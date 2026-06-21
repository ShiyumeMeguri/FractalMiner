// HGRP SkyboxCubemap — rotatable HDR cubemap sky with HG atmosphere/exponential/volumetric fog re-color
//   (single Background pass; the source's empty "ProceduralSkyRayTracing" stub pass is dropped).
// Merged from: skyboxcubemap.shader Sub0 — vertex blob 1 (inline), fragment blob 2 (inline). No keyword variants
//   (the source has no multi_compile_local; the inline SPIRV-Cross HLSL IS the single ground-truth blob).
// Keywords: none.
// Kept: legacy Skybox/Cubemap sample (Y-axis _Rotation of the object-space cube direction, _Tint, [Gamma] _Exposure),
//   perspective/orthographic view-ray selection, the full HG fog stack — atmosphere in-scatter (Mie+Rayleigh phase),
//   exponential height fog (volumetric-froxel path + analytic path), _VFXParams1 desaturate/tint post adjustment.
// Removed: TAA jitter (_TaaJitterStrength), _NonJitteredViewNoTransProjMatrix no-translation VP (replaced by URP
//   far-plane skybox vertex via UNITY_MATRIX_VP on a camera-relative ray; z forced to the far clip value),
//   HGRP global cbuffer (re-exposed the needed HG-fog fields as material Vectors — URP has no equivalent global),
//   the RayTracingReflection pass (empty stub in source).
//
// NOTE: the source is a decompiled legacy "Skybox/Cubemap" builtin that HG wrapped with its fog post-apply. The
//   decompiler ALIASED the legacy skybox material cbuffer onto the per-draw matrix registers (register-overlap
//   artifact, same class FogSimple_Fix documents): _unity_ObjectToWorld[0].xyz = _Tint.rgb (blob lines 170-172),
//   _unity_ObjectToWorld[1].x = _Exposure (blob lines 170-172,236,240), _unity_ObjectToWorld[1].y = _Rotation
//   (blob line 166). Restored here as real material properties.
// NOTE: HG fog globals (_AtmosphereFogParams*/_ExponentialFogParams*/_VolumetricFogParams*) have no URP equivalent;
//   re-exposed as material Vectors so the fog math stays 1:1. Defaults make the branch a near-passthrough
//   (fogDensity≈0 ⇒ output ≈ cubemap*tint*exposure). Values are pushed by the HG sky/fog volume at runtime.
// NOTE: depth for the froxel sample/mask uses the source's `1.0/gl_FragCoord.w` (blob main glue line 249 sets
//   gl_FragCoord.w = 1/w_clip, so 1/that = w_clip = linear eye distance to the sky vertex). URP's interpolated
//   input.positionCS.w IS that same w_clip — no scene-depth fetch (the sky is its own far-plane geometry).
// NOTE: the colored cubemap (cubemap*tint*exposure, _VFXParams1-adjusted) is the fog "card color"; the compose is
//   the SAME atmosphere/fog blend as FogSimple_Fix but with blendInv=1 and no _FogIntensity distance lerp — the
//   sky is fully fogged at the far plane. Reproduced bit-for-bit from blob lines 236-243.

Shader "HGRP/SkyboxCubemap_Fix"
{
    Properties
    {
        _Tint ("Tint Color", Color) = (0.5, 0.5, 0.5, 0.5)
        [Gamma] _Exposure ("Exposure", Range(0, 8)) = 1
        _Rotation ("Rotation", Range(0, 360)) = 0
        [NoScaleOffset] _Tex ("Cubemap   (HDR)", Cube) = "black" {}

        // HG VFX post adjustment (global in source; re-exposed). .xyz = tint, .w = desaturation amount.
        _VFXParams1 ("VFX Color Adjust (xyz tint, w desat)", Vector) = (1, 1, 1, 0)

        // HG fog globals re-exposed so the fog compose stays 1:1 (no URP equivalent). Defaults => near-passthrough.
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
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline"="UniversalPipeline"
            "PreviewType"="Skybox"
            "Queue"="Background"
            "RenderType"="Background"
        }
        LOD 100

        Pass
        {
            // Source pass "ProceduralSky": ZClip On / ZWrite Off / Cull Front (blob lines 14-18).
            Name "Skybox"
            Tags { "LightMode"="SRPDefaultUnlit" }
            ZWrite Off
            ZTest LEqual
            Cull Front

            HLSLPROGRAM
            // 4.5: the volumetric froxel PCG hash (asuint/bit-shifts) + Texture3D LOD sampling need SM4.5 integer/
            // 3D-tex ops; source was target 5.0. (mirrors HGRP_FogSimple_Fix.shader)
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _Tint;
                float  _Exposure;
                float  _Rotation;
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

            TEXTURECUBE(_Tex);   SAMPLER(sampler_Tex);   // HDR sky cubemap (blob T1, linear repeat)
            // HG volumetric froxel texture (blob T0, Texture3D) — no URP source; sampled only in the froxel fog path.
            TEXTURE3D(_VolumetricLightingTexture); SAMPLER(sampler_VolumetricLightingTexture);

            static const float3 LUMA      = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709 (blob line 236)
            static const float  DEG2RAD   = 0.0174532942473888397216796875;          // π/180 (blob line 166)
            static const float  VIEW_EPS  = 9.9999999392252902907785028219223e-09;   // 1e-8 view-len floor (blob line 161)
            static const float  LOG2_E    = 1.44269502162933349609375;               // log2(e) (blob lines 174-177)
            static const float  EXPM1_EPS = 5.9604644775390625e-08;                  // 2^-24 (blob lines 196,204,208)
            static const float  BLUE_UNPACK = 3.05180437862873077392578125e-05;      // 1/32766, 16-bit (blob line 207)
            static const float  FOURPI    = 12.56637096405029296875;                 // 4π (blob line 239)
            static const float  INV16PI3  = 0.0596831031143665313720703125;          // 3/(16π) (blob line 238)
            static const float  ADEN_FLOOR = 0.00999999977648258209228515625;        // 0.01 (blob line 173)
            static const float  MIE_FLOOR  = 0.001000000047497451305389404296875;    // 0.001 (blob line 239)

            // expm1-style helper used by the HG exponential-height fog: (1 - exp2(-x))/x with a series fallback near 0.
            // Source spelled inline via asfloat(asuint(...)) bit-selects. (blob lines 204,224)
            float HgExpM1OverX(float x)
            {
                return (EXPM1_EPS < abs(x))
                       ? ((((-0.0) - exp2((-0.0) - x)) + 1.0) / x)
                       : mad((-0.0) - x, 0.2402265071868896484375, 0.693147182464599609375);
            }

            struct Attributes
            {
                float3 positionOS : POSITION;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float3 rayWS      : TEXCOORD0; // world-space sky ray (blob TEXCOORD, = world pos of the sky vertex)
                float3 cubeDirOS  : TEXCOORD1; // object-space direction for the cubemap lookup (blob TEXCOORD_1)
            };

            // ============================================================
            // Vertex — blob lines 63-79. Sky shell: world position = mul(ObjectToWorld, posOS) (the source's
            // camera-relative round-trip `(-cam + M*pos) + cam` collapses to M*pos), projected to clip then z is
            // forced to the far plane (source set z=0 under its [0,1]/ZClip-On convention). cubeDirOS = raw posOS.
            // ============================================================
            Varyings vert(Attributes v)
            {
                Varyings o;

                float3 posWS = TransformObjectToWorld(v.positionOS); // (blob lines 65-70)
                o.rayWS = posWS;

                o.positionCS = TransformWorldToHClip(posWS);
                // skybox sits at the far plane: source forced gl_Position.z = 0 under ZClip On (blob line 75).
                // URP/reversed-Z far value is UNITY_RAW_FAR_CLIP_VALUE; scale by w so perspective divide lands there.
                o.positionCS.z = UNITY_RAW_FAR_CLIP_VALUE * o.positionCS.w;

                o.cubeDirOS = v.positionOS; // (blob lines 76-78)
                return o;
            }

            // ============================================================
            // Fragment — blob lines 154-243.
            // ============================================================
            half4 frag(Varyings input) : SV_Target
            {
                // ---- view ray toward camera: perspective = cameraPos - skyVertexWS; ortho = camera forward
                //      (view Z row). (blob lines 156-159) ----
                bool isPersp = (0.0 == unity_OrthoParams.w); // source _47 = (0 == ortho.w) (blob line 156)
                float3 viewVec = isPersp
                    ? (((-0.0) - input.rayWS) + _WorldSpaceCameraPos)
                    : UNITY_MATRIX_V[2].xyz; // camera forward = view matrix Z row (blob lines 157-159 ortho branch)
                float viewLenSq = dot(viewVec, viewVec);                       // _95 (blob line 160)
                float invLenV   = rsqrt(max(viewLenSq, VIEW_EPS));             // _101 (blob line 161)
                float3 rayDir   = viewVec * invLenV;                           // _102,_103,_104 (blob lines 162-164)
                float  rayLenView = viewLenSq * invLenV;                       // _105 = |viewVec| (blob line 165)

                // ---- cubemap lookup with Y-axis rotation of the object-space direction (blob lines 166-169) ----
                float rot = DEG2RAD * _Rotation;                              // _109 (blob line 166)
                float sinR = sin(rot);                                        // _111 (blob line 167)
                float cosR = cos(rot);                                        // _112 (blob line 168)
                float3 cubeDir = float3(
                    dot(float2(cosR, (-0.0) - sinR), float2(input.cubeDirOS.x, input.cubeDirOS.z)), // cos*x - sin*z
                    input.cubeDirOS.y,
                    dot(float2(sinR, cosR), float2(input.cubeDirOS.x, input.cubeDirOS.z)));         // sin*x + cos*z
                float4 sky = SAMPLE_TEXTURECUBE(_Tex, sampler_Tex, cubeDir);  // _133 (blob line 169)

                // ---- tint the cubemap (blob lines 170-172): _143/_144/_145 = sky.rgb * _Tint.rgb ----
                float3 tinted = sky.rgb * _Tint.rgb;

                // ======================= HG atmosphere in-scatter (blob lines 173-179) =======================
                // worldP.y == sky vertex world Y == input.rayWS.y.
                float aDen = max(mad(input.rayWS.y, _AtmosphereFogParams3.w, _AtmosphereFogParams4.w), ADEN_FLOOR); // _163
                float aOpt = (((((-0.0) - exp2(aDen * (-LOG2_E))) + 1.0) / aDen)                                   // _198
                              * exp2(mad(input.rayWS.y, _AtmosphereFogParams3.w, _AtmosphereFogParams5.w) * LOG2_E))
                             * ((-0.0) - max(mad(rayLenView, _AtmosphereFogParams1.w, (-0.0) - _AtmosphereFogParams0.w), 0.0));
                float aTransR = exp2((aOpt * _AtmosphereFogParams2.x) * LOG2_E);                                    // _211
                float aTransG = exp2((aOpt * _AtmosphereFogParams2.y) * LOG2_E);                                    // _212
                float aTransB = exp2((aOpt * _AtmosphereFogParams2.z) * LOG2_E);                                    // _213
                float aCos = dot(float3((-0.0) - rayDir.x, (-0.0) - rayDir.y, (-0.0) - rayDir.z),                  // _222
                                 float3(_AtmosphereFogParams1.x, _AtmosphereFogParams1.y, _AtmosphereFogParams1.z));
                float aPhaseDen = mad(_AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0)                        // _239
                                + ((-0.0) - dot(aCos.xx, _AtmosphereFogParams2.w.xx));

                // ======================= exponential height fog: density + color (blob lines 180-235) =======================
                float fogDensity = 0.0; // _706
                float fogColorX  = 0.0; // _707
                float fogColorY  = 0.0; // _708
                float fogColorZ  = 0.0; // _709
                if (0.0 < _VolumetricFogParams0.z)
                {
                    // --- volumetric froxel path (blob lines 184-218) ---
                    uint px = uint(input.positionCS.x); // _249
                    uint py = uint(input.positionCS.y); // _250
                    // PCG-ish hash chain seeded by pixel + frame (blob lines 188-193)
                    uint h0 = (py * 1664525u) + 1013904223u;                                  // _263
                    uint h1 = ((7u & (uint)_Time.w) * 1664525u) + 1013904223u;                // _265 (source _FrameCount; _Time.w nearest URP analog)
                    uint h2 = (h0 * h1) + ((px * 1664525u) + 1013904223u);                    // _267
                    uint h3 = (h1 * h2) + h0;                                                 // _269
                    uint h4 = (h2 * h3) + h1;                                                 // _271
                    uint h5 = (h3 * h4) + h2;                                                 // _273

                    float camForwardDotRay = dot(float3((-0.0) - rayDir.x, (-0.0) - rayDir.y, (-0.0) - rayDir.z), // _280
                                                 float3((-0.0) - UNITY_MATRIX_V[2].x, (-0.0) - UNITY_MATRIX_V[2].y, (-0.0) - UNITY_MATRIX_V[2].z));
                    float heightAboveCam = input.rayWS.y + ((-0.0) - _WorldSpaceCameraPos.y);  // _289
                    float marchScale = asfloat(asuint(1.0 / camForwardDotRay) & ((EXPM1_EPS < camForwardDotRay) ? 0xffffffffu : 0u)) * _VolumetricFogParams0.w; // _301
                    float invRayLen = 1.0 / rayLenView;                                        // _302
                    float marchT = invRayLen * marchScale;                                     // _303
                    float sampleY = mad(marchT, heightAboveCam, _WorldSpaceCameraPos.y);       // _307
                    float remHeight = mad((-0.0) - marchT, heightAboveCam, heightAboveCam);    // _309
                    float remFrac = mad((-0.0) - marchScale, invRayLen, 1.0);                  // _311

                    float e0 = max(remHeight * _ExponentialFogParams0.z, -127.0);              // _318
                    float e3 = max(remHeight * _ExponentialFogParams3.x, -127.0);              // _325
                    float fogIntegral = mad(                                                   // _387
                        exp2((-0.0) - max((sampleY + ((-0.0) - _ExponentialFogParams0.x)) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                        HgExpM1OverX(e0),
                        HgExpM1OverX(e3) * (exp2((-0.0) - max((sampleY + ((-0.0) - _ExponentialFogParams3.z)) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y));
                    float baseDen = clamp(mad(rayLenView, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0); // _399
                    float totalDen = min(baseDen + (clamp(mad(rayLenView, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0) // _412
                                     + max(min(exp2((-0.0) - ((rayLenView * remFrac) * fogIntegral)), 1.0), _ExponentialFogParams2.w)), 1.0);

                    // froxel scattering color from the volumetric 3D texture (blob line 207). Depth coord uses
                    // 1/gl_FragCoord.w == input.positionCS.w (linear eye distance to the sky vertex).
                    // X-tap = h5>>16 (_273); Y-tap = (h4*h5 + h3)>>16 ((_271*_273)+_269).
                    float3 froxelUVW = float3(
                        mad(mad(float(h5 >> 16u), BLUE_UNPACK, -1.0), _VolumetricFogParams4.w, float(px)) * _VolumetricFogParams2.x,
                        mad(mad(float(((h4 * h5) + h3) >> 16u), BLUE_UNPACK, -1.0), _VolumetricFogParams4.w, float(py)) * _VolumetricFogParams2.y,
                        (log2(mad(input.positionCS.w, _VolumetricFogParams1.x, _VolumetricFogParams1.y)) * _VolumetricFogParams1.z) / _VolumetricFogParams0.z);
                    float4 froxel = SAMPLE_TEXTURE3D_LOD(_VolumetricLightingTexture, sampler_VolumetricLightingTexture, froxelUVW, 0.0); // _462
                    float froxelMask = clamp((input.positionCS.w + ((-0.0) - _VolumetricFogParams3.z)) * 1000000.0, 0.0, 1.0); // _479
                    float froxelTrans = mad(froxelMask, froxel.w + (-1.0), 1.0);               // _487
                    float invTotalDen = ((-0.0) - totalDen) + 1.0;                             // _489
                    float heightCol = exp2(log2(clamp(dot(rayDir, float3(_ExponentialFogParams4.x, _ExponentialFogParams4.y, _ExponentialFogParams4.z)), 0.0, 1.0)) * _ExponentialFogParams5.w); // _506
                    float dirTrans = ((-0.0) - min(exp2((-0.0) - (max(mad(remFrac, rayLenView, (-0.0) - _ExponentialFogParams4.w), 0.0) * fogIntegral)), 1.0)) + 1.0; // _526
                    float invBaseDen = ((-0.0) - baseDen) + 1.0;                               // _531
                    fogDensity = totalDen * froxelTrans;                                       // _706
                    fogColorX = mad(mad(_ExponentialFogParams2.x, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.x))), froxelTrans, mad(froxelMask, froxel.x + (-0.0), 0.0)); // _707
                    fogColorY = mad(mad(_ExponentialFogParams2.y, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.y))), froxelTrans, mad(froxelMask, froxel.y + (-0.0), 0.0)); // _708
                    fogColorZ = mad(mad(_ExponentialFogParams2.z, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.z))), froxelTrans, mad(froxelMask, froxel.z + (-0.0), 0.0)); // _709
                }
                else
                {
                    // --- analytic height fog path (no froxel) (blob lines 219-235) ---
                    float heightAboveCam = input.rayWS.y + ((-0.0) - _WorldSpaceCameraPos.y);  // _553
                    float e3 = max(heightAboveCam * _ExponentialFogParams3.x, -127.0);         // _562
                    float e0 = max(heightAboveCam * _ExponentialFogParams0.z, -127.0);         // _563
                    float fogIntegral = mad(                                                   // _629
                        exp2((-0.0) - max((_WorldSpaceCameraPos.y + ((-0.0) - _ExponentialFogParams0.x)) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                        HgExpM1OverX(e0),
                        HgExpM1OverX(e3) * (exp2((-0.0) - max((_WorldSpaceCameraPos.y + ((-0.0) - _ExponentialFogParams3.z)) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y));
                    float baseDen = clamp(mad(rayLenView, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0); // _640
                    float totalDen = min(baseDen + (clamp(mad(rayLenView, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0) // _652
                                     + max(min(exp2((-0.0) - (rayLenView * fogIntegral)), 1.0), _ExponentialFogParams2.w)), 1.0);
                    float invTotalDen = ((-0.0) - totalDen) + 1.0;                             // _654
                    float heightCol = exp2(log2(clamp(dot(rayDir, float3(_ExponentialFogParams4.x, _ExponentialFogParams4.y, _ExponentialFogParams4.z)), 0.0, 1.0)) * _ExponentialFogParams5.w); // _669
                    // NOTE: analytic branch uses mad(_95, _101, ...) == viewLenSq*invLenV == rayLenView here (blob line 229),
                    // whereas the froxel branch used mad(_311, _105, ...) (remFrac*rayLenView). Kept distinct.
                    float dirTrans = ((-0.0) - min(exp2((-0.0) - (max(mad(viewLenSq, invLenV, (-0.0) - _ExponentialFogParams4.w), 0.0) * fogIntegral)), 1.0)) + 1.0; // _689
                    float invBaseDen = ((-0.0) - baseDen) + 1.0;                               // _694
                    fogDensity = totalDen;                                                     // _706
                    fogColorX = mad(_ExponentialFogParams2.x, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.x))); // _707
                    fogColorY = mad(_ExponentialFogParams2.y, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.y))); // _708
                    fogColorZ = mad(_ExponentialFogParams2.z, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.z))); // _709
                }

                // ---- card color = (cubemap*tint) * _Exposure, _VFXParams1 desaturate(.w)+tint(.xyz) (blob lines 236-242) ----
                float3 exposed = tinted * _Exposure;                          // _143/_144/_145 * [1].x
                float luma = dot(exposed, LUMA);                              // _710
                float negLuma = (-0.0) - luma;                               // _719
                float3 colF = float3(
                    mad(_VFXParams1.w, exposed.x + negLuma, luma) * _VFXParams1.x,
                    mad(_VFXParams1.w, exposed.y + negLuma, luma) * _VFXParams1.y,
                    mad(_VFXParams1.w, exposed.z + negLuma, luma) * _VFXParams1.z);

                // ---- atmosphere phase: Rayleigh + Mie (blob lines 238-239) ----
                float rayleighPh = mad(aCos, aCos, 1.0) * INV16PI3;          // _742 = (1+cos^2)*3/(16π)
                float miePh = mad((-0.0) - _AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0) // _771
                            / max((aPhaseDen * FOURPI) * sqrt(aPhaseDen), MIE_FLOOR);

                // ---- final compose (blob lines 240-242): per-channel
                //   colF * (fogDensity * aTrans) + atmosScatter*(1-aTrans)*fogDensity + fogColor ----
                float atmScatterR = clamp(mad(_AtmosphereFogParams4.x, miePh, mad(_AtmosphereFogParams3.x, rayleighPh, _AtmosphereFogParams5.x)), 0.0, 1.0) * 255.0;
                float atmScatterG = clamp(mad(_AtmosphereFogParams4.y, miePh, mad(_AtmosphereFogParams3.y, rayleighPh, _AtmosphereFogParams5.y)), 0.0, 1.0) * 255.0;
                float atmScatterB = clamp(mad(_AtmosphereFogParams4.z, miePh, mad(_AtmosphereFogParams3.z, rayleighPh, _AtmosphereFogParams5.z)), 0.0, 1.0) * 255.0;

                float3 outCol;
                outCol.x = mad(colF.x, fogDensity * aTransR, mad(atmScatterR * (((-0.0) - aTransR) + 1.0), fogDensity, fogColorX));
                outCol.y = mad(colF.y, fogDensity * aTransG, mad(atmScatterG * (((-0.0) - aTransG) + 1.0), fogDensity, fogColorY));
                outCol.z = mad(colF.z, fogDensity * aTransB, mad(atmScatterB * (((-0.0) - aTransB) + 1.0), fogDensity, fogColorZ));

                return half4(outCol, 1.0); // SV_Target.w = 1 (blob line 243)
            }
            ENDHLSL
        }
    }
}
