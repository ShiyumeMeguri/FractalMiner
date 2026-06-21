// HGRP LitHLOD — Hierarchical-LOD impostor surface for opaque props. HGBuffer(->ForwardLit) + ShadowCaster + DepthOnly.
// Merged from: lithlod.shader (base/#else variants: HGBuffer Vertex b1, HGBuffer Fragment b2,
//   ShadowCaster Vertex b6 [inline in skeleton], ShadowCaster Fragment b7 [empty], DepthOnly Vertex b10, DepthOnly Fragment b11).
//   _DITHER delta blob (DepthOnly Fragment b13) folded in as a runtime ToggleUI LOD-crossfade clip.
// Keywords: (none kept as shader_feature). HG multi_compile_local _ HG_ENABLE_MV / _ SRP_INSTANCING_ON / _ LIGHTMAP_ON / _ DITHER
//   are pipeline/instancing/lightmap/LOD-crossfade infra -> URP facilities; only _DITHER survives as a runtime ToggleUI.
// Kept (1:1 math): HLOD-baked GBuffer surface from 2 maps — _BaseColorMap(T0): RGB=albedo, A packs emission via
//   clamp(A*(10/9) - (1/9), 0,1)*_PackedEmissiveIntensity (b2:73-76); _NormalMap(T1): .a=smoothness (b2:93),
//   .b passthrough (b2:97), .xy = tangent-space normal with |n|<0.012 deadzone-to-0 (b2:95-99) -> TBN world normal
//   (b2:100-103, tangent-sign _194 from TEXCOORD_3.w) -> normalize. DepthOnly LOD-crossfade interleaved-gradient discard (b13).
// Removed (pixel-neutral pipeline infra, substituted by URP): GPU/HG packed-octahedral vertex normal+tangent decode
//   (b1:144-213, 10:10:10:2 unpack + oct-decode + tangent-frame reconstruct -> URP GetVertexNormalInputs), SRP per-draw
//   instancing buffer + camera-relative CB1_m0 object->world (b1:217-289 -> URP GetVertexPositionInputs), HG motion-vector
//   MRT (SV_Target1 sqrt-encoded screen MV from cur/prev clip b2:77-85, + prev-frame world pos b1:251-275) -> URP has a
//   dedicated MotionVectors pass, dropped. HG 5-MRT deferred GBuffer packing (octahedral normal MRT3.xy, albedo MRT4,
//   emission MRT0, smoothness MRT2.x) -> URP ForwardLit resolves lighting in-fragment (CORE_MATH §1.4 PORT GUIDANCE).
//   The vertical-flip clip hack (gl_Position.xy -= worldTransformParams.zw*w*±2, b1:249-250) is HG render-target
//   y-flip plumbing -> URP TransformWorldToHClip is already correct-handed.
//
// NOTE: this is NOT the full Lit PBR surface (CORE_MATH §2) — it is the HLOD IMPOSTOR bake, which carries only
//   albedo + emission + world-normal + smoothness (no metallic/specular/roughness-remap/occlusion map, no _BaseColor
//   tint, no MRO map). Metallic is taken as 0 and specular/smoothness drive a standard URP PBR resolve so the impostor
//   shades consistently with the full Lit material it replaces at distance.
//   _NormalMap channels: .xy = normal XY (remap *2-1, deadzone 0.012), .a = smoothness, .b = unused-passthrough.

Shader "HGRP/LitHLOD_Fix"
{
    Properties
    {
        _BaseColorMap ("Base Color Map (RGB albedo, A=packed emission)", 2D) = "white" {}
        _NormalMap ("Normal Map (XY normal, A=smoothness)", 2D) = "bump" {}
        _PackedEmissiveIntensity ("Packed Emissive Intensity", Float) = 0
        _DitherScale ("Dither Scale", Range(0, 1)) = 1

        // Surface / blend plumbing (opaque defaults; skeleton: Cull [_CullMode], ZClip On)
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [HideInInspector] _ShadowCullMode ("Shadow Render Face", Float) = 2
        [HideInInspector] _ShadowBias ("Shadow Bias", Float) = 0
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0

        // DepthOnly LOD-crossfade dither clip (HG _DITHER multi_compile_local -> runtime ToggleUI)
        [ToggleUI] _EnableDither ("Enable LOD Dither", Float) = 0
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

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

        CBUFFER_START(UnityPerMaterial)
            // type_UnityPerMaterial (Fragment b2:20-23). HLOD bake carries only the emissive intensity scalar.
            float  _PackedEmissiveIntensity;   // b2 c0.y
            float4 _BaseColorMap_ST;           // URP tiling for _BaseColorMap (HG sampled raw uv; ST added for URP batching)
            float4 _NormalMap_ST;              // URP tiling for _NormalMap
            float  _DitherScale;
            float  _EnableDither;
        CBUFFER_END

        TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);   // b2 T0 (sampler_LinearClamp)
        TEXTURE2D(_NormalMap);      SAMPLER(sampler_NormalMap);      // b2 T1 (sampler_LinearRepeat)

        // ------------------------------------------------------------
        // Magic-constant decodes (b2 / b13). asfloat(uint) bit-patterns -> real values.
        // ------------------------------------------------------------
        // b2:73 emission alpha remap: clamp(a * 1.111111164 - 0.111111119, 0, 1) = clamp(a*(10/9) - (1/9), 0, 1).
        static const float EMISSIVE_A_SCALE  = 1.111111164093017578125;   // 10/9
        static const float EMISSIVE_A_BIAS   = -0.11111111938953399658203125; // -1/9
        // b2:98-99 normal-XY deadzone: |n|<0.012 -> 0.
        static const float NORMAL_DEADZONE   = 0.01200000010430812835693359375; // 0.012
        // b2:104 normalize rsqrt guard = FLT_MIN.
        static const float FLT_MIN_GUARD     = 1.1754943508222875079687365372222e-38;
        // b13:69 interleaved-gradient-noise (LOD-crossfade dither).
        static const float2 IGN_MAGIC = float2(0.067110560834407806396484375, 0.005837149918079376220703125);
        static const float  IGN_SCALE = 52.98291778564453125;

        float InterleavedGradientNoise(float2 pixelCoord)
        {
            return frac(frac(dot(pixelCoord, IGN_MAGIC)) * IGN_SCALE);
        }
        ENDHLSL

        // ============================================================
        // Pass: ForwardLit  (HG LIGHTMODE "GBuffer" / HGBuffer -> URP UniversalForwardOnly)
        //   Source render-state (lithlod.shader:23-36): ZClip On, Cull [_CullMode],
        //     Stencil { Comp Always Pass Replace Fail Keep ZFail Keep }.
        //   Base blobs: Vertex b1, Fragment b2.  (CORE_MATH §1.4: re-author the HG 5-MRT
        //   deferred GBuffer as forward-resolved lighting; the HLOD bake supplies the surface.)
        // ============================================================
        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForwardOnly" }

            ZTest LEqual
            ZWrite On
            Cull [_CullMode]

            Stencil
            {
                Ref [_StencilRef]
                Comp Always
                Pass Replace
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            // URP lighting infra (replaces HG deferred GBuffer + downstream deferred lighting).
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
            #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
            #pragma multi_compile_fragment _ _SCREEN_SPACE_OCCLUSION
            #pragma multi_compile_fog

            struct Attributes
            {
                float4 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float2 uv0        : TEXCOORD0;
                float2 uv1        : TEXCOORD1;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;   // b1: TEXCOORD (uv0)
                float3 normalWS   : TEXCOORD1;   // b1: TEXCOORD_2_1 (geometric world normal)
                float4 tangentWS  : TEXCOORD2;   // b1: TEXCOORD_3 (.xyz tangent world, .w sign)
                float3 positionWS : TEXCOORD3;   // b1: TEXCOORD_5 (world position)
                float  fogFactor  : TEXCOORD4;
            };

            Varyings vert(Attributes input)
            {
                Varyings output = (Varyings)0;

                // HG packed-octahedral NORMAL+TANGENT decode (b1:144-213) + SRP per-draw instanced
                // camera-relative object->world (b1:217-289) are mesh-import / instancing infra
                // -> URP standard transforms (CORE_MATH §3.1/§3.3).
                VertexPositionInputs posInputs = GetVertexPositionInputs(input.positionOS.xyz);
                VertexNormalInputs   nrmInputs = GetVertexNormalInputs(input.normalOS, input.tangentOS);

                output.positionCS = posInputs.positionCS;     // b1:246-277 object->world->clip (y-flip hack dropped, §header)
                output.positionWS = posInputs.positionWS;     // b1:246-248 world pos (_463/_464/_466). (b1 TEXCOORD_5 = clip-space MV data, not worldPos; URP supplies worldPos for the forward resolve)
                output.normalWS   = nrmInputs.normalWS;        // b1:262-264 normalize(inverse-transpose * N)
                output.tangentWS  = float4(nrmInputs.tangentWS,
                                           input.tangentOS.w * GetOddNegativeScale()); // b1:266-269 tangent world + sign _194
                output.uv         = input.uv0;                 // b1:278-279 TEXCOORD passthrough
                output.fogFactor  = ComputeFogFactor(posInputs.positionCS.z);
                return output;
            }

            float4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                float2 uv = input.uv;

                // ---- _BaseColorMap (T0) : RGB = albedo, A packs emission (b2:68-76) ----
                // SampleBias(sampler_LinearClamp, uv, _GlobalMipBias) -> URP SAMPLE_TEXTURE2D_BIAS folds _GlobalMipBias.
                float4 baseTex = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uv, 0.0);
                float3 albedo  = baseTex.rgb;                                   // b2:70-72,87-89 (MRT4 albedo / MRT0 rgb base)
                // b2:73 : emissiveScale = clamp(A*(10/9) - (1/9), 0, 1) * _PackedEmissiveIntensity.
                float  emissiveScale = clamp(mad(baseTex.w, EMISSIVE_A_SCALE, EMISSIVE_A_BIAS), 0.0, 1.0) * _PackedEmissiveIntensity;
                float3 emission = albedo * emissiveScale;                       // b2:74-76 (MRT0.rgb = albedo*scale)

                // ---- _NormalMap (T1) : .a = smoothness, .xy = tangent-space normal (b2:92-103) ----
                float4 nrmTex = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap, uv, 0.0);
                float  smoothness = nrmTex.w;                                   // b2:93 (MRT2.x)
                // b2:95-96 remap, b2:98-99 deadzone |n|<0.012 -> 0.
                float nx = mad(nrmTex.x, 2.0, -1.0);                            // b2:95 (_231)
                float ny = mad(nrmTex.y, 2.0, -1.0);                            // b2:96 (_234)
                nx = (abs(nx) < NORMAL_DEADZONE) ? 0.0 : nx;                    // b2:98 (_244)
                ny = (abs(ny) < NORMAL_DEADZONE) ? 0.0 : ny;                    // b2:99 (_246)
                // b2:100 derive tangent-space Z: sqrt(max(1 - dot(n.xy,n.xy), 0)).
                float nz = sqrt(max((-dot(float2(nx, ny), float2(nx, ny))) + 1.0, 0.0)); // b2:100 (_265)

                // ---- TBN world normal (b2:94,101-104). N=TEXCOORD_2, T=TEXCOORD_3.xyz, B=sign*cross(N,T) ----
                // b2:101-103 use the RAW interpolated geometric normal (TEXCOORD_2) in the TBN combine
                // (no re-normalize before the blend); the single guarded rsqrt below (b2:104) handles unit length.
                float3 N = input.normalWS;                                     // b2 TEXCOORD_2 (raw, per-vertex-unit)
                float4 T = input.tangentWS;                                     // b2 TEXCOORD_3 (.xyz, .w sign)
                float  bitSign = (T.w > 0.0) ? 1.0 : -1.0;                      // b2:94 (_194 = asfloat(...1.0:-1.0))
                float3 B = bitSign * cross(N, T.xyz);                           // b2:101-103 (_194 * (N×T) ) per-component
                float3 tbn = nz * N + nx * T.xyz + ny * B;                      // b2:101-103 (_272,_273,_274)
                // b2:104 normalize with FLT_MIN rsqrt-guard (NOT bare normalize): rsqrt(max(dot,FLT_MIN)).
                float3 normalWS = tbn * rsqrt(max(dot(tbn, tbn), FLT_MIN_GUARD)); // b2:104 (_280..283)

                // ============================================================
                // Lighting resolve via URP (substitutes HG deferred GBuffer + deferred shading).
                // The HLOD impostor surface = albedo + smoothness + worldNormal + emission; metallic = 0.
                // ============================================================
                float3 positionWS = input.positionWS;
                float3 viewDirWS   = GetWorldSpaceNormalizeViewDir(positionWS);

                SurfaceData surfaceData = (SurfaceData)0;
                surfaceData.albedo     = albedo;
                surfaceData.metallic   = 0.0;
                surfaceData.specular    = 0.0;
                surfaceData.smoothness  = smoothness;
                surfaceData.occlusion   = 1.0;
                surfaceData.emission    = emission;
                surfaceData.alpha       = 1.0;       // opaque (SV_Target.w / MRT material-id is not a color alpha)
                surfaceData.normalTS    = float3(0, 0, 1);

                InputData inputData = (InputData)0;
                inputData.positionWS      = positionWS;
                inputData.normalWS        = normalWS;
                inputData.viewDirectionWS = viewDirWS;
                inputData.shadowCoord     = TransformWorldToShadowCoord(positionWS);
                inputData.fogCoord        = input.fogFactor;
                inputData.bakedGI         = SampleSH(normalWS);                 // CORE_MATH §2.4: IV-cascade GI -> SampleSH
                inputData.normalizedScreenSpaceUV = GetNormalizedScreenSpaceUV(input.positionCS);
                inputData.shadowMask      = unity_ProbesOcclusion;

                #if defined(_SCREEN_SPACE_OCCLUSION)
                    AmbientOcclusionFactor aoFactor = GetScreenSpaceAmbientOcclusion(inputData.normalizedScreenSpaceUV);
                    surfaceData.occlusion = min(surfaceData.occlusion, aoFactor.indirectAmbientOcclusion);
                #endif

                half4 color = UniversalFragmentPBR(inputData, surfaceData);
                color.rgb = MixFog(color.rgb, input.fogFactor);
                return color;
            }
            ENDHLSL
        }

        // ============================================================
        // Pass: ShadowCaster  (HG LIGHTMODE "SHADOWCASTER" -> URP ShadowCaster)
        //   Source render-state (lithlod.shader:77-84): Cull [_ShadowCullMode], Offset [_ShadowBias], 0.
        //   Base blobs: Vertex b6 (inline in skeleton: object->world then mul(_ShadowpassVP) -> shadow clip,
        //   CORE_MATH §4.1), Fragment b7 (EMPTY, depth-only, no clip in base).
        // ============================================================
        Pass
        {
            Name "ShadowCaster"
            Tags { "LightMode" = "ShadowCaster" }

            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_ShadowCullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vertShadow
            #pragma fragment fragShadow
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW

            // CORE_MATH §4.1: HG bakes depth bias into _ShadowpassVP; URP ApplyShadowBias is the faithful substitute.
            float3 _LightDirection;
            float3 _LightPosition;

            struct AttributesShadow
            {
                float4 positionOS : POSITION;
                float3 normalOS   : NORMAL;
            };

            struct VaryingsShadow
            {
                float4 positionCS : SV_POSITION;
            };

            float4 GetShadowPositionHClip(AttributesShadow input)
            {
                float3 positionWS = TransformObjectToWorld(input.positionOS.xyz);  // b6: object->world (skinning dropped)
                float3 normalWS   = TransformObjectToWorldNormal(input.normalOS);

                #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                    float3 lightDirectionWS = normalize(_LightPosition - positionWS);
                #else
                    float3 lightDirectionWS = _LightDirection;
                #endif

                float4 positionCS = TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDirectionWS)); // b6: mul(_ShadowpassVP,...)
                #if UNITY_REVERSED_Z
                    positionCS.z = min(positionCS.z, UNITY_NEAR_CLIP_VALUE);
                #else
                    positionCS.z = max(positionCS.z, UNITY_NEAR_CLIP_VALUE);
                #endif
                return positionCS;
            }

            VaryingsShadow vertShadow(AttributesShadow input)
            {
                VaryingsShadow output = (VaryingsShadow)0;
                output.positionCS = GetShadowPositionHClip(input);
                return output;
            }

            half4 fragShadow(VaryingsShadow input) : SV_Target
            {
                return 0;   // Fragment b7: EMPTY -> pure depth (no alpha-clip in base, CORE_MATH §4.2)
            }
            ENDHLSL
        }

        // ============================================================
        // Pass: DepthOnly  (HG LIGHTMODE "DepthOnly" -> URP DepthOnly)
        //   Source render-state (lithlod.shader:255-262): ZClip On, Cull [_CullMode].
        //   Base blobs: Vertex b10 (object->world->camera-clip, same as b1 sans normal/tangent;
        //   CORE_MATH §4.3), Fragment b11 (EMPTY, writes 0, no clip).
        //   _DITHER delta (Fragment b13): LOD-crossfade interleaved-gradient discard -> runtime ToggleUI.
        // ============================================================
        Pass
        {
            Name "DepthOnly"
            Tags { "LightMode" = "DepthOnly" }

            ZWrite On
            ColorMask R
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vertDepth
            #pragma fragment fragDepth

            struct AttributesDepth
            {
                float4 positionOS : POSITION;
            };

            struct VaryingsDepth
            {
                float4 positionCS : SV_POSITION;
            };

            VaryingsDepth vertDepth(AttributesDepth input)
            {
                VaryingsDepth output = (VaryingsDepth)0;
                // b10:84-113 object->world->camera-clip (skinning/instancing dropped, y-flip hack dropped).
                output.positionCS = TransformObjectToHClip(input.positionOS.xyz);
                return output;
            }

            half4 fragDepth(VaryingsDepth input) : SV_Target
            {
                // Base Fragment b11:10-12 writes nothing (pure depth). _DITHER delta (b13:66-73):
                // discard when the LOD-crossfade interleaved-gradient test < 0 ; gated here by _EnableDither.
                if (_EnableDither > 0.5)
                {
                    float ign = InterleavedGradientNoise(input.positionCS.xy);   // b13:69 (_41)
                    // b13:71 : discard if  min( 1 - max(LODFade.z, LODFade.y) - ign,
                    //                           LODFade.x - ((LODFade.x>=0)? ign : -ign) )  < 0.
                    float fadeZY    = max(unity_LODFade.z, unity_LODFade.y);
                    float signedIgn = (unity_LODFade.x >= 0.0) ? ign : -ign;
                    float t = min(((-fadeZY) + (-ign)) + 1.0, (-signedIgn) + unity_LODFade.x);
                    clip(t);
                }
                return 0;
            }
            ENDHLSL
        }
    }

    FallBack "Hidden/Universal Render Pipeline/FallbackError"
}
