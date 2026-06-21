// Merged HGRP CharacterNPR Cloth shader — ForwardLit + Outline.
// Merged from: 39815923 (cloth_01), 677bb616 (cloth_04), 6b74f564 (cloth_02), 4aedaa52 (cloth_03, transparent)
// Keywords: _CLEARCOAT, _PARALLAX_MAP, _NORMALMAP, _DIFF_RAMP_ON, _METALLICSPECGLOSSMAP, _SPEC_RAMP_ON, _EMISSION, _OUTLINE_MASK, _PANTYHOSE
// Kept: Normal Map, Diffuse Ramp (with wrap-lighting), Shadow Color (brightness/saturation),
//   MetallicGlossMap, Spec Ramp, GGX Specular, Skin Specular (CP8/CP9), Subsurface,
//   Emission, Cubemap Reflection (_CharMaxCubemap), Character Outline with Outline Mask (full NPR lighting),
//   VFX Color Adjustment, Alpha Premultiply (transparent support via _SurfaceType).
// Removed: GPU skinning, instancing, TAA jitter, motion vectors, rain/wet, all shadows,
//   SDF lightmap, fog, IV clipmap, punctual lights, dissolve.
//
// NOTE: CharacterParams numbering differs from Skin variant!
//   Cloth CP2 = ambient color (Skin CP3), Cloth CP5 = light color override (Skin CP4).
//
// Outline Mask: _OutlineMask texture R = outline width multiplier, G = Z offset multiplier.

Shader "HGRP/CharacterNPR_Fix" {
    Properties {
        _BaseColor ("Color", Color) = (1, 1, 1, 1)
        _BaseMap ("Albedo", 2D) = "white" {}
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _Cull ("Render Face", Float) = 0
        [Enum(On, 0, Off, 1)] _BackFaceNormalFlip ("Back Face Normal Flip", Float) = 0
        [HideInInspector] _AlphaPremultiply ("Alpha Premultiply", Float) = 0
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 0
        [Toggle(_ALPHATEST_ON)] _AlphaClip ("Alpha Clip", Float) = 0
        _AlphaClipThreshold ("Alpha Clip Threshold", Range(0, 1)) = 0.5

        [Toggle(_SHADOW_LUT_TEX)] _UseShadowLutTex ("Use Shadow LUT", Float) = 0
        _ShadowLutTex ("Shadow Color LUT", 2D) = "white" {}
        _ShadowColorBrightness ("Shadow Color Brightness", Range(0, 1)) = 0.5
        _ShadowColorSaturation ("Shadow Color Saturation", Range(0, 2)) = 1

        [Toggle(_METALLICSPECGLOSSMAP)] _UseMetallicGlossMap ("Use MetallicGlossMap", Float) = 1
        [Gamma] _Metallic ("Metallic", Range(0, 1)) = 0.839
        _Specular ("Specular Scale", Range(0, 1)) = 1
        _Smoothness ("Smoothness", Range(0, 1)) = 0.406
        _MetallicGlossMap ("RGBA: Metal,Spec,Shadow,Smooth", 2D) = "white" {}

        [Toggle(_NORMALMAP)] _UseBumpMap ("Use Normal Map", Float) = 1
        _BumpScale ("Normal Scale", Float) = 1
        _BumpMap ("Normal Map", 2D) = "bump" {}

        [Toggle(_DIFF_RAMP_ON)] _UseDiffRampMap ("Diffuse Ramp", Float) = 1
        _DiffRampMap ("Diffuse Ramp", 2D) = "white" {}

        [Toggle(_SPEC_RAMP_ON)] _UseSpecRampMap ("Specular Ramp", Float) = 1
        _SpecRampMap ("Specular Ramp", 2D) = "white" {}
        [ToggleUI] _SpecRampIridescentMode ("Iridescent Mode", Float) = 0

        [Toggle(_EMISSION)] _UseEmission ("Use Emission", Float) = 1
        _EmissionColor ("Emission Color", Color) = (0, 0, 0, 1)
        _EmissionBrightness ("Emission Brightness", Float) = 1
        _EmissionMap ("Emission", 2D) = "black" {}

        [HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}

        [Header(Cubemap)]
        _CharMaxCubemap ("Cubemap", Cube) = "" {}
        _CubemapIntensity ("Cubemap Intensity", Float) = 1

        [Header(Outline)]
        [ToggleUI] _EnableOutline ("Enable Outline", Float) = 1
        _OutlineWidth ("Outline Width", Range(0, 2)) = 0.5
        _OutlineOffsetZ ("Outline Offset Z", Range(0, 1)) = 0.0
        _OutlineColorBrightness ("Outline Color Brightness", Range(0, 1)) = 0.5
        _OutlineColorSaturation ("Outline Color Saturation", Range(0, 2)) = 1.5
        [ToggleUI] _OutlineAverageNormal ("Use Smooth Normal (UV2)", Float) = 1
        [ToggleUI] _OutlineTintEnable ("Outline Tint Enable", Float) = 0
        _OutlineTintColor ("Outline Tint Color", Color) = (1, 1, 1, 1)
        [Toggle(_OUTLINE_MASK)] _EnableOutlineMask ("Outline Mask Enable", Float) = 1
        _OutlineMask ("Outline Mask", 2D) = "white" {}

        [Header(VFX Color Adjustment)]
        [ToggleUI] _EnableVFXColorAdjustment ("VFX Color Adjustment", Float) = 0
        _ColorAdjustmentBrightness ("Color Adjustment Brightness", Range(0.5, 1.5)) = 1
        _ColorAdjustmentSaturation ("Color Adjustment Saturation", Range(0, 2)) = 1
        _ColorAdjustmentContrast ("Color Adjustment Contrast", Range(0, 2)) = 1
        _ColorAdjustmentColorBlend ("Color Adjustment Color Blend", Color) = (1, 1, 1, 0)
        _ColorAdjustmentRimWidth ("Color Adjustment Rim Width", Range(0, 1)) = 0.35
        _ColorAdjustmentRimIntensity ("Color Adjustment Rim Intensity", Range(0, 10)) = 4
        _ColorAdjustmentRimColor ("Color Adjustment Rim Color", Color) = (1, 1, 1, 1)

        [Header(Pantyhose)]
        [Toggle(_PANTYHOSE)] _Pantyhose ("Pantyhose Effect", Float) = 0
        _PantyhoseColor ("Pantyhose Color", Color) = (0.36, 0.17, 0.16, 0.5)
        _PantyhoseSpecularInt ("Pantyhose Specular Intensity", Range(0, 0.5)) = 0
        _PantyhoseSpecularValue ("Pantyhose Specular Offset", Range(-2, 2)) = 0
        _PantyhoseAnisotropyDirection ("Pantyhose Anisotropy", Range(-1, 1)) = 0

        [Header(ClearCoat)]
        [Toggle(_CLEARCOAT)] _ClearCoat ("ClearCoat Effect", Float) = 0
        _ClearCoatMask ("ClearCoat Mask", 2D) = "white" {}
        _ClearCoatColor ("ClearCoat Color", Color) = (1, 1, 1, 1)
        _ClearCoatSmoothness ("ClearCoat Smoothness", Range(0, 1)) = 0.95
        _ClearCoatMetallic ("ClearCoat Metallic", Range(0, 1)) = 0
        [Enum(Vertex, 0, Texture, 1)] _ClearCoatNormalMode ("ClearCoat Normal", Float) = 0

        [Header(Parallax)]
        [Toggle(_PARALLAX_MAP)] _UseParallax ("Parallax Map", Float) = 0
        _ParallaxTex ("Parallax Tex", 2D) = "black" {}
        _ParallaxMarchNum ("Parallax March Steps", Range(1, 5)) = 2
        _ParallaxScale ("Parallax Scale", Range(0, 1)) = 0.3
        [HDR] _ParallaxColor ("Parallax Color", Color) = (1, 1, 1, 1)

        [Header(Character Params)]
        _CharacterParams0 ("CP0 (.y=diffuse .z=shadow .w=brightness)", Vector) = (0, 1, 0.7, 1)
        _CharacterParams1 ("CP1 (.x=brightMix .y=shadowStr .z=shadowLerp .w=lightDirOverride)", Vector) = (0, 0, 0, 0)
        _CharacterParams2 ("CP2 (ambient color rgb)", Vector) = (1, 1, 1, 0)
        _CharacterParams5 ("CP5 (light color override rgb)", Vector) = (1, 1, 1, 1)
        _CharacterParams6 ("CP6 (ambient direction)", Vector) = (0, 1, 0, 0)
        _CharacterParams7 ("CP7 (.x=offset .y=scale .z=bias)", Vector) = (0.15, 0.6, 1, 0)
        _CharacterParams8 ("CP8 (skin spec color rgb + .w=intensity)", Vector) = (0, 0, 0, 1)
        _CharacterParams9 ("CP9 (skin spec .xy=dir .z=tint .w=width)", Vector) = (0, 1, 0, 0.4)
        _CharacterParams11 ("CP11 (light dir override xyz + .w=rampBias)", Vector) = (-0.433, 0.5, 0.75, 0)
        _CharacterParams12 ("CP12 (.x=rampOffset .y=lightColOverride .z=shadowGate .w=exposureBlend)", Vector) = (0, 0, 0, 0)
        _CharacterParams13 ("CP13 (.w=GGX specular toggle)", Vector) = (0, 0, 0, 1)
        _EnvironmentGlobalParams0 ("EnvGlobalParams0", Vector) = (1.67, 1.5, 1, 0)
        _ExposureParams ("ExposureParams", Vector) = (1, 0, 0, 0)

        [Header(Workarounds)]
        _ShadowBlurRadius ("Shadow Blur Radius (Screen Space)", Range(0, 8)) = 2.5

        // Behind-Hair Composite stencil (clear hair marker bit5 to prevent overdraw on body/cloth/hat)
        [HideInInspector] _StencilRef ("Stencil Ref", Float) = 0
        [HideInInspector] _StencilClearMask ("Stencil Write Mask", Float) = 32

        [Toggle(_USE_GROUND_TRUTH_AO)] _UseGroundTruthAO ("Use Ground Truth Ambient Occlusion", Float) = 0
        [Toggle(_USE_ALCHEMY_AO)] _UseAlchemyAO ("Use Alchemy Ambient Occlusion", Float) = 0
    }
    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Opaque" }
        LOD 600

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "CustomAOSample.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _BaseColor;
                float4 _BaseMap_ST;
                float _ShadowColorBrightness;
                float _ShadowColorSaturation;
                float _Metallic;
                float _Specular;
                float _Smoothness;
                float _BackFaceNormalFlip;
                float _AlphaPremultiply;
                float _SurfaceType;
                float _AlphaClipThreshold;
                float _ShadowBlurRadius;
                float _BumpScale;
                float _SpecRampIridescentMode;
                float4 _EmissionColor;
                float _EmissionBrightness;
                float _CubemapIntensity;
                // Outline
                float _EnableOutline;
                float _OutlineWidth;
                float _OutlineOffsetZ;
                float _OutlineColorBrightness;
                float _OutlineColorSaturation;
                float _OutlineAverageNormal;
                float _OutlineTintEnable;
                float4 _OutlineTintColor;
                // VFX Color Adjustment
                float _EnableVFXColorAdjustment;
                float _ColorAdjustmentBrightness;
                float _ColorAdjustmentSaturation;
                float _ColorAdjustmentContrast;
                float _ColorAdjustmentRimWidth;
                float _ColorAdjustmentRimIntensity;
                float4 _ColorAdjustmentColorBlend;
                float4 _ColorAdjustmentRimColor;
                // Pantyhose
                float4 _PantyhoseColor;
                float _PantyhoseSpecularInt;
                float _PantyhoseSpecularValue;
                float _PantyhoseAnisotropyDirection;
                // ClearCoat
                float4 _ClearCoatColor;
                float _ClearCoatSmoothness;
                float _ClearCoatMetallic;
                float _ClearCoatNormalMode;
                // Parallax
                float4 _ParallaxTex_ST;
                float _ParallaxMarchNum;
                float _ParallaxScale;
                float4 _ParallaxColor;
                // Character params (cloth variant numbering)
                float4 _CharacterParams0;
                float4 _CharacterParams1;
                float4 _CharacterParams2;  // ambient color (Skin uses CP3)
                float4 _CharacterParams5;  // light color override (Skin uses CP4)
                float4 _CharacterParams6;
                float4 _CharacterParams7;
                float4 _CharacterParams8;
                float4 _CharacterParams9;
                float4 _CharacterParams11;
                float4 _CharacterParams12;
                float4 _CharacterParams13;
                float4 _EnvironmentGlobalParams0;
                float4 _ExposureParams;
            CBUFFER_END

            TEXTURE2D(_BaseMap);          SAMPLER(sampler_BaseMap);
            TEXTURE2D(_BumpMap);          SAMPLER(sampler_BumpMap);
            TEXTURE2D(_MetallicGlossMap); SAMPLER(sampler_MetallicGlossMap);
            TEXTURE2D(_DiffRampMap);      SAMPLER(sampler_DiffRampMap);
            TEXTURE2D(_SpecRampMap);      SAMPLER(sampler_SpecRampMap);
            TEXTURE2D(_EmissionMap);      SAMPLER(sampler_EmissionMap);
            TEXTURE2D(_OutlineMask);      SAMPLER(sampler_OutlineMask);
            TEXTURE2D(_ClearCoatMask);    SAMPLER(sampler_ClearCoatMask);
            TEXTURE2D(_ParallaxTex);      SAMPLER(sampler_ParallaxTex);
            TEXTURE2D(_ShadowLutTex);     SAMPLER(sampler_ShadowLutTex);
            TEXTURECUBE(_CharMaxCubemap); SAMPLER(sampler_CharMaxCubemap);

            static const float3 LUM = float3(0.2126729, 0.7152, 0.07217500);
            static const float NEAR_ZERO_Y = 6.103515625e-05; // asfloat(947912704u)

            float LinearToSRGB_Custom(float c) {
                return (c <= 0.0031308) ? (c * 12.92)
                    : (1.055 * pow(abs(c), 0.41666666) - 0.055);
            }

            // Environment BRDF rational approximation (decompiled lines 2320-2328)
            void ComputeEnvBRDF(float NdotV, float roughSq, out float dfgX, out float dfgY) {
                float NdotV2 = NdotV * NdotV;
                float NdotV3 = NdotV * NdotV2;
                float roughSq6 = roughSq * roughSq * roughSq;

                float2 numX = float2(
                    dot(float2(3.32707, 1.0), float2(NdotV, 0.0365463)),
                    dot(float2(-9.04756, 1.0), float2(NdotV, 9.0632))
                );
                float3 denX = float3(
                    dot(float3(3.59685, -1.36772, 1.0), float3(NdotV2, NdotV3, 1.0)),
                    dot(float3(-16.3174, 1.0, 9.22949), float3(NdotV2, 9.04401, NdotV3)),
                    dot(float3(1.0, 19.7886, -20.2123), float3(5.56589, NdotV2, NdotV3))
                );
                dfgX = dot(numX, float2(1.0, roughSq)) / dot(denX, float3(1.0, roughSq, roughSq6));

                float2 numY = float2(
                    dot(float2(-1.28514, 1.0), float2(NdotV, 0.99044)),
                    dot(float2(1.0, -0.755907), float2(1.29678, NdotV))
                );
                float3 denY = float3(
                    dot(float3(2.92338, 59.4188, 1.0), float3(NdotV, NdotV3, 1.0)),
                    dot(float3(1.0, -27.0302, 222.592), float3(20.3225, NdotV, NdotV3)),
                    dot(float3(626.13, 316.627, 1.0), float3(NdotV, NdotV3, 121.563))
                );
                dfgY = dot(numY, float2(1.0, roughSq)) / dot(denY, float3(1.0, roughSq, roughSq6));
            }

            // ================================================================
            // Shared NPR lighting — used by both ForwardLit and Outline passes
            // albedo: already processed (raw for ForwardLit, brightness/saturation adjusted for Outline)
            // ================================================================
            float3 computeNPRLighting(float2 uv, float3 positionWS, float3 normalWS_raw, float4 tangentWS, float faceSign, float3 albedo, float baseAlpha, out float3 shadowColorOut) {
                // ---- Object-to-World origin ----
                float originX = unity_ObjectToWorld._m03;
                float originZ = unity_ObjectToWorld._m23;

                // ---- View direction ----
                float3 toCam = _WorldSpaceCameraPos - positionWS;
                float3 orthoFwd = float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22);
                float3 viewRaw = toCam + unity_OrthoParams.w * (orthoFwd - toCam);
                float3 V = normalize(viewRaw);

                // ---- MetallicGlossMap ----
                float metallic, specScale, shadowMask, smoothness;
                #ifdef _METALLICSPECGLOSSMAP
                    float4 mgSample = SAMPLE_TEXTURE2D(_MetallicGlossMap, sampler_MetallicGlossMap, uv);
                    metallic   = mgSample.r;
                    specScale  = mgSample.g;
                    shadowMask = mgSample.b;
                    smoothness = mgSample.a;
                #else
                    metallic   = _Metallic;
                    specScale  = _Specular;
                    shadowMask = 1.0;
                    smoothness = _Smoothness;
                #endif
                float roughnessRaw = 1.0 - smoothness;

                // ---- Shadow color ----
                float3 shadowColor;
                #ifdef _SHADOW_LUT_TEX
                    float sR = saturate(LinearToSRGB_Custom(albedo.r));
                    float sG = saturate(LinearToSRGB_Custom(albedo.g));
                    float sB = saturate(LinearToSRGB_Custom(albedo.b));
                    float bSlice = floor(sB * 31.0);
                    float lutU = bSlice * 0.03125 + sR * 0.0302734375 + 0.00048828125;
                    float lutV = sG * 0.96875 + 0.015625;
                    float4 lut0 = SAMPLE_TEXTURE2D_LOD(_ShadowLutTex, sampler_ShadowLutTex, float2(lutU, lutV), 0);
                    float4 lut1 = SAMPLE_TEXTURE2D_LOD(_ShadowLutTex, sampler_ShadowLutTex, float2(lutU + 0.03125, lutV), 0);
                    float bFrac = sB * 31.0 - bSlice;
                    shadowColor = lerp(lut0.rgb, lut1.rgb, bFrac);
                #else
                    float3 shadBright = albedo * _ShadowColorBrightness;
                    float shadLum = dot(shadBright, LUM);
                    shadowColor = _ShadowColorSaturation * (shadBright - shadLum) + shadLum;
                #endif

                // ---- Normal map ----
                float3 N;
                #ifdef _NORMALMAP
                    float4 nrmSmp = SAMPLE_TEXTURE2D(_BumpMap, sampler_BumpMap, uv);
                    float nrmX = (nrmSmp.x * nrmSmp.w * 2.0 - 1.0) * _BumpScale;
                    float nrmY = (nrmSmp.y * 2.0 - 1.0) * _BumpScale;
                    float nrmZ = max(sqrt(1.0 - saturate(nrmX*nrmX + nrmY*nrmY)), 1e-16);
                    float3 nrmWS = normalize(normalWS_raw);
                    float3 tanWS = normalize(tangentWS.xyz);
                    float3 bitWS = cross(nrmWS, tanWS) * tangentWS.w;
                    N = faceSign * normalize(nrmX * tanWS + nrmY * bitWS + nrmZ * nrmWS);
                #else
                    N = faceSign * normalize(normalWS_raw);
                #endif

                // ---- ClearCoat setup ----
                #ifdef _CLEARCOAT
                    float ccMask = SAMPLE_TEXTURE2D(_ClearCoatMask, sampler_ClearCoatMask, uv).r;
                    float3 ccN = lerp(faceSign * normalize(normalWS_raw), N, _ClearCoatNormalMode);
                    float ccPercRough = 1.0 - _ClearCoatSmoothness;
                    float ccAlpha = max(ccPercRough * ccPercRough, 0.0078125);
                    float ccF0scalar = mad(_ClearCoatMetallic, 0.96, 0.04);
                    float3 ccF0 = ccF0scalar * _ClearCoatColor.rgb;
                    bool ccActive = ccMask > 0.001;
                #endif

                // ---- Pantyhose Fresnel color blend ----
                // Decompiled lines 1568-1583: Fresnel rim blends _PantyhoseColor into
                // both albedo and shadowColor at grazing angles. Mask excludes alpha >= 0.99.
                #ifdef _PANTYHOSE
                    float ph_alphaProduct = baseAlpha * _BaseColor.a;
                    float ph_mask = (ph_alphaProduct < 0.99) ? 1.0 : 0.0;
                    float ph_NdotV = saturate(dot(V, N));
                    float ph_exp = ph_alphaProduct + 1.0 - _PantyhoseColor.a;
                    float ph_blend = ph_mask * min(exp2(log2(1.05 - ph_NdotV) * (ph_exp * 2.0)), 0.9);
                    albedo = lerp(albedo, _PantyhoseColor.rgb, ph_blend);
                    shadowColor = lerp(shadowColor, _PantyhoseColor.rgb, ph_blend);
                #endif
                shadowColorOut = shadowColor;

                // ---- Emission map ----
                float3 emissionTex = float3(0, 0, 0);
                #ifdef _EMISSION
                    emissionTex = SAMPLE_TEXTURE2D(_EmissionMap, sampler_EmissionMap, uv).rgb;
                #endif

                // ---- Steep Parallax Mapping (blob 8ca935ed lines 1572-1647) ----
                // Ray-march heightmap in tangent space, sample at intersection,
                // result added to emission as _ParallaxColor * sample.
                float parallaxSample = 0.0;
                #ifdef _PARALLAX_MAP
                {
                    // Tangent-space view direction (blob lines 1572-1575)
                    float3 pxNrm = normalize(normalWS_raw);
                    float3 pxTan = normalize(tangentWS.xyz);
                    float3 pxBit = cross(pxNrm, pxTan) * tangentWS.w;
                    float3 tbnV = float3(dot(pxTan, V), dot(pxBit, V), dot(pxNrm, V));
                    float tbnInvLen = rsqrt(max(dot(tbnV, tbnV), 1.175e-38));

                    // UV and ray step setup (blob lines 1576-1594)
                    float2 pxUV = uv * _ParallaxTex_ST.xy + _ParallaxTex_ST.zw;
                    float2 pxDxUV = ddx(pxUV);
                    float2 pxDyUV = ddy(pxUV);
                    float pxSteps = min(20.0, _ParallaxMarchNum);
                    float pxStepSz = 1.0 / pxSteps;
                    float pxViewZ = max(tbnInvLen * tbnV.z, 0.001);
                    float2 pxUVStep = (tbnInvLen * tbnV.xy / pxViewZ) * (-_ParallaxScale);
                    float2 pxUVDelta = pxStepSz * pxUVStep;

                    // Ray-march loop (blob lines 1615-1644)
                    float2 pxAccum = pxUVDelta;
                    float2 pxPrevOff = float2(0, 0);
                    float pxPrevH = 0.0;
                    float pxLayerH = 1.0 - pxStepSz;
                    float pxPrevLayerH = 1.0;
                    float pxHitH = 0.0;
                    bool pxHit = false;
                    for (float pxi = 0; pxi < pxSteps + 1.0; pxi += 1.0) {
                        float pxTexH = _ParallaxTex.SampleGrad(
                            sampler_ParallaxTex, pxUV + pxAccum, pxDxUV, pxDyUV).r;
                        if (pxLayerH < pxTexH) { pxHitH = pxTexH; pxHit = true; break; }
                        pxPrevOff = pxAccum;
                        pxAccum += pxUVDelta;
                        pxPrevH = pxTexH;
                        pxPrevLayerH = pxLayerH;
                        pxLayerH -= pxStepSz;
                    }
                    if (!pxHit) pxHitH = pxPrevH;

                    // Secant interpolation refinement (blob line 1645)
                    float pxT = (pxPrevH - pxPrevLayerH)
                              / (-pxPrevLayerH + pxLayerH + pxPrevH - pxHitH);

                    // Final sample at refined UV (blob line 1646)
                    float2 pxFinalUV = pxUV + pxUVDelta * pxT + pxPrevOff;
                    parallaxSample = SAMPLE_TEXTURE2D(_ParallaxTex, sampler_ParallaxTex, pxFinalUV).r;
                }
                #endif

                // ---- Flat direction: origin->fragment on XZ plane ----
                float fX = positionWS.x - originX;
                float fZ = positionWS.z - originZ;
                float fLen = rsqrt(fX*fX + NEAR_ZERO_Y*NEAR_ZERO_Y + fZ*fZ);
                float3 flatDir = float3(fX*fLen, NEAR_ZERO_Y*fLen, fZ*fLen);

                // ---- Exposure ----
                float exposure = (_CharacterParams12.w * (1.0 - _EnvironmentGlobalParams0.x) + _EnvironmentGlobalParams0.x) * _ExposureParams.x;

                // ---- Ambient (IV disabled -> CP2 fallback) ----
                float ambInt = exposure;
                float3 ambCol = _CharacterParams2.xyz;

                // ---- Camera forward ----
                float3 camFwd = float3(UNITY_MATRIX_I_V._m02, UNITY_MATRIX_I_V._m12, UNITY_MATRIX_I_V._m22);

                // ---- Metallic workflow ----
                float dielSpec = specScale * 0.04;
                float oneMinusRefl = (1.0 - metallic) * 0.96;
                float3 diffColor = oneMinusRefl * albedo;
                float3 specColor = metallic * (albedo - dielSpec) + dielSpec;
                float3 shadowDiff = oneMinusRefl * shadowColor;

                float roughness = max(roughnessRaw * roughnessRaw, 0.0078125);

                // ---- Main light from URP (with shadow) ----
                float4 shadowCoord = TransformWorldToShadowCoord(positionWS);
                Light mainLight = GetMainLight(shadowCoord);
                #if defined(_MAIN_LIGHT_SHADOWS_SCREEN) && !defined(_SURFACE_TYPE_TRANSPARENT)
                {
                    float2 suv = shadowCoord.xy / shadowCoord.w;
                    float2 off = _ShadowBlurRadius / _ScreenParams.xy;
                    float cS = SAMPLE_TEXTURE2D(_ScreenSpaceShadowmapTexture, sampler_LinearClamp, suv).x;
                    float s1 = SAMPLE_TEXTURE2D(_ScreenSpaceShadowmapTexture, sampler_LinearClamp, suv + float2(-off.x, -off.y)).x;
                    float s2 = SAMPLE_TEXTURE2D(_ScreenSpaceShadowmapTexture, sampler_LinearClamp, suv + float2( off.x, -off.y)).x;
                    float s3 = SAMPLE_TEXTURE2D(_ScreenSpaceShadowmapTexture, sampler_LinearClamp, suv + float2(-off.x,  off.y)).x;
                    float s4 = SAMPLE_TEXTURE2D(_ScreenSpaceShadowmapTexture, sampler_LinearClamp, suv + float2( off.x,  off.y)).x;
                    float bF = 4.0;
                    float w1 = 1.0 / (1.0 + max(0.0, s1 - cS) * bF);
                    float w2 = 1.0 / (1.0 + max(0.0, s2 - cS) * bF);
                    float w3 = 1.0 / (1.0 + max(0.0, s3 - cS) * bF);
                    float w4 = 1.0 / (1.0 + max(0.0, s4 - cS) * bF);
                    mainLight.shadowAttenuation = (cS + s1*w1 + s2*w2 + s3*w3 + s4*w4) / (1.0 + w1 + w2 + w3 + w4);
                }
                #endif
                float3 mainLightDir = mainLight.direction;
                float3 lightCol = mainLight.color;
                float lightInt = 1.0;

                // ---- Adjusted light direction ----
                float3 adjustedLightDir = lerp(mainLightDir, _CharacterParams11.xyz, _CharacterParams1.w);
                float adjXZLen = rsqrt(adjustedLightDir.x*adjustedLightDir.x + adjustedLightDir.z*adjustedLightDir.z + NEAR_ZERO_Y*NEAR_ZERO_Y);
                float adjXZ_x = adjXZLen * adjustedLightDir.x;
                float adjXZ_z = adjXZLen * adjustedLightDir.z;

                // ---- Light color blend (using CP5 for cloth) ----
                float3 blendedLightCol = lerp(lightCol, _CharacterParams5.xyz, _CharacterParams12.y);
                float blendedLightInt = lerp(lightInt, 1.0, _CharacterParams12.w);

                // ---- Camera-light facing terms for diffuse ramp ----
                float cfXZLen = rsqrt(camFwd.x * camFwd.x + camFwd.z * camFwd.z);
                float camLightDot = saturate(-(adjXZ_x * (cfXZLen * camFwd.x) + adjXZ_z * (cfXZLen * camFwd.z)));
                float camYFade = saturate(2.0 * (0.75 - abs(camFwd.y)));
                float camYSmooth = camYFade * camYFade * (3.0 - 2.0 * camYFade);

                // ==== DIFFUSE RAMP (cloth-specific wrap-lighting) ====
                float geomNdotL = dot(N, adjustedLightDir);
                float wrapAdd = 0.5 - 0.5 * geomNdotL * geomNdotL;
                float camFadeFactor = (1.0 - _CharacterParams12.x) * (camLightDot * camYSmooth);
                float modNdotL = camFadeFactor * wrapAdd + geomNdotL;
                #ifdef _DIFF_RAMP_ON
                    float rampInput = clamp(_CharacterParams11.w * _CharacterParams12.x + modNdotL, -1.0, 1.0) * 0.5 + 0.5;
                    float4 rampSmp = SAMPLE_TEXTURE2D_LOD(_DiffRampMap, sampler_DiffRampMap, float2(rampInput, 0.5), 0);
                    float3 rampCol = rampSmp.rgb;
                    float rampA = rampSmp.a;
                    float rampChroma = max(rampCol.r, max(rampCol.g, rampCol.b)) - min(rampCol.r, min(rampCol.g, rampCol.b));
                    float rampChromaInv = 1.0 - rampChroma;

                    // ---- Second ramp sample: view direction ----
                    float viewRampU = dot(N, camFwd) * 0.5 + 0.5;
                    float4 viewRampSmp = SAMPLE_TEXTURE2D_LOD(_DiffRampMap, sampler_DiffRampMap, float2(viewRampU, 0.5), 0);
                    float viewRampA = viewRampSmp.a;
                #else
                    float3 rampCol = float3(1, 1, 1);
                    float rampA = saturate(modNdotL * 0.5 + 0.5);
                    float rampChroma = 0;
                    float rampChromaInv = 1.0;
                    float viewRampA = 0;
                #endif

                // ---- Shadow terms (charShadow=1 simplification) ----
                float castShadow = lerp(smoothstep(0.0, 1.0, mainLight.shadowAttenuation), 1.0, _CharacterParams1.z);
                float minShadow = min(rampA, shadowMask) * castShadow;
                float viewShadowProduct = viewRampA * shadowMask;

                // ==== NPR DIFFUSE COMPOSITION (charShadow=1) ====
                float3 albScaled = shadowDiff * _CharacterParams0.z;
                float diffColorLum = dot(diffColor, LUM);

                float nprNdotL = saturate(dot(N, _CharacterParams6.xyz) + _CharacterParams7.x) * _CharacterParams7.y + _CharacterParams7.z;
                float shadowStr = minShadow * _CharacterParams1.y;

                float3 shadAmb = nprNdotL * (shadowStr * (1.0 - ambCol) + ambCol);

                float bright065 = min(ambInt * 0.35 + 0.65, 1.5);
                float brightFull = clamp(ambInt, 0.0, 1.5);
                float brightMix = lerp(bright065, clamp(ambInt, 1.25, 1.75), _CharacterParams1.x);
                float3 brightAmb = brightMix * shadAmb * _CharacterParams0.w;

                float lightLum = dot(blendedLightCol * blendedLightInt, LUM);

                float oneMinus12y = 1.0 - _CharacterParams12.y;
                float3 lightBlend = blendedLightCol * _CharacterParams12.y + oneMinus12y;
                float3 fullDiff;
                fullDiff.r = (shadAmb.r * brightFull * lightBlend.r + minShadow * (blendedLightCol.r * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;
                fullDiff.g = (shadAmb.g * brightFull * lightBlend.g + minShadow * (blendedLightCol.g * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;
                fullDiff.b = (shadAmb.b * brightFull * lightBlend.b + minShadow * (blendedLightCol.b * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;

                float albScaledLum = dot(albScaled * 0.65, LUM);
                float3 desatShad = (albScaled * 0.65 - albScaledLum) * 1.2 + albScaledLum;

                float combWeight = saturate(viewShadowProduct + rampA);
                float3 weightedAmb = lerp(desatShad, albScaled, combWeight);
                float3 shadowBlended = lerp(weightedAmb, diffColor, minShadow);

                float3 viewDepShad = viewShadowProduct * ((diffColor - diffColorLum) * 1.2 + diffColorLum - albScaled) + albScaled;

                float3 rampTinted = shadowBlended * (rampCol * rampChroma + rampChromaInv);

                float shadowLumVal = dot(shadowBlended, LUM);
                float rampLum = dot(rampTinted, LUM);
                float lumRatio = clamp(shadowLumVal / max(rampLum, 0.001), 0.0, 1.5);

                float3 nprDiff = rampTinted * lumRatio;

                float ambDiffInt = minShadow * (1.0 - _CharacterParams0.z) + _CharacterParams0.z;
                float specAmbInt = ambDiffInt * (minShadow * 0.5 + 0.5);

                // ==== ALPHA PREMULTIPLY ====
                float alphaPremul = mad(baseAlpha, _AlphaPremultiply, 1.0 - _AlphaPremultiply);

                // ==== GGX SPECULAR ====
                float NdotV_spec = saturate(dot(N, V));
                float mainLightY = adjustedLightDir.y;
                float3 camFwdMod = normalize(float3(camFwd.x, mainLightY, camFwd.z));
                float3 H = normalize(V * 3.0 + adjustedLightDir + camFwdMod * 2.0);
                float NdotH = dot(N, H);
                float roughSq = roughness * roughness;
                float denom = (NdotH * roughSq - NdotH) * NdotH + 1.0;
                float denomSq = denom * denom;
                float D_raw = (denomSq != roughSq) ? roughSq / denomSq : 1.0;

                // Pantyhose anisotropic specular (decompiled lines 3311-3333):
                // Secondary NDF with offset half-vector and anisotropic roughness axes.
                #ifdef _PANTYHOSE
                    float3 ph_rawTan = tangentWS.xyz;
                    float3 ph_T = normalize(ph_rawTan - N * dot(ph_rawTan, N));
                    float3 ph_B = cross(N, ph_T) * tangentWS.w;
                    float3 ph_H = normalize(H + V * _PantyhoseSpecularValue);
                    float ph_aniso = saturate(ph_alphaProduct * 0.5) * (0.5 - _PantyhoseAnisotropyDirection) + _PantyhoseAnisotropyDirection;
                    float ph_rT = roughness * (ph_aniso + 1.0);
                    float ph_rB = (1.0 - ph_aniso) * roughness;
                    float ph_rTB = ph_rT * ph_rB;
                    float ph_tH = ph_rB * dot(ph_T, ph_H);
                    float ph_bH = dot(ph_B, ph_H) * ph_rT;
                    float ph_nH = dot(N, ph_H) * ph_rTB;
                    float ph_d = ph_tH * ph_tH + ph_bH * ph_bH + ph_nH * ph_nH;
                    float ph_rTB3 = ph_rTB * ph_rTB * ph_rTB;
                    float ph_d2 = ph_d * ph_d;
                    float ph_ndf = (ph_d2 != ph_rTB3) ? (ph_rTB3 / ph_d2) : 1.0;
                    float D_combined = D_raw + ph_ndf * _PantyhoseSpecularInt * ph_mask;
                #else
                    float D_combined = D_raw;
                #endif
                float ggxTerm = clamp(D_combined * 0.5 / (NdotV_spec * 2.0 + roughness + 1e-4) - NEAR_ZERO_Y, 0.0, 20.0);

                // ---- Spec Ramp (cloth-specific) ----
                float3 specRampColor = specColor;
                float3 specRampEnv = specColor;
                #ifdef _SPEC_RAMP_ON
                    float specRampPartial = D_raw * (roughSq + 1e-4);
                    float specRampU = lerp(specRampPartial, NdotV_spec * NdotV_spec, _SpecRampIridescentMode);
                    float specRampV = (1.0 - metallic) * roughnessRaw;
                    float3 specRampSmp = SAMPLE_TEXTURE2D_LOD(_SpecRampMap, sampler_SpecRampMap, float2(specRampU, specRampV), 0).rgb;
                    specRampColor = specColor * specRampSmp;
                    specRampEnv = lerp(specColor, specRampColor, _SpecRampIridescentMode);
                #endif

                // ---- ClearCoat Specular (directional) ----
                // Blob lines 2286-2312: GGX NDF + Kelemen V + Schlick Fresnel, energy conservation.
                #ifdef _CLEARCOAT
                    float3 ccSpecDir = float3(0, 0, 0);
                    float3 ccBaseScale = float3(1, 1, 1);
                    float3 ccDiffScale = float3(1, 1, 1);
                    if (ccActive) {
                        float ccNdotH = dot(ccN, H);
                        float ccNdotV = saturate(dot(ccN, V));
                        float VdotH = saturate(dot(V, H));
                        // Schlick Fresnel (per-channel with tinted F0)
                        float oneMinusVdotH = 1.0 - VdotH;
                        float pow2 = oneMinusVdotH * oneMinusVdotH;
                        float pow5 = pow2 * pow2 * oneMinusVdotH;
                        float complement = 1.0 - pow5;
                        float3 ccFresnel = ccF0 * complement + pow5;
                        // Masked Fresnel and energy conservation (blob lines 2297-2302)
                        float3 ccMaskedF = ccMask * ccFresnel;
                        ccBaseScale = 1.0 - ccMaskedF;              // base spec *= baseScale^2
                        ccDiffScale = 1.0 - ccMask * ccMaskedF;     // diffuse *= 1 - mask^2*F
                        // GGX NDF (blob lines 2303-2306)
                        float ccAlphaSq = ccAlpha * ccAlpha;
                        float ccDenom = (ccNdotH * ccAlphaSq - ccNdotH) * ccNdotH + 1.0;
                        float ccDenomSq = ccDenom * ccDenom;
                        float ccD = (ccDenomSq != ccAlphaSq) ? ccAlphaSq / ccDenomSq : 1.0;
                        // Kelemen visibility (blob line 2307)
                        float ccV = 0.5 / (mad(ccNdotV, 2.0, ccAlpha) + 0.0001);
                        ccSpecDir = clamp(ccV * ccD * ccMaskedF, 0.0, 20.0);
                    }
                #endif

                // Main lit composition (diffuse premultiplied, specular not)
                #ifdef _CLEARCOAT
                    float3 mainLit = fullDiff * nprDiff * alphaPremul * ccDiffScale
                                   + (specAmbInt * fullDiff) * (ggxTerm * specRampColor * ccBaseScale * ccBaseScale + ccSpecDir) * _CharacterParams13.w;
                #else
                    float3 mainLit = fullDiff * nprDiff * alphaPremul + (specAmbInt * fullDiff) * (ggxTerm * specRampColor) * _CharacterParams13.w;
                #endif
                float mainLitLum = dot(mainLit, LUM);
                float desatAmt = clamp(mainLitLum - 0.5, 0.0, 0.5);

                // ==== SKIN SPECULAR CP8/CP9 ====
                float cp9x = _CharacterParams9.x;
                float cp9y = _CharacterParams9.y;
                float3 skinDir;
                skinDir.x = -cp9y * camFwd.z;
                skinDir.y = camFwd.z * cp9x;
                skinDir.z = camFwd.x * cp9y - cp9x * camFwd.y;
                skinDir = normalize(skinDir);

                float skinFresnel = 1.0 - abs(dot(V, N));
                float skinLow = _CharacterParams9.w * (-0.6) + 0.8;
                float skinHigh = _CharacterParams9.w * (-0.4) + 0.9;
                float skinT = saturate((skinFresnel - skinLow) / (skinHigh - skinLow));
                float skinSmooth = skinT * skinT * (3.0 - 2.0 * skinT);
                float skinNdotL = saturate(dot(flatDir, skinDir) + 1.0);
                float skinShadow = min(shadowMask, skinNdotL);
                float skinNdotBN = saturate(dot(skinDir, N));

                float3 skinSpec;
                skinSpec.r = skinShadow * skinSmooth * _CharacterParams8.x * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.r - 0.25) + 0.25);
                skinSpec.g = skinShadow * skinSmooth * _CharacterParams8.y * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.g - 0.25) + 0.25);
                skinSpec.b = skinShadow * skinSmooth * _CharacterParams8.z * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.b - 0.25) + 0.25);

                // ==== SUBSURFACE SPECULAR ====
                float mainNdotL_xz = dot(float3(adjXZ_x, adjXZLen * NEAR_ZERO_Y, adjXZ_z), N);
                float wrapNdotL = saturate(0.5 + mainNdotL_xz - 0.5 * mainNdotL_xz * mainNdotL_xz);
                float camLightFacing = (1.0 - _CharacterParams12.x) * camLightDot;
                float edgeT = saturate((-abs(dot(V, N)) + 0.4) * 5.0);
                float edgeFresnel = edgeT * edgeT * (3.0 - 2.0 * edgeT);
                float brightT = saturate((0.1 - diffColorLum) * 16.666);
                float brightnessGate = (brightT * brightT) * (3.0 - 2.0 * brightT);
                float3 subsurfLight = blendedLightCol * blendedLightInt;
                float3 subsurfSpec = brightnessGate * shadowMask * edgeFresnel * camLightFacing * wrapNdotL * subsurfLight * max(diffColor, 0.15);

                // ==== CUBEMAP REFLECTION (_CharMaxCubemap) ====
                float3 reflDir = reflect(-V, N);
                float cubeMip = log2(max(roughnessRaw, 0.001)) * 1.2 + 5.0;
                half3 cubeSample = SAMPLE_TEXTURECUBE_LOD(_CharMaxCubemap, sampler_CharMaxCubemap, reflDir, cubeMip).rgb;

                float dfgX, dfgY;
                ComputeEnvBRDF(NdotV_spec, roughness, dfgX, dfgY);
                float3 envBRDF = specRampEnv * dfgX + dfgY;
                float totalRefl = dfgX + dfgY;
                float reflBoost = (1.0 - totalRefl) / max(totalRefl, 1e-6);

                float cubeAmbInt = ambDiffInt * (clamp(exposure, 0.5, 1.5) * _CharacterParams0.w);
                float3 cubeRefl = cubeSample * envBRDF * (1.0 + reflBoost * specRampEnv);
                float3 cubemapContrib = cubeAmbInt * cubeRefl * ambCol * _CubemapIntensity;

                // ---- ClearCoat IBL (blob lines 2354-2373) ----
                #ifdef _CLEARCOAT
                    if (ccActive) {
                        float3 ccReflDir = reflect(-V, ccN);
                        float ccCubeMip = log2(max(ccPercRough, 0.001)) * 1.2 + 5.0;
                        half3 ccCubeSmp = SAMPLE_TEXTURECUBE_LOD(_CharMaxCubemap, sampler_CharMaxCubemap, ccReflDir, ccCubeMip).rgb;
                        float ccNdotV_ibl = saturate(dot(ccN, V));
                        float ccDfgX, ccDfgY;
                        ComputeEnvBRDF(ccNdotV_ibl, ccAlpha, ccDfgX, ccDfgY);
                        float3 ccEnvBRDF = ccF0 * ccDfgX + ccDfgY;
                        float ccTotalRefl = ccDfgX + ccDfgY;
                        float ccReflBoost = (1.0 - ccTotalRefl) / max(ccTotalRefl, 1e-6);
                        float3 ccCubeRefl = ccCubeSmp * ccEnvBRDF * (1.0 + ccReflBoost * ccF0);
                        cubemapContrib += ccMask * ccCubeRefl * _CubemapIntensity;
                    }
                #endif

                // ==== EMISSION ====
                float3 emissionContrib = float3(0, 0, 0);
                #ifdef _EMISSION
                    emissionContrib = emissionTex * _EmissionColor.rgb * _EmissionBrightness * alphaPremul;
                #endif
                // Parallax additive emission (blob lines 2421-2423)
                #ifdef _PARALLAX_MAP
                    emissionContrib += baseAlpha * parallaxSample * _ParallaxColor.rgb * alphaPremul;
                #endif

                // ==== FINAL ASSEMBLY ====
                float desatFactor = desatAmt * desatAmt + 1.0;
                float3 desatMainLit = desatFactor * (mainLit - mainLitLum) + mainLitLum;

                float3 litColor = desatMainLit + skinSpec + subsurfSpec + emissionContrib + cubemapContrib;

                // ==== VFX COLOR ADJUSTMENT ====
                if (_EnableVFXColorAdjustment > 0.5) {
                    float litLum = dot(litColor, LUM);
                    float3 adjusted;
                    adjusted.r = _ColorAdjustmentContrast * (lerp(litLum, litColor.r, _ColorAdjustmentSaturation) - 0.5) + 0.5;
                    adjusted.g = _ColorAdjustmentContrast * (lerp(litLum, litColor.g, _ColorAdjustmentSaturation) - 0.5) + 0.5;
                    adjusted.b = _ColorAdjustmentContrast * (lerp(litLum, litColor.b, _ColorAdjustmentSaturation) - 0.5) + 0.5;
                    float caRimT = saturate((_ColorAdjustmentRimWidth - NdotV_spec) / max(_ColorAdjustmentRimWidth, 1e-5));
                    float caRimSmooth = caRimT * caRimT * (3.0 - 2.0 * caRimT);
                    float3 caBrightened = adjusted * _ColorAdjustmentBrightness;
                    litColor = lerp(caBrightened, _ColorAdjustmentColorBlend.rgb, _ColorAdjustmentColorBlend.w)
                             + caRimSmooth * _ColorAdjustmentRimColor.rgb * _ColorAdjustmentRimIntensity;
                }

                float3 finalColor = litColor / _ExposureParams.x;
                return finalColor;
            }
        ENDHLSL

        // ================================================================
        // Pass 1: ForwardLit
        // ================================================================
        Pass {
            Name "ForwardLit"
            Blend [_SrcBlend] OneMinusSrcAlpha
            ZTest LEqual
            ZWrite [_ZWrite]
            Cull [_Cull]
            Tags { "LightMode"="UniversalForwardOnly" }
            Stencil {
                Ref [_StencilRef]
                WriteMask [_StencilClearMask]
                Comp Always
                Pass Replace
            }
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex vert
                #pragma fragment frag
                #pragma shader_feature _CLEARCOAT
                #pragma shader_feature _DIFF_RAMP_ON
                #pragma shader_feature _EMISSION
                #pragma shader_feature _METALLICSPECGLOSSMAP
                #pragma shader_feature _NORMALMAP
                #pragma shader_feature _PANTYHOSE
                #pragma shader_feature _PARALLAX_MAP
                #pragma shader_feature _SHADOW_LUT_TEX
                #pragma shader_feature _SPEC_RAMP_ON
                #pragma shader_feature_local _USE_GROUND_TRUTH_AO
                #pragma shader_feature_local _USE_ALCHEMY_AO
                #pragma multi_compile _ _CUSTOM_AO_ON
                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH

                struct Attributes {
                    float3 positionOS : POSITION;
                    float2 uv         : TEXCOORD0;
                    float3 normalOS   : NORMAL;
                    float4 tangentOS  : TANGENT;
                };

                struct Varyings {
                    float4 positionCS : SV_Position;
                    float2 uv         : TEXCOORD0;
                    float3 positionWS : TEXCOORD1;
                    float3 normalWS   : TEXCOORD2;
                    float4 tangentWS  : TEXCOORD3;
                };

                Varyings vert(Attributes input) {
                    Varyings o = (Varyings)0;
                    VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);
                    VertexNormalInputs   nrmIn = GetVertexNormalInputs(input.normalOS, input.tangentOS);
                    o.positionCS = posIn.positionCS;
                    o.positionWS = posIn.positionWS;
                    o.normalWS   = nrmIn.normalWS;
                    o.tangentWS  = float4(nrmIn.tangentWS, input.tangentOS.w);
                    o.uv = input.uv * _BaseMap_ST.xy + _BaseMap_ST.zw;
                    return o;
                }

                float4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target {
                    float faceSign = isFrontFace ? 1.0 : (_BackFaceNormalFlip * 2.0 - 1.0);
                    float4 baseSample = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, input.uv);
                    float3 albedo = baseSample.rgb * _BaseColor.rgb;
                    float3 shadowColor;
                    float3 color = computeNPRLighting(input.uv, input.positionWS, input.normalWS, input.tangentWS, faceSign, albedo, baseSample.a, shadowColor);
                    color = ApplyCustomAO(color, shadowColor, GetNormalizedScreenSpaceUV(input.positionCS));
                    float alpha = (_SurfaceType == 1.0) ? baseSample.a : 1.0;
                    return float4(color, alpha);
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 2: Character Outline (inverted hull, full NPR lighting + OutlineMask)
        // ================================================================
        Pass {
            Name "CharacterOutline"
            Blend [_SrcBlend] OneMinusSrcAlpha
            Cull Front
            ZWrite On
            ZTest Less
            Tags { "LightMode"="SRPDefaultUnlit" }
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex outlineVert
                #pragma fragment outlineFrag
                #pragma shader_feature _CLEARCOAT
                #pragma shader_feature _DIFF_RAMP_ON
                #pragma shader_feature _EMISSION
                #pragma shader_feature _METALLICSPECGLOSSMAP
                #pragma shader_feature _NORMALMAP
                #pragma shader_feature _ALPHATEST_ON
                #pragma shader_feature _OUTLINE_MASK
                #pragma shader_feature _PANTYHOSE
                #pragma shader_feature _PARALLAX_MAP
                #pragma shader_feature _SHADOW_LUT_TEX
                #pragma shader_feature _SPEC_RAMP_ON
                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH

                struct OutlineAttributes {
                    float3 positionOS    : POSITION;
                    float2 uv            : TEXCOORD0;
                    float3 normalOS      : NORMAL;
                    float4 tangentOS     : TANGENT;
                    float2 smoothNrmTS   : TEXCOORD2;
                };

                struct OutlineVaryings {
                    float4 positionCS : SV_Position;
                    float2 uv         : TEXCOORD0;
                    float3 positionWS : TEXCOORD1;
                    float3 normalWS   : TEXCOORD2;
                    float4 tangentWS  : TEXCOORD3;
                };

                OutlineVaryings outlineVert(OutlineAttributes input) {
                    OutlineVaryings o = (OutlineVaryings)0;
                    if (_EnableOutline < 0.5) {
                        o.positionCS = float4(0, 0, 0, 0);
                        return o;
                    }

                    VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);
                    VertexNormalInputs nrmIn = GetVertexNormalInputs(input.normalOS, input.tangentOS);

                    // Pass through for fragment NPR lighting (original mesh data)
                    o.positionWS = posIn.positionWS;
                    o.normalWS = nrmIn.normalWS;
                    o.tangentWS = float4(nrmIn.tangentWS, input.tangentOS.w);
                    float2 uvTransformed = input.uv * _BaseMap_ST.xy + _BaseMap_ST.zw;
                    o.uv = uvTransformed;

                    // Choose normal: smooth (UV2 tangent-space) or regular vertex normal
                    float3 normalWS = nrmIn.normalWS;
                    if (_OutlineAverageNormal > 0.5) {
                        float2 ts = input.smoothNrmTS;
                        float z = sqrt(max(1.0 - dot(ts, ts), 0.0));
                        float3 bitWS = cross(nrmIn.normalWS, nrmIn.tangentWS) * input.tangentOS.w;
                        normalWS = normalize(nrmIn.tangentWS * ts.x + bitWS * ts.y + nrmIn.normalWS * z);
                    }

                    float4 clipPos = posIn.positionCS;

                    // Outline mask: R = width multiplier, G = Z offset multiplier
                    #ifdef _OUTLINE_MASK
                        float2 maskSmp = SAMPLE_TEXTURE2D_LOD(_OutlineMask, sampler_OutlineMask, uvTransformed, 0).rg;
                        float widthMask = maskSmp.r;
                        float zOffsetVal = maskSmp.g * _OutlineOffsetZ;
                    #else
                        float widthMask = 1.0;
                        float zOffsetVal = _OutlineOffsetZ;
                    #endif

                    // Project normal to clip-space XY
                    float2 screenN = mul((float3x3)UNITY_MATRIX_VP, normalWS).xy;
                    float screenNInvLen = rsqrt(dot(screenN, screenN) + 1e-8);

                    // FOV half-angle from projection matrix
                    float tanHalf = -1.0 / UNITY_MATRIX_P._m11;
                    bool small = abs(tanHalf) < 1.0;
                    float t = small ? abs(tanHalf) : (1.0 / abs(tanHalf));
                    float t2 = t * t;
                    float approx = mad(mad(t2, 0.0872929, -0.301895), t2, 1.0);
                    float angle = small ? (t * approx) : mad(-approx, t, 1.5707964);
                    float halfFov = (tanHalf < 0.0) ? -angle : angle;

                    // Width with FOV correction + distance attenuation
                    float width = (0.3926990 / halfFov) * _OutlineWidth;
                    float distAtten = clamp(clipPos.w * halfFov * 4.5837, 0.0, 1.0);

                    // Screen-space offset
                    float aspect = _ScreenParams.y / _ScreenParams.x;
                    float2 offset;
                    offset.x = distAtten * width * (screenNInvLen * screenN.x * aspect) * 0.005;
                    offset.y = distAtten * width * (screenNInvLen * screenN.y) * 0.005;

                    // Min pixel width enforcement
                    float maxExtent = min(1.5707964 / halfFov, max(clipPos.w, 0.0));
                    float2 minPixel = float2(maxExtent / _ScreenParams.x, maxExtent / _ScreenParams.y);
                    offset.x = (abs(offset.x) < minPixel.x) ? sign(offset.x) * minPixel.x : offset.x;
                    offset.y = (abs(offset.y) < minPixel.y) ? sign(offset.y) * minPixel.y : offset.y;

                    // Apply width mask
                    clipPos.xy += offset * widthMask;

                    // Z offset with mask: push outline behind main geometry
                    if (unity_OrthoParams.w == 0.0) {
                        float viewZ = mad(zOffsetVal, -0.1, -clipPos.w);
                        clipPos.z = (clipPos.w * mad(viewZ, UNITY_MATRIX_P._m22, UNITY_MATRIX_P._m23)) / (-viewZ);
                    } else {
                        clipPos.z += (-0.1 * zOffsetVal) / _ProjectionParams.z;
                    }

                    o.positionCS = clipPos;
                    return o;
                }

                float4 outlineFrag(OutlineVaryings input) : SV_Target {
                    float4 baseSample = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, input.uv);
                    float3 rawAlbedo = baseSample.rgb * _BaseColor.rgb;
                    #ifdef _ALPHATEST_ON
                        float baseAlpha = baseSample.a * _BaseColor.a;
                        clip(baseAlpha - _AlphaClipThreshold);
                    #endif

                    // Outline albedo processing
                    float3 albedo;
                    if (_OutlineTintEnable != 0.0) {
                        albedo = _OutlineTintColor.rgb;
                    } else {
                        float3 scaled = rawAlbedo * _OutlineColorBrightness;
                        float lum = dot(scaled, LUM);
                        albedo = lum + _OutlineColorSaturation * (scaled - lum);
                    }

                    // Full NPR lighting (same as ForwardLit)
                    // faceSign=1: original game does not flip normals for outline
                    float3 shadowColorUnused;
                    float3 color = computeNPRLighting(input.uv, input.positionWS, input.normalWS, input.tangentWS, 1.0, albedo, baseSample.a, shadowColorUnused);
                    float alpha = (_SurfaceType == 1.0) ? baseSample.a : 1.0;
                    return float4(color, alpha);
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 3: ShadowCaster
        // ================================================================
        Pass {
            Name "ShadowCaster"
            Tags { "LightMode"="ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull Off
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex shadowVert
                #pragma fragment shadowFrag
                #pragma shader_feature _ALPHATEST_ON
                #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW

                float3 _LightDirection;
                float3 _LightPosition;

                struct ShadowAttributes {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float2 uv         : TEXCOORD0;
                };

                struct ShadowVaryings {
                    float4 positionCS : SV_Position;
                    float2 uv         : TEXCOORD0;
                };

                ShadowVaryings shadowVert(ShadowAttributes input) {
                    ShadowVaryings o;
                    float3 positionWS = TransformObjectToWorld(input.positionOS);
                    float3 normalWS = TransformObjectToWorldNormal(input.normalOS);
                    #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                        float3 lightDir = normalize(_LightPosition - positionWS);
                    #else
                        float3 lightDir = _LightDirection;
                    #endif
                    o.positionCS = TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDir));
                    #if UNITY_REVERSED_Z
                        o.positionCS.z = min(o.positionCS.z, UNITY_NEAR_CLIP_VALUE);
                    #else
                        o.positionCS.z = max(o.positionCS.z, UNITY_NEAR_CLIP_VALUE);
                    #endif
                    o.uv = input.uv * _BaseMap_ST.xy + _BaseMap_ST.zw;
                    return o;
                }

                float4 shadowFrag(ShadowVaryings input) : SV_Target {
                    #ifdef _ALPHATEST_ON
                        float alpha = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, input.uv).a * _BaseColor.a;
                        clip(alpha - _AlphaClipThreshold);
                    #endif
                    return 0;
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 4: DepthNormalsOnly (for SSAO / Deferred depth-normals prepass)
        // ================================================================
        Pass {
            Name "DepthNormalsOnly"
            ZWrite On
            Cull [_Cull]
            Tags { "LightMode"="DepthNormalsOnly" }
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex depthNormalsVert
                #pragma fragment depthNormalsFrag
                #pragma shader_feature _NORMALMAP

                struct DepthNormalsAttributes {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float4 tangentOS  : TANGENT;
                    float2 uv         : TEXCOORD0;
                };

                struct DepthNormalsVaryings {
                    float4 positionCS : SV_Position;
                    float3 normalWS   : TEXCOORD0;
                    float4 tangentWS  : TEXCOORD1;
                    float2 uv         : TEXCOORD2;
                };

                DepthNormalsVaryings depthNormalsVert(DepthNormalsAttributes input) {
                    DepthNormalsVaryings o = (DepthNormalsVaryings)0;
                    VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);
                    VertexNormalInputs nrmIn = GetVertexNormalInputs(input.normalOS, input.tangentOS);
                    o.positionCS = posIn.positionCS;
                    o.normalWS   = nrmIn.normalWS;
                    o.tangentWS  = float4(nrmIn.tangentWS, input.tangentOS.w);
                    o.uv = input.uv * _BaseMap_ST.xy + _BaseMap_ST.zw;
                    return o;
                }

                float4 depthNormalsFrag(DepthNormalsVaryings input) : SV_Target {
                    #ifdef _NORMALMAP
                        float4 nrmSmp = SAMPLE_TEXTURE2D(_BumpMap, sampler_BumpMap, input.uv);
                        float nrmX = (nrmSmp.x * nrmSmp.w * 2.0 - 1.0) * _BumpScale;
                        float nrmY = (nrmSmp.y * 2.0 - 1.0) * _BumpScale;
                        float nrmZ = max(sqrt(1.0 - saturate(nrmX*nrmX + nrmY*nrmY)), 1e-16);
                        float3 nrmWS = normalize(input.normalWS);
                        float3 tanWS = normalize(input.tangentWS.xyz);
                        float3 bitWS = cross(nrmWS, tanWS) * input.tangentWS.w;
                        float3 normalWS = normalize(nrmX * tanWS + nrmY * bitWS + nrmZ * nrmWS);
                    #else
                        float3 normalWS = normalize(input.normalWS);
                    #endif
                    return float4(normalWS, 0.0);
                }
            ENDHLSL
        }
    }
}
