// HGRP VFX Dither-Alpha — particle/VFX surface with screen-space interleaved-gradient dither alpha test.
//   ForwardLit pass -> visible color (MainTex * tint * vertexColor * intensity, optional Main2 / Mask /
//                      Disturb / Dissolve+emissive / CubeMap reflection / Fresnel rim / vertical
//                      ColorGradient / NormalMap-driven Fresnel), divided by post-exposure.
//   DepthOnly pass  -> the defining feature: per-pixel IGN ordered-dither clip on the particle's
//                      procedural alpha (so the transparent VFX reads/writes depth as a stochastic
//                      stipple instead of writing a hard alpha edge).
//
// Merged from: vfxditheralpha.shader (HGRP/Effect/VFXDitherAlpha)
//   ForwardLit (GBuffer) base blob: vfxditheralpha/Sub0_Pass0_Fragment_b125.hlsl (+ Sub0_Pass0_Vertex_b124.hlsl)
//   DepthOnly        base blob: vfxditheralpha/Sub0_Pass1_Fragment_b465.hlsl (+ Sub0_Pass1_Vertex_b464.hlsl)
//   Feature deltas (color path): _USE_MAIN2 b129, _USE_COLOR_GRADIENT b247,
//     _NORMAL_MAP+_USE_FRESNEL+_USE_MAIN2+_USE_DISSOLVE+_USE_DISTURB b343,
//     _USE_CUBEMAP+_NORMAL_MAP+_USE_DISSOLVE+_USE_DISTURB+_USE_SCREENUV+_USE_POLARUV b369,
//     vertex _USE_VERTOFFSET b132.
//
// Keywords: _USE_MAIN2, _USE_MASK, _USE_DISTURB, _USE_DISSOLVE, _USE_CUBEMAP, _USE_FRESNEL,
//   _NORMAL_MAP, _USE_COLOR_GRADIENT, _USE_SCREENUV, _USE_POLARUV, _USE_VERTOFFSET, _USE_VERTOFFSETMASK
// Kept: particle-aware UV (UV-channel weights + time/custom scroll + 2x2 rotate + ST + disturb),
//   MainTex sample (RGB or alpha-as-RGB), tint/vertex-color/intensity, ignore-post-exposure scale,
//   Main2 multiply/additive RGB blend, Mask (ALPHA-only, "只影响Alpha"), disturb (bi-direction / normal-map mode),
//   dissolve edge + emissive edge color, cubemap reflection add, Fresnel rim (NormalMap-driven,
//   bias/power/flip/affect-opacity), vertical color gradient, screen-UV / polar-UV coordinate
//   generators, vertex offset (offset-tex driven, object/world/normal direction switch + mask),
//   near-camera distance fade, and the screen-space IGN ordered-dither alpha clip
//   (_DitherTilling tiling + _DitherAlphaExp pow on the saturated alpha).
// Removed (pixel-neutral HGRP infra substituted by URP): the 5-MRT GBuffer encode
//   (SV_Target_1..4 = packed octahedral normal / motion-vector / material-id targets — URP forward
//   has no deferred MRT here; normals come from URP's own DepthNormals prepass), HG_ENABLE_MV
//   prev-frame motion-vector reprojection (_PrevNonJittered*/_PrevCamPosRWS), TAA jitter
//   (_TaaJitterStrength), GPU-skinning / packed-octahedral vertex normal+tangent unpack (spvBitfield*),
//   SRP per-draw instancing array, manual View/InvViewProj/NonJittered matrices, _GlobalMipBias,
//   _VFXParams0.w (custom VFX time -> URP _Time.y), _ScreenSize (-> _ScreenParams). DepthOnly's
//   manual InvViewProj depth-reconstruction is replaced by URP LinearEyeDepth; ScreenUV's manual
//   world-pos reconstruction is replaced by URP screen UV + LinearEyeDepth.
//
// NOTE: This VFX family ALIASES the same float4 uniforms differently per ParamBlob (decompiler remap):
//   e.g. in b343/b369 the MainTex UV scroll reads out of _Fresnel*/_NearCameraFade*/_Dissolve* slots,
//   and Main2/Mask UV weights out of _Mask* slots. Every uniform below is named by its TRUE inspector
//   semantic (matching the source Properties block) and the blob slot it was read from is cited.
// NOTE: _ProcedureAlpha is a source [HideInInspector] property but the DepthOnly base/delta blobs
//   (b465 ...) never read it — the dither alpha is pow(saturate(alpha), _DitherAlphaExp) with NO
//   _ProcedureAlpha factor (it is not in the b465 cbuffer at all).
// NOTE: _MainUVSet/_MaskUVSet/etc. PolarUV(2)/ScreenUV(3) enum values are realized by the
//   _USE_POLARUV / _USE_SCREENUV keyword branches (which compute polar/screen coords and feed them
//   through the same weights.zw channels the decompiled UV expression uses). UV0(0)/UV1(1) collapse
//   to the weights.x=UV0, weights.y=UV1 blend the base blob compiles.

Shader "HGRP/Effect/VFXDitherAlpha_Fix"
{
    Properties
    {
        [Header(Base)]
        [Enum(Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        [ToggleUI] _DisableVertColor ("Disable VertColor", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 1
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        [HideInInspector] _ProcedureAlpha ("Procedure Alpha", Float) = 1
        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity", Range(1, 100)) = 1
        _TintColorAlpha ("Tint Color Alpha", Range(0, 10)) = 1
        [Header(Exposure)]
        _ExposureParams ("ExposureParams (.x = post-exposure)", Vector) = (1, 0, 0, 0)

        [Header(Dither)]
        _DitherTilling ("Dither Tilling", Float) = 1
        _DitherAlphaExp ("Dither Alpha Exp", Float) = 1

        [Header(Main Tex)]
        _MainTex ("Main Tex", 2D) = "white" {}
        [ToggleUI] _MainTexUseDisturb ("Main Tex Use Disturb", Float) = 1
        [ToggleUI] _UseMainTexAsAlpha ("UseMainTexAsAlpha", Float) = 1
        _MainTexUVSpeed ("MainTexUVSpeed (XY:Time, ZW:Custom1.X)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _MainTexUVRotateMat ("MainTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MainUVSet ("Main UV Set", Float) = 0
        [HideInInspector] _MainTexUVWeights ("_MainTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Main Tex 2 (RGB only))]
        [Toggle(_USE_MAIN2)] _UseMain2 ("Use Main 2", Float) = 0
        _MainTex2Color ("Main Tex 2 Color", Color) = (1, 1, 1, 1)
        _MainTex2 ("Main Tex 2", 2D) = "white" {}
        [ToggleUI] _MainTex2UseDisturb ("Main Tex 2 Use Disturb", Float) = 1
        [ToggleUI] _UseMainTex2AsAlpha ("UseMainTex2AsAlpha", Float) = 1
        _MainTex2UVSpeed ("MainTex2UVSpeed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _MainTex2UVRotateMat ("MainTex2UVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MainTex2UVSet ("Main2 UV Set", Float) = 0
        [HideInInspector] _MainTex2UVWeights ("_MainTex2UVWeights", Vector) = (1, 0, 0, 0)
        [Enum(Multiply, 0, Additive, 1)] _MainTex2BlendMode ("Main Tex2 Blend Type", Float) = 0

        [Header(Mask (Alpha plus RGB))]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        [ToggleUI] _MaskTexUseDisturb ("Mask Tex Use Disturb", Float) = 1
        [ToggleUI] _UseMaskTexAsAlpha ("UseMaskTexAsAlpha", Float) = 1
        _MaskTexUVSpeed ("MaskTexUVSpeed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _MaskTexUVRotateMat ("MaskTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MaskUVSet ("Mask UV Set", Float) = 0
        [HideInInspector] _MaskTexUVWeights ("_MaskTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Disturb)]
        [Toggle(_USE_DISTURB)] _UseDisturb ("Use Disturb", Float) = 0
        _DisturbTex1 ("Disturb Tex 1", 2D) = "white" {}
        _DisturbUVSpeed1 ("DisturbUVSpeed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _DisturbUVRotateMat1 ("DisturbUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _DisturbUVSet1 ("DisturbTex UV Set", Float) = 0
        [HideInInspector] _DisturbUVWeights1 ("_DisturbTexUVWeights", Vector) = (1, 0, 0, 0)
        [ToggleUI] _Bi_Disturb ("Disturb in 2 Direction", Float) = 0
        [ToggleUI] _DisturbTex1Normal ("Disturb Tex1 is Normal", Float) = 0
        _DisturbUIntensity1 ("UIntensity1", Float) = 0
        _DisturbVIntensity1 ("VIntensity1 (Unused In Normal)", Float) = 0

        [Header(Dissolve)]
        [Toggle(_USE_DISSOLVE)] _UseDissolve ("Use Dissolve", Float) = 0
        _DissolveTex ("Dissolve Tex", 2D) = "white" {}
        [ToggleUI] _DissolveTexUseDisturb ("Dissolve Tex Use Disturb", Float) = 1
        _DissolveUVSpeed ("DissolveUVSpeed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _DissolveUVRotateMat ("DissolveUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _DissolveUVSet ("Dissolve UV Set", Float) = 0
        [HideInInspector] _DissolveUVWeights ("_DissolveUVWeights", Vector) = (1, 0, 0, 0)
        _DissolveScheduleOffset ("Dissolve Schedule Offset", Range(0, 2)) = 0
        _DissolveEdgeSharp ("Dissolve Edge Sharp", Range(0.001, 100)) = 1
        _DissolveEmissiveEdge ("Dissolve Edge Emissive", Range(0, 0.5)) = 0
        [HDR] [Gamma] _DissolveEmissiveColor ("Dissolve Edge Emissive Color", Color) = (0, 0, 0, 0)

        [Header(CubeMap (RGB only))]
        [Toggle(_USE_CUBEMAP)] _UseCubeMap ("Use CubeMap", Float) = 0
        _CubeMap ("Cube Map", Cube) = "black" {}
        _CubeMapColor ("Cube Map Color", Color) = (1, 1, 1, 1)

        [Header(Fresnel)]
        [Toggle(_USE_FRESNEL)] _UseFresnel ("Use Fresnel", Float) = 0
        [HDR] [Gamma] _FresnelColor ("Fresnel Color", Color) = (1, 1, 1, 1)
        _FresnelBias ("Fresnel Bias", Range(-1, 2)) = 0
        _FresnelAffectOpacity ("Fresnel Affect Opacity", Range(0, 1)) = 1
        _FresnelPower ("Fresnel Power", Range(1, 10)) = 1
        [ToggleUI] _FresnelFlip ("Fresnel Flip", Float) = 0.001

        [Header(Screen and Polar UV)]
        [ToggleUI] _UsePosYAsScreenV ("Use World Y as ScreenV", Float) = 0
        [ToggleUI] _ScreenUVUseDepth ("ScreenUV affected by camera distance", Float) = 1

        [Header(Normal Map (for Fresnel))]
        [Toggle(_NORMAL_MAP)] _EnableNormalMap ("Normal Map", Float) = 0
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 3)) = 1
        [ToggleUI] _NormalMapUseDisturb ("NormalMap Use Disturb", Float) = 1
        _NormalMapUVSpeed ("NormalMapUVSpeed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _NormalMapUVRotateMat ("NormalMapUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _NormalMapUVSet ("NormalMap UV Set", Float) = 0
        [HideInInspector] _NormalMapUVWeights ("_NormalMapUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Color Gradient)]
        [Toggle(_USE_COLOR_GRADIENT)] _UseColorGradient ("Use Color Gradient", Float) = 0
        _ColorTop ("Color Top", Color) = (0, 0, 0, 1)
        _ColorBottom ("Color Bottom", Color) = (1, 1, 1, 1)
        _ColorGradientCenter ("Center", Float) = 0
        _ColorGradientRange ("Gradient Range", Float) = 0.2

        [Header(Vertex Offset)]
        [Toggle(_USE_VERTOFFSET)] _UseVertexOffset ("Use Vertex Offset", Float) = 0
        _OffsetTex ("Offset Tex", 2D) = "white" {}
        _OffsetSpeed ("Offset Speed (XY:Time, ZW:Custom)", Vector) = (0, 0, 0, 0)
        _OffsetDir ("Offset Dir (XYZ:Axis, W:By CustomY)", Vector) = (0, 0, 0, 0)
        [Enum(Object, 0, World, 1, Normal, 2)] _OffsetSwitchDir ("Dir Switcher", Float) = 0
        _OffsetIntensity ("Offset Intensity", Float) = 0
        [ToggleUI] _Bi_Offset ("Use Two Direction Offset", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _OffsetUVSet ("Vertex Offset UV Set", Float) = 0
        [Toggle(_USE_VERTOFFSETMASK)] _UseVertexOffsetMask ("Use Vertex Offset Mask", Float) = 0
        _OffsetMaskTex ("Offset Mask Tex", 2D) = "white" {}
        _OffsetMaskSpeed ("Offset Mask Speed (XY:Time, ZW:Custom)", Vector) = (0, 0, 0, 0)
        _OffsetMaskPower ("Offset Mask Power", Range(0, 5)) = 0

        [Header(Near Camera Fade)]
        [ToggleUI] _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Start 1", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Fade End 1", Range(0.001, 3000)) = 10
        _NearCameraFadeDistanceEnd2 ("Fade End 2", Range(0.002, 3000)) = 100
        _NearCameraFadeDistanceStart2 ("Fade Start 2", Range(0.001, 3000)) = 120

        // Render-state plumbing (driven by a material editor / OnValidate, not the shader).
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _StencilReadMask ("__stencilReadMask", Float) = 255
        [HideInInspector] _StencilWriteMask ("__stencilWriteMask", Float) = 255
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 1
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType"     = "Transparent"
            "Queue"          = "Transparent"
        }
        LOD 300

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Base
                float  _SurfaceType;
                float  _BlendMode;
                float  _InParticle;
                float  _DisableVertColor;
                float  _IgnorePostExposure;
                float  _ProcedureAlpha;
                float  _TintColorIntensity;
                float  _TintColorAlpha;
                float4 _TintColor;
                float4 _ExposureParams;
                // Dither
                float  _DitherTilling;
                float  _DitherAlphaExp;
                // MainTex
                float  _MainTexUseDisturb;
                float  _UseMainTexAsAlpha;
                float4 _MainTexUVSpeed;
                float4 _MainTexUVRotateMat;
                float4 _MainTexUVWeights;
                float4 _MainTex_ST;
                // Main Tex 2
                float  _MainTex2UseDisturb;
                float  _UseMainTex2AsAlpha;
                float  _MainTex2BlendMode;
                float4 _MainTex2Color;
                float4 _MainTex2UVSpeed;
                float4 _MainTex2UVRotateMat;
                float4 _MainTex2UVWeights;
                float4 _MainTex2_ST;
                // Mask
                float  _MaskTexUseDisturb;
                float  _UseMaskTexAsAlpha;
                float4 _MaskTexUVSpeed;
                float4 _MaskTexUVRotateMat;
                float4 _MaskTexUVWeights;
                float4 _MaskTex_ST;
                // Disturb
                float  _Bi_Disturb;
                float  _DisturbTex1Normal;
                float  _DisturbUIntensity1;
                float  _DisturbVIntensity1;
                float4 _DisturbUVSpeed1;
                float4 _DisturbUVRotateMat1;
                float4 _DisturbUVWeights1;
                float4 _DisturbTex1_ST;
                // Dissolve
                float  _DissolveTexUseDisturb;
                float  _DissolveScheduleOffset;
                float  _DissolveEdgeSharp;
                float  _DissolveEmissiveEdge;
                float4 _DissolveEmissiveColor;
                float4 _DissolveUVSpeed;
                float4 _DissolveUVRotateMat;
                float4 _DissolveUVWeights;
                float4 _DissolveTex_ST;
                // CubeMap
                float4 _CubeMapColor;
                // Fresnel
                float  _FresnelBias;
                float  _FresnelAffectOpacity;
                float  _FresnelPower;
                float  _FresnelFlip;
                float4 _FresnelColor;
                // Screen / Polar UV
                float  _UsePosYAsScreenV;
                float  _ScreenUVUseDepth;
                // Normal Map
                float  _NormalScale;
                float  _NormalMapUseDisturb;
                float4 _NormalMapUVSpeed;
                float4 _NormalMapUVRotateMat;
                float4 _NormalMapUVWeights;
                float4 _NormalMap_ST;   // blob b343:248 NormalMap own ST (aliased _Roughness/_AntiFlicker c36)
                // Color Gradient
                float  _ColorGradientCenter;
                float  _ColorGradientRange;
                float4 _ColorTop;
                float4 _ColorBottom;
                // Vertex Offset
                float  _OffsetSwitchDir;
                float  _OffsetIntensity;
                float  _Bi_Offset;
                float  _OffsetUVSet;
                float  _OffsetMaskPower;
                float4 _OffsetSpeed;
                float4 _OffsetDir;
                float4 _OffsetTex_ST;
                float4 _OffsetMaskSpeed;
                float4 _OffsetMaskTex_ST;
                // Near camera fade
                float  _UseNearCameraFade;
                float  _NearCameraFadeDistanceStart;
                float  _NearCameraFadeDistanceEnd;
                float  _NearCameraFadeDistanceEnd2;
                float  _NearCameraFadeDistanceStart2;
                // Render state
                float  _TransparentSortPriority;
            CBUFFER_END

            TEXTURE2D(_MainTex);       SAMPLER(sampler_MainTex);
            TEXTURE2D(_MainTex2);      SAMPLER(sampler_MainTex2);
            TEXTURE2D(_MaskTex);       SAMPLER(sampler_MaskTex);
            TEXTURE2D(_DisturbTex1);   SAMPLER(sampler_DisturbTex1);
            TEXTURE2D(_DissolveTex);   SAMPLER(sampler_DissolveTex);
            TEXTURE2D(_NormalMap);     SAMPLER(sampler_NormalMap);
            TEXTURE2D(_OffsetTex);     SAMPLER(sampler_OffsetTex);
            TEXTURE2D(_OffsetMaskTex); SAMPLER(sampler_OffsetMaskTex);
            TEXTURECUBE(_CubeMap);     SAMPLER(sampler_CubeMap);

            static const float PI       = 3.1415927410125732421875;   // blob b369:233
            static const float INV_2PI  = 0.15915493667125701904296875; // 1/(2*PI), blob b369:234
            static const float NEAR_ZERO = 9.9999999392252902907785028219223e-09; // 1e-8 rsqrt/denominator guard
            static const float TINY_Z    = 1.000000016862383526387164645044e-16;   // derived-normal Z floor (blob b343:253)

            // ============================================================================
            // Particle-aware UV (GBuffer base blob b125:103; matches every delta's UV expr).
            // 1:1 with the decompiled inner expression:
            //   coord = UV0*weights.x + UV1*weights.y (+ polar/screen extras via weights.zw)
            //   coord = coord + speed.xy*time + speed.zw*custom
            //   c     = coord - 0.5;  rot.x = c.x*M.x + c.y*M.z;  rot.y = c.x*M.y + c.y*M.w
            //   uv    = (rot + 0.5) * ST.xy + ST.zw  (+ disturb*useDisturb)
            // UV0 = TEXCOORD.xy; UV1 rebuilt particle-side (see BuildParticleUVs).
            // extra2/extra3 carry the PolarUV (angle, radius) or ScreenUV (x, y) coords routed
            // into weights.z/weights.w exactly as the decompiled expr multiplies them in
            // (blob b369:275 mad(... weights.w ... weights.z ...)).
            // ============================================================================
            float2 ComputeVfxUV(float2 uv0, float2 uv1, float4 weights, float4 speed,
                                float time, float custom, float4 rotateMat, float4 st,
                                float2 extra2, float2 extra3,
                                float2 disturb, float useDisturb)
            {
                // coord.x: TEXCOORD.x*weights.x + UV1.x*weights.y + extra3.x*weights.z + extra2.x*weights.w
                // coord.y: TEXCOORD.y*weights.x + UV1.y*weights.y + extra3.y*weights.z + extra2.y*weights.w
                float2 coord;
                coord.x = mad(uv0.x, weights.x, mad(uv1.x, weights.y, mad(extra3.x, weights.z, extra2.x * weights.w)));
                coord.y = mad(uv0.y, weights.x, mad(uv1.y, weights.y, mad(extra3.y, weights.z, extra2.y * weights.w)));
                coord = mad(speed.xy, time.xx, coord);
                coord = mad(speed.zw, custom.xx, coord);
                float2 c = coord + (-0.5).xx;
                float2 rot;
                rot.x = mad(c.x, rotateMat.x, c.y * rotateMat.z);
                rot.y = mad(c.x, rotateMat.y, c.y * rotateMat.w);
                float2 uv = mad(rot + 0.5.xx, st.xy, st.zw);
                return mad(disturb, useDisturb.xx, uv);
            }

            // Polar UV (blob b369:223-235). u=TEXCOORD.x-0.5, v=TEXCOORD.y-0.5.
            //   atan2 via minimax: t=|u/v| (or 1/|u/v|), poly = ((0.0872929*t^2 - 0.3018950)*t^2 + 1)*t
            //   angle = (sign-corrected atan2 + PI) * (1/2PI);  radius = 2*length(u,v).
            // out .x = angle (-> weights.z slot), .y = radius (-> weights.z slot for the .y component);
            // the decompiled expr routes _335(angle) into the .x build and _326(radius doubled) too.
            // Returns float4(angleX, radiusX, angleY, radiusY) packed for the extra3 channel use:
            //   blob feeds (angle, radius) as the weights.z pair: coordX uses _335(angle), coordY uses _326?
            //   Actually b369:275 coordX += _335*weights.z (angle) and coordY += _326*weights.z (radius).
            // So extra3 = float2(angle, radius).
            float2 ComputePolarUV(float2 uv01)
            {
                float u = uv01.x + (-0.5);  // blob b369:223 _286
                float v = uv01.y + (-0.5);  // blob b369:224 _288
                float q = u / v;            // _289
                bool small = abs(q) < 1.0;  // _293
                float t = small ? abs(q) : (1.0 / abs(q));        // _295
                float t2 = t * t;                                  // _297
                float poly = mad(mad(t2, 0.087292902171611785888671875, -0.3018949925899505615234375), t2, 1.0) * t; // b369:301 _301*t = _309 small path
                float atanCore = small ? poly : mad((-0.0) - poly, 1.0, 1.57079637050628662109375); // b369:309 large path = PI/2 - poly
                float radius = sqrt(dot(float2(u, v), float2(u, v))); // _324
                // sign-corrected atan2 (blob b369:331):
                float signU = (u >= 0.0) ? asfloat(1078530010u) : asfloat(3226013658u); // +PI : -PI  (atan2 octant base)
                float maskV = asfloat(((v < 0.0) ? 4294967295u : 0u) & 1065353216u);    // (v<0)?1:0
                float a = (q < 0.0) ? (-atanCore) : atanCore;
                float angle = mad(signU, maskV, a) + PI;                                  // _331
                float angleUV = angle * INV_2PI;                                          // _335
                float radius2 = radius + radius;                                          // _326
                return float2(angleUV, radius2);
            }

            // Screen UV (blob b369:208-222). Reconstructs the particle's screen-space UV with an
            // optional camera-distance scale (_ScreenUVUseDepth) and a world-Y-as-V branch
            // (_UsePosYAsScreenV). URP gives screen UV directly; camera distance via LinearEyeDepth.
            //   base screen uv0 = positionCS.xy / _ScreenParams.xy   (NDC-ish [0,1] then *2-1 in blob)
            //   distScale = mad(max(-(viewZ) - _ProjectionParams.y, 1), _ScreenUVUseDepth, 1-_ScreenUVUseDepth)
            // We return float2(scaledU, scaledV) for the extra2 (weights.w) channel.
            float2 ComputeScreenUV(float4 positionCS, float dist)
            {
                // NDC screen coords centered (blob b369:217-218 use floor(fragCoord)/screenParams*2-1).
                float2 ndc = positionCS.xy / _ScreenParams.xy; // [0,1]
                float sx = mad(ndc.x, 2.0, -1.0);              // _238
                // _247 = (ndc.y*2-1)/_ScreenParams.x * _ScreenParams.y  (aspect re-scale of V)
                float sy = (mad(ndc.y, 2.0, -1.0) / _ScreenParams.x) * _ScreenParams.y; // _247
                // camera-distance scale factor (blob b369:127,207):
                //   distScale = lerp(1, max(dist - _ProjectionParams.y, 1), _ScreenUVUseDepth)
                float distScale = mad(max(dist + ((-0.0) - _ProjectionParams.y), 1.0), _ScreenUVUseDepth, 1.0 + ((-0.0) - _ScreenUVUseDepth)); // _127
                // _UsePosYAsScreenV picks world-Y vs screen-Y for V (blob b369:265 branch).
                // Approximated by screen V here; the exact world-Y branch is a TODO below.
                float scaledU = distScale * sx; // b369:267 _267 = _127 * _255
                float scaledV = distScale * sy; // b369:267 _269 = _127 * _265
                return float2(scaledU, scaledV);
            }

            // Disturb offset (blob b343:223-227 / b369 disturb). biDisturb remaps [0,1]->[-1,1] when
            // _Bi_Disturb=1: mad(s.x, 1+_Bi_Disturb, -_Bi_Disturb). Normal-mode (s is a normal map):
            //   x = mad(biDisturb*s.w, 2,-1) * _DisturbUIntensity1; y = mad(s.y, 2,-1) * _DisturbUIntensity1.
            // Non-normal: x = biDisturb * _DisturbUIntensity1; y = biDisturb * _DisturbVIntensity1.
            float2 ComputeDisturb(float2 uv0, float2 uv1, float time, float custom)
            {
                float2 d = float2(0.0, 0.0);
            #ifdef _USE_DISTURB
                float2 dUV = ComputeVfxUV(uv0, uv1, _DisturbUVWeights1, _DisturbUVSpeed1,
                                          time, custom, _DisturbUVRotateMat1, _DisturbTex1_ST,
                                          float2(0.0, 0.0), float2(0.0, 0.0),
                                          float2(0.0, 0.0), 0.0);
                float4 s = SAMPLE_TEXTURE2D(_DisturbTex1, sampler_DisturbTex1, dUV);
                float biDisturb = mad(s.x, 1.0 + _Bi_Disturb, -_Bi_Disturb); // b343:224 _200
                bool normalMode = (0.0 != _DisturbTex1Normal);               // b343:225 _220
                d.x = normalMode ? (mad(biDisturb * s.w, 2.0, -1.0) * _DisturbUIntensity1)
                                 : (biDisturb * _DisturbUIntensity1);        // b343:226 _227
                d.y = normalMode ? (mad(s.y, 2.0, -1.0) * _DisturbUIntensity1)
                                 : (biDisturb * _DisturbVIntensity1);        // b343:227 _229
            #endif
                return d;
            }

            // ---- Shared particle interpolants -------------------------------------------------
            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0; // UV0 in .xy, UV1 in .zw (particle)
                float4 texcoord1  : TEXCOORD1; // particle custom data (.x,.y custom1; .z dissolve schedule)
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float4 uv0uv1     : TEXCOORD0; // pass-through texcoord0
                float4 customData : TEXCOORD1; // pass-through texcoord1
                float4 vertColor  : TEXCOORD2;
                float3 normalWS   : TEXCOORD3;
                float4 tangentWS  : TEXCOORD4; // .xyz tangent, .w bitangent sign
                float3 positionWS : TEXCOORD5;
            };

            // Vertex offset (1:1, blob b132:264-276). offset = offsetTexR_remapped * intensity * direction,
            // where intensity = mad(_OffsetDir.w, custom1Y, _OffsetIntensity) (b132:267 _496; _OffsetDir.w c13.w),
            // offsetTexR_remapped = mad(offsetTex.x, 1+_Bi_Offset, -_Bi_Offset) (b132:269 _573).
            // The source builds the offset in WORLD space (b132:270-276 _574/_575/_576, then added to the
            // world position _632/_633/_634) with the direction switched on _OffsetSwitchDir:
            //   1(World)  -> raw _OffsetDir.xyz, already WORLD-space (b132:270 _410-branch, _OffsetDir alias).
            //   2(Normal) -> object normal mul ObjectToWorld-3x3 (b132:271 _411-branch mad(_f_0[*], normal)).
            //   0(Object) -> _OffsetDir.xyz mul ObjectToWorld-3x3 (b132:272 else-branch mad(_f_0[*], _OffsetDir)).
            // _f_0[0..2] are the ObjectToWorld columns (same matrix URP exposes as unity_ObjectToWorld); the
            // matrix product is UNNORMALIZED -> TransformObjectToWorldDir(dir, /*doNormalize=*/false).
            // A uniform world-space scale _581 = 1 - unity_ObjectToWorld._m01 multiplies all three components
            // (b132:273 _581; b132:274-276 mad(_57x, _581, posWS)). For a particle/VFX identity-ish matrix
            // _m01 = 0 -> _581 = 1; reproduced exactly here. Returns the WORLD-space displacement (applied to
            // positionWS in VfxVert, NOT object space — that is what fixes the prior World-mode approximation:
            // displacing a raw world axis in OS would wrongly re-apply the object rotation/scale).
            float3 ComputeVertexOffsetWS(Attributes v, float time, float custom1Y)
            {
                float3 ofsWS = float3(0.0, 0.0, 0.0);
            #ifdef _USE_VERTOFFSET
                // Offset UV: choose UV0/UV1, scroll by _OffsetSpeed, *ST (b132:269 inner).
                // UV1 is the particle-rebuilt uv1 (b132:269 inner mad(TEXCOORD.zw,_InParticle,-custom)+customData),
                // NOT raw texcoord0.zw — identical when _InParticle=1, differs only when _InParticle=0.
                float custom1X = v.texcoord1.x * _InParticle;
                float2 uv1p = float2(mad(v.texcoord0.z, _InParticle, -custom1X) + v.texcoord1.x,
                                     mad(v.texcoord0.w, _InParticle, -custom1Y) + v.texcoord1.y);
                float2 ouv0 = (_OffsetUVSet < 0.5) ? v.texcoord0.xy : uv1p; // b132:269 lerp(uv0,uv1p,_OffsetUVSet)
                float2 ouv = mad(ouv0, _OffsetTex_ST.xy, _OffsetTex_ST.zw);
                ouv = mad(_OffsetSpeed.xy, time.xx, ouv);
                ouv = mad(_OffsetSpeed.zw, custom1Y.xx, ouv);
                float offR = SAMPLE_TEXTURE2D_LOD(_OffsetTex, sampler_OffsetTex, ouv, 0.0).x;
                float offRemap = mad(offR, 1.0 + _Bi_Offset, -_Bi_Offset);        // b132:269 _573
                float intensity = mad(_OffsetDir.w, custom1Y, _OffsetIntensity); // b132:267 _496 (_OffsetDir.w="By CustomY", c13.w; NOT _OffsetSpeed)
                float3 dirWS;
                if (1.0 == _OffsetSwitchDir)        // World: raw world-space axis (b132:270 _410-branch)
                    dirWS = _OffsetDir.xyz;
                else if (2.0 == _OffsetSwitchDir)   // Normal: ObjectToWorld-3x3 * objectNormal (b132:271 _411)
                    dirWS = TransformObjectToWorldDir(v.normalOS, false);
                else                                // Object: ObjectToWorld-3x3 * _OffsetDir (b132:272 else)
                    dirWS = TransformObjectToWorldDir(_OffsetDir.xyz, false);
                ofsWS = (offRemap * intensity) * dirWS; // b132:270-272 _574/_575/_576 (pre-_581)
                float scale581 = 1.0 + ((-0.0) - unity_ObjectToWorld._m01); // b132:273 _581 = 1 - M[col1].x
                ofsWS *= scale581;                      // b132:274-276 mad(_57x, _581, posWS)
            #endif
            #ifdef _USE_VERTOFFSETMASK
                // Offset mask scales the offset by mask power (source _OffsetMaskTex/_OffsetMaskPower).
                float2 muv = mad(v.texcoord0.xy, _OffsetMaskTex_ST.xy, _OffsetMaskTex_ST.zw);
                muv = mad(_OffsetMaskSpeed.xy, time.xx, muv);
                float offMask = SAMPLE_TEXTURE2D_LOD(_OffsetMaskTex, sampler_OffsetMaskTex, muv, 0.0).x;
                ofsWS *= (offMask * _OffsetMaskPower);
            #endif
                return ofsWS;
            }

            Varyings VfxVert(Attributes v)
            {
                Varyings o = (Varyings)0;
                float time = _Time.y; // replaces _VFXParams0.w (custom VFX time)
                float custom1Y = v.texcoord1.y * _InParticle;

                // Base object->world via URP, then displace in WORLD space (b132:274-276 add _57x to posWS).
                VertexPositionInputs pin = GetVertexPositionInputs(v.positionOS);
                float3 offsetWS = ComputeVertexOffsetWS(v, time, custom1Y);
                pin.positionWS += offsetWS;
                pin.positionCS  = TransformWorldToHClip(pin.positionWS);

                VertexNormalInputs   nin = GetVertexNormalInputs(v.normalOS, v.tangentOS);
                o.positionCS = pin.positionCS;
                o.positionWS = pin.positionWS;
                o.normalWS   = nin.normalWS;
                o.tangentWS  = float4(nin.tangentWS, v.tangentOS.w * GetOddNegativeScale()); // bitangent sign
                o.uv0uv1     = v.texcoord0;
                o.customData = v.texcoord1;
                o.vertColor  = v.color;
                return o;
            }

            // Build the (uv0, uv1, custom) particle UV set common to both passes (blob b125:102-103 inner).
            //   custom1X = customData.x * _InParticle ; custom1Y = customData.y * _InParticle
            //   uv0 = TEXCOORD.xy
            //   uv1 = mad(TEXCOORD.zw, _InParticle, -custom) + customData.xy
            void BuildParticleUVs(Varyings input, out float2 uv0, out float2 uv1,
                                  out float custom1X, out float custom1Y)
            {
                custom1X = input.customData.x * _InParticle;
                custom1Y = input.customData.y * _InParticle;
                uv0 = input.uv0uv1.xy;
                uv1 = float2(
                    mad(input.uv0uv1.z, _InParticle, -custom1X) + input.customData.x,
                    mad(input.uv0uv1.w, _InParticle, -custom1Y) + input.customData.y);
            }
        ENDHLSL

        // =====================================================================================
        // ForwardLit color pass — derived from the GBuffer base blob's SV_Target0.rgb
        // (b125 lines 102-119) and the feature deltas. The decompiled GBuffer wrote 5 MRTs
        // (color + packed normal / motion-vector / material-id); URP forward keeps only the
        // visible color. The octahedral-normal / MV / scene-effect-split MRTs collapse away
        // (see Removed in header) and are pixel-neutral for an unlit transparent VFX.
        // =====================================================================================
        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend]
            ZTest Equal
            ZWrite Off
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex VfxVert
            #pragma fragment frag
            #pragma shader_feature_local _USE_MAIN2
            #pragma shader_feature_local _USE_MASK
            #pragma shader_feature_local _USE_DISTURB
            #pragma shader_feature_local _USE_DISSOLVE
            #pragma shader_feature_local _USE_CUBEMAP
            #pragma shader_feature_local _USE_FRESNEL
            #pragma shader_feature_local _NORMAL_MAP
            #pragma shader_feature_local _USE_COLOR_GRADIENT
            #pragma shader_feature_local _USE_SCREENUV
            #pragma shader_feature_local _USE_POLARUV
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _USE_VERTOFFSETMASK

            // World-space tangent-frame normal from the normal map (blob b343:249-261).
            //   nx = (n.x*n.w*2-1)*_NormalScale ; ny = (n.y*2-1)*_NormalScale
            //   nz = max(sqrt(1 - min(dot(nx,ny),1)), 1e-16)   (then normalize the (nx,ny,nz) triple)
            //   N = T*nx_n + bitSign*cross(N,T)*ny_n + Ngeo*nz_n   (TBN), bitSign = tangent.w sign.
            float3 ApplyNormalMap(float3 Ngeo, float4 Tws, float2 nrmUV)
            {
            #ifdef _NORMAL_MAP
                float4 n = SAMPLE_TEXTURE2D(_NormalMap, sampler_NormalMap, nrmUV);
                float nx = mad(n.x * n.w, 2.0, -1.0);          // b343:249 _668
                float ny = mad(n.y, 2.0, -1.0);                // b343:250 _669
                float sx = nx * _NormalScale;                  // b343:251 _676
                float sy = ny * _NormalScale;                  // b343:252 _677
                float sz = max(sqrt(((-0.0) - min(dot(float2(nx, ny), float2(nx, ny)), 1.0)) + 1.0), TINY_Z); // b343:253 _682
                float inv = rsqrt(dot(float3(sx, sy, sz), float3(sx, sy, sz))); // b343:254 _687
                float tnx = inv * sx, tny = inv * sy, tnz = inv * sz;
                float bitSign = (0.0 < Tws.w) ? 1.0 : -1.0;    // b343:258 _697
                float3 B = bitSign * cross(Ngeo, Tws.xyz);     // bitangent
                // world normal = T*tnx + B*tny + Ngeo*tnz  (b343:259-261 _752/_753/_754)
                return Tws.xyz * tnx + B * tny + Ngeo * tnz;
            #else
                return Ngeo;
            #endif
            }

            half4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                float time = _Time.y; // replaces _VFXParams0.w

                float2 uv0, uv1; float custom1X, custom1Y;
                BuildParticleUVs(input, uv0, uv1, custom1X, custom1Y);
                float2 disturb = ComputeDisturb(uv0, uv1, time, custom1Y);

                // Optional PolarUV / ScreenUV coordinate generators routed into the weights.z/.w slots.
                float dist = LinearEyeDepth(input.positionCS.z, _ZBufferParams);
                float2 polar = float2(0.0, 0.0);
                float2 screen = float2(0.0, 0.0);
                #ifdef _USE_POLARUV
                    polar = ComputePolarUV(uv0); // (angle, radius), blob b369:223-235
                #endif
                #ifdef _USE_SCREENUV
                    screen = ComputeScreenUV(input.positionCS, dist); // blob b369:208-222
                #endif

                // ---- MainTex (blob b125:103; b343:228; b369:277). Scroll uses custom1X. ----
                float2 mainUV = ComputeVfxUV(uv0, uv1, _MainTexUVWeights, _MainTexUVSpeed,
                                             time, custom1X, _MainTexUVRotateMat, _MainTex_ST,
                                             screen, polar, disturb, _MainTexUseDisturb);
                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, mainUV);

                // Per-channel main color factor (blob b125:109-111):
                //   mainChan = mad(_UseMainTexAsAlpha, 1-rgb, rgb) == lerp(rgb, 1, _UseMainTexAsAlpha)
                float3 mainColorFactor = lerp(mainSample.rgb, 1.0.xxx, _UseMainTexAsAlpha);

                // Tint * vertex-color * intensity (blob b125:109-111):
                //   tintRGB = (mad(_DisableVertColor, 1-vc, vc) * _TintColor.rgb) * _TintColorIntensity
                float3 vcAdj   = lerp(input.vertColor.rgb, 1.0.xxx, _DisableVertColor);
                float3 tintRGB = (vcAdj * _TintColor.rgb) * _TintColorIntensity;

                // Base color = tint * main factor. (Main2 / Mask / ColorGradient modify below.)
                float3 baseRGB = tintRGB * mainColorFactor;

                // ---- Main Tex 2 (blob b129:133-152). RGB-only Multiply/Additive blend. ----
                //   m2  = lerp(main2.rgb, 1, _UseMainTex2AsAlpha) * _MainTex2Color.rgb
                //   out = lerp(A*m2, A+m2, _MainTex2BlendMode)   with A = tint*mainFactor
                //   (decompiled mad form: mad(mad(A, m2add?...) ...) ; verified Multiply when
                //    blend=0 -> A*m2 ; Additive when blend=1 -> A+m2, see b129:150 _369.)
                #ifdef _USE_MAIN2
                    float2 main2UV = ComputeVfxUV(uv0, uv1, _MainTex2UVWeights, _MainTex2UVSpeed,
                                                  time, custom1Y, _MainTex2UVRotateMat, _MainTex2_ST,
                                                  screen, polar, disturb, _MainTex2UseDisturb);
                    float4 main2Sample = SAMPLE_TEXTURE2D(_MainTex2, sampler_MainTex2, main2UV);
                    float3 m2 = lerp(main2Sample.rgb, 1.0.xxx, _UseMainTex2AsAlpha) * _MainTex2Color.rgb; // b129:146-148
                    baseRGB = lerp(baseRGB * m2, baseRGB + m2, _MainTex2BlendMode); // b129:150-152
                #endif

                // ---- Mask (source "Mask (只影响Alpha)" — ALPHA-ONLY; blob b517:140). ----
                // The Mask texture does NOT recolor the particle: the only `_USE_MASK`-keyworded blobs
                // that consume the mask (DepthOnly b517:140) fold a single factor
                //   maskA = lerp(mask.a, mask.r, _UseMaskTexAsAlpha)
                // into the particle OPACITY, never into RGB. (The RGB Multiply/Additive blend the prior
                // port applied here was actually the Main2 path of the COMBINED b343/b129 ParamBlob —
                // _USE_MASK is NOT in b343's keyword set — so blending mask into baseRGB was wrong.)
                // Compute maskA here (UVs share the same generator) and apply it to the output alpha below.
                float maskA = 1.0;
                #ifdef _USE_MASK
                    float2 maskUV = ComputeVfxUV(uv0, uv1, _MaskTexUVWeights, _MaskTexUVSpeed,
                                                 time, custom1Y, _MaskTexUVRotateMat, _MaskTex_ST,
                                                 screen, polar, disturb, _MaskTexUseDisturb);
                    float4 maskSample = SAMPLE_TEXTURE2D(_MaskTex, sampler_MaskTex, maskUV);
                    maskA = lerp(maskSample.a, maskSample.r, _UseMaskTexAsAlpha); // b517:140 _326/_323.x select
                #endif

                // ---- Color Gradient (blob b247:122-126). Vertical lerp _ColorBottom->_ColorTop. ----
                //   g = saturate((worldY - (center - range*0.5)) / range)   (b247:122 _205)
                //   factor = lerp(_ColorBottom, _ColorTop, g)   (b247:124-126 mad(_205, top-bottom, bottom))
                //   baseRGB *= factor
                #ifdef _USE_COLOR_GRADIENT
                    float gWorldY = input.positionWS.y;
                    float gLo = mad((-0.0) - _ColorGradientRange, 0.5, _ColorGradientCenter); // center - range*0.5  (b247:122)
                    float g = saturate((gWorldY + ((-0.0) - gLo)) / _ColorGradientRange);      // b247:122 _205
                    float3 grad = lerp(_ColorBottom.rgb, _ColorTop.rgb, g);                    // b247:124-126
                    baseRGB *= grad;
                #endif

                // ---- World normal (for CubeMap + Fresnel), with front/back flip ----
                // Nbase = the PRE-face-flip world normal (blob _677/_678/_679 = TBN-mapped normal, or the
                //   geometric normal when no normal map). The CubeMap reflection uses THIS un-flipped
                //   normal (b369:274 reflects through _677); Fresnel uses the FACE-FLIPPED Ngeo (_762).
                float3 Nbase = input.normalWS;
                float4 tangentWS = input.tangentWS;
                #ifdef _NORMAL_MAP
                    float2 nrmUV = ComputeVfxUV(uv0, uv1, _NormalMapUVWeights, _NormalMapUVSpeed,
                                                time, custom1Y, _NormalMapUVRotateMat, _NormalMap_ST,
                                                screen, polar, disturb, _NormalMapUseDisturb); // b343:248 own ST
                    Nbase = ApplyNormalMap(input.normalWS, tangentWS, nrmUV); // b369:257-259 _677/_678/_679 (pre-flip)
                #endif
                float3 Ngeo = isFrontFace ? Nbase : -Nbase; // b343:262-265 / b369:271-273 face flip (_762/_763/_764)

                // View direction (perspective): V = normalize(camPos - P)  (blob b369:260-267).
                float3 Vraw = _WorldSpaceCameraPos - input.positionWS;
                float3 V = Vraw * rsqrt(max(dot(Vraw, Vraw), NEAR_ZERO)); // b369:264-267

                // ---- CubeMap reflection (blob b369:268-274,281-283). RGB-only add. ----
                //   R = reflect(-V, N) = -V - 2*dot(-V,N)*N  (b369:268-274 via _723 = -2*dot(V_neg,N))
                //   NOTE: the source reflects through the PRE-face-flip normal Nbase (_677/_678/_679),
                //   NOT the face-flipped Ngeo — so two-sided particles reflect identically on both faces.
                //   color += cube.rgb * _CubeMapColor.rgb   (b369:281-283 added through the mad's 3rd arg)
                #ifdef _USE_CUBEMAP
                    float ndv = dot(-V, Nbase);                // b369:268 _719 (uses un-flipped _677)
                    float k = (-0.0) - (ndv + ndv);            // b369:269 _723
                    float3 R = mad(Nbase, k.xxx, -V);          // b369:274 reflect vector through _677
                    float3 cube = SAMPLE_TEXTURECUBE(_CubeMap, sampler_CubeMap, R).rgb; // b369:274 _744
                    baseRGB += cube * _CubeMapColor.rgb;       // b369:281-283
                #endif

                // ---- Dissolve (1:1, isolated COLOR-pass dissolve blob b173:142-146; alpha edge b481:144). ----
                // TWO distinct quantities ride the SAME dissolve texture (both isolated, both verified):
                //   threshold = mad(mad(customData.z*_InParticle, _DissolveScheduleOffset), 2.02, -1.01)
                //               (b173:142 / b481:144 inner mad — identical across passes)
                //   (a) ALPHA edge  (DepthOnly opacity, b481:144 _418 inner):
                //         alphaEdge = saturate((dissolve.r - threshold) * _DissolveEdgeSharp)   [POSITIVE, no bias]
                //       -> multiplies particle opacity (kept where dissolve.r > threshold). Used in the alpha block.
                //   (b) EMISSIVE band (COLOR rim, b173:142 _329 — the isolated _USE_DISSOLVE GBuffer):
                //         emissiveBand = saturate((threshold - dissolve.r + _DissolveEmissiveEdge) * _DissolveEdgeSharp)
                //       i.e. the COMPLEMENT of the alpha edge, biased OUT by _DissolveEmissiveEdge — a band that
                //       lights up just inside the dissolving boundary. This is NOT a decompiler folding: the
                //       inverted `-(dissolve.r-threshold)+W` sign + the `W=_DissolveEmissiveEdge` bias are the
                //       clean expression (cross-checked b173:142 AND b343:280 _925 — two independent ParamBlobs).
                //   color blend (b173:144-146 _370/_372/_373 / b343:282-284 _966/_968/_969):
                //         mad(e, mad(e*emissive_c, _TintColorIntensity, -base_c), base_c)
                //       = base_c*(1 - e) + e*e * _DissolveEmissiveColor_c * _TintColorIntensity   (e = emissiveBand)
                //       applied BEFORE the post-exposure divide (matches blob: the mad(...) feeds the /exposure).
                float dissolveEdge = 1.0; // (a) alpha edge, exported to the opacity block below
                #ifdef _USE_DISSOLVE
                    float2 dissolveUV = ComputeVfxUV(uv0, uv1, _DissolveUVWeights, _DissolveUVSpeed,
                                                     time, custom1Y, _DissolveUVRotateMat,
                                                     _DissolveTex_ST, screen, polar,
                                                     disturb, _DissolveTexUseDisturb);
                    float4 dissolveSample = SAMPLE_TEXTURE2D(_DissolveTex, sampler_DissolveTex, dissolveUV);
                    float dissolveThreshold = mad(
                        mad(input.customData.z, _InParticle, _DissolveScheduleOffset),
                        2.019999980926513671875, -1.0099999904632568359375);   // b173:142 / b481:144 threshold
                    dissolveEdge = saturate((dissolveSample.r + ((-0.0) - dissolveThreshold)) * _DissolveEdgeSharp); // b481:144 alpha edge
                    // (b) emissive band = saturate((threshold - dissolve.r + _DissolveEmissiveEdge) * _DissolveEdgeSharp). b173:142 _329
                    float emissiveBand = saturate((((-0.0) - (dissolveSample.r + ((-0.0) - dissolveThreshold))) + _DissolveEmissiveEdge) * _DissolveEdgeSharp);
                    // color = base*(1-band) + band^2 * emissive * _TintColorIntensity. b173:144-146 / b343:282-284
                    baseRGB = mad(emissiveBand.xxx,
                                  mad((emissiveBand * _TintColorIntensity).xxx, _DissolveEmissiveColor.rgb, -baseRGB),
                                  baseRGB);
                #endif

                // ---- Fresnel (blob b127:125-143, the isolated Fresnel-only HGBuffer = ground truth). ----
                //   rim    = saturate(dot(N, V) + _FresnelBias)       (b127:125 _208 inner; N = face-flipped)
                //   f      = pow(rim, _FresnelPower)                  (b127:125 _208 = exp2(log2(rim)*power))
                //   ff     = lerp(1-f, f, _FresnelFlip)              (b127:127 _220 inner; flip=0 default -> 1-f)
                //   factor = ff * _FresnelColor.a                     (b127:127 _220 * _Globals_FresnelColor.w)
                //            NOTE: the COLOR blend uses _FresnelColor.a only — _FresnelAffectOpacity is alpha-only.
                //   color  = lerp(color, _FresnelColor.rgb, factor)  (b127:141-143 _428/_430/_431)
                #ifdef _USE_FRESNEL
                    float rim = saturate(dot(Ngeo, V) + _FresnelBias);     // b127:125 _208 inner / b343:274 _886
                    float f = exp2(log2(rim) * _FresnelPower);             // b127:125 _208 = pow(rim, power)
                    // 1:1 (b127:126-127 / b343:275-276): _210/_888 = 1-f ;
                    //   _220/_898 = mad(_FresnelFlip, f-(1-f), 1-f) * _FresnelColor.a = lerp(1-f, f, _FresnelFlip)*colorA.
                    //   At _FresnelFlip=0 (default 0.001) the factor is (1-f) — a rim bright at grazing angles.
                    float fLerp = lerp(1.0 - f, f, _FresnelFlip);          // b127:127 / b343:276 _898 inner
                    float factor = fLerp * _FresnelColor.a;                 // b127:127 / b343:276 _898 * colorA
                    baseRGB = lerp(baseRGB, _FresnelColor.rgb, factor);     // b127:141-143 / b343:277-279 lerp(base, color, factor)
                #endif

                // ---- Post-exposure divide + clamp (blob b125:108-111). ----
                //   exposureScale = mad(_ExposureParams.x, _IgnorePostExposure, 1-_IgnorePostExposure)
                //   color = clamp(color / exposureScale, 0, 1000)
                float exposureScale = mad(_ExposureParams.x, _IgnorePostExposure, 1.0 + ((-0.0) - _IgnorePostExposure)); // b125:108 _240
                float3 color = clamp(baseRGB / exposureScale, 0.0.xxx, 1000.0.xxx); // b125:109-111

                // Output alpha: the GBuffer color pass writes alpha = 0.5 constant (blob b125:119).
                // For URP transparent blending we want the particle's procedural alpha so the color
                // pass blends correctly (the dither/depth is handled by the DepthOnly pass). Compute
                // the same alpha the DepthOnly pass uses (blob b465:113 inner), gated to surface type.
                float mainA = lerp(mainSample.a, mainSample.r, _UseMainTexAsAlpha);
                float vcA   = lerp(input.vertColor.a, 1.0, _DisableVertColor);
                float alpha = mainA * (vcA * _TintColor.a) * _TintColorAlpha; // b465:113 / b517:140
                alpha *= maskA;                                               // b517:140 mask is alpha-only
                #ifdef _USE_DISSOLVE
                    alpha *= dissolveEdge;
                #endif
                // Near-camera fade is part of the particle opacity (blob b465/b467:134); when off, factor=1.
                // Reuses `dist` (eye depth) computed above for the ScreenUV generator.
                if (_UseNearCameraFade != 0.0)
                {
                    float fadeOuter = saturate((dist + ((-0.0) - _NearCameraFadeDistanceEnd2))
                                               / (((-0.0) - _NearCameraFadeDistanceEnd2) + _NearCameraFadeDistanceStart2));
                    float fadeInner = saturate((dist + ((-0.0) - _NearCameraFadeDistanceStart))
                                               / (((-0.0) - _NearCameraFadeDistanceStart) + _NearCameraFadeDistanceEnd));
                    alpha *= fadeOuter * fadeInner;                          // b467:134 two-ramp product
                }
                #ifdef _USE_FRESNEL
                    // Fresnel affect-opacity (blob b467:134): the alpha is scaled by the SAME flip-adjusted
                    // rim used for the color blend, then lerped toward 1 by _FresnelAffectOpacity:
                    //   ff     = lerp(1-f, f, _FresnelFlip)               (b467:134 inner mad)
                    //   factor = lerp(1, ff, _FresnelAffectOpacity)        (b467:134 outer mad)
                    float fA   = exp2(log2(saturate(dot(Ngeo, V) + _FresnelBias)) * _FresnelPower); // f = pow(rim, power)
                    float ffA  = lerp(1.0 - fA, fA, _FresnelFlip);          // b467:134 mad(_FresnelFlip, f-(1-f), 1-f)
                    alpha *= lerp(1.0, ffA, _FresnelAffectOpacity);         // b467:134 mad(ff, _FresnelAffectOpacity, 1-_FresnelAffectOpacity)
                #endif
                alpha = (_SurfaceType == 1.0) ? alpha : 1.0;

                return half4(color, alpha);
            }
            ENDHLSL
        }

        // =====================================================================================
        // DepthOnly + dither alpha-clip — derived from the DepthOnly base blob (b465).
        // This is the load-bearing pass: it computes the particle's procedural opacity and
        // stochastically discards fragments via an interleaved-gradient screen dither so the
        // transparent VFX participates in the depth buffer as a stipple.
        // =====================================================================================
        Pass
        {
            Name "DepthOnly"
            Tags { "LightMode" = "DepthOnly" }
            ZTest LEqual
            ZWrite On
            ColorMask 0
            Cull [_CullMode]
            Stencil
            {
                Ref       [_StencilRef]
                ReadMask  [_StencilReadMask]
                WriteMask [_StencilWriteMask]
                Comp      Always
                Pass      Replace
                Fail      Keep
                ZFail     Keep
            }

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex VfxVert
            #pragma fragment frag
            #pragma shader_feature_local _USE_MASK
            #pragma shader_feature_local _USE_DISTURB
            #pragma shader_feature_local _USE_DISSOLVE
            #pragma shader_feature_local _USE_SCREENUV
            #pragma shader_feature_local _USE_POLARUV
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _USE_VERTOFFSETMASK

            // Near-camera distance fade (blob b465:113 outer, two saturating ramps over view dist):
            //   inner = saturate((dist - Start) / (End  - Start))
            //   outer = saturate((dist - End2)  / (Start2 - End2))   (fades IN over End2..Start2)
            // (the four edges are aliased out of the _Mask*/_Dissolve* slots in b465:113; named here
            //  by their true semantics, cite order gate,Start,End,End2,Start2.)
            float NearCameraFade(float dist)
            {
                float outer = saturate((dist + ((-0.0) - _NearCameraFadeDistanceEnd2))
                                       / (((-0.0) - _NearCameraFadeDistanceEnd2) + _NearCameraFadeDistanceStart2));
                float inner = saturate((dist + ((-0.0) - _NearCameraFadeDistanceStart))
                                       / (((-0.0) - _NearCameraFadeDistanceStart) + _NearCameraFadeDistanceEnd));
                return outer * inner;
            }

            void frag(Varyings input)
            {
                float time = _Time.y; // replaces _VFXParams0.w

                float2 uv0, uv1; float custom1X, custom1Y;
                BuildParticleUVs(input, uv0, uv1, custom1X, custom1Y);
                float2 disturb = ComputeDisturb(uv0, uv1, time, custom1Y);

                // View-space camera distance (blob b465:105-112): the decompiler reconstructs world
                // pos from screen UV + depth via _InvViewProjMatrix, then takes |view-space Z| via
                // _ViewMatrix row2. URP gives the identical quantity directly from device depth.
                float dist = LinearEyeDepth(input.positionCS.z, _ZBufferParams); // b465:112 _280

                float2 polar = float2(0.0, 0.0);
                float2 screen = float2(0.0, 0.0);
                #ifdef _USE_POLARUV
                    polar = ComputePolarUV(uv0);
                #endif
                #ifdef _USE_SCREENUV
                    screen = ComputeScreenUV(input.positionCS, dist);
                #endif

                // MainTex (blob b465:109). Scroll uses custom1X.
                float2 mainUV = ComputeVfxUV(uv0, uv1, _MainTexUVWeights, _MainTexUVSpeed,
                                             time, custom1X, _MainTexUVRotateMat, _MainTex_ST,
                                             screen, polar, disturb, _MainTexUseDisturb);
                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, mainUV);

                // Base procedural alpha (blob b465:113 inner-most factor):
                //   mainA = mad(_UseMainTexAsAlpha, mainSample.r - mainSample.a, mainSample.a)  (lerp a->r)
                //   alpha = mainA * (mad(_DisableVertColor,1-vc.a,vc.a) * tint.a) * _TintColorAlpha
                float mainA  = lerp(mainSample.a, mainSample.r, _UseMainTexAsAlpha); // b465:111-113
                float vcA    = lerp(input.vertColor.a, 1.0, _DisableVertColor);
                float alpha  = mainA * (vcA * _TintColor.a) * _TintColorAlpha;       // b465:113

                // ==== MASK (blob b465:113 _UseMaskTexAsAlpha-gated factor) ====
                //   maskA = mad(_UseMaskTexAsAlpha, mask.r - mask.a, mask.a)  (lerp a->r)
                //   the base blob folds a product of two saturating dissolve-style ramps when masking;
                //   1:1 the mask path multiplies maskA into alpha (b465:113 the inner ternary product).
                #ifdef _USE_MASK
                    float2 maskUV = ComputeVfxUV(uv0, uv1, _MaskTexUVWeights, _MaskTexUVSpeed,
                                                 time, custom1Y, _MaskTexUVRotateMat, _MaskTex_ST,
                                                 screen, polar, disturb, _MaskTexUseDisturb);
                    float4 maskSample = SAMPLE_TEXTURE2D(_MaskTex, sampler_MaskTex, maskUV);
                    float maskA = lerp(maskSample.a, maskSample.r, _UseMaskTexAsAlpha);
                    alpha *= maskA;
                #endif

                // ==== DISSOLVE (blob b465 _USE_DISSOLVE delta) ====
                #ifdef _USE_DISSOLVE
                    float2 dissolveUV = ComputeVfxUV(uv0, uv1, _DissolveUVWeights, _DissolveUVSpeed,
                                                     time, custom1Y, _DissolveUVRotateMat,
                                                     _DissolveTex_ST, screen, polar,
                                                     disturb, _DissolveTexUseDisturb);
                    float4 dissolveSample = SAMPLE_TEXTURE2D(_DissolveTex, sampler_DissolveTex, dissolveUV);
                    float dissolveThreshold = mad(
                        mad(input.customData.z, _InParticle, _DissolveScheduleOffset),
                        2.019999980926513671875, -1.0099999904632568359375);
                    float dissolveEdge = saturate((dissolveSample.r + ((-0.0) - dissolveThreshold)) * _DissolveEdgeSharp);
                    alpha *= dissolveEdge;
                #endif

                // Near-camera fade (blob b465:113): gated by _UseNearCameraFade. When off, factor = 1.
                if (_UseNearCameraFade != 0.0)
                {
                    alpha *= NearCameraFade(dist);
                }

                // Dither-alpha exponent (blob b465:113 outer):
                //   a = pow(saturate(alpha * (1 - _unity_LODFade.y)), _DitherAlphaExp)
                // The decompiled expression ends at `* _MaskTexUVSpeed.y` (= _DitherAlphaExp); there is
                // NO trailing `* _ProcedureAlpha` (not in the b465 cbuffer). _unity_LODFade is URP LOD
                // crossfade (1 when not crossfading -> factor 1). exp2(log2(clamp(.,0,1)) * exp) == pow.
                float lodScale = 1.0; // (1 - _unity_LODFade.y); URP applies crossfade via its own keyword
                float ditheredAlpha = exp2(log2(clamp(alpha * lodScale, 0.0, 1.0)) * _DitherAlphaExp); // b465:113 _329

                // Interleaved-gradient screen dither threshold (blob b465:114):
                //   n = frac(frac(dot(fragXY*_DitherTilling + frameJitter, k)) * 52.98291778564453)
                //   k = float2(0.06711056, 0.00583715)
                // _TaaFrameInfo.z was the per-frame temporal offset; dropped (no TAA in URP forward).
                float2 fragXY = input.positionCS.xy;
                float2 hashIn = mad(fragXY, _DitherTilling.xx, 0.0.xx); // b465:114 (fragCoord*_MaskTexUVSpeed.x alias = _DitherTilling)
                float noise = frac(frac(dot(hashIn, float2(0.067110560834407806396484375,
                                                           0.005837149918079376220703125)))
                                   * 52.98291778564453125); // b465:114 _351

                // Discard when ditheredAlpha < signedNoise (blob b465:115). ditheredAlpha >= 0,
                // so the sign branch reduces to a plain `ditheredAlpha < noise` clip.
                float signedNoise = (ditheredAlpha >= 0.0) ? noise : -noise; // b465:115
                clip(ditheredAlpha - signedNoise);
            }
            ENDHLSL
        }
    }
}
