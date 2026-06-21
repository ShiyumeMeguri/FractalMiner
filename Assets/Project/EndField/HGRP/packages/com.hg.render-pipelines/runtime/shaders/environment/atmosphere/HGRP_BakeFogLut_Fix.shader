// HGRP atmosphere fog-LUT baker -> URP — single fullscreen pass that bakes a 2D fog lookup table.
// Merged from: bakefoglut.shader (single variant, no multi_compile permutations, code inline in the .shader).
// Keywords: (none — this shader has no shader_feature variants)
// Kept (1:1): fullscreen-triangle vertex; the dual-mode fragment selected by the LUT column
//   (gl_FragCoord.x == 0 vs != 0):
//     * column 0  -> RGB = clamp(Rayleigh-phase + Henyey-Greenstein-phase scattering, 0..1) * 255, A = 0.
//     * column !=0 -> RGB = atmospheric in-scatter transmittance 1-exp2(inscatter*AtmoFog2.rgb),
//                     A   = combined two-layer exponential height-fog transmittance 1-min(linear+height,1).
//   Henyey-Greenstein phase (1-g^2)/(4*pi*(1+g^2-2g*cos)^1.5); Rayleigh (1+cos^2)*3/(16*pi);
//   exponential-depth slice decode; analytic optical-depth integral (1-2^-x)/x with small-x Taylor guard.
// Removed (pixel-neutral pipeline infra, substituted by URP): SPIRV-Cross plumbing
//   (spvBitfieldInsert / gl_Position / gl_VertexIndex / gl_BaseVertexARB / SPIRV_Cross_Input/Output statics);
//   the HGRP global cbuffer `type_ShaderVariablesGlobal : register(b0)` with packoffset bindings — every
//   field re-exposed as a URP material uniform; `_WorldSpaceCameraPos_Internal` -> URP `_WorldSpaceCameraPos`.
//
// NOTE: this is a render-target baker, not a surface shader: it is drawn fullscreen into a fog LUT RT.
//   The Y axis (uv.y) encodes view zenith / vertical ray direction; the X axis (uv.x) encodes the
//   exponential depth slice; the FIRST texel column (x==0) is repurposed to store the directional
//   scattering colors while every other column stores the per-distance fog integration.
//   All `_AtmosphereFogParams*` / `_ExponentialFogParams*` / `_FogBakeLut*Params` are HGRP per-frame
//   globals; URP has no equivalent, so they are material Vectors fed by the C# bake pass.

Shader "HGRP/BakeFogLut_Fix" {
    Properties {
        // HGRP `type_ShaderVariablesGlobal` fog globals re-exposed as material uniforms (source packoffset c153..c174).
        [Header(Atmosphere Fog Params)]
        _AtmosphereFogParams0 ("Atmosphere Fog Params 0", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams1 ("Atmosphere Fog Params 1", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams2 ("Atmosphere Fog Params 2 (.w = HG anisotropy g)", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams3 ("Atmosphere Fog Params 3", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams4 ("Atmosphere Fog Params 4", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams5 ("Atmosphere Fog Params 5", Vector) = (0, 0, 0, 0)

        [Header(Exponential Fog Params)]
        _ExponentialFogParams0 ("Exponential Fog Params 0 (layer0 height/density/falloff)", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams1 ("Exponential Fog Params 1 (.x bias .y scale)", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams2 ("Exponential Fog Params 2 (.w density floor)", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams3 ("Exponential Fog Params 3 (layer1 falloff/density/height)", Vector) = (0, 0, 0, 0)

        [Header(Fog Bake LUT Params)]
        _FogBakeLutRescaleParams ("Fog Bake LUT Rescale Params (.z scale .w bias)", Vector) = (0, 0, 0, 0)
        _FogBakeLutEncodeParams ("Fog Bake LUT Encode Params (.z .w exp-depth decode)", Vector) = (0, 0, 0, 0)
        _FogBakeLutYawParams ("Fog Bake LUT Yaw Params (.x scale .y bias)", Vector) = (0, 0, 0, 0)
    }

    SubShader {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
        LOD 100

        Pass {
            Name "BakeFogLut"
            // Source render-state (bakefoglut.shader lines 7-10): ZClip On, ZTest Always, ZWrite Off, Cull Off.
            // ZClip On is the default; the rest map directly. No Blend/Stencil/ColorMask declared.
            Cull Off
            ZWrite Off
            ZTest Always
            Blend Off

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            // Core.hlsl brings _WorldSpaceCameraPos plus mad/exp2/asfloat and the URP CBUFFER/TEXTURE macros.
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _AtmosphereFogParams0;     // source packoffset c153
                float4 _AtmosphereFogParams1;     // source packoffset c154
                float4 _AtmosphereFogParams2;     // source packoffset c155 (.w = HG g)
                float4 _AtmosphereFogParams3;     // source packoffset c156
                float4 _AtmosphereFogParams4;     // source packoffset c157
                float4 _AtmosphereFogParams5;     // source packoffset c158
                float4 _ExponentialFogParams0;    // source packoffset c159
                float4 _ExponentialFogParams1;    // source packoffset c160
                float4 _ExponentialFogParams2;    // source packoffset c161
                float4 _ExponentialFogParams3;    // source packoffset c162
                float4 _FogBakeLutRescaleParams;  // source packoffset c172
                float4 _FogBakeLutEncodeParams;   // source packoffset c173
                float4 _FogBakeLutYawParams;      // source packoffset c174
            CBUFFER_END

            // _WorldSpaceCameraPos_Internal (source cbuffer packoffset c44) -> URP global from Core.hlsl.
            // Core.hlsl declares `_WorldSpaceCameraPos`; we read its .y for the camera world height.

            // ----- magic constants decoded from the denormalized/literal floats in bakefoglut.shader -----
            static const float RAYLEIGH_PHASE_NORM = 0.0596831031143665313720703125; // 3/(16*pi)  (source line 137)
            static const float FOUR_PI             = 12.56637096405029296875;         // 4*pi       (source lines 139)
            static const float LOG2_E              = 1.44269502162933349609375;       // log2(e)=1/ln2 (source lines 146,148,150-153)
            static const float LN2                 = 0.693147182464599609375;         // ln(2)      (source line 146 Taylor c0)
            static const float LN2_SQ_OVER_2       = 0.2402265071868896484375;        // (ln2)^2/2  (source line 146 Taylor c1)
            static const float SELECT_EPS          = 5.9604644775390625e-08;          // 2^-24 : |x|>eps guard (source line 146)
            static const float EXP2_FLOOR          = -127.0;                          // exp2 argument clamp floor (source lines 144-146)

            // Analytic optical-depth integral factor (1 - 2^-x)/x, with the small-x 2-term Taylor fallback
            // ln2 - x*(ln2)^2/2 when |x| <= 2^-24. Source line 146:
            //   asfloat((2^-24 < abs(x)) ? asuint((((-0)-exp2((-0)-x))+1)/x) : asuint(mad((-0)-x, 0.2402265, 0.693147)))
            // The asfloat(cond ? asuint(A) : asuint(B)) idiom is a plain float select A:B.
            float TransmittanceIntegralFactor(float x)
            {
                return (SELECT_EPS < abs(x))
                    ? ((-exp2(-x) + 1.0) / x)
                    : mad(-x, LN2_SQ_OVER_2, LN2);
            }

            struct Attributes {
                uint vertexID : SV_VertexID;
            };

            struct Varyings {
                float4 positionCS : SV_Position;
                float2 uv         : TEXCOORD0;
            };

            // 1:1 vertex — fullscreen triangle. Source vert_main (bakefoglut.shader lines 69-80) builds it from
            // the vertex id via spvBitfieldInsert: _34 = bit0 of (vid-base) (a single bit, in {0,1}),
            // _35 = (vid-base) & 2 (in {0,2}); then gl_Position.xy = mad(_34/_35, 2, -1), z = 1, w = 1,
            // TEXCOORD = (_34, 1 - _35). Re-authored verbatim (NOT via GetFullScreenTriangle*, whose x uses
            // the oversized (vid<<1)&2 encoding and whose uv.y flip is gated on UNITY_UV_STARTS_AT_TOP) so the
            // clip<->uv orientation is the source's `1 - b1` flip on EVERY platform, not just the DXC bake target.
            Varyings vert(Attributes input) {
                Varyings output;
                float bitX = float(input.vertexID & 1u);        // _34 : bit0 in {0,1}
                float bitY = float(input.vertexID & 2u);        // _35 : (vid & 2) in {0,2}
                output.positionCS = float4(mad(bitX, 2.0, -1.0), mad(bitY, 2.0, -1.0), 1.0, 1.0); // source z=1,w=1
                output.uv = float2(bitX, (-bitY) + 1.0);        // TEXCOORD = (b0, 1 - b1)
                return output;
            }

            // 1:1 fragment — dual-mode fog-LUT bake. Source frag_main (bakefoglut.shader lines 134-154).
            // `_307 = uint(gl_FragCoord.x) != 0u` selects column-0 (directional scattering colors) vs
            // every-other-column (per-distance fog integration).
            float4 frag(Varyings input) : SV_Target {
                float2 uv = input.uv;
                float camPosY = _WorldSpaceCameraPos.y; // source _WorldSpaceCameraPos_Internal.y

                // ----- directional terms (column 0 payload) -----
                // _36: view zenith cosine remapped [0,1] -> [-1,1] (source line 136).
                float cosZenith = mad(uv.y, 2.0, -1.0);
                // _46: Rayleigh phase (1 + cos^2) * 3/(16*pi) (source line 137).
                float rayleighPhase = mad(cosZenith, cosZenith, 1.0) * RAYLEIGH_PHASE_NORM;
                // _65: Henyey-Greenstein denom base (1 + g^2 - 2*g*cos), g = AtmoFog2.w.
                //   dot(_36.xx, g.xx) = 2*g*cos (source line 138).
                float g = _AtmosphereFogParams2.w;
                float hgDenomBase = -dot(cosZenith.xx, g.xx) + mad(g, g, 1.0);
                // _80: Henyey-Greenstein phase (1 - g^2) / max(sqrt(base)*(base*4*pi), 0.001) (source line 139).
                float hgPhase = mad(-g, g, 1.0) / max(sqrt(hgDenomBase) * (hgDenomBase * FOUR_PI), 0.001000000047497451305389404296875);

                // ----- depth slice + ray geometry -----
                // _164: exponential-depth slice decode. inner rescaled slice coord uv.x*rs.z + rs.w;
                //   dist = enc.w/(1 - slice*enc.z) - enc.w (source line 140).
                float sliceCoord = mad(uv.x, _FogBakeLutRescaleParams.z, _FogBakeLutRescaleParams.w);
                float sampleDist = (_FogBakeLutEncodeParams.w / mad(-sliceCoord, _FogBakeLutEncodeParams.z, 1.0)) + (-_FogBakeLutEncodeParams.w);
                // _174: per-row vertical ray factor yaw.x*uv.y + yaw.y (source line 141).
                float yawFactor = mad(_FogBakeLutYawParams.x, uv.y, _FogBakeLutYawParams.y);
                // _175: horizontal*vertical product (source line 142).
                float horizVertDist = sampleDist * yawFactor;
                // _179: world height at the sample = yaw*dist + camY (source line 143).
                float sampleHeight = mad(yawFactor, sampleDist, camPosY);
                // _188 / _189: clamped layer falloff exponents (source lines 144-145).
                float layer0Exp = max(horizVertDist * _ExponentialFogParams0.z, EXP2_FLOOR);
                float layer1Exp = max(horizVertDist * _ExponentialFogParams3.x, EXP2_FLOOR);

                // ----- two-layer exponential height-fog optical depth -> transmittance (alpha payload) -----
                // _230 (source line 146). layerN density at camera = exp2(-max((camY - heightN)*falloffN, -127)) * densityN.
                //   optical depth = layer0Density*EFP0.y*F2(_188) + layer1Density*EFP3.y*F2(_189);  F2 = TransmittanceIntegralFactor.
                //   _230 = max(min(exp2(-dist*opticalDepth), 1), EFP2.w).
                float layer0DensityCam = exp2(-max((camPosY + (-_ExponentialFogParams0.x)) * _ExponentialFogParams0.z, EXP2_FLOOR)) * _ExponentialFogParams0.y;
                float layer1DensityCam = exp2(-max((camPosY + (-_ExponentialFogParams3.z)) * _ExponentialFogParams3.x, EXP2_FLOOR)) * _ExponentialFogParams3.y;
                float opticalDepth = mad(layer0DensityCam, TransmittanceIntegralFactor(layer0Exp),
                                         layer1DensityCam * TransmittanceIntegralFactor(layer1Exp));
                float heightFogTransmittance = max(min(exp2(-(sampleDist * opticalDepth)), 1.0), _ExponentialFogParams2.w);

                // ----- atmospheric in-scatter (column !=0 RGB payload) -----
                // _271: max(mad(height, AFP3.w, AFP4.w), 0.01) (source line 147).
                float atmoDenom = max(mad(sampleHeight, _AtmosphereFogParams3.w, _AtmosphereFogParams4.w), 0.00999999977648258209228515625);
                // _282 (source line 148): exp2(mad(height,AFP3.w,AFP5.w)*log2e) * ((1 - exp2(atmoDenom*-log2e)) / atmoDenom)
                //   * (-max(mad(dist, AFP1.w, -AFP0.w), 0)).
                float inscatter = (exp2(mad(sampleHeight, _AtmosphereFogParams3.w, _AtmosphereFogParams5.w) * LOG2_E)
                                   * ((-exp2(atmoDenom * (-LOG2_E)) + 1.0) / atmoDenom))
                                  * (-max(mad(sampleDist, _AtmosphereFogParams1.w, -_AtmosphereFogParams0.w), 0.0));

                // ----- column select (source line 149) -----
                bool isInscatterColumn = uint(input.positionCS.x) != 0u; // _307

                float4 result;
                // RGB: source lines 150-152. inscatter column = 1 - exp2(inscatter * AtmoFog2.rgb * log2e);
                //   column 0 = clamp(AFP4.rgb*hgPhase + AFP3.rgb*rayleighPhase + AFP5.rgb, 0, 1) * 255.
                result.x = isInscatterColumn
                    ? (-exp2((inscatter * _AtmosphereFogParams2.x) * LOG2_E) + 1.0)
                    : (clamp(mad(_AtmosphereFogParams4.x, hgPhase, mad(_AtmosphereFogParams3.x, rayleighPhase, _AtmosphereFogParams5.x)), 0.0, 1.0) * 255.0);
                result.y = isInscatterColumn
                    ? (-exp2((inscatter * _AtmosphereFogParams2.y) * LOG2_E) + 1.0)
                    : (clamp(mad(_AtmosphereFogParams4.y, hgPhase, mad(_AtmosphereFogParams3.y, rayleighPhase, _AtmosphereFogParams5.y)), 0.0, 1.0) * 255.0);
                result.z = isInscatterColumn
                    ? (-exp2((inscatter * _AtmosphereFogParams2.z) * LOG2_E) + 1.0)
                    : (clamp(mad(_AtmosphereFogParams4.z, hgPhase, mad(_AtmosphereFogParams3.z, rayleighPhase, _AtmosphereFogParams5.z)), 0.0, 1.0) * 255.0);
                // A: source line 153. inscatter column = 1 - min(clamp(dist*EFP1.y + EFP1.x, 0,1) + heightFog, 1);
                //   column 0 = asfloat(0u) = 0.
                result.w = isInscatterColumn
                    ? (-min(clamp(mad(sampleDist, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0) + heightFogTransmittance, 1.0) + 1.0)
                    : 0.0;
                return result;
            }
            ENDHLSL
        }
    }
}
