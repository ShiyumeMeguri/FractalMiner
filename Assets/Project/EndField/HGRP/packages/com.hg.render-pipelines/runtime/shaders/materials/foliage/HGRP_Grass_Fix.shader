// HGRP Foliage/Grass — foliage subsurface surface, re-authored deferred(HGBuffer)+ShadowCaster+DepthOnly into URP Forward.
// Merged from: grass.shader base variant b24/b25 (HG_ENABLE_MV) + map/animate variant b32/b33 (_NORMAL_MAP _ALPHATEST_ON _ANIMATE_VERTEX_GRASS).
// Source: E:/.../com.hg.render-pipelines/runtime/shaders/materials/foliage/grass/grass.shader (catch-all #else = Sub0_Pass0_Vertex_b24 / Sub0_Pass0_Fragment_b25).
// Keywords: _NORMAL_MAP, _ALPHATEST_ON, _ANIMATE_VERTEX_GRASS
// Kept (1:1 surface math, cited per block):
//   Albedo (BaseColorMap.rgb * _BaseColor * _BaseColorBrighterScale, saturate) + Tint-Cover blend          (b33:242-247 / b25:231-237)
//   Normal Map decode with _BendNormalUpward bias + Two-Sided-Normal sign + _NormalScale TBN               (b33:193-209)
//   Roughness = lerp(_RoughnessMin,_RoughnessMax, normalMap.B) in _NORMAL_MAP path (b33:235);
//     base (no-map) path roughness = constant 1.0 (b25:256 SV_Target_3.z), NOT _RoughnessMax
//   Spherical contact AO (_AoParams: position/contrast/intensity/radius) from object-space pivot pos        (b33:237-240 / b25:238-241)
//   Spherical direct self-shadow term (_DirParams) modulating diffuse + transmission                        (b33:211-217 / b25:218-219,253)
//   Subsurface intensity + Back-face Transmission (translucency), masked by NormalMap.A                     (b33:215-224 / b25:249-255)
// Removed (HG-engine infrastructure substituted by URP facilities or split into sibling shaders; pixel-neutral here):
//   5-MRT deferred GBuffer packing + octahedral normal encode (b25/b33 SV_Target0..4)  -> URP forward PBR (GetMainLight + SampleSH + GGX).
//   HG global wind+motor simulation cbuffers (_WindGlobalParams*/_WindMotorParams0..3[4]/_LastWind*/CB3_m0) and
//     foliage-interactive trample RT + character-height carve (b26:161-973)             -> see TODO(1:1) in vert; gated by _ANIMATE_VERTEX_GRASS.
//   Foliage-occluder mask cull (_FoliageOccluderParams0, NaN-discard, T0 occluder map)  -> lives in sibling HGRP_FoliageOccluder_Fix.
//   TAA jitter (_TaaJitterStrength), motion vectors (SV_Target1 + prev-frame clip), LOD-crossfade dither    -> URP has dedicated passes.
//   GPU-skin / packed-octahedral vertex stream decode (b24:167-236)                     -> URP GetVertexNormalInputs on standard meshes.
//
// NOTE: grass has NO metallic channel in its material cbuffer (foliage); metallic is hard 0 (b25/b33 never read it).
// NOTE: _NormalMap layout = RG normal / B roughness / A mask (matches source property label, grass.shader:13).
// NOTE: TEXCOORD_6 in the blobs = object-space vertex position relative to the foliage pivot (b24:297-299 carries _173/_172/_171 = POSITION.xyz); used by the spherical AO/Dir falloffs.
Shader "HGRP/Grass_Fix" {
    Properties {
        [Header(Surface)]
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Alpha Test", Float) = 0
        _AlphaClipThreshold ("Clip", Range(0, 1)) = 0.5
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1

        [Header(Base Color)]
        _BaseColor ("Base Color", Color) = (1, 1, 1, 1)
        _BaseColorMap ("Base Color Map", 2D) = "white" {}
        _BaseColorTintCover ("Base Color Tint Cover", Range(0, 1)) = 0
        _BaseColorBrighterScale ("Base Color Brighter Scale", Range(1, 3)) = 1
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1

        [Header(Normal Map RG  Roughness B  Mask A)]
        [Toggle(_NORMAL_MAP)] _EnableNormalMap ("Use Normal Map", Float) = 0
        _NormalMap ("Normal / Roughness / Mask", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 10)) = 1

        [Header(Subsurface and Transmission)]
        _SubsurfaceIntensity ("Subsurface Intensity", Range(0, 1)) = 0
        _Transmission ("Back Transmission", Range(0, 1)) = 0.1

        [Header(Shape)]
        [ToggleUI] _TwoSidedNormal ("Flip Back-Face Normal", Float) = 1
        _BendNormalUpward ("Bend Normal Upward", Range(0, 1)) = 0

        [Header(Direct Self Shadow)]
        _DirIntensity ("Dir Intensity", Range(0, 1)) = 0.2
        _DirContrast ("Dir Contrast", Range(0, 3)) = 0.2
        _DirPosition ("Dir Position", Range(0, 1)) = 0
        _DirRadius ("Dir Radius", Range(0.01, 1)) = 0.1
        _DirParams ("Dir Params (x=pos y=contrast z=intensity w=radius)", Vector) = (0.1, 1, 0.8, 99)
        _MaskOnDiffuse ("Mask On Diffuse", Range(0.01, 1)) = 1
        _MaskOnTransmission ("Mask On Transmission", Range(0.01, 1)) = 1

        [Header(Ambient Occlusion)]
        _AoIntensity ("AO Intensity", Range(0, 1)) = 0.2
        _AoContrast ("AO Contrast", Range(0, 3)) = 0.2
        _AoPosition ("AO Position", Range(0, 1)) = 0
        _AoRadius ("AO Radius", Range(0.01, 1)) = 0.1
        _AoParams ("AO Params (x=pos y=contrast z=intensity w=radius)", Vector) = (0.1, 1, 0.8, 99)

        [Header(Wind Interaction  (requires HG wind manager  see TODO))]
        [Toggle(_ANIMATE_VERTEX_GRASS)] _EnableAnimateVertex ("Animate Vertex (Wind)", Float) = 0
        [ToggleUI] _AnimateVertexHasPivot ("Has Pivot", Float) = 0
        _AnimateVertexLocalPhase ("Local Phase", Range(0, 1)) = 1
        _AnimateVertexLeanFactor ("Wind Lean Factor", Range(0, 1)) = 0.2
        _AnimateVertexNoiseFactor ("Wind Noise Factor", Range(0, 1)) = 0.2
        _WindFrequencyScale ("Wind Frequency Scale", Range(0.5, 2)) = 1
        _FixRootHeight ("Fix Root Height", Range(0.01, 0.5)) = 0.03
        _AnimateVertexInteractivePushStrength ("Character Push Strength", Range(0, 1)) = 0.5
        _AnimateVertexInteractivePushDown ("Character Push Down", Range(0, 1)) = 0.1
        _AnimateVertexInteractivePushFrequency ("Character Push Frequency", Range(0, 15)) = 10
        _AnimateVertexInteractiveDuration ("Character Push Duration", Range(0, 10)) = 4
    }

    SubShader {
        Tags {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Opaque"
            "Queue" = "Geometry"
        }
        LOD 600

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

        CBUFFER_START(UnityPerMaterial)
            // Core surface (type_UnityPerMaterial, b25:29-57 / b33:23-51)
            float4 _BaseColor;
            float4 _BaseColorMap_ST;
            float4 _NormalMap_ST;
            float  _BaseColorTintCover;
            float  _BaseColorBrighterScale;
            float  _RoughnessMin;
            float  _RoughnessMax;
            float  _NormalScale;
            float  _TwoSidedNormal;
            float  _BendNormalUpward;
            float  _AlphaClipThreshold;
            // Subsurface / transmission
            float  _SubsurfaceIntensity;
            float  _Transmission;
            float  _MaskOnDiffuse;
            float  _MaskOnTransmission;
            // Spherical falloff params (Vector uniforms, b25:55-56)
            float4 _DirParams;
            float4 _AoParams;
            float  _DirIntensity;
            float  _DirContrast;
            float  _DirPosition;
            float  _DirRadius;
            float  _AoIntensity;
            float  _AoContrast;
            float  _AoPosition;
            float  _AoRadius;
            // Wind material params (b25:42-53) — consumed only under _ANIMATE_VERTEX_GRASS
            float  _AnimateVertexNoiseFactor;
            float  _AnimateVertexLeanFactor;
            float  _FixRootHeight;
            float  _AnimateVertexLocalPhase;
            float  _AnimateVertexHasPivot;
            float  _AnimateVertexInteractivePushStrength;
            float  _AnimateVertexInteractivePushFrequency;
            float  _AnimateVertexInteractiveDuration;
            float  _AnimateVertexInteractivePushDown;
            float  _WindFrequencyScale;
        CBUFFER_END

        TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);
        TEXTURE2D(_NormalMap);      SAMPLER(sampler_NormalMap);

        // Algorithm-boundary constants decoded from the blobs (do not "simplify").
        static const float NORMAL_Z_MIN = 1.0e-16;   // b33:200  1.000000016862383526387164645044e-16f
        static const float RSQRT_MIN    = 1.175494351e-38; // FLT_MIN, rsqrt guard (b24:275, b33:206)

        struct Attributes {
            float3 positionOS : POSITION;
            float3 normalOS   : NORMAL;
            float4 tangentOS  : TANGENT;
            float4 color      : COLOR;
            float2 uv0        : TEXCOORD0;
            float2 uv1        : TEXCOORD1;
            float2 uv2        : TEXCOORD2;
        };

        struct Varyings {
            float4 positionCS : SV_POSITION;
            float2 uv         : TEXCOORD0;
            float3 positionWS : TEXCOORD1;
            float3 normalWS   : TEXCOORD2;
            float4 tangentWS  : TEXCOORD3;   // .w = bitangent sign
            float3 pivotLocal : TEXCOORD4;   // object-space pos relative to foliage pivot (blob TEXCOORD_6)
        };

        // ============================================================================
        // Wind vertex displacement (HG foliage wind), gated by _ANIMATE_VERTEX_GRASS.
        // Source: grass/Sub0_Pass0_Vertex_b26.hlsl:161-973.
        //
        // The full source path is HG's global-wind ENGINE system: it reads per-frame
        // global cbuffers that have NO URP equivalent and are populated by HG's foliage
        // wind manager every frame — there is nothing to bind them to under stock URP:
        //   _WindGlobalParams0/2, _WindMotorParams0..3[4], _WindMotorCount,
        //   _LastWindGlobalParams0, _LastWindMotorParams1/3[4]  (4-motor sway accumulation, b26:181-412,494-688),
        //   _FoliageInteractiveParams0 + interactive trample RT (b26:423-488),
        //   _CharacterHeightParams (character-height carve, b26:468),
        //   CB3_m0[8] (per-foliage-instance pivot/phase, b26:168-171,414-418,452-461),
        //   wind-noise tex T3 (b26:177,491), foliage-interactive tex T1 (b26:434).
        // Re-authoring those 810 SSA lines verbatim would transcribe dead engine
        // infrastructure (it cannot run in URP). Per PORT DISCIPLINE (infra -> URP
        // facilities; 1:1 binds surface MATH), the surface shading below is the faithful
        // 1:1 target; the wind hook is kept material-param-driven and explicitly bounded.
        //
        // TODO(1:1): full 4-WindMotor + foliage-interactive + character-carve sway is HG
        //   global-wind infrastructure not reproducible under stock URP — vs blob
        //   grass/Sub0_Pass0_Vertex_b26.hlsl:161-973. Drive via a URP-side wind manager
        //   (CBUFFER + global textures mirroring the HG names above) to restore it.
        // ============================================================================
        float3 ApplyGrassWind(float3 positionOS, float4 color, float3 pivotLocal)
        {
        #ifdef _ANIMATE_VERTEX_GRASS
            // Bend-mask along blade height: COLOR.y (green = wind mask) squared, biased by lean factor.
            // Faithful core of b26:172,180,226 (_190 = saturate(COLOR.y - windBias); _226 = _190*_190).
            // Wind-bias term CB3_m0[4].w is per-instance HG data (=0 with no instance buffer).
            float windMask = saturate(color.y);
            float bendAmt  = windMask * windMask * _AnimateVertexLeanFactor;
            // Lean the upper blade in object-space XZ; amplitude folds in the noise factor.
            // (Direction/phase that the source derives from the global wind field + per-blade
            //  noise tex is HG infrastructure — see TODO; here amplitude is preserved, direction
            //  is left to be supplied by a URP wind manager.)
            positionOS.x += bendAmt * _AnimateVertexNoiseFactor;
            positionOS.z += bendAmt * _AnimateVertexNoiseFactor;
        #endif
            return positionOS;
        }

        Varyings GrassVert(Attributes input)
        {
            Varyings output = (Varyings)0;

            float3 positionOS = ApplyGrassWind(input.positionOS, input.color, input.positionOS);

            VertexPositionInputs posInputs = GetVertexPositionInputs(positionOS);
            VertexNormalInputs   nrmInputs = GetVertexNormalInputs(input.normalOS, input.tangentOS);

            output.positionCS = posInputs.positionCS;
            output.positionWS = posInputs.positionWS;
            output.normalWS   = nrmInputs.normalWS;
            // tangent.w sign drives the bitangent (b24:283 / b33:193 _133 = sign(TANGENT.w));
            // combine with the mesh odd-negative-scale flip as URP does.
            output.tangentWS  = float4(nrmInputs.tangentWS, input.tangentOS.w * GetOddNegativeScale());
            output.uv         = input.uv0;
            output.pivotLocal = input.positionOS;   // blob TEXCOORD_6 = object-space POSITION (b24:297-299)
            return output;
        }

        // Spherical falloff shared by AO (_AoParams) and direct self-shadow (_DirParams).
        // 1:1 b33:237-240 / b25:238-241 (AO) and b33:211-214 / b25:218-219,253 (Dir):
        //   p   = pivotLocal + float3(0, P.w, 0)
        //   t   = saturate( ( max(length(p) - P.w, 0) - P.x ) * P.y )
        //   out = saturate( mad(t, 1 - P.z, P.z) )
        float SphericalFalloff(float3 pivotLocal, float4 P)
        {
            float3 p = float3(pivotLocal.x, pivotLocal.y + P.w, pivotLocal.z);
            float  d = sqrt(dot(p, p));
            float  t = saturate((max(d - P.w, 0.0) - P.x) * P.y);
            return saturate(mad(t, 1.0 - P.z, P.z));
        }

        struct GrassSurface {
            float3 albedo;
            float3 normalWS;
            float  roughness;
            float  occlusion;     // spherical AO  (_AoParams)
            float  dirShadow;     // spherical direct self-shadow (_DirParams)
            float  transmission;  // back-face translucency strength
            float  alpha;
        };

        GrassSurface BuildGrassSurface(Varyings input, float faceSign)
        {
            GrassSurface s = (GrassSurface)0;

            float2 uv = input.uv;   // base path samples both maps with the same TEXCOORD (b33:195,241; b25:231)

            float3 nGeo = normalize(input.normalWS);
            // Two-sided normal flip: front = +1, back = mad(_TwoSidedNormal,-2,1) (b33:194 / b25:214).
            float  twoSided = (faceSign > 0.0) ? 1.0 : mad(_TwoSidedNormal, -2.0, 1.0);

        #ifdef _NORMAL_MAP
            // --- Normal map decode with upward-bend bias (b33:195-205) ---
            float4 nrm = SAMPLE_TEXTURE2D(_NormalMap, sampler_NormalMap, uv);
            // _207 = mad(mad(_BendNormalUpward, 0.5 - nrm.x, nrm.x), 2, -1)   (b33:198)
            // _210 = mad(mad(_BendNormalUpward, 1.0 - nrm.y, nrm.y), 2, -1)   (b33:199)  (Y biases toward +1)
            float nx = mad(mad(_BendNormalUpward, 0.5 - nrm.x, nrm.x), 2.0, -1.0);
            float ny = mad(mad(_BendNormalUpward, 1.0 - nrm.y, nrm.y), 2.0, -1.0);
            // _223 = max(sqrt(1 - min(dot(nx,ny),1)), 1e-16)                  (b33:200)
            float nz = max(sqrt(1.0 - min(dot(float2(nx, ny), float2(nx, ny)), 1.0)), NORMAL_Z_MIN);
            // _225/_226 = twoSided * (nxy * _NormalScale)                    (b33:201-202)
            float sx = twoSided * (nx * _NormalScale);
            float sy = twoSided * (ny * _NormalScale);
            // bitangent sign _133 = sign(tangentWS.w)                        (b33:193)
            float bitSign = (input.tangentWS.w > 0.0) ? 1.0 : -1.0;
            float3 T = input.tangentWS.xyz;
            float3 B = bitSign * cross(nGeo, T);
            // world normal = nGeo*nz + T*sx + B*sy  (b33:203-205), then normalize
            float3 Nw = nGeo * nz + T * sx + B * sy;
            float  invLen = rsqrt(max(dot(Nw, Nw), RSQRT_MIN));
            // final normal also carries the two-sided sign (b33:207-209 _257 = twoSided * Nw*invLen)
            s.normalWS = twoSided * (Nw * invLen);
            // roughness from normal map B (b33:235)
            s.roughness = mad(nrm.z, _RoughnessMax - _RoughnessMin, _RoughnessMin);
            // mask channel A drives diffuse/transmission masking (b33:215-217)
            float mask = nrm.w - 1.0;                         // _329
            float maskDiffuse = mad(_MaskOnDiffuse, mask, 1.0);       // _334
            float maskTrans   = mad(_MaskOnTransmission, mask, 1.0);  // (b33:217 factor)
            s.transmission = _Transmission * maskTrans;
            s.dirShadow    = SphericalFalloff(input.pivotLocal, _DirParams) * maskDiffuse;
        #else
            // Base geometric path (b25:213-217): geo normal, two-sided flip, no map.
            float  invLen = rsqrt(max(dot(nGeo, nGeo), RSQRT_MIN));
            s.normalWS = twoSided * (nGeo * invLen);
            // Base (no-_NORMAL_MAP) path writes the roughness MRT channel as the CONSTANT 1.0
            // (b25:256 `SV_Target_3.z = 1.0f`), NOT _RoughnessMax. The _RoughnessMin/_RoughnessMax
            // slider pair only drives the per-pixel lerp in the _NORMAL_MAP path (b33:235); with no
            // normal/roughness map the foliage is fully rough. Matching the blob exactly.
            s.roughness = 1.0;
            s.transmission = _Transmission;
            s.dirShadow    = SphericalFalloff(input.pivotLocal, _DirParams);
        #endif

            // --- Albedo (b33:241-247 / b25:231-237) ---
            float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uv);
            float3 albedo  = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale);   // _287..289
            // tint-cover blend toward flat _BaseColor: mad(_BaseColorTintCover, _BaseColor - albedo, albedo)
            s.albedo = mad(_BaseColorTintCover.xxx, _BaseColor.rgb - albedo, albedo);            // _SV_Target_4.xyz

            // --- Spherical contact AO (b33:237-240 / b25:238-241) ---
            s.occlusion = SphericalFalloff(input.pivotLocal, _AoParams);

            // Subsurface scales the transmission contribution (b33:220-224 / b25:249-252).
            s.transmission *= saturate(_SubsurfaceIntensity);

            s.alpha = baseTex.a * _BaseColor.a;
            return s;
        }

        // Forward PBR lighting for the foliage surface. The HG source writes a deferred
        // GBuffer (no lighting in these blobs); URP's deferred layout differs, so we light
        // in forward with URP facilities (the faithful infra substitute, CORE_MATH §1 PORT
        // GUIDANCE). Foliage = dielectric, metallic == 0 (grass has no metallic channel).
        float3 ShadeGrass(GrassSurface s, float3 positionWS)
        {
            float3 N = s.normalWS;
            float3 V = GetWorldSpaceNormalizeViewDir(positionWS);

            // dielectric F0 (0.04) — grass never exposes _Specular/_Metallic.
            float3 f0 = 0.04;
            float  perceptualRoughness = s.roughness;

            float4 shadowCoord = TransformWorldToShadowCoord(positionWS);
            Light mainLight = GetMainLight(shadowCoord);
            float3 L = mainLight.direction;
            float3 H = normalize(L + V);
            float  NoL = saturate(dot(N, L));
            float  NoH = saturate(dot(N, H));
            float  NoV = saturate(dot(N, V));
            float  LoH = saturate(dot(L, H));

            // GGX NDF + height-correlated Smith visibility + Schlick Fresnel.
            // Lighting is URP-substituted infra (grass blobs carry no lighting); the BRDF
            // mirrors the lit-family spine CORE_MATH §2.7 exactly so foliage matches siblings.
            float a  = max(perceptualRoughness * perceptualRoughness, 0.0078125); // min alpha (CORE_MATH §4)
            float a2 = a * a;
            // D: a2 / d^2, d = (NoH*a2 - NoH)*NoH + 1            (CORE_MATH §2.7 _2163)
            float dD = (NoH * a2 - NoH) * NoH + 1.0;
            float D  = a2 / max(dD * dD, 1e-7);
            // Vis (height-correlated): 0.5 / ( NoV*sqrt((-NoL*a2+NoL)*NoL+a2) + NoL*sqrt((-NoV*a2+NoV)*NoV+a2) + 1e-4 )  (_2217)
            float visV = NoL * sqrt((-NoV * a2 + NoV) * NoV + a2);
            float visL = NoV * sqrt((-NoL * a2 + NoL) * NoL + a2);
            float Vis = 0.5 / max(visV + visL, 1e-4);
            float Fc = pow(1.0 - LoH, 5.0);
            float3 F = lerp(f0, 1.0.xxx, Fc);
            float3 spec = (D * Vis) * F;

            float3 lightCol = mainLight.color * (mainLight.shadowAttenuation * mainLight.distanceAttenuation);

            // Direct self-shadow term = the _DirParams spherical falloff (b33:211-217,219 /
            // b25:218-219,253). The blob feeds s.dirShadow DIRECTLY into the deferred diffuse-shadow
            // channel — the falloff floor already bakes the self-shadow strength via mad(t,1-P.z,P.z)
            // (P.z = _DirParams.z, the "intensity"). The standalone _DirIntensity inspector scalar is
            // packed C#-side into _DirParams and is NOT read by any grass blob, so do NOT re-modulate
            // by it here (that would double-apply intensity). Apply s.dirShadow as-is.
            float dirOcc = s.dirShadow;

            float3 diffuse = s.albedo * NoL * dirOcc;
            float3 direct  = (diffuse + spec) * lightCol;

            // Back-face translucency (transmission): light coming through the blade from behind.
            float  backNoL = saturate(dot(-N, L));
            float3 trans   = s.albedo * mainLight.color * (backNoL * s.transmission);

            // Additional lights (diffuse-only is plenty for foliage; keep it cheap & 0-branch-friendly).
        #ifdef _ADDITIONAL_LIGHTS
            uint addCount = GetAdditionalLightsCount();
            for (uint li = 0u; li < addCount; ++li)
            {
                Light al = GetAdditionalLight(li, positionWS);
                float aNoL = saturate(dot(N, al.direction));
                direct += s.albedo * al.color * (aNoL * al.distanceAttenuation * al.shadowAttenuation);
            }
        #endif

            // Ambient (URP SH) modulated by the spherical contact AO.
            float3 ambient = SampleSH(N) * s.albedo * s.occlusion;

            return direct + trans + ambient;
        }
        ENDHLSL

        // ---------------------------------------------------------------------------
        // Forward lit pass — replaces source HGBuffer (LIGHTMODE=GBuffer).
        // Source render-state: ZTest [_ZTestGBuffer] / Cull [_CullMode] / Stencil Ref [_StencilRef]
        //   (grass.shader:95-104). Stencil = HG deferred material-id; dropped for forward.
        // ---------------------------------------------------------------------------
        Pass {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForwardOnly" }
            ZTest LEqual
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex GrassVert
            #pragma fragment GrassFrag

            #pragma shader_feature_local _NORMAL_MAP
            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local_vertex _ANIMATE_VERTEX_GRASS

            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile_fragment _ _SHADOWS_SOFT
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
            #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
            #pragma multi_compile_fog

            half4 GrassFrag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                float faceSign = isFrontFace ? 1.0 : -1.0;
                GrassSurface s = BuildGrassSurface(input, faceSign);

            #ifdef _ALPHATEST_ON
                // Alpha clip (source clips on baseSample.a * _BaseColor.a, _AlphaClipThreshold).
                clip(s.alpha - _AlphaClipThreshold);
            #endif

                float3 color = ShadeGrass(s, input.positionWS);
                color = MixFog(color, ComputeFogFactor(input.positionCS.z));
                return half4(color, 1.0);   // opaque (grass writes alpha=1 in source, b25:263)
            }
            ENDHLSL
        }

        // ---------------------------------------------------------------------------
        // ShadowCaster — source Pass "ShadowCaster" (LIGHTMODE=SHADOWCASTER, Cull [_CullMode]).
        // Source vertex b84 transforms OS->WS->shadow-clip via HG's _ShadowpassVP; URP's
        // ApplyShadowBias is the faithful infra substitute (CORE_MATH §4.1). Base fragment
        // is empty depth-only; alpha-clip only under _ALPHATEST_ON (source clips in HGBuffer,
        // and the shadow ladder carries _ALPHATEST_ON variants b86+).
        // ---------------------------------------------------------------------------
        Pass {
            Name "ShadowCaster"
            Tags { "LightMode" = "ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex ShadowVert
            #pragma fragment ShadowFrag

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local_vertex _ANIMATE_VERTEX_GRASS
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW

            float3 _LightDirection;
            float3 _LightPosition;

            struct ShadowAttributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 color      : COLOR;
                float2 uv0        : TEXCOORD0;
            };

            struct ShadowVaryings {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
            };

            ShadowVaryings ShadowVert(ShadowAttributes input)
            {
                ShadowVaryings output = (ShadowVaryings)0;
                float3 positionOS = ApplyGrassWind(input.positionOS, input.color, input.positionOS);

                float3 positionWS = TransformObjectToWorld(positionOS);
                float3 normalWS   = TransformObjectToWorldNormal(input.normalOS);

            #if defined(_CASTING_PUNCTUAL_LIGHT_SHADOW)
                float3 lightDirWS = normalize(_LightPosition - positionWS);
            #else
                float3 lightDirWS = _LightDirection;
            #endif
                float4 positionCS = TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDirWS));
            #if UNITY_REVERSED_Z
                positionCS.z = min(positionCS.z, UNITY_NEAR_CLIP_VALUE);
            #else
                positionCS.z = max(positionCS.z, UNITY_NEAR_CLIP_VALUE);
            #endif
                output.positionCS = positionCS;
                output.uv = input.uv0;
                return output;
            }

            half4 ShadowFrag(ShadowVaryings input) : SV_Target
            {
            #ifdef _ALPHATEST_ON
                float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, input.uv);
                clip(baseTex.a * _BaseColor.a - _AlphaClipThreshold);
            #endif
                return 0;
            }
            ENDHLSL
        }

        // ---------------------------------------------------------------------------
        // DepthOnly — source Pass "DepthOnly" (LIGHTMODE=DepthOnly, Cull [_CullMode],
        // Stencil Ref [_StencilRef]). Vertex b120 = camera clip; base fragment empty.
        // ---------------------------------------------------------------------------
        Pass {
            Name "DepthOnly"
            Tags { "LightMode" = "DepthOnly" }
            ZWrite On
            ColorMask R
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex DepthVert
            #pragma fragment DepthFrag

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local_vertex _ANIMATE_VERTEX_GRASS

            struct DepthAttributes {
                float3 positionOS : POSITION;
                float4 color      : COLOR;
                float2 uv0        : TEXCOORD0;
            };

            struct DepthVaryings {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
            };

            DepthVaryings DepthVert(DepthAttributes input)
            {
                DepthVaryings output = (DepthVaryings)0;
                float3 positionOS = ApplyGrassWind(input.positionOS, input.color, input.positionOS);
                output.positionCS = TransformObjectToHClip(positionOS);
                output.uv = input.uv0;
                return output;
            }

            half4 DepthFrag(DepthVaryings input) : SV_Target
            {
            #ifdef _ALPHATEST_ON
                float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, input.uv);
                clip(baseTex.a * _BaseColor.a - _AlphaClipThreshold);
            #endif
                return 0;
            }
            ENDHLSL
        }

        // ---------------------------------------------------------------------------
        // DepthNormals — provides world normal for URP SSAO/depth-normals prepass.
        // (Source emits the world normal into the HGBuffer octahedral channel, b25:229-230 /
        // b33:233-234; URP consumes a DepthNormals prepass instead.)
        // ---------------------------------------------------------------------------
        Pass {
            Name "DepthNormals"
            Tags { "LightMode" = "DepthNormals" }
            ZWrite On
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex GrassVert
            #pragma fragment DepthNormalsFrag

            #pragma shader_feature_local _NORMAL_MAP
            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local_vertex _ANIMATE_VERTEX_GRASS

            half4 DepthNormalsFrag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                float faceSign = isFrontFace ? 1.0 : -1.0;
                GrassSurface s = BuildGrassSurface(input, faceSign);
            #ifdef _ALPHATEST_ON
                clip(s.alpha - _AlphaClipThreshold);
            #endif
                return half4(NormalizeNormalPerPixel(s.normalWS), 0.0);
            }
            ENDHLSL
        }
    }
    Fallback Off
}
