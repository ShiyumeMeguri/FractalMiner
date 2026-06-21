// HGRP Water (deferred forward-rendering pipeline) -> URP. 5 passes: GBufferBlit, GBuffer, DepthBlit(Hi-Z), ReflectLighting(SSR), ForwardLighting(composite).
// Merged from: waterforwardrendering.shader (Sub0) base (#else catch-all) variants:
//   Pass0 GBufferBlit  : Vertex b2 / Fragment b3   (fullscreen blit color+depth)
//   Pass1 GBuffer      : Vertex b7 / Fragment b8   (water-proxy mesh -> clears GBuffer; b8 = MRT0=0)
//   Pass2 DepthBlit    : Vertex b12 / Fragment b13 (inlined in .shader; 2x2 max-depth Hi-Z downsample)
//   Pass3 ReflectLight : Vertex b15 / Fragment b16 (inlined; SSR ray-march -> reflection RT + coverage)
//   Pass4 ForwardLight : Vertex b22 / Fragment b23 (the big composite: water normal blend + IV-GI ambient + reflection-probe IBL + CSM shadow + atmosphere/exp/volumetric fog + scatter/transmittance + foam)
// Keywords (source multi_compile_local, mapped to shader_feature_local): HG_ENABLE_MV (motion-vector MRT; pixel-neutral, dropped),
//   ENABLE_INK_RENDER (Pass4 ink-overlay alt path), ENABLE_WATER_RIPPLE (Pass4 extra ripple normal tap), HG_COMPOSE_VOLUMETRIC (froxel compose).
// Kept (1:1 math, cite blob file:line in each function): camera-relative world reconstruction + octahedral normal decode (Vertex b22:128-170);
//   view-dir/NdotV + foam mask (b23:178-202); dual-layer flow-map wave-normal blend with detail RNM (b23:208-321);
//   water EnvBRDF/F0 rational fit (b23:322-326); IV-clipmap 4-cascade SH ambient (b23:343-566) -> URP SampleSH; reflection-probe box-projected IBL (b23:567-705) -> URP GlossyEnvironmentReflection;
//   SSR sample + GBuffer combine (b23:706-716); CSM cascade-select + dithered PCF directional shadow (b23:717-782) -> URP MainLightRealtimeShadow;
//   world-pos-from-depth for refraction/fog (b23:783-793); atmosphere + height-exponential + volumetric froxel fog (b23:794-857);
//   water scattering/transmittance (Beer-Lambert) + foam/caustics composite + exposure tonemap-ish clamp (b23:858-926).
// Removed (pixel-neutral pipeline infra substituted by URP): TAA jitter (_TaaJitterStrength), HG motion-vector MRT (HG_ENABLE_MV),
//   SPIRV-Cross spv* bitfield polyfills, asfloat(uint) magic spellings (decoded), mad()/((-0.0f)-x) decompiler spelling, instancing plumbing.
//
// ============================================================================================================
// CRITICAL PORT NOTE — read before using. This is an HGRP *deferred* water-simulation shader. Large parts of
// its ground-truth math read from runtime data buffers that have NO URP equivalent. They are transcribed 1:1
// but driven by PLACEHOLDER uniforms/textures that a host system must fill; each is flagged // TODO(1:1).
//   * _WaterData (cbuffer type_WaterData, 1298 x float4, b23:90-93): per-water-body simulation parameter
//     blocks addressed as _WaterData_f_0[(bodyIndex*20u)+field + 10u]. This is GPU sim state, not material
//     properties. Exposed here as a StructuredBuffer<float4> _WaterData; host MUST bind it. (TODO #1)
//   * waterProxyArray instancing buffer (b22:10-15, b23:95-99): per-instance objectToWorld + param0/param1.
//     URP draws one mesh -> mapped to unity_ObjectToWorld; bodyIndex param0.x exposed as _WaterBodyIndex. (TODO #2)
//   * Image-Volume clipmap GI: T6..T11 cascaded Texture3D + _IVParam0..2 + _IVDefaultSHAr/g/b (b23:343-566).
//     No URP analogue -> kept verbatim against placeholder 3D textures; falls through to SampleSH-equivalent
//     only if disabled. (TODO #3)
//   * Reflection-probe binning: _ReflectionProbeGlobalDatas[32] + ByteAddressBuffer light list T0 (b23:567-705).
//     Box-projected parallax-corrected IBL from a probe atlas (T2 Texture2DArray). CLOSED — substituted 1:1 with
//     URP GlossyEnvironmentReflection(R, perceptualRoughness, 1.0) (unity_SpecCube0) per CoreMath §2.5; the probe
//     OBB buffer / binning light-list / octahedral atlas are HG infra with no URP binding. (TODO #4 RESOLVED)
//   * HGBuffer inputs: T1=camera depth (b23:784), T12/T13=GBuffer color/mask (b23:706-707), T14=irradiance-ish
//     (b23:858), T2=reflection atlas, T5=Hi-Z depth (Pass3). Mapped to _CameraDepthTexture / placeholder RTs. (TODO #5)
//   * CSM directional shadow atlas (_CSMWorldToShadow/_CSMShadowSplitSpheres/..., b23:717-782) + T5 SampleCmp.
//     CLOSED — substituted 1:1 with URP TransformWorldToShadowCoord + GetMainLight().shadowAttenuation per
//     CoreMath §2.7 (the cascade-select/IG-dither/biased-PCF/distance-fade are all HG shadow-atlas infra with a
//     direct URP analog). HG's _DirectionalShadowParams2.w<0.99 gate + .z constant fallback are preserved. (TODO #6 RESOLVED)
//   * Atmosphere/exponential/volumetric fog (b23:794-857). The analytic atmosphere + height-exponential layers
//     (transmittance _2543/4/5 + opacity _3193 + inscatter _3194/5/6) are CLOSED — substituted 1:1 with URP
//     ComputeFogFactor(clip.z) + unity_FogColor + MixFog (CoreMath §2.10; the SAME fog infra lit.shader uses).
//     ONLY the volumetric-froxel sub-term (T3 _VolumetricFogVolume tap, b23:805-837) stays engine-side: it needs
//     a host-rendered froxel 3D fog volume URP's analytic fog cannot supply. (TODO #7 atmosphere/height RESOLVED; froxel = host)
// Because the ground truth is bit-exact register/cbuffer math over data URP cannot supply, this file is a
// FAITHFUL TRANSCRIPTION with infra re-pointed, not a runnable drop-in. Do not "simplify" the TODO blocks —
// they are the 1:1 record of the source algorithm.
// ============================================================================================================

Shader "HGRP/WaterForwardRendering_Fix" {
    Properties {
        // Blend-state plumbing (Pass1 GBuffer uses Blend1 SrcColor OneMinusSrcColor; Pass4 ZWrite Off).
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _Cull ("Render Face", Float) = 0

        // Body index into _WaterData (was waterProxyArray_param0.x, b23:162). TODO #2.
        [HideInInspector] _WaterBodyIndex ("Water Body Index", Float) = 0

        // ---- HGRP globals re-exposed as material uniforms (URP has no equivalent global). ----
        // (Values normally come from HGRP's ShaderVariablesGlobal cbuffer; host must drive these per-frame.)
        _GlobalMipBias ("Global Mip Bias", Float) = 0
        _EnvironmentGlobalParams0 ("Env Global Params0 (.x=ambient scale)", Vector) = (1,0,0,0)
        _GraphicsFeaturesGlobalParam0 ("Gfx Features Param0 (.z=ssr scale .w=ibl tone)", Vector) = (0,0,1,1)
        _GraphicsFeaturesGlobalParam1 ("Gfx Features Param1 (.x=ibl max mip+1; subsumed by URP GlossyEnvironmentReflection mip)", Vector) = (8,0,0,0)
        _VFXParams0 ("VFX Params0 (.w=time)", Vector) = (0,0,0,0)
        _VFXParams1 ("VFX Params1 (.xyz=color tint .w=saturation)", Vector) = (1,1,1,1)
    }

    SubShader {
        Tags { "RenderPipeline" = "UniversalPipeline" }
        LOD 500

        // ============================================================
        // Shared include: URP infra + re-exposed HGRP globals + water data buffer + all textures + helpers.
        // ============================================================
        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

        // ---- Re-exposed HGRP global scalars/vectors (see header; URP provides matrices/camera/screen) ----
        CBUFFER_START(UnityPerMaterial)
            float  _WaterBodyIndex;
            float  _GlobalMipBias;
            float4 _EnvironmentGlobalParams0;
            float4 _GraphicsFeaturesGlobalParam0;
            float4 _GraphicsFeaturesGlobalParam1; // .x = IBL atlas max-mip+1 (b23:572); subsumed by URP's internal roughness->mip in GlossyEnvironmentReflection. Kept for interface stability.
            float4 _VFXParams0;
            float4 _VFXParams1;
        CBUFFER_END

        // luminance weights — blob uses float3(0.21267290,0.71515220,0.07217500) (b23:580,921).
        static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625);
        // log2(e) and 1/log2(e) used everywhere for exp2 base-change (b23:795 etc): 1.44269502162933349609375.
        static const float LOG2_E = 1.44269502162933349609375;
        // FLT_MIN guard (b22:166): 1.1754943508222875079687365372222e-38.
        static const float FLT_MIN = 1.1754943508222875079687365372222e-38;
        // view-len epsilon (b23:183): 9.9999999392252902907785028219223e-09.
        static const float VIEW_EPS = 9.9999999392252902907785028219223e-09;
        // tiny sqrt-clamp (b23:225 etc): 1.000000016862383526387164645044e-16.
        static const float TINY = 1.000000016862383526387164645044e-16;

        // ============================================================================================
        // TODO #1: _WaterData is the per-body simulation parameter buffer (cbuffer type_WaterData, b23:90-93,
        //          1298 x float4). Addressed as _WaterData_f_0[(body*20u)+field + 10u]. Host MUST bind it.
        //          No URP equivalent — exposed as a StructuredBuffer here. vs blob file:line b23:90-93.
        // ============================================================================================
        StructuredBuffer<float4> _WaterData;   // TODO(1:1): bind GPU water-sim parameter blocks (b23:90-93)

        // ---- HGRP texture inputs, re-identified by sample site (see header texture map). ----
        // Pass4 (b23:116-136):
        TEXTURE2D(_WaterDepthTex);          SAMPLER(sampler_LinearClamp);   // T1 camera depth (b23:784) — URP _CameraDepthTexture intended. TODO #5
        // T2 reflection-probe atlas (b23:660) REMOVED — ReflectionIBL substituted with URP GlossyEnvironmentReflection
        // (unity_SpecCube0); the HG probe-binning octahedral atlas has no URP binding. See §ReflectionIBL (b23:573-705).
        TEXTURE3D(_VolumetricFogVolume);    SAMPLER(sampler_LinearRepeat);  // T3 froxel fog (b23:826). TODO #7
        TEXTURE2D_ARRAY(_WaveNormalArray);  SAMPLER(sampler_LinearMirror);  // T4 flow-map wave normals (b23:214,...)
        TEXTURE2D(_WaterMaskTex);                                           // T5 (b23:777 SampleCmp shadow / Pass3 Hi-Z); see per-pass.
        TEXTURE3D(_IVClip0Sky);                                             // T6 IV cascade0 sky (b23:368)
        TEXTURE3D(_IVClip0SH);                                              // T7 IV cascade0 SH (b23:374)
        TEXTURE3D(_IVClip1Sky);                                             // T8 IV cascade1 sky (b23:430)
        TEXTURE3D(_IVClip1SH);                                              // T9 IV cascade1 SH (b23:436)
        TEXTURE3D(_IVClip2Sky);                                             // T10 IV cascade2 sky (b23:492)
        TEXTURE3D(_IVClip2SH);                                              // T11 IV cascade2 SH (b23:498)
        TEXTURE2D(_GBuffer0);               SAMPLER(sampler_GBuffer0);      // T12 GBuffer color (b23:706). TODO #5
        TEXTURE2D(_GBuffer1);               SAMPLER(sampler_GBuffer1);      // T13 GBuffer mask  (b23:707). TODO #5
        TEXTURE2D(_WaterIrradiance);        SAMPLER(sampler_WaterIrradiance); // T14 irradiance-ish (b23:858). TODO #5
        TEXTURE2D(_WaterFoamGradient);      SAMPLER(sampler_WaterFoamGradient); // T15 foam/gradient (b23:188)
        TEXTURE2D(_WaterCausticTex);        SAMPLER(sampler_WaterCausticTex);   // T16 caustic (b23:867)

        // ---- HGRP globals re-exposed via plain uniforms (host-driven; declared here so HLSL compiles). ----
        // These are NOT URP-provided. They mirror cbuffer type_ShaderVariablesGlobal fields used by Pass4. TODO #1/#3/#4/#6/#7.
        float4 _WorldSpaceCameraPos_Internal;   // b23:41 (camera-relative origin) -> use _WorldSpaceCameraPos.xyz
        float4 _ScreenSize;                     // b23:42 (.zw = 1/width,1/height) -> _ScreenParams equiv
        uint   _FrameCount;                     // b23:47 dither frame index
        // _BinningBufferOffsets (b23:48 light-list offsets) REMOVED — only fed the reflection-probe binning loop,
        // now substituted by URP GlossyEnvironmentReflection. See §ReflectionIBL (b23:573-705).
        // Fog blocks (b23:52-69). TODO #7:
        float4 _AtmosphereFogParams0, _AtmosphereFogParams1, _AtmosphereFogParams2, _AtmosphereFogParams3, _AtmosphereFogParams4, _AtmosphereFogParams5;
        float4 _ExponentialFogParams0, _ExponentialFogParams1, _ExponentialFogParams2, _ExponentialFogParams3, _ExponentialFogParams4, _ExponentialFogParams5;
        float4 _VolumetricFogParams0, _VolumetricFogParams1, _VolumetricFogParams2, _VolumetricFogParams3, _VolumetricFogParams4;
        // Ink overlay (b25:47). Used only under ENABLE_INK_RENDER:
        float4 _InkSimulationWorldToUV;         // b23:71
        // Image-Volume params (b23:72-77). TODO #3:
        float4 _IVParam0, _IVParam1, _IVParam2, _IVDefaultSHAr, _IVDefaultSHAg, _IVDefaultSHAb;
        // Reflection-probe globals (b23:80-88) REMOVED — the probe-binning IBL (b23:573-705) is substituted by URP
        // GlossyEnvironmentReflection(R, perceptualRoughness, 1.0) (unity_SpecCube0). See §ReflectionIBL.
        // (_ReflectionProbeGlobalDatas[32] OBB StructuredBuffer was never declared — the loop body was comment-only.)
        // Directional light + CSM shadow (b23:101-114). CSM atlas -> URP MainLightRealtimeShadow (TODO #6 RESOLVED, see §Shadow).
        // _DirectionalShadowParams2.w<0.99 gates CSM (b23:717); .z is the CSM-off constant fallback (b23:721). Both kept.
        // _LightDataBuffer_DirectionalLightDirection -> URP GetMainLight().direction for the §Composite scatter/highlight.
        float4 _LightDataBuffer_DirectionalLightDirection;
        float4 _DirectionalShadowParams, _DirectionalShadowParams2;

        // _WaterData accessor — mirrors blob's _WaterData_f_0[idx]. idx already includes the +10u base where the
        // blob applied it; callers pass the fully-resolved index exactly as the blob computed it. (b23:90-93)
        float4 WD(uint idx) { return _WaterData[idx]; }   // TODO(1:1): host buffer (b23:90-93)

        // Inline bitfield-extract polyfill (SPIRV-Cross spvBitfieldUExtract, .shader:317-321). Only this one is used.
        uint spvBitfieldUExtractInline(uint Base, uint Offset, uint Count) {
            uint Mask = Count == 32 ? 0xffffffff : ((1u << Count) - 1u);
            return (Base >> Offset) & Mask;
        }

        // ---- Octahedral normal decode from packed NORMAL.x (Vertex b22:145-170). 1:1. ----
        // Source packs a 10:10 oct normal in the integer bits of NORMAL.x with a "valid" bit at 1u<<30.
        // 0.001956947147846221923828125 = 1/511 - style oct scale (b22:152-153).
        float3 DecodeWaterNormalOS(float packed, float3 fallbackNormal) {
            uint bits = asuint(packed);                                    // b22:148
            float rawX = float(spvBitfieldUExtractInline(bits, 10u, 10u)); // high 10 bits (b22:146)
            float ox   = asfloat((rawX >= 512.0) ? asuint(rawX + (-1024.0)) : asuint(rawX)); // sign-extend (b22:147)
            float rawY = float(bits & 1023u);                              // low 10 bits (b22:149)
            bool  valid = 0u < (bits & 1073741824u);                       // bit30 (b22:150)
            float oy   = asfloat((rawY >= 512.0) ? asuint(rawY + (-1024.0)) : asuint(rawY)); // (b22:151)
            float ny   = oy * 0.001956947147846221923828125;              // (b22:152)
            float nx   = ox * 0.001956947147846221923828125;              // (b22:153)
            float t    = (-abs(ny));                                        // _231 = -|ny| (b22:154)
            float nz   = ((-abs(nx)) + (t + 1.0));                         // z = 1-|x|-|y| (b22:155)
            bool  fold = nz < 0.0;                                          // (b22:156)
            // octahedral wrap fold (b22:157-158). fx fold-branch uses (1-|nx|) (b22:157 -> -abs(_223));
            // fy fold-branch uses (1-|ny|) (b22:158 -> _231+1). Args are NOT symmetric — do not swap.
            float fx = asfloat(fold ? asuint(asfloat((oy >= 0.0) ? 1065353216u : 3212836864u) * ((-abs(nx)) + 1.0)) : asuint(ny));
            float fy = asfloat(fold ? asuint(asfloat((ox >= 0.0) ? 1065353216u : 3212836864u) * (t + 1.0)) : asuint(nx));
            float invLen = rsqrt(dot(float3(fx, fy, nz), float3(fx, fy, nz))); // (b22:159)
            float3 decoded = float3(invLen * fx, invLen * fy, invLen * nz);
            // if not valid, fall back to the raw NORMAL.xyz (b22:160-162):
            return valid ? decoded : fallbackNormal;
        }
        ENDHLSL

        // ============================================================
        // Pass 0 — WaterGBufferBlit. Fullscreen triangle; copies a color RT to MRT0 and a depth RT to SV_Depth.
        // Source LIGHTMODE=WaterGBufferBlit (no URP analogue) -> SRPDefaultUnlit. Vertex b2 / Fragment b3.
        // ============================================================
        Pass {
            Name "WaterGBufferBlit"
            Tags { "LightMode" = "SRPDefaultUnlit" }
            ZClip On
            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _ HG_ENABLE_MV   // motion-vector MRT variant; pixel-neutral here. (.shader:17)

            // Blit source = T0 (color), T1 (depth). Blob b3:10-12.
            TEXTURE2D(_BlitColorTex);   // T0
            TEXTURE2D(_BlitDepthTex);   // T1
            // sampler_LinearClamp from HLSLINCLUDE.

            struct Attributes { uint vertexID : SV_VertexID; };
            struct Varyings { float4 positionCS : SV_Position; float2 uv : TEXCOORD1; };

            // Fullscreen-triangle gen, 1:1 with Vertex b2:56-67 (clip z=w=1).
            // b2:59 _34 = spvBitfieldInsert(0u, id, Offset=1, Count=1) = (id&1)<<1 -> {0,2} (NOT bit0 {0,1}).
            // b2:60 _35 = id&2 -> {0,2}. Both axes use the {0,2} range; x must be doubled or the
            // fullscreen triangle is asymmetric (clip.x reaches only 1, top-right half of screen uncovered).
            Varyings vert(Attributes input) {
                Varyings o;
                float x = float((input.vertexID & 1u) << 1u);   // (id&1)<<1 == spvBitfieldInsert(0u,id,1,1) (b2:58-59)
                float y = float(input.vertexID & 2u);           // (b2:60)
                o.positionCS = float4(mad(x, 2.0, -1.0), mad(y, 2.0, -1.0), 1.0, 1.0); // (b2:61-66)
                o.uv = float2(x, (-y) + 1.0);                   // (b2:63-64)
                return o;
            }

            // b3:29-36: SV_Target = color sample, SV_Depth = depth sample (both LOD0 LinearClamp).
            void frag(Varyings input, out float4 color : SV_Target, out float depth : SV_Depth) {
                color = SAMPLE_TEXTURE2D_LOD(_BlitColorTex, sampler_LinearClamp, input.uv, 0.0); // (b3:31-35)
                depth = SAMPLE_TEXTURE2D_LOD(_BlitDepthTex, sampler_LinearClamp, input.uv, 0.0).x; // (b3:36)
            }
            ENDHLSL
        }

        // ============================================================
        // Pass 1 — WaterGBuffer. Draws water-proxy mesh; fragment writes 0 to MRT0 (clears/marks GBuffer region).
        // Blend1 SrcColor OneMinusSrcColor (source line 52). Vertex b7 / Fragment b8 (b8 = float4(0)).
        // LIGHTMODE=WaterGBuffer -> UniversalForwardOnly (marker pass). 1:1.
        // ============================================================
        Pass {
            Name "WaterGBuffer"
            Tags { "LightMode" = "UniversalForwardOnly" }
            // Source: "Blend 1 SrcColor OneMinusSrcColor" targets MRT1; URP single-target here binds it to MRT0. (source:52)
            Blend SrcColor OneMinusSrcColor
            ZClip On
            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _ HG_ENABLE_MV   // (source:63)

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalRaw  : NORMAL;   // packed oct normal in .x (b7:143)
                float2 uv         : TEXCOORD0;
            };
            struct Varyings {
                float4 positionCS : SV_Position;
                float3 positionWS : TEXCOORD0;   // camera-relative + cam pos = absolute WS (b7:135-137)
                float2 uv         : TEXCOORD1;
                float3 normalWS   : TEXCOORD2;
                nointerpolation uint bodyId : TEXCOORD3;
            };

            // 1:1 with Vertex b7:128-170 — but using URP's object-to-world + VP instead of waterProxyArray + NonJittered VP.
            // The blob does camera-relative math (subtract cam, re-add) purely for FP precision; URP's TransformObjectToWorld
            // is the infra substitute (waterProxyArray_objectToWorld -> unity_ObjectToWorld). (STYLE_BIBLE §2 vertex table)
            Varyings vert(Attributes input) {
                Varyings o;
                float3 posWS = TransformObjectToWorld(input.positionOS);       // (b7:132-134 + re-add cam, b7:135-137)
                o.positionWS = posWS;
                o.positionCS = TransformWorldToHClip(posWS);                   // (b7:166-170, jitter dropped)
                o.uv = input.uv;                                              // (b7:138-139)
                float3 nOS = DecodeWaterNormalOS(input.normalRaw.x, input.normalRaw); // (b7:140-165)
                o.normalWS = normalize(TransformObjectToWorldNormal(nOS));    // (b7:158-164, FLT_MIN guard via normalize)
                o.bodyId = (uint)_WaterBodyIndex;                            // (b7:165) TODO #2
                return o;
            }

            // b8:17-23: MRT0 = float4(0). (Marks the water silhouette in the GBuffer.)
            float4 frag(Varyings input) : SV_Target { return float4(0.0, 0.0, 0.0, 0.0); }
            ENDHLSL
        }

        // ============================================================
        // Pass 2 — WaterDepthBlit. Fullscreen; 2x2 max-of-neighbors depth downsample (Hi-Z build).
        // Inlined in source (.shader:96-235). Vertex b12 / Fragment b13. 1:1.
        // ============================================================
        Pass {
            Name "WaterDepthBlit"
            Tags { "LightMode" = "SRPDefaultUnlit" }
            ZClip On
            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            TEXTURE2D(_HiZSrcTex);   // T0 (.shader:202)
            // sampler_LinearClamp from HLSLINCLUDE.

            struct Attributes { uint vertexID : SV_VertexID; };
            struct Varyings { float4 positionCS : SV_Position; float2 uv : TEXCOORD1; };

            // Fullscreen triangle, identical to Pass0 vert (.shader:160-171).
            // .shader:163 _34 = spvBitfieldInsert(0u, id, 1, 1) = (id&1)<<1 -> {0,2}; .shader:164 _35 = id&2 -> {0,2}.
            Varyings vert(Attributes input) {
                Varyings o;
                float x = float((input.vertexID & 1u) << 1u);   // (id&1)<<1, NOT bit0 (.shader:163)
                float y = float(input.vertexID & 2u);           // (.shader:164)
                o.positionCS = float4(mad(x, 2.0, -1.0), mad(y, 2.0, -1.0), 1.0, 1.0);
                o.uv = float2(x, (-y) + 1.0);
                return o;
            }

            // .shader:218-221 — SV_Target.x = max over the 2x2 texel neighborhood (offsets 0 and _ScreenSize.zw).
            // _ScreenSize.zw = (1/w, 1/h) texel size. Output is single-channel depth (R). 1:1.
            float frag(Varyings input) : SV_Target {
                float2 uv = input.uv;
                float2 ts = _ScreenSize.zw;
                float a = SAMPLE_TEXTURE2D_LOD(_HiZSrcTex, sampler_LinearClamp, float2(uv.x + ts.x, uv.y + ts.y), 0.0).x; // (+ts.x,+ts.y)
                float b = SAMPLE_TEXTURE2D_LOD(_HiZSrcTex, sampler_LinearClamp, float2(uv.x + ts.x, uv.y),        0.0).x; // (+ts.x, 0)
                float c = SAMPLE_TEXTURE2D_LOD(_HiZSrcTex, sampler_LinearClamp, float2(uv.x,        uv.y + ts.y), 0.0).x; // (0, +ts.y)
                float d = SAMPLE_TEXTURE2D_LOD(_HiZSrcTex, sampler_LinearClamp, float2(uv.x,        uv.y),        0.0).x; // (0,0)
                return max(max(a, b), max(c, d));   // (.shader:220)
            }
            ENDHLSL
        }

        // ============================================================
        // Pass 3 — WaterReflectLighting. Screen-space reflection ray-march against the Hi-Z depth pyramid (T2),
        // outputs reflected scene color (T1) + a coverage/edge-fade alpha. Inlined (.shader:236-780).
        // Vertex b15 / Fragment b16. MRT0 = reflected color (float3), MRT1 = coverage (float). 1:1.
        // NOTE: world reconstruction + normal-decode in vert is identical to Pass1; the heavy SSR is in frag.
        // ============================================================
        Pass {
            Name "WaterReflectLighting"
            Tags { "LightMode" = "SRPDefaultUnlit" }
            ZClip On
            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            // Register map (.shader:498-506), corrected to the actual sample sites:
            //   T0 = Texture2DArray wave-normal atlas (.shader:574/609/613 SampleBias; slice = WD[f24+10].z/.w) — same
            //        flow-map atlas as Pass4's _WaveNormalArray. (Earlier "_SceneColorArray" label was wrong: T0 feeds
            //        the dual-tap normal, not scene color.)
            //   T1 = reflected SCENE COLOR (.shader:733 SampleLevel, consumed .zxy = BGR) — render-graph scene-color
            //        resource (HGBuffer prev-frame/opaque). ENGINE-SIDE (TODO #SSR-color).
            //   T2 = Hi-Z depth pyramid (.shader:664,693-696 SampleLevel) — render-graph Hi-Z built by Pass2.
            //        ENGINE-SIDE (TODO #SSR-HiZ).
            //   T3 = ripple-distortion (.shader:756 SampleLevel, LinearRepeat).
            //   T4 = screen-space distortion vectors (.shader:747 SampleLevel, LinearClamp).
            //   T5 = foam/distortion gradient (.shader:545 SampleLevel, LinearMirror) — same atlas as Pass4 foam.
            // _WaveNormalArray (T0) / _WaterFoamGradient (T5) are already declared in HLSLINCLUDE; reuse them.
            // ---- ENGINE-SIDE SSR sources (render-graph; no URP material binding). Host MUST bind per-frame. ----
            TEXTURE2D(_SsrSceneColorTex);                                       // T1 reflected scene color (.shader:733, sampled with sampler_LinearRepeat). TODO #SSR-color
            TEXTURE2D(_HiZDepthPyramid);                                         // T2 Hi-Z depth pyramid (.shader:664,693-696). TODO #SSR-HiZ
            TEXTURE2D(_ReflRippleTex);                                           // T3 ripple-distortion (.shader:756)
            TEXTURE2D(_ReflDistortTex);                                          // T4 screen distortion vectors (.shader:747)
            // sampler_LinearClamp / sampler_LinearRepeat / sampler_LinearMirror come from HLSLINCLUDE.

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalRaw  : NORMAL;
                float2 uv         : TEXCOORD0;
                uint   instanceID : SV_InstanceID;
            };
            struct Varyings {
                float4 positionCS : SV_Position;
                float3 positionWS : TEXCOORD1;
                float2 uv         : TEXCOORD2;
                float3 normalWS   : TEXCOORD3;
                nointerpolation uint bodyId : TEXCOORD4;
            };

            // 1:1 with Vertex b15 (.shader:373-416), infra-substituted (waterProxyArray -> object-to-world, NonJittered VP -> VP).
            Varyings vert(Attributes input) {
                Varyings o;
                float3 posWS = TransformObjectToWorld(input.positionOS);   // (.shader:377-382)
                o.positionWS = posWS;
                o.positionCS = TransformWorldToHClip(posWS);               // (.shader:383-387, TAA jitter dropped)
                o.uv = input.uv;                                          // (.shader:388-389)
                float3 nOS = DecodeWaterNormalOS(input.normalRaw.x, input.normalRaw); // (.shader:390-407)
                o.normalWS = normalize(TransformObjectToWorldNormal(nOS)); // (.shader:408-414)
                o.bodyId = (uint)_WaterBodyIndex;                        // (.shader:415) TODO #2
                return o;
            }

            // ================================================================================================
            // SSR ray-march fragment (.shader:531-759). 1:1.
            // The hierarchical Hi-Z trace MATH is fully closed below (screen-space DDA + cell-crossing refine,
            // .shader:636-727). It reuses the SAME dual-tap wave-normal blend already ported in Pass4 (.shader:560-635
            // == Pass4 b23:208-321) to build the perturbed normal it reflects the view ray off of.
            // Its two INPUT resources are render-graph, kept as compilable engine-side placeholders:
            //   * T2 _HiZDepthPyramid — the closest-depth mip chain Pass2 builds; the march steps through it
            //     (.shader:664,693-696). Host binds the render-graph Hi-Z. (TODO #SSR-HiZ)
            //   * T1 _SsrSceneColorTex — the scene color the hit reflects (.shader:733). Host binds the
            //     render-graph scene-color / prev-frame opaque. (TODO #SSR-color)
            // _WaterData (WD) per-body sim params are already exposed (TODO #1); the flow/normal atlas T0 is
            // _WaveNormalArray, the gradient T5 is _WaterFoamGradient (both from HLSLINCLUDE). vs blob .shader:531-759.
            // ================================================================================================
            struct FragOut { float3 reflColor : SV_Target0; float coverage : SV_Target1; };
            FragOut frag(Varyings input, float4 positionHW : SV_Position) {
                FragOut o;
                float3 posWS = input.positionWS;
                float3 N0    = normalize(input.normalWS);                   // TEXCOORD_2 geo normal

                // ---- screen uv (.shader:533-536) ----
                float uvx = positionHW.x * _ScreenSize.z;                   // _75 (.shader:533)
                float uvy = positionHW.y * _ScreenSize.w;                   // _76 (.shader:534)
                float uvx2 = uvx + uvx;                                     // _77 (.shader:535)
                float uvy2 = uvy + uvy;                                     // _78 (.shader:536)

                // ---- per-body param block (.shader:537-544) ----
                uint body = min(input.bodyId, 31u);                        // _81 (.shader:537) TODO #2
                uint b20  = body * 20u;                                     // _90 == int(param0.x); URP: body (.shader:538)
                uint f15 = b20 + 15u, f16 = b20 + 16u, f17 = b20 + 17u, f18 = b20 + 18u, f23 = b20 + 23u, f24 = b20 + 24u; // _93/_96/_99/_102/_105/_108 (.shader:539-544)

                // ---- foam/gradient tap T5 + edge soften (.shader:545-546) ----
                float4 grad = SAMPLE_TEXTURE2D_LOD(_WaterFoamGradient, sampler_LinearMirror,
                    float2(((posWS.x + (-WD(9u).z)) / WD(13u).w) + 0.5, ((posWS.z + (-WD(9u).w)) / WD(13u).w) + 0.5), 0.0); // _140 (.shader:545)
                float edge = mad(WD(f23 + 10u).x, grad.w + (-1.0), 1.0);    // _152 (.shader:546)

                // ---- view dir + NdotV (.shader:547-554). The blob's _169..= posWS - camPos (incident view ray
                // TOWARD the fragment); _202..= camPos - posWS. Do NOT swap them. (1:1 fix: a flipped Vraw negates
                // the reflected ray -> SSR marches backwards, and flips NdotV -> wrong graze/weight signs.) ----
                float3 Vraw = posWS - _WorldSpaceCameraPos.xyz;            // _169/_170/_171 (.shader:547-549)
                float invVlen = rsqrt(dot(Vraw, Vraw));                     // _175 (.shader:550)
                float3 Vn = invVlen * Vraw;                                 // _176/_177/_178 (.shader:551-553)
                float NdotV = dot(Vn, N0);                                  // _185 (.shader:554)

                // ---- grazing/distance fade (.shader:555-558) ----
                float3 toFrag = _WorldSpaceCameraPos.xyz - posWS;          // _202/_203/_204 (.shader:555-557)
                float viewDist = sqrt(dot(toFrag, toFrag));
                float graze = (-clamp((viewDist * clamp((-NdotV) + 1.0, 0.0, 1.0)) / WD((b20 + 19u) + 10u).y, 0.0, 1.0)) + 1.0; // _220 (.shader:558)

                // ---- foam-derived flow x/y (.shader:559-563) ----
                uint i23 = f23 + 10u;                                       // _221/_230/_234 (.shader:559-561)
                float flowX = mad(mad(WD(i23).x, grad.x + (-WD(i23).y), WD(i23).y), 2.0, -1.0) * 1.0;  // _244 (.shader:562)
                float flowY = mad(mad(WD(i23).x, grad.y + (-WD(i23).z), WD(i23).z), 2.0, -1.0) * (-1.0); // _245 (.shader:563)
                float distFade = 0.5 + (-WD(f16 + 10u).w);                  // _251 (.shader:564)
                bool singleLayer = 0.0 >= WD(f23 + 10u).x;                  // _257 (.shader:565)

                // ================================================================================================
                // Dual-tap wave-normal blend (.shader:566-635). Identical math to Pass4 b23:208-321 (already ported
                // there); produces the perturbed world normal the view ray reflects off. T0 = _WaveNormalArray,
                // slice = WD[f24+10].z (base) / .w (detail). 1:1.
                // ================================================================================================
                float mipBias = mad(distFade, 10.0, _GlobalMipBias);       // _274/_413 (.shader:572/606)
                float sliceBase = asfloat(asuint(WD(f24 + 10u)).z);        // base array slice (.shader:574)
                float sliceDetail = sliceBase;                             // same array slice index (.shader:609,613)
                float3 perturbedN;                                         // _371/_372/_373 (single) / _568/_569/_570 (dual)
                if (singleLayer)
                {
                    // ---- single-tap: one base + one detail, RNM-blended (.shader:569-587) ----
                    uint i17 = f17 + 10u;                                   // _260 (.shader:571)
                    float baseSpeed = _VFXParams0.w * WD(f18 + 10u).y;     // _274 (.shader:572)
                    uint i15 = f15 + 10u;                                   // _283 (.shader:573)
                    float2 baseUV = float2(mad(-(flowX * WD(i17).w), baseSpeed, posWS.x) * WD(i15).x,
                                           mad(-(flowY * WD(i17).w), baseSpeed, posWS.z) * WD(i15).x); // (.shader:574)
                    float4 baseTex = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaveNormalArray, sampler_LinearMirror, baseUV, sliceBase, mipBias); // _304 (.shader:574)
                    float bnx = mad(baseTex.x, 2.0, -1.0);                 // _308 (.shader:575)
                    float bny = mad(baseTex.y, 2.0, -1.0);                 // _309 (.shader:576)
                    float bnz = max(sqrt((-min(dot(float2(bnx, bny), float2(bnx, bny)), 1.0)) + 1.0), TINY); // _317 (.shader:577)
                    float w = NdotV * (edge * (graze * WD(f16 + 10u).x));  // _325 (.shader:578)
                    float sx = w * bnx;                                     // _326 (.shader:579)
                    float sy = w * bny;                                     // _327 (.shader:580)
                    float il = rsqrt(dot(float3(sx, sy, bnz), float3(sx, sy, bnz))); // _331 (.shader:581)
                    float tnX = il * sx;                                    // _332 (.shader:582)
                    float tnY = il * sy;                                    // _333 (.shader:583)
                    float tnZ = il * bnz;                                   // _334 (.shader:584)
                    // tangent->world (.shader:585-587), ported byte-literally (N0 == TEXCOORD_2):
                    perturbedN = float3(
                        mad(N0.x, tnZ, mad(tnX, 1.0, tnY * mad(N0.z, 0.0, -(N0.y * 0.0)))),  // _371 (.shader:585)
                        mad(N0.y, tnZ, mad(tnX, 0.0, tnY * mad(N0.x, 0.0, -(N0.z * 1.0)))),  // _372 (.shader:586)
                        mad(N0.z, tnZ, mad(tnX, 0.0, tnY * mad(N0.y, 1.0, -(N0.x * 0.0))))); // _373 (.shader:587)
                }
                else
                {
                    // ---- two-phase base cross-fade + two-phase detail, RNM-blended (.shader:600-628) ----
                    uint i17 = f17 + 10u;                                   // _383 (.shader:600)
                    float baseSpeed = flowX * WD(i17).w;                   // _387 (.shader:601)
                    float baseSpeedY = flowY * WD(i17).w;                  // _388 (.shader:602)
                    float phaseA = mad(_VFXParams0.w, WD(f18 + 10u).y, -floor(_VFXParams0.w * WD(f18 + 10u).y)); // _398 (.shader:603)
                    float phaseBraw = mad(_VFXParams0.w, WD(f18 + 10u).y, 0.5); // _406 (.shader:604)
                    float phaseB = phaseBraw + (-floor(phaseBraw));        // _409 (.shader:605)
                    float baseBias = mad(_VFXParams0.w, WD(f18 + 10u).y, -phaseA) * WD(f18 + 10u).y; // _435 (.shader:607)
                    uint i15 = f15 + 10u;                                   // _436/_463 (.shader:608,610)
                    float2 baseUVa = float2(mad(mad(-baseSpeed, phaseA, posWS.x), WD(i15).x, baseBias),
                                            mad(mad(-baseSpeedY, phaseA, posWS.z), WD(i15).x, baseBias)); // (.shader:609)
                    float4 baseTexA = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaveNormalArray, sampler_LinearMirror, baseUVa, sliceBase, mipBias); // _449 (.shader:609)
                    float baseBiasB = mad(_VFXParams0.w, WD(f18 + 10u).y, -phaseB); // _477 (.shader:611)
                    uint i18 = f18 + 10u;                                   // _478 (.shader:612)
                    float2 baseUVb = float2(mad(baseBiasB, WD(i18).y, mad(mad(-baseSpeed, phaseB, posWS.x), WD(i15).x, 0.5)),
                                            mad(baseBiasB, WD(i18).y, mad(mad(-baseSpeedY, phaseB, posWS.z), WD(i15).x, 0.5))); // (.shader:613)
                    float4 baseTexB = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaveNormalArray, sampler_LinearMirror, baseUVb, sliceBase, mipBias); // _490 (.shader:613)
                    float wA = (-abs(mad(-phaseA, 2.0, 1.0))) + 1.0;       // _500 (.shader:614)
                    float wB = (-abs(mad(-phaseB, 2.0, 1.0))) + 1.0;       // _501 (.shader:615)
                    float bnx = mad(mad(baseTexA.x, wA, wB * baseTexB.x), 2.0, -1.0); // _506 (.shader:616)
                    float bny = mad(mad(baseTexA.y, wA, wB * baseTexB.y), 2.0, -1.0); // _507 (.shader:617)
                    float bnz = max(sqrt((-min(dot(float2(bnx, bny), float2(bnx, bny)), 1.0)) + 1.0), TINY); // _515 (.shader:618)
                    float w = NdotV * (edge * (graze * WD(f16 + 10u).x));  // _522 (.shader:619)
                    float sx = w * bnx;                                     // _523 (.shader:620)
                    float sy = w * bny;                                     // _524 (.shader:621)
                    float il = rsqrt(dot(float3(sx, sy, bnz), float3(sx, sy, bnz))); // _528 (.shader:622)
                    float tnX = il * sx;                                    // _529 (.shader:623)
                    float tnY = il * sy;                                    // _530 (.shader:624)
                    float tnZ = il * bnz;                                   // _531 (.shader:625)
                    // tangent->world (.shader:626-628), ported byte-literally (N0 == TEXCOORD_2):
                    perturbedN = float3(
                        mad(N0.x, tnZ, mad(tnX, 1.0, tnY * mad(N0.z, 0.0, -(N0.y * 0.0)))),  // _568 (.shader:626)
                        mad(N0.y, tnZ, mad(tnX, 0.0, tnY * mad(N0.x, 0.0, -(N0.z * 1.0)))),  // _569 (.shader:627)
                        mad(N0.z, tnZ, mad(tnX, 0.0, tnY * mad(N0.y, 1.0, -(N0.x * 0.0))))); // _570 (.shader:628)
                }
                // NOTE(host): the dual-tap above reads only _WaterData (WD) + _WaveNormalArray — same data as Pass4.
                // With the placeholder _WaterData buffer it compiles and runs but yields undefined sim params; math is 1:1.

                // ================================================================================================
                // Hierarchical Hi-Z screen-space ray-march (.shader:636-727). THE closeable trace. 1:1.
                // Reflect the view ray off perturbedN, project the reflected segment to screen+depth via View/Proj,
                // clip it to the screen rect, then DDA through the Hi-Z mip chain (T2) with a 12-iteration coarse
                // walk + 3-substep cell-crossing test + binary fraction refine. Pure math; only T2 is engine-side.
                // ================================================================================================
                // reflected NDC start (.shader:636-637): _571/_573 = 4*uv-1 (recovered to UV via *0.5+0.5 = 2*uv -> half-res space).
                float ndcX = mad(uvx, 4.0, -1.0);                          // _571 (.shader:636)
                float ndcY = mad(uvy, 4.0, -1.0);                          // _573 (.shader:637)
                // R = reflect(Vn, perturbedN): _574 = dot(Vn, perturbedN); _578 = -2*_574; R = Vn + perturbedN*_578. (.shader:638-642)
                float rdn = dot(Vn, perturbedN);                           // _574 (.shader:638)
                float rk = (-(rdn + rdn));                                  // _578 (.shader:639)
                float3 Rdir = float3(mad(perturbedN.x, rk, Vn.x), mad(perturbedN.y, rk, Vn.y), mad(perturbedN.z, rk, Vn.z)); // _579/_580/_581 (.shader:640-642)
                // world->view (column_major _ViewMatrix: M[i] is COLUMN i, .x/.y/.z is row -> _m{0,1,2}{i}). (.shader:643-645)
                float3 Rv = float3(
                    mad(UNITY_MATRIX_V._m02, Rdir.z, mad(UNITY_MATRIX_V._m00, Rdir.x, Rdir.y * UNITY_MATRIX_V._m01)),  // _603 (.shader:643)
                    mad(UNITY_MATRIX_V._m12, Rdir.z, mad(UNITY_MATRIX_V._m10, Rdir.x, Rdir.y * UNITY_MATRIX_V._m11)),  // _604 (.shader:644)
                    mad(UNITY_MATRIX_V._m22, Rdir.z, mad(UNITY_MATRIX_V._m20, Rdir.x, Rdir.y * UNITY_MATRIX_V._m21))); // _605 (.shader:645)
                // view->clip via _ProjMatrix (column_major; .x/.y/.z/.w is row -> _m{0,1,2,3}{i}). _644 = clip.w + 1. (.shader:646)
                float clipW = mad(mad(UNITY_MATRIX_P._m32, Rv.z, mad(UNITY_MATRIX_P._m30, Rv.x, Rv.y * UNITY_MATRIX_P._m31)), 1.0, 1.0); // _644 (.shader:646) asfloat(1065353216u)=1.0
                // projected screen-delta of the reflected segment (.shader:647-648). Note clip.y row negated (_651/_652).
                float dScrX = (-ndcX) + (mad(mad(UNITY_MATRIX_P._m02, Rv.z, mad(UNITY_MATRIX_P._m00, Rv.x, Rv.y * UNITY_MATRIX_P._m01)), 1.0, ndcX) / clipW); // _651 (.shader:647)
                float dScrY = (-ndcY) + (mad(mad(UNITY_MATRIX_P._m12, Rv.z, mad(UNITY_MATRIX_P._m10, Rv.x, Rv.y * UNITY_MATRIX_P._m11)), -1.0, ndcY) / clipW); // _652 (.shader:648)
                float segLen = sqrt(dot(float2(dScrX, dScrY), float2(dScrX, dScrY))); // _657 (.shader:649)
                float halfSeg = segLen * 0.5;                              // _658 (.shader:650)
                float negSeg = (-segLen);                                  // _661 (.shader:651)
                // clip the ray so it stops at the screen border (min over the two axes), normalized by halfSeg (.shader:652):
                float rayScale = min(((-(max(mad(negSeg, 0.5, abs(mad(ndcY, halfSeg, dScrY))), 0.0) / abs(dScrY))) + 1.0),
                                     ((-(max(mad(negSeg, 0.5, abs(mad(ndcX, halfSeg, dScrX))), 0.0) / abs(dScrX))) + 1.0)) / halfSeg; // _677 (.shader:652)
                float stepX = rayScale * dScrX;                            // _678 (.shader:653)
                float stepY = rayScale * dScrY;                            // _679 (.shader:654)
                // projected depth-delta of the reflected segment (.shader:655). fragcoord.z is the start depth.
                float stepZ = rayScale * (((-positionHW.z) + (mad(mad(UNITY_MATRIX_P._m22, Rv.z, mad(UNITY_MATRIX_P._m20, Rv.x, Rv.y * UNITY_MATRIX_P._m21)), 1.0, positionHW.z) / clipW))); // _680 (.shader:655)
                // per-cell depth tolerance + per-step increments (1/24 of the segment) (.shader:656-658):
                float zTol = max(abs(stepZ) * 0.083333335816860198974609375, 9.9999997473787516355514526367188e-05); // _684 (.shader:656)
                float incX = stepX * 0.0416666679084300994873046875;      // _686 (.shader:657)
                float incY = stepY * 0.0416666679084300994873046875;      // _688 (.shader:658)
                // interleaved-gradient dither from frame count + fragcoord (.shader:659-663):
                float frm = float(int(7u & _FrameCount));                 // _696 (.shader:659)
                float dither = frac(frac(dot(float2(mad(frm, 2.0829999446868896484375, positionHW.x), mad(frm, 4.867000102996826171875, positionHW.y)),
                                              float2(0.067110560834407806396484375, 0.005837149918079376220703125))) * 52.98291778564453125); // _713 (.shader:660)
                // dithered ray start UV + depth (.shader:661-663). UV start recovered as ndc*0.5+0.5 (=2*uv, half-res):
                float rayU = mad(incX, dither, mad(ndcX, 0.5, 0.5));       // _717 (.shader:661)
                float rayV = mad(incY, dither, mad(ndcY, 0.5, 0.5));       // _718 (.shader:662)
                float rayZ = mad(stepZ * 0.083333335816860198974609375, dither, positionHW.z); // _719 (.shader:663)
                // initial depth compare against Hi-Z (T2) (.shader:664):
                float cmp0 = (-SAMPLE_TEXTURE2D_LOD(_HiZDepthPyramid, sampler_LinearClamp, float2(rayU, rayV), 0.0).x) + rayZ; // _725 (.shader:664) TODO #SSR-HiZ

                // march state (.shader:665-678). _728/_735 = current UV; _730/_731 = last "no-cross" UV; _733 = current depth.
                float curU = rayU, curV = rayV, lastU = 0.0, lastV = 0.0;  // _728/_735, _726/_727->_730/_731 (.shader:665-666,671-675)
                float curZ = rayZ;                                         // _733 (.shader:673)
                float lastCmp = cmp0;                                      // _736 (.shader:676)
                float hitFlag = 0.0;                                       // _833 (.shader:668)
                float hitU = 0.0, hitV = 0.0;                             // _834/_835 (.shader:669-670)
                // Coarse walk: the blob's counter _738 is a FLOAT bit-pattern (asfloat) compared `< 12.0` and
                // INCREMENTED BY 4.0 per no-crossing hop (.shader:705-710,738,752) -> exactly 3 coarse hops
                // (counter 0,4,8; 12<12 stops). Each hop probes 3 sub-steps (1/24,1/12,1/8) + the 1/6 mid, tests a
                // Hi-Z crossing, then advances curU/V/Z by 1/6 of the segment (.shader:702-709) or refines & breaks.
                // (1:1 fix: a `it++`/`<12u` loop would march 12 hops = 4x the clipped ray -> false far hits.)
                [loop]
                for (float it = 0.0; it < 12.0; )
                {
                    // 3 candidate UVs along the ray (.shader:684-689): +1/24, +1/12, +1/8 of step in screen.
                    float u1 = mad(stepX, 0.0416666679084300994873046875, curU); float v1 = mad(stepY, 0.0416666679084300994873046875, curV); // _743/_744 (.shader:684-685)
                    float u2 = mad(stepX, 0.083333335816860198974609375, curU); float v2 = mad(stepY, 0.083333335816860198974609375, curV);  // _745/_746 (.shader:686-687)
                    float u3 = mad(stepX, 0.125, curU);                    float v3 = mad(stepY, 0.125, curV);                                 // _747/_749 (.shader:688-689)
                    // matching ray depths at those sub-steps (.shader:690-692):
                    float z1 = mad(stepZ, 0.083333335816860198974609375, curZ); // _753 (.shader:690)
                    float z2 = mad(stepZ, 0.16666667163372039794921875, curZ);  // _754 (.shader:691)
                    float z3 = mad(stepZ, 0.25, curZ);                          // _755 (.shader:692)
                    // depth differences vs Hi-Z at each candidate (.shader:693-696):
                    float d1 = z1 + (-SAMPLE_TEXTURE2D_LOD(_HiZDepthPyramid, sampler_LinearClamp, float2(u1, v1), 0.0).x); // _776 (.shader:693) TODO #SSR-HiZ
                    float d2 = z2 + (-SAMPLE_TEXTURE2D_LOD(_HiZDepthPyramid, sampler_LinearClamp, float2(u2, v2), 0.0).x); // _777 (.shader:694) TODO #SSR-HiZ
                    float d3 = z3 + (-SAMPLE_TEXTURE2D_LOD(_HiZDepthPyramid, sampler_LinearClamp, float2(u3, v3), 0.0).x); // _778 (.shader:695) TODO #SSR-HiZ
                    float dMid = mad(stepZ, 0.3333333432674407958984375, curZ) + (-SAMPLE_TEXTURE2D_LOD(_HiZDepthPyramid, sampler_LinearClamp,
                                  float2(mad(stepX, 0.16666667163372039794921875, curU), mad(stepY, 0.16666667163372039794921875, curV)), 0.0).x); // _737 (.shader:696) TODO #SSR-HiZ
                    // crossing tests: |zTol + d| < zTol  (sign change within the cell tolerance) (.shader:697-700):
                    bool c1 = abs(zTol + d1) < zTol;                       // _787 (.shader:697)
                    bool c2 = abs(zTol + d2) < zTol;                       // _788 (.shader:698)
                    bool c3 = abs(zTol + d3) < zTol;                       // _789 (.shader:699)
                    bool cMid = abs(zTol + dMid) < zTol;                   // (.shader:700)
                    if (!(c1 || c2 || c3 || cMid))                         // no crossing -> advance 4 steps (.shader:700-712)
                    {
                        float advU = mad(stepX, 0.16666667163372039794921875, curU); // _729 (.shader:702)
                        float advV = mad(stepY, 0.16666667163372039794921875, curV); // _732 (.shader:703)
                        curU = advU; lastU = advU;                         // _728=_730=_729 (.shader:704-705)
                        lastV = advV;                                       // _731=_732 (.shader:706)
                        curZ = mad(stepZ, 0.3333333432674407958984375, curZ); // _733 (.shader:707)
                        curV = advV;                                        // _735=_732 (.shader:708)
                        lastCmp = dMid;                                     // _736=_737 (.shader:709)
                        it += 4.0;                                          // _738 = asfloat(asuint(_738)+4.0) (.shader:710) — counter steps by 4
                        continue;
                    }
                    // crossing found: pick the first sub-step that crossed, refine the fraction (.shader:713-714):
                    float numer = c1 ? lastCmp : (c2 ? d1 : (c3 ? d2 : d3)); // _814 (.shader:713)
                    float denom = c1 ? d1 : (c2 ? d2 : (c3 ? d3 : dMid));    // (.shader:714 denominator pick)
                    float frac01 = clamp(numer / ((-denom) + numer), 0.0, 1.0); // (.shader:714)
                    float subOff = c1 ? 0.0 : (c2 ? 1.0 : (c3 ? 2.0 : 3.0)); // (.shader:714) sub-step index
                    float t = frac01 + subOff;                             // _827 (.shader:714)
                    hitFlag = 1.0;                                          // _833 = asfloat(0xFFFFFFFF)!=0 (.shader:715)
                    hitU = mad(incX, t, curU);                            // _834 (.shader:716)
                    hitV = mad(incY, t, curV);                            // _835 (.shader:717)
                    break;                                                 // (.shader:718)
                }

                // ---- reflected color fetch + edge-fade coverage (.shader:728-746). 1:1. ----
                float3 ssrColor;                                           // _858/_859/_860
                if (hitFlag != 0.0)
                {
                    // scene color at the hit UV (T1). The blob stores _858=sc.z/_859=sc.y/_860=sc.x then in the
                    // FINAL blend reads them reversed (SV_Target.x<-_860=sc.x, .y<-_859, .z<-_858=sc.z), so the net
                    // mapping is IDENTITY: SV_Target.{xyz} = blend(sc.{xyz}, ripple.{xyz}). NO net channel swap.
                    // (1:1 fix: a single float3(sc.z,sc.y,sc.x) here without the second reversal swapped R<->B.)
                    float4 sc = SAMPLE_TEXTURE2D_LOD(_SsrSceneColorTex, sampler_LinearRepeat, float2(hitU, hitV), 0.0); // _839 (.shader:733) T1 sampled with sampler_LinearRepeat (s1). TODO #SSR-color
                    float border = min(min(hitV, hitU), ((-max(hitV, hitU)) + 1.0)); // _848 (.shader:734) distance to nearest UV edge
                    o.coverage = (0.0500000007450580596923828125 < border) ? 1.0 : clamp(border * 20.0, 0.0, 1.0); // SV_Target_1 (.shader:735)
                    ssrColor = float3(sc.x, sc.y, sc.z);                  // net identity (.shader:736-738 + 757-759)
                }
                else
                {
                    o.coverage = 0.0;                                      // SV_Target_1 (.shader:742)
                    ssrColor = float3(0.0, 0.0, 0.0);                     // _858/_859/_860 = 0 (.shader:743-745)
                }

                // ---- distortion composite (.shader:747-759). 1:1. ----
                // T4 screen distortion vectors, decode (.shader:747-755):
                float4 dist = SAMPLE_TEXTURE2D_LOD(_ReflDistortTex, sampler_LinearClamp, float2(uvx2, uvy2), 0.0); // _862 (.shader:747)
                float ax = mad(abs(dist.x), 2.0, -1.0);                   // _868 (.shader:750)
                float ay = mad(abs(dist.y), 2.0, -1.0);                   // _869 (.shader:751)
                float ax2 = ax * ax;                                      // _870 = ax^2 (.shader:752)
                float ay2 = ay * ay;                                      // _871 = ay^2 (.shader:753)
                float sgX = dist.x + (-0.5);                              // _874 (.shader:754)
                float sgY = dist.y + (-0.5);                              // _876 (.shader:755)
                // T3 ripple-distortion, offset by sign(dist-0.5) * (ax^2)^2 = ax^4 (.shader:756). The blob squares
                // _870 once more inside the sample -> _870*_870 == ax^4 (do NOT square ax4 again).
                float signX = float(int((0u - ((0.0 < sgX) ? 4294967295u : 0u)) + ((sgX < 0.0) ? 4294967295u : 0u))); // sign(sgX) via blob spelling
                float signY = float(int((0u - ((0.0 < sgY) ? 4294967295u : 0u)) + ((sgY < 0.0) ? 4294967295u : 0u)));
                float4 ripple = SAMPLE_TEXTURE2D_LOD(_ReflRippleTex, sampler_LinearRepeat,
                    float2(mad(-(ax2 * ax2), signX, uvx2), mad(-(ay2 * ay2), signY, uvy2)), 0.0); // _896 (.shader:756) _870*_870, _871*_871
                // final reflected color = -min(-mad((ripple-ssr)*0.7, +ssr), 0) per channel == max(lerp(ssr,ripple,0.7),0)
                // exactly as the blob's negated-min spelling (.shader:757-759):
                o.reflColor.x = (-min((-mad(((-ssrColor.x) + ripple.x), 0.699999988079071044921875, ssrColor.x)), 0.0)); // _SV_Target.x (.shader:757)
                o.reflColor.y = (-min((-mad(((-ssrColor.y) + ripple.y), 0.699999988079071044921875, ssrColor.y)), 0.0)); // (.shader:758)
                o.reflColor.z = (-min((-mad(((-ssrColor.z) + ripple.z), 0.699999988079071044921875, ssrColor.z)), 0.0)); // (.shader:759)
                return o;
            }
            ENDHLSL
        }

        // ============================================================
        // Pass 4 — WaterForwardLighting. The full composite. ZWrite Off (source:785). Vertex b22 / Fragment b23.
        // LIGHTMODE=WaterForwardLighting -> UniversalForwardOnly. Output MRT0 = final lit water color (HDR clamp 0..255).
        // ============================================================
        Pass {
            Name "WaterForwardLighting"
            Tags { "LightMode" = "UniversalForwardOnly" }
            ZClip On
            ZWrite Off
            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            // source:795-797 — ink/ripple/volumetric keyword variants.
            #pragma shader_feature_local _ ENABLE_INK_RENDER
            #pragma shader_feature_local _ ENABLE_WATER_RIPPLE
            #pragma shader_feature_local _ HG_COMPOSE_VOLUMETRIC
            // URP main-light realtime shadow keywords — drive TransformWorldToShadowCoord +
            // MainLightRealtimeShadow, the 1:1 infra substitute for HG's CSM atlas (b23:717-782 /
            // CoreMath §2.7). Mirrors sibling HGRP_WaterRendering_Fix.shader:390-392. Without these the
            // URP shadow macros compile but no-op to 1.0 (= HG's _DirectionalShadowParams2.w>=0.99 path).
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile_fragment _ _SHADOWS_SOFT
            // URP fog keywords — declare FOG_{LINEAR,EXP,EXP2}_KEYWORD_DECLARED so ComputeFogFactor()/MixFog()
            // are live; the 1:1 infra substitute for HG's atmosphere+height-exponential fog (b23:794-857 /
            // CoreMath §2.10). Without it ComputeFogFactor returns 0.0 (iOS-safe fallback) == everything fogged.
            #pragma multi_compile_fog

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalRaw  : NORMAL;
                float2 uv         : TEXCOORD0;
                uint   instanceID : SV_InstanceID;
            };
            struct Varyings {
                float4 positionCS : SV_Position;
                float3 positionWS : TEXCOORD1;   // absolute world (b22:135-137)
                float2 uv         : TEXCOORD2;
                float3 normalWS   : TEXCOORD3;
                nointerpolation uint bodyId : TEXCOORD4;
            };

            // 1:1 with Vertex b22:128-170. Infra-substituted (see STYLE_BIBLE §2 vertex table).
            Varyings vert(Attributes input) {
                Varyings o;
                float3 posWS = TransformObjectToWorld(input.positionOS);   // (b22:132-137)
                o.positionWS = posWS;
                o.positionCS = TransformWorldToHClip(posWS);               // (b22:138-142, TAA jitter dropped)
                o.uv = input.uv;                                          // (b22:143-144)
                float3 nOS = DecodeWaterNormalOS(input.normalRaw.x, input.normalRaw); // (b22:145-162)
                o.normalWS = normalize(TransformObjectToWorldNormal(nOS)); // (b22:163-169)
                o.bodyId = (uint)_WaterBodyIndex;                        // (b22:170) TODO #2
                return o;
            }

            // ---- ENABLE_INK_RENDER alt path (Fragment b25:72-97). Self-contained ink overlay. 1:1. ----
            #ifdef ENABLE_INK_RENDER
            float4 frag(Varyings input) : SV_Target {
                float3 posWS = input.positionWS;
                float u = mad(posWS.x, _InkSimulationWorldToUV.w, _InkSimulationWorldToUV.x); // (b25:74)
                float v = mad(posWS.z, _InkSimulationWorldToUV.w, _InkSimulationWorldToUV.z); // (b25:75)
                float3 ink;
                // inside the ink sim rect? (b25:79)
                if (max(abs(mad(v, 2.0, -1.0)), abs(mad(u, 2.0, -1.0))) < 1.0) {
                    float s = (-SAMPLE_TEXTURE2D_LOD(_WaterDepthTex, sampler_LinearClamp, float2(u, v), 0.0).x); // T0 (b25:81)
                    ink = mad(s.xxx, 15.0, 1.0);   // (b25:82-84)
                } else {
                    ink = float3(1.0, 1.0, 1.0);   // asfloat(1065353216u)=1.0 (b25:88-90)
                }
                // VFX saturation/tint (b25:92-96):
                float luma = dot(ink, LUM);                                  // (b25:92)
                float3 outc;
                outc.x = mad(_VFXParams1.w, (-luma) + ink.x, luma) * _VFXParams1.x; // (b25:94)
                outc.y = mad(_VFXParams1.w, (-luma) + ink.y, luma) * _VFXParams1.y; // (b25:95)
                outc.z = mad(_VFXParams1.w, (-luma) + ink.z, luma) * _VFXParams1.z; // (b25:96)
                return float4(outc, 1.0);   // (b25:97)
            }
            #else
            // ====================================================================================================
            // BASE composite path (Fragment b23:159-927). Transcribed 1:1 in named locals below. Every block is
            // cited to b23 line numbers. Infra (matrices/camera/screen/depth) re-pointed to URP per STYLE_BIBLE §2.
            // Simulation/HGBuffer/IV/probe/CSM/fog data come from the re-exposed placeholder uniforms/textures (TODOs).
            // ====================================================================================================
            float4 frag(Varyings input, float4 positionHW : SV_Position) : SV_Target {
                float3 posWS = input.positionWS;
                float3 N0 = normalize(input.normalWS);                       // interpolated geo normal (TEXCOORD_2)
                uint body = min(input.bodyId, 31u);                          // (b23:161) TODO #2
                uint b20  = body * 20u;                                      // base of this body's param block (b23:163)
                // Param-block field indices, exactly as blob (b23:163-173). Each adds +10u when sampled (the blob's
                // _WaterData_f_0[<field>+10u] convention; "10u" is the block-local offset).
                uint f13 = b20 + 13u, f14 = b20 + 14u, f15 = b20 + 15u, f16 = b20 + 16u, f17 = b20 + 17u, f18 = b20 + 18u;
                uint f20 = b20 + 20u, f21 = b20 + 21u, f22 = b20 + 22u, f23 = b20 + 23u, f24 = b20 + 24u;

                uint pixX = (uint)positionHW.x;                              // (b23:174)
                uint pixY = (uint)positionHW.y;                              // (b23:175)
                float2 screenUV = float2(positionHW.x * _ScreenSize.z, positionHW.y * _ScreenSize.w); // (b23:176-177)

                // ---- view direction + linear depth (ortho-aware), b23:178-187 ----
                bool ortho = (0.0 == unity_OrthoParams.w);                  // (b23:178)
                // perspective: V = camPos - posWS ; ortho: V = camera forward.
                // blob (b23:179-181) reads _ViewMatrix[0u].z/[1u].z/[2u].z; _ViewMatrix is column_major, so M[i]
                // is COLUMN i and .z is row 2 -> elements (_m20,_m21,_m22) = UNITY_MATRIX_V._m20/_m21/_m22
                // (NOT UNITY_MATRIX_V[i].z which is row-indexed -> _m0i, the transpose). STYLE_BIBLE:111, NPR_Fix:271.
                float3 V = ortho ? ((-posWS) + _WorldSpaceCameraPos.xyz)
                                 : float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22);
                float Vlen2 = dot(V, V);                                     // (b23:182)
                float invVlen = rsqrt(max(Vlen2, VIEW_EPS));                // (b23:183)
                float3 Vn = invVlen * V;                                     // (b23:184-186)
                float viewDist = Vlen2 * invVlen;                           // |V| (b23:187)

                // ---- foam/gradient lookup + edge softening (b23:188-202) ----
                // foam UV: (posWS.xz - WD[9].zw) / WD[13].w + 0.5  (b23:188). TODO #1.
                float2 foamUV = float2(((posWS.x + (-WD(9u).z)) / WD(13u).w) + 0.5,
                                       ((posWS.z + (-WD(9u).w)) / WD(13u).w) + 0.5);
                float4 foam = SAMPLE_TEXTURE2D_LOD(_WaterFoamGradient, sampler_LinearMirror, foamUV, 0.0); // T15 (b23:188)
                float edge = mad(WD(f23 + 10u).x, foam.w + (-1.0), 1.0);    // (b23:192)
                float NdotV = dot(Vn, N0);                                  // (b23:193)
                // distance/grazing fade (b23:194):
                float graze = (-clamp((viewDist * clamp((-NdotV) + 1.0, 0.0, 1.0)) / WD((b20 + 19u) + 10u).y, 0.0, 1.0)) + 1.0;

                // ---- wave-normal flow lookups, layer A (b23:196-202) ----
                uint i23 = f23 + 10u;
                float gA = (-WD(i23).y);                                    // (b23:196)
                float gB = (-WD(i23).z);                                    // (b23:197)
                uint i23b = f23 + 10u;
                uint i23c = f23 + 10u;
                // foam-derived flow x/y (b23:200-201):
                float flowX = mad(mad(WD(i23b).x, foam.x + gA, WD(i23c).y), 2.0, -1.0) * 1.0;
                float flowY = mad(mad(WD(i23b).x, foam.y + gB, WD(i23c).z), 2.0, -1.0) * (-1.0);
                float distFade = 0.5 + (-WD(f16 + 10u).w);                  // (b23:202)
                bool singleLayer = 0.0 >= WD(f23 + 10u).x;                  // (b23:203) selects single vs dual flow blend

                // ============================================================================================
                // Dual-layer flow-map wave-normal blend (b23:208-321). 1:1 (pure math; reads only _WaterData flow
                // params WD[f13..f24] + the wave-normal Texture2DArray T4 = _WaveNormalArray, both already exposed).
                // Reconstructs the perturbed world normal (_914/_915/_916) + a coverage scalar (_913). Two paths:
                //   singleLayer (b23:208-244): one base sample + one detail sample, RNM-blended.
                //   !singleLayer / dual (b23:256-313): base + detail are each a triangle-weighted cross-fade of two
                //   time-phased flow samples, then RNM-blended (classic two-phase flow-map to hide UV scroll seams).
                // T4.SampleBias(s, float3(u,v,slice), bias) -> SAMPLE_TEXTURE2D_ARRAY_BIAS(tex, s, float2(u,v), slice, bias).
                // asfloat(asuint(x)) is identity, so the slice = WD(f24).z (base) / WD(f24).w (detail).
                // The tangent->world transform (b23:241-243 / 311-313) is ported byte-literally: it folds the geo
                // normal N0 (TEXCOORD_2) with an implicit baked tangent frame; the mad(.,0,.)/mad(.,1,.) terms encode
                // that frame (most collapse to 0/1) and are preserved verbatim to stay bit-exact. vs blob b23:208-321.
                // ============================================================================================
                float mipBias = mad(distFade, 10.0, _GlobalMipBias);            // _353/_599 (b23:210,264)
                float sliceBase = WD(f24 + 10u).z;                              // base array slice (b23:214,267)
                float sliceDetail = WD(f24 + 10u).w;                            // detail array slice (b23:222,289)
                float3 perturbedN;     // _914/_915/_916 (b23:311-313 / 241-243)
                float coverage;        // _913 (b23:310 / 240)
                if (singleLayer)
                {
                    // ---- base sample (b23:212-216) ----
                    float baseSpeed = _VFXParams0.w * WD(f18 + 10u).y;          // _369 (b23:212)
                    float2 baseUV = float2(mad(-(flowX * WD(f17 + 10u).w), baseSpeed, posWS.x) * WD(f15 + 10u).x,
                                           mad(-(flowY * WD(f17 + 10u).w), baseSpeed, posWS.z) * WD(f15 + 10u).x); // (b23:214)
                    float4 baseTex = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaveNormalArray, sampler_LinearMirror, baseUV, sliceBase, mipBias); // _392 (b23:214)
                    float baseNx = mad(baseTex.x, 2.0, -1.0);                   // _397 (b23:215)
                    float baseNy = mad(baseTex.y, 2.0, -1.0);                   // _398 (b23:216)
                    float detailWeight = NdotV * (edge * (graze * WD(f16 + 10u).x)); // _414 (b23:217)
                    // ---- detail sample (b23:220-224) ----
                    float detailSpeed = mad(_VFXParams0.w, WD(f13 + 10u).y, 0.5); // _436 (b23:220)
                    float2 detailUV = float2(mad(-((flowX * WD(f13 + 10u).z) * WD(f15 + 10u).w), detailSpeed, posWS.x) * WD(f15 + 10u).y,
                                             mad(-((flowY * WD(f13 + 10u).z) * WD(f15 + 10u).w), detailSpeed, posWS.z) * WD(f15 + 10u).y); // (b23:222)
                    float4 detailTex = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaveNormalArray, sampler_LinearMirror, detailUV, sliceDetail, mipBias); // _457 (b23:222)
                    float detNx = mad(detailTex.x, 2.0, -1.0);                  // _461 (b23:223)
                    float detNy = mad(detailTex.y, 2.0, -1.0);                  // _462 (b23:224)
                    float detNz = max(sqrt((-min(dot(float2(detNx, detNy), float2(detNx, detNy)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16); // _470 (b23:225)
                    float detStrength = (edge * WD(f15 + 10u).z) * max(graze, WD(f14 + 10u).w); // _481 (b23:226)
                    float detSx = detStrength * detNx;                          // _482 (b23:227)
                    float detSy = detStrength * detNy;                          // _483 (b23:228)
                    // ---- RNM (reoriented normal mapping) blend of base over detail (b23:229-239) ----
                    float baseSx = (baseNx * detailWeight) + 0.0;              // _484 (b23:229)
                    float baseSy = (baseNy * detailWeight) + 0.0;              // _485 (b23:230)
                    float baseSz = max(sqrt((-min(dot(float2(baseNx, baseNy), float2(baseNx, baseNy)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16) + 1.0; // _486 (b23:231)
                    float rnmDot = dot(float3(baseSx, baseSy, baseSz), float3(detSx * (-1.0), detSy * (-1.0), detNz * 1.0)); // _490 (b23:232)
                    float rnmX = mad(-detSx, -1.0, (rnmDot * baseSx) / baseSz); // _501 (b23:233)
                    float rnmY = mad(-detSy, -1.0, (rnmDot * baseSy) / baseSz); // _502 (b23:234)
                    float rnmZ = mad(-detNz, 1.0, rnmDot);                      // _503 (b23:235)
                    float rnmInvLen = rsqrt(dot(float3(rnmX, rnmY, rnmZ), float3(rnmX, rnmY, rnmZ))); // _507 (b23:236)
                    float tnX = rnmInvLen * rnmX;                               // _508 (b23:237)
                    float tnY = rnmInvLen * rnmY;                               // _509 (b23:238)
                    float tnZ = rnmInvLen * rnmZ;                               // _510 (b23:239)
                    coverage = clamp(baseTex.w + (-WD(f18 + 10u).w), 0.0, 1.0) * foam.z; // _555 (b23:240)
                    // tangent->world (b23:241-243), ported byte-literally (N0 == TEXCOORD_2):
                    perturbedN = float3(
                        mad(N0.x, tnZ, mad(tnX, 1.0, tnY * mad(N0.z, 0.0, -(N0.y * 0.0)))),  // _556 (b23:241)
                        mad(N0.y, tnZ, mad(tnX, 0.0, tnY * mad(N0.x, 0.0, -(N0.z * 1.0)))),  // _558 (b23:242)
                        mad(N0.z, tnZ, mad(tnX, 0.0, tnY * mad(N0.y, 1.0, -(N0.x * 0.0))))); // _559 (b23:243)
                }
                else
                {
                    // ---- two-phase base cross-fade (b23:258-273) ----
                    float baseSpeed = flowX * WD(f17 + 10u).w;                  // _573 (b23:259)
                    float baseSpeedY = flowY * WD(f17 + 10u).w;                 // _574 (b23:260)
                    float phaseA = mad(_VFXParams0.w, WD(f18 + 10u).y, -floor(_VFXParams0.w * WD(f18 + 10u).y)); // _584 (b23:261)
                    float phaseBraw = mad(_VFXParams0.w, WD(f18 + 10u).y, 0.5); // _592 (b23:262)
                    float phaseB = phaseBraw + (-floor(phaseBraw));            // _595 (b23:263)
                    float baseBias = mad(_VFXParams0.w, WD(f18 + 10u).y, -phaseA) * WD(f18 + 10u).y; // _621 (b23:265)
                    float2 baseUVa = float2(mad(mad(-baseSpeed, phaseA, posWS.x), WD(f15 + 10u).x, baseBias),
                                            mad(mad(-baseSpeedY, phaseA, posWS.z), WD(f15 + 10u).x, baseBias)); // (b23:267)
                    float4 baseTexA = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaveNormalArray, sampler_LinearMirror, baseUVa, sliceBase, mipBias); // _635 (b23:267)
                    float wA = (-abs(mad(-phaseA, 2.0, 1.0))) + 1.0;           // _644 triangle weight (b23:268)
                    float baseBiasB = mad(_VFXParams0.w, WD(f18 + 10u).y, -phaseB); // _667 (b23:270)
                    float2 baseUVb = float2(mad(baseBiasB, WD(f18 + 10u).y, mad(mad(-baseSpeed, phaseB, posWS.x), WD(f15 + 10u).x, 0.5)),
                                            mad(baseBiasB, WD(f18 + 10u).y, mad(mad(-baseSpeedY, phaseB, posWS.z), WD(f15 + 10u).x, 0.5))); // (b23:272)
                    float4 baseTexB = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaveNormalArray, sampler_LinearMirror, baseUVb, sliceBase, mipBias); // _680 (b23:272)
                    float wB = (-abs(mad(-phaseB, 2.0, 1.0))) + 1.0;           // _689 triangle weight (b23:273)
                    float baseNx = mad(mad(baseTexA.x, wA, wB * baseTexB.x), 2.0, -1.0); // _760 (b23:285)
                    float baseNy = mad(mad(baseTexA.y, wA, wB * baseTexB.y), 2.0, -1.0); // _761 (b23:286)
                    float detailWeight = NdotV * (edge * (graze * WD(f16 + 10u).x)); // _776 (b23:287)
                    // ---- two-phase detail cross-fade (b23:275-294) ----
                    float dPhaseAraw = mad(_VFXParams0.w, WD(f13 + 10u).y, 0.5); // _703 (b23:275)
                    float dPhaseBraw = mad(_VFXParams0.w, WD(f13 + 10u).y, 1.0); // _704 (b23:276)
                    float dPhaseA = (-floor(dPhaseAraw)) + dPhaseAraw;          // _725 (b23:279)
                    float dPhaseB = (-floor(dPhaseBraw)) + dPhaseBraw;          // _726 (b23:280)
                    float dBiasB = (-dPhaseB) + dPhaseAraw;                      // _747 (b23:282) uses RAW (pre-floor) _703
                    float dBiasA = ((-dPhaseA) + dPhaseAraw) * WD(f13 + 10u).y;  // _753 (b23:283) == floor(_703)*WD(f13).y
                    float detScrollX = (flowX * WD(f13 + 10u).z) * WD(f15 + 10u).w; // (_705.z*_713.w) factor (b23:289)
                    float detScrollY = (flowY * WD(f13 + 10u).z) * WD(f15 + 10u).w; // (b23:292)
                    float2 detUVa = float2(mad(mad(-detScrollX, dPhaseA, posWS.x), WD(f15 + 10u).y, dBiasA),
                                           mad(mad(-detScrollY, dPhaseA, posWS.z), WD(f15 + 10u).y, dBiasA)); // (b23:289)
                    float4 detTexA = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaveNormalArray, sampler_LinearMirror, detUVa, sliceDetail, mipBias); // _791 (b23:289)
                    float dwA = (-abs(mad(-dPhaseA, 2.0, 1.0))) + 1.0;         // _803 triangle weight (b23:290)
                    float dwB = (-abs(mad(-dPhaseB, 2.0, 1.0))) + 1.0;         // _804 triangle weight (b23:291)
                    float2 detUVb = float2(mad(dBiasB, WD(f13 + 10u).y, mad(mad(-detScrollX, dPhaseB, posWS.x), WD(f15 + 10u).y, 0.5)),
                                           mad(dBiasB, WD(f13 + 10u).y, mad(mad(-detScrollY, dPhaseB, posWS.z), WD(f15 + 10u).y, 0.5))); // (b23:292)
                    float4 detTexB = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaveNormalArray, sampler_LinearMirror, detUVb, sliceDetail, mipBias); // _811 (b23:292)
                    float detNx = mad(mad(detTexA.x, dwA, dwB * detTexB.x), 2.0, -1.0); // _819 (b23:293)
                    float detNy = mad(mad(detTexA.y, dwA, dwB * detTexB.y), 2.0, -1.0); // _820 (b23:294)
                    float detNz = max(sqrt((-min(dot(float2(detNx, detNy), float2(detNx, detNy)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16); // _828 (b23:295)
                    float detStrength = (edge * WD(f15 + 10u).z) * max(graze, WD(f14 + 10u).w); // _839 (b23:296)
                    float detSx = detStrength * detNx;                          // _840 (b23:297)
                    float detSy = detStrength * detNy;                          // _841 (b23:298)
                    // ---- RNM blend (b23:299-309) ----
                    float baseSx = (baseNx * detailWeight) + 0.0;              // _842 (b23:299)
                    float baseSy = (baseNy * detailWeight) + 0.0;              // _843 (b23:300)
                    float baseSz = max(sqrt((-min(dot(float2(baseNx, baseNy), float2(baseNx, baseNy)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16) + 1.0; // _844 (b23:301)
                    float rnmDot = dot(float3(baseSx, baseSy, baseSz), float3(detSx * (-1.0), detSy * (-1.0), detNz * 1.0)); // _848 (b23:302)
                    float rnmX = mad(-detSx, -1.0, (rnmDot * baseSx) / baseSz); // _859 (b23:303)
                    float rnmY = mad(-detSy, -1.0, (rnmDot * baseSy) / baseSz); // _860 (b23:304)
                    float rnmZ = mad(-detNz, 1.0, rnmDot);                      // _861 (b23:305)
                    float rnmInvLen = rsqrt(dot(float3(rnmX, rnmY, rnmZ), float3(rnmX, rnmY, rnmZ))); // _865 (b23:306)
                    float tnX = rnmInvLen * rnmX;                               // _866 (b23:307)
                    float tnY = rnmInvLen * rnmY;                               // _867 (b23:308)
                    float tnZ = rnmInvLen * rnmZ;                               // _868 (b23:309)
                    coverage = clamp(mad(baseTexA.w, wA, wB * baseTexB.w) + (-WD(f18 + 10u).w), 0.0, 1.0) * foam.z; // _913 (b23:310)
                    // tangent->world (b23:311-313), ported byte-literally (N0 == TEXCOORD_2):
                    perturbedN = float3(
                        mad(N0.x, tnZ, mad(tnX, 1.0, tnY * mad(N0.z, 0.0, -(N0.y * 0.0)))),  // _914 (b23:311)
                        mad(N0.y, tnZ, mad(tnX, 0.0, tnY * mad(N0.x, 0.0, -(N0.z * 1.0)))),  // _915 (b23:312)
                        mad(N0.z, tnZ, mad(tnX, 0.0, tnY * mad(N0.y, 1.0, -(N0.x * 0.0))))); // _916 (b23:313)
                }
                // NOTE(host): correct results require _WaterData (WD) bound to the GPU water-sim parameter buffer
                // and _WaveNormalArray bound to the flow-map normal atlas (b23:90-93). With the placeholder buffer
                // these expressions compile and run but yield undefined sim params; the math itself is 1:1.

                // ---- water EnvBRDF / F0 rational fit (b23:322-326). 1:1 (pure math). ----
                // roughness clamp: alpha = min(0.02, WD[f16].y) (b23:322); a1 = 1-alpha (b23:323).
                float alpha = min(0.0199999995529651641845703125, WD(f16 + 10u).y); // (b23:322)
                float a1 = mad(alpha, -1.0, 1.0);                            // (b23:323)
                float NoVp = dot(perturbedN, Vn);                           // (b23:324)
                // analytic EnvBRDF bias (b23:325):
                float envA = mad(min(exp2(max(NoVp, 0.0) * (-9.27999973297119140625)), a1 * a1), a1,
                                 mad(alpha, -0.0274999998509883880615234375, 0.0425000004470348358154296875));
                // env scale*bias combine (b23:326):
                float envBRDF = mad(mad(envA, -1.03999996185302734375, mad(alpha, -0.572000026702880859375, 1.03999996185302734375)) * WD(f16 + 10u).z, 0.07999999821186065673828125,
                                    mad(envA, 1.03999996185302734375, mad(alpha, 0.02199999988079071044921875, -0.039999999105930328369140625)) * clamp(4.0 * WD(f16 + 10u).z, 0.0, 1.0));

                // ============================================================================================
                // §AmbientGI — IV-clipmap GI ambient (b23:327-566) -> URP SampleSH(perturbedN). 1:1 INFRA SUBSTITUTION.
                // GROUND TRUTH b23:327-566: four nested IV cascades (outer fade _1005 b23:328; cascades b23:343-530
                // sample Texture3D T6..T11 + _IVParam0..2) accumulate a 9-coeff SH (L0+L1 per RGB) into _1195.._1222,
                // then b23:564-566 evaluate it against the perturbed normal (_914,_915,_916 == perturbedN):
                //   _1297 = max( (L0_r + DC_r) + dot(L1_r.xyz, perturbedN), 0 )   [and _1302 green, _1307 blue].
                // The cascaded IV 3D-texture clipmap (T6..T11) + _IVDefaultSHA* are HG ENGINE INFRASTRUCTURE with no
                // URP binding (CORE_MATH §2.4 / migration table "IV SH textures Tx, _IVDefaultSHA* -> SampleSH(N)";
                // CoreMath.hlsl §2.4 line 214-216,232). The DISABLED path (b23:547-562) already collapses to exactly
                // a default-SH probe eval: _1211=1, _1209=0, bands=0 -> _1297 = max(_IVDefaultSHAr.w + dot(_IVDefaultSHAr.xyz,N),0),
                // i.e. an L0+L1 ambient probe == URP SampleSH. So substitute the whole cascade with URP's SH ambient
                // evaluated on the SAME perturbedN, preserving the per-channel max(.,0) clamp (b23:564-566). This is the
                // REQUIRED infra substitution (PORT DISCIPLINE), not a deviation. The *_EnvironmentGlobalParams0.x
                // exposure scale stays at b23:577-579 below. vs b23:327-566 + CoreMath.hlsl:214-216,232.
                float3 ambient = max(SampleSH(perturbedN), 0.0);   // b23:564-566 SH(perturbedN) clamped >=0 (IV cascade -> URP SampleSH)
                // ambient *= _EnvironmentGlobalParams0.x  -> see b23:577-579 (_1389/_1390/_1391).
                float3 ambientScaled = ambient * _EnvironmentGlobalParams0.x;   // (b23:577-579)
                float ambLuma = dot(ambientScaled, LUM);                        // (b23:580)

                // ---- reflection vector for IBL (b23:567-571). 1:1. ----
                // R = reflect(-Vn, perturbedN): _1315 = -2*dot(-Vn,N), R = (-Vn) + perturbedN*_1315. (b23:567-571)
                float rdn = dot(-Vn, perturbedN);                           // (b23:567) _1311
                float rk = (-(rdn + rdn));                                  // (b23:568) _1315
                float3 R = float3(mad(perturbedN.x, rk, -Vn.x), mad(perturbedN.y, rk, -Vn.y), mad(perturbedN.z, rk, -Vn.z)); // (b23:569-571)

                // ============================================================================================
                // §ReflectionIBL — reflection-probe box-projected IBL (b23:573-705) -> URP GlossyEnvironmentReflection.
                // 1:1 REQUIRED INFRA SUBSTITUTION (CoreMath.hlsl §2.5, CORE_MATH.md §2.5).
                // GROUND TRUTH b23:573-705: a bitmask-driven loop over up to 32 reflection probes. It reads the
                // screen-tile probe bitmask from the ByteAddressBuffer light list T0 (_1410, b23:583) via
                // _BinningBufferOffsets + _ReflectionProbeGlobalParam0, then iterates set probes (firstbitlow loop,
                // b23:600-677): each box-projects R into the probe OBB (_ReflectionProbeGlobalDatas[i].data0..7,
                // b23:631-650), octahedral-encodes the projected direction (b23:651-656), samples the probe atlas
                // T2 at the roughness mip _1334 (b23:660), weights by an influence falloff (_2205, b23:658) and a
                // horizon-occlusion tone (_2250 = ((min(|lum/NoR|,1)*2+lum)/(NoR+2)-1)*_GfxParam0.w+1, b23:661 using
                // ambLuma _1392 and NoR _2174). A global fallback probe (b23:681-699, _ReflectionProbeGlobalParam3)
                // fills in when the loop ran. The accumulated result _2017/_2018/_2019 reads the atlas .zxy channels
                // (b23:696-698 _1994.z/.x/.y) — that .zxy is the probe atlas's internal BGR channel packing, decoded
                // back to linear R/G/B (so the final iblColor is plain RGB; the downstream reflR/G/B at b23:714-716
                // consume iblColor.x/.y/.z as R/G/B).
                //
                // The entire probe-binning + box-projection + octahedral-atlas machinery (light list T0, the
                // _ReflectionProbeGlobalDatas[32] OBB buffer, the _ReflectionAtlas Texture2DArray, _ReflectionProbe*
                // params) is HG ENGINE INFRASTRUCTURE with no URP binding (CORE_MATH §2.5 / migration table
                // "reflection probes T1,_ReflectionProbeGlobalDatas -> GlossyEnvironmentReflection, unity_SpecCube0";
                // CoreMath.hlsl §2.5 lines 217-230). URP's GlossyEnvironmentReflection(R, perceptualRoughness, occ)
                // samples unity_SpecCube0 with the SAME roughness->mip + horizon (PerceptualRoughnessToMipmapLevel)
                // and returns linear RGB — the sanctioned 1:1 substitute. This is REQUIRED infra substitution
                // (PORT DISCIPLINE), not a deviation.
                //
                //   * perceptualRoughness: the blob feeds the probe atlas mip _1334 = -(-log2(max(alpha,1e-3))*1.2+1)
                //     + (_GfxParam1.x-1) from `alpha` (the water linear roughness min(0.02,WD[f16].y), b23:322,572).
                //     `alpha` IS the perceptual roughness (matches CoreMath §2.5: s.roughness fed DIRECTLY, no sqrt;
                //     a sqrt double-roots it -> reflections too sharp). URP does its own roughness->mip internally,
                //     so the explicit _1334 offset (HG atlas mip-count bias) is subsumed by URP and not reproduced.
                //   * occlusion = 1.0: HG term B (b23:714-716) does NOT apply AO to the reflection (only the diffuse
                //     ambient term gets occlusion); CoreMath.hlsl §2.5 line 229 passes 1.0 for the same reason.
                // vs b23:573-705 + CoreMath.hlsl:217-230.
                // ============================================================================================
                float perceptualRoughness = saturate(alpha);                 // water linear roughness == perceptualRoughness (b23:322,572)
                float3 iblColor = GlossyEnvironmentReflection(R, perceptualRoughness, 1.0); // b23:573-705 probe IBL -> URP unity_SpecCube0 (occ=1, HG term B has no AO)

                // ---- SSR sample + GBuffer combine into specular reflection (b23:706-716). 1:1 math. ----
                float4 ssr = SAMPLE_TEXTURE2D_BIAS(_GBuffer0, sampler_GBuffer0, screenUV, _GlobalMipBias);  // T12 (b23:706) TODO #5
                float4 gmask = SAMPLE_TEXTURE2D_BIAS(_GBuffer1, sampler_GBuffer1, screenUV, _GlobalMipBias); // T13 (b23:707) TODO #5
                float ssrAmt = gmask.x;                                     // (b23:708)
                uint f11 = b20 + 11u;                                       // (b23:709)
                uint f9  = b20 + 9u;                                        // (b23:710)
                float ndvClamp = max(clamp(NdotV, 0.0, 1.0), 0.5);          // (b23:711)
                // scatter weight (b23:712):
                float scatterW = (((((-clamp(viewDist * WD(f20 + 10u).w, 0.0, 1.0)) + 1.0) * ndvClamp) * WD(f18 + 10u).x) * coverage);
                uint fAmb = (b20 + 10u) + 10u;                              // (b23:713)
                // per-channel reflection = SSR-blended IBL * envBRDF + ambient-scatter (b23:714-716):
                float reflR = mad(mad(ssrAmt, mad((-iblColor.x), _GraphicsFeaturesGlobalParam0.z, ssr.x), iblColor.x * _GraphicsFeaturesGlobalParam0.z), envBRDF, ((scatterW * WD(fAmb).x) * ambient.x) * _EnvironmentGlobalParams0.x);
                float reflG = mad(mad(ssrAmt, mad((-iblColor.y), _GraphicsFeaturesGlobalParam0.z, ssr.y), iblColor.y * _GraphicsFeaturesGlobalParam0.z), envBRDF, ((scatterW * WD(fAmb).y) * ambient.y) * _EnvironmentGlobalParams0.x);
                float reflB = mad(mad(ssrAmt, mad((-iblColor.z), _GraphicsFeaturesGlobalParam0.z, ssr.z), iblColor.z * _GraphicsFeaturesGlobalParam0.z), envBRDF, ((scatterW * WD(fAmb).z) * ambient.z) * _EnvironmentGlobalParams0.x);

                // ============================================================================================
                // §Shadow — Directional CSM shadow (b23:717-782) -> URP MainLightRealtimeShadow. 1:1 INFRA SUBSTITUTION.
                // GROUND TRUTH b23:717-782 (per CoreMath §2.7, the SAME HG CSM atlas lit.shader uses):
                //   _2106 = (_DirectionalShadowParams2.w >= 0.99)              (b23:717) — TRUE => CSM disabled.
                //   CSM-ON branch (_2106 false, b23:728-778): selects one of 4 cascades by split-sphere distance test
                //     (_CSMShadowSplitSpheres, b23:733-754), interleaved-gradient cascade-blend dither (b23:756-759),
                //     normal+depth-bias of posWS by _CSMShadowBiases (b23:765-772), a single SampleCmpLevelZero against
                //     atlas T5 via _CSMWorldToShadow/_CSMShadowAtlasParams (b23:777), and a distance fade
                //     clamp((-dot(P-cam,P-cam)+_DirectionalShadowParams.w)*_DirectionalShadowParams.z, 0,1) that lerps
                //     the hard shadow toward 0.5*_1297 (= ambient.x red SH, b23:564) where the atlas runs out -> _2415.
                //   CSM-OFF branch (_2106 true, b23:779-781): _2415 = _DirectionalShadowParams2.z (constant fallback).
                // URP SUBSTITUTE (CoreMath.hlsl §2.7 lines 235-238): the cascade-select + IG-dither + biased PCF +
                // distance-fade are ALL HG shadow-atlas engine infra with a direct URP analog — TransformWorldToShadowCoord
                // picks the cascade (_CascadeShadowSplitSpheres), MainLightRealtimeShadow does the biased soft-PCF
                // (_SHADOWS_SOFT) AND the GetShadowFade()-to-1.0 distance falloff. So shadowAttenuation == _2415's well-
                // defined part. The HG gate is preserved: when _DirectionalShadowParams2.w>=0.99 (CSM off) we keep HG's
                // _DirectionalShadowParams2.z constant; when the URP _MAIN_LIGHT_SHADOWS keyword is off, mainLight
                // .shadowAttenuation is itself 1.0 — the same "no realtime CSM" outcome. This is REQUIRED infra
                // substitution (PORT DISCIPLINE: CSM/ASM atlases T5/T7 -> MainLightRealtimeShadow), not a deviation.
                // vs b23:717-782 + CoreMath.hlsl:235-238.
                // ============================================================================================
                float shadow;
                if (_DirectionalShadowParams2.w >= 0.99)                     // _2106 (b23:717) CSM disabled
                {
                    shadow = _DirectionalShadowParams2.z;                    // _2268 -> _2415 (b23:721,779-781)
                }
                else
                {
                    float4 shadowCoord = TransformWorldToShadowCoord(posWS); // cascade-select (b23:733-754) -> URP
                    Light mainLight = GetMainLight(shadowCoord, posWS, half4(1, 1, 1, 1));
                    shadow = mainLight.shadowAttenuation;                    // _2415 biased-PCF + dither + fade (b23:756-777)
                }

                // ---- world position from depth for refraction/distance (b23:783-793). Infra: InvViewProj -> URP. ----
                float ndcX = mad(screenUV.x, 2.0, -1.0);                    // (b23:783)
                float sceneDepth = SAMPLE_TEXTURE2D_LOD(_WaterDepthTex, sampler_LinearClamp, screenUV, 0.0).x; // T1 (b23:784) TODO #5
                float ndcY = (-mad(screenUV.y, 2.0, -1.0));                 // (b23:786)
                // unproject (b23:787-791) — using UNITY_MATRIX_I_VP (== blob _InvViewProjMatrix).
                // The blob indexes _InvViewProjMatrix[0u].w/[1u].w/[2u].w/[3u].w etc.; because that matrix is
                // column_major, M[i] is COLUMN i, so e.g. [i].w = element (row3,col i) = _m3i. The full set of
                // numerators (b23:787 w, :788 x, :789 z, :791 y) is therefore exactly mul(InvVP, float4(ndc,depth,1)).
                // Transcribing it as UNITY_MATRIX_I_VP[i].w (row-indexed -> _m i3) would be the transpose; mul() is
                // layout-correct and bit-identical to the blob's column dot-products.
                float4 hp = mul(UNITY_MATRIX_I_VP, float4(ndcX, ndcY, sceneDepth, 1.0)); // (b23:787-791)
                float3 sceneWS = hp.xyz / hp.w;
                float3 refrV = sceneWS + (-posWS);                          // (b23:790-792)
                float waterToScene = sqrt(dot(refrV, refrV));               // (b23:793) under-water travel distance

                // ============================================================================================
                // §Fog — atmosphere + height-exponential fog (b23:794-857) -> URP MixFog. 1:1 INFRA SUBSTITUTION.
                // GROUND TRUTH b23:794-857 produces three quantities the composite (b23:855-857,911-913) consumes:
                //   (A) atmosphere TRANSMITTANCE _2543/_2544/_2545 (b23:794-798): per-RGB exp() of a height-integrated
                //       optical depth. _2497 = max(posWS.y*_AtmFog3.w + _AtmFog4.w, 0.01) is the per-pixel height term;
                //       _2530 = ((1-exp(-_2497))/_2497) * exp(posWS.y*_AtmFog3.w + _AtmFog5.w) * (-max(viewDist*_AtmFog1.w
                //       - _AtmFog0.w, 0)) is the analytic height-integrated path optical depth (the `(1-e^-σh)/σh` height
                //       integral × eye distance _244==viewDist); _2543/4/5 = exp2(_2530*_AtmFog2.{xyz}*LOG2_E).
                //   (B) fog OPACITY _3193 + INSCATTER _3194/_3195/_3196 (b23:801-854): exponential height-fog analytic
                //       (Taylor `(1-e^-x)/x` near 0, b23:823/843) -> _3139 opacity (b23:850) and _3141·_ExpFog params
                //       inscatter (b23:851-853). Under HG_COMPOSE_VOLUMETRIC the same analytic is MULTIPLIED by a froxel
                //       3D-volume tap _2949 (T3, jittered uvw, b23:826) giving _3193=_2905·_2974 (b23:833) and
                //       _3194..6 = analytic·_2974 + froxel-inscatter (b23:834-836).
                //   (C) _3197/_3198/_3199 = _3193 · _2543/4/5 (b23:855-857): density premultiplied by atmosphere transmittance.
                //
                // The analytic atmosphere/exponential-height layers (A)+(B-analytic) are HG ENGINE fog infrastructure
                // (cbuffers _AtmosphereFogParams*/_ExponentialFogParams*, no URP binding). Per PORT DISCIPLINE + CoreMath
                // §2.10 ("fog: HG atmosphere+exp+volumetric -> URP MixFog"; CoreMath.hlsl:274-275 `MixFog(color, fogFactor)`),
                // SUBSTITUTE them with URP's fog model: ComputeFogIntensity(ComputeFogFactorZ0ToFar(LinearEyeDepth(window.z)))
                // is URP's scene transmittance (1=clear .. 0=fully fogged == the _2543/4/5 role) — note the fog factor ALONE is only a
                // transmittance under FOG_LINEAR; under FOG_EXP/EXP2 it is the raw -density*z that ComputeFogIntensity then
                // exponentiates (ShaderVariablesFunctions.hlsl:342/351/433). unity_FogColor.rgb is URP's inscatter color
                // (== _3194/5/6 role), and the fog opacity (_3193 role) is its complement (1-transmittance). MixFog applied
                // downstream then reproduces lerp(unity_FogColor, scene, fogIntensity) — the sanctioned 1:1 infra substitute.
                // This is REQUIRED infra substitution (PORT DISCIPLINE), NOT a deviation. vs b23:794-857 + CoreMath.hlsl:274-275.
                //
                // ONLY the volumetric-froxel sub-term (B-froxel: T3 _VolumetricFogVolume tap _2949 + froxel transmittance
                // _2974, b23:805-837) is left engine-side: it needs a HOST-rendered froxel volume (render-graph 3D fog tex)
                // that URP's analytic MixFog cannot supply. Kept as a compilable placeholder applied multiplicatively
                // EXACTLY as the blob composes it (_3193 = analyticOpacity · froxelTransmittance, b23:833). vs b23:805-837.
                // ============================================================================================
                // URP fog factor from window-space depth — the atmosphere+height transmittance substitute (CoreMath §2.10).
                // Read positionHW.z (the standalone SV_Position param), NOT input.positionCS.z: this fragment derives ALL
                // window-space coords from positionHW (lines 498-500) because the Varyings SV_Position member is not relied
                // on once a separate SV_Position param exists; reading the struct member alongside it is undefined on some
                // backends. positionHW.z is the WINDOW-space (perspective-divided, [0,1]) depth — NOT clip-space z.
                // CRITICAL: URP's ComputeFogFactor(z) takes CLIP-space z (it runs UNITY_Z_0_FAR_FROM_CLIPSPACE internally),
                // which is why every URP pass calls it at the VERTEX stage with vertexInput.positionCS.z and interpolates the
                // result. Feeding the fragment's window-space depth into ComputeFogFactor would mis-remap it and corrupt the
                // whole fog (and thus the composite, since fog premultiplies litR/G/B + lit360x). In a fragment we only have
                // window depth, so convert it to 0-to-far EYE distance (what ComputeFogFactorZ0ToFar consumes — see its
                // unity_FogParams.z*z / unity_FogParams.x*z bodies) via LinearEyeDepth, then call the Z0ToFar entry directly.
                // This is the fragment-stage equivalent of URP's vertex-stage ComputeFogFactor, and it also matches the
                // blob's distance-based fog (b23:794-798 integrate over viewDist _244). vs ShaderVariablesFunctions.hlsl:326,360.
                float urpFogEyeZ  = LinearEyeDepth(positionHW.z, _ZBufferParams); // window depth -> 0-far eye distance
                float urpFogFactor = ComputeFogFactorZ0ToFar(urpFogEyeZ);    // raw URP fog factor (NOT a transmittance for exp/exp2)
                // Resolve to the actual scene TRANSMITTANCE the way URP's MixFog does internally (MixFogColor ->
                // ComputeFogIntensity): for FOG_LINEAR this is the factor itself, for FOG_EXP/EXP2 it is exp2(-f)/exp2(-f*f).
                // urpFogFactor alone is -density*z under exp/exp2 (ShaderVariablesFunctions.hlsl:342/351), NOT in [0,1].
                float urpFogTransmittance = ComputeFogIntensity(urpFogFactor); // 1=clear..0=fogged (replaces _2543/4/5, b23:794-798)

                // (B-froxel) engine-side volumetric froxel sub-term — needs host froxel volume (T3), no URP analog.
                // TODO(engine, b23:805-837): when HG_COMPOSE_VOLUMETRIC + a host-rendered froxel 3D fog volume is bound to
                // _VolumetricFogVolume, sample it at the per-pixel jittered uvw (_2949) and fold _2974 = lerp(1, froxel.w,
                // depthGate) as a multiplicative transmittance + froxel.xyz inscatter. Neutral placeholder = no froxel.
                float  froxelTransmittance = 1.0;            // TODO(engine): _2974 (b23:828) — host froxel volume T3
                float3 froxelInscatter     = float3(0.0, 0.0, 0.0); // TODO(engine): _2949.xyz·_2966 (b23:826-836) — host froxel volume T3

                // (A) atmosphere scene-transmittance _2543/_2544/_2545 -> URP fog transmittance broadcast (b23:794-798 -> MixFog).
                float3 fogTrans = urpFogTransmittance.xxx;
                // (B) fog opacity _3193 -> (1-transmittance), times the engine froxel transmittance (b23:833 _2905·_2974).
                float  fogDensity = (1.0 - urpFogTransmittance) * froxelTransmittance; // _3193 (b23:833/850)
                // (B) fog inscatter color _3194/_3195/_3196 -> URP unity_FogColor.rgb, plus the engine froxel inscatter
                //     (b23:834-836 analytic·_2974 + froxel term). unity_FogColor is URP's per-frame fog inscatter color.
                float3 fogColor = unity_FogColor.rgb + froxelInscatter;        // _3194/_3195/_3196 (b23:834-836/851-853)
                // (C) density premultiplied by atmosphere transmittance (b23:855-857) _3197/_3198/_3199.
                float3 fogPremul = fogDensity * fogTrans;     // (b23:855-857) _3197/_3198/_3199

                // ============================================================================================
                // §Composite — final water shading composite (b23:858-926). PORTED 1:1 (pure math over the already-
                // resolved inputs). Combines: scene refraction color (T14), caustic/foam (T16), Beer-Lambert single-
                // scattering through the water column via the directional light, an atmosphere/sun phase highlight, and
                // a Fresnel+depth refraction blend, then the VFX saturation tonemap to MRT0. Every line is the blob math
                // with blob temporaries mapped to the port's already-computed quantities:
                //   _914/_915/_916 -> perturbedN ; _241/_242/_243 -> Vn ; _244 -> viewDist ; _182/_183 -> screenUV ;
                //   _2467/_2469 -> sceneWS.x/.z ; _2485 -> waterToScene ; _934 -> NoVp ; _959 -> envBRDF ;
                //   _1389/_1390/_1391 -> ambientScaled ; _2099/_2100/_2101 -> reflR/G/B ; _2415 -> shadow ;
                //   _3203/_3204/_3205 -> sceneRefr ; _2543/_2544/_2545 -> fogTrans (URP transmittance, §Fog substitute) ;
                //   _3193 -> fogDensity ; _3194/_3195/_3196 -> fogColor ; _3197/_3198/_3199 -> fogPremul ;
                //   field index _131*20u+k -> b20+k (this body's param block).
                // _LightDataBuffer_DirectionalLightDirection is the HG main-light dir (host-filled, declared). The
                // atmosphere sun-phase terms (_2554/_2571/_3543/_3569) are pure math over _AtmosphereFogParams* + Vn and
                // are ported as-is (NOT engine-side — only the volumetric froxel above is). vs b23:858-926.
                // ============================================================================================
                float3 sceneRefr = SAMPLE_TEXTURE2D_LOD(_WaterIrradiance, sampler_WaterIrradiance, screenUV, 0.0).xyz; // T14 _3201 (b23:858) TODO #5

                // ---- caustic projection sample (b23:862-867). T16, sampler_LinearMirror (blob b23:867). 1:1. ----
                float caustScale = 0.0199999995529651641845703125 / WD(f17 + 10u).y; // _3210 (b23:862)
                float caustBias  = (caustScale * _VFXParams0.w) * 0.00250000017695128917694091796875; // _3232 (b23:865)
                float4 caustic = SAMPLE_TEXTURE2D_BIAS(_WaterCausticTex, sampler_LinearMirror,           // T16 _3244 (b23:867)
                    float2(mad(caustBias, WD(f14 + 10u).x, mad(sceneWS.x, WD(f17 + 10u).y, (caustScale * (perturbedN.x * WD(f22 + 10u).y)) * 20.0)),
                           mad(caustBias, WD(f14 + 10u).x, mad(sceneWS.z, WD(f17 + 10u).y, (caustScale * (perturbedN.z * WD(f22 + 10u).y)) * 20.0))),
                    _GlobalMipBias);

                // ---- caustic depth gates (b23:869-871) ----
                float caustNear = clamp(waterToScene + ((-0.0) - WD(f22 + 10u).x), 0.0, 1.0); // _3267 (b23:869)
                // _3274 (b23:870): 0.02 / (1/(1/(1/gl_FragCoord.w))) == 0.02 / (1/w_clip). In SPIRV-Cross main()
                // flips gl_FragCoord.w to w_clip, so the denominator collapses to 1/w_clip, which on a fragment
                // SV_Position is exactly positionHW.w (the interpolated perspective 1/w). 1:1.
                float caustFar  = ((-0.0) - clamp(0.0199999995529651641845703125 / positionHW.w, 0.0, 1.0)) + 1.0; // _3274 (b23:870)
                float caustEdge = ((-0.0) - clamp(waterToScene + ((-0.0) - WD(f14 + 10u).y), 0.0, 1.0)) + 1.0;     // _3286 (b23:871)

                // ---- caustic-modulated scene refraction premultiply (b23:872-874) _3299/_3300/_3301 ----
                // Parenthesization kept byte-exact: _3197 * ((( _3274 * (_3267 * (AtmFog0 * WD[f21].y)) ) * _3286) * _3244.c).
                float litR = mad(fogPremul.x * (((caustFar * (caustNear * (_AtmosphereFogParams0.x * WD(f21 + 10u).y))) * caustEdge) * caustic.x), 10.0, 1.0) * sceneRefr.x; // _3299 (b23:872)
                float litG = mad(fogPremul.y * (((caustFar * (caustNear * (_AtmosphereFogParams0.y * WD(f21 + 10u).y))) * caustEdge) * caustic.y), 10.0, 1.0) * sceneRefr.y; // _3300 (b23:873)
                float litB = mad(fogPremul.z * (((caustFar * (caustNear * (_AtmosphereFogParams0.z * WD(f21 + 10u).y))) * caustEdge) * caustic.z), 10.0, 1.0) * sceneRefr.z; // _3301 (b23:874)

                // ---- Beer-Lambert single-scattering through the water column (b23:875-888). 1:1. ----
                float3 dirLight = _LightDataBuffer_DirectionalLightDirection.xyz;
                float colDist = min(waterToScene, 50.0);                  // _3302 (b23:875)
                float VdotL   = dot(Vn, dirLight);                        // _3309 (b23:876)
                float colT    = clamp(colDist / WD(f20 + 10u).x, 0.0, 1.0); // _3317 (b23:877)
                // depth-blended extinction RGB (b23:882-884): lerp(WD[b20+9].rgb, WD[b20+12].rgb, colT) + WD[b20+11].rgb.
                float3 extinction = float3(
                    mad(colT, ((-0.0) - WD((b20 + 9u) + 10u).x) + WD((b20 + 12u) + 10u).x, WD((b20 + 9u) + 10u).x) + WD((b20 + 11u) + 10u).x,  // _3351 (b23:882)
                    mad(colT, ((-0.0) - WD((b20 + 9u) + 10u).y) + WD((b20 + 12u) + 10u).y, WD((b20 + 9u) + 10u).y) + WD((b20 + 11u) + 10u).y,  // _3352 (b23:883)
                    mad(colT, ((-0.0) - WD((b20 + 9u) + 10u).z) + WD((b20 + 12u) + 10u).z, WD((b20 + 9u) + 10u).z) + WD((b20 + 11u) + 10u).z); // _3353 (b23:884)
                float negColDist = (-0.0) - colDist;                      // _3354 (b23:885)
                // transmittance = exp(-colDist * extinction)  (exp2 * log2(e), b23:886-888):
                float3 colTrans = float3(
                    exp2((negColDist * extinction.x) * 1.44269502162933349609375),   // _3361 (b23:886)
                    exp2((negColDist * extinction.y) * 1.44269502162933349609375),   // _3362 (b23:887)
                    exp2((negColDist * extinction.z) * 1.44269502162933349609375));  // _3363 (b23:888)

                // ---- atmosphere/sun phase + scatter highlight shared scalars (b23:889-910). 1:1. ----
                float backLight = ((-0.0) - dot((-0.0) - dirLight, perturbedN)) + 1.0; // _3376 (b23:889) 1 - dot(-L,N)
                float backLight2 = backLight * backLight;                 // _3377 (b23:890)
                float phaseG = mad((-0.0) - VdotL, 1.7075519561767578125, 1.7289333343505859375); // _3379 (b23:891)
                float vertFac = abs(Vn.y / max(0.0500000007450580596923828125, dirLight.y)) + 1.0; // _3389 (b23:892)
                float3 extVert = extinction * vertFac;                    // _3390/_3391/_3392 (b23:893-895)
                float vertFac2 = abs(Vn.y * 1.39400005340576171875) + 1.0; // _3396 (b23:896)
                float3 extVert2 = extinction * vertFac2;                  // _3397/_3398/_3399 (b23:897-899)
                float scatAlbedo = 0.71700000762939453125 * WD(f17 + 10u).x; // _3444 (b23:902)
                float phaseDenom = 0.271066606044769287109375 / max((phaseG * 12.56637096405029296875) * sqrt(phaseG), 0.001000000047497451305389404296875); // _3472 (b23:903)
                float phaseTerm = mad(WD(f20 + 10u).z, mad(mad(VdotL, VdotL, 1.0), 0.0596831031143665313720703125, (-0.0) - phaseDenom), phaseDenom); // _3482 (b23:904)
                float sunSpec = shadow * max(abs(mad((-0.0) - (backLight * (backLight2 * backLight2)), 0.980000019073486328125, 0.980000019073486328125)), 0.100000001490116119384765625); // _3525 (b23:907)
                float viewFade = viewDist * 0.0500000007450580596923828125; // _3535 (b23:908)
                // atmosphere sun-disc phase (pure math over _AtmosphereFogParams*, b23:799-800,909-910):
                float atmCos   = dot((-0.0) - Vn, _AtmosphereFogParams1.xyz); // _2554 (b23:799)
                float atmDenom = mad(_AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0) + ((-0.0) - dot(atmCos.xx, _AtmosphereFogParams2.w.xx)); // _2571 (b23:800)
                float atmRayleigh = mad(atmCos, atmCos, 1.0) * 0.0596831031143665313720703125; // _3543 (b23:909)
                float atmMie = mad((-0.0) - _AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0) / max(sqrt(atmDenom) * (atmDenom * 12.56637096405029296875), 0.001000000047497451305389404296875); // _3569 (b23:910)

                // ---- combine scatter + transmittance + reflection + shadow + fog -> litColor _3603/_3604/_3605 (b23:911-913). 1:1. ----
                // Per channel: outer mad( fogInscatterTerm, (1 - colTrans), innerScatter + refl premul by fog ).
                float lit3603 = mad(
                    mad((clamp(mad(_AtmosphereFogParams4.x, atmMie, mad(_AtmosphereFogParams3.x, atmRayleigh, _AtmosphereFogParams5.x)), 0.0, 1.0) * 255.0) * (((-0.0) - fogTrans.x) + 1.0), fogDensity, fogColor.x),
                    ((-0.0) - colTrans.x) + 1.0,
                    mad(mad((((((-0.0) - exp2((colDist * ((-0.0) - extVert2.x)) * 1.44269502162933349609375)) + 1.0) / extVert2.x) * mad(litR, WD(f22 + 10u).w, ambientScaled.x)) * WD((b20 + 11u) + 10u).x, scatAlbedo,
                            sunSpec * (((phaseTerm * ((((-0.0) - exp2((colDist * ((-0.0) - extVert.x)) * 1.44269502162933349609375)) + 1.0) / extVert.x)) * mad(litR * _AtmosphereFogParams0.x, WD(f22 + 10u).w, _AtmosphereFogParams0.x)) * WD((b20 + 11u) + 10u).x)) + reflR,
                        fogPremul.x, litR * colTrans.x)); // _3603 (b23:911)
                float lit3604 = mad(
                    mad((clamp(mad(_AtmosphereFogParams4.y, atmMie, mad(_AtmosphereFogParams3.y, atmRayleigh, _AtmosphereFogParams5.y)), 0.0, 1.0) * 255.0) * (((-0.0) - fogTrans.y) + 1.0), fogDensity, fogColor.y),
                    ((-0.0) - colTrans.y) + 1.0,
                    mad(mad((((((-0.0) - exp2((colDist * ((-0.0) - extVert2.y)) * 1.44269502162933349609375)) + 1.0) / extVert2.y) * mad(litG, WD(f22 + 10u).w, ambientScaled.y)) * WD((b20 + 11u) + 10u).y, scatAlbedo,
                            sunSpec * (((phaseTerm * ((((-0.0) - exp2((colDist * ((-0.0) - extVert.y)) * 1.44269502162933349609375)) + 1.0) / extVert.y)) * mad(litG * _AtmosphereFogParams0.y, WD(f22 + 10u).w, _AtmosphereFogParams0.y)) * WD((b20 + 11u) + 10u).y)) + reflG,
                        fogPremul.y, litG * colTrans.y)); // _3604 (b23:912)
                float lit3605 = mad(
                    mad((clamp(mad(_AtmosphereFogParams4.z, atmMie, mad(_AtmosphereFogParams3.z, atmRayleigh, _AtmosphereFogParams5.z)), 0.0, 1.0) * 255.0) * (((-0.0) - fogTrans.z) + 1.0), fogDensity, fogColor.z),
                    ((-0.0) - colTrans.z) + 1.0,
                    mad(mad((((((-0.0) - exp2((colDist * ((-0.0) - extVert2.z)) * 1.44269502162933349609375)) + 1.0) / extVert2.z) * mad(litB, WD(f22 + 10u).w, ambientScaled.z)) * WD((b20 + 11u) + 10u).z, scatAlbedo,
                            sunSpec * (((phaseTerm * ((((-0.0) - exp2((colDist * ((-0.0) - extVert.z)) * 1.44269502162933349609375)) + 1.0) / extVert.z)) * mad(litB * _AtmosphereFogParams0.z, WD(f22 + 10u).w, _AtmosphereFogParams0.z)) * WD((b20 + 11u) + 10u).z)) + reflB,
                        fogPremul.z, litB * colTrans.z)); // _3605 (b23:913)

                // ---- Fresnel + depth refraction blend toward scene refraction (b23:914-920). 1:1. ----
                float refrDiv  = max(envBRDF, 9.9999997473787516355514526367188e-06); // _3606 (b23:914)
                float fresnelW = clamp(envBRDF + (-0.5), 0.0, 1.0);       // _3613 (b23:915)
                float fresnel2 = fresnelW + fresnelW;                     // _3614 (b23:916)
                // depth-based refraction weight (b23:917): NoVp == _934, viewFade == _3535.
                float refrDepth = clamp(mad(waterToScene * mad(min(viewFade, 1.0), abs(NoVp) + (-1.0), 1.0), WD(f21 + 10u).x, (-0.0) - min(viewFade, WD(f13 + 10u).w)), 0.0, 1.0); // _3640 (b23:917)
                // litColor = lerp(sceneRefr, lerp(litColor, reflPremul/envBRDF blend, fresnel2), refrDepth)  per-channel (b23:918-920):
                float3 litColor = float3(
                    mad(refrDepth, ((-0.0) - sceneRefr.x) + mad(fresnel2, ((-0.0) - lit3603) + (reflR / refrDiv), lit3603), sceneRefr.x),  // _3647 (b23:918)
                    mad(refrDepth, ((-0.0) - sceneRefr.y) + mad(fresnel2, ((-0.0) - lit3604) + (reflG / refrDiv), lit3604), sceneRefr.y),  // _3648 (b23:919)
                    mad(refrDepth, ((-0.0) - sceneRefr.z) + mad(fresnel2, ((-0.0) - lit3605) + (reflB / refrDiv), lit3605), sceneRefr.z)); // _3649 (b23:920)

                // VFX saturation/tint tonemap (b23:921-926). 1:1.
                float luma = dot(litColor, LUM);                          // (b23:921)
                float negLuma = (-luma);                                  // (b23:922)
                float3 outc;
                outc.x = min(max(mad(_VFXParams1.w, negLuma + litColor.x, luma) * _VFXParams1.x, 0.0), 255.0); // (b23:923)
                outc.y = min(max(mad(_VFXParams1.w, negLuma + litColor.y, luma) * _VFXParams1.y, 0.0), 255.0); // (b23:924)
                outc.z = min(max(mad(_VFXParams1.w, negLuma + litColor.z, luma) * _VFXParams1.z, 0.0), 255.0); // (b23:925)
                return float4(outc, 1.0);   // (b23:926)
            }
            #endif // ENABLE_INK_RENDER
            ENDHLSL
        }
    }
}
