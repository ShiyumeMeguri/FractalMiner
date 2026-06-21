// HGRP Unlit — single-color/textured unlit surface with opaque+transparent + alpha-clip — ForwardOnly + ShadowCaster.
// Merged from: unlit/Sub0_Pass0_Fragment_b5 (base ForwardOnly), _b7 (_TRANSPARENT_MAT), _b9 (_ALPHATEST_ON);
//   unlit/Sub0_Pass1_Vertex_b20 (base ShadowCaster), _b23 (_ALPHATEST_ON). Catch-all (#else) variants = base ground truth.
// Keywords: _ALPHATEST_ON  (_SurfaceType / _BlendMode / _CullMode drive render-state, not shader_feature)
// Kept: base-map * _BaseColor tint, _AlphaMaskChannel A-vs-R alpha source, alpha clip, opaque/transparent blend pattern,
//   URP fog (MixFog) in place of the hand-rolled atmospheric in/out-scatter, ShadowCaster with alpha clip.
// Removed: GPU skinning (CB1 skin-matrix fetch from ByteAddressBuffer), SRP instancing (UnityPerDrawArray[256]),
//   motion vectors / SV_Target1 (HG_ENABLE_MV — URP motion-vector pass owns this), DITHER (TAA dither),
//   hand-rolled exp2 atmospheric fog + in-scattering (Float4x5_Param fog coeffs → URP MixFog),
//   per-sample global mip-bias (Float4x5_Param1.x → URP _GlobalMipBias), ShadowpassVP global (→ URP shadow matrices).
//
// NOTE: math is 1:1 from the blobs; the entire SV_Target.xyz fog/scatter chain and all SV_Target1 (motion) writes in the
//   decompiled fragment are pipeline infrastructure URP provides itself — the genuine unlit math is only:
//   color = baseSample.rgb * _BaseColor.rgb ; alpha = lerp(baseSample.a*_BaseColor.a, baseSample.r*_BaseColor.r, _AlphaMaskChannel).
// _AlphaMaskChannel: 0 = use Alpha channel, 1 = use Red channel (源 property '透贴通道' {Dropdown:{A,R}}).

Shader "HGRP/Unlit_Fix"
{
    Properties
    {
        [HDR] [Gamma] _BaseColor ("Unlit Color", Color) = (1, 1, 1, 1)
        _BaseColorMap ("Unlit Color Map", 2D) = "white" {}

        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Alpha Test", Float) = 0
        [Enum(A, 0, R, 1)] _AlphaMaskChannel ("Alpha Mask Channel", Float) = 0
        _AlphaClipThreshold ("Clip Threshold", Range(0, 1)) = 0.5

        // Surface / blend plumbing (driven by a material editor / OnValidate, not by the shader)
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 0
        [Enum(Alpha, 0, Additive, 1, Premultiply, 4)] _BlendMode ("Blend Type", Float) = 0
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2

        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Opaque"
            "Queue"="Geometry"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _BaseColor;
                float4 _BaseColorMap_ST;
                float  _AlphaMaskChannel;
                float  _AlphaClipThreshold;
                float  _SurfaceType;
                float  _BlendMode;
                float  _ZWrite;
            CBUFFER_END

            TEXTURE2D(_BaseColorMap);    SAMPLER(sampler_BaseColorMap);

            // ---- Shared unlit surface evaluation (blob Fragment_b9 lines 87-90 / 178-180, _b5 lines 84-91 / 158-160) ----
            // Returns base color in .rgb and channel-selected alpha in .a (the clip/output alpha == blob _87).
            // The RAW base alpha (blob _76 = baseSample.a*_BaseColor.a) is returned separately via outBaseAlpha,
            // because the blob premultiplies RGB by the RAW base alpha (_76), NOT by the channel-selected alpha
            // (SV_Target.xyz lead term is mad(_76*color,...) at b9:178-180, while SV_Target.w=_87 at b9:184).
            float4 SampleUnlitSurface(float2 uv, out float outBaseAlpha)
            {
                // base map sampled with global mip-bias in source (Float4x5_Param1.x); URP injects _GlobalMipBias.
                // blob _b9 line 87: T0.SampleBias(sampler_LinearRepeat, uv, bias)
                float4 baseSample = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uv);

                // blob _b9 lines 88,179,180: rgb = baseSample.rgb * _BaseColor.rgb  (R = _60.x*_BaseColor.x = _73)
                float3 color = baseSample.rgb * _BaseColor.rgb;

                // blob _b9 line 89: A = baseSample.a * _BaseColor.a  (_76 = _60.w*_BaseColor.w)
                float alphaA = baseSample.a * _BaseColor.a;
                outBaseAlpha = alphaA;

                // blob _b9 line 90: mad(_AlphaMaskChannel, mad(R, A, -A), A) == A + _AlphaMaskChannel*(R*A - A)
                //   R = baseSample.r * _BaseColor.r (the red-channel mask path multiplies R into A; mask=1 -> R*A).
                float redMask = baseSample.r * _BaseColor.r;   // _73 = _60.x * _BaseColor.x
                float alpha = mad(_AlphaMaskChannel, mad(redMask, alphaA, -alphaA), alphaA);

                return float4(color, alpha);
            }

            // Convenience overload for sites that only need the channel-selected alpha (clip in Shadow/Depth).
            float4 SampleUnlitSurface(float2 uv)
            {
                float baseAlphaUnused;
                return SampleUnlitSurface(uv, baseAlphaUnused);
            }
        ENDHLSL

        // =====================================================================
        // ForwardOnly — source Pass "ForwardOnly" (LIGHTMODE "ForwardOnly")
        //   source render-state (skeleton unlit.shader 31-36): Blend 0 [_SrcBlend][_DstBlend],[_AlphaSrcBlend][_AlphaDstBlend];
        //   Blend 1 (MV target, DROPPED); ColorMask RGB 1 (the "RGB" mask was on RT1=motion, DROPPED — RT0 stays RGBA);
        //   ZWrite [_ZWrite], Cull [_CullMode], ZClip On (URP default). RT0 alpha IS written (SV_Target.w=_87), so no ColorMask.
        // =====================================================================
        Pass
        {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }

            Blend [_SrcBlend] [_DstBlend]
            ZWrite [_ZWrite]
            ZTest LEqual
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma multi_compile_fog

            struct Attributes
            {
                float3 positionOS : POSITION;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
                float  fogCoord   : TEXCOORD1;
            };

            Varyings vert(Attributes input)
            {
                Varyings output = (Varyings)0;
                // HGRP did manual ObjectToWorld then VP (blob Vertex_b4 lines 301-323); URP equivalent:
                VertexPositionInputs posInputs = GetVertexPositionInputs(input.positionOS);
                output.positionCS = posInputs.positionCS;
                output.uv = TRANSFORM_TEX(input.uv, _BaseColorMap);
                output.fogCoord = ComputeFogFactor(posInputs.positionCS.z);
                return output;
            }

            half4 frag(Varyings input) : SV_Target
            {
                float baseAlpha;                                       // _76 = baseSample.a*_BaseColor.a
                float4 surface = SampleUnlitSurface(input.uv, baseAlpha);

                #ifdef _ALPHATEST_ON
                    // blob _b9 lines 90-91: discard if channel-selected alpha (_87) < threshold
                    clip(surface.a - _AlphaClipThreshold);
                #endif

                // blob _b9 lines 178-180: RGB lead term is mad(_76*color, ...) -> premultiply by the RAW base
                // alpha _76 (baseSample.a*_BaseColor.a), NOT the channel-selected alpha _87. They differ whenever
                // _AlphaMaskChannel != 0 (R-channel source), where _87 = R*A but the premultiply still uses A.
                float3 rgb = surface.rgb * baseAlpha;

                // Hand-rolled exp2 atmospheric in/out-scatter (blob _b9 lines 119-180) → URP MixFog.
                rgb = MixFog(rgb, input.fogCoord);

                // Opaque writes alpha=1; transparent writes channel-selected alpha (STYLE_BIBLE §6).
                float outAlpha = (_SurfaceType == 1.0) ? surface.a : 1.0;
                return half4(rgb, outAlpha);
            }
            ENDHLSL
        }

        // =====================================================================
        // ShadowCaster — source Pass "ShadowCaster" (LIGHTMODE "SHADOWCASTER")
        //   vertex: OS → world → shadow-clip (blob Vertex_b20 lines 321-324 via _ShadowpassVP) → URP shadow bias.
        //   fragment: empty base (blob Fragment_b21), alpha clip only under _ALPHATEST_ON (blob Fragment_b23 line 79).
        // =====================================================================
        Pass
        {
            Name "ShadowCaster"
            Tags { "LightMode"="ShadowCaster" }

            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex shadowVert
            #pragma fragment shadowFrag

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"

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

            float4 GetShadowPositionHClip(ShadowAttributes input)
            {
                float3 positionWS = TransformObjectToWorld(input.positionOS);
                float3 normalWS   = TransformObjectToWorldNormal(input.normalOS);

            #if defined(_CASTING_PUNCTUAL_LIGHT_SHADOW)
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
                output.positionCS = GetShadowPositionHClip(input);
                return output;
            }

            half4 shadowFrag(ShadowVaryings input) : SV_Target
            {
                #ifdef _ALPHATEST_ON
                    // blob Fragment_b23 line 79: clip on the same channel-selected alpha
                    float4 surface = SampleUnlitSurface(input.uv);
                    clip(surface.a - _AlphaClipThreshold);
                #endif
                return 0;
            }
            ENDHLSL
        }

        // =====================================================================
        // DepthOnly — URP depth prepass (source ForwardOnly wrote depth via ZWrite; URP needs an explicit DepthOnly).
        // =====================================================================
        Pass
        {
            Name "DepthOnly"
            Tags { "LightMode"="DepthOnly" }

            ZWrite On
            ZTest LEqual
            ColorMask R
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex depthVert
            #pragma fragment depthFrag

            #pragma shader_feature_local _ALPHATEST_ON

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
                #ifdef _ALPHATEST_ON
                    float4 surface = SampleUnlitSurface(input.uv);
                    clip(surface.a - _AlphaClipThreshold);
                #endif
                return 0;
            }
            ENDHLSL
        }
    }
}
