// HGRP water interactive ripple-range accumulator — single fullscreen "RippleAdd" pass.
// Merged from: ripplerange.shader (single variant, no multi_compile permutations).
// Keywords: (none — this shader has no shader_feature variants)
// Kept: fullscreen-triangle vertex, UV->world-space remap over [center +/- halfRange], 8 ripple
//   point-sources (params4,5,6,7,8,9,10,11) each contributing a radial falloff
//   saturate(1 - length(worldPos - center) * radiusScale) weighted by paramN.w, summed onto the
//   previous-frame height (T0 sampled at clamped, P1.xy-offset UV) and broadcast to RGBA.
// Removed: SPIRV-Cross plumbing (spvBitfieldInsert / gl_Position / SPIRV_Cross_Input/Output statics),
//   HGRP global cbuffer type_WaterInteractiveCB (b0) — re-exposed as URP material uniforms; raw
//   register/packoffset/space bindings; source pass-state ZClip On (URP default, no explicit map needed).
//
// NOTE: rippleParams meaning (per source frag_main, ripplerange.shader:127-149):
//   _RippleArea.xy (params0) = ripple-area world center; _RippleArea.z is unused here.
//   _RippleOffset (params1): .xy = previous-buffer UV read offset, .z = half-range that the UV
//     [0,1] span maps to in world units (so worldPos = center.xy + (uv-0.5)*2*halfRange).
//   _RippleSrc4.._RippleSrc11 (params4..11): .xy = source world center, .w = source weight.
//   Shared radius scale = _RippleSrc4.z for sources 4,5,6,7,8,9,10; source 11 uses its OWN
//   _RippleSrc11.z as radius scale (the sole per-source override — ripplerange.shader:149).
//
// Source pass has NO Blend/ZWrite/ZTest/Cull declared (only ZClip On): a HGRP water-system fullscreen
//   blit that reads the prior height via T0 and writes height+ripples (ping-pong overwrite, NOT hardware
//   additive blend). Mapped to the standard URP fullscreen blit render-state (Cull Off/ZWrite Off/ZTest
//   Always/Blend Off).

Shader "HGRP/RippleRange_Fix" {
    Properties {
        [HideInInspector] _RipplePrevTex ("Previous Ripple Height", 2D) = "black" {}
        _RippleArea   ("Ripple Area Center (.xy = world center)", Vector) = (0, 0, 0, 0)
        _RippleOffset ("Ripple Offset (.xy = read UV offset, .z = world half-range)", Vector) = (0, 0, 1, 0)
        _RippleSrc4   ("Ripple Src 4 (.xy = center, .z = shared radius scale, .w = weight)", Vector) = (0, 0, 1, 0)
        _RippleSrc5   ("Ripple Src 5 (.xy = center, .w = weight)", Vector) = (0, 0, 0, 0)
        _RippleSrc6   ("Ripple Src 6 (.xy = center, .w = weight)", Vector) = (0, 0, 0, 0)
        _RippleSrc7   ("Ripple Src 7 (.xy = center, .w = weight)", Vector) = (0, 0, 0, 0)
        _RippleSrc8   ("Ripple Src 8 (.xy = center, .w = weight)", Vector) = (0, 0, 0, 0)
        _RippleSrc9   ("Ripple Src 9 (.xy = center, .w = weight)", Vector) = (0, 0, 0, 0)
        _RippleSrc10  ("Ripple Src 10 (.xy = center, .w = weight)", Vector) = (0, 0, 0, 0)
        _RippleSrc11  ("Ripple Src 11 (.xy = center, .z = own radius scale, .w = weight)", Vector) = (0, 0, 1, 0)
    }

    SubShader {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
        LOD 100

        Pass {
            Name "RippleAdd"
            // Source: single pass, ZClip On, no Blend/ZWrite/Cull/Stencil declared — see header NOTE.
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
                // type_WaterInteractiveCB fields (HGRP global cbuffer b0) -> material uniforms.
                float4 _RippleArea;    // _WaterInteractiveCB_rippleParams0 (c0). ripplerange.shader:128-131
                float4 _RippleOffset;  // _WaterInteractiveCB_rippleParams1 (c1). ripplerange.shader:127,130,150
                float4 _RippleSrc4;    // _WaterInteractiveCB_rippleParams4 (c4). ripplerange.shader:134-135,144
                float4 _RippleSrc5;    // _WaterInteractiveCB_rippleParams5 (c5). ripplerange.shader:132-133,144,150
                float4 _RippleSrc6;    // _WaterInteractiveCB_rippleParams6 (c6). ripplerange.shader:136-137,144
                float4 _RippleSrc7;    // _WaterInteractiveCB_rippleParams7 (c7). ripplerange.shader:138-139,144
                float4 _RippleSrc8;    // _WaterInteractiveCB_rippleParams8 (c8). ripplerange.shader:140-141,144
                float4 _RippleSrc9;    // _WaterInteractiveCB_rippleParams9 (c9). ripplerange.shader:142-143,144
                float4 _RippleSrc10;   // _WaterInteractiveCB_rippleParams10 (c10). ripplerange.shader:145-146,149
                float4 _RippleSrc11;   // _WaterInteractiveCB_rippleParams11 (c11). ripplerange.shader:147-149
            CBUFFER_END

            // T0 (blob register t0, ripplerange.shader:109). sampler_LinearClamp (s0, line 110) is a URP-global
            // sampler already declared by Core.hlsl -> GlobalSamplers.hlsl (SAMPLER(sampler_LinearClamp));
            // re-declaring it here is a duplicate-definition error (X3003), so only the texture is declared.
            TEXTURE2D(_RipplePrevTex);

            struct Attributes {
                uint vertexID : SV_VertexID;
            };

            struct Varyings {
                float4 positionCS : SV_Position;
                float2 uv         : TEXCOORD0;
            };

            // One ripple point-source contribution. 1:1 with the repeated inner term of the nested mads,
            // e.g. ripplerange.shader:144 ( (-clamp(sqrt(dot(off,off)) * scale, 0, 1) + 1) * weight ):
            //   falloff = saturate(1 - length(worldPos - center) * radiusScale), result = falloff * weight.
            // length spelled sqrt(dot(.,.)) to match the source exactly (line 144).
            float RippleFalloffWeighted(float2 worldPos, float2 center, float radiusScale, float weight) {
                float2 off = worldPos - center;
                float dist = sqrt(dot(off, off));
                float falloff = clamp(1.0 - dist * radiusScale, 0.0, 1.0);  // (-clamp(d*scale,0,1)) + 1
                return falloff * weight;
            }

            // 1:1 vertex — fullscreen triangle. Source vert_main (ripplerange.shader:64-75) generates the
            // SPIRV fullscreen triangle via spvBitfieldInsert: pos.xy = vidBits*2-1, uv = (b0, 1-b1).
            // URP's GetFullScreenTriangle* helpers emit the identical clip-space triangle + matching UVs.
            Varyings vert(Attributes input) {
                Varyings output;
                output.positionCS = GetFullScreenTriangleVertexPosition(input.vertexID);  // source z=1, w=1
                output.uv = GetFullScreenTriangleTexCoord(input.vertexID);
                return output;
            }

            // 1:1 fragment — ripple-range accumulation. Source frag_main (ripplerange.shader:125-156).
            float4 frag(Varyings input) : SV_Target {
                float2 uv = input.uv;

                // UV [0,1] -> world position across [center.xy - halfRange, center.xy + halfRange].
                // _49 = P0.x - P1.z (min X), _61 = mad(uv.x, ((P0.x+P1.z) - _49), _49). ripplerange.shader:127-131.
                float halfRange = _RippleOffset.z;                         // P1.z
                float minX = _RippleArea.x - halfRange;                    // _49
                float minY = _RippleArea.y - halfRange;                    // _50
                float worldX = mad(uv.x, (_RippleArea.x + halfRange) - minX, minX);  // _61
                float worldY = mad(uv.y, (_RippleArea.y + halfRange) - minY, minY);  // _62
                float2 worldPos = float2(worldX, worldY);

                // Accumulate the 8 sources in the SOURCE evaluation order (nested-mad order, ripplerange.shader:144,149):
                // 5, 4, 6, 7, 8, 9 (all radiusScale = _RippleSrc4.z), then 10 (scale = _RippleSrc4.z), then 11 (scale = _RippleSrc11.z).
                float sharedScale = _RippleSrc4.z;                         // P4.z

                // _208 (ripplerange.shader:144): src5*P5.w is the innermost (first-evaluated) term, then 4,6,7,8,9.
                float accum =
                      RippleFalloffWeighted(worldPos, _RippleSrc5.xy, sharedScale, _RippleSrc5.w)   // (... )*P5.w
                    + RippleFalloffWeighted(worldPos, _RippleSrc4.xy, sharedScale, _RippleSrc4.w)   // mad(..., P4.w, ...)
                    + RippleFalloffWeighted(worldPos, _RippleSrc6.xy, sharedScale, _RippleSrc6.w)
                    + RippleFalloffWeighted(worldPos, _RippleSrc7.xy, sharedScale, _RippleSrc7.w)
                    + RippleFalloffWeighted(worldPos, _RippleSrc8.xy, sharedScale, _RippleSrc8.w)
                    + RippleFalloffWeighted(worldPos, _RippleSrc9.xy, sharedScale, _RippleSrc9.w);

                // _256 (ripplerange.shader:149): + src10 (shared scale) + src11 (OWN _RippleSrc11.z scale).
                accum += RippleFalloffWeighted(worldPos, _RippleSrc10.xy, sharedScale, _RippleSrc10.w);
                accum += RippleFalloffWeighted(worldPos, _RippleSrc11.xy, _RippleSrc11.z, _RippleSrc11.w);

                // Previous-frame height: T0.SampleLevel(LinearClamp, saturate(saturate(uv) - P1.xy), 0).x.
                // ripplerange.shader:150-151. Double-clamp is 1:1 (clamp(clamp(uv,0,1) - offset, 0, 1)).
                float2 readUV = float2(
                    clamp(clamp(uv.x, 0.0, 1.0) - _RippleOffset.x, 0.0, 1.0),
                    clamp(clamp(uv.y, 0.0, 1.0) - _RippleOffset.y, 0.0, 1.0));
                float prevHeight = SAMPLE_TEXTURE2D_LOD(_RipplePrevTex, sampler_LinearClamp, readUV, 0.0).x;  // _277

                // SV_Target.xyzw = prevHeight + accum (broadcast). ripplerange.shader:152-155.
                float outValue = prevHeight + accum;
                return float4(outValue, outValue, outValue, outValue);
            }
            ENDHLSL
        }
    }
}
