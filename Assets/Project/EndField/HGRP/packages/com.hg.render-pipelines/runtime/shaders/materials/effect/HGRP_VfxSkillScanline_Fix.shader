// HGRP VFX Skill ScanLine — single fullscreen post-process overlay pass.
// A screen-space "scan reveal" effect for skills/abilities: reconstructs world position from the
// camera depth buffer, then layers two sub-effects over the scene underlay —
//   * BLACK_BOX      : a radial "black box" reveal — distance-banded contour lines (sampled from a
//                      mirror-wrapped noise tex) + a background tint that fades in/out by two
//                      smoothstep distance rings + a silhouette-edge alpha from the camera normals.
//   * VFX_SCANLINE   : a 3-cone box-projected scanline pulse (cosine bands) + animated value-noise
//                      bands scrolling in world XZ + a highlight term + an edge fade derived from the
//                      camera normals octahedral buffer. SCANLINE_USE_MASK adds a projected mask-tex
//                      modulation of the noise (and a separate screen mask read).
// Drawn as a fullscreen triangle, masked by stencil, additively composited over the underlay.
// Merged from: vfxskillscanline.shader collapsing 8 variants (b6..b21) of {BLACK_BOX, SCANLINE_USE_MASK, VFX_SCANLINE}.
//   Vertex base = vfxskillscanline/Sub0_Pass0_Vertex_b6.hlsl  (catch-all #else; ALL vertex variants b6..b20 identical)
//   Frag  base  = vfxskillscanline/Sub0_Pass0_Fragment_b7.hlsl  (catch-all #else — plain underlay blit, == b11 SCANLINE_USE_MASK)
//   Frag  bbox  = vfxskillscanline/Sub0_Pass0_Fragment_b9.hlsl  (BLACK_BOX)
//   Frag  scan  = vfxskillscanline/Sub0_Pass0_Fragment_b15.hlsl (VFX_SCANLINE)
//   Frag  all   = vfxskillscanline/Sub0_Pass0_Fragment_b21.hlsl (BLACK_BOX + SCANLINE_USE_MASK + VFX_SCANLINE)
// Keywords: _BLACK_BOX, _VFX_SCANLINE, _SCANLINE_USE_MASK
// Kept: fullscreen-triangle vertex (clip+UV exactly per blob), depth→world reconstruction via InvViewProj,
//   black-box contour+background+edge-alpha math, scanline 3-cone projector + value-noise band + highlight +
//   normals edge-fade, all magic constants/branch bounds, additive composite over underlay, exposure divide,
//   stencil mask (Ref 4 / ReadMask 7 / Comp NotEqual), Blend SrcAlpha OneMinusSrcAlpha, ZTest Less, ZWrite Off, Cull Off.
// Removed: SPIRV-Cross plumbing (gl_Position/gl_VertexIndex/spvBitfieldInsert), HGRP global cbuffer
//   (type_ShaderVariablesGlobal: _ViewMatrix/_InvViewProjMatrix/_WorldSpaceCameraPos_Internal/_ScreenSize/
//   _unity_OrthoParams/_Time/_GlobalMipBias/_ExposureParams/_VFXParams0) — mapped to URP globals (UNITY_MATRIX_I_VP,
//   UNITY_MATRIX_V, _WorldSpaceCameraPos, _ScreenParams, unity_OrthoParams, _Time) or re-exposed material Vectors
//   (_ExposureParams, _VFXParams0, _GlobalMipBias); instancing/TAA/motion vectors (none present).
//
// NOTE: depth source  = URP _CameraDepthTexture (HGRP global T0, SampleLevel at screen-uv, mip 0).
// NOTE: normals source = URP _CameraNormalsTexture (HGRP global, Load(fragcoord) — octahedral-encoded, used by the
//   edge-fade in the VFX_SCANLINE / BLACK_BOX alpha). Requires URP DepthNormals prepass enabled.
// NOTE: underlay source = URP _CameraOpaqueTexture (HGRP global, sampled at the fullscreen TEXCOORD with mip bias)
//   — the scene color this overlay composites onto. Requires the renderer's Opaque Texture enabled.
// NOTE: _VFXParams0 = (.xyz scanline distort center / .w black-box time phase) — HGRP global, here a material Vector.
//   _ExposureParams.x = post-exposure; _GlobalMipBias = scene/noise sample bias. All HGRP globals with no URP equal.
// NOTE: _BlackBox* / _ScanLine* / _Box* params come from HGRP cbuffer type_cb0 (per-effect constants); re-exposed
//   as material properties 1:1 in name and swizzle (the C# effect driver writes them; defaults are placeholders).

Shader "HGRP/VfxSkillScanline_Fix" {
    Properties {
        [Header(Mode)]
        [Toggle(_BLACK_BOX)]         _EnableBlackBox    ("Enable Black Box", Float) = 0
        [Toggle(_VFX_SCANLINE)]      _EnableScanLine    ("Enable Scan Line", Float) = 1
        [Toggle(_SCANLINE_USE_MASK)] _ScanLineUseMask   ("Scan Line Use Mask", Float) = 0

        [Header(Global)]
        // HGRP globals with no URP equivalent — re-exposed as material props (written by the effect driver).
        _VFXParams0     ("VFX Params0 (.xyz scan distort center, .w bbox time)", Vector) = (0, 0, 0, 0)
        _ExposureParams ("Exposure Params (.x post-exposure)", Vector) = (1, 0, 0, 0)
        _GlobalMipBias  ("Sample Mip Bias", Float) = 0

        [Header(Black Box)]
        [HDR] _BlackBoxBackGroundTint ("BlackBox BG Tint", Color) = (0, 0, 0, 1)
        [HDR] _BlackBoxContourColor   ("BlackBox Contour Color", Color) = (1, 1, 1, 1)
        _BlackBoxCenterPos ("BlackBox Center Pos (world)", Vector) = (0, 0, 0, 0)
        _BlackBoxParams1   ("BlackBox Params1", Vector) = (1, 0, 1, 0)
        _BlackBoxParams2   ("BlackBox Params2", Vector) = (1, 1, 0, 0)
        _BlackBoxParams3   ("BlackBox Params3", Vector) = (1, 1, 0, 0)
        _BlackBoxParams4   ("BlackBox Params4", Vector) = (1, 1, 0, 0)
        _BlackBoxParams5   ("BlackBox Params5", Vector) = (1, 1, 1, 1)

        [Header(Scan Line)]
        [HDR] _ScanLineTint          ("ScanLine Tint", Color) = (1, 1, 1, 1)
        [HDR] _ScanLineHighlightTint ("ScanLine Highlight Tint", Color) = (1, 1, 1, 1)
        _ScanLineCenterPos ("ScanLine Center Pos (.xyz world, .w phase)", Vector) = (0, 0, 0, 0)
        _ScanLineParams1   ("ScanLine Params1", Vector) = (1, 1, 1, 1)
        _ScanLineParams2   ("ScanLine Params2", Vector) = (1, 1, 1, 1)
        _ScanLineParams3   ("ScanLine Params3", Vector) = (1, 1, 1, 1)
        _ScanLineParams4   ("ScanLine Params4", Vector) = (1, 1, 1, 1)
        _ScanLineParams5   ("ScanLine Params5 (mask proj)", Vector) = (1, 1, 0, 0)
        _ScanLineParams6   ("ScanLine Params6", Vector) = (1, 1, 1, 1)
        _ScanLineParams7   ("ScanLine Params7", Vector) = (1, 1, 0, 0)
        _ScanLineParams9   ("ScanLine Params9", Vector) = (0, 0, 0, 0)
        _ScanLineParams10  ("ScanLine Params10", Vector) = (1, 1, 0, 1)
        _BoxPosition1 ("Box Position1", Vector) = (0, 0, 0, 1)
        _BoxPosition2 ("Box Position2", Vector) = (0, 0, 0, 1)
        _BoxPosition3 ("Box Position3", Vector) = (0, 0, 0, 1)
        _BoxVec1 ("Box Vec1 (.xz dir, .w len)", Vector) = (1, 0, 0, 1)
        _BoxVec2 ("Box Vec2 (.xz dir, .w len)", Vector) = (1, 0, 0, 1)
        _BoxVec3 ("Box Vec3 (.xz dir, .w len)", Vector) = (1, 0, 0, 1)

        [Header(Render State)]
        [HideInInspector] _SrcBlend ("__src", Float) = 5  // SrcAlpha
        [HideInInspector] _DstBlend ("__dst", Float) = 10 // OneMinusSrcAlpha
    }
    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent+100"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Global re-exposures (HGRP type_ShaderVariablesGlobal had no URP equal)
                float4 _VFXParams0;       // .xyz scanline distort center, .w black-box time phase  (c185)
                float4 _ExposureParams;   // .x post-exposure                                       (c109)
                float  _GlobalMipBias;    // scene/noise sample mip bias                            (c108)

                // Black Box (HGRP type_cb0 c0..c7)
                float4 _BlackBoxBackGroundTint;
                float4 _BlackBoxCenterPos;
                float4 _BlackBoxParams1;
                float4 _BlackBoxParams2;
                float4 _BlackBoxParams3;
                float4 _BlackBoxParams4;
                float4 _BlackBoxParams5;
                float4 _BlackBoxContourColor;

                // Scan Line (HGRP type_cb0 c8..c25)
                float4 _ScanLineTint;
                float4 _ScanLineCenterPos;
                float4 _ScanLineParams1;
                float4 _ScanLineParams2;
                float4 _ScanLineParams3;
                float4 _ScanLineParams4;
                float4 _ScanLineParams5;
                float4 _ScanLineParams6;
                float4 _ScanLineParams7;
                float4 _ScanLineParams9;
                float4 _ScanLineParams10;
                float4 _ScanLineHighlightTint;
                float4 _BoxPosition1;
                float4 _BoxPosition2;
                float4 _BoxPosition3;
                float4 _BoxVec1;
                float4 _BoxVec2;
                float4 _BoxVec3;
            CBUFFER_END

            // ---- Screen-space source textures (HGRP unnamed globals T0/T1/T2.. re-identified by role) ----
            // Depth — HGRP T0, SampleLevel(LinearClamp, screenUV, 0). Plain TEXTURE2D so we keep an explicit LOD.
            TEXTURE2D(_CameraDepthTexture);
            // Camera octahedral normals — HGRP T1, Load(fragcoord). Used by the silhouette edge-fade.
            TEXTURE2D(_CameraNormalsTexture);
            // Scene underlay color — HGRP underlay tex, SampleBias(LinearRepeat/Clamp, TEXCOORD, _GlobalMipBias).
            TEXTURE2D(_CameraOpaqueTexture);
            // Black-box distortion / contour noise — HGRP T1 (BLACK_BOX path), SampleBias(LinearMirror, uv, bias).
            TEXTURE2D(_BlackBoxNoiseTex);          SAMPLER(sampler_BlackBoxNoiseTex);
            // Black-box silhouette contour mask — HGRP T3 (BLACK_BOX), SampleBias(LinearClamp, TEXCOORD, bias).
            TEXTURE2D(_BlackBoxContourTex);        SAMPLER(sampler_BlackBoxContourTex);
            // Scanline projected mask — HGRP T2 (SCANLINE_USE_MASK path), SampleBias(LinearMirror, projUV, bias).
            TEXTURE2D(_ScanLineMaskTex);           SAMPLER(sampler_ScanLineMaskTex);
            // sampler_LinearClamp is provided by Core.hlsl (GlobalSamplers.hlsl) — used for depth + screen reads.

            // 2*pi — blob 6.28318500518798828125f (Fragment_b15.hlsl:109 etc.)
            static const float TWO_PI = 6.28318500518798828125;
            // view-length epsilon — blob 9.9999999392252902907785028219223e-09f (Fragment_b9.hlsl:107)
            static const float VIEW_LEN_EPS = 9.9999999392252902907785028219223e-09;

            struct Attributes {
                uint vertexID : SV_VertexID;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
            };

            // Fullscreen triangle — 1:1 from Vertex_b6.hlsl:58-66 (ALL variants b6..b20 identical).
            // _34 = bitfieldInsert(0, vid, offset=1, count=1) = (vid & 1) << 1  ∈ {0,2}   (b6:58-59)
            // _35 = vid & 2                                                     ∈ {0,2}   (b6:60)
            // UV.y = 1-(vid&2) is the blob's own convention (NOT URP GetFullScreenTriangleTexCoord) — transcribed exactly.
            Varyings vert(Attributes input) {
                Varyings o;
                uint vid = input.vertexID;
                float x = float((vid << 1u) & 2u);   // _34 — b6:59  (bitfieldInsert(0,vid,1,1))
                float y = float(vid & 2u);            // _35 — b6:60
                o.positionCS.x = mad(x, 2.0, -1.0);   // b6:61
                o.positionCS.y = mad(y, 2.0, -1.0);   // b6:62
                o.positionCS.z = 1.0;                 // b6:65
                o.positionCS.w = 1.0;                 // b6:66
                o.uv.x = x;                           // b6:63
                o.uv.y = (-y) + 1.0;                  // b6:64  (((-0.0f)-_35)+1.0)
                return o;
            }

            // ---------------------------------------------------------------------------------------------
            // Depth → world position. blob Fragment_b15.hlsl:76-83 (== b9:60-71, b21:83-94).
            // ndcX = mad(fragX*screenZ, 2, -1);  ndcY = -(mad(fragY*screenW, 2, -1))   (b15:78-79)
            // screenUV = (floor(frag)+0.5)*screenZW;  depth = T0.SampleLevel(LinearClamp, screenUV, 0).x (b15:76)
            // posH = IVP[0]*ndcX + IVP[1]*ndcY + IVP[2]*depth + IVP[3]; worldPos = posH.xyz / posH.w   (b15:80-83)
            // URP: _InvViewProjMatrix → UNITY_MATRIX_I_VP. The blob indexes columns ([col].row, column_major),
            // so posH = mul(I_VP, float4(ndcX, ndcY, depth, 1)). _ScreenSize.zw → 1/_ScreenParams.xy.
            float3 ReconstructWorldPos(float2 fragCoord, out float2 outScreenUV, out float outDepthRaw) {
                float2 invScreen = 1.0 / _ScreenParams.xy;                 // _ScreenSize.zw
                outScreenUV = (floor(fragCoord) + 0.5) * invScreen;        // b15:76 (float(uint(frag))+0.5)*screenZW
                // blob: T0.SampleLevel(LinearClamp, texelCenterUV, 0). A linear sample at the exact texel center ==
                // a point load; URP's _CameraDepthTexture has no bound sampler, so use the stereo-safe load (1:1).
                outDepthRaw = LOAD_TEXTURE2D_X(_CameraDepthTexture, uint2(floor(fragCoord))).x; // b15:76
                float ndcX =  mad(fragCoord.x * invScreen.x, 2.0, -1.0);   // b15:78
                float ndcY = -mad(fragCoord.y * invScreen.y, 2.0, -1.0);   // b15:79
                float4 posH = mul(UNITY_MATRIX_I_VP, float4(ndcX, ndcY, outDepthRaw, 1.0)); // b15:80-83
                return posH.xyz / posH.w;
            }

            // Octahedral normal decode of the camera normals buffer. blob Fragment_b15.hlsl:183-190 (== b21:193-200).
            // n.xy = mad(load.xy, 2, -1);  t = 1 - (|n.x|+|n.y|);  if (t<0) octa-wrap;  normalize; return saturate(n*t... )
            // Here we only need the scalar edge term the blob produces: clamp(rsqrt(dot(n3,n3))*t, 0,1).
            float DecodeNormalEdge(float2 fragCoord) {
                float4 enc = LOAD_TEXTURE2D_X(_CameraNormalsTexture, uint2(floor(fragCoord))); // b15:183 T1.Load(int3(frag,0))
                float nx = mad(enc.x, 2.0, -1.0);                                    // b15:184
                float ny = mad(enc.y, 2.0, -1.0);                                    // b15:185
                float t  = (-dot(float2(1.0, 1.0), float2(abs(nx), abs(ny)))) + 1.0; // b15:186  1-(|nx|+|ny|)
                bool wrap = t < 0.0;                                                 // b15:187
                // octa fold (b15:188-189): if wrap, nx = sign(nx)*(1-|ny|), ny = sign(ny)*(1-|nx|)
                float fx = wrap ? (((nx >= 0.0) ? 1.0 : -1.0) * ((-abs(ny)) + 1.0)) : nx; // b15:188
                float fy = wrap ? (((ny >= 0.0) ? 1.0 : -1.0) * ((-abs(nx)) + 1.0)) : ny; // b15:189
                return clamp(rsqrt(dot(float3(fx, t, fy), float3(fx, t, fy))) * t, 0.0, 1.0); // b15:190
            }

            // Value-noise hash used by the scanline bands. blob Fragment_b15.hlsl:534-535,564 (repeated).
            // h(x) = frac(abs(x)); s = (x>=-x)? h : -h;  return frac(sin(dot(s*1024, (12.9898,78.233)))*43758.546875)
            float Hash2(float a, float b) {
                float ha = frac(abs(a));                                              // b15:534
                float hb = frac(abs(b));                                              // b15:535
                float sa = ((a >= ((-0.0) - a)) ? ha : ((-0.0) - ha)) * 1024.0;       // b15:564 (sign-fold * 1024)
                float sb = ((b >= ((-0.0) - b)) ? hb : ((-0.0) - hb)) * 1024.0;
                return frac(sin(dot(float2(sa, sb), float2(12.98980045318603515625, 78.233001708984375))) * 43758.546875); // b15:564
            }

            // 2D value noise on a grid, period 1024 (cell scale 0.0009765625 = 1/1024). blob Fragment_b15.hlsl:488-626.
            // Bilinear blend of 4 corner hashes with smoothstep weights derived from frac(p). Returns the raw band value
            // BEFORE the *_ScanLineParams3.w scale (callers apply the scale, matching b15:626 / b21:621 layout).
            float ValueNoise2D(float2 p) {
                float fx = frac(p.x);                                                 // b15:499/646
                float fy = frac(p.y);                                                 // b15:500/647
                float ix = floor(p.x);                                                // b15:501/648
                float iy = floor(p.y);                                                // b15:502/649
                float wx = mad((-0.0) - fx, 2.0, 3.0) * (fx * fx);                    // b15:507*503 smoothstep
                float wy = mad((-0.0) - fy, 2.0, 3.0) * (fy * fy);                    // b15:512
                // corner hashes (blob addresses corners as (ix+{0,1})*1/1024 etc.) b15:517-591
                float h00 = Hash2( ix          * 0.0009765625,  iy          * 0.0009765625); // b15:591 (ix,iy)
                float h10 = Hash2((ix + 1.0)   * 0.0009765625, (iy)         * 0.0009765625); // b15:626 corner
                float h01 = Hash2((ix)         * 0.0009765625, (iy + 1.0)   * 0.0009765625); // b15:564
                float h11 = Hash2((ix + 1.0)   * 0.0009765625, (iy + 1.0)   * 0.0009765625);
                // bilinear: b15:626 mad chain — lerp rows by wx then columns by wy
                float bottom = mad(wx, h10 - h00, h00);
                float top    = mad(wx, h11 - h01, h01);
                return mad(wy, top - bottom, bottom);
            }
        ENDHLSL

        Pass {
            Name "VFXScanLine"
            // Source render-state — vfxskillscanline.shader:10-22.
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend], [_SrcBlend] [_DstBlend]  // SrcAlpha OneMinusSrcAlpha (both RGB+A)
            ZClip On
            ZTest Less
            ZWrite Off
            Cull Off
            Stencil {
                Ref 4
                ReadMask 7
                Comp NotEqual
                Pass Keep
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _BLACK_BOX
            #pragma shader_feature_local _SCANLINE_USE_MASK
            #pragma shader_feature_local _VFX_SCANLINE

            half4 frag(Varyings input, float4 positionCS : SV_Position) : SV_Target {
                float2 fragCoord = positionCS.xy;

            // ============================================================================================
            // BASE / SCANLINE_USE_MASK-only — plain underlay blit. blob Fragment_b7.hlsl:39-43 (== b11).
            // SV_Target.rgb = T0.SampleBias(LinearClamp, TEXCOORD, _GlobalMipBias).rgb; SV_Target.a = 0.
            // ============================================================================================
            #if !defined(_BLACK_BOX) && !defined(_VFX_SCANLINE)
                float4 underlay = SAMPLE_TEXTURE2D_BIAS(_CameraOpaqueTexture, sampler_LinearClamp, input.uv, _GlobalMipBias); // b7:39
                return half4(underlay.x, underlay.y, underlay.z, 0.0); // b7:40-43
            #else
                // ---- shared depth → world reconstruction (b9:60-71 / b15:76-83 / b21:83-94) ----
                float2 screenUV; float depthRaw;
                float3 worldPos = ReconstructWorldPos(fragCoord, screenUV, depthRaw);

                float3 outColor = 0.0;
                float  outAlpha = 0.0;

                // =========================================================================================
                // VFX_SCANLINE. blob Fragment_b15.hlsl:84-199 (mask-on additions from b21:188, b21:229-242).
                // =========================================================================================
                #ifdef _VFX_SCANLINE
                {
                    // Direction from scanline center, projected to XZ plane. b15:84-90
                    float3 toC = worldPos - _ScanLineCenterPos.xyz;          // b15:84-86 (_139.._141)
                    float  invXZ = rsqrt(dot(toC.xz, toC.xz));               // b15:87 (_145)
                    float2 dirXZ = toC.xz * invXZ;                           // b15:88-89 (_146,_147)
                    float  dist  = sqrt(dot(toC, toC));                      // b15:90 (_152) = |toC|

                    // --- 3 box-projector cones. Each: dot(dir, boxVecN.xz) → clamp → narrow band ---
                    float d1 = dot(dirXZ, _BoxVec1.xz);                      // b15:91 (_158)
                    float d2 = dot(dirXZ, _BoxVec2.xz);                      // b15:96 (_261)
                    float d3 = dot(dirXZ, _BoxVec3.xz);                      // b15:97 (_268)
                    float c1 = clamp(d1, 0.0, 1.0);                          // b15:92 (_162)
                    float c2 = clamp(d2, 0.0, 1.0);                          // b15:98 (_271)
                    float c3 = clamp(d3, 0.0, 1.0);                          // b15:106 (_393)
                    // cone falloff narrowing: (c-0.95)*20  (0.949999988 / 19.999996) b15:93,100,107
                    float n1 = max((c1 + (-0.949999988079071044921875)) * 19.999996185302734375, 0.0); // b15:93 (_177)
                    float n2 = max((c2 + (-0.949999988079071044921875)) * 19.999996185302734375, 0.0); // b15:100 (_283)
                    float n3 = max((c3 + (-0.949999988079071044921875)) * 19.999996185302734375, 0.0); // b15:107 (_404)
                    // perpendicular distance along each cone: dist * sqrt(1 - d*d)  b15:99,101,108
                    float p1 = dist * sqrt(mad((-0.0) - d1, d1, 1.0));       // b15:101 (_293)
                    float p2 = dist * sqrt(mad((-0.0) - d2, d2, 1.0));       // b15:99 (_275)
                    float p3 = dist * sqrt(mad((-0.0) - d3, d3, 1.0));       // b15:108 (_414)

                    float invP7y = 1.0 / _ScanLineParams7.y;                 // b15:94 (_188)
                    float invP7x = 1.0 / _ScanLineParams7.x;                 // b15:95 (_189)
                    float band1 = 1.0 + ((-0.0) - _ScanLineParams9.z);       // b15:102 (_302)
                    float band2 = ((-0.0) - band1) + (1.0 + ((-0.0) - _ScanLineParams9.w)); // b15:103 (_305)
                    float invP6y = 1.0 / _ScanLineParams6.y;                 // b15:104 (_313)
                    float halfP6y = 0.5 * _ScanLineParams6.y;               // b15:105 (_322)

                    // Per-cone cosine pulse, gated by (boxVec.w-cropped dist < halfP6y) & (min(P6w,boxVec.w)>=dist).
                    // b15:109 (_452) — additive over 3 cones. asfloat(cmp & 0x3f800000) = (cmp?1:0).
                    // cone3 term:
                    float gate3 = (min(_ScanLineParams6.w, _BoxVec3.w) >= dist) ? 1.0 : 0.0;       // b15:109
                    float pulse3 = (p3 < halfP6y) ? 1.0 : 0.0;
                    float cos3 = pulse3 * (cos((invP6y * p3) * TWO_PI) + 1.0);
                    float falloff3 = ((-0.0) - mad(dist * (1.0 / _BoxVec3.w), band2, band1)) + 1.0;
                    float amp3 = (c3 * _ScanLineParams6.z) * 0.0500000007450580596923828125;
                    float term3 = gate3 * (((cos3 * (falloff3 * amp3)) * _ScanLineParams6.x) * _BoxPosition3.w);
                    // cone2 term:
                    float gate2 = (min(_ScanLineParams6.w, _BoxVec2.w) >= dist) ? 1.0 : 0.0;       // b15:109
                    float pulse2 = (p2 < halfP6y) ? 1.0 : 0.0;
                    float cos2 = pulse2 * (cos((invP6y * p2) * TWO_PI) + 1.0);
                    float amp2 = (c2 * _ScanLineParams6.z) * 0.0500000007450580596923828125;
                    float falloff2 = ((-0.0) - mad(dist * (1.0 / _BoxVec2.w), band2, band1)) + 1.0;
                    float term2 = gate2 * (((cos2 * (amp2 * falloff2)) * _ScanLineParams6.x) * _BoxPosition2.w);
                    // cone1 term:
                    float gate1 = (min(_ScanLineParams6.w, _BoxVec1.w) >= dist) ? 1.0 : 0.0;       // b15:109
                    float pulse1 = (p1 < halfP6y) ? 1.0 : 0.0;
                    float cos1 = pulse1 * (cos((invP6y * p1) * TWO_PI) + 1.0);
                    float falloff1 = ((-0.0) - mad(dist * (1.0 / _BoxVec1.w), band2, band1)) + 1.0;
                    float amp1 = (c1 * _ScanLineParams6.z) * 0.0500000007450580596923828125;
                    float term1 = gate1 * (((cos1 * (falloff1 * amp1)) * _ScanLineParams6.x) * _BoxPosition1.w);
                    float pulseSum = max(term3 + term2 + term1, 0.0);        // b15:109 (_452), b15:111 (_454=max(.,0))

                    // Cone "highlight width" select — picks P10.x or P10.y per cone by 1>=(invP7*boxVec.w), smoothstep(nN).
                    // b15:110 (_453) — mad chain over 3 cones with base 1, +1 +1 at the tail.
                    float sel3 = ((1.0 >= (invP7x * _BoxVec3.w)) ? _ScanLineParams10.y : 0.0)
                               + ((1.0 >= (invP7y * _BoxVec3.w)) ? _ScanLineParams10.x : 0.0);     // b15:110
                    float sm3 = (n3 * n3) * mad(n3, -2.0, 3.0);
                    float sel2 = ((1.0 >= (invP7x * _BoxVec2.w)) ? _ScanLineParams10.y : 0.0)
                               + ((1.0 >= (invP7y * _BoxVec2.w)) ? _ScanLineParams10.x : 0.0);
                    float sm2 = (n2 * n2) * mad(n2, -2.0, 3.0);
                    float sel1 = ((1.0 >= (invP7x * _BoxVec1.w)) ? _ScanLineParams10.y : 0.0)
                               + ((1.0 >= (invP7y * _BoxVec1.w)) ? _ScanLineParams10.x : 0.0);
                    float sm1 = (n1 * n1) * mad(n1, -2.0, 3.0);
                    // _453 = (((sel1*sm1)*10 + 1)*... ) chain; +asfloat(1065353216) twice = +1 +1. asfloat(0x3f800000)=1.0
                    float highlightWidth = mad(sel3 * sm3, 10.0,
                                           mad(sel2 * sm2, 10.0,
                                           mad(sel1 * sm1, 10.0, 1.0)) + 1.0) + 1.0; // b15:110 (_453)

                    // --- animated value-noise bands scrolling in world XZ (two noise sets) ---
                    // set A (used for distort dist), set B (used for line position). b15:115-145, 146-176
                    float aX = mad(_Time.y, _ScanLineParams4.w, worldPos.x * _ScanLineParams3.y); // b15:115 (_488)
                    float aY = mad(_Time.y, _ScanLineParams4.w, worldPos.z * _ScanLineParams3.y); // b15:116 (_489)
                    float bX = mad(_Time.y, _ScanLineParams2.x, worldPos.x * _ScanLineParams3.x); // b15:117 (_497)
                    float bY = mad(_Time.y, _ScanLineParams2.x, worldPos.z * _ScanLineParams3.x); // b15:118 (_498)
                    float noiseA = ValueNoise2D(float2(aX, aY)) * _ScanLineParams3.w;             // b15:119-145,*=P3.w (_626)
                    float noiseB = ValueNoise2D(float2(bX, bY));                                  // b15:146-176 (inside _780)

                    // distort distance ramp: smoothstep over (|worldPos - VFXParams0.xyz| + P4.x*noiseA - P4.y)/(-P4.y)
                    float3 toV = worldPos - _VFXParams0.xyz;                 // b15:112-114 (_473.._475)
                    float distortDist = clamp((1.0 / ((-0.0) - _ScanLineParams4.y))
                        * (mad(_ScanLineParams4.x, noiseA, sqrt(dot(toV, toV))) + ((-0.0) - _ScanLineParams4.y)),
                        0.0, 1.0);                                           // b15:146 (_642)
                    float distortSmooth = (distortDist * distortDist) * mad(distortDist, -2.0, 3.0); // b15:147 (_645)
                    float widthScale = mad(distortSmooth, _ScanLineParams4.z, 1.0); // b15:175 (_771)

                #ifdef _SCANLINE_USE_MASK
                    // mask-on: line position folds a projected mask-tex sample into the noise. b21:188 (_822)
                    // projUV = ( (toC.x/(centerW+P1.z))*0.5+0.5 )*P5.x+P5.z , ( (-(worldPos.z)+centerZ)/(centerW+P1.z)*0.5+0.5 )*P5.y+P5.w
                    float denom = _ScanLineCenterPos.w + _ScanLineParams1.z;  // b21:187 (_792)
                    float2 maskUV = float2(
                        mad(mad(toC.x / denom, 0.5, 0.5), _ScanLineParams5.x, _ScanLineParams5.z),
                        mad(mad((((-0.0) - worldPos.z) + _ScanLineCenterPos.z) / denom, 0.5, 0.5), _ScanLineParams5.y, _ScanLineParams5.w));
                    float maskN = SAMPLE_TEXTURE2D_BIAS(_ScanLineMaskTex, sampler_ScanLineMaskTex, maskUV, _GlobalMipBias).x; // b21:188
                    // _822 = mad( mad(noiseB, maskN, noiseA*distortSmooth), P3.z, dist )   (b21:188)
                    float linePos = mad(mad(noiseB, maskN, noiseA * distortSmooth), _ScanLineParams3.z, dist) / _ScanLineParams1.y; // b21:188-189 (_822/_832 pre-frac)
                    float frac0 = frac(linePos + ((-0.0) - _ScanLineCenterPos.w)); // b21:189 (_832)
                #else
                    // mask-off: line position = distortSmooth*noiseA + noiseB, scaled by P3.z, offset by dist. b15:176 (_780)
                    // _780 = mad( mad(_645=distortSmooth, _626=noiseA, <noiseB>), P3.z, dist ) / P1.y
                    float linePos = mad(mad(distortSmooth, noiseA, noiseB), _ScanLineParams3.z, dist) / _ScanLineParams1.y; // b15:176 (_780)
                    float frac0 = frac(linePos + ((-0.0) - _ScanLineCenterPos.w)); // b15:177 (_786)
                #endif

                    // line bands: two clamped ramps centered on pulseSum and on P1.x, width P2.y. b15:178,194 / b21:847,1012
                    float lineHi = clamp(((pulseSum + frac0) + (-1.0)) * _ScanLineParams2.y, 0.0, 1.0)
                                 + clamp((((-0.0) - frac0) + pulseSum) * _ScanLineParams2.y, 0.0, 1.0); // b15:178 (_801)
                    float lineBase = clamp(((frac0 + _ScanLineParams1.x) + (-1.0)) * _ScanLineParams2.y, 0.0, 1.0)
                                   + clamp((((-0.0) - frac0) + _ScanLineParams1.x) * _ScanLineParams2.y, 0.0, 1.0); // b15:194 (_972)

                    // distance window gate: (dist>=P1.w) & ((centerW+P1.z)>=dist). b15:179 (_844) / b21:191 (_881)
                    float distGate = ((dist >= _ScanLineParams1.w) && ((_ScanLineCenterPos.w + _ScanLineParams1.z) >= dist)) ? 1.0 : 0.0; // b15:179
                    // exposure-relative highlight scale. b15:180 (_866)
                    float expScale = mad(_ScanLineParams10.w, (-1.0) + _ExposureParams.x, 1.0); // b15:180 (_866)
                    // radial fade by P2.z smoothstep. b15:181-182 (_876/_879)
                    float radFade = clamp((1.0 / ((-0.0) - _ScanLineParams2.z)) * (dist + ((-0.0) - _ScanLineParams2.z)), 0.0, 1.0); // b15:181
                    float radSmooth = (radFade * radFade) * mad(radFade, -2.0, 3.0); // b15:182 (_879)

                    // silhouette edge-fade from camera normals octa buffer. b15:183-191 (_896.._949)
                    float edge = DecodeNormalEdge(fragCoord);               // b15:183-190 (_939)
                    float edgeFade = edge / mad(1.0 + ((-0.0) - _ScanLineParams2.w), edge, _ScanLineParams2.w); // b15:191 (_949)

                    // alpha + color accumulation. b15:192-199 / b21:204-228.
                    float aTint = (distGate * (radSmooth * _ScanLineTint.w)) * edgeFade;      // b15:192 (_950)
                    float aHi   = (distGate * (radSmooth * _ScanLineHighlightTint.w)) * edgeFade; // b15:193 (_951)
                    float hiAmt = highlightWidth * 0.333000004291534423828125;               // b15:167 (_712)
                    // NOTE: keep aTint RAW here. Standalone (b15:195) clamps to [0,1]; combined (b21:242) uses it raw
                    // inside the final clamp. The base-vs-effect return below clamps when scanline is the only effect.
                    outAlpha = aTint;                                                         // b15:192/195 (_950)
                    // SV_Target.c = mad( clamp(distGate*lineBase*(widthScale*Tint.c),0,1000), aTint,
                    //                    aHi * ( hiAmt * clamp(distGate*lineHi*(widthScale*Hi.c),0,1000) / expScale ) )  b15:197-199
                    float3 tintC = _ScanLineTint.xyz;
                    float3 hiC   = _ScanLineHighlightTint.xyz;
                    float3 baseTerm = min(max(distGate * (lineBase * (widthScale * tintC)), 0.0), 1000.0); // b15:197-199 first arg
                    float3 hiTerm   = min(max(distGate * (lineHi   * (widthScale * hiC)),   0.0), 1000.0); // b15:197-199 hi
                    // b15:197-199: SV_Target.c = mad(baseTerm, _950, _951 * ((_712 * hiTerm) / _866)) + underlay.
                    // op-order matches blob exactly: aHi * ((hiAmt * hiTerm) / expScale).
                    outColor += mad(baseTerm, aTint, aHi * ((hiAmt * hiTerm) / expScale));    // b15:197-199
                #if !defined(_BLACK_BOX)
                    // Scanline STANDALONE (b15:197-199) adds the scene underlay (_1001 = T2.SampleBias at TEXCOORD) into
                    // RGB. In the combined variant (b21:226) the underlay arrives once via the BLACK_BOX term instead, so
                    // only add it here when BLACK_BOX is NOT also compiled (else it would be double-counted).
                    float4 scanUnderlay = SAMPLE_TEXTURE2D_BIAS(_CameraOpaqueTexture, sampler_LinearClamp, input.uv, _GlobalMipBias); // b15:196 (_1001)
                    outColor += scanUnderlay.xyz;                                             // b15:197-199 (+ _1001)
                #endif
                }
                #endif // _VFX_SCANLINE

                // =========================================================================================
                // BLACK_BOX. blob Fragment_b9.hlsl:58-107 (mask-on path uses sampler_LinearMirrorOnce, math identical b21).
                // =========================================================================================
                #ifdef _BLACK_BOX
                {
                    float3 toC = worldPos - _BlackBoxCenterPos.xyz;          // b9:72-74 (_143.._145)
                    float  bbDist = sqrt(dot(toC, toC));                     // b9:75 (_150)

                    // noise-driven contour lookup, two cascaded samples of the mirror-wrapped noise tex.
                    // sample1: uv = (P3.z*VFX0.w + bbDist)*P3.x , (P3.w*VFX0.w + worldPos.y)*P3.y     b9:76
                    float s1y = SAMPLE_TEXTURE2D_BIAS(_BlackBoxNoiseTex, sampler_BlackBoxNoiseTex, float2(
                        mad(_BlackBoxParams3.z, _VFXParams0.w, bbDist) * _BlackBoxParams3.x,
                        mad(_BlackBoxParams3.w, _VFXParams0.w, worldPos.y) * _BlackBoxParams3.y), _GlobalMipBias).y; // b9:76-77 (_175)
                    // sample2: offset by P5.x*(s1y*P5.zw); read .x  b9:78
                    float s2x = SAMPLE_TEXTURE2D_BIAS(_BlackBoxNoiseTex, sampler_BlackBoxNoiseTex, float2(
                        mad(_BlackBoxParams2.z, _VFXParams0.w, mad(_BlackBoxParams5.x, s1y * _BlackBoxParams5.z, bbDist)) * _BlackBoxParams2.x,
                        mad(_BlackBoxParams2.w, _VFXParams0.w, mad(_BlackBoxParams5.x, s1y * _BlackBoxParams5.w, worldPos.y)) * _BlackBoxParams2.y), _GlobalMipBias).x; // b9:78-79 (_209)
                    // intensity sample3: read .z, remap by P5.y. b9:82
                    float s3z = SAMPLE_TEXTURE2D_BIAS(_BlackBoxNoiseTex, sampler_BlackBoxNoiseTex, float2(
                        mad(_BlackBoxParams4.z, _VFXParams0.w, bbDist) * _BlackBoxParams4.x,
                        mad(_BlackBoxParams4.w, _VFXParams0.w, worldPos.y) * _BlackBoxParams4.y), _GlobalMipBias).z; // b9:82
                    float contourIntensity = mad(_BlackBoxParams5.y, s3z + (-1.0), 1.0); // b9:82 (_262)

                    // two distance rings → smoothstep. ranges from Params1: (x-y) and (z-w). b9:80-86
                    float r0 = ((-0.0) - _BlackBoxParams1.y) + _BlackBoxParams1.x;        // b9:80 (_230)
                    float r1 = ((-0.0) - _BlackBoxParams1.w) + _BlackBoxParams1.z;        // b9:81 (_231)
                    float ring0 = clamp((1.0 / (((-0.0) - r0) + _BlackBoxParams1.x)) * (bbDist + ((-0.0) - r0)), 0.0, 1.0); // b9:83 (_276)
                    float ring1 = clamp((1.0 / (((-0.0) - r1) + _BlackBoxParams1.z)) * (bbDist + ((-0.0) - r1)), 0.0, 1.0); // b9:84 (_277)
                    float ringSmooth0 = (ring0 * ring0) * mad(ring0, -2.0, 3.0);          // b9:85 (_284)
                    float ringSmooth1 = (ring1 * ring1) * mad(ring1, -2.0, 3.0);          // b9:86 (_285)

                    // depth presence mask: contour only where depth != 0. b9:87 (_295)
                    float depthMask = (depthRaw != 0.0) ? 1.0 : 0.0;                      // b9:87
                    float bgBlend = mad((-0.0) - ringSmooth0, depthMask, 1.0);            // b9:88 (_310)
                    float bgTintAmt = depthMask * ringSmooth0;                            // b9:89 (_311)

                    // underlay sample at TEXCOORD. b9:90 (_321)
                    float4 underlay = SAMPLE_TEXTURE2D_BIAS(_CameraOpaqueTexture, sampler_LinearClamp, input.uv, _GlobalMipBias); // b9:90
                    // contour color over background tint over underlay. b9:91-93
                    float3 contour = min(max(contourIntensity * (((s2x * _BlackBoxContourColor.xyz) * ringSmooth1) * depthMask), 0.0), 1000.0); // b9:91-93
                    float3 bbColor = contour + mad(_BlackBoxBackGroundTint.xyz, bgTintAmt, bgBlend * underlay.xyz); // b9:91-93

                    // --- silhouette alpha from contour mask tex + camera-relative depth gradient. b9:94-107 ---
                    float contourMask = SAMPLE_TEXTURE2D_BIAS(_BlackBoxContourTex, sampler_BlackBoxContourTex, input.uv, _GlobalMipBias).x; // b9:94 (_354)
                    // reconstruct world pos at the contour-mask depth, camera-relative. b9:96-99
                    float ndcX =  mad(fragCoord.x / _ScreenParams.x, 2.0, -1.0);          // b9:60 reused (_59)
                    float ndcY = -mad(fragCoord.y / _ScreenParams.y, 2.0, -1.0);          // b9:61 reused (_63)
                    float4 posH2 = mul(UNITY_MATRIX_I_VP, float4(ndcX, ndcY, contourMask, 1.0)); // b9:96 (_378 group)
                    float3 wpos2 = posH2.xyz / posH2.w;
                    float3 camRel2 = wpos2 - _WorldSpaceCameraPos.xyz;                    // b9:97-99 (_391.._393)
                    float3 camRel  = worldPos - _WorldSpaceCameraPos.xyz;                 // b9:100-102 (_405.._407)
                    // camera forward (ortho vs perspective). b9:103-106
                    bool isPersp = (0.0 == unity_OrthoParams.w);                          // b9:103 (_431)
                    float fwdX = isPersp ? (((-0.0) - worldPos.x) + _WorldSpaceCameraPos.x) : UNITY_MATRIX_V._m20; // b9:104 (_439)  _ViewMatrix[0].z
                    float fwdZ = isPersp ? (((-0.0) - worldPos.z) + _WorldSpaceCameraPos.z) : UNITY_MATRIX_V._m22; // b9:105 (_446)  _ViewMatrix[2].z
                    float fwdY = isPersp ? (((-0.0) - worldPos.y) + _WorldSpaceCameraPos.y) : UNITY_MATRIX_V._m21; // b9:106 (_453)  _ViewMatrix[1].z
                    // depth-edge silhouette: 1 if mask reveals (no contour), else 1 - clamp(grad, 0,1). b9:107
                    float reveal = clamp(((-0.0) - depthRaw) + contourMask, 0.0, 1.0);    // b9:107 inner clamp
                    float grad = clamp((rsqrt(max(dot(float3(fwdX, fwdY, fwdZ), float3(fwdX, fwdY, fwdZ)), VIEW_LEN_EPS)) * fwdY)
                        * ((((-0.0) - sqrt(dot(camRel2, camRel2))) + sqrt(dot(camRel, camRel))) * 0.5), 0.0, 1.0); // b9:107
                    float silhouette = (0.0 >= reveal) ? 1.0 : (((-0.0) - grad) + 1.0);   // b9:107
                    float bbAlpha = min(silhouette * max(ringSmooth1, ringSmooth0), 1.0); // b9:107 (SV_Target.w)

                    // Composite black box over the scanline accumulation (b21 sums BLACK_BOX onto VFX_SCANLINE).
                #if defined(_VFX_SCANLINE)
                    outColor += bbColor;        // b21:226-228 (scanline + (contour + bg))
                    outAlpha  = clamp(mad(max(ringSmooth1, ringSmooth0), silhouette, outAlpha), 0.0, 1.0); // b21:242 form
                #else
                    outColor = bbColor;         // b9:91-93
                    outAlpha = bbAlpha;         // b9:107
                #endif
                }
                #endif // _BLACK_BOX

                // Final alpha clamp — 1:1 across all effect cases:
                //   scanline-only b15:195 clamp(_950,0,1); bbox-only b9:107 min(.,1) (already ≥0); combined b21:242 clamp(.,0,1).
                return half4(outColor, clamp(outAlpha, 0.0, 1.0));
            #endif // base vs effect
            }
            ENDHLSL
        }
    }
}
