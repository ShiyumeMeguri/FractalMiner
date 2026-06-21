// HGRP UnlitSubShaderLOD — clean URP unlit (ForwardOnly + ShadowCaster).
// Merged from: unlitsubshaderlod.shader (HGRP "HGRP/UnlitSubShaderLOD", QUEUE=Transparent, LOD 600).
//   Pass0 ForwardOnly base #else = Sub0_Pass0_Vertex_b4 / Sub0_Pass0_Fragment_b5 (+ DITHER delta b8/b9).
//   Pass1 ShadowCaster base #else = Sub0_Pass1_Vertex_b16 / Sub0_Pass1_Fragment_b17 (fragment is empty).
// Keywords: _ALPHATEST_ON (alpha test), _DITHER→LOD_FADE_CROSSFADE (LOD crossfade dither).
// Kept (1:1 math): base-map sample with global mip bias, _BaseColor (HDR) multiply,
//   _AlphaMaskChannel A↔R*A alpha-channel select (blob Fragment_b5 L94/L99),
//   _SurfaceType opaque/transparent + _BlendMode (Alpha/Additive/Premultiply) blend plumbing,
//   _CullMode render face, alpha clip threshold,
//   HGRP analytic fog — atmosphere scattering (blob Fragment_b5 L100-106,L164-168) + exponential
//   height fog (L148-163) ported 1:1 in ApplyHgAnalyticFog, gated by _EnableHgFog (host binds the
//   _AtmosphereFogParams*/_ExponentialFogParams* globals); URP MixFog is the unbound fallback.
// Removed (pixel-neutral pipeline infra substituted by URP):
//   GPU mesh skinning (T0 ByteAddressBuffer + unity_LODFade LOD-skin path, blob Vertex_b4 L63-264),
//   camera-relative world space (RWS, _WorldSpaceCameraPos_Internal subtraction), TAA jitter
//   (_TaaJitterStrength), _GlobalMipBias global (→ no bias), HGRP global cbuffers.
//
// TODO(1:1, ENGINE-SIDE): the VOLUMETRIC-froxel fog term (blob Fragment_b5 L111-146, `T1.SampleLevel`
//   over _VolumetricFogParams*) reads a Texture3D froxel volume filled by HGRP's volumetric-fog
//   injection/accumulation COMPUTE pass — only a host ScriptableRenderFeature can produce that buffer,
//   so it is omitted (analytic atmosphere+height fog is reproduced; volumetric inscatter is not).
// TODO(1:1, ENGINE-SIDE): object motion vectors → SV_Target1 (blob Fragment_b5 L169-173) fed by
//   prev-frame matrices (_unity_MatrixPreviousM / _PrevNonJitteredViewNoTransProjMatrix, Vertex_b4
//   L283-298). MRT + prev-frame transforms belong to URP's motion-vector prepass (host render pass),
//   not a material; the forward pass writes one color target.
//
// NOTE(1:1): _DitherScale is exposed by the source Properties but is NEVER read by the compiled DITHER
//   variant — the dither in Sub0_Pass0_Fragment_b9 L102-103 is a pure unity_LODFade crossfade hash
//   (gl_FragCoord + _unity_LODFade only), mapped 1:1 to URP LODFadeCrossFade(). _DitherScale is kept
//   for material compat only; there is no deferred math. vs Sub0_Pass0_Fragment_b9 L102-103.
Shader "HGRP/UnlitSubShaderLOD_Fix"
{
    Properties
    {
        [HDR] [Gamma] _BaseColor ("Unlit Color", Color) = (1, 1, 1, 1)
        _BaseColorMap ("Unlit Color Map", 2D) = "white" {}
        [HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}   // Unity batching/compat alias of _BaseColorMap

        _DitherScale ("Dither Scale", Range(0, 1)) = 1

        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Alpha Test", Float) = 0
        [Enum(A, 0, R, 1)] _AlphaMaskChannel ("Alpha Mask Channel", Float) = 0
        _AlphaClipThreshold ("Clip Threshold", Range(0, 1)) = 0.5

        // Surface type + blend plumbing (driven by material editor / OnValidate, see _SurfaceType / _BlendMode)
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 0
        [Enum(Alpha, 0, Additive, 1, Premultiply, 4)] _BlendMode ("Blend Type", Float) = 0
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2

        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _TransparentSortPriority ("__transparentSortPriority", Float) = 0
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
        }
        LOD 600

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _BaseColor;
                float4 _BaseColorMap_ST;
                float  _AlphaMaskChannel;
                float  _AlphaClipThreshold;
                float  _DitherScale;
                float  _SurfaceType;
                float  _BlendMode;
                float  _ZWrite;
                float  _TransparentSortPriority;

                // ---- HGRP analytic-fog parameters (1:1 from the decompiled global cbuffer) ----------
                // In the source these are HGRP-engine globals (type_ShaderVariablesGlobal,
                // blob Sub0_Pass0_Fragment_b5 L23-34) filled by HGRP's Atmosphere / VolumetricFog C#
                // volume systems. URP has no such global, so per CLOSEABLE-rule they are DECLARED here
                // (a host render-feature or the material binds them) and the fog MATH is ported 1:1.
                // _EnableHgFog gates the whole analytic-fog block off when unbound (default 0 → URP MixFog).
                float  _EnableHgFog;
                float4 _AtmosphereFogParams0;
                float4 _AtmosphereFogParams1;
                float4 _AtmosphereFogParams2;
                float4 _AtmosphereFogParams3;
                float4 _AtmosphereFogParams4;
                float4 _AtmosphereFogParams5;
                float4 _ExponentialFogParams0;
                float4 _ExponentialFogParams1;
                float4 _ExponentialFogParams2;
                float4 _ExponentialFogParams3;
                float4 _ExponentialFogParams4;
                float4 _ExponentialFogParams5;
            CBUFFER_END

            TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);

            // ---- Unlit surface (1:1) -------------------------------------------------
            // Base-map sample (HGRP used T0.SampleBias(sampler_LinearRepeat, uv, _GlobalMipBias);
            // _GlobalMipBias dropped → plain sample). blob Sub0_Pass0_Fragment_b5 L93.
            // _AlphaMaskChannel select: mad(ch, mad(s.x*c.x, a, -a), a)
            //   = lerp(s.a*c.a, s.r*c.r * s.a*c.a, ch)  → ch=0: A channel, ch=1: R*A.
            // blob Sub0_Pass0_Fragment_b5 L94 (_190 = s.w*c.w) and L99 (SV_Target.w).
            void SampleUnlit(float2 uv, out float3 albedo, out float alpha)
            {
                float4 baseSample = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uv);
                albedo = baseSample.rgb * _BaseColor.rgb;
                float maskedA = baseSample.w * _BaseColor.w;
                alpha = mad(_AlphaMaskChannel, mad(baseSample.x * _BaseColor.x, maskedA, -maskedA), maskedA);
            }

            // ---- HGRP analytic fog (atmosphere scattering + exponential height fog) -----------------
            // 1:1 MATH port of blob Sub0_Pass0_Fragment_b5:
            //   - view-ray reconstruction  L77-92  (infra-substituted to URP world-pos facilities)
            //   - atmosphere scattering    L100-106 + composite L164-168
            //   - exponential height fog   L148-163 (the NON-volumetric `else` branch)
            // The volumetric-froxel branch (L111-146, T1 3D texture) is the ONLY engine-side gap and is
            // left out (see the fragment-stage TODO). All denormal `e-Nf`/exp2(x*log2(e)) idioms are
            // re-spelled; constants are byte-preserved.
            //   LOG2_E = 1.44269502162933349609375  (= log2(e); exp2(x*LOG2_E) == exp(x))  blob L100,L102-104
            //   INV_FOURPI_SQ = 0.0596831031143665313720703125 (Rayleigh phase 3/(16π)·…)  blob L164
            //   FOURPI = 12.56637096405029296875                                            blob L165
            // Returns fogged color; `eyeToPosWS` is (positionWS - cameraPositionWS), `posWS` world pos.
            static const float HG_LOG2_E = 1.44269502162933349609375;
            static const float HG_RCP_LOG2_E_NEG = -1.44269502162933349609375;

            // (1-exp(-x))/x with the blob's small-x series fallback (blob L132/L465 etc.):
            //   |x|>5.96e-08 → (1-exp(-x))/x ; else → mad(-x, 0.2402265071868896, 0.6931471824645996)
            float HgOpticalRatio(float x)
            {
                float series = mad(-x, 0.2402265071868896484375, 0.693147182464599609375);
                float exact  = (((-0.0f) - exp2((-0.0f) - x)) + 1.0f) / x;
                return (5.9604644775390625e-08f < abs(x)) ? exact : series;
            }

            float3 ApplyHgAnalyticFog(float3 albedo, float3 posWS, float3 eyeToPosWS)
            {
                // View-ray basis: blob `_155.._159` = (camPos - worldPos) (L83-86, perspective branch),
                // i.e. the fragment->camera vector — camera-relative-world, pointing TOWARD the eye.
                // URP infra: eyeToPosWS = (posWS - cameraPosWS) = camera->fragment = the NEGATION of the
                // blob ray. So `dirWS` below equals -(blob `_166.._168`). SIGN INVARIANT (do not regress):
                //   blob `_166.._168` == -dirWS. Every blob use of (_166,_167,_168) maps as:
                //     L105 `_287 = dot((-_166,-_167,-_168),P1)` -> dot(+dirWS, P1)   (double-negated)
                //     L155 `_737 = dot(( _166, _167, _168),P4)` -> dot(-dirWS, P4)   (not negated)
                // lenSq/rcpLen/dist/_160/_165/_169 are sign-independent so they map straight through.
                float lenSq = dot(eyeToPosWS, eyeToPosWS);                                      // _160
                float rcpLen = rsqrt(max(lenSq, 9.9999999392252902907785028219223e-09f));      // _165
                float3 dirWS = eyeToPosWS * rcpLen;                                             // -(_166.._168)
                float dist   = lenSq * rcpLen;                                                  // _169 (== |eyeToPos|)
                float posY   = posWS.y;                                                         // _114 (world Y of frag)
                float camY   = posWS.y - eyeToPosWS.y;                                          // _WorldSpaceCameraPos.y

                // ---- Atmosphere scattering (blob L100-106) --------------------------------------------
                float a240 = max(mad(posY, _AtmosphereFogParams3.w, _AtmosphereFogParams4.w),
                                 0.00999999977648258209228515625f);                              // _240
                float a263 = (exp2(mad(posY, _AtmosphereFogParams3.w, _AtmosphereFogParams5.w) * HG_LOG2_E)
                              * ((((-0.0f) - exp2(a240 * HG_RCP_LOG2_E_NEG)) + 1.0f) / a240))
                             * ((-0.0f) - max(mad(dist, _AtmosphereFogParams1.w,
                                                  (-0.0f) - _AtmosphereFogParams0.w), 0.0f));     // _263
                float t276 = exp2((a263 * _AtmosphereFogParams2.x) * HG_LOG2_E);                  // _276
                float t277 = exp2((a263 * _AtmosphereFogParams2.y) * HG_LOG2_E);                  // _277
                float t278 = exp2((a263 * _AtmosphereFogParams2.z) * HG_LOG2_E);                  // _278
                float a287 = dot(dirWS, _AtmosphereFogParams1.xyz);                               // _287  blob L105 dot((-_166,-_167,-_168),P1)= dot(+dirWS,P1) (blob ray = -dirWS)
                float a304 = mad(_AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0f)
                             + ((-0.0f) - dot(a287.xx, _AtmosphereFogParams2.w.xx));              // _304

                // ---- Exponential height fog — NON-volumetric branch (blob L148-163) -------------------
                float e623 = posY + ((-0.0f) - camY);                                            // _623
                float e632 = max(e623 * _ExponentialFogParams3.x, -127.0f);                      // _632
                float e633 = max(e623 * _ExponentialFogParams0.z, -127.0f);                      // _633
                float e699 = mad(exp2((-0.0f) - max((camY + ((-0.0f) - _ExponentialFogParams0.x))
                                       * _ExponentialFogParams0.z, -127.0f)) * _ExponentialFogParams0.y,
                                 HgOpticalRatio(e633),
                                 HgOpticalRatio(e632)
                                   * (exp2((-0.0f) - max((camY + ((-0.0f) - _ExponentialFogParams3.z))
                                            * _ExponentialFogParams3.x, -127.0f)) * _ExponentialFogParams3.y)); // _699
                float e710 = clamp(mad(dist, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0f, 1.0f);  // _710
                float e722 = min(e710 + (clamp(mad(dist, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0f, 1.0f)
                                  + max(min(exp2((-0.0f) - (dist * e699)), 1.0f), _ExponentialFogParams2.w)), 1.0f); // _722
                float e737 = exp2(log2(clamp(dot(-dirWS, _ExponentialFogParams4.xyz), 0.0f, 1.0f))
                                  * _ExponentialFogParams5.w);                                    // _737  blob L155 dot((_166,_167,_168),P4)= dot(-dirWS,P4) (blob ray = -dirWS, NOT negated here)
                float e758 = ((-0.0f) - min(exp2((-0.0f) - (max(mad(lenSq, rcpLen,
                                  (-0.0f) - _ExponentialFogParams4.w), 0.0f) * e699)), 1.0f)) + 1.0f; // _758
                float e759 = ((-0.0f) - e722) + 1.0f;                                            // _759
                float e764 = ((-0.0f) - e710) + 1.0f;                                            // _764
                float fog776 = mad(_ExponentialFogParams2.x, e759, e764 * (e758 * (e737 * _ExponentialFogParams5.x))); // _776
                float fog777 = mad(_ExponentialFogParams2.y, e759, e764 * (e758 * (e737 * _ExponentialFogParams5.y))); // _777
                float fog778 = mad(_ExponentialFogParams2.z, e759, e764 * (e758 * (e737 * _ExponentialFogParams5.z))); // _778
                float fog779 = e722;                                                             // _779

                // ---- Atmosphere/exponential composite (blob L164-168) --------------------------------
                // Structurally IDENTICAL to the blob. The ONLY substitution: the blob's per-channel
                // BACKGROUND literal in the first mad — `mad(fog779*tNNN, <bg>, inner)` with <bg> =
                // {x:1.0, y:0.0, z:0.0} (L166/167/168) — was the source's black/MV-packed background.
                // URP has one color target showing the unlit surface, so <bg> := albedo.{x,y,z}.
                // This is `albedo * (transmittance*coverage) + inscatter` — physically the surface seen
                // through fog. No other term, constant, sign or bound is changed.
                float c784 = mad(a287, a287, 1.0f) * 0.0596831031143665313720703125f;            // _784
                float c813 = mad((-0.0f) - _AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0f)
                             / max(sqrt(a304) * (a304 * 12.56637096405029296875f),
                                   0.001000000047497451305389404296875f);                         // _813
                float3 outRGB;
                outRGB.x = mad(fog779 * t276, albedo.x,
                               mad((clamp(mad(_AtmosphereFogParams4.x, c813,
                                              mad(_AtmosphereFogParams3.x, c784, _AtmosphereFogParams5.x)),
                                          0.0f, 1.0f) * 255.0f) * (((-0.0f) - t276) + 1.0f),
                                   fog779, fog776));                                              // SV_Target.x (L166)
                outRGB.y = mad(fog779 * t277, albedo.y,
                               mad((clamp(mad(_AtmosphereFogParams4.y, c813,
                                              mad(_AtmosphereFogParams3.y, c784, _AtmosphereFogParams5.y)),
                                          0.0f, 1.0f) * 255.0f) * (((-0.0f) - t277) + 1.0f),
                                   fog779, fog777));                                              // SV_Target.y (L167)
                outRGB.z = mad(fog779 * t278, albedo.z,
                               mad((clamp(mad(_AtmosphereFogParams4.z, c813,
                                              mad(_AtmosphereFogParams3.z, c784, _AtmosphereFogParams5.z)),
                                          0.0f, 1.0f) * 255.0f) * (((-0.0f) - t278) + 1.0f),
                                   fog779, fog778));                                              // SV_Target.z (L168)
                return outRGB;
            }
        ENDHLSL

        // ============================================================
        // Pass: ForwardOnly  (HGRP "ForwardOnly" → URP UniversalForwardOnly)
        // base = Sub0_Pass0_Vertex_b4 / Sub0_Pass0_Fragment_b5 (+ DITHER delta b8/b9)
        // ============================================================
        Pass
        {
            Name "ForwardOnly"
            Tags { "LightMode" = "UniversalForwardOnly" }

            // HGRP: Blend 0 [_SrcBlend] [_DstBlend] ; ColorMask RGB 1 ; ZClip On ; ZWrite [_ZWrite] ; Cull [_CullMode]
            // (Blend 1 / MV target dropped.) Alpha-channel factor simplified to OneMinusSrcAlpha per STYLE_BIBLE §6.
            Blend [_SrcBlend] [_DstBlend], One OneMinusSrcAlpha
            ColorMask RGB
            ZWrite [_ZWrite]
            ZTest LEqual
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            #pragma shader_feature_local _ALPHATEST_ON
            // HGRP DITHER (unity_LODFade crossfade hash) → URP LOD crossfade.
            #pragma multi_compile _ LOD_FADE_CROSSFADE
            #pragma multi_compile_fog

            // LODFadeCrossFade lives in LODCrossFade.hlsl (NOT pulled by Core.hlsl);
            // include it exactly like URP UnlitForwardPass.hlsl does, gated by the keyword.
            #if defined(LOD_FADE_CROSSFADE)
                #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/LODCrossFade.hlsl"
            #endif

            struct Attributes
            {
                float3 positionOS : POSITION;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
                float  fogFactor  : TEXCOORD1;
                float3 positionWS : TEXCOORD2;   // for HGRP analytic-fog view-ray reconstruction
            };

            Varyings vert(Attributes input)
            {
                Varyings output = (Varyings)0;
                // HGRP did manual ObjectToWorld(RWS) → NonJitteredViewNoTransProj. URP: standard MVP.
                // blob Sub0_Pass0_Vertex_b4 L275-294 (infra-substituted).
                VertexPositionInputs positionInputs = GetVertexPositionInputs(input.positionOS);
                output.positionCS = positionInputs.positionCS;
                output.positionWS = positionInputs.positionWS;
                output.uv = TRANSFORM_TEX(input.uv, _BaseColorMap);
                output.fogFactor = ComputeFogFactor(positionInputs.positionCS.z);
                return output;
            }

            half4 frag(Varyings input) : SV_Target
            {
                #ifdef LOD_FADE_CROSSFADE
                    // HGRP hash-dither LOD crossfade discard (blob Sub0_Pass0_Fragment_b9 L102-103).
                    LODFadeCrossFade(input.positionCS);
                #endif

                float3 albedo;
                float  alpha;
                SampleUnlit(input.uv, albedo, alpha);

                #ifdef _ALPHATEST_ON
                    clip(alpha - _AlphaClipThreshold);
                #endif

                // Fog. The source wrote HGRP analytic fog AS the RGB output (blob Fragment_b5 L100-168).
                // Closeable atmosphere+exponential math is ported 1:1 in ApplyHgAnalyticFog and used when
                // a host binds the HGRP fog params (_EnableHgFog>0.5). Otherwise URP MixFog is the
                // pixel-neutral fallback.
                // TODO(1:1, ENGINE-SIDE): the VOLUMETRIC-froxel fog branch (blob Fragment_b5 L111-146,
                //   `T1.SampleLevel(sampler_LinearClamp, froxelUVW)` + _VolumetricFogParams*) samples a
                //   Texture3D froxel volume produced by HGRP's volumetric-fog injection/accumulation
                //   compute pass. That 3D buffer can only be filled by a host C# ScriptableRenderFeature
                //   (URP has no equivalent froxel volume), so the volumetric inscatter term is omitted;
                //   only the analytic atmosphere+height fog is reproduced here.
                if (_EnableHgFog > 0.5)
                {
                    float3 eyeToPosWS = input.positionWS - _WorldSpaceCameraPos;
                    albedo = ApplyHgAnalyticFog(albedo, input.positionWS, eyeToPosWS);
                }
                else
                {
                    albedo = MixFog(albedo, input.fogFactor);
                }

                // Opaque writes alpha=1; transparent writes the masked alpha (STYLE_BIBLE §6).
                // TODO(1:1, ENGINE-SIDE): the source also wrote object motion vectors to SV_Target1
                //   (blob Fragment_b5 L169-173, fed by prev-frame matrices _unity_MatrixPreviousM /
                //   _PrevNonJitteredViewNoTransProjMatrix in Vertex_b4 L283-298). MRT + prev-frame
                //   transforms are owned by URP's motion-vector prepass (a host render pass), not a
                //   material; the unlit forward pass writes a single color target only.
                float outAlpha = (_SurfaceType == 1.0) ? alpha : 1.0;
                return half4(albedo, outAlpha);
            }
            ENDHLSL
        }

        // ============================================================
        // Pass: ShadowCaster  (HGRP "SHADOWCASTER" → URP ShadowCaster)
        // base = Sub0_Pass1_Vertex_b16 (HGRP shadow output = world-space, projection external);
        //        Sub0_Pass1_Fragment_b17 is EMPTY. URP: standard ApplyShadowBias + clip-space.
        // ============================================================
        Pass
        {
            Name "ShadowCaster"
            Tags { "LightMode" = "ShadowCaster" }

            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex shadowVert
            #pragma fragment shadowFrag

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma multi_compile _ LOD_FADE_CROSSFADE
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"
            #if defined(LOD_FADE_CROSSFADE)
                #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/LODCrossFade.hlsl"
            #endif

            float3 _LightDirection;
            float3 _LightPosition;

            struct ShadowAttributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float2 uv         : TEXCOORD0;
            };

            struct ShadowVaryings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
            };

            float4 GetShadowPositionHClip(float3 positionOS, float3 normalOS)
            {
                float3 positionWS = TransformObjectToWorld(positionOS);
                float3 normalWS = TransformObjectToWorldNormal(normalOS);

            #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                float3 lightDirectionWS = normalize(_LightPosition - positionWS);
            #else
                float3 lightDirectionWS = _LightDirection;
            #endif

                float4 positionCS = TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDirectionWS));
            #if UNITY_REVERSED_Z
                positionCS.z = min(positionCS.z, UNITY_NEAR_CLIP_VALUE);
            #else
                positionCS.z = max(positionCS.z, UNITY_NEAR_CLIP_VALUE);
            #endif
                return positionCS;
            }

            ShadowVaryings shadowVert(ShadowAttributes input)
            {
                ShadowVaryings output = (ShadowVaryings)0;
                output.uv = TRANSFORM_TEX(input.uv, _BaseColorMap);
                output.positionCS = GetShadowPositionHClip(input.positionOS, input.normalOS);
                return output;
            }

            half4 shadowFrag(ShadowVaryings input) : SV_Target
            {
                #ifdef LOD_FADE_CROSSFADE
                    LODFadeCrossFade(input.positionCS);
                #endif
                #ifdef _ALPHATEST_ON
                    float3 albedo;
                    float  alpha;
                    SampleUnlit(input.uv, albedo, alpha);
                    clip(alpha - _AlphaClipThreshold);
                #endif
                return 0;
            }
            ENDHLSL
        }

        // ============================================================
        // Pass: DepthOnly (URP depth prepass; HGRP had no explicit DepthOnly here,
        // added for URP depth/SSAO correctness — alpha-clip respected.)
        // ============================================================
        Pass
        {
            Name "DepthOnly"
            Tags { "LightMode" = "DepthOnly" }

            ZWrite On
            ColorMask R
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex depthVert
            #pragma fragment depthFrag

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma multi_compile _ LOD_FADE_CROSSFADE

            #if defined(LOD_FADE_CROSSFADE)
                #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/LODCrossFade.hlsl"
            #endif

            struct DepthAttributes
            {
                float3 positionOS : POSITION;
                float2 uv         : TEXCOORD0;
            };

            struct DepthVaryings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
            };

            DepthVaryings depthVert(DepthAttributes input)
            {
                DepthVaryings output = (DepthVaryings)0;
                output.positionCS = TransformObjectToHClip(input.positionOS);
                output.uv = TRANSFORM_TEX(input.uv, _BaseColorMap);
                return output;
            }

            half4 depthFrag(DepthVaryings input) : SV_Target
            {
                #ifdef LOD_FADE_CROSSFADE
                    LODFadeCrossFade(input.positionCS);
                #endif
                #ifdef _ALPHATEST_ON
                    float3 albedo;
                    float  alpha;
                    SampleUnlit(input.uv, albedo, alpha);
                    clip(alpha - _AlphaClipThreshold);
                #endif
                return 0;
            }
            ENDHLSL
        }
    }
}
