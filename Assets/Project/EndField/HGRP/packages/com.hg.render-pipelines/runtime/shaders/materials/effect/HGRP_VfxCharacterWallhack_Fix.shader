// HGRP VFXCharacterWallhack — occluded-silhouette "wallhack / X-ray" effect — ForwardOnly pass.
// Draws the character's flat unlit color ONLY where it is hidden behind opaque geometry:
//   ZTest Greater + ZWrite Off  -> fragment passes only when BEHIND already-drawn depth.
//   Stencil Ref 8 ReadMask 8 Comp Equal -> only on pixels the character marked in the stencil bit.
//   Cull Off, alpha blend over the scene -> see-through-walls overlay.
// The blob colors the silhouette with _BaseMap*_BaseColor (premultiplied by alpha) then applies
// HGRP scene fog; here that fog is URP MixFog. (source = vfxcharacterwallhack/Sub0_Pass0_Fragment_b5.hlsl:92-172)
//
// Merged from: Sub0_Pass0_*_b4/b5 (base = catch-all #else, kw HG_ENABLE_MV),
//   b6/b7 (_TRANSPARENT_MAT — fragment math IDENTICAL to base; only swaps render-state blend),
//   b12/b13 (DITHER — adds LOD-crossfade dither discard at frag top).
// Keywords: _ALPHATEST_ON, LOD_FADE_CROSSFADE
// Kept: unlit silhouette tint (_BaseMap*_BaseColor*alpha), alpha-premultiplied output,
//   scene fog applied to the silhouette, optional alpha-test clip, optional LOD-crossfade dither,
//   the wallhack render-state (ZTest Greater / Stencil Ref8 Equal / Cull Off / blend).
// Removed (pixel-neutral pipeline infra substituted by URP, or sandbox-irrelevant):
//   GPU skinning (T0 ByteAddressBuffer + BLENDWEIGHTS/BLENDINDICES; URP skinning is automatic),
//   motion vectors / SV_Target1 + HG_ENABLE_MV + prev-frame matrices + TAA jitter (separate URP MV pass),
//   the hand-rolled depth->worldDir reconstruction (only fed HGRP fog; URP MixFog uses clip-z),
//   HGRP AtmosphereFog/ExponentialFog/VolumetricFog froxel sampling + LCG dither (-> URP MixFog),
//   _DitherScale property's froxel use, exposure global.
//
// NOTE: the silhouette color is _BaseColor (HDR, [Gamma]) * _BaseMap, NOT a lit surface — there is
//   no normal/light/BRDF anywhere in the blob. Output is alpha-premultiplied RGB (blob:164-166).
Shader "HGRP/VfxCharacterWallhack_Fix" {
    Properties {
        [HDR] [Gamma] _BaseColor ("Unlit Color", Color) = (1, 1, 1, 1)
        _BaseMap ("Unlit Color Map", 2D) = "white" {}

        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Alpha Test", Float) = 0
        _AlphaClipThreshold ("Clip Threshold", Range(0, 1)) = 0.5

        // Wallhack stencil bit (HGRP source: Ref 8, ReadMask 8, Comp Equal — see-through-walls gate).
        [HideInInspector] _StencilRef      ("__stencilRef", Float) = 8
        [HideInInspector] _StencilReadMask ("__stencilReadMask", Float) = 8

        // Blend/state plumbing (driven by a material editor / OnValidate, as in the HGRP source).
        // Source ForwardOnly defaults: Blend SrcAlpha OneMinusSrcAlpha, ZTest Greater, ZWrite Off, Cull Off.
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 0
        [HideInInspector] _SrcBlend ("__src", Float) = 5   // SrcAlpha
        [HideInInspector] _DstBlend ("__dst", Float) = 10  // OneMinusSrcAlpha
        [HideInInspector] _ZWrite   ("__zw",  Float) = 0
        [HideInInspector] _SurfaceType ("__surfaceType", Float) = 1
    }
    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _BaseColor;
                float4 _BaseMap_ST;
                float  _AlphaClipThreshold;
                float  _StencilRef;
                float  _StencilReadMask;
                float  _CullMode;
                float  _SrcBlend;
                float  _DstBlend;
                float  _ZWrite;
                float  _SurfaceType;
            CBUFFER_END

            TEXTURE2D(_BaseMap);    SAMPLER(sampler_BaseMap);
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }

            // Wallhack render-state — the load-bearing identity of this effect.
            // (source vfxcharacterwallhack.shader:31-44)
            Blend [_SrcBlend] [_DstBlend]
            ZTest Greater       // pass ONLY where occluded by already-drawn opaque depth
            ZWrite [_ZWrite]    // 0 — never write depth
            Cull [_CullMode]    // source: Cull Off (both faces of the hidden silhouette)
            Stencil {
                Ref      [_StencilRef]        // 8
                ReadMask [_StencilReadMask]   // 8
                Comp Equal
                Pass Keep
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            // _ALPHATEST_ON drives the optional clip; LOD_FADE_CROSSFADE maps the source DITHER keyword
            // (b13 LOD-fade dither discard, blob Fragment_b13.hlsl:100-102).
            #pragma shader_feature_local _ALPHATEST_ON
            #pragma multi_compile_fragment _ LOD_FADE_CROSSFADE

            // URP fog keywords so MixFog resolves the scene fog the HGRP blob baked inline.
            #pragma multi_compile_fog

            // LODFadeCrossFade lives in URP's LODCrossFade.hlsl (NOT Core.hlsl); include it,
            // guarded by the keyword, exactly as URP's own PBRForwardPass does.
            #if defined(LOD_FADE_CROSSFADE)
                #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/LODCrossFade.hlsl"
            #endif

            struct Attributes {
                float3 positionOS : POSITION;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
                float  fogFactor  : TEXCOORD1;
            };

            Varyings vert(Attributes v)
            {
                Varyings o;
                // GPU skinning is automatic in URP; the blob's manual blend-weight skin
                // (Vertex_b4.hlsl:61-264) collapses to the standard object->clip path.
                VertexPositionInputs posInputs = GetVertexPositionInputs(v.positionOS);
                o.positionCS = posInputs.positionCS;
                o.uv = TRANSFORM_TEX(v.uv, _BaseMap);
                o.fogFactor = ComputeFogFactor(posInputs.positionCS.z);
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                // --- DITHER (source DITHER keyword, blob Fragment_b13.hlsl:100-102) ---
                // HGRP spelled an inline LOD-fade hashed-dither discard; URP provides the identical
                // screen-door discard via LODFadeCrossFade under LOD_FADE_CROSSFADE.
                #ifdef LOD_FADE_CROSSFADE
                    LODFadeCrossFade(input.positionCS);
                #endif

                // --- Silhouette color (blob Fragment_b5.hlsl:92-93, 164-166, 170) ---
                // _180 = SampleBias(_BaseMap, uv, _GlobalMipBias) (blob:92). _GlobalMipBias is an HGRP
                // global with no URP equivalent -> SAMPLE_TEXTURE2D_BIAS with 0 bias (sibling convention).
                half4 baseSample = SAMPLE_TEXTURE2D_BIAS(_BaseMap, sampler_BaseMap, input.uv, 0.0);
                // _196 = baseSample.a * _BaseColor.a   (blob:93)
                half alpha = baseSample.a * _BaseColor.a;

                #ifdef _ALPHATEST_ON
                    clip(alpha - _AlphaClipThreshold);
                #endif

                // SV_Target.rgb = (_196 * (baseSample.rgb * _BaseColor.rgb)) ...  (blob:164-166)
                // i.e. tinted silhouette, premultiplied by alpha. The blob's trailing fog terms
                // (_780*_277 transmittance + _777 inscatter) are the HGRP scene fog -> URP MixFog.
                half3 color = alpha * (baseSample.rgb * _BaseColor.rgb);
                // SCENE FOG = HGRP-global INFRA -> URP MixFog (STYLE_BIBLE §2 + canonical Removed: "fog";
                //   matches in-family siblings HGRP_VfxCharacterOutline_Fix:227-228 (MixFog) and
                //   HGRP_VfxCharacterGrowing_Fix:22-24 / HGRP_CharacterNPR_VFX_Fix (drop)).
                //   The blob's trailing fog (Fragment_b5.hlsl:98-166) is HGRP scene fog composited onto
                //   the silhouette: transmittance _277/_278/_279 (atmosphere, b5:100-102) * density _780
                //   + exponential-height inscatter _777/_778/_779 (b5:128-160) + an atmosphere in-scatter
                //   term (b5:162-166). Its drivers are the HGRP `type_ShaderVariablesGlobal` cbuffer block
                //   (_AtmosphereFogParams0..5 / _ExponentialFogParams0..5 / _VolumetricFogParams0..4,
                //   b5:23-39) — render-pipeline globals with NO URP analog and NO material source; URP's
                //   MixFog (height/linear/exp fog driven by URP's own fog globals) is the sanctioned infra
                //   substitute. The fog CURVE is not bit-reproduced because that would require re-exposing
                //   ~16 system float4s nothing in the URP sandbox would populate per-scene.
                // ENGINE-SIDE (the froxel branch only, b5:109-144): the `if (_VolumetricFogParams0.z > 0)`
                //   path samples a Texture3D scattering LUT `T1` (b5:133 T1.SampleLevel) produced by HGRP's
                //   VOLUMETRIC-FOG FROXEL INJECTION compute pass (HGRenderPipeline VBuffer / Vol-fog system).
                //   That 3D LUT is filled by a separate custom render pass, not by this material, so it
                //   cannot be reproduced inside the shader — it requires a host froxel-fog render feature.
                color = MixFog(color, input.fogFactor);

                // SV_Target.w = _196 (blob:170). Output is already alpha-premultiplied RGB.
                return half4(color, alpha);
            }
            ENDHLSL
        }
    }
}
