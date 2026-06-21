// HGRP sky-atmosphere precomputed LUT chain (Hillaire/UE SkyAtmosphere) — 3 fullscreen passes.
//   Pass 0 "RenderTransmittanceLut": single-scattering optical-depth -> transmittance T(r,mu).
//   Pass 1 "RenderMultiScatteredLuminanceLut": isotropic multi-scatter LUT (2-bounce or 8-dir HQ).
//   Pass 2 "RenderSkyViewLut": camera-anchored sky-view radiance (single + multi scatter).
// Merged from: Hidden/RenderAtmosphereLut (HGRenderPipeline) — all base (#else) variants + the
//   HIGHQUALITY_MULTISCATTERING_APPROX_ENABLED delta of Pass 1.
// Keywords: HIGHQUALITY_MULTISCATTERING_APPROX_ENABLED (Pass 1 only)
// Kept (1:1 math): ray/sphere atmosphere intersection, Rayleigh+Mie+Ozone (absorption) extinction,
//   per-step transmittance integral, 2nd-order multiscatter approx + 8-direction HQ sphere-integral,
//   Rayleigh phase 3/(16π)(1+cos²θ) and Cornette-Shanks Mie phase, transmittance-LUT lookups,
//   ground intersection shadowing, Chapman-style sun-light visibility, ACES-ish luminance shaping tail.
// Removed: SPIRV-Cross plumbing (spvBitfieldInsert / gl_VertexIndex / SPIRV_Cross_Input-Output),
//   the `register(bN,space0)` / `packoffset` cbuffer layout, denormalized-float bit-pattern literals
//   (decoded to asfloat(uint)/value), HLSLSupport.cginc, use_dxc — replaced by URP Core infra +
//   CBUFFER_START(UnityPerMaterial). No PBR surface/lighting (this is procedural, NOT a lit shader).
//
// NOTE: AtmosphereLutParams0..9 are HGRP per-frame constants (cbuffer type_AtmosphereLutConstants).
//   URP has no equivalent global, so they are re-exposed as material Vector uniforms (the driving
//   C# atmosphere system writes them per draw). Decoded swizzle semantics (from the blob math):
//     P0 = (topRadius, bottomRadius, atmosphereThickness=top-bottom, viewHeight/cosLatScale)
//     P1 = (rayleighScatterScale.rgb? , skyViewLuminanceScale.w) ; multiscatter writes use P1.w
//     P2 = (mieScatter.rgb, mieDensityExpScale.w)        ; P3 = (rayleighScatter.rgb, miePhaseG.w)
//     P4 = (rayleighDensity?.rgb=extinction add, rayleighDensityExpScale.w)
//     P5 = (ozoneAbsorption.rgb, ozoneLayerTop.w)        ; P6 = ozone linear-term (a0,a1,b0,b1)
//     P7 = (sunIlluminance.rgb, globalLuminanceScale.w)  ; P8 = (sunDir.xyz, sampleCountMax.w)
//     P9 = (transmittanceSampleCount.x, multiSampleClamp.y, skyViewSampleMax.z, sampleMinClamp.w)
//   These groupings are inferred from usage; the MATH is verbatim 1:1 from the blobs regardless of name.

Shader "HGRP/RenderAtmosphereLut_Fix" {
    Properties {
        [HideInInspector] _AtmosphereLutParams0 ("Params0 (topR, botR, thickness, viewScale)", Vector) = (6420, 6360, 60, 1)
        [HideInInspector] _AtmosphereLutParams1 ("Params1 (.w=skyViewLumScale)", Vector) = (1, 1, 1, 1)
        [HideInInspector] _AtmosphereLutParams2 ("Params2 (mieScatter.rgb, mieExpScale.w)", Vector) = (0.004, 0.004, 0.004, -0.833)
        [HideInInspector] _AtmosphereLutParams3 ("Params3 (rayleighScatter.rgb, miePhaseG.w)", Vector) = (0.0058, 0.0135, 0.0331, 0.8)
        [HideInInspector] _AtmosphereLutParams4 ("Params4 (rayleighExt.rgb, rayleighExpScale.w)", Vector) = (0.0058, 0.0135, 0.0331, -0.125)
        [HideInInspector] _AtmosphereLutParams5 ("Params5 (ozoneAbs.rgb, ozoneTopH.w)", Vector) = (0.00065, 0.00188, 0.00009, 35)
        [HideInInspector] _AtmosphereLutParams6 ("Params6 (ozone a0,a1,b0,b1)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _AtmosphereLutParams7 ("Params7 (sunIlluminance.rgb, lumScale.w)", Vector) = (1, 1, 1, 1)
        [HideInInspector] _AtmosphereLutParams8 ("Params8 (sunDir.xyz, sampleCountMax.w)", Vector) = (0, 1, 0, 64)
        [HideInInspector] _AtmosphereLutParams9 ("Params9 (transSamp.x, msClamp.y, svSampMax.z, sampMin.w)", Vector) = (40, 1, 256, 1)
        [HideInInspector] _TransmittanceLut ("Transmittance LUT", 2D) = "white" {}
        [HideInInspector] _MultiScatterLut ("MultiScatter LUT", 2D) = "black" {}
    }

    SubShader {
        Tags {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Opaque"
        }
        LOD 100

        // Shared infra for all three passes.
        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

        CBUFFER_START(UnityPerMaterial)
            float4 _AtmosphereLutParams0;
            float4 _AtmosphereLutParams1;
            float4 _AtmosphereLutParams2;
            float4 _AtmosphereLutParams3;
            float4 _AtmosphereLutParams4;
            float4 _AtmosphereLutParams5;
            float4 _AtmosphereLutParams6;
            float4 _AtmosphereLutParams7;
            float4 _AtmosphereLutParams8;
            float4 _AtmosphereLutParams9;
        CBUFFER_END

        // Transmittance LUT (Pass 0 output), sampled by Pass 1 & 2 as T0.
        TEXTURE2D(_TransmittanceLut);   SAMPLER(sampler_LinearClamp);
        // Multi-scatter LUT (Pass 1 output), sampled by Pass 2 as T1.
        TEXTURE2D(_MultiScatterLut);

        // --- Decoded magic constants (blob denormalized-float bit patterns -> values) ---
        static const float LOG2_E       = 1.44269502162933349609375;  // log2(e); exp2(x*LOG2_E)=exp(x)
        static const float STEP_RATIO   = 0.300000011920928955078125; // 0.3  (rayLen->step, == 0.3/sampleCount form)
        static const float INV_FOUR_PI  = 0.079577468335628509521484375; // 1/(4π)  isotropic phase
        static const float INV_PI       = 0.3183098733425140380859375;   // 1/π
        static const float RAYLEIGH_K   = 0.0596831031143665313720703125; // 3/(16π)
        static const float FOUR_PI      = 12.56637096405029296875;        // 4π
        static const float COS_PI_8     = 0.92387950420379638671875;      // cos(π/8) sphere-sample tilt

        // Fullscreen-triangle vertex shared by every pass (blob Sub0_Pass1_Vertex_b4.hlsl:56-67;
        // identical inline vert in skeleton lines 70-81 / 282-293). 1:1.
        struct AttributesFS
        {
            uint vertexID : SV_VertexID;
        };

        struct VaryingsFS
        {
            float2 uv         : TEXCOORD0;
            float4 positionCS : SV_POSITION;
        };

        VaryingsFS VertFullscreen(AttributesFS input)
        {
            VaryingsFS output;
            // _34 = spvBitfieldInsert(0,vid,1,1) = (vid<<1)&2 = 2*bit0(vid)  -> {0,2} (NOT {0,1}).
            //   The Offset=1 in the bitfield-insert shifts bit0 to value 2; this is the oversized
            //   fullscreen triangle (clip X spans {-1,3}, uv.x spans {0,2}). blob:58-60
            float x = float((input.vertexID & 1u) << 1u);  // {0,2}
            float y = float(input.vertexID & 2u);          // {0,2}
            output.positionCS.x = mad(x, 2.0, -1.0);      // blob:61  -> {-1,3}
            output.positionCS.y = mad(y, 2.0, -1.0);      // blob:62  -> {-1,3}
            output.positionCS.z = 1.0;                    // blob:65
            output.positionCS.w = 1.0;                    // blob:66
            output.uv.x = x;                              // blob:63  -> {0,2}
            output.uv.y = (-y) + 1.0;                     // blob:64  ((-0.0f)-_35)+1.0f
            return output;
        }
        ENDHLSL

        // =========================================================================================
        // Pass 0 — RenderTransmittanceLut
        //   Ground truth: skeleton Fragment Blob 2 (renderatmospherelut.shader:128-159).
        // =========================================================================================
        Pass {
            Name "RenderTransmittanceLut"
            ZClip On
            ZTest Always
            ZWrite Off
            Cull Off

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex VertFullscreen
            #pragma fragment FragTransmittance

            float3 FragTransmittance(VaryingsFS input) : SV_Target
            {
                float2 uv = input.uv;

                // Map UV -> (radius r, view cos mu) for the transmittance parameterization. blob:130-138
                float _30 = uv.y * _AtmosphereLutParams0.z;                                              // :130
                float _43 = mad(_30, _30, _AtmosphereLutParams0.y * _AtmosphereLutParams0.y);            // :131
                float _44 = sqrt(_43);                                                                   // :132  rho? horizon dist
                float _50 = (-_44) + _AtmosphereLutParams0.x;                                            // :133
                float _64 = mad(uv.x,
                                (-_50) + mad(_AtmosphereLutParams0.z, uv.y, _AtmosphereLutParams0.z),
                                _50);                                                                    // :134  ray length d
                float _65 = _44 + _44;                                                                   // :135

                // mu = cos(view zenith) reconstructed from d, clamped [-1,1]; identity when d==0. blob:136
                float _88 = (_64 == 0.0)
                    ? 1.0
                    : clamp(mad(-_64, _64,
                                mad(_AtmosphereLutParams0.z, _AtmosphereLutParams0.z, -(_30 * _30)))
                            / (_64 * _65), -1.0, 1.0);

                // _95 = ray march length to atmosphere top / ground. blob:137
                float _95 = max(mad(-_44, _88,
                                    sqrt(max(mad(_43, mad(_88, _88, -1.0),
                                                 _AtmosphereLutParams0.x * _AtmosphereLutParams0.x), 0.0))),
                                0.0);
                float _101 = _95 / max(1.0, _AtmosphereLutParams8.w);   // step length = len / sampleCountMax. blob:138
                float _102 = _101 * STEP_RATIO;                          // first sample offset (0.3 t). blob:139

                // Optical-depth accumulators (R,G,B in _111,_107,_109 per the output swizzle). blob:140-145
                float _107 = 0.0;
                float _109 = 0.0;
                float _111 = 0.0;

                // Ray march: accumulate extinction*step. blob:153 (the giant for-update list)
                [loop]
                for (float _113 = _102; !(_113 >= _95); _113 = _101 + _113)
                {
                    // height above ground at this sample
                    float _136 = max(sqrt(mad(_113, mad(_65, _88, _113), _43)) + (-_AtmosphereLutParams0.y), 0.0);
                    // density profiles (exp2(h*scale*log2e) == exp(h*scale))
                    float _144 = exp2((_136 * _AtmosphereLutParams4.w) * LOG2_E);   // Rayleigh density
                    float _150 = exp2((_136 * _AtmosphereLutParams2.w) * LOG2_E);   // Mie density
                    // extinction = mie.x*mieDens + rayleighExt.x*rayDens(P2.x) + rayDens*P3.x ... per channel
                    float _173 = mad(_AtmosphereLutParams4.x, _144, mad(_AtmosphereLutParams2.x, _150, _144 * _AtmosphereLutParams3.x)); // X
                    float _174 = mad(_AtmosphereLutParams4.y, _144, mad(_AtmosphereLutParams2.y, _150, _144 * _AtmosphereLutParams3.y)); // Y
                    float _175 = mad(_AtmosphereLutParams4.z, _144, mad(_AtmosphereLutParams2.z, _150, _144 * _AtmosphereLutParams3.z)); // Z
                    // ozone absorption: piecewise-linear in height, clamped [0,1]
                    float _197 = (_136 < _AtmosphereLutParams5.w)
                        ? clamp(mad(_AtmosphereLutParams6.x, _136, _AtmosphereLutParams6.z), 0.0, 1.0)
                        : clamp(mad(_AtmosphereLutParams6.y, _136, _AtmosphereLutParams6.w), 0.0, 1.0);
                    // accumulate (extinction + ozone*absorptionColor) * step
                    _107 = mad(mad(_AtmosphereLutParams5.y, _197, _174), _101, _107);
                    _109 = mad(mad(_AtmosphereLutParams5.z, _197, _175), _101, _109);
                    _111 = mad(mad(_AtmosphereLutParams5.x, _197, _173), _101, _111);
                }

                // transmittance = exp(-opticalDepth). blob:156-158
                float3 col;
                col.x = exp2(_111 * (-LOG2_E));
                col.y = exp2(_107 * (-LOG2_E));
                col.z = exp2(_109 * (-LOG2_E));
                return col;
            }
            ENDHLSL
        }

        // =========================================================================================
        // Pass 1 — RenderMultiScatteredLuminanceLut
        //   Base (#else): blob renderatmospherelut/Sub0_Pass1_Fragment_b5.hlsl  (2-direction up/down)
        //   HQ (HIGHQUALITY_MULTISCATTERING_APPROX_ENABLED): Sub0_Pass1_Fragment_b7.hlsl (8-dir sphere)
        // =========================================================================================
        Pass {
            Name "RenderMultiScatteredLuminanceLut"
            ZClip On
            ZTest Always
            ZWrite Off
            Cull Off

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex VertFullscreen
            #pragma fragment FragMultiScatter
            #pragma shader_feature_local _ HIGHQUALITY_MULTISCATTERING_APPROX_ENABLED

            // T0 = transmittance LUT.
            #define T0 _TransmittanceLut

            float3 FragMultiScatter(VaryingsFS input) : SV_Target
            {
                float2 uv = input.uv;

            #if defined(HIGHQUALITY_MULTISCATTERING_APPROX_ENABLED)
                // ---- HQ 8-direction uniform-sphere multiscatter (blob _b7.hlsl:40-166) ----
                float _48 = mad(uv.y, (-_AtmosphereLutParams0.y) + _AtmosphereLutParams0.x, _AtmosphereLutParams0.y); // r. :42
                float _51 = mad(uv.x, 2.0, -1.0);                                  // sun cos. :43
                float _57 = sqrt(mad(-_51, _51, 1.0));                             // sun sin. :44
                float _66 = _AtmosphereLutParams0.x * _AtmosphereLutParams0.x;     // topR². :45
                float _67 = _AtmosphereLutParams0.y * _AtmosphereLutParams0.y;     // botR². :46
                float _72 = max(1.0, _AtmosphereLutParams9.x);                     // sample count. :47
                float _73 = _48 + _48;                                             // :48
                float _74 = _51 * _48;                                             // :49
                float _75 = _48 * _48;                                             // r². :50
                float _78 = mad(uv.x, 2.0, -1.0);                                  // :51 (== _51)

                // outer accumulators: _88/_90/_92 = luminance L, _94/_96/_98 = fms (multiscatter factor). :52-64
                float _88 = 0.0, _90 = 0.0, _92 = 0.0;
                float _94 = 0.0, _96 = 0.0, _98 = 0.0;

                [loop]
                for (float _86 = 0.0; !(_86 >= 8.0); _86 += 1.0)
                {
                    // direction sample over 8-entry sphere (cos in [-1,1]). :75-78
                    float _141 = mad(_86 + 0.5, 0.25, -1.0);                       // cosTheta_dir
                    float _148 = dot(float2(sqrt(mad(-_141, _141, 1.0)) * COS_PI_8, _141), float2(_57, _78)); // dir·sun
                    float _151 = mad(_141, _141, -1.0);
                    float _152 = mad(_75, _151, _67);
                    uint  _167 = ((_152 >= 0.0) ? 0xffffffffu : 0u) & ((_141 < 0.0) ? 0xffffffffu : 0u);
                    float _170 = max(mad(-_48, _141, -sqrt(max(_152, 0.0))), 0.0); // ground-hit length
                    float _176 = (_167 != 0u)
                        ? _170
                        : max(mad(-_48, _141, sqrt(max(mad(_75, _151, _66), 0.0))), 0.0); // top-hit length
                    float _177 = _176 / _72;                                       // step. :82
                    float _178 = _177 * STEP_RATIO;                                // start offset. :83

                    // inner per-direction transmittance integral accumulators. :84-98
                    float _190 = 0.0, _192 = 0.0, _194 = 0.0; // fms (L2 second order)
                    float _196 = 0.0, _198 = 0.0, _200 = 0.0; // L (single-scatter into this dir)
                    float _202 = 1.0, _204 = 1.0, _206 = 1.0; // running transmittance

                    [loop]
                    for (float _208 = _178; !(_208 >= _176); _208 = _177 + _208)
                    {
                        float _217 = sqrt(mad(_208, mad(_73, _141, _208), _75));   // sample radius
                        float _221 = min(max(mad(_208, _148, _74) / _217, -1.0), 1.0); // sun cos at sample
                        float _227 = max(_217 + (-_AtmosphereLutParams0.y), 0.0);  // height
                        float _235 = exp2((_227 * _AtmosphereLutParams4.w) * LOG2_E); // Rayleigh density
                        float _241 = exp2((_227 * _AtmosphereLutParams2.w) * LOG2_E); // Mie density
                        // scattering coeff S = mie*mieDens + rayScatter*rayDens (per channel)
                        float _256 = mad(_AtmosphereLutParams2.x, _241, _235 * _AtmosphereLutParams3.x);
                        float _257 = mad(_AtmosphereLutParams2.y, _241, _235 * _AtmosphereLutParams3.y);
                        float _258 = mad(_AtmosphereLutParams2.z, _241, _235 * _AtmosphereLutParams3.z);
                        // ozone
                        float _288 = (_227 < _AtmosphereLutParams5.w)
                            ? clamp(mad(_AtmosphereLutParams6.x, _227, _AtmosphereLutParams6.z), 0.0, 1.0)
                            : clamp(mad(_AtmosphereLutParams6.y, _227, _AtmosphereLutParams6.w), 0.0, 1.0);
                        // extinction E = S + rayExt + ozone*ozoneAbs
                        float _294 = mad(_AtmosphereLutParams5.x, _288, mad(_AtmosphereLutParams4.x, _235, _256));
                        float _295 = mad(_AtmosphereLutParams5.y, _288, mad(_AtmosphereLutParams4.y, _235, _257));
                        float _296 = mad(_AtmosphereLutParams5.z, _288, mad(_AtmosphereLutParams4.z, _235, _258));
                        // segment transmittance = exp(-E*step)
                        float _306 = exp2((_177 * (-_294)) * LOG2_E);
                        float _307 = exp2((_177 * (-_295)) * LOG2_E);
                        float _308 = exp2((_177 * (-_296)) * LOG2_E);
                        // transmittance-LUT lookup toward sun (with ground occlusion test)
                        float _309 = _217 * _217;
                        float _313 = sqrt(max(mad(_217, _217, -_67), 0.0));
                        float _314 = mad(_221, _221, -1.0);
                        float _319 = (-_217) + _AtmosphereLutParams0.x;
                        float2 _343 = float2(
                            ((-_319) + max(mad(-_217, _221, sqrt(max(mad(_309, _314, _66), 0.0))), 0.0))
                                / ((-_319) + (_313 + _AtmosphereLutParams0.z)),
                            _313 / _AtmosphereLutParams0.z);
                        float4 _342 = SAMPLE_TEXTURE2D_LOD(T0, sampler_LinearClamp, _343, 0.0);
                        // shadow: 0 if ray hits ground, else 1
                        float _354 = ((((_221 < 0.0) ? 0xffffffffu : 0u)
                                       & ((mad(_309, _314, _67) >= 0.0) ? 0xffffffffu : 0u)) != 0u) ? 0.0 : 1.0;
                        // in-scattered single-scatter (isotropic 1/4π) * sun transmittance
                        float _361 = (_256 * (_354 * _342.x)) * INV_FOUR_PI;
                        float _363 = (_257 * (_354 * _342.y)) * INV_FOUR_PI;
                        float _364 = (_258 * (_354 * _342.z)) * INV_FOUR_PI;
                        // integrate L += T * (S_int - S_int*segT)/E  (analytic step integral)
                        _196 = mad(_202, mad(-_361, _306, _361) / _294, _196);
                        _198 = mad(_204, mad(-_363, _307, _363) / _295, _198);
                        _200 = mad(_206, mad(-_364, _308, _364) / _296, _200);
                        // fms += T * S * step  (for 2nd-order multiscatter)
                        _190 = mad(_202 * _256, _177, _190);
                        _192 = mad(_204 * _257, _177, _192);
                        _194 = mad(_206 * _258, _177, _194);
                        // advance transmittance
                        _202 *= _306;
                        _204 *= _307;
                        _206 *= _308;
                    }

                    // ground-bounce contribution if this ray hit the planet. :136-153
                    float _440, _441, _442;
                    if ((((_170 == _176) ? 0xffffffffu : 0u) & _167) != 0u)
                    {
                        float _379 = sqrt(mad(_176, mad(_73, _141, _176), _75));
                        float _383 = min(max(mad(_176, _148, _74) / _379, -1.0), 1.0);
                        float _392 = (-_379) + _AtmosphereLutParams0.x;
                        float _393 = max(_383, 0.0);
                        float _401 = sqrt(max(mad(_379, _379, -_67), 0.0));
                        float4 _419 = SAMPLE_TEXTURE2D_LOD(T0, sampler_LinearClamp, float2(
                            ((-_392) + max(mad(-_379, _383, sqrt(max(mad(_379 * _379, mad(_383, _383, -1.0), _66), 0.0))), 0.0))
                                / ((-_392) + (_401 + _AtmosphereLutParams0.z)),
                            _401 / _AtmosphereLutParams0.z), 0.0);
                        _440 = mad((_419.x * (_393 * _202)) * _AtmosphereLutParams7.x, INV_PI, _196);
                        _441 = mad((_419.y * (_393 * _204)) * _AtmosphereLutParams7.y, INV_PI, _198);
                        _442 = mad((_419.z * (_393 * _206)) * _AtmosphereLutParams7.z, INV_PI, _200);
                    }
                    else
                    {
                        _440 = _196;
                        _441 = _198;
                        _442 = _200;
                    }
                    // accumulate over 8 directions: L (_92/_90/_88) and fms (_94/_96/_98). :72,154-156
                    _88 += _442;
                    _90 += _441;
                    _92 += _440;
                    _94 += _194;
                    _96 += _192;
                    _98 += _190;
                }

                // average over 8 dirs (×0.125), close the infinite multiscatter series
                // L_total = L * (1 + fms + fms² + ...) ≈ L * Σ via the polynomial fit. :158-166
                float _103 = _98 * 0.125;
                float _105 = _96 * 0.125;
                float _106 = _94 * 0.125;
                float _107 = _103 * _103;
                float _108 = _105 * _105;
                float _109 = _106 * _106;
                float3 col;
                col.x = mad(_107, _107, mad(_107, _103, mad(_103, _103, _103) + 1.0)) * ((_92 * _AtmosphereLutParams1.w) * 0.125);
                col.y = mad(_108, _108, mad(_108, _105, mad(_105, _105, _105) + 1.0)) * ((_90 * _AtmosphereLutParams1.w) * 0.125);
                col.z = mad(_109, _109, mad(_109, _106, mad(_106, _106, _106) + 1.0)) * ((_88 * _AtmosphereLutParams1.w) * 0.125);
                return col;
            #else
                // ---- Base 2-direction (up & down) multiscatter (blob _b5.hlsl:40-176) ----
                float _48 = mad(uv.y, (-_AtmosphereLutParams0.y) + _AtmosphereLutParams0.x, _AtmosphereLutParams0.y); // r. :42
                float _51 = mad(uv.x, 2.0, -1.0);                                  // sun cos*. :43
                float _54 = _48 * _48;                                             // r². :44
                float _61 = max((-_48) + abs(_AtmosphereLutParams0.x), 0.0);       // up-ray length. :45
                float _71 = _AtmosphereLutParams0.x * _AtmosphereLutParams0.x;     // topR². :46
                float _72 = _AtmosphereLutParams0.y * _AtmosphereLutParams0.y;     // botR². :47
                float _77 = max(1.0, _AtmosphereLutParams9.x);                     // sample count. :48
                float _79 = _61 / _77;                                             // up step. :49
                float _80 = _79 * STEP_RATIO;                                      // up start. :50

                // up-ray: L carry _96/_98/_100, fms _110/_92/_94, running T _102/_104/_106 (init 1). :51-65
                float _92 = 0.0, _94 = 0.0;            // fms (Y,Z)
                float _96 = 0.0, _98 = 0.0, _100 = 0.0; // L carry
                float _110 = 0.0;                       // fms (X)
                {
                    float _102 = 1.0, _104 = 1.0, _106 = 1.0; // running transmittance
                    [loop]
                    for (float _108 = _80; !(_108 >= _61); _108 = _79 + _108)
                    {
                        float _137 = mad(_48, 2.0, _108);
                        float _138 = mad(_108, _137, _54);
                        float _139 = sqrt(_138);                                       // radius
                        float _144 = min(max((_51 * (_48 + _108)) / _139, -1.0), 1.0); // sun cos. :102
                        float _150 = max(_139 + (-_AtmosphereLutParams0.y), 0.0);      // height
                        float _158 = exp2((_150 * _AtmosphereLutParams4.w) * LOG2_E);  // Rayleigh density
                        float _165 = exp2((_150 * _AtmosphereLutParams2.w) * LOG2_E);  // Mie density
                        // scatter S = mie*mieDens + rayScatter*rayDens
                        float _180 = mad(_AtmosphereLutParams2.x, _165, _158 * _AtmosphereLutParams3.x);
                        float _181 = mad(_AtmosphereLutParams2.y, _165, _158 * _AtmosphereLutParams3.y);
                        float _182 = mad(_AtmosphereLutParams2.z, _165, _158 * _AtmosphereLutParams3.z);
                        // ozone
                        float _212 = (_150 < _AtmosphereLutParams5.w)
                            ? clamp(mad(_AtmosphereLutParams6.x, _150, _AtmosphereLutParams6.z), 0.0, 1.0)
                            : clamp(mad(_AtmosphereLutParams6.y, _150, _AtmosphereLutParams6.w), 0.0, 1.0);
                        // extinction E
                        float _218 = mad(_AtmosphereLutParams5.x, _212, mad(_AtmosphereLutParams4.x, _158, _180));
                        float _219 = mad(_AtmosphereLutParams5.y, _212, mad(_AtmosphereLutParams4.y, _158, _181));
                        float _220 = mad(_AtmosphereLutParams5.z, _212, mad(_AtmosphereLutParams4.z, _158, _182));
                        // segment transmittance exp(-E*step)
                        float _230 = exp2((_79 * (-_218)) * LOG2_E);
                        float _231 = exp2((_79 * (-_219)) * LOG2_E);
                        float _232 = exp2((_79 * (-_220)) * LOG2_E);
                        // transmittance-LUT lookup toward sun + ground occlusion
                        float _233 = _139 * _139;
                        float _237 = sqrt(max(mad(_139, _139, -_72), 0.0));
                        float _238 = mad(_144, _144, -1.0);
                        float _243 = (-_139) + _AtmosphereLutParams0.x;
                        float4 _266 = SAMPLE_TEXTURE2D_LOD(T0, sampler_LinearClamp, float2(
                            ((-_243) + max(mad(-_139, _144, sqrt(max(mad(_233, _238, _71), 0.0))), 0.0))
                                / ((-_243) + (_237 + _AtmosphereLutParams0.z)),
                            _237 / _AtmosphereLutParams0.z), 0.0);
                        float _279 = ((((_144 < 0.0) ? 0xffffffffu : 0u)
                                       & ((mad(_233, _238, _72) >= 0.0) ? 0xffffffffu : 0u)) != 0u) ? 0.0 : 1.0;
                        // in-scatter (isotropic 1/4π)
                        float _286 = (_180 * (_279 * _266.x)) * INV_FOUR_PI;
                        float _288 = (_181 * (_279 * _266.y)) * INV_FOUR_PI;
                        float _289 = (_182 * (_279 * _266.z)) * INV_FOUR_PI;
                        float _290 = _102 * _180;
                        // L += T * (S - S*segT)/E  (uses T BEFORE advance, carry _96/_98/_100)
                        float _97 = mad(_102, mad(-_286, _230, _286) / _218, _96);
                        float _99 = mad(_104, mad(-_288, _231, _288) / _219, _98);
                        float _101 = mad(_106, mad(-_289, _232, _289) / _220, _100);
                        // fms += T*S*step
                        _92 = mad(_104 * _181, _79, _92);
                        _94 = mad(_106 * _182, _79, _94);
                        _110 = mad(_290, _79, _110);
                        _96 = _97; _98 = _99; _100 = _101;
                        // advance transmittance
                        _102 *= _230; _104 *= _231; _106 *= _232;
                    }
                }

                // down-ray setup. blob:105-109
                float _117 = mad(-uv.x, 2.0, 1.0);
                float _124 = max(_48 + (-abs(_AtmosphereLutParams0.y)), 0.0);       // down-ray length
                float _125 = _124 / _77;                                           // down step
                float _126 = _125 * STEP_RATIO;                                    // down start
                float _127 = _51 * _48;

                // down-ray: L carry _310/_312/_314, fms _302/_304/_306, running T _316/_318/_320 (init 1). :110-127
                float _302 = 0.0, _304 = 0.0, _306 = 0.0;   // fms
                float _310 = 0.0, _312 = 0.0, _314 = 0.0;   // L carry
                {
                    float _316 = 1.0, _318 = 1.0, _320 = 1.0; // running transmittance
                    [loop]
                    for (float _308 = _126; !(_308 >= _124); _308 = _125 + _308)
                    {
                        float _429 = sqrt(mad(_308, mad(_48, -2.0, _308), _54));    // radius. :158
                        float _433 = min(max(mad(_308, _117, _127) / _429, -1.0), 1.0); // sun cos
                        float _439 = max(_429 + (-_AtmosphereLutParams0.y), 0.0);   // height
                        float _445 = exp2((_439 * _AtmosphereLutParams4.w) * LOG2_E); // Rayleigh density
                        float _451 = exp2((_439 * _AtmosphereLutParams2.w) * LOG2_E); // Mie density
                        float _465 = mad(_AtmosphereLutParams2.x, _451, _445 * _AtmosphereLutParams3.x);
                        float _466 = mad(_AtmosphereLutParams2.y, _451, _445 * _AtmosphereLutParams3.y);
                        float _467 = mad(_AtmosphereLutParams2.z, _451, _445 * _AtmosphereLutParams3.z);
                        float _495 = (_439 < _AtmosphereLutParams5.w)
                            ? clamp(mad(_AtmosphereLutParams6.x, _439, _AtmosphereLutParams6.z), 0.0, 1.0)
                            : clamp(mad(_AtmosphereLutParams6.y, _439, _AtmosphereLutParams6.w), 0.0, 1.0);
                        float _501 = mad(_AtmosphereLutParams5.x, _495, mad(_AtmosphereLutParams4.x, _445, _465));
                        float _502 = mad(_AtmosphereLutParams5.y, _495, mad(_AtmosphereLutParams4.y, _445, _466));
                        float _503 = mad(_AtmosphereLutParams5.z, _495, mad(_AtmosphereLutParams4.z, _445, _467));
                        float _513 = exp2((_125 * (-_501)) * LOG2_E);
                        float _514 = exp2((_125 * (-_502)) * LOG2_E);
                        float _515 = exp2((_125 * (-_503)) * LOG2_E);
                        float _516 = _429 * _429;
                        float _520 = sqrt(max(mad(_429, _429, -_72), 0.0));
                        float _521 = mad(_433, _433, -1.0);
                        float _526 = (-_429) + _AtmosphereLutParams0.x;
                        float4 _548 = SAMPLE_TEXTURE2D_LOD(T0, sampler_LinearClamp, float2(
                            ((-_526) + max(mad(-_429, _433, sqrt(max(mad(_516, _521, _71), 0.0))), 0.0))
                                / ((-_526) + (_520 + _AtmosphereLutParams0.z)),
                            _520 / _AtmosphereLutParams0.z), 0.0);
                        float _560 = ((((_433 < 0.0) ? 0xffffffffu : 0u)
                                       & ((mad(_516, _521, _72) >= 0.0) ? 0xffffffffu : 0u)) != 0u) ? 0.0 : 1.0;
                        float _567 = (_465 * (_560 * _548.x)) * INV_FOUR_PI;
                        float _568 = (_466 * (_560 * _548.y)) * INV_FOUR_PI;
                        float _569 = (_467 * (_560 * _548.z)) * INV_FOUR_PI;
                        // L += T * (S - S*segT)/E  (carry _310/_312/_314)
                        float _311 = mad(_316, mad(-_567, _513, _567) / _501, _310);
                        float _313 = mad(_318, mad(-_568, _514, _568) / _502, _312);
                        float _315 = mad(_320, mad(-_569, _515, _569) / _503, _314);
                        // fms += T*S*step
                        _302 = mad(_316 * _465, _125, _302);
                        _304 = mad(_318 * _466, _125, _304);
                        _306 = mad(_320 * _467, _125, _306);
                        _310 = _311; _312 = _313; _314 = _315;
                        _316 *= _513; _318 *= _514; _320 *= _515;
                    }

                    // ground sample at end of down-ray. blob:161-166
                    float _326 = sqrt(mad(_124, mad(_48, -2.0, _124), _54));
                    float _330 = min(max(mad(_124, _117, _127) / _326, -1.0), 1.0);
                    float _340 = max(_330, 0.0);
                    float _348 = sqrt(max(mad(_326, _326, -_72), 0.0));
                    float _356 = -((-_326) + _AtmosphereLutParams0.x);
                    float4 _365 = SAMPLE_TEXTURE2D_LOD(T0, sampler_LinearClamp, float2(
                        (_356 + max(mad(-_326, _330, sqrt(max(mad(_326 * _326, mad(_330, _330, -1.0), _71), 0.0))), 0.0))
                            / (_356 + (_348 + _AtmosphereLutParams0.z)),
                        _348 / _AtmosphereLutParams0.z), 0.0);

                    // average up+down fms, ACES-ish polynomial tail, scale by skyView lum. blob:167-175
                    float _389 = (_110 + _302) * 0.5;
                    float _391 = (_92  + _304) * 0.5;
                    float _392 = (_94  + _306) * 0.5;
                    float _393 = _389 * _389;
                    float _394 = _391 * _391;
                    float _395 = _392 * _392;
                    float3 col;
                    col.x = (((mad((_365.x * (_340 * _316)) * _AtmosphereLutParams7.x, INV_PI, _310) + _96)  * _AtmosphereLutParams1.w) * 0.5)
                            * mad(_393, _393, mad(_393, _389, mad(_389, _389, _389) + 1.0));
                    col.y = (((mad((_365.y * (_340 * _318)) * _AtmosphereLutParams7.y, INV_PI, _312) + _98)  * _AtmosphereLutParams1.w) * 0.5)
                            * mad(_394, _394, mad(_394, _391, mad(_391, _391, _391) + 1.0));
                    col.z = (((mad((_365.z * (_340 * _320)) * _AtmosphereLutParams7.z, INV_PI, _314) + _100) * _AtmosphereLutParams1.w) * 0.5)
                            * mad(_395, _395, mad(_395, _392, mad(_392, _392, _392) + 1.0));
                    return col;
                }
            #endif
            }
            ENDHLSL
        }

        // =========================================================================================
        // Pass 2 — RenderSkyViewLut
        //   Ground truth: skeleton Fragment Blob 10 (renderatmospherelut.shader:344-457).
        //   T0 = transmittance LUT, T1 = multi-scatter LUT.
        // =========================================================================================
        Pass {
            Name "RenderSkyViewLut"
            ZClip On
            ZTest Always
            ZWrite Off
            Cull Off

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex VertFullscreen
            #pragma fragment FragSkyView

            #define T0 _TransmittanceLut
            #define T1 _MultiScatterLut

            float3 FragSkyView(VaryingsFS input) : SV_Target
            {
                float2 uv = input.uv;

                // Decode octahedral-ish sky-view direction from UV. blob:346-351
                float _39 = (uv.y + uv.x) + (-1.0);
                float _47 = (-uv.y) + uv.x;
                float _56 = (-dot(float2(abs(_39), abs(_47)), 1.0.xx)) + 1.0;
                float _60 = rsqrt(dot(float3(_39, _56, _47), float3(_39, _56, _47)));
                float _62 = _60 * _56;
                float _71 = dot(float3(_60 * _39, _62, _60 * _47),
                                float3(_AtmosphereLutParams8.x, _AtmosphereLutParams8.y, _AtmosphereLutParams8.z)); // cos(view,sun)

                float _84 = _AtmosphereLutParams0.w * _AtmosphereLutParams0.w;     // viewHeight². :352
                float _85 = _AtmosphereLutParams0.x * _AtmosphereLutParams0.x;     // topR². :353
                float _86 = _AtmosphereLutParams0.y * _AtmosphereLutParams0.y;     // botR². :354
                float _87 = mad(_62, _62, -1.0);                                   // :355
                float _88 = mad(_84, _87, _86);                                    // :356
                // ray length to ground or atmosphere top
                float _101 = max(mad(-_AtmosphereLutParams0.w, _62, -sqrt(max(_88, 0.0))), 0.0); // :357
                uint  _108 = ((_88 >= 0.0) ? 0xffffffffu : 0u) & ((_62 < 0.0) ? 0xffffffffu : 0u); // :358
                float _119 = (_108 != 0u)
                    ? _101
                    : max(mad(-_AtmosphereLutParams0.w, _62, sqrt(max(mad(_84, _87, _85), 0.0))), 0.0);   // :359
                float _130 = max(1.0, _AtmosphereLutParams9.y);                    // :360
                // adaptive sample count -> step length. :361
                float _138 = _119 / floor(mad(min(_119 / max(1.0, _AtmosphereLutParams9.w), 1.0),
                                               (-_130) + min(256.0, _AtmosphereLutParams9.z), _130));

                // phase functions. blob:362-364
                float _155 = (-dot(_71.xx, _AtmosphereLutParams3.w.xx)) + mad(_AtmosphereLutParams3.w, _AtmosphereLutParams3.w, 1.0);
                float _170 = mad(-_AtmosphereLutParams3.w, _AtmosphereLutParams3.w, 1.0)
                             / max(sqrt(_155) * (_155 * FOUR_PI), 0.001000000047497451305389404296875); // Cornette-Shanks Mie phase
                float _171 = mad(_71, _71, 1.0) * RAYLEIGH_K;                      // Rayleigh phase 3/(16π)(1+cos²)
                float _173 = _138 * STEP_RATIO;                                    // start offset. :365
                float _178 = dot(_62.xx, _AtmosphereLutParams0.w.xx);             // :366
                float _187 = _AtmosphereLutParams0.w * _AtmosphereLutParams8.y;   // :367
                float _195 = (-_AtmosphereLutParams0.y) + _AtmosphereLutParams0.x; // atmosphere thickness. :368

                // accumulators: _205/_207/_209 running transmittance (=1), _211/_213/_215 luminance L. :369-380
                float _205 = 1.0, _207 = 1.0, _209 = 1.0;
                float _211 = 0.0, _213 = 0.0, _215 = 0.0;
                float _212 = 0.0, _214 = 0.0, _216 = 0.0; // L next

                [loop]
                for (float _203 = _173; !(_203 >= _119); _203 = _138 + _203)
                {
                    float _224 = sqrt(mad(_203, _178 + _203, _84));               // radius
                    float _228 = min(max(mad(_203, _71, _187) / _224, -1.0), 1.0);// sun cos
                    float _233 = _224 + (-_AtmosphereLutParams0.y);
                    float _234 = max(_233, 0.0);                                  // height
                    float _242 = exp2((_234 * _AtmosphereLutParams4.w) * LOG2_E); // Rayleigh density
                    float _248 = _242 * _AtmosphereLutParams3.x;
                    float _249 = _242 * _AtmosphereLutParams3.y;
                    float _250 = _242 * _AtmosphereLutParams3.z;
                    float _257 = exp2((_234 * _AtmosphereLutParams2.w) * LOG2_E); // Mie density
                    // scatter S = mie*mieDens + rayScatter
                    float _271 = mad(_AtmosphereLutParams2.x, _257, _248);
                    float _272 = mad(_AtmosphereLutParams2.y, _257, _249);
                    float _273 = mad(_AtmosphereLutParams2.z, _257, _250);
                    // ozone
                    float _303 = (_234 < _AtmosphereLutParams5.w)
                        ? clamp(mad(_AtmosphereLutParams6.x, _234, _AtmosphereLutParams6.z), 0.0, 1.0)
                        : clamp(mad(_AtmosphereLutParams6.y, _234, _AtmosphereLutParams6.w), 0.0, 1.0);
                    // extinction E
                    float _309 = mad(_AtmosphereLutParams5.x, _303, mad(_AtmosphereLutParams4.x, _242, _271));
                    float _310 = mad(_AtmosphereLutParams5.y, _303, mad(_AtmosphereLutParams4.y, _242, _272));
                    float _311 = mad(_AtmosphereLutParams5.z, _303, mad(_AtmosphereLutParams4.z, _242, _273));
                    float _312 = -_309, _313 = -_310, _314 = -_311;
                    // segment transmittance
                    float _321 = exp2((_138 * _312) * LOG2_E);
                    float _322 = exp2((_138 * _313) * LOG2_E);
                    float _323 = exp2((_138 * _314) * LOG2_E);
                    // transmittance-LUT lookup toward sun + planet-shadow + ground intersect
                    float _324 = _224 * _224;
                    float _328 = sqrt(max(mad(_224, _224, -_86), 0.0));
                    float _329 = mad(_228, _228, -1.0);
                    float _334 = (-_224) + _AtmosphereLutParams0.x;
                    float _337 = max(mad(_324, _329, _85), 0.0);
                    float _350 = ((-_334) + max(mad(-_224, _228, sqrt(_337)), 0.0))
                                 / ((-_334) + (_328 + _AtmosphereLutParams0.z));
                    float4 _357 = SAMPLE_TEXTURE2D_LOD(T0, sampler_LinearClamp,
                                                       float2(_350, _328 / _AtmosphereLutParams0.z), 0.0);
                    bool  _364 = mad(_324, _329, _86) >= 0.0;
                    float _369 = ((((_228 < 0.0) ? 0xffffffffu : 0u) & (_364 ? 0xffffffffu : 0u)) != 0u) ? 0.0 : 1.0;
                    float _370 = _369 * _357.x;
                    float _371 = _369 * _357.y;
                    float _372 = _369 * _357.z;
                    // phase-weighted single scatter: S_mie*miePhase + S_ray*rayPhase
                    float _376 = mad(_257 * _AtmosphereLutParams2.x, _171, _170 * _248);
                    float _377 = mad(_257 * _AtmosphereLutParams2.y, _171, _170 * _249);
                    float _378 = mad(_257 * _AtmosphereLutParams2.z, _171, _170 * _250);
                    // multiscatter LUT lookup
                    float4 _383 = SAMPLE_TEXTURE2D_LOD(T1, sampler_LinearClamp,
                                                       float2(mad(_228, 0.5, 0.5), _233 / _195), 0.0);
                    // in-scatter = sunT*phaseScatter + multiscatter*scatter
                    float _391 = mad(_370, _376, _383.x * _271);
                    float _392 = mad(_371, _377, _383.y * _272);
                    float _393 = mad(_372, _378, _383.z * _273);
                    // analytic step integral: (S - S*segT)/E
                    float _397 = mad(-_391, _321, _391);
                    float _398 = mad(-_392, _322, _392);
                    float _399 = mad(-_393, _323, _393);
                    float _400 = _397 / _309;
                    float _401 = _398 / _310;
                    float _402 = _399 / _311;
                    // L += T * stepIntegral  (blob:431 SSA targets: _216<-X(_209/_400/_215), _212<-Z(_205/_402/_211))
                    _216 = mad(_209, _400, _215);
                    _214 = mad(_207, _401, _213);
                    _212 = mad(_205, _402, _211);
                    // advance transmittance & carry L. (blob:431 update list)
                    _205 *= _323;
                    _207 *= _322;
                    _209 *= _321;
                    _211 = _212;
                    _213 = _214;
                    _215 = _216;
                }

                // optional ground-bounce if the view ray hit the planet. blob:434-454
                float _465, _466, _467;
                if ((((_101 == _119) ? 0xffffffffu : 0u) & _108) != 0u)
                {
                    float _405 = sqrt(mad(_119, _178 + _119, _84));
                    float _409 = min(max(mad(_119, _71, _187) / _405, -1.0), 1.0);
                    float _419 = max(_409, 0.0);
                    float _427 = sqrt(max(mad(_405, _405, -_86), 0.0));
                    float _435 = -((-_405) + _AtmosphereLutParams0.x);
                    float4 _444 = SAMPLE_TEXTURE2D_LOD(T0, sampler_LinearClamp, float2(
                        (_435 + max(mad(-_405, _409, sqrt(max(mad(_405 * _405, mad(_409, _409, -1.0), _85), 0.0))), 0.0))
                            / (_435 + (_427 + _AtmosphereLutParams0.z)),
                        _427 / _AtmosphereLutParams0.z), 0.0);
                    _465 = mad((_444.z * (_419 * _205)) * _AtmosphereLutParams7.z, INV_PI, _211);
                    _466 = mad((_444.y * (_419 * _207)) * _AtmosphereLutParams7.y, INV_PI, _213);
                    _467 = mad((_444.x * (_419 * _209)) * _AtmosphereLutParams7.x, INV_PI, _215);
                }
                else
                {
                    _465 = _211;
                    _466 = _213;
                    _467 = _215;
                }

                // final: L * sunIlluminance * globalScale. blob:455-457
                float3 col;
                col.x = (_467 * _AtmosphereLutParams1.x) * _AtmosphereLutParams7.w;
                col.y = (_466 * _AtmosphereLutParams1.y) * _AtmosphereLutParams7.w;
                col.z = (_465 * _AtmosphereLutParams1.z) * _AtmosphereLutParams7.w;
                return col;
            }
            ENDHLSL
        }
    }
}
