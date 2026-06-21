#ifndef HGRP_LIT_CORE_MATH_INCLUDED
#define HGRP_LIT_CORE_MATH_INCLUDED

// ============================================================================================
// CoreMath.hlsl  —  Lit family LIGHTING / BRDF core (HGRP -> URP, 1:1).
// OWNED by the lighting agent. This file is #include'd LAST in HGRP_Lit_Fix.shader's
// HLSLINCLUDE (after CoreVertex.hlsl + CoreSurface.hlsl), so LitSurfaceData / Varyings / the
// UnityPerMaterial CBUFFER / all TEXTURE2D bindings are already in scope — we do NOT redeclare
// any of them. We only add: shared math primitives + LitForwardLighting + LitPackGBuffer.
//
// GROUND TRUTH for every algorithmic line below:
//   litforward/Sub0_Pass0_Fragment_b9.hlsl  (the HGRP LitForward ForwardOnly fragment).
// Each block cites its b9 line range. b9 is DXBC->HLSL: SSA temps `_NNNN`, `mad(a,b,c)`=a*b+c,
// `((-0.0f)-x)`=-x, `asfloat(<uint>)` = denormalized-float magic constant. Decoded inline.
//
// PORT DISCIPLINE: 1:1 binds MATH / constants / branch-boundaries / signs / swizzles. The HGRP
// engine infrastructure (IV-clipmap SH cascade T10-T15, reflection-probe binning T1/T0, CSM+ASM
// shadow atlases T5/T7, froxel volumetric fog T16, motion-vector SV_Target1) is substituted by
// URP facilities (SampleSH, GlossyEnvironmentReflection, GetMainLight/GetAdditionalLight shadow
// attenuation, MixFog) per CORE_MATH §2.4/§2.5/§2.7/§2.10/§2.12 — REQUIRED, not a deviation.
// SV_Target1 (HG MV/TAAU pack, b9:1333-1339) is DROPPED (URP has a dedicated MotionVectors pass).
// ============================================================================================

// --------------------------------------------------------------------------------------------
// §0.4  Decoded magic-constant table (denormalized float bit patterns -> real values), GLOBAL.
//       Source: CORE_MATH §0.4 + the literals as spelled in b9. These are algorithm boundaries
//       (epsilons / luma / grazing floor / dielectric-F0 base), preserved EXACTLY.
// --------------------------------------------------------------------------------------------
static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709 luma, b9:1328/1060
static const float  HGRP_EPS_VIEWLEN     = 9.9999999392252902907785028219223e-09; // = 1e-8 ; rsqrt/denominator guard, b9:277
static const float  HGRP_EPS_NORMAL_Z    = 1.000000016862383526387164645044e-16;  // = 1e-16 ; derived-normal Z floor, b9:441
static const float  HGRP_EPS_HALF_RSQRT  = 6.103515625e-05;                        // = 2^-14 ; half-precision rsqrt guard, b9:949/960
static const float  HGRP_EPS_VIS         = 9.9999997473787516355514526367188e-05;  // = 1e-4  ; Smith-visibility denominator floor, b9:981
static const float  HGRP_DIELECTRIC_F0   = 0.07999999821186065673828125;           // = 0.08  ; dielectric F0 base = 0.08*_Specular, b9:318
static const float  HGRP_GRAZING_FLOOR   = 0.0476190485060214996337890625;         // = 1/21  ; multiscatter-diffuse grazing floor gz=lerp(F0,1,1/21), b9:977-979 (used by HgDirectLightEnergy)

// --------------------------------------------------------------------------------------------
// §0.4 / §2.9  Sign + octahedral helpers (CORE_MATH §0.4, §2.9), as static-const-friendly funcs.
//   HG spells sign() as: float(int((0u-(0<x?~0:0)) + (x<0?~0:0))) (b9:659-661,695-697). That is
//   exactly HLSL sign() (returns -1/0/+1). The octahedral wrap (b9:659-664) is URP's std oct
//   encode of a world normal -> 2x[0,1], reused by LitPackGBuffer when _GBUFFER_NORMALS_OCT.
// --------------------------------------------------------------------------------------------
float  HgSign(float x)  { return sign(x); }
float2 HgSign2(float2 v){ return float2(sign(v.x), sign(v.y)); }

// Octahedral encode of a unit normal n -> oct in [-1,1] (b9:659-664 wrap logic).
float2 HgOctEncode(float3 n)
{
    float3 a = abs(n);
    n /= (a.x + a.y + a.z);                 // project onto octahedron, b9:662-663 (x/sum, y/sum)
    float2 oct = n.xy;
    if (n.z < 0.0)                          // lower hemisphere wrap, b9:664 (z/sum < 0)
        oct = (1.0 - abs(oct.yx)) * HgSign2(oct.xy);
    return oct;
}

// --------------------------------------------------------------------------------------------
// §2.6  Karis mobile analytic ENVIRONMENT-BRDF / horizon energy (b9:326-329, 1261).
//   This is the HG "specular DFG" pre-integration used to gate the ambient (probe) reflection.
//   The 2D DFG split-sum LUT (T9, b9:982/1011) is HGRP infra -> replaced here by this analytic
//   form per CORE_MATH §2.6 / MERGE_BLUEPRINT §0. The poly coeffs are LOAD-BEARING — copy exact.
//
//   const0 = (-1, -0.0275, -0.572, 0.022) , const1 = (1, 0.0425, 1.04, -0.04)
//   envF        (_536) = min((1-rough)^2, exp2(-9.28*NoV)) * (1-rough) + (rough*-0.0275 + 0.0425)
//   envSpecScale(_537) = envF*-1.04 + (rough*-0.572 + 1.04)
//   envSpecBias (_3103)= (envF*1.04 + (rough*0.022 - 0.04)) * saturate(F0.g * 50)
//   gate (b9:1325) = F0 * envSpecScale + envSpecBias    -> the (scale,bias) applied to F0.
// --------------------------------------------------------------------------------------------
void HgEnvBRDF(float roughness, float NoV, float3 f0,
               out float envSpecScale, out float envSpecBias)
{
    float oneMinusRough = mad(roughness, -1.0, 1.0);                                                   // 1-rough, b9:326 (_520)
    // _536 = mad( min(_520*_520, exp2(_531*-9.28)), _520, mad(_361,-0.0275,0.0425) )                  // b9:328
    float envF = mad(min(oneMinusRough * oneMinusRough, exp2(NoV * -9.27999973297119140625)),
                     oneMinusRough,
                     mad(roughness, -0.0274999998509883880615234375, 0.0425000004470348358154296875));
    // _537 = mad(_536, -1.04, mad(_361, -0.572, 1.04))                                                // b9:329
    envSpecScale = mad(envF, -1.03999996185302734375,
                       mad(roughness, -0.572000026702880859375, 1.03999996185302734375));
    // _3103 = mad(_536, 1.04, mad(_361, 0.022, -0.04)) * saturate(F0.g * 50)                          // b9:1261
    envSpecBias = mad(envF, 1.03999996185302734375,
                      mad(roughness, 0.02199999988079071044921875, -0.039999999105930328369140625))
                  * saturate(f0.g * 50.0);
}

// --------------------------------------------------------------------------------------------
// §2.6  EnvBRDFApprox rational DFG scale (b9:975 _2183). Karis/Lazarov "EnvBRDFApprox" polynomial
//   in perceptualRoughness (= linear roughness here), used by the direct-light MULTISCATTER diffuse
//   energy term (b9:983 term A). Coeffs are 1:1 load-bearing (CORE_MATH §2.6, MERGE_BLUEPRINT §5).
//     t      (_2174) = 1 - roughness
//     dfg    (_2183) = min( t*(t*((-t)*0.38302600 - 0.07619470) + 1.04997003) + 0.40925499, 0.999 )
//   NOTE: HG additionally multiplies dfg by a 2D split-sum DFG LUT product T9(NoV)·T9(NoL)
//   (b9:982 _2240). T9 is the precomputed split-sum integration texture = engine infrastructure
//   with no URP binding in the frozen interface; the analytic `dfg` is its sanctioned substitute
//   (CORE_MATH §2.6 / §2.12). The poly + the 1/21 grazing floor below ARE the 1:1 math.
// --------------------------------------------------------------------------------------------
float HgEnvBRDFApproxDFG(float roughness)
{
    float t = mad(roughness, -1.0, 1.0);                           // 1 - roughness , b9:974 (_2174)
    return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875,    // b9:975 (_2183)
                                  -0.076194703578948974609375),
                            1.04997003078460693359375),
                   0.4092549979686737060546875),
               0.999000012874603271484375);
}

// --------------------------------------------------------------------------------------------
// §2.7 / §2.8  Analytic-light specular BRDF: Cook-Torrance GGX-D + Smith height-correlated Vis
//              + Schlick Fresnel (b9:964-983). Shared by the main directional light (§2.7) and
//              the additional-lights loop (§2.8) — the punctual loop re-derives the IDENTICAL
//              D/Vis/F (b9:1220-1228). Returns the specular RGB (NOT yet * NoL).
//
//   a   (_2159) = roughness*roughness ; a2 (_2160) = a*a
//   NoV (_2158) = min(NoV, 1)
//   d   (_2163) = (NoH*a2 - NoH)*NoH + 1
//   D           = a2 / (d*d)
//   Vis (_2217) = 0.5 / ( NoV*sqrt((-NoL*a2+NoL)*NoL + a2) + NoL*sqrt((-NoV*a2+NoV)*NoV + a2) + 1e-4 )
//   Fc  (_2172) = (1 - VoH)^5            (VoH = saturate(dot(V,H)))
//   F           = lerp(F0, 1, Fc) = mad(F0, 1-Fc, Fc)
//   spec        = (D*Vis) * F
// --------------------------------------------------------------------------------------------
float3 HgDirectSpecular(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
{
    float a   = roughness * roughness;                              // b9:967 (_2159)
    float a2  = a * a;                                             // b9:968 (_2160)
    float nv  = min(NoV, 1.0);                                     // b9:966 (_2158)

    // GGX NDF denominator d, then D = a2/(d*d) folded into the Vis product (b9:969,981).
    float d   = mad(mad(NoH, a2, -NoH), NoH, 1.0);                 // (NoH*a2 - NoH)*NoH + 1 , b9:969 (_2163)
    // Smith height-correlated visibility (b9:981 _2217): 0.5 / (lambdaV + lambdaL + 1e-4).
    float visDenom = nv  * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2))  // NoV*sqrt((-NoL*a2+NoL)*NoL + a2)
                   + NoL * sqrt(mad(mad(-nv,  a2, nv ), nv , a2))  // NoL*sqrt((-NoV*a2+NoV)*NoV + a2)
                   + HGRP_EPS_VIS;
    float DV  = (a2 / (d * d)) * (0.5 / visDenom);                 // D * Vis , b9:981 (_2217)

    // Schlick Fresnel: Fc = (1-VoH)^5 (b9:970-973), F = lerp(F0,1,Fc) (b9:980+983 mad(F0,1-Fc,Fc)).
    float oneMinusVoH = mad(-VoH, 1.0, 1.0);                       // 1 - saturate(VoH) , b9:970 (_2169)
    float sq   = oneMinusVoH * oneMinusVoH;                        // (1-VoH)^2 , b9:971 (_2170)
    float quad = sq * sq;                                          // (1-VoH)^4 , b9:972 (_2171)
    float Fc   = oneMinusVoH * quad;                              // (1-VoH)^5 , b9:973 (_2172)
    float oneMinusFc = mad(-quad, oneMinusVoH, 1.0);              // 1 - (1-VoH)^5 , b9:980 (_2198 form)
    float3 F   = mad(f0, oneMinusFc.xxx, Fc.xxx);                 // lerp(F0,1,Fc) , b9:983 mad(_514,_2198,_2172)

    return DV * F;                                                 // (D*Vis)*F
}

// --------------------------------------------------------------------------------------------
// §2.7 / §2.8  Full per-light radiance response (b9:983-985 _2283/_2284/_2285, re-derived per
//   light in the punctual loop b9:1232-1234). Returns the bracketed energy that gets multiplied
//   by NoL and lightColor at the call site. Faithful to HG's energy structure:
//
//     specE  (_2217·F)  = (D*Vis)*F                                       (clamped to 2048)
//     msDiff (_2240·…)  = (dfg/(1-dfg) * gz^2) / (1 - gz*(1-dfg))  per ch  (multiscatter diffuse)
//                         where gz = lerp(F0, 1, 1/21)  (grazing floor _2193)
//                         and dfg = HgEnvBRDFApproxDFG(roughness)         (T9 LUT substitute)
//     energy = min(max( (msDiff + min(specE, 2048)) * lightScale, 0), 1000)
//   The (diffuse*NoL) Lambert base is ADDED at the call site (b9:983 `+ _509*_2153`); lightScale
//   (_LightDataBuffer[4].x, per-light intensity) is folded into URP's lightColor → pass 1.0 here.
// --------------------------------------------------------------------------------------------
float3 HgDirectLightEnergy(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
{
    float3 specE = HgDirectSpecular(roughness, f0, NoL, NoH, NoV, VoH);   // (D*Vis)*F , b9:981·983
    float  dfg   = HgEnvBRDFApproxDFG(roughness);                         // analytic DFG , b9:975 (_2183)
    float  oneMinusDfg = mad(-dfg, 1.0, 1.0);                             // 1 - dfg , b9:976 (_2186)
    // _2240 = (dfg * T9(NoV).x*T9(NoL).x) / (1-dfg). T9 split-sum LUT product is engine infra with
    // no URP binding → substitute the analytic dfg for the product (CORE_MATH §2.6/§2.12).
    float  dfgEnergy = dfg / oneMinusDfg;                                 // analytic _2240 (T9 product -> dfg)
    float3 gz    = mad((float3(1.0, 1.0, 1.0) - f0), HGRP_GRAZING_FLOOR, f0); // lerp(F0,1,1/21) , b9:977-979 (_2193..)
    // multiscatter diffuse per channel: (_2240 * gz^2) / mad(-gz, _2186, 1) , b9:983 term A
    float3 msDiff = (dfgEnergy * (gz * gz)) / mad(-gz, oneMinusDfg, float3(1.0, 1.0, 1.0));
    // (msDiff + min(spec,2048)) then global clamp [0,1000] , b9:983 min(max(...,0),1000)
    return min(max(msDiff + min(specE, 2048.0), 0.0), 1000.0);           // lightScale folded into lightColor
}

// --------------------------------------------------------------------------------------------
// §2.2  View vector V (world). Perspective: normalize(camPos - P); ortho: -camera forward.
//       b9:271-281 (_154 ortho flag, _196..200 raw, _207 rsqrt, _208..210 V). CoreVertex already
//       computed the unnormalized viewDirWS into IN.viewDirWS; we normalize with the SAME guard.
// --------------------------------------------------------------------------------------------
float3 HgViewDirWS(float3 viewRaw)
{
    float distSq = dot(viewRaw, viewRaw);                          // b9:276 (_201)
    float invLen = rsqrt(max(distSq, HGRP_EPS_VIEWLEN));           // b9:277 (_207)
    return viewRaw * invLen;                                       // b9:278-280 (_208..210)
}

// --------------------------------------------------------------------------------------------
// §SSS  Subsurface scatter — FORWARD RE-AUTHOR to the REFERENCE standard (NOT the deferred 5-MRT encode).
//
//   PORT STANDARD: the REFERENCE deliverables HGRP_CharacterNPR_Skin_Fix.shader (subsurfSpec, :566-578)
//   and HGRP_CharacterNPR_Fix.shader (subsurfSpec, :661-670) — both list "Kept: Subsurface" in their
//   FORWARD pass — define what "1:1 / no differences" means here: reproduce the SSS LOOK in the FORWARD
//   composite. The reference forward SSS is a three-part term: (1) a WRAP-DIFFUSE where NoL is biased so
//   light wraps around the silhouette (ref `wrapNdotL = saturate(0.5 + NoL - 0.5*NoL*NoL)`,
//   Skin_Fix:568 / NPR_Fix:663); (2) a BACK-TRANSMISSION gated by a view-grazing edge fresnel + a
//   light-behind-surface factor so light shows through thin silhouettes (ref `edgeFresnel`*`camLightFacing`,
//   Skin_Fix:569-571 / NPR_Fix:664-666); (3) a SUBSURFACE-COLOR TINT carried by the light and the surface
//   albedo (ref `subsurfLight * max(diffColor,0.15)`, Skin_Fix:574-578 / NPR_Fix:669-670).
//
//   This re-authors that SAME forward technique through lit's NAMED _Subsurface* properties (the ones
//   already in the merged UnityPerMaterial CBUFFER, lit.shader:274-295) instead of the reference's
//   character-specific _CharacterParams*/flat-XZ-hemisphere drivers — exactly the substitution the
//   reference deliverable itself performs (re-author HG's deferred SSS feature as a forward term):
//     wrap      = _SubsurfaceWrapNoLBias   (lit.shader L290 _SubsurfaceWrapNoLBias) — how far light wraps
//                 the silhouette; canonical wrap-lighting saturate((NoL+w)/(1+w)) is the named-prop form of
//                 the reference's `0.5+NoL-0.5*NoL^2` wrap shaping (w=0 -> plain Lambert).
//     tint      = _SubsurfaceColor.rgb     (lit.shader L286 [HDR] _SubsurfaceColor) — the HDR scatter tint
//                 the engine-side resolve modulates; same role as the ref's subsurfLight tint.
//     thickness = s.thickness = lerp(_Min,_MaxSubsurfaceThickness, s.subsurfaceMask) (seeded by
//                 LitEffectSubsurface; lit.shader L292-293) — thicker => LESS back-transmission, so the
//                 transmission lobe is scaled by (1 - thickness) (ref: thin silhouettes transmit, L2911).
//     indirect  = _SubsurfaceIndirect      (lit.shader L289 _SubsurfaceIndirect) — ambient-driven SSS so the
//                 tint also reads under indirect (SH) light, scaled by the same wrap/edge envelope.
//
//   This is FAITHFUL re-authoring (the reference itself re-authored HG's deferred SSS into this forward
//   look), NOT a fabrication of the deferred path: it deliberately does NOT touch SV_Target.w material-id
//   and does NOT lift the b397/b405 VIEW-SPACE MOTION-VECTOR / VAT-velocity blob (which an earlier pass
//   wrongly mis-attributed as SSS — that blob is MV/VAT data this shader drops; the named-prop CBUFFER
//   fields used here, NOT the VAT/_OffsetDir aliases, are the 1:1 binding). Keyword-gated #ifdef
//   _SUBSURFACE/_SUBSURFACE_DEFAULTLIT; off-path returns 0 -> strict base-path non-regress.
//
//   Returns the forward SSS radiance to ADD into the lit/diffuse result. Direct args come from the
//   main-light block of LitForwardLighting (N,V,L,NoV,lightColor*atten); ambientSH feeds the indirect
//   lobe. s carries the seeded subsurfaceColor/subsurfaceMask/thickness and the diffuse albedo.
// --------------------------------------------------------------------------------------------
float3 HgSubsurfaceForward(LitSurfaceData s, float3 N, float3 V, float3 L, float NoV,
                           float3 diffuseAlbedo, float3 lightColorAtten, float3 ambientSH)
{
#if !defined(_SUBSURFACE) && !defined(_SUBSURFACE_DEFAULTLIT)
    return float3(0.0, 0.0, 0.0);                                  // keyword-gated no-op -> strict base-path non-regress
#else
    // ---- (1) wrap-diffuse: bias NoL by the named wrap so light wraps the silhouette ----------
    //   Reference shaping is saturate(0.5 + NoL - 0.5*NoL^2) (Skin_Fix:568 / NPR_Fix:663). Expressed
    //   through the NAMED _SubsurfaceWrapNoLBias via the canonical wrap-lighting normalize: w=0 -> Lambert,
    //   larger w -> light bleeds past the terminator (the reference's silhouette wrap).
    float  NoL  = dot(N, L);
    float  w    = max(_SubsurfaceWrapNoLBias, 0.0);
    float  wrap = saturate((NoL + w) / (1.0 + w));                 // wrap-diffuse NoL bias (named-prop form)

    // ---- (2) back-transmission: light behind the surface, shown through thin grazing edges -----
    //   Reference gates SSS to grazing silhouettes (edgeFresnel on -|NoV|, Skin_Fix:570-571) where the
    //   light is on the far side (camLightFacing, Skin_Fix:569). Re-authored with the standard transmission
    //   driver: back-facing NoL (light coming THROUGH the surface) * a view-grazing fresnel, attenuated by
    //   thickness (thicker => less transmission; ref note L2911). s.thickness in [_Min,_Max].
    float  backNoL    = saturate(-NoL);                            // light-behind-surface (transmission)
    float  edge       = saturate(1.0 - NoV);
    float  edgeFres   = edge * edge * (3.0 - 2.0 * edge);         // smoothstep grazing edge (ref edgeFresnel role)
    float  thinFactor = saturate(1.0 - s.thickness);              // thicker -> less back-transmission
    float  transLobe  = backNoL * edgeFres * thinFactor;          // back-transmission envelope

    // ---- direct SSS envelope: wrap-diffuse front + back-transmission, tinted ---------------------
    float  directEnvelope = wrap + transLobe;

    // ---- (3) subsurface-color tint, carried by the surface albedo (ref max(diffColor,0.15)) ------
    float3 sssTint = half3(s.subsurfaceColor) * max(diffuseAlbedo, 0.15);

    // direct lobe modulated by main-light color*attenuation (ref subsurfLight) --------------------
    float3 directSSS = directEnvelope * sssTint * lightColorAtten;

    // ---- (4) indirect: ambient-driven SSS under the same wrap/edge envelope (named _SubsurfaceIndirect)
    float3 indirectSSS = (_SubsurfaceIndirect * (wrap + edgeFres)) * sssTint * ambientSH;

    return directSSS + indirectSSS;
#endif
}
// --------------------------------------------------------------------------------------------

// --------------------------------------------------------------------------------------------
// §SSS-PROFILE  Pre-integrated subsurface PROFILE — FORWARD RE-AUTHOR to the REFERENCE standard.
//
//   FEATURE: _UseSubsurfaceProfile (lit.shader:296-307). The canonical forward home for a
//   "pre-integrated subsurface profile" is the pre-integrated-skin curvature diffuse (Penner 2011,
//   "Pre-Integrated Skin Shading", GPU Pro 2): the per-light diffuse NoL term is replaced by a
//   lookup into a 2D LUT whose U-axis is the (remapped) NoL and whose V-axis is the surface
//   CURVATURE — sharply-curved regions scatter more, softening and reddening the terminator.
//
//   PORT STANDARD: the reference deliverables (HGRP_CharacterNPR_Skin_Fix.shader,
//   HGRP_CharacterNPR_Fix.shader) re-author HG's deferred features into the FORWARD pass and list
//   "Kept: Subsurface". The reference pre-integrates its diffuse through a NoL-indexed diffuse RAMP
//   (Skin_Fix:416-437, `rampInput = clampedNdotL*0.5+0.5`) with NO curvature-texture axis. Per the
//   task DO clause ("mirror the reference if it has a curvature LUT path; else implement the
//   standard pre-integrated-skin curvature lookup"), we implement the STANDARD pre-integrated-skin
//   curvature lookup against lit's NAMED props — reproducing the same pre-integrated-diffuse LOOK
//   the reference keeps, using the second (curvature) axis lit exposes.
//
//   NAMED-property binding (the props already in the merged UnityPerMaterial CBUFFER):
//     LUT       = _SubsurfaceNormalCurvatureTex  (lit.shader:304) — pre-integrated diffuse-by-
//                 curvature texture, sampled at float2(NoL*0.5+0.5, curvatureV).
//     curvatureV= s.subsurfaceProfileCurvature  — seeded by LitEffectSubsurfaceProfile as
//                 saturate(mad(length(fwidth(N))/length(fwidth(P)), _SubsurfaceCurvatureScale,
//                 _SubsurfaceCurvatureOffset)) (lit.shader:306-307).
//     strength  = _SubsurfaceNormalStrength  (lit.shader:305) — blend weight from Lambert toward
//                 the pre-integrated diffuse (0 -> plain Lambert, 1 -> full LUT scatter).
//
//   This is FAITHFUL re-authoring (grounded in the reference forward technique + lit's named-prop
//   semantics), NOT the reverted terrain-VT deferred blob (b407:555 `_1079`) and NOT the deferred
//   2-bit profile-id encode (b399:300-302, HG engine-side resolve) — neither is used here.
//
//   Returns the diffuse-NoL REPLACEMENT term: the value to use IN PLACE OF Lambert `NoL` for the
//   diffuse lobe (curvature-modulated). Keyword-gated #ifdef _UseSubsurfaceProfile; off-path
//   returns plain saturate(NoL) -> strict base-path non-regress (identical to the prior Lambert).
// --------------------------------------------------------------------------------------------
float HgSubsurfaceProfileNoL(LitSurfaceData s, float rawNoL)
{
#ifndef _UseSubsurfaceProfile
    return saturate(rawNoL);                                       // keyword off -> plain Lambert diffuse-NoL (non-regress)
#else
    // Pre-integrated-skin LUT lookup: U = remapped NoL (signed -> [0,1] so the wrapped/scattered
    // terminator below NoL=0 is represented), V = per-pixel curvature (seeded in the surface stage).
    float  lutU   = saturate(rawNoL * 0.5 + 0.5);                  // pre-integrated diffuse U-axis (Penner: (NoL+1)/2)
    float  lutV   = saturate(s.subsurfaceProfileCurvature);        // curvature V-axis = mad(curvature,scale,offset)
    float  sssNoL = SAMPLE_TEXTURE2D_LOD(_SubsurfaceNormalCurvatureTex, sampler_SubsurfaceNormalCurvatureTex,
                                         float2(lutU, lutV), 0).r; // pre-integrated diffuse (red = primary scatter channel)

    // Blend Lambert -> pre-integrated diffuse by the NAMED strength (lit.shader:305). Strength 0
    // reproduces the base Lambert exactly (non-regress); strength 1 = full curvature-modulated SSS.
    return lerp(saturate(rawNoL), sssNoL, saturate(_SubsurfaceNormalStrength));
#endif
}
// --------------------------------------------------------------------------------------------

// ============================================================================================
// LitForwardLighting — full direct + ambient PBR composite for the ForwardLit path.
//   Mirrors b9:1325-1343 final composite (with HG fog -> URP MixFog, SV_Target1 dropped):
//     color = diffuse * SH(N) * occlusion * envAmbientIntensity                 (b9:1325 term A)
//           + reflection * envReflIntensity * (F0*envSpecScale + envSpecBias)   (b9:1325 term B)
//           + directionalLight                                                  (b9:1325 +_2753)
//           + additionalLights                                                  (b9:1325 +_2866)
//     color = MixFog(color, fogFactor)                                          (b9 HG fog -> URP)
//     out   = half4(color, alpha)   alpha=(_SurfaceType==1)?baseAlpha:1         (b9:1343 _349)
// ============================================================================================
half4 LitForwardLighting(LitSurfaceData s, Varyings IN)
{
    float3 N  = normalize(s.normalWS);
    float3 V  = HgViewDirWS(IN.viewDirWS);                          // §2.2, b9:271-280
    float3 P  = IN.positionWS;

    float  roughness = s.roughness;                                // linear roughness, b9:301 (_361)
    float3 f0        = s.f0;                                       // lerp(0.08*_Specular, albedo, metallic), b9:322-325 (_514..516)
    float3 diffuse   = s.albedo * (1.0 - s.metallic);             // baseCol*(1-metallic), b9:319-321 (_509..511)
    float  occlusion = s.occlusion;                                // lerp(1, mro.b, _OcclusionStrength), b9:1260 (_3084)

    float  NoV = max(dot(N, V), 0.0);                              // b9:327 (_531)

    // ---- §2.6 environment-BRDF (F0 scale/bias for ambient reflection) ----------------------
    float envSpecScale, envSpecBias;
    HgEnvBRDF(roughness, NoV, f0, envSpecScale, envSpecBias);      // b9:326-329,1261

    // ---- §2.4 ambient diffuse: HG IV-clipmap SH cascade -> URP SampleSH(N) -----------------
    //   b9:575-577 project SH onto N; b9:1325 term A = diffuse * ambientSH * occ * envParams0.x.
    float3 ambientSH = SampleSH(N);
    // ---- §2.5 specular reflection: HG probe-binning atlas -> URP GlossyEnvironmentReflection -
    //   perceptualRoughness from linear roughness; b9:1325 term B gated by EnvBRDF (F0*scale+bias).
    // s.roughness IS perceptualRoughness (HG _361; GGX uses a=_361^2 in HgDirectSpecular). Feed URP's
    // reflection its perceptualRoughness DIRECTLY — a sqrt here double-roots it (reflections too sharp). b9:301/1005.
    float  perceptualRoughness = saturate(roughness);
    float3 reflectVec = reflect(-V, N);                            // R = reflect(-V,N) , b9:578-582 (_991..993)
#if defined(_CUSTOM_IBL) || defined(_PLANAR_REFLECTION)
    float3 reflection = s.reflectionColor;                         // leaf module override (CustomIBL / PlanarReflection)
#else
    // occlusion arg = 1.0 : HG term B (b9:1325 _1669) does NOT apply AO to the reflection (only
    // term A diffuse gets _3084). URP's GlossyEnvironmentReflection would multiply by occlusion;
    // pass 1.0 so the reflection stays un-occluded to match HG.
    float3 reflection = GlossyEnvironmentReflection(reflectVec, perceptualRoughness, 1.0);
#endif

    float3 color = diffuse * ambientSH * occlusion * _EnvironmentGlobalParams0.x          // term A , b9:1325
                 + reflection * (f0 * envSpecScale + envSpecBias) * _EnvironmentGlobalParams0.y; // term B , b9:1325

    // ---- §2.7 direct MAIN (directional) light: HG CSM/ASM atlas -> URP main-light shadow ----
    float4 shadowCoord = TransformWorldToShadowCoord(P);
    Light mainLight = GetMainLight(shadowCoord, P, half4(1,1,1,1));
    float  mainAtten = mainLight.distanceAttenuation * mainLight.shadowAttenuation;        // -> _1897 (shadow), b9:938
    {
        float3 L = mainLight.direction;                            // -_LightDataBuffer_DirectionalLightDirection[0] , b9:944
        float3 H = normalize(L + V);                               // b9:957-963 (_2139..2149)
        float rawNoL = dot(L, N);                                  // signed dot (feeds the pre-integrated profile LUT below)
        float NoL = saturate(rawNoL);                             // b9:964 (_2153)
        float NoH = saturate(dot(N, H));                          // b9:965 (_2157)
        float VoH = saturate(dot(V, H));                          // b9:970 base (dot(V,H))
        // Full HG energy bracket: min(max(msDiff + min((D*Vis)*F, 2048), 0), 1000) , b9:983
        float3 energy = HgDirectLightEnergy(roughness, f0, NoL, NoH, NoV, VoH); // §2.7 , b9:975-983
        // §SSS-PROFILE  _UseSubsurfaceProfile — curvature-modulated SSS: the DIFFUSE lobe's NoL is
        //   REPLACED by the pre-integrated-skin curvature LUT (HgSubsurfaceProfileNoL: samples
        //   _SubsurfaceNormalCurvatureTex at (NoL*0.5+0.5, s.subsurfaceProfileCurvature) *
        //   _SubsurfaceNormalStrength), softening/reddening the terminator. SPECULAR keeps geometric
        //   NoL. Keyword off -> diffNoL == saturate(rawNoL) == base Lambert (strict non-regress).
        float diffNoL = HgSubsurfaceProfileNoL(s, rawNoL);
        // out = (energy*NoL + diffuse*diffNoL) * lightColor * atten   (b9:983 mad(energy,NoL, _509*NoL) * _LightData[1])
        color += mad(energy, NoL, diffuse * diffNoL) * (mainAtten * mainLight.color);

        // §SSS  _SUBSURFACE / _SUBSURFACE_DEFAULTLIT — FORWARD-re-authored to the REFERENCE standard.
        //   ADD the forward subsurface look (wrap-diffuse NoL bias + back-transmission tinted by
        //   _SubsurfaceColor, thickness-modulated) into the lit result, matching what the reference
        //   deliverables KEEP in their forward pass (HGRP_CharacterNPR_Skin_Fix.shader:566-578,
        //   HGRP_CharacterNPR_Fix.shader:661-670), expressed through lit's NAMED _Subsurface* props
        //   (_SubsurfaceWrapNoLBias / _SubsurfaceColor / _SubsurfaceIndirect / s.thickness=lerp(_Min,_Max,mask)).
        //   This is the reference forward LOOK, NOT the deferred 5-MRT MV/VAT encode (b397/b405) — those
        //   aliases are deliberately NOT used (see HgSubsurfaceForward header for the full grounding).
        //   Direct lobe carried by the main light (mainAtten*mainLight.color), indirect by ambientSH.
        color += HgSubsurfaceForward(s, N, V, L, NoV, diffuse, mainAtten * mainLight.color, ambientSH);
    }

    // ---- §2.8 additional (punctual) lights: HG tile/zbin -> URP GetAdditionalLight loop -----
    //   Plain for-loop (not the clustered LIGHT_LOOP_BEGIN macro, which needs an InputData in
    //   scope). Per-light: same GGX D / Smith Vis / Schlick F as the main light (b9:1220-1234).
#if defined(_ADDITIONAL_LIGHTS)
    uint addCount = GetAdditionalLightsCount();
    for (uint lightIndex = 0u; lightIndex < addCount; ++lightIndex)
    {
        Light light = GetAdditionalLight(lightIndex, P, half4(1, 1, 1, 1));
        float3 L = light.direction;
        float3 H = normalize(L + V);
        float NoL = saturate(dot(L, N));
        float NoH = saturate(dot(N, H));
        float VoH = saturate(dot(V, H));
        // same energy bracket as §2.7, re-derived per light in HG's punctual loop , b9:1228-1234
        float3 energy = HgDirectLightEnergy(roughness, f0, NoL, NoH, NoV, VoH);
        // §LOCAL-SHADOW  _RECEIVE_LOCAL_LIGHT_SHADOW — HG samples a per-local-light SHADOW ATLAS to
        //   attenuate punctual lights; the URP substitute is THIS additional-lights loop's
        //   light.shadowAttenuation (URP's own additional-light shadow atlas, sampled when
        //   _ADDITIONAL_LIGHT_SHADOWS is on). Same infra-substitution class as the main-light CSM/ASM
        //   atlas (-> mainLight.shadowAttenuation, §2.7), the IV-clipmap SH (-> SampleSH, §2.4), and the
        //   probe-binning reflection (-> GlossyEnvironmentReflection, §2.5). GATED by the keyword to match
        //   HG's _ReceiveLocalLightShadow toggle, whose litforward default is 0 = OFF (lit.shader:596,
        //   [Toggle] ... = 0): keyword ON -> apply the local-light shadow; keyword OFF (or undeclared) ->
        //   1.0 = NO local shadow = the correct HG default-off. Previously this unconditionally applied
        //   light.shadowAttenuation, which was WRONG vs HG's default-off toggle — the #else 1.0 FIXES that
        //   (non-regress: a shader that never declares the keyword now gets HG's default no-local-shadow).
#ifdef _RECEIVE_LOCAL_LIGHT_SHADOW
        float localShadow = light.shadowAttenuation;                  // HG local-light shadow atlas -> URP additional-light shadowAttenuation
#else
        float localShadow = 1.0;                                       // HG default _ReceiveLocalLightShadow=0 = no local shadow
#endif
        float atten = light.distanceAttenuation * localShadow;
        color += mad(energy, NoL, diffuse * NoL) * (atten * light.color);
    }
#endif

    // ---- emission (leaf Emissive modules write s.emission; base variant = 0) ---------------
    color += s.emission;

    // ---- §REFRACT  _USE_REFRACTION / _GLASS_REFRACTION_SCENECOLOR — blend the refracted scene color in ----
    //   <<MODULE: Refraction>> (LitApplyRefraction, HGRP_Lit_Fix.shader) resolved the IoR-bent refracted color
    //   into s.refractionColor (URP _CameraOpaqueTexture scene-color sample for glass, or _RefractTex for plain),
    //   already tinted by _RefractTint*_RefractBrightness, and carried the _RefractionContribution glass-blend
    //   WEIGHT in s.coatMask. Blend the lit surface toward that refracted color by the weight — the standard
    //   URP transparent-refraction composite and the 1:1 forward equivalent of HG's scene-color glass (b62/b64).
    //   Pre-fog so the refracted scene-color is fogged with the surface (same depth). Keyword-gated; when off,
    //   the module never writes coatMask (CoreSurface seeds it 0) -> lerp(color, …, 0) == color (strict non-regress).
#if defined(_USE_REFRACTION) || defined(_GLASS_REFRACTION_SCENECOLOR)
    color = lerp(color, float3(s.refractionColor), saturate(s.coatMask));          // glass refraction blend (b62/b64 _RefractionContribution weight)
#endif

    // ---- §2.10 fog: HG atmosphere+exp+volumetric (b9:1262-1327) -> URP MixFog -------------
    color = MixFog(color, IN.fogFactor);

    // ---- §2.11 output alpha gated by surface type (b9:1343 _349; STYLE_BIBLE §6) -----------
    float alpha = (_SurfaceType == 1.0) ? s.alpha : 1.0;
    return half4(color, alpha);
}

// --------------------------------------------------------------------------------------------
// World-normal -> URP GBuffer2 packing, byte-for-byte matching URP GBufferCommon.hlsl
// PackGBufferNormal (oct-quad encode under _GBUFFER_NORMALS_OCT, raw otherwise). Re-inlined here
// because we do not #include GBufferOutput.hlsl (it pulls extra deferred plumbing); URP's own
// `struct SurfaceData` is already in scope via Lighting.hlsl->BRDF.hlsl->SurfaceData.hlsl, which
// is exactly why the scaffold's surface type is named `LitSurfaceData` (not `SurfaceData`) to
// avoid a redefinition collision. All primitives here come from URP core Packing.hlsl.
// --------------------------------------------------------------------------------------------
half3 HgPackGBufferNormal(half3 normalWS)
{
#if defined(_GBUFFER_NORMALS_OCT)
    float2 octNormalWS = PackNormalOctQuadEncode(normalWS);            // [-1,+1]
    float2 remappedOctNormalWS = saturate(octNormalWS * 0.5 + 0.5);    // [0,+1]
    return half3(PackFloat2To888(remappedOctNormalWS));
#else
    return normalWS;
#endif
}

// ============================================================================================
// LitPackGBuffer — URP deferred path. The HG 5-MRT layout (b281:124-195) is NOT a URP GBuffer
// (CORE_MATH §1.4 PORT GUIDANCE); we resolve the surface into URP's NATIVE 4-target GBuffer,
// replicating URP 6.1 PackGBuffersBRDFData (GBufferOutput.hlsl:76-112) layout EXACTLY:
//   gBuffer0 = (diffuse.rgb,  materialFlags)            (sRGB target)
//   gBuffer1 = (reflectivity, 0, 0,  occlusion)         (non-_SPECULAR_SETUP path)
//   gBuffer2 = (PackGBufferNormal(N), smoothness)
//   gBuffer3 = (globalIllumination, 1)                  (camera color attachment / GI laydown)
// We feed it our HG-exact split (F0 = lerp(0.08*_Specular, albedo, metallic)). SV_Target1 (HG MV
// pack) has no URP-deferred analog and is dropped. (Inlined — see HgPackGBufferNormal note.)
// ============================================================================================
void LitPackGBuffer(LitSurfaceData s, Varyings IN,
                    out half4 outGBuffer0, out half4 outGBuffer1,
                    out half4 outGBuffer2, out half4 outGBuffer3)
{
    float3 N = normalize(s.normalWS);

    half  smoothness = half(1.0) - half(saturate(s.roughness));         // smoothness = 1 - perceptualRoughness (s.roughness=_361 perceptual; NO sqrt). InitializeBRDFData re-squares to alpha=_361^2, matching HgDirectSpecular.

    // Build URP BRDFData (alpha is `inout` -> needs an lvalue), then override with our HG-exact F0/diffuse.
    half  alpha = half(1.0);
    BRDFData brdfData;
    InitializeBRDFData(half3(s.albedo), half(s.metallic), half3(0.0, 0.0, 0.0), smoothness, alpha, brdfData);
    brdfData.diffuse  = half3(s.albedo) * (half(1.0) - half(s.metallic));   // b9:319-321 diffuse = baseCol*(1-metallic)
    brdfData.specular = half3(s.f0);                                        // b9:322-325 F0 = lerp(0.08*_Spec, albedo, metallic)

    // GI laydown = SH ambient * occlusion * ambient-intensity (mirrors forward term A's diffuse-GI input).
    half3 globalIllumination = brdfData.diffuse * SampleSH(N) * half(s.occlusion) * half(_EnvironmentGlobalParams0.x);

    uint materialFlags = 0;
    outGBuffer0 = half4(brdfData.diffuse, materialFlags * (half(1.0) / half(255.0)));   // PackGBufferMaterialFlags, GBufferCommon:108
    outGBuffer1 = half4(brdfData.reflectivity, 0.0, 0.0, half(s.occlusion));            // reflectivity + occlusion (non-_SPECULAR_SETUP)
    outGBuffer2 = half4(HgPackGBufferNormal(N), smoothness);                            // encoded normal + smoothness
    outGBuffer3 = half4(s.emission + globalIllumination, 1.0);                          // emission + GI
}

#endif // HGRP_LIT_CORE_MATH_INCLUDED
