// HGRP WetnessTrail — Unified Fix shader. Single decal pass that writes a wetness
// coverage value into a Min-blended RG accumulation buffer (footprint / wet-trail decal).
// Merged from: wetnesstrail.shader (Pass "WetnessDecal"), base variant (blob 4/5) + _USE_MASK (blob 6/7).
// Keywords: _USE_MASK
// Kept: V-coordinate edge fade (_EdgeSoft), scene-depth soft intersection (_DepthSoft) via
//   _CameraDepthTexture + LinearEyeDepth, vertex-color alpha, global opacity (_OverallOpacity),
//   optional world-XZ mask subtract (_USE_MASK, mask sampled in world XZ with _BaseColorMap_ST tiling),
//   Min blend-op + One One factors into an RG target, ReadMask-7 Equal stencil, [_CullMode] face select.
// Removed: TAA jitter (_TaaJitterStrength → TransformWorldToHClip), camera-relative position rebase
//   (folds out exactly → plain positionWS), _GlobalMipBias on mask (→ SAMPLE_TEXTURE2D_BIAS with 0 bias),
//   HGRP _ScreenSize/_ZBufferParams globals (→ URP _ScreenParams + LinearEyeDepth), SRP instancing.
//
// NOTE: Output is written to BOTH R and G of an RG render target as (1 - coverage*_OverallOpacity),
//   combined with BlendOp Min so overlapping decals keep the wettest (smallest) value. This shader
//   must render into a 2-channel accumulation target with that blend state to behave correctly.
// NOTE: With _USE_MASK the mask texture is sampled in WORLD XZ space (positionWS.xz), NOT mesh UV —
//   only the edge-fade term uses mesh UV.y. This matches the decompiled blob exactly.

Shader "HGRP/WetnessTrail_Fix" {
    Properties {
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        _OverallOpacity ("Overall Opacity", Range(0, 1)) = 1
        _EdgeSoft ("Edge Softness", Float) = 2.5
        _DepthSoft ("Depth Softness (1 / soften distance (m))", Float) = 15

        [Toggle(_USE_MASK)] _UseMask ("Use Mask", Float) = 0
        _BaseColorMap ("Mask Tex", 2D) = "white" {}
    }

    SubShader {
        Tags {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType"     = "Transparent"
            "Queue"          = "Transparent"
        }
        LOD 100

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

        CBUFFER_START(UnityPerMaterial)
            float  _OverallOpacity;
            float  _EdgeSoft;
            float  _DepthSoft;
            float4 _BaseColorMap_ST;
        CBUFFER_END

        TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);
        ENDHLSL

        Pass {
            Name "WetnessDecal"
            // Decal writes into an RG wetness accumulation buffer; Min keeps the wettest (smallest) value.
            Blend One One, One One
            BlendOp Min, Min
            ZClip On
            ZWrite Off
            Cull [_CullMode]
            Stencil {
                ReadMask 7
                WriteMask 0
                Comp Equal
                Pass Keep
                Fail Keep
                ZFail Keep
            }
            Tags { "LightMode" = "SRPDefaultUnlit" }

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_MASK

            struct Attributes {
                float3 positionOS : POSITION;
                float4 color      : COLOR;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings {
                float4 positionCS : SV_Position;
                float4 positionWS : TEXCOORD0; // .xyz = world pos, .w = vertex color alpha (blob Vertex_b4:51-53,59)
                float2 uv         : TEXCOORD1; // mesh UV (blob Vertex_b4:60-61)
            };

            Varyings vert(Attributes input) {
                Varyings output = (Varyings)0;

                // Camera-relative rebase in the blob folds out exactly: posWS = (mul(O2W,pos) - camPos) + camPos.
                // (blob Vertex_b4:48-53). Net result is plain world position.
                VertexPositionInputs positionInputs = GetVertexPositionInputs(input.positionOS);

                output.positionWS.xyz = positionInputs.positionWS;
                output.positionWS.w   = input.color.w;          // blob Vertex_b4:59
                output.uv             = input.uv;               // blob Vertex_b4:60-61
                // TAA jitter (_TaaJitterStrength.zw) removed; plain clip transform. (blob Vertex_b4:54-58)
                output.positionCS     = positionInputs.positionCS;
                return output;
            }

            float4 frag(Varyings input) : SV_Target {
                float3 positionWS = input.positionWS.xyz;
                float  vertAlpha  = input.positionWS.w;        // COLOR.w   (blob Fragment_b5:48 -> TEXCOORD.w)
                float  meshV      = input.uv.y;                // (blob Fragment_b5:47 -> TEXCOORD_1.y)

                // --- Scene-depth soft intersection -------------------------------------------------
                // Sample camera depth at this fragment's screen pixel, convert to eye depth.
                // Blob: sceneEye = 1 / (_ZBufferParams.z*rawDepth + _ZBufferParams.w) == LinearEyeDepth.
                // fragEye = 1 / gl_FragCoord.w == clip.w == eye depth. (blob Fragment_b5:48)
                float2 screenUV = (floor(input.positionCS.xy) + 0.5) * (_ScreenParams.zw - 1.0);
                float  rawDepth = SampleSceneDepth(screenUV);
                float  sceneEyeDepth = LinearEyeDepth(rawDepth, _ZBufferParams);
                float  fragEyeDepth  = input.positionCS.w;     // clip.w == eye-space depth
                float  depthDiff     = sceneEyeDepth - fragEyeDepth;

                // --- Edge fade from V coordinate ---------------------------------------------------
                // 1 - |2*V - 1| : a triangular ramp peaking at V=0.5, 0 at the V edges. (blob Fragment_b5:47)
                float edgeRamp = 1.0 - abs(mad(-meshV, 2.0, 1.0));

            #ifdef _USE_MASK
                // Mask sampled in WORLD XZ space with _BaseColorMap_ST tiling. (blob Fragment_b7:52)
                // _GlobalMipBias removed -> use SAMPLE_TEXTURE2D_BIAS with 0 bias.
                float2 maskUV = mad(positionWS.xz, _BaseColorMap_ST.xy, _BaseColorMap_ST.zw);
                float  mask   = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, maskUV, 0.0).x; // blob Fragment_b7:52-53

                // Mask subtracts from both the edge term and the depth term. (blob Fragment_b7:54-55)
                float edgeFade  = saturate(mad(edgeRamp, _EdgeSoft, -mask));                 // _125
                float depthFade = saturate(mad(depthDiff, _DepthSoft, -mask));               // inner clamp of _135
            #else
                float edgeFade  = saturate(edgeRamp * _EdgeSoft);                            // _94  (blob Fragment_b5:47)
                float depthFade = saturate(depthDiff * _DepthSoft);                          // inner clamp of _104 (blob Fragment_b5:48)
            #endif

                // smoothstep(0,1,edgeFade): edgeFade^2 * (3 - 2*edgeFade). (blob Fragment_b5:48 / b7:55)
                float edgeSmooth = (edgeFade * edgeFade) * mad(edgeFade, -2.0, 3.0);

                // coverage = depthFade * smoothstep(edge) * vertexColorAlpha. (blob Fragment_b5:48 / b7:55)
                float coverage = depthFade * (edgeSmooth * vertAlpha);

                // out = 1 - coverage*_OverallOpacity, written to both channels of the RG target;
                // BlendOp Min keeps the wettest value. blob: mad(-coverage, _OverallOpacity, 1).
                // (blob Fragment_b5:49-50 / b7:56-57)
                float wet = mad(-coverage, _OverallOpacity, 1.0);
                return float4(wet, wet, wet, wet);
            }
            ENDHLSL
        }
    }
}
