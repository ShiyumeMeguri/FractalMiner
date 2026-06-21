#ifndef HGRP_LITEFFECTBLEND_MODULES_INCLUDED
#define HGRP_LITEFFECTBLEND_MODULES_INCLUDED

// =============================================================================
// LitEffectBlendModules.hlsl — the EMISSIVE + PARALLAX feature deltas of
// HGRP/LitEffectBlend, ported 1:1 from the decompiled HGBuffer/Erosion fragment.
//
// These three keywords are declared by the source HGBuffer pass's
// `#pragma multi_compile_local` (liteffectblend.shader L143-145):
//     _EMISSIVE_MAP   _PARALLAX_MAP   _PARALLAX_MAP_WORLDSPACE
// In the BASE variant (b7) emission is identically 0 (b7:122-124 SV_Target.xyz=0),
// which CoreSurface fills as s.emission = 0. Each feature below is an ADDITIVE
// contribution to the HG GBuffer emission target SV_Target.xyz, which URP
// CoreMath.hlsl consumes verbatim (`color += s.emission`, CoreMath L272; deferred
// `outGBuffer3 = s.emission + GI`, CoreMath L334). So every term here writes into
// s.emission — it never touches albedo / normal / roughness / the erosion alpha
// (the source confirms: b219 and b11 leave SV_Target_2/3/4 = the b7 base surface).
//
// GROUND TRUTH (clean-named ParamBlob = THIS shader's own blob):
//   Emissive : liteffectblend/Sub0_Pass0_Fragment_b11.hlsl  L200-205,355-357
//   Parallax : liteffectblend/Sub0_Pass0_Fragment_b11.hlsl  L527-674,803  (steep march + Fresnel + color + anim)
//              cross-checked against the ISOLATED parallax-only variant
//              liteffect/Sub0_Pass0_Fragment_b219.hlsl L508-798 (same march, scrambled names)
//   WorldParallax : liteffectblend/Sub0_Pass0_Fragment_b11.hlsl L821-1016,1142-1182,355-357
//
// HGRP->URP INFRA SUBSTITUTION (the ONLY non-material inputs; substituted, NOT transcribed):
//   _VFXParams0   (.xyz = SceneEffect/skill emitter WORLD position, .w = effect TIME/age) and
//   _VFXParams2   (.xyz = secondary emitter, .w = strength) are HG per-renderer "VFX SceneEffect"
//     globals, filled by the host C# HGVfxSceneEffect / character-skill system. They drive ONLY
//     the optional char-position BRIGHTNESS pulse (_ParallaxCharPos) and the world-pattern radial
//     falloff. There is no URP equivalent global => declared below defaulting NEUTRAL (emitter at
//     origin, strength 0), and the TIME channel _VFXParams0.w is mapped 1:1 to URP `_Time.y`.
//     With no skill driving them the terms collapse to the source's un-pulsed steady state.
//   _unity_Float4x5_Param0 (.x = SceneEffect "Dark" darken amount) and _unity_Float4x5_Param2
//     (.xyz = SceneEffect emissive tint, .w = tint weight) and _unity_Float4x5_Param4 (emissive
//     color OVERRIDE, .w = weight) are the HG SceneEffect ("_UseSceneEffect(Dark)", source L91)
//     per-renderer color-grade, host-C#-filled. No URP analog => declared NEUTRAL (darken 0, tint
//     identity, override weight 0); the emissive sample/route/remap math is otherwise 1:1.
//   post-exposure (_1118 b11:350) folds _ExposureParams.x (re-exposed as a material Vector in this
//     shader, CBUFFER `_ExposureParams`) gated by _IgnorePostExposure — ported as-is.
//
// SSA-decode reminders (same as the rest of _core): mad(a,b,c)=a*b+c ; ((-0.0f)-x)=-x ;
//   asfloat(<uint>) = a denormalized-float magic constant decoded inline ; asfloat(cond?~0u:0u)&x
//   = (cond ? x : 0). Branch boundaries / signs / clamp bounds are preserved EXACTLY.
// =============================================================================

// ---- INFRA: HG SceneEffect / VFX per-renderer globals (host-C#-filled; NEUTRAL here) --------
// Declared with a value so a normal material with no SceneEffect renders the source's steady state.
// (A host ScriptableRenderFeature that ports HGVfxSceneEffect would set these per-draw.)
#ifndef HGRP_LEB_VFX_GLOBALS
#define HGRP_LEB_VFX_GLOBALS
float4 _VFXParams0;              // .xyz emitter WS pos, .w effect time  (mapped to _Time.y when unset)
float4 _VFXParams2;              // .xyz secondary emitter pos, .w strength
float4 _unity_Float4x5_Param0;   // .x SceneEffect darken amount
float4 _unity_Float4x5_Param2;   // .xyz SceneEffect emissive tint, .w weight
float4 _unity_Float4x5_Param4;   // emissive color override, .w weight
#endif

// =============================================================================
// MODULE: Emissive  — _EMISSIVE_MAP.  1:1 source b11:200-205,355-357.
//
//   uv  : (uv0 + _EmissiveUVSet*(uv1-uv0))*_EmissiveMap_ST.xy + _EmissiveMap_ST.zw
//         + _EmissiveSpeed.xy * time                                       (b11:200)
//   tex : _375 = SAMPLE(_EmissiveMap, uv)                                  (b11:200)
//   route (b11:355 inner): per channel c:
//       base.c  = mad(_unity_Float4x5_Param2.w, _unity_Float4x5_Param2.c - _EmissiveColor.c, _EmissiveColor.c)
//                                                       (SceneEffect tint of _EmissiveColor; neutral w=0 -> _EmissiveColor.c)
//       single  = base.c * _375.x                                         (channel R, always)
//       quad    = (_EmissiveColorG.c*_375.y + _EmissiveColorB.c*_375.z + _EmissiveColorA.c*_375.w) * _EmissiveType
//       route.c = single + quad                          (_EmissiveType=0 -> single only; =1 -> +GBA)
//   albedoAffect (b11:355 last factor):
//       aff.c   = mad(_AlbedoAffectEmissive, mad(-albedoTinted.c, sceneTint.c, 1), albedoSceneCol.c)
//                 where sceneTint.c=_439.c (SceneEffect tint of albedo; neutral=1),
//                 albedoSceneCol.c=_442.c = albedoTinted.c*_439.c (neutral = albedoTinted.c).
//                 So neutral: aff.c = mad(_AlbedoAffectEmissive, 1-albedoTinted.c, albedoTinted.c)
//                                   = lerp(albedoTinted.c, 1, _AlbedoAffectEmissive).
//   exposure : _1118 = 1/mad(_ExposureParams.x,_IgnorePostExposure,1-_IgnorePostExposure)  (b11:350)
//   darken   : _1102 = 1 - _unity_Float4x5_Param0.x  (SceneEffect darken; neutral=1)        (b11:349)
//   Em.c     = _1118 * (_1102 * (route.c * aff.c)) * _EmissiveRemap        (b11:355 mad(B,_EmissiveRemap,C), B-term)
// albedoTinted = CoreSurface baseCol (= the tint-covered s.albedo).
// =============================================================================
float3 LebEmissive(float2 uv0, float2 uv1, float3 albedoTinted, float time)
{
#ifdef _EMISSIVE_MAP
    float duvX = uv1.x - uv0.x;                                            // b11:187 (_253)
    float duvY = uv1.y - uv0.y;                                           // b11:188 (_254)
    float2 emUV = float2(
        mad(_EmissiveSpeed.x, time, mad(mad(_EmissiveUVSet, duvX, uv0.x), _EmissiveMap_ST.x, _EmissiveMap_ST.z)),
        mad(_EmissiveSpeed.y, time, mad(mad(_EmissiveUVSet, duvY, uv0.y), _EmissiveMap_ST.y, _EmissiveMap_ST.w)));  // b11:200
    float4 em = SAMPLE_TEXTURE2D_BIAS(_EmissiveMap, sampler_EmissiveMap, emUV, 0.0);  // b11:200 (_375), URP auto-adds _GlobalMipBias.x

    // SceneEffect emissive-color override mask (b11:205-216). Neutral (override weight 0) -> sceneTint=1.
    float presence = (em.x >= 0.100000001490116119384765625) ? 1.0 : 0.0;            // b11:205 (_386)
    float ovrW     = presence * _unity_Float4x5_Param4.w;                            // b11:206 (_391)
    float ovrBase  = mad(-_unity_Float4x5_Param4.w, presence, 1.0);                  // b11:213 (_433)
    float3 sceneTint = float3(                                                       // b11:214-216 (_439..441)
        mad(_unity_Float4x5_Param4.x, ovrW, ovrBase),
        mad(_unity_Float4x5_Param4.y, ovrW, ovrBase),
        mad(_unity_Float4x5_Param4.z, ovrW, ovrBase));
    float3 albedoSceneCol = albedoTinted * sceneTint;                               // b11:217-219 (_442..444)

    // emissive color route: R channel always, GBA gated by _EmissiveType (b11:355 inner first mad-pair).
    float3 baseCol = float3(                                                         // SceneEffect tint of _EmissiveColor; neutral w=0 -> _EmissiveColor.rgb
        mad(_unity_Float4x5_Param2.w, _unity_Float4x5_Param2.x - _EmissiveColor.x, _EmissiveColor.x),
        mad(_unity_Float4x5_Param2.w, _unity_Float4x5_Param2.y - _EmissiveColor.y, _EmissiveColor.y),
        mad(_unity_Float4x5_Param2.w, _unity_Float4x5_Param2.z - _EmissiveColor.z, _EmissiveColor.z));
    float3 quad = float3(                                                            // b11:355 (_EmissiveColorG.x*_378 + _EmissiveColorB.x*_379 + _EmissiveColorA.x*_380)
        mad(_EmissiveColorA.x, em.w, mad(_EmissiveColorG.x, em.y, em.z * _EmissiveColorB.x)),
        mad(_EmissiveColorA.y, em.w, mad(_EmissiveColorG.y, em.y, em.z * _EmissiveColorB.y)),
        mad(_EmissiveColorA.z, em.w, mad(_EmissiveColorG.z, em.y, em.z * _EmissiveColorB.z)));
    float3 route = baseCol * em.x + quad * _EmissiveType;                            // b11:355 mad(baseCol, _377, quad*_EmissiveType)

    // albedo-affect: mad(_AlbedoAffectEmissive, mad(-albedoTinted, sceneTint, 1), albedoSceneCol)  (b11:355)
    float3 aff = float3(
        mad(_AlbedoAffectEmissive, mad(-albedoTinted.x, sceneTint.x, 1.0), albedoSceneCol.x),
        mad(_AlbedoAffectEmissive, mad(-albedoTinted.y, sceneTint.y, 1.0), albedoSceneCol.y),
        mad(_AlbedoAffectEmissive, mad(-albedoTinted.z, sceneTint.z, 1.0), albedoSceneCol.z));

    float postExp = 1.0 / mad(_ExposureParams.x, _IgnorePostExposure, 1.0 - _IgnorePostExposure);  // b11:350 (_1118)
    float darken  = 1.0 - _unity_Float4x5_Param0.x;                                                // b11:349 (_1102)
    return (postExp * (darken * (route * aff))) * _EmissiveRemap;                                  // b11:355 B-term * _EmissiveRemap
#else
    return float3(0.0, 0.0, 0.0);
#endif
}

// =============================================================================
// MODULE: Parallax (steep, non-worldspace)  — _PARALLAX_MAP.
// 1:1 source: liteffectblend b11:527-674,803 (clean names) == liteffect b219:508-798 (isolated).
//
// A self-contained EMISSIVE pattern: ray-marches a height/noise field along the tangent-space
// view ray, samples the parallax texture, applies a Fresnel falloff + animated breathing, lerps
// _ParallaxColor<->_ParallaxColorDark, and writes the result to the emission target (b219:346-348
// SV_Target.xyz = _579/581/583*_OffsetUVSet; in the isolated variant _OffsetUVSet aliases the
// global _ParallaxIntensity master). It does NOT modify the base surface.
//
// March (b11:527-627):
//   uvP   = (uv0 + _ParallaxMapUVType*(uv1-uv0))                           (b11:527-528)
//   V_ts  = the tangent-space view direction (camForward projected into TBN), built from the
//           world view dir camFwd and the per-vertex TBN (b11:497-515). offset/step:
//   numSteps = min(_ParallaxMarchNum, 20) ; invSteps = 1/numSteps         (b11:547-549)
//   bias  = mad(NoV_ts, rcpLen, 0.42)                                      (b11:550)  parallax-scale bias
//   denom = max(rcpLen*NoV_ts, 1e-3)                                       (b11:554)
//   dir.xy = ((rcpLen*T)/bias/denom) * (-_ParallaxStrength)                (b11:563-564)
//   step.xy = invSteps*dir.xy                                             (b11:565-566)
//   loop count numSteps+1; each step samples _ParallaxNoiseMap (T6) with SampleGrad and walks
//   until the stored height surpasses the marched height (b11:572-616), then a soft-intersection
//   parametric blend _627 (b11:627). Finally samples _ParallaxMap (T3) at the parallax-corrected
//   uv*_ParallaxTilling (b11:641) -> height _644.
// Color/Fresnel/anim (b11:650-803):
//   colorLerp.c = lerp(_ParallaxColorDark.c, _ParallaxColor.c, _644)       (b11:672-674)
//   fresnel = pow(saturate(dot(camFwd, N_world)), floor(_ParallaxFresnelStrength))  (b11:686, max .001 base)
//   breathing = _650*((1+_ParallaxMinBrightness)/_650 + cos(time*_ParallaxAnimSpeed*0.05 + objOriginSum*_ParallaxAnimRandom))*0.5
//               where _650 = 1 - _ParallaxMinBrightness                    (b11:803 + _650 b11:308)
//   charPulse = (smoothstep(outer,inner,|P - emitterWS|)^ via _757) * _ParallaxBrightStrength , gated by _ParallaxCharPos
//               (b11:735-757,803) -- the ONE host-VFX input (_VFXParams0.xyz); neutral (emitter=origin) -> steady.
//   bright = mad(charPulse, ... , breathing) folded as b11:803 (_803).
//   Em.c = min(max(bright * (fresnel * colorLerp.c), 0), 1000) / postExp   (b11:885-887 core, w/o worldspace mask)
//          * _ParallaxIntensity                                           (b219:346 *_OffsetUVSet == _ParallaxIntensity)
// =============================================================================
// Returns the FINAL (post-_ParallaxIntensity) plain parallax emission. Also outputs, for the
// worldspace path, the PRE-master per-channel emission `emPreMaster` (= bright*fresnel*colorLerp/postExp,
// before *_ParallaxIntensity) and the visible heights `heights`=(pHx,pHy) sampled from _ParallaxMap.
// normalGeo = the GEOMETRIC vertex world normal (b11 TEXCOORD_2) — drives the TBN view-projection
//             for the march (b11:497-515) AND the bitangent (b11:192-194).
// normalShaded = the normal-mapped surface normal (b11:481-490) — drives ONLY the Fresnel (b11:686).
float3 LebParallax(float2 uv0, float2 uv1, float3 positionWS, float3 normalGeo, float3 normalShaded,
                   float3 tangentWS, float tangentSign, float3 viewDirWS, float time,
                   out float3 emPreMaster, out float2 heights, out float3 colorLerpOut)
{
    emPreMaster = float3(0.0, 0.0, 0.0);
    heights     = float2(0.0, 0.0);
    colorLerpOut = float3(0.0, 0.0, 0.0);
#if defined(_PARALLAX_MAP) || defined(_PARALLAX_MAP_WORLDSPACE)
    // world camera-forward / view dir (b11:199-242). HgViewDirWS-style normalize with the SAME guard.
    float3 camFwd = normalize(viewDirWS);                                          // b11:239-242 (_240..242) (ortho uses -ViewMatrix row2; URP viewDirWS already encodes both)

    // tangent-space basis (the GEOMETRIC T/B/N), b11:176-194 bitangent = sign*cross(N_geo,T).
    float3 bitangent = (tangentSign) * cross(normalGeo, tangentWS);                 // b11:192-194 (_192..194 with _158 sign)
    float tDotV = dot(tangentWS,  camFwd);                                          // b11:228 (_497)
    float bDotV = dot(bitangent,  camFwd);                                          // b11:229 (_500)
    float nDotV = dot(normalGeo,  camFwd);                                          // b11:230 (_509) GEOMETRIC normal
    float rcpLen = rsqrt(dot(float3(tDotV, bDotV, nDotV), float3(tDotV, bDotV, nDotV)));  // b11:231 (_515)

    float duvX = uv1.x - uv0.x;
    float duvY = uv1.y - uv0.y;
    float2 uvP = float2(mad(_ParallaxMapUVType, duvX, uv0.x),                       // b11:527-528 (_527,_528)
                        mad(_ParallaxMapUVType, duvY, uv0.y));

    float dXx = ddx_coarse(uv0.x), dXy = ddx_coarse(uv0.y);                         // b11:533-534
    float dYx = ddy_coarse(uv0.x), dYy = ddy_coarse(uv0.y);                         // b11:539-540
    float numSteps = min(float(_ParallaxMarchNum), 20.0);                           // b11:547 (_547)
    float invSteps = 1.0 / numSteps;                                              // b11:548 (_549)
    float bias  = mad(nDotV, rcpLen, 0.4199999868869781494140625);                  // b11:550 (_550)
    float denom = max(rcpLen * nDotV, 0.001000000047497451305389404296875);        // b11:554 (_554)
    float negStr = -_ParallaxStrength;                                             // b11:562 (_562)
    float dirU = (((rcpLen * tDotV) / bias) / denom) * negStr;                      // b11:563 (_563)
    float dirV = (((rcpLen * bDotV) / bias) / denom) * negStr;                      // b11:564 (_564)
    float stepU = invSteps * dirU;                                                // b11:565 (_565)
    float stepV = invSteps * dirV;                                                // b11:566 (_566)
    float endN = numSteps + 1.0;                                                  // b11:569 (_569)
    // _GlobalMipBiasPow2 (b11:573) = exp2(_GlobalMipBias) = URP's `_GlobalMipBias.y` (Input.hlsl float2). INFRA 1:1.
    float2 gradX = float2(dXx, dXy) * _GlobalMipBias.y;                             // b11:573-574 (_573,_574)
    float2 gradY = float2(dYx, dYy) * _GlobalMipBias.y;                             // b11:578-579 (_578,_579)

    // steep march on _ParallaxNoiseMap (T6), b11:572-616 (state copies _585/_587/_589/_591..595).
    float layerH   = 1.0 - invSteps;                  // b11:261 (_585) marched height, starts (1 - invSteps)
    float curU     = stepU;                            // b11:268 (_587)
    float curV     = stepV;                            // b11:269/287 (_589 as asfloat, seeded from _580=asuint(_566)) -> start = stepV
    float prevH    = 1.0;                              // b11:263 (_593) previous marched height
    float prevU    = 0.0;                              // b11:264 (_594)
    float prevV    = 0.0;                              // b11:265 (_595)
    float storedAtHit = 0.0;                           // b11:267 (_616 = 0u) noise height at the hit step
    float storedPrev  = 0.0;                           // b11:262 (_591 = 0u) noise height at the previous step
    float i = 0.0;                                     // b11:270 (_597 = _584 = 0)
    [loop]
    for (; i < endN; i += 1.0)                          // b11:272-303 (for(;;){ _597 < _569 })
    {
        float h = SAMPLE_TEXTURE2D_GRAD(_ParallaxNoiseMap, sampler_ParallaxNoiseMap,
                  float2(mad(uvP.x, _ParallaxNoiseMapTilling, curU), mad(uvP.y, _ParallaxNoiseMapTilling, curV)),
                  gradX, gradY).x;                      // b11:277 (_607.x = _611)
        if (layerH < h)                                 // b11:280 !(_585 < _611) is the CONTINUE; so hit when layerH < h
        {
            storedAtHit = h;                            // b11:295 (_616 = _592)
            break;
        }
        prevH = layerH;          layerH -= invSteps;    // b11:283-284 (_593=_585_copy ; _585 -= invSteps)
        prevU = curU;            curU = mad(dirU, invSteps, curU);   // b11:285-286 (_594=_587_copy ; _587 += step)
        prevV = curV;            curV = mad(dirV, invSteps, curV);   // b11:287 (_595=asfloat(_589) ; _589 += step)
        storedPrev = h;                                 // b11:288 (_591 = _592 = asuint(_611))  prev-step noise height
    }
    // soft parametric intersection blend (b11:304/627). _591=storedPrev, _616=storedAtHit, _593=prevH, _585=layerH.
    float t = (storedPrev - prevH) / ((-prevH) + (layerH + (storedPrev - storedAtHit)));  // b11:627 (_627)
    // corrected parallax uv -> sample _ParallaxMap (T3) for the visible height (b11:641).
    float2 pUV = float2((mad(stepU, t, prevU) + uvP.x) * _ParallaxTilling,
                        (mad(stepV, t, prevV) + uvP.y) * _ParallaxTilling);                // b11:305 (_641 uv)
    float2 pTex = SAMPLE_TEXTURE2D_BIAS(_ParallaxMap, sampler_ParallaxMap, pUV, 0.0).xy;   // b11:305 (_641), .x=_643 .y=_644
    float pHx = pTex.x;                                                                    // b11:306 (_643)
    float pHy = pTex.y;                                                                    // b11:307 (_644)

    // color lerp _ParallaxColorDark<->_ParallaxColor by the visible height (b11:672-674).
    float3 colorLerp = float3(
        mad(pHy, _ParallaxColor.x - _ParallaxColorDark.x, _ParallaxColorDark.x),
        mad(pHy, _ParallaxColor.y - _ParallaxColorDark.y, _ParallaxColorDark.y),
        mad(pHy, _ParallaxColor.z - _ParallaxColorDark.z, _ParallaxColorDark.z));

    // Fresnel = pow(saturate(dot(camFwd, N_shaded)), floor(_ParallaxFresnelStrength)) (b11:686), .001 base floor.
    // b11:686 uses the NORMAL-MAPPED surface normal (_488..490), not the geometric one.
    float NoVc = clamp(dot(camFwd, normalShaded), 0.0, 1.0);
    float fresnel = exp2(log2(max(NoVc, 0.001000000047497451305389404296875)) * floor(_ParallaxFresnelStrength));  // b11:686 (_686)

    // animated breathing (b11:308,803). minB-> _650 = 1 - _ParallaxMinBrightness.
    float minB = 1.0 - _ParallaxMinBrightness;                                             // b11:308 (_650)
    float objOriginSum = (unity_ObjectToWorld._m13 + unity_ObjectToWorld._m03) + unity_ObjectToWorld._m23;  // b11:803 ((_unity_ObjectToWorld[3].y + .x) + .z)
    float breathing = minB * (((1.0 + _ParallaxMinBrightness) / minB)
                    + cos(mad(time * _ParallaxAnimSpeed, 0.0500000007450580596923828125, objOriginSum * _ParallaxAnimRandom)));  // b11:803 inner

    // char-position brightness pulse (b11:735-757,803) — host VFX input (_VFXParams0.xyz skill emitter).
    // Neutral (emitter at origin, _ParallaxCharPos default 0): pulse contributes 0 -> steady breathing.
    float3 dEmit = positionWS - _VFXParams0.xyz;                                           // b11:735-737 (_735..737)
    float ring = clamp((length(dEmit) - _ParallaxBrightOuterRadius)
               * (1.0 / (_ParallaxBrightInnerRadius - _ParallaxBrightOuterRadius)), 0.0, 1.0);  // b11:757 (_757)
    float ringSmooth = (ring * ring) * mad(ring, -2.0, 3.0);                               // b11:803 smoothstep((_757^2)(3-2_757))
    float charPulse = (_ParallaxCharPos != 0.0) ? (ringSmooth * _ParallaxBrightStrength) : 0.0;  // b11:803 (& _ParallaxCharPos mask)

    // secondary skill-sphere falloff (b11:317-319,803) — host VFX input (_VFXParams2; .z=radius, .w=strength).
    // Neutral (_VFXParams2 = 0 -> radius 0): the 1/(-radius) term is degenerate, so the sphere contributes
    // 0 exactly (faithful: no secondary skill sphere active). Gated on _VFXParams2.z != 0 to avoid the inf.
    float sphereSmooth = 0.0;
    if (_VFXParams2.z != 0.0)
    {
        float2 dSphere = float2(positionWS.x - _VFXParams2.x, positionWS.z - _VFXParams2.y);  // b11:317-318 (_779,_780)
        float sphere = clamp((1.0 / (-_VFXParams2.z)) * (length(dSphere) - _VFXParams2.z), 0.0, 1.0);  // b11:319 (_796)
        sphereSmooth = (sphere * sphere) * mad(sphere, -2.0, 3.0);                          // b11:803 smoothstep
    }
    float bright = mad(sphereSmooth, _VFXParams2.w, mad(breathing, 0.5, charPulse));        // b11:803 (_803) full

    float postExpDiv = (_ParallaxIgnorePostExposure != 0.0) ? _ExposureParams.x : 1.0;     // b11:331 (_872)
    float3 em = float3(
        min(max(bright * (fresnel * colorLerp.x), 0.0), 1000.0) / postExpDiv,
        min(max(bright * (fresnel * colorLerp.y), 0.0), 1000.0) / postExpDiv,
        min(max(bright * (fresnel * colorLerp.z), 0.0), 1000.0) / postExpDiv);             // b219:336-338 / b11:885-887 (core, no mask-map factor in non-worldspace)
    emPreMaster = em;                                                                       // for the worldspace pattern path (b11:885-887, pre-_ParallaxIntensity)
    heights     = float2(pHx, pHy);                                                         // b11:306-307 (_643,_644) for the world-mask uv offset
    colorLerpOut = colorLerp;                                                               // b11:332 _672/_673/_674 — worldspace _885 multiplies by colorLerp again
    return em * _ParallaxIntensity;                                                        // b219:346-348 *_OffsetUVSet == master _ParallaxIntensity
#else
    return float3(0.0, 0.0, 0.0);
#endif
}

// =============================================================================
// MODULE: WorldParallax  — _PARALLAX_MAP_WORLDSPACE.  1:1 source b11:821-1016,355-357.
//
// Adds a WORLD-XZ-projected pattern mask (_ParallaxMaskMap, T5) rotated by _MaskWorldPosParams,
// modulating the parallax emission through a 5-level sign-control pattern-color blend
// (_ParallaxPatternColor<->Dark selected by _ParallaxSignControl bits + _ParallaxSignLerpFactor*).
// Returns the FULL b11:355-357 worldspace contribution: mad(_1182*_1014, _ParallaxIntensity, TERM_C)
// where TERM_C = _1160*(_1142*((_1014+0.3)*_WorldParallaxAdditionalColor)). The caller adds this to
// s.emission. ALL material math (mask RGB _885 factor, true _1182, surface-channel _1152/_1160, TERM C)
// is closed 1:1; the ONLY host-fed inputs are the two interaction interpolators (fed neutral 0).
//
//   worldXZ = positionWS.xz - _MaskWorldPosParams.xz                       (b11:821-822)
//   ang     = radians(_MaskWorldPosParams.y) ; (s,c)=sincos(ang)           (b11:826-829)
//   scale   = max(0.1, _MaskWorldPosParams.w)                              (b11:833)
//   maskUV  = ( dot(worldXZ/scale, (c, s)) + 0.5  +  pHx*_ParallaxMinBrightness,
//               dot(worldXZ/scale, (-s, c)) + 0.5 +  pHy*_ParallaxMinBrightness )  (b11:329)
//   mask    = SampleLevel(_ParallaxMaskMap, maskUV, lod=mad(|N_geo.y|,-3,3))  ; _856 (.w=_861)  (b11:329-330)
//   em885.c       = parallaxEm.c * colorLerp.c * mask.c * _ParallaxMaskMapColorStrength  (b11:332-334 _885..887)
//   patternBase.c = em885.c * _ParallaxPatternColor.c                      (b11:343-345 _999..1001)
//   patternDark.c = mad(em885.c, _ParallaxPatternColorDark.c, -patternBase.c) (b11:346-348)
//   pattern.c     = mad(signMix, patternDark.c, patternBase.c)             (b11:346-348 _1014..1016)
//     signMix(_992) = saturate( mad( sum_{k=0..4} level(mask,k)*bit_k*_ParallaxSignLerpFactor,
//                                    interactSignal,                                          (b11:341 *TEXCOORD_4.x)
//                                    clamp(pHx*20 + |worldXZ| - _ParallaxLerpSchedule, 0, 1) ) )(b11:341 schedule)
//   _1182   = lerp(baseW, clamp(-positionWS.y + F1.w, 0, 1), saturate(F1.w))   (b11:354)
//   Out.c   = _1182 * pattern.c * _ParallaxIntensity                              (b11:355-357 A-term)
//           + _1160 * _1142 * (pattern.c + 0.3) * _WorldParallaxAdditionalColor.c (b11:355-357 TERM C)
//
// INFRA (host-side, neutral default): `interactSignal` = TEXCOORD_4.x and `interactSignalY` =
// TEXCOORD_7.y, two HG interaction-system vertex interpolators (the "交互物信号" signals) NOT
// present on a URP standard mesh; fed by the host interaction feature, defaulted 0 (un-triggered).
// With both = 0 the signal-driven sigMix collapses to the schedule term and TERM C collapses unless
// _ParallaxSignLerpFactor1.y < 0 — exactly the source's un-triggered steady pattern.
//
// _885 (b11:332): the worldspace parallax emission is the LebParallax CORE emission TIMES colorLerp
// AGAIN times the mask-map RGB times _ParallaxMaskMapColorStrength. The mask RGB (_856.xyz) is the
// SAME sample whose .w drives the sign-control levels. _1182 (b11:354) and the TERM-C surface-channel
// selects (_1152/_1160, b11:352-353) need baseTex.w / nrm.z / nrm.w — RE-SAMPLED here from the
// IDENTICAL base/normal UVs (CoreSurface spine untouched; 1:1 same textures, same _ST/UV-set math).
// `parallaxColorHeights` carries (pHx,pHy) = the _ParallaxMap visible heights (LebParallax internal).
// `colorLerp` = the per-channel _672/_673/_674 from LebParallax (needed to rebuild _885).
// `normalGeo` = GEOMETRIC world normal (b11 TEXCOORD_2); its .y drives the mask mip LOD (b11:329),
//   NOT a view-space or normal-mapped normal.
// =============================================================================
float3 LebWorldParallax(float3 parallaxEmPreIntensity, float3 colorLerp, float2 parallaxColorHeights,
                        float2 uv0, float2 uv1, float3 positionWS, float3 normalGeo,
                        float interactSignal, float interactSignalY)
{
#ifdef _PARALLAX_MAP_WORLDSPACE
    float pHx = parallaxColorHeights.x, pHy = parallaxColorHeights.y;
    float2 worldXZ = positionWS.xz - _MaskWorldPosParams.xz;                                // b11:821-822 (_821,_822)
    float ang = 0.01745329238474369049072265625 * _MaskWorldPosParams.y;                   // b11:826 (_826) deg->rad
    float s = sin(ang), c = cos(ang);                                                      // b11:828-829 (_828,_829)
    float scale = max(0.100000001490116119384765625, _MaskWorldPosParams.w);               // b11:833 (_833)
    float2 wq = worldXZ / scale;                                                           // b11:834-835 (_834,_835)
    float2 maskUV = float2(mad(pHx, _ParallaxMinBrightness, dot(wq, float2(c,  s)) + 0.5),  // b11:329 (_856 uv)
                           mad(pHy, _ParallaxMinBrightness, dot(wq, float2(-s, c)) + 0.5));
    float lod = mad(abs(normalGeo.y), -3.0, 3.0);                                          // b11:329 lod = mad(abs(TEXCOORD_2.y),-3,3) — GEOMETRIC world normal Y
    float4 mask = SAMPLE_TEXTURE2D_LOD(_ParallaxMaskMap, sampler_ParallaxMaskMap, maskUV, lod);  // b11:330 (_856)
    float maskA = mask.w;                                                                   // b11:330 (_861)

    // _885 (b11:332): coreEmission * colorLerp(_672) * maskRGB(_856.x) * _ParallaxMaskMapColorStrength.
    float3 em885 = float3(
        parallaxEmPreIntensity.x * (colorLerp.x * (mask.x * _ParallaxMaskMapColorStrength)),
        parallaxEmPreIntensity.y * (colorLerp.y * (mask.y * _ParallaxMaskMapColorStrength)),
        parallaxEmPreIntensity.z * (colorLerp.z * (mask.z * _ParallaxMaskMapColorStrength)));  // b11:332-334 (_885,_886,_887)

    // pattern color (b11:343-348). _999 = _885 * _ParallaxPatternColor ; pattern = lerp(base, base+dark, signMix).
    float3 patternBase = em885 * _ParallaxPatternColor.rgb;                                 // b11:343-345 (_999..1001)
    float3 patternDark = float3(
        mad(em885.x, _ParallaxPatternColorDark.x, -patternBase.x),
        mad(em885.y, _ParallaxPatternColorDark.y, -patternBase.y),
        mad(em885.z, _ParallaxPatternColorDark.z, -patternBase.z));                         // b11:346-348 inner

    // 5-level sign-control blend factor (b11:335-342). _ParallaxSignControl bits select levels;
    // each level = clamp(mask - k*0.2)*(0.18>=level?1:0)*5 * bit * _ParallaxSignLerpFactor.
    uint sig = uint(int(_ParallaxSignControl));                                            // b11:335 (_891)
    float l0 = clamp(maskA,                                          0.0, 1.0);            // b11:336 (_892)
    float l1 = clamp(maskA - 0.20000000298023223876953125,          0.0, 1.0);             // b11:337 (_901)
    float l2 = clamp(maskA - 0.4000000059604644775390625,           0.0, 1.0);             // b11:338 (_902)
    float l3 = clamp(maskA - 0.60000002384185791015625,             0.0, 1.0);             // b11:339 (_903)
    float l4 = clamp(maskA - 0.800000011920928955078125,            0.0, 1.0);             // b11:340 (_904)
    float term4 = ((l4 * ((0.180000007152557373046875 >= l4) ? 1.0 : 0.0)) * 5.0) * float((sig >> 4u) & 1u) * _ParallaxSignLerpFactor2;       // b11:341
    float term3 = ((l3 * ((0.180000007152557373046875 >= l3) ? 1.0 : 0.0)) * 5.0) * float((sig >> 3u) & 1u) * _ParallaxSignLerpFactor0.w;
    float term2 = ((l2 * ((0.180000007152557373046875 >= l2) ? 1.0 : 0.0)) * 5.0) * float((sig >> 2u) & 1u) * _ParallaxSignLerpFactor0.z;
    float term0 = (float(sig & 1u) * ((((0.180000007152557373046875 >= l0) ? 1.0 : 0.0) * l0) * 5.0)) * _ParallaxSignLerpFactor0.x;
    float term1 = (((l1 * ((0.180000007152557373046875 >= l1) ? 1.0 : 0.0)) * 5.0) * float((sig >> 1u) & 1u)) * _ParallaxSignLerpFactor0.y;
    float sigSum = term4 + term3 + term2 + term0 + term1;                                  // b11:341 nested mads
    // schedule = clamp(pHx*20 + |worldXZ| - _ParallaxLerpSchedule, 0, 1)  (b11:341 _991 schedule)
    float schedule = clamp(mad(pHx, 20.0, length(worldXZ)) - _ParallaxLerpSchedule, 0.0, 1.0);
    float signMix = clamp(mad(sigSum, interactSignal, schedule), 0.0, 1.0);                // b11:341-342 (_991->_992)

    float3 pattern = float3(
        mad(signMix, patternDark.x, patternBase.x),
        mad(signMix, patternDark.y, patternBase.y),
        mad(signMix, patternDark.z, patternBase.z));                                       // b11:346-348 (_1014..1016)

    // ---- surface channels for _1182 / _1160 : re-sample base & normal at the IDENTICAL UVs (b11:189-193) ----
    // _286 = baseColorMap.w ; _319 = normalMap.z ; _320 = normalMap.w (CoreSurface uses the same _ST/UV-set math).
    float duvX = uv1.x - uv0.x;
    float duvY = uv1.y - uv0.y;
    float2 uvBase = float2(mad(mad(_BaseUVSet,    duvX, uv0.x), _BaseColorMap_ST.x, _BaseColorMap_ST.z),
                           mad(mad(_BaseUVSet,    duvY, uv0.y), _BaseColorMap_ST.y, _BaseColorMap_ST.w));  // b11:189 (_281 uv)
    float2 uvPbr  = float2(mad(mad(_BasePbrMapUVSet, duvX, uv0.x), _NormalMap_ST.x, _NormalMap_ST.z),
                           mad(mad(_BasePbrMapUVSet, duvY, uv0.y), _NormalMap_ST.y, _NormalMap_ST.w));      // b11:191 (_315 uv)
    float baseW = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uvBase, 0.0).w;                 // b11:190 (_286)
    float2 nrmZW = SAMPLE_TEXTURE2D_BIAS(_NormalMap,    sampler_NormalMap,    uvPbr,  _TAAUNormalBiasReverse).zw; // b11:192-193 (_319,_320)
    float nrmZ = nrmZW.x, nrmW = nrmZW.y;

    // ---- _1182 (b11:354): lerp(baseW, clamp(-positionWS.y + F1.w, 0, 1), saturate(F1.w)) ----
    // _148 (reconstructed world Y) == IN.positionWS.y (faithful depth-reconstruction identity).
    float sigMaskA = mad(clamp(_ParallaxSignLerpFactor1.w, 0.0, 1.0),
                         (-baseW) + clamp((-positionWS.y) + _ParallaxSignLerpFactor1.w, 0.0, 1.0),
                         baseW);                                                            // b11:354 (_1182)

    // worldspace pattern emission term = _1182 * pattern * _ParallaxIntensity (b11:355-357 mad(_1182*_1014, _ParallaxIntensity, ...)).
    float3 worldTerm = (sigMaskA * pattern) * _ParallaxIntensity;

    // ---- TERM C (b11:351-353,355-357): _1160 * (_1142 * ((_1014 + 0.3) * _WorldParallaxAdditionalColor)) ----
    // _1142 = clamp(TEXCOORD_7.y - F1.y, 0, 1) ; TEXCOORD_7.y = host interaction interpolator (fed neutral 0).
    // _1152 = lerp(baseW, nrmZ, saturate(maskCh)) ; _1160 = lerp(_1152, nrmW, saturate(maskCh - 1)).
    float maskCh = _WorldParallaxAdditionalLightMaskChannel;
    float c1142 = clamp(interactSignalY - _ParallaxSignLerpFactor1.y, 0.0, 1.0);            // b11:351 (_1142)
    float c1152 = mad(clamp(maskCh,        0.0, 1.0), (-baseW) + nrmZ, baseW);              // b11:352 (_1152)
    float c1160 = mad(clamp(maskCh - 1.0,  0.0, 1.0), (-c1152) + nrmW, c1152);             // b11:353 (_1160)
    float3 termC = float3(
        c1160 * (c1142 * ((pattern.x + 0.300000011920928955078125) * _WorldParallaxAdditionalColor.x)),
        c1160 * (c1142 * ((pattern.y + 0.300000011920928955078125) * _WorldParallaxAdditionalColor.y)),
        c1160 * (c1142 * ((pattern.z + 0.300000011920928955078125) * _WorldParallaxAdditionalColor.z)));  // b11:355-357 C-term (_1014+0.3)

    return worldTerm + termC;
#else
    return float3(0.0, 0.0, 0.0);
#endif
}

#endif // HGRP_LITEFFECTBLEND_MODULES_INCLUDED
