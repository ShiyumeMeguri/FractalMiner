// HGRP CharacterNPR VFX — Unified Fix shader
// Covers all 4 blob variants via shader_feature:
//   bc442885 (_NORMAL_MAP + _USE_BLEND + _USE_DISTURB + _USE_FRESNEL + _USE_MASK) — wulfa
//   9aca3fcf (_USE_BLEND + _USE_DISTURB + _USE_MASK) — yvonne, lastrite
//   d4968533 (_USE_BLEND + _USE_DISTURB) — ardelia, tangtang
//   39f9e1d6 (_USE_BLEND) — tangtang
//
// Sandbox simplifications:
//   - GPU Skinning removed (static mesh)
//   - Motion Vectors / SV_Target1 removed
//   - LOD Crossfade / Dither removed
//   - TAA Jitter removed
//   - _VFXParams0.w replaced with _Time.y

Shader "HGRP/CharacterNPR_VFX_Fix" {
    Properties {
        [Header(Base)]
        [Enum(Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        [ToggleUI] _DisableVertColor ("Disable VertColor", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 1
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        [HideInInspector] _ProcedureAlpha ("Procedure Alpha", Float) = 1
        _VertCameraOffset ("Vertex Camera Offset (m)", Float) = 0
        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity", Range(1, 100)) = 1
        _ExpThreshold ("Exp Threshold", Range(0, 1)) = 1
        _ExpIntensity ("Exp Intensity", Range(0, 100)) = 0
        _TintColorAlpha ("Tint Color Alpha", Range(0, 10)) = 1
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0
        [ToggleUI] _EnableTransparentMV ("Enable Transparent MV", Float) = 0

        [Header(Main Tex)]
        _MainTex ("Main Tex", 2D) = "white" {}
        _MainTexUseDisturb ("Main Tex Use Disturb", Range(0, 1)) = 1
        [ToggleUI] _MainTexUseFlowmap ("Main Tex Use Flowmap", Float) = 0
        [ToggleUI] _UseMainTexAsAlpha ("UseMainTexAsAlpha", Float) = 1
        _MainTexUVSpeed ("MainTexUVSpeed(XY:Time,ZW:Custom1.X)", Vector) = (0, 0, 0, 0)
        _MainTexUVRotate ("MainTexUVRotate(Degree)", Float) = 0
        [HideInInspector] _MainTexUVRotateMat ("MainTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MainUVSet ("Main UV Set", Float) = 0
        [HideInInspector] _MainTexUVWeights ("_MainTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        _MaskTexUseDisturb ("Mask Tex Use Disturb", Range(0, 1)) = 0
        [ToggleUI] _UseMaskTexAsAlpha ("UseMaskTexAsAlpha", Float) = 1
        _MaskTexUVSpeed ("MaskTexUVSpeed(XY:Time,ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _MaskTexUVRotate ("MaskTexUVRotate(Degree)", Float) = 0
        [HideInInspector] _MaskTexUVRotateMat ("MaskTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MaskUVSet ("Mask UV Set", Float) = 0
        [HideInInspector] _MaskTexUVWeights ("_MaskTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Blend)]
        [Toggle(_USE_BLEND)] _UseBlend ("Use Blend", Float) = 0
        _BlendTex ("Blend Tex", 2D) = "black" {}
        [ToggleUI] _BlendTexMipmapBias ("BlendTexMipmapBias", Float) = 0
        _BlendTexUseDisturb ("Blend Tex Use Disturb", Range(0, 1)) = 0
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _BlendUVSet ("Blend UV Set", Float) = 0
        [HideInInspector] _BlendTexUVWeights ("_BlendTexUVWeights", Vector) = (1, 0, 0, 0)
        [HDR] [Gamma] _BlendTint ("BlendTint", Color) = (1, 1, 1, 1)
        _BlendTexUVSpeed ("BlendTexUVSpeed(XY:Time,ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _BlendTexUVRotate ("BlendTexUVRotate(Degree)", Float) = 0
        [HideInInspector] _BlendTexUVRotateMat ("BlendTexUVRotateMat", Vector) = (1, 0, 0, 1)

        [Header(Disturb)]
        [Toggle(_USE_DISTURB)] _UseDisturb ("Use Disturb", Float) = 0
        _DisturbTex1 ("Disturb Tex 1", 2D) = "white" {}
        _DisturbUVSpeed1 ("DisturbUVSpeed(XY:Time,ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _DisturbUVRotate1 ("DisturbUVRotate(Degree)", Float) = 0
        [HideInInspector] _DisturbUVRotateMat1 ("DisturbUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _DisturbUVSet1 ("DisturbTex UV Set", Float) = 0
        [HideInInspector] _DisturbUVWeights1 ("_DisturbTexUVWeights", Vector) = (1, 0, 0, 0)
        [ToggleUI] _Bi_Disturb ("Disturb in 2 Direction", Float) = 0
        [ToggleUI] _DisturbTex1Normal ("Disturb Tex1 is Normal", Float) = 0
        _DisturbUIntensity1 ("UIntensity1", Float) = 0
        _DisturbVIntensity1 ("VIntensity1 (Unused In Normal)", Float) = 0

        [Header(Normal Map)]
        [Toggle(_NORMAL_MAP)] _EnableNormalMap ("Normal Map", Float) = 0
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 3)) = 1
        _NormalMapUVSpeed ("NormalMapUVSpeed(XY:Time,ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _NormalMapUVRotate ("NormalMapUVRotate", Float) = 0
        [HideInInspector] _NormalMapUVRotateMat ("NormalMapUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _NormalMapUVSet ("NormalMap UV Set", Float) = 0
        [HideInInspector] _NormalMapUVWeights ("_NormalMapUVWeights", Vector) = (1, 0, 0, 0)
        _NormalMapUseDisturb ("NormalMap Use Disturb", Float) = 1

        [Header(Fresnel)]
        [Toggle(_USE_FRESNEL)] _UseFresnel ("Use Fresnel", Float) = 0
        [HDR] [Gamma] _FresnelColor ("Fresnel Color", Color) = (1, 1, 1, 1)
        _FresnelBias ("Fresnel Bias", Range(-1, 2)) = 0
        _FresnelAffectOpacity ("Fresnel Affect Opacity", Range(0, 1)) = 1
        _FresnelPower ("Fresnel Power", Range(1, 10)) = 1
        [ToggleUI] _FresnelFlip ("Fresnel Flip", Float) = 0.001

        [Header(Near Camera Fade)]
        _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Start 1", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Fade End 1", Range(0.001, 3000)) = 10
        _NearCameraFadeDistanceEnd2 ("Fade End 2", Range(0.002, 3000)) = 100
        _NearCameraFadeDistanceStart2 ("Fade Start 2", Range(0.001, 3000)) = 120

        [Header(Exposure)]
        _ExposureParams ("ExposureParams", Vector) = (1, 0, 0, 0)

        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 0
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
    }
    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Base
                float _SurfaceType;
                float _BlendMode;
                float _Responsive;
                float _EnableTransparentMV;
                float _InParticle;
                float _DisableVertColor;
                float _TintColorIntensity;
                float _TintColorAlpha;
                float _IgnorePostExposure;
                float _VertCameraOffset;
                float _ProcedureAlpha;
                float _ExpThreshold;
                float _ExpIntensity;
                float4 _TintColor;
                // MainTex
                float _UseMainTexAsAlpha;
                float _MainTexUseDisturb;
                float _MainTexUseFlowmap;
                float4 _MainTexUVSpeed;
                float4 _MainTexUVRotateMat;
                float4 _MainTexUVWeights;
                float4 _MainTex_ST;
                // Mask
                float _UseMaskTexAsAlpha;
                float _MaskTexUseDisturb;
                float4 _MaskTex_ST;
                float4 _MaskTexUVSpeed;
                float4 _MaskTexUVRotateMat;
                float4 _MaskTexUVWeights;
                // Blend
                float _BlendTexUseDisturb;
                float _BlendTexMipmapBias;
                float4 _BlendTex_ST;
                float4 _BlendTexUVSpeed;
                float4 _BlendTexUVRotateMat;
                float4 _BlendTexUVWeights;
                float4 _BlendTint;
                // Disturb
                float _Bi_Disturb;
                float _DisturbTex1Normal;
                float _DisturbUIntensity1;
                float _DisturbVIntensity1;
                float4 _DisturbTex1_ST;
                float4 _DisturbUVSpeed1;
                float4 _DisturbUVRotateMat1;
                float4 _DisturbUVWeights1;
                // Normal Map
                float _NormalScale;
                float _NormalMapUseDisturb;
                float4 _NormalMap_ST;
                float4 _NormalMapUVSpeed;
                float4 _NormalMapUVRotateMat;
                float4 _NormalMapUVWeights;
                // Fresnel
                float4 _FresnelColor;
                float _FresnelBias;
                float _FresnelAffectOpacity;
                float _FresnelPower;
                float _FresnelFlip;
                // Near Camera Fade
                float _UseNearCameraFade;
                float _NearCameraFadeDistanceStart;
                float _NearCameraFadeDistanceEnd;
                float _NearCameraFadeDistanceEnd2;
                float _NearCameraFadeDistanceStart2;
                // Exposure
                float4 _ExposureParams;
                // Render state
                float _TransparentSortPriority;
            CBUFFER_END

            TEXTURE2D(_MainTex);        SAMPLER(sampler_MainTex);
            TEXTURE2D(_MaskTex);        SAMPLER(sampler_MaskTex);
            TEXTURE2D(_BlendTex);       SAMPLER(sampler_BlendTex);
            TEXTURE2D(_DisturbTex1);    SAMPLER(sampler_DisturbTex1);
            TEXTURE2D(_NormalMap);       SAMPLER(sampler_NormalMap);

            // UV computation shared by all VFX textures (blob lines 865, 870, 877, 884, 886)
            // Pattern: UV channel select → time scroll + custom data scroll → rotation → ST → disturb
            float2 computeVFXUV(float2 uv0, float2 uv1, float4 weights, float4 speed,
                                float time, float customData, float4 rotateMat, float4 st,
                                float2 disturb, float useDisturb)
            {
                float2 uv = uv0 * weights.x + uv1 * weights.y;
                uv += speed.xy * time + speed.zw * customData;
                float2 c = uv - 0.5;
                uv.x = c.x * rotateMat.x + c.y * rotateMat.z + 0.5;
                uv.y = c.x * rotateMat.y + c.y * rotateMat.w + 0.5;
                uv = uv * st.xy + st.zw;
                uv += disturb * useDisturb;
                return uv;
            }
        ENDHLSL

        Pass {
            Name "ForwardLit"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature _NORMAL_MAP
            #pragma shader_feature _USE_BLEND
            #pragma shader_feature _USE_DISTURB
            #pragma shader_feature _USE_FRESNEL
            #pragma shader_feature _USE_MASK

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0; // UV0 in .xy, may have UV1 in .zw
                float4 texcoord1  : TEXCOORD1; // particle custom data / UV1
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float4 uv0uv1    : TEXCOORD0; // pass-through texcoord0
                float4 customData : TEXCOORD1; // pass-through texcoord1
                float3 normalWS   : TEXCOORD2;
                float4 tangentWS  : TEXCOORD3; // .w = tangent sign
                float4 vertColor  : TEXCOORD4;
                float3 positionWS : TEXCOORD5;
            };

            Varyings vert(Attributes v)
            {
                Varyings o;

                // World position + camera offset (blob lines 727-741)
                float3 posWS = TransformObjectToWorld(v.positionOS);
                float3 camDir = normalize(_WorldSpaceCameraPos - posWS);
                posWS += camDir * _VertCameraOffset;

                o.positionCS = TransformWorldToHClip(posWS);
                o.positionWS = posWS;

                // Normal + tangent to world (blob lines 742-778)
                o.normalWS = TransformObjectToWorldNormal(v.normalOS);
                o.tangentWS.xyz = TransformObjectToWorldDir(v.tangentOS.xyz);
                o.tangentWS.w = v.tangentOS.w * GetOddNegativeScale();

                o.uv0uv1 = v.texcoord0;
                o.customData = v.texcoord1;
                o.vertColor = v.color;
                return o;
            }

            half4 frag(Varyings input, bool facing : SV_IsFrontFace) : SV_Target
            {
                float time = _Time.y; // replaces _VFXParams0.w

                // Particle-aware UV setup (blob lines 861-864)
                // MainTex speed.zw uses custom1X; all others use custom1Y
                float custom1X = input.customData.x * _InParticle;
                float custom1Y = input.customData.y * _InParticle;
                float2 uv0 = input.uv0uv1.xy;
                // When _InParticle=1: uv1 = texcoord0.zw; When _InParticle=0: uv1 = texcoord1.xy
                float2 uv1 = float2(
                    mad(input.uv0uv1.z, _InParticle, -custom1X) + input.customData.x,
                    mad(input.uv0uv1.w, _InParticle, -custom1Y) + input.customData.y
                );

                // ==== DISTURB (blob lines 865-869) ====
                float2 disturb = float2(0, 0);
                #ifdef _USE_DISTURB
                    float2 disturbUV = computeVFXUV(uv0, uv1, _DisturbUVWeights1, _DisturbUVSpeed1,
                                                     time, custom1Y, _DisturbUVRotateMat1,
                                                     _DisturbTex1_ST, float2(0, 0), 0);
                    float4 disturbSample = SAMPLE_TEXTURE2D(_DisturbTex1, sampler_DisturbTex1, disturbUV);
                    // Bi-directional remap: [0,1]→[-1,1] when _Bi_Disturb=1 (blob line 866)
                    float biDisturb = mad(disturbSample.x, 1.0 + _Bi_Disturb, -_Bi_Disturb);
                    // Normal-map mode vs standard mode (blob lines 867-869)
                    bool isNormalMode = (0.0 != _DisturbTex1Normal);
                    disturb.x = isNormalMode
                        ? mad(biDisturb * disturbSample.w, 2.0, -1.0) * _DisturbUIntensity1
                        : biDisturb * _DisturbUIntensity1;
                    disturb.y = isNormalMode
                        ? mad(disturbSample.y, 2.0, -1.0) * _DisturbUIntensity1
                        : biDisturb * _DisturbVIntensity1;
                #endif

                // ==== MAIN TEX (blob line 870) ====
                float2 mainUV = computeVFXUV(uv0, uv1, _MainTexUVWeights, _MainTexUVSpeed,
                                              time, custom1X, _MainTexUVRotateMat,
                                              _MainTex_ST, disturb, _MainTexUseDisturb);
                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, mainUV);

                // Alpha source: R or A channel (blob line 876)
                float mainAlpha = lerp(mainSample.a, mainSample.r, _UseMainTexAsAlpha);
                // Base alpha (blob line 876)
                float baseAlpha = lerp(input.vertColor.a, 1.0, _DisableVertColor)
                                * _TintColor.a * _TintColorAlpha * mainAlpha;

                // ==== MASK (blob lines 877-883) ====
                float maskAlpha = 1.0;
                float3 maskColorFactor = float3(1, 1, 1);
                #ifdef _USE_MASK
                    float2 maskUV = computeVFXUV(uv0, uv1, _MaskTexUVWeights, _MaskTexUVSpeed,
                                                  time, custom1Y, _MaskTexUVRotateMat,
                                                  _MaskTex_ST, disturb, _MaskTexUseDisturb);
                    float4 maskSample = SAMPLE_TEXTURE2D(_MaskTex, sampler_MaskTex, maskUV);
                    // Channel select: R for alpha when flag=1, A for alpha when flag=0
                    maskAlpha = lerp(maskSample.a, maskSample.r, _UseMaskTexAsAlpha);
                    // Color: when R→alpha, color factor = 1 (no modulation); otherwise use RGB
                    maskColorFactor = lerp(maskSample.rgb, float3(1, 1, 1), _UseMaskTexAsAlpha);
                #endif

                // ==== BASE COLOR (blob lines 888-890 base terms) ====
                float3 vcAdj = lerp(input.vertColor.rgb, float3(1, 1, 1), _DisableVertColor);
                // When R→alpha, mainColorFactor=1 (color from tint only); otherwise use mainTex RGB
                float3 mainColorFactor = lerp(mainSample.rgb, float3(1, 1, 1), _UseMainTexAsAlpha);
                float3 color = vcAdj * _TintColor.rgb * _TintColorIntensity * mainColorFactor * maskColorFactor;

                // ==== BLEND (blob lines 886-890 blend terms) ====
                float combinedAlpha = baseAlpha * maskAlpha;
                #ifdef _USE_BLEND
                    float2 blendUV = computeVFXUV(uv0, uv1, _BlendTexUVWeights, _BlendTexUVSpeed,
                                                   time, custom1Y, _BlendTexUVRotateMat,
                                                   _BlendTex_ST, disturb, _BlendTexUseDisturb);
                    float4 blendSample = SAMPLE_TEXTURE2D(_BlendTex, sampler_BlendTex, blendUV);
                    // Blend factor (blob line 887): blend alpha from combined base+mask + blend tex alpha
                    float blendFactor = saturate((combinedAlpha + blendSample.a)
                                                 * input.vertColor.a * _BlendTint.a);
                    // Additive blend — uses raw vertColor (not DisableVertColor-adjusted) (blob lines 888-890)
                    color += blendFactor * blendSample.rgb * input.vertColor.rgb * _BlendTint.rgb;
                #endif

                // ==== NORMAL MAP (blob lines 891-903) ====
                float3 faceNormal = normalize(input.normalWS);
                #ifdef _NORMAL_MAP
                    float2 normalUV = computeVFXUV(uv0, uv1, _NormalMapUVWeights, _NormalMapUVSpeed,
                                                    time, custom1Y, _NormalMapUVRotateMat,
                                                    _NormalMap_ST, disturb, _NormalMapUseDisturb);
                    float4 nSample = SAMPLE_TEXTURE2D(_NormalMap, sampler_NormalMap, normalUV);
                    // DXT5nm unpack (blob lines 891-892)
                    float3 normalTS;
                    normalTS.x = nSample.r * nSample.a * 2.0 - 1.0;
                    normalTS.y = nSample.g * 2.0 - 1.0;
                    normalTS.z = max(sqrt(1.0 - min(dot(normalTS.xy, normalTS.xy), 1.0)), 1e-16);
                    normalTS.xy *= _NormalScale;
                    normalTS = normalize(normalTS);
                    // TBN transform (blob lines 900-903)
                    float3 T = normalize(input.tangentWS.xyz);
                    float3 N = faceNormal;
                    float bSign = (input.tangentWS.w > 0.0) ? 1.0 : -1.0;
                    float3 B = bSign * cross(N, T);
                    faceNormal = normalize(normalTS.x * T + normalTS.y * B + normalTS.z * N);
                #endif
                // Flip for back-facing (blob line 904)
                faceNormal = facing ? faceNormal : -faceNormal;

                // ==== FRESNEL (blob lines 905-923) ====
                float fresnelTerm = 1.0;
                #ifdef _USE_FRESNEL
                    // View direction (blob lines 911-914)
                    float3 viewDir = normalize(_WorldSpaceCameraPos - input.positionWS);
                    // NdotV + bias → pow → flip (blob lines 916-918)
                    float NdotV = dot(viewDir, faceNormal) + _FresnelBias;
                    float fresnel = pow(saturate(NdotV), _FresnelPower);
                    float invFresnel = 1.0 - fresnel;
                    fresnelTerm = mad(_FresnelFlip, fresnel - invFresnel, invFresnel);
                    // Color blend (blob lines 921-923)
                    float fresnelBlend = fresnelTerm * _FresnelColor.a;
                    color = lerp(color, _FresnelColor.rgb, fresnelBlend);
                #endif

                // ==== EXPOSURE (blob line 949, 921-923) ====
                float exposureScale = mad(_ExposureParams.x, _IgnorePostExposure, 1.0 - _IgnorePostExposure);
                color = clamp(color / exposureScale, 0.0, 1000.0);

                // ==== NEAR CAMERA FADE (blob lines 924, 1064) ====
                float nearFade = 1.0;
                if (_UseNearCameraFade != 0.0) {
                    float dist = abs(dot(UNITY_MATRIX_V[2].xyz, input.positionWS) + UNITY_MATRIX_V[2].w);
                    nearFade = saturate((dist - _NearCameraFadeDistanceStart2)
                                        / (_NearCameraFadeDistanceEnd2 - _NearCameraFadeDistanceStart2))
                             * saturate((dist - _NearCameraFadeDistanceStart)
                                        / (_NearCameraFadeDistanceEnd - _NearCameraFadeDistanceStart));
                }

                // ==== FINAL ALPHA (blob line 1064) ====
                float fresnelOpacity = lerp(1.0, fresnelTerm, _FresnelAffectOpacity);
                float finalAlpha = saturate(saturate(combinedAlpha) * fresnelOpacity * nearFade);

                // ==== OUTPUT — premultiplied alpha (blob lines 928-931) ====
                // Additive (_BlendMode=1): a=0; Alpha blend (_BlendMode=0): a=finalAlpha
                return half4(finalAlpha * color, (1.0 - _BlendMode) * finalAlpha);
            }

            ENDHLSL
        }
    }
}
