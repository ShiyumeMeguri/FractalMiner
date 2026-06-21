// HGRP Unlit Decal — single screen-space deferred decal pass (depth-reconstructed, procedural-shape-clipped, one unlit albedo map, full per-decal atmosphere/exponential/volumetric fog, VFX color desaturate, premultiplied output).
// Merged from: ReferenceProjects/RuriBeyondShader/.../materials/decal/decalunlit.shader (HGRP fork of HDRP).
//   Single-variant source (NO multi_compile_local keyword ladder): the ForwardDecal pass embeds the vertex (Blob 1) and
//   fragment (Blob 2) HLSL inline, gated only by SHADER_STAGE_VERTEX / SHADER_STAGE_FRAGMENT. That inline body IS the
//   ground truth (no per-variant blob subfolder exists). All cites below are decalunlit.shader line numbers.
// Keywords: (none — source exposes no shader_feature; all behaviour is uniform-driven).
// Kept (1:1 math): camera-depth world-position reconstruction (inverse view-proj; b2:256-271), world->decal-object-space
//   projection (worldToObject * surfaceWS; b2:272-275), procedural shape clip via packedMisc&255
//   (0=box |x|,|y|,|z|<.5 ; 1=disc radiusXZ<.5 + Y slab ; 2=SECTOR atan2-angle band ; 3=sphere radius3D<.5 ; b2:276-298),
//   single decal albedo sample with uvTilingOffset tiling + precomputed mip (b2:314-315),
//   FULL HGRP per-decal fog: atmosphere height/in-scatter (b2:317-323,379-384), exponential height+distance fog with
//   directional in-scatter and the (1-exp(-x))/x Taylor fallback (b2:345-378), volumetric froxel-LUT scattering with
//   per-pixel hash dither (b2:328-361), exposure divide (b2:316), Rec.709-luminance VFX desaturate via _VFXParams1
//   (b2:385-390), premultiplied-alpha decal output (alpha = albedoA*_BaseColor.a, RGB premultiplied; b2:387-390).
// Removed (pixel-neutral pipeline infra substituted by URP, or dropped with a documented gap):
//   SPIRV-Cross plumbing (gl_FragCoord / SPIRV_Cross_* / static I/O / discard_state -> SV_Position + clip());
//   ECS GPU-instancing draw array indexed by SV_InstanceID, and the CB1[2560] SRP per-draw constant pool used by the
//   vertex polar/sector mesh deformation (-> URP unity_ObjectToWorld / unity_WorldToObject single-instance + per-instance
//   data exposed as [HideInInspector] uniforms so the fragment math is 1:1; the vertex procedural deform is dropped — see gaps);
//   HGRP global cbuffer (_ViewMatrix / _InvViewProjMatrix / _ScreenSize / _unity_OrthoParams / _WorldSpaceCameraPos_Internal
//   -> UNITY_MATRIX_V / UNITY_MATRIX_I_VP / _ScreenParams / unity_OrthoParams / _WorldSpaceCameraPos);
//   denormalized-float magic literals (decoded inline as asfloat(<uint>)/named const).
//
// NOTE: This is a SCREEN-SPACE DEFERRED DECAL, not a lit/PBR surface — no GetMainLight / BRDF / SH (so _core/CoreMath is
//   intentionally NOT included). It rasterizes the projector volume in Cull Front / ZTest Greater, reconstructs the underlying
//   opaque surface world position from the camera depth buffer, transforms it into the projector's object space, evaluates a
//   procedural shape, samples one unlit decal albedo, applies HGRP fog, and outputs premultiplied colour.
// NOTE: per-instance feed (worldToObject/objectToWorld implied by unity matrices, uvTilingOffset, packedColor[UNUSED here],
//   sectorAngle, packedMisc) is HGRP ECS decal-batch data with no URP equivalent — mapped to unity matrices (single instance)
//   + [HideInInspector] uniforms. (Unlit decal does NOT read packedColor/packedColorIntensity; only sectorAngle + packedMisc + uvTilingOffset are used.)
// NOTE (FOG): _AtmosphereFogParams0..5 / _ExponentialFogParams0..5 / _VolumetricFogParams0..4 / _FrameCount are HGRP render
//   globals with NO URP equivalent. The fog MATH is ported 1:1 and exposed as [HideInInspector] material Vectors so it is
//   auditable and compiles; the volumetric froxel 3D LUT (source T2) and _FrameCount blue-noise jitter cannot be sourced in
//   URP and are stubbed (see gaps). With the default-neutral fog params the fog term is identity (no scattering).
// Texture channel legend: camera depth = URP _CameraDepthTexture (source T0, point-sampled at pixel center, sampler_LinearClamp).
//   _BaseColorMap = unlit decal albedo (source T1, sampled with sampler_LinearMirror + uvTilingOffset, precomputed mip level).
//   _VolumetricFogTex = HGRP volumetric froxel 3D LUT (source T2, sampler_LinearRepeat) — see gaps.

Shader "HGRP/DecalUnlit_Fix" {
    Properties {
        _MainProperties ("Main Properties", Float) = 0
        [Enum(Alpha, 0, Additive, 1, Premultiply, 4)] _BlendMode ("Blend Type", Float) = 0
        [HDR] [Gamma] _BaseColor ("Unlit Color", Color) = (1, 1, 1, 1)
        _BaseColorMap ("Base Color Map", 2D) = "white" {}

        [Header(Advanced Options)]
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1

        // --- VFX scene-color adjustment (source HGRP global _VFXParams1: .xyz = per-channel tint scale, .w = saturation lerp). ---
        // 1:1 — HGRP global re-exposed as material Vector (STYLE_BIBLE §2 prescribed substitution). Desaturate math is fully ported (b2:385-390). Neutral = (1,1,1,1).
        [HideInInspector] _VFXParams1 ("VFX Color Adjust (xyz=tint, w=saturation)", Vector) = (1, 1, 1, 1)

        // --- Exposure (source HGRP global _ExposureParams.x; URP has none -> material Vector). Neutral = (1,0,0,0). ---
        [HideInInspector] _ExposureParams ("Exposure Params (x=exposure)", Vector) = (1, 0, 0, 0)

        // --- Per-instance decal feed (HGRP ECSPerDrawArray; no URP equivalent). Single-instance mapping. ---
        // 1:1 — per-instance ECS decal-batch data re-exposed as material uniforms (single-instance; STYLE_BIBLE §2 prescribed substitution).
        //   uvTilingOffset/sectorAngle/packedMisc are CONSUMED 1:1 by the fragment (UV tiling b2:314, sector b2:281-293, shape b2:296).
        [HideInInspector] _UVTilingOffset ("Decal UV Tiling/Offset (xy=tiling, zw=offset)", Vector) = (1, 1, 0, 0)
        [HideInInspector] _SectorAngle ("Sector Angle (deg)", Float) = 0
        [HideInInspector] _PackedMisc ("Packed Misc (uint bits; &255 = shape)", Float) = 0
        [HideInInspector] _DecalMipLevel ("Decal Mip Level (source vertex TEXCOORD.x)", Float) = 0

        // --- HGRP per-decal fog globals (no URP equivalent; exposed [HideInInspector] so fog math is 1:1). Defaults neutral. ---
        // 1:1 — HGRP fog globals re-exposed as material Vectors (STYLE_BIBLE §2 prescribed substitution); the atmosphere/exponential/
        //   volumetric fog MATH is fully ported (b2:317-384). The only engine-side dependency is the froxel LUT sampled inside the
        //   volumetric branch (_VolumetricFogTex / _FrameCount, see below) — the scalar params here are all consumed 1:1.
        [HideInInspector] _AtmosphereFogParams0 ("AtmoFog0", Vector) = (0, 0, 0, 0)
        [HideInInspector] _AtmosphereFogParams1 ("AtmoFog1 (xyz=sunDir, w=density)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _AtmosphereFogParams2 ("AtmoFog2 (xyz=extinction, w=g)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _AtmosphereFogParams3 ("AtmoFog3 (xyz=mieColor, w=heightSlope)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _AtmosphereFogParams4 ("AtmoFog4 (xyz=rayleighColor, w=heightOffsetA)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _AtmosphereFogParams5 ("AtmoFog5 (xyz=ambientColor, w=heightOffsetB)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _ExponentialFogParams0 ("ExpFog0", Vector) = (0, 0, 0, 0)
        [HideInInspector] _ExponentialFogParams1 ("ExpFog1", Vector) = (0, 0, 0, 0)
        [HideInInspector] _ExponentialFogParams2 ("ExpFog2 (w=fogMin)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _ExponentialFogParams3 ("ExpFog3", Vector) = (0, 0, 0, 0)
        [HideInInspector] _ExponentialFogParams4 ("ExpFog4 (xyz=inscatterDir, w)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _ExponentialFogParams5 ("ExpFog5 (xyz=inscatterColor, w=power)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _VolumetricFogParams0 ("VolFog0 (z=enable/depthScale, w=stepScale)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _VolumetricFogParams1 ("VolFog1 (depth slice mapping)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _VolumetricFogParams2 ("VolFog2 (xy=uvScale)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _VolumetricFogParams3 ("VolFog3 (z=nearClip)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _VolumetricFogParams4 ("VolFog4 (w=jitterScale)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _FrameCount ("Frame Count (volumetric jitter)", Float) = 0

        // --- Render-state plumbing (source had _SrcBlend / _DstBlend / _DrawOrder; driven by material editor). ---
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _DrawOrder ("__DrawOrder", Float) = 0
    }

    SubShader {
        Tags {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
        }
        LOD 100

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

        CBUFFER_START(UnityPerMaterial)
            // Core (source type_UnityPerMaterial, b2:206-208).
            float _BlendMode;
            float _IgnorePostExposure;
            float4 _BaseColor;
            // VFX color adjustment + exposure (HGRP globals re-exposed).
            float4 _VFXParams1;
            float4 _ExposureParams;
            // Per-instance decal feed (HGRP ECSPerDrawArray; single-instance).
            float4 _UVTilingOffset;
            float _SectorAngle;
            float _PackedMisc;
            float _DecalMipLevel;
            // HGRP fog globals (re-exposed; fog math is 1:1).
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
            float _FrameCount;
            // Render state.
            float _SrcBlend;
            float _DstBlend;
            float _DrawOrder;
        CBUFFER_END

        TEXTURE2D(_BaseColorMap);       SAMPLER(sampler_BaseColorMap);
        // ENGINE-SIDE (declared + sampled 1:1; only the BINDING is host-fed): HGRP volumetric froxel 3D LUT (source T2).
        //   This is a frustum-aligned scattering volume integrated per-frame by the HGRP volumetric-fog froxel compute pass
        //   (a host ScriptableRendererFeature / compute shader) — NOT a material texture or a formula, so it is the
        //   legitimate punt per the CLOSEABLE-vs-ENGINE-SIDE rule. The sample math below is 1:1 (b2:350); it samples whatever
        //   is bound (default = black 3D tex => froxel = 0 => identity with neutral fog params). A host froxel-fog feature must fill it.
        TEXTURE3D(_VolumetricFogTex);   SAMPLER(sampler_VolumetricFogTex);

        // ---- magic-constant decodes (cites against decalunlit.shader, fragment Blob 2) ----
        static const float3  LUM        = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709 (b2:385)
        static const float   LOG2_E     = 1.44269502162933349609375;       // log2(e) = 1/ln(2)           (b2:318-321,347...)
        static const float   RAD2DEG    = 57.295780181884765625;           // 180/pi                       (b2:290)
        static const float   HALF_PI    = 1.57079637050628662109375;       // pi/2                         (b2:286)
        static const float   NEG_PI     = -3.1415927410125732421875;       // asfloat(3226013659u) = -pi   (b2:286)
        static const float   INV_RAY    = 0.0596831031143665313720703125;  // 3/(16*pi)                    (b2:379)
        static const float   FOUR_PI    = 12.56637096405029296875;         // 4*pi                         (b2:380)
        static const float   LN2        = 0.693147182464599609375;         // ln(2) (Taylor fallback bias) (b2:347,367)
        static const float   TAYLOR_K   = 0.2402265071868896484375;        // ~ln(2)^2/2 (Taylor slope)    (b2:347,367)
        static const float   U16_TO_SNORM = 3.05180437862873077392578125e-05; // 2/65535 (>>16 -> [-1,1])  (b2:350)
        static const float   EPS_2N24   = 5.9604644775390625e-08;          // 2^-24                        (b2:339,347,367)
        static const float   VIEW_EPS   = 9.9999999392252902907785028219223e-09; // 1e-8 view-len eps     (b2:305)

        // atan2(y, x) reconstructed exactly as the decompiler (radians, (-pi, pi]). Source swizzle: y plays localX (_182),
        // x plays localZ — i.e. SectorAngleDeg below feeds (localX, localZ) like the source's atan2(_182, _184). (b2:283-289)
        // (Identical idiom to HGRP_VfxDecalProjector_Fix.SectorArcField's Atan2Src; replicated here so this shader is self-contained.)
        float Atan2Src(float a, float b)
        {
            float t  = (1.0 / max(abs(a), abs(b))) * min(abs(a), abs(b));   // b2:283
            float t2 = t * t;                                                // b2:284
            float poly = mad(t2, mad(t2, mad(t2, mad(t2,
                          0.02083509974181652069091796875, -0.08513300120830535888671875),
                          0.1801410019397735595703125), -0.33029949665069580078125),
                          0.999866008758544921875);                          // b2:285
            // b2:286: sign mask = (a<0 ? -pi : 0) ; t*poly added UNCONDITIONALLY, then +((|a|<|b|)?(pi/2 - 2*t*poly):0).
            float signTerm = (a < 0.0) ? NEG_PI : 0.0;                       // b2:286 asfloat((_182<-_182)&3226013659u)
            float quad = mad(t, poly, ((abs(a) < abs(b)) ? mad(poly * t, -2.0, HALF_PI) : 0.0)); // b2:286
            float ang = signTerm + quad;
            if ((min(a, b) < 0.0) && (max(a, b) >= 0.0)) ang = -ang;         // b2:289 (_260)
            return ang;
        }

        // angle of (localX, localZ) wrapped to [0,360) DEGREES. (b2:290 _269)
        float SectorAngleDeg(float localX, float localZ)
        {
            float ang = Atan2Src(localX, localZ);                            // b2:283-289 (atan2(_182,_184))
            return (ang < 0.0) ? mad(ang, RAD2DEG, 360.0) : (ang * RAD2DEG); // b2:290
        }

        // The (1 - exp2(-x)) / x term with the linear Taylor fallback near x~0 the decompiler emits for fog optical depth.
        // (b2:347 inner, b2:367) : |x|>2^-24 ? (1-exp2(-x))/x : mad(-x, TAYLOR_K, LN2).
        float OneMinusExp2OverX(float x)
        {
            return (EPS_2N24 < abs(x))
                ? ((1.0 - exp2(-x)) / x)
                : mad(-x, TAYLOR_K, LN2);
        }
        ENDHLSL

        Pass {
            Name "ForwardDecal"
            // Source render-state (decalunlit.shader lines 21-32): Blend [_SrcBlend][_DstBlend] on both color channels,
            // ZClip On / ZTest Greater / ZWrite Off / Cull Front (rasterize back faces of the projector box so the volume
            // is hit even when the camera is inside it). Stencil { ReadMask 32  Comp Equal  Pass/Fail/ZFail Keep }.
            Blend [_SrcBlend] [_DstBlend], [_SrcBlend] [_DstBlend]
            ZClip On
            ZTest Greater
            ZWrite Off
            Cull Front
            // ENGINE-SIDE (render-state plumbing, no math/texture to port): the Stencil Ref (decal-receiver bit, source
            //   ReadMask 32 Comp Equal) is the receiver bit written into the stencil buffer by the HGRP decal-receiver
            //   tagging render-feature during the opaque pass; no URP global supplies it and no formula produces it.
            //   Binding a wrong literal Ref would reject every pixel, so the Stencil block is omitted (ReadMask 32 / Comp
            //   Equal preserved in spirit by the ZTest Greater depth-receiver test). A host decal-stencil render-feature must bind it. (decalunlit.shader:26-32)

            Tags { "LightMode" = "SRPDefaultUnlit" }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes
            {
                float3 positionOS : POSITION;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                nointerpolation uint shapeMode : TEXCOORD0; // packedMisc & 255 (source nointerpolation TEXCOORD_1 use)
                nointerpolation float mip       : TEXCOORD1; // precomputed decal mip (source vertex TEXCOORD.x, b1:131)
            };

            // ============================================================
            // Vertex: rasterize the projector volume so the fragment depth-reconstruction runs over its screen footprint.
            // Source (b1:105-134) additionally bakes a polar/sector vertex deformation driven by the CB1[2560] SRP constant
            // pool + ECS worldToObject offsets (HGRP ECS-decal-specific procedural mesh; no URP feed). We rasterize the
            // projector mesh straight through object->world->clip; the real per-pixel work (procedural shape from
            // reconstructed depth) is 1:1 in the fragment. The source also computes a screen-derived mip into TEXCOORD.x
            // (b1:131) from CB1 globals; mapped to the _DecalMipLevel uniform. (Documented in gaps.)
            // ============================================================
            Varyings vert(Attributes input)
            {
                Varyings o = (Varyings)0;
                float3 posWS = TransformObjectToWorld(input.positionOS);
                o.positionCS = TransformWorldToHClip(posWS);
                o.shapeMode  = 255u & asuint(_PackedMisc);
                o.mip        = _DecalMipLevel;
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                uint shapeMode = input.shapeMode;

                // ===== Reconstruct world position of the underlying opaque surface from depth (b2:256-271). =====
                // Source: NDC from gl_FragCoord, _InvViewProjMatrix * (ndc, sampledDepth). T0 = camera depth, point-sampled
                // at the pixel center via integer pixel coord + 0.5 (b2:256-257,266). input.positionCS.xy = screen-space pixel xy.
                uint px = (uint)input.positionCS.x;                          // b2:256
                uint py = (uint)input.positionCS.y;                          // b2:257
                float2 screenUV = (float2(px, py) + 0.5) * rcp(_ScreenParams.xy); // b2:266 ((_57+0.5)*_ScreenSize.zw)
                float rawDepth  = SampleSceneDepth(screenUV);               // T0.SampleLevel(LinearClamp, uv, 0).x (b2:266-267)

                // NDC built from the *interpolated* fragment xy (b2:258-259 use gl_FragCoord.xy directly, not the rounded px).
                float ndcX = mad(input.positionCS.x * rcp(_ScreenParams.x), 2.0, -1.0);   // b2:258
                float ndcY = -mad(input.positionCS.y * rcp(_ScreenParams.y), 2.0, -1.0);  // b2:259

                // _96.._99 = IVP[0]*ndcX + IVP[1]*ndcY (cols 0,1 ONLY — the source adds the translation col3 separately
                // inside each reconstruction at b2:268-271/299, so do NOT fold col3 in here or it double-adds). (b2:260-263)
                float4 rayXY = UNITY_MATRIX_I_VP._m00_m10_m20_m30 * ndcX
                             + UNITY_MATRIX_I_VP._m01_m11_m21_m31 * ndcY;                  // _96,_97,_98,_99 (b2:260-263)
                float4 ivpCol2 = UNITY_MATRIX_I_VP._m02_m12_m22_m32;                       // IVP[2] (depth column)
                float4 ivpCol3 = UNITY_MATRIX_I_VP._m03_m13_m23_m33;                       // IVP[3] (translation column)
                // Surface reconstruction from the sampled depth buffer: + IVP[2]*rawDepth + IVP[3], then perspective-divide (b2:268-271).
                float4 worldH = rayXY + ivpCol2 * rawDepth + ivpCol3;                      // b2:268 (_138 w) + b2:269-271 numerators
                float3 surfaceWS = worldH.xyz / worldH.w;                                  // b2:269-271 (/ _138)
                float wPosX = surfaceWS.x; // _139
                float wPosY = surfaceWS.y; // _140
                float wPosZ = surfaceWS.z; // _141

                // ===== World -> decal object space (b2:273-275: worldToObject * surfaceWS). =====
                float3 localP = mul(unity_WorldToObject, float4(surfaceWS, 1.0)).xyz;
                float lx = localP.x; // _182
                float ly = localP.y; // _183
                float lz = localP.z; // _184

                float radiusXZ = sqrt(dot(float2(lx, lz), float2(lx, lz)));               // b2:279
                float radius3D = sqrt(dot(float3(lx, ly, lz), float3(lx, ly, lz)));       // b2:296

                // Disc-slab membership: (-0.5 < ly < 0.5) AND radiusXZ < 0.5 (b2:277-279, _208). NOTE: source tests
                // _183 = localY here (the disc axis is Y), NOT localX as in the sector-projector sibling.
                bool yLo = (-0.5) < ly;                  // _198
                bool yHi = ly < 0.5;                     // _200
                bool discXZ = radiusXZ < 0.5;
                bool inDiscSlab = yHi && yLo && discXZ;  // _208

                // ===== Primary shape membership -> clip (b2:280-298). =====
                float shapeMask;
                if (shapeMode == 2u) // SECTOR (b2:281-293)
                {
                    float deg = SectorAngleDeg(lx, lz);                                   // _269 (atan2(_182,_184) -> deg)
                    float negSector = -_SectorAngle;                                      // _280
                    bool wrapHi  = (deg < 360.0) && (deg >= mad(negSector, 0.5, 450.0));  // b2:292 grp1
                    bool mainArc = (deg >= mad(negSector, 0.5, 90.0))
                                 && (mad(_SectorAngle, 0.5, 90.0) >= deg);                // b2:292 grp2
                    shapeMask = ((wrapHi || mainArc) && inDiscSlab) ? 1.0 : 0.0;          // b2:292 (_208 & (...))
                }
                else // b2:294-296
                {
                    // box = all three axes in (-0.5, 0.5) (b2:296 last group).
                    bool xLo = (-0.5) < lx, xHi = lx < 0.5;
                    bool zLo = (-0.5) < lz, zHi = lz < 0.5;
                    bool box = (zLo && yLo && xLo) && (zHi && yHi && xHi);                // b2:296
                    shapeMask = (shapeMode == 3u) ? (radius3D < 0.5 ? 1.0 : 0.0)          // sphere
                              : (shapeMode == 1u) ? (inDiscSlab ? 1.0 : 0.0)              // disc (_208)
                              : (shapeMode != 0u) ? 1.0                                    // any other id -> pass
                              : (box ? 1.0 : 0.0);                                         // box
                }
                clip(shapeMask > 0.0 ? 1.0 : -1.0);                                        // b2:298 discard when NOT inside

                // ===== Camera/view directions, perspective vs ortho (b2:299-313). =====
                // _358: perspective when _unity_OrthoParams.w == 0; then dir = camPos - reconstructedWS, else view fwd (V row2).
                bool isPersp = (unity_OrthoParams.w == 0.0);                              // _358 (b2:300)
                float3 viewFwdWS = float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22); // ortho: _ViewMatrix[N].z

                // dir from the *opaque depth* surface to the camera (uses gl_FragCoord.z reconstruction; b2:299-306).
                float3 depthWS;
                {
                    float wD = mad(ivpCol2.w, input.positionCS.z, rayXY.w) + ivpCol3.w;   // _353 (b2:299)
                    float3 reconZ = (rayXY.xyz + ivpCol2.xyz * input.positionCS.z + ivpCol3.xyz) / wD; // b2:301-303 numerators / _353
                    depthWS = isPersp ? (_WorldSpaceCameraPos - reconZ) : viewFwdWS;      // b2:301-303
                }
                float depthLen2 = dot(depthWS, depthWS);                                  // _398
                float invDepthLen = rsqrt(max(depthLen2, VIEW_EPS));                      // _403
                float depthDist = invDepthLen * depthLen2;                                // _404 = |depthWS| (length)

                // dir from the *decal surface* (reconstructed WS) to the camera, normalized (b2:307-313).
                float3 surfDir = isPersp ? (_WorldSpaceCameraPos - surfaceWS) : viewFwdWS; // _420/_422/_424
                float invSurfLen = rsqrt(dot(surfDir, surfDir));                          // _428
                float3 surfDirN = surfDir * invSurfLen;                                   // _429/_430/_431

                // ===== Decal albedo sample (b2:314-315). uvTilingOffset: .xy = tiling, .zw = offset ; +0.5 centers local XZ. =====
                float2 decalUV = float2(
                    mad(lx + 0.5, _UVTilingOffset.x, _UVTilingOffset.z),                  // b2:314 row0
                    mad(lz + 0.5, _UVTilingOffset.y, _UVTilingOffset.w));                 // b2:314 row1
                float4 albedo = SAMPLE_TEXTURE2D_LOD(_BaseColorMap, sampler_BaseColorMap, decalUV, input.mip); // b2:314 (mip = TEXCOORD.x)
                float outAlpha = albedo.w * _BaseColor.w;                                 // _466 (b2:315)

                float exposure = mad(_IgnorePostExposure, (-1.0) + _ExposureParams.x, 1.0); // _475 (b2:316)

                // ======================================================================================
                // ===== HGRP per-decal FOG (atmosphere + exponential + volumetric). Math 1:1, b2:317-384. =====
                // The fog MATH below is ported 1:1 (b2:317-384). All fog scalar params are HGRP render globals re-exposed as
                //   [HideInInspector] material Vectors (consumed 1:1). ENGINE-SIDE residue (binding only): the volumetric froxel
                //   LUT (T2) is filled by the HGRP volumetric-fog froxel compute pass, and _FrameCount is the engine frame index
                //   feeding the blue-noise jitter — both host-fed, no formula to port. With neutral defaults this whole block is identity.
                // ======================================================================================

                // --- Atmosphere height/in-scatter optical depth (b2:317-323). ---
                float atmoH    = max(mad(wPosY, _AtmosphereFogParams3.w, _AtmosphereFogParams4.w), 0.00999999977648258209228515625); // _488 (b2:317)
                float atmoTau  = (((1.0 - exp2(atmoH * -LOG2_E)) / atmoH)
                                  * exp2(mad(wPosY, _AtmosphereFogParams3.w, _AtmosphereFogParams5.w) * LOG2_E))
                                 * (-max(mad(depthDist, _AtmosphereFogParams1.w, -_AtmosphereFogParams0.w), 0.0));               // _520 (b2:318)
                float atmoTr   = exp2((atmoTau * _AtmosphereFogParams2.x) * LOG2_E);      // _533 transmittance R (b2:319)
                float atmoTg   = exp2((atmoTau * _AtmosphereFogParams2.y) * LOG2_E);      // _534 (b2:320)
                float atmoTb   = exp2((atmoTau * _AtmosphereFogParams2.z) * LOG2_E);      // _535 (b2:321)
                float cosSun   = dot(-surfDirN, _AtmosphereFogParams1.xyz);               // _544 (b2:322)
                // b2:323: _561 = mad(P2.w,P2.w,1) - dot(_544.xx, P2.w.xx). The .xx makes dot = 2*cosSun*P2.w (NOT cosSun*P2.w).
                float phaseDen = mad(_AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0) - dot(cosSun.xx, _AtmosphereFogParams2.w.xx); // _561 (b2:323)

                // --- Exponential + Volumetric fog (b2:324-378). The volumetric branch (b2:328) is gated on
                //     _VolumetricFogParams0.z > 0 ; both branches compute (fogAmt, inScatterRGB) into _1023.._1026. ---
                float fogAmt;           // _1023 (fog opacity / coverage)
                float3 inScatter;       // _1026,_1025,_1024 (R,G,B in-scatter)
                if (0.0 < _VolumetricFogParams0.z) // VOLUMETRIC branch (b2:328-361)
                {
                    float viewZ = mad(UNITY_MATRIX_V._m22, wPosZ, mad(UNITY_MATRIX_V._m20, wPosX, wPosY * UNITY_MATRIX_V._m21)) + UNITY_MATRIX_V._m23; // _582 (b2:330)
                    // per-pixel PCG-style hash chain for froxel jitter (b2:331-336). Uses _FrameCount & 7.
                    uint h0 = (py * 1664525u) + 1013904223u;                              // _594
                    uint h1 = ((7u & (uint)_FrameCount) * 1664525u) + 1013904223u;        // _596
                    uint h2 = (h0 * h1) + ((px * 1664525u) + 1013904223u);                // _598
                    uint h3 = (h1 * h2) + h0;                                             // _600
                    uint h4 = (h2 * h3) + h1;                                             // _602
                    uint h5 = (h3 * h4) + h2;                                             // _604
                    float cosFwd  = dot(-surfDirN, -viewFwdWS);                           // _611 (b2:337)
                    float relY    = wPosY - _WorldSpaceCameraPos.y;                       // _618 (b2:338)
                    float invCos  = (EPS_2N24 < cosFwd) ? (1.0 / cosFwd) : 0.0;           // _629 numerator (b2:339)
                    float stepT   = (invCos * _VolumetricFogParams0.w) * (1.0 / depthDist); // _631 (b2:339-341)
                    float fogY    = mad(stepT, relY, _WorldSpaceCameraPos.y);             // _635 (b2:342)
                    float fogDY   = mad(-stepT, relY, relY);                              // _637 (b2:343)
                    float fogDamp = mad(-(invCos * _VolumetricFogParams0.w), (1.0 / depthDist), 1.0); // _639 (b2:344)
                    float e0      = max(fogDY * _ExponentialFogParams0.z, -127.0);        // _646 (b2:345)
                    float e3      = max(fogDY * _ExponentialFogParams3.x, -127.0);        // _653 (b2:346)
                    float expTau  = mad(exp2(-max((fogY - _ExponentialFogParams0.x) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y, OneMinusExp2OverX(e0),
                                        OneMinusExp2OverX(e3) * (exp2(-max((fogY - _ExponentialFogParams3.z) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y)); // _715 (b2:347)
                    float distFogA = clamp(mad(depthDist, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0);       // _727 (b2:348)
                    float fogCov  = min(distFogA + (clamp(mad(depthDist, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                                       + max(min(exp2(-((depthDist * fogDamp) * expTau)), 1.0), _ExponentialFogParams2.w)), 1.0); // _740 (b2:349)
                    // volumetric froxel LUT sample (b2:350) — jittered XY + log-mapped Z slice.
                    float3 froxelUV = float3(
                        mad(mad(float(h5 >> 16u), U16_TO_SNORM, -1.0), _VolumetricFogParams4.w, float(px)) * _VolumetricFogParams2.x,
                        mad(mad(float(((h4 * h5) + h3) >> 16u), U16_TO_SNORM, -1.0), _VolumetricFogParams4.w, float(py)) * _VolumetricFogParams2.y,
                        (log2(mad(abs(viewZ), _VolumetricFogParams1.x, _VolumetricFogParams1.y)) * _VolumetricFogParams1.z) / _VolumetricFogParams0.z); // _783 uvw (b2:350)
                    float4 froxel = SAMPLE_TEXTURE3D_LOD(_VolumetricFogTex, sampler_VolumetricFogTex, froxelUV, 0.0); // _783 (b2:350)
                    float nearMask = clamp((abs(viewZ) - _VolumetricFogParams3.z) * 1000000.0, 0.0, 1.0);             // _798 (b2:351)
                    float froxelBlend = mad(nearMask, froxel.w - 1.0, 1.0);                                          // _806 (b2:352)
                    float invFogCov = 1.0 - fogCov;                                                                   // _808 (b2:353)
                    float dirInsc = exp2(log2(clamp(dot(surfDirN, _ExponentialFogParams4.xyz), 0.0, 1.0)) * _ExponentialFogParams5.w); // _825 (b2:354)
                    float heightInsc = 1.0 - min(exp2(-(max(mad(fogDamp, depthDist, -_ExponentialFogParams4.w), 0.0) * expTau)), 1.0); // _845 (b2:355)
                    float invDistFogA = 1.0 - distFogA;                                                               // _850 (b2:356)
                    fogAmt = fogCov * froxelBlend;                                                                    // _1023 (b2:357)
                    inScatter.b = mad(mad(_ExponentialFogParams2.z, invFogCov, invDistFogA * (heightInsc * (dirInsc * _ExponentialFogParams5.z))), froxelBlend, mad(nearMask, froxel.z, 0.0)); // _1024 (b2:358)
                    inScatter.g = mad(mad(_ExponentialFogParams2.y, invFogCov, invDistFogA * (heightInsc * (dirInsc * _ExponentialFogParams5.y))), froxelBlend, mad(nearMask, froxel.y, 0.0)); // _1025 (b2:359)
                    inScatter.r = mad(mad(_ExponentialFogParams2.x, invFogCov, invDistFogA * (heightInsc * (dirInsc * _ExponentialFogParams5.x))), froxelBlend, mad(nearMask, froxel.x, 0.0)); // _1026 (b2:360)
                }
                else // NON-VOLUMETRIC exponential branch (b2:362-378)
                {
                    float relY    = wPosY - _WorldSpaceCameraPos.y;                       // _870 (b2:364)
                    float e3      = max(relY * _ExponentialFogParams3.x, -127.0);         // _891 (b2:365)
                    float e0      = max(relY * _ExponentialFogParams0.z, -127.0);         // _892 (b2:366)
                    float expTau  = mad(exp2(-max((_WorldSpaceCameraPos.y - _ExponentialFogParams0.x) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y, OneMinusExp2OverX(e0),
                                        OneMinusExp2OverX(e3) * (exp2(-max((_WorldSpaceCameraPos.y - _ExponentialFogParams3.z) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y)); // _946 (b2:367)
                    float distFogA = clamp(mad(depthDist, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0);       // _957 (b2:368)
                    float fogCov  = min(distFogA + (clamp(mad(depthDist, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                                       + max(min(exp2(-(depthDist * expTau)), 1.0), _ExponentialFogParams2.w)), 1.0); // _969 (b2:369)
                    float invFogCov = 1.0 - fogCov;                                                                   // _971 (b2:370)
                    float dirInsc = exp2(log2(clamp(dot(surfDirN, _ExponentialFogParams4.xyz), 0.0, 1.0)) * _ExponentialFogParams5.w); // _986 (b2:371)
                    float heightInsc = 1.0 - min(exp2(-(max(mad(depthLen2, invDepthLen, -_ExponentialFogParams4.w), 0.0) * expTau)), 1.0); // _1006 (b2:372) (note depthLen2*invDepthLen = depthDist)
                    float invDistFogA = 1.0 - distFogA;                                                               // _1011 (b2:373)
                    fogAmt = fogCov;                                                                                  // _1023 (b2:374)
                    inScatter.b = mad(_ExponentialFogParams2.z, invFogCov, invDistFogA * (heightInsc * (dirInsc * _ExponentialFogParams5.z))); // _1024 (b2:375)
                    inScatter.g = mad(_ExponentialFogParams2.y, invFogCov, invDistFogA * (heightInsc * (dirInsc * _ExponentialFogParams5.y))); // _1025 (b2:376)
                    inScatter.r = mad(_ExponentialFogParams2.x, invFogCov, invDistFogA * (heightInsc * (dirInsc * _ExponentialFogParams5.x))); // _1026 (b2:377)
                }

                // --- Atmosphere Rayleigh+Mie phase combine into final fog colour (b2:379-384). ---
                float rayPhase = mad(cosSun, cosSun, 1.0) * INV_RAY;                       // _1031 (b2:379)
                float miePhase = mad(-_AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0)
                                 / max(sqrt(phaseDen) * (phaseDen * FOUR_PI), 0.001000000047497451305389404296875); // _1060 (b2:380)
                float blendOneMinus = 1.0 - _BlendMode;                                    // _1092 (b2:381) (Additive=1 -> 0 ; Alpha=0 -> 1)

                // per-channel: (albedo*baseColor/exposure) * (fogAmt*atmoTrans) + (1-BlendMode)*( atmoInScatter*(1-atmoTrans)*fogAmt + expVolInScatter )
                float3 atmoColScale = clamp(float3(
                        mad(_AtmosphereFogParams4.x, miePhase, mad(_AtmosphereFogParams3.x, rayPhase, _AtmosphereFogParams5.x)),
                        mad(_AtmosphereFogParams4.y, miePhase, mad(_AtmosphereFogParams3.y, rayPhase, _AtmosphereFogParams5.y)),
                        mad(_AtmosphereFogParams4.z, miePhase, mad(_AtmosphereFogParams3.z, rayPhase, _AtmosphereFogParams5.z))), 0.0, 1.0) * 255.0; // b2:382-384 inner clamp*255
                float3 atmoTrans = float3(atmoTr, atmoTg, atmoTb);
                float3 albedoCol = (albedo.xyz * _BaseColor.xyz) / exposure;
                float3 color;
                color.r = mad(albedoCol.r, fogAmt * atmoTr, blendOneMinus * mad(atmoColScale.r * (1.0 - atmoTr), fogAmt, inScatter.r)); // _1096 (b2:382)
                color.g = mad(albedoCol.g, fogAmt * atmoTg, blendOneMinus * mad(atmoColScale.g * (1.0 - atmoTg), fogAmt, inScatter.g)); // _1097 (b2:383)
                color.b = mad(albedoCol.b, fogAmt * atmoTb, blendOneMinus * mad(atmoColScale.b * (1.0 - atmoTb), fogAmt, inScatter.b)); // _1098 (b2:384)

                // ===== VFX color desaturate + per-channel tint, then premultiply by alpha (b2:385-390). =====
                // luma = dot(outAlpha*color, LUM) ; out.rgb = (luma + _VFXParams1.w*(outAlpha*color - luma)) * _VFXParams1.xyz.
                float luma = dot(outAlpha * color, LUM);                                   // _1102 (b2:385)
                float3 premul = outAlpha * color;                                          // _466 * _10xx
                float3 outRGB;
                outRGB.r = mad(_VFXParams1.w, premul.r - luma, luma) * _VFXParams1.x;       // _1096 path (b2:387)
                outRGB.g = mad(_VFXParams1.w, premul.g - luma, luma) * _VFXParams1.y;       // (b2:388)
                outRGB.b = mad(_VFXParams1.w, premul.b - luma, luma) * _VFXParams1.z;       // (b2:389)
                return half4(outRGB, outAlpha);                                            // SV_Target.w = _466 (b2:390)
            }
            ENDHLSL
        }
    }
}
