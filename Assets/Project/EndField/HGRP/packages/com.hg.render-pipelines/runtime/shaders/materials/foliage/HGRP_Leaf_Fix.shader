// HGRP Foliage/Leaf -> URP. Forward-lit foliage (leaf-card / canopy) with translucency.
// Merged from: leaf/Sub0_Pass0_*_b95/b96 (base GBuffer surface), leaf/Sub0_Pass0_Fragment_b110 (_NORMAL_MAP delta),
//   leaf/Sub0_Pass1_*_b390/b391 (ShadowCaster base), leaf/Sub0_Pass2_*_b662/b663 (DepthOnly base).
// Source: ReferenceProjects/RuriBeyondShader/packages/com.hg.render-pipelines/runtime/shaders/materials/foliage/leaf.shader
// Keywords: _NORMAL_MAP, _ALPHATEST_ON, _EMISSIVE_MAP (leaf.shader:211,215,217 multi_compile_local). _TwoSidedNormal
//   is a [ToggleUI] UNIFORM (leaf.shader:22), NOT a keyword. Plus URP shadow/fog/additional-light system keywords.
// Kept (1:1, cite leaf blob file:line): albedo+BaseColorBrighterScale+tint-cover (b96:212-217 / b110:215-220),
//   DXT5nm-style normal-map decode RG + _NormalScale + two-sided front sign (b110:213-239), tangent->world TBN
//   (b110:230-236), roughness = lerp(RoughMin,RoughMax, NormalMap.b) (b110:264; base midpoint b96:252),
//   AO from vertex-color.x * _OcclusionStrength (b96:218-219 / b110:228-229), foliage transmission from
//   NormalMap.a * _Transmission with AO-gate + distance-fade (b110:240-272), subsurface AO-gate strength packed
//   (b96:239/b110:251; consumed by a SEPARATE SSS pass, not this resolve), fake-directional-shadow pow/strength
//   on cam-right (b96:261 / b110:273), GGX-D + Smith-Vis + Schlick-F direct BRDF (validated 1:1 vs
//   deferredlightingperlight/Sub0_Pass2_Fragment_b9.hlsl:561,565 — Smith 0.5/(..+1e-4), min(spec,2048), clamp[0,1000]).
// Lit response GROUND TRUTH = HG DEFERRED LIGHTING (deferredlighting/Sub0_Pass10_Fragment_b1001.hlsl), now READ:
//   - reflectance->F0 = (round(7*_Reflectance)*0.107142857 + 0.5)*0.08  (b1001:901)  [was inferred 0.04+0.04*R: WRONG]
//   - env-spec scale/bias = b1001:328,901  (NO litforward `*saturate(F0.g*50)` gate — foliage path omits it)
//   - foliage translucency = forward DIFFUSE-RESPONSE scalar _2257 = transmission*min(NoV,1) + _backfaceGiIntensity
//     (b1001:910), NOT a back-hemisphere wrap and NOT a SampleSH(-N) lookup (both were fabricated, now removed)
//   - _DiffuseUseVertexNormal feeds the GBuffer GI-normal channel (b96:262-263), NOT the direct Lambert (b1001:326,977).
//   ambient diffuse -> SampleSH(N), reflection -> GlossyEnvironmentReflection (b1001:879-881,977 -> URP infra).
// Removed (pixel-neutral pipeline infra, substituted by URP per STYLE_BIBLE §2 / CORE_MATH §2.12):
//   HG ECS-instancing buffer + object->world->clip (-> GetVertexPositionInputs/NormalInputs), octahedral
//   NORMAL/TANGENT mesh-decode (b95:131-200 -> URP normal inputs), GPU vertex skinning, HG motion-vector
//   SV_Target1 pack (b96:237-238), HG 5-MRT deferred GBuffer pack (b96:241-271 -> URP forward lighting),
//   LOD-crossfade interleaved-gradient discard (b96:208-210 -> URP LODFadeCrossFade), IV-clipmap GI
//   (-> SampleSH), reflection-probe binning (-> GlossyEnvironmentReflection), CSM/ASM atlas (-> URP main-light
//   shadow), froxel fog (-> MixFog), RayTracingReflection body (empty stub).
//
// NOTE: leaf's base catch-all variant is a HG DEFERRED GBUFFER surface writer (b96 = 5 MRTs, no lighting); the
//   actual lit response lives in HG's deferred lighting pass (lighting/deferredlighting, NOW READ - base resolve
//   Sub0_Pass10_Fragment_b1001 + per-light Sub0_Pass2_Fragment_b9). Per CORE_MATH §1.4 PORT GUIDANCE this family
//   is re-authored as URP ForwardLit: surface params assembled 1:1 from b96/b110, lit with the HG forward BRDF
//   spine + the foliage-specific F0/env/translucency decode reconstructed from b1001 (see Lit-response block above).
//   GBuffer->deferred texture map: T20=SV_Target_4(albedo), T19=SV_Target_3(oct-normal.xy/rough.z/backfaceGI-lo.w),
//   T18=SV_Target_2(transmission+subsurface.x / reflectance+fakeShadow.y / GI-normal+backfaceGI-hi.z / subsurface-lo.w).
//   Remaining TODO(1:1): the deferred composite's diffuse renormalization (albedo/maxCh, 1/pi; b1001:906,977) and
//   the subsurface-profile SSS blur (separate screen-space pass) are out of forward scope.
//   _NormalMap channels: RG = tangent normal, B = roughness, A = transmission mask (property label leaf.shader:18).
//   AO source = vertex-color.x (leaf bakes leaf-card occlusion into the red vertex channel; b96:218 TEXCOORD_3.x).

Shader "HGRP/Foliage/Leaf_Fix" {
    Properties {
        // ---- Blend-state plumbing (set by CustomEditor / _SurfaceType presets) ----
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [HideInInspector] _ShadowCullMode ("Shadow Render Face", Float) = 2
        [HideInInspector] _ShadowBias ("Shadow Bias", Float) = 0
        [HideInInspector] _StencilRef ("Stencil Ref", Float) = 0
        [HideInInspector] _ZTestGBuffer ("__ztGBuffer", Float) = 4
        [HideInInspector] _PreDepthStencilRef ("Pre-Depth Stencil Ref", Float) = 5

        // ---- Base material ----
        _BaseColor ("Base Color", Color) = (1, 1, 1, 1)
        _BaseColorMap ("Base Color Map", 2D) = "white" {}
        _BaseColorTintCover ("Base Color Tint Cover", Range(0, 1)) = 0
        _BaseColorBrighterScale ("Base Color Brighter Scale", Range(1, 3)) = 1
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1
        _Reflectance ("Reflectance Boost", Range(0, 1)) = 0
        _OcclusionStrength ("Occlusion Strength (AO from vertex R)", Range(0, 1)) = 1
        _OcclusionShadow ("Occlusion Affect Shadow", Range(0, 1)) = 0
        [HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}

        // ---- Normal / Roughness / Transmission map ----
        [Toggle(_NORMAL_MAP)] _EnableNormalMap ("Use Normal(RG) Roughness(B) Transmission(A) Map", Float) = 0
        _NormalMap ("Normal(RG) Roughness(B) Transmission(A)", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 3)) = 1
        [ToggleUI] _DiffuseUseVertexNormal ("Direct Diffuse Uses Vertex Normal", Float) = 1

        // ---- Shape / two-sided ----
        // leaf.shader:22 is [ToggleUI] — a plain uniform read by the HLSL (frontSign = mad(_TwoSidedNormal,-2,1)),
        // NOT a shader keyword. [ToggleUI] (no _TWOSIDEDNORMAL_ON keyword) is the 1:1 match.
        [ToggleUI] _TwoSidedNormal ("Flip Back-Face Normal", Float) = 0

        // ---- Fake directional (hemispheric) shadow baked into AO ----
        [Header(Fake Directional Shadow)]
        _FakeDirectionalShadowStrength ("Fake Dir Shadow Strength", Range(0, 2)) = 0
        _FakeDirectionalShadowPow ("Fake Dir Shadow Transition", Range(0.01, 5)) = 1

        // ---- Transmission / subsurface ----
        [Header(Transmission and Subsurface)]
        _SubsurfaceIntensity ("Subsurface Intensity", Range(0, 1)) = 0
        [ToggleUI] _TransmissionDistanceFade ("Transmission Fades With Distance", Float) = 0
        _Transmission ("Transmission Strength", Range(0, 1)) = 0.2
        _backfaceGiIntensity ("Backface GI Intensity", Range(0, 1)) = 0.2
        // AO influence on transmission / subsurface
        _AoAffectTransmissionStart ("AO Affect Transmission Start", Range(0, 0.99)) = 0
        _AoAffectTransmissionRange ("AO Affect Transmission Range", Range(0.01, 0.9)) = 0.01
        _AoAffectSubsurfaceStart ("AO Affect Subsurface Start", Range(0, 0.99)) = 0
        _AoAffectSubsurfaceRange ("AO Affect Subsurface Range", Range(0.01, 0.9)) = 0.01

        // ---- Emissive ----
        [Header(Emissive)]
        [Toggle(_EMISSIVE_MAP)] _EnableEmissiveMap ("Use Emissive Map", Float) = 0
        _EmissiveMap ("Emissive Map", 2D) = "black" {}
        [HDR] _EmissiveColorR ("Emissive Color (Channel R)", Color) = (0, 0, 0, 1)
        [ToggleUI] _AlbedoAffectEmissive ("Albedo Affects Emissive", Float) = 1

        // ---- Alpha test ----
        [Header(Alpha Test)]
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Enable Alpha Test", Float) = 0
        _AlphaClipThreshold ("Alpha Clip Threshold", Range(0, 1.001)) = 0.5
        _ShadowAlphaClipThreshold ("Shadow Alpha Clip Threshold", Range(0, 1.001)) = 0.2

        // ---- Environment params (HGRP globals re-exposed; URP has no equivalent — STYLE_BIBLE §1.5/§2) ----
        [Header(Environment Params)]
        _EnvironmentGlobalParams0 ("EnvGlobalParams0 (.x=ambient .y=reflection intensity)", Vector) = (1, 1, 1, 0)
    }

    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Opaque" "Queue"="Geometry" }
        LOD 600

        HLSLINCLUDE
            // ============================================================
            // URP infrastructure (substitutes for the HGRP hand-rolled globals — STYLE_BIBLE §2)
            // ============================================================
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"

            // ============================================================
            // CBUFFER_START(UnityPerMaterial) — every uniform referenced below exactly once.
            // Field set = leaf type_UnityPerMaterial (b96:28-60 / b110 superset) minus the GBuffer/VAT-only
            // fields that the base surface path never reads. No packoffset (SPIRV-Cross artifact).
            // ============================================================
            CBUFFER_START(UnityPerMaterial)
                float _SrcBlend;
                float _DstBlend;
                float _ZTest;
                float _ZWrite;
                float _CullMode;
                float _ShadowCullMode;
                float _ShadowBias;
                float _StencilRef;
                float _ZTestGBuffer;
                float _PreDepthStencilRef;

                float4 _BaseColor;              // b96:59
                float4 _BaseColorMap_ST;
                float4 _NormalMap_ST;
                float4 _EmissiveMap_ST;
                float4 _EmissiveColorR;
                float4 _EnvironmentGlobalParams0;

                float _BaseColorTintCover;      // b96:46
                float _BaseColorBrighterScale;  // b96:47
                float _RoughnessMin;            // b96:35
                float _RoughnessMax;            // b96:36
                float _Reflectance;             // b96:48
                float _OcclusionStrength;       // b96:32
                float _OcclusionShadow;         // b96:33
                float _NormalScale;             // b96:30
                float _TwoSidedNormal;          // b96:31
                float _DiffuseUseVertexNormal;  // b96:45

                float _FakeDirectionalShadowStrength;  // b96:43
                float _FakeDirectionalShadowPow;       // b96:44

                float _SubsurfaceIntensity;     // b96:39
                float _TransmissionDistanceFade;// b96:41
                float _Transmission;            // b96:34
                float _backfaceGiIntensity;     // b96:42
                float _AoAffectTransmissionStart;  // b96:52
                float _AoAffectTransmissionRange;  // b96:53
                float _AoAffectSubsurfaceStart;    // b96:54
                float _AoAffectSubsurfaceRange;    // b96:55

                float _AlbedoAffectEmissive;
                float _AlphaClipThreshold;      // b96:37
                float _ShadowAlphaClipThreshold;// b96:38
            CBUFFER_END

            TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);   // T0 (b96:67) albedo  / clamp
            TEXTURE2D(_NormalMap);      SAMPLER(sampler_NormalMap);      // T1 (b110:221) normal.RG / roughness.B / transmission.A / repeat
            TEXTURE2D(_EmissiveMap);    SAMPLER(sampler_EmissiveMap);    // emissive (R channel)

            // ---- decoded magic constants (denormalized-float bit patterns -> real values, leaf blobs) ----
            static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709 luma
            static const float  HGRP_EPS_VIEWLEN   = 9.9999999392252902907785028219223e-09; // = 1e-8  ; rsqrt/denominator guard, b96:232
            static const float  HGRP_EPS_NORMAL_Z  = 1.000000016862383526387164645044e-16;  // = 1e-16 ; derived-normal-Z floor, b110:224
            static const float  HGRP_FLT_MIN       = 1.1754943508222875079687365372222e-38; // = FLT_MIN; normalize rsqrt guard, b96:220
            static const float  HGRP_EPS_VIS       = 9.9999997473787516355514526367188e-05;  // = 1e-4  ; Smith-visibility denominator floor (b9:981)
            static const float  HGRP_DIELECTRIC_F0 = 0.07999999821186065673828125;           // = 0.08  ; dielectric F0 base (b9:318)
            static const float  HGRP_GRAZING_FLOOR = 0.0476190485060214996337890625;         // = 1/21  ; multiscatter-diffuse grazing floor (b9:977)
            static const float  TRANSMISSION_FADE_DIST  = -60.0;                              // distance-fade start, b96:257 / b110:269
            static const float  TRANSMISSION_FADE_SCALE = -0.100000001490116119384765625;    // = -0.1 (fade over 10m), b96:257 / b110:269

            // ============================================================
            // Surface output (leaf foliage). Filled 1:1 from b96 / b110; lighting consumes it.
            // ============================================================
            struct LeafSurfaceData
            {
                half3  albedo;        // tint-covered base color (b96:212-217 / b110:215-220)
                half3  normalWS;      // shaded world normal (geo for base, TBN-mapped under _NORMAL_MAP)
                half3  vertexNormalWS;// geometric world normal (front-signed), for direct-diffuse blend (b96:262 _DiffuseUseVertexNormal)
                half   roughness;     // linear roughness = lerp(RoughMin,RoughMax, NormalMap.b) (b110:264)
                half   occlusion;     // AO = saturate(_OcclusionStrength*(vColor.x-1)+1) (b96:218-219)
                half   fakeDirShadow; // hemispheric fake-dir shadow * AO-shadow (b96:261 / b110:273)
                half   reflectance;   // _Reflectance boost (b96:261 SV_Target_2.y low bits)
                half   transmission;  // AO-gated transmission (b110:272)
                half   subsurface;    // AO-gated subsurface (b96:239 / b110:251)
                half   backfaceGI;    // backface GI intensity (b96:240)
                half3  f0;            // dielectric foliage F0
                half3  emission;      // emissive (b110/feature)
                half   alpha;         // base alpha
            };

            // --------------------------------------------------------------------------------------------
            // smoothstep01(t) = t*t*(3-2t). HG spells it `t*t*mad(t,-2,3)` (b96:239,260; b110:251,272).
            // --------------------------------------------------------------------------------------------
            float HgSmooth01(float t) { return (t * t) * mad(t, -2.0, 3.0); }

            // --------------------------------------------------------------------------------------------
            // §2.6 HG env-BRDF horizon energy — leaf GROUND TRUTH is the DEFERRED-LIGHTING resolve, NOT the
            // litforward b9 path. Source: deferredlighting/Sub0_Pass10_Fragment_b1001.hlsl:328 (envF=_677),
            // :901 (the full reflection-F0 = (reflDecode)*envSpecScale + envSpecBias). The leaf foliage path
            // does NOT apply the litforward `* saturate(F0.g*50)` gate on the bias (that factor is litforward-
            // only); the deferred foliage resolve writes the bias raw (b1001:901). Removed it -> 1:1.
            //   envF (b1001:328)         = mad(min((1-r)^2, exp2(NoV*-9.28)), (1-r), mad(r,-0.0275,0.0425))
            //   envSpecScale (b1001:901) = mad(envF,-1.04, mad(r,-0.572,1.04))
            //   envSpecBias  (b1001:901) = mad(envF, 1.04, mad(r, 0.022,-0.04))     [NO f0.g gate]
            // --------------------------------------------------------------------------------------------
            void HgEnvBRDF(float roughness, float NoV, out float envSpecScale, out float envSpecBias)
            {
                float oneMinusRough = mad(roughness, -1.0, 1.0);
                float envF = mad(min(oneMinusRough * oneMinusRough, exp2(NoV * -9.27999973297119140625)),
                                 oneMinusRough,
                                 mad(roughness, -0.0274999998509883880615234375, 0.0425000004470348358154296875));
                envSpecScale = mad(envF, -1.03999996185302734375,
                                   mad(roughness, -0.572000026702880859375, 1.03999996185302734375));
                envSpecBias = mad(envF, 1.03999996185302734375,
                                  mad(roughness, 0.02199999988079071044921875, -0.039999999105930328369140625)); // b1001:901 (no f0.g gate)
            }

            // §2.6 EnvBRDFApprox rational DFG scale (b9:975 _2183) — direct-light multiscatter-diffuse energy.
            float HgEnvBRDFApproxDFG(float roughness)
            {
                float t = mad(roughness, -1.0, 1.0);
                return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875, -0.076194703578948974609375),
                                      1.04997003078460693359375),
                               0.4092549979686737060546875),
                           0.999000012874603271484375);
            }

            // §2.7/§2.8 Cook-Torrance GGX-D + Smith height-correlated Vis + Schlick F (b9:964-983). Returns spec RGB (pre-NoL).
            float3 HgDirectSpecular(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float a   = roughness * roughness;          // b9:967
                float a2  = a * a;                         // b9:968
                float nv  = min(NoV, 1.0);                 // b9:966
                float d   = mad(mad(NoH, a2, -NoH), NoH, 1.0);          // (NoH*a2 - NoH)*NoH + 1 , b9:969
                float visDenom = nv  * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2))
                               + NoL * sqrt(mad(mad(-nv,  a2, nv ), nv , a2))
                               + HGRP_EPS_VIS;                          // b9:981
                float DV  = (a2 / (d * d)) * (0.5 / visDenom);          // D * Vis , b9:981
                float oneMinusVoH = mad(-VoH, 1.0, 1.0);
                float sq   = oneMinusVoH * oneMinusVoH;
                float quad = sq * sq;
                float Fc   = oneMinusVoH * quad;                        // (1-VoH)^5 , b9:973
                float oneMinusFc = mad(-quad, oneMinusVoH, 1.0);
                float3 F   = mad(f0, oneMinusFc.xxx, Fc.xxx);           // lerp(F0,1,Fc) , b9:983
                return DV * F;
            }

            // §2.7/§2.8 Full per-light energy bracket (b9:983): msDiff (multiscatter) + min(spec,2048), clamp [0,1000].
            float3 HgDirectLightEnergy(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float3 specE = HgDirectSpecular(roughness, f0, NoL, NoH, NoV, VoH);
                float  dfg   = HgEnvBRDFApproxDFG(roughness);
                float  oneMinusDfg = mad(-dfg, 1.0, 1.0);
                float  dfgEnergy = dfg / oneMinusDfg;
                float3 gz    = mad((float3(1.0, 1.0, 1.0) - f0), HGRP_GRAZING_FLOOR, f0);   // lerp(F0,1,1/21) , b9:977
                float3 msDiff = (dfgEnergy * (gz * gz)) / mad(-gz, oneMinusDfg, float3(1.0, 1.0, 1.0));
                return min(max(msDiff + min(specE, 2048.0), 0.0), 1000.0);
            }
        ENDHLSL

        // ============================================================================================
        // Pass 0 : ForwardLit  (HGBuffer "GBuffer" pass -> URP forward; leaf base surface b95/b96/b110)
        // ============================================================================================
        Pass {
            Name "ForwardLit"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] OneMinusSrcAlpha
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LeafVertex
                #pragma fragment LeafForwardFragment
                // --- material feature keywords (HGRP multi_compile_local -> URP shader_feature_local) ---
                #pragma shader_feature_local _NORMAL_MAP
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma shader_feature_local _EMISSIVE_MAP
                // --- URP system keywords ---
                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH
                #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
                #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BOX_PROJECTION
                #pragma multi_compile_fragment _ _SCREEN_SPACE_OCCLUSION
                #pragma multi_compile_fog
                #pragma multi_compile_fragment _ LOD_FADE_CROSSFADE
                #pragma multi_compile_instancing

                struct Attributes
                {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float4 tangentOS  : TANGENT;
                    float4 color      : COLOR;     // .x = leaf-card AO mask (b96:218 TEXCOORD_3.x)
                    float2 uv0        : TEXCOORD0;
                    UNITY_VERTEX_INPUT_INSTANCE_ID
                };

                struct Varyings
                {
                    float4 positionCS : SV_Position;
                    float3 positionWS : TEXCOORD0;
                    float3 normalWS   : TEXCOORD1;
                    float4 tangentWS  : TEXCOORD2;  // .xyz tangent, .w sign
                    float2 uv         : TEXCOORD3;
                    float4 color      : TEXCOORD4;  // vertex color rgba (.x AO mask)
                    float3 viewDirWS  : TEXCOORD5;  // camera->fragment, unnormalized
                    float  fogFactor  : TEXCOORD6;
                    UNITY_VERTEX_INPUT_INSTANCE_ID
                    UNITY_VERTEX_OUTPUT_STEREO
                };

                // ---- vertex: object->world->clip via URP infra (drops HG instancing/oct-decode/skin/MV, b95) ----
                Varyings LeafVertex(Attributes IN)
                {
                    Varyings OUT = (Varyings)0;
                    UNITY_SETUP_INSTANCE_ID(IN);
                    UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
                    UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);

                    VertexPositionInputs posInputs = GetVertexPositionInputs(IN.positionOS);   // b95:209-242 obj->world->clip
                    VertexNormalInputs   nrmInputs = GetVertexNormalInputs(IN.normalOS, IN.tangentOS); // b95:227-234 normalize(world N / T)

                    OUT.positionCS = posInputs.positionCS;
                    OUT.positionWS = posInputs.positionWS;
                    OUT.normalWS   = nrmInputs.normalWS;
                    OUT.tangentWS  = float4(nrmInputs.tangentWS, IN.tangentOS.w * GetOddNegativeScale()); // b95:204 TANGENT.w sign
                    OUT.uv         = TRANSFORM_TEX(IN.uv0, _BaseColorMap);     // leaf uses one UV set (b95:250-251)
                    OUT.color      = IN.color;                                 // b95:243-246
                    OUT.viewDirWS  = GetWorldSpaceViewDir(posInputs.positionWS);
                    OUT.fogFactor  = ComputeFogFactor(posInputs.positionCS.z);
                    return OUT;
                }

                // ---- surface assembly: 1:1 from leaf b96 (base, no normal map) / b110 (_NORMAL_MAP) ----
                LeafSurfaceData LeafBuildSurface(Varyings IN, bool isFrontFace)
                {
                    LeafSurfaceData s = (LeafSurfaceData)0;

                    float3 normalGeo = normalize(IN.normalWS);                              // b96:220-223 / b110 TEXCOORD_1 normalize
                    float2 uv = IN.uv;

                    // two-sided front sign: isFrontFace ? +1 : (_TwoSidedNormal>0 ? -1 : +1)  (b96:224 / b110:225 _209)
                    float frontSign = isFrontFace ? 1.0 : mad(_TwoSidedNormal, -2.0, 1.0); // b96:224 / b110:225 _209

                    // front-signed geometric normal (b96:225-227 _210..212)
                    float3 normalGeoSigned = normalGeo * frontSign;

                    // ---- albedo + tint-cover ----
                    // T0/T1 RGB * _BaseColor * _BaseColorBrighterScale, saturate (b96:212-214 / b110:215-217).
                    // Base samples BaseColorMap (T0); _NORMAL_MAP variant samples the same albedo map (b110 T0) and
                    // additionally the NormalMap (b110 T1).
                #ifdef _NORMAL_MAP
                    float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uv);  // b110:214 (albedo on T0)
                    float4 nrm     = SAMPLE_TEXTURE2D(_NormalMap,    sampler_NormalMap,    uv);  // b110:221 (T1: RG normal, B rough, A transmission)
                #else
                    float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uv);  // b96:211 (albedo on T0)
                    float4 nrm     = float4(0.5, 0.5, 0.5, 0.0); // base has no map: midpoint normal, rough=0.5, transmission=0
                #endif
                    float3 albedoRaw = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale); // b96:212-214
                    float3 baseCol   = lerp(albedoRaw, _BaseColor.rgb, _BaseColorTintCover);             // b96:215-217 SV_Target_4.xyz

                    // ---- AO from vertex-color.x (leaf-card occlusion baked into red channel) ----
                    float vAo = IN.color.x - 1.0;                                       // b96:218 _161 = TEXCOORD_3.x - 1
                    float occlusion = saturate(mad(_OcclusionStrength, vAo, 1.0));      // b96:219 _169

                    // ---- world normal (TBN under _NORMAL_MAP; geometric otherwise) ----
                #ifdef _NORMAL_MAP
                    // tangent-space normal: nx=(nrm.x*2-1)*_NormalScale, ny=(nrm.y*2-1)*_NormalScale (b110:222-227)
                    float nx = mad(nrm.x, 2.0, -1.0);                                   // b110:222 _185
                    float ny = mad(nrm.y, 2.0, -1.0);                                   // b110:223 _188
                    float nz = max(sqrt(mad(-min(dot(float2(nx, ny), float2(nx, ny)), 1.0), 1.0, 1.0)), HGRP_EPS_NORMAL_Z); // b110:224 _196
                    float nxs = frontSign * (nx * _NormalScale);                       // b110:226 _215
                    float nys = frontSign * (ny * _NormalScale);                       // b110:227 _216
                    // bitangent sign from tangent.w (b110:213 _114 = tangent.w>0?+1:-1)
                    float bitSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
                    float3 bitangent = bitSign * cross(normalGeo, IN.tangentWS.xyz);
                    // N = nz*Ngeo + nxs*T + nys*bitangent ; normalize ; then re-sign whole by frontSign
                    // (b110:230-236 _281..292 build, b110:237-239 _293..295 = _209 * normalize(...)).
                    float3 normalWS = frontSign * normalize(nz * normalGeo + nxs * IN.tangentWS.xyz + nys * bitangent); // b110:230-239
                    float roughness = lerp(_RoughnessMin, _RoughnessMax, nrm.z);        // b110:264 SV_Target_3.z
                    float transmissionMask = saturate(1.0 - nrm.w) * _Transmission;     // b110:272 clamp(1-nrm.a)* _Transmission
                #else
                    // base shading normal = frontSign * normalize(geoNormal), applied ONCE (b96:220-227 _210..212).
                    float3 normalWS = normalGeoSigned;                                  // b96:225-227
                    float roughness = mad(_RoughnessMax - _RoughnessMin, 0.5, _RoughnessMin); // b96:252 midpoint (no roughness map)
                    float transmissionMask = _Transmission;                            // b96:260 (no NormalMap.a)
                #endif

                    // ---- AO-gated transmission / subsurface  (b96:228-231 / b110:240-243) ----
                    // tFactor = saturate( (AO - start) / range )  with range scaled by (start+range-start) = range. HG: 1/((rng+start)-start)*(AO-start).
                    float transStart = _AoAffectTransmissionStart;                     // b96:228 _234
                    float subStart   = _AoAffectSubsurfaceStart;                       // b96:229 _239
                    float tFactor = saturate((1.0 / ((_AoAffectTransmissionRange + _AoAffectTransmissionStart) - transStart)) * (occlusion - transStart)); // b96:230 _252
                    float sFactor = saturate((1.0 / ((_AoAffectSubsurfaceRange + _AoAffectSubsurfaceStart) - subStart)) * (occlusion - subStart));         // b96:231 _253

                    // distance fade for transmission (camera->frag length): saturate((dist - 60) * -0.1) when enabled (b96:254-260 / b110:266-272)
                    float camDist = length(IN.viewDirWS);                              // |camPos - P| ; HG uses object-origin dist (b96:254-257) -> per-fragment dist substitute
                    float distFade = (_TransmissionDistanceFade > 0.0) ? HgSmooth01(saturate((camDist + TRANSMISSION_FADE_DIST) * TRANSMISSION_FADE_SCALE)) : 1.0; // b96:257-260
                    float transmission = HgSmooth01(tFactor) * (distFade * transmissionMask); // b96:260 / b110:272 SV_Target_2.x
                    float subsurface   = HgSmooth01(sFactor) * _SubsurfaceIntensity;          // b96:239 / b110:251 _322

                    // ---- fake directional (hemispheric) shadow on cam-right axis, baked into AO-shadow (b96:261 / b110:273) ----
                    // _ViewMatrix[0].xyz = camera RIGHT axis -> URP UNITY_MATRIX_V row0.
                    float3 camRight = float3(UNITY_MATRIX_V._m00, UNITY_MATRIX_V._m01, UNITY_MATRIX_V._m02);
                    float ndotR = mad(dot(normalWS, camRight), 0.5, 0.5);              // b96:261 mad(dot(N,row0),0.5,0.5)
                    // fakeShadow = saturate( -pow(ndotR, _Pow) * _Strength + 1 ) * (occlusionShadow = mad(_OcclusionShadow, vAo, 1))   (b96:261)
                    float fakeShadow = saturate(mad(-exp2(log2(max(ndotR, HGRP_FLT_MIN)) * _FakeDirectionalShadowPow), _FakeDirectionalShadowStrength, 1.0))
                                     * mad(_OcclusionShadow, vAo, 1.0);                // b96:261 _OcclusionShadow*_161 path

                    // ---- emissive (R channel * HDR color, optional albedo affect) (leaf _EMISSIVE_MAP) ----
                    float3 emission = 0.0;
                #ifdef _EMISSIVE_MAP
                    float emMask = SAMPLE_TEXTURE2D(_EmissiveMap, sampler_EmissiveMap, uv).r;
                    emission = _EmissiveColorR.rgb * emMask;
                    emission = lerp(emission, emission * baseCol, _AlbedoAffectEmissive); // _AlbedoAffectEmissive: 1 => unaffected (leaf label inverted)
                #endif

                    // ---- dielectric foliage F0 — GROUND TRUTH = HG deferred-lighting reflectance DECODE ----
                    // leaf packs round(7*_Reflectance) into the GBuffer 3-bit field (b96:261). The deferred
                    // resolve reconstructs the reflection F0 as:  (reflField*0.107142857 + 0.5) * 0.08
                    // (deferredlighting/Sub0_Pass10_Fragment_b1001.hlsl:901). With reflField = 7*_Reflectance
                    // (URP has no GBuffer quantization), that is (0.5 + 0.75*_Reflectance)*0.08 = 0.04 + 0.06*_Reflectance.
                    // (The earlier mad(_Reflectance,0.04,0.04) = 0.04..0.08 was inferred and WRONG: slope is 0.06, max 0.10.)
                    float f0scalar = mad(7.0 * _Reflectance, 0.107142865657806396484375, 0.5) * 0.07999999821186065673828125; // b1001:901

                    s.albedo        = baseCol;
                    s.normalWS      = normalWS;
                    s.vertexNormalWS= normalGeoSigned;
                    s.roughness     = roughness;
                    s.occlusion     = occlusion;
                    s.fakeDirShadow = fakeShadow;
                    s.reflectance   = _Reflectance;
                    s.transmission  = transmission;
                    s.subsurface    = subsurface;
                    s.backfaceGI    = _backfaceGiIntensity;
                    s.f0            = f0scalar.xxx;
                    s.emission      = emission;
                    s.alpha         = baseTex.a;
                    return s;
                }

                // ---- forward lighting: HG BRDF spine + foliage translucency ----
                half4 LeafForwardLighting(LeafSurfaceData s, Varyings IN)
                {
                    float3 N = normalize(s.normalWS);
                    // view dir (perspective): normalize(camPos - P) with HG's rsqrt guard (b9:276-280 -> here)
                    float3 viewRaw = IN.viewDirWS;
                    float invLen = rsqrt(max(dot(viewRaw, viewRaw), HGRP_EPS_VIEWLEN));
                    float3 V = viewRaw * invLen;
                    float3 P = IN.positionWS;

                    float roughness = s.roughness;
                    float3 f0       = s.f0;
                    float3 diffuse  = s.albedo;            // dielectric foliage: diffuse = albedo (metallic=0), b9:319-321
                    float occlusion = s.occlusion;

                    float NoV = max(dot(N, V), 0.0);       // b9:327

                    // --- §2.6 env-BRDF (ambient reflection F0 scale/bias) — b1001:328,901 ---
                    float envSpecScale, envSpecBias;
                    HgEnvBRDF(roughness, NoV, envSpecScale, envSpecBias);

                    // --- §2.4 ambient diffuse (HG IV-cascade -> SampleSH) ; §2.5 reflection (probe-bin -> GlossyEnvironmentReflection) ---
                    float3 ambientSH = SampleSH(N);
                    float  perceptualRoughness = saturate(roughness);
                    float3 reflectVec = reflect(-V, N);
                    float3 reflection = GlossyEnvironmentReflection(reflectVec, perceptualRoughness, 1.0);

                    // backface-GI: GROUND TRUTH (deferredlighting/Sub0_Pass10_Fragment_b1001.hlsl:910) — leaf does
                    // NOT do a SampleSH(-N) back-hemisphere lookup. round(31*_backfaceGiIntensity) is packed across
                    // SV_Target_2.z(bits2-4) + SV_Target_3.w(bits0-1) (b96:241,263) and reconstructed by the resolve
                    // as the SECOND term of the forward GI/translucency scalar _2257 = transmission*min(NoV,1) +
                    // _backfaceGiIntensity (b1001:910). It is therefore a forward DIFFUSE-RESPONSE lift, applied with
                    // transmission below — NOT additive -N ambient. The previous SampleSH(-N)*backfaceGI was fabricated
                    // AND double-counted backfaceGI. Removed here; folded into `translucency` at the direct-light term.
                    float3 color = diffuse * ambientSH * occlusion * _EnvironmentGlobalParams0.x                 // term A (ambient diffuse, b1001:977 _629*_1178*envParams.x*_747)
                                 + reflection * (f0 * envSpecScale + envSpecBias) * _EnvironmentGlobalParams0.y; // term B (ambient reflection, b1001:879-881,977)

                    // --- §2.7 main directional light (HG CSM/ASM -> URP main-light shadow) ---
                    float4 shadowCoord = TransformWorldToShadowCoord(P);
                    Light mainLight = GetMainLight(shadowCoord, P, half4(1, 1, 1, 1));
                    // fake-dir-shadow: packed into SV_Target_2.y bits[3..10) (<<3), OR'd above the 3-bit reflectance
                    // (b96:261). The base deferred resolve b1001:901 and the screen-space-shadow-mask variant b1005:823
                    // read ONLY the low 3 bits (& 7u = reflectance); the fakeShadow high bits live in the shadow/AO
                    // MRT and are consumed by the directional per-light pass (not line-traced — see RESIDUAL RISK).
                    // Applying it as a direct main-light modulator is the defensible mapping (named _FakeDirectional*,
                    // packed in the shadow channel); whether HG applies it to direct/ambient/both is uncited.
                    float mainAtten = mainLight.distanceAttenuation * mainLight.shadowAttenuation * s.fakeDirShadow; // b96:261 (application target uncited)
                    {
                        float3 L = mainLight.direction;
                        float3 H = normalize(L + V);
                        // _DiffuseUseVertexNormal does NOT touch direct light. In the source it only blends the
                        // GBuffer *GI* normal: SV_Target_2.z = dot(lerp(mappedN,geoN,_DiffuseUseVertexNormal),-camRight)
                        // (b96:262-263 / b110:274-275), which the deferred resolve consumes into the GI/translucency
                        // scalar _2257 (b1001:910) — NOT the sun Lambert. The HG sun diffuse uses the MAPPED normal
                        // (_170/_171/_172, b1001:326,977). The earlier lerp toward the vertex normal on the DIRECT
                        // term was a misplacement that flattened direct shading under the default (_DiffuseUseVertexNormal=1).
                        // Forward port: direct diffuse uses mapped N; the GI-normal blend has no clean forward analog
                        // and is folded into the SampleSH(N) ambient (kept on mapped N). _DiffuseUseVertexNormal retained
                        // as a uniform so the property/material stays bindable.
                        float NoL  = saturate(dot(L, N));     // b9:964 (mapped normal)
                        float NoLd = NoL;                     // direct diffuse = mapped-normal Lambert (b1001:326,977)
                        float NoH  = saturate(dot(N, H));     // b9:965
                        float VoH  = saturate(dot(V, H));     // b9:970
                        float3 energy = HgDirectLightEnergy(roughness, f0, NoL, NoH, NoV, VoH); // §2.7
                        // foliage translucency/GI — GROUND TRUTH = HG deferred resolve (deferredlighting/
                        // Sub0_Pass10_Fragment_b1001.hlsl:910). The resolve packs ONE forward scalar:
                        //   _2257 = transmission*min(NoV,1)*(1/127)  +  backfaceGI*(1/31)
                        // (term1 = transmission field SV_Target_2.x>>3 * min(NoV,1); term2 = backfaceGI field
                        // reconstructed from SV_Target_2.z + SV_Target_3.w). It scales the DIFFUSE response
                        // (b1001:977) — there is NO dot(-L,N)/dot(V,-L) back-scatter and NO SampleSH(-N) in the
                        // source. NOTE: term2 is _backfaceGiIntensity, NOT subsurface — subsurface (_322, packed in
                        // SV_Target_2.x-low2 / .w, b96:239,264) is consumed by a SEPARATE screen-space SSS profile
                        // pass, not this base resolve, so it has no place in this forward lit term.
                        // TODO(1:1): the source composite also renormalizes diffuse by albedo/maxChannel (_629/_2223,
                        //   b1001:906,977) and applies 1/pi; that whole-term deferred normalization is not transferred
                        //   (it would replace, not augment, the perlight-b9:565-validated base diffuse). The translucency
                        //   SCALE is ported; the SSS-profile blur (subsurface field) is out of forward scope.
                        float translucency = mad(s.transmission, min(NoV, 1.0), s.backfaceGI); // b1001:910 (transmission*min(NoV,1) + backfaceGI)
                        color += (energy * NoL + diffuse * NoLd * (1.0 + translucency)) * (mainAtten * mainLight.color); // b9:983 + b1001:910,977
                    }

                    // --- §2.8 additional lights (HG tile/zbin -> URP loop), same BRDF ---
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
                        float3 energy = HgDirectLightEnergy(roughness, f0, NoL, NoH, NoV, VoH);
                        float atten = light.distanceAttenuation * light.shadowAttenuation;
                        // same forward translucency scale as the main light (b1001:910) — NOT back-scatter.
                        float translucency = mad(s.transmission, min(NoV, 1.0), s.backfaceGI);
                        color += (energy * NoL + diffuse * NoL * (1.0 + translucency)) * (atten * light.color);
                    }
                #endif

                    color += s.emission;
                    color = MixFog(color, IN.fogFactor);   // §2.10 HG fog -> URP MixFog
                    return half4(color, s.alpha);
                }

                half4 LeafForwardFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                #ifdef LOD_FADE_CROSSFADE
                    // HG used an interleaved-gradient discard for LOD crossfade (b96:208-210); URP's faithful substitute.
                    LODFadeCrossFade(IN.positionCS);
                #endif
                    LeafSurfaceData s = LeafBuildSurface(IN, isFrontFace);
                #ifdef _ALPHATEST_ON
                    clip(s.alpha - _AlphaClipThreshold);   // leaf foliage alpha-test (leaf.shader:49-50)
                #endif
                    return LeafForwardLighting(s, IN);
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 1 : ShadowCaster  (leaf Pass1 "SHADOWCASTER" b390/b391 — position-only + URP ApplyShadowBias)
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
                #pragma vertex   LeafShadowVertex
                #pragma fragment LeafShadowFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW
                #pragma multi_compile_fragment _ LOD_FADE_CROSSFADE
                #pragma multi_compile_instancing

                float3 _LightDirection;
                float3 _LightPosition;

                struct Attributes
                {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float2 uv0        : TEXCOORD0;
                    UNITY_VERTEX_INPUT_INSTANCE_ID
                };
                struct Varyings
                {
                    float4 positionCS : SV_Position;
                    float2 uv         : TEXCOORD0;
                    UNITY_VERTEX_INPUT_INSTANCE_ID
                };

                Varyings LeafShadowVertex(Attributes IN)
                {
                    Varyings OUT = (Varyings)0;
                    UNITY_SETUP_INSTANCE_ID(IN);
                    UNITY_TRANSFER_INSTANCE_ID(IN, OUT);

                    float3 positionWS = TransformObjectToWorld(IN.positionOS);
                    float3 normalWS   = TransformObjectToWorldNormal(IN.normalOS);
                #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                    float3 lightDirectionWS = normalize(_LightPosition - positionWS);
                #else
                    float3 lightDirectionWS = _LightDirection;
                #endif
                    // HG bakes shadow bias into _ShadowpassVP CPU-side (leaf base shadow variant has no per-vertex
                    // normal-bias; b390); URP's faithful substitute is ApplyShadowBias + ApplyShadowClamping.
                    OUT.positionCS = ApplyShadowClamping(TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDirectionWS)));
                    OUT.uv = TRANSFORM_TEX(IN.uv0, _BaseColorMap);
                    return OUT;
                }

                half4 LeafShadowFragment(Varyings IN) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                #ifdef LOD_FADE_CROSSFADE
                    LODFadeCrossFade(IN.positionCS);
                #endif
                #ifdef _ALPHATEST_ON
                    // shadow uses its OWN threshold (_ShadowAlphaClipThreshold) — leaf.shader:51, b391.
                    float a = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, IN.uv).a;
                    clip(a - _ShadowAlphaClipThreshold);
                #endif
                    return 0;
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2 : DepthOnly  (leaf Pass2 "DepthOnly" b662/b663 — camera clip, depth write; alpha-clip under keyword)
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
                #pragma vertex   LeafDepthVertex
                #pragma fragment LeafDepthFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma multi_compile_fragment _ LOD_FADE_CROSSFADE
                #pragma multi_compile_instancing

                struct Attributes
                {
                    float3 positionOS : POSITION;
                    float2 uv0        : TEXCOORD0;
                    UNITY_VERTEX_INPUT_INSTANCE_ID
                };
                struct Varyings
                {
                    float4 positionCS : SV_Position;
                    float2 uv         : TEXCOORD0;
                    UNITY_VERTEX_INPUT_INSTANCE_ID
                };

                Varyings LeafDepthVertex(Attributes IN)
                {
                    Varyings OUT = (Varyings)0;
                    UNITY_SETUP_INSTANCE_ID(IN);
                    UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
                    OUT.positionCS = TransformObjectToHClip(IN.positionOS);   // b662 obj->world->camera clip
                    OUT.uv = TRANSFORM_TEX(IN.uv0, _BaseColorMap);
                    return OUT;
                }

                half4 LeafDepthFragment(Varyings IN) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                #ifdef LOD_FADE_CROSSFADE
                    LODFadeCrossFade(IN.positionCS);
                #endif
                #ifdef _ALPHATEST_ON
                    float a = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, IN.uv).a;
                    clip(a - _AlphaClipThreshold);
                #endif
                    return 0;
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 3 : DepthNormalsOnly  (URP SSAO / depth-normals prepass — STYLE_BIBLE §7; maps HG GBuffer-normal need)
        // ============================================================================================
        Pass {
            Name "DepthNormalsOnly"
            Tags { "LightMode"="DepthNormalsOnly" }
            ZWrite On
            Cull [_CullMode]
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LeafDepthNormalsVertex
                #pragma fragment LeafDepthNormalsFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma shader_feature_local _NORMAL_MAP
                #pragma multi_compile_fragment _ LOD_FADE_CROSSFADE
                #pragma multi_compile_instancing

                struct Attributes
                {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float4 tangentOS  : TANGENT;
                    float2 uv0        : TEXCOORD0;
                    UNITY_VERTEX_INPUT_INSTANCE_ID
                };
                struct Varyings
                {
                    float4 positionCS : SV_Position;
                    float3 normalWS   : TEXCOORD0;
                    float4 tangentWS  : TEXCOORD1;
                    float2 uv         : TEXCOORD2;
                    UNITY_VERTEX_INPUT_INSTANCE_ID
                };

                Varyings LeafDepthNormalsVertex(Attributes IN)
                {
                    Varyings OUT = (Varyings)0;
                    UNITY_SETUP_INSTANCE_ID(IN);
                    UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
                    VertexPositionInputs posInputs = GetVertexPositionInputs(IN.positionOS);
                    VertexNormalInputs   nrmInputs = GetVertexNormalInputs(IN.normalOS, IN.tangentOS);
                    OUT.positionCS = posInputs.positionCS;
                    OUT.normalWS   = nrmInputs.normalWS;
                    OUT.tangentWS  = float4(nrmInputs.tangentWS, IN.tangentOS.w * GetOddNegativeScale());
                    OUT.uv         = TRANSFORM_TEX(IN.uv0, _BaseColorMap);
                    return OUT;
                }

                half4 LeafDepthNormalsFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                #ifdef LOD_FADE_CROSSFADE
                    LODFadeCrossFade(IN.positionCS);
                #endif
                #ifdef _ALPHATEST_ON
                    float a = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, IN.uv).a;
                    clip(a - _AlphaClipThreshold);
                #endif
                    float frontSign = isFrontFace ? 1.0 : mad(_TwoSidedNormal, -2.0, 1.0); // b96:224 / b110:225 _209
                    float3 normalGeo = normalize(IN.normalWS);
                #ifdef _NORMAL_MAP
                    float4 nrm = SAMPLE_TEXTURE2D(_NormalMap, sampler_NormalMap, IN.uv);
                    float nx = mad(nrm.x, 2.0, -1.0);
                    float ny = mad(nrm.y, 2.0, -1.0);
                    float nz = max(sqrt(mad(-min(dot(float2(nx, ny), float2(nx, ny)), 1.0), 1.0, 1.0)), HGRP_EPS_NORMAL_Z);
                    float bitSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
                    float3 bitangent = bitSign * cross(normalGeo, IN.tangentWS.xyz);
                    float3 normalWS = normalize(nz * normalGeo + (nx * _NormalScale) * IN.tangentWS.xyz + (ny * _NormalScale) * bitangent) * frontSign;
                #else
                    float3 normalWS = normalGeo * frontSign;
                #endif
                    return half4(NormalizeNormalPerPixel(normalWS), 0.0);
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 4 : RayTracingReflection  (HGRP RT-injection hook — EMPTY STUB; leaf.shader:2209-2221 has no program)
        // ============================================================================================
        Pass {
            Name "RayTracingReflection"
            Tags { "LightMode"="RayTracingReflection" }
            ZTest Equal
            ZWrite Off
            Cull Off
            // intentionally no HLSLPROGRAM (source pass carries only render-state + tag; drop body, keep stub).
        }
    }
}
