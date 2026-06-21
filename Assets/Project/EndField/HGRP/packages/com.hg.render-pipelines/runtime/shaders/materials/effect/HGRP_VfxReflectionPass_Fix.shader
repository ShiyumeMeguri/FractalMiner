// HGRP VFX Reflection Pass — a VFX/particle surface rendered into the planar/SS-reflection G-buffer — single pass.
// This is NOT a color shader: it writes a reflection MASK + (optionally) an octahedral-encoded world normal so the
// reflection system can shade the VFX in the reflection. It samples MainTex ONLY to derive an alpha, runs the same
// VFX UV pipeline (scroll/rotate/tile, UV-set weights, _InParticle particle center) as the sibling VFX shaders, builds
// a coverage alpha (LODFade * near-camera-fade * [fresnel] * mainAlpha * vertColorGate * tint.a * tintAlpha), CLIPS the
// fragment when that alpha < _ReflectionPassAlphaCutout, then writes a fixed marker color.
//   _USE_FRESNEL OFF: writes SV_Target = (0.5, 1, 1)               (flat reflection-mask marker; coverage gates clip).
//   _USE_FRESNEL ON : writes SV_Target = (octa(N).x*0.5+0.5, octa(N).z*0.5+0.5, 1)  (Y-up octahedral world normal),
//                     and the coverage alpha is additionally shaped by a Fresnel(NdotV) term.
// Merged from: vfxreflectionpass.shader (HGRP/Effect/VFXReflectionPass)
//   Vertex base (catch-all #else) = vfxreflectionpass/Sub0_Pass0_Vertex_b4.hlsl   (KW: HG_ENABLE_MV)
//   Vertex fresnel                = vfxreflectionpass/Sub0_Pass0_Vertex_b6.hlsl   (HG_ENABLE_MV + _USE_FRESNEL; adds NORMAL/TANGENT)
//   Frag  base  (catch-all #else) = vfxreflectionpass/Sub0_Pass0_Fragment_b5.hlsl (KW: HG_ENABLE_MV; flat marker)
//   Frag  fresnel                 = vfxreflectionpass/Sub0_Pass0_Fragment_b7.hlsl (HG_ENABLE_MV + _USE_FRESNEL; octa normal)
//   (instancing variants b8/b9/b10/b11 are math-identical to b4/b5/b6/b7 — confirmed b9==b5 & b11==b7 — pure SRP_INSTANCING_ON infra.)
// Keywords: _USE_FRESNEL
// Kept: VFX MainTex UV (per-axis scroll by _MainTexUVSpeed.xy*time + .zw*custom1, UV-set blend via _MainTexUVWeights over
//   mesh-UV0/UV1, rotation via _MainTexUVRotateMat 2x2, _MainTex_ST tiling — blob b5:104-106 / b7:118-119), MainTex alpha
//   channel select (_UseMainTexAsAlpha: lerp a<-r, b5:109 inner), vertex-color gate (_DisableVertColor, b5:109), tint.a*tintAlpha
//   coverage, view-space-depth (abs) near-camera dual-band fade (b5:108-109 / b7:126-127), Fresnel pow(saturate(NdotV+bias),power)
//   with front-face normal flip + _FresnelFlip/_FresnelAffectOpacity opacity shaping (b7:122-127), LODFade coverage scale
//   (unity_LODFade.y, b5:109 / b7:127), _ReflectionPassAlphaCutout clip (b7:128), Y-up octahedral world-normal encode (b7:129-139),
//   flat (0.5,1,1) marker for the non-fresnel path (b5:111-113).
// Removed (pixel-neutral pipeline infra substituted by URP / HGRP-only framework with no URP analog):
//   SPIRV-Cross plumbing (gl_FragCoord/gl_FrontFacing/SV_Target statics, frag_main glue, discard_cond/discard_exit,
//   spvBitfieldUExtract packed-normal codec b6:73-127); HGRP global cbuffer type_ShaderVariablesGlobal mapped to URP
//   (_ViewMatrix→UNITY_MATRIX_V, _InvViewProjMatrix→UNITY_MATRIX_I_VP via ComputeWorldSpacePosition,
//   _NonJitteredViewNoTransProjMatrix→TransformWorldToHClip, _WorldSpaceCameraPos_Internal→_WorldSpaceCameraPos,
//   _ScreenSize→_ScreenParams, _unity_OrthoParams→unity_OrthoParams, _GlobalMipBias→0); GPU instancing (SRP_INSTANCING_ON);
//   TAA jitter (_TaaJitterStrength→identity); ALL motion-vector machinery (the HG_ENABLE_MV prev-frame clip output
//   TEXCOORD_6 / _PrevNonJitteredViewNoTransProjMatrix / _PrevCamPosRWS_Internal, blob b4:88-103 / b6:249-254 — HGRP MV is
//   written to a separate target this single-RT pass never reads); HGRP camera-RELATIVE world space (see NOTE).
//
// NOTE: _VFXParams0.w (HGRP per-VFX custom-particle time, used in the UV scroll .x/.y term) -> _Time.y (URP).
// NOTE: world position of THIS fragment is reconstructed from its own SV_Position.z via ComputeWorldSpacePosition +
//   UNITY_MATRIX_I_VP (blob unprojects gl_FragCoord.z through _InvViewProjMatrix, b5:103-108) — no scene depth texture
//   needed. The HGRP _InvViewProjMatrix is camera-RELATIVE, so its reconstructed world is relative to the camera; URP's
//   UNITY_MATRIX_I_VP is absolute. View-space depth (abs view-Z) and the view direction (camPos-worldPos) are invariant
//   to that offset, so the near-camera-fade and Fresnel are 1:1; only an absolute world position would differ (unused here).
//
// NOTE (the two compiles use DIFFERENT fade math — not an aliasing artifact): b5 (no fresnel) and b7 (fresnel) share an
//   IDENTICAL cbuffer byte layout through c13, but the original ShaderLab HLSL wired different inputs under #ifdef
//   _USE_FRESNEL, so the no-fresnel coverage fade is genuinely a different (legacy) formulation:
//     b5 (no fresnel): gate = (_FresnelBias != 0); bands clamp((d-_FresnelFlip)/(_UseNearCameraFade-_FresnelFlip)) *
//                      clamp((d-_FresnelAffectOpacity)/(_FresnelPower-_FresnelAffectOpacity)); cutout = _NearCameraFadeDistanceEnd2.
//     b7 (fresnel)   : gate = _UseNearCameraFade; bands over Start2/End2 and Start/End; cutout = _ReflectionPassAlphaCutout;
//                      plus the Fresnel(NdotV) opacity term. b7's cbuffer adds _ReflectionPassAlphaCutout (c14); b5 lacks it.
//   Both branches below transcribe their own blob's named fields VERBATIM — the no-fresnel quirk is preserved 1:1, NOT
//   "corrected" to the near-camera-fade.

Shader "HGRP/VfxReflectionPass_Fix" {
    Properties {
        [Header(Reflection Pass)]
        _ReflectionPassAlphaCutout ("Reflection Pass Alpha Cutout", Range(0, 1)) = 0.01
        [Toggle(_USE_FRESNEL)] _UseFresnel ("Use Fresnel (write octahedral normal)", Float) = 0

        [Header(Base)]
        [Enum(Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableVertColor ("Disable Vert Color", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle (Center In Texcoord1.xyz)", Float) = 1
        [ToggleUI] _DisableParticleInstanceColor ("Disable Particle Instance Color", Float) = 0
        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorAlpha ("Tint Color Alpha (Default 1)", Range(0, 10)) = 1

        [Header(Main Tex)]
        _MainTex ("Main Tex", 2D) = "white" {}
        [ToggleUI] _UseMainTexAsAlpha ("Use Main Tex As Alpha", Float) = 1
        _MainTexUVSpeed ("MainTexUVSpeed (XY:By Time, ZW:By Custom1.X)", Vector) = (0, 0, 0, 0)
        _MainTexUVRotate ("MainTexUVRotate (Degree)", Float) = 0
        [HideInInspector] _MainTexUVRotateMat ("MainTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MainUVSet ("Main UV Set", Float) = 0
        [HideInInspector] _MainTexUVWeights ("_MainTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Fresnel)]
        _FresnelBias ("Fresnel Bias (Default 0)", Range(-1, 2)) = 0
        _FresnelAffectOpacity ("Fresnel Affect Opacity", Range(0, 1)) = 1
        _FresnelPower ("Fresnel Power (Default 1)", Range(1, 10)) = 1
        [ToggleUI] _FresnelFlip ("Fresnel Flip", Float) = 0.001

        [Header(Near Camera Fade)]
        [ToggleUI] _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Start 1 (disappear)", Float) = 0
        _NearCameraFadeDistanceEnd ("Fade End 1 (appear)", Float) = 10
        _NearCameraFadeDistanceStart2 ("Fade Start 2 (disappear)", Float) = 0
        _NearCameraFadeDistanceEnd2 ("Fade End 2 (appear)", Float) = 100

        [Header(VFX Globals)]
        // HGRP global type_ShaderVariablesGlobal _VFXParams0 (c185); .w = per-VFX custom-particle time -> _Time.y.
        // Exposed for parity; the shader uses _Time.y directly (see frag). Kept HideInInspector to avoid editor noise.
        [HideInInspector] _VFXParams0 ("VFXParams0 (.w=custom time)", Vector) = (0, 0, 0, 0)

        // Render-state plumbing — driven by the material editor / OnValidate from _SurfaceType/_CullMode, not the shader.
        // Source pass "ForwardReflection" is ColorMask RGB, ZClip On, Cull [_CullMode], with NO explicit Blend/ZTest/ZWrite
        // (HGRP framework binds the reflection-pass depth state). We bind ZTest LEqual / ZWrite Off (transparent overlay
        // into the reflection target) and keep ColorMask RGB; clipping is what produces the mask coverage.
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 0
    }
    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 100

        HLSLINCLUDE
            // Core.hlsl brings ComputeWorldSpacePosition, UNITY_MATRIX_I_VP / UNITY_MATRIX_V, TransformWorldToView,
            // GetVertexPositionInputs/GetVertexNormalInputs, _WorldSpaceCameraPos, _ScreenParams, unity_OrthoParams,
            // unity_LODFade, _Time, SAMPLE_TEXTURE2D, CBUFFER_START. No Lighting.hlsl: this pass uses no lights.
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Reflection pass
                float  _ReflectionPassAlphaCutout;
                // Base
                float  _SurfaceType;
                float  _DisableVertColor;
                float  _InParticle;
                float  _DisableParticleInstanceColor;
                float  _TintColorAlpha;
                float4 _TintColor;
                // Main Tex
                float  _UseMainTexAsAlpha;
                float  _MainTexUVRotate;
                float4 _MainTexUVSpeed;
                float4 _MainTexUVRotateMat;   // 2x2 rotation packed (.xy = row0, .zw = row1). blob _MainTexUVRotateMat
                float  _MainUVSet;
                float4 _MainTexUVWeights;     // UV-set blend weights (.x=UV-axis, .y=particle-center). blob _MainTexUVWeights
                float4 _MainTex_ST;
                // Fresnel
                float  _FresnelBias;
                float  _FresnelAffectOpacity;
                float  _FresnelPower;
                float  _FresnelFlip;
                // Near camera fade
                float  _UseNearCameraFade;
                float  _NearCameraFadeDistanceStart;
                float  _NearCameraFadeDistanceEnd;
                float  _NearCameraFadeDistanceStart2;
                float  _NearCameraFadeDistanceEnd2;
                // VFX globals (re-exposed; unused at runtime, time taken from _Time.y)
                float4 _VFXParams0;
            CBUFFER_END

            // T0 = MainTex (blob b5:54, sampler_LinearClamp -> Clamp wrap). Sampled only to derive an alpha.
            TEXTURE2D(_MainTex);   SAMPLER(sampler_MainTex);

            // ----------------------------------------------------------------------------------------------
            // VFX MainTex UV — 1:1 with blob b5:104-106 (== b7:118-119; identical in every variant).
            // The blob inlines this once per .x and once per .y of the final UV; re-derived here as one function.
            //
            //   custom1     = TEXCOORD_1.x * _InParticle   (b5:104  "_139")   -> particle Custom1.X, gated by _InParticle
            //   uvAxis.x    = TEXCOORD.x   (mesh UV0.x)     uvAxis.y = TEXCOORD.y   (mesh UV0.y)
            //   center.x    = mad(TEXCOORD.z, _InParticle, -(TEXCOORD_1.x*_InParticle)) + TEXCOORD_1.x   (b5:105 inner)
            //               = TEXCOORD.z*_InParticle + TEXCOORD_1.x*(1 - _InParticle)     (particle-center remap on UV1.x slot)
            //   center.y    = mad(TEXCOORD.w, _InParticle, -(TEXCOORD_1.y*_InParticle)) + TEXCOORD_1.y     (UV1.y slot)
            //   blended.x   = mad(TEXCOORD.x, _MainTexUVWeights.x, center.x * _MainTexUVWeights.y)         (UV-set blend)
            //   scrolled.x  = mad(_MainTexUVSpeed.z, custom1, mad(_MainTexUVSpeed.x, _VFXParams0.w, blended.x))  [time + custom1]
            //   centered.x  = scrolled.x - 0.5                                                            (b5:105 "+(-0.5f)")
            //   rotated.x   = centered.x*_MainTexUVRotateMat.x + centered.y*_MainTexUVRotateMat.z + 0.5    (b5:105 2x2 rot)
            //   final.x     = mad(rotated.x, _MainTex_ST.x, _MainTex_ST.z)                                 (tiling.x, offset.z)
            //   (.y analogously uses _MainTexUVRotateMat.y/.w, _MainTex_ST.y/.w)
            // NOTE: the blob's last UV1.x term in the .y branch spells "(-0.0f) - _139" (== -(TEXCOORD_1.x*_InParticle))
            //   identically to the .x branch's "(-0.0f) - (TEXCOORD_1.x*_InParticle)" — same value; folded below.
            // ----------------------------------------------------------------------------------------------
            float2 ComputeVfxReflUV(float4 uv0, float4 custom1Set)
            {
                // uv0     = mesh UV0 (TEXCOORD): .xy = UV-axis, .zw = particle-center source (UV1 slot when _InParticle).
                // custom1Set = TEXCOORD_1: .x = Custom1.X (also UV1.x center fallback), .y = UV1.y center fallback.
                float time    = _Time.y;                                  // _VFXParams0.w -> _Time.y
                float custom1 = custom1Set.x * _InParticle;               // b5:104 "_139"

                // particle-center remap (b5:105 inner): center = uv0.zw*_InParticle + custom1Set.xy*(1-_InParticle)
                float2 center;
                center.x = mad(uv0.z, _InParticle, -(custom1Set.x * _InParticle)) + custom1Set.x;
                center.y = mad(uv0.w, _InParticle, -(custom1Set.y * _InParticle)) + custom1Set.y;

                // UV-set blend (b5:105): blended = uv0.xy*_MainTexUVWeights.x + center*_MainTexUVWeights.y
                float2 blended;
                blended.x = mad(uv0.x, _MainTexUVWeights.x, center.x * _MainTexUVWeights.y);
                blended.y = mad(uv0.y, _MainTexUVWeights.x, center.y * _MainTexUVWeights.y);

                // scroll by time (_MainTexUVSpeed.xy) + by Custom1 (_MainTexUVSpeed.zw) (b5:105)
                float2 scrolled;
                scrolled.x = mad(_MainTexUVSpeed.z, custom1, mad(_MainTexUVSpeed.x, time, blended.x));
                scrolled.y = mad(_MainTexUVSpeed.w, custom1, mad(_MainTexUVSpeed.y, time, blended.y));

                // 2x2 rotation about (0.5,0.5) via _MainTexUVRotateMat (b5:105)
                float2 c = scrolled - 0.5;
                float2 rotated;
                rotated.x = (c.x * _MainTexUVRotateMat.x) + (c.y * _MainTexUVRotateMat.z) + 0.5;
                rotated.y = (c.x * _MainTexUVRotateMat.y) + (c.y * _MainTexUVRotateMat.w) + 0.5;

                // tile + offset by _MainTex_ST (b5:105)
                float2 uv;
                uv.x = mad(rotated.x, _MainTex_ST.x, _MainTex_ST.z);
                uv.y = mad(rotated.y, _MainTex_ST.y, _MainTex_ST.w);
                return uv;
            }

            // Coverage alpha shared by both paths. 1:1 with blob b5:109 (base) / b7:127 (fresnel inner product).
            //   mainAlpha   = lerp(mainSample.a, mainSample.r, _UseMainTexAsAlpha)               (b5/b7 "_UseMainTexAsAlpha" term)
            //   vertGate    = lerp(vertColor.a, 1, _DisableVertColor)                            (b5/b7 "_DisableVertColor" term)
            //   coverage    = mainAlpha * vertGate * _TintColor.a * _TintColorAlpha              (clamped 0..1 by caller path)
            float VfxCoverageAlpha(float4 mainSample, float vertColorA)
            {
                float mainAlpha = mad(_UseMainTexAsAlpha, (-mainSample.a) + mainSample.x, mainSample.a); // lerp(a, r, flag)
                float vertGate  = mad(_DisableVertColor, (-vertColorA) + 1.0, vertColorA);               // lerp(a, 1, flag)
                return mainAlpha * (vertGate * _TintColor.w * _TintColorAlpha);
            }

            // View-space depth used by the near-camera fade: abs(view-space Z) of the world point.
            // Blob b5:108 (_282) / b7:126 (_390): abs( _ViewMatrix row-2 . worldPos + _ViewMatrix[3].z ).
            // URP 1:1: TransformWorldToView(worldPos).z is exactly UNITY_MATRIX_V row-2 . worldPos (+ translation).
            float ViewDepthAbs(float3 worldPos)
            {
                return abs(TransformWorldToView(worldPos).z);
            }

            // Near-camera dual-band fade. 1:1 with blob b7:127 (fresnel path's true near-fade fields; see header NOTE).
            //   gate==0 -> 1.0 ; else clamp((d - Start2)/(End2 - Start2),0,1) * clamp((d - Start)/(End - Start),0,1)
            float NearCameraFade(float viewDepth)
            {
                float band2 = clamp((viewDepth + (-_NearCameraFadeDistanceStart2)) / ((-_NearCameraFadeDistanceStart2) + _NearCameraFadeDistanceEnd2), 0.0, 1.0);
                float band1 = clamp((viewDepth + (-_NearCameraFadeDistanceStart))  / ((-_NearCameraFadeDistanceStart)  + _NearCameraFadeDistanceEnd),  0.0, 1.0);
                return (0.0 != _UseNearCameraFade) ? (band2 * band1) : 1.0;
            }

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;     // only consumed by the _USE_FRESNEL path
                float4 tangentOS  : TANGENT;    // declared for completeness; reflection pass uses normal only
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0;  // mesh UV0  -> blob TEXCOORD
                float4 texcoord1  : TEXCOORD1;  // Custom1 / UV1 -> blob TEXCOORD_1
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float4 uv0        : TEXCOORD0;  // mesh UV0 passthrough (blob vert TEXCOORD_2 = TEXCOORD). b4:80-83
                float4 custom1    : TEXCOORD1;  // Custom1/UV1 passthrough (blob TEXCOORD_1_1 = TEXCOORD_1). b4:84-87
                float4 vertColor  : TEXCOORD2;  // COLOR, with _DisableParticleInstanceColor scale. b4:88-92
                float3 normalWS   : TEXCOORD3;  // world normal (fresnel path only). b6:236-239
            };

            // Vertex: object->world->clip. HGRP source does the camera-relative non-jittered VP transform manually
            // (blob b4:67-76 / b6:205-256); URP GetVertexPositionInputs is the 1:1 infra equivalent (the only outputs the
            // kept fragment consumes are clip position, UV0, Custom1, vertex color, and — fresnel path — the world normal;
            // the prev-frame motion-vector outputs b4:88-103 / b6:249-254 are dropped with the MV target).
            //
            // Vertex-color particle scale (blob b4:88-92 / b6:245-248): when _unity_ObjectToWorld[3].z == 0 the color is
            // scaled by (1 - _DisableParticleInstanceColor), else passed through. The blob reads object origin Z to detect
            // the "not a particle instance" case. We replicate the exact gate using unity_ObjectToWorld._m23.
            Varyings vert(Attributes v)
            {
                Varyings o;
                VertexPositionInputs posIn = GetVertexPositionInputs(v.positionOS);
                o.positionCS = posIn.positionCS;
                o.uv0        = v.texcoord0;     // blob b4:80-83
                o.custom1    = v.texcoord1;     // blob b4:84-87

                // b4:88-92: _218 = (0 != ObjectToWorld[3].z); color = _218 ? COLOR : (1 - _Disable...) * COLOR.
                bool isInstance = (0.0 != unity_ObjectToWorld._m23);
                o.vertColor  = isInstance ? v.color : ((1.0 - _DisableParticleInstanceColor) * v.color);

                // World normal (fresnel path). HGRP decodes a packed normal (b6:131-201 spvBitfield codec) then transforms
                // by inverse-transpose (b6:217-222) and normalizes (b6:236-239). URP GetVertexNormalInputs is the 1:1 infra
                // equivalent (mesh provides a real float3 normal; the packed-normal codec is a vertex-stream detail).
                VertexNormalInputs nrmIn = GetVertexNormalInputs(v.normalOS, v.tangentOS);
                o.normalWS   = nrmIn.normalWS;
                return o;
            }

            // Reconstruct THIS fragment's world position from its own device depth (blob b5:103-108 / b7:110-113).
            float3 ReconstructWorldPos(float4 positionCS)
            {
                float2 screenUV = positionCS.xy / _ScreenParams.xy;       // b5:101-102 NDC from gl_FragCoord*_ScreenSize
                return ComputeWorldSpacePosition(screenUV, positionCS.z, UNITY_MATRIX_I_VP);
            }
        ENDHLSL

        Pass {
            Name "ForwardReflection"
            // Source pass: ColorMask RGB, ZClip On, Cull [_CullMode] (source .shader lines 89-94). Reflection-mask
            // overlay into the reflection target: depth-test but no depth-write; coverage produced by clip().
            ColorMask RGB
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]
            Tags { "LightMode"="SRPDefaultUnlit" }   // HGRP "ForwardReflection" has no URP analog; render as unlit overlay.

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_FRESNEL

            half4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                // ---- world reconstruction + view-space depth (both paths) ----
                float3 worldPos  = ReconstructWorldPos(input.positionCS);   // b5:103-108 / b7:110-113
                float  viewDepth = ViewDepthAbs(worldPos);                  // b5:108 (_282) / b7:126 (_390)

                // ---- MainTex sample (alpha source only) ----
                float2 mainUV    = ComputeVfxReflUV(input.uv0, input.custom1);          // b5:105 / b7:119
                // SampleBias(_GlobalMipBias) -> plain sample (HGRP global mip bias dropped). b5:106 / b7:120
                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, mainUV);

                // ---- coverage alpha (shared product) + LOD fade ----
                // NOTE: the FADE term differs between the two compiles (different uniforms — see each branch); only the
                // mainAlpha*vertGate*tint coverage product and the LOD-fade scale are shared. Do NOT hoist the fade.
                float coverage = VfxCoverageAlpha(mainSample, input.vertColor.w);      // b5:109 / b7:127 inner
                float lodFade  = 1.0 + (-unity_LODFade.y);                             // (1 - LODFade.y). b5:109 / b7:127

            #ifdef _USE_FRESNEL
                // ---- Fresnel(NdotV) (blob b7:114-125) ----
                // View dir: persp = camPos - worldPos ; ortho = camera forward (UNITY_MATRIX_V row-2). b7:114-117
                bool   isPersp = (0.0 == unity_OrthoParams.w);                          // b7:114 (_140)
                float3 viewVec = isPersp ? (_WorldSpaceCameraPos - worldPos)
                                         : float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22);
                // normalize with the blob's 1e-8 view-len epsilon. b7:122 (_298)
                float  vlen    = rsqrt(max(dot(viewVec, viewVec), 9.9999999392252902907785028219223e-09));
                float3 V       = viewVec * vlen;
                // front-face-flipped world normal: gl_FrontFacing ? N : -N. b7:123-124 (_305)
                float3 N       = isFrontFace ? input.normalWS : -input.normalWS;
                // fresnel = pow(saturate(dot(V, N) + _FresnelBias), _FresnelPower) via exp2(log2(.)*power). b7:124 (_339)
                float  fresnel = exp2(log2(clamp(dot(V, N) + _FresnelBias, 0.0, 1.0)) * _FresnelPower);
                float  invFres = (-fresnel) + 1.0;                                      // b7:125 (_373) = 1 - fresnel

                // opacity shaping: lerp(1, lerp(invFres, fresnel, _FresnelFlip), _FresnelAffectOpacity). b7:127
                //   inner = mad(_FresnelFlip, fresnel - invFres, invFres)
                //   fresnelOpacity = mad(inner, _FresnelAffectOpacity, 1 - _FresnelAffectOpacity)
                float  inner   = mad(_FresnelFlip, fresnel + (-invFres), invFres);
                float  fresOp  = mad(inner, _FresnelAffectOpacity, 1.0 + (-_FresnelAffectOpacity));

                // near-camera dual-band fade — the fresnel path uses the TRUE near-camera-fade fields (b7:127):
                //   gate = _UseNearCameraFade ; bands clamp((d-Start2)/(End2-Start2)) * clamp((d-Start)/(End-Start)).
                float  nearFade = NearCameraFade(viewDepth);                           // b7:127
                // full coverage product (b7:127): LOD * nearFade * (fresnelOpacity * clamp(coverage,0,1))
                float  alpha   = lodFade * (nearFade * (fresOp * clamp(coverage, 0.0, 1.0)));
                // clip when clamp(alpha,0,1) < _ReflectionPassAlphaCutout. b7:128
                clip(clamp(alpha, 0.0, 1.0) + (-_ReflectionPassAlphaCutout));

                // ---- output: Y-up octahedral encode of the world normal (blob b7:129-139) ----
                // n = normalize(rawNormal) (b7:129-132, uses the un-flipped interpolated normal)
                float3 n     = input.normalWS * rsqrt(dot(input.normalWS, input.normalWS));
                float  denom = dot(float3(1, 1, 1), abs(n));                            // |nx|+|ny|+|nz|. b7:133 (_471)
                float  ox    = n.x / denom;                                             // b7:134 (_474)
                float  oz    = n.z / denom;                                             // b7:135 (_475)
                bool   lowerHemi = (0.0 >= n.y);                                        // b7:136 (_476)
                // octahedral wrap for the lower hemisphere (b7:137-138):
                //   ox' = lowerHemi ? sign(ox)*(1 - |oz|) : ox   (sign via asfloat(±1) ternary; sign(0+)=+1)
                //   oz' = lowerHemi ? sign(oz)*(1 - |ox|) : oz
                float  encX  = lowerHemi ? (((ox >= 0.0) ? 1.0 : -1.0) * ((-abs(oz)) + 1.0)) : ox;
                float  encY  = lowerHemi ? (((oz >= 0.0) ? 1.0 : -1.0) * ((-abs(ox)) + 1.0)) : oz;
                // pack to [0,1]: enc*0.5 + 0.5 ; B channel = 1 (marker). b7:137-139
                return half4(mad(encX, 0.5, 0.5), mad(encY, 0.5, 0.5), 1.0, 1.0);
            #else
                // ---- non-fresnel coverage + clip (blob b5:109, transcribed VERBATIM) ----
                // CRITICAL 1:1: the no-fresnel compile uses a GENUINELY DIFFERENT fade than the fresnel path. Same cbuffer
                // byte layout, but the source HLSL wired different inputs under #ifdef _USE_FRESNEL. b5:109 reads (exact):
                //   gate  = (0 != _FresnelBias)
                //   band1 = clamp((viewDepth - _FresnelFlip) / (_UseNearCameraFade - _FresnelFlip), 0, 1)
                //   band2 = clamp((viewDepth - _FresnelAffectOpacity) / (_FresnelPower - _FresnelAffectOpacity), 0, 1)
                //   fade  = gate ? band1*band2 : 1.0
                //   cutout = _NearCameraFadeDistanceEnd2   (NOT _ReflectionPassAlphaCutout — b5's cbuffer lacks that field)
                // These are the literal named fields at those packoffsets (b5:43-51), NOT an aliasing artifact — do NOT
                // "correct" them to the b7 near-camera-fade. (This is a faithful port of a quirky/legacy code path.)
                float band1 = clamp((viewDepth + (-_FresnelFlip))          / ((-_FresnelFlip)          + _UseNearCameraFade), 0.0, 1.0);
                float band2 = clamp((viewDepth + (-_FresnelAffectOpacity)) / ((-_FresnelAffectOpacity) + _FresnelPower),      0.0, 1.0);
                float fade  = (0.0 != _FresnelBias) ? (band1 * band2) : 1.0;
                // full coverage product (b5:109): clamp( LOD * fade * coverage , 0, 1) ; clip if that < _NearCameraFadeDistanceEnd2
                float alpha = lodFade * (fade * coverage);
                clip(clamp(alpha, 0.0, 1.0) + (-_NearCameraFadeDistanceEnd2));

                // ---- output: flat reflection-mask marker (blob b5:111-113) ----
                return half4(0.5, 1.0, 1.0, 1.0);
            #endif
            }
            ENDHLSL
        }
    }
}
