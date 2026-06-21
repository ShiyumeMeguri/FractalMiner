// HGRP VFX Radial Blur — screen-space radial-blur distortion of the camera color buffer — single transparent pass.
// Merged from: vfxradialblur.shader (HGRP/Effect/VFXRadialBlur), base blob Sub0_Pass0_Fragment_b11.hlsl (HG_ENABLE_MV catch-all),
//   + delta blobs Sub0_Pass0_Fragment_b13.hlsl (_USE_MASK) and Sub0_Pass0_Fragment_b19.hlsl (_USE_MASK+_USE_SOFTBLEND+_USE_POLARUV);
//   vertex base Sub0_Pass0_Vertex_b10.hlsl.
// Keywords: _USE_MASK, _USE_SOFTBLEND, _USE_POLARUV
// Kept: radial-blur sampling loop (6 taps, 1/3 average) of the camera color texture (blob b11 lines 96-123),
//   particle/object-center reprojection to screen for the blur focal point (b11 lines 83-98),
//   _RadialBlurWithScreenDepth power-by-view-depth divisor (b11 line 99), _Power exp2/log2 pow shaping (b11 lines 100-101),
//   _UseNearCameraFade dual-band view-depth fade (b11 lines 124-129/384), tint alpha (_318.w*_TintColorAlpha),
//   _USE_MASK polar/mesh-UV mask sample + _UseMaskTexAsAlpha channel select (b13 lines 128-141 / b19 lines 140-159),
//   _USE_SOFTBLEND camera-depth soft fade over _SoftDistance (b19 lines 152-166),
//   _USE_POLARUV atan2-rational polar UV remap gated by _MaskSwitchUV (b19 lines 93-100, 143-145).
// Removed (pixel-neutral pipeline infra substituted by URP, or HGRP-only framework with no URP analog):
//   TAA jitter (_TaaJitterStrength → identity, drops to plain TransformWorldToHClip), HGRP global cbuffers
//   (_ViewMatrix/_InvViewProjMatrix/_NonJitteredViewNoTransProjMatrix/_WorldSpaceCameraPos_Internal/_ScreenSize/_GlobalMipBias
//   → URP UNITY_MATRIX_V / unity_CameraInvProjection-via-Core / _WorldSpaceCameraPos / _ScreenParams / global mip bias=0),
//   GPU instancing (SRP_INSTANCING_ON), the HGRP "Distortion" LightMode 2nd MRT motion-vector target (SV_Target1, b11 lines 130-135)
//   — ENGINE-SIDE: URP's UniversalForwardOnly binds one color attachment (no RT1), and URP emits object motion
//   vectors in a separate MotionVectorRenderPass (MV buffer as RT0), so closing it needs a host ScriptableRenderPass
//   that binds a 2nd MRT + feeds prev-frame matrices — not a material-shader concern; full 1:1 MV math kept in TODO(1:1) below.
//
// NOTE: this samples the camera color buffer, so it requires URP Opaque Texture ON (_CameraOpaqueTexture) and,
//   for _USE_SOFTBLEND, Depth Texture ON (_CameraDepthTexture). It must render in the Transparent queue AFTER opaques.
// NOTE: the radial-blur focal-point pixel offset is _CanterOffset.xy in the source; decompiled base/delta blobs that
//   lacked _CanterOffset in their cbuffer aliased that read onto neighbouring registers (_MaskTexUVRotate/_UseMaskTexAsAlpha
//   in b11, _SoftDistance in b13) — b19 (which has _CanterOffset) proves the true field. We use _CanterOffset.xy.

Shader "HGRP/VfxRadialBlur_Fix" {
    Properties {
        [Enum(Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableParticleInstanceColor ("Disable Particle Instance Color", Float) = 0
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        _TintColorAlpha ("Tint Color Alpha (Default 1)", Range(0, 10)) = 1
        [ToggleUI] _InParticle ("Use In Particle (Center In Texcoord1.xyz)", Float) = 1
        _RadialBlurIntensity ("RadialBlur Intensity", Range(0, 0.5)) = 0.1
        _CanterOffset ("Canter Offset (ZW Not Used)", Vector) = (0, 0, 0, 0)
        _Power ("Power", Range(1, 2)) = 1
        [ToggleUI] _RadialBlurWithScreenDepth ("Radial Blur With Screen Depth", Float) = 0
        [ToggleUI] _EnableTransparentMV ("Enable Transparent MV", Float) = 0

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        [ToggleUI] _UseMaskTexAsAlpha ("UseMaskTexAsAlpha", Float) = 1
        [Enum(MeshUV, 0, PolarUV, 2)] _MaskSwitchUV ("Refract UV Switcher", Float) = 0
        _MaskTexUVSpeed ("MaskTexUVSpeed (XY:By Time, ZW:By Custom1.X)", Vector) = (0, 0, 0, 0)
        _MaskTexUVRotate ("MaskTexUVRotate (Degree)", Float) = 0

        [Header(Soft Blend)]
        [Toggle(_USE_SOFTBLEND)] _UseSoftBlend ("Use SoftBlend", Float) = 0
        _SoftDistance ("Soft Distance", Range(0.001, 10)) = 0.001

        [Header(Polar UV)]
        [Toggle(_USE_POLARUV)] _UsePolarUV ("Use Polar UV", Float) = 0

        [Header(Near Camera Fade)]
        _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Start 1 (disappear)", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Fade End 1 (appear)", Range(0.001, 3000)) = 10
        _NearCameraFadeDistanceEnd2 ("Fade End 2 (appear)", Range(0.002, 3000)) = 100
        _NearCameraFadeDistanceStart2 ("Fade Start 2 (disappear)", Range(0.001, 3000)) = 120

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
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareOpaqueTexture.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float _SurfaceType;
                float _EnableTransparentMV;
                float _InParticle;
                float _TintColorAlpha;
                float _NearCameraFadeDistanceStart;
                float _NearCameraFadeDistanceEnd;
                float _NearCameraFadeDistanceStart2;
                float _NearCameraFadeDistanceEnd2;
                float _UseNearCameraFade;
                float _RadialBlurIntensity;
                float _Power;
                float _RadialBlurWithScreenDepth;
                // Mask
                float _MaskTexUVRotate;
                float _UseMaskTexAsAlpha;
                float _MaskSwitchUV;
                float4 _MaskTexUVSpeed;
                float4 _MaskTex_ST;
                // Soft blend
                float _SoftDistance;
                // Radial-blur focal-point pixel offset (source _CanterOffset, see header NOTE)
                float4 _CanterOffset;
            CBUFFER_END

            TEXTURE2D(_MaskTex);    SAMPLER(sampler_MaskTex);

            // VFX time driver: source reads _VFXParams0.w (HGRP per-particle time); URP uses _Time.y.
            #define _VFXTime (_Time.y)

            // atan2 via rational minimax (blob b19 lines 96-100): for |t|<1 → t*(1 + t^2*(-0.30189 + 0.087293*t^2)),
            // else π/2 - that. Returns atan2(y, x): the angle of the vector whose numerator is y and denominator is x.
            // Full-circle reconstruction is b19 line 144's masked add  mad(A, B, C)  bit-for-bit:
            //   A = (y>=0)? +π : -π   [asfloat((_144>=0)?1078530010u:3226013658u), _144 = numerator = y]
            //   B = (x<0)?  1 : 0     [asfloat(((_146<0)?0xFFFFFFFFu:0u) & 1065353216u), _146 = denominator = x]
            //   C = (ratio<0)? -a : a [(_147<0)? -_168 : _168]
            // So the π offset is added only in the lower half-plane (x<0), and its sign follows y — exactly atan2(y,x).
            float Atan2Rational(float y, float x)
            {
                float ratio = y / x;                                 // b19 line 95: _144 / _146
                bool small = abs(ratio) < 1.0;                       // b19 line 96
                float r = small ? abs(ratio) : (1.0 / abs(ratio));   // b19 line 97
                float r2 = r * r;                                    // b19 line 98
                float poly = mad(mad(r2, 0.087292902171611785888671875f, -0.3018949925899505615234375f), r2, 1.0f); // b19 line 99
                float a = small ? (r * poly)                         // b19 line 100 (_168)
                                : mad(-poly, r, 1.57079637050628662109375f);
                // b19 line 144 masked add: A * B + C  (kept as mad to mirror the source spelling exactly).
                // A uses asfloat(1078530010u)/asfloat(3226013658u) = ±3.141592502593994140625 — note this is the
                // sign-select π (bits 1078530010), 1 ULP below the additive +π offset (bits 1078530011) used in polarU.
                float A = (y >= 0.0) ? 3.141592502593994140625f : -3.141592502593994140625f; // numerator sign → ±π
                float B = (x <  0.0) ? 1.0 : 0.0;                                              // denominator-negative gate
                float C = (ratio < 0.0) ? -a : a;                                             // base angle, signed by ratio
                return mad(A, B, C);
            }
        ENDHLSL

        Pass {
            Name "Refraction"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_MASK
            #pragma shader_feature_local _USE_SOFTBLEND
            #pragma shader_feature_local _USE_POLARUV

            struct Attributes {
                float3 positionOS : POSITION;
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0; // .xy mesh UV, .zw spare (b10: TEXCOORD)
                float4 texcoord1  : TEXCOORD1; // particle center .xyz, custom1 in .w (b10: TEXCOORD_1)
            };

            struct Varyings {
                float4 positionCS    : SV_POSITION;
                float4 meshUV        : TEXCOORD0; // pass-through texcoord0   (b10 TEXCOORD_2)
                float4 particleData  : TEXCOORD1; // particle center.xyz + custom1.w (b10 TEXCOORD_1_1)
                float4 vertColor     : TEXCOORD2; // (1 - _unity_Float4x5_Param2)*COLOR; w used for blur intensity (b10 TEXCOORD_2_1)
            };

            Varyings vert(Attributes v)
            {
                Varyings o;
                // World→clip. Source builds NonJitteredViewNoTransProj manually then removes TAA jitter
                // (b10 lines 65-74); the jitter-free result == URP TransformWorldToHClip.
                VertexPositionInputs posInputs = GetVertexPositionInputs(v.positionOS);
                o.positionCS = posInputs.positionCS;

                o.meshUV = v.texcoord0;          // b10 lines 78-81
                o.particleData = v.texcoord1;    // b10 lines 82-85

                // Vertex color exposure de-scale: (1 - _unity_Float4x5_Param2)*COLOR (b10 lines 86-89).
                // _unity_Float4x5_Param2 is an HGRP per-particle exposure param with no URP analog → 0 (identity).
                o.vertColor = v.color;
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                // Screen UV of this fragment (b11 lines 78-79: gl_FragCoord.xy * _ScreenSize.zw).
                float2 screenUV = input.positionCS.xy / _ScreenParams.xy;

                // ---- Radial-blur focal point: particle/object center reprojected to screen ----
                // Center WS: particle center (texcoord1.xyz) when _InParticle, else object origin (b11 lines 83-86).
                bool inParticle = (0.0 != _InParticle);
                float3 centerWS = inParticle ? input.particleData.xyz
                                             : float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);

                // Project center to NDC then to [0,1] screen (b11 lines 90-94). URP UNITY_MATRIX_VP replaces the
                // hand-rolled NonJitteredViewNoTransProj (camera-relative); jitter term dropped.
                // The fragment's screenUV comes from SV_POSITION pixel coords (top-left origin, y-down), so the
                // reprojected center must be flipped on Y to share that space — the source does this with the explicit
                // negate at b11 line 92 ((-0.0f) - clipY before *0.5+0.5). X keeps the plain +0.5 mad (b11 line 91).
                float4 centerCS = mul(UNITY_MATRIX_VP, float4(centerWS, 1.0));
                float2 centerNdcProj = centerCS.xy / centerCS.w;
                float2 centerScreen01 = float2(mad(centerNdcProj.x,  0.5, 0.5),   // b11 line 91 (_215)
                                               mad(centerNdcProj.y, -0.5, 0.5));  // b11 line 92 (_217, explicit Y negate)
                float2 centerNdc = mad(centerScreen01, 2.0, -1.0);              // b11 lines 93-94 (_218/_219)

                // Off-screen guard: if reprojected length > sqrt(2), normalize to the rim (b11 lines 95-98).
                // NOTE source's sqrt term is sqrt(x*x + (y+y)) — kept verbatim (b11 line 95).
                bool offScreen = 1.41400003433227539062f < sqrt(mad(centerNdc.x, centerNdc.x, centerNdc.y + centerNdc.y));
                float invLen = rsqrt(dot(centerNdc, centerNdc)); // b11 line 96 (_229)
                float2 focal = float2(
                    offScreen ? mad(centerNdc.x, invLen, 1.0) * 0.5 : saturate(centerScreen01.x),  // b11 line 97
                    offScreen ? mad(centerNdc.y, invLen, 1.0) * 0.5 : saturate(centerScreen01.y)); // b11 line 98

                // Direction from this fragment to focal point, in screen-UV space, + _CanterOffset.xy (see header NOTE).
                float2 dir = screenUV - (focal + _CanterOffset.xy); // b11 lines 97-98 (_261/_262)

                // ---- Power shaping divisor ----
                // _RadialBlurWithScreenDepth: divide _Power by view-space depth of the center (b11 line 99), else 1.
                float viewZ = -(dot(UNITY_MATRIX_V[2].xyz, centerWS) + UNITY_MATRIX_V[2].w); // -(view.z) of centerWS
                float depthDivisor = (0.0 != _RadialBlurWithScreenDepth)
                                   ? max(viewZ - _ProjectionParams.y, 0.00999999977648258209228515625f) // b11 line 99
                                   : 1.0;
                float powExp = _Power / depthDivisor; // b11 line 99

                // pow(|dir|, powExp) * dir, per component (b11 lines 100-101: exp2(log2(abs)*p)*v).
                float2 shaped = float2(
                    exp2(log2(abs(dir.x)) * powExp) * dir.x,
                    exp2(log2(abs(dir.y)) * powExp) * dir.y);

                // ---- Radial blur: 6 taps (3 integer + 3 half-offset), averaged (b11 lines 102-123) ----
                // Per-particle blur weight: custom1 (texcoord2.w in source vertColor) when _InParticle, else 1.
                float blurWeight = (inParticle ? input.vertColor.w : 1.0) * _RadialBlurIntensity; // b11 line 103 (_330)

                float3 accum = SAMPLE_TEXTURE2D_X(_CameraOpaqueTexture, sampler_CameraOpaqueTexture, screenUV).rgb; // b11 line 102 seeds accum
                // loop i=1..2 inclusive (int(asuint(i)) >= 3 stops): two iterations, each adds tap(i) + tap(i-0.5).
                [unroll]
                for (int i = 1; i < 3; ++i) // b11 line 118 (_338 from 1, < 3)
                {
                    float fi = (float)i;
                    float2 uvA = mad(-(fi * shaped), blurWeight, screenUV);          // b11 line 118 (_476)
                    float3 tapA = SAMPLE_TEXTURE2D_X(_CameraOpaqueTexture, sampler_CameraOpaqueTexture, uvA).rgb;
                    float fh = fi - 0.5;                                              // b11 line 118 (_480)
                    float2 uvB = mad(-(fh * shaped), blurWeight, screenUV);          // b11 line 118 (_485/_486)
                    float3 tapB = SAMPLE_TEXTURE2D_X(_CameraOpaqueTexture, sampler_CameraOpaqueTexture, uvB).rgb;
                    accum = mad(tapA + tapB, 0.5, accum);                            // b11 line 118 (_332/_334/_336)
                }
                float3 blurred = accum * 0.3333333432674407958984375f;              // b11 lines 121-123 (avg of 6 -> /3 of the half-sums)

                // ---- Mask ----
                float maskAlpha = 1.0;       // mask alpha channel-selected (b13 line 147 _417/_414 path)
                float3 maskTint = 1.0.xxx;   // RGB tint when _UseMaskTexAsAlpha=0 (b13 lines 139-141)
                #ifdef _USE_MASK
                    // Mask UV: rotate(mesh or polar UV scrolled by speed) then ST (b13 lines 128-133 / b19 lines 140-146).
                    float ang = 0.01745329238474369049072265625f * _MaskTexUVRotate; // deg→rad (b13 line 128)
                    float s = sin(ang); // b13 line 129
                    float c = cos(ang); // b13 line 130

                    float2 baseUV = input.meshUV.xy;
                    #ifdef _USE_POLARUV
                        // Polar remap gated by _MaskSwitchUV (1 or 2 → polar) (b19 lines 143-145).
                        float2 centered = input.meshUV.xy - 0.5;                 // b19 lines 93-94 (_144/_146)
                        bool usePolar = (1.0 == _MaskSwitchUV) || (2.0 == _MaskSwitchUV); // b19 line 143
                        float radius = sqrt(dot(centered, centered));            // b19 line 101/145 (_193)
                        float angle = Atan2Rational(centered.x, centered.y);     // b19 lines 95-100,144 (atan2(x over y))
                        float polarU = (angle + 3.14159274101257324218750f) * 0.15915493667125701904296875f; // b19 line 144: (a+π)/2π
                        float polarV = radius + radius;                          // b19 line 145 (_193+_193)
                        baseUV = usePolar ? float2(polarU, polarV) : input.meshUV.xy;
                    #endif

                    // Scroll: +speed.xy*time + speed.zw*custom1 (b13/b19: _MaskTexUVSpeed), then -0.5 recenter.
                    float2 scrolled = mad(_MaskTexUVSpeed.xy, _VFXTime, baseUV);            // b13 lines 131-132
                    scrolled = mad(_MaskTexUVSpeed.zw, input.particleData.w, scrolled) - 0.5; // b13 lines 131-132 (TEXCOORD_1.w)
                    // Rotate about center, +0.5, then ST (b13 line 133 / b19 line 146).
                    float2 rotated = float2(dot(scrolled, float2(c, s)) + 0.5,
                                            dot(scrolled, float2(-s, c)) + 0.5);
                    float2 maskUV = mad(rotated, _MaskTex_ST.xy, _MaskTex_ST.zw);
                    float4 maskSample = SAMPLE_TEXTURE2D(_MaskTex, sampler_MaskTex, maskUV);

                    // Channel select (b13 lines 139-141 / 147): when _UseMaskTexAsAlpha→ use R as alpha & tint=1;
                    // else use RGB as tint and A as alpha.
                    maskTint = lerp(maskSample.rgb, 1.0.xxx, _UseMaskTexAsAlpha);     // b13 lines 139-141 (_414 path)
                    maskAlpha = lerp(maskSample.a, maskSample.r, _UseMaskTexAsAlpha); // b13 line 147 (_417 vs _414)
                #endif

                // ---- Soft blend (camera-depth fade) ----
                float softFade = 1.0;
                #ifdef _USE_SOFTBLEND
                    // View-space depth of this fragment's surface vs scene depth, faded over _SoftDistance (b19 lines 152-165).
                    float sceneDepthRaw = SampleSceneDepth(screenUV);                 // b19 line 153 (T0.SampleLevel .x)
                    float sceneViewZ = LinearEyeDepth(sceneDepthRaw, _ZBufferParams); // view-space scene depth
                    float fragViewZ = LinearEyeDepth(input.positionCS.z, _ZBufferParams);
                    softFade = saturate((sceneViewZ - fragViewZ) / _SoftDistance);    // b19 line 165 (|scene|-|frag|)/_SoftDistance
                #endif

                // ---- Near-camera fade (dual band, view-depth driven) (b11 lines 124-129/384) ----
                // Source reconstructs WS from the depth buffer then takes view.z (b11 line 384 / b19 lines 139,164,628).
                // The reconstructed point IS this fragment's surface, so LinearEyeDepth of its own clip-z is equivalent.
                float reconViewZ = LinearEyeDepth(input.positionCS.z, _ZBufferParams);
                float nearFade = 1.0;
                if (0.0 != _UseNearCameraFade) // b11 line 129
                {
                    float d = abs(reconViewZ); // b11 line 384 abs(view.z); b19 line 164 _628
                    nearFade = saturate((d - _NearCameraFadeDistanceStart2) / (_NearCameraFadeDistanceEnd2 - _NearCameraFadeDistanceStart2)) // b11 line 129
                             * saturate((d - _NearCameraFadeDistanceStart)  / (_NearCameraFadeDistanceEnd  - _NearCameraFadeDistanceStart));
                }

                // ---- Compose output color (RT0) ----
                float4 sceneSample = SAMPLE_TEXTURE2D_X(_CameraOpaqueTexture, sampler_CameraOpaqueTexture, screenUV); // b11 line 102 (_318) for .w
                // RGB: mask-tinted blurred color, clamped [0,1000] (b11 lines 121-123 / b13 lines 139-141 / b19 lines 157-159).
                float3 outRGB = clamp(maskTint * blurred, 0.0, 1000.0);
                // Alpha: nearFade * softFade * maskAlpha * (sceneColor.a * _TintColorAlpha), clamped [0,1]
                //   (b11 line 129 / b13 line 147 / b19 lines 165-166).
                float outA = saturate(nearFade * softFade * maskAlpha * (sceneSample.a * _TintColorAlpha));

                return half4(outRGB, outA);

                // TODO(1:1) — ENGINE-SIDE (host ScriptableRenderPass, not closeable in a material shader):
                //   the HGRP "Distortion" pass writes a 2nd MRT (SV_Target1) of packed object motion vectors
                //   in the SAME draw as the blurred color (source .shader line 49 binds a 2nd blend slot
                //   "Blend 1 [_MVSrcColorBlend] [_MVDstColorBlend]"; frag b11 lines 130-135 / b13 lines 148-153 /
                //   b19 lines 167-172 emit SV_Target_1.xyzw). The current frag's `: SV_Target` output writes only
                //   RT0; SV_Target1 needs a 2nd render target BOUND by the renderer, plus previous-frame matrices
                //   fed to the vertex stage — neither of which a material shader can create.
                //   WHY URP can't host this here: URP's UniversalForwardOnly LightMode binds exactly ONE color
                //   attachment, so there is no RT1 to write. URP instead renders object motion vectors in its OWN
                //   dedicated pass — MotionVectorRenderPass.cs binds the MV buffer as RT0
                //   (SetRenderAttachment(motionVectorColor, 0, ...), GraphicsFormat.R16G16_SFloat) and runs
                //   ShaderLibrary/ObjectMotionVectors.hlsl (LightMode "MotionVectors", prev pos via
                //   _PrevViewProjMatrix * UNITY_PREV_MATRIX_M). There is no per-material "Distortion" MV MRT analog.
                //   HOST SYSTEM REQUIRED TO CLOSE: a custom URP ScriptableRendererFeature/ScriptableRenderPass that
                //   (a) binds the camera motion-vector buffer as a 2nd MRT alongside this transparent color target
                //   and (b) supplies the previous-frame view-proj + previous ObjectToWorld so the vertex stage can
                //   emit TEXCOORD_4 = prevClip (mirroring vertex blob b10 lines 90-100). Until that host pass exists
                //   the MV target is dropped (color RT0 path above is unaffected).
                //   1:1 MATH for when the host pass lands (blob b11 lines 130-135, identical in b13/b19):
                //     d  = TEXCOORD_3.xy / TEXCOORD_3.z  -  TEXCOORD_4.xy / TEXCOORD_4.z  // cur NDC - prev NDC
                //         (z-divisors clamped to max(z, 9.999999e-09) — b11 lines 124-125/142-143)
                //     gate _454 = clamp((1 + _EnableTransparentMV) - _SurfaceType, 0, 1)  // b11 line 131
                //     RT1.x = min(_454 * (sign(d.x) * sqrt(sqrt(abs(d.x * 0.5))) * 0.5 + 0.5), 1)   // b11 line 132
                //     RT1.y = min(_454 * (sign(-d.y) * sqrt(sqrt(abs(d.y * -0.5))) * 0.5 + 0.5), 1) // b11 line 133
                //         (note source negates the Y delta: _425 = -d.y, and the magnitude uses abs(d.y * -0.5))
                //     RT1.z = 1;  RT1.w = 0;                                                        // b11 lines 134-135
            }
            ENDHLSL
        }
    }
}
