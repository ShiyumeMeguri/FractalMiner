// HGRP LitEffect (deferred PBR prop/effect surface) -> URP, 1:1. Passes: HGBuffer, ShadowCaster, DepthOnly, RayTracingReflection(stub) + URP-added ForwardLit / DepthNormalsOnly.
// Merged from: liteffect.shader (HGRP/LitEffect) base variant blobs:
//   Vertex   HGBuffer  = liteffect/Sub0_Pass0_Vertex_b184.hlsl   (catch-all #else, liteffect.shader:805-808)
//   Fragment HGBuffer  = liteffect/Sub0_Pass0_Fragment_b185.hlsl (catch-all #else, liteffect.shader:1365-1368)
//   Vertex   Shadow    = liteffect/Sub0_Pass1_Vertex_b588.hlsl   (catch-all #else, liteffect.shader:1579-1582)
//   Fragment Shadow    = liteffect/Sub0_Pass1_Fragment_b589.hlsl (EMPTY, liteffect.shader:1767-1770)
//   Vertex   DepthOnly = liteffect/Sub0_Pass2_Vertex_b764.hlsl   (catch-all #else, liteffect.shader:2345-2346 sibling)
//   Fragment DepthOnly = liteffect/Sub0_Pass2_Fragment_b765.hlsl (EMPTY, liteffect.shader:2345-2348)
// Keywords: _ALPHATEST_ON, _TWO_BASEMAP, _TRI_CHANNEL_MASK, _EMISSIVE_MAP, _EMISSIVE_MASK, _EMISSIVE_NOMAP, _EMISSIVE_ANIM, _EMISSIVE_ANIM_SWEEP,
//   _DETAIL_MAP, _PARALLAX_MAP, _PARALLAX_MAP_WORLDSPACE, _USE_DISTURB, _USE_DISSOLVE, _USE_VERTOFFSET, _USE_VERTOFFSETMASK, _UV_ANIMATION,
//   _VAT_SOFTBODY, _VAT_RIGIDBODY, _UNLOAD_ROT_TEX.
// Kept (1:1 base surface + lighting): base PBR (BaseColor tint-cover/brighter, MRO unpack via _BaseTextureMapCount, roughness Min/Max remap,
//   metallic select, occlusion via MRO.b, two-sided normal, DXT5nm normal decode), F0 = lerp(0.08*_Specular, albedo, metallic), diffuse = albedo*(1-metallic),
//   GGX-D + Smith height-correlated Vis + Schlick-F direct light, Karis analytic Env-BRDF (DFG poly), SH ambient, glossy reflection, MixFog.
//   _TWO_BASEMAP + _ALPHATEST_ON closed 1:1 in the shared _core spine. _EMISSIVE_MAP + _EMISSIVE_MASK +
//   _EMISSIVE_NOMAP + _EMISSIVE_ANIM + _EMISSIVE_ANIM_SWEEP closed 1:1 in this file's HLSLINCLUDE
//   (LitEffectEmissive / LitEffectEmissiveModulation). MAP: liteffectblend b11:200,355-357
//   clean Rosetta x-checked vs scrambled liteffect b197. MASK: liteffect b207:162,168-170,187-189 (mask-channel
//   select BaseColorA/NormalMapB/NormalMapA/MROA/NOMAP + [0.05,0.95] remap), selector anchored by b229:239-241
//   (clean `_EmissiveType` for the b207 `_NormalMap_ST.y` slot). NOMAP: flat _EmissiveColor (b211:164-166).
//   ANIM/SWEEP: per-emissive-channel time modulation (1 + EmColor{,G,B,A}.a*mod) + min(max(.,0),1000) clamp,
//   mod = breathing _119 (b213:188-191) / sweep _261 (b215:194-196,206); aliases pinned by formula role (no
//   clean-named sibling exists, cbuffer not in decl order). VFX per-draw overrides (Param2/3/4) folded to identity.
//   _PARALLAX_MAP + _PARALLAX_MAP_WORLDSPACE closed 1:1 (LitEffectParallax/LitEffectWorldParallax): steep-march
//   + Fresnel + _ParallaxColor/Dark lerp + animated breathing + world-XZ pattern (b11:497-1016, clean Rosetta).
//   The optional char-position bright-ring rides VFX global _VFXParams0.xyz but is GATED by _ParallaxCharPos
//   (default 0) -> neutral steady state; only that gated pulse + the host-interpolator _WorldParallaxAdditionalColor
//   interaction term are host-side (omitted neutrally).
//   _DETAIL_MAP closed 1:1 (LitEffectDetail): detail normal RNM-blend + roughness + AO(mode1)/albedo-tint(mode0),
//   gated by a mask-channel * depth-falloff weight. GROUND TRUTH = the ISOLATED single-keyword GBuffer blob
//   liteffect b335 (diffed vs base b185); no clean Rosetta, but the register-collided feature uniforms are pinned
//   by formula role + the clean _Detail* property enum (same recovery as the folded emissive-mask select).
//   _TRI_CHANNEL_MASK closed 1:1 (LitEffectTriChannelMask): 3-channel mask -> per-channel lerp of albedo/
//   roughness/metallic toward _MaskAlbedo/_MaskRoghness/_MaskMetallic{R/G/B} (order B->G->R), weight
//   w_ch = saturate(mask.ch) * _MaskAlbedo{ch}.a, then f0 recomputed. GROUND TRUTH = isolated GBuffer blob
//   liteffect b193 (diffed vs b185) DECODED via the clean-named ForwardLit Rosetta littransparent b58
//   (every _Mask* token clean); the reduced property set's absent offset/contrast are zero-default aliases (identity).
//   _USE_VERTOFFSET texture-driven world-space vertex displacement is CLOSED 1:1 (vertex stage,
//   _core/CoreVertex.hlsl LitEffectVertexOffsetDeltaWS) — ground truth = isolated vertex blob liteffect b234
//   (diffed vs base b188); offset uniforms CB3_m0[19..23] role-decoded against the clean _Offset* property enum.
//   _USE_VERTOFFSETMASK is a verified no-op in the deferred liteffect path (keyword in ZERO liteffect passes;
//   b234 binds only _OffsetTex) — liteffect's only offset mask is the vertex-color-A gate.
//   _UV_ANIMATION vertex uv-scroll is CLOSED 1:1 (vertex stage, _core/CoreVertex.hlsl LitPackAnimatedUV,
//   #ifdef _UV_ANIMATION) — uv0 += _UVAnimationSpeed.xy*_Time.y, uv1 += .zw*_Time.y. Ground truth =
//   keyword-isolated lit/Sub0_Pass0_Vertex_b614.hlsl:564-567 (the four speed coeffs are a contiguous float4
//   at packoffset c19.xyzw, unambiguously _UVAnimationSpeed; HG per-object time _84 -> URP _Time.y, same infra
//   fold as _USE_VERTOFFSET). PASS COVERAGE = strict ground-truth parity (NOT _USE_VERTOFFSET-mirrored): the
//   keyword rides ONLY the surface passes (HGBuffer + its URP forward twin ForwardLit) because lit.shader
//   compiles `multi_compile_local _ _UV_ANIMATION` ONLY in the HGBuffer/surface pass (lit.shader:497) and has
//   ZERO _UV_ANIMATION in the ShadowCaster (:2255-2716) / DepthOnly (:2717-3172) ladders — cast shadow, depth,
//   and the depth-normals prepass therefore sample UN-scrolled uv (surface-uv scroll is GBuffer-only; unlike
//   _USE_VERTOFFSET, which DOES recur in shadow/depth at :2275/:2743 since vertex displacement moves those
//   silhouettes). The Houdini-VAT trio (_VAT_SOFTBODY/_VAT_RIGIDBODY/_UNLOAD_ROT_TEX) is CLOSED 1:1 (vertex
//   stage, _core/CoreVertex.hlsl :: LitEffectApplyVAT, behind LITEFFECT_VAT_PORTED): sample _PositionTexture/
//   _RotationTexture by baked frame index, LDR/HDR remap, quaternion->basis rotation, displace+reorient verts
//   (soft vs rigid vs compressed-rot). Ground truth = isolated vertex blobs b266/b288/b308; soft quaternion math
//   verified bit-exact vs the blob mad-chains. The offline-baked VAT textures + per-vertex VAT UV stream (the
//   uv0.zw/uv1.w id/lifetime + rigid pivot, added to Attributes under the keyword) + bake bounds are DATA the
//   Houdini-VAT/VFX system supplies (same standard as _USE_VERTOFFSET's _OffsetTex). Base path + all features 1:1.
// Removed (pixel-neutral pipeline infra, substituted by URP — CORE_MATH §2.12 / STYLE_BIBLE §2):
//   GPU skinning (BLENDWEIGHTS/BLENDINDICES + ByteAddressBuffer bone palette, b184:222-438) -> GetVertexPositionInputs;
//   octahedral-packed NORMAL.x vertex stream (b184:136-205) -> plain GetVertexNormalInputs;
//   HG dual-frame motion-vector clip output (b184:460-497 / b185:132-143 SV_Target1) -> URP MotionVectors pass (dropped);
//   HG 5-MRT deferred GBuffer (b185:128-185) -> URP native 4-target GBuffer (LitPackGBuffer) or in-fragment forward lighting;
//   IV-clipmap GI -> SampleSH; reflection-probe binning -> GlossyEnvironmentReflection; CSM/ASM atlas -> URP main-light shadow; froxel fog -> MixFog.
//
// NOTE: liteffect's HGBuffer base (b185) is the SAME surface math as the lit family (lit/Sub0_Pass0_Fragment_b281, litforward/Sub0_Pass0_Fragment_b9);
//   per CORE_MATH §0 "lit, liteffect, lithlod share this exact GBuffer/ShadowCaster/DepthOnly architecture". This shader therefore #includes the
//   VERIFIED lit-family core spine (_core/CoreVertex.hlsl + CoreSurface.hlsl + CoreMath.hlsl) — the same files HGRP_Lit_Fix.shader uses (the recipe
//   permits #include for lit-family siblings). The base-blob metallic source aliasing (b185:159 samples via the _BaseColorMap-named sampler but
//   reads MRO.x for metallic) is resolved by CoreSurface as metallic = lerp(MRO.r, _Metallic, saturate(_BaseTextureMapCount-1)) (CORE_MATH §0.3).
//   Texture-channel legend: _MROMap RGB = Metallic, Roughness, Occlusion. _NormalMap DXT5nm (X in .a, Y in .g). _BaseTextureMapCount {Three=0, Two=1, TwoWithNoMetallic=2}.

Shader "HGRP/LitEffect_Fix" {
    Properties {
        // ============================================================
        // Blend-state plumbing (set by CustomEditor / material presets via _SurfaceType; STYLE_BIBLE §6).
        // liteffect HGBuffer/DepthOnly use [_ZTestGBuffer]=4, [_CullMode]=2; opaque defaults.
        // ============================================================
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _Cull ("Render Face", Float) = 2
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 0
        [HideInInspector] _ShadowCullMode ("Shadow Cull Mode", Float) = 2     // liteffect.shader:1377 [_ShadowCullMode]=2
        [HideInInspector] _ShadowBias ("Shadow Bias", Float) = 0              // liteffect.shader:1378 Offset [_ShadowBias]
        [HideInInspector] _StencilRef ("Stencil Ref", Float) = 0
        [HideInInspector] _ZTestGBuffer ("__ztGBuffer", Float) = 4
        [HideInInspector] _PreDepthStencilRef ("Pre-Depth Stencil Ref", Float) = 5

        // ============================================================
        // Core surface / base PBR (always-on, no keyword) — liteffect.shader:4-22
        // ============================================================
        [Enum(Three, 0, Two, 1, TwoWithNoMetallic, 2)] _BaseTextureMapCount ("Base Texture Map Count", Float) = 0
        _BaseColorMap ("Base Color Map", 2D) = "white" {}
        _BaseUVSet ("Base UV Set", Float) = 0
        _BaseColor ("Base Color", Color) = (1, 1, 1, 1)
        _BaseColorTintCover ("Base Color Tint Cover", Range(0, 1)) = 0
        _BaseColorBrighterScale ("Base Color Brighter Scale", Range(1, 3)) = 1
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _MROMap ("MRO Map (Metallic,Roughness,Occlusion)", 2D) = "white" {}
        _BasePbrMapUVSet ("PBR Map UV Set", Float) = 0
        _NormalScale ("Normal Scale", Range(0, 1)) = 1
        [Toggle] _TwoSidedNormal ("Two Sided Normal", Float) = 1
        _Metallic ("Metallic", Range(0, 1)) = 0
        _Specular ("Specular", Range(0, 1)) = 0.5
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1
        _OcclusionStrength ("Occlusion Strength", Range(0, 1)) = 1
        [HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}

        // ============================================================
        // Porosity (no keyword, runtime) — liteffect.shader:23-25
        // ============================================================
        [Header(Porosity)]
        _PorosityFactorX ("Porosity Factor X", Range(-1, 1)) = 0.2
        _PorosityFactorY ("Porosity Factor Y", Range(0, 1)) = 0.4

        // ============================================================
        // Emissive — [_EMISSIVE_MAP/_EMISSIVE_MASK/_EMISSIVE_NOMAP/_EMISSIVE_ANIM/_EMISSIVE_ANIM_SWEEP] liteffect.shader:28-53
        // ============================================================
        [Header(Emissive)]
        [ToggleUI] _EnableEmissiveMap ("Enable Emissive Map", Float) = 0
        [Enum(EmissiveMap, 0, BaseColorA, 1, NormalMapB, 2, NormalMapA, 3, MROA, 4, NOMAP, 5)] _EmissiveMaskChannel ("Emissive Mask Channel", Float) = 0
        _EmissiveUVSet ("Emissive UV Set", Float) = 0
        [Enum(ChannelR, 0, ChannelRGBA, 1)] _EmissiveType ("Emissive Type", Float) = 0
        _EmissiveMap ("Emissive Map", 2D) = "black" {}
        [ToggleUI] _AlbedoAffectEmissive ("Albedo Affect Emissive", Float) = 1
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        [HDR][Gamma] _EmissiveColor ("Emissive Color", Color) = (1, 1, 1, 1)
        [HDR][Gamma] _EmissiveColorG ("Emissive Color G", Color) = (0, 0, 0, 1)
        [HDR][Gamma] _EmissiveColorB ("Emissive Color B", Color) = (0, 0, 0, 1)
        [HDR][Gamma] _EmissiveColorA ("Emissive Color A", Color) = (0, 0, 0, 1)
        [HideInInspector] _EmissiveSpeed ("Emissive Speed", Vector) = (0, 0, 0, 0)
        _EmissiveRemap ("Emissive Remap", Range(1, 2)) = 1
        [Toggle(_EMISSIVE_ANIM)] _EnableEmissiveAnim ("Enable Emissive Anim", Float) = 0
        _EmissiveMapTilling ("Emissive Map Tilling", Range(0.01, 20)) = 1
        _EmissiveAnimSpeed ("Emissive Anim Speed", Range(0, 80)) = 0
        _EmissiveAnimInterval ("Emissive Anim Interval", Range(1, 10)) = 1
        [ToggleUI] _EmissiveAnimRandom ("Emissive Anim Random", Float) = 0
        _EmissiveMinBrightness ("Emissive Min Brightness", Range(0, 0.5)) = 0
        [Toggle(_EMISSIVE_ANIM_SWEEP)] _EnableEmissiveAnimSweep ("Enable Emissive Anim Sweep", Float) = 0
        _EmissiveSweepSpeed ("Emissive Sweep Speed", Range(0.01, 20)) = 3
        _EmissiveSweepInterval ("Emissive Sweep Interval", Range(0.01, 20)) = 3
        _EmissiveSweepWidth ("Emissive Sweep Width", Range(0.01, 10)) = 0.8
        _EmissiveSweepFalloff ("Emissive Sweep Falloff", Range(1, 10)) = 1
        [ToggleUI] _EmissiveSweepRandom ("Emissive Sweep Random", Float) = 0
        _EmissiveSweepAlbedoScale ("Emissive Sweep Albedo Scale", Range(0, 5)) = 0

        // ============================================================
        // Detail — [_DETAIL_MAP] liteffect.shader:54-64
        // ============================================================
        [Header(Detail)]
        [Toggle(_DETAIL_MAP)] _EnableDetailMap ("Enable Detail Map", Float) = 0
        _DetailMap ("Detail Map", 2D) = "bump" {}
        _DetailUVSet ("Detail UV Set", Float) = 0
        [Enum(Normal_Roughness_AlbedoTint, 0, Normal_Roughness_AO, 1)] _DetailMode ("Detail Mode", Float) = 0
        [Enum(AllPass, 0, DetailMapA, 1, BaseColorA, 2, NormalMapB, 3, NormalMapA, 4, MROA, 5)] _DetailMaskMode ("Detail Mask Mode", Float) = 0
        _DetailNormalIntensity ("Detail Normal Intensity", Range(0, 3)) = 1
        _DetailOverlayColor ("Detail Overlay Color", Color) = (0, 0, 0, 0)
        _DetailBaseColorBrighterScale ("Detail Base Color Brighter Scale", Range(1, 3)) = 1
        _DetailPBRIntensity ("Detail PBR Intensity", Range(0, 1)) = 1
        _DetailFalloffStart ("Detail Falloff Start", Range(0, 800)) = 750
        _DetailFalloffEnd ("Detail Falloff End", Range(0, 800)) = 800

        // ============================================================
        // Tri-Channel Mask — [_TRI_CHANNEL_MASK] liteffect.shader:65-76
        // ============================================================
        [Header(Tri Channel Mask)]
        [Toggle(_TRI_CHANNEL_MASK)] _EnableTriChannelMask ("Enable Tri Channel Mask", Float) = 0
        _MaskMap ("Mask Map", 2D) = "black" {}
        _MaskUVSet ("Mask UV Set", Float) = 0
        _MaskAlbedoR ("Mask Albedo R", Color) = (1, 0, 0, 1)
        _MaskRoghnessR ("Mask Roughness R", Range(0, 1)) = 0.25
        _MaskMetallicR ("Mask Metallic R", Range(0, 1)) = 0
        _MaskAlbedoG ("Mask Albedo G", Color) = (0, 1, 0, 1)
        _MaskRoghnessG ("Mask Roughness G", Range(0, 1)) = 0.25
        _MaskMetallicG ("Mask Metallic G", Range(0, 1)) = 0
        _MaskAlbedoB ("Mask Albedo B", Color) = (0, 0, 1, 1)
        _MaskRoghnessB ("Mask Roughness B", Range(0, 1)) = 0.25
        _MaskMetallicB ("Mask Metallic B", Range(0, 1)) = 0

        // ============================================================
        // Disturb / Dissolve (effect) — [_USE_DISTURB/_USE_DISSOLVE] liteffect.shader:77-82,119-133
        // ============================================================
        [Header(Disturb Dissolve)]
        [Toggle(_USE_DISTURB)] _UseDisturb ("Use Disturb", Float) = 0
        [ToggleUI] _Bi_Disturb ("Bi Disturb", Float) = 0
        _DisturbTex ("Disturb Tex", 2D) = "white" {}
        _DisturbUVSpeed ("Disturb UV Speed", Vector) = (0, 0, 0, 0)
        _DisturbUIntensity ("Disturb U Intensity", Float) = 0
        _DisturbVIntensity ("Disturb V Intensity", Float) = 0
        _DisturbWarpScale ("Disturb Warp Scale (c20.x, un-anchored)", Float) = 1
        [Toggle(_USE_DISSOLVE)] _UseDissolve ("Use Dissolve", Float) = 0
        _DissolveEdgeSharp ("Dissolve Edge Sharp", Float) = 0
        _DissolveScheduleOffset ("Dissolve Schedule Offset", Float) = 0
        _DissolveEmissiveEdge ("Dissolve Emissive Edge", Float) = 0
        _DissolveUVSpeed ("Dissolve UV Speed", Vector) = (0, 0, 0, 0)
        [HDR] _DissolveEmissiveColor ("Dissolve Emissive Color", Color) = (0, 0, 0, 1)
        _DissolveTex ("Dissolve Tex", 2D) = "white" {}
        [HideInInspector] _UseScanDissolve ("Use Scan Dissolve", Float) = 0
        _DissolveUVRotate ("Dissolve UV Rotate", Float) = 0
        [ToggleUI] _DissolveTexUseDisturb ("Dissolve Tex Use Disturb", Float) = 0
        _DissolveDir ("Dissolve Dir", Vector) = (0, 0, 0, 0)
        [HideInInspector] _DissolveSpeed ("Dissolve Speed", Vector) = (0, 0, 0, 0)
        _DissolveScanSchedule ("Dissolve Scan Schedule", Float) = -1
        _DissolveScanWidth ("Dissolve Scan Width", Range(0.1, 1)) = 0
        _DissolveEmissiveWidth ("Dissolve Emissive Width", Range(0, 5)) = 0

        // ============================================================
        // Parallax (emissive/worldspace) — [_PARALLAX_MAP/_PARALLAX_MAP_WORLDSPACE] liteffect.shader:83-118
        // ============================================================
        [Header(Parallax)]
        [Toggle(_PARALLAX_MAP)] _EnableParallaxMap ("Enable Parallax Map", Float) = 0
        [Enum(BaseColorA, 0, NormalMapB, 1, NormalMapA, 2, MROA, 3)] _ParallaxMaskChannel ("Parallax Mask Channel", Float) = 0
        [ToggleUI] _UseParallaxMask ("Use Parallax Mask", Float) = 0
        _ParallaxNoiseMap ("Parallax Noise Map", 2D) = "black" {}
        _ParallaxNoiseMapTilling ("Parallax Noise Map Tilling", Range(0.01, 20)) = 1
        _ParallaxMaskMap ("Parallax Mask Map", 2D) = "black" {}
        [Enum(UV0, 0, UV1, 1)] _ParallaxMapUVType ("Parallax Map UV Type", Float) = 0
        _ParallaxMap ("Parallax Map", 2D) = "black" {}
        _ParallaxStrength ("Parallax Strength", Range(0, 1)) = 0
        _ParallaxMarchNum ("Parallax March Num", Range(2, 5)) = 2
        _ParallaxTilling ("Parallax Tilling", Range(0.01, 20)) = 1
        [HDR] _ParallaxColor ("Parallax Color", Color) = (0, 0, 0, 1)
        [HDR] _ParallaxColorDark ("Parallax Color Dark", Color) = (0, 0, 0, 1)
        _ParallaxAnimSpeed ("Parallax Anim Speed", Range(0, 50)) = 0
        [ToggleUI] _ParallaxAnimRandom ("Parallax Anim Random", Float) = 0
        [ToggleUI] _ParallaxCharPos ("Parallax Affected By CharPos", Float) = 0
        _ParallaxBrightOuterRadius ("Parallax Bright Outer Radius", Range(0, 50)) = 20
        _ParallaxBrightInnerRadius ("Parallax Bright Inner Radius", Range(0, 50)) = 10
        _ParallaxBrightStrength ("Parallax Bright Strength", Range(0, 20)) = 1
        _ParallaxMinBrightness ("Parallax Min Brightness", Range(0, 0.5)) = 0
        _ParallaxFresnelStrength ("Parallax Fresnel Strength", Range(0.001, 10)) = 1
        [ToggleUI] _ParallaxMaskByLayerBlend ("Parallax Mask By Layer Blend", Float) = 0
        [ToggleUI] _ParallaxIgnorePostExposure ("Parallax Ignore Post Exposure", Float) = 1
        [Toggle(_PARALLAX_MAP_WORLDSPACE)] _UseWorldSpaceParallaxMask ("Use World Space Parallax Mask", Float) = 0
        [HDR] _ParallaxPatternColor ("Parallax Pattern Color", Color) = (0, 0, 0, 1)
        [HDR] _ParallaxPatternColorDark ("Parallax Pattern Color Dark", Color) = (0, 0, 0, 1)
        _ParallaxMaskMapColorStrength ("Parallax Mask Map Color Strength", Range(0, 20)) = 1
        _ParallaxLerpSchedule ("Parallax Lerp Schedule", Range(0, 30)) = 0
        _MaskWorldPosParams ("Mask World Pos Params", Vector) = (0, 0, 0, 1)
        _ParallaxSignControl ("Parallax Sign Control", Float) = 0
        [HDR] _WorldParallaxAdditionalColor ("World Parallax Additional Color", Color) = (0, 0, 0, 1)
        _WorldParallaxAdditionalLightMaskChannel ("World Parallax Additional Light Mask Channel", Float) = 0
        _ParallaxSignLerpFactor0 ("Parallax Sign Lerp Factor 0", Vector) = (0, 0, 0, 0)
        _ParallaxSignLerpFactor2 ("Parallax Sign Lerp Factor 2", Float) = 0
        _ParallaxSignLerpFactor1 ("Parallax Sign Lerp Factor 1", Vector) = (0, 0, 0, 0)
        _ParallaxIntensity ("Parallax Intensity", Range(0, 1)) = 1

        // ============================================================
        // Vertex Offset — [_USE_VERTOFFSET/_USE_VERTOFFSETMASK] liteffect.shader:134-146
        // ============================================================
        [Header(Vertex Offset)]
        [Toggle(_USE_VERTOFFSET)] _UseVertexOffset ("Use Vertex Offset", Float) = 0
        _OffsetTex ("Offset Tex", 2D) = "white" {}
        _OffsetSpeed ("Offset Speed", Vector) = (0, 0, 0, 0)
        _OffsetDir ("Offset Dir", Vector) = (0, 0, 0, 0)
        [Enum(Object, 0, World, 1, Normal, 2)] _OffsetSwitchDir ("Offset Switch Dir", Float) = 0
        _OffsetIntensity ("Offset Intensity", Float) = 0
        [ToggleUI] _Bi_Offset ("Bi Offset", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _OffsetUVSet ("Offset UV Set", Float) = 0
        [ToggleUI] _UseVertexColorMask ("Use Vertex Color Mask", Float) = 0
        [Toggle(_USE_VERTOFFSETMASK)] _UseVertexOffsetMask ("Use Vertex Offset Mask", Float) = 0
        _OffsetMaskTex ("Offset Mask Tex", 2D) = "white" {}
        _OffsetMaskSpeed ("Offset Mask Speed", Vector) = (0, 0, 0, 0)
        _OffsetMaskPower ("Offset Mask Power", Range(0, 5)) = 0

        // ============================================================
        // Houdini VAT — [_VAT_SOFTBODY/_VAT_RIGIDBODY/_UNLOAD_ROT_TEX] liteffect.shader:147-166,196-202
        // ============================================================
        [Header(Houdini VAT)]
        [Toggle(_VAT_SOFTBODY)] _EnableHoudiniVAT ("Enable Houdini VAT", Float) = 0
        [Enum(RigidBody, 0, SoftBody, 1)] _HoudiniVATType ("Houdini VAT Type", Float) = 0
        [ToggleUI] _HoudiniVATInParticle ("Houdini VAT In Particle", Float) = 0
        [ToggleUI] _B_autoPlayback ("B Auto Playback", Float) = 0
        _gameTimeAtFirstFrame ("Game Time At First Frame", Float) = 0
        _displayFrame ("Display Frame", Float) = 0
        _playbackSpeed ("Playback Speed", Float) = 0
        _houdiniFPS ("Houdini FPS", Float) = 0
        [ToggleUI] _TextureFormat ("Texture Format", Float) = 1
        _PositionTexture ("Position Texture", 2D) = "white" {}
        [ToggleUI] _BlendMeshNormalAndTangent ("Blend Mesh Normal And Tangent", Float) = 0
        [Toggle(_UNLOAD_ROT_TEX)] _B_UNLOAD_ROT_TEX ("Unload Rot Tex", Float) = 0
        _RotationTexture ("Rotation Texture", 2D) = "white" {}
        [ToggleUI] _B_surfaceNormals ("Surface Normals", Float) = 0
        [ToggleUI] _B_twoSidedNorms ("Two Sided Norms", Float) = 0
        [ToggleUI] _B_pscaleAreInPosA ("Pscale Are In PosA", Float) = 0
        _globalPscaleMul ("Global Pscale Mul", Float) = 1
        [ToggleUI] _B_stretchByVel ("Stretch By Vel", Float) = 0
        _stretchByVelAmount ("Stretch By Vel Amount", Float) = 0
        [ToggleUI] _B_animateFirstFrame ("Animate First Frame", Float) = 0
        [HideInInspector] _frameCount ("Frame Count", Float) = 0
        [HideInInspector] _boundMaxX ("Bound Max X", Float) = 0
        [HideInInspector] _boundMaxY ("Bound Max Y", Float) = 0
        [HideInInspector] _boundMaxZ ("Bound Max Z", Float) = 0
        [HideInInspector] _boundMinX ("Bound Min X", Float) = 0
        [HideInInspector] _boundMinY ("Bound Min Y", Float) = 0
        [HideInInspector] _boundMinZ ("Bound Min Z", Float) = 0

        // ============================================================
        // Alpha Test — [_ALPHATEST_ON] liteffect.shader:167-169
        // ============================================================
        [Header(Alpha Test)]
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Enable Alpha Test", Float) = 0
        [Enum(BaseColor_A, 0, NRO_A, 1)] _AlphaMaskChannel ("Alpha Mask Channel", Float) = 0
        _AlphaClipThreshold ("Alpha Clip Threshold", Range(0, 1)) = 0.5

        // ============================================================
        // UV Animation — [_UV_ANIMATION] liteffect.shader:170-171
        // ============================================================
        [Header(UV Animation)]
        [Toggle(_UV_ANIMATION)] _EnableUVAnimation ("Enable UV Animation", Float) = 0
        _UVAnimationSpeed ("UV Animation Speed", Vector) = (0, 0, 0, 0)

        // ============================================================
        // Advanced options / infra (no keyword unless noted) — liteffect.shader:172-202
        // ============================================================
        [Header(Advanced)]
        _DitherScale ("Dither Scale", Range(0, 1)) = 1
        [ToggleUI] _DisableVerticalOcclusion ("Disable Vertical Occlusion", Float) = 0
        _VerticalOcclusionDepthBias ("Vertical Occlusion Depth Bias", Range(0, 0.3)) = 0
        [HideInInspector] _CutOffPosY ("Cut Off Pos Y", Float) = 0
        [HideInInspector] _UseCutOff ("Use Cut Off", Float) = 0
        [HideInInspector] _CutOffDirection ("Cut Off Direction", Vector) = (0, 1, 0, 0)
        [ToggleUI] _EnableInstancing ("Enable Instancing", Float) = 0
        [ToggleUI] _TAAUNormalBiasReverse ("TAAU Normal Bias Reverse", Float) = 0
        [ToggleUI] _ReceiveDecals ("Receive Decals", Float) = 1
        [ToggleUI] _UseSceneEffect ("Use Scene Effect", Float) = 1
        [ToggleUI] _EnableBakedEmissive ("Enable Baked Emissive", Float) = 0
        [HideInInspector] _DirectLightRoughnessOffset ("Direct Light Roughness Offset", Float) = 0
        [HideInInspector] _DitherTransparentAlpha ("Dither Transparent Alpha", Float) = 1
        [HideInInspector] _DitherTransparentOffset ("Dither Transparent Offset", Float) = 0.1
        [HideInInspector] _StencilOpGBuffer ("Stencil Op GBuffer", Float) = 2
        [HideInInspector] _StencilOpPreZ ("Stencil Op PreZ", Float) = 0
        [HideInInspector] _ShadingModel ("Shading Model", Float) = 0
        [HideInInspector] _HlodBakeMaxEmissiveIntensity ("HLOD Bake Max Emissive Intensity", Float) = 0
        [HideInInspector] _UseDeferredRendering ("Use Deferred Rendering", Float) = 1
        [HideInInspector] _TransparentSortPriority ("Transparent Sort Priority", Float) = 0
        // vertex-color opacity gate (CoreSurface reads it; liteffect base has no _Use_VerexTexColorAsOpacity -> default 0 = opaque, b185 has no vertex-color alpha)
        [HideInInspector] _Use_VerexTexColorAsOpacity ("Use Vertex Tex Color As Opacity", Float) = 0

        // ============================================================
        // Environment / Exposure params (HGRP globals re-exposed as material Vectors; URP has no
        // equivalent global — STYLE_BIBLE §1.5 / §2). Ambient + reflection intensity feed (CORE_MATH §2.4/§2.11).
        // ============================================================
        [Header(Environment Params)]
        _EnvironmentGlobalParams0 ("EnvGlobalParams0 (.x=ambient intensity .y=reflection intensity)", Vector) = (1, 1, 1, 0)
        _ExposureParams ("ExposureParams (.x=exposure)", Vector) = (1, 0, 0, 0)
    }

    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Opaque" }
        LOD 600    // liteffect.shader:209

        HLSLINCLUDE
            // ============================================================
            // URP infrastructure (substitutes for all HGRP hand-rolled globals — STYLE_BIBLE §2 / CORE_MATH §2.12).
            // Core.hlsl: UNITY_MATRIX_*, _WorldSpaceCameraPos, unity_ObjectToWorld, GetVertexPositionInputs/NormalInputs,
            //   TransformWorldToHClip, GetWorldSpaceViewDir, ComputeFogFactor, MixFog, _GlobalMipBias + SAMPLE_TEXTURE2D_BIAS,
            //   PackNormalOctQuadEncode/PackFloat2To888 (Packing.hlsl), NormalizeNormalPerPixel.
            // Lighting.hlsl: GetMainLight, GetAdditionalLight(sCount), Light, SampleSH, GlossyEnvironmentReflection,
            //   BRDFData/InitializeBRDFData (used by LitPackGBuffer). Shadows.hlsl: TransformWorldToShadowCoord, ApplyShadowBias.
            // NOTE: SurfaceInput.hlsl deliberately NOT included — it pulls URP's `struct SurfaceData` which COLLIDES with the
            //   shader-local `struct LitSurfaceData` naming guard (that is WHY the surface type is LitSurfaceData, not SurfaceData).
            // ============================================================
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"

            // ============================================================
            // FROZEN UNIFORM INTERFACE — single UnityPerMaterial CBUFFER.
            // Every uniform referenced by the property block + the _core trio appears here exactly once.
            // NO packoffset, NO _at_NNN SPIRV-Cross aliases. Base-path field set (the subset the _core trio reads):
            //   litforward/Sub0_Pass0_Fragment_b9.hlsl:99-126 + lit/Sub0_Pass0_Fragment_b281.hlsl:35-80
            //   (== liteffect/Sub0_Pass0_Fragment_b185.hlsl:35-77 material cbuffer); the rest are liteffect feature uniforms.
            // ============================================================
            CBUFFER_START(UnityPerMaterial)
                // ---- Blend-state plumbing ----
                float _SrcBlend;
                float _DstBlend;
                float _ZTest;
                float _ZWrite;
                float _Cull;
                float _SurfaceType;
                float _ShadowCullMode;
                // _ShadowBias: NOT a UnityPerMaterial field — URP Shadows.hlsl declares a global `float4 _ShadowBias`
                //   (x=depth, y=normal slope). The material property (Properties block) still feeds the ShadowCaster
                //   `Offset [_ShadowBias]` render-state binding; no HLSL here reads it, so the duplicate CBUFFER float
                //   only collided with URP's global (redefinition error). Removed.
                float _StencilRef;
                float _ZTestGBuffer;
                float _PreDepthStencilRef;

                // ---- Core surface / base PBR (CORE_MATH §0.2 ; b185:47-76) ----
                float4 _BaseColor;
                float4 _BaseColorMap_ST;
                float4 _NormalMap_ST;
                float4 _MROMap_ST;
                float _BaseTextureMapCount;
                float _BaseUVSet;
                float _BasePbrMapUVSet;
                float _BaseColorTintCover;
                float _BaseColorBrighterScale;
                float _NormalScale;
                float _TwoSidedNormal;
                float _Metallic;
                float _Specular;
                float _RoughnessMin;
                float _RoughnessMax;
                float _OcclusionStrength;
                float _TAAUNormalBiasReverse;
                float _Use_VerexTexColorAsOpacity;

                // ---- Porosity ----
                float _PorosityFactorX;
                float _PorosityFactorY;

                // ---- Emissive (map/mask/nomap + anim + sweep) ----
                float4 _EmissiveMap_ST;
                float4 _EmissiveColor;
                float4 _EmissiveColorG;
                float4 _EmissiveColorB;
                float4 _EmissiveColorA;
                float4 _EmissiveSpeed;
                float _EmissiveMaskChannel;
                float _EmissiveUVSet;
                float _EmissiveType;
                float _AlbedoAffectEmissive;
                float _IgnorePostExposure;
                float _EmissiveMapTilling;
                float _EmissiveRemap;
                float _EmissiveAnimSpeed;
                float _EmissiveAnimInterval;
                float _EmissiveAnimRandom;
                float _EmissiveMinBrightness;
                float _EmissiveSweepSpeed;
                float _EmissiveSweepInterval;
                float _EmissiveSweepWidth;
                float _EmissiveSweepFalloff;
                float _EmissiveSweepRandom;
                float _EmissiveSweepAlbedoScale;

                // ---- Detail ----
                float4 _DetailMap_ST;
                float4 _DetailOverlayColor;
                float _DetailUVSet;
                float _DetailMode;
                float _DetailMaskMode;
                float _DetailNormalIntensity;
                float _DetailBaseColorBrighterScale;
                float _DetailPBRIntensity;
                float _DetailFalloffStart;
                float _DetailFalloffEnd;

                // ---- Tri-Channel Mask ----
                float4 _MaskMap_ST;
                float4 _MaskAlbedoR;
                float4 _MaskAlbedoG;
                float4 _MaskAlbedoB;
                float _MaskUVSet;
                float _MaskRoghnessR;
                float _MaskMetallicR;
                float _MaskRoghnessG;
                float _MaskMetallicG;
                float _MaskRoghnessB;
                float _MaskMetallicB;

                // ---- Disturb / Dissolve ----
                float4 _DisturbTex_ST;
                float4 _DisturbUVSpeed;
                float4 _DissolveUVSpeed;
                float4 _DissolveEmissiveColor;
                float4 _DissolveTex_ST;
                float4 _DissolveDir;
                float4 _DissolveSpeed;
                float _Bi_Disturb;
                float _DisturbUIntensity;
                float _DisturbVIntensity;
                float _DissolveEdgeSharp;
                float _DissolveScheduleOffset;
                float _DissolveEmissiveEdge;
                float _UseScanDissolve;
                float _DissolveUVRotate;
                float _DissolveTexUseDisturb;
                float _DissolveScanSchedule;
                float _DissolveScanWidth;
                float _DissolveEmissiveWidth;
                // Disturb-warp master scale = the liteffect GBuffer blob's _BaseColorMap_ST_at_320.x slot (b259:229,
                //   register-collided c20.x; .y/.z/.w decode cleanly to _DissolveEdgeSharp/_DissolveScheduleOffset/
                //   _DissolveEmissiveEdge via the littransparent b44 Rosetta, but .x has NO clean-named sibling —
                //   exposed as a real uniform by its UNIQUE formula role: it scales the disturb-texture UV displacement
                //   that warps the dissolve-noise sample. Default 1 = neutral (no extra scale beyond the per-axis
                //   _Disturb{U,V}Intensity). Math stays 1:1: mad(disturb*intensity, _DisturbWarpScale, rotatedDissolveUV).
                float _DisturbWarpScale;

                // ---- Parallax (emissive/worldspace) ----
                float4 _ParallaxMap_ST;
                float4 _ParallaxColor;
                float4 _ParallaxColorDark;
                float4 _ParallaxPatternColor;
                float4 _ParallaxPatternColorDark;
                float4 _WorldParallaxAdditionalColor;
                float4 _MaskWorldPosParams;
                float4 _ParallaxSignLerpFactor0;
                float4 _ParallaxSignLerpFactor1;
                float _ParallaxMaskChannel;
                float _UseParallaxMask;
                float _ParallaxNoiseMapTilling;
                float _ParallaxMapUVType;
                float _ParallaxStrength;
                float _ParallaxMarchNum;
                float _ParallaxTilling;
                float _ParallaxAnimSpeed;
                float _ParallaxAnimRandom;
                float _ParallaxCharPos;
                float _ParallaxBrightOuterRadius;
                float _ParallaxBrightInnerRadius;
                float _ParallaxBrightStrength;
                float _ParallaxMinBrightness;
                float _ParallaxFresnelStrength;
                float _ParallaxMaskByLayerBlend;
                float _ParallaxIgnorePostExposure;
                float _ParallaxMaskMapColorStrength;
                float _ParallaxLerpSchedule;
                float _ParallaxSignControl;
                float _WorldParallaxAdditionalLightMaskChannel;
                float _ParallaxSignLerpFactor2;
                float _ParallaxIntensity;

                // ---- Vertex Offset ----
                float4 _OffsetTex_ST;
                float4 _OffsetSpeed;
                float4 _OffsetDir;
                float4 _OffsetMaskTex_ST;
                float4 _OffsetMaskSpeed;
                float _OffsetSwitchDir;
                float _OffsetIntensity;
                float _Bi_Offset;
                float _OffsetUVSet;
                float _UseVertexColorMask;
                float _OffsetMaskPower;

                // ---- UV Animation ----
                float4 _UVAnimationSpeed;

                // ---- Houdini VAT ----
                float _B_autoPlayback;
                float _gameTimeAtFirstFrame;
                float _displayFrame;
                float _playbackSpeed;
                float _houdiniFPS;
                float _TextureFormat;
                float _BlendMeshNormalAndTangent;
                float _B_surfaceNormals;
                float _B_twoSidedNorms;
                float _B_pscaleAreInPosA;
                float _globalPscaleMul;
                float _B_stretchByVel;
                float _stretchByVelAmount;
                float _B_animateFirstFrame;
                float _HoudiniVATInParticle;
                float _frameCount;
                float _boundMinX;
                float _boundMaxX;
                float _boundMinY;
                float _boundMaxY;
                float _boundMinZ;
                float _boundMaxZ;

                // ---- Alpha Test ----
                float _AlphaMaskChannel;
                float _AlphaClipThreshold;

                // ---- Advanced / infra ----
                float4 _CutOffDirection;
                float _DitherScale;
                float _DisableVerticalOcclusion;
                float _VerticalOcclusionDepthBias;
                float _EnableInstancing;
                float _ReceiveDecals;
                float _UseSceneEffect;
                float _EnableBakedEmissive;
                float _DirectLightRoughnessOffset;
                float _DitherTransparentAlpha;
                float _DitherTransparentOffset;
                float _StencilOpGBuffer;
                float _StencilOpPreZ;
                float _ShadingModel;
                float _HlodBakeMaxEmissiveIntensity;
                float _UseDeferredRendering;
                float _TransparentSortPriority;
                float _UseCutOff;
                float _CutOffPosY;

                // ---- Environment / Exposure (HGRP globals re-exposed; CORE_MATH §2.4/§2.11) ----
                float4 _EnvironmentGlobalParams0;
                float4 _ExposureParams;
            CBUFFER_END

            // ============================================================
            // FROZEN TEXTURE INTERFACE — one decl per line, paired sampler.
            // Base surface set re-identified by usage (CORE_MATH §0.3 ; b185:84-89): T_base=albedo, T_normal=DXT5nm, T_mro=MRO.
            // Wrap modes per CORE_MATH §0.3 (set on the import asset): base=mirror, normal=clamp, MRO=repeat.
            // The feature maps below are declared so the (stubbed) keyword paths + Properties resolve.
            // ============================================================
            TEXTURE2D(_BaseColorMap);     SAMPLER(sampler_BaseColorMap);   // b185:84 albedo (sampler aliased _LinearMirror)
            TEXTURE2D(_NormalMap);        SAMPLER(sampler_NormalMap);      // b185:85 DXT5nm normal (sampler aliased _LinearClamp)
            TEXTURE2D(_MROMap);           SAMPLER(sampler_MROMap);         // b185:86 metallic/roughness/occlusion (sampler aliased _LinearRepeat)
            TEXTURE2D(_EmissiveMap);      SAMPLER(sampler_EmissiveMap);
            TEXTURE2D(_DetailMap);        SAMPLER(sampler_DetailMap);
            TEXTURE2D(_MaskMap);          SAMPLER(sampler_MaskMap);
            TEXTURE2D(_DisturbTex);       SAMPLER(sampler_DisturbTex);
            TEXTURE2D(_DissolveTex);      SAMPLER(sampler_DissolveTex);
            TEXTURE2D(_ParallaxMap);      SAMPLER(sampler_ParallaxMap);
            TEXTURE2D(_ParallaxNoiseMap); SAMPLER(sampler_ParallaxNoiseMap);
            TEXTURE2D(_ParallaxMaskMap);  SAMPLER(sampler_ParallaxMaskMap);
            TEXTURE2D(_OffsetTex);        SAMPLER(sampler_OffsetTex);
            TEXTURE2D(_OffsetMaskTex);    SAMPLER(sampler_OffsetMaskTex);
            TEXTURE2D(_PositionTexture);  SAMPLER(sampler_PositionTexture);   // VAT
            TEXTURE2D(_RotationTexture);  SAMPLER(sampler_RotationTexture);   // VAT

            // ============================================================
            // FROZEN SHARED DATA STRUCTS — populated by the core trio (_core/*.hlsl).
            // ============================================================

            // Vertex input (URP-standard appdata; HG GPU-skin / octahedral-packed normal / MV streams DROPPED
            // per CORE_MATH §0.1/§3.1 — fed plain via GetVertexNormalInputs).
            // Houdini-VAT needs the EXTRA vertex-stream channels the offline VAT bake writes (per-point id /
            // lifetime in uv0.zw + uv1.w, and the per-piece pivot for the rigid path). Widen uv0/uv1 to float4 and
            // add the pivot stream ONLY when a VAT keyword is on (b266/b288/b308 read TEXCOORD.zw / TEXCOORD_1.x/y/w
            // + the rigid pivot in TEXCOORD_2.x/z/w + TEXCOORD_3.x/y). LITEFFECT_VAT_PORTED tells the shared
            // _core/CoreVertex.hlsl that THIS shader (not the plain Lit, whose VAT is an un-ported placeholder)
            // supplies the wide channels, so the VAT math compiles here and stays inert in the Lit sibling.
            #if defined(_VAT_SOFTBODY) || defined(_VAT_RIGIDBODY)
                #define LITEFFECT_VAT_PORTED 1
            #endif

            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;     // vertex color (b184:491-494 passthrough)
            #ifdef LITEFFECT_VAT_PORTED
                float4 uv0        : TEXCOORD0;  // VAT: .zw = in-particle id/lifetime (b266 TEXCOORD.z/.w)
                float4 uv1        : TEXCOORD1;  // VAT: .x = U-id, .y = lifetime, .w = frame id (b266 TEXCOORD_1.x/.y/.w)
                float4 vatPivot2  : TEXCOORD2;  // VAT rigid pivot src A (b288 input TEXCOORD2: .x always, .z/.w in-particle)
                float2 vatPivot3  : TEXCOORD3;  // VAT rigid pivot src B (b288 input TEXCOORD3: .x/.y when NOT in-particle)
            #else
                float2 uv0        : TEXCOORD0;
                float2 uv1        : TEXCOORD1;
            #endif
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            // Interpolators (worldPos + TBN + 2 UV sets + vertex color + view + fog). HG dual-clip MV
            // interpolators (TEXCOORD_5/_6, b184:482-497) DROPPED — URP MotionVectors pass owns them.
            struct Varyings
            {
                float4 positionCS  : SV_Position;
                float3 positionWS  : TEXCOORD0;
                float3 normalWS    : TEXCOORD1;
                float4 tangentWS   : TEXCOORD2;   // .xyz tangent (b184:475-477), .w = sign*handedness (b184:478)
                float4 uv          : TEXCOORD3;   // .xy = raw uv0, .zw = raw uv1 (fragment does UV-set lerp + per-map _ST)
                float4 color       : TEXCOORD4;   // vertex color rgba
                float3 viewDirWS   : TEXCOORD5;   // camera->fragment (perspective) / -view fwd (ortho), unnormalized
                float  fogFactor   : TEXCOORD6;
                UNITY_VERTEX_INPUT_INSTANCE_ID
                UNITY_VERTEX_OUTPUT_STEREO
            };

            // LitSurfaceData — CoreSurface fills the base block; leaf feature modules write the extension fields.
            // NAME must NOT be `SurfaceData` (URP Lighting.hlsl->BRDF.hlsl->SurfaceData.hlsl already declares one;
            // reusing the name is a 'struct type redefinition' compile error — see HLSLINCLUDE NOTE).
            struct LitSurfaceData
            {
                half3  albedo;        // saturate(baseTex*_BaseColor*_BaseColorBrighterScale), tint-covered (b185:152-154,182-184)
                half3  normalWS;      // world normal after TBN + two-sided sign (b185:166-174)
                half   metallic;      // lerp(MRO.r, _Metallic, saturate(_BaseTextureMapCount-1)) (b185:159)
                half   roughness;     // linear roughness = lerp(_RoughnessMin,_RoughnessMax,MRO.g)
                half   occlusion;     // lerp(1, MRO.b, _OcclusionStrength)
                half3  emission;      // emissive contribution (keyword-gated; base = 0)
                half   alpha;         // surface alpha / opacity
                half3  specular;      // dielectric F0 base = 0.08*_Specular (pre-metallic-mix)
                half3  f0;            // lerp(0.08*_Specular, albedo, metallic) — final specular color
                // feature-extension fields (leaf modules write; lighting/composite reads) ---------
                half3  bakedGI;       // SampleSH ambient (set by CoreSurface)
                half3  subsurfaceColor;
                half   subsurfaceMask;
                half   thickness;
                half3  reflectionColor;   // _CUSTOM_IBL / _PLANAR_REFLECTION override (else GlossyEnvironmentReflection)
                half   reflectionWeight;
                half3  matcapColor;
                half3  fresnelColor;
                half3  refractionColor;
                half   coatMask;
                half   shadowExtra;
            };

            // ============================================================
            // VERIFIED LIT-FAMILY CORE SPINE (1:1 ground truth, shared by lit/liteffect/lithlod).
            //   CoreVertex.hlsl  : object->world->clip (GetVertexPositionInputs/NormalInputs) + UV passthrough;
            //                      drops HG skinning/oct-decode/MV — LitVertex/LitShadowVertex/LitDepthVertex/LitDepthNormalsVertex.
            //   CoreSurface.hlsl : base fragment surface assembly (UV-set lerp, 3-map sample, DXT5nm normal + two-sided,
            //                      roughness/metallic/occlusion/albedo tint-cover, F0/diffuse split, SampleSH) -> LitBuildSurface;
            //                      + LitAlphaClip (_ALPHATEST_ON). Cites litforward b9 / lit b281 (== liteffect b185 base).
            //   CoreMath.hlsl    : GGX-D + Smith Vis + Schlick F, Karis Env-BRDF (DFG poly), magic-const table,
            //                      LitForwardLighting (forward composite) + LitPackGBuffer (URP native 4-target GBuffer).
            // Same files HGRP_Lit_Fix.shader includes; the recipe permits #include for lit-family siblings.
            // ============================================================
            // ShadowCaster light vector globals — declared HERE (before CoreVertex.hlsl) because LitShadowVertex
            //   lives in the shared include and reads them; URP's ShadowCasterPass declares the same names, so the
            //   per-pass duplicate is dropped (the include is the single declaration site). Matches STYLE_BIBLE §2
            //   (ShadowCaster declares float3 _LightDirection/_LightPosition + _CASTING_PUNCTUAL_LIGHT_SHADOW).
            float3 _LightDirection;
            float3 _LightPosition;
            #include "_core/CoreVertex.hlsl"
            #include "_core/CoreSurface.hlsl"
            #include "_core/CoreMath.hlsl"

            // ============================================================
            // LITEFFECT FEATURE-MODULE HOOKS (keyword-gated deltas).
            //
            // CLOSED (1:1, shared spine): _TWO_BASEMAP (2-map MRO packing) + _ALPHATEST_ON (alpha clip)
            //   are ported 1:1 in _core/CoreSurface.hlsl. Base path (all feature keywords OFF) is fully 1:1
            //   via the core trio. Source: lit b281 / litforward b9 == liteffect b185.
            //
            // CLOSED HERE (1:1, ported below in LitEffectApplyFeatures):
            //   _EMISSIVE_MAP — emissive sample + R/RGBA route + albedo-affect + post-exposure + remap, added
            //     to s.emission. GROUND TRUTH = the CLEAN-NAMED Rosetta liteffectblend/Sub0_Pass0_Fragment_b11.hlsl
            //     L200,355-357 (real names _EmissiveColor/_EmissiveColorG/B/A/_EmissiveType/_EmissiveRemap/
            //     _AlbedoAffectEmissive/_IgnorePostExposure/_EmissiveSpeed/_EmissiveMap_ST/_EmissiveUVSet),
            //     cross-checked against the ISOLATED single-keyword liteffect/Sub0_Pass0_Fragment_b197.hlsl
            //     L182,200-213 (same math, SPIRV-scrambled aliases — decoded slot-for-slot via b11). The two
            //     blobs agree on every constant/sign/swizzle, so the emissive path is fully recoverable.
            //     VFX per-draw overrides (_unity_Float4x5_Param0.x fade / _Param2 color override / _Param4 mask
            //     intensity / _VFXParams0.w uv-scroll) are UnityPerDraw b1 MaterialPropertyBlock values that a
            //     standalone URP material does NOT bind; they take their DEFAULT (identity) — Param0.x=0 (fade=1),
            //     Param2.w=0 (no override -> _EmissiveColor), Param4.w=0 (no mask remap -> albedo=tint-cover),
            //     _VFXParams0.w=0 (no scroll). Folding them to identity is the defined no-VFX-graph behavior,
            //     NOT a guess (the host VFX system is named below for the one path that genuinely needs it).
            //
            // ENGINE-SIDE / ARTIFACT-GAP (kept as TODO with reason). Distinct from the closeable emissive path:
            //
            //   GAP A — NO CLEAN-NAMED ROSETTA EXISTS (un-decodable register collision). For these features the
            //     ONLY blobs are SPIRV-Cross-scrambled (feature uniforms aliased onto whatever base field shares
            //     the packoffset slot), AND there is no clean-named sibling anywhere in the lit package to decode
            //     the slots against (verified: `_DetailNormalIntensity` / `_MaskAlbedoR` / `_DisturbUVSpeed` real
            //     tokens appear in ZERO blobs across lit/litforward/liteffectblend/littransparent/lithlod). The
            //     liteffectblend Rosetta only covers _EMISSIVE_MAP/_PARALLAX_MAP/_PARALLAX_MAP_WORLDSPACE/_TWO_BASEMAP
            //     (b11 header line 7) — so unlike emissive, the detail/tri-channel/dissolve/disturb/mask-channel
            //     feature-specific slot->property map is unrecoverable from the available artifacts. Decoding base
            //     fields worked (clean lit/litforward siblings); these feature slots have no such anchor.
            //
            //   GAP B — HGRP VFX GLOBAL WORLD-POS (host VFX system required). The parallax char-position bright
            //     term reads `_VFXParams0/2` (ShaderVariablesGlobal b0 c185/187, b11:313-320) — the per-frame
            //     character world position pushed by HG's "HGCharacterVFXManager" global setter. Unlike the
            //     per-draw emissive overrides (which legitimately default to identity), this is a LIVE global the
            //     parallax bright-ring math centers on; with no host writer it is not identity-neutral (the ring
            //     would lock to world origin), so the worldspace bright term is genuinely host-side.
            //
            // CLOSED HERE (1:1): _EMISSIVE_MASK / _EMISSIVE_NOMAP mask-channel select (BaseColorA/NormalMapB/
            //   NormalMapA/MROA/NOMAP) + emissive color/remap. Ported in LitEffectEmissive below.
            //   The earlier "no clean Rosetta" punt was WRONG: the pure _EMISSIVE_MASK blob liteffect b207 shares
            //   the EXACT cbuffer of the already-decoded _EMISSIVE_MAP blob b197/b11 (identical packoffsets), and
            //   the MASK+PARALLAX blob b229:239-241 RETAINS the clean name `_EmissiveType` for the very c21.y slot
            //   that b207 aliases `_NormalMap_ST.y` — anchoring the selector. The channel endpoints are read by
            //   the same usage identification as the core surface (b207 _145=BaseColorMap.a=BaseColorA,
            //   _150.w=MROMap.a=MROA); the folded blob exposes the BaseColorA<->MROA endpoints its material used,
            //   and the URP port reconstructs the full _EmissiveMaskChannel enum select (NormalMapB/A = _NormalMap
            //   .b/.a). Remap window (1/0.9, -0.05/0.9) + 0.1 threshold copied EXACTLY. NOMAP = flat _EmissiveColor
            //   (b211:164-166, no map/mask/remap). VFX Param2 color override + Param4 mask fold to identity (no host
            //   VFX-graph), reducing the masked color to maskScalar*_EmissiveColor — the source standalone state.
            // CLOSED HERE (1:1): _EMISSIVE_ANIM breathing + _EMISSIVE_ANIM_SWEEP sweep — per-emissive-channel
            //   time modulation layered on the _EMISSIVE_MAP path (LitEffectEmissiveModulation + the anim/sweep
            //   branch in LitEffectEmissive). GROUND TRUTH = liteffect/Sub0_Pass0_Fragment_b213.hlsl:188-193,201-202,
            //   226-228 (breathing) / b215.hlsl:194-196,206-208,216-217,232-234 (sweep), diffed against the un-animated
            //   _EMISSIVE_MAP blob b197 to isolate the delta. The "no clean-named sibling" worry held (the anim/sweep
            //   uniforms exist in ZERO blobs tree-wide, and this GBuffer cbuffer is NOT in declaration order so a
            //   positional decode is invalid) — BUT the math is fully recoverable WITHOUT a name map: each scrambled
            //   alias is pinned by its UNIQUE role in the formula (speed multiplies _Time.x; the 1/(2pi) constant;
            //   interval scales the saw; minBright lifts the floor; sweep projects worldPos onto UNITY_MATRIX_V's Y
            //   basis; albedoScale boosts by luma). All constants/signs/branch-bounds copied EXACTLY; the per-channel
            //   breath factor (1 + EmissiveColor{,G,B,A}.a*mod) + the anim-only min(max(.,0),1000) clamp are 1:1.
            //   Sweep time uses URP _TimeParameters.x (continuous) where HG read .w (non-standard in URP); the lone
            //   VFX per-draw input _unity_Float4x5_Param3.z folds to its identity default 1 (same no-VFX-graph fold
            //   as Param0/2/4) -> sweep mod = lumBoost-1, the un-emitted standalone state.
            // CLOSED HERE (1:1): _DETAIL_MAP detail normal (RNM blend) / roughness / AO / albedo-tint blend —
            //   ported in LitEffectDetail below. GROUND TRUTH = the ISOLATED single-keyword GBuffer blob
            //   liteffect/Sub0_Pass0_Fragment_b335.hlsl (liteffect.shader:1038 the `&& defined(_DETAIL_MAP) &&
            //   !SRP_INSTANCING_ON` branch, all other feature keywords OFF), diffed against the base blob b185 to
            //   isolate the delta. The b335 feature uniforms register-collide onto base names (_BaseColorMap_ST_at_320
            //   c20 / _NormalMap_ST c21 / _Dissolve* c19/c22) and there is NO clean-named Rosetta — but every alias
            //   is recovered by its UNIQUE formula role + the clean property enum (liteffect.shader:54-64), the SAME
            //   way the folded emissive-mask channel select was rebuilt (full decode table in LitEffectDetail header).
            //   Math/constants/signs/branch-bounds copied EXACTLY; the GBuffer-packing MRT slots map to the forward
            //   LitSurfaceData channels (CORE_MATH §1.2-1.4). The one routing judgment (AO mode multiplies b335's
            //   VAT-gated occlusion slot SV_Target_2.y, which is VAT-neutral) is applied to the forward occlusion
            //   source mro.z with the EXACT same factor — flagged in the function header.
            // CLOSED HERE (1:1): _TRI_CHANNEL_MASK 3-channel albedo/roughness/metallic remap — ported in
            //   LitEffectTriChannelMask below. GROUND TRUTH = isolated GBuffer blob liteffect b193
            //   (liteffect.shader:825-827, diffed vs base b185) for the routing, DECODED via the clean-named
            //   ForwardLit Rosetta littransparent b58 (littransparent.shader:420-422) which keeps every _MaskAlbedo*/
            //   _MaskRoghness*/_MaskMetallic* token clean. The b193 alias scramble IS recovered: each channel does
            //   w_ch = saturate(mask.ch) * _MaskAlbedo{ch}.a, then albedo/metallic/roughness each take 3 lerps
            //   (B->G->R) toward the per-channel mask targets; f0 recomputed. The reduced liteffect/littransparent
            //   property set exposes no per-channel offset/contrast (b58's `_MaskROffset`/contrast slots are
            //   zero-default aliases -> identity remap) — earlier "no clean-named Rosetta" punt was wrong.
            // CLOSED HERE (1:1): _PARALLAX_MAP / _PARALLAX_MAP_WORLDSPACE steep-parallax march + emissive pattern.
            //   The march loop + Fresnel + _ParallaxColor/Dark lerp + animated breathing + _MaskWorldPosParams
            //   world-pattern projection + sign-control pattern blend are ALL clean-named in the Rosetta
            //   liteffectblend/Sub0_Pass0_Fragment_b11.hlsl:527-1016 (every _Parallax* token clean — verified the
            //   liteffect property set is identical), cross-checked vs the isolated liteffect b219:508-798 (plain
            //   march, scrambled names). Ported 1:1 in LitEffectParallax/LitEffectWorldParallax below; the result
            //   adds to s.emission exactly as b219:346 (plain: parallaxEm*_ParallaxIntensity) / b11:355-357
            //   (worldspace: + _1182*pattern*_ParallaxIntensity). The ONLY host-VFX input is the OPTIONAL
            //   char-position bright-ring (_VFXParams0.xyz emitter pos), GATED by _ParallaxCharPos (default 0) ->
            //   neutral; with no host writer it contributes 0, i.e. the source's un-pulsed steady state — NOT a
            //   feature drop. The worldspace interaction signal (b11 TEXCOORD_4.x, HG interaction interpolator not
            //   on a URP mesh) defaults 0 -> schedule-only steady pattern (b11:341-342). Earlier GAP-B punt was
            //   wrong: the march/pattern is pure material math, only the gated pulse is host-side.
            // CLOSED HERE (1:1): _USE_DISSOLVE dissolve clip + emissive-edge + albedo-fade (+ _USE_DISTURB UV warp) —
            //   ported in LitEffectDisturbDissolve below. GROUND TRUTH = isolated single-keyword GBuffer blob liteffect
            //   b239 (liteffect.shader:924, diffed vs base b185), DECODED via the CLEAN-NAMED Rosetta littransparent b44
            //   (which keeps every _Dissolve* token clean: cbuffer 154-187, dissolve math 441-445/495) — the earlier
            //   "_Dissolve* slots un-anchored" punt was WRONG, b44 IS the anchor and pins every c20.y/.z/.w alias slot-for-
            //   slot (_DissolveEdgeSharp/_DissolveScheduleOffset/_DissolveEmissiveEdge), _NormalMap_ST.xyz=_DissolveDir,
            //   _OffsetTex_ST.xyz=_DissolveEmissiveColor. The _USE_DISTURB UV-warp delta (b259 vs b239, b259:211-229) is
            //   formula-role decoded (NO blob keeps clean _Disturb* names, same as the emissive-anim aliases); its sole
            //   un-nameable constant c20.x is exposed as the real uniform _DisturbWarpScale (default 1). The GBuffer's
            //   depth->WS reconstruction (b239:191-193,199) is the INFRA substitute for IN.positionWS (forward has it
            //   directly); MRT0 emission/MRT4 albedo/discard map to s.emission/s.albedo/clip() per CORE_MATH §1.4.
            //   NOTE: _USE_DISTURB standalone is a VERIFIED no-op in the deferred liteffect path (b232==b196 vertex,
            //   b233==b197 fragment byte-identical; no _USE_DISTURB+_PARALLAX-only branch exists) — it ONLY warps the
            //   dissolve sample UV (the _DissolveTexUseDisturb feature), so the #ifdef _USE_DISTURB lives INSIDE the
            //   _USE_DISSOLVE guard exactly as the source ladder only ever co-defines them meaningfully.
            // CLOSED (1:1, vertex stage — _core/CoreVertex.hlsl LitEffectVertexOffsetDeltaWS + wired into
            //   LitFillCameraVaryings/LitShadowVertex): _USE_VERTOFFSET texture-driven world-space displacement.
            //   GROUND TRUTH = the ISOLATED single-keyword vertex blob liteffect/Sub0_Pass0_Vertex_b234.hlsl
            //   (liteffect.shader:328-330, _USE_VERTOFFSET on / all other feature keywords off), diffed vs base
            //   b188 to lift the delta. Sample _OffsetTex.x at lerp(uv0,uv1,_OffsetUVSet)*_OffsetTex_ST +
            //   _OffsetSpeed*time, remap tex*(1+_Bi_Offset)-_Bi_Offset, build a WORLD dir per _OffsetSwitchDir
            //   (Object=ObjectToWorld*_OffsetDir / World=_OffsetDir / Normal=normalWS) * _OffsetIntensity,
            //   gate by vertex-color.A (_UseVertexColorMask), add to positionWS (b234:484-487). The earlier
            //   "no anchor" GAP-A punt was WRONG: the offset uniforms (ParamBlob CB3_m0[19..23]) decode cleanly
            //   by formula role + the clean property enum (_OffsetSwitchDir Object/World/Normal, _Bi_Offset, …),
            //   the SAME recovery already accepted here for _DETAIL_MAP / _TRI_CHANNEL_MASK / _USE_DISSOLVE.
            //   INFRA fold (documented in the module header): HG `_TimeParameters.w` time channel -> URP `_Time.y`
            //   (continuous seconds; the scroll is speed*time so .w is HG's continuous-time channel, not deltaTime).
            //   The per-draw `_297 = 1 - unity_ObjectToWorld._m01` displacement multiplier (b234:178,485-487) is
            //   reproduced EXACTLY (unity_ObjectToWorld is a URP Core.hlsl global; =1 only for axis-aligned draws,
            //   so folding to 1.0 would drift magnitude on rotated instances — NOT folded).
            //   NOTE: _USE_VERTOFFSETMASK is a NO-OP in the deferred liteffect path — its `[Toggle]` property
            //   exists but the keyword is NOT in any liteffect pass's `#pragma multi_compile_local` (verified:
            //   the token appears in the liteffect ladder ZERO times; only lit.shader compiles it, lines 482/
            //   2276/2744), and the isolated VERTOFFSET vertex blob b234 declares ONLY T1=_OffsetTex (no mask
            //   texture). So liteffect's vertex offset has exactly ONE mask path: the vertex-color-A gate above.
            //   The `_OffsetMaskTex/_OffsetMaskSpeed/_OffsetMaskPower` properties stay declared (Properties +
            //   CBUFFER) for material/inspector parity but are not sampled (no liteffect variant binds them).
            // CLOSED (1:1, vertex stage — _core/CoreVertex.hlsl LitPackAnimatedUV(), #ifdef _UV_ANIMATION; the
            //   surface-pass OUTPUT uv writes route through it, raw LitPackUV stays on the _USE_VERTOFFSET sample
            //   sites which must read UN-scrolled uv per b234): _UV_ANIMATION per-UV-set scroll.
            //   GROUND TRUTH = the keyword-ISOLATED vertex blob lit/Sub0_Pass0_Vertex_b614.hlsl:564-567 (the
            //   `_UV_ANIMATION` variant; lit.shader:497 is the ONLY `#pragma multi_compile_local _ _UV_ANIMATION`
            //   in the whole tree — liteffect folds the `[Toggle]` away as never-enabled, so its base b184:487-490
            //   passes uv straight through). The scroll is uv0 += _UVAnimationSpeed.xy*t, uv1 += _UVAnimationSpeed
            //   .zw*t (mad(speed,_84,uv)). The four speed coeffs are CONTIGUOUS at packoffset c19.xyzw (b614:94-97)
            //   = one float4 _UVAnimationSpeed (liteffect.shader:171 ".xy 1st set / .zw 2nd set"); the decompiler's
            //   per-float aliases (_OffsetSwitchDir/_CommonVAT*) are recovered by formula role + the clean property
            //   (.xy->uv0/.zw->uv1) — the SAME GAP-A role-decode already accepted for _USE_VERTOFFSET / _DETAIL_MAP
            //   / _TRI_CHANNEL_MASK / _USE_DISSOLVE; the earlier "no clean-named reference" punt was WRONG (the slot
            //   is a contiguous float4, unambiguously _UVAnimationSpeed). INFRA fold: HG `_84` (b614:214 = a per-
            //   object instancing-buffer + MotionVectorsParams continuous time) -> URP `_Time.y` (continuous seconds;
            //   scroll is speed*time, not deltaTime) — the IDENTICAL HG-time substitution used for _USE_VERTOFFSET
            //   (CoreVertex.hlsl:79-81) / disturb / emissive-anim (:820-821). PASS COVERAGE = strict ground-truth
            //   parity: the keyword is on ONLY the surface passes (HGBuffer + its URP forward twin ForwardLit). The
            //   ground truth lit.shader compiles `multi_compile_local _ _UV_ANIMATION` ONLY in the HGBuffer/surface
            //   pass (lit.shader:497); its ShadowCaster (:2255-2716) and DepthOnly (:2717-3172) ladders carry ZERO
            //   _UV_ANIMATION branches, so cast shadow / depth / depth-normals sample UN-scrolled uv. This DIFFERS
            //   from _USE_VERTOFFSET (which IS in the shadow/depth ladders at :2275/:2743, because a displaced vertex
            //   moves the shadow & depth silhouette) — a surface-uv scroll does not, so it must NOT be mirrored to
            //   shadow/depth. (Earlier all-5-pass coverage was an OVER-REACH and was removed.)
            // _VAT_SOFTBODY / _VAT_RIGIDBODY / _UNLOAD_ROT_TEX Houdini-VAT position/rotation-texture vertex
            //   animation is PORTED 1:1 (VERTEX stage) in _core/CoreVertex.hlsl :: LitEffectApplyVAT (wired into
            //   LitFillCameraVaryings + LitShadowVertex behind LITEFFECT_VAT_PORTED, like _USE_VERTOFFSET). Ground
            //   truth: liteffect/Sub0_Pass0_Vertex_b266.hlsl (softbody, liteffect.shader:376-378),
            //   _b288.hlsl (rigidbody, :409-411), _b308.hlsl (softbody+unload, :439-441). The shader MATH (sample
            //   _PositionTexture/_RotationTexture by baked frame index, LDR<->HDR remap, quaternion->basis rotate,
            //   displace+reorient) is fully expressible and ported; the offline-baked textures + per-vertex VAT UV
            //   stream + bake bounds are DATA the VFX/Houdini-bake system supplies (same standard as _USE_VERTOFFSET's
            //   _OffsetTex). Two per-draw VFX values fold to their no-VFX-graph identity: HG clock _VFXParams0.w ->
            //   _Time.y, per-draw frame override _unity_Float4x5_Param3.x -> 0 (the SAME fold the emissive/parallax
            //   modules use). The softbody quaternion->basis math is VERIFIED bit-exact vs the blob's mad-chains
            //   (rotate(q,+Y)==b266 _1029-1031, rotate(q,-X)==b266 _866-868); the rigidbody pivot/+1-z offset is
            //   transcribed literally from b288:627-635, the compressed smallest-three quaternion octant switch from
            //   b288:584-626.
            //
            // Locals the emissive module reads from the surface assembly are recomputed here (the module runs
            // AFTER LitBuildSurface, so it re-derives uvBase/duv + tint-covered albedo identically to b9:282-299).
            // ============================================================

#if defined(_EMISSIVE_ANIM) || defined(_EMISSIVE_ANIM_SWEEP)
            // -------------------------------------------------------------------------------------
            // LitEffectEmissiveModulation — the time-driven emissive scalar that the per-channel breath
            //   factor (1 + _EmissiveColor{,G,B,A}.a * mod) is built from. EXACTLY one of the two keywords is
            //   active (editor ConflictIf, liteffect.shader:41,47 -> verified mutually exclusive: zero ladder
            //   branches co-define _EMISSIVE_ANIM && _EMISSIVE_ANIM_SWEEP). Returns `mod` in [minBright-1, 0]
            //   for breathing / [-1, boosted] for sweep, matching the source `_119` (b213) / `_261` (b215).
            //
            //   Param decode is by MATH SEMANTICS + property range (no clean-named Rosetta exists for the anim/
            //   sweep uniforms — verified: _EmissiveAnimSpeed/_EmissiveSweep* appear in ZERO blobs across the whole
            //   com.hg.render-pipelines tree; the GBuffer cbuffer is NOT in declaration order, so positional decode
            //   is invalid). Each scrambled alias is pinned by its unique role in the formula:
            //     b213 (breathing): _ParallaxBrightInnerRadius == _EmissiveAnimSpeed (x SPEED, multiplies _Time.x),
            //       _DissolveScanWidth_at_460 == _EmissiveAnimInterval (saw plateau), _DissolveScanSchedule_at_456
            //       == _EmissiveMinBrightness (floor lift), _DissolveUVRotate_at_448 == _EmissiveAnimRandom (phase).
            //     b215 (sweep): _DissolveUVRotate_at_464 == _EmissiveSweepSpeed, _ParallaxBrightInnerRadius ==
            //       _EmissiveSweepInterval (period divisor), _DissolveScanSchedule_at_456 == _EmissiveSweepWidth
            //       (band half-width denom), _DissolveScanWidth_at_460 == _EmissiveSweepFalloff (edge hardness),
            //       _DissolveEdgeSharp_at_468 == _EmissiveSweepAlbedoScale (luma boost), _DissolveUVRotate_at_448
            //       == _EmissiveSweepRandom (phase). The shared c28.y slot is _EmissiveAnimSpeed under ANIM and
            //       _EmissiveSweepInterval under SWEEP — the two keywords never coexist, so the reuse is sound.
            // -------------------------------------------------------------------------------------
            float LitEffectEmissiveModulation(Varyings IN, float3 tintCoveredAlbedo)
            {
            #if defined(_EMISSIVE_ANIM)
                // ---- BREATHING (1:1, source = liteffect/Sub0_Pass0_Fragment_b213.hlsl:188-191) ----
                // 0.15915493667125701904296875 == 1/(2*PI): time -> phase. saw = clamp(frac(t*speed/2pi + rand)*interval,0,1).
                float saw = mad(_Time.x * _EmissiveAnimSpeed, 0.15915493667125701904296875, _EmissiveAnimRandom);  // b213:188 inner mad
                float tri = mad(clamp(frac(saw) * _EmissiveAnimInterval, 0.0, 1.0), 2.0, -1.0);                     // b213:188 -> [-1,1]
                float tri2 = tri * tri;                                                                             // b213:189 (_98)
                float k = 1.0 - _EmissiveMinBrightness;                                                             // b213:190 (_115)
                // bump = 1 - 6*tri^2 + 4*|tri|^3 (smooth pulse +1 center -> -1 edge); abs(tri*tri2)=|tri|^3.
                float bump = mad(tri2, -6.0, abs(tri * tri2) * 4.0) + 1.0;                                          // b213:191 inner
                // remap pulse so floor lifts to minBright: mod in [minBright-1, 0]. EXACT b213:191.
                float mod = mad((((1.0 + _EmissiveMinBrightness) / k) + bump) * k, 0.5, -1.0);                      // b213:191 (_119)
                return mod;
            #else // _EMISSIVE_ANIM_SWEEP
                // ---- SWEEP (1:1, source = liteffect/Sub0_Pass0_Fragment_b215.hlsl:194,196,206) ----
                // Object origin (camera-relative WS) — same access the parallax path uses (b215:194,196 [3u].x/.y/.z).
                float3 objOrigin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);
                // Scrolling scan position: (speed*originX + time)/interval, then frac toward 0 (sign-preserving).
                //   _TimeParameters.x is the continuous time URP guarantees (HG used _TimeParameters.w as its time
                //   accumulator; .w is not standardized in URP so the continuous .x is the faithful infra substitute).
                float scan = mad(_EmissiveSweepSpeed, objOrigin.x, _TimeParameters.x) / _EmissiveSweepInterval;     // b215:194 (_91)
                float fr   = frac(abs(scan));                                                                       // b215:195 (_96)
                float triWave = (scan >= -scan) ? fr : -fr;                                                         // b215:196 sign(scan)*frac(|scan|)
                // World position projected onto the view-Y basis (the moving band axis) about the object origin.
                float3 dPos = IN.positionWS - objOrigin;                                                            // b215:196 (pos - origin)
                float posProj = mad(UNITY_MATRIX_V._m21, dPos.z,
                                mad(UNITY_MATRIX_V._m01, dPos.x, dPos.y * UNITY_MATRIX_V._m11));                     // b215:196 (_ViewMatrix[2/0/1].y rows)
                // band distance: |(-(triWave*interval - 0.3*interval))*rand + posProj| / width, clamped.
                float band = mad(-mad(triWave, _EmissiveSweepInterval, -(0.300000011920928955078125 * _EmissiveSweepInterval)),
                                 _EmissiveSweepRandom, posProj);                                                    // b215:196 inner mad
                float scanT = clamp(abs(band) / _EmissiveSweepWidth, 0.0, 1.0);                                     // b215:196 (clamp(|band|/width))
                // falloff ramp: clamp(falloff*(1-scanT), 0, 1) == clamp(mad(-scanT, falloff, falloff),0,1).
                float ramp = clamp(mad(-scanT, _EmissiveSweepFalloff, _EmissiveSweepFalloff), 0.0, 1.0);            // b215:196 (_161)
                // albedo-luminance edge boost: max(mad(albedoScale, dot(albedo,0.333)-0.2, 0.2)*5, 0) * ramp^2.
                float lumBoost = max(mad(_EmissiveSweepAlbedoScale,
                                         dot(tintCoveredAlbedo, 0.333000004291534423828125.xxx) + (-0.20000000298023223876953125),
                                         0.20000000298023223876953125) * 5.0, 0.0) * (ramp * ramp);                 // b215:206 inner
                // _unity_Float4x5_Param3.z is a VFX per-draw MaterialPropertyBlock value (no host VFX graph here);
                //   its identity default is 1 (the no-override mask scale, same family as Param0/2/4 above), so the
                //   final mad reduces to mod = lumBoost - 1, matching an un-emitted standalone material.
                float mod = lumBoost - 1.0;                                                                         // b215:206 (_261) with Param3.z=1
                return mod;
            #endif
            }
#endif

            // -------------------------------------------------------------------------------------
            // LitEffectEmissive — _EMISSIVE_MAP delta. 1:1, source = liteffectblend/Sub0_Pass0_Fragment_b11.hlsl:200,355-357
            //   (cross-checked liteffect/Sub0_Pass0_Fragment_b197.hlsl:182,200-213). Adds to s.emission.
            // VFX per-draw overrides folded to their standalone (no-VFX-graph) identity defaults (documented above).
            // _EMISSIVE_ANIM / _EMISSIVE_ANIM_SWEEP layer a per-channel time modulation onto the _EMISSIVE_MAP path
            //   (the keyword ladder ALWAYS pairs anim/sweep with _EMISSIVE_MAP — verified every positive
            //   _EMISSIVE_ANIM[_SWEEP] branch also defines _EMISSIVE_MAP, liteffect.shader:295,571,855,858,1131).
            // -------------------------------------------------------------------------------------
            void LitEffectEmissive(inout LitSurfaceData s, Varyings IN)
            {
            #if defined(_EMISSIVE_MAP) || defined(_EMISSIVE_MASK) || defined(_EMISSIVE_NOMAP)
                // ---- emissive base color `emisColor` (per-mode), then the SHARED tail (albedo-affect +
                //      post-exposure + fade + remap). The three modes are mutually exclusive (editor enum);
                //      precedence MAP > MASK > NOMAP matches the source blob #if/#elif order.
                float3 emisColor;
                // _EmissiveRemap is applied as the final scalar multiply in MAP/NOMAP; MASK folds the
                //   masked-channel scalar into emisColor and ALSO multiplies _EmissiveRemap at the tail.
                float remapMul = _EmissiveRemap;
            #endif

            #if defined(_EMISSIVE_MAP)
                float2 uv0 = IN.uv.xy;                         // b11 TEXCOORD_1
                float2 uv1 = IN.uv.zw;                         // b11 TEXCOORD (uv set 1)
                float duvX = uv1.x - uv0.x;                    // b11:187 (_253)
                float duvY = uv1.y - uv0.y;                    // b11:188 (_254)

                // emissive UV: (uv0 + _EmissiveUVSet*duv)*_EmissiveMap_ST.xy + .zw  + _EmissiveSpeed.xy*scroll.
                // b11:200 — the _EmissiveSpeed*_VFXParams0.w scroll is the per-draw VFX time (=0 standalone).
                float2 uvEmis = float2(
                    mad(mad(_EmissiveUVSet, duvX, uv0.x), _EmissiveMap_ST.x, _EmissiveMap_ST.z),
                    mad(mad(_EmissiveUVSet, duvY, uv0.y), _EmissiveMap_ST.y, _EmissiveMap_ST.w));
                float4 emis = SAMPLE_TEXTURE2D_BIAS(_EmissiveMap, sampler_EmissiveMap, uvEmis, 0.0);  // b11:200 (_375); URP auto-adds _GlobalMipBias.x

                // ---- emissive color pick: R-channel base color, blended with G/B/A channel colors when
                //      _EmissiveType selects RGBA (b11:355). With Param2.w=0 (no VFX color override) the
                //      base color term reduces to _EmissiveColor; keep the full mad() form for exactness.
                //   colorR.c = mad( _EmissiveColor.c, emis.r,
                //                   (mad(_EmissiveColorA.c, emis.a, mad(_EmissiveColorG.c, emis.g, emis.b*_EmissiveColorB.c))) * _EmissiveType )
            #if defined(_EMISSIVE_ANIM) || defined(_EMISSIVE_ANIM_SWEEP)
                // ===== _EMISSIVE_ANIM / _EMISSIVE_ANIM_SWEEP: per-emissive-channel time modulation. =====
                // 1:1, source = liteffect/Sub0_Pass0_Fragment_b213.hlsl:192-193,201-202,226-228 (breathing) /
                //              liteffect/Sub0_Pass0_Fragment_b215.hlsl:207-208,216-217,232-234 (sweep).
                // Each of the four emissive-map channels {R=emis.x, G=emis.y, B=emis.z, A=emis.w} is scaled by
                //   f_c = mad(_EmissiveColor{,G,B,A}.a, mod, 1) = 1 + emissiveColor_c.alpha * mod   (b213 _125/_130/_249/_254).
                //   mod is the breathing/sweep scalar (LitEffectEmissiveModulation). When mod=0 (center/no anim)
                //   every f_c==1 and this reduces EXACTLY to the un-animated _EMISSIVE_MAP form below.
                float mod = LitEffectEmissiveModulation(IN, s.albedo);    // b213 _119 / b215 _261
                float fR = mad(_EmissiveColor.w,  mod, 1.0);              // b213:192 (_125)  R-channel breath
                float fG = mad(_EmissiveColorG.w, mod, 1.0);             // b213:193 (_130)  G-channel breath
                float fB = mad(_EmissiveColorB.w, mod, 1.0);             // b213:201 (_249)  B-channel breath
                float fA = mad(_EmissiveColorA.w, mod, 1.0);             // b213:202 (_254)  A-channel breath
                // R term carries fR; the type-gated (G+B+A) carry their own factors. EXACT b213:226-228 nesting:
                //   mad(fA*emis.w*ColA, type, mad(fB*emis.z*ColB, type, mad(emis.x*ColR, fR, fG*emis.y*ColG*type))).
                // Then the summed emissive is clamped min(max(.,0),1000) — a clamp present ONLY in the anim/sweep
                //   variants (b197 base has none); it bounds the breath-scaled sum before the shared albedo/exposure tail.
                emisColor.x = min(max(mad(fA * (emis.w * _EmissiveColorA.x), _EmissiveType,
                                      mad(fB * (emis.z * _EmissiveColorB.x), _EmissiveType,
                                      mad(emis.x * _EmissiveColor.x, fR, (fG * (emis.y * _EmissiveColorG.x)) * _EmissiveType))), 0.0), 1000.0);
                emisColor.y = min(max(mad(fA * (emis.w * _EmissiveColorA.y), _EmissiveType,
                                      mad(fB * (emis.z * _EmissiveColorB.y), _EmissiveType,
                                      mad(emis.x * _EmissiveColor.y, fR, (fG * (emis.y * _EmissiveColorG.y)) * _EmissiveType))), 0.0), 1000.0);
                emisColor.z = min(max(mad(fA * (emis.w * _EmissiveColorA.z), _EmissiveType,
                                      mad(fB * (emis.z * _EmissiveColorB.z), _EmissiveType,
                                      mad(emis.x * _EmissiveColor.z, fR, (fG * (emis.y * _EmissiveColorG.z)) * _EmissiveType))), 0.0), 1000.0);
            #else
                emisColor.x = mad(_EmissiveColor.x, emis.x, mad(_EmissiveColorA.x, emis.w, mad(_EmissiveColorG.x, emis.y, emis.z * _EmissiveColorB.x)) * _EmissiveType);
                emisColor.y = mad(_EmissiveColor.y, emis.x, mad(_EmissiveColorA.y, emis.w, mad(_EmissiveColorG.y, emis.y, emis.z * _EmissiveColorB.y)) * _EmissiveType);
                emisColor.z = mad(_EmissiveColor.z, emis.x, mad(_EmissiveColorA.z, emis.w, mad(_EmissiveColorG.z, emis.y, emis.z * _EmissiveColorB.z)) * _EmissiveType);
            #endif

            #elif defined(_EMISSIVE_MASK)
                // =====================================================================================
                // _EMISSIVE_MASK — emissive intensity is a SELECTED CHANNEL of an existing map (no separate
                //   EmissiveMap), remapped + thresholded, then multiplied by the flat _EmissiveColor.
                // 1:1, source = liteffect/Sub0_Pass0_Fragment_b207.hlsl:162,168-170,187-189 (pure _EMISSIVE_MASK
                //   blob), cross-checked vs b229:231,239-241,396 / b209:158-164 (which retain the CLEAN name
                //   `_EmissiveType` for the c21.y selector slot the b207 ParamBlob aliases as `_NormalMap_ST.y`).
                // Channel set (b207 _145=BaseColorMap.a, _150.w=MROMap.a) + the _EmissiveMaskChannel enum
                //   {EmissiveMap=0, BaseColorA=1, NormalMapB=2, NormalMapA=3, MROA=4, NOMAP=5}: the compiled blob
                //   constant-folds the selector to the BaseColorA<->MROA endpoints its material used (lerp by
                //   saturate(sel-2)); the URP port reconstructs the FULL runtime select so all enum values work.
                //   The NormalMapB/A endpoints (T1.b/T1.a in usage) are the only channels the available folded
                //   variants did not emit; sourced from _NormalMap by the same usage identification as the core
                //   surface (T0=BaseColor, T1=Normal, T2=MRO — CORE_MATH §0.3, usage-authoritative).
                // =====================================================================================
                // Re-derive uvBase/uvPbr exactly as CoreSurface (the module runs AFTER LitBuildSurface).
                float2 uv0 = IN.uv.xy;                         // b207 TEXCOORD_1
                float2 uv1 = IN.uv.zw;                         // b207 TEXCOORD
                float duvX = uv1.x - uv0.x;                    // b207:157 (_90)
                float duvY = uv1.y - uv0.y;                    // b207:158 (_91)
                float2 uvBase = float2(
                    mad(mad(_BaseUVSet,       duvX, uv0.x), _BaseColorMap_ST.x, _BaseColorMap_ST.z),
                    mad(mad(_BaseUVSet,       duvY, uv0.y), _BaseColorMap_ST.y, _BaseColorMap_ST.w));   // b207:161 (BaseColor uv; _TextureFormat alias == _BaseUVSet)
                float2 uvPbr = float2(
                    mad(mad(_BasePbrMapUVSet, duvX, uv0.x), _NormalMap_ST.x, _NormalMap_ST.z),
                    mad(mad(_BasePbrMapUVSet, duvY, uv0.y), _NormalMap_ST.y, _NormalMap_ST.w));         // b207:159-160 (PBR uv)

                // Channel candidates (sample the same maps/UVs the core surface did).
                float baseColorA = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uvBase, 0.0).w;                    // b207:162 (_145 = T0.w = BaseColorA)
                float4 nrmTex    = SAMPLE_TEXTURE2D_BIAS(_NormalMap,    sampler_NormalMap,    uvPbr,  _TAAUNormalBiasReverse);    // NormalMapB/A endpoints (.z/.w)
                float mroA       = SAMPLE_TEXTURE2D_BIAS(_MROMap,       sampler_MROMap,       uvPbr,  0.0).w;                     // b207:163 (_150.w = T2.w = MROA)

                // Full runtime channel select on _EmissiveMaskChannel (BaseColorA=1 .. MROA=4); NOMAP=5 -> 1.0.
                //   The folded blob form is lerp(BaseColorA, MROA, saturate(sel-2)); the discrete select below is
                //   the un-folded equivalent that additionally routes NormalMapB(2)/NormalMapA(3) (b207 omitted them).
                float maskRaw;
                if      (_EmissiveMaskChannel < 1.5) maskRaw = baseColorA;   // 1 BaseColorA
                else if (_EmissiveMaskChannel < 2.5) maskRaw = nrmTex.z;     // 2 NormalMapB
                else if (_EmissiveMaskChannel < 3.5) maskRaw = nrmTex.w;     // 3 NormalMapA
                else if (_EmissiveMaskChannel < 4.5) maskRaw = mroA;         // 4 MROA
                else                                 maskRaw = 1.0;          // 5 NOMAP (channel-less)

                // typeGate: lerp(1, maskRaw, saturate(sel)) — for sel>=1 this == maskRaw (b207 _183*..., the
                //   clamp(sel,0,1) factor). Kept as the source spells it so sel==0 (unreached in MASK) -> 1.
                float typeGate = saturate(_EmissiveMaskChannel);                         // b207:168 (_183)
                float selMix   = mad(typeGate, maskRaw - 1.0, 1.0);                      // b207:169 inner lerp(1, maskRaw, typeGate)
                // remap the masked scalar by [0.05,0.95] -> [0,1]: mad(x, 1/0.9, -0.05/0.9) then saturate.
                float maskScalar = saturate(mad(selMix, 1.111111164093017578125, -0.055555559694766998291015625));  // b207:169 (_188); 1/0.9, -0.05/0.9
                // emissive on/off threshold at 0.1 (b207:170 _195). Drives ONLY the VFX Param4 color override
                //   (host-filled, identity here) — folding Param4 to identity makes it neutral, so the masked
                //   color reduces to maskScalar * _EmissiveColor. The threshold itself does not gate the additive
                //   emission in the standalone (no-VFX) path; preserved as a comment-cite, not a live branch.

                // colorPick == flat _EmissiveColor (VFX Param2 override folded to identity, b207:187 inner mad).
                emisColor = maskScalar.xxx * _EmissiveColor.xyz;                         // b207:187-189 (_188 * vfxColor); typeGate folded below
                // typeGate also multiplies the final emission in b207 (_183 outer factor) — apply it here so the
                //   shared tail stays mode-agnostic.
                emisColor *= typeGate;

            #elif defined(_EMISSIVE_NOMAP)
                // =====================================================================================
                // _EMISSIVE_NOMAP — flat emissive: no map, no mask, no channel/RGBA blend, no remap. Just the
                //   _EmissiveColor modulated by albedo-affect + post-exposure + fade.
                // 1:1, source = liteffect/Sub0_Pass0_Fragment_b211.hlsl:164-166 (_EMISSIVE_NOMAP _TWO_BASEMAP;
                //   TWO_BASEMAP only changes MRO sampling, not this emissive color math). emisColor base = 1.0,
                //   so SV_Target = postExp * fade * (_EmissiveColor * albedoAffect). No _EmissiveRemap factor.
                // =====================================================================================
                emisColor  = _EmissiveColor.xyz;                                          // b211:164 (Param2 mad -> identity = _EmissiveColor)
                remapMul   = 1.0;                                                          // NOMAP has NO _EmissiveRemap multiply (b211:164 has no trailing remap)
                // NOTE: was `#else` (fired for ANY non-MAP/non-MASK variant incl. NONE-defined -> emisColor
                //   undeclared once the shader actually compiles this far); tightened to `#elif _NOMAP` so the
                //   emissive assembly is gated EXACTLY by the same MAP||MASK||NOMAP set that declares emisColor.
            #endif

            #if defined(_EMISSIVE_MAP) || defined(_EMISSIVE_MASK) || defined(_EMISSIVE_NOMAP)
                // ---- albedo-affect: lerp(tint-covered albedo, 1, _AlbedoAffectEmissive)  (b11:355 / b207:187 /
                //      b211:164, all == mad(_AlbedoAffectEmissive, 1-albedo, albedo) at identity VFX mask).
                //      s.albedo is the tint-covered base color the spine already wrote.
                float3 albedoAffect = mad(_AlbedoAffectEmissive.xxx, 1.0 - s.albedo, s.albedo);

                // ---- post-exposure divide: 1/lerp(1, _ExposureParams.x, _IgnorePostExposure)
                //      (b11:350 _1118 / b207:186 _316 / b211:149 _81).
                float postExpInv = 1.0 / mad(_ExposureParams.x, _IgnorePostExposure, 1.0 - _IgnorePostExposure);

                // ---- assemble: emission += postExpInv * fade * (colorPick * albedoAffect) * remapMul.
                //      fade = 1 - _unity_Float4x5_Param0.x = 1 (no VFX dissolve fade, standalone).
                float3 emission = (postExpInv * (emisColor * albedoAffect)) * remapMul;
                s.emission += emission;
            #endif
            }

            // ---- INFRA: HG SceneEffect / VFX per-renderer world-pos globals (host-C#-filled; NEUTRAL here).
            //   _VFXParams0.xyz = skill/SceneEffect emitter WORLD position, .w = effect time. Drives ONLY the
            //   OPTIONAL _ParallaxCharPos bright-ring; default emitter at origin + _ParallaxCharPos=0 => the term
            //   contributes 0 (source steady state). A ScriptableRenderFeature porting HGCharacterVFXManager would
            //   set these per-draw. _Time.y is NOT substituted for .w here because the only consumer (char-pulse)
            //   reads .xyz; the breathing anim uses _ParallaxAnimSpeed*_VFXParams0.w which, un-driven, freezes the
            //   cosine phase at the object-origin term (b11:803) — matching an un-emitted material exactly.
            #ifndef HGRP_LITEFFECT_VFX_GLOBALS
            #define HGRP_LITEFFECT_VFX_GLOBALS
            float4 _VFXParams0;   // .xyz emitter WS pos, .w effect time (host-filled; neutral 0)
            #endif

            // -------------------------------------------------------------------------------------
            // LitEffectParallax — _PARALLAX_MAP steep-parallax emissive pattern. 1:1, source =
            //   liteffectblend/Sub0_Pass0_Fragment_b11.hlsl:497-803 (clean names) == liteffect b219:508-798.
            // Returns the plain parallax emission (b219:346 == parallaxEm*_ParallaxIntensity) and outputs the
            // PRE-_ParallaxIntensity per-channel emission + visible heights for the worldspace pattern path.
            // Uses the GEOMETRIC vertex TBN (IN.normalWS/IN.tangentWS = b11 TEXCOORD_2/_3), NOT s.normalWS.
            // -------------------------------------------------------------------------------------
            //   normalPerPixel = the TBN-perturbed per-pixel normal (CoreSurface s.normalWS == b11 _488..490);
            //   used ONLY for the Fresnel dot (b11:686). The TBN view-projection (march) uses the GEOMETRIC normal.
            //   emPreMaster = the PLAIN per-channel emission (b219:336-338 / b11 inner min/max/postExp, WITHOUT the
            //   worldspace colorLerp*maskMap factor); colorLerpOut = the _ParallaxColorDark<->Color lerp (b11:672-674),
            //   needed by the worldspace path to rebuild b11:332 _885.
            float3 LitEffectParallax(Varyings IN, float3 normalPerPixel, out float3 emPreMaster, out float3 colorLerpOut, out float2 heights, out float3 camFwd)
            {
                emPreMaster  = float3(0.0, 0.0, 0.0);
                colorLerpOut = float3(0.0, 0.0, 0.0);
                heights      = float2(0.0, 0.0);
                camFwd       = float3(0.0, 0.0, 1.0);
            #if defined(_PARALLAX_MAP) || defined(_PARALLAX_MAP_WORLDSPACE)
                float2 uv0 = IN.uv.xy;
                float2 uv1 = IN.uv.zw;
                float3 positionWS = IN.positionWS;
                float3 nGeo  = IN.normalWS;                 // b11 TEXCOORD_2 (geometric normal — for TBN view-projection)
                float3 tGeo  = IN.tangentWS.xyz;            // b11 TEXCOORD_3.xyz (geometric tangent)
                float  tSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;   // b11:158 (_158)

                camFwd = normalize(IN.viewDirWS);           // b11:229-242 (_240..242): persp = camPos-P, ortho = -viewFwd

                float3 bitangent = tSign * cross(nGeo, tGeo);          // b11:192-194 (_192..194)
                float tDotV = dot(tGeo,      camFwd);                  // b11:228 (_497)
                float bDotV = dot(bitangent, camFwd);                  // b11:229 (_500)
                float nDotV = dot(nGeo,      camFwd);                  // b11:230 (_509)
                float rcpLen = rsqrt(dot(float3(tDotV, bDotV, nDotV), float3(tDotV, bDotV, nDotV)));  // b11:231 (_515)

                float duvX = uv1.x - uv0.x;
                float duvY = uv1.y - uv0.y;
                float2 uvP = float2(mad(_ParallaxMapUVType, duvX, uv0.x),
                                    mad(_ParallaxMapUVType, duvY, uv0.y));            // b11:527-528 (_527,_528)

                float dXx = ddx_coarse(uv0.x), dXy = ddx_coarse(uv0.y);              // b11:533-534
                float dYx = ddy_coarse(uv0.x), dYy = ddy_coarse(uv0.y);              // b11:539-540
                float numSteps = min(float(_ParallaxMarchNum), 20.0);                // b11:547 (_547)
                float invSteps = 1.0 / numSteps;                                     // b11:548 (_549)
                float bias  = mad(nDotV, rcpLen, 0.4199999868869781494140625);       // b11:550 (_550)
                float denom = max(rcpLen * nDotV, 0.001000000047497451305389404296875); // b11:554 (_554)
                float negStr = -_ParallaxStrength;                                   // b11:562 (_562)
                float dirU = (((rcpLen * tDotV) / bias) / denom) * negStr;           // b11:563 (_563)
                float dirV = (((rcpLen * bDotV) / bias) / denom) * negStr;           // b11:564 (_564)
                float stepU = invSteps * dirU;                                       // b11:565 (_565)
                float stepV = invSteps * dirV;                                       // b11:566 (_566)
                float endN = numSteps + 1.0;                                         // b11:569 (_569)
                float2 gradX = float2(dXx, dXy) * _GlobalMipBias.y;                  // b11:573-574 (_GlobalMipBiasPow2 == URP _GlobalMipBias.y = exp2(bias), Input.hlsl:112)
                float2 gradY = float2(dYx, dYy) * _GlobalMipBias.y;                  // b11:578-579

                float layerH = 1.0 - invSteps;     // b11:261 (_585)
                float curU   = stepU;              // b11:268 (_587)
                float curV   = stepV;              // b11:269 (_589 seeded from _580=asuint(_566))
                float prevH  = 1.0;                // b11:263 (_593)
                float prevU  = 0.0;                // b11:264 (_594)
                float prevV  = 0.0;                // b11:265 (_595)
                float storedAtHit = 0.0;           // b11:267 (_616 init 0u -> 0.0)
                float storedPrev  = 0.0;           // b11:262 (_591 init 0u -> 0.0; NOT 1.0 — matters on first-iter hit, _627 numerator asfloat(_591))
                [loop]
                for (float i = 0.0; i < endN; i += 1.0)        // b11:272-303
                {
                    float h = SAMPLE_TEXTURE2D_GRAD(_ParallaxNoiseMap, sampler_ParallaxNoiseMap,
                              float2(mad(uvP.x, _ParallaxNoiseMapTilling, curU), mad(uvP.y, _ParallaxNoiseMapTilling, curV)),
                              gradX, gradY).x;                   // b11:277 (_611)
                    if (layerH < h)                              // b11:280: hit when layerH < h (CONTINUE while !(layerH<h))
                    {
                        storedAtHit = h;                         // b11:295 (_616)
                        break;
                    }
                    prevH = layerH;  layerH -= invSteps;         // b11:283-284
                    prevU = curU;    curU = mad(dirU, invSteps, curU);   // b11:285-286
                    prevV = curV;    curV = mad(dirV, invSteps, curV);   // b11:287
                    storedPrev = h;                              // b11:288 (_591)
                }
                float t = (storedPrev - prevH) / ((-prevH) + (layerH + (storedPrev - storedAtHit)));  // b11:304/627 (_627)
                float2 pUV = float2((mad(stepU, t, prevU) + uvP.x) * _ParallaxTilling,
                                    (mad(stepV, t, prevV) + uvP.y) * _ParallaxTilling);   // b11:305 (_641 uv)
                float2 pTex = SAMPLE_TEXTURE2D_BIAS(_ParallaxMap, sampler_ParallaxMap, pUV, 0.0).xy;   // b11:305 (_641)
                float pHx = pTex.x;     // b11:306 (_643)
                float pHy = pTex.y;     // b11:307 (_644)

                float3 colorLerp = float3(
                    mad(pHy, _ParallaxColor.x - _ParallaxColorDark.x, _ParallaxColorDark.x),
                    mad(pHy, _ParallaxColor.y - _ParallaxColorDark.y, _ParallaxColorDark.y),
                    mad(pHy, _ParallaxColor.z - _ParallaxColorDark.z, _ParallaxColorDark.z));   // b11:672-674

                // Fresnel dot uses the PER-PIXEL normal (b11:686 dot(_240..242, _488..490); _488..490 == s.normalWS), NOT nGeo.
                float NoVc = clamp(dot(camFwd, normalPerPixel), 0.0, 1.0);
                float fresnel = exp2(log2(max(NoVc, 0.001000000047497451305389404296875)) * floor(_ParallaxFresnelStrength));  // b11:686 (_686)

                float minB = 1.0 - _ParallaxMinBrightness;                            // b11:308 (_650)
                float objOriginSum = (unity_ObjectToWorld._m13 + unity_ObjectToWorld._m03) + unity_ObjectToWorld._m23;  // b11:803 ((origin.y+.x)+.z)
                float breathing = minB * (((1.0 + _ParallaxMinBrightness) / minB)
                                + cos(mad(_VFXParams0.w * _ParallaxAnimSpeed, 0.0500000007450580596923828125, objOriginSum * _ParallaxAnimRandom)));  // b11:803

                float3 dEmit = positionWS - _VFXParams0.xyz;                          // b11:735-737
                float ring = clamp((length(dEmit) - _ParallaxBrightOuterRadius)
                           * (1.0 / (_ParallaxBrightInnerRadius - _ParallaxBrightOuterRadius)), 0.0, 1.0);  // b11:757 (_757)
                float ringSmooth = (ring * ring) * mad(ring, -2.0, 3.0);              // b11:803 smoothstep(_757)
                float charPulse = (_ParallaxCharPos != 0.0) ? (ringSmooth * _ParallaxBrightStrength) : 0.0;  // b11:803 (& _ParallaxCharPos)
                // b11:803 _803 = mad(smoothstep(_796)*_VFXParams2.w, 1, mad(breathing,0.5,charPulse)). The leading
                //   smoothstep(_796)*_VFXParams2.w is a 2nd VFX-emitter sphere falloff (_796 from _VFXParams2.xyz,
                //   strength _VFXParams2.w); with the host VFX neutral (_VFXParams2.w=0) that term is exactly 0 ->
                //   _803 = mad(breathing,0.5,charPulse). Omitted neutrally (parallels the _ParallaxCharPos gate).
                float bright = mad(breathing, 0.5, charPulse);                        // b11:803 (_803, host _VFXParams2 sphere term = 0 at neutral)

                float postExpDiv = (_ParallaxIgnorePostExposure != 0.0) ? _ExposureParams.x : 1.0;  // b11:331 (_872)
                float3 em = float3(
                    min(max(bright * (fresnel * colorLerp.x), 0.0), 1000.0) / postExpDiv,
                    min(max(bright * (fresnel * colorLerp.y), 0.0), 1000.0) / postExpDiv,
                    min(max(bright * (fresnel * colorLerp.z), 0.0), 1000.0) / postExpDiv);   // b219:336-338 / b11:332-334 inner (no mask-map factor)
                emPreMaster  = em;
                colorLerpOut = colorLerp;
                heights      = float2(pHx, pHy);
                return em * _ParallaxIntensity;                                       // b219:346 (*_OffsetUVSet == _ParallaxIntensity)
            #else
                return float3(0.0, 0.0, 0.0);
            #endif
            }

            // -------------------------------------------------------------------------------------
            // LitEffectWorldParallax — _PARALLAX_MAP_WORLDSPACE world-XZ pattern term. 1:1, source =
            //   liteffectblend/Sub0_Pass0_Fragment_b11.hlsl:821-1016,329-348,354. Returns the worldspace pattern
            //   emission term (_1182*pattern of b11:355-357). interactSignal (b11 TEXCOORD_4.x, HG interaction
            //   interpolator absent on URP meshes) defaults 0 -> schedule-only steady pattern (b11:341-342).
            //   lod uses abs(GEOMETRIC WORLD normal .y) directly (b11:329 mad(abs(TEXCOORD_2.y),-3,3)) — NOT view-space.
            // -------------------------------------------------------------------------------------
            float3 LitEffectWorldParallax(float3 plainEm, float3 colorLerp, float2 heights, float3 positionWS, float3 normalGeoWS)
            {
            #ifdef _PARALLAX_MAP_WORLDSPACE
                float pHx = heights.x, pHy = heights.y;
                float interactSignal = 0.0;                                           // b11 TEXCOORD_4.x (host interaction; neutral 0)

                float2 worldXZ = positionWS.xz - _MaskWorldPosParams.xz;              // b11:821-822 (_821,_822)
                float ang = 0.01745329238474369049072265625 * _MaskWorldPosParams.y;  // b11:826 (_826) deg->rad
                float s = sin(ang), c = cos(ang);                                     // b11:828-829
                float scale = max(0.100000001490116119384765625, _MaskWorldPosParams.w);  // b11:833 (_833)
                float2 wq = worldXZ / scale;                                          // b11:834-835
                float2 maskUV = float2(mad(pHx, _ParallaxMinBrightness, dot(wq, float2(c,  s)) + 0.5),
                                       mad(pHy, _ParallaxMinBrightness, dot(wq, float2(-s, c)) + 0.5));  // b11:329 (_856 uv)
                float lod = mad(abs(normalGeoWS.y), -3.0, 3.0);                       // b11:329 lod = mad(abs(TEXCOORD_2.y),-3,3) (geometric world normal Y)
                float4 mask = SAMPLE_TEXTURE2D_LOD(_ParallaxMaskMap, sampler_ParallaxMaskMap, maskUV, lod);  // b11:329 (_856 rgba)
                float maskA = mask.w;                                                 // b11:330 (_861)

                // _885..887 (b11:332-334) = plainEm.c * (colorLerp.c * (mask.c * _ParallaxMaskMapColorStrength)).
                //   plainEm.c == min(max(bright*fresnel*colorLerp.c,0),1000)/postExp (the LebParallax `em`); the
                //   worldspace path adds the EXTRA colorLerp*maskMapRGB*strength modulation the plain path lacks.
                float3 em885 = float3(
                    plainEm.x * (colorLerp.x * (mask.x * _ParallaxMaskMapColorStrength)),
                    plainEm.y * (colorLerp.y * (mask.y * _ParallaxMaskMapColorStrength)),
                    plainEm.z * (colorLerp.z * (mask.z * _ParallaxMaskMapColorStrength)));   // b11:332-334 (_885..887)

                float3 patternBase = em885 * _ParallaxPatternColor.rgb;               // b11:343-345 (_999..1001)
                float3 patternDark = float3(
                    mad(em885.x, _ParallaxPatternColorDark.x, -patternBase.x),
                    mad(em885.y, _ParallaxPatternColorDark.y, -patternBase.y),
                    mad(em885.z, _ParallaxPatternColorDark.z, -patternBase.z));        // b11:346-348 inner

                uint sig = uint(int(_ParallaxSignControl));                           // b11:335 (_891)
                float l0 = clamp(maskA,                                 0.0, 1.0);     // b11:336 (_892)
                float l1 = clamp(maskA - 0.20000000298023223876953125, 0.0, 1.0);     // b11:337 (_901)
                float l2 = clamp(maskA - 0.4000000059604644775390625,  0.0, 1.0);     // b11:338 (_902)
                float l3 = clamp(maskA - 0.60000002384185791015625,    0.0, 1.0);     // b11:339 (_903)
                float l4 = clamp(maskA - 0.800000011920928955078125,   0.0, 1.0);     // b11:340 (_904)
                float term4 = ((l4 * ((0.180000007152557373046875 >= l4) ? 1.0 : 0.0)) * 5.0) * float((sig >> 4u) & 1u) * _ParallaxSignLerpFactor2;        // b11:341
                float term3 = ((l3 * ((0.180000007152557373046875 >= l3) ? 1.0 : 0.0)) * 5.0) * float((sig >> 3u) & 1u) * _ParallaxSignLerpFactor0.w;
                float term2 = ((l2 * ((0.180000007152557373046875 >= l2) ? 1.0 : 0.0)) * 5.0) * float((sig >> 2u) & 1u) * _ParallaxSignLerpFactor0.z;
                float term0 = (float(sig & 1u) * ((((0.180000007152557373046875 >= l0) ? 1.0 : 0.0) * l0) * 5.0)) * _ParallaxSignLerpFactor0.x;
                float term1 = (((l1 * ((0.180000007152557373046875 >= l1) ? 1.0 : 0.0)) * 5.0) * float((sig >> 1u) & 1u)) * _ParallaxSignLerpFactor0.y;
                float sigSum = term4 + term3 + term2 + term0 + term1;                 // b11:341 nested mads
                float schedule = clamp(mad(pHx, 20.0, length(worldXZ)) - _ParallaxLerpSchedule, 0.0, 1.0);  // b11:341 (_991 schedule)
                float signMix = clamp(mad(sigSum, interactSignal, schedule), 0.0, 1.0);  // b11:341-342 (_991->_992)

                float3 pattern = float3(
                    mad(signMix, patternDark.x, patternBase.x),
                    mad(signMix, patternDark.y, patternBase.y),
                    mad(signMix, patternDark.z, patternBase.z));                      // b11:346-348 (_1014..1016)

                float sigMaskA = clamp(_ParallaxSignLerpFactor1.w, 0.0, 1.0);         // b11:354 (_1182 weight)
                return (sigMaskA * pattern) * _ParallaxIntensity;                     // b11:355 _1182*_1014*_ParallaxIntensity
            #else
                return float3(0.0, 0.0, 0.0);
            #endif
            }

            // -------------------------------------------------------------------------------------
            // LitEffectDetail — _DETAIL_MAP delta: detail normal (RNM blend) + roughness + AO/albedo-tint,
            //   all gated by a mask-channel * depth-falloff weight. Mutates s.normalWS / s.roughness /
            //   s.occlusion / s.albedo / s.f0. 1:1, source = liteffect/Sub0_Pass0_Fragment_b335.hlsl
            //   (the ISOLATED single-keyword `HG_ENABLE_MV _DETAIL_MAP` GBuffer variant, liteffect.shader:1038
            //   `... && !_PARALLAX_MAP_WORLDSPACE && defined(_DETAIL_MAP) && !SRP_INSTANCING_ON`), diffed
            //   against the base GBuffer blob b185 to isolate the delta. This GBuffer fragment only PACKS
            //   surface params; the URP port re-applies the SAME per-channel detail math onto the forward
            //   LitSurfaceData (the packing MRT slots map: SV_Target_3.xy=octWorldNormal -> s.normalWS,
            //   SV_Target_3.z=roughnessT -> s.roughness, SV_Target_4.rgb=tint-covered albedo -> s.albedo,
            //   SV_Target_2.y=VAT-gated occlusion -> s.occlusion; CORE_MATH §1.2-1.4).
            //
            //   No clean-named Rosetta exists (liteffectblend b11 covers only emissive/parallax/two-basemap),
            //   so the b335 feature uniforms — register-collided onto unrelated base packoffset slots — are
            //   pinned by their UNIQUE ROLE in the formula + the clean property enum (liteffect.shader:54-64).
            //   This is the SAME recovery the emissive-mask path used (constant-folded channel select rebuilt
            //   into the full runtime enum). Every alias decode:
            //     _BaseColorMap_ST_at_320 (c20) == (_DetailFalloffStart, _DetailFalloffEnd, _DetailUVSet,
            //         _DetailBaseColorBrighterScale)  [.x/.y = depth-falloff start/end (b335:177 div);
            //         .z = detail UV-set select (b335:182); .w = detail brighter-scale (b335:240)].
            //     _DissolveUVSpeed (c22) == _DetailMap_ST  [detail-map tiling/offset, b335:182].
            //     _OffsetIntensity (c19.y) == _DetailMaskMode  [the AllPass/DetailMapA/BaseColorA/NormalMapB/
            //         NormalMapA/MROA enum; b335:193-194 saturate(x)/saturate(x-1)/saturate(x-3) select boundaries].
            //     _DissolveScanSchedule (c19.z) == _DetailNormalIntensity  [scales detail normal XY, b335:195 _423].
            //     _DissolveScanWidth (c19.w) == _DetailPBRIntensity  [scales roughness/AO blend, b335:196 _424].
            //     _DissolveUVRotate (c19.x) == _DetailMode  [0=Normal_Roughness_AlbedoTint, 1=Normal_Roughness_AO;
            //         b335:235 roughness-source lerp, b335:236 (1-mode) albedo gate, b335:197 (mode) AO gate].
            //     _NormalMap_ST (c21) == _DetailOverlayColor (rgba)  [albedo overlay tint, b335:240-245].
            //     _B_autoPlayback == _NormalScale (the VAT-neutral base-normal scale, SAME resolution
            //         CoreSurface uses for the base path; b335:206-207 _489/_490).
            //   The mask select (b335:194) constant-folds modes 2..5 to a saturate(mode-3) lerp between
            //   BaseColorA<->MROA endpoints (dropping NormalMapB/A exactly like the folded emissive mask);
            //   the URP port rebuilds the full discrete enum, routing NormalMapB=_NormalMap.b / NormalMapA=
            //   _NormalMap.a by the same usage identification the core surface uses (T1=NormalMap, CORE_MATH §0.3).
            //   Re-samples BaseColorMap/_NormalMap/_MROMap (the module runs AFTER LitBuildSurface) so the RNM
            //   base normal + the mask-channel candidates + the pre-remap roughness/occlusion are reproduced
            //   identically to CoreSurface.
            // -------------------------------------------------------------------------------------
            void LitEffectDetail(inout LitSurfaceData s, Varyings IN, bool isFrontFace)
            {
            #ifdef _DETAIL_MAP
                float3 positionWS = IN.positionWS;
                float2 uv0 = IN.uv.xy;                         // b335 TEXCOORD
                float2 uv1 = IN.uv.zw;                         // b335 TEXCOORD_1
                float duvX = uv1.x - uv0.x;                    // b335:178 (_281)
                float duvY = uv1.y - uv0.y;                    // b335:179 (_282)
                float3 normalGeo  = IN.normalWS;              // b335 TEXCOORD_2 (geometric world normal)
                float4 tangentWS  = IN.tangentWS;             // b335 TEXCOORD_3
                float  tangentSign = (tangentWS.w > 0.0) ? 1.0 : -1.0;   // b335:219 (_537)

                // ---- UV-set select + per-map _ST (re-derived exactly as CoreSurface) ----
                float2 uvBase = float2(
                    mad(mad(_BaseUVSet,       duvX, uv0.x), _BaseColorMap_ST.x, _BaseColorMap_ST.z),
                    mad(mad(_BaseUVSet,       duvY, uv0.y), _BaseColorMap_ST.y, _BaseColorMap_ST.w));   // b335:180 (_309 uv; _TextureFormat alias == _BaseUVSet)
                float2 uvPbr = float2(
                    mad(mad(_BasePbrMapUVSet, duvX, uv0.x), _NormalMap_ST.x, _NormalMap_ST.z),
                    mad(mad(_BasePbrMapUVSet, duvY, uv0.y), _NormalMap_ST.y, _NormalMap_ST.w));         // b335:185-186 (_372,_373 uvPbr)
                float2 uvDetail = float2(
                    mad(mad(_DetailUVSet,     duvX, uv0.x), _DetailMap_ST.x, _DetailMap_ST.z),
                    mad(mad(_DetailUVSet,     duvY, uv0.y), _DetailMap_ST.y, _DetailMap_ST.w));         // b335:182 (_357 detail uv)

                // ---- re-sample the base maps (URP auto-adds _GlobalMipBias.x; +_TAAUNormalBiasReverse on NORMAL) ----
                float4 baseTex = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uvBase, 0.0);                    // b335:180 (_309) — .w = BaseColorA
                // NORMAL bias = _TAAUNormalBiasReverse to match CoreSurface's base sample EXACTLY (so the RNM base
                //   normal == the spine's). b335:203 spells the add as `_globalPscaleMul` (its alias of the same
                //   c-slot CoreSurface resolves as _TAAUNormalBiasReverse for the base path; CORE_MATH §2.2 — the
                //   +bias rides the NORMAL sample). URP also auto-adds _GlobalMipBias.x on top.
                float4 nrm     = SAMPLE_TEXTURE2D_BIAS(_NormalMap,    sampler_NormalMap,    uvPbr,  _TAAUNormalBiasReverse); // b335:203 (_467) — base DXT5nm normal + NormalMapB/A in .z/.w
                float4 mro     = SAMPLE_TEXTURE2D_BIAS(_MROMap,       sampler_MROMap,       uvPbr,  0.0);                    // b335:187 (_378) — .x metallic .y roughness(_667) .z occlusion .w MROA
                float4 detail  = SAMPLE_TEXTURE2D_BIAS(_DetailMap,    sampler_DetailMap,    uvDetail, 0.0);                  // b335:182 (_357) — .x/.y normal .z/.w pbr/mask

                float baseColorA = baseTex.w;   // b335:181 (_314)
                float mroA       = mro.w;        // b335:194 (_378.w)
                float detailA    = detail.w;     // b335:184 (_362)
                float detailB    = detail.z;     // b335:183 (_361)

                // ---- depth falloff `_270` (b335:174-177): view-space linear |Z| -> clamp((End - |Z|)/(End - Start),0,1).
                //   HG reconstructs worldPos from depth then dots into the view-matrix Z row; the URP-faithful
                //   substitute is the view-space Z of the already-known positionWS (UNITY_MATRIX_V owns the same
                //   camera basis the blob's _ViewMatrix did — CORE_MATH §2.12). End=_DetailFalloffEnd, Start=_DetailFalloffStart.
                float viewZ    = mul(UNITY_MATRIX_V, float4(positionWS, 1.0)).z;                                            // b335:177 _ViewMatrix[*].z row
                float depthFade = clamp((((-abs(viewZ)) + _DetailFalloffEnd) / ((-_DetailFalloffStart) + _DetailFalloffEnd)), 0.0, 1.0); // b335:177 (_270)

                // ---- mask-channel select `_418` (b335:192-194). Folded blob = lerp over {1, detailA, BaseColorA, MROA}
                //   via saturate(mode)/saturate(mode-1)/saturate(mode-3); rebuilt as the full _DetailMaskMode enum.
                //   AllPass=0 -> 1 (depth-only). DetailMapA=1 -> detail.a. BaseColorA=2. NormalMapB=3 -> nrm.z.
                //   NormalMapA=4 -> nrm.w. MROA=5 -> mro.w. (b335 emitted only the BaseColorA<->MROA endpoints.)
                float maskCh;
                if      (_DetailMaskMode < 0.5) maskCh = 1.0;          // 0 AllPass
                else if (_DetailMaskMode < 1.5) maskCh = detailA;      // 1 DetailMapA
                else if (_DetailMaskMode < 2.5) maskCh = baseColorA;   // 2 BaseColorA
                else if (_DetailMaskMode < 3.5) maskCh = nrm.z;        // 3 NormalMapB
                else if (_DetailMaskMode < 4.5) maskCh = nrm.w;        // 4 NormalMapA
                else                            maskCh = mroA;         // 5 MROA
                float weight = depthFade * maskCh;                    // b335:194 (_418) — mask * depth-falloff

                float wNormal = weight * _DetailNormalIntensity;       // b335:195 (_423)
                float wPbr    = weight * _DetailPBRIntensity;          // b335:196 (_424)

                // ================= DETAIL NORMAL (reoriented normal mapping) — b335:204-227 =================
                // base tangent-space normal (DXT5nm decode, UNSCALED radicand + _NormalScale-scaled XY; the
                //   b335 `_B_autoPlayback` factor is the VAT-neutral alias of _NormalScale, SAME as CoreSurface).
                float bnxDecode = mad(nrm.x * nrm.w, 2.0, -1.0);       // b335:204 (_473) — UNSCALED
                float bnyDecode = mad(nrm.y,         2.0, -1.0);       // b335:205 (_474)
                float bnx = bnxDecode * _NormalScale;                 // b335:206 (_489) — XY scaled (_B_autoPlayback -> _NormalScale)
                float bny = bnyDecode * _NormalScale;                 // b335:207 (_490)
                float bnzP1 = max(sqrt(((-0.0) - min(dot(float2(bnxDecode, bnyDecode), float2(bnxDecode, bnyDecode)), 1.0)) + 1.0),
                                  1.000000016862383526387164645044e-16) + 1.0;                                              // b335:208 (_491) — base Z + 1 (RNM t.z)
                // detail tangent-space normal (plain RG, 0.012 dead-zone, scaled by wNormal).
                float dnx = mad(detail.x, 2.0, -1.0);                 // b335:209 (_492)
                float dny = mad(detail.y, 2.0, -1.0);                 // b335:210 (_493)
                float dnxDz = (abs(dnx) < 0.01200000010430812835693359375) ? 0.0 : dnx;   // b335:211 (_502)
                float dnyDz = (abs(dny) < 0.01200000010430812835693359375) ? 0.0 : dny;   // b335:212 (_504)
                float du = wNormal * dnxDz;                           // b335:213 (_505)
                float dv = wNormal * dnyDz;                           // b335:214 (_506)
                float dnz = sqrt(max(((-0.0) - dot(float2(dnxDz, dnyDz), float2(dnxDz, dnyDz))) + 1.0, 0.0)); // b335:215 (_513) — detail Z (unsigned)
                // RNM: t = (bnx,bny,bnzP1) ; u = (-du,-dv,dnz) ; blended.xy = u.xy + t.xy*dot(t,u)/t.z ; blended.z = dot(t,u)-u.z
                float tDotU = dot(float3(bnx, bny, bnzP1), float3(du * (-1.0), dv * (-1.0), dnz * 1.0));        // b335:216 (_517)
                float blendX = mad((-0.0) - du, -1.0, (bnx * tDotU) / bnzP1);                                   // b335:217 (_528)
                float blendY = mad((-0.0) - dv, -1.0, (bny * tDotU) / bnzP1);                                   // b335:218 (_529)
                float frontSign = isFrontFace ? 1.0 : ((_TwoSidedNormal > 0.0) ? -1.0 : 1.0);                   // b335:220 (_596 sign)
                float blendZ = frontSign * mad((-0.0) - dnz, 1.0, tDotU);                                       // b335:220 (_596) = frontSign*(tDotU - dnz)
                // world normal via the SAME TBN as the base (N*Z + T*X + (tangentSign*cross(N,T))*Y), normalize.
                float3 crossNT = float3(
                    mad(normalGeo.y, tangentWS.z, (-0.0) - (normalGeo.z * tangentWS.y)),
                    mad(normalGeo.z, tangentWS.x, (-0.0) - (normalGeo.x * tangentWS.z)),
                    mad(normalGeo.x, tangentWS.y, (-0.0) - (normalGeo.y * tangentWS.x)));                        // b335:221-223 cross(N,T)
                float3 worldN = float3(
                    mad(normalGeo.x, blendZ, mad(tangentWS.x, blendX, blendY * (tangentSign * crossNT.x))),
                    mad(normalGeo.y, blendZ, mad(tangentWS.y, blendX, blendY * (tangentSign * crossNT.y))),
                    mad(normalGeo.z, blendZ, mad(tangentWS.z, blendX, blendY * (tangentSign * crossNT.z))));     // b335:221-223 (_603..605)
                s.normalWS = normalize(worldN);                                                                 // b335:224 (_609 rsqrt)

                // ================= DETAIL ROUGHNESS — b335:234-235 =================
                // roughnessT (pre-_RoughnessMin/Max remap) <- lerp(mro.y, lerp(detail.a, detail.b, _DetailMode), wPbr).
                //   (GBuffer SV_Target_3.z is the roughness packing slot; _667 is its VAT-neutral mro.y value.)
                float roughT     = mro.y;                                                       // b335:234 (_667 VAT-neutral) == CoreSurface roughnessT
                float detailRough = mad(_DetailMode, ((-0.0) - detailA) + detailB, detailA);     // b335:235 lerp(detail.a, detail.b, _DetailMode)
                float roughTDetail = mad(wPbr, ((-0.0) - roughT) + detailRough, roughT);         // b335:235 (_? -> SV_Target_3.z) lerp(roughT, detailRough, wPbr)
                s.roughness = lerp(_RoughnessMin, _RoughnessMax, roughTDetail);                  // CoreSurface remap (b9:171/b7:174)

                // ================= DETAIL AO (mode 1 only) — b335:197 =================
                // occlusion channel *= (1 + wPbr*(detail.a - 1)*_DetailMode) == lerp(1, detail.a, wPbr) in AO mode.
                //   b335 multiplies SV_Target_2.y (the VAT-gated occlusion slot, lerp(1,mro.z,_houdiniFPS)); the
                //   houdini gate is VAT-neutral, so the faithful forward routing applies the SAME factor to the
                //   occlusion the forward path uses (mro.z), pre-_OcclusionStrength remap.
                float aoFactor = mad(wPbr, (detailA + (-1.0)) * _DetailMode, 1.0);               // b335:197 (1 + _424*_409*_DetailMode)
                float occTDetail = mro.z * aoFactor;                                             // b335:197 occlusion slot *= aoFactor
                s.occlusion = lerp(1.0, occTDetail, _OcclusionStrength);                         // CoreSurface occlusion remap (b7:151/b9:146)

                // ================= DETAIL ALBEDO TINT (mode 0 only) — b335:236-245 =================
                // detailW = (1 - detail.b) * (1 - _DetailMode) * weight   (b335:236 _678; mode 1 -> 0, no tint).
                float detailAlbW = (((-0.0) - detailB) + 1.0) * (1.0 + ((-0.0) - _DetailMode)) * weight;        // b335:236 (_678)
                // tint-covered base albedo == s.albedo (CoreSurface already wrote lerp(albedoRaw,_BaseColor,_BaseColorTintCover)).
                float3 baseCol = s.albedo;                                                                      // b335:237-239 (_693..695)
                // detail-overlay-tinted, brightened albedo: saturate(baseCol * _DetailOverlayColor.rgb * _DetailBaseColorBrighterScale).
                float3 tinted = saturate(baseCol * _DetailOverlayColor.rgb * _DetailBaseColorBrighterScale);    // b335:240-242 (_711..713)
                // overlay endpoint mix: lerp(tinted, _DetailOverlayColor.rgb, _DetailOverlayColor.a)  (b335:243-245 inner).
                float3 overlay = float3(
                    mad(_DetailOverlayColor.w, ((-0.0) - tinted.x) + _DetailOverlayColor.x, tinted.x),
                    mad(_DetailOverlayColor.w, ((-0.0) - tinted.y) + _DetailOverlayColor.y, tinted.y),
                    mad(_DetailOverlayColor.w, ((-0.0) - tinted.z) + _DetailOverlayColor.z, tinted.z));         // b335:243-245 inner mad
                float3 albedoDetail = float3(
                    mad(detailAlbW, ((-0.0) - baseCol.x) + overlay.x, baseCol.x),
                    mad(detailAlbW, ((-0.0) - baseCol.y) + overlay.y, baseCol.y),
                    mad(detailAlbW, ((-0.0) - baseCol.z) + overlay.z, baseCol.z));                              // b335:243-245 (_SV_Target_4) lerp(baseCol, overlay, detailAlbW)
                s.albedo = albedoDetail;

                // ---- f0/specular derive from albedo (CoreSurface b9:318-325); recompute after albedo blend.
                //   dielF0 = 0.08*_Specular ; f0 = lerp(dielF0, albedo, metallic). (s.specular = dielF0.xxx is metallic-free.)
                float dielF0 = 0.07999999821186065673828125 * _Specular;                                       // b9:318 (_504)
                s.f0 = lerp(dielF0.xxx, s.albedo, s.metallic);                                                  // b9:322-325 (_513..516)
            #endif
            }

            // -------------------------------------------------------------------------------------
            // LitEffectTriChannelMask — _TRI_CHANNEL_MASK delta: a 3-channel (R/G/B) material-override mask.
            //   Samples _MaskMap; for each of the mask's R,G,B channels it lerps albedo / roughness / metallic
            //   toward a per-channel target (_MaskAlbedo{R/G/B}, _MaskRoghness{R/G/B}, _MaskMetallic{R/G/B}),
            //   weighted by that channel's mask value. Order is B -> G -> R (R wins last). Mutates s.albedo /
            //   s.roughness / s.metallic, then recomputes s.f0 from the new albedo+metallic.
            //
            //   GROUND TRUTH (1:1):
            //     * Isolated single-keyword GBuffer blob liteffect/Sub0_Pass0_Fragment_b193.hlsl (the
            //       `&& defined(_TRI_CHANNEL_MASK) && !<all other feature kw>` branch, liteffect.shader:825-827),
            //       diffed against base b185 to isolate the delta:
            //         - mask sample b193:194 (T3, the new texture; aliased UVSet `_DissolveUVRotate`, aliased
            //           `_MaskMap_ST` == `_CutOffDirection_at_432`).
            //         - 3 channel weights b193:198/209/210 (`_258`=B,`_363`=G,`_368`=R).
            //         - albedo 3-lerp b193:222-233; metallic 3-lerp b193:207/208/212; roughness 3-lerp b193:225/229/230.
            //     * CLEAN-NAMED Rosetta = littransparent/Sub0_Pass0_Fragment_b58.hlsl (ForwardLit, the
            //       `defined(_TRI_CHANNEL_MASK)` branch, littransparent.shader:420-422) — every `_MaskAlbedo*`,
            //       `_MaskRoghness*`(via roughness 3-lerp b58:402/406/409) and `_MaskMetallic*`(b58:412-414) token
            //       is clean, fixing the b193 alias decode AND exposing two facts the GBuffer blob hid:
            //         (1) the per-channel weight GATE is the mask-color ALPHA: `_MaskAlbedo{R/G/B}.w` (b58:389-391).
            //         (2) the weight has an OFFSET (`_Mask{R}Offset`) + CONTRAST (`mad(ch+off, k+1, -0.5k)`) remap.
            //       Offset/contrast are NOT exposed in the liteffect/littransparent reduced property set
            //       (liteffect.shader:65-76 / littransparent.shader:26-37 expose ONLY MaskMap+UVSet+per-channel
            //       Color/Roughness/Metallic). In the decompiled cbuffer they alias onto unrelated zero-default
            //       slots (b58:386-388 `_DirectionTendency`/`_MaskGScale`/`_Use_VerexTexColorAsOpacity`;
            //       `_MaskROffset`/`_Kite`/`_MaskBOffset`), so for a real material off=0, contrast=0 and the remap
            //       collapses to the identity `saturate(mad(ch+0, 0+1, 0)) = saturate(ch)`. The mask-color alpha
            //       defaults to 1 (liteffect.shader:68/71/74). Net faithful weight: `w_ch = saturate(mask.ch) * _MaskAlbedo{ch}.a`.
            //   NOTE: in the GBuffer blob the roughness slot is the VAT-packed `lerp(_displayFrame,_playbackSpeed,mro.y)`;
            //     the forward Rosetta b58:398 shows it is the FINAL linear roughness `lerp(_RoughnessMin,_RoughnessMax,mro.y)`
            //     and the _MaskRoghness{R/G/B} targets (Range 0..1) are blended onto THAT — so we mutate s.roughness directly.
            // -------------------------------------------------------------------------------------
            void LitEffectTriChannelMask(inout LitSurfaceData s, Varyings IN)
            {
            #ifdef _TRI_CHANNEL_MASK
                float2 uv0 = IN.uv.xy;                         // b193 TEXCOORD
                float2 uv1 = IN.uv.zw;                         // b193 TEXCOORD_1
                float duvX = uv1.x - uv0.x;                    // b193:192 (_183)
                float duvY = uv1.y - uv0.y;                    // b193:193 (_184)

                // ---- mask UV: lerp(uv0,uv1,_MaskUVSet) then *_MaskMap_ST (b193:194 / b58:385). ----
                float2 uvMask = float2(
                    mad(mad(_MaskUVSet, duvX, uv0.x), _MaskMap_ST.x, _MaskMap_ST.z),
                    mad(mad(_MaskUVSet, duvY, uv0.y), _MaskMap_ST.y, _MaskMap_ST.w));         // b193:194 (UVSet alias _DissolveUVRotate, _ST alias _CutOffDirection_at_432)
                float4 mask = SAMPLE_TEXTURE2D_BIAS(_MaskMap, sampler_MaskMap, uvMask, 0.0);  // b193:194 T3 (URP auto-adds _GlobalMipBias.x)

                // ---- per-channel weights: w_ch = saturate(mask.ch) * _MaskAlbedo{ch}.a ----
                //   (faithful reduction of b58:389-391 `saturate(mad(mask.ch + off, k+1, -0.5k)) * _MaskAlbedo{ch}.w`
                //    with off=0, contrast k=0 — neither is exposed in the liteffect reduced set, both default 0;
                //    the .w gate defaults 1 via the color property defaults.)
                float wR = saturate(mask.x) * _MaskAlbedoR.w;   // b193:210 (_368) / b58:389 (_456)
                float wG = saturate(mask.y) * _MaskAlbedoG.w;   // b193:209 (_363) / b58:390 (_460)
                float wB = saturate(mask.z) * _MaskAlbedoB.w;   // b193:198 (_258) / b58:391 (_464)

                // ---- ALBEDO: 3 successive lerps toward the per-channel mask color, order B -> G -> R. ----
                //   (s.albedo is the tint-covered base color CoreSurface already wrote, == b193 _411..413 / b58 _489..491.)
                float3 albedo = s.albedo;
                albedo = lerp(albedo, _MaskAlbedoB.xyz, wB);    // b193:222-225 (_443..445) / b58:399-401 (_521..523)
                albedo = lerp(albedo, _MaskAlbedoG.xyz, wG);    // b193:226-228 (_463..465) / b58:403-405 (_541..543)
                albedo = lerp(albedo, _MaskAlbedoR.xyz, wR);    // b193:231-233 (SV_Target_4) / b58:407,408,410 (_561,_562,_564)
                s.albedo = albedo;

                // ---- METALLIC: base metallic, then 3 lerps toward _MaskMetallic{B,G,R}. ----
                //   (s.metallic is CoreSurface's lerp(mro.x,_Metallic,saturate(count-1)), == b193 _346 / b58 _575.)
                float metallic = s.metallic;
                metallic = lerp(metallic, _MaskMetallicB, wB);  // b193:208 (_353) / b58:412 (_582)
                metallic = lerp(metallic, _MaskMetallicG, wG);  // b193:211 (_369) / b58:413 (_588)
                metallic = lerp(metallic, _MaskMetallicR, wR);  // b193:212 (SV_Target_2.x) / b58:414 (_594)
                s.metallic = metallic;

                // ---- ROUGHNESS (final linear): base roughness, then 3 lerps toward _MaskRoghness{B,G,R}. ----
                //   (b58:398 shows the blend rides the post-_RoughnessMin/Max linear roughness, == s.roughness.)
                float roughness = s.roughness;
                roughness = lerp(roughness, _MaskRoghnessB, wB);  // b193:225 (_446) / b58:402 (_524)
                roughness = lerp(roughness, _MaskRoghnessG, wG);  // b193:229 (_466) / b58:406 (_544)
                roughness = lerp(roughness, _MaskRoghnessR, wR);  // b193:230 (SV_Target_3.z) / b58:409 (_563)
                s.roughness = roughness;

                // ---- recompute f0 from the masked albedo+metallic (b9:318-325; s.specular = 0.08*_Specular is metallic-free). ----
                float dielF0 = 0.07999999821186065673828125 * _Specular;                     // b9:318 (_504) = 0.08*_Specular
                s.f0 = lerp(dielF0.xxx, s.albedo, s.metallic);                                // b9:322-325 (_513..516)
            #endif
            }

            // -------------------------------------------------------------------------------------
            // LitEffectDisturbDissolve — _USE_DISSOLVE dissolve clip + emissive edge (+ _USE_DISTURB UV warp).
            //   1:1, GROUND TRUTH = the ISOLATED single-keyword GBuffer blob liteffect/Sub0_Pass0_Fragment_b239.hlsl
            //   (liteffect.shader:924 `&& defined(_USE_DISSOLVE) &&` all-other-feature-OFF branch), DECODED via the
            //   CLEAN-NAMED Rosetta littransparent/Sub0_Pass0_Fragment_b44.hlsl (littransparent.shader has _USE_DISSOLVE;
            //   b44 keeps every _Dissolve* token clean: cbuffer lines 154-187, dissolve math 441-445/495). The _USE_DISTURB
            //   UV-warp delta is from liteffect b259 (DISSOLVE+DISTURB) diffed against b239 (DISSOLVE) — b259:211-229.
            //
            //   ALIAS DECODE (b239 register-collided -> clean, confirmed slot-for-slot vs b44):
            //     _BaseColorMap_ST_at_320 (c20) .y=_DissolveEdgeSharp  .z=_DissolveScheduleOffset  .w=_DissolveEmissiveEdge
            //       (b44:163-165 the SAME three at c33.y/.z/.w; clip b44:445 uses .y, emissive band b44:495 uses .w/.y).
            //     _NormalMap_ST.xyz (c21)  =  _DissolveDir.xyz   (object-space sweep axis; b44:176 _DissolveDir c37, the
            //       SAME `mul(unity_ObjectToWorld, dir)` projection b44:443).
            //     _OffsetTex_ST.xyz (c23)  =  _DissolveEmissiveColor.xyz  (HDR edge color; b44:183 _DissolveEmissiveColor c39).
            //     _DissolveUVRotate/_DissolveUVSpeed/_DissolveTex_ST/_DissolveScanSchedule/_DissolveScanWidth already clean in b239.
            //   _USE_DISTURB decode (b259, formula-role — NO blob anywhere keeps clean _Disturb* names, same as the
            //     emissive-anim aliases): _ParallaxMinBrightness(c26)=_DisturbUVSpeed.x (U scroll), _UseVertexColorMask
            //     (c26.y)=_DisturbUVSpeed.y (V scroll), _CutOffDirection_at_432(c27)=_DisturbTex_ST (.xy tile/.zw offset),
            //     _OffsetSwitchDir(c25)=disturb sample re-center, _OffsetIntensity_at_404(c25.y)=_DisturbUIntensity,
            //     _Bi_Offset(c25.z)=_DisturbVIntensity, _BaseColorMap_ST_at_320.x(c20.x)=_DisturbWarpScale (un-anchored, declared).
            //
            //   INFRA SUBSTITUTION (CORE_MATH §1, STYLE_BIBLE §2): the GBuffer blob reconstructs world position from the
            //     depth buffer (b239:191-193,199 `_InvViewProjMatrix * NDC`) because the deferred surface pass has no
            //     interpolated WS. The forward port has `IN.positionWS` directly -> USE IT (the reconstructed `_142/_143/_144`
            //     world point and `IN.positionWS` are the SAME shading-point WS; substitute is exact). Object origin is
            //     `unity_ObjectToWorld._m03/_m13/_m23` (b239:199 `_unity_ObjectToWorld[3u].x/.y/.z`, == the sweep emissive path).
            //
            //   CHANNEL MAP (GBuffer MRT -> forward LitSurfaceData, CORE_MATH §1.4 PORT GUIDANCE):
            //     discard_cond (b239:201)            -> clip()                 (hard dissolve cut)
            //     SV_Target.xyz = edge*EmissiveColor (b239:216-218, MRT0=emission/GI) -> s.emission += edge*_DissolveEmissiveColor.rgb
            //     SV_Target_4.xyz *= (1-edge)        (b239:222-225, MRT4=albedo)       -> s.albedo *= (1-edge), s.f0 recomputed
            // -------------------------------------------------------------------------------------
            // LitEffectDissolveField — the dissolve scalar field `_268` (b239:194-200). Shared by the lit-pass
            //   apply (clip + emissive edge + albedo fade) and the DepthOnly clip, so the cut is identical across
            //   passes (matches the source: the GBuffer `discard` writes depth, and liteffect's DepthOnly ladder
            //   gates on _USE_DISSOLVE, skeleton 1797-1806 / target pass 4 keyword). EXACT blob constants.
            float LitEffectDissolveField(Varyings IN)
            {
                // ---- dissolve UV: scroll uv0 by _DissolveUVSpeed*_Time.y, center at 0.5, rotate by _DissolveUVRotate deg.
                //      (b239:194-198: _141 deg->rad, _143/_144 sin/cos, _170/_172 scrolled-centered uv.)
                float ang = 0.01745329238474369049072265625 * _DissolveUVRotate;                       // b239:194 (_141) deg->rad
                float sinA = sin(ang);                                                                  // b239:195 (_143)
                float cosA = cos(ang);                                                                  // b239:196 (_144)
                float u = mad(_DissolveUVSpeed.x, _Time.y, mad(IN.uv.x, _DissolveTex_ST.x, _DissolveTex_ST.z)) - 0.5;  // b239:197 (_170)
                float v = mad(_DissolveUVSpeed.y, _Time.y, mad(IN.uv.y, _DissolveTex_ST.y, _DissolveTex_ST.w)) - 0.5;  // b239:198 (_172)
                // rotate about UV center, re-bias to 0.5: (dot((u,v),(cos,sin))+0.5, dot((u,v),(-sin,cos))+0.5).
                float2 dissolveUV = float2(dot(float2(u, v), float2(cosA, sinA)) + 0.5,
                                           dot(float2(u, v), float2(-sinA, cosA)) + 0.5);               // b239:200 inner rotated uv

            #if defined(_USE_DISTURB)
                // ---- _USE_DISTURB: sample _DisturbTex at OBJECT-space planar coords (scrolled by time) and ADD its
                //      remapped value * per-axis intensity * _DisturbWarpScale to the dissolve UV (b259:211-229).
                //      worldPos -> object space via the inverse-transform trick (b259:220-222):
                //        objPlanar = (worldPos - O2W[*].w) / |O2W row|^2, then re-projected onto O2W rows 0 and 2.
                float3 col0 = float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20);  // O2W col x (b259:211-213 _165/_170/_175)
                float3 col1 = float3(unity_ObjectToWorld._m01, unity_ObjectToWorld._m11, unity_ObjectToWorld._m21);  // O2W col y (b259:214-216 _185/_190/_195)
                float3 col2 = float3(unity_ObjectToWorld._m02, unity_ObjectToWorld._m12, unity_ObjectToWorld._m22);  // O2W col z (b259:217-219 _204/_209/_214)
                float ox = (IN.positionWS.x - unity_ObjectToWorld._m03) / dot(col0, col0);              // b259:220 (_219)
                float oy = (IN.positionWS.y - unity_ObjectToWorld._m13) / dot(col1, col1);              // b259:221 (_220)
                float oz = (IN.positionWS.z - unity_ObjectToWorld._m23) / dot(col2, col2);              // b259:222 (_221)
                float3 objPlanar = float3(ox, oy, oz);
                // planar X/Z = dot(objPlanar, O2W row0/row2 as a vector) — b259:223 `dot(_219..221, O2W[0]/_O2W[2])`.
                float planarX = dot(objPlanar, float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m01, unity_ObjectToWorld._m02));
                float planarZ = dot(objPlanar, float3(unity_ObjectToWorld._m20, unity_ObjectToWorld._m21, unity_ObjectToWorld._m22));
                float2 disturbUV = float2(mad(_DisturbUVSpeed.x, _Time.y, mad(planarX, _DisturbTex_ST.x, _DisturbTex_ST.z)),
                                          mad(_DisturbUVSpeed.y, _Time.y, mad(planarZ, _DisturbTex_ST.y, _DisturbTex_ST.w)));  // b259:223 uv
                // remap disturb sample: mad(s, 1+_Bi_Disturb, -_Bi_Disturb) (b259:223 outer mad, _OffsetSwitchDir=re-center).
                float disturb = mad(SAMPLE_TEXTURE2D_BIAS(_DisturbTex, sampler_DisturbTex, disturbUV, 0.0).x,
                                    1.0 + _Bi_Disturb, -_Bi_Disturb);                                   // b259:223 (_275); URP macro auto-adds _GlobalMipBias.x
                // warp dissolve UV by the disturb displacement (b259:229 mad(_275*intensity, _at_320.x=_DisturbWarpScale, uv)).
                dissolveUV.x = mad(disturb * _DisturbUIntensity, _DisturbWarpScale, dissolveUV.x);      // b259:229 U
                dissolveUV.y = mad(disturb * _DisturbVIntensity, _DisturbWarpScale, dissolveUV.y);      // b259:229 V
            #endif

                // ---- world-space scan gradient: project (worldPos - objOrigin) onto _DissolveDir (object->world) / scanWidth.
                //      (b239:199 _261; _NormalMap_ST.xyz == _DissolveDir.xyz, transformed by unity_ObjectToWorld rows.)
                float3 objOrigin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);  // b239:199 O2W[3u].xyz
                // dirWS = mul((float3x3)unity_ObjectToWorld, _DissolveDir.xyz). EXACT blob mad order (b239:199):
                //   dirWS.c = mad(O2W[2].c, dir.z, mad(O2W[0].c, dir.x, O2W[1].c * dir.y)), with O2W[row].col == _m{row}{col}.
                float3 dirWS = float3(
                    mad(unity_ObjectToWorld._m20, _DissolveDir.z, mad(unity_ObjectToWorld._m00, _DissolveDir.x, unity_ObjectToWorld._m10 * _DissolveDir.y)),   // O2W[*].x col
                    mad(unity_ObjectToWorld._m21, _DissolveDir.z, mad(unity_ObjectToWorld._m01, _DissolveDir.x, unity_ObjectToWorld._m11 * _DissolveDir.y)),   // O2W[*].y col
                    mad(unity_ObjectToWorld._m22, _DissolveDir.z, mad(unity_ObjectToWorld._m02, _DissolveDir.x, unity_ObjectToWorld._m12 * _DissolveDir.y)));  // O2W[*].z col
                float scan = dot(IN.positionWS - objOrigin, dirWS) / _DissolveScanWidth;                // b239:199 (_261)

                // ---- dissolve field (b239:200 _268). VFX per-draw _unity_Float4x5_Param4.x folds to 0 (no VFX graph,
                //      same standalone fold as the emissive path), so the schedule bias term = -(_DissolveScheduleOffset)*2.02 - 1.01.
                //      2.019999980926513671875 / 1.0099999904632568359375 are EXACT blob constants (b239:200).
                float scheduleBias = mad(_DissolveScheduleOffset, 2.019999980926513671875, -1.0099999904632568359375);  // b239:200 (Param4.x=0)
                float noise = SAMPLE_TEXTURE2D_BIAS(_DissolveTex, sampler_DissolveTex, dissolveUV, 0.0).x;    // b239:200 T3 dissolve noise; URP macro auto-adds _GlobalMipBias.x
                return ((-scheduleBias + noise) + (scan - _DissolveScanSchedule)) - 1.0;                 // b239:200 (_268)
            }

            // LitEffectDissolveClip — the dissolve hard cut, for passes that only need to discard (DepthOnly).
            //   discard where clamp(field*_DissolveEdgeSharp,0,1) - 0.02 < 0. EXACT 0.0199999995529651641845703125 (b239:201).
            void LitEffectDissolveClip(Varyings IN)
            {
            #if defined(_USE_DISSOLVE)
                float field = LitEffectDissolveField(IN);                                               // b239:194-200 (_268)
                clip(clamp(field * _DissolveEdgeSharp, 0.0, 1.0) - 0.0199999995529651641845703125);     // b239:201 discard_cond
            #endif
            }

            // -------------------------------------------------------------------------------------
            // LitEffectDisturbDissolve — full lit-pass apply: clip + emissive edge + albedo fade.
            // -------------------------------------------------------------------------------------
            void LitEffectDisturbDissolve(inout LitSurfaceData s, Varyings IN)
            {
            #if defined(_USE_DISSOLVE)
                float field = LitEffectDissolveField(IN);                                               // b239:194-200 (_268)
                // ---- clip: discard where clamp(field*_DissolveEdgeSharp,0,1) - 0.02 < 0 (b239:201).
                clip(clamp(field * _DissolveEdgeSharp, 0.0, 1.0) - 0.0199999995529651641845703125);     // b239:201 discard_cond
                // ---- emissive edge factor: clamp((_DissolveEmissiveEdge - field) * _DissolveEdgeSharp, 0, 1) (b239:215 _389;
                //      b44:495 the SAME clamp((_DissolveEmissiveEdge - field)*_DissolveEdgeSharp)).
                float edge = clamp((_DissolveEmissiveEdge - field) * _DissolveEdgeSharp, 0.0, 1.0);      // b239:215 (_389)
                // emissive output: edge * _DissolveEmissiveColor.rgb -> MRT0 (emission/GI). Forward: add to s.emission.
                s.emission += edge * _DissolveEmissiveColor.rgb;                                         // b239:216-218 SV_Target.xyz
                // albedo fades to black at the edge: MRT4.rgb *= (1 - edge). Recompute f0 from the faded albedo.
                s.albedo *= (1.0 - edge);                                                                // b239:222-225 SV_Target_4.xyz * _440
                float dielF0 = 0.07999999821186065673828125 * _Specular;                                 // b9:318 (_504) 0.08*_Specular
                s.f0 = lerp(dielF0.xxx, s.albedo, s.metallic);                                            // b9:322-325 keep f0 consistent with faded albedo
            #endif
            }

            // -------------------------------------------------------------------------------------
            // LitEffectApplyFeatures — single entry the LitEffect fragments call after LitBuildSurface.
            // Closeable keyword deltas mutate `s` here; GAP-A keywords (above) are no-ops pending a
            // clean-named Rosetta (the isolated single-keyword blobs alias feature uniforms onto unrelated
            // base names with no anchor to recover the routing/channel constants to a verifiable 1:1 standard).
            // -------------------------------------------------------------------------------------
            void LitEffectApplyFeatures(inout LitSurfaceData s, Varyings IN, bool isFrontFace)
            {
                LitEffectDetail(s, IN, isFrontFace);
                LitEffectTriChannelMask(s, IN);   // _TRI_CHANNEL_MASK: 3-channel albedo/roughness/metallic remap (before emissive, which reads albedo)
                LitEffectEmissive(s, IN);
                LitEffectDisturbDissolve(s, IN);  // _USE_DISSOLVE clip+emissive-edge+albedo-fade (+_USE_DISTURB UV warp); runs after albedo/emission are final

            #if defined(_PARALLAX_MAP) || defined(_PARALLAX_MAP_WORLDSPACE)
                // Steep-parallax emissive pattern. Additive to emission.
                float3 emPreMaster; float3 colorLerp; float2 pHeights; float3 camFwd;
                float3 parallaxEm = LitEffectParallax(IN, s.normalWS, emPreMaster, colorLerp, pHeights, camFwd);
                #ifdef _PARALLAX_MAP_WORLDSPACE
                    // WORLDSPACE: b11:355 emits ONLY the world-PATTERN term (_1182*_1014*_ParallaxIntensity),
                    //   where _1014 is built from _885..887 (= plainEm * colorLerp * maskMapRGB * strength) * pattern
                    //   color. The plain parallax emission is CONSUMED INTO the pattern (NOT a separate additive
                    //   term), so do NOT also add `parallaxEm`. (The _WorldParallaxAdditionalColor interaction term
                    //   _1160*_1142*((_1014+0.3)*_WorldParallaxAdditionalColor) rides host interpolators TEXCOORD_4.x
                    //   + TEXCOORD_7.y + the _ParallaxMask/_ParallaxMap light-mask channels and is neutral without the
                    //   HG interaction feed — omitted; flagged in the audit.)
                    s.emission += LitEffectWorldParallax(emPreMaster, colorLerp, pHeights, IN.positionWS, IN.normalWS);
                #else
                    // PLAIN: b219:346 SV_Target = parallaxEm * _ParallaxIntensity, added straight to emission.
                    s.emission += parallaxEm;
                #endif
            #endif
            }
        ENDHLSL

        // ============================================================================================
        // Pass 1: HGBuffer  (liteffect deferred path -> URP UniversalGBuffer; LIGHTMODE GBuffer -> UniversalGBuffer).
        // Render-state 1:1 liteffect.shader:211-225: ZClip On (URP default), ZTest [_ZTestGBuffer], Cull [_CullMode],
        //   Stencil { Ref [_StencilRef] Comp Always Pass Replace }. The HG 5-MRT layout is NOT a URP GBuffer
        //   (CORE_MATH §1.4 PORT GUIDANCE) — LitPackGBuffer writes URP's native 4-target GBuffer.
        // ============================================================================================
        Pass {
            Name "HGBuffer"
            Tags { "LightMode"="UniversalGBuffer" }
            ZTest [_ZTestGBuffer]
            ZWrite [_ZWrite]
            Cull [_Cull]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitVertex
                #pragma fragment LitGBufferFragment
                // material feature keywords — liteffect HGBuffer ladder (skeleton lines 232-250; HG multi_compile_local -> URP shader_feature_local)
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma shader_feature_local _TWO_BASEMAP
                #pragma shader_feature_local _TRI_CHANNEL_MASK
                #pragma shader_feature_local _EMISSIVE_MAP
                #pragma shader_feature_local _EMISSIVE_MASK
                #pragma shader_feature_local _EMISSIVE_NOMAP
                #pragma shader_feature_local _EMISSIVE_ANIM
                #pragma shader_feature_local _EMISSIVE_ANIM_SWEEP
                #pragma shader_feature_local _PARALLAX_MAP
                #pragma shader_feature_local _USE_DISTURB
                #pragma shader_feature_local _USE_VERTOFFSET
                #pragma shader_feature_local _USE_DISSOLVE
                #pragma shader_feature_local _VAT_SOFTBODY
                #pragma shader_feature_local _VAT_RIGIDBODY
                #pragma shader_feature_local _UNLOAD_ROT_TEX
                #pragma shader_feature_local _PARALLAX_MAP_WORLDSPACE
                #pragma shader_feature_local _DETAIL_MAP
                #pragma shader_feature_local _UV_ANIMATION                       // vertex uv-scroll (LitPackAnimatedUV); surface-pass only — this is the GBuffer/surface pass lit.shader:497 compiles the keyword on (b614:564-567)
                // URP system keywords
                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH
                #pragma multi_compile _ LIGHTMAP_ON
                #pragma multi_compile _ DIRLIGHTMAP_COMBINED
                #pragma multi_compile_fragment _ _MIXED_LIGHTING_SUBTRACTIVE
                #pragma multi_compile_fragment _ _GBUFFER_NORMALS_OCT
                #pragma multi_compile_instancing

                Varyings LitVertex(Attributes IN);                              // _core/CoreVertex.hlsl
                LitSurfaceData LitBuildSurface(Varyings IN, bool isFrontFace);  // _core/CoreSurface.hlsl
                void LitEffectApplyFeatures(inout LitSurfaceData s, Varyings IN, bool isFrontFace); // HLSLINCLUDE (liteffect deltas)
                void LitPackGBuffer(LitSurfaceData s, Varyings IN,
                                    out half4 outGBuffer0, out half4 outGBuffer1,
                                    out half4 outGBuffer2, out half4 outGBuffer3);  // _core/CoreMath.hlsl

                struct GBufferOut
                {
                    half4 GBuffer0 : SV_Target0;   // albedo, material flags
                    half4 GBuffer1 : SV_Target1;   // reflectivity, occlusion
                    half4 GBuffer2 : SV_Target2;   // normalWS + smoothness
                    half4 GBuffer3 : SV_Target3;   // emission / GI
                };

                GBufferOut LitGBufferFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace)
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                    LitSurfaceData s = LitBuildSurface(IN, isFrontFace);
                    LitEffectApplyFeatures(s, IN, isFrontFace);   // liteffect keyword deltas (emissive ported 1:1)
                    GBufferOut o;
                    LitPackGBuffer(s, IN, o.GBuffer0, o.GBuffer1, o.GBuffer2, o.GBuffer3);
                    return o;
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2: ForwardLit  (URP forward render path). liteffect has NO forward pass (deferred-only:
        //   its HGBuffer fragment b185 only PACKS surface params, no lighting). To render under URP's
        //   forward path the surface must be lit in-fragment; LitForwardLighting (CoreMath, 1:1 b9 lighting
        //   spine shared by the lit family) resolves it. Maps to UniversalForwardOnly.
        // ============================================================================================
        Pass {
            Name "ForwardLit"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] OneMinusSrcAlpha
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_Cull]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitVertex
                #pragma fragment LitForwardFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma shader_feature_local _TWO_BASEMAP
                #pragma shader_feature_local _TRI_CHANNEL_MASK
                #pragma shader_feature_local _EMISSIVE_MAP
                #pragma shader_feature_local _EMISSIVE_MASK
                #pragma shader_feature_local _EMISSIVE_NOMAP
                #pragma shader_feature_local _EMISSIVE_ANIM
                #pragma shader_feature_local _EMISSIVE_ANIM_SWEEP
                #pragma shader_feature_local _PARALLAX_MAP
                #pragma shader_feature_local _USE_DISTURB
                #pragma shader_feature_local _USE_VERTOFFSET
                #pragma shader_feature_local _USE_DISSOLVE
                #pragma shader_feature_local _VAT_SOFTBODY
                #pragma shader_feature_local _VAT_RIGIDBODY
                #pragma shader_feature_local _UNLOAD_ROT_TEX
                #pragma shader_feature_local _PARALLAX_MAP_WORLDSPACE
                #pragma shader_feature_local _DETAIL_MAP
                #pragma shader_feature_local _UV_ANIMATION                       // vertex uv-scroll (LitPackAnimatedUV); surface-pass only — ForwardLit is the URP forward twin of the GBuffer surface lit.shader:497 scrolls (b614:564-567); NOT on shadow/depth
                #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
                #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH
                #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
                #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
                #pragma multi_compile_fragment _ _REFLECTION_PROBE_BOX_PROJECTION
                #pragma multi_compile_fragment _ _SCREEN_SPACE_OCCLUSION
                #pragma multi_compile_fog
                #pragma multi_compile_instancing

                Varyings LitVertex(Attributes IN);                              // _core/CoreVertex.hlsl
                LitSurfaceData LitBuildSurface(Varyings IN, bool isFrontFace);  // _core/CoreSurface.hlsl
                void LitEffectApplyFeatures(inout LitSurfaceData s, Varyings IN, bool isFrontFace); // HLSLINCLUDE (liteffect deltas)
                half4 LitForwardLighting(LitSurfaceData s, Varyings IN);        // _core/CoreMath.hlsl

                half4 LitForwardFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                    LitSurfaceData s = LitBuildSurface(IN, isFrontFace);
                    LitEffectApplyFeatures(s, IN, isFrontFace);   // liteffect keyword deltas (emissive ported 1:1)
                    return LitForwardLighting(s, IN);
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 3: ShadowCaster  (CORE_MATH §4.1 — position-only + URP ApplyShadowBias; alpha-clip under keyword).
        // Source LIGHTMODE SHADOWCASTER (liteffect.shader:1380), Cull [_ShadowCullMode] (1377), Offset [_ShadowBias]
        //   (1378) -> URP's ApplyShadowBias subsumes the bias. Fragment b589 is EMPTY (depth-only).
        // ============================================================================================
        Pass {
            Name "ShadowCaster"
            Tags { "LightMode"="ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_ShadowCullMode]
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitShadowVertex
                #pragma fragment LitShadowFragment
                // liteffect ShadowCaster ladder keywords (skeleton lines 1388-1396, surface subset)
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma shader_feature_local _TWO_BASEMAP
                #pragma shader_feature_local _USE_VERTOFFSET
                // NO _UV_ANIMATION here: ground-truth lit.shader compiles `multi_compile_local _ _UV_ANIMATION`
                //   ONLY in the HGBuffer/surface pass (lit.shader:497); its ShadowCaster ladder (lit.shader:2255-2716)
                //   has ZERO _UV_ANIMATION branches, so the cast shadow samples UN-scrolled uv. _USE_VERTOFFSET DOES
                //   recur in the shadow ladder (lit.shader:2275) because a displaced vertex must cast a displaced
                //   shadow — _UV_ANIMATION is a SURFACE-uv-only feature and does not. 1:1 = scroll only the surface.
                #pragma shader_feature_local _VAT_SOFTBODY
                #pragma shader_feature_local _VAT_RIGIDBODY
                #pragma shader_feature_local _UNLOAD_ROT_TEX
                #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW
                #pragma multi_compile_instancing

                // _LightDirection/_LightPosition declared in the shared HLSLINCLUDE (before CoreVertex.hlsl,
                //   which defines LitShadowVertex reading them) — single declaration site, no per-pass duplicate.

                Varyings LitShadowVertex(Attributes IN);   // _core/CoreVertex.hlsl (uses _LightDirection/_LightPosition + ApplyShadowBias)

                half4 LitShadowFragment(Varyings IN) : SV_Target
                {
                    // depth-only (b589 EMPTY); alpha-clip only under _ALPHATEST_ON (CORE_MATH §4.2).
                    #ifdef _ALPHATEST_ON
                        LitAlphaClip(IN);                  // _core/CoreSurface.hlsl helper
                    #endif
                    return 0;
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 4: DepthOnly  (CORE_MATH §4.3 — camera clip, depth write; alpha-clip under keyword).
        // Source LIGHTMODE DepthOnly (liteffect.shader:1789), ZClip On, Cull [_CullMode] (1780),
        //   Stencil { Ref [_StencilRef] Comp Always Pass Replace } (1781-1787). Fragment b765 is EMPTY.
        // ============================================================================================
        Pass {
            Name "DepthOnly"
            Tags { "LightMode"="DepthOnly" }
            ZWrite On
            ZTest LEqual
            ColorMask R
            Cull [_Cull]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }   // liteffect.shader:1779-1780 binds [_StencilRef] (NOT _PreDepthStencilRef); source DepthOnly + GBuffer share the same stencil ref
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitDepthVertex
                #pragma fragment LitDepthFragment
                // liteffect DepthOnly ladder keywords (skeleton lines 1797-1806, surface subset)
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma shader_feature_local _TWO_BASEMAP
                #pragma shader_feature_local _USE_VERTOFFSET
                // NO _UV_ANIMATION here: ground-truth lit.shader DepthOnly ladder (lit.shader:2717-3172) has ZERO
                //   _UV_ANIMATION branches (the keyword is compiled ONLY in the surface/HGBuffer pass, lit.shader:497).
                //   So the depth/alpha-clip samples UN-scrolled uv. (Contrast _USE_VERTOFFSET, which IS in the depth
                //   ladder at lit.shader:2743 — vertex displacement affects depth; a surface-uv scroll does not.)
                #pragma shader_feature_local _USE_DISSOLVE
                #pragma shader_feature_local _VAT_SOFTBODY
                #pragma shader_feature_local _VAT_RIGIDBODY
                #pragma shader_feature_local _UNLOAD_ROT_TEX
                #pragma multi_compile_instancing

                Varyings LitDepthVertex(Attributes IN);   // _core/CoreVertex.hlsl
                void LitEffectDissolveClip(Varyings IN);  // HLSLINCLUDE (liteffect dissolve hard cut)

                half4 LitDepthFragment(Varyings IN) : SV_Target
                {
                    #ifdef _ALPHATEST_ON
                        LitAlphaClip(IN);                  // _core/CoreSurface.hlsl helper
                    #endif
                    LitEffectDissolveClip(IN);             // _USE_DISSOLVE: dissolved-away pixels must not write depth (matches GBuffer discard)
                    return 0;
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 5: DepthNormalsOnly  (URP SSAO / depth-normals prepass — STYLE_BIBLE §7). No HG blob analog
        //   (HG packed normals into its GBuffer); URP's prepass needs world position + TBN so CoreSurface
        //   rebuilds the per-pixel normal. Same camera transform as the HGBuffer vertex.
        // ============================================================================================
        Pass {
            Name "DepthNormalsOnly"
            Tags { "LightMode"="DepthNormalsOnly" }
            ZWrite On
            Cull [_Cull]
            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex   LitDepthNormalsVertex
                #pragma fragment LitDepthNormalsFragment
                #pragma shader_feature_local _ALPHATEST_ON
                #pragma shader_feature_local _DETAIL_MAP
                #pragma shader_feature_local _USE_VERTOFFSET
                // VAT vertex displacement IS compiled here (like _USE_VERTOFFSET above): the depth-normals prepass
                //   feeds SSAO/contact shadows, so it must track the DISPLACED + REORIENTED silhouette the VAT cache
                //   produces (b266/b288/b308 vertex math is shared across HG's surface/depth ladders). Ported in
                //   _core/CoreVertex.hlsl :: LitEffectApplyVAT (via LitDepthNormalsVertex -> LitFillCameraVaryings).
                #pragma shader_feature_local _VAT_SOFTBODY
                #pragma shader_feature_local _VAT_RIGIDBODY
                #pragma shader_feature_local _UNLOAD_ROT_TEX
                // NO _UV_ANIMATION here: this URP-added depth-normals prepass has no HG analog; its nearest source
                //   sibling (DepthOnly) does NOT compile _UV_ANIMATION (lit.shader compiles it only in the surface/
                //   HGBuffer pass, :497), so the prepass tracks the same UN-scrolled uv the source depth path uses.
                //   (The source never feeds a scrolled normal into an SSAO prepass — surface-uv scroll is GBuffer-only.)
                #pragma multi_compile_instancing

                Varyings LitDepthNormalsVertex(Attributes IN);                 // _core/CoreVertex.hlsl
                LitSurfaceData LitBuildSurface(Varyings IN, bool isFrontFace);  // _core/CoreSurface.hlsl
                void LitEffectDetail(inout LitSurfaceData s, Varyings IN, bool isFrontFace);   // HLSLINCLUDE (detail normal RNM blend)

                half4 LitDepthNormalsFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
                {
                    UNITY_SETUP_INSTANCE_ID(IN);
                    #ifdef _ALPHATEST_ON
                        LitAlphaClip(IN);                  // _core/CoreSurface.hlsl helper
                    #endif
                    LitSurfaceData s = LitBuildSurface(IN, isFrontFace);
                    LitEffectDetail(s, IN, isFrontFace);   // _DETAIL_MAP perturbs the world normal the prepass writes
                    return half4(NormalizeNormalPerPixel(s.normalWS), 0.0);
                }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 6: RayTracingReflection  (HGRP RT-injection hook — EMPTY STUB; liteffect.shader:2354-2365 has
        //   render-state but NO HLSLPROGRAM. Kept for material/tag parity; no body, URP never schedules it).
        // ============================================================================================
        Pass {
            Name "RayTracingReflection"
            Tags { "LightMode"="RayTracingReflection" }
            ZTest Equal
            ZWrite Off
            Cull Off
            // intentionally no HLSLPROGRAM (source pass is render-state only — drop body, keep stub).
        }
    }
}
