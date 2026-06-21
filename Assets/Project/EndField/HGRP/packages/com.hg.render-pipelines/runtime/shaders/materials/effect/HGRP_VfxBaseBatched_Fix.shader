// HGRP VFXBaseBatched — unified transparent particle/VFX surface, single ForwardOnly pass.
// Merged from: vfxbasebatched.shader (HGRP/Effect/VFXBaseBatched), per-stage catch-all + feature blobs:
//   Vertex:   Sub0_Pass0_Vertex_b34 (base) / _b38 (_USE_MASK) / _b40 (_USE_BLEND) /
//             _b42 (_USE_DISTURB) / _b46 (_USE_DISSOLVE) / _b62 (_USE_FRESNEL)
//   Fragment: Sub0_Pass0_Fragment_b35 (base) / _b37 (_USE_BRIGHT) / _b39 (_USE_MASK) /
//             _b41 (_USE_BLEND) / _b43 (_USE_DISTURB) / _b47 (_USE_DISSOLVE) /
//             _b55 (_USE_SOFTBLEND) / _b63 (_USE_FRESNEL)
// Keywords: _USE_BRIGHT, _USE_MASK, _USE_BLEND, _USE_DISTURB, _USE_DISSOLVE, _USE_SOFTBLEND, _USE_FRESNEL
// Kept (math 1:1): UseMainTexAsAlpha rgb<->alpha lerp; vertColor*_TintColor*_TintColorIntensity/postExposure;
//   ExpThreshold/ExpIntensity glow boost; Rec709-luma desaturate by _VFXParams1 (.xyz mul, .w lerp-to-grey);
//   2-band near-camera fade; per-tex speed(time+custom)+UVset(polar)+rotate+ST UV build (main/mask/blend/dissolve);
//   mask multiply; blend-tex additive-over-tint; disturb (UV warp + normal-disturb + bi-disturb);
//   dissolve (edge clip + emissive edge); soft scene-depth fade; fresnel rim (color + opacity);
//   bright spot/scanline + 2-octave procedural distort noise + DistortAlpha/DistortOnEdge.
// Removed (HGRP pipeline infra with no URP single-RT equivalent; mirrors HGRP_CharacterNPR_VFX_Fix):
//   Motion Vectors / SV_Target1 (HGRP MRT-1 transparent MV); TAA jitter (_TaaJitterStrength);
//   camera-relative-world rebase (_WorldSpaceCameraPos add-back to OS->WS); GPU skinning;
//   SRP instancing per-draw color scale (_unity_Float4x5_Param2 -> identity);
//   octahedral NORMAL/TANGENT bit-unpack (URP feeds real mesh normal).
//   _VFXParams0.w (custom particle time) -> _Time.y; _VFXParams0.xyz (spot center) kept for _USE_BRIGHT.
//
// NOTE: _VFXParams1 = HGRP per-batch VFX color modifier (xyz RGB multiply, w desaturation). Exposed as a
//   material Vector, identity default (1,1,1,0). _ExposureParams.x = HGRP global exposure mult (default 1).
// NOTE: source emitted a 2nd motion-vector RT gated by (_Responsive*_SurfaceType) & _EnableTransparentMV;
//   dropped with the MRT. _Responsive / _EnableTransparentMV kept as inert flags.

Shader "HGRP/VfxBaseBatched_Fix" {
    Properties {
        [Header(Surface)]
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableVertColor ("Disable VertColor", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 1
        [ToggleUI] _DisableParticleInstanceColor ("Disable Particle Instance Color", Float) = 0
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        [ToggleUI] _ForceMoveToFarPlane ("Move To Far Plane", Float) = 0
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0
        [ToggleUI] _EnableTransparentMV ("Enable Transparent MV", Float) = 0

        [Header(Tint)]
        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity", Range(1, 100)) = 1
        _TintColorAlpha ("Tint Color Alpha", Range(0, 10)) = 1
        _ExpThreshold ("Exp Threshold", Range(0, 1)) = 1
        _ExpIntensity ("Exp Intensity", Range(0, 100)) = 0
        _VFXParams1 ("VFX Color Modifier (xyz mul, w desat)", Vector) = (1, 1, 1, 0)
        _ExposureParams ("Exposure Params (.x mul)", Vector) = (1, 0, 0, 0)

        [Header(Main Tex)]
        _MainTex ("Main Tex", 2D) = "white" {}
        [ToggleUI] _UseMainTexAsAlpha ("UseMainTexAsAlpha", Float) = 1
        [ToggleUI] _MainTexUseDisturb ("Main Tex Use Disturb", Float) = 1
        _MainTexUVSpeed ("MainTexUVSpeed(XY:Time, ZW:Custom1.X)", Vector) = (0, 0, 0, 0)
        _MainTexUVRotate ("MainTexUVRotate(Degree)", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _MainUVSet ("Main UV Set", Float) = 0

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        [ToggleUI] _UseMaskTexAsAlpha ("UseMaskTexAsAlpha", Float) = 1
        _MaskTexUVSpeed ("MaskTexUVSpeed(XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _MaskTexUVRotate ("MaskTexUVRotate(Degree)", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _MaskUVSet ("Mask UV Set", Float) = 0

        [Header(Blend)]
        [Toggle(_USE_BLEND)] _UseBlend ("Use Blend", Float) = 0
        _BlendTex ("Blend Tex", 2D) = "black" {}
        [HDR] [Gamma] _BlendTint ("BlendTint", Color) = (1, 1, 1, 1)
        _BlendTexUVSpeed ("BlendTexUVSpeed(XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _BlendTexUVRotate ("BlendTexUVRotate(Degree)", Float) = 0

        [Header(Disturb)]
        [Toggle(_USE_DISTURB)] _UseDisturb ("Use Disturb", Float) = 0
        _DisturbTex1 ("Disturb1 Tex", 2D) = "white" {}
        [ToggleUI] _Bi_Disturb ("Disturb in 2 Direction", Float) = 0
        [ToggleUI] _DisturbTex1Normal ("Disturb Tex1 is Normal", Float) = 0
        _DisturbUVSpeed1 ("Disturb1 UVSpeed(XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _DisturbUIntensity1 ("UIntensity1", Float) = 0
        _DisturbVIntensity1 ("VIntensity1 (Unused In Normal)", Float) = 0

        [Header(Dissolve)]
        [Toggle(_USE_DISSOLVE)] _UseDissolve ("Use Dissolve", Float) = 0
        _DissolveTex ("Dissolve Tex", 2D) = "white" {}
        _DissolveUVSpeed ("DissolveUVSpeed(XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _DissolveUVRotate ("DissolveUVRotate(Degree)", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _DissolveUVSet ("Dissolve UV Set", Float) = 0
        _DissolveScheduleOffset ("Dissolve Schedule Offset", Range(0, 1)) = 0
        _DissolveEdgeSharp ("Dissolve Edge Sharp", Range(0.001, 100)) = 1
        _DissolveEmissiveEdge ("Dissolve Edge Emissive", Range(0, 0.5)) = 0
        [HDR] [Gamma] _DissolveEmissiveColor ("Dissolve Edge Emissive Color", Color) = (0, 0, 0, 0)

        [Header(Soft Blend)]
        [Toggle(_USE_SOFTBLEND)] _UseSoftBlend ("Use SoftBlend", Float) = 0
        _SoftDistance ("Soft Distance", Range(0.001, 10)) = 0.001
        _SoftBias ("Soft Bias", Float) = 0

        [Header(Fresnel)]
        [Toggle(_USE_FRESNEL)] _UseFresnel ("Use Fresnel", Float) = 0
        [HDR] [Gamma] _FresnelColor ("Fresnel Color", Color) = (1, 1, 1, 1)
        _FresnelBias ("Fresnel Bias", Range(-1, 2)) = 0
        _FresnelAffectOpacity ("Fresnel Affect Opacity", Range(0, 1)) = 1
        _FresnelPower ("Fresnel Power", Range(1, 10)) = 1
        [ToggleUI] _FresnelFlip ("Fresnel Flip", Float) = 0.001

        [Header(Bright)]
        [Toggle(_USE_BRIGHT)] _UseBright ("Use Bright", Float) = 0
        [HDR] [Gamma] _BrightColor ("Bright (Scanline) Color", Color) = (1, 1, 1, 1)
        [Enum(Spot, 0, ScanLine, 1)] _BrightType ("Bright Type", Float) = 0
        _ScanLineSchedule ("ScanLine Schedule", Float) = 0
        _ScanLineWidth ("ScanLine Width", Float) = 0
        [HDR] [Gamma] _ScanFillColor ("Scan Fill Color", Color) = (1, 1, 1, 1)
        _InnerRadius ("Inner Radius (feather)", Range(0, 5)) = 0
        _OuterRadius ("Outer Radius (feather)", Range(0, 10)) = 2
        _CharacterHeight ("Character Height", Float) = 1.5
        _DistortScale ("Distort Scale", Float) = 5
        _DistortSpeed ("Distort Speed", Float) = 1
        _DistortIntensity ("Distort Intensity", Range(0, 1)) = 0
        _DistortAlpha ("Distort Alpha", Range(-1, 1)) = 1
        _DistortOnEdge ("Distort On Edge", Float) = 0
        _VFXParams0 ("VFX Params0 (xyz=spot center)", Vector) = (0, 0, 0, 0)

        [Header(Near Camera Fade)]
        _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Start 1", Range(0.001, 200)) = 0.001
        _NearCameraFadeDistanceEnd ("Fade End 1", Range(0.001, 200)) = 10
        _NearCameraFadeDistanceEnd2 ("Fade End 2", Range(0.002, 200)) = 100
        _NearCameraFadeDistanceStart2 ("Fade Start 2", Range(0.001, 200)) = 120

        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 1
    }

    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Surface flags
                float _SurfaceType;
                float _BlendMode;
                float _DisableVertColor;
                float _InParticle;
                float _DisableParticleInstanceColor;
                float _IgnorePostExposure;
                float _ForceMoveToFarPlane;
                float _Responsive;
                float _EnableTransparentMV;
                // Tint / exposure / glow
                float4 _TintColor;
                float _TintColorIntensity;
                float _TintColorAlpha;
                float _ExpThreshold;
                float _ExpIntensity;
                float4 _VFXParams1;
                float4 _ExposureParams;
                float4 _VFXParams0;
                // Main tex
                float4 _MainTex_ST;
                float _UseMainTexAsAlpha;
                float _MainTexUseDisturb;
                float4 _MainTexUVSpeed;
                float _MainTexUVRotate;
                float _MainUVSet;
                // Mask
                float4 _MaskTex_ST;
                float _UseMaskTexAsAlpha;
                float4 _MaskTexUVSpeed;
                float _MaskTexUVRotate;
                float _MaskUVSet;
                // Blend
                float4 _BlendTex_ST;
                float4 _BlendTint;
                float4 _BlendTexUVSpeed;
                float _BlendTexUVRotate;
                // Disturb
                float4 _DisturbTex1_ST;
                float _Bi_Disturb;
                float _DisturbTex1Normal;
                float4 _DisturbUVSpeed1;
                float _DisturbUIntensity1;
                float _DisturbVIntensity1;
                // Dissolve
                float4 _DissolveTex_ST;
                float4 _DissolveEmissiveColor;
                float4 _DissolveUVSpeed;
                float _DissolveUVRotate;
                float _DissolveUVSet;
                float _DissolveScheduleOffset;
                float _DissolveEdgeSharp;
                float _DissolveEmissiveEdge;
                // Soft blend
                float _SoftDistance;
                float _SoftBias;
                // Fresnel
                float4 _FresnelColor;
                float _FresnelBias;
                float _FresnelAffectOpacity;
                float _FresnelPower;
                float _FresnelFlip;
                // Bright / distort
                float4 _BrightColor;
                float4 _ScanFillColor;
                float _BrightType;
                float _ScanLineSchedule;
                float _ScanLineWidth;
                float _InnerRadius;
                float _OuterRadius;
                float _CharacterHeight;
                float _DistortScale;
                float _DistortSpeed;
                float _DistortIntensity;
                float _DistortAlpha;
                float _DistortOnEdge;
                // Near camera fade
                float _UseNearCameraFade;
                float _NearCameraFadeDistanceStart;
                float _NearCameraFadeDistanceEnd;
                float _NearCameraFadeDistanceStart2;
                float _NearCameraFadeDistanceEnd2;
            CBUFFER_END

            TEXTURE2D(_MainTex);      SAMPLER(sampler_MainTex);
            TEXTURE2D(_MaskTex);      SAMPLER(sampler_MaskTex);
            TEXTURE2D(_BlendTex);     SAMPLER(sampler_BlendTex);
            TEXTURE2D(_DisturbTex1);  SAMPLER(sampler_DisturbTex1);
            TEXTURE2D(_DissolveTex);  SAMPLER(sampler_DissolveTex);

            // Rec.709 luma. Blob: float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625)
            static const float3 LUM = float3(0.2126729041, 0.7152152, 0.07217500);
            // deg -> rad. Blob: 0.01745329238474369049072265625
            static const float DEG2RAD = 0.0174532924;
            // view-length epsilon. Blob: 9.9999999392252902907785028219223e-09 == 1e-8
            static const float VIEW_EPS = 9.9999999e-09;
            // hash noise constants. Blob: float2(12.98980045318603515625, 78.233001708984375), 43758.546875
            static const float2 HASH_K = float2(12.98980045, 78.23300171);
            static const float HASH_M = 43758.546875;
            // 1/1024 tile step (distort noise). Blob: 0.0009765625
            static const float NOISE_STEP = 0.0009765625;

            // World position from screen UV + raw device depth.
            // (Fragment_b35 lines 135-138: NDC->clip->world via _InvViewProjMatrix). URP: UNITY_MATRIX_I_VP.
            float3 ReconstructWorldPos(float2 screenUV, float deviceZ)
            {
                float ndcX = mad(screenUV.x, 2.0, -1.0);
                float ndcY = -mad(screenUV.y, 2.0, -1.0);              // blob y-flip ((-0.0)-(...))
                float4 hpos = mul(UNITY_MATRIX_I_VP, float4(ndcX, ndcY, deviceZ, 1.0));
                return hpos.xyz / hpos.w;
            }

            // View-space Z of a world point. (Fragment_b35 line 138 expands _ViewMatrix row-2 dot)
            float ViewSpaceZ(float3 posWS)
            {
                return mul(UNITY_MATRIX_V, float4(posWS, 1.0)).z;
            }

            // 2-band near-camera fade. (Fragment_b35 line 139)
            float NearCameraFade(float viewZ)
            {
                float az = abs(viewZ);
                float band2 = clamp((az + (-_NearCameraFadeDistanceStart2)) / ((-_NearCameraFadeDistanceStart2) + _NearCameraFadeDistanceEnd2), 0.0, 1.0);
                float band1 = clamp((az + (-_NearCameraFadeDistanceStart)) / ((-_NearCameraFadeDistanceStart) + _NearCameraFadeDistanceEnd), 0.0, 1.0);
                return (0.0 != _UseNearCameraFade) ? (band2 * band1) : 1.0;
            }

            // Tint triple shared by all variants. (Fragment_b35 lines 122-125)
            float3 TintRGB(float3 vertColor)
            {
                float postExposure = mad(_IgnorePostExposure, (-1.0) + _ExposureParams.x, 1.0);
                float3 vc = (0.0 != _DisableVertColor) ? float3(1.0, 1.0, 1.0) : vertColor;
                return (vc * _TintColor.rgb * _TintColorIntensity) / postExposure;
            }

            // Tint alpha term. (Fragment_b35 line 139 inner: (vertAlphaOrOne * _TintColor.w) * _TintColorAlpha)
            float TintAlpha(float vertAlpha)
            {
                float va = (0.0 != _DisableVertColor) ? 1.0 : vertAlpha;
                return (va * _TintColor.w) * _TintColorAlpha;
            }

            // lerp(rgb, 1, _UseMainTexAsAlpha) per channel. (Fragment_b35 lines 118-120)
            float3 UseTexAsAlphaRGB(float3 rgb, float useAsAlpha)
            {
                float one = 1.0; // asfloat(1065353216u)
                float3 o;
                o.x = mad(useAsAlpha, one + (-rgb.x), rgb.x);
                o.y = mad(useAsAlpha, one + (-rgb.y), rgb.y);
                o.z = mad(useAsAlpha, one + (-rgb.z), rgb.z);
                return o;
            }

            // Exp-threshold glow + Rec709 desaturate. boostAlpha: per-channel alpha multiplier inside the boost.
            // (Fragment_b35 lines 127-134) col' = saturate0..1000( mad(max(mad(col,a,-thr),0), inten, col*a) ),
            //   then desat = mad(_VFXParams1.w, col'-luma, luma) * _VFXParams1.xyz.
            float3 FinalizeColor(float3 col, float3 boostAlpha)
            {
                float thr = (-0.0) - _ExpThreshold;
                float3 b;
                b.x = min(max(mad(max(mad(col.x, boostAlpha.x, thr), 0.0), _ExpIntensity, col.x * boostAlpha.x), 0.0), 1000.0);
                b.y = min(max(mad(max(mad(col.y, boostAlpha.y, thr), 0.0), _ExpIntensity, col.y * boostAlpha.y), 0.0), 1000.0);
                b.z = min(max(mad(max(mad(col.z, boostAlpha.z, thr), 0.0), _ExpIntensity, col.z * boostAlpha.z), 0.0), 1000.0);
                float luma = dot(b, LUM);
                float3 d;
                d.x = mad(_VFXParams1.w, b.x - luma, luma) * _VFXParams1.x;
                d.y = mad(_VFXParams1.w, b.y - luma, luma) * _VFXParams1.y;
                d.z = mad(_VFXParams1.w, b.z - luma, luma) * _VFXParams1.z;
                return d;
            }

            // Same but boost uses (col - thr) (rgb already pre-multiplied: blend/dissolve/fresnel). (Fragment_b41 lines 145-147)
            float3 FinalizeColorPremul(float3 col)
            {
                float thr = (-0.0) - _ExpThreshold;
                float3 b;
                b.x = min(max(mad(max(col.x + thr, 0.0), _ExpIntensity, col.x), 0.0), 1000.0);
                b.y = min(max(mad(max(col.y + thr, 0.0), _ExpIntensity, col.y), 0.0), 1000.0);
                b.z = min(max(mad(max(col.z + thr, 0.0), _ExpIntensity, col.z), 0.0), 1000.0);
                float luma = dot(b, LUM);
                float3 d;
                d.x = mad(_VFXParams1.w, b.x - luma, luma) * _VFXParams1.x;
                d.y = mad(_VFXParams1.w, b.y - luma, luma) * _VFXParams1.y;
                d.z = mad(_VFXParams1.w, b.z - luma, luma) * _VFXParams1.z;
                return d;
            }

            // Secondary UV build (speed time+custom + UVset polar switch). (Vertex_b34 lines 148-151, b38 166-167)
            // set ? (mad(uv0.z,inP,-(uv1.x*inP)) + uv1.x) : uv0.x   for the chosen axis pair.
            float2 BuildAnimUV(float4 uv0, float4 uv1, float4 speed, float uvSet, float chanScroll, float customTime)
            {
                float p0x = uv1.x * _InParticle;
                float p0y = uv1.y * _InParticle;
                float polarU = mad(uv0.z, _InParticle, -p0x) + uv1.x;
                float polarV = mad(uv0.w, _InParticle, -p0y) + uv1.y;
                bool set = (0.0 != uvSet);
                float baseU = set ? polarU : uv0.x;
                float baseV = set ? polarV : uv0.y;
                float u = mad(speed.z, chanScroll, mad(speed.x, customTime, baseU)) + (-0.5);
                float v = mad(speed.w, chanScroll, mad(speed.y, customTime, baseV)) + (-0.5);
                return float2(u, v);
            }

            // Rotate (about 0.5) by degrees then apply _ST. (Vertex_b34 lines 152-156)
            float2 RotateScaleUV(float2 uv, float degrees, float4 st)
            {
                float r = DEG2RAD * degrees;
                float s = sin(r);
                float c = cos(r);
                float2 rot;
                rot.x = mad(dot(uv, float2(c, s)) + 0.5, st.x, st.z);
                rot.y = mad(dot(uv, float2(-s, c)) + 0.5, st.y, st.w);
                return rot;
            }

            // Value-noise hash. (Fragment_b37 line 179) frac(sin(dot(sign(cell)*frac(abs(cell))*1024, HASH_K))*HASH_M)
            float HashCell(float2 cell)
            {
                float2 a = frac(abs(cell));
                float2 sgn;
                sgn.x = (cell.x >= -cell.x) ? a.x : -a.x;
                sgn.y = (cell.y >= -cell.y) ? a.y : -a.y;
                return frac(sin(dot(sgn * 1024.0, HASH_K)) * HASH_M);
            }
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }

            Blend [_SrcBlend] [_DstBlend]
            ZWrite [_ZWrite]
            ZTest [_ZTest]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            #pragma shader_feature_local _USE_BRIGHT
            #pragma shader_feature_local _USE_MASK
            #pragma shader_feature_local _USE_BLEND
            #pragma shader_feature_local _USE_DISTURB
            #pragma shader_feature_local _USE_DISSOLVE
            #pragma shader_feature_local _USE_SOFTBLEND
            #pragma shader_feature_local _USE_FRESNEL

            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;
                float4 uv0        : TEXCOORD0;
                float4 uv1        : TEXCOORD1;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float4 uvMain     : TEXCOORD0; // xy = raw uv0.xy, zw = main rotated+ST uv
                float4 color      : TEXCOORD1; // vertex color (rgb) + alpha
                float3 positionWS : TEXCOORD2;
                // secondary UV varyings (only the active feature's are meaningfully consumed)
                float4 uvSecondary : TEXCOORD3; // mask/blend/dissolve/disturb uv1-derived (see per-feature build)
                float  dissolveSchedule : TEXCOORD4; // uv1.z * _InParticle, dissolve schedule input
            #if defined(_USE_FRESNEL)
                float3 normalWS   : TEXCOORD5;
            #endif
            };

            Varyings vert(Attributes input)
            {
                Varyings o = (Varyings)0;
                float customTime = _Time.y; // _VFXParams0.w in blob

                // Object->World (URP drops camera-relative rebase). (Vertex_b34 lines 135-137)
                float3 positionWS = TransformObjectToWorld(input.positionOS);
                o.positionWS = positionWS;

                // Clip pos (TAA jitter dropped). (Vertex_b34 lines 138-144)
                float4 positionCS = TransformWorldToHClip(positionWS);
                if (0.0 != _ForceMoveToFarPlane)              // (Vertex_b34 line 143)
                {
                #if UNITY_REVERSED_Z
                    positionCS.z = 0.0;
                #else
                    positionCS.z = positionCS.w;
                #endif
                }
                o.positionCS = positionCS;

                // Main UV. (Vertex_b34 lines 148-158) chanScroll = uv1.x*_InParticle
                float2 mainAnim = BuildAnimUV(input.uv0, input.uv1, _MainTexUVSpeed, _MainUVSet, input.uv1.x * _InParticle, customTime);
                float2 mainUV = RotateScaleUV(mainAnim, _MainTexUVRotate, _MainTex_ST);
                o.uvMain = float4(input.uv0.x, input.uv0.y, mainUV.x, mainUV.y);

                // Particle-instance color: SRP per-draw scale dropped -> identity, both branches == COLOR.
                // (Vertex_b34 lines 159-163)
                o.color = input.color;

                // Secondary UV per active feature (each mirrors its own vertex blob).
                float4 sec = float4(0, 0, 0, 0);
            #if defined(_USE_MASK)
                // (Vertex_b38 lines 165-172) mask anim chanScroll = uv1.y*_InParticle, rotate by _MaskTexUVRotate+_MaskTex_ST
                float2 maskAnim = BuildAnimUV(input.uv0, input.uv1, _MaskTexUVSpeed, _MaskUVSet, input.uv1.y * _InParticle, customTime);
                sec.xy = RotateScaleUV(maskAnim, _MaskTexUVRotate, _MaskTex_ST);
            #elif defined(_USE_BLEND)
                // (Vertex_b40 lines 164-170) blend anim: scroll = uv1.y*_InParticle, NO UVset (always uv0.xy),
                // rotate by _BlendTexUVRotate then _BlendTex_ST. (Fragment_b41 line 139 applies _BlendTex_ST AGAIN.)
                float p1yB = input.uv1.y * _InParticle;
                float bu = mad(_BlendTexUVSpeed.z, p1yB, mad(_BlendTexUVSpeed.x, customTime, input.uv0.x)) + (-0.5);
                float bv = mad(_BlendTexUVSpeed.w, p1yB, mad(_BlendTexUVSpeed.y, customTime, input.uv0.y)) + (-0.5);
                sec.xy = RotateScaleUV(float2(bu, bv), _BlendTexUVRotate, _BlendTex_ST);
            #elif defined(_USE_DISSOLVE)
                // (Vertex_b46 lines 161-177) dissolve anim uses _DissolveUVSpeed, _DissolveUVSet (mad-switch), rotate+_DissolveTex_ST
                float p1y = input.uv1.y * _InParticle;
                float polarU = mad(input.uv0.z, _InParticle, -(input.uv1.x * _InParticle)) + input.uv1.x;
                float polarV = mad(input.uv0.w, _InParticle, -p1y) + input.uv1.y;
                float du = mad(_DissolveUVSpeed.z, p1y, mad(_DissolveUVSpeed.x, customTime, mad(_DissolveUVSet, polarU + (-input.uv0.x), input.uv0.x))) + (-0.5);
                float dv = mad(_DissolveUVSpeed.w, p1y, mad(_DissolveUVSpeed.y, customTime, mad(_DissolveUVSet, polarV + (-input.uv0.y), input.uv0.y))) + (-0.5);
                sec.xy = RotateScaleUV(float2(du, dv), _DissolveUVRotate, _DissolveTex_ST);
                o.dissolveSchedule = input.uv1.z * _InParticle; // (Vertex_b46 line 163)
            #elif defined(_USE_DISTURB)
                // (Vertex_b42 lines 135-142) disturb passes raw uv0 (.zw polar) and uv1 (.xy scroll) untouched;
                // fragment rebuilds the disturb-warped main UV. Carry uv1.xy for the scroll channel.
                sec.xy = input.uv1.xy;
            #endif
                o.uvSecondary = sec;

            #if defined(_USE_FRESNEL)
                // (Vertex_b62 lines 314-317) world normal; octahedral unpack dropped, URP feeds real normal.
                o.normalWS = TransformObjectToWorldNormal(input.normalOS);
            #endif
                return o;
            }

            float4 frag(Varyings input) : SV_Target
            {
                float2 rawUV    = input.uvMain.xy;
                float2 mainUV   = input.uvMain.zw;
                float3 vertColor = input.color.xyz;
                float  vertAlpha = input.color.w;

                // Screen UV + reconstructed world/view depth (shared). (Fragment_b35 lines 135-138)
                float2 screenUV = input.positionCS.xy / _ScreenParams.xy;
                float3 worldPos = ReconstructWorldPos(screenUV, input.positionCS.z);
                float  viewZ    = ViewSpaceZ(worldPos);

                // ----- Disturb UV warp (Fragment_b43 lines 130-149) -----
            #if defined(_USE_DISTURB)
                float dC1y = input.uvSecondary.y * _InParticle; // (Fragment_b43 line 132) uv1.y * _InParticle
                float2 disturbUV;
                disturbUV.x = mad(mad(_DisturbUVSpeed1.x, _Time.y, dC1y * _DisturbUVSpeed1.z) + rawUV.x, _DisturbTex1_ST.x, _DisturbTex1_ST.z);
                disturbUV.y = mad(mad(_DisturbUVSpeed1.y, _Time.y, dC1y * _DisturbUVSpeed1.w) + rawUV.y, _DisturbTex1_ST.y, _DisturbTex1_ST.w);
                float4 dSamp = SAMPLE_TEXTURE2D(_DisturbTex1, sampler_DisturbTex1, disturbUV);
                float biX = mad(dSamp.x, 1.0 + _Bi_Disturb, -_Bi_Disturb);                  // (blob line 139)
                bool dNormal = (0.0 != _DisturbTex1Normal);
                float offU = dNormal ? (mad(biX * dSamp.w, 2.0, -1.0) * _DisturbUIntensity1) // (blob line 141, first arg)
                                     : (biX * _DisturbUIntensity1);
                float offV = dNormal ? (mad(dSamp.y, 2.0, -1.0) * _DisturbUIntensity1)        // (blob line 141, second arg)
                                     : (biX * _DisturbVIntensity1);
                mainUV.x = mad(offU, _MainTexUseDisturb, mainUV.x);
                mainUV.y = mad(offV, _MainTexUseDisturb, mainUV.y);
            #endif

                // ----- Bright spot/scanline + procedural distort (Fragment_b37) -----
            #if defined(_USE_BRIGHT)
                // Blob indexes a column_major O2W: _unity_ObjectToWorld[col].comp == element(comp,col).
                // So O2W[0..2].x = (M_00,M_01,M_02) = ROW 0; O2W[i].x/.y/.z = COLUMN i.
                // objDir/pX use the COLUMNS; the objPos denominator uses the ROWS (blob 137-139). Keep both.
                float3 ocCol0 = float3(UNITY_MATRIX_M[0][0], UNITY_MATRIX_M[1][0], UNITY_MATRIX_M[2][0]); // column 0
                float3 ocCol1 = float3(UNITY_MATRIX_M[0][1], UNITY_MATRIX_M[1][1], UNITY_MATRIX_M[2][1]); // column 1
                float3 ocCol2 = float3(UNITY_MATRIX_M[0][2], UNITY_MATRIX_M[1][2], UNITY_MATRIX_M[2][2]); // column 2
                float3 ocRow0 = float3(UNITY_MATRIX_M[0][0], UNITY_MATRIX_M[0][1], UNITY_MATRIX_M[0][2]); // row 0 = O2W[0..2].x
                float3 ocRow1 = float3(UNITY_MATRIX_M[1][0], UNITY_MATRIX_M[1][1], UNITY_MATRIX_M[1][2]); // row 1 = O2W[0..2].y
                float3 ocRow2 = float3(UNITY_MATRIX_M[2][0], UNITY_MATRIX_M[2][1], UNITY_MATRIX_M[2][2]); // row 2 = O2W[0..2].z

                // world->object: (1/|rowI|^2) * (worldI - O2W[I].w). O2W[I].w == element(3,I) == M[3][I]
                // (= 0 for an affine TRS; the blob literally subtracts this). (blob lines 137-139)
                float3 objPos;
                objPos.x = (1.0 / dot(ocRow0, ocRow0)) * ((-UNITY_MATRIX_M[3][0]) + worldPos.x);
                objPos.y = (1.0 / dot(ocRow1, ocRow1)) * ((-UNITY_MATRIX_M[3][1]) + worldPos.y);
                objPos.z = (1.0 / dot(ocRow2, ocRow2)) * ((-UNITY_MATRIX_M[3][2]) + worldPos.z);

                float2 dC = float2((-worldPos.x) + _VFXParams0.x, (-worldPos.z) + _VFXParams0.z); // (blob 140-141)
                float pX = dot(dC, float2(ocCol0.x, ocCol0.z));                                // (blob 142) column 0 .xz
                float pY = dot(dC, float2(ocCol1.x, ocCol1.z));                                // (blob 143) column 1 .xz
                float pZ = dot(dC, float2(ocCol2.x, ocCol2.z));                                // (blob 144) column 2 .xz
                float invLenP = rsqrt(dot(float3(pX, pY, pZ), float3(pX, pY, pZ)));            // (blob 145)
                float3 objDir = float3(dot(objPos, ocCol0), dot(objPos, ocCol1), dot(objPos, ocCol2)); // (blob 146) columns
                float scanCoord = dot(objDir, float3(invLenP * pX, invLenP * pY, invLenP * pZ)) + _ScanLineSchedule;

                float invScanW = 1.0 / (-_ScanLineWidth);                                      // (blob 147)
                float scanT     = clamp(invScanW * (scanCoord + (-_ScanLineWidth)), 0.0, 1.0); // (blob 148)
                float scanFillT = clamp(invScanW * (abs(scanCoord) + (-_ScanLineWidth)), 0.0, 1.0); // (blob 149)

                float3 dSpot = float3((-_VFXParams0.x) + worldPos.x,
                                      (-(_VFXParams0.y + _CharacterHeight)) + worldPos.y,
                                      (-_VFXParams0.z) + worldPos.z);                          // (blob 150-152)
                float spotDist = sqrt(dot(dSpot, dSpot));                                       // (blob 153)
                float invRadius = 1.0 / ((-_OuterRadius) + _InnerRadius);                       // (blob 154)
                float spotT = clamp((spotDist + (-_OuterRadius)) * invRadius, 0.0, 1.0);        // (blob 155)

                // smoothstep(t)=t*t*(3-2t); select spot/scanline by _BrightType. (blob 156-157)
                float brightSel = (0.0 != _BrightType) ? ((scanFillT * scanFillT) * mad(scanFillT, -2.0, 3.0))
                                                       : ((spotT * spotT) * mad(spotT, -2.0, 3.0));
                float scanFill = (scanT * scanT) * mad(scanT, -2.0, 3.0);

                // 2-octave value-noise distort. (blob 164-202) base coord = main rotated uv (TEXCOORD.zw)
                float distTime = _Time.y * _DistortSpeed;                                       // (blob 164)
                float nu = mad(mainUV.x, _DistortScale, distTime);                              // (blob 165)
                float nv = mad(mainUV.y, _DistortScale, distTime);                              // (blob 166)
                float fu = floor(nu);
                float fv = floor(nv);
                float ru = frac(nu);
                float rv = frac(nv);
                float su = mad(-ru, 2.0, 3.0) * (ru * ru);                                      // (blob 189-190)
                float sv = mad(-rv, 2.0, 3.0) * (rv * rv);                                      // (blob 191)
                float h00 = HashCell(float2(fu * NOISE_STEP, fv * NOISE_STEP));                 // (blob 186 _533)
                float h10 = HashCell(float2((fu + 1.0) * NOISE_STEP, fv * NOISE_STEP));         // (blob 195 inner)
                float h01 = HashCell(float2(fu * NOISE_STEP, (fv + 1.0) * NOISE_STEP));         // (blob 179 _502)
                float h11 = HashCell(float2((fu + 1.0) * NOISE_STEP, (fv + 1.0) * NOISE_STEP)); // (blob 195 _577)
                // bilerp then *2-1. (blob _577) along-U then along-V, matches mad-nest.
                float lerpU0 = lerp(h00, h10, su);
                float lerpU1 = lerp(h01, h11, su);
                float noiseRaw = mad(lerp(lerpU0, lerpU1, sv), 2.0, -1.0);

                float distEdgeT = clamp(invRadius * (mad(_DistortOnEdge, noiseRaw, spotDist) + (-_OuterRadius)), 0.0, 1.0); // (blob 196)
                float distEdge = (distEdgeT * distEdgeT) * mad(distEdgeT, -2.0, 3.0);           // (blob 197)
                float distAmt = distEdge * _DistortIntensity;                                   // (blob 198)
                // Separate 1D value-noise lane for the V-axis warp. (blob 187,194,199-202)
                // n1(f)=frac(f*0.011); g(x)=(x+7.5)*x; h(x)=frac((x+x)*x); V=lerp(h(g(n1(fv))),h(g(n1(fv+1))),sv)*2-1
                const float K011 = 0.010999999940395355224609375;                              // blob 187
                float n0 = frac(fv * K011);                                                     // blob 187 _534
                float n1 = frac((fv + 1.0) * K011);                                             // blob 194 _560
                float g0 = (n0 + 7.5) * n0;                                                     // blob 200 _604
                float g1 = (n1 + 7.5) * n1;                                                     // blob 199 _600
                float hv0 = frac((g0 + g0) * g0);                                               // blob 201 _608
                float hv1 = frac((g1 + g1) * g1);                                               // blob 202 inner
                float noiseV = mad(lerp(hv0, hv1, sv), 2.0, -1.0);                              // blob 202 (sv == _544)
                mainUV.x = mad(distAmt * noiseRaw, _MainTexUseDisturb, mainUV.x);               // (blob 202 .x)
                mainUV.y = mad(distAmt * noiseV, _MainTexUseDisturb, mainUV.y);                 // (blob 202 .y)
            #endif

                // ----- Main texture + UseMainTexAsAlpha -----
                // Main color samples MainTex at the rotated+ST main UV in every variant
                // (Fragment_b35 line 113 TEXCOORD.zw; Fragment_b55 line 127 T1 at TEXCOORD.zw).
                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, mainUV);
                float3 mainRGB = UseTexAsAlphaRGB(mainSample.xyz, _UseMainTexAsAlpha);
                // alpha term uses rgb.r-vs-alpha lerp. (Fragment_b35 line 139: mad(_UseMainTexAsAlpha, r-a, a))
                float mainAlpha = mad(_UseMainTexAsAlpha, mainSample.x + (-mainSample.w), mainSample.w);

                float3 tint = TintRGB(vertColor);
                float  tintA = TintAlpha(vertAlpha);

                // For the non-premul boost (base/mask/soft/bright), FinalizeColor computes
                //   mad(max(mad(col,boostAlpha,thr),0), _ExpIntensity, col*boostAlpha):
                // base/soft pass col=tint, boostAlpha=mainRGB (blob _128*_74); mask passes col=mainRGB*tint,
                // boostAlpha=maskRGB (blob _136*_166); bright passes col=brightRGB, boostAlpha=mainRGB.
                float3 color;
                float3 boostAlpha = mainRGB;
                bool   premulBoost = false;  // blend/dissolve/fresnel pre-multiply rgb -> (col-thr) boost
                float  opacity;

            #if defined(_USE_BRIGHT)
                // rgb = mad(_BrightColor, brightSel, scanFill*_ScanFillColor*_BrightType) + tint. (blob 158-163)
                float3 brightRGB;
                brightRGB.x = mad(_BrightColor.x, brightSel, (scanFill * _ScanFillColor.x) * _BrightType) + tint.x;
                brightRGB.y = mad(_BrightColor.y, brightSel, (scanFill * _ScanFillColor.y) * _BrightType) + tint.y;
                brightRGB.z = mad(_BrightColor.z, brightSel, (scanFill * _ScanFillColor.z) * _BrightType) + tint.z;
                float brightA = mad(_BrightColor.w, brightSel, (scanFill * _ScanFillColor.w) * _BrightType) + tintA;
                color = brightRGB;       // col=brightRGB, boostAlpha=mainRGB (blob 212: mad(_419,_650,..))
                boostAlpha = mainRGB;
                // opacity = mainAlpha * smoothstep-distort-modulated brightA. (blob 216)
                float brightOpacity = clamp(mad(distEdge, mad(brightA, _DistortAlpha, -brightA), brightA), 0.0, 1.0);
                opacity = mad(_UseMainTexAsAlpha, (-mainSample.w) + mainSample.x, mainSample.w) * brightOpacity;
            #elif defined(_USE_FRESNEL)
                // (Fragment_b63) view dir, pow-fresnel, rim color into tinted main, opacity affected.
                bool isOrtho = (0.0 == unity_OrthoParams.w);                                    // (blob 127)
                float3 camFwd = float3(UNITY_MATRIX_V[2][0], UNITY_MATRIX_V[2][1], UNITY_MATRIX_V[2][2]); // _ViewMatrix[0..2].z
                float3 vdir = isOrtho ? (-worldPos + _WorldSpaceCameraPos) : camFwd;            // (blob 128-130)
                float invVlen = rsqrt(max(dot(vdir, vdir), VIEW_EPS));                          // (blob 131)
                float ndv = clamp(dot(vdir * invVlen, input.normalWS) + _FresnelBias, 0.0, 1.0);// (blob 132)
                float fres = exp2(log2(ndv) * _FresnelPower);                                   // (blob 132) pow
                float invF = (-fres) + 1.0;                                                     // (blob 133)
                float fresFlipped = mad(_FresnelFlip, (-invF) + fres, invF);                    // (blob 134)
                float fresW = fresFlipped * _FresnelColor.w;                                    // (blob 135)
                // rgb = lerp(main*tint, _FresnelColor.rgb, fresW). (blob 150-152, mad form)
                color.x = mad(fresW, mad(-tint.x, mainRGB.x, _FresnelColor.x), mainRGB.x * tint.x);
                color.y = mad(fresW, mad(-tint.y, mainRGB.y, _FresnelColor.y), mainRGB.y * tint.y);
                color.z = mad(fresW, mad(-tint.z, mainRGB.z, _FresnelColor.z), mainRGB.z * tint.z);
                premulBoost = true;
                float fresOpacityMul = mad(fresFlipped, _FresnelAffectOpacity, 1.0 + (-_FresnelAffectOpacity)); // (blob 153)
                opacity = fresOpacityMul * clamp(mainAlpha * tintA, 0.0, 1.0);
            #elif defined(_USE_BLEND)
                // (Fragment_b41) blend tex added over main*tint, weighted by combined alpha.
                float2 blendUV = float2(mad(input.uvSecondary.x, _BlendTex_ST.x, _BlendTex_ST.z),
                                        mad(input.uvSecondary.y, _BlendTex_ST.y, _BlendTex_ST.w)); // (blob 139)
                float4 blendSample = SAMPLE_TEXTURE2D(_BlendTex, sampler_BlendTex, blendUV);
                float blendW = clamp(mad(tintA, mainAlpha, blendSample.w) * (vertAlpha * _BlendTint.w), 0.0, 1.0); // (blob 140)
                color.x = mad(blendW * blendSample.x, vertColor.x * _BlendTint.x, mainRGB.x * tint.x);   // (blob 141)
                color.y = mad(blendW * blendSample.y, vertColor.y * _BlendTint.y, mainRGB.y * tint.y);   // (blob 142)
                color.z = mad(blendW * blendSample.z, vertColor.z * _BlendTint.z, mainRGB.z * tint.z);   // (blob 143)
                premulBoost = true;
                opacity = mainAlpha * tintA;                                                    // (blob 157 _135*_97)
            #elif defined(_USE_DISSOLVE)
                // (Fragment_b47) dissolve mask -> edge clip + emissive edge color.
                float dissTex = SAMPLE_TEXTURE2D(_DissolveTex, sampler_DissolveTex, input.uvSecondary.xy).x; // (blob 130)
                float dissolveDrive = ((-0.0) - mad(input.dissolveSchedule + _DissolveScheduleOffset, 2.019999980926513671875, -1.0099999904632568359375)) + dissTex; // (blob 130)
                float edge = clamp(((-dissolveDrive) + _DissolveEmissiveEdge) * _DissolveEdgeSharp, 0.0, 1.0); // (blob 131)
                float3 mt = mainRGB * tint;
                color.x = mad(edge, mad(edge * _DissolveEmissiveColor.x, _TintColorIntensity, -mt.x), mt.x); // (blob 132)
                color.y = mad(edge, mad(edge * _DissolveEmissiveColor.y, _TintColorIntensity, -mt.y), mt.y); // (blob 133)
                color.z = mad(edge, mad(edge * _DissolveEmissiveColor.z, _TintColorIntensity, -mt.z), mt.z); // (blob 134)
                premulBoost = true;
                float dissolveAlpha = clamp(dissolveDrive * _DissolveEdgeSharp, 0.0, 1.0);      // (blob 148 inner)
                opacity = (mainAlpha * tintA) * dissolveAlpha;
            #elif defined(_USE_MASK)
                // (Fragment_b39) mask tex multiplies tinted color (via boost alpha) and opacity.
                float4 maskSample = SAMPLE_TEXTURE2D(_MaskTex, sampler_MaskTex, input.uvSecondary.xy);
                float3 maskRGB = UseTexAsAlphaRGB(maskSample.xyz, _UseMaskTexAsAlpha);          // (blob 133-135)
                float maskAlpha = mad(_UseMaskTexAsAlpha, maskSample.x + (-maskSample.w), maskSample.w); // (blob 149)
                color = mainRGB * tint;       // col=mainRGB*tint (blob _136), boostAlpha=maskRGB (blob _166)
                boostAlpha = maskRGB;                                                           // (blob 137-139)
                opacity = (mainAlpha * tintA) * maskAlpha;                                       // (blob 149)
            #elif defined(_USE_SOFTBLEND)
                // (Fragment_b55) soft depth fade against scene depth.
                float sceneRaw = SampleSceneDepth(screenUV);                                     // URP camera depth
                float3 sceneWS = ReconstructWorldPos(screenUV, sceneRaw);
                float sceneViewZ = ViewSpaceZ(sceneWS);
                float soft = clamp((((-abs(viewZ)) + abs(sceneViewZ)) + _SoftBias) / _SoftDistance, 0.0, 1.0); // (blob 125)
                color = tint;            // col=tint, boostAlpha=mainRGB (blob 141: mad(_303,_253,..))
                boostAlpha = mainRGB;
                opacity = soft * (mainAlpha * tintA);                                            // (blob 144)
            #else
                // BASE. (Fragment_b35 lines 122-129) col=tint (_128), boostAlpha=mainRGB (_74); product == mainRGB*tint.
                color = tint;
                boostAlpha = mainRGB;
                opacity = mainAlpha * tintA;
            #endif

                float3 finalRGB = premulBoost ? FinalizeColorPremul(color) : FinalizeColor(color, boostAlpha);

                // Near-camera fade scales opacity, saturate. (Fragment_b35 line 139 outer clamp)
                float finalAlpha = clamp(NearCameraFade(viewZ) * opacity, 0.0, 1.0);

                float outAlpha = (_SurfaceType == 1.0) ? finalAlpha : 1.0; // opaque writes 1 (STYLE_BIBLE §6)
                return float4(finalRGB, outAlpha);
            }
            ENDHLSL
        }
    }
}
