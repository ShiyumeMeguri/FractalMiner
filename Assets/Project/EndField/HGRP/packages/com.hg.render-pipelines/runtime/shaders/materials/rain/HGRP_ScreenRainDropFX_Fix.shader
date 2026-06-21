// Screen-space rain-drop distortion FX — single transparent "Distortion" pass.
// Renders a batch of camera-facing rain-drop quads directly in clip space (NDC),
// each drop fading via two radial smoothstep masks modulated by a noise texture
// and a sky/vertical-occlusion wetness gate. Output = flat _RainColor with a
// computed alpha (writes alpha into the distortion/UI-overlay buffer).
//
// Merged from: ReferenceProjects/.../materials/rain/screenraindropfx.shader
//   base variant  Sub0_Pass0_Vertex_b1.hlsl / Sub0_Pass0_Fragment_b2.hlsl   (catch-all #else)
//   delta variant Sub0_Pass0_Vertex_b3.hlsl / Sub0_Pass0_Fragment_b4.hlsl   (SRP_INSTANCING_ON)
// Keywords: (none kept — SRP_INSTANCING_ON only added an instanceID passthrough)
// Kept: per-drop clip-space placement (aspect-corrected), active-drop count guard (NaN cull),
//   noise-modulated alpha, two radial smoothstep falloffs (drop body + ring), per-drop intensity,
//   vertical-occlusion (sky-visibility) wetness gate, flat rain color RGB.
// Removed: SRP instancing (instanceID passthrough was unused by the math),
//   raw HGRP global cbuffers (_f_0 drop array / CB0UBO screen — re-exposed as material uniforms below),
//   HGRP global samplers (mapped to URP inline SAMPLER()).
//
// NOTE: This pass is DATA-DRIVEN by HGRP rain globals that URP has no equivalent for:
//   - _f_0[30] (per-drop clip pos.xy / intensity.z / scale.w) is re-exposed as the material
//     array _RainDropData[64] (.xy=clipCenter .z=intensity .w=scale). Drop count comes from
//     _RainTex0_ST.y (active-count, kept verbatim from source).  // blob Vertex_b1:53,55-66
//   - CB0_m0[87] (screen width/height for aspect) -> URP _ScreenParams.  // blob Vertex_b1:55
//   - The vertical-occlusion map (T0, SampleCmpLevelZero sky-shadow) is re-exposed as
//     _VerticalOcclusionMap + its WorldToVerticalOcclusionMap matrix; gate _UseVerticalOcclusion
//     mirrors _RainWetnessGlobalParam4.y>0.5. When off, occlusion term = 1.  // blob Fragment_b2:57-64
//   - _GlobalMipBias -> material float (URP has no such global on this path).  // blob Fragment_b2:68
// _ScreenDropFXNoiseTex.r drives both the alpha and the ring-radius offset.  // blob Fragment_b2:68-77

Shader "HGRP/ScreenRainDropFX_Fix" {
    Properties {
        [Header(Rain Drop)]
        _ScreenDropFXNoiseTex ("ScreenDropFXNoiseTex", 2D) = "white" {}
        _ScreenDropFXNoiseTex_ST ("ScreenDropFXNoiseTex_ST", Vector) = (1, 1, 0, 0)
        _RainTex0_ST ("RainTex0_ST (.y = active drop count)", Vector) = (1, 1, 1, 1)
        // .x = ring inner offset/scale, .y = noise->ring offset weight, .z = body inner radius, .w = body outer radius
        _RainParams ("RainParams (x:ringScale y:noiseWeight z:bodyInner w:bodyOuter)", Vector) = (1, 1, 1, 1)
        [HDR] _RainColor ("RainColor (.w = master alpha)", Color) = (1, 1, 1, 1)
        _GlobalMipBias ("Noise Mip Bias", Float) = 0

        [Header(Vertical Occlusion Wetness Gate)]
        [Toggle(_USE_VERTICAL_OCCLUSION)] _UseVerticalOcclusion ("Use Vertical Occlusion", Float) = 0
        _VerticalOcclusionMap ("Vertical Occlusion Map", 2D) = "white" {}
        // World->occlusion-map basis rows packed as 4 columns (matches column_major float4x4 in blob)
        _WorldToVerticalOcclusionMapRow0 ("WorldToVOcc Row0", Vector) = (1, 0, 0, 0)
        _WorldToVerticalOcclusionMapRow1 ("WorldToVOcc Row1", Vector) = (0, 1, 0, 0)
        _WorldToVerticalOcclusionMapRow2 ("WorldToVOcc Row2", Vector) = (0, 0, 1, 0)
        _WorldToVerticalOcclusionMapRow3 ("WorldToVOcc Row3", Vector) = (0, 0, 0, 1)
        _VerticalOcclusionMapUVScrollingOffset ("VOcc UV Scroll Offset", Vector) = (0, 0, 0, 0)

        // Render state (HGRP source: Blend SrcAlpha OneMinusSrcAlpha, One One / ZWrite Off / Cull Off)
        [HideInInspector] _SrcBlend ("__src", Float) = 5            // SrcAlpha
        [HideInInspector] _DstBlend ("__dst", Float) = 10           // OneMinusSrcAlpha
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1  // One
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 1  // One
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
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _RainColor;
                float4 _RainParams;
                float4 _RainTex0_ST;
                float4 _ScreenDropFXNoiseTex_ST;
                float  _GlobalMipBias;
                // Vertical occlusion (sky-visibility) wetness gate
                float4 _WorldToVerticalOcclusionMapRow0;
                float4 _WorldToVerticalOcclusionMapRow1;
                float4 _WorldToVerticalOcclusionMapRow2;
                float4 _WorldToVerticalOcclusionMapRow3;
                float4 _VerticalOcclusionMapUVScrollingOffset;
            CBUFFER_END

            // Per-drop simulation data — HGRP global _f_0[30] re-exposed as a material array.
            // .xy = drop center in clip space (NDC), .z = drop intensity (0..1), .w = drop scale.
            // Source caps drop index by _RainTex0_ST.y; 64 covers the source's 30-entry budget.  // blob Vertex_b1:53,56-66
            #define MAX_RAIN_DROPS 64
            float4 _RainDropData[MAX_RAIN_DROPS];

            TEXTURE2D(_ScreenDropFXNoiseTex);   SAMPLER(sampler_ScreenDropFXNoiseTex);
            TEXTURE2D(_VerticalOcclusionMap);   SAMPLER_CMP(sampler_VerticalOcclusionMap);

            // Smoothstep weight 3t^2 - 2t^3 spelled exactly as the blob: (t*t)*(t*-2+3).  // blob Fragment_b2:77
            float SmoothFalloff(float t)
            {
                return (t * t) * mad(t, -2.0, 3.0);
            }
        ENDHLSL

        Pass {
            Name "ScreenRainDropFX"
            Tags { "LightMode"="SRPDefaultUnlit" }     // HGRP "Distortion" LightMode -> URP unlit overlay pass
            // HGRP: Blend SrcAlpha OneMinusSrcAlpha, One One  /  ZWrite Off  /  Cull Off  /  ZClip On
            Blend [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend]
            ZWrite [_ZWrite]
            ZTest Always
            Cull Off

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_VERTICAL_OCCLUSION

            struct Attributes {
                // POSITION.xy = quad corner offsets (NDC-space, pre-scale); POSITION.z = drop index.  // blob Vertex_b1:51,56-57
                float3 positionOS : POSITION;
                float2 texcoord   : TEXCOORD0;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float2 uvRaw      : TEXCOORD0;   // source TEXCOORD_1: untouched quad uv     // blob Vertex_b1:62-63
                float2 uvScreen   : TEXCOORD1;   // source TEXCOORD_1_1: NDC->[0,1] screen uv // blob Vertex_b1:64-65
                float2 dropParam  : TEXCOORD2;   // source TEXCOORD_2: .x = per-drop intensity // blob Vertex_b1:80-81
            };

            // ===== Vertex: place drop quad in clip space (blob Sub0_Pass0_Vertex_b1:49-82) =====
            Varyings vert(Attributes v)
            {
                Varyings o = (Varyings)0;

                uint dropIndex = uint(int(floor(v.positionOS.z)));                 // blob Vertex_b1:51
                // Active-drop guard: index must be <= (_RainTex0_ST.y - 1).        // blob Vertex_b1:53
                int maxIndex = int(uint(int((-1.0) + _RainTex0_ST.y)));
                if (maxIndex >= int(dropIndex))
                {
                    float4 drop = _RainDropData[dropIndex];

                    // Aspect ratio = screenWidth / screenHeight.  // blob Vertex_b1:55 (CB0_m0[87].x/.y -> _ScreenParams.x/.y)
                    float aspect = (1.0 / _ScreenParams.y) * _ScreenParams.x;

                    // Clip-space center+scale: pos.xy = corner * drop.w + drop.xy (Y aspect-corrected).  // blob Vertex_b1:56-57
                    float clipX = mad(v.positionOS.x, drop.w, drop.x);
                    float clipY = mad(aspect * v.positionOS.y, drop.w, drop.y);
                    o.positionCS = float4(clipX, clipY, 1.0, 1.0);                 // blob Vertex_b1:58-61

                    o.uvRaw = v.texcoord;                                          // blob Vertex_b1:62-63
                    // NDC -> [0,1] screen uv; Y un-does the aspect squeeze.        // blob Vertex_b1:64-65
                    o.uvScreen.x = mad(clipX, 0.5, 0.5);
                    o.uvScreen.y = mad(clipY, 0.5, 0.5) / max(aspect, 0.00999999977648258209228515625);

                    // Per-drop intensity (source bit-round-trips drop.z through uint; value-identical).  // blob Vertex_b1:66,80
                    o.dropParam.x = drop.z;
                }
                else
                {
                    // Degenerate / inactive drop -> NaN clip pos so the triangle is culled.  // blob Vertex_b1:70-78
                    o.positionCS = asfloat(0x7fc00000u).xxxx; // NaN
                    o.uvRaw = 0.0;
                    o.uvScreen = 0.0;
                    o.dropParam.x = 0.0;
                }
                o.dropParam.y = 0.0;                                              // blob Vertex_b1:81
                return o;
            }

            // ===== Fragment: noise-modulated radial drop alpha (blob Sub0_Pass0_Fragment_b2:54-87) =====
            half4 frag(Varyings input) : SV_Target
            {
                // ---- Vertical-occlusion (sky visibility) wetness gate ----  // blob Fragment_b2:56-64
                float occlusion;
            #ifdef _USE_VERTICAL_OCCLUSION
                // World camera pos -> occlusion-map space via column_major WorldToVerticalOcclusionMap.
                // row[k].x/.y/.z reproduces blob _WorldToVerticalOcclusionMap[k].x/.y/.z.  // blob Fragment_b2:59
                float3 camPos = _WorldSpaceCameraPos;
                float occU = mad(_WorldToVerticalOcclusionMapRow2.x, camPos.z,
                              mad(_WorldToVerticalOcclusionMapRow0.x, camPos.x,
                                  camPos.y * _WorldToVerticalOcclusionMapRow1.x))
                              + _WorldToVerticalOcclusionMapRow3.x;
                float occV = mad(_WorldToVerticalOcclusionMapRow2.y, camPos.z,
                              mad(_WorldToVerticalOcclusionMapRow0.y, camPos.x,
                                  camPos.y * _WorldToVerticalOcclusionMapRow1.y))
                              + _WorldToVerticalOcclusionMapRow3.y;
                float occW = mad(_WorldToVerticalOcclusionMapRow2.z, camPos.z,
                              mad(_WorldToVerticalOcclusionMapRow0.z, camPos.x,
                                  camPos.y * _WorldToVerticalOcclusionMapRow1.z))
                              + _WorldToVerticalOcclusionMapRow3.z;
                // UV: u = u*0.5 + scrollOffset.x + 0.5 ; v = -(v*0.5+0.5) + scrollOffset.y + 1.0.  // blob Fragment_b2:59
                float2 occUV;
                occUV.x = mad(occU, 0.5, _VerticalOcclusionMapUVScrollingOffset.x) + 0.5;
                occUV.y = (-(mad(occV, 0.5, 0.5)) + _VerticalOcclusionMapUVScrollingOffset.y) + 1.0;
                // Compare depth clamped to a tiny floor 1/2048.  // blob Fragment_b2:59 (0.00048828125)
                float occDepth = max(occW, 0.00048828125);
                occlusion = SAMPLE_TEXTURE2D_SHADOW(_VerticalOcclusionMap, sampler_VerticalOcclusionMap,
                                                    float3(occUV, occDepth));
            #else
                occlusion = 1.0;                                                  // blob Fragment_b2:63 (asfloat(1065353216u))
            #endif

                float alpha;
                if (0.00048828125 < occlusion)                                   // blob Fragment_b2:66 (1/2048)
                {
                    // Noise sample (R channel) with global mip bias.  // blob Fragment_b2:68-69
                    float2 noiseUV = float2(
                        mad(input.uvRaw.x, _ScreenDropFXNoiseTex_ST.x, _ScreenDropFXNoiseTex_ST.z),
                        mad(input.uvRaw.y, _ScreenDropFXNoiseTex_ST.y, _ScreenDropFXNoiseTex_ST.w));
                    float noise = SAMPLE_TEXTURE2D_BIAS(_ScreenDropFXNoiseTex, sampler_ScreenDropFXNoiseTex,
                                                        noiseUV, _GlobalMipBias).x;

                    // Centered uv deltas (drop-local and screen-local).  // blob Fragment_b2:70-73
                    float2 dRaw    = input.uvRaw    - 0.5;   // (_159,_161)
                    float2 dScreen = input.uvScreen - 0.5;   // (_162,_163)

                    // Body falloff: remap radius from [z, w] of _RainParams to [0,1].  // blob Fragment_b2:74
                    float bodyT = clamp(
                        (1.0 / (((-0.0) - _RainParams.z) + _RainParams.w))
                        * (sqrt(dot(dRaw, dRaw)) + ((-0.0) - _RainParams.z)),
                        0.0, 1.0);

                    // Ring radius driven by noise: (noise-0.5)*RainParams.y + 1.  // blob Fragment_b2:75
                    float ringRadius = dot((noise + (-0.5)).xx, _RainParams.y.xx) + 1.0;

                    // Ring falloff: ((screenDist - ringRadius*RainParams.x) / (-(ringRadius*RainParams.x))).  // blob Fragment_b2:76
                    float ringT = clamp(
                        mad((-0.0) - _RainParams.x, ringRadius, sqrt(dot(dScreen, dScreen)))
                        * (1.0 / ((-0.0) - (ringRadius * _RainParams.x))),
                        0.0, 1.0);

                    // Combine: occlusion * noise * dropIntensity * smooth(ring) * smooth(body) * RainColor.w.  // blob Fragment_b2:77
                    alpha = occlusion
                          * (noise
                             * (clamp(input.dropParam.x, 0.0, 1.0)
                                * ((SmoothFalloff(ringT) * SmoothFalloff(bodyT)) * _RainColor.w)));
                }
                else
                {
                    alpha = 0.0;                                                 // blob Fragment_b2:81 (asfloat(0u))
                }

                // RGB = flat rain color, A = computed coverage.  // blob Fragment_b2:83-86
                return half4(_RainColor.rgb, alpha);
            }
            ENDHLSL
        }
    }
}
