// HGRP Foliage Interactive Blit — single full-screen-triangle reprojection pass.
// Advances the foliage interaction heightfield each frame. It reads the PREVIOUS frame's
// interaction RT (T0; RG = bend-depth / raise-amount, both encoded as world-Y in [0,1]) and
// re-derives the CURRENT frame's RT, accounting for (a) the camera-centered footprint moving in
// world XZ between frames (Last/Cur center pos + size) and (b) the bent grass recovering upward
// at _RaiseSpeed per second. Each current texel's world XZ is computed from the CURRENT center/
// size, mapped back into the PREVIOUS frame's UV, the history is sampled there, its two height
// channels are re-encoded into the CURRENT frame's Y range, and the .y (raise) channel is pushed
// up by _RaiseSpeed*_DeltaTime. Texels that are already fully recovered (R>0.999) or never
// initialised (RG both 0) reset hard to (1,1). The grass system consumes RG to bend/recover
// foliage around things that have pressed it down.
//
// Merged from: foliageinteractiveblit.shader (HGRP/Foliage/FoliageInteractiveBlit).
//   The whole shader is a single self-contained Pass with the vertex + fragment HLSL emitted
//   INLINE (no per-variant blob subfolder exists). Ground truth = the .shader itself:
//     Vertex  : foliageinteractiveblit.shader lines 70-81  (main glue 83-92).
//     Fragment: foliageinteractiveblit.shader lines 127-140 (main glue 142-149).
//
// Keywords: (none — the source declares no multi_compile_local; one single variant).
// Kept (1:1): SV_VertexID full-screen triangle with top-left UV origin (uv.y flipped); the
//   current-center -> previous-frame-UV history reprojection (CurCenterSize/Pos in, LastCenterPos/
//   Size out); the per-channel world-Y <-> [0,1] re-encode through Last/Cur center-size.y; the
//   _RaiseSpeed*_DeltaTime advance of the raise channel; the (raise <= 1.0) gate that holds vs.
//   snaps the bend channel to 1.0; the reset test ((0.999 < R) OR (G==0 AND R==0)) forcing (1,1);
//   ZClip On / ZWrite Off / ZTest Always / Cull Off.
// Removed: SPIRV-Cross statics + SPIRV_Cross_Input/Output plumbing, the spvBitfieldInsert polyfill
//   (the SV_VertexID bit-twiddle re-spelled as plain mask/select), the HGRP global cbuffer
//   `type_Globals` (its six foliage fields are kept, re-exposed as material uniforms), the raw
//   register/packoffset binding (T0 -> URP TEXTURE2D; sampler_LinearClamp comes from URP Core.hlsl,
//   not re-declared). The decompiler's asfloat(uint) bit-pattern selects are decoded to literals
//   (asfloat(1065353216u)=1.0, 0.999000012874603271484375f=0.999, all-ones masks = bool selects).
//
// NOTE: this is a blit driven by a custom ScriptableRenderPass (the source pass carries no
//   LightMode tag, no Blend; ZTest Always / ZWrite Off). URP will only schedule it from a matching
//   Blitter/RenderPass that binds _FoliageInteractiveHistory (T0), the six foliage uniforms, and
//   draws 3 vertices with no mesh. RenderType is Opaque only so the shader compiles standalone; it
//   is not part of any forward/shadow/depth queue.
// NOTE: output is float4(bendDepth, raiseAmount, 0, 1).
//   R/G are world-Y encoded heights in [0,1]; B is always 0, A always 1 (source lines 138-139).
//   .xy center fields index as: CurCenterPos/Size .x = world X, .z = world Z, .y = world Y range.

Shader "HGRP/FoliageInteractiveBlit_Fix"
{
    Properties
    {
        // The source pass is driven entirely by full-screen-triangle vertex IDs (no mesh) plus the
        // HGRP-global `type_Globals` cbuffer and one bound texture. URP has no such global, so the
        // six foliage fields are re-exposed here (set by the host ScriptableRenderPass via
        // material.SetFloat / SetVector / SetTexture or as shader globals).
        [HideInInspector] _DeltaTime       ("Delta Time (s)", Float) = 0
        [HideInInspector] _RaiseSpeed      ("Raise Speed (world-Y / s)", Float) = 0
        [HideInInspector] _LastCenterPos   ("Last Center Pos (.x=X .z=Z .y=Y origin)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _LastCenterSize  ("Last Center Size (.x=X .z=Z .y=Y range)", Vector) = (1, 1, 1, 0)
        [HideInInspector] _CurCenterPos    ("Cur Center Pos (.x=X .z=Z .y=Y origin)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _CurCenterSize   ("Cur Center Size (.x=X .z=Z .y=Y range)", Vector) = (1, 1, 1, 0)
        [HideInInspector] _FoliageInteractiveHistory ("History RT (T0)", 2D) = "black" {}
    }

    SubShader
    {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
        LOD 100

        Pass
        {
            Name "FoliageInteriaveBlit"

            // Source render state (foliageinteractiveblit.shader lines 8-11):
            //   ZClip On  /  ZTest Always  /  ZWrite Off  /  Cull Off
            //   (no Blend, no ColorMask -> opaque overwrite, RGBA).
            ZClip On
            ZTest Always
            ZWrite Off
            Cull Off

            HLSLPROGRAM
            #pragma target 3.5
            #pragma vertex vert
            #pragma fragment frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // cbuffer type_Globals, packoffset c0.x/c0.y/c1..c4 (source lines 101-109).
                float  _DeltaTime;
                float  _RaiseSpeed;
                float4 _LastCenterPos;
                float4 _LastCenterSize;
                float4 _CurCenterPos;
                float4 _CurCenterSize;
            CBUFFER_END

            // T0 (source line 111) sampled with the global sampler_LinearClamp (s0, line 112).
            // sampler_LinearClamp is provided by URP Core.hlsl (GlobalSamplers.hlsl, included above) —
            // re-declaring it here would be a duplicate SamplerState definition (compile error).
            TEXTURE2D(_FoliageInteractiveHistory); // T0 : previous-frame interaction RT (RG heights)

            struct Attributes
            {
                uint vertexID : SV_VertexID;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD1; // top-left-origin full-screen UV (uv.y flipped)
            };

            // Full-screen triangle from SV_VertexID, 1:1 with source vert_main (lines 70-81).
            // Source (decoded from the spvBitfieldInsert polyfill, lines 72-73):
            //   _34 = float(BitfieldInsert(0, vid - baseVertex, off=1, cnt=1))  -> bit0 placed at bit1 == ((vid&1)!=0 ? 2 : 0)
            //   _35 = float((vid - baseVertex) & 2u)                            -> 0 or 2
            //   gl_Position.x = _34 * 2 - 1   // -1 or 3   (line 75)
            //   gl_Position.y = _35 * 2 - 1   // -1 or 3   (line 76)
            //   gl_Position.z = 1, gl_Position.w = 1        (lines 79-80)
            //   TEXCOORD.x = _34              //  0 or 2   (line 77)
            //   TEXCOORD.y = 1 - _35          //  1 or -1  (line 78, spelled ((-0.0)-_35)+1)
            // (baseVertex == 0 for a no-mesh full-screen draw, so vid-baseVertex == vid.)
            Varyings vert(Attributes input)
            {
                Varyings output = (Varyings)0;

                float u = ((input.vertexID & 1u) != 0u) ? 2.0 : 0.0; // _34 (source line 72-73)
                float v = float(input.vertexID & 2u);                 // _35 (source line 74)

                output.positionCS = float4(mad(u, 2.0, -1.0),         // x  (source line 75)
                                           mad(v, 2.0, -1.0),         // y  (source line 76)
                                           1.0,                        // z  (source line 79)
                                           1.0);                       // w  (source line 80)
                output.uv = float2(u, 1.0 - v);                        // (source lines 77-78)
                return output;
            }

            // 1:1 with source frag_main (lines 127-140).
            // Magic-constant decodes (STYLE_BIBLE §4):
            //   asfloat(1065353216u)              = 1.0  (0x3F800000)
            //   asfloat((cond?0xffffffff:0) & 1065353216u) = cond ? 1.0 : 0.0   -> used as a select weight
            //   asfloat(cond ? 0u : 1065353216u)  = cond ? 0.0 : 1.0
            //   0.999000012874603271484375f       = 0.999
            //   (x ? 0xffffffff : 0u) | ...  != 0u  -> plain boolean OR/AND
            float4 frag(Varyings input) : SV_Target
            {
                // History UV reprojection (source line 129): take the current texel's world XZ from the
                // CURRENT center (uv-0.5 scaled by CurCenterSize about CurCenterPos), shift into the
                // PREVIOUS frame's local frame (-LastCenterPos), normalise by LastCenterSize, recentre +0.5.
                //   note .x uses CurCenterSize.x/LastCenterSize.x; .y uses the .z (world-Z) components.
                float histU = ((mad(input.uv.x - 0.5, _CurCenterSize.x, _CurCenterPos.x) - _LastCenterPos.x) / _LastCenterSize.x) + 0.5;
                float histV = ((mad(input.uv.y - 0.5, _CurCenterSize.z, _CurCenterPos.z) - _LastCenterPos.z) / _LastCenterSize.z) + 0.5;

                // Sample previous-frame interaction RT. _76 = .x (bend depth), _77 = .y (raise amount).
                // (source line 129 SampleLevel ... lines 130-131)
                float4 history = SAMPLE_TEXTURE2D_LOD(_FoliageInteractiveHistory, sampler_LinearClamp, float2(histU, histV), 0.0);
                float bendPrev  = history.x; // _76
                float raisePrev = history.y; // _77

                // _98 = -_CurCenterPos.y   (source line 132, spelled (-0.0f)-CurCenterPos.y)
                float negCurY = -_CurCenterPos.y;

                // Raise channel advanced (source line 133):
                //   _106 = ( (raisePrev-0.5)*LastCenterSize.y + LastCenterPos.y   // decode prev raise world-Y
                //            + _RaiseSpeed*_DeltaTime                              // recover upward this frame
                //            - CurCenterPos.y ) / CurCenterSize.y + 0.5           // re-encode into current Y range
                float raiseWorld = mad(raisePrev - 0.5, _LastCenterSize.y, _LastCenterPos.y);
                float raiseAdvanced = mad(_RaiseSpeed, _DeltaTime, raiseWorld) + negCurY;
                float raiseEncoded = (raiseAdvanced / _CurCenterSize.y) + 0.5; // _106

                // _109 = 1.0 >= _106   (raise still within / below the top of the current Y range)
                bool raiseInRange = (1.0 >= raiseEncoded); // source line 134

                // Reset test (source line 135): fully recovered (0.999 < bendPrev) OR uninitialised
                // (raisePrev == 0 AND bendPrev == 0). Decoded from the OR/AND of all-ones masks != 0u.
                bool reset = (0.999 < bendPrev) || ((raisePrev == 0.0) && (bendPrev == 0.0)); // _130

                // Bend channel decoded into the current Y range (inner of source line 136):
                //   bendEncoded = ( (bendPrev-0.5)*LastCenterSize.y + LastCenterPos.y - CurCenterPos.y ) / CurCenterSize.y + 0.5
                float bendWorld = mad(bendPrev - 0.5, _LastCenterSize.y, _LastCenterPos.y);
                float bendEncoded = ((bendWorld + negCurY) / _CurCenterSize.y) + 0.5;

                // mad(bendEncoded, raiseInRange?1:0, raiseInRange?0:1) == raiseInRange ? bendEncoded : 1.0
                // (source line 136: the two asfloat() selects collapse to this branch).
                float bendGated = raiseInRange ? bendEncoded : 1.0;

                float outR = reset ? 1.0 : clamp(bendGated,    0.0, 1.0); // SV_Target.x (source line 136)
                float outG = reset ? 1.0 : clamp(raiseEncoded, 0.0, 1.0); // SV_Target.y (source line 137)

                // SV_Target.z = 0.0, SV_Target.w = 1.0  (source lines 138-139)
                return float4(outR, outG, 0.0, 1.0);
            }
            ENDHLSL
        }
    }
}
