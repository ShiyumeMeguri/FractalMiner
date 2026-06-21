// HGRP GPU-clipmap virtual-texture terrain -> clean URP terrain surface. ForwardLit + ShadowCaster + DepthOnly + DepthNormals.
// Merged from: hgterrainps (HGRP/HGTerrainPS). Base (#else catch-all) variants: HGBuffer V=b5/F=b6, FallbackGBuffer V=b467/F=b468 (non-VT splat path), TerrainShadowCaster F=b332, TerrainDepthOnly F=b40.
// Keywords: _FAKEGLINT (view-dependent sparkle, b484 — ported as shader_feature). Water ripple is ALWAYS-ON in the base blob,
//   gated by the _WaterInteractionParams0.y uniform (NOT a keyword) — b6:731-754,777.
// Feature-keyword audit (GBuffer pass multi_compile_local, skeleton:35-39/278-284/3844-3848):
//   _FAKEGLINT          -> CLOSED here (albedo+smoothness sparkle; b484:419-440). shader_feature, default OFF.
//   _TERRAIN_WET_RIPPLE -> folded ALWAYS-ON (the b6 base already runs it); includes the +0.1*ripStrength smoothness boost (b6:777).
//   _FAKE_SHADOW        -> EXCLUDED, correct: its GBuffer store is byte-identical to base b6 (b8 == b6, no surface-value delta).
//   _SUBSURFACE_PROFILE -> EXCLUDED, correct: base albedo/normal/metal/smooth UNCHANGED (b476:394-420); only packs deferred-SSS
//                          channels (MRT2.xy=MRT3.xy + 8-bit profile MRT4.w, b476:429-432) consumed by HG's deferred SSS lighting
//                          resolve (downstream host pass, not in these blobs / not representable in URP forward).
//   _FAKE_VOLUME        -> CLOSEABLE in principle (modifies albedo via fake-interior parallax/refraction, b472:417-549) but NOT
//                          ported: its steep-parallax + IoR-refraction ray-march (2 loops, b472:430-535) dots the WORLD view dir
//                          against TANGENT-space normal components and marches a world-XZ height field — intrinsically coupled to
//                          HG's patch-aligned (world-XZ = tangent-UV, world-up = tangent-Z) coordinate convention, which this port
//                          DROPPED (HG GPU-clipmap patch grid -> Unity mesh). A byte-1:1 transcription would have to reintroduce
//                          that removed infra; a TBN-correct version deviates from the blob. Port-pending under #ifdef _FAKE_VOLUME
//                          (default OFF) with Unity compile + visual verification — NOT an engine-side punt (no host); a coordinate-coupling blocker.
// Kept (1:1 math, cite blob file:line) — the terrain surface assembly from the baked VT atlas:
//   atlas channel binding (b468:355-371 / b6:706-722):
//     T0 (_NormalMaskMap): .x,.y = tangent-space normal XY (decoded x*2-1), .z = metallic, .w = smoothness.
//     T1 (_BaseColorMap) : .x,.y,.z = albedo RGB.
//     T2 (_HeightMap)    : .w = baked-AO source.
//   bakedAO = clamp(heightMap.w - 0.5, 0, 1)                         (b468:361 / b6:714)
//   aoFactor = min(bakedAO * 2.17391300201416015625, 1)             (b468:373 _784 / b6:727 _1659)
//   albedo  = mad(aoFactor*c, -0.35000002384185791015625, c)        (b468:374-376 / b6:728-730)
//   metallic = mad(aoFactor*m, -0.10000002384185791015625, m), m = T0.z (b468:384 _778 / b6:762 _1644)
//   smoothness = mad(aoFactor, -s, s) = s*(1-aoFactor), s = T0.w     (base term: b468:399 _776 / b6:777 inner mad)
//   + wet smoothness boost: smoothness += 0.1 * ripStrength          (b6:777 OUTER mad — ALWAYS-ON; was dropped, now restored)
//   tangent-space normal: nx=mad(T0.x,2,-1), ny=mad(T0.y,2,-1), nz=sqrt(max(1-dot(xy,xy),0)) (b468:356,357,363 / b6:707,708,720)
//   subsurface-mask pack: (1 - min(|2*ssMask-1|,1)) * heightmapUVOffset-lerp (b6:780 / b468:402) — documented, scalar-out for parity.
//   water-ripple normal perturbation (ALWAYS-ON, world-space blend; b6:731-754,777): wet broadens AO -> flattens the world
//   terrain normal toward geometric-up by 0.98*aoFactor, then blends in the ripple normal (transformed through the terrain
//   world TBN) by weight ripTex.w * discMask * (max(aoFactor-0.2,0)*1.25) * _WaterInteractionParams1.y. disc length<=0.5.
// Removed (pixel-neutral pipeline infra, substituted by URP facilities per CORE_MATH §2.12 / STYLE_BIBLE §2):
//   HG GPU-clipmap procedural patch-grid vertex synthesis + heightmap displacement + LOD-transition stitching (b5) -> Unity terrain mesh + GetVertexPositionInputs;
//   HG virtual-texture page-table indirection (_IndirectionMap/_NodeAtlasMap, the VT feedback U0.Store + parallax-occlusion VT raymarch loops b6:367-543 / b468:207-256) -> direct splat/atlas sampling (the non-VT `else` branch b468:318-372 / b6:669-723 IS the faithful surface);
//   HG deferred 5-MRT GBuffer (MRT0..4 pack, b6:728-788 / b468:374-410) -> URP ForwardLit (lighting resolved in-fragment);
//   HG octahedral world-normal encode into MRT3.xy (b6:1900-1910 / b468:393-398) -> URP DepthNormals stores raw world normal;
//   IV-clipmap GI -> SampleSH; HG reflection-probe binning -> GlossyEnvironmentReflection; CSM/ASM atlas -> URP main-light shadow;
//   HG motion-vector + TAAU normal MRT1 pack (b6:760-761 / b468:382-383) -> URP MotionVectors pass (dropped); TAA jitter (-> none).
//
// NOTE: the GBuffer base blob (b6/b468) has NO UnityPerMaterial cbuffer and NO PBR sliders — every surface value is read from the
//   baked atlas. _BaseColor/_NormalScale/_Metallic/_Specular/_Smoothness sliders below are URP authoring conveniences and DEFAULT
//   to no-op (multiply-by-1 / add-0) so the out-of-box result is the faithful baked atlas. The per-layer splat blend that produced
//   the atlas runs in a SEPARATE HG VT bake pass (not in this shader); the atlas CONTENT is sampled 1:1, the VT UV addressing is dropped infra.
//   ForwardLit lighting altitude: resolved via URP UniversalFragmentPBR (URP PBR semantics), NOT the HG deferred lighting pass (which is
//   downstream of this GBuffer writer and not in these blobs) — correct architectural substitution per CORE_MATH §1/§2.12.

Shader "HGRP/HgTerrainPS_Fix" {
    Properties {
        // ============================================================
        // Blend-state plumbing (opaque terrain; HG source HGBuffer = ZTest Less, ZWrite On, opaque)
        // ============================================================
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [Enum(UnityEngine.Rendering.CullMode)] _Cull ("Cull", Float) = 1   // HG TerrainShadowCaster = Cull Off; HGBuffer no override -> Back(1) default

        // ============================================================
        // Baked terrain VT atlas, re-exposed as standard maps (channel legend in header NOTE)
        // ============================================================
        // T1: albedo RGB (b468:358 / b6:709)
        _BaseColorMap ("Albedo (atlas T1, .rgb)", 2D) = "white" {}
        _BaseColor ("Base Color (authoring tint, no-op=white)", Color) = (1, 1, 1, 1)
        // T0: .xy = TS normal, .z = metallic, .w = smoothness (b468:355-357,369,370 / b6:706-708,717,722)
        _NormalMaskMap ("Normal+Mask (atlas T0, .xy=N .z=metal .w=smooth)", 2D) = "bump" {}
        _NormalScale ("Normal Scale (authoring, no-op=1)", Range(0, 2)) = 1
        // T2: .w = baked AO (b468:361 / b6:714)
        _HeightMap ("Height-AO (atlas T2, .w baked AO)", 2D) = "white" {}
        // Authoring no-op overrides (GBuffer base has NO such sliders; defaults keep atlas as-is)
        _Metallic ("Metallic (authoring add, no-op=0)", Range(0, 1)) = 0
        _Specular ("Specular (authoring only; GBuffer reflectance ch = 0, no-op)", Range(0, 1)) = 0.5
        _SmoothnessScale ("Smoothness Scale (authoring, no-op=1)", Range(0, 2)) = 1

        // ============================================================
        // Water ripple (HG always-on, gated by _WaterInteractionParams0.y; b6:731-754,777)
        // _WaterInteractionParams0 = (centerBaseOffset, intensity, centerX, centerZ); _WaterInteractionParams1 = (uvScale, strength, _, _)
        // ============================================================
        [Header(Water Ripple)]
        _RippleNormalMap ("Ripple Normal Map (T3)", 2D) = "bump" {}
        _WaterInteractionParams0 ("Ripple Params 0 (off,intensity,cx,cz)", Vector) = (0, 0, 0, 0)
        _WaterInteractionParams1 ("Ripple Params 1 (uvScale,strength,_,_)", Vector) = (1, 1, 0, 0)

        // ============================================================
        // Subsurface (HG SV_Target_4.w pack; b6:780) — terrain subsurface mask scalar (kept for parity, not consumed in URP forward)
        // ============================================================
        [Header(Subsurface)]
        _SubsurfaceMask ("Subsurface Mask", Range(0, 1)) = 0

        // ============================================================
        // Fake glint (HG _FAKEGLINT; b484:419-440) — view-dependent sparkle over a world-XZ-tiled glint field.
        // Toggle stands in for the baked-away per-layer glint-type gate (b484:420 _910). Default OFF.
        // ============================================================
        [Header(Fake Glint)]
        [Toggle(_FAKEGLINT)] _UseFakeGlint ("Enable Fake Glint", Float) = 0
        _GlintMap ("Glint Normal/Noise (b484 T9, world-XZ tiled)", 2D) = "bump" {}
        [HDR] _GlintColor ("Glint Color (.rgb tint, .a weight)", Color) = (1, 1, 1, 1)
        _GlintStrength ("Glint Strength", Range(0, 4)) = 1
        _GlintScale ("Glint Tiling (world XZ)", Float) = 1
        _GlintThreshold ("Glint Threshold", Range(0, 0.999)) = 0.5
        _GlintTopBlendSmoothness ("Glint Top-Blend Smoothness", Range(0.001, 1)) = 0.1
        _GlintTopBlendThreshold ("Glint Top-Blend Threshold", Range(0, 1)) = 0.5
        _GlintFadeDistance ("Glint Fade Distance", Float) = 50
    }

    SubShader {
        Tags {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Opaque"
            "Queue" = "Geometry"
            "TerrainCompatible" = "true"
        }
        LOD 600

        // ============================================================================================
        // Shared HLSL: URP includes + material cbuffer + textures + helpers (CORE_MATH §0/§2 spine).
        // ============================================================================================
        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

        CBUFFER_START(UnityPerMaterial)
            float4 _BaseColorMap_ST;
            float4 _BaseColor;
            float  _NormalScale;
            float  _Metallic;
            float  _Specular;
            float  _SmoothnessScale;
            // Water ripple (b6 _WaterInteractionParams0/1)
            float4 _WaterInteractionParams0;
            float4 _WaterInteractionParams1;
            float  _SubsurfaceMask;
            // Fake glint (b484 _Glint*)
            float4 _GlintMap_ST;
            float4 _GlintColor;
            float  _GlintStrength;
            float  _GlintScale;
            float  _GlintThreshold;
            float  _GlintTopBlendSmoothness;
            float  _GlintTopBlendThreshold;
            float  _GlintFadeDistance;
            float  _Cull;
        CBUFFER_END

        TEXTURE2D(_BaseColorMap);    SAMPLER(sampler_BaseColorMap);
        TEXTURE2D(_NormalMaskMap);   SAMPLER(sampler_NormalMaskMap);
        TEXTURE2D(_HeightMap);       SAMPLER(sampler_HeightMap);
        TEXTURE2D(_RippleNormalMap); SAMPLER(sampler_RippleNormalMap);
        TEXTURE2D(_GlintMap);        SAMPLER(sampler_GlintMap);     // b484 T9 (_FAKEGLINT, world-XZ tiled)

        // ---- magic constants decoded from blob (STYLE_BIBLE §4) ----
        static const float AO_GAIN          = 2.17391300201416015625;      // b6:727 / b468:373  occ -> aoFactor gain (= 1/0.46)
        static const float AO_ALBEDO_DARK   = -0.35000002384185791015625;  // b6:728-730 / b468:374-376 albedo *= mad(aoFactor*c,-0.35,1)
        static const float AO_METAL_DARK    = -0.10000002384185791015625;  // b6:762 / b468:384 metallic darken
        static const float WET_NORMAL_FLAT  = 0.980000019073486328125;     // b6:738 _1739  wet flattens world normal by 0.98*aoFactor
        static const float WET_BROADEN      = 1.25;                        // b6:731 _1674  wetAmt = max(aoFactor-0.2,0)*1.25
        static const float WET_BROADEN_SUB  = 0.20000000298023223876953125;// b6:731  aoFactor-0.2
        static const float WET_SMOOTH_BOOST = 0.100000001490116119384765625;// b6:777  smoothness += 0.1 * ripStrength (wet -> shinier)
        static const float NRM_FLAT_EPS     = 1.1754943508222875079687365372222e-38; // b6:763  FLT_MIN rsqrt guard

        // Unpack the atlas tangent-space normal stored as (.x,.y) in [0,1], derive +Z.
        // GBuffer base applies NO scale (b468:356-357 / b6:707-708); _NormalScale is an authoring no-op (default 1).
        float3 UnpackTerrainNormal(float2 packedXY, float scale)
        {
            float nx = mad(packedXY.x, 2.0, -1.0) * scale;   // b468:356  _690 = mad(_684.x,2,-1)
            float ny = mad(packedXY.y, 2.0, -1.0) * scale;   // b468:357  _692 = mad(_684.y,2,-1)
            // b468:363  nz = sqrt(max(1 - dot(xy,xy), 0))
            float nz = sqrt(max(1.0 - dot(float2(nx, ny), float2(nx, ny)), 0.0));
            return float3(nx, ny, nz);
        }
        ENDHLSL

        // =====================================================================================
        // ForwardLit — the HG "HGBuffer"/"FallbackGBuffer" surface, resolved in-fragment (URP).
        // HG: LIGHTMODE=GBuffer, ZTest Less, ZWrite On (opaque terrain).
        // =====================================================================================
        Pass {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForward" }
            ZTest LEqual
            ZWrite [_ZWrite]
            Cull [_Cull]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            // URP lighting system keywords
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
            #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
            #pragma multi_compile_fragment _ _SHADOWS_SOFT
            #pragma multi_compile _ _SCREEN_SPACE_OCCLUSION
            #pragma multi_compile_fog
            #pragma multi_compile _ LIGHTMAP_ON
            #pragma multi_compile _ DIRLIGHTMAP_COMBINED

            // HG material-feature keyword (source per-layer multi_compile_local _ _FAKEGLINT, skeleton:282/3848)
            // -> material shader_feature (STYLE_BIBLE §3). Default OFF: base path (the must-be-1:1 surface) is unaffected.
            #pragma shader_feature_local _ _FAKEGLINT

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float2 uv         : TEXCOORD0;
                float2 lightmapUV : TEXCOORD1;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float3 positionWS : TEXCOORD0;
                float3 normalWS   : TEXCOORD1;
                float4 tangentWS  : TEXCOORD2;  // .w = sign
                float2 uv         : TEXCOORD3;
                DECLARE_LIGHTMAP_OR_SH(lightmapUV, vertexSH, 4);
                float  fogFactor  : TEXCOORD5;
            };

            // Vertex: HG procedurally synthesizes the patch grid + heightmap-displaces (b5:146-218); for the URP
            // port the terrain is a real Unity terrain/mesh, so positions/normals come from the mesh via URP. (CORE_MATH §3.3)
            Varyings vert(Attributes input)
            {
                Varyings o = (Varyings)0;
                VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);
                VertexNormalInputs   nrmIn = GetVertexNormalInputs(input.normalOS, input.tangentOS);

                o.positionCS = posIn.positionCS;
                o.positionWS = posIn.positionWS;
                o.normalWS   = nrmIn.normalWS;
                o.tangentWS  = float4(nrmIn.tangentWS, input.tangentOS.w * GetOddNegativeScale());
                o.uv         = TRANSFORM_TEX(input.uv, _BaseColorMap);
                OUTPUT_LIGHTMAP_UV(input.lightmapUV, unity_LightmapST, o.lightmapUV);
                OUTPUT_SH(o.normalWS, o.vertexSH);
                o.fogFactor  = ComputeFogFactor(o.positionCS.z);
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                float2 uv = input.uv;

                // ---- atlas samples (HG VT atlas -> standard maps; non-VT splat else-branch b468:355-361 / b6:706-714) ----
                float4 nmTex   = SAMPLE_TEXTURE2D(_NormalMaskMap, sampler_NormalMaskMap, uv); // T0: .xy=N .z=metal .w=smooth
                float3 baseRGB = SAMPLE_TEXTURE2D(_BaseColorMap,  sampler_BaseColorMap,  uv).rgb; // T1: albedo
                float  heightAO = SAMPLE_TEXTURE2D(_HeightMap,    sampler_HeightMap,     uv).w;    // T2: .w baked AO

                // ---- baked AO from the height map (b6:714 _1631 / b468:361 _763): clamp(heightMap.w - 0.5, 0, 1) ----
                float bakedAO = saturate(heightAO - 0.5);
                // aoFactor = min(bakedAO * 2.17391, 1)  (b6:727 _1659 / b468:373 _784)
                float aoFactor = min(bakedAO * AO_GAIN, 1.0);

                // ---- albedo with AO darkening (b6:728-730 / b468:374-376): c -> mad(aoFactor*c, -0.35, c) ----
                float3 albedo;
                albedo.x = mad(aoFactor * baseRGB.x, AO_ALBEDO_DARK, baseRGB.x);
                albedo.y = mad(aoFactor * baseRGB.y, AO_ALBEDO_DARK, baseRGB.y);
                albedo.z = mad(aoFactor * baseRGB.z, AO_ALBEDO_DARK, baseRGB.z);
                albedo *= _BaseColor.rgb; // authoring tint (no-op=white)

                // ---- metallic = T0.z with AO darkening (b6:762 _1644 / b468:384 _778): m -> mad(aoFactor*m, -0.10, m) ----
                float metalSrc = nmTex.z;
                float metallic = mad(aoFactor * metalSrc, AO_METAL_DARK, metalSrc);
                metallic = saturate(metallic + _Metallic); // authoring add (no-op=0)

                // ---- smoothness = T0.w with AO darkening (b6:777 _1635 / b468:399 _776): s -> mad(aoFactor, -s, s) = s*(1-aoFactor) ----
                // NOTE: in the always-on b6 path the wet ripple ALSO boosts smoothness by +0.1*ripStrength (b6:777 outer mad);
                // the final saturate*_SmoothnessScale is deferred until AFTER the ripple block so that boost is included.
                float smoothSrc  = nmTex.w;
                float smoothness = mad(aoFactor, -smoothSrc, smoothSrc);

                // ---- tangent-space normal from atlas T0.xy (b6:707-708,720 / b468:356-357,363) ----
                float3 nTS = UnpackTerrainNormal(nmTex.xy, _NormalScale);

                // TBN -> world (URP). tangentWS.w carries handedness sign. This is the terrain world normal.
                float sgn = input.tangentWS.w;
                float3 bitangentWS = sgn * cross(input.normalWS, input.tangentWS.xyz);
                float3 normalWS = normalize(nTS.x * input.tangentWS.xyz + nTS.y * bitangentWS + nTS.z * input.normalWS);

                // ---- water ripple normal perturbation (ALWAYS-ON, gated by uniform; b6:731-754,777) ----
                // Operates on the WORLD normal: wet flattens it toward geometric-up, then blends the ripple normal in
                // through the terrain world TBN. P0.y intensity defaults 0 -> discMask 0 -> ripStrength 0 -> identity.
                {
                    float3 P = input.positionWS;
                    float wetAmt  = max(aoFactor - WET_BROADEN_SUB, 0.0) * WET_BROADEN; // b6:731 _1674
                    float baseOff = -_WaterInteractionParams0.x;                        // b6:732 _1680
                    // ripple-plane coords: clamp((P - center)*uvScale*0.5, 0, 1) - 0.5   (b6:733-734 _1711/_1712)
                    float rdx = saturate((P.x - (baseOff + _WaterInteractionParams0.z)) * _WaterInteractionParams1.x * 0.5) - 0.5;
                    float rdz = saturate((P.z - (baseOff + _WaterInteractionParams0.w)) * _WaterInteractionParams1.x * 0.5) - 0.5;
                    // disc mask: intensity * (length(rd) <= 0.5 ? 1 : 0)                  (b6:735 _1727)
                    float discMask = saturate(_WaterInteractionParams0.y) * ((0.5 - length(float2(rdx, rdz))) >= 0.0 ? 1.0 : 0.0);
                    // ripple normal sample: UV = (P - center)*uvScale*-0.5                (b6:736 _1733)
                    float2 rippleUV = float2((P.x - (baseOff + _WaterInteractionParams0.z)) * _WaterInteractionParams1.x * -0.5,
                                             (P.z - (baseOff + _WaterInteractionParams0.w)) * _WaterInteractionParams1.x * -0.5);
                    float4 ripTex = SAMPLE_TEXTURE2D(_RippleNormalMap, sampler_RippleNormalMap, rippleUV);
                    float3 ripN = float3(mad(ripTex.x, 2.0, -1.0), mad(ripTex.y, 2.0, -1.0), mad(ripTex.z, 2.0, -1.0)); // b6:742-744
                    // ripple blend weight = ripTex.w * discMask * (wetAmt * strength)     (b6:751 _1804)
                    float ripStrength = ripTex.w * (discMask * (wetAmt * _WaterInteractionParams1.y));
                    // 1:1 b6:777 — the SAME ripStrength raises smoothness by +0.1 (wet reads shinier). The base path
                    // had only s*(1-aoFactor); the outer mad(ripStrength,0.1,smoothBase) of SV_Target_3.z was previously dropped.
                    smoothness += WET_SMOOTH_BOOST * ripStrength;
                    // wet flattens the world normal toward geometric-up by 0.98*aoFactor  (b6:738-741 _1749/_1750/_1751)
                    float wetFlat = aoFactor * WET_NORMAL_FLAT;
                    float3 flatN = normalize(lerp(normalWS, input.normalWS, wetFlat));
                    // transform the ripple normal into world via the terrain world TBN, blend by ripStrength (b6:752-754)
                    float3 ripWorld = ripN.x * input.tangentWS.xyz + ripN.y * bitangentWS + ripN.z * input.normalWS;
                    normalWS = normalize(lerp(flatN, ripWorld, ripStrength));
                }

                // ===== _FAKEGLINT (b484:419-440) — view-dependent sparkle over a world-XZ-tiled glint field =====
                // The blob gates this on a per-LAYER glint-type mask (_910 = 1-min(|2*layerType-1|,1), b484:420); that
                // per-layer classification is BAKED AWAY in this atlas-altitude port, so the shader_feature toggle IS the gate
                // (keyword on => layer is glint-type => gate=1) per STYLE_BIBLE §3 (multi_compile_local layer kw -> shader_feature).
                // The glint normal is sampled from a world-XZ-tiled field and dotted with the world view dir (b484:430), i.e.
                // a world-space view-dependent sparkle — faithful to the world-tiled intent (no tangent-frame dependence).
                #ifdef _FAKEGLINT
                {
                    float3 Vg = GetWorldSpaceNormalizeViewDir(input.positionWS);                // b484:425-427 _957/958/959 (camPos-posWS, norm)
                    float3 qV = floor(Vg * 50.0) * 0.0020000000949949026;                       // b484:430 floor(V*50)*0.002 view quantize
                    float4 gT = SAMPLE_TEXTURE2D_LOD(_GlintMap, sampler_GlintMap, input.positionWS.xz * _GlintScale, 0.0); // b484:428 SampleLevel 0
                    float3 gN = float3(mad(gT.x, 2.0, -1.0), gT.y, mad(gT.z, 2.0, -1.0));        // b484:430 decode (NOTE .y RAW, .x/.z *2-1)
                    float gDot = mad(dot(gN, qV), 0.5, 0.5);                                     // b484:430 _1013
                    float gC = saturate((frac(gDot + gDot) - _GlintThreshold) * (1.0 / (1.0 - _GlintThreshold))); // b484:431 _1028
                    float gS = (gC * gC) * mad(gC, -2.0, 3.0);                                   // b484:432 smoothstep _1033
                    float g4 = (gS * gS) * (gS * gS);                                            // b484:433-435 (_1034=gS^2; _1034*_1034 = gS^4)
                    float topness = lerp(nTS.z, 1.0, aoFactor * WET_NORMAL_FLAT);                // b484:417 _900 = lerp(nTS.z,1,wetFlat)
                    float topBlend = saturate((1.0 / max(0.00048828125, _GlintTopBlendSmoothness)) * (topness - _GlintTopBlendThreshold)); // b484:435
                    float gDist = 1.0 / input.positionCS.w;                                      // b484:434 1/gl_FragCoord.w = perspective eye depth (w_clip)
                    float gFadeR = saturate((1.0 / (-_GlintFadeDistance)) * (gDist - _GlintFadeDistance)); // b484:434 _1070
                    float gFade = (gFadeR * gFadeR) * mad(gFadeR, -2.0, 3.0);                    // b484:435 smoothstep fade
                    float glintMask = (g4 * (topBlend * _GlintStrength)) * gFade;               // b484:435 _1074 (per-layer gate _910 folded to 1)
                    albedo += _GlintColor.rgb * _GlintColor.w * glintMask;                       // b484:437-439 albedo += glintColor.w * glintColor.rgb * mask
                    smoothness = mad(glintMask, -smoothness, smoothness);                        // b484:436 smoothness *= (1 - mask)
                }
                #endif

                // finalize smoothness AFTER the ripple (+ glint) boosts (b6:777 wrote SV_Target_3.z raw; _SmoothnessScale is authoring no-op=1).
                smoothness = saturate(smoothness * _SmoothnessScale);

                // ============================ URP PBR lighting (CORE_MATH §2) ============================
                InputData inputData = (InputData)0;
                inputData.positionWS = input.positionWS;
                inputData.normalWS = normalWS;
                float3 viewDirWS = GetWorldSpaceNormalizeViewDir(input.positionWS); // b6:343-391 (persp/ortho view dir)
                inputData.viewDirectionWS = viewDirWS;
                inputData.shadowCoord = TransformWorldToShadowCoord(input.positionWS);
                inputData.fogCoord = input.fogFactor;
                inputData.bakedGI = SAMPLE_GI(input.lightmapUV, input.vertexSH, normalWS); // IV-GI -> SampleSH/lightmap (CORE_MATH §2.4)
                inputData.normalizedScreenSpaceUV = GetNormalizedScreenSpaceUV(input.positionCS);
                inputData.shadowMask = unity_ProbesOcclusion;

                SurfaceData surfaceData = (SurfaceData)0;
                surfaceData.albedo = saturate(albedo);
                surfaceData.metallic = metallic;
                // 1:1 — the GBuffer base writes the reflectance/specular MRT channel as a hard zero:
                //   SV_Target_2.x = 0.0  (b468:409 / b6:787). The terrain material carries NO _Specular uniform
                //   and NO 0.08*reflectance F0 anywhere in these blobs (the earlier "0.08*_Specular / _504" note
                //   was a misattribution: _504 = min(_499,_116) is a VT clipmap LOD coord b468:322, and the only
                //   0.08 literal — b6:544 _1524=clamp((abs(_626)-0.08)*25,0,1) — is a VT parallax smoothstep edge
                //   mask, removed infra). So reflectance = 0 is the faithful base value.
                surfaceData.specular = 0.0;
                surfaceData.smoothness = smoothness;
                surfaceData.occlusion = 1.0; // GBuffer base writes NO separate occlusion; AO already darkened into albedo/metal/smooth
                surfaceData.alpha = 1.0;
                surfaceData.normalTS = nTS;

                half4 color = UniversalFragmentPBR(inputData, surfaceData);
                color.rgb = MixFog(color.rgb, inputData.fogCoord); // froxel/atmosphere fog -> MixFog (CORE_MATH §2.10)
                return half4(color.rgb, 1.0);
                // ENGINE-SIDE (not closeable in this material): the dielectric-F0/reflectance->lighting conversion
                //   is NOT in this shader. This is the HG deferred GBUFFER WRITER (LIGHTMODE=GBuffer/FallbackGBuffer);
                //   it emits albedo/metal/smooth/normal into MRT0..4 with the spec channel = 0. The F0 split and the
                //   BRDF that consumes these MRTs live in the downstream HG deferred GBuffer-RESOLVE lighting pass
                //   (a separate full-screen pass / compute that reads the 5-MRT GBuffer), which is NOT present in
                //   these blobs (see header lines 31-32). URP substitutes that resolve with UniversalFragmentPBR
                //   in-fragment (kDielectricSpec=0.04). To match HG's resolve EXACTLY a host URP deferred/resolve
                //   feature would have to reproduce HG's F0 model — that host system is out of this material's scope.
            }
            ENDHLSL
        }

        // =====================================================================================
        // ShadowCaster — HG "TerrainShadowCaster" (b332: SV_Target = gl_FragCoord.z depth resolve). URP ApplyShadowBias.
        // =====================================================================================
        Pass {
            Name "ShadowCaster"
            Tags { "LightMode" = "ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull Off   // HG TerrainShadowCaster: Cull Off (skeleton:2230)

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex shadowVert
            #pragma fragment shadowFrag
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW

            float3 _LightDirection;
            float3 _LightPosition;

            struct AttributesS { float3 positionOS : POSITION; float3 normalOS : NORMAL; };
            struct VaryingsS  { float4 positionCS : SV_POSITION; };

            VaryingsS shadowVert(AttributesS input)
            {
                VaryingsS o;
                float3 positionWS = TransformObjectToWorld(input.positionOS);
                float3 normalWS   = TransformObjectToWorldNormal(input.normalOS);
            #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                float3 lightDirectionWS = normalize(_LightPosition - positionWS);
            #else
                float3 lightDirectionWS = _LightDirection;
            #endif
                float4 positionCS = TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDirectionWS));
            #if UNITY_REVERSED_Z
                positionCS.z = min(positionCS.z, UNITY_NEAR_CLIP_VALUE);
            #else
                positionCS.z = max(positionCS.z, UNITY_NEAR_CLIP_VALUE);
            #endif
                o.positionCS = positionCS;
                return o;
            }

            half4 shadowFrag(VaryingsS input) : SV_Target { return 0; } // b332: depth-only (depth via ColorMask 0)
            ENDHLSL
        }

        // =====================================================================================
        // DepthOnly — HG "TerrainDepthOnly" (b40: SV_Target = gl_FragCoord.z). URP writes depth via ColorMask 0.
        // =====================================================================================
        Pass {
            Name "DepthOnly"
            Tags { "LightMode" = "DepthOnly" }
            ZWrite On
            ColorMask 0
            Cull [_Cull]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex depthVert
            #pragma fragment depthFrag

            struct AttributesD { float3 positionOS : POSITION; };
            struct VaryingsD  { float4 positionCS : SV_POSITION; };

            VaryingsD depthVert(AttributesD input)
            {
                VaryingsD o;
                o.positionCS = TransformObjectToHClip(input.positionOS);
                return o;
            }

            half4 depthFrag(VaryingsD input) : SV_Target { return 0; } // b40: depth-only (depth via ColorMask 0)
            ENDHLSL
        }

        // =====================================================================================
        // DepthNormals — feeds URP SSAO/depth-normals prepass (substitutes HG GBuffer normal MRT3.xy).
        // HG octahedral-encodes the world normal into MRT3.xy (b6:1900-1910); URP stores a raw world normal.
        // =====================================================================================
        Pass {
            Name "DepthNormals"
            Tags { "LightMode" = "DepthNormals" }
            ZWrite On
            Cull [_Cull]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex dnVert
            #pragma fragment dnFrag

            struct AttributesN {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float2 uv         : TEXCOORD0;
            };
            struct VaryingsN {
                float4 positionCS : SV_POSITION;
                float3 normalWS   : TEXCOORD0;
                float4 tangentWS  : TEXCOORD1;
                float2 uv         : TEXCOORD2;
            };

            VaryingsN dnVert(AttributesN input)
            {
                VaryingsN o = (VaryingsN)0;
                VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);
                VertexNormalInputs   nrmIn = GetVertexNormalInputs(input.normalOS, input.tangentOS);
                o.positionCS = posIn.positionCS;
                o.normalWS   = nrmIn.normalWS;
                o.tangentWS  = float4(nrmIn.tangentWS, input.tangentOS.w * GetOddNegativeScale());
                o.uv         = TRANSFORM_TEX(input.uv, _BaseColorMap);
                return o;
            }

            half4 dnFrag(VaryingsN input) : SV_Target
            {
                // Reconstruct the same terrain world normal as ForwardLit (atlas T0.xy), output raw for URP SSAO.
                float4 nmTex = SAMPLE_TEXTURE2D(_NormalMaskMap, sampler_NormalMaskMap, input.uv);
                float3 nTS = UnpackTerrainNormal(nmTex.xy, _NormalScale);
                float sgn = input.tangentWS.w;
                float3 bitangentWS = sgn * cross(input.normalWS, input.tangentWS.xyz);
                float3 normalWS = normalize(nTS.x * input.tangentWS.xyz + nTS.y * bitangentWS + nTS.z * input.normalWS);
                return half4(normalWS, 0.0); // b6:1900-1910 (HG octahedral-encodes; URP normals tex stores raw normal)
            }
            ENDHLSL
        }
    }

    FallBack "Hidden/Universal Render Pipeline/FallbackError"
}
