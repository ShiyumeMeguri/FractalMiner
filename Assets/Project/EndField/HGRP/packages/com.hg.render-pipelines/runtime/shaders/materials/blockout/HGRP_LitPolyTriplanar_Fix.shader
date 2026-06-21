// HGRP Blockout "LitPolyTriplanar" (grid-projected triplanar lit surface) merged -> URP.
//   The source is a DEFERRED-ONLY HGRP shader: HGBuffer (5-MRT surface packer), ShadowCaster, DepthOnly.
//   It has NO forward-lighting fragment (HG resolves lighting in a separate full-screen deferred pass).
//   The faithful URP port produces the IDENTICAL surface (triplanar albedo + tangent->world normal + MRO)
//   and resolves it with the lit-family direct+ambient PBR (the same GGX-D / Smith-Vis / Schlick-F that
//   consumes the HG GBuffer — CORE_MATH §2), in a URP UniversalForwardOnly pass (+ optional UniversalGBuffer
//   parity is NOT emitted; forward-only per CORE_MATH §1.4 PORT GUIDANCE).
// Merged from: litpolytriplanar/Sub0_Pass0_Fragment_b3.hlsl (HGBuffer frag, base), Sub0_Pass0_Vertex_b2.hlsl
//   (HGBuffer vert, base), Sub0_Pass1_Vertex_b12.hlsl (ShadowCaster vert, base), Sub0_Pass2_Vertex_b18.hlsl
//   (DepthOnly vert, base). All "#else" catch-all variants; keyword set HG_ENABLE_MV only.
// Keywords: _ALPHATEST_ON. (The two triplanar toggles _UseObjectSpaceTriplanar / _GridLength are RUNTIME
//   uniform reads in the blob — b3:132,147,148 read them as scalars, NOT static keyword branches — so they
//   stay [ToggleUI] uniforms here, the faithful mapping; no shader_feature is generated for them.)
// Kept (1:1): GRID TRIPLANAR albedo (3-plane projection of world-or-object position * grid scale, weights =
//   |normal|^100 normalized) (b3:132-154), tangent-space DXT5nm normal decode (x in .a) * _NormalScale + TBN
//   world normal + two-sided front-face sign (b3:103-124), MRO unpack (metallic=.x, roughness=lerp(RoughMin,
//   RoughMax,.y), AO=lerp(1,.z,_OcclusionStrength)) (b3:99-102), _BaseColor tint, alpha-clip, the lit-family
//   GGX/Smith/Schlick direct lighting + EnvBRDF ambient that consumes the surface (CORE_MATH §2.6/§2.7).
// Removed (pixel-neutral pipeline infra, substituted by URP — STYLE_BIBLE §2 / CORE_MATH §2.12):
//   HG packed-octahedral vertex NORMAL/TANGENT decode (-> Unity-standard mesh + GetVertexNormalInputs),
//   GPU skinning, HG motion-vector dual-frame MRT + TAAU (-> URP MotionVectors pass; SV_Target1 dropped),
//   HG 5-MRT deferred GBuffer pack incl. octahedral-normal encode + LOD-crossfade dither (-> URP forward),
//   depth-buffer world-position reconstruction via _InvViewProjMatrix (-> interpolated positionWS; identical),
//   IV-clipmap GI (-> SampleSH), HG reflection-probe binning (-> GlossyEnvironmentReflection),
//   CSM/ASM shadow atlas (-> URP main-light shadow), froxel fog (-> MixFog), _GlobalMipBias (URP auto-adds).
//
// NOTE (load-bearing): the decompiled HGBuffer fragment reads the TWO triplanar toggles as
//   `_unity_ObjectToWorld[0u].x` (= use-object-space, lerp factor world<->object) and `_unity_ObjectToWorld[0u].y`
//   (= grid length, fed to `mad(-flag, 0.9, 1.0)` -> 1.0 for 1m / 0.1 for 10m). That cbuffer is a SPIRV-Cross
//   register-aliasing artifact (the fragment never reads the real object-to-world matrix; b3:31-34,132,147,455).
//   These are the material properties _UseObjectSpaceTriplanar (Float 0/1) and _GridLength (Enum 0=1m,1=10m).
// Texture channels: _MROMap RGB = Metallic, Roughness, Occlusion. _NormalMap DXT5nm (X in .a, Y in .g).
//   _BaseColorMap is TRIPLANAR-projected (its own _ST is NOT used; the projected coord uses grid scale only).

Shader "HGRP/Blockout/LitPolyTriplanar_Fix" {
    Properties {
        // ============================================================
        // Blend-state plumbing (set by CustomEditor / presets via _SurfaceType). Opaque defaults.
        // ============================================================
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _Cull ("Render Face", Float) = 2
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 0
        [HideInInspector] _ZTestGBuffer ("__ztGBuffer", Float) = 4
        [HideInInspector] _StencilRef ("Stencil Ref", Float) = 0

        // ============================================================
        // Core surface / base PBR (always-on)  (b3 cbuffer type_UnityPerMaterial)
        // ============================================================
        _BaseColor ("Base Color", Color) = (0.6, 0.6, 0.6, 1)
        _BaseColorMap ("Base Color Map (triplanar)", 2D) = "white" {}
        _NormalMap ("Normal Map (DXT5nm)", 2D) = "bump" {}
        _MROMap ("MRO Map (Metallic,Roughness,Occlusion)", 2D) = "white" {}
        _NormalScale ("Normal Scale", Range(0, 1)) = 1
        _Specular ("Specular", Range(0, 1)) = 0.5
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1
        _OcclusionStrength ("Occlusion Strength", Range(0, 1)) = 1
        [ToggleUI] _TwoSidedNormal ("Two Sided Normal", Float) = 0

        // ============================================================
        // Triplanar grid controls  (HG toggles; see header NOTE)
        // ============================================================
        [Header(Triplanar Grid)]
        [ToggleUI] _UseObjectSpaceTriplanar ("Use Object-Space Triplanar", Float) = 0
        [Enum(OneMeter, 0, TenMeters, 1)] _GridLength ("Grid Length (1m / 10m)", Float) = 0

        // ============================================================
        // Alpha Test  (b-keyword _ALPHATEST_ON; clip in Shadow/Depth + Forward)
        // ============================================================
        [Header(Alpha Test)]
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Enable Alpha Test", Float) = 0
        _AlphaClipThreshold ("Clip Threshold", Range(0, 1)) = 0.5

        // ============================================================
        // Advanced infra (no keyword)
        // ============================================================
        [Header(Advanced)]
        _TAAUNormalBiasReverse ("TAAU Normal Bias Reverse", Float) = 0

        // ============================================================
        // Environment params (HGRP globals re-exposed as material Vectors; URP has no equivalent
        // global — STYLE_BIBLE §1.5/§2). Ambient diffuse + reflection intensity scales.
        // ============================================================
        [Header(Environment Params)]
        _EnvironmentGlobalParams0 ("EnvGlobalParams0 (.x=ambient .y=reflection intensity)", Vector) = (1, 1, 1, 0)
    }

    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Opaque" }
        LOD 300

        HLSLINCLUDE
            // ============================================================
            // URP infrastructure (substitutes for the HGRP hand-rolled globals — STYLE_BIBLE §2):
            //   _InvViewProjMatrix/_NonJitteredViewNoTransProjMatrix/_unity_ObjectToWorld -> UNITY_MATRIX_*,
            //   GetVertexPositionInputs/GetVertexNormalInputs ; _GlobalMipBias auto-added by SAMPLE_*_BIAS ;
            //   _WorldSpaceCameraPos_Internal -> GetWorldSpaceViewDir ; SH/probe/shadow/fog -> URP facilities.
            // ============================================================
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"

            // ------------------------------------------------------------
            // FROZEN UNIFORM INTERFACE — single UnityPerMaterial CBUFFER.
            // Field set: b3 cbuffer type_UnityPerMaterial (_NormalScale,_RoughnessMin,_RoughnessMax,
            // _OcclusionStrength,_BaseColor) + the props referenced by the surface/lighting math.
            // No packoffset, no _unity_ObjectToWorld[] alias (SPIRV-Cross artifact — see header NOTE).
            // ------------------------------------------------------------
            CBUFFER_START(UnityPerMaterial)
                // blend-state plumbing
                float _SrcBlend;
                float _DstBlend;
                float _ZTest;
                float _ZWrite;
                float _Cull;
                float _SurfaceType;
                float _ZTestGBuffer;
                float _StencilRef;
                // core surface / PBR
                float4 _BaseColor;
                float4 _BaseColorMap_ST;   // present for material/batching compat; triplanar path ignores it (header NOTE)
                float  _NormalScale;
                float  _Specular;
                float  _RoughnessMin;
                float  _RoughnessMax;
                float  _OcclusionStrength;
                float  _TwoSidedNormal;
                // triplanar grid toggles (HG _unity_ObjectToWorld[0].x/.y aliases)
                float  _UseObjectSpaceTriplanar;
                float  _GridLength;
                // alpha-clip
                float  _AlphaClipThreshold;
                // advanced
                float  _TAAUNormalBiasReverse;
                // env globals re-exposed
                float4 _EnvironmentGlobalParams0;
            CBUFFER_END

            // ------------------------------------------------------------
            // Textures. Wrap modes are LOAD-BEARING and taken from the blob sampler aliases (b3:39-41),
            // NOT from the texture import settings — HG hard-binds a specific global sampler per texture.
            // URP exposes these exact global samplers as predefined inline samplers (Core/D3D11.hlsl),
            // so we sample with the named sampler (STYLE_BIBLE sampler-map rows 129-130):
            //   _BaseColorMap : sampler_LinearClamp   (triplanar projection — CLAMP, b3:148-150)  <- forced
            //   _NormalMap    : sampler_LinearRepeat  (tangent normal — REPEAT, b3:104)
            //   _MROMap       : sampler_LinearMirror  (MRO — MIRROR, b3:99)
            // ------------------------------------------------------------
            TEXTURE2D(_BaseColorMap);  // triplanar samples use sampler_LinearClamp (URP built-in, b3:148-150)
            TEXTURE2D(_NormalMap);     SAMPLER(sampler_LinearRepeat);  // b3:104
            TEXTURE2D(_MROMap);        SAMPLER(sampler_LinearMirror);  // b3:99

            // ------------------------------------------------------------
            // Algorithm-boundary constants (CORE_MATH §0.4; preserved EXACTLY — decode of denormals).
            // ------------------------------------------------------------
            static const float HGRP_EPS_NORMAL_Z   = 1.000000016862383526387164645044e-16;  // 1e-16 ; derived-normal Z floor (b3:109)
            static const float HGRP_EPS_RSQRT      = 1.1754943508222875079687365372222e-38;  // FLT_MIN ; normalize rsqrt guard (b3:113)
            static const float HGRP_EPS_VIEWLEN    = 9.9999999392252902907785028219223e-09;  // 1e-8 ; view rsqrt guard (CORE_MATH §0.4)
            static const float HGRP_EPS_VIS        = 9.9999997473787516355514526367188e-05;  // 1e-4 ; Smith-vis denom floor (b9:981)
            static const float HGRP_DIELECTRIC_F0  = 0.07999999821186065673828125;           // 0.08 ; dielectric F0 = 0.08*_Specular (b9:318)
            static const float HGRP_GRAZING_FLOOR  = 0.0476190485060214996337890625;         // 1/21 ; multiscatter grazing floor (b9:977-979)
            static const float TRIPLANAR_SHARPNESS = 100.0;                                  // |normal|^100 triplanar weight power (b3:132-134)

            // ============================================================================================
            // SURFACE (1:1) — built from b3 (the HGBuffer fragment surface assembly).
            // ============================================================================================
            struct LitPolySurface
            {
                float3 albedo;     // triplanar base color * _BaseColor (b3:151-153)
                float3 normalWS;   // TBN world normal, two-sided + front-face signed (b3:103-124)
                float  metallic;   // mro.x (b3:101)
                float  roughness;  // linear, lerp(RoughMin,RoughMax,mro.y) (b3:102)
                float  occlusion;  // lerp(1, mro.z, _OcclusionStrength) (b3:100)
                float  alpha;      // surface-type / alpha-clip alpha (transparent = base.a)
                float3 f0;         // lerp(0.08*_Specular, albedo, metallic) (CORE_MATH §2.3)
            };

            // Triplanar albedo: project (world or object) position onto 3 axis planes, blend by |normal|^100.
            // 1:1 source b3:132-154. World position comes from URP positionWS (b3 reconstructs the SAME value
            // from the depth buffer via _InvViewProjMatrix — infra substitution, identical result). Object
            // position = the interpolated object-space POSITION the HG vertex passed in TEXCOORD_7 (b2:272-274).
            // The blend normal is lerp(worldNormal, objectNormal, useObjectSpace): HG feeds object-space NORMAL
            // (TEXCOORD_4 in frag = decoded vertex normal) interpolated against the front-faced world normal.
            float3 SampleTriplanarAlbedo(float3 positionWS, float3 positionOS, float3 normalWS, float3 normalOS)
            {
                // grid scale: _455 = mad(-_GridLength, 0.9, 1.0) -> 1.0 (1m) or 0.1 (10m)  (b3:147)
                float gridScale = mad(-_GridLength, 0.89999997615814208984375, 1.0);

                // blend coordinate = lerp(worldPos, objPos, useObjectSpace)  (b3:148-150 inner mad)
                float3 triPos = lerp(positionWS, positionOS, _UseObjectSpaceTriplanar) * gridScale;
                // blend normal  = lerp(worldNormal, objNormal, useObjectSpace)  (b3:132-134 inner mad)
                float3 triNrm = lerp(normalWS, normalOS, _UseObjectSpaceTriplanar);

                // triplanar weights = |triNrm|^100 normalized  (b3:132-138)
                float3 wx = exp2(log2(abs(triNrm)) * TRIPLANAR_SHARPNESS);         // |n|^100 per axis (b3:132-134)
                float  wsum = wx.x + wx.y + wx.z;                                  // (b3:135)
                float3 w = wx / wsum;                                              // (b3:136-138)

                // axis-plane projections (b3:148-150):
                //   X-plane (w.x): uv = (triPos.z, triPos.y)   [_473 in blob]
                //   Y-plane (w.y): uv = (triPos.x, triPos.z)   [_465 in blob, the "top" plane]
                //   Z-plane (w.z): uv = (triPos.x, triPos.y)   [_502 in blob]
                float4 cX = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_LinearClamp, float2(triPos.z, triPos.y)); // _473 (b3:149)
                float4 cY = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_LinearClamp, float2(triPos.x, triPos.z)); // _465 (b3:148)
                float4 cZ = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_LinearClamp, float2(triPos.x, triPos.y)); // _502 (b3:150)

                // blend then tint  (b3:151-153): mad(cZ,w.z, mad(cX,w.x, w.y*cY)) * _BaseColor
                float3 blended = mad(cZ.rgb, w.zzz, mad(cX.rgb, w.xxx, w.yyy * cY.rgb)); // (b3:151-153)
                return blended * _BaseColor.rgb;
            }

            // Tangent-space normal -> world, with DXT5nm decode + two-sided front-face sign. 1:1 b3:103-124.
            float3 BuildWorldNormal(float2 uv, float3 normalGeo, float4 tangentWS, bool isFrontFace,
                                    out float baseTexAlphaUnused)
            {
                baseTexAlphaUnused = 0.0;

                // tangent handedness sign: _180 = (tangent.w>0)?+1:-1  (b3:103)
                float bitSign = (tangentWS.w > 0.0) ? 1.0 : -1.0;

                // DXT5nm decode: nx = (n.x*n.w*2 - 1) ; ny = (n.y*2 - 1) ; both * _NormalScale  (b3:104-108)
                // b3:104 samples the normal with _GlobalMipBias ONLY (URP folds it into plain SAMPLE_TEXTURE2D).
                // NOTE(1:1): _TAAUNormalBiasReverse is NOT applied here — it does not appear in b3 (it is a
                // dropped TAAU/motion-vector side-channel concern, not a GBuffer normal-mip bias). Applying it
                // as a mip bias would diverge from b3 whenever the material sets it nonzero.
                float4 nrm = SAMPLE_TEXTURE2D(_NormalMap, sampler_LinearRepeat, uv); // _225 (b3:104)
                float nxRaw = mad(nrm.x * nrm.w, 2.0, -1.0);    // _231 (b3:105)
                float nyRaw = mad(nrm.y,        2.0, -1.0);    // _234 (b3:106)
                float nx = nxRaw * _NormalScale;                // _238 (b3:107)
                float ny = nyRaw * _NormalScale;                // _239 (b3:108)
                // tangent-space Z (NOTE: HG uses the UN-scaled nx,ny here — _247 = sqrt(1 - dot(nxRaw,nyRaw)))  (b3:109)
                float nz = max(sqrt(1.0 - min(dot(float2(nxRaw, nyRaw), float2(nxRaw, nyRaw)), 1.0)), HGRP_EPS_NORMAL_Z); // _247 (b3:109)

                // world normal via TBN: N*nz + T*nx + ny*(bitSign*cross(N,T))  (b3:110-112)
                float3 bitangent = bitSign * cross(normalGeo, tangentWS.xyz);
                float3 nWS = mad(nz.xxx, normalGeo, mad(nx.xxx, tangentWS.xyz, ny.xxx * bitangent)); // _267..269 (b3:110-112)
                nWS = nWS * rsqrt(max(dot(nWS, nWS), HGRP_EPS_RSQRT));                                // _275 (b3:113)

                // two-sided front-face flip: _281/_285..287 = isFrontFace ? n : -n  (b3:117-120)
                // HG flips UNCONDITIONALLY on back faces (no _TwoSidedNormal gate here — the deferred GBuffer
                // path always two-sides; _TwoSidedNormal lives in the forward lit family, b9:303). Faithful to b3.
                float3 signedN = isFrontFace ? nWS : -nWS;
                return normalize(signedN); // _291..294 (b3:121-124)
            }

            LitPolySurface BuildSurface(float3 positionWS, float3 positionOS, float3 normalGeo, float3 normalOS,
                                        float4 tangentWS, float2 uv, bool isFrontFace)
            {
                LitPolySurface s = (LitPolySurface)0;

                float dummyA;
                s.normalWS = BuildWorldNormal(uv, normalGeo, tangentWS, isFrontFace, dummyA);

                // MRO unpack (b3:99-102). _150 = T2(mirror).SampleBias(uv, _GlobalMipBias).
                float4 mro = SAMPLE_TEXTURE2D_BIAS(_MROMap, sampler_LinearMirror, uv, 0.0);  // URP auto-adds _GlobalMipBias.x (b3:99)
                s.metallic  = mro.x;                                                    // _150.x -> MRT2.x (b3:101)
                s.roughness = mad(mro.y, _RoughnessMax - _RoughnessMin, _RoughnessMin); // lerp(RoughMin,RoughMax,mro.y) -> MRT3.z (b3:102)
                s.occlusion = mad(mro.z, _OcclusionStrength, 1.0 - _OcclusionStrength); // lerp(1,mro.z,_OcclusionStrength) -> MRT2.y (b3:100)

                // triplanar albedo (b3:132-154)
                s.albedo = SampleTriplanarAlbedo(positionWS, positionOS, s.normalWS, normalOS);

                // PBR split (CORE_MATH §2.3): F0 = lerp(0.08*_Specular, albedo, metallic).
                float dielF0 = HGRP_DIELECTRIC_F0 * _Specular;       // 0.08*_Specular (b9:318)
                s.f0 = lerp(dielF0.xxx, s.albedo, s.metallic);       // (b9:322-325)

                s.alpha = _BaseColor.a;
                return s;
            }

            // ============================================================================================
            // LIGHTING (1:1 lit-family direct+ambient PBR — the model that consumes the HG GBuffer).
            // GGX-D + Smith height-correlated Vis + Schlick F (CORE_MATH §2.7, b9:964-983); EnvBRDF ambient
            // (CORE_MATH §2.6, b9:326-329/1261); SampleSH + GlossyEnvironmentReflection + MixFog (§2.4/2.5/2.10).
            // ============================================================================================

            // Karis mobile EnvBRDF: F0 scale/bias for the ambient (probe) reflection. b9:326-329,1261. Coeffs exact.
            void HgEnvBRDF(float roughness, float NoV, float3 f0, out float envSpecScale, out float envSpecBias)
            {
                float oneMinusRough = mad(roughness, -1.0, 1.0);                                  // 1-rough (b9:326)
                float envF = mad(min(oneMinusRough * oneMinusRough, exp2(NoV * -9.27999973297119140625)),
                                 oneMinusRough,
                                 mad(roughness, -0.0274999998509883880615234375, 0.0425000004470348358154296875)); // _536 (b9:328)
                envSpecScale = mad(envF, -1.03999996185302734375,
                                   mad(roughness, -0.572000026702880859375, 1.03999996185302734375));               // _537 (b9:329)
                envSpecBias = mad(envF, 1.03999996185302734375,
                                  mad(roughness, 0.02199999988079071044921875, -0.039999999105930328369140625))
                              * saturate(f0.g * 50.0);                                                              // _3103 (b9:1261)
            }

            // Karis/Lazarov EnvBRDFApprox rational DFG (multiscatter diffuse energy). b9:975 (_2183). Coeffs exact.
            float HgEnvBRDFApproxDFG(float roughness)
            {
                float t = mad(roughness, -1.0, 1.0);                                       // 1-roughness (b9:974)
                return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875,
                                              -0.076194703578948974609375),
                                        1.04997003078460693359375),
                               0.4092549979686737060546875),
                           0.999000012874603271484375);                                    // (b9:975)
            }

            // Cook-Torrance GGX-D + Smith height-correlated Vis + Schlick F. b9:964-983. Returns spec (pre-NoL).
            float3 HgDirectSpecular(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float a  = roughness * roughness;                            // _2159 (b9:967)
                float a2 = a * a;                                            // _2160 (b9:968)
                float nv = min(NoV, 1.0);                                    // _2158 (b9:966)
                float d  = mad(mad(NoH, a2, -NoH), NoH, 1.0);               // (NoH*a2-NoH)*NoH+1 _2163 (b9:969)
                float visDenom = nv  * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2))
                               + NoL * sqrt(mad(mad(-nv,  a2, nv ), nv , a2))
                               + HGRP_EPS_VIS;                               // _2217 denom (b9:981)
                float DV = (a2 / (d * d)) * (0.5 / visDenom);               // D*Vis (b9:981)
                float oneMinusVoH = mad(-VoH, 1.0, 1.0);                    // 1-VoH (b9:970)
                float sq = oneMinusVoH * oneMinusVoH;                        // (b9:971)
                float quad = sq * sq;                                        // (b9:972)
                float Fc = oneMinusVoH * quad;                             // (1-VoH)^5 _2172 (b9:973)
                float oneMinusFc = mad(-quad, oneMinusVoH, 1.0);           // 1-(1-VoH)^5 (b9:980)
                float3 F = mad(f0, oneMinusFc.xxx, Fc.xxx);                // lerp(F0,1,Fc) (b9:983)
                return DV * F;
            }

            // Per-light energy bracket: min(max(msDiff + min(spec,2048), 0), 1000). b9:983 (multiscatter + spec).
            float3 HgDirectLightEnergy(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float3 specE = HgDirectSpecular(roughness, f0, NoL, NoH, NoV, VoH);          // (b9:981·983)
                float dfg = HgEnvBRDFApproxDFG(roughness);                                   // _2183 (b9:975)
                float oneMinusDfg = mad(-dfg, 1.0, 1.0);                                     // _2186 (b9:976)
                float dfgEnergy = dfg / oneMinusDfg;                                         // _2240 (T9 product -> dfg substitute)
                float3 gz = mad((float3(1.0, 1.0, 1.0) - f0), HGRP_GRAZING_FLOOR, f0);       // lerp(F0,1,1/21) _2193 (b9:977-979)
                float3 msDiff = (dfgEnergy * (gz * gz)) / mad(-gz, oneMinusDfg.xxx, float3(1.0, 1.0, 1.0)); // (b9:983 term A)
                return min(max(msDiff + min(specE, 2048.0), 0.0), 1000.0);                   // (b9:983)
            }

            // View dir (world), normalized with HG's guard. b9:271-280 ; ortho resolved by GetWorldSpaceViewDir.
            float3 HgViewDirWS(float3 viewRaw)
            {
                return viewRaw * rsqrt(max(dot(viewRaw, viewRaw), HGRP_EPS_VIEWLEN)); // _207..210 (b9:277)
            }

            // Full forward composite (the deferred surface, lit). Mirrors b9:1325-1343 (fog -> MixFog, SV_Target1 dropped).
            half4 LitPolyForwardLighting(LitPolySurface s, float3 positionWS, float3 viewDirWS, float fogFactor)
            {
                float3 N = normalize(s.normalWS);
                float3 V = HgViewDirWS(viewDirWS);                                    // §2.2 (b9:271-280)
                float roughness = s.roughness;                                       // linear (b9:301)
                float3 f0 = s.f0;                                                    // (b9:322-325)
                float3 diffuse = s.albedo * (1.0 - s.metallic);                      // baseCol*(1-metallic) (b9:319-321)
                float occlusion = s.occlusion;                                       // (b9:1260)
                float NoV = max(dot(N, V), 0.0);                                     // _531 (b9:327)

                // §2.6 ambient EnvBRDF (F0 scale/bias)
                float envSpecScale, envSpecBias;
                HgEnvBRDF(roughness, NoV, f0, envSpecScale, envSpecBias);            // (b9:326-329,1261)

                // §2.4 ambient diffuse: IV-clipmap SH -> URP SampleSH(N) ; §2.5 reflection -> GlossyEnvironmentReflection
                float3 ambientSH = SampleSH(N);
                float perceptualRoughness = saturate(roughness);
                float3 reflectVec = reflect(-V, N);                                  // R=reflect(-V,N) (b9:578-582)
                float3 reflection = GlossyEnvironmentReflection(reflectVec, perceptualRoughness, 1.0); // un-occluded (b9:1325 term B)

                float3 color = diffuse * ambientSH * occlusion * _EnvironmentGlobalParams0.x          // term A (b9:1325)
                             + reflection * (f0 * envSpecScale + envSpecBias) * _EnvironmentGlobalParams0.y; // term B (b9:1325)

                // §2.7 main directional light: HG CSM/ASM -> URP main-light shadow
                float4 shadowCoord = TransformWorldToShadowCoord(positionWS);
                Light mainLight = GetMainLight(shadowCoord, positionWS, half4(1, 1, 1, 1));
                float mainAtten = mainLight.distanceAttenuation * mainLight.shadowAttenuation;        // _1897 (b9:938)
                {
                    float3 L = mainLight.direction;                                  // (b9:944)
                    float3 H = normalize(L + V);                                     // (b9:957-963)
                    float NoL = saturate(dot(L, N));                                // _2153 (b9:964)
                    float NoH = saturate(dot(N, H));                                // _2157 (b9:965)
                    float VoH = saturate(dot(V, H));                                // (b9:970)
                    float3 energy = HgDirectLightEnergy(roughness, f0, NoL, NoH, NoV, VoH); // (b9:975-983)
                    color += mad(energy, NoL, diffuse * NoL) * (mainAtten * mainLight.color); // (b9:983)
                }

                // §2.8 additional punctual lights: HG tile/zbin -> URP GetAdditionalLight loop
            #if defined(_ADDITIONAL_LIGHTS)
                uint addCount = GetAdditionalLightsCount();
                for (uint li = 0u; li < addCount; ++li)
                {
                    Light light = GetAdditionalLight(li, positionWS, half4(1, 1, 1, 1));
                    float3 L = light.direction;
                    float3 H = normalize(L + V);
                    float NoL = saturate(dot(L, N));
                    float NoH = saturate(dot(N, H));
                    float VoH = saturate(dot(V, H));
                    float3 energy = HgDirectLightEnergy(roughness, f0, NoL, NoH, NoV, VoH);
                    float atten = light.distanceAttenuation * light.shadowAttenuation;
                    color += mad(energy, NoL, diffuse * NoL) * (atten * light.color);
                }
            #endif

                // §2.10 fog: HG atmosphere+exp+volumetric -> URP MixFog
                color = MixFog(color, fogFactor);

                // §2.11 output alpha gated by surface type (b9:1343 _349; STYLE_BIBLE §6)
                float alpha = (_SurfaceType == 1.0) ? s.alpha : 1.0;
                return half4(color, alpha);
            }

            // Alpha-clip helper (ShadowCaster / DepthOnly / DepthNormals / Forward under _ALPHATEST_ON).
            // HG base ShadowCaster/DepthOnly fragments are EMPTY (b13/b19); the clip lives in the keyword
            // branch (CORE_MATH §4.2/§4.4). _BaseColorMap is triplanar here, so the clip samples the SAME
            // triplanar albedo .a — but the base map alpha (cZ plane) is the representative; faithfully we
            // re-derive the full triplanar alpha so the cutout matches the lit surface.
            void LitPolyAlphaClip(float3 positionWS, float3 positionOS, float3 normalWS, float3 normalOS)
            {
            #ifdef _ALPHATEST_ON
                float gridScale = mad(-_GridLength, 0.89999997615814208984375, 1.0);
                float3 triPos = lerp(positionWS, positionOS, _UseObjectSpaceTriplanar) * gridScale;
                float3 triNrm = lerp(normalWS, normalOS, _UseObjectSpaceTriplanar);
                float3 wx = exp2(log2(abs(triNrm)) * TRIPLANAR_SHARPNESS);
                float3 w = wx / (wx.x + wx.y + wx.z);
                float aX = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_LinearClamp, float2(triPos.z, triPos.y)).a;
                float aY = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_LinearClamp, float2(triPos.x, triPos.z)).a;
                float aZ = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_LinearClamp, float2(triPos.x, triPos.y)).a;
                float alpha = (aZ * w.z + aX * w.x + aY * w.y) * _BaseColor.a;
                clip(alpha - _AlphaClipThreshold);
            #endif
            }
        ENDHLSL

        // ============================================================================================
        // Pass 1: ForwardLit — resolves the HG deferred surface in-fragment (URP forward path).
        // The source had no forward fragment; this is the faithful URP substitute for HG's deferred
        // lighting pass that consumes the GBuffer (CORE_MATH §1.4 PORT GUIDANCE).
        // ============================================================================================
        Pass {
            Name "ForwardLit"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] OneMinusSrcAlpha
            ZTest [_ZTestGBuffer]
            ZWrite [_ZWrite]
            Cull [_Cull]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex   ForwardVert
                #pragma fragment ForwardFrag

                #pragma shader_feature_local _ALPHATEST_ON

                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH
                #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
                #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BOX_PROJECTION
                #pragma multi_compile_fog

                struct Attributes
                {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float4 tangentOS  : TANGENT;
                    float2 uv0        : TEXCOORD0;
                };

                struct Varyings
                {
                    float4 positionCS : SV_POSITION;
                    float3 positionWS : TEXCOORD0;
                    float3 positionOS : TEXCOORD1;   // object-space pos for object-space triplanar (b2:272-274)
                    float3 normalWS   : TEXCOORD2;
                    float4 tangentWS  : TEXCOORD3;
                    float3 normalOS   : TEXCOORD4;   // object-space normal = triplanar blend normal (b3 TEXCOORD_4)
                    float2 uv         : TEXCOORD5;
                    float3 viewDirWS  : TEXCOORD6;
                    float  fogFactor  : TEXCOORD7;
                };

                Varyings ForwardVert(Attributes IN)
                {
                    Varyings OUT = (Varyings)0;
                    VertexPositionInputs p = GetVertexPositionInputs(IN.positionOS);
                    VertexNormalInputs   n = GetVertexNormalInputs(IN.normalOS, IN.tangentOS);
                    OUT.positionCS = p.positionCS;
                    OUT.positionWS = p.positionWS;
                    OUT.positionOS = IN.positionOS;
                    OUT.normalWS   = n.normalWS;
                    OUT.tangentWS  = float4(n.tangentWS, IN.tangentOS.w * GetOddNegativeScale());
                    OUT.normalOS   = IN.normalOS;
                    OUT.uv         = IN.uv0;
                    OUT.viewDirWS  = GetWorldSpaceViewDir(p.positionWS);
                    OUT.fogFactor  = ComputeFogFactor(p.positionCS.z);
                    return OUT;
                }

                half4 ForwardFrag(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    LitPolyAlphaClip(IN.positionWS, IN.positionOS, normalize(IN.normalWS), IN.normalOS);
                    LitPolySurface s = BuildSurface(IN.positionWS, IN.positionOS, IN.normalWS, IN.normalOS,
                                                    IN.tangentWS, IN.uv, isFrontFace);
                    return LitPolyForwardLighting(s, IN.positionWS, IN.viewDirWS, IN.fogFactor);
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2: ShadowCaster  (1:1 b12 — object->world->shadow-clip ; URP ApplyShadowBias substitute).
        //   HG clips through a baked shadow VP (b12:103-106 _unity_ObjectToWorld = shadow VP); URP's
        //   faithful infra substitute is ApplyShadowBias + TransformWorldToHClip (+ near-plane clamp).
        //   Base fragment EMPTY (b13) ; alpha-clip only under _ALPHATEST_ON.
        // ============================================================================================
        Pass {
            Name "ShadowCaster"
            Tags { "LightMode"="ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_Cull]
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex   ShadowVert
                #pragma fragment ShadowFrag
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW

                float3 _LightDirection;
                float3 _LightPosition;

                struct Attributes
                {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float2 uv0        : TEXCOORD0;
                };

                struct Varyings
                {
                    float4 positionCS : SV_POSITION;
                    float3 positionWS : TEXCOORD0;
                    float3 positionOS : TEXCOORD1;
                    float3 normalWS   : TEXCOORD2;
                    float3 normalOS   : TEXCOORD3;
                };

                Varyings ShadowVert(Attributes IN)
                {
                    Varyings OUT = (Varyings)0;
                    float3 positionWS = TransformObjectToWorld(IN.positionOS);     // b12:103-106 world (-> shadow clip)
                    float3 normalWS   = TransformObjectToWorldNormal(IN.normalOS);
                #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                    float3 lightDir = normalize(_LightPosition - positionWS);
                #else
                    float3 lightDir = _LightDirection;
                #endif
                    OUT.positionCS = TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDir));
                #if UNITY_REVERSED_Z
                    OUT.positionCS.z = min(OUT.positionCS.z, UNITY_NEAR_CLIP_VALUE);
                #else
                    OUT.positionCS.z = max(OUT.positionCS.z, UNITY_NEAR_CLIP_VALUE);
                #endif
                    OUT.positionWS = positionWS;
                    OUT.positionOS = IN.positionOS;
                    OUT.normalWS   = normalWS;
                    OUT.normalOS   = IN.normalOS;
                    return OUT;
                }

                half4 ShadowFrag(Varyings IN) : SV_Target
                {
                    LitPolyAlphaClip(IN.positionWS, IN.positionOS, normalize(IN.normalWS), IN.normalOS);
                    return 0; // base fragment empty (b13)
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 3: DepthOnly  (1:1 b18 — object->world->camera-clip ; depth write). Base fragment EMPTY (b19).
        // ============================================================================================
        Pass {
            Name "DepthOnly"
            Tags { "LightMode"="DepthOnly" }
            ZWrite On
            ZTest LEqual
            ColorMask R
            Cull [_Cull]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex   DepthVert
                #pragma fragment DepthFrag
                #pragma shader_feature_local _ALPHATEST_ON

                struct Attributes
                {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float2 uv0        : TEXCOORD0;
                };

                struct Varyings
                {
                    float4 positionCS : SV_POSITION;
                    float3 positionWS : TEXCOORD0;
                    float3 positionOS : TEXCOORD1;
                    float3 normalWS   : TEXCOORD2;
                    float3 normalOS   : TEXCOORD3;
                };

                Varyings DepthVert(Attributes IN)
                {
                    Varyings OUT = (Varyings)0;
                    VertexPositionInputs p = GetVertexPositionInputs(IN.positionOS); // b18 object->world->camera clip
                    OUT.positionCS = p.positionCS;
                    OUT.positionWS = p.positionWS;
                    OUT.positionOS = IN.positionOS;
                    OUT.normalWS   = TransformObjectToWorldNormal(IN.normalOS);
                    OUT.normalOS   = IN.normalOS;
                    return OUT;
                }

                half4 DepthFrag(Varyings IN) : SV_Target
                {
                    LitPolyAlphaClip(IN.positionWS, IN.positionOS, normalize(IN.normalWS), IN.normalOS);
                    return 0; // base fragment empty (b19)
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 4: DepthNormalsOnly  (URP SSAO / depth-normals prepass — STYLE_BIBLE §7). Maps the HG
        // HGBuffer "world normal" output (b3:121-124) into URP's prepass normal target; rebuilds the
        // SAME per-pixel TBN triplanar-surface normal so SSAO matches the lit surface.
        // ============================================================================================
        Pass {
            Name "DepthNormalsOnly"
            Tags { "LightMode"="DepthNormalsOnly" }
            ZWrite On
            Cull [_Cull]
            HLSLPROGRAM
                #pragma target 3.0
                #pragma vertex   DepthNormalsVert
                #pragma fragment DepthNormalsFrag
                #pragma shader_feature_local _ALPHATEST_ON

                struct Attributes
                {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float4 tangentOS  : TANGENT;
                    float2 uv0        : TEXCOORD0;
                };

                struct Varyings
                {
                    float4 positionCS : SV_POSITION;
                    float3 positionWS : TEXCOORD0;
                    float3 positionOS : TEXCOORD1;
                    float3 normalWS   : TEXCOORD2;
                    float4 tangentWS  : TEXCOORD3;
                    float3 normalOS   : TEXCOORD4;
                    float2 uv         : TEXCOORD5;
                };

                Varyings DepthNormalsVert(Attributes IN)
                {
                    Varyings OUT = (Varyings)0;
                    VertexPositionInputs p = GetVertexPositionInputs(IN.positionOS);
                    VertexNormalInputs   n = GetVertexNormalInputs(IN.normalOS, IN.tangentOS);
                    OUT.positionCS = p.positionCS;
                    OUT.positionWS = p.positionWS;
                    OUT.positionOS = IN.positionOS;
                    OUT.normalWS   = n.normalWS;
                    OUT.tangentWS  = float4(n.tangentWS, IN.tangentOS.w * GetOddNegativeScale());
                    OUT.normalOS   = IN.normalOS;
                    OUT.uv         = IN.uv0;
                    return OUT;
                }

                half4 DepthNormalsFrag(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    LitPolyAlphaClip(IN.positionWS, IN.positionOS, normalize(IN.normalWS), IN.normalOS);
                    float dummyA;
                    float3 normalWS = BuildWorldNormal(IN.uv, IN.normalWS, IN.tangentWS, isFrontFace, dummyA);
                    return half4(NormalizeNormalPerPixel(normalWS), 0.0);
                }
            ENDHLSL
        }
    }
    FallBack "Hidden/Universal Render Pipeline/FallbackError"
}
