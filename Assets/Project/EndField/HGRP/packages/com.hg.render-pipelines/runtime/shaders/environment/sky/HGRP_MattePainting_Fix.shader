// HGRP MattePainting — transparent unlit sky/backdrop quad with tint + exp-threshold emission boost + exposure + VFX color grade.
//   A "matte painting" is a screen-aligned painted-sky card drawn in the transparent queue; the BASE blob simply
//   samples one _MainTex, optionally treats it as a luminance/alpha source, tints it, applies an exp-threshold HDR
//   boost, divides by post-exposure, then runs a luminance-based saturation/tint grade (_VFXParams1).
//
// Merged from (one Pass "ForwardOnly", Vertex+Fragment):
//   b6/b7  (HG_ENABLE_MV)                              — BASE (catch-all #else), color algorithm ground truth.
//   b11    (HG_ENABLE_MV + _USE_FOG + _ALPHATEST_ON)   — fog delta (atmosphere+exponential+volumetric) + alpha clip.
//
// Keywords: _USE_FOG (HGRP atmosphere+exponential+volumetric fog re-color), _ALPHATEST_ON (alpha clip).
// Kept: MainTex sample + mip bias, _UseMainTexAsAlpha luminance-as-alpha, _TintColor*_TintColorIntensity,
//   exp-threshold HDR boost (_ExpThreshold/_ExpIntensity), post-exposure divide (_ExposureParams.x/_IgnorePostExposure),
//   _VFXParams1 luminance saturation+channel grade, _TintColorAlpha alpha, _SurfaceType Opaque/Transparent,
//   _BlendMode Alpha/Additive, _CullMode, _AlphaClipThreshold clip,
//   _USE_FOG = HGRP atmosphere (Rayleigh/Mie phase + height transmittance) + exponential-height fog + volumetric-froxel
//     compose, ported 1:1 from b11 (matches the sibling HGRP_FogSimple_Fix port of the identical HG fog math).
// Removed (pixel-neutral pipeline infra substituted by URP, or sandbox-irrelevant):
//   - Motion vectors / SV_Target1 (HG_ENABLE_MV, _EnableTransparentMV, _Responsive output) — URP forward has no MV target.
//   - TAA jitter (_TaaJitterStrength), camera-relative-world reconstruction, _NonJitteredViewNoTransProjMatrix —
//     replaced by GetVertexPositionInputs (clip) + per-fragment world rebuild via UNITY_MATRIX_I_VP (b11 _InvViewProjMatrix path).
//   - SRP instancing (SRP_INSTANCING_ON), _GlobalMipBias global (-> SAMPLE_TEXTURE2D_BIAS with a material bias).
//
// NOTE: _VFXParams1 is an HGRP global (per-VFX color override): .xyz = per-channel multiply, .w = saturation lerp
//   (0 = fully desaturated to luminance, 1 = original). URP has no such global, so it is re-exposed as a material
//   Vector defaulting to (1,1,1,1) = identity grade. Luminance weights are the Rec.709 set baked in the blob.
//   _ExposureParams.x (post-exposure multiplier) is likewise re-exposed as a material Vector (default (1,0,0,0)).
// NOTE: the HG fog globals (_AtmosphereFogParams0-5 / _ExponentialFogParams0-5 / _VolumetricFogParams0-4) are HGRP
//   fog-volume globals with no URP equivalent; re-exposed as material Vectors (default 0 => the _USE_FOG branch is an
//   exact passthrough no-op: transmittance=1, inscatter=0). Same convention/naming as HGRP_FogSimple_Fix so a host
//   render-feature can bind both shaders' fog params with one block.
// ENGINE-SIDE: _VolumetricLightingTexture (b11 T0, Texture3D froxel) is produced by an HGRP VolumetricLighting compute
//   pass (camera-frustum froxel integration), not a material texture; URP has no such buffer. It is declared + sampled
//   1:1 (so wiring a host volumetric pass is a no-code-change) but reads neutral until that pass fills it.

Shader "HGRP/MattePainting_Fix"
{
    Properties
    {
        // Blend / render-state plumbing (driven by a material editor / OnValidate, not the shader)
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1

        // Surface controls
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 0
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1

        // Tint + emission boost
        _TintColor ("Tint Color", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity (Default 1)", Range(1, 100)) = 1
        _ExpThreshold ("Exp Threshold", Range(0, 1)) = 1
        _ExpIntensity ("Exp Intensity", Range(0, 100)) = 0
        _TintColorAlpha ("Tint Color Alpha (Default 1)", Range(0, 10)) = 1

        // Main texture
        _MainTex ("Main Tex", 2D) = "white" {}
        _MipBias ("Mip Bias", Float) = 0
        [ToggleUI] _UseMainTexAsAlpha ("Use MainTex As Alpha", Float) = 0

        // Color grade (HGRP _VFXParams1 re-exposed: .xyz channel multiply, .w saturation lerp)
        _VFXParams1 ("VFX Color Grade (.xyz=mul .w=saturation)", Vector) = (1, 1, 1, 1)
        // Post-exposure (HGRP _ExposureParams re-exposed: .x = post-exposure multiplier)
        _ExposureParams ("Exposure Params (.x=postExposure)", Vector) = (1, 0, 0, 0)

        // HG fog globals re-exposed so _USE_FOG stays 1:1 (no URP equivalent). Default 0 => fog branch inert.
        // (same names as HGRP_FogSimple_Fix so one host fog-volume bind feeds both.)
        _AtmosphereFogParams0 ("Atmosphere Fog 0", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams1 ("Atmosphere Fog 1", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams2 ("Atmosphere Fog 2", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams3 ("Atmosphere Fog 3", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams4 ("Atmosphere Fog 4", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams5 ("Atmosphere Fog 5", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams0 ("Exponential Fog 0", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams1 ("Exponential Fog 1", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams2 ("Exponential Fog 2", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams3 ("Exponential Fog 3", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams4 ("Exponential Fog 4", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams5 ("Exponential Fog 5", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams0 ("Volumetric Fog 0", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams1 ("Volumetric Fog 1", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams2 ("Volumetric Fog 2", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams3 ("Volumetric Fog 3", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams4 ("Volumetric Fog 4", Vector) = (0, 0, 0, 0)

        // Feature toggles
        [Toggle(_USE_FOG)] _UseFog ("Use Fog", Float) = 1
        [Toggle(_ALPHATEST_ON)] _UseAlphaTest ("Use Alpha Test", Float) = 0
        _AlphaClipThreshold ("Clip Threshold", Range(0, 1)) = 0.5
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Surface
                float _SurfaceType;
                float _BlendMode;
                float _IgnorePostExposure;
                // Tint + emission boost
                float4 _TintColor;
                float _TintColorIntensity;
                float _TintColorAlpha;
                float _ExpThreshold;
                float _ExpIntensity;
                // Main texture
                float4 _MainTex_ST;
                float _MipBias;
                float _UseMainTexAsAlpha;
                // Color grade / exposure (re-exposed HGRP globals)
                float4 _VFXParams1;
                float4 _ExposureParams;
                // HG fog globals (re-exposed; no URP equivalent — default 0 => _USE_FOG inert)
                float4 _AtmosphereFogParams0;
                float4 _AtmosphereFogParams1;
                float4 _AtmosphereFogParams2;
                float4 _AtmosphereFogParams3;
                float4 _AtmosphereFogParams4;
                float4 _AtmosphereFogParams5;
                float4 _ExponentialFogParams0;
                float4 _ExponentialFogParams1;
                float4 _ExponentialFogParams2;
                float4 _ExponentialFogParams3;
                float4 _ExponentialFogParams4;
                float4 _ExponentialFogParams5;
                float4 _VolumetricFogParams0;
                float4 _VolumetricFogParams1;
                float4 _VolumetricFogParams2;
                float4 _VolumetricFogParams3;
                float4 _VolumetricFogParams4;
                // Alpha clip
                float _AlphaClipThreshold;
            CBUFFER_END

            TEXTURE2D(_MainTex);        SAMPLER(sampler_MainTex);
            // HG volumetric froxel texture (b11 T0, Texture3D) — produced by an HGRP VolumetricLighting compute pass;
            // no URP source. Sampled 1:1 in the _USE_FOG froxel path; reads neutral (until a host pass binds it).
            TEXTURE3D(_VolumetricLightingTexture); SAMPLER(sampler_VolumetricLightingTexture);

            // Rec.709 luminance weights — baked in blob (Fragment_b7 line 103: dot(rgb, float3(0.2126729..,0.7151522..,0.0721750..)))
            static const float3 LUM709 = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625);

            // HG fog constants (b11). LOG2_E = log2(e) folds the blob's exp2(x*LOG2_E)==exp(x) spelling; VIEW_EPS = 1e-8
            // view-length floor (b11 _226 rsqrt floor); BLUE_UNPACK = 1/32766 (16-bit blue-noise unpack, b11 froxel taps).
            static const float LOG2_E      = 1.44269502162933349609375;
            static const float VIEW_EPS    = 9.9999999392252902907785028219223e-09;
            static const float BLUE_UNPACK = 3.05180437862873077392578125e-05;

            // expm1-style helper used by the HG exponential-height fog (b11 lines 181/201): (1 - exp2(-x))/x with a
            // series fallback near 0. The blob spells this inline as asfloat(|x|>5.96e-08 ? asuint((1-exp2(-x))/x)
            // : asuint(mad(-x, 0.2402265, 0.6931472))). source = Sub0_Pass0_Fragment_b11.hlsl:181
            float HgExpM1OverX(float x)
            {
                return (5.9604644775390625e-08 < abs(x))
                       ? ((((-0.0) - exp2((-0.0) - x)) + 1.0) / x)
                       : mad((-0.0) - x, 0.2402265071868896484375, 0.693147182464599609375);
            }

            // Core matte-painting color algorithm — 1:1 from Fragment_b7 lines 85-102.
            // Returns the exp-threshold-boosted, post-exposure-divided UNGRADED RGB (_135/_137/_138);
            // writes clamped tinted alpha to alphaOut. The _VFXParams1 luminance grade is applied SEPARATELY
            // (ApplyVFXGrade) so it runs AFTER fog, matching b11 ordering (fog -> grade), not before.
            // source = Sub0_Pass0_Fragment_b7.hlsl:85-102
            float3 ComputeMattePainting(float4 mainSample, out float alphaOut)
            {
                // _UseMainTexAsAlpha lerps each RGB channel toward 1.0 (b7 lines 91-93): mad(flag, 1-c, c) = lerp(c,1,flag)
                float r = mad(_UseMainTexAsAlpha, 1.0 - mainSample.x, mainSample.x);
                float g = mad(_UseMainTexAsAlpha, 1.0 - mainSample.y, mainSample.y);
                float b = mad(_UseMainTexAsAlpha, 1.0 - mainSample.z, mainSample.z);

                // Tint scaled by intensity (b7 lines 94-96)
                float tintR = _TintColorIntensity * _TintColor.x;
                float tintG = _TintColorIntensity * _TintColor.y;
                float tintB = _TintColorIntensity * _TintColor.z;

                // Alpha (b7 line 98): clamp( lerp(a, r, _UseMainTexAsAlpha) * _TintColorAlpha * _TintColor.w, 0, 1 )
                float texAlpha = mad(_UseMainTexAsAlpha, mainSample.x - mainSample.w, mainSample.w);
                alphaOut = clamp(texAlpha * (_TintColorAlpha * _TintColor.w), 0.0, 1.0);

                // Post-exposure scale (b7 line 99): lerp(1, _ExposureParams.x, _IgnorePostExposure)
                float exposureScale = mad(_ExposureParams.x, _IgnorePostExposure, 1.0 - _IgnorePostExposure);

                // Exp-threshold HDR boost then exposure divide, clamped to [0,1000] (b7 lines 100-102):
                //   col = min(max( mad( max(mad(tint, c, -_ExpThreshold), 0), _ExpIntensity, c*tint ) / exposureScale, 0), 1000)
                float negThreshold = -_ExpThreshold;
                float colR = min(max(mad(max(mad(tintR, r, negThreshold), 0.0), _ExpIntensity, r * tintR) / exposureScale, 0.0), 1000.0);
                float colG = min(max(mad(max(mad(tintG, g, negThreshold), 0.0), _ExpIntensity, g * tintG) / exposureScale, 0.0), 1000.0);
                float colB = min(max(mad(max(mad(tintB, b, negThreshold), 0.0), _ExpIntensity, b * tintB) / exposureScale, 0.0), 1000.0);

                return float3(colR, colG, colB);
            }

            // VFX luminance grade — 1:1 from Fragment_b7 lines 103-108 (and b11 lines 219-223, applied AFTER fog):
            //   lum = dot(col, LUM709); out = mad(_VFXParams1.w, col - lum, lum) * _VFXParams1.xyz
            // source = Sub0_Pass0_Fragment_b7.hlsl:103-108 / Sub0_Pass0_Fragment_b11.hlsl:219-223
            float3 ApplyVFXGrade(float3 col)
            {
                float lum = dot(col, LUM709);
                float3 graded;
                graded.x = mad(_VFXParams1.w, col.x - lum, lum) * _VFXParams1.x;
                graded.y = mad(_VFXParams1.w, col.y - lum, lum) * _VFXParams1.y;
                graded.z = mad(_VFXParams1.w, col.z - lum, lum) * _VFXParams1.z;
                return graded;
            }
        ENDHLSL

        Pass
        {
            Name "ForwardOnly"
            Tags { "LightMode" = "UniversalForwardOnly" }

            Blend [_SrcBlend] [_DstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            // 4.5: the _USE_FOG froxel path needs SM4.5 integer (PCG hash) + Texture3D LOD ops (source was target 5.0);
            // mirrors HGRP_FogSimple_Fix.
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_FOG
            #pragma shader_feature_local _ALPHATEST_ON

            struct Attributes
            {
                float3 positionOS : POSITION;
                float2 texcoord   : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
            };

            Varyings vert(Attributes v)
            {
                Varyings o = (Varyings)0;
                // HGRP rebuilt clip pos from camera-relative world + jittered VP (Vertex_b6 lines 59-68);
                // URP infra equivalent — GetVertexPositionInputs gives both clip and world pos.
                VertexPositionInputs vp = GetVertexPositionInputs(v.positionOS);
                o.positionCS = vp.positionCS;
                // Sample-UV: the matte-painting vertex packs uv = rawUV * objectWorldOrigin.{x,y} + objectWorldOrigin.{z,w}
                // (Vertex_b6 lines 72-73: mad(uv.x, OTW[3].x, OTW[3].z), mad(uv.y, OTW[3].y, OTW[3].w)).
                // OTW[3] is the 4th column of unity_ObjectToWorld = (_m03,_m13,_m23,_m33) = object world translation.
                // This is NOT TRANSFORM_TEX(_MainTex_ST) — the blob never reads _MainTex_ST at the sample site.
                // source = Sub0_Pass0_Vertex_b6.hlsl:72-73
                o.uv = float2(
                    mad(v.texcoord.x, unity_ObjectToWorld._m03, unity_ObjectToWorld._m23),
                    mad(v.texcoord.y, unity_ObjectToWorld._m13, unity_ObjectToWorld._m33));
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                // MainTex sample with mip bias (b7 line 86: T0.SampleBias(sampler_LinearClamp, uv, _GlobalMipBias))
                float4 mainSample = SAMPLE_TEXTURE2D_BIAS(_MainTex, sampler_MainTex, input.uv, _MipBias);

                float alpha;
                // UNGRADED boosted color (_135/_137/_138). The _VFXParams1 grade is applied LAST (after fog).
                float3 color = ComputeMattePainting(mainSample, alpha);

                // Alpha clip (b11 line 121: discard when alpha < _AlphaClipThreshold)
                #ifdef _ALPHATEST_ON
                    clip(alpha - _AlphaClipThreshold);
                #endif

                // Fog runs on the UNGRADED color, BEFORE the VFX grade — matching b11 ordering:
                //   _967 = mad(_266, atmTrans*fogOpacity, (1-_BlendMode)*inscatter)  (b11:216, pre-grade _266/_268/_269),
                //   then SV_Target = ApplyVFXGrade(_967/_968/_969)                   (b11:219-223).
                // Ported 1:1 from b11; the analytic atmosphere + exponential-height fog is pure formula on the
                // re-exposed HG fog Vectors, the volumetric branch samples the froxel Texture3D (engine-side, neutral
                // until a host VolumetricLighting pass fills it). Mirrors the sibling HGRP_FogSimple_Fix fog port.
                #ifdef _USE_FOG
                {
                    // ---- reconstruct THIS fragment's world position from screen NDC + depth (b11 lines 122-127) ----
                    // b11 spells mul(_InvViewProjMatrix, clip) via column-major access; URP's UNITY_MATRIX_I_VP is
                    // row-major so the 1:1 equivalent is the direct mul (NOT a literal index transcription, which would
                    // transpose). _125/_129 bake the Y-flip into NDC (b11:122-123) so we feed clip straight to I_VP.
                    // source = Sub0_Pass0_Fragment_b11.hlsl:122-127
                    float2 fogNdc = float2(
                        mad(input.positionCS.x / _ScaledScreenParams.x, 2.0, -1.0),
                        (-0.0) - mad(input.positionCS.y / _ScaledScreenParams.y, 2.0, -1.0));
                    float4 fogClip = float4(fogNdc.x, fogNdc.y, input.positionCS.z, 1.0);
                    float4 fogWorldH = mul(UNITY_MATRIX_I_VP, fogClip);
                    float3 worldP = fogWorldH.xyz / fogWorldH.w;

                    // view ray toward camera (perspective) or fixed camera-forward (ortho) (b11 lines 128-137).
                    // b11 _183 = (0 == ortho.w) => perspective; persp = camPos - worldP, ortho = ViewMatrix col-2 (cam fwd).
                    bool fogPersp = (0.0 == unity_OrthoParams.w);
                    float3 fogViewVec = fogPersp
                        ? (((-0.0) - worldP) + _WorldSpaceCameraPos)
                        : UNITY_MATRIX_V[2].xyz;
                    float fogViewLenSq = dot(fogViewVec, fogViewVec);                  // b11 _221
                    float fogInvLen    = rsqrt(max(fogViewLenSq, VIEW_EPS));            // b11 _226
                    float3 rayDir      = fogViewVec * fogInvLen;                        // b11 _227/_228/_229
                    float rayLenView   = fogViewLenSq * fogInvLen;                      // b11 _230 = |viewVec|

                    // view-space Z (camera distance along forward) for the froxel + masks (b11 _450).
                    float viewZ = mad(UNITY_MATRIX_V[2].z, worldP.z, mad(UNITY_MATRIX_V[2].x, worldP.x, worldP.y * UNITY_MATRIX_V[2].y)) + UNITY_MATRIX_V[2].w;

                    float blendInv = 1.0 + ((-0.0) - _BlendMode);                      // b11 _963 = 1 - _BlendMode

                    // ---- atmosphere transmittance + phase (b11 lines 149-155, 213-214), all from _AtmosphereFogParams* ----
                    // aDen/aOpt: height-attenuated optical depth along the ray (b11 _349/_381).
                    float aDen = max(mad(worldP.y, _AtmosphereFogParams3.w, _AtmosphereFogParams4.w), 0.00999999977648258209228515625);
                    float aOpt = ((((((-0.0) - exp2(aDen * (-LOG2_E))) + 1.0) / aDen)
                                   * exp2(mad(worldP.y, _AtmosphereFogParams3.w, _AtmosphereFogParams5.w) * LOG2_E)))
                                 * ((-0.0) - max(mad(rayLenView, _AtmosphereFogParams1.w, (-0.0) - _AtmosphereFogParams0.w), 0.0));
                    float aTransR = exp2((aOpt * _AtmosphereFogParams2.x) * LOG2_E);   // b11 _394
                    float aTransG = exp2((aOpt * _AtmosphereFogParams2.y) * LOG2_E);   // b11 _395
                    float aTransB = exp2((aOpt * _AtmosphereFogParams2.z) * LOG2_E);   // b11 _396
                    float aCos = dot(float3((-0.0) - rayDir.x, (-0.0) - rayDir.y, (-0.0) - rayDir.z),
                                     float3(_AtmosphereFogParams1.x, _AtmosphereFogParams1.y, _AtmosphereFogParams1.z)); // b11 _405
                    float aPhaseDen = mad(_AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0) + ((-0.0) - dot(aCos.xx, _AtmosphereFogParams2.w.xx)); // b11 _422
                    float rayleighPh = mad(aCos, aCos, 1.0) * 0.0596831031143665313720703125;   // b11 _902 = (1+cos^2)*3/(16pi)
                    float miePh      = mad((-0.0) - _AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0)
                                       / max(sqrt(aPhaseDen) * (aPhaseDen * 12.56637096405029296875), 0.001000000047497451305389404296875); // b11 _931

                    // ---- exponential-height + volumetric-froxel transmittance(_894) & inscatter(_895/_896/_897) ----
                    float fogDensity = 0.0;            // b11 _894
                    float3 fogColor  = float3(0.0, 0.0, 0.0); // b11 _895/_896/_897
                    if (0.0 < _VolumetricFogParams0.z)
                    {
                        // --- volumetric froxel path (b11 lines 160-195) ---
                        uint px = uint(input.positionCS.x);   // b11 _432
                        uint py = uint(input.positionCS.y);   // b11 _433
                        // PCG-ish hash chain seeded by pixel + frame (b11 lines 165-170). Source used _FrameCount;
                        // _Time.w (URP) is the nearest per-frame analog (matches HGRP_FogSimple_Fix).
                        uint h0 = (py * 1664525u) + 1013904223u;                                  // b11 _462
                        uint h1 = ((7u & (uint)_Time.w) * 1664525u) + 1013904223u;                // b11 _464
                        uint h2 = (h0 * h1) + ((px * 1664525u) + 1013904223u);                    // b11 _466
                        uint h3 = (h1 * h2) + h0;                                                 // b11 _468
                        uint h4 = (h2 * h3) + h1;                                                 // b11 _470
                        uint h5 = (h3 * h4) + h2;                                                 // b11 _472

                        float camForwardDotRay = dot(float3((-0.0) - rayDir.x, (-0.0) - rayDir.y, (-0.0) - rayDir.z),
                                                     float3((-0.0) - UNITY_MATRIX_V[2].x, (-0.0) - UNITY_MATRIX_V[2].y, (-0.0) - UNITY_MATRIX_V[2].z)); // b11 _479
                        float heightAboveCam = worldP.y + ((-0.0) - _WorldSpaceCameraPos.y);      // b11 _486
                        float marchScale = asfloat(asuint(1.0 / camForwardDotRay) & ((5.9604644775390625e-08 < camForwardDotRay) ? 0xffffffffu : 0u)) * _VolumetricFogParams0.w; // b11 _497
                        float invRayLen = 1.0 / rayLenView;                                       // b11 _498
                        float marchT    = marchScale * invRayLen;                                 // b11 _499
                        float sampleY   = mad(marchT, heightAboveCam, _WorldSpaceCameraPos.y);    // b11 _503
                        float remHeight = mad((-0.0) - marchT, heightAboveCam, heightAboveCam);   // b11 _505
                        float remFrac   = mad((-0.0) - marchScale, invRayLen, 1.0);               // b11 _507

                        float e0 = max(remHeight * _ExponentialFogParams0.z, -127.0);             // b11 _521
                        float e3 = max(remHeight * _ExponentialFogParams3.x, -127.0);             // b11 _519
                        float fogIntegral = mad(
                            exp2((-0.0) - max((sampleY + ((-0.0) - _ExponentialFogParams0.x)) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                            HgExpM1OverX(e0),
                            HgExpM1OverX(e3) * (exp2((-0.0) - max((sampleY + ((-0.0) - _ExponentialFogParams3.z)) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y)); // b11 _583
                        float baseDen  = clamp(mad(rayLenView, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0); // b11 _595
                        float totalDen = min(baseDen + (clamp(mad(rayLenView, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                                         + max(min(exp2((-0.0) - ((rayLenView * remFrac) * fogIntegral)), 1.0), _ExponentialFogParams2.w)), 1.0); // b11 _608

                        // froxel scattering color from the volumetric 3D texture (b11 line 184):
                        // X-tap = h5>>16, Y-tap = (h4*h5 + h3)>>16, Z = log2(mad(|viewZ|,VOL1.x,VOL1.y))*VOL1.z / VOL0.z.
                        float3 froxelUVW = float3(
                            mad(mad(float(h5 >> 16u), BLUE_UNPACK, -1.0), _VolumetricFogParams4.w, float(px)) * _VolumetricFogParams2.x,
                            mad(mad(float(((h4 * h5) + h3) >> 16u), BLUE_UNPACK, -1.0), _VolumetricFogParams4.w, float(py)) * _VolumetricFogParams2.y,
                            (log2(mad(abs(viewZ), _VolumetricFogParams1.x, _VolumetricFogParams1.y)) * _VolumetricFogParams1.z) / _VolumetricFogParams0.z);
                        float4 froxel = SAMPLE_TEXTURE3D_LOD(_VolumetricLightingTexture, sampler_VolumetricLightingTexture, froxelUVW, 0.0); // b11 _654
                        float froxelMask  = clamp((abs(viewZ) + ((-0.0) - _VolumetricFogParams3.z)) * 1000000.0, 0.0, 1.0); // b11 _669
                        float froxelTrans = mad(froxelMask, froxel.w + (-1.0), 1.0);              // b11 _677
                        float invTotalDen = ((-0.0) - totalDen) + 1.0;                            // b11 _679
                        float heightCol = exp2(log2(clamp(dot(rayDir, float3(_ExponentialFogParams4.x, _ExponentialFogParams4.y, _ExponentialFogParams4.z)), 0.0, 1.0)) * _ExponentialFogParams5.w); // b11 _696
                        float dirTrans  = ((-0.0) - min(exp2((-0.0) - (max(mad(remFrac, rayLenView, (-0.0) - _ExponentialFogParams4.w), 0.0) * fogIntegral)), 1.0)) + 1.0; // b11 _716
                        float invBaseDen = ((-0.0) - baseDen) + 1.0;                              // b11 _721
                        fogDensity = totalDen * froxelTrans;                                      // b11 _894
                        fogColor.x = mad(mad(_ExponentialFogParams2.x, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.x))), froxelTrans, mad(froxelMask, froxel.x + (-0.0), 0.0)); // b11 _895
                        fogColor.y = mad(mad(_ExponentialFogParams2.y, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.y))), froxelTrans, mad(froxelMask, froxel.y + (-0.0), 0.0)); // b11 _896
                        fogColor.z = mad(mad(_ExponentialFogParams2.z, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.z))), froxelTrans, mad(froxelMask, froxel.z + (-0.0), 0.0)); // b11 _897
                    }
                    else
                    {
                        // --- analytic exponential-height fog path, no froxel (b11 lines 198-211) ---
                        float heightAboveCam = worldP.y + ((-0.0) - _WorldSpaceCameraPos.y);      // b11 _741
                        float e3 = max(heightAboveCam * _ExponentialFogParams3.x, -127.0);        // b11 _750
                        float e0 = max(heightAboveCam * _ExponentialFogParams0.z, -127.0);        // b11 _751
                        float fogIntegral = mad(
                            exp2((-0.0) - max((_WorldSpaceCameraPos.y + ((-0.0) - _ExponentialFogParams0.x)) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                            HgExpM1OverX(e0),
                            HgExpM1OverX(e3) * (exp2((-0.0) - max((_WorldSpaceCameraPos.y + ((-0.0) - _ExponentialFogParams3.z)) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y)); // b11 _817
                        float baseDen  = clamp(mad(rayLenView, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0); // b11 _828
                        float totalDen = min(baseDen + (clamp(mad(rayLenView, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                                         + max(min(exp2((-0.0) - (rayLenView * fogIntegral)), 1.0), _ExponentialFogParams2.w)), 1.0); // b11 _840
                        float invTotalDen = ((-0.0) - totalDen) + 1.0;                            // b11 _842
                        float heightCol = exp2(log2(clamp(dot(rayDir, float3(_ExponentialFogParams4.x, _ExponentialFogParams4.y, _ExponentialFogParams4.z)), 0.0, 1.0)) * _ExponentialFogParams5.w); // b11 _857
                        // dirTrans uses fogViewLenSq*fogInvLen == rayLenView (b11 _877 spells mad(_221,_226,...)).
                        float dirTrans  = ((-0.0) - min(exp2((-0.0) - (max(mad(fogViewLenSq, fogInvLen, (-0.0) - _ExponentialFogParams4.w), 0.0) * fogIntegral)), 1.0)) + 1.0; // b11 _877
                        float invBaseDen = ((-0.0) - baseDen) + 1.0;                              // b11 _882
                        fogDensity = totalDen;                                                    // b11 _894
                        fogColor.x = mad(_ExponentialFogParams2.x, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.x))); // b11 _895
                        fogColor.y = mad(_ExponentialFogParams2.y, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.y))); // b11 _896
                        fogColor.z = mad(_ExponentialFogParams2.z, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.z))); // b11 _897
                    }

                    // ---- compose atmosphere transmittance*card + (1-_BlendMode)*(atmosphere inscatter + height inscatter)
                    // directly onto the ungraded card color (b11 lines 216-218). Unlike HGRP_FogSimple_Fix there is NO
                    // _FogIntensity/distance lerp here — the matte card replaces its color outright. ----
                    float3 fogged;
                    fogged.x = mad(color.x, aTransR * fogDensity, blendInv * mad((((-0.0) - aTransR) + 1.0) * (clamp(mad(_AtmosphereFogParams4.x, miePh, mad(_AtmosphereFogParams3.x, rayleighPh, _AtmosphereFogParams5.x)), 0.0, 1.0) * 255.0), fogDensity, fogColor.x)); // b11 _967
                    fogged.y = mad(color.y, aTransG * fogDensity, blendInv * mad((((-0.0) - aTransG) + 1.0) * (clamp(mad(_AtmosphereFogParams4.y, miePh, mad(_AtmosphereFogParams3.y, rayleighPh, _AtmosphereFogParams5.y)), 0.0, 1.0) * 255.0), fogDensity, fogColor.y)); // b11 _968
                    fogged.z = mad(color.z, aTransB * fogDensity, blendInv * mad((((-0.0) - aTransB) + 1.0) * (clamp(mad(_AtmosphereFogParams4.z, miePh, mad(_AtmosphereFogParams3.z, rayleighPh, _AtmosphereFogParams5.z)), 0.0, 1.0) * 255.0), fogDensity, fogColor.z)); // b11 _969
                    color = fogged;
                }
                #endif

                // VFX luminance grade is the FINAL color op in BOTH blobs (b7:103-108 / b11:219-223). Apply after fog.
                color = ApplyVFXGrade(color);

                // Output alpha. BASE b7 (line 105) writes SV_Target.w = _115 (clamped tinted alpha) UNCONDITIONALLY —
                // no _SurfaceType gate, no (1-_BlendMode) premultiply. Additive-vs-alpha is delegated to the Blend STATE.
                // source = Sub0_Pass0_Fragment_b7.hlsl:105
                return half4(color, alpha);
            }
            ENDHLSL
        }
    }
    Fallback Off
}
