// HGRP VFX Water-Dither (Alpha) — particle/VFX surface with screen-space ordered-dither alpha test.
//   GBuffer pass  -> color out (tint * intensity / post-exposure), front/back normal sign.
//   DepthOnly pass -> the defining feature: per-pixel interleaved-gradient dither clip on the
//                     particle's procedural opacity (so transparent water reads/writes depth as a
//                     stochastic stipple instead of writing a hard alpha).
//
// Merged from: vfxwaterdither.shader (HGRP/Effect/VFXWaterDitherAlpha)
//   GBuffer  base blob: vfxwaterdither/Sub0_Pass0_Fragment_b15.hlsl  (+ Sub0_Pass0_Vertex_b14.hlsl)
//   DepthOnly base blob: vfxwaterdither/Sub0_Pass1_Fragment_b61.hlsl (+ Sub0_Pass1_Vertex_b60.hlsl)
//   Feature deltas: Pass1 _USE_DISSOLVE b65, _USE_MASK b69, _USE_DISTURB b63.
//
// Keywords: _USE_MASK, _USE_DISTURB, _USE_DISSOLVE
// Kept: particle-aware UV (UV-channel weights + time/custom scroll + 2x2 rotate + ST + disturb),
//   MainTex sample, tint/vertex-color/intensity, ignore-post-exposure scale, near-camera distance
//   fade (reconstructed view-space depth), mask alpha, dissolve edge (with disturb), and the
//   screen-space ordered-dither alpha clip (IGN hash threshold + _DitherAlphaExp pow on the
//   saturated alpha). Octahedral front/back normal sign preserved as plain face flip.
// Removed (pixel-neutral HGRP infra substituted by URP): the packed-MRT GBuffer encode
//   (SV_Target_1/2/3 = packed octahedral normal / motion-vector / material-id buffers — URP forward
//   has no deferred MRT here; normals are emitted by URP's own DepthNormals prepass), HG_ENABLE_MV
//   prev-frame motion-vector reprojection (_PrevNonJittered* / _PrevCamPosRWS), TAA jitter
//   (_TaaJitterStrength), GPU-skinning / packed-octahedral vertex normal unpack (spvBitfield*),
//   SRP per-draw instancing array, manual VP/InvVP/View matrices, _GlobalMipBias, _VFXParams0.w
//   (custom VFX time -> URP _Time.y), _ScreenSize (-> _ScreenParams). DepthOnly's manual
//   InvViewProj depth-reconstruction is replaced by URP LinearEyeDepth.
// Closed scene-effect split (was dropped): the GBuffer visible color now applies the
//   (1 - _UseSceneEffect) complement (blob b15:104-107); the complementary share went to a SECOND
//   MRT (SV_Target_4 = _UseSceneEffect * color, b15:108-110) which stays engine-side (needs a host
//   render-feature to bind the scene-effect MRT) — only that extra MRT write is unported.
//
// NOTE: This VFX family ALIASES the same float4 uniforms differently per pass (the decompiler's
//   ParamBlob remap). In the DepthOnly/dither pass the blob reads dither/fade constants out of the
//   _Mask*/_Dissolve* slots; we name each URP uniform by its TRUE inspector semantic
//   (_DitherTilling = c13.x, _DitherAlphaExp = c13.y, _NearCameraFade* group, _DissolveScheduleOffset)
//   and cite the blob slot it came from. NOTE _ProcedureAlpha is a source [HideInInspector] property
//   but the DepthOnly base/delta blobs (b61/b63/b65/b69) never read it — the dither alpha is
//   pow(saturate(alpha), _DitherAlphaExp) with NO _ProcedureAlpha factor (it is not in the b61
//   cbuffer at all). _MainUVSet/_MaskUVSet PolarUV(2)/ScreenUV(3) branches collapse to the UV0/UV1
//   weight blend the base blobs actually compile (weights.x=UV0, weights.y=UV1).

Shader "HGRP/Effect/VFXWaterDither_Fix"
{
    Properties
    {
        [Header(Base)]
        [Enum(Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableVertColor ("Disable VertColor", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 1
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        [ToggleUI] _UseSceneEffect ("Is SceneEffect", Float) = 0
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

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask (alpha only)", Float) = 0
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

        [Header(Near Camera Fade)]
        [ToggleUI] _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Start 1", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Fade End 1", Range(0.001, 3000)) = 10
        _NearCameraFadeDistanceEnd2 ("Fade End 2", Range(0.002, 3000)) = 100
        _NearCameraFadeDistanceStart2 ("Fade Start 2", Range(0.001, 3000)) = 120

        // Render-state plumbing (driven by a material editor / OnValidate, not the shader)
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _StencilReadMask ("__stencilReadMask", Float) = 255
        [HideInInspector] _StencilWriteMask ("__stencilWriteMask", Float) = 255
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 0
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
                float  _UseSceneEffect;
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
                float4 _DissolveUVSpeed;
                float4 _DissolveUVRotateMat;
                float4 _DissolveUVWeights;
                float4 _DissolveTex_ST;
                // Near camera fade
                float  _UseNearCameraFade;
                float  _NearCameraFadeDistanceStart;
                float  _NearCameraFadeDistanceEnd;
                float  _NearCameraFadeDistanceEnd2;
                float  _NearCameraFadeDistanceStart2;
                // Render state
                float  _TransparentSortPriority;
            CBUFFER_END

            TEXTURE2D(_MainTex);     SAMPLER(sampler_MainTex);
            TEXTURE2D(_MaskTex);     SAMPLER(sampler_MaskTex);
            TEXTURE2D(_DisturbTex1); SAMPLER(sampler_DisturbTex1);
            TEXTURE2D(_DissolveTex); SAMPLER(sampler_DissolveTex);

            // ---- Particle-aware UV (GBuffer blob b15 line 95; DepthOnly blob b61 line 103) ----
            // 1:1 with the decompiled inner expression:
            //   coord = (UV0*weights.x + UV1*weights.y) + speed.xy*time + speed.zw*custom
            //   c     = coord - 0.5;  rot.x = c.x*M.x + c.y*M.z;  rot.y = c.x*M.y + c.y*M.w
            //   uv    = (rot + 0.5) * ST.xy + ST.zw  (+ disturb*useDisturb)
            // In the blobs UV0 = TEXCOORD.xy, and UV1 is rebuilt particle-side as
            //   UV1 = mad(TEXCOORD.zw, _InParticle, -custom) + customData  (blob b15 line 95 inner).
            float2 ComputeVfxUV(float2 uv0, float2 uv1, float4 weights, float4 speed,
                                float time, float custom, float4 rotateMat, float4 st,
                                float2 disturb, float useDisturb)
            {
                float2 coord = uv0 * weights.x + uv1 * weights.y;
                coord = mad(speed.xy, time.xx, coord);
                coord = mad(speed.zw, custom.xx, coord);
                float2 c = coord + (-0.5).xx;
                float2 rot;
                rot.x = mad(c.x, rotateMat.x, c.y * rotateMat.z);
                rot.y = mad(c.x, rotateMat.y, c.y * rotateMat.w);
                float2 uv = mad(rot + 0.5.xx, st.xy, st.zw);
                return mad(disturb, useDisturb.xx, uv);
            }

            // Disturb offset (GBuffer/DepthOnly disturb delta, blob b63 lines 124-127).
            // biDisturb remaps [0,1]->[-1,1] when _Bi_Disturb=1: mad(s.x, 1+_Bi_Disturb, -_Bi_Disturb).
            // Normal-mode (s is a normal map): x = mad(biDisturb*s.w, 2,-1); y = mad(s.y, 2,-1).
            float2 ComputeDisturb(float2 uv0, float2 uv1, float time, float custom)
            {
                float2 d = float2(0.0, 0.0);
            #ifdef _USE_DISTURB
                float2 dUV = ComputeVfxUV(uv0, uv1, _DisturbUVWeights1, _DisturbUVSpeed1,
                                          time, custom, _DisturbUVRotateMat1, _DisturbTex1_ST,
                                          float2(0.0, 0.0), 0.0);
                float4 s = SAMPLE_TEXTURE2D(_DisturbTex1, sampler_DisturbTex1, dUV);
                float biDisturb = mad(s.x, 1.0 + _Bi_Disturb, -_Bi_Disturb);
                bool normalMode = (0.0 != _DisturbTex1Normal);
                d.x = normalMode ? (mad(biDisturb * s.w, 2.0, -1.0) * _DisturbUIntensity1)
                                 : (biDisturb * _DisturbUIntensity1);
                d.y = normalMode ? (mad(s.y, 2.0, -1.0) * _DisturbUIntensity1)
                                 : (biDisturb * _DisturbVIntensity1);
            #endif
                return d;
            }

            // ---- Shared particle interpolants -------------------------------------------------
            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0; // UV0 in .xy, UV1 in .zw (particle)
                float4 texcoord1  : TEXCOORD1; // particle custom data
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float4 uv0uv1     : TEXCOORD0; // pass-through texcoord0
                float4 customData : TEXCOORD1; // pass-through texcoord1
                float4 vertColor  : TEXCOORD2;
                float3 normalWS   : TEXCOORD3;
                float3 positionWS : TEXCOORD4;
            };

            Varyings VfxVert(Attributes v)
            {
                Varyings o = (Varyings)0;
                VertexPositionInputs pin = GetVertexPositionInputs(v.positionOS);
                o.positionCS = pin.positionCS;
                o.positionWS = pin.positionWS;
                o.normalWS   = TransformObjectToWorldNormal(v.normalOS);
                o.uv0uv1     = v.texcoord0;
                o.customData = v.texcoord1;
                o.vertColor  = v.color;
                return o;
            }

            // Build the (uv0, uv1, custom) particle UV set common to both passes.
            // (blob b15 line 95 inner / blob b61 line 103 inner)
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
        // Color pass — derived from the GBuffer base blob's SV_Target.rgb (b15 lines 94-111).
        // The decompiled GBuffer wrote 5 MRTs (color + packed normal/MV/material-id); URP forward
        // keeps only the visible color. Octahedral normal-sign write (SV_Target_3) collapses to a
        // plain front/back face flip (b15 lines 125-140) which is pixel-neutral for an unlit VFX.
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
            #pragma shader_feature_local _USE_MASK
            #pragma shader_feature_local _USE_DISTURB

            half4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                float time = _Time.y; // replaces _VFXParams0.w (custom VFX time)

                float2 uv0, uv1; float custom1X, custom1Y;
                BuildParticleUVs(input, uv0, uv1, custom1X, custom1Y);
                float2 disturb = ComputeDisturb(uv0, uv1, time, custom1Y);

                // MainTex (blob b15 line 95-96; MainTex scroll uses custom1X)
                float2 mainUV = ComputeVfxUV(uv0, uv1, _MainTexUVWeights, _MainTexUVSpeed,
                                             time, custom1X, _MainTexUVRotateMat, _MainTex_ST,
                                             disturb, _MainTexUseDisturb);
                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, mainUV);

                // Per-channel RGB color (blob b15 lines 100-103):
                //   rgb_chan = mad(_UseMainTexAsAlpha, 1-mainChan, mainChan)
                //            * (mad(_DisableVertColor, 1-vc, vc) * tint) * _TintColorIntensity
                // mad(flag, (-x)+1, x) == lerp(x, 1, flag).
                float3 mainColorFactor = lerp(mainSample.rgb, 1.0.xxx, _UseMainTexAsAlpha);
                float3 vcAdj           = lerp(input.vertColor.rgb, 1.0.xxx, _DisableVertColor);
                float3 baseRGB = mainColorFactor * (vcAdj * _TintColor.rgb) * _TintColorIntensity;

                // Post-exposure divide (blob b15 lines 100-103):
                //   exposureScale = mad(_ExposureParams.x, _IgnorePostExposure, 1-_IgnorePostExposure)
                //   color = clamp(baseRGB / exposureScale, 0, 1000)
                float exposureScale = mad(_ExposureParams.x, _IgnorePostExposure, 1.0 - _IgnorePostExposure);
                float3 color = clamp(baseRGB / exposureScale, 0.0.xxx, 1000.0.xxx);

                // Mask only touches alpha in the dither pass; in the GBuffer color path the base
                // blob does not modulate color by mask, so _USE_MASK adds no color term here.
                #ifdef _USE_MASK
                #endif

                // Front/back face normal sign (blob b15 lines 125-140) -> pixel-neutral for unlit.
                float3 faceNormal = isFrontFace ? input.normalWS : -input.normalWS;

                // Scene-effect color split (blob b15 lines 104-110). The base blob writes the
                // visible color to SV_Target.rgb scaled by the complement of the scene-effect
                // factor (c13.z, aliased _MaskTexUVSpeed.z in the GBuffer ParamBlob, true semantic
                // _UseSceneEffect), and routes the complementary share to a SECOND MRT:
                //   _257 = 1 - _UseSceneEffect          (b15:104)
                //   SV_Target.rgb   = _257 * color      (b15:105-107)  <- the visible color we emit
                //   SV_Target_4.rgb = _UseSceneEffect * color  (b15:108-110) <- engine-side MRT
                // 1:1, source = Sub0_Pass0_Fragment_b15.hlsl:104-107. When _UseSceneEffect=0 (default)
                // this is (1 - 0) * color = full color, matching the prior behaviour exactly; a
                // scene-effect material (_UseSceneEffect=1) now correctly drops the visible color to 0.
                color = (1.0 - _UseSceneEffect) * color;

                // TODO(engine-side): SV_Target_4.rgb = _UseSceneEffect * color (blob b15:108-110) is a
                //   SECOND render target (HGRP's scene-effect / motion-vector MRT). URP forward has no
                //   such target; emitting it requires a host ScriptableRenderFeature that allocates the
                //   scene-effect color buffer and binds it as MRT1 for this pass. Material-side math
                //   (the complement above) is fully closed; only the extra MRT write is host-dependent.

                // The GBuffer color pass writes alpha = 0.5 constant (blob b15 line 111).
                return half4(color, 0.5);
            }
            ENDHLSL
        }

        // =====================================================================================
        // DepthOnly + dither alpha-clip — derived from the DepthOnly base blob (b61).
        // This is the load-bearing pass: it computes the particle's procedural opacity and
        // stochastically discards fragments via an interleaved-gradient screen dither so the
        // transparent water participates in the depth buffer as a stipple.
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

            // Near-camera distance fade (blob b61 line 107):
            //   product of two saturating ramps over the view-space camera distance `dist`.
            //   In the base blob the four edges are aliased out of the _Mask*/_Dissolve* slots;
            //   here they are the real _NearCameraFade* uniforms. The cbuffer declaration order
            //   (proven by b65:133 / b61:107 c-slot order: gate, Start, End, End2, Start2) gives:
            //     inner = saturate((dist - Start) / (End  - Start))      // b61:107 ramp on c11.y,c11.z
            //     outer = saturate((dist - End2)  / (Start2 - End2))     // b61:107 ramp on c11.w,c12.x
            //   NOTE the outer ramp's lo edge is End2 and its span is (Start2 - End2): with defaults
            //   End2=100, Start2=120 it fades IN over 100..120 (matches the decompiled
            //   (dist - p3)/(p4 - p3) form exactly), it is NOT (dist - Start2)/(End2 - Start2).
            float NearCameraFade(float dist)
            {
                float outer = saturate((dist - _NearCameraFadeDistanceEnd2)
                                       / (_NearCameraFadeDistanceStart2 - _NearCameraFadeDistanceEnd2));
                float inner = saturate((dist - _NearCameraFadeDistanceStart)
                                       / (_NearCameraFadeDistanceEnd - _NearCameraFadeDistanceStart));
                return outer * inner;
            }

            void frag(Varyings input)
            {
                float time = _Time.y; // replaces _VFXParams0.w

                float2 uv0, uv1; float custom1X, custom1Y;
                BuildParticleUVs(input, uv0, uv1, custom1X, custom1Y);
                float2 disturb = ComputeDisturb(uv0, uv1, time, custom1Y);

                // MainTex (blob b61 line 103). MainTex scroll uses custom1X.
                float2 mainUV = ComputeVfxUV(uv0, uv1, _MainTexUVWeights, _MainTexUVSpeed,
                                             time, custom1X, _MainTexUVRotateMat, _MainTex_ST,
                                             disturb, _MainTexUseDisturb);
                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, mainUV);

                // Base procedural alpha (blob b61 line 107 inner-most factor):
                //   mainA = mad(_UseMainTexAsAlpha, 1-mainSample.a, mainSample.a)   (lerp a->1)
                //   alpha = mainA * (mad(_DisableVertColor,1-vc.a,vc.a) * tint.a) * _TintColorAlpha
                float mainA  = lerp(mainSample.a, mainSample.r, _UseMainTexAsAlpha);
                float vcA    = lerp(input.vertColor.a, 1.0, _DisableVertColor);
                float alpha  = mainA * (vcA * _TintColor.a) * _TintColorAlpha;

                // View-space camera distance (blob b61 lines 99-106): the decompiler reconstructs
                // world pos from screen UV + depth via _InvViewProjMatrix, then takes |view-space Z|
                // via _ViewMatrix row2. URP gives the identical quantity directly from device depth.
                float dist = LinearEyeDepth(input.positionCS.z, _ZBufferParams);

                // ==== MASK (blob b69 line 129) ====
                // alpha *= mad(_UseMaskTexAsAlpha, maskA - 1, 1)  ... i.e. lerp(1, maskA, flag-ish);
                // the base blob folds maskA into the same product as mainA. 1:1 form:
                //   maskA = mad(_UseMaskTexAsAlpha, mask.r - mask.a, mask.a)  (lerp a->r)
                #ifdef _USE_MASK
                    float2 maskUV = ComputeVfxUV(uv0, uv1, _MaskTexUVWeights, _MaskTexUVSpeed,
                                                 time, custom1Y, _MaskTexUVRotateMat, _MaskTex_ST,
                                                 disturb, _MaskTexUseDisturb);
                    float4 maskSample = SAMPLE_TEXTURE2D(_MaskTex, sampler_MaskTex, maskUV);
                    float maskA = lerp(maskSample.a, maskSample.r, _UseMaskTexAsAlpha);
                    alpha *= maskA;
                #endif

                // ==== DISSOLVE (blob b65 line 133) ====
                // edge = saturate((dissolve.r - threshold) * _DissolveEdgeSharp); alpha *= edge,
                // where threshold = mad(mad(customData.z*_InParticle, +_DissolveScheduleOffset), 2.02, -1.01).
                // (b65:133 inner addend is the c11.y slot the decompiler aliased _MaskTexUseDisturb;
                //  its true semantic is _DissolveScheduleOffset, which pushes the cut -1.01..1.01.)
                #ifdef _USE_DISSOLVE
                    float2 dissolveUV = ComputeVfxUV(uv0, uv1, _DissolveUVWeights, _DissolveUVSpeed,
                                                     time, custom1Y, _DissolveUVRotateMat,
                                                     _DissolveTex_ST, disturb, _DissolveTexUseDisturb);
                    float4 dissolveSample = SAMPLE_TEXTURE2D(_DissolveTex, sampler_DissolveTex, dissolveUV);
                    float dissolveThreshold = mad(
                        mad(input.customData.z, _InParticle, _DissolveScheduleOffset),
                        2.019999980926513671875, -1.0099999904632568359375);
                    float dissolveEdge = saturate((dissolveSample.r - dissolveThreshold) * _DissolveEdgeSharp);
                    alpha *= dissolveEdge;
                #endif

                // Near-camera fade (blob b61 line 107): gated by _UseNearCameraFade (the base blob's
                // `0.0 != _UseMaskTexAsAlpha`-aliased branch). When off, factor = 1.
                if (_UseNearCameraFade != 0.0)
                {
                    alpha *= NearCameraFade(dist);
                }

                // Dither-alpha exponent (blob b61 line 107 outer):
                //   a = pow(saturate(alpha * (1 - _unity_LODFade.y)), _DitherAlphaExp)
                // The decompiled b61:107 expression ends at `* _MaskTexUVSpeed.y` (= _DitherAlphaExp);
                // there is NO trailing `* _ProcedureAlpha` (that field is not even in the b61 cbuffer,
                // nor read by the b63/b65/b69 deltas) -> do NOT multiply by _ProcedureAlpha here.
                // _unity_LODFade is URP LOD crossfade (1 when not crossfading -> factor 1).
                // Implemented as exp2(log2(clamp(.,0,1)) * exp) exactly like the blob.
                float lodScale = 1.0; // (1 - _unity_LODFade.y); URP applies crossfade via its own keyword
                float ditheredAlpha = exp2(log2(clamp(alpha * lodScale, 0.0, 1.0)) * _DitherAlphaExp);

                // Interleaved-gradient screen dither threshold (blob b61 line 108):
                //   n = frac(frac(dot(fragXY*_DitherTilling + frameJitter, k)) * 52.98291778564453)
                //   k = float2(0.06711056, 0.00583715)
                // _TaaFrameInfo.z was the per-frame temporal offset; dropped (no TAA in URP forward).
                float2 fragXY = input.positionCS.xy;
                float2 hashIn = mad(fragXY, _DitherTilling.xx, 0.0.xx);
                float noise = frac(frac(dot(hashIn, float2(0.067110560834407806396484375,
                                                           0.005837149918079376220703125)))
                                   * 52.98291778564453125);

                // Discard when ditheredAlpha < signedNoise (blob b61 line 109). ditheredAlpha >= 0,
                // so the sign branch reduces to a plain `ditheredAlpha < noise` clip.
                float signedNoise = (ditheredAlpha >= 0.0) ? noise : -noise;
                clip(ditheredAlpha - signedNoise);
            }
            ENDHLSL
        }
    }
}
