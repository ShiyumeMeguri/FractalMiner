// HGRP LitWater (forward-rendered transparent water surface) -> URP. Single pass: ForwardLit (transparent).
// Merged from: litwater.shader (one self-contained ForwardLit pass; vertex + fragment HLSL inlined directly in the
//   ShaderLab, NOT a #if/#else keyword ladder — the only multi_compile_local are HG_ENABLE_MV / SRP_INSTANCING_ON,
//   which gate engine motion-vector / instancing infra only. The base variant IS the whole shader). Source path:
//   .../com.hg.render-pipelines/runtime/shaders/materials/water/litwater.shader. Vertex = lines 282-456, Fragment = 767-2368.
// Keywords (none in source affect pixels): _ENABLE_SEA_WAVE / _ENABLE_DETAIL_SEAWAVE exist as Properties + per-vertex
//   gerstner/tide code paths, but are NOT compiled into this base blob (separate keyword variants, absent here) -> see GAPS.
// Kept (1:1 from litwater fragment, cited per block below):
//   - Flow-map cyclic blend of the small-wave normal map (2 phase taps + triangle blend weight, frag 339-419),
//   - Large-wave normal (directional flow) reoriented into the small-wave tangent frame (frag 432-501),
//   - Foam assembly: flow-noise-perturbed foam mask R/G + base, clamped * _FoamOpacity (frag 515-564),
//   - World-space perturbed normal via per-pixel TBN from interpolated N/T + flow normal (frag 619-660), foam-aware roughness (frag 639-652),
//   - PBR split F0 = 0.08*_Specular dielectric, GGX-D + Smith height-correlated Vis + Schlick F direct light (frag 1006-1130, == CoreMath),
//   - Env-BRDF (envSpecScale/-Bias) + EnvBRDFApprox DFG poly + 1/21 grazing multiscatter (frag 1030-1130 / 4055-4094),
//   - SSR screen-space ray-march reflection blended with probe reflection by _UseSSR/_SSRStrength (frag 3170-4371),
//   - Env-spec desaturation (_EnvSpecularDesaturation) toward luma + _EnvLightSpecularIntensity (frag 3149-3169),
//   - WATER VOLUME: refracted scene-color sample (water IOR bend + screen reproject), Beer-Lambert transmittance
//     exp(-d*(scatter+absorb)) per channel, single-scatter in-scatter with Rayleigh/Mie phase blend (_RayleighMieLerpFactor),
//     ambient-light water scatter, full-absorption fallback color (frag 4391-2362). THIS is the heart of the water look.
// Removed (pixel-neutral pipeline infra, substituted by URP per STYLE_BIBLE §2 / CORE_MATH §2.12):
//   GPU instancing per-draw array + octahedral vertex decode (vert 133-426) -> GetVertexPositionInputs/GetVertexNormalInputs;
//   HG motion-vector dual-frame + SV_Target1 (MV/TAAU pack, frag 2364-2367) -> dropped (URP has a MotionVectors pass);
//   IV-clipmap SH cascade T13-T18 (frag 1675-1914) -> SampleSH(N); reflection-probe binning T0/T3 + box-projection (frag 2310-3138) -> GlossyEnvironmentReflection;
//   CSM+ASM+cloud shadow atlases T7/T8/T9/T10 (frag 864-1086) -> URP main-light shadowAttenuation; tile/zbin punctual loop T0 (frag 1146-1674) -> GetAdditionalLight loop;
//   atmosphere/exponential/volumetric froxel fog T19 (frag 2288-2347) -> MixFog;
//   SSR / refraction depth+color buffers (HG T2 depth pyramid, T1 prev-color, T6 scene-color) -> URP _CameraDepthTexture / _CameraOpaqueTexture.
//
// NOTE: the source ForwardLit pass (LIGHTMODE=ForwardOnly, Queue 3000 Transparent) maps to URP UniversalForwardOnly,
//   Blend SrcAlpha OneMinusSrcAlpha (source Blend0 line 103). SV_Target.w = 1.0 in source (frag 2363) — opacity is baked
//   into the Beer-Lambert composite (transmittance term carries the "see-through"), so the surface writes a=1 and relies on
//   the refracted scene-color already being mixed in. We keep that: alpha output = 1.0 (1:1 frag 2363).
//   Water absorption/scatter uses _WaterRayleighScatteringMeter / _WaterRayleighAbsorptionMeter (per-channel σ_s, σ_a) — these
//   are [HideInInspector] driven by the _WaterType preset + _OverridePhysicalSetting on the C# side; exposed here as material Vectors.
//   _CullMode default Front (2) like source line 5 (water seen from above renders its underside in HG's convention).

Shader "HGRP/LitWater_Fix" {
    Properties {
        // ---- Blend-state plumbing (source is always-transparent; defaults = SrcAlpha/OneMinusSrcAlpha) ----
        [HideInInspector] _SrcBlend ("__src", Float) = 5      // SrcAlpha  (source Blend0, litwater.shader:103)
        [HideInInspector] _DstBlend ("__dst", Float) = 10     // OneMinusSrcAlpha
        [HideInInspector] _ZWrite ("__zw", Float) = 0         // transparent: no depth write
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2   // source line 5 default Front
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [Enum(FastConvergeTransparent, 0, ResponsiveTransparent, 1)] _TransparentTypeForTAAU ("Transparent Type For TAAU", Float) = 1

        // ---- Water base params (source lines 6-9) ----
        _Specular ("Specular", Range(0, 1)) = 0.5
        _Roughness ("Roughness", Range(0, 1)) = 0.1
        _DistanceFade ("Normal Distance Fade", Range(0, 10000)) = 300
        _OcclusionStrength ("Occlusion Strength", Range(-2, 10)) = 1

        // ---- Water physical (absorption / scattering) — preset-driven, exposed as Vectors (source lines 11-21) ----
        [Enum(Clean_Blue, 0, MidClean_Blue, 1, FullClean, 2, Dirty_Black, 3, Dirty_Green, 4)] _WaterType ("Water Type Preset", Float) = 2
        _WaterRayleighScatteringMeter ("Water Scattering (per m, RGB)", Vector) = (1, 1, 1, 1)
        _WaterRayleighAbsorptionMeter ("Water Absorption (per m, RGB)", Vector) = (1, 1, 1, 1)
        _RayleighMieLerpFactor ("Rayleigh/Mie Phase Lerp", Range(0, 1)) = 0.92
        [Enum(No, 0, Yes, 1)] _OverridePhysicalSetting ("Use Custom Physical", Float) = 1
        _AbsorptionTint ("Global Tint", Color) = (1, 1, 1, 1)
        _ScatterTint ("Lit Tint", Color) = (1, 1, 1, 1)
        _AbsorptionScale ("Opacity", Range(0.01, 20)) = 1
        _ScatterScale ("Lit Color Intensity", Range(0.01, 5)) = 1
        _EnvLightIntensity ("Env Scatter Intensity", Range(0, 1)) = 0
        _SafeFullAbsorpDistance ("Full Absorption Distance", Float) = 0

        // ---- Lighting (source lines 23-26) ----
        [Enum(No, 0, Yes, 1)] _UseSSR ("Use SSR", Float) = 1
        _SSRStrength ("SSR Strength", Range(0, 1)) = 0.5
        _EnvSpecularDesaturation ("Env Spec Desaturation", Range(0, 1)) = 0
        _EnvLightSpecularIntensity ("Env Spec Intensity", Range(0, 2)) = 0

        // ---- Refraction (source line 28) ----
        _WaterIOR ("Water IOR", Range(0.001, 1)) = 0.1

        // ---- Wave (flow map + dual normal) — source lines 30-40 ----
        _FlowTex ("Flow Map", 2D) = "white" {}
        _FlowSpeed ("Flow Speed", Range(0, 5)) = 0.05
        [HideInInspector] _FlowFullCycle ("Flow Full Cycle", Range(0, 10)) = 1
        _NormalMap ("Small Wave Normal", 2D) = "bump" {}
        _NormalTilling ("Small Wave Tilling", Range(0, 100)) = 5
        _NormalScale ("Small Wave Normal Scale", Range(1E-05, 2)) = 1
        _LargeWaveNormalMap ("Large Wave Normal", 2D) = "bump" {}
        _LargeWaveNormalTilling ("Large Wave Tilling", Range(0, 20)) = 1
        _LargeWaveNormalScale ("Large Wave Normal Scale", Range(1E-05, 2)) = 1
        _LargeWaveFlowSpeed ("Large Wave Flow Speed", Range(0, 0.1)) = 1
        _LargeWaveDir ("Large Wave Flow Dir", Vector) = (-1, -1, 0, 0)

        // ---- Foam (source lines 42-48) ----
        _FoamOpacity ("Foam Opacity", Range(0, 5)) = 1
        _FoamRoughness ("Foam Roughness", Range(0, 2)) = 1
        _FoamNormalStrength ("Foam Normal Strength", Range(0, 1)) = 0.5
        [HDR] _FoamColorR ("Foam R Channel Color", Color) = (1, 1, 1, 1)
        [HDR] _FoamColorG ("Foam G Channel Color", Color) = (1, 1, 1, 1)
        [HDR] _FlowBaseColor ("Foam Base Color", Color) = (1, 1, 1, 1)
        _FlowNoiseStrength ("Flow Noise Strength", Range(0, 0.2)) = 0.01

        // ---- Caustic (source lines 50-53) — sampled only in the keyword sea-wave path (absent in base) ----
        _CausticMap ("Caustic Map", 2D) = "white" {}
        _CausticOpacity ("Caustic Opacity", Range(0, 2)) = 1
        _CausticTilling ("Caustic Density", Range(0, 0.5)) = 2
        _CausticDistortStrength ("Caustic Distort Strength", Range(0, 2)) = 1

        // ---- HGRP globals re-exposed as material Vectors (URP has no equivalent; STYLE_BIBLE §1.5) ----
        _EnvironmentGlobalParams0 ("Env Global Params0 (.x amb .y refl)", Vector) = (1, 1, 0, 0)
        _GraphicsFeaturesGlobalParam0 ("Gfx Feature Param0 (.z reflScale)", Vector) = (0, 0, 1, 0)
    }

    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Transparent" "Queue"="Transparent" }
        LOD 300

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareOpaqueTexture.hlsl"

        // ============================================================
        // UnityPerMaterial — every uniform the HLSL reads exactly once (source cbuffer type_UnityPerMaterial, lines 531-561,
        //   re-ordered by logical group, NOT packoffset). HGRP globals re-exposed as material Vectors at the tail.
        // ============================================================
        CBUFFER_START(UnityPerMaterial)
            float4 _FlowTex_ST;
            float4 _NormalMap_ST;
            float4 _LargeWaveNormalMap_ST;
            float4 _CausticMap_ST;
            // Water base
            float  _Specular;
            float  _Roughness;
            float  _DistanceFade;
            float  _OcclusionStrength;
            // Water physical
            float4 _WaterRayleighScatteringMeter;   // .xyz = σ_s per channel (source c11)
            float4 _WaterRayleighAbsorptionMeter;   // .xyz = σ_a per channel (source c12)
            float  _RayleighMieLerpFactor;
            float  _AbsorptionScale;
            float  _ScatterScale;
            float  _EnvLightIntensity;
            float  _SafeFullAbsorpDistance;
            float4 _AbsorptionTint;
            float4 _ScatterTint;
            float  _WaterType;
            float  _OverridePhysicalSetting;
            // Lighting
            float  _UseSSR;
            float  _SSRStrength;
            float  _EnvSpecularDesaturation;
            float  _EnvLightSpecularIntensity;
            float  _TransparentTypeForTAAU;
            // Refraction
            float  _WaterIOR;
            // Wave
            float  _FlowSpeed;
            float  _FlowFullCycle;
            float  _NormalTilling;
            float  _NormalScale;
            float  _LargeWaveNormalTilling;
            float  _LargeWaveNormalScale;
            float  _LargeWaveFlowSpeed;
            float4 _LargeWaveDir;
            // Foam
            float  _FoamOpacity;
            float  _FoamRoughness;
            float  _FoamNormalStrength;
            float4 _FoamColorR;
            float4 _FoamColorG;
            float4 _FlowBaseColor;
            float  _FlowNoiseStrength;
            // Caustic
            float  _CausticOpacity;
            float  _CausticTilling;
            float  _CausticDistortStrength;
            // HGRP globals re-exposed
            float4 _EnvironmentGlobalParams0;
            float4 _GraphicsFeaturesGlobalParam0;
        CBUFFER_END

        TEXTURE2D(_FlowTex);              SAMPLER(sampler_FlowTex);
        TEXTURE2D(_NormalMap);            SAMPLER(sampler_NormalMap);
        TEXTURE2D(_LargeWaveNormalMap);   SAMPLER(sampler_LargeWaveNormalMap);
        TEXTURE2D(_CausticMap);          SAMPLER(sampler_CausticMap);

        // ============================================================
        // §0.4 Decoded magic-constant table (denormalized-float bit patterns -> real values), as spelled in the blob.
        //   These are ALGORITHM boundaries (epsilons / luma / phase constants), preserved EXACTLY.
        // ============================================================
        static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709 luma, frag 2352
        static const float  EPS_VIEWLEN   = 9.9999999392252902907785028219223e-09; // = 1e-8 ; rsqrt/denominator guard, frag 782
        static const float  EPS_NORMAL_Z  = 1.000000016862383526387164645044e-16;  // = 1e-16 ; derived tangent-normal Z floor, frag 812/821
        static const float  EPS_HALF      = 6.103515625e-05;                        // = 2^-14 ; half-precision rsqrt guard, frag 1102/1113
        static const float  EPS_VIS       = 9.9999997473787516355514526367188e-05;  // = 1e-4  ; Smith-visibility denominator floor, frag 1130
        static const float  FLT_MIN_GUARD = 1.1754943508222875079687365372222e-38f; // = FLT_MIN ; normalize rsqrt guard, frag 848
        static const float  DIELECTRIC_F0 = 0.07999999821186065673828125;           // = 0.08  ; dielectric F0 base = 0.08*_Specular, frag 858
        static const float  GRAZING_FLOOR = 0.0476190485060214996337890625;         // = 1/21  ; multiscatter-diffuse grazing floor, frag 1129
        static const float  LOG2_E        = 1.44269502162933349609375;              // = log2(e) ; exp(x) = exp2(x*log2e), frag 2280+ (Beer-Lambert)
        static const float  INV_4PI       = 0.0596831031143665313720703125;         // = 3/(16π) Rayleigh-ish phase coeff, frag 2356/2358
        static const float  FOUR_PI       = 12.56637096405029296875;                // = 4π ; phase normalization, frag 2355/2359
        static const float  MIE_PHASE_K0  = 0.271066606044769287109375;             // Mie phase numerator, frag 2355
        static const float  SCATTER_PHASE_A = 1.7075519561767578125;                // single-scatter angular term slope, frag 2283
        static const float  SCATTER_PHASE_B = 1.7289333343505859375;                // single-scatter angular term bias, frag 2283

        // ============================================================
        // §2.6 Karis analytic ENVIRONMENT-BRDF / horizon energy (frag 4055-4094, the SSR/reflection gate; same form as
        //   CoreMath HgEnvBRDF). Used to scale F0 for the ambient/SSR specular reflection. Poly coeffs LOAD-BEARING.
        //     envF (_4055)        = min((1-r)^2, exp2(-9.28*NoV))*(1-r) + (r*-0.0275 + 0.0425)
        //     envSpecScale (_4094 left)  = 0.08*_Specular * (envF*-1.04 + (r*-0.572 + 1.04))
        //     envSpecBias  (_4094 right) = (envF*1.04 + (r*0.022 - 0.04)) * saturate(4*_Specular)
        //     gate = F0scale*envF... applied as reflection * (dielF0*scale + bias). (frag 4094)
        // ============================================================
        void WaterEnvBRDF(float roughness, float NoV, float dielF0, float specular,
                          out float envSpecScale, out float envSpecBias)
        {
            float oneMinusRough = mad(roughness, -1.0, 1.0);                                              // frag 4157 (_4036)
            // _4055: NoV here = dot(reflViewN, geoN) saturated (frag 2158 uses dot(halfwayN, geoN))
            float envF = mad(min(oneMinusRough * oneMinusRough, exp2(NoV * -9.27999973297119140625)),
                             oneMinusRough,
                             mad(roughness, -0.0274999998509883880615234375, 0.0425000004470348358154296875)); // frag 4158 (_4055)
            // _4094 left  = dielF0 * (envF*-1.04 + (r*-0.572 + 1.04))
            envSpecScale = dielF0 * mad(envF, -1.03999996185302734375,
                                        mad(roughness, -0.572000026702880859375, 1.03999996185302734375));     // frag 4161
            // _4094 right = (envF*1.04 + (r*0.022 - 0.04)) * saturate(4*_Specular)
            envSpecBias  = mad(envF, 1.03999996185302734375,
                               mad(roughness, 0.02199999988079071044921875, -0.039999999105930328369140625))
                         * clamp(4.0 * specular, 0.0, 1.0);                                                    // frag 4161
        }

        // ============================================================
        // §2.6 EnvBRDFApprox DFG polynomial (frag 1030/1127/1562/1159, _1030/_1562) — Karis/Lazarov in perceptual roughness,
        //   feeds the direct-light multiscatter-diffuse energy. Coeffs 1:1 load-bearing.
        //     dfg = min( t*(t*((-t)*0.38302600 - 0.07619470) + 1.04997003) + 0.40925499, 0.999 ), t = 1-roughness
        // ============================================================
        float WaterEnvBRDFApproxDFG(float roughness)
        {
            float t = mad(roughness, -1.0, 1.0);                                                          // frag 1126 (_1021)
            return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875, -0.076194703578948974609375),
                                  1.04997003078460693359375),
                           0.4092549979686737060546875),
                       0.999000012874603271484375);                                                       // frag 1127 (_1030)
        }

        // ============================================================
        // §2.7/§2.8 Analytic-light specular: Cook-Torrance GGX-D + Smith height-correlated Vis + Schlick F (frag 1006-1130).
        //   1:1 identical to CoreMath HgDirectSpecular (the water frag re-derives the same _1007/(_1010*_1010) GGX-D and
        //   0.5/(...) Smith-Vis at lines 1120-1130 / 6091-6139). Returns specular RGB (NOT yet *NoL).
        //   NOTE the water frag's Schlick uses the multiscatter-diffuse "DFG" path for the diffuse term; the *specular* Fresnel
        //   is folded as F0*F0/(1-F0*(1-dfg)) energy (frag 1129-1130 `_1039*_1039 / mad(-_1039,_1033,1)`), where
        //   _1039 = dielF0 + (1-0.08*_Specular)*(1/21) is the grazing-lifted F0. We mirror that exact structure below.
        // ============================================================
        // GGX-D * Smith-Vis (the "_1091 left" specular lobe; frag 1120-1130 left term).
        float WaterGGXSmith(float roughness, float NoL, float NoH, float NoV)
        {
            float a2sq = roughness * roughness;     // _1006 = sqr(rough) (note: water's _652 IS the roughness, _1006 = _652^2)
            float a4   = a2sq * a2sq;               // _1007 = _1006*_1006
            float nl   = NoL;                        // _997 (clamped at call site)
            float nv   = NoV;                        // _1005 (clamped at call site)
            // GGX NDF: D = a4 / (((NoH*a4 - NoH)*NoH + 1)^2)  (frag 1122 _1010 = mad(mad(NoH,_1007,-NoH),NoH,1))
            float d    = mad(mad(NoH, a4, -NoH), NoH, 1.0);                                                // frag 1122 (_1010)
            float D    = a4 / (d * d);                                                                     // frag 1130 (_1007/(_1010*_1010))
            // Smith height-correlated Vis = 0.5 / (nv*sqrt((-nl*a4+nl)*nl+a4) + nl*sqrt((-nv*a4+nv)*nv+a4) + 1e-4)
            float visDenom = nv * sqrt(mad(mad(-nl, a4, nl), nl, a4))                                      // frag 1130 lambdaV (_1005*sqrt(...))
                           + nl * sqrt(mad(mad(-nv, a4, nv), nv, a4))                                      // frag 1130 lambdaL (_997*sqrt(...))
                           + EPS_VIS;
            return D * (0.5 / visDenom);                                                                   // frag 1130 (_1007/(_1010*_1010)) * (0.5/(...))
        }

        // Multiscatter-diffuse + Fresnel-energy specular term (the "_1091 right" energy; frag 1127-1130 right term).
        //   _1039 = mad(mad(-_Specular,0.08,1), 1/21, 0.08*_Specular) = dielF0 + (1-dielF0)*(1/21)  (grazing-lifted F0)
        //   right = (dfg * DFG_LUT^2 / (1-dfg)) * (_1039^2) / (1 - _1039*(1-dfg))   ... DFG_LUT replaced by analytic dfg.
        float WaterSpecEnergyRight(float roughness, float dielF0, float specular, float NoL, float NoV)
        {
            float dfg = WaterEnvBRDFApproxDFG(roughness);                                                 // frag 1127 (_1030)
            float oneMinusDfg = mad(-dfg, 1.0, 1.0);                                                       // frag 1128 (_1033)
            float f0g = mad(mad(-specular, DIELECTRIC_F0, 1.0), GRAZING_FLOOR, DIELECTRIC_F0 * specular);  // frag 1129 (_1039)
            // HG multiplies dfg by a 2D split-sum DFG LUT product T12(NoV)*T12(NoL) (frag 1130 _1091 left-inner). T12 is engine
            // infra with no URP binding -> substitute the analytic dfg for the product (CORE_MATH §2.6/§2.12).
            float dfgProd = dfg;                                                                           // frag 1130 (T12·T12 -> dfg)
            return ((dfgProd / oneMinusDfg) * (f0g * f0g)) / mad(-f0g, oneMinusDfg, 1.0);                  // frag 1130 right
        }

        // ============================================================
        // §2.2 View dir V (world). perspective = normalize(camPos - P) ; ortho = -camera forward (frag 774-786).
        //   URP: unity_OrthoParams.w ortho flag ; ortho fwd = -UNITY_MATRIX_V row2 (STYLE_BIBLE §2).
        //   Returns normalized V and outputs linear eye distance (frag 786 _232 = distSq*invLen).
        // ============================================================
        float3 WaterViewDirWS(float3 positionWS, out float eyeDist)
        {
            float3 viewRaw = (unity_OrthoParams.w == 0.0)
                           ? (_WorldSpaceCameraPos - positionWS)                                           // frag 775-777 (_194..196)
                           : -float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22);       // frag 778-780 (ortho: -ViewMatrix col2)
            float distSq = dot(viewRaw, viewRaw);                                                          // frag 781 (_222)
            float invLen = rsqrt(max(distSq, EPS_VIEWLEN));                                                // frag 782 (_228)
            eyeDist = distSq * invLen;                                                                     // frag 786 (_232)
            return viewRaw * invLen;                                                                       // frag 783-785 (_229..231)
        }

        // ============================================================
        // §2.5 SSR screen-space ray-march (frag 2053-2165). 1:1 port of HG's hierarchical depth march.
        //   Source builds a view-space reflection ray, projects its screen-space direction (_3306/_3307 ndc-delta) and
        //   depth slope (_3335), screen-border-clamps it (_3332), jitters the start by an interleaved-gradient dither
        //   (_3355), then marches up to 32 iterations sampling the DEPTH buffer (HG T2 -> URP _CameraDepthTexture) at 4
        //   coarse sub-taps per step, advancing by 1/16 of the ray each iter; on a depth crossing it sub-step-refines and
        //   reports the hit screen UV + an edge-fade (_4339). The hit-COLOR source (HG T1 = previous-frame color history)
        //   has no URP forward binding -> the caller samples the current-frame opaque texture at hitUV instead (see note).
        //   (1:1, source = litwater.shader:2053-2165 _3170/_3214..3261/_3299..3361/_3642..3993/_4063/_4339.)
        // ============================================================
        bool WaterSSRMarch(float3 positionWS, float3 N, float2 fragNDC, float fragDeviceZ,
                           out float2 hitUV, out float edgeFade)
        {
            hitUV = float2(0.0, 0.0);
            edgeFade = 0.0;
            // view-space fragment-position dir (_3214..3216) and view-space normal (_3251..3253), then reflect (_3259..3261).
            float3 viewV = normalize(TransformWorldToView(positionWS));                                    // frag 3207-3216 (_3214..3216)
            float3 viewN = TransformWorldToViewDir(N, false);                                              // frag 3243-3253 (_3251..3253; rsqrt-normalized below by reflect form)
            viewN = viewN * rsqrt(max(dot(viewN, viewN), EPS_VIEWLEN));                                    // frag 3250 (_3250 normalize of the 4-vec; view dir part)
            float3 viewR = mad(viewN, (-2.0 * dot(viewV, viewN)).xxx, viewV);                              // frag 3258-3261 (_3259..3261 = reflect(viewV,viewN))
            // project reflected endpoint: perspective w guard _3299, screen-space ray dir _3306/_3307, depth slope _3335.
            float  projW = max(mad(UNITY_MATRIX_P._m30, viewR.x, UNITY_MATRIX_P._m31 * viewR.y + UNITY_MATRIX_P._m32 * viewR.z) + 1.0, EPS_VIS); // frag 3299 (_3299)
            float  rayX  = mad(mad(UNITY_MATRIX_P._m00, viewR.x, UNITY_MATRIX_P._m01 * viewR.y + UNITY_MATRIX_P._m02 * viewR.z), 1.0, fragNDC.x) / projW - fragNDC.x; // frag 3306 (_3306)
            float  rayY  = mad(mad(UNITY_MATRIX_P._m10, viewR.x, UNITY_MATRIX_P._m11 * viewR.y + UNITY_MATRIX_P._m12 * viewR.z), -1.0, fragNDC.y) / projW - fragNDC.y; // frag 3307 (_3307)
            float  rayZ  = mad(mad(UNITY_MATRIX_P._m20, viewR.x, UNITY_MATRIX_P._m21 * viewR.y + UNITY_MATRIX_P._m22 * viewR.z), 1.0, fragDeviceZ) / projW - fragDeviceZ; // frag 3335 (_3335 inner)
            // screen-border clamp scale _3332 (limit ray length so its xy stays inside [-1,1] ndc).
            float  rayLen = sqrt(dot(float2(rayX, rayY), float2(rayX, rayY)));                             // frag 3312 (_3312)
            float  halfLen = rayLen * 0.5;                                                                 // frag 3313 (_3313)
            float  negLen = -rayLen;                                                                       // frag 3316 (_3316)
            float  clampX = (-(max(mad(negLen, 0.5, abs(mad(fragNDC.x, halfLen, rayX))), 0.0) / abs(rayX))) + 1.0; // frag 3332 inner-x
            float  clampY = (-(max(mad(negLen, 0.5, abs(mad(fragNDC.y, halfLen, rayY))), 0.0) / abs(rayY))) + 1.0; // frag 3332 inner-y
            float  scale = min(clampY, clampX) / halfLen;                                                  // frag 3332 (_3332)
            float  stepX = scale * rayX;                                                                   // frag 3333 (_3333)
            float  stepY = scale * rayY;                                                                   // frag 3334 (_3334)
            float  stepZ = scale * rayZ;                                                                   // frag 3335 (_3335 = _3332 * z-delta)
            float  thresh = max(abs(stepZ) * 0.03125, EPS_VIS);                                            // frag 3338 (_3338) depth-compare half-thickness
            // interleaved-gradient dither _3355 (uses pixel-center _244/_246 = floor(gl_FragCoord)+0.5; URP: positionCS.xy).
            //   Source adds a per-FRAME phase (_3347 = float(7u & _FrameCount)) into the pixel coords for temporal SSR jitter.
            //   _FrameCount is HG temporal-accumulation infra (resolved by TAAU); dropped here (no TAA pass) -> phase 0, so the
            //   dither is purely spatial (interleaved-gradient). This is a temporal-jitter omission, NOT a math deviation.
            float  pxc = (fragNDC.x * 0.5 + 0.5) * _ScreenParams.x;                                        // _244 pixel-center x
            float  pyc = (fragNDC.y * 0.5 + 0.5) * _ScreenParams.y;                                        // _246 pixel-center y
            float  jitter = frac(frac(dot(float2(pxc, pyc), float2(0.067110560834407806396484375, 0.005837149918079376220703125))) * 52.98291778564453125); // frag 3355 (_3355, _3347 frame phase = 0)
            // start position: ndc->uv + jittered 1/64 xy step; z start + jittered z step (frag 3359-3361).
            float  baseU = mad(stepX * 0.015625, jitter, mad(fragNDC.x, 0.5, 0.5));                        // frag 3359 (_3359)
            float  baseV = mad(stepY * 0.015625, jitter, mad(fragNDC.y, 0.5, 0.5));                        // frag 3360 (_3360)
            float  baseZ = mad(stepZ * 0.03125, jitter, fragDeviceZ);                                      // frag 3361 (_3361)
            float  prevDiff = (-SampleSceneDepth(float2(baseU, baseV))) + baseZ;                           // frag 3367 (_3367) sceneDepth(-)rayZ at start
            // march: up to 32 iters, 4 coarse taps each, advance 1/16 of the ray per iter (frag 2106-2150).
            bool   found = false;
            float  outU = 0.0, outV = 0.0;
            [loop] for (uint iter = 0u; iter < 32u; iter += 4u)
            {
                float u1 = mad(stepX, 0.015625, baseU);   float v1 = mad(stepY, 0.015625, baseV);          // frag 3822-3823
                float u2 = mad(stepX, 0.03125,  baseU);   float v2 = mad(stepY, 0.03125,  baseV);          // frag 3824-3825
                float u3 = mad(stepX, 0.046875, baseU);   float v3 = mad(stepY, 0.046875, baseV);          // frag 3826-3828
                float u4 = mad(stepX, 0.0625,   baseU);   float v4 = mad(stepY, 0.0625,   baseV);          // frag 2123 inner
                float d1 = mad(stepZ, 0.03125,  baseZ) + (-SampleSceneDepth(float2(u1, v1)));              // frag 3854 (_3854)
                float d2 = mad(stepZ, 0.0625,   baseZ) + (-SampleSceneDepth(float2(u2, v2)));              // frag 3855 (_3855)
                float d3 = mad(stepZ, 0.09375,  baseZ) + (-SampleSceneDepth(float2(u3, v3)));              // frag 3856 (_3856)
                float d4 = mad(stepZ, 0.125,    baseZ) + (-SampleSceneDepth(float2(u4, v4)));              // frag 3645 (_3645)
                bool h1 = abs(thresh + d1) < thresh;                                                       // frag 3865 (_3865)
                bool h2 = abs(thresh + d2) < thresh;                                                       // frag 3866 (_3866)
                bool h3 = abs(thresh + d3) < thresh;                                                       // frag 3867 (_3867)
                bool h4 = abs(thresh + d4) < thresh;                                                       // frag 2127 inner (_3645 compare)
                if (!(h1 || h2 || h3 || h4))                                                               // frag 2127 (no crossing in this step)
                {
                    baseU = u4;                                                                            // frag 3646 advance 1/16 (= 0.0625)
                    baseV = v4;                                                                            // frag 3648
                    baseZ = mad(stepZ, 0.125, baseZ);                                                      // frag 3650
                    prevDiff = d4;                                                                         // frag 3644 (= _3645)
                    continue;
                }
                // hit: pick the first crossing tap (h1 uses prevDiff, else the tap's own diff) and sub-step refine (_3985).
                float numer = h1 ? prevDiff : (h2 ? d1 : (h3 ? d2 : d3));                                  // frag 3973 (_3973)
                float denom = -(h1 ? d1 : (h2 ? d2 : (h3 ? d3 : d4))) + numer;                             // frag 3985 denom
                float tapBase = h1 ? 0.0 : (h2 ? 1.0 : (h3 ? 2.0 : 3.0));                                  // frag 3985 (asfloat selects 0/1/2/3)
                float refine = clamp(numer / denom, 0.0, 1.0) + tapBase;                                   // frag 3985 (_3985)
                outU = mad(stepX * 0.015625, refine, baseU);                                               // frag 3992 (_3992) = _3339*_3985 + base
                outV = mad(stepY * 0.015625, refine, baseV);                                               // frag 3993 (_3993) = _3340*_3985 + base
                found = true;
                break;
            }
            if (found)
            {
                hitUV = float2(outU, outV);
                // edge-fade _4063/_4339: fade where the hit UV nears a screen border (frag 4063/4339).
                float prox = min((-max(outV, outU)) + 1.0, min(outV, outU));                              // frag 4063 (_4063)
                edgeFade = (0.25 < prox) ? 1.0 : clamp(prox * 4.0, 0.0, 1.0);                              // frag 4339 (_4339)
            }
            return found;
        }
        ENDHLSL

        // ================================================================
        // Pass 0: ForwardLit  (source LIGHTMODE=ForwardOnly, Queue 3000 Transparent -> URP UniversalForwardOnly)
        //   Render-state from litwater.shader:103-118 (Blend0 SrcAlpha OneMinusSrcAlpha / Cull [_CullMode] / transparent).
        // ================================================================
        Pass {
            Name "ForwardLit"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend]
            ZTest LEqual
            ZWrite [_ZWrite]
            Cull [_CullMode]
            HLSLPROGRAM
                #pragma target 3.5
                #pragma vertex vert
                #pragma fragment frag

                // URP lighting system keywords (substitute HG CSM/ASM shadow + tile/zbin punctual loop).
                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
                #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
                #pragma multi_compile_fragment _ _SHADOWS_SOFT
                #pragma multi_compile_fog

                struct Attributes {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float4 tangentOS  : TANGENT;
                    float4 color      : COLOR;
                    float2 uv0        : TEXCOORD0;
                    float2 uv1        : TEXCOORD1;
                };

                struct Varyings {
                    float4 positionCS : SV_Position;
                    float3 positionWS : TEXCOORD0;   // source TEXCOORD (P), frag 391-393 (abs world pos, camera-relative + camPos)
                    float3 normalWS   : TEXCOORD1;   // source TEXCOORD_3, vert 395-397
                    float4 tangentWS  : TEXCOORD2;   // source TEXCOORD_4_1 (.w = bitangent sign), vert 399-402
                    float2 uv0        : TEXCOORD3;   // -> frag TEXCOORD_1 (the flow/normal/foam sampling UV set), vert 411-412
                    float2 uv1        : TEXCOORD4;   // -> frag TEXCOORD_2 (carried; not sampled in base), vert 413-414
                    float4 color      : TEXCOORD5;   // source TEXCOORD_6 (vertex color), vert 419-422
                    float  fogFactor  : TEXCOORD6;
                };

                // Vertex: source vert 360-426 = manual instanced object->world->clip + inverse-transpose normal/tangent.
                //   GPU instancing per-draw array (vert 358-425) + octahedral vertex decode (vert 282-353) DROPPED — engine
                //   infra (STYLE_BIBLE §2 / CORE_MATH §3.1/§3.2) -> URP GetVertexPositionInputs/GetVertexNormalInputs.
                Varyings vert(Attributes input) {
                    Varyings o = (Varyings)0;
                    VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);                // vert 360-409 (_304..468)
                    VertexNormalInputs   nrmIn = GetVertexNormalInputs(input.normalOS, input.tangentOS);   // vert 395-402 normalize Nw/Tw
                    o.positionCS = posIn.positionCS;
                    o.positionWS = posIn.positionWS;                                                       // -> frag TEXCOORD (P)
                    o.normalWS   = nrmIn.normalWS;                                                         // -> frag TEXCOORD_3
                    o.tangentWS  = float4(nrmIn.tangentWS, input.tangentOS.w * GetOddNegativeScale());     // -> frag TEXCOORD_4 (.w sign _171)
                    o.uv0        = input.uv0;                                                              // -> frag TEXCOORD_1 (flow/normal/foam UVs)
                    o.uv1        = input.uv1;                                                              // -> frag TEXCOORD_2 (carried)
                    o.color      = input.color;                                                            // frag TEXCOORD_6
                    o.fogFactor  = ComputeFogFactor(posIn.positionCS.z);
                    return o;
                }

                half4 frag(Varyings input) : SV_Target {
                    float3 positionWS = input.positionWS;
                    float3 geoN = normalize(input.normalWS);                                               // interpolated geometric normal
                    float3 geoT = normalize(input.tangentWS.xyz);
                    float  bitSign = input.tangentWS.w;                                                    // frag 773 (_171), TEXCOORD_4.w sign
                    // Source samples flow/normal/foam with fragment TEXCOORD_1 (semantic TEXCOORD2 = vertex uv0; vert 411-412 -> frag 657/800).
                    float2 uvFlow = input.uv0;                                                             // frag 800-801 (_353,_354 = TEXCOORD_1 = uv0)

                    float  eyeDist;
                    float3 V = WaterViewDirWS(positionWS, eyeDist);                                        // §2.2, frag 774-786

                    // ========================================================
                    // FLOW MAP cyclic blend of the small-wave normal map (frag 312-419).
                    //   _FlowTex.xy in [0,1] -> [-1,1] flow vector; two phase taps (_339 phase A, _372 phase B = phase A - half),
                    //   triangle-blend weight _389; produces flow-advected normal (_399,_400) + alpha (_398 -> foam mask later).
                    // ========================================================
                    float4 flowTex = SAMPLE_TEXTURE2D_BIAS(_FlowTex, sampler_FlowTex, uvFlow, 0.0); // frag 796 (T5.SampleBias _GlobalMipBias; URP macro auto-adds _GlobalMipBias.x)
                    float  flowX = mad(flowTex.x, 2.0, -1.0);                                              // frag 797 (_317)
                    float  flowY = mad(flowTex.y, 2.0, -1.0);                                              // frag 798 (_318)
                    // _VFXParams0.w (HG time) -> URP _Time.y (seconds). Phase A = frac(time*_FlowSpeed + 0.5)*_FlowFullCycle.
                    float  phaseA = frac(mad(_Time.y, _FlowSpeed, 0.5)) * _FlowFullCycle;                  // frag 799 (_339)
                    float  uNrmX = uvFlow.x * _NormalTilling;                                              // frag 800 (_353)
                    float  uNrmY = uvFlow.y * _NormalTilling;                                              // frag 801 (_354)
                    float4 nrmA = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap,
                                     float2(mad(flowX, phaseA, uNrmX), mad(flowY, phaseA, uNrmY)), 0.0); // frag 802 (T4 phase A; URP auto-adds _GlobalMipBias.x)
                    float  phaseB = frac(_Time.y * _FlowSpeed) * _FlowFullCycle;                           // frag 806 (_372)
                    float4 nrmB = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap,
                                     float2(mad(flowX, phaseB, uNrmX), mad(flowY, phaseB, uNrmY)), 0.0); // frag 807 (T4 phase B; URP auto-adds _GlobalMipBias.x)
                    // triangle blend weight: |(_FlowFullCycle*0.5 - phaseA)| / (0.5*_FlowFullCycle)  (frag 808 _389)
                    float  blend = abs(mad(_FlowFullCycle, 0.5, -phaseA)) / (0.5 * _FlowFullCycle);        // frag 808 (_389)
                    float  flowAlpha = mad(blend, -nrmA.w + nrmB.w, nrmA.w);                               // frag 809 (_398) lerp(nrmA.w, nrmB.w, blend)
                    float  smallNX = mad(mad(blend, -nrmA.x + nrmB.x, nrmA.x), 2.0, -1.0);                 // frag 810 (_399)
                    float  smallNY = mad(mad(blend, -nrmA.y + nrmB.y, nrmA.y), 2.0, -1.0);                 // frag 811 (_400)
                    float  smallNZ = max(sqrt(-min(dot(float2(smallNX, smallNY), float2(smallNX, smallNY)), 1.0) + 1.0), EPS_NORMAL_Z); // frag 812 (_408)
                    // small-wave normal scaled by (_FlowTex.z*_FoamNormalStrength + _NormalScale)  (frag 813 _417)
                    float  smallScale = mad(flowTex.z, _FoamNormalStrength, _NormalScale);                 // frag 813 (_417)
                    float  smallNXs = smallScale * smallNX;                                                // frag 814 (_418)
                    float  smallNYs = smallScale * smallNY;                                                // frag 815 (_419)

                    // ========================================================
                    // LARGE WAVE normal (directional flow) — frag 432-501.
                    //   sampled along _LargeWaveDir (normalized) at _LargeWaveFlowSpeed; then reoriented INTO the small-wave
                    //   tangent frame: large normal expressed relative to the small normal's basis (frag 488-501).
                    // ========================================================
                    float  dirLen = rsqrt(dot(_LargeWaveDir.xy, _LargeWaveDir.xy));                       // frag 816 (_432)
                    float  lwSpeed = _Time.y * _LargeWaveFlowSpeed;                                        // frag 817 (_446)
                    float4 lwTex = SAMPLE_TEXTURE2D_BIAS(_LargeWaveNormalMap, sampler_LargeWaveNormalMap,
                                     float2(mad(dirLen * _LargeWaveDir.x, lwSpeed, uvFlow.x * _LargeWaveNormalTilling),
                                            mad(dirLen * _LargeWaveDir.y, lwSpeed, uvFlow.y * _LargeWaveNormalTilling)), 0.0); // frag 818 (T4; URP auto-adds _GlobalMipBias.x)
                    float  lwNX = mad(lwTex.x, 2.0, -1.0);                                                 // frag 819 (_456)
                    float  lwNY = mad(lwTex.y, 2.0, -1.0);                                                 // frag 820 (_457)
                    float  lwNZ = max(sqrt(-min(dot(float2(lwNX, lwNY), float2(lwNX, lwNY)), 1.0) + 1.0), EPS_NORMAL_Z); // frag 821 (_465)
                    float  lwNXs = lwNX * _LargeWaveNormalScale;                                           // frag 822 (_469)
                    float  lwNYs = lwNY * _LargeWaveNormalScale;                                           // frag 823 (_470)
                    // normalize small-wave normal (frag 824-827 _474..477) and large-wave normal (frag 828-831 _481..484)
                    float  snInv = rsqrt(dot(float3(smallNXs, smallNYs, smallNZ), float3(smallNXs, smallNYs, smallNZ))); // frag 824 (_474)
                    float3 sN = float3(smallNXs * snInv, smallNYs * snInv, smallNZ * snInv);               // frag 825-827 (_475..477)
                    float  lnInv = rsqrt(dot(float3(lwNXs, lwNYs, lwNZ), float3(lwNXs, lwNYs, lwNZ)));     // frag 828 (_481)
                    float3 lN = float3(lwNXs * lnInv, lwNYs * lnInv, lwNZ * lnInv);                        // frag 829-831 (_482..484)
                    // reorient: project large normal against small normal's flipped basis (frag 832-835 _488..501).
                    float  reproj = dot(sN, float3(-lN.x, -lN.y, lN.z));                                   // frag 832 (_488)
                    float  flowNX = mad(lN.x, 1.0, (reproj * sN.x) / sN.z);                                // frag 833 (_499) = lN.x + reproj*sN.x/sN.z
                    float  flowNY = mad(lN.y, 1.0, (reproj * sN.y) / sN.z);                                // frag 834 (_500)
                    float  flowNZ = mad(-lN.z, 1.0, reproj);                                               // frag 835 (_501) = reproj - lN.z

                    // ========================================================
                    // FOAM assembly (frag 515-564). Sample foam mask from _FlowTex (T5) at flow-noise-perturbed UVs;
                    //   foam = clamp(base*B + flowAlpha*R*B + flowAlpha*G*A, 0,1) * _FoamOpacity, per channel. (_517=B mask, _518=A mask)
                    // ========================================================
                    float4 foamTex = SAMPLE_TEXTURE2D_BIAS(_FlowTex, sampler_FlowTex,
                                       float2(mad(flowNX, _FlowNoiseStrength, uvFlow.x), mad(flowNZ, _FlowNoiseStrength, uvFlow.y)), 0.0); // frag 836 (T5; URP auto-adds _GlobalMipBias.x)
                    float  foamB = foamTex.z;                                                              // frag 837 (_517)
                    float  foamA = foamTex.w;                                                              // frag 838 (_518)
                    // foamRaw = clamp(mask,0,1)*_FoamOpacity (can exceed 1 since opacity up to 5) — used by roughness (frag 852).
                    float3 foamRaw;
                    foamRaw.x = clamp(mad(_FlowBaseColor.x, foamB, mad(flowAlpha * _FoamColorR.x, foamB, foamA * (flowAlpha * _FoamColorG.x))), 0.0, 1.0) * _FoamOpacity; // frag 839 (_559)
                    foamRaw.y = clamp(mad(_FlowBaseColor.y, foamB, mad(flowAlpha * _FoamColorR.y, foamB, foamA * (flowAlpha * _FoamColorG.y))), 0.0, 1.0) * _FoamOpacity; // frag 840 (_560)
                    foamRaw.z = clamp(mad(_FlowBaseColor.z, foamB, mad(flowAlpha * _FoamColorR.z, foamB, foamA * (flowAlpha * _FoamColorG.z))), 0.0, 1.0) * _FoamOpacity; // frag 841 (_561)
                    float3 foam = clamp(foamRaw, 0.0, 1.0);                                                // frag 842-844 (_562..564) — used as the lit albedo

                    // ========================================================
                    // WORLD-SPACE perturbed normal via per-pixel TBN (frag 619-660).
                    //   N_ws = flowNZ*geoN + flowNX*geoT + flowNY*(bitSign * cross(geoN, geoT)) ; then distance-faded toward up.
                    // ========================================================
                    float3 bitangent = bitSign * cross(geoN, geoT);                                       // frag 845-847 (_171 * cross(T,N) terms)
                    float3 nwRaw = flowNZ * geoN + flowNX * geoT + flowNY * bitangent;                    // frag 845-847 (_619..621)
                    float  nwInv = rsqrt(max(dot(nwRaw, nwRaw), FLT_MIN_GUARD));                           // frag 848 (_627)
                    float  nX = nwInv * nwRaw.x;                                                           // frag 849 (_628)
                    float  nZc = nwInv * nwRaw.z;                                                          // frag 850 (_629) (note: source packs .z then .y)
                    // distance fade: blend perturbed normal toward geometric up by camera distance (frag 851-853).
                    float  distFade = clamp((rcp(input.positionCS.w) + 0.100000001490116119384765625) / _DistanceFade, 0.0, 1.0); // frag 851 (_639) linear eye depth/_DistanceFade
                    float  nYc = mad(nwRaw.y, nwInv, distFade);                                            // frag 853 (_653) = perturbed N.y + distFade (bends toward up far away)
                    float  nFinalInv = rsqrt(dot(float3(nX, nYc, nZc), float3(nX, nYc, nZc)));             // frag 854 (_657)
                    float3 N = float3(nX, nYc, nZc) * nFinalInv;                                           // frag 855-857 (_658..660) [x, y, z]
                    // foam-aware roughness: min(distFade + len(foamRaw)*_FoamRoughness + _Roughness, 0.1)  (frag 852 _652; uses the pre-final-clamp _559..561)
                    float  roughness = min(distFade + mad(sqrt(dot(foamRaw, foamRaw)), _FoamRoughness, _Roughness), 0.100000001490116119384765625); // frag 852 (_652)

                    // ========================================================
                    // PBR setup (frag 858-866). dielectric F0 = 0.08*_Specular (water is dielectric; no metal channel).
                    //   Halfway-with-up vector for the env-spec NoV (frag 859-863 _666..673 builds a tilted N for env sampling).
                    // ========================================================
                    float  dielF0 = DIELECTRIC_F0 * _Specular;                                            // frag 858 (_664)
                    // env/shading normal: N with .y HALVED then renormalized (frag 859-863: _666=N.y*0.5; _671=N.x, _672=N.y*0.5, _673=N.z).
                    float3 envNraw = float3(N.x, N.y * 0.5, N.z);                                          // frag 859 (_658, _666=_659*0.5, _660)
                    float  envNinv = rsqrt(dot(envNraw, envNraw));                                         // frag 860 (_670)
                    float3 envN = envNraw * envNinv;                                                       // frag 861-863 (_671, _672, _673)

                    // ========================================================
                    // §2.7 MAIN directional light: HG CSM/ASM/cloud shadow (frag 864-1086) -> URP main-light shadowAttenuation.
                    //   Direct lobe (frag 1006-1138): GGX-D*Smith-Vis specular + multiscatter-diffuse energy + FOAM as albedo.
                    //   _1104 = mad(_1091, NoL, NoL*foam) * lightColor : the foam acts as the diffuse albedo (water body is clear).
                    // ========================================================
                    float4 shadowCoord = TransformWorldToShadowCoord(positionWS);
                    Light mainLight = GetMainLight(shadowCoord, positionWS, half4(1, 1, 1, 1));
                    float3 directLit = float3(0.0, 0.0, 0.0);
                    {
                        // The direct lobe uses envN (the .y-halved tilted normal _671..673) as the shading normal and the
                        // half vector H = normalize(L + V) (frag 1110-1116 _983..993). NoL=_997, NoH=_1001, NoV=_1005, VoH=1-_1016.
                        float3 Lm = mainLight.direction;                                                  // -_LightData[0], frag 916/1097
                        float3 Hm = normalize(Lm + V);                                                    // frag 1110-1116 (_991..993)
                        float  NoL = clamp(dot(Lm, envN), 0.0, 1.0);                                      // frag 1117 (_997)
                        float  NoH = clamp(dot(envN, Hm), 0.0, 1.0);                                      // frag 1118 (_1001)
                        float  NoV = clamp(dot(envN, V), 0.0, 1.0);                                       // frag 1119 (_1005)
                        float  VoH = clamp(dot(V, Hm), 0.0, 1.0);                                         // frag 1123 (1 - _1016)
                        // Schlick on the spec lobe = lerp(dielF0, 1, (1-VoH)^5)  (frag 1130 mad(_664, mad(-_1018,_1016,1), _1016*_1018),
                        //   where _1016=1-VoH, _1018=_1016^4 -> mad(-_1018,_1016,1)=1-(1-VoH)^5, _1016*_1018=(1-VoH)^5).
                        float  om = 1.0 - VoH;                                                            // frag 1123 (_1016)
                        float  om4 = (om * om) * (om * om);                                               // frag 1125 (_1018)
                        float  fresnel = mad(dielF0, mad(-om4, om, 1.0), om * om4);                       // frag 1130 (Schlick, F0=dielF0)
                        float  specE = min(WaterGGXSmith(roughness, NoL, NoH, NoV) * fresnel, 2048.0);    // frag 1130 (GGX*Vis*Fresnel)
                        float  spExtra = WaterSpecEnergyRight(roughness, dielF0, _Specular, NoL, NoV);    // frag 1130 right energy
                        float  energy = min(max(specE + spExtra, 0.0), 1000.0);                           // frag 1130 (_1091) [* _LightData[4].x folded into lightColor]
                        float  atten = mainLight.shadowAttenuation * mainLight.distanceAttenuation;        // -> _748 main-light shadow, frag 1086/1134
                        // foam-as-albedo direct: (energy*NoL + NoL*foam) * lightColor  (frag 1131-1133 _1104..1106)
                        directLit = mad(energy.xxx, NoL.xxx, NoL * foam) * (atten * mainLight.color);      // frag 1131-1133, * _LightData[1] = lightColor
                    }

                    // ========================================================
                    // §2.8 ADDITIONAL (punctual) lights: HG tile/zbin culling (frag 1146-1674) -> URP GetAdditionalLight loop.
                    //   Same GGX-D/Smith-Vis/energy; foam again acts as the diffuse albedo (frag 1467-1469 _4031..4035).
                    // ========================================================
                    float3 addLit = float3(0.0, 0.0, 0.0);
                #if defined(_ADDITIONAL_LIGHTS)
                    uint addCount = GetAdditionalLightsCount();
                    for (uint li = 0u; li < addCount; ++li)
                    {
                        Light light = GetAdditionalLight(li, positionWS, half4(1, 1, 1, 1));
                        float3 Lp = light.direction;
                        float3 Hp = normalize(Lp + V);                                                    // frag 1450-1456 (_6068..6070)
                        float  NoL = clamp(dot(Lp, envN), 0.0, 1.0);                                      // frag 1457 (_6074)
                        float  NoH = clamp(dot(envN, Hp), 0.0, 1.0);
                        float  NoV = clamp(dot(envN, V), 0.0, 1.0);                                       // frag 1458 (_6078)
                        float  VoH = clamp(dot(V, Hp), 0.0, 1.0);                                         // frag 1462 (1 - _6096)
                        float  om = 1.0 - VoH;                                                            // frag 1462 (_6096)
                        float  om4 = (om * om) * (om * om);                                               // frag 1464 (_6099)
                        float  fresnel = mad(dielF0, mad(-om4, om, 1.0), om * om4);                       // frag 1465 (Schlick, F0=dielF0)
                        float  specE = min(WaterGGXSmith(roughness, NoL, NoH, NoV) * fresnel, 2048.0);    // frag 1465 (GGX*Vis*Fresnel)
                        float  spExtra = WaterSpecEnergyRight(roughness, dielF0, _Specular, NoL, NoV);    // frag 1465 right energy
                        float  energy = min(max(specE + spExtra, 0.0), 1000.0);                           // frag 1465 (_6139)
                        float  atten = light.distanceAttenuation * light.shadowAttenuation;
                        addLit += mad(energy.xxx, NoL.xxx, NoL * foam) * (atten * light.color);           // frag 1467-1469 (_4031..4035)
                    }
                #endif

                    // ========================================================
                    // §2.4 AMBIENT diffuse: HG IV-clipmap SH cascade T13-T18 (frag 1675-1914) -> URP SampleSH(N).
                    //   Source projects 3-band SH onto N and adds foam*ambient (frag 2180-2182 _4391..4393). foam = albedo again.
                    // ========================================================
                    float3 ambientSH = max(SampleSH(N), 0.0);                                             // frag 2180-2182 max(SH(N)+DC, 0)
                    float3 ambientLit = foam * ambientSH * _EnvironmentGlobalParams0.x;                   // frag 2180-2182 foam * SH * envParams0.x

                    // ========================================================
                    // §2.5 REFLECTION (probe IBL) + SSR (frag 2310-4371).
                    //   probe reflection: HG box-projected probe-binning atlas -> URP GlossyEnvironmentReflection(R, roughness).
                    //   env-spec desaturation toward luma (_EnvSpecularDesaturation) then *_EnvLightSpecularIntensity (frag 3149-3169).
                    //   SSR: HG screen ray-march on depth pyramid -> URP _CameraDepthTexture + _CameraOpaqueTexture screen reflection.
                    //   final spec = lerp(probeRefl*envIntensity, ssrColor*_SSRStrength, _UseSSR) gated by env-BRDF (frag 4174-4179).
                    // ========================================================
                    float3 reflVec = reflect(-V, N);                                                      // frag 2310-2320 (_2318..2320 = reflect off perturbed N)
                    float  perceptualRoughness = saturate(roughness);
                    float3 probeRefl = GlossyEnvironmentReflection(reflVec, perceptualRoughness, 1.0);    // frag 2330-3138 probe atlas -> URP
                    probeRefl *= _GraphicsFeaturesGlobalParam0.z;                                         // frag 3136-3138 (_GraphicsFeaturesGlobalParam0.z)
                    // env-spec desaturation (frag 3147-3163): luma = avg(refl*intensity); lerp each channel toward luma by desat.
                    float  envLuma = (probeRefl.x + probeRefl.y + probeRefl.z) * _EnvLightSpecularIntensity * 0.3333333432674407958984375; // frag 3147 (_3149)
                    float3 envSpec;
                    envSpec.x = mad(mad(probeRefl.x, _EnvLightSpecularIntensity, -envLuma), _EnvSpecularDesaturation, envLuma); // frag 3149 (_3161)
                    envSpec.y = mad(mad(probeRefl.y, _EnvLightSpecularIntensity, -envLuma), _EnvSpecularDesaturation, envLuma); // frag 3150 (_3162)
                    envSpec.z = mad(mad(probeRefl.z, _EnvLightSpecularIntensity, -envLuma), _EnvSpecularDesaturation, envLuma); // frag 3151 (_3163)
                    float  envSpecZ = envSpec.z * _EnvLightSpecularIntensity;                             // frag 3052 (_3169)

                    // ---- SSR ray-march (frag 3170-4165): URP screen-space reflection from opaque color + depth ----
                    float2 screenUV = GetNormalizedScreenSpaceUV(input.positionCS);
                    float  NoVenv = max(dot(N, V), 0.0);                                                  // env-BRDF NoV (frag 2158 uses dot(reflViewN, N))
                    float  envSpecScale, envSpecBias;
                    WaterEnvBRDF(roughness, NoVenv, dielF0, _Specular, envSpecScale, envSpecBias);        // frag 4158-4161 (_4055,_4094)
                    // SSR ray-march (frag 2053-2165): 1:1 screen-space depth march -> hit UV + edge-fade. The hit flag _3991
                    //   gates ssrColor (frag 2155-2166: no hit -> _4336=0). HG samples the hit color from T1 (PREVIOUS-FRAME
                    //   color history); URP forward-transparent has no prev-frame history binding -> we sample the current-frame
                    //   opaque texture (_CameraOpaqueTexture) at the SAME hitUV. (1:1 march; hit-color source substituted per below.)
                    float2 fragNDC2 = mad(screenUV, 2.0, -1.0);                                           // frag 3170-3171 (_3170,_3171 = uv*2-1)
                    float3 ssrColor = float3(0.0, 0.0, 0.0);
                    float  ssrEdgeFade = 0.0;                                                             // frag 2165 (_4339); 0 on miss (frag 2172)
                    {
                        float2 ssrHitUV;
                        // TODO(1:1) ENGINE-SIDE (hit-COLOR source only — the MARCH below is ported 1:1): HG reads the reflected
                        //   color from T1 = the PREVIOUS-FRAME COLOR history buffer (frag 2160 T1.SampleBias). That temporal
                        //   history is produced by the engine's TAAU/reprojection feature and is not bound to a URP forward
                        //   transparent material. SUBSTITUTION: sample the current-frame _CameraOpaqueTexture at the marched hitUV.
                        if (WaterSSRMarch(positionWS, N, fragNDC2, input.positionCS.z, ssrHitUV, ssrEdgeFade)) // frag 2053-2150 (_3991 hit)
                        {
                            ssrColor = SampleSceneColor(ssrHitUV);                                        // frag 2160 (T1 prev-color at hit) -> URP opaque at hitUV
                            // env-BRDF gate (frag 4094 _4094 = dielF0*scale + bias). WaterEnvBRDF already folds dielF0 into envSpecScale.
                            ssrColor *= (envSpecScale + envSpecBias) * _SSRStrength;                      // frag 2162-2164 (_4094 * T1 * _SSRStrength)
                        }
                    }
                    // blend probe-env-spec vs SSR by _UseSSR (frag 4174-4177 _4369..4371).
                    float  oneMinusSSR = 1.0 - _UseSSR;                                                   // frag 4174 (_4362)
                    float3 reflFinal;
                    reflFinal.x = mad(envSpec.x * _EnvLightSpecularIntensity, oneMinusSSR, ssrColor.x * _UseSSR); // frag 4175 (_4369)
                    reflFinal.y = mad(envSpec.y * _EnvLightSpecularIntensity, oneMinusSSR, ssrColor.y * _UseSSR); // frag 4176 (_4370)
                    reflFinal.z = mad(envSpecZ, oneMinusSSR, ssrColor.z * _UseSSR);                       // frag 4177 (_4371)

                    // specular ambient = lerp(reflFinal, envSpec, ssr-edge-fade^2) (frag 4178-4182 _4374 mix), then + ambientLit.
                    //   _4374 = (1 - _4339)^2 where _4339 is the SSR edge-fade (0 on miss -> _4374=1, so envSpec stands in). (1:1 frag 2178-2179.)
                    float  oneMinusEdge = -ssrEdgeFade + 1.0;                                             // frag 2178 (_4373)
                    float  ssrFadeSq = oneMinusEdge * oneMinusEdge;                                       // frag 2179 (_4374)
                    float3 specAmbient;
                    specAmbient.x = mad(ssrFadeSq, mad(envSpec.x, _EnvLightSpecularIntensity, -reflFinal.x), reflFinal.x); // frag 4180 (_4391 right)
                    specAmbient.y = mad(ssrFadeSq, mad(envSpec.y, _EnvLightSpecularIntensity, -reflFinal.y), reflFinal.y); // frag 4181 (_4392 right)
                    specAmbient.z = mad(ssrFadeSq, mad(envSpecZ, 1.0, -reflFinal.z), reflFinal.z);        // frag 4182 (_4393 right)
                    // total non-volume color so far = ambientLit (foam*SH) + specAmbient + directLit + addLit (frag 2180-2182 _4391..4393).
                    float3 surfaceColor = ambientLit + specAmbient + directLit + addLit;                  // frag 2180-2182 (_4391,_4392,_4393)

                    // ========================================================
                    // WATER VOLUME: refraction + Beer-Lambert absorption + single-scatter in-scatter (frag 4391-2362).
                    //   This is what makes it look like water. Steps:
                    //   (1) refract V through the surface normal by _WaterIOR, reproject to screen, sample scene-color behind (frag 4499-4651).
                    //   (2) compute underwater path length d (camera->surface vs surface->floor) clamped (frag 4694-5107).
                    //   (3) transmittance T = exp(-d*(σ_s+σ_a)) per channel (frag 5935-5948).
                    //   (4) in-scatter = phase(angle) * σ_s * (1-exp(-d*σ_s*depthFactor))/σ_s * sunColor * sunVisibility (frag 5950-6007,2360-2362).
                    //   (5) full-absorption fallback (deep water) samples a scene-color/sky tex when d<_SafeFullAbsorpDistance (frag 5582-5912).
                    //   FINAL: SV_Target.rgb = lerp_by_T( fog+inscatter+surfaceColor, refractedScene ) (frag 2360-2362).
                    // ========================================================
                    // (0) through-water floor distance _4488 (frag 2184-2190): reconstruct the OPAQUE scene point behind THIS
                    //   pixel from the depth buffer (source samples T2 depth at the fragment's OWN pixel-center UV, frag 769-792
                    //   _255 = T2.SampleLevel(_244*_ScreenSize.z, _246*_ScreenSize.w); _244/_246 = floor(gl_FragCoord)+0.5),
                    //   un-project (_InvViewProjMatrix*(ndc.xy, sceneDepth)) -> floor world pos (frag 2184-2189 _4469..4484),
                    //   then _4488 = length(floorWS - positionWS). URP: ComputeWorldSpacePosition(screenUV, deviceDepth, I_VP).
                    //   (1:1, source = litwater.shader:2184-2190 _4428/_4469/_4482..4484/_4488.)
                    float  floorDepthDevice = SampleSceneDepth(screenUV);                                 // frag 792 (T2 depth at own pixel)
                    float3 floorWS = ComputeWorldSpacePosition(screenUV, floorDepthDevice, UNITY_MATRIX_I_VP); // frag 2186-2189 (_InvViewProjMatrix unproject)
                    float  floorDist = distance(floorWS, positionWS);                                     // frag 2190 (_4488) through-water floor distance

                    // (1) refraction direction: bend V's xz by _WaterIOR (frag 2191-2193 _4499/_4500/_4505), screen reproject (frag 2198-2203).
                    float3 refrDir = normalize(float3(N.x * _WaterIOR, N.y, N.z * _WaterIOR));            // frag 2191-2193 (_4499,_4500,_4505) — IOR bends horizontal
                    float  refrDist = min(floorDist, 20.0);                                               // frag 2197 (_4540 = min(_4488, 20)) clamp refraction reach
                    // edge/grazing-aware bend attenuation _4527 (frag 2194-2196): reduce the horizontal bend near the screen border
                    //   (_4515 screen-edge fade) and far from camera (eyeDist grazing term). The bend is scaled by (1 - _4527).
                    //   (1:1, source = litwater.shader:2194-2196 _4509/_4515/_4527.)
                    float2 fragNDC = mad(screenUV, 2.0, -1.0);                                            // frag 2053-2054 (_3170 = _156*2-1, _3171 = _157*2-1)
                    float  edgeProx = -min(1.0 - abs(fragNDC.y), 1.0 - abs(fragNDC.x));                   // frag 2194 (_4509 = -min(1-|_3171|, 1-|_3170|))
                    float  edgeFade = clamp(mad(edgeProx, 1.0, 0.199999988079071044921875) * 5.0, 0.0, 1.0); // frag 2195 (_4515 = saturate((_4509+0.2)*5))
                    float  grazing  = mad(-clamp(mad(eyeDist, 1.0, -0.75) * 4.0, 0.0, 1.0), 1.0, 1.0);    // frag 2196 (1 - saturate((_4397-0.75)*4)); _4397 = eyeDist
                    float  bendBlend = mad(grazing, min(edgeProx + 1.25, 1.0) - edgeFade, edgeFade);      // frag 2196 (_4527 = lerp(_4515, min(_4509+1.25,1), grazing))
                    // The source offsets ONLY X and Z (frag 2198/2200 `* -1`) and leaves Y fixed (frag 2199 `* -0.0` -> 0).
                    //   offset = -refrDir.xz * (1 - _4527) * refrDist  (frag 2198/2200 inner = _4505*bend*(1-_4527), times -1).
                    float  bendAttn = (1.0 - bendBlend) * refrDist;                                       // frag 2198-2200 ((1-_4527)*_4540)
                    float3 refrPos = positionWS - float3(refrDir.x, 0.0, refrDir.z) * bendAttn;           // frag 2198-2200 (_4559=P.x-bendX, _4560=P.y, _4561=P.z-bendZ)
                    float4 refrCS = TransformWorldToHClip(refrPos);                                       // frag 2201 (_ViewNoTransProjMatrix reproject)
                    float2 refrUV = saturate(refrCS.xy / refrCS.w * 0.5 + 0.5);                           // frag 2202-2203 (_4610,_4611)
                    float3 refractedScene = SampleSceneColor(refrUV);                                     // frag 2204/2263 (T2/T6 scene color)

                    // (2) underwater scatter path length. Source _5107 in the front-facing _4722 branch = _5055 = _4488 (frag 2242,2257);
                    //   _5913 = min(_5107, 50) (frag 2274). So pathLen = min(floorDist, 50). (1:1, source = litwater.shader:2242/2257/2274.)
                    float  pathLen = min(floorDist, 50.0);                                                // frag 2274 (_5913 = min(_5107=_4488, 50))

                    // (3) Beer-Lambert transmittance per channel: T = exp(-d*(σ_s+σ_a))  (frag 5935-5948).
                    float3 sigmaT = _WaterRayleighScatteringMeter.xyz + _WaterRayleighAbsorptionMeter.xyz; // frag 5935-5937 (_5935..5937)
                    float3 transmittance = exp2((-pathLen * sigmaT) * LOG2_E);                            // frag 5946-5948 (_5946..5948) = exp(-d*σ_t)

                    // (4) single-scatter in-scatter. sun-water angle phase (frag 5950) + Rayleigh/Mie phase blend (frag 6672-6681).
                    //   _5920 = dot(reconDir, _LightData[0]); for the typical front-facing _4722 branch reconDir = V (frag 2237-2242,2275),
                    //   and _LightData[0] = light-travel dir = -mainLight.direction. So sunWaterDot = dot(V, -mainLight.direction). (NOT dot(N, toLight).)
                    float3 lightTravel = -mainLight.direction;                                            // _LightData[0] = travel dir of sun (away from light)
                    float  sunWaterDot = dot(V, lightTravel);                                             // frag 2275 (_5920) cos(view, sun-travel)
                    float  phaseAngle = mad(-sunWaterDot, SCATTER_PHASE_A, SCATTER_PHASE_B);              // frag 5950 (_5950)
                    // depth-scaled scatter coefficient (frag 5960-5963): σ_s * (1 + |V.y / max(lightTravel.y, 0.05)|)
                    //   source _5960 = abs(_230 / max(0.05, _LightData[0].y)) + 1 ; _230 = V.y (normalized view dir), _LightData[0].y = -mainLight.direction.y.
                    float  depthScale = abs(V.y / max(0.0500000007450580596923828125, lightTravel.y)) + 1.0; // frag 2284 (_5960) — V.y / lightTravel.y
                    float3 sigmaSdepth = depthScale * _WaterRayleighScatteringMeter.xyz;                  // frag 5961-5963 (_5961..5963)
                    // Rayleigh/Mie phase: lerp( Mie(MIE_PHASE_K0/(...)) , Rayleigh((cos^2+1)*INV_4PI) , _RayleighMieLerpFactor ) (frag 6672-6681)
                    float  miePhase = MIE_PHASE_K0 / max(sqrt(phaseAngle) * (phaseAngle * FOUR_PI), 0.001000000047497451305389404296875); // frag 6672 (_6672)
                    float  scatterPhase = mad(_RayleighMieLerpFactor, mad(mad(sunWaterDot, sunWaterDot, 1.0), INV_4PI, -miePhase), miePhase); // frag 6681 (_6681)
                    // sun visibility through water surface (frag 2357): max(dot(-_LightData[0], N)*0.98 + 0.04, 0.1).
                    //   -_LightData[0] = mainLight.direction (to-light dir). So this is dot(mainLight.direction, N), NOT dot(-mainLight.direction, N).
                    float  sunVis = max(mad(dot(mainLight.direction, N), 0.980000019073486328125, 0.039999999105930328369140625), 0.100000001490116119384765625); // frag 2357 (_6715)
                    // in-scatter per channel = scatterPhase * ((1 - exp(-d*σ_s_depth))/σ_s_depth) * envParams.x... * σ_s * sunVis (frag 2360-2362)
                    float3 inScatterIntegral = (-exp2((pathLen * -sigmaSdepth) * LOG2_E) + 1.0) / sigmaSdepth; // frag 2360 ((1-exp(-d*σ_s))/σ_s) per channel
                    float3 inScatter = (scatterPhase * inScatterIntegral) * _EnvironmentGlobalParams0.x * _WaterRayleighScatteringMeter.xyz * sunVis; // frag 2360-2362 (_6681*...*_AtmosphereFogParams0.x*σ_s*_6715)

                    // (5) "scene behind" the water (the `* transmittance` term). In HG the ONLY behind-color written to SV_Target
                    //   is the deep/sky capture _5910 (T6), gated `_5107 < _SafeFullAbsorpDistance` (frag 2261): pathLen < dist ->
                    //   _5910 = T6.Sample ; ELSE _5910 = 0 (frag 2264/2270). It is attenuated by transmittance _5946 (frag 2360 `_5910*_5946`).
                    //   The refracted scene-color sample (T2 GatherRed, frag 2204/2217) is consumed by the path-length / normal
                    //   reconstruction, NOT composited directly — the actual see-through is HG's dual-source Blend1 hardware path
                    //   (litwater.shader:104 `Blend 1 SrcColor OneMinusSrcColor` + SV_Target1, frag 2364-2367), which URP single-RT
                    //   forward cannot replicate. SUBSTITUTION: we feed the URP opaque-texture refracted sample as the behind-color
                    //   so the water is see-through. NOTE the source gate `pathLen < dist` selects the CAPTURE (else 0); with the
                    //   default _SafeFullAbsorpDistance=0 that capture branch is never taken (pathLen>=0), so HG's _5910 term is 0.
                    // TODO(1:1) ENGINE-SIDE: exact see-through is HG's DUAL-SOURCE BLEND (litwater.shader:104 `Blend 1 SrcColor
                    //   OneMinusSrcColor` + SV_Target1 frag 2364-2367) — unreproducible in URP single-RT forward. Gate is inverted vs
                    //   source (source pathLen<dist -> T6 deep-capture, else 0) so the URP opaque-texture refracted sample stands in.
                    float3 sceneBehind = (pathLen < _SafeFullAbsorpDistance)
                                       ? float3(0.0, 0.0, 0.0)    // substitute: "fully absorbed" deep band -> no see-through
                                       : refractedScene;          // URP opaque-texture refracted background (absorbed by transmittance below)

                    // ---- FINAL COMPOSITE (frag 2349-2363) ----
                    //   Source SV_Target (frag 2360) = mad(B, fogExp, deepCapture*T) with B = mad(litTerm, _6614, inScatter):
                    //     B = litTerm*(1-T) + inScatter   — NOTE the single-scatter term is added STRAIGHT, it is NOT multiplied by (1-T)
                    //     (the (1-exp(-d*σ_s))/σ_s integral already encodes the in-medium accumulation; only the surface lit term gets (1-T)).
                    //   fogExp (_6607*_6020 exp/atmosphere transmittance) + deepCapture (T6) are folded into MixFog + sceneBehind below.
                    //   surfaceColor = directLit + addLit + ambientLit(foam*SH) + specAmbient (= source litTerm minus the VFX color-grade).
                    float3 oneMinusT = -transmittance + 1.0;                                              // frag 2349-2351 (_6614..6616)
                    float3 color = mad(surfaceColor, oneMinusT, inScatter) + sceneBehind * transmittance; // frag 2360-2362: litTerm*(1-T) + inScatter + behind*T
                    // apply scene fog over the whole composite (HG atmosphere/exp/volumetric fog -> URP MixFog).
                    color = MixFog(color, input.fogFactor);                                               // frag 2288-2347 HG fog -> URP

                    // §2.11 output: source writes SV_Target.w = 1.0 (frag 2363) — see-through is in the transmittance composite.
                    return half4(color, 1.0);                                                             // frag 2360-2363
                }
            ENDHLSL
        }
    }
    Fallback Off
}
