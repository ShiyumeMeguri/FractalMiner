// HGRP Blockout/LitPoly merged -> URP. ForwardLit + ShadowCaster + DepthOnly + DepthNormals.
// Merged from: HGRP/Blockout/LitPoly (single shader, blockout/litpoly.shader). Base variant = blobs
//   litpoly/Sub0_Pass0_Vertex_b1.hlsl  (HGBuffer vertex, catch-all #else)
//   litpoly/Sub0_Pass0_Fragment_b2.hlsl(HGBuffer fragment, catch-all #else)  <- GROUND TRUTH
// (b3/b4 deltas = LIGHTMAP_ON only; fragment body byte-identical to b2 — lightmap is a dropped infra
//  keyword, see Removed. So b2 alone is the full surface ground truth.)
//
// What LitPoly is: a stripped "blockout" Lit. Its WHOLE per-material cbuffer is 5 fields
//   (_NormalScale,_RoughnessMin,_RoughnessMax,_OcclusionStrength,_BaseColor; b2:20-27). It has NO
//   _Metallic/_Specular/_BaseTextureMapCount/_BaseColorBrighterScale/_BaseColorTintCover, NO UV-set
//   lerp and NO texture _ST tiling (samples TEXCOORD raw, b2:90/95/123). 3 maps only:
//   T0=BaseColor (LinearClamp), T1=Normal (LinearRepeat), T2=MRO (LinearMirror) (b2:29-34).
//
// Keywords: (none material-facing). Source only declares infra multi_compile_local
//   _ HG_ENABLE_MV / _ SRP_INSTANCING_ON / _ LIGHTMAP_ON — all DROPPED (Removed). LitPoly exposes
//   ZERO shader_feature that changes surface math, so this _Fix carries none.
// Kept (1:1): base PBR surface — albedo = baseTex.rgb*_BaseColor.rgb*vertexColor.rgb (b2:124-126),
//   DXT5nm normal decode (x in .a) *_NormalScale + TBN world normal + UNCONDITIONAL back-face flip
//   (b2:96-115; gl_FrontFacing?n:-n, NO _TwoSidedNormal gate — blockout always two-sided),
//   metallic = MRO.r raw (b2:92), roughness = lerp(_RoughnessMin,_RoughnessMax,MRO.g)
//   (b2:93), occlusion = lerp(1,MRO.b,_OcclusionStrength) (b2:91). Lighting = the HGRP Lit forward
//   PBR (GGX-D + Smith height-correlated Vis + Schlick F + multiscatter-diffuse energy + analytic
//   EnvBRDF ambient), 1:1 from litforward/Sub0_Pass0_Fragment_b9.hlsl per CORE_MATH §2.3/§2.6/§2.7.
// Removed (pixel-neutral pipeline infra, substituted by URP — CORE_MATH §2.12): GPU skinning +
//   octahedral-packed vertex normal/tangent (b1:142-213), SRP instancing per-draw buffer, HG
//   motion-vector dual-clip MRT (b1:251-289 / SV_Target1), HG deferred 5-MRT GBuffer (b2 writes 5
//   MRTs with NO lighting — re-authored as URP ForwardLit per CORE_MATH §1.4 PORT GUIDANCE), lightmap
//   (LIGHTMAP_ON), IV-clipmap GI -> SampleSH, reflection-probe binning -> GlossyEnvironmentReflection,
//   CSM/ASM shadow atlas -> URP main-light shadow, froxel fog -> MixFog.
//
// NOTE: LitPoly's GBuffer fragment (b2) packs surface params with NO _Specular/_Metallic uniforms.
//   For the FORWARD lighting model (CORE_MATH §2.3 F0 = lerp(0.08*_Specular, albedo, metallic)) we
//   expose _Specular (default 0.5 -> 0.08*0.5 = 0.04 = standard dielectric F0) so the lit response is
//   the faithful HGRP-Lit BRDF; metallic stays raw MRO.r (no slider — LitPoly has none).
// Texture-channel legends: _MROMap RGB = Metallic, Roughness, Occlusion (b2:92/93/91).
//   _NormalMap DXT5nm (X in .a, Y in .g) (b2:96-97). Vertex COLOR.rgb multiplies albedo (b2:124-126).

Shader "HGRP/Blockout/LitPoly_Fix"
{
    Properties
    {
        // ---- Blend-state plumbing (set by CustomEditor / presets via _SurfaceType; STYLE_BIBLE §6) ----
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [Enum(Both, 0, Back, 1, Front, 2)] _Cull ("Render Face", Float) = 2          // source _CullMode default 2=Front (litpoly.shader:42)
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 0
        [HideInInspector] _ShadowCullMode ("Shadow Cull Mode", Float) = 2
        [HideInInspector] _StencilRef ("Stencil Ref", Float) = 0                     // source _StencilRef (litpoly.shader:46)

        // ---- Core surface / base PBR (the WHOLE LitPoly material cbuffer, b2:20-27) ----
        _BaseColorMap ("Base Color Map", 2D) = "white" {}                            // T0 (b2:29, LinearClamp)
        _BaseColor ("Base Color", Color) = (1, 1, 1, 1)                              // b2:26 _BaseColor
        _NormalMap ("Normal Map (DXT5nm)", 2D) = "bump" {}                           // T1 (b2:30, LinearRepeat)
        _MROMap ("MRO Map (Metallic,Roughness,Occlusion)", 2D) = "white" {}          // T2 (b2:31, LinearMirror)
        _NormalScale ("Normal Scale", Range(0, 2)) = 1                               // b2:22 _NormalScale (source Range(0,2), litpoly.shader:15)
        // NOTE: source declares _TwoSidedNormal (litpoly.shader:16) but the compiled base blob b2 does
        // NOT consume it (cbuffer b2:20-27 has no such field; back-face flip b2:108-111 is unconditional).
        // Dropped as a dead property — including it would falsely imply it gates the normal flip.
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0                             // b2:23
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1                             // b2:24
        _OcclusionStrength ("Occlusion Strength", Range(0, 1)) = 1                   // b2:25
        _Specular ("Specular", Range(0, 1)) = 0.5                                    // re-exposed: F0 base 0.08*_Specular (CORE_MATH §2.3); LitPoly GBuffer omits it (default 0.5)

        // ---- Alpha clip (LitPoly base has none; exposed neutral-off for ShadowCaster/DepthOnly parity, STYLE_BIBLE §6) ----
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Enable Alpha Test", Float) = 0
        _AlphaClipThreshold ("Alpha Clip Threshold", Range(0, 1)) = 0.5

        // ---- Advanced / infra ----
        _TAAUNormalBiasReverse ("TAAU Normal Bias Reverse", Float) = 0               // source litpoly.shader:44; INERT — LitPoly's b2 cbuffer (b2:20-27) does NOT consume it (unlike full-Lit b9 §2.2). Kept as inert uniform to match source property surface; wired to no sample.

        // ---- Environment / Exposure (HGRP globals re-exposed as material Vectors; STYLE_BIBLE §1.5 / §2) ----
        [Header(Environment Params)]
        _EnvironmentGlobalParams0 ("EnvGlobalParams0 (.x=ambient .y=reflection intensity)", Vector) = (1, 1, 1, 0)
        _ExposureParams ("ExposureParams (.x=exposure)", Vector) = (1, 0, 0, 0)
    }

    SubShader
    {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Opaque" }
        LOD 600

        HLSLINCLUDE
            // ============================================================
            // URP infrastructure (substitutes for all HGRP hand-rolled globals — CORE_MATH §2.12)
            // ============================================================
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"

            // ============================================================
            // UnityPerMaterial — LitPoly's whole material cbuffer (b2:20-27) + URP _ST/blend plumbing
            // + re-exposed HGRP env globals. NO packoffset (SPIRV-Cross artifact; STYLE_BIBLE §1.5).
            // ============================================================
            CBUFFER_START(UnityPerMaterial)
                float _SrcBlend;
                float _DstBlend;
                float _ZWrite;
                float _ZTest;
                float _Cull;
                float _SurfaceType;
                float _ShadowCullMode;
                float _StencilRef;

                float4 _BaseColor;            // b2:26
                float4 _BaseColorMap_ST;      // URP tiling (LitPoly samples raw -> default (1,1,0,0))
                float4 _NormalMap_ST;
                float4 _MROMap_ST;
                float  _NormalScale;          // b2:22
                float  _RoughnessMin;         // b2:23
                float  _RoughnessMax;         // b2:24
                float  _OcclusionStrength;    // b2:25
                float  _Specular;             // re-exposed F0 base (CORE_MATH §2.3)
                float  _AlphaClipThreshold;
                float  _TAAUNormalBiasReverse;

                float4 _EnvironmentGlobalParams0;
                float4 _ExposureParams;
            CBUFFER_END

            // ============================================================
            // Textures — LitPoly's 3 maps (b2:29-34). Wrap modes per source sampler binding:
            //   _BaseColorMap = sampler_LinearClamp (b2:32), _NormalMap = sampler_LinearRepeat (b2:33),
            //   _MROMap = sampler_LinearMirror (b2:34). Wrap behavior is set on the import asset; the
            //   per-texture SAMPLER() below is the URP infra substitute (CORE_MATH §0.3).
            // ============================================================
            TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);   // T0 albedo  (b2:123, LinearClamp)
            TEXTURE2D(_NormalMap);      SAMPLER(sampler_NormalMap);      // T1 normal  (b2:95,  LinearRepeat)
            TEXTURE2D(_MROMap);         SAMPLER(sampler_MROMap);         // T2 MRO     (b2:90,  LinearMirror)

            // ============================================================
            // §0.4 Decoded magic-constant table (denormalized float bit patterns -> real values).
            //   Algorithm boundaries (epsilons / luma / grazing floor / dielectric-F0 base), EXACT.
            //   Source: b2 (surface) + b9 (lighting), decoded per CORE_MATH §0.4.
            // ============================================================
            static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709 luma, b9:1328
            static const float  EPS_VIEWLEN  = 9.9999999392252902907785028219223e-09; // = 1e-8  ; rsqrt/denominator guard (b2:79/80, b9:277)
            static const float  EPS_NORMAL_Z = 1.000000016862383526387164645044e-16;  // = 1e-16 ; derived tangent-normal Z floor (b2:100, b9:441)
            static const float  EPS_NORMALIZE= 1.1754943508222875079687365372222e-38; // = FLT_MIN; world-normal rsqrt guard (b2:104, b9:457)
            static const float  EPS_VIS      = 9.9999997473787516355514526367188e-05;  // = 1e-4  ; Smith-visibility denominator floor (b9:981)
            static const float  DIELECTRIC_F0= 0.07999999821186065673828125;           // = 0.08  ; dielectric F0 base = 0.08*_Specular (b9:318)
            static const float  GRAZING_FLOOR= 0.0476190485060214996337890625;         // = 1/21  ; multiscatter-diffuse grazing floor (b9:977-979)

            struct LitPolySurface
            {
                float3 albedo;       // baseTex.rgb*_BaseColor.rgb*vertexColor.rgb (b2:124-126)
                float3 normalWS;     // world normal after TBN + unconditional back-face flip (b2:101-115)
                float  metallic;     // MRO.r raw (b2:92)
                float  roughness;    // lerp(_RoughnessMin,_RoughnessMax,MRO.g), linear (b2:93)
                float  occlusion;    // lerp(1,MRO.b,_OcclusionStrength) (b2:91)
                float  alpha;        // surface alpha (LitPoly opaque base = 1; sampled BaseColor.a for transparent)
                float3 f0;           // lerp(0.08*_Specular, albedo, metallic) (CORE_MATH §2.3)
            };

            // ============================================================
            // §2.6 Karis/Lazarov analytic ENVIRONMENT-BRDF (b9:326-329,1261). HG "specular DFG"
            //   pre-integration gating the ambient (probe) reflection. The 2D DFG split-sum LUT (T9)
            //   is engine infra with no URP binding -> this analytic form is its sanctioned substitute
            //   (CORE_MATH §2.6 / §2.12). Poly coeffs are LOAD-BEARING — copied exact.
            //     envF        (_536) = min((1-rough)^2, exp2(-9.28*NoV))*(1-rough) + (rough*-0.0275+0.0425)
            //     envSpecScale(_537) = envF*-1.04 + (rough*-0.572+1.04)
            //     envSpecBias (_3103)= (envF*1.04 + (rough*0.022-0.04)) * saturate(F0.g*50)
            // ============================================================
            void EnvBRDF(float roughness, float NoV, float3 f0, out float envSpecScale, out float envSpecBias)
            {
                float oneMinusRough = mad(roughness, -1.0, 1.0);                                                // 1-rough, b9:326 (_520)
                float envF = mad(min(oneMinusRough * oneMinusRough, exp2(NoV * -9.27999973297119140625)),
                                 oneMinusRough,
                                 mad(roughness, -0.0274999998509883880615234375, 0.0425000004470348358154296875)); // b9:328 (_536)
                envSpecScale = mad(envF, -1.03999996185302734375,
                                   mad(roughness, -0.572000026702880859375, 1.03999996185302734375));           // b9:329 (_537)
                envSpecBias = mad(envF, 1.03999996185302734375,
                                  mad(roughness, 0.02199999988079071044921875, -0.039999999105930328369140625))
                              * saturate(f0.g * 50.0);                                                          // b9:1261 (_3103)
            }

            // §2.6 EnvBRDFApprox rational DFG scale (b9:974-975 _2174/_2183) — feeds the direct-light
            //   MULTISCATTER diffuse energy. Coeffs 1:1 load-bearing (CORE_MATH §2.6).
            //     t   = 1 - roughness
            //     dfg = min( t*(t*((-t)*0.38302600 - 0.07619470) + 1.04997003) + 0.40925499, 0.999 )
            float EnvBRDFApproxDFG(float roughness)
            {
                float t = mad(roughness, -1.0, 1.0);                              // 1-rough, b9:974 (_2174)
                return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875,      // b9:975 (_2183)
                                              -0.076194703578948974609375),
                                        1.04997003078460693359375),
                               0.4092549979686737060546875),
                           0.999000012874603271484375);
            }

            // §2.7/§2.8 Cook-Torrance GGX-D + Smith height-correlated Vis + Schlick F (b9:964-983).
            //   Shared by main + additional lights (HG re-derives identical D/Vis/F in the punctual
            //   loop, b9:1220-1234). Returns specular RGB (NOT yet *NoL).
            //     a=rough*rough ; a2=a*a ; nv=min(NoV,1)
            //     d = (NoH*a2 - NoH)*NoH + 1 ; D = a2/(d*d)
            //     Vis = 0.5 / ( nv*sqrt((-NoL*a2+NoL)*NoL+a2) + NoL*sqrt((-nv*a2+nv)*nv+a2) + 1e-4 )
            //     Fc = (1-VoH)^5 ; F = lerp(F0,1,Fc)
            float3 DirectSpecular(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float a   = roughness * roughness;                               // b9:967 (_2159)
                float a2  = a * a;                                              // b9:968 (_2160)
                float nv  = min(NoV, 1.0);                                      // b9:966 (_2158)

                float d   = mad(mad(NoH, a2, -NoH), NoH, 1.0);                  // (NoH*a2-NoH)*NoH+1, b9:969 (_2163)
                float visDenom = nv  * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2))   // nv*sqrt((-NoL*a2+NoL)*NoL+a2)
                               + NoL * sqrt(mad(mad(-nv,  a2, nv ), nv , a2))   // NoL*sqrt((-nv*a2+nv)*nv+a2)
                               + EPS_VIS;
                float DV  = (a2 / (d * d)) * (0.5 / visDenom);                  // D*Vis, b9:981 (_2217)

                float oneMinusVoH = mad(-VoH, 1.0, 1.0);                        // 1-VoH, b9:970 (_2169)
                float sq   = oneMinusVoH * oneMinusVoH;                         // (1-VoH)^2, b9:971
                float quad = sq * sq;                                          // (1-VoH)^4, b9:972
                float Fc   = oneMinusVoH * quad;                              // (1-VoH)^5, b9:973 (_2172)
                float oneMinusFc = mad(-quad, oneMinusVoH, 1.0);             // 1-(1-VoH)^5, b9:980
                float3 F   = mad(f0, oneMinusFc.xxx, Fc.xxx);                // lerp(F0,1,Fc), b9:983

                return DV * F;
            }

            // §2.7/§2.8 Full per-light energy bracket (b9:983 _2283..2285), re-derived per light in the
            //   punctual loop (b9:1232-1234). Returned value is multiplied by NoL & lightColor at the
            //   call site. msDiff = multiscatter-diffuse; specE clamped 2048; bracket clamped [0,1000].
            float3 DirectLightEnergy(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float3 specE = DirectSpecular(roughness, f0, NoL, NoH, NoV, VoH);      // (D*Vis)*F, b9:981·983
                float  dfg   = EnvBRDFApproxDFG(roughness);                           // analytic DFG, b9:975
                float  oneMinusDfg = mad(-dfg, 1.0, 1.0);                             // 1-dfg, b9:976
                float  dfgEnergy = dfg / oneMinusDfg;                                 // analytic _2240 (T9 product -> dfg)
                float3 gz    = mad((float3(1.0, 1.0, 1.0) - f0), GRAZING_FLOOR, f0);  // lerp(F0,1,1/21), b9:977-979
                float3 msDiff = (dfgEnergy * (gz * gz)) / mad(-gz, oneMinusDfg, float3(1.0, 1.0, 1.0)); // b9:983 term A
                return min(max(msDiff + min(specE, 2048.0), 0.0), 1000.0);           // b9:983 min(max(...,0),1000)
            }

            // ============================================================
            // Varyings (worldPos + TBN + uv + vertex color + view dir + fog). HG dual-clip MV
            // interpolators (TEXCOORD5/6) DROPPED — URP MotionVectors pass owns them.
            // ============================================================
            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;       // vertex color (b1:282-285 -> b2:124-126 albedo mul)
                float2 uv0        : TEXCOORD0;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct Varyings
            {
                float4 positionCS : SV_Position;
                float3 positionWS : TEXCOORD0;
                float3 normalWS   : TEXCOORD1;
                float4 tangentWS  : TEXCOORD2;   // .xyz tangent, .w = handedness sign
                float2 uv         : TEXCOORD3;
                float4 color      : TEXCOORD4;   // vertex color rgba
                float3 viewDirWS  : TEXCOORD5;   // camera->fragment, unnormalized
                float  fogFactor  : TEXCOORD6;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                UNITY_VERTEX_OUTPUT_STEREO
            };

            // ============================================================
            // Vertex — object->world->clip + inverse-transpose normal / forward tangent basis
            //   (b1:217-289). HG GPU-skin (b1:142-213 oct path / skin), per-draw instancing buffer,
            //   and dual-frame MV output (b1:251-289) DROPPED per CORE_MATH §3.1-§3.4; URP's
            //   GetVertexPositionInputs / GetVertexNormalInputs are the faithful infra substitute.
            // ============================================================
            Varyings LitPolyVertex(Attributes IN)
            {
                Varyings OUT = (Varyings)0;
                UNITY_SETUP_INSTANCE_ID(IN);
                UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);

                VertexPositionInputs posInputs = GetVertexPositionInputs(IN.positionOS);        // b1:221-248 obj->world->clip
                VertexNormalInputs   nrmInputs = GetVertexNormalInputs(IN.normalOS, IN.tangentOS); // b1:233-268 inv-transpose normal + fwd tangent

                OUT.positionCS = posInputs.positionCS;
                OUT.positionWS = posInputs.positionWS;
                OUT.normalWS   = nrmInputs.normalWS;
                // tangent.w handedness (b1:269 = sign(WorldTransformParams.w) * TANGENT.w) -> odd-negative-scale.
                OUT.tangentWS  = float4(nrmInputs.tangentWS, IN.tangentOS.w * GetOddNegativeScale());
                OUT.uv         = TRANSFORM_TEX(IN.uv0, _BaseColorMap);   // LitPoly samples raw (b2:90/95/123); _ST default (1,1,0,0)
                OUT.color      = IN.color;                              // b1:282-285 COLOR passthrough
                OUT.viewDirWS  = GetWorldSpaceViewDir(posInputs.positionWS); // b9:196-211 camPos-P (ortho resolved by URP)
                OUT.fogFactor  = ComputeFogFactor(posInputs.positionCS.z);
                return OUT;
            }

            // ============================================================
            // Surface assembly — 1:1 b2:90-127 (the LitPoly GBuffer surface, NO lighting in source).
            // ============================================================
            LitPolySurface BuildLitPolySurface(Varyings IN, bool isFrontFace)
            {
                LitPolySurface s = (LitPolySurface)0;

                float2 uv = IN.uv;

                // ---- MRO (T2, LinearMirror) ; metallic/roughness/occlusion (b2:90-93) ----
                // URP SAMPLE_TEXTURE2D_BIAS auto-adds _GlobalMipBias.x = HG "sample at _GlobalMipBias".
                float4 mro = SAMPLE_TEXTURE2D_BIAS(_MROMap, sampler_MROMap, uv, 0.0);          // b2:90 (_147)
                float metallic   = mro.x;                                                      // b2:92 (MRT2.x = _147.x), raw
                float roughness  = mad(mro.y, (-_RoughnessMin) + _RoughnessMax, _RoughnessMin); // b2:93 lerp(Min,Max,MRO.g)
                float occlusion  = mad(mro.z, _OcclusionStrength, 1.0 - _OcclusionStrength);    // b2:91 lerp(1,MRO.b,_OcclusionStrength)

                // ---- Normal (T1, LinearRepeat) ; DXT5nm decode x in .a (b2:95-99) ----
                // b2:95 samples T1 at PLAIN _GlobalMipBias (NO _TAAUNormalBiasReverse — LitPoly's b2
                // cbuffer (b2:20-27) has no such field; the +_TAAUNormalBiasReverse-on-normal idiom is
                // the FULL-Lit b9 path (CORE_MATH §2.2), which LitPoly stripped). Bias 0.0 = _GlobalMipBias.
                float4 nrm = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap, uv, 0.0); // b2:95 (_222), plain _GlobalMipBias
                float nx = mad(nrm.x * nrm.w, 2.0, -1.0);            // b2:96 (_228)  (x in .a * .x trick)
                float ny = mad(nrm.y,         2.0, -1.0);            // b2:97 (_231)
                float nxs = nx * _NormalScale;                      // b2:98 (_235)
                float nys = ny * _NormalScale;                      // b2:99 (_236)

                // ---- tangent-space Z (b2:100): max(sqrt(1 - min(dot(nx,ny . nx,ny),1)), 1e-16) ----
                float nz = max(sqrt(((-0.0) - min(dot(float2(nx, ny), float2(nx, ny)), 1.0)) + 1.0), EPS_NORMAL_Z); // b2:100 (_244)

                // ---- tangent handedness from TEXCOORD_3.w sign (b2:94 _177 = sign(tangent.w)) ----
                float bitSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;                            // b2:94 (_177)

                // ---- world normal via TBN (b2:101-103). B = bitSign * cross(N,T); the blob spells the
                //      cross component-wise (e.g. _264.bit = _177 * (Ny*Tz - Nz*Ty)) — that is exactly
                //      bitSign*cross(normalGeo, tangent). N = N*nz + T*nxs + bitangent*nys. ----
                float3 N0 = IN.normalWS;
                float3 T0 = IN.tangentWS.xyz;
                float3 bitangent = bitSign * cross(N0, T0);                                     // b2:101-103 (_177*cross terms)
                float3 nWS = N0 * nz + T0 * nxs + bitangent * nys;                              // b2:101-103 (_264,_265,_266)
                // normalize with FLT_MIN guard (b2:104 _272), THEN the back-face flip (b2:108-111):
                nWS = nWS * rsqrt(max(dot(nWS, nWS), EPS_NORMALIZE));                            // b2:104-107 (_272..275)
                // frontSign: front face -> +N; back face -> flip the WHOLE world normal (b2:108-111 _282..284).
                // UNCONDITIONAL flip: b2 is `gl_FrontFacing ? n : -n` with NO _TwoSidedNormal gate (the
                // LitPoly cbuffer has no such field, b2:20-27) — blockout always treats back faces as
                // two-sided. (Contrast the full Lit, which gates on _TwoSidedNormal; LitPoly does NOT.)
                float frontSign = isFrontFace ? 1.0 : -1.0;
                nWS *= frontSign;
                nWS = normalize(nWS);                                                           // b2:112-115 (_288 re-normalize)

                // ---- albedo (T0, LinearClamp) * _BaseColor * vertex COLOR (b2:123-126) ----
                float4 baseTex = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uv, 0.0); // b2:123 (_336)
                float3 albedo = baseTex.rgb * _BaseColor.rgb * IN.color.rgb;                    // b2:124-126 (no saturate/brighter/tint — LitPoly)

                // ---- F0 / specular split (CORE_MATH §2.3; LitPoly has no _Specular in GBuffer -> default 0.5) ----
                float dielF0 = DIELECTRIC_F0 * _Specular;                                       // 0.08*_Specular, b9:318
                float3 f0 = lerp(dielF0.xxx, albedo, metallic);                                 // lerp(0.08*_Spec, albedo, metallic), b9:322-325

                s.albedo    = albedo;
                s.normalWS  = nWS;
                s.metallic  = metallic;
                s.roughness = roughness;
                s.occlusion = occlusion;
                s.f0        = f0;
                s.alpha     = (_SurfaceType == 1.0) ? baseTex.a : 1.0;                          // opaque base writes 1 (STYLE_BIBLE §6)
                return s;
            }

            // ============================================================
            // Forward lighting composite — 1:1 b9:1325-1343 (HG IV-GI -> SampleSH, probe-binning ->
            // GlossyEnvironmentReflection, CSM/ASM -> URP main-light shadow, froxel fog -> MixFog,
            // SV_Target1 MV pack dropped). LitPoly's surface feeds this faithful HGRP-Lit BRDF.
            //   color = diffuse*SH(N)*occlusion*envParams0.x  (term A, b9:1325)
            //         + reflection*(F0*envSpecScale+envSpecBias)*envParams0.y  (term B, b9:1325)
            //         + mainLight  + additionalLights
            //         then MixFog ; out = half4(color, alpha)
            // ============================================================
            half4 LitPolyForwardLighting(LitPolySurface s, Varyings IN)
            {
                float3 N = normalize(s.normalWS);
                float3 P = IN.positionWS;

                // view dir V (world): perspective normalize(camPos-P); ortho -camFwd (URP resolves) (b9:271-280).
                float3 viewRaw = IN.viewDirWS;
                float  invLen  = rsqrt(max(dot(viewRaw, viewRaw), EPS_VIEWLEN));                // b9:277 (_207)
                float3 V = viewRaw * invLen;                                                    // b9:278-280

                float  roughness = s.roughness;
                float3 f0        = s.f0;
                float3 diffuse   = s.albedo * (1.0 - s.metallic);                              // baseCol*(1-metallic), b9:319-321
                float  occlusion = s.occlusion;
                float  NoV       = max(dot(N, V), 0.0);                                        // b9:327 (_531)

                // ---- §2.6 EnvBRDF (F0 scale/bias for ambient reflection) ----
                float envSpecScale, envSpecBias;
                EnvBRDF(roughness, NoV, f0, envSpecScale, envSpecBias);                         // b9:326-329,1261

                // ---- §2.4 ambient diffuse: IV-clipmap SH -> URP SampleSH(N) ; §2.5 reflection -> URP probe ----
                float3 ambientSH = SampleSH(N);                                                // b9:575-577 -> SampleSH
                float  perceptualRoughness = saturate(roughness);                              // s.roughness IS perceptual (a=rough^2 in DirectSpecular); no extra sqrt (CORE_MATH §2.5)
                float3 reflectVec = reflect(-V, N);                                            // R = reflect(-V,N), b9:578-582
                float3 reflection = GlossyEnvironmentReflection(reflectVec, perceptualRoughness, 1.0); // occlusion=1: HG term B not AO-occluded (CORE_MATH §2.5)

                float3 color = diffuse * ambientSH * occlusion * _EnvironmentGlobalParams0.x            // term A, b9:1325
                             + reflection * (f0 * envSpecScale + envSpecBias) * _EnvironmentGlobalParams0.y; // term B, b9:1325

                // ---- §2.7 direct MAIN (directional) light: HG CSM/ASM -> URP main-light shadow ----
                float4 shadowCoord = TransformWorldToShadowCoord(P);
                Light mainLight = GetMainLight(shadowCoord, P, half4(1, 1, 1, 1));
                float mainAtten = mainLight.distanceAttenuation * mainLight.shadowAttenuation; // -> _1897 shadow, b9:938
                {
                    float3 L = mainLight.direction;                                            // -_LightDataBuffer dir, b9:944
                    float3 H = normalize(L + V);                                               // b9:957-963
                    float NoL = saturate(dot(L, N));                                          // b9:964 (_2153)
                    float NoH = saturate(dot(N, H));                                          // b9:965 (_2157)
                    float VoH = saturate(dot(V, H));                                          // b9:970 (dot(V,H))
                    float3 energy = DirectLightEnergy(roughness, f0, NoL, NoH, NoV, VoH);       // §2.7, b9:975-983
                    color += mad(energy, NoL, diffuse * NoL) * (mainAtten * mainLight.color);   // b9:983 (energy*NoL + diffuse*NoL)*lightColor
                }

                // ---- §2.8 additional (punctual) lights: HG tile/zbin -> URP GetAdditionalLight loop ----
            #if defined(_ADDITIONAL_LIGHTS)
                uint addCount = GetAdditionalLightsCount();
                for (uint li = 0u; li < addCount; ++li)
                {
                    Light light = GetAdditionalLight(li, P, half4(1, 1, 1, 1));
                    float3 L = light.direction;
                    float3 H = normalize(L + V);
                    float NoL = saturate(dot(L, N));
                    float NoH = saturate(dot(N, H));
                    float VoH = saturate(dot(V, H));
                    float3 energy = DirectLightEnergy(roughness, f0, NoL, NoH, NoV, VoH);       // same BRDF re-derived per light, b9:1228-1234
                    float atten = light.distanceAttenuation * light.shadowAttenuation;
                    color += mad(energy, NoL, diffuse * NoL) * (atten * light.color);
                }
            #endif

                // ---- §2.10 fog: HG atmosphere+exp+volumetric -> URP MixFog ----
                color = MixFog(color, IN.fogFactor);

                return half4(color, s.alpha);                                                  // b9:1340-1343 (_349 alpha)
            }

            // Alpha-clip helper (LitPoly base has NO clip; lives under _ALPHATEST_ON only, STYLE_BIBLE §6).
            void LitPolyAlphaClip(Varyings IN)
            {
            #ifdef _ALPHATEST_ON
                float a = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, IN.uv, 0.0).a * _BaseColor.a;
                clip(a - _AlphaClipThreshold);
            #endif
            }
        ENDHLSL

        // ============================================================================================
        // Pass 1: ForwardLit  (LitPoly's HGBuffer surface resolved as URP forward — CORE_MATH §1.4 PORT
        //   GUIDANCE: the HG 5-MRT deferred GBuffer (b2) is NOT a URP GBuffer; re-author as ForwardLit.)
        //   Source HGBuffer render-state: ZTest [_ZTestGBuffer], Cull [_CullMode], Stencil Ref Replace
        //   (litpoly.shader:59-68).
        // ============================================================================================
        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] OneMinusSrcAlpha
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_Cull]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }   // source HGBuffer stencil (litpoly.shader:62-68)
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitPolyVertex
                #pragma fragment LitPolyForwardFragment
                // URP system keywords (LitPoly material-facing keywords: none).
                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH
                #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
                #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BOX_PROJECTION
                #pragma multi_compile_fragment _ _SCREEN_SPACE_OCCLUSION
                #pragma multi_compile_fog
                #pragma multi_compile_instancing

                half4 LitPolyForwardFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                    LitPolySurface s = BuildLitPolySurface(IN, isFrontFace);
                    return LitPolyForwardLighting(s, IN);
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2: ShadowCaster  (source pass "ShadowCaster" LIGHTMODE=SHADOWCASTER, empty fragment
        //   b7; litpoly.shader:112-288 / CORE_MATH §4.1-§4.2). Position-only + URP ApplyShadowBias.
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
                #pragma vertex   LitPolyShadowVertex
                #pragma fragment LitPolyShadowFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW
                #pragma multi_compile_instancing

                float3 _LightDirection;
                float3 _LightPosition;

                Varyings LitPolyShadowVertex(Attributes IN)
                {
                    Varyings OUT = (Varyings)0;
                    UNITY_SETUP_INSTANCE_ID(IN);
                    UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
                    UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);

                    float3 positionWS = TransformObjectToWorld(IN.positionOS);     // b1 obj->world (shadow uses _ShadowpassVP; URP ApplyShadowBias is the faithful substitute, CORE_MATH §4.1)
                    float3 normalWS   = TransformObjectToWorldNormal(IN.normalOS);

                    #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                        float3 lightDirWS = normalize(_LightPosition - positionWS);
                    #else
                        float3 lightDirWS = _LightDirection;
                    #endif

                    OUT.positionCS = ApplyShadowClamping(TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDirWS)));
                    OUT.positionWS = positionWS;
                    OUT.normalWS   = normalWS;
                    OUT.tangentWS  = float4(TransformObjectToWorldDir(IN.tangentOS.xyz), IN.tangentOS.w * GetOddNegativeScale());
                    OUT.uv         = TRANSFORM_TEX(IN.uv0, _BaseColorMap);
                    OUT.color      = IN.color;
                    OUT.viewDirWS  = GetWorldSpaceViewDir(positionWS);
                    OUT.fogFactor  = 0.0;
                    return OUT;
                }

                half4 LitPolyShadowFragment(Varyings IN) : SV_Target
                {
                    LitPolyAlphaClip(IN);   // no-op unless _ALPHATEST_ON (b7 fragment is EMPTY)
                    return 0;
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 3: DepthOnly  (source pass "DepthOnly" LIGHTMODE=DepthOnly, empty fragment b10;
        //   litpoly.shader:289-461 / CORE_MATH §4.3-§4.4). Camera clip + depth write. Stencil Replace.
        // ============================================================================================
        Pass
        {
            Name "DepthOnly"
            Tags { "LightMode"="DepthOnly" }
            ZWrite On
            ZTest LEqual
            ColorMask R
            Cull [_Cull]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }   // source DepthOnly stencil (litpoly.shader:293-299)
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitPolyVertex
                #pragma fragment LitPolyDepthFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma multi_compile_instancing

                half4 LitPolyDepthFragment(Varyings IN) : SV_Target
                {
                    LitPolyAlphaClip(IN);   // no-op unless _ALPHATEST_ON (b10 fragment is EMPTY)
                    return 0;
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 4: DepthNormalsOnly  (URP SSAO / depth-normals prepass — STYLE_BIBLE §7. LitPoly's source
        //   DepthOnly carried no normal output; URP's prepass needs the per-pixel world normal, which
        //   the b2 surface (DXT5nm decode + TBN + two-sided) reconstructs identically.)
        // ============================================================================================
        Pass
        {
            Name "DepthNormalsOnly"
            Tags { "LightMode"="DepthNormalsOnly" }
            ZWrite On
            ZTest LEqual
            Cull [_Cull]
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitPolyVertex
                #pragma fragment LitPolyDepthNormalsFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma multi_compile_instancing

                half4 LitPolyDepthNormalsFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                    LitPolyAlphaClip(IN);
                    LitPolySurface s = BuildLitPolySurface(IN, isFrontFace);
                    return half4(NormalizeNormalPerPixel(s.normalWS), 0.0);
                }
            ENDHLSL
        }
    }
}
