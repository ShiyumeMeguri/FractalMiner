// HGRP water ripple height-field -> tangent-space normal map converter — single fullscreen blit pass.
// Merged from: rippleheightconvert.shader (single variant, no multi_compile permutations).
// Keywords: (none — this shader has no shader_feature variants)
// Kept: fullscreen-triangle blit, central-difference height->normal encode (Z=1 up, *0.5+0.5),
//   ripple strength scale (5.0 * _RippleParams.x), height passthrough in alpha, mip-biased height taps.
// Removed: SPIRV-Cross plumbing (spvBitfieldInsert / gl_Position / SPIRV_Cross_Input/Output statics),
//   HGRP global cbuffers (type_ShaderVariablesGlobal._GlobalMipBias, type_WaterInteractiveCB) — re-exposed
//   as URP material uniforms; raw register/packoffset/space bindings.
//
// NOTE: Input is a single-channel ripple HEIGHT texture (.x). Output RGB = encoded tangent normal
//   (RG = scaled XY gradient, B = up), output A = passthrough center height.
//   Texel step 0.001953125 = 1/512; assumes a 512-wide ripple buffer (source hard-codes this offset).

Shader "HGRP/RippleHeightConvert_Fix" {
    Properties {
        [HideInInspector] _RippleHeightTex ("Ripple Height", 2D) = "black" {}
        _RippleParams ("Ripple Params (.x = normal strength)", Vector) = (1, 0, 0, 0)
        _GlobalMipBias ("Global Mip Bias", Float) = 0
    }

    SubShader {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
        LOD 100

        Pass {
            Name "RippleHeightConvert"
            // Source: single pass, ZClip On, no Blend/ZWrite/Cull/Stencil declared — a HGRP water-system
            // fullscreen blit. Mapped to the standard URP fullscreen blit render-state.
            Cull Off
            ZWrite Off
            ZTest Always
            Blend Off

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            // GetFullScreenTriangleVertexPosition / GetFullScreenTriangleTexCoord:
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Common.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // _WaterInteractiveCB_rippleParams2.x (HGRP global cbuffer c2) -> material uniform. Blob line 102,125.
                float4 _RippleParams;
                // type_ShaderVariablesGlobal._GlobalMipBias (HGRP global c108) -> material uniform. Blob line 97,123.
                float _GlobalMipBias;
            CBUFFER_END

            // T0 (blob 105). sampler_LinearClamp (blob 106) is a URP-global sampler already declared by
            // Core.hlsl -> GlobalSamplers.hlsl (SAMPLER(sampler_LinearClamp)); re-declaring it here would be a
            // duplicate-definition error (X3003), so only the texture is declared.
            TEXTURE2D(_RippleHeightTex);

            // Central-difference texel step. Source hard-codes 0.001953125 = 1/512 (blob lines 126,128).
            static const float RIPPLE_TEXEL_STEP = 0.001953125;
            // _87 = asfloat(1065353216u) = 0x3F800000 = 1.0f : the up (Z) component of the surface normal (blob line 129).
            static const float NORMAL_UP_Z = 1.0;

            struct Attributes {
                uint vertexID : SV_VertexID;
            };

            struct Varyings {
                float4 positionCS : SV_Position;
                float2 uv         : TEXCOORD0;
            };

            // 1:1 vertex — fullscreen triangle. Source vert_main (blob lines 64-75) generates the
            // SPIRV fullscreen triangle via spvBitfieldInsert: pos.xy = vidBits*2-1, uv = (b0, 1-b1).
            // URP's GetFullScreenTriangle* helpers emit the identical clip-space triangle + matching UVs.
            Varyings vert(Attributes input) {
                Varyings output;
                output.positionCS = GetFullScreenTriangleVertexPosition(input.vertexID);  // pos.z=UNITY_NEAR_CLIP_VALUE, w=1 (source z=1,w=1)
                output.uv = GetFullScreenTriangleTexCoord(input.vertexID);
                return output;
            }

            // 1:1 fragment — height-field -> tangent normal encode. Source frag_main (blob lines 121-134).
            float4 frag(Varyings input) : SV_Target {
                float2 uv = input.uv;

                // _71: center height sample (blob lines 123-124).
                float centerHeight = SAMPLE_TEXTURE2D_BIAS(_RippleHeightTex, sampler_LinearClamp, uv, _GlobalMipBias).x;

                // _79 = 5.0 * rippleParams2.x : gradient->normal strength scale (blob line 125).
                float strength = 5.0 * _RippleParams.x;

                // _81: X gradient = strength * (rightHeight - centerHeight), right tap at uv + (1/512, 0) (blob line 126).
                float gradX = strength * (SAMPLE_TEXTURE2D_BIAS(_RippleHeightTex, sampler_LinearClamp, float2(uv.x + RIPPLE_TEXEL_STEP, uv.y + 0.0), _GlobalMipBias).x - centerHeight);

                // _86: Y gradient = strength * (upHeight - centerHeight), up tap at uv + (0, 1/512) (blob line 128).
                float gradY = strength * (SAMPLE_TEXTURE2D_BIAS(_RippleHeightTex, sampler_LinearClamp, float2(uv.x + 0.0, uv.y + RIPPLE_TEXEL_STEP), _GlobalMipBias).x - centerHeight);

                // Normalize (gradX, gradY, 1) and encode to [0,1]. _94 = rsqrt(dot(n,n)); out.xyz = mad(n, _94, 1)*0.5 (blob lines 130-133).
                float3 normalT = float3(gradX, gradY, NORMAL_UP_Z);
                float invLen = rsqrt(dot(normalT, normalT));

                float4 result;
                result.x = mad(gradX, invLen, 1.0) * 0.5;
                result.y = mad(gradY, invLen, 1.0) * 0.5;
                result.z = mad(NORMAL_UP_Z, invLen, 1.0) * 0.5;
                result.w = centerHeight;  // SV_Target.w = _71 : height passthrough in alpha (blob line 127).
                return result;
            }
            ENDHLSL
        }
    }
}
