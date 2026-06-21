// HGRP VFX Electric-Wire Factory — Unified Fix shader (single ForwardOnly pass, transparent unlit billboard wire).
// Merged from: vfxelectricwirefactory.shader (Sub0_Pass0). Base variant blobs Vertex_b4 / Fragment_b5 (catch-all #else, keyword set: HG_ENABLE_MV);
//   mask + polar-UV + screen-UV deltas folded from Vertex_b6 / Fragment_b7 (keywords HG_ENABLE_MV _USE_MASK _USE_POLARUV _USE_SCREENUV).
// Keywords: _USE_MASK, _USE_SCREENUV, _USE_POLARUV   (driven by [Toggle] props; collapsed from #pragma multi_compile_local).
// Kept: camera-facing wire billboard frame + screen-space min-width expansion, world-distance highlight ramp (smoothstep),
//   WireRampTex tint × MainTex (UseMainTexAsAlpha select), exp-threshold glow, near-camera double fade, mask tex (RGB+alpha select),
//   per-channel UV scroll/rotate/ST, MeshUV / ScreenUV(+depth) / PolarUV switch, particle custom-data UV blend, vertex-color/disturb,
//   _Responsive transparent flag, _SurfaceType opaque/transparent alpha gate, additive/alpha blend, exposure divide, VFX color-grade.
// Removed (pixel-neutral HGRP pipeline infra substituted by URP, or HGRP-internal global with no URP single-pass equivalent):
//   motion vectors (SV_Target1 + prev-frame clip TEXCOORD / _PrevNonJitteredViewNoTransProjMatrix / _unity_MatrixPreviousM / _EnableTransparentMV MV write),
//   TAA jitter (_TaaJitterStrength), _NonJitteredViewNoTransProjMatrix→UNITY_MATRIX_VP, _InvViewProjMatrix→ComputeWorldSpacePosition,
//   _ViewMatrix→UNITY_MATRIX_V, _ScreenSize→_ScreenParams, _WorldSpaceCameraPos_Internal→_WorldSpaceCameraPos,
//   _GlobalMipBias (URP SAMPLE_TEXTURE2D_BIAS uses _GlobalMipBias internally / pass 0), particle-instance-color de-tint (_unity_Float4x5_Param2, dropped → COLOR used raw).
//
// NOTE: _VFXParams0.w (HGRP per-VFX custom time) → _Time.y. _VFXParams1 (HGRP post-VFX color-grade: .xyz tint, .w saturation) and
//   _ExposureParams (.x post-exposure) are HGRP globals with no URP equivalent → re-exposed as material Vectors defaulting to identity (no-op).
// NOTE: _MainTex sampled by the vertex-scrolled UV (TEXCOORD.zw) = the glow/alpha source; _WireRampTex sampled by raw mesh UV (TEXCOORD.xy) = the tint ramp.
//   _MaskTex (mirror sampler) gates alpha + RGB when _USE_MASK; otherwise WireRampTex carries the tint (base variant has no mask).

Shader "HGRP/VfxElectricWireFactory_Fix" {
    Properties {
        [Header(Base)]
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        [ToggleUI] _DisableVertColor ("Disable VertColor", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 1
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0

        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity", Range(1, 100)) = 1
        _TintColorAlpha ("Tint Color Alpha", Range(0, 10)) = 1
        _ExpThreshold ("Exp Threshold", Range(0, 1)) = 1
        _ExpIntensity ("Exp Intensity", Range(0, 100)) = 0

        [Header(Main Tex)]
        _MainTex ("Main Tex", 2D) = "white" {}
        [ToggleUI] _UseMainTexAsAlpha ("UseMainTexAsAlpha", Float) = 1
        [Enum(MeshUV, 0, ScreenUV, 1, PolarUV, 2)] _MainSwitchUV ("Main UV Switcher", Float) = 0
        [ToggleUI] _MainScreenDepthUV ("Screen UV With Depth", Float) = 0
        [ToggleUI] _MainUVSet ("Main UV Set (UV1)", Float) = 0
        _MainTexUVSpeed ("MainTexUVSpeed (XY:Time, ZW:Custom1.X)", Vector) = (0, 0, 0, 0)
        _MainTexUVRotate ("MainTexUVRotate (Degree)", Float) = 0

        [Header(Wire)]
        _WireRampTex ("Wire Ramp Tex", 2D) = "white" {}
        _HighLightPos ("HighLight Pos", Range(0, 0.5)) = 0.5
        _HighLightOffset ("HighLight Offset", Range(0, 1)) = 0.01
        [HDR] [Gamma] _HighLightColor ("High Light Color", Color) = (1, 1, 1, 1)
        [ToggleUI] _WireBillBoard ("Wire BillBoard", Float) = 0
        _WireMinWidth ("Wire Min Width", Range(1.2, 4)) = 1.5
        [ToggleUI] _ForceMoveToFarPlane ("Move To Far Plane", Float) = 0
        [ToggleUI] _UsePosYAsScreenV ("Use World Y as Screen V", Float) = 0

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        [ToggleUI] _UseMaskTexAsAlpha ("UseMaskTexAsAlpha", Float) = 1
        [Enum(MeshUV, 0, ScreenUV, 1, PolarUV, 2)] _MaskSwitchUV ("Mask UV Switcher", Float) = 0
        [ToggleUI] _MaskScreenDepthUV ("Screen UV With Depth", Float) = 0
        [ToggleUI] _MaskUVSet ("Mask UV Set (UV1)", Float) = 0
        _MaskTexUVSpeed ("MaskTexUVSpeed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _MaskTexUVRotate ("MaskTexUVRotate (Degree)", Float) = 0

        [Header(UV Mode Keywords)]
        [Toggle(_USE_SCREENUV)] _UseScreenUV ("Use Screen UV", Float) = 0
        [Toggle(_USE_POLARUV)] _UsePolarUV ("Use Polar UV", Float) = 0

        [Header(Near Camera Fade)]
        _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Start 1", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Fade End 1", Range(0.001, 3000)) = 10
        _NearCameraFadeDistanceEnd2 ("Fade End 2", Range(0.002, 3000)) = 100
        _NearCameraFadeDistanceStart2 ("Fade Start 2", Range(0.001, 3000)) = 120

        [Header(HGRP Global Re-exposed)]
        _ExposureParams ("ExposureParams (.x = post exposure)", Vector) = (1, 0, 0, 0)
        _VFXParams1 ("VFXParams1 (.xyz tint, .w saturation)", Vector) = (1, 1, 1, 1)

        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 1
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
    }
    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 300

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Base
                float _SurfaceType;
                float _BlendMode;
                float _Responsive;
                float _InParticle;
                float _DisableVertColor;
                float _IgnorePostExposure;
                float _TintColorIntensity;
                float _TintColorAlpha;
                float _ExpThreshold;
                float _ExpIntensity;
                float4 _TintColor;
                // Main Tex
                float _UseMainTexAsAlpha;
                float _MainSwitchUV;
                float _MainScreenDepthUV;
                float _MainUVSet;
                float _MainTexUVRotate;
                float4 _MainTexUVSpeed;
                float4 _MainTex_ST;
                // Wire
                float _HighLightPos;
                float _HighLightOffset;
                float _WireBillBoard;
                float _WireMinWidth;
                float _ForceMoveToFarPlane;
                float _UsePosYAsScreenV;
                float4 _HighLightColor;
                // Mask
                float _UseMaskTexAsAlpha;
                float _MaskSwitchUV;
                float _MaskScreenDepthUV;
                float _MaskUVSet;
                float _MaskTexUVRotate;
                float4 _MaskTexUVSpeed;
                float4 _MaskTex_ST;
                // Near Camera Fade
                float _UseNearCameraFade;
                float _NearCameraFadeDistanceStart;
                float _NearCameraFadeDistanceEnd;
                float _NearCameraFadeDistanceEnd2;
                float _NearCameraFadeDistanceStart2;
                // HGRP globals re-exposed (identity defaults)
                float4 _ExposureParams;
                float4 _VFXParams1;
                // Render state
                float _TransparentSortPriority;
            CBUFFER_END

            TEXTURE2D(_MainTex);        SAMPLER(sampler_LinearClamp_MainTex);          // T0, sampler_LinearClamp
            TEXTURE2D(_WireRampTex);    SAMPLER(sampler_LinearRepeat_WireRampTex);     // T1, sampler_LinearRepeat
            TEXTURE2D(_MaskTex);        SAMPLER(sampler_LinearMirror_MaskTex);         // T2, sampler_LinearMirror

            // ---- magic-constant decodes (blob literals → named) ----
            static const float DEG2RAD       = 0.01745329238474369049072265625;   // pi/180  (UV rotate, blob b4:158, b5/b7 rotate)
            static const float INV_TWO_PI    = 0.15915493667125701904296875;      // 1/(2*pi) (polar angle normalize, b7:119)
            static const float PI_CONST      = 3.1415927410125732421875;          // pi      (b7:119)
            static const float HALF_PI       = 1.57079637050628662109375;         // pi/2    (atan poly, b7:116)
            static const float ATAN_C0       = 0.087292902171611785888671875;     // atan approx (b7:115)
            static const float ATAN_C1       = -0.3018949925899505615234375;      // atan approx (b7:115)
            static const float WIRE_WIDTH_K  = 0.000277777784503996372222900390625; // 1/3600 (wire min-width clip scale, b4:149, b6:144)
            static const float3 LUMA709      = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec709 (b5:140)

            // Decompiled polar angle from centered (xc, yc), 1:1 with blob b7:111-119.
            // NOTE the blob divides r = xc/yc (centered-X over centered-Y, b7:111 _61) — NOT yc/xc — and
            // the octant fold is +-pi/2 keyed on sign(yc<0) (b7:119), not sign(xc). Reproduce verbatim.
            float PolarAngle(float xc, float yc)
            {
                float r = xc / yc;                                        // b7:111  (_61 = _58/_60)
                bool inUnit = abs(r) < 1.0;                               // b7:112  (_68)
                float t = inUnit ? abs(r) : (1.0 / abs(r));               // b7:113  (_70)
                float t2 = t * t;                                         // b7:114  (_73)
                float poly = mad(mad(t2, ATAN_C0, ATAN_C1), t2, 1.0);     // b7:115  (_77)
                float atanAbs = inUnit ? (t * poly) : mad(-poly, t, HALF_PI); // b7:116 (_86 = atan(|xc/yc|))
                float signedAtan = (r < 0.0) ? -atanAbs : atanAbs;        // b7:119 inner (_61<0?-_86:_86)
                float octant = (xc >= 0.0) ? HALF_PI : -HALF_PI;          // asfloat(1078530010u)=+pi/2 / asfloat(3226013658u)=-pi/2 by sign(xc=_58)
                float yNeg   = (yc < 0.0) ? 1.0 : 0.0;                     // asfloat(((yc<0)?0xffffffff:0) & 1.0)  (sign of _60)
                return mad(octant, yNeg, signedAtan);                     // b7:119 numerator (before +pi)
            }

            // Polar UV from a centered (uv-0.5) coordinate, matching b7:117-119.
            // .x = radius*2 (_102/_172), .y = (angle+pi)/(2pi) (_109/_177).  Angle arg order = (x, y).
            float2 PolarUV(float2 uvCentered)
            {
                float radius = sqrt(dot(uvCentered, uvCentered)); // b7:117 (_101)
                float u = radius + radius;                         // b7:118 (_102)
                float v = (PolarAngle(uvCentered.x, uvCentered.y) + PI_CONST) * INV_TWO_PI; // b7:119 (_109)
                return float2(u, v);
            }
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma target 3.0
            #pragma shader_feature_local _USE_MASK
            #pragma shader_feature_local _USE_SCREENUV
            #pragma shader_feature_local _USE_POLARUV

            struct Attributes {
                float3 positionOS : POSITION;
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0; // .xy = UV0, .zw = UV1 (particle-baked)
                float4 texcoord1  : TEXCOORD1; // particle custom data
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float4 uv         : TEXCOORD1; // .xy = raw mesh UV0 (WireRamp), .zw = vertex-scrolled MainTex UV (base path)
                float4 vertColor  : TEXCOORD2;
                float3 positionWS : TEXCOORD3; // world pos for highlight / fade / screen reconstruct
                float4 particleUV : TEXCOORD4; // .xy = raw baked UV1 (texcoord0.zw), .zw = particle custom data (texcoord1.xy)
                                               //   needed by the b7 mask/screen/polar fragment recompute (custom1.X/Y + uvSet=1 reconstruction)
            };

            // --------------------------------------------------------------------------------------
            // Vertex: camera-facing wire frame + screen-space minimum-width expansion.
            // 1:1 from Sub0_Pass0_Vertex_b4 (lines 107-153 frame+expand, 154-167 UV) and b6.
            // Motion-vector outputs (b4:170-186, TEXCOORD_3/TEXCOORD_4_1 prev-clip) are DROPPED (HGRP MV infra).
            // --------------------------------------------------------------------------------------
            Varyings vert(Attributes v)
            {
                Varyings o;

                float3 objX  = float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20); // ObjectToWorld[0].xyz
                float3 objY  = float3(unity_ObjectToWorld._m01, unity_ObjectToWorld._m11, unity_ObjectToWorld._m21); // ObjectToWorld[1].xyz
                float3 objZ  = float3(unity_ObjectToWorld._m02, unity_ObjectToWorld._m12, unity_ObjectToWorld._m22); // ObjectToWorld[2].xyz
                float3 origin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23); // ObjectToWorld[3].xyz

                // camera->origin vector, reordered (y,z,x) exactly as the blob builds it (b4:107-109)
                float3 camRel = float3(_WorldSpaceCameraPos.y - origin.y,   // _56
                                       _WorldSpaceCameraPos.z - origin.z,   // _57
                                       _WorldSpaceCameraPos.x - origin.x);  // _58

                // normalized object X axis, reordered (y,z,x) (b4:110-113 → _79=x, _80=y, _81=z stored as (_80,_81,_79))
                float invLenX = rsqrt(dot(objX, objX));      // _73
                float nXx = invLenX * objX.x;                // _79
                float nXy = invLenX * objX.y;                // _80
                float nXz = invLenX * objX.z;                // _81
                float3 axisX = float3(nXy, nXz, nXx);        // the (_80,_81,_79) ordering used below

                // Gram-Schmidt: remove axisX component from camRel, then cross to get a stable perpendicular (b4:114-124)
                float d0 = dot(axisX, camRel);                                  // _82
                float3 proj = mad(-axisX, d0, camRel);                          // (_88,_89,_90)
                float3 perp = float3(mad(nXy, proj.y, -(proj.x * nXz)),         // _97
                                     mad(nXz, proj.z, -(proj.y * nXx)),         // _98
                                     mad(nXx, proj.x, -(proj.z * nXy)));        // _99
                float invLenP = rsqrt(dot(perp, perp));                         // _103
                float3 nPerp = invLenP * perp;                                  // (_104,_105,_106)

                // object-space position lifted to world rotation (no translation) (b4:125-129)
                float invLenY = rsqrt(dot(objY, objY));                         // _121
                float3 rotPos = float3(mad(objZ.x, v.positionOS.z, mad(objX.x, v.positionOS.x, v.positionOS.y * objY.x)),  // _159
                                       mad(objZ.y, v.positionOS.z, mad(objX.y, v.positionOS.x, v.positionOS.y * objY.y)),  // _160
                                       mad(objZ.z, v.positionOS.z, mad(objX.z, v.positionOS.x, v.positionOS.y * objY.z))); // _161
                float along = dot(invLenY * objY, rotPos);                      // _162  (signed extent along wire)

                // wire side vector = along * perp, normalized (b4:130-136)
                float3 side = along * nPerp;                                    // (_165,_166,_167)
                float invLenS = rsqrt(dot(side, side));                         // _171
                float3 nSide = invLenS * side;                                  // (_172,_173,_174)

                // project side dir to clip XY to measure on-screen direction (b4:137-142)
                float clipDx = mad(UNITY_MATRIX_VP._m02, nSide.z, mad(UNITY_MATRIX_VP._m00, nSide.x, nSide.y * UNITY_MATRIX_VP._m01)); // _194
                float clipDy = mad(UNITY_MATRIX_VP._m12, nSide.z, mad(UNITY_MATRIX_VP._m10, nSide.x, nSide.y * UNITY_MATRIX_VP._m11)); // _195
                float invLenC = rsqrt(dot(float2(clipDx, clipDy), float2(clipDx, clipDy)));  // _200
                float alongAbs = abs(along);                                    // _215
                float dirX = alongAbs * ((invLenC * clipDx) * (_ScreenParams.y / _ScreenParams.x)); // _216 (aspect correct X)
                float dirY = alongAbs * ((invLenC * clipDy) * 1.0);                                 // _217 (asfloat(1065353216u)=1)

                // billboard center: either rotated-onto-camera-plane (_WireBillBoard) or plain world (b4:143-147)
                // _235 = dot(float3(_79,_80,_81), rotPos) = dot(NATURAL-order normalized X axis, rotPos).
                // (NOT axisX, which is the (y,z,x)-permuted vector — rotPos is natural order, so the permutation does NOT cancel here.)
                float planar = dot(float3(nXx, nXy, nXz), rotPos);              // _235
                bool billboard = (_WireBillBoard != 0.0);                       // _261
                // absolute world center (blob keeps it camera-relative + uses a no-translation VP; the URP
                // equivalent is absolute world through the full UNITY_MATRIX_VP — pixel-identical).
                float3 centerWS = billboard
                    ? float3(mad(nPerp.x, along, mad(nXx, planar, origin.x)),   // _282 (before -cam)
                             mad(nPerp.y, along, mad(nXy, planar, origin.y)),   // _283
                             mad(nPerp.z, along, mad(nXz, planar, origin.z)))   // _284
                    : (rotPos + origin);

                // clip-space center (b4:148-153): clip = UNITY_MATRIX_VP * centerWS
                float4 clip = mul(UNITY_MATRIX_VP, float4(centerWS, 1.0));      // (_150 base,_151 base,_152,_325=w)
                float clipW = clip.w;                                           // _325
                float minHalf = (clipW * _WireMinWidth) * WIRE_WIDTH_K;        // _330

                // side direction projected to clip XY (rotation only — direction, no translation) (b4:137-142)
                // sign(dir)*minHalf only when |dir| < minHalf, i.e. widen thin wires up to minimum (b4:150-151)
                float widenX = (abs(dirX) < minHalf) ? (sign(dirX) * minHalf) : 0.0; // masked term in _150
                float widenY = (abs(dirY) < minHalf) ? (sign(dirY) * minHalf) : 0.0; // masked term in _151
                // ENGINE-SIDE (not closeable): b4:150-151 add a manual per-vertex TAA jitter
                //   gl_Position.x += mad(-(clipW*_TaaJitterStrength.z), 2, clip.x)  → clip.x - 2*clipW*_TaaJitterStrength.z
                //   gl_Position.y += mad(-(clipW*_TaaJitterStrength.w),-2, clip.y)  → clip.y + 2*clipW*_TaaJitterStrength.w
                // because HGRP builds clip from the NON-jittered _NonJitteredViewNoTransProjMatrix and re-adds jitter here.
                // URP instead bakes the jitter into the projection matrix host-side (UniversalRenderPipeline / CameraData TAA
                // setup): UNITY_MATRIX_VP used above (clip = mul(UNITY_MATRIX_VP, centerWS)) is ALREADY the jittered VP, while
                // _NonJitteredViewProjMatrix is kept separate (UnityInput.hlsl:289). _TaaJitterStrength is a per-frame value only
                // that host TAA pass can produce, and its visual effect is already applied through the jittered UNITY_MATRIX_VP —
                // so re-transcribing this term would DOUBLE-jitter every vertex (a fidelity regression, not a fix). Left engine-side.

                o.positionCS.x = widenX + clip.x;
                o.positionCS.y = widenY + clip.y;
                o.positionCS.z = (_ForceMoveToFarPlane != 0.0) ? 0.0 : clip.z;  // b4:152
                o.positionCS.w = clipW;                                         // b4:153

                // world position for highlight/fade. The blob reconstructs worldPos from the RENDERED fragment
                // depth (b5:107-117 _115/_116/_117), i.e. the actual billboard plane = centerWS (NOT the un-billboarded
                // rotPos+origin). centerWS == rotPos+origin when _WireBillBoard=0 (default), and is the correct rendered
                // world point when billboard is on, so this is the faithful stand-in for the depth reconstruction.
                o.positionWS = centerWS;

                // --- UV (base b4:154-164): MeshUV path with scroll/rotate/ST into .zw, raw mesh UV in .xy ---
                float custom1X = v.texcoord1.x * _InParticle;                   // _380
                bool uvSet = (_MainUVSet != 0.0);                              // _402
                float2 uv1 = float2(mad(v.texcoord0.z, _InParticle, -custom1X) + v.texcoord1.x,                                  // _139-style
                                    mad(v.texcoord0.w, _InParticle, -(v.texcoord1.y * _InParticle)) + v.texcoord1.y);

                // base path uses MeshUV only (b4:156-157). Screen/Polar selection lives in the fragment for those keywords.
                float2 baseUV = float2(mad(_MainTexUVSpeed.z, custom1X, mad(_MainTexUVSpeed.x, _Time.y, uvSet ? uv1.x : v.texcoord0.x)) - 0.5,  // _426
                                       mad(_MainTexUVSpeed.w, custom1X, mad(_MainTexUVSpeed.y, _Time.y, uvSet ? uv1.y : v.texcoord0.y)) - 0.5); // _428
                float rot = DEG2RAD * _MainTexUVRotate;                         // _432
                float s = sin(rot), c = cos(rot);                              // _434,_435
                float2 scrolledUV = float2(mad(dot(baseUV, float2(c, s)) + 0.5, _MainTex_ST.x, _MainTex_ST.z),    // TEXCOORD_2.z (b4:161)
                                           mad(dot(baseUV, float2(-s, c)) + 0.5, _MainTex_ST.y, _MainTex_ST.w));  // TEXCOORD_2.w (b4:162)

                o.uv = float4(v.texcoord0.x, v.texcoord0.y, scrolledUV.x, scrolledUV.y); // TEXCOORD_2.xy=mesh uv, .zw=scrolled

                // raw streams the mask/screen/polar variant (b6 passes them through, b7 consumes) re-derives UVs from:
                //   .xy = baked UV1 (TEXCOORD.zw),  .zw = particle custom data (TEXCOORD_1.xy)
                o.particleUV = float4(v.texcoord0.z, v.texcoord0.w, v.texcoord1.x, v.texcoord1.y);

                // vertex color (b4:165-169). _DisableParticleInstanceColor de-tint via _unity_Float4x5_Param2 DROPPED → raw COLOR.
                o.vertColor = v.color;
                return o;
            }

            // --------------------------------------------------------------------------------------
            // Fragment: 1:1 from Sub0_Pass0_Fragment_b5 (base) + b7 (mask / screen / polar UV deltas).
            // SV_Target1 motion-vector outputs (b5:145-154, b7:202-211) DROPPED (HGRP MV target).
            // --------------------------------------------------------------------------------------
            half4 frag(Varyings input) : SV_Target
            {
                // World position reconstructed from depth in the blob (b5:105-110 via _InvViewProjMatrix);
                // URP supplies positionWS through the interpolator → identical world point.
                float3 posWS = input.positionWS;

                // ---- highlight ramp by normalized world distance from wire origin (b5:111-118 / b7:160-166) ----
                float3 origin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);
                float3 rel = posWS - origin;                                                  // (_139,_140,_141)
                float wireScale = sqrt(dot(float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20),
                                           float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20))); // _209
                float hlOff = _HighLightOffset / wireScale;                                   // _214
                float hl = clamp((1.0 / (-hlOff)) * ((-hlOff) + abs((sqrt(dot(rel, rel)) / wireScale) - _HighLightPos)), 0.0, 1.0); // _226
                float hlSmooth = (hl * hl) * mad(hl, -2.0, 3.0);                              // _231  (smoothstep)

                // ---- exposure scale (b5:119) ----
                float exposureScale = mad(_IgnorePostExposure, _ExposureParams.x - 1.0, 1.0); // _250

                // ---- vertex-color select (b5:120) ----
                bool noVC = (_DisableVertColor != 0.0);                                       // _254
                float3 vc = float3(noVC ? 1.0 : input.vertColor.x,
                                   noVC ? 1.0 : input.vertColor.y,
                                   noVC ? 1.0 : input.vertColor.z);
                float vcA = noVC ? 1.0 : input.vertColor.w;

                // ---- per-pixel UV for the two textures ----
                // Base path (b5): WireRampTex sampled by raw mesh UV (input.uv.xy); MainTex by vertex-scrolled UV (input.uv.zw).
                // Screen/Polar keywords (b7) re-derive the MainTex UV per-pixel from screen reconstruction.
                float2 mainUV = input.uv.zw;     // default MeshUV (vertex-scrolled)
                float2 rampUV = input.uv.xy;
                float2 maskUVraw = input.uv.xy;  // mask base sample uses raw mesh UV (b7:169 T2 sample with TEXCOORD.xy)

                // The mask/screen/polar variant (b6/b7) does NOT pre-scroll the MainTex UV in the vertex — b6 passes raw
                // streams through and b7 recomputes the whole UV per-pixel. So whenever any of these keywords is active,
                // re-derive mainUV here from the raw interpolants (matching b7:120-154), overriding the base .zw value.
                #if defined(_USE_SCREENUV) || defined(_USE_POLARUV) || defined(_USE_MASK)
                {
                    // ScreenUV / PolarUV branch (b7:135-150). Reconstruct screen + polar from this pixel.
                    float2 ndcUV = GetNormalizedScreenSpaceUV(input.positionCS);             // float(uint(gl_FragCoord.xy))/_ScreenParams (b7:141,148)
                    float screenU = mad(ndcUV.x, 2.0, -1.0);                                 // _262
                    // V: world-Y reconstruction OR aspect-scaled screen Y (b7:148, _343)
                    float screenV = (_UsePosYAsScreenV != 0.0)
                        ? posWS.y
                        : (mad(ndcUV.y, 2.0, -1.0) / _ScreenParams.x) * _ScreenParams.y;
                    // depth-scaled screen UV factor (b7:138-139, _238/_245): linear-ish view-depth bias
                    float viewDepth = mad(UNITY_MATRIX_V._m20, origin.x, mad(UNITY_MATRIX_V._m21, origin.y, UNITY_MATRIX_V._m22 * origin.z)) + UNITY_MATRIX_V._m23; // ViewMatrix·origin .z (b7:138)
                    float depthBias = max(-viewDepth - _ProjectionParams.y, 0.0) - 1.0;       // _238
                    float mainDepthFac = mad(_MainScreenDepthUV, depthBias, 1.0);             // _245

                    bool isScreen = (1.0 == _MainSwitchUV);                                   // _198
                    bool isPolar  = (2.0 == _MainSwitchUV);                                   // _199
                    bool uvSet = (_MainUVSet != 0.0);                                         // _181

                    // particle custom1.X and the uvSet=1 baked-UV1 reconstruction (b7:120-123)
                    float custom1X = input.particleUV.z * _InParticle;                        // _120 = TEXCOORD_1.x * _InParticle
                    float custom1Y = input.particleUV.w * _InParticle;                        // _121 = TEXCOORD_1.y * _InParticle
                    float2 uv1recon = float2(mad(input.particleUV.x, _InParticle, -custom1X) + input.particleUV.z,    // _139
                                             mad(input.particleUV.y, _InParticle, -custom1Y) + input.particleUV.w);   // _140
                    // Polar from mesh UV0 (centered) and from the uvSet=1 baked UV1 (centered) (b7:117-119 / 124-134)
                    float2 polar0 = PolarUV(input.uv.xy - 0.5);                               // (_102,_109)
                    float2 polar1 = PolarUV(uv1recon - 0.5);                                  // (_172,_177)

                    float pickU = isScreen ? (mainDepthFac * screenU)
                                           : (isPolar ? (uvSet ? polar1.y : polar0.y)
                                                      : (uvSet ? uv1recon.x : input.uv.x));   // _371 inner select (pre scroll/rot)
                    float pickV = isScreen ? (mainDepthFac * screenV)
                                           : (isPolar ? (uvSet ? polar1.x : polar0.x)
                                                      : (uvSet ? uv1recon.y : input.uv.y));   // _372 inner select
                    float2 baseUV = float2(mad(_MainTexUVSpeed.z, custom1X, mad(_MainTexUVSpeed.x, _Time.y, pickU)) - 0.5,
                                           mad(_MainTexUVSpeed.w, custom1X, mad(_MainTexUVSpeed.y, _Time.y, pickV)) - 0.5); // _371,_372
                    float rot = DEG2RAD * _MainTexUVRotate;
                    float s = sin(rot), cc = cos(rot);
                    mainUV = float2(mad(dot(baseUV, float2(cc, s)) + 0.5, _MainTex_ST.x, _MainTex_ST.z),
                                    mad(dot(baseUV, float2(-s, cc)) + 0.5, _MainTex_ST.y, _MainTex_ST.w)); // _407 uv
                }
                #endif

                // ---- MainTex (b5:126 / b7:154, T0) — glow + alpha source, sampled at mainUV ----
                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_LinearClamp_MainTex, mainUV); // _317 / _407
                // UseMainTexAsAlpha → color factor lerp(rgb, 1, flag) (b5:131-133 / b7:170-172 left term)
                float3 mainColorFac = float3(mad(_UseMainTexAsAlpha, 1.0 - mainSample.x, mainSample.x),   // _334 / _409 term
                                             mad(_UseMainTexAsAlpha, 1.0 - mainSample.y, mainSample.y),   // _335
                                             mad(_UseMainTexAsAlpha, 1.0 - mainSample.z, mainSample.z));  // _336

                float expThr = -_ExpThreshold;                                                // _346 / _667
                float3 tint;     // color before glow  (_305/_306/_307  or  _553/_554/_555)
                float3 glowFac;  // glow second-factor (_334/_335/_336   or  _655/_656/_657)
                float maskAlpha; // multiplies output alpha (1 in base; _655-alpha in mask)

                #ifdef _USE_MASK
                {
                    // --- b7 mask variant: 3 textures ---
                    // MaskTex (T2, mirror) sampled by raw mesh UV → tint multiplier (b7:169 _545).
                    float4 maskSample = SAMPLE_TEXTURE2D(_MaskTex, sampler_LinearMirror_MaskTex, maskUVraw); // _545
                    // tint = mainColorFac * ( (vc*_TintColor*intensity/exposure)*maskRGB + highlight )  (b7:170-172)
                    tint = mainColorFac * mad((vc * _TintColor.rgb * _TintColorIntensity) / exposureScale,
                                              maskSample.rgb, hlSmooth * _HighLightColor.rgb);            // _553,_554,_555

                    // WireRampTex (T1, repeat) sampled at the MASK-scrolled UV → glow factor (b7:176-189 _637/_655).
                    bool maskUVSet  = (_MaskUVSet != 0.0);                                   // _560
                    bool maskScreen = (1.0 == _MaskSwitchUV);                                // _577
                    bool maskPolar  = (2.0 == _MaskSwitchUV);                                // _578
                    float custom1Ym = input.particleUV.w * _InParticle;                      // _121 = TEXCOORD_1.y * _InParticle
                    float custom1Xm = input.particleUV.z * _InParticle;                      // _120 (for the shared uv1 reconstruction)
                    float2 uv1reconM = float2(mad(input.particleUV.x, _InParticle, -custom1Xm) + input.particleUV.z,   // _139 (shared with main)
                                              mad(input.particleUV.y, _InParticle, -custom1Ym) + input.particleUV.w);  // _140
                    // depth-scaled factor for mask screen UV (b7:140 _246)
                    float viewDepthM = mad(UNITY_MATRIX_V._m20, origin.x, mad(UNITY_MATRIX_V._m21, origin.y, UNITY_MATRIX_V._m22 * origin.z)) + UNITY_MATRIX_V._m23;
                    float depthBiasM = max(-viewDepthM - _ProjectionParams.y, 0.0) - 1.0;     // _238
                    float maskDepthFac = mad(_MaskScreenDepthUV, depthBiasM, 1.0);            // _246
                    float2 ndcUVm = GetNormalizedScreenSpaceUV(input.positionCS);             // _262 base
                    float screenUm = mad(ndcUVm.x, 2.0, -1.0);                               // _262
                    float screenVm = (_UsePosYAsScreenV != 0.0) ? posWS.y
                                   : (mad(ndcUVm.y, 2.0, -1.0) / _ScreenParams.x) * _ScreenParams.y; // _343
                    float2 polarM0 = PolarUV(input.uv.xy - 0.5);                              // (_102,_109)  uvSet=0
                    float2 polarM1 = PolarUV(uv1reconM - 0.5);                                // (_172,_177)  uvSet=1
                    float mPickU = maskScreen ? (maskDepthFac * screenUm)
                                              : (maskPolar ? (maskUVSet ? polarM1.y : polarM0.y)
                                                           : (maskUVSet ? uv1reconM.x : input.uv.x)); // _605 inner
                    float mPickV = maskScreen ? (maskDepthFac * screenVm)
                                              : (maskPolar ? (maskUVSet ? polarM1.x : polarM0.x)
                                                           : (maskUVSet ? uv1reconM.y : input.uv.y)); // _606 inner
                    float2 mBase = float2(mad(_MaskTexUVSpeed.z, custom1Ym, mad(_MaskTexUVSpeed.x, _Time.y, mPickU)) - 0.5,
                                          mad(_MaskTexUVSpeed.w, custom1Ym, mad(_MaskTexUVSpeed.y, _Time.y, mPickV)) - 0.5); // _605,_606
                    float mRot = DEG2RAD * _MaskTexUVRotate;                                  // _610
                    float ms = sin(mRot), mc = cos(mRot);                                     // _611,_612
                    float2 rampUVm = float2(mad(dot(mBase, float2(mc, ms)) + 0.5, _MaskTex_ST.x, _MaskTex_ST.z),
                                            mad(dot(mBase, float2(-ms, mc)) + 0.5, _MaskTex_ST.y, _MaskTex_ST.w)); // _637 uv
                    float4 ramp = SAMPLE_TEXTURE2D(_WireRampTex, sampler_LinearRepeat_WireRampTex, rampUVm);       // _637
                    glowFac = float3(mad(_UseMaskTexAsAlpha, 1.0 - ramp.x, ramp.x),           // _655
                                     mad(_UseMaskTexAsAlpha, 1.0 - ramp.y, ramp.y),           // _656
                                     mad(_UseMaskTexAsAlpha, 1.0 - ramp.z, ramp.z));          // _657
                    // mask output-alpha factor lerp(ramp.a, ramp.r, flag) (b7:195 _655-alpha)
                    maskAlpha = mad(_UseMaskTexAsAlpha, ramp.x - ramp.w, ramp.w);
                }
                #else
                {
                    // --- b5 base variant: WireRampTex (T1, repeat) sampled by raw mesh UV → tint ramp ---
                    float4 ramp = SAMPLE_TEXTURE2D(_WireRampTex, sampler_LinearRepeat_WireRampTex, rampUV); // _299
                    // tint = (vc*_TintColor*intensity/exposure)*rampRGB + highlight  (b5:122-124). NOT × mainColorFac.
                    tint = mad((vc * _TintColor.rgb * _TintColorIntensity) / exposureScale, ramp.rgb,
                               hlSmooth * _HighLightColor.rgb);                                // _305,_306,_307
                    glowFac = mainColorFac;                                                   // _334/_335/_336
                    maskAlpha = 1.0;
                }
                #endif

                // ---- exp-threshold glow (b5:136-138 / b7:191-193) ----
                float3 col = float3(
                    min(max(mad(max(mad(tint.x, glowFac.x, expThr), 0.0), _ExpIntensity, glowFac.x * tint.x), 0.0), 1000.0),  // _364 / _683
                    min(max(mad(max(mad(tint.y, glowFac.y, expThr), 0.0), _ExpIntensity, glowFac.y * tint.y), 0.0), 1000.0),  // _366 / _685
                    min(max(mad(max(mad(tint.z, glowFac.z, expThr), 0.0), _ExpIntensity, glowFac.z * tint.z), 0.0), 1000.0)); // _367 / _686

                // ---- view-space depth for near-camera fade (b5:114 _148 / b7:194 _702) ----
                float viewZ = mad(UNITY_MATRIX_V._m20, posWS.x, mad(UNITY_MATRIX_V._m21, posWS.y, UNITY_MATRIX_V._m22 * posWS.z)) + UNITY_MATRIX_V._m23;

                // ---- alpha: MainTex.a (UseMainTexAsAlpha select) × mask.a × tint.a × near fade (b5:135 / b7:195) ----
                float mainAlpha = mad(_UseMainTexAsAlpha, mainSample.x - mainSample.w, mainSample.w); // lerp(mainSample.a, mainSample.r, flag)  _319-_322
                float baseAlpha = maskAlpha * mainAlpha * (vcA * _TintColor.w * _TintColorAlpha);     // maskAlpha=1 in base
                float nearFade = (_UseNearCameraFade != 0.0)
                    ? (clamp((abs(viewZ) - _NearCameraFadeDistanceStart2) / (_NearCameraFadeDistanceEnd2 - _NearCameraFadeDistanceStart2), 0.0, 1.0)
                     * clamp((abs(viewZ) - _NearCameraFadeDistanceStart)  / (_NearCameraFadeDistanceEnd  - _NearCameraFadeDistanceStart),  0.0, 1.0))
                    : 1.0;                                                                     // _360 / _746
                float alpha = clamp(nearFade * baseAlpha, 0.0, 1.0);

                // ---- VFX color-grade (desaturate toward luma, then tint) (b5:140-144 / b7:197-201) ----
                float luma = dot(col, LUMA709);                                               // _370 / _749
                float3 graded = float3(mad(_VFXParams1.w, col.x - luma, luma) * _VFXParams1.x, // _305-style SV_Target.x
                                       mad(_VFXParams1.w, col.y - luma, luma) * _VFXParams1.y,
                                       mad(_VFXParams1.w, col.z - luma, luma) * _VFXParams1.z);

                // ---- surface-type alpha gate (opaque writes 1) ----
                // _Responsive*_SurfaceType drove the MV-responsive bit (SV_Target1.w) which is dropped;
                // the visible RGBA alpha is the faded base alpha, written 1 for opaque.
                float outAlpha = (_SurfaceType == 1.0) ? alpha : 1.0;

                return half4(graded, outAlpha);
            }

            ENDHLSL
        }
    }
}
