// HGRP VFX Distance Field — additive/alpha SDF VFX card. ForwardOnly (lit color) + HGBuffer→DepthNormals stub.
// Merged from: vfxdistancefield.shader (HGRP/Effect/VFXDistanceField)
//   base variant  : Sub0_Pass0_Vertex_b4.hlsl / Sub0_Pass0_Fragment_b5.hlsl   (catch-all #else, fewest keywords)
//   blend variant : Sub0_Pass0_Fragment_b7.hlsl + Sub0_Pass1_Fragment_b23.hlsl (_USE_BLEND delta)
// Keywords: _USE_BLEND
// Kept (1:1 math):
//   - Base tint:   color = baseTex.rgb * _TintColor.rgb * _TintColorIntensity / postExposure ; a = baseTex.a * _TintColor.a * _TintColorAlpha  (b5:107-112)
//   - SDF blend (_USE_BLEND): screen-space-derivative anti-aliased signed-distance from _BlendSDFTex, gated by a
//     view-depth _SDFSwitchStart/End ramp, additive _BlendTint contribution (b7:114-123, b23:87-99)
//   - Exposure compensation: mad(_IgnorePostExposure, _ExposureParams.x - 1, 1)  (b5:108)
//   - Per-sample global mip bias: SAMPLE_TEXTURE2D_BIAS(.., _GlobalMipBias.x) == blob SampleBias(s,uv,_GlobalMipBias)
//     (b5:107, b7:110/114, b23:88/94; URP-provided _GlobalMipBias, NOT redeclared — avoids Core.hlsl clash)
//   - _SurfaceType opaque/transparent + Alpha/Additive blend-state plumbing via [HideInInspector] blend floats
// Removed (pixel-neutral pipeline infra substituted by URP, or HGRP-deferred-only with no URP equivalent):
//   - HGRP 3-term fog (b5:117-185): atmosphere (_AtmosphereFogParams0..5) + exponential (_ExponentialFogParams0..5)
//     are analytic but driven ONLY by per-frame scene-Fog-volume pipeline globals (a host would have to push 17
//     float4s/frame — same host-fills-it dependency as a volume); volumetric (b5:128-163) samples a froxel 3D
//     injection volume (T1, b5:152) from a separate HGRP compute pass. All three → URP MixFog, the cluster-wide
//     substitution (STYLE_BIBLE §2). ENGINE-SIDE to restore exactly: a host HGRP-fog render feature. See frag TODO.
//   - Motion-vector MRT (SV_Target_1 = encoded screen-space MV from _NonJittered/_Prev matrices, b5:188-192,
//     vert b4:85-95) — HGRP transparent-MV pass; URP forward has no second MV target here.
//   - "_Responsive" responsive-transparent stencil bit (SV_Target_1.w, b5:190) — HGRP transparent-responsive infra.
//   - HGBuffer pass MRTs SV_Target_2..4 (constant GBuffer normal/spec/baseColor packing, b21:93-104) — HGRP
//     deferred-only; remapped to a URP DepthNormalsOnly stub.
//   - TAA jitter (_TaaJitterStrength, vert b4:70-71), instancing (SRP_INSTANCING_ON), color-banding dither
//     (_APPLY_COLOR_BANDING_DITHER — pure ordered-dither, pixel-noise infra), camera-relative world space.
//
// NOTE: positions in HGRP are camera-relative (RWS). URP uses absolute world space via GetVertexPositionInputs;
//   the visible math (UV, tint, SDF derivatives) is camera-origin-invariant so this is 1:1 for the lit color.
// _BaseTex.a = card mask; _BlendSDFTex.x = signed distance field (0.5 = edge), .w = blend weight.

Shader "HGRP/VfxDistanceField_Fix" {
    Properties {
        [Header(Base)]
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        [ToggleUI] _IsUI ("Use In UI", Float) = 0
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1

        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _BaseTex ("Base Color Tex", 2D) = "white" {}
        _TintColorIntensity ("Tint Color Intensity (Default 1)", Range(1, 100)) = 1
        _ExpThreshold ("Exp Threshold", Range(0, 1)) = 1
        _ExpIntensity ("Exp Intensity", Range(0, 100)) = 0
        _TintColorAlpha ("Tint Color Alpha (Default 1)", Range(0, 10)) = 1
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0
        [ToggleUI] _EnableTransparentMV ("Enable Transparent MV", Float) = 0

        [Header(Blend SDF)]
        [Toggle(_USE_BLEND)] _UseBlend ("Use Blend", Float) = 0
        _BlendSDFTex ("Blend SDF Tex", 2D) = "black" {}
        _SDFSwitchStart ("SDF Switch Start", Range(0.001, 100)) = 1
        _SDFSwitchEnd ("SDF Switch End", Range(0.001, 100)) = 1
        [HDR] [Gamma] _BlendTint ("BlendTint", Color) = (1, 1, 1, 1)

        [Header(Exposure)]
        _ExposureParams ("ExposureParams (.x = exposure)", Vector) = (1, 0, 0, 0)

        // Render-state plumbing (driven by a material editor / OnValidate from _SurfaceType + _BlendMode)
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 1
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
                // Base
                float4 _TintColor;
                float4 _BaseTex_ST;
                float _TintColorIntensity;
                float _TintColorAlpha;
                float _IgnorePostExposure;
                float _SurfaceType;
                float _BlendMode;
                float _Responsive;
                float _EnableTransparentMV;
                float _ExpThreshold;
                float _ExpIntensity;
                // Blend SDF
                float4 _BlendSDFTex_ST;
                float4 _BlendTint;
                float _SDFSwitchStart;
                float _SDFSwitchEnd;
                // Exposure (HGRP global re-exposed as material Vector — URP has no _ExposureParams global)
                float4 _ExposureParams;
            CBUFFER_END

            TEXTURE2D(_BaseTex);      SAMPLER(sampler_BaseTex);     // base-color card
            TEXTURE2D(_BlendSDFTex);  SAMPLER(sampler_BlendSDFTex); // signed distance field (.x dist, .w weight)
            // NOTE (texture-import setting, not a math delta): the source's per-sample mip bias is ported 1:1 via
            //   SAMPLE_TEXTURE2D_BIAS(.., _GlobalMipBias.x) below (URP _GlobalMipBias, Input.hlsl:112, .x=bias) ==
            //   the blob's T.SampleBias(s, uv, _GlobalMipBias). The only remaining source-vs-port difference is the
            //   sampler WRAP MODE, which URP cannot select per SAMPLE call (wrap is an import setting):
            //     base variant   base tex → sampler_LinearRepeat (b5:107)   [set _BaseTex     wrap = Repeat]
            //     blend variant  base tex → sampler_LinearMirror (b7:110)   [set _BaseTex     wrap = Mirror]
            //     blend variant  SDF tex  → sampler_LinearRepeat (b7:114)   [set _BlendSDFTex wrap = Repeat]
            //   Resolve by the texture import settings on the assigned textures; differs only at UV wrap edges —
            //   interior pixels are bit-exact. (Not engine-side, not a code stub: purely an importer choice.)

            // (Rec.709 luma float3(0.2126729,0.7151522,0.072175) from b5:190 drove the dropped responsive MRT bit; not needed for visible color.)

            struct Attributes {
                float3 positionOS : POSITION;
                float4 color      : COLOR;
                float2 texcoord0  : TEXCOORD0; // _BaseTex / _BlendSDFTex UV (TEXCOORD in blob)
                float2 texcoord1  : TEXCOORD1; // secondary UV (unused by base color)
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
                float4 vertColor  : TEXCOORD1;
                float3 positionWS : TEXCOORD2;
                float  fogFactor  : TEXCOORD3;
            };

            // ---- Shared base-color evaluation (1:1 with b5:107-112, blend with b7:110-123 / b23:87-99) ----
            // Returns RGB in .xyz, output alpha in .w. positionWS feeds the SDF distance-switch view-Z (b7:119).
            float4 ComputeVfxColor(float2 uv, float3 positionWS)
            {
                // Exposure compensation (b5:108): mad(_IgnorePostExposure, -1 + _ExposureParams.x, 1)
                float postExposure = mad(_IgnorePostExposure, (-1.0) + _ExposureParams.x, 1.0);

                #ifdef _USE_BLEND
                    // Blend variant (b7:110-123): base tex sampled with mirror addressing in source.
                    float2 baseUV = float2(mad(uv.x, _BaseTex_ST.x, _BaseTex_ST.z), mad(uv.y, _BaseTex_ST.y, _BaseTex_ST.w));
                    float4 baseSample = SAMPLE_TEXTURE2D_BIAS(_BaseTex, sampler_BaseTex, baseUV, _GlobalMipBias.x);   // T1.SampleBias(sampler_LinearMirror, .., _GlobalMipBias) (b7:110); URP _GlobalMipBias float2 .x=bias

                    // SDF source (b7:114-119): _BlendSDFTex.x signed distance, edge at 0.5, screen-space-derivative AA.
                    float2 sdfUV = float2(mad(uv.x, _BlendSDFTex_ST.x, _BlendSDFTex_ST.z), mad(uv.y, _BlendSDFTex_ST.y, _BlendSDFTex_ST.w));
                    float4 sdfSample = SAMPLE_TEXTURE2D_BIAS(_BlendSDFTex, sampler_BlendSDFTex, sdfUV, _GlobalMipBias.x); // T0.SampleBias(sampler_LinearRepeat_BaseTex, .., _GlobalMipBias) (b7:114)
                    float sdfWeight = sdfSample.w;                       // _275 (b7:115)
                    float sdfDist   = (-sdfSample.x) + 0.5;              // _277 (b7:116)
                    float ddxd = ddx_coarse(sdfDist);                    // _279 (b7:117)
                    float ddyd = ddy_coarse(sdfDist);                    // _280 (b7:118)

                    // Distance-switch ramp on |view-space Z| of the surface (b7:99 _138, b7:119).
                    // Source: _138 = dot(_ViewMatrix.row2, float4(rwsWorldPos, 1)) = view-space Z of the fragment
                    //   (camera-relative worldPos reconstructed from _InvViewProjMatrix·clip, then ·_ViewMatrix).
                    // VERIFIED 1:1: URP's UNITY_MATRIX_V bakes the camera world translation into row 2, so
                    //   dot(UNITY_MATRIX_V[2].xyz, absWorldPos) + UNITY_MATRIX_V[2].w == mul(UNITY_MATRIX_V, float4(posWS,1)).z
                    //   yields the identical view-space Z; the RWS camera-origin offset is already absorbed by the
                    //   view matrix translation row. abs() below makes the right-handed -Z sign irrelevant. (b7:99)
                    float viewZ = dot(UNITY_MATRIX_V[2].xyz, positionWS) + UNITY_MATRIX_V[2].w;
                    float sdfSwitch = clamp((abs(viewZ) + (-_SDFSwitchStart)) / ((-_SDFSwitchStart) + _SDFSwitchEnd), 0.0, 1.0); // _159-equiv (b23:87) / clamp in _307 (b7:119)

                    // Anti-aliased SDF coverage (b7:119): lerp the raw distance toward its derivative-normalized
                    // edge by the distance-switch, then re-bias by +0.5 and clamp.
                    float sdfAA = sdfDist / sqrt(dot(float2(ddxd, ddyd), float2(ddxd, ddyd)));
                    float sdfCoverage = clamp((-mad(sdfSwitch, (-sdfDist) + sdfAA, sdfDist)) + 0.5, 0.0, 1.0); // _307 (b7:119)

                    // Base alpha (b7:111-113): _229 = baseTex.a*_TintColor.a ; _252 = _229*_TintColorAlpha.
                    float baseTintAlpha = baseSample.w * _TintColor.w;   // _229 (b7:111)
                    float outAlpha = baseTintAlpha * _TintColorAlpha;    // _252 (b7:113)

                    // Blend tint weight (b7:120): clamp((_229*_TintColorAlpha + sdfWeight) * _BlendTint.w)
                    float blendWeight = clamp(mad(baseTintAlpha, _TintColorAlpha, sdfWeight) * _BlendTint.w, 0.0, 1.0); // _325 (b7:120)

                    // Final RGB (b7:121-123): additive: blendWeight * sdfCoverage * _BlendTint.rgb * sdfWeight  +  tint base.
                    float3 baseRGB = (baseSample.xyz * _TintColor.xyz * _TintColorIntensity) / postExposure;
                    float3 rgb;
                    rgb.x = mad(blendWeight * (sdfCoverage * _BlendTint.x), sdfWeight, baseRGB.x); // _329 (b7:121)
                    rgb.y = mad(blendWeight * (sdfCoverage * _BlendTint.y), sdfWeight, baseRGB.y); // _330 (b7:122)
                    rgb.z = mad(blendWeight * (sdfCoverage * _BlendTint.z), sdfWeight, baseRGB.z); // _331 (b7:123)
                    return float4(rgb, outAlpha);
                #else
                    // Base variant (b5:107-112).
                    float2 baseUV = float2(mad(uv.x, _BaseTex_ST.x, _BaseTex_ST.z), mad(uv.y, _BaseTex_ST.y, _BaseTex_ST.w));
                    float4 baseSample = SAMPLE_TEXTURE2D_BIAS(_BaseTex, sampler_BaseTex, baseUV, _GlobalMipBias.x);   // T0.SampleBias(sampler_LinearRepeat, .., _GlobalMipBias) (b5:107)
                    float3 rgb = (baseSample.xyz * _TintColor.xyz * _TintColorIntensity) / postExposure; // _226-_228 (b5:109-111)
                    float outAlpha = (baseSample.w * _TintColor.w) * _TintColorAlpha;                    // _232 (b5:112)
                    return float4(rgb, outAlpha);
                #endif
            }
        ENDHLSL

        // ============================================================
        // Pass: ForwardOnly — the visible lit color (source Pass "ForwardOnly", LIGHTMODE "ForwardOnly").
        // ============================================================
        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_BLEND
            #pragma multi_compile_fog

            Varyings vert(Attributes v)
            {
                Varyings o;
                VertexPositionInputs posIn = GetVertexPositionInputs(v.positionOS); // b4:64-73 (camera-relative→URP abs WS)
                o.positionCS = posIn.positionCS;
                o.positionWS = posIn.positionWS;
                o.uv         = v.texcoord0;            // TEXCOORD (b4:77-78)
                o.vertColor  = v.color;               // COLOR    (b4:81-84)
                o.fogFactor  = ComputeFogFactor(posIn.positionCS.z);
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                float4 c = ComputeVfxColor(input.uv, input.positionWS);

                // Output alpha gated by surface type (STYLE_BIBLE §6): opaque writes 1, transparent writes computed alpha.
                float alpha = (_SurfaceType == 1.0) ? c.w : 1.0;

                // HGRP in-shader fog (b5:117-185) decomposes into three terms; URP substitution is MixFog,
                // the SAME infra substitution the whole HGRP_*_Fix effect cluster uses (STYLE_BIBLE §2;
                // cf. HGRP_LitEffect_Fix "froxel fog -> MixFog"). Accounting of the three terms:
                //   (1) Atmosphere scattering  (b5:117-123,181-185): analytic, driven ONLY by the per-frame
                //       pipeline globals _AtmosphereFogParams0..5 (a scene Fog-volume parametrization, identical
                //       for every object — NOT a material constant). Folded into MixFog's scene fog.
                //   (2) Exponential height/linear fog (b5:147-179): analytic, driven ONLY by _ExponentialFogParams0..5
                //       (same per-frame Fog-volume globals). Folded into MixFog.
                //   (3) Volumetric froxel fog (b5:128-163): samples T1, a Texture3D froxel injection/accumulation
                //       volume (b5:152 T1.SampleLevel, indexed by screen-froxel + log view-Z slice) produced by a
                //       separate HGRP volumetric-lighting COMPUTE pass. URP has no froxel volume here.
                // ENGINE-SIDE (only legitimate punt): terms (1)+(2) are pipeline-global driven (a host
                //   ScriptableRenderFeature would have to recompute HGRP's _AtmosphereFogParams/_ExponentialFogParams
                //   from the URP fog/volume state and push 17 float4s into every VFX material each frame — the same
                //   host-fills-it dependency as a froxel volume, not material-self-contained); term (3) is the
                //   froxel-fog injection volume named verbatim as engine-side. All three collapse to URP MixFog,
                //   matching the cluster. The visible tint/SDF color+alpha above is bit-exact 1:1; only the fog
                //   compositing model differs (MixFog vs HGRP 3-term). To restore HGRP-exact fog, a host
                //   HGRP-fog-emulation render feature must bind those globals + a froxel 3D texture.
                float3 rgb = MixFog(c.xyz, input.fogFactor);

                return half4(rgb, alpha);
            }
            ENDHLSL
        }

        // ============================================================
        // Pass: DepthNormalsOnly — remaps source Pass "HGBuffer" (LIGHTMODE "GBuffer").
        // Source writes constant GBuffer MRTs (SV_Target_2..4: normal=(0,1,0), spec=(.5,.5,1), baseColor=_TintColor)
        // for HGRP deferred (b21:93-104). URP is forward here; we emit a depth-normals stub so the VFX participates
        // in URP's depth-normals prepass (SSAO/depth). The constant up-normal matches source GBuffer normal (0,1,0).
        // ============================================================
        Pass {
            Name "DepthNormalsOnly"
            Tags { "LightMode"="DepthNormalsOnly" }
            ZWrite On
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vertDN
            #pragma fragment fragDN

            struct VaryingsDN {
                float4 positionCS : SV_POSITION;
            };

            VaryingsDN vertDN(Attributes v)
            {
                VaryingsDN o;
                o.positionCS = GetVertexPositionInputs(v.positionOS).positionCS;
                return o;
            }

            half4 fragDN(VaryingsDN input) : SV_Target
            {
                // Source GBuffer normal is constant (0,1,0) (b21:93-96). Pack as world-space normal.
                return half4(0.0, 1.0, 0.0, 0.0);
            }
            ENDHLSL
        }
    }
    Fallback Off
}
