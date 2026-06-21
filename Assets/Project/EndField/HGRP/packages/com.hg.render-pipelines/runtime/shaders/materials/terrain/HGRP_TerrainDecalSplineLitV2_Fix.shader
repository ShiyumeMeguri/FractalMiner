// HGRP Terrain Spline Decal V2 — single mesh-decal pass, 3-MRT deferred G-buffer write (NO lighting).
// Merged from: inlined Blob 1 (vertex) + Blob 2 (fragment), base variant (catch-all #else, HG_ENABLE_MV OFF).
//   Source: ReferenceProjects/RuriBeyondShader/.../materials/terrain/terraindecalsplinelitv2.shader (HGRP fork of HDRP).
//   (Unlike terraindecallit.shader, the V2 blobs are inlined directly in the .shader; there is no per-variant
//    .hlsl subfolder. The ONLY keyword is HG_ENABLE_MV (motion vectors) — its base/off branch is what is inlined.)
// Keywords: <none kept> (HG_ENABLE_MV removed — URP has a dedicated MotionVectors pass).
// Kept (1:1 math): mesh-decal world TBN passthrough, _BaseColorMap_ST UV on uv0, mip-biased albedo sample,
//   _BaseTexChannel (0 = Diffuse+Opacity, 1 = Normal+Roughness+Opacity) channel routing, dead-zone tangent-normal
//   decode (|x|<0.012 -> 0), normal-scale tangent-space blend onto the interpolated geometric world TBN with
//   handedness sign, OCTAHEDRAL-encode of the blended world normal into MRT1.xy, roughness remap [min,max],
//   height-map blend (_UseHeightMap gate, *.5 center, [min,max] remap), AO from _OcclusionChannel + strength.
//   Writes 3 splat targets exactly as source: MRT0 albedo+opacity, MRT1 octa-normal.xy + roughness + opacity,
//   MRT2 height + AO + 0 + opacity.
// Removed (pixel-neutral infra substituted by URP): SPIRV-Cross plumbing (gl_Position/SPIRV_Cross_*/static I/O),
//   spvBitfield* polyfills, the inlined octahedral NORMAL/TANGENT vertex-decode + manual object->world->clip
//   via the aliased _NormalScale[6] ObjectToWorld array + _NonJitteredViewNoTransProjMatrix (-> URP
//   GetVertexPositionInputs / GetVertexNormalInputs, unity_ObjectToWorld), TAA jitter (_TaaJitterStrength),
//   the HG_ENABLE_MV previous-frame clip output (TEXCOORD_6, _PrevNonJitteredViewNoTransProjMatrix /
//   _PrevCamPosRWS), camera-relative-world rebias (+_WorldSpaceCameraPos_Internal), denormalized-float magics
//   (decoded to asfloat(<uint>)/value).
//
// NOTE: This is a DEFERRED MESH DECAL, not a lit PBR surface. It does NO lighting — it rasterizes the decal
//   mesh (Cull Off, ZWrite Off, ZClip On) with a Stencil Ref-128 / Comp-Equal gate and SrcAlpha blends its
//   surface params into a 3-target terrain G-buffer, to be lit later by the terrain pass. There is no
//   GetMainLight / BRDF / SH here by design (so _core/CoreMath is intentionally NOT included).
// NOTE: The source vertex packs uv0->slot TEXCOORD2 and uv1->slot TEXCOORD0; the FRAGMENT samples the
//   decal from slot TEXCOORD2 = uv0 (via _BaseColorMap_ST). uv1 is interpolated but unused. (The
//   decompiler's fragment static names "TEXCOORD_1"/"TEXCOORD_2" are SPIRV-Cross renames bound by
//   ": TEXCOORDn" semantic, NOT by uv index — uv0 is the decal UV here, see frag decalUV note.)
//   The geometric world normal/tangent are carried as TEXCOORD_3 (N) and TEXCOORD_4 (T.xyz + handedness .w).
// Texture channel legend: _BaseColorMap RGBA = Albedo.rgb + Opacity.a (when _BaseTexChannel==0)
//   OR NormalX, NormalY, Roughness, Opacity (when _BaseTexChannel==1). _BaseHeightMap R = height (0..1).

Shader "HGRP/TerrainDecalSplineLitV2_Fix" {
    Properties {
        _MainProperties ("Main Properties", Float) = 0
        _BaseColor ("Base Color", Color) = (1, 1, 1, 1)
        [Enum(Diffuse Opacity, 0, Normal Roughness Opacity, 1)] _BaseTexChannel ("Base Texture Usage", Float) = 0
        _BaseColorMap ("Base Map", 2D) = "white" {}
        [Toggle] _BlendAlbedo ("Blend Albedo", Float) = 1
        [Toggle(_COMPLETE_PBR)] _UseSampleTex1 ("Use NRO Map (Complete PBR)", Float) = 0
        _SampleTex1 ("NRO Map", 2D) = "bump" {}

        [Header(Normal Roughness)]
        [Toggle] _AffectNormal ("Use Map Normal", Float) = 0
        _NormalScale ("Normal Scale", Range(0, 5)) = 1
        [Toggle] _AffectMRO ("Use Map Roughness", Float) = 1
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1

        [Header(Metallic AO)]
        [Enum(Close, 0, Texture2 R, 1, Texture2 G, 2, Texture2 B, 3, Texture2 A, 4)] _OcclusionChannel ("AO Channel", Float) = 0
        _OcclusionStrength ("AO Strength", Range(0, 2)) = 1
        [Enum(Close, 0, Slider, 1, Texture2 R, 2, Texture2 G, 3, Texture2 B, 4, Texture2 A, 5)] _MetallicChannel ("Metallic Channel", Float) = 0
        _Metallic ("Metallic", Range(0, 1)) = 0

        [Header(Height)]
        [Toggle] _UseHeight ("Height Blend", Float) = 0
        [Toggle] _UseHeightMap ("Use Map Height", Float) = 0
        _BaseHeightMap ("Height Map", 2D) = "grey" {}
        _BaseHeightMin ("Height Min", Range(0, 1)) = 0
        _BaseHeightMax ("Height Max", Range(0, 1)) = 1

        [Header(Advanced)]
        [HideInInspector] _EnableInstancing ("Enable GPU Instancing", Float) = 0
        [ToggleUI] _ReceiveDecals ("Receive Decals", Float) = 1
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0

        // Stencil / per-target ColorMask plumbing (source Properties lines 30-39). Driven by a material editor.
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 128
        [HideInInspector] _ColorMask0 ("ColorMask0", Float) = 15
        [HideInInspector] _ColorMask1 ("ColorMask1", Float) = 15
        [HideInInspector] _ColorMask2 ("ColorMask2", Float) = 15
        [HideInInspector] _SurfaceType ("Surface Type", Float) = 1

        // HGRP global mip bias (source cbuffer type_ShaderVariablesGlobal _GlobalMipBias c108).
        // No URP equivalent global; exposed so the SAMPLE_*_BIAS math is 1:1.
        [HideInInspector] _GlobalMipBias ("Global Mip Bias", Float) = 0
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
            // Source cbuffer type_UnityPerMaterial (fragment), terraindecalsplinelitv2.shader lines 369-382.
            float  _NormalScale;
            float  _RoughnessMin;
            float  _RoughnessMax;
            float  _BaseTexChannel;
            float  _OcclusionChannel;
            float  _OcclusionStrength;
            float  _Metallic;            // declared by source Properties (MetallicChannel); base frag does not read it.
            float4 _BaseColorMap_ST;     // packoffset c4 (source line 377) — tiling/offset for the decal UV.
            float  _UseHeightMap;        // packoffset c11 (source line 378) — 0/1 height-map gate.
            float  _BaseHeightMin;       // packoffset c11.y (source line 379)
            float  _BaseHeightMax;       // packoffset c11.z (source line 380)
            float4 _BaseColor;           // packoffset c12 (source line 381)

            // HGRP global mip bias (source cbuffer type_ShaderVariablesGlobal _GlobalMipBias, c108 line 366).
            float  _GlobalMipBias;
        CBUFFER_END

        // Textures re-identified from blob sample sites (the sampler wrap mode is the load-bearing 1:1 part):
        //   _BaseColorMap  = decal albedo / NRO map (source T0, sampler_LinearClamp, mip-biased; line 384,386,425).
        //   _BaseHeightMap = decal height map       (source T1, sampler_LinearRepeat, mip-biased; line 385,387,458).
        TEXTURE2D(_BaseColorMap);  SAMPLER(sampler_LinearClamp);
        TEXTURE2D(_BaseHeightMap); SAMPLER(sampler_LinearRepeat);

        // Magic-constant decodes (source uses denormalized-float / asfloat(uint) literals):
        //   asfloat(1065353216u)=1.0, asfloat(3212836864u)=-1.0, asfloat(1056964608u)=0.5, asfloat(0u)=0.0.
        static const float ONE_BITS      = 1.0;
        static const float NEG_ONE       = -1.0;
        static const float HALF_BITS     = 0.5;
        static const float NRM_DEADZONE  = 0.01200000010430812835693359375;      // |n| dead-zone (source line 437-438)
        static const float FLT_MIN_GUARD = 1.1754943508222875079687365372222e-38; // rsqrt guard = FLT_MIN (source line 445)

        // Dead-zone a decoded-normal channel: |x| < 0.012 -> 0, else x. (source lines 437-438)
        float NormalDeadZone(float x)
        {
            return (abs(x) < NRM_DEADZONE) ? 0.0 : x;
        }

        struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS   : NORMAL;
            float4 tangentOS  : TANGENT;
            float2 uv0        : TEXCOORD0;
            float2 uv1        : TEXCOORD1;
        };

        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float3 positionWS : TEXCOORD0; // source TEXCOORD_2 (world position, camera-relative rebiased back to absolute)
            float2 uv0        : TEXCOORD1; // source TEXCOORD_1_1 (uv0 passthrough — V2 samples the decal UV from THIS, frag lines 423-424)
            float2 uv1        : TEXCOORD2; // source TEXCOORD_2_1 (uv1 passthrough — interpolated but unused by the frag)
            float3 normalWS   : TEXCOORD3; // source TEXCOORD_3 (normalized geometric world normal)
            float4 tangentWS  : TEXCOORD4; // source TEXCOORD_4 (normalized world tangent .xyz + handedness sign .w)
        };

        // ----------------------------------------------------------------------------------------------
        // Vertex (source Blob 1, terraindecalsplinelitv2.shader lines 198-327).
        // The inlined source does: (1) an octahedral NORMAL/TANGENT unpack (the asuint(NORMAL.x)&0x40000000
        //   packed path, lines 200-269) — HG MESH-IMPORT infra, DROPPED (URP feeds standard meshes); (2) a
        //   manual object->world via the _NormalScale[6] array (an ALIAS of unity_ObjectToWorld rows, lines
        //   273-293) and inverse-transpose normal/tangent basis (lines 285-309); (3) world->clip via
        //   _NonJitteredViewNoTransProjMatrix with TAA jitter + camera-relative-world rebias (lines 294-326).
        // Per PORT DISCIPLINE all of that is INFRASTRUCTURE -> URP GetVertexPositionInputs /
        // GetVertexNormalInputs (object->world->clip + inverse-transpose normal + forward tangent), and
        // unity_ObjectToWorld. TAA jitter + the HG_ENABLE_MV previous-clip output are removed (URP MotionVectors).
        // The 1:1-preserved outputs: normalized world N (source lines 302-305), normalized world T (306-309),
        // tangent handedness = sign(scale.w) * TANGENT.w (source line 310), uv0/uv1 passthrough (319-322).
        // ----------------------------------------------------------------------------------------------
        Varyings vert(Attributes input)
        {
            Varyings output = (Varyings)0;

            VertexPositionInputs positionInputs = GetVertexPositionInputs(input.positionOS);
            VertexNormalInputs    normalInputs   = GetVertexNormalInputs(input.normalOS, input.tangentOS);

            output.positionCS = positionInputs.positionCS;
            output.positionWS = positionInputs.positionWS;

            // Normalized geometric world normal (source lines 302-305: rsqrt(max(dot,FLT_MIN)) * N).
            output.normalWS = normalInputs.normalWS;

            // Normalized world tangent (source lines 306-309) + handedness sign.
            // Source line 310: w = sign(_NormalScale[5].w >= 0) * TANGENT.w  ==  GetOddNegativeScale() * tangentOS.w.
            output.tangentWS = float4(normalInputs.tangentWS, input.tangentOS.w * GetOddNegativeScale());

            // uv0 / uv1 raw passthrough (source lines 319-322).
            output.uv0 = input.uv0;
            output.uv1 = input.uv1;

            return output;
        }

        ENDHLSL

        Pass {
            Name "UnityTerrainSplineDecal"
            // Source render-state (terraindecalsplinelitv2.shader lines 48-67):
            //   per-target SrcAlpha/OneMinusSrcAlpha blend, ColorMask [_ColorMaskN] N, ZClip On, ZWrite Off,
            //   Cull Off, Stencil Ref 128 ReadMask 128 Comp Equal Pass Replace Fail/ZFail Keep.
            Blend 0 SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
            ColorMask [_ColorMask0] 0
            Blend 1 SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
            ColorMask [_ColorMask1] 1
            Blend 2 SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
            ColorMask [_ColorMask2] 2
            ZClip On
            ZWrite Off
            Cull Off
            Stencil {
                Ref [_StencilRef]
                ReadMask 128
                Comp Equal
                Pass Replace
                Fail Keep
                ZFail Keep
            }

            Tags { "LightMode" = "SRPDefaultUnlit" }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            // 3 MRT splat targets (source SV_Target/_1/_2). Authored as an explicit struct so the MRT
            // layout is 1:1 with the source deferred G-buffer write (source lines 413-418, 430-460).
            struct DecalGBuffer
            {
                float4 albedoOpacity : SV_Target0; // RGB albedo (or white when NRO), A opacity
                float4 normalRough   : SV_Target1; // XY octahedral world normal, Z roughness, W opacity
                float4 heightAO      : SV_Target2; // X height, Y AO, Z 0, W opacity
            };

            DecalGBuffer frag(Varyings input)
            {
                // _BaseTexChannel != 0  -> base map holds Normal/Roughness/Opacity (source line 422 _56).
                bool useNRO = (0.0 != _BaseTexChannel);

                // === Decal UV = uv0 * _BaseColorMap_ST.xy + .zw (source lines 423-424 _73,_74) ===
                // NOTE: source frag reads its static "TEXCOORD_1" (semantic TEXCOORD2). Tracing the
                // SPIRV-Cross semantic chain: vert writes TEXCOORD_1_1 (= mesh uv0, vert lines 319-320)
                // to slot TEXCOORD2 (vert out line 132); frag binds TEXCOORD_1 : TEXCOORD2 (frag in
                // line 404) -> the decal UV is mesh UV0, NOT uv1. (uv1 lands in frag static TEXCOORD_2
                // : TEXCOORD0 and is unused.) Do not be fooled by the decompiler's "_1"/"_2" renaming.
                float2 decalUV = float2(mad(input.uv0.x, _BaseColorMap_ST.x, _BaseColorMap_ST.z),
                                        mad(input.uv0.y, _BaseColorMap_ST.y, _BaseColorMap_ST.w));

                // === Sample decal albedo / NRO (T0, sampler_LinearClamp, mip-biased) (source line 425 _81) ===
                float4 baseSample = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_LinearClamp, decalUV, _GlobalMipBias);
                float baseR = baseSample.x; // _83
                float baseG = baseSample.y; // _84
                float baseB = baseSample.z; // _85

                // === Opacity (source line 429 _126): baseSample.a * _BaseColor.a ===
                float opacity = baseSample.w * _BaseColor.w;

                // === MRT0: albedo (white when NRO) * _BaseColor.rgb (source lines 430-433) ===
                DecalGBuffer o;
                o.albedoOpacity.x = (useNRO ? ONE_BITS : baseR) * _BaseColor.x;
                o.albedoOpacity.y = (useNRO ? ONE_BITS : baseG) * _BaseColor.y;
                o.albedoOpacity.z = (useNRO ? ONE_BITS : baseB) * _BaseColor.z;
                o.albedoOpacity.w = opacity;

                // === Tangent-space normal X/Y (source lines 435-440) ===
                // useNRO ? baseSample.xy : 0.5(asfloat(1056964608u)), each decoded *2-1, then dead-zoned, then *scale.
                float nx = mad(useNRO ? baseR : HALF_BITS, 2.0, -1.0); // _185
                float ny = mad(useNRO ? baseG : HALF_BITS, 2.0, -1.0); // _188
                nx = NormalDeadZone(nx); // _197
                ny = NormalDeadZone(ny); // _199
                float sx = nx * _NormalScale; // _203
                float sy = ny * _NormalScale; // _204
                // tangent-space Z (source line 441 _212): sqrt(max(1 - dot(nxy,nxy), 0)).
                float nz = sqrt(max((NEG_ONE * dot(float2(nx, ny), float2(nx, ny))) + 1.0, 0.0));

                // === Tangent-space normal -> world via interpolated geometric TBN (source lines 434,442-448) ===
                // handedness = (tangentWS.w > 0) ? 1 : -1 (source line 434 _147). Bitangent = handed * cross(N, T).
                // World normal (source lines 442-444): nz*N + sx*T + sy*(handed * cross(N,T)), spelled component-wise
                // as the decompiler's mad-cross form, then normalized (source line 445 _239).
                float handed = (0.0 < input.tangentWS.w) ? ONE_BITS : NEG_ONE;
                float3 N = input.normalWS;
                float4 T = input.tangentWS;
                float wnX = mad(nz, N.x, mad(sx, T.x, (handed * mad(N.y, T.z, NEG_ONE * (N.z * T.y))) * sy)); // _231
                float wnY = mad(nz, N.y, mad(sx, T.y, (handed * mad(N.z, T.x, NEG_ONE * (N.x * T.z))) * sy)); // _232
                float wnZ = mad(nz, N.z, mad(sx, T.z, (handed * mad(N.x, T.y, NEG_ONE * (N.y * T.x))) * sy)); // _233
                float invLenN = rsqrt(max(dot(float3(wnX, wnY, wnZ), float3(wnX, wnY, wnZ)), FLT_MIN_GUARD));   // _239
                float wn_x = invLenN * wnX; // _240
                float wn_y = invLenN * wnY; // _241
                float wn_z = invLenN * wnZ; // _242

                // === Octahedral-encode the world normal into MRT1.xy (source lines 449-454) ===
                // L1 = dot(1, |n|) ; oct = (n.x, n.z) / L1 ; if (n.y <= 0) wrap = sign(oct)*(1-|oct.yx|) ; *0.5+0.5.
                float L1 = dot(float3(1.0, 1.0, 1.0), float3(abs(wn_x), abs(wn_y), abs(wn_z)));  // _246
                float octX = wn_x / L1;  // _249
                float octY = wn_z / L1;  // _250
                bool  lowerHemi = (0.0 >= wn_y);  // _251
                float encX = lowerHemi ? (((octX >= 0.0) ? ONE_BITS : NEG_ONE) * (((NEG_ONE * abs(octY)) + 1.0))) : octX; // _SV1.x arg
                float encY = lowerHemi ? (((octY >= 0.0) ? ONE_BITS : NEG_ONE) * (((NEG_ONE * abs(octX)) + 1.0))) : octY; // _SV1.y arg
                o.normalRough.x = mad(encX, 0.5, 0.5); // source line 453
                o.normalRough.y = mad(encY, 0.5, 0.5); // source line 454

                // === MRT1.z roughness (source line 455) ===
                // useNRO ? baseSample.b : 1.0(asfloat(1065353216u)) , remapped into [_RoughnessMin,_RoughnessMax].
                float roughSrc = useNRO ? baseB : ONE_BITS;
                o.normalRough.z = mad(roughSrc, (NEG_ONE * _RoughnessMin) + _RoughnessMax, _RoughnessMin);
                o.normalRough.w = opacity; // source line 456

                // === MRT2 (source lines 457-460) ===
                o.heightAO.w = opacity; // source line 457
                // X height (source line 458): mad(mad(_UseHeightMap, heightSample.r - 0.5, 0.5), Hmax-Hmin, Hmin).
                // Height map = T1, sampler_LinearRepeat, mip-biased, SAME decalUV.
                float heightR = SAMPLE_TEXTURE2D_BIAS(_BaseHeightMap, sampler_LinearRepeat, decalUV, _GlobalMipBias).x;
                float heightMix = mad(_UseHeightMap, heightR + (-0.5), 0.5);
                o.heightAO.x = mad(heightMix, (NEG_ONE * _BaseHeightMin) + _BaseHeightMax, _BaseHeightMin);
                // Y AO (source line 459): (1 - clamp(_OcclusionChannel,0,1)) strength-mixed toward 1.
                o.heightAO.y = mad((NEG_ONE * clamp(_OcclusionChannel, 0.0, 1.0)) + 1.0, _OcclusionStrength,
                                   1.0 + (NEG_ONE * _OcclusionStrength));
                o.heightAO.z = 0.0; // source line 460

                return o;
            }
            ENDHLSL
        }
    }
}
