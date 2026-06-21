// HGRP CharacterNPR ShadowReceiver — clean URP port (single multiply-blend "ShadowReceiver" pass).
// A ground projector quad placed under a character: it samples the directional (and, in HGRP, the
// per-character) shadow term at its world position, fades it in a circle around the character's feet,
// folds in a screen-space "capsule AO" SH term, and MULTIPLIES the framebuffer by the resulting
// shadow tint (Blend Zero SrcColor). It writes no lighting of its own — it only darkens the ground.
//
// Merged from: characternpr_shadowreceiver.shader
//   Vertex  base (#else catch-all): characternpr_shadowreceiver/Sub0_Pass0_Vertex_b2.hlsl   (skeleton line 49->52)
//   Fragment base (#else catch-all): characternpr_shadowreceiver/Sub0_Pass0_Fragment_b3.hlsl (skeleton line 63->66)
//   (SRP_INSTANCING_ON delta vertex b4 / fragment b5 are identical math + instancing array — dropped.)
// Keywords: _CIRCLE_FADE (was [ToggleUI] _CircleFade, promoted to a static branch), _CAPSULE_AO.
// Kept: directional shadow receive (Disable toggle), per-character self-shadow receive (Disable toggle),
//   the shadow-tint clip-bias (saturate(0.95 - minShadow) * _ShadowColor.a), circle radial fade
//   (smoothstep t*t*(3-2t) over [_dist-_smooth, _dist]), capsule-AO SH evaluation math, final
//   per-channel multiply tint = lerp( lerp(1,_ShadowColor.rgb,mask), _CapsuleAoColor.rgb, capsuleAO ).
// Removed: SRP instancing (SRP_INSTANCING_ON), TAA clip-space jitter (_TaaJitterStrength),
//   HGRP CSM/ASM/cloud-shadow atlas sampling (replaced by URP MainLightRealtimeShadow),
//   HGRP per-character shadow atlas (no URP analog — see NOTE/TODO), HGRP screen-space capsule-AO
//   SH prepass buffer + FHat/AB LUTs (no URP analog — gated under _CAPSULE_AO, neutral-off by default).
//
// NOTE: HGRP has TWO independent shadow sources here — the main directional CSM (gates the "scene shadow"
//   toggle) and a dedicated per-character shadow atlas (gates the "character self shadow" toggle). URP has
//   ONE realtime main-light shadow map, so both terms are driven from MainLightRealtimeShadow; the two
//   Disable toggles still operate independently on it. A true separate character-shadow atlas has no URP
//   equivalent (see TODO in computeShadowReceiver).
// NOTE: The capsule-AO path samples a full-screen SH buffer (_CapsuleAOBuffer) + a 1D FHat LUT
//   (_CapsuleAOFHatLUT) written by an HGRP prepass that URP does not produce; with _CAPSULE_AO off the
//   term resolves to 0 (no contribution), which equals the HGRP base behaviour when no buffer is bound.

Shader "HGRP/CharacterNPR_ShadowReceiver_Fix"
{
    Properties
    {
        _ShadowColor ("Shadow Color", Color) = (0.5, 0.5, 0.5, 1)
        [ToggleUI] _DisableCharacterSelfShadow ("Disable Character Self Shadow On Ground", Float) = 0
        [ToggleUI] _DisableSceneShadow ("Disable Main-Light Shadow On Ground", Float) = 0
        [Toggle(_CIRCLE_FADE)] _CircleFade ("Circle Fade (center the quad pivot under the feet)", Float) = 0
        _CircleFadeDistance ("Circle Fade Distance", Range(0.01, 3)) = 0.5
        _CircleFadeSmoothness ("Circle Fade Smoothness", Range(0, 3)) = 0
        _CapsuleAoColor ("Capsule AO Color", Color) = (0.25, 0.25, 0.25, 1)

        [Header(Capsule AO (HGRP screen-space SH prepass; off in URP))]
        [Toggle(_CAPSULE_AO)] _UseCapsuleAO ("Use Capsule AO (requires HGRP SH buffer)", Float) = 0
        _CapsuleAOFHatScale ("Capsule AO FHat (x=scale y=bias)", Vector) = (1, 0, 0, 0)
        _CapsuleAOABParams ("Capsule AO AB Params (x,z=L0 a/b ; y,w=L1 a/b)", Vector) = (1, 1, 0, 0)

        // Render-state plumbing (driven by a material editor; defaults = the HGRP ShadowReceiver pass state).
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 32
        [HideInInspector] _StencilReadMask ("__stencilReadMask", Float) = 32
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
            "IgnoreProjector" = "True"
        }
        LOD 300

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _ShadowColor;        // .rgb = ground shadow tint, .w = overall shadow strength (blob _328,_456-458)
                float4 _CapsuleAoColor;     // .rgb = ground color under full capsule AO (blob _460-462)
                float  _DisableCharacterSelfShadow;
                float  _DisableSceneShadow;
                float  _CircleFade;
                float  _CircleFadeDistance;
                float  _CircleFadeSmoothness;
                // Capsule AO (HGRP screen-space SH prepass params; map to _ABParams/_FHatParams in blob)
                float4 _CapsuleAOFHatScale; // .x=_FHatParams.x scale, .y=_FHatParams.y bias (blob _428)
                float4 _CapsuleAOABParams;  // .x=_ABParams.x, .y=_ABParams.y, .z=_ABParams.z, .w=_ABParams.w (blob _429,_436)
            CBUFFER_END

            // HGRP screen-space capsule-AO prepass outputs. URP does not produce these; bound only when
            // _CAPSULE_AO is enabled and an external feature writes them.
            TEXTURE2D(_CapsuleAOBuffer);     SAMPLER(sampler_CapsuleAOBuffer);   // blob T5 (per-pixel SH: .x=DC, .yzw=L1 dir)
            TEXTURE2D(_CapsuleAOFHatLUT);    SAMPLER(sampler_CapsuleAOFHatLUT);  // blob T4 (1D FHat ramp)

            // Rec.709 luma (blob _459 dot weights 0.21267290,0.71515220,0.07217500).
            static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625);
            // SH band-0 basis Y00 = 1/(2*sqrt(pi)) (blob 0.282094776630401611328125).
            static const float SH_Y00 = 0.282094776630401611328125;
            // SH band-1 evaluation weight used on the rotated L1 term (blob _448 -0.32573497295379638671875).
            static const float SH_L1_WEIGHT = -0.32573497295379638671875;
            // 2*sqrt(pi) — inverse SH_Y00, the L0 reconstruction scale (blob _436 3.5449078083038330078125).
            static const float SH_TWO_SQRT_PI = 3.5449078083038330078125;
            // exp2 argument scale for the FHat falloff (blob _430 0.4069767296314239501953125).
            static const float CAPSULE_EXP2_SCALE = 0.4069767296314239501953125;

            // ----------------------------------------------------------------------------------------
            // Capsule AO (HGRP screen-space SH occlusion). 1:1 from blob Fragment_b3 lines 408-455.
            // Reads a screen-space SH buffer (T5) at the fragment's screen UV, renormalizes the SH band
            // magnitude into the FHat-LUT (T4) domain, then runs the directional-SH rotation accumulation
            // loop and returns the occlusion factor (blob _1152): 1 - saturate(dot(max(L0row,0), Rec709)).
            // When no buffer is bound this returns 0 (no occlusion), matching the HGRP empty-buffer path.
            float computeCapsuleAO(float2 screenUV)
            {
            #ifdef _CAPSULE_AO
                float4 sh = SAMPLE_TEXTURE2D_LOD(_CapsuleAOBuffer, sampler_CapsuleAOBuffer, screenUV, 0.0); // blob _396

                // Skip when the SH buffer is effectively empty (blob _415: any |component| > 1e-4).
                float capsuleR = 0.0;   // blob _1125 (rotated L1 term)
                float capsuleD = 1.0;   // blob _1127 (L0/DC term; 1 = "no occlusion" sentinel)
                bool hasData = (abs(sh.x) > 1e-4) || (abs(sh.y) > 1e-4) || (abs(sh.z) > 1e-4) || (abs(sh.w) > 1e-4);
                if (hasData)
                {
                    // Renormalize the L1 magnitude down into the LUT's [.., 4.6] domain (blob _1020,_1117-_1124).
                    float l1Len = sqrt(dot(sh.yzw, sh.yzw));                 // blob _1020
                    float iterF = 0.0;                                      // blob _1117 (loop count, drives the rotation loop)
                    float scale = 1.0;                                      // blob _1121 (halving factor)
                    [loop] while (l1Len > 4.599999904632568359375)         // blob _422
                    {
                        iterF += 1.0;
                        l1Len *= 0.5;
                        scale *= 0.5;
                    }

                    float3 l1 = scale * sh.yzw;                              // blob _1208-_1210
                    // FHat LUT fetch: u = (|scaledL1|*FHat.x + FHat.y)*255 + 0.5, then *1/256; v = 0.5 (blob _428).
                    float lutU = mad(mad(sqrt(dot(l1, l1)), _CapsuleAOFHatScale.x, _CapsuleAOFHatScale.y), 255.0, 0.5) * 0.00390625;
                    float4 fhat = SAMPLE_TEXTURE2D_LOD(_CapsuleAOFHatLUT, sampler_CapsuleAOFHatLUT, float2(lutU, 0.5), 0.0); // blob _1229

                    float abY = mad(fhat.y, _CapsuleAOABParams.y, _CapsuleAOABParams.w);     // blob _1242
                    float falloff = exp2((scale * sh.x) * CAPSULE_EXP2_SCALE);               // blob _1250

                    // Seed SH coeffs (blob _1459,_1461,_1253,_1254,_1255 -> L0row,L1x,L1y,L1z,iter).
                    float shL0 = falloff * (mad(fhat.x, _CapsuleAOABParams.x, _CapsuleAOABParams.z) * SH_TWO_SQRT_PI); // _1459
                    float shA  = falloff * (abY * l1.x);   // _1461
                    float shB  = falloff * (abY * l1.y);   // _1253
                    float shC  = falloff * (abY * l1.z);   // _1254

                    // Directional-SH rotation accumulation (blob _1463..loop, iterF iterations).
                    [loop] for (float i = 0.0; i < iterF; i += 1.0)
                    {
                        float w0 = shL0 * SH_Y00;
                        float wA = shA  * SH_Y00;
                        float wB = shB  * SH_Y00;
                        float wC = shC  * SH_Y00;
                        float2 pA = float2(shL0, shA);
                        float2 pB = float2(shL0, shB);
                        float2 pC = float2(shL0, shC);
                        shL0 = dot(float4(w0, wA, wB, wC), float4(shL0, shA, shB, shC));
                        shA  = dot(float2(wA, w0), pA);
                        shB  = dot(float2(wB, w0), pB);
                        shC  = dot(float2(wC, w0), pC);
                    }

                    capsuleR = shA * SH_L1_WEIGHT;   // blob _1125
                    capsuleD = shL0 * SH_Y00;        // blob _1127
                }

                // Occlusion factor (blob _1152): -min(dot(max(dot(float2(R,D),(1,1)),0).xxx, Rec709),1)+1.
                // The blob clamps ONLY the low side here (max(s,0)) and lets the post-LUM min(.,1) cap the
                // high side; saturate() would wrongly pre-clamp s to 1 and (because sum(LUM)<1) leak ~1e-5
                // where the blob yields exactly 0. Keep max(.,0) to bind 1:1 (blob Fragment_b3.hlsl:459).
                float occ = 1.0 - min(dot(max(capsuleR + capsuleD, 0.0).xxx, LUM), 1.0);
                return occ;
            #else
                return 0.0; // HGRP empty-buffer path: _1125=0,_1127=1 -> 1-min(1,1)=0 (blob _453-454,_459).
            #endif
            }

            // ----------------------------------------------------------------------------------------
            // Core ShadowReceiver tint. 1:1 from blob Fragment_b3 lines 198-463 (shadow gather collapsed
            // to URP MainLightRealtimeShadow; circle fade + capsule-AO composite preserved exactly).
            //   positionWS  = TEXCOORD  (blob _356 etc.) — world position of the projector fragment.
            //   objectOrigin = unity_ObjectToWorld translation (blob _unity_ObjectToWorld[3].xyz, _403-405).
            float4 computeShadowReceiver(float3 positionWS, float3 objectOrigin, float2 screenUV)
            {
                // --- Shadow gather ---------------------------------------------------------------
                // HGRP: _295 = main directional CSM/ASM/cloud (blob _198-398); _82 = per-character atlas
                // (blob _114-197). URP has one main-light realtime shadow; drive both terms from it.
                // ENGINE-SIDE (not closeable — host render-feature, not a material texture+math):
                //   the per-character self-shadow term _82 (blob Fragment_b3.hlsl:114-197) is a PCF tap of
                //   T1, an HGRP *character shadow ATLAS* — a comparison shadow map rendered by a dedicated
                //   HGRP per-character shadow render-pass, indexed by the per-object bitmask
                //   _unity_WorldTransformParams.z & _CharacterShadowBiases[i].w, using the 15-slot arrays
                //   _CharacterWorldToShadow[15]/_CharacterShadowBiases[15]/_CharacterShadowLightDir[15]/
                //   _CharacterShadowAtlasParams[15]/_CharacterShadowTexelSize/_CharacterShadowParams that
                //   only a host C# ScriptableRendererFeature (a "CharacterShadowAtlas" pass that rasterizes
                //   each tagged character into the atlas and binds T1 + those CBUFFER arrays) can produce.
                //   URP ships no such atlas, so it is collapsed onto MainLightRealtimeShadow.
                //   COST OF PUNT = NIL FOR THE BASE VARIANT: in this catch-all blob the term _82 is provably
                //   the constant 1.0 — the in-bounds PCF result _604 (blob:185) is never written back to the
                //   loop phi (Branch C sets _82=1.0, blob:187), and every terminating path leaves _82 at its
                //   init 1.0 (blob:118); the loop only exits when _CharacterShadowParams.z<=0. So the faithful
                //   base-variant character term is "no character shadow". Driving charShadow from the URP main
                //   shadow below is a deliberate functional enhancement over that inert base, NOT a regression.
                // TODO(1:1, engine-side): bind a CharacterShadowAtlas ScriptableRendererFeature (T1 + the
                //   _CharacterWorldToShadow[15]/_CharacterShadow* arrays) to restore the >0-slot HGRP path
                //   (blob Fragment_b3.hlsl:114-197); until then charShadow = MainLightRealtimeShadow.
                float4 shadowCoord = TransformWorldToShadowCoord(positionWS);
                Light mainLight = GetMainLight(shadowCoord);
                float sceneShadow = mainLight.shadowAttenuation; // blob _295 (main directional shadow)
                float charShadow  = sceneShadow;                 // blob _82  (character self shadow; engine-side above)

                // _DirectionalShadowParams.x is the HGRP global shadow strength; URP folds strength into
                // shadowAttenuation already, so the strength lerp here uses 1.0 (full): lerp(1,s,1) = s.
                // _313 = lerp(1, sceneShadow, strength) ; _303 = lerp(1, charShadow, strength) (blob _399-400).
                float sceneTerm = sceneShadow;
                float charTerm  = charShadow;

                // Per-toggle disable: lerp(term,1,disable) (blob _401 inner mads).
                float sceneOr1 = lerp(sceneTerm, 1.0, _DisableSceneShadow);
                float charOr1  = lerp(charTerm,  1.0, _DisableCharacterSelfShadow);

                // Shadow mask with the 0.95 clip-bias and overall strength (blob _328).
                float shadowMask = saturate(0.949999988079071044921875 - min(sceneOr1, charOr1)) * _ShadowColor.w;

                // --- Circle fade -----------------------------------------------------------------
                // Radial smoothstep around the object origin (XZ + Y), blob _340,_356-358,_372,_382.
                float fadeEnd = _CircleFadeSmoothness + _CircleFadeDistance;      // blob _340
                float3 toOrigin = positionWS - objectOrigin;                      // blob _356-358
                float radial = saturate((sqrt(dot(toOrigin, toOrigin)) - fadeEnd) // blob _372
                                        * (1.0 / (_CircleFadeDistance - fadeEnd)));
                float fadedMask = shadowMask;
            #ifdef _CIRCLE_FADE
                // smoothstep t*t*(3-2t) (blob _382: (_372*_372)*mad(_372,-2,3)).
                fadedMask = (radial * radial) * mad(radial, -2.0, 3.0) * shadowMask;
            #endif

                // --- Capsule AO occlusion --------------------------------------------------------
                float capsuleAO = computeCapsuleAO(screenUV);                     // blob _1152

                // --- Final multiply tint ---------------------------------------------------------
                // shadowTint = lerp(1, _ShadowColor.rgb, fadedMask)  (blob _1137-1139).
                float3 shadowTint = lerp(float3(1.0, 1.0, 1.0), _ShadowColor.rgb, fadedMask);
                // out = lerp(shadowTint, _CapsuleAoColor.rgb, capsuleAO)  (blob _460-462).
                float3 outRGB = lerp(shadowTint, _CapsuleAoColor.rgb, capsuleAO);
                return float4(outRGB, 1.0); // blob _463 SV_Target.w = 1 (alpha unused under Zero SrcColor).
            }
        ENDHLSL

        Pass
        {
            Name "ShadowReceiver"
            Tags { "LightMode" = "UniversalForwardOnly" }

            // Multiply the framebuffer by the shadow tint (HGRP: Blend Zero SrcColor, Zero SrcColor).
            Blend Zero SrcColor, Zero SrcColor
            ZWrite Off
            ZTest LEqual
            Cull Back
            // HGRP stencil: receive only where the character did NOT write bit 32 (Comp NotEqual, Ref 32, ReadMask 32).
            Stencil
            {
                Ref [_StencilRef]
                ReadMask [_StencilReadMask]
                Comp NotEqual
                Pass Keep
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            #pragma shader_feature_local _CIRCLE_FADE
            #pragma shader_feature_local _CAPSULE_AO

            // URP main-light shadow keywords (replaces HGRP CSM/ASM machinery, blob _198-398).
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH

            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;   // carried 1:1 with the blob (TEXCOORD_1) though unused by the lighting here.
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float3 positionWS : TEXCOORD0; // blob TEXCOORD (world position)
                float3 normalWS   : TEXCOORD1; // blob TEXCOORD_1 (world normal — carried, unread)
            };

            // Vertex: object->world (TEXCOORD), world normal (TEXCOORD_1), world->clip.
            // 1:1 from blob Vertex_b2 lines 49-84 / b4 lines 69-106 (instancing array + TAA jitter dropped;
            // URP GetVertexPositionInputs/GetVertexNormalInputs are the faithful infra substitutes).
            Varyings vert(Attributes v)
            {
                Varyings o;
                VertexPositionInputs posnIn = GetVertexPositionInputs(v.positionOS);
                VertexNormalInputs   nrmIn  = GetVertexNormalInputs(v.normalOS);
                o.positionCS = posnIn.positionCS;
                o.positionWS = posnIn.positionWS; // blob _83-85 (TEXCOORD = ObjectToWorld * POSITION)
                o.normalWS   = nrmIn.normalWS;    // blob _261-269 (normalize(inverse-transpose * NORMAL))
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                // Object world-space origin = unity_ObjectToWorld translation (blob _unity_ObjectToWorld[3].xyz).
                float3 objectOrigin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);
                // Screen UV for the capsule-AO buffer (blob _408: gl_FragCoord.xy * _ScreenSize.zw).
                float2 screenUV = input.positionCS.xy * (rcp(_ScreenParams.xy));

                float4 tint = computeShadowReceiver(input.positionWS, objectOrigin, screenUV);
                return half4(tint);
            }
            ENDHLSL
        }
    }

    Fallback Off
}
