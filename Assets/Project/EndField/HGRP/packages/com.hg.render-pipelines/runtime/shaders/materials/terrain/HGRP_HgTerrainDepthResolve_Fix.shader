// HGRP Terrain Depth Resolve — single full-screen-triangle depth-copy + stencil-tag pass.
// Re-projects a precomputed terrain DEPTH texture (T0, single channel .x) straight into the
// hardware depth buffer via SV_Depth, while tagging touched pixels in the stencil buffer
// (Ref 3, WriteMask 2, Comp Always, Pass Replace). Pixels whose source depth is exactly 0
// (no terrain coverage / cleared) are DISCARDED, so they neither write depth nor stencil.
// HGRP runs this to "resolve" the terrain's own depth pre-pass into the main camera depth so
// later passes (and the stencil tag) can treat terrain as written-into the shared depth buffer.
//
// Merged from: hgterraindepthresolve.shader (HGRP/HGTerrainDepthResolve).
//   The whole shader is a single self-contained Pass with the vertex + fragment HLSL emitted
//   INLINE (no per-variant blob subfolder exists). Ground truth = the .shader itself:
//     Vertex  : hgterraindepthresolve.shader lines 77-99  (vert_main 77-88, main glue 90-99).
//     Fragment: hgterraindepthresolve.shader lines 142-159 (frag_main 142-150).
//
// Keywords: (none — the source declares no multi_compile_local; exactly one variant).
// Kept (1:1): SV_VertexID full-screen triangle with top-left UV origin (uv.y = 1 - vBit) and
//   clip-space z = 0 / w = 1 (source lines 86-87); single-channel depth tap T0.x at LOD 0;
//   discard-when-depth==0 (source line 147); SV_Depth = sampled depth (source line 148);
//   render state ZClip On / ZTest Always / Cull Off and the Stencil block (Ref 3, WriteMask 2,
//   Comp Always, Pass Replace, Fail Keep, ZFail Keep).
// Removed: SPIRV-Cross statics + SPIRV_Cross_Input/Output plumbing, the spvBitfieldInsert
//   polyfill (the SV_VertexID bit-twiddle is re-spelled as plain mask/select), the
//   discard_state / discard_cond / discard_exit helper dance (collapsed to a single clip()/discard),
//   raw register/space bindings (T0 -> URP TEXTURE2D; S0 -> SAMPLER(sampler_PointClamp)).
//
// NOTE: This is a blit driven by a custom HGRP ScriptableRenderPass (the source pass carries no
//   LightMode tag). URP will only schedule it from a matching Blitter/RenderPass that binds
//   _TerrainDepthTex (T0) and draws 3 vertices with no mesh. RenderType is Opaque only so the
//   shader compiles standalone; it is not part of any forward/shadow/depth queue tag.
// NOTE: The source samples a NON-reversed depth value and writes it verbatim to SV_Depth — it does
//   no reversed-Z conversion. The depth in _TerrainDepthTex must already be in the buffer's native
//   convention; this pass is a bit-faithful copy, not a re-projection.

Shader "HGRP/HgTerrainDepthResolve_Fix"
{
    Properties
    {
        // T0 in the decompiled source (line 108): the precomputed terrain depth texture, sampled
        // .x only. Bound by the host ScriptableRenderPass; "black" => depth 0 => fully discarded
        // until a real depth target is supplied.
        [HideInInspector] _TerrainDepthTex ("Terrain Depth (T0, .x)", 2D) = "black" {}

        // Stencil plumbing exposed so the host material/pass can retarget the tag without editing
        // the shader. Defaults are the source's literals (lines 12-13): Ref 3, WriteMask 2.
        [HideInInspector] _StencilRef       ("Stencil Ref", Float) = 3
        [HideInInspector] _StencilWriteMask ("Stencil Write Mask", Float) = 2
    }

    SubShader
    {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
        LOD 100

        Pass
        {
            Name "TerrainDepthResolve"

            // Source render state (hgterraindepthresolve.shader lines 8-18):
            //   ZClip On / ZTest Always / Cull Off, and a stencil tag.
            // The fragment writes SV_Depth explicitly, so ZWrite is left at its default (On);
            // ZTest Always means the comparison never rejects, exactly as the source.
            ZClip On
            ZTest Always
            Cull Off
            Stencil
            {
                Ref [_StencilRef]
                WriteMask [_StencilWriteMask]
                Comp Always
                Pass Replace
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Stencil refs live in the cbuffer only so the [HideInInspector] floats above bind;
                // they are not read by HLSL (the stencil unit consumes them directly).
                float _StencilRef;
                float _StencilWriteMask;
            CBUFFER_END

            // T0 (source line 108) sampled with S0 (source line 109). The depth tap is a point/
            // nearest read (SampleLevel at LOD 0 on a 1:1 full-screen blit), so it is mapped to the
            // URP-global SAMPLER(sampler_PointClamp). sampler_PointClamp is provided by URP Core.hlsl
            // (GlobalSamplers.hlsl); re-declaring it here would be a duplicate-definition error.
            TEXTURE2D(_TerrainDepthTex);   // T0 : precomputed terrain depth, .x

            struct Attributes
            {
                uint vertexID : SV_VertexID;
            };

            struct Varyings
            {
                float4 positionCS : SV_Position;
                float2 uv         : TEXCOORD1; // top-left-origin full-screen UV (uv.y flipped)
            };

            // Full-screen triangle from SV_VertexID, 1:1 with source vert_main (lines 77-88).
            // Source (decoded from the spvBitfieldInsert polyfill):
            //   _34 = ((vertexID & 1u) != 0) ? 2.0 : 0.0   // BitfieldInsert(0, vid, off=1, cnt=1): bit0 -> bit1
            //   _35 = float(vertexID & 2u)                  // 0 or 2
            //   gl_Position.x = _34 * 2 - 1                  // -1 or 3   (source line 82)
            //   gl_Position.y = _35 * 2 - 1                  // -1 or 3   (source line 83)
            //   TEXCOORD.x    = _34                          //  0 or 2   (source line 84)
            //   TEXCOORD.y    = 1 - _35                      //  1 or -1  (source line 85, spelled ((-0.0)-_35)+1)
            //   gl_Position.z = 0                            // (source line 86)  NOTE: 0, not near-clip
            //   gl_Position.w = 1                            // (source line 87)
            Varyings vert(Attributes input)
            {
                Varyings output = (Varyings)0;

                float u = ((input.vertexID & 1u) != 0u) ? 2.0 : 0.0; // _34 (source line 80)
                float v = float(input.vertexID & 2u);                 // _35 (source line 81)

                output.positionCS = float4(mad(u, 2.0, -1.0),         // x  (source line 82)
                                           mad(v, 2.0, -1.0),         // y  (source line 83)
                                           0.0,                        // z  (source line 86)
                                           1.0);                       // w  (source line 87)
                output.uv = float2(u, 1.0 - v);                        // (source lines 84-85)
                return output;
            }

            // 1:1 with source frag_main (lines 142-150). Returns depth via SV_Depth; discards when
            // the sampled depth is exactly 0 (cleared / no-coverage texels).
            float frag(Varyings input) : SV_Depth
            {
                // _33 = T0.SampleLevel(S0, (uv.x, uv.y), 0); _35 = _33.x   (source lines 145-146)
                float depth = SAMPLE_TEXTURE2D_LOD(_TerrainDepthTex, sampler_PointClamp, input.uv, 0.0).x;

                // discard_cond(_35 == 0.0); ... discard_exit()   (source lines 147,149)
                // clip(x) discards when x < 0; -(depth == 0) is 0 when depth!=0 (keep) and -1 when
                // depth==0 (discard) — bit-identical branch to the source's discard-on-equal-zero.
                clip(depth == 0.0 ? -1.0 : 1.0);

                // gl_FragDepth = _35   (source line 148)
                return depth;
            }
            ENDHLSL
        }
    }
}
