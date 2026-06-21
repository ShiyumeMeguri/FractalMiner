// HGRP VFX Line — single transparent ForwardOnly pass (additive/alpha VFX ribbon/line).
// A camera-relative VFX surface: reconstructs world-space XZ from screen position, scrolls
// the main tex by world XZ + time, tints by vertex-color * _TintColor * intensity, applies an
// exponential "Exp" glow boost (base + ExpIntensity * max(color - ExpThreshold, 0)), then divides
// by post-exposure. Optional second "Mask" texture (mesh-UV) modulates color + alpha.
// Merged from: vfxline.shader
//   Vertex base (catch-all #else) = vfxline/Sub0_Pass0_Vertex_b4.hlsl   (KW: HG_ENABLE_MV)
//   Vertex mask                   = vfxline/Sub0_Pass0_Vertex_b6.hlsl   (HG_ENABLE_MV + _USE_MASK)
//   Frag  base  (catch-all #else) = vfxline/Sub0_Pass0_Fragment_b5.hlsl (KW: HG_ENABLE_MV)
//   Frag  mask                    = vfxline/Sub0_Pass0_Fragment_b7.hlsl (HG_ENABLE_MV + _USE_MASK)
// Keywords: _USE_MASK
// Kept: world-XZ-from-screen reconstruction for MainTex UV (InvViewProj depth unproject, blob b5:95-114),
//   per-axis UV scroll by _MainTexUVSpeed*time + worldXZ, degree->radian UV rotation, _MainTex_ST tiling,
//   vertex-color gate (_DisableVertColor), tint*intensity, UseMainTexAsAlpha channel remap (lerp rgb<-1),
//   exponential Exp glow (ExpThreshold/ExpIntensity), post-exposure divide (_ExposureParams.x/_IgnorePostExposure),
//   optional Mask tex (mesh UV0, own scroll/rotate/ST, UseMaskTexAsAlpha) modulating color+alpha,
//   STRAIGHT (non-premultiplied) color out + fixed-function Blend factors (One/Zero defaults, set by the
//   blend-mode editor) doing additive/alpha composite, _SurfaceType-gated output alpha.
// Removed: SPIRV-Cross plumbing (gl_FragCoord/SV_Target statics, frag_main glue), HGRP global cbuffer
//   (type_ShaderVariablesGlobal) mapped to URP globals/material props; motion vectors (SV_Target1 / MRT1,
//   TAA-jitter, _NonJittered/_Prev* matrices, _Responsive/_EnableTransparentMV velocity write — needs no
//   second render target in this sandbox); ALL HGRP atmospheric fog (Atmosphere/Exponential/Volumetric
//   per-fragment fog composite, blob b5:136-204) — sandbox uses URP fog only; instancing (SRP_INSTANCING_ON).
//
// NOTE: _VFXParams0.w (HGRP per-VFX custom time) -> _Time.y (URP). _ExposureParams.x (HGRP post-exposure
//   global) re-exposed as a material Vector since URP has no such global; set .x=1 for neutral exposure.
// NOTE: world position is reconstructed from THIS fragment's own SV_Position.z (== blob gl_FragCoord.z,
//   b5:97-100) via ComputeWorldSpacePosition + UNITY_MATRIX_I_VP — NOT the scene depth buffer, so no URP
//   Depth Texture is required. The reconstructed XZ only drives the MainTex scroll origin (blob b5:119-120),
//   exactly as the HGRP source.

Shader "HGRP/VfxLine_Fix" {
    Properties {
        [Header(Base)]
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableVertColor ("Disable Vert Color", Float) = 0
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity", Range(1, 100)) = 1
        _ExpThreshold ("Exp Threshold", Range(0, 1)) = 1
        _ExpIntensity ("Exp Intensity", Range(0, 100)) = 0
        _TintColorAlpha ("Tint Color Alpha", Range(0, 10)) = 1

        [Header(Main Tex)]
        _MainTex ("Main Tex", 2D) = "white" {}
        [ToggleUI] _UseMainTexAsAlpha ("Use Main Tex As Alpha", Float) = 1
        _MainTexUVSpeed ("MainTexUVSpeed (XY:By Time, ZW:By Custom1.X)", Vector) = (0, 0, 0, 0)
        _MainTexUVRotate ("MainTexUVRotate (Degree)", Float) = 0

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        [ToggleUI] _UseMaskTexAsAlpha ("Use Mask Tex As Alpha", Float) = 1
        _MaskTexUVSpeed ("MaskTexUVSpeed (XY:By Time, ZW:By Custom1.Y)", Vector) = (0, 0, 0, 0)
        _MaskTexUVRotate ("MaskTexUVRotate (Degree)", Float) = 0

        [Header(Exposure)]
        // HGRP global type_ShaderVariablesGlobal _ExposureParams (c109); .x = post-exposure multiplier.
        _ExposureParams ("ExposureParams (.x = post exposure)", Vector) = (1, 0, 0, 0)

        // Render-state plumbing — driven by the material editor / OnValidate from _BlendMode/_SurfaceType,
        // not by the shader. Mirrors source .shader lines 30-38.
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 0
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _StencilWriteMask ("__stencilWriteMask", Float) = 0
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
    }
    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 100

        HLSLINCLUDE
            // Core.hlsl brings ComputeWorldSpacePosition, UNITY_MATRIX_I_VP, GetVertexPositionInputs,
            // _ScreenParams, _Time, SAMPLE_TEXTURE2D, CBUFFER_START. World reconstruction uses the fragment's
            // own SV_Position.z (no scene depth texture needed) so no DeclareDepthTexture include.
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Base
                float  _SurfaceType;
                float  _BlendMode;
                float  _DisableVertColor;
                float  _IgnorePostExposure;
                float  _TintColorIntensity;
                float  _TintColorAlpha;
                float  _ExpThreshold;
                float  _ExpIntensity;
                float4 _TintColor;
                // Main Tex
                float  _UseMainTexAsAlpha;
                float  _MainTexUVRotate;
                float4 _MainTexUVSpeed;
                float4 _MainTex_ST;
                // Mask
                float  _UseMaskTexAsAlpha;
                float  _MaskTexUVRotate;
                float4 _MaskTexUVSpeed;
                float4 _MaskTex_ST;
                // Exposure (HGRP global re-exposed as material Vector)
                float4 _ExposureParams;
                // Render state
                float  _TransparentSortPriority;
            CBUFFER_END

            // T0 = MainTex (blob b5:65, sampler_LinearRepeat -> Repeat wrap).
            TEXTURE2D(_MainTex);   SAMPLER(sampler_MainTex);
            // T1 = MaskTex (blob b7:67, sampler_LinearMirror -> Mirror wrap; only sampled under _USE_MASK).
            TEXTURE2D(_MaskTex);   SAMPLER(sampler_MaskTex);

            // Degrees -> radians. Blob spells 0.01745329238474369049072265625f (= PI/180). b5:116, b7:118/128.
            static const float DEG2RAD = 0.01745329238474369049072265625;

            // ----------------------------------------------------------------
            // Scroll + rotate + tile a VFX UV, exactly per blob.
            //   inUV   : the per-tex base coordinate (MainTex: reconstructed world XZ; Mask: mesh UV0).
            //   speed  : _XxxTexUVSpeed (.xy scrolled by time)
            //   time   : _VFXParams0.w -> _Time.y
            //   sinA/cosA : sin/cos(DEG2RAD * _XxxTexUVRotate)
            //   st     : _XxxTex_ST (tiling .xy, offset .zw)
            // Mirrors blob b5:116-121 (MainTex) and b7:128-133 (MaskTex):
            //   p = speed.xy*time + inUV - 0.5
            //   uv.x = mad(dot(p, float2( cosA, sinA)) + 0.5, st.x, st.z)
            //   uv.y = mad(dot(p, float2(-sinA, cosA)) + 0.5, st.y, st.w)
            // ----------------------------------------------------------------
            float2 ComputeVfxLineUV(float2 inUV, float4 speed, float time, float sinA, float cosA, float4 st)
            {
                float2 p = mad(speed.xy, time.xx, inUV) - 0.5;
                float2 uv;
                uv.x = mad(dot(p, float2( cosA, sinA)) + 0.5, st.x, st.z);
                uv.y = mad(dot(p, float2(-sinA, cosA)) + 0.5, st.y, st.w);
                return uv;
            }

            struct Attributes {
                float3 positionOS : POSITION;
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float4 uv         : TEXCOORD0;  // mesh UV0 (TEXCOORD passed through; .xy used by Mask). blob vert b4:73-76
                float4 vertColor  : TEXCOORD1;  // COLOR -> tint gate. blob vert b4:77-80
            };

            // Vertex: object->world->clip. HGRP source does the camera-relative + non-jittered VP transform
            // manually (blob b4:60-69); URP's GetVertexPositionInputs is the 1:1 infra equivalent (the only
            // pixel-affecting outputs consumed by the kept fragment are clip position, UV, and vertex color —
            // the prev-frame / motion-vector outputs b4:81-91 are dropped with SV_Target1).
            Varyings vert(Attributes v)
            {
                Varyings o;
                VertexPositionInputs posIn = GetVertexPositionInputs(v.positionOS);
                o.positionCS = posIn.positionCS;
                o.uv         = v.texcoord0;     // blob b4:73-76 (TEXCOORD_1 = TEXCOORD)
                o.vertColor  = v.color;         // blob b4:77-80 (TEXCOORD_1_1 = COLOR)
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                float time = _Time.y; // _VFXParams0.w (HGRP per-VFX custom time). blob b5:119-120

                // ---- Reconstruct world position of THIS fragment (blob b5:95-114) ----
                // HGRP: NDC.xy from gl_FragCoord.xy*_ScreenSize (b5:95-96, _59=2*ndc.x-1, _63=-(2*ndc.y-1)),
                // depth = gl_FragCoord.z (THIS fragment's own interpolated device depth, NOT the scene depth
                // buffer), then _InvViewProjMatrix*(ndc,depth)/w -> _112=X, _114=Z (b5:97-100).
                // URP 1:1 infra: ComputeWorldSpacePosition(screenUV, input.positionCS.z, UNITY_MATRIX_I_VP).
                // ComputeClipSpacePosition (Common.hlsl 1323-1335) does positionCS.xy = ndc*2-1 then flips
                // .y under UNITY_UV_STARTS_AT_TOP -> byte-identical to the blob's _59 / _63 (the -(2*ndc.y-1)).
                // CRITICAL: deviceDepth is the VFX surface's own SV_Position.z (== blob gl_FragCoord.z), so it
                // needs NO depth texture; sampling the scene depth would reconstruct the BACKGROUND point and
                // shift the MainTex scroll origin. Only worldX (_112) and worldZ (_114) are consumed (b5:119-120).
                // 1:1, source = vfxline/Sub0_Pass0_Fragment_b5.hlsl:95-100,119-120. The blob's _InvViewProjMatrix
                // is HGRP camera-RELATIVE, so _112/_114 are world XZ RELATIVE to the camera; URP's
                // UNITY_MATRIX_I_VP yields ABSOLUTE world XZ. We reproduce the blob's exact camera-relative value
                // by subtracting _WorldSpaceCameraPos.xz below (URP global, Core.hlsl/UnityInput.hlsl) -> the
                // MainTex scroll origin then matches the source bit-for-bit (was previously punted as a phase
                // residual; it is plain math, so it is closed). NOTE: the HGRP camera-relative _154/_156/_158
                // basis path (b5:101-104) feeds ONLY the dropped atmospheric-fog view direction, so it is absent.
                float2 screenUV  = input.positionCS.xy / _ScreenParams.xy;
                float3 worldPos  = ComputeWorldSpacePosition(screenUV, input.positionCS.z, UNITY_MATRIX_I_VP);

                // ---- Vertex-color gate (blob b5:111) ----
                bool disableVC = (0.0 != _DisableVertColor);

                // ---- Post-exposure divisor (blob b5:112) ----
                // _215 = mad(_IgnorePostExposure, _ExposureParams.x - 1, 1)
                float exposureDiv = mad(_IgnorePostExposure, _ExposureParams.x - 1.0, 1.0);

                // ---- Tint RGB (blob b5:113-115) ----
                // ((disableVC?1:vc.rgb) * _TintColor.rgb * _TintColorIntensity) / exposureDiv
                float3 vc3   = disableVC ? float3(1, 1, 1) : input.vertColor.rgb;
                float3 tint  = (vc3 * _TintColor.rgb * _TintColorIntensity) / exposureDiv;

                // ---- MainTex sample (blob b5:116-129) ----
                float  mainAngle = DEG2RAD * _MainTexUVRotate;          // b5:116
                float  mainSin   = sin(mainAngle);                      // b5:117
                float  mainCos   = cos(mainAngle);                      // b5:118
                // Scroll origin = blob's camera-RELATIVE world XZ (b5:119-120: _112=worldX-camX, _114=worldZ-camZ).
                // URP's ComputeWorldSpacePosition gives ABSOLUTE world XZ; subtract _WorldSpaceCameraPos.xz to
                // reproduce the HGRP camera-relative _112/_114 exactly. b5:119 mad(_MainTexUVSpeed.x,time,_112),
                // b5:120 mad(_MainTexUVSpeed.y,time,_114).
                float2 mainBase  = float2(worldPos.x, worldPos.z) - _WorldSpaceCameraPos.xz;
                float2 mainUV    = ComputeVfxLineUV(mainBase, _MainTexUVSpeed, time, mainSin, mainCos, _MainTex_ST);
                // SampleBias with _GlobalMipBias -> standard sample (HGRP global mip bias dropped). b5:121
                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, mainUV);
                // UseMainTexAsAlpha: remap rgb -> lerp(rgb, 1, flag). mad(flag, (1-c), c). b5:126-129
                float3 mainRGB = lerp(mainSample.rgb, float3(1, 1, 1), _UseMainTexAsAlpha);
                // Alpha source channel: lerp(a, r, flag) via mad(flag, r-a, a). b5:135 inner term
                float  mainA   = lerp(mainSample.a, mainSample.r, _UseMainTexAsAlpha);

                // ---- Color before Mask (blob b5: tintR*mainRGB are _216*_287 etc.) ----
                float3 color = tint * mainRGB;
                // Raw alpha product (clamped ONCE at the very end to match the single blob clamp; do NOT
                // saturate the base before multiplying by mask, else base alpha >1 truncates wrongly). b5:135 / b7:151
                float  vcA   = disableVC ? 1.0 : input.vertColor.a;
                float  alpha = vcA * _TintColor.a * _TintColorAlpha * mainA;

                // ---- Mask (blob b7:128-151) ----
                #ifdef _USE_MASK
                    float  maskAngle = DEG2RAD * _MaskTexUVRotate;      // b7:128 (0.0174532..f * _MaskTexUVRotate)
                    float  maskSin   = sin(maskAngle);                  // b7:129
                    float  maskCos   = cos(maskAngle);                  // b7:130
                    // Mask base UV = mesh UV0 (b7:131-132 use TEXCOORD.xy, NOT world).
                    float2 maskUV    = ComputeVfxLineUV(input.uv.xy, _MaskTexUVSpeed, time, maskSin, maskCos, _MaskTex_ST);
                    float4 maskSample = SAMPLE_TEXTURE2D(_MaskTex, sampler_MaskTex, maskUV); // b7:133 (sampler_LinearMirror)
                    // UseMaskTexAsAlpha: color factor = lerp(rgb, 1, flag) = mad(flag,(1-c),c). b7:142-145 (_365/_366/_367)
                    float3 maskRGB = lerp(maskSample.rgb, float3(1, 1, 1), _UseMaskTexAsAlpha);
                    // Mask alpha factor = lerp(a, r, flag). b7:151 inner mask term mad(flag,(-_331)+_328,_331)
                    float  maskA   = lerp(maskSample.a, maskSample.r, _UseMaskTexAsAlpha);
                    // color *= maskColorFactor: b7 folds _349*_365 etc. into the Exp glow input (b7:218-220 SV_Target.x
                    // uses _349*_365, where _349=tintR*mainRGBr at b7:139). Multiplying before the glow == 1:1.
                    color *= maskRGB;
                    alpha *= maskA;     // b7:151 alpha product *= mask alpha channel (single clamp deferred to end)
                #endif
                alpha = saturate(alpha); // single clamp(...,0,1) matching b5:135 / b7:151

                // ---- Exponential "Exp" glow + clamp (blob b5:202-204; base/mask identical math) ----
                // per-channel: clamp(mad(max(color - _ExpThreshold, 0), _ExpIntensity, color), 0, 1000)
                // (fog factors _901*_398=1 and additive fog term=0 once HGRP fog is removed)
                float3 expExcess = max(color - _ExpThreshold, 0.0); // _299 = -_ExpThreshold added => color - thr
                float3 outColor  = clamp(mad(expExcess, _ExpIntensity, color), 0.0, 1000.0);

                // ---- Output: STRAIGHT (non-premultiplied) color, exactly as the HGRP source ----
                // Source writes SV_Target.rgb = outColor (b5:202-204) and SV_Target.a = alpha (b5:135), then
                // the fixed-function Blend factors do the composite: _BlendMode=Additive -> _SrcBlend=One
                // (rgb added straight); _BlendMode=Alpha -> _SrcBlend=SrcAlpha (hardware multiplies by alpha).
                // So we must NOT premultiply here.
                // NOTE: the COLOR-buffer alpha (SV_Target.w) in the source is ONLY ever the clamped alpha
                // product (b5:135) — it is NEVER gated by _SurfaceType. _SurfaceType in this shader gates only
                // the dropped motion-vector RT: SV_Target_1.x/.y via _1005=clamp((1+_EnableTransparentMV)-
                // _SurfaceType,0,1) (b5:206-208) and SV_Target_1.w=_Responsive*_SurfaceType (b5:209). With MRT1
                // gone there is no surface-type alpha gate; output the straight clamped alpha verbatim.
                return half4(outColor, alpha);
            }
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }

            // Source .shader lines 48-61. RGB + alpha blend factors all bound from material props (set by the
            // blend-mode/surface-type editor); property defaults One/Zero. The source's MRT1 motion-vector blend
            // (line 49 "Blend 1 ...") is dropped with SV_Target1. ZTest/ZWrite/Cull from props; Stencil Replace.
            Blend [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]
            Stencil {
                Ref [_StencilRef]
                WriteMask [_StencilWriteMask]
                Comp Always
                Pass Replace
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_MASK
            ENDHLSL
        }
    }
}
