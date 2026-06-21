// HGRP VFX Scene Color Adjustment — single fullscreen post-process overlay pass.
// A screen-region color grade: samples the scene color, optionally desaturates it
// around luminance, then tints by _VFXParams1.xyz. Drawn as a fullscreen triangle,
// masked by stencil, writing straight over the scene (Blend One Zero).
// Merged from: vfxscenecoloradjustment.shader — base (no keyword) + ENABLE_SATURATION.
//   Vertex base = vfxscenecoloradjustment/Sub0_Pass0_Vertex_b2.hlsl   (catch-all #else)
//   Vertex sat  = vfxscenecoloradjustment/Sub0_Pass0_Vertex_b4.hlsl   (ENABLE_SATURATION — identical math)
//   Frag  base  = vfxscenecoloradjustment/Sub0_Pass0_Fragment_b3.hlsl (catch-all #else, flat tint)
//   Frag  sat   = vfxscenecoloradjustment/Sub0_Pass0_Fragment_b5.hlsl (ENABLE_SATURATION, scene-color saturation+tint)
// Keywords: ENABLE_SATURATION
// Kept: fullscreen-triangle vertex (clip + UV exactly per blob, NOTE Y differs from URP helper),
//   luminance-preserving saturation (Rec.709 weights), per-channel tint by _VFXParams1,
//   stencil mask (Ref 3 / ReadMask 71 / Comp Greater), Blend [_SrcBlend] Zero replace, ZTest Less, ZWrite Off, Cull Off.
// Removed: SPIRV-Cross plumbing (gl_Position/gl_VertexIndex/spvBitfieldInsert), HGRP global cbuffer
//   (type_ShaderVariablesGlobal) — _VFXParams1/_GlobalMipBias re-exposed as material props per the
//   CharacterParams-as-Vector substitution; instancing/TAA/motion vectors (none present).
//
// NOTE: scene color source = URP _CameraOpaqueTexture (HGRP _SceneColorTexture / global T0). Requires
//   the URP renderer's Opaque Texture to be enabled for the ENABLE_SATURATION path to read the scene.
// NOTE: _VFXParams1 = (.xyz tint multiplier, .w saturation 0=grayscale..1=original) — HGRP global,
//   here a material Vector since URP has no such global. _GlobalMipBias is the scene-color sample bias.

Shader "HGRP/VfxSceneColorAdjustment_Fix" {
    Properties {
        [Header(VFX Scene Color Adjustment)]
        // .xyz = per-channel tint, .w = saturation (0 grayscale .. 1 original). Source: HGRP global _VFXParams1.
        _VFXParams1 ("VFX Params (.xyz tint, .w saturation)", Vector) = (1, 1, 1, 1)
        _GlobalMipBias ("Scene Color Mip Bias", Float) = 0

        // Render-state plumbing (driven by material editor / OnValidate, not the shader).
        [HideInInspector] _SrcBlend ("__src", Float) = 1
    }
    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent+100"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // .xyz tint, .w saturation amount (HGRP global type_ShaderVariablesGlobal c186)
                float4 _VFXParams1;
                // scene-color sample mip bias (HGRP global type_ShaderVariablesGlobal c108)
                float  _GlobalMipBias;
            CBUFFER_END

            // URP scene-color (HGRP _SceneColorTexture / global T0). Only sampled on the ENABLE_SATURATION path.
            // Plain TEXTURE2D (not _X) so we can pair with SAMPLE_TEXTURE2D_BIAS — URP exposes no _X_BIAS macro,
            // and the source samples a single 2D scene-color with an explicit mip bias (no XR array slice).
            TEXTURE2D(_CameraOpaqueTexture);
            // sampler_LinearClamp is provided by Core.hlsl (GlobalSamplers.hlsl) — do NOT re-declare it here,
            // a manual SAMPLER(sampler_LinearClamp) would be a duplicate declaration (X3003). Maps the blob's
            // sampler_LinearClamp_SceneColorTexture (Fragment_b5.hlsl:17) 1:1 (Linear filter, Clamp wrap).

            // Rec.709 luminance weights — blob Fragment_b5.hlsl:36
            // dot(rgb, float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625))
            static const float3 LUMINANCE_709 = float3(0.21267290413379669, 0.715152204036712646, 0.072175003588199615);

            struct Attributes {
                uint vertexID : SV_VertexID;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
            };

            // Fullscreen triangle — 1:1 from Vertex_b2.hlsl:58-66 (== b4.hlsl:58-66, ENABLE_SATURATION identical).
            // _39 = bitfieldInsert(0, vid, offset=1, count=1) = (vid & 1) << 1  ∈ {0,2}
            // _21 = vid & 2                                                     ∈ {0,2}
            // Clip XY match URP GetFullScreenTriangleVertexPosition; UV.y = 1-(vid&2) is the blob's own
            // convention (NOT URP's GetFullScreenTriangleTexCoord, which uses vid&2) — transcribed exactly.
            Varyings vert(Attributes input) {
                Varyings o;
                uint vid = input.vertexID;
                float x = float((vid << 1u) & 2u);   // _39 — blob b2:60
                float y = float(vid & 2u);            // _21 — blob b2:58
                o.uv.x = x;                                          // blob b2:61
                o.uv.y = (-y) + 1.0;                                 // blob b2:62  (((-0.0f)-_21)+1.0)
                o.positionCS.x = mad(x, 2.0, -1.0);                  // blob b2:63
                o.positionCS.y = mad(y, 2.0, -1.0);                  // blob b2:64
                o.positionCS.z = 1.0;                                // blob b2:65
                o.positionCS.w = 1.0;                                // blob b2:66
                return o;
            }
        ENDHLSL

        Pass {
            Name "VfxSceneColorAdjustment"
            // Source: Tags{} only ("LightMode" unset in HGRP). Mapped to a transparent overlay for URP.
            Tags { "LightMode"="UniversalForwardOnly" }

            // Render state — source .shader lines 13-25.
            Blend [_SrcBlend] Zero, [_SrcBlend] Zero   // default _SrcBlend=One -> straight scene replace
            ZClip On
            ZTest Less
            ZWrite Off
            Cull Off
            Stencil {
                Ref 3
                ReadMask 71
                Comp Greater
                Pass Keep
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_local _ ENABLE_SATURATION

            half4 frag(Varyings input) : SV_Target {
            #ifdef ENABLE_SATURATION
                // Scene-color saturation + tint — blob Fragment_b5.hlsl:34-41
                // T0.SampleBias(sampler_LinearClamp_SceneColorTexture, uv, _GlobalMipBias)
                float4 sceneColor = SAMPLE_TEXTURE2D_BIAS(_CameraOpaqueTexture, sampler_LinearClamp, input.uv, _GlobalMipBias); // b5:34
                float  lum  = dot(sceneColor.rgb, LUMINANCE_709);   // b5:36
                float  nLum = -lum;                                 // b5:37  ((-0.0f)-_47)
                half4 outColor;
                // SV_Target.c = mad(_VFXParams1.w, nLum + sceneColor.c, lum) * _VFXParams1.c   — b5:38-40
                outColor.x = mad(_VFXParams1.w, nLum + sceneColor.x, lum) * _VFXParams1.x; // b5:38
                outColor.y = mad(_VFXParams1.w, nLum + sceneColor.y, lum) * _VFXParams1.y; // b5:39
                outColor.z = mad(_VFXParams1.w, nLum + sceneColor.z, lum) * _VFXParams1.z; // b5:40
                outColor.w = 1.0;                                   // b5:41
                return outColor;
            #else
                // Flat tint fill — blob Fragment_b3.hlsl:26-29
                return half4(_VFXParams1.x, _VFXParams1.y, _VFXParams1.z, 1.0); // b3:26-29
            #endif
            }
            ENDHLSL
        }
    }
}
