// HGRP Procedural Skybox — full-screen sky dome: octahedral skybox cubemap + horizon fade,
//   two ray-marched celestial bodies (Planet0 "Planet" / Planet1 "Talos") with lat/long emissive+base
//   surface and atmosphere rim, analytic HQ sun disc, procedural equirect clouds, and the HG 3-layer
//   fog stack (atmosphere in-scatter + exponential height fog + optional volumetric froxel fog), with a
//   final VFX color grade. Two passes: opaque "ProceduralSky" (full sky) + blended "Cloud" (a second
//   premultiplied 'over' cloud layer drawn atop the sky).
//
// Merged from: 448/449 (Pass0 base sky+planets+fog, #else catch-all), 513 (Pass0 SKYBOX_SUNDISK_HQ),
//   1476/1477 (Cloud pass base, #else), 1479 (Cloud pass HG_CLOUD textured). The shader is a
//   "multi_compile_local" explosion (2048 sky variants); the catch-all (`HG_ENABLE_MV` only) is the
//   ground truth, with sun-disc + cloud collapsed as features. (NB: Pass0+HG_CLOUD blob b577 folds the
//   cloud into the opaque sky and writes alpha=1; it is NOT the Cloud pass and is not used here.)
// Keywords: _SKYBOX_SUNDISK_HQ, _HG_CLOUD, _HG_CLOUD_FLOWMAP, _HG_CLOUD_PROCEDRURALFLOW
// Kept: octahedral skybox lookup + horizon fade, Planet0/Planet1 sphere ray-march (lat/long UV via
//   atan/asin polynomial approximations, emissive*NdL-star + base*planetEmissive, atmosphere-rim falloff,
//   front-hemisphere gate), analytic HQ sun disc (1:1), procedural cloud equirect sampling (Cloud pass),
//   HG atmosphere/exponential/volumetric fog (1:1 analytic, incl. PCG froxel jitter), VFX color grade,
//   the Cloud composite pass (second blended layer, dual RGB SrcAlpha/OneMinusSrcAlpha + Alpha One/OneMinusSrcAlpha).
// Removed (HGRP pipeline infra substituted by URP / dropped, pixel-neutral for the look):
//   GPU motion vectors (SV_Target1 sqrt-encoded MV + _PrevNonJitteredViewNoTransProjMatrix prev-frame
//   reprojection — URP has a dedicated MotionVectors pass), TAA sub-pixel jitter (_TaaJitterStrength),
//   _NonJitteredViewNoTransProjMatrix (→ UNITY_MATRIX_VP), camera-relative world space, ray-tracing
//   reflection pass (HGRP "ProceduralSkyRayTracing" — no URP analog; dropped).
//
// NOTE: this is HGRP's bespoke sky. Every _Globals_* uniform (planet transforms/colors/atmosphere, sun
//   disc, cloud, star) and every _AtmosphereFogParams*/_ExponentialFogParams*/_VolumetricFogParams* is an
//   HGRP per-frame GLOBAL with NO URP equivalent — re-exposed here as material Vectors (set by a C# sky
//   driver, exactly like HGRP_FogSimple_Fix). The fog block is bit-identical to HGRP_FogSimple_Fix.
// NOTE: the per-planet texture set is keyword-gated in the source (HG_SKYBOX_STAR / HG_SKYBOX_NEBULA /
//   DRAW_ADVANCED_PLANET swap which Tn + sampler wrap a planet samples, and DRAW_PLANET_RING /
//   DRAW_PLANET_ATMOSPHERE / HG_RING add ring + scattering). This port carries the BASE planet texture
//   binding (Emi/Base per planet); the alternate star/nebula/advanced/ring planet paths are TODO (gaps).
// Texture roles (base variant): _SkyboxOctaMap = octahedral sky gradient; _Planet0EmiMap/_Planet0BaseMap,
//   _Planet1EmiMap/_Planet1BaseMap = celestial-body emissive/base; _CloudMap = equirect cloud;
//   _VolumetricFogTex = froxel 3D fog.

Shader "HGRP/ProceduralSky_Fix"
{
    Properties
    {
        [HideInInspector] _SkyboxOctaMap ("Skybox Octa Map", 2D) = "black" {}
        [HideInInspector] _Planet0EmiMap ("Planet0 Emissive", 2D) = "black" {}
        [HideInInspector] _Planet0BaseMap ("Planet0 Base", 2D) = "black" {}
        [HideInInspector] _Planet1EmiMap ("Planet1 Emissive", 2D) = "black" {}
        [HideInInspector] _Planet1BaseMap ("Planet1 Base", 2D) = "black" {}
        [HideInInspector] _CloudMap ("Cloud Map", 2D) = "black" {}
        [HideInInspector] _VolumetricFogTex ("Volumetric Fog (3D)", 3D) = "black" {}

        [Header(Feature Toggles)]
        [Toggle(_SKYBOX_SUNDISK_HQ)] _UseSunDisc ("HQ Sun Disc", Float) = 0
        [Toggle(_HG_CLOUD)] _UseCloud ("Procedural Cloud", Float) = 0
        [Toggle(_HG_CLOUD_FLOWMAP)] _UseCloudFlowmap ("Cloud Flowmap", Float) = 0
        [Toggle(_HG_CLOUD_PROCEDRURALFLOW)] _UseCloudProceduralFlow ("Cloud Procedural Flow", Float) = 0

        // ----- Planet / celestial-body globals (HGRP _Globals_*; set by sky driver) -----
        [Header(Planets)]
        _Globals_PlanetInView ("Planet0 In View", Float) = 0
        _Globals_TalosInView ("Planet1 In View", Float) = 0
        _Globals_PlanetCenterViewDir0 ("Planet0 Center ViewDir", Vector) = (0,0,1,0)
        _Globals_PlanetCenterViewDir1 ("Planet1 Center ViewDir", Vector) = (0,0,1,0)
        _Globals_PlanetParams0 ("Planet0 Params (.x=cosAngularRadius)", Vector) = (1,0,0,0)
        _Globals_PlanetParams1 ("Planet1 Params (.x=cosAngularRadius)", Vector) = (1,0,0,0)
        _Globals_PlanetUpWs0 ("Planet0 Up WS", Vector) = (0,1,0,0)
        _Globals_PlanetUpWs1 ("Planet1 Up WS", Vector) = (0,1,0,0)
        _Globals_PlanetForwardWs0 ("Planet0 Forward WS", Vector) = (0,0,1,0)
        _Globals_PlanetForwardWs1 ("Planet1 Forward WS", Vector) = (0,0,1,0)
        _Globals_PlanetRightWs0 ("Planet0 Right WS", Vector) = (1,0,0,0)
        _Globals_PlanetRightWs1 ("Planet1 Right WS", Vector) = (1,0,0,0)
        _Globals_IncidentLightDir0 ("Planet0 Incident Light Dir", Vector) = (0,0,1,0)
        _Globals_IncidentLightDir1 ("Planet1 Incident Light Dir", Vector) = (0,0,1,0)
        [HDR] _Globals_PlanetColor0 ("Planet0 Color", Vector) = (1,1,1,1)
        [HDR] _Globals_PlanetColor1 ("Planet1 Color", Vector) = (1,1,1,1)
        _Globals_PlanetEmissive0 ("Planet0 Emissive Scale", Vector) = (1,1,1,1)
        _Globals_PlanetEmissive1 ("Planet1 Emissive Scale", Vector) = (1,1,1,1)
        _Globals_StarNdlSharp0 ("Planet0 NdL Sharp", Float) = 1
        _Globals_StarNdlSharp1 ("Planet1 NdL Sharp", Float) = 1
        _Globals_StarBackFaceAlpha0 ("Planet0 BackFace Alpha", Float) = 0
        _Globals_StarBackFaceAlpha1 ("Planet1 BackFace Alpha", Float) = 0
        _Globals_PlanetAtmosphereParams30 ("Planet0 Atmosphere3 (.w=rimAmt)", Vector) = (0,0,0,0)
        _Globals_PlanetAtmosphereParams31 ("Planet1 Atmosphere3 (.w=rimAmt)", Vector) = (0,0,0,0)

        // ----- Sun disc globals -----
        [Header(Sun Disc)]
        [HDR] _Globals_SunDiscParam0 ("Sun Disc 0 (.rgb=color .w=size)", Vector) = (1,1,1,1)
        _Globals_SunDiscParam1 ("Sun Disc 1 (.x=falloffPow .y=softMix .w=intensity)", Vector) = (1,0,0,1)
        _Globals_SunDiscParam2 ("Sun Disc 2 (.xyz=-sunDir .w=intensity)", Vector) = (0,0,1,1)

        // ----- Cloud globals -----
        [Header(Cloud)]
        _Globals_CloudOpacities ("Cloud Opacities", Vector) = (1,1,1,1)
        [HDR] _Globals_CloudTint ("Cloud Tint", Vector) = (1,1,1,1)
        _Globals_CloudParam ("Cloud Param (.x=blend .y=contrast)", Vector) = (1,1,0,0)
        _Globals_CloudFlowParam ("Cloud Flow Param (.w=scrollTime)", Vector) = (0,0,0,0)

        // ----- VFX color grade -----
        [Header(VFX Color Adjustment)]
        _VFXParams1 ("VFX Params 1 (.xyz=tint .w=saturation)", Vector) = (1,1,1,1)

        // ----- HG fog globals (no URP analog; set by sky driver) -----
        [Header(Atmosphere Fog)]
        _AtmosphereFogParams0 ("Atmosphere Fog 0", Vector) = (0,0,0,0)
        _AtmosphereFogParams1 ("Atmosphere Fog 1", Vector) = (0,0,0,0)
        _AtmosphereFogParams2 ("Atmosphere Fog 2", Vector) = (0,0,0,0)
        _AtmosphereFogParams3 ("Atmosphere Fog 3", Vector) = (0,0,0,0)
        _AtmosphereFogParams4 ("Atmosphere Fog 4", Vector) = (0,0,0,0)
        _AtmosphereFogParams5 ("Atmosphere Fog 5", Vector) = (0,0,0,0)
        [Header(Exponential Fog)]
        _ExponentialFogParams0 ("Exponential Fog 0", Vector) = (0,0,0,0)
        _ExponentialFogParams1 ("Exponential Fog 1", Vector) = (0,0,0,0)
        _ExponentialFogParams2 ("Exponential Fog 2", Vector) = (0,0,0,0)
        _ExponentialFogParams3 ("Exponential Fog 3", Vector) = (0,0,0,0)
        _ExponentialFogParams4 ("Exponential Fog 4", Vector) = (0,0,0,0)
        _ExponentialFogParams5 ("Exponential Fog 5", Vector) = (0,0,0,0)
        [Header(Volumetric Fog)]
        _VolumetricFogParams0 ("Volumetric Fog 0 (.z=enable .w=stepLen)", Vector) = (0,0,0,0)
        _VolumetricFogParams1 ("Volumetric Fog 1", Vector) = (0,0,0,0)
        _VolumetricFogParams2 ("Volumetric Fog 2", Vector) = (0,0,0,0)
        _VolumetricFogParams3 ("Volumetric Fog 3", Vector) = (0,0,0,0)
        _VolumetricFogParams4 ("Volumetric Fog 4", Vector) = (0,0,0,0)
    }

    SubShader
    {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Background" "Queue"="Background" }
        LOD 600

        // =====================================================================================
        // Shared include: URP plumbing + uniforms + textures + the sky/planet/cloud/fog helpers.
        // =====================================================================================
        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

        CBUFFER_START(UnityPerMaterial)
            float4 _SkyboxOctaMap_ST;
            float4 _CloudMap_ST;

            // Planets
            float  _Globals_PlanetInView;
            float  _Globals_TalosInView;
            float4 _Globals_PlanetCenterViewDir0;
            float4 _Globals_PlanetCenterViewDir1;
            float4 _Globals_PlanetParams0;
            float4 _Globals_PlanetParams1;
            float4 _Globals_PlanetUpWs0;
            float4 _Globals_PlanetUpWs1;
            float4 _Globals_PlanetForwardWs0;
            float4 _Globals_PlanetForwardWs1;
            float4 _Globals_PlanetRightWs0;
            float4 _Globals_PlanetRightWs1;
            float4 _Globals_IncidentLightDir0;
            float4 _Globals_IncidentLightDir1;
            float4 _Globals_PlanetColor0;
            float4 _Globals_PlanetColor1;
            float4 _Globals_PlanetEmissive0;
            float4 _Globals_PlanetEmissive1;
            float  _Globals_StarNdlSharp0;
            float  _Globals_StarNdlSharp1;
            float  _Globals_StarBackFaceAlpha0;
            float  _Globals_StarBackFaceAlpha1;
            float4 _Globals_PlanetAtmosphereParams30;
            float4 _Globals_PlanetAtmosphereParams31;

            // Sun disc
            float4 _Globals_SunDiscParam0;
            float4 _Globals_SunDiscParam1;
            float4 _Globals_SunDiscParam2;

            // Cloud
            float4 _Globals_CloudOpacities;
            float4 _Globals_CloudTint;
            float4 _Globals_CloudParam;
            float4 _Globals_CloudFlowParam;

            // VFX grade
            float4 _VFXParams1;

            // HG fog
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

        TEXTURE2D(_SkyboxOctaMap);   SAMPLER(sampler_SkyboxOctaMap);   // octahedral sky gradient (LinearClamp)
        TEXTURE2D(_Planet0EmiMap);   SAMPLER(sampler_Planet0EmiMap);   // planet0 emissive (LinearRepeat)
        TEXTURE2D(_Planet0BaseMap);  SAMPLER(sampler_Planet0BaseMap);  // planet0 base    (LinearMirrorOnce)
        TEXTURE2D(_Planet1EmiMap);   SAMPLER(sampler_Planet1EmiMap);   // planet1 emissive (LinearMirror)
        TEXTURE2D(_Planet1BaseMap);  SAMPLER(sampler_Planet1BaseMap);  // planet1 base    (PointClamp)
        TEXTURE2D(_CloudMap);        SAMPLER(sampler_CloudMap);        // equirect cloud  (LinearRepeat)
        TEXTURE3D(_VolumetricFogTex);SAMPLER(sampler_VolumetricFogTex);// froxel fog (LinearClamp)

        // ----- Decoded magic constants (denormalized-float bit patterns -> real values) -----
        static const float3 REC709_LUMA = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625);
        static const float  LOG2_E      = 1.44269502162933349609375;   // log2(e)
        static const float  EPS_LEN     = 9.9999999392252902907785028219223e-09; // 1e-8 ray-len epsilon
        static const float  EPS_RCP     = 5.9604644775390625e-08;      // 2^-24 reciprocal-validity guard
        static const float  INV_2PI     = 0.15915493667125701904296875;// 1/(2*pi)
        static const float  PI_CONST    = 3.1415927410125732421875;
        static const float  HALF_PI     = 1.570728778839111328125;     // pi/2 (atan poly constant term, base path)
        static const float  PHASE_K     = 0.0596831031143665313720703125; // atmosphere phase const (= 3/(16*pi)-ish)
        static const float  FOUR_PI     = 12.56637096405029296875;     // 4*pi

        // (1 - exp2(-x))/x with a near-zero series fallback. Used by the HG exponential-height fog.
        // Source spelled inline (blob 449 lines 280/299; identical to HGRP_FogSimple_Fix HgExpM1OverX).
        float HgExpM1OverX(float x)
        {
            return (EPS_RCP < abs(x))
                   ? ((((-0.0) - exp2((-0.0) - x)) + 1.0) / x)
                   : mad((-0.0) - x, 0.2402265071868896484375, 0.693147182464599609375);
        }

        // sign(x) as float via the decompiled int-trunc idiom: (x>0) - (x<0)  (blob 449 line 177 etc.)
        float HgSign(float x)
        {
            return float(int((0u - ((0.0 < x) ? 4294967295u : 0u)) + ((x < 0.0) ? 4294967295u : 0u)));
        }

        // ---------------------------------------------------------------------------------
        // Ray-marched celestial body (one planet). Mirrors blob 449 lines 156-203 (planet0) /
        // 207-243 (planet1), parameterized over the per-planet globals + the two surface maps.
        // viewDir = normalized ray dir (unnormalized comps gxyz, len2 in r2 for the rsqrt).
        // Returns the planet emissive color (pre VFX-grade) in .rgb and the rim factor in .w.
        // ---------------------------------------------------------------------------------
        float4 EvaluatePlanet(
            float3 dirN, float3 dirRaw, float lenSq,
            float4 centerViewDir, float4 planetParams, float4 upWs, float4 fwdWs, float4 rightWs,
            float4 incidentLight, float ndlSharp, float backFaceAlpha,
            float4 planetColor, float4 planetEmissive, float4 atmoParams3,
            TEXTURE2D_PARAM(emiMap, emiSampler), TEXTURE2D_PARAM(baseMap, baseSampler),
            float mipBias)
        {
            // Re-normalize the ray with the EXACT (rsqrt(lenSq)) the source uses inside the planet branch
            // (blob 449 line 158). Note the (.y,.x,.z) component reshuffle the decompiler emitted (_137,_138,_139).
            float invLen = rsqrt(lenSq);                                            // 449:158
            float dy = dirRaw.y * invLen;
            float dx = dirRaw.x * invLen;
            float dz = dirRaw.z * invLen;
            float3 vd = float3(dx, dy, dz);                                         // view dir (x,y,z)

            // sphere intersection (cosAngularRadius packed in planetParams.x). (449:162-167)
            float vDotC = dot(vd, centerViewDir.xyz);                              // 449:162
            float disc  = mad(vDotC, vDotC, mad(planetParams.x, planetParams.x, -1.0)); // 449:163
            float t     = ((-0.0) - sqrt(max(disc, 0.0))) + vDotC;                 // 449:164
            // surface point on unit-direction sphere, relative to center, scaled by 1/cosR. (449:165-167)
            float3 sp = float3(
                mad(dx, t, (-0.0) - centerViewDir.x) / planetParams.x,
                mad(dy, t, (-0.0) - centerViewDir.y) / planetParams.x,
                mad(dz, t, (-0.0) - centerViewDir.z) / planetParams.x);

            // tangent-frame project onto planet basis -> lat (via up) and long (via right/forward). (449:168-182)
            float upDot = dot(sp, upWs.xyz);                                        // 449:168
            float3 planar = float3(
                mad((-0.0) - upWs.x, upDot, sp.x),
                mad((-0.0) - upWs.y, upDot, sp.y),
                mad((-0.0) - upWs.z, upDot, sp.z));                                 // 449:169-171
            float planarInv = rsqrt(dot(planar, planar));                          // 449:172
            float3 planarN = planar * planarInv;                                   // 449:173-175
            float rightDot = dot(planarN, rightWs.xyz);                            // 449:176
            float rightSign = HgSign(rightDot);                                    // 449:177
            float fwdDot = dot(planarN, fwdWs.xyz);                                // 449:178
            float fwdComp = sqrt(((-0.0) - abs(fwdDot)) + 1.0);                    // 449:179 (= sin from cos)
            // acos polynomial approximation of |fwdDot| (449:180): 7th-order minimax for asin/acos.
            float acosApprox = mad(mad(mad(abs(fwdDot), -0.0187292993068695068359375, 0.074261002242565155029296875),
                                       abs(fwdDot), -0.212114393711090087890625), abs(fwdDot), HALF_PI);
            // longitude u in [0,1]: sign-correct the half, wrap negative-forward to (2pi - a). (449:181)
            float longParam = mad(
                rightSign * mad(acosApprox, fwdComp,
                    asfloat(((fwdDot < ((-0.0) - fwdDot)) ? 4294967295u : 0u) & asuint(mad(fwdComp * acosApprox, -2.0, PI_CONST)))),
                INV_2PI, clamp((-0.0) - rightSign, 0.0, 1.0));
            // latitude v from up-dot via cubic (449:182):
            float latParam = mad(mad(upDot * upDot, -0.22222222387790679931640625, -0.27777779102325439453125),
                                 (-0.0) - upDot, 0.500000059604644775390625);

            float2 uvPlanet = float2(longParam, latParam);
            float4 emi  = SAMPLE_TEXTURE2D_BIAS(emiMap, emiSampler, uvPlanet, mipBias);   // 449:183
            float4 base = SAMPLE_TEXTURE2D_BIAS(baseMap, baseSampler, uvPlanet, mipBias); // 449:185

            // N.L star term: saturate( saturate(dot(incidentLight, surfNormal)) * ndlSharp + backFaceAlpha ). (449:184)
            float ndl = clamp(mad(clamp(dot(incidentLight.xyz, sp), 0.0, 1.0), ndlSharp, backFaceAlpha), 0.0, 1.0);

            // visibility gate: only where the disc actually faces us (centerViewDir normalized, ray in front). (449:186-187)
            float centerInvLen = rsqrt(dot(centerViewDir.xyz, centerViewDir.xyz));
            float facing = asfloat(((0.0 < max(clamp(dot(vd, centerInvLen * centerViewDir.xyz), 0.0, 1.0) * disc, 0.0)) ? 4294967295u : 0u) & 1065353216u);

            // emissive color = base.a * facing * (emi.rgb*ndl + base.rgb*planetEmissive) * planetColor. (449:188-190)
            float3 emiCol = (emi.w * (facing * mad(emi.rgb, ndl.xxx, base.rgb * planetEmissive.xyz))) * planetColor.xyz;

            // atmosphere rim falloff using latitude (dirN.y clamped). (449:191)
            float rim = mad(atmoParams3.w, clamp(dy, 0.0, 1.0) + (-1.0), 1.0);
            return float4(emiCol, rim);
        }

        // ---------------------------------------------------------------------------------
        // HG 3-layer fog: atmosphere in-scatter + exponential height fog (+ optional volumetric
        // froxel). 1:1 from blob 449 lines 250-323 (the #else volumetric branch + composite).
        // skyColor = pre-fog sky+planets RGB (already VFX-graded source-side via _635..637 path).
        //   rayN  = normalized ray dir, rayLen = eye distance (= lenSq*invLen), worldDir = sky world pos,
        //   fragCoord = SV_Position.xyw, linearW = linear eye depth = clip.w, camPosY world height.
        //   NOTE on linearW: blob reads froxel/depth-gate depth as (1.0/gl_FragCoord.w); after main()'s
        //   gl_FragCoord.w=1/clip.w that equals clip.w = linear eye depth (matches the verified
        //   HGRP_FogSimple_Fix froxel which uses abs(viewZ)=clip.w). URP's fragment positionCS.w = 1/clip.w,
        //   so linearW = 1.0/positionCS.w = clip.w. (449:283-284)
        // Returns final composited RGB. (We fold the source's _635/_1184/_1185 composite exactly.)
        // ---------------------------------------------------------------------------------
        float3 ApplyHgFog(float3 skyColor, float3 rayN, float rayLen, float3 worldDir,
                          float4 fragCoord, float linearW, float camPosY)
        {
            // ----- atmosphere transmittance + in-scatter setup (449:250-256) -----
            float aDen = max(mad(worldDir.y, _AtmosphereFogParams3.w, _AtmosphereFogParams4.w), 0.00999999977648258209228515625); // 449:250
            float aOpt = ((((((-0.0) - exp2(aDen * ((-0.0) - LOG2_E))) + 1.0) / aDen)
                          * exp2(mad(worldDir.y, _AtmosphereFogParams3.w, _AtmosphereFogParams5.w) * LOG2_E))
                          * ((-0.0) - max(mad(rayLen, _AtmosphereFogParams1.w, (-0.0) - _AtmosphereFogParams0.w), 0.0)));  // 449:251
            float3 aTrans = exp2((aOpt * _AtmosphereFogParams2.xyz) * LOG2_E);                                            // 449:252-254
            float aCos = dot(rayN, _AtmosphereFogParams1.xyz);                                                            // 449:255
            float aPhaseDen = mad(_AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0) + ((-0.0) - dot(aCos.xx, _AtmosphereFogParams2.w.xx)); // 449:256

            // ----- exponential + (optional) volumetric height fog -----
            float fogAmount;   // _1184
            float3 fogColor;   // _1185..1187
            if (0.0 < _VolumetricFogParams0.z)
            {
                // PCG hash from pixel coords + frame for froxel jitter. (449:263-270)
                uint px = uint(fragCoord.x);
                uint py = uint(fragCoord.y);
                uint h0 = (py * 1664525u) + 1013904223u;
                // NOTE: source seeds the per-frame jitter with _FrameCount (an HGRP global). URP exposes
                // no standard equivalent uniform here, so the PCG chain is kept 1:1 but seeded with
                // frame=0 (static froxel jitter). See gaps / TODO(1:1) below.
                uint frameSeed = 0u;                                                  // TODO(1:1): _FrameCount global (449:266)
                uint h2 = ((frameSeed & 7u) * 1664525u) + 1013904223u;
                uint h3 = (h0 * h2) + ((px * 1664525u) + 1013904223u);                // 449:267
                uint h4 = (h2 * h3) + h0;                                             // 449:268
                uint h5 = (h3 * h4) + h2;                                             // 449:269
                uint h6 = (h4 * h5) + h3;                                             // 449:270

                // camera-forward dot (ortho-aware ray-length along view Z). (449:271-274)
                float viewZ = dot(rayN, float3((-0.0) - UNITY_MATRIX_V[2].x, (-0.0) - UNITY_MATRIX_V[2].y, (-0.0) - UNITY_MATRIX_V[2].z));
                float stepLen = asfloat(asuint(1.0 / viewZ) & ((EPS_RCP < viewZ) ? 4294967295u : 0u)) * _VolumetricFogParams0.w; // 449:272
                float invRayLen = 1.0 / rayLen;                                       // 449:273
                float marchT = stepLen * invRayLen;                                   // 449:274
                float sampleY = mad(marchT, worldDir.y, camPosY);                     // 449:275
                float dyEff   = mad((-0.0) - marchT, worldDir.y, worldDir.y);         // 449:276
                float oneMinusStep = mad((-0.0) - stepLen, invRayLen, 1.0);           // 449:277

                // exponential height-fog optical depth (two layers, 0 and 3). (449:278-280)
                float e3 = max(dyEff * _ExponentialFogParams3.x, -127.0);
                float e0 = max(dyEff * _ExponentialFogParams0.z, -127.0);
                float optDepth = mad(exp2((-0.0) - max((sampleY + ((-0.0) - _ExponentialFogParams0.x)) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                                     HgExpM1OverX(e0),
                                     HgExpM1OverX(e3) * (exp2((-0.0) - max((sampleY + ((-0.0) - _ExponentialFogParams3.z)) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y)); // 449:280
                float fogA = clamp(mad(rayLen, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0); // 449:281
                float fogB = min(fogA + (clamp(mad(rayLen, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                               + max(min(exp2((-0.0) - ((rayLen * oneMinusStep) * optDepth)), 1.0), _ExponentialFogParams2.w)), 1.0); // 449:282

                // froxel 3D sample (jittered uvw, depth-sliced log). (449:283)
                float3 froxelUVW = float3(
                    mad(mad(float(h6 >> 16u), 3.05180437862873077392578125e-05, -1.0), _VolumetricFogParams4.w, float(px)) * _VolumetricFogParams2.x,                 // blob uses float(uint(fragCoord.x))
                    mad(mad(float(((h5 * h6) + h4) >> 16u), 3.05180437862873077392578125e-05, -1.0), _VolumetricFogParams4.w, float(py)) * _VolumetricFogParams2.y,     // blob uses float(uint(fragCoord.y))
                    (log2(mad(linearW, _VolumetricFogParams1.x, _VolumetricFogParams1.y)) * _VolumetricFogParams1.z) / _VolumetricFogParams0.z);
                float4 froxel = SAMPLE_TEXTURE3D_LOD(_VolumetricFogTex, sampler_VolumetricFogTex, froxelUVW, 0.0);
                float depthGate = clamp((linearW + ((-0.0) - _VolumetricFogParams3.z)) * 1000000.0, 0.0, 1.0); // 449:284
                float froxelTrans = mad(depthGate, froxel.w + (-1.0), 1.0);          // 449:285
                float oneMinusFogB = ((-0.0) - fogB) + 1.0;                          // 449:286
                float ground = exp2(log2(clamp(dot((-rayN), _ExponentialFogParams4.xyz), 0.0, 1.0)) * _ExponentialFogParams5.w); // 449:287
                float groundTrans = ((-0.0) - min(exp2((-0.0) - (max(mad(oneMinusStep, rayLen, (-0.0) - _ExponentialFogParams4.w), 0.0) * optDepth)), 1.0)) + 1.0; // 449:288
                float oneMinusFogA = ((-0.0) - fogA) + 1.0;                          // 449:289

                fogAmount = fogB * froxelTrans;                                      // 449:290
                fogColor = float3(
                    mad(mad(_ExponentialFogParams2.x, oneMinusFogB, oneMinusFogA * (groundTrans * (ground * _ExponentialFogParams5.x))), froxelTrans, mad(depthGate, froxel.x, 0.0)),
                    mad(mad(_ExponentialFogParams2.y, oneMinusFogB, oneMinusFogA * (groundTrans * (ground * _ExponentialFogParams5.y))), froxelTrans, mad(depthGate, froxel.y, 0.0)),
                    mad(mad(_ExponentialFogParams2.z, oneMinusFogB, oneMinusFogA * (groundTrans * (ground * _ExponentialFogParams5.z))), froxelTrans, mad(depthGate, froxel.z, 0.0))); // 449:291-293
            }
            else
            {
                // no-volumetric branch (449:297-309): exp height fog evaluated at camera height directly.
                float e0 = max(worldDir.y * _ExponentialFogParams0.z, -127.0);       // 449:297
                float e3 = max(worldDir.y * _ExponentialFogParams3.x, -127.0);       // 449:298
                float optDepth = mad(exp2((-0.0) - max((camPosY + ((-0.0) - _ExponentialFogParams0.x)) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                                     HgExpM1OverX(e0),
                                     HgExpM1OverX(e3) * (exp2((-0.0) - max((camPosY + ((-0.0) - _ExponentialFogParams3.z)) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y)); // 449:299
                float fogA = clamp(mad(rayLen, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0); // 449:300
                float fogB = min(fogA + (clamp(mad(rayLen, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                               + max(min(exp2((-0.0) - (rayLen * optDepth)), 1.0), _ExponentialFogParams2.w)), 1.0); // 449:301
                float oneMinusFogB = ((-0.0) - fogB) + 1.0;                          // 449:302
                float ground = exp2(log2(clamp(dot((-rayN), _ExponentialFogParams4.xyz), 0.0, 1.0)) * _ExponentialFogParams5.w); // 449:303
                // NOTE source uses lenSq*invLen (= rayLen) here as _84*_90; identical to rayLen. (449:304)
                float groundTrans = ((-0.0) - min(exp2((-0.0) - (max(mad(rayLen, 1.0, (-0.0) - _ExponentialFogParams4.w), 0.0) * optDepth)), 1.0)) + 1.0; // 449:304
                float oneMinusFogA = ((-0.0) - fogA) + 1.0;                          // 449:305

                fogAmount = fogB;                                                    // 449:306
                fogColor = float3(
                    mad(_ExponentialFogParams2.x, oneMinusFogB, oneMinusFogA * (groundTrans * (ground * _ExponentialFogParams5.x))),
                    mad(_ExponentialFogParams2.y, oneMinusFogB, oneMinusFogA * (groundTrans * (ground * _ExponentialFogParams5.y))),
                    mad(_ExponentialFogParams2.z, oneMinusFogB, oneMinusFogA * (groundTrans * (ground * _ExponentialFogParams5.z)))); // 449:307-309
            }

            // ----- final composite: VFX-grade sky, mul by fogAmount*atmTrans, add atmosphere in-scatter. (449:311-317) -----
            float skyLuma = dot(skyColor, REC709_LUMA);                              // 449:311
            float negLuma = (-0.0) - skyLuma;                                        // 449:312
            float phaseFwd = mad(aCos, aCos, 1.0) * PHASE_K;                         // 449:313 Rayleigh-ish phase
            float phaseBack = mad((-0.0) - _AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0)
                            / max(sqrt(aPhaseDen) * (aPhaseDen * FOUR_PI), 0.001000000047497451305389404296875); // 449:314 Mie HG phase

            float3 graded = (mad(_VFXParams1.w.xxx, negLuma.xxx + skyColor, skyLuma.xxx) * _VFXParams1.xyz); // VFX desat/tint
            float3 inscatter = (clamp(mad(_AtmosphereFogParams4.xyz, phaseBack.xxx, mad(_AtmosphereFogParams3.xyz, phaseFwd.xxx, _AtmosphereFogParams5.xyz)), 0.0, 1.0) * 255.0)
                             * (((-0.0) - aTrans) + 1.0);
            // out = graded*(fogAmount*atmTrans) + inscatter*fogAmount + fogColor   (449:315-317)
            return mad(graded, fogAmount.xxx * aTrans, mad(inscatter, fogAmount.xxx, fogColor));
        }
        ENDHLSL

        // =====================================================================================
        // Pass 0: ProceduralSky — full sky dome (octa sky + planets + sun disc + fog).
        // Source render-state: ZClip On, ZWrite Off, Cull Front, LOD 600 (no LightMode tag).
        // SV_Target1 (motion vectors) DROPPED (URP MotionVectors pass owns that).
        // =====================================================================================
        Pass
        {
            Name "ProceduralSky"
            Tags { "LightMode"="UniversalForwardOnly" }
            ZWrite Off
            ZTest LEqual
            Cull Front

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _SKYBOX_SUNDISK_HQ

            struct Attributes
            {
                float3 positionOS : POSITION;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float3 worldDir    : TEXCOORD1; // world-space sky-dome position (blob TEXCOORD_1)
                float2 uv          : TEXCOORD2;
            };

            // Vertex: dome positioned at the camera. Source builds world pos = ObjectToWorld*posOS, then
            // a no-translation view-proj with clip.z forced to 0 (far-plane sky). URP: TransformObjectToWorld
            // + UNITY_MATRIX_VP, then clamp clip.z to the far plane via positionCS = positionCS.xyww-style.
            // (blob 448 lines 53-79)
            Varyings vert(Attributes v)
            {
                Varyings o;
                float3 posWS = TransformObjectToWorld(v.positionOS);                 // 448:53-55 (world dome pos)
                o.worldDir = posWS;                                                  // 448:66-68 (TEXCOORD_1 = world pos)
                float4 clip = TransformWorldToHClip(posWS);                          // 448:56-58 (no-jitter VP)
                // sky at far plane: force depth to the far value (reversed-Z aware). (448:61 gl_Position.z=0)
                #if UNITY_REVERSED_Z
                    clip.z = 1e-6 * clip.w;
                #else
                    clip.z = clip.w;
                #endif
                o.positionCS = clip;
                o.uv = v.uv;
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                // ---- view ray (world): dir = normalize(worldPos - camPos), len = eye distance. (449:137-145) ----
                float3 rel = input.worldDir - _WorldSpaceCameraPos.xyz;             // 449:137-139
                float lenSq = dot(rel, rel);                                        // 449:140
                float invLen = rsqrt(max(lenSq, EPS_LEN));                          // 449:141
                float3 rayN = rel * invLen;                                         // 449:142-144 normalized dir
                float rayLen = lenSq * invLen;                                      // 449:145 eye distance

                // ---- base octahedral skybox lookup + horizon fade. (449:146-152) ----
                float octScale = 1.0 / dot(abs(rayN), 1.0.xxx);                     // 449:146 (octahedral)
                float octZ = rayN.z * octScale;
                float2 octUV = float2(((octZ + (rayN.x * octScale)) + 1.0) * 0.5,
                                      (mad(rayN.x, octScale, (-0.0) - octZ) + 1.0) * 0.5); // 449:148
                float3 sky = SAMPLE_TEXTURE2D_LOD(_SkyboxOctaMap, sampler_SkyboxOctaMap, octUV, 0.0).rgb;
                float horizon = clamp(mad(rayN.y, 10.0, 1.0), 0.0, 1.0);           // 449:149 horizon fade
                sky *= horizon;                                                    // 449:150-152

            #ifdef _SKYBOX_SUNDISK_HQ
                // ---- analytic HQ sun disc, added to sky before planets. (513:150-158) ----
                float sunCos = exp2(log2(clamp(dot((-_Globals_SunDiscParam2.xyz), (-rayN)), 0.0, 1.0)) * _Globals_SunDiscParam1.x); // 513:150 pow(saturate(L.V), falloff)
                float sunShape = (mad(sunCos, sunCos, 1.0) * 0.010016442276537418365478515625)
                               / max(exp2(log2(mad((-0.0) - sunCos, 1.980000019073486328125, 1.98010003566741943359375))
                                          * (exp2(log2(_Globals_SunDiscParam0.w) * 0.64999997615814208984375) * 8.0)),
                                     9.9999997473787516355514526367188e-05);        // 513:151
                float sunS = sunShape + (-0.5);                                     // 513:152
                float sunSat = clamp(sunS + sunS, 0.0, 1.0);                        // 513:153
                float sunSmooth = (sunSat * sunSat) * mad(sunSat, -2.0, 3.0);       // 513:154 smoothstep
                float sunMix = mad(_Globals_SunDiscParam1.y, mad((-0.0) - sunSmooth, sunShape, sunShape), sunShape * sunSmooth); // 513:155
                float3 sunAdd = min(max(((sunMix * _Globals_SunDiscParam0.xyz) * _Globals_SunDiscParam1.w) * _Globals_SunDiscParam2.w, 0.0), 3.0); // 513:156-158
                sky = sky + sunAdd;                                                 // 513:156-158 (mad with horizon-sky)
            #endif

                // ---- Planet0 ("Planet"), front-hemisphere gated. (449:156-203) ----
                float3 color = sky;
                if (0.75 < _Globals_PlanetInView)
                {
                    float4 p = EvaluatePlanet(rayN, rel, lenSq,
                        _Globals_PlanetCenterViewDir0, _Globals_PlanetParams0, _Globals_PlanetUpWs0, _Globals_PlanetForwardWs0, _Globals_PlanetRightWs0,
                        _Globals_IncidentLightDir0, _Globals_StarNdlSharp0, _Globals_StarBackFaceAlpha0,
                        _Globals_PlanetColor0, _Globals_PlanetEmissive0, _Globals_PlanetAtmosphereParams30,
                        TEXTURE2D_ARGS(_Planet0EmiMap, sampler_Planet0EmiMap), TEXTURE2D_ARGS(_Planet0BaseMap, sampler_Planet0BaseMap),
                        _GlobalMipBias.x);   // URP 17 _GlobalMipBias is float2 (.x = bias scalar = HG _GlobalMipBias)
                    // VFX-grade the planet and blend over sky (rim-scaled). (449:191-196)
                    float pl = dot(p.rgb * p.w, REC709_LUMA);                       // 449:192 (luma of rim*emi)
                    float3 graded = mad(_VFXParams1.w.xxx, mad(p.rgb, p.w.xxx, ((-0.0) - pl).xxx), pl.xxx); // 449:194-196
                    color = mad(graded, _VFXParams1.xyz, color);
                }

                // ---- Planet1 ("Talos"), front-hemisphere gated. (449:207-242) ----
                if (0.75 < _Globals_TalosInView)
                {
                    float4 p = EvaluatePlanet(rayN, rel, lenSq,
                        _Globals_PlanetCenterViewDir1, _Globals_PlanetParams1, _Globals_PlanetUpWs1, _Globals_PlanetForwardWs1, _Globals_PlanetRightWs1,
                        _Globals_IncidentLightDir1, _Globals_StarNdlSharp1, _Globals_StarBackFaceAlpha1,
                        _Globals_PlanetColor1, _Globals_PlanetEmissive1, _Globals_PlanetAtmosphereParams31,
                        TEXTURE2D_ARGS(_Planet1EmiMap, sampler_Planet1EmiMap), TEXTURE2D_ARGS(_Planet1BaseMap, sampler_Planet1BaseMap),
                        _GlobalMipBias.x);
                    // planet1 blends as mad(emiCol*rim, 1, color) per channel. (449:240-242)
                    color = mad(p.rgb, p.w.xxx, color);
                }

                // ---- 3-layer fog + final VFX-grade composite. (449:250-317) ----
                // linearW = clip.w = linear eye depth = blob's (1.0/gl_FragCoord.w). positionCS.w is 1/clip.w in
                // the fragment, so invert once. (Matches HGRP_FogSimple_Fix froxel abs(viewZ)=clip.w.)
                float linearW = 1.0 / input.positionCS.w;                           // 449:283-284 (= clip.w)
                float3 outRGB = ApplyHgFog(color, rayN, rayLen, input.worldDir, input.positionCS, linearW, _WorldSpaceCameraPos.y);
                return half4(outRGB, 1.0);                                          // SV_Target.w = 1 (449:325)
            }
            ENDHLSL
        }

        // =====================================================================================
        // Pass 1: Cloud — premultiplied 'over' cloud composite, a second blended layer atop ProceduralSky.
        // Source render-state: Blend 0 SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha (RT0); ColorMask GB 1
        //   masks RT1 (= dropped motion-vector target, no URP analog); ZClip On; ZWrite Off; Cull Front.
        //   (proceduralsky.shader:3124-3128). URP keeps RT0 only -> full RGBA write, dual RGB/alpha blend.
        // Base variant (b1477, no HG_CLOUD): flat hemisphere-tinted cloud constant + fog, gated to
        //   the upper hemisphere. The textured cloud path is the _HG_CLOUD feature (Pass-1 blob b1479):
        //   same structure as b1477 but cloud color/coverage come from the equirect _CloudMap sample —
        //   NO octa-sky lookup and NO soft-mix; color = cloudCol*upperGate, alpha = textured coverage.
        // =====================================================================================
        Pass
        {
            Name "Cloud"
            Tags { "LightMode"="SRPDefaultUnlit" }
            // Source RT0 state (the only target URP keeps): Blend 0 SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha.
            //   RGB src=SrcAlpha dst=OneMinusSrcAlpha; ALPHA src=One dst=OneMinusSrcAlpha (standard 'over' alpha accum).
            //   The source's 'ColorMask GB 1' masks RT1 (the dropped motion-vector target), NOT RT0 — so RT0 writes
            //   full RGBA and NO ColorMask applies here. (proceduralsky.shader:3124-3125)
            Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha
            ZWrite Off
            ZTest LEqual
            Cull Front

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _HG_CLOUD
            #pragma shader_feature_local _HG_CLOUD_FLOWMAP
            #pragma shader_feature_local _HG_CLOUD_PROCEDRURALFLOW

            struct Attributes
            {
                float3 positionOS : POSITION;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float3 worldDir    : TEXCOORD1;
                float2 uv          : TEXCOORD2;
            };

            // Vertex identical to pass 0 (same dome; blob 1476 == 448).
            Varyings vert(Attributes v)
            {
                Varyings o;
                float3 posWS = TransformObjectToWorld(v.positionOS);
                o.worldDir = posWS;
                float4 clip = TransformWorldToHClip(posWS);
                #if UNITY_REVERSED_Z
                    clip.z = 1e-6 * clip.w;
                #else
                    clip.z = clip.w;
                #endif
                o.positionCS = clip;
                o.uv = v.uv;
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                // view ray (1477:84-92)
                float3 rel = input.worldDir - _WorldSpaceCameraPos.xyz;
                float lenSq = dot(rel, rel);
                float invLen = rsqrt(max(lenSq, EPS_LEN));
                float3 rayN = rel * invLen;
                float rayLen = lenSq * invLen;

            #ifdef _HG_CLOUD
                // ---- textured procedural cloud (equirect via atan/asin polynomial). GROUND TRUTH = Pass-1
                //   HG_CLOUD blob b1479 (NOT b577 — that is the Pass-0/opaque cloud variant). b1479 is the
                //   base cloud (b1477) with the flat constant replaced by the textured equirect sample:
                //   NO octa-sky lookup, NO horizon, NO soft-mix-over-sky; color = cloudCol*upperGate and the
                //   alpha channel = textured cloud coverage. (b1479:85-117) ----
                // TODO(1:1): _HG_CLOUD_FLOWMAP (Pass-1 blob b1481) and _HG_CLOUD_PROCEDRURALFLOW (b1483) warp the
                //   cloud UV before sampling (flow-map / procedural-flow distortion). Their pragmas + Toggle props
                //   exist but the UV-warp math is NOT yet implemented, so toggling them currently yields the static
                //   textured cloud (silent no-op warp). Read b1481/b1483 and branch the cloudUV build to restore.
                // equirect UV: longitude via atan2 polynomial (1479:96-101), latitude via asin (1479:102-105).
                float tanXZ = rayN.x / rayN.z;                                      // 1479:96
                bool small = abs(tanXZ) < 1.0;                                      // 1479:97
                float a = small ? abs(tanXZ) : (1.0 / abs(tanXZ));                  // 1479:98
                float a2 = a * a;                                                   // 1479:99
                float atanPoly = mad(mad(a2, 0.087292902171611785888671875, -0.3018949925899505615234375), a2, 1.0); // 1479:100
                float atanV = asfloat(small ? asuint(a * atanPoly) : asuint(mad((-0.0) - atanPoly, a, 1.57079637050628662109375))); // 1479:101
                float latPoly = mad(mad(abs(rayN.y), 0.04688780009746551513671875, -0.203471004962921142578125), abs(rayN.y), 1.57079601287841796875); // 1479:102
                float latSin = sqrt(((-0.0) - abs(rayN.y)) + 1.0);                  // 1479:103
                bool upper = rayN.y >= 0.0;                                         // 1479:104
                float lon = mad(mad(asfloat((rayN.x >= 0.0) ? 1078530010u : 3226013658u), asfloat(((rayN.z < 0.0) ? 4294967295u : 0u) & 1065353216u),
                                    (tanXZ < 0.0) ? ((-0.0) - atanV) : atanV), 0.159099996089935302734375, 0.5); // 1479:105 (longitude->u)
                float lat = mad(((-0.0) - asfloat(upper ? asuint(latSin * latPoly) : asuint(mad((-0.0) - latPoly, latSin, 3.1415927410125732421875))))
                              + 1.57079637050628662109375, 0.3183000087738037109375, 0.5);                         // 1479:105 (latitude->v)
                float2 cloudUV = float2(mad((-0.0) - _Globals_CloudFlowParam.w, 0.00277777784503996372222900390625, lon) + 1.0,
                                        mad(lat, 2.0, -1.0));                       // 1479:105 (scroll by flow time)
                float4 cloudTex = SAMPLE_TEXTURE2D_BIAS(_CloudMap, sampler_CloudMap, cloudUV, _GlobalMipBias.x); // 1479:105

                // contrast-remap RGB by CloudParam.y, opacity blend by CloudParam.x. (1479:106-117)
                float cAlphaTex = cloudTex.w;                                       // 1479:106 (_169 = coverage)
                float cr = mad(cloudTex.x + (-0.5), _Globals_CloudParam.y, 0.5);    // 1479:107
                float cg = mad(cloudTex.y + (-0.5), _Globals_CloudParam.y, 0.5);    // 1479:108
                float cb = mad(cloudTex.z + (-0.5), _Globals_CloudParam.y, 0.5);    // 1479:109
                float or_ = cr * _Globals_CloudOpacities.x;                         // 1479:110
                float og = cg * _Globals_CloudOpacities.y;                          // 1479:111
                float omax = max(og, or_);                                         // 1479:112 (_192)
                float3 cloudCol = float3(
                    mad(_Globals_CloudParam.x, mad((-0.0) - cr, _Globals_CloudOpacities.x, omax), or_) * _Globals_CloudTint.x,                          // 1479:113
                    mad(_Globals_CloudParam.x, mad((-0.0) - cg, _Globals_CloudOpacities.y, omax), og) * _Globals_CloudTint.y,                           // 1479:114
                    mad(_Globals_CloudParam.x, mad((-0.0) - cb, _Globals_CloudOpacities.z, omax), cb * _Globals_CloudOpacities.z) * _Globals_CloudTint.z); // 1479:115 (omax inner, cb*Opac.z outer)
                float upperGate = asfloat((upper ? 4294967295u : 0u) & 1065353216u); // 1479:116
                float outAlpha = clamp(upperGate * (mad(_Globals_CloudParam.x, mad((-0.0) - cAlphaTex, _Globals_CloudOpacities.w, omax), cAlphaTex * _Globals_CloudOpacities.w) * _Globals_CloudTint.w), 0.0, 1.0); // 1479:117 (textured coverage -> alpha)
                float3 color = cloudCol * upperGate;                               // 1479:179/183 composite passes cloudCol*upperGate (no sky)
            #else
                // ---- base (no-texture) cloud: flat hemisphere tint + alpha. (1477:93-103) ----
                float cMix = mad(_Globals_CloudParam.y, -0.5, 0.5);                 // 1477:93
                float c0 = cMix * _Globals_CloudOpacities.x;                        // 1477:94
                float c1 = cMix * _Globals_CloudOpacities.y;                        // 1477:95
                float c2 = cMix * _Globals_CloudOpacities.z;                        // 1477:96
                float czero = asfloat(0u);                                         // 1477:97 (= 0)
                float cmax = max(c1, c0);                                           // 1477:98
                float3 cloudCol = float3(
                    mad(_Globals_CloudParam.x, ((-0.0) - c0) + cmax, c0) * _Globals_CloudTint.x,
                    mad(_Globals_CloudParam.x, ((-0.0) - c1) + cmax, c1) * _Globals_CloudTint.y,
                    mad(_Globals_CloudParam.x, ((-0.0) - c2) + cmax, c2) * _Globals_CloudTint.z); // 1477:99-101
                float upperGate = asfloat(((rayN.y >= 0.0) ? 4294967295u : 0u) & 1065353216u); // 1477:102
                float outAlpha = clamp(upperGate * (mad(_Globals_CloudParam.x, ((-0.0) - czero) + cmax, czero) * _Globals_CloudTint.w), 0.0, 1.0); // 1477:103
                float3 color = cloudCol * upperGate;                               // (gated to upper hemisphere)
            #endif

                // ---- same 3-layer fog composite. (1477:104-171 / 1479 tail) ----
                float linearW = 1.0 / input.positionCS.w;                           // 1479:151-152 (= clip.w linear eye depth)
                float3 outRGB = ApplyHgFog(color, rayN, rayLen, input.worldDir, input.positionCS, linearW, _WorldSpaceCameraPos.y);
                return half4(outRGB, outAlpha);                                     // RT0 full RGBA; alpha = cloud coverage (1479:117)
            }
            ENDHLSL
        }

        // =====================================================================================
        // Pass 2 (source "ProceduralSkyRayTracing", LightMode-less, ZTest Equal, MRT0+MRT1 blend):
        //   HGRP ray-tracing reflection sky pass — re-runs the SAME sky math (blob 448/449) into the
        //   ray-tracing reflection target. No URP analog (URP has no RT reflection sky inject).
        //   DROPPED per STYLE_BIBLE (RayTracingReflection -> drop). See gaps.
        // =====================================================================================
    }

    Fallback Off
}
