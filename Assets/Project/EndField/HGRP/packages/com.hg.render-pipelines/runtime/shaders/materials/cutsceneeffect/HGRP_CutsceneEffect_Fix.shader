// HGRP CutsceneEffect — full-screen cinematic "蜡纸" (letterbox / vignette) overlay, ForwardOnly only.
//   A screen-space quad that draws a brighten ("提亮"/screen) OR darken ("压暗"/multiply) card with
//   elliptical-or-quad shape masking, left/right edge fades, total/local translate+rotate+scale, optional
//   aspect-ratio auto-stretch (ultrawide), and an optional scene-depth near-fade.
// Merged from: cutsceneeffect Sub0_Pass0 — base variant b2/b3 (catch-all #else, keyword HG_ENABLE_MV) +
//   depth-fade variant b4/b5 (HG_ENABLE_MV + _ENABLE_DEPTH_FADE).
// Keywords: _ENABLE_DEPTH_FADE
// Kept: shape (quad/ellipse) mask, dual LightRange remap + smoothstep, left/right edge fade, screen-space
//   card placement (XOffset/YOffset/Ration/Scale/TotalXOffset/TotalYOffset), aspect auto-stretch gate,
//   brighten(screen)/darken(multiply) blend select via _ColorOption, exposure-normalized HDR base color,
//   optional depth-fade (with invert-fade) sampling the camera depth texture.
// Removed: HG_ENABLE_MV motion-vector stage (SV_Target1 prev-clip-pos output — the entire TEXCOORD_2/_3
//   prev/cur NoTransProj reprojection in the vertex blob; URP overlay has no MV target here),
//   HGRP global cbuffers (NonJittered/Prev view-proj, ZBufferParams→URP _ZBufferParams, ScreenParams→
//   _ScreenParams, per-draw matrix packing → named material params), SPIRV-Cross statics/polyfills.
//
// NOTE: the source delivers the card placement params (XOffset/YOffset/Ration/Scale/TotalXOffset/
//   TotalYOffset/EnableAutoStretch) packed into the per-draw _unity_ObjectToWorld rows at runtime
//   (HG full-screen-quad convention). They are re-read here directly from the named material properties
//   they represent — same math, no per-draw matrix abuse. Row map: [1].xy=_Scale.xy,
//   [4].x=_XOffset, [4].y=_YOffset, [4].z=_Ration, [5].z=_TotalXOffset, [5].w=_TotalYOffset,
//   [6].y=_EnableAutoStretch. [3].y (auto-stretch gate input only) is mapped to _TotalYOffset by
//   elimination but is a DISTINCT packing slot — see TODO(1:1) in vert(); the native packer that fills
//   it (CutsceneEffectPass.h, C++) is outside the managed decompile.
// NOTE: _ColorOption (0=brighten/screen card, 1=darken/multiply card) is a HideInInspector float set by the
//   editor from _SurfaceType/_BlendMode; the HLSL lerp between the two cards is exact (blob b3 lines 80-83).
Shader "HGRP/CutsceneEffect_Fix" {
    Properties {
        _LightProperties ("提亮", Float) = 0
        [Enum(Quad, 0, Ver, 1)] _ShapeOption ("形状(方/圆)", Float) = 0
        [HDR] [Gamma] _BaseColor ("Light Color", Color) = (1, 1, 1, 1)
        _LightRange1 ("滤色提亮范围参数1", Range(0, 1)) = 0
        _LightRange2 ("滤色提亮范围参数2", Range(0, 1)) = 1
        _LightIntensity ("提亮片强度", Range(0, 1)) = 1

        _DarkProperties ("压暗", Float) = 0
        _DarkIntensity ("压暗片强度", Range(0, 1)) = 1

        _ControlProperties ("控制", Float) = 0
        _XOffset ("x轴平移", Range(-1, 1)) = 0
        _YOffset ("y轴平移", Range(-1, 1)) = 0
        _Ration ("旋转角度", Range(-90, 90)) = 0
        _Scale ("蜡纸大小", Vector) = (1, 1, 1, 1)
        _LeftFadeRange ("左侧渐变位置", Range(0, 0.5)) = 0
        _RightFadeRange ("右侧渐变位置", Range(0, 0.5)) = 0
        _TotalXOffset ("X轴整体平移", Range(-2, 2)) = 0
        _TotalYOffset ("Y轴整体平移", Range(-2, 2)) = 0

        [Toggle(_ENABLE_DEPTH_FADE)] _EnableDepthFade ("Enable Depth Fade", Float) = 0
        _DepthFadePosition ("景深渐变位置", Range(0, 200)) = 0.1
        _NearFadeIntensity ("近景蜡纸强度", Range(0, 1)) = 0.28
        [ToggleUI] _EnableuseInvertFade ("反转景深范围", Float) = 0
        _DepthFadeRange ("景深渐变范围", Range(0, 2)) = 0

        _AdvancedProperties ("Advanced", Float) = 0
        [ToggleUI] [HideInInspector] _EnableAutoStretch ("Enable Auto Stretch (Ultrawide)", Float) = 1

        // Render-state plumbing (driven by editor; source: Blend 0 [_SrcBlend] [_DstBlend], Zero One / ZWrite Off)
        [HideInInspector] _SurfaceType ("Surface Type", Float) = 0
        [HideInInspector] _BlendMode ("Blend Type", Float) = 0
        [HideInInspector] _ColorOption ("Color Option", Float) = 0
        [HideInInspector] _CullMode ("Render Face", Float) = 2
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [HideInInspector] _SrcBlend ("__src", Float) = 4
        [HideInInspector] _DstBlend ("__dst", Float) = 1
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
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _BaseColor;
                float4 _Scale;
                // Shape / brighten / darken
                float _ShapeOption;
                float _ColorOption;
                float _LightRange1;
                float _LightRange2;
                float _LightIntensity;
                float _DarkIntensity;
                // Edge fades
                float _LeftFadeRange;
                float _RightFadeRange;
                // Card placement
                float _XOffset;
                float _YOffset;
                float _Ration;
                float _TotalXOffset;
                float _TotalYOffset;
                float _EnableAutoStretch;
                // Depth fade
                float _DepthFadePosition;
                float _NearFadeIntensity;
                float _DepthFadeRange;
                float _EnableuseInvertFade;
            CBUFFER_END

            // HGRP exposure global ( _ExposureParams.x = post-exposure multiplier ). URP overlay has no such
            // global, so it is declared here and defaults to 1 when unbound (no exposure change).
            // Source: blob b3 lines 77-83 divide HDR base color by _ExposureParams.x.
            float4 _ExposureParams;

            // smoothstep cubic on a pre-saturated t: t*t*(3 - 2t). Blob spells it (t*t)*mad(t,-2,3).
            // Source: blob b3 lines 70-73 (_81, _117 factors).
            float SmoothCube(float t)
            {
                return (t * t) * mad(t, -2.0, 3.0);
            }
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }
            // Source: Blend 0 [_SrcBlend] [_DstBlend], Zero One  /  ColorMask RGB  /  ZWrite Off / ZClip On.
            // RGB blends by the card's src/dst; alpha keeps destination (Zero One).
            Blend [_SrcBlend] [_DstBlend], Zero One
            ColorMask RGB
            ZWrite Off
            ZClip On
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma target 3.0
            #pragma shader_feature_local _ENABLE_DEPTH_FADE

            struct Attributes {
                float3 positionOS : POSITION;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0; // == TEXCOORD_1 in blob (raw mesh uv)
                float2 screenUV   : TEXCOORD1; // == TEXCOORD_1_1 in blob (NDC->[0,1] uv for depth sampling)
            };

            // ----------------------------------------------------------------
            // Vertex — screen-space card placement.
            // Source: Vertex blob b2 lines 58-77 (the b4 depth-fade variant is byte-identical for these
            // outputs; only the dropped MV TEXCOORD_2/_3 reprojection differs).
            // The per-draw _unity_ObjectToWorld[N] reads are remapped to the named material params they pack
            // (see header NOTE). Magic constants decoded inline.
            // ----------------------------------------------------------------
            Varyings vert(Attributes input)
            {
                Varyings output = (Varyings)0;

                // _85 = aspect = ScreenW / ScreenH. (_ScreenParams.x/.y)  — blob line 58.
                float aspect = _ScreenParams.x / _ScreenParams.y;

                // _91: auto-stretch gate. uint AND of:
                //   ( 0 < (1 - _unity_ObjectToWorld[3u].y) * (aspect - 2.16666675) )
                //   ( 0.5 < _EnableAutoStretch )                          [_unity_ObjectToWorld[6u].y]
                // 2.1666667461395263671875 = 13/6 (the design/reference aspect threshold). — blob line 59.
                // TODO(1:1): _unity_ObjectToWorld[3u].y is a distinct slot in HG's per-draw packing bag
                //   (row 3 of the 7-row param matrix; rows 4/5/6 hold the other named params). The native
                //   packer (CutsceneEffectPass.h, C++ — not in the managed decompile) decides what value
                //   lands here. Mapped to _TotalYOffset by elimination; this affects ONLY whether the
                //   ultrawide auto-stretch (>13/6 aspect) doubles the scale, never the non-ultrawide path.
                //   The gate MATH is transcribed 1:1 regardless. Re-confirm against the native packer if
                //   ultrawide auto-stretch ever misbehaves.
                const float REF_ASPECT = 2.1666667461395263671875; // 13/6
                bool stretchCond = (0.0 < ((1.0 + (-_TotalYOffset)) * (aspect + (-REF_ASPECT))))
                                && (0.5 < _EnableAutoStretch);

                // _98 = stretchCond ? 2.0 : 1.0   ( asfloat(1073741824u)=2.0, asfloat(1065353216u)=1.0 ) — blob line 60.
                float stretchScale = stretchCond ? 2.0 : 1.0;

                // _115 = abs(_Ration)   [_unity_ObjectToWorld[4u].z = _Ration] — blob line 61.
                float absRation = abs(_Ration);

                // _148 = REF_ASPECT / aspect — blob line 62.
                float invAspectRef = REF_ASPECT / aspect;

                // _156 = (invAspectRef * scaleX') * POSITION.x, where scaleX' = (absRation<35) ? stretchScale*_Scale.x : _Scale.x
                //   [_unity_ObjectToWorld[1u].x = _Scale.x] — blob line 63.
                float scaleX = (absRation < 35.0) ? (stretchScale * _Scale.x) : _Scale.x;
                float px = (invAspectRef * scaleX) * input.positionOS.x;

                // _158 = (scaleY' * POSITION.y) / aspect, where scaleY' = (80<absRation) ? stretchScale*_Scale.y : _Scale.y
                //   [_unity_ObjectToWorld[1u].y = _Scale.y] — blob line 64.
                float scaleY = (80.0 < absRation) ? (stretchScale * _Scale.y) : _Scale.y;
                float py = (scaleY * input.positionOS.y) / aspect;

                // _162 = radians(_Ration); _164=sin, _165=cos. 0.0174532923... = π/180 — blob lines 65-67.
                float rad = 0.01745329238474369049072265625 * _Ration;
                float s = sin(rad);
                float c = cos(rad);

                // X offset term, blob line 68 (_181):
                //   xOff' = (85 < absRation)
                //       ? mad( asfloat(_91&1)*( (float)(sign(_XOffset)) ) * _Scale.y , 0.115 , _XOffset )
                //       : _XOffset
                //   where the integer expression  int( (0u-((0<_XOffset)?-1u:0u)) + ((_XOffset<0)?-1u:0u) ) == sign(_XOffset)
                //   ( +1 when _XOffset>0, -1 when _XOffset<0, 0 when ==0 — uint -1==0xFFFFFFFF wraps to give this )
                //   and asfloat(_91 & 1065353216u) = stretchCond ? 1.0 : 0.0.
                //   _181 = mad( mad(xOff', invAspectRef, mad(dot((px,py),(c,s)),0.5,0.5)) , 2.0 , _TotalXOffset ) - 1.0
                //   [_unity_ObjectToWorld[4u].x=_XOffset, [1u].y=_Scale.y, [5u].z=_TotalXOffset]
                float stretchFlag = stretchCond ? 1.0 : 0.0;
                float signX = (_XOffset > 0.0) ? 1.0 : ((_XOffset < 0.0) ? -1.0 : 0.0); // == sign(_XOffset)
                float xOff = (85.0 < absRation)
                    ? mad(stretchFlag * signX * _Scale.y, 0.115000002086162567138671875, _XOffset)
                    : _XOffset;
                float rotX = dot(float2(px, py), float2(c, s));
                float ndcX = mad(mad(xOff, invAspectRef, mad(rotX, 0.5, 0.5)), 2.0, _TotalXOffset) + (-1.0);

                // Y offset term, blob line 69 (_195):
                //   _195 = mad( mad( aspect*dot((px,py),(-s,c)), 0.5, 0.5 ) + (-_YOffset), 2.0, -1.0 ) + (-_TotalYOffset)
                //   [_unity_ObjectToWorld[4u].y=_YOffset, [5u].w=_TotalYOffset]
                float rotY = dot(float2(px, py), float2(-s, c));
                float ndcY = mad(mad(aspect * rotY, 0.5, 0.5) + (-_YOffset), 2.0, -1.0) + (-_TotalYOffset);

                // gl_Position: x=_181, y=_195, z=POSITION.z, w=1 — blob lines 70-75.
                output.positionCS = float4(ndcX, ndcY, input.positionOS.z, 1.0);

                // TEXCOORD_1_1 (screenUV for depth): x = ndcX*0.5+0.5; y = (ndcY*0.5+0.5)*-1 + 1 — blob lines 72-73.
                output.screenUV.x = mad(mad(ndcX, 0.5, 0.5), 1.0, 0.0);
                output.screenUV.y = mad(mad(ndcY, 0.5, 0.5), -1.0, 1.0);

                // TEXCOORD_1 = raw mesh uv — blob lines 76-77.
                output.uv = input.uv;

                return output;
            }

            // ----------------------------------------------------------------
            // Fragment — brighten/darken card.
            // Base math: Fragment blob b3 lines 66-83.
            // Depth-fade addendum (_ENABLE_DEPTH_FADE): Fragment blob b5 lines 70-92 (the b5 fade factor _120
            // multiplies _BaseColor.w before the dark/light intensities; b3 uses _BaseColor.w directly).
            // ----------------------------------------------------------------
            float4 frag(Varyings input) : SV_Target
            {
                float2 uv = input.uv;

                // Shape mask remap. _38/_41 = uv*2-1 (NDC of the card). — blob b3 lines 66-67.
                float nx = mad(uv.x, 2.0, -1.0);
                float ny = mad(uv.y, 2.0, -1.0);

                // _66 = 1 - _LightRange1 — blob b3 line 68.
                float r1 = 1.0 + (-_LightRange1);

                // shape distance: lerp by _ShapeOption between quad (uv.y) and ellipse (length(nx,ny)).
                //   mad(_ShapeOption, length((nx,ny)) - uv.y, uv.y) — blob b3 line 69.
                float radial = sqrt(dot(float2(nx, ny), float2(nx, ny)));
                float shape = mad(_ShapeOption, radial + (-uv.y), uv.y);

                // _76 = saturate( (1/((-r1)+(1-_LightRange2))) * ((-r1)+shape) )  — dual-range remap — blob b3 line 69.
                float rangeDen = (-r1) + (1.0 + (-_LightRange2));
                float shapeMask = clamp((1.0 / rangeDen) * ((-r1) + shape), 0.0, 1.0);

                // _81 = smoothstep cubic of shapeMask — blob b3 line 70.
                float shapeSmooth = SmoothCube(shapeMask);

                // Edge fades. _106 = saturate( saturate(1-uv.x) * (1/_RightFadeRange) );
                //             _110 = saturate( (1/_LeftFadeRange) * uv.x ) — blob b3 lines 71-72.
                float rightT = clamp(clamp((-uv.x) + 1.0, 0.0, 1.0) * (1.0 / _RightFadeRange), 0.0, 1.0);
                float leftT  = clamp((1.0 / _LeftFadeRange) * uv.x, 0.0, 1.0);

                // _117 = smoothstep(right) * smoothstep(left) — blob b3 line 73.
                float edgeFade = SmoothCube(rightT) * SmoothCube(leftT);

                // Alpha base. b3: uses _BaseColor.w directly. b5: replaces it with a depth-fade-modulated alpha.
                float alphaBase = _BaseColor.w;
                #ifdef _ENABLE_DEPTH_FADE
                    // Linear eye depth from camera depth texture, reconstructed exactly as the blob:
                    //   _64 = 1 / mad(_ZBufferParams.z, sampledDepth, _ZBufferParams.w)   — blob b5 line 70.
                    // (URP _ZBufferParams matches HGRP layout: x=1-far/near, y=far/near, z=x/far, w=y/far.)
                    float rawDepth = SampleSceneDepth(input.screenUV);
                    float eyeDepth = 1.0 / mad(_ZBufferParams.z, rawDepth, _ZBufferParams.w);

                    // _74 = -(9.9999997e-05 + _DepthFadeRange) + eyeDepth   (9.9999997473787516e-05 = 1e-4) — blob b5 line 71.
                    float fadeLo = (-(9.9999997473787516355514526367188e-05 + _DepthFadeRange)) + eyeDepth;

                    // _86 = saturate( (1/((-fadeLo)+eyeDepth)) * ((-fadeLo)+_DepthFadePosition) ) — blob b5 line 72.
                    float depthT = clamp((1.0 / ((-fadeLo) + eyeDepth)) * ((-fadeLo) + _DepthFadePosition), 0.0, 1.0);

                    // _113 = mad(_EnableuseInvertFade, -1 + _NearFadeIntensity, 1) — blob b5 line 73.
                    float invA = mad(_EnableuseInvertFade, -1.0 + _NearFadeIntensity, 1.0);

                    // _120 = mad( smoothstep(depthT), (-invA) + mad(_EnableuseInvertFade, 1 - _NearFadeIntensity, _NearFadeIntensity), invA ) * _BaseColor.w
                    //   — blob b5 line 74.
                    float invB = mad(_EnableuseInvertFade, 1.0 + (-_NearFadeIntensity), _NearFadeIntensity);
                    alphaBase = mad(SmoothCube(depthT), (-invA) + invB, invA) * _BaseColor.w;
                #endif

                // Dark / light pre-multiplied card amounts. _118=dark, _119=light — blob b3 lines 74-75 / b5 83-84.
                float darkAmt  = edgeFade * ((shapeSmooth * _DarkIntensity)  * alphaBase);
                float lightAmt = edgeFade * ((shapeSmooth * _LightIntensity) * alphaBase);

                // Brighten (screen) RGB: _138 = lightAmt*3; per-channel = (_138 * baseRGB) / exposure — blob b3 lines 76-79 / b5 85-88.
                // NOTE: blob divides by _ExposureParams.x directly per channel (not via a precomputed
                //   reciprocal) — kept as division to be bit-exact under a runtime exposure != 1.
                float light3 = lightAmt * 3.0;
                float3 lightRGB = (light3 * _BaseColor.xyz) / _ExposureParams.x;

                // Output: lerp by _ColorOption between brighten card (RGB=lightRGB, A=lightAmt) and
                // darken card (RGB = mad(darkAmt, baseRGB/exposure - 1, 1), A=darkAmt). — blob b3 lines 80-83 / b5 89-92.
                float3 baseExp = _BaseColor.xyz / _ExposureParams.x;
                float3 darkRGB;
                darkRGB.x = mad(darkAmt, baseExp.x + (-1.0), 1.0);
                darkRGB.y = mad(darkAmt, baseExp.y + (-1.0), 1.0);
                darkRGB.z = mad(darkAmt, baseExp.z + (-1.0), 1.0);

                float4 col;
                col.x = mad(_ColorOption, (-lightRGB.x) + darkRGB.x, lightRGB.x);
                col.y = mad(_ColorOption, (-lightRGB.y) + darkRGB.y, lightRGB.y);
                col.z = mad(_ColorOption, (-lightRGB.z) + darkRGB.z, lightRGB.z);
                col.w = mad(_ColorOption, (-lightAmt) + darkAmt, lightAmt);
                return col;
            }
            ENDHLSL
        }
    }
}
