#ifndef HGRP_LIT_CORE_SURFACE_INCLUDED
#define HGRP_LIT_CORE_SURFACE_INCLUDED

// =============================================================================
// CoreSurface.hlsl — FRAGMENT SURFACE ASSEMBLY for the merged URP Lit shader.
//
// Owns: LitBuildSurface(Varyings, bool isFrontFace) -> LitSurfaceData
//       (the base PBR surface path: UV-set select, 3-map sample, DXT5nm-style
//        normal decode + two-sided sign, TBN world normal, roughness/metallic/
//        occlusion/albedo tint-cover, F0/diffuse split, SampleSH ambient).
//       LitAlphaClip(Varyings) — alpha-clip helper for ShadowCaster/DepthOnly/
//       DepthNormalsOnly passes under _ALPHATEST_ON.
//
// GROUND TRUTH (1:1, MATH/constants/branch-bounds/signs/swizzles):
//   litforward/Sub0_Pass0_Fragment_b9.hlsl  L271-372  (ForwardLit base surface)
//   lit/Sub0_Pass0_Fragment_b281.hlsl       L153-194  (GBuffer base surface — same math)
//   CORE_MATH §2.2 (surface) + §2.3 (F0/diffuse split) + §1.2-1.3 (GBuffer cross-check)
//
// Leaf feature modules (NormalMapping / Emissive / Detail / Parallax / TriChannelMask /
// LayerBlend / Subsurface / Porosity / ...) plug into the // <<MODULE: ...>> hooks
// below; each mutates LitSurfaceData. This file authors ONLY the always-on base path.
//
// INFRA substitution (CORE_MATH §2.12, NOT a deviation):
//   _GlobalMipBias    HGRP TAA-upscale mip bias global -> URP has no analog in this
//                     core version; declared as a neutral global float (default 0),
//                     applied via SAMPLE_TEXTURE2D_BIAS (the infra-correct SampleBias).
//   SampleBias(...)   -> SAMPLE_TEXTURE2D_BIAS(tex, sampler, uv, bias)   (D3D11.hlsl:124)
//   ambient SH        -> SampleSH(N)   (Lighting.hlsl), set into s.bakedGI for the
//                        composite (CORE_MATH §2.4 PORT note); IV-cascade infra dropped.
// =============================================================================

// HGRP TAA-upscale global mip bias (b9:52 packoffset c108). URP ALREADY provides this exact
// infra global: `float2 _GlobalMipBias` (Input.hlsl:112), and URP's SAMPLE_TEXTURE2D_BIAS macro
// (Core.hlsl:200-204) AUTOMATICALLY folds `_GlobalMipBias.x` into every sampled bias. So the
// HGRP "sample at _GlobalMipBias" intent is realized 1:1 by passing bias=0 (URP adds the global);
// the normal map's extra `+ _TAAUNormalBiasReverse` rides on top (b9:287). Do NOT redeclare the
// symbol here — URP owns it as float2, and a local `float _GlobalMipBias;` is a duplicate-symbol /
// type-conflict compile error (CORE_MATH §2.12 infra substitution — REQUIRED, not a deviation).

// -----------------------------------------------------------------------------
// LitBuildSurface — base surface assembly.  b9 L271-372 (cross-check b281 L153-194).
// -----------------------------------------------------------------------------
LitSurfaceData LitBuildSurface(Varyings IN, bool isFrontFace)
{
    LitSurfaceData s = (LitSurfaceData)0;

    // ---- interpolator unpack (frozen Varyings -> blob TEXCOORD_N) ----
    float3 positionWS = IN.positionWS;       // b9 TEXCOORD  (worldPos / shading point P)
    float2 uv0        = IN.uv.xy;            // b9 TEXCOORD_1
    float2 uv1        = IN.uv.zw;            // b9 TEXCOORD_2
    float3 normalGeo  = IN.normalWS;        // b9 TEXCOORD_3 (geometric world normal)
    float4 tangentWS  = IN.tangentWS;       // b9 TEXCOORD_4 (.xyz tangent, .w sign)

    // ---- tangent handedness sign: _147 = (TEXCOORD_4.w>0)?+1:-1  (b9:271) ----
    float tangentSign = (tangentWS.w > 0.0) ? 1.0 : -1.0;

    // ---- UV-set select + per-map _ST tiling  (b9:282-286) ----
    // duv = uv1 - uv0 ; uvBase = (uv0 + _BaseUVSet*duv)*BaseST.xy + BaseST.zw
    //                   uvPbr  = (uv0 + _BasePbrMapUVSet*duv)*NormalST.xy + NormalST.zw
    // (b9 reuses the _NormalMap_ST PBR uv for BOTH _NormalMap and _MROMap: L284/285/292.)
    float duvX = uv1.x - uv0.x;             // b9:282 (_222)
    float duvY = uv1.y - uv0.y;             // b9:283 (_223)
    float2 uvBase = float2(
        mad(mad(_BaseUVSet,    duvX, uv0.x), _BaseColorMap_ST.x, _BaseColorMap_ST.z),
        mad(mad(_BaseUVSet,    duvY, uv0.y), _BaseColorMap_ST.y, _BaseColorMap_ST.w));   // b9:286
    float2 uvPbr = float2(
        mad(mad(_BasePbrMapUVSet, duvX, uv0.x), _NormalMap_ST.x, _NormalMap_ST.z),
        mad(mad(_BasePbrMapUVSet, duvY, uv0.y), _NormalMap_ST.y, _NormalMap_ST.w));      // b9:284-285

    // ---- sample the base maps + channel-route per packing mode ----
    // mip biases per ground truth: albedo & MRO at _GlobalMipBias; NORMAL at
    // _GlobalMipBias + _TAAUNormalBiasReverse. (Blob authority: the +bias rides
    // the _NormalMap sample, NOT the MRO sample — CORE_MATH §2.2 L204.)
    // URP's SAMPLE_TEXTURE2D_BIAS auto-adds _GlobalMipBias.x (Core.hlsl:200-204); pass bias=0 for
    // albedo/MRO (= HGRP "sample at _GlobalMipBias"), and _TAAUNormalBiasReverse for NORMAL.
    float4 baseTex = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uvBase, 0.0);                    // albedo.rgb (+ metallic.a under _TWO_BASEMAP)
    float4 nrm     = SAMPLE_TEXTURE2D_BIAS(_NormalMap,    sampler_NormalMap,    uvPbr,  _TAAUNormalBiasReverse); // normal (+ roughness.z/occlusion.w under _TWO_BASEMAP)

#ifndef _TWO_BASEMAP
    // ===== 3-map BASE packing =====  GROUND TRUTH: 3-map BASE (litforward b9 L286-302 ==
    // liteffectblend b7:142-174). MRO is a separate third texture; normal X uses the DXT5nm
    // (x in .a) reconstruction.
    float4 mro = SAMPLE_TEXTURE2D_BIAS(_MROMap, sampler_MROMap, uvPbr, 0.0);                // b7:148 (_420 = T3.SampleBias, _GlobalMipBias)

    // ---- tangent-space normal decode (DXT5nm-style x in .a) ----
    // Decoded (pre-scale) X/Y feed the nz radicand 1:1 (b7:157 dot(_452,_453)); the
    // *_NormalScale variants feed the TBN matrix (b7:159-161 _460,_461). Keep both:
    //   nxDecode = nrm.x*nrm.w*2-1 ; nyDecode = nrm.y*2-1            (b7:153-154 _452,_453)
    //   nx = nxDecode*_NormalScale ; ny = nyDecode*_NormalScale      (b7:155-156 _460,_461)
    float nxDecode = mad(nrm.x * nrm.w, 2.0, -1.0);   // b7:153 (_452) — UNSCALED, for nz
    float nyDecode = mad(nrm.y,         2.0, -1.0);   // b7:154 (_453) — UNSCALED, for nz
    float nx = nxDecode * _NormalScale;               // b7:155 (_460) — SCALED, for TBN
    float ny = nyDecode * _NormalScale;               // b7:156 (_461) — SCALED, for TBN

    // ---- roughness/metallic/occlusion from the dedicated MRO map ----
    float roughnessT = mro.y;     // b7:174 (_420.y) -> lerp(_RoughnessMin,_RoughnessMax,mro.y)
    float metallicT  = mro.x;     // b7:149-150 (_422 = _420.x) -> lerp(mro.x,_Metallic,saturate(count-1))
    float occlusionT = mro.z;     // b7:151 (_420.z) -> lerp(1,mro.z,_OcclusionStrength)
#else
    // ===== 2-map _TWO_BASEMAP packing =====  GROUND TRUTH 1:1: liteffectblend
    // Sub0_Pass0_Fragment_b9.hlsl L139-174 (== HGRP_Lit / HGRP_LitForward family delta).
    // NO third MRO texture: metallic rides baseTex.w, roughness rides nrm.z, occlusion rides
    // nrm.w. Normal X does NOT multiply by .w (that channel is now metallic), and both decoded
    // tangent components pass a |.| < 0.012 dead-zone before _NormalScale.
    //   metallic  : SV_Target_2.x = lerp(baseTex.w, _Metallic, saturate(count-1))   (b9:140-141, _393)
    //   occlusion : SV_Target_2.y = lerp(1, nrm.w, _OcclusionStrength)              (b9:146, _427.w)
    //   roughness : SV_Target_3.z = lerp(_RoughnessMin, _RoughnessMax, nrm.z)        (b9:171, _427.z)
    //   normal    : nx=(nrm.x*2-1), ny=(nrm.y*2-1); deadzone |c|<0.012 -> 0; *_NormalScale (b9:149-154)
    float metallicT  = baseTex.w;   // b9:140 (_393)
    float occlusionT = nrm.w;       // b9:146 (_427.w)
    float roughnessT = nrm.z;       // b9:171 (_427.z)

    // ---- tangent-space normal decode (NO *.w; 0.012 dead-zone) ----  b9:149-155
    float nxRaw = mad(nrm.x, 2.0, -1.0);   // b9:149 (_483) — no *nrm.w (that slot is metallic)
    float nyRaw = mad(nrm.y, 2.0, -1.0);   // b9:150 (_484)
    // _493/_495 = asfloat((abs<0.012)?0u:asuint(c)) == (abs(c) < 0.012 ? 0 : c)  (b9:151-152)
    // These DEADZONED-but-UNSCALED values feed the nz radicand 1:1 (b9:155 dot(_493,_495));
    // the *_NormalScale variants feed the TBN matrix (b9:156-158 _499,_500).
    float nxDecode = (abs(nxRaw) < 0.01200000010430812835693359375) ? 0.0 : nxRaw;   // b9:151 (_493) — UNSCALED, for nz
    float nyDecode = (abs(nyRaw) < 0.01200000010430812835693359375) ? 0.0 : nyRaw;   // b9:152 (_495) — UNSCALED, for nz
    float nx = nxDecode * _NormalScale;    // b9:153 (_499) — SCALED, for TBN
    float ny = nyDecode * _NormalScale;    // b9:154 (_500) — SCALED, for TBN
#endif

    // ---- albedo + tint-cover  (b9:294-299) ----
    // albedoRaw = saturate(baseTex*_BaseColor*_BaseColorBrighterScale)  (pre-tint, _322..324)
    // baseCol   = lerp(albedoRaw, _BaseColor, _BaseColorTintCover)      (tint-covered, _339..341)
    // The frozen LitSurfaceData.albedo contract = the TINT-COVERED value (baseCol); the lighting
    // composite derives diffuse = s.albedo*(1-metallic) (= b9 _509..511) and f0 from it.
    float3 albedoRaw = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale); // b9:294-296 (_322..324)
    float3 baseCol = lerp(albedoRaw, _BaseColor.rgb, _BaseColorTintCover);               // b9:297-299 (_339..341)

    // ---- opacity: vertex-color.x as alpha gate  (b9:300) ----
    // _349 = mad(_Use_VerexTexColorAsOpacity, color.x - 1, 1) == lerp(1, color.x, flag)
    float opacity = mad(_Use_VerexTexColorAsOpacity, IN.color.x - 1.0, 1.0);           // b9:300 (_349)

    // ---- roughness (linear) + metallic select  (b9:301-302) ----
    // roughnessT/metallicT routed above per packing mode (3-map: MRO tex; 2-map: nrm.z / baseTex.w).
    float roughness = lerp(_RoughnessMin, _RoughnessMax, roughnessT);                  // b7:174 / b9:171 (_361)
    float metallic  = lerp(metallicT, _Metallic, saturate(_BaseTextureMapCount - 1.0)); // b7:149-150 / b9:140-141 (_372)

    // ---- tangent-space Z with two-sided front sign  (b7:157 / b9:155) ----
    // nz = max(sqrt(1 - min(dot(decode,decode), 1)), 1e-16) * frontSign
    // GROUND TRUTH: the radicand uses the DECODED, *_NormalScale-FREE* X/Y (b7:157 dot(_452,_453);
    // b9:155 dot(deadzoned _493,_495)); the scaled nx/ny are reserved for the TBN matrix only.
    // (At _NormalScale=1, nxDecode==nx so this is bit-identical to the prior scaled form.)
    // frontSign = isFrontFace ? +1 : (_TwoSidedNormal>0 ? -1 : +1)
    float frontSign = isFrontFace ? 1.0 : ((_TwoSidedNormal > 0.0) ? -1.0 : 1.0);
    float nz = max(sqrt(1.0 - min(dot(float2(nxDecode, nyDecode), float2(nxDecode, nyDecode)), 1.0)), 1.000000016862383526387164645044e-16) * frontSign; // b7:157 (_480) / b9:155 (_530), 1e-16 clamp

    // ---- world normal via TBN: N = N*nz + T*nx + ny*(tSign*cross(N,T)), normalize ----
    // b9:304-310 (_448..457). B = tangentSign * cross(normalGeo, tangentWS.xyz).
    float3 bitangent = tangentSign * cross(normalGeo, tangentWS.xyz);
    float3 normalWS = normalize(normalGeo * nz + tangentWS.xyz * nx + bitangent * ny); // b9:304-307

    // ---- PBR specular split & F0  (b9:318-325, CORE_MATH §2.3) ----
    // dielF0 = 0.08*_Specular ; F0 = lerp(dielF0, baseCol, metallic).
    // (diffuse term = baseCol*(1-metallic), b9:319-321 (_509..511) — derived in the
    //  lighting composite from s.albedo/s.metallic; not a LitSurfaceData field here.)
    float dielF0 = 0.07999999821186065673828125 * _Specular;            // b9:318 (_504) = 0.08*_Specular
    float3 f0 = lerp(dielF0.xxx, baseCol, metallic);                    // b9:322-325 (_513..516)

    // ---- occlusion  ( mad(_OcclusionStrength, occlusionT-1, 1) = lerp(1, occlusionT, _OcclusionStrength); b7:151 / b9:146 ) ----
    // occlusionT routed above per packing mode (3-map: mro.z; 2-map: nrm.w).
    float occlusion = lerp(1.0, occlusionT, _OcclusionStrength);

    // ---- populate LitSurfaceData (base block; leaf modules extend) ----
    s.albedo    = baseCol;        // tint-covered (frozen contract); diffuse = albedo*(1-metallic) in composite
    s.normalWS  = normalWS;
    s.metallic  = metallic;
    s.roughness = roughness;
    s.occlusion = occlusion;
    s.emission  = 0.0;
    s.alpha     = opacity;
    s.specular  = dielF0.xxx;     // dielectric F0 base = 0.08*_Specular (pre-metallic mix)
    s.f0        = f0;             // final specular color = lerp(0.08*_Specular, baseCol, metallic)

    // ---- ambient (CORE_MATH §2.4 PORT): IV-cascade -> URP SampleSH(N) ----
    s.bakedGI = SampleSH(normalWS);

    // feature-extension fields default neutral (leaf modules overwrite at their hooks)
    s.subsurfaceColor = 0.0;
    s.subsurfaceMask  = 0.0;
    s.thickness       = 0.0;
    s.reflectionColor = 0.0;
    s.reflectionWeight = 0.0;
    s.matcapColor     = 0.0;
    s.fresnelColor    = 0.0;
    s.refractionColor = 0.0;
    s.coatMask        = 0.0;
    s.shadowExtra     = 0.0;

    // ============================================================
    // MODULE HOOKS — leaf-module #ifdef code is inlined here (MERGE_BLUEPRINT §3).
    // In-scope locals modules may read: positionWS, uv0/uv1, uvBase/uvPbr, normalGeo,
    // tangentWS, tangentSign, baseTex/nrm/mro, albedoRaw/baseCol, nx/ny/nz, normalWS.
    // View vector available via IN.viewDirWS (unnormalized camera->fragment). Modules
    // mutate `s` (and may rewrite normalWS/roughness/metallic/albedo before s is filled
    // if the integrator orders them earlier per hookNotes).
    // ============================================================
    // <<MODULE: Porosity>>                       // (runtime, no keyword) — AO/spec-occ from _PorosityFactorX/Y/Z
    // <<MODULE: NormalMapping / MacroNormal>>    // _MACRO_NORMAL_MAP
    // <<MODULE: Detail>>                         // _DETAIL_MAP
    // <<MODULE: TriChannelMask>>                 // _TRI_CHANNEL_MASK (+_TRI_CHANNEL_MASK_SWITCH_TEXTURE)
    // <<MODULE: Parallax>>                       // _PARALLAX_MAP / _PARALLAX_MAP_PBR / _PARALLAX_MAP_WORLDSPACE
    // <<MODULE: ParallaxDeform>>                 // _PARALLAX_DEFORM
    // <<MODULE: InteriorMapping>>                // _INTERIORMAPPING / _INTERIOR_PARALLAX
    // <<MODULE: LayerBlend>>                     // _LAYERBLEND / _LAYERBLEND_MASK / _LAYERBLEND_TOP / _LAYERBLEND_MOSS / _LAYERBLEND_NOISEBLEND
    // <<MODULE: TerrainBlend>>                   // _TERRAIN_BLEND / _TERRAIN_BLEND_FROM_HEIGHT / _TERRAIN_BLEND_NOISE
    // <<MODULE: Subsurface>>                     // _SUBSURFACE / _SUBSURFACE_DEFAULTLIT / _SUBSURFACE_THICKNESSMAP
    // <<MODULE: SubsurfaceProfile>>              // _UseSubsurfaceProfile
    // <<MODULE: Emissive>>                       // _EMISSIVE_MAP / _EMISSIVE_MASK / _EMISSIVE_NOMAP
    // <<MODULE: EmissiveAnim>>                   // _EMISSIVE_ANIM
    // <<MODULE: EmissiveSweep>>                  // _EMISSIVE_ANIM_SWEEP
    // <<MODULE: Matcap>>                         // _MATCAP
    // <<MODULE: FakeGlint>>                      // _FAKEGLINT
    // <<MODULE: FakeVolume>>                     // _FAKE_VOLUME / _FAKE_CRACK_LAYER / _FAKE_CRACK_CSM / _FAKE_REFRACTION / _FAKE_DUST_LAYER
    // <<MODULE: CustomIBL>>                      // _CUSTOM_IBL
    // <<MODULE: ThinFilm>>                       // _THIN_FILM
    // <<MODULE: PlanarReflection>>               // _PLANAR_REFLECTION
    // <<MODULE: ObjectBlend>>                    // (Erosion pass, no keyword)
    // <<MODULE: Disturb_Dissolve>>               // _USE_DISTURB / _USE_DISSOLVE
    // <<MODULE: Fresnel>>                        // _USE_FRESNEL (transparent)
    // <<MODULE: Refraction>>                     // _USE_REFRACTION / _GLASS_REFRACTION_SCENECOLOR / _USE_HIGH_REFLECTION / _FULLY_TRANSPARENT
    // <<MODULE: ReceiveLocalLightShadow>>        // _RECEIVE_LOCAL_LIGHT_SHADOW

    return s;
}

// -----------------------------------------------------------------------------
// LitAlphaClip — depth/shadow alpha-clip helper.  Called under _ALPHATEST_ON only
// (ShadowCaster / DepthOnly / DepthNormalsOnly fragments). b9 base path has NO clip;
// the clip lives in the keyword branch (CORE_MATH §4.2/§4.4, STYLE_BIBLE §6).
// _AlphaMaskChannel: 0 = BaseColor.A, 1 = NRO.A (the _NormalMap alpha). Threshold
// _AlphaClipThreshold. UVs computed exactly as the base surface (b9:282-286).
// -----------------------------------------------------------------------------
void LitAlphaClip(Varyings IN)
{
#ifdef _ALPHATEST_ON
    float2 uv0 = IN.uv.xy;
    float2 uv1 = IN.uv.zw;
    float duvX = uv1.x - uv0.x;
    float duvY = uv1.y - uv0.y;
    float2 uvBase = float2(
        mad(mad(_BaseUVSet,    duvX, uv0.x), _BaseColorMap_ST.x, _BaseColorMap_ST.z),
        mad(mad(_BaseUVSet,    duvY, uv0.y), _BaseColorMap_ST.y, _BaseColorMap_ST.w));
    float2 uvPbr = float2(
        mad(mad(_BasePbrMapUVSet, duvX, uv0.x), _NormalMap_ST.x, _NormalMap_ST.z),
        mad(mad(_BasePbrMapUVSet, duvY, uv0.y), _NormalMap_ST.y, _NormalMap_ST.w));

    float baseA = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uvBase, 0.0).a * _BaseColor.a;     // URP auto-adds _GlobalMipBias.x
    float nroA  = SAMPLE_TEXTURE2D_BIAS(_NormalMap,    sampler_NormalMap,    uvPbr,  _TAAUNormalBiasReverse).a; // + _GlobalMipBias.x via macro
    float alpha = (_AlphaMaskChannel < 0.5) ? baseA : nroA;
    clip(alpha - _AlphaClipThreshold);
#endif
}

#endif // HGRP_LIT_CORE_SURFACE_INCLUDED
