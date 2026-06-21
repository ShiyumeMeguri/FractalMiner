// HGRP VFX Water — a tinted, optionally PBR-lit transparent water/fluid particle surface with
//   alpha-or-additive compositing, Fresnel-driven opacity, indirect SH + direct main/additional
//   light specular, and optional normal-map / UV-disturb / mask / dissolve / subsurface / screen-space
//   refraction features — single transparent "ForwardLit" pass.
// Merged from: vfxwater.shader (HGRP/Effect/VFXWater),
//   base blob Sub0_Pass0_Vertex_b272.hlsl + Sub0_Pass0_Fragment_b273.hlsl (the catch-all `#else` =
//   NONE of the 18 multi_compile keywords defined; the blobs' own `// Keywords: HG_ENABLE_MV` header is
//   the keyword-NAMESPACE tag, NOT a defined keyword — HG_ENABLE_MV gates the b274.. `#if` branches).
//   Delta blobs read for the kept feature toggles (cite per #ifdef block):
//     _NORMAL_MAP   -> Sub0_Pass0_Fragment_b291.hlsl (tangent-space normal-map sample + TBN perturb)
//     _USE_DISTURB  -> Sub0_Pass0_Fragment_b303.hlsl (disturb-tex UV/normal offset; same head as b291)
//     _USE_MASK     -> Sub0_Pass0_Fragment_b277.hlsl (mask tex modulates alpha only)
//     _USE_DISSOLVE -> Sub0_Pass0_Fragment_b307.hlsl (dissolve threshold clip + emissive edge)
//     VFX_WATER_REFRACT -> Sub0_Pass0_Fragment_b347.hlsl (Snell refraction of camera opaque tex)
//   The keyword ladder only swaps interpolator-packing / GPU-skin / instancing / VAT infra (+ adds the
//   above sampling) around the SAME surface+lighting+composite math, so base `#else` b273 is the
//   full ground truth for the spine. (b273 reads prev-frame MV regs only for the dropped SV_Target_1.)
//
// Keywords: _SUBSURFACE, _USE_MASK, _NORMAL_MAP, _USE_DISTURB, _USE_DISSOLVE, VFX_WATER_REFRACT
// Kept (1:1 math, cite = blob b273 line unless stated):
//   - Main tex UV (channel/polar/screen select folded into _MainTexUVWeights + _MainTexUVRotateMat
//     scroll+rotate+ST, +_WaterRandomUV world-hash jitter) and sample (b273 319-326).
//   - Tint color (mainTex-as-alpha-gated rgb * vertColor.rgb * _TintColor.rgb * _TintColorIntensity,
//     post-exposure de-scale) and opacity assembly (mainAlpha * vertColor.a * _TintColor.a *
//     _TintColorAlpha * near-fade * view-N-dependent angular fade) clamped [0,1] (b273 332-354, 591-601).
//   - Roughness-dependent Fresnel + diffuse/F0 split (b273 882-893, 2306-2342) and dielectric F0=0.08*spec.
//   - Indirect SH ambient (HG IV clipmap _IVDefaultSHA·N -> URP SampleSH(N)) * env intensity, with
//     _IndirectSaturation grade (b273 600-607).
//   - Direct main-light PBR: GGX-D + Smith height-correlated Vis + Schlick F (b273 1773-1860), EnvBRDFApprox
//     DFG multiscatter-diffuse + 1/21 grazing floor (b273 1800-1853), _DirSpecularStrength.
//   - Additional (punctual) lights: same BRDF per light (HG tile/Z-bin cluster b273 870-1412 -> URP
//     GetAdditionalLight loop).
//   - _UseLighting / _IsSceneEffect / _BlendMode (additive vs alpha) compositing, VFX saturation
//     color-grade (_VFXParams1 -> exposed _VfxColorGrade) (b273 3288-3400).
//   - Near-camera dual-band view-depth fade (b273 _MaskTexUseDisturb/_NearCameraFade* branch, line 332).
//   - Feature toggles closed 1:1 from full delta-blob bodies (see end-of-frag CLOSED block):
//       _USE_MASK (b277 366/369-371: mask gates BOTH opacity AND per-channel tint color), _USE_DISSOLVE (b307 369-380: schedule
//       threshold + edge-band emissive folded into tint), _SUBSURFACE (b275 602-604: subsurface color folded into
//       ambient diffuse pre-grade), _USE_DISTURB (b303 363-365: _Bi_Disturb U-decode + _DisturbTex1Normal modes),
//       _NORMAL_MAP (b291 363-369: raw-basis TBN single front-face flip), VFX_WATER_REFRACT (b347 1545-1559).
// Removed (pixel-neutral pipeline infra substituted by URP, or HGRP-only framework with no URP analog):
//   GPU skinning + packed-octahedral vertex stream (b272 132-204), TAA jitter (_TaaJitterStrength,
//   b272 232-233 -> identity TransformWorldToHClip), HGRP global cbuffers (_ViewMatrix / _InvViewProjMatrix /
//   _NonJitteredViewNoTransProjMatrix / _WorldSpaceCameraPos_Internal / _ScreenSize / _GlobalMipBias ->
//   URP UNITY_MATRIX_V / _WorldSpaceCameraPos / _ScreenParams / mip-bias 0), GPU instancing
//   (SRP_INSTANCING_ON), LOD crossfade (_unity_LODFade.y, b273 332), the full HGRP CSM+ASM+cloud shadow
//   stack (b273 610-802 -> URP main-light shadow attenuation), the tile/Z-bin punctual-light cluster
//   (b273 870-1412 -> URP GetAdditionalLight), the IV image-volume clipmap GI (b273 363-599 -> URP SampleSH),
//   HGRP atmosphere+exp+volumetric froxel fog (b273 1413-1474 -> URP MixFog), the planar-reflection
//   reproject (b273 355-359, _GraphicsFeaturesGlobalParam1.y), light-cookie sampling (b273 _lightCookie*),
//   sequence-frame / VAT-Houdini / vertex-offset / soft-scene-blend feature keywords (no URP analog or
//   out-of-scope particle authoring), and the "ForwardOnly" 2nd MRT motion-vector target (SV_Target_1,
//   b273 1491-1494) — URP has no transparent-MV MRT for a custom shader. See TODO(1:1).
//
// NOTE: VFX_WATER_REFRACT samples the camera color buffer -> requires URP Opaque Texture ON
//   (_CameraOpaqueTexture). Always renders in the Transparent queue AFTER opaques.
// NOTE: _VFXParams0.w (HGRP per-particle time) is substituted by _Time.y; particle custom1 data rides
//   COLOR/UV like the source (_InParticle gates it).
// NOTE: the decompiled base packs the PBR scalars into a free cbuffer slot per permutation. VERIFIED b273:
//   _MaskTexUVRotateMat.x = _UseLighting (litTint mult, _599=_591*.x ; _2306=1-.x = unlit weight, b273 883),
//   .y = _Metallic (diffuse atten _686=_591*.x*(1-.y) & F0 blend _697=lerp(dielF0,litTint,.y), b273 348-354),
//   .z = _Roughness (GGX a=.z*.z b273 836 ; EnvBRDF t=1-.z b273 843), .w = _Specular (dielF0=0.08*.w b273 347);
//   _MaskTexUVSpeed.x = _DirSpecularStrength (b273 853), .z = _IndirectSaturation (b273 605); b291 normal-map
//   aliases the same scalars onto _DisturbUVRotateMat1.xyzw / _DisturbUVSpeed1 (b291 357/376-378/415-419).
//   Re-exposed here as the real source Property names — the cite is the MATH OPERATION, not the per-variant slot.

Shader "HGRP/VfxWater_Fix" {
    Properties {
        [Header(Base)]
        [Enum(Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _WaterRandomUV ("Random UV By Position", Float) = 0
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        [ToggleUI] _DisableVertColor ("Disable VertColor", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 0
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 0
        [ToggleUI] _IsSceneEffect ("Is Scene Effect (follows scene darkening)", Float) = 1
        [HideInInspector] _UseLighting ("Use Lighting", Float) = 1
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0
        [ToggleUI] _EnableTransparentMV ("Enable Transparent MV", Float) = 0

        [Header(Main Tex)]
        _MainTex ("Main Tex", 2D) = "white" {}
        _MainTexUseDisturb ("Main Tex Use Disturb", Range(0, 5)) = 1
        [ToggleUI] _UseMainTexAsAlpha ("UseMainTexAsAlpha", Float) = 1
        _MainTexUVSpeed ("MainTexUVSpeed(XY:By Time, ZW:By Custom1.X)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _MainTexUVRotateMat ("MainTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MainUVSet ("Main UV Set", Float) = 0
        [HideInInspector] _MainTexUVWeights ("_MainTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Tint)]
        [HDR] _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity (Default 1)", Range(1, 100)) = 1
        _TintColorAlpha ("Tint Color Alpha (Default 1)", Range(0, 10)) = 1

        [Header(PBR)]
        _Roughness ("Roughness", Range(0, 1)) = 1
        _Metallic ("Metallic", Range(0, 1)) = 1
        _Specular ("Specular", Range(0, 1)) = 1
        _DirSpecularStrength ("Direct Specular Strength", Range(0, 10)) = 1
        _IndirectSaturation ("Indirect Saturation", Range(0, 1)) = 0
        [ToggleUI] _UseVertexColorAsOpacity ("Use Vertex Color As Opacity", Float) = 0
        [ToggleUI] _UseFresnelAsOpacity ("Use Fresnel As Opacity", Float) = 0
        _FresnelStrength ("Fresnel Strength (opacity)", Range(-2, 2)) = 0

        [Header(Subsurface)]
        [Toggle(_SUBSURFACE)] _UseSubsurface ("Use Subsurface", Float) = 0
        _SubsurfaceIndirect ("Subsurface Indirect Influence", Range(0, 10)) = 1
        [HDR] _SubsurfaceColor ("Subsurface Color", Color) = (1, 1, 1, 1)

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask (alpha only)", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        [ToggleUI] _UseMaskTexAsAlpha ("Use Mask Tex As Alpha", Float) = 1
        _MaskTexUVSpeed ("MaskTexUVSpeed(XY:By Time, ZW:By Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _MaskTexUVRotateMat ("MaskTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [HideInInspector] _MaskTexUVWeights ("_MaskTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Normal Map)]
        [Toggle(_NORMAL_MAP)] _EnableNormalMap ("Normal Map", Float) = 0
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 3)) = 1
        _NormalMapUVSpeed ("NormalMapUVSpeed(XY:By Time, ZW:By Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _NormalMapUVRotateMat ("NormalMapUVRotateMat", Vector) = (1, 0, 0, 1)
        [HideInInspector] _NormalMapUVWeights ("_NormalMapUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Disturb)]
        [Toggle(_USE_DISTURB)] _UseDisturb ("Use Disturb", Float) = 0
        _DisturbTex1 ("Disturb Tex 1", 2D) = "white" {}
        _DisturbUVSpeed1 ("DisturbUVSpeed(XY:By Time, ZW:By Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _DisturbUVRotateMat1 ("DisturbUVRotateMat", Vector) = (1, 0, 0, 1)
        [HideInInspector] _DisturbUVWeights1 ("_DisturbUVWeights1", Vector) = (1, 0, 0, 0)
        _DisturbUIntensity1 ("Disturb U Intensity", Float) = 0
        _DisturbVIntensity1 ("Disturb V Intensity", Float) = 0
        [ToggleUI] _Bi_Disturb ("Disturb In 2 Direction", Float) = 0
        [ToggleUI] _DisturbTex1Normal ("Disturb Tex1 Is Normal", Float) = 0

        [Header(Dissolve)]
        [Toggle(_USE_DISSOLVE)] _UseDissolve ("Use Dissolve", Float) = 0
        _DissolveTex ("Dissolve Tex", 2D) = "white" {}
        _DissolveTexUseDisturb ("Dissolve Tex Use Disturb", Range(0, 5)) = 0
        _DissolveUVSpeed ("DissolveUVSpeed(XY:By Time, ZW:By Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _DissolveUVRotateMat ("DissolveUVRotateMat", Vector) = (1, 0, 0, 1)
        [HideInInspector] _DissolveUVWeights ("_DissolveUVWeights", Vector) = (0, 0, 0, 0)
        _DissolveScheduleOffset ("Dissolve Schedule Offset", Range(0, 2)) = 0
        _DissolveEdgeSharp ("Dissolve Edge Sharp", Range(0.001, 100)) = 1
        _DissolveEmissiveEdge ("Dissolve Edge Emissive", Range(0, 0.5)) = 0
        [HDR] [Gamma] _DissolveEmissiveColor ("Dissolve Edge Emissive Color", Color) = (0, 0, 0, 0)

        [Header(Refract)]
        [Toggle(VFX_WATER_REFRACT)] _UseRefract ("Use Refract", Float) = 0
        _RefractTint ("Refract Tint", Color) = (1, 1, 1, 1)
        _RefractThickness ("Refract Thickness", Range(0, 1)) = 0.01
        _IoR ("IoR", Range(0, 0.5)) = 0.8
        _RefractBrightness ("Refract Brightness", Range(0, 2)) = 1

        [Header(Near Camera Fade)]
        _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Start 1 (disappear)", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Fade End 1 (appear)", Range(0.001, 3000)) = 10
        _NearCameraFadeDistanceEnd2 ("Fade End 2 (appear)", Range(0.002, 3000)) = 100
        _NearCameraFadeDistanceStart2 ("Fade Start 2 (disappear)", Range(0.001, 3000)) = 120

        [Header(Pipeline Params)]
        // HGRP globals re-exposed as material params (no URP global equivalent), neutral defaults.
        _ExposureParams ("ExposureParams (.x=exposure)", Vector) = (1, 0, 0, 0)
        _EnvironmentGlobalParams0 ("Env Ambient Intensity (.x)", Vector) = (1, 0, 0, 0)
        // _VFXParams1: .xyz = post tint, .w = saturation amount (1 = no desat). Source _VFXParams1.
        _VfxColorGrade ("VFX Color Grade (.xyz tint, .w saturation)", Vector) = (1, 1, 1, 1)

        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 0
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
    }
    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 600

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareOpaqueTexture.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Base
                float _SurfaceType;
                float _BlendMode;
                float _WaterRandomUV;
                float _InParticle;
                float _DisableVertColor;
                float _IgnorePostExposure;
                float _IsSceneEffect;
                float _UseLighting;
                float _Responsive;
                float _EnableTransparentMV;
                // Main Tex
                float _MainTexUseDisturb;
                float _UseMainTexAsAlpha;
                float4 _MainTex_ST;
                float4 _MainTexUVSpeed;
                float4 _MainTexUVRotateMat;
                float4 _MainTexUVWeights;
                float _MainUVSet;
                // Tint
                float4 _TintColor;
                float _TintColorIntensity;
                float _TintColorAlpha;
                // PBR
                float _Roughness;
                float _Metallic;
                float _Specular;
                float _DirSpecularStrength;
                float _IndirectSaturation;
                float _UseVertexColorAsOpacity;
                float _UseFresnelAsOpacity;
                float _FresnelStrength;
                // Subsurface
                float _SubsurfaceIndirect;
                float4 _SubsurfaceColor;
                // Mask
                float4 _MaskTex_ST;
                float _UseMaskTexAsAlpha;
                float4 _MaskTexUVSpeed;
                float4 _MaskTexUVRotateMat;
                float4 _MaskTexUVWeights;
                // Normal Map
                float4 _NormalMap_ST;
                float _NormalScale;
                float4 _NormalMapUVSpeed;
                float4 _NormalMapUVRotateMat;
                float4 _NormalMapUVWeights;
                // Disturb
                float4 _DisturbTex1_ST;
                float4 _DisturbUVSpeed1;
                float4 _DisturbUVRotateMat1;
                float4 _DisturbUVWeights1;
                float _DisturbUIntensity1;
                float _DisturbVIntensity1;
                float _Bi_Disturb;
                float _DisturbTex1Normal;
                // Dissolve
                float4 _DissolveTex_ST;
                float _DissolveTexUseDisturb;
                float4 _DissolveUVSpeed;
                float4 _DissolveUVRotateMat;
                float4 _DissolveUVWeights;
                float _DissolveScheduleOffset;
                float _DissolveEdgeSharp;
                float _DissolveEmissiveEdge;
                float4 _DissolveEmissiveColor;
                // Refract
                float4 _RefractTint;
                float _RefractThickness;
                float _IoR;
                float _RefractBrightness;
                // Near Camera Fade
                float _UseNearCameraFade;
                float _NearCameraFadeDistanceStart;
                float _NearCameraFadeDistanceEnd;
                float _NearCameraFadeDistanceEnd2;
                float _NearCameraFadeDistanceStart2;
                // Pipeline params (HGRP globals re-exposed)
                float4 _ExposureParams;
                float4 _EnvironmentGlobalParams0;
                float4 _VfxColorGrade;
                // Render state
                float _TransparentSortPriority;
            CBUFFER_END

            TEXTURE2D(_MainTex);        SAMPLER(sampler_MainTex);
            TEXTURE2D(_MaskTex);        SAMPLER(sampler_MaskTex);
            TEXTURE2D(_NormalMap);      SAMPLER(sampler_NormalMap);
            TEXTURE2D(_DisturbTex1);    SAMPLER(sampler_DisturbTex1);
            TEXTURE2D(_DissolveTex);    SAMPLER(sampler_DissolveTex);

            // VFX time driver: source reads _VFXParams0.w (HGRP per-particle time); URP uses _Time.y. (b273 _VFXParams0.w)
            #define _VFXTime (_Time.y)

            // ===== Decoded magic constants (denormalized-float bit patterns -> real values) =====
            // Rec.709 luma (b273 1475/1486/1488): dot(c, LUM). 1:1 from CORE_MATH §0.4.
            static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625);
            static const float  EPS_VIEWLEN    = 9.9999999392252902907785028219223e-09; // 1e-8  ; view rsqrt guard (b273 313)
            static const float  EPS_HALF_RSQRT = 6.103515625e-05;                        // 2^-14 ; half-rsqrt guard (b273 818/829)
            static const float  EPS_VIS        = 9.9999997473787516355514526367188e-05;  // 1e-4  ; Smith-vis denom floor (b273 850)
            static const float  DIELECTRIC_F0  = 0.07999999821186065673828125;           // 0.08  ; dielectric F0 = 0.08*_Specular (b273 347/672)
            static const float  GRAZING_FLOOR  = 0.0476190485060214996337890625;         // 1/21  ; multiscatter-diffuse grazing floor (b273 846-848)

            // ===== EnvBRDFApprox DFG (Karis/Lazarov), 1:1 from CORE_MATH HgEnvBRDFApproxDFG =====
            // t=1-roughness ; min( t*(t*((-t)*0.38302600 - 0.07619470) + 1.04997003) + 0.40925499, 0.999 ). (b273 1800/2311 _1800/_2311)
            float EnvBRDFApproxDFG(float roughness)
            {
                float t = mad(roughness, -1.0, 1.0);
                return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875,
                                              -0.076194703578948974609375),
                                        1.04997003078460693359375),
                               0.4092549979686737060546875),
                           0.999000012874603271484375);
            }

            // ===== Cook-Torrance GGX-D + Smith height-correlated Vis + Schlick F. 1:1 from
            //       CORE_MATH HgDirectSpecular. Returns specular RGB (NOT yet * NoL). (b273 1773-1850)
            //   a=roughness^2 ; a2=a*a ; NoV'=min(NoV,1)
            //   d=(NoH*a2-NoH)*NoH+1 ; D=a2/(d*d)
            //   Vis=0.5/(NoV'*sqrt((-NoL*a2+NoL)*NoL+a2) + NoL*sqrt((-NoV'*a2+NoV')*NoV'+a2) + 1e-4)
            //   Fc=(1-VoH)^5 ; F=lerp(F0,1,Fc)=mad(F0,1-Fc,Fc) ; spec=(D*Vis)*F
            float3 DirectSpecular(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float a   = roughness * roughness;                              // b273 1773-1774 (_1773/_1774)
                float a2  = a * a;
                float nv  = min(NoV, 1.0);
                float d   = mad(mad(NoH, a2, -NoH), NoH, 1.0);                  // b273 1777 (_1777)
                float visDenom = nv  * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2))   // b273 1850 (_1835 denom term 1)
                               + NoL * sqrt(mad(mad(-nv,  a2, nv ), nv , a2))   // b273 1850 (_1835 denom term 2)
                               + EPS_VIS;
                float DV  = (a2 / (d * d)) * (0.5 / visDenom);                  // b273 1850 (_1835 = D*Vis)
                float oneMinusVoH = mad(-VoH, 1.0, 1.0);
                float sq   = oneMinusVoH * oneMinusVoH;
                float quad = sq * sq;
                float Fc   = oneMinusVoH * quad;                               // (1-VoH)^5
                float oneMinusFc = mad(-quad, oneMinusVoH, 1.0);
                float3 F   = mad(f0, oneMinusFc.xxx, Fc.xxx);                  // lerp(F0,1,Fc)
                return DV * F;
            }

            // ===== Full per-light energy bracket. 1:1 from CORE_MATH HgDirectLightEnergy. (b273 1800-1853)
            //   specE=(D*Vis)*F ; dfg=EnvBRDFApproxDFG(rough)
            //   gz=lerp(F0,1,1/21) ; msDiff=(dfg/(1-dfg) * gz^2)/(1 - gz*(1-dfg))  [per channel]
            //   energy=min(max(msDiff + min(specE,2048), 0), 1000)
            //   The HG split-sum 2D DFG LUT (T14, b273 1851 _1864) is engine infra with no URP binding
            //   -> analytic dfg substitute (CORE_MATH §2.6/§2.12). Poly + 1/21 ARE the 1:1 math.
            float3 DirectLightEnergy(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float3 specE = DirectSpecular(roughness, f0, NoL, NoH, NoV, VoH);     // b273 1850 (_1835)
                float  dfg   = EnvBRDFApproxDFG(roughness);                          // b273 1800 (_1800)
                float  oneMinusDfg = mad(-dfg, 1.0, 1.0);                            // b273 1803 (_1803)
                float  dfgEnergy = dfg / oneMinusDfg;                                // b273 1851 analytic (_1864 LUT -> dfg)
                float3 gz    = mad((float3(1.0, 1.0, 1.0) - f0), GRAZING_FLOOR, f0); // b273 846-848 (_1810/_1812/_1813)
                float3 msDiff = (dfgEnergy * (gz * gz)) / mad(-gz, oneMinusDfg, float3(1.0, 1.0, 1.0)); // b273 1853 term A
                return min(max(msDiff + min(specE, 2048.0), 0.0), 1000.0);           // b273 1853 (min(...,1000))
            }

            // ===== Generic VFX UV builder: channel select folded into weights + scroll + rotate + ST.
            //   1:1 structure from b273 320-321 / b291 346 (main tex) and b273 387-388 mask variant.
            //   weights.x = UV0/UV1 select (mesh uv), weights.y = particle-center blend ; rotateMat is the
            //   2x2 pre-rotation; ST is tiling/offset. randomUV adds a per-instance world hash on both axes.
            //   custom1 = particle custom data (TEXCOORD.zw vs uv1, gated by _InParticle).
            float2 BuildVfxUV(float2 meshUV0, float4 uv1, float4 tc, float4 speed, float4 rotateMat,
                              float4 weights, float4 st, float vfxTimeW, float worldHash, float custom1Scalar)
            {
                float custom1X = uv1.x * _InParticle;                          // b273 318 (_266)
                // base axis = mesh uv*weights.y blended with particle-center (uv1 +/- custom), + uv0*weights.x.
                float baseU = mad(tc.x, weights.x, (mad(tc.z, _InParticle, -(uv1.x * _InParticle)) + uv1.x) * weights.y); // b273 320
                float baseV = mad(tc.y, weights.x, (mad(tc.w, _InParticle, -(uv1.y * _InParticle)) + uv1.y) * weights.y); // b273 321
                float su = mad(speed.x, custom1Scalar, mad(speed.z, custom1X, baseU)) - 0.5; // b273 320 scroll (.x by vfxTime, .z by custom1)
                float sv = mad(speed.y, custom1Scalar, mad(speed.w, custom1X, baseV)) - 0.5; // b273 321 scroll (.y by vfxTime, .w by custom1)
                float2 uv;
                uv.x = mad(su, rotateMat.x, sv * rotateMat.z) + 0.5;          // b273 320 rotate
                uv.y = mad(su, rotateMat.y, sv * rotateMat.w) + 0.5;          // b273 321 rotate
                // _WaterRandomUV per-instance world hash (b273 320-321 _MaskTexUVWeights.z * _375 added to BOTH axes;
                //   V axis additionally scaled by (min(hash*weights.z,0.5)+1)).
                float hashAdd = weights.z * worldHash;                         // b273 320-321 (_MaskTexUVWeights.z*_375)
                uv = mad(uv, st.xy, st.zw);                                    // b273 320-321 ST
                uv.x += hashAdd;
                uv.y = mad(uv.y, (min(hashAdd, 0.5) + 1.0), hashAdd);          // b273 321 V outer factor
                return uv;
            }
        ENDHLSL

        Pass {
            Name "ForwardLit"
            Tags { "LightMode"="UniversalForwardOnly" }
            // Source: Blend 0 One OneMinusSrcAlpha, One OneMinusSrcAlpha (vfxwater.shader line 186).
            //   _BlendMode (alpha vs additive) is applied in HLSL via the _2598=1-_BlendMode factor on
            //   premultiplied color + output alpha (b273 3394-3400); blend op kept as premultiplied-over.
            Blend One OneMinusSrcAlpha, One OneMinusSrcAlpha
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            // Kept feature toggles (HGRP multi_compile_local -> URP shader_feature_local).
            #pragma shader_feature_local _SUBSURFACE
            #pragma shader_feature_local _USE_MASK
            #pragma shader_feature_local _NORMAL_MAP
            #pragma shader_feature_local _USE_DISTURB
            #pragma shader_feature_local _USE_DISSOLVE
            #pragma shader_feature_local VFX_WATER_REFRACT

            // URP main-light shadow keywords (HG CSM/ASM/cloud stack -> URP main-light shadow attenuation).
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
            #pragma multi_compile_fragment _ _SHADOWS_SOFT
            // HG atmosphere/exp/volumetric fog stack (b273 1413-1474) -> URP fog; required so MixFogColor is not a no-op.
            #pragma multi_compile_fog

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0; // mesh UV .xy (+ .zw spare); particle custom rides here (b272 TEXCOORD)
                float4 texcoord1  : TEXCOORD1; // particle center / UV1 / custom1 (b272 TEXCOORD_1)
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float4 uv0        : TEXCOORD0; // pass-through texcoord0          (b272 TEXCOORD_2 / b273 TEXCOORD)
                float4 uv1        : TEXCOORD1; // pass-through texcoord1          (b272 TEXCOORD_1_1 / b273 TEXCOORD_1)
                float3 normalWS   : TEXCOORD2; // world geo normal               (b272 TEXCOORD_2_1 / b273 TEXCOORD_2)
                float4 tangentWS  : TEXCOORD3; // world tangent (.w = bitangent sign) (b272 TEXCOORD_3)
                float4 vertColor  : TEXCOORD4; // vertex color (exposure-adjusted)(b272 TEXCOORD_4_1 / b273 TEXCOORD_4)
                float3 positionWS : TEXCOORD5; // world position                 (b273 depth-reconstructed WS == own WS)
                float  fogFactor  : TEXCOORD6; // URP fog factor (HG fog stack substitute; b273 1413-1474)
            };

            Varyings vert(Attributes v)
            {
                Varyings o;
                // World->clip. Source builds NonJitteredViewNoTransProj manually then removes TAA jitter
                // (b272 lines 229-233); the jitter-free result == URP TransformWorldToHClip.
                VertexPositionInputs posInputs = GetVertexPositionInputs(v.positionOS);
                o.positionCS = posInputs.positionCS;
                o.positionWS = posInputs.positionWS;

                // World geo normal + tangent (b272 lines 220-246: normalize(inverse-transpose basis)).
                VertexNormalInputs nrmInputs = GetVertexNormalInputs(v.normalOS, v.tangentOS);
                o.normalWS  = nrmInputs.normalWS;
                o.tangentWS = float4(nrmInputs.tangentWS, v.tangentOS.w * GetOddNegativeScale()); // b272 247 (tangent.w sign)

                o.uv0 = v.texcoord0;       // b272 lines 260-263
                o.uv1 = v.texcoord1;       // b272 lines 264-267
                // Vertex color exposure de-scale (b272 lines 248-251): (1 - _SurfaceType[13])*COLOR when not
                // camera-relative; the HGRP exposure param _SurfaceType[13] has no URP analog -> identity.
                o.vertColor = v.color;
                o.fogFactor = ComputeFogFactor(o.positionCS.z); // HG fog stack -> URP fog (b273 1413-1474)
                return o;
            }

            half4 frag(Varyings input, bool facing : SV_IsFrontFace) : SV_Target
            {
                float3 P = input.positionWS;                    // b273 _186/_187/_188 (depth-reconstructed WS == own surface WS)
                float2 screenUV = input.positionCS.xy / _ScreenParams.xy; // b273 301-302 gl_FragCoord.xy * _ScreenSize.zw

                // ---- View vector V (world, pointing toward camera) ----  (b273 308-317)
                // perspective: normalize(camPos - P) ; ortho: +UNITY_MATRIX_V[2].xyz (third row of V = toward-camera dir).
                // b273 309-311 ortho branch = _ViewMatrix[0].z/[1].z/[2].z (third ROW of column-major V) with NO negation;
                //   URP's GetWorldSpaceViewDir ortho = +UNITY_MATRIX_V[2].xyz (a leading minus flips cosI/Fresnel/refraction).
                bool isOrtho = (0.0 != unity_OrthoParams.w);                // b273 308 (_210 = 0==ortho.w; inverted)
                float3 viewRaw = isOrtho ? UNITY_MATRIX_V[2].xyz            // b273 309-311 (third row, NO negate)
                                         : (_WorldSpaceCameraPos - P);
                float distSq = dot(viewRaw, viewRaw);                       // b273 312 (_248)
                float invLen = rsqrt(max(distSq, EPS_VIEWLEN));            // b273 313 (_253)
                float3 V = viewRaw * invLen;                              // b273 314-316 (_254/_255/_256)
                float  viewDist = distSq * invLen;                       // b273 317 (_257 linear eye dist)
                // view-space depth for near fade (b273 307 _205 = |dot(V[2].xyz, worldDir) + V[2].w|).
                float viewDepth = abs(dot(UNITY_MATRIX_V[2].xyz, P) + UNITY_MATRIX_V[2].w); // b273 307 (_205)

                float custom1Scalar = _VFXTime;                            // b273 _VFXParams0.w substitute
                float worldHash = frac(unity_ObjectToWorld._m03 + unity_ObjectToWorld._m13 + unity_ObjectToWorld._m23) * _WaterRandomUV; // b273 319 (_375)

                // ---- Disturb (UV offset / packed normal) ----  (b291/b303 352-362)
                // Disturb tex sampled in its own UV; its decoded XY perturbs the main/normal sample UVs and
                // (when _DisturbTex1Normal) feeds the surface normal. Base (#else b273) has NO disturb.
                float2 disturbOffset = float2(0.0, 0.0);
            #ifdef _USE_DISTURB
                float2 disturbUV = BuildVfxUV(input.uv0.xy, input.uv1, input.uv0, _DisturbUVSpeed1,
                                              _DisturbUVRotateMat1, _DisturbUVWeights1, _DisturbTex1_ST,
                                              custom1Scalar, worldHash, custom1Scalar); // b291 352 (_557)
                float4 disturbSample = SAMPLE_TEXTURE2D(_DisturbTex1, sampler_DisturbTex1, disturbUV); // b303 362 (_461)
                // 1:1 from b303 363-365. Bi-direction U base: _476 = R*(1+_Bi_Disturb) - _Bi_Disturb
                //   ( _Bi_Disturb=0 -> raw R in [0,1] one-directional ; =1 -> mad(R,2,-1) signed bidirectional ).
                float disturbU0 = mad(disturbSample.x, 1.0 + _Bi_Disturb, -_Bi_Disturb); // b303 363 (_476, _UseMaskTexAsAlpha slot = _Bi_Disturb)
                // _DisturbTex1Normal (b303 364 _494) selects packed-normal decode vs scalar warp:
                //   normal: U = mad(_476*A, 2, -1) ; V = mad(G, 2, -1).  scalar: U = V = _476.
                float disturbUraw = (0.0 != _DisturbTex1Normal) ? mad(disturbU0 * disturbSample.w, 2.0, -1.0) : disturbU0; // b303 365 (_494 ? .. : ..) U
                float disturbVraw = (0.0 != _DisturbTex1Normal) ? mad(disturbSample.y, 2.0, -1.0)            : disturbU0; // b303 365 (_494 ? .. : ..) V
                disturbOffset = float2(disturbUraw * _DisturbUIntensity1, disturbVraw * _DisturbVIntensity1) * _MainTexUseDisturb; // b303 365 (*_DisturbUIntensity1/_DisturbVIntensity1 then *_MainTexUseDisturb)
            #endif

                // ---- Main tex UV (channel/polar/screen select -> scroll -> rotate -> ST) + sample ----  (b273 319-326)
                float2 mainUV = BuildVfxUV(input.uv0.xy, input.uv1, input.uv0, _MainTexUVSpeed,
                                           _MainTexUVRotateMat, _MainTexUVWeights, _MainTex_ST,
                                           custom1Scalar, worldHash, custom1Scalar); // b273 320-321 (_387/_388)
                mainUV += disturbOffset;                                    // b291: main UV offset by disturb
                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, mainUV); // b273 322 (_395)

                // mainTex alpha source: R when _UseMainTexAsAlpha else A.  1:1 reduces to lerp(A, R, X). (b273 332 _401 vs _398)
                float mainAlpha = lerp(mainSample.a, mainSample.r, _UseMainTexAsAlpha); // b273 332 (_398 vs _401)

                // ---- Surface normal: geometric vertex normal, or tangent-space normal map perturb ----  (b291 363-369)
                float3 geomN = facing ? input.normalWS : -input.normalWS;   // b273 324-327 / b291 366-369 front-face flip (_492/_493/_494)
                float3 N = geomN;
            #ifdef _NORMAL_MAP
                {
                    // normal map sampled with disturbed UV (b291 reuses disturb-driven UV); DXT-style packed normal
                    // with Z reconstructed (b291 354-356), scaled by _NormalScale (b291 357 _MaskTexUVSpeed.x).
                    float2 nUV = BuildVfxUV(input.uv0.xy, input.uv1, input.uv0, _NormalMapUVSpeed,
                                            _NormalMapUVRotateMat, _NormalMapUVWeights, _NormalMap_ST,
                                            custom1Scalar, worldHash, custom1Scalar);
                    nUV += disturbOffset;
                    float4 nSample = SAMPLE_TEXTURE2D(_NormalMap, sampler_NormalMap, nUV);       // b291 353 analog (_556)
                    float2 nxy = mad(float2(nSample.x * nSample.w, nSample.y), 2.0, -1.0);       // b291 354-355 (_562/_563)
                    float nz  = max(sqrt(mad(-min(dot(nxy, nxy), 1.0), 1.0, 1.0)), 1.000000016862383526387164645044e-16); // b291 356 (_571 = sqrt(1-dot(xy,xy)))
                    float3 nTS = float3(nxy * _NormalScale, nz);                                 // b291 357-358 (_577/_578 scale by _NormalScale)
                    nTS = normalize(nTS);                                                        // b291 359-362 (_582 rsqrt)
                    // TBN built from the RAW (un-flipped) vertex basis TEXCOORD_2/TEXCOORD_3 (b291 363-365);
                    //   bitangent = tangent.w sign(_216) * cross(normalWS, tangentWS). The whole perturbed
                    //   normal is front-face-flipped ONCE at the end (b291 366-369). Building the TBN from a
                    //   pre-flipped geomN would double-flip the map contribution on back-faces.
                    float3 bitangent = input.tangentWS.w * cross(input.normalWS, input.tangentWS.xyz); // b291 363-365 (_216 * cross(TEXCOORD_2,TEXCOORD_3))
                    float3 perturbed = nTS.x * input.tangentWS.xyz + nTS.y * bitangent + nTS.z * input.normalWS; // b291 363-365 (_640/_641/_642: nx*T + ny*B + nz*N_raw)
                    N = facing ? perturbed : -perturbed;                                         // b291 366-369 front-face flip of perturbed (_650/_651/_652)
                }
            #endif

                // ---- Opacity assembly ----  (b273 332-354, 591-601 _570/_571)
                // near-fade (dual band) * mainAlpha * vertColor.a(DisableVertColor) * _TintColor.a * _TintColorAlpha *
                //   angular view-N fade * (mask alpha) * vertex-color-opacity * Fresnel-opacity, clamped [0,1].
                float nearFade = 1.0;
                if (0.0 != _UseNearCameraFade) {                            // b273 332 (_UseMaskTexAsAlpha!=0 gate; near-fade dual band)
                    nearFade = saturate((viewDepth - _NearCameraFadeDistanceStart) / (_NearCameraFadeDistanceEnd - _NearCameraFadeDistanceStart))
                             * saturate((viewDepth - _NearCameraFadeDistanceEnd2)  / (_NearCameraFadeDistanceStart2 - _NearCameraFadeDistanceEnd2)); // b273 332 (_205 clamps)
                }
                float vertA = lerp(input.vertColor.a, 1.0, _DisableVertColor); // b273 332 (mad(_DisableVertColor, 1-vc.a, vc.a))
                // angular view-N fade (b273 332 _MaskTexUVSpeed.w * (|dot(N_geo, V)|^_MaskTexUVSpeed.y - 1) + 1).
                float angFade = mad(_MaskTexUVSpeed.w, exp2(log2(abs(dot(input.normalWS, V))) * _MaskTexUVSpeed.y) - 1.0, 1.0); // b273 332 (_570 inner)
                // vertex-color-as-opacity (b273 332 mad(weights.x, vc.a-1, 1) = lerp(1, vc.a, X)). RAW vertColor.a.
                float vcOpacity = lerp(1.0, input.vertColor.a, _UseVertexColorAsOpacity); // b273 332 (mad(_MaskTexUVWeights.x, TEXCOORD_4.w-1, 1))
                float fresnelOpacity = 1.0;
                if (0.0 != _UseFresnelAsOpacity) {                          // b273 _UseFresnelAsOpacity branch (pow(|N.V|, _FresnelStrength))
                    fresnelOpacity = pow(abs(dot(input.normalWS, V)), _FresnelStrength);
                }
                float opacity = mainAlpha * (vertA * _TintColor.a) * _TintColorAlpha * nearFade * angFade * vcOpacity * fresnelOpacity; // b273 332 (_570)

                // Mask (b277) modulates BOTH opacity and tint color, gated by _UseMaskTexAsAlpha:
                //   opacity *= lerp(maskA, maskR, X)        (b277 366 _673 first factor)
                //   tint.rgb *= lerp(maskRGB, 1.0, X)       (b277 369-371 _700/_702/_703 PER-CHANNEL co-factor)
                // X=1 -> mask R is the opacity gate & color untouched ; X=0 -> mask A is opacity, mask RGB tints color
                //   per channel (NOT scalar maskR: b277 _700 uses _481=maskR, _702 uses _482=maskG, _703 uses _483=maskB).
                float3 maskColorFactor = float3(1.0, 1.0, 1.0);
            #ifdef _USE_MASK
                float2 maskUV = BuildVfxUV(input.uv0.xy, input.uv1, input.uv0, _MaskTexUVSpeed,
                                           _MaskTexUVRotateMat, _MaskTexUVWeights, _MaskTex_ST,
                                           custom1Scalar, worldHash, custom1Scalar);
                float4 maskSample = SAMPLE_TEXTURE2D(_MaskTex, sampler_MaskTex, maskUV); // b277 355 (_479)
                opacity *= lerp(maskSample.a, maskSample.r, _UseMaskTexAsAlpha); // b277 366 (_481/_484 select on opacity)
                maskColorFactor = lerp(maskSample.rgb, float3(1.0, 1.0, 1.0), _UseMaskTexAsAlpha); // b277 369-371 (mad(X,1-maskRGB,maskRGB) PER-CHANNEL co-factor on tint RGB)
            #endif

                opacity = saturate(opacity);                               // b273 333 (_571 = clamp(_570,0,1))

                // ---- Dissolve ----  (b307 358-380)  schedule threshold gates opacity; edge band folds into tint.
                //   _587 = dissolveR + 1 - schedule ; schedule = mad(_DissolveScheduleOffset, 2.02, -0.01)   (b307 369)
                //     (the b307 vertex-range clamp _673 and the custom1.z [TEXCOORD_1.z*_InParticle] schedule ride
                //      are particle-authoring vertex-stream inputs the port drops -> their multiplicand collapses to 1).
                //   dissolveWeight = clamp(_587 * _DissolveEdgeSharp, 0, 1)             (b307 375 opacity gate)
                //   dissolveEdge   = _602 = clamp((_DissolveEmissiveEdge - _587) * _DissolveEdgeSharp, 0, 1) (b307 370)
                float dissolveEdge = 0.0;                                   // _602 (0 when _USE_DISSOLVE off)
            #ifdef _USE_DISSOLVE
                {
                    float2 dUV = BuildVfxUV(input.uv0.xy, input.uv1, input.uv0, _DissolveUVSpeed,
                                            _DissolveUVRotateMat, _DissolveUVWeights, _DissolveTex_ST,
                                            custom1Scalar, worldHash, custom1Scalar);
                    dUV += disturbOffset * _DissolveTexUseDisturb;          // b307 dissolve-tex-use-disturb scale (_MaskTexUseDisturb path)
                    float dNoise = SAMPLE_TEXTURE2D(_DissolveTex, sampler_DissolveTex, dUV).r; // b307 368 (_545.x)
                    float schedule = mad(_DissolveScheduleOffset, 2.019999980926513671875, -0.0099999904632568359375); // b307 369 (mad(.., 2.02, -0.01))
                    float dThresh = (dNoise + 1.0) - schedule;             // b307 369 (_587 = _545.x + 1 - schedule, vertex-range clamp = 1)
                    dissolveEdge = saturate((_DissolveEmissiveEdge - dThresh) * _DissolveEdgeSharp); // b307 370 (_602)
                    opacity *= saturate(dThresh * _DissolveEdgeSharp);     // b307 375 (clamp(_587*_DissolveEdgeSharp,0,1) gates opacity)
                }
            #endif

                // ---- Tint color ----  (b273 334-340, 591-601)
                // tintCol = mainTex.rgb (R-as-alpha gated -> white when _UseMainTexAsAlpha) * vertColor.rgb *
                //   _TintColor.rgb * _TintColorIntensity / exposureDeScale, clamped [0,1000].
                float exposureScale = mad(_ExposureParams.x, _IgnorePostExposure, 1.0 - _IgnorePostExposure); // b273 334 (_584)
                float3 mainColorFactor = lerp(mainSample.rgb, float3(1.0, 1.0, 1.0), _UseMainTexAsAlpha);      // b273 335-337 (_591/_593/_594 first factor)
                mainColorFactor *= maskColorFactor;                                                            // b277 369-371 mask-RGB per-channel tint co-factor ((1,1,1) when _USE_MASK off)
                float3 vertRGB = lerp(input.vertColor.rgb, float3(1.0, 1.0, 1.0), _DisableVertColor);          // b273 335-337 (mad(_DisableVertColor, 1-vc.xyz, vc.xyz))
                float3 tintNumer = (mainColorFactor * (vertRGB * _TintColor.rgb)) * _TintColorIntensity;       // b273 335-337 / b307 365-367 (_468/_469/_470 pre-exposure tint)
                // Dissolve edge-emissive fold (b307 378-380): tint = tintBase*(1-_602) + _602^2 * _DissolveEmissiveColor * _TintColorIntensity.
                tintNumer = mad(dissolveEdge.xxx, mad(dissolveEdge.xxx * _DissolveEmissiveColor.rgb, _TintColorIntensity.xxx, -tintNumer), tintNumer); // b307 378-380 (mad(_602, mad(_602*emis,_TCI,-base), base))
                float3 tintCol = min(max(tintNumer / exposureScale, 0.0), 1000.0); // b273 335-337 (_591/_593/_594 = /exposure, clamp [0,1000])
                float3 litTint = tintCol * _UseLighting;                    // b273 338-340 (_599/_600/_601)

                // ---- Diffuse / F0 split ----  (b273 347-354)
                // dielectric F0 = 0.08 * _Specular ; _Metallic splits diffuse vs F0. NO _UseMainTexAsAlpha here.
                //   b273 aliases _Specular->_MaskTexUVRotateMat.w, _Metallic->_MaskTexUVRotateMat.y (re-exposed as real names).
                float dielF0 = DIELECTRIC_F0 * _Specular;                   // b273 347 (_672 = 0.08*.w)
                float3 diffuseCol = litTint * (1.0 - _Metallic);            // b273 348-350 (_686 = _591*.x*(1-.y) = litTint*(1-metallic))
                float  f0Scalar  = mad(-dielF0, _Metallic, dielF0);         // b273 351 (_693 = dielF0*(1-.y) = dielF0*(1-metallic))
                float3 f0        = mad(litTint, _Metallic, f0Scalar.xxx);   // b273 352-354 (_697 = _599*.y + _693 = lerp(dielF0, litTint, metallic))

                // ---- Indirect SH ambient ----  (b273 600-607)
                // HG: diffuseCol * dot(_IVDefaultSHA[rgb], float4(N,1)) -> URP SampleSH(N) per channel.
                // _SUBSURFACE (b275 599-604): the diffuse factor feeding ambient becomes
                //   mad(subsurfaceColor*diffuseR, _SubsurfaceIndirect, diffuseCol)  BEFORE the SH multiply & grade,
                //   where _1123/_1124/_1125 = diffuseR(_611) * HSV(_SubsurfaceColor) and _MaskTexUVSpeed.w = _SubsurfaceIndirect.
                //   The clean HDR _SubsurfaceColor already carries the HSV hue/sat/value, so it collapses to *_SubsurfaceColor.rgb.
                float3 ambientDiffuse = diffuseCol;                          // b275 602-604 _603 base diffuse
            #ifdef _SUBSURFACE
                ambientDiffuse = mad(diffuseCol.r * _SubsurfaceColor.rgb, _SubsurfaceIndirect.xxx, diffuseCol); // b275 602 (mad(_1123, _MaskTexUVSpeed.w, _603))
            #endif
                float3 sh = max(SampleSH(N), 0.0);                           // b273 600-602 (_1122 = _686 * max(SH·N, 0); HG clamps SH dot to 0)
                float3 indirect = ambientDiffuse * sh * _EnvironmentGlobalParams0.x; // b273/b275 600-603 (_1147..* envParams.x)
                float  indLuma = dot(indirect, float3(1.0, 1.0, 1.0)) * 0.3333333432674407958984375; // b273 603 (_1136 avg)
                float3 indirectGraded = mad(indirect - indLuma.xxx, _MaskTexUVSpeed.z, indLuma.xxx);  // b273 605-607 (_1147/_1148/_1149 saturation grade; _IndirectSaturation slot)

                // ---- Direct main light (PBR) ----  (b273 806-860)
                float4 shadowCoord = TransformWorldToShadowCoord(P);        // HG CSM/ASM -> URP shadow coord
                Light mainLight = GetMainLight(shadowCoord, P, half4(1, 1, 1, 1));
                float  mainAtten = mainLight.distanceAttenuation * mainLight.shadowAttenuation; // b273 802 (_1389 final shadow)
                float3 directLight = float3(0, 0, 0);
                {
                    float3 L = mainLight.direction;                        // b273 813-825 (light dir; area-soften dropped)
                    float3 H = normalize(L + V);                          // b273 826-832 (_1744..1754)
                    float NoL = saturate(dot(L, N));                      // b273 833 (_1758)
                    float NoH = saturate(dot(N, H));                      // b273 834 (_1762)
                    float NoV = saturate(dot(N, V));                      // b273 835 (_1766)
                    float VoH = saturate(dot(V, H));                      // Schlick VoH base dot
                    // energyBracket = msDiff + min(D*Vis*F, 2048), clamped [0,1000]. (b273 1853)
                    float3 energyBracket = DirectLightEnergy(_Roughness, f0, NoL, NoH, NoV, VoH); // b273 1850-1853 (_1835 bracket)
                    // HG then: /max(opacity,0.01), min(...,1000), *_DirSpecularStrength on the WHOLE bracket (b273 852-853).
                    float opacityFloor = max(opacity, 0.00999999977648258209228515625); // b273 852 (_1895)
                    float3 energyDir = min(energyBracket / opacityFloor, 1000.0) * _DirSpecularStrength; // b273 853 (/_1895, min, *_MaskTexUVSpeed.x = _DirSpecularStrength)
                    // out = (energyDir*NoL + diffuseCol*NoL) * lightColor * atten   (b273 853-855 mad(...,_1758, _686*_1758) * lightCol)
                    // HG T13 shadow-falloff ramp (b273 856-860 _1929) is engine infra -> URP shadowAttenuation; dropped.
                    directLight = mad(energyDir, NoL, diffuseCol * NoL) * (mainAtten * mainLight.color); // b273 853-860 (_1920/_1921/_1922 -> _2232/_2233/_2234)
                }

                // ---- Additional (punctual) lights ----  (b273 870-1412 cluster -> URP loop)
                float3 addLight = float3(0, 0, 0);
            #if defined(_ADDITIONAL_LIGHTS)
                uint addCount = GetAdditionalLightsCount();
                for (uint li = 0u; li < addCount; ++li)                     // b273 912/925 nested light loop -> URP GetAdditionalLight
                {
                    Light l = GetAdditionalLight(li, P, half4(1, 1, 1, 1));
                    float3 L = l.direction;
                    float3 H = normalize(L + V);
                    float NoL = saturate(dot(L, N));
                    float NoH = saturate(dot(N, H));
                    float NoV = saturate(dot(N, V));
                    float VoH = saturate(dot(V, H));
                    float3 energy = DirectLightEnergy(_Roughness, f0, NoL, NoH, NoV, VoH); // b273 1200-1207 (same BRDF per light)
                    float atten = l.distanceAttenuation * l.shadowAttenuation;
                    addLight += mad(energy, NoL, diffuseCol * NoL) * (atten * l.color);    // b273 1205-1207 (_4064/_4066/_4068)
                }
            #endif

                // ---- Surface lit color = unlit-tint + VFX-graded indirect + direct + add lights ----  (b273 3394-3396 LIGHTING_SUM)
                float sceneDarken = 1.0 - _IsSceneEffect;                   // b273 608 (_1154)
                // unlit-tint passthrough: emissive tint * (1 - _UseLighting), modulated by VFX grade & exposure.
                // b273 3394 inner: mad(_591, _2306, ...) where _2306 = 1 - _MaskTexUVRotateMat.x = 1 - _UseLighting
                //   (the .x slot is the lit-tint multiplier; _599 = _591*.x = litTint). NOT _Metallic.
                float3 unlitTint = tintCol * (1.0 - _UseLighting);          // b273 883/3394 (_2306 = 1 - .x = 1 - _UseLighting)
                // VFX saturation grade of the indirect term, gated by _IsSceneEffect (b273 3394 inner mad):
                //   grade = (_VfxColorGrade.w*(indirectGraded - luma) + luma) * _VfxColorGrade.xyz
                float indLumaGrade = dot(indirectGraded, LUM);             // b273 3475 (_3288)
                float3 indirectVfx = mad(_VfxColorGrade.w, indirectGraded - indLumaGrade.xxx, indLumaGrade.xxx) * _VfxColorGrade.xyz; // b273 3394 (VFX grade _VFXParams1)
                float3 indirectTerm = mad(indirectVfx, _IsSceneEffect, indirectGraded * sceneDarken); // b273 3394 mad(grade, _IsSceneEffect, _1147*_1154)
                float3 lightingSum = unlitTint + indirectTerm + (directLight + addLight); // b273 3394-3396 (_591*_2306 + indirectTerm + (_2392*_2388 + _2232))
                // (b307 dissolve edge-emissive is folded into tintCol above per b307 378-380, NOT a separate lightingSum add.)

                // ---- Composite blend factor ----
                float blendAlpha = 1.0 - _BlendMode;                        // b273 1413 (_2598 = 1 - _BlendMode ; 1=alpha,0=additive)

                // ---- Fog: HG atmosphere+exp+volumetric (b273 1413-1474) -> URP fog (transmittance + gated inscatter).
                //   b273 3394: result = lightingSum*transmittance(_2652*_3287) + _2598*inscatter. The _2598=(1-_BlendMode)
                //   factor multiplies ONLY the inscatter (transmittance is never gated), so additive (_BlendMode=1 ->
                //   _2598=0) keeps transmittance darkening but receives NO fog inscatter color.
                //   URP MixFogColor(c, fogCol, f) = lerp(fogCol, c, intensity) = c*intensity + fogCol*(1-intensity),
                //   guarded by the FOG_* keyword + IsFogEnabled() (no-op when fog off). Pre-scaling fogColor by
                //   blendAlpha gates the inscatter exactly like _2598 while leaving the c*intensity transmittance intact.
                float3 surfFogged = MixFogColor(lightingSum, blendAlpha * unity_FogColor.rgb, input.fogFactor); // b273 3394 (lightingSum*transmit + _2598*inscatter)
            #ifdef VFX_WATER_REFRACT
                // ---- Refraction: Snell's law through N, view-space-projected screen offset ----  (b347 400-408)
                float cosI = dot(-V, N);                                    // b347 400 (_764 = dot(-V, N))
                float k = mad(-(_IoR * _IoR), mad(-cosI, cosI, 1.0), 1.0);  // b347 401 (_777 = 1 - IoR^2*(1-cosI^2); _NormalMapUseDisturb slot=_IoR)
                float kSqrt = mad(_IoR, cosI, sqrt(max(k, 0.0)));          // b347 402 (_782 = IoR*cosI + sqrt(k))
                bool noTIR = (k >= 0.0);                                    // b347 403 (_784 TIR mask)
                float refStrength = opacity * _RefractThickness;            // b347 404 (_813 = _730*_NearCameraFadeDistanceStart2 slot=_RefractThickness)
                float3 refrDir = noTIR ? (_IoR * (-V) - N * kSqrt) : float3(0, 0, 0); // b347 405-407 (_814/_815/_816 masked refracted ray)
                float2 refrOffsetVS = mul((float3x3)UNITY_MATRIX_V, refStrength * refrDir).xy; // b347 408 (mul((float3x3)_ViewMatrix, refStrength*refrDir))
                float2 refrUV = screenUV + refrOffsetVS;                    // b347 408 (scene UV = fragcoord*screen + V*refrOffset)
                float3 sceneRefr = SAMPLE_TEXTURE2D_X(_CameraOpaqueTexture, sampler_CameraOpaqueTexture, refrUV).rgb; // b347 408 (_849 raw camera color)
                // refrBg = (opacity*(_RefractTint*_RefractBrightness - 1) + 1) * sceneColor   (b347 1545-1547).
                //   Tint rides INSIDE the brightness mad (tint*brightness), NOT a separate scene*tint multiply.
                float3 refrBg = mad(opacity.xxx, mad(_RefractTint.rgb, _RefractBrightness.xxx, float3(-1.0, -1.0, -1.0)), float3(1.0, 1.0, 1.0)) * sceneRefr; // b347 1545-1547 (_3651/_3652/_3653)
                // opacity * (opacity*litSurface - refrBg) + refrBg  (premultiplied-over)  (b347 1548-1550 outer mad).
                float3 composite = mad(opacity.xxx, mad(surfFogged, opacity.xxx, -refrBg), refrBg);
            #else
                // base (#else b273): NO scene refraction. Composite is opacity*litSurface (premultiplied),
                //   alpha-vs-additive selected by blendAlpha (b273 3397-3400).
                float3 composite = surfFogged * opacity;                    // b273 3397-3399 (_571 * _3394)
            #endif

                // ---- Final VFX saturation color-grade ----  (b273 3401-3430)
                float compLuma = dot(composite, LUM);                       // b273 3401 (_3401)
                float3 graded = mad(_VfxColorGrade.w, composite - compLuma.xxx, compLuma.xxx) * _VfxColorGrade.xyz; // b273 3428-3430 (_VFXParams1 grade)
                float3 outRGB = mad(graded, _IsSceneEffect, sceneDarken * composite); // b273 3428-3430 (mad(grade, _IsSceneEffect, _1154*comp))

                // ---- Output (RT0). Alpha = (1-_BlendMode) * opacity (b273 3400 SV_Target.w = _2598*_571).
                //   Refract mode bakes the scene into RGB, so it forces alpha = 1 to fully replace (b347 1559 SV_Target.w=1). ----
            #ifdef VFX_WATER_REFRACT
                float outA = 1.0;                                           // b347 1559 (SV_Target.w = 1.0)
            #else
                float outA = blendAlpha * opacity;                          // b273 3400 (_3400 = _2598 * _571)
            #endif
                return half4(outRGB, outA);

                // TODO(1:1) ENGINE-SIDE (the only legitimate punt): the HGRP "ForwardOnly" pass writes a 2nd MRT
                //   (SV_Target_1) = packed transparent motion vectors (b273 1491-1492, encode sign(d)*sqrt(sqrt(|d*0.5|))
                //   *0.5+0.5 per channel, gated by clamp(1+_EnableTransparentMV-_SurfaceType)) + a luminance-thresholded
                //   coverage bit (b273 1493 SV_Target_1.z) + a responsive-transparent flag bit in .w (b273 1494,
                //   _SurfaceType*_Responsive). This requires a HOST C# ScriptableRenderFeature that binds a SECOND
                //   render target (a per-camera transparent-motion-vector RTHandle) and a matching multi-RT pass; a
                //   material shader alone cannot create that MRT binding in URP. NOT a texture/formula -> cannot be
                //   closed in-shader. The math itself (d = TEXCOORD_5.xy/TEXCOORD_5.z - TEXCOORD_6.xy/TEXCOORD_6.z,
                //   then the per-channel encode above) is ready to drop into that pass once the host provides the target.
                // NOTE (not a gap): _UseLighting/_Metallic/_Roughness/_Specular/_DirSpecularStrength/_IndirectSaturation are
                //   re-exposed as real source Property names. VERIFIED base-b273 packing: _MaskTexUVRotateMat.x=_UseLighting,
                //   .y=_Metallic, .z=_Roughness, .w=_Specular ; _MaskTexUVSpeed.x=_DirSpecularStrength, .z=_IndirectSaturation
                //   (b291 normal-map moves them to _DisturbUVRotateMat1.xyzw / _DisturbUVSpeed1). The MATH
                //   (lerp(dielF0,litTint,metallic), litTint*(1-metallic) diffuse, 0.08*spec F0, roughness^2 alpha,
                //   *_DirSpecularStrength, unlit = tint*(1-_UseLighting)) is verified 1:1; the slot binding is the
                //   decompiler's per-variant packing. The cite is the MATH OPERATION, not the per-variant cbuffer slot.
                // CLOSED 1:1 (delta-blob bodies read in full, not just heads):
                //   _USE_MASK     = b277 366/369-371 : opacity *= lerp(maskA,maskR,_UseMaskTexAsAlpha) AND
                //                                    tint.rgb *= lerp(maskRGB,1,_UseMaskTexAsAlpha) PER-CHANNEL
                //                                    (b277 _700=maskR/_702=maskG/_703=maskB; was scalar maskR, now float3).
                //   _USE_DISSOLVE = b307 369-380  : _587 = dissolveR+1-mad(_DissolveScheduleOffset,2.02,-0.01);
                //                                    opacity *= clamp(_587*_DissolveEdgeSharp,0,1);
                //                                    edge _602 = clamp((_DissolveEmissiveEdge-_587)*_DissolveEdgeSharp,0,1);
                //                                    tint = base*(1-_602)+_602^2*_DissolveEmissiveColor*_TintColorIntensity.
                //                                    (b307 vertex-range clamp _673 + custom1.z[TEXCOORD_1.z] schedule ride are
                //                                     particle-authoring vertex inputs the port drops -> multiplicand=1.)
                //   _SUBSURFACE   = b275 602-604  : ambientDiffuse = mad(diffuseR*_SubsurfaceColor.rgb,_SubsurfaceIndirect,
                //                                    diffuseCol) folded BEFORE the SH multiply & saturation grade
                //                                    (HSV _1123 hue-wheel collapses into the clean HDR _SubsurfaceColor).
                //   _USE_DISTURB  = b303 363-365  : U base _476 = mad(R,1+_Bi_Disturb,-_Bi_Disturb);
                //                                    _DisturbTex1Normal? (U=mad(_476*A,2,-1),V=mad(G,2,-1)) : (U=V=_476);
                //                                    offset = (U*_DisturbUIntensity1, V*_DisturbVIntensity1)*_MainTexUseDisturb.
                //   _NORMAL_MAP   = b291 363-369  : TBN now built from RAW normalWS/tangentWS, flipped ONCE at the end
                //                                    (was double-flipping the map contribution on back-faces).
                //   VFX_WATER_REFRACT = b347 1545-1559 : refrBg tint folded INSIDE the brightness mad
                //                                    (opacity*(_RefractTint*_RefractBrightness-1)+1)*scene; outA=1 in refract.
            }
            ENDHLSL
        }
    }
}
