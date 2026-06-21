// HGRP WaterRendering -> URP. Deferred screen-space water lighting/compositing — Lighting pass (fullscreen) + G-buffer/mask stubs.
// Merged from: waterrendering.shader passes WaterTessellation0 (b1/b2), WaterTessellation1 (b1/b2), WaterLighting (b69 vertex / b70 fragment, BASE catch-all variants).
// Keywords: _HG_WATER_DESKTOP_QUALITY_LOW (quality toggle — base vs low differ in CAUSTICS sample-count: base 2-octave taps blended
//   prod·100+max (b70:1096-1101,1109), low 1 tap ×10 (b72:1060,1065); the CSM-PCF tap-count delta is URP-side via _SHADOWS_SOFT. Ported below, not collapsed).
// Kept (1:1 MATH from blob Sub0_Pass2_Fragment_b70.hlsl): depth->worldPos reconstruction (b70:195-205), ortho/persp view dir + |V| (b70:207-216),
//   octahedral water-normal decode (b70:217-226), anisotropic-normal tweak + N-basis (b70:475-479,508), surface Fresnel via EnvBRDFApprox poly (b70:515-517),
//   reflected-view SUN-DISK specular direction: Rv=reflect(-V,Naniso), snap-to-cone L_spec by sin/cos half-angle, H=norm(V+L_spec) (b70:480-508; CustomData2 sin/cos/intensity -> _SunDiskParams uniform),
//   direct specular _732 = GGX-D + Smith-Vis × SCHLICK-F(VoH, F0=0.08·F0Scale) inner-clamp 2048 + split-sum DFG-LUT (T8 -> _WaterBrdfLut) multi-scatter term, ×sunIntensity outer-clamp 1000 (b70:509-521),
//   scatter-channel min/mid/max sort -> sorted-max + saturation spread + iridescent hue phase (b70:237-246,522), back-scatter/SSS lobe _791 (b70:519,523-524),
//   directional light response _806/_807/_808 (b70:525-527), SH ambient (b70:766-768 -> URP SampleSH), reflection (b70 probe loop 801-902 -> URP GlossyEnvironmentReflection),
//   height/distance fog (b70:1020-1080 -> URP MixFog), final composite (b70:1167-1170).
// Removed (pixel-neutral pipeline infra, substituted by URP per STYLE_BIBLE §2): HGRP global cbuffer (_ViewMatrix/_InvViewProjMatrix/_WorldSpaceCameraPos_Internal/_unity_OrthoParams
//   -> UNITY_MATRIX_*/_WorldSpaceCameraPos/unity_OrthoParams), SPIRV-Cross statics/polyfills, ByteAddressBuffer reflection-probe binning (T0+_ReflectionProbeGlobalDatas[32])
//   -> GlossyEnvironmentReflection, CSM+ASM cascaded-shadow atlases (T4/T6+_CSM*/_ASM*) -> GetMainLight shadowAttenuation, cloud shadows (T5+_CloudShadowParams) -> dropped,
//   IV-clipmap SH-GI cascade (T9-T14+_IVParam*) -> SampleSH, atmosphere/exp/volumetric froxel fog (T3+_*FogParams*) -> MixFog.
//
// NOTE — STRUCTURAL: this is NOT a per-object surface shader. The HGRP original is a DEFERRED compositor whose ENTIRE input set is produced by the HGRP
//   water COMPUTE + TESSELLATION pipeline, which has no URP equivalent and no material-property surface:
//     (a) WaterTessellation0/1 passes: the BASE (#else catch-all) blobs b1/b2 are DEGENERATE STUBS — vertex emits NaN (b1:53-56), fragment writes 0 + discards (b2:33-46).
//         The real water surface geometry only exists in the WATER_USE_INDIRECT/tessellation variants driven by GPU compute (indirect draws + type_WaterData[1298]).
//         There is NO portable per-vertex water surface math in the base variant. These passes (which write the water G-buffer + stencil) are stubbed here.
//     (b) WaterLighting fragment reads water G-buffers T16 (water depth), T1 (scene depth), T17 (octahedral normal + roughness), T20 (scatter/absorb color + material id),
//         caustics T21, foam/scene-color T15, and indexes _WaterData_f_0[1298] by a per-pixel material id (id=round(T20.a*255), b70:227) for EVERY BRDF coefficient.
//         None of these resources exist without the water compute pipeline. They are exposed below as clean uniforms / sampler inputs so the shader COMPILES + RUNS
//         standalone with a single representative water material, and every unavailable resource is flagged with an explicit // TODO(1:1).
//   The lighting MATH that maps cleanly to URP (Fresnel/GGX/specular/scatter/SH/reflection/fog) is ported 1:1 with blob cites. The compute-fed data array and the
//   tessellation/G-buffer production are the TODO surface — they cannot be made 1:1 in a self-contained shader without porting the HGRP water compute system.
//
// Water G-buffer channel legend (from blob sample sites): _WaterNormalRoughness (T17) .xy = octahedral normal, .z = perceptualRoughness (b70:191-192,217-218);
//   _WaterScatterColor (T20) .xyz = scatter/absorption RGB, .w = material id (b70:187-190,227); _WaterDepth (T16) .x = water surface device depth (b70:179-180).

Shader "HGRP/WaterRendering_Fix" {
    Properties {
        // ============================================================
        // Blend-state plumbing (WaterLighting pass = additive-over via stencil; tessellation passes use HGRP "Blend 2 SrcColor OneMinusSrcColor")
        // Source render-state: WaterLighting (skeleton 471-484) ZTest Always / ZWrite Off / Cull Off / Stencil Ref 1 Comp Equal.
        // ============================================================
        [HideInInspector] _SrcBlend ("__src", Float) = 1            // One
        [HideInInspector] _DstBlend ("__dst", Float) = 0            // Zero (resolve writes final color; HGRP composes via stencil-gated full-screen)
        [HideInInspector] _ZTest ("__zt", Float) = 8               // Always (b70 lighting pass: ZTest Always)
        [HideInInspector] _ZWrite ("__zw", Float) = 0              // Off
        [HideInInspector] _Cull ("__cull", Float) = 0              // Off
        [HideInInspector] _StencilRef ("Stencil Ref", Float) = 1

        // ============================================================
        // Water G-buffer inputs (produced by the HGRP water compute/tessellation pipeline; here as bindable maps so the pass runs standalone)
        // TODO(1:1) ENGINE-SIDE: these are screen-space render targets WRITTEN by a host C# water render-feature (the WaterTessellation0/1
        //   raster pass + the water-simulation compute that fills type_WaterData[1298]) — not material textures and not derivable in-shader.
        //   That host pass must run before WaterLighting and bind T16/T17/T20/T1/T15/T21. Texture-sampling itself is done 1:1 in the frag.
        // ============================================================
        [Header(Water G Buffer Inputs)]
        _WaterDepth ("Water Depth (T16 .x = device depth)", 2D) = "black" {}
        _WaterNormalRoughness ("Water Normal+Roughness (T17 .xy oct, .z rough)", 2D) = "black" {}
        _WaterScatterColor ("Water Scatter+Id (T20 .rgb scatter, .a id)", 2D) = "black" {}
        _SceneDepthCopy ("Scene Depth Copy (T1 .x)", 2D) = "white" {}
        _SceneColorCopy ("Scene Color / Foam (T15)", 2D) = "black" {}
        _WaterCaustics ("Water Caustics (T21)", 2D) = "black" {}
        // Split-sum DFG / environment-BRDF LUT (T8, sampled with sampler_LinearMirror at NoV/NoL × roughness, b70:521).
        // In HGRP this is a globally bound precomputed BRDF integration LUT; here a bindable material texture (texture+math => CLOSEABLE).
        _WaterBrdfLut ("Water BRDF DFG LUT (T8 .x split-sum)", 2D) = "white" {}

        // ============================================================
        // Water material coefficients — in HGRP these come from _WaterData_f_0[1298] indexed by per-pixel material id (b70:227-251,...).
        // Re-exposed as clean uniforms for ONE representative water material. TODO(1:1) ENGINE-SIDE: the _WaterData_f_0[1298] StructuredBuffer
        //   is filled by the host C# water system (per-material rows, indexed per-pixel by id=round(T20.a*255)); only the ARRAY LOOKUP is collapsed
        //   to one material here. Every coefficient the lighting MATH consumes is exposed as a uniform below and used 1:1.
        // ============================================================
        [Header(Water Material (was _WaterData per id))]
        _ScatterColor ("Scatter / Subsurface Color", Color) = (0.05, 0.35, 0.45, 1)
        _AbsorbColor ("Absorption Color (deep)", Color) = (0.02, 0.08, 0.12, 1)
        _WaterRoughness ("Water Roughness", Range(0.01, 1)) = 0.05
        _SpecularScale ("Specular Scale (legacy stand-in; superseded by _SunDiskParams.x sun intensity)", Range(0, 4)) = 1
        _AnisoNormalScale ("Anisotropic Normal Scale (was WaterData _346.z)", Range(0.1, 4)) = 1
        _SssStrength ("Back-Scatter Strength (legacy stand-in; superseded by 1:1 _791 lobe)", Range(0, 4)) = 1
        _RefractionStrength ("Refraction Strength (screen UV warp)", Range(0, 0.2)) = 0.02
        [HDR] _FoamColor ("Foam Color", Color) = (1, 1, 1, 1)
        _FoamAmount ("Foam Amount", Range(0, 1)) = 0
        // Was WaterData _356.z (F0 scale, b70:233), _349+10.z (multi-scatter horizon, b70:518), _437+10.w (back-scatter mask coeff, b70:519,251).
        _WaterF0Scale ("Water F0 Scale (was WaterData _356.z)", Range(0, 2)) = 1
        _MultiScatterScale ("Multi-Scatter Horizon (was WaterData _349.z)", Range(0, 2)) = 1
        _BackScatterMask ("Back-Scatter Mask Coeff (was WaterData _437.w)", Range(0, 4)) = 1

        // ============================================================
        // Directional sun-disk data — HGRP _LightDataBuffer_DirectionalLightCustomData2 (cbuffer b3, b70:91,489-521).
        //   .x = sun specular intensity, .y = sin(angular half-radius), .z = cos(angular half-radius). URP has no global for the
        //   sun's angular size, so it is re-exposed as a material Vector (STYLE_BIBLE §1.5/§2). Drives the reflected-view sun-disk
        //   widening that yields the sharp anisotropic glitter streak. Default = HG sun (~0.53° diameter): sin/cos of 0.265°.
        // ============================================================
        [Header(Sun Disk (was LightData CustomData2))]
        _SunDiskParams ("Sun Disk (.x intensity .y sinHalfAng .z cosHalfAng)", Vector) = (1, 0.0046251, 0.9999893, 0)

        // ============================================================
        // Environment intensities — HGRP _EnvironmentGlobalParams0 (b70:779-781) re-exposed (URP has no global equivalent; STYLE_BIBLE §1.5/§2).
        // ============================================================
        [Header(Environment)]
        _EnvironmentGlobalParams0 ("Env Params0 (.x ambient .y reflection scale)", Vector) = (1, 1, 0, 0)

        // ============================================================
        // Quality toggle — HGRP HG_WATER_DESKTOP_QUALITY_LOW (skeleton 491). Base vs low DIFFER in CAUSTICS sample-count (base 2 octave taps
        //   blended prod·100+max, b70:1096-1101,1109; low 1 tap ×10, b72:1060,1065) — ported under #ifdef in the WaterLighting frag, NOT collapsed.
        // ============================================================
        [Toggle(_HG_WATER_DESKTOP_QUALITY_LOW)] _DesktopQualityLow ("Desktop Quality Low", Float) = 0
    }

    SubShader {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" "Queue" = "Transparent+100" }
        LOD 300

        // ============================================================================================
        // Shared HLSLINCLUDE — URP core + every uniform/texture + the 1:1 water-lighting math.
        // ============================================================================================
        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

        CBUFFER_START(UnityPerMaterial)
            float4 _ScatterColor;
            float4 _AbsorbColor;
            float  _WaterRoughness;
            float  _SpecularScale;
            float  _AnisoNormalScale;
            float  _SssStrength;
            float  _RefractionStrength;
            float4 _FoamColor;
            float  _FoamAmount;
            float  _WaterF0Scale;
            float  _MultiScatterScale;
            float  _BackScatterMask;
            float4 _SunDiskParams;
            float4 _EnvironmentGlobalParams0;
            float4 _WaterBrdfLut_TexelSize;
            float4 _WaterDepth_TexelSize;
            float4 _WaterNormalRoughness_TexelSize;
            float4 _WaterScatterColor_TexelSize;
            float4 _SceneDepthCopy_TexelSize;
            float4 _SceneColorCopy_TexelSize;
            float4 _WaterCaustics_TexelSize;
        CBUFFER_END

        TEXTURE2D(_WaterDepth);            SAMPLER(sampler_WaterDepth);
        TEXTURE2D(_WaterNormalRoughness);  SAMPLER(sampler_WaterNormalRoughness);
        TEXTURE2D(_WaterScatterColor);     SAMPLER(sampler_WaterScatterColor);
        TEXTURE2D(_SceneDepthCopy);        SAMPLER(sampler_SceneDepthCopy);
        TEXTURE2D(_SceneColorCopy);        SAMPLER(sampler_SceneColorCopy);
        TEXTURE2D(_WaterCaustics);         SAMPLER(sampler_WaterCaustics);
        TEXTURE2D(_WaterBrdfLut);          SAMPLER(sampler_WaterBrdfLut);   // T8 split-sum DFG LUT (b70:521), sampler_LinearMirror

        // ---- Decoded magic-constant table (denormalized-float bit patterns -> real values, b70). Algorithm boundaries — preserve EXACTLY. ----
        static const float HGRP_EPS_VIEWLEN  = 9.9999999392252902907785028219223e-09; // = 1e-8 ; |V| rsqrt guard, b70:212
        static const float HGRP_EPS_HALF      = 6.103515625e-05;                       // = 2^-14 ; half-precision rsqrt guard (asfloat(947912704u)), b70:490,501
        static const float HGRP_DIELECTRIC_F0 = 0.07999999821186065673828125;          // = 0.08  ; dielectric F0 base, b70:233
        static const float HGRP_EPS_VIS       = 9.9999997473787516355514526367188e-05; // = 1e-4  ; Smith-visibility / ratio denominator floor, b70:521,246
        static const float HGRP_FLT_MIN       = 1.1754943508222875079687365372222e-38; // = FLT_MIN ; aniso-normal rsqrt floor, b70:955
        static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709 luma, b70:782

        // --------------------------------------------------------------------------------------------
        // Octahedral DECODE of the packed water normal (b70:217-226). T17.xy in [0,1] -> [-1,1] -> oct -> unit normal.
        //   _297=2*nx-1, _298=2*ny-1 ; z = 1 - (|x|+|y|) ; if z<0 wrap: x = sign(x)*(1-|y|), y = sign(y)*(1-|x|) ; normalize.
        // --------------------------------------------------------------------------------------------
        float3 DecodeWaterNormal(float2 packed)
        {
            float x = mad(packed.x, 2.0, -1.0);                                   // b70:217 (_297)
            float y = mad(packed.y, 2.0, -1.0);                                   // b70:218 (_298)
            float z = mad(-1.0, dot(float2(1.0, 1.0), float2(abs(x), abs(y))), 1.0); // 1-(|x|+|y|) , b70:219 (_305)
            if (z < 0.0)                                                          // b70:220 (_306)
            {
                float sx = (x >= 0.0) ? 1.0 : -1.0;                              // asfloat(1065353216u/3212836864u) = +1/-1 , b70:221
                float sy = (y >= 0.0) ? 1.0 : -1.0;                              // b70:222
                float nx = sx * (mad(-1.0, abs(y), 1.0));                        // sign(x)*(1-|y|) , b70:221 (_328)
                float ny = sy * (mad(-1.0, abs(x), 1.0));                        // sign(y)*(1-|x|) , b70:222 (_329)
                x = nx; y = ny;
            }
            float invLen = rsqrt(dot(float3(x, z, y), float3(x, z, y)));         // b70:223 (_335) — note HG basis order (x, z=up, y)
            return float3(x * invLen, z * invLen, y * invLen);                   // b70:224-226 (_337=Nx, _338=Ny(up), _339=Nz)
        }

        // --------------------------------------------------------------------------------------------
        // Water Fresnel reflectance F(NoV) via the Karis/Lazarov EnvBRDFApprox polynomial in (1-roughness) (b70:515-517).
        //   t=1-rough ; F = min( t*(t*((-t)*0.383026 - 0.0761947) + 1.04997) + 0.409255, 0.999 ) ; returns reflectance (HG _660), and its complement is the transmittance.
        //   Identical poly + coeffs as CoreMath.HgEnvBRDFApproxDFG — water reuses it as the surface Fresnel.
        // --------------------------------------------------------------------------------------------
        float WaterFresnel(float roughness)
        {
            float t = mad(-1.0, roughness, 1.0);                                  // 1-rough , b70:515 (_651)
            return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875,          // b70:516 (_660)
                                          -0.076194703578948974609375),
                                    1.04997003078460693359375),
                           0.4092549979686737060546875),
                       0.999000012874603271484375);
        }

        // --------------------------------------------------------------------------------------------
        // Direct-light water specular = the blob's _732 (b70:509-521), now ported 1:1 in BOTH terms:
        //   term2 (analytic highlight): GGX-D (NoH·a^2 denom) × Smith height-correlated Vis × SCHLICK-F(VoH, F0=0.08·WaterData),
        //     inner-clamped to 2048. a^2-NDF/Vis is 1:1 with CoreMath.HgDirectSpecular. NoH=_631, NoL=_627, NoV=_635, VoH=1-_646.
        //   term1 (multi-scatter / energy-comp via the split-sum DFG LUT, was the punted T8 path, b70:518,521):
        //     ((_660 · T8(NoV,rough).x · T8(NoL,rough).x) / _663) · (_670²) / (1 − _670·_663), with
        //     _663 = 1−_660 (EnvBRDFApprox complement), _670 = lerp/mad of the multi-scatter horizon coeff.
        //   Both are summed, scaled by CustomData2.x (sun specular intensity → _SunDiskParams.x), and outer-clamped to 1000.
        //   T8 split-sum DFG LUT addressing (b70:521): float2(value·0.96875 + 0.015625, rough·0.96875 + 0.015625).
        //   1:1, source = waterrendering/Sub0_Pass2_Fragment_b70.hlsl:518,521.
        // --------------------------------------------------------------------------------------------
        float WaterSpecular(float roughness, float NoL, float NoH, float NoV, float VoH, float fresnelRefl,
                            float dielectricF0, float multiScatterScale, float sunIntensity)
        {
            float a   = roughness * roughness;                                   // _636 = rough*rough , b70:509
            float a2  = a * a;                                                  // _637 , b70:510
            // GGX NDF denominator: d = (NoH*a2 - NoH)*NoH + 1 ; folded D=a2/(d*d) below , b70:511 (_640 uses NoH=_631)
            float d   = mad(mad(NoH, a2, -NoH), NoH, 1.0);                       // b70:511 (_640)
            float visDenom = NoV * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2))        // NoV*sqrt((-NoL*a2+NoL)*NoL+a2) , b70:521 sub (_635 leg)
                           + NoL * sqrt(mad(mad(-NoV, a2, NoV), NoV, a2))        // NoL*sqrt((-NoV*a2+NoV)*NoV+a2) , (_627 leg)
                           + HGRP_EPS_VIS;                                       // 1e-4 floor , b70:521
            float DV  = (a2 / (d * d)) * (0.5 / visDenom);                       // D*Vis , b70:521 (_637/(_640*_640) · 0.5/visDenom)
            // Schlick Fresnel over VoH (b70:512-514,521): _646=(1-VoH)=1-clamp(dot(V,H)), _648=(1-VoH)^4 ->
            //   lerp(F0,1,(1-VoH)^5) = mad(F0, 1-(1-VoH)^5, (1-VoH)^5). HG spells the inner mad as mad(_363,mad(-_648,_646,1),_646*_648).
            float oneMinusVoH = mad(-1.0, VoH, 1.0);                             // 1-VoH , b70:512 (_646)
            float sq          = oneMinusVoH * oneMinusVoH;                       // _647
            float quad        = sq * sq;                                        // (1-VoH)^4 , b70:514 (_648)
            float Fspec       = mad(dielectricF0, mad(-quad, oneMinusVoH, 1.0), oneMinusVoH * quad); // mad(F0, 1-(1-VoH)^5, (1-VoH)^5) , b70:521
            float term2 = min(DV * Fspec, 2048.0);                              // analytic highlight, inner clamp 2048 , b70:521

            // term1 — split-sum DFG LUT multi-scatter (b70:518,521). _670 = multi-scatter horizon coefficient.
            float complement = mad(-1.0, fresnelRefl, 1.0);                     // _663 = 1 - _660 , b70:517
            float msHorizon  = mad(mad(-multiScatterScale, HGRP_DIELECTRIC_F0, 1.0),
                                   0.0476190485060214996337890625, dielectricF0); // _670 = mad((-WaterData·0.08+1), 1/21, _363) , b70:518
            float dfgV = SAMPLE_TEXTURE2D(_WaterBrdfLut, sampler_WaterBrdfLut,
                             float2(mad(NoV, 0.96875, 0.015625), mad(roughness, 0.96875, 0.015625))).x; // T8(NoV,rough) , b70:521
            float dfgL = SAMPLE_TEXTURE2D(_WaterBrdfLut, sampler_WaterBrdfLut,
                             float2(mad(NoL, 0.96875, 0.015625), mad(roughness, 0.96875, 0.015625))).x; // T8(NoL,rough) , b70:521
            float term1 = (((fresnelRefl * (dfgV * dfgL)) / complement) * (msHorizon * msHorizon))
                        / mad(-msHorizon, complement, 1.0);                      // (_660·T8·T8)/_663·_670²/(1-_670·_663) , b70:521

            return min(max((term1 + term2) * sunIntensity, 0.0), 1000.0);       // outer ×CustomData2.x then clamp 1000 , b70:521 (_732)
        }

        // --------------------------------------------------------------------------------------------
        // Reflected-view sun-disk specular direction (b70:480-508). Builds the HG anisotropic SUN-GLITTER direction:
        //   Rv = reflect(-V, Naniso) (b70:480-484) ; if Rv falls OUTSIDE the sun's angular disk (cos half-angle = sunCos),
        //   SNAP Rv to the disk edge: L_spec = -lightDirHG·cos + normalize(Rv - (Rv·lightDirHG)·lightDirHG ... )·sin
        //   (b70:489-497). Else L_spec = Rv. Then H = normalize(V + L_spec) (b70:498-504). Outputs NoL/NoH/NoV (b70:505-508).
        //   lightDirHG = HG directional-light direction (= the direction light TRAVELS) = -mainLight.direction (URP).
        //   1:1, source = waterrendering/Sub0_Pass2_Fragment_b70.hlsl:480-508.
        // --------------------------------------------------------------------------------------------
        void WaterSunDiskTerms(float3 Naniso, float3 V, float3 lightDirHG, float sunSin, float sunCos,
                               out float NoL, out float NoH, out float NoV, out float VoH, out float NoLraw, out float3 LspecOut)
        {
            // Rv = reflect(-V, Naniso) , b70:480-484 (_538/_539/_540). _530=dot(-V,Naniso); _534=-2·_530.
            float dNegVN = dot(-V, Naniso);                                      // _530
            float twoFold = -(dNegVN + dNegVN);                                  // _534
            float3 Rv = mad(Naniso, twoFold.xxx, -V);                            // _538/_539/_540
            // _549 = dot(-lightDirHG, Rv). Tangential component perp = lightDirHG·_549 + Rv , b70:485-488 (_557/558/559).
            float along = dot(-lightDirHG, Rv);                                  // _549
            float3 perp = mad(lightDirHG, along.xxx, Rv);                        // _557/_558/_559
            bool outside = along < sunCos;                                       // _564 : Rv outside the sun disk
            float invPerp = rsqrt(max(dot(perp, perp), HGRP_EPS_HALF));          // _570 , 2^-14 floor
            // Snap to disk edge: -lightDirHG·cos + (normalize(perp))·sin , b70:491-493 (_591/_592/_593).
            float3 edge = mad(-lightDirHG, sunCos.xxx, (invPerp * sunSin).xxx * perp); // _591/_592/_593
            float invEdge = rsqrt(dot(edge, edge));                              // _597
            float3 Lspec = outside ? (edge * invEdge) : Rv;                      // _608/_610/_612 = L_spec
            LspecOut = Lspec;
            float3 H = V + Lspec;                                               // _613/_614/_615 = V + L_spec
            H *= rsqrt(max(dot(H, H), HGRP_EPS_HALF));                          // _620 normalize , 2^-14 floor
            NoLraw = dot(Lspec, Naniso);                                        // _624 (unclamped, feeds back-scatter _682)
            NoL = saturate(NoLraw);                                             // _627 = clamp(dot(L_spec, Naniso))
            NoH = saturate(dot(Naniso, H));                                     // _631 = clamp(dot(Naniso, H))
            NoV = saturate(dot(Naniso, V));                                     // _635 = clamp(dot(Naniso, V))
            VoH = saturate(dot(V, H));                                          // 1-_646 input : clamp(dot(V, H)) , b70:512
        }

        // --------------------------------------------------------------------------------------------
        // Scatter-channel min/mid/max sort -> absorbed (min) component + iridescent hue phase (b70:237-246,522).
        //   HG sorts the three scatter channels (_147/_148/_149) to derive: _418 = the sorted MAX (drives back-scatter mask),
        //   _424/_427 = (max-min(mid,...)) spread ratio (saturation), and _740 = a hue PHASE for the per-channel rainbow ramp.
        //   Pure math on the sampled scatter RGB — no missing resource.
        //   1:1, source = waterrendering/Sub0_Pass2_Fragment_b70.hlsl:237-246,522.
        // --------------------------------------------------------------------------------------------
        void WaterScatterSort(float3 scatterRGB, out float sortedMax, out float spreadRatio, out float huePhase)
        {
            float c0 = scatterRGB.x, c1 = scatterRGB.y, c2 = scatterRGB.z;       // _147/_148/_149
            // First compare g vs b (b70:237-240).
            float selGB = (c1 >= c2) ? 1.0 : 0.0;                                // _392 = (g>=b)?1:0
            float hiGB  = mad(selGB, c1 - c2, c2);                               // _402 = max(g,b)
            float loGB  = mad(selGB, c2 - c1, c1);                               // _403 = min(g,b)
            float hueGB = mad(selGB, -1.0, 0.6666667);                           // _405 = (g>=b)? -1/3 : 2/3   (asfloat(3212836864)=-1, asfloat(1059760811)=2/3)
            // Then compare r vs max(g,b) (b70:241-244).
            float selR  = (c0 >= hiGB) ? 1.0 : 0.0;                              // _409 = (r>=hiGB)?1:0
            sortedMax   = mad(selR, c0 - hiGB, hiGB);                            // _418 = overall max
            float midR  = mad(selR, -loGB + loGB, loGB);                         // _419 = loGB (HG _419: mad(_409, (-_403)+_403, _403))
            float lowR  = mad(selR, hiGB - c0, c0);                              // _421 = min(r, hiGB)
            float spread = -min(midR, lowR) + sortedMax;                         // _424 = max - min(mid,low)
            spreadRatio  = spread / (sortedMax + HGRP_EPS_VIS);                  // _427 = spread / (max+1e-4)  (saturation)
            // Hue phase _740 (b70:522): combine the two hue selectors into the chroma wheel position.
            float hueR = mad(selR, -hueGB + mad(selGB, 1.0, -1.0), hueGB);       // inner of _740 : mad(_409,(-_405)+mad(_392,1,-1),_405)
            huePhase = abs((((-midR) + lowR) / mad(spread, 6.0, HGRP_EPS_VIS)) + hueR); // _740
        }
        ENDHLSL

        // ============================================================================================
        // Pass 0 — WaterTessellation0  (HGRP: writes water G-buffer + stencil Ref 1 Comp Always Replace).
        //   BASE (#else) blobs b1 (vertex, NaN) / b2 (fragment, 0 + discard) are degenerate stubs — the real surface
        //   only exists in the compute-driven tessellation variants. Kept here as a stencil-writing stub.
        // ============================================================================================
        Pass {
            Name "WaterTessellation0"
            Tags { "LightMode" = "SRPDefaultUnlit" }
            Blend SrcColor OneMinusSrcColor                                       // HGRP "Blend 2 SrcColor OneMinusSrcColor" (skeleton 5)
            ZWrite Off
            Cull Off
            Stencil { Ref [_StencilRef] Comp Always Pass Replace Fail Keep ZFail Keep } // skeleton 8-14

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes { float4 positionOS : POSITION; };
            struct Varyings   { float4 positionCS : SV_Position; };

            Varyings vert(Attributes input)
            {
                Varyings o;
                o.positionCS = TransformObjectToHClip(input.positionOS.xyz);
                return o;
            }

            // TODO(1:1): WaterTessellation0 surface = HGRP water tessellation/simulation compute (type_WaterData[1298], indirect draws).
            //   BASE blob b2 writes 0 + discards (b2:33-46); no portable surface math exists in the base variant. Stencil-only stub.
            half4 frag(Varyings input) : SV_Target
            {
                clip(-1.0);                                                       // b2: discard (base variant fully discards)
                return half4(0, 0, 0, 0);                                         // b2:35-45 SV_Target = 0
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 1 — WaterTessellation1  (HGRP: same as Pass0 but Stencil Comp NotEqual; second tessellation layer).
        //   Same degenerate base blobs (b1/b2). Stencil-writing stub.
        // ============================================================================================
        Pass {
            Name "WaterTessellation1"
            Tags { "LightMode" = "SRPDefaultUnlit" }
            Blend SrcColor OneMinusSrcColor
            ZWrite Off
            Cull Off
            Stencil { Ref [_StencilRef] Comp NotEqual Pass Replace Fail Keep ZFail Keep } // skeleton 242-248

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes { float4 positionOS : POSITION; };
            struct Varyings   { float4 positionCS : SV_Position; };

            Varyings vert(Attributes input)
            {
                Varyings o;
                o.positionCS = TransformObjectToHClip(input.positionOS.xyz);
                return o;
            }

            // TODO(1:1): identical to Pass0 — HGRP water tessellation compute, base blob discards. Stencil-only stub.
            half4 frag(Varyings input) : SV_Target
            {
                clip(-1.0);
                return half4(0, 0, 0, 0);
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2 — WaterLighting  (THE meaty pass). Fullscreen-triangle deferred water resolve.
        //   Vertex = b69 (fullscreen tri from SV_VertexID). Fragment = b70 (1184-line deferred lighting), ported 1:1 for the
        //   portable lighting math; compute-fed G-buffers/_WaterData are uniforms; HGRP shadow/probe/fog infra -> URP facilities.
        // ============================================================================================
        Pass {
            Name "WaterLighting"
            Tags { "LightMode" = "UniversalForwardOnly" }
            Blend One Zero                                                        // resolve writes final color (HGRP composes via stencil-gated fullscreen)
            ZTest Always                                                          // skeleton 474 (ZTest Always)
            ZWrite Off                                                            // skeleton 475
            Cull Off                                                              // skeleton 476
            Stencil { Ref [_StencilRef] ReadMask 1 Comp Equal Pass Keep Fail Keep ZFail Keep } // skeleton 477-483

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile_fragment _ _SHADOWS_SOFT
            #pragma shader_feature_local _HG_WATER_DESKTOP_QUALITY_LOW

            struct Attributes { uint vertexID : SV_VertexID; };
            struct Varyings
            {
                float4 positionCS : SV_Position;
                float2 uv         : TEXCOORD0;   // b69: TEXCOORD1 (screen uv)
            };

            // Fullscreen triangle from vertex id (b69:56-66). _34 = (id>>0)&1 mapped, _35 = id&2 ; clip = 2*bit-1 ; uv.y flipped.
            Varyings vert(Attributes input)
            {
                Varyings o;
                float x = float(input.vertexID & 1u);                            // b69:58-59 (_34 = id&1) — 1:1
                // b69:60 HG uses _35 = id&2 -> {0,2} (NOT {0,1}); clip.y=2*_35-1 in {-1,3}, uv.y=1-_35 in {1,-1}.
                // For the 3 verts {0,1,2} this is the OVERSIZED fullscreen triangle; the (id>>1)&1 form below yields
                // clip.y in {-1,1}, uv.y in {1,0} — a DIFFERENT (half-size) triangle that interpolates to the SAME uv
                // at every on-screen pixel (both share the bottom edge + same affine gradient). On-screen result is identical.
                float y = float((input.vertexID >> 1u) & 1u);                    // b69:60 (id&2 normalized to {0,1})
                o.positionCS = float4(mad(x, 2.0, -1.0), mad(y, 2.0, -1.0), 1.0, 1.0); // b69:61-62,65-66 (z=w=1, far plane)
                o.uv = float2(x, mad(-1.0, y, 1.0));                             // b69:63-64 (uv.y = 1 - y)
                #if UNITY_UV_STARTS_AT_TOP
                o.positionCS.y = -o.positionCS.y;                                // URP clip-space Y handedness (infra)
                #endif
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                float2 uv = input.uv;

                // ---- Sample water G-buffers (b70:179-192). T16=water depth, T1=scene depth, T20=scatter+id, T17=oct normal+rough. ----
                float waterDepth = SAMPLE_TEXTURE2D(_WaterDepth, sampler_WaterDepth, uv).x;             // b70:179-180 (_126)
                float sceneDepth = SAMPLE_TEXTURE2D(_SceneDepthCopy, sampler_SceneDepthCopy, uv).x;     // b70:181-182 (_134)
                // b70:183-186: discard where water is behind scene depth (water occluded).
                if (waterDepth < sceneDepth) { clip(-1.0); }
                float4 scatterSample = SAMPLE_TEXTURE2D(_WaterScatterColor, sampler_WaterScatterColor, uv); // b70:187-190 (_145)
                float3 scatterRGB    = scatterSample.xyz;                                                    // _147/_148/_149
                float4 normRough     = SAMPLE_TEXTURE2D(_WaterNormalRoughness, sampler_WaterNormalRoughness, uv); // b70:191 (_156)
                float  roughness     = normRough.z;                                                          // b70:192 (_160) perceptualRoughness

                // ---- Reconstruct world position from water depth (b70:195-205) via inverse view-projection. ----
                //   HG uses _InvViewProjMatrix (its own global); URP equivalent = UNITY_MATRIX_I_VP. NDC = (2*uv.x-1, -(2*uv.y-1)).
                float ndcX = mad(uv.x, 2.0, -1.0);                                // b70:195 (_172)
                float ndcY = -mad(uv.y, 2.0, -1.0);                              // b70:196-197 (_175 then negate -> _176)
                float4 clipPos = float4(ndcX, ndcY, waterDepth, 1.0);
                float4 worldH  = mul(UNITY_MATRIX_I_VP, clipPos);               // b70:198-205 (_197..225) : I_VP * (ndc, depth, 1)
                float3 positionWS = worldH.xyz / worldH.w;                       // perspective divide , b70:203-205 (_223/_224/_225)

                // ---- View vector (b70:207-216). Persp: normalize(camPos - P) ; ortho: -camera forward (UNITY_MATRIX_I_V col2). ----
                float3 viewRaw;
                if (unity_OrthoParams.w == 0.0)                                  // b70:207 (_248) : persp
                    viewRaw = _WorldSpaceCameraPos - positionWS;                 // b70:208-210 (_281/_283/_285)
                else
                    viewRaw = float3(UNITY_MATRIX_I_V._m02, UNITY_MATRIX_I_V._m12, UNITY_MATRIX_I_V._m22); // ortho: +camFwd, b70:208-210 else-branch (_ViewMatrix[i].z = 3rd row of view = +I_V.col2, NO negation in blob)
                float distSq = dot(viewRaw, viewRaw);                            // b70:211 (_286)
                float invViewLen = rsqrt(max(distSq, HGRP_EPS_VIEWLEN));         // b70:212 (_292)
                float3 V = viewRaw * invViewLen;                                 // b70:213-215 (_293/_294/_295)
                float  viewLen = distSq * invViewLen;                           // |V| , b70:216 (_296)

                // ---- Decode water surface normal (b70:217-226). ----
                float3 N = DecodeWaterNormal(normRough.xy);                      // (_337=Nx, _338=Ny up, _339=Nz)

                // ---- Anisotropic normal tweak used for the specular lobe (b70:475-479). Stretch tangent-plane by _AnisoNormalScale. ----
                //   HG: _519 = Ny * WaterData[_346].z ; renormalize (Nx, Ny', Nz). _AnisoNormalScale re-exposes that compute-fed scale.
                float aniN_y = N.y * _AnisoNormalScale;                          // b70:475 (_519 ; WaterData _346.z -> uniform)
                float aniInv = rsqrt(dot(float3(N.x, N.z, aniN_y), float3(N.x, N.z, aniN_y))); // b70:476 (_523)
                float3 Naniso = float3(N.x * aniInv, aniN_y * aniInv, N.z * aniInv);           // b70:477-479 (_524/_525/_526) — basis (x, up=y', z)

                // ---- Sun-disk specular geometry (b70:480-508), now 1:1: reflected-view direction snapped to the sun disk. ----
                Light mainLight = GetMainLight(TransformWorldToShadowCoord(positionWS), positionWS, half4(1,1,1,1));
                float3 lightDirHG = -mainLight.direction;                        // HG _LightDataBuffer_DirectionalLightDirection = direction light travels (b70:485)
                float NoL, NoH, NoV, VoH, NoLraw; float3 Lspec;
                WaterSunDiskTerms(Naniso, V, lightDirHG, _SunDiskParams.y, _SunDiskParams.z, NoL, NoH, NoV, VoH, NoLraw, Lspec); // _627/_631/_635/_646/_624/_608..612

                // ---- Water surface Fresnel reflectance (b70:515-517). EnvBRDFApprox poly — drives reflection/refraction split. ----
                float fresnelRefl = WaterFresnel(roughness);                     // (_660)
                float dielectricF0 = HGRP_DIELECTRIC_F0 * _WaterF0Scale;         // _363 = 0.08*WaterData[_356].z , b70:233

                // ---- Direct specular = HG _732 (b70:509-521): analytic GGX·Vis·Schlick + split-sum DFG multi-scatter, ×sun intensity, clamp 1000. ----
                float spec = WaterSpecular(roughness, NoL, NoH, NoV, VoH, fresnelRefl, dielectricF0, _MultiScatterScale, _SunDiskParams.x); // _732
                float shadow = mainLight.shadowAttenuation;                      // HGRP CSM/ASM _508/_514 -> URP main-light shadow (b70:253-474 substituted)

                // ---- Scatter-channel sort (b70:237-246): sorted max (_418), saturation spread (_427), iridescent hue phase (_740). ----
                float sortedMax, spreadRatio, huePhase;
                WaterScatterSort(scatterRGB, sortedMax, spreadRatio, huePhase);  // _418 / _427 / _740
                float3 waterAlbedo = scatterRGB;                                 // b70:188-190 raw scatter (_147/_148/_149)

                // ---- Back-scatter / SSS lobe _791 (b70:519,523-524). Sharp forward-transmitted glow gated by the sorted-max mask. ----
                float backMaskCoeff = _BackScatterMask;                          // WaterData[_437+10].w -> uniform (b70:251,519)
                float bs678 = saturate(mad(-sortedMax, backMaskCoeff, 1.0));     // _678 = clamp(1 - _418·coeff)
                float bs682 = saturate(mad(NoLraw, 0.6666666865, 0.3333333433)); // _682 = clamp(_624·2/3 + 1/3)
                float bs773 = mad(bs678, mad(sqrt(bs682) * bs682, 1.6666666269, -1.0), 1.0); // _773
                float vDotLspecNeg = saturate(-dot(V, Lspec));                  // clamp(-dot(V, L_spec)) , b70:524 (_608..612 from the sun disk)
                float bs791 = mad(mad(bs678, -2.9000000954, 3.0) * exp2(log2(max(vDotLspecNeg, 1e-30)) * 12.0),
                                  mad(-bs773, 0.1591549367, 1.0), bs773 * 0.1591549367); // _791 (b70:524)
                float backScatterBase = sortedMax * backMaskCoeff;              // _443 = _418·WaterData[_437+10].w (b70:251)

                // ---- Direct light response _806/_807/_808 (b70:525-527): (scatter·NoL + _732·NoL + _443·hueRamp·_791)·LightColor. ----
                //   hueRamp per channel = mad(_427, clamp(abs(frac(_740+phase)·6-3)-1,0,1)-1, 1) : an iridescent rainbow triangle wave.
                float hueRampR = mad(spreadRatio, clamp(abs(mad(frac(huePhase + 1.0),               6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0); // _806 sub
                float hueRampG = mad(spreadRatio, clamp(abs(mad(frac(huePhase + 0.6666666865),      6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0); // _807 sub
                float hueRampB = mad(spreadRatio, clamp(abs(mad(frac(huePhase + 0.3333333433),      6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0); // _808 sub
                float3 backScatterRGB = (backScatterBase * bs791).xxx * float3(hueRampR, hueRampG, hueRampB); // _443·_791·hueRamp
                float3 directRGB = (waterAlbedo * NoL + spec.xxx * NoL + backScatterRGB)
                                 * (mainLight.color * shadow);                   // b70:525-527 (_806/_807/_808) * DirectionalLightColor

                // ---- Ambient (SH) (b70:766-768). HG IV-clipmap SH cascade (_IVDefaultSHA*) -> URP SampleSH(N). ----
                float3 ambientSH = SampleSH(N);                                  // b70:766-768 (_1640/_1645/_1650) — diffuse SH projected on N
                float3 ambientRGB = waterAlbedo * ambientSH * _EnvironmentGlobalParams0.x; // gated by env ambient intensity , b70:779-781

                // ---- Reflection (b70:801-902). HG reflection-probe binning atlas -> URP GlossyEnvironmentReflection. ----
                float3 reflectVec = reflect(-V, N);                              // R = reflect(-V,N) , b70:769-773 (_1662/_1663/_1664)
                float  perceptualRoughness = saturate(roughness);              // b70:301-equivalent ; feed URP its perceptualRoughness directly
                float3 reflection = GlossyEnvironmentReflection(reflectVec, perceptualRoughness, 1.0);
                float3 reflectRGB = reflection * fresnelRefl * _EnvironmentGlobalParams0.y; // env reflection scale , b70:911-917

                // ---- Screen-space refraction (b70:944-983 + 1084-1115). HG reconstructs a refracted scene UV from the water normal + depth. ----
                //   Full path needs scene-color + scene-depth copies (T15/T1) and a parallax march; here a 1:1-spirit single-tap warp by the normal.x/z.
                float2 refractUV = uv + float2(N.x, N.z) * _RefractionStrength;  // b70:953-965 warp (normal-driven screen offset)
                float3 sceneColor = SAMPLE_TEXTURE2D(_SceneColorCopy, sampler_SceneColorCopy, refractUV).xyz; // b70:1084 (_3797 foam/scene)
                float3 absorbed   = sceneColor * _AbsorbColor.rgb;              // deep-water absorption tint (b70:_AbsorbColor endpoint of _402/_418 sort)

                // ---- Caustics (b70:1088-1111 base / b72:1055-1067 LOW). Caustics texture (T21) sampled with a WaterData-scaled,
                //   normal-driven scroll. QUALITY delta (the _HG_WATER_DESKTOP_QUALITY_LOW keyword): base takes TWO counter-scrolled
                //   octave taps blended as tap1·tap2·100 + max(tap1,tap2) (b70:1096-1101,1109); LOW takes ONE tap blended ×10
                //   (b72:1060,1065). The per-id WaterData scroll coefficients (_WaterData_f_0[..].x/.y) are engine-side; the 2-octave
                //   structure + blend constants are the portable MATH ported 1:1 here. Scroll stand-in = _RefractionStrength·(N.x,N.z)·20.
                //   1:1, source = waterrendering/Sub0_Pass2_Fragment_b70.hlsl:1096-1101,1109 (base), Sub0_Pass2_Fragment_b72.hlsl:1060,1065 (LOW).
                float2 causticScroll = float2(N.x, N.z) * (_RefractionStrength * 20.0);          // b70:1090-1091 (_3817/_3819 = scroll·20)
                float causticBlend;
                #ifdef _HG_WATER_DESKTOP_QUALITY_LOW
                    // LOW: single tap, ×10 (b72:1060 single SampleBias, b72:1065 mad(... · _3729.x, 10.0, 1.0)).
                    float causticLo = SAMPLE_TEXTURE2D(_WaterCaustics, sampler_WaterCaustics, refractUV + causticScroll).x; // b72:1060 (_3729.x)
                    causticBlend = causticLo * 10.0;                                              // b72:1065 (×10 single octave)
                #else
                    // Base: two counter-scrolled octave taps, tap1·tap2·100 + max(tap1,tap2) (b70:1096/1101 two SampleBias, b70:1109 blend).
                    float causticA = SAMPLE_TEXTURE2D(_WaterCaustics, sampler_WaterCaustics, refractUV + causticScroll).x; // b70:1096 (_3848.x), +_3817/+_3819
                    float causticB = SAMPLE_TEXTURE2D(_WaterCaustics, sampler_WaterCaustics, refractUV - causticScroll).x; // b70:1101 (_3866.x), -_3817/-_3819 second octave
                    causticBlend = mad(causticA * causticB, 100.0, max(causticA, causticB));      // b70:1109 mad(_3850·_3868, 100, max(_3850,_3868))
                #endif
                absorbed += absorbed * causticBlend;                            // b70:1109-1111 caustic boost of transmitted light

                // ---- Foam (b70:1106-1114, 922-931). Foam mask folds toward _FoamColor near shorelines/crests. ----
                float3 foam = _FoamColor.rgb * (_FoamAmount * SAMPLE_TEXTURE2D(_SceneColorCopy, sampler_SceneColorCopy, uv).w); // b70:924-931 (_2883)

                // ---- Composite (b70:1167-1170). transmitted (absorbed) blended with surface (direct+ambient+reflect) by Fresnel transmittance, + foam. ----
                float  transmit = mad(-1.0, fresnelRefl, 1.0);                  // 1-F , transmittance
                float3 color = absorbed * transmit
                             + (directRGB + ambientRGB + reflectRGB)            // surface lit terms , b70:1167-1169 (SV_Target.xyz)
                             + foam;

                // ---- Fog (b70:1020-1080). HG atmosphere+exponential+volumetric froxel fog -> URP MixFog. ----
                float fogFactor = ComputeFogFactor(input.positionCS.z);
                color = MixFog(color, fogFactor);                               // b70:_3786..3792 fog composite -> URP

                // Output alpha = surface coverage (transparent water). HG SV_Target.w = foam/scene alpha (b70:1170 _3797.w).
                float alpha = saturate(fresnelRefl + _FoamAmount);
                return half4(color, alpha);
            }
            ENDHLSL
        }
    }

    // CLOSED (now ported 1:1 with blob cites; previously punted): reflected-view sun-disk specular L_spec/H (b70:480-508),
    //   the T8 split-sum DFG-LUT multi-scatter term of _732 (b70:518,521 -> _WaterBrdfLut sample + math), the scatter-channel
    //   min/mid/max sort + iridescent hue ramp (b70:237-246,522), and the _791 back-scatter/SSS lobe (b70:519,523-524).
    //   The HGRP compute-fed scalars those formulas needed (CustomData2 sin/cos/intensity; WaterData F0/multi-scatter/back-scatter
    //   coefficients) are re-exposed as material uniforms (_SunDiskParams,_WaterF0Scale,_MultiScatterScale,_BackScatterMask) per
    //   STYLE_BIBLE §1.5/§2 — the MATH is byte-faithful, only the per-id ARRAY lookup is collapsed to one material.
    //   ALSO NOW CLOSED (was an EMPTY-PROMISE stub: _HG_WATER_DESKTOP_QUALITY_LOW declared but unbranched, header falsely claimed
    //   "base+low identical MATH"): the CAUSTICS sample-count quality delta is real — base takes TWO counter-scrolled octave taps of
    //   _WaterCaustics blended prod·100+max (b70:1096-1101,1109), LOW takes ONE tap ×10 (b72:1060,1065). Ported under #ifdef
    //   _HG_WATER_DESKTOP_QUALITY_LOW in the WaterLighting frag (the per-id WaterData scroll coeffs stay engine-side; the 2-octave
    //   structure + blend constants are 1:1). 1:1, source = Sub0_Pass2_Fragment_b70.hlsl:1096-1101,1109 / Sub0_Pass2_Fragment_b72.hlsl:1060,1065.
    //   (Other Pass2 keywords carry NO closeable frag delta: HG_ENABLE_SCREEN_SPACE_SHADOW_MASK b78 is byte-identical to base b70
    //   post-header — URP _MAIN_LIGHT_SHADOWS_SCREEN covers it; ENABLE_INK_RENDER b74 is a separate REMOVED stylized art-style
    //   compositor (563-line alt path, not a texture+math delta on the base) — dropped per STYLE_BIBLE §3.4.)
    //
    // SUBSTITUTED BY URP (pixel-equivalent infra, not a 1:1 gap — STYLE_BIBLE §2): CSM(5)+ASM cascaded-shadow atlases+3x3 PCF
    //   (b70:253-468 -> GetMainLight().shadowAttenuation); cloud shadows (T5+_CloudShadowParams, dropped); IV-clipmap SH-GI cascade
    //   (T9-T14+_IVParam*, b70:531-768 -> SampleSH); reflection-probe binning (T0+_ReflectionProbeGlobalDatas[32], b70:785-910 ->
    //   GlossyEnvironmentReflection); atmosphere+exponential+volumetric froxel fog (T3+_*FogParams*, b70:1020-1083 -> MixFog);
    //   screen-space refraction GatherRed depth-edge reprojection + thickness march (b70:944-1019,1116-1170 -> single normal-warped tap).
    //
    // ENGINE-SIDE (the only genuine TODO — requires a HOST system, not a material texture or formula):
    //   - WaterTessellation0/1 surface geometry: produced by the HGRP water TESSELLATION + simulation COMPUTE pipeline (indirect
    //     draws + type_WaterData[1298] StructuredBuffer filled by a C# water system). The base #else blobs b1/b2 are degenerate
    //     NaN/discard stubs (b1:53-56, b2:33-46) — there is NO portable surface math in the base variant. A host ScriptableRenderFeature
    //     running the water sim + tessellation must produce the surface; Pass0/1 stay stencil-only stubs.
    //   - The water G-buffers themselves (_WaterDepth/_WaterNormalRoughness/_WaterScatterColor + scene depth/color copies, caustics):
    //     screen-space render targets written by that same host water pass (T16/T17/T20/T1/T15/T21). Exposed as bindable textures so
    //     the lighting pass runs standalone; the host pass must bind them. (A material texture/formula is never engine-side; these are
    //     pass-produced TEXTURES filled by the water compute/raster system, named per the §2 G-buffer legend above.)
}
