// HGRP SkyDomeStarRT — additive sky-dome star/atmosphere compositing pass (unlit, single pass).
// Composites two render-target textures (planet stars + atmosphere) onto a camera-relative sky dome,
// applies a per-channel tint + saturation adjustment, and blends additively (Blend One One).
// Merged from: skydomestarrt.shader (single inlined variant — no multi_compile_local keywords).
//   Vertex  = inlined Blob 1 (skydomestarrt.shader lines 64-82).
//   Fragment = inlined Blob 2 (skydomestarrt.shader lines 132-145).
// Keywords: (none — this shader has no shader_feature variants).
// Kept: camera-relative sky-dome projection (no-translation VP), far-plane clamp (z=0 reverse-Z),
//   additive composite of _PlanetRTTex (clamp) + _AtmosphereRTTex (repeat), Rec.709 luminance,
//   saturation lerp + per-channel tint, additive RGB+A output, mip-bias sampling.
// Removed: TAA jitter (_TaaJitterStrength — pixel-neutral with TAA off; dropped per STYLE_BIBLE §2),
//   _NonJitteredViewNoTransProjMatrix global (replaced by camera-relative pos + UNITY_MATRIX_VP),
//   _WorldSpaceCameraPos_Internal global (→ _WorldSpaceCameraPos), SPIRV-Cross I/O statics.
//
// NOTE: _VFXParams1 is an HGRP global cbuffer field (type_ShaderVariablesGlobal c186) with no URP
//   equivalent — re-exposed as the material Vector _ColorAdjust (.xyz = per-channel tint/intensity,
//   .w = saturation amount). Likewise _GlobalMipBias (HGRP global c108) → material float _MipBias.
//   Defaults (tint=1, saturation=1, bias=0) reproduce the identity composite exactly.
// _PlanetRTTex sampled with clamp (sampler_LinearClamp); _AtmosphereRTTex sampled with repeat
//   (sampler_LinearRepeat) — both at the SAME ST-transformed planet UV (blob lines 80-81,134-135).

Shader "HGRP/SkyDomeStarRT_Fix"
{
    Properties
    {
        [Header(Render Targets)]
        _PlanetRTTex     ("Planet RT (stars)", 2D) = "black" {}
        _AtmosphereRTTex ("Atmosphere RT",     2D) = "black" {}

        [Header(Color Adjustment)]
        // HGRP _VFXParams1: .xyz = per-channel tint/intensity, .w = saturation (0=greyscale, 1=full).
        _ColorAdjust ("Color Adjust (RGB=tint, A=saturation)", Vector) = (1, 1, 1, 1)
        // HGRP _GlobalMipBias: LOD bias applied to both RT samples.
        _MipBias     ("Global Mip Bias", Float) = 0
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType"     = "Transparent"
            "Queue"          = "Transparent"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _PlanetRTTex_ST;       // blob c0 _Globals_PlanetRTTex_ST (lines 80-81)
                float4 _AtmosphereRTTex_ST;   // declared for batching compat (unused — frag reuses planet UV)
                float4 _ColorAdjust;          // re-exposed HGRP _VFXParams1 (c186)
                float  _MipBias;              // re-exposed HGRP _GlobalMipBias (c108)
            CBUFFER_END

            TEXTURE2D(_PlanetRTTex);      SAMPLER(sampler_LinearClamp);   // blob T0 + sampler_LinearClamp (s0)
            TEXTURE2D(_AtmosphereRTTex);  SAMPLER(sampler_LinearRepeat);  // blob T1 + sampler_LinearRepeat (s1)

            // Rec.709 luminance weights — blob line 139: dot(rgb, float3(0.212672904, 0.715152204, 0.072175004)).
            static const float3 LUM = float3(0.21267290413379669189453125,
                                             0.715152204036712646484375,
                                             0.072175003588199615478515625);
        ENDHLSL

        Pass
        {
            Name "SkyDomeStarRT"
            Tags { "LightMode" = "SRPDefaultUnlit" }

            // blob skeleton lines 12-14: Blend One One, One One / ZClip On / ZWrite Off.
            //   Source declares NO ZTest and NO Cull → ShaderLab implicit defaults apply
            //   (ZTest LEqual, Cull Back). Reproduced explicitly here for 1:1 effective state;
            //   Cull Off would double-composite a closed dome's back+front faces under additive
            //   Blend One One (over-bright) — NOT what the source does.
            Blend One One, One One
            ZClip On
            ZWrite Off
            ZTest LEqual
            Cull Back

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes
            {
                float4 positionOS : POSITION;   // blob POSITION (xyz used; w via ObjectToWorld[3])
                float2 uv         : TEXCOORD0;   // blob TEXCOORD
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD1;   // blob TEXCOORD_1 (ST-transformed planet uv)
                float3 positionWS : TEXCOORD2;   // blob TEXCOORD_1_1 (world pos; carried as in source)
            };

            // ==========================================================================================
            // Vertex — inlined Blob 1 (skydomestarrt.shader lines 64-82). 1:1.
            //   Sky dome rendered camera-relative through the no-translation view-proj, forced to the
            //   far plane (clip.z = 0 under reverse-Z). TAA jitter removed (STYLE_BIBLE §2).
            // ==========================================================================================
            Varyings vert(Attributes v)
            {
                Varyings o;

                // World position: mul(ObjectToWorld, float4(POSITION.xyz, 1)) — blob lines 66-68.
                float3 positionWS = TransformObjectToWorld(v.positionOS.xyz);
                o.positionWS = positionWS;  // blob TEXCOORD_1_1 (lines 72-74)

                // Camera-relative position: worldPos - cameraPos — blob lines 69-71
                //   (_89/_90/_91 = _76/_77/_78 + ((-0.0) - _WorldSpaceCameraPos_Internal.xyz)).
                float3 positionRWS = positionWS - _WorldSpaceCameraPos;

                // Clip = mul(VP_noTranslation, positionRWS) — blob lines 75-78.
                //   Source uses _NonJitteredViewNoTransProjMatrix (view stripped of translation, so feeding
                //   the camera-relative position reproduces an infinitely-far sky dome). UNITY_MATRIX_VP fed
                //   the camera-relative position is the URP-equivalent no-translation transform.
                float4 positionCS = mul(UNITY_MATRIX_VP, float4(positionRWS, 1.0));

                // TAA jitter removed: source subtracted _TaaJitterStrength.z/.w * clip.w from x/y (blob
                //   lines 76-77). With TAA off these terms are zero and pixel-neutral — dropped.

                // Far-plane clamp — blob line 79: gl_Position.z = 0 (reverse-Z far plane), w preserved (line 78).
                positionCS.z = 0.0;
                o.positionCS = positionCS;

                // Planet UV: TEXCOORD * _PlanetRTTex_ST.xy + _PlanetRTTex_ST.zw — blob lines 80-81.
                o.uv = mad(v.uv, _PlanetRTTex_ST.xy, _PlanetRTTex_ST.zw);

                return o;
            }

            // ==========================================================================================
            // Fragment — inlined Blob 2 (skydomestarrt.shader lines 132-145). 1:1.
            //   Sum the two RT samples, compute Rec.709 luminance, lerp saturation about luminance,
            //   tint per channel, output additively.
            // ==========================================================================================
            half4 frag(Varyings input) : SV_Target
            {
                // Both RT samples at the planet UV with global mip bias — blob lines 134-135.
                //   _49 = _PlanetRTTex.SampleBias(LinearClamp,  uv, _GlobalMipBias)
                //   _63 = _AtmosphereRTTex.SampleBias(LinearRepeat, uv, _GlobalMipBias)
                float4 planet = SAMPLE_TEXTURE2D_BIAS(_PlanetRTTex,     sampler_LinearClamp,  input.uv, _MipBias);
                float4 atmo   = SAMPLE_TEXTURE2D_BIAS(_AtmosphereRTTex, sampler_LinearRepeat, input.uv, _MipBias);

                // Additive RGB sum — blob lines 136-138 (_69/_70/_71).
                float3 sumRGB = planet.rgb + atmo.rgb;

                // Rec.709 luminance — blob line 139 (_73).
                float luma = dot(sumRGB, LUM);

                // Saturation lerp about luminance, then per-channel tint — blob lines 142-144:
                //   SV_Target.xyz = mad(_VFXParams1.w, sumRGB + (-luma), luma) * _VFXParams1.xyz
                //   = lerp(luma, sumRGB, _ColorAdjust.w) * _ColorAdjust.xyz.   (_79 = -_73)
                float3 rgb = mad(_ColorAdjust.w, sumRGB - luma, luma) * _ColorAdjust.xyz;

                // Additive alpha — blob line 141: SV_Target.w = _49.w + _63.w.
                float alpha = planet.a + atmo.a;

                return half4(rgb, alpha);
            }
            ENDHLSL
        }
    }
}
