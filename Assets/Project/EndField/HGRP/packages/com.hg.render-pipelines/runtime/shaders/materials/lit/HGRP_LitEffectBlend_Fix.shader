// HGRP LitEffectBlend (soft depth-intersection "erosion" Lit surface) -> URP. ForwardLit + ShadowCaster + DepthOnly.
// Merged from: Hidden/HGRP/LitEffectBlend  (.../materials/lit/liteffectblend.shader), BASE variant (catch-all #else):
//   Sub0_Pass0_Vertex_b6.hlsl    (Keywords: HG_ENABLE_MV)              — object->world->clip + TBN basis (Erosion/HGBuffer pass)
//   Sub0_Pass0_Fragment_b7.hlsl  (Keywords: HG_ENABLE_MV)             — 3-map surface pack + scene-depth soft-intersection erosion alpha
//   Sub0_Pass1_Vertex_b22.hlsl   (Keywords: HG_ENABLE_MV)            — ShadowCaster world->shadow-VP
//   Sub0_Pass1_Fragment_b23.hlsl (EMPTY)                            — ShadowCaster depth-only
//   Sub0_Pass2_Vertex_b42.hlsl   (Keywords: HG_ENABLE_MV)            — DepthOnly world->camera-clip
//   Sub0_Pass2_Fragment_b43.hlsl (EMPTY)                            — DepthOnly depth-only
//   Delta variants read for the keyword map (the source HGBuffer pass's multi_compile_local, liteffectblend.shader:142-145):
//    - Sub0_Pass0_Fragment_b9.hlsl   (_TWO_BASEMAP)                  — 2-map packing, ported 1:1 in _core/CoreSurface.hlsl #ifdef _TWO_BASEMAP (b9:139-174).
//    - Sub0_Pass0_Fragment_b11.hlsl  (_EMISSIVE_MAP+_PARALLAX_MAP+_PARALLAX_MAP_WORLDSPACE, fused) — emissive + parallax deltas.
//    - liteffect/Sub0_Pass0_Fragment_b219.hlsl (_PARALLAX_MAP isolated) — cross-check for the parallax-only structure.
// Keywords: _TWO_BASEMAP (2-map packing, ported _core/CoreSurface.hlsl), _EMISSIVE_MAP / _PARALLAX_MAP /
//   _PARALLAX_MAP_WORLDSPACE (emissive + steep-parallax interior-pattern overlays -> s.emission, ported 1:1 in
//   _core/LitEffectBlendModules.hlsl; delta b11), _ALPHATEST_ON (shared shadow/depth clip).
// Kept: full base PBR Lit surface (BaseColor tint/brighter, MRO unpack via _BaseTextureMapCount, roughness Min/Max
//   remap, metallic select, occlusion, two-sided normal, DXT5nm normal decode, F0/diffuse split) — 1:1 via the
//   verified lit-family core (_core/Core{Vertex,Surface,Math}.hlsl). The DEFINING feature: OBJECT-BLEND "EROSION"
//   soft depth-intersection alpha (b7:108-121) — surface fades where it penetrates the scene depth, exposed as
//   _ObjectBlendFactor / _ObjectBlendFallOff. EMISSIVE-MAP + PARALLAX-MAP feature deltas CLOSED 1:1 (b11:200-205,355-357
//   emissive sample/route/color/remap; b11:527-803 steep ray-march interior pattern + Fresnel + anim; b11:821-1016
//   world-projected pattern-color blend) -> all additive to s.emission (b7 base emission = 0).
//   ShadowCaster + DepthOnly passes (1:1, both fragments empty in BASE).
// Removed (pixel-neutral pipeline infra substituted by URP, or HGRP-only globals with no URP equivalent):
//   - The HG 5-MRT deferred GBuffer pack itself (CORE_MATH §1.4 PORT GUIDANCE): the source HGBuffer/Erosion fragment
//     does NO in-fragment lighting (it packs surface to 5 HG targets, shaded later). The HG MRT layout is NOT a URP
//     GBuffer -> re-authored as a single ForwardLit pass that resolves URP PBR in-fragment (CORE_MATH §2.11), output
//     alpha = the erosion factor, Blend SrcAlpha OneMinusSrcAlpha (matches source HGBuffer Blend, skeleton L114).
//   - SV_Target1 LOD-crossfade dither + SV_Target3.xy octahedral normal pack + SV_Target2/3/4 surface MRT channels
//     (b7:122-177) — HG deferred targets; the surface values they carried are consumed in-fragment by URP lighting.
//   - GPU skinning, SRP instancing buffer, packed-octahedral vertex normal stream, HG motion-vector dual-clip
//     interpolators/SV_Target1 (CORE_MATH §0.1/§3) -> URP GetVertexPositionInputs / GetVertexNormalInputs + MotionVectors pass.
//   - camera-relative-rendering (RWS) globals + _NonJitteredViewNoTransProjMatrix + TAA jitter (b6:200-225) ->
//     URP TransformWorldToHClip / UNITY_MATRIX_VP (pixel-identical), jitter dropped (pixel-neutral).
//   - HG scene-depth reconstruction via _InvViewProjMatrix+_ViewMatrix row2 (b7:108-119) -> URP SampleSceneDepth +
//     LinearEyeDepth (both yield the SAME positive view-space eye-Z the blob takes abs() of; faithful substitute).
//   - HG IV-clipmap GI -> SampleSH ; reflection-probe binning -> GlossyEnvironmentReflection ; CSM/ASM atlas ->
//     URP main-light shadow ; froxel fog -> MixFog (all inherited from _core/CoreMath.hlsl, CORE_MATH §2.4/§2.5/§2.7/§2.10).
//   - HG VFX SceneEffect per-renderer globals that ONLY modulate the emissive/parallax overlays (NOT material textures
//     or formulas — those ARE ported above): _VFXParams0/2 (skill emitter world-pos + effect time + secondary sphere)
//     and _unity_Float4x5_Param0/2/4 (SceneEffect "Dark" darken/tint/emissive-override matrix). These are filled
//     per-draw by the host C# HGVfxSceneEffect / character-skill system (no URP global). Declared NEUTRAL in
//     _core/LitEffectBlendModules.hlsl (emitter at origin, darken 0, tint identity) so a material with no skill active
//     renders the source's un-pulsed steady state; the effect TIME channel _VFXParams0.w maps 1:1 to URP _Time.y.
//     ENGINE-SIDE to fully drive: a ScriptableRenderFeature porting HGVfxSceneEffect must set these per renderer.
//     Likewise the worldspace-pattern interaction signals (TEXCOORD_4.x + TEXCOORD_7.y, HG interaction-system
//     vertex interpolators) have no URP standard-mesh analog -> fed 0 (un-triggered). ALL the worldspace MATERIAL
//     math is ported 1:1: the _885 mask-RGB*colorStrength factor, the true _1182 base-alpha/world-Y mask weight,
//     the _1152/_1160 surface-channel selects (baseTex.w / nrm.z / nrm.w re-sampled at identical UVs), and TERM C
//     (_1160*_1142*((_1014+0.3)*_WorldParallaxAdditionalColor)). Only the two interaction interpolators are host-fed.
//
// NOTE: the lit-family ground-truth spine + its HGRP->URP infra substitution is owned by the VERIFIED exemplar
//   _core/Core{Vertex,Surface,Math}.hlsl (re-authored 1:1 from litforward b8/b9 == lit b280/b281 == this shader's b6/b7
//   surface math; CORE_MATH §1 "lit, liteffect, liteffectblend share this GBuffer/ShadowCaster/DepthOnly architecture").
//   This shader #includes that spine and adds ONLY the erosion object-blend (the one thing unique to liteffectblend).
// _ObjectBlendFactor : depth-difference scale (HG blob aliased it as _ParallaxStrength at packoffset c19; the property
//   slot is _ObjectBlendFactor, source skeleton L12 Range(0.03,20)). _ObjectBlendFallOff : pow() exponent (b7:120).
// Texture-channel legend: _BaseColorMap RGB = albedo. _NormalMap (DXT5nm: X in .a, Y in .g; .z unused here in BASE).
//   _MROMap RGB = Metallic, Roughness, Occlusion (_BaseTextureMapCount enum {Three=0,Two=1,TwoWithNoMetallic=2}).

Shader "HGRP/LitEffectBlend_Fix"
{
    Properties
    {
        // ============================================================
        // Blend-state plumbing (BASE Erosion pass = SrcAlpha/OneMinusSrcAlpha; skeleton L114). Driven by material editor.
        // ============================================================
        [HideInInspector] _SrcBlend ("__src", Float) = 5    // SrcAlpha
        [HideInInspector] _DstBlend ("__dst", Float) = 10   // OneMinusSrcAlpha
        [HideInInspector] _ZTest ("__zt", Float) = 4        // LEqual (source ZTest [_ZTestGBuffer], default 4)
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1   // erosion blend = transparent-style
        [HideInInspector] _ShadowCullMode ("Shadow Cull Mode", Float) = 2
        [HideInInspector] _ShadowBias ("Shadow Bias", Float) = 0
        [HideInInspector] _StencilRef ("Stencil Ref", Float) = 0
        [HideInInspector] _PreDepthStencilRef ("Pre-Depth Stencil Ref", Float) = 5

        // ============================================================
        // Core surface / base PBR (always-on; 1:1 b7:140-177 / b9 surface) — owned by _core/CoreSurface.hlsl
        // ============================================================
        [Enum(Three, 0, Two, 1, TwoWithNoMetallic, 2)] _BaseTextureMapCount ("Base Texture Map Count", Float) = 0
        _BaseColorMap ("Base Color Map", 2D) = "white" {}
        _BaseUVSet ("Base UV Set", Float) = 0
        _BaseColor ("Base Color", Color) = (1, 1, 1, 1)
        _BaseColorTintCover ("Base Color Tint Cover", Range(0, 1)) = 0
        _BaseColorBrighterScale ("Base Color Brighter Scale", Range(1, 3)) = 1
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _MROMap ("MRO Map (Metallic,Roughness,Occlusion)", 2D) = "white" {}
        _BasePbrMapUVSet ("PBR Map UV Set", Float) = 0
        _NormalScale ("Normal Scale", Range(0, 1)) = 1
        [Toggle] _TwoSidedNormal ("Two Sided Normal", Float) = 1
        _Metallic ("Metallic", Range(0, 1)) = 0
        _Specular ("Specular", Range(0, 1)) = 0.5
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1
        _OcclusionStrength ("Occlusion Strength", Range(0, 1)) = 1
        [HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}

        // 2-map packing keyword (delta b9:139-174). Ported 1:1 in _core/CoreSurface.hlsl (#ifdef _TWO_BASEMAP):
        // metallic=baseTex.a, occlusion=normal.a, roughness=normal.b, normal.xy NO *.a + 0.012 deadzone.
        [Toggle(_TWO_BASEMAP)] _UseTwoBaseMap ("Use Two Base Map", Float) = 0

        // ============================================================
        // Emissive — [_EMISSIVE_MAP] (source multi_compile_local liteffectblend.shader:143).
        // 1:1 ported in _core/LitEffectBlendModules.hlsl LebEmissive (delta b11:200-205,355-357).
        // ============================================================
        [Header(Emissive)]
        [Toggle(_EMISSIVE_MAP)] _EnableEmissiveMap ("Enable Emissive Map", Float) = 0
        _EmissiveMap ("Emissive Map", 2D) = "black" {}
        [Enum(UV0, 0, UV1, 1)] _EmissiveUVSet ("Emissive UV Set", Float) = 0
        [Enum(ChannelR, 0, ChannelRGBA, 1)] _EmissiveType ("Emissive Type", Float) = 0
        [HDR] [Gamma] _EmissiveColor ("Emissive Color", Color) = (1, 1, 1, 1)
        [HDR] [Gamma] _EmissiveColorG ("Emissive Color (G channel)", Color) = (0, 0, 0, 1)
        [HDR] [Gamma] _EmissiveColorB ("Emissive Color (B channel)", Color) = (0, 0, 0, 1)
        [HDR] [Gamma] _EmissiveColorA ("Emissive Color (A channel)", Color) = (0, 0, 0, 1)
        [ToggleUI] _AlbedoAffectEmissive ("Albedo Affect Emissive", Float) = 1
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        _EmissiveRemap ("Emissive Remap", Range(1, 2)) = 1
        [HideInInspector] _EmissiveSpeed ("Emissive Speed", Vector) = (0, 0, 0, 0)

        // ============================================================
        // Parallax (emissive interior/pattern overlay) — [_PARALLAX_MAP] / [_PARALLAX_MAP_WORLDSPACE]
        // (source multi_compile_local liteffectblend.shader:144-145). 1:1 ported in
        // _core/LitEffectBlendModules.hlsl LebParallax (steep march b11:527-674,803) +
        // LebWorldParallax (world-projected pattern b11:821-1016). Writes to s.emission only.
        // ============================================================
        [Header(Parallax)]
        [Toggle(_PARALLAX_MAP)] _EnableParallaxMap ("Enable Parallax Map", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _ParallaxMapUVType ("Parallax Map UV Type", Float) = 0
        _ParallaxMap ("Parallax Map", 2D) = "black" {}
        _ParallaxNoiseMap ("Parallax Noise Map", 2D) = "black" {}
        _ParallaxNoiseMapTilling ("Parallax Noise Map Tilling", Range(0.01, 20)) = 1
        _ParallaxStrength ("Parallax Strength", Range(0, 1)) = 0
        _ParallaxMarchNum ("Parallax Ray March Num", Range(2, 5)) = 2
        _ParallaxTilling ("Parallax Tilling", Range(0.01, 20)) = 1
        [HDR] _ParallaxColor ("Parallax Color", Color) = (0, 0, 0, 1)
        [HDR] _ParallaxColorDark ("Parallax Color Dark", Color) = (0, 0, 0, 1)
        _ParallaxAnimSpeed ("Parallax Anim Speed", Range(0, 50)) = 0
        [ToggleUI] _ParallaxAnimRandom ("Parallax Anim Random", Float) = 0
        [ToggleUI] _ParallaxCharPos ("Parallax Affected By CharPos", Float) = 0
        _ParallaxBrightOuterRadius ("Parallax Bright OuterRadius", Range(0, 50)) = 20
        _ParallaxBrightInnerRadius ("Parallax Bright InnerRadius", Range(0, 50)) = 10
        _ParallaxBrightStrength ("Parallax Bright Strength", Range(0, 20)) = 1
        _ParallaxMinBrightness ("Parallax Min Brightness", Range(0, 0.5)) = 0
        _ParallaxFresnelStrength ("Parallax Fresnel Strength", Range(0.001, 10)) = 1
        [ToggleUI] _ParallaxIgnorePostExposure ("Parallax Ignore Post Exposure", Float) = 1
        _ParallaxIntensity ("Parallax Intensity", Range(0, 1)) = 1
        // World-space pattern projection ([_PARALLAX_MAP_WORLDSPACE])
        [Toggle(_PARALLAX_MAP_WORLDSPACE)] _UseWorldSpaceParallaxMask ("Use World Space Parallax Mask", Float) = 0
        _ParallaxMaskMap ("Parallax Mask Map", 2D) = "black" {}
        _ParallaxMaskMapColorStrength ("Parallax Mask Map Color Strength", Float) = 1   // b11:80 — mask RGB modulates parallax emission in _885
        [HDR] _ParallaxPatternColor ("Parallax Pattern Color", Color) = (0, 0, 0, 1)
        [HDR] _ParallaxPatternColorDark ("Parallax Pattern Color Dark", Color) = (0, 0, 0, 1)
        _ParallaxLerpSchedule ("Parallax Lerp Schedule", Range(0, 30)) = 0
        _MaskWorldPosParams ("Mask World Pos (xz=pos, y=rot, w=range)", Vector) = (0, 0, 0, 1)
        _ParallaxSignControl ("Parallax Sign Control", Float) = 0
        _ParallaxSignLerpFactor0 ("Parallax Sign Lerp Factor 0", Vector) = (0, 0, 0, 0)
        _ParallaxSignLerpFactor1 ("Parallax Sign Lerp Factor 1 (.w = _1182 mask weight)", Vector) = (0, 0, 0, 0)
        _ParallaxSignLerpFactor2 ("Parallax Sign Lerp Factor 2", Float) = 0
        // World-parallax additional (interaction) color term (b11:100,104; TERM C of b11:355-357).
        _WorldParallaxAdditionalLightMaskChannel ("World Parallax Additional Light Mask Channel", Range(0, 2)) = 0   // b11:100 — selects baseTex.w / nrm.z / nrm.w via 2-stage lerp
        [HDR] _WorldParallaxAdditionalColor ("World Parallax Additional Color", Color) = (0, 0, 0, 1)               // b11:104

        // ============================================================
        // Object Blend (erosion) — THE defining feature of liteffectblend (b7:108-121). No keyword.
        // ============================================================
        [Header(Object Blend)]
        _ObjectBlendFactor ("Object Blend Factor", Range(0.03, 20)) = 1
        _ObjectBlendFallOff ("Object Blend Fall Off", Range(0.2, 5)) = 1

        // ============================================================
        // Alpha Test — [_ALPHATEST_ON] (shared shadow/depth clip; CoreSurface.LitAlphaClip)
        // ============================================================
        [Header(Alpha Test)]
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Enable Alpha Test", Float) = 0
        [Enum(BaseColor_A, 0, NRO_A, 1)] _AlphaMaskChannel ("Alpha Mask Channel", Float) = 0
        _AlphaClipThreshold ("Alpha Clip Threshold", Range(0, 1)) = 0.5

        // ============================================================
        // Advanced / infra (no keyword). _TAAUNormalBiasReverse + vertex-color opacity read by CoreSurface.
        // ============================================================
        [Header(Advanced)]
        _TAAUNormalBiasReverse ("TAAU Normal Bias Reverse", Float) = 0
        [ToggleUI] _Use_VerexTexColorAsOpacity ("Use Vertex Tex Color As Opacity", Float) = 0

        // ============================================================
        // Environment params (HGRP globals re-exposed as material Vectors; URP has no equivalent global —
        // STYLE_BIBLE §1.5 / §2). Ambient + reflection intensity feed (read by _core/CoreMath.hlsl composite).
        // ============================================================
        [Header(Environment Params)]
        _EnvironmentGlobalParams0 ("EnvGlobalParams0 (.x=ambient intensity .y=reflection intensity)", Vector) = (1, 1, 1, 0)
        _ExposureParams ("ExposureParams (.x=exposure)", Vector) = (1, 0, 0, 0)
    }

    SubShader
    {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Transparent" "Queue"="Transparent" }
        LOD 600

        HLSLINCLUDE
            // ============================================================
            // URP infrastructure (substitutes for all HGRP hand-rolled globals — STYLE_BIBLE §2).
            // ============================================================
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"
            // Scene depth (for the erosion soft-intersection): provides _CameraDepthTexture + SampleSceneDepth().
            // Faithful substitute for the HG manual depth reconstruction (b7:108-119) — see header NOTE.
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

            // ============================================================
            // FROZEN UNIFORM INTERFACE — single UnityPerMaterial CBUFFER (every uniform once; NO packoffset).
            // Field set: the liteffectblend BASE material cbuffer (b7:32-58) re-identified by usage, plus the
            // _core spine's contract fields (_TAAUNormalBiasReverse, _Use_VerexTexColorAsOpacity,
            // _EnvironmentGlobalParams0). _GlobalMipBias is NOT declared here — URP owns it as a global float2
            // (Input.hlsl) and SAMPLE_TEXTURE2D_BIAS auto-adds it (CoreSurface note; CORE_MATH §2.12).
            // ============================================================
            CBUFFER_START(UnityPerMaterial)
                // ---- Blend-state plumbing ----
                float _SrcBlend;
                float _DstBlend;
                float _ZTest;
                float _CullMode;
                float _SurfaceType;
                float _ShadowCullMode;
                float _ShadowBias;
                float _StencilRef;
                float _PreDepthStencilRef;

                // ---- Core surface / base PBR (b7:32-58, CORE_MATH §0.2) ----
                float4 _BaseColor;
                float4 _BaseColorMap_ST;
                float4 _NormalMap_ST;
                float _BaseTextureMapCount;
                float _BaseUVSet;
                float _BasePbrMapUVSet;
                float _BaseColorTintCover;
                float _BaseColorBrighterScale;
                float _NormalScale;
                float _TwoSidedNormal;
                float _Metallic;
                float _Specular;
                float _RoughnessMin;
                float _RoughnessMax;
                float _OcclusionStrength;
                float _TAAUNormalBiasReverse;
                float _Use_VerexTexColorAsOpacity;

                // ---- Object Blend (erosion) — b7:120 (_ObjectBlendFactor aliased _ParallaxStrength c19 in blob) ----
                float _ObjectBlendFactor;
                float _ObjectBlendFallOff;

                // ---- Emissive (b11:91-99 cbuffer; LebEmissive) ----
                float4 _EmissiveMap_ST;
                float4 _EmissiveColor;
                float4 _EmissiveColorG;
                float4 _EmissiveColorB;
                float4 _EmissiveColorA;
                float4 _EmissiveSpeed;
                float _EmissiveUVSet;
                float _EmissiveType;
                float _EmissiveRemap;
                float _AlbedoAffectEmissive;
                float _IgnorePostExposure;

                // ---- Parallax (steep emissive overlay; b11:65-104 cbuffer; LebParallax/LebWorldParallax) ----
                float4 _ParallaxColor;
                float4 _ParallaxColorDark;
                float4 _ParallaxPatternColor;
                float4 _ParallaxPatternColorDark;
                float4 _MaskWorldPosParams;
                float4 _ParallaxSignLerpFactor0;
                float4 _ParallaxSignLerpFactor1;
                float _ParallaxStrength;          // b11:65 (aliases _ObjectBlendFactor slot in the blob; SEPARATE property here)
                float _ParallaxMarchNum;          // b11:67 (blob types it uint; declared float here for Unity Range-property compat, cast to float in-shader anyway)
                float _ParallaxTilling;           // b11:68
                float _ParallaxAnimSpeed;         // b11:69
                float _ParallaxAnimRandom;        // b11:70
                float _ParallaxMinBrightness;     // b11:71
                float _ParallaxFresnelStrength;   // b11:72
                float _ParallaxIgnorePostExposure;// b11:73
                float _ParallaxMapUVType;         // b11:74
                float _ParallaxNoiseMapTilling;   // b11:75
                float _ParallaxCharPos;           // b11:76
                float _ParallaxBrightOuterRadius; // b11:77
                float _ParallaxBrightInnerRadius; // b11:78
                float _ParallaxBrightStrength;    // b11:79
                float _ParallaxLerpSchedule;      // b11:81
                float _ParallaxSignControl;       // b11:82
                float _ParallaxIntensity;         // b11:83
                float _ParallaxMaskMapColorStrength;          // b11:80 — mask-RGB color strength (worldspace _885 factor)
                float _ParallaxSignLerpFactor2;   // b11:101
                float _WorldParallaxAdditionalLightMaskChannel; // b11:100 — TERM C surface-channel select
                float4 _WorldParallaxAdditionalColor;           // b11:104 — TERM C interaction color

                // ---- Alpha Test ----
                float _AlphaMaskChannel;
                float _AlphaClipThreshold;

                // ---- Environment / Exposure (HGRP globals re-exposed; CORE_MATH §2.4/§2.11) ----
                float4 _EnvironmentGlobalParams0;
                float4 _ExposureParams;
            CBUFFER_END

            // ============================================================
            // FROZEN TEXTURE INTERFACE — re-identified from the blob Tn by usage (b7:60-67):
            //   T1 (sampled _382, .rgb albedo, b7:142)  -> _BaseColorMap
            //   T2 (sampled _446, normal, b7:152)       -> _NormalMap   (DXT5nm: x in .a via *.w trick, b7:153)
            //   T3 (sampled _420, MRO,    b7:148)       -> _MROMap      (.x metallic .y roughness .z occlusion)
            // (T0 = scene depth -> URP _CameraDepthTexture, declared by DeclareDepthTexture.hlsl above.)
            // Wrap modes (CORE_MATH §0.3): base=mirror, normal=clamp, MRO=repeat — set on the import asset.
            // ============================================================
            TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);   // T1 (b7:142) albedo
            TEXTURE2D(_NormalMap);      SAMPLER(sampler_NormalMap);      // T2 (b7:152) DXT5nm normal
            TEXTURE2D(_MROMap);         SAMPLER(sampler_MROMap);         // T3 (b7:148) metallic/roughness/occlusion
            // Emissive + Parallax maps (b11 T4/T6/T3/T5; re-identified by usage in LitEffectBlendModules.hlsl).
            TEXTURE2D(_EmissiveMap);      SAMPLER(sampler_EmissiveMap);      // _EMISSIVE_MAP   (b11:200 T4)
            TEXTURE2D(_ParallaxMap);      SAMPLER(sampler_ParallaxMap);      // _PARALLAX_MAP   (b11:305 height/color)
            TEXTURE2D(_ParallaxNoiseMap); SAMPLER(sampler_ParallaxNoiseMap); // _PARALLAX_MAP   (b11:277 march noise)
            TEXTURE2D(_ParallaxMaskMap);  SAMPLER(sampler_ParallaxMaskMap);  // _PARALLAX_MAP_WORLDSPACE (b11:329 world mask)

            // ============================================================
            // FROZEN SHARED DATA STRUCTS — populated by the core trio (_core/*.hlsl).
            // ============================================================

            // Vertex input (URP-standard appdata; GPU-skin / octahedral-packed normal / MV streams DROPPED —
            // CORE_MATH §0.1/§3.1 — fed plain via GetVertexNormalInputs).
            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;     // vertex color (.x reused as opacity — b7/b9 _349)
                float2 uv0        : TEXCOORD0;
                float2 uv1        : TEXCOORD1;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            // Interpolators (worldPos + TBN + 2 UV sets + vertex color + view dir + fog). HG dual-clip MV
            // interpolators (TEXCOORD5/6) DROPPED — URP MotionVectors pass owns them.
            struct Varyings
            {
                float4 positionCS  : SV_Position;
                float3 positionWS  : TEXCOORD0;
                float3 normalWS    : TEXCOORD1;
                float4 tangentWS   : TEXCOORD2;   // .xyz tangent, .w = sign*handedness
                float4 uv          : TEXCOORD3;   // .xy = uv0, .zw = uv1 (raw; CoreSurface applies _ST + UV-set lerp)
                float4 color       : TEXCOORD4;   // vertex color rgba
                float3 viewDirWS   : TEXCOORD5;   // camera->fragment (perspective) / -view fwd (ortho), unnormalized
                float  fogFactor   : TEXCOORD6;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                UNITY_VERTEX_OUTPUT_STEREO
            };

            // LitSurfaceData — CoreSurface fills the base block; the lighting composite (CoreMath) consumes it.
            // Name must NOT be `SurfaceData` (collides with URP's struct from Lighting.hlsl->SurfaceData.hlsl).
            struct LitSurfaceData
            {
                half3  albedo;        // saturate(baseTex*_BaseColor*_BaseColorBrighterScale), tint-covered
                half3  normalWS;      // world normal after TBN + two-sided sign
                half   metallic;      // lerp(MRO.r, _Metallic, saturate(_BaseTextureMapCount-1))
                half   roughness;     // linear roughness = lerp(_RoughnessMin,_RoughnessMax,MRO.g)
                half   occlusion;     // lerp(1, MRO.b, _OcclusionStrength)
                half3  emission;      // emissive contribution (BASE liteffectblend = 0, no emissive keyword in this pass)
                half   alpha;         // surface alpha / opacity
                half3  specular;      // dielectric F0 base = 0.08*_Specular (pre-metallic-mix)
                half3  f0;            // lerp(0.08*_Specular, albedo, metallic) — final specular color
                // feature-extension fields (defaulted neutral by CoreSurface; unused by this shader) -----------
                half3  bakedGI;
                half3  subsurfaceColor;
                half   subsurfaceMask;
                half   thickness;
                half3  reflectionColor;
                half   reflectionWeight;
                half3  matcapColor;
                half3  fresnelColor;
                half3  refractionColor;
                half   coatMask;
                half   shadowExtra;
            };

            // ============================================================
            // CORE TRIO — the VERIFIED lit-family spine (re-authored 1:1 from litforward b8/b9 == lit b280/b281 ==
            // this shader's surface math b6/b7; CORE_MATH §1). Owns the frozen prototypes:
            //   CoreVertex.hlsl  : LitVertex / LitShadowVertex / LitDepthVertex (object->world->clip + TBN; drops skin/oct/MV).
            //   CoreSurface.hlsl : LitBuildSurface (UV-set lerp, 3-map sample, DXT5nm normal + two-sided, roughness/
            //                      metallic/occlusion/albedo tint-cover, F0/diffuse split, SampleSH ambient) + LitAlphaClip.
            //   CoreMath.hlsl    : LitForwardLighting (GGX-D + Smith-Vis + Schlick-F direct, SampleSH ambient,
            //                      GlossyEnvironmentReflection, MixFog composite — CORE_MATH §2).
            // ============================================================
            #include "_core/CoreVertex.hlsl"
            #include "_core/CoreSurface.hlsl"
            #include "_core/CoreMath.hlsl"
            // Emissive + Parallax feature deltas (s.emission contributions): the keyword features
            // _EMISSIVE_MAP / _PARALLAX_MAP / _PARALLAX_MAP_WORLDSPACE from the source HGBuffer pass
            // (liteffectblend.shader:143-145), ported 1:1 (delta b11 / cross-checked b219).
            #include "_core/LitEffectBlendModules.hlsl"

            // ============================================================
            // MODULE: ObjectBlend (erosion)  — THE feature unique to liteffectblend.
            // 1:1 source: Sub0_Pass0_Fragment_b7.hlsl L108-121 (== b9 L106-119).
            //
            // The blob reconstructs view-space Z for (a) the scene depth at this pixel and (b) the fragment's own
            // surface depth, then:
            //   _211 = view-space Z of the SCENE (from sampled depth T0)              (b7:118)
            //   _212 = view-space Z of the SURFACE (from gl_FragCoord.z)             (b7:119)
            //   diff = (-abs(_212)) + abs(_211)                                      (b7:120, = abs(sceneZ) - abs(surfZ))
            //   _238 = min( exp2( log2(abs(diff * _ObjectBlendFactor)) * _ObjectBlendFallOff), 1.0)   (b7:120)
            //          masked by ( abs(_212) < abs(_211) ? all-ones : 0 )            (b7:120, near-side gate)
            //   == pow( abs(diff)*_ObjectBlendFactor, _ObjectBlendFallOff ), saturated to 1, ONLY where the surface
            //      is nearer than the scene (abs(surfViewZ) < abs(sceneViewZ)); 0 behind/at the scene surface.
            // This _238 is written to every MRT's .w in the deferred pack (b7:121,138,172,173) = the blend/erosion alpha.
            //
            // INFRA SUBSTITUTION (CORE_MATH §2.12, faithful): HG reconstructs |viewZ| for BOTH the scene and the
            // surface through the IDENTICAL _InvViewProjMatrix+_ViewMatrix-row-2 path (b7:118 from sampled depth _92,
            // b7:119 from gl_FragCoord.z) and takes abs() of each. URP's LinearEyeDepth(rawDepth, _ZBufferParams)
            // returns exactly that positive view-space eye-Z. So abs(_211)=LinearEyeDepth(sceneDepth) and
            // abs(_212)=LinearEyeDepth(surfaceDepth) — both fragment depths run through the SAME function (mirroring
            // the blob's symmetric reconstruction), surface depth = SV_Position.z (the rasterized hardware depth).
            // ============================================================
            float ComputeErosionBlend(float4 positionCS)
            {
                // scene eye-Z at this pixel (abs(_211)); positionCS.xy is the pixel coord, /_ScreenParams.xy -> [0,1] UV.
                float2 screenUV   = positionCS.xy / _ScreenParams.xy;                    // b7:108 pixel-center UV
                float  sceneRaw   = SampleSceneDepth(screenUV);                          // b7:108 T0 raw depth fetch (== _92)
                float  sceneEyeZ  = LinearEyeDepth(sceneRaw, _ZBufferParams);            // b7:118 abs(_211) = |scene viewZ|
                // surface eye-Z (abs(_212)): the fragment's own hardware depth through the SAME LinearEyeDepth path (b7:119).
                float  surfEyeZ   = LinearEyeDepth(positionCS.z, _ZBufferParams);        // b7:119 abs(_212) = |surface viewZ|

                float  diff = sceneEyeZ - surfEyeZ;                                      // b7:120 (-abs(_212)) + abs(_211)
                // pow(|diff|*factor, falloff) via exp2(log2(|.|)*falloff), saturated to 1 (b7:120 min(...,1)).
                float  blend = min(exp2(log2(abs(diff * _ObjectBlendFactor)) * _ObjectBlendFallOff), 1.0);
                // near-side gate: keep only where surface is in FRONT of the scene (abs(surfZ) < abs(sceneZ)) -> b7:120.
                return (surfEyeZ < sceneEyeZ) ? blend : 0.0;
            }
        ENDHLSL

        // ============================================================================================
        // Pass 1: ForwardLit  (the Erosion/HGBuffer pass, re-authored as URP forward — CORE_MATH §1.4/§2.11).
        //   Source HGBuffer render-state (skeleton L114-131): Blend SrcAlpha OneMinusSrcAlpha, ZTest [_ZTestGBuffer],
        //   Cull [_CullMode], Stencil Ref [_StencilRef] Comp Always Pass Replace. Output alpha = erosion blend.
        // ============================================================================================
        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitVertex
                #pragma fragment LitErosionForwardFragment
                // --- material feature keywords (HGRP multi_compile_local -> URP shader_feature_local) ---
                #pragma shader_feature_local _TWO_BASEMAP
                #pragma shader_feature_local _EMISSIVE_MAP
                #pragma shader_feature_local _PARALLAX_MAP
                #pragma shader_feature_local _PARALLAX_MAP_WORLDSPACE
                #pragma shader_feature_local _ALPHATEST_ON
                // --- URP system keywords ---
                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH
                #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
                #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BOX_PROJECTION
                #pragma multi_compile_fragment _ _SCREEN_SPACE_OCCLUSION
                #pragma multi_compile _ LIGHTMAP_ON
                #pragma multi_compile _ DIRLIGHTMAP_COMBINED
                #pragma multi_compile_fog
                #pragma multi_compile_instancing

                // Entry points call the FROZEN core prototypes (implemented in _core/*.hlsl).
                Varyings LitVertex(Attributes IN);                              // _core/CoreVertex.hlsl
                LitSurfaceData LitBuildSurface(Varyings IN, bool isFrontFace);     // _core/CoreSurface.hlsl
                half4 LitForwardLighting(LitSurfaceData s, Varyings IN);           // _core/CoreMath.hlsl

                half4 LitErosionForwardFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                    #ifdef _ALPHATEST_ON
                        LitAlphaClip(IN);                                          // _core/CoreSurface.hlsl
                    #endif
                    // _TWO_BASEMAP 2-map packing: CLOSED 1:1 in the shared spine _core/CoreSurface.hlsl
                    // (LitBuildSurface #ifdef _TWO_BASEMAP branch). Delta source = liteffectblend
                    // Sub0_Pass0_Fragment_b9.hlsl L139-174: metallic=baseTex.w (b9:140), occlusion=nrm.w
                    // (b9:146), roughness=nrm.z (b9:171), normal=(x*2-1,y*2-1) NO *.w + |.|<0.012 deadzone
                    // (b9:149-154). The fix lives in the spine (shared with HGRP_Lit/HGRP_LitEffect),
                    // so this leaf gets correct channel routing under _TWO_BASEMAP automatically.
                    LitSurfaceData s = LitBuildSurface(IN, isFrontFace);

                    // ---- EMISSIVE + PARALLAX feature deltas -> s.emission (CLOSED 1:1, _core/LitEffectBlendModules.hlsl) ----
                    // The source HGBuffer/Erosion fragment writes these to SV_Target.xyz (the HG emission
                    // target); URP CoreMath consumes s.emission into the forward color (CoreMath:272) and the
                    // deferred GI target (CoreMath:334). BASE (b7) emission = 0, so this is purely additive.
                    // _EMISSIVE_MAP: sample + channel-route + color + remap + albedo-affect (b11:200,355).
                    // _PARALLAX_MAP: steep-march emissive interior pattern + Fresnel + anim (b11:527-803).
                    // _PARALLAX_MAP_WORLDSPACE: world-projected pattern-color blend (b11:821-1016).
                    {
                        float2 uv0 = IN.uv.xy;
                        float2 uv1 = IN.uv.zw;
                        float  time = _Time.y;                                       // HG _VFXParams0.w effect time -> URP _Time.y
                        float  tSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
                        float3 emission = float3(0.0, 0.0, 0.0);

                        emission += LebEmissive(uv0, uv1, s.albedo, time);           // _EMISSIVE_MAP (b11:200,355)

                        float3 parallaxPre; float2 parallaxHeights; float3 parallaxColorLerp;
                        // normalGeo = IN.normalWS (geometric, drives TBN view-projection b11:497-515 + mask LOD b11:329);
                        // normalShaded = s.normalWS (normal-mapped, drives Fresnel b11:686).
                        float3 parallaxPlain = LebParallax(uv0, uv1, IN.positionWS, IN.normalWS, s.normalWS,
                                                           IN.tangentWS.xyz, tSign, IN.viewDirWS, time,
                                                           parallaxPre, parallaxHeights, parallaxColorLerp);  // _PARALLAX_MAP (b11:527-803)
                    #ifdef _PARALLAX_MAP_WORLDSPACE
                        // world-projected pattern path REPLACES the plain parallax output with the masked
                        // pattern term + TERM C (b11:355-357: mad(_1182*_1014, _ParallaxIntensity, _1160*(_1142*((_1014+0.3)*_WorldParallaxAdditionalColor)))).
                        // Mask LOD uses the GEOMETRIC world normal Y (b11:329 abs(TEXCOORD_2.y)), passed as IN.normalWS.
                        float  interactSignal  = 0.0;   // TEXCOORD_4.x HG interaction signal (host-fed; neutral 0)
                        float  interactSignalY = 0.0;   // TEXCOORD_7.y HG interaction signal for _1142 (host-fed; neutral 0)
                        emission += LebWorldParallax(parallaxPre, parallaxColorLerp, parallaxHeights, uv0, uv1,
                                                     IN.positionWS, IN.normalWS, interactSignal, interactSignalY);
                    #else
                        emission += parallaxPlain;                                  // _PARALLAX_MAP plain emissive overlay
                    #endif

                        s.emission += half3(emission);
                    }

                    half4 col = LitForwardLighting(s, IN);                         // URP PBR composite (CORE_MATH §2.11) + s.emission (CoreMath:272)
                    // OBJECT-BLEND EROSION: output alpha = the soft depth-intersection factor (b7:108-121).
                    // 1:1 — the source liteffectblend Erosion fragment writes SV_Target.w = _238 DIRECTLY
                    // (b7:121); it has NO _Use_VerexTexColorAsOpacity / vertex-opacity path (that is a
                    // litforward-b9-only field, absent from b7). So ASSIGN (not multiply): a `*=` would
                    // give vertexOpacity*erosion when _Use_VerexTexColorAsOpacity=1, diverging from the
                    // source's pure _238. Under the default flag=0 (s.alpha=1) the two are identical.
                    col.a = ComputeErosionBlend(IN.positionCS);
                    return col;
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2: ShadowCaster  (1:1 Sub0_Pass1, b22 vertex world->shadow-VP + EMPTY fragment b23).
        //   CORE_MATH §4.1 — position-only + URP ApplyShadowBias; alpha-clip only under _ALPHATEST_ON.
        // ============================================================================================
        Pass
        {
            Name "ShadowCaster"
            Tags { "LightMode"="ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_ShadowCullMode]
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitShadowVertex
                #pragma fragment LitShadowFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma shader_feature_local _TWO_BASEMAP
                #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW
                #pragma multi_compile_instancing

                float3 _LightDirection;
                float3 _LightPosition;

                Varyings LitShadowVertex(Attributes IN);   // _core/CoreVertex.hlsl (uses _LightDirection/_LightPosition + ApplyShadowBias)

                half4 LitShadowFragment(Varyings IN) : SV_Target
                {
                    // EMPTY in BASE (b23) — depth-only; alpha-clip only under _ALPHATEST_ON.
                    #ifdef _ALPHATEST_ON
                        LitAlphaClip(IN);                  // _core/CoreSurface.hlsl
                    #endif
                    return 0;
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 3: DepthOnly  (1:1 Sub0_Pass2, b42 vertex world->camera-clip + EMPTY fragment b43).
        //   CORE_MATH §4.3 — camera clip, depth write; Stencil Ref [_PreDepthStencilRef] (skeleton L293-299).
        // ============================================================================================
        Pass
        {
            Name "DepthOnly"
            Tags { "LightMode"="DepthOnly" }
            ZWrite On
            ZTest LEqual
            ColorMask R
            Cull [_CullMode]
            Stencil { Ref [_PreDepthStencilRef] Comp Always Pass Replace }
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitDepthVertex
                #pragma fragment LitDepthFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma shader_feature_local _TWO_BASEMAP
                #pragma multi_compile_instancing

                Varyings LitDepthVertex(Attributes IN);   // _core/CoreVertex.hlsl

                half4 LitDepthFragment(Varyings IN) : SV_Target
                {
                    // EMPTY in BASE (b43) — depth-only; alpha-clip only under _ALPHATEST_ON.
                    #ifdef _ALPHATEST_ON
                        LitAlphaClip(IN);                  // _core/CoreSurface.hlsl
                    #endif
                    return 0;
                }
            ENDHLSL
        }
    }
}
