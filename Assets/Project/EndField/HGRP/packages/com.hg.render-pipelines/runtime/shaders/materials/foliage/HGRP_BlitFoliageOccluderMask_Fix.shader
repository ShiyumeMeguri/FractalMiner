// HGRP Foliage Occluder Mask Blit — single full-screen-triangle reprojection pass.
// Re-builds the 2-channel foliage-occluder mask each frame: it reads the PREVIOUS frame's
// occluder mask (T0) and the CURRENT frame's freshly-rasterized occluder source (T1), and
// writes RG = (reprojectedHistory, currentSource). The history sample is offset in UV by the
// camera's XZ translation since last frame (so the persistent mask follows the world, not the
// screen) and clamped to a hard [0,1] valid-region test (off-region history -> 0). The grass /
// foliage system consumes this RG mask to fade/bend foliage that is occluded by world geometry.
//
// Merged from: blitfoliageoccludermask.shader (HGRP/Foliage/BlitFoliageOccluderMask).
//   The whole shader is a single self-contained Pass with the vertex + fragment HLSL emitted
//   INLINE (no per-variant blob subfolder exists). Ground truth = the .shader itself:
//     Vertex  : blitfoliageoccludermask.shader lines 69-91  (frag_main glue 82-91).
//     Fragment: blitfoliageoccludermask.shader lines 123-148.
//
// Keywords: (none — the source declares no multi_compile_local; one single variant).
// Kept (1:1): SV_VertexID full-screen triangle with top-left UV origin (uv.y flipped),
//   camera-delta UV reprojection of the history mask, the [0,1] valid-region bounds test that
//   zeroes off-region history, the bit-preserving history-channel copy (asuint->asfloat, a no-op
//   on the .y float), the current-source .x passthrough, and ZClip On / ZWrite Off / Cull Off.
// Removed: SPIRV-Cross statics + SPIRV_Cross_Input/Output plumbing, spvBitfieldInsert polyfill
//   (the SV_VertexID bit-twiddle is re-spelled as plain shifts/masks), the HGRP global cbuffer
//   `type_ShaderVariablesGlobal` (only its two foliage fields are kept, re-exposed as material
//   uniforms _FoliageOccluderParams0 / _FoliageOccluderCameraPosParam), the raw register/packoffset
//   binding (T0/T1 -> URP TEXTURE2D; sampler_LinearClamp comes from URP Core.hlsl, not re-declared).
//
// NOTE: this is a blit driven by a custom ScriptableRenderPass (the source pass carries no
//   LightMode tag, no Blend, ColorMask defaults). URP will only schedule it from a matching
//   Blitter/RenderPass that binds _FoliageOccluderHistory (T0) and _FoliageOccluderSource (T1),
//   the two foliage uniforms, and draws 3 vertices with no mesh. RenderType is Opaque only so the
//   shader compiles standalone; it is not part of any forward/shadow/depth queue.
// NOTE: output is RG only (SV_Target0 is a float2 in the source, line 120).
//   R = reprojected history T0.y (or 0 outside the valid region); G = current source T1.x.
// NOTE: _FoliageOccluderParams0.x is the occluder half-world-size; the reprojection divides the
//   camera XZ delta by (2 * .x) to convert world units to [0,1] UV (source line 125: _53 = x+x).

Shader "HGRP/BlitFoliageOccluderMask_Fix"
{
    Properties
    {
        // The source pass is driven entirely by full-screen-triangle vertex IDs (no mesh) plus
        // two HGRP-global uniforms and two bound textures. These were globals in the decompiled
        // cbuffer `type_ShaderVariablesGlobal`; URP has no such global, so they are re-exposed here
        // (set by the host ScriptableRenderPass via material.SetVector / SetTexture or globals).
        [HideInInspector] _FoliageOccluderParams0 ("Occluder Params0 (.x = half world size)", Vector) = (1, 0, 0, 0)
        [HideInInspector] _FoliageOccluderCameraPosParam ("Camera Pos Param (.xy=prev XZ, .zw=cur XZ)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _FoliageOccluderHistory ("History Mask (T0)", 2D) = "black" {}
        [HideInInspector] _FoliageOccluderSource ("Current Source (T1)", 2D) = "black" {}
    }

    SubShader
    {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
        LOD 100

        Pass
        {
            Name "FoliageOccluderBlit"

            // Source render state (blitfoliageoccludermask.shader lines 8-10):
            //   ZClip On  /  ZWrite Off  /  Cull Off   (no Blend, no ColorMask -> opaque overwrite, RGBA).
            ZClip On
            ZWrite Off
            Cull Off

            HLSLPROGRAM
            #pragma target 3.5
            #pragma vertex vert
            #pragma fragment frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // cbuffer type_ShaderVariablesGlobal, packoffset c240/c241 (source lines 100-104).
                float4 _FoliageOccluderParams0;
                float4 _FoliageOccluderCameraPosParam;
            CBUFFER_END

            // T0 / T1 (source lines 106-107) sampled with the global sampler_LinearClamp (s0, line 108).
            // sampler_LinearClamp is provided by URP Core.hlsl (GlobalSamplers.hlsl, included above) —
            // re-declaring it here would be a duplicate SamplerState definition (compile error).
            TEXTURE2D(_FoliageOccluderHistory);   // T0 : previous-frame mask (reprojected)
            TEXTURE2D(_FoliageOccluderSource);    // T1 : current-frame occluder source

            struct Attributes
            {
                uint vertexID : SV_VertexID;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD1; // top-left-origin full-screen UV (uv.y flipped)
            };

            // Full-screen triangle from SV_VertexID, 1:1 with source vert_main (lines 69-80).
            // Source (decoded from the spvBitfieldInsert polyfill):
            //   _34 = ((vertexID & 1u) != 0) ? 2.0 : 0.0     // BitfieldInsert(0, vid, off=1, cnt=1) -> bit0 placed at bit1
            //   _35 = float(vertexID & 2u)                    // 0 or 2
            //   gl_Position.x = _34 * 2 - 1                    // -1 or 3   (line 74)
            //   gl_Position.y = _35 * 2 - 1                    // -1 or 3   (line 75)
            //   gl_Position.z = 1, gl_Position.w = 1           // lines 78-79
            //   TEXCOORD.x = _34                               //  0 or 2   (line 76)
            //   TEXCOORD.y = 1 - _35                           //  1 or -1  (line 77, spelled ((-0.0)-_35)+1)
            Varyings vert(Attributes input)
            {
                Varyings output = (Varyings)0;

                float u = ((input.vertexID & 1u) != 0u) ? 2.0 : 0.0; // _34 (source line 72)
                float v = float(input.vertexID & 2u);                 // _35 (source line 73)

                output.positionCS = float4(mad(u, 2.0, -1.0),         // x  (source line 74)
                                           mad(v, 2.0, -1.0),         // y  (source line 75)
                                           1.0,                        // z  (source line 78)
                                           1.0);                       // w  (source line 79)
                output.uv = float2(u, 1.0 - v);                        // (source lines 76-77)
                return output;
            }

            // 1:1 with source frag_main (lines 123-139).
            float2 frag(Varyings input) : SV_Target
            {
                // _53 = _FoliageOccluderParams0.x + _FoliageOccluderParams0.x   (= 2*halfWorldSize, source line 125)
                float worldToUv = _FoliageOccluderParams0.x + _FoliageOccluderParams0.x;

                // Reproject the history UV by the camera XZ delta since last frame:
                //   _62 = (-cam.x + cam.z) / _53 + uv.x   (source line 126)
                //   _63 = (-cam.y + cam.w) / _53 + uv.y   (source line 127)
                // cam.xy = previous-frame camera XZ, cam.zw = current-frame camera XZ.
                float reprojU = ((-_FoliageOccluderCameraPosParam.x + _FoliageOccluderCameraPosParam.z) / worldToUv) + input.uv.x;
                float reprojV = ((-_FoliageOccluderCameraPosParam.y + _FoliageOccluderCameraPosParam.w) / worldToUv) + input.uv.y;

                // Valid-region test: if the reprojected UV leaves [0,1] in either axis, history -> 0.
                // Source line 129 OR-combines four (cond ? 0xffffffff : 0) masks; != 0u means out of range.
                // Boundaries are 1:1: strict (1.0 < x) on the high side, strict (x < 0.0) on the low side.
                float historyR;
                if ((reprojV > 1.0) || (reprojU > 1.0) || (reprojV < 0.0) || (reprojU < 0.0))
                {
                    historyR = 0.0; // source lines 130-132 (_86 = 0u)
                }
                else
                {
                    // _86 = asuint(T0.SampleLevel(LinearClamp, (_62,_63), 0).y); SV_Target.x = asfloat(_86)
                    // The asuint->asfloat round-trip is bit-preserving — a no-op on the float — so this
                    // is exactly T0.y at the reprojected UV (source lines 135 + 137).
                    historyR = SAMPLE_TEXTURE2D_LOD(_FoliageOccluderHistory, sampler_LinearClamp, float2(reprojU, reprojV), 0.0).y;
                }

                // SV_Target.y = T1.SampleLevel(LinearClamp, uv, 0).x   (current source, source line 138).
                float currentG = SAMPLE_TEXTURE2D_LOD(_FoliageOccluderSource, sampler_LinearClamp, input.uv, 0.0).x;

                return float2(historyR, currentG);
            }
            ENDHLSL
        }
    }
}
