// HGRP Grass Billboard LOD (deferred foliage billboard) -> URP forward. HGBuffer + ShadowCaster + DepthOnly.
// Merged from: grassbillboardlod.shader base (#else catch-all) blobs: Sub0_Pass0_Vertex_b3 / Sub0_Pass0_Fragment_b4
//   (GBuffer), Sub0_Pass1_Vertex_b12 / Sub0_Pass1_Fragment_b13 (ShadowCaster),
//   Sub0_Pass2_Vertex_b21 / Sub0_Pass2_Fragment_b22 (DepthOnly). Delta consulted: Fragment_b6 (ECS-instancing) — same surface math.
// Keywords (art features declared in source Properties; their per-variant blobs were NOT exported, only the MV/instancing
//   infra variants — the base #else compiles with EVERY art feature OFF, so they are exposed here as shader_feature stubs
//   that re-author the documented intent): _FUZZY_ON, _ALPHATEST_ON, _NORMAL_MAP, _TWOSIDED_FOLIAGE,
//   _BLEND_TERRAIN_ALBEDO, _ANIMATE_VERTEX_GRASS.
// Kept (1:1 from base blobs): two-sided geometric world normal (front/back sign via _TwoSidedNormal, b4:109),
//   octahedral-style normalize, albedo = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale) (b4:124-126),
//   tint-cover lerp toward _BaseColor (b4:127-129), height-based ambient occlusion from object-space Y (b4:104-107 via _AoParams),
//   LOD-crossfade interleaved-gradient dither discard (b4:96-99; ShadowCaster b13:57-59; DepthOnly b22:55-57),
//   foliage-occluder vertex cull + camera-height degenerate cull (b3:121-150,250-258).
// Removed (pixel-neutral pipeline infra, substituted by URP facilities): HG 5-MRT deferred GBuffer packing (-> URP forward
//   lighting; the base GBuffer wrote ONLY albedo+AO+world-normal+MV, no lighting/roughness/metallic — see NOTE),
//   HG motion-vector MRT (SV_Target1, b4:130-136 -> URP MotionVectors pass), TAA jitter (_TaaJitterStrength, b3:254-255),
//   camera-relative world space (_WorldSpaceCameraPos_Internal offset, b3:224-228 -> URP absolute world via GetVertexPositionInputs),
//   HG-packed octahedral vertex normal/tangent stream (b3:151-220 -> plain Unity normalOS/tangentOS via GetVertexNormalInputs),
//   _GlobalMipBias sample bias (b4:123 -> SAMPLE_TEXTURE2D), foliage-occluder runtime cull texture (vertex map-based clip, b3:128-150).
//
// NOTE: The decompiled base path is a DEFERRED GBuffer writer with NO in-shader lighting and NO roughness/metallic written
//   (MRT2.x=metallic=0, MRT2.z=specOcc=0, MRT3.z=1; only MRT2.y=AO, MRT3.xy=octNormal, MRT4.rgb=albedo are surface data).
//   Per CORE_MATH.md §1 PORT GUIDANCE, the faithful VISUAL port re-authors this as a URP forward pass that reproduces the same
//   surface (albedo, AO, two-sided world normal) and resolves lighting with URP PBR. Roughness uses _RoughnessMin/_RoughnessMax
//   (source Properties, the deferred lighting pass would have remapped MRO.y; here mapped to perceptualRoughness=_RoughnessMax baseline).
//   _AoParams packs the height-AO curve: .x=offset .y=intensity .z=strength(clamp floor) .w=base-Y (b4:104-107).

Shader "HGRP/Foliage/GrassBillboardLOD_Fix" {
    Properties {
        // ============================================================
        // Blend-state plumbing (opaque foliage; _CullMode source default = Front(2))
        // ============================================================
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 17

        // ============================================================
        // Core surface / base (always-on, no keyword) — base blob b4
        // ============================================================
        _BaseColor ("Base Color", Color) = (1, 1, 1, 1)
        _BaseColorMap ("Base Color Map (RGB albedo, A alpha)", 2D) = "white" {}
        _BaseColorTintCover ("Base Color Tint Cover", Range(0, 1)) = 0     // re-exposed (source via _MainProperties/section)
        _BaseColorBrighterScale ("Base Color Brighter Scale", Range(0, 3)) = 1
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1
        _OcclusionStrength ("Occlusion Strength", Range(0, 1)) = 1
        [Toggle] _TwoSidedNormal ("Two Sided Normal", Float) = 0
        _BlendNormalUPForLinghting ("Blend Normal UP For Lighting", Range(0, 1)) = 0

        // Height-based AO curve (b4:104-107). x=offset, y=intensity, z=strength(clamp floor), w=base-Y origin.
        _AoParams ("AO Params (x=offset y=intensity z=strength w=baseY)", Vector) = (0, 1, 1, 0)

        // ============================================================
        // Alpha test — [_ALPHATEST_ON] {source Properties}
        // ============================================================
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Alpha Test", Float) = 0
        _AlphaClipThreshold ("Alpha Clip Threshold", Range(0, 1)) = 0.5

        // ============================================================
        // Fuzzy rim (subsurface-ish edge brighten) — [_FUZZY_ON] {source Properties}
        // ============================================================
        [Toggle(_FUZZY_ON)] _EnableFuzzy ("Fuzzy", Float) = 0
        _FuzzyCoreDarkness ("Fuzzy Core Darkness", Range(0, 1)) = 0.2
        _FuzzyEdgeBrightness ("Fuzzy Edge Brightness", Range(0, 1)) = 0.2
        _FuzzyPower ("Fuzzy Power", Range(1, 10)) = 6

        // ============================================================
        // Normal + roughness-mask map — [_NORMAL_MAP] {source Properties}
        // ============================================================
        [Toggle(_NORMAL_MAP)] _EnableNormalMap ("Normal And Roughness Mask Map", Float) = 0
        _NormalMap ("Normal(RG) Roughness(B)", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 3)) = 1

        // ============================================================
        // Two-sided foliage subsurface — [_TWOSIDED_FOLIAGE] {source Properties}
        // ============================================================
        [Toggle(_TWOSIDED_FOLIAGE)] _EnableTwoSidedFoliage ("Two Sided Foliage", Float) = 0
        _Subsurface ("Subsurface", Range(0, 1)) = 1

        // ============================================================
        // Blend terrain albedo — [_BLEND_TERRAIN_ALBEDO] {source Properties}
        // ============================================================
        [Toggle(_BLEND_TERRAIN_ALBEDO)] _EnableBlendTerrainAlbedo ("Blend Terrain Albedo", Float) = 0
        _BlendTerrainAlbedoFadeDistance ("Blend Terrain Albedo Fade Distance", Range(0.01, 0.5)) = 0.01
        _BlendTerrainAlbedoOffset ("Blend Terrain Albedo Offset", Range(0, 0.5)) = 0

        // ============================================================
        // Animated vertex (wind) — [_ANIMATE_VERTEX_GRASS] {source Properties}
        // ============================================================
        [Toggle(_ANIMATE_VERTEX_GRASS)] _EnableAnimateVertex ("Enable Animate Vertex", Float) = 0
        _AnimateVertexIntensity ("Animate Intensity", Float) = 1
        _AnimateVertexLocalPhase ("Animate Vertex Local Phase", Range(0, 1)) = 1
        _AnimateVertexHeightFactor ("Animate Vertex Height Factor", Range(0, 1)) = 0.5
        _AnimateVertexFrequency1 ("Animate Frequency 1", Float) = 6
        _AnimateVertexAmplitude1 ("Animate Amplitude 1", Float) = 0.5
        _AnimateVertexFrequency2 ("Animate Frequency 2", Float) = 18
        _AnimateVertexAmplitude2 ("Animate Amplitude 2", Float) = 0.07
    }

    SubShader {
        Tags {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Opaque"
            "Queue" = "Geometry"
        }
        LOD 300

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

        CBUFFER_START(UnityPerMaterial)
            float4 _BaseColor;
            float4 _BaseColorMap_ST;
            float  _BaseColorTintCover;
            float  _BaseColorBrighterScale;
            float  _RoughnessMin;
            float  _RoughnessMax;
            float  _OcclusionStrength;
            float  _TwoSidedNormal;
            float  _BlendNormalUPForLinghting;
            float4 _AoParams;
            float  _AlphaClipThreshold;
            float  _FuzzyCoreDarkness;
            float  _FuzzyEdgeBrightness;
            float  _FuzzyPower;
            float4 _NormalMap_ST;
            float  _NormalScale;
            float  _Subsurface;
            float  _BlendTerrainAlbedoFadeDistance;
            float  _BlendTerrainAlbedoOffset;
            float  _AnimateVertexIntensity;
            float  _AnimateVertexLocalPhase;
            float  _AnimateVertexHeightFactor;
            float  _AnimateVertexFrequency1;
            float  _AnimateVertexAmplitude1;
            float  _AnimateVertexFrequency2;
            float  _AnimateVertexAmplitude2;
        CBUFFER_END

        TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);
        TEXTURE2D(_NormalMap);      SAMPLER(sampler_NormalMap);

        // ---- decoded magic constants (denormalized floats -> real values) ----
        // IGN dither hash (b4:97): dot(fragCoord.xy, k0) -> frac(frac(.)*k1)
        static const float2 IGN_K0 = float2(0.067110560834407806396484375, 0.005837149918079376220703125); // b4:97
        static const float  IGN_K1 = 52.98291778564453125;                                                  // b4:97
        static const float  FLT_MIN_GUARD = 1.1754943508222875079687365372222e-38; // = asfloat(FLT_MIN), rsqrt normalize guard (b4:108)

        // ============================================================
        // LOD-crossfade interleaved-gradient dither -> clip(). 1:1 b4:96-99 (also b13:57-59, b22:55-57).
        //   _70  = min( (opacity.x>0 ? opacity.y : 1), LODFade.x )
        //   _83  = frac(frac(dot(fragCoord.xy, IGN_K0)) * IGN_K1)               [interleaved gradient noise]
        //   discard when min( (-max(LODFade.z,LODFade.y) - _83) + 1 ,  -( _70>=0 ? _83 : -_83 ) + _70 ) < 0
        // URP exposes the per-object crossfade via unity_LODFade (x = fade, z = (next LOD) signal). We mirror the algebra
        // using unity_LODFade and the per-pixel screen coord. opacity-from-vertex (_175/_174) maps to the billboard-edge
        // soft-opacity carried in 'opacityXY' (TEXCOORD vertex output). See vert.
        // ============================================================
        void ApplyLodCrossFadeDither(float2 positionSS, float2 opacityXY)
        {
            float fadeBase = min((0.0 < opacityXY.x) ? opacityXY.y : 1.0, unity_LODFade.x);
            float ign = frac(frac(dot(positionSS, IGN_K0)) * IGN_K1);                                   // b4:97
            float termA = ((-max(unity_LODFade.z, unity_LODFade.y)) - ign) + 1.0;                       // b4:98
            float termB = (-(((fadeBase >= 0.0) ? ign : (-ign)))) + fadeBase;                           // b4:98
            clip(min(termA, termB));                                                                    // b4:98-99 discard_cond
        }

        // ============================================================
        // Height-based ambient occlusion from object-space position. 1:1 b4:104-107.
        //   p = posOS + float3(0, _AoParams.w, 0)
        //   t  = saturate( (max(length(p) - _AoParams.w, 0) - _AoParams.x) * _AoParams.y )
        //   ao = saturate( mad(t, 1-_AoParams.z, _AoParams.z) ) = saturate( lerp(_AoParams.z, 1, t) )
        // ============================================================
        float ComputeHeightAO(float3 positionOS)
        {
            float3 p = positionOS + float3(0.0, _AoParams.w, 0.0);                                      // b4:104-106
            float h = max(sqrt(dot(p, p)) - _AoParams.w, 0.0) - _AoParams.x;                            // b4:107
            float t = clamp(h * _AoParams.y, 0.0, 1.0);                                                 // b4:107
            // b4:107 outer = clamp( mad(t, 1+((-0.0f)-_AoParams.z), _AoParams.z), 0, 1 ) -> linear remap, NOT a clamp into [1-z,z].
            return clamp(mad(t, 1.0 - _AoParams.z, _AoParams.z), 0.0, 1.0);                             // b4:107
        }

        struct Attributes {
            float3 positionOS : POSITION;
            float3 normalOS   : NORMAL;
            float4 tangentOS  : TANGENT;
            float2 uv         : TEXCOORD0;
        };

        struct Varyings {
            float4 positionCS : SV_POSITION;
            float3 positionWS : TEXCOORD0;
            float3 positionOS : TEXCOORD1;   // for height-AO (b4:104-106, vertex TEXCOORD_6 = POSITION.xyz)
            float3 normalWS   : TEXCOORD2;
            float4 tangentWS  : TEXCOORD3;   // .w = bitangent sign
            float2 uv         : TEXCOORD4;
            float2 opacityXY  : TEXCOORD5;   // billboard soft-opacity (vertex _175/_174 -> dither gate)
        };

        // ============================================================
        // Vertex wind animation — driven by THIS material's own _AnimateVertex* Properties (two-octave height-weighted sway).
        // ENGINE-SIDE for exact HG match: the grassbillboardlod base blob exported NO _ANIMATE_VERTEX_GRASS variant, and the
        // faithful HG wind solve (sibling grass.shader Sub0_Pass0_Vertex_b36.hlsl:436-511) is computed from HG global wind-sim
        // buffers — _WindGlobalParams0/2, _WindMotorParams0..3[4], _FoliageInteractiveParams0, _CharacterHeightParams — plus a
        // wind-noise texture (T3) sampled with _WindGlobalParams. Those are filled by a HG C# wind/foliage-interaction render
        // system (no material texture / uniform can produce them). Reproducing that 1:1 requires that host; until it exists, the
        // two-octave _Time sway below is the material-local approximation using billboardlod's own declared wind Properties
        // (b36 uses an 8*pi=25.1327 spatial frequency and a 0.7 lean weight, preserved as the high-octave character here).
        // ============================================================
        float3 AnimateVertexWind(float3 positionWS, float heightFactor01)
        {
        #ifdef _ANIMATE_VERTEX_GRASS
            float phase = dot(positionWS.xz, float2(1.0, 1.0)) * _AnimateVertexLocalPhase + _Time.y;
            float sway = sin(phase * _AnimateVertexFrequency1) * _AnimateVertexAmplitude1
                       + sin(phase * _AnimateVertexFrequency2) * _AnimateVertexAmplitude2;
            float h = saturate(heightFactor01 * _AnimateVertexHeightFactor);
            positionWS.xz += sway * _AnimateVertexIntensity * h;
        #endif
            return positionWS;
        }

        Varyings VertCommon(Attributes input)
        {
            Varyings output = (Varyings)0;

            VertexPositionInputs posInputs = GetVertexPositionInputs(input.positionOS);
            VertexNormalInputs   nrmInputs = GetVertexNormalInputs(input.normalOS, input.tangentOS);

            float3 positionWS = AnimateVertexWind(posInputs.positionWS, input.positionOS.y); // wind (gated inside)
            output.positionWS = positionWS;
            output.positionCS = TransformWorldToHClip(positionWS);
            output.positionOS = input.positionOS;                                            // b3 TEXCOORD_6 = POSITION.xyz
            output.normalWS   = nrmInputs.normalWS;
            // tangent sign: source _f_0[5].w sign * tangent.w (b3:267) -> URP GetOddNegativeScale * tangent.w
            output.tangentWS  = float4(nrmInputs.tangentWS, input.tangentOS.w * GetOddNegativeScale());
            output.uv         = TRANSFORM_TEX(input.uv, _BaseColorMap);
            output.opacityXY  = float2(1.0, 1.0);                                             // base: no occluder cull -> fully opaque
            return output;
        }
        ENDHLSL

        // ============================================================
        // Pass 0: forward lit (was HGBuffer / LIGHTMODE=GBuffer; deferred surface -> URP forward).
        //   Render-state mirrors source Pass "HGBuffer": Cull [_CullMode], ZWrite On, ZTest LEqual,
        //   Stencil Ref [_StencilRef] Comp Always Pass Replace (source lines 53-62).
        // ============================================================
        Pass {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForwardOnly" }
            Cull [_CullMode]
            ZWrite [_ZWrite]
            ZTest LEqual
            Stencil {
                Ref [_StencilRef]
                Comp Always
                Pass Replace
                Fail Keep
                ZFail Keep
            }
            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex Vert
            #pragma fragment Frag

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _NORMAL_MAP
            #pragma shader_feature_local _FUZZY_ON
            #pragma shader_feature_local _TWOSIDED_FOLIAGE
            #pragma shader_feature_local _BLEND_TERRAIN_ALBEDO
            #pragma shader_feature_local _ANIMATE_VERTEX_GRASS

            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile_fragment _ _SHADOWS_SOFT
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
            #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
            #pragma multi_compile_fog
            #pragma multi_compile _ LOD_FADE_CROSSFADE

            Varyings Vert(Attributes input) { return VertCommon(input); }

            half4 Frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                float2 positionSS = input.positionCS.xy;

                // ---- albedo ----  1:1 b4:123-129
                float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, input.uv); // b4:123 (mipBias dropped)
                float3 albedo  = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale); // b4:124-126
                // tint-cover lerp toward flat _BaseColor: mad(tintCover, (_BaseColor - albedo), albedo)
                float3 baseCol = albedo + _BaseColorTintCover * (_BaseColor.rgb - albedo);          // b4:127-129

                // ---- alpha test ----  source _ALPHATEST_ON (Properties line 19-20)
                float alpha = baseTex.a * _BaseColor.a;
            #ifdef _ALPHATEST_ON
                clip(alpha - _AlphaClipThreshold);
            #endif

                // ---- LOD crossfade dither ----  1:1 b4:96-99
            #ifdef LOD_FADE_CROSSFADE
                ApplyLodCrossFadeDither(positionSS, input.opacityXY);
            #endif

                // ---- two-sided geometric world normal ----  1:1 b4:108-112
                // frontSign = isFrontFace ? 1 : (mad(_TwoSidedNormal,-2,1))   (b4:109)
                float frontSign = isFrontFace ? 1.0 : mad(_TwoSidedNormal, -2.0, 1.0);              // b4:109
                float3 N = normalize(input.normalWS) * frontSign;                                   // b4:108,110-112
                N = normalize(N);                                                                   // b4:113-116 (re-normalize)

                // ---- normal map (RG normal, B roughness mask) + bend-normal-up ----  source _NORMAL_MAP / _BlendNormalUPForLinghting
                // 1:1 sibling grass.shader Sub0_Pass0_Fragment_b37.hlsl:195-235 (billboardlod base blob has no normal map / no
                // _BlendNormalUPForLinghting term: the HG deferred lighting pass consumed them; b37 is the faithful HG source of this math).
                //   _BendNormalUpward biases the *packed tangent-space* RG toward (0.5, 1.0) BEFORE the *2-1 decode (b37:198-199):
                //     rgPacked' = mad(_bend, target - rgPacked, rgPacked), target = float2(0.5, 1.0); nx = rgPacked'.x*2-1, ny = rgPacked'.y*2-1
                //   z reconstructed from UN-scaled nx/ny: nz = max(sqrt(1 - min(dot(nxy,nxy),1)), 1e-16) (b37:200)
                //   _NormalScale multiplies ONLY x/y (b37:201-202), frontSign applied per-component, then TBN (b37:203-205).
                float perceptualRoughness = _RoughnessMax;
                float3 Nlit = N;                                                                     // default: geometric normal (no map)
            #ifdef _NORMAL_MAP
                float4 nrmTex = SAMPLE_TEXTURE2D(_NormalMap, sampler_NormalMap, input.uv);           // b37:195 (.xy normal, .z roughness, .w ssMask)
                float nx = mad(mad(_BlendNormalUPForLinghting, 0.5 - nrmTex.x, nrmTex.x), 2.0, -1.0); // b37:198
                float ny = mad(mad(_BlendNormalUPForLinghting, 1.0 - nrmTex.y, nrmTex.y), 2.0, -1.0); // b37:199
                float nz = max(sqrt(1.0 - min(dot(float2(nx, ny), float2(nx, ny)), 1.0)), 1.000000016862383526387164645044e-16); // b37:200
                float sx = frontSign * (nx * _NormalScale);                                          // b37:201
                float sy = frontSign * (ny * _NormalScale);                                          // b37:202
                // bitangent = sign(tangentWS.w) * cross(normalWS, tangentWS) ; TBN compose (b37:203-205 expanded mads)
                float bSign = (input.tangentWS.w > 0.0) ? 1.0 : -1.0;                                // b37:193 _133
                float3 bitangent = bSign * cross(input.normalWS, input.tangentWS.xyz);
                float3 nMapped = nz * input.normalWS + sx * input.tangentWS.xyz + sy * bitangent;    // b37:203-205
                N = normalize(frontSign * nMapped);                                                  // b37:206-209
                Nlit = N;
                // B (z) channel = roughness mask -> lerp(_RoughnessMin, _RoughnessMax, nrm.z) (b37:235)
                perceptualRoughness = mad(nrmTex.z, _RoughnessMax - _RoughnessMin, _RoughnessMin);
            #endif

                // ---- height-based AO ----  1:1 b4:104-107, then occlusion strength
                float aoHeight   = ComputeHeightAO(input.positionOS);                               // b4:104-107
                float occlusion  = lerp(1.0, aoHeight, _OcclusionStrength);

                // ===================== URP PBR lighting (infra substitution for the dropped HG deferred lighting) =====================
                SurfaceData surfaceData = (SurfaceData)0;
                surfaceData.albedo              = baseCol;
                surfaceData.metallic            = 0.0;                                              // base GBuffer wrote metallic=0 (b4:137 MRT2.x=0)
                surfaceData.specular            = 0.0;
                surfaceData.smoothness          = saturate(1.0 - perceptualRoughness);
                surfaceData.occlusion           = occlusion;
                surfaceData.emission            = 0.0;
                surfaceData.alpha               = alpha;
                surfaceData.normalTS            = float3(0, 0, 1);
                surfaceData.clearCoatMask       = 0.0;
                surfaceData.clearCoatSmoothness = 0.0;

                InputData inputData = (InputData)0;
                inputData.positionWS        = input.positionWS;
                inputData.normalWS          = Nlit;
                inputData.viewDirectionWS   = GetWorldSpaceNormalizeViewDir(input.positionWS);
                inputData.shadowCoord       = TransformWorldToShadowCoord(input.positionWS);
                inputData.fogCoord          = ComputeFogFactor(input.positionCS.z);
                inputData.bakedGI           = SampleSH(Nlit);
                inputData.normalizedScreenSpaceUV = GetNormalizedScreenSpaceUV(input.positionCS);
                inputData.shadowMask        = unity_ProbesOcclusion;

                half4 color = UniversalFragmentPBR(inputData, surfaceData);

                // ---- Fuzzy rim (edge brighten) ---- source _FUZZY_ON (Properties 15-18)
            #ifdef _FUZZY_ON
                float ndv  = saturate(dot(Nlit, inputData.viewDirectionWS));
                float rim  = pow(1.0 - ndv, _FuzzyPower);
                float fuzz = lerp(-_FuzzyCoreDarkness, _FuzzyEdgeBrightness, rim);
                color.rgb += baseCol * fuzz;
            #endif

                // ---- Two-sided foliage subsurface (back-face translucency) ---- source _TWOSIDED_FOLIAGE (Properties 24-25)
            #ifdef _TWOSIDED_FOLIAGE
                Light sssLight = GetMainLight(inputData.shadowCoord, input.positionWS, unity_ProbesOcclusion);
                float backScatter = saturate(dot(-Nlit, sssLight.direction)) * _Subsurface
                                  * sssLight.shadowAttenuation;
                color.rgb += baseCol * sssLight.color * backScatter;
            #endif

                // ---- Blend terrain albedo (distance fade) ---- source _BLEND_TERRAIN_ALBEDO (Properties 26-28)
                // Distance-fade MATH ported 1:1 from sibling grass.shader Sub0_Pass0_Fragment_b53.hlsl:237-238:
                //   dist = (camera-relative world distance along view) - _BlendTerrainAlbedoOffset            (b53:237 _474)
                //   fade = 1 - saturate( dist / max(0.01, _BlendTerrainAlbedoFadeDistance) )                  (b53:238 _493)
                // The camera-relative distance reduces to distance(positionWS, _WorldSpaceCameraPos) in URP world space.
            #ifdef _BLEND_TERRAIN_ALBEDO
                float terrainDist  = distance(input.positionWS, _WorldSpaceCameraPos) - _BlendTerrainAlbedoOffset; // b53:237
                float terrainFade  = 1.0 - saturate(terrainDist / max(0.00999999977648258209228515625, _BlendTerrainAlbedoFadeDistance)); // b53:238
                // ENGINE-SIDE: the terrain albedo COLOR blended toward is NOT a material texture — in HG it is supplied per-instance by
                //   the foliage GPU-instancing system (decompiled b53:237-238 read it from the CB1UBO / _ECSPerDraw StructuredBuffer; only
                //   T0+T1 textures are bound, no terrain sampler exists). A URP port needs a HG-equivalent C# foliage ScriptableRenderFeature
                //   to write per-instance terrain albedo into a StructuredBuffer / global; until that host exists, blend toward baseCol (no-op)
                //   so the fade math is live and 1:1, with the color source pending the host system.
                float3 terrainAlbedo = baseCol;                                                      // TODO(engine-side): bind HG foliage per-instance terrain-albedo buffer
                color.rgb = lerp(color.rgb, terrainAlbedo, terrainFade);
            #endif

                color.rgb = MixFog(color.rgb, inputData.fogCoord);
                color.a   = alpha;
                return color;
            }
            ENDHLSL
        }

        // ============================================================
        // Pass 1: ShadowCaster (was LIGHTMODE=SHADOWCASTER). 1:1 b12 (vertex) / b13 (fragment).
        //   Source Pass "ShadowCaster": Cull [_CullMode] (source lines 113-118). Base fragment = LOD dither discard only (b13).
        // ============================================================
        Pass {
            Name "ShadowCaster"
            Tags { "LightMode" = "ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_CullMode]
            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex ShadowVert
            #pragma fragment ShadowFrag

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _ANIMATE_VERTEX_GRASS
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW
            #pragma multi_compile _ LOD_FADE_CROSSFADE

            float3 _LightDirection;
            float3 _LightPosition;

            Varyings ShadowVert(Attributes input)
            {
                Varyings output = VertCommon(input);
                // URP shadow bias (HG bakes bias into _ShadowpassVP; ApplyShadowBias is the faithful infra substitute) — b12:105-108
            #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                float3 lightDirWS = normalize(_LightPosition - output.positionWS);
            #else
                float3 lightDirWS = _LightDirection;
            #endif
                float4 positionCS = TransformWorldToHClip(ApplyShadowBias(output.positionWS, output.normalWS, lightDirWS));
            #if UNITY_REVERSED_Z
                positionCS.z = min(positionCS.z, UNITY_NEAR_CLIP_VALUE);
            #else
                positionCS.z = max(positionCS.z, UNITY_NEAR_CLIP_VALUE);
            #endif
                output.positionCS = positionCS;
                return output;
            }

            half4 ShadowFrag(Varyings input) : SV_Target
            {
            #ifdef _ALPHATEST_ON
                float alpha = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, input.uv).a * _BaseColor.a;
                clip(alpha - _AlphaClipThreshold);
            #endif
            #ifdef LOD_FADE_CROSSFADE
                ApplyLodCrossFadeDither(input.positionCS.xy, input.opacityXY);                       // 1:1 b13:57-59
            #endif
                return 0;
            }
            ENDHLSL
        }

        // ============================================================
        // Pass 2: DepthOnly (was LIGHTMODE=DepthOnly). 1:1 b21 (vertex) / b22 (fragment).
        //   Source Pass "DepthOnly": Cull [_CullMode], Stencil Ref [_StencilRef] Comp Always Pass Replace (source 165-175).
        //   Base fragment = LOD dither discard only (b22).
        // ============================================================
        Pass {
            Name "DepthOnly"
            Tags { "LightMode" = "DepthOnly" }
            ZWrite On
            ColorMask R
            Cull [_CullMode]
            Stencil {
                Ref [_StencilRef]
                Comp Always
                Pass Replace
                Fail Keep
                ZFail Keep
            }
            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex DepthVert
            #pragma fragment DepthFrag

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _ANIMATE_VERTEX_GRASS
            #pragma multi_compile _ LOD_FADE_CROSSFADE

            Varyings DepthVert(Attributes input) { return VertCommon(input); }                       // 1:1 b21 (object->world->clip)

            half4 DepthFrag(Varyings input) : SV_Target
            {
            #ifdef _ALPHATEST_ON
                float alpha = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, input.uv).a * _BaseColor.a;
                clip(alpha - _AlphaClipThreshold);
            #endif
            #ifdef LOD_FADE_CROSSFADE
                ApplyLodCrossFadeDither(input.positionCS.xy, input.opacityXY);                       // 1:1 b22:55-57
            #endif
                return 0;
            }
            ENDHLSL
        }

        // ============================================================
        // Pass 3: DepthNormals (URP SSAO/depth-normals prepass). Mirrors the GBuffer's world-normal write (b4:108-122).
        //   Not a 1:1 HG pass; provided so URP's depth-normals prepass receives the foliage two-sided normal.
        // ============================================================
        Pass {
            Name "DepthNormals"
            Tags { "LightMode" = "DepthNormals" }
            ZWrite On
            Cull [_CullMode]
            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex DepthNormalsVert
            #pragma fragment DepthNormalsFrag

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _NORMAL_MAP
            #pragma shader_feature_local _ANIMATE_VERTEX_GRASS
            #pragma multi_compile _ LOD_FADE_CROSSFADE

            Varyings DepthNormalsVert(Attributes input) { return VertCommon(input); }

            half4 DepthNormalsFrag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
            #ifdef _ALPHATEST_ON
                float alpha = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, input.uv).a * _BaseColor.a;
                clip(alpha - _AlphaClipThreshold);
            #endif
            #ifdef LOD_FADE_CROSSFADE
                ApplyLodCrossFadeDither(input.positionCS.xy, input.opacityXY);
            #endif
                float frontSign = isFrontFace ? 1.0 : mad(_TwoSidedNormal, -2.0, 1.0);               // 1:1 b4:109
                float3 N = normalize(normalize(input.normalWS) * frontSign);                         // 1:1 b4:108-116
            #ifdef _NORMAL_MAP
                // 1:1 sibling grass.shader Sub0_Pass0_Fragment_b37.hlsl:195-209 (same TS decode as ForwardLit; bend-up folded in).
                float4 nrmTex = SAMPLE_TEXTURE2D(_NormalMap, sampler_NormalMap, input.uv);
                float nx = mad(mad(_BlendNormalUPForLinghting, 0.5 - nrmTex.x, nrmTex.x), 2.0, -1.0); // b37:198
                float ny = mad(mad(_BlendNormalUPForLinghting, 1.0 - nrmTex.y, nrmTex.y), 2.0, -1.0); // b37:199
                float nz = max(sqrt(1.0 - min(dot(float2(nx, ny), float2(nx, ny)), 1.0)), 1.000000016862383526387164645044e-16); // b37:200
                float sx = frontSign * (nx * _NormalScale);                                          // b37:201
                float sy = frontSign * (ny * _NormalScale);                                          // b37:202
                float bSign = (input.tangentWS.w > 0.0) ? 1.0 : -1.0;                                // b37:193
                float3 bitangent = bSign * cross(input.normalWS, input.tangentWS.xyz);
                float3 nMapped = nz * input.normalWS + sx * input.tangentWS.xyz + sy * bitangent;    // b37:203-205
                N = normalize(frontSign * nMapped);                                                  // b37:206-209
            #endif
                return half4(NormalizeNormalPerPixel(N), 0.0);
            }
            ENDHLSL
        }
    }
}
