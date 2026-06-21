// HGRP CharacterNPR LiquidAG (liquid-silver / mercury character) — ForwardLit + Outline + ShadowCaster + DepthNormals.
// Merged from: characternpr_liquidag.shader base variant (catch-all #else blobs b24/b25 Fwd, b132/b133 Outline, b196/b197 PreGBuffer->DepthNormals, b211/b212 ShadowCaster).
// Keywords: _NORMALMAP, _EMISSION, _METALLICSPECGLOSSMAP, _ALPHATEST_ON, _OUTLINE_MASK
// Kept: base albedo+BaseColor, Shadow Color (brightness/saturation, b25:344-348), MetallicGlossMap (R=metal,G=spec,B=shadowMask,A=smooth, b25 _METALLICSPECGLOSSMAP variant),
//   Normal Map (b25:_NORMALMAP variant), SH ambient (IV cascade -> SampleSH, b25:379-682 with CP2 fallback), NPR wrap-diffuse + ramp-less shadow compose (b25:1745-1945),
//   GGX Specular w/ custom HG half-vector (b25:1046-2015) + CP13.w gate, Skin Specular CP8/CP9/CP15.w (b25:1074-2295), Subsurface rim spec (b25:2331-2352),
//   Cubemap reflection T15 + analytic EnvBRDF (b25:2096-2444), VFX Color Adjustment (b25:1719-1731), Alpha Premultiply via _SurfaceType (b25:1066/1742),
//   Character Outline (inverted hull b132 + SIMPLE shading b133: tintedAlbedo*lerp(lightLum,lightCol*CP0.y,shadow), NOT the ForwardLit spine), ShadowCaster (b211/b212), DepthNormals (PreGBuffer b196/b197 -> URP normals prepass, faceSign-flipped).
// Removed: GPU skinning, SRP instancing, per-object motion vectors (SV_Target1 MV/TAAU pack b25:773-776), TAA jitter,
//   CSM/ASM/cloud directional shadow atlases (b25:789-988 -> URP GetMainLight shadowAttenuation), punctual light tile/zbin binning loop (b25:1149-1715 -> URP additional lights, dropped),
//   IV volumetric-irradiance 3D-texture cascade (b25:381-668 -> URP SampleSH), atmosphere/exponential/volumetric froxel fog (b25:1743-1818 -> URP MixFog),
//   light cookies, _CharacterParams10 runtime detail-VFX path (b25:695-754), _ALPHA_SCENE_DEPTH_FADE/_CHARACTER_VFX_SPECIAL/_ENEMY_HIT_FLASH/VFX_CHARACTER_DISSOLVE/DITHER keyword variants.
//
// NOTE: CharacterParams are HGRP globals (cbuffer type_ShaderVariablesGlobal, b25:71-83) with no URP equivalent -> re-exposed as material Vectors.
//   LiquidAG uses CP2 = ambient color fallback, CP5 = light color override, CP15.w = skin-spec view-rotation blend (b25:1077-1079).
// _MetallicGlossMap channels: R=Metallic, G=Specular scale, B=shadow mask, A=Smoothness (b25 metallic/spec/shadowMask/smooth assignment).

Shader "HGRP/CharacterNPR_LiquidAG_Fix" {
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
        [HideInInspector] _AlphaPremultiply ("Alpha Premultiply", Float) = 0
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 0
        [Toggle(_ALPHATEST_ON)] _AlphaClip ("Alpha Clip", Float) = 0
        _AlphaClipThreshold ("Alpha Clip Threshold", Range(0, 1)) = 0.5

        _ShadowColorBrightness ("Shadow Color Brightness", Range(0, 1)) = 0.5
        _ShadowColorSaturation ("Shadow Color Saturation", Range(0, 2)) = 1

        [Toggle(_METALLICSPECGLOSSMAP)] _UseMetallicGlossMap ("Use MetallicGlossMap", Float) = 0
        [Gamma] _Metallic ("Metallic", Range(0, 1)) = 0
        _Specular ("Specular Scale", Range(0, 1)) = 1
        _Smoothness ("Smoothness", Range(0, 1)) = 0.5
        _MetallicGlossMap ("RGBA: Metal,Spec,Shadow,Smooth", 2D) = "white" {}

        [Toggle(_NORMALMAP)] _UseBumpMap ("Use Normal Map", Float) = 0
        _BumpScale ("Normal Scale", Float) = 1
        _BumpMap ("Normal Map", 2D) = "bump" {}

        [Toggle(_EMISSION)] _UseEmission ("Use Emission", Float) = 0
        _EmissionColor ("Emission Color", Color) = (0, 0, 0, 1)
        _EmissionBrightness ("Emission Brightness", Float) = 1
        _EmissionMap ("Emission", 2D) = "black" {}

        [HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}

        [Header(Cubemap)]
        _CharMaxCubemap ("Cubemap", Cube) = "" {}

        [Header(Outline)]
        [ToggleUI] _EnableOutline ("Enable Outline", Float) = 1
        _OutlineWidth ("Outline Width", Range(0, 50)) = 0.5
        _OutlineOffsetZ ("Outline Offset Z", Range(0, 1)) = 0.0
        _OutlineColorBrightness ("Outline Color Brightness", Range(0, 1)) = 0.5
        _OutlineColorSaturation ("Outline Color Saturation", Range(0, 2)) = 1.0
        [ToggleUI] _OutlineAverageNormal ("Use Smooth Normal (UV2)", Float) = 1
        [ToggleUI] _OutlineTintEnable ("Outline Tint Enable", Float) = 0
        _OutlineTintColor ("Outline Tint Color", Color) = (1, 1, 1, 1)
        [Toggle(_OUTLINE_MASK)] _EnableOutlineMask ("Outline Mask Enable", Float) = 0
        _OutlineMask ("Outline Mask", 2D) = "white" {}
        [Enum(On, 7, Off, 255)] _OutlineInnerClipStencilMask ("Outline Inner Clip Stencil Mask", Float) = 255

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
        _CharacterParams1 ("CP1 (.x=brightMix .y=ambientGate .z=shadowLerp .w=lightDirOverride)", Vector) = (0, 0, 0, 0)
        _CharacterParams2 ("CP2 (ambient color rgb fallback)", Vector) = (1, 1, 1, 0)
        _CharacterParams5 ("CP5 (light color override rgb)", Vector) = (1, 1, 1, 1)
        _CharacterParams6 ("CP6 (ambient/NPR-NdotL direction)", Vector) = (0, 1, 0, 0)
        _CharacterParams7 ("CP7 (.x=offset .y=scale .z=bias)", Vector) = (0.15, 0.6, 1, 0)
        _CharacterParams8 ("CP8 (skin spec color rgb + .w=intensity)", Vector) = (0, 0, 0, 1)
        _CharacterParams9 ("CP9 (skin spec .xy=dir .z=tint .w=width)", Vector) = (0, 1, 0, 0.4)
        _CharacterParams11 ("CP11 (light dir override xyz + .w=rampBias)", Vector) = (-0.433, 0.5, 0.75, 0)
        _CharacterParams12 ("CP12 (.x=rampOffset .y=lightColOverride .z=shadowGate .w=exposureBlend)", Vector) = (0, 0, 0, 0)
        _CharacterParams13 ("CP13 (.w=GGX specular toggle)", Vector) = (0, 0, 0, 1)
        _CharacterParams15 ("CP15 (.w=skin spec view-rotation blend)", Vector) = (0, 0, 0, 0)
        _EnvironmentGlobalParams0 ("EnvGlobalParams0 (.x=ambient intensity)", Vector) = (1.67, 1.5, 1, 0)
        _ExposureParams ("ExposureParams (.x=exposure)", Vector) = (1, 0, 0, 0)

        // Behind-Hair Composite stencil + outline inner-clip (HG stencil bits)
        [HideInInspector] _StencilRef ("Stencil Ref", Float) = 0
        [HideInInspector] _StencilClearMask ("Stencil Write Mask", Float) = 32
    }
    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Opaque" }
        LOD 600

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

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
                float _BumpScale;
                float4 _EmissionColor;
                float _EmissionBrightness;
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
                // Character params (HGRP globals re-exposed)
                float4 _CharacterParams0;
                float4 _CharacterParams1;
                float4 _CharacterParams2;   // ambient color fallback
                float4 _CharacterParams5;   // light color override
                float4 _CharacterParams6;
                float4 _CharacterParams7;
                float4 _CharacterParams8;
                float4 _CharacterParams9;
                float4 _CharacterParams11;
                float4 _CharacterParams12;
                float4 _CharacterParams13;
                float4 _CharacterParams15;  // .w = skin-spec view-rotation blend
                float4 _EnvironmentGlobalParams0;
                float4 _ExposureParams;
            CBUFFER_END

            TEXTURE2D(_BaseMap);          SAMPLER(sampler_BaseMap);
            TEXTURE2D(_BumpMap);          SAMPLER(sampler_BumpMap);
            TEXTURE2D(_MetallicGlossMap); SAMPLER(sampler_MetallicGlossMap);
            TEXTURE2D(_EmissionMap);      SAMPLER(sampler_EmissionMap);
            TEXTURE2D(_OutlineMask);      SAMPLER(sampler_OutlineMask);
            TEXTURECUBE(_CharMaxCubemap); SAMPLER(sampler_CharMaxCubemap);

            // Rec.709 luma (b25: 0.21267290,0.71515220,0.07217500)
            static const float3 LUM = float3(0.2126729, 0.7152, 0.07217500);
            // tiny non-zero Y to avoid degenerate XZ-plane normalization (b25:351 asfloat(947912704u))
            static const float NEAR_ZERO_Y = 6.103515625e-05; // asfloat(947912704u)

            // Analytic environment-BRDF rational approximation (b25:2096-2097).
            // Returns dfgX (F0 scale) and dfgY (bias); poly coeffs are 1:1 (decoded from asfloat magics).
            void ComputeEnvBRDF(float NdotV, float roughSq, out float dfgX, out float dfgY) {
                float NdotV2 = NdotV * NdotV;     // _2147
                float NdotV3 = NdotV * NdotV2;    // _2148
                float roughSq3 = roughSq * (roughSq * roughSq); // _2150

                // dfgX (b25:2096)
                float2 numX = float2(
                    dot(float2(3.32706999, 1.0), float2(NdotV, 0.0365463)),   // asfloat(1024831891u)=0.0365463
                    dot(float2(-9.04755973, 1.0), float2(NdotV, 9.0632))      // asfloat(1091633886u)=9.0632
                );
                float3 denX = float3(
                    dot(float3(3.59684991, -1.36772000, 1.0), float3(NdotV2, NdotV3, 1.0)),
                    dot(float3(-16.31739997, 1.0, 9.22949028), float3(NdotV2, 9.04401, NdotV3)), // asfloat(1091613764u)=9.04401
                    dot(float3(1.0, 19.78860092, -20.21229934), float3(5.56589, NdotV2, NdotV3)) // asfloat(1085414341u)=5.56589
                );
                dfgX = dot(numX, float2(1.0, roughSq)) / dot(denX, float3(1.0, roughSq, roughSq3));

                // dfgY (b25:2228)
                float2 numY = float2(
                    dot(float2(-1.28514003, 1.0), float2(NdotV, 0.99044)),    // asfloat(1065192826u)=0.99044
                    dot(float2(1.0, -0.75590699), float2(1.29678, NdotV))     // asfloat(1067842787u)=1.29678
                );
                float3 denY = float3(
                    dot(float3(2.92337989, 59.41880035, 1.0), float3(NdotV, NdotV3, 1.0)),
                    dot(float3(1.0, -27.03019905, 222.59199524), float3(20.3225, NdotV, NdotV3)), // asfloat(1101173883u)=20.3225
                    dot(float3(626.13000488, 316.62701416, 1.0), float3(NdotV, NdotV3, 121.563))  // asfloat(1123229762u)=121.563
                );
                dfgY = dot(numY, float2(1.0, roughSq)) / dot(denY, float3(1.0, roughSq, roughSq3));
            }

            // ================================================================
            // Shared NPR lighting — used by ForwardLit and Outline passes.
            // albedo: already processed (raw*BaseColor for ForwardLit; brightness/saturation adjusted for Outline).
            // faceSign: front/back normal flip. baseAlpha: base map .a (pre-_BaseColor.a). Mirrors b25:frag_main, charShadow path.
            // ================================================================
            float3 computeNPRLighting(float2 uv, float3 positionWS, float3 normalWS_raw, float4 tangentWS, float faceSign, float3 albedo, float baseAlpha) {
                // ---- Object-to-World origin (b25:332-333 ObjectToWorld[3].x/.z) ----
                float originX = unity_ObjectToWorld._m03;
                float originZ = unity_ObjectToWorld._m23;

                // ---- View direction (b25:307-320: ortho-blend camera fwd) ----
                float3 toCam = _WorldSpaceCameraPos - positionWS;
                float3 orthoFwd = float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22);
                float3 viewRaw = toCam + unity_OrthoParams.w * (orthoFwd - toCam);
                float distSq = dot(viewRaw, viewRaw);
                float invLen = rsqrt(max(distSq, 9.99999993922529e-09)); // _190
                float3 V = viewRaw * invLen;                              // _191,_192,_193

                // ---- MetallicGlossMap ---- (b25 _METALLICSPECGLOSSMAP variant; base reads sliders)
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
                float roughnessRaw = 1.0 - smoothness; // _259

                // ---- Shadow color (b25:344-348: luma-desaturate of brightness-scaled albedo) ----
                float3 shadBright = albedo * _ShadowColorBrightness; // _267..269 * brightness
                float shadLum = dot(shadBright, LUM);                // _277
                float3 shadowColor = _ShadowColorSaturation * (shadBright - shadLum) + shadLum; // _293..295

                // ---- Normal (b25:356-363 geometric; _NORMALMAP variant adds TBN map) ----
                float3 N;
                #ifdef _NORMALMAP
                    float4 nrmSmp = SAMPLE_TEXTURE2D(_BumpMap, sampler_BumpMap, uv);
                    float nrmXraw = nrmSmp.x * nrmSmp.w * 2.0 - 1.0; // _315 (DXT5nm: x*a)
                    float nrmYraw = nrmSmp.y * 2.0 - 1.0;            // _317
                    float nrmZ = max(sqrt(1.0 - min(nrmXraw*nrmXraw + nrmYraw*nrmYraw, 1.0)), 1e-16); // _325 (Z from UNSCALED X,Y; pre-_BumpScale)
                    float nrmX = nrmXraw * _BumpScale; // _330
                    float nrmY = nrmYraw * _BumpScale; // _331
                    float3 nrmWS = normalize(normalWS_raw);
                    float3 tanWS = normalize(tangentWS.xyz);
                    float3 bitWS = cross(nrmWS, tanWS) * tangentWS.w;
                    N = faceSign * normalize(nrmZ * nrmWS + nrmX * tanWS + nrmY * bitWS); // _405..407 -> _426..428 -> _429..431
                #else
                    float3 nrmWS = normalize(normalWS_raw);          // _335..337
                    N = faceSign * nrmWS;                            // _350 * normalized normal -> _351..353
                #endif

                // ---- Flat direction: origin->fragment on XZ plane (b25:349-355) ----
                float fX = positionWS.x - originX;
                float fZ = positionWS.z - originZ;
                float fLen = rsqrt(fX*fX + NEAR_ZERO_Y*NEAR_ZERO_Y + fZ*fZ);
                float3 flatDir = float3(fX*fLen, NEAR_ZERO_Y*fLen, fZ*fLen); // _310,_311,_312

                // ---- Exposure (b25:367) ----
                float exposure = (_CharacterParams12.w * (1.0 - _EnvironmentGlobalParams0.x) + _EnvironmentGlobalParams0.x) * _ExposureParams.x; // _398

                // ---- Ambient (IV cascade disabled -> CP2 fallback, b25:669-682 charShadow branch) ----
                float ambInt = exposure;                  // _532
                float3 ambCol = _CharacterParams2.xyz;    // _536,_538,_540
                // SH directional terms collapse: base (no IV) => directional SH = 0, weight CP-driven (b25:676-681)

                // ---- Camera forward / inverse-view col2 (b25 _InvViewMatrix[2].xyz) ----
                float3 camFwd = float3(UNITY_MATRIX_I_V._m02, UNITY_MATRIX_I_V._m12, UNITY_MATRIX_I_V._m22);

                // ---- Metallic workflow (b25:755-766) ----
                float oneMinusRefl = (1.0 - metallic) * 0.96;     // _1177 (mad(-metallic,0.96,0.96))
                float3 diffColor = oneMinusRefl * albedo;         // _1179..1181
                float dielSpec = specScale * 0.04;                // _1185
                float3 specColor = metallic * (albedo - dielSpec) + dielSpec; // _1194..1196
                float3 shadowDiff = oneMinusRefl * shadowColor;   // _1197..1199
                float roughness = max(roughnessRaw * roughnessRaw, 0.0078125); // _1201

                // ---- Main light from URP (replaces HG CSM/ASM/cloud atlas, b25:789-989) ----
                float4 shadowCoord = TransformWorldToShadowCoord(positionWS);
                Light mainLight = GetMainLight(shadowCoord);
                float3 mainLightDir = mainLight.direction; // -_LightDataBuffer_DirectionalLightDirection[0].xyz
                float3 lightCol = mainLight.color;         // _LightDataBuffer_DirectionalLightDirection[3].xyz
                float lightInt = 1.0;                      // _1335 (defaults to 1)
                // castShadow: lerp(shadowAtten,1,CP1.z) (b25:989-990 _1657,_1663)
                float charShadow = lerp(mainLight.shadowAttenuation, 1.0, _CharacterParams1.z); // _1663

                // ---- Adjusted light direction (b25:777-783) ----
                float3 adjustedLightDir = lerp(mainLightDir, _CharacterParams11.xyz, _CharacterParams1.w); // _1285..1287
                float adjXZLen = rsqrt(adjustedLightDir.x*adjustedLightDir.x + adjustedLightDir.z*adjustedLightDir.z + NEAR_ZERO_Y*NEAR_ZERO_Y); // _1292
                float adjXZ_x = adjXZLen * adjustedLightDir.x; // _1293
                float adjXZ_z = adjXZLen * adjustedLightDir.z; // _1295

                // ---- Light color blend (CP5 override) (b25:784-787) ----
                float3 blendedLightCol = lerp(lightCol, _CharacterParams5.xyz, _CharacterParams12.y); // _1321..1323
                float blendedLightInt = lerp(lightInt, 1.0, _CharacterParams12.w);                    // _1335

                // ---- Camera-light facing terms (b25:996-1003) ----
                float ivXZLen = rsqrt(dot(camFwd.xz, camFwd.xz)); // _1692 (InvView col2 xz)
                float camLightDot = saturate(-(adjXZ_x * (ivXZLen * camFwd.x) + adjXZ_z * (ivXZLen * camFwd.z))); // _1703
                float camYFade = saturate(2.0 * (0.75 - abs(camFwd.y))); // _1724
                float camYSmooth = camYFade * camYFade * (3.0 - 2.0 * camYFade);

                // ---- NPR wrap-diffuse ramp input (ramp-less: clamp(modNdotL)*0.5+0.5) (b25:991,1002-1008) ----
                float geomNdotL = dot(N, adjustedLightDir); // _1664 (dot N, _1285..1287)
                float wrapAdd = mad(-geomNdotL, mad(geomNdotL, 0.5, -1.0), -geomNdotL) + 0.5; // b25:1002 inner mad
                float camFadeFactor = (1.0 - _CharacterParams12.x) * (camLightDot * camYSmooth); // _1710*( _1703*camYSmooth )
                float modNdotL = mad(camFadeFactor, wrapAdd, geomNdotL); // inside _1745
                float rampInput01 = max(min(mad(_CharacterParams11.w, _CharacterParams12.x, modNdotL), 1.0), -1.0); // _1745 pre-bias clamp[-1,1]
                float rampA = max((rampInput01 - 0.25) * 1.33333337, 0.0); // _1745 (remap to ramp coord)
                float rampSmooth = (rampA * rampA) * mad(rampA, -2.0, 3.0); // _1748 smoothstep

                // ---- View-facing ramp term (b25:1004-1007) ----
                float viewNdotN = saturate((dot(N, camFwd) - 0.25) * 1.33333337); // _1759
                float vN_3m2 = mad(viewNdotN, -2.0, 3.0);    // _1760 = 3 - 2*viewNdotN
                float vN_sq = viewNdotN * viewNdotN;          // _1761
                float viewRampSmooth = vN_sq * vN_3m2;        // _1762 (smoothstep)
                float minShadow = min(rampSmooth, 1.0);       // _1763

                // ---- NPR diffuse compose (charShadow=screen shadow; ramp-less) (b25:1009-1024) ----
                float nprNdotL = mad(saturate(dot(N, _CharacterParams6.xyz) + _CharacterParams7.x), _CharacterParams7.y, _CharacterParams7.z); // _1785
                float shadowStr = minShadow * _CharacterParams1.y; // _1789
                float3 shadAmb = nprNdotL * (shadowStr * (1.0 - ambCol) + ambCol); // _1799..1801

                float bright065 = min(mad(ambInt, 0.35, 0.65), 1.5);     // _1804
                float brightFull = clamp(ambInt, 0.0, 1.5);              // _1812
                float brightMix = lerp(bright065, clamp(ambInt, 1.25, 1.75), _CharacterParams1.x); // _1819
                float3 brightAmb = brightMix * shadAmb * _CharacterParams0.w; // _1826..1828

                float lightLum = dot(blendedLightCol * blendedLightInt, LUM); // _1829
                float oneMinus12y = 1.0 - _CharacterParams12.y;              // _1711
                float3 lightBlend = blendedLightCol * _CharacterParams12.y + oneMinus12y; // mad(CP5,CP12.y,1-CP12.y)
                float3 fullDiff;
                fullDiff.r = mad(charShadow, mad(mad(shadAmb.r * brightFull, lightBlend.r, mad(minShadow, mad(blendedLightCol.r, blendedLightInt, -lightLum), lightLum)), _CharacterParams0.y, -brightAmb.r), brightAmb.r); // _1860
                fullDiff.g = mad(charShadow, mad(mad(shadAmb.g * brightFull, lightBlend.g, mad(minShadow, mad(blendedLightCol.g, blendedLightInt, -lightLum), lightLum)), _CharacterParams0.y, -brightAmb.g), brightAmb.g); // _1861
                fullDiff.b = mad(charShadow, mad(mad(shadAmb.b * brightFull, lightBlend.b, mad(minShadow, mad(blendedLightCol.b, blendedLightInt, -lightLum), lightLum)), _CharacterParams0.y, -brightAmb.b), brightAmb.b); // _1862

                // ---- Shadow-tinted albedo blends (b25:992-994,1025-1045) ----
                float3 albScaled = shadowDiff * _CharacterParams0.z; // _1671..1673
                float albScaledLum = dot(albScaled * 0.65, LUM);     // _1863
                float3 desatShad = mad(albScaled * 0.65 - albScaledLum, 1.2, albScaledLum); // _1870..1873
                // weighted ambient: lerp(desatShad, shadowDiff*CP0.z, _1875) where _1875 = min(vN_3m2*vN_sq + rampSmooth, 1) (b25:1030-1033)
                float w1875 = min(mad(vN_3m2, vN_sq, rampSmooth), 1.0); // _1875
                float3 weightedAmb = mad(w1875.xxx, mad(shadowDiff, _CharacterParams0.z, -desatShad), desatShad); // _1885..1887
                float diffColorLum = dot(diffColor, LUM); // _1678 (diffColor = _1179..1181 = albedo*oneMinusRefl)
                // shadowBlended: lerp(weightedAmb, diffColor, minShadow) (b25:1034-1036; _1894=mad(_1763, mad(_1172,_1177,-_1885), _1885))
                float3 shadowBlended = mad(minShadow.xxx, diffColor - weightedAmb, weightedAmb); // _1894..1896
                // view-dependent shadow (b25:1037-1040): _1913 = mad(_1762, mad(-_1197,CP0.z, mad(mad(_1172,_1177,-_1678),1.2,_1678)), _1671)
                float3 viewDepShad = mad(viewRampSmooth.xxx, mad(-shadowDiff, _CharacterParams0.z, mad(diffColor - diffColorLum, 1.2, diffColorLum)), albScaled); // _1913..1915
                // luma-preserve ratio (b25:1041-1045)
                float shadowLumVal = dot(shadowBlended, LUM); // _1916
                float lumRatio = clamp(shadowLumVal * (1.0 / max(shadowLumVal, 0.001)), 0.0, 1.5); // _1924
                float3 nprDiff = mad(charShadow.xxx, mad(shadowBlended, lumRatio, -viewDepShad), viewDepShad); // _1931..1933

                // _1936 = mad(charShadow, mad(-vN_3m2, vN_sq, minShadow), viewRampSmooth); _1945 = lerp(_1936->1 by (1-CP0.z))*... (b25:1046-1047)
                float npr1936 = mad(charShadow, mad(-vN_3m2, vN_sq, minShadow), viewRampSmooth); // _1936
                float ambDiffInt = mad(npr1936, 1.0 - _CharacterParams0.z, _CharacterParams0.z); // _1945

                // ==== ALPHA PREMULTIPLY (b25:1066) ====
                float alphaPremul = mad(baseAlpha * _BaseColor.a, _AlphaPremultiply, 1.0 - _AlphaPremultiply); // _2000 (_270 = base.a*BaseColor.a)

                // ==== GGX SPECULAR (HG custom half-vector) (b25:1046-2015) ====
                float NdotV_spec = saturate(dot(N, V)); // _1951
                // half-vector h built from camera-fwd reflect + light + view (b25:1046-1062)
                float hY = mad(charShadow, adjustedLightDir.y - 0.5, 0.5); // _1947 (mad(charShadow, CP-lightY-0.5, 0.5))
                float3 ivCol2 = float3(UNITY_MATRIX_I_V._m02, hY, UNITY_MATRIX_I_V._m22); // (_1956,_1947,_1958)
                float ivLen = rsqrt(max(dot(ivCol2, ivCol2), 1.175494e-38)); // _1963
                float3 ivN = ivCol2 * ivLen; // _1964..1966
                float shadowPlus2 = charShadow + 2.0; // _1973
                float3 Hraw = mad(V, shadowPlus2.xxx, mad(adjustedLightDir, charShadow.xxx, ivN + ivN)); // _1974..1976
                float3 H = Hraw * rsqrt(dot(Hraw, Hraw)); // _1980
                float NdotH = dot(N, H); // _1984
                float roughSq = roughness * roughness; // _1987
                float denom = mad(mad(NdotH, roughSq, -NdotH), NdotH, 1.0); // _1990
                float denomSq = denom * denom; // _1991
                float D_raw = (denomSq != roughSq) ? roughSq / denomSq : 1.0; // _2015 inner asfloat select
                float ggxTerm = clamp(mad(D_raw, 0.5 / (mad(NdotV_spec, 2.0, roughness) + 9.9999997e-05), -NEAR_ZERO_Y), 0.0, 20.0); // _2015

                // specular ambient intensity (b25:1068): _2021 = _1945 * mad(_1936, 0.5, 0.5)
                float specAmbInt = ambDiffInt * mad(npr1936, 0.5, 0.5); // _2021

                // ---- Main lit composition (diffuse premultiplied, specular not) (b25:1069-1071) ----
                float3 mainLit;
                mainLit.r = mad(fullDiff.r * nprDiff.r, alphaPremul, ((specAmbInt * fullDiff.r) * (specColor.r * ggxTerm)) * _CharacterParams13.w); // _2035
                mainLit.g = mad(fullDiff.g * nprDiff.g, alphaPremul, ((specAmbInt * fullDiff.g) * (specColor.g * ggxTerm)) * _CharacterParams13.w); // _2036
                mainLit.b = mad(fullDiff.b * nprDiff.b, alphaPremul, ((specAmbInt * fullDiff.b) * (specColor.b * ggxTerm)) * _CharacterParams13.w); // _2037
                float mainLitLum = dot(mainLit, LUM); // _2038
                float desatAmt = clamp(mainLitLum - 0.5, 0.0, 0.5); // _2043

                // ==== SKIN SPECULAR CP8/CP9/CP15.w (b25:1074-2295) ====
                // skin dir built from CP9.xy rotated through ViewMatrix COLUMNS, blended by CP15.w (b25:1077-1086).
                // _ViewMatrix is column_major: _ViewMatrix[col].row == UNITY_MATRIX_V._m{row}{col}.
                // So _ViewMatrix[1u].x=_m01, [1u].y=_m11 (sdY); [2u].x=_m02, [2u].y=_m12 (sdZ); [0u].x=_m00, [0u].y=_m10 (sdX).
                float cp9x = _CharacterParams9.x; // _2096
                float cp9y = _CharacterParams9.y; // _2094
                float sdY = mad(_CharacterParams15.w, (UNITY_MATRIX_V._m01 * cp9x + UNITY_MATRIX_V._m11 * cp9y) - cp9y, cp9y); // _2108 (_ViewMatrix[1u].x/.y)
                float sdZ = mad(_CharacterParams15.w, (UNITY_MATRIX_V._m02 * cp9x + UNITY_MATRIX_V._m12 * cp9y) - 0.0, 0.0); // _2109 (_ViewMatrix[2u].x/.y)
                float sdX = mad(_CharacterParams15.w, (UNITY_MATRIX_V._m00 * cp9x + UNITY_MATRIX_V._m10 * cp9y) - cp9x, cp9x); // _2110 (_ViewMatrix[0u].x/.y)
                // cross with InvView col2 to get world skin dir (b25:1080-1086)
                float3 ivc2 = float3(UNITY_MATRIX_I_V._m02, UNITY_MATRIX_I_V._m12, UNITY_MATRIX_I_V._m22);
                float3 skinDir;
                skinDir.x = mad(ivc2.y, sdZ, -(sdY * ivc2.z)); // _2127
                skinDir.y = mad(ivc2.z, sdX, -(sdZ * ivc2.x)); // _2128
                skinDir.z = mad(ivc2.x, sdY, -(sdX * ivc2.y)); // _2129
                skinDir = skinDir * rsqrt(dot(skinDir, skinDir)); // _2134..2136

                float skinFresnel = 1.0 - abs(dot(N, V)); // _2139 (=_2138+1, _2138=-abs(_1948))
                float skinLow = mad(_CharacterParams9.w, -0.6, 0.8);  // _2244
                float skinHigh = mad(_CharacterParams9.w, -0.4, 0.9); // inside _2255
                float skinT = saturate((skinFresnel - skinLow) / (skinHigh - skinLow)); // _2255
                float skinSmooth = (skinT * skinT) * mad(skinT, -2.0, 3.0); // _2258
                float skinNdotL = saturate(dot(flatDir, skinDir) + 1.0); // _2278
                float skinNdotBN = saturate(dot(skinDir, N));            // _2295

                // ==== SUBSURFACE / wrap terms (b25:2316-2352) ====
                // base collapse of _2326: _534=0 (b25:672) and _548..552=0 (b25:679-681) kill the _2316 ambient-light-dir term,
                // leaving only the _2142 (adjusted-light XZ flat dir . N) wrap. (b25:1089 _2142, :1114 _2326)
                float subNdotL = dot(float3(adjXZ_x, adjXZLen * NEAR_ZERO_Y, adjXZ_z), N); // _2142 (= dot((_1293, _1292*_1288, _1295), N))
                float wrapNdotL = saturate(mad(charShadow, mad(-subNdotL, mad(subNdotL, 0.5, -1.0), 0.5), 0.0)); // _2326 (charShadow gate, _534=0 base)
                float camLightFacing = (1.0 - _CharacterParams12.x) * mad(camLightDot, charShadow, 1.0 - charShadow); // _2331
                float edgeT = saturate((-abs(dot(N, V)) + 0.4) * 5.0); // _2337 (=clamp((_2138+0.4)*5))
                float edgeFresnel = (edgeT * edgeT) * mad(edgeT, -2.0, 3.0); // _2340
                float brightT = saturate((diffColorLum - 0.1) * (-16.6666660)); // _2348
                float brightGate = (brightT * brightT) * mad(brightT, -2.0, 3.0); // _2352 numerator
                float subGate = mad(brightGate, charShadow, 1.0 - charShadow); // _2352
                // per-channel light factor: lerp(1, blendedLightCol*blendedLightInt, charShadow) — base _2304=_2305=_2306=1 (b25:1109-1112, _542/544/546=1)
                float3 subsurfLightFac = mad(charShadow.xxx, blendedLightCol * blendedLightInt - 1.0, 1.0); // mad(_1663, mad(_1321,_1335,-_2304), _2304)
                float subsurfScalar = subGate * (edgeFresnel * (camLightFacing * wrapNdotL)); // _2352*_2340*_2331*_2326 (scalar chain)
                float3 subsurfSpec = subsurfScalar * (subsurfLightFac * max(diffColor, 0.15)); // b25:1143 last mad arg, per-channel max(_1179..1181,0.15)

                // skin specular term (b25:2853 middle): _2278 * smooth * CP8.xyz*CP8.w * _2295 * (CP9.z*(diff-0.25)+0.25)
                float3 skinSpec;
                skinSpec.r = (skinNdotL * (skinSmooth * _CharacterParams8.x) * _CharacterParams8.w) * (skinNdotBN * mad(_CharacterParams9.z, diffColor.r - 0.25, 0.25)); // _2853 mid
                skinSpec.g = (skinNdotL * (skinSmooth * _CharacterParams8.y) * _CharacterParams8.w) * (skinNdotBN * mad(_CharacterParams9.z, diffColor.g - 0.25, 0.25));
                skinSpec.b = (skinNdotL * (skinSmooth * _CharacterParams8.z) * _CharacterParams8.w) * (skinNdotBN * mad(_CharacterParams9.z, diffColor.b - 0.25, 0.25));

                // ==== CUBEMAP REFLECTION (_CharMaxCubemap = T15) (b25:2096-2444) ====
                float3 reflDir = reflect(-V, N); // _2410 build: -V reflected about N (b25:1125-1127)
                float cubeMip = mad(log2(max(roughnessRaw, 0.001)), 1.2, 5.0); // _2423 lod
                half3 cubeSample = SAMPLE_TEXTURECUBE_LOD(_CharMaxCubemap, sampler_CharMaxCubemap, reflDir, cubeMip).rgb; // _2423.xyz

                float dfgX, dfgY;
                // EnvBRDF poly uses UNCLAMPED roughnessRaw^2 (_1200), NOT the GGX-clamped roughness (_1201). (b25:1096-1097 use _1200/_2150=_1200^3)
                float roughSqRaw = roughnessRaw * roughnessRaw; // _1200 (= _1174*_1174, no max(.,0.0078125))
                ComputeEnvBRDF(NdotV_spec, roughSqRaw, dfgX, dfgY); // _2192,_2228
                float3 envBRDF = mad(specColor, dfgX, dfgY); // _2229..2231
                float totalRefl = dfgX + dfgY;               // _2232
                float reflBoost = (1.0 - totalRefl) / totalRefl; // _2430
                float cubeAmbInt = ambDiffInt * (clamp(exposure, 0.5, 1.5) * _CharacterParams0.w); // _2444
                // cube term (b25:2853 first arg): _2444 * (cube * mad(_2430*specColor, envBRDF, envBRDF)) * ambCol
                float3 cubemapContrib;
                cubemapContrib.r = cubeAmbInt * (cubeSample.r * mad(reflBoost * specColor.r, envBRDF.r, envBRDF.r)) * ambCol.r;
                cubemapContrib.g = cubeAmbInt * (cubeSample.g * mad(reflBoost * specColor.g, envBRDF.g, envBRDF.g)) * ambCol.g;
                cubemapContrib.b = cubeAmbInt * (cubeSample.b * mad(reflBoost * specColor.b, envBRDF.b, envBRDF.b)) * ambCol.b;

                // ==== EMISSION ====
                float3 emissionContrib = float3(0, 0, 0);
                #ifdef _EMISSION
                    float3 emissionTex = SAMPLE_TEXTURE2D(_EmissionMap, sampler_EmissionMap, uv).rgb;
                    emissionContrib = emissionTex * _EmissionColor.rgb * _EmissionBrightness * alphaPremul;
                #endif

                // ==== FINAL ASSEMBLY (b25:2853-2857 fused) ====
                // _2853 = cubeTerm + mad(_2233[desatFactor], _2234[-lum]+_2035[mainLit], _2038[lum]) + skinSpec + subsurf
                float desatFactor = mad(desatAmt, desatAmt, 1.0); // _2233
                float3 desatMainLit = mad(desatFactor.xxx, mainLit - mainLitLum, mainLitLum); // desatFactor*(mainLit-lum)+lum
                float3 litColor = cubemapContrib + desatMainLit + skinSpec + subsurfSpec + emissionContrib;

                // ==== VFX COLOR ADJUSTMENT (b25:1719-1731) ====
                if (_EnableVFXColorAdjustment > 0.5) {
                    float litLum = dot(litColor, LUM); // _2993
                    float3 adjusted;
                    adjusted.r = mad(_ColorAdjustmentContrast, mad(_ColorAdjustmentSaturation, -litLum + litColor.r, litLum) - 0.5, 0.5); // _3012
                    adjusted.g = mad(_ColorAdjustmentContrast, mad(_ColorAdjustmentSaturation, -litLum + litColor.g, litLum) - 0.5, 0.5); // _3013
                    adjusted.b = mad(_ColorAdjustmentContrast, mad(_ColorAdjustmentSaturation, -litLum + litColor.b, litLum) - 0.5, 0.5); // _3014
                    float caRimComp = 1.0 - _ColorAdjustmentRimWidth; // _3046
                    float caRimT = saturate((-caRimComp + (1.0 - NdotV_spec)) * (1.0 / (1.0 - caRimComp))); // _3055
                    float caRimSmooth = (caRimT * caRimT) * mad(caRimT, -2.0, 3.0); // _3058
                    litColor.r = mad(caRimSmooth * _ColorAdjustmentRimColor.r, _ColorAdjustmentRimIntensity, mad(_ColorAdjustmentColorBlend.w, mad(-adjusted.r, _ColorAdjustmentBrightness, _ColorAdjustmentColorBlend.r), adjusted.r * _ColorAdjustmentBrightness)); // _3074
                    litColor.g = mad(caRimSmooth * _ColorAdjustmentRimColor.g, _ColorAdjustmentRimIntensity, mad(_ColorAdjustmentColorBlend.w, mad(-adjusted.g, _ColorAdjustmentBrightness, _ColorAdjustmentColorBlend.g), adjusted.g * _ColorAdjustmentBrightness)); // _3075
                    litColor.b = mad(caRimSmooth * _ColorAdjustmentRimColor.b, _ColorAdjustmentRimIntensity, mad(_ColorAdjustmentColorBlend.w, mad(-adjusted.b, _ColorAdjustmentBrightness, _ColorAdjustmentColorBlend.b), adjusted.b * _ColorAdjustmentBrightness)); // _3076
                }

                // ---- Exposure normalize (b25:1739-1741); HG fog dropped -> URP MixFog applied by caller if desired ----
                float3 finalColor = litColor / _ExposureParams.x;
                return finalColor;
            }

            // ================================================================
            // Outline shading — base outline blob b133 is a DISTINCT, much simpler model than ForwardLit:
            //   outlineColor.c = (rawAlbedo.c * _OutlineTintColor.c) * lerp(lightLumTerm, blendedLightCol.c*blendedLightInt, charShadow)
            // NO GGX / skin spec / cubemap / wrap-diffuse / view-ramp; NO _BaseColor.rgb; NO brightness/saturation/tint-toggle.
            // (b133:411-423 final color; :231-234 light; :414 lightLumTerm; :415-416 charShadow; :427-447 VFX; :455-457 exposure.)
            // ================================================================
            float3 computeOutlineLighting(float2 uv, float3 positionWS, float3 normalWS_raw, float3 rawAlbedo) {
                // View dir (b133:196-209: identical ortho-blend camera fwd to ForwardLit)
                float3 toCam = _WorldSpaceCameraPos - positionWS;
                float3 orthoFwd = float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22);
                float3 viewRaw = toCam + unity_OrthoParams.w * (orthoFwd - toCam);
                float3 V = viewRaw * rsqrt(max(dot(viewRaw, viewRaw), 9.99999993922529e-09));
                float3 N = normalize(normalWS_raw); // b133:185-189 (faceSign=1; outline pass does not flip, gl_FrontFacing path unused)

                // Main light + char shadow (b133:231-234 light blend, :415-416 charShadow)
                Light mainLight = GetMainLight(TransformWorldToShadowCoord(positionWS));
                float3 blendedLightCol = lerp(mainLight.color, _CharacterParams5.xyz, _CharacterParams12.y); // _385..387 / _384
                float blendedLightInt = lerp(1.0, 1.0, _CharacterParams12.w);                                // _384 (URP color already carries intensity)
                float3 lightScaled = blendedLightCol * blendedLightInt;                                       // _385..387 (= blended * _384)
                float charShadow = lerp(mainLight.shadowAttenuation, 1.0, _CharacterParams1.z);               // _510

                // Tinted albedo + simple lit term (b133:411-423)
                float3 tintedAlbedo = rawAlbedo * _OutlineTintColor.rgb;                       // _483..485 (raw base map, NO _BaseColor.rgb)
                float lightLumTerm = min(dot(lightScaled, LUM), 1.0) * _CharacterParams0.w;    // _497
                float3 litTerm = mad(charShadow.xxx, mad(lightScaled, _CharacterParams0.y, -lightLumTerm), lightLumTerm); // _518..520 = lerp(lightLumTerm, lightScaled*CP0.y, charShadow)
                float3 outColor = tintedAlbedo * litTerm;                                      // _521..523

                // VFX Color Adjustment (b133:427-447) — rim uses 1-NdotV (octahedral MV-normal pack -> identity)
                if (_EnableVFXColorAdjustment > 0.5) {
                    float outLum = dot(outColor, LUM); // _871
                    float3 adjusted;
                    adjusted.r = mad(_ColorAdjustmentContrast, mad(_ColorAdjustmentSaturation, mad(tintedAlbedo.r, litTerm.r, -outLum), outLum) - 0.5, 0.5); // _890
                    adjusted.g = mad(_ColorAdjustmentContrast, mad(_ColorAdjustmentSaturation, mad(tintedAlbedo.g, litTerm.g, -outLum), outLum) - 0.5, 0.5); // _891
                    adjusted.b = mad(_ColorAdjustmentContrast, mad(_ColorAdjustmentSaturation, mad(tintedAlbedo.b, litTerm.b, -outLum), outLum) - 0.5, 0.5); // _892
                    float caRimComp = 1.0 - _ColorAdjustmentRimWidth; // _924
                    float caRimT = saturate((1.0 / (1.0 - caRimComp)) * (-caRimComp + (1.0 - saturate(dot(V, N))))); // _944
                    float caRimSmooth = (caRimT * caRimT) * mad(caRimT, -2.0, 3.0); // _947
                    outColor.r = mad(caRimSmooth * _ColorAdjustmentRimColor.r, _ColorAdjustmentRimIntensity, mad(_ColorAdjustmentColorBlend.w, mad(-adjusted.r, _ColorAdjustmentBrightness, _ColorAdjustmentColorBlend.r), adjusted.r * _ColorAdjustmentBrightness)); // _963
                    outColor.g = mad(caRimSmooth * _ColorAdjustmentRimColor.g, _ColorAdjustmentRimIntensity, mad(_ColorAdjustmentColorBlend.w, mad(-adjusted.g, _ColorAdjustmentBrightness, _ColorAdjustmentColorBlend.g), adjusted.g * _ColorAdjustmentBrightness)); // _964
                    outColor.b = mad(caRimSmooth * _ColorAdjustmentRimColor.b, _ColorAdjustmentRimIntensity, mad(_ColorAdjustmentColorBlend.w, mad(-adjusted.b, _ColorAdjustmentBrightness, _ColorAdjustmentColorBlend.b), adjusted.b * _ColorAdjustmentBrightness)); // _965
                }

                return outColor / _ExposureParams.x; // b133:455-457
            }
        ENDHLSL

        // ================================================================
        // Pass 1: ForwardLit  (source LIGHTMODE "ForwardCharacterOnly" -> URP UniversalForwardOnly)
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
                #pragma shader_feature _NORMALMAP
                #pragma shader_feature _EMISSION
                #pragma shader_feature _METALLICSPECGLOSSMAP
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
                    float faceSign = isFrontFace ? 1.0 : (_BackFaceNormalFlip * 2.0 - 1.0); // b25:360
                    float4 baseSample = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, input.uv);
                    float3 albedo = baseSample.rgb * _BaseColor.rgb; // b25:340-342
                    #ifdef _ALPHATEST_ON
                        clip(baseSample.a * _BaseColor.a - _AlphaClipThreshold);
                    #endif
                    float3 color = computeNPRLighting(input.uv, input.positionWS, input.normalWS, input.tangentWS, faceSign, albedo, baseSample.a);
                    float alpha = (_SurfaceType == 1.0) ? (baseSample.a * _BaseColor.a) : 1.0; // b25:1742
                    return float4(color, alpha);
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 2: Character Outline  (source LIGHTMODE "ForwardOnly" inverted hull -> URP SRPDefaultUnlit)
        // ================================================================
        Pass {
            Name "CharacterOutline"
            Blend [_SrcBlend] OneMinusSrcAlpha
            Cull Front
            ZWrite [_ZWrite]
            ZTest Less
            Stencil {
                Ref 4
                ReadMask [_OutlineInnerClipStencilMask]
                Comp NotEqual
                Pass Keep
                Fail Keep
                ZFail Keep
            }
            Tags { "LightMode"="SRPDefaultUnlit" }
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex outlineVert
                #pragma fragment outlineFrag
                #pragma shader_feature _NORMALMAP
                #pragma shader_feature _EMISSION
                #pragma shader_feature _METALLICSPECGLOSSMAP
                #pragma shader_feature _ALPHATEST_ON
                #pragma shader_feature _OUTLINE_MASK
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

                    o.positionWS = posIn.positionWS;
                    o.normalWS = nrmIn.normalWS;
                    o.tangentWS = float4(nrmIn.tangentWS, input.tangentOS.w);
                    float2 uvTransformed = input.uv * _BaseMap_ST.xy + _BaseMap_ST.zw;
                    o.uv = uvTransformed;

                    // Smooth normal (UV2 tangent-space) or vertex normal (b132:519 _OutlineAverageNormal)
                    float3 normalWS = nrmIn.normalWS;
                    if (_OutlineAverageNormal > 0.5) {
                        float2 ts = input.smoothNrmTS;
                        float z = sqrt(max(1.0 - dot(ts, ts), 0.0));
                        float3 bitWS = cross(nrmIn.normalWS, nrmIn.tangentWS) * input.tangentOS.w;
                        normalWS = normalize(nrmIn.tangentWS * ts.x + bitWS * ts.y + nrmIn.normalWS * z);
                    }

                    float4 clipPos = posIn.positionCS;

                    // Outline mask: R = width multiplier, G = Z offset multiplier (b132 _OUTLINE_MASK variant)
                    #ifdef _OUTLINE_MASK
                        float2 maskSmp = SAMPLE_TEXTURE2D_LOD(_OutlineMask, sampler_OutlineMask, uvTransformed, 0).rg;
                        float widthMask = maskSmp.r;
                        float zOffsetVal = maskSmp.g * _OutlineOffsetZ;
                    #else
                        float widthMask = 1.0;
                        float zOffsetVal = _OutlineOffsetZ;
                    #endif

                    // Project normal to clip-space XY (b132 inverted-hull expansion)
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

                    float width = (0.3926990 / halfFov) * _OutlineWidth;
                    float distAtten = clamp(clipPos.w * halfFov * 4.5837, 0.0, 1.0);

                    float aspect = _ScreenParams.y / _ScreenParams.x;
                    float2 offset;
                    offset.x = distAtten * width * (screenNInvLen * screenN.x * aspect) * 0.005;
                    offset.y = distAtten * width * (screenNInvLen * screenN.y) * 0.005;

                    float maxExtent = min(1.5707964 / halfFov, max(clipPos.w, 0.0));
                    float2 minPixel = float2(maxExtent / _ScreenParams.x, maxExtent / _ScreenParams.y);
                    offset.x = (abs(offset.x) < minPixel.x) ? sign(offset.x) * minPixel.x : offset.x;
                    offset.y = (abs(offset.y) < minPixel.y) ? sign(offset.y) * minPixel.y : offset.y;

                    clipPos.xy += offset * widthMask;

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
                    #ifdef _ALPHATEST_ON
                        clip(baseSample.a * _BaseColor.a - _AlphaClipThreshold);
                    #endif

                    // Simple outline shading (b133 base, NOT the ForwardLit spine). Albedo = raw base map (no _BaseColor.rgb).
                    float3 color = computeOutlineLighting(input.uv, input.positionWS, input.normalWS, baseSample.rgb);
                    float alpha = (_SurfaceType == 1.0) ? saturate(baseSample.a * _BaseColor.a) : 1.0; // b133:458 (saturate, unlike ForwardLit)
                    return float4(color, alpha);
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 3: ShadowCaster  (source LIGHTMODE "SHADOWCASTER", empty frag b212)
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
                    return 0; // b212 empty frag
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 4: DepthNormalsOnly  (source PreGBuffer "DepthCharacterOnly" 5-MRT -> URP normals prepass)
        // PreGBuffer (b197) writes MRT3.xy=octahedral world normal + MRT4.rgb=albedo; URP needs world normal.
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

                float4 depthNormalsFrag(DepthNormalsVaryings input, bool isFrontFace : SV_IsFrontFace) : SV_Target {
                    float faceSign = isFrontFace ? 1.0 : (_BackFaceNormalFlip * 2.0 - 1.0); // b197:186 (_215)
                    #ifdef _NORMALMAP
                        // _NORMALMAP variant adds TBN map (same TBN as ForwardLit; base b197 has no map path)
                        float4 nrmSmp = SAMPLE_TEXTURE2D(_BumpMap, sampler_BumpMap, input.uv);
                        float nrmXraw = nrmSmp.x * nrmSmp.w * 2.0 - 1.0;
                        float nrmYraw = nrmSmp.y * 2.0 - 1.0;
                        float nrmZ = max(sqrt(1.0 - min(nrmXraw*nrmXraw + nrmYraw*nrmYraw, 1.0)), 1e-16); // Z from UNSCALED X,Y (pre-_BumpScale)
                        float nrmX = nrmXraw * _BumpScale;
                        float nrmY = nrmYraw * _BumpScale;
                        float3 nrmWS = normalize(input.normalWS);
                        float3 tanWS = normalize(input.tangentWS.xyz);
                        float3 bitWS = cross(nrmWS, tanWS) * input.tangentWS.w;
                        float3 normalWS = faceSign * normalize(nrmZ * nrmWS + nrmX * tanWS + nrmY * bitWS);
                    #else
                        float3 normalWS = faceSign * normalize(input.normalWS); // b197:185-193 (_215 * normalize(TEXCOORD_2))
                    #endif
                    return float4(normalWS, 0.0);
                }
            ENDHLSL
        }
    }
}
