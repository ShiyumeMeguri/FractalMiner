// HGRP interactive-water ripple SIMULATE pass -> URP. One fullscreen blit pass that advances
// a height-field wave-equation integrator by one step (double-buffered ripple RT).
// Merged from: ripplesimulate.shader (single base variant, blob 2 = Fragment, blob 1 = Vertex; no keywords).
// Keywords: (none) — the source has zero multi_compile_local; it is a single self-contained GPGPU pass.
// Kept: fullscreen-triangle SV_VertexID vertex with the source's Y-flipped UV (TEXCOORD.y = 1 - bit),
//   damping ramp (min(30.003*rp0.w,1)*rp3.w), damping-scaled axis-aligned 4-neighbor Laplacian,
//   previous-frame advected feedback (rp3.z), wave-speed/output scale (rp3.x), neighbor weight (2*rp3.y),
//   radial edge mask 1-saturate((length(uv-0.5)-0.4)*10), result broadcast to RGBA.
// Removed (pixel-neutral pipeline infra, substituted by URP): HGRP global cbuffers
//   type_ShaderVariablesGlobal._GlobalMipBias (scalar) -> URP global _GlobalMipBias.x (Input.hlsl) fed to
//   SAMPLE..._BIAS; type_Globals._Globals_CurrentRT_TexelSize -> material _CurrentRT_TexelSize; SamplerState
//   sampler_LinearClamp -> URP global sampler_LinearClamp (GlobalSamplers.hlsl via Core.hlsl, NOT re-declared);
//   SPIRV-Cross gl_* statics / spvBitfieldInsert polyfill / SPIRV_Cross_Input/_Output plumbing ->
//   clean Attributes/Varyings + SV_VertexID fullscreen triangle.
//
// NOTE: this is NOT a lit/PBR surface — no Core lighting, no _SurfaceType blend pattern. It is a compute-
//   style fullscreen pass driven entirely by the _WaterInteractiveCB uniforms. Render state mirrors the
//   source: ZClip On is the only declared state, so URP-side ZWrite Off / ZTest Always / Cull Off / Blend Off
//   (an RT integrator that fully overwrites its target). The driving C# (HG WaterInteractive) binds T0/T1 and
//   the rippleParamsN each frame; here they are exposed as _PrevHeightTex (T0) / _CurrHeightTex (T1) + a
//   _RippleParams0/1/3 Vector trio so the same RT pipeline can drive this _Fix shader.
//   rippleParams semantics (from the math, blob lines 131-143): rp0.w=age->damping ramp; rp1.xy=advection
//   UV offset for the prev-frame tap; rp3.x=output/wave-speed scale; rp3.y=neighbor weight (used as 2*rp3.y);
//   rp3.z=prev-frame feedback; rp3.w=global damping. Texel sign: taps use +texel and -texel symmetrically.

Shader "HGRP/RippleSimulate_Fix"
{
    Properties
    {
        [HideInInspector] _PrevHeightTex ("Prev Height (T0)", 2D) = "black" {}
        [HideInInspector] _CurrHeightTex ("Curr Height (T1)", 2D) = "black" {}

        // _Globals.CurrentRT_TexelSize (1/w, 1/h, w, h). Only .x/.y are read.
        [HideInInspector] _CurrentRT_TexelSize ("RT TexelSize (1/w,1/h,w,h)", Vector) = (0.00390625, 0.00390625, 256, 256)
        // NOTE: _GlobalMipBias is a URP-provided global (Input.hlsl, float2 .x=bias), driven by the
        // pipeline each frame — it is intentionally NOT a material property here.

        // ShaderVariables WaterInteractiveCB rippleParams (only 0,1,3 are read by this pass).
        // rp0: (_, _, _, .w = age driving the damping ramp)
        [HideInInspector] _RippleParams0 ("Ripple Params 0 (.w=age)", Vector) = (0, 0, 0, 1)
        // rp1: (.x,.y = advection UV offset for prev tap)
        [HideInInspector] _RippleParams1 ("Ripple Params 1 (.xy=advectUV)", Vector) = (0, 0, 0, 0)
        // rp3: (.x=outputScale, .y=neighborWeight, .z=prevFeedback, .w=globalDamping)
        [HideInInspector] _RippleParams3 ("Ripple Params 3 (.x=scale .y=nWeight .z=prevFb .w=damp)", Vector) = (1, 0.25, 0.99, 1)
    }

    SubShader
    {
        Tags { "RenderPipeline" = "UniversalPipeline" }
        LOD 100

        Pass
        {
            Name "RippleSimulate"
            // Source declares only "ZClip On"; this is a full-overwrite RT integrator.
            ZWrite Off
            ZTest Always
            Cull Off
            Blend Off

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            // _GlobalMipBias is NOT declared here: URP Core (Input.hlsl) already declares it
            // globally as `float2 _GlobalMipBias` (.x = mip bias, .y = 2^bias). The source's HGRP
            // scalar `_GlobalMipBias` (type_ShaderVariablesGlobal c108, blob line 97) maps 1:1 to
            // URP's `_GlobalMipBias.x`. Re-declaring it here would be a redefinition/type conflict.
            CBUFFER_START(UnityPerMaterial)
                float4 _CurrentRT_TexelSize;
                float4 _RippleParams0;
                float4 _RippleParams1;
                float4 _RippleParams3;
            CBUFFER_END

            // sampler_LinearClamp is provided globally by URP Core (GlobalSamplers.hlsl,
            // pulled in by Core.hlsl above) — re-declaring it here is a redefinition error.
            // Source used the SRP global SamplerState sampler_LinearClamp (blob line 114).
            TEXTURE2D(_PrevHeightTex);
            TEXTURE2D(_CurrHeightTex);

            struct Attributes
            {
                uint vertexID : SV_VertexID;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
            };

            // Fullscreen triangle from SV_VertexID, 1:1 with blob 1 vert_main (Vertex_b... lines 64-75):
            //   x bit  = bit0 of vertexID, y bit = bit1 (value 0 or 2);
            //   clip.xy = bit*2 - 1; uv.x = xbit; uv.y = 1 - ybit (Y flip); clip.z = clip.w = 1.
            // The source's spvBitfieldInsert(0u, id, 1, 1) extracts bit0 as a float in {0,1};
            // ((-0.0f)-_35)+1.0f is a 1 - _35 Y-flip.
            Varyings vert(Attributes input)
            {
                Varyings output;
                float xBit = float(input.vertexID & 1u);          // {0,1}            (blob vert line 67)
                float yBit = float(input.vertexID & 2u);          // {0,2}            (blob vert line 68)
                output.positionCS = float4(mad(xBit, 2.0, -1.0),  // clip.x           (blob vert line 69)
                                           mad(yBit, 2.0, -1.0),  // clip.y           (blob vert line 70)
                                           1.0, 1.0);             // clip.z, clip.w   (blob vert lines 73-74)
                output.uv = float2(xBit, 1.0 - yBit);             // Y-flipped uv     (blob vert lines 71-72)
                return output;
            }

            // Wave-equation integrator, 1:1 with blob 2 frag_main (Fragment_b... lines 129-148).
            float4 frag(Varyings input) : SV_Target
            {
                // _53: damping ramp ramps to 1 over ~1/30.003 of rp0.w, scaled by global damping rp3.w.
                //      (blob line 131)  30.0030002593994140625 kept exactly.
                float damping = min(30.0030002593994140625 * _RippleParams0.w, 1.0) * _RippleParams3.w;

                // _59/_60: vertical/horizontal tap distance = damping * texel. (blob lines 132-133)
                float tapY = damping * _CurrentRT_TexelSize.y;
                float tapX = damping * _CurrentRT_TexelSize.x;

                // _61/_62 = asfloat(0u) = 0 -> the cross-axis component of each tap is zero,
                //           so the 4 taps are axis-aligned N/S/E/W. (blob lines 134-135)
                const float zeroOff = 0.0;

                // _70/_71: clamped center uv. (blob lines 136-137)
                float2 uv = saturate(input.uv);

                // _120: center current height H. (blob lines 138-139)
                float H = SAMPLE_TEXTURE2D_BIAS(_CurrHeightTex, sampler_LinearClamp, uv, _GlobalMipBias.x).x;

                // _156: radial edge mask = 1 - saturate((length(uv-0.5) - 0.4) * 10). (blob lines 140-142)
                //       0.4000000059604644775390625 kept exactly (~0.4).
                float2 centered = uv - 0.5;
                float edgeMask = 1.0 - min(max(sqrt(dot(centered, centered)) - 0.4000000059604644775390625, 0.0) * 10.0, 1.0);

                // Previous-frame advected tap (T0 at uv - rp1.xy, clamped). (inside blob line 143)
                float2 prevUV = saturate(uv - _RippleParams1.xy);
                float prevAdvected = SAMPLE_TEXTURE2D_BIAS(_PrevHeightTex, sampler_LinearClamp, prevUV, _GlobalMipBias.x).x;

                // Four axis-aligned neighbor taps of current height T1. (blob line 143)
                //   N: (uv.x + zeroOff,  uv.y + tapY)
                //   E: (uv.x + tapX,     uv.y + zeroOff)
                //   W: (uv.x - tapX,     uv.y - zeroOff)
                //   S: (uv.x - zeroOff,  uv.y - tapY)
                float nTap = SAMPLE_TEXTURE2D_BIAS(_CurrHeightTex, sampler_LinearClamp, float2(uv.x + zeroOff, uv.y + tapY),    _GlobalMipBias.x).x;
                float eTap = SAMPLE_TEXTURE2D_BIAS(_CurrHeightTex, sampler_LinearClamp, float2(uv.x + tapX,    uv.y + zeroOff), _GlobalMipBias.x).x;
                float wTap = SAMPLE_TEXTURE2D_BIAS(_CurrHeightTex, sampler_LinearClamp, float2(uv.x - tapX,    uv.y - zeroOff), _GlobalMipBias.x).x;
                float sTap = SAMPLE_TEXTURE2D_BIAS(_CurrHeightTex, sampler_LinearClamp, float2(uv.x - zeroOff, uv.y - tapY),    _GlobalMipBias.x).x;
                float neighborSum = nTap + eTap + wTap + sTap;

                // Discrete Laplacian * (2 * neighborWeight): mad(-H, 4, neighborSum) * (rp3.y + rp3.y). (blob line 143)
                float laplacianTerm = mad(-H, 4.0, neighborSum) * (_RippleParams3.y + _RippleParams3.y);

                // Previous-frame feedback: mad(rp3.z, (-prevAdvected) + H, H) = H + rp3.z*(H - prevAdvected). (blob line 143)
                float prevTerm = mad(_RippleParams3.z, (-prevAdvected) + H, H);

                // _173 = mad(rp3.x, prevTerm, laplacianTerm) = rp3.x*prevTerm + laplacianTerm. (blob line 143)
                float newHeight = mad(_RippleParams3.x, prevTerm, laplacianTerm);

                // Output = edgeMask * newHeight broadcast to RGBA. (blob lines 144-147)
                return (edgeMask * newHeight).xxxx;
            }
            ENDHLSL
        }
    }
}
