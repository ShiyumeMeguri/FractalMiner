// HGRP LitForward (forward-rendered PBR lit surface) -> URP. Passes: ForwardLit + DepthOnly + DepthNormalsOnly + ShadowCaster.
// Merged from: litforward.shader base variant (catch-all #else): Vertex b8, Fragment b9, DepthOnly b26/b27, ShadowCaster b32/b33.
//   (All under .../runtime/shaders/materials/lit/litforward/ — the ForwardOnly forward path of the HGRP Lit family.)
// Keywords: _TWO_BASEMAP, _RECEIVE_LOCAL_LIGHT_SHADOW, _EMISSIVE_MASK, _CUSTOM_IBL, _LAYERBLEND_MASK, _THIN_FILM, _PLANAR_REFLECTION, _ALPHATEST_ON (URP shadow/depth alpha-clip).
// Kept (1:1 from b9): BaseColor tint-cover + brighter-scale, _BaseTextureMapCount metallic-from-map vs slider, RoughnessMin/Max remap,
//   DXT5nm-style normal unpack (x*w*2-1, y*2-1)*scale + two-sided sign, TBN world normal, occlusion = lerp(1,mro.b,_OcclusionStrength),
//   F0 = lerp(0.08*_Specular, albedo, metallic), diffuse = albedo*(1-metallic), Cook-Torrance GGX-D + Smith height-correlated Vis +
//   Schlick Fresnel direct light, EnvBRDFApprox DFG poly + 1/21 grazing multiscatter-diffuse energy, ambient-spec env-BRDF (envSpecScale
//   _537 / envSpecBias _3103), VFX color grade (_VFXParams1), opacity = lerp(1, vColor.x, _Use_VerexTexColorAsOpacity).
// Removed (pixel-neutral pipeline infra, substituted by URP per STYLE_BIBLE §2 / CORE_MATH §2.12):
//   GPU skinning (b8:240-442) + octahedral vertex-stream decode (b8:151-220) -> GetVertexPositionInputs/GetVertexNormalInputs;
//   SRP instancing per-draw array -> unity_ObjectToWorld; HG motion-vector dual-frame + SV_Target1 MV/TAAU pack (b9:1333-1339) -> URP MotionVectors pass;
//   IV-clipmap SH cascade T10-T15 (b9:338-577) -> SampleSH(N); reflection-probe binning T0/T1 + box-projection (b9:584-713) -> GlossyEnvironmentReflection;
//   CSM+ASM+cloud shadow atlases T5/T6/T7 (b9:715-937) -> URP main-light shadow; tile/zbin punctual light culling T0 (b9:998-1259) -> GetAdditionalLight loop;
//   atmosphere/exponential/volumetric froxel fog T16 (b9:1262-1327) -> MixFog; light-cookie LUT T17/T8 attenuation ramp.
//
// NOTE: forward-only faithful path (the source ForwardLit pass LIGHTMODE=ForwardOnly -> URP UniversalForwardOnly). The source RayTracingReflection
//   pass is an empty ShaderLab stub (no HLSLPROGRAM) with no URP analog -> DROPPED (STYLE_BIBLE §7). DepthNormalsOnly is added for URP's SSAO/depth-normals
//   prepass (the source DepthOnly writes depth only; its normal needs are served here faithfully via the same b9 TBN unpack).
//   _MROMap channels: R=Metallic, G=Roughness(remapped via Min/Max), B=Occlusion (CORE_MATH §0.3). _NormalMap: X in .a, Y in .g (DXT5nm-like), b9:288-289.
//   _EnvironmentGlobalParams0.x = ambient/diffuse intensity, .y = reflection intensity (HGRP global re-exposed as material Vector; URP has no equivalent — STYLE_BIBLE §1.5).
//   _GraphicsFeaturesGlobalParam0.z = reflection-feature scale on term B (b9:1325 _1669*_GraphicsFeaturesGlobalParam0.z); re-exposed as material Vector (neutral .z=1). Its .w (horizon-occ, b9:669/703) lives inside the dropped probe-binning loop -> subsumed by GlossyEnvironmentReflection.
//
// Keyword-delta closure status (vs delta blobs in litforward/):
//   _CUSTOM_IBL        = CLOSED 1:1 from Sub0_Pass0_Fragment_b17.hlsl:1128 (cube sample, exact 1.2*log2 roughness->mip) + :1132-1134
//                        (reflection term = cube * (F0*envSpecScale+envSpecBias) * _CustomIBLIntensity, replacing GfxFeat.z*EnvParams.y).
//                        Cube mip count re-exposed as _GraphicsFeaturesGlobalParam1.x (HG global, no URP equiv).
//   _PLANAR_REFLECTION = ENGINE-SIDE (legit punt, host system named): in b23 the reflection is a SCREEN-SPACE RT lookup — ByteAddressBuffer T0
//                        (b23:38) read at coords projecting positionWS through host-supplied _FakePlanarReflectionViewProjMatrix (cbuffer c244,
//                        b23:369-372 -> _643/_644 screen UV via _ScreenSize, _646 depth via _ZBufferParams), gated by _GraphicsFeaturesGlobalParam1.y
//                        (b23:372 _552). Requires a host ScriptableRendererFeature to render+bind the planar RT + VP matrix; URP
//                        GlossyEnvironmentReflection samples cube probes only, never a screen-space RT. No material texture/formula can stand in.
//   _EMISSIVE_MASK     = NO-EMISSIVE-TEXTURE-IN-ANY-BLOB (the directive's "_EmissiveMap sample" path does not exist in this shader's HLSL): b15/b17
//                        sample the IDENTICAL T2/T3/T4 set as base b9 (no _EmissiveMap register) and have NO additive emissive term. `_EnableEmissiveMap`
//                        is NOT constant-folded (earlier note corrected) — it is live as a SCALAR multiplier in the albedo->term-A diffuse path
//                        (b15:1349, b17:1132), entangled with the _LAYERBLEND height-blend AND the DROPPED per-draw array _SRP_UnityPerDraw_*_Float4x5_Param2.
//                        Not isolatable without re-introducing dropped infra + the _LAYERBLEND base-model. Non-1:1 stand-in kept (map*color); see frag note.
//   _TWO_BASEMAP / _RECEIVE_LOCAL_LIGHT_SHADOW / _LAYERBLEND_MASK / _THIN_FILM = exposed but NOT 1:1-closeable WITHOUT regressing the base path:
//                        each carries real material-texture deltas, but on a DIFFERENT base-surface texture model than b9 — verified by blob:
//                          • _TWO_BASEMAP (b11) / _RECEIVE_LOCAL_LIGHT_SHADOW (b13): compiled with SRP_INSTANCING_ON, so ALL material params are an
//                            instanced array `CB2_m0[...]` (b11:265, b13:322) not named uniforms; the 2nd-basemap / local-light-shadow-atlas logic
//                            lives in the dropped instancing + local-light atlas infra (STYLE_BIBLE §2). No isolatable additive material delta on b9.
//                          • _LAYERBLEND_MASK (b19): packs base metallic in baseColor.a (_258=_253.w, b19:303), roughness in normal.b (_622<-_287.z,
//                            b19:357), occlusion in normal.a (_3321<-_287.w, b19:1315), and frees T4 to be the blend MASK (_414, b19:325) — NO MRO map at
//                            all. b9's base path uses a dedicated _MROMap (R/G/B = M/R/O). The blend KERNEL itself (albedo _583..585 b19:352-354 / metallic
//                            _610 b19:356 / roughness _625 b19:358 / normal _508/_509/_685 b19:341-359 lerp'd by height factor _468 b19:336) IS material-
//                            side; but a faithful 1:1 close is blocked by THREE things, not one: (1) it forces #ifdef-branching BuildLitSurface's base M/R/O
//                            sourcing off the byte-identical b9 path the spec forbids regressing; (2) the 2nd-layer UV (_367/_368 b19:317-318) is selected
//                            from the DROPPED packed constant pool `_115[_338/_345/_355]` (the _LayerBlendUVType UV0/WorldXZ/UV2 matrix) whose slice is not
//                            recoverable from these blobs without fabrication; (3) the blend normal (_692..694 b19:360-362) is interwoven with the dropped
//                            instancing + LOD-fade dither (_713<-UnityPerDrawArray.unity_LODFade b19:368) + planar screen-space (_FakePlanarReflectionViewProjMatrix
//                            b19:387-390) + IV-clipmap (_IVParam0/2 b19:394-395) infra. A partial port omitting (2)/(3) would be non-1:1 — left exposed-but-unported.
//                          • _THIN_FILM (b21): same packed base model (roughness _582<-_320.z). Its iridescence LUT (T7, b21:360) + thin-film normal
//                            (T6, b21:350) feed BOTH an albedo-replace (b21:373-381 _ThinFilmAffectBaseColor) and an additive-emissive (b21:1266
//                            _ThinFilmAffectEmissive) term off the same _776; the two are inseparable and the LUT-input normal is built on b21's distinct
//                            normal pipeline. A partial (emissive-only) port would be non-1:1 — so left exposed-but-unported rather than mislabeled-closed.

Shader "HGRP/LitForward_Fix" {
    Properties {
        // ---- Blend-state plumbing (set by CustomEditor / presets via _SurfaceType; opaque defaults) ----
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _Cull ("Render Face", Float) = 2
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 0
        [HideInInspector] _ZTestGBuffer ("__ztGBuffer", Float) = 3
        [HideInInspector] _PreDepthStencilRef ("Pre-Depth Stencil Ref", Float) = 5

        // ---- Core surface / base PBR (always-on, b9:97-123 material cbuffer) ----
        [Enum(Three, 0, Two, 1, TwoWithNoMetallic, 2)] _BaseTextureMapCount ("Base Texture Map Count", Float) = 0
        _BaseColorMap ("Base Color Map", 2D) = "white" {}
        [Enum(UV0, 0, UV1, 1)] _BaseUVSet ("Base UV Set", Float) = 0
        _BaseColor ("Base Color", Color) = (1, 1, 1, 1)
        _BaseColorTintCover ("Base Color Tint Cover", Range(0, 1)) = 0
        _BaseColorBrighterScale ("Base Color Brighter Scale", Range(1, 2)) = 1
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _MROMap ("MRO Map (R Metallic, G Roughness, B Occlusion)", 2D) = "white" {}
        [Enum(UV0, 0, UV1, 1)] _BasePbrMapUVSet ("PBR Map UV Set", Float) = 0
        _NormalScale ("Normal Scale", Range(0, 2)) = 1
        [ToggleUI] _TwoSidedNormal ("Two Sided Normal", Float) = 1
        _Metallic ("Metallic", Range(0, 1)) = 0
        _Specular ("Specular", Range(0, 1)) = 0.5
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1
        _OcclusionStrength ("Occlusion Strength", Range(0, 1)) = 1
        [Toggle(_TWO_BASEMAP)] _UseTwoBaseMap ("Two BaseMap (keyword)", Float) = 0
        [HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}

        // ---- Alpha test (URP shadow/depth clip; transparent opacity gate) ----
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Enable Alpha Test", Float) = 0
        _AlphaClipThreshold ("Alpha Clip Threshold", Range(0, 1)) = 0.5
        [ToggleUI] _Use_VerexTexColorAsOpacity ("Use Vertex Color As Opacity", Float) = 0

        // ---- VFX color adjustment (HGRP global re-exposed; b9:1330-1332 _VFXParams1) ----
        [Header(VFX Color Adjustment)]
        _VFXParams1 ("VFX Params1 (.xyz=tint, .w=saturation)", Vector) = (1, 1, 1, 1)

        // ---- Keyword-gated feature toggles (delta blobs read: _CUSTOM_IBL closed from b17; _PLANAR_REFLECTION engine-side; _EMISSIVE_MASK folded-out in blob -> see header status) ----
        [Header(Optional Features)]
        [Toggle(_EMISSIVE_MASK)] _EnableEmissiveMap ("Enable Emissive (keyword)", Float) = 0
        _EmissiveMap ("Emissive Map", 2D) = "black" {}
        [HDR] _EmissiveColor ("Emissive Color", Color) = (0, 0, 0, 1)
        [Toggle(_CUSTOM_IBL)] _EnabledCustomIBL ("Enabled Custom IBL (keyword)", Float) = 0
        _CustomIBL ("Custom IBL", Cube) = "black" {}
        _CustomIBLIntensity ("Custom IBL Intensity", Range(0, 3)) = 1
        [Toggle(_THIN_FILM)] _EnableThinFilmInterference ("Enable Thin Film (keyword)", Float) = 0
        [Toggle(_PLANAR_REFLECTION)] _EnabledPlanarReflection ("Enabled Planar Reflection (keyword)", Float) = 0
        [HDR] _PlanarReflectionTint ("Planar Reflection Tint", Color) = (1, 1, 1, 1)
        [Toggle(_LAYERBLEND_MASK)] _LayerBlend ("Layer Blend Mask (keyword)", Float) = 0
        [Toggle(_RECEIVE_LOCAL_LIGHT_SHADOW)] _ReceiveLocalLightShadow ("Receive Local Light Shadow (keyword)", Float) = 0

        // ---- Environment params (HGRP globals re-exposed as material Vectors — STYLE_BIBLE §1.5/§2) ----
        [Header(Environment Params)]
        _EnvironmentGlobalParams0 ("EnvGlobalParams0 (.x=ambient intensity .y=reflection intensity)", Vector) = (1, 1, 1, 0)
        _GraphicsFeaturesGlobalParam0 ("GfxFeatures0 (.z=reflection feature scale .w=horizon occ)", Vector) = (0, 0, 1, 1)
        _GraphicsFeaturesGlobalParam1 ("GfxFeatures1 (.x=custom-IBL cube mip count)", Vector) = (7, 0, 0, 0)
        _ExposureParams ("ExposureParams (.x=exposure)", Vector) = (1, 0, 0, 0)
    }

    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Opaque" }
        LOD 600

        HLSLINCLUDE
            // ============================================================
            // URP infrastructure (substitutes for all HGRP hand-rolled globals — STYLE_BIBLE §2)
            //   Core.hlsl    -> UNITY_MATRIX_*, _WorldSpaceCameraPos, unity_ObjectToWorld, unity_OrthoParams,
            //                   GetVertexPositionInputs/GetVertexNormalInputs, TransformWorldToHClip, MixFog, fog factor.
            //   Lighting.hlsl-> GetMainLight/GetAdditionalLight, Light, SampleSH, GlossyEnvironmentReflection,
            //                   TransformWorldToShadowCoord, shadow keywords/macros.
            // ============================================================
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"

            // ============================================================
            // UnityPerMaterial — every uniform the base b9 fragment reads (b9:97-123), de-packoffset'd.
            //   _BaseColorMap_ST / _NormalMap_ST added (source `_BaseColorMap` 2D -> URP needs the _ST float4 for tiling).
            // ============================================================
            CBUFFER_START(UnityPerMaterial)
                float4 _BaseColor;            // b9:115
                float4 _BaseColorMap_ST;      // b9:116 (_BaseColorMap_ST)
                float4 _NormalMap_ST;         // b9:117 (also tiles _MROMap — b9 uses _NormalMap_ST for both PBR maps, _242/_243)
                float  _BaseTextureMapCount;  // b9:110
                float  _BaseUVSet;            // b9:107
                float  _BasePbrMapUVSet;      // b9:108
                float  _BaseColorTintCover;   // b9:111
                float  _BaseColorBrighterScale; // b9:113
                float  _NormalScale;          // b9:99
                float  _TwoSidedNormal;       // b9:104
                float  _Metallic;             // b9:112
                float  _Specular;             // b9:100
                float  _RoughnessMin;         // b9:101
                float  _RoughnessMax;         // b9:102
                float  _OcclusionStrength;    // b9:103
                float  _TAAUNormalBiasReverse;// b9:109
                float  _Use_VerexTexColorAsOpacity; // b9:119
                float  _SurfaceType;
                float  _Cull;
                float  _AlphaClipThreshold;
                float4 _EmissiveColor;
                float4 _PlanarReflectionTint;
                float  _CustomIBLIntensity;
                // HGRP globals re-exposed as material Vectors (URP has no equivalent global — STYLE_BIBLE §1.5):
                float4 _VFXParams1;               // b9:81 -> _3900..3902 color grade
                float4 _EnvironmentGlobalParams0; // b9:56 -> .x ambient, .y reflection intensity (b9:1325)
                float4 _GraphicsFeaturesGlobalParam0; // b9:57 (c112) -> .z reflection-feature scale on term B (b9:1325 _GraphicsFeaturesGlobalParam0.z)
                float4 _GraphicsFeaturesGlobalParam1; // b17:46 (c113) -> .x = custom-IBL cube mip count (b17:1128 reflection-mip base; same curve b9:583, b21:1201); URP has no equivalent global (STYLE_BIBLE §1.5/§2)
                float4 _ExposureParams;           // b9:54 (post-exposure; informational)
            CBUFFER_END

            // ============================================================
            // Textures (each b9 `Tn` re-identified by sample site — CORE_MATH §0.3).
            //   T2 (b9:286) = _BaseColorMap ; T3 (b9:287) = _NormalMap ; T4 (b9:292) = _MROMap.
            //   Wrap modes from b9 inline samplers: base=mirror, normal=clamp, MRO=repeat (CORE_MATH §0.3) -> use per-texture SAMPLER.
            // ============================================================
            TEXTURE2D(_BaseColorMap);  SAMPLER(sampler_BaseColorMap);
            TEXTURE2D(_NormalMap);     SAMPLER(sampler_NormalMap);
            TEXTURE2D(_MROMap);        SAMPLER(sampler_MROMap);
            TEXTURE2D(_EmissiveMap);   SAMPLER(sampler_EmissiveMap);
            TEXTURECUBE(_CustomIBL);   SAMPLER(sampler_CustomIBL);

            // ============================================================
            // §0.4 Decoded magic-constant table (denormalized-float bit patterns -> real values),
            //      as spelled in b9. Algorithm boundaries (epsilons / luma / grazing floor / dielectric F0) — kept EXACT.
            // ============================================================
            static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709 luma, b9:1328
            static const float  HGRP_EPS_VIEWLEN  = 9.9999999392252902907785028219223e-09; // = 1e-8 ; rsqrt/denominator guard, b9:277
            static const float  HGRP_EPS_NORMAL_Z = 1.000000016862383526387164645044e-16;  // = 1e-16 ; derived-normal Z floor, b9:441
            static const float  HGRP_EPS_VIS      = 9.9999997473787516355514526367188e-05;  // = 1e-4  ; Smith-visibility denominator floor, b9:981
            static const float  HGRP_DIELECTRIC_F0= 0.07999999821186065673828125;           // = 0.08  ; dielectric F0 base = 0.08*_Specular, b9:318
            static const float  HGRP_GRAZING_FLOOR= 0.0476190485060214996337890625;         // = 1/21  ; multiscatter-diffuse grazing floor lerp(F0,1,1/21), b9:977

            // ------------------------------------------------------------
            // LitSurface — resolved surface for the lit composite.
            // ------------------------------------------------------------
            struct LitSurface
            {
                float3 albedo;     // tint-covered base color (b9:339-341, _339..341)
                float3 normalWS;   // world normal (b9:455-457)
                float3 f0;         // lerp(0.08*_Specular, albedo, metallic) (b9:514-516)
                float  metallic;   // b9:372 (_372)
                float  roughness;  // linear/perceptual roughness lerp(RoughMin,RoughMax,mro.g) (b9:301, _361)
                float  occlusion;  // lerp(1, mro.b, _OcclusionStrength) (b9:1260, _3084)
                float  alpha;      // opacity (b9:300, _349)
                float3 emission;   // base variant = 0 (emissive is _EMISSIVE_MASK-gated)
            };

            // ============================================================
            // §2.2 Surface assembly — UV-set lerp, sample 3 maps, normal unpack, TBN, albedo, PBR split.
            //   1:1 from b9:282-372,441-457. mipBias _GlobalMipBias -> 0 (URP applies its own global mip bias).
            //   faceSign: HG uses gl_FrontFacing ? +1 : (_TwoSidedNormal>0 ? -1 : +1) (b9:303). isFrontFace passed in.
            //   bitSign: tangent.w sign (b9:271 _147; here tangentWS.w already carries oddNegativeScale*tangentOS.w).
            // ============================================================
            LitSurface BuildLitSurface(float2 uv0, float2 uv1, float3 normalWS, float4 tangentWS, float4 vertexColor, bool isFrontFace)
            {
                LitSurface s = (LitSurface)0;

                // UV-set select then *ST (b9:282-285): lerp(uv0,uv1,_UVSet) via mad(mad(uvSet, uv1-uv0, uv0), ST.xy, ST.zw).
                float2 duv = uv1 - uv0;                                                                  // b9:282-283 (_222,_223)
                float2 uvBase = float2(mad(mad(_BaseUVSet, duv.x, uv0.x), _BaseColorMap_ST.x, _BaseColorMap_ST.z),
                                       mad(mad(_BaseUVSet, duv.y, uv0.y), _BaseColorMap_ST.y, _BaseColorMap_ST.w)); // b9:286
                float2 uvPbr  = float2(mad(mad(_BasePbrMapUVSet, duv.x, uv0.x), _NormalMap_ST.x, _NormalMap_ST.z),
                                       mad(mad(_BasePbrMapUVSet, duv.y, uv0.y), _NormalMap_ST.y, _NormalMap_ST.w)); // b9:284-285 (_242,_243)

                float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uvBase);          // b9:286 (_270)
                float4 nrm     = SAMPLE_TEXTURE2D(_NormalMap,    sampler_NormalMap,    uvPbr);           // b9:287 (_283)
                float4 mro     = SAMPLE_TEXTURE2D(_MROMap,       sampler_MROMap,       uvPbr);           // b9:292 (_301)

                // Normal unpack (DXT5nm-like) — b9:288-291. RAW xy (_289,_291) feed nz; SCALED xy (_295,_296) feed TBN.
                float nxRaw = mad(nrm.x * nrm.w, 2.0, -1.0);                                              // b9:288 (_289)
                float nyRaw = mad(nrm.y,         2.0, -1.0);                                              // b9:289 (_291)
                float nx = nxRaw * _NormalScale;                                                         // b9:290 (_295)
                float ny = nyRaw * _NormalScale;                                                         // b9:291 (_296)

                // Albedo: saturate(base*_BaseColor*_BaseColorBrighterScale) then tint-cover toward flat _BaseColor — b9:294-299.
                float3 albedoRaw = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale);     // b9:294-296 (_322..324)
                s.albedo = lerp(albedoRaw, _BaseColor.rgb, _BaseColorTintCover);                         // b9:297-299 (_339..341)

                s.alpha     = mad(_Use_VerexTexColorAsOpacity, vertexColor.x - 1.0, 1.0);                // b9:300 (_349)
                s.roughness = mad(mro.y, _RoughnessMax - _RoughnessMin, _RoughnessMin);                  // b9:301 (_361) linear roughness
                s.metallic  = mad(saturate(_BaseTextureMapCount - 1.0), _Metallic - mro.x, mro.x);       // b9:302 (_372)

                // Two-sided / front-face sign on the derived tangent-space Z (b9:303 _441).
                //   nz is derived from the RAW (pre-NormalScale) xy — b9:303 uses dot(_289,_291), NOT the scaled _295,_296.
                float faceSign = isFrontFace ? 1.0 : (_TwoSidedNormal > 0.0 ? -1.0 : 1.0);               // b9:303 sign term
                float nz = max(sqrt(1.0 - min(dot(float2(nxRaw, nyRaw), float2(nxRaw, nyRaw)), 1.0)), HGRP_EPS_NORMAL_Z) * faceSign; // b9:303 (_441)

                // World normal via TBN: N*nz + T*nx + (bitSign*cross(N,T))*ny, then normalize (b9:304-310).
                float3 N = normalWS;
                float3 T = tangentWS.xyz;
                float  bitSign = tangentWS.w;                                                            // carries oddNegativeScale*tangentOS.w (b9:271 _147)
                float3 B = bitSign * cross(N, T);
                s.normalWS = normalize(N * nz + T * nx + B * ny);                                        // b9:304-310 (_448..457)

                // PBR diffuse/specular split (b9:318-325).
                float dielF0 = HGRP_DIELECTRIC_F0 * _Specular;                                           // b9:318 (_504)
                s.f0 = lerp(dielF0.xxx, s.albedo, s.metallic);                                           // b9:322-325 (_513..516)

                s.occlusion = mad(_OcclusionStrength, mro.z - 1.0, 1.0);                                 // b9:1260 (_3084) = lerp(1,mro.b,strength)

                // Base variant: no emissive (gated _EMISSIVE_MASK).
                s.emission = float3(0.0, 0.0, 0.0);
            #ifdef _EMISSIVE_MASK
                // TODO(1:1, NO-EMISSIVE-TEXTURE-IN-ANY-BLOB): there is NO `_EmissiveMap` sample (or any additive emissive term) in any
                //   litforward fragment blob, so the directive's "_EMISSIVE_MASK = sample _EmissiveMap + channel-select + color/anim" path
                //   simply does not exist in this shader's compiled HLSL. Blob evidence (corrects the earlier "constant-folded to NO-OP" note,
                //   which was wrong — `_EnableEmissiveMap` is NOT folded out, it is live):
                //     - b15 & b17 sample the IDENTICAL material-texture set as base b9 — T2 base, T3 normal, T4 MRO, exactly 1×1×1
                //       (grep `T[0-9]+\.Sample` counts equal b9's; T5-T17 are all HG infra: shadow/IV-SH/fog/cookie). No `_EmissiveMap` register.
                //     - `_EnableEmissiveMap` survives only as a SCALAR MULTIPLIER inside the albedo->term-A diffuse path, e.g. b15:1349 / b17:1132
                //       `(_albedoTint * (_layerHeightTrans * mad(_SRP_UnityPerDraw...Float4x5_Param2.w, …_PlanarReflectionTint…, …)) * _EnableEmissiveMap)`.
                //       It is entangled with (a) the _LAYERBLEND height-blend (`_LayerBlendHeightTransition`, `_344/_359`) and (b) the DROPPED
                //       per-draw instanced array `_SRP_UnityPerDraw_UnityPerDrawArray[...]_Float4x5_Param2` (STYLE_BIBLE §2 infra). It is a layer-
                //       emissive-brightness gate, NOT a texture-sampled additive emissive — and it cannot be isolated without re-introducing the
                //       dropped per-draw infra and the _LAYERBLEND base-model (which uses a different M/R/O packing than the b9 base path — see below).
                //   Hence no 1:1 emissive math is recoverable here. The line below is a plausible NON-blob-verified stand-in (emissive map * color)
                //   kept only to keep the keyword + `_EmissiveMap`/`_EmissiveColor` properties wired; it is NOT 1:1. Exact parity would require an
                //   HGRP variant whose cbuffer carries `_EmissiveColor`/`_EmissiveMaskChannel`/`_EmissiveType`/`_EmissiveSpeed` un-folded (source
                //   litforward.shader:69-88) and an actual emissive texture sample — none exists in litforward/Sub0_Pass0_Fragment_b{11,13,15,17,19,21,23}.hlsl.
                s.emission = SAMPLE_TEXTURE2D(_EmissiveMap, sampler_EmissiveMap, uvBase).rgb * _EmissiveColor.rgb;
            #endif
                return s;
            }

            // ============================================================
            // §2.6 Karis analytic ENVIRONMENT-BRDF / horizon energy (b9:326-329,1261). Gates the ambient reflection.
            //   envF        (_536) = min((1-r)^2, exp2(-9.28*NoV))*(1-r) + (r*-0.0275 + 0.0425)
            //   envSpecScale(_537) = envF*-1.04 + (r*-0.572 + 1.04)
            //   envSpecBias (_3103)= (envF*1.04 + (r*0.022 - 0.04)) * saturate(F0.g*50)
            //   applied (b9:1325) = reflection * (F0*envSpecScale + envSpecBias).  Poly coeffs LOAD-BEARING — exact.
            // ============================================================
            void HgEnvBRDF(float roughness, float NoV, float3 f0, out float envSpecScale, out float envSpecBias)
            {
                float oneMinusRough = mad(roughness, -1.0, 1.0);                                          // b9:326 (_520)
                float envF = mad(min(oneMinusRough * oneMinusRough, exp2(NoV * -9.27999973297119140625)),
                                 oneMinusRough,
                                 mad(roughness, -0.0274999998509883880615234375, 0.0425000004470348358154296875)); // b9:328 (_536)
                envSpecScale = mad(envF, -1.03999996185302734375,
                                   mad(roughness, -0.572000026702880859375, 1.03999996185302734375));     // b9:329 (_537)
                envSpecBias  = mad(envF, 1.03999996185302734375,
                                   mad(roughness, 0.02199999988079071044921875, -0.039999999105930328369140625))
                             * saturate(f0.g * 50.0);                                                      // b9:1261 (_3103)
            }

            // ============================================================
            // §2.6 EnvBRDFApprox rational DFG scale (b9:975 _2183) — Karis/Lazarov polynomial in perceptual roughness,
            //   feeds the direct-light multiscatter-diffuse energy. Coeffs 1:1 load-bearing.
            //     dfg = min( t*(t*((-t)*0.38302600 - 0.07619470) + 1.04997003) + 0.40925499, 0.999 ), t = 1-roughness
            //   HG additionally multiplies by a 2D split-sum DFG LUT product T9(NoV)*T9(NoL) (b9:982 _2240); T9 is engine
            //   infra with no URP binding -> the analytic dfg is its sanctioned substitute (CORE_MATH §2.6/§2.12).
            // ============================================================
            float HgEnvBRDFApproxDFG(float roughness)
            {
                float t = mad(roughness, -1.0, 1.0);                                                       // b9:974 (_2174)
                return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875, -0.076194703578948974609375),
                                      1.04997003078460693359375),
                               0.4092549979686737060546875),
                           0.999000012874603271484375);                                                    // b9:975 (_2183)
            }

            // ============================================================
            // §2.7/§2.8 Analytic-light specular: Cook-Torrance GGX-D + Smith height-correlated Vis + Schlick F (b9:964-983).
            //   Shared by main directional light (§2.7) and additional lights (§2.8) — punctual loop re-derives identical D/Vis/F (b9:1220-1234).
            //   a=r^2 ; a2=a*a ; nv=min(NoV,1) ; d=(NoH*a2-NoH)*NoH+1 ; D=a2/(d*d) ;
            //   Vis=0.5/(nv*sqrt((-NoL*a2+NoL)*NoL+a2) + NoL*sqrt((-nv*a2+nv)*nv+a2) + 1e-4) ;
            //   Fc=(1-VoH)^5 ; F=lerp(F0,1,Fc).  Returns specular RGB (NOT yet *NoL).
            // ============================================================
            float3 HgDirectSpecular(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float a  = roughness * roughness;                                                          // b9:967 (_2159)
                float a2 = a * a;                                                                          // b9:968 (_2160)
                float nv = min(NoV, 1.0);                                                                  // b9:966 (_2158)

                float d = mad(mad(NoH, a2, -NoH), NoH, 1.0);                                               // b9:969 (_2163)
                float visDenom = nv  * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2))                              // b9:981 lambdaV
                               + NoL * sqrt(mad(mad(-nv,  a2, nv ), nv , a2))                              // b9:981 lambdaL
                               + HGRP_EPS_VIS;
                float DV = (a2 / (d * d)) * (0.5 / visDenom);                                              // b9:981 (_2217) = D*Vis

                float oneMinusVoH = mad(-VoH, 1.0, 1.0);                                                   // b9:970 (_2169)
                float sq   = oneMinusVoH * oneMinusVoH;                                                    // b9:971 (_2170)
                float quad = sq * sq;                                                                      // b9:972 (_2171)
                float Fc   = oneMinusVoH * quad;                                                           // b9:973 (_2172) = (1-VoH)^5
                float oneMinusFc = mad(-quad, oneMinusVoH, 1.0);                                           // b9:980 (_2198)
                float3 F = mad(f0, oneMinusFc.xxx, Fc.xxx);                                                // b9:983 lerp(F0,1,Fc)

                return DV * F;
            }

            // ============================================================
            // §2.7/§2.8 Full per-light energy bracket (b9:983 _2283/_2284/_2285; re-derived per light b9:1232-1234):
            //   gz = lerp(F0,1,1/21) (b9:977 _2193) ; dfg = HgEnvBRDFApproxDFG (T9-product substitute) ;
            //   msDiff = (dfg/(1-dfg) * gz^2) / (1 - gz*(1-dfg))  per channel ;
            //   energy = min(max(msDiff + min((D*Vis)*F, 2048), 0), 1000).
            //   The Lambert diffuse base (diffuse*NoL) is ADDED at the call site (b9:983 `+ _509*_2153`).
            //   HG per-light scale (_LightData[4].x) is folded into URP lightColor -> pass nothing here.
            // ============================================================
            float3 HgDirectLightEnergy(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float3 specE = HgDirectSpecular(roughness, f0, NoL, NoH, NoV, VoH);                        // b9:981·983 (D*Vis*F)
                float  dfg = HgEnvBRDFApproxDFG(roughness);                                                // b9:975 (_2183)
                float  oneMinusDfg = mad(-dfg, 1.0, 1.0);                                                  // b9:976 (_2186)
                float  dfgEnergy = dfg / oneMinusDfg;                                                      // b9:982 (_2240) T9-product -> analytic dfg
                float3 gz = mad((float3(1.0, 1.0, 1.0) - f0), HGRP_GRAZING_FLOOR, f0);                     // b9:977-979 (_2193..) lerp(F0,1,1/21)
                float3 msDiff = (dfgEnergy * (gz * gz)) / mad(-gz, oneMinusDfg, float3(1.0, 1.0, 1.0));    // b9:983 term A
                return min(max(msDiff + min(specE, 2048.0), 0.0), 1000.0);                                 // b9:983 clamp
            }

            // ============================================================
            // §2.2 View dir V (world). perspective = normalize(camPos - P) ; ortho = -camera forward (b9:271-281).
            //   URP: unity_OrthoParams.w ortho flag ; ortho fwd = -UNITY_MATRIX_V row2 (_m20/_m21/_m22) (STYLE_BIBLE §2).
            // ============================================================
            float3 HgViewDirWS(float3 positionWS)
            {
                float3 viewRaw = (unity_OrthoParams.w == 0.0)
                               ? (_WorldSpaceCameraPos - positionWS)                                       // b9:273-275 perspective
                               : -float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22);   // b9:273-275 ortho (-ViewMatrix col2)
                float distSq = dot(viewRaw, viewRaw);                                                      // b9:276 (_201)
                float invLen = rsqrt(max(distSq, HGRP_EPS_VIEWLEN));                                       // b9:277 (_207)
                return viewRaw * invLen;                                                                   // b9:278-280 (_208..210)
            }

            // ============================================================
            // Final ForwardLit composite (b9:1325-1343 with HG infra -> URP):
            //   color = diffuse*SH(N)*occ*envParams.x  +  reflection*(F0*envSpecScale + envSpecBias)*envParams.y
            //         + mainLight(GGX,§2.7)  +  addLights(§2.8)  +  emission ;
            //   color = MixFog(color, fogFactor) ;  out = half4(graded color, alpha).
            //   VFX grade (b9:1330-1332): lerp(luma, color, _VFXParams1.w) * _VFXParams1.xyz.
            // ============================================================
            half4 LitForwardComposite(LitSurface s, float3 positionWS, float fogFactor)
            {
                float3 N = s.normalWS;
                float3 V = HgViewDirWS(positionWS);                                                        // §2.2
                float3 diffuse = s.albedo * (1.0 - s.metallic);                                            // b9:319-321 (_509..511)

                float NoV = max(dot(N, V), 0.0);                                                           // b9:327 (_531)

                float envSpecScale, envSpecBias;
                HgEnvBRDF(s.roughness, NoV, s.f0, envSpecScale, envSpecBias);                              // §2.6, b9:326-329,1261

                // §2.4 ambient diffuse: HG IV-clipmap SH cascade -> URP SampleSH(N) (b9:575-577 project SH onto N).
                float3 ambientSH = SampleSH(N);
                // §2.5 specular reflection: HG probe-binning atlas -> URP GlossyEnvironmentReflection.
                //   s.roughness IS perceptual (HG _361; GGX squares it). Feed URP its perceptualRoughness directly.
                //   occlusion arg = 1.0: HG term B (b9:1325 _1669) does NOT apply AO to the reflection.
                float  perceptualRoughness = saturate(s.roughness);
                float3 reflectVec = reflect(-V, N);                                                        // b9:579-582 (_987=-2NoV, _991..993) = 2*NoV*N - V (== b17:574-578 _1018/_1022..1024)
                // Shared split-sum DFG bracket applied to the reflection (b9:1325 mad(_514,_537,_3103) ; b17:1132 mad(_561,_584,_2615)).
                float3 reflectionDFG = s.f0 * envSpecScale + envSpecBias;
            #if defined(_CUSTOM_IBL)
                // 1:1, source = litforward/Sub0_Pass0_Fragment_b17.hlsl:1128 (cube sample) + :1132-1134 (reflection term).
                //   Cube reflection mip (b17:1128 inline, same curve b9:583 _1005 / b21:1201): mip = (mipCount-1) - (1.0 - 1.2*log2(max(perceptualRoughness, 0.001))).
                //   mipCount = _GraphicsFeaturesGlobalParam1.x (HG global re-exposed; STYLE_BIBLE §2). 0.001 floor & 1.2 slope LOAD-BEARING.
                float  customMip = ((-1.0) + _GraphicsFeaturesGlobalParam1.x)
                                 - mad(-log2(max(perceptualRoughness, 0.001000000047497451305389404296875)), 1.2000000476837158203125, 1.0); // b17:1128 (inline mip of _2607 cube sample)
                float3 reflection = SAMPLE_TEXTURECUBE_LOD(_CustomIBL, sampler_CustomIBL, reflectVec, customMip).rgb; // b17:1128 (_2607.xyz)
                // b17:1132-1134: reflection term = cube * (F0*envSpecScale+envSpecBias) * _CustomIBLIntensity (NO GfxFeat.z / EnvParams.y).
                float3 reflectionTerm = reflection * reflectionDFG * _CustomIBLIntensity;
            #else
                float3 reflection = GlossyEnvironmentReflection(reflectVec, perceptualRoughness, 1.0);
                // b9:1325 term B: (reflection * GfxFeat.z) * (F0*envSpecScale+envSpecBias) * EnvParams.y (_1669*_GraphicsFeaturesGlobalParam0.z).
                float3 reflectionTerm = (reflection * _GraphicsFeaturesGlobalParam0.z) * reflectionDFG * _EnvironmentGlobalParams0.y;
            #endif
            #if defined(_PLANAR_REFLECTION)
                // TODO(1:1, ENGINE-SIDE — host system named): _PLANAR_REFLECTION needs a host C# ScriptableRendererFeature that renders a planar
                //   reflection RT and binds two HGRP globals URP has no equivalent for: (1) the screen-space reflection/probe atlas `ByteAddressBuffer T0`
                //   (b23:38 — the t0/t1 binning buffer this port already replaced with GlossyEnvironmentReflection), and (2) the planar VP matrix
                //   `_FakePlanarReflectionViewProjMatrix` (b23 cbuffer c244). At b23:369-372 the reflection lookup projects positionWS (TEXCOORD) through
                //   that VP to a screen UV `_643=clamp(...)*_ScreenSize.x`, `_644=...*_ScreenSize.y` plus linearized depth `_646` (via `_ZBufferParams`),
                //   then reads T0 at those coords — gated by the host "planar active" flag `_552 = (_GraphicsFeaturesGlobalParam1.y == 1.0)`. No material
                //   texture or formula can stand in: it is a screen-space RT lookup whose coordinates only the host pass can produce. URP
                //   GlossyEnvironmentReflection samples CUBE probes only, never a screen-space planar RT. (b23 also folds _PlanarReflectionTint to
                //   identity 1,1,1,1, so the kept tint multiply below is a neutral no-op marker, NOT the missing planar sample.)
                reflectionTerm *= _PlanarReflectionTint.rgb;
            #endif

                float3 color = diffuse * ambientSH * s.occlusion * _EnvironmentGlobalParams0.x            // b9:1325 term A
                             + reflectionTerm;                                                            // b9:1325 term B (keyword-selected source/scale)

                // §2.7 main (directional) light: HG CSM/ASM atlas -> URP main-light shadow.
                float4 shadowCoord = TransformWorldToShadowCoord(positionWS);
                Light mainLight = GetMainLight(shadowCoord, positionWS, half4(1, 1, 1, 1));
                {
                    float3 L = mainLight.direction;                                                       // b9:944 (-_LightData[0])
                    float3 H = normalize(L + V);                                                          // b9:957-963 (_2139..2149)
                    float NoL = saturate(dot(L, N));                                                      // b9:964 (_2153)
                    float NoH = saturate(dot(N, H));                                                      // b9:965 (_2157)
                    float VoH = saturate(dot(V, H));                                                      // b9:970 base
                    float3 energy = HgDirectLightEnergy(s.roughness, s.f0, NoL, NoH, NoV, VoH);           // §2.7 (b9:975-983)
                    float  atten  = mainLight.distanceAttenuation * mainLight.shadowAttenuation;           // -> _1897, b9:938
                    color += mad(energy, NoL.xxx, diffuse * NoL) * (atten * mainLight.color);             // b9:983 mad(energy,NoL, diffuse*NoL)*lightColor
                }

                // §2.8 additional (punctual) lights: HG tile/zbin culling -> URP GetAdditionalLight loop, same BRDF (b9:1228-1234).
            #if defined(_ADDITIONAL_LIGHTS)
                uint addCount = GetAdditionalLightsCount();
                for (uint li = 0u; li < addCount; ++li)
                {
                    Light light = GetAdditionalLight(li, positionWS, half4(1, 1, 1, 1));
                    float3 L = light.direction;
                    float3 H = normalize(L + V);
                    float NoL = saturate(dot(L, N));
                    float NoH = saturate(dot(N, H));
                    float VoH = saturate(dot(V, H));
                    float3 energy = HgDirectLightEnergy(s.roughness, s.f0, NoL, NoH, NoV, VoH);
                    float  atten  = light.distanceAttenuation * light.shadowAttenuation;
                    color += mad(energy, NoL.xxx, diffuse * NoL) * (atten * light.color);
                }
            #endif

                color += s.emission;                                                                      // base = 0 (b9 has no emissive in base)

                // §2.10 fog: HG atmosphere+exp+volumetric (b9:1262-1327) -> URP MixFog.
                color = MixFog(color, fogFactor);

                // VFX color grade (b9:1330-1332): desaturate toward luma then tint.
                float luma = dot(color, LUM);                                                             // b9:1328 (_3881)
                color = lerp(luma.xxx, color, _VFXParams1.w) * _VFXParams1.xyz;                           // b9:1330-1332 (_3900..3902)

                // §2.11 output alpha gated by surface type (b9:1343 _349; STYLE_BIBLE §6).
                float alpha = (_SurfaceType == 1.0) ? s.alpha : 1.0;
                return half4(color, alpha);
            }
        ENDHLSL

        // ================================================================
        // Pass 0: ForwardLit  (source LIGHTMODE=ForwardOnly -> URP UniversalForwardOnly)
        //   Render-state from litforward.shader:120-123 (ZClip On / ZTest [_ZTestGBuffer] / ZWrite [_ZWrite] / Cull [_CullMode]).
        // ================================================================
        Pass {
            Name "ForwardLit"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] OneMinusSrcAlpha
            ZTest LEqual
            ZWrite [_ZWrite]
            Cull [_Cull]
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex vert
                #pragma fragment frag

                // Surface/material feature keywords (litforward.shader:135-141) -> shader_feature.
                #pragma shader_feature_local _TWO_BASEMAP
                #pragma shader_feature_local _RECEIVE_LOCAL_LIGHT_SHADOW
                #pragma shader_feature_local _EMISSIVE_MASK
                #pragma shader_feature_local _CUSTOM_IBL
                #pragma shader_feature_local _LAYERBLEND_MASK
                #pragma shader_feature_local _THIN_FILM
                #pragma shader_feature_local _PLANAR_REFLECTION

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
                    float3 positionWS : TEXCOORD0;
                    float3 normalWS   : TEXCOORD1;
                    float4 tangentWS  : TEXCOORD2;
                    float2 uv0        : TEXCOORD3;
                    float2 uv1        : TEXCOORD4;
                    float4 color      : TEXCOORD5;
                    float  fogFactor  : TEXCOORD6;
                };

                // Vertex: b8:461-532 manual object->world->clip + inverse-transpose normal/tangent -> URP facilities.
                //   (GPU skinning b8:240-442 and octahedral vertex decode b8:151-220 DROPPED — engine infra, CORE_MATH §3.1/§3.2.)
                Varyings vert(Attributes input) {
                    Varyings o = (Varyings)0;
                    VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);                // b8:461-488 (_672..835)
                    VertexNormalInputs   nrmIn = GetVertexNormalInputs(input.normalOS, input.tangentOS);   // b8:504-511 normalize Nw/Tw
                    o.positionCS = posIn.positionCS;
                    o.positionWS = posIn.positionWS;                                                       // -> b9 TEXCOORD (P), b8:501-503
                    o.normalWS   = nrmIn.normalWS;                                                         // -> b9 TEXCOORD_3
                    o.tangentWS  = float4(nrmIn.tangentWS, input.tangentOS.w * GetOddNegativeScale());     // b8:512 tangent.w sign -> b9 TEXCOORD_4.w (_147)
                    o.uv0        = input.uv0;                                                              // b9 TEXCOORD_1
                    o.uv1        = input.uv1;                                                              // b9 TEXCOORD_2
                    o.color      = input.color;                                                            // b9 TEXCOORD_5 (vertex color; .x = opacity)
                    o.fogFactor  = ComputeFogFactor(posIn.positionCS.z);
                    return o;
                }

                half4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target {
                    LitSurface s = BuildLitSurface(input.uv0, input.uv1, normalize(input.normalWS),
                                                   float4(normalize(input.tangentWS.xyz), input.tangentWS.w),
                                                   input.color, isFrontFace);
                #ifdef _ALPHATEST_ON
                    clip(s.alpha - _AlphaClipThreshold);
                #endif
                    return LitForwardComposite(s, input.positionWS, input.fogFactor);
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 1: DepthOnly  (source LIGHTMODE=DepthOnly, litforward.shader:210-223; fragment b27 is EMPTY = pure depth)
        //   Source Stencil Ref [_PreDepthStencilRef] Comp Always Pass Replace preserved.
        // ================================================================
        Pass {
            Name "DepthOnly"
            Tags { "LightMode"="DepthOnly" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_Cull]
            Stencil {
                Ref [_PreDepthStencilRef]
                Comp Always
                Pass Replace
                Fail Keep
                ZFail Keep
            }
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex depthVert
                #pragma fragment depthFrag
                #pragma shader_feature_local _ALPHATEST_ON

                struct DepthAttributes {
                    float3 positionOS : POSITION;
                    float2 uv0        : TEXCOORD0;
                };
                struct DepthVaryings {
                    float4 positionCS : SV_Position;
                    float2 uv         : TEXCOORD0;
                };

                // b26:302-331 object->world->camera clip -> URP TransformObjectToHClip; carry uv only for alpha-clip.
                DepthVaryings depthVert(DepthAttributes input) {
                    DepthVaryings o;
                    o.positionCS = TransformObjectToHClip(input.positionOS);
                    o.uv = input.uv0 * _BaseColorMap_ST.xy + _BaseColorMap_ST.zw;
                    return o;
                }

                // b27 fragment is EMPTY (base = pure depth write). Alpha-clip only under _ALPHATEST_ON (CORE_MATH §4.4).
                half4 depthFrag(DepthVaryings input) : SV_Target {
                #ifdef _ALPHATEST_ON
                    float a = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, input.uv).a * _BaseColor.a;
                    clip(a - _AlphaClipThreshold);
                #endif
                    return 0;
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 2: DepthNormalsOnly  (URP SSAO / depth-normals prepass — substitutes the source DepthOnly's normal need)
        //   Faithful world-normal reconstruction via the same b9 TBN unpack (b9:288-310).
        // ================================================================
        Pass {
            Name "DepthNormalsOnly"
            Tags { "LightMode"="DepthNormalsOnly" }
            ZWrite On
            Cull [_Cull]
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex depthNormalsVert
                #pragma fragment depthNormalsFrag
                #pragma shader_feature_local _ALPHATEST_ON

                struct DNAttributes {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float4 tangentOS  : TANGENT;
                    float2 uv0        : TEXCOORD0;
                    float2 uv1        : TEXCOORD1;
                };
                struct DNVaryings {
                    float4 positionCS : SV_Position;
                    float3 normalWS   : TEXCOORD0;
                    float4 tangentWS  : TEXCOORD1;
                    float2 uv0        : TEXCOORD2;
                    float2 uv1        : TEXCOORD3;
                };

                DNVaryings depthNormalsVert(DNAttributes input) {
                    DNVaryings o = (DNVaryings)0;
                    VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);
                    VertexNormalInputs   nrmIn = GetVertexNormalInputs(input.normalOS, input.tangentOS);
                    o.positionCS = posIn.positionCS;
                    o.normalWS   = nrmIn.normalWS;
                    o.tangentWS  = float4(nrmIn.tangentWS, input.tangentOS.w * GetOddNegativeScale());
                    o.uv0 = input.uv0;
                    o.uv1 = input.uv1;
                    return o;
                }

                half4 depthNormalsFrag(DNVaryings input, bool isFrontFace : SV_IsFrontFace) : SV_Target {
                    // Same UV-set + normal unpack as the forward pass (b9:282-310).
                    float2 duv = input.uv1 - input.uv0;
                    float2 uvPbr = float2(mad(mad(_BasePbrMapUVSet, duv.x, input.uv0.x), _NormalMap_ST.x, _NormalMap_ST.z),
                                          mad(mad(_BasePbrMapUVSet, duv.y, input.uv0.y), _NormalMap_ST.y, _NormalMap_ST.w));
                    float4 nrm = SAMPLE_TEXTURE2D(_NormalMap, sampler_NormalMap, uvPbr);                   // b9:287
                    float nxRaw = mad(nrm.x * nrm.w, 2.0, -1.0);                                          // b9:288 (_289) RAW
                    float nyRaw = mad(nrm.y,         2.0, -1.0);                                          // b9:289 (_291) RAW
                    float nx = nxRaw * _NormalScale;                                                     // b9:290 (_295)
                    float ny = nyRaw * _NormalScale;                                                     // b9:291 (_296)
                    float faceSign = isFrontFace ? 1.0 : (_TwoSidedNormal > 0.0 ? -1.0 : 1.0);            // b9:303
                    float nz = max(sqrt(1.0 - min(dot(float2(nxRaw, nyRaw), float2(nxRaw, nyRaw)), 1.0)), HGRP_EPS_NORMAL_Z) * faceSign; // b9:303 (nz from RAW xy)
                    float3 N = normalize(input.normalWS);
                    float3 T = normalize(input.tangentWS.xyz);
                    float3 B = input.tangentWS.w * cross(N, T);
                    float3 normalWS = normalize(N * nz + T * nx + B * ny);                                // b9:304-310
                #ifdef _ALPHATEST_ON
                    float2 uvBase = float2(mad(mad(_BaseUVSet, duv.x, input.uv0.x), _BaseColorMap_ST.x, _BaseColorMap_ST.z),
                                          mad(mad(_BaseUVSet, duv.y, input.uv0.y), _BaseColorMap_ST.y, _BaseColorMap_ST.w));
                    float a = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uvBase).a * _BaseColor.a;
                    clip(a - _AlphaClipThreshold);
                #endif
                    return half4(NormalizeNormalPerPixel(normalWS), 0.0);
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 3: ShadowCaster  (source LIGHTMODE=SHADOWCASTER, litforward.shader:265-269; fragment b33 EMPTY)
        //   HG bakes depth bias into _ShadowpassVP (b32:325-328); URP's ApplyShadowBias is the faithful substitute (CORE_MATH §4.1).
        // ================================================================
        Pass {
            Name "ShadowCaster"
            Tags { "LightMode"="ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_Cull]
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex shadowVert
                #pragma fragment shadowFrag
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW

                float3 _LightDirection;
                float3 _LightPosition;

                struct ShadowAttributes {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float2 uv0        : TEXCOORD0;
                };
                struct ShadowVaryings {
                    float4 positionCS : SV_Position;
                    float2 uv         : TEXCOORD0;
                };

                ShadowVaryings shadowVert(ShadowAttributes input) {
                    ShadowVaryings o;
                    float3 positionWS = TransformObjectToWorld(input.positionOS);                         // b32:471-473
                    float3 normalWS   = TransformObjectToWorldNormal(input.normalOS);
                    #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                        float3 lightDir = normalize(_LightPosition - positionWS);
                    #else
                        float3 lightDir = _LightDirection;
                    #endif
                    o.positionCS = TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDir));// b32:325-328 (-> shadow clip)
                    #if UNITY_REVERSED_Z
                        o.positionCS.z = min(o.positionCS.z, UNITY_NEAR_CLIP_VALUE);
                    #else
                        o.positionCS.z = max(o.positionCS.z, UNITY_NEAR_CLIP_VALUE);
                    #endif
                    o.uv = input.uv0 * _BaseColorMap_ST.xy + _BaseColorMap_ST.zw;
                    return o;
                }

                // b33 fragment EMPTY (base = depth-only). Alpha-clip only under _ALPHATEST_ON (CORE_MATH §4.2).
                half4 shadowFrag(ShadowVaryings input) : SV_Target {
                #ifdef _ALPHATEST_ON
                    float a = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, input.uv).a * _BaseColor.a;
                    clip(a - _AlphaClipThreshold);
                #endif
                    return 0;
                }
            ENDHLSL
        }

        // ================================================================
        // (Source Pass "RayTracingReflection" LIGHTMODE=RayTracingReflection is an empty ShaderLab stub with no
        //  HLSLPROGRAM and no URP analog -> DROPPED per STYLE_BIBLE §7. Nothing to emit.)
        // ================================================================
    }
}
