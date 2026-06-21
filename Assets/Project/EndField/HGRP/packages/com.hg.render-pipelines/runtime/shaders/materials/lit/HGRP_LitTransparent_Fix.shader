// HGRP LitTransparent (forward PBR glass/transparent surface) -> URP. Passes: ForwardLit (UniversalForwardOnly), ShadowCaster, ForwardReflection (normals-prepass).
// Merged from: littransparent.shader base variants — Sub0_Pass0 Vertex_b23 / Fragment_b24 (ForwardOnly), Sub0_Pass1 Vertex_b117 / Fragment_b118 (ShadowCaster), Sub0_Pass2 Vertex_b126 / Fragment_b127 (ForwardReflection). Keyword set of the #else catch-all = HG_ENABLE_MV SRP_INSTANCING_ON only.
// Keywords: _TWO_BASEMAP (CLOSED: straight-RG normal + 0.012 dead-zone, b34:345-357,507), _MATCAP (CLOSED: view-space-normal matcap add, b54:379,1263,1327-1329), _ALPHATEST_ON (none in base; reserved), _SIMPLE_VERTEXANIM, _SIMPLE_VERTEXANIM_CLOTH (declared so the variant set matches; base path neutral).
// Feature keywords NOT closed (decompiled-blob defects, not infra): _EMISSIVE_MAP/_EMISSIVE_MASK (b26/b28 SPIRV-Cross output is math-corrupt — scalar `.z` swizzles on float uniforms + mask/refract/vertanim cbuffer slots cross-aliased into the emissive variant; no recoverable 1:1 emissive add). _TRI_CHANNEL_MASK (b58 math structure is clean but the per-channel roughness/metallic + offset/sharpen uniforms are decompiler-aliased onto unrelated slots (_MaskGScale/_RefractTexIntensity/_SimpleVertexAnimation*) AND are HG-global shaping params absent from this shader's Property set — porting would require inventing their defaults). _USE_REFRACTION/_GLASS_REFRACTION_SCENECOLOR (b30/b32 sample sampler_LinearClamp_SceneColorTexture through Texture3D froxels = host scene-color pass, ENGINE-SIDE). _SUBSURFACE/_USE_FRESNEL never appear isolated (only inside the corrupt combined blobs b44/b48/b50/b52).
// Kept (1:1 base path): base PBR (BaseColor tint-cover/brighter, MRO unpack via _BaseTextureMapCount, roughness Min/Max remap, metallic select, occlusion, two-sided normal, DXT5nm-style normal X-in-.a), Cook-Torrance GGX-D + Smith height-correlated Vis + Schlick F (b24:1025-1043), Karis analytic Env-BRDF F0 scale/bias (b24:391-392,1592), EnvBRDFApprox DFG (b24:1033) + 1/21 grazing-floor multiscatter diffuse (b24:1035-1037), SH ambient diffuse, glossy env reflection, transparent output alpha = refraction-aware baseAlpha*BaseColor.a blended by vertex-color.x under _UseCustomRefractTex (b24:356,363), VFX color-grade (b24:1659-1663), ForwardReflection octahedral-normal+roughness output (b127:106-108).
// Removed (pixel-neutral pipeline infra, substituted by URP per STYLE_BIBLE §2 / CORE_MATH §2.12): GPU skinning (b23:238-440), SRP-instancing per-draw array, octahedral NORMAL/TANGENT vertex decode (b23:149-218), HG motion-vector dual-clip + SV_Target1 MV/TAAU pack (b24:1664-1670), IV-clipmap GI cascade T11-T16 (b24:417-640) -> SampleSH, HG reflection-probe binning T0/T1 (b24:651-776) -> GlossyEnvironmentReflection, CSM/ASM/cloud directional-shadow atlases T5/T7/T8 (b24:778-995) -> URP main-light shadow, tile/zbin punctual-light loop + per-light PCF T6 (b24:1056-1590) -> URP GetAdditionalLight, atmosphere+exponential+volumetric froxel fog T17 (b24:1593-1658) -> MixFog, planar-reflection screen reprojection (b24:393-397).
//
// NOTE: transparent alpha differs from the opaque lit-forward sibling. The base output alpha is _411 (b24:363):
//   baseAlpha = baseTex.a * _BaseColor.a (b24:356 _375); alpha = lerp(baseAlpha, baseAlpha*vertexColor.x, _UseCustomRefractTex).
//   The opaque "vertex-color.x as opacity" (_349) is only consumed by the dropped SV_Target1 MV pack, NOT by SV_Target0.
// NOTE: base-variant sampler states are POINT-filtered (b24:348 sampler_PointClamp BaseColor, :349 sampler_PointRepeat Normal, :354 sampler_PointMirror MRO). Wrap modes BaseColor=clamp, Normal=repeat, MRO=mirror; filter=point — set these on the import asset (declared with inline SamplerStates below to preserve filter+wrap intent).
// Texture-channel legend: _MROMap RGB = Metallic, Roughness, Occlusion. _NormalMap stores X in .a, Y in .g (decoded nx=nrm.x*nrm.w*2-1, ny=nrm.y*2-1). _BaseTextureMapCount enum {Three=0, Two=1, TwoWithNoMetallic=2} selects metallic-from-MRO.r vs _Metallic slider.

Shader "HGRP/LitTransparent_Fix" {
    Properties {
        // ---- Blend-state plumbing (set by CustomEditor / material presets via _SurfaceType; transparent defaults) ----
        [HideInInspector] _SrcBlend ("__src", Float) = 5       // SrcAlpha    (littransparent.shader:170)
        [HideInInspector] _DstBlend ("__dst", Float) = 10      // OneMinusSrcAlpha (littransparent.shader:171)
        [HideInInspector] _ZTest ("__zt", Float) = 4           // LEqual
        [HideInInspector] _ZWrite ("__zw", Float) = 0          // transparent: ZWrite Off (littransparent _Zwrite default 0, :148)
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2   // littransparent.shader:145 (default Front)
        [Enum(Opaque, 0, Transparent, 1)] [HideInInspector] _SurfaceType ("Surface Type", Float) = 1  // littransparent.shader:146
        [HideInInspector] _StencilRef ("Stencil Ref", Float) = 0

        // ---- Two-BaseMap normal mode (keyword: straight-RG normal + dead-zone, not DXT5nm X-in-A) ----
        [Toggle(_TWO_BASEMAP)] _TwoBaseMap ("Two BaseMap (RG normal, no X-in-A)", Float) = 0

        // ---- Core surface / base PBR (always-on, no keyword) ----
        [Enum(Three, 0, Two, 1, TwoWithNoMetallic, 2)] _BaseTextureMapCount ("Base Texture Map Count", Float) = 0
        _BaseColorMap ("Base Color Map", 2D) = "white" {}
        _BaseUVSet ("Base UV Set", Float) = 0
        _BaseColor ("Base Color", Color) = (1, 1, 1, 1)
        _BaseColorTintCover ("Base Color Tint Cover", Range(0, 1)) = 0
        _BaseColorBrighterScale ("Base Color Brighter Scale", Range(1, 2)) = 1
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _MROMap ("MRO Map (Metallic,Roughness,Occlusion)", 2D) = "white" {}
        _BasePbrMapUVSet ("PBR Map UV Set", Float) = 0
        _NormalScale ("Normal Scale", Range(0, 2)) = 1
        [Toggle] _TwoSidedNormal ("Two Sided Normal", Float) = 1
        _Metallic ("Metallic", Range(0, 1)) = 0
        _Specular ("Specular", Range(0, 1)) = 0.5
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1
        _OcclusionStrength ("Occlusion Strength", Range(0, 1)) = 1
        _TAAUNormalBiasReverse ("TAAU Normal Bias Reverse", Float) = 0
        [Enum(BaseColor_A, 0, NRO_A, 1)] _AlphaMaskChannel ("Alpha Mask Channel", Float) = 0
        [HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}

        // ---- Transparent base alpha / opacity ----
        [Header(Transparent Base Alpha)]
        [ToggleUI] _Use_VerexTexColorAsOpacity ("Use Vertex Tex Color As Opacity", Float) = 0
        [Enum(RefractiveIndex, 0, CustomTex, 1)] _UseCustomRefractTex ("Use Custom Refract Tex", Float) = 0
        _RefractTexIntensity ("Refract Tex Intensity", Range(0, 1)) = 0.01

        // ---- Matcap (keyword: view-space-normal matcap, additive into final color; littransparent.shader:81-84) ----
        [Header(Matcap)]
        [Toggle(_MATCAP)] _EnableMatcap ("Enable Matcap", Float) = 0
        _MatcapMap ("Matcap Map", 2D) = "black" {}
        _MatcapMapStrength ("Matcap Map Strength", Range(0, 1)) = 0.2
        [ToggleUI] _MatCapIgnorePostExposure ("Matcap Ignore Post Exposure", Float) = 1

        // ---- Simple Vertex Anim (variant-set parity; base path neutral) ----
        [Header(Simple Vertex Anim)]
        _SimpleVertexAnimationWindIntensity ("Wind Intensity", Range(0, 20)) = 1
        _SimpleVertexAnimationWindFreq ("Wind Freq", Range(0, 50)) = 7

        // ---- Alpha Test (reserved keyword; base has none) ----
        [Header(Alpha Test)]
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Enable Alpha Test", Float) = 0
        _AlphaClipThreshold ("Alpha Clip Threshold", Range(0, 1)) = 0.5

        // ---- Environment / Exposure (HGRP globals re-exposed as material Vectors; URP has no equivalent global; STYLE_BIBLE §1.5/§2) ----
        [Header(Environment Params)]
        _EnvironmentGlobalParams0 ("EnvGlobalParams0 (.x=ambient intensity, .y=reflection intensity)", Vector) = (1, 1, 1, 0)
        _GraphicsFeaturesGlobalParam0 ("GraphicsFeatures0 (.z=reflection feature scale)", Vector) = (0, 0, 1, 1)
        _VFXParams1 ("VFXParams1 (.xyz=tint .w=saturation)", Vector) = (1, 1, 1, 1)
        _ExposureParams ("ExposureParams (.x=current exposure; matcap post-exposure comp)", Vector) = (1, 1, 1, 1)
    }

    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Transparent" "Queue"="Transparent" }
        LOD 600

        HLSLINCLUDE
            // ============================================================
            // URP infrastructure (substitutes for all HGRP hand-rolled globals — STYLE_BIBLE §2 / CORE_MATH §2.12).
            // Core.hlsl: UNITY_MATRIX_*, _WorldSpaceCameraPos, unity_ObjectToWorld, unity_OrthoParams, _ScreenParams,
            //            GetVertexPositionInputs/GetVertexNormalInputs, TransformWorldToHClip, SAMPLE_TEXTURE2D_BIAS,
            //            GetWorldSpaceViewDir, ComputeFogFactor, MixFog, SampleSH, PackNormalOctQuadEncode.
            // Lighting.hlsl: GetMainLight/GetAdditionalLight, Light, TransformWorldToShadowCoord, GlossyEnvironmentReflection.
            // (SurfaceInput.hlsl deliberately NOT included — it pulls URP's `struct SurfaceData`; we own our surface type.)
            // ============================================================
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"

            // ============================================================
            // UnityPerMaterial — single CBUFFER. Field set = b24:101-124 (type_UnityPerMaterial) + the transparent
            // exposed params. NO packoffset / NO SPIRV-Cross aliases. (b24 packoffset order is the compiler's, not used.)
            // ============================================================
            CBUFFER_START(UnityPerMaterial)
                // blend-state plumbing
                float _SrcBlend;
                float _DstBlend;
                float _ZTest;
                float _CullMode;
                float _SurfaceType;
                float _StencilRef;

                // core surface / base PBR (b24:103-119)
                float4 _BaseColor;            // b24:117 (c8)
                float4 _BaseColorMap_ST;      // b24:118 (c11)
                float4 _NormalMap_ST;         // b24:119 (c12)  (also tiles _MROMap — b24:346,354)
                float _NormalScale;           // b24:103
                float _Specular;              // b24:104
                float _RoughnessMin;          // b24:105
                float _RoughnessMax;          // b24:106
                float _OcclusionStrength;     // b24:107
                float _AlphaMaskChannel;      // b24:108
                float _TwoSidedNormal;        // b24:109
                float _BaseUVSet;             // b24:110
                float _BasePbrMapUVSet;       // b24:111
                float _TAAUNormalBiasReverse; // b24:112
                float _BaseTextureMapCount;   // b24:113
                float _BaseColorTintCover;    // b24:114
                float _Metallic;              // b24:115
                float _BaseColorBrighterScale;// b24:116

                // transparent base alpha (b24:120-123)
                float _UseCustomRefractTex;   // b24:120 (c19)
                float _RefractTexIntensity;   // b24:121
                float _SimpleVertexAnimationWindIntensity; // b24:122
                float _SimpleVertexAnimationWindFreq;      // b24:123
                float _Use_VerexTexColorAsOpacity;
                float _AlphaClipThreshold;

                // matcap (_MATCAP) — b54:1263,1327-1329. names are decompiler-aliased in b54 (c19.x/.y); real roles per littransparent.shader:81-84.
                float _MatcapMapStrength;        // b54:1327 _UseCustomRefractTex-slot = _MatcapMapStrength
                float _MatCapIgnorePostExposure; // b54:1263 _RefractTexIntensity-slot = _MatCapIgnorePostExposure

                // HGRP globals re-exposed (b24 cbuffer type_ShaderVariablesGlobal -> material Vectors)
                float4 _EnvironmentGlobalParams0;     // b24:58 (c111) .x=ambient intensity, .y=reflection intensity
                float4 _GraphicsFeaturesGlobalParam0; // b24:59 (c112) .z=reflection-feature scale (b24:1656 _GraphicsFeaturesGlobalParam0.z)
                float4 _VFXParams1;                   // b24:85 (c186) .xyz=tint, .w=saturation (b24:1661-1663)
                float4 _ExposureParams;               // b24:56 (c109) .x=current exposure (matcap post-exposure comp, b54:1263)
            CBUFFER_END

            // ============================================================
            // Textures. Each blob Tn re-identified by usage (b24:176-178 -> by sample site b24:348/349/354).
            // Inline SamplerState names encode the base-variant filter+wrap (b24:193-199): BaseColor=PointClamp,
            // Normal=PointRepeat, MRO=PointMirror. (URP TEXTURE2D/SAMPLER macros honor the asset's import settings;
            // the explicit names document the ground-truth intent — STYLE_BIBLE §1.6 / §2.)
            // ============================================================
            TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);   // T2 (b24:348) albedo — point/clamp
            TEXTURE2D(_NormalMap);      SAMPLER(sampler_NormalMap);      // T3 (b24:349) DXT5nm normal — point/repeat
            TEXTURE2D(_MROMap);         SAMPLER(sampler_MROMap);         // T4 (b24:354) metallic/roughness/occlusion — point/mirror
            TEXTURE2D(_MatcapMap);      SAMPLER(sampler_MatcapMap);      // _MATCAP T5 (b54:379) view-space-normal matcap — linear/repeat

            // ---- Decoded magic constants (denormalized-float bit patterns -> real values), b24 (CORE_MATH §0.4) ----
            static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709 luma, b24:652/1659
            static const float  HGRP_EPS_VIEWLEN  = 9.9999999392252902907785028219223e-09; // 1e-8 ; view rsqrt guard, b24:339
            static const float  HGRP_EPS_NORMAL_Z = 1.000000016862383526387164645044e-16;  // 1e-16 ; derived-normal Z floor, b24:366
            static const float  HGRP_EPS_HALF_RSQRT = 6.103515625e-05;                     // 2^-14 ; half-precision rsqrt guard, b24:1007
            static const float  HGRP_EPS_VIS      = 9.9999997473787516355514526367188e-05; // 1e-4 ; Smith-Vis denominator floor, b24:1039
            static const float  HGRP_DIELECTRIC_F0 = 0.07999999821186065673828125;         // 0.08 ; dielectric F0 base = 0.08*_Specular, b24:381
            static const float  HGRP_GRAZING_FLOOR  = 0.0476190485060214996337890625;      // 1/21 ; grazing floor gz=lerp(F0,1,1/21), b24:1035-1037

            // ============================================================
            // Attributes / Varyings (URP-standard appdata; HG skin / octahedral-packed normal / MV streams dropped).
            // ============================================================
            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;     // vertex color (b23:520-523 TEXCOORD_4_1); .x = opacity gate (b24:363/_349)
                float2 uv0        : TEXCOORD0;
                float2 uv1        : TEXCOORD1;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct Varyings
            {
                float4 positionCS  : SV_Position;
                float3 positionWS  : TEXCOORD0;   // b24 TEXCOORD_5 (world pos reconstructed; here passed directly)
                float3 normalWS    : TEXCOORD1;   // b24 TEXCOORD_2 (geometric world normal)
                float4 tangentWS   : TEXCOORD2;   // b24 TEXCOORD_3 (.xyz tangent, .w = sign*handedness)
                float4 uv          : TEXCOORD3;   // .xy = raw uv0, .zw = raw uv1 (frag does UV-set lerp + per-map _ST, b24:344-347)
                float4 color       : TEXCOORD4;   // vertex color rgba (b23:520-523)
                float3 viewDirWS   : TEXCOORD5;   // camera->fragment unnormalized (frag normalizes, b24:334-343)
                float  fogFactor   : TEXCOORD6;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                UNITY_VERTEX_OUTPUT_STEREO
            };

            struct LitSurfaceData
            {
                half3  albedo;     // tint-covered baseCol (b24:382-384 _571-derives; here baseCol pre-metallic)
                half3  normalWS;   // world normal after TBN + two-sided sign (b24:367-373)
                half   metallic;   // lerp(MRO.r, _Metallic, saturate(count-1)) (b24:365)
                half   roughness;  // linear roughness = lerp(RoughMin,RoughMax,MRO.g) (b24:364)
                half   occlusion;  // lerp(1, MRO.b, _OcclusionStrength) (b24:1591)
                half   alpha;      // transparent output alpha = _411 (b24:363)
                half3  f0;         // lerp(0.08*_Specular, baseCol, metallic) (b24:382-388)
            };

            // ============================================================
            // VERTEX — object->world->clip + TBN basis. 1:1 source: b23:459-528 (transform), b23:499-507 (TBN).
            // The HG manual mul(unity_ObjectToWorld,posOS)+mul(VP,..) and inverse-transpose normal / forward
            // tangent basis are supplied verbatim by URP GetVertexPositionInputs / GetVertexNormalInputs
            // (STYLE_BIBLE §2 vertex table). Skinning (b23:238-440) / oct-decode (b23:149-218) / MV (b23:508-513) dropped.
            // ============================================================
            Varyings LitVertex(Attributes IN)
            {
                Varyings OUT = (Varyings)0;
                UNITY_SETUP_INSTANCE_ID(IN);
                UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);

                VertexPositionInputs posInputs = GetVertexPositionInputs(IN.positionOS);   // b23:484-486,514-515 (world->clip)
                VertexNormalInputs   nrmInputs = GetVertexNormalInputs(IN.normalOS, IN.tangentOS); // b23:499-507 (normalize TBN)

                OUT.positionCS = posInputs.positionCS;
                OUT.positionWS = posInputs.positionWS;                     // b23:524-526 TEXCOORD_5 (world pos)
                OUT.normalWS   = nrmInputs.normalWS;                       // b23:500-502 TEXCOORD_2_1
                // tangent.w = sign(WorldTransformParams.w) * TANGENT.w (b23:507) -> URP odd-negative-scale
                OUT.tangentWS  = float4(nrmInputs.tangentWS, IN.tangentOS.w * GetOddNegativeScale());
                OUT.uv         = float4(IN.uv0, IN.uv1);                   // raw uv0/uv1 (b23:516-519); frag applies _ST
                OUT.color      = IN.color;                                // b23:520-523 TEXCOORD_4_1
                OUT.viewDirWS  = GetWorldSpaceViewDir(posInputs.positionWS); // perspective camPos-P / ortho -fwd (b24:334-337)
                OUT.fogFactor  = ComputeFogFactor(posInputs.positionCS.z);  // HG froxel/atmos fog -> URP MixFog (b24:1593-1658)
                return OUT;
            }

            // ============================================================
            // FRAGMENT SURFACE ASSEMBLY — 1:1 source: b24:344-388,1591 (cross-check ForwardReflection b127:86-108).
            // ============================================================
            LitSurfaceData LitBuildSurface(Varyings IN, bool isFrontFace)
            {
                LitSurfaceData s = (LitSurfaceData)0;

                float2 uv0 = IN.uv.xy;
                float2 uv1 = IN.uv.zw;
                float4 tangentWS = IN.tangentWS;
                float3 normalGeo = IN.normalWS;

                // tangent handedness sign: _218 = (TEXCOORD_3.w>0)?+1:-1  (b24:333)
                float tangentSign = (tangentWS.w > 0.0) ? 1.0 : -1.0;

                // UV-set select + per-map _ST: duv=uv1-uv0; base/pbr = (uv0 + UVSet*duv)*ST.xy + ST.zw (b24:344-348)
                float duvX = uv1.x - uv0.x;   // b24:344 (_281)
                float duvY = uv1.y - uv0.y;   // b24:345 (_282)
                float2 uvBase = float2(
                    mad(mad(_BaseUVSet,       duvX, uv0.x), _BaseColorMap_ST.x, _BaseColorMap_ST.z),
                    mad(mad(_BaseUVSet,       duvY, uv0.y), _BaseColorMap_ST.y, _BaseColorMap_ST.w));  // b24:348
                float2 uvPbr = float2(
                    mad(mad(_BasePbrMapUVSet, duvX, uv0.x), _NormalMap_ST.x, _NormalMap_ST.z),
                    mad(mad(_BasePbrMapUVSet, duvY, uv0.y), _NormalMap_ST.y, _NormalMap_ST.w));        // b24:346-347

                // sample the 3 base maps. mip: albedo & MRO at _GlobalMipBias; NORMAL at _GlobalMipBias + _TAAUNormalBiasReverse
                // (b24:348/354 vs :349). URP SAMPLE_TEXTURE2D_BIAS auto-folds _GlobalMipBias.x; pass 0 / _TAAUNormalBiasReverse.
                float4 baseTex = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uvBase, 0.0);                     // b24:348 (_329)
                float4 nrm     = SAMPLE_TEXTURE2D_BIAS(_NormalMap,    sampler_NormalMap,    uvPbr,  _TAAUNormalBiasReverse);  // b24:349 (_343)
                float4 mro     = SAMPLE_TEXTURE2D_BIAS(_MROMap,       sampler_MROMap,       uvPbr,  0.0);                     // b24:354 (_360)

                // tangent-space normal decode. base path: X in .a (DXT5nm) -> rawNx=nrm.x*nrm.w*2-1 (b24:350-353).
                // _TWO_BASEMAP: straight-RG normal (no .w fold) + 0.012 dead-zone snapping tiny XY to 0 (b34:345-357).
            #ifdef _TWO_BASEMAP
                float rawNx = mad(nrm.x, 2.0, -1.0);                       // b34:345 (_345) straight-RG, no .a fold
                float rawNy = mad(nrm.y, 2.0, -1.0);                       // b34:346 (_346)
                rawNx = (abs(rawNx) < 0.01200000010430812835693359375) ? 0.0 : rawNx;  // b34:355 dead-zone (_355)
                rawNy = (abs(rawNy) < 0.01200000010430812835693359375) ? 0.0 : rawNy;  // b34:357 (_357)
            #else
                float rawNx = mad(nrm.x * nrm.w, 2.0, -1.0);               // b24:350 (_349) DXT5nm X-in-.a
                float rawNy = mad(nrm.y,         2.0, -1.0);               // b24:351 (_350)
            #endif
                float nx = rawNx * _NormalScale;                          // b24:352 / b34:361 (_354 / _361)
                float ny = rawNy * _NormalScale;                          // b24:353 / b34:362 (_355 / _362)

                // base alpha + albedo + tint-cover (b24:356-362).
                // _TWO_BASEMAP packs N=(Nx,Ny,Roughness,Occlusion) [NRO] + metallic from BaseColor.a; MRO map unused (b34 does not sample T4).
                // base alpha = baseTex.a*_BaseColor.a (b24:356); two-basemap selects mask channel via _AlphaMaskChannel (b34:38 _408).
            #ifdef _TWO_BASEMAP
                float baseAlpha = mad(_AlphaMaskChannel, -baseTex.a + nrm.w, baseTex.a) * _BaseColor.a; // b34:38 (_408) lerp(baseTex.a, N.a, _AlphaMaskChannel)*_BaseColor.a
            #else
                float baseAlpha = baseTex.a * _BaseColor.a;               // b24:356 (_375)
            #endif
                float3 albedoRaw = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale); // b24:357-359 (_383-385)
                float3 baseCol = float3(
                    mad(_BaseColorTintCover, -albedoRaw.x + _BaseColor.x, albedoRaw.x),
                    mad(_BaseColorTintCover, -albedoRaw.y + _BaseColor.y, albedoRaw.y),
                    mad(_BaseColorTintCover, -albedoRaw.z + _BaseColor.z, albedoRaw.z));              // b24:360-362 (_400-402)

                // output alpha (refraction-aware): _411 = lerp(baseAlpha, baseAlpha*vertexColor.x, _UseCustomRefractTex) (b24:363)
                float alpha = mad(_UseCustomRefractTex, mad(baseAlpha, IN.color.x, -baseAlpha), baseAlpha);  // b24:363 (_411)

                // roughness (linear) + metallic select (b24:364-365). _TWO_BASEMAP: roughness from N.z, metallic from baseTex.a (b34:429,441).
            #ifdef _TWO_BASEMAP
                float roughness = mad(nrm.z,    -_RoughnessMin + _RoughnessMax, _RoughnessMin);        // b34:429 (_429) = lerp(min,max,N.z)
                float metallic  = mad(saturate(-1.0 + _BaseTextureMapCount), -baseTex.a + _Metallic, baseTex.a); // b34:441 (_440) = lerp(baseTex.a,_Metallic,sat(count-1))
            #else
                float roughness = mad(mro.y, -_RoughnessMin + _RoughnessMax, _RoughnessMin);          // b24:364 (_423) = lerp(min,max,mro.g)
                float metallic  = mad(saturate(-1.0 + _BaseTextureMapCount), -mro.x + _Metallic, mro.x); // b24:365 (_434)
            #endif

                // tangent-space Z with two-sided front sign (b24:366); world normal via TBN, normalize (b24:367-373)
                float frontSign = isFrontFace ? 1.0 : ((_TwoSidedNormal > 0.0) ? -1.0 : 1.0);          // b24:366 sign
            #ifdef _TWO_BASEMAP
                // b34:507 reconstructs Z from the DEAD-ZONED pre-scale XY, clamp INSIDE sqrt (max(...,0)), no 1e-16 floor / no min-1.
                float nz = sqrt(max(1.0 - dot(float2(rawNx, rawNy), float2(rawNx, rawNy)), 0.0)) * frontSign; // b34:507 (_507)
            #else
                float nz = max(sqrt(1.0 - min(dot(float2(nx, ny), float2(nx, ny)), 1.0)), HGRP_EPS_NORMAL_Z) * frontSign; // b24:366 (_503)
            #endif
                float3 bitangent = tangentSign * cross(normalGeo, tangentWS.xyz);                      // b24:367-369 cross*sign (_218)
                float3 normalWS = normalize(normalGeo * nz + tangentWS.xyz * nx + bitangent * ny);     // b24:367-373 (_510-519)

                // PBR specular split & F0 (b24:381-388, CORE_MATH §2.3)
                float dielF0 = HGRP_DIELECTRIC_F0 * _Specular;            // b24:381 (_566) = 0.08*_Specular
                float3 f0 = float3(
                    mad(baseCol.x, metallic, mad(-dielF0, metallic, dielF0)),
                    mad(baseCol.y, metallic, mad(-dielF0, metallic, dielF0)),
                    mad(baseCol.z, metallic, mad(-dielF0, metallic, dielF0)));   // b24:385-388 (_575-578) = lerp(0.08*_Spec, baseCol, metallic)

                // occlusion: base from MRO.b (b24:1591); _TWO_BASEMAP from N.a (b34:1267 _3031).
            #ifdef _TWO_BASEMAP
                float occlusion = mad(_OcclusionStrength, nrm.w - 1.0, 1.0); // b34:1267 (_3031) = lerp(1, N.a, _OcclusionStrength)
            #else
                float occlusion = mad(_OcclusionStrength, mro.z - 1.0, 1.0);   // b24:1591 (_3027) = lerp(1, mro.b, _OcclusionStrength)
            #endif

                s.albedo    = baseCol;
                s.normalWS  = normalWS;
                s.metallic  = metallic;
                s.roughness = roughness;
                s.occlusion = occlusion;
                s.alpha     = alpha;
                s.f0        = f0;
                return s;
            }

            // ============================================================
            // Karis analytic ENVIRONMENT-BRDF (F0 scale/bias for ambient reflection). 1:1 source b24:391-392,1592.
            //   envF        (_598) = mad(min((1-r)^2, exp2(NoV*-9.28)), 1-r, mad(r,-0.0275,0.0425))
            //   envSpecScale(_599) = mad(envF, -1.04, mad(r, -0.572, 1.04))
            //   envSpecBias (_3046)= mad(envF, 1.04, mad(r, 0.022, -0.04)) * saturate(F0.g * 50)
            //   gate (b24:1656)    = reflection * (F0*envSpecScale + envSpecBias)
            // The 2D DFG split-sum LUT T10 (b24:1040/1069) is engine infra; replaced by the analytic form below
            // per CORE_MATH §2.6/§2.12. Poly coeffs are LOAD-BEARING — copied exactly from b24.
            // ============================================================
            void HgEnvBRDF(float roughness, float NoV, float3 f0, out float3 envSpecScale, out float3 envSpecBias)
            {
                float oneMinusRough = mad(roughness, -1.0, 1.0);                         // 1-r , b24:389 (_582)
                float envF = mad(min(oneMinusRough * oneMinusRough, exp2(NoV * -9.27999973297119140625)),
                                 oneMinusRough,
                                 mad(roughness, -0.0274999998509883880615234375, 0.0425000004470348358154296875)); // b24:391 (_598)
                float scale = mad(envF, -1.03999996185302734375,
                                  mad(roughness, -0.572000026702880859375, 1.03999996185302734375));                // b24:392 (_599)
                // _3046 = mad(_598,1.04, mad(_423,0.022,-0.04)) * saturate(_577*50). _577 = F0.g (b24:1592).
                float biasCommon = mad(envF, 1.03999996185302734375,
                                       mad(roughness, 0.02199999988079071044921875, -0.039999999105930328369140625)); // b24:1592 (_3046 lhs)
                float bias = biasCommon * saturate(f0.g * 50.0);                                                      // b24:1592 (_3046)
                envSpecScale = scale.xxx;
                envSpecBias  = bias.xxx;
            }

            // ============================================================
            // EnvBRDFApprox rational DFG scale (Karis/Lazarov). 1:1 source b24:1033 (_2210) / b24:1064 (_2746).
            //   t   = 1 - roughness ; dfg = min(t*(t*((-t)*0.38302600 - 0.07619470) + 1.04997003) + 0.40925499, 0.999)
            // ============================================================
            float HgEnvBRDFApproxDFG(float roughness)
            {
                float t = mad(roughness, -1.0, 1.0);                          // 1-r , b24:1032 (_2201)
                return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875,  // b24:1033 (_2210)
                                              -0.076194703578948974609375),
                                        1.04997003078460693359375),
                               0.4092549979686737060546875),
                           0.999000012874603271484375);
            }

            // ============================================================
            // Analytic-light specular BRDF: Cook-Torrance GGX-D + Smith height-correlated Vis + Schlick F.
            // 1:1 source b24:1024-1043 (directional) == b24:1372-1383 (punctual, identical D/Vis/F). Returns (D*Vis)*F.
            //   a=r*r (_2186), a2=a*a (_2187), nv=min(NoV,1) (_2185)
            //   d=(NoH*a2 - NoH)*NoH + 1 (_2190) ; D=a2/(d*d)
            //   Vis=0.5/(nv*sqrt((-NoL*a2+NoL)*NoL+a2) + NoL*sqrt((-nv*a2+nv)*nv+a2) + 1e-4) (_2244)
            //   Fc=(1-VoH)^5 (_2199) ; F=lerp(F0,1,Fc)=mad(F0,1-Fc,Fc) (_2225/_2198)
            // ============================================================
            float3 HgDirectSpecular(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float a   = roughness * roughness;                            // b24:1025 (_2186)
                float a2  = a * a;                                           // b24:1026 (_2187)
                float nv  = min(NoV, 1.0);                                   // b24:1024 (_2185)
                float d   = mad(mad(NoH, a2, -NoH), NoH, 1.0);               // b24:1027 (_2190)
                float visDenom = nv  * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2)) // b24:1039 (_2244) lambdaV
                               + NoL * sqrt(mad(mad(-nv,  a2, nv ), nv , a2)) //                  lambdaL
                               + HGRP_EPS_VIS;
                float DV  = (a2 / (d * d)) * (0.5 / visDenom);               // D * Vis , b24:1039 (_2244)
                // Schlick: Fc=(1-VoH)^5 (b24:1029-1031 _2197-2199), F=lerp(F0,1,Fc) (b24:1038 _2225 + _2198)
                float oneMinusVoH = mad(-VoH, 1.0, 1.0);                     // 1-VoH , b24:1028 (_2196)
                float sq   = oneMinusVoH * oneMinusVoH;                      // (1-VoH)^2 , b24:1029 (_2197)
                float quad = sq * sq;                                        // (1-VoH)^4 , b24:1030 (_2198)
                float Fc   = oneMinusVoH * quad;                            // (1-VoH)^5 , b24:1031 (_2199)
                float oneMinusFc = mad(-quad, oneMinusVoH, 1.0);            // 1-(1-VoH)^5 , b24:1038 (_2225)
                float3 F   = mad(f0, oneMinusFc.xxx, Fc.xxx);              // lerp(F0,1,Fc)
                return DV * F;
            }

            // ============================================================
            // Per-light energy bracket (b24:1040-1041 _2310). multiscatter diffuse + clamped specular.
            //   gz=lerp(F0,1,1/21) (_2220) ; dfg=EnvBRDFApproxDFG (_2210) ; T9 DFG LUT product -> analytic dfg (CORE_MATH §2.6).
            //   msDiff = (dfg/(1-dfg) * gz^2) / (1 - gz*(1-dfg))  per channel (b24:1040 inner)
            //   energy = min(max( msDiff + min((D*Vis)*F, 2048), 0), 1000)
            // The Lambert base (diffuse*NoL) is ADDED at the call site (b24:1041 + _571*NoL). lightScale folded into URP lightColor.
            // ============================================================
            float3 HgDirectLightEnergy(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float3 specE = HgDirectSpecular(roughness, f0, NoL, NoH, NoV, VoH);     // (D*Vis)*F , b24:1039
                float  dfg   = HgEnvBRDFApproxDFG(roughness);                           // analytic DFG , b24:1033 (_2210)
                float  oneMinusDfg = mad(-dfg, 1.0, 1.0);                               // 1-dfg , b24:1034 (_2213)
                float  dfgEnergy = dfg / oneMinusDfg;                                   // _2267 (T9 product -> dfg substitute)
                float3 gz = mad((float3(1.0, 1.0, 1.0) - f0), HGRP_GRAZING_FLOOR, f0);  // lerp(F0,1,1/21) , b24:1035-1037 (_2220-2223)
                float3 msDiff = (dfgEnergy * (gz * gz)) / mad(-gz, oneMinusDfg.xxx, float3(1.0, 1.0, 1.0)); // b24:1040 term A
                return min(max(msDiff + min(specE, 2048.0), 0.0), 1000.0);             // b24:1040-1041 clamp [0,1000]
            }

            // ============================================================
            // ForwardLit composite. 1:1 source b24:1656-1674 (final color + VFX grade + output).
            //   color = diffuse*SH(N)*occ*envParams0.x                              (b24:1656 term, _571*_1032*_3027*envParams.x)
            //         + reflection*GraphicsFeatures0.z*envParams0.y*(F0*scale+bias)  (b24:1656 _1726*..*mad(_576,_599,_3046))
            //         + directionalLight + additionalLights                          (b24:1656 + mad(_2813,_2819,_2699))
            //   color = MixFog(color)                                                (HG atmos/exp/volumetric fog -> URP)
            //   color = lerp(luma, color, _VFXParams1.w) * _VFXParams1.xyz           (b24:1659-1663)
            //   out   = half4(color, alpha)                                          (b24:1671-1674, alpha=_411)
            // ============================================================
            half4 LitForwardLighting(LitSurfaceData s, Varyings IN)
            {
                float3 N = normalize(s.normalWS);
                // View dir: perspective normalize(camPos-P); rsqrt guard 1e-8 (b24:338-343 _261/_266/_267-269)
                float3 viewRaw = IN.viewDirWS;
                float  distSq  = dot(viewRaw, viewRaw);                      // b24:338 (_261)
                float  invLen  = rsqrt(max(distSq, HGRP_EPS_VIEWLEN));       // b24:339 (_266)
                float3 V = viewRaw * invLen;                                 // b24:340-342 (_267-269)

                float  roughness = s.roughness;
                float3 f0        = s.f0;
                float3 diffuse   = s.albedo * (1.0 - s.metallic);           // baseCol*(1-metallic) , b24:382-384 (_571-573)
                float  occlusion = s.occlusion;
                float  NoV = max(dot(N, V), 0.0);                           // b24:390 (_593)

                // ---- env-BRDF F0 scale/bias (b24:391-392,1592) ----
                float3 envSpecScale, envSpecBias;
                HgEnvBRDF(roughness, NoV, f0, envSpecScale, envSpecBias);

                // ---- ambient diffuse: HG IV-clipmap SH cascade (b24:417-640) -> URP SampleSH(N) ----
                float3 ambientSH = SampleSH(N);                             // b24:638-640 project SH onto N (_1032 R-channel etc.)
                // ---- specular reflection: HG probe-binning atlas (b24:651-776) -> URP GlossyEnvironmentReflection ----
                float  perceptualRoughness = saturate(roughness);          // s.roughness IS perceptual (GGX squares it); no sqrt (b24:364/1068)
                float3 reflectVec = reflect(-V, N);                        // R = -V + 2*NoV*N , b24:641-645 (_1054-1056)
                float3 reflection = GlossyEnvironmentReflection(reflectVec, perceptualRoughness, 1.0); // occ=1: HG term B not AO-gated (b24:1656)

                // term A (diffuse ambient) + term B (reflection), b24:1656. GraphicsFeatures0.z scales the reflection (b24:1656 _GraphicsFeaturesGlobalParam0.z).
                float3 color = diffuse * ambientSH * occlusion * _EnvironmentGlobalParams0.x
                             + reflection * _GraphicsFeaturesGlobalParam0.z * _EnvironmentGlobalParams0.y * (f0 * envSpecScale + envSpecBias);

                // ---- direct MAIN (directional) light: HG CSM/ASM/cloud atlases (b24:778-995) -> URP main-light shadow ----
                float4 shadowCoord = TransformWorldToShadowCoord(IN.positionWS);
                Light mainLight = GetMainLight(shadowCoord, IN.positionWS, half4(1, 1, 1, 1));
                float  mainAtten = mainLight.distanceAttenuation * mainLight.shadowAttenuation;   // -> _1948 shadow scale (b24:996)
                {
                    float3 L = mainLight.direction;                        // -_LightDataBuffer_DirectionalLightDirection[0] , b24:1002/1022
                    float3 H = normalize(L + V);                           // b24:1015-1021 (_2166-2176)
                    float NoL = saturate(dot(L, N));                       // b24:1022 (_2180)
                    float NoH = saturate(dot(N, H));                       // b24:1023 (_2184)
                    float VoH = saturate(dot(V, H));                       // b24:1028 base dot(V,H)
                    float3 energy = HgDirectLightEnergy(roughness, f0, NoL, NoH, NoV, VoH);  // b24:1033-1041
                    color += mad(energy, NoL, diffuse * NoL) * (mainAtten * mainLight.color); // b24:1041 mad(energy,NoL,_571*NoL)*lightColor
                }

                // ---- additional (punctual) lights: HG tile/zbin loop (b24:1056-1590) -> URP GetAdditionalLight ----
                //   Re-uses the IDENTICAL GGX D / Smith Vis / Schlick F per light (b24:1372-1383). HG tile/zbin/half-pack dropped.
            #if defined(_ADDITIONAL_LIGHTS)
                uint addCount = GetAdditionalLightsCount();
                for (uint li = 0u; li < addCount; ++li)
                {
                    Light light = GetAdditionalLight(li, IN.positionWS, half4(1, 1, 1, 1));
                    float3 L = light.direction;
                    float3 H = normalize(L + V);
                    float NoL = saturate(dot(L, N));
                    float NoH = saturate(dot(N, H));
                    float VoH = saturate(dot(V, H));
                    float3 energy = HgDirectLightEnergy(roughness, f0, NoL, NoH, NoV, VoH);
                    float atten = light.distanceAttenuation * light.shadowAttenuation;
                    color += mad(energy, NoL, diffuse * NoL) * (atten * light.color);
                }
            #endif

                // ---- matcap (_MATCAP): view-space-normal lookup, additive into pre-fog color. 1:1 source b54:379,1263,1327-1329.
                //   uv = (mul((float3x3)V, N).xy + 1)*0.5  (b54:379: _ViewMatrix rows 0/1 dotted with world N -> view-space N.xy)
                //   expComp = 1/lerp(1, _ExposureParams.x, _MatCapIgnorePostExposure)  (b54:1263 _3116)
                //   color += matcap.rgb * _MatcapMapStrength * expComp                 (b54:1327-1329 mad(_549.xyz*_strength, _3116, lit))
            #ifdef _MATCAP
                float3 viewN = mul((float3x3)UNITY_MATRIX_V, N);            // world normal -> view space (b54:379 _ViewMatrix[*].x/.y · N)
                float2 matcapUV = mad(viewN.xy, 0.5, 0.5);                  // (viewN.xy + 1)*0.5 , b54:379
                float3 matcap = SAMPLE_TEXTURE2D(_MatcapMap, sampler_MatcapMap, matcapUV).rgb; // b54:379 (_549)
                float  matcapExpComp = 1.0 / mad(_ExposureParams.x, _MatCapIgnorePostExposure, 1.0 - _MatCapIgnorePostExposure); // b54:1263 (_3116)
                color += matcap * (_MatcapMapStrength * matcapExpComp);     // b54:1327-1329
            #endif

                // ---- fog: HG atmosphere+exp+volumetric (b24:1593-1658) -> URP MixFog ----
                color = MixFog(color, IN.fogFactor);

                // ---- VFX color-grade: desaturate toward luma then tint (b24:1659-1663) ----
                float luma = dot(color, LUM);                              // b24:1659 (_3817)
                color = mad(_VFXParams1.w, (-luma).xxx + color, luma.xxx) * _VFXParams1.xyz; // b24:1661-1663 (_3836-3838)

                // ---- output alpha (b24:1674 SV_Target.w = _411). _SurfaceType==1 -> transparent alpha; opaque -> 1 (STYLE_BIBLE §6). ----
                float alpha = (_SurfaceType == 1.0) ? s.alpha : 1.0;
                return half4(color, alpha);
            }
        ENDHLSL

        // ============================================================================================
        // Pass 1: ForwardLit  (littransparent Sub0_Pass0 — LIGHTMODE "ForwardOnly" -> URP UniversalForwardOnly).
        //   Source render-state (littransparent.shader:182-198): Blend 0 [_SrcBlend] [_DstBlend], One OneMinusSrcAlpha;
        //   ZWrite [_Zwrite]; Cull [_CullMode]; Stencil Ref [_StencilRef] Comp Always Pass Replace.
        //   (Blend 1 / ColorMask R 1 / ZClip On are MRT/HG plumbing for the dropped SV_Target1 — not needed in URP.)
        // ============================================================================================
        Pass {
            Name "ForwardLit"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend], One OneMinusSrcAlpha   // littransparent.shader:182 (RGB src/dst bound; alpha One,OneMinusSrcAlpha)
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace } // littransparent.shader:188-194
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitVertex
                #pragma fragment LitForwardFragment
                // material feature keywords (HGRP multi_compile_local -> URP shader_feature_local). Base = none set.
                #pragma shader_feature_local _TWO_BASEMAP
                #pragma shader_feature_local _MATCAP
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma shader_feature_local _SIMPLE_VERTEXANIM
                #pragma shader_feature_local _SIMPLE_VERTEXANIM_CLOTH
                // URP system keywords
                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH
                #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
                #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BOX_PROJECTION
                #pragma multi_compile_fog
                #pragma multi_compile_instancing

                half4 LitForwardFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                    LitSurfaceData s = LitBuildSurface(IN, isFrontFace);
                    return LitForwardLighting(s, IN);
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2: ShadowCaster  (littransparent Sub0_Pass1 — LIGHTMODE "SHADOWCASTER", fragment b118 EMPTY).
        //   b117:325-328 clips through dedicated shadow-VP with bias baked CPU-side -> URP ApplyShadowBias +
        //   TransformWorldToHClip + ApplyShadowClamping (CORE_MATH §4.1, mirrors URP GetShadowPositionHClip).
        //   Base fragment writes nothing (depth-only); alpha-clip only under _ALPHATEST_ON (base has none).
        // ============================================================================================
        Pass {
            Name "ShadowCaster"
            Tags { "LightMode"="ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_CullMode]                                       // littransparent.shader:519 (ShadowCaster binds _CullMode, NOT a separate shadow-cull prop)
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitShadowVertex
                #pragma fragment LitShadowFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma shader_feature_local _TWO_BASEMAP
                #pragma shader_feature_local _SIMPLE_VERTEXANIM
                #pragma shader_feature_local _SIMPLE_VERTEXANIM_CLOTH
                #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW
                #pragma multi_compile_instancing

                float3 _LightDirection;
                float3 _LightPosition;

                Varyings LitShadowVertex(Attributes IN)
                {
                    Varyings OUT = (Varyings)0;
                    UNITY_SETUP_INSTANCE_ID(IN);
                    UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
                    UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);

                    float3 positionWS = TransformObjectToWorld(IN.positionOS);          // b117:329-331 world pos
                    float3 normalWS   = TransformObjectToWorldNormal(IN.normalOS);

                    #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                        float3 lightDirectionWS = normalize(_LightPosition - positionWS);
                    #else
                        float3 lightDirectionWS = _LightDirection;
                    #endif

                    // world -> shadow clip (b117:325-328 mul(_ShadowpassVP, worldPos)); URP folds bias into ApplyShadowBias.
                    OUT.positionCS = ApplyShadowClamping(TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDirectionWS)));
                    OUT.positionWS = positionWS;
                    OUT.normalWS   = normalWS;
                    OUT.tangentWS  = float4(TransformObjectToWorldDir(IN.tangentOS.xyz), IN.tangentOS.w * GetOddNegativeScale());
                    OUT.uv         = float4(IN.uv0, IN.uv1);
                    OUT.color      = IN.color;
                    OUT.viewDirWS  = GetWorldSpaceViewDir(positionWS);
                    OUT.fogFactor  = 0.0;
                    return OUT;
                }

                half4 LitShadowFragment(Varyings IN) : SV_Target
                {
                    // base ShadowCaster fragment b118 is EMPTY (depth-only); clip only under _ALPHATEST_ON (none in base).
                    #ifdef _ALPHATEST_ON
                        float2 uv0 = IN.uv.xy, uv1 = IN.uv.zw;
                        float duvX = uv1.x - uv0.x, duvY = uv1.y - uv0.y;
                        float2 uvBase = float2(mad(mad(_BaseUVSet, duvX, uv0.x), _BaseColorMap_ST.x, _BaseColorMap_ST.z),
                                               mad(mad(_BaseUVSet, duvY, uv0.y), _BaseColorMap_ST.y, _BaseColorMap_ST.w));
                        float a = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uvBase, 0.0).a * _BaseColor.a; // = _375
                        clip(a - _AlphaClipThreshold);
                    #endif
                    return 0;
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 3: ForwardReflection  (littransparent Sub0_Pass2 — LIGHTMODE "ForwardReflection"; fragment b127).
        //   The HG ForwardReflection fragment writes the WORLD-NORMAL (octahedral-encoded to [0,1]) in RG and linear
        //   ROUGHNESS in B (b127:106-108) — a normals+roughness output for a reflection-capture target.
        //   Source render-state (littransparent.shader:574-578): ColorMask RGB; ZClip On; Cull [_CullMode].
        //   Retargeted LightMode -> DepthNormalsOnly so URP SCHEDULES the pass. The frag MATH is 1:1 to b127, but the
        //   HG reflection-capture SLOT and its R/G/B(=roughness) packing have NO faithful URP consumer — see the
        //   TODO(1:1) in LitReflectionFragment for why this is left b127-exact rather than reshaped to URP oct packing.
        // ============================================================================================
        Pass {
            Name "ForwardReflection"
            Tags { "LightMode"="DepthNormalsOnly" }
            ColorMask RGB
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitVertex
                #pragma fragment LitReflectionFragment
                #pragma shader_feature_local _TWO_BASEMAP
                #pragma shader_feature_local _SIMPLE_VERTEXANIM
                #pragma shader_feature_local _SIMPLE_VERTEXANIM_CLOTH
                #pragma multi_compile_instancing

                // b127:84-108: rebuild per-pixel world normal (same TBN decode as ForwardLit), octahedral-encode to
                // [0,1] (b127:102-107), output roughness = lerp(RoughMin,RoughMax,MRO.g) in .z (b127:108).
                // -------------------------------------------------------------------------------------------------
                // TODO(1:1) ENGINE-SIDE: encode MATH is already 1:1 to b127:102-108 below; only the host render-graph
                //   SLOT is unmappable — HG "ForwardReflection" reflection-capture MRT (RG=octN, B=roughness) has no
                //   standalone-URP analog, and URP's _CameraNormalsTexture consumer expects a different layout.
                // SLOT/PACKING CONTRACT MISMATCH (unmappable — author flagged risk #1):
                //   HG "ForwardReflection" renders transparents into a REFLECTION-CAPTURE target with the b127 packing
                //   below (oct.x->R, oct.y->G, roughness->B). URP has NO equivalent render-graph slot. Retargeting to
                //   "DepthNormalsOnly" makes URP SCHEDULE the pass, but URP's _CameraNormalsTexture CONSUMER (SSAO,
                //   etc.) expects EITHER raw world-normal in RGB, OR (under _GBUFFER_NORMALS_OCT) PackFloat2To888 of
                //   the oct pair across all 3 channels with NO roughness slot (LitDepthNormalsPass.hlsl:128-133).
                //   This shader writes roughness in .B, so a URP oct-consumer WILL mis-decode the normal. The MATH is
                //   1:1 to b127; the SLOT is not reproducible in URP. Left faithful-to-b127 + flagged, NOT silently
                //   reshaped into URP's PackFloat2To888 (which would discard the roughness the HG slot carries).
                // OCTAHEDRAL AXES: b127 folds on N.y and projects (N.x, N.z) [Y-up oct]. URP PackNormalOctQuadEncode
                //   folds on N.z / projects (N.x, N.y) [Z-up oct] -> DIFFERENT RG values for the same normal. So the
                //   encode below is hand-rolled to match b127:102-107 EXACTLY (do NOT swap in PackNormalOctQuadEncode).
                // -------------------------------------------------------------------------------------------------
                half4 LitReflectionFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                    LitSurfaceData s = LitBuildSurface(IN, isFrontFace);          // normal (b127:84-101) + roughness (b127:108)
                    float3 N = normalize(s.normalWS);                            // b127:98-101 (_212-215)
                    float  l1 = dot(float3(1.0, 1.0, 1.0), abs(N));              // b127:102 (_219) = |Nx|+|Ny|+|Nz|
                    float  px = N.x / l1;                                        // b127:103 (_222)
                    float  pz = N.z / l1;                                        // b127:104 (_223)
                    bool   lowerHemi = (0.0 >= N.y);                             // b127:105 (_224) fold on N.y
                    // wrap: if N.y<=0, fold each component: comp = sign(other)*(1-|other|) (b127:106-107)
                    float  ex = lowerHemi ? (((px >= 0.0) ? 1.0 : -1.0) * (1.0 - abs(pz))) : px; // b127:106
                    float  ey = lowerHemi ? (((pz >= 0.0) ? 1.0 : -1.0) * (1.0 - abs(px))) : pz; // b127:107
                    float2 octN = float2(ex, ey) * 0.5 + 0.5;                    // b127:106-107 mad(...,0.5,0.5)
                    return half4(octN.x, octN.y, s.roughness, 0.0);              // b127:106-108 (RG=octN, B=roughness=_RoughnessMin..Max lerp)
                }
            ENDHLSL
        }
    }
}
