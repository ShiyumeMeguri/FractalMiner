// HGRP CharacterNPR ProxyLOD — stylized VAT proxy-mesh character silhouette. ForwardLit + DepthOnly.
// Merged from: characternpr_proxylod.shader (base/#else variants: Vertex b2, Fragment b3, DepthOnly Vertex b10, DepthOnly Fragment b11).
// Keywords: (none kept as shader_feature) — _DITHER exposed as ToggleUI LOD-crossfade clip (DepthOnly), runtime-gated.
// Kept (1:1 math): UV.y tint gradient pow(uv.y,_TintSplit) BaseColor->TintColor lerp, view-Fresnel rim
//   (exponent = (1 - 1.5*saturate(uv.y-0.5))*_FresnelPower) with smoothstep root-fade by uv.y, per-object
//   world-origin Fresnel modulation, main-light shadow attenuation darkening (0.75 + 0.25*shadow), alpha gradient.
// Removed: GPU VAT skinning (AnimationTexture bone-matrix fetch), HG packed-octahedral NORMAL decode, TAA jitter,
//   motion vectors (SV_Target1 MV + sqrt-encoded normal), HG 3-layer atmosphere/exponential/volumetric fog
//   (-> URP MixFog), HG CSM/ASM/cloud directional-shadow atlas machinery (-> URP MainLightRealtimeShadow),
//   exposure division (_ExposureParams.x), 255*atmosphere-inscatter term.
//
// NOTE: this shader is NOT a PBR/lit surface — there is no albedo/metallic/normal map; color is a flat
//   2-color vertical gradient + a rim glow. CORE_MATH.md (lit family) does not apply here.
//
// _AnimationTexture (VAT) is a vertex-skinning input on the HG mesh path; URP feeds already-skinned
//   positionOS, so it is retained as an inert [HideInInspector] property only (no sample) — see gaps.

Shader "HGRP/CharacterNPR_ProxyLOD_Fix"
{
    Properties
    {
        _BaseColor ("Base Color", Color) = (0.33, 0.33, 0.33, 1)
        _TintColor ("Tint Color", Color) = (0.67, 0.67, 0.67, 1)
        _TintSplit ("Tint Split", Range(0.5, 2)) = 1
        _FresnelColor ("Fresnel Color", Color) = (0.5, 0.5, 0.5, 1)
        _FresnelPower ("Fresnel Power", Range(0.1, 100)) = 5
        _FresnelRootFade ("Fresnel Root Fade", Range(0, 1)) = 0.3

        [HideInInspector] _AnimationTexture ("Animation Texture (VAT, unused in URP)", 2D) = "black" {}
        [ToggleUI] _DebugVATFrameIndex ("Debug VAT Frame", Float) = 0
        _VATFrameIndex ("VAT Frame Index", Range(0, 1)) = 0

        // Surface / blend plumbing (opaque defaults)
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [Enum(Both, 0, Back, 1, Front, 2)] _Cull ("Render Face", Float) = 0

        // DepthOnly LOD-crossfade dither clip (HG _DITHER multi_compile -> runtime ToggleUI)
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
        LOD 300

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

        CBUFFER_START(UnityPerMaterial)
            // type_UnityPerMaterial (Fragment b3:68-76 / Vertex b2:29-40)
            float  _FresnelPower;        // b3 c0
            float  _FresnelRootFade;     // b3 c0.y
            float  _TintSplit;           // b3 c0.z
            float4 _BaseColor;           // b3 c1
            float4 _TintColor;           // b3 c2
            float4 _FresnelColor;        // b3 c3
            float4 _AnimationTexture_ST; // (VAT path dropped; kept for batching compat)
            float4 _AnimationTexture_TexelSize;
            float  _DebugVATFrameIndex;  // b2 c5
            float  _VATFrameIndex;       // b2 c5.y
            float  _EnableDither;
        CBUFFER_END

        TEXTURE2D(_AnimationTexture);    SAMPLER(sampler_AnimationTexture);

        // ------------------------------------------------------------
        // Interleaved-gradient noise hash (LOD-crossfade dither).
        // Fragment b13:61 / b3:184 : frac(frac(dot(p, float2(0.0671105608, 0.0058371499))) * 52.9829178)
        // ------------------------------------------------------------
        static const float2 IGN_MAGIC = float2(0.067110560834407806396484375, 0.005837149918079376220703125);
        static const float  IGN_SCALE = 52.98291778564453125;

        float InterleavedGradientNoise(float2 pixelCoord)
        {
            return frac(frac(dot(pixelCoord, IGN_MAGIC)) * IGN_SCALE);
        }
        ENDHLSL

        // ============================================================
        // Pass: ForwardLit  (HG LIGHTMODE "ForwardCharacterOnly" -> URP UniversalForwardOnly)
        //   Source render-state (proxylod.shader:19-26): ZClip On, ZTest Equal, ZWrite Off.
        //   Base blobs: Vertex b2, Fragment b3.
        // ============================================================
        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForwardOnly" }

            ZTest Equal
            ZWrite [_ZWrite]
            Cull [_Cull]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            // URP main-light shadows (replaces HG CSM/ASM/cloud atlas, Fragment b3:142-323)
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH
            #pragma multi_compile_fog

            struct Attributes
            {
                float4 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
                float3 normalWS   : TEXCOORD1;   // geometric world normal (b2: TEXCOORD_1_1)
                float3 positionWS : TEXCOORD2;   // world position         (b2: TEXCOORD_2)
                float  fogFactor  : TEXCOORD3;
            };

            Varyings vert(Attributes input)
            {
                Varyings output = (Varyings)0;

                // HG GPU-skinning (AnimationTexture bone fetch, b2:163-406) + packed-octahedral
                // NORMAL decode (b2:134-151) are mesh-import infra -> URP standard inputs.
                VertexPositionInputs posInputs = GetVertexPositionInputs(input.positionOS.xyz);
                VertexNormalInputs   nrmInputs = GetVertexNormalInputs(input.normalOS);

                output.positionCS = posInputs.positionCS;
                output.positionWS = posInputs.positionWS;     // b2:434-436 worldPos (camera-relative offset folded by URP)
                output.normalWS   = nrmInputs.normalWS;        // b2:427-433 normalize(inverse-transpose * N)
                output.uv         = input.uv;                  // b2:448-449 TEXCOORD passthrough
                output.fogFactor  = ComputeFogFactor(posInputs.positionCS.z);
                return output;
            }

            float4 frag(Varyings input) : SV_Target
            {
                float2 uv = input.uv;
                float3 positionWS = input.positionWS;
                float3 normalWS = normalize(input.normalWS);

                // --- View vector V (b3:126-140) ---
                // Vraw = camPos - P ; ortho swaps to camera forward (_ViewMatrix col2.z basis).
                // lerp(Vraw, camFwd, orthoParams.w) ; camFwd = UNITY_MATRIX_V row2 (._m20/_m21/_m22).
                float3 Vraw   = _WorldSpaceCameraPos - positionWS;                                   // b3:126-128
                float3 camFwd = float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22); // b3:129-131
                float3 Vsel   = lerp(Vraw, camFwd, unity_OrthoParams.w);                             // b3:132-134
                float  distSq = dot(Vsel, Vsel);                                                     // b3:135
                float  invLen = rsqrt(max(distSq, 9.9999999392252902907785028219223e-09)); // 1e-8  // b3:136
                float3 V      = Vsel * invLen;                                                       // b3:137-139

                // --- Directional shadow attenuation (b3:142-329) ---
                // HG CSM + ASM + cloud-shadow atlas -> URP main-light realtime shadow.
                // _213 = mad(_DirectionalShadowParams.x, min(_205,1)-1, 1) = lerp(1, _205, strength).
                //   (_205 composite = b3:141-328 ; _213 strength-fold = b3:329)
                Light mainLight = GetMainLight(TransformWorldToShadowCoord(positionWS));
                float shadow = mainLight.shadowAttenuation;                                          // <- substitutes _205/_213 (b3:329)

                // --- Tint gradient by UV.y (temp _221, b3:330) : pow(uv.y, _TintSplit) ---
                float tintT = exp2(log2(uv.y) * _TintSplit);                                         // b3:330 (_221)
                float3 gradColor = lerp(_BaseColor.rgb, _TintColor.rgb, tintT);                      // b3:399-401 mad-form (lerp(BaseRGB,TintRGB,tintT))

                // --- Fresnel rim (temps _256 b3:331, _1293 b3:393, _1298 b3:394) ---
                float vy        = saturate(uv.y - 0.5);                                              // b3:331  (_256)
                float fresExp   = mad(vy, 0.5, mad(-vy, 2.0, 1.0)) * _FresnelPower; // (1 - 1.5*vy)*pow  b3:394
                float rootFade  = saturate((uv.y - _FresnelRootFade) * 4.0);                         // b3:393  (_1293)
                float rootSmooth = (rootFade * rootFade) * mad(rootFade, -2.0, 3.0); // smoothstep    b3:394
                float NdotV     = saturate(dot(V, normalWS));                                        // b3:394 dot(_134..136, TEXCOORD_1)
                float rim       = exp2(log2(1.0 - NdotV) * fresExp) * rootSmooth; // pow(1-NdotV,exp) b3:394  (_1298)

                // --- Per-object world-origin Fresnel modulation (b3:395-401) ---
                // _1310 = max(1, objToWorld._m33) ; perObj = 1 + shadow*(objOrigin.xyz*_1310 - 1).
                float  objW       = max(1.0, UNITY_MATRIX_M._m33);                                   // b3:395  _1310
                float3 objOrigin  = float3(UNITY_MATRIX_M._m03, UNITY_MATRIX_M._m13, UNITY_MATRIX_M._m23);
                float3 perObj     = mad(shadow, mad(objOrigin, objW, -1.0.xxx), 1.0.xxx);            // b3:399-401

                // --- Composite (b3:396,399-401) : shade = (0.75 + 0.25*shadow) * (rim*FresnelColor*perObj + gradient) ---
                float  shadeScale = mad(shadow, 0.25, 0.75);                                         // b3:396  _1325
                float3 color = shadeScale * mad(rim * _FresnelColor.rgb, perObj, gradColor);

                // NOTE(infra): source divides by _ExposureParams.x (HG exposure, b3:399) — URP color is
                // pre-exposure linear, so the division is dropped (faithful infra substitution).

                // --- Alpha gradient (b3:409) ---
                float alpha = mad(tintT, (-_BaseColor.w) + _TintColor.w, _BaseColor.w); // lerp(BaseA,TintA,tintT)

                // --- Fog (b3:332-401) -> URP MixFog (STYLE_BIBLE §2 sanctioned infra substitution) ---
                // The analytic ATMOSPHERE-transmittance (b3:332-336: exp2(height-integral * _AtmosphereFogParams2.xyz/ln2),
                //   the per-channel _315/_316/_317) and EXPONENTIAL-HEIGHT fog (b3:376-392 no-volumetric branch:
                //   analytic exp2 height integral _920 density + _1259/_1260/_1261 inscatter) are pure distance/height
                //   fog whose ONLY inputs are HG per-frame pipeline globals _AtmosphereFogParams0..5 / _ExponentialFogParams0..5
                //   (blob cbuffer type_ShaderVariablesGlobal b3:23-34). These are NOT material properties and URP exposes
                //   no equivalent global; their faithful URP facility is the vert->frag fogFactor + MixFog path (same call
                //   the canonical HGRP_CharacterNPR_Fix.shader makes). Re-declaring those 12 unbound globals would read as
                //   garbage under URP (§B: INFRA -> URP facilities, not raw register transcription), so MixFog IS the 1:1 map.
                color = MixFog(color, input.fogFactor);
                // TODO(engine-side): two terms have no URP forward-path equivalent and require host systems to reproduce:
                //   (1) VOLUMETRIC froxel inscatter (b3:343-374, gated by _VolumetricFogParams0.z): samples T3 =
                //       Texture3D froxel volume injected by HG's separate volumetric-fog compute pass (_730 sample,
                //       _755=mad(_747,_730.w-1,1) transmittance, mad(_747,_730.xyz,..) inscatter). Froxel-injection
                //       volume = the legitimate engine-side punt; needs a C# ScriptableRenderFeature volumetric-fog
                //       compute pass binding a 3D froxel texture before this shader runs.
                //   (2) 255*atmosphere-inscatter MRT term (b3:399-401 last mad: clamp(mad(_AtmosphereFogParams4,_1371,
                //       mad(_AtmosphereFogParams3,_1342,_AtmosphereFogParams5)))*255*(1-_315), where _1342=(1+cos2θ)*3/(16π)
                //       Rayleigh, _1371=(1-g²)/(4π·d·√d) Henyey-Greenstein) is written into HG's deferred atmosphere/
                //       motion-vector MRT (SV_Target0+SV_Target1, b3:399-411) for a later HG fog-resolve pass; URP's
                //       single-RT UniversalForwardOnly path drops SV_Target1 (motion vectors already in header "Removed:").
                //       Needs the HG deferred-fog MRT resolve render-feature to reproduce.

                return float4(color, alpha);
            }
            ENDHLSL
        }

        // ============================================================
        // Pass: DepthOnly  (HG LIGHTMODE "DepthCharacterOnly" -> URP DepthOnly)
        //   Source render-state (proxylod.shader:66-78): ZClip On, Stencil Ref 5 Comp Always Pass Replace.
        //   Base blobs: Vertex b10 (= same skinned object->world->clip as b2), Fragment b11 (writes 0, no clip).
        //   _DITHER delta (Fragment b13): LOD-crossfade interleaved-gradient discard.
        // ============================================================
        Pass
        {
            Name "DepthOnly"
            Tags { "LightMode" = "DepthOnly" }

            ZWrite On
            ColorMask R
            Cull [_Cull]

            Stencil
            {
                Ref 5
                Comp Always
                Pass Replace
                Fail Keep
                ZFail Keep
            }

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
                // b10:407-444 skinned object->world->camera-clip -> URP TransformObjectToHClip.
                output.positionCS = TransformObjectToHClip(input.positionOS.xyz);
                return output;
            }

            half4 fragDepth(VaryingsDepth input) : SV_Target
            {
                // Base Fragment b11:18-22 writes 0 (pure depth). _DITHER delta (b13:61-62):
                // discard when min(LODdither thresholds, IGN) < 0 ; gated here by _EnableDither.
                if (_EnableDither > 0.5)
                {
                    float ign = InterleavedGradientNoise(input.positionCS.xy);                       // b13:61
                    // b13:62 : min( 1 - max(LODFade.z,LODFade.y) - ign ,
                    //               LODFade.x - ((LODFade.x>=0)? ign : -ign) ) < 0  -> discard
                    float fadeZY = max(unity_LODFade.z, unity_LODFade.y);
                    float signedIgn = (unity_LODFade.x >= 0.0) ? ign : -ign;
                    float t = min(((-fadeZY) + (-ign)) + 1.0, ((-signedIgn) + unity_LODFade.x));
                    clip(t);
                }
                return 0;
            }
            ENDHLSL
        }
    }

    FallBack "Hidden/Universal Render Pipeline/FallbackError"
}
