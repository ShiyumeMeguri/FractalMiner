// Merged HGRP CharacterNPR Eye shader -- ForwardLit only.
// Combines eyebrow (978107fe) and iris (c2f593bc) variants via #ifdef.
//
// Eyebrow keywords: _DIFF_RAMP_ON
// Iris keywords:    _DIFF_RAMP_ON, _MATCAP_ON, _EYE_HIGHLIGHT
//
// _MATCAP_ON gates the full iris pipeline: parallax mapping, iris circle mask,
//   matcapN_world (UV-derived pseudo-spherical normal for lighting), matcap sampling,
//   eye blend factor, CP13 eye direct term, alpha premultiply.
// When _MATCAP_ON is off: vertex normal N is used for all lighting, no parallax,
//   no iris mask, no matcap, no eye blend — pure eyebrow behavior.
//
// Shared: Object-space light XZ projection, FBXRotationFix, Diffuse Ramp (2 samples),
//   Shadow Color (brightness + saturation), Subsurface Specular, Metallic workflow,
//   CP2 ambient, CP5 light color override.

Shader "HGRP/CharacterNPR_Eye_Fix" {
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
        _ShadowColorBrightness ("Shadow Color Brightness", Range(0, 1)) = 0.55
        _ShadowColorSaturation ("Shadow Color Saturation", Range(0, 2)) = 1.0
        [Gamma] _Metallic ("Metallic", Range(0, 1)) = 0
        [Toggle(_DIFF_RAMP_ON)] _UseDiffRampMap ("Diffuse Ramp", Float) = 0
        _DiffRampMap ("Diffuse Ramp", 2D) = "white" {}
        [HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}

        [Header(Iris Features)]
        _AlphaPremultiply ("Alpha Premultiply", Float) = 0
        [Toggle(_MATCAP_ON)] _UseMatcap ("Use Matcap", Float) = 0
        _MatcapTex ("Matcap", 2D) = "white" {}
        _MatcapNormalScale ("Matcap Normal Scale", Range(0, 1.5)) = 1.0
        [HDR] _MatcapColor ("Matcap Color", Color) = (1, 1, 1, 1)
        _ParallaxScale ("Parallax Scale", Range(0, 0.15)) = 0.03
        [Toggle(_EYE_HIGHLIGHT)] _EyeHighLight ("Eye Highlight", Float) = 0
        [HDR] _EyeHighLightColor ("Highlight Color", Color) = (2, 2, 2, 1)
        [HDR] _EyeScatteringColor ("Scattering Color", Color) = (1, 1, 1, 1)

        [Header(Character Params)]
        _CharacterParams0 ("CP0 (.y=diffuse .z=shadowScale .w=brightness)", Vector) = (0, 1, 0.7, 1)
        _CharacterParams1 ("CP1 (.x=brightMix .y=shadowStr .z=shadowLerp .w=lightDirOverride)", Vector) = (0, 0, 0, 0)
        _CharacterParams2 ("CP2 (ambient color rgb)", Vector) = (1, 1, 1, 0)
        _CharacterParams5 ("CP5 (light color override rgb)", Vector) = (1, 1, 1, 1)
        _CharacterParams6 ("CP6 (ambient direction)", Vector) = (0, 1, 0, 0)
        _CharacterParams7 ("CP7 (.x=offset .y=scale .z=bias)", Vector) = (0.15, 0.6, 1, 0)
        _CharacterParams11 ("CP11 (light dir override xyz + .w=rampBias)", Vector) = (-0.433, 0.5, 0.75, 0)
        _CharacterParams12 ("CP12 (.x=rampOffset .y=lightColOverride .z=shadowGate .w=exposureBlend)", Vector) = (0, 0, 0, 0)
        _CharacterParams13 ("CP13 (.x=eyeColor .y=highlight .z=scatter .w=ggxSpec)", Vector) = (0, 0, 0, 1)
        _EnvironmentGlobalParams0 ("EnvGlobalParams0", Vector) = (1.67, 1.5, 1, 0)
        _ExposureParams ("ExposureParams", Vector) = (1, 0, 0, 0)

        [Header(Workarounds)]
        [Toggle] _FBXRotationFix ("FBX -90 Z Rotation Fix (OTW col0/col1 swap)", Float) = 0

        [Header(Behind Hair Composite)]
        [HideInInspector] _FaceForward ("Face Forward (World)", Vector) = (0, 0, 1, 0)
        [ToggleUI] _DrawBehindHair ("Draw Behind Hair", Float) = 0
        _DrawBehindHairAlpha ("Behind Hair Alpha", Range(0, 1)) = 0.3
    }
    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Opaque" }
        LOD 600

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float _Metallic;
                float _BackFaceNormalFlip;
                float _FBXRotationFix;
                float _AlphaPremultiply;
                float _ShadowColorBrightness;
                float _ShadowColorSaturation;
                float _MatcapNormalScale;
                float _ParallaxScale;
                float4 _BaseMap_ST;
                float4 _BaseColor;
                float4 _MatcapColor;
                float4 _EyeHighLightColor;
                float4 _EyeScatteringColor;
                float4 _CharacterParams0;
                float4 _CharacterParams1;
                float4 _CharacterParams2;
                float4 _CharacterParams5;
                float4 _CharacterParams6;
                float4 _CharacterParams7;
                float4 _CharacterParams11;
                float4 _CharacterParams12;
                float4 _CharacterParams13;
                float4 _EnvironmentGlobalParams0;
                float4 _ExposureParams;
                float4 _FaceForward;
                float  _DrawBehindHair;
                float  _DrawBehindHairAlpha;
            CBUFFER_END

            TEXTURE2D(_BaseMap);       SAMPLER(sampler_BaseMap);
            TEXTURE2D(_DiffRampMap);   SAMPLER(sampler_DiffRampMap);
            TEXTURE2D(_MatcapTex);     SAMPLER(sampler_MatcapTex);
            TEXTURE2D(_ShadowLutTex);  SAMPLER(sampler_ShadowLutTex);

            static const float3 LUM = float3(0.2126729, 0.7152, 0.07217500);
            static const float NEAR_ZERO_Y = 6.103515625e-05; // asfloat(947912704u)

            float LinearToSRGB_Custom(float c) {
                return (c <= 0.0031308) ? (c * 12.92)
                    : (1.055 * pow(abs(c), 0.41666666) - 0.055);
            }

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
                float4 tangentWS  : TEXCOORD3; // xyz = tangent, w = sign
            };

            Varyings EyeVert(Attributes input) {
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

            float4 EyeFrag(Varyings input, bool isFrontFace) {
                    // ---- View direction (ortho-aware) ----
                    float3 toCam = _WorldSpaceCameraPos - input.positionWS;
                    float3 orthoFwd = float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22);
                    float3 V = normalize(toCam + unity_OrthoParams.w * (orthoFwd - toCam));

                    // ---- Normal ----
                    float3 rawN = input.normalWS;
                    float  nInvLen = rsqrt(dot(rawN, rawN));
                    float  faceSign = isFrontFace ? 1.0 : (_BackFaceNormalFlip * 2.0 - 1.0);
                    float3 N = faceSign * (nInvLen * rawN);

                    // ---- Iris pipeline: TBN, parallax, iris mask, matcap normal ----
                    #ifdef _MATCAP_ON
                        float3 T = input.tangentWS.xyz;
                        float  tSign = input.tangentWS.w;
                        float3 B = cross(rawN, T) * tSign;

                        // Iris circle mask: 1=outside(sclera), 0=inside(iris)
                        float2 fracUV = frac(input.uv);
                        float2 uvFromCenter = fracUV - 0.5;
                        float distSq = dot(uvFromCenter, uvFromCenter);
                        float irisMask = (distSq >= 0.25) ? 1.0 : 0.0;

                        // Parallax mapping (tangent-space view offset)
                        float Tv = dot(nInvLen * T, V);
                        float Bv = dot(nInvLen * (tSign * cross(rawN, T)), V);
                        float Nv = dot(nInvLen * rawN, V);
                        float tbvLen = rsqrt(Tv * Tv + Bv * Bv + Nv * Nv);
                        float parallaxRaw = saturate((distSq - 0.25) * (-5.0));
                        float parallaxSmooth = parallaxRaw * parallaxRaw * (3.0 - 2.0 * parallaxRaw);
                        float2 sampleUV = float2(
                            input.uv.x - (tbvLen * Tv * _ParallaxScale) * parallaxSmooth,
                            input.uv.y - (tbvLen * Bv * _ParallaxScale * 0.25) * parallaxSmooth
                        );

                        // Matcap normal: UV-derived pseudo-spherical, iris-masked for lighting
                        float matNx = fracUV.x * 2.0 - 1.0;
                        float matNy = fracUV.y * 2.0 - 1.0;
                        float matNz = max(sqrt(saturate(1.0 - dot(float2(matNx, matNy), float2(matNx, matNy)))), 1e-16);
                        float scaledNx = matNx * (-_MatcapNormalScale);
                        float scaledNy = matNy * (-_MatcapNormalScale);
                        float maskFactor = 0.125 * (irisMask - 1.0); // -0.125 inside, 0 outside
                        float3 lightN = normalize(T * (scaledNx * maskFactor)
                                                + B * (scaledNy * maskFactor)
                                                + rawN * lerp(matNz, 1.0, irisMask));
                        float3 flatLightN = normalize(float3(lightN.x, NEAR_ZERO_Y, lightN.z));
                    #else
                        float2 sampleUV = input.uv;
                        float3 lightN = N;
                        float3 flatLightN = normalize(float3(N.x, NEAR_ZERO_Y, N.z));
                    #endif

                    // ---- Base color ----
                    float4 baseSample = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, sampleUV);
                    float3 albedo = baseSample.rgb * _BaseColor.rgb;
                    float  baseAlpha = baseSample.a * _BaseColor.a;

                    // ---- Exposure ----
                    float exposure = (_CharacterParams12.w * (1.0 - _EnvironmentGlobalParams0.x)
                                     + _EnvironmentGlobalParams0.x) * _ExposureParams.x;

                    // ---- Ambient (CP2 fallback) ----
                    float3 ambCol = _CharacterParams2.xyz;

                    // ---- Camera forward ----
                    float3 camFwd = float3(UNITY_MATRIX_I_V._m02, UNITY_MATRIX_I_V._m12, UNITY_MATRIX_I_V._m22);

                    // ---- Metallic workflow ----
                    float oneMinusRefl = (1.0 - _Metallic) * 0.96;
                    float3 diffColor = oneMinusRefl * albedo;

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
                        shadowColor = oneMinusRefl * lerp(lut0.rgb, lut1.rgb, bFrac);
                    #else
                        float3 albBright = albedo * _ShadowColorBrightness;
                        float shadBright = dot(albBright, LUM);
                        shadowColor = oneMinusRefl * (shadBright + _ShadowColorSaturation * (albBright - shadBright));
                    #endif

                    // ---- Main light from URP ----
                    Light mainLight = GetMainLight();
                    float3 mainLightDir = mainLight.direction;

                    // ---- Adjusted light direction ----
                    float3 adjustedLightDir = lerp(mainLightDir, _CharacterParams11.xyz, _CharacterParams1.w);
                    float adjXZLen = rsqrt(adjustedLightDir.x * adjustedLightDir.x
                                         + adjustedLightDir.z * adjustedLightDir.z
                                         + NEAR_ZERO_Y * NEAR_ZERO_Y);
                    float adjXZ_x = adjXZLen * adjustedLightDir.x;
                    float adjXZ_z = adjXZLen * adjustedLightDir.z;

                    // ---- Light color blend (CP5) ----
                    float3 blendedLightCol = lerp(mainLight.color, _CharacterParams5.xyz, _CharacterParams12.y);
                    float lightLum = dot(blendedLightCol, LUM);

                    // ---- Object-space light projection (Eye-specific) ----
                    float3 _otwC0 = float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20);
                    float3 _otwC1 = float3(unity_ObjectToWorld._m01, unity_ObjectToWorld._m11, unity_ObjectToWorld._m21);
                    float3 _otwC2 = float3(unity_ObjectToWorld._m02, unity_ObjectToWorld._m12, unity_ObjectToWorld._m22);
                    if (_FBXRotationFix > 0.5) {
                        float3 tmp = _otwC0;
                        _otwC0 = _otwC1;
                        _otwC1 = -tmp;
                    }
                    float3x3 o2w3x3 = float3x3(
                        _otwC0.x, _otwC1.x, _otwC2.x,
                        _otwC0.y, _otwC1.y, _otwC2.y,
                        _otwC0.z, _otwC1.z, _otwC2.z);
                    float3 localLight = mul(adjustedLightDir, o2w3x3);
                    float localLen = rsqrt(max(dot(localLight, localLight), 1.175494e-38));
                    float3 normLocal = localLight * localLen;
                    float3 projLight = mul(o2w3x3, float3(normLocal.x, 0, normLocal.z));
                    float projLen = rsqrt(max(dot(projLight, projLight), 1.175494e-38));
                    projLight *= projLen;

                    // ---- Eye blend factor (iris: highlight + scattering, eyebrow: 1) ----
                    #ifdef _MATCAP_ON
                        float insideMask = 1.0 - irisMask;
                        #ifdef _EYE_HIGHLIGHT
                            float3 highlightTerm = _EyeHighLightColor.rgb * irisMask + insideMask;
                        #else
                            float3 highlightTerm = float3(insideMask, insideMask, insideMask);
                        #endif
                        float scatterBase = 1.0 - baseAlpha;
                        float3 eyeBlend = highlightTerm * (_EyeScatteringColor.rgb * baseAlpha + scatterBase);
                    #else
                        float3 eyeBlend = float3(1, 1, 1);
                    #endif

                    // ==== DIFFUSE RAMP ====
                    #ifdef _DIFF_RAMP_ON
                        float rampNdotL = dot(lightN, projLight);
                        float rampInput = clamp(_CharacterParams11.w * _CharacterParams12.x + rampNdotL, -1.0, 1.0) * 0.5 + 0.5;
                        float4 rampSmp = SAMPLE_TEXTURE2D_LOD(_DiffRampMap, sampler_DiffRampMap, float2(rampInput, 0.5), 0);
                        float3 rampCol = rampSmp.rgb;
                        float rampA = rampSmp.a;

                        float viewRampInput = dot(lightN, camFwd) * 0.5 + 0.5;
                        float4 viewRampSmp = SAMPLE_TEXTURE2D_LOD(_DiffRampMap, sampler_DiffRampMap, float2(viewRampInput, 0.5), 0);
                        float viewRampA = viewRampSmp.a;
                    #else
                        float3 rampCol = float3(1, 1, 1);
                        float rampA = 1;
                        float viewRampA = 0;
                    #endif

                    float rampChroma = max(rampCol.r, max(rampCol.g, rampCol.b))
                                     - min(rampCol.r, min(rampCol.g, rampCol.b));
                    float rampChromaInv = 1.0 - rampChroma;
                    float minRampA = min(rampA, 1.0);

                    // ==== NPR DIFFUSE COMPOSITION ====
                    float nprNdotL = saturate(dot(flatLightN, _CharacterParams6.xyz) + _CharacterParams7.x)
                                   * _CharacterParams7.y + _CharacterParams7.z;
                    float shadowStr = minRampA * _CharacterParams1.y;
                    float3 shadAmb = nprNdotL * (shadowStr * (1.0 - ambCol) + ambCol);

                    float brightFull = clamp(exposure, 0.0, 1.5);
                    float brightAlt = clamp(exposure, 1.25, 1.75);
                    float brightness = lerp(brightFull, brightAlt, _CharacterParams1.x);

                    float3 lightBlend = blendedLightCol * _CharacterParams12.y + (1.0 - _CharacterParams12.y);

                    float3 fullDiff = (shadAmb * brightness * lightBlend
                                      + minRampA * (blendedLightCol - lightLum) + lightLum)
                                      * _CharacterParams0.y;

                    // Shadow desaturation
                    float3 albScaled = shadowColor * _CharacterParams0.z;
                    float3 albScaled65 = albScaled * 0.65;
                    float albScaledLum = dot(albScaled65, LUM);
                    float3 desatShad = (albScaled65 - albScaledLum) * 1.2 + albScaledLum;

                    float combWeight = saturate(rampA + viewRampA);
                    float3 weightedAmb = lerp(desatShad, albScaled, combWeight);
                    float3 shadowBlended = lerp(weightedAmb, diffColor * eyeBlend, minRampA);

                    // Ramp color tinting
                    float3 rampTinted = shadowBlended * (rampCol * rampChroma + rampChromaInv);

                    float shadowLum = dot(shadowBlended, LUM);
                    float rampLum = dot(rampTinted, LUM);
                    float lumRatio = clamp(shadowLum / max(rampLum, 0.001), 0.0, 1.5);

                    float3 nprDiff = rampTinted * lumRatio;

                    // ==== MATCAP SAMPLING & BLENDING ====
                    float alphaPremult = lerp(1.0, baseAlpha, _AlphaPremultiply);

                    #ifdef _MATCAP_ON
                        float rampBlendFactor = minRampA;
                        float matcapIntensity = (rampBlendFactor * (1.0 - _CharacterParams0.z) + _CharacterParams0.z)
                                              * (rampBlendFactor * 0.5 + 0.5);

                        // Full matcap normal (no iris masking, full MatcapNormalScale)
                        float3 matcapFullN = normalize(T * scaledNx + B * scaledNy + rawN * matNz);
                        float3 viewN;
                        viewN.x = dot(float3(UNITY_MATRIX_V._m00, UNITY_MATRIX_V._m01, UNITY_MATRIX_V._m02), matcapFullN);
                        viewN.y = dot(float3(UNITY_MATRIX_V._m10, UNITY_MATRIX_V._m11, UNITY_MATRIX_V._m12), matcapFullN);
                        viewN.z = dot(float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22), matcapFullN);
                        float viewNLen = rsqrt(dot(viewN, viewN));
                        float2 matcapUV = float2(viewN.x * viewNLen * 0.5 + 0.5, viewN.y * viewNLen * 0.5 + 0.5);
                        float4 matcapSmp = SAMPLE_TEXTURE2D(_MatcapTex, sampler_MatcapTex, matcapUV);
                        float matcapA = matcapSmp.a;

                        float3 matcapContrib = (matcapSmp.rgb * _MatcapColor.a + matcapA * _MatcapColor.rgb)
                                              * (matcapIntensity * fullDiff);
                    #else
                        float3 matcapContrib = float3(0, 0, 0);
                    #endif

                    float3 mainLit = nprDiff * fullDiff * alphaPremult + matcapContrib;
                    float mainLitLum = dot(mainLit, LUM);

                    // Desaturation
                    float desatAmt = clamp(mainLitLum - 0.5, 0.0, 0.5);
                    float desatFactor = desatAmt * desatAmt + 1.0;
                    float3 term1 = desatFactor * (mainLit - mainLitLum) + mainLitLum;

                    // ==== SUBSURFACE SPECULAR ====
                    float mainNdotL_xz = dot(float3(adjXZ_x, adjXZLen * NEAR_ZERO_Y, adjXZ_z), lightN);
                    float wrapNdotL = saturate(0.5 + mainNdotL_xz - 0.5 * mainNdotL_xz * mainNdotL_xz);

                    float cfXZLen = rsqrt(UNITY_MATRIX_I_V._m02 * UNITY_MATRIX_I_V._m02
                                        + UNITY_MATRIX_I_V._m22 * UNITY_MATRIX_I_V._m22);
                    float camLightDot = -(adjXZ_x * (cfXZLen * UNITY_MATRIX_I_V._m02)
                                        + adjXZ_z * (cfXZLen * UNITY_MATRIX_I_V._m22));
                    float camLightFacing = (1.0 - _CharacterParams12.x) * saturate(camLightDot);

                    float NdotV = dot(V, lightN);
                    float edgeT = saturate((-abs(NdotV) + 0.4) * 5.0);
                    float edgeFresnel = edgeT * edgeT * (3.0 - 2.0 * edgeT);

                    float diffColorLum = dot(diffColor, LUM);
                    float brightT = saturate((0.1 - diffColorLum) * 16.666);
                    float brightnessGate = brightT * brightT * (3.0 - 2.0 * brightT);

                    float3 subsurfSpec = brightnessGate * edgeFresnel * camLightFacing * wrapNdotL
                                       * blendedLightCol * max(diffColor, 0.15);

                    // ==== CP13 EYE DIRECT TERM ====
                    #ifdef _MATCAP_ON
                        #ifdef _EYE_HIGHLIGHT
                            float3 highlightEmission = irisMask * _EyeHighLightColor.rgb;
                        #else
                            float3 highlightEmission = float3(0, 0, 0);
                        #endif
                        float3 eyeDirect = (albedo * _CharacterParams13.x
                                          + highlightEmission * _CharacterParams13.y
                                          + (baseAlpha * _EyeScatteringColor.rgb) * _CharacterParams13.z)
                                          * alphaPremult;
                    #else
                        float3 eyeDirect = float3(0, 0, 0);
                    #endif

                    // ==== FINAL ASSEMBLY ====
                    // Eye intentionally skips Custom AO — kept evenly lit, like the face,
                    // so the iris/sclera don't pick up shadowing from surrounding hair.
                    float3 finalColor = (eyeDirect + subsurfSpec + term1) / _ExposureParams.x;
                    return float4(finalColor, 1.0);
            }
        ENDHLSL

        // ================================================================
        // Pass 0: ForwardLit
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
                #pragma shader_feature _MATCAP_ON
                #pragma shader_feature _EYE_HIGHLIGHT
                #pragma shader_feature _SHADOW_LUT_TEX

                Varyings vert(Attributes input) { return EyeVert(input); }
                float4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target {
                    return EyeFrag(input, isFrontFace);
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 1: BehindHairOverdraw — render behind hair via stencil composite
        //   Endfield Eye shader covers BOTH eyebrow and iris/sclera.
        //   Eyebrow lives ON face skin (bit 6 = 1), iris is in eye socket (bit 6 = 0).
        //   ZZZ's iris-only check (ReadMask 96 Ref 32) excludes eyebrow → wrong here.
        //   We use ReadMask 32 (bit 5 only) like ZZZ Face shader, so eyebrow shows
        //   through hair on the forehead. Iris/sclera also draw, relying on the
        //   (depth-cleared) z-buffer + alpha modulation for natural occlusion.
        //   Alpha encodes view-facing strength * _DrawBehindHairAlpha.
        // ================================================================
        Pass {
            Name "BehindHairOverdraw"
            Tags { "LightMode" = "BehindHairOverdraw" }
            ZTest LEqual
            ZWrite On
            // Stencil mask is applied later in BehindHairComposite Pass 1
            // (which reads cameraDepth's stencil). Overlay depth here has no stencil.
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex vert
                #pragma fragment frag
                #pragma shader_feature _DIFF_RAMP_ON
                #pragma shader_feature _MATCAP_ON
                #pragma shader_feature _EYE_HIGHLIGHT
                #pragma shader_feature _SHADOW_LUT_TEX

                Varyings vert(Attributes input) { return EyeVert(input); }
                float4 frag(Varyings input) : SV_Target {
                    clip(_DrawBehindHair - 0.5);
                    float4 result = EyeFrag(input, true);
                    // View-facing fade: only show when face is roughly toward camera
                    float3 toCam = _WorldSpaceCameraPos - input.positionWS;
                    float3 V = normalize(toCam);
                    float forwardDot = dot(_FaceForward.xyz, V);
                    float behindAlpha = saturate(forwardDot) * _DrawBehindHairAlpha;
                    return float4(result.rgb, result.a * behindAlpha);
                }
            ENDHLSL
        }

        // ================================================================
        // Pass 2: DepthNormalsOnly (for SSAO / Deferred depth-normals prepass)
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

                struct DepthNormalsAttributes {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                };

                struct DepthNormalsVaryings {
                    float4 positionCS : SV_Position;
                    float3 normalWS   : TEXCOORD0;
                };

                DepthNormalsVaryings depthNormalsVert(DepthNormalsAttributes input) {
                    DepthNormalsVaryings o = (DepthNormalsVaryings)0;
                    VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);
                    VertexNormalInputs nrmIn = GetVertexNormalInputs(input.normalOS);
                    o.positionCS = posIn.positionCS;
                    o.normalWS   = nrmIn.normalWS;
                    return o;
                }

                float4 depthNormalsFrag(DepthNormalsVaryings input) : SV_Target {
                    return float4(normalize(input.normalWS), 0.0);
                }
            ENDHLSL
        }
    }
}
