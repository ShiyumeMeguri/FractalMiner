// HGRP Terrain Virtual-Texture Decal — single VT-atlas splat pass (3-MRT G-buffer write).
// Merged from: blob 3/4 (base, no keywords), blob 5/6 (_COMPLETE_PBR), blob 7/8 (_COMPLETE_PBR + _UV_ARC).
//   Source: ReferenceProjects/RuriBeyondShader/.../materials/terrain/terraindecallit.shader (HGRP fork of HDRP).
// Keywords: _COMPLETE_PBR (separate NRO map + multi-channel AO), _UV_ARC (barrel/arc UV distortion).
// Kept (1:1 math): VT page-space terrain-position reconstruction from SV_Position + per-page params,
//   15-bit terrain heightmap decode, world->decal-object-space projection, sector-shape clip
//   (box / cylinder / sphere via packedMisc&255), decal albedo+NRO sampling with mip bias,
//   tangent-space detail-normal blend onto the terrain normal (with handedness sign), dead-zone
//   normal decode, roughness remap (min/max), AO channel select + strength, packed vertex-color
//   (RGB+intensity+opacity) modulation. Writes 3 splat targets exactly as source (albedo/opacity,
//   octa-less XY normal + roughness, height + AO + opacity).
// Removed (pixel-neutral infra substituted by URP): SPIRV-Cross plumbing (gl_FragCoord/SPIRV_Cross_*),
//   spvBitfield* polyfills (-> HLSL >>/& and asuint), discard_state bookkeeping (-> clip()),
//   GPU-instancing draw array indexed by SV_InstanceID (-> URP unity_ObjectToWorld/unity_WorldToObject,
//   single-instance), denormalized-float magic literals (decoded to asfloat(<uint>)/value).
//
// NOTE: This is a VIRTUAL-TEXTURE TERRAIN DECAL, not a lit PBR surface. It does NO lighting — it
//   rasterizes the decal volume in front-face / ZTest-Always mode and writes into the terrain's
//   page-atlas MRT G-buffer, to be lit later by the terrain pass. There is no GetMainLight / BRDF /
//   SH here by design (so _core/CoreMath is intentionally NOT included).
// NOTE: The page/atlas globals (_PageViewProjMatrix, _TerrainPosParam, _NodePosParam, _AtlasUVScale,
//   _AtlasUVPadding, _SplatParam, _UVParam0/1) and the per-instance decal transform
//   (objectToWorld/worldToObject/uvTilingOffset/packedColor/packedColorIntensity/sectorAngle/packedMisc)
//   are HGRP virtual-texture-terrain feed; URP has NO equivalent subsystem. They are preserved as
//   documented uniforms so the math is 1:1, and the per-instance transform is mapped to URP's
//   unity_ObjectToWorld / unity_WorldToObject (single instance). See gaps/TODO(1:1).
//   _GlobalMipBias (blob's type_ShaderVariablesGlobal c108) is NOT a preserved uniform: URP already
//   provides it (float2 _GlobalMipBias, Input.hlsl:112) and SAMPLE_TEXTURE2D_BIAS auto-applies its .x,
//   so the blob's SampleBias(..,_GlobalMipBias) maps onto URP's facility (sample sites pass bias 0.0).
// Texture channel legend: _BaseColorMap RGBA = Albedo.rgb + Opacity.a (when _BaseTexChannel==0)
//   OR NormalX,NormalY,Roughness,Opacity (when _BaseTexChannel==1). _SampleTex1 = NRO (Normal/Roughness/Occlusion).

Shader "HGRP/TerrainDecalLit_Fix" {
    Properties {
        _MainProperties ("Main Properties", Float) = 0
        [Enum(Diffuse Opacity, 0, Normal Roughness Opacity, 1)] _BaseTexChannel ("Base Texture Usage", Float) = 0
        _BaseColorMap ("Base Map", 2D) = "white" {}
        _DecalOpacity ("Decal Opacity", Range(0, 1)) = 1
        [Toggle] _BlendAlbedo ("Blend Albedo", Float) = 1
        [Toggle(_COMPLETE_PBR)] _UseSampleTex1 ("Use NRO Map (Complete PBR)", Float) = 0
        _SampleTex1 ("NRO Map", 2D) = "white" {}

        [Header(Normal Blend)]
        [Toggle] _AffectNormal ("Use Map Normal", Float) = 0
        _NormalScale ("Normal Scale", Range(0.01, 1)) = 1
        [Toggle] _AffectMRO ("Use Map Roughness", Float) = 1
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1

        [Header(Occlusion)]
        [Enum(Close, 0, Texture2 R, 1, Texture2 G, 2, Texture2 B, 3, Texture2 A, 4)] _OcclusionChannel ("AO Channel", Float) = 0
        _OcclusionStrength ("AO Strength", Range(0, 2)) = 1

        [Header(Height)]
        [Toggle] _UseHeight ("Height Blend", Float) = 0
        [Toggle] _UseHeightMap ("Use Map Height", Float) = 0
        _BaseHeightMap ("Height Map", 2D) = "grey" {}
        _BaseHeightMin ("Height Min", Range(0, 1)) = 0
        _BaseHeightMax ("Height Max", Range(0, 1)) = 1

        [Header(UV Distortion)]
        [Toggle(_UV_NOISE)] _UVNoiseSection ("UV Noise (unused in base/PBR/arc variants)", Float) = 0
        _UVNoiseMap ("Noise Map", 2D) = "gray" {}
        _UVNoiseStrength ("Noise Strength", Range(-1, 1)) = 0
        _UVNoiseTiling ("Noise Tiling", Float) = 1
        [Toggle(_UV_ARC)] _UVArcSection ("UV Arc Warp", Float) = 0
        _UVArcStrengthX ("Arc Strength X", Range(-1, 1)) = 0
        _UVArcStrengthY ("Arc Strength Y", Range(-1, 1)) = 0
        _UVArcOffsetX ("UV Offset X", Range(-1, 1)) = 0
        _UVArcOffsetY ("UV Offset Y", Range(-1, 1)) = 0

        // --- Terrain VT page/atlas + per-instance feed (HGRP VT terrain; no URP equivalent) ---
        // TODO(1:1): These are normally bound per-page/per-instance by the HGRP VT-terrain renderer.
        //   URP has no such subsystem; exposed here so the math compiles & is 1:1.
        // NOTE: _GlobalMipBias is NOT redeclared here — URP provides it as a global `float2 _GlobalMipBias`
        //   (Input.hlsl:112, consumed by SAMPLE_TEXTURE2D_BIAS via Core.hlsl:203). Redeclaring it (esp. as
        //   `float`) is a guaranteed redefinition/type clash; the blob's SampleBias(..,_GlobalMipBias) maps to
        //   URP's macro auto-adding _GlobalMipBias.x, so the sample sites pass explicit bias 0.0 (see frag).
        [HideInInspector] _UVParam0 ("UV Param 0", Vector) = (1, 0, 0, 0)
        [HideInInspector] _UVParam1 ("UV Param 1", Vector) = (1, 0, 0, 0)
        [HideInInspector] _NodePosParam ("Node Pos Param", Vector) = (0, 0, 1, 0)
        [HideInInspector] _AtlasUVScale ("Atlas UV Scale", Vector) = (1, 1, 1, 1)
        [HideInInspector] _AtlasUVPadding ("Atlas UV Padding", Vector) = (0, 0, 0, 0)
        [HideInInspector] _TerrainPosParam ("Terrain Pos Param", Vector) = (1, 0, 1, 1)
        [HideInInspector] _SplatParam ("Splat Param", Vector) = (1, 1, 1, 1)
        // Per-instance decal transform/color (source: ECSPerDrawArray). Single-instance mapping.
        [HideInInspector] _UVTilingOffset ("Decal UV Tiling/Offset", Vector) = (1, 1, 0, 0)
        [HideInInspector] _PackedColor ("Packed Color (uint as float bits)", Float) = 0
        [HideInInspector] _PackedColorIntensity ("Packed Color Intensity", Float) = 1
        [HideInInspector] _SectorAngle ("Sector Angle", Float) = 0
        [HideInInspector] _PackedMisc ("Packed Misc (uint as float bits)", Float) = 0

        [HideInInspector] _DrawOrder ("DrawOrder", Float) = 0
        [HideInInspector] _Specular ("Specular", Range(0, 1)) = 0.5
        [HideInInspector] _AngleBlendFallOff ("Angle Blend FallOff", Range(0.1, 5)) = 1
    }

    SubShader {
        Tags {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Opaque"
        }
        LOD 300

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

        CBUFFER_START(UnityPerMaterial)
            // PBR / normal-blend scalars (source cbuffer type_UnityPerMaterial, blob 4 lines 44-60).
            float _NormalScale;
            float _RoughnessMin;
            float _RoughnessMax;
            float _BaseTexChannel;
            float _OcclusionChannel;
            float _OcclusionStrength;
            float _DecalOpacity;
            float _UVArcSection;
            float _UVArcStrengthX;
            float _UVArcStrengthY;
            float _UVArcOffsetX;
            float _UVArcOffsetY;
            float _BaseHeightMin;
            float _BaseHeightMax;

            // Terrain VT page/atlas globals (source cbuffer type_PerPageData, blob 4 lines 26-36).
            // NOTE: _GlobalMipBias (blob 4:21-24, type_ShaderVariablesGlobal c108) is intentionally NOT in this
            //   CBUFFER — URP already declares the global `float2 _GlobalMipBias` (Input.hlsl:112). Adding it
            //   here would be a redefinition + float-vs-float2 type clash (guaranteed under UNITY_VIRTUAL_TEXTURING).
            float4 _UVParam0;
            float4 _UVParam1;
            float4x4 _PageViewProjMatrix; // page view-proj (blob 3:25 / blob 4:30); used in vert + page-UV recon.
            float4 _NodePosParam;
            float4 _AtlasUVScale;
            float4 _AtlasUVPadding;
            float4 _TerrainPosParam;
            float4 _SplatParam;

            // Per-instance decal feed (source ECSPerDrawArray, blob 4 lines 10-19). Single-instance.
            float4 _UVTilingOffset;
            float  _PackedColor;
            float  _PackedColorIntensity;
            float  _SectorAngle;
            float  _PackedMisc;
        CBUFFER_END

        // Textures re-identified from blob sample sites (samplers are the load-bearing 1:1 part):
        //   _BaseColorMap  = decal albedo/NRO  (blob 4:62 T0, sampler_LinearMirror, mip-biased)
        //   _SampleTex1    = decal NRO map     (blob 6:63 T1, sampler_LinearMirrorOnce, _COMPLETE_PBR only)
        //   _BaseHeightMap = terrain VT heightmap page (blob 4:63 T1 / blob 6:64 T2, sampler_LinearClamp, LOD0)
        //   _TerrainNormalAtlas = terrain VT detail-normal atlas page (blob 4:64 T2 / blob 6:65 T3, sampler_LinearRepeat, LOD0)
        // TODO(1:1): _BaseHeightMap & _TerrainNormalAtlas are VT-system page atlases bound by the HGRP
        //   terrain renderer, NOT material slots; URP has no VT terrain, so they are plain material samplers here.
        TEXTURE2D(_BaseColorMap);       SAMPLER(sampler_LinearMirror);
        TEXTURE2D(_SampleTex1);         SAMPLER(sampler_LinearMirrorOnce);
        TEXTURE2D(_BaseHeightMap);      SAMPLER(sampler_LinearClamp);
        TEXTURE2D(_TerrainNormalAtlas); SAMPLER(sampler_LinearRepeat);

        // asfloat(1065353216u)=1.0, asfloat(3212836864u)=-1.0, asfloat(1056964608u)=0.5 (blob 4:175,204,195).
        static const float ONE_BITS   = 1.0;
        static const float NEG_ONE    = -1.0;
        static const float HALF_BITS  = 0.5;
        static const float INV_255    = 0.0039215688593685626983642578125; // 1/255 (blob 4:194)
        static const float NRM_DEADZONE = 0.01200000010430812835693359375;  // (blob 4:197)
        static const float FLT_MIN_GUARD = 1.1754943508222875079687365372222e-38; // rsqrt guard (blob 4:210)

        // Dead-zone a decoded-normal channel: |x| < 0.012 -> 0, else x. (blob 4:197-198 / b6:205-206)
        float NormalDeadZone(float x)
        {
            return (abs(x) < NRM_DEADZONE) ? 0.0 : x;
        }

        struct Attributes
        {
            float3 positionOS : POSITION;
        };

        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float3 decalAxisU  : TEXCOORD0; // source TEXCOORD  (normalized objectToWorld col0 -> here col "Y")
            float4 terrainTBN  : TEXCOORD1; // source TEXCOORD_1: xyz = normalized objectToWorld col0, w = handedness(-1)
        };

        // ----------------------------------------------------------------------------
        // Vertex (blob 3, lines 63-84; blob 7 is byte-identical — _UV_ARC does not touch vertex).
        // Rasterize the decal volume through the page view-proj. Pass the decal's world-space
        // axis basis (normalized objectToWorld columns) to the fragment for the TBN blend.
        // ----------------------------------------------------------------------------
        Varyings vert(Attributes input)
        {
            Varyings output = (Varyings)0;

            // posWS = objectToWorld * positionOS (blob 3:67-69).
            float3 posWS = mul(unity_ObjectToWorld, float4(input.positionOS, 1.0)).xyz;

            // clip = _PageViewProjMatrix * posWS (blob 3:70-73).
            output.positionCS = mul(_PageViewProjMatrix, float4(posWS, 1.0));

            // Normalize objectToWorld column 1 -> decalAxisU (source TEXCOORD). (blob 3:74-77)
            float3 col1 = float3(unity_ObjectToWorld._m01, unity_ObjectToWorld._m11, unity_ObjectToWorld._m21);
            float invLen1 = rsqrt(max(dot(col1, col1), FLT_MIN_GUARD));
            output.decalAxisU = invLen1 * col1;

            // Normalize objectToWorld column 0 -> terrainTBN.xyz (source TEXCOORD_1). (blob 3:78-82)
            float3 col0 = float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20);
            float invLen0 = rsqrt(max(dot(col0, col0), FLT_MIN_GUARD));
            output.terrainTBN.xyz = invLen0 * col0;
            output.terrainTBN.w   = NEG_ONE; // handedness flag (blob 3:82)

            return output;
        }

        ENDHLSL

        Pass {
            Name "TerrainVTDecal"
            // Source: 3-MRT terrain atlas splat. Blend per-target SrcAlpha/OneMinusSrcAlpha,
            // ZTest Always, ZWrite Off, Cull Front, ColorMask per-target (driven by _ColorMaskTerrainN).
            // (terraindecallit.shader lines 50-63)
            Blend SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
            ZTest Always
            ZWrite Off
            Cull Front

            Tags { "LightMode" = "SRPDefaultUnlit" }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _COMPLETE_PBR
            #pragma shader_feature_local _UV_ARC

            // 3 MRT splat targets (source SV_Target/_1/_2). Authored as an explicit struct so the
            // MRT layout is 1:1 with the source G-buffer write.
            struct DecalGBuffer
            {
                float4 albedoOpacity : SV_Target0; // RGB albedo (or white), A opacity
                float4 normalRough   : SV_Target1; // XY packed normal, Z roughness, W opacity
                float4 heightAO      : SV_Target2; // X height, Y AO, Z 0, W opacity
            };

            DecalGBuffer frag(Varyings input)
            {
                // === Page UV from screen position (blob 4:169-172 / b6:171-174) ===
                // gl_FragCoord.xy == input.positionCS.xy (pixel coords). _TerrainPosParam.w = page pixel size.
                float pageX = input.positionCS.x / _TerrainPosParam.w;
                float pageY = input.positionCS.y / _TerrainPosParam.w;
                float uvX = clamp(mad(pageX, _UVParam0.x, _UVParam0.y), 0.0, 1.0);
                float uvY = clamp(mad(pageY, _UVParam0.x, _UVParam0.z), 0.0, 1.0);
                float uvOffX = _UVParam0.w;
                float uvOffY = _UVParam1.w;
                float splatScaleY = _SplatParam.w;

                // === Sample terrain heightmap, decode 15-bit height (blob 4:177-181 / b6:179-183) ===
                // PBR variant samples this on T2 (sampler_LinearClamp); base samples on T1. Same map slot.
                float2 heightUV = float2(mad(uvX, _TerrainPosParam.x, uvOffX) * ONE_BITS,
                                         mad(uvY, _TerrainPosParam.x, uvOffY) * splatScaleY);
                float4 heightSample = SAMPLE_TEXTURE2D_LOD(_BaseHeightMap, sampler_LinearClamp, heightUV, 0.0);
                // 15-bit height = (G*65280 + R*255) & 32767, then * posParam.z + posParam.y.
                uint heightBits = uint((heightSample.y * 65280.0) + (heightSample.x * 255.0)) & 32767u;
                float terrainHeight = mad(float(heightBits), _TerrainPosParam.z, _TerrainPosParam.y);

                // === Terrain world XZ from node-pos params (blob 4:178-179 / b6:180-181) ===
                float terrainWX = mad(pageX, _NodePosParam.z, _NodePosParam.x);
                float terrainWZ = mad(pageY, _NodePosParam.z, _NodePosParam.y);

                // === World -> decal object space via worldToObject (blob 4:182-184 / b6:184-186) ===
                // localPos = worldToObject * (terrainWX, terrainHeight, terrainWZ, 1). The blob spells this
                // column-major as col0.*WX + col1.*WY + col2.*WZ + col3 == standard mul(M, v).
                float3 terrainWS = float3(terrainWX, terrainHeight, terrainWZ);
                float3 localPos = mul(unity_WorldToObject, float4(terrainWS, 1.0)).xyz;
                float localX = localPos.x;
                float localY = localPos.y;
                float localZ = localPos.z;

                // === Sector-shape clip (blob 4:185-188 / b6:187-190) ===
                // mode = packedMisc & 255: 1 = cylinder (XZ disc radius .5 AND |Y|<.5 slab),
                //                          3 = sphere (radius .5), 0 = box (|x,y,z|<.5), else pass.
                uint sectorMode = 255u & asuint(_PackedMisc);
                bool yLo = (NEG_ONE * 0.5) < localY; // (-0.5) < localY
                bool yHi = localY < 0.5;
                bool inside;
                if (sectorMode == 1u)
                {
                    bool disc = sqrt(dot(float2(localX, localZ), float2(localX, localZ))) < 0.5;
                    inside = yLo && yHi && disc;
                }
                else if (sectorMode == 3u)
                {
                    inside = sqrt(dot(float3(localX, localY, localZ), float3(localX, localY, localZ))) < 0.5;
                }
                else if (sectorMode != 0u)
                {
                    inside = true;
                }
                else
                {
                    bool xLo = (NEG_ONE * 0.5) < localX;
                    bool zLo = (NEG_ONE * 0.5) < localZ;
                    bool xHi = localX < 0.5;
                    bool zHi = localZ < 0.5;
                    inside = zLo && yLo && xLo && zHi && yHi && xHi;
                }
                // discard when NOT inside (source: discard_cond((mask ^ 0xffffffff) != 0)).
                clip(inside ? 1.0 : -1.0);

                // === Decal UV (with optional arc warp) ===
                float decalU;
                float decalV;
                #ifdef _UV_ARC
                    // Arc/barrel distortion (blob 8:191-196).
                    // centered = local + 0.5; nrm = centered*2-1; warp = (1 - nrm*nrm)*strength + offset.
                    float centeredX = localX + 0.5;
                    float centeredZ = localZ + 0.5;
                    float nrmZ = mad(centeredZ, 2.0, -1.0);
                    float nrmX = mad(centeredX, 2.0, -1.0);
                    // U (blob 8:195): arc uses Y-strength/offset on the Z-derived nrm, added to col.x tiling on centeredX.
                    decalU = mad(mad(mad(NEG_ONE * nrmZ, nrmZ, 1.0), _UVArcStrengthY, _UVArcOffsetY), _UVArcSection,
                                 mad(centeredX, _UVTilingOffset.x, _UVTilingOffset.z));
                    // V (blob 8:196): arc uses X-strength/offset on the X-derived nrm, added to col.y tiling on centeredZ.
                    decalV = mad(mad(mad(NEG_ONE * nrmX, nrmX, 1.0), _UVArcStrengthX, _UVArcOffsetX), _UVArcSection,
                                 mad(centeredZ, _UVTilingOffset.y, _UVTilingOffset.w));
                #else
                    // No arc (blob 4:189 / b6:191-192): UV = (local + 0.5) * tiling + offset.
                    decalU = mad(localX + 0.5, _UVTilingOffset.x, _UVTilingOffset.z);
                    decalV = mad(localZ + 0.5, _UVTilingOffset.y, _UVTilingOffset.w);
                #endif
                float2 decalUV = float2(decalU, decalV);

                // === Sample decal albedo (T0, sampler_LinearMirror, mip-biased) (blob 4:189 / b6:193) ===
                // Blob: T0.SampleBias(samp, uv, _GlobalMipBias). URP's SAMPLE_TEXTURE2D_BIAS auto-adds the
                // global _GlobalMipBias.x to the explicit bias (Core.hlsl:203), so pass 0.0 here to land on
                // exactly _GlobalMipBias.x = the blob's global mip bias (no local redeclare; no double-add).
                float4 baseSample = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_LinearMirror, decalUV, 0.0);
                float baseR = baseSample.x;
                float baseG = baseSample.y;
                float baseB = baseSample.z;
                bool useNRO = (0.0 != _BaseTexChannel); // _BaseTexChannel != 0 -> base map holds Normal/Roughness/Opacity

                // === Normal X/Y + roughness source selection ===
                // Base variant (blob 4:195-196): when useNRO, take normal XY from baseSample; else default 0.5.
                // PBR variant (blob 6:198-204): a SECOND NRO map (_SampleTex1, sampler_LinearMirrorOnce) supplies
                //   the "else" branch (not a flat 0.5). When useNRO=true both pick baseSample, false picks nroSample.
                #ifdef _COMPLETE_PBR
                    // Blob 6: T1.SampleBias(samp, uv, _GlobalMipBias) -> URP macro adds _GlobalMipBias.x, pass 0.0.
                    float4 nroSample = SAMPLE_TEXTURE2D_BIAS(_SampleTex1, sampler_LinearMirrorOnce, decalUV, 0.0);
                    float nroR = nroSample.x;
                    float nroG = nroSample.y;
                    float nroB = nroSample.z;
                    // (blob 6:203-204) decoded normal X/Y = (sel*2 - 1).
                    float nx = mad(useNRO ? baseR : nroR, 2.0, -1.0);
                    float ny = mad(useNRO ? baseG : nroG, 2.0, -1.0);
                #else
                    // (blob 4:195-196) else-branch is the constant 0.5 (asfloat(1056964608u)).
                    float nx = mad(useNRO ? baseR : HALF_BITS, 2.0, -1.0);
                    float ny = mad(useNRO ? baseG : HALF_BITS, 2.0, -1.0);
                #endif
                nx = NormalDeadZone(nx); // |nx| < 0.012 -> 0 (blob 4:197 / b6:205)
                ny = NormalDeadZone(ny);
                float nz = sqrt(max((NEG_ONE * dot(float2(nx, ny), float2(nx, ny))) + 1.0, 0.0)); // (blob 4:199 / b6:207)

                // === Sample terrain detail-normal atlas (blob 4:200-203 / b6:208-211) ===
                // T2 in base (sampler_LinearRepeat) / T3 in PBR. Atlas UV from page UV + atlas scale/pad.
                float2 atlasUV = float2(ONE_BITS * (mad(uvX, _AtlasUVScale.x, uvOffX) + _AtlasUVPadding.x),
                                        splatScaleY * (mad(uvY, _AtlasUVScale.x, uvOffY) + _AtlasUVPadding.x));
                float4 detailNrm = SAMPLE_TEXTURE2D_LOD(_TerrainNormalAtlas, sampler_LinearRepeat, atlasUV, 0.0);
                float dnx = mad(detailNrm.x, 2.0, -1.0);          // (blob 4:201 / b6:209)
                float dny = mad(detailNrm.y, 2.0, -1.0);          // (blob 4:202 / b6:210)
                float dnz = sqrt(max((NEG_ONE * dot(float2(dnx, dny), float2(dnx, dny))) + 1.0, 0.0)); // (blob 4:203 / b6:211)

                // === Tangent-space blend of decal normal onto terrain normal (blob 4:204-210 / b6:212-218) ===
                // handedness = (TEXCOORD_1.w > 0) ? 1 : -1  (here terrainTBN.w == -1 from vertex -> -1). (blob 4:204)
                float handed = (0.0 < input.terrainTBN.w) ? ONE_BITS : NEG_ONE;
                float sx = nx * _NormalScale; // (blob 4:205 / b6:213)
                float sy = ny * _NormalScale; // (blob 4:206 / b6:214)
                float3 T = input.terrainTBN.xyz; // normalized decal axis (object col0) acting as terrain tangent frame
                // Reconstruct the blended world normal exactly as the decompiler (cross-style mix). (blob 4:207-209)
                float bnX = mad(nz, dnx, mad(sx, T.x, sy * (handed * mad(dnz, T.z, NEG_ONE * (dny * T.y)))));
                float bnY = mad(nz, dnz, mad(sx, T.y, sy * (handed * mad(dny, T.x, NEG_ONE * (dnx * T.z)))));
                float bnZ = mad(nz, dny, mad(sx, T.z, sy * (handed * mad(dnx, T.y, NEG_ONE * (dnz * T.x)))));
                float invLenN = rsqrt(max(dot(float3(bnX, bnY, bnZ), float3(bnX, bnY, bnZ)), FLT_MIN_GUARD)); // (blob 4:210)

                // === Opacity (blob 4:194 / b6:202): packedColor>>24 (alpha byte) * _DecalOpacity * baseSample.a / 255 ===
                uint packedColorBits = asuint(_PackedColor);
                float opacity = ((float(packedColorBits >> 24u) * _DecalOpacity) * baseSample.w) * INV_255;

                // === MRT0: albedo * vertexColor(RGB,intensity) (or white when NRO) (blob 4:216-218 / b6:224-226) ===
                // packedColor byte0/1/2 = vertex color R/G/B; * intensity. When useNRO, albedo forced to 1 (white).
                float vcR = float(255u & packedColorBits) * INV_255 * _PackedColorIntensity;
                float vcG = float((packedColorBits >> 8u) & 255u) * INV_255 * _PackedColorIntensity;
                float vcB = float((packedColorBits >> 16u) & 255u) * INV_255 * _PackedColorIntensity;

                // Albedo source is the T0 _BaseColorMap sample (baseR/G/B) in BOTH variants:
                // base uses _272/_273/_274 (blob 4:216-218), PBR uses _276/_277/_278 = _274 = T0
                // (blob 6:224-226). The _SampleTex1 NRO map feeds normal/roughness/AO, NOT albedo,
                // so there is NO _COMPLETE_PBR split here. useNRO ? white(1.0) : baseSample.rgb ; * vertexColor.
                DecalGBuffer o;
                o.albedoOpacity.x = (useNRO ? ONE_BITS : baseR) * vcR;
                o.albedoOpacity.y = (useNRO ? ONE_BITS : baseG) * vcG;
                o.albedoOpacity.z = (useNRO ? ONE_BITS : baseB) * vcB;
                o.albedoOpacity.w = opacity;

                // === MRT1: packed blended normal XZ (encode *.5+.5) + roughness (blob 4:211-213 / b6:219-221) ===
                o.normalRough.x = mad(invLenN * bnX, 0.5, 0.5);
                o.normalRough.y = mad(invLenN * bnZ, 0.5, 0.5);
                // roughness = remap source roughness (baseB or nroB) into [_RoughnessMin,_RoughnessMax]; useNRO ? sel : 1.
                #ifdef _COMPLETE_PBR
                    float roughSrc = useNRO ? baseB : nroB;
                #else
                    float roughSrc = useNRO ? baseB : ONE_BITS;
                #endif
                o.normalRough.z = mad(roughSrc, (NEG_ONE * _RoughnessMin) + _RoughnessMax, _RoughnessMin);
                o.normalRough.w = opacity;

                // === MRT2: height + AO (blob 4:219-220 / b6:227-229) ===
                // X = remap height center: (_BaseHeightMax - _BaseHeightMin)*0.5 + _BaseHeightMin.
                o.heightAO.x = mad((NEG_ONE * _BaseHeightMin) + _BaseHeightMax, 0.5, _BaseHeightMin);
                #ifdef _COMPLETE_PBR
                    // AO selected from NRO channels by _OcclusionChannel (1=R,2=G,3=B,4=A), nested lerps. (blob 6:228-229)
                    // _524 = lerp(nroR, nroG, clamp(_OcclusionChannel-1,0,1))
                    float aoSel = mad(clamp((-1.0) + _OcclusionChannel, 0.0, 1.0), (NEG_ONE * nroR) + nroG, nroR);
                    // inner = lerp(aoSel, lerp(nroB, nroSample.a, clamp(_OcclusionChannel-3,0,1)), clamp(_OcclusionChannel-2,0,1))
                    float aoBA = mad(clamp((-3.0) + _OcclusionChannel, 0.0, 1.0), (NEG_ONE * nroB) + nroSample.w, nroB);
                    float aoInner = mad(clamp((-2.0) + _OcclusionChannel, 0.0, 1.0), (NEG_ONE * aoSel) + aoBA, aoSel);
                    // ao = lerp(1, aoInner, clamp(_OcclusionChannel,0,1)) then strength-mix toward 1.
                    float aoMixed = mad(clamp(_OcclusionChannel, 0.0, 1.0), aoInner + (-1.0), 1.0);
                    o.heightAO.y = mad(aoMixed, _OcclusionStrength, 1.0 + (NEG_ONE * _OcclusionStrength));
                #else
                    // Base variant has no NRO map: AO = (1 - clamp(_OcclusionChannel,0,1)) strength-mixed. (blob 4:220)
                    o.heightAO.y = mad((NEG_ONE * clamp(_OcclusionChannel, 0.0, 1.0)) + 1.0, _OcclusionStrength,
                                       1.0 + (NEG_ONE * _OcclusionStrength));
                #endif
                o.heightAO.z = 0.0;
                o.heightAO.w = opacity;

                return o;
            }
            ENDHLSL
        }
    }
}
