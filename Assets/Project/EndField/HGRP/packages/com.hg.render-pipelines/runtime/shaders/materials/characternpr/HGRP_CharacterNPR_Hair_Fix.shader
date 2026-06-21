// Simplified HGRP CharacterNPR Hair shader — ForwardLit + Outline.
// Based on: HGRP_CharacterNPR_Hair_7623044f.shader
// Material: M_actor_aurora_hair_01
// Keywords: _NORMALMAP, _SPECULAR_NORMALMAP, _METALLICSPECGLOSSMAP, _DIFF_RAMP_ON, _SPEC_RAMP_ON, _SPECULAR_LINE, _DRAW_UNDER_BROW, _OUTLINE_MASK
// Kept: Split Normal Map (diffuse + specular), Diffuse Ramp (wrap-lighting), Shadow Color,
//   MetallicGlossMap, Spec Ramp, Kajiya-Kay Anisotropic Specular (dual strand), Specular Line,
//   Skin Specular (CP8/CP9 + _CameraDepthTexture), Subsurface, CP10 Height Darken,
//   HairBrowMask discard, Character Outline (full NPR lighting), VFX Color Adjustment.
// Removed: GPU skinning, instancing, TAA jitter, motion vectors, rain/wet, all shadows,
//   IV clipmap, fog, punctual lights, dissolve, cubemap reflection,
//   emission, avatar customize, alpha clip, stroke map.
//
// NOTE: CharacterParams numbering same as Cloth variant:
//   CP2 = ambient color, CP5 = light color override.
//
// Requires: URP Depth Texture ON (for _CameraDepthTexture skin specular edge detection).

Shader "HGRP/CharacterNPR_Hair_Fix" {
    Properties {
        _BaseColor ("Color", Color) = (1, 1, 1, 1)
        _BaseMap ("Albedo", 2D) = "white" {}
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _Cull ("Render Face", Float) = 2
        [Enum(On, 0, Off, 1)] _BackFaceNormalFlip ("Back Face Normal Flip", Float) = 0
        [HideInInspector] _AlphaPremultiply ("__alphaPremul", Float) = 0
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 0
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Alpha Test", Float) = 0
        _AlphaClipThreshold ("Alpha Clip Threshold", Range(0, 1)) = 0.5

        [Toggle(_SHADOW_LUT_TEX)] _UseShadowLutTex ("Use Shadow LUT", Float) = 0
        _ShadowLutTex ("Shadow Color LUT", 2D) = "white" {}
        _ShadowColorBrightness ("Shadow Color Brightness", Range(0, 1)) = 0.5
        _ShadowColorSaturation ("Shadow Color Saturation", Range(0, 2)) = 1.1

        [Toggle(_METALLICSPECGLOSSMAP)] _UseMetallicGlossMap ("Use MetallicGlossMap", Float) = 1
        [Gamma] _Metallic ("Metallic", Range(0, 1)) = 0
        _Specular ("Specular Scale", Range(0, 1)) = 1
        _Smoothness ("Smoothness", Range(0, 1)) = 1
        _MetallicGlossMap ("RGBA: Metal,Spec,Shadow,Smooth", 2D) = "white" {}

        [Toggle(_NORMALMAP)] _UseBumpMap ("Use Normal Map", Float) = 1
        _BumpScale ("Normal Scale", Float) = 1

        [Toggle(_SPECULAR_NORMALMAP)] _UseSpecBumpMap ("Split Diffuse/Specular Normal", Float) = 1
        _SplitNormalMap ("Hair Normal Map (RG=diffuse, BA=specular)", 2D) = "grey" {}
        _SpecBumpScale ("Spec Normal Scale", Float) = 1

        [Toggle(_DIFF_RAMP_ON)] _UseDiffRampMap ("Diffuse Ramp", Float) = 1
        _DiffRampMap ("Diffuse Ramp", 2D) = "white" {}

        [Toggle(_SPEC_RAMP_ON)] _UseSpecRampMap ("Specular Ramp", Float) = 1
        _SpecRampMap ("Specular Ramp", 2D) = "white" {}

        [Header(Anisotropy)]
        _AnisotropyValue ("Anisotropy Value (strand 1)", Range(0, 1)) = 0.7
        _AnisotropyValue2 ("Anisotropy Value2 (strand 2)", Range(0, 1)) = 0.712
        _AnisotropyDirX ("Anisotropy Direction X", Range(-1, 1)) = 0
        _AnisotropyIntensity ("Anisotropy Intensity", Range(0, 3)) = 2
        _AnisotropyEdgeFade ("Anisotropy Edge Fade", Range(0.01, 10)) = 3
        _AnisotropyRange2 ("Anisotropy Range2", Range(-1, 1)) = 0.5
        _AnisotropyColor2 ("Anisotropy Color2", Color) = (0.563, 0.283, 0.048, 1)

        [Header(Stroke Map)]
        [Toggle(_STROKE_ON)] _StrokeOn ("Use Stroke Map", Float) = 0
        _StrokeMap ("Stroke Map (R:anisotropy)", 2D) = "linearGrey" {}
        _StrokeScale ("Stroke Scale", Float) = 1

        [Header(Specular Line)]
        [Toggle(_SPECULAR_LINE)] _SpecularLine ("Specular Line", Float) = 1
        _UseLineMap ("Use Line Map", Float) = 1
        _LineMap ("Line Map", 2D) = "black" {}
        _LineAmount ("Line Amount", Float) = 300
        _LineValue ("Line Value", Range(0, 1)) = 0.58
        _LineRange ("Line Range", Range(-1, 1)) = 0.93
        _LineIntensity ("Line Intensity", Range(0, 1)) = 0.3
        _LineSaturation ("Line Saturation", Range(0, 10)) = 1.7

        [Header(Hair Brow Mask)]
        [Toggle(_DRAW_UNDER_BROW)] _DrawUnderBrow ("Draw Under Brow", Float) = 1
        _HairBrowMask ("Hair Brow Mask", 2D) = "white" {}
        _HairBrowMaskThreshold ("Hair Brow Mask Threshold", Range(0, 1)) = 0.5

        [Header(Height Darken)]
        _HairDarkenParams ("Hair Darken (x=offsetX y=darken z=offsetZ w=minDarken)", Vector) = (0, 0, 0, 0)

        [HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}

        [Header(Outline)]
        [ToggleUI] _EnableOutline ("Enable Outline", Float) = 1
        [Toggle(_OUTLINE_MASK)] _EnableOutlineMask ("Outline Mask Enable", Float) = 1
        _OutlineMask ("Outline Mask", 2D) = "white" {}
        _OutlineWidth ("Outline Width", Range(0, 2)) = 0.5
        _OutlineOffsetZ ("Outline Offset Z", Range(0, 1)) = 0.0
        _OutlineColorBrightness ("Outline Color Brightness", Range(0, 1)) = 0.4
        _OutlineColorSaturation ("Outline Color Saturation", Range(0, 2)) = 1.2
        [ToggleUI] _OutlineAverageNormal ("Use Smooth Normal (UV2)", Float) = 1
        [ToggleUI] _OutlineTintEnable ("Outline Tint Enable", Float) = 0
        _OutlineTintColor ("Outline Tint Color", Color) = (1, 1, 1, 1)

        [Header(VFX Color Adjustment)]
        [ToggleUI] _EnableVFXColorAdjustment ("VFX Color Adjustment", Float) = 0
        _ColorAdjustmentBrightness ("Color Adjustment Brightness", Range(0.5, 1.5)) = 1
        _ColorAdjustmentSaturation ("Color Adjustment Saturation", Range(0, 2)) = 1
        _ColorAdjustmentContrast ("Color Adjustment Contrast", Range(0, 2)) = 1
        _ColorAdjustmentColorBlend ("Color Adjustment Color Blend", Color) = (1, 1, 1, 0)
        _ColorAdjustmentRimWidth ("Color Adjustment Rim Width", Range(0, 1)) = 0.35
        _ColorAdjustmentRimIntensity ("Color Adjustment Rim Intensity", Range(0, 10)) = 4
        _ColorAdjustmentRimColor ("Color Adjustment Rim Color", Color) = (1, 1, 1, 1)

        [Header(Character Params)]
        _CharacterParams0 ("CP0 (.y=diffuse .z=shadow .w=brightness)", Vector) = (0, 1, 0.7, 1)
        _CharacterParams1 ("CP1 (.x=brightMix .y=shadowStr .z=shadowLerp .w=lightDirOverride)", Vector) = (0, 0, 0, 0)
        _CharacterParams2 ("CP2 (ambient color rgb)", Vector) = (1, 1, 1, 0)
        _CharacterParams5 ("CP5 (light color override rgb)", Vector) = (1, 1, 1, 1)
        _CharacterParams6 ("CP6 (ambient direction)", Vector) = (0, 1, 0, 0)
        _CharacterParams7 ("CP7 (.x=offset .y=scale .z=bias)", Vector) = (0.15, 0.6, 1, 0)
        _CharacterParams8 ("CP8 (skin spec color rgb + .w=intensity)", Vector) = (0, 0, 0, 1)
        _CharacterParams9 ("CP9 (skin spec .xy=dir .z=tint .w=width)", Vector) = (0, 1, 0, 0.4)
        _CharacterParams10 ("CP10 (height darken control)", Vector) = (0, 0, 0, 0)
        _CharacterParams11 ("CP11 (light dir override xyz + .w=rampBias)", Vector) = (-0.433, 0.5, 0.75, 0)
        _CharacterParams12 ("CP12 (.x=rampOffset .y=lightColOverride .z=shadowGate .w=exposureBlend)", Vector) = (0, 0, 0, 0)
        _CharacterParams13 ("CP13 (.w=anisotropy specular toggle)", Vector) = (0, 0, 0, 1)
        _EnvironmentGlobalParams0 ("EnvGlobalParams0", Vector) = (1.67, 1.5, 1, 0)
        _ExposureParams ("ExposureParams", Vector) = (1, 0, 0, 0)

        [Header(Workarounds)]
        [Toggle] _FBXRotationFix ("FBX -90 Z Rotation Fix (OTW col0/col1 swap)", Float) = 0
        _ShadowBlurRadius ("Shadow Blur Radius (Screen Space)", Range(0, 8)) = 2.5

        // Behind-Hair Composite stencil (write hair marker bit5, clear face marker bit7)
        [HideInInspector] _StencilRef ("Stencil Ref", Float) = 32
        [HideInInspector] _StencilClearMask ("Stencil Write Mask", Float) = 160

        [Toggle(_USE_GROUND_TRUTH_AO)] _UseGroundTruthAO ("Use Ground Truth Ambient Occlusion", Float) = 0
        [Toggle(_USE_ALCHEMY_AO)] _UseAlchemyAO ("Use Alchemy Ambient Occlusion", Float) = 0
    }
    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Opaque" }
        LOD 600

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"
            #include "CustomAOSample.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _BaseColor;
                float4 _BaseMap_ST;
                float _ShadowColorBrightness;
                float _ShadowColorSaturation;
                float _AlphaClipThreshold;
                float _ShadowBlurRadius;
                float _Metallic;
                float _Specular;
                float _Smoothness;
                float _BackFaceNormalFlip;
                float _AlphaPremultiply;
                float _SurfaceType;
                float _FBXRotationFix;
                float _BumpScale;
                float _SpecBumpScale;
                float4 _LineMap_ST;
                float _AnisotropyValue;
                float _AnisotropyValue2;
                float _AnisotropyDirX;
                float _AnisotropyIntensity;
                float _AnisotropyEdgeFade;
                float _AnisotropyRange2;
                float4 _AnisotropyColor2;
                float4 _StrokeMap_ST;
                float _StrokeScale;
                float _UseLineMap;
                float _LineAmount;
                float _LineValue;
                float _LineRange;
                float _LineIntensity;
                float _LineSaturation;
                float _HairBrowMaskThreshold;
                float4 _HairDarkenParams;
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
                // Character params
                float4 _CharacterParams0;
                float4 _CharacterParams1;
                float4 _CharacterParams2;
                float4 _CharacterParams5;
                float4 _CharacterParams6;
                float4 _CharacterParams7;
                float4 _CharacterParams8;
                float4 _CharacterParams9;
                float4 _CharacterParams10;
                float4 _CharacterParams11;
                float4 _CharacterParams12;
                float4 _CharacterParams13;
                float4 _EnvironmentGlobalParams0;
                float4 _ExposureParams;
            CBUFFER_END

            TEXTURE2D(_BaseMap);            SAMPLER(sampler_BaseMap);
            TEXTURE2D(_SplitNormalMap);      SAMPLER(sampler_SplitNormalMap);
            TEXTURE2D(_MetallicGlossMap);    SAMPLER(sampler_MetallicGlossMap);
            TEXTURE2D(_DiffRampMap);         SAMPLER(sampler_DiffRampMap);
            TEXTURE2D(_SpecRampMap);         SAMPLER(sampler_SpecRampMap);
            TEXTURE2D(_LineMap);
            TEXTURE2D(_StrokeMap);
            TEXTURE2D(_HairBrowMask);        SAMPLER(sampler_HairBrowMask);
            TEXTURE2D(_OutlineMask);         SAMPLER(sampler_OutlineMask);
            TEXTURE2D(_ShadowLutTex);        SAMPLER(sampler_ShadowLutTex);

            static const float3 LUM = float3(0.2126729, 0.7151522, 0.07217500);
            static const float NEAR_ZERO_Y = 6.103515625e-05; // asfloat(947912704u)

            float LinearToSRGB_Custom(float c) {
                return (c <= 0.0031308) ? (c * 12.92)
                    : (1.055 * pow(abs(c), 0.41666666) - 0.055);
            }

            // ================================================================
            // Shared NPR lighting — used by both ForwardLit and Outline passes
            // Hair variant: Kajiya-Kay anisotropy, split normals, specular line, depth edge detection
            // albedo: already processed (raw for ForwardLit, brightness/saturation adjusted for Outline)
            // screenPos: for depth-based skin specular edge detection
            // ================================================================
            float3 computeNPRLighting(float2 uv, float3 positionWS, float3 normalWS_raw, float4 tangentWS, float faceSign, float3 albedo, float baseAlpha, float4 screenPos, out float3 shadowColorOut) {
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
                shadowColorOut = shadowColor;

                // ---- Split Normal Map ----
                float3 nrmWS = normalize(normalWS_raw);
                float3 tanWS = normalize(tangentWS.xyz);
                float3 bitWS = cross(nrmWS, tanWS) * tangentWS.w;

                float3 N; // diffuse normal
                float3 specN; // specular normal
                #if defined(_SPECULAR_NORMALMAP) && defined(_NORMALMAP)
                    float4 nrmSmp = SAMPLE_TEXTURE2D(_SplitNormalMap, sampler_SplitNormalMap, uv);
                    float dnRawX = nrmSmp.x * 2.0 - 1.0;
                    float dnRawY = nrmSmp.y * 2.0 - 1.0;
                    float dnZ = max(sqrt(1.0 - saturate(dnRawX*dnRawX + dnRawY*dnRawY)), 1e-16);
                    float dnX = dnRawX * _BumpScale;
                    float dnY = dnRawY * _BumpScale;
                    N = faceSign * normalize(dnX * tanWS + dnY * bitWS + dnZ * nrmWS);
                    float snRawX = nrmSmp.z * 2.0 - 1.0;
                    float snRawY = nrmSmp.w * 2.0 - 1.0;
                    float snZ = max(sqrt(1.0 - saturate(snRawX*snRawX + snRawY*snRawY)), 1e-16);
                    float snX = snRawX * _SpecBumpScale;
                    float snY = snRawY * _SpecBumpScale;
                    specN = normalize(snX * tanWS + snY * bitWS + snZ * nrmWS);
                #elif defined(_NORMALMAP)
                    float4 nrmSmp = SAMPLE_TEXTURE2D(_SplitNormalMap, sampler_SplitNormalMap, uv);
                    float dnRawX = nrmSmp.x * 2.0 - 1.0;
                    float dnRawY = nrmSmp.y * 2.0 - 1.0;
                    float dnZ = max(sqrt(1.0 - saturate(dnRawX*dnRawX + dnRawY*dnRawY)), 1e-16);
                    float dnX = dnRawX * _BumpScale;
                    float dnY = dnRawY * _BumpScale;
                    N = faceSign * normalize(dnX * tanWS + dnY * bitWS + dnZ * nrmWS);
                    specN = N;
                #else
                    N = faceSign * nrmWS;
                    specN = N;
                #endif

                float3 geomN = faceSign * nrmWS;

                // ---- Flat direction: origin->fragment on XZ plane ----
                float fX = positionWS.x - originX;
                float fZ = positionWS.z - originZ;
                float fLen = rsqrt(fX*fX + NEAR_ZERO_Y*NEAR_ZERO_Y + fZ*fZ);
                float3 flatDir = float3(fX*fLen, NEAR_ZERO_Y*fLen, fZ*fLen);

                // ---- Anisotropy tangent ----
                float3 otwCol0 = float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20);
                float3 otwCol1 = float3(unity_ObjectToWorld._m01, unity_ObjectToWorld._m11, unity_ObjectToWorld._m21);
                float3 otwCol2 = float3(unity_ObjectToWorld._m02, unity_ObjectToWorld._m12, unity_ObjectToWorld._m22);
                if (_FBXRotationFix > 0.5) {
                    float3 tmp = otwCol0;
                    otwCol0 = otwCol1;
                    otwCol1 = -tmp;
                }
                float3 anisoDir = normalize(otwCol0 * _AnisotropyDirX + otwCol1);
                float3 anisoBitan = cross(specN, anisoDir);
                float3 blendedBitan = lerp(anisoBitan, tangentWS.xyz, metallic);
                float tanSignScale = lerp(1.0, tangentWS.w, metallic);
                float3 modBitan = tanSignScale * cross(specN, blendedBitan);

                // ---- Edge fade ----
                float vDotC0 = dot(V, otwCol0);
                float vDotC2 = dot(V, otwCol2);
                float nDotC0 = dot(specN, otwCol0);
                float nDotC2 = dot(specN, otwCol2);
                float nXZLen = rsqrt(nDotC0*nDotC0 + nDotC2*nDotC2);
                float vXZLen = rsqrt(vDotC0*vDotC0 + vDotC2*vDotC2);
                float edgeDot = saturate(dot(float2(nXZLen*nDotC0, nXZLen*nDotC2), float2(vXZLen*vDotC0, vXZLen*vDotC2)));
                float edgeFade = exp2(log2(edgeDot) * _AnisotropyEdgeFade);

                // ---- Exposure ----
                float exposure = (_CharacterParams12.w * (1.0 - _EnvironmentGlobalParams0.x) + _EnvironmentGlobalParams0.x) * _ExposureParams.x;

                // ---- Ambient (IV bypassed -> CP2 fallback) ----
                float ambInt = exposure;
                float3 ambCol = _CharacterParams2.xyz;

                // ---- CP10 Height Darken ----
                float darkenOffsetX = lerp(_HairDarkenParams.x, _CharacterParams10.y, _CharacterParams10.x);
                float darkenOffsetZ = lerp(_HairDarkenParams.z, _CharacterParams10.w, _CharacterParams10.x);
                float darkenY = lerp(_HairDarkenParams.y, 0.0, _CharacterParams10.x);
                float darkenMinW = _HairDarkenParams.w;

                float heightT = saturate(((darkenOffsetZ - positionWS.y) + 0.2) * 2.857143);
                float heightSmooth = heightT * heightT * (3.0 - 2.0 * heightT);
                float darkenFactor = max(heightSmooth * darkenY, darkenMinW);

                float darkenSum = darkenFactor + darkenOffsetX;
                float3 darkenedAlbedo;
                float3 darkenedShadowColor;
                float darkenedScale;
                if (0.01 < darkenSum) {
                    float dMax = max(darkenFactor, darkenOffsetX);
                    float dInv = 1.0 - dMax;
                    float dMul = dMax * 0.8 + dInv;
                    darkenedAlbedo = albedo * dMul;
                    darkenedShadowColor = shadowColor * dMul;
                    darkenedScale = dMax * 2.0 + dInv;
                } else {
                    darkenedAlbedo = albedo;
                    darkenedShadowColor = shadowColor;
                    darkenedScale = 1.0;
                }

                // ---- Metallic workflow (Hair: metallic=0 simplification) ----
                float3 diffColor = darkenedAlbedo * 0.96;
                float dielSpec = specScale * 0.04;
                float3 shadowDiff = darkenedShadowColor * 0.96;
                float diffColorLum = dot(diffColor, LUM);

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

                // ---- Adjusted light direction ----
                float3 adjustedLightDir = lerp(mainLightDir, _CharacterParams11.xyz, _CharacterParams1.w);
                float adjXZLen = rsqrt(adjustedLightDir.x*adjustedLightDir.x + adjustedLightDir.z*adjustedLightDir.z + NEAR_ZERO_Y*NEAR_ZERO_Y);
                float adjXZ_x = adjXZLen * adjustedLightDir.x;
                float adjXZ_z = adjXZLen * adjustedLightDir.z;

                // ---- Light color blend ----
                float3 blendedLightCol = lerp(lightCol, _CharacterParams5.xyz, _CharacterParams12.y);
                float blendedLightInt = lerp(1.0, 1.0, _CharacterParams12.w);

                // ---- Camera forward ----
                float3 camFwd = float3(UNITY_MATRIX_I_V._m02, UNITY_MATRIX_I_V._m12, UNITY_MATRIX_I_V._m22);

                // ---- Camera-light facing ----
                float cfXZLen = rsqrt(camFwd.x * camFwd.x + camFwd.z * camFwd.z);
                float camLightDot = saturate(-(adjXZ_x * (cfXZLen * camFwd.x) + adjXZ_z * (cfXZLen * camFwd.z)));
                float camYFade = saturate(2.0 * (0.75 - abs(camFwd.y)));
                float camYSmooth = camYFade * camYFade * (3.0 - 2.0 * camYFade);

                // ==== DIFFUSE RAMP ====
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

                // ---- Shadow terms (charShadow=1) ----
                float castShadow = lerp(smoothstep(0.0, 1.0, mainLight.shadowAttenuation), 1.0, _CharacterParams1.z);
                float charShadowMask = shadowMask;
                float minShadow = min(rampA, shadowMask) * castShadow;
                float viewShadowProduct = viewRampA * charShadowMask;

                // ==== NPR DIFFUSE COMPOSITION (charShadow=1) ====
                float3 albScaled = shadowDiff * _CharacterParams0.z;
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

                float3 rampTinted = shadowBlended * (rampCol * rampChroma + rampChromaInv);

                float3 viewDepShad = viewShadowProduct * ((diffColor - diffColorLum) * 1.2 + diffColorLum - albScaled) + albScaled;

                float shadowLumVal = dot(shadowBlended, LUM);
                float rampLumVal = dot(rampTinted, LUM);
                float lumRatio = clamp(shadowLumVal / max(rampLumVal, 0.001), 0.0, 1.5);

                float3 nprDiff = rampTinted * lumRatio;

                float ambDiffInt = minShadow * (1.0 - _CharacterParams0.z) + _CharacterParams0.z;
                float specAmbInt = ambDiffInt * (minShadow * 0.5 + 0.5);

                // ==== KAJIYA-KAY ANISOTROPIC SPECULAR ====
                #ifdef _STROKE_ON
                    float2 strokeUV = uv * _StrokeMap_ST.xy + _StrokeMap_ST.zw;
                    float strokeVal = SAMPLE_TEXTURE2D(_StrokeMap, sampler_BaseMap, strokeUV).r * 2.0 - 1.0;
                    float anisoShift1 = strokeVal * _StrokeScale + _AnisotropyValue * 2.0 - 1.0;
                    float anisoShift2 = strokeVal * _StrokeScale + _AnisotropyValue2 * 2.0 - 1.0;
                #else
                    float anisoShift1 = _AnisotropyValue * 2.0 - 1.0;
                    float anisoShift2 = _AnisotropyValue2 * 2.0 - 1.0;
                #endif

                float3 shiftedT1 = normalize(specN * anisoShift1 + modBitan);

                float3 worldContrib = otwCol0 * vDotC0 + otwCol1 * adjustedLightDir.y + otwCol2 * vDotC2;
                float3 modL = adjustedLightDir + worldContrib * 2.0;
                float3 H = normalize(normalize(modL) + V);

                float TdotH1 = dot(shiftedT1, H);
                float sinTH1 = max(sqrt(1.0 - TdotH1 * TdotH1), 0.0001);
                float strand1 = saturate(specScale * exp2(log2(sinTH1) * 200.0));

                float edgeFade2 = edgeFade * edgeFade;
                #ifdef _SPEC_RAMP_ON
                    float specRampV = edgeFade2 * ((TdotH1 > 0.0) ? 1.0 : 0.0);
                    float3 specRampSmp = SAMPLE_TEXTURE2D_LOD(_SpecRampMap, sampler_SpecRampMap, float2(strand1, specRampV), 0).rgb;
                    float3 strand1Spec = edgeFade * (strand1 * specRampSmp);
                #else
                    float3 strand1Spec = float3(1, 1, 1) * (edgeFade * strand1);
                #endif
                float strand1Max = max(strand1Spec.r, max(strand1Spec.g, strand1Spec.b));

                float3 shiftedT2 = normalize(specN * anisoShift2 + modBitan);
                float TdotH2 = dot(shiftedT2, H);
                float sinTH2 = max(sqrt(1.0 - TdotH2 * TdotH2), 0.0001);
                float strand2Exp = trunc(max(1.0 - _AnisotropyRange2, 0.0) * 200.0);
                float strand2Raw = edgeFade * exp2(log2(sinTH2) * strand2Exp);
                float3 strand2Spec = darkenedScale * (strand2Raw * (smoothness * _AnisotropyColor2.rgb));

                // ==== SPECULAR LINE ====
                #ifdef _SPECULAR_LINE
                    float2 lineUV = uv * _LineMap_ST.xy + _LineMap_ST.zw;
                    float lineMapVal = SAMPLE_TEXTURE2D(_LineMap, sampler_BaseMap, lineUV).x;

                    float lineShift = _LineValue * 2.0 - 1.0;
                    float3 shiftedTL = normalize(specN * lineShift + modBitan);
                    float TdotHL = dot(shiftedTL, H);
                    float sinTHL = max(sqrt(1.0 - TdotHL * TdotHL), 0.0001);

                    float procLine = ceil(max(frac(uv.x * _LineAmount) - 0.5, 0.0));
                    float lineBlend = (_UseLineMap * (-procLine + (1.0 - lineMapVal)) + procLine) * _LineIntensity + (1.0 - _LineIntensity);

                    float lineExp = trunc(max(1.0 - _LineRange, 0.0) * 200.0);
                    float lineMod = specScale * ((lineBlend + (1.0 - lineBlend) * strand1Max - 1.0) * exp2(log2(sinTHL) * lineExp)) + 1.0;
                #else
                    float lineMod = 1.0;
                #endif

                // ==== MAIN LIT COMPOSITION ====
                float alphaPremul = mad(baseAlpha, _AlphaPremultiply, 1.0 - _AlphaPremultiply);
                float3 mainLit = fullDiff * nprDiff * alphaPremul;
                float3 lineSatLit = lineMod * mainLit;
                float lineSatLitLum = dot(lineSatLit, LUM);
                float lineSatFactor = lineMod * (1.0 - _LineSaturation) + _LineSaturation;
                float3 diffContrib = (lineSatFactor * (lineSatLit - lineSatLitLum) + lineSatLitLum);

                float3 anisoSpec;
                anisoSpec.r = darkenedScale * ((dielSpec * strand1Spec.r) * _AnisotropyIntensity) * 5.0 + lerp(strand2Spec.r, 0.0, strand1Max);
                anisoSpec.g = darkenedScale * ((dielSpec * strand1Spec.g) * _AnisotropyIntensity) * 5.0 + lerp(strand2Spec.g, 0.0, strand1Max);
                anisoSpec.b = darkenedScale * ((dielSpec * strand1Spec.b) * _AnisotropyIntensity) * 5.0 + lerp(strand2Spec.b, 0.0, strand1Max);
                float3 specContrib = (specAmbInt * fullDiff) * anisoSpec * _CharacterParams13.w;

                float3 combined = diffContrib + specContrib;
                float combinedLum = dot(combined, LUM);
                float desatAmt = clamp(combinedLum - 0.5, 0.0, 0.5);

                // ==== SKIN SPECULAR CP8/CP9 (depth-based edge detection) ====
                float cp9x = _CharacterParams9.x;
                float cp9y = _CharacterParams9.y;
                float3 skinDir;
                skinDir.x = -cp9y * camFwd.z;
                skinDir.y = camFwd.z * cp9x;
                skinDir.z = camFwd.x * cp9y - cp9x * camFwd.y;
                skinDir = normalize(skinDir);

                float3 viewN = mul((float3x3)UNITY_MATRIX_V, N);
                float viewNLen = rsqrt(viewN.x*viewN.x + viewN.y*viewN.y);
                float2 viewNDir = float2(viewN.x * viewNLen, viewN.y * viewNLen);
                float aspect = _ScreenParams.y / _ScreenParams.x;

                float2 screenUV = screenPos.xy / screenPos.w;
                float2 depthSampleUV = screenUV + viewNDir * float2(aspect, 1.0) * _CharacterParams9.w * 0.006;
                depthSampleUV = clamp(depthSampleUV, 1.0 / _ScreenParams.xy, 1.0 - 1.0 / _ScreenParams.xy);

                float sampledDepth = SampleSceneDepth(depthSampleUV);
                float sampledLinear = 1.0 / (_ZBufferParams.z * sampledDepth + _ZBufferParams.w);
                float fragLinear = screenPos.w;
                float depthDiff = (sampledLinear - fragLinear - 0.1) * 10.0;
                float depthT = saturate(depthDiff);
                float depthSmooth = depthT * depthT * (3.0 - 2.0 * depthT);

                float skinNdotL = min(charShadowMask, min(shadowMask, saturate(dot(flatDir, skinDir) + 1.0)));
                float skinNdotBN = saturate(dot(skinDir, N));

                float3 skinSpec;
                skinSpec.r = skinNdotL * ((depthSmooth * _CharacterParams8.x) * _CharacterParams8.w) * skinNdotBN * (_CharacterParams9.z * (diffColor.r - 0.25) + 0.25);
                skinSpec.g = skinNdotL * ((depthSmooth * _CharacterParams8.y) * _CharacterParams8.w) * skinNdotBN * (_CharacterParams9.z * (diffColor.g - 0.25) + 0.25);
                skinSpec.b = skinNdotL * ((depthSmooth * _CharacterParams8.z) * _CharacterParams8.w) * skinNdotBN * (_CharacterParams9.z * (diffColor.b - 0.25) + 0.25);

                // ==== SUBSURFACE SPECULAR ====
                float mainNdotL_xz = dot(float3(adjXZ_x, adjXZLen * NEAR_ZERO_Y, adjXZ_z), N);
                float wrapNdotL = saturate(0.5 + mainNdotL_xz - 0.5 * mainNdotL_xz * mainNdotL_xz);
                float camLightFacing = (1.0 - _CharacterParams12.x) * camLightDot;
                float VdotN = dot(V, N);
                float edgeT2 = saturate((-abs(VdotN) + 0.4) * 5.0);
                float edgeFresnel = edgeT2 * edgeT2 * (3.0 - 2.0 * edgeT2);
                float brightT = saturate((diffColorLum - 0.1) * (-16.6667));
                float brightnessGate = brightT * brightT * (3.0 - 2.0 * brightT);
                float3 subsurfLight = blendedLightCol * blendedLightInt;
                float3 subsurfSpec = brightnessGate * (shadowMask * (edgeFresnel * (camLightFacing * (wrapNdotL * subsurfLight)))) * max(diffColor, 0.15);

                // ==== FINAL ASSEMBLY ====
                float desatFactor = desatAmt * desatAmt + 1.0;
                float3 desatCombined = desatFactor * (combined - combinedLum) + combinedLum;

                float3 litColor = desatCombined + skinSpec + subsurfSpec;

                // ==== VFX COLOR ADJUSTMENT ====
                if (_EnableVFXColorAdjustment > 0.5) {
                    float NdotV_spec = saturate(dot(N, V));
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
            Blend [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend]
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
                #pragma shader_feature _NORMALMAP
                #pragma shader_feature _SPECULAR_NORMALMAP
                #pragma shader_feature _METALLICSPECGLOSSMAP
                #pragma shader_feature _DIFF_RAMP_ON
                #pragma shader_feature _SHADOW_LUT_TEX
                #pragma shader_feature _SPEC_RAMP_ON
                #pragma shader_feature _SPECULAR_LINE
                #pragma shader_feature _STROKE_ON
                #pragma shader_feature _ALPHATEST_ON
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
                    float4 positionCS  : SV_Position;
                    float2 uv          : TEXCOORD0;
                    float3 positionWS  : TEXCOORD1;
                    float3 normalWS    : TEXCOORD2;
                    float4 tangentWS   : TEXCOORD3;
                    float4 screenPos   : TEXCOORD4;
                };

                Varyings vert(Attributes input) {
                    Varyings o = (Varyings)0;
                    VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);

                    VertexNormalInputs nrmIn = GetVertexNormalInputs(input.normalOS, input.tangentOS);
                    o.positionCS = posIn.positionCS;
                    o.positionWS = posIn.positionWS;
                    o.normalWS   = nrmIn.normalWS;
                    o.tangentWS  = float4(nrmIn.tangentWS, input.tangentOS.w);
                    o.uv = input.uv * _BaseMap_ST.xy + _BaseMap_ST.zw;
                    o.screenPos = ComputeScreenPos(posIn.positionCS);
                    return o;
                }

                float4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target {
                    float faceSign = isFrontFace ? 1.0 : (_BackFaceNormalFlip * 2.0 - 1.0);
                    float4 baseSample = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, input.uv);
                    float3 albedo = baseSample.rgb * _BaseColor.rgb;
                    float baseAlpha = baseSample.a * _BaseColor.a;
                    #ifdef _ALPHATEST_ON
                        clip(baseAlpha - _AlphaClipThreshold);
                    #endif
                    float3 shadowColor;
                    float3 color = computeNPRLighting(input.uv, input.positionWS, input.normalWS, input.tangentWS, faceSign, albedo, baseAlpha, input.screenPos, shadowColor);
                    color = ApplyCustomAO(color, shadowColor, GetNormalizedScreenSpaceUV(input.positionCS));
                    float alpha = (_SurfaceType == 1.0) ? baseSample.a : 1.0;
                    return float4(color, alpha);
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 2: Character Outline (inverted hull, full NPR lighting)
        // ================================================================
        Pass {
            Name "CharacterOutline"
            Blend [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend]
            Cull Front
            ZWrite On
            ZTest Less
            Tags { "LightMode"="SRPDefaultUnlit" }
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex outlineVert
                #pragma fragment outlineFrag
                #pragma shader_feature _NORMALMAP
                #pragma shader_feature _SPECULAR_NORMALMAP
                #pragma shader_feature _METALLICSPECGLOSSMAP
                #pragma shader_feature _DIFF_RAMP_ON
                #pragma shader_feature _DRAW_UNDER_BROW
                #pragma shader_feature _OUTLINE_MASK
                #pragma shader_feature _SHADOW_LUT_TEX
                #pragma shader_feature _SPEC_RAMP_ON
                #pragma shader_feature _SPECULAR_LINE
                #pragma shader_feature _STROKE_ON
                #pragma shader_feature _ALPHATEST_ON
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
                    float4 screenPos  : TEXCOORD4;
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
                    // screenPos from original clip pos (before outline displacement) for depth sampling
                    o.screenPos = ComputeScreenPos(posIn.positionCS);

                    // Choose normal: smooth (UV2 tangent-space) or regular vertex normal
                    float3 normalWS = nrmIn.normalWS;
                    if (_OutlineAverageNormal > 0.5) {
                        float2 ts = input.smoothNrmTS;
                        float z = sqrt(max(1.0 - dot(ts, ts), 0.0));
                        float3 bitWS = cross(nrmIn.normalWS, nrmIn.tangentWS) * input.tangentOS.w;
                        normalWS = normalize(nrmIn.tangentWS * ts.x + bitWS * ts.y + nrmIn.normalWS * z);
                    }

                    float4 clipPos = posIn.positionCS;

                    // Outline mask
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

                    // Z offset with mask
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
                    // BrowMask discard — disabled in URP forward pipeline.
                    // In HGRP deferred, PreGBuffer discards browMask area (creating depth holes
                    // for face to show through), so the outline discard matched. In URP without
                    // PreGBuffer, hair renders opaque everywhere, so discarding outline only
                    // creates visual gaps. Re-enable when depth prepass transparency (task 4) is implemented.
                    // #ifdef _DRAW_UNDER_BROW
                    //     float browMask = SAMPLE_TEXTURE2D(_HairBrowMask, sampler_HairBrowMask, input.uv).x;
                    //     clip(browMask - _HairBrowMaskThreshold);
                    // #endif

                    float4 baseSample = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, input.uv);
                    float3 rawAlbedo = baseSample.rgb * _BaseColor.rgb;
                    float baseAlpha = baseSample.a * _BaseColor.a;
                    #ifdef _ALPHATEST_ON
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
                    float3 color = computeNPRLighting(input.uv, input.positionWS, input.normalWS, input.tangentWS, 1.0, albedo, baseAlpha, input.screenPos, shadowColorUnused);
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
                #pragma shader_feature _ALPHATEST_ON

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
                    // URP runs DepthNormalsOnly as a depth pre-pass for SSAO.
                    // Without this clip, back-face fragments (Cull=Both / Off)
                    // write depth even on transparent hair-tip pixels, exposing
                    // the mesh silhouette from behind. Matches ShadowCaster.
                    #ifdef _ALPHATEST_ON
                        float baseAlpha = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, input.uv).a * _BaseColor.a;
                        clip(baseAlpha - _AlphaClipThreshold);
                    #endif
                    #ifdef _NORMALMAP
                        float4 nrmSmp = SAMPLE_TEXTURE2D(_SplitNormalMap, sampler_SplitNormalMap, input.uv);
                        float nrmX = (nrmSmp.x * 2.0 - 1.0) * _BumpScale;
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
