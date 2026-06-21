// HGRP FarRain — procedural distant-rain-streak card (single transparent ForwardOnly pass) ported to URP.
// Merged from: E:/.../com.hg.render-pipelines/runtime/shaders/materials/rain/farrain/  (blob 6 vertex / blob 7 fragment = base #else catch-all = HG_ENABLE_MV only).
// Keywords: _RAIN_WAVE  (RAIN_WAVE selects the texture-driven rain-ripple path, blob 9/13; default-off = procedural streaks, blob 7).
// Kept (1:1 math, cite blob Sub0_Pass0_{Vertex_b6,Fragment_b7}.hlsl):
//   - Procedural rain-streak field: per-column row hash (frac/sin), per-cell random (frac(sin(dot))*43758), animated streak sine, streak-width/edge falloff, intensity ramp.  (Fragment_b7 lines 112-132)
//   - MESH-UV-derived streak grid (input.uv.xy * _RainTex0_ST): frag b7 `TEXCOORD_1`=semantic TEXCOORD2=raw uv (b6:94-95), worldPos rides `TEXCOORD`/TEXCOORD1. Height fade uses worldY (TEXCOORD.y). Vertical mask term TEXCOORD_2 (camera-forward * screen-space slope, Vertex_b6 line 92-93).
//   - Soft scene-depth intersection fade against the camera depth buffer (streak dissolves behind geometry).  (Fragment_b7 line 217)
//   - Height fade above camera (130m start / 120m range smoothstep).  (Fragment_b7 lines 130-132)
//   - _RainParams (.x phase .y density .z spawn-threshold), _RainMaskParams (.w mask-enable .z mask-scale), _RainColor (.rgb tint .a opacity).
//   - _RAIN_WAVE path: dual rain-ripple texture sample + ripple transform UVs + wetness/height gate.  (Fragment_b13 lines 121-126, 212)
// Removed (pixel-neutral pipeline infra, substituted by URP or dropped as engine-global):
//   - HG motion-vector MRT (SV_Target1) + _NonJitteredViewNoTransProjMatrix / _PrevNonJitteredViewNoTransProjMatrix / _TaaJitterStrength jitter  -> URP TransformWorldToHClip (motion vectors are a separate URP pass).  (Vertex_b6 lines 76-106)
//   - HG fog stack: AtmosphereFog (height/scatter) + ExponentialFog + VolumetricFog froxel (3D LUT + blue-noise reproject)  -> URP MixFog.  (Fragment_b7 lines 158-216)
//   - VerticalOcclusionMap rain-wetness gate (_RainWetnessGlobalParam4.y / T0 SampleCmp) -> dropped; the HG default when wetness disabled is occ=1.0 (Fragment_b7 lines 148-155), so the streak field is emitted unmodulated as in the no-wetness branch.
//   - Render-pixel-RNG froxel jitter, _FrameCount, _BinningBufferOffsets, _GlobalMipBias, IV/SH GI params, cloud-shadow params -> none have a visible effect on the opaque streak field; dropped.
//
// NOTE: This is a VFX overlay, NOT a lit surface — no BRDF, no SH, no shadows. Geometry is a Cull Front inward-facing dome/box around the camera (source Cull Front kept).
//   The rain streaks are fully PROCEDURAL from world position; _RainTex0 is sampled ONLY in the _RAIN_WAVE ripple path (kept as a real map there). In the base path _RainTex0_ST is reused purely as streak-grid scale (.xy) — matches HG.
//   Soft-depth fade uses URP _CameraDepthTexture (requires Depth Texture enabled on the URP asset), replacing HG's hand-bound camera-depth T1 (Fragment_b7 line 217).

Shader "HGRP/FarRain_Fix"
{
    Properties
    {
        [Header(Rain)]
        _RainTex0 ("Rain Texture 0 (ripple, _RAIN_WAVE only)", 2D) = "white" {}
        _RainTex1_ST ("Rain Tex1 ST", Vector) = (1, 1, 1, 1)
        _RainParams ("Rain Params (.x phase .y density .z spawn-threshold)", Vector) = (1, 1, 1, 1)
        _RainMaskParams ("Rain Mask Params (.z mask-scale .w mask-enable)", Vector) = (-1, 1, 1, 1)
        [HDR] _RainColor ("Rain Color (.rgb tint .a opacity)", Color) = (1, 1, 1, 1)

        [Header(Rain Wave)]
        [Toggle(_RAIN_WAVE)] _UseRainWave ("Use Rain Wave (texture ripples)", Float) = 0

        // Render-state plumbing (source: Blend SrcAlpha OneMinusSrcAlpha / ZWrite Off / Cull Front, skeleton lines 12-15)
        [HideInInspector] _SrcBlend ("__src", Float) = 5   // SrcAlpha
        [HideInInspector] _DstBlend ("__dst", Float) = 10  // OneMinusSrcAlpha
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [Enum(UnityEngine.Rendering.CullMode)] _Cull ("Cull", Float) = 1  // Front
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _RainTex0_ST;
                float4 _RainTex1_ST;
                float4 _RainParams;
                float4 _RainMaskParams;
                float4 _RainColor;
            CBUFFER_END

            TEXTURE2D(_RainTex0);   SAMPLER(sampler_RainTex0);

            // ---- magic-constant decode table (from Fragment_b7) ----
            static const float ROW_HASH_MUL   = 0.011;            // blob 7 line 114  (0.010999999940395355f)
            static const float INV_1024       = 0.0009765625;     // blob 7 lines 119-120  (1/1024)
            static const float CELL_HASH_SCALE = 1024.0;          // blob 7 line 123
            static const float2 CELL_HASH_DOT = float2(12.9898001, 78.2330017); // blob 7 line 123
            static const float CELL_HASH_AMP  = 43758.546875;     // blob 7 line 123
            static const float EDGE_INV_035   = 2.8571426868;     // blob 7 line 126  (1/0.35)
            static const float HALF_BIT       = 0.5;              // blob 7 line 129  asfloat(1056964608u)
            static const float MIN_2048       = 0.00048828125;    // blob 7 lines 117/129/133  (1/2048)
            static const float INV_120        = 0.0083333337680;  // blob 7 line 131  (1/120)
            static const float RSQRT_EPS      = 9.9999999392e-09; // blob 7 line 142  (~1e-8)
            static const float SOFT_DEPTH_K   = 0.1000000015;     // blob 7 line 217  (soft-intersection fade scale)
            static const float RAIN_PI        = 3.1415927410;     // blob 7 line 93  (named RAIN_PI: URP Core already #defines PI)

            // cond ? 1.0 : 0.0 — blob spells this `asfloat((cond ? 0xFFFFFFFF : 0u) & 1065353216u)` (blob 7 lines 127,132)
            float Mask1(bool cond) { return cond ? 1.0 : 0.0; }

            // Reconstruct linear eye depth of the opaque scene at this screen UV.
            // HG bound camera depth as T1 and did (1/(z*_ZBufferParams.z + _ZBufferParams.w)) - (1/w_clip)  (blob 7 line 217).
            // URP: LinearEyeDepth(SampleSceneDepth(uv)) - thisFragmentEyeDepth.
            float SceneDepthDelta(float2 screenUV, float thisEyeDepth)
            {
                float rawScene = SampleSceneDepth(screenUV);
                float sceneEye = LinearEyeDepth(rawScene, _ZBufferParams);
                return sceneEye - thisEyeDepth;
            }
        ENDHLSL

        Pass
        {
            Name "FarRain"
            Tags { "LightMode"="UniversalForwardOnly" }

            Blend [_SrcBlend] [_DstBlend]
            ZWrite [_ZWrite]
            ZClip On
            Cull [_Cull]

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _RAIN_WAVE

            struct Attributes
            {
                float3 positionOS : POSITION;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float3 positionWS : TEXCOORD0; // TEXCOORD_1 in blob (world pos)
                float2 uv         : TEXCOORD1; // TEXCOORD_1_1 in blob (raw uv)
                float2 maskTerm   : TEXCOORD2; // TEXCOORD_2 in blob: .x ring-mask, .y vertical screen-slope
                float  fogFactor  : TEXCOORD3; // URP MixFog substitute for HG fog stack (computed from clip-Z at vertex)
            };

            // =========================================================
            // VERTEX  (1:1 source = Sub0_Pass0_Vertex_b6.hlsl lines 73-95)
            // HG built world pos as (ObjectToWorld*posOS) - cameraPos + cameraPos (camera-relative),
            // then re-added cameraPos for TEXCOORD_1. URP TransformObjectToWorld is the absolute world pos directly.
            // =========================================================
            Varyings vert(Attributes v)
            {
                Varyings o;

                float3 positionWS = TransformObjectToWorld(v.positionOS);   // blob 6 lines 73-75 (+cam) then 86-88 (=world)
                o.positionWS = positionWS;
                o.positionCS = TransformWorldToHClip(positionWS);           // blob 6 lines 76-82 (jitter dropped)
                o.uv = v.uv;                                                // blob 6 lines 94-95

                // Object origin in world (HG: _unity_ObjectToWorld[3].xyz). URP: unity_ObjectToWorld._m03_m13_m23.
                float3 objOriginWS = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);

                // TEXCOORD_2.y: vertical screen-space slope term (blob 6 line 92).
                //   max(dot(-camFwd, posWS - objOrigin), 0) * (-1 / P._m11) * (-1 + _ScreenParams.z)
                //   -camFwd = -(_ViewMatrix row2 .z basis) -> URP UNITY_MATRIX_V[2].xyz is that same camera-forward basis row.
                float3 negCamFwd = -float3(UNITY_MATRIX_V[0].z, UNITY_MATRIX_V[1].z, UNITY_MATRIX_V[2].z);
                float vertSlope = max(dot(negCamFwd, positionWS - objOriginWS), 0.0);
                o.maskTerm.y = vertSlope * (-1.0 / UNITY_MATRIX_P[1].y) * (-1.0 + _ScreenParams.z);

                // TEXCOORD_2.x: radial ring mask (blob 6 line 93).
                //   (sin(PI / _RainTex0_ST.x) * length(posOS.xz)) * _RainMaskParams.z * 0.5
                o.maskTerm.x = (sin(RAIN_PI / _RainTex0_ST.x) * sqrt(dot(v.positionOS.xz, v.positionOS.xz)))
                               * _RainMaskParams.z * 0.5;

                o.fogFactor = ComputeFogFactor(o.positionCS.z); // HG fog stack (blob 7 lines 158-216) -> URP MixFog
                return o;
            }

            // =========================================================
            // FRAGMENT  (1:1 source = Sub0_Pass0_Fragment_b7.hlsl lines 112-230)
            // =========================================================
            half4 frag(Varyings input) : SV_Target
            {
            #ifdef _RAIN_WAVE
                // ---- Texture-driven rain-ripple path (1:1 source = Fragment_b13 lines 121-126,212; vertex b8 sets maskTerm=0) ----
                // Ripple UVs are built from the RAW MESH UV (frag b13 `TEXCOORD_1` = semantic TEXCOORD2
                // = vertex TEXCOORD_1_1 = uv, b8:82-83), NOT worldPos (worldPos = `TEXCOORD`/TEXCOORD1).
                // HG transforms uv through the VerticalOcclusionMap matrix; with that HG global absent we
                // substitute the material ripple tiling (_RainTex0_ST/_RainTex1_ST) for the world->ripple
                // scale (TODO(1:1) below), preserving abs(frac(u)-0.5)*scale*2+off and u.y*scale+off STRUCTURE.
                float2 rippleUV0 = float2(
                    (abs(frac(input.uv.x * _RainTex0_ST.x) - 0.5) * _RainTex0_ST.z) * 2.0 + _RainTex1_ST.z,
                    input.uv.y * _RainTex0_ST.y + _RainTex1_ST.w);                                          // blob 13 line 121
                float2 rippleUV1 = float2(
                    (abs(frac(input.uv.x * _RainTex1_ST.x) - 0.5) * _RainTex1_ST.z) * 2.0 + _RainParams.z,
                    input.uv.y * _RainTex1_ST.y + _RainParams.w);                                           // blob 13 line 122
                float r0 = SAMPLE_TEXTURE2D(_RainTex0, sampler_RainTex0, rippleUV0).x;                      // blob 13 line 121
                float r1 = SAMPLE_TEXTURE2D(_RainTex0, sampler_RainTex0, rippleUV1).y;                      // blob 13 line 122

                // Height fades: above-camera 130m/120m smoothstep (blob 13 lines 123-124) and a second slope gate (line 125).
                float hAbove = input.positionWS.y - _WorldSpaceCameraPos.y;                                 // blob 13 line 123 (_165)
                float fHeight = saturate((max(hAbove, 0.0) - 130.0) * -INV_120);                            // blob 13 line 124
                fHeight = (fHeight * fHeight) * mad(fHeight, -2.0, 3.0);                                     // smoothstep
                float rainField = (r0 * r1) * min(fHeight, 1.0);                                            // blob 13 line 126
                // TODO(1:1): blob 13 line 125 second gate uses HG _VerticalOcclusionMapUVScrollingOffset.y (engine global) — dropped; ripple uses single height fade.

                clip(rainField - MIN_2048);                                                                 // blob 13 line 127
                float3 rainColor = _RainColor.rgb;
                float alpha = rainField;

                // Soft scene-depth fade (blob 13 line 212 inner term).
                float thisEye = LinearEyeDepth(input.positionWS, GetWorldToViewMatrix());
                float depthDelta = SceneDepthDelta(input.positionCS.xy * (1.0 / _ScreenParams.xy), thisEye);
                float softDepth = min(max(depthDelta, 0.0) * SOFT_DEPTH_K, 1.0);                            // blob 13 line 212
                alpha = saturate(softDepth * rainField * _RainColor.w);
                // HG writes straight color + alpha with Blend SrcAlpha OneMinusSrcAlpha (NOT premultiplied), blob skeleton line 12.
                rainColor = MixFog(rainColor, input.fogFactor);
                return half4(rainColor, alpha);
            #else
                // ============================================================
                // Procedural rain-streak field (1:1 source = Fragment_b7 lines 112-132)
                // Streak grid coords from the RAW MESH UV * _RainTex0_ST.xy.
                // SPIRV-Cross semantic trap: in frag b7 `TEXCOORD_1` (semantic TEXCOORD2) is the
                // vertex's TEXCOORD_1_1 = raw mesh uv (b6:94-95), NOT worldPos. worldPos rides
                // `TEXCOORD` (semantic TEXCOORD1, b6:89-91). So _66/_67 are uv.xy, not positionWS.xz.
                // ============================================================
                float gx = input.uv.x * _RainTex0_ST.x;   // _66  blob 7 line 112 (TEXCOORD_1.x = uv.x)
                float gy = input.uv.y * _RainTex0_ST.y;    // _67  blob 7 line 113 (TEXCOORD_1.y = uv.y)

                // Per-column row hash (blob 7 lines 114-117).
                float h0  = frac(floor(gx) * ROW_HASH_MUL);                       // _73  line 114
                float h1  = (h0 + 7.5) * h0;                                      // _76  line 115
                float h2  = frac((h1 + h1) * h1);                                 // _79  line 116  (column random)
                float row = floor(mad(h2, 0.5, 1.0) * _RainTex0_ST.y);           // _90  line 117

                // Streak cell vertical coord (blob 7 line 118).
                float gyCell = mad(mad(h2, 0.5, _RainParams.x) + 0.5, row, gy);   // _97  line 118

                // Per-cell random via frac(sin(dot(...)))*43758 (blob 7 lines 119-123).
                float cx = floor(gx) * INV_1024;                                  // _99  line 119
                float cy = floor(gyCell) * INV_1024;                              // _101 line 120
                float ax = frac(abs(cx));                                         // _110 line 121
                float ay = frac(abs(cy));                                         // _111 line 122
                // signed-abs: (v >= -v) ? frac(|v|) : -frac(|v|)  == copysign(frac(|v|), v)  (blob 7 line 123)
                float sx = (cx >= -cx) ? ax : -ax;
                float sy = (cy >= -cy) ? ay : -ay;
                float cellRand = frac(sin(dot(float2(sx * CELL_HASH_SCALE, sy * CELL_HASH_SCALE),
                                              CELL_HASH_DOT)) * CELL_HASH_AMP);   // _127 line 123

                // Animated streak brightness (blob 7 line 124).
                float streak = mad(sin(mad(h2, row, gy)), 0.5, 0.5) * cellRand;   // _131 line 124

                // Density / intensity ramp (blob 7 lines 125-126).
                float dens   = min(mad(h2, 0.6, 0.4) * (0.4 * _RainParams.y), 1.0);              // _150 line 125
                float edge   = max((cellRand - 0.65) * EDGE_INV_035, 0.0);                       // _169 line 126

                // Streak-width band gated by ring mask (blob 7 line 127).
                //   abs( mad(mad(streak,2,-1),0.3,0.5) + (-frac(gx)) )  minus  ringMaskTerm , widened, clamped, edged.
                float ringMask = Mask1(0.0 < _RainMaskParams.w)
                                 * clamp(0.25 / ((1.0 / max(input.maskTerm.y, 0.01)) * input.maskTerm.x), 0.0, 1.0); // line 127 inner
                float band = max((max(mad(-ringMask, 1.0,
                                          abs(mad(mad(streak, 2.0, -1.0), 0.3, 0.5) - frac(gx))), 0.0) - 0.2) * -5.0, 0.0); // _204 line 127

                // Vertical streak profile inside the cell (blob 7 lines 128-129).
                float d0   = max(dens - 0.2, 0.0);                                               // _209 line 128
                float prof = clamp((1.0 / (-d0 + max(dens, MIN_2048)))
                                   * (abs(HALF_BIT - frac(gyCell)) - d0), 0.0, 1.0);              // _219 line 129

                // Height fade above camera: 130m start, 120m range (blob 7 lines 130-131).
                float hAbove = input.positionWS.y - _WorldSpaceCameraPos.y;                      // _233 line 130
                float fHeight = saturate((max(hAbove, 0.0) - 130.0) * -INV_120);                 // _239 line 131
                fHeight = (fHeight * fHeight) * mad(fHeight, -2.0, 3.0);                          // smoothstep part of line 132

                // Combined streak field (blob 7 line 132): smoothstep(prof) * smoothstep(band) * smoothstep(edge) * spawn-gate.
                float sProf = mad(-mad(prof, -2.0, 3.0), prof * prof, 1.0);                       // (1 - smoothstep'(prof))
                float sBand = (band * band) * mad(band, -2.0, 3.0);
                float sEdge = (edge * edge) * mad(edge, -2.0, 3.0);
                float spawn = Mask1(cellRand >= mad(1.0 - _RainParams.z, 0.35, 0.65));            // line 132 spawn threshold
                float rainField = fHeight * ((sProf * sBand) * (sEdge * spawn));                  // _243 line 132

                float3 rainColor;
                float alpha;
                if (MIN_2048 < rainField)                                                         // blob 7 line 133
                {
                    // Soft scene-depth intersection fade + streak self-occlusion (blob 7 line 217).
                    float thisEye = LinearEyeDepth(input.positionWS, GetWorldToViewMatrix());
                    float2 screenUV = input.positionCS.xy * (1.0 / _ScreenParams.xy);
                    float depthDelta = SceneDepthDelta(screenUV, thisEye);
                    // streak self-shadow term: -streak*7.5 + depthDelta , >=0, *0.1, <=1  (blob 7 line 217)
                    float fade = min(max(mad(-streak, 7.5, depthDelta), 0.0) * SOFT_DEPTH_K, 1.0);
                    alpha = saturate(fade * rainField * _RainColor.w);                            // line 217 (wetness occ=1.0)
                    rainColor = _RainColor.rgb;
                    rainColor = MixFog(rainColor, input.fogFactor);                              // HG fog stack -> URP MixFog
                }
                else
                {
                    rainColor = _RainColor.rgb;                                                   // blob 7 lines 226-228
                    alpha = rainField;                                                            // blob 7 line 229
                }
                // HG writes straight color + alpha with Blend SrcAlpha OneMinusSrcAlpha (NOT premultiplied), blob skeleton line 12.
                return half4(rainColor, alpha);
            #endif
            }
            ENDHLSL
        }
    }
    Fallback Off
}
