// HGRP Tree-Foliage Billboard-LOD shader merged -> URP. ForwardLit + ShadowCaster + DepthOnly + DepthNormals.
// Merged from: treefoliagebillboardlod.shader (HGRP/Foliage/TreeFoliageBillboardLod). Base (#else) variant blobs:
//   Sub0_Pass0 HGBuffer  : Vertex_b3 / Fragment_b4   (surface assembly — the ground truth for this port)
//   Sub0_Pass1 ShadowCaster: Vertex_b18 / Fragment_b19 (frag EMPTY)
//   Sub0_Pass2 DepthOnly : Vertex_b30 / Fragment_b31 (frag EMPTY)
// Captured permutation keyword set for THIS shader's dump = { HG_ENABLE_MV } only (it never added the
//   feature #pragmas), so its OWN blobs hold no feature bodies. Resolution by SIBLING dumps of the IDENTICAL
//   foliage codebase (grass/grasscardmeshlod/treefoliagecardmeshlod, which DO `multi_compile_local` them):
//   - _ALPHATEST_ON  -> CLOSED 1:1 from grass/Sub0_Pass1_Fragment_b87:83 == grass/Sub0_Pass2_Fragment_b123:81
//                       (clip baseTex.w < threshold). See FoliageAlphaClip.
//   - _BLEND_COLOR   -> cardmesh-IMPOSTOR-CAPTURE-only GBuffer albedo-source swap (writes NormalMap T0.rgb into
//                       the albedo MRT instead of computed albedo: treefoliagecardmeshlod/Fragment_b23:263-265
//                       vs _b21:193-195). NOT a runtime billboard-LOD visual term -> no ForwardLit analog (gaps).
//   - _BILLBOARD / _CLUSTERED_LEAF_FOLIAGE -> body in ZERO blobs PACKAGE-WIDE (no foliage shader ever compiles
//                       these keywords; _ClusterNormalDst is read in no compiled body). No ground-truth math
//                       exists to port -> left TODO with that reason (NOT engine-side, NOT a no-uniform punt).
//
// Keywords (this shader): _ALPHATEST_ON (leaf cutout — CLOSED 1:1, sibling blob), + URP system keywords
//   (_MAIN_LIGHT_SHADOWS*, _SHADOWS_SOFT*, _ADDITIONAL_LIGHTS*, _SCREEN_SPACE_OCCLUSION, fog).
//
// Kept (1:1, MATH/constants/branch-bounds/signs/swizzles — Fragment_b4):
//   - albedo: saturate(baseTex*_BaseColor*_BaseColorBrighterScale) tint-cover lerp, vertexColor.r raw-bypass (b4:177-187)
//   - foliage NORMAL reflect-trick decode: (2*nz*nx, 2*nz*ny, 2*nz^2-1)*_NormalScale(xy only), double normalize (b4:188-205)
//   - two-sided foliage face sign from front-face + vertexColor.r/.g + _TwoSidedNormal, applied to ts.xy AND final WN (b4:176,200-205,210-212)
//   - TBN world normal with bitangent = tangent.w-sign * cross(N,T) (b4:206-208)
//   - transmission distance-fade (object-pivot dist, 60..70 m, smoothstep, _TransmissionDistanceFade gate) (b4:213-217)
//   - transmission + perceptual roughness CardmeshCaptureMode branch (render: rough=lerp(min,max,0.8), trans=fade*NRM.b*_Transmission) (b4:218-229)
//   - occlusion lerp(1,NRM.a,_OcclusionStrength) then lerp(occ,NRM.a,vColor.r); occlusion-affects-shadow lerp(1,occ,_OcclusionShadow) (b4:230-231,256)
//   - fake directional shadow saturate(1 - _FakeDirectionalShadowStrength*(NdotL*0.5+0.5)^_FakeDirectionalShadowPow) (b4:257)
//   - translucency-toward-light saturate(dot(N, lightDir)), subsurface = _SubsurfaceIntensity*(1-vColor.r), backfaceGI = _backfaceGiIntensity*(1-vColor.r) (b4:261,239,252)
//   - lighting BRDF: HG Cook-Torrance GGX-D + Smith height-correlated Vis + Schlick F + EnvBRDF (verified exemplar CoreMath.hlsl == litforward/Fragment_b9:964-983,326-329)
//
// Removed (pixel-neutral pipeline infra, substituted by URP facilities — STYLE_BIBLE §2, NOT a deviation):
//   HG packed-octahedral vertex NORMAL/TANGENT decode (Vertex_b3:122-193) -> GetVertexNormalInputs;
//   HG billboard/instancing object->world via _f_0[] material-cbuffer matrix + _NonJitteredViewNoTransProjMatrix
//     (Vertex_b3:197-243) -> GetVertexPositionInputs / TransformWorldToHClip;
//   HG dual-frame motion-vector prev-clip output (Vertex_b3:237-242, Fragment_b4 TEXCOORD_5/_6 + SV_Target_1) -> dropped (URP MotionVectors pass);
//   HG deferred 5-MRT GBuffer pack (Fragment_b4:237-269 SV_Target/_1/_2/_3/_4 bit-packing) -> resolved in-fragment to URP ForwardLit color;
//   _GlobalMipBias (b4:177) -> URP folds it into SAMPLE_TEXTURE2D_BIAS automatically;
//   HG directional-light global _LightDataBuffer_DirectionalLightDirection (b4:48,257,261) -> GetMainLight();
//   ambient/reflection (deferred) -> SampleSH(N) + GlossyEnvironmentReflection; fog -> MixFog.
//
// NOTE (load-bearing): this is a DEFERRED foliage shader — Fragment_b4 only PACKS surface params into the HG
//   5-MRT GBuffer (b4:237-269); it contains NO lighting. The pass that CONSUMES those packed channels
//   (transmission / subsurface-profile / backfaceGI / fake-dir-shadow / translucency-NoL) is the fullscreen
//   `shaders/lighting/deferredlighting` shader — VERIFIED present in the package but ENGINE-SIDE: its blob
//   (deferredlighting/Sub0_Pass0_Fragment_b101) decodes the GBuffer using host-C#-filled StructuredBuffers
//   (light-binning ByteAddressBuffer b101:24, _LightDataBuffer[2054] b101:102, CSM shadow atlas b101:107,
//   IV-volume GI globals b101:64-69) — none producible by a material shader, so it is NOT ported here.
//   Per CORE_MATH §1.4 PORT GUIDANCE the faithful 1:1 VISUAL port re-authors the family as ForwardLit.
//   Therefore: every SURFACE quantity below is 1:1 (cited b4:line, incl. the b4:251 vColor.r roughness blend);
//   the foliage channel VALUES are 1:1, only their fold-into-radiance WEIGHTING is the engine-side deferred
//   pass's, reconstructed in the standard foliage-SSS manner and flagged TODO(1:1) (named host) + in gaps.
//   _NormalMap channels: RG = tangent normal, B = giBackfaceFromAO (roughness/transmission mask), A = SubsurfaceMultiplier (occlusion source).
//   F0 = 0.04 fixed dielectric: foliage has NO _Specular/_Metallic uniform and the GBuffer never writes metallic (b4 cbuffer:26-44).

Shader "HGRP/Foliage/TreeFoliageBillboardLod_Fix" {
    Properties {
        // ============================================================
        // Blend-state plumbing (opaque cutout; set by CustomEditor / presets)
        // ============================================================
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [Enum(Both, 0, Back, 1, Front, 2)] _ShadowCullMode ("Shadow Render Face", Float) = 2
        [HideInInspector] _ShadowBias ("Shadow Bias", Float) = 0
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _ZTestGBuffer ("__ztGBuffer", Float) = 4
        [HideInInspector] _PreDepthStencilRef ("Pre-Depth Stencil Ref", Float) = 5

        // ============================================================
        // Core surface / base PBR (always-on) — Fragment_b4
        // ============================================================
        _BaseColor ("Base Color", Color) = (1, 1, 1, 1)
        _BaseColorMap ("Base Color Map (RGB albedo, A cutout)", 2D) = "white" {}
        _BaseColorTintCover ("Base Color Tint Cover", Range(0, 1)) = 0
        _BaseColorBrighterScale ("Base Color Brighter Scale", Float) = 1
        _NormalMap ("Normal Map (RG normal, B giBackfaceFromAO, A subsurfaceMul)", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 3)) = 1
        [ToggleUI] _TwoSidedNormal ("Flip Back-Face Normal", Float) = 0
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1
        _OcclusionStrength ("Occlusion Strength", Range(0, 1)) = 1
        _OcclusionShadow ("Occlusion Affect Shadow", Range(0, 1)) = 0
        [HideInInspector] _DirectLightRoughnessOffset ("(Hack) Direct Light Roughness Offset", Range(-1, 1)) = 0

        // ============================================================
        // Backface scattering / subsurface (foliage translucency) — Fragment_b4
        // ============================================================
        [Header(Backface Scattering)]
        _SubsurfaceIntensity ("Subsurface Intensity", Range(0, 1)) = 0
        _Transmission ("Backface Transmission", Range(0, 1)) = 0.2
        [HideInInspector] _TransmissionDistanceFade ("Transmission Distance Fade", Float) = 0
        [HideInInspector] _backfaceGiIntensity ("Backface GI Intensity", Range(0, 1)) = 0
        [HideInInspector] _CardmeshCaptureMode ("Cardmesh Capture Mode", Float) = 0
        _FakeDirectionalShadowStrength ("Fake Directional Shadow Strength", Range(0, 1)) = 0
        _FakeDirectionalShadowPow ("Fake Directional Shadow Pow", Float) = 1

        // ============================================================
        // Alpha Test (leaf cutout) — [_ALPHATEST_ON]  (RECONSTRUCTED: clip absent from captured base blob — see TODO/gaps)
        // ============================================================
        [Header(Alpha Test)]
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Enable Alpha Test", Float) = 1
        _AlphaClipThreshold ("Clip Threshold", Range(0, 1)) = 0.5
        _ShadowAlphaClipThreshold ("Shadow Clip Threshold", Range(0, 1)) = 0.2

        // ============================================================
        // Feature toggles exposed for material parity. _BILLBOARD/_CLUSTERED_LEAF_FOLIAGE bodies exist in NO
        // blob package-wide (no foliage shader compiles them) -> no ground-truth math to port. _BLEND_COLOR is
        // an impostor-CAPTURE GBuffer albedo swap (no runtime billboard-LOD visual analog). See header + gaps.
        // ============================================================
        [Header(Unported Toggles  no ground-truth blob)]
        [ToggleUI] _EnableBillboard ("Billboard (no blob package-wide)", Float) = 0
        [ToggleUI] _ClusteredNormal ("Clustered Leaf Normal (no blob package-wide)", Float) = 0
        _ClusterNormalDst ("Cluster Normal Looseness (no blob package-wide)", Range(0, 1)) = 0.5
        [ToggleUI] _EnableBlendColor ("Blend Color (impostor-capture only)", Float) = 0
        [HideInInspector] _DitherScale ("Dither Scale (LOD crossfade -> URP native)", Range(0, 1)) = 1

        // ============================================================
        // HGRP environment global re-exposed as material Vector (URP has no equivalent global — STYLE_BIBLE §1.5/§2)
        // ============================================================
        [Header(Environment Params)]
        _EnvironmentGlobalParams0 ("EnvGlobalParams0 (.x=ambient intensity, .y=reflection intensity)", Vector) = (1, 1, 1, 0)
    }

    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="TransparentCutout" "Queue"="AlphaTest" }
        LOD 300

        HLSLINCLUDE
            // ============================================================
            // URP infrastructure (substitutes for every HGRP hand-rolled global — STYLE_BIBLE §2)
            // ============================================================
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"

            // ============================================================
            // FROZEN UNIFORM INTERFACE — single UnityPerMaterial CBUFFER.
            // Ground-truth field set: treefoliagebillboardlod/Sub0_Pass0_Fragment_b4.hlsl cbuffer (b4:25-44).
            // NO packoffset (SPIRV-Cross artifact). _ST floats added per URP convention (identity-neutral at default).
            // ============================================================
            CBUFFER_START(UnityPerMaterial)
                // ---- blend-state plumbing ----
                float _SrcBlend;
                float _DstBlend;
                float _ZTest;
                float _CullMode;
                float _ShadowCullMode;
                float _ShadowBias;
                float _StencilRef;
                float _ZTestGBuffer;
                float _PreDepthStencilRef;

                // ---- core surface (b4:25-44) ----
                float4 _BaseColor;            // b4:43
                float4 _BaseColorMap_ST;      // URP tiling (identity default)
                float4 _NormalMap_ST;         // URP tiling (identity default)
                float  _BaseColorTintCover;   // b4:39
                float  _BaseColorBrighterScale; // b4:40
                float  _NormalScale;          // b4:27
                float  _TwoSidedNormal;       // b4:30
                float  _RoughnessMin;         // b4:35
                float  _RoughnessMax;         // b4:36
                float  _OcclusionStrength;    // b4:31
                float  _OcclusionShadow;      // b4:32
                float  _DirectLightRoughnessOffset; // consumed by deferred lighting (re-exposed; see TODO)

                // ---- backface scattering / subsurface (b4:25-44) ----
                float  _SubsurfaceIntensity;  // b4:28
                float  _Transmission;         // b4:29
                float  _TransmissionDistanceFade; // b4:41
                float  _backfaceGiIntensity;  // b4:33
                float  _CardmeshCaptureMode;  // b4:42
                float  _FakeDirectionalShadowStrength; // b4:37
                float  _FakeDirectionalShadowPow;      // b4:38

                // ---- alpha test ----
                float  _AlphaClipThreshold;
                float  _ShadowAlphaClipThreshold;

                // ---- unported-toggle parity (no math emitted) ----
                float  _EnableBillboard;
                float  _ClusteredNormal;
                float  _ClusterNormalDst;
                float  _EnableBlendColor;
                float  _DitherScale;

                // ---- HGRP env global (re-exposed) ----
                float4 _EnvironmentGlobalParams0;
            CBUFFER_END

            // ============================================================
            // TEXTURES — base map sampled with LinearClamp (HG sampler_LinearClamp, b4:53), normal with
            // LinearRepeat (HG sampler_LinearRepeat, b4:54). URP provides both inline samplers via Core.
            // (Wrap-mode preservation is the only behavioral bit that matters — CORE_MATH §0.3.)
            // ============================================================
            TEXTURE2D(_BaseColorMap);
            TEXTURE2D(_NormalMap);

            // ============================================================
            // Decoded magic-constant table (denormalized-float bit patterns -> real values), all 1:1.
            // ============================================================
            static const float  FOLIAGE_F0          = 0.039999999105930328369140625; // = 0.04 ; fixed dielectric F0 (no _Specular in foliage)
            static const float  EPS_NORMALIZE        = 1.1754943508222875079687365372222e-38; // = FLT_MIN ; world-normal rsqrt guard, b4:209
            static const float  EPS_VIS              = 9.9999997473787516355514526367188e-05;  // = 1e-4  ; Smith-visibility denom floor (b9:981)
            static const float3 LUM                  = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709

            // ============================================================
            // HG analytic-light BRDF (VERIFIED exemplar CoreMath.hlsl §2.6/§2.7 == litforward/Fragment_b9).
            // Inlined (this shader is self-contained; the foliage cbuffer/surface differ from the Lit family
            // so the _core/*.hlsl cannot be #included wholesale). Constants are 1:1 load-bearing.
            // ============================================================

            // EnvBRDFApprox rational DFG scale (b9:974-975 _2174/_2183).
            float HgEnvBRDFApproxDFG(float roughness)
            {
                float t = mad(roughness, -1.0, 1.0);                                  // 1 - roughness
                return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875,
                                              -0.076194703578948974609375),
                                        1.04997003078460693359375),
                               0.4092549979686737060546875),
                           0.999000012874603271484375);
            }

            // Karis mobile env-BRDF horizon energy: F0 scale + bias for ambient reflection (b9:326-329,1261).
            void HgEnvBRDF(float roughness, float NoV, float3 f0, out float envSpecScale, out float envSpecBias)
            {
                float oneMinusRough = mad(roughness, -1.0, 1.0);                      // 1-rough, b9:326
                float envF = mad(min(oneMinusRough * oneMinusRough, exp2(NoV * -9.27999973297119140625)),
                                 oneMinusRough,
                                 mad(roughness, -0.0274999998509883880615234375, 0.0425000004470348358154296875)); // b9:328
                envSpecScale = mad(envF, -1.03999996185302734375,
                                   mad(roughness, -0.572000026702880859375, 1.03999996185302734375));               // b9:329
                envSpecBias  = mad(envF, 1.03999996185302734375,
                                   mad(roughness, 0.02199999988079071044921875, -0.039999999105930328369140625))
                               * saturate(f0.g * 50.0);                                                              // b9:1261
            }

            // Cook-Torrance GGX-D + Smith height-correlated Vis + Schlick F (b9:964-983). Returns (D*Vis)*F.
            float3 HgDirectSpecular(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float a   = roughness * roughness;                                   // b9:967
                float a2  = a * a;                                                   // b9:968
                float nv  = min(NoV, 1.0);                                           // b9:966
                float d   = mad(mad(NoH, a2, -NoH), NoH, 1.0);                       // (NoH*a2-NoH)*NoH+1, b9:969
                float visDenom = nv  * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2))
                               + NoL * sqrt(mad(mad(-nv,  a2, nv ), nv , a2))
                               + EPS_VIS;                                            // b9:981
                float DV  = (a2 / (d * d)) * (0.5 / visDenom);                       // D*Vis
                float oneMinusVoH = mad(-VoH, 1.0, 1.0);                             // b9:970
                float sq   = oneMinusVoH * oneMinusVoH;                              // b9:971
                float quad = sq * sq;                                               // b9:972
                float Fc   = oneMinusVoH * quad;                                     // (1-VoH)^5, b9:973
                float oneMinusFc = mad(-quad, oneMinusVoH, 1.0);                     // 1-(1-VoH)^5, b9:980
                float3 F   = mad(f0, oneMinusFc.xxx, Fc.xxx);                        // lerp(F0,1,Fc), b9:983
                return DV * F;
            }

            // Full per-light energy bracket: min(max(msDiff + min((D*Vis)*F, 2048), 0), 1000) (b9:975-983).
            float3 HgDirectLightEnergy(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float3 specE = HgDirectSpecular(roughness, f0, NoL, NoH, NoV, VoH);
                float  dfg   = HgEnvBRDFApproxDFG(roughness);                        // b9:975
                float  oneMinusDfg = mad(-dfg, 1.0, 1.0);                            // b9:976
                float  dfgEnergy   = dfg / oneMinusDfg;                              // b9:983 (T9 LUT -> analytic dfg)
                float3 gz    = mad((float3(1.0, 1.0, 1.0) - f0), 0.0476190485060214996337890625, f0); // lerp(F0,1,1/21), b9:977-979
                float3 msDiff = (dfgEnergy * (gz * gz)) / mad(-gz, oneMinusDfg, float3(1.0, 1.0, 1.0));
                return min(max(msDiff + min(specE, 2048.0), 0.0), 1000.0);          // b9:983
            }

            // ============================================================
            // Attributes / Varyings (frozen interface)
            // ============================================================
            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;     // b3:47 ; frag reads .r (foliage blend) + .g (normal-sign) (b4 TEXCOORD_4)
                float2 uv0        : TEXCOORD0;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float3 positionWS : TEXCOORD0;
                float3 normalWS   : TEXCOORD1;  // geometric world normal (b4 TEXCOORD_2)
                float4 tangentWS  : TEXCOORD2;  // .xyz tangent, .w handedness (b4 TEXCOORD_3)
                float2 uv         : TEXCOORD3;  // uv0 (b4 TEXCOORD)
                float4 color      : TEXCOORD4;  // vertex color rgba (b4 TEXCOORD_4)
                float3 viewDirWS  : TEXCOORD5;
                float  fogCoord   : TEXCOORD6;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                UNITY_VERTEX_OUTPUT_STEREO
            };

            // ============================================================
            // Shared camera vertex (object->world->clip + TBN). 1:1 transform == Vertex_b3:197-243 via URP infra
            // (GetVertexPositionInputs / GetVertexNormalInputs); HG oct-decode/billboard/MV dropped (STYLE_BIBLE §2).
            // ============================================================
            Varyings FoliageVertex(Attributes IN)
            {
                Varyings OUT = (Varyings)0;
                UNITY_SETUP_INSTANCE_ID(IN);
                UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);

                VertexPositionInputs posIn = GetVertexPositionInputs(IN.positionOS);
                VertexNormalInputs   nrmIn = GetVertexNormalInputs(IN.normalOS, IN.tangentOS);

                OUT.positionCS = posIn.positionCS;
                OUT.positionWS = posIn.positionWS;
                OUT.normalWS   = nrmIn.normalWS;                                       // b3:228-231 (normalize(objToWorld^-T * N))
                OUT.tangentWS  = float4(nrmIn.tangentWS, IN.tangentOS.w * GetOddNegativeScale()); // b3:232-236
                OUT.uv         = TRANSFORM_TEX(IN.uv0, _BaseColorMap);                 // b4 samples raw uv0; _ST identity-neutral
                OUT.color      = IN.color;                                            // b3:249-252
                OUT.viewDirWS  = GetWorldSpaceViewDir(posIn.positionWS);
                OUT.fogCoord   = ComputeFogFactor(posIn.positionCS.z);
                return OUT;
            }

            // ============================================================
            // Foliage surface result (decoded from Fragment_b4, pre-lighting).
            // ============================================================
            struct FoliageSurface
            {
                float3 albedo;
                float3 normalWS;
                float  roughness;       // perceptual GBuffer roughness channel = lerp(_358, nrm.b, vColor.r) (b4:251)
                float  occlusion;       // b4 _373
                float  occShadow;       // b4 _536
                float  transmission;    // b4 _357
                float  subsurface;      // b4 subsurface intensity = _SubsurfaceIntensity*(1-vColor.r) (b4:252)
                float  backfaceGI;      // b4 _backfaceGiIntensity*(1-vColor.r) (b4:239)
                float  vColorR;         // shadow-channel blend gate (b4 TEXCOORD_4.x)
                float  alpha;
            };

            // ============================================================
            // LitBuildSurface == Fragment_b4 surface assembly, 1:1 (every line cited b4:NNN).
            // ============================================================
            FoliageSurface FoliageBuildSurface(Varyings IN, bool isFrontFace)
            {
                FoliageSurface s = (FoliageSurface)0;

                float2 uv     = IN.uv;
                float3 N      = IN.normalWS;        // b4 TEXCOORD_2 (geo world normal)
                float4 T4     = IN.tangentWS;       // b4 TEXCOORD_3
                float4 vColor = IN.color;           // b4 TEXCOORD_4
                s.vColorR     = vColor.x;

                // ---- handedness + two-sided foliage face sign ----
                float tanSign  = (T4.w > 0.0) ? 1.0 : -1.0;                                                  // b4:175 (_85)
                float faceSign = isFrontFace ? 1.0 : (((vColor.x + _TwoSidedNormal + vColor.y) >= 0.5) ? -1.0 : 1.0); // b4:176 (_92)

                // ---- albedo: saturate(tex*_BaseColor*_BaseColorBrighterScale) tint-cover; vColor.r raw-bypass ----
                float4 baseTex = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_LinearClamp, uv, 0.0);          // b4:177 (_103) ; URP folds _GlobalMipBias
                float3 albSat  = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale);            // b4:182-184 (_129..131)
                float3 albTint = lerp(albSat, _BaseColor.rgb, _BaseColorTintCover);                          // b4:185-187 mad(_TintCover,_BaseColor-albSat,albSat)
                s.albedo = (vColor.x != 0.0) ? baseTex.rgb : albTint;                                        // b4:181,185-187 (_110)
                s.alpha  = baseTex.a;

                // ---- foliage NORMAL reflect-trick decode (b4:188-205) ----
                float4 nrm = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_LinearRepeat, uv, 0.0);                // b4:188 (_167)
                float  nB  = nrm.z;                                                                          // b4:189 (_171) giBackfaceFromAO
                float  nA  = nrm.w;                                                                          // b4:190 (_172) subsurfaceMul / occlusion src
                float  nx  = mad(nrm.x, 2.0, -1.0);                                                          // b4:191 (_173)
                float  ny  = mad(nrm.y, 2.0, -1.0);                                                          // b4:192 (_176)
                float  nz2 = 1.0 - nx * nx - ny * ny;                                                        // b4:193 (_182) = dot((nx,ny,1),(-nx,-ny,1))
                float  nzS = sqrt(nz2);                                                                      // b4:194 (_185)
                float  zr  = mad(nz2, 2.0, -1.0);                                                            // b4:195 (_190) reflected Z = 2*nz^2-1
                float  xr  = (2.0 * nzS * nx) * _NormalScale;                                                // b4:196 (_194)
                float  yr  = (2.0 * nzS * ny) * _NormalScale;                                                // b4:197 (_195)
                float  invL1 = rsqrt(dot(float3(xr, yr, zr), float3(xr, yr, zr)));                           // b4:198 (_199)
                float  tsZ = invL1 * zr;                                                                     // b4:199 (_202)
                float  tsX = faceSign * (invL1 * xr);                                                        // b4:200 (_203) faceSign on xy
                float  tsY = faceSign * (invL1 * yr);                                                        // b4:201 (_204)
                float  invL2 = rsqrt(dot(float3(tsX, tsY, tsZ), float3(tsX, tsY, tsZ)));                     // b4:202 (_208)
                float3 ts  = invL2 * float3(tsX, tsY, tsZ);                                                  // b4:203-205 (_209,_210,_211)

                // ---- TBN -> world normal: ts.x*T + ts.y*(tanSign*cross(N,T)) + ts.z*N (b4:206-208) ----
                float3 B  = tanSign * cross(N, T4.xyz);                                                      // b4:206-208 inline cross * _85
                float3 wN = ts.z * N + ts.x * T4.xyz + ts.y * B;                                            // b4:206-208 (_266..268)
                float  invWN = rsqrt(max(dot(wN, wN), EPS_NORMALIZE));                                       // b4:209 (_274)
                s.normalWS = faceSign * wN * invWN;                                                          // b4:210-212 (_278..280) faceSign on whole WN

                // ---- transmission distance-fade (object-pivot dist; b4:213-217) ----
                float3 objOrigin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);
                float3 camToObj  = _WorldSpaceCameraPos.xyz - objOrigin;                                     // b4:213-215 (_299..301)
                float  fadeRaw   = saturate((length(camToObj) - 60.0) * -0.100000001490116119384765625);    // b4:216 (_310)
                float  distFade  = (_TransmissionDistanceFade != 0.0) ? (fadeRaw * fadeRaw * mad(fadeRaw, -2.0, 3.0)) : 1.0; // b4:217 (_318) smoothstep

                // ---- transmission + perceptual roughness (CardmeshCaptureMode branch; b4:218-229) ----
                float transmission, roughness;
                if (_CardmeshCaptureMode < 0.5)
                {
                    transmission = distFade * (nB * _Transmission);                                          // b4:222 (_357)
                    roughness    = mad((_RoughnessMax - _RoughnessMin), 0.800000011920928955078125, _RoughnessMin); // b4:223 (_358) lerp(min,max,0.8)
                }
                else
                {
                    transmission = distFade * _Transmission;                                                // b4:227 (_357)
                    roughness    = mad(nB, (_RoughnessMax - _RoughnessMin), _RoughnessMin);                 // b4:228 (_358) lerp(min,max,nB)
                }
                s.transmission = transmission;
                // GBuffer roughness channel is the vColor.r-gated blend of branch-roughness with nrm.b, NOT raw
                // branch-roughness: SV_Target_3.z = lerp(_358, nrm.b, vColor.r) (b4:251 _368-pack). This is what the
                // deferred lighting pass reads back as perceptual roughness -> apply it here so ForwardLit is 1:1.
                s.roughness    = mad(vColor.x, nB - roughness, roughness);                                    // b4:251 (_358->SV_Target_3.z) lerp(roughness,nB,vColor.r)

                // ---- occlusion (b4:230-231) + occlusion-affects-shadow (b4:256) ----
                float occBase = saturate(mad(nA, _OcclusionStrength, 1.0 - _OcclusionStrength));             // b4:230 (_368) saturate(lerp(1,nA,strength))
                s.occlusion   = mad(vColor.x, nA - occBase, occBase);                                        // b4:231 (_373) lerp(occBase,nA,vColor.r)
                s.occShadow   = mad(_OcclusionShadow, s.occlusion - 1.0, 1.0);                               // b4:256 (_536) lerp(1,occlusion,_OcclusionShadow)

                // ---- subsurface + backface GI (b4:239,252) ----
                s.subsurface  = mad(vColor.x, -_SubsurfaceIntensity, _SubsurfaceIntensity);                  // b4:252 (_514 input) _SubsurfaceIntensity*(1-vColor.r)
                s.backfaceGI  = mad(vColor.x, -_backfaceGiIntensity, _backfaceGiIntensity);                  // b4:239 (_452 input) _backfaceGiIntensity*(1-vColor.r)

                return s;
            }

            // ============================================================
            // Forward lighting composite — HG forward BRDF (CoreMath/b9) on the 1:1 surface. Every foliage SURFACE
            // channel that Fragment_b4 packs is now reproduced 1:1 (each cited b4:line, incl. the vColor.r-gated
            // roughness blend b4:251). What Fragment_b4 does NOT contain is the LIGHTING — it is a deferred GBuffer
            // writer (5 MRT bit-pack, b4:237-269). The pass that READS those packed channels and folds them into
            // radiance is the fullscreen `shaders/lighting/deferredlighting` shader (ENGINE-SIDE): its blob
            // (deferredlighting/Sub0_Pass0_Fragment_b101) consumes host-C#-filled StructuredBuffers — light-binning
            // ByteAddressBuffer T0 (b101:24), _LightDataBuffer_DirectionalLightDirection[2054] (b101:102), CSM
            // shadow atlases _CSMWorldToShadow (b101:107), and the image-volume GI globals _IVParam*/_IVDefaultSHA*
            // (b101:64-69) that drive backfaceGI ambient. None of that can be produced by a material shader.
            // ENGINE-SIDE TODO(1:1) (named host = deferredlighting fullscreen pass): the channel VALUES below are
            //   1:1 (cited); only their fold-into-final-radiance weighting is the host pass's, reconstructed here in
            //   the faithful foliage-SSS forward manner so ForwardLit is self-contained.
            // ============================================================
            half4 FoliageForwardLighting(FoliageSurface s, Varyings IN)
            {
                float3 N  = normalize(s.normalWS);
                float3 V  = normalize(IN.viewDirWS);
                float3 P  = IN.positionWS;

                float  roughness = saturate(s.roughness);
                float3 f0        = FOLIAGE_F0.xxx;                              // fixed dielectric (no _Specular in foliage)
                float3 diffuse   = s.albedo;                                  // metallic = 0 -> diffuse = albedo
                float  NoV = max(dot(N, V), 0.0);                             // b9:327

                // ---- ambient: SampleSH(N) diffuse * occlusion + GlossyEnvironmentReflection * EnvBRDF (CoreMath §2.4/§2.5) ----
                float envSpecScale, envSpecBias;
                HgEnvBRDF(roughness, NoV, f0, envSpecScale, envSpecBias);     // b9:326-329,1261
                float3 ambientSH  = SampleSH(N);
                float3 reflectVec = reflect(-V, N);
                float3 reflection = GlossyEnvironmentReflection(reflectVec, roughness, 1.0);
                // backface GI: thin-leaf ambient also lights the opposite hemisphere. s.backfaceGI VALUE is 1:1
                // (b4:239 _backfaceGiIntensity*(1-vColor.r), packed to SV_Target_3.w/SV_Target_2.z). The back-hemi
                // weighting is the host deferredlighting pass's IV-volume ambient (b101 _IVParam*/_IVDefaultSHA*),
                // ENGINE-SIDE; SampleSH(-N) is URP's faithful image-volume-ambient substitute.
                float3 ambientBack = SampleSH(-N) * s.backfaceGI;            // value 1:1 b4:239; fold-in = deferredlighting IV ambient (engine-side)
                float3 color = (ambientSH + ambientBack) * diffuse * s.occlusion * _EnvironmentGlobalParams0.x
                             + reflection * (f0 * envSpecScale + envSpecBias) * _EnvironmentGlobalParams0.y; // b9:1325 terms A/B

                // ---- main directional light ----
                float4 shadowCoord = TransformWorldToShadowCoord(P);
                Light mainLight = GetMainLight(shadowCoord, P, half4(1, 1, 1, 1));
                float  mainAtten = mainLight.distanceAttenuation * mainLight.shadowAttenuation;             // -> b9 _1897
                float3 Lurp = mainLight.direction;                            // URP: toward-light
                float3 hgLightDir = -Lurp;                                    // HG _LightDataBuffer_DirectionalLightDirection (light-travel) = -URP dir
                // _DirectLightRoughnessOffset (.shader:36) is NOT packed by Fragment_b4 — it is a uniform read only
                // by the host deferredlighting pass when it shades direct light. Applied here to the DIRECT-light
                // roughness only (ambient/reflection keep s.roughness); exact host weighting is engine-side.
                float directRoughness = saturate(roughness + _DirectLightRoughnessOffset); // not-in-b4 hack; fold-in = deferredlighting (engine-side)
                {
                    float3 H = normalize(Lurp + V);
                    float NoL = saturate(dot(Lurp, N));                       // b9:964
                    float NoH = saturate(dot(N, H));                         // b9:965
                    float VoH = saturate(dot(V, H));                        // b9:970
                    float3 energy = HgDirectLightEnergy(directRoughness, f0, NoL, NoH, NoV, VoH); // b9:975-983
                    float3 direct = mad(energy, NoL, diffuse * NoL) * (mainAtten * mainLight.color);        // b9:983

                    // fake directional shadow (1:1 b4:257) — saturate(1 - strength*(dot(N,hgLightDir)*0.5+0.5)^pow)
                    float NdotLhalf     = mad(dot(N, hgLightDir), 0.5, 0.5);                                 // b4:257 inner
                    float fakeDirShadow = saturate(mad(-pow(NdotLhalf, _FakeDirectionalShadowPow), _FakeDirectionalShadowStrength, 1.0)); // b4:257 (_557)
                    // GBuffer "shadow" channel VALUE is 1:1: SV_Target_2.y = lerp(occShadow*fakeDirShadow, 1, vColor.r)
                    // (b4:259 mad(vColorR, mad(-_536,_557,1), _557*_536)). It scales direct radiance in the host pass.
                    float shadowChan = lerp(s.occShadow * fakeDirShadow, 1.0, s.vColorR);                   // value 1:1 b4:259; fold-in (scales direct) = deferredlighting (engine-side)
                    color += direct * shadowChan;

                    // ---- leaf translucency (transmission) ----
                    // translucency-NoL VALUE is 1:1: SV_Target_2.z low term = saturate(dot(N, -hgLightDir))
                    // = saturate(dot(N, Lurp)) (b4:261). transmission(b4:255 7-bit) + subsurface(b4:252 profile idx)
                    // VALUES are 1:1; the SSS-profile-LUT weighting that folds them into back-light radiance is the
                    // host deferredlighting pass (profile tables filled by C#), ENGINE-SIDE.
                    float transNoL = saturate(dot(N, -hgLightDir));                                          // value 1:1 b4:261 = saturate(dot(N, Lurp))
                    float3 translucency = diffuse * (s.transmission * (1.0 + s.subsurface)) * transNoL
                                        * (mainAtten * mainLight.color);                                     // values 1:1 b4:252,255,261; SSS-profile fold-in = deferredlighting (engine-side)
                    color += translucency;
                }

                // ---- additional (punctual) lights ----
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
                    float3 energy = HgDirectLightEnergy(roughness, f0, NoL, NoH, NoV, VoH);                  // b9:1228-1234 (same BRDF)
                    float atten = light.distanceAttenuation * light.shadowAttenuation;
                    color += mad(energy, NoL, diffuse * NoL) * (atten * light.color);
                }
            #endif

                color = MixFog(color, IN.fogCoord);                          // HG fog -> URP MixFog (CORE_MATH §2.10)
                return half4(color, 1.0);                                    // opaque cutout -> alpha 1
            }

            // ============================================================
            // Alpha clip helper — 1:1 with the foliage-family alpha-test delta. This shader's OWN captured base
            // permutation had _ALPHATEST_ON OFF, but the identical foliage codebase compiles it in the sibling
            // grass/cardmesh dumps: the clip is `discard_cond(BaseColorMap.SampleBias(uv, mipBias).w < threshold)`
            // — strict `<`, samples _BaseColorMap.w RAW (NO _BaseColor.a multiply), mipBias folded by URP.
            // Source = grass/Sub0_Pass1_Fragment_b87:83 (ShadowCaster) == grass/Sub0_Pass2_Fragment_b123:81 (DepthOnly);
            // discard_cond semantics = grass/Sub0_Pass0_Fragment_b25:186-200 (sets discard when cond true).
            // ============================================================
            void FoliageAlphaClip(Varyings IN, float threshold)
            {
            #ifdef _ALPHATEST_ON
                // 1:1, source = grass/Sub0_Pass1_Fragment_b87.hlsl:83 (sibling of identical foliage codebase).
                // discard when baseTex.a < threshold; clip(a-threshold) discards on a-threshold<0 == a<threshold.
                float a = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_LinearClamp, IN.uv, 0.0).w;
                clip(a - threshold);
            #endif
            }
        ENDHLSL

        // ============================================================================================
        // Pass 1: ForwardLit  (source HGBuffer LIGHTMODE=GBuffer -> URP UniversalForwardOnly; STYLE_BIBLE §7)
        //   Source render-state (treefoliagebillboardlod.shader:48-62): ZClip On / ZTest [_ZTestGBuffer] /
        //   Cull [_CullMode] / Stencil Ref [_StencilRef] Comp Always Pass Replace.
        // ============================================================================================
        Pass {
            Name "ForwardLit"
            Tags { "LightMode"="UniversalForwardOnly" }
            ZTest [_ZTestGBuffer]
            ZWrite [_ZWrite]
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   FoliageVertex
                #pragma fragment FoliageForwardFragment

                #pragma shader_feature_local _ALPHATEST_ON
                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH
                #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
                #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BOX_PROJECTION
                #pragma multi_compile_fragment _ _SCREEN_SPACE_OCCLUSION
                #pragma multi_compile_fog
                #pragma multi_compile_instancing

                half4 FoliageForwardFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                    FoliageAlphaClip(IN, _AlphaClipThreshold);
                    FoliageSurface s = FoliageBuildSurface(IN, isFrontFace);
                    return FoliageForwardLighting(s, IN);
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2: ShadowCaster  (source ShadowCaster LIGHTMODE=SHADOWCASTER -> URP ShadowCaster; b18/b19)
        //   Source: ZClip On / Cull [_ShadowCullMode] / Offset [_ShadowBias],0. Fragment EMPTY (b19).
        // ============================================================================================
        Pass {
            Name "ShadowCaster"
            Tags { "LightMode"="ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_ShadowCullMode]
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   FoliageShadowVertex
                #pragma fragment FoliageShadowFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW
                #pragma multi_compile_instancing

                float3 _LightDirection;
                float3 _LightPosition;

                Varyings FoliageShadowVertex(Attributes IN)
                {
                    Varyings OUT = (Varyings)0;
                    UNITY_SETUP_INSTANCE_ID(IN);
                    UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
                    UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);

                    float3 positionWS = TransformObjectToWorld(IN.positionOS);   // b18:81-84 (ObjectToWorld * posOS)
                    float3 normalWS   = TransformObjectToWorldNormal(IN.normalOS);

                    #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                        float3 lightDirectionWS = normalize(_LightPosition - positionWS);
                    #else
                        float3 lightDirectionWS = _LightDirection;
                    #endif
                    // HG bakes shadow bias into _ShadowpassVP; URP's faithful substitute = ApplyShadowBias + near-clamp.
                    OUT.positionCS = ApplyShadowClamping(TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDirectionWS)));
                    OUT.uv         = TRANSFORM_TEX(IN.uv0, _BaseColorMap);
                    OUT.color      = IN.color;
                    return OUT;
                }

                half4 FoliageShadowFragment(Varyings IN) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                    FoliageAlphaClip(IN, _ShadowAlphaClipThreshold);            // shadow uses _ShadowAlphaClipThreshold
                    return 0;                                                  // b19 EMPTY
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 3: DepthOnly  (source DepthOnly LIGHTMODE=DepthOnly -> URP DepthOnly; b30/b31)
        //   Source: ZClip On / Cull [_CullMode] / Stencil Ref [_StencilRef]. Fragment EMPTY (b31).
        // ============================================================================================
        Pass {
            Name "DepthOnly"
            Tags { "LightMode"="DepthOnly" }
            ZWrite On
            ZTest LEqual
            ColorMask R
            Cull [_CullMode]
            Stencil { Ref [_PreDepthStencilRef] Comp Always Pass Replace }
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   FoliageVertex
                #pragma fragment FoliageDepthFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma multi_compile_instancing

                half4 FoliageDepthFragment(Varyings IN) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                    FoliageAlphaClip(IN, _AlphaClipThreshold);
                    return 0;                                                  // b31 EMPTY
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 4: DepthNormalsOnly  (URP SSAO / depth-normals prepass — STYLE_BIBLE §7; maps HG GBuffer-normal need)
        // ============================================================================================
        Pass {
            Name "DepthNormalsOnly"
            Tags { "LightMode"="DepthNormalsOnly" }
            ZWrite On
            Cull [_CullMode]
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   FoliageVertex
                #pragma fragment FoliageDepthNormalsFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma multi_compile_instancing

                half4 FoliageDepthNormalsFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                    FoliageAlphaClip(IN, _AlphaClipThreshold);
                    FoliageSurface s = FoliageBuildSurface(IN, isFrontFace);
                    return half4(NormalizeNormalPerPixel(s.normalWS), 0.0);
                }
            ENDHLSL
        }
    }
}
