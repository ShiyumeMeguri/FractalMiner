// HGRP FogSimple — world-space soft fog card (single ForwardOnly transparent pass).
// Merged from: fogsimple.shader Sub0/Pass0 blobs (vertex catch-all b28, fragment catch-all b29,
//   + _USE_LIGHTING b37, _USE_SOFTBLEND b33, _USE_FOG b31).
// Keywords: _USE_LIGHTING, _USE_SOFTBLEND, _USE_FOG  (HG_COMPOSE_VOLUMETRIC + SRP_INSTANCING_ON dropped).
// Kept: octahedral normal/tangent unpack, wind-disturbed mask sampling, fresnel rim, distance/near/top fades,
//   view-relative world reconstruction from depth, optional directional lighting, optional soft depth blend,
//   optional HG exponential+atmosphere+volumetric fog re-color, _VFXParams1 desaturate/tint post adjustment.
// Removed: TAA jitter (_TaaJitterStrength), GPU instancing (SRP_INSTANCING_ON), HG_COMPOSE_VOLUMETRIC compose
//   path, _GlobalMipBias texture LOD bias, _NonJitteredViewNoTransProjMatrix (replaced by URP UNITY_MATRIX_VP
//   on reconstructed world pos), HGRP global cbuffer (re-exposed needed fields as material Vectors).
//
// NOTE: _IndirectColor is dual-purpose in the source — a per-instance WORLD-POSITION offset in the vertex blob
//   (b28 lines 213-215) AND the dark/ambient color in the _USE_LIGHTING fragment (b37 lines 137-139). Both kept.
// NOTE: scene depth reconstruction uses the opaque depth buffer (_CameraDepthTexture); soft-blend + HG-fog
//   sample scene depth at the fragment's screen UV exactly as the source sampled _CameraDepthTexture (T0).
// NOTE: HG fog globals (_AtmosphereFogParams*/_ExponentialFogParams*/_VolumetricFogParams*) have no URP
//   equivalent; re-exposed as material Vectors so the _USE_FOG branch stays 1:1. With them at 0 the branch is inert.
// NOTE: world reconstruction = mul(UNITY_MATRIX_I_VP, clip) (URP's ComputeWorldSpacePosition form); the blob's
//   column-major hand-expansion must NOT be index-transcribed onto URP's row-major matrix (that transposes it).
// NOTE: each variant maps a SINGLE source keyword. The combined-keyword blobs (FOG+SOFTBLEND b35, LIGHTING+FOG b39,
//   etc.) were not decoded; with two keywords on at once the #ifdef blocks stack (FOG re-derives alpha without the
//   soft term, and composites whatever `col` is current) which can differ from the dedicated combined blob.

Shader "HGRP/FogSimple_Fix"
{
    Properties
    {
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 0
        [HDR] _BaseColor ("Base Color", Color) = (1, 1, 1, 1)
        _BaseAlphaIntensity ("Alpha Intensity", Range(0, 10)) = 1
        [HideInInspector] _MainTex ("Base Shape Mask", 2D) = "white" {}
        _NoiseTex ("Disturb Noise", 2D) = "white" {}
        _FogNoiseIntensity ("Noise Influence", Range(0, 1)) = 0

        // Wind
        [Toggle] _UseWind ("Use Wind", Float) = 0
        _WindNoiseIntensity ("Wind Noise Influence", Range(0, 1)) = 1
        _WindNoiseContrast ("Wind Noise Contrast", Range(-5, 5)) = 0
        _WindScale ("Disturb Scale", Range(0, 1)) = 1
        [ToggleUI] _UseSeparateScale ("Use Separate Axis Scale", Float) = 0
        _WindScaleX ("Disturb Scale X", Range(0, 1)) = 1
        _WindScaleY ("Disturb Scale Y", Range(0, 1)) = 1
        _WindDirX ("Disturb Dir X", Range(-1, 1)) = 1
        _WindDirY ("Disturb Dir Y", Range(-1, 1)) = 1
        _WindSpeed ("Disturb Speed", Range(0, 1)) = 0

        // Lighting
        [Toggle(_USE_LIGHTING)] _UseLighting ("Use Lighting", Float) = 1
        [ToggleUI] _UseNormalTex ("Use Normal Map", Float) = 0
        _NormalTex ("Normal Map", 2D) = "black" {}
        _NormalScale ("Normal Scale", Range(0, 10)) = 0
        [ToggleUI] _TwoSidedNormal ("Flip Backface Normal", Float) = 0
        [HDR] _IndirectColor ("Indirect/Dark Color (also vertex world offset)", Color) = (0, 0, 0, 1)
        _LightFactor ("Lighting Influence", Range(0, 1)) = 1

        // Fresnel
        [Toggle] _UseFresnel ("Use Fresnel", Float) = 0
        [ToggleUI] _FlipFresnel ("Flip Fresnel", Float) = 1
        _FresnelIntensity ("Fresnel Intensity", Range(0, 1)) = 0
        _FresnelContract ("Fresnel Contrast", Range(0.01, 10)) = 1

        // Distance fade
        _DistanceFadeStart ("Disappear Distance 1", Range(0.001, 3000)) = 0.001
        _DistanceFadeEnd ("Appear Distance 1", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Appear Distance 2", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceStart ("Disappear Distance 2", Range(0.001, 3000)) = 0.001

        // Top fade
        _TopFadeContract ("Top Fade Contrast", Range(0, 10)) = 0
        _TopFadeOffset ("Top Fade Offset", Range(-1, 1)) = 1

        // Soft blend
        [Toggle(_USE_SOFTBLEND)] _UseSoftBlend ("Use Soft Blend", Float) = 0
        _SoftDistance ("Soft Blend Range", Range(0, 100)) = 1

        // Fog influence
        [Toggle(_USE_FOG)] _UseFog ("Affected by Fog", Float) = 0
        _FogIntensity ("Near Fog Intensity", Range(0, 1)) = 1
        _FogIntensityFadeOutDistance ("Fog Fade-out Distance", Range(10, 10000)) = 2000

        // HG VFX post adjustment (global in source; re-exposed). .xyz = tint, .w = desaturation amount.
        _VFXParams1 ("VFX Color Adjust (xyz tint, w desat)", Vector) = (1, 1, 1, 0)

        // HG fog globals re-exposed so _USE_FOG stays 1:1 (no URP equivalent). Default 0 => fog branch inert.
        _AtmosphereFogParams0 ("Atmosphere Fog 0", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams1 ("Atmosphere Fog 1", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams2 ("Atmosphere Fog 2", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams3 ("Atmosphere Fog 3", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams4 ("Atmosphere Fog 4", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams5 ("Atmosphere Fog 5", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams0 ("Exponential Fog 0", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams1 ("Exponential Fog 1", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams2 ("Exponential Fog 2", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams3 ("Exponential Fog 3", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams4 ("Exponential Fog 4", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams5 ("Exponential Fog 5", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams0 ("Volumetric Fog 0", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams1 ("Volumetric Fog 1", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams2 ("Volumetric Fog 2", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams3 ("Volumetric Fog 3", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams4 ("Volumetric Fog 4", Vector) = (0, 0, 0, 0)

        // Render state plumbing (driven by a material editor / OnValidate, not the shader).
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 1
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 1
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
        [HideInInspector] _ProcedureAlpha ("Procedure Alpha", Float) = 1
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
            "PreviewType"="Plane"
        }
        LOD 300

        Pass
        {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend]
            ZWrite Off
            Cull [_CullMode]

            HLSLPROGRAM
            // 4.5: the octahedral decode (asuint/bit-shifts, base vertex path) + froxel PCG hash + Texture3D LOD
            // sampling need SM4.5 integer/3D-tex ops; source was target 5.0. (mirrors HGRP_Lit_Fix.shader)
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag

            #pragma shader_feature_local _USE_LIGHTING
            #pragma shader_feature_local _USE_SOFTBLEND
            #pragma shader_feature_local _USE_FOG

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _MainTex_ST;
                float4 _NoiseTex_ST;
                float4 _BaseColor;
                float4 _IndirectColor;
                float  _BlendMode;
                float  _BaseAlphaIntensity;
                float  _FogNoiseIntensity;
                float  _UseWind;
                float  _WindNoiseIntensity;
                float  _WindNoiseContrast;
                float  _WindSpeed;
                float  _WindScale;
                float  _UseSeparateScale;
                float  _WindScaleX;
                float  _WindScaleY;
                float  _WindDirX;
                float  _WindDirY;
                float  _UseNormalTex;
                float  _NormalScale;
                float  _TwoSidedNormal;
                float  _LightFactor;
                float  _UseFresnel;
                float  _FresnelIntensity;
                float  _FresnelContract;
                float  _FlipFresnel;
                float  _DistanceFadeStart;
                float  _DistanceFadeEnd;
                float  _NearCameraFadeDistanceStart;
                float  _NearCameraFadeDistanceEnd;
                float  _TopFadeContract;
                float  _TopFadeOffset;
                float  _SoftDistance;
                float  _FogIntensity;
                float  _FogIntensityFadeOutDistance;
                float4 _VFXParams1;
                // HG fog globals (re-exposed; no URP equivalent)
                float4 _AtmosphereFogParams0;
                float4 _AtmosphereFogParams1;
                float4 _AtmosphereFogParams2;
                float4 _AtmosphereFogParams3;
                float4 _AtmosphereFogParams4;
                float4 _AtmosphereFogParams5;
                float4 _ExponentialFogParams0;
                float4 _ExponentialFogParams1;
                float4 _ExponentialFogParams2;
                float4 _ExponentialFogParams3;
                float4 _ExponentialFogParams4;
                float4 _ExponentialFogParams5;
                float4 _VolumetricFogParams0;
                float4 _VolumetricFogParams1;
                float4 _VolumetricFogParams2;
                float4 _VolumetricFogParams3;
                float4 _VolumetricFogParams4;
            CBUFFER_END

            TEXTURE2D(_MainTex);   SAMPLER(sampler_MainTex);    // base-shape mask  (b29 T0, linear clamp)
            TEXTURE2D(_NoiseTex);  SAMPLER(sampler_NoiseTex);   // disturb noise    (b29 T1, linear repeat)
            TEXTURE2D(_NormalTex); SAMPLER(sampler_NormalTex);  // normal map       (b37 T2, linear mirror)
            // HG volumetric froxel texture (b31 T0, Texture3D) — no URP source; sampled only in dead _USE_FOG path.
            TEXTURE3D(_VolumetricLightingTexture); SAMPLER(sampler_VolumetricLightingTexture);

            static const float3 LUMA = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625);
            static const float  OCT_DECODE = 0.001956947147846221923828125; // 2/1022 (10-bit octahedral)
            static const float  FLT_MIN_POS = 1.1754943508222875079687365372222e-38;
            static const float  VIEW_EPS    = 9.9999999392252902907785028219223e-09; // 1e-8
            static const float  NRM_Z_FLOOR = 1.000000016862383526387164645044e-16;
            static const float  POW_FLOOR   = 0.00048828125; // 1/2048
            static const float  LOG2_E      = 1.44269502162933349609375;
            static const float  BLUE_UNPACK = 3.05180437862873077392578125e-05; // 1/32766 (16-bit)

            // -------- octahedral-packed normal/tangent decode (b28 lines 122-191) --------
            // NORMAL.x carries a bit-packed octahedral normal+tangent when bit30 is set; else NORMAL/TANGENT are raw.
            struct UnpackedTBN { float3 normal; float3 tangent; float tangentSign; };

            UnpackedTBN DecodeOctaTBN(float3 rawNormal, float4 rawTangent)
            {
                UnpackedTBN o;
                uint packed = asuint(rawNormal.x);
                bool isPacked = (packed & 1073741824u) != 0u; // bit30

                if (isPacked)
                {
                    // --- normal from 10+10 bits (b28 lines 133-145) ---
                    float n0 = float(packed & 1023u);
                    float n1 = float((packed >> 10u) & 1023u);
                    float n2 = float((packed >> 20u) & 1023u);
                    n0 = (n0 >= 512.0) ? (n0 - 1024.0) : n0;
                    n1 = (n1 >= 512.0) ? (n1 - 1024.0) : n1;
                    n2 = (n2 >= 512.0) ? (n2 - 1024.0) : n2;
                    float nx = n0 * OCT_DECODE;
                    float ny = n1 * OCT_DECODE;
                    float nz = ((-abs(ny)) + ((-abs(nx)) + 1.0)); // 1 - |nx| - |ny|  (b28 line 145)
                    bool below = nz < 0.0;
                    // octahedral wrap (b28 lines 147-148)
                    float wx = below ? (((nx >= 0.0) ? 1.0 : -1.0) * ((-abs(ny)) + 1.0)) : nx;
                    float wy = below ? (((ny >= 0.0) ? 1.0 : -1.0) * ((-abs(nx)) + 1.0)) : ny;
                    float invLenN = rsqrt(dot(float3(wx, wy, nz), float3(wx, wy, nz)));
                    float Nx = invLenN * wx;
                    float Ny = invLenN * wy;
                    float Nz = invLenN * nz;

                    // --- build an arbitrary tangent basis from N (b28 lines 153-163) ---
                    float gx = mad(wy, invLenN, -Nz);
                    float gy = mad(nz, invLenN, -Nx);
                    float gz = mad(wx, invLenN, -Ny);
                    float gd = -dot(float3(gx, gy, gz), float3(Nx, Ny, Nz));
                    float tx = gd + gx;
                    float ty = gd + gy;
                    float tz = gd + gz;
                    float invLenT = rsqrt(dot(float3(tx, ty, tz), float3(tx, ty, tz)));
                    float Tx = invLenT * tx;
                    float Ty = invLenT * ty;
                    float Tz = invLenT * tz;

                    // --- decode the in-plane tangent angle from n2 (b28 lines 164-170) ---
                    float aSign = (n2 < 0.0) ? -1.0 : 1.0;
                    float ca = ((-dot((n2 * OCT_DECODE).xx, aSign.xx)) + 1.0);
                    float sa = (((-abs(ca)) + 1.0)) * aSign;
                    float invLenA = rsqrt(dot(float2(ca, sa), float2(ca, sa)));
                    float cosA = invLenA * ca;
                    float sinA = invLenA * sa;

                    // bitangent = N x T (b28 lines 170-173)
                    float bx = mad(Ny, Tz, -(Nz * Ty));
                    float by = mad(Nz, Tx, -(Nx * Tz));
                    float bz = mad(Nx, Ty, -(Ny * Tx));
                    float invLenB = rsqrt(dot(float3(bx, by, bz), float3(bx, by, bz)));

                    o.normal      = float3(Nx, Ny, Nz);
                    o.tangent     = float3(mad(cosA, Tx, sinA * (invLenB * bx)),
                                           mad(cosA, Ty, sinA * (invLenB * by)),
                                           mad(cosA, Tz, sinA * (invLenB * bz)));
                    o.tangentSign = mad(float(packed >> 31u), 2.0, -1.0); // bit31 -> +/-1 (b28 line 179)
                }
                else
                {
                    o.normal      = rawNormal;
                    // raw path: the decoded-tangent temps are 0, but the outer per-component select
                    // (b28:192-194 `_42 ? _215 : TANGENT.x`) recovers the RAW input tangent xyz, which
                    // is what then gets transformed by ObjectToWorld. Not zero.
                    o.tangent     = rawTangent.xyz;        // (b28 lines 192-194 select -> TANGENT.xyz)
                    o.tangentSign = rawTangent.w;          // raw path keeps TANGENT.w (b28 line 227 select)
                }
                return o;
            }

            // expm1-style helper used by the HG exponential-height fog (b31 lines 182/643/877):
            // (1 - exp2(-x))/x with a series fallback near 0. Source spelled inline.
            float HgExpM1OverX(float x)
            {
                return (5.9604644775390625e-08 < abs(x))
                       ? ((((-0.0) - exp2((-0.0) - x)) + 1.0) / x)
                       : mad((-0.0) - x, 0.2402265071868896484375, 0.693147182464599609375);
            }

            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
                float3 normalWS   : TEXCOORD1; // packed octa normal in WS-equivalent space (b28 TEXCOORD_1_1)
                float4 tangentWS  : TEXCOORD2; // .w = tangentSign * sign(_WindScale)  (b28 TEXCOORD_2)
            };

            // ============================================================
            // Vertex — b28 (catch-all). World position = posOS oriented by ObjectToWorld basis
            // then offset by (_IndirectColor.xyz - cameraPos); source then applied a no-translation VP.
            // We rebuild the same world position and use URP UNITY_MATRIX_VP (translation handled by camera-relative offset).
            // ============================================================
            Varyings vert(Attributes v)
            {
                Varyings o;

                UnpackedTBN tbn = DecodeOctaTBN(v.normalOS, v.tangentOS);

                // The blob aliases the ObjectToWorld basis COLUMNS as the (_MainTex_ST/_NoiseTex_ST/_BaseColor)
                // material registers (a decompiler register-overlap artifact): _MainTex_ST=col0, _NoiseTex_ST=col1,
                // _BaseColor=col2. POSITION & TANGENT transform by plain M (b28:210-215); NORMAL transforms by the
                // INVERSE-TRANSPOSE, which the blob spells as M . diag(1/|row_j|^2) . N (b28:204-209). In URP we use
                // the real unity_ObjectToWorld. (b28 lines 204-228)
                float3x3 o2w = (float3x3)unity_ObjectToWorld;

                // normal -> world: blob spells M . diag(1/|row_j|^2) . N (an inverse-transpose-style transform).
                // o2w[j] is row j of (float3x3)unity_ObjectToWorld; divide each input component by its row's len^2,
                // then mul(M, .). Reproduced bit-for-bit from the blob; equals plain mul(M,N) for rotation / uniform
                // / axis-aligned scale and diverges only for rotated + non-uniform scale. (b28 lines 204-209,219-222)
                float3 invRowLenSq = float3(1.0 / dot(o2w[0], o2w[0]),
                                            1.0 / dot(o2w[1], o2w[1]),
                                            1.0 / dot(o2w[2], o2w[2]));
                float3 nWS = mul(o2w, tbn.normal * invRowLenSq);
                o.normalWS = nWS * rsqrt(max(dot(nWS, nWS), FLT_MIN_POS));

                // tangent -> world (plain M, b28 lines 210-212,223-226)
                float3 tWS = mul(o2w, tbn.tangent);
                o.tangentWS.xyz = tWS * rsqrt(max(dot(tWS, tWS), FLT_MIN_POS));
                // .w = sign(_WindScale) * tangentSign  (b28 line 227)
                o.tangentWS.w = ((_WindScale >= 0.0) ? 1.0 : -1.0) * tbn.tangentSign;

                // world position: rotate posOS by basis, add per-instance offset (_IndirectColor.xyz)
                // then subtract camera pos (camera-relative). (b28 lines 213-215)
                float3 posWS = mul(o2w, v.positionOS) + _IndirectColor.xyz;
                o.positionCS = TransformWorldToHClip(posWS);

                o.uv = v.uv;
                return o;
            }

            // ============================================================
            // Fragment — base b29 + _USE_LIGHTING b37 + _USE_SOFTBLEND b33 + _USE_FOG b31.
            // ============================================================
            half4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                float faceSign = isFrontFace ? 1.0 : -1.0; // (b29 line 130)

                // ---- wind-disturbed mask sample (shared by all variants; b29 line 114, b37 line 136) ----
                float sepInv = 1.0 + ((-0.0) - _UseSeparateScale);   // 1 - _UseSeparateScale
                float windT  = _Time.y * _WindSpeed;
                float2 windUV = float2(
                    mad(input.uv.x * _WindScale, mad(_WindScaleX, _UseSeparateScale, sepInv), windT * ((-0.0) - _WindDirX)),
                    mad(input.uv.y * _WindScale, mad(_WindScaleY, _UseSeparateScale, sepInv), windT * _WindDirY));
                float windNoise = SAMPLE_TEXTURE2D(_NoiseTex, sampler_NoiseTex, windUV).x;
                // contrast remap -> clamp -> lerp by intensity -> gate by _UseWind  (b29 line 114)
                windNoise = clamp(mad(windNoise, mad(_WindNoiseContrast, 2.0, 1.0), (-0.0) - _WindNoiseContrast), 0.0, 1.0);
                float windFactor = mad(mad(windNoise, _WindNoiseIntensity, 1.0 + ((-0.0) - _WindNoiseIntensity)),
                                       _UseWind, 1.0 + ((-0.0) - _UseWind));

                // ---- base shape * noise -> per-channel mask color & alpha (b29 lines 115-118) ----
                float2 mainUV  = float2(mad(input.uv.x, _MainTex_ST.x, _MainTex_ST.z), mad(input.uv.y, _MainTex_ST.y, _MainTex_ST.w));
                float2 noiseUV = float2(mad(input.uv.x, _NoiseTex_ST.x, _NoiseTex_ST.z), mad(input.uv.y, _NoiseTex_ST.y, _NoiseTex_ST.w));
                float  baseMask  = SAMPLE_TEXTURE2D(_MainTex,  sampler_MainTex,  mainUV).x;
                float  noiseMask = SAMPLE_TEXTURE2D(_NoiseTex, sampler_NoiseTex, noiseUV).x;
                float  shapeAlpha = windFactor * (baseMask
                                  * mad(noiseMask, _FogNoiseIntensity, 1.0 + ((-0.0) - _FogNoiseIntensity))
                                  * _BaseColor.w);

                // base RGB (lit path overrides this with directional lighting)
                float3 col = windFactor * _BaseColor.xyz; // (b29 lines 116-118)

            #ifdef _USE_LIGHTING
                // ---- normal mapping (b37 lines 120-130) ----
                float twoSided = asfloat((0.0 < input.tangentWS.w) ? 0x3f800000u : 0xbf800000u); // sign(tangentSign)
                float4 nSample = SAMPLE_TEXTURE2D(_NormalTex, sampler_NormalTex, input.uv);
                float nmx = mad(nSample.x * nSample.w, 2.0, -1.0); // DXT5nm-ish (b37 line 122)
                float nmy = mad(nSample.y, 2.0, -1.0);
                float tnX = mad(_UseNormalTex, (nmx * _NormalScale) + (-0.0), 0.0);
                float tnY = mad(_UseNormalTex, (nmy * _NormalScale) + (-0.0), 0.0);
                float tnZ = mad(_UseNormalTex, max(sqrt(((-0.0) - min(dot(float2(nmx, nmy), float2(nmx, nmy)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16) + (-1.0), 1.0);
                // TBN apply: bitangent = tangentSign(.w) * cross(N,T)  (b37 lines 127-129)
                float3 N = input.normalWS;
                float3 T = input.tangentWS.xyz;
                float3 Bn = twoSided * cross(N, T);
                float3 nrm = float3(
                    mad(tnZ, N.x, mad(tnX, T.x, Bn.x * tnY)),
                    mad(tnZ, N.y, mad(tnX, T.y, Bn.y * tnY)),
                    mad(tnZ, N.z, mad(tnX, T.z, Bn.z * tnY)));
                nrm *= rsqrt(max(dot(nrm, nrm), FLT_MIN_POS)); // (b37 line 130)
                // two-sided flip then NdotL (b37 lines 131-133)
                float sideFlip = mad(faceSign, _TwoSidedNormal, 1.0 + ((-0.0) - _TwoSidedNormal));
                Light mainLight = GetMainLight();
                float3 L = mainLight.direction; // URP gives the to-light dir; source used -DirectionalLightDirection
                float ndl = max(dot(nrm * sideFlip, L), 0.0);
                float lightTerm = mad(ndl, _LightFactor, 1.0 + ((-0.0) - _LightFactor));
                // diffuse = lerp(_IndirectColor, _BaseColor*lightColor, lightTerm) * windFactor  (b37 lines 137-139)
                float3 lightCol = mainLight.color;
                col = float3(
                    mad(lightTerm, mad(_BaseColor.x, lightCol.x, (-0.0) - _IndirectColor.x), _IndirectColor.x),
                    mad(lightTerm, mad(_BaseColor.y, lightCol.y, (-0.0) - _IndirectColor.y), _IndirectColor.y),
                    mad(lightTerm, mad(_BaseColor.z, lightCol.z, (-0.0) - _IndirectColor.z), _IndirectColor.z)) * windFactor;
            #endif

                // ---- reconstruct world position of THIS fragment from depth (b29 lines 119-128) ----
                // NDC with Y already flipped (the blob bakes the flip into _235 = -(2*y/H-1), b29:121); we feed
                // this straight into mul(I_VP, clip) so we must NOT use URP's ComputeClipSpacePosition (it would
                // flip Y a second time under UNITY_UV_STARTS_AT_TOP).
                float2 ndc = float2(mad(input.positionCS.x / _ScaledScreenParams.x, 2.0, -1.0),
                                    (-0.0) - mad(input.positionCS.y / _ScaledScreenParams.y, 2.0, -1.0));
                bool isPersp = (0.0 == unity_OrthoParams.w); // source _207 = (0 == ortho.w): TRUE for perspective (b29:119)
                float fragZ = input.positionCS.z;
                // inverse-VP * clip -> world. Blob spells mul(IVP,clip) via column-major access (IVP[col].row);
                // URP's UNITY_MATRIX_I_VP is row-major, so the 1:1 equivalent is the direct mul, NOT a literal
                // index transcription (that would transpose the matrix). (b29:122-128; URP ComputeWorldSpacePosition)
                float4 clipP = float4(ndc.x, ndc.y, fragZ, 1.0);
                float4 worldH = mul(UNITY_MATRIX_I_VP, clipP);
                float3 worldP = worldH.xyz / worldH.w;

                // view direction toward camera (perspective) or fixed camera fwd (ortho) (b29 lines 126-128)
                float3 viewVec = isPersp
                    ? (((-0.0) - worldP) + _WorldSpaceCameraPos)
                    : UNITY_MATRIX_V[2].xyz; // camera forward (view Z row)
                float invLenV = rsqrt(dot(viewVec, viewVec));
                float3 viewDir = viewVec * invLenV;

                // fresnel rim from NdotV (front-face flipped normal) (b29 lines 130-133)
                float ndv = clamp(dot(viewDir, input.normalWS * faceSign), 0.0, 1.0);
                float invNdv = ((-0.0) - ndv) + 1.0;
                float fres = mad(_FresnelIntensity,
                                 exp2(log2(max(abs(mad(_FlipFresnel, ndv + ((-0.0) - invNdv), invNdv)), POW_FLOOR)) * _FresnelContract) + (-1.0),
                                 1.0);
                bool useFres = (0.0 != _UseFresnel);

                // apply fresnel to color (b29 lines 135-137)
                float3 colF = useFres ? (col * fres) : col;

                // view-space Z (camera distance along forward) for distance fades (b29 line 138)
                float viewZ = mad(UNITY_MATRIX_V[2].z, worldP.z, mad(UNITY_MATRIX_V[2].x, worldP.x, worldP.y * UNITY_MATRIX_V[2].y)) + UNITY_MATRIX_V[2].w;

                // top fade from world-Y relative to object origin scaled by object up-axis length (b29 line 139)
                float upLen = max(length(unity_ObjectToWorld._m01_m11_m21), FLT_MIN_POS);
                float topFade = clamp(mad((((-0.0) - worldP.y) + unity_ObjectToWorld._m13) / upLen, _TopFadeContract, _TopFadeOffset), 0.0, 1.0);
                // near + far distance fades multiply (b29 line 139)
                float nearFade = clamp((abs(viewZ) + ((-0.0) - _NearCameraFadeDistanceStart)) / (((-0.0) - _NearCameraFadeDistanceStart) + _NearCameraFadeDistanceEnd), 0.0, 1.0);
                float farFade  = clamp((abs(viewZ) + ((-0.0) - _DistanceFadeStart)) / (((-0.0) - _DistanceFadeStart) + _DistanceFadeEnd), 0.0, 1.0);
                float shapeAlphaF = useFres ? (shapeAlpha * fres) : shapeAlpha;
                float alpha = topFade * (nearFade * farFade * shapeAlphaF) * _BaseAlphaIntensity;

            #ifdef _USE_SOFTBLEND
                // soft depth blend against scene depth at this screen UV (b33 lines 126-151) ----
                // _CameraDepthTexture is URP's opaque depth = the HG T0 source. Blob sampled T0 at the fractional
                // center UV (b33:129) but reconstructed the NDC from the TRUNCATED pixel (float(uint(frag.xy)),
                // b33:148-149); that half-texel split is sub-pixel and immaterial, so we use the center UV for both.
                float2 screenUV = float2(input.positionCS.x / _ScaledScreenParams.x, input.positionCS.y / _ScaledScreenParams.y);
                float sceneRawZ = SampleSceneDepth(screenUV); // source sampled T0 (_CameraDepthTexture) at SampleLevel 0
                float2 ndcS = float2(mad(screenUV.x, 2.0, -1.0), (-0.0) - mad(screenUV.y, 2.0, -1.0));
                // direct mul(I_VP, clip) — same transpose caveat as the primary reconstruction. (b33:150-151)
                float4 sceneClip = float4(ndcS.x, ndcS.y, sceneRawZ, 1.0);
                float4 sceneH = mul(UNITY_MATRIX_I_VP, sceneClip);
                float3 sceneP = sceneH.xyz / sceneH.w;
                float sceneViewZ = mad(UNITY_MATRIX_V[2].z, sceneP.z, mad(UNITY_MATRIX_V[2].x, sceneP.x, sceneP.y * UNITY_MATRIX_V[2].y)) + UNITY_MATRIX_V[2].w;
                // softFactor = saturate((|sceneViewZ| - |viewZ|) / _SoftDistance)  (b33 line 151)
                float softFactor = clamp((((-0.0) - abs(viewZ)) + abs(sceneViewZ)) / _SoftDistance, 0.0, 1.0);
                alpha = topFade * (nearFade * farFade * shapeAlphaF) * softFactor * _BaseAlphaIntensity;
            #endif

            #ifdef _USE_FOG
                // ============================================================
                // HG fog re-color of the fog card (b31). Uses re-exposed HG fog globals; with them at 0 the
                // result collapses to passthrough. View ray / froxel build kept 1:1 from the blob.
                // ============================================================
                // normalized view ray & its view-space length (b31 lines 128-133)
                float viewLenSq = dot(viewVec, viewVec);
                float invLenF = rsqrt(max(viewLenSq, VIEW_EPS));
                float3 rayDir = viewVec * invLenF;
                float  rayLenView = invLenF * viewLenSq; // |viewVec| (b31 _196)
                float  blendInv = 1.0 + ((-0.0) - _BlendMode); // 1 - _BlendMode (b31 _209)

                // atmosphere in-scatter (b31 lines 151-157) — Mie/Rayleigh-style, all from _AtmosphereFogParams*
                float aDen = max(mad(worldP.y, _AtmosphereFogParams3.w, _AtmosphereFogParams4.w), 0.00999999977648258209228515625);
                float aOpt = (exp2(mad(worldP.y, _AtmosphereFogParams3.w, _AtmosphereFogParams5.w) * LOG2_E)
                              * ((((-0.0) - exp2(aDen * (-LOG2_E))) + 1.0) / aDen))
                             * ((-0.0) - max(mad(rayLenView, _AtmosphereFogParams1.w, (-0.0) - _AtmosphereFogParams0.w), 0.0));
                float aTransR = exp2((aOpt * _AtmosphereFogParams2.x) * LOG2_E);
                float aTransG = exp2((aOpt * _AtmosphereFogParams2.y) * LOG2_E);
                float aTransB = exp2((aOpt * _AtmosphereFogParams2.z) * LOG2_E);
                float aCos = dot(float3((-0.0) - rayDir.x, (-0.0) - rayDir.y, (-0.0) - rayDir.z),
                                 float3(_AtmosphereFogParams1.x, _AtmosphereFogParams1.y, _AtmosphereFogParams1.z));
                float aPhaseDen = mad(_AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0) + ((-0.0) - dot(aCos.xx, _AtmosphereFogParams2.w.xx));

                float fogDensity = 0.0;
                float3 fogColor  = float3(0.0, 0.0, 0.0);
                if (0.0 < _VolumetricFogParams0.z)
                {
                    // --- volumetric froxel path (b31 lines 162-196) ---
                    uint px = uint(input.positionCS.x);
                    uint py = uint(input.positionCS.y);
                    // PCG-ish hash chain seeded by pixel + frame (b31 lines 166-171)
                    uint h0 = (py * 1664525u) + 1013904223u;
                    uint h1 = ((7u & (uint)_Time.w) * 1664525u) + 1013904223u; // source used _FrameCount; _Time.w nearest URP analog
                    uint h2 = (h0 * h1) + ((px * 1664525u) + 1013904223u);
                    uint h3 = (h1 * h2) + h0;
                    uint h4 = (h2 * h3) + h1;
                    uint h5 = (h3 * h4) + h2;

                    float camForwardDotRay = dot(float3((-0.0) - rayDir.x, (-0.0) - rayDir.y, (-0.0) - rayDir.z),
                                                 float3((-0.0) - UNITY_MATRIX_V[2].x, (-0.0) - UNITY_MATRIX_V[2].y, (-0.0) - UNITY_MATRIX_V[2].z));
                    float heightAboveCam = worldP.y + ((-0.0) - _WorldSpaceCameraPos.y);
                    float marchScale = asfloat(asuint(1.0 / camForwardDotRay) & ((5.9604644775390625e-08 < camForwardDotRay) ? 0xffffffffu : 0u)) * _VolumetricFogParams0.w;
                    float invRayLen = 1.0 / rayLenView;
                    float marchT = invRayLen * marchScale;
                    float sampleY = mad(marchT, heightAboveCam, _WorldSpaceCameraPos.y);
                    float remHeight = mad((-0.0) - marchT, heightAboveCam, heightAboveCam);
                    float remFrac = mad((-0.0) - marchScale, invRayLen, 1.0);

                    float e0 = max(remHeight * _ExponentialFogParams0.z, -127.0);
                    float e3 = max(remHeight * _ExponentialFogParams3.x, -127.0);
                    float fogIntegral = mad(
                        exp2((-0.0) - max((sampleY + ((-0.0) - _ExponentialFogParams0.x)) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                        HgExpM1OverX(e0),
                        HgExpM1OverX(e3) * (exp2((-0.0) - max((sampleY + ((-0.0) - _ExponentialFogParams3.z)) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y));
                    float baseDen = clamp(mad(rayLenView, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0);
                    float totalDen = min(baseDen + (clamp(mad(rayLenView, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                                     + max(min(exp2((-0.0) - ((rayLenView * remFrac) * fogIntegral)), 1.0), _ExponentialFogParams2.w)), 1.0);

                    // froxel scattering color from the volumetric 3D texture (b31 lines 185-187)
                    // froxel UVW: X-tap = h5>>16 (b31:185 _532), Y-tap = (h4*h5 + h3)>>16 (b31:185 (_530*_532)+_528).
                    float3 froxelUVW = float3(
                        mad(mad(float(h5 >> 16u), BLUE_UNPACK, -1.0), _VolumetricFogParams4.w, float(px)) * _VolumetricFogParams2.x,
                        mad(mad(float(((h4 * h5) + h3) >> 16u), BLUE_UNPACK, -1.0), _VolumetricFogParams4.w, float(py)) * _VolumetricFogParams2.y,
                        (log2(mad(abs(viewZ), _VolumetricFogParams1.x, _VolumetricFogParams1.y)) * _VolumetricFogParams1.z) / _VolumetricFogParams0.z);
                    float4 froxel = SAMPLE_TEXTURE3D_LOD(_VolumetricLightingTexture, sampler_VolumetricLightingTexture, froxelUVW, 0.0);
                    float froxelMask = clamp((abs(viewZ) + ((-0.0) - _VolumetricFogParams3.z)) * 1000000.0, 0.0, 1.0);
                    float froxelTrans = mad(froxelMask, froxel.w + (-1.0), 1.0);
                    float invTotalDen = ((-0.0) - totalDen) + 1.0;
                    float heightCol = exp2(log2(clamp(dot(rayDir, float3(_ExponentialFogParams4.x, _ExponentialFogParams4.y, _ExponentialFogParams4.z)), 0.0, 1.0)) * _ExponentialFogParams5.w);
                    float dirTrans = ((-0.0) - min(exp2((-0.0) - (max(mad(remFrac, rayLenView, (-0.0) - _ExponentialFogParams4.w), 0.0) * fogIntegral)), 1.0)) + 1.0;
                    float invBaseDen = ((-0.0) - baseDen) + 1.0;
                    fogDensity = totalDen * froxelTrans;
                    fogColor.x = mad(mad(_ExponentialFogParams2.x, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.x))), froxelTrans, mad(froxelMask, froxel.x + (-0.0), 0.0));
                    fogColor.y = mad(mad(_ExponentialFogParams2.y, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.y))), froxelTrans, mad(froxelMask, froxel.y + (-0.0), 0.0));
                    fogColor.z = mad(mad(_ExponentialFogParams2.z, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.z))), froxelTrans, mad(froxelMask, froxel.z + (-0.0), 0.0));
                }
                else
                {
                    // --- analytic height fog path (no froxel) (b31 lines 199-212) ---
                    float heightAboveCam = worldP.y + ((-0.0) - _WorldSpaceCameraPos.y);
                    float e3 = max(heightAboveCam * _ExponentialFogParams3.x, -127.0);
                    float e0 = max(heightAboveCam * _ExponentialFogParams0.z, -127.0);
                    float fogIntegral = mad(
                        exp2((-0.0) - max((_WorldSpaceCameraPos.y + ((-0.0) - _ExponentialFogParams0.x)) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                        HgExpM1OverX(e0),
                        HgExpM1OverX(e3) * (exp2((-0.0) - max((_WorldSpaceCameraPos.y + ((-0.0) - _ExponentialFogParams3.z)) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y));
                    float baseDen = clamp(mad(rayLenView, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0);
                    float totalDen = min(baseDen + (clamp(mad(rayLenView, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                                     + max(min(exp2((-0.0) - (rayLenView * fogIntegral)), 1.0), _ExponentialFogParams2.w)), 1.0);
                    float invTotalDen = ((-0.0) - totalDen) + 1.0;
                    float heightCol = exp2(log2(clamp(dot(rayDir, float3(_ExponentialFogParams4.x, _ExponentialFogParams4.y, _ExponentialFogParams4.z)), 0.0, 1.0)) * _ExponentialFogParams5.w);
                    float dirTrans = ((-0.0) - min(exp2((-0.0) - (max(mad(viewLenSq, invLenF, (-0.0) - _ExponentialFogParams4.w), 0.0) * fogIntegral)), 1.0)) + 1.0;
                    float invBaseDen = ((-0.0) - baseDen) + 1.0;
                    fogDensity = totalDen;
                    fogColor.x = mad(_ExponentialFogParams2.x, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.x)));
                    fogColor.y = mad(_ExponentialFogParams2.y, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.y)));
                    fogColor.z = mad(_ExponentialFogParams2.z, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.z)));
                }

                // fog intensity over distance + atmosphere compose back onto the card color (b31 lines 214-220)
                float fogDist   = clamp(abs(viewZ) / _FogIntensityFadeOutDistance, 0.0, 1.0);
                float rayleighPh = mad(aCos, aCos, 1.0) * 0.0596831031143665313720703125; // 3/(16π)
                float miePh      = mad((-0.0) - _AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0) / max((aPhaseDen * 12.56637096405029296875) * sqrt(aPhaseDen), 0.001000000047497451305389404296875);
                float fogMix     = mad(_FogIntensity, ((-0.0) - fogDist) + 1.0, fogDist);
                // per-channel: lerp(cardColor, atmosphere*card + blendInv*scatter, fogMix). (b31 lines 218-220)
                float3 fogged;
                fogged.x = mad(fogMix, ((-0.0) - colF.x) + mad(colF.x, aTransR * fogDensity, blendInv * mad((((-0.0) - aTransR) + 1.0) * (clamp(mad(_AtmosphereFogParams4.x, miePh, mad(_AtmosphereFogParams3.x, rayleighPh, _AtmosphereFogParams5.x)), 0.0, 1.0) * 255.0), fogDensity, fogColor.x)), colF.x);
                fogged.y = mad(fogMix, ((-0.0) - colF.y) + mad(colF.y, aTransG * fogDensity, blendInv * mad((((-0.0) - aTransG) + 1.0) * (clamp(mad(_AtmosphereFogParams4.y, miePh, mad(_AtmosphereFogParams3.y, rayleighPh, _AtmosphereFogParams5.y)), 0.0, 1.0) * 255.0), fogDensity, fogColor.y)), colF.y);
                fogged.z = mad(fogMix, ((-0.0) - colF.z) + mad(colF.z, aTransB * fogDensity, blendInv * mad((((-0.0) - aTransB) + 1.0) * (clamp(mad(_AtmosphereFogParams4.z, miePh, mad(_AtmosphereFogParams3.z, rayleighPh, _AtmosphereFogParams5.z)), 0.0, 1.0) * 255.0), fogDensity, fogColor.z)), colF.z);
                colF = fogged;
                // _USE_FOG recomputes the alpha (no soft-blend term) from the same fades (b31 line 223)
                alpha = topFade * (nearFade * farFade * shapeAlphaF) * _BaseAlphaIntensity;
            #endif

                // ---- LOD crossfade attenuation: final = (1 - unity_LODFade.y) * clamp(alpha). unity_LODFade is a
                // URP built-in (UnityInput.hlsl); it is 0 unless LOD_FADE_CROSSFADE is active, so this is a no-op by
                // default and 1:1 with the blob when the card sits under a crossfading LODGroup. (b29:140, b37:161, b33:152, b31:224) ----
                float outAlpha = (1.0 + ((-0.0) - unity_LODFade.y)) * clamp(alpha, 0.0, 1.0);

                // ---- _VFXParams1 post adjustment: desaturate(.w) toward luma, then tint(.xyz) (b29 lines 141-146) ----
                float luma = dot(colF, LUMA);
                float3 outCol = float3(
                    mad(_VFXParams1.w, colF.x + ((-0.0) - luma), luma) * _VFXParams1.x,
                    mad(_VFXParams1.w, colF.y + ((-0.0) - luma), luma) * _VFXParams1.y,
                    mad(_VFXParams1.w, colF.z + ((-0.0) - luma), luma) * _VFXParams1.z);

                // premultiplied output: rgb scaled by alpha, alpha returned as-is (b29 lines 143-146)
                return half4(outAlpha * outCol, outAlpha);
            }
            ENDHLSL
        }
    }
}
