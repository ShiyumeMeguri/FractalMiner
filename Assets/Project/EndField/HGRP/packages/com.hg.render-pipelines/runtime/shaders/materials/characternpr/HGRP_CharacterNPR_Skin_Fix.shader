// Merged HGRP CharacterNPR Skin shader — ForwardLit + Outline.
// Merged from body (5e955a99) and face (ce05d1bb) variants.
// Keywords control face-specific features: _SDFLIGHTMAP, _EMOTION_MAP, _HIGHLIGHT_MAP, _OUTLINE_MASK.
// Without these keywords, behavior matches the body variant exactly.
//
// Kept: Normal Map, Diffuse Ramp, Shadow LUT, GGX Specular, Skin Specular (CP8/CP9),
//   Subsurface Specular, Fresnel Rim, Character Outline, VFX Color Adjustment.
// Face features (keyword-gated): SDF Lightmap, SDF Mask, Emotion Map, Highlight Map,
//   CP14 Secondary Specular, Outline Mask, face-modified rim/specular.

Shader "HGRP/CharacterNPR_Skin_Fix" {
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
        [Toggle(_SHADOW_LUT_TEX)] _UseShadowLutTex ("Use Shadow LUT", Float) = 0
        _ShadowLutTex ("Shadow Color LUT", 2D) = "white" {}
        [Gamma] _Metallic ("Metallic", Range(0, 1)) = 0
        _Specular ("Specular Scale", Range(0, 1)) = 1
        _Smoothness ("Smoothness", Range(0, 1)) = 0.5
        [Toggle(_NORMALMAP)] _UseBumpMap ("Use Normal Map", Float) = 0
        _BumpScale ("Normal Scale", Float) = 1
        _BumpMap ("Normal Map", 2D) = "bump" {}
        [Toggle(_DIFF_RAMP_ON)] _UseDiffRampMap ("Diffuse Ramp", Float) = 0
        _DiffRampMap ("Diffuse Ramp", 2D) = "white" {}
        _SDFRimColor ("Skin Rim Color", Color) = (1, 1, 1, 1)
        _SkinRimOffScale ("Skin Rim Scale", Range(0, 1.5)) = 0.5
        [HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}

        [Header(Face Features)]
        [Toggle(_SDFLIGHTMAP)] _UseSDFLightmap ("Use SDF Lightmap", Float) = 0
        _SDFLightmap ("SDF Lightmap", 2D) = "black" {}
        _SDFMask ("SDF Mask (rim/blend/body/ctrl)", 2D) = "black" {}
        _FaceRimOffScale ("Face Rim Scale (SDF Area)", Range(0, 1.5)) = 1
        [HideInInspector] _FaceForward ("Face Forward (World)", Vector) = (0, 0, 1, 0)
        [HideInInspector] _FaceRight ("Face Right (World)", Vector) = (1, 0, 0, 0)
        [Toggle(_EMOTION_MAP)] _UseEmotionMap ("Use Emotion Map", Float) = 0
        _EmotionMap ("Emotion Map", 2D) = "black" {}
        [IntRange] _EmotionIndex ("Emotion Index", Range(0, 3)) = 0
        _EmotionBlend ("Emotion Blend", Range(0, 1)) = 1
        [Toggle(_HIGHLIGHT_MAP)] _FaceHighlightMap ("Use Highlight Map", Float) = 0
        [Gamma] _HighlightMap ("Highlight Map", 2D) = "black" {}
        _HighlightMapVector ("Highlight Map Vector", Vector) = (0.04, -0.01, 0, 0)

        [Header(Outline)]
        [ToggleUI] _EnableOutline ("Enable Outline", Float) = 1
        _OutlineWidth ("Outline Width", Range(0, 2)) = 0.5
        _OutlineOffsetZ ("Outline Offset Z", Range(0, 1)) = 0.08
        _OutlineColorBrightness ("Outline Color Brightness", Range(0, 1)) = 0.7
        _OutlineColorSaturation ("Outline Color Saturation", Range(0, 4)) = 2.0
        [ToggleUI] _OutlineAverageNormal ("Use Smooth Normal (UV2)", Float) = 1
        _OutlineMask ("Outline Mask", 2D) = "white" {}
        [ToggleUI] _OutlineTintEnable ("Outline Tint Enable", Float) = 0
        _OutlineTintColor ("Outline Tint Color", Color) = (0, 0, 0, 0)

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
        _CharacterParams0 ("CP0 (.y=diffuse .z=LUT .w=brightness)", Vector) = (0, 1, 0.7, 1)
        _CharacterParams1 ("CP1 (.x=brightMix .y=shadowStr .z=shadowLerp .w=lightDirOverride)", Vector) = (0, 0, 0, 0)
        _CharacterParams3 ("CP3 (ambient color rgb)", Vector) = (1, 1, 1, 0)
        _CharacterParams4 ("CP4 (light color override rgb)", Vector) = (1, 1, 1, 1)
        _CharacterParams6 ("CP6 (ambient direction)", Vector) = (0, 1, 0, 0)
        _CharacterParams7 ("CP7 (.x=offset .y=scale .z=bias)", Vector) = (0.15, 0.6, 1, 0)
        _CharacterParams8 ("CP8 (skin spec color rgb + .w=intensity)", Vector) = (0, 0, 0, 1)
        _CharacterParams9 ("CP9 (skin spec .xy=dir .z=tint .w=width)", Vector) = (0, 1, 0, 0.4)
        _CharacterParams11 ("CP11 (light dir override xyz + .w=rampBias)", Vector) = (-0.433, 0.5, 0.75, 0)
        _CharacterParams12 ("CP12 (.x=rampOffset .y=lightColOverride .z=shadowGate .w=exposureBlend)", Vector) = (0, 0, 0, 0)
        _CharacterParams13 ("CP13 (.w=GGX specular toggle)", Vector) = (0, 0, 0, 1)
        _CharacterParams14 ("CP14 (secondary spec color rgb + .w=intensity)", Vector) = (0, 0, 0, 0)
        _CharacterParams15 ("CP15 (.z=SDF secondary threshold)", Vector) = (0, 0, 0, 0)
        _EnvironmentGlobalParams0 ("EnvGlobalParams0", Vector) = (1.67, 1.5, 1, 0)
        _ExposureParams ("ExposureParams", Vector) = (1, 0, 0, 0)

        [Header(Workarounds)]
        [Toggle] _FBXRotationFix ("FBX -90 Z Rotation Fix (OTW col0/col1 swap)", Float) = 0
        _ShadowBlurRadius ("Shadow Blur Radius (Screen Space)", Range(0, 8)) = 2.5

        [Header(Behind Hair Composite)]
        // 0 = face skin (acts as depth blocker), 1 = brow (renders with behindAlpha)
        [HideInInspector] _DrawBehindHair ("Draw Behind Hair", Float) = 0
        _DrawBehindHairAlpha ("Behind Hair Alpha", Range(0, 1)) = 0.3
    }
    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Opaque" }
        LOD 600

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float _Smoothness;
                float _Specular;
                float _Metallic;
                float _BackFaceNormalFlip;
                float _FBXRotationFix;
                float _ShadowBlurRadius;
                float _BumpScale;
                float4 _BaseMap_ST;
                float4 _SDFRimColor;
                float4 _BaseColor;
                float _SkinRimOffScale;
                float _FaceRimOffScale;
                float4 _FaceForward;
                float4 _FaceRight;
                float _EmotionIndex;
                float _EmotionBlend;
                float4 _HighlightMapVector;
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
                float4 _CharacterParams3;
                float4 _CharacterParams4;
                float4 _CharacterParams6;
                float4 _CharacterParams7;
                float4 _CharacterParams8;
                float4 _CharacterParams9;
                float4 _CharacterParams11;
                float4 _CharacterParams12;
                float4 _CharacterParams13;
                float4 _CharacterParams14;
                float4 _CharacterParams15;
                float4 _EnvironmentGlobalParams0;
                float4 _ExposureParams;
                // Behind-Hair Composite
                float _DrawBehindHair;
                float _DrawBehindHairAlpha;
            CBUFFER_END

            TEXTURE2D(_BaseMap);        SAMPLER(sampler_BaseMap);
            TEXTURE2D(_BumpMap);        SAMPLER(sampler_BumpMap);
            TEXTURE2D(_DiffRampMap);    SAMPLER(sampler_DiffRampMap);
            TEXTURE2D(_ShadowLutTex);   SAMPLER(sampler_ShadowLutTex);
            TEXTURE2D(_SDFLightmap);    SAMPLER(sampler_SDFLightmap);
            TEXTURE2D(_SDFMask);        SAMPLER(sampler_SDFMask);
            TEXTURE2D(_EmotionMap);
            TEXTURE2D(_HighlightMap);
            TEXTURE2D(_OutlineMask);    SAMPLER(sampler_OutlineMask);

            static const float3 LUM = float3(0.2126729, 0.7152, 0.07217500);
            static const float NEAR_ZERO_Y = 6.103515625e-05; // asfloat(947912704u)

            float LinearToSRGB_Custom(float c) {
                return (c <= 0.0031308) ? (c * 12.92)
                    : (1.055 * pow(abs(c), 0.41666666) - 0.055);
            }

            // ================================================================
            // Shared NPR lighting — used by both ForwardLit and Outline passes
            // Body: standard skin lighting with subsurface.
            // Face (_SDFLIGHTMAP): adds SDF lightmap, face rim, camera gate,
            //   CP14 secondary specular, face-modified VFX rim.
            // ================================================================
            float3 computeNPRLighting(float2 uv, float3 positionWS, float3 normalWS_raw, float4 tangentWS, float faceSign, float3 albedo, float baseAlpha) {
                // ---- Object-to-World ----
                #if defined(_SDFLIGHTMAP) || defined(_HIGHLIGHT_MAP)
                    float3 objectRight   = float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20);
                    float3 objectUp      = float3(unity_ObjectToWorld._m01, unity_ObjectToWorld._m11, unity_ObjectToWorld._m21);
                    float3 objectForward = float3(unity_ObjectToWorld._m02, unity_ObjectToWorld._m12, unity_ObjectToWorld._m22);
                    if (_FBXRotationFix > 0.5) {
                        float3 tmp = objectRight;
                        objectRight = objectUp;
                        objectUp = -tmp;
                    }
                #endif
                float originX = unity_ObjectToWorld._m03;
                float originZ = unity_ObjectToWorld._m23;

                // ---- View direction ----
                float3 toCam = _WorldSpaceCameraPos - positionWS;
                float3 orthoFwd = float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22);
                float3 viewRaw = toCam + unity_OrthoParams.w * (orthoFwd - toCam);
                float3 V = normalize(viewRaw);

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

                // ---- sRGB for Shadow LUT UV ----
                #ifdef _SHADOW_LUT_TEX
                    float sR = saturate(LinearToSRGB_Custom(albedo.r));
                    float sG = saturate(LinearToSRGB_Custom(albedo.g));
                    float sB = saturate(LinearToSRGB_Custom(albedo.b));
                    float bSlice = floor(sB * 31.0);
                    float lutU = bSlice * 0.03125 + sR * 0.0302734375 + 0.00048828125;
                    float lutV = sG * 0.96875 + 0.015625;
                #endif

                // ---- SDF Mask ----
                #ifdef _SDFLIGHTMAP
                    float4 sdfMask = SAMPLE_TEXTURE2D(_SDFMask, sampler_SDFMask, uv);
                #else
                    float4 sdfMask = float4(1, 1, 0, 0);
                #endif

                // ---- Flat direction: origin->fragment on XZ ----
                float fX = positionWS.x - originX;
                float fZ = positionWS.z - originZ;
                float fLen = rsqrt(fX*fX + NEAR_ZERO_Y*NEAR_ZERO_Y + fZ*fZ);
                float3 flatDir = float3(fX*fLen, NEAR_ZERO_Y*fLen, fZ*fLen);

                // ---- Camera forward ----
                float3 camFwd = float3(UNITY_MATRIX_I_V._m02, UNITY_MATRIX_I_V._m12, UNITY_MATRIX_I_V._m22);

                #ifdef _SDFLIGHTMAP
                    float3 faceUp = cross(_FaceForward.xyz, _FaceRight.xyz);
                    float3 camFwdObj = float3(
                        dot(camFwd, _FaceRight.xyz),
                        dot(camFwd, faceUp),
                        dot(camFwd, _FaceForward.xyz)
                    );
                    float camFwdObjLen = rsqrt(max(dot(camFwdObj, camFwdObj), 1.175494e-38));
                    camFwdObj *= camFwdObjLen;
                    float camFwdObj_xz_invLen = rsqrt(camFwdObj.x * camFwdObj.x + camFwdObj.z * camFwdObj.z);
                #endif

                // ---- Flat normal XZ for hemisphere NdotL ----
                float3 vertNFlatXZ = float3(N.x, NEAR_ZERO_Y, N.z);
                float vertNFlatLen = rsqrt(dot(vertNFlatXZ, vertNFlatXZ));
                vertNFlatXZ *= vertNFlatLen;

                #ifdef _SDFLIGHTMAP
                    float3 blendedDir = normalize(lerp(flatDir, vertNFlatXZ, sdfMask.y));
                #else
                    float3 blendedDir = vertNFlatXZ;
                #endif

                // ---- Exposure ----
                float exposure = (_CharacterParams12.w * (1.0 - _EnvironmentGlobalParams0.x) + _EnvironmentGlobalParams0.x) * _ExposureParams.x;

                // ---- Ambient ----
                float ambInt = exposure;
                float3 ambCol = _CharacterParams3.xyz;

                // ---- Rim ----
                float rimModifier;
                #ifdef _SDFLIGHTMAP
                    float camAngleBias = saturate(camFwdObj.z * camFwdObj_xz_invLen + 0.5);
                    rimModifier = lerp(camAngleBias, 1.0, sdfMask.y) * sdfMask.x;
                #else
                    rimModifier = 1.0;
                #endif

                float rimOffScale;
                #ifdef _SDFLIGHTMAP
                    rimOffScale = lerp(_FaceRimOffScale, _SkinRimOffScale, sdfMask.z);
                #else
                    rimOffScale = _SkinRimOffScale;
                #endif

                float NdotV = dot(N, V);
                float NdotV_sat = saturate(NdotV);
                float rimFresnel = 1.0 - (NdotV_sat * 0.85 + 0.15);
                float rimAmt = saturate(rimFresnel * rimModifier * rimOffScale);
                float rimInv = 1.0 - rimAmt;
                float3 rimFactor = _SDFRimColor.rgb * rimAmt + rimInv;
                float3 rimAlbedo = albedo * rimFactor;

                // ---- Metallic workflow ----
                float specScale;
                #ifdef _SDFLIGHTMAP
                    specScale = sdfMask.y * _Specular;
                #else
                    specScale = _Specular;
                #endif
                float roughnessRaw = 1.0 - _Smoothness;
                float oneMinusRefl = (1.0 - _Metallic) * 0.96;
                float3 diffColor = oneMinusRefl * rimAlbedo;
                float dielSpec = specScale * 0.04;
                float3 specColor = _Metallic * (rimAlbedo - dielSpec) + dielSpec;

                // ---- Shadow LUT ----
                #ifdef _SHADOW_LUT_TEX
                    float4 lut0 = SAMPLE_TEXTURE2D_LOD(_ShadowLutTex, sampler_ShadowLutTex, float2(lutU, lutV), 0);
                    float4 lut1 = SAMPLE_TEXTURE2D_LOD(_ShadowLutTex, sampler_ShadowLutTex, float2(lutU + 0.03125, lutV), 0);
                    float bFrac = sB * 31.0 - bSlice;
                    float3 shadowLut = oneMinusRefl * lerp(lut0.rgb, lut1.rgb, bFrac);
                #else
                    float3 shadowLut = oneMinusRefl;
                #endif

                float roughness = max(roughnessRaw * roughnessRaw, 0.0078125);

                // ---- Main light from URP ----
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

                // ---- Camera-light dot (shared by subsurface + SDF backlit) ----
                float cfXZLen = rsqrt(camFwd.x * camFwd.x + camFwd.z * camFwd.z);
                float camLightDot = -(adjXZ_x * (cfXZLen * camFwd.x) + adjXZ_z * (cfXZLen * camFwd.z));

                // ---- Light color blend ----
                float3 blendedLightCol;
                blendedLightCol.r = lightCol.r + _CharacterParams12.y * (_CharacterParams4.x - lightCol.r);
                blendedLightCol.g = lightCol.g + _CharacterParams12.y * (_CharacterParams4.y - lightCol.g);
                blendedLightCol.b = lightCol.b + _CharacterParams12.y * (_CharacterParams4.z - lightCol.b);
                float blendedLightInt = _CharacterParams12.w * (1.0 - lightInt) + lightInt;

                // ==== SDF LIGHTMAP ====
                #ifdef _SDFLIGHTMAP
                    float objLightX = dot(adjustedLightDir, _FaceRight.xyz);
                    float objLightZ = dot(adjustedLightDir, _FaceForward.xyz);
                    float objLight_invLen = rsqrt(objLightX * objLightX + NEAR_ZERO_Y * NEAR_ZERO_Y + objLightZ * objLightZ);
                    float sdfLightZ = objLight_invLen * objLightZ;
                    float lightSide = (objLight_invLen * objLightX > 0.0) ? 1.0 : 0.0;

                    float mirrorU = 1.0 - uv.x;
                    float2 sdfUV = float2(
                        mad(lightSide, uv.x - mirrorU, mirrorU),
                        uv.y
                    );
                    float4 sdfSample = SAMPLE_TEXTURE2D_LOD(_SDFLightmap, sampler_SDFLightmap, sdfUV, 0);
                    float sdfValue = sdfSample.x + sdfSample.y;

                    // Derive flat normal from SDF
                    float sdfNx_base = 1.0 - 2.0 * sdfSample.z;
                    float sdfNx = mad(lightSide, (2.0 * sdfSample.z - 1.0) - sdfNx_base, sdfNx_base);
                    float sdfNz = 1.0 - abs(sdfNx);
                    float3 sdfFlatN = normalize(float3(sdfNx, NEAR_ZERO_Y, sdfNz));

                    // Transform SDF normal to world space
                    float3 sdfNormalWS = normalize(sdfFlatN.x * _FaceRight.xyz + sdfFlatN.y * faceUp + sdfFlatN.z * _FaceForward.xyz);

                    // Blend SDF normal with vertex normal
                    float3 sdfBlendedN = normalize(lerp(sdfNormalWS, N, sdfMask.y));

                    // ---- Wrap NdotL for SDF threshold ----
                    float backlitFactor = saturate(camLightDot) * saturate(-sdfLightZ) * (1.0 - _CharacterParams12.x);
                    float wrapTerm = 0.5 * (1.0 - sdfLightZ * sdfLightZ);
                    float sdfWrapNdotL = sdfLightZ + backlitFactor * wrapTerm;

                    // ---- SDF threshold -> sdfNdotL ----
                    float halfWrap = sdfWrapNdotL * 0.5;
                    float sdfT = clamp(0.5 - halfWrap, 0.001, 0.999);
                    float sdfLo = max(2.0 * sdfT - 1.0, 0.0);
                    float sdfHi = min(2.0 * sdfT, 1.0);
                    float sdfS = saturate((sdfValue * 0.5 - sdfLo) / (sdfHi - sdfLo));
                    float sdfSS = sdfS * sdfS * (3.0 - 2.0 * sdfS);
                    float halfCeil = ceil(halfWrap) * halfWrap;
                    float sdfNdotL = (sdfSS + halfCeil) * 2.0 - 1.0;
                #else
                    float3 sdfBlendedN = N;
                #endif

                // ==== DIFFUSE RAMP ====
                float geomNdotL = dot(N, adjustedLightDir);
                float clampedNdotL = clamp(_CharacterParams11.w * _CharacterParams12.x + geomNdotL, -1.0, 1.0);

                #ifdef _SDFLIGHTMAP
                    float rampInput = lerp(sdfNdotL, clampedNdotL, sdfMask.y) * 0.5 + 0.5;
                #else
                    float rampInput = clampedNdotL * 0.5 + 0.5;
                #endif

                #ifdef _DIFF_RAMP_ON
                    float4 rampSmp = SAMPLE_TEXTURE2D_LOD(_DiffRampMap, sampler_DiffRampMap, float2(rampInput, 0.5), 0);
                    float3 rampCol = rampSmp.rgb;
                    float rampA = rampSmp.a;
                    float rampChroma = max(rampCol.r, max(rampCol.g, rampCol.b)) - min(rampCol.r, min(rampCol.g, rampCol.b));
                    float rampChromaInv = 1.0 - rampChroma;
                #else
                    float3 rampCol = float3(1, 1, 1);
                    float rampA = 1.0;
                    float rampChroma = 0.0;
                    float rampChromaInv = 1.0;
                #endif

                // ==== NPR DIFFUSE COMPOSITION (charShadow=1) ====
                float3 albScaled = shadowLut * _CharacterParams0.z;
                float diffColorLum = dot(diffColor, LUM);
                #ifdef _SDFLIGHTMAP
                    float castShadow = 1.0;
                #else
                    float castShadow = lerp(smoothstep(0.0, 1.0, mainLight.shadowAttenuation), 1.0, _CharacterParams1.z);
                #endif
                float minShadow = min(rampA, baseAlpha) * castShadow;

                // Hemisphere NdotL (uses SDF-blended direction when available)
                float nprNdotL = saturate(dot(blendedDir, _CharacterParams6.xyz) + _CharacterParams7.x) * _CharacterParams7.y + _CharacterParams7.z;
                float shadowStr = minShadow * _CharacterParams1.y;

                // Shadowed ambient
                float3 shadAmb;
                shadAmb.r = nprNdotL * (shadowStr * (1.0 - ambCol.r) + ambCol.r);
                shadAmb.g = nprNdotL * (shadowStr * (1.0 - ambCol.g) + ambCol.g);
                shadAmb.b = nprNdotL * (shadowStr * (1.0 - ambCol.b) + ambCol.b);

                // Brightness
                float bright065 = min(ambInt * 0.35 + 0.65, 1.5);
                float brightFull = clamp(ambInt, 0.0, 1.5);
                float brightMix = lerp(bright065, clamp(ambInt, 1.25, 1.75), _CharacterParams1.x);

                // Light luminance
                float lightLum = dot(blendedLightCol * blendedLightInt, LUM);

                // Full diffuse
                float oneMinus12y = 1.0 - _CharacterParams12.y;
                float3 lightBlend = blendedLightCol * _CharacterParams12.y + oneMinus12y;
                float3 fullDiff;
                fullDiff.r = (shadAmb.r * brightFull * lightBlend.r + minShadow * (blendedLightCol.r * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;
                fullDiff.g = (shadAmb.g * brightFull * lightBlend.g + minShadow * (blendedLightCol.g * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;
                fullDiff.b = (shadAmb.b * brightFull * lightBlend.b + minShadow * (blendedLightCol.b * blendedLightInt - lightLum) + lightLum) * _CharacterParams0.y;

                // Shadow color desaturation
                float albScaledLum = dot(albScaled * 0.65, LUM);
                float3 desatShad;
                desatShad.r = (albScaled.r * 0.65 - albScaledLum) * 1.2 + albScaledLum;
                desatShad.g = (albScaled.g * 0.65 - albScaledLum) * 1.2 + albScaledLum;
                desatShad.b = (albScaled.b * 0.65 - albScaledLum) * 1.2 + albScaledLum;

                float combWeight = saturate(baseAlpha + rampA);
                float3 weightedAmb = lerp(desatShad, albScaled, combWeight);
                float3 shadowBlended = lerp(weightedAmb, diffColor, minShadow);

                // Ramp color tint
                float3 rampTinted;
                rampTinted.r = shadowBlended.r * (rampCol.r * rampChroma + rampChromaInv);
                rampTinted.g = shadowBlended.g * (rampCol.g * rampChroma + rampChromaInv);
                rampTinted.b = shadowBlended.b * (rampCol.b * rampChroma + rampChromaInv);

                // Luminance ratio
                float shadowLumVal = dot(shadowBlended, LUM);
                float rampLum = dot(rampTinted, LUM);
                float lumRatio = clamp(shadowLumVal / max(rampLum, 0.001), 0.0, 1.5);

                // Final NPR diffuse
                float3 nprDiff = rampTinted * lumRatio;

                // Attenuation
                float attenFac = minShadow;
                float ambDiffInt = (attenFac * (1.0 - _CharacterParams0.z) + _CharacterParams0.z) * (attenFac * 0.5 + 0.5);

                float3 ambDiff = ambDiffInt * fullDiff;

                // ==== GGX SPECULAR ====
                float NdotV_spec = saturate(dot(N, V));
                float3 camFwdMod = normalize(float3(camFwd.x, adjustedLightDir.y, camFwd.z));
                float3 H = normalize(V * 3.0 + adjustedLightDir + camFwdMod * 2.0);
                float NdotH = dot(N, H);
                float roughSq = roughness * roughness;
                float denom = (NdotH * roughSq - NdotH) * NdotH + 1.0;
                float denomSq = denom * denom;
                float D_raw = (denomSq != roughSq) ? roughSq / denomSq : 1.0;
                float ggxTerm = clamp(D_raw * 0.5 / (NdotV_spec * 2.0 + roughness + 1e-4) - NEAR_ZERO_Y, 0.0, 20.0);

                // ==== HIGHLIGHT MAP ====
                #ifdef _HIGHLIGHT_MAP
                    float hlOffsetX = dot(V, objectRight) * _HighlightMapVector.x;
                    float hlOffsetY = dot(V, objectUp) * _HighlightMapVector.y;
                    float3 hlSample = SAMPLE_TEXTURE2D(_HighlightMap, sampler_BaseMap, float2(uv.x + hlOffsetX, uv.y + hlOffsetY)).rgb;
                #else
                    float3 hlSample = float3(0, 0, 0);
                #endif

                // Main lit composition
                float3 mainLit;
                mainLit.r = fullDiff.r * nprDiff.r + ambDiff.r * (specColor.r * ggxTerm * _CharacterParams13.w + hlSample.r);
                mainLit.g = fullDiff.g * nprDiff.g + ambDiff.g * (specColor.g * ggxTerm * _CharacterParams13.w + hlSample.g);
                mainLit.b = fullDiff.b * nprDiff.b + ambDiff.b * (specColor.b * ggxTerm * _CharacterParams13.w + hlSample.b);
                float mainLitLum = dot(mainLit, LUM);
                float desatAmt = clamp(mainLitLum - 0.5, 0.0, 0.5);

                // ==== SKIN SPECULAR (CP8/CP9) ====
                float3 skinDir;
                skinDir.x = -_CharacterParams9.y * camFwd.z;
                skinDir.y =  camFwd.z * _CharacterParams9.x;
                skinDir.z =  camFwd.x * _CharacterParams9.y - _CharacterParams9.x * camFwd.y;
                skinDir = normalize(skinDir);

                // Face uses sdfBlendedN; body uses N (sdfBlendedN=N when SDF off)
                float skinNdotV = dot(V, sdfBlendedN);
                float skinFresnel = 1.0 - abs(skinNdotV);
                float skinLow = _CharacterParams9.w * (-0.6) + 0.8;
                float skinHigh = _CharacterParams9.w * (-0.4) + 0.9;
                float skinT = saturate((skinFresnel - skinLow) / (skinHigh - skinLow));
                float skinSmooth = skinT * skinT * (3.0 - 2.0 * skinT);

                // Face-specific camera angle gate; body uses skinSmooth directly
                float skinAmt;
                #ifdef _SDFLIGHTMAP
                    float camAngleAbs = abs(camFwdObj.z * camFwdObj_xz_invLen);
                    float camGateT = saturate((camAngleAbs - 0.9) * 10.0);
                    float camGate = camGateT * camGateT * (3.0 - 2.0 * camGateT);
                    float cp9wGate = saturate(_CharacterParams9.w * 10.0 - 3.0);
                    float camFacingSkin = (dot(camFwd, skinDir) < -0.01) ? 1.0 : 0.0;
                    skinAmt = lerp(camGate * skinSmooth, max(camGate, camFacingSkin) * sdfMask.w, cp9wGate);
                #else
                    skinAmt = skinSmooth;
                #endif

                float skinNdotL = saturate(dot(flatDir, skinDir) + 1.0);
                float skinShadow = min(baseAlpha, skinNdotL);
                float skinNdotBN = saturate(dot(skinDir, sdfBlendedN));

                // ==== SUBSURFACE SPECULAR ====
                float mainNdotL_xz = dot(float3(adjXZ_x, adjXZLen * NEAR_ZERO_Y, adjXZ_z), N);
                float wrapNdotL = saturate(0.5 + mainNdotL_xz - 0.5 * mainNdotL_xz * mainNdotL_xz);
                float camLightFacing = (1.0 - _CharacterParams12.x) * saturate(camLightDot);
                float edgeT = saturate((-abs(NdotV) + 0.4) * 5.0);
                float edgeFresnel = edgeT * edgeT * (3.0 - 2.0 * edgeT);
                float brightT = saturate((0.1 - diffColorLum) * 16.666);
                float brightnessGate = (brightT * brightT) * (3.0 - 2.0 * brightT);
                float3 subsurfLight = blendedLightCol * blendedLightInt;
                float3 subsurfSpec;
                subsurfSpec.r = brightnessGate * baseAlpha * edgeFresnel * camLightFacing * wrapNdotL * subsurfLight.r * max(diffColor.r, 0.15);
                subsurfSpec.g = brightnessGate * baseAlpha * edgeFresnel * camLightFacing * wrapNdotL * subsurfLight.g * max(diffColor.g, 0.15);
                subsurfSpec.b = brightnessGate * baseAlpha * edgeFresnel * camLightFacing * wrapNdotL * subsurfLight.b * max(diffColor.b, 0.15);

                // ==== CP14 SECONDARY SPECULAR ====
                float3 cp14Term = float3(0, 0, 0);
                #ifdef _SDFLIGHTMAP
                    float halfCP15 = 0.5 * _CharacterParams15.z;
                    float cp15T = clamp(0.5 - halfCP15, 0.001, 0.999);
                    float cp15Lo = max(2.0 * cp15T - 1.0, 0.0);
                    float cp15Hi = min(2.0 * cp15T, 1.0);
                    float cp15S = saturate((sdfValue * 0.5 - cp15Lo) / (cp15Hi - cp15Lo));
                    float cp15SS = cp15S * cp15S * (3.0 - 2.0 * cp15S);
                    float cp15Ceil = ceil(halfCP15) * halfCP15;
                    float cp15Raw = saturate((cp15SS + cp15Ceil) * 2.0 - 0.5);
                    float cp15Smooth = cp15Raw * cp15Raw * (3.0 - 2.0 * cp15Raw);
                    float cp14Spec = (1.0 - sdfMask.y) * cp15Smooth;
                    cp14Term.r = diffColor.r * cp14Spec * _CharacterParams14.x * _CharacterParams14.w;
                    cp14Term.g = diffColor.g * cp14Spec * _CharacterParams14.y * _CharacterParams14.w;
                    cp14Term.b = diffColor.b * cp14Spec * _CharacterParams14.z * _CharacterParams14.w;
                #endif

                // ==== FINAL ASSEMBLY ====
                float desatFactor = desatAmt * desatAmt + 1.0;
                float3 term1;
                term1.r = desatFactor * (mainLit.r - mainLitLum) + mainLitLum;
                term1.g = desatFactor * (mainLit.g - mainLitLum) + mainLitLum;
                term1.b = desatFactor * (mainLit.b - mainLitLum) + mainLitLum;

                // Skin specular (CP8/CP9)
                float3 skinTerm;
                skinTerm.r = skinShadow * skinAmt * _CharacterParams8.x * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.r - 0.25) + 0.25);
                skinTerm.g = skinShadow * skinAmt * _CharacterParams8.y * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.g - 0.25) + 0.25);
                skinTerm.b = skinShadow * skinAmt * _CharacterParams8.z * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.b - 0.25) + 0.25);

                float3 litColor = term1 + skinTerm + subsurfSpec + cp14Term;

                // ==== VFX COLOR ADJUSTMENT ====
                if (_EnableVFXColorAdjustment > 0.5) {
                    float litLum = dot(litColor, LUM);
                    float3 adjusted;
                    adjusted.r = _ColorAdjustmentContrast * (lerp(litLum, litColor.r, _ColorAdjustmentSaturation) - 0.5) + 0.5;
                    adjusted.g = _ColorAdjustmentContrast * (lerp(litLum, litColor.g, _ColorAdjustmentSaturation) - 0.5) + 0.5;
                    adjusted.b = _ColorAdjustmentContrast * (lerp(litLum, litColor.b, _ColorAdjustmentSaturation) - 0.5) + 0.5;
                    float caRimT = saturate((_ColorAdjustmentRimWidth - NdotV_sat) / max(_ColorAdjustmentRimWidth, 1e-5));
                    float caRimSmooth = caRimT * caRimT * (3.0 - 2.0 * caRimT);
                    float caRimAmt = rimModifier * caRimSmooth;
                    float3 caBrightened = adjusted * _ColorAdjustmentBrightness;
                    litColor = lerp(caBrightened, _ColorAdjustmentColorBlend.rgb, _ColorAdjustmentColorBlend.w)
                             + caRimAmt * _ColorAdjustmentRimColor.rgb * _ColorAdjustmentRimIntensity;
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
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex vert
                #pragma fragment frag
                #pragma shader_feature _DIFF_RAMP_ON
                #pragma shader_feature _EMOTION_MAP
                #pragma shader_feature _HIGHLIGHT_MAP
                #pragma shader_feature _NORMALMAP
                #pragma shader_feature _SDFLIGHTMAP
                #pragma shader_feature _SHADOW_LUT_TEX
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
                    float4 baseSample = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, input.uv);
                    float baseAlpha = baseSample.a;

                    float3 albedo;
                    #ifdef _EMOTION_MAP
                        float halfIdx = 0.5 * _EmotionIndex;
                        float fracIdx = frac(halfIdx);
                        float2 emotionUV = float2(
                            input.uv.x * 0.5 + fracIdx,
                            input.uv.y * 0.5 + floor(halfIdx) * 0.5
                        );
                        float4 emotionSmp = SAMPLE_TEXTURE2D(_EmotionMap, sampler_BaseMap, emotionUV);
                        float emotionT = emotionSmp.a * _EmotionBlend;
                        albedo.r = mad(emotionT, emotionSmp.r - baseSample.r * _BaseColor.r, baseSample.r * _BaseColor.r);
                        albedo.g = mad(emotionT, emotionSmp.g - baseSample.g * _BaseColor.g, baseSample.g * _BaseColor.g);
                        albedo.b = mad(emotionT, emotionSmp.b - baseSample.b * _BaseColor.b, baseSample.b * _BaseColor.b);
                    #else
                        albedo = baseSample.rgb * _BaseColor.rgb;
                    #endif

                    float faceSign = isFrontFace ? 1.0 : (_BackFaceNormalFlip * 2.0 - 1.0);
                    float3 color = computeNPRLighting(input.uv, input.positionWS, input.normalWS, input.tangentWS, faceSign, albedo, baseAlpha);
                    return float4(color, 1.0);
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 1b: FaceStencilMarker — Mark face skin in stencil bit 6
        // Runs via RenderObjects (LightMode=FaceStencilMarker) before BehindHairOverdraw.
        //
        // Endfield uses Skin_Fix for BOTH face and body skin (arms/legs); they are
        // distinguished only by the _SDFLIGHTMAP shader keyword (face has it, body
        // does not — see line 705 where the shader itself disables URP SSAO only
        // when _SDFLIGHTMAP is defined). We mirror that convention: only face skin
        // materials write bit 6, so post-effects (e.g. CustomAO) can mask just the
        // face without affecting body limbs.
        //
        // _DrawBehindHair=0 (face skin)  -> writes bit 6
        // _DrawBehindHair=1 (brow material) -> discards
        // No _SDFLIGHTMAP (body skin)      -> discards
        // ================================================================
        Pass {
            Name "FaceStencilMarker"
            Tags { "LightMode"="FaceStencilMarker" }
            ZTest Always
            ZWrite Off
            ColorMask 0
            Cull [_Cull]
            Stencil {
                Ref 64
                WriteMask 64
                Comp Always
                Pass Replace
            }
            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature _SDFLIGHTMAP

            struct MarkerAttributes { float3 positionOS : POSITION; };
            struct MarkerVaryings   { float4 positionCS : SV_Position; };

            MarkerVaryings vert(MarkerAttributes input) {
                MarkerVaryings o;
                o.positionCS = TransformObjectToHClip(input.positionOS);
                return o;
            }
            half4 frag(MarkerVaryings input) : SV_Target {
                // Body skin (no SDF lightmap) is not face — skip stencil write.
                // clip() before stencil ROP guarantees no bit-6 write.
                #ifndef _SDFLIGHTMAP
                    clip(-1);
                #endif
                clip(0.5 - _DrawBehindHair);
                return 0;
            }
            ENDHLSL
        }

        // ================================================================
        // Pass 1c: BehindHairOverdraw — Depth blocker for face skin
        // Stencil-gated to hair-marker pixels (bit 5).
        // Face skin outputs alpha=0 + ZWrite On so overlay composite ignores
        // it visually, but the depth write blocks Eye behind-hair from showing
        // through skin (e.g. sclera behind face skin).
        // ================================================================
        Pass {
            Name "BehindHairOverdraw"
            Tags { "LightMode"="BehindHairOverdraw" }
            ZTest LEqual
            ZWrite On
            Cull [_Cull]
            // Stencil mask is applied in BehindHairComposite Pass 1 (cameraDepth.stencil bit 5).
            // Overlay depth has no stencil; this pass writes alpha=0 + depth so eye/sclera
            // geometry behind face skin is occluded in the overlay buffer.
            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            struct OverdrawAttributes { float3 positionOS : POSITION; };
            struct OverdrawVaryings   { float4 positionCS : SV_Position; };

            OverdrawVaryings vert(OverdrawAttributes input) {
                OverdrawVaryings o;
                o.positionCS = TransformObjectToHClip(input.positionOS);
                return o;
            }
            half4 frag(OverdrawVaryings input) : SV_Target {
                // Endfield Skin shader is only used for face skin (brow uses Eye shader),
                // so always act as depth blocker. Gate kept for parity with ZZZ.
                clip(0.5 - _DrawBehindHair);
                return half4(0, 0, 0, 0);
            }
            ENDHLSL
        }

        // ================================================================
        // Pass 2: Character Outline (inverted hull, full NPR lighting)
        // ================================================================
        Pass {
            Name "CharacterOutline"
            Cull Front
            ZWrite On
            ZTest Less
            Tags { "LightMode"="SRPDefaultUnlit" }
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex outlineVert
                #pragma fragment outlineFrag
                #pragma shader_feature _DIFF_RAMP_ON
                #pragma shader_feature _HIGHLIGHT_MAP
                #pragma shader_feature _NORMALMAP
                #pragma shader_feature _OUTLINE_MASK
                #pragma shader_feature _SDFLIGHTMAP
                #pragma shader_feature _SHADOW_LUT_TEX
                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH

                struct OutlineAttributes {
                    float3 positionOS    : POSITION;
                    float2 uv            : TEXCOORD0;
                    float3 normalOS      : NORMAL;
                    float4 tangentOS     : TANGENT;
                    float2 smoothNrmTS   : TEXCOORD2; // UV2: tangent-space smooth normal
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
                    o.uv = input.uv * _BaseMap_ST.xy + _BaseMap_ST.zw;

                    // Choose normal: smooth (UV2 tangent-space) or regular vertex normal
                    float3 normalWS = nrmIn.normalWS;
                    if (_OutlineAverageNormal > 0.5) {
                        float2 ts = input.smoothNrmTS;
                        float z = sqrt(max(1.0 - dot(ts, ts), 0.0));
                        float3 bitWS = cross(nrmIn.normalWS, nrmIn.tangentWS) * input.tangentOS.w;
                        normalWS = normalize(nrmIn.tangentWS * ts.x + bitWS * ts.y + nrmIn.normalWS * z);
                    }

                    float4 clipPos = posIn.positionCS;

                    // Outline Mask (vertex shader LOD 0 sample)
                    float widthMask = 1.0;
                    float zOff = _OutlineOffsetZ;
                    #ifdef _OUTLINE_MASK
                        float4 outlineMaskSmp = SAMPLE_TEXTURE2D_LOD(_OutlineMask, sampler_OutlineMask, input.uv * _BaseMap_ST.xy + _BaseMap_ST.zw, 0);
                        widthMask = outlineMaskSmp.x;
                        zOff = outlineMaskSmp.y * _OutlineOffsetZ;
                    #endif

                    // Screen-space normal projection
                    float2 screenN = mul((float3x3)UNITY_MATRIX_VP, normalWS).xy;
                    float screenNInvLen = rsqrt(dot(screenN, screenN) + 1e-8);

                    // FOV half-angle
                    float tanHalf = -1.0 / UNITY_MATRIX_P._m11;
                    bool small = abs(tanHalf) < 1.0;
                    float t = small ? abs(tanHalf) : (1.0 / abs(tanHalf));
                    float t2 = t * t;
                    float approx = mad(mad(t2, 0.0872929, -0.301895), t2, 1.0);
                    float angle = small ? (t * approx) : mad(-approx, t, 1.5707964);
                    float halfFov = (tanHalf < 0.0) ? -angle : angle;

                    // Width + distance attenuation
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

                    // Apply with width mask
                    clipPos.xy += offset * widthMask;

                    // Z offset with mask
                    if (unity_OrthoParams.w == 0.0) {
                        float viewZ = mad(zOff, -0.1, -clipPos.w);
                        clipPos.z = (clipPos.w * mad(viewZ, UNITY_MATRIX_P._m22, UNITY_MATRIX_P._m23)) / (-viewZ);
                    } else {
                        clipPos.z += (-0.1 * zOff) / _ProjectionParams.z;
                    }

                    o.positionCS = clipPos;
                    return o;
                }

                float4 outlineFrag(OutlineVaryings input) : SV_Target {
                    float4 baseSample = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, input.uv);
                    float3 rawAlbedo = baseSample.rgb * _BaseColor.rgb;

                    // Outline albedo processing: tint or brightness/saturation
                    float3 albedo;
                    if (_OutlineTintEnable != 0.0) {
                        albedo = _OutlineTintColor.rgb;
                    } else {
                        float3 scaled = rawAlbedo * _OutlineColorBrightness;
                        float lum = dot(scaled, LUM);
                        albedo = lum + _OutlineColorSaturation * (scaled - lum);
                    }

                    // Full NPR lighting (same as ForwardLit).
                    float3 color = computeNPRLighting(input.uv, input.positionWS, input.normalWS, input.tangentWS, 1.0, albedo, baseSample.a);
                    return float4(color, 1.0);
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
                #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW

                float3 _LightDirection;
                float3 _LightPosition;

                struct ShadowAttributes {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                };

                struct ShadowVaryings {
                    float4 positionCS : SV_Position;
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
                    return o;
                }

                float4 shadowFrag(ShadowVaryings input) : SV_Target {
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
