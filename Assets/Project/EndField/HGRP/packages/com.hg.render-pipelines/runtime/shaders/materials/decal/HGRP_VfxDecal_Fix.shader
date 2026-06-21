// HGRP VFX Decal — single screen-space deferred VFX decal pass (depth-reconstructed, box-clipped, writes G-buffer color+alpha via ColorMask RA).
// Merged from: ReferenceProjects/RuriBeyondShader/.../materials/decal/vfxdecal.shader (HGRP fork of HDRP).
//   Base ground truth: vfxdecal/Sub0_Pass0_Vertex_b568.hlsl (catch-all #else, vertex) + vfxdecal/Sub0_Pass0_Fragment_b569.hlsl (catch-all #else, fragment).
//   Keyword deltas inspected: Sub0_Pass0_Fragment_b571.hlsl (_USE_MASK — mask-texture layer, 1:1) and
//   Sub0_Pass0_Fragment_b573.hlsl (_USE_BLEND — alpha-gated additive blend layer; compositing math taken 1:1 from b573:202-206),
//   Sub0_Pass0_Fragment_b575.hlsl (_USE_PARALLAX — steep-parallax crack marching; LEFT AS GAP, see below).
// Keywords (exposed as shader_feature_local): _USE_MASK, _USE_BLEND. (Source also had _USE_PARALLAX/_USE_DISSOLVE/_USE_DISTURB/_USE_DISTURB_TEX2/_USE_WEIGHT/_USE_SCREENUV/_USE_POLARUV/_USE_NORMALBLEND/_USE_IN_PARTICLE/_USE_FOG — see gaps.)
// Kept (1:1 math, cites against Fragment_b569 / b571):
//   camera-depth world-position reconstruction (inverse view-proj, b569:138-145), world->decal-object-space projection via the 3
//   interpolated world->object rows + decal origin (b569:147-152 / vertex b568:230-260), unit-box clip (|decalX|,|decalY|,|decalZ| < .5, b569:175),
//   main-tex UV from decal XZ with disturb-offset + degree rotate + tiling/offset (b569:153-158), UseMainTexAsAlpha/UseMaskTexAsAlpha lerp (b569:164-166),
//   height fade along decal Y (b569:167,359), edge fade X & Z (decompiler smoothstep s*s*(3-2s), b569:172-174,401), view-Z near-camera double-band distance fade (b569:146,401),
//   procedure-alpha * (1-LODFade.y) * tintColorAlpha (b569:174), squared-alpha decal weighting (b569:176,182-184), post-exposure divide (b569:178-181),
//   Rec709-luma VFX color-grade desaturate+tint (b569:185-190), additive-vs-premultiplied blend-mode lerp (b569:188-190), responsive MRT1.w stencil-ish flag (b569:191).
// Removed (pixel-neutral pipeline infra substituted by URP or dropped): SPIRV-Cross plumbing (gl_FragCoord/SPIRV_Cross_*/static I/O -> SV_POSITION + clean structs),
//   spvBitfieldUExtract/SExtract polyfills (vertex octahedral unpack -> dropped, URP feeds plain mesh normals/tangents via GetVertexNormalInputs),
//   HG GPU-skinning / packed-octahedral NORMAL.x stream (b568:125-194 -> plain Attributes), HGRP global cbuffer
//   (_ViewMatrix/_InvViewProjMatrix/_NonJitteredViewNoTransProjMatrix/_ScreenSize/_WorldSpaceCameraPos_Internal -> UNITY_MATRIX_V / UNITY_MATRIX_I_VP / _ScreenParams / _WorldSpaceCameraPos),
//   HG_ENABLE_MV motion-vector previous-frame clip path + SV_Target1 MV pack (b568:250-263, b569:191-194 -> single bound target; MRT1.w responsive flag preserved as a documented note),
//   TAA jitter (_TaaJitterStrength, b568:222-223), denormalized-float magic literals (decoded inline), HGRP per-decal fog cbuffers (Atmosphere/Exponential/Volumetric -> dropped; URP has no per-decal scattering — see gaps).
//
// NOTE: This is a SCREEN-SPACE DEFERRED VFX DECAL, not a lit/PBR surface. The projector box mesh is drawn Cull Front / ZTest Greater / ZWrite Off;
//   the fragment reconstructs the underlying opaque surface world position from the camera depth buffer, transforms it into the decal's object
//   (unit-box) space, evaluates texture stack + fades, and writes premultiplied color into the G-buffer (ColorMask RA -> only .r/.a reach the bound
//   color/blend RTs). No GetMainLight / BRDF / SH (so _core/CoreMath is intentionally NOT included). Sibling precedent: HGRP_VfxDecalProjector_Fix.shader.
// NOTE on cbuffer NAME ALIASING: the decompiled base variant (ParamBlob 0, b569 lines 54-100) packs the material cbuffer in a permuted order whose
//   field NAMES DO NOT MATCH their semantic use (e.g. b569 '_BlendTexUVSpeed.y' is the blend-mode factor, '_DissolveUVRotate/_Bi_Disturb/_DisturbUIntensity1'
//   are the decal base color RGB, '_BlendTint_at_80.xyzw' are the near-camera distance-fade params). The true semantics below were recovered by aligning
//   b569 against the more-truthfully-named b571 (ParamBlob 1) operation-for-operation; clean property names follow the SHADER Properties block (vfxdecal.shader:2-106).
// Texture channel legend: scene depth = URP _CameraDepthTexture (source T0, point-sampled at pixel center, b569:140).
//   _MainTex = decal albedo/alpha (source T1, b569:158). _MaskTex = mask layer (_USE_MASK; source T2 in b571:180). _BlendTex = additive blend layer (_USE_BLEND).

Shader "HGRP/VfxDecal_Fix" {
    Properties {
        _MainProperties ("Main Properties", Float) = 0
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 0
        [Enum(Alpha, 0, Additive, 1, Premultiply, 4)] _BlendMode ("Blend Type", Float) = 0
        _HeightFade ("Height Fade", Range(0.001, 3)) = 0.001
        _HeightFadeOffset ("Height Fade Offset", Range(-0.5, 0.5)) = 0
        _EdgeFadeX ("Edge Fade X", Range(0, 0.5)) = 0
        _EdgeFadeZ ("Edge Fade Z", Range(0, 0.5)) = 0
        _EdgeFadeIntensity ("Edge Fade Intensity", Range(0.001, 0.5)) = 0.001
        [HDR] [Gamma] _DecalBaseColor ("Decal Base Color", Color) = (1, 1, 1, 1)
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        [ToggleUI] _IsSceneEffect ("Is SceneEffect", Float) = 0
        _TintColorAlpha ("Tint Color Alpha (Default 1)", Range(0, 10)) = 1
        [HideInInspector] _ProcedureAlpha ("Procedure Alpha", Float) = 1

        [Header(Main Tex)]
        _MainTex ("Main Tex", 2D) = "white" {}
        [ToggleUI] _MainTexUseDisturb ("Main Tex Use Disturb", Float) = 1
        [ToggleUI] _UseMainTexAsAlpha ("UseMainTexAsAlpha", Float) = 1
        _MainTexUVSpeed ("MainTexUVSpeed(XY:By Time, ZW:By Custom)", Vector) = (0, 0, 0, 0)
        _MainCustomData ("CustomData", Float) = 0
        _MainTexUVRotate ("MainTexUVRotate(Degree)", Float) = 0
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        [ToggleUI] _UseMaskTexAsAlpha ("UseMaskTexAsAlpha", Float) = 1
        _MaskTexUVSpeed ("MaskTexUVSpeed(XY:By Time, ZW:By Custom)", Vector) = (0, 0, 0, 0)
        _MaskCustomData ("CustomData", Float) = 0
        _MaskTexUVRotate ("MaskTexUVRotate(Degree)", Float) = 0

        [Header(Blend)]
        [Toggle(_USE_BLEND)] _UseBlend ("Use Blend", Float) = 0
        _BlendTex ("Blend Tex", 2D) = "black" {}
        [HDR] [Gamma] _BlendTint ("BlendTint", Color) = (1, 1, 1, 1)
        _BlendTexUVSpeed ("BlendTexUVSpeed(XY:By Time, ZW:By Custom)", Vector) = (0, 0, 0, 0)
        _BlendCustomData ("CustomData", Float) = 0
        _BlendTexUVRotate ("BlendTexUVRotate(Degree)", Float) = 0

        [Header(Near Camera Fade)]
        [ToggleUI] _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Disappear Distance 1", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Appear Distance 1", Range(0.001, 3000)) = 10
        _NearCameraFadeDistanceEnd2 ("Appear Distance 2", Range(0.002, 3000)) = 100
        _NearCameraFadeDistanceStart2 ("Disappear Distance 2", Range(0.001, 3000)) = 120

        // Exposure (source _ExposureParams.x is an HGRP global; URP has none -> material Vector).
        [Header(Workarounds)]
        _ExposureParams ("Exposure Params (.x = post exposure)", Vector) = (1, 0, 0, 0)
        // VFX color-grade globals (source _VFXParams0.w = custom-data time driver, _VFXParams1 = grade .xyz tint + .w desat).
        _VFXColorTint ("VFX Color Tint (_VFXParams1.xyz)", Vector) = (1, 1, 1, 0)
        _VFXDesaturate ("VFX Desaturate (_VFXParams1.w)", Range(0, 1)) = 0
        _VFXCustomData ("VFX Custom Data (_VFXParams0.w)", Float) = 0
        // LOD crossfade (source _unity_LODFade.y); kept so the (1-LODFade.y) factor is 1:1. 0 => no fade.
        [HideInInspector] _LODFadeY ("LOD Fade Y", Float) = 0

        [Header(Advanced)]
        [ToggleUI] _DecalsNoStencil ("Draw On Any Mesh", Float) = 0
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _StencilReadMask ("_stencilReadMask", Float) = 32
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
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
            // --- core (source type_UnityPerMaterial, true semantics recovered from b571) ---
            float _SurfaceType;             // b569:65
            float _BlendMode;               // b569:66
            float _IgnorePostExposure;      // b569:67
            float _Responsive;
            float _IsSceneEffect;
            float _ProcedureAlpha;          // (1 - LODFade.y) * _ProcedureAlpha is the proc-alpha factor (b571:_BlendSwitchUV slot)
            float _TintColorAlpha;          // b569:82
            float4 _DecalBaseColor;         // decal tint RGB(A); b569 base color (b571 _DisturbUVSpeed2.xyz)
            // --- height / edge fades ---
            float _HeightFade;              // height-fade falloff denom (b569:167 denom)
            float _HeightFadeOffset;        // height-fade center offset (b569:167 _MaskTex_ST.x slot)
            float _EdgeFadeX;               // edge-fade X start (b569:369 _MaskTexUVSpeed.x slot)
            float _EdgeFadeZ;               // edge-fade Z start (b569:370 _MaskTexUVSpeed.y slot)
            float _EdgeFadeIntensity;       // edge-fade width (b569:374/375 _MaskTexUVSpeed.w slot)
            // --- near-camera double-band distance fade (b569:401, _BlendTint_at_80.xyzw + _BlendTexUVSpeed.x) ---
            float _UseNearCameraFade;
            float _NearCameraFadeDistanceStart;  // d1 start (disappear near)
            float _NearCameraFadeDistanceEnd;     // d1 end   (appear)
            float _NearCameraFadeDistanceEnd2;    // d2 end   (appear far)
            float _NearCameraFadeDistanceStart2;  // d2 start (disappear far)
            // --- main tex UV ---
            float4 _MainTex_ST;             // tiling/offset (b569:158 _DisturbUseWeight/_MainSwitchUV/_EdgeFadeZ_at_164/_EdgeFadeIntensity_at_172 slots)
            float4 _MainTexUVSpeed;         // .xy time scroll, .zw custom-data scroll (b571 _DisturbTex1_ST role for offset)
            float _MainTexUVRotate;         // degrees (b569:155)
            float _MainCustomData;
            float _MainTexUseDisturb;
            float _UseMainTexAsAlpha;       // b569:164
            // --- mask tex (_USE_MASK) ---
            float4 _MaskTex_ST;
            float4 _MaskTexUVSpeed;
            float _MaskTexUVRotate;
            float _MaskCustomData;
            float _UseMaskTexAsAlpha;
            // --- blend tex (_USE_BLEND) ---
            float4 _BlendTex_ST;
            float4 _BlendTexUVSpeed;
            float4 _BlendTint;              // .x,.y feed responsive MRT1.w (b569:191); HDR tint of blend layer
            float _BlendTexUVRotate;
            float _BlendCustomData;
            // --- workaround globals (HGRP globals with no URP equivalent) ---
            float4 _ExposureParams;         // .x post-exposure (b569:178)
            float4 _VFXColorTint;           // _VFXParams1.xyz (b569:188-190)
            float _VFXDesaturate;           // _VFXParams1.w
            float _VFXCustomData;           // _VFXParams0.w (b569:153-154)
            float _LODFadeY;                // _unity_LODFade.y (b569:174)
            float _DecalsNoStencil;
        CBUFFER_END

        TEXTURE2D(_MainTex);    SAMPLER(sampler_MainTex);
        TEXTURE2D(_MaskTex);    SAMPLER(sampler_MaskTex);
        TEXTURE2D(_BlendTex);   SAMPLER(sampler_BlendTex);

        // ---- magic-constant decodes (cites against Fragment_b569) ----
        static const float3 REC709     = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709 luma (b569:185)
        static const float  DEG2RAD    = 0.01745329238474369049072265625;   // pi/180 (b569:155)
        static const float  HEIGHT_EPS = 0.001000000047497451305389404296875; // 1e-3 height-fade denom clamp (b569:167)

        // Decompiler smoothstep: s*s*(3-2s) on a saturated argument. (b569:174 _390/_391 -> _401)
        float SmoothStep01(float t)
        {
            float s = saturate(t);
            return (s * s) * mad(s, -2.0, 3.0);
        }

        // Rotate a centered UV by 'degrees' about origin (decompiler builds sin/cos then dot, b569:155-158).
        // row0 = (cos, -sin), row1 = (sin, cos) ; matches mad(dot(uv,(cos,sin)),..) / mad(dot(uv,(-sin,cos)),..).
        float2 RotateUV(float2 centeredUV, float degrees)
        {
            float a = DEG2RAD * degrees;
            float s = sin(a);
            float c = cos(a);
            // b569:158 : x uses (cos, sin), y uses (-sin, cos).
            float u = dot(centeredUV, float2(c, s));
            float v = dot(centeredUV, float2(-s, c));
            return float2(u, v);
        }
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            LOD 600
            // Source render-state (vfxdecal.shader:117-131): a second MRT (Blend 1 One One) + ColorMask RA 1 select which
            // G-buffer channels the decal writes. URP single-target approximation keeps the first MRT's blend + ColorMask RA.
            // ZClip On / ZTest Greater / ZWrite Off / Cull Front preserved 1:1 (back faces of the projector box rasterize the footprint).
            Blend [_SrcBlend] [_DstBlend], [_SrcBlend] [_DstBlend]
            ColorMask RA
            ZClip On
            ZTest Greater
            ZWrite Off
            Cull Front
            // Source Stencil { Ref [_StencilRef] ReadMask [_StencilReadMask] Comp Equal Pass/Fail/ZFail Keep } = HGRP decal-receiver bit.
            // TODO(1:1): _StencilRef (decal-receiver layer mask) is bound by the HGRP decal system; URP has no equivalent global.
            //   Omitted (binding Ref against an unset receiver buffer would reject every pixel). See gaps.

            Tags { "LightMode" = "SRPDefaultUnlit" }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_MASK
            #pragma shader_feature_local _USE_BLEND
            // TODO(1:1): the following source multi_compile_local keyword features are NOT ported in this pass (each is a
            //   self-contained subsystem to add as its own #ifdef path; cite blobs in the vfxdecal/ subfolder):
            //   _USE_PARALLAX     — 31-step steep-parallax crack march into CrackNoise/Depth/CrackMask tex stack vs Sub0_Pass0_Fragment_b575.hlsl:235-289 (uses TEXCOORD_3 normalWS + TEXCOORD_4 tangentWS, both emitted by vert).
            //   _USE_DISSOLVE     — dissolve erosion threshold + emissive edge color vs the _USE_DISSOLVE variant fragment blob.
            //   _USE_DISTURB / _USE_DISTURB_TEX2 — UV distortion sampled from disturb tex (the base bakes the offset MADs with identity; the gated path samples DisturbTex1/2 * intensity * weight).
            //   _USE_WEIGHT       — weight-texture modulation of the layered alpha.
            //   _USE_SCREENUV / _USE_POLARUV — alternate UV projection modes (screen-space / polar) replacing the decal-XZ box UV.
            //   _USE_NORMALBLEND  — angle-based coverage from world geo normal vs camera (TEXCOORD_3 already passed; the AngleBlendFallOff math is gated off here).
            //   _USE_IN_PARTICLE  — particle-system per-instance custom-data feed path.
            //   _USE_FOG          — HGRP per-decal Atmosphere/Exponential/Volumetric fog composite (no URP per-decal equivalent; would map to MixFog at best).

            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                // The 3 world->object decal rows + decal origin in their .w (b568:230-260 -> b569:147-152).
                // .xyz = world->object row i (objectToWorld_row_i / dot(row_i,row_i) = inverse for orthogonal basis), .w = decal origin axis i.
                float4 decalRow0  : TEXCOORD0; // row0 (decal X axis) + originX  (source TEXCOORD/TEXCOORD1.w)
                float4 decalRow1  : TEXCOORD1; // row1 (decal Y axis) + originY  (source TEXCOORD_1/TEXCOORD2.w)
                float4 decalRow2  : TEXCOORD2; // row2 (decal Z axis) + originZ  (source TEXCOORD_2/TEXCOORD3.w)
                float3 normalWS   : TEXCOORD3; // world geo normal (source TEXCOORD_3, used by _USE_PARALLAX/_USE_NORMALBLEND — gap)
                float4 tangentWS  : TEXCOORD4; // world tangent + sign (source TEXCOORD_4_1 — gap)
            };

            // ============================================================
            // Vertex: rasterize the projector box so the fragment depth-reconstruction runs over its screen footprint,
            // and emit the world->object decal basis rows + origin. Source (Vertex_b568:198-263) bakes camera-relative
            // world position, the orthonormal inverse rows (row_i = objectToWorld_row_i / dot(row_i,row_i)), the world
            // geo normal/tangent, and the MV previous-frame clip. We compute object->world->clip via URP, and pass the
            // same inverse rows straight from unity_ObjectToWorld. (MV / TAA / octahedral-unpack dropped — see header.)
            // ============================================================
            Varyings vert(Attributes input)
            {
                Varyings o = (Varyings)0;

                float3 posWS = TransformObjectToWorld(input.positionOS);
                o.positionCS = TransformWorldToHClip(posWS);

                // world->object basis rows = objectToWorld column-i divided by its squared length (b568:229-240).
                // unity_ObjectToWorld._mXY: row=X, col=Y. column i = (_m0i, _m1i, _m2i). origin = column 3 (_m03,_m13,_m23).
                float3 c0 = float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20);
                float3 c1 = float3(unity_ObjectToWorld._m01, unity_ObjectToWorld._m11, unity_ObjectToWorld._m21);
                float3 c2 = float3(unity_ObjectToWorld._m02, unity_ObjectToWorld._m12, unity_ObjectToWorld._m22);
                float3 origin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);

                o.decalRow0 = float4(c0 / dot(c0, c0), origin.x); // b568:230-232,258 (decal X)
                o.decalRow1 = float4(c1 / dot(c1, c1), origin.y); // b568:234-236,259 (decal Y)
                o.decalRow2 = float4(c2 / dot(c2, c2), origin.z); // b568:238-240,260 (decal Z)

                // world geo normal & tangent (b568:241-249) via URP basis (plain mesh stream; octahedral unpack dropped).
                VertexNormalInputs n = GetVertexNormalInputs(input.normalOS, input.tangentOS);
                o.normalWS  = n.normalWS;                                    // b568:242-244 (_368..370 normalized)
                o.tangentWS = float4(n.tangentWS, input.tangentOS.w * GetOddNegativeScale()); // b568:246-249

                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                // ===== Reconstruct world position of the underlying opaque surface from depth (b569:138-145). =====
                // input.positionCS.xy = pixel coords (raster already added .5). NDC from fragcoord, inv-view-proj * (ndc, sampledDepth).
                float2 screenUV = input.positionCS.xy * rcp(_ScreenParams.xy);       // gl_FragCoord.xy * _ScreenSize.zw (b569:140)
                float rawDepth  = SampleSceneDepth(screenUV);                        // T0.SampleLevel(LinearClamp,...).x (b569:140)
                float ndcX = mad(screenUV.x, 2.0, -1.0);                             // b569:138
                float ndcY = -mad(screenUV.y, 2.0, -1.0);                            // b569:139
                float4 worldH = mul(UNITY_MATRIX_I_VP, float4(ndcX, ndcY, rawDepth, 1.0)); // b569:142-145 (_InvViewProjMatrix)
                float3 worldP = worldH.xyz / worldH.w;

                // ===== View-space depth magnitude for the near-camera distance fade (b569:146). =====
                // |dot(viewMatrix_row2, worldP) + viewMatrix[3].z| = |view-space Z|.
                float viewZ = abs(mul(UNITY_MATRIX_V, float4(worldP, 1.0)).z);       // b569:146 (_157)

                // ===== World -> decal object (unit-box) space: rel = worldP - origin, then dot with each row. (b569:147-152) =====
                float3 rel = worldP - float3(input.decalRow0.w, input.decalRow1.w, input.decalRow2.w); // _207..209
                float decalX = dot(input.decalRow0.xyz, rel);  // _216
                float decalZ = dot(input.decalRow2.xyz, rel);  // _225
                float decalY = dot(input.decalRow1.xyz, rel);  // _234

                // ===== Main-tex UV: decal XZ centered + scroll(time .xy + custom-data .zw), degree rotate about origin, tiling/offset. (b569:153-158) =====
                // b569:153-154 centered form: c = (decalXZ + 0.5) + speed.zw*customData + speed.xy*_VFXParams0.w  (then -0.5 to recenter).
                // The two scroll mads in the blob are the by-custom-data offset and the by-time offset; both fold into _MainTexUVSpeed per its label.
                float2 centeredMain = float2(decalX, decalZ)
                                    + _MainTexUVSpeed.zw * _MainCustomData          // b569:153-154 first scroll mad (ZW: by custom)
                                    + _MainTexUVSpeed.xy * _VFXCustomData;          // b569:153-154 _VFXParams0.w time term (XY: by time)
                float2 rotMain = RotateUV(centeredMain, _MainTexUVRotate) + 0.5;     // b569:155-158
                float2 mainUV = rotMain * _MainTex_ST.xy + _MainTex_ST.zw;           // b569:158
                float4 mainTex = SAMPLE_TEXTURE2D_BIAS(_MainTex, sampler_MainTex, mainUV, _GlobalMipBias.x); // b569:158 (_GlobalMipBias; URP float2, .x = bias)

                // UseMainTexAsAlpha lerp: lerp(rgb, 1, useAsAlpha) = mad(useAsAlpha, (1-rgb), rgb). (b569:164-166)
                float3 mainRGB;
                mainRGB.x = mad(_UseMainTexAsAlpha, (1.0 - mainTex.x), mainTex.x);
                mainRGB.y = mad(_UseMainTexAsAlpha, (1.0 - mainTex.y), mainTex.y);
                mainRGB.z = mad(_UseMainTexAsAlpha, (1.0 - mainTex.z), mainTex.z);
                // main alpha = lerp(mainTex.a, mainTex.r, useAsAlpha) (b569:174 _301 term: mad(useAsAlpha,(rgb.x - a), a))
                float mainA = mad(_UseMainTexAsAlpha, (mainTex.x - mainTex.w), mainTex.w);

                // ===== Color & alpha accumulation. baseColor = _DecalBaseColor; layered by mask & blend below. (b569:164-166,174) =====
                float3 color = mainRGB * _DecalBaseColor.rgb;     // b569:164-166 (* _DissolveUVRotate/_Bi_Disturb/_DisturbUIntensity1 = base color rgb)
                float texAlpha = mainA;                            // accumulates mask.a / blend contributions

                #ifdef _USE_MASK
                    // Mask layer (b571:175-184): own UV (decal XZ + customData scroll + degree rotate + _MaskTex_ST), UseMaskTexAsAlpha lerp, multiply.
                    float2 centeredMask = float2(decalX, decalZ) + _MaskCustomData * _MaskTexUVSpeed.zw + _MaskTexUVSpeed.xy * _VFXCustomData;
                    float2 maskUV = (RotateUV(centeredMask, _MaskTexUVRotate) + 0.5) * _MaskTex_ST.xy + _MaskTex_ST.zw;
                    float4 maskTex = SAMPLE_TEXTURE2D_BIAS(_MaskTex, sampler_MaskTex, maskUV, _GlobalMipBias.x); // b571:180
                    float3 maskRGB;
                    maskRGB.x = mad(_UseMaskTexAsAlpha, (1.0 - maskTex.x), maskTex.x); // b571:195-197
                    maskRGB.y = mad(_UseMaskTexAsAlpha, (1.0 - maskTex.y), maskTex.y);
                    maskRGB.z = mad(_UseMaskTexAsAlpha, (1.0 - maskTex.z), maskTex.z);
                    float maskA = mad(_UseMaskTexAsAlpha, (maskTex.x - maskTex.w), maskTex.w); // b571:205 _325 term
                    color *= maskRGB;        // b571:418-420 (mask.rgb * main.rgb * baseColor)
                    texAlpha *= maskA;       // b571:205
                #endif

                #ifdef _USE_BLEND
                    // Blend layer (additive, alpha-gated). Ground truth = Sub0_Pass0_Fragment_b573.hlsl:202-206.
                    // own UV + _BlendTint, ADDED to color. The additive term is gated by an alpha factor
                    //   _505 = saturate((procTail*mainA + blendTex.a) * _BlendTint.a)   (b573:203)
                    //   where procTail = (1-LODFade.y)*_ProcedureAlpha*_TintColorAlpha  (b573 _357, = c4.z*c12.w slots).
                    // color.ch += _505 * blendTex.ch * _BlendTint.ch                     (b573:204-206 first mad operand).
                    // (Earlier port added blendTex.rgb*_BlendTint.rgb UNGATED -> over-bright additive halo ignoring
                    //  blend/main/tint alpha; corrected to the b573 gate below.)
                    float2 centeredBlend = float2(decalX, decalZ) + _BlendCustomData * _BlendTexUVSpeed.zw + _BlendTexUVSpeed.xy * _VFXCustomData;
                    float2 blendUV = (RotateUV(centeredBlend, _BlendTexUVRotate) + 0.5) * _BlendTex_ST.xy + _BlendTex_ST.zw;
                    float4 blendTex = SAMPLE_TEXTURE2D_BIAS(_BlendTex, sampler_BlendTex, blendUV, _GlobalMipBias.x);
                    float blendProcTail = (1.0 - _LODFadeY) * _ProcedureAlpha * _TintColorAlpha; // b573 _357
                    float blendGate = saturate(mad(blendProcTail, mainA, blendTex.w) * _BlendTint.w); // b573:203 _505
                    color += (blendGate * blendTex.rgb) * _BlendTint.rgb;  // b573:204-206 additive, gated
                    // NOTE(1:1): b573 also shuffles texture roles (its T2/blend-tex UV uses _MaskTexUVSpeed + a double-_MaskTex_ST
                    //   wrap, b573:199-202) because the _USE_BLEND variant recompiles the whole fragment with main/blend swapped.
                    //   This clean path keeps the semantic _BlendTex* properties for the blend UV (compiler slot-shuffle is an
                    //   artifact, not intent); only the COMPOSITING gate above is the load-bearing 1:1 math.
                #endif

                // ===== Height fade along decal Y (b569:167). =====
                // ((-|decalY + offset|) + (0.5 + |offset|)) / max(1e-3, heightFade), clamp [0,1], then *2 clamp (b569:174 clamp(_359+_359)).
                float heightFade = ((-abs(decalY + _HeightFadeOffset)) + (0.5 + abs(_HeightFadeOffset))) / max(HEIGHT_EPS, _HeightFade); // _359
                heightFade = saturate(heightFade + heightFade);                     // b569:174 clamp(_359 + _359)

                // ===== Edge fade X & Z (b569:168-174). decompiler builds start/end then smoothstep. =====
                float eStartX = 0.5 - _EdgeFadeX;                                    // _369
                float eStartZ = 0.5 - _EdgeFadeZ;                                    // _370
                float eEndX = eStartX + _EdgeFadeIntensity;                          // _374
                float eEndZ = eStartZ + _EdgeFadeIntensity;                          // _375
                float edgeX = saturate((1.0 / (eStartX - eEndX)) * ((-eEndX) + abs(decalX))); // _390
                float edgeZ = saturate((1.0 / (eStartZ - eEndZ)) * ((-eEndZ) + abs(decalZ))); // _391
                float edgeFade = SmoothStep01(edgeZ) * SmoothStep01(edgeX);          // b569:174 (_401 outer two smoothsteps)

                // ===== Near-camera double-band distance fade (b569:174 _401 inner: asfloat((0 != enable) ? bandProduct : 1)). =====
                // band = clamp((viewZ - d1start)/(d2end? ...)) ; the decompiler does TWO clamped ramps multiplied (near appear + far disappear).
                float distFade = 1.0;
                if (_UseNearCameraFade != 0.0)                                       // b569:174 (0.0 != _BlendTint_at_80.x)
                {
                    float band1 = saturate((viewZ - _NearCameraFadeDistanceStart) / ((-_NearCameraFadeDistanceStart) + _NearCameraFadeDistanceEnd)); // _401 first clamp
                    float band2 = saturate((viewZ - _NearCameraFadeDistanceEnd2)   / ((-_NearCameraFadeDistanceEnd2)   + _NearCameraFadeDistanceStart2)); // _401 second clamp
                    distFade = band1 * band2;
                }

                // ===== Combined coverage (b569:174 _401). =====
                float procAlpha = (1.0 - _LODFadeY) * _ProcedureAlpha;              // b569:174 ((1 - LODFade.y) * _MaskTexUseDisturb-slot)
                float coverage = edgeFade * (heightFade * (distFade * (texAlpha * (procAlpha * _TintColorAlpha)))); // _401

                // ===== Unit-box clip + final alpha (b569:175). =====
                // alpha = (all decal coords within (-0.5, 0.5)) ? clamp(coverage) : 0.
                bool inBox = (decalX < 0.5) && (decalZ < 0.5) && (decalY < 0.5)
                          && (-0.5 < decalX) && (-0.5 < decalZ) && (-0.5 < decalY); // b569:175
                float alpha = inBox ? saturate(coverage) : 0.0;                     // _423
                float alphaSq = alpha * alpha;                                       // _424

                // ===== Post-exposure divide (b569:178-181). exposure = lerp(1, _ExposureParams.x, ignorePostExposure). =====
                float exposure = mad(_ExposureParams.x, _IgnorePostExposure, 1.0 - _IgnorePostExposure); // _461
                float3 exposed = min(max(color, 0.0), 1000.0) / exposure;           // _462..464
                float3 premul = alphaSq * exposed;                                   // _465..467

                // ===== VFX color-grade desaturate+tint, then blend-mode lerp (b569:185-190). =====
                float luma = dot(premul, REC709);                                    // _468
                // graded = lerp(luma, channel, _VFXDesaturate) * _VFXColorTint ; out = lerp(premul, graded, blendModeFactor).
                // decompiler: mad( mad(desat, (premulCh - luma), luma) * tintCh , blendFactor , (1 - blendFactor) * premulCh ). (b569:188-190)
                float blendFactor = (_BlendMode == 1.0) ? 1.0 : 0.0;                 // additive => 1, alpha/premul => 0 (b569:188 _BlendTexUVSpeed.y slot = blend-mode factor)
                float invBlend = 1.0 - blendFactor;                                  // _494
                float3 graded;
                graded.x = mad(mad(_VFXDesaturate, (premul.x - luma), luma) * _VFXColorTint.x, blendFactor, invBlend * premul.x); // _SV_Target.x
                graded.y = mad(mad(_VFXDesaturate, (premul.y - luma), luma) * _VFXColorTint.y, blendFactor, invBlend * premul.y);
                graded.z = mad(mad(_VFXDesaturate, (premul.z - luma), luma) * _VFXColorTint.z, blendFactor, invBlend * premul.z);

                // SV_Target.w = alpha (plain, NOT premultiplied) ; ColorMask RA -> only .r/.a reach the bound RTs. (b569:177)
                // NOTE: source MRT1.w (b569:191) = responsive-transparent flag = (luma01>0.5) ? (_BlendTint.y*_BlendTint.x) : 0 — a
                //   separate G-buffer channel (Blend 1 One One) consumed by HG's responsive-TAA. Dropped here (single target). See gaps.
                return half4(graded.x, graded.y, graded.z, alpha);
            }
            ENDHLSL
        }
    }
}
