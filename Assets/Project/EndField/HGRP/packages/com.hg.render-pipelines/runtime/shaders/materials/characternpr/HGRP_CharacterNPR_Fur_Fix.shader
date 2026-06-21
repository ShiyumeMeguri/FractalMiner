// Simplified HGRP CharacterNPR Fur shader — ForwardLit only.
// Based on: HGRP_CharacterNPR_ad86c95c.shader
// Material: M_actor_aurora_hair_02 (keywords: _NORMALMAP, _DIFF_RAMP_ON, _METALLICSPECGLOSSMAP, _SPEC_RAMP_ON)
// Kept: Normal Map, Diffuse Ramp (with wrap-lighting + fur NdotL modification), Shadow Color,
//   MetallicGlossMap, Spec Ramp, GGX Specular, Skin Specular (CP8/CP9), Subsurface,
//   Cubemap Reflection (URP probe), Shell-based Fur (UV1.x shell index, FurMap, alpha blend).
// Removed: GPU skinning, instancing, TAA jitter, motion vectors, rain/wet, all shadows,
//   SDF lightmap, fog, IV clipmap, punctual lights, VFX color adjustment, dissolve,
//   erosion proximity (CP10 + CB1), outline (_EnableOutline=0), emission (_UseEmission=0).
//
// NOTE: CharacterParams numbering matches cloth variant:
//   CP2 = ambient color, CP5 = light color override.
//
// Fur system: UV1.x = shell layer index (0=base, up to ~1 at outermost shell).
// Mesh has 20 shell layers (330 base verts * 20 = 6600 total).
// FurMap tiling is isotropic: _FurMap_ST.x used for BOTH UV dimensions.

Shader "HGRP/CharacterNPR_Fur_Fix" {
    Properties {
        _BaseColor ("Color", Color) = (1, 1, 1, 1)
        _BaseMap ("Albedo", 2D) = "white" {}
        [HideInInspector] _SrcBlend ("__src", Float) = 5
        [HideInInspector] _DstBlend ("__dst", Float) = 10
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 10
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _Cull ("Render Face", Float) = 2
        [Enum(On, 0, Off, 1)] _BackFaceNormalFlip ("Back Face Normal Flip", Float) = 0

        _ShadowColorBrightness ("Shadow Color Brightness", Range(0, 1)) = 0.55
        _ShadowColorSaturation ("Shadow Color Saturation", Range(0, 2)) = 1.1

        [Toggle(_METALLICSPECGLOSSMAP)] _UseMetallicGlossMap ("Use MetallicGlossMap", Float) = 1
        [Gamma] _Metallic ("Metallic", Range(0, 1)) = 0
        _Specular ("Specular Scale", Range(0, 1)) = 0
        _Smoothness ("Smoothness", Range(0, 1)) = 0.1
        _MetallicGlossMap ("RGBA: Metal,Spec,Shadow,Smooth", 2D) = "white" {}

        [Toggle(_NORMALMAP)] _UseBumpMap ("Use Normal Map", Float) = 1
        _BumpScale ("Normal Scale", Float) = 1
        _BumpMap ("Normal Map", 2D) = "bump" {}

        [Toggle(_DIFF_RAMP_ON)] _UseDiffRampMap ("Diffuse Ramp", Float) = 1
        _DiffRampMap ("Diffuse Ramp", 2D) = "white" {}

        [Toggle(_SPEC_RAMP_ON)] _UseSpecRampMap ("Specular Ramp", Float) = 1
        _SpecRampMap ("Specular Ramp", 2D) = "white" {}
        [ToggleUI] _SpecRampIridescentMode ("Iridescent Mode", Float) = 0

        [HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}
        [HideInInspector] _AlphaPremultiply ("Alpha Premultiply", Float) = 0

        [Header(Fur)]
        _FurMap ("Fur Noise", 2D) = "white" {}
        _FurLengthIntensity ("Fur Length", Range(0.001, 6)) = 0.7
        _FurCutoffStart ("Root Cutoff", Range(0, 1)) = 0
        _FurCutoffEnd ("Tip Cutoff", Range(0, 1)) = 1
        _FurAO ("Root AO", Range(0, 1)) = 1
        _FurEdgeFade ("Edge Fade", Range(0, 1)) = 0.4
        _FurGravityStrength ("Gravity Strength", Range(0, 1)) = 0.65
        _FurTTIntensity ("Transmittance Intensity", Range(0, 1)) = 0
        [ToggleUI] _FurDirMapEnable ("Use Fur Direction Map", Float) = 0
        _FurDirMap ("Fur Direction (RG) Density (B) Length (A)", 2D) = "bump" {}
        [ToggleUI] _FurSharpen ("Fur Sharpen", Float) = 0
        [ToggleUI] _FurNoise ("Fur Shell Noise", Float) = 0

        [Header(Fur Dye)]
        [Toggle(_CHARACTER_FUR_DYE)] _FurDyeEnable ("Fur Dye", Float) = 0
        _FurDyeMap ("Fur Dye Map", 2D) = "black" {}
        _FurDyeIntensity ("Fur Dye Intensity", Range(0, 1)) = 1

        [Header(Character VFX Special)]
        [Toggle(_CHARACTER_VFX_SPECIAL)] _EnableCharacterVFX ("Character VFX", Float) = 0
        [HDR] _VFXColor ("VFX Color", Color) = (1, 1, 1, 1)
        _VFXColorIntensity ("VFX Color Intensity", Range(1, 100)) = 1
        _VFXColorAlpha ("VFX Color Alpha", Range(0, 10)) = 1
        _VFXSpecialMainTex ("VFX Main Tex", 2D) = "white" {}
        [ToggleUI] _UseVFXMainTexAsAlpha ("Use MainTex R As Alpha", Float) = 0
        _VFXSpecialBlendTex ("VFX Blend Tex", 2D) = "black" {}
        _VFXSpecialBlendTexRForDisturb ("Blend Tex R Disturb", Range(0, 1)) = 1
        [HDR] _VFXBlendTint ("VFX Blend Tint", Color) = (1, 1, 1, 1)
        _VFXSpecialParam ("VFX Scroll (XY:Main ZW:Blend)", Vector) = (0, 0, 0, 0)
        [HDR] _VFXFresnelColor ("VFX Fresnel Color", Color) = (1, 1, 1, 1)
        _VFXFresnelBias ("VFX Fresnel Bias", Range(-1, 2)) = 0
        _VFXFresnelAffectOpacity ("Fresnel Affect Opacity", Range(0, 1)) = 1
        _VFXFresnelPower ("VFX Fresnel Power", Range(1, 100)) = 1
        [ToggleUI] _VFXFresnelFlip ("VFX Fresnel Flip", Float) = 0
        _SpecialDissolveScheduleOffset ("Dissolve Schedule Offset", Range(0, 1)) = 0

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

        [Toggle(_USE_GROUND_TRUTH_AO)] _UseGroundTruthAO ("Use Ground Truth Ambient Occlusion", Float) = 0
        [Toggle(_USE_ALCHEMY_AO)] _UseAlchemyAO ("Use Alchemy Ambient Occlusion", Float) = 0
    }
    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Transparent" "Queue"="Transparent" }
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
                float _BumpScale;
                float _SpecRampIridescentMode;
                float _AlphaPremultiply;
                // Fur
                float4 _FurMap_ST;
                float _FurLengthIntensity;
                float _FurCutoffStart;
                float _FurCutoffEnd;
                float _FurAO;
                float _FurEdgeFade;
                float _FurGravityStrength;
                float _FurTTIntensity;
                float _FurDirMapEnable;
                float _FurSharpen;
                float _FurNoise;
                // Fur Dye
                float _FurDyeIntensity;
                float4 _FurDyeMap_ST;
                // VFX Special
                float4 _VFXColor;
                float _VFXColorIntensity;
                float _VFXColorAlpha;
                float _UseVFXMainTexAsAlpha;
                float _VFXSpecialBlendTexRForDisturb;
                float4 _VFXBlendTint;
                float4 _VFXSpecialParam;
                float4 _VFXFresnelColor;
                float _VFXFresnelBias;
                float _VFXFresnelAffectOpacity;
                float _VFXFresnelPower;
                float _VFXFresnelFlip;
                float4 _VFXSpecialMainTex_ST;
                float4 _VFXSpecialBlendTex_ST;
                float _SpecialDissolveScheduleOffset;
                // Character params
                float4 _CharacterParams0;
                float4 _CharacterParams1;
                float4 _CharacterParams2;
                float4 _CharacterParams5;
                float4 _CharacterParams6;
                float4 _CharacterParams7;
                float4 _CharacterParams8;
                float4 _CharacterParams9;
                float4 _CharacterParams11;
                float4 _CharacterParams12;
                float4 _CharacterParams13;
                float4 _EnvironmentGlobalParams0;
                float4 _ExposureParams;
                float _ShadowBlurRadius;
            CBUFFER_END

            TEXTURE2D(_BaseMap);          SAMPLER(sampler_BaseMap);
            TEXTURE2D(_BumpMap);          SAMPLER(sampler_BumpMap);
            TEXTURE2D(_MetallicGlossMap); SAMPLER(sampler_MetallicGlossMap);
            TEXTURE2D(_DiffRampMap);      SAMPLER(sampler_DiffRampMap);
            TEXTURE2D(_SpecRampMap);      SAMPLER(sampler_SpecRampMap);
            TEXTURE2D(_FurMap);           // uses sampler_BaseMap (matches decompiled)
            TEXTURE2D(_FurDirMap);        SAMPLER(sampler_FurDirMap);
            TEXTURE2D(_FurDyeMap);        // uses sampler_BaseMap
            TEXTURE2D(_VFXSpecialMainTex);  // uses sampler_BaseMap
            TEXTURE2D(_VFXSpecialBlendTex); // uses sampler_BaseMap

            static const float3 LUM = float3(0.2126729, 0.7152, 0.07217500);
            static const float NEAR_ZERO_Y = 6.103515625e-05; // asfloat(947912704u)
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
                #pragma shader_feature _CHARACTER_FUR_DYE
                #pragma shader_feature _CHARACTER_VFX_SPECIAL
                #pragma shader_feature _DIFF_RAMP_ON
                #pragma shader_feature _METALLICSPECGLOSSMAP
                #pragma shader_feature _NORMALMAP
                #pragma shader_feature _SPEC_RAMP_ON
                #pragma shader_feature_local _USE_GROUND_TRUTH_AO
                #pragma shader_feature_local _USE_ALCHEMY_AO
                #pragma multi_compile _ _CUSTOM_AO_ON
                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH

                struct Attributes {
                    float3 positionOS : POSITION;
                    float2 uv         : TEXCOORD0;
                    float2 uv1        : TEXCOORD1; // .x = shell index
                    float3 normalOS   : NORMAL;
                    float4 tangentOS  : TANGENT;
                };

                struct Varyings {
                    float4 positionCS : SV_Position;
                    float2 uv         : TEXCOORD0;
                    float3 positionWS : TEXCOORD1;
                    float3 normalWS   : TEXCOORD2;
                    float4 tangentWS  : TEXCOORD3;
                    float  shellIdx   : TEXCOORD4;
                };

                Varyings vert(Attributes input) {
                    Varyings o = (Varyings)0;
                    float shellIdx = input.uv1.x;

                    VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);
                    VertexNormalInputs   nrmIn = GetVertexNormalInputs(input.normalOS, input.tangentOS);
                    float3 normalWS = nrmIn.normalWS;

                    // Shell displacement (decompiled lines 1033-1038)
                    // Gravity-modified direction: blend normal toward (0,-1,0)
                    // gravityWeight increases for upward-facing surfaces and outer shells
                    float gravityWeight = (0.5 - 0.5 * normalWS.y) * shellIdx * _FurGravityStrength;
                    float3 displaceDir = normalWS * (1.0 - gravityWeight) + float3(0, -1, 0) * gravityWeight;

                    // Magnitude: shellIdx * length * FurDirMap.w (fur length map, default=1)
                    float furLengthMap = SAMPLE_TEXTURE2D_LOD(_FurDirMap, sampler_FurDirMap, input.uv, 0).w;
                    float shellOffset = shellIdx * _FurLengthIntensity * 0.01 * furLengthMap;

                    float3 posWS = posIn.positionWS + displaceDir * shellOffset;

                    o.positionCS = TransformWorldToHClip(posWS);
                    o.positionWS = posWS;
                    o.normalWS   = normalWS;
                    o.tangentWS  = float4(nrmIn.tangentWS, input.tangentOS.w);
                    o.uv = input.uv * _BaseMap_ST.xy + _BaseMap_ST.zw;
                    o.shellIdx = shellIdx;
                    return o;
                }

                // Environment BRDF rational approximation (decompiled lines 2817-2883)
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

                float4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target {
                    float shellIdx = input.shellIdx;
                    float2 uv = input.uv;

                    // ---- Object-to-World origin (decompiled _246, _247) ----
                    float originX = unity_ObjectToWorld._m03;
                    float originZ = unity_ObjectToWorld._m23;

                    // ---- View direction (decompiled _193-_204) ----
                    float3 toCam = _WorldSpaceCameraPos - input.positionWS;
                    float3 orthoFwd = float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22);
                    float3 viewRaw = toCam + unity_OrthoParams.w * (orthoFwd - toCam);
                    float3 V = normalize(viewRaw);

                    // ---- Base color (decompiled _258-_270) ----
                    float4 baseSample = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, uv);
                    float3 albedo = baseSample.rgb * _BaseColor.rgb;

                    // ---- Fur Dye (decompiled lines 1262-1265) ----
                    // Screen blend: normalize UV from BaseMap_ST, apply DyeMap_ST, then blend.
                    #ifdef _CHARACTER_FUR_DYE
                        float2 dyeUV = float2(
                            mad((uv.x - _BaseMap_ST.z) / max(0.001, abs(_BaseMap_ST.x)), _FurDyeMap_ST.x, _FurDyeMap_ST.z),
                            mad((uv.y - _BaseMap_ST.w) / max(0.001, abs(_BaseMap_ST.y)), _FurDyeMap_ST.y, _FurDyeMap_ST.w)
                        );
                        float3 dyeSmp = SAMPLE_TEXTURE2D(_FurDyeMap, sampler_BaseMap, dyeUV).rgb;
                        float3 screenBlend = 1.0 - (1.0 - albedo) * (1.0 - dyeSmp);
                        albedo = lerp(albedo, screenBlend, _FurDyeIntensity);
                    #endif

                    // ---- MetallicGlossMap (decompiled _279-_286) ----
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

                    // ---- Shadow color (decompiled _293-_311) ----
                    float3 shadBright = albedo * _ShadowColorBrightness;
                    float shadLum = dot(shadBright, LUM);
                    float3 shadowColor = _ShadowColorSaturation * (shadBright - shadLum) + shadLum;

                    // ---- Normal map (decompiled _320-_425) ----
                    float faceSign = isFrontFace ? 1.0 : (_BackFaceNormalFlip * 2.0 - 1.0);
                    float nrmZ_raw = 1.0; // for fur AO, needs pre-BumpScale Z
                    float3 N;
                    #ifdef _NORMALMAP
                        float4 nrmSmp = SAMPLE_TEXTURE2D(_BumpMap, sampler_BumpMap, uv);
                        float nrmX_raw = nrmSmp.x * nrmSmp.w * 2.0 - 1.0;
                        float nrmY_raw = nrmSmp.y * 2.0 - 1.0;
                        nrmZ_raw = max(sqrt(1.0 - saturate(nrmX_raw * nrmX_raw + nrmY_raw * nrmY_raw)), 1e-16);
                        float nrmX = nrmX_raw * _BumpScale;
                        float nrmY = nrmY_raw * _BumpScale;
                        float3 nrmWS = normalize(input.normalWS);
                        float3 tanWS = normalize(input.tangentWS.xyz);
                        float3 bitWS = cross(nrmWS, tanWS) * input.tangentWS.w;
                        N = faceSign * normalize(nrmX * tanWS + nrmY * bitWS + nrmZ_raw * nrmWS);
                    #else
                        N = faceSign * normalize(input.normalWS);
                    #endif

                    // ---- FurDirMap (decompiled line 1626) ----
                    float4 furDirSmp = SAMPLE_TEXTURE2D(_FurDirMap, sampler_FurDirMap, uv);

                    // ---- FurMap sampling (decompiled lines 1252, 1306, simplified with erosion=0) ----
                    // Per-shell noise (line 1252)
                    float furShellNoise = (frac(sin(dot(shellIdx.xx, float2(12.9898, 78.233))) * 43758.5469) * 2.0 - 1.0) * _FurNoise * 0.05;
                    // UV distortion from direction map + noise
                    float2 furDirOffset = float2(
                        (furDirSmp.x * 2.0 - 1.0) * _FurDirMapEnable * 0.005 + furShellNoise,
                        (furDirSmp.y * 2.0 - 1.0) * _FurDirMapEnable * 0.005 + furShellNoise
                    );
                    // FurMap UV: isotropic tiling (_FurMap_ST.x for both dims)
                    float2 furSampleUV = float2(
                        (uv.x - shellIdx * furDirOffset.x) * _FurMap_ST.x + _FurMap_ST.z,
                        (uv.y - shellIdx * furDirOffset.y) * _FurMap_ST.x + _FurMap_ST.w
                    );
                    float furSample = SAMPLE_TEXTURE2D(_FurMap, sampler_BaseMap, furSampleUV).x;
                    float furDirZ = furDirSmp.z; // density channel (=1.0 for default bump)

                    // ---- Fur cutoff + alpha (decompiled lines 1640-1649) ----
                    float cutoff = shellIdx * (_FurCutoffEnd - _FurCutoffStart) + _FurCutoffStart;
                    float cutoffSharp = lerp(cutoff, sqrt(cutoff), _FurSharpen);
                    float cutLo = max(cutoffSharp - 0.25, 0.0);
                    float cutHi = min(cutoffSharp + 0.25, 1.0);
                    float furRaw = saturate((furDirZ * furSample - cutLo) / (cutHi - cutLo));
                    float furSmooth = furRaw * furRaw * (3.0 - 2.0 * furRaw); // smoothstep

                    // Shell alpha: base (shellIdx<=0.01) = 1, shells = fur alpha with edge fade
                    float isBase = (shellIdx <= 0.01) ? 1.0 : 0.0;
                    float furAlphaRaw = isBase * (1.0 - furSmooth) + furSmooth;
                    float3 geomN = normalize(input.normalWS);
                    float edgeFactor = (1.0 - shellIdx * shellIdx * shellIdx) + dot(geomN, V) - _FurEdgeFade;
                    float shellAlpha = ceil(shellIdx) * (saturate(furAlphaRaw * edgeFactor) - 1.0) + 1.0;

                    // Discard transparent shells (decompiled line 1649)
                    clip(shellAlpha - 0.003);

                    // ---- Fur AO (decompiled lines 1481-1500, erosion=0) ----
                    float nrmZ2 = min(nrmZ_raw * 2.0, 1.0);
                    float nrmZ2sq = nrmZ2 * nrmZ2;
                    float furAO = shellIdx * (1.0 - nrmZ2sq * _FurAO) + nrmZ2sq * _FurAO;
                    float furShadowMask = furAO * shadowMask;

                    // ---- Character VFX Special: texture sampling + Fresnel (decompiled lines 1653-1716) ----
                    #ifdef _CHARACTER_VFX_SPECIAL
                        float vfxTime = _Time.y;

                        // BlendTex sampling with scroll
                        float2 vfxBlendUV = float2(
                            mad(mad(_VFXSpecialParam.z, vfxTime, uv.x), _VFXSpecialBlendTex_ST.x, _VFXSpecialBlendTex_ST.z),
                            mad(mad(_VFXSpecialParam.w, vfxTime, uv.y), _VFXSpecialBlendTex_ST.y, _VFXSpecialBlendTex_ST.w)
                        );
                        float4 vfxBlendSmp = SAMPLE_TEXTURE2D(_VFXSpecialBlendTex, sampler_BaseMap, vfxBlendUV);

                        // MainTex sampling with distortion from BlendTex.R + scroll
                        float2 vfxDistortUV = uv + vfxBlendSmp.r * _VFXSpecialBlendTexRForDisturb;
                        float2 vfxMainUV = float2(
                            mad(mad(_VFXSpecialParam.x, vfxTime, vfxDistortUV.x), _VFXSpecialMainTex_ST.x, _VFXSpecialMainTex_ST.z),
                            mad(mad(_VFXSpecialParam.y, vfxTime, vfxDistortUV.y), _VFXSpecialMainTex_ST.y, _VFXSpecialMainTex_ST.w)
                        );
                        float4 vfxMainSmp = SAMPLE_TEXTURE2D(_VFXSpecialMainTex, sampler_BaseMap, vfxMainUV);

                        // Alpha: use MainTex.r or MainTex.a
                        float vfxTexAlpha = lerp(vfxMainSmp.a, vfxMainSmp.r, _UseVFXMainTexAsAlpha);
                        // Color: when UseMainTexAsAlpha=1, RGB channels become 1.0
                        float3 vfxMainRGB = lerp(vfxMainSmp.rgb, float3(1, 1, 1), _UseVFXMainTexAsAlpha);

                        // Fresnel (uses geometric normal, not normal-mapped N)
                        float3 vfxGeomN = normalize(input.normalWS);
                        float vfxFresnel = exp2(log2(saturate(dot(V, vfxGeomN) + _VFXFresnelBias)) * _VFXFresnelPower);
                        float vfxFresnelFlipped = lerp(1.0 - vfxFresnel, vfxFresnel, _VFXFresnelFlip);

                        float vfxAlphaBase = _VFXColorAlpha * _VFXColor.a;

                        // Dissolve schedule (decompiled lines 1712-1713)
                        // _1981 = blendTexR - (SDO * 2.02 - 1.01)
                        float vfxDissolveDelta = vfxBlendSmp.r - (_SpecialDissolveScheduleOffset * 2.02 - 1.01);
                        float vfxDissolveEdge = saturate(-vfxDissolveDelta);  // _1983: edge glow factor
                    #endif

                    // ---- Flat direction (decompiled _1413-_1423) ----
                    float fX = input.positionWS.x - originX;
                    float fZ = input.positionWS.z - originZ;
                    float fLen = rsqrt(fX * fX + NEAR_ZERO_Y * NEAR_ZERO_Y + fZ * fZ);
                    float3 flatDir = float3(fX * fLen, NEAR_ZERO_Y * fLen, fZ * fLen);

                    // ---- Exposure (decompiled _444) ----
                    float exposure = (_CharacterParams12.w * (1.0 - _EnvironmentGlobalParams0.x) + _EnvironmentGlobalParams0.x) * _ExposureParams.x;

                    // ---- Ambient (IV disabled -> CP2 fallback, decompiled lines 1562-1576) ----
                    float ambInt = exposure;
                    float3 ambCol = _CharacterParams2.xyz;

                    // ---- Camera forward ----
                    float3 camFwd = float3(UNITY_MATRIX_I_V._m02, UNITY_MATRIX_I_V._m12, UNITY_MATRIX_I_V._m22);

                    // ---- Metallic workflow (decompiled _1458-_1475) ----
                    float dielSpec = specScale * 0.04;
                    float oneMinusRefl = (1.0 - metallic) * 0.96;
                    float3 diffColor = oneMinusRefl * albedo;
                    float3 specColor = metallic * (albedo - dielSpec) + dielSpec;
                    float3 shadowDiff = oneMinusRefl * shadowColor;

                    float roughness = max(roughnessRaw * roughnessRaw, 0.0078125);
                    float roughSq4 = roughness * roughness;

                    // ---- Main light from URP ----
                    float4 shadowCoord = TransformWorldToShadowCoord(input.positionWS);
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

                    // ---- Adjusted light direction (decompiled _1578-_1588) ----
                    float3 adjustedLightDir = lerp(mainLightDir, _CharacterParams11.xyz, _CharacterParams1.w);
                    float adjXZLen = rsqrt(adjustedLightDir.x * adjustedLightDir.x + adjustedLightDir.z * adjustedLightDir.z + NEAR_ZERO_Y * NEAR_ZERO_Y);
                    float adjXZ_x = adjXZLen * adjustedLightDir.x;
                    float adjXZ_z = adjXZLen * adjustedLightDir.z;

                    // ---- Light color blend (decompiled _1614-_1628, using CP5) ----
                    float3 blendedLightCol = lerp(lightCol, _CharacterParams5.xyz, _CharacterParams12.y);
                    float blendedLightInt = lerp(lightInt, 1.0, _CharacterParams12.w);

                    // ---- Camera-light facing (decompiled _2329-_2386) ----
                    float cfXZLen = rsqrt(camFwd.x * camFwd.x + camFwd.z * camFwd.z);
                    float camLightDot = saturate(-(adjXZ_x * (cfXZLen * camFwd.x) + adjXZ_z * (cfXZLen * camFwd.z)));
                    float camYFade = saturate(2.0 * (0.75 - abs(camFwd.y)));
                    float camYSmooth = camYFade * camYFade * (3.0 - 2.0 * camYFade);

                    // ==== FUR NdotL MODIFICATION (decompiled lines 1999-2000) ====
                    float geomNdotL = dot(N, adjustedLightDir);
                    // Fur transmittance: smoothstep on inverse fur sample
                    float furInv = saturate((1.0 - furSample) * 1.4286);
                    float furInvSmooth = furInv * furInv * (3.0 - 2.0 * furInv);
                    float furTT = furInvSmooth * camLightDot * _FurNoise * (1.15 - _FurTTIntensity) + _FurTTIntensity;
                    float furModNdotL = clamp(furTT * shellIdx + geomNdotL, -1.0, 1.0);

                    // ==== DIFFUSE RAMP (wrap-lighting with fur-modified NdotL, decompiled line 2005) ====
                    float wrapAdd = 0.5 - 0.5 * furModNdotL * furModNdotL;
                    float camFadeFactor = (1.0 - _CharacterParams12.x) * (camLightDot * camYSmooth);
                    float modNdotL = camFadeFactor * wrapAdd + furModNdotL;
                    #ifdef _DIFF_RAMP_ON
                        float rampInput = clamp(_CharacterParams11.w * _CharacterParams12.x + modNdotL, -1.0, 1.0) * 0.5 + 0.5;
                        float4 rampSmp = SAMPLE_TEXTURE2D_LOD(_DiffRampMap, sampler_DiffRampMap, float2(rampInput, 0.5), 0);
                        float3 rampCol = rampSmp.rgb;
                        float rampA = rampSmp.a;
                        float rampChroma = max(rampCol.r, max(rampCol.g, rampCol.b)) - min(rampCol.r, min(rampCol.g, rampCol.b));
                        float rampChromaInv = 1.0 - rampChroma;

                        // Second ramp sample: view direction (decompiled line 2011)
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

                    // ---- Shadow terms (charShadow=1, using furShadowMask) ----
                    float castShadow = lerp(smoothstep(0.0, 1.0, mainLight.shadowAttenuation), 1.0, _CharacterParams1.z);
                    float minShadow = min(rampA, furShadowMask) * castShadow;
                    float viewShadowProduct = viewRampA * furShadowMask;

                    // ==== NPR DIFFUSE COMPOSITION (charShadow=1, decompiled _2457-_2614) ====
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

                    // Shadow desaturation (decompiled _2534-_2543)
                    float albScaledLum = dot(albScaled * 0.65, LUM);
                    float3 desatShad = (albScaled * 0.65 - albScaledLum) * 1.2 + albScaledLum;

                    // View-dependent shadow blend (decompiled _2545-_2566)
                    float combWeight = saturate(viewShadowProduct + rampA);
                    float3 weightedAmb = lerp(desatShad, albScaled, combWeight);
                    float3 shadowBlended = lerp(weightedAmb, diffColor, minShadow);

                    // View-dependent shadow transition (decompiled _2591-_2593)
                    float3 viewDepShad = viewShadowProduct * ((diffColor - diffColorLum) * 1.2 + diffColorLum - albScaled) + albScaled;

                    // Ramp color tint (decompiled _2572-_2574)
                    float3 rampTinted = shadowBlended * (rampCol * rampChroma + rampChromaInv);

                    // Luminance ratio (decompiled _2605)
                    float shadowLum = dot(shadowBlended, LUM);
                    float rampLum = dot(rampTinted, LUM);
                    float lumRatio = clamp(shadowLum / max(rampLum, 0.001), 0.0, 1.5);

                    // Final NPR diffuse (decompiled _2612-_2614, charShadow=1)
                    float3 nprDiff = rampTinted * lumRatio;

                    // Attenuation (decompiled _2617-_2735, charShadow=1)
                    float ambDiffInt = minShadow * (1.0 - _CharacterParams0.z) + _CharacterParams0.z;
                    float specAmbInt = ambDiffInt * (minShadow * 0.5 + 0.5);

                    // ==== GGX SPECULAR (decompiled _2629-_2729) ====
                    float NdotV_spec = saturate(dot(N, V));
                    float mainLightY = adjustedLightDir.y;
                    float3 camFwdMod = normalize(float3(camFwd.x, mainLightY, camFwd.z));
                    // H = V*3 + L + camFwdMod*2 (charShadow+2=3)
                    float3 H = normalize(V * 3.0 + adjustedLightDir + camFwdMod * 2.0);
                    float NdotH = dot(N, H);
                    float roughSq = roughness * roughness;
                    float denom = (NdotH * roughSq - NdotH) * NdotH + 1.0;
                    float denomSq = denom * denom;
                    float D_raw = (denomSq != roughSq) ? roughSq / denomSq : 1.0;
                    float ggxTerm = clamp(D_raw * 0.5 / (NdotV_spec * 2.0 + roughness + 1e-4) - NEAR_ZERO_Y, 0.0, 20.0);

                    // ---- Spec Ramp (decompiled _2680-_2710) ----
                    float3 specRampColor = specColor;
                    float3 specRampEnv = specColor;
                    #ifdef _SPEC_RAMP_ON
                        float specRampPartial = D_raw * (roughSq4 + 1e-4);
                        float specRampU = lerp(specRampPartial, NdotV_spec * NdotV_spec, _SpecRampIridescentMode);
                        float specRampV = (1.0 - metallic) * roughnessRaw;
                        float3 specRampSmp = SAMPLE_TEXTURE2D_LOD(_SpecRampMap, sampler_SpecRampMap, float2(specRampU, specRampV), 0).rgb;
                        specRampColor = specColor * specRampSmp;
                        specRampEnv = lerp(specColor, specRampColor, _SpecRampIridescentMode);
                    #endif

                    // AlphaPremultiply (decompiled line 2090)
                    float alphaPremul = shellAlpha * _AlphaPremultiply + (1.0 - _AlphaPremultiply);

                    // Main lit composition (decompiled _2749-_2751)
                    float3 mainLit = fullDiff * nprDiff * alphaPremul + (specAmbInt * fullDiff) * (ggxTerm * specRampColor) * _CharacterParams13.w;
                    float mainLitLum = dot(mainLit, LUM);
                    float desatAmt = clamp(mainLitLum - 0.5, 0.0, 0.5);

                    // ==== SKIN SPECULAR CP8/CP9 (decompiled _2762-_2951) ====
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
                    float skinShadow = min(furShadowMask, skinNdotL);
                    float skinNdotBN = saturate(dot(skinDir, N));

                    float3 skinSpec;
                    skinSpec.r = skinShadow * skinSmooth * _CharacterParams8.x * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.r - 0.25) + 0.25);
                    skinSpec.g = skinShadow * skinSmooth * _CharacterParams8.y * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.g - 0.25) + 0.25);
                    skinSpec.b = skinShadow * skinSmooth * _CharacterParams8.z * _CharacterParams8.w * skinNdotBN * (_CharacterParams9.z * (diffColor.b - 0.25) + 0.25);

                    // ==== SUBSURFACE SPECULAR (decompiled _2982-_3011) ====
                    float mainNdotL_xz = dot(float3(adjXZ_x, adjXZLen * NEAR_ZERO_Y, adjXZ_z), N);
                    float wrapNdotL = saturate(0.5 + mainNdotL_xz - 0.5 * mainNdotL_xz * mainNdotL_xz);
                    float camLightFacing = (1.0 - _CharacterParams12.x) * camLightDot;
                    float edgeT = saturate((-abs(dot(V, N)) + 0.4) * 5.0);
                    float edgeFresnel = edgeT * edgeT * (3.0 - 2.0 * edgeT);
                    float brightT = saturate((0.1 - diffColorLum) * 16.666);
                    float brightnessGate = (brightT * brightT) * (3.0 - 2.0 * brightT);
                    float3 subsurfLight = blendedLightCol * blendedLightInt;
                    float3 subsurfSpec = brightnessGate * furShadowMask * edgeFresnel * camLightFacing * wrapNdotL * subsurfLight * max(diffColor, 0.15);

                    // ==== CUBEMAP REFLECTION (decompiled _3065-_3103, using URP probe) ====
                    float3 reflDir = reflect(-V, N);
                    float cubeMip = log2(max(roughnessRaw, 0.001)) * 1.2 + 5.0;
                    half4 cubeEnc = SAMPLE_TEXTURECUBE_LOD(unity_SpecCube0, samplerunity_SpecCube0, reflDir, cubeMip);
                    half3 cubeSample = DecodeHDREnvironment(cubeEnc, unity_SpecCube0_HDR);

                    float dfgX, dfgY;
                    ComputeEnvBRDF(NdotV_spec, roughness, dfgX, dfgY);
                    float3 envBRDF = specRampEnv * dfgX + dfgY;
                    float totalRefl = dfgX + dfgY;
                    float reflBoost = (1.0 - totalRefl) / max(totalRefl, 1e-6);

                    float cubeAmbInt = ambDiffInt * (clamp(exposure, 0.5, 1.5) * _CharacterParams0.w);
                    float3 cubeRefl = cubeSample * envBRDF * (1.0 + reflBoost * specRampEnv);
                    float3 cubemapContrib = cubeAmbInt * cubeRefl * ambCol;

                    // ==== FINAL ASSEMBLY (decompiled _3511-_3515, _3731-_3739) ====
                    float desatFactor = desatAmt * desatAmt + 1.0;
                    float3 desatMainLit = desatFactor * (mainLit - mainLitLum) + mainLitLum;

                    float3 finalColor = desatMainLit + skinSpec + subsurfSpec + cubemapContrib;

                    // ---- Character VFX Special: additive color (decompiled lines 2188-2217) ----
                    #ifdef _CHARACTER_VFX_SPECIAL
                        // Blend factor (decompiled line 2188)
                        float vfxBlendFactor = saturate((vfxAlphaBase * vfxTexAlpha + vfxBlendSmp.a) * _VFXBlendTint.a);
                        // VFX main color (decompiled lines 2189-2191)
                        // Original blob: additive (VFXColor + BlendTint). Sandbox: lerp for HDR visibility.
                        float3 vfxColorTerm = _VFXColorIntensity * _VFXColor.rgb * vfxMainRGB;
                        float3 vfxTintTerm = _VFXBlendTint.rgb * _VFXColorIntensity;
                        float vfxTintWeight = saturate(vfxBlendFactor * dot(vfxBlendSmp.rgb, 0.333));
                        float3 vfxMainColor = lerp(vfxColorTerm, vfxTintTerm, vfxTintWeight);
                        // Dissolve edge color modulation (decompiled lines 2192-2194)
                        // lerp(mainColor, edge * FresnelColor * Intensity, edge)
                        float3 vfxDissolvedColor = lerp(vfxMainColor, vfxDissolveEdge * _VFXFresnelColor.rgb * _VFXColorIntensity, vfxDissolveEdge);
                        // Fresnel alpha (decompiled line 2195)
                        float vfxFresnelAlpha = vfxFresnelFlipped * _VFXFresnelColor.a;
                        // Dissolve visibility masks opacity (decompiled line 2196)
                        float vfxDissolveVis = saturate(vfxDissolveDelta);
                        float vfxOpacity = saturate(vfxDissolveVis * vfxAlphaBase * vfxTexAlpha)
                                         * lerp(1.0, vfxFresnelFlipped, _VFXFresnelAffectOpacity);
                        // Final: lerp dissolved color toward FresnelColor, scale by opacity
                        float3 vfxContrib = vfxOpacity * lerp(vfxDissolvedColor, _VFXFresnelColor.rgb, vfxFresnelAlpha);
                        finalColor += vfxContrib * alphaPremul;
                    #endif

                    finalColor /= _ExposureParams.x;
                    finalColor = ApplyCustomAO(finalColor, shadowColor, GetNormalizedScreenSpaceUV(input.positionCS));

                    return float4(finalColor, shellAlpha);
                }
            ENDHLSL
        }
    }
}
