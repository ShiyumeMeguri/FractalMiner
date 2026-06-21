// HGRP SkyDomeStarDrawer — procedural sky-dome planet / star / ring billboard drawer (single ForwardOnly pass).
// Merged from: skydomestardrawer.shader (HGRP/SkydomeStar) — base blob b5 + variant blobs b7 (TEXTURE_STAR_DRAW_MODE),
//   b9 (_SPHERICAL_MAPPING + DRAW_ATMOSPHERE), b11 (_SPHERICAL_MAPPING + DRAW_ATMOSPHERE + DRAW_RING),
//   vertex base b4 / variant b10.
// Keywords: _TEXTURE_STAR_DRAW_MODE, _SPHERICAL_MAPPING, _DRAW_ATMOSPHERE, _DRAW_RING
// Kept (1:1 from blobs): view-ray reconstruction (ortho/persp), ray-sphere planet intersection, spherical-UV longitude/latitude
//   via the rational atan/acos approximations, planet N.L lighting with sharpness + backface term, ring-plane intersection +
//   ring radial UV + ring/planet mutual shadowing, single-scatter atmosphere ray-march (outer scatter x inner light samples,
//   exp2 optical depth, Rayleigh 3/(16pi)(1+cos^2) phase), TEXTURE_STAR billboard alpha^2, VFX color-grade (desat+tint),
//   _AlphaPremultiply (CB[16].x) output-alpha gate, HDR _Color/_PlanetEmissive/_RingColorAlpha tints,
//   HG scene fog: atmosphere height-fog (mie/rayleigh halo) + exponential height-fog analytic integral (ApplyHgSceneFog).
// Removed (HGRP pipeline infra substituted by URP, pixel-neutral): GPU instancing/UnityPerDraw indexing, TAA jitter
//   (_TaaJitterStrength), camera-relative world offset (folded into standard world space),
//   _NonJitteredViewNoTransProjMatrix clip (TransformWorldToHClip), _GlobalMipBias mip-bias (dropped; plain sample), _FrameCount.
//
// NOTE: The planet/ring/star/atmosphere-HALO math IS the 1:1 obligation and is reproduced from the blobs verbatim.
//   HG scene fog: the TWO ANALYTIC layers (atmosphere height-fog + exponential height-fog, the _VolumetricFogParams0.z<=0
//   path) ARE reproduced 1:1 in ApplyHgSceneFog as `graded = scene*(expOpacity*atmoTransmit) + inscatter`. The HG
//   _Atmosphere/_ExponentialFogParams SRP-globals are re-exposed as material Vectors (STYLE_BIBLE infra rule; URP has no
//   global analog) and default to fog-OFF. The THIRD layer (Texture3D FROXEL volumetric fog, gated _VolumetricFogParams0.z>0)
//   is ENGINE-SIDE: it samples a froxel volume filled by a C# volumetric-fog injection compute pass -> left as TODO(1:1).
//
// _MainTex   = planet albedo (star body) / star billboard texture (TEXTURE_STAR mode).
// _EmissiveTex = planet self-emission (night-side glow).
// _RingTex   = ring band texture (sampled along ring radius; .w = ring alpha).

Shader "HGRP/SkyDomeStarDrawer_Fix"
{
    Properties
    {
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1, Premultiply, 4)] _BlendMode ("Blend Type", Float) = 1

        _MainTex ("Texture", 2D) = "white" {}
        _EmissiveTex ("Emissive Texture", 2D) = "black" {}
        _RingTex ("Ring Texture", 2D) = "white" {}

        [HDR] _Color ("Color and Alpha", Color) = (1, 1, 1, 1)
        _DrawScale ("Scale", Range(0, 5)) = 1
        _DrawRotation ("Rotation", Float) = 0

        [Toggle(_TEXTURE_STAR_DRAW_MODE)] _TextureStarDrawMode ("Texture Star Draw Mode", Float) = 0
        [Toggle(_SPHERICAL_MAPPING)] _SphericalMapping ("Unwrap Simulated UV Spherically", Float) = 1
        [Toggle(_DRAW_ATMOSPHERE)] _DrawAtmosphere ("Draw Atmosphere", Float) = 1
        [Toggle(_DRAW_RING)] _DrawRing ("Draw Ring", Float) = 0

        _StarNdlSharp ("Planet Light Transition Softness", Range(0, 10)) = 1
        _StarBackFaceAlpha ("Planet Back-Light Face Brightness", Range(0, 1)) = 0
        [HDR] _PlanetEmissive ("Planet Emissive", Color) = (1, 1, 1, 1)
        [HDR] _RingColorAlpha ("Ring Color and Alpha", Color) = (1, 1, 1, 1)
        _RingShadowSoftness ("Ring Shadow Softness", Range(0, 1)) = 0.1

        // --- procedural planet/atmosphere geometry (CB[0]..CB[8]); normally driven by a C# SkydomeStar component ---
        // CB[0] PlanetAtmosphereParams : x=AtmosphereRadius y=ScatterSampleCount z=DensityScale w=PlanetRadius
        [HideInInspector] _PlanetAtmosphereParams  ("PlanetAtmosphereParams (x=AtmoR y=ScatterSamples z=DensityScale w=PlanetR)", Vector) = (1.05, 8, 1, 1)
        // CB[1] PlanetAtmosphereParams2 : x=LightSampleCount y=DensityFalloff z=ScatterIntensity w=PhaseBias
        [HideInInspector] _PlanetAtmosphereParams2 ("PlanetAtmosphereParams2 (x=LightSamples y=DensityFalloff z=Intensity w=PhaseBias)", Vector) = (4, 1, 1, 0)
        // CB[2] PlanetAtmosphereParams3 : y=AtmoColorScale w=BackFaceAlpha(=_StarBackFaceAlpha)
        [HideInInspector] _PlanetAtmosphereParams3 ("PlanetAtmosphereParams3 (y=AtmoColorScale w=BackFaceAlpha)", Vector) = (1, 1, 1, 0)
        // CB[3] PlanetCenterDir : xyz = direction from camera to planet center (unit), used as sphere ray-origin->center
        [HideInInspector] _PlanetCenterViewDir ("PlanetCenterDir (xyz)", Vector) = (0, 0, 1, 0)
        // CB[4] IncidentLightDir : xyz = light direction towards planet
        [HideInInspector] _IncidentLightDir ("IncidentLightDir (xyz)", Vector) = (0, 0, -1, 0)
        // CB[5] PlanetParams : x=cosPlanetAngularRadius y=NdlSharpScale z=RingInnerRcp w=RingOffset
        [HideInInspector] _PlanetParams ("PlanetParams (x=cosR y=NdlSharp z=RingInnerRcp w=RingOffset)", Vector) = (0.999, 1, 1, 0)
        [HideInInspector] _PlanetUpWs      ("PlanetUpWs (xyz)",      Vector) = (0, 1, 0, 0)
        [HideInInspector] _PlanetForwardWs ("PlanetForwardWs (xyz)", Vector) = (0, 0, 1, 0)
        [HideInInspector] _PlanetRightWs   ("PlanetRightWs (xyz)",   Vector) = (1, 0, 0, 0)
        // CB[11] : z = ring shadow softness denominator ; CB[15] : x,y = N.L transition (from _StarNdlSharp)
        [HideInInspector] _RingShadowParams ("RingShadowParams (z=softnessDenom)", Vector) = (0, 0, 0.1, 0)
        [HideInInspector] _StarNdlTransform ("StarNdlTransform (x=scale y=bias)", Vector) = (1, 0, 0, 0)

        // VFX color grade (CB186 = _VFXParams1 : xyz=tint w=saturation)
        [HideInInspector] _VFXParams1 ("VFX Color (xyz=tint w=saturation)", Vector) = (1, 1, 1, 1)
        // CB[16].x = premultiply-alpha-into-rgb gate (1=do not premultiply / output rgb as-is)
        [HideInInspector] _AlphaPremultiplyGate ("AlphaPremultiplyGate", Float) = 0

        // --- HG scene-fog SRP-globals re-exposed as material params (driven by a C# Sky/Fog component).
        //     Defaults = fog OFF (density 0 / exp params 0) so an un-bound material renders identically to no-fog. ---
        [HideInInspector] _AtmosphereFogParams0 ("AtmoFog0", Vector) = (0, 0, 0, 0)
        [HideInInspector] _AtmosphereFogParams1 ("AtmoFog1", Vector) = (0, 1, 0, 0)
        [HideInInspector] _AtmosphereFogParams2 ("AtmoFog2", Vector) = (0, 0, 0, 0)
        [HideInInspector] _AtmosphereFogParams3 ("AtmoFog3", Vector) = (0, 0, 0, 1)
        [HideInInspector] _AtmosphereFogParams4 ("AtmoFog4", Vector) = (0, 0, 0, 0)
        [HideInInspector] _AtmosphereFogParams5 ("AtmoFog5", Vector) = (0, 0, 0, 0)
        [HideInInspector] _ExponentialFogParams0 ("ExpFog0", Vector) = (0, 0, 1, 0)
        [HideInInspector] _ExponentialFogParams1 ("ExpFog1", Vector) = (0, 0, 0, 0)
        [HideInInspector] _ExponentialFogParams2 ("ExpFog2", Vector) = (0, 0, 0, 0)
        [HideInInspector] _ExponentialFogParams3 ("ExpFog3", Vector) = (1, 0, 0, 0)
        [HideInInspector] _ExponentialFogParams4 ("ExpFog4", Vector) = (0, 0, 0, 0)
        [HideInInspector] _ExponentialFogParams5 ("ExpFog5", Vector) = (0, 0, 0, 0)
        [HideInInspector] _VolumetricFogParams0 ("VolFog0 (.z gates froxel; engine-side)", Vector) = (0, 0, 0, 0)

        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 1
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 0
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 0
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
        }
        LOD 100

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

        CBUFFER_START(UnityPerMaterial)
            float4 _MainTex_ST;
            float4 _EmissiveTex_ST;
            float4 _RingTex_ST;
            float4 _Color;
            float  _DrawScale;
            float  _DrawRotation;
            float  _StarNdlSharp;
            float  _StarBackFaceAlpha;
            float4 _PlanetEmissive;
            float4 _RingColorAlpha;
            float  _RingShadowSoftness;

            // procedural geometry constants (CB[0..8,11,15])
            float4 _PlanetAtmosphereParams;     // CB[0]
            float4 _PlanetAtmosphereParams2;    // CB[1]
            float4 _PlanetAtmosphereParams3;    // CB[2]
            float4 _PlanetCenterViewDir;        // CB[3]
            float4 _IncidentLightDir;           // CB[4]
            float4 _PlanetParams;               // CB[5]
            float4 _PlanetUpWs;                 // CB[6]
            float4 _PlanetForwardWs;            // CB[7]
            float4 _PlanetRightWs;              // CB[8]
            float4 _RingShadowParams;           // CB[11]
            float4 _StarNdlTransform;           // CB[15]

            float4 _VFXParams1;                 // CB186
            float  _AlphaPremultiplyGate;       // CB[16].x

            // --- HG scene-fog SRP-globals, re-exposed as material uniforms (URP has no analog;
            //     STYLE_BIBLE: bespoke HG global -> material Vector, same as _CharacterParams/_ExposureParams).
            //     Driven by a C# Sky/Fog component. CB0[153..158]=atmosphere height-fog, CB0[159..164]=exponential fog. ---
            float4 _AtmosphereFogParams0;       // CB0[153]
            float4 _AtmosphereFogParams1;       // CB0[154] (.xyz=fog sun dir, .w=density)
            float4 _AtmosphereFogParams2;       // CB0[155] (.xyz=wavelength ext, .w=mie g)
            float4 _AtmosphereFogParams3;       // CB0[156] (.xyz=mie tint, .w=height falloff)
            float4 _AtmosphereFogParams4;       // CB0[157] (.xyz=mie scale, .w=base height)
            float4 _AtmosphereFogParams5;       // CB0[158] (.xyz=rayleigh tint, .w=height offset)
            float4 _ExponentialFogParams0;      // CB0[159]
            float4 _ExponentialFogParams1;      // CB0[160]
            float4 _ExponentialFogParams2;      // CB0[161]
            float4 _ExponentialFogParams3;      // CB0[162]
            float4 _ExponentialFogParams4;      // CB0[163]
            float4 _ExponentialFogParams5;      // CB0[164]
            float4 _VolumetricFogParams0;       // CB0[165] (.z gates the froxel branch; ENGINE-SIDE)
        CBUFFER_END

        TEXTURE2D(_MainTex);     SAMPLER(sampler_MainTex);
        TEXTURE2D(_EmissiveTex); SAMPLER(sampler_EmissiveTex);
        TEXTURE2D(_RingTex);     SAMPLER(sampler_RingTex);

        // Rec.709 luma — blob: 0.21267290413379669189453125 / 0.715152204036712646484375 / 0.072175003588199615478515625
        static const float3 LUMA_709 = float3(0.2126729041337966919, 0.715152204036712646, 0.072175003588199615);
        // Rayleigh-ish phase normalization 3/(16*pi) — blob 0.0596831031143665313720703125 (b11:209, b5:163)
        static const float  INV_16PI3 = 0.0596831031143665313720703125;
        static const float  INV_2PI   = 0.15915493667125701904296875;   // 1/(2*pi)  (b11:106 longitude scale)
        // NOTE: prefixed STAR_ — URP Core.hlsl (Macros.hlsl) already #defines PI / HALF_PI as macros; reusing the
        //       bare names makes `static const float PI = ...` expand to `static const float 3.14159 = ...` (syntax error).
        static const float  STAR_PI      = 3.1415927410125732421875;    // (b11:106)
        static const float  STAR_HALF_PI = 1.570728778839111328125;     // acos-approx leading term (b11:105)

        // -------------------------------------------------------------------------------------------------
        // Spherical-UV longitude. The decompiler fuses an acos(|cosLon|) rational approximation with the
        // sin -> longitude -> [0,1] map into one expression; reproduced 1:1 from b11:102-106 / b9:107-111.
        //   acos-poly: 1.570728778839 + |x|*(-0.212114393711 + |x|*(0.074261002242 + |x|*(-0.018729299306)))
        //              then * sqrt(1-|x|)  (standard Nvidia/Sebastien-Lagarde acos fit).
        //   cosLon  = dot(dirOnPlane, planetForward)   [_308 / _235]
        //   axisSign= sign(dot(dirOnPlane, planetRight)) [_298 / _225]
        // -------------------------------------------------------------------------------------------------
        float SphericalLongitudeU(float cosLon, float axisSign)
        {
            float ax = abs(cosLon);
            float poly = mad(mad(mad(ax, -0.0187292993068695068, 0.074261002242565155),
                                 ax, -0.212114393711090088),
                             ax, STAR_HALF_PI);                             // b11:105
            float s = poly * sqrt(1.0 - ax);                               // b11:104 sqrt(1-|cosLon|)
            // (cosLon<0) ? (pi - 2*s) : s  — selects the back hemisphere   (b11:106)
            float back = (cosLon < -cosLon) ? mad(s, -2.0, STAR_PI) : 0.0;
            float angle = mad(s, 1.0, back);   // s + back  == s for front, pi-s for back
            // U = axisSign * angle / (2*pi) + clamp(-axisSign,0,1)         (b11:106)
            return mad(axisSign * angle, INV_2PI, clamp(-axisSign, 0.0, 1.0));
        }

        struct Attributes
        {
            float3 positionOS : POSITION;
            float2 uv         : TEXCOORD0;
        };

        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float3 positionWS : TEXCOORD0;   // blob TEXCOORD_1 : world position of the dome vertex
            float2 uv         : TEXCOORD1;   // blob TEXCOORD_1_1
        };

        // =================================================================================================
        // VERTEX  (blob b4 base / b10 variant)
        //   world pos = TransformObjectToWorld(posOS)  (blob _85..87 = ObjectToWorld*pos, camera-relative removed)
        //   clip      = TransformWorldToHClip(worldPos) (blob used _NonJitteredViewNoTransProjMatrix + TAA jitter; dropped)
        //   uv: base b4 swizzles (-tex.y, tex.x); spherical b10 applies _MainTex_ST. We apply _MainTex_ST and keep the
        //       base swizzle behind the keyword so both variants are 1:1.
        // =================================================================================================
        Varyings Vert(Attributes input)
        {
            Varyings output = (Varyings)0;
            VertexPositionInputs posInputs = GetVertexPositionInputs(input.positionOS);
            output.positionWS = posInputs.positionWS;
            output.positionCS = posInputs.positionCS;

        #if defined(_SPHERICAL_MAPPING) || defined(_DRAW_ATMOSPHERE) || defined(_DRAW_RING)
            // b10:67-68 : uv = tex.xy * _MainTex_ST.xy + _MainTex_ST.zw
            output.uv = mad(input.uv, _MainTex_ST.xy, _MainTex_ST.zw);
        #else
            // b4:57-58 : uv = (-tex.y, tex.x)   (90-degree rotated, no tiling)
            output.uv = float2(input.uv.y * -1.0, input.uv.x);
        #endif
            return output;
        }

        // =================================================================================================
        // Per-pixel view ray (shared by all fragment variants, blob b5:80-86 / b9:85-91 / b11:69-75).
        //   rayDir = normalize(positionWS - cameraPos)  — branch-free (identical in ortho & persp in the blob).
        // (The blob ALSO reconstructs an ortho/persp `viewDir` (_109..111) + `viewDirLen` (_112) that feed the HG
        //  scene-fog dot products / distance term; those are reconstructed faithfully in ComputeViewVec below.)
        // =================================================================================================
        float3 ComputeRayDir(float3 positionWS)
        {
            float3 rd = positionWS - _WorldSpaceCameraPos;                           // _127..129
            return rd * rsqrt(dot(rd, rd));                                          // _135/_134/_136
        }

        // =================================================================================================
        // Ortho/persp view vector toward the camera + its length (blob b5:70-86 / b7 / b9 / b11:53-68).
        //   persp (orthoParams.w==0): viewVec = cameraPos - positionWS  (_97/_99/_101)
        //   ortho                   : viewVec = camera forward = _ViewMatrix[*].z = UNITY_MATRIX_V row2 (._m20.._m22)
        //   viewDirN = normalize(viewVec) (_109..111);  viewLen = |viewVec| (_112) = dot/rsqrt fused.
        // Feeds ONLY the HG scene-fog dot products / distance term (planet/ring/star use ComputeRayDir).
        // =================================================================================================
        void ComputeViewVec(float3 positionWS, out float3 viewDirN, out float viewLen)
        {
            bool persp = (unity_OrthoParams.w == 0.0);                               // _53 / _62
            // _ViewMatrix[i].z (column-major) == UNITY_MATRIX_V row 2 = (._m20,._m21,._m22)
            float3 camFwd = float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22);
            float3 viewVec = persp ? (_WorldSpaceCameraPos - positionWS) : camFwd;   // _97/_99/_101
            float lenSq = dot(viewVec, viewVec);                                      // _102
            float invLen = rsqrt(max(lenSq, 9.9999999392252902907785028219223e-09f));// _108
            viewDirN = viewVec * invLen;                                             // _109..111
            viewLen = lenSq * invLen;                                               // _112 (= |viewVec|)
        }

        // =================================================================================================
        // HG scene fog — ANALYTIC layers ported 1:1 (atmosphere height-fog + exponential height-fog).
        //   blob b5:100-106,145-169 / b7:95,135-161 / b9 / b11:253-322 (the _VolumetricFogParams0.z<=0 path).
        // Composites the already-graded color as:  graded*(expFogOpacity*atmoTransmit) + inscatter ,
        //   inscatter = (1-CB16.x) * ( atmoHalo*(1-atmoTransmit)*expFogOpacity + expFogInscatter ).
        // The third layer (Texture3D FROXEL volumetric fog, gated by _VolumetricFogParams0.z>0) is ENGINE-SIDE:
        //   it samples a froxel volume filled by a C# volumetric-fog injection compute pass (no material-side
        //   equivalent), so only the analytic else-branch is reproduced here. See TODO(1:1) below.
        // exp2(x*1.44269502...) == exp(x);  exp2(x*-1.44269502...) == exp(-x).  log2e = 1.44269502162933349609375.
        // =================================================================================================
        float3 ApplyHgSceneFog(float3 graded, float3 positionWS, float3 viewDirN, float viewLen)
        {
            // ---- Exponential height-fog, analytic (no froxel). blob b5:145-159 (_VolumetricFogParams0.z<=0 else) ----
            float camY = _WorldSpaceCameraPos.y;                                                  // CB0[44].y
            // _128 = TEXCOORD.y - camY = (dome vertex world Y) - (camera world Y)  [b5:81; vertex blob b4:49-51 re-adds
            //   camPos so TEXCOORD is ABSOLUTE world]. _663/_664 integrate fog over this vertical delta, NOT bare camY.
            float posMinusCamY = positionWS.y - camY;                                              // _128 (b5:81)
            float _663 = max(posMinusCamY * _ExponentialFogParams0.z, -127.0);                     // b5:147 (_128*EFP0.z)
            float _664 = max(posMinusCamY * _ExponentialFogParams3.x, -127.0);                     // b5:148 (_128*EFP3.x)
            // analytic transmittance-integral coefficient (two fog modes summed). blob b5:149.
            float _730 = mad(exp2(-max((camY - _ExponentialFogParams0.x) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                             asfloat((5.9604644775390625e-08 < abs(_663)) ? asuint((1.0 - exp2(-_663)) / _663) : asuint(mad(-_663, 0.2402265071868896484375, 0.693147182464599609375))),
                             asfloat((5.9604644775390625e-08 < abs(_664)) ? asuint((1.0 - exp2(-_664)) / _664) : asuint(mad(-_664, 0.2402265071868896484375, 0.693147182464599609375)))
                             * (exp2(-max((camY - _ExponentialFogParams3.z) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y));
            float _741 = clamp(mad(viewLen, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0); // b5:150
            // expFogOpacity (_807): base + distance term + start-distance term, clamped to 1. blob b5:151.
            float expFogOpacity = min(_741 + (clamp(mad(viewLen, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                                   + max(min(exp2(-(viewLen * _730)), 1.0), _ExponentialFogParams2.w)), 1.0);
            float _755 = 1.0 - expFogOpacity;                                                       // b5:152
            // directional in-scatter tint (sun-facing gradient ^ exponent). blob b5:153.
            float _770 = exp2(log2(clamp(dot(viewDirN, _ExponentialFogParams4.xyz), 0.0, 1.0)) * _ExponentialFogParams5.w);
            float _790 = 1.0 - min(exp2(-(max(viewLen - _ExponentialFogParams4.w, 0.0) * _730)), 1.0); // b5:154 (_102*_108=viewLen, _323=1 in else)
            float _795 = 1.0 - _741;                                                                // b5:155
            // expFog inscatter color (_808..810): const term + directional term. blob b5:157-159.
            float3 expFogInscatter = float3(
                mad(_ExponentialFogParams2.x, _755, _795 * (_790 * (_770 * _ExponentialFogParams5.x))),
                mad(_ExponentialFogParams2.y, _755, _795 * (_790 * (_770 * _ExponentialFogParams5.y))),
                mad(_ExponentialFogParams2.z, _755, _795 * (_790 * (_770 * _ExponentialFogParams5.z))));

            // ---- Atmosphere height-fog (mie/rayleigh halo). blob b5:100-106,163-169 ----
            // _317: height-integrated optical depth scaled by -(view-len projected density). blob b5:100-101.
            float posY = positionWS.y;                                   // TEXCOORD.y in blob (dome vertex world Y)
            float _283 = max(mad(posY, _AtmosphereFogParams3.w, _AtmosphereFogParams4.w), 0.00999999977648258209228515625);
            // blob exp2(x*+-1.44269502...) == exp(+-x) (natural). The *1.44269502... (log2e) factors are LOAD-BEARING:
            //   (1-e^-_283)/_283 * e^(posY*AFP3.w+AFP5.w), NOT base-2 exp2(-_283)/exp2(...).  (b5:101)
            float _317 = (((1.0 - exp2(-_283 * 1.44269502162933349609375)) / _283)
                          * exp2(mad(posY, _AtmosphereFogParams3.w, _AtmosphereFogParams5.w) * 1.44269502162933349609375))
                         * (-max(mad(viewLen, _AtmosphereFogParams1.w, -_AtmosphereFogParams0.w), 0.0));
            // atmosphere transmittance per wavelength (_330..332). blob b5:102-104.
            //   exp2((_317*AFP2.c)*1.44269502...) == exp(_317*AFP2.c); the log2e factor is required (natural exp, not 2^x).
            float3 atmoTransmit = float3(exp2((_317 * _AtmosphereFogParams2.x) * 1.44269502162933349609375),
                                         exp2((_317 * _AtmosphereFogParams2.y) * 1.44269502162933349609375),
                                         exp2((_317 * _AtmosphereFogParams2.z) * 1.44269502162933349609375));
            // mie/rayleigh phase halo around the fog sun (_341/_358/_840/_869). blob b5:105-106,163-164.
            float _341 = dot(-viewDirN, _AtmosphereFogParams1.xyz);
            float _358 = mad(_AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0) - dot(_341.xx, _AtmosphereFogParams2.w.xx);
            float _840 = mad(_341, _341, 1.0) * 0.0596831031143665313720703125;       // (1+cos^2)*3/16pi
            float _869 = mad(-_AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0)
                         / max((_358 * 12.56637096405029296875) * sqrt(_358), 0.001000000047497451305389404296875);
            // atmosphere inscatter color (_167 inner haloX..Z): clamp(mie*_869 + rayleigh*_840 + base,0,1)*255. blob b5:167-169.
            float3 atmoHalo = clamp(mad(_AtmosphereFogParams4.xyz, _869.xxx, mad(_AtmosphereFogParams3.xyz, _840.xxx, _AtmosphereFogParams5.xyz)), 0.0, 1.0) * 255.0;

            // ---- Composite (blob b5:167-169 mad structure, gate _914 applied by caller). ----
            // out = graded*(expFogOpacity*atmoTransmit) + (1-CB16.x)*( atmoHalo*(1-atmoTransmit)*expFogOpacity + expFogInscatter )
            float inscatterGate = 1.0 - _AlphaPremultiplyGate;                                      // _901 = 1 - CB16.x
            float3 transmit = expFogOpacity.xxx * atmoTransmit;
            float3 inscatter = inscatterGate * (mad(atmoHalo * (1.0 - atmoTransmit), expFogOpacity.xxx, expFogInscatter));
            return mad(graded, transmit, inscatter);

            // TODO(1:1) ENGINE-SIDE: Texture3D froxel VOLUMETRIC fog branch (blob b5:111-144 / b7:100-133 / b11:264-296,
            //   `if (0 < _VolumetricFogParams0.z)`). It blue-noise-jitters a screen ray and samples T0 = Texture3D froxel
            //   volume (`T0.SampleLevel(...)`) whose contents are produced by a C# volumetric-fog INJECTION compute pass
            //   (Frostbite-style froxel grid). A material shader cannot fill that volume, so it is the ONE legitimately
            //   engine-side layer. To restore it: a URP ScriptableRendererFeature must run the froxel-injection compute
            //   and bind the resulting Texture3D as _HgVolumetricFogTex, then this function samples it and blends per
            //   blob b5:140-143. Until that host pass exists, only the analytic layers above are reproduced.
        }

        // =================================================================================================
        // VFX color-grade + scene fog + premultiply gate + output alpha
        //   (blob b5:161-170 / b7:152-161 / b9:310-319 / b11:314-323).
        //   grade(c)   = lerp(luma, c, _VFXParams1.w) * _VFXParams1.xyz   (desaturate then tint)  (_811/_154..156)
        //   fog        = ApplyHgSceneFog(graded, positionWS, viewDirN, viewLen)   (1:1 analytic; froxel engine-side)
        //   premulGate = (CB[16].x==0) ? alpha : 1.0   -> multiplies whole rgb                     (_914/_830/_1585)
        // =================================================================================================
        float4 GradeAndOutput(float3 color, float alpha, float3 positionWS, float3 viewDirN, float viewLen)
        {
            float luma = dot(color, LUMA_709);                                       // _811 / _1484
            float3 graded = mad(_VFXParams1.w, color - luma, luma) * _VFXParams1.xyz;// _154..156,_724 form

            graded = ApplyHgSceneFog(graded, positionWS, viewDirN, viewLen);         // _807/_330 transmit + inscatter

            float gate = (_AlphaPremultiplyGate == 0.0) ? alpha : 1.0;               // _914 / _830 / _1585
            graded *= gate;

            return float4(graded, alpha);
        }
        ENDHLSL

        Pass
        {
            Name "SkydomeStar"
            Tags { "LightMode" = "UniversalForwardOnly" }

            Blend [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend]
            ZWrite Off
            ZTest LEqual
            Cull Off

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex Vert
            #pragma fragment Frag

            #pragma shader_feature_local _TEXTURE_STAR_DRAW_MODE
            #pragma shader_feature_local _SPHERICAL_MAPPING
            #pragma shader_feature_local _DRAW_ATMOSPHERE
            #pragma shader_feature_local _DRAW_RING

            // ============================================================================================
            // Single-scatter atmosphere ray-march (blob b9:134-225 / b11:139-229, DRAW_ATMOSPHERE path).
            //   Outer loop: N=PlanetAtmosphereParams.y scatter samples between near/far atmosphere hits.
            //   Inner loop: M=PlanetAtmosphereParams2.x light samples from each scatter point toward the sun,
            //               accumulating optical depth; transmittance = exp2(-tau * waveScale * log2(e)).
            //   Wavelength density coeffs (b9:155-157 / b11:159-161):
            //     R: 0.000244140625 * DensityScale  (= 1/4096 * z)
            //     G: 0.001267349696718156 * DensityScale
            //     B: 0.00266802101396024 * DensityScale
            //   Phase = (1 + cosTheta^2) * 3/(16*pi)  (b9:205 / b11:209).
            //   Returns the three accumulated scatter channels (already * density coeff).
            // ============================================================================================
            float3 RaymarchAtmosphere(float3 rayDir)
            {
                float3 inscatter = 0.0;

                float atmoR   = _PlanetAtmosphereParams.x + _PlanetAtmosphereParams.w; // _589/_363 = CB[0].x + CB[0].w
                // planet world center = object origin. Blob b9 uses _unity_ObjectToWorld[3]; b11 uses _ViewMatrix[3]
                // (= world origin in HGRP camera-relative space). In URP non-camera-relative world space, both reduce
                // to the object origin -> URP `unity_ObjectToWorld._m03_m13_m23` (STYLE_BIBLE: object origin XZ/Y substitution).
                float3 planetCenter = unity_ObjectToWorld._m03_m13_m23;
                float3 toCenter = _WorldSpaceCameraPos - planetCenter;                 // _386..388 / _612..614

                float b = dot(rayDir, toCenter);                                       // _615 / _389
                float c2 = dot(toCenter, toCenter);                                     // _618 / _392
                float discOuter = mad(b, b, -mad(-atmoR, atmoR, c2));                   // _624 / _398
                if (discOuter <= 0.0)
                    return inscatter;

                float sq = sqrt(discOuter);                                             // _626
                float nearT = max(-b - sq, 0.0);                                        // _630 / _404
                float farSpan = (-b + sq) - nearT;                                      // _634 / _430

                // planet-surface occlusion of the atmosphere segment (b11:144-147 / b9:138-143)
                float discPlanet = mad(b, b, -mad(-_PlanetAtmosphereParams.w, _PlanetAtmosphereParams.w, c2));
                bool hitPlanet = (0.0 < discPlanet);
                float planetEntry = hitPlanet ? max(-b - sqrt(discPlanet), 0.0) : 0.0; // _654 / _426
                float span = hitPlanet ? ((planetEntry > 0.0) ? min(-nearT + planetEntry, farSpan) : farSpan) : farSpan; // _664/_437
                if (span <= 0.0)
                    return inscatter;

                float3 lightDir = _IncidentLightDir.xyz * rsqrt(max(dot(_IncidentLightDir.xyz, _IncidentLightDir.xyz), 1.1754943508222875079687365372222e-38f)); // _683..691
                float scatterCount = _PlanetAtmosphereParams.y;                        // CB[0].y
                float stepLen = span / scatterCount;                                   // _695 / _468
                float cosSun = dot(-rayDir, lightDir);                                 // _699 / _472

                float densR = 0.000244140625 * _PlanetAtmosphereParams.z;              // _705 (1/4096 * z)
                float densG = 0.001267349696718156337738037109375 * _PlanetAtmosphereParams.z; // _707
                float densB = 0.00266802101396024227142333984375 * _PlanetAtmosphereParams.z;  // _709

                float3 samplePos = mad(rayDir * stepLen, 0.5, mad(rayDir, nearT, _WorldSpaceCameraPos)); // _722..725
                float invSurfR = 1.0 / _PlanetAtmosphereParams.x;                      // _729 (1/CB[0].x)
                float3 halfLight = lightDir * 0.5;                                     // _730..732

                float accumOptical = 0.0;   // _947  running outer optical-depth integral
                float3 transmit = 0.0;      // _957/_959/_961  accumulated transmittance*density per wavelength

                [loop]
                for (float i = 0.0; i < scatterCount; i += 1.0)
                {
                    float3 rel = samplePos - planetCenter;                             // _1428..1430
                    float relSq = dot(rel, rel);
                    // local density at sample: stepLen * exp2(-(1/surfR)*(|rel|-planetR) * densityFalloff * log2e)
                    float density = min(stepLen * exp2((-(invSurfR * (sqrt(relSq) - _PlanetAtmosphereParams.w))
                                        * _PlanetAtmosphereParams2.y) * 1.44269502162933349609375), 3.4028234663852885981170418348452e+38f); // _1449 (b11:188)

                    // inner: distance from this sample to the atmosphere boundary along the sun (b11:190-193)
                    float lb = dot(lightDir, rel);                                     // _1451
                    float ldisc = mad(lb, lb, -mad(-atmoR, atmoR, relSq));             // _1457
                    float lspan = (ldisc > 0.0) ? ((sqrt(ldisc) - lb) - max(-sqrt(ldisc) - lb, 0.0)) : 0.0; // _1475
                    float lightSampleCount = _PlanetAtmosphereParams2.x;              // CB[1].x
                    lspan /= lightSampleCount;                                         // _1475 /= CB[1].x

                    // inner light-march optical depth (b11:205 / b9:201)
                    float lightOptical = 0.0;
                    float3 lpos = mad(halfLight, lspan, samplePos);                    // _1476..1478
                    [loop]
                    for (uint j = 0u; (float)j < lightSampleCount; j++)
                    {
                        float3 lrel = lpos - planetCenter;                            // _1629..1631
                        lightOptical += exp2((-(invSurfR * max(sqrt(dot(lrel, lrel)) - _PlanetAtmosphereParams.w, 0.0)) * _PlanetAtmosphereParams2.y) * 1.44269502162933349609375);
                        lpos = mad(lightDir, lspan, lpos);
                    }

                    // _948 = accumOptical + density (this sample); totalOptical = innerOptical*lspan + _948 (b11:182,189)
                    accumOptical += density;                                            // _947 = _948
                    float totalOptical = mad(lightOptical, lspan, accumOptical);        // _1609
                    transmit.x = mad(exp2((totalOptical * densR) * -1.44269502162933349609375), density, transmit.x); // _957
                    transmit.y = mad(exp2((totalOptical * densG) * -1.44269502162933349609375), density, transmit.y); // _959
                    transmit.z = mad(exp2((totalOptical * densB) * -1.44269502162933349609375), density, transmit.z); // _961
                    samplePos = mad(rayDir, stepLen, samplePos);                        // _951..955 += rayDir*stepLen
                }

                float phase = mad(cosSun, cosSun, 1.0) * INV_16PI3;                    // _1415 (1+cos^2)*3/16pi
                inscatter.x = densR * (phase * transmit.x);                            // _742
                inscatter.y = densG * (phase * transmit.y);                            // _744
                inscatter.z = densB * (phase * transmit.z);                            // _746
                return inscatter;
            }

            // Tonemap-ish HSV recolor of the atmosphere scatter (blob b9:226-245 / b11:230-249).
            // Sorts the 3 scatter channels (max/mid/min), reconstructs hue via the standard frac()-triangle wheel,
            // multiplies value back. (1:1 with the _529/_550 select + _604..606 wheel.)
            float3 AtmosphereRecolor(float3 scatter)
            {
                float3 s = scatter * _PlanetAtmosphereParams2.z;                       // *CB[1].z  (_750..752)
                // first compare g vs b (b9:229-232 / b11:233-236)
                float sel0 = (s.y >= s.z) ? 1.0 : 0.0;                                // _756 (G>=B)
                float p_x = mad(sel0, s.y - s.z, s.z);                                // _770 = max(G,B)
                float p_y = mad(sel0, s.z - s.y, s.y);                                // _771 = min(G,B)
                float p_w = mad(sel0, -1.0, 0.6666666865348816);                      // _546/_773 (=0.6667 - sel0)
                // then compare r vs the running max
                float sel1 = (s.x >= p_x) ? 1.0 : 0.0;                                // _777 (R>=max(G,B))
                float maxc = mad(sel1, s.x - p_x, p_x);                               // _786 = max(R,G,B)
                float midc = p_y;                                                      // _787 = min(G,B) (passthrough)
                float minc = mad(sel1, p_x - s.x, s.x);                               // _789 = sel1?max(G,B):R
                float chroma = maxc - min(midc, minc);                                // _565/_792
                float hue = abs((minc - midc) / mad(chroma, 6.0, 9.9999997473787516355514526367188e-05)
                            + mad(sel1, mad(sel0, 1.0, -1.0) - p_w, p_w)) + _PlanetAtmosphereParams2.w; // _577/_804 ( (_789-_787)/.. + CB[1].w )
                float sat = chroma / (maxc + 9.9999997473787516355514526367188e-05);  // _600/_827
                float3 wheel = float3(
                    mad(sat, clamp(abs(mad(frac(hue + 1.0),                       6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0),
                    mad(sat, clamp(abs(mad(frac(hue + 0.6666666865348816),        6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0),
                    mad(sat, clamp(abs(mad(frac(hue + 0.3333333432674407958984375), 6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0)); // _604..606
                return maxc * wheel;                                                   // value * hue-wheel
            }

            float4 Frag(Varyings input) : SV_Target
            {
                float3 rayDir = ComputeRayDir(input.positionWS);
                float3 viewDirN; float viewLen;
                ComputeViewVec(input.positionWS, viewDirN, viewLen);   // ortho/persp view vec for HG scene fog

            #if defined(_TEXTURE_STAR_DRAW_MODE)
                // ----- billboard star texture path (blob b7:78-161) -----
                float4 tex = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, input.uv);    // _119
                float3 col = tex.rgb * _Color.rgb;                                     // _132..134 (CB[10]=_Color)
                float a = tex.a * _Color.a;                                            // _135
                float alpha = a * a;                                                   // _139  alpha^2 self-occlusion
                return GradeAndOutput(col, alpha, input.positionWS, viewDirN, viewLen);
            #else
                // ----- procedural planet path (blob b5 base / b9 / b11) -----
                // Ray-sphere intersection against the planet (b11:76-78 / b5:87-92).
                float bb = dot(rayDir, _PlanetCenterViewDir.xyz);                      // _152 / _143
                float disc = mad(bb, bb, mad(_PlanetParams.x, _PlanetParams.x, -1.0)); // _164 / _155 ( b^2 + cos^2 - 1 )
                bool hit = (0.0 < disc);                                               // _186
                float hitMask = asfloat((hit ? 0xFFFFFFFFu : 0u) & 0x3F800000u);       // _191 / _243  (1.0 if hit)
                float tHit = bb - sqrt(max(disc, 0.0));                                // _168 / _188

                // surface point in planet-centered, radius-normalized space (b11:79-81)
                float3 surf = float3(mad(rayDir.x, tHit, -_PlanetCenterViewDir.x),
                                     mad(rayDir.y, tHit, -_PlanetCenterViewDir.y),
                                     mad(rayDir.z, tHit, -_PlanetCenterViewDir.z)) / _PlanetParams.x;

            #if defined(_SPHERICAL_MAPPING)
                // ----- spherical UV unwrap (b11:93-107 / b9:98-112) -----
                // project surface point onto the plane perpendicular to PlanetUp, normalize -> dirOnPlane (latitude basis)
                float upDot = dot(surf, _PlanetUpWs.xyz);                              // _262 / _188
                float3 onPlane = float3(mad(-_PlanetUpWs.x, upDot, surf.x),
                                        mad(-_PlanetUpWs.y, upDot, surf.y),
                                        mad(-_PlanetUpWs.z, upDot, surf.z));           // _273..275
                onPlane *= rsqrt(dot(onPlane, onPlane));                               // _280..282

                float lonCos  = dot(onPlane, _PlanetForwardWs.xyz);                    // _308 (cos longitude)
                float lonSign = sign(dot(onPlane, _PlanetRightWs.xyz));               // _289/_298 sign(dot right)
                float u = SphericalLongitudeU(lonCos, lonSign);                        // _337
                // latitude v from the up-projection (b11:107): rational of upDot
                float v = mad(mad(upDot * upDot, -0.22222222387790679931640625, -0.27777779102325439453125),
                              -upDot, 0.500000059604644775390625);                     // _344 / _271
                float2 planetUV = float2(u, v);
            #endif

                // N.L lighting with sharpness transition (b11:109 / b5:93 / b9:115)
                //   ndl = saturate( saturate(dot(lightDir, surf)) * CB[15].x + CB[15].y )
                float ndl = clamp(mad(clamp(dot(_IncidentLightDir.xyz, surf), 0.0, 1.0),
                                      _StarNdlTransform.x, _StarNdlTransform.y), 0.0, 1.0); // _375 / _225
                // planet front/back-face alpha term (b5:98 / b11:123): mad(backFaceAlpha, saturate(rayDir.y)-1, 1)
                float faceAlpha = mad(_PlanetAtmosphereParams3.w, clamp(rayDir.y, 0.0, 1.0) - 1.0, 1.0); // _267/_567 (CB[2].w)

                float3 color;
                float  planetAlpha;

            #if defined(_SPHERICAL_MAPPING)
                // ===== spherical planet: T1=_MainTex albedo, T2=_EmissiveTex (b9/b11) =====
                float4 albedoTex   = SAMPLE_TEXTURE2D(_MainTex,     sampler_MainTex,     planetUV); // _352
                float4 emissiveTex = SAMPLE_TEXTURE2D(_EmissiveTex, sampler_EmissiveTex, planetUV); // _380
                // body = albedo*ndl + emissive*_PlanetEmissive   (b9:246 / b11:250 inner mad)
                float3 planetBody = mad(albedoTex.rgb, ndl.xxx, emissiveTex.rgb * _PlanetEmissive.rgb);

                #if defined(_DRAW_RING)
                    // ----- ring plane intersection + radial sampling (b11:84-122, T3=_RingTex) -----
                    float planeT = abs(dot(_PlanetUpWs.xyz, _PlanetCenterViewDir.xyz)) / abs(dot(_PlanetUpWs.xyz, rayDir)); // _216
                    float3 ringHit = float3(mad(rayDir.x, planeT, -_PlanetCenterViewDir.x),
                                            mad(rayDir.y, planeT, -_PlanetCenterViewDir.y),
                                            mad(rayDir.z, planeT, -_PlanetCenterViewDir.z)); // _225..227
                    float ringDist = sqrt(dot(ringHit, ringHit));                          // _231
                    float3 ringDir = ringHit / ringDist;                                   // _232..234
                    // ring radial V (b11:92): (ringDist * planeValid) * RingInnerRcp + RingOffset
                    float planeValid = asfloat(((abs(dot(_PlanetUpWs.xyz, ringHit)) < 0.001) ? 0xFFFFFFFFu : 0u) & 0x3F800000u);
                    float ringRadialV = mad(ringDist * planeValid, _PlanetParams.z, _PlanetParams.w); // _256
                    // ring longitude via same atan polynomial on ring direction (b11:114-120)
                    float ringLonCos  = dot(ringDir, _PlanetForwardWs.xyz);                // _461 (CB[7]=Forward)
                    float ringLonSign = sign(dot(ringDir, _PlanetRightWs.xyz));           // _434/_443 (CB[8]=Right)
                    float ringU = SphericalLongitudeU(ringLonCos, ringLonSign);
                    float4 ringTex = SAMPLE_TEXTURE2D(_RingTex, sampler_RingTex, float2(ringU, ringRadialV)); // _489 (T3)

                    // ring visibility: in front of planet & within radial band (b11:113)
                    float ringVis = mad(hitMask, clamp(sign(-dot(rayDir, ringDir)), 0.0, 1.0) - 1.0, 1.0)
                                    * clamp(sign(ringRadialV * clamp(1.0 - ringRadialV, 0.0, 1.0)), 0.0, 1.0); // _428
                    float ringNdl = clamp(-dot(_IncidentLightDir.xyz, ringDir), 0.0, 1.0);                     // _454
                    // ring self-shadow softness from grazing geometry (b11:121)
                    float ringShadow = (1.0 - clamp((mad(-ringDist, sqrt(mad(-ringNdl, ringNdl, 1.0)), _PlanetParams.x) * _PlanetParams.y) / _RingShadowParams.z + 1.0, 0.0, 1.0))
                                       * min(abs(dot(_IncidentLightDir.xyz, _PlanetUpWs.xyz)) + 0.4000000059604644775390625, 1.0); // _544
                    float ringAlpha = ringShadow * (ringTex.w * _RingColorAlpha.w);        // _548 (CB[12].w)

                    // body pre-faceAlpha (b11:250 inner): ( hitMask*planetBody*albedo.a + ringTerm ) * _Color
                    //   ringTerm = ringVis*(ringAlpha*(ringShadow*ringTex.rgb*_RingColorAlpha.rgb))   [_428*_548*_544*_489*CB12]
                    float3 bodyColored = mad((hitMask * albedoTex.w).xxx, planetBody,
                                ringVis * (ringAlpha * (ringShadow * (ringTex.rgb * _RingColorAlpha.rgb)))) * _Color.rgb;
                    // alpha (b11:124): _567 * ( ringVis*ringAlpha*(planet-not-hit) + hitMask*albedo.a ) * _Color.a
                    float planetNotHit = asfloat(hit ? 0u : 0x3F800000u);
                    planetAlpha = faceAlpha * (mad(ringVis * ringAlpha, planetNotHit, hitMask * albedoTex.w) * _Color.a); // _582
                #else
                    // body pre-faceAlpha (b9:246 inner): hitMask * planetBody * albedo.a * _Color
                    float3 bodyColored = (hitMask * albedoTex.w) * planetBody * _Color.rgb; // _625 inner
                    planetAlpha = faceAlpha * ((hitMask * albedoTex.w) * _Color.a);         // _356
                #endif

                // fuse atmosphere term + faceAlpha (b9:246 / b11:250 outer mad). atmoTerm is NOT * _Color.
            #if defined(_DRAW_ATMOSPHERE)
                float3 atmoCol = AtmosphereRecolor(RaymarchAtmosphere(rayDir)); // maxc*wheel  (_786*_831)
                // per-channel: maxc*wheel * (CB[2].y*(1-ndl) + ndl)   [b9:246 mad(CB[2].y, atmo-ndl*atmo, ndl*atmo)]
                float3 atmoTerm = atmoCol * (mad(_PlanetAtmosphereParams3.y, 1.0 - ndl, ndl));
                color = faceAlpha * (atmoTerm + bodyColored);   // _625 = _567*(atmoTerm + bodyColored)
            #else
                color = faceAlpha * bodyColored;                // spherical w/o atmosphere keyword (no dedicated blob)
            #endif
            #else
                // ===== base / non-spherical (b5): T1=_EmissiveTex (lit body), T2=_RingTex (added emissive) =====
                // body.rgb = emissive.a * hitMask * ( emissive.rgb*ndl + ringTex.rgb*_PlanetEmissive ) * _Color
                float4 litTex  = SAMPLE_TEXTURE2D(_EmissiveTex, sampler_EmissiveTex, input.uv); // _166 (T1=_EmissiveTex)
                float4 addTex  = SAMPLE_TEXTURE2D(_RingTex,     sampler_RingTex,     input.uv); // _180 (T2=_RingTex)
                float litAlpha = litTex.w;                                                       // _171
                float3 body = mad(litTex.rgb, ndl.xxx, addTex.rgb * _PlanetEmissive.rgb);        // _166*_225 + _180*CB[13]
                color = (litAlpha * (hitMask * body)) * _Color.rgb;                              // _258..260 (* CB[10])
                planetAlpha = faceAlpha * ((hitMask * litAlpha) * _Color.a);                     // _271
            #endif

                // NOTE: the atmosphere single-scatter halo is fused inside the _SPHERICAL_MAPPING branch
                // (b9/b11 _625/_852). The base b5 path has no DRAW_ATMOSPHERE blob, so no atmosphere term here.
                return GradeAndOutput(color, planetAlpha, input.positionWS, viewDirN, viewLen);
            #endif
            }
            ENDHLSL
        }
    }

    Fallback Off
}
