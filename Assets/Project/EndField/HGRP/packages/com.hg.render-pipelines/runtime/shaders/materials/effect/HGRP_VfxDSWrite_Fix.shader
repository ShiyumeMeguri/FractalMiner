// HGRP VFX DS-Write — single transparent ForwardOnly VFX surface (depth/distance-write particle quad).
// An unlit camera-relative VFX surface (sibling of vfxline): samples a scrolling/rotating MainTex,
// tints it by vertex-color * _TintColor * intensity, applies an exponential "Exp" glow boost
// (color + ExpIntensity * max(color - ExpThreshold, 0)), divides by post-exposure, then applies a
// global VFX saturation+recolor (lerp(luma, color, _VFXParams1.w) * _VFXParams1.rgb), and finally a
// near-camera distance fade reconstructed from this fragment's own device depth. MainTex UV is built
// in the VERTEX shader (mesh UV0, particle custom-UV, scroll by time + Custom1.X, degree rotation,
// _MainTex_ST tiling) selected by _MainUVSet (UV vs PolarUV/particle set). Optional grid-line geometry
// mode (_USE_GRID_LINE) screen-space-thickens thin edges to a min pixel width, and optional alpha test.
// Merged from: vfxdswrite.shader
//   Vertex base (catch-all #else) = vfxdswrite/Sub0_Pass0_Vertex_b6.hlsl   (KW: HG_ENABLE_MV)
//   Vertex grid                   = vfxdswrite/Sub0_Pass0_Vertex_b8.hlsl   (HG_ENABLE_MV + _USE_GRID_LINE)
//   Frag  base  (catch-all #else) = vfxdswrite/Sub0_Pass0_Fragment_b7.hlsl (KW: HG_ENABLE_MV)
//   Frag  grid                    = vfxdswrite/Sub0_Pass0_Fragment_b9.hlsl (HG_ENABLE_MV + _USE_GRID_LINE)
//   Frag  alphatest               = vfxdswrite/Sub0_Pass0_Fragment_b11.hlsl(HG_ENABLE_MV + _ALPHATEST_ON + _USE_GRID_LINE)
// Keywords: _USE_GRID_LINE, _ALPHATEST_ON
// Kept: vertex-built MainTex UV (mesh UV0 vs particle-set via _MainUVSet, scroll _MainTexUVSpeed.xy*time +
//   .zw*Custom1.X, degree->radian rotation, _MainTex_ST tiling; blob b6:108-116), particle-instance vertex
//   color attenuation (_DisableParticleInstanceColor + _unity_Float4x5_Param2; blob b6:119-123), vertex-color
//   gate (_DisableVertColor), tint*intensity / post-exposure divide (_ExposureParams.x/_IgnorePostExposure;
//   blob b7:92-95), UseMainTexAsAlpha channel remap (blob b7:88-90), exponential Exp glow
//   (_ExpThreshold/_ExpIntensity; blob b7:96-99), global VFX saturation+recolor (luma lerp by _VFXParams1.w,
//   per-channel mul _VFXParams1.xyz; blob b7:100-104), near-camera double-ring distance fade from this
//   fragment's own device depth via InvViewProj+ViewMatrix.z (blob b7:105-110), _ForceMoveToFarPlane clip-z,
//   grid-line screen-space min-pixel-width thickening of thin edges (blob vert b8:101-153), alpha test clip
//   (blob frag b11:104/124/147), STRAIGHT (non-premultiplied) color out + fixed-function Blend factors,
//   _SurfaceType-gated output alpha.
// Removed: SPIRV-Cross plumbing (gl_Position/gl_FragCoord/SV_Target statics, frag_main/vert_main glue,
//   discard_state helper); HGRP global cbuffer (type_ShaderVariablesGlobal) mapped to URP globals
//   (UNITY_MATRIX_I_VP / UNITY_MATRIX_V / _ScreenParams / _Time / unity_ObjectToWorld) or re-exposed material
//   Vectors (_ExposureParams, _VFXParams0, _VFXParams1, _GlobalMipBias); HGRP camera-relative rendering
//   (_WorldSpaceCameraPos_Internal subtraction + _NonJitteredViewNoTransProjMatrix no-translation VP) replaced
//   by URP absolute-world GetVertexPositionInputs / UNITY_MATRIX_VP; TAA jitter (_TaaJitterStrength);
//   instancing (SRP_INSTANCING_ON); type_UnityPerDraw _unity_MatrixPreviousM/_unity_MotionVectorsParamsInternal.
//
// NOTE: MOTION-VECTOR / RESPONSIVE second render target DROPPED. The HGRP source is an MRT shader: SV_Target0 =
//   color (kept), SV_Target1 = packed screen-space velocity (.xy) + responsive/transparent-MV flag (.w) computed
//   from this-frame vs previous-frame non-jittered clip pos (blob b7:111-120, vert b6:124-134). URP forward VFX
//   has no second VFX-velocity RT in this sandbox, so SV_Target1 and everything feeding ONLY it is removed:
//   _NonJitteredViewNoTransProjMatrix/_PrevNonJitteredViewNoTransProjMatrix/_PrevCamPosRWS_Internal, previous-M,
//   _TaaJitterStrength, _Responsive, _EnableTransparentMV. See gaps[] — this is the only non-1:1 omission.
// NOTE: _VFXParams0.w (HGRP per-VFX custom time) -> _Time.y; _VFXParams0.x reserved for Custom1.X particle data
//   (drives _MainTexUVSpeed.zw scroll, blob b6:108/110-111) — left as material Vector, default 0.
//   _VFXParams1 (HGRP per-VFX global color) re-exposed material Vector: .xyz = post color multiply, .w = saturation
//   (0=grayscale .. 1=full color); neutral default (1,1,1,1). _ExposureParams.x = post-exposure (default 1).
// NOTE: near-camera-fade view-space Z (blob b7:105-108) is reconstructed from THIS fragment's own SV_Position.z
//   (== blob gl_FragCoord.z), NOT the scene depth buffer, so NO URP depth texture is required. The HGRP source
//   _InvViewProjMatrix is camera-RELATIVE; URP UNITY_MATRIX_I_VP is absolute, but only |viewZ| (camera distance)
//   is consumed by the fade, and that distance is identical under both — so the fade is exactly 1:1.

Shader "HGRP/VfxDSWrite_Fix" {
    Properties {
        [Header(Base)]
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [Enum(Off, 0, On, 1)] _ZWriteMode ("ZWrite Mode", Float) = 1
        [ToggleUI] _DisableVertColor ("Disable Vert Color", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 1
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity", Range(1, 100)) = 1
        _ExpThreshold ("Exp Threshold", Range(0, 1)) = 1
        _ExpIntensity ("Exp Intensity", Range(0, 100)) = 0
        _TintColorAlpha ("Tint Color Alpha", Range(0, 10)) = 1
        [ToggleUI] _DisableParticleInstanceColor ("Disable Particle Instance Color", Float) = 0

        [Header(Main Tex)]
        _MainTex ("Main Tex", 2D) = "white" {}
        [Enum(UV, 0, PolarUV, 1)] _MainUVSet ("Main UV Set", Float) = 0
        [ToggleUI] _UseMainTexAsAlpha ("Use Main Tex As Alpha", Float) = 1
        _MainTexUVSpeed ("MainTexUVSpeed (XY:By Time, ZW:By Custom1.X)", Vector) = (0, 0, 0, 0)
        _MainTexUVRotate ("MainTexUVRotate (Degree)", Float) = 0

        [Header(Far Plane and Grid Line)]
        [ToggleUI] _ForceMoveToFarPlane ("Move To Far Plane", Float) = 0
        [Toggle(_USE_GRID_LINE)] _UseGridLine ("Grid Line", Float) = 0
        _GridLineWidth ("Grid Line Width", Range(0.1, 15)) = 1

        [Header(Near Camera Fade)]
        _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Disappear Distance 1", Range(0.001, 200)) = 0.001
        _NearCameraFadeDistanceEnd ("Appear Distance 1", Range(0.001, 200)) = 10
        _NearCameraFadeDistanceEnd2 ("Appear Distance 2", Range(0.002, 200)) = 100
        _NearCameraFadeDistanceStart2 ("Disappear Distance 2", Range(0.001, 200)) = 120

        [Header(Alpha Test)]
        [Toggle(_ALPHATEST_ON)] _UseAlphaTest ("Use Alpha Test", Float) = 0
        _AlphaClipThreshold ("Clip Threshold", Range(0, 1)) = 1

        [Header(VFX Globals re exposed as material Vectors)]
        // HGRP global type_ShaderVariablesGlobal: _ExposureParams (c109), _VFXParams0 (c185), _VFXParams1 (c186),
        // _GlobalMipBias (c108). URP has no equivalents; the C# VFX driver writes these per-effect.
        _ExposureParams ("ExposureParams (.x = post exposure)", Vector) = (1, 0, 0, 0)
        _VFXParams0 ("VFXParams0 (.x = Custom1.X)", Vector) = (0, 0, 0, 0)
        _VFXParams1 ("VFXParams1 (.xyz = color mul, .w = saturation)", Vector) = (1, 1, 1, 1)
        _GlobalMipBias ("Global Mip Bias", Float) = 0

        // Render-state plumbing — driven by the material editor / OnValidate from _BlendMode/_SurfaceType/
        // _CullMode/_ZWriteMode, not by the shader. Mirrors source .shader lines 45-57.
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 0
        [HideInInspector] _StencilRef ("_StencilRef", Float) = 0
        [HideInInspector] _StencilWriteMask ("_StencilWriteMask", Float) = 255
        [HideInInspector] _StencilComp ("_StencilComp", Float) = 8
        [HideInInspector] _StencilOp ("_StencilOp", Float) = 0
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
            // Core.hlsl brings ComputeWorldSpacePosition, UNITY_MATRIX_I_VP/UNITY_MATRIX_V, GetVertexPositionInputs,
            // _ScreenParams, _Time, SAMPLE_TEXTURE2D[_BIAS], CBUFFER_START. The near-camera fade reconstructs view-Z
            // from THIS fragment's own SV_Position.z (no scene depth texture needed), so no DeclareDepthTexture.
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Base
                float  _SurfaceType;
                float  _BlendMode;
                float  _DisableVertColor;
                float  _InParticle;
                float  _IgnorePostExposure;
                float  _TintColorIntensity;
                float  _TintColorAlpha;
                float  _ExpThreshold;
                float  _ExpIntensity;
                float  _DisableParticleInstanceColor;
                float4 _TintColor;
                // Main Tex
                float  _MainUVSet;
                float  _UseMainTexAsAlpha;
                float  _MainTexUVRotate;
                float4 _MainTexUVSpeed;
                float4 _MainTex_ST;
                // Far plane / grid line
                float  _ForceMoveToFarPlane;
                float  _GridLineWidth;
                // Near camera fade
                float  _UseNearCameraFade;
                float  _NearCameraFadeDistanceStart;
                float  _NearCameraFadeDistanceEnd;
                float  _NearCameraFadeDistanceEnd2;
                float  _NearCameraFadeDistanceStart2;
                // Alpha test
                float  _AlphaClipThreshold;
                // HGRP globals re-exposed
                float4 _ExposureParams;
                float4 _VFXParams0;
                float4 _VFXParams1;
                float  _GlobalMipBias;
                // Render state
                float  _TransparentSortPriority;
            CBUFFER_END

            // T0 = MainTex (blob frag b7:54, sampler_LinearClamp -> Clamp wrap).
            TEXTURE2D(_MainTex);   SAMPLER(sampler_MainTex);

            // Rec.709 luminance weights. Blob spells the dot weights
            // (0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625). b7:100
            static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625);
            // Degrees -> radians. Blob spells 0.01745329238474369049072265625f (= PI/180). vert b6:112
            static const float DEG2RAD = 0.01745329238474369049072265625;
            // Min squared length for grid-line normal normalize (= FLT_MIN). vert b8:116
            static const float FLT_MIN = 1.1754943508222875079687365372222e-38f;
            // 0.01 grid-line screen scale. vert b8:142-143 (0.00999999977648258209228515625f)
            static const float GRIDLINE_SCALE = 0.00999999977648258209228515625;

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;     // grid-line only (blob vert b8 reads NORMAL)
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0;  // mesh UV0 (.xy) + particle custom UV (.zw). blob vert b6: TEXCOORD
                float4 texcoord1  : TEXCOORD1;  // particle position/UV data. blob vert b6: TEXCOORD_1
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float4 uv         : TEXCOORD0;  // .xy = mesh UV0 passthrough, .zw = computed MainTex UV. blob vert b6:115-118 (TEXCOORD_2)
                float4 vertColor  : TEXCOORD1;  // attenuated vertex color. blob vert b6:120-123 (TEXCOORD_1_1)
            };

            // ----------------------------------------------------------------
            // Build the MainTex UV exactly per blob vert b6:108-116.
            //   custom1X    : Custom1.X particle data driving the .zw scroll (= TEXCOORD_1.x * _InParticle). b6:108
            //   baseUV      : per-UV-set base coordinate selected by _MainUVSet (b6:109-111):
            //                   _MainUVSet==0 -> mesh UV0 (TEXCOORD.xy)
            //                   _MainUVSet!=0 -> particle-set UV (TEXCOORD.zw blended with TEXCOORD_1.xy * _InParticle)
            //   time        : _VFXParams0.w -> _Time.y
            // Then:
            //   p   = speed.xy*time + speed.zw*custom1X + baseUV - 0.5     (b6:110-111, then +(-0.5))
            //   ang = DEG2RAD * _MainTexUVRotate ; s=sin, c=cos           (b6:112-114)
            //   uv.x = mad(dot(p, float2( c, s)) + 0.5, _MainTex_ST.x, _MainTex_ST.z)   (b6:115)
            //   uv.y = mad(dot(p, float2(-s, c)) + 0.5, _MainTex_ST.y, _MainTex_ST.w)   (b6:116)
            // ----------------------------------------------------------------
            float2 ComputeMainTexUV(float4 texcoord0, float4 texcoord1, float time)
            {
                float custom1X = texcoord1.x * _InParticle;                             // b6:108 (_177)
                bool polarSet = (0.0 != _MainUVSet);                                    // b6:109 (_199)
                // Base U (b6:110): polarSet ? (mad(TEXCOORD.z, _InParticle, -custom1X) + TEXCOORD_1.x) : TEXCOORD.x
                float baseU = polarSet ? (mad(texcoord0.z, _InParticle, -custom1X) + texcoord1.x) : texcoord0.x;
                // Base V (b6:111): polarSet ? (mad(TEXCOORD.w, _InParticle, -(TEXCOORD_1.y*_InParticle)) + TEXCOORD_1.y) : TEXCOORD.y
                float baseV = polarSet ? (mad(texcoord0.w, _InParticle, -(texcoord1.y * _InParticle)) + texcoord1.y) : texcoord0.y;
                // p = speed.zw*custom1X + speed.xy*time + base - 0.5  (b6:110-111)
                float px = mad(_MainTexUVSpeed.z, custom1X, mad(_MainTexUVSpeed.x, time, baseU)) - 0.5;
                float py = mad(_MainTexUVSpeed.w, custom1X, mad(_MainTexUVSpeed.y, time, baseV)) - 0.5;
                float ang = DEG2RAD * _MainTexUVRotate;                                 // b6:112
                float s = sin(ang);                                                     // b6:113
                float c = cos(ang);                                                     // b6:114
                float2 p = float2(px, py);
                float2 uv;
                uv.x = mad(dot(p, float2( c, s)) + 0.5, _MainTex_ST.x, _MainTex_ST.z);  // b6:115
                uv.y = mad(dot(p, float2(-s, c)) + 0.5, _MainTex_ST.y, _MainTex_ST.w);  // b6:116
                return uv;
            }

            // ----------------------------------------------------------------
            // Attenuate vertex color by particle-instance fade (blob vert b6:119-123).
            //   _DisableParticleInstanceColor != 0 -> color unchanged
            //   else                               -> color * (1 - _unity_Float4x5_Param2)  (instance dissolve)
            // _unity_Float4x5_Param2 is a per-draw particle attribute with no URP equivalent in this sandbox;
            // with instancing dropped it is 0 -> the branch is identity. Kept as the 1:1 gate (uses 0).
            // ----------------------------------------------------------------
            float4 AttenuateVertColor(float4 color)
            {
                bool keep = (0.0 != _DisableParticleInstanceColor);                     // b6:119 (_294)
                // _unity_Float4x5_Param2 dropped (instancing) -> 0; (1 - 0) = 1 -> identity.
                float4 instFade = float4(1.0, 1.0, 1.0, 1.0);
                return keep ? color : (instFade * color);
            }

            half4 frag(Varyings input) : SV_Target
            {
                // ---- MainTex sample at the vertex-computed UV (blob b7:83) ----
                // SampleBias(_GlobalMipBias) -> URP SAMPLE_TEXTURE2D_BIAS. b7:83
                float4 mainSample = SAMPLE_TEXTURE2D_BIAS(_MainTex, sampler_MainTex, input.uv.zw, _GlobalMipBias);

                // ---- UseMainTexAsAlpha: remap rgb -> lerp(rgb, 1, flag) (blob b7:88-90) ----
                // mad(flag, (1 - c), c) per channel.
                float3 mainRGB = lerp(mainSample.rgb, float3(1, 1, 1), _UseMainTexAsAlpha);

                // ---- Vertex-color gate (blob b7:91) ----
                bool disableVC = (0.0 != _DisableVertColor);                            // b7:91 (_82)

                // ---- Post-exposure divisor (blob b7:92) ----
                // _127 = mad(_IgnorePostExposure, _ExposureParams.x - 1, 1)
                float exposureDiv = mad(_IgnorePostExposure, _ExposureParams.x - 1.0, 1.0);

                // ---- Tint RGB (blob b7:93-95) ----
                // ((disableVC?1:vc.rgb) * _TintColor.rgb * _TintColorIntensity) / exposureDiv
                float3 vc3  = disableVC ? float3(1, 1, 1) : input.vertColor.rgb;
                float3 tint = (vc3 * _TintColor.rgb * _TintColorIntensity) / exposureDiv;

                // ---- Color before Exp glow ----
                float3 color = tint * mainRGB;

                // ---- Exponential "Exp" glow + clamp (blob b7:96-99) ----
                // per-channel: clamp(mad(max(color - _ExpThreshold, 0), _ExpIntensity, color), 0, 1000)
                float3 expExcess = max(color - _ExpThreshold, 0.0);                     // b7:96-97 inner (_139 = -_ExpThreshold)
                float3 glow      = clamp(mad(expExcess, _ExpIntensity, color), 0.0, 1000.0); // b7:97-99 (_155/_157/_158)

                // ---- Global VFX saturation + recolor (blob b7:100-104) ----
                // luma = dot(glow, LUM); out.rgb = lerp(luma, glow, _VFXParams1.w) * _VFXParams1.xyz
                //   blob: mad(_VFXParams1.w, (-luma + glow), luma) * _VFXParams1.x   ( _165 = -_159 )
                float luma = dot(glow, LUM);                                            // b7:100 (_159)
                float3 outColor;
                outColor.x = mad(_VFXParams1.w, glow.x - luma, luma) * _VFXParams1.x;   // b7:102
                outColor.y = mad(_VFXParams1.w, glow.y - luma, luma) * _VFXParams1.y;   // b7:103
                outColor.z = mad(_VFXParams1.w, glow.z - luma, luma) * _VFXParams1.z;   // b7:104

                // ---- Near-camera distance fade (blob b7:105-110) ----
                // Reconstruct view-space Z from THIS fragment's own device depth (== gl_FragCoord.z), NOT scene depth.
                // HGRP: NDC.xy = mad(fragcoord.xy * _ScreenSize.zw, 2, -1) with Y negated (b7:105-106), unproject with
                // _InvViewProjMatrix to world, then world->view via _ViewMatrix row 2 (.z) -> view-space Z (_267).
                // URP 1:1 infra: ComputeWorldSpacePosition(screenUV, posCS.z, UNITY_MATRIX_I_VP) -> world; viewZ via
                // UNITY_MATRIX_V row 2. Only |viewZ| (camera distance) is consumed below, identical absolute vs
                // camera-relative, so this is exactly 1:1.
                float2 screenUV = input.positionCS.xy / _ScreenParams.xy;
                float3 worldPos = ComputeWorldSpacePosition(screenUV, input.positionCS.z, UNITY_MATRIX_I_VP);
                float  viewZ    = mul(UNITY_MATRIX_V, float4(worldPos, 1.0)).z;         // b7:108 (_267, _ViewMatrix.z row)

                // Double-ring fade (b7:109): _UseNearCameraFade!=0 ?
                //   clamp((|viewZ| - start2)/(end2 - start2), 0,1) * clamp((|viewZ| - start)/(end - start), 0,1) : 1
                float absViewZ = abs(viewZ);
                float ring2 = saturate((absViewZ - _NearCameraFadeDistanceStart2) /
                                       (_NearCameraFadeDistanceEnd2 - _NearCameraFadeDistanceStart2));
                float ring1 = saturate((absViewZ - _NearCameraFadeDistanceStart) /
                                       (_NearCameraFadeDistanceEnd  - _NearCameraFadeDistanceStart));
                float fade = (0.0 != _UseNearCameraFade) ? (ring2 * ring1) : 1.0;

                // ---- Output alpha (blob b7:109-110) ----
                // alpha = clamp(fade * (mainAlphaChannel * ((disableVC?1:vc.a) * _TintColor.a * _TintColorAlpha)), 0, 1)
                // mainAlphaChannel: mad(_UseMainTexAsAlpha, mainSample.r - mainSample.a, mainSample.a) = lerp(a, r, flag). b7:109 inner
                float mainA = lerp(mainSample.a, mainSample.r, _UseMainTexAsAlpha);
                float vcA   = disableVC ? 1.0 : input.vertColor.w;                      // b7:109 (_82 ? 1 : TEXCOORD_1.w)
                float alpha = saturate(fade * (mainA * (vcA * _TintColor.w * _TintColorAlpha)));

                // ---- Alpha test (blob frag b11:104/124/147) ----
                // The _ALPHATEST_ON variant clips against _AlphaClipThreshold using the SAME alpha product (b11:123-124,
                // discard_cond(_260 < _AlphaClipThreshold)). Exactly the saturated alpha above.
                #ifdef _ALPHATEST_ON
                    clip(alpha - _AlphaClipThreshold);                                  // b11:124
                #endif

                // ---- Output: STRAIGHT (non-premultiplied) color, exactly as the HGRP source ----
                // Source writes SV_Target.rgb = outColor (b7:102-104) and SV_Target.a = alpha (b7:110); fixed-function
                // Blend factors then composite (_BlendMode=Additive -> _SrcBlend=One; Alpha -> SrcAlpha). Do NOT
                // premultiply. The color-buffer alpha is the clamped product (b7:110); _SurfaceType gates ONLY the
                // dropped MV RT (SV_Target_1, b7:111/117-120), so we output the straight alpha verbatim.
                return half4(outColor, alpha);
            }

            // ----------------------------------------------------------------
            // BASE vertex (blob vert b6:93-118 — kept clip+UV+color; MV outputs dropped with SV_Target1).
            // HGRP does camera-relative posWS (b6:95-97) then _NonJitteredViewNoTransProjMatrix (no-translation VP)
            // with TAA jitter (b6:98-104); URP's GetVertexPositionInputs is the 1:1 infra equivalent for the only
            // pixel-affecting output the kept fragment consumes (clip position). _ForceMoveToFarPlane forces clip-z
            // to the reversed-Z far plane (b6:103). UV (b6:108-116) + attenuated color (b6:119-123) passed through.
            // ----------------------------------------------------------------
            Varyings vertBase(Attributes v)
            {
                Varyings o;
                VertexPositionInputs posIn = GetVertexPositionInputs(v.positionOS);
                o.positionCS = posIn.positionCS;
                // _ForceMoveToFarPlane: clip-z -> far plane. b6:103 sets gl_Position.z = 0 (HGRP reversed-Z far);
                // URP reversed-Z far is also 0, so write 0 directly (UNITY_RAW_FAR_CLIP_VALUE under reversed-Z).
                if (0.0 != _ForceMoveToFarPlane)
                {
                    o.positionCS.z = UNITY_RAW_FAR_CLIP_VALUE * o.positionCS.w;
                }
                o.uv.xy = v.texcoord0.xy;                                               // b6:117-118 (TEXCOORD_2.xy = TEXCOORD.xy)
                o.uv.zw = ComputeMainTexUV(v.texcoord0, v.texcoord1, _Time.y);          // b6:108-116
                o.vertColor = AttenuateVertColor(v.color);                              // b6:119-123
                return o;
            }

            #ifdef _USE_GRID_LINE
            // ----------------------------------------------------------------
            // GRID-LINE vertex (blob vert b8:101-153). After the base clip transform, thin near-silhouette edges
            // are pushed out in screen space to a minimum pixel width so the line never sub-pixels away.
            //   1. World-space normal (inverse-transpose-ish: NORMAL / |ObjectToWorld column|^2, then normalize). b8:101-119
            //   2. View direction = normalize(cameraPos - worldPos). b8:120-126
            //   3. Screen tangent = normalize( cross-ish of (normal, viewDir) ) -> _224/_225/_226. b8:127-136
            //   4. Project tangent.xy through the (no-translation) VP, aspect-correct, scale by _GridLineWidth*0.01. b8:137-143
            //   5. minPixelWidth = (0.75 / min(screen.x,screen.y)) * clipW ; if |offset|<minPixelWidth, snap offset to
            //      sign(rawProj)*minPixelWidth, then add to clip.xy. b8:150-152
            // 1:1 infra: ObjectToWorld via unity_ObjectToWorld, normal via UNITY_MATRIX_VP for the screen projection,
            // worldPos/cameraPos via TransformObjectToWorld/_WorldSpaceCameraPos. _ScreenParams replaces _ScreenSize.
            // ----------------------------------------------------------------
            Varyings vertGridLine(Attributes v)
            {
                Varyings o = vertBase(v);

                // World-space normal (b8:101-119). Inverse-transpose via per-column 1/|col|^2 scale then ObjectToWorld
                // rotate, then normalize with FLT_MIN floor. URP unity_ObjectToWorld columns == blob _unity_ObjectToWorld.
                float3 c0 = float3(unity_ObjectToWorld[0].x, unity_ObjectToWorld[1].x, unity_ObjectToWorld[2].x); // column 0
                float3 c1 = float3(unity_ObjectToWorld[0].y, unity_ObjectToWorld[1].y, unity_ObjectToWorld[2].y); // column 1
                float3 c2 = float3(unity_ObjectToWorld[0].z, unity_ObjectToWorld[1].z, unity_ObjectToWorld[2].z); // column 2
                float3 nScaled;                                                         // b8:110-112
                nScaled.x = (1.0 / dot(c0, c0)) * v.normalOS.x;
                nScaled.y = (1.0 / dot(c1, c1)) * v.normalOS.y;
                nScaled.z = (1.0 / dot(c2, c2)) * v.normalOS.z;
                float3 nWS;                                                             // b8:113-115 (ObjectToWorld * nScaled)
                nWS.x = mad(unity_ObjectToWorld[0].z, nScaled.z, mad(unity_ObjectToWorld[0].x, nScaled.x, nScaled.y * unity_ObjectToWorld[0].y));
                nWS.y = mad(unity_ObjectToWorld[1].z, nScaled.z, mad(unity_ObjectToWorld[1].x, nScaled.x, nScaled.y * unity_ObjectToWorld[1].y));
                nWS.z = mad(unity_ObjectToWorld[2].z, nScaled.z, mad(unity_ObjectToWorld[2].x, nScaled.x, nScaled.y * unity_ObjectToWorld[2].y));
                float invLenN = rsqrt(max(dot(nWS, nWS), FLT_MIN));                     // b8:116
                nWS *= invLenN;                                                         // b8:117-119 (_145/_146/_147)

                // View direction = normalize(cameraPos - worldPos_of_TEXCOORD_1) (b8:120-126).
                // blob uses TEXCOORD_1 (particle position) for the world point; mirror with that attribute.
                float3 wpForView;                                                       // b8:120-122 (ObjectToWorld * TEXCOORD_1.xyz)
                wpForView.x = mad(unity_ObjectToWorld[0].z, v.texcoord1.z, mad(unity_ObjectToWorld[0].x, v.texcoord1.x, v.texcoord1.y * unity_ObjectToWorld[0].y)) + unity_ObjectToWorld[0].w;
                wpForView.y = mad(unity_ObjectToWorld[1].z, v.texcoord1.z, mad(unity_ObjectToWorld[1].x, v.texcoord1.x, v.texcoord1.y * unity_ObjectToWorld[1].y)) + unity_ObjectToWorld[1].w;
                wpForView.z = mad(unity_ObjectToWorld[2].z, v.texcoord1.z, mad(unity_ObjectToWorld[2].x, v.texcoord1.x, v.texcoord1.y * unity_ObjectToWorld[2].y)) + unity_ObjectToWorld[2].w;
                float3 viewVec = _WorldSpaceCameraPos - wpForView;                      // b8:120-122 (cam - wp)
                float invLenV = rsqrt(dot(viewVec, viewVec));                           // b8:123
                float3 viewDir = viewVec * invLenV;                                     // b8:124-126 (_204/_205/_206)

                // Screen tangent = normalize( nWS x viewDir ) component form (b8:127-129).
                // The blob STORES the normalized view-dir lane-permuted: _204=VY, _205=VZ, _206=VX
                // (b8:120-126 compute Y/Z/X first), so its _213/_214/_215 still equal the NATURAL-order
                // cross product nWS x V (verified). Our viewDir is natural (X,Y,Z), so emit the plain cross
                // directly — substituting viewDir.x/.y/.z into the blob's _204/_205/_206 slots verbatim would
                // mis-permute the lanes and produce a scrambled (wrong-direction) tangent.
                float3 tang;                                                            // b8:127-129 (_213/_214/_215) == cross(nWS, viewDir)
                tang.x = mad(nWS.y, viewDir.z, -(nWS.z * viewDir.y));
                tang.y = mad(nWS.z, viewDir.x, -(nWS.x * viewDir.z));
                tang.z = mad(nWS.x, viewDir.y, -(nWS.y * viewDir.x));
                float invLenT = rsqrt(dot(tang, tang));                                 // b8:133
                tang *= invLenT;                                                        // b8:134-136 (_224/_225/_226)

                // Project tangent.xy through VP (no-translation in HGRP -> URP UNITY_MATRIX_VP rotation part). b8:137-139
                float projX = mad(UNITY_MATRIX_VP[0].z, tang.z, mad(UNITY_MATRIX_VP[0].x, tang.x, tang.y * UNITY_MATRIX_VP[0].y));
                float projY = mad(UNITY_MATRIX_VP[1].z, tang.z, mad(UNITY_MATRIX_VP[1].x, tang.x, tang.y * UNITY_MATRIX_VP[1].y));
                float invLenP = rsqrt(dot(float2(projX, projY), float2(projX, projY))); // b8:139
                // Aspect correct: x *= screen.y/screen.x, y *= 1; * _GridLineWidth. b8:140-141
                float ox = ((invLenP * projX) * (_ScreenParams.y / _ScreenParams.x)) * _GridLineWidth;
                float oy = ((invLenP * projY) * 1.0) * _GridLineWidth;
                float offX = ox * GRIDLINE_SCALE;                                       // b8:142 (_273)
                float offY = oy * GRIDLINE_SCALE;                                       // b8:143 (_275)

                // minPixelWidth = (0.75 / min(screen.y, screen.x)) * clipW (b8:150). clipW = positionCS.w.
                float minPix = (0.75 / min(_ScreenParams.y, _ScreenParams.x)) * o.positionCS.w;
                // if |off| < minPix -> snap to sign(rawProj)*minPix, else keep off; then add to clip.xy. b8:151-152
                float snapX = (abs(offX) < minPix) ? (sign(ox) * minPix) : offX;
                float snapY = (abs(offY) < minPix) ? (sign(oy) * minPix) : offY;
                o.positionCS.x += snapX;
                o.positionCS.y += snapY;
                return o;
            }
            #endif

            Varyings vert(Attributes v)
            {
                #ifdef _USE_GRID_LINE
                    return vertGridLine(v);
                #else
                    return vertBase(v);
                #endif
            }
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }

            // Source .shader lines 67-80. RGB + alpha blend factors all bound from material props (set by the
            // blend-mode/surface-type editor); property defaults One/Zero. The source's MRT1 motion-vector blend
            // (line 68 "Blend 1 ...") is dropped with SV_Target1. ZTest/ZWrite/Cull/Stencil from props.
            Blend [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWriteMode]
            Cull [_CullMode]
            Stencil {
                Ref [_StencilRef]
                WriteMask [_StencilWriteMask]
                Comp [_StencilComp]
                Pass [_StencilOp]
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_GRID_LINE
            #pragma shader_feature_local _ALPHATEST_ON
            ENDHLSL
        }
    }
}
