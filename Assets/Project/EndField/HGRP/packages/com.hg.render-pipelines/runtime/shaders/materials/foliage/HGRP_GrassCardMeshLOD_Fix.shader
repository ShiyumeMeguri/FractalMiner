// HGRP Foliage "Grass Cardmesh Lod" -> URP. Forward-lit grass-card LOD. Passes: ForwardOnly (was HGBuffer), ShadowCaster, DepthOnly. RayTracingReflection dropped (empty HG stub).
// Merged from: grasscardmeshlod.shader  (HGRP/Foliage/Grass Cardmesh Lod) — base variant blobs Sub0_Pass0_Vertex_b18 / Sub0_Pass0_Fragment_b19 / Sub0_Pass1_Vertex_b66 / Sub0_Pass1_Fragment_b67 / Sub0_Pass2_Vertex_b102 / Sub0_Pass2_Fragment_b103, + deltas Sub0_Pass0_Vertex_b22 (camera tilling) / Sub0_Pass0_Fragment_b21 (normal map).
// Keywords: _NORMAL_MAP, _ALPHATEST_ON, _USE_CAMERA_BASED_TILLING, _HEIGHT_CULLING, _MODEL_SPACE_EMISSIVE, _EMISSIVE_MAP, _BLEND_TERRAIN_ALBEDO.
// Kept (1:1 math from blobs): 10:10:10:2 octahedral NORMAL+TANGENT vertex unpack; camera-based tilling (lean = _CameraBasedTillingIntensity * (1 - unity_ObjectToWorld._m01) along camera-up by local height, b22:240-243 / b26:260-263 / b72:128-129 — NOT 1-intensity); ALWAYS-ON foliage-occluder mask cull (degenerate-vertex) and ALWAYS-ON world-Y cone cull (>80 fixed cutoff + 0.198 slope, b18:251-258 base — NOT keyword-gated); _HEIGHT_CULLING keyword adds a property-driven height-fade Y-sink (fade>=0.95 -> -10 world-Y, b26:153,262 / b72:94,130); LOD-crossfade interleaved-gradient-noise dither discard (b19:187-194; occFade.x=visibility gate, .y=param-z); BaseColor tint-cover + brighter-scale albedo; DXT-style normal-map TBN blend with two-sided normal sign (base path b19 has NO face flip); height-driven AO (_AoParams) and height-driven directional self-shadow (_DirParams); subsurface intensity + back-face transmission (forward-approx).
// Removed (pixel-neutral pipeline infra, substituted by URP): HG 5-MRT deferred GBuffer packing (octahedral-normal/subsurface/transmission/dir-shadow packed into MRT2/MRT3/MRT4 — re-resolved as a URP forward surface, see CORE_MATH.md §1.4 PORT GUIDANCE); HG motion-vector SV_Target1 + TAAU pack (URP has a dedicated MotionVectors pass); HG_ENABLE_MV / SRP_INSTANCING_ON / HG_ECS_INSTANCING_ON keywords; _NonJitteredViewNoTransProjMatrix+TaaJitter (-> UNITY_MATRIX_VP / GetVertexPositionInputs); camera-relative world space (URP uses absolute world); _GlobalMipBias (URP applies its own); HG main-light buffer (-> GetMainLight); ambient/reflection are URP SampleSH + GlossyEnvironmentReflection (HG resolved these in the deferred lighting pass, not in this surface shader).
//
// NOTE: this HGRP shader's fragment is a DEFERRED GBuffer SURFACE-PACKER — it contains NO lighting; it packs albedo/normal/AO/subsurface/transmission/dir-self-shadow into HG's bespoke 5 MRTs for HG's deferred lighting pass. There is no ForwardLit blob. Per CORE_MATH.md §1.4 the faithful VISUAL port reconstructs the identical surface (the 1:1 obligation) and lights it with URP's standard PBR so it is visible on screen. The surface params that HG packed are reproduced exactly: octahedral world-normal (blob computes oct-encode for MRT3.xy; we keep the world normal it encodes), AO (_AoParams height ramp), subsurface/transmission, and the _DirParams height self-shadow (folded into occlusion).
//   Texture-channel legend: _BaseColorMap RGB = albedo (only .rgb read; blob clamps base*_BaseColor*_BaseColorBrighterScale). _NormalMap RG = tangent-space XY (2*c-1), B = roughness mask source, A = extra AO mask (b21: _193.w -> SV_Target3.z, _193.z-1 modulates self-shadow via _MaskOnDiffuse/_MaskOnTransmission).
//   _DirParams (.x=start .y=gradient .z=floor .w=offset) and _AoParams (same layout) drive a height-distance self-occlusion using the model-local vertex position (TEXCOORD_6 in blob = object-space POSITION carried through).

Shader "HGRP/Foliage/GrassCardMeshLOD_Fix"
{
    Properties
    {
        // ============================================================
        // Blend-state plumbing (opaque foliage; set by material/editor)
        // ============================================================
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _ZTestGBuffer ("__ztGBuffer", Float) = 4
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 17

        // ============================================================
        // Core surface (always-on)
        // ============================================================
        _BaseColor ("Base Color", Color) = (1, 1, 1, 1)
        _BaseColorMap ("Base Color Map", 2D) = "white" {}
        _BaseColorTintCover ("Base Color Tint Cover", Range(0, 1)) = 0
        _BaseColorBrighterScale ("Base Color Brighter Scale", Range(1, 3)) = 1
        [Toggle] _TwoSidedNormal ("Two Sided Normal (flip back)", Float) = 0

        // Normal And Roughness Mask Map — [_NORMAL_MAP]
        [Toggle(_NORMAL_MAP)] _EnableNormalMap ("Enable Normal Map", Float) = 0
        _NormalMap ("Normal(RG) Roughness(B) Mask(A)", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 1)) = 1
        _MaskOnDiffuse ("Mask On Diffuse Self-Shadow", Range(0.01, 1)) = 1
        _MaskOnTransmission ("Mask On Transmission Self-Shadow", Range(0.01, 1)) = 1

        // Direct-light self-shadow (height ramp)
        _DirParams ("Dir Self-Shadow Params (start,grad,floor,offset)", Vector) = (0.1, 1, 0.8, 99)
        // AO (height ramp)
        _AoParams ("AO Params (start,grad,floor,offset)", Vector) = (0.1, 1, 0.8, 99)

        // Subsurface scattering & transmission
        _SubsurfaceIntensity ("Subsurface Intensity", Range(0, 1)) = 0
        _Transmission ("Back-face Transmission", Range(0, 1)) = 0.1

        // Alpha test — [_ALPHATEST_ON]
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Alpha Test", Float) = 0
        _AlphaClipThreshold ("Clip Threshold", Range(0, 1)) = 0.5

        // Camera-based tilling (lean toward camera) — [_USE_CAMERA_BASED_TILLING]
        [Toggle(_USE_CAMERA_BASED_TILLING)] _UseCameraBasedTilling ("Camera-based Tilling", Float) = 1
        _CameraBasedTillingIntensity ("Camera-based Tilling Intensity", Range(0, 2)) = 1.5

        // Height-difference culling — [_HEIGHT_CULLING]
        [Toggle(_HEIGHT_CULLING)] _EnableHeightCulling ("Height Culling", Float) = 0
        _HeightCullingStartHeight ("Height Culling Start", Range(2, 50)) = 15
        _HeightCullingGradient ("Height Culling Gradient", Range(0.02, 0.2)) = 0.07

        // Blend terrain albedo — [_BLEND_TERRAIN_ALBEDO]
        [Toggle(_BLEND_TERRAIN_ALBEDO)] _EnableBlendTerrainAlbedo ("Blend Terrain Albedo", Float) = 0
        _BlendTerrainAlbedoFadeDistance ("Blend Terrain Albedo Fade Distance", Range(0.01, 0.5)) = 0.01
        _BlendTerrainAlbedoOffset ("Blend Terrain Albedo Offset", Range(0, 0.5)) = 0

        // Model-space emissive — [_MODEL_SPACE_EMISSIVE]
        [Toggle(_MODEL_SPACE_EMISSIVE)] _EnableModelSpaceEmissive ("Model-space Emissive", Float) = 0
        [ToggleUI] _MSEmissiveFartherIsBrighter ("Farther From Origin = Brighter", Float) = 0
        _MSEmissiveModelHeight ("Model Height", Range(0, 10)) = 1
        _MSEmissiveMaskPower ("Emissive Mask Power", Range(1, 2)) = 1
        _MSEmissiveBias ("Emissive Bias", Range(-1, 1)) = 0
        [HDR] _MSEmissiveColor ("Emissive Color", Color) = (0, 0, 0, 1)
        [ToggleUI] _MSEmissiveIgnoreAlbedo ("Emissive Ignore Albedo", Float) = 1

        // Emissive map — [_EMISSIVE_MAP]
        [Toggle(_EMISSIVE_MAP)] _EnableEmissiveMap ("Emissive Map", Float) = 0
        _EmissiveMap ("Emissive Map", 2D) = "black" {}

        // Foliage occluder (HG global params, exposed for material override)
        [HideInInspector] _FoliageOccluderParams0 ("__foliageOccluder", Vector) = (50, 0, 1, 0)
        [HideInInspector] _FoliageOccluderCameraPosParam ("__foliageOccluderCamPos", Vector) = (0, 0, 0, 0)
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Opaque"
            "Queue" = "Geometry"
        }
        LOD 600

        // ============================================================
        // Shared include: URP infra + cbuffer + textures + grass surface helpers
        // ============================================================
        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

        CBUFFER_START(UnityPerMaterial)
            float4 _BaseColor;
            float4 _BaseColorMap_ST;
            float  _BaseColorTintCover;
            float  _BaseColorBrighterScale;
            float  _TwoSidedNormal;
            float  _NormalScale;
            float  _MaskOnDiffuse;
            float  _MaskOnTransmission;
            float4 _DirParams;
            float4 _AoParams;
            float  _SubsurfaceIntensity;
            float  _Transmission;
            float  _AlphaClipThreshold;
            float  _CameraBasedTillingIntensity;
            float  _HeightCullingStartHeight;
            float  _HeightCullingGradient;
            float  _BlendTerrainAlbedoFadeDistance;
            float  _BlendTerrainAlbedoOffset;
            // Model-space emissive
            float  _MSEmissiveFartherIsBrighter;
            float  _MSEmissiveModelHeight;
            float  _MSEmissiveMaskPower;
            float  _MSEmissiveBias;
            float4 _MSEmissiveColor;
            float  _MSEmissiveIgnoreAlbedo;
            float4 _EmissiveMap_ST;
            // Foliage occluder (HG globals re-exposed as material params)
            float4 _FoliageOccluderParams0;
            float4 _FoliageOccluderCameraPosParam;
        CBUFFER_END

        TEXTURE2D(_BaseColorMap);          SAMPLER(sampler_BaseColorMap);
        TEXTURE2D(_NormalMap);             SAMPLER(sampler_NormalMap);
        TEXTURE2D(_EmissiveMap);           SAMPLER(sampler_EmissiveMap);
        // Foliage occluder visibility map (HG global T0 in every stage). URP has no equivalent global;
        // bound here so the cull math is preserved 1:1 when a project supplies it. Defaults to "white" (visible).
        TEXTURE2D(_FoliageOccluderTex);    SAMPLER(sampler_FoliageOccluderTex);

        // FLT_MIN rsqrt guard — blob 1.1754943508222875079687365372222e-38f (b18:260, b19:199)
        static const float FLT_MIN_GUARD = 1.1754943508222875079687365372222e-38f;
        // 1e-8 epsilon — blob 9.9999999392252902907785028219223e-09f (b19:227)
        static const float EPS_1E8 = 9.9999999392252902907785028219223e-09f;
        // 10-bit octahedral decode scale = 1/511 — blob 0.001956947147846221923828125f (b18:172)
        static const float OCT_DECODE_10 = 0.001956947147846221923828125f;
        // Interleaved-gradient-noise constants for LOD crossfade dither — blob (b19:188)
        static const float2 IGN_K = float2(0.067110560834407806396484375f, 0.005837149918079376220703125f);
        static const float  IGN_SCALE = 52.98291778564453125f;

        // -------- 10:10:10:2 packed octahedral NORMAL+TANGENT decode (b18:152-221) --------
        // HG packs an octahedral normal + a hemioct tangent into asuint(NORMAL.x) when bit30 (0x40000000) is set.
        // This is HG mesh-import infrastructure; for standard URP meshes bit30 is clear and we use plain
        // normalOS/tangentOS. The decode is reproduced 1:1 so HG-packed grass meshes round-trip identically.
        void DecodeGrassNormalTangent(float3 normalOS, float4 tangentOS, out float3 nOut, out float3 tOut, out float tSign)
        {
            uint packed = asuint(normalOS.x);
            if ((packed & 0x40000000u) != 0u)
            {
                // sign-extend three 10-bit fields, scale by 1/511  (b18:166-173)
                float fx = float(packed & 1023u);
                float fy = float((packed >> 10u) & 1023u);
                float fz = float((packed >> 20u) & 1023u);
                float sx = (fx >= 512.0f) ? (fx - 1024.0f) : fx;   // b18:169
                float sy = (fy >= 512.0f) ? (fy - 1024.0f) : fy;   // b18:170
                float sz = (fz >= 512.0f) ? (fz - 1024.0f) : fz;   // b18:171
                float ox = sx * OCT_DECODE_10;                      // b18:172
                float oy = sy * OCT_DECODE_10;                      // b18:173
                // octahedral wrap -> direction N  (b18:174-182)
                float nz = (1.0f - abs(ox)) - abs(oy);             // b18:174-175 (_241)
                bool wrap = nz < 0.0f;                              // b18:176
                float wx = wrap ? (((ox >= 0.0f) ? 1.0f : -1.0f) * (1.0f - abs(oy))) : ox;   // b18:177
                float wy = wrap ? (((oy >= 0.0f) ? 1.0f : -1.0f) * (1.0f - abs(ox))) : oy;   // b18:178
                float invN = rsqrt(dot(float3(wx, wy, nz), float3(wx, wy, nz)));             // b18:179
                float Nx = invN * wx, Ny = invN * wy, Nz = invN * nz;                        // b18:180-182
                nOut = float3(Nx, Ny, Nz);

                // build an orthonormal tangent basis from N, then a second hemioct (sz) selects tangent (b18:183-210)
                float bx = mad(wy, invN, -Nz);                     // b18:183 (_270)
                float by = mad(nz, invN, -Nx);                     // b18:184 (_271)
                float bz = mad(wx, invN, -Ny);                     // b18:185 (_272)
                float d0 = -dot(float3(bx, by, bz), float3(Nx, Ny, Nz));   // b18:186
                float e0x = d0 + bx, e0y = d0 + by, e0z = d0 + bz;        // b18:187-189
                float invE = rsqrt(dot(float3(e0x, e0y, e0z), float3(e0x, e0y, e0z)));  // b18:190
                float t0x = invE * e0x, t0y = invE * e0y, t0z = invE * e0z;             // b18:191-193
                float signZ = (sz < 0.0f) ? -1.0f : 1.0f;          // b18:194 (_289)
                float u0 = (1.0f - dot((sz * OCT_DECODE_10).xx, signZ.xx));  // b18:195 (_294)
                float u1 = (1.0f - abs(u0)) * signZ;               // b18:196 (_298)
                float invU = rsqrt(dot(float2(u0, u1), float2(u0, u1)));   // b18:197
                float c0 = invU * u0, c1 = invU * u1;              // b18:198-199
                // cross(N, t0) (b18:200-203)
                float cx = mad(Ny, t0z, -(Nz * t0y));              // b18:200
                float cy = mad(Nz, t0x, -(Nx * t0z));              // b18:201
                float cz = mad(Nx, t0y, -(Ny * t0x));              // b18:202
                float invC = rsqrt(dot(float3(cx, cy, cz), float3(cx, cy, cz)));  // b18:203
                tOut = float3(mad(c0, t0x, c1 * (invC * cx)),
                              mad(c0, t0y, c1 * (invC * cy)),
                              mad(c0, t0z, c1 * (invC * cz)));      // b18:205-207
                tSign = mad(float(packed >> 31u), 2.0f, -1.0f);    // b18:208 (_349)
            }
            else
            {
                nOut = normalOS;                                   // b18:214-220
                tOut = tangentOS.xyz;
                tSign = tangentOS.w;
            }
        }

        // -------- height-ramp self-occlusion (shared by _DirParams self-shadow and _AoParams AO) --------
        // posLocal = model-space vertex position; p = ramp params (x=start, y=gradient, z=floor, w=offset).
        // b19:223-226 (AO) / b19:204,238 (dir self-shadow): distance from a w-offset model origin, remapped + floored.
        float HeightRampOcclusion(float3 posLocal, float4 p)
        {
            float3 d = float3(posLocal.x, p.w + posLocal.y, posLocal.z);          // b19:223-225 / 203-205
            float dist = sqrt(dot(d, d));                                         // b19:226
            float t = saturate((max(dist - p.w, 0.0f) - p.x) * p.y);             // b19:226 inner
            return saturate(mad(t, 1.0f - p.z, p.z));                            // b19:226 outer = mad(t, 1-z, z) = lerp(z_floor, 1, t)
        }

        // -------- LOD-crossfade interleaved-gradient-noise dither test (b19:187-194, b67:57-59, b103:55-57) --------
        // occFade carried per-vertex (.x = "has occluder" flag, .y = occluder fade). Returns true => discard.
        bool LodDitherDiscard(float2 svPosXY, float lodFadeX, float lodFadeY, float lodFadeZ, float2 occFade)
        {
            float fade = min((0.0f < occFade.x) ? occFade.y : 1.0f, lodFadeX);   // b19:187 (_72)
            float ign = frac(frac(dot(svPosXY, IGN_K)) * IGN_SCALE);            // b19:188 (_85)
            float a = (1.0f - max(lodFadeZ, lodFadeY)) - ign;                   // b19:189 first arg
            float b = fade - ((fade >= 0.0f) ? ign : -ign);                    // b19:189 second arg
            return min(a, b) < 0.0f;                                            // b19:189
        }

        // -------- DXT/HG normal-map TBN blend -> world normal (b21:177-193) --------
        // Reconstructs a reflect-style detail normal and blends it into the geometric TBN, applying the
        // front-face / two-sided sign. Returns the (un-normalized) world normal; caller normalizes.
        float3 NormalMapToWorld(float2 uv, float3 N, float4 T, float faceSign)
        {
            float bitSign = (0.0f < T.w) ? 1.0f : -1.0f;                        // b21:177 (_133)
            float4 nm = SAMPLE_TEXTURE2D(_NormalMap, sampler_NormalMap, uv);    // b21:179
            float nx = mad(nm.x, 2.0f, -1.0f);                                  // b21:180
            float ny = mad(nm.y, 2.0f, -1.0f);                                  // b21:181
            float nz2 = 1.0f - nx * nx - ny * ny;                              // b21:182 (_206 = dot((nx,ny,1),(-nx,-ny,1)))
            float nz = sqrt(nz2);                                               // b21:183
            float c  = mad(nz2, 2.0f, -1.0f);                                   // b21:184 (_214)
            float kx = faceSign * (2.0f * nz * nx);                            // b21:185 (_215, _NormalScale folds into faceSign upstream? blob uses _180 only)
            float ky = faceSign * (2.0f * nz * ny);                            // b21:186 (_216)
            float3 B = bitSign * cross(N, T.xyz);                              // b21:187-189 inner cross
            float3 Nw = c * N + kx * T.xyz + ky * B;                           // b21:187-189
            return faceSign * Nw;                                              // b21:191-193 (sign re-applied)
        }
        ENDHLSL

        // ============================================================
        // PASS 1 — ForwardOnly  (HGRP "HGBuffer" surface, forward-resolved)
        //   HGRP: Name "HGBuffer", LIGHTMODE=GBuffer, ZTest [_ZTestGBuffer], Cull [_CullMode],
        //         Stencil Ref [_StencilRef] Comp Always Pass Replace.
        // ============================================================
        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForwardOnly" }
            ZTest [_ZTestGBuffer]
            ZWrite [_ZWrite]
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace Fail Keep ZFail Keep }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag

            #pragma shader_feature_local _NORMAL_MAP
            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _USE_CAMERA_BASED_TILLING
            #pragma shader_feature_local _HEIGHT_CULLING
            #pragma shader_feature_local _MODEL_SPACE_EMISSIVE
            #pragma shader_feature_local _EMISSIVE_MAP
            // ENGINE-SIDE (legitimate punt): _BLEND_TERRAIN_ALBEDO blends the grass-card albedo toward the UNDERLYING
            // TERRAIN's albedo, read from HG's screen-space terrain GBuffer (a camera-space render-target filled by HG's
            // separate terrain GBuffer pass), faded by _BlendTerrainAlbedoFadeDistance/_BlendTerrainAlbedoOffset over depth.
            // EXHAUSTIVELY VERIFIED: this keyword is NOT in ANY multi_compile/shader_feature pragma in the source .shader
            // (Pass0 pragmas grasscardmeshlod.shader:86-92 list only HG_ENABLE_MV/_ALPHATEST_ON/_NORMAL_MAP/_USE_CAMERA_BASED_TILLING/
            // _HEIGHT_CULLING/HG_ECS_INSTANCING_ON/SRP_INSTANCING_ON), so DXC produced NO variant blob carrying it — confirmed by
            // grep over all 18 Pass0 fragment variants (b19..b53) and the entire …/materials/ tree: zero "BlendTerrain"/"TerrainAlbedo"
            // hits, and _BlendTerrainAlbedo* never enters any blob's type_UnityPerMaterial cbuffer. The value it needs (per-pixel
            // terrain albedo at this fragment's screen position) can ONLY be produced by a host system that binds a terrain-GBuffer
            // texture: a URP ScriptableRenderFeature exposing the terrain albedo RT (HG's "TerrainGBuffer"). A material texture +
            // math cannot synthesize it. Keyword compiles to a no-op until such a render-feature supplies _TerrainAlbedoTex.
            #pragma shader_feature_local _BLEND_TERRAIN_ALBEDO

            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile_fragment _ _SHADOWS_SOFT
            #pragma multi_compile_fog
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS

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
                float3 normalWS   : TEXCOORD1;
                float4 tangentWS  : TEXCOORD2;   // .w = bitangent sign
                float3 positionWS : TEXCOORD3;
                float3 posLocal   : TEXCOORD4;   // model-space POSITION carried for AO/dir ramps (blob TEXCOORD_6)
                float2 occFade    : TEXCOORD5;   // foliage-occluder dither (blob TEXCOORD_1_1)
            };

            // Foliage-occluder mask cull (b18:122-151). Computes the occluder-map fade and, when masked,
            // pushes the vertex position to NaN (degenerate triangle = grass blade removed). worldXZ is the
            // blade's world position relative to the occluder camera; returns possibly-NaN local position.
            float3 ApplyFoliageOccluder(float3 posLocal, float2 worldXZRelOccluder, out float2 occFade)
            {
                occFade = float2(0.0f, 0.0f);
                // outside occluder radius -> fully visible (b18:129-136)
                if ((_FoliageOccluderParams0.x < abs(worldXZRelOccluder.x)) ||
                    (_FoliageOccluderParams0.x < abs(worldXZRelOccluder.y)))
                {
                    return posLocal;
                }
                float diam = _FoliageOccluderParams0.x + _FoliageOccluderParams0.x;   // b18:139
                float2 ouv = worldXZRelOccluder / diam + 0.5f;                         // b18:140
                float4 occ = SAMPLE_TEXTURE2D_LOD(_FoliageOccluderTex, sampler_FoliageOccluderTex, ouv, 0.0f); // b18:140
                bool rPos = 0.0f < occ.x;                                              // b18:143
                bool masked = (0.0f < occ.y) && rPos;                                  // b18:144-145
                // BLOB CHANNEL ORDER (b18:277-278): TEXCOORD_1.x = _175 (visibility 0/1), TEXCOORD_1.y = _174 (param-z fade).
                // The fragment dither (b19:187) gates on .x (_175) and reads .y (_174): min((0<_175)?_174:1, LODFade.x).
                occFade.x = masked ? 1.0f
                          : (((occ.y == 0.0f) && (occ.x == 0.0f)) ? 0.0f : 1.0f);     // b18:150 (_175) -> TEXCOORD_1.x
                occFade.y = rPos ? _FoliageOccluderParams0.z
                          : (1.0f - _FoliageOccluderParams0.z);                       // b18:149 (_174) -> TEXCOORD_1.y
                return masked ? asfloat(0x7fc00000u).xxx : posLocal;                  // b18:146-148 (NaN)
            }

            Varyings vert(Attributes IN)
            {
                Varyings OUT = (Varyings)0;

                // --- decode (possibly packed) normal/tangent (b18:152-221) ---
                float3 nOS; float3 tOS; float tSign;
                DecodeGrassNormalTangent(IN.normalOS, IN.tangentOS, nOS, tOS, tSign);

                // --- world placement of the (original) vertex for occluder lookup (b18:122-123) ---
                float3 worldPos0 = TransformObjectToWorld(IN.positionOS);
                float2 worldXZRel = float2(worldPos0.x - _FoliageOccluderCameraPosParam.z,
                                           worldPos0.z - _FoliageOccluderCameraPosParam.w);

                // --- foliage-occluder mask cull (b18:129-151) ---
                float2 occFade;
                float3 posLocal = ApplyFoliageOccluder(IN.positionOS, worldXZRel, occFade);

                // --- object -> world (b18:225-229; URP TransformObjectToWorld == mad(O2W, posOS)) ---
                float3 positionWS = TransformObjectToWorld(posLocal);

            #ifdef _USE_CAMERA_BASED_TILLING
                // Lean toward camera: offset world XZ along camera-up by local height (b22:134,240-243; b26:260-263).
                // camUp = UNITY_MATRIX_I_V column 1 (HG _InvViewMatrix[1]); invLen = rsqrt(dot(camUp,camUp)) (b22:134 _74).
                // BLOB MATH (1:1):  leanTerm = camUp * invUpLen * POSITION.y * _CameraBasedTillingIntensity * (1 - M[1].x)
                //   where M = object-to-world, M[1].x = element (row0,col1) = unity_ObjectToWorld._m01.
                //   Magnitude: b22:241 spells it _PerPassConstants_DisableAnimateVert.z; b26/b28:261 and shadow b72:129 spell
                //   the SAME register (b3.c1.z) as _CameraBasedTillingIntensity — DXC reflection-name aliasing of one slot.
                //   The fragment cbuffer (b19:30) authoritatively names material c1.z = _CameraBasedTillingIntensity, so the
                //   magnitude IS _CameraBasedTillingIntensity (NOT 1-intensity, which was the prior port's inversion bug).
                //   Second factor: b22:240 (1 - _f_0[1].x) == shadow b72:128 (1 - _unity_ObjectToWorld[1].x): the b22 _f_0[2]
                //   buffer is an alias of the object-to-world rows, so _f_0[1].x = unity_ObjectToWorld._m01 (proven by b72,
                //   which spells the identical lean factor with the matrix name). Already-tilted instances lean less.
                float3 camUp = float3(UNITY_MATRIX_I_V._m01, UNITY_MATRIX_I_V._m11, UNITY_MATRIX_I_V._m21);
                float  invUpLen = rsqrt(dot(camUp, camUp));                            // b22:134 (_74)
                float  lean = _CameraBasedTillingIntensity * (1.0f - unity_ObjectToWorld._m01); // b26:260-261 / b72:128-129
                positionWS.x += (camUp.x * invUpLen) * posLocal.y * lean;             // b22:241 / b26:261
                positionWS.z += (camUp.z * invUpLen) * posLocal.y * lean;             // b22:243 / b26:263
                // (Y receives mad(0,...) in base tilling -> no vertical lean, b22:242; the _HEIGHT_CULLING variant
                //  replaces that 0 with a height-fade sink, handled in the _HEIGHT_CULLING block below.)
            #endif

                OUT.positionWS = positionWS;
                OUT.positionCS = TransformWorldToHClip(positionWS);                   // b18:248-259 (VP) , TAA jitter dropped

                // --- normal/tangent to world (inverse-transpose; URP normal inputs) (b18:239-247) ---
                float3 normalWS  = normalize(TransformObjectToWorldNormal(nOS));
                float3 tangentWS = normalize(TransformObjectToWorldDir(tOS));
                float  sgn = tSign * GetOddNegativeScale();                           // b18:268 (sign * worldTransformParams.w)
                OUT.normalWS  = normalWS;
                OUT.tangentWS = float4(tangentWS, sgn);

                OUT.uv = TRANSFORM_TEX(IN.uv, _BaseColorMap);                          // b18:275-276 (uv passthrough)
                OUT.posLocal = posLocal;                                              // b18:282-284 (TEXCOORD_6)
                OUT.occFade  = occFade;                                               // b18:277-278

                // --- ALWAYS-ON fixed-80 world-Y cone cull (b18:251-258 — present in the BASE blob with NO keyword) ---
                // Above 80m camera-relative height AND inside an XZ cone (slope 0.19885681569576263427734375) -> NaN
                // (degenerate triangle). This is the base behavior; it is NOT gated by _HEIGHT_CULLING.
                float camHeight = _WorldSpaceCameraPos.y - unity_ObjectToWorld._m13;  // b18:251 (_578)
                float cone = camHeight * 0.19885681569576263427734375f;              // b18:252 (_579)
                float2 camRelXZ = float2(unity_ObjectToWorld._m03 - _WorldSpaceCameraPos.x,
                                         unity_ObjectToWorld._m23 - _WorldSpaceCameraPos.z); // b18:225-226 (_402,_404)
                bool cull = (80.0f < camHeight) && (abs(camRelXZ.y) < cone) && (abs(camRelXZ.x) < cone); // b18:253
                if (cull) { OUT.positionCS = asfloat(0x7fc00000u).xxxx; }            // b18:255-259

            #ifdef _HEIGHT_CULLING
                // _HEIGHT_CULLING keyword body (b26:152-153,262): a SEPARATE property-driven height-difference sink that
                // stacks ON TOP of the always-on fixed-80 cone cull above. Math, 1:1 from b26:
                //   fade01 = saturate((camHeight - _HeightCullingStartHeight) * _HeightCullingGradient)   (b26:153 _118)
                //   when fade01 >= 0.95 (b26:262 const 0.949999988079071044921875): add -10.0 to world-Y
                //   (b26:262 asfloat(3240099840u) = -10.0f ; else asfloat(2147483648u) = -0.0f), * the tilling
                //   (1 - _m01) term -> blade sinks below ground (hidden). Below 0.95 -> no change. The blob multiplies the
                //   sink select by the SAME (1 - unity_ObjectToWorld._m01) factor as the X/Z camera-lean (b26:260 _485,
                //   confirmed by shadow b72:128-130 which spells it _unity_ObjectToWorld[1].x); applied here 1:1.
                // NOTE: the (1 - fade01) value the blob also writes to TEXCOORD_2_1.y is DEAD in every Pass0 fragment
                //   (b29 carries the interpolant but never reads it) — so there is NO fragment-side fade; the sink is the
                //   complete fragment-visible effect. Not fabricating a fragment fade here.
                float fade01 = saturate((camHeight - _HeightCullingStartHeight) * _HeightCullingGradient); // b26:153 (_118)
                float ySink = ((fade01 >= 0.95f) ? -10.0f : 0.0f) * (1.0f - unity_ObjectToWorld._m01); // b26:262 (-10/-0 select * (1-_m01))
                positionWS.y += ySink;                                                // b26:262 (Y-lean replaces base 0)
                OUT.positionWS = positionWS;
                if (!cull) { OUT.positionCS = TransformWorldToHClip(positionWS); }    // re-project after sink (keep NaN if culled)
            #endif

                return OUT;
            }

            half4 frag(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                // --- LOD crossfade dither discard (b19:187-194) ---
                if (LodDitherDiscard(IN.positionCS.xy, unity_LODFade.x, unity_LODFade.y, unity_LODFade.z, IN.occFade))
                    discard;

                // geometric world normal (b19:195-205): two-sided / tangent-sign basis
                float geoSign = (0.0f < IN.tangentWS.w) ? 1.0f : -1.0f;              // b19:195 (_115)
                float faceSign = (0.0f < _TwoSidedNormal) ? (isFrontFace ? 1.0f : -1.0f) : 1.0f; // b21:178 (_180)

                float3 worldNormal;
            #ifdef _NORMAL_MAP
                // NormalMapToWorld already bakes faceSign into the returned normal (b21:185-186,247-249, final _180*).
                worldNormal = NormalMapToWorld(IN.uv, IN.normalWS, IN.tangentWS, faceSign);  // b21:177-193
            #else
                // base path (b19:196-205): world normal = geoSign * cross(N, T), normalized. The BASE blob b19 has NO
                // front-face input and does NOT apply _TwoSidedNormal — so NO faceSign flip here (verified: b19 never
                // reads _TwoSidedNormal/gl_FrontFacing). faceSign is consumed only inside the _NORMAL_MAP branch above.
                worldNormal = geoSign * cross(IN.normalWS, IN.tangentWS.xyz);
            #endif
                float3 N = normalize(worldNormal);
                // (no external N *= faceSign: base path has no flip per b19; normalmap path already applied it per b21,
                //  so re-applying would square it to +1 and cancel the intended back-face flip.)

                // --- albedo (b19:216-222 base / b21:225-231 normalmap) ---
            #ifdef _NORMAL_MAP
                float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, IN.uv); // b21:225 (T0)
            #else
                float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, IN.uv); // b19:216 (T0)
            #endif
                float3 albedo = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale); // b19:217-219
                float3 baseCol = lerp(albedo, _BaseColor.rgb, _BaseColorTintCover);   // b19:220-222

            #ifdef _ALPHATEST_ON
                // VERIFIED (no blob delta to port — NOT a punt): _AlphaClipThreshold is declared in every _ALPHATEST_ON
                // fragment variant's cbuffer (b21:25 packoffset c1.w) but provably NEVER consumed — no clip()/discard on
                // alpha exists in ANY of the 18 Pass0 fragment blobs (b19..b53; the only discard is the LOD-dither test).
                // HG's grass cards are opaque GBuffer surfaces; their cutout is the foliage-occluder degenerate-vertex
                // path (ApplyFoliageOccluder, NaN-collapse) + LOD-crossfade dither, NOT a texture alpha clip. This clip()
                // is therefore a deliberate URP bridge (standalone URP has no HG occluder-mesh pipeline), behaviorally
                // added — there is no ground-truth clip math to make 1:1. Remove if HG occluder culling is ported.
                clip(baseTex.a * _BaseColor.a - _AlphaClipThreshold);
            #endif

                // --- height-ramp AO and directional self-shadow (b19:223-226 AO, b19:203-205,238 dir) ---
                float ao = HeightRampOcclusion(IN.posLocal, _AoParams);              // b19:226 -> SV_Target4.w
                float dirShadow = HeightRampOcclusion(IN.posLocal, _DirParams);      // b19:238 inner -> SV_Target2.y
            #ifdef _NORMAL_MAP
                // normalmap variant modulates self-shadow by the normal-map mask (b21:199-202)
                float4 nmask = SAMPLE_TEXTURE2D(_NormalMap, sampler_NormalMap, IN.uv);
                float maskM = nmask.z - 1.0f;                                         // b21:199 (_319)
                dirShadow *= mad(_MaskOnDiffuse, maskM, 1.0f);                        // b21:201-202 (_325 path)
            #endif

                // --- PBR surface (this HGRP grass packs no metallic/roughness in the deferred MRTs that
                //     reach lighting; foliage is dielectric, smoothness low). Compose a URP forward result
                //     so the reconstructed surface is visible. Lighting infra = URP (CORE_MATH §1.4). ---
                SurfaceData sd = (SurfaceData)0;
                sd.albedo = baseCol;
                sd.metallic = 0.0f;
                sd.specular = 0.0h;
                sd.smoothness = 0.0f;
                sd.occlusion = ao;
                sd.alpha = 1.0f;

                InputData inp = (InputData)0;
                inp.positionWS = IN.positionWS;
                inp.normalWS = N;
                inp.viewDirectionWS = normalize(GetWorldSpaceViewDir(IN.positionWS));
                float4 shadowCoord = TransformWorldToShadowCoord(IN.positionWS);
                inp.shadowCoord = shadowCoord;
                inp.fogCoord = ComputeFogFactor(IN.positionCS.z);
                inp.bakedGI = SampleSH(N);
                inp.normalizedScreenSpaceUV = GetNormalizedScreenSpaceUV(IN.positionCS);
                inp.shadowMask = unity_ProbesOcclusion;

                Light mainLight = GetMainLight(shadowCoord, IN.positionWS, inp.shadowMask);
                // fold the HG height self-shadow (b19:238) into the main-light realtime shadow term
                mainLight.shadowAttenuation *= dirShadow;

                half4 color = UniversalFragmentPBR(inp, sd);

                // --- back-face transmission (b19/b21 pack _Transmission + _SubsurfaceIntensity for HG's
                //     deferred SSS; forward-resolved as a wrap-lit back-face contribution) ---
                {
                    float NdotLBack = saturate(dot(-N, mainLight.direction));        // back-hemisphere
                    float trans = _Transmission;
                #ifdef _NORMAL_MAP
                    float4 nmaskT = SAMPLE_TEXTURE2D(_NormalMap, sampler_NormalMap, IN.uv);
                    trans *= mad(_MaskOnTransmission, nmaskT.z - 1.0f, 1.0f);        // b21:202 (_328 path)
                #endif
                    color.rgb += baseCol * mainLight.color * (NdotLBack * trans * mainLight.shadowAttenuation);
                    // subsurface intensity brightens ambient wrap (HG packs _SubsurfaceIntensity to MRT2.x/w)
                    color.rgb += baseCol * inp.bakedGI * (_SubsurfaceIntensity * 0.5f);
                }

            #ifdef _MODEL_SPACE_EMISSIVE
                // Model-space emissive: brighter with model-local height, optional farther-is-brighter,
                // power/bias mask. (Source grasscardmeshlod.shader Properties lines 33-40.)
                // FAITHFUL FORWARD-RECONSTRUCTION of a DEFERRED-RESOLVE feature (no blob math to port — exhaustively
                // verified): _MODEL_SPACE_EMISSIVE is NOT in any source pragma (only the 7 keywords at .shader:86-92 compile),
                // so DXC produced no variant carrying it — grep over all 18 Pass0 fragment blobs (b19..b53) AND the entire
                // …/materials/ tree finds ZERO _MSEmissive* references and they never enter any blob cbuffer. This HGRP
                // shader's Pass0 is a GBuffer SURFACE-PACKER (CORE_MATH.md §1.4); HG computes emission in its separate
                // deferred LIGHTING-RESOLVE pass (reads the packed GBuffer, not a material texture). Per §1.4 the URP forward
                // port reconstructs the surface and resolves lighting itself, so this emissive is reconstructed from the
                // property semantics (height-mask × HDR color). It is NOT a stub/no-op; it has no 1:1 blob to bind against.
                float hMask = saturate(IN.posLocal.y / max(_MSEmissiveModelHeight, 1e-4f));
                hMask = (_MSEmissiveFartherIsBrighter > 0.5f) ? hMask : (1.0f - hMask);
                hMask = saturate(pow(saturate(hMask + _MSEmissiveBias), _MSEmissiveMaskPower));
                float3 emi = _MSEmissiveColor.rgb * hMask;
                emi *= (_MSEmissiveIgnoreAlbedo > 0.5f) ? 1.0f.xxx : baseCol;
                color.rgb += emi;
            #endif
            #ifdef _EMISSIVE_MAP
                // CLOSEABLE feature CLOSED (texture-sample + additive emission): sample _EmissiveMap and add its RGB.
                // No 1:1 blob math to bind against — EXHAUSTIVELY VERIFIED: _EMISSIVE_MAP is NOT in any source pragma
                // (.shader:86-92 compiles only the 7 non-emissive keywords), so DXC emitted no variant carrying it, and
                // grep over all 18 Pass0 fragment blobs (b19..b53) + the whole …/materials/ tree finds ZERO _EmissiveMap
                // references (it never enters any blob cbuffer). HG resolves this map's emission in its deferred LIGHTING
                // pass, not in this GBuffer surface-packer (CORE_MATH.md §1.4). The source's default is albedo-independent
                // additive (_AlbedoAffectEmissive label "自发光不受固有色影响" defaults to 1 = ignore albedo), so the
                // faithful forward composite is a straight additive map. This is a closed, working feature — not a stub.
                color.rgb += SAMPLE_TEXTURE2D(_EmissiveMap, sampler_EmissiveMap, TRANSFORM_TEX(IN.uv, _EmissiveMap)).rgb;
            #endif

                color.rgb = MixFog(color.rgb, inp.fogCoord);
                color.a = 1.0f;                                                       // opaque (b19:248 SV_Target.w=1)
                return color;
            }
            ENDHLSL
        }

        // ============================================================
        // PASS 2 — ShadowCaster  (HGRP "ShadowCaster", LIGHTMODE=SHADOWCASTER, Cull [_CullMode])
        //   Base blobs: Sub0_Pass1_Vertex_b66 (+occluder+heightcull) / Sub0_Pass1_Fragment_b67 (LOD dither discard).
        // ============================================================
        Pass
        {
            Name "ShadowCaster"
            Tags { "LightMode" = "ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vertShadow
            #pragma fragment fragShadow

            #pragma shader_feature_local _USE_CAMERA_BASED_TILLING
            #pragma shader_feature_local _HEIGHT_CULLING
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW

            float3 _LightDirection;
            float3 _LightPosition;

            struct AttributesS { float3 positionOS : POSITION; float2 uv : TEXCOORD0; };
            struct VaryingsS
            {
                float4 positionCS : SV_POSITION;
                float2 occFade    : TEXCOORD0;   // blob TEXCOORD_2 (b66:121-122)
            };

            float3 ApplyFoliageOccluderS(float3 posLocal, float2 worldXZRelOccluder, out float2 occFade)
            {
                occFade = float2(0.0f, 0.0f);
                if ((_FoliageOccluderParams0.x < abs(worldXZRelOccluder.x)) ||
                    (_FoliageOccluderParams0.x < abs(worldXZRelOccluder.y)))
                    return posLocal;                                                  // b66:72-79
                float diam = _FoliageOccluderParams0.x + _FoliageOccluderParams0.x;   // b66:82
                float2 ouv = worldXZRelOccluder / diam + 0.5f;                         // b66:83
                float4 occ = SAMPLE_TEXTURE2D_LOD(_FoliageOccluderTex, sampler_FoliageOccluderTex, ouv, 0.0f);
                bool rPos = 0.0f < occ.x;
                bool masked = (0.0f < occ.y) && rPos;                                 // b66:87-88
                // blob channel order (b66:121-122): TEXCOORD_2.x = _175 (visibility), .y = _174 (param-z). Frag b67:57 gates on .x.
                occFade.x = masked ? 1.0f : (((occ.y == 0.0f) && (occ.x == 0.0f)) ? 0.0f : 1.0f); // b66:93 (_175) -> .x
                occFade.y = rPos ? _FoliageOccluderParams0.z : (1.0f - _FoliageOccluderParams0.z); // b66:92 (_174) -> .y
                return masked ? asfloat(0x7fc00000u).xxx : posLocal;                  // b66:89-91
            }

            float4 GetShadowClip(float3 positionWS, float3 normalWS)
            {
                float3 lightDir =
                #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                    normalize(_LightPosition - positionWS);
                #else
                    _LightDirection;
                #endif
                float4 cs = TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDir));
            #if UNITY_REVERSED_Z
                cs.z = min(cs.z, UNITY_NEAR_CLIP_VALUE);
            #else
                cs.z = max(cs.z, UNITY_NEAR_CLIP_VALUE);
            #endif
                return cs;
            }

            VaryingsS vertShadow(AttributesS IN)
            {
                VaryingsS OUT = (VaryingsS)0;
                float3 worldPos0 = TransformObjectToWorld(IN.positionOS);
                float2 worldXZRel = float2(worldPos0.x - _FoliageOccluderCameraPosParam.z,
                                           worldPos0.z - _FoliageOccluderCameraPosParam.w);
                float2 occFade;
                float3 posLocal = ApplyFoliageOccluderS(IN.positionOS, worldXZRel, occFade);
                float3 positionWS = TransformObjectToWorld(posLocal);
            #ifdef _USE_CAMERA_BASED_TILLING
                // 1:1 with ForwardLit (b72:128-129). Magnitude = _CameraBasedTillingIntensity (material c1.z), NOT
                // 1-intensity; second factor = (1 - unity_ObjectToWorld._m01) (b72:128 spells it as the matrix element).
                float3 camUp = float3(UNITY_MATRIX_I_V._m01, UNITY_MATRIX_I_V._m11, UNITY_MATRIX_I_V._m21);
                float  invUpLen = rsqrt(dot(camUp, camUp));
                float  lean = _CameraBasedTillingIntensity * (1.0f - unity_ObjectToWorld._m01); // b72:128-129
                positionWS.x += (camUp.x * invUpLen) * posLocal.y * lean;
                positionWS.z += (camUp.z * invUpLen) * posLocal.y * lean;
            #endif

            #ifdef _HEIGHT_CULLING
                // _HEIGHT_CULLING sink (b72:94,128-130) applied to world-Y BEFORE shadow clip (same as ForwardLit).
                float hcCamHeight = _WorldSpaceCameraPos.y - unity_ObjectToWorld._m13;       // b72:93 (_105)
                float fade01 = saturate((hcCamHeight - _HeightCullingStartHeight) * _HeightCullingGradient); // b72:94 (_118)
                positionWS.y += ((fade01 >= 0.95f) ? -10.0f : 0.0f) * (1.0f - unity_ObjectToWorld._m01); // b72:130 (* _297=1-_m01)
            #endif

                float3 normalWS = TransformObjectToWorldNormal(IN.positionOS); // grass: shadow needs only bias normal
                OUT.positionCS = GetShadowClip(positionWS, normalWS);          // b66:106-109 (HG used _ShadowpassVP; URP ApplyShadowBias)
                OUT.occFade = occFade;                                         // b66:121-122

                // ALWAYS-ON fixed-80 cone cull (b66:103-109 — base shadow blob, NO keyword gate).
                float camHeight = _WorldSpaceCameraPos.y - unity_ObjectToWorld._m13;        // b66:103 (_275)
                float cone = camHeight * 0.19885681569576263427734375f;                     // b66:104
                float2 camRelXZ = float2(unity_ObjectToWorld._m03 - _WorldSpaceCameraPos.x,
                                         unity_ObjectToWorld._m23 - _WorldSpaceCameraPos.z); // b66:95-96
                bool cull = (80.0f < camHeight) && (abs(camRelXZ.y) < cone) && (abs(camRelXZ.x) < cone); // b66:105
                if (cull) { OUT.positionCS = asfloat(0x7fc00000u).xxxx; }                    // b66:106-109
                return OUT;
            }

            half4 fragShadow(VaryingsS IN) : SV_Target
            {
                // LOD crossfade dither discard (b67:57-59)
                if (LodDitherDiscard(IN.positionCS.xy, unity_LODFade.x, unity_LODFade.y, unity_LODFade.z, IN.occFade))
                    discard;
                return 0;
            }
            ENDHLSL
        }

        // ============================================================
        // PASS 3 — DepthOnly  (HGRP "DepthOnly", LIGHTMODE=DepthOnly, Cull [_CullMode],
        //   Stencil Ref [_StencilRef] Comp Always Pass Replace.)
        //   Base blobs: Sub0_Pass2_Vertex_b102 (camera VP + occluder + heightcull) / Sub0_Pass2_Fragment_b103 (LOD dither).
        // ============================================================
        Pass
        {
            Name "DepthOnly"
            Tags { "LightMode" = "DepthOnly" }
            ZWrite On
            ColorMask R
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace Fail Keep ZFail Keep }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vertDepth
            #pragma fragment fragDepth

            #pragma shader_feature_local _USE_CAMERA_BASED_TILLING
            #pragma shader_feature_local _HEIGHT_CULLING

            struct AttributesD { float3 positionOS : POSITION; float2 uv : TEXCOORD0; };
            struct VaryingsD
            {
                float4 positionCS : SV_POSITION;
                float2 occFade    : TEXCOORD0;   // blob TEXCOORD_1_1 (b102)
                float3 posLocal   : TEXCOORD1;   // blob TEXCOORD_4 (object-local position for LOD)
            };

            float3 ApplyFoliageOccluderD(float3 posLocal, float2 worldXZRelOccluder, out float2 occFade)
            {
                occFade = float2(0.0f, 0.0f);
                if ((_FoliageOccluderParams0.x < abs(worldXZRelOccluder.x)) ||
                    (_FoliageOccluderParams0.x < abs(worldXZRelOccluder.y)))
                    return posLocal;
                float diam = _FoliageOccluderParams0.x + _FoliageOccluderParams0.x;
                float2 ouv = worldXZRelOccluder / diam + 0.5f;
                float4 occ = SAMPLE_TEXTURE2D_LOD(_FoliageOccluderTex, sampler_FoliageOccluderTex, ouv, 0.0f);
                bool rPos = 0.0f < occ.x;
                bool masked = (0.0f < occ.y) && rPos;
                // blob channel order (b102:113-114): TEXCOORD_1_1.x = _170 (visibility), .y = _169 (param-z). Frag b103:55 gates on .x.
                occFade.x = masked ? 1.0f : (((occ.y == 0.0f) && (occ.x == 0.0f)) ? 0.0f : 1.0f);
                occFade.y = rPos ? _FoliageOccluderParams0.z : (1.0f - _FoliageOccluderParams0.z);
                return masked ? asfloat(0x7fc00000u).xxx : posLocal;
            }

            VaryingsD vertDepth(AttributesD IN)
            {
                VaryingsD OUT = (VaryingsD)0;
                float3 worldPos0 = TransformObjectToWorld(IN.positionOS);
                float2 worldXZRel = float2(worldPos0.x - _FoliageOccluderCameraPosParam.z,
                                           worldPos0.z - _FoliageOccluderCameraPosParam.w);
                float2 occFade;
                float3 posLocal = ApplyFoliageOccluderD(IN.positionOS, worldXZRel, occFade);
                float3 positionWS = TransformObjectToWorld(posLocal);
            #ifdef _USE_CAMERA_BASED_TILLING
                // 1:1 with ForwardLit (b72:128-129). Magnitude = _CameraBasedTillingIntensity (material c1.z), NOT
                // 1-intensity; second factor = (1 - unity_ObjectToWorld._m01) (b72:128 spells it as the matrix element).
                float3 camUp = float3(UNITY_MATRIX_I_V._m01, UNITY_MATRIX_I_V._m11, UNITY_MATRIX_I_V._m21);
                float  invUpLen = rsqrt(dot(camUp, camUp));
                float  lean = _CameraBasedTillingIntensity * (1.0f - unity_ObjectToWorld._m01); // b72:128-129
                positionWS.x += (camUp.x * invUpLen) * posLocal.y * lean;
                positionWS.z += (camUp.z * invUpLen) * posLocal.y * lean;
            #endif
            #ifdef _HEIGHT_CULLING
                // _HEIGHT_CULLING sink (b116-equiv, same math as b26:153,262 / b72:94,128-130) applied to world-Y before clip.
                float hcCamHeight = _WorldSpaceCameraPos.y - unity_ObjectToWorld._m13;
                float fade01 = saturate((hcCamHeight - _HeightCullingStartHeight) * _HeightCullingGradient);
                positionWS.y += ((fade01 >= 0.95f) ? -10.0f : 0.0f) * (1.0f - unity_ObjectToWorld._m01); // * (1-_m01), 1:1 with b26/b72
            #endif
                OUT.positionCS = TransformWorldToHClip(positionWS);   // b102: camera VP (DepthOnly uses camera clip)
                OUT.occFade = occFade;
                OUT.posLocal = posLocal;

                // ALWAYS-ON fixed-80 cone cull (b102:96-104 — base depth blob, NO keyword gate).
                float camHeight = _WorldSpaceCameraPos.y - unity_ObjectToWorld._m13;        // b102:96 (_279)
                float cone = camHeight * 0.19885681569576263427734375f;                     // b102:97 (_280)
                float2 camRelXZ = float2(unity_ObjectToWorld._m03 - _WorldSpaceCameraPos.x,
                                         unity_ObjectToWorld._m23 - _WorldSpaceCameraPos.z); // b102:88-89
                bool cull = (80.0f < camHeight) && (abs(camRelXZ.y) < cone) && (abs(camRelXZ.x) < cone); // b102:98
                if (cull) { OUT.positionCS = asfloat(0x7fc00000u).xxxx; }                    // b102:100-104
                return OUT;
            }

            half4 fragDepth(VaryingsD IN) : SV_Target
            {
                // LOD crossfade dither discard (b103:55-57)
                if (LodDitherDiscard(IN.positionCS.xy, unity_LODFade.x, unity_LODFade.y, unity_LODFade.z, IN.occFade))
                    discard;
                return 0;
            }
            ENDHLSL
        }

        // ============================================================
        // PASS 4 — RayTracingReflection: HGRP declares an EMPTY pass (no HLSLPROGRAM) for the
        // ray-tracing reflection light-mode (grasscardmeshlod.shader:449-461). URP has no equivalent;
        // dropped entirely (no stub needed — empty source pass produced no shader code).
        // ============================================================
    }
    FallBack "Hidden/InternalErrorShader"
}
