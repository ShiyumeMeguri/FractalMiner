// HGRP Mesh Decal (Lit) — single screen-space DEFERRED G-buffer decal pass (depth-reconstructed,
//   procedural-shape-clipped, writes 5 deferred MRTs: emissive / dither-MV / metallic-AO-opacity /
//   octahedral-normal-roughness-opacity / albedo-opacity, via SrcAlpha,OneMinusSrcAlpha blending).
// Merged from: ReferenceProjects/RuriBeyondShader/.../materials/decal/decallit.shader (HGRP fork of HDRP).
//   Base ground truth : decallit/Sub0_Pass0_Vertex_b11.hlsl (catch-all #else, vertex)
//                      + decallit/Sub0_Pass0_Fragment_b12.hlsl (catch-all #else, fragment).
//   Keyword deltas inspected: Fragment_b14 (_COMPLETE_PBR, separate NRO map T2 + multi-channel metal/AO),
//     Fragment_b22 (_BLEND_EMISSIVE + _COMPLETE_PBR, SV_Target0 emissive + angle-blend channel mix),
//     Fragment_b26 (_BLEND_WATER_FLOW, dual flow-distorted normal taps + emissive-flag SV_Target1),
//     Fragment_b32 (_UV_ARC + _UV_NOISE, barrel-warp + noise-warp UV), Fragment_b16 (_NORMAL_ANGLE_BLEND:
//     base body + an opacity fade by exp2(log2(saturate(dot(decalAxis1,sceneNormal)))*_AngleBlendFallOff), b16:263).
//     _FOOT_PRINT (b20) is dropped (not exposed). Vertex is byte-identical across ALL variants.
// Keywords (exposed as shader_feature_local): _COMPLETE_PBR, _BLEND_EMISSIVE, _BLEND_WATER_FLOW, _UV_ARC, _UV_NOISE.
// Kept (1:1 math): camera-depth world-position reconstruction (inverse view-proj * (ndc, sceneDepth)),
//   world->decal-object-space projection (worldToObject), procedural shape clip via packedMisc&255
//   (0=box |xyz|<.5, 1=cylinder XZ-disc<.5 + |Y|<.5 slab, 2=SECTOR atan2 angle band, 3=sphere radius3D<.5),
//   scene G-buffer normal read (octahedral-style XY decode of the deferred normal RT) for normal blending,
//   decal albedo/NRO sample (sampler wrap modes preserved), dead-zone normal decode (|n|<0.012 -> 0),
//   NormalScale, _BlendSceneNormal cross-blend onto the scene tangent frame, _AffectNormal lerp toward
//   scene normal, octahedral ENCODE of the result for the normal MRT, roughness remap [min,max],
//   metallic/AO channel select (base: slider ; PBR: nested channel lerps), packed vertex color
//   (RGB bytes + intensity), opacity = (packedColor>>24)*_DecalOpacity*decalAlpha/255,
//   _BLEND_EMISSIVE channel-mixed emissive with albedo-affect + post-exposure divide,
//   _BLEND_WATER_FLOW dual-direction flow normal accumulation + emissive-flag set,
//   _UV_ARC barrel warp + _UV_NOISE texture-driven UV jitter.
// Removed (pixel-neutral pipeline infra substituted by URP or dropped): SPIRV-Cross plumbing
//   (gl_FragCoord/SPIRV_Cross_*/static I/O), spvBitfieldUExtract polyfills (-> HLSL >>/& + asuint),
//   discard_state bookkeeping (-> clip()), ECS GPU-instancing draw array indexed by SV_InstanceID
//   (-> URP unity_ObjectToWorld/unity_WorldToObject single-instance + per-instance feed as
//   [HideInInspector] uniforms), HGRP global cbuffer (_InvViewProjMatrix/_ScreenSize ->
//   UNITY_MATRIX_I_VP / _ScreenParams), HGRP camera-relative-rendering offset rows in the vertex
//   (-> URP TransformObjectToHClip), denormalized-float magic literals (decoded inline), TAA/MV/dither
//   MRT-in-forward trick (SV_Target1 reduced to the source's constant pack).
//
// NOTE: This is a SCREEN-SPACE DEFERRED MESH DECAL, not a lit/PBR surface. It rasterizes the projector
//   volume in Cull Front / ZTest Greater / ZWrite Off, reconstructs the underlying opaque surface world
//   position from the camera depth buffer, transforms it into the decal's object space, evaluates a
//   procedural shape, and BLENDS surface properties (albedo/normal/metallic/roughness/AO/emissive) into
//   the deferred G-buffer. There is NO GetMainLight / BRDF / SH here by design (so _core/CoreMath is
//   intentionally NOT included). The 5-MRT layout is the HGRP deferred G-buffer, NOT a URP G-buffer —
//   on URP there is no matching deferred decal target set, so the MRTs are authored 1:1 against the
//   source SV_Target0..4 and documented; wiring them into an actual URP deferred buffer is a gap.
// NOTE: per-instance feed (objectToWorld/worldToObject/uvTilingOffset/packedColor/packedColorIntensity/
//   sectorAngle/packedMisc) is HGRP ECS decal-batch data with no URP equivalent — mapped to
//   unity_ObjectToWorld/unity_WorldToObject (single instance) + documented [HideInInspector] uniforms so
//   the math is 1:1. The scene-normal G-buffer RT and camera depth are bound here as plain material
//   textures (_SceneNormalGBuffer / _CameraDepthTexture) because URP exposes no deferred-normal sampler
//   to a transparent/unlit decal pass.
// Texture channel legend: _BaseColorMap RGBA = Albedo.rgb + Opacity.a (when _BaseTexChannel==0)
//   OR NormalX,NormalY,Roughness,Opacity (when _BaseTexChannel==1). _SampleTex1 (_COMPLETE_PBR) = NRO map.
//   _UVNoiseMap (_UV_NOISE) = scalar noise driving UV jitter. _SceneNormalGBuffer = deferred normal RT
//   (point-Load at pixel). _CameraDepthTexture = scene depth (point-sampled at pixel center).

Shader "HGRP/DecalLit_Fix" {
    Properties {
        _MainProperties ("Main Properties", Float) = 0
        [Enum(Diffuse Opacity, 0, Normal Roughness Opacity, 1)] _BaseTexChannel ("Base Texture Usage", Float) = 0
        _BaseColorMap ("Base Map", 2D) = "white" {}
        _DecalOpacity ("Decal Opacity", Range(0, 1)) = 1
        [Toggle] _BlendAlbedo ("Blend Albedo", Float) = 1

        [Header(Complete PBR)]
        [Toggle(_COMPLETE_PBR)] _UseSampleTex1 ("Use NRO Map (Complete PBR)", Float) = 0
        _SampleTex1 ("NRO Map", 2D) = "white" {}
        [Enum(Main Tex UV, 0, NRO Tex UV, 1)] _SampleTex1UVSet ("NRO UV Source", Float) = 0
        _SampleTex1_ST ("NRO Tiling/Offset", Vector) = (1, 1, 0, 0)

        [Header(Normal And Roughness)]
        [Toggle] _AffectNormal ("Use Map Normal", Float) = 0
        [Toggle] _AffectRoughness ("Use Roughness", Float) = 1
        [ToggleUI] _BlendSceneNormal ("Blend Scene Normal", Float) = 0
        _NormalScale ("Normal Scale", Range(0.01, 1)) = 1
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1

        [Header(Metallic And AO)]
        [Enum(Close, 0, Texture2 R, 1, Texture2 G, 2, Texture2 B, 3, Texture2 A, 4)] _OcclusionChannel ("AO Channel", Float) = 0
        _OcclusionStrength ("AO Strength", Range(0, 2)) = 1
        [Enum(Close, 0, Slider, 1, Texture2 R, 2, Texture2 G, 3, Texture2 B, 4, Texture2 A, 5)] _MetallicChannel ("Metallic Channel", Float) = 0
        _Metallic ("Metallic", Range(0, 1)) = 0

        [Header(Angle Blend)]
        [Toggle(_NORMAL_ANGLE_BLEND)] _NormalAngleBlend ("Normal Angle Blend", Float) = 0
        _AngleBlendFallOff ("Angle Blend FallOff", Range(0.1, 5)) = 1

        [Header(Emissive)]
        [Toggle(_BLEND_EMISSIVE)] _BlendEmissive ("Blend Emissive", Float) = 0
        [Enum(Texture2 R, 0, Texture2 G, 1, Texture2 B, 2, Texture2 A, 3, Opacity, 4)] _EmissiveChannel ("Emissive Channel", Float) = 0
        [HDR] _EmissiveColor ("Emissive Color", Color) = (1, 1, 1, 1)
        [ToggleUI] _AlbedoAffectEmissive ("Albedo Not Affect Emissive", Float) = 1
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1

        [Header(Water Flow)]
        [Toggle(_BLEND_WATER_FLOW)] _UseWaterFlow ("Enable Surface Water Flow", Float) = 0
        _UVMovement ("Flow (X:Speed1 Y:Speed2 Z:Tiling1 W:Tiling2)", Vector) = (0.1, 0.15, 1, 1)
        _WaterNormalScale ("Water Normal Scale", Range(0.01, 1)) = 1
        _WaterNormalTex ("Water Normal Map", 2D) = "white" {}
        _WaterRoughness ("Water Roughness", Range(0, 1)) = 0
        _NormalFactor ("World Normal Influence", Range(0, 0.1)) = 0
        _AngleBlendFallOff2 ("Flat-Flow Angle Threshold", Range(0.01, 1)) = 1

        [Header(UV Distortion)]
        [Toggle(_UV_NOISE)] _UVNoiseSection ("UV Noise", Float) = 0
        _UVNoiseMap ("Noise Map", 2D) = "gray" {}
        _UVNoiseStrength ("Noise Strength", Range(-1, 1)) = 0
        _UVNoiseTiling ("Noise Tiling", Float) = 1
        [Toggle(_UV_ARC)] _UVArcSection ("UV Arc Warp", Float) = 0
        _UVArcStrengthX ("Arc Strength X", Range(-1, 1)) = 0
        _UVArcStrengthY ("Arc Strength Y", Range(-1, 1)) = 0
        _UVArcOffsetX ("UV Offset X", Range(-1, 1)) = 0
        _UVArcOffsetY ("UV Offset Y", Range(-1, 1)) = 0

        // --- Deferred-decal scene inputs (HGRP bound these as global RTs; URP has no decal-deferred sampler) ---
        // ENGINE-SIDE: _CameraDepthTexture (b12:177 T0) + _SceneNormalGBuffer (b12:212 T2 / b14:217 T3) are deferred
        //   G-buffer render-targets produced by the render pipeline, NOT material textures. On URP a host
        //   ScriptableRendererFeature decal-pass must bind the camera depth + the deferred normal RT as global textures
        //   before this pass; exposed here as [HideInInspector] material slots so the 1:1 math compiles standalone.
        [HideInInspector] _CameraDepthTexture ("Camera Depth", 2D) = "black" {}
        [HideInInspector] _SceneNormalGBuffer ("Scene Normal G-buffer", 2D) = "bump" {}
        [HideInInspector] _GlobalMipBias ("Global Mip Bias", Float) = 0
        [HideInInspector] _ExposureParams ("Exposure Params (.x = exposure)", Vector) = (1, 1, 0, 0)
        [HideInInspector] _Time2 ("Time (.y = seconds)", Vector) = (0, 0, 0, 0)

        // --- Per-instance decal feed (source: ECSPerDrawArray). Single-instance mapping. ---
        // ENGINE-SIDE: these are filled per-instance by a host C# decal-batch renderer (source struct ECSPerDrawArray,
        //   b11:10-19) — objectToWorld/worldToObject + packed color/misc/sector — there is no URP material or
        //   closed-form equivalent. Mapped to unity_ObjectToWorld/unity_WorldToObject (single instance) + exposed
        //   [HideInInspector] uniforms so the 1:1 math compiles; a host decal system must feed them for true batches.
        [HideInInspector] _UVTilingOffset ("Decal UV Tiling/Offset", Vector) = (1, 1, 0, 0)
        [HideInInspector] _PackedColor ("Packed Color (uint as float bits)", Float) = 0
        [HideInInspector] _PackedColorIntensity ("Packed Color Intensity", Float) = 1
        [HideInInspector] _SectorAngle ("Sector Angle (deg)", Float) = 0
        [HideInInspector] _PackedMisc ("Packed Misc (uint as float bits; &255 = shape)", Float) = 0

        // --- Render-state plumbing (driven by material editor; source had per-target Blend + _ColorMaskN) ---
        [HideInInspector] _SrcBlend ("__src", Float) = 5      // SrcAlpha
        [HideInInspector] _DstBlend ("__dst", Float) = 10     // OneMinusSrcAlpha
        [HideInInspector] _DrawOrder ("__DrawOrder", Float) = 0
        [HideInInspector] _Specular ("Specular", Range(0, 1)) = 0.5
    }

    SubShader {
        Tags {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
        }
        LOD 300

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

        CBUFFER_START(UnityPerMaterial)
            // PBR / normal-blend scalars (source cbuffer type_UnityPerMaterial, blob 12 lines 39-55).
            float _NormalScale;
            float _RoughnessMin;
            float _RoughnessMax;
            float _BaseTexChannel;
            float _MetallicChannel;
            float _OcclusionChannel;
            float _Metallic;
            float _OcclusionStrength;
            float _AffectNormal;
            float _SampleTex1UVSet;
            float _BlendSceneNormal;
            float4 _BaseColorMap_TexelSize;
            float4 _SampleTex1_ST;
            float _DecalOpacity;
            float _UVNoiseSection;
            float _UVNoiseStrength;
            float _UVNoiseTiling;
            // UV-arc + angle-blend + emissive scalars (source blobs 22/26/32 cbuffer extension, b22 lines 60-71).
            float _UVArcSection;
            float _UVArcStrengthX;
            float _UVArcStrengthY;
            float _UVArcOffsetX;
            float _UVArcOffsetY;
            float _AngleBlendFallOff;
            float _AlbedoAffectEmissive;
            float _IgnorePostExposure;
            float _AngleBlendFallOff2;
            float _EmissiveChannel;
            // Aliased duplicate emissive-selector slots the decompiler emits at c12.y/c12.z (b22:70-71, b26:69-70).
            // In _BLEND_EMISSIVE they are the G/B emissive-channel selectors; in _BLEND_WATER_FLOW the decompiler
            // reuses them as the second-pass flow scroll speed + flow-tiling. Kept as named uniforms for 1:1.
            float _AlbedoAffectEmissive_at_196;
            float _IgnorePostExposure_at_200;
            float4 _EmissiveColor;
            // Water flow (source blob 26 cbuffer; _UVMovement/_WaterNormalScale/_WaterRoughness/_NormalFactor).
            float4 _UVMovement;
            float _WaterNormalScale;
            float _WaterRoughness;
            float _NormalFactor;

            // Deferred scene inputs + HGRP globals re-exposed (source type_ShaderVariablesGlobal, b12 lines 23-28).
            float  _GlobalMipBias;
            float4 _ExposureParams;
            float4 _Time2;

            // Per-instance decal feed (source ECSPerDrawArray, blob 12 lines 11-18). Single-instance.
            float4 _UVTilingOffset;
            float  _PackedColor;
            float  _PackedColorIntensity;
            float  _SectorAngle;
            float  _PackedMisc;
        CBUFFER_END

        // Textures re-identified from blob sample sites (sampler wrap modes are the load-bearing 1:1 part):
        //   _CameraDepthTexture = scene depth   (b12:177 T0, sampler_LinearClamp, SampleLevel LOD0)
        //   _BaseColorMap       = decal albedo  (b12:231 T1, sampler_LinearRepeat, mip = precomputed level)
        //   _SceneNormalGBuffer = deferred normal RT (b12:212 T2, .Load at pixel)  [_COMPLETE_PBR: T3, b14:217]
        //   _SampleTex1         = NRO map       (b14:245 T2, sampler_LinearMirror, mip-biased) [_COMPLETE_PBR only]
        //   _UVNoiseMap         = noise         (b32:248 T1) + noise-driver sample (b32:247 T2, sampler_LinearMirror)
        //   _WaterNormalTex     = water flow normal (b26:271 T2, sampler_LinearRepeat) [_BLEND_WATER_FLOW only]
        TEXTURE2D(_CameraDepthTexture); SAMPLER(sampler_LinearClamp);
        TEXTURE2D(_BaseColorMap);       SAMPLER(sampler_LinearRepeat);
        TEXTURE2D(_SceneNormalGBuffer);
        TEXTURE2D(_SampleTex1);         SAMPLER(sampler_LinearMirror);
        TEXTURE2D(_UVNoiseMap);
        TEXTURE2D(_WaterNormalTex);

        // ---- magic-constant decodes (cites against Fragment_b12 unless noted) ----
        static const float INV_255      = 0.0039215688593685626983642578125;  // 1/255              (b12:238)
        static const float NRM_DEADZONE = 0.01200000010430812835693359375;    // normal dead-zone   (b12:243)
        static const float FLT_MIN_GUARD = 1.1754943508222875079687365372222e-38; // rsqrt guard     (b12:223)
        static const float RAD2DEG      = 57.295780181884765625;              // 180/pi             (b12:202)
        static const float HALF_PI      = 1.57079637050628662109375;          // pi/2               (b12:198)
        static const float NEG_PI       = -3.1415927410125732421875;          // asfloat(3226013659u) = -pi (b12:198)
        static const float RECIP_GUARD  = 5.9604644775390625e-08;             // 2^-24 (water log2 guard, b26:262)

        // Dead-zone a decoded-normal channel: |x| < 0.012 -> 0, else x. (b12:243-244)
        float NormalDeadZone(float x)
        {
            return (abs(x) < NRM_DEADZONE) ? 0.0 : x;
        }

        // atan2(y, x) reconstructed exactly as the decompiler (radians, (-pi, pi]).
        // In the sector code the decompiler feeds y=localZ (_190) and x=localX (_188). (b12:197-201)
        float Atan2Src(float y, float x)
        {
            float t  = (1.0 / max(abs(x), abs(y))) * min(abs(x), abs(y));   // b12:195 (max/min over |z|,|x|)
            float t2 = t * t;                                               // b12:196
            float poly = mad(t2, mad(t2, mad(t2, mad(t2,
                          0.02083509974181652069091796875, -0.08513300120830535888671875),
                          0.1801410019397735595703125), -0.33029949665069580078125),
                          0.999866008758544921875);                         // b12:197
            // sign term = (localX < 0) ? -pi : 0  (b12:198 : asfloat((_188 < -_188) & 3226013659u))
            float signTerm = (x < 0.0) ? NEG_PI : 0.0;
            // EXACT order: t*poly + ((|x| < |y|) ? (pi/2 - 2*t*poly) : 0). (b12:198)
            float quad = mad(t, poly, (abs(x) < abs(y)) ? mad(poly * t, -2.0, HALF_PI) : 0.0);
            float ang = signTerm + quad;
            // (b12:201 _270): if (min(x,z) < 0 && max(x,z) >= 0) ang = -ang.
            if ((min(x, y) < 0.0) && (max(x, y) >= 0.0)) ang = -ang;
            return ang;
        }

        // Sector angle of (localX, localZ) in DEGREES, wrapped to [0,360). (b12:200-202 _274)
        float SectorAngleDeg(float localX, float localZ)
        {
            float ang = Atan2Src(localZ, localX);
            return (ang < 0.0) ? mad(ang, RAD2DEG, 360.0) : (ang * RAD2DEG);
        }
        ENDHLSL

        Pass {
            Name "DecalLit_GBuffer"
            // Source render-state (decallit.shader lines 75-95): 5 MRTs, MRT0 SrcAlpha/OneMinusSrcAlpha,
            // MRT1 Zero/One (color-write masked off), MRT2..4 SrcAlpha/OneMinusSrcAlpha, per-target ColorMask
            // driven by _ColorMaskN. ZClip On / ZTest Greater / ZWrite Off / Cull Front, Stencil ReadMask 32
            // Comp Equal (decal-receiver bit). URP single-bound approximation keeps the dominant SrcAlpha blend +
            // ZTest Greater / ZWrite Off / Cull Front 1:1; per-MRT ColorMask/Stencil are HGRP deferred-decal infra.
            Blend [_SrcBlend] [_DstBlend], [_SrcBlend] [_DstBlend]
            ZClip On
            ZTest Greater
            ZWrite Off
            Cull Front
            // Source Stencil { ReadMask 32  Comp Equal  Pass/Fail/ZFail Keep } = HGRP decal-receiver bit.
            // ENGINE-SIDE: the stencil Ref (decal-receiver bit 32) is written into the stencil buffer by the host
            //   HGRP/URP deferred decal-receiver pass — it is render-pipeline state, not a material value. URP has no
            //   equivalent global, so the Stencil block is omitted (a bound Ref with no host-provided value would
            //   reject every pixel). A host ScriptableRendererFeature must re-introduce the receiver-bit test.

            Tags { "LightMode" = "SRPDefaultUnlit" }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _COMPLETE_PBR
            #pragma shader_feature_local _NORMAL_ANGLE_BLEND
            #pragma shader_feature_local _BLEND_EMISSIVE
            #pragma shader_feature_local _BLEND_WATER_FLOW
            #pragma shader_feature_local _UV_ARC
            #pragma shader_feature_local _UV_NOISE

            struct Attributes
            {
                float3 positionOS : POSITION;
            };

            struct Varyings
            {
                float4 positionCS  : SV_POSITION;
                // Source vertex passes the decal's world-space axis basis (normalized objectToWorld columns)
                // for the scene-normal cross-blend (TEXCOORD_1 = col1 dir, TEXCOORD_2 = col0 dir + sign.w),
                // and a precomputed sample mip level in TEXCOORD.x.
                float3 decalAxis1  : TEXCOORD0; // source TEXCOORD_1 : normalized objectToWorld col1
                float4 decalAxis0  : TEXCOORD1; // source TEXCOORD_2 : xyz = normalized objectToWorld col0, w = sign(-1)
                float  sampleMip   : TEXCOORD2; // source TEXCOORD.x : decal sample mip level (here 0)
                nointerpolation uint shapeMode : TEXCOORD3; // packedMisc & 255 (source nointerp TEXCOORD_5 use)
            };

            // ============================================================
            // Vertex (blob 11, lines 83-133; byte-identical across all keyword variants).
            // Source additionally bakes a procedural SECTOR mesh deformation: when packedMisc&255 == 2 it rotates
            // the unit-disc POSITION.xz by an atan2-derived angle scaled by the sector angle (CB1_m0[9].z) — an
            // HGRP ECS-decal procedural mesh built from CB1 global arrays + camera-relative offsets, with no URP
            // feed. We rasterize the projector mesh straight through object->world->clip; the real per-pixel work
            // (the procedural shape from reconstructed depth) is 1:1 in the fragment. (Documented in gaps.)
            // ============================================================
            Varyings vert(Attributes input)
            {
                Varyings o = (Varyings)0;

                // posWS = objectToWorld * positionOS ; clip = VP * posWS. Source builds clip via the decal-receiver
                // NDC remap rows (b11:104-110, _ECSPerDraw[3].* + viewport scale on rows[10]); on URP a single-
                // instance projector box maps to the standard TransformObjectToHClip. (b11:104-110)
                o.positionCS = TransformObjectToHClip(input.positionOS);

                // Normalize objectToWorld col1 -> decalAxis1 (source TEXCOORD_1, b11:116-120).
                float3 col1 = float3(unity_ObjectToWorld._m01, unity_ObjectToWorld._m11, unity_ObjectToWorld._m21);
                float invLen1 = rsqrt(max(dot(col1, col1), FLT_MIN_GUARD));
                o.decalAxis1 = invLen1 * col1;

                // Normalize objectToWorld col0 -> decalAxis0.xyz (source TEXCOORD_2, b11:121-125).
                float3 col0 = float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20);
                float invLen0 = rsqrt(max(dot(col0, col0), FLT_MIN_GUARD));
                o.decalAxis0.xyz = invLen0 * col0;
                o.decalAxis0.w   = -1.0; // sign flag (b11:125)

                // ENGINE-SIDE: source TEXCOORD.x (b11:114) = max(floor(log2((min(CB1_m0[i+8].xy) * _BaseColorMap_TexelSize.w)
                //   / max(float(asuint(CB1_m0[i+9].w)>>16) * _ECSPerDraw[8].objectToWorld[2].y * INV_255, 0.001))), 0).
                //   Its inputs CB1_m0[] (the HGRP decal-binning UBO: per-instance projector screen footprint) and
                //   _ECSPerDraw[] (the ECS decal-batch array) are host-filled global arrays with no URP material or
                //   closed-form equivalent — only the HGRP decal-batch C# system produces them. Single-instance -> mip 0.
                o.sampleMip = 0.0;

                o.shapeMode = 255u & asuint(_PackedMisc);
                return o;
            }

            // 5 MRT deferred-decal targets (source SV_Target/_1/_2/_3/_4). Authored as an explicit struct so the
            // MRT layout is 1:1 with the source G-buffer write.
            //   MRT0 = emissive.rgb + opacity.w (base: all 0 ; _BLEND_EMISSIVE: lit emissive)        (b12:273-276 / b22:293-317)
            //   MRT1 = dither/MV pack (base const 0.5,0.5,0,0 ; water sets .z=1 + emissive flag .w)  (b12:277-280 / b26:320-327)
            //   MRT2 = metallic.x, _ (.y), ao.z?, opacity.w ; here .x=metallic .y=AO .z=0 .w=opacity (b12:271-272,281-282)
            //   MRT3 = octa-normal XY .xy, roughness .z, opacity .w                                   (b12:267-269,283)
            //   MRT4 = albedo.rgb (vertexColor-modulated), opacity .w                                 (b12:238-240,284)
            struct DecalGBuffer
            {
                float4 emissive    : SV_Target0;
                float4 ditherMV    : SV_Target1;
                float4 metalAO     : SV_Target2;
                float4 normalRough : SV_Target3;
                float4 albedo      : SV_Target4;
            };

            DecalGBuffer frag(Varyings input)
            {
                uint shapeMode = input.shapeMode;

                // ===== Reconstruct world position of the underlying opaque surface from depth (b12:174-184). =====
                // Source: NDC from gl_FragCoord, inv-view-proj * (ndcX, -ndcY, sampledDepth). T0 = camera depth,
                // point-sampled at pixel center. input.positionCS.xy here = pixel coords (SV_POSITION in frag).
                uint px = (uint)input.positionCS.x;
                uint py = (uint)input.positionCS.y;
                // Source uses HGRP _ScreenSize.zw = (1/width, 1/height). URP's _ScreenParams.zw is (1+1/w, 1+1/h),
                // so the correct 1/w,1/h is rcp(_ScreenParams.xy) (= _ScreenSize.zw). (b12:176-177)
                float2 invScreen = rcp(_ScreenParams.xy);
                float2 depthUV = float2((float(px) + 0.5) * invScreen.x, (float(py) + 0.5) * invScreen.y); // b12:177
                float sceneDepth = SAMPLE_TEXTURE2D_LOD(_CameraDepthTexture, sampler_LinearClamp, depthUV, 0.0).x; // _98 (b12:177)
                float ndcX = mad(input.positionCS.x * invScreen.x, 2.0, -1.0);                                 // _78 (b12:176)
                float ndcY = -mad(input.positionCS.y * invScreen.y, 2.0, -1.0);                                // _99 (b12:179)
                // worldH = UNITY_MATRIX_I_VP * (ndcX, ndcY, depth, 1) ; then perspective divide. (b12:180-184)
                float4 worldH = mul(UNITY_MATRIX_I_VP, float4(ndcX, ndcY, sceneDepth, 1.0));
                float invW = 1.0 / worldH.w;
                float3 surfaceWS = worldH.xyz * invW;

                // ===== World -> decal object space via worldToObject (b12:185-187). =====
                float3 localP = mul(unity_WorldToObject, float4(surfaceWS, 1.0)).xyz;
                float lx = localP.x; // _188
                float ly = localP.y; // _189
                float lz = localP.z; // _190

                // ===== Procedural shape membership -> clip (b12:188-210). =====
                // mode = packedMisc & 255 : 2 = SECTOR (atan2 angle band ∩ disc-slab),
                //   3 = sphere (radius3D<.5), 1 = cylinder (XZ-disc<.5 ∩ |Y|<.5), else = box (|x,y,z|<.5).
                bool yLo = (-0.5) < ly; // _203
                bool yHi = ly < 0.5;    // _205
                bool discXZ = sqrt(dot(float2(lx, lz), float2(lx, lz))) < 0.5; // _213 component
                bool inDiscSlab = yHi && yLo && discXZ;                        // _213
                bool keep;
                if (shapeMode == 2u)
                {
                    // Sector band: angle in [-(sectorAngle)/2+90 .. sectorAngle/2+90] OR the wrap range
                    // [-(sectorAngle)/2+450 .. 360), all ANDed with the disc-slab. (b12:193-204)
                    float deg = SectorAngleDeg(lx, lz);                                   // _274
                    float negS = -_SectorAngle;                                           // _285
                    bool wrapHi  = (deg < 360.0) && (deg >= mad(negS, 0.5, 450.0));        // b12:204 grp1
                    bool mainArc = (deg >= mad(negS, 0.5, 90.0)) && (mad(_SectorAngle, 0.5, 90.0) >= deg); // b12:204 grp2
                    keep = inDiscSlab && (wrapHi || mainArc);
                }
                else if (shapeMode == 3u)
                {
                    keep = sqrt(dot(float3(lx, ly, lz), float3(lx, ly, lz))) < 0.5;        // b12:208 (_197==3)
                }
                else if (shapeMode == 1u)
                {
                    keep = inDiscSlab;                                                     // b12:208 (_197==1 -> _213)
                }
                else if (shapeMode != 0u)
                {
                    keep = true;                                                           // b12:208 (_197!=0 -> pass)
                }
                else
                {
                    // box: all 6 planes |x,y,z| < .5 (b12:208 box group, exact AND order preserved).
                    bool xLo = (-0.5) < lx;
                    bool zLo = (-0.5) < lz;
                    keep = (lz < 0.5) && (lx < 0.5) && zLo && xLo && yHi && yLo;
                }
                // discard when NOT inside (source: discard_cond((mask ^ 0xffffffff) != 0)). (b12:210)
                clip(keep ? 1.0 : -1.0);

                // ===== Scene G-buffer normal read + octahedral-style XY decode (b12:211-226). =====
                // sign = (decalAxis0.w > 0) ? 1 : -1  (b12:211, TEXCOORD_2.w = -1 from vertex -> -1).
                float axisSign = (0.0 < input.decalAxis0.w) ? 1.0 : -1.0;
                #ifdef _COMPLETE_PBR
                    float4 sceneNrmTex = LOAD_TEXTURE2D(_SceneNormalGBuffer, int2(px, py)); // b14:217 T3.Load
                #else
                    float4 sceneNrmTex = LOAD_TEXTURE2D(_SceneNormalGBuffer, int2(px, py)); // b12:212 T2.Load
                #endif
                float snX = mad(sceneNrmTex.x, 2.0, -1.0); // _348
                float snY = mad(sceneNrmTex.y, 2.0, -1.0); // _349
                float snZ = (-dot(float2(1.0, 1.0), float2(abs(snX), abs(snY)))) + 1.0; // _356 (octa Z = 1-|x|-|y|)
                bool snFold = snZ < 0.0;                                                 // _357
                // octahedral unfold when Z<0 (b12:217-218).
                float snXu = snFold ? (((snX >= 0.0) ? 1.0 : -1.0) * ((-abs(snY)) + 1.0)) : snX; // _377
                float snYu = snFold ? (((snY >= 0.0) ? 1.0 : -1.0) * ((-abs(snX)) + 1.0)) : snY; // _379
                // normalize twice exactly as the blob (rsqrt then a guarded rsqrt). (b12:219-226)
                float snInv1 = rsqrt(dot(float3(snXu, snZ, snYu), float3(snXu, snZ, snYu)));   // _383
                float sn1x = snInv1 * snXu; // _384
                float sn1y = snInv1 * snZ;  // _385  (note: Y carries the octa Z)
                float sn1z = snInv1 * snYu; // _386
                float snInv2 = rsqrt(max(dot(float3(sn1x, sn1y, sn1z), float3(sn1x, sn1y, sn1z)), FLT_MIN_GUARD)); // _392
                float sn2x = snInv2 * sn1x; // _393
                float sn2y = snInv2 * sn1y; // _394
                float sn2z = snInv2 * sn1z; // _395

                // ===== Normalized decal axis1 (source normalizes TEXCOORD_2 again here) (b12:227-230). =====
                // The blob re-normalizes the vertex-supplied decalAxis0 (TEXCOORD_2) and reorders xyz->(y,z,x).
                float a0Inv = rsqrt(max(dot(input.decalAxis0.xyz, input.decalAxis0.xyz), FLT_MIN_GUARD)); // _412
                float a0y = a0Inv * input.decalAxis0.y; // _419
                float a0z = a0Inv * input.decalAxis0.z; // _420
                float a0x = a0Inv * input.decalAxis0.x; // _421

                // ===== Decal UV (with optional arc warp + noise warp). =====
                float decalU;
                float decalV;
                #if defined(_UV_ARC) || defined(_UV_NOISE)
                    // (b32:241-248) centered = local + 0.5 ; nrm = centered*2-1 ; arc = (1 - nrm*nrm)*strength + offset.
                    float cX = lx + 0.5; // _427
                    float cZ = lz + 0.5; // _428
                    float nZ = mad(cZ, 2.0, -1.0); // _429
                    float nX = mad(cX, 2.0, -1.0); // _430
                    // U (b32:245): arc Y on nZ + col.x tiling on cX. V (b32:246): arc X on nX + col.y tiling on cZ.
                    float arcU = mad(mad(mad(-nZ, nZ, 1.0), _UVArcStrengthY, _UVArcOffsetY), _UVArcSection,
                                     mad(cX, _UVTilingOffset.x, _UVTilingOffset.z));
                    float arcV = mad(mad(mad(-nX, nX, 1.0), _UVArcStrengthX, _UVArcOffsetX), _UVArcSection,
                                     mad(cZ, _UVTilingOffset.y, _UVTilingOffset.w));
                    #ifdef _UV_NOISE
                        // noise driver: scalar from _UVNoiseMap sampled at arcUV*tiling, biased, scaled by strength*section.
                        // (b32:247) _484 = dot(((noise.x - 0.5)*strength).xx, section.xx).
                        float noiseSrc = SAMPLE_TEXTURE2D_BIAS(_UVNoiseMap, sampler_LinearMirror,
                                            float2(arcU * _UVNoiseTiling, arcV * _UVNoiseTiling), _GlobalMipBias).x;
                        float noiseAmt = dot(((noiseSrc + (-0.5)) * _UVNoiseStrength).xx, _UVNoiseSection.xx); // _484
                        decalU = arcU + noiseAmt; // _493 uv.x
                        decalV = arcV + noiseAmt; // _493 uv.y
                    #else
                        decalU = arcU;
                        decalV = arcV;
                    #endif
                #else
                    // No distortion (b12:231): UV = (local + 0.5) * tiling + offset.
                    decalU = mad(lx + 0.5, _UVTilingOffset.x, _UVTilingOffset.z);
                    decalV = mad(lz + 0.5, _UVTilingOffset.y, _UVTilingOffset.w);
                #endif
                float2 decalUV = float2(decalU, decalV);

                // ===== Sample decal albedo (T1, sampler_LinearRepeat, mip = trunc(sampleMip)) (b12:231-234 / b32:248). =====
                // T1 = the PRIMARY decal base texture (_BaseColorMap) in every variant. Proven by b30 (_UV_ARC+_COMPLETE_PBR):
                // T1 is sampled at the primary decal UV (= base color), while the secondary slot T2 holds the NRO map / the
                // _UV_NOISE driver. The decompiler's sampler names (sampler_LinearRepeat_UVNoiseMap on T1 in b32) are aliased
                // and NOT the texture identity. So under _UV_NOISE the base sample is still _BaseColorMap (the noise map is only
                // the T2 driver tap below); sampling _UVNoiseMap here would paint the noise texture as the decal albedo.
                float4 baseSample = SAMPLE_TEXTURE2D_LOD(_BaseColorMap, sampler_LinearRepeat, decalUV, trunc(input.sampleMip)); // b32:248 T1=_BaseColorMap
                float baseR = baseSample.x; // _443
                float baseG = baseSample.y; // _444
                float baseB = baseSample.z; // _445
                bool useNRO = (0.0 != _BaseTexChannel); // _450 : base map holds Normal/Roughness/Opacity

                // ===== Normal X/Y source selection + dead-zone (b12:241-247). =====
                // base: when useNRO take XY from baseSample, else the constant 0.5. PBR: a SECOND NRO map
                // (_SampleTex1) supplies the "else" branch + roughness/metal/AO channels. (b14:245-257)
                #ifdef _COMPLETE_PBR
                    // NRO UV = lerp(decalUV, decalUV-derived _SampleTex1_ST mapping, _SampleTex1UVSet). (b14:245)
                    float2 nroUV = float2(mad(_SampleTex1UVSet, (-decalU) + mad(lx + 0.5, _SampleTex1_ST.x, _SampleTex1_ST.z), decalU),
                                          mad(_SampleTex1UVSet, (-decalV) + mad(lz + 0.5, _SampleTex1_ST.y, _SampleTex1_ST.w), decalV));
                    float4 nroSample = SAMPLE_TEXTURE2D_BIAS(_SampleTex1, sampler_LinearMirror, nroUV, _GlobalMipBias); // _479
                    float nroR = nroSample.x; // _481
                    float nroG = nroSample.y; // _482
                    float nroB = nroSample.z; // _483
                    float nx = mad(useNRO ? baseR : nroR, 2.0, -1.0); // _555
                    float ny = mad(useNRO ? baseG : nroG, 2.0, -1.0); // _556
                #else
                    float nx = mad(useNRO ? baseR : 0.5, 2.0, -1.0); // _519 (0.5 = asfloat(1056964608u))
                    float ny = mad(useNRO ? baseG : 0.5, 2.0, -1.0); // _520
                #endif
                nx = NormalDeadZone(nx); // _529
                ny = NormalDeadZone(ny); // _531
                float nz = sqrt(max((-dot(float2(nx, ny), float2(nx, ny))) + 1.0, 0.0)); // _538
                float sx = nx * _NormalScale; // _542
                float sy = ny * _NormalScale; // _543

                // ===== Scene tangent frame (cross of decalAxis1 and scene normal), sign-flipped (b12:248-250). =====
                // bX/Y/Z = axisSign * cross(decalAxis1, decalAxis0)  (TEXCOORD_1 x TEXCOORD_2). (b12:248-250)
                float3 d1 = input.decalAxis1;
                float3 d2 = input.decalAxis0.xyz;
                float bX = axisSign * mad(d1.y, d2.z, -(d1.z * d2.y)); // _607
                float bY = axisSign * mad(d1.z, d2.x, -(d1.x * d2.z)); // _608
                float bZ = axisSign * mad(d1.x, d2.y, -(d1.y * d2.x)); // _609

                // ===== Blended decal normal in world space, with optional _BlendSceneNormal mix (b12:251-253). =====
                // For each axis: nz*lerp(d1, sceneNrm2, blend)  + sx*lerp(d2, sceneNrm-derived, blend)
                //              + sy*lerp(bitangent, scene-cross, blend).
                float bnX = mad(nz, mad(_BlendSceneNormal, mad(sn1x, snInv2, -d1.x), d1.x),
                            mad(sx, mad(_BlendSceneNormal, mad(d2.x, a0Inv, -d2.x), d2.x),
                                sy * mad(_BlendSceneNormal, mad(mad(sn2y, a0z, -(sn2z * a0y)), axisSign, -bX), bX)));
                float bnY = mad(nz, mad(_BlendSceneNormal, mad(sn1y, snInv2, -d1.y), d1.y),
                            mad(sx, mad(_BlendSceneNormal, mad(d2.y, a0Inv, -d2.y), d2.y),
                                sy * mad(_BlendSceneNormal, mad(mad(sn2z, a0x, -(sn2x * a0z)), axisSign, -bY), bY)));
                float bnZ = mad(nz, mad(_BlendSceneNormal, mad(sn1z, snInv2, -d1.z), d1.z),
                            mad(sx, mad(_BlendSceneNormal, mad(d2.z, a0Inv, -d2.z), d2.z),
                                sy * mad(_BlendSceneNormal, mad(mad(sn2x, a0y, -(sn2y * a0x)), axisSign, -bZ), bZ)));

                // ===== Opacity (b12:254): baseSample.a * (packedColor>>24)*_DecalOpacity / 255. =====
                uint pc = asuint(_PackedColor);
                float opacity = (baseSample.w * (float(pc >> 24u) * _DecalOpacity)) * INV_255; // _676
                #ifdef _NORMAL_ANGLE_BLEND
                    // _NORMAL_ANGLE_BLEND (b16:263 / b18:276): fade opacity by the decal-axis vs scene-normal angle.
                    // opacity *= exp2(log2(max(saturate(dot(decalAxis1, sn1)), 2^-24)) * max(0.001, _AngleBlendFallOff))
                    //          = pow(saturate(dot(d1, sn1)), _AngleBlendFallOff) (guarded). Applies to all MRT .w via opacity.
                    float angleDot   = clamp(dot(d1, float3(sn1x, sn1y, sn1z)), 0.0, 1.0);                 // b16:263 dot(TEXCOORD_1, sn1)
                    float angleBlend = exp2(log2(max(angleDot, RECIP_GUARD)) * max(0.001000000047497451305389404296875, _AngleBlendFallOff)); // b16:263
                    opacity *= angleBlend;
                #endif

                // ===== _AffectNormal lerp toward scene normal, normalize, octahedral ENCODE (b12:255-268). =====
                // Lerp target is the FIRST scene-normal normalize (_384/_385/_386 = sn1*), NOT the guarded second
                // normalize. When _AffectNormal=0 the output is exactly the scene normal (decal normal off). (b12:256)
                float bnInv = rsqrt(max(dot(float3(bnX, bnY, bnZ), float3(bnX, bnY, bnZ)), FLT_MIN_GUARD)); // _681
                float anX = mad(_AffectNormal, mad(bnX, bnInv, -sn1x), sn1x); // _691
                float anY = mad(_AffectNormal, mad(bnY, bnInv, -sn1y), sn1y); // _692
                float anZ = mad(_AffectNormal, mad(bnZ, bnInv, -sn1z), sn1z); // _693
                float anN = rsqrt(dot(float3(anX, anY, anZ), float3(anX, anY, anZ))); // _697
                float fnX = anX * anN; // _698
                float fnY = anY * anN; // _699
                float fnZ = anZ * anN; // _700
                // octahedral encode (b12:263-268): oct = n.xz / (|x|+|y|+|z|), fold when n.y<=0, *.5+.5.
                float octDenom = dot(float3(1.0, 1.0, 1.0), float3(abs(fnX), abs(fnY), abs(fnZ))); // _704
                float octX = fnX / octDenom; // _707
                float octZ = fnZ / octDenom; // _708
                bool octFold = 0.0 >= fnY;    // _709
                float octXf = octFold ? (((octX >= 0.0) ? 1.0 : -1.0) * ((-abs(octZ)) + 1.0)) : octX; // SV_Target_3.x num
                float octZf = octFold ? (((octZ >= 0.0) ? 1.0 : -1.0) * ((-abs(octX)) + 1.0)) : octZ; // SV_Target_3.y num

                // ===== Roughness (b12:269 / b14:282 / b32:283): remap source roughness into [min,max]. =====
                #ifdef _COMPLETE_PBR
                    float roughSrc = useNRO ? baseB : nroB; // b14:282
                #else
                    float roughSrc = useNRO ? baseB : 1.0;  // b12:269 (else = asfloat(1065353216u)=1)
                #endif
                float roughness = mad(roughSrc, (-_RoughnessMin) + _RoughnessMax, _RoughnessMin);

                // ===== Metallic + AO (b12:270-272 base / b14:283-289 PBR). =====
                #ifdef _COMPLETE_PBR
                    // multi-channel select via nested clamps on _MetallicChannel/_OcclusionChannel. (b14:283-289)
                    float nrG = (-nroR) + nroG;          // _810
                    float nrBA = (-nroB) + nroSample.w;  // _811
                    float metClamp = clamp(_MetallicChannel, 0.0, 1.0); // _789
                    float metSel = mad(clamp((-2.0) + _MetallicChannel, 0.0, 1.0), nrG, nroR); // _812
                    float metallic = mad(clamp((-1.0) + _MetallicChannel, 0.0, 1.0),
                                       mad(-metClamp, _Metallic,
                                         mad(clamp((-3.0) + _MetallicChannel, 0.0, 1.0),
                                           (-metSel) + mad(clamp((-4.0) + _MetallicChannel, 0.0, 1.0), nrBA, nroB),
                                           metSel)),
                                       metClamp * _Metallic); // SV_Target_2.x
                    float aoSel = mad(clamp((-1.0) + _OcclusionChannel, 0.0, 1.0), nrG, nroR); // _838
                    float aoInner = mad(clamp((-2.0) + _OcclusionChannel, 0.0, 1.0),
                                      (-aoSel) + mad(clamp((-3.0) + _OcclusionChannel, 0.0, 1.0), nrBA, nroB), aoSel);
                    float ao = mad(mad(clamp(_OcclusionChannel, 0.0, 1.0), aoInner + (-1.0), 1.0),
                                 _OcclusionStrength, 1.0 + (-_OcclusionStrength)); // SV_Target_2.y
                #else
                    // base (b12:270-272): metallic = clamp(channel,0,1)*_Metallic lerp'd by clamp(channel-1,0,1).
                    float metBase = clamp(_MetallicChannel, 0.0, 1.0) * _Metallic; // _758
                    float metallic = mad(clamp((-1.0) + _MetallicChannel, 0.0, 1.0), -metBase, metBase); // SV_Target_2.x
                    float ao = mad((-clamp(_OcclusionChannel, 0.0, 1.0)) + 1.0, _OcclusionStrength,
                                 1.0 + (-_OcclusionStrength)); // SV_Target_2.y
                #endif

                // ===== Assemble base MRTs (b12:267-284). =====
                DecalGBuffer o;
                o.emissive    = float4(0.0, 0.0, 0.0, 0.0);       // base: MRT0 all 0 (b12:273-276)
                o.ditherMV    = float4(0.5, 0.5, 0.0, 0.0);       // base: MRT1 const (b12:277-280)
                o.metalAO     = float4(metallic, ao, 0.0, opacity);                         // b12:271-272,281-282
                o.normalRough = float4(mad(octXf, 0.5, 0.5), mad(octZf, 0.5, 0.5), roughness, opacity); // b12:267-269,283
                // albedo.rgb = (useNRO ? 1 : baseRGB) * packed vertex color (RGB bytes * intensity). (b12:238-240)
                float vcR = (float(255u & pc) * INV_255) * _PackedColorIntensity;        // _238 chain
                float vcG = (float((pc >> 8u)  & 255u) * INV_255) * _PackedColorIntensity; // _239 chain
                float vcB = (float((pc >> 16u) & 255u) * INV_255) * _PackedColorIntensity; // _240 chain
                o.albedo = float4((useNRO ? 1.0 : baseR) * vcR,
                                  (useNRO ? 1.0 : baseG) * vcG,
                                  (useNRO ? 1.0 : baseB) * vcB,
                                  opacity); // b12:238-240,284

                // ===== _BLEND_EMISSIVE: channel-mixed emissive into MRT0, albedo-affect + exposure divide. =====
                // Requires the NRO map (_COMPLETE_PBR provides nroR/G/B/nroSample.w); the emissive channel is selected
                // from the NRO RGBA + the decal-albedo alpha ("Opacity" option) via a clamp chain.
                // CRITICAL 1:1 SPLIT: b22 (_BLEND_EMISSIVE+_COMPLETE_PBR, NO angle blend) and b24
                //   (+_NORMAL_ANGLE_BLEND) compile the SAME author intent against DIFFERENT cbuffer slots (b22 & b24
                //   have byte-identical cbuffer layouts, b22:41-72 == b24:41-73, so these are distinct physical uniforms
                //   the HGRP variant system feeds differently). b22 drives the channel-select clamp by _AngleBlendFallOff
                //   (free in b22), per-channel intensity by the c12.xyz aliases (_EmissiveChannel/_AlbedoAffectEmissive_at_196/
                //   _IgnorePostExposure_at_200), exposure-gate by _IgnorePostExposure, albedo-affect by _AlbedoAffectEmissive.
                //   b24 (with angle blend occupying _AngleBlendFallOff) drives the channel-select clamp by _EmissiveChannel,
                //   per-channel intensity by _EmissiveColor.xyz (c13), exposure-gate by _IgnorePostExposure_at_200,
                //   albedo-affect by _AlbedoAffectEmissive_at_196. Both ported faithfully under the matching keyword set.
                #if defined(_BLEND_EMISSIVE) && defined(_COMPLETE_PBR)
                    // albedo-modulated packed vertex color (b22:268-273 / b24:263-273). albedoSel = useNRO ? 1 : decalAlbedo.
                    float albSelR = useNRO ? 1.0 : baseR; // _544
                    float albSelG = useNRO ? 1.0 : baseG; // _546
                    float albSelB = useNRO ? 1.0 : baseB; // _548
                    float vaR = albSelR * vcR;            // _549
                    float vaG = albSelG * vcG;            // _550
                    float vaB = albSelB * vcB;            // _551
                    // emissive channel select from NRO + decal-alpha("Opacity") via a clamp chain.
                    float emG  = (-nroR) + nroG;          // _704
                    float emBA = (-nroB) + nroSample.w;   // _705
                    #ifdef _NORMAL_ANGLE_BLEND
                        // b24:288-296: clamp driver = _EmissiveChannel ; per-channel = _EmissiveColor.xyz (c13) ;
                        //   exposure-gate = _IgnorePostExposure_at_200 ; albedo-affect factor = _AlbedoAffectEmissive_at_196.
                        float emBase = mad(clamp(_EmissiveChannel, 0.0, 1.0), emG, nroR); // _706
                        float emMid  = mad(clamp((-1.0) + _EmissiveChannel, 0.0, 1.0),
                                         (-emBase) + mad(clamp((-2.0) + _EmissiveChannel, 0.0, 1.0), emBA, nroB), emBase); // _720
                        float emChan = mad(clamp((-3.0) + _EmissiveChannel, 0.0, 1.0), (-emMid) + baseSample.w, emMid);    // _723 (Opacity = decalAlbedo.a)
                        float exposure = mad(_IgnorePostExposure_at_200, (-1.0) + _ExposureParams.x, 1.0); // _756
                        o.emissive.x = ((emChan * _EmissiveColor.x) * mad(_AlbedoAffectEmissive_at_196, mad(-vcR, albSelR, 1.0), vaR)) / exposure; // b24:294
                        o.emissive.y = ((emChan * _EmissiveColor.y) * mad(_AlbedoAffectEmissive_at_196, mad(-vcG, albSelG, 1.0), vaG)) / exposure; // b24:295
                        o.emissive.z = ((emChan * _EmissiveColor.z) * mad(_AlbedoAffectEmissive_at_196, mad(-vcB, albSelB, 1.0), vaB)) / exposure; // b24:296
                        o.emissive.w = opacity;          // b24:318 (SV_Target.w = _798 = angle-faded opacity)
                    #else
                        // b22:287-295: clamp driver = _AngleBlendFallOff ; per-channel = c12.xyz aliases ;
                        //   exposure-gate = _IgnorePostExposure ; albedo-affect factor = _AlbedoAffectEmissive.
                        float emBase = mad(clamp(_AngleBlendFallOff, 0.0, 1.0), emG, nroR); // _706
                        float emMid  = mad(clamp((-1.0) + _AngleBlendFallOff, 0.0, 1.0),
                                         (-emBase) + mad(clamp((-2.0) + _AngleBlendFallOff, 0.0, 1.0), emBA, nroB), emBase); // _720
                        float emChan = mad(clamp((-3.0) + _AngleBlendFallOff, 0.0, 1.0), (-emMid) + baseSample.w, emMid);    // _723 (Opacity = decalAlbedo.a)
                        float exposure = mad(_IgnorePostExposure, (-1.0) + _ExposureParams.x, 1.0); // _756
                        // Per-OUTPUT-channel selector = _EmissiveChannel(R) / _AlbedoAffectEmissive_at_196(G) /
                        // _IgnorePostExposure_at_200(B) — the decompiler's aliased c12.x/.y/.z. albedo-affect mix:
                        //   lerp(vaC, 1, _AlbedoAffectEmissive) = vaC + _AlbedoAffectEmissive*(1 - vaC). (b22:293-295)
                        o.emissive.x = ((emChan * _EmissiveChannel)             * mad(_AlbedoAffectEmissive, mad(-vcR, albSelR, 1.0), vaR)) / exposure; // b22:293
                        o.emissive.y = ((emChan * _AlbedoAffectEmissive_at_196) * mad(_AlbedoAffectEmissive, mad(-vcG, albSelG, 1.0), vaG)) / exposure; // b22:294
                        o.emissive.z = ((emChan * _IgnorePostExposure_at_200)   * mad(_AlbedoAffectEmissive, mad(-vcB, albSelB, 1.0), vaB)) / exposure; // b22:295
                        o.emissive.w = opacity;          // b22:317 (SV_Target.w = _776 = opacity)
                    #endif
                    // _BLEND_EMISSIVE writes albedo MRT4 = albedo-modulated packed vertex color (b22:326-328 / b24:327-329).
                    o.albedo.x = vaR; o.albedo.y = vaG; o.albedo.z = vaB;
                #elif defined(_BLEND_EMISSIVE)
                    // NOT A GAP: the source Pass0 fragment ladder (decallit.shader:159-193) emits NO
                    //   _BLEND_EMISSIVE && !_COMPLETE_PBR variant — _BLEND_EMISSIVE only ever appears paired with
                    //   _COMPLETE_PBR (b22) or _COMPLETE_PBR+_NORMAL_ANGLE_BLEND (b24), because the emissive channel
                    //   select needs the NRO map (nroR/G/B/.w). With no source blob there is nothing to port 1:1;
                    //   this combo leaves emissive at the base value (0). Authors must enable both toggles together.
                #endif

                // ===== _BLEND_WATER_FLOW: dual flow-distorted normal taps + emissive flag (b26:257-331). =====
                #ifdef _BLEND_WATER_FLOW
                    // Tangent-projection weights from the scene normal (b26:257-261).
                    float w0 = abs(sn1x) * abs(sn1x);            // _519
                    float w1 = abs(sn1z) * abs(sn1z);            // _520
                    float wSum = 1.0 / (w1 + w0);                // _522
                    float wa = w0 * wSum;                        // _523
                    float wb = w1 * wSum;                        // _524
                    // flow phase from the up-component, exp2 over _AngleBlendFallOff2 (b26:262-264).
                    float flowLg = log2(max(abs((-abs(sn1y)) + 1.0), RECIP_GUARD)) * max(0.001, _AngleBlendFallOff2); // _538
                    float flowE = exp2(flowLg);                  // _539/_540
                    // Reconstructed world position components the scroll UVs are built from (b26:198-206):
                    //   _151 = surfaceWS.x, _152 = surfaceWS.y, _149 = surfaceWS.z.
                    float wsX = surfaceWS.x; // _151
                    float wsY = surfaceWS.y; // _152
                    float wsZ = surfaceWS.z; // _149
                    float time = _Time2.y;
                    // 1:1, source = Sub0_Pass0_Fragment_b26.hlsl:267-272,281-286. The water-flow scroll UVs build two
                    //   scrolling sample coordinates from the reconstructed world position, where the decompiler aliases
                    //   the EMISSIVE cbuffer fields as the WATER cbuffer: _EmissiveColor.xy = flow tiling (b26:267-270
                    //   _548=_149*_EmissiveColor.x, _549=(_146/_148)*_EmissiveColor.y, _550=_151*_EmissiveColor.x,
                    //   _551=_152*_EmissiveColor.y); _IgnorePostExposure_at_200 (Pair A) / _EmissiveChannel (Pair B) =
                    //   the world-scroll speed (mad 2nd factor); _IgnorePostExposure = the flowE blend gate (mad 1st
                    //   factor); _EmissiveChannel (Pair A) / _AlbedoAffectEmissive_at_196 (Pair B) = the _Time.y scroll
                    //   speed. _541=_542=0 and the per-pair mad addends asfloat(0u)=0 (b26:265-266). The U axis carries
                    //   wsZ (Pair*0) vs wsX (Pair*1); the V axis carries wsY in every tap. Sampled 4x from T2=_WaterNormalTex
                    //   (sampler_LinearRepeat = s1) and blended by wa/wb into the detail normal (_725/_729/_730 below).
                    // Pair A (b26:271-272 _583/_591): U = wsZ|wsX * flowTileX * _IgnorePostExposure_at_200 ;
                    //   V = flowE*_IgnorePostExposure + wsY*flowTileY*_IgnorePostExposure_at_200 + time*_EmissiveChannel.
                    float2 flowUV0 = float2(mad(0.0,   _IgnorePostExposure, mad(wsZ * _EmissiveColor.x, _IgnorePostExposure_at_200, 0.0)),
                                            mad(flowE, _IgnorePostExposure, mad(wsY * _EmissiveColor.y, _IgnorePostExposure_at_200, time * _EmissiveChannel)));
                    float2 flowUV1 = float2(mad(0.0,   _IgnorePostExposure, mad(wsX * _EmissiveColor.x, _IgnorePostExposure_at_200, 0.0)),
                                            mad(flowE, _IgnorePostExposure, mad(wsY * _EmissiveColor.y, _IgnorePostExposure_at_200, time * _EmissiveChannel)));
                    float4 wt0 = SAMPLE_TEXTURE2D_BIAS(_WaterNormalTex, sampler_LinearRepeat, flowUV0, _GlobalMipBias); // _583
                    float4 wt1 = SAMPLE_TEXTURE2D_BIAS(_WaterNormalTex, sampler_LinearRepeat, flowUV1, _GlobalMipBias); // _591
                    float wnx0 = NormalDeadZone(mad(wt0.x, 2.0, -1.0)); // _606
                    float wny0 = NormalDeadZone(mad(wt0.y, 2.0, -1.0)); // _608
                    float wnx1 = NormalDeadZone(mad(wt1.x, 2.0, -1.0)); // _618
                    float wny1 = NormalDeadZone(mad(wt1.y, 2.0, -1.0)); // _620
                    // Pair B (b26:281-290): second scroll using _AlbedoAffectEmissive_at_196 as the alt speed.
                    float2 flowUV2 = float2(mad(0.0,   _IgnorePostExposure, mad(wsZ * _EmissiveColor.x, _EmissiveChannel, 0.0)),
                                            mad(flowE, _IgnorePostExposure, mad(wsY * _EmissiveColor.y, _EmissiveChannel, time * _AlbedoAffectEmissive_at_196)));
                    float2 flowUV3 = float2(mad(0.0,   _IgnorePostExposure, mad(wsX * _EmissiveColor.x, _EmissiveChannel, 0.0)),
                                            mad(flowE, _IgnorePostExposure, mad(wsY * _EmissiveColor.y, _EmissiveChannel, time * _AlbedoAffectEmissive_at_196)));
                    float4 wt2 = SAMPLE_TEXTURE2D_BIAS(_WaterNormalTex, sampler_LinearRepeat, flowUV2, _GlobalMipBias); // _648
                    float4 wt3 = SAMPLE_TEXTURE2D_BIAS(_WaterNormalTex, sampler_LinearRepeat, flowUV3, _GlobalMipBias); // _667
                    float wnx2 = NormalDeadZone(mad(wt2.x, 2.0, -1.0)); // _661
                    float wny2 = NormalDeadZone(mad(wt2.y, 2.0, -1.0)); // _663
                    float wnx3 = NormalDeadZone(mad(wt3.x, 2.0, -1.0)); // _680
                    float wny3 = NormalDeadZone(mad(wt3.y, 2.0, -1.0)); // _682
                    // blended water detail Z + tangent XY by wa/wb (b26:291-293).
                    float wDetZ = mad(sqrt(max((-dot(float2(wnx2, wny2), float2(wnx2, wny2))) + 1.0, 0.0)), wa,
                                    wb * sqrt(max((-dot(float2(wnx3, wny3), float2(wnx3, wny3))) + 1.0, 0.0)))
                                + mad(sqrt(max((-dot(float2(wnx0, wny0), float2(wnx0, wny0))) + 1.0, 0.0)), wa,
                                    wb * sqrt(max((-dot(float2(wnx1, wny1), float2(wnx1, wny1))) + 1.0, 0.0))); // _725
                    float wDetX = (mad(wnx2, wa, wb * wnx3) + mad(wnx0, wa, wb * wnx1)) * _AngleBlendFallOff; // _729
                    float wDetY = (mad(wny2, wa, wb * wny3) + mad(wny0, wa, wb * wny1)) * _AngleBlendFallOff; // _730
                    // re-blend onto scene normal exactly like the base path but with the water detail (b26:297-299).
                    float wbnX = mad(wDetZ, mad(_BlendSceneNormal, mad(sn1x, snInv2, -d1.x), d1.x),
                                 mad(wDetX, mad(_BlendSceneNormal, mad(d2.x, a0Inv, -d2.x), d2.x),
                                     wDetY * mad(_BlendSceneNormal, mad(mad(sn2y, a0z, -(sn2z * a0y)), axisSign, -bX), bX)));
                    float wbnY = mad(wDetZ, mad(_BlendSceneNormal, mad(sn1y, snInv2, -d1.y), d1.y),
                                 mad(wDetX, mad(_BlendSceneNormal, mad(d2.y, a0Inv, -d2.y), d2.y),
                                     wDetY * mad(_BlendSceneNormal, mad(mad(sn2z, a0x, -(sn2x * a0z)), axisSign, -bY), bY)));
                    float wbnZ = mad(wDetZ, mad(_BlendSceneNormal, mad(sn1z, snInv2, -d1.z), d1.z),
                                 mad(wDetX, mad(_BlendSceneNormal, mad(d2.z, a0Inv, -d2.z), d2.z),
                                     wDetY * mad(_BlendSceneNormal, mad(mad(sn2x, a0y, -(sn2y * a0x)), axisSign, -bZ), bZ)));
                    float wOpacity = ((baseSample.w * flowE) * (float(pc >> 24u) * _DecalOpacity)) * INV_255; // _863/_864
                    float wInv = rsqrt(max(dot(float3(wbnX, wbnY, wbnZ), float3(wbnX, wbnY, wbnZ)), FLT_MIN_GUARD)); // _869
                    float waX = mad(_AffectNormal, mad(wbnX, wInv, -sn1x), sn1x); // _879
                    float waY = mad(_AffectNormal, mad(wbnY, wInv, -sn1y), sn1y); // _880
                    float waZ = mad(_AffectNormal, mad(wbnZ, wInv, -sn1z), sn1z); // _881
                    float waN = rsqrt(dot(float3(waX, waY, waZ), float3(waX, waY, waZ))); // _885
                    float wfX = waX * waN, wfY = waY * waN, wfZ = waZ * waN; // _886-888
                    float wDenom = dot(float3(1.0,1.0,1.0), float3(abs(wfX), abs(wfY), abs(wfZ))); // _892
                    float woX = wfX / wDenom, woZ = wfZ / wDenom;            // _895/_896
                    bool wFold = 0.0 >= wfY;                                  // _897
                    float woXf = wFold ? (((woX >= 0.0) ? 1.0 : -1.0) * ((-abs(woZ)) + 1.0)) : woX;
                    float woZf = wFold ? (((woZ >= 0.0) ? 1.0 : -1.0) * ((-abs(woX)) + 1.0)) : woZ;
                    o.normalRough.x = mad(woXf, 0.5, 0.5);  // b26:314
                    o.normalRough.y = mad(woZf, 0.5, 0.5);  // b26:315
                    o.normalRough.z = ((wt0.z + wt1.z) * _AlbedoAffectEmissive) * 0.5; // b26:316 (water roughness)
                    o.normalRough.w = wOpacity;
                    o.metalAO.w = wOpacity; o.albedo.w = wOpacity;
                    // water sets MRT1 = (0,0,1,emissiveFlag) (b26:320,325-327): .z=1, .w = (flow>0)?asfloat(1059816734u):0.
                    // asfloat(1059816734u) ~= 0.6538119 — emitted verbatim to avoid hand-decode error (b26:320).
                    o.ditherMV = float4(0.0, 0.0, 1.0, (0.0 < (baseSample.w * flowE * (float(pc >> 24u) * _DecalOpacity))) ? asfloat(1059816734u) : 0.0);
                    // metallic/ao recomputed by base path above (b26:317-319 identical to base).
                #endif

                return o;
            }
            ENDHLSL
        }
    }
}
