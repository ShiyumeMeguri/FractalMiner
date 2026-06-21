#ifndef HGRP_LIT_CORE_VERTEX_INCLUDED
#define HGRP_LIT_CORE_VERTEX_INCLUDED

// ============================================================================================
// CoreVertex.hlsl — the vertex stage of the HGRP Lit family, re-authored 1:1 onto URP.
//
// Ground truth (all under .../runtime/shaders/materials/lit/):
//   litforward/Sub0_Pass0_Vertex_b8.hlsl   (ForwardLit base — object->world->clip + normal/tangent basis)
//   lit/Sub0_Pass0_Vertex_b280.hlsl        (GBuffer base — SAME math, differs only in interpolator packing)
//   litforward/Sub0_Pass2_Vertex_b32.hlsl  (ShadowCaster — world->shadow-VP)
//   litforward/Sub0_Pass1_Vertex_b26.hlsl  (DepthOnly — world->camera-clip)
// Blueprint spine: CORE_MATH §3 + §4 ; infra substitution: STYLE_BIBLE §2.
//
// 1:1 obligation = the surface/transform MATH only. The decompiled vertex blobs carry three big
// blocks of HG MESH-IMPORT / ENGINE INFRASTRUCTURE that are DROPPED per PORT DISCIPLINE
// (CORE_MATH §0.1/§3.1/§3.2/§3.4) — URP feeds Unity-standard meshes, so these have no URP analog:
//   * octahedral NORMAL+TANGENT decode (b8:151-220, the `asuint(NORMAL.x)&0x40000000` packed path)
//   * GPU skinning from ByteAddressBuffer bone matrices (b8:240-442, BLENDWEIGHTS/BLENDINDICES)
//   * dual-frame motion-vector previous-clip output (b8:491-518 TEXCOORD_6/_7) — URP has a
//     dedicated MotionVectors pass; the frozen Varyings drops those interpolators.
// What REMAINS 1:1 is object->world->clip (b8:461-520) and the inverse-transpose normal /
// forward-transform tangent basis (b8:473-485) — both supplied verbatim by URP's
// GetVertexPositionInputs / GetVertexNormalInputs (STYLE_BIBLE §2 vertex table).
//
// This file OWNS and implements the four frozen vertex prototypes the scaffold declared:
//   LitVertex / LitShadowVertex / LitDepthVertex / LitDepthNormalsVertex.
// It writes ONLY into the FROZEN Attributes -> Varyings interface (declared in HGRP_Lit_Fix.shader);
// it does not re-declare any uniform, texture, or struct field.
// ============================================================================================

// ----------------------------------------------------------------------------------------------
// UV-set 0/1 passthrough helper.
// 1:1 source = b8:521-524 (forward) / b26:326-329 (depth) / b32:338-341 (shadow): the vertex copies
// uv0 and uv1 to the interpolators UNSCALED. The Lit-family FRAGMENT re-derives the per-map UV from
// BOTH uv sets with a UV-set lerp and per-map _ST — proven by b9:282-286:
//   _222 = -uv0.x + uv1.x                                           (duv = uv1 - uv0 ; b9:282-283)
//   base = mad(mad(_BaseUVSet,    duv, uv0), _BaseColorMap_ST.xy, _BaseColorMap_ST.zw)   (b9:286)
//   pbr  = mad(mad(_BasePbrMapUVSet, duv, uv0), _NormalMap_ST.xy,  _NormalMap_ST.zw)     (b9:284-285)
// i.e. `(uv0 + UVSet*(uv1-uv0)) * _ST + _ST.zw` with DIFFERENT _ST/UV-set per map. So uv.xy MUST be
// RAW uv0 (NOT pre-tiled): CoreSurface owns the _BaseColorMap_ST / _NormalMap_ST application. Baking
// _BaseColorMap_ST here would (1) double-apply it on the base map and (2) tile the coords the UV-set
// lerp runs on — both break 1:1. The FROZEN Varyings .xy comment ("ST already applied for uv0") and
// the CharacterNPR target (:797, whose fragment does NOT re-derive a UV-set lerp) describe a DIFFERENT
// shader; the Lit blob (b9:282-286) is the ground truth here and wins (STYLE_BIBLE §0).
// ----------------------------------------------------------------------------------------------
float4 LitPackUV(float2 uv0, float2 uv1)
{
    float4 uv;
    uv.xy = uv0;   // raw uv0 (b8:521-522 ; fragment does UV-set lerp + per-map _ST, b9:282-286)
    uv.zw = uv1;   // raw uv1 (b8:523-524)
    return uv;
}

// ----------------------------------------------------------------------------------------------
// _UV_ANIMATION — per-UV-set scroll written into the OUTPUT uv interpolator (vertex stage).
//
// GROUND TRUTH = the keyword-isolated vertex blob lit/Sub0_Pass0_Vertex_b614.hlsl:564-567 (the
//   `_UV_ANIMATION` variant — lit.shader:497 `#pragma multi_compile_local _ _UV_ANIMATION` is the ONLY
//   place in the whole com.hg.render-pipelines tree where the keyword compiles a distinct blob; the
//   liteffect ladder folds `[Toggle(_UV_ANIMATION)]` away as a never-enabled feature, so its own base
//   blobs b184/b185 pass uv straight through, b184:487-490). The b614 scroll writes the OUTPUT interps:
//     TEXCOORD_2.x   = mad(speed.x, _84, uv0.x)   // uv0.x + speed.x*t
//     TEXCOORD_2.y   = mad(speed.y, _84, uv0.y)   // uv0.y + speed.y*t
//     TEXCOORD_1_1.x = mad(speed.z, _84, uv1.x)   // uv1.x + speed.z*t
//     TEXCOORD_1_1.y = mad(speed.w, _84, uv1.y)   // uv1.y + speed.w*t
//   The four speed coefficients are CONTIGUOUS at packoffset c19.xyzw (b614:94-97) — i.e. ONE float4, the
//   property `_UVAnimationSpeed` (liteffect.shader:171 ".xy 1st UV set / .zw 2nd UV set"). The decompiler
//   split that float4 into 4 floats aliased onto whatever shipped-material metadata sat at the slot
//   (_OffsetSwitchDir/_CommonVATCurrentFrame/_CommonVATAutoPlay/_CommonVATFPS) — recovered by formula role +
//   the clean property (.xy->uv0, .zw->uv1), the SAME GAP-A role-decode already accepted in this file for
//   _USE_VERTOFFSET and in the fragment modules for _DETAIL_MAP/_TRI_CHANNEL_MASK/_USE_DISSOLVE. The math is
//   `mad(speed, time, uv)` = uv + speed*time, a pure additive scroll.
//
// INFRA fold: `_84` (b614:214) = `MotionVectorsParamsInternal.w * (1 - perInstance[14].x) + perInstance[14].y`
//   — HG's per-object CONTINUOUS animation time from the SRP instancing buffer + global MotionVectorsParams.
//   That buffer is engine infrastructure with no URP analog (CORE_MATH §0.1/§3.4 drop the HG instancing/MV
//   machinery); the faithful URP substitute for "current time in seconds" is `_Time.y`. IDENTICAL HG-time->
//   _Time.y substitution this shader already makes for _USE_VERTOFFSET (CoreVertex.hlsl:98), the disturb warp,
//   and the emissive anim (HGRP_LitEffect_Fix.shader:820-821). The scroll is speed*time, so .y (continuous) is
//   correct, NOT unity_DeltaTime.
//
// WHY A SEPARATE OUTPUT PACK (not folded into LitPackUV): the source scrolls EXACTLY at the OUTPUT-interpolator
//   write (b614 TEXCOORD_2/_1_1), derived from the RAW input TEXCOORD. Other vertex-stage consumers read the
//   RAW input independently — in particular _USE_VERTOFFSET (b234) samples _OffsetTex from its own
//   `lerp(rawUv0,rawUv1,_OffsetUVSet)`, with NO scroll (b234 carries no _UV_ANIMATION, and no combined blob
//   applies the scroll to the offset's sample). So the displacement uv stays RAW (LitPackUV) and ONLY the
//   varying the fragment consumes is scrolled — preserving 1:1 when both keywords are enabled.
// ----------------------------------------------------------------------------------------------
float4 LitPackAnimatedUV(float2 uv0, float2 uv1)
{
#ifdef _UV_ANIMATION
    uv0 = mad(_UVAnimationSpeed.xy, _Time.y, uv0);   // b614:564-565 : uv0 + _UVAnimationSpeed.xy * t
    uv1 = mad(_UVAnimationSpeed.zw, _Time.y, uv1);   // b614:566-567 : uv1 + _UVAnimationSpeed.zw * t
#endif
    return LitPackUV(uv0, uv1);
}

// ----------------------------------------------------------------------------------------------
// _USE_VERTOFFSET — texture-driven world-space vertex displacement (vertex stage).
//
// GROUND TRUTH = the ISOLATED single-keyword vertex blob liteffect/Sub0_Pass0_Vertex_b234.hlsl
//   (liteffect.shader:328-330: the `HG_ENABLE_MV && _TWO_BASEMAP && _USE_VERTOFFSET`, all other feature
//   keywords OFF branch — the cleanest VERTOFFSET isolation), diffed vs the base b188 (TWO_BASEMAP only)
//   to lift exactly the offset delta. The decompiler names the per-instance object->world matrix cbuffer
//   after its first field `_B_autoPlayback[10]`; rows [0..2] = ObjectToWorld 3x3, [3] = translation — that
//   is the SAME object->world URP supplies via GetVertexPositionInputs/NormalInputs (CORE_MATH §3.3), so the
//   skinning / octahedral / VAT / MV machinery around it is DROPPED per PORT DISCIPLINE and only the offset
//   add remains. All offset uniforms live in the ParamBlob cbuffer `CB3_m0[24]`; decoded by formula role +
//   the clean property enum (liteffect.shader:134-146) — the same role-decode already accepted in this file
//   for _DETAIL_MAP / _TRI_CHANNEL_MASK / _USE_DISSOLVE:
//     CB3_m0[19].x  -> _OffsetSwitchDir  (b234:171-172  _196=(==1)World, _197=(==2)Normal, else Object)
//     CB3_m0[19].y  -> _OffsetIntensity  (b234:174 the `* CB3_m0[19u].y` on the direction)
//     CB3_m0[19].z  -> _Bi_Offset        (b234:170,484  scalar = tex.x*(1+z) - z  => off:[0,1], on:tex*2-1)
//     CB3_m0[19].w  -> _OffsetUVSet      (b234:167-169  lerp(uv0,uv1,w) before _ST)
//     CB3_m0[20].y  -> _UseVertexColorMask (b234:177  >0 ? COLOR.w : 1)
//     CB3_m0[21].xy -> _OffsetSpeed.xy   (b234:484  + speed * timeChannel into the sample UV)
//     CB3_m0[22].xyz-> _OffsetDir.xyz    (b234:173-176  World: raw; Object: ObjectToWorld*dir)
//     CB3_m0[23].xy/zw -> _OffsetTex_ST  (b234:168-169  uv*_ST.xy + _ST.zw)
//   Direction (b234:174-176): World = _OffsetDir.xyz (already world, raw/unnormalized); Object = ObjectToWorld
//     * _OffsetDir.xyz; Normal = ObjectToWorld * normalOS = normalWS — ALL resolve to a WORLD vector, so the
//     displacement `_292 * dir * scalar * _297` (b234:485-487) is added to the WORLD position.
//   Offset scalar (b234:484): sample _OffsetTex.x at `lerp(uv0,uv1,_OffsetUVSet)*_OffsetTex_ST + _OffsetSpeed*t`,
//     then `tex.x*(1+_Bi_Offset) - _Bi_Offset`. HG read `_TimeParameters.w` (a non-URP time channel) — mapped
//     1:1 to URP `_Time.y` (continuous seconds), the SAME HG-time substitution this shader's disturb/VFX paths
//     use (HGRP_LitEffect_Fix.shader:1572 / LitEffectBlendModules.hlsl:32,52). LOD 0 sample (SampleLevel ,0).
//   _297 (b234:178,485) = `1 - _unity_ObjectToWorld[1].x` reads the SEPARATE per-draw matrix cbuffer
//     (type_UnityPerDraw b0, NOT the instancing matrix the position uses) -> `1 - m01` (column_major M[1].x =
//     math element (row0,col1), i.e. unity_ObjectToWorld._m01; verified against b188's worldPos mul). The blob
//     multiplies the ENTIRE displacement by this term (b234:485-487) and it recurs identically in every offset
//     pass (b236/b262/b264 gbuffer, b596/b626 depth, b772/b778/b816/b822 shadow), so it is part of the offset's
//     compiled math, not noise. URP exposes unity_ObjectToWorld (Core.hlsl) -> reproduced EXACTLY as
//     `1 - unity_ObjectToWorld._m01` (zero infra cost). It is 1 only for axis-aligned/unsheared draws; folding
//     it to 1.0 would drift displacement magnitude on rotated instances, so 1:1 keeps the multiplier.
//   The displacement is in the SHARED vertex blob => every pass's ladder (GBuffer/Shadow/Depth) carries it;
//   wired here into LitFillCameraVaryings + LitShadowVertex so all URP passes displace identically (1:1).
// ----------------------------------------------------------------------------------------------
float3 LitEffectVertexOffsetDeltaWS(float3 positionWS, float3 normalWS, float4 uv, float4 color)
{
#ifdef _USE_VERTOFFSET
    // sample UV = lerp(uv0,uv1,_OffsetUVSet)*_OffsetTex_ST + scroll (b234:167-169,484).
    float2 uvSel  = lerp(uv.xy, uv.zw, _OffsetUVSet);                          // b234:167-169 (uv0+(uv1-uv0)*set)
    float2 offUV  = uvSel * _OffsetTex_ST.xy + _OffsetTex_ST.zw + _OffsetSpeed.xy * _Time.y;  // _OffsetSpeed*t scroll
    float  texX   = SAMPLE_TEXTURE2D_LOD(_OffsetTex, sampler_OffsetTex, offUV, 0.0).x;          // b234:484 .x, LOD 0

    // bidirectional remap: off -> tex.x ([0,1]); on -> tex.x*2 - 1 ([-1,1]) (b234:170,484).
    float  offsetScalar = texX * (1.0 + _Bi_Offset) - _Bi_Offset;             // mad(tex.x, 1+_Bi_Offset, -_Bi_Offset)

    // direction in WORLD space per _OffsetSwitchDir (b234:171-176). World: raw _OffsetDir; Object: rotate OS->WS
    //   (un-normalized, matching the raw matrix mul, doNormalize=false); Normal: the world vertex normal.
    float3 dirWS;
    if (_OffsetSwitchDir == 1.0)            // World  (b234:171 _196)
    {
        dirWS = _OffsetDir.xyz;
    }
    else if (_OffsetSwitchDir == 2.0)       // Normal (b234:172 _197 = ObjectToWorld * normalOS = normalWS)
    {
        dirWS = normalWS;
    }
    else                                    // Object (b234 else = ObjectToWorld * _OffsetDir.xyz)
    {
        dirWS = TransformObjectToWorldDir(_OffsetDir.xyz, false);
    }
    dirWS *= _OffsetIntensity;              // * CB3_m0[19].y (b234:174-176)

    // vertex-color.A mask gate (b234:177).
    float vertexColorMask = (_UseVertexColorMask > 0.0) ? color.w : 1.0;      // b234:177
    // _297 = 1 - unity_ObjectToWorld._m01 (b234:178, identical across every offset pass b236/b262/b264/b596/b626/
    //   b772/b778/b816/b822). The blob multiplies the whole displacement by this per-draw matrix term
    //   (b234:485-487 `mad(_292*(_281*_950), _297, base)`). It is reproduced EXACTLY here — URP exposes
    //   unity_ObjectToWorld (Core.hlsl), so there is zero infra cost and folding it to 1.0 would change the
    //   displacement magnitude on any rotated/sheared instance (m01 != 0). 1:1 binds the multiplier.
    float perDrawScale = 1.0 - unity_ObjectToWorld._m01;                      // b234:178 (_297)
    return dirWS * (offsetScalar * vertexColorMask * perDrawScale);           // b234:485-487 add to worldPos
#else
    return float3(0.0, 0.0, 0.0);
#endif
}

// ==============================================================================================
// _SIMPLE_VERTEXANIM (+ _SIMPLE_VERTEXANIM_CLOTH / _ROPE / _PENDULUM) — simple vertex wind anim (vertex stage).
//
// GROUND TRUTH:
//   CLOTH  (the master keyword set the merged shader declares per the ref's parity): the CLEAN-NAMED Rosetta
//          littransparent/Sub0_Pass0_Vertex_b59.hlsl:180-241 (Keywords _SIMPLE_VERTEXANIM _SIMPLE_VERTEXANIM_CLOTH
//          _TWO_BASEMAP). UNLIKE the lit blobs, b59's decompiler kept the REAL property names
//          (_SimpleVertexAnimationWindIntensity_at_328 / _WindFreq_at_332 / _WindSoftFactor_at_336 /
//          _MainDirectionAngle / _Kite / _DirectionTendency / _Use_Custom_WindDir / _NoiseOffsetIntensity), so the
//          role decode is EXACT (no GAP-A guessing for cloth). == aliased twin lit/Sub0_Pass0_Vertex_b570.hlsl:252-303.
//   ROPE   = lit/Sub0_Pass0_Vertex_b590.hlsl:266-315 (no clean transparent twin — littransparent ships only CLOTH).
//   PENDULUM = lit/Sub0_Pass0_Vertex_b596.hlsl:268-319.
//   The b590/b596 SVA properties are decompiler-aliased onto VAT/offset slots; decoded by FORMULA-ROLE against the
//   b59 Rosetta + the gate-pattern + the property packoffsets (the same GAP-A role-decode this file already accepts
//   for _USE_VERTOFFSET / _UV_ANIMATION / _DETAIL_MAP). The decode is anchored, not guessed:
//     - GATE: b59 gates on `(_WindIntensity_at_328 + _NoiseOffsetIntensity) != 0`; b590/b596 gate on
//       `(_CommonVATAutoPlay + _OffsetDir.w) != 0` at the SAME site -> _CommonVATAutoPlay=_WindIntensity,
//       _OffsetDir.w=_NoiseOffsetIntensity (BYTE-identical gate => unambiguous).
//     - _CommonVATFPS (b590:277 / b596:290, the `sin(mad(FREQ, windTime, instPhase))` multiplier) = _WindFreq
//       (b59:198 spells `_WindFreq_at_332` in that exact slot).
//     - _MainDirectionAngle (b596:278 deg->rad) is its OWN clean name in b596 (== b59:193). _Use_Custom_WindDir
//       (b596:283-284 wind-dir blend selector) is clean too (== b59:236).
//     - _OffsetDir.z (b590:295 noise on/off branch) = _Add_Noise ; _OffsetDir.x (b590:276 anchor adjust) =
//       _RopeAnchorAdjust ; _OffsetDir.y (b590:304 noise UV tiling) = _NoiseOffsetTilling.
//     - _CommonVATCurrentFrame (b596:287 anchor lerp selector `mad(sel, customAnchor - instOrigin, instOrigin)`)
//       = _Use_Custom_Anchor ; _AnchorPoint is clean ; _CommonVATMapParams.y (b596:310 self-rot phase freq)
//       = _SelfRotationSpeed ; _CommonVATMapParams.z (b590:288 / b596:320 vtx-color amplitude blend) = _Stability.
//
// INFRA SUBSTITUTIONS (faithful, STYLE_BIBLE §2 vertex table — the SAME ones this file already makes):
//   (1) HG global wind TIME accumulator `_WindGlobalParams0.y` (b59:198 _lightCookieData[114].y) -> URP `_Time.y`.
//       This is the IDENTICAL HG-time->_Time.y substitution used for _USE_VERTOFFSET (CoreVertex.hlsl:142),
//       _UV_ANIMATION (:92-93), the disturb warp and the VAT clock. The wind anim is `sin(freq*windTime + phase)`,
//       i.e. continuous seconds — _Time.y is the exact substitute.
//   (2) per-instance phase `CB2_m0[inst*16+3].x` = ObjectToWorld translation .x (the SRP-batcher instance matrix
//       column 3) -> URP `unity_ObjectToWorld._m03` (object world-origin X) — desyncs instances. (.y/.z likewise
//       -> _m13/_m23.)
//   (3) world-vertex term `_118` = `mul(ObjectToWorld,posOS).z` (b59:191 instance-matrix row 2) -> `positionWS.z`.
//   (4) per-draw scale `_226` = `1 - unity_ObjectToWorld[1].x` (b59:252, the SEPARATE per-draw matrix) ->
//       `1 - unity_ObjectToWorld._m01` — IDENTICAL to _USE_VERTOFFSET's _297 (CoreVertex.hlsl:172). The blob
//       multiplies the WHOLE displacement by it (b59:236-241 consumed `mad(offset,_226,baseWorldPos)`), so 1:1
//       keeps it. (skin/oct-normal/motion-vector prev-frame copy dropped — CoreVertex.hlsl:477 base policy.)
//   (5) noise scroll clock `_TimeParameters.w` (b590:304) -> `_Time.y` (same continuous-seconds channel as (1)).
//
// ENGINE-SIDE GAP (legit, documented — same class as PlanarReflection's _FakePlanarReflectionViewProjMatrix):
//   the NON-custom wind DIRECTION `_WindGlobalParams0.zw` (b59:232-233 _lightCookieData[114].zw) is HGRP's HOST
//   global wind-simulation direction (register c114, populated by HG's wind-motor system _WindMotorParams0..3 /
//   _WindMotorCount). URP/AzureNihil has NO global wind system binding these; they are declared NOWHERE in the
//   merged shader. When `_Use_Custom_WindDir == 1` the direction comes PURELY from `_MainDirectionAngle`
//   (material) and the path is FULLY 1:1. When 0, the blob would read the host wind dir; with no URP binding the
//   faithful neutral fallback is the SAME custom-angle basis (HG_WIND_DIR_FALLBACK below) so the keyword stays
//   functional and the base path is never regressed. A host C# wind-state global (float4 _WindGlobalParams0) bound
//   per-frame would close it exactly — identical remedy to the planar-reflection host feature.
//
// CONSUMPTION: all three modes write an ADDITIVE world-space delta * perDrawScale (b590/b596 `_237=_Stability*
//   ((world+rotΔ) - world)` is a delta; b59 cloth is a delta directly), so this returns `deltaWS` and the caller
//   does `positionWS += deltaWS` then re-derives clip — IDENTICAL wiring to _USE_VERTOFFSET. Off-path: float3(0).
//   Wind direction basis is horizontal XZ: (cos(angle), 0, sin(angle)) — b59 Y term _496/_529 fold to 0.
// ----------------------------------------------------------------------------------------------
#if defined(_SIMPLE_VERTEXANIM)
// HG sin/cos via the blob's polynomial approx of the deg->rad angle (b59:193-197 / b596:278-282). Kept 1:1
//   (NOT replaced by intrinsic sin/cos) because the blob feeds these EXACT 4th/5th-order series as the wind-dir
//   basis and folding to intrinsics would drift the low-order error the magnitude rides on.
//   cos: mad(a2*a2, 0.0139.., mad(-a2, 0.50040.., 1.0))   sin: mad(a2*a3, 0.00834.., mad(-a3, 0.16680.., a))
float2 HgSimpleAnimCosSin(float angRad)
{
    float a2 = angRad * angRad;
    float a3 = angRad * a2;
    float c  = mad(a2 * a2, 0.013899999670684337615966796875, mad((-0.0) - a2, 0.500400006771087646484375, 1.0));   // b59:196 (_138)
    float s  = mad(a2 * a3, 0.008340000174939632415771484375, mad((-0.0) - a3, 0.1667999923229217529296875, angRad)); // b59:197 (_144)
    return float2(c, s);
}
#endif

float3 LitEffectSimpleVertexAnimDeltaWS(float3 positionWS, float3 positionOS, float4 color, float2 uv0)
{
#if defined(_SIMPLE_VERTEXANIM)
    // gate: vertexColor.w != 0 AND (windIntensity + noiseOffsetIntensity) != 0 (b59:188). Off -> zero delta.
    if (color.w == 0.0 || (_SimpleVertexAnimationWindIntensity + _NoiseOffsetIntensity) == 0.0)
        return float3(0.0, 0.0, 0.0);

    float perDrawScale = 1.0 - unity_ObjectToWorld._m01;                        // b59:252 (_226) per-draw matrix term
    float instPhase    = unity_ObjectToWorld._m03;                             // b59 CB2_m0[inst+3].x -> world-origin X phase
    float windTime     = _Time.y;                                             // INFRA (1): _WindGlobalParams0.y -> _Time.y

    // ---- HG global wind direction (engine-side gap): custom path is 1:1; non-custom falls back to the custom
    //      angle basis (URP has no host wind-dir global; see header). Horizontal XZ basis (cos,0,sin).
    float2 windCS = HgSimpleAnimCosSin(0.01746725477278232574462890625 * _MainDirectionAngle);  // b59:193 deg->rad (_128) + cos/sin
    #define HG_WIND_DIR_FALLBACK windCS                                        // _WindGlobalParams0.zw substitute (custom basis)
    float windDirX = lerp(HG_WIND_DIR_FALLBACK.x, windCS.x, _Use_Custom_WindDir); // b59:236/239 lerp(_526=_WGP.z, _138, useCustom)
    float windDirZ = lerp(HG_WIND_DIR_FALLBACK.y, windCS.y, _Use_Custom_WindDir); // b59:238/241 lerp(_528=_WGP.w, _144, useCustom)
    #undef HG_WIND_DIR_FALLBACK

#if defined(_SIMPLE_VERTEXANIM_ROPE)
    // ---- ROPE (b590:266-315): rotate the WORLD vertex about a per-instance anchor by a wind-driven angle, +noise.
    float3 worldP = positionWS;                                                // b590:272-274 (_140/_141/_142) = mul(O2W,posOS)
    float anchorY = mad(unity_ObjectToWorld._m11, _RopeAnchorAdjust, unity_ObjectToWorld._m13); // b590:276 (_159) anchor height
    float swing   = (0.5 * _SimpleVertexAnimationWindIntensity)
                  * sin(mad(_SimpleVertexAnimationWindFreq, windTime, instPhase)) * 0.100000001490116119384765625; // b590:277 (_174)
    float sw2 = swing * swing;  float sw3 = sw2 * swing;
    float swSin = mad(sw2 * sw3, 0.008340000174939632415771484375, mad((-0.0) - sw3, 0.1667999923229217529296875, swing));   // b590:280 (_190)
    float swCos = mad(sw2 * sw2, 0.013899999670684337615966796875, mad((-0.0) - sw2, 0.500400006771087646484375, 1.0));      // b590:293 (cos of swing)
    // instance horizontal axis (normalized world XZ of column 2) — the rope's bend plane (b590:282-286).
    float ax0 = unity_ObjectToWorld._m22;  float ax2 = -unity_ObjectToWorld._m02;
    float axInv = rsqrt(dot(float2(ax0, ax2), float2(ax0, ax2)));
    float axX = axInv * (-unity_ObjectToWorld._m02);                          // b590:285-286 (_206/_207)
    float axZ = axInv * ( unity_ObjectToWorld._m22);
    float armY = ((-0.0) - anchorY) + worldP.y;                               // b590:287 (_211) height above anchor
    float amp  = mad(_Stability, mad((-0.0) - color.w, 0.5 * _SimpleVertexAnimationWindIntensity, 1.0),
                     (0.5 * _SimpleVertexAnimationWindIntensity) * color.w);  // b590:288 (_223) color-blended amplitude
    // bent position - world  ==> additive delta (b590:292-294). X/Z: the +world/-world cancel (rotation about
    //   the vertical through world XZ). Y is referenced to the ANCHOR: _238 = amp*((anchorY + armY*swCos) - worldY)
    //   = amp*armY*(swCos - 1) since armY = worldY - anchorY. (NOT amp*armY*swCos — must subtract worldY, not anchorY.)
    float dX = amp * ( ((-0.0) - (swSin * axX)) * armY );                     // b590:292 (_237) X
    float dY = amp * ( (anchorY + (armY * swCos)) - worldP.y );               // b590:293 (_238) Y (anchor-referenced)
    float dZ = amp * ( ( swSin * axZ) * armY );                              // b590:294 (_239) Z
    // _Add_Noise (b590:299-308, _OffsetDir.z): scroll _NoiseOffsetTex by _NoiseOffsetSpeed*_Time.y*0.1, project
    //   _NoiseOffsetDir through the instance matrix, scale by noiseIntensity (_OffsetDir.w). +adds to the delta.
    if (_Add_Noise != 0.0)
    {
        // sample UV = (uv0.x*_NoiseOffsetTilling + scrollX, uv0.y*0 + scrollY) — b590:304 (TEXCOORD.x*_OffsetDir.y
        //   + speed, TEXCOORD.y*0 + speed); only U is tiled, V is pure scroll. _TimeParameters.w -> _Time.y (INFRA 5).
        float2 nUV = float2(mad(uv0.x, _NoiseOffsetTilling, (_Time.y * _NoiseOffsetSpeed.x) * 0.100000001490116119384765625),
                            mad(uv0.y, 0.0,                 (_Time.y * _NoiseOffsetSpeed.y) * 0.100000001490116119384765625)); // b590:304 UV
        float nS = SAMPLE_TEXTURE2D_LOD(_NoiseOffsetTex, sampler_NoiseOffsetTex, nUV, 0.0).x;                                          // b590:304-305 (_330/_332)
        float nDirX = mad(unity_ObjectToWorld._m03, _NoiseOffsetDir.w, mad(unity_ObjectToWorld._m02, _NoiseOffsetDir.z, mad(unity_ObjectToWorld._m00, _NoiseOffsetDir.x, _NoiseOffsetDir.y * unity_ObjectToWorld._m01))); // b590:306
        float nDirY = mad(unity_ObjectToWorld._m13, _NoiseOffsetDir.w, mad(unity_ObjectToWorld._m12, _NoiseOffsetDir.z, mad(unity_ObjectToWorld._m10, _NoiseOffsetDir.x, _NoiseOffsetDir.y * unity_ObjectToWorld._m11))); // b590:307
        float nDirZ = mad(unity_ObjectToWorld._m23, _NoiseOffsetDir.w, mad(unity_ObjectToWorld._m22, _NoiseOffsetDir.z, mad(unity_ObjectToWorld._m20, _NoiseOffsetDir.x, _NoiseOffsetDir.y * unity_ObjectToWorld._m21))); // b590:308
        dX = mad(nDirX * _NoiseOffsetIntensity, nS, dX);                      // b590:306 (_336)
        dY = mad(nDirY * _NoiseOffsetIntensity, nS, dY);                      // b590:307 (_337)
        dZ = mad(nDirZ * _NoiseOffsetIntensity, nS, dZ);                      // b590:308 (_338)
    }
    // vertex-color.w gate: b590 applies it as a SEPARATE outer factor (_385 = _336 * COLOR.w, b590:346-348)
    //   BEFORE the perDrawScale mad (_1212 = mad(_385, _395, baseWorld), b590:692). UNLIKE cloth/pendulum which
    //   bake color.w INTO the delta (b59:239 _216 / b596:350 _497), rope keeps _336/_337/_338 color-free until
    //   here — so the additive delta is (_336/_337/_338) * COLOR.w * _395. 1:1 requires this * color.w.
    return float3(dX, dY, dZ) * (color.w * perDrawScale);                     // b590:346-348 (* COLOR.w) + b590:692 (* _395)

#elif defined(_SIMPLE_VERTEXANIM_PENDULUM)
    // ---- PENDULUM (b596:268-319): rigid swing of the whole vertex about a (custom) anchor, axis = wind dir.
    float3 worldP = positionWS;                                               // b596:274-276 (_132/_133/_134)
    // anchor = lerp(instanceOrigin, _AnchorPoint, _Use_Custom_Anchor) (b596:287-289 _207/_208/_209).
    float3 instOrigin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);
    float3 anchor = float3(mad(_Use_Custom_Anchor, _AnchorPoint.x - instOrigin.x, instOrigin.x),
                           mad(_Use_Custom_Anchor, _AnchorPoint.y - instOrigin.y, instOrigin.y),
                           mad(_Use_Custom_Anchor, _AnchorPoint.z - instOrigin.z, instOrigin.z));
    // swing angle: sin(freq*windTime + instPhase)*intensity*0.1 -> cos/sin series (b596:290-294 _223/_229/_234).
    float swing = (0.5 * _SimpleVertexAnimationWindIntensity)
                * sin(mad(_SimpleVertexAnimationWindFreq, windTime, instPhase)) * 0.100000001490116119384765625;   // b596:290 (_223)
    float sw2 = swing * swing;  float sw3 = sw2 * swing;
    float swCos = mad(sw2 * sw2, 0.013899999670684337615966796875, mad((-0.0) - sw2, 0.500400006771087646484375, 1.0));      // b596:292 (_229)
    float swSin = mad(sw2 * sw3, 0.008340000174939632415771484375, mad((-0.0) - sw3, 0.1667999923229217529296875, swing));   // b596:294 (_234)
    // rotation axis = normalized world-horizontal wind dir (b596:295-302 _245/_246/_248/_249 from (-windZ, windX, -windX)).
    float axX2 = (-0.0) - windDirZ;  float axZ2 = (-0.0) - windDirX;
    float axInv = rsqrt(dot(float3(axX2, windDirX, axZ2), float3(windDirZ * (-1.0), windDirX, axZ2)));            // b596:299 (_245)
    float r0 = axInv * (windDirZ * (-1.0));  float r1 = axInv * windDirX;  float r2 = axInv * axZ2;               // b596:300-302
    float oneMinusCos = ((-0.0) - swCos) + 1.0;                                                                   // b596:303 (_251)
    float3 arm = worldP - anchor;                                                                                 // b596:307-309 (_258/_259/_260)
    // axis-angle rotation matrix * arm, projected (Rodrigues, b596:315-319) — X and Z rows; Y stays (rigid swing).
    //   _291 = (axInv * _236) * r0 with _236 = -windDirX (b596:295,315) ; _292 = r1*r0 ; _298 = r1*r2.
    float t291 = (axInv * ((-0.0) - windDirX)) * r0;                                                              // b596:315 (_291)
    float m00 = mad(r0 * r0, oneMinusCos, swCos);                                                                 // b596:318 col0
    float m01 = mad(t291,     oneMinusCos, (-0.0) - (swSin * r1));                                                // b596:318 col1 (_291,-_252)
    float m02 = mad(r1 * r0,  oneMinusCos, swSin * r2);                                                           // b596:318 col2 (_292,+_254)
    float m20 = mad(r1 * r0,  oneMinusCos, (-0.0) - (swSin * r2));                                                // b596:319 col0 (_292,-_254)
    float m21 = mad(r1 * r2,  oneMinusCos, swSin * r0);                                                           // b596:319 col1 (_298,+_253)
    float m22 = mad(r1 * r1,  oneMinusCos, swCos);                                                               // b596:319 col2
    float rotX = dot(float3(m00, m01, m02), arm);                                                                 // b596:318 (_308) rotated-arm X
    float rotZ = dot(float3(m20, m21, m22), arm);                                                                 // b596:319 (_314) rotated-arm Z
    // Y row (b596:351 inner): (mad(_291,1-c,_252), mad(_249²,1-c,c), mad(_298,1-c,-_253)) with _249=r2,
    //   _252=swSin*r1, _253=swSin*r0, _298=r1*r2.
    float yRow0 = mad(t291,    oneMinusCos, swSin * r1);                                                          // b596:351 col0 (_291,+_252)
    float yRow1 = mad(r2 * r2, oneMinusCos, swCos);                                                              // b596:351 col1 (_249²=r2²,+c)
    float yRow2 = mad(r1 * r2, oneMinusCos, (-0.0) - (swSin * r0));                                              // b596:351 col2 (_298,-_253)
    float rotY  = dot(float3(yRow0, yRow1, yRow2), arm);                                                         // b596:351 (_498 inner)
    // self-rotation sweep: angle _278 = sin(selfRotSpeed*windTime + instPhase)*selfRotRange*0.0087336 -> cos/sin
    //   (b596:310-314 _278/_284/_289 ; _CommonVATMapParams.y=_SelfRotationSpeed, _UseVertexColorMask=_SelfRotationRange).
    float srAng = (sin(mad(windTime, _SelfRotationSpeed, instPhase)) * _SelfRotationRange) * 0.008733627386391162872314453125; // b596:310 (_278)
    float sr2 = srAng * srAng;  float sr3 = srAng * sr2;
    float srCos = mad(sr2 * sr2, 0.013899999670684337615966796875, mad((-0.0) - sr2, 0.500400006771087646484375, 1.0));        // b596:312 (_284)
    float srSin = mad(sr2 * sr3, 0.008340000174939632415771484375, mad((-0.0) - sr3, 0.1667999923229217529296875, srAng));     // b596:314 (_289)
    float amp  = mad(_Stability, mad((-0.0) - color.w, 0.5 * _SimpleVertexAnimationWindIntensity, 1.0),
                     (0.5 * _SimpleVertexAnimationWindIntensity) * color.w);                                      // b596:320 (_337) color-blended amplitude
    // delta = amp * ( -world + (anchor + selfRot2D(rotX,rotZ)) ) * color.w  (b596:350-352).
    //   X: anchor.x + dot((srCos,srSin),(rotX,rotZ)) ; Z: anchor.z + dot((-srSin,srCos),(rotX,rotZ)) ; Y: anchor.y + rotY.
    float dX = (amp * (((-0.0) - worldP.x) + (anchor.x + dot(float2(srCos, srSin),         float2(rotX, rotZ))))) * color.w;  // b596:350 (_497)
    float dY = (amp * (((-0.0) - worldP.y) + (anchor.y + rotY)))                                               * color.w;     // b596:351 (_498)
    float dZ = (amp * (((-0.0) - worldP.z) + (anchor.z + dot(float2((-0.0) - srSin, srCos), float2(rotX, rotZ))))) * color.w; // b596:352 (_499)
    return float3(dX, dY, dZ) * perDrawScale;                                                                     // b596:699.. mad(delta,_507,baseWorld)

#else // _SIMPLE_VERTEXANIM_CLOTH (and bare _SIMPLE_VERTEXANIM master) — the clean b59 Rosetta path.
    // per-vertex world-height phase term (b59:191 _118 = mul(O2W,posOS).z).
    float worldZ = positionWS.z;
    float ampDefault = 0.5  * _SimpleVertexAnimationWindIntensity;             // b59:192 (_122)
    float ampKite    = 0.05 * _SimpleVertexAnimationWindIntensity;             // b59:204/217 (_234/_486 kite)
    float phase = windTime * _SimpleVertexAnimationWindFreq;                   // b59:198 (_153) = _WGP.y * freq -> _Time.y*freq
    float amplitude, wave;
    if (_Kite != 0.0)                                                          // b59:199 (_158) kite branch
    {
        amplitude = ampKite;
        // b59:205 / b570:269 kite wave reads OBJECT-space POSITION.y (the raw vertex attribute), NOT world Y —
        //   BOTH the `mad(POSITION.y, _SoftFactor, ...)` softness term AND the trailing `* POSITION.y` height
        //   weight. (The non-kite branch deliberately uses world Z via _118 = mul(O2W,posOS).z, b59:191/210 —
        //   the asymmetry is in the HG source.) Using positionWS.y here would fold in the instance world
        //   transform (translation/rotation/scale) and break 1:1, so the object-space vertex Y is passed in.
        wave = sin(mad(_Kite, mad(positionOS.y, _SimpleVertexAnimationWindSoftFactor, (-0.0) - (color.w * 3.1415927410125732421875)), phase) + instPhase) * positionOS.y; // b59:205 (_235) OBJECT-space Y
    }
    else
    {
        amplitude = ampDefault;
        wave = sin(mad((-0.0) - color.w, 3.1400001049041748046875, mad((-0.0) - worldZ, _SimpleVertexAnimationWindSoftFactor, phase)) + instPhase); // b59:210 (_235)
    }
    float waveScaled = (wave + _DirectionTendency) + 1.0;                      // b59:235 (_546)
    // per-axis delta = amplitude * waveScaled * windDir(X,0,Z) * vertexColor.w (b59:239-241).
    float dX = (amplitude * (waveScaled * windDirX)) * color.w;                // b59:239 (_216)
    float dY = 0.0;                                                            // b59:240 (_218) _496/_529 fold to 0
    float dZ = (amplitude * (waveScaled * windDirZ)) * color.w;                // b59:241 (_220)
    return float3(dX, dY, dZ) * perDrawScale;                                  // b59:236-241 consumed mad(delta,_226,baseWorld)
#endif
#else
    return float3(0.0, 0.0, 0.0);
#endif
}

// ==============================================================================================
// _FOLIAGE_TRUNK — trunk/branch wind: axis-angle trunk lean about the wind direction + a noise-driven
//                  per-branch flutter about the baked pivot (vertex stage). +_MOVING_BAMBOO below.
//
// GROUND TRUTH = the keyword-isolated vertex blob lit/Sub0_Pass0_Vertex_b484.hlsl (lit.shader:815/478
//   `_FOLIAGE_TRUNK` all-other-feature-OFF branch). b484's UnityPerMaterial cbuffer is decompiler-SCRAMBLED
//   (the trunk/branch uniforms aliased onto the VAT/offset metadata slots _CommonVAT*/_OffsetTex_ST/_OffsetDir/
//   _OffsetSwitchDir/_UseVertexColorMask/_Use_Custom_WindDir/_MainDirectionAngle/_AnimateVertexHasPivot).
//   The CLEAN-NAMED Rosetta is foliage/leaf/Sub0_Pass0_Vertex_b101.hlsl — its decompiler kept the REAL property
//   names and the trunk math is BYTE-IDENTICAL to b484, so every alias is decoded by formula-role against b101
//   (the SAME GAP-A role-decode this file accepts for _USE_VERTOFFSET / _UV_ANIMATION / _SIMPLE_VERTEXANIM):
//     b484 _999  (b484:524, gate `_CommonVATCurrentFrame>0`)  == b101 _1024 (gate `_AnimateVertexTrunkIntensity>0`)
//        -> _CommonVATCurrentFrame      = _AnimateVertexTrunkIntensity
//     b484 _1009 = mad(_924+_WGP0.y, _UseVertexColorMask, _999)  == b101 _1030 = mad(_908+_WGP0.y, _AnimateVertexTrunkFrequency, _1024)
//        -> _UseVertexColorMask         = _AnimateVertexTrunkFrequency   (the phase-rate multiplier)
//     b484 _1017 = clamp(COLOR.w - _Use_Custom_WindDir,0,1)      == b101 _1038 = clamp(COLOR.w - _AnimateVertexTrunkThreshold,0,1)
//        -> _Use_Custom_WindDir         = _AnimateVertexTrunkThreshold   (vertex-color.A bottom cutoff)
//     b484 _1037 = (_1018 * (_936 * mad(sway, _975, _970*_MainDirectionAngle)) * _AnimateVertexHasPivot) * deg2rad
//          == b101 _1058 = (_1039 * (_920 * mad(sway, _999, _994*_AnimateVertexTrunkLeanFactor)) * _CrossCardViewCullingThreshold) * deg2rad
//        -> _MainDirectionAngle (in trunk) = _AnimateVertexTrunkLeanFactor ; _AnimateVertexHasPivot (in trunk lean) = the
//           pivot-toggle gate (b101 spells the leaf's own toggle _CrossCardViewCullingThreshold; in the LIT material the
//           overall trunk gate is _AnimateVertexHasPivot — kept as the merged shader's _AnimateVertexHasPivot).
//   BRANCH block (b484:543-568 `if(_1081)`) == b101 `if(_1102)` (b101:517-537). The leaf binds its branch flutter to
//     LEAF properties (_WindInteractionLeafStiffness/Frequency, b101:526); the LIT material has no leaf split, so the
//     two `_OffsetTex_ST.z/.w` reads role-decode to the lit branch shape pair (GAP-A, leaf-anchored formula):
//        b484 _OffsetSwitchDir (b484:263,549, pivot UV gate/select)        = _AnimateVertexHasPivot   (b101:227-229,519-521 `_AnimateVertexHasPivot`)
//        b484 _OffsetDir.x      (b484:553, noise planar-UV scale, squared)  = _AnimateVertexBranchIntensity (b101:523 `_WindInteractionBranchIntensity`)
//        b484 _CommonVATMapParams.z (b484:554, planar-UV pivot select)      = _AnimateVertexTrunkLeanFactor (b101:524 `_AnimateVertexTrunkLeanFactor_at_252`)
//        b484 _CommonVATCurrentFrame (b484:554,556, planar-UV scale + octave weights) = _AnimateVertexTrunkIntensity (b101:524,526 `_AnimateVertexTrunkIntensity`)
//        b484 _CommonVATMapParams.y (b484:555, noise time-scale)            = _AnimateVertexTrunkThreshold (b101:525 `_AnimateVertexTrunkThreshold_at_248`)
//        b484 _CommonVATMapParams.w (b484:556, branch-mode blend)           = _SwitchBranchWindMode        (b101:526 `_SwitchBranchWindMode`)
//        b484 _OffsetTex_ST.z       (b484:556, COLOR.z length base)         = _AnimateVertexBranchStiffness (b101:526 `_WindInteractionLeafStiffness` role)
//        b484 _OffsetTex_ST.w       (b484:556, COLOR.z length exponent)     = _AnimateVertexBranchShapeCurve(b101:526 `_WindInteractionLeafFrequency` role)
//        b484 _CommonVATMapParams.x (b484:556, branch overall intensity)    = _AnimateVertexBranchFrequency (b101:526 `_AnimateVertexTrunkFrequency_at_244` role -> the lit branch amount)
//     The MATH/constants (0.02 planar scale, 25.1327.. octave base, the 4-octave sin weights
//     mad(I,-0.25,0.5)/mad(I,0,0.25)/mad(I,0.125,0.125)/mad(I,0.1875,0.0625), exp2/log2 length term, 6.28318.. phase,
//     0.0174532.. deg->rad) are transcribed BYTE-IDENTICAL — that is what 1:1 binds; the alias label is cosmetic.
//
// INFRA SUBSTITUTIONS (faithful, STYLE_BIBLE §2 — the SAME ones this file already makes):
//   (1) HG global wind TIME `_WindGlobalParams0.y` (b484:525,555) -> URP `_Time.y` — IDENTICAL to _USE_VERTOFFSET
//       (CoreVertex.hlsl:142) / _UV_ANIMATION (:92-93) / _SIMPLE_VERTEXANIM (:261). The bend phase is sin(rate*windTime
//       + perInstancePhase), continuous seconds.
//   (2) world-oriented object offset `_111/_112/_113 = mul((float3x3)O2W, posOS)` (b484:256-258) -> URP
//       `TransformObjectToWorldDir(positionOS, false)` (un-normalized) == `positionWS - instOrigin`. Full world pos
//       `_121.. = _111.. + CB2[inst+3]` (b484:260-262) -> `positionWS`. Pivot point `_169.. = mul((float3x3)O2W, pivot)
//       + CB2[inst+3]` (b484:269-271) -> `TransformObjectToWorldDir(pivotOS,false) + instOrigin`. Object scale
//       `_185 = |O2W col0|` (b484:272) -> `length(TransformObjectToWorldDir(float3(1,0,0),false))`.
//   (3) per-instance world origin `CB2[inst+3]` (the SRP instance-matrix col 3) -> `unity_ObjectToWorld._m03/_m13/_m23`.
//   (4) per-draw scale `_2693 = 1 - unity_ObjectToWorld[1].x` (b484:871,1203 consumed `mad(delta,_2693,baseWorld)`) ->
//       `1 - unity_ObjectToWorld._m01` — IDENTICAL to _USE_VERTOFFSET's _297 / SVA's _226. Multiplies the whole delta.
//   (5) baked trunk PIVOT in the extra UV channels: b484 reads (TEXCOORD_1.xy, TEXCOORD_2.x) (b484:263-265,175-176) ->
//       URP (IN.uv1.xy, IN.uv2.x). "_AnimateVertexHasPivot" toggles whether the pivot was authored into uv1/uv2.
//
// ENGINE-SIDE GAP (legit, documented — same class as SVA's _WindGlobalParams0.zw / PlanarReflection's host matrix):
//   the SWAY accumulation `_924/_926/_928/_930` (b484:273-510) is HGRP's host WIND-MOTOR simulation (_WindMotorParams0..3
//   / _WindMotorCount / _WindGlobalParams0), a per-frame runtime wind-zone solve with NO URP binding (declared NOWHERE in
//   the merged shader). With no host wind, the faithful neutral is zero motor contribution, so the sway magnitude floors
//   to the global base `_936 = max(0, _WindGlobalParams0.x)` and the wind DIRECTION blends to `_WindGlobalParams0.zw`.
//   Those globals also have no URP binding; the faithful neutral that keeps the keyword FUNCTIONAL (never regressing the
//   base path) drives the bend from the material `_AnimateVertexTrunkLeanFactor` amount + a unit horizontal wind axis from
//   `_MainDirectionAngle` (the SAME custom-angle fallback SVA uses for its missing _WGP0.zw), with a neutral unit base
//   magnitude so the per-instance trunk still leans. A host C# float4 _WindGlobalParams0 + _WindMotorParams* bound
//   per-frame would close it EXACTLY — identical remedy to the SVA wind-dir host feature.
//
// CONSUMPTION: returns the ADDITIVE world-space delta (trunk bend `_1071/_1072/_1073` + branch `_1476/_1477/_1478` are a
//   delta on the world-oriented offset, consumed `mad(delta, perDrawScale, baseWorldPos)`), so the caller does
//   `positionWS += delta` then re-derives clip — IDENTICAL wiring to _USE_VERTOFFSET. Off-path: float3(0). The b484
//   _2300/_2686 stack (previous-frame, _LastWind*) is the dual-frame MOTION-VECTOR copy -> DROPPED (CoreVertex.hlsl base
//   policy, header lines 18-20: URP has a dedicated MotionVectors pass).
// ----------------------------------------------------------------------------------------------
#if defined(_FOLIAGE_TRUNK)
// HG wind globals (host wind-motor simulation, no URP binding — engine-side gap; see header). Folded to their
//   no-host-wind neutral: base magnitude 0 (-> trunk leans off the material amount), global wind dir 0 (-> the
//   _MainDirectionAngle custom-angle fallback drives the axis). `.y` is the wind TIME -> substituted by _Time.y inline.
static const float4 HG_FOLIAGE_WIND_GLOBAL = float4(0.0, 0.0, 0.0, 0.0);   // (_WGP0.x base, _WGP0.y=time->_Time.y, _WGP0.zw dir)

// pivotUv1 = (TEXCOORD_1.x, TEXCOORD_1.y) baked pivot, pivotUv2 = (TEXCOORD_2.x, TEXCOORD_2.y) (b484:263-265,524). The
//   caller resolves these from the active Attributes layout (narrow uv1/uv2, or — if VAT co-compiles and widens the
//   struct — uv1.xy / the pivot slot), so this function is layout-agnostic.
float3 LitFoliageTrunkDeltaWS(float3 positionWS, float3 positionOS, float4 color, float2 pivotUv1, float2 pivotUv2)
{
    // ---- per-instance world origin (CB2[inst+3] -> unity_ObjectToWorld col 3) and the world-oriented offset
    //      _111.. = mul((float3x3)O2W, posOS) == positionWS - instOrigin (b484:256-262 ; INFRA 2/3).
    float3 instOrigin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);
    float3 offWS  = positionWS - instOrigin;                                   // _111/_112/_113 (world-oriented offset)
    float3 worldP = positionWS;                                                // _121/_122/_123 (full world pos)
    float  objScale = length(TransformObjectToWorldDir(float3(1.0, 0.0, 0.0), false)); // _185 = |O2W col0| (b484:272)

    // ---- pivot UV (baked into uv1.xy / uv2.x), gated by _AnimateVertexHasPivot (b484:263-265, INFRA 5).
    float pivU0 = pivotUv1.x * _AnimateVertexHasPivot;                         // _134 (b484:263)
    float pivU1 = pivotUv1.y * _AnimateVertexHasPivot;                         // _135 (b484:264)
    float pivU2 = pivotUv2.x * _AnimateVertexHasPivot;                        // _136 (b484:265)

    // ============================ wind SWAY accumulation (engine-side gap) ============================
    // _924/_926/_928/_930 = host wind-motor sway (b484:273-510). No URP binding -> neutral (zero motor contribution).
    float swayAccum  = 0.0;                                                    // _924 (phase add, wind-zone time accumulator)
    float swayMag    = 0.0;                                                    // _926 (sway magnitude)
    float swayDirX   = 0.0;                                                    // _928
    float swayDirZ   = 0.0;                                                    // _930

    // ---- global-wind blend (b484:511-519). _936 = max(swayMag, _WGP0.x) ; dir = lerp(globalDir, swayDir, blend) then
    //      normalized. With neutral host wind (swayMag=0, _WGP0=0) the dir degenerates -> rsqrt(0); the faithful
    //      custom-angle fallback supplies a unit horizontal axis from _MainDirectionAngle (engine-side-gap remedy).
    float windBase = max(swayMag, HG_FOLIAGE_WIND_GLOBAL.x);                   // _936
    float windBlend = swayMag / ((swayMag + HG_FOLIAGE_WIND_GLOBAL.x) + 0.00999999977648258209228515625); // _943
    float gWindZ = HG_FOLIAGE_WIND_GLOBAL.z;                                   // _948 (_WGP0.z)
    float gWindW = HG_FOLIAGE_WIND_GLOBAL.w;                                   // _950 (_WGP0.w)
    float windX = mad(windBlend, swayDirX + ((-0.0) - gWindZ), gWindZ);        // _957 (b484:515)
    float windZ = mad(windBlend, swayDirZ + ((-0.0) - gWindW), gWindW);        // _959 (b484:516)
    float windLenSq = dot(float2(windX, windZ), float2(windX, windZ));
    float2 windDir;
    if (windLenSq > 0.0)                                                       // _963 = rsqrt(_957²+_959²) (b484:517-519)
    {
        float windInv = rsqrt(windLenSq);
        windDir = float2(windInv * windX, windInv * windZ);                    // _964 / _966
    }
    else
    {
        // engine-side-gap fallback (no host wind dir): unit horizontal axis from _MainDirectionAngle, the SAME
        //   custom-angle substitute SVA uses for its missing _WGP0.zw (CoreVertex.hlsl:265-268).
        float ang = 0.01745329238474369049072265625 * _MainDirectionAngle;     // deg->rad
        windDir = float2(cos(ang), sin(ang));                                  // unit (_964, _966)
    }
    float windBaseClamp = clamp(windBase * 0.20000000298023223876953125, 0.0, 1.0); // _969
    float windBase2 = windBaseClamp * windBaseClamp;                          // _970
    float windInvClamp = ((-0.0) - windBaseClamp) + 1.0;                      // _972
    float windShape = mad((-0.0) - (windInvClamp * windInvClamp), windInvClamp, 1.0); // _975 (smoothstep-ish)

    // ---- per-instance phase _999 (b484:524). gate `_AnimateVertexTrunkIntensity>0 ? uv2.y : 0` + the world-origin
    //      dot phase (CB2[inst+3].xzy . (0.08,0.08,-0.03)) * 2PI. CB2[inst+3] -> instOrigin (xzy swizzle preserved).
    float pivPhaseSel = (_AnimateVertexTrunkIntensity > 0.0) ? pivotUv2.y : 0.0; // (b484:524 `_CommonVATCurrentFrame>0 ? TEXCOORD_2.y`)
    float instPhase = (((-0.0) - pivPhaseSel)
                      + dot(instOrigin.xzy, float3(0.07999999821186065673828125, 0.07999999821186065673828125, -0.02999999932944774627685546875)))
                      * 6.283185482025146484375;                              // _999
    // ---- master trunk lean angle (radians) (b484:525-528). phase = (swayAccum + windTime)*trunkFreq + instPhase ;
    //      lean = colorBottom² * (windBase * (sway-shaped + windBase2*trunkLean)) * hasPivot * deg2rad.
    float trunkPhase = mad(swayAccum + _Time.y, _AnimateVertexTrunkFrequency, instPhase);   // _1009 (INFRA 1: _WGP0.y->_Time.y)
    float colBottom = clamp(color.w + ((-0.0) - _AnimateVertexTrunkThreshold), 0.0, 1.0);   // _1017
    float colBottom2 = colBottom * colBottom;                                                // _1018
    float leanAngle = (colBottom2 * ((windBase * mad(mad(sin(trunkPhase), 0.5, cos(trunkPhase * 0.5) * 0.25), windShape, windBase2 * _AnimateVertexTrunkLeanFactor)) * _AnimateVertexHasPivot)) * 0.01745329238474369049072265625; // _1037

    // ---- axis-angle rotation of the world-oriented offset about the (horizontal) wind axis (b484:529-542).
    //      axis = normalize(windDir.y, -windDir.x) in the XZ-vertical plane ; Rodrigues matrix * offWS, then minus offWS
    //      = the additive bend delta on the offset.
    float leanSin = sin(leanAngle);                                           // _1039
    float leanCos = cos(leanAngle);                                           // _1040
    float oneMinusCos = ((-0.0) - leanCos) + 1.0;                             // _1042
    float axRawX = windDir.y;                                                 // _966 (= windDir z-component)
    float axRawY = (-0.0) - windDir.x;                                        // _1043 = -_964
    float axInv = rsqrt(dot(float2(axRawX, axRawY), float2(axRawX, axRawY))); // _1047
    float ax0 = axInv * axRawX;                                               // _1048
    float ax1 = axInv * axRawY;                                               // _1049
    float t1051 = oneMinusCos * ax1;                                          // _1051
    float t1052 = leanSin * ax1;                                             // _1052
    float t1053 = leanSin * ax0;                                            // _1053
    float t1056 = ax0 * t1051;                                              // _1056
    // bend delta = R*offWS - offWS (b484:540-542 the leading `-_111 + dot(...)`).
    float3 bendDelta = float3(
        ((-0.0) - offWS.x) + dot(float3(mad(ax0 * ax0, oneMinusCos, leanCos), (-0.0) - t1052, t1056), offWS), // _1071
        ((-0.0) - offWS.y) + dot(float3(t1052, leanCos, (-0.0) - t1053), offWS),                              // _1072
        ((-0.0) - offWS.z) + dot(float3(t1056, t1053, mad(t1051, ax1, leanCos)), offWS));                     // _1073

    // ============================ per-branch noise flutter (b484:543-568 `if(_1081)`) ============================
    // gate: any pivot UV channel non-zero (the vertex was authored with a branch pivot). Off -> trunk bend only.
    float3 outDelta = bendDelta;                                              // _1476/_1477/_1478 (else branch = trunk only)
    if ((pivU2 != 0.0) || (pivU1 != 0.0) || (pivU0 != 0.0))                   // _1081 (b484:543)
    {
        // branch-local vertex = pivotUV*hasPivot - posOS (b484:549-551).
        float3 branchLocal = float3(mad(pivotUv1.x, _AnimateVertexHasPivot, (-0.0) - positionOS.x),  // _1322
                                    mad(pivotUv1.y, _AnimateVertexHasPivot, (-0.0) - positionOS.y),  // _1323
                                    mad(pivotUv2.x, _AnimateVertexHasPivot, (-0.0) - positionOS.z)); // _1324
        // noise planar UV: object-space planar coords scrolled by trunk-lean-select + branch-intensity² scale (b484:553-555).
        float branchScale = _AnimateVertexBranchIntensity * _AnimateVertexBranchIntensity;       // _1385 (b484:553)
        float planarBias = (mad(instOrigin.y, 0.00999999977648258209228515625, mad(_AnimateVertexTrunkLeanFactor, branchLocal.y, positionOS.y)) * _AnimateVertexTrunkIntensity) * 0.0199999995529651641845703125; // _1390 (b484:554 ; CB2[inst+3].y -> instOrigin.y)
        float2 noiseUV = float2(mad(mad(instOrigin.x, 0.00999999977648258209228515625, mad(_AnimateVertexTrunkLeanFactor, branchLocal.x, positionOS.x)), branchScale, planarBias),  // (b484:555 CB2[inst+3].x -> instOrigin.x)
                                mad(mad(instOrigin.z, 0.00999999977648258209228515625, mad(_AnimateVertexTrunkLeanFactor, branchLocal.z, positionOS.z)), branchScale, planarBias)); // (CB2[inst+3].z -> instOrigin.z)
        // sample _NoiseOffsetTex.y (the noise-offset texture; CLAMP, LOD 0), then octave-mix into the flutter phase
        //   (b484:555 `mad(tex.y, 25.1327.., _WGP0.y*timeScale)`). _WGP0.y -> _Time.y (INFRA 1).
        float noisePhase = mad(SAMPLE_TEXTURE2D_LOD(_NoiseOffsetTex, sampler_NoiseOffsetTex, noiseUV, 0.0).y, 25.1327419281005859375, _Time.y * _AnimateVertexTrunkThreshold); // _1406
        // 4-octave sin weighted by trunkIntensity, shaped by windShape, blended by branch-mode, scaled by the COLOR.z
        //   length term (exp2/log2) * objScale*0.5 * branch amount (b484:556). EXACT constants.
        float flutter = mad(dot(float4(sin(noisePhase * 1.0), sin(noisePhase * 0.5), sin(noisePhase * 0.25), sin(noisePhase * 0.125)),
                                float4(mad(_AnimateVertexTrunkIntensity, -0.25, 0.5), mad(_AnimateVertexTrunkIntensity, 0.0, 0.25), mad(_AnimateVertexTrunkIntensity, 0.125, 0.125), mad(_AnimateVertexTrunkIntensity, 0.1875, 0.0625))),
                            windShape, windBase2 * _SwitchBranchWindMode)
                       * (((mad(_AnimateVertexBranchStiffness, mad(sqrt(dot(branchLocal, branchLocal)), 0.5, -1.0), 1.0)
                            * exp2((((-0.0) - _AnimateVertexBranchStiffness) + _AnimateVertexBranchShapeCurve) * log2(abs(color.z))))
                           * (objScale * 0.5)) * _AnimateVertexBranchFrequency);                  // _1435
        // pivot point in world (b484:269-271): mul((float3x3)O2W, pivotUV) + instOrigin.
        float3 pivotWS = TransformObjectToWorldDir(float3(pivU0, pivU1, pivU2), false) + instOrigin; // _169/_170/_171
        // displaced vertex along the wind dir, length-preserved about the pivot (b484:557-567). _1442.. = -pivotWS +
        //   (windDir*flutter + worldP) ; renormalize to the original pivot->vertex length ; delta back to world + bend.
        float3 disp = float3(((-0.0) - pivotWS.x) + mad(windDir.x, flutter, worldP.x),   // _1442
                             ((-0.0) - pivotWS.y) + mad(0.0,        flutter, worldP.y),   // _1443 (b484:558 _963*mad(_943,0,0)=0)
                             ((-0.0) - pivotWS.z) + mad(windDir.y, flutter, worldP.z));   // _1444
        float dispInv = rsqrt(max(dot(disp, disp), 1.1754943508222875079687365372222e-38)); // _1450
        float3 armWS = worldP - pivotWS;                                                      // _1457/_1458/_1459
        float armLen = sqrt(dot(armWS, armWS));                                               // _1463
        // _1476.. = (-worldP + (pivotWS + normalize(disp)*armLen)) + bendDelta  (b484:565-567).
        outDelta = float3(((-0.0) - worldP.x) + mad(dispInv * disp.x, armLen, pivotWS.x),     // _1476
                          ((-0.0) - worldP.y) + mad(dispInv * disp.y, armLen, pivotWS.y),     // _1477
                          ((-0.0) - worldP.z) + mad(dispInv * disp.z, armLen, pivotWS.z))     // _1478
                 + bendDelta;
    }

    // per-draw scale (b484:1203 `mad(delta, _2693, baseWorld)`), IDENTICAL to _USE_VERTOFFSET's _297 / SVA's _226.
    float perDrawScale = 1.0 - unity_ObjectToWorld._m01;                       // _2693
    return outDelta * perDrawScale;
}
#endif

// ==============================================================================================
// _MOVING_BAMBOO — per-segment bamboo trunk sway: bend the world-oriented vertex offset toward a per-instance
//                  sway direction by a cubic height profile, length-preserved about the instance origin (vertex stage).
//
// GROUND TRUTH = the keyword-isolated vertex blob lit/Sub0_Pass0_Vertex_b496.hlsl (lit.shader:833/479
//   `_MOVING_BAMBOO` all-other-feature-OFF branch), displacement math b496:227-243. The two material uniforms are
//   aliased onto the VAT slots (_AnimateVertexHasPivot c20 / _UseVertexColorMask c20.y) — role-decoded against the
//   lit.shader bamboo property block (lit.shader:247-248 `_MovingBambooTrunkCurve` / `_MovingBambooTrunkIntensity`):
//     b496 _138 = mad(_AnimateVertexHasPivot, _129³-_129, _129) where _129 = posOS.y*0.1   (the bend HEIGHT PROFILE
//          lerp linear<->cubic) -> _AnimateVertexHasPivot = _MovingBambooTrunkCurve (lit.shader curve, 0=straight)
//     b496 _154 = worldX + _138*(_UseVertexColorMask * sway.x) - instOrigin.x  (the sway AMPLITUDE)
//          -> _UseVertexColorMask = _MovingBambooTrunkIntensity (lit.shader sway amount)
//   MATH (0.1 height scale, the cubic `y³-y` profile, length-preserve renormalize, the Y-axis having NO sway term
//   `+ asfloat(0u)` = +0) transcribed BYTE-IDENTICAL.
//
// INFRA / ENGINE-SIDE GAP:
//   world-oriented offset `_102.. = mul((float3x3)O2W, posOS)` (b496:223-225) -> TransformObjectToWorldDir(posOS,false)
//     == positionWS - instOrigin ; full world `_112.. = _102.. + CB2[inst+3]` -> positionWS ; instOrigin = CB2[inst+3]
//     -> unity_ObjectToWorld._m03/_m13/_m23 ; per-draw scale `_189 = 1 - O2W[1].x` (b496:243, consumed
//     `mad(_182,_189,baseWorld)` b496:575) -> `1 - unity_ObjectToWorld._m01` (IDENTICAL to _USE_VERTOFFSET's _297).
//   The per-instance SWAY direction `CB2[inst+13].xy` (b496:230,234,236) is HGRP's host bamboo wind-state written per
//   instance by the wind system — NO URP binding (the instance block beyond col 9 is engine infrastructure, header
//   lines 18). Faithful neutral = zero sway; then the bent offset == the original offset, normalize*len == offset, and
//   the delta `_182.. = -worldP + (instOrigin + offset) = 0` — a clean identity that NEVER regresses the base path and
//   keeps the keyword functional. A host C# per-instance sway (float4 bound at the instance slot, or a global wind
//   feeding the bamboo) would close it EXACTLY — same remedy class as the foliage-trunk wind-motor gap above.
//
// CONSUMPTION: returns the ADDITIVE world-space delta `_182/_183/_184` * perDrawScale ; caller does
//   `positionWS += delta` then re-derives clip (off-path: float3(0)). Same wiring as _USE_VERTOFFSET / _FOLIAGE_TRUNK.
// ----------------------------------------------------------------------------------------------
#if defined(_MOVING_BAMBOO)
// per-instance bamboo sway direction (host wind-state at the SRP instance slot CB2[inst+13]; no URP binding —
//   engine-side gap, see header). Folded to its neutral identity (zero sway -> zero delta).
static const float2 HG_BAMBOO_INSTANCE_SWAY = float2(0.0, 0.0);              // (CB2[inst+13].x, CB2[inst+13].y)

float3 LitMovingBambooDeltaWS(float3 positionWS, float3 positionOS)
{
    float3 instOrigin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23); // CB2[inst+3]
    float3 offWS  = positionWS - instOrigin;                                  // _102/_103/_104 (world-oriented offset)
    float3 worldP = positionWS;                                              // _112/_113/_114 (full world pos)

    // bend height profile: lerp(y, y³, _MovingBambooTrunkCurve), y = posOS.y*0.1 (b496:231-232).
    float hY = positionOS.y * 0.100000001490116119384765625;                 // _129
    float bendProfile = mad(_MovingBambooTrunkCurve, mad(hY * hY, hY, (-0.0) - hY), hY); // _138

    // bent world offset: add profile * intensity * instanceSway on X/Z (Y has NO sway term, b496:234-236).
    float3 bentOff = float3((worldP.x + (bendProfile * (_MovingBambooTrunkIntensity * HG_BAMBOO_INSTANCE_SWAY.x))) - instOrigin.x, // _154
                            (worldP.y + 0.0)                                                                       - instOrigin.y, // _155 (b496:235 +asfloat(0u))
                            (worldP.z + (bendProfile * (_MovingBambooTrunkIntensity * HG_BAMBOO_INSTANCE_SWAY.y))) - instOrigin.z); // _156
    float bentInv = rsqrt(max(dot(bentOff, bentOff), 1.1754943508222875079687365372222e-38)); // _162
    float origLen = sqrt(dot(offWS, offWS));                                  // _169 = |_102..|
    // delta = -worldP + (instOrigin + normalize(bentOff)*origLen)  (b496:240-242 ; length-preserved bend).
    float3 delta = float3(((-0.0) - worldP.x) + mad(bentInv * bentOff.x, origLen, instOrigin.x),   // _182
                          ((-0.0) - worldP.y) + mad(bentInv * bentOff.y, origLen, instOrigin.y),   // _183
                          ((-0.0) - worldP.z) + mad(bentInv * bentOff.z, origLen, instOrigin.z));  // _184

    float perDrawScale = 1.0 - unity_ObjectToWorld._m01;                      // _189 (b496:243)
    return delta * perDrawScale;
}
#endif

// ==============================================================================================
// _VAT_SOFTBODY / _VAT_RIGIDBODY / _UNLOAD_ROT_TEX — Houdini-VAT vertex-cache playback (vertex stage).
//
// GROUND TRUTH (the three isolated single-feature vertex blobs, all under .../materials/lit/liteffect/):
//   _VAT_SOFTBODY                 = Sub0_Pass0_Vertex_b266.hlsl  (liteffect.shader:376-378)
//   _VAT_RIGIDBODY                = Sub0_Pass0_Vertex_b288.hlsl  (liteffect.shader:409-411)
//   _VAT_SOFTBODY + _UNLOAD_ROT_TEX = Sub0_Pass0_Vertex_b308.hlsl (liteffect.shader:439-441)
//
// WHAT IT DOES (Houdini VAT = vertex-animation-texture playback): per frame, sample a baked POSITION
//   texture (xyz = per-vertex world-space offset for SOFTBODY / per-piece translation for RIGIDBODY) and
//   a ROTATION quaternion (full xyzw, or a 2-value compressed pair in POSITION.a under _UNLOAD_ROT_TEX),
//   then DISPLACE the vertex and REORIENT its normal/tangent by the quaternion. The frame index is derived
//   from a baked per-vertex id/lifetime in the extra UV channels (uv0.zw / uv1.x/.y/.w) + a playback clock.
//
// PORT DISCIPLINE: the offline-baked _PositionTexture/_RotationTexture, the per-vertex VAT UV stream, and
//   the bake bounds (_boundMin/Max*, _frameCount) are DATA the VFX/material/Houdini-bake system supplies —
//   exactly like _USE_VERTOFFSET's _OffsetTex. The SHADER MATH (sampling, LDR<->HDR remap, quaternion->basis
//   rotation, displacement) is fully expressible and is ported 1:1 here. Two per-draw VFX values have no URP
//   global, folded to their no-VFX-graph identity (the SAME fold the emissive/parallax modules use,
//   HGRP_LitEffect_Fix.shader:718-722): HG VFX clock `_VFXParams0.w` -> URP `_Time.y` (continuous seconds);
//   per-draw frame override `_unity_Float4x5_Param3.x` -> 0 (no override).
//
// INFRA SUBSTITUTIONS (STYLE_BIBLE §2): GPU-skinned base pos/normal/tangent (b266:518-529) -> URP plain
//   IN.positionOS / IN.normalOS / IN.tangentOS (skinning dropped, CORE_MATH §3.2); manual
//   mul(unity_ObjectToWorld,.) (b266:592-619) -> TransformObjectToWorld; manual per-column inverse-transpose
//   `* 1/dot(M_col,M_col)` for the rotated normal (b266:611-613) -> TransformObjectToWorldNormal (the exact
//   inverse-transpose URP supplies); camera-relative `- _WorldSpaceCameraPos_Internal` (b266:592-594) is the
//   HG camera-relative-world convention, absent in URP absolute-world -> dropped (TransformObjectToWorld is
//   already absolute world). NORMAL-octahedral decode + dual-frame MV output (b266:241-312,620-657) dropped.
//
// ALIAS DECODE (the scrambled cbuffer is NOT in declaration order; pinned by formula role + the clean
//   property enum liteffect.shader:147-166, the SAME GAP-A recovery this file uses for _USE_VERTOFFSET):
//   _DissolveUVRotate_at_448 == _BlendMeshNormalAndTangent (liteffect.shader:157 "使用Mesh的Normal和Tangent";
//     b266:589-591,611-613,638 lerp(VAT-rotated, mesh-skinned, t) — t in {0,1}); _AlphaMaskChannel ==
//     _B_surfaceNormals (liteffect.shader:160; b266:584 mask = (!=0)?~0:0 zeroes the rotated tangent when off).
//
// TEXTURE ROLE: the decompiler's sampler ALIAS names are swapped vs the logical Houdini role; the binding is
//   resolved by WRAP MODE, which is consistent across blobs: the CLAMP-sampled texture carries POSITION
//   (b308's lone position tex uses sampler_LinearClamp_PositionTexture; b266's position-feeding T1 is also
//   clamp), the REPEAT-sampled texture carries the ROTATION quaternion (b266 T2). So _PositionTexture = clamp
//   (xyz position[+ .a compressed-rot under _UNLOAD_ROT_TEX]), _RotationTexture = repeat (xyzw quaternion).
// ==============================================================================================

// Frame index + VAT (u,v) texel address. 1:1 source = b266:546-552 (softbody) / b308:544-549 (unload — same
//   formula). `age` = per-vertex lifetime gate; `frameRaw` = the 1-indexed frame BEFORE the -1 (b288 reuses it
//   for its first-frame gate); the V-row internally uses (frameRaw-1)/N sign-preserving frac.
//   autoPlayback: frame = floor(frac((t - t0) * fps/(N-0.01)) * speed) * N + 1 ; manual: floor(displayFrame).
//   The boundMin/Max sub-texel corrections (b266:549,552) align the sample to the baked atlas rows/cols.
void LitEffectVATFrameUV(Attributes IN, out float2 vatUV, out float age, out float frameRaw)
{
    bool inParticle = (_HoudiniVATInParticle != 0.0);                          // b266:546 (_636)
    age = inParticle ? IN.uv0.w : IN.uv1.y;                                    // b266:548 (_648) lifetime
    // U: baked column id * (1 - frac(10*boundMinZ)) sub-texel correction (b266:549 _668).
    float uId  = inParticle ? IN.uv0.z : IN.uv1.x;                            // b266:549
    float uCorr = mad(_boundMinZ, 10.0, -ceil(10.0 * _boundMinZ)) + 1.0;       // b266:549 = 1 - frac(10*minZ)
    vatUV.x = uId * uCorr;

    // RAW frame index (b266:550 _734 inner / b288:557 _727). HG VFX clock _VFXParams0.w -> _Time.y ;
    //   per-draw override Param3.x -> 0. autoPlayback: floor(frac(normalizedTime)*speed)*N + 1 ; manual: displayFrame.
    float autoFrame   = floor(frac((_Time.y - _gameTimeAtFirstFrame) * (_houdiniFPS / (_frameCount - 0.00999999977648258209228515625)))
                              * _playbackSpeed) * _frameCount + 1.0;           // b266:550 / b288:557 auto branch
    float manualFrame = floor((inParticle ? IN.uv1.w : 0.0) + (0.0 + _displayFrame)); // manual branch (Param3.x=0)
    frameRaw = (_B_autoPlayback != 0.0) ? autoFrame : manualFrame;             // b288:557 (_727, BEFORE the -1)

    // V row: uses the (raw-1)/N normalized frame, sign-preserving frac (b266:550-552 _734/_751).
    float frameN = (frameRaw - 1.0) / _frameCount;                             // b266:550 (-1)/N
    float frameFrac = (frameN >= -frameN) ? frac(abs(frameN)) : -frac(abs(frameN)); // b266:551-552 sign*frac(|.|)
    float vCorr = -(floor(-10.0 * _boundMaxX) + mad(_boundMaxX, 10.0, 1.0));    // b266:552 = frac(10*maxX) - 1
    vatUV.y = mad(vCorr, frameFrac + (1.0 - age), 1.0);                        // b266:552
}

// Decode the baked POSITION-texture xyz into an object-space offset. HDR(_TextureFormat!=0): raw texel;
//   LDR: remap [0,1] -> [boundMin, boundMax] per axis. 1:1 source = b266:558-563 (softbody) / b308:555-560.
float3 LitEffectVATPosDecode(float4 posTex, bool hdr)
{
    float3 lo = float3(_boundMinX, _boundMinY, _boundMinZ);
    float3 hi = float3(_boundMaxX, _boundMaxY, _boundMaxZ);
    return hdr ? posTex.xyz : (posTex.xyz * (hi - lo) + lo);                    // b266:558,560,562
}

// Rotate object-space vector v by quaternion q (x,y,z,w). Standard Hamilton rotation
//   v' = v + 2*q.w*(q.xyz x v) + 2*(q.xyz x (q.xyz x v)). The source builds this as an explicit mad-chain
//   per canonical axis (b266:577-582 for the normal's -X image, b266:604-609 for the tangent's +Y image);
//   this general form reproduces those EXACTLY (verified: rotate(q,+Y) == b266 _1029/_1030/_1031 standard
//   column1; rotate(q,-X) == b266 _866/_867/_868). Kept as one helper, applied to the two canonical axes.
float3 LitEffectVATQuatRotate(float4 q, float3 v)
{
    float3 t = 2.0 * cross(q.xyz, v);
    return v + q.w * t + cross(q.xyz, t);
}

// Full VAT vertex op. Returns the displaced WORLD position; writes the reoriented WORLD normal/tangent.
//   baseNormalWS/baseTangentWS = the un-VAT world basis (used only as the _BlendMeshNormalAndTangent target).
float3 LitEffectApplyVAT(Attributes IN, float3 baseNormalWS, float3 baseTangentWS,
                         out float3 outNormalWS, out float3 outTangentWS)
{
#if defined(LITEFFECT_VAT_PORTED)
    bool hdr = (_TextureFormat != 0.0);                                        // b266:547 (_637)
    float blendMesh   = _BlendMeshNormalAndTangent;                           // alias _DissolveUVRotate_at_448
    float surfaceMask = (_B_surfaceNormals != 0.0) ? 1.0 : 0.0;               // alias _AlphaMaskChannel (b266:584)

    float2 vatUV; float age; float frameRaw;
    LitEffectVATFrameUV(IN, vatUV, age, frameRaw);
    bool dead = (0.100000001490116119384765625 >= age);                       // b266:557 (_787) age<=0.1 -> cull to origin

    float3 basePosOS = IN.positionOS;        // skinned base pos -> plain OS (CORE_MATH §3.2)
    float3 baseNrmOS = IN.normalOS;
    float3 baseTanOS = IN.tangentOS.xyz;

#if defined(_VAT_RIGIDBODY)
    // ============================ RIGIDBODY (b288) ============================
    // Per-PIECE rigid transform: each fractured piece rotates about its baked pivot by a compressed quaternion
    //   (smallest-three octant encoding in posTex.w, quaternion xyz in rotTex), scales by _globalPscaleMul, then translates by the baked
    //   position offset. _PositionTexture(T1).xyz = piece translation, _RotationTexture(T2) = quaternion source.
    float4 posTex = SAMPLE_TEXTURE2D_LOD(_PositionTexture, sampler_PositionTexture, vatUV, 0.0);    // b288:562 (T1)
    float4 rotTex = SAMPLE_TEXTURE2D_LOD(_RotationTexture, sampler_RotationTexture, vatUV, 0.0);    // b288:566 (T2)
    float3 posOffOS = LitEffectVATPosDecode(posTex, hdr);                                           // b288:633-635 (T1.xyz)

    // quaternion components from T2 (HDR raw, LDR 2*(t-0.5)); w-component reconstructed via sqrt (b288:573-579).
    float cz = hdr ? rotTex.z : (2.0 * (rotTex.z - 0.5));                                            // b288:573-574 (_822)
    float cx = hdr ? rotTex.x : (2.0 * (rotTex.x - 0.5));                                            // b288:575-576 (_824)
    float cy = hdr ? rotTex.y : (2.0 * (rotTex.y - 0.5));                                            // b288:577-578 (_826)
    float cw = sqrt(max(1.0 - (cx * cx + cy * cy + cz * cz), 0.0));                                  // b288:579 (_833) reconstructed largest
    // smallest-three octant: posTex.w*4 selects which slot holds the reconstructed component (b288:584-626).
    //   Ground truth b288:584 reads the octant from _768.w = the CLAMP sample (sampler_LinearClamp_RotationTexture),
    //   which by the wrap-mode role resolution (header note) is the POSITION texture -> posTex.w, NOT rotTex.w.
    //   (The quaternion XYZ above come from T2/REPEAT=_RotationTexture; only the octant index lives in the position
    //   texture's alpha.) Reading rotTex.w here would pick the wrong octant -> wrong per-piece rigid orientation.
    float4 q;
    uint octant = uint(int(floor(posTex.w * 4.0)));                                                 // b288:584 (_768.w = clamp/position tex alpha)
    if (octant == 1u)       q = float4(cz, cw, cy, cx);                                              // b288:594-600
    else if (octant == 2u)  q = float4(cz, cx, -cw, -cy);                                            // b288:602-607
    else if (octant == 3u)  q = float4(-cw, cx, cy, -cz);                                            // b288:610-615
    else                    q = float4(cz, cx, cy, cw);                                              // b288:586-592 / default (octant 0)

    // piece-local vertex = base position relative to the baked pivot (b288:627-629). The pivot's y/z source
    //   channel depends on _HoudiniVATInParticle: in-particle uses TEXCOORD2.z/.w, else TEXCOORD3.x/.y (b288:628-629).
    //   The blob's per-axis pivot sign is NOT uniform (literal transcription b288:627-629): x is double-negated
    //   -> +pivotX (b288:627); y is SINGLE-negated -> -pivotY (b288:628 `((-0.0)-pivot)+base`); z is
    //   `-(((-0.0)-pivot)+1)` -> +(pivotZ-1) (b288:629). (Earlier note wrongly read all three as +pivot.)
    bool inParticleR = (_HoudiniVATInParticle != 0.0);                                               // b288:554 (_640)
    float pivotX = IN.vatPivot2.x;                                                                   // b288:627 (TEXCOORD_2.x)
    float pivotY = inParticleR ? IN.vatPivot2.z : IN.vatPivot3.x;                                    // b288:628 (TEXCOORD_2.z : TEXCOORD_3.x)
    float pivotZ = inParticleR ? IN.vatPivot2.w : IN.vatPivot3.y;                                    // b288:629 (TEXCOORD_2.w : TEXCOORD_3.y)
    float3 localV = float3(basePosOS.x + pivotX,                                                     // b288:627 (_1172) +pivotX
                           basePosOS.y - pivotY,                                                     // b288:628 (_1173) -pivotY (single negate)
                           basePosOS.z + (pivotZ - 1.0));                                            // b288:629 (_1174) the (-(-(..)+1)) = +(pivot.z-1)
    // displaced piece position = pscale * rotate(q, localV) + posOffset (b288:630-635).
    float3 rotLocal = LitEffectVATQuatRotate(q, localV);                                             // b288:630-632 rotate-about-pivot
    float3 dispPosOSraw = _globalPscaleMul * rotLocal + posOffOS;                                    // b288:633-635 (pscale, +posOffset)
    // first-frame gate: if NOT _B_animateFirstFrame and (raw frame == 1), keep the un-displaced base pos
    //   (b288:636-645). The test is on the RAW frame /N (b288:637 _1224 = _727/N, NOT (_727-1)/N).
    float ffN = frameRaw / _frameCount;                                                              // b288:637 (_1224)
    float ffFrac = (ffN >= -ffN) ? frac(abs(ffN)) : -frac(abs(ffN));                                 // b288:638 sign*frac(|.|)
    bool firstFrame = ((_B_animateFirstFrame == 0.0) && (ffFrac * _frameCount == 1.0));              // b288:636,639 (_1235)
    float3 dispPosOS = dead ? float3(0.0, 0.0, 0.0) : (firstFrame ? basePosOS : dispPosOSraw);       // b288:640-646

    // rigid normal/tangent: BOTH the skinned normal AND the skinned tangent are rotated by q, then blended
    //   toward the mesh basis by _BlendMeshNormalAndTangent. The rotated NORMAL (b288:674-683, normalOS) is
    //   NOT surface-masked; the rotated TANGENT (b288:648-661, tangentOS) IS surface-masked (b288:655-657 mask).
    float3 rotN = LitEffectVATQuatRotate(q, baseNrmOS);                                              // b288:674-679 rotate(q, normalOS)
    float3 nrmBlendOS = lerp(rotN, baseNrmOS, blendMesh);                                            // b288:681-683 lerp(rot,+mesh)
    float3 rotT = normalize(LitEffectVATQuatRotate(q, baseTanOS)) * surfaceMask;                     // b288:648-657 rotate(q, tangentOS), masked
    float3 tanBlendOS = lerp(rotT, baseTanOS, blendMesh);                                            // b288:659-661 lerp(rot,+mesh)
#elif defined(_UNLOAD_ROT_TEX)
    // -------- compressed-rotation path (b308): ONE texture (_PositionTexture) carries xyz=pos, .a=2-value quat.
    float4 posTex = SAMPLE_TEXTURE2D_LOD(_PositionTexture, sampler_PositionTexture, vatUV, 0.0);  // b308:549
    float3 posOffOS = LitEffectVATPosDecode(posTex, hdr);                                          // b308:555-560
    // decode quaternion from the packed alpha (b308:561-565): two 7-bit-ish components in [-2,2], w via sqrt.
    float packed = floor(posTex.w * 32.0);                                                         // b308:561 (_814)
    float qx = mad(packed, 0.12698413431644439697265625, -2.0);                                    // b308:562 (_817) = packed/7.875 - 2
    float qz = mad(mad(-packed, 32.0, posTex.w * 1024.0), 0.12698413431644439697265625, -2.0);     // b308:563 (_820)
    float negSumSq = -dot(float2(qx, qz), float2(qx, qz));                                          // b308:564 (_824)
    float qScale = sqrt(mad(negSumSq, 0.25, 1.0));                                                  // b308:565 (_829) = sqrt(1 - (qx^2+qz^2)/4)
    // reconstructed unit quat (x,y,z,w) (b308:581-583 build the rotated +Y normal image directly):
    float4 q = float4(clamp(-(qx * qScale), -1.0, 1.0),                                             // b308:581 (_945)
                      clamp(mad(negSumSq, 0.5, 1.0), -1.0, 1.0),                                     // b308:582 (_946) = 1 - (qx^2+qz^2)/2
                      clamp(qz * qScale, -1.0, 1.0), 0.0);                                           // b308:583 (_947)
    // In the unload path (_945/_946/_947) IS rotate(unitQuat,+Y); normalized (b308:584 _951 rsqrt) before the
    //   mesh blend. The rotated tangent rides _BlendMeshNormalAndTangent only (b308:566-568,585-587).
    float3 rotNrmOS = normalize(float3(q.x, q.y, q.z));                                             // b308:581-584 (+Y image, normalized)
    float3 rotTanOS = baseTanOS;                                                                    // b308:566-568: tangent = mesh tangent * blend
    rotTanOS *= blendMesh;                                                                          // b308:566-568 (_836/_837/_838)
    float3 nrmBlendOS = lerp(rotNrmOS, baseNrmOS, blendMesh);                                       // b308:585-587 lerp toward mesh normal
    float3 tanBlendOS = rotTanOS;
    float3 dispPosOS = dead ? float3(0.0, 0.0, 0.0) : (basePosOS + posOffOS);                       // b308:554-560 base + offset, age-culled
#else
    // -------- full path (b266 softbody): position tex (clamp) + rotation quaternion tex (repeat, full xyzw).
    float4 posTex = SAMPLE_TEXTURE2D_LOD(_PositionTexture, sampler_PositionTexture, vatUV, 0.0);    // b266:553 (T1, position)
    float4 rotTex = SAMPLE_TEXTURE2D_LOD(_RotationTexture, sampler_RotationTexture, vatUV, 0.0);    // b266:564 (T2, quaternion)
    float3 posOffOS = LitEffectVATPosDecode(posTex, hdr);                                           // b266:558-563
    // quaternion: HDR raw, LDR 2*(t-0.5) per component (b266:573-576).
    float4 q = hdr ? rotTex : (2.0 * (rotTex - 0.5));                                               // b266:569-576 (_838/_840/_842/_844)
    // rotated basis: normal = normalize(rotate(q,+Y)) (b266:604-610 _1029-1031 then _1035 rsqrt), tangent =
    //   normalize(rotate(q,-X)) (b266:577-583 _866-868 then _872 rsqrt). Both normalized (the LDR-decoded quat is
    //   only near-unit). Surface-normal mask zeroes the rotated tangent when off (b266:584-587).
    float3 rotNrmOS = normalize(LitEffectVATQuatRotate(q, float3(0.0, 1.0, 0.0)));                  // b266:604-610 (+Y image -> normal)
    float3 rotTanOS = normalize(LitEffectVATQuatRotate(q, float3(-1.0, 0.0, 0.0))) * surfaceMask;   // b266:577-583 (-X image -> tangent), masked
    float3 nrmBlendOS = lerp(rotNrmOS, baseNrmOS, blendMesh);                                       // b266:611-613 lerp(rot,+mesh)
    float3 tanBlendOS = lerp(rotTanOS, baseTanOS, blendMesh);                                       // b266:589-591 lerp(rot,+mesh)
    float3 dispPosOS = dead ? float3(0.0, 0.0, 0.0) : (basePosOS + posOffOS);                       // b266:558-563 (_807/_809/_811) base + offset, age-culled
#endif

    // -> world. position: TransformObjectToWorld (b266:592-594, camera-relative term dropped).
    float3 dispPosWS = TransformObjectToWorld(dispPosOS);                                           // b266:592-594
    // normal via inverse-transpose (b266:611-619 per-column 1/dot == URP TransformObjectToWorldNormal, which
    //   does mul(n,(float3x3)WorldToObject) — the exact inverse-transpose), tangent via forward transform
    //   (b266:617-619 mul(ObjectToWorld,.)). Both normalized (b266:630-637 rsqrt with FLT_MIN guard ~ SafeNormalize).
    float3 nWS = TransformObjectToWorldNormal(nrmBlendOS, true);                                    // b266:611-616,631-633
    float3 tWS = SafeNormalize(TransformObjectToWorldDir(tanBlendOS, false));                       // b266:617-619,635-637

    outNormalWS  = (blendMesh >= 1.0) ? baseNormalWS  : nWS;   // when fully blending to mesh, keep base WS basis
    outTangentWS = (blendMesh >= 1.0) ? baseTangentWS : tWS;
    return dispPosWS;
#else
    outNormalWS  = baseNormalWS;
    outTangentWS = baseTangentWS;
    return TransformObjectToWorld(IN.positionOS);
#endif
}

// ==============================================================================================
// CommonVAT — "common VAT bone playback" (lit-unique; +_COMMONVAT_BONE_1/_3/_4). VERTEX feature.
//   GROUND TRUTH (1:1): the ISOLATED single-keyword vertex blobs
//   lit/Sub0_Pass0_Vertex_b600.hlsl (_COMMONVAT_BONE_1) / b602.hlsl (_COMMONVAT_BONE_3) /
//   b604.hlsl (_COMMONVAT_BONE_4), all under // Keywords: HG_ENABLE_MV SRP_INSTANCING_ON _TWO_BASEMAP.
//   The three keywords differ in the BONE COUNT N (1/3/4) of a per-vertex LINEAR-BLEND-SKIN over N bone
//   matrices — that is a MATERIAL-feature delta, NOT just the (dropped) engine GPU-skinning bone-loop:
//   b602/b604 sample N bone columns (uv2.xyzw*127) and blend by N weights (uv3.xyzw), verified by diffing
//   the VAT region of b600/b602/b604. So the keyword-gated path below builds the matrix as the N-bone sum.
//
// WHAT IT DOES: per animation frame, sample _CommonVATMap to fetch a per-bone 3x4 AFFINE transform
//   (3 texel rows = the 3 matrix rows; the 4th column is the row's .w = translation) at a baked bone
//   column index, weight every element by a per-vertex bone weight, then transform the OBJECT-space
//   position / normal / tangent by that VAT matrix and emit the standard object->world. This is GPU
//   "vertex-animation-texture" SKELETAL playback (vs Houdini-VAT's per-point/per-piece cache).
//
// INFRA SUBSTITUTIONS (STYLE_BIBLE §2 / CORE_MATH §0.1/§3.1/§3.2 — IDENTICAL to LitEffectApplyVAT):
//   * GPU-skinned base pos/normal/tangent (b600:298-433, the T0 bone-matrix ByteAddressBuffer fan-out
//     over BLENDINDICES/BLENDWEIGHTS) -> URP plain IN.positionOS / IN.normalOS / IN.tangentOS.xyz
//     (engine vertex skinning dropped; it is URP UNITY_SKINNED_VERTEX infra, not a material feature).
//   * octahedral NORMAL/TANGENT unpack (b600:225-294) dropped -> URP feeds normalOS/tangentOS plain.
//   * manual per-column inverse-transpose `M·n * 1/dot(O2Wcol_i,O2Wcol_i)` then mul(CB1 O2W rows)
//     (b600:482-489,511-513) -> TransformObjectToWorldNormal (the exact inverse-transpose URP supplies);
//     forward tangent basis mul(O2W) (b600:499-501) -> TransformObjectToWorldDir; clip via the HG
//     per-draw instancing CB (b600:511-535) -> TransformObjectToWorld (absolute world).
//   * dual-frame MOTION-VECTOR output stack (b600:459-468 second VAT sample at the previous-frame V
//     `_622`, + b600:520-534 previous-world-pos TEXCOORD_6) DROPPED -> the merged Varyings has no MV
//     interpolators (URP MotionVectors pass owns them); SAME prev-frame drop as Houdini-VAT.
//   * HG per-draw playback clock `unity_MotionVectorsParamsInternal.w` (b600:436) -> URP `_Time.y`
//     (continuous seconds — the SAME HG-time substitution Houdini-VAT/_USE_VERTOFFSET use).
//   * per-instance manual-frame offset `CB1_m0[inst+14].x` (b600:438) -> 0 (no per-instance override;
//     the SAME fold Houdini-VAT applies to its per-draw frame override Param3.x).
//
// CONSUMPTION: REPLACES the vertex (like LitEffectApplyVAT) — returns the new WORLD position and writes
//   the VAT-reoriented WORLD normal/tangent (wired in LitFillCameraVaryings + LitShadowVertex, off-path
//   the whole block compiles out and the GetVertexPositionInputs basis stands; no base/sibling regress).
// 1:1, source = lit/Sub0_Pass0_Vertex_b600.hlsl:435-513.
// ==============================================================================================
#if defined(_COMMONVAT_BONE_1) || defined(_COMMONVAT_BONE_3) || defined(_COMMONVAT_BONE_4)
float3 LitCommonVATApply(Attributes IN, float3 baseNormalWS, float3 baseTangentWS,
                         out float3 outNormalWS, out float3 outTangentWS)
{
    // ---- playback frame -> V row (b600:435-442). _CommonVATMapParams.x = matrix-column count (texel
    //      width 1/x, 3 columns per bone); _CommonVATMapParams.y = frame count N.
    bool  autoPlay  = (0.5 < _CommonVATAutoPlay);                                          // b600:435 (_478)
    float autoNorm  = (_Time.y * _CommonVATFPS) / _CommonVATMapParams.y;                   // b600:436 (_492) HG clock -> _Time.y
    float autoFrac  = frac(abs(autoNorm));                                                 // b600:437 (_496)
    float autoFrame = ((autoNorm >= -autoNorm) ? autoFrac : -autoFrac) * _CommonVATMapParams.y; // b600:436-442 sign*frac(|.|)*N
    float manNorm   = (_CommonVATCurrentFrame + 0.0) / _CommonVATMapParams.y;              // b600:438 (_511) per-inst offset -> 0
    float manFrac   = frac(abs(manNorm));                                                  // b600:439 (_515)
    float manFrame  = ((manNorm >= -manNorm) ? manFrac : -manFrac) * _CommonVATMapParams.y; // b600:440 (_522)
    float frame     = autoPlay ? autoFrame : manFrame;                                     // b600:442 select
    float vRow      = (-((frame + 0.5) / _CommonVATMapParams.y)) + 1.0;                     // b600:442 (_537) = 1 - (frame+0.5)/N

    // ---- per-bone row U coords + the LINEAR-BLEND-SKIN matrix accumulation (b600:443-458 / b602:443-472
    //      / b604:443-479). The VAT matrix is a per-vertex weighted SUM of N bone matrices (N = the
    //      keyword's bone count): each bone i contributes its 3x4 sample (3 texel columns = the 3 matrix
    //      rows) at baked bone index uv2[i]*127, weighted by uv3[i]. (CRITICAL: BONE_3/_4 are NOT just
    //      BONE_1 + a dropped engine bone-loop — the matrix-playback math itself blends N bones; verified
    //      by diffing b602/b604:VAT-region against b600. A single-bone path silently drops bones 2..N.)
    //      `_CommonVATMapParams.x` = matrix-column count (texel width 1/x, 3 columns per bone). Per-bone
    //      column index for matrix-row k(=0,1,2) = (boneIdx_i*3 + 0.5 + k) * colW.
    float colW = 1.0 / _CommonVATMapParams.x;                                               // b600:441 (_530)
    float4 r0, r1, r2;
    #define LIT_CVAT_SAMPLE_BONE(bidx) \
        float bi##bidx = mad(IN.uv2[bidx], 127.0, -0.100000001490116119384765625);           \
        float4 s0_##bidx = SAMPLE_TEXTURE2D_LOD(_CommonVATMap, sampler_CommonVATMap, float2(colW * mad(bi##bidx, 3.0, 0.5), vRow), 0.0); \
        float4 s1_##bidx = SAMPLE_TEXTURE2D_LOD(_CommonVATMap, sampler_CommonVATMap, float2(colW * mad(bi##bidx, 3.0, 1.5), vRow), 0.0); \
        float4 s2_##bidx = SAMPLE_TEXTURE2D_LOD(_CommonVATMap, sampler_CommonVATMap, float2(colW * mad(bi##bidx, 3.0, 2.5), vRow), 0.0)
#if defined(_COMMONVAT_BONE_4)
    // 4-bone blend (b604:443-479): r_k = b0*uv3.x + b1*uv3.y + b2*uv3.z + b3*uv3.w (mad-nest order b604:463).
    LIT_CVAT_SAMPLE_BONE(0); LIT_CVAT_SAMPLE_BONE(1); LIT_CVAT_SAMPLE_BONE(2); LIT_CVAT_SAMPLE_BONE(3);
    r0 = mad(s0_3, IN.uv3.w, mad(s0_2, IN.uv3.z, mad(s0_0, IN.uv3.x, s0_1 * IN.uv3.y)));      // b604:463-465 row0
    r1 = mad(s1_3, IN.uv3.w, mad(s1_2, IN.uv3.z, mad(s1_0, IN.uv3.x, s1_1 * IN.uv3.y)));      // b604:470-472 row1
    r2 = mad(s2_3, IN.uv3.w, mad(s2_2, IN.uv3.z, mad(s2_0, IN.uv3.x, s2_1 * IN.uv3.y)));      // b604:477-479 row2
#elif defined(_COMMONVAT_BONE_3)
    // 3-bone blend (b602:443-472): r_k = b0*uv3.x + b1*uv3.y + b2*uv3.z (mad-nest order b602:458).
    LIT_CVAT_SAMPLE_BONE(0); LIT_CVAT_SAMPLE_BONE(1); LIT_CVAT_SAMPLE_BONE(2);
    r0 = mad(s0_2, IN.uv3.z, mad(s0_0, IN.uv3.x, s0_1 * IN.uv3.y));                           // b602:458-460 row0
    r1 = mad(s1_2, IN.uv3.z, mad(s1_0, IN.uv3.x, s1_1 * IN.uv3.y));                           // b602:464-466 row1
    r2 = mad(s2_2, IN.uv3.z, mad(s2_0, IN.uv3.x, s2_1 * IN.uv3.y));                           // b602:470-472 row2
#else // _COMMONVAT_BONE_1
    // 1-bone (b600:443-458): r_k = b0 * uv3.x. Single sample weighted by the lone bone weight.
    LIT_CVAT_SAMPLE_BONE(0);
    r0 = s0_0 * IN.uv3.x;                                                                     // b600:447-450 (_554*w)
    r1 = s1_0 * IN.uv3.x;                                                                     // b600:451-454 (_566*w)
    r2 = s2_0 * IN.uv3.x;                                                                     // b600:455-458 (_578*w)
#endif
    #undef LIT_CVAT_SAMPLE_BONE

    // ---- OS base (skinning dropped): plain mesh OS position/normal/tangent.
    float3 posOS = IN.positionOS;                                                           // b600:416-418 skinned pos -> plain OS
    float3 nrmOS = IN.normalOS;                                                             // b600:413-415 skinned nrm -> plain OS
    float3 tanOS = IN.tangentOS.xyz;                                                        // b600:419-421 skinned tan -> plain OS

    // ---- apply VAT matrix to NORMAL (b600:478-484). The matrix is ROW-major: r0/r1/r2 are its three
    //      rows, so M·n = (dot(r0.xyz,n), dot(r1.xyz,n), dot(r2.xyz,n)) (b600:478-480 dot row_i with
    //      normalOS). VAT-linear normal = normalize(M3x3 · n), blended toward the un-VAT normal by
    //      _AnimateVertexHasPivot (pivot=1 keeps mesh normal, pivot=0 full VAT).
    float nx = dot(r0.xyz, nrmOS);                                                          // b600:478 (_732)
    float ny = dot(r1.xyz, nrmOS);                                                          // b600:479 (_735)
    float nz = dot(r2.xyz, nrmOS);                                                          // b600:480 (_738)
    float nInv = rsqrt(dot(float3(nx, ny, nz), float3(nx, ny, nz)));                        // b600:481 (_744)
    float3 nrmVatOS = float3(mad(_AnimateVertexHasPivot, mad(-nx, nInv, nrmOS.x), nInv * nx),   // b600:482 (_760)
                             mad(_AnimateVertexHasPivot, mad(-ny, nInv, nrmOS.y), nInv * ny),   // b600:483 (_761)
                             mad(_AnimateVertexHasPivot, mad(-nz, nInv, nrmOS.z), nInv * nz));   // b600:484 (_762)
    //      (b600:482-484 fold the `* 1/dot(O2Wcol,O2Wcol)` per-column term — supplied here by
    //       TransformObjectToWorldNormal's inverse-transpose, exactly as Houdini-VAT folds b266:611-613.)

    // ---- apply VAT matrix to TANGENT (b600:490-496): normalize(M3x3 · t) = normalize((dot(r0.xyz,t), …)).
    float tx = dot(r0.xyz, tanOS);                                                          // b600:490 (_789)
    float ty = dot(r1.xyz, tanOS);                                                          // b600:491 (_792)
    float tz = dot(r2.xyz, tanOS);                                                          // b600:492 (_795)
    float tInv = rsqrt(dot(float3(tx, ty, tz), float3(tx, ty, tz)));                        // b600:493 (_801)
    float3 tanVatOS = float3(tx, ty, tz) * tInv;                                            // b600:494-496 (_802/_803/_804)

    // ---- apply the FULL 3x4 affine to POSITION (b600:502-504): each row's .w is its translation column,
    //      so M·(pos,1) = (dot(r0, (pos,1)), dot(r1, (pos,1)), dot(r2, (pos,1))).
    float px = dot(r0, float4(posOS, 1.0));                                                 // b600:502 (_831)
    float py = dot(r1, float4(posOS, 1.0));                                                 // b600:503 (_834)
    float pz = dot(r2, float4(posOS, 1.0));                                                 // b600:504 (_837)
    float3 posVatOS = float3(px, py, pz);

    // ---- object -> world (b600:511-535 HG instancing CB -> URP infra). Position absolute world,
    //      normal inverse-transpose, tangent forward; normalize the basis (b600:523-530 rsqrt guards).
    outNormalWS  = TransformObjectToWorldNormal(nrmVatOS, true);                            // b600:523-526 + the folded inv-transpose
    outTangentWS = SafeNormalize(TransformObjectToWorldDir(tanVatOS, false));               // b600:527-530
    return TransformObjectToWorld(posVatOS);                                                // b600:511-535
}
#endif

// ----------------------------------------------------------------------------------------------
// <<MODULE: MotionVectors_DepthClamp_Dither>> — vertex half (depth-clamp).
// Feature keyword: _ENABLE_VERT_DEPTH_CLAMP ("支持mobile超远距离投影 / EnableVertDepthClamp", lit.shader:384).
//
// 1:1 GROUND-TRUTH FINDING (lit.shader blob ladder): the keyword compiles into EXACTLY four variants,
//   all in the ShadowCaster pass (positive guards lit.shader:2300 / 2402 / 2512 / 2614), and EVERY one
//   is BYTE-IDENTICAL to its clamp-off sibling — verified by diffing the isolating pairs
//   lit/Sub0_Pass1_Vertex_b912.hlsl (clamp off) vs _b914.hlsl (clamp on) and _b980 vs _b982 (DITHER set):
//   the only delta is the `// Keywords:` header comment; the SPIR-V body is the same. The DepthOnly pass
//   (lit.shader:2717, the pass that also carries `ZClip On` at :2719) does NOT compile the keyword at all
//   (0 occurrences in its 2761-2964 vertex ladder). So in the HG source `_ENABLE_VERT_DEPTH_CLAMP` carries
//   NO isolatable per-vertex math delta and NO pass render-state delta — its real effect is host/CPU-side
//   (the C# shadow setup picks a far-plane-clamped projection so super-far casters render onto the far plane
//   instead of being far-clipped; the keyword exists only to pick the variant — the GPU code is identical).
//
// FAITHFUL URP REALIZATION: the GPU-visible meaning of "clamp depth so far-clipped verts land on the far
//   plane" is a reversed-Z-correct NDC-z clamp at the END of the depth/shadow vertex stage. Off-path
//   (keyword undefined) the whole thing compiles OUT — positionCS is returned untouched, so the base path
//   and every other module are bit-for-bit unchanged (matches the source, where on/off blobs are identical).
//   Under reversed-Z (URP always defines UNITY_REVERSED_Z) the far plane is the SMALLEST raw-z, so a vertex
//   pushed BEYOND far has z below UNITY_RAW_FAR_CLIP_VALUE*w; clamp lifts it back onto the far plane. We clamp
//   in homogeneous space (compare against the *w scale, no divide) so the post-rasterizer perspective divide
//   yields exactly UNITY_RAW_FAR_CLIP_VALUE — identical to URP's own far-plane handling. NOTE: this is a
//   VERTEX feature, so it is wired HERE (LitDepthVertex / the depth+shadow clip path) and NOT at the fragment
//   <<MODULE>> hook in the shader's HLSLINCLUDE (that hook sits PAST this include — a #ifdef there could not
//   see/affect positionCS; same discipline the GBuffer/MV fragment-hook headers call out).
// Source: lit.shader:384 (property) + :2300/:2402/:2512/:2614 (the only clamp variants, all ShadowCaster)
//         + lit/Sub0_Pass1_Vertex_b914.hlsl == _b912.hlsl (byte-identical clamp on/off proof).
// ----------------------------------------------------------------------------------------------
float4 LitApplyVertDepthClamp(float4 positionCS)
{
    // GROUND TRUTH (blob-verified): _ENABLE_VERT_DEPTH_CLAMP carries NO GPU delta. The clamp-ON shadow vertex
    //   blob (lit/Sub0_Pass1_Vertex_b914.hlsl) is BYTE-IDENTICAL to its clamp-OFF sibling b912 (and b982==b980)
    //   apart from the "// Keywords:" header — `grep -c 'min(|max(|clamp('` over b914 == 0, and gl_Position.z is
    //   a plain `mad(_ShadowpassVP[2].z, ...)` with no clamp. The keyword is a HOST-side variant selector
    //   (mobile super-far shadow projection: the CPU binds a far-plane-clamped _ShadowpassVP); the emitted GPU
    //   code is unchanged. The faithful 1:1 realization is therefore an IDENTITY no-op — injecting an active
    //   far-plane NDC clamp would add math present in NEITHER blob and break 1:1 (and on DepthOnly, where the
    //   keyword is not even compiled, it would corrupt camera depth for distant geometry). The function is kept
    //   (called from LitShadowVertex) only so the merged ShadowCaster variant SET matches the source 1:1.
    // Source: lit.shader:2272 (multi_compile_local, ShadowCaster pass ONLY; DepthOnly 2717-3172 has 0 refs)
    //         + lit/Sub0_Pass1_Vertex_b914.hlsl == _b912.hlsl & _b982.hlsl == _b980.hlsl (byte-identical proof).
    return positionCS;
}

// ----------------------------------------------------------------------------------------------
// Shared object->world->clip + TBN basis fill for the camera passes (ForwardLit / GBuffer / Depth /
// DepthNormals). 1:1 source = b8:461-520 (clip) + b8:473-485 (normal/tangent basis) + b8:501-532
// (interpolator pack), via the URP infra substitutes (STYLE_BIBLE §2 vertex table):
//   manual mul(unity_ObjectToWorld,posOS) then mul(VP,..)        -> GetVertexPositionInputs(.positionCS/.positionWS)
//   manual inverse-transpose normal / forward tangent basis      -> GetVertexNormalInputs(.normalWS/.tangentWS)
//   tangent.w handedness (b8:512 sign * TANGENT.w)               -> input.tangentOS.w * GetOddNegativeScale()
// ----------------------------------------------------------------------------------------------
Varyings LitFillCameraVaryings(Attributes IN)
{
    Varyings OUT = (Varyings)0;

    UNITY_SETUP_INSTANCE_ID(IN);
    UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
    UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);

    // object -> world -> clip (b8:461-520 ; gl_Position = VP * world, world = ObjectToWorld * posOS).
    VertexPositionInputs positionInputs = GetVertexPositionInputs(IN.positionOS);
    // normal via inverse-transpose, tangent via forward transform, both normalized (b8:473-485,504-511).
    VertexNormalInputs normalInputs = GetVertexNormalInputs(IN.normalOS, IN.tangentOS);

    float3 positionWS = positionInputs.positionWS;
    float4 positionCS = positionInputs.positionCS;

    // _USE_VERTOFFSET: texture-driven world-space displacement (b234:485-487). Added to the world position
    //   in the shared vertex blob, so it must perturb positionWS THEN re-derive clip pos (off-path: delta=0,
    //   identical to GetVertexPositionInputs). uv/color passthrough mirror the source (b234:511-518).
#ifdef _USE_VERTOFFSET
    float4 uvForOffset = LitPackUV(IN.uv0.xy, IN.uv1.xy);
    positionWS += LitEffectVertexOffsetDeltaWS(positionWS, normalInputs.normalWS, uvForOffset, IN.color);
    positionCS  = TransformWorldToHClip(positionWS);
#endif

    // _SIMPLE_VERTEXANIM (+_CLOTH/_ROPE/_PENDULUM): additive world-space wind displacement (b59/b590/b596).
    //   Perturb positionWS THEN re-derive clip (off-path delta=0). Same wiring as _USE_VERTOFFSET so the
    //   silhouette/shadow/depth all track the wind. HG wind-time -> _Time.y ; non-custom wind-dir is engine-side
    //   (custom-angle fallback). See LitEffectSimpleVertexAnimDeltaWS header.
#if defined(_SIMPLE_VERTEXANIM)
    positionWS += LitEffectSimpleVertexAnimDeltaWS(positionWS, IN.positionOS, IN.color, IN.uv0.xy);
    positionCS  = TransformWorldToHClip(positionWS);
#endif

    // _FOLIAGE_TRUNK: additive world-space trunk lean + branch flutter (b484:565-567). Perturb positionWS THEN
    //   re-derive clip (off-path delta=0). Same wiring as _USE_VERTOFFSET so the silhouette/shadow/depth track the
    //   wind. Wind-motor sway + global wind dir are the engine-side gap (custom-angle fallback). Pivot = uv1/uv2.
#if defined(_FOLIAGE_TRUNK)
    // pivot = (uv1.xy, uv2.xy) in the narrow layout. If VAT co-compiles (LITEFFECT_VAT_PORTED widens the struct and
    //   removes uv2), fall back to the wide uv1.xy / vatPivot2.xy so this still compiles (VAT replaces the vertex anyway).
    #ifdef LITEFFECT_VAT_PORTED
    positionWS += LitFoliageTrunkDeltaWS(positionWS, IN.positionOS, IN.color, IN.uv1.xy, IN.vatPivot2.xy);
    #else
    positionWS += LitFoliageTrunkDeltaWS(positionWS, IN.positionOS, IN.color, IN.uv1, IN.uv2);
    #endif
    positionCS  = TransformWorldToHClip(positionWS);
#endif

    // _MOVING_BAMBOO: additive world-space bamboo trunk sway (b496:240-242). Perturb positionWS THEN re-derive clip
    //   (off-path delta=0). Per-instance sway direction is the engine-side gap (neutral identity). Same wiring above.
#if defined(_MOVING_BAMBOO)
    positionWS += LitMovingBambooDeltaWS(positionWS, IN.positionOS);
    positionCS  = TransformWorldToHClip(positionWS);
#endif

    // _VAT_SOFTBODY / _VAT_RIGIDBODY / _UNLOAD_ROT_TEX — Houdini-VAT vertex-cache playback (b266/b288/b308).
    //   Samples _PositionTexture/_RotationTexture by baked frame index, displaces + reorients the vertex. The
    //   rotated normal/tangent are produced in OBJECT space and transformed to world, so they REPLACE the
    //   GetVertexNormalInputs basis (not compose). Off-path (no keyword / non-VAT shader) this whole block is
    //   compiled out and the standard basis above stands. Mirrors _USE_VERTOFFSET (perturbs world pos -> reclip).
    // tangent.w = TANGENT.w * odd-negative-scale sign (b8:512 / b184:478: sign(WorldTransformParams.w) * TANGENT.w).
    float tangentSignW = IN.tangentOS.w * GetOddNegativeScale();
#if defined(LITEFFECT_VAT_PORTED)
    {
        float3 vatN, vatT;
        positionWS = LitEffectApplyVAT(IN, normalInputs.normalWS, normalInputs.tangentWS, vatN, vatT);
        positionCS = TransformWorldToHClip(positionWS);
        normalInputs.normalWS  = vatN;
        normalInputs.tangentWS = vatT;
        // VAT tangent.w additionally rides _BlendMeshNormalAndTangent (b266:638 / b288:708 / b308:612 all spell
        //   sign * mad(blendMesh, tangentW - 0, 0) == sign * blendMesh * tangentW). The base (b184:478) does NOT.
        tangentSignW *= _BlendMeshNormalAndTangent;
    }
#endif

    // _COMMONVAT_BONE_1/_3/_4 — common VAT bone playback (b600). Sample _CommonVATMap for the per-bone 3x4
    //   matrix at the playback frame, transform OS pos/normal/tangent -> REPLACE positionWS + the TBN basis
    //   (NOT compose), re-derive clip. Mutually exclusive with Houdini-VAT (distinct keyword group -> narrow
    //   uv2/uv3 layout in effect, exactly what LitCommonVATApply reads). Off-path: compiled out, base stands.
    //   tangent.w stays the base sign (b600:531 is plain sign*TANGENT.w, NO _BlendMeshNormalAndTangent factor).
#if defined(_COMMONVAT_BONE_1) || defined(_COMMONVAT_BONE_3) || defined(_COMMONVAT_BONE_4)
    {
        float3 cvatN, cvatT;
        positionWS = LitCommonVATApply(IN, normalInputs.normalWS, normalInputs.tangentWS, cvatN, cvatT);
        positionCS = TransformWorldToHClip(positionWS);
        normalInputs.normalWS  = cvatN;
        normalInputs.tangentWS = cvatT;
    }
#endif

    OUT.positionCS = positionCS;
    OUT.positionWS = positionWS;
    OUT.normalWS   = normalInputs.normalWS;
    OUT.tangentWS  = float4(normalInputs.tangentWS, tangentSignW);

    // raw uv0 + raw uv1 (b8:521-524), with _UV_ANIMATION scroll applied to the OUTPUT interpolator
    //   (b614:564-567; off-path LitPackAnimatedUV == LitPackUV) ; vertex color rgba passthrough (b8:525-528).
    OUT.uv    = LitPackAnimatedUV(IN.uv0.xy, IN.uv1.xy);
    OUT.color = IN.color;

    // View vector (world), UNNORMALIZED — fragment normalizes & extracts eye-distance (CORE_MATH §2.2,
    // b9:196-211: perspective = camPos - P ; ortho = -camera-forward). URP GetWorldSpaceViewDir returns
    // (camPos - positionWS) and already resolves the ortho case, the faithful infra substitute.
    OUT.viewDirWS = GetWorldSpaceViewDir(positionWS);

    // Fog factor from clip-space Z (HG froxel fog -> URP MixFog ; CORE_MATH §2.10/§2.12 PORT).
    OUT.fogFactor = ComputeFogFactor(positionCS.z);

    return OUT;
}

// ============================================================================================
// LitVertex — ForwardLit / HGBuffer / ForwardReflection passes.
// 1:1 source: litforward/Sub0_Pass0_Vertex_b8.hlsl (forward base) == lit/Sub0_Pass0_Vertex_b280.hlsl
// (gbuffer base, same math; CORE_MATH §3 note). Object->world->clip + TBN, drop skin/oct/MV.
// ============================================================================================
Varyings LitVertex(Attributes IN)
{
    return LitFillCameraVaryings(IN);
}

// ============================================================================================
// LitShadowVertex — ShadowCaster pass.
// 1:1 source: litforward/Sub0_Pass2_Vertex_b32.hlsl. The blob clips through a dedicated shadow
// view-projection `_ShadowpassVP` (b32:325-328) with depth bias BAKED INTO that matrix CPU-side
// and NO per-vertex normal/slope bias in the base variant (CORE_MATH §4.1). URP's faithful infra
// substitute is ApplyShadowBias(posWS,nrmWS,lightDir) + TransformWorldToHClip + ApplyShadowClamping
// (the UNITY_REVERSED_Z near-plane clamp; STYLE_BIBLE §2 vertex table; this mirrors URP's own
// GetShadowPositionHClip in ShadowCasterPass.hlsl). _LightDirection / _LightPosition +
// _CASTING_PUNCTUAL_LIGHT_SHADOW are declared in the ShadowCaster HLSLPROGRAM.
// ============================================================================================
Varyings LitShadowVertex(Attributes IN)
{
    Varyings OUT = (Varyings)0;

    UNITY_SETUP_INSTANCE_ID(IN);
    UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
    UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);

    float3 positionWS = TransformObjectToWorld(IN.positionOS);   // b32:329-331 world pos (ObjectToWorld * posOS)
    float3 normalWS   = TransformObjectToWorldNormal(IN.normalOS);
    float3 tangentWS  = TransformObjectToWorldDir(IN.tangentOS.xyz);

    // _USE_VERTOFFSET: displace the world position BEFORE the shadow transform, so the cast shadow tracks the
    //   displaced surface (the source's shared vertex blob offsets worldPos for every pass, incl. ShadowCaster
    //   liteffect.shader:1388-1396 ladder; b234:485-487). Off-path: delta = 0, no change.
#ifdef _USE_VERTOFFSET
    positionWS += LitEffectVertexOffsetDeltaWS(positionWS, normalWS, LitPackUV(IN.uv0.xy, IN.uv1.xy), IN.color);
#endif

    // _SIMPLE_VERTEXANIM: displace the cast-shadow silhouette identically to the camera passes (the source's
    //   shared SVA vertex blob offsets worldPos for every pass incl. ShadowCaster). Off-path: delta = 0.
#if defined(_SIMPLE_VERTEXANIM)
    positionWS += LitEffectSimpleVertexAnimDeltaWS(positionWS, IN.positionOS, IN.color, IN.uv0.xy);
#endif

    // _FOLIAGE_TRUNK / _MOVING_BAMBOO: displace the cast-shadow silhouette identically to the camera passes (the
    //   source's shared trunk/bamboo vertex blob offsets worldPos for every pass incl. ShadowCaster). Off-path delta=0.
#if defined(_FOLIAGE_TRUNK)
    #ifdef LITEFFECT_VAT_PORTED
    positionWS += LitFoliageTrunkDeltaWS(positionWS, IN.positionOS, IN.color, IN.uv1.xy, IN.vatPivot2.xy);
    #else
    positionWS += LitFoliageTrunkDeltaWS(positionWS, IN.positionOS, IN.color, IN.uv1, IN.uv2);
    #endif
#endif
#if defined(_MOVING_BAMBOO)
    positionWS += LitMovingBambooDeltaWS(positionWS, IN.positionOS);
#endif

    // _VAT_SOFTBODY / _VAT_RIGIDBODY: displace + reorient the cast-shadow silhouette identically to the camera
    //   passes (the source's VAT vertex blob is SHARED across HGBuffer/Shadow/Depth ladders, so a VAT-animated
    //   vertex moves its shadow too). Off-path: compiled out, plain object->world stands.
    float tangentSignW = IN.tangentOS.w * GetOddNegativeScale();   // b184:478 base sign (no blendMesh)
#if defined(LITEFFECT_VAT_PORTED)
    {
        float3 vatN, vatT;
        positionWS = LitEffectApplyVAT(IN, normalWS, tangentWS, vatN, vatT);
        normalWS  = vatN;
        tangentWS = vatT;
        tangentSignW *= _BlendMeshNormalAndTangent;   // VAT tangent.w rides blendMesh (b266:638 / b288:708 / b308:612)
    }
#endif

    // _COMMONVAT_BONE_1/_3/_4: displace + reorient the cast-shadow silhouette identically to the camera passes
    //   (ShadowCaster carries the _COMMONVAT_BONE_* pragma; a VAT-animated vertex moves its shadow too). Off-path
    //   compiled out, plain object->world stands. tangent.w stays base sign (b600:531, no blendMesh factor).
#if defined(_COMMONVAT_BONE_1) || defined(_COMMONVAT_BONE_3) || defined(_COMMONVAT_BONE_4)
    {
        float3 cvatN, cvatT;
        positionWS = LitCommonVATApply(IN, normalWS, tangentWS, cvatN, cvatT);
        normalWS  = cvatN;
        tangentWS = cvatT;
    }
#endif

    #if _CASTING_PUNCTUAL_LIGHT_SHADOW
        float3 lightDirectionWS = normalize(_LightPosition - positionWS);
    #else
        float3 lightDirectionWS = _LightDirection;
    #endif

    // world -> shadow clip (b32:325-328 mul(_ShadowpassVP, worldPos)); URP folds bias into ApplyShadowBias,
    // and ApplyShadowClamping applies the UNITY_REVERSED_Z near-plane clamp (matches URP ShadowCasterPass).
    OUT.positionCS = ApplyShadowClamping(TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDirectionWS)));
    // <<MODULE: MotionVectors_DepthClamp_Dither>> — _ENABLE_VERT_DEPTH_CLAMP. ShadowCaster-only keyword
    //   (lit.shader:2272). Blob-verified IDENTITY (clamp-on blob b914 == clamp-off b912, byte-for-byte): the
    //   far-plane clamp is host-side (CPU binds a far-clamped _ShadowpassVP), NO per-vertex GPU delta. Call is a
    //   no-op (see LitApplyVertDepthClamp header) and exists only so the variant set matches the source 1:1.
    OUT.positionCS = LitApplyVertDepthClamp(OUT.positionCS);

    // carry surface attributes so the fragment alpha-clip path (_ALPHATEST_ON) has uv (b32:338-341).
    //   NO _UV_ANIMATION scroll on the cast shadow: the ShadowCaster pass does NOT define _UV_ANIMATION
    //   (ground truth lit.shader compiles the keyword ONLY in the HGBuffer/surface pass, lit.shader:497; its
    //   ShadowCaster ladder lit.shader:2255-2716 has ZERO _UV_ANIMATION branches), so the shadow alpha-clip
    //   samples UN-scrolled uv — matching the source, where a surface-uv scroll never moves the shadow.
    //   LitPackAnimatedUV is kept for uniformity but is INERT here (#ifdef _UV_ANIMATION is off in this pass);
    //   contrast _USE_VERTOFFSET, which the ShadowCaster DOES compile (it displaces the shadow silhouette).
    OUT.positionWS = positionWS;
    OUT.normalWS   = normalWS;
    OUT.tangentWS  = float4(tangentWS, tangentSignW);
    OUT.uv         = LitPackAnimatedUV(IN.uv0.xy, IN.uv1.xy);
    OUT.color      = IN.color;
    OUT.viewDirWS  = GetWorldSpaceViewDir(positionWS);
    OUT.fogFactor  = 0.0;

    return OUT;
}

// ============================================================================================
// LitDepthVertex — DepthOnly pass.
// 1:1 source: litforward/Sub0_Pass1_Vertex_b26.hlsl. Same object->world->CAMERA clip as the
// ForwardLit vertex (b26:305-331 uses unity_ObjectToWorld + camera VP, NOT shadow VP; CORE_MATH §4.3),
// so it routes through the shared camera fill (GetVertexPositionInputs). uv carried for the
// _ALPHATEST_ON clip; depth needs no normal/tangent but the fields are harmless and kept uniform.
// ============================================================================================
Varyings LitDepthVertex(Attributes IN)
{
    // NOTE: _ENABLE_VERT_DEPTH_CLAMP is NOT applied here. In the source (lit.shader) the keyword is declared
    //   ONLY on the ShadowCaster pass (multi_compile_local @2272); the DepthOnly pass (2717-3172) never compiles
    //   it. Wiring the clamp into camera-depth would corrupt the depth prepass for distant geometry — a path the
    //   source does not touch. The (identity, see header) clamp lives in LitShadowVertex instead.
    Varyings OUT = LitFillCameraVaryings(IN);
    return OUT;
}

// ============================================================================================
// LitDepthNormalsVertex — DepthNormalsOnly pass (URP SSAO / depth-normals prepass; STYLE_BIBLE §7).
// No HG blob analog (HG packed normals into its GBuffer); URP's prepass needs world position +
// full TBN so CoreSurface can rebuild the per-pixel normal. Same camera transform as LitVertex.
// ============================================================================================
Varyings LitDepthNormalsVertex(Attributes IN)
{
    return LitFillCameraVaryings(IN);
}

#endif // HGRP_LIT_CORE_VERTEX_INCLUDED
