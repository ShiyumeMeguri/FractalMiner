// HGRP Water Decal — screen-space deferred water-surface decal (3 passes: WaterDecal color, WaterDecalDisplacement height, WaterDecalDeferred stencil-gated color).
// A unit plane/box decal volume rasterized Cull [_CullMode] / ZTest [_ZTest] / ZWrite Off: each fragment reconstructs the
// underlying surface world position from the camera depth buffer, transforms it into the decal's object space, box-clips to
// [-0.5,0.5]^3 (Box mesh only), edge-fades, and writes the decal color into the water G-buffer (multi-RT ColorMask in source).
//
// Merged from: ReferenceProjects/RuriBeyondShader/.../materials/water/waterdecal.shader (HGRP fork of HDRP).
//   Pass0 "WaterDecal"             base ground truth: waterdecal/Sub0_Pass0_Vertex_b15.hlsl + Sub0_Pass0_Fragment_b16.hlsl (catch-all #else).
//   Pass1 "WaterDecalDisplacement" base ground truth: waterdecal/Sub0_Pass1_Vertex_b63.hlsl + Sub0_Pass1_Fragment_b64.hlsl (catch-all #else; base emits a flat displacement marker).
//   Pass2 "WaterDecalDeferred"     SAME blobs as Pass0 (skeleton selects Sub0_Pass2_Vertex_b15 / Sub0_Pass2_Fragment_b16) + a Stencil Comp Equal gate.
//   Keyword delta inspected: Sub0_Pass0_Fragment_b18.hlsl (_BLEND_BASECOLOR) for the BaseColorMap sample + UV-switch + tint path;
//                            Sub0_Pass1_Fragment_b94.hlsl (_BLEND_DISPLACEMENT, min variant also carries _USE_DISTURB/_USE_MASK) for the
//                            displacement-map channel-select + acid bubble height stack (material-texture math PORTED; the water-LOD
//                            reprojection matrix + _WaterData_WaterLODParam1 sim-scale + CB1_m0/_FlowOffset flow-field warp remain engine-side).
// Keywords (exposed as shader_feature_local): _BLEND_BASECOLOR, _BLEND_DISPLACEMENT.
//   (Source also multi_compile_local's _BLEND_BASECOLOR2, _USE_SEQUENCE_FRAME, _USE_DISTURB, _USE_MASK, _USE_DISSOLVE,
//    _USE_TWO_LAYER_FLOATING_MAP, _USE_SOFTBLEND, _USE_WATER_EROSION, _USE_BUBBLE — those feature stacks are documented gaps, see below.)
// Kept (1:1 math, cited per block against the blobs):
//   - Vertex: unit-mesh -> per-instance decal objectToWorld -> clip; inverse-decal-basis rows packed (col/dot(col,col)) with
//     translation in .w (Vertex_b15:93-109), positionOS + positionWS + uv + instanceID passthrough.
//   - Fragment: camera-depth world-position reconstruction (inverse view-proj, Fragment_b16:101-110), WS->decal-object projection
//     via the packed inverse rows (b16:111-113), box membership clip gated by _MeshType!=0 (b16:114), edge-fade
//     (abs(localUV-0.5)+range, 1 - sqrt2*len, b16:115-117), discard epsilon 1e-4 when BlendMode>0.5 (b16:118),
//     per-instance opacity (_OverallOpacity * animParam0.z * animParam0.w, b16:121-124), out.a = 1 - BlendMode (b16:125).
//   - _BLEND_BASECOLOR: Mesh/Polar/World/inputMesh UV switch lerp chain (Fragment_b18:137-150, atan2 minimax poly), animated
//     BaseColorMap sample with _ST + speed*animParam scroll + mip bias (b18:152), UseAChannelAsAlpha, tint blend mad(tex*aFac, tint, baseColor) (b18:153-160).
//   - Displacement pass base: flat displacement marker float4(0, value, 0, 1-BlendMode) with distance-fade + edge-fade discard (Fragment_b64:97-126).
//   - _BLEND_DISPLACEMENT: _DisplacementMap (T3) 4-way channel select (b94:223-224) -> length(_AcidTexture(T2).xyz) * ((chan + _DisplacementSwitchUV)
//     * _FlowmapUVNoiseStrength) (b94:224) -> bubble lerp by _BubbleSpeed via _AcidTexture.a (b94:225); UV = decal-projected switch UV
//     (DecalSwitchUV) + _ST + _DecalCustomTime scroll; out = (_OverallOpacity*animFade) * edgeFade * (distFade * [waterLODScale]) * height * animAlpha (b94:225).
//     The flow-field UV warp + water-LOD reprojection + _WaterData_WaterLODParam1 sim-scale are engine-side (see gaps); LOD scale = 1.0.
// Removed (pixel-neutral pipeline infra substituted by URP or dropped):
//   - SPIRV-Cross plumbing (gl_FragCoord / SPIRV_Cross_* / static I/O / discard_state -> clip()); denormalized-float magic literals (decoded inline).
//   - HGRP per-decal-instance buffer (_WaterDecal_waterDecalArray[32] indexed by SV_InstanceID, + the CB1_m0[314] per-draw matrix array):
//     no URP equivalent. objectToWorld -> URP unity_ObjectToWorld; the per-instance animParam fields (animParam0.z/.w fade/alpha,
//     param1.w custom-time) -> [HideInInspector] uniforms _DecalAnimFade / _DecalAnimAlpha / _DecalCustomTime so the math is 1:1 (single instance).
//   - HGRP global cbuffer (_InvViewProjMatrix / _ScreenSize / _WorldSpaceCameraPos_Internal / _Time / _VFXParams0.w / _GlobalMipBias)
//     -> UNITY_MATRIX_I_VP / _CameraDepthTexture_TexelSize / _WorldSpaceCameraPos / _Time / _DecalCustomTime / 0.
//   - Pass0 source vertex bakes the clip position through a CB1_m0 per-draw matrix then a SECOND decalArray[2] matrix
//     (HGRP two-stage decal placement); the Displacement vertex (b63) uses the single decalArray[instance] objectToWorld then a
//     _WaterLODViewProjMatrix. URP rasterizes the projector mesh straight object->world->clip (TransformObjectToWorld/HClip);
//     the load-bearing per-pixel work (depth reconstruct + decal-space project + clip + fade) is 1:1 in the fragment.
//   - Source multi-RT decal G-buffer (Blend 0/1/2 with separate ColorMask RGB/R/RGB writing decal normal/base/mask atlases) ->
//     URP single bound target keeps RT0's premultiplied-style blend + ColorMask RGB. See gaps.
//
// NOTE: This is a SCREEN-SPACE DEFERRED DECAL, not a lit/PBR surface — no GetMainLight / BRDF / SH, so _core/CoreMath is intentionally NOT included.
// NOTE: _CameraDepthTexture must be available (URP DepthTexture enabled / decal renderer-feature event). Source point/linear-clamp samples it.
// NOTE: _BlendMode (0=Alpha, 1=Additive) drives out.a = 1 - _BlendMode (Additive -> a=0); _MeshType (0=Plane, 1=Box) gates the box clip.
// Texture channel legend: camera depth = URP _CameraDepthTexture (source T0). _BaseColorMap = decal albedo (source T1, _BLEND_BASECOLOR), .a optionally alpha.

Shader "HGRP/WaterDecal_Fix" {
    Properties {
        [Header(Main Properties)]
        [Enum(Plane, 0, Box, 1)] _MeshType ("Mesh Type", Float) = 0
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        _UVScaleOffset ("UV Scale Offset", Vector) = (1, 1, 0, 0)
        [ToggleUI] _UseEdgeFade ("Use Edge Fade", Float) = 1
        _EdgeFadeRange ("Edge Fade Range", Vector) = (0, 0, 0, 0)
        _OverallOpacity ("Overall Opacity", Range(0, 1)) = 1
        _MinMipLevel ("Min Mip Level", Range(0, 5)) = 0
        _BaseColor ("Base Color", Color) = (0, 0, 0, 0)
        _DistanceFade ("Distance Fade", Float) = 300
        _Bias ("Mipmap Sample Bias", Float) = 0

        [Header(Base Color)]
        [Toggle(_BLEND_BASECOLOR)] _BlendBaseColor ("Blend BaseColor", Float) = 0
        [Enum(MeshUV, 0, PolarUV, 1, WorldUV, 2, InputMeshUV, 3)] _BaseColorSwitchUV ("BaseColor UV Switcher", Float) = 0
        [ToggleUI] _MainTexUseDisturb ("Main Tex Use Disturb", Float) = 1
        _BaseColorMap ("BaseColorMap", 2D) = "white" {}
        _BaseColorSpeed ("Color Map Move Speed", Vector) = (0, 0, 0, 0)
        [ToggleUI] _UseAChannelAsAlpha ("Use MainTex.a As Alpha", Float) = 1
        [HDR] _BaseColorTint ("Tint", Color) = (1, 1, 1, 1)

        [Header(Displacement)]
        [Toggle(_BLEND_DISPLACEMENT)] _BlendDisplacement ("Blend Displacement", Float) = 0
        // NOTE: the source decompile reuses the name "_DisplacementSwitchUV" for TWO entities: the skeleton property is the UV-switcher
        //   ENUM (here named _DisplacementSwitchUVMode to disambiguate), while the b94 c19.y packing slot is the additive HEIGHT BIAS
        //   (kept as _DisplacementSwitchUV). b94's displacement-map UV is actually routed through _DisturbSwitchUV because the min
        //   shipped variant co-activates _USE_DISTURB; for a clean _BLEND_DISPLACEMENT path the displacement's own UV enum drives it.
        [Enum(MeshUV, 0, PolarUV, 1, WorldUV, 2, InputMeshUV, 3)] _DisplacementSwitchUVMode ("Displacement UV Switcher", Float) = 0
        _DisplacementMap ("DisplacementMap", 2D) = "white" {}
        _DisplacementMapSpeed ("Displacement Map Move Speed", Vector) = (0, 0, 0, 0)
        _DisplacementBias ("Displacement Mipmap Bias", Float) = 0
        [Enum(BaseColorR, 0, BaseColorG, 1, BaseColorB, 2, BaseColorA, 3)] _DisplacementMapChannelSwitch ("Displacement Channel", Float) = 0
        _DisplacementSwitchUV ("Displacement Height Bias", Float) = 0           // b94:224 additive term inside the height scale ((chan + _DisplacementSwitchUV) * _FlowmapUVNoiseStrength)
        _FlowmapUVNoiseStrength ("Displacement Height Scale", Float) = 0         // b94:224 multiplies the channel-selected displacement height
        _AcidTexture ("Acid/Bubble Tex", 2D) = "white" {}
        _BubbleHeightScale ("Bubble Height Scale", Range(0, 2)) = 0
        _BubbleSpeed ("Bubble Speed", Range(0, 2)) = 0

        // --- Per-instance decal feed (HGRP waterDecalArray; no URP equivalent). Single-instance mapping. ---
        // ENGINE-SIDE: normally bound per-instance by the HGRP water-decal renderer (waterDecalArray SV_InstanceID buffer);
        //   exposed as [HideInInspector] single-instance uniforms so the per-pixel math is 1:1 (host renderer feature feeds them).
        [HideInInspector] _DecalAnimFade ("Decal Anim Fade (animParam0.z)", Float) = 1   // waterDecalArray[i].animParam0.z (Fragment_b16:121)
        [HideInInspector] _DecalAnimAlpha ("Decal Anim Alpha (animParam0.w)", Float) = 1  // waterDecalArray[i].animParam0.w (Fragment_b16:122)
        [HideInInspector] _DecalCustomTime ("Decal Custom Time (param1.w)", Float) = 0     // waterDecalArray[i].param1.w / animParam0.y custom-time (Fragment_b18:152)

        // --- Render-state plumbing (driven by material editor; source had _ZTest/_ZTestMobile/_CullMode/_IgnoreZTest) ---
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _CullMode ("__cull", Float) = 2
    }

    SubShader {
        Tags {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
        }
        LOD 600

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

        CBUFFER_START(UnityPerMaterial)
            // Core decal scalars (source type_UnityPerMaterial, Fragment_b16:38-47).
            float _OverallOpacity;
            float _UseEdgeFade;
            float _MinMipLevel;
            float _BlendMode;
            float _MeshType;
            float _Bias;
            float _DistanceFade;
            float4 _BaseColor;
            float4 _EdgeFadeRange;
            float4 _UVScaleOffset;
            // _BLEND_BASECOLOR scalars (Fragment_b18:52-57).
            float _UseAChannelAsAlpha;
            float _MainTexUseDisturb;
            float _BaseColorSwitchUV;
            float4 _BaseColorTint;
            float4 _BaseColorSpeed;
            float4 _BaseColorMap_ST;
            // Per-instance decal feed (source waterDecalArray; single-instance).
            float _DecalAnimFade;
            float _DecalAnimAlpha;
            float _DecalCustomTime;
            // _BLEND_DISPLACEMENT scalars (Fragment_b94 type_UnityPerMaterial c5,c14,c17-19).
            float _DisplacementSwitchUVMode;
            float _DisplacementMapChannelSwitch;   // b94:223-224 channel select (R/G/B/A)
            float _DisplacementBias;               // b94:207 displacement-map mip = floor(_DisplacementBias) (source slot _EdgeSharp3)
            float _DisplacementSwitchUV;           // b94:224 additive bias inside the height scale
            float _FlowmapUVNoiseStrength;         // b94:224 height scale multiplier
            float _BubbleHeightScale;              // b94:225 bubble height scale (unused-by-b94 path kept for parity)
            float _BubbleSpeed;                    // b94:225 bubble lerp factor
            float4 _DisplacementMapSpeed;          // b94 scroll speed (decal-custom-time scrolled)
            float4 _DisplacementMap_ST;
            float4 _AcidTexture_ST;                // b94:220-221 acid UV _ST
        CBUFFER_END

        TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);
        TEXTURE2D(_DisplacementMap); SAMPLER(sampler_DisplacementMap); // source T3 (sampler_LinearRepeat) b94:95,207
        TEXTURE2D(_AcidTexture);    SAMPLER(sampler_AcidTexture);      // source T2 (sampler_LinearRepeat) b94:94,221

        // ---- magic-constant decodes (cites against Fragment_b16 / Fragment_b18) ----
        static const float EDGE_FADE_SLOPE = 1.41419994831085205078125;            // ~sqrt(2) edge-fade falloff slope (b16:117)
        static const float DISCARD_EPS     = 9.9999997473787516355514526367188e-05; // = 1e-4 discard epsilon (b16:118)
        static const float HALF_PI         = 1.57079637050628662109375;            // pi/2  (b18:143)
        static const float PI_CONST        = 3.1415927410125732421875;             // pi    (b18:145)
        static const float INV_TWO_PI      = 0.15915493667125701904296875;         // 1/(2*pi) (b18:145)
        // atan2 minimax poly coefficients (b18:142).
        static const float ATAN_C0 = 0.087292902171611785888671875;
        static const float ATAN_C1 = -0.3018949925899505615234375;

        // atan2(y, x) reconstructed exactly as the decompiler emits it (radians).
        // Source spelling (Fragment_b18:138-145): t = (|small|/|large|), poly = ((t^2*C0 + C1)*t^2 + 1),
        //   core = (|t|<1) ? t*poly : (pi/2 - poly*t) ; sign via asfloat((x>=0)?PI:-PI) gated by (y<0).
        // POS_PI = asfloat(1078530010u) = +pi ; NEG_PI = asfloat(3226013658u) = -pi.
        float Atan2Src(float y, float x)
        {
            float ratio = x / y;                                  // _252 = _212/_213 (b18:138)  [note: arg order matches source _212=x-edge,_213=y-edge]
            bool small = abs(ratio) < 1.0;                        // _254 (b18:139)
            float t = small ? abs(ratio) : (1.0 / abs(ratio));    // _258 (b18:140)
            float t2 = t * t;                                     // _259 (b18:141)
            float poly = mad(mad(t2, ATAN_C0, ATAN_C1), t2, 1.0); // _263 (b18:142)
            float core = small ? (t * poly) : mad(-poly, t, HALF_PI); // _271 (b18:143)
            float posPi = asfloat(1078530010u);                   // +pi  (b18:145)
            float negPi = asfloat(3226013658u);                   // -pi  (b18:145)
            float signPi = (x >= 0.0) ? posPi : negPi;            // asfloat((_212>=0)?1078530010u:3226013658u) (b18:145)
            float yMask  = asfloat(((y < 0.0) ? 0xFFFFFFFFu : 0u) & 1065353216u); // ((_213<0)?-1:0) & 1.0f -> 1.0 when y<0 else 0 (b18:145)
            float coreSigned = (ratio < 0.0) ? (-core) : core;    // (_252<0) ? -_271 : _271 (b18:145)
            return mad(signPi, yMask, coreSigned);                // mad(signPi, yMask, coreSigned) (b18:145)
        }

        // -----------------------------------------------------------------------------------------
        // Shared decal kernel: reconstruct surface WS from depth, project to decal-object space,
        // box-clip, edge-fade. Returns the decal-local coords + edge fade; out 'discardPixel' tells the
        // caller to clip(). 1:1 with Fragment_b16:101-118 (Pass0/Pass2 base) — the Displacement base (b64)
        // adds a camera distance-fade term to the discard, handled by the 'useDistanceFade' branch.
        // -----------------------------------------------------------------------------------------
        struct DecalSample
        {
            float3 localP;     // decal-object-space position (_146/_155/_164 in b16 = localX/Y/Z)
            float3 surfaceWS;  // reconstructed world position (_132/_133/_134)
            float  edgeFade;   // _234 edge fade
            float  distFade;   // _278 camera distance fade (1.0 when useDistanceFade=false; b64:122)
            float2 edgeUV;     // (_212,_213) centered decal UV used by the BaseColor UV-switch
            float2 rawUV;      // (_210,_211) un-centered decal UV
        };

        DecalSample SampleDecal(float4 positionCS, bool useDistanceFade, out bool discardPixel)
        {
            DecalSample s = (DecalSample)0;
            s.distFade = 1.0; // identity unless the distance-fade branch overwrites it (b64:122)
            discardPixel = false;

            // ===== Reconstruct world position of the underlying surface from depth (b16:101-110). =====
            // Source: screenUV = fragCoord * _ScreenSize.zw ; depth = T0.SampleLevel(LinearClamp, screenUV).x ;
            //   ndc = (screenUV*2-1) with Y negated ; worldH = _InvViewProjMatrix * (ndc.x, ndc.y, depth, 1).
            float2 screenUV = positionCS.xy * _CameraDepthTexture_TexelSize.xy; // fragCoord * (1/w, 1/h) (b16:101-102)
            float rawDepth  = SampleSceneDepth(screenUV);                       // T0.SampleLevel(LinearClamp).x (b16:104)
            float ndcX = mad(screenUV.x, 2.0, -1.0);                            // _63 (b16:103)
            float ndcY = mad(screenUV.y, 2.0, -1.0);                            // (b16:106 before the Y flip)
            // Source (b16:106) hard-negates Y because HGRP's _InvViewProjMatrix wants bottom-left NDC. URP's
            // unity_MatrixInvVP bakes the GL clip-flip into the projection matrix, so the equivalent flip is the
            // platform-guarded one URP itself uses (ComputeClipSpacePosition, Common.hlsl). On Vulkan/D3D
            // (UNITY_UV_STARTS_AT_TOP=1) this is the same -Y as the source; the guard keeps it correct on GL too.
        #if UNITY_UV_STARTS_AT_TOP
            ndcY = -ndcY; // _73 = (-0.0f) - mad(_61,2,-1) (b16:106)
        #endif
            float4 worldH = mul(UNITY_MATRIX_I_VP, float4(ndcX, ndcY, rawDepth, 1.0)); // b16:107-110
            s.surfaceWS = worldH.xyz / worldH.w;

            // ===== World -> decal object space (b16:108-113: (surfaceWS - col.w) projected on packed inverse rows). =====
            // URP: unity_WorldToObject already IS the packed inverse decal basis; one matrix-multiply reproduces the
            // hand-unrolled row = objectToWorld_col / dot(col,col) ; dot(row, surfaceWS - translation).
            float3 localP = mul(unity_WorldToObject, float4(s.surfaceWS, 1.0)).xyz;
            s.localP = localP;
            float lx = localP.x; // _142/_146 localX
            float ly = localP.y; // _151/_155 localY
            float lz = localP.z; // _160/_164 localZ

            // ===== Box membership clip, only when _MeshType != 0 (Box) (b16:114). =====
            // Source: discard when (MeshType!=0) AND NOT( all(|local| < 0.5) ). all-inside = (l<0.5) & (-0.5<l) per axis.
            bool inside = (lx < 0.5) && (ly < 0.5) && (lz < 0.5)
                       && ((-0.5) < lx) && ((-0.5) < ly) && ((-0.5) < lz);
            if ((_MeshType != 0.0) && !inside)
            {
                discardPixel = true; // discard_cond (b16:114)
            }

            // ===== Edge fade (b16:115-117). =====
            // raw UV: mad(local + 0.5, scale, offset) ; edge dist: abs(rawUV - 0.5) + edgeRange ;
            // fade = useEdgeFade ? max(1 - sqrt(dot(e,e))*EDGE_FADE_SLOPE, 0) : 1.
            float rawU = mad(lx + 0.5, _UVScaleOffset.x, _UVScaleOffset.z); // _210 (b18:129) / _220 inner (b16:115)
            float rawV = mad(lz + 0.5, _UVScaleOffset.y, _UVScaleOffset.w); // _211 (b18:130)
            s.rawUV  = float2(rawU, rawV);
            float eU = rawU + (-0.5); // _212 (b18:131)
            float eV = rawV + (-0.5); // _213 (b18:132)
            s.edgeUV = float2(eU, eV);
            float e0 = abs(eU) + _EdgeFadeRange.x; // _220/_224 (b16:115 / b18:133)
            float e1 = abs(eV) + _EdgeFadeRange.y; // _221/_225 (b16:116 / b18:134)
            float fade = (_UseEdgeFade != 0.0)
                       ? max(mad(-sqrt(dot(float2(e0, e1), float2(e0, e1))), EDGE_FADE_SLOPE, 1.0), 0.0)
                       : 1.0; // _234/_238 (b16:117 / b18:135)
            s.edgeFade = fade;

            // ===== Discard on fade / distance, gated by BlendMode > 0.5 (Additive) (b16:118 ; b64:122 adds distance). =====
            // Base color pass (b16:118): discard if (fade <= 1e-4) && (BlendMode > 0.5).
            // Displacement base (b64:122): discard if ((distFade <= 1e-4) || (fade<=1e-4 && useEdgeFade)) && (BlendMode > 0.5).
            bool fadeKill = (DISCARD_EPS >= fade);
            if (useDistanceFade)
            {
                float3 rel = s.surfaceWS - _WorldSpaceCameraPos; // _247/_248/_249 (b64:119-121)
                float distFade = (-clamp(length(rel) / _DistanceFade, 0.0, 1.0)) + 1.0; // _278 (b64:122)
                s.distFade = distFade; // expose to the displacement height (b94:225 uses _278)
                bool distKill = (DISCARD_EPS >= distFade);
                bool edgeKill = fadeKill && (_UseEdgeFade != 0.0);
                if ((distKill || edgeKill) && (_BlendMode > 0.5))
                {
                    discardPixel = true;
                }
            }
            else
            {
                if (fadeKill && (_BlendMode > 0.5))
                {
                    discardPixel = true; // discard_cond (b16:118)
                }
            }
            return s;
        }

        // BaseColor UV switch (Fragment_b18:137-150): selects among MeshUV(0)/PolarUV(1)/WorldUV(2)/InputMeshUV(3)
        // via two clamped lerp gates. Returns the UV fed to the BaseColorMap sample BEFORE _ST/scroll.
        //   uvSwitch=0 -> rawUV (mesh-projected decal UV).
        //   uvSwitch=1 -> polar: U = lerp(rawU, (atan2(...)+pi)/(2pi), 1) ; V = lerp(rawV, 2*radius, 1).
        //   uvSwitch=2 -> world: lerp toward surfaceWS.xz * 0.1.
        //   uvSwitch=3 -> input mesh UV (interpolated TEXCOORD0).
        // Parameterized UV-switch core: the blob emits the identical gate1/gate2 fold for every per-feature
        // *SwitchUV value (BaseColor uses _BaseColorSwitchUV b18:145-152; Displacement/Acid reuse it with
        // _DisplacementSwitchUVMode, b94:189-194). 'switchVal' is the raw enum-as-float gate.
        float2 DecalSwitchUV(DecalSample s, float2 meshUV0, float switchVal)
        {
            float eU = s.edgeUV.x;   // _212/_225
            float eV = s.edgeUV.y;   // _213/_226
            float rawU = s.rawUV.x;  // _210/_222
            float rawV = s.rawUV.y;  // _211/_224
            // polar angle/radius (b18:144-146 ; b94:183-188).
            float angle = Atan2Src(eV, eU);                  // _271 core feeds _302 (b18:143-145)
            float polarU = (angle + PI_CONST) * INV_TWO_PI;  // (_271-sign + pi) * 1/2pi (b18:145)
            float radius = sqrt(dot(float2(eU, eV), float2(eU, eV))); // _292/_332 (b18:144 / b94:184)
            float polarV = radius + radius;                  // _303/_340 inner (b18:146 / b94:188)
            // Blend chain exactly as the blob folds it (NOT a clean lerp ladder; the first factor is the raw switch value):
            //   uPolar = lerp(rawU, polar, switchVal)   [factor = full switch, _302/_345]
            //   uWorld = lerp(uPolar, world, gate1=clamp(switch-1,0,1))   [_317/_362]
            //   outUV  = lerp(uWorld, meshUV0, gate2=clamp(switch-2,0,1)) [inner mad with gate2]
            // At enum values 0/1/2/3 this resolves to mesh/polar/world/inputMesh respectively.
            float gate1 = clamp((-1.0) + switchVal, 0.0, 1.0); // _310/_355 (b18:147 / b94:191)
            float gate2 = clamp((-2.0) + switchVal, 0.0, 1.0); // _311/_356 (b18:148 / b94:192)
            float uPolar = mad(switchVal, (-rawU) + polarU, rawU); // _302/_345 (b18:145 / b94:189)
            float vPolar = mad(switchVal, (-rawV) + polarV, rawV); // _303/_346 (b18:146 / b94:190)
            float uWorld = mad(gate1, mad(s.surfaceWS.x, 0.100000001490116119384765625, -uPolar), uPolar); // _317/_362 (b18:149 / b94:193)
            float vWorld = mad(gate1, mad(s.surfaceWS.z, 0.100000001490116119384765625, -vPolar), vPolar); // _318/_363 (b18:150 / b94:194)
            // gate2 selects input-mesh UV (TEXCOORD0) over the computed UV (b18:152 / b94 inner mad with gate2).
            float2 outUV;
            outUV.x = mad(gate2, (-uWorld) + meshUV0.x, uWorld); // b18:152 U
            outUV.y = mad(gate2, (-vWorld) + meshUV0.y, vWorld); // b18:152 V
            return outUV;
        }

        float2 BaseColorSwitchUV(DecalSample s, float2 meshUV0)
        {
            return DecalSwitchUV(s, meshUV0, _BaseColorSwitchUV); // base path unchanged (b18:145-152)
        }
        ENDHLSL

        // ============================================================================================
        // Pass 0 — "WaterDecal" : base color decal. Source multi-RT (Blend 0/1/2 + ColorMask RGB/R/RGB)
        // collapsed to single RT0 (premultiplied-style One OneMinusSrcAlpha) + ColorMask RGB. (skeleton 129-269)
        // ============================================================================================
        Pass {
            Name "WaterDecal"
            Blend One OneMinusSrcAlpha, One OneMinusSrcAlpha
            ColorMask RGB
            ZClip On
            ZTest [_ZTest]
            ZWrite Off
            Cull [_CullMode]
            // Source LightMode "WaterDecal" (HGRP water-decal renderer event) -> URP SRPDefaultUnlit. NOTE: all three
            // passes below necessarily share SRPDefaultUnlit (URP has no WaterDecal/Displacement/Deferred render events),
            // so under the stock URP pipeline ONLY this pass (the first SRPDefaultUnlit match) is drawn. Pass1/Pass2 are
            // inert until a custom URP renderer feature invokes them by name into their own RTs. (documented gap)
            Tags { "LightMode" = "SRPDefaultUnlit" }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _BLEND_BASECOLOR

            struct Attributes
            {
                float3 positionOS : POSITION;
                float2 uv0        : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv0        : TEXCOORD0; // source TEXCOORD_5 = mesh UV0 (Vertex_b15:110-111)
            };

            // Vertex: rasterize the projector volume so the fragment's depth-reconstruction runs over its screen footprint.
            // Source (Vertex_b15:73-112) bakes clip pos through a CB1 per-draw matrix then decalArray[2] objectToWorld (HGRP
            // two-stage placement); URP rasterizes object->world->clip directly. uv0 + positionOS passthrough preserved.
            Varyings vert(Attributes input)
            {
                Varyings o = (Varyings)0;
                float3 posWS = TransformObjectToWorld(input.positionOS);
                o.positionCS = TransformWorldToHClip(posWS);
                o.uv0 = input.uv0; // TEXCOORD_5 (b15:110-111)
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                bool discardPixel;
                DecalSample s = SampleDecal(input.positionCS, /*useDistanceFade=*/false, discardPixel);
                clip(discardPixel ? -1.0 : 1.0);

                // per-instance opacity (b16:121): _OverallOpacity * animParam0.z.
                float opacity = _OverallOpacity * _DecalAnimFade; // _266 / _417 (b16:121, b18:156)

            #ifdef _BLEND_BASECOLOR
                // ===== Animated BaseColorMap sample (Fragment_b18:151-160). =====
                // UV = BaseColorSwitchUV * _ST + speed*animParam-scroll ; mip bias = floor(_MinMipLevel)+floor(_Bias).
                float2 uvSel = BaseColorSwitchUV(s, input.uv0);
                // scroll: mad(speed * customTime, animParam0.y, uvSel*_ST.xy + _ST.zw). Source folds animParam0.x/.y; with
                // single-instance customTime feed -> _DecalCustomTime. (b18:152)
                float2 uv;
                uv.x = mad(_DecalCustomTime * _BaseColorSpeed.x, 1.0, mad(uvSel.x, _BaseColorMap_ST.x, _BaseColorMap_ST.z)); // b18:152 U
                uv.y = mad(_DecalCustomTime * _BaseColorSpeed.y, 1.0, mad(uvSel.y, _BaseColorMap_ST.y, _BaseColorMap_ST.w)); // b18:152 V
                float mipBias = floor(_MinMipLevel) + floor(_Bias); // b18:152
                float4 tex = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uv, mipBias); // T1.SampleBias (b18:152)
                float texAm1 = tex.w + (-1.0);                       // _382 (b18:153)
                float aFac   = mad(_UseAChannelAsAlpha, texAm1, 1.0); // _386 (b18:154)
                float aOut   = mad(_UseAChannelAsAlpha, texAm1, 2.0); // _387 (b18:155)
                // out.rgb = opacity * edgeFade * aOut * mad(aFac*tex.rgb, tint, baseColor) * animParam0.w (b18:157-159).
                float3 colorRGB = float3(
                    mad(aFac * tex.x, _BaseColorTint.x, _BaseColor.x),
                    mad(aFac * tex.y, _BaseColorTint.y, _BaseColor.y),
                    mad(aFac * tex.z, _BaseColorTint.z, _BaseColor.z));
                float3 outRGB = (opacity * (s.edgeFade * (aOut * colorRGB))) * _DecalAnimAlpha;
                float outA = (1.0 + (-_BlendMode)) * aOut; // _387-scaled (b18:160)
                return half4(outRGB, outA);
            #else
                // ===== Base (no BaseColorMap) : flat BaseColor decal (Fragment_b16:121-125). =====
                // out.rgb = (edgeFade * BaseColor.rgb) * opacity * animParam0.w ; out.a = 1 - BlendMode.
                float3 outRGB = ((s.edgeFade * _BaseColor.xyz) * opacity) * _DecalAnimAlpha; // _SV.x/y/z (b16:122-124)
                float outA = 1.0 + (-_BlendMode); // _SV.w (b16:125)
                return half4(outRGB, outA);
            #endif
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 1 — "WaterDecalDisplacement" : writes a displacement/height marker. Source base (Fragment_b64)
        // emits a flat float4(0, 1, 0, 1-BlendMode) with the distance-fade + edge-fade discard; the real
        // displacement/flow/bubble height stack lives in the _BLEND_DISPLACEMENT delta blobs (documented gap).
        // ============================================================================================
        Pass {
            Name "WaterDecalDisplacement"
            // Source Pass1 has NO ColorMask (waterdecal.shader:273-277): the displacement RT is written RGBA
            // (G = height marker, A = 1-BlendMode). Do NOT mask to RGB here — that would drop the A write. (1:1 render-state)
            Blend One OneMinusSrcAlpha, One OneMinusSrcAlpha
            ZClip On
            ZTest [_ZTest]
            ZWrite Off
            Cull [_CullMode]
            Tags { "LightMode" = "SRPDefaultUnlit" }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _BLEND_DISPLACEMENT

            struct Attributes
            {
                float3 positionOS : POSITION;
                float2 uv0        : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv0        : TEXCOORD0;
            };

            // Vertex: source (Vertex_b63:73-105) transforms unit mesh by decalArray[instance].objectToWorld then a water-LOD
            // view-proj matrix; URP rasterizes object->world->clip. uv0 passthrough preserved.
            Varyings vert(Attributes input)
            {
                Varyings o = (Varyings)0;
                float3 posWS = TransformObjectToWorld(input.positionOS);
                o.positionCS = TransformWorldToHClip(posWS);
                o.uv0 = input.uv0;
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                bool discardPixel;
                // Displacement base uses the distance-fade discard variant (b64:119-122).
                DecalSample s = SampleDecal(input.positionCS, /*useDistanceFade=*/true, discardPixel);
                clip(discardPixel ? -1.0 : 1.0);

            #ifdef _BLEND_DISPLACEMENT
                // ===== Displacement height stack (Fragment_b94:207-225). =====
                // Ported 1:1: _DisplacementMap (T3) 4-channel select -> length(_AcidTexture.xyz)*((chan+bias)*scale) ->
                //   bubble lerp by _BubbleSpeed via _AcidTexture.a. The per-instance opacity/edge/distance gates reuse SampleDecal.
                // ENGINE-SIDE (dropped, named below): the displacement-map/acid UV in the blob is warped by the HGRP water FLOW
                //   FIELD (CB1_m0[i*10+6/7] per-draw flow constants + _FlowOffset.zw flow vector, b94:207/220) and the height is
                //   reconstructed in the WATER-LOD reprojected space (_WaterData_WaterLODInvViewProjMatrix) and scaled by the
                //   water-LOD sim parameter _WaterData_WaterLODParam1.x (b94:148-157,225). Those come ONLY from the HGRP water
                //   simulation / water-LOD render pass (type_WaterData GPU buffer); under URP they are unavailable, so the flow
                //   warp term is omitted and the LOD scale is identity (1.0). The MATERIAL-texture height math is exact.
                float2 dispUVbase = DecalSwitchUV(s, input.uv0, _DisplacementSwitchUVMode);    // b94:189-194 (UV switch)
                // Decal-custom-time scroll (material part of the blob's UV; the engine FLOW warp is dropped, see above). b94:207
                float2 dispUV;
                dispUV.x = mad(_DecalCustomTime * _DisplacementMapSpeed.x, 1.0, mad(dispUVbase.x, _DisplacementMap_ST.x, _DisplacementMap_ST.z));
                dispUV.y = mad(_DecalCustomTime * _DisplacementMapSpeed.y, 1.0, mad(dispUVbase.y, _DisplacementMap_ST.y, _DisplacementMap_ST.w));
                float4 dispTex = SAMPLE_TEXTURE2D_BIAS(_DisplacementMap, sampler_DisplacementMap, dispUV, floor(_DisplacementBias)); // T3.SampleBias, mip=floor(_EdgeSharp3 slot) (b94:207)
                // 4-way channel select R->G->B->A via the clamped (switch-0/-1/-2) gate fold (b94:223-224).
                float dChan = mad(clamp(_DisplacementMapChannelSwitch, 0.0, 1.0), (-dispTex.x) + dispTex.y, dispTex.x); // _603 (b94:223)
                dChan = mad(clamp((-1.0) + _DisplacementMapChannelSwitch, 0.0, 1.0),
                            (-dChan) + mad(clamp((-2.0) + _DisplacementMapChannelSwitch, 0.0, 1.0), (-dispTex.z) + dispTex.w, dispTex.z),
                            dChan); // _chan (b94:224)
                float2 acidUV;
                acidUV.x = mad(_DecalCustomTime * _DisplacementMapSpeed.x, 1.0, mad(dispUVbase.x, _AcidTexture_ST.x, _AcidTexture_ST.z)); // b94:220 (flow/bubble-random warp -> engine-side, dropped)
                acidUV.y = mad(_DecalCustomTime * _DisplacementMapSpeed.y, 1.0, mad(dispUVbase.y, _AcidTexture_ST.y, _AcidTexture_ST.w)); // b94:221
                float4 acid = SAMPLE_TEXTURE2D_BIAS(_AcidTexture, sampler_AcidTexture, acidUV, floor(_Bias)); // T2.SampleBias, mip=floor(_Bias) (b94:221)
                // height = |acid.xyz| * ((chan + _DisplacementSwitchUV) * _FlowmapUVNoiseStrength) (b94:224 _621).
                float heightCore = sqrt(dot(acid.xyz, acid.xyz)) * ((dChan + _DisplacementSwitchUV) * _FlowmapUVNoiseStrength); // _621 (b94:224)
                // bubble lerp: lerp(heightCore, heightCore*acid.w, _BubbleSpeed) (b94:225 mad(_BubbleSpeed, mad(_621,_589.w,-_621), _621)).
                float bubbleHeight = mad(_BubbleSpeed, mad(heightCore, acid.w, -heightCore), heightCore); // b94:225
                // ENGINE-SIDE water-LOD sim scale _WaterData_WaterLODParam1.x -> identity (HGRP water-LOD pass fills it). b94:225
                float waterLODScale = 1.0; // TODO(engine-side): _WaterData_WaterLODParam1.x from the HGRP water-LOD render pass (type_WaterData GPU buffer).
                float dispOpacity = _OverallOpacity * _DecalAnimFade; // _OverallOpacity * CB1_m0[i*10+6].z (b94:225)
                float height = (dispOpacity * (s.edgeFade * ((s.distFade * waterLODScale) * bubbleHeight))) * _DecalAnimAlpha; // * CB1_m0[i*10+7].x (b94:225)
                return half4(height, 1.0, 0.0, 1.0 + (-_BlendMode)); // SV_Target = (height, 1, 0, 1-BlendMode) (b94:225-228: .x=height stack, .y=1, .z=0, .w=1-BlendMode)
            #else
                // Base displacement marker (Fragment_b64:123-126): float4(0, 1, 0, 1 - BlendMode).
                return half4(0.0, 1.0, 0.0, 1.0 + (-_BlendMode));
            #endif
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2 — "WaterDecalDeferred" : identical HLSL to Pass0 (skeleton selects the SAME blob ids
        // Sub0_Pass2_*_b15/b16), differing only in render-state: adds a Stencil Comp Equal gate (water
        // surface bit). Source: Blend 0 One OneMinusSrcAlpha + ColorMask RGB + Stencil{Ref 1 ReadMask 1 Comp Equal}.
        // (skeleton 425-569)
        // ============================================================================================
        Pass {
            Name "WaterDecalDeferred"
            Blend One OneMinusSrcAlpha, One OneMinusSrcAlpha
            ColorMask RGB
            ZClip On
            ZTest [_ZTest]
            ZWrite Off
            Cull [_CullMode]
            // Source Stencil { Ref 1 ReadMask 1 Comp Equal Pass/Fail/ZFail Keep } = HGRP water-surface receiver bit.
            // ENGINE-SIDE: the stencil Ref (water-surface mask bit) is written by the HGRP water G-buffer pre-pass — a
            //   separate render pass, not a material texture/formula, so it cannot be produced in-shader. URP has no
            //   equivalent global stencil convention. The gate is preserved verbatim so it is 1:1 once a matching URP
            //   renderer-feature writes ref=1; if no feature writes the bit this pass draws nothing. (host: HGRP water G-buffer pass)
            Stencil {
                Ref 1
                ReadMask 1
                Comp Equal
                Pass Keep
                Fail Keep
                ZFail Keep
            }
            Tags { "LightMode" = "SRPDefaultUnlit" }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _BLEND_BASECOLOR

            struct Attributes
            {
                float3 positionOS : POSITION;
                float2 uv0        : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv0        : TEXCOORD0;
            };

            Varyings vert(Attributes input)
            {
                Varyings o = (Varyings)0;
                float3 posWS = TransformObjectToWorld(input.positionOS);
                o.positionCS = TransformWorldToHClip(posWS);
                o.uv0 = input.uv0;
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                bool discardPixel;
                DecalSample s = SampleDecal(input.positionCS, /*useDistanceFade=*/false, discardPixel);
                clip(discardPixel ? -1.0 : 1.0);

                float opacity = _OverallOpacity * _DecalAnimFade; // b16:121

            #ifdef _BLEND_BASECOLOR
                float2 uvSel = BaseColorSwitchUV(s, input.uv0);
                float2 uv;
                uv.x = mad(_DecalCustomTime * _BaseColorSpeed.x, 1.0, mad(uvSel.x, _BaseColorMap_ST.x, _BaseColorMap_ST.z)); // b18:152
                uv.y = mad(_DecalCustomTime * _BaseColorSpeed.y, 1.0, mad(uvSel.y, _BaseColorMap_ST.y, _BaseColorMap_ST.w)); // b18:152
                float mipBias = floor(_MinMipLevel) + floor(_Bias); // b18:152
                float4 tex = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uv, mipBias); // b18:152
                float texAm1 = tex.w + (-1.0);                       // _382 (b18:153)
                float aFac   = mad(_UseAChannelAsAlpha, texAm1, 1.0); // _386 (b18:154)
                float aOut   = mad(_UseAChannelAsAlpha, texAm1, 2.0); // _387 (b18:155)
                float3 colorRGB = float3(
                    mad(aFac * tex.x, _BaseColorTint.x, _BaseColor.x),
                    mad(aFac * tex.y, _BaseColorTint.y, _BaseColor.y),
                    mad(aFac * tex.z, _BaseColorTint.z, _BaseColor.z));
                float3 outRGB = (opacity * (s.edgeFade * (aOut * colorRGB))) * _DecalAnimAlpha; // b18:157-159
                float outA = (1.0 + (-_BlendMode)) * aOut; // b18:160
                return half4(outRGB, outA);
            #else
                float3 outRGB = ((s.edgeFade * _BaseColor.xyz) * opacity) * _DecalAnimAlpha; // b16:122-124
                float outA = 1.0 + (-_BlendMode); // b16:125
                return half4(outRGB, outA);
            #endif
            }
            ENDHLSL
        }
    }
}
