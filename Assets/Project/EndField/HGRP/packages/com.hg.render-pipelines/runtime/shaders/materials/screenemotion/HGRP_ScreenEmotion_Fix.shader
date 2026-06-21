// HGRP ScreenEmotion — robot/vehicle facial-display emote shader (unlit, screen-mask overlay).
// Merged from: screenemotion.shader base variant (catch-all #else, Blob 5 fragment / Blob 4 vertex).
//   ForwardOnly + DepthOnly passes; the HG_ENABLE_MV / DITHER / SRP_INSTANCING_ON keyword
//   permutations differ ONLY in GPU-skinning / motion-vector / dither plumbing (pixel-neutral),
//   so a single clean variant reproduces all of them.
// Keywords: (none — _ScreenType / _BlendMode / _IgnorePostExposure are plain uniform branches)
// Kept: sprite-sheet frame addressing (_Frame/_RowsColumns/_ScaleOffset with cell-edge texel clamp),
//   distance-adaptive screen mask (CROSSHAIR dot-grid + HORSCAN horizontal scanline, distance LOD on
//   _ScreenTilling at 3m/6m, _ScreenScale shrink past 6m), _ScreenEffectColor mask tint,
//   _TintColor (HDR) emissive tint, post-exposure desaturate+scale via _IgnorePostExposure.
// Removed: GPU skinning (T0 ByteAddressBuffer + BLENDWEIGHTS/BLENDINDICES — static mesh, URP TransformObjectToWorld),
//   motion vectors (SV_Target1 / _PrevNonJitteredViewNoTransProjMatrix / _unity_MatrixPreviousM),
//   TAA jitter (_TaaJitterStrength), LOD crossfade (_unity_LODFade), particle instance-color tint
//   (_unity_Float4x5_Param2), HGRP atmosphere/exponential/volumetric fog (_AtmosphereFogParams* /
//   _ExponentialFogParams* / _VolumetricFogParams* — substituted by URP MixFog),
//   per-fragment world-pos-from-depth reconstruction (camera-relative-world rendering artifact;
//   URP gives positionWS directly from the vertex stage).
//
// NOTE: the emote billboard normally renders unlit; mask distance uses true world-space distance
//   camera→fragment. _MainTex alpha gates the whole emote (premultiplied into output RGB by tex.a).
// _MainTex sampled with mip-bias (_GlobalMipBias → 0 here); channel legend: RGB=emote color, A=coverage.

Shader "HGRP/ScreenEmotion_Fix" {
    Properties {
        [Header(Main)]
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        _MainTex ("Emote Atlas (RGB color, A coverage)", 2D) = "black" {}
        [HDR] [Gamma] _TintColor ("Emissive Tint", Color) = (1, 1, 1, 1)
        _Frame ("Frame Index", Float) = 1
        _RowsColumns ("Atlas Rows/Columns", Vector) = (1, 1, 0, 0)
        _ScaleOffset ("Cell Scale (xy) / Offset (zw)", Vector) = (1, 1, 0, 0)
        [ToggleUI] _IgnorePostExposure ("Ignore Auto-Exposure", Float) = 1

        [Header(Screen Mask)]
        [Enum(Crosshair, 0, HorScan, 1)] _ScreenType ("Mask Effect", Float) = 1
        _ScreenTilling ("Mask Tilling", Range(2, 100)) = 30
        _ScreenScale ("Mask Scale", Range(0, 1)) = 0.5
        [Gamma] _ScreenEffectColor ("Mask Color (A = mask strength)", Color) = (0, 0, 0, 1)

        [Header(Advanced)]
        [Enum(Opaque, 0, Transparent, 1)] [HideInInspector] _SurfaceType ("Surface Type", Float) = 0
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 0

        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _StencilReadMask ("__stencilReadMask", Float) = 255
        [HideInInspector] _StencilWriteMask ("__stencilWriteMask", Float) = 255
        [HideInInspector] _StencilComp ("__stencilComp", Float) = 8
        [HideInInspector] _StencilOp ("__stencilOp", Float) = 0
    }

    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Opaque"
            "Queue"="Geometry"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float _CullMode;
                float _Frame;
                float _IgnorePostExposure;
                float _ScreenType;
                float _ScreenTilling;
                float _ScreenScale;
                float _BlendMode;
                float _SurfaceType;
                float4 _TintColor;
                float4 _RowsColumns;
                float4 _ScaleOffset;
                float4 _ScreenEffectColor;
                float4 _MainTex_ST;
                float4 _MainTex_TexelSize;
            CBUFFER_END

            TEXTURE2D(_MainTex);          SAMPLER(sampler_MainTex);

            // ITU-R BT.709 luminance weights (blob Fragment_b5 line 219:
            //   dot(rgb, float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625)))
            static const float3 LUMA709 = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625);

            // sign(x) re-spelled from the decompiled uint-bit trick
            //   int((0u - (0<x?0xFFFFFFFFu:0)) + (x<0?0xFFFFFFFFu:0))  (blob Fragment_b5 lines 129-130,226-227)
            float SignOf(float x)
            {
                return (x > 0.0) ? 1.0 : ((x < 0.0) ? -1.0 : 0.0);
            }

            // Signed fractional part used by the dot-grid cell coordinate (blob Fragment_b5 lines 136-140):
            //   _360 = frac(abs(v)); result = (v >= -v) ? _360 : -_360
            float SignedFrac(float v)
            {
                float f = frac(abs(v));
                return (v >= -v) ? f : -f;
            }
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }

            Blend [_SrcBlend] [_DstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]
            Stencil {
                Ref [_StencilRef]
                ReadMask [_StencilReadMask]
                WriteMask [_StencilWriteMask]
                Comp [_StencilComp]
                Pass [_StencilOp]
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_fog

            struct Attributes {
                float3 positionOS : POSITION;
                float4 texcoord0  : TEXCOORD0;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
                float3 positionWS : TEXCOORD1;
                float  fogFactor  : TEXCOORD2;
            };

            Varyings vert(Attributes v)
            {
                Varyings o = (Varyings)0;
                // World/clip position — blob Vertex_b4 lines 325-347 reconstruct posWS via
                // _unity_ObjectToWorld (camera-relative) then mul by VP; URP does this in one call.
                VertexPositionInputs vpi = GetVertexPositionInputs(v.positionOS);
                o.positionCS = vpi.positionCS;
                o.positionWS = vpi.positionWS;
                // UV passed through untransformed (blob Vertex_b4 lines 359-360: TEXCOORD_2.xy = TEXCOORD.xy);
                // the _MainTex_ST rotate/scroll path (TEXCOORD_2.zw) is unused by the base fragment.
                o.uv = v.texcoord0.xy;
                o.fogFactor = ComputeFogFactor(vpi.positionCS.z);
                return o;
            }

            float4 frag(Varyings input) : SV_Target
            {
                float2 uv = input.uv;

                // ============================================================
                // Sprite-sheet frame addressing — blob Fragment_b5 lines 117-124
                // ============================================================
                float invCols = 1.0 / _RowsColumns.y;                 // _174 (blob line 117)
                float invRows = 1.0 / _RowsColumns.x;                 // _176 (blob line 118)
                // Clamp frame to [0, rows*cols-1], then split into column band (blob line 119)
                float frameIdx = trunc(min(mad(_RowsColumns.x, _RowsColumns.y, -1.0),
                                           max(floor(_Frame - 1.0), 0.0))) / _RowsColumns.y; // _197
                // Column UV origin (blob line 121): _208 = invCols * (signedFrac(_197) * cols)
                // where signedFrac(_197) == ((_197 >= -_197) ? frac(abs(_197)) : -frac(abs(_197))) == _201 path
                float colOrigin = invCols * (SignedFrac(frameIdx) * _RowsColumns.y);         // _208
                // Row UV origin (blob line 122): _212 = mad(-(floor(_197)+1), invRows, 1)
                float rowOrigin = mad(-(floor(frameIdx) + 1.0), invRows, 1.0);               // _212

                // Per-cell UV with _ScaleOffset scale/offset and cell-edge texel clamp (blob line 123)
                float cellU = mad(((uv.x - 0.5) / max(0.001, _ScaleOffset.x)) + 0.5, invCols, colOrigin);
                cellU = mad(-_ScaleOffset.z, invCols, cellU);
                cellU = min((invCols - _MainTex_TexelSize.x) + colOrigin,
                            max(cellU, colOrigin + _MainTex_TexelSize.x));
                float cellV = mad(((uv.y - 0.5) / max(0.001, _ScaleOffset.y)) + 0.5, invRows, rowOrigin);
                cellV = mad(-_ScaleOffset.w, invRows, cellV);
                cellV = min((invRows - _MainTex_TexelSize.y) + rowOrigin,
                            max(cellV, rowOrigin + _MainTex_TexelSize.y));

                float4 tex = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, float2(cellU, cellV)); // _270
                float texAlpha = tex.w;                                                          // _276 (blob line 124)

                // ============================================================
                // World-space camera distance — blob Fragment_b5 line 125
                //   _280 = length(camPos - posWS)  (decompiled as length of the camera-relative offset)
                // ============================================================
                float camDist = distance(_WorldSpaceCameraPos.xyz, input.positionWS);            // _280

                // ============================================================
                // Distance-adaptive tiling — blob Fragment_b5 lines 126-132
                //   _316 = min(_ScreenTilling, 15) ; _317 = min(_ScreenTilling, 10)
                //   (re-spelled from: saturate(sign(till-15))*(15-till)+till, etc.)
                //   _333 = lerp(_317, lerp(_316, till, saturate(3-dist)), saturate(6-dist))
                // ============================================================
                float till15 = mad(saturate(SignOf(_ScreenTilling - 15.0)), 15.0 - _ScreenTilling, _ScreenTilling); // _316
                float till10 = mad(saturate(SignOf(_ScreenTilling - 10.0)), 10.0 - _ScreenTilling, _ScreenTilling); // _317
                float negDist = -camDist;                                                          // _318
                float tiling = mad(saturate(negDist + 6.0),
                                   (-till10) + mad(saturate(negDist + 3.0), (-till15) + _ScreenTilling, till15),
                                   till10);                                                         // _333

                // Distance mask-scale shrink — blob Fragment_b5 line 133
                //   _346 = _ScreenScale - 0.2*_ScreenScale*saturate((dist-6)*0.25)
                float maskScale = mad(saturate((camDist - 6.0) * 0.25) * _ScreenScale,
                                      -0.199999988079071044921875, _ScreenScale);                  // _346

                // ============================================================
                // CROSSHAIR / dot-grid mask — blob Fragment_b5 lines 134-142
                // ============================================================
                float gx = tiling * uv.x;                                                          // _352
                float gy = tiling * uv.y;                                                          // _353
                // Centered cell coordinate in [-1,1]: mad(signedFrac(g), 2, -1)
                float cellX = mad(SignedFrac(gx), 2.0, -1.0);                                      // inside _371
                float cellY = mad(SignedFrac(gy), 2.0, -1.0);                                      // inside _372
                float negScale = -maskScale;                                                       // _368
                float dx = negScale + abs(cellX);                                                  // _371
                float dy = negScale + abs(cellY);                                                  // _372
                float box = saturate(dy) * saturate(dx);                                           // _375
                // Round dot vs square corner blend (blob line 142):
                //   _390 = 1 - ( saturate(scale^2 - box)*ceil(box) / max(scale^2,0.001)
                //               + mad(-ceil(_371), ceil(_372), 1) )
                float crosshairMask = 1.0 -
                    ((saturate(mad(maskScale, maskScale, -box)) * ceil(box)) / max(maskScale * maskScale, 0.001)
                     + mad(-ceil(dx), ceil(dy), 1.0));                                             // _390

                // ============================================================
                // HORSCAN / horizontal scanline mask — blob Fragment_b5 lines 143-144
                //   _396 = (-_346 + abs(frac(_353)-0.5)) + 0.5
                //   scan = saturate(2*_396) / max(saturate(2-2*_346), 0.001)
                // ============================================================
                float scanBand = (negScale + abs(frac(gy) - 0.5)) + 0.5;                          // _396
                float scanMask = saturate(scanBand + scanBand)
                               / max(saturate(mad(-maskScale, 2.0, 2.0)), 0.001);

                // Mask select + strength (blob line 144):
                //   raw = lerp(crosshairMask, scanMask, _ScreenType)
                //   _415 = lerp(1, raw, _ScreenEffectColor.a)
                float maskRaw = mad(_ScreenType, scanMask - crosshairMask, crosshairMask);
                float screenMask = mad(_ScreenEffectColor.w, maskRaw - 1.0, 1.0);                 // _415

                // ============================================================
                // Composite emote color — blob Fragment_b5 lines 216-218 (fog terms dropped)
                //   colorRGB = texAlpha * lerp(_ScreenEffectColor.rgb, tex.rgb, screenMask) * _TintColor.rgb
                // ============================================================
                float3 maskedColor = mad(screenMask.xxx, tex.xyz - _ScreenEffectColor.xyz, _ScreenEffectColor.xyz);
                float3 color = (texAlpha * maskedColor) * _TintColor.xyz;

                // ============================================================
                // Post-exposure desaturate + scale — blob Fragment_b5 lines 219-223
                //   _VFXParams1.w = saturation (0=full desat toward luma, 1=identity)
                //   _VFXParams1.xyz = exposure scale (post-exposure)
                // Sandbox: no auto-exposure pipeline → _IgnorePostExposure gates desat/scale.
                // When _IgnorePostExposure=1 → saturation=1, scale=1 (color unchanged).
                // ============================================================
                float luma = dot(color, LUMA709);                                                 // _1099
                float saturation = _IgnorePostExposure;        // _VFXParams1.w analogue (1 = keep saturated)
                color = mad(saturation.xxx, color - luma.xxx, luma.xxx);                          // SV_Target.xyz pre-scale

                // ============================================================
                // Output alpha — blob Fragment_b5 line 228 (SV_Target.w = _276)
                // Opaque writes texAlpha; transparent surface keeps the same (premultiplied path).
                // ============================================================
                float outAlpha = (_SurfaceType == 1.0) ? texAlpha : 1.0;

                // URP fog (substitutes the dropped HGRP atmosphere/exp/volumetric fog blend)
                color = MixFog(color, input.fogFactor);

                return float4(color, outAlpha);
            }
            ENDHLSL
        }

        Pass {
            Name "DepthOnly"
            Tags { "LightMode"="DepthOnly" }

            ZWrite On
            ColorMask 0
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            // DepthOnly base blobs: Vertex_b16 (identical position math to ForwardOnly, fog-free),
            // Fragment_b17 is an EMPTY frag_main() — depth-only, no color work.
            struct Attributes {
                float3 positionOS : POSITION;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
            };

            Varyings vert(Attributes v)
            {
                Varyings o;
                o.positionCS = GetVertexPositionInputs(v.positionOS).positionCS; // blob Vertex_b16 lines 325-347
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                return 0; // blob Fragment_b17: empty frag_main()
            }
            ENDHLSL
        }
    }
}
