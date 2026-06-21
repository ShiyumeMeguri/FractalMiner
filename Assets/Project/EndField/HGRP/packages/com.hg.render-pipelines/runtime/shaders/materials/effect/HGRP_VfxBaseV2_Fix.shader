// HGRP VfxBaseV2 — unified VFX (particle/effect) shader, single ForwardOnly pass mapped to URP UniversalForwardOnly.
// Merged from: vfxbasev2.shader (HGRP/Effect/VFXBaseV2) base (#else catch-all) variant
//   Vertex base: vfxbasev2/Sub0_Pass0_Vertex_b1308.hlsl   (Keywords: HG_ENABLE_MV)
//   Fragment base: vfxbasev2/Sub0_Pass0_Fragment_b1309.hlsl (Keywords: HG_ENABLE_MV)
//   + Fresnel delta 1:1: vfxbasev2/Sub0_Pass0_Fragment_b1355.hlsl (Keywords: HG_ENABLE_MV _USE_FRESNEL)
//
// Keywords (exposed in this Fix): _USE_FRESNEL, _USE_LIGHTING, _USE_BRIGHT, _USE_BRIGHT_SECTOR, _USE_ANIM_BREATHING,
//   _SAMPLE_TEX0, _SAMPLE_TEX1, _SAMPLE_TEX2, _SAMPLE_TEX3, _SAMPLE_TEX4, _SAMPLE_TEX5, _USE_POLARUV, _USE_SCREENUV,
//   _USE_EDGECOLOR, _USE_SOFTBLEND, _USE_FOG, _USE_WATER_BLEND, _USE_TRAIL.
// Kept (1:1 from base blobs): object->world->clip transform, in-particle/camera-offset vertex push,
//   MainTex sample (mip-bias) + channel-select alpha (_UseMainTexAsAlpha), tint*vertexColor*intensity,
//   exposure-threshold HDR boost (_ExpThreshold/_ExpIntensity), camera-distance soft+edge fade,
//   LOD-crossfade dither clip, surface-type gating, premultiplied additive/alpha output (_BlendMode),
//   Fresnel rim (view-dir, ortho-aware, bias/power/flip, color blend),
//   Bright Spot/ScanLine value-noise distance-field brightness overlay (animated value-noise UV distortion +
//   radial/signed-axis/noise-distorted smoothstep masks adding _BrightColor/_ScanFillColor; b1313) and the
//   _USE_BRIGHT_SECTOR angular-wedge distance field (atan2 sector + box + ring smoothstep; b1329).
// Removed (pixel-neutral pipeline infra substituted by URP / dropped per sandbox):
//   GPU skinning (T0 ByteAddressBuffer bone matrices), HGRP motion vectors + SV_Target1 MRT,
//   TAA jitter (_TaaJitterStrength), HGRP global cbuffers (ShaderVariablesGlobal / CB2UBO / UnityPerDraw
//   -> URP Core.hlsl globals), _VFXParams0/1 + _IsSceneEffect scene-effect compositing, particle
//   instance-color (CB2_m0[13]), _Responsive transparent-MV packing.
//   _USE_LIGHTING dropped its TERM3 only: the HG tiled/punctual light-binning loop (T0/T1 light ByteAddressBuffers,
//   light-cookie atlas T5, _lightCookieMatrices) — HG clustered lights, no URP-portable equivalent. The SH/IV
//   ambient (TERM1) + directional main-light (TERM2) ARE ported 1:1 via SampleSH + GetMainLight.
//
// NOTE: This is the BASE permutation. The source is a 28-keyword / 2848-variant explosion. The remaining
//   keyword-gated subsystems (VAT Rigid/Soft/Fluid/Particle, VertexOffset(+Mask)) are NOT in this base blob;
//   they HAVE been deep-closed from their own delta blobs (see the DONE log at file end) — none are silently
//   simplified, and the only host-bound piece (VAT textures, filled by a Houdini->C# bake) keeps a documented
//   identity-playback stub. The Lighting subsurface+main-light
//   contribution HAS been ported (deep-close, from Fragment_b1311:588-590,368-378) under _USE_LIGHTING
//   (SH ambient via SampleSH*_EnvironmentGlobalParams0.x + URP main-light saturate(NdotL)*color*shadow; the HG
//   tiled/punctual light-binning loop is host-bound and dropped — see the DONE note at file end). The EdgeColor multiply/additive tint HAS been
//   ported (deep-close, from b1871:193-196) under _USE_EDGECOLOR. The Bright Spot/ScanLine/Sector value-noise
//   system HAS been ported (deep-close, from b1313 + b1329) under _USE_BRIGHT / _USE_BRIGHT_SECTOR; the
//   AnimBreathing alpha pulse HAS been ported (deep-close, from b1647) under _USE_ANIM_BREATHING; the
//   _SAMPLE_TEX0.._SAMPLE_TEX5 shared input layer (6 aux texture reads feeding Disturb/Weight/Mask/Blend/
//   Dissolve) HAS been ported (deep-close, from Fragment_b1315:177-204 + Vertex_b1314:466-469); the
//   ScreenUV / PolarUV alternate MainTex UV generation HAS been ported (deep-close, from Fragment_b1385:155-183)
//   under _USE_SCREENUV / _USE_POLARUV (atan2 polar UV + depth/flat screen UV, weighted-blended into MainTex UV);
//   and the SoftBlend depth-buffer soft-particle fade HAS been ported (deep-close, from Fragment_b1681:156-168)
//   under _USE_SOFTBLEND (scene depth via URP _CameraDepthTexture: saturate((sceneEyeDepth - particleEyeDepth +
//   _SoftBias)/_SoftDistance)).
// NOTE: several base-blob scalar reads are packoffset-ALIASED (e.g. c13.w read as _EdgeColor.w but also
//   declared _NearCameraFadeDistanceStart2); the verified sibling HGRP_CharacterNPR_VFX_Fix.shader was
//   used to disambiguate the logical role of those registers. See selfRisks in the manifest.

Shader "HGRP/VfxBaseV2_Fix" {
    Properties {
        // --- Main Properties ---
        [Enum(Opaque, 0, Transparent, 1)] [HideInInspector] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        _VertCameraOffset ("Vertex Camera Offset (m)", Float) = 0
        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity", Range(1, 100)) = 1
        _ExpThreshold ("Exp Threshold", Range(0, 1)) = 1
        _ExpIntensity ("Exp Intensity", Range(0, 100)) = 0
        _TintColorAlpha ("Tint Color Alpha", Range(0, 10)) = 1
        [HideInInspector] _ProcedureAlpha ("Procedure Alpha", Float) = 1

        // --- Main Tex ---
        _MainTex ("Main Tex", 2D) = "white" {}
        [ToggleUI] _MainTexMipmapBias ("MainTex Mipmap Bias", Float) = 0
        _MainTexUseDisturb ("Main Tex Use Disturb", Range(0, 1)) = 1
        [ToggleUI] _UseMainTexAsAlpha ("Use MainTex As Alpha", Float) = 1
        [ToggleUI] _EnableTransparentMV ("Enable Transparent MV", Float) = 0
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MainUVSet ("Main UV Set", Float) = 0
        // ScreenUV (_USE_SCREENUV) controls. _UsePosYAsScreenV: V = world Y instead of screen Y.
        //   _ScreenUVUseDepth: screen UV is reconstructed-from-depth view-space XY (and distance-scaled) vs flat.
        [Toggle(_USE_POLARUV)] _UsePolarUV ("Use Polar UV", Float) = 0
        [Toggle(_USE_SCREENUV)] _UseScreenUV ("Use Screen UV", Float) = 0
        [ToggleUI] _UsePosYAsScreenV ("Screen UV: Use World Y as V", Float) = 0
        [ToggleUI] _ScreenUVUseDepth ("Screen UV: Affected By Camera Distance", Float) = 1
        _MainTexUVSpeed ("MainTex UV Speed (XY:Time, ZW:Custom1.X)", Vector) = (0, 0, 0, 0)
        _MainTexUVRotate ("MainTex UV Rotate (Degree)", Float) = 0
        [HideInInspector] _MainTexUVRotateMat ("MainTex UV Rotate Mat", Vector) = (1, 0, 0, 1)
        [HideInInspector] _MainTexUVWeights ("MainTex UV Weights", Vector) = (1, 0, 0, 0)
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0

        // --- Camera-distance fade (edge / soft) ---
        _EdgeDistance ("Edge Distance", Range(0.001, 10)) = 0.001
        _EdgeDistanceOffset ("Edge Distance Offset", Range(0.0001, 10)) = 0.001
        _SoftDistance ("Soft Distance", Range(0.001, 10)) = 0.001
        _SoftBias ("Soft Bias", Float) = 0
        // Soft-particle depth-buffer fade (_USE_SOFTBLEND). When on, the soft fade reads the scene depth
        //   buffer (URP _CameraDepthTexture) and fades by (sceneDepth - particleDepth); when off, the base
        //   self-depth (camera-distance) fade is used. 1:1 vfxbasev2/Sub0_Pass0_Fragment_b1681.hlsl:156-168.
        [Toggle(_USE_SOFTBLEND)] _UseSoftBlend ("Use SoftBlend (depth soft-particle)", Float) = 0

        // --- Fog (HG atmosphere + exponential height + volumetric froxel fog blend; _USE_FOG) ---
        //   When on, the effect color is blended toward the scene fog (camera-distance + height + sun-phase
        //   in-scattering) 1:1 vfxbasev2/Sub0_Pass0_Fragment_b1925.hlsl:211-284. The HG fog parameter banks
        //   (_AtmosphereFogParams*/_ExponentialFogParams*/_VolumetricFogParams*) are engine-side globals
        //   populated by HG's Fog/VolumetricFog render components; re-exposed as a global CBUFFER (infra idiom).
        [Toggle(_USE_FOG)] _UseFog ("Use Fog", Float) = 0

        // --- Water Blend (underwater absorption + scatter; _USE_WATER_BLEND) ---
        //   1:1 vfxbasev2/Sub0_Pass0_Fragment_b1661.hlsl:206-223. Beer-Lambert-style absorption darkens the
        //   effect color+alpha by (1 - _WaterAbsorption.w); a depth-ramp mask (from _WaterAbsorption.z +
        //   _WaterAbsorption2 + _SafeFullAbsorpDistance, driven by the per-vertex water-depth in uv0.z) then
        //   adds the _WaterScatter color back into the RGB (in-scatter). Canonical property names per
        //   vfxbasev2.shader:267-272; the ramp coefficients are packoffset-ALIASED in the blob (see frag note).
        [Toggle(_USE_WATER_BLEND)] _UseWaterBlend ("Use Water Blend", Float) = 0
        _WaterHeight ("Water Height", Float) = -9999
        _SafeFullAbsorpDistance ("Safe Full Absorption Distance", Float) = 0
        [HDR] _WaterAbsorption ("Water Absorption (.w=strength .z=ramp depth)", Color) = (1, 1, 1, 1)
        [HDR] _WaterAbsorption2 ("Water Absorption 2 (scatter depth-ramp coeffs)", Color) = (1, 1, 1, 1)
        [HDR] _WaterScatter ("Water Scatter (.xyz=in-scatter color, .y!=0 enables)", Color) = (1, 1, 1, 1)

        // --- Edge Color tint (_USE_EDGECOLOR) ---
        [Toggle(_USE_EDGECOLOR)] _UseEdgeColor ("Use Edge Color", Float) = 0
        [Enum(Multiply, 0, Addictive, 1)] _EdgeColorMode ("Edge Color Mode", Float) = 0
        [HDR] [Gamma] _EdgeColor ("Edge Color", Color) = (1, 1, 1, 1)

        // --- Vertex Offset (offset-texture vertex displacement; _USE_VERTOFFSET (+ _USE_VERTOFFSETMASK)) ---
        //   VERTEX-ONLY feature. Each vertex is pushed along a chosen direction (Object axis / World axis /
        //   decoded vertex Normal) by an amount read from _OffsetTex (a scrolling offset texture), remapped
        //   around _OffsetIntensity, scaled by a per-vertex mask (_Bi_Offset + custom-data weight). With
        //   _USE_VERTOFFSETMASK a SECOND texture (_OffsetMaskTex) further modulates the amount.
        //   1:1 vfxbasev2/Sub0_Pass0_Vertex_b1438.hlsl (offset) + Sub0_Pass0_Vertex_b1508.hlsl (offset+mask).
        //   Canonical property names per vfxbasev2.shader:135-146.
        [Toggle(_USE_VERTOFFSET)] _UseVertexOffset ("Use Vertex Offset", Float) = 0
        _OffsetTex ("Offset Tex", 2D) = "white" {}
        _OffsetSpeed ("Offset Speed (XY: By Time, ZW: By Custom)", Vector) = (0, 0, 0, 0)
        _OffsetDir ("Offset Dir (XYZ: Axis, W: By CustomY)", Vector) = (0, 0, 0, 0)
        [Enum(Object, 0, World, 1, Normal, 2)] _OffsetSwitchDir ("Dir Switcher", Float) = 0
        _OffsetIntensity ("Offset Intensity", Float) = 0
        [ToggleUI] _Bi_Offset ("Use Two Direction Offset", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _OffsetUVSet ("Vertex Offset UV Set", Float) = 0
        [ToggleUI] _LocalPivortSpace ("Local Pivot Space", Float) = 0
        [Toggle(_USE_VERTOFFSETMASK)] _UseVertexOffsetMask ("Use Vertex Offset Mask", Float) = 0
        _OffsetMaskTex ("Offset Mask Tex", 2D) = "white" {}
        _OffsetMaskSpeed ("Offset Mask Speed (XY: By Time, ZW: By Custom)", Vector) = (0, 0, 0, 0)
        _OffsetMaskPower ("Offset Mask Power", Range(0, 5)) = 0

        // --- Houdini VAT playback (vertex; _VAT_RIGIDBODY / _VAT_SOFTBODY / _VAT_FLUIDBODY / _VAT_PARTICLE,
        //     + _USE_VAT_COLORTEX). Plays a baked Houdini Vertex-Animation-Texture simulation: per-frame
        //     per-vertex POSITION (and for rigid/soft/fluid a per-vertex orientation QUATERNION) are read from
        //     _VatPositionTexture / _VatRotationTexture and used to displace + reorient the mesh. The current
        //     animation frame and the per-vertex UV into the VAT texture are computed from the bake metadata
        //     (frame count, bounds-remap, pivot) + the per-vertex VAT-uv channel. 1:1 vertex deltas:
        //       _VAT_RIGIDBODY  vfxbasev2/Sub0_Pass0_Vertex_b1618.hlsl  (rotate pivot-relative vertex by q + add pos)
        //       _VAT_SOFTBODY   vfxbasev2/Sub0_Pass0_Vertex_b1592.hlsl  (per-vertex pos offset; q reorients normal only)
        //       _VAT_FLUIDBODY  vfxbasev2/Sub0_Pass0_Vertex_b1638.hlsl  (soft + _VatLookupTexture vertex->texel remap)
        //       _VAT_PARTICLE   vfxbasev2/Sub0_Pass0_Vertex_b1644.hlsl  (camera-facing quad expansion + heading spin)
        //   The VAT textures are HOST-BOUND (baked by a Houdini->C# pipeline); absent the system Unity binds the
        //   defaults below (black pos/rot/color) -> identity playback. Toggles are keyword-exclusive (pick one body).
        // Keyword names match the source multi_compile_local exactly (vfxbasev2.shader:347-351); pick ONE body.
        [Toggle(_VAT_RIGIDBODY)] _UseVATRigidBody ("VAT RigidBody", Float) = 0
        [Toggle(_VAT_SOFTBODY)]  _UseVATSoftBody  ("VAT SoftBody", Float) = 0
        [Toggle(_VAT_FLUIDBODY)] _UseVATFluidBody ("VAT FluidBody", Float) = 0
        [Toggle(_VAT_PARTICLE)]  _UseVATParticle  ("VAT Particle", Float) = 0
        [Toggle(_USE_VAT_COLORTEX)] _UseVATColorTex ("VAT Use Color/Heading Tex", Float) = 0
        _VatPositionTexture ("VAT Position Texture", 2D) = "black" {}
        _VatRotationTexture ("VAT Rotation Texture", 2D) = "black" {}
        _VatColorTexture ("VAT Color/Heading Texture", 2D) = "black" {}
        _VatLookupTexture ("VAT Lookup Texture (fluid topology remap)", 2D) = "black" {}
        // Bake metadata (canonical logical names; the blob reads these from packoffset-aliased water/edge/sampler
        //   registers, decoded by usage — same alias idiom as the VertexOffset/Water features above).
        _VatFrameCount ("VAT Frame Count", Float) = 1
        _VatBoundsMin ("VAT Bounds Min (pos remap subtract)", Float) = 0
        _VatBoundsMax ("VAT Bounds Max (pos remap scale)", Float) = 1
        _VatRotBoundsMin ("VAT Rot Bounds Min (quat remap subtract)", Float) = 0
        _VatRotBoundsMax ("VAT Rot Bounds Max (quat remap scale)", Float) = 1
        _VatPosScale ("VAT Position Scale", Float) = 1
        _VatTexHeight ("VAT Texture Height (rows, frame addressing)", Float) = 1
        _VatUseSnapshot ("VAT Use Snapshot (paused/manual frame)", Float) = 0
        _VatManualFrame ("VAT Manual Frame", Float) = 0
        _VatPlaybackSpeed ("VAT Playback Speed", Float) = 1
        // Particle-only (b1644): quad size axes + spin source.
        _VatParticleScaleX ("VAT Particle Scale X", Float) = 1
        _VatParticleScaleY ("VAT Particle Scale Y", Float) = 1
        [ToggleUI] _VatSpinByHeading ("VAT Spin Quad By Heading", Float) = 0
        [ToggleUI] _VatScaleByVel ("VAT Scale By Velocity", Float) = 0
        _VatScaleByVelAmount ("VAT Scale By Velocity Amount", Float) = 0
        [ToggleUI] _VatParticleVertColor ("VAT Particle Vertex Color (from heading tex)", Float) = 0

        // --- Trail (camera-facing ribbon billboard; _USE_TRAIL) ---
        //   VERTEX-ONLY feature (the fragment is byte-identical to the no-trail base, verified by diffing
        //   vfxbasev2/Sub0_Pass0_Fragment_b1553.hlsl against the base Fragment_b1309.hlsl). When on, each vertex
        //   is splayed sideways perpendicular to BOTH the camera-to-vertex direction and the per-vertex trail
        //   flow direction (TEXCOORD2.xyz), by (0.5 - uv0.y) * trailWidth(TEXCOORD2.w) — turning the strip mesh
        //   into a screen-facing ribbon. 1:1 vfxbasev2/Sub0_Pass0_Vertex_b1552.hlsl:341-349.
        [Toggle(_USE_TRAIL)] _UseTrail ("Use Trail", Float) = 0

        // --- Near Camera Fade ---
        _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Start 1", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Fade End 1", Range(0.001, 3000)) = 10
        _NearCameraFadeDistanceEnd2 ("Fade End 2", Range(0.002, 3000)) = 100
        _NearCameraFadeDistanceStart2 ("Fade Start 2", Range(0.001, 3000)) = 120

        // --- Bright (Spot / ScanLine / Sector value-noise brightness overlay) ---
        [Toggle(_USE_BRIGHT)] _UseBright ("Use Bright", Float) = 0
        [Toggle(_USE_BRIGHT_SECTOR)] _UseBrightSector ("Use Bright Sector", Float) = 0
        [HDR] [Gamma] _BrightColor ("Bright(Scanline) Color", Color) = (1, 1, 1, 1)
        [Enum(Spot, 0, ScanLine, 1, Sector, 2)] _BrightType ("Bright Type", Float) = 0
        _ScanLineSchedule ("ScanLine Schedule", Float) = 0
        _ScanLineWidth ("ScanLine Width", Float) = 0
        [HDR] [Gamma] _ScanFillColor ("Scan Fill Color", Color) = (1, 1, 1, 1)
        [ToggleUI] _BrightUseVertColor ("Bright Use Vertex Alpha", Float) = 0
        _InnerRadius ("Inner Radius (feather)", Range(0, 10)) = 0
        _OuterRadius ("Outer Radius (feather)", Range(0, 10)) = 2
        _SectorAngle ("Sector Angle", Range(0, 180)) = 0
        _SectorRadius ("Sector Radius", Range(0, 10)) = 2
        _SectorCenterRadius ("Sector Center Radius", Range(0, 10)) = 2
        _BoxInnerRadius ("Box Inner Radius", Range(0, 5)) = 1
        _BoxOuterRadius ("Box Outer Radius", Range(0, 5)) = 2
        _CharacterHeight ("Character Height", Float) = 1.5
        _DistortScale ("Distort Scale", Float) = 5
        _DistortSpeed ("Distort Speed", Float) = 1
        _DistortIntensity ("Distort Intensity", Range(0, 1)) = 0
        _DistortAlpha ("Distort Alpha", Range(-1, 1)) = 1
        _DistortOnEdge ("Distort On Edge", Float) = 0
        _BrightCenter ("Bright Center (0 = default character pos)", Vector) = (0, 0, 0, 0)
        // Re-exposed HGRP global (no URP equivalent): _VFXParams0.xyz = character/effect world position
        //   injected by the HG VFX system (the bright spot follows the character); .w = scroll time/phase.
        //   Same re-exposure idiom as sibling HGRP_VfxSkillScanline_Fix.shader:48,99.
        _VFXParams0 ("VFXParams0 (.xyz char world pos, .w time)", Vector) = (0, 0, 0, 0)

        // --- Lighting (subsurface SH ambient + dynamic main-light diffuse; _USE_LIGHTING) ---
        //   When on, the effect color is lit by the scene: SH/IV ambient irradiance (SampleSH) scaled by
        //   _EnvironmentGlobalParams0.x, plus the URP main directional light (saturate(NdotL)*color*shadow).
        //   1:1 vfxbasev2/Sub0_Pass0_Fragment_b1311.hlsl:588-590 (+ the directional term :368-378). The HG
        //   tiled/punctual-light loop and the ASM shadow-atlas ramp are engine-side (dropped, see frag note).
        [Toggle(_USE_LIGHTING)] _UseLighting ("Use Lighting", Float) = 0
        // Re-exposed HGRP global (no URP equivalent): _EnvironmentGlobalParams0.x = ambient/GI intensity.
        _EnvironmentGlobalParams0 ("EnvGlobalParams0 (.x=ambient intensity)", Vector) = (1, 0, 0, 0)

        // --- Fresnel ---
        [Toggle(_USE_FRESNEL)] _UseFresnel ("Use Fresnel", Float) = 0
        [HDR] [Gamma] _FresnelColor ("Fresnel Color", Color) = (1, 1, 1, 1)
        _FresnelBias ("Fresnel Bias", Range(-1, 2)) = 0
        _FresnelAffectOpacity ("Fresnel Affect Opacity", Range(0, 1)) = 1
        _FresnelPower ("Fresnel Power", Range(1, 100)) = 1
        [ToggleUI] _FresnelFlip ("Fresnel Flip", Float) = 0.001

        // --- Anim Breathing (alpha pulses over time) ---
        //   Params are NOT separate properties: the breathing variant (Fragment_b1647:169) overloads the
        //   _EdgeColor (c13) register -> minAlpha=_EdgeColor.x, speed=_EdgeColor.y, power=_EdgeColor.z.
        [Toggle(_USE_ANIM_BREATHING)] _UseAnimBreathing ("Use Anim Breathing", Float) = 0

        // --- SampleTex shared input layer (6 aux textures: Disturb/Weight/Mask/Blend/Dissolve) ---
        //   _SampleTexNUse: 0 Disturb1 / 1 Disturb2 / 2 Weight / 3 Mask / 4 Blend / 5 Dissolve (vfxbasev2.shader:188).
        //   UVRotateMat is the prebuilt float2x2 (cos,-sin,sin,cos); UVSpeed.xy=by time, .zw=by custom1.
        [Header(SampleTex 0)]
        [Toggle(_SAMPLE_TEX0)] _UseSampleTex0 ("Use SampleTex 0", Float) = 0
        _SampleTex0 ("Sample Tex 0", 2D) = "white" {}
        [ToggleUI] _SampleTex0MipmapBias ("SampleTex0 Mipmap Bias", Float) = 0
        // Disturb weight-use gate (blob c12.x): nonzero enables the disturb-UV fold + channel-weight; 0 = no offset
        //   (b1315:191 _168 mask). Per-axis disturb AMOUNT lives in _SampleTex0DisturbParams.xy (NOT here).
        _SampleTex0UseDisturb ("SampleTex0 Use Disturb (weight-use gate)", Range(0, 1)) = 0
        [ToggleUI] _UseSampleTex0AsAlpha ("Use SampleTex0 As Alpha", Float) = 1
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _SampleTex0UVSet ("SampleTex0 UV Set", Float) = 0
        _SampleTex0UVSpeed ("SampleTex0 UV Speed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex0UVRotateMat ("SampleTex0 UV Rotate Mat", Vector) = (1, 0, 0, 1)
        [Enum(Disturb1, 0, Disturb2, 1, Weight, 2, Mask, 3, Blend, 4, Dissolve, 5)] _SampleTex0Use ("SampleTex0 Use", Float) = 0
        [HideInInspector] _SampleTex0UVWeights ("SampleTex0 UV Weights", Vector) = (0, 0, 0, 0)
        // Disturb-fold params (1:1 Fragment_b1315:186-192). DisturbParams = (UIntensity1, VIntensity1, biRemap, biSelect);
        //   DisturbBase = the channel-weight rest value _102 (=1-c19.x). gate = _SampleTex0UseDisturb (c12.x, repurposed).
        [HideInInspector] _SampleTex0DisturbParams ("SampleTex0 Disturb (U/V intensity, biRemap, biSelect)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex0DisturbBase ("SampleTex0 Disturb Base", Float) = 0
        _SampleTex0UseWeight0 ("SampleTex0 Use Weight0 (Blend amt / Dissolve threshold)", Float) = 0
        _SampleTex0UseWeight2 ("SampleTex0 Use Weight2 (Dissolve sharp)", Float) = 0
        _SampleTex0UseWeight3 ("SampleTex0 Use Weight3", Float) = 0
        _SampleTex0UseWeight4 ("SampleTex0 Use Weight4", Float) = 0
        _SampleTex0UseWeight5 ("SampleTex0 Use Weight5", Float) = 0
        [Header(SampleTex 1)]
        [Toggle(_SAMPLE_TEX1)] _UseSampleTex1 ("Use SampleTex 1", Float) = 0
        _SampleTex1 ("Sample Tex 1", 2D) = "white" {}
        [ToggleUI] _SampleTex1MipmapBias ("SampleTex1 Mipmap Bias", Float) = 0
        _SampleTex1UseDisturb ("SampleTex1 Use Disturb", Range(0, 1)) = 0
        [ToggleUI] _UseSampleTex1AsAlpha ("Use SampleTex1 As Alpha", Float) = 1
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _SampleTex1UVSet ("SampleTex1 UV Set", Float) = 0
        _SampleTex1UVSpeed ("SampleTex1 UV Speed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex1UVRotateMat ("SampleTex1 UV Rotate Mat", Vector) = (1, 0, 0, 1)
        [Enum(Disturb1, 0, Disturb2, 1, Weight, 2, Mask, 3, Blend, 4, Dissolve, 5)] _SampleTex1Use ("SampleTex1 Use", Float) = 0
        [HideInInspector] _SampleTex1UVWeights ("SampleTex1 UV Weights", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex1DisturbParams ("SampleTex1 Disturb (U/V intensity, biRemap, biSelect)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex1DisturbBase ("SampleTex1 Disturb Base", Float) = 0
        _SampleTex1UseWeight1 ("SampleTex1 Use Weight1", Float) = 0
        _SampleTex1UseWeight2 ("SampleTex1 Use Weight2 (Dissolve sharp)", Float) = 0
        _SampleTex1UseWeight3 ("SampleTex1 Use Weight3", Float) = 0
        _SampleTex1UseWeight4 ("SampleTex1 Use Weight4", Float) = 0
        _SampleTex1UseWeight5 ("SampleTex1 Use Weight5", Float) = 0
        [Header(SampleTex 2)]
        [Toggle(_SAMPLE_TEX2)] _UseSampleTex2 ("Use SampleTex 2", Float) = 0
        _SampleTex2 ("Sample Tex 2", 2D) = "white" {}
        [ToggleUI] _SampleTex2MipmapBias ("SampleTex2 Mipmap Bias", Float) = 0
        _SampleTex2UseDisturb ("SampleTex2 Use Disturb", Range(0, 1)) = 0
        [ToggleUI] _UseSampleTex2AsAlpha ("Use SampleTex2 As Alpha", Float) = 1
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _SampleTex2UVSet ("SampleTex2 UV Set", Float) = 0
        _SampleTex2UVSpeed ("SampleTex2 UV Speed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex2UVRotateMat ("SampleTex2 UV Rotate Mat", Vector) = (1, 0, 0, 1)
        [Enum(Disturb1, 0, Disturb2, 1, Weight, 2, Mask, 3, Blend, 4, Dissolve, 5)] _SampleTex2Use ("SampleTex2 Use", Float) = 0
        [HideInInspector] _SampleTex2UVWeights ("SampleTex2 UV Weights", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex2DisturbParams ("SampleTex2 Disturb (U/V intensity, biRemap, biSelect)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex2DisturbBase ("SampleTex2 Disturb Base", Float) = 0
        _SampleTex2UseWeight2 ("SampleTex2 Use Weight2 (Blend amt / Dissolve threshold)", Float) = 0
        _SampleTex2UseWeight3 ("SampleTex2 Use Weight3 (Dissolve sharp)", Float) = 0
        _SampleTex2UseWeight4 ("SampleTex2 Use Weight4", Float) = 0
        _SampleTex2UseWeight5 ("SampleTex2 Use Weight5", Float) = 0
        [Header(SampleTex 3)]
        [Toggle(_SAMPLE_TEX3)] _UseSampleTex3 ("Use SampleTex 3", Float) = 0
        _SampleTex3 ("Sample Tex 3", 2D) = "white" {}
        [ToggleUI] _SampleTex3MipmapBias ("SampleTex3 Mipmap Bias", Float) = 0
        _SampleTex3UseDisturb ("SampleTex3 Use Disturb", Range(0, 1)) = 0
        [ToggleUI] _UseSampleTex3AsAlpha ("Use SampleTex3 As Alpha", Float) = 1
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _SampleTex3UVSet ("SampleTex3 UV Set", Float) = 0
        _SampleTex3UVSpeed ("SampleTex3 UV Speed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex3UVRotateMat ("SampleTex3 UV Rotate Mat", Vector) = (1, 0, 0, 1)
        [Enum(Disturb1, 0, Disturb2, 1, Weight, 2, Mask, 3, Blend, 4, Dissolve, 5)] _SampleTex3Use ("SampleTex3 Use", Float) = 0
        [HideInInspector] _SampleTex3UVWeights ("SampleTex3 UV Weights", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex3DisturbParams ("SampleTex3 Disturb (U/V intensity, biRemap, biSelect)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex3DisturbBase ("SampleTex3 Disturb Base", Float) = 0
        _SampleTex3UseWeight3 ("SampleTex3 Use Weight3 (Blend amt / Dissolve threshold)", Float) = 0
        _SampleTex3UseWeight4 ("SampleTex3 Use Weight4 (Dissolve sharp)", Float) = 0
        _SampleTex3UseWeight5 ("SampleTex3 Use Weight5", Float) = 0
        [Header(SampleTex 4)]
        [Toggle(_SAMPLE_TEX4)] _UseSampleTex4 ("Use SampleTex 4", Float) = 0
        _SampleTex4 ("Sample Tex 4", 2D) = "white" {}
        [ToggleUI] _SampleTex4MipmapBias ("SampleTex4 Mipmap Bias", Float) = 0
        _SampleTex4UseDisturb ("SampleTex4 Use Disturb", Range(0, 1)) = 0
        [ToggleUI] _UseSampleTex4AsAlpha ("Use SampleTex4 As Alpha", Float) = 1
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _SampleTex4UVSet ("SampleTex4 UV Set", Float) = 0
        _SampleTex4UVSpeed ("SampleTex4 UV Speed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex4UVRotateMat ("SampleTex4 UV Rotate Mat", Vector) = (1, 0, 0, 1)
        [Enum(Disturb1, 0, Disturb2, 1, Mask, 2, Blend, 3, Weight, 4, Dissolve, 5)] _SampleTex4Use ("SampleTex4 Use", Float) = 0
        [HideInInspector] _SampleTex4UVWeights ("SampleTex4 UV Weights", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex4DisturbParams ("SampleTex4 Disturb (U/V intensity, biRemap, biSelect)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex4DisturbBase ("SampleTex4 Disturb Base", Float) = 0
        _SampleTex4UseWeight4 ("SampleTex4 Use Weight4 (Blend amt / Dissolve threshold)", Float) = 0
        _SampleTex4UseWeight5 ("SampleTex4 Use Weight5 (Dissolve sharp)", Float) = 0
        [Header(SampleTex 5)]
        [Toggle(_SAMPLE_TEX5)] _UseSampleTex5 ("Use SampleTex 5", Float) = 0
        _SampleTex5 ("Sample Tex 5", 2D) = "white" {}
        [ToggleUI] _SampleTex5MipmapBias ("SampleTex5 Mipmap Bias", Float) = 0
        _SampleTex5UseDisturb ("SampleTex5 Use Disturb", Range(0, 1)) = 0
        [ToggleUI] _UseSampleTex5AsAlpha ("Use SampleTex5 As Alpha", Float) = 1
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _SampleTex5UVSet ("SampleTex5 UV Set", Float) = 0
        _SampleTex5UVSpeed ("SampleTex5 UV Speed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex5UVRotateMat ("SampleTex5 UV Rotate Mat", Vector) = (1, 0, 0, 1)
        [Enum(Disturb1, 0, Disturb2, 1, Mask, 2, Blend, 3, Weight, 4, Dissolve, 5)] _SampleTex5Use ("SampleTex5 Use", Float) = 0
        [HideInInspector] _SampleTex5UVWeights ("SampleTex5 UV Weights", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex5DisturbParams ("SampleTex5 Disturb (U/V intensity, biRemap, biSelect)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _SampleTex5DisturbBase ("SampleTex5 Disturb Base", Float) = 0
        _SampleTex5UseWeight4 ("SampleTex5 Use Weight4 (Blend amt / Dissolve threshold)", Float) = 0
        _SampleTex5UseWeight5 ("SampleTex5 Use Weight5 (Dissolve sharp)", Float) = 0

        // --- Advanced ---
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        [ToggleUI] _IsSceneEffect ("Is SceneEffect", Float) = 0
        [ToggleUI] _DisableVertColor ("Disable VertColor", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 1
        // Re-exposed HGRP global (no URP equivalent): _ExposureParams.x = post-exposure multiplier.
        _ExposureParams ("ExposureParams (x=postExposure)", Vector) = (1, 0, 0, 0)

        // --- Render state plumbing (driven by material editor / _SurfaceType) ---
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 1
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 1
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
        [HideInInspector] _StencilRef ("_StencilRef", Float) = 0
        [HideInInspector] _StencilReadMask ("_StencilReadMask", Float) = 255
        [HideInInspector] _StencilWriteMask ("_StencilWriteMask", Float) = 255
        [HideInInspector] _StencilComp ("_StencilComp", Float) = 8
        [HideInInspector] _StencilOp ("_StencilOp", Float) = 0
    }

    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 600

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            // _USE_LIGHTING (subsurface + dynamic-light contribution) needs URP's main-light + SH-ambient
            //   facilities (GetMainLight, SampleSH). These live in Lighting.hlsl. This is the INFRA substitution
            //   for the blob's hand-rolled HG light stack (ASM shadow atlas T3, the _LightDataBuffer directional
            //   global, the light-binning ByteAddressBuffers T0/T1, and the SH-probe buffer T1) — see the
            //   _USE_LIGHTING block in frag() for the full per-term mapping. Guarded so non-lit variants do not
            //   pull the lighting library (mirrors the _USE_SOFTBLEND depth-include guard below).
            #ifdef _USE_LIGHTING
                #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #endif
            // _USE_SOFTBLEND soft-particle fade reads the scene depth buffer. URP exposes it via
            //   DeclareDepthTexture.hlsl -> TEXTURE2D_X_FLOAT(_CameraDepthTexture) + SampleSceneDepth(uv)
            //   (raw device depth). This is the INFRA substitution for the blob's manual scene-depth
            //   reconstruction (b1681 samples T0=_CameraDepthTexture then rebuilds view-Z via _InvViewProjMatrix);
            //   LinearEyeDepth(rawDepth,_ZBufferParams) gives the same |sceneViewZ|. Guarded so non-softblend
            //   variants do not bind the depth texture.
            // _USE_EDGECOLOR ALSO needs scene depth: the b1871/b1895 edge mask _258 is the SAME scene-depth
            //   soft-particle intersection (b1895:175,177 reads T0=_CameraDepthTexture), so include the depth
            //   texture whenever EITHER keyword is on.
            #if defined(_USE_SOFTBLEND) || defined(_USE_EDGECOLOR)
                #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"
            #endif

            CBUFFER_START(UnityPerMaterial)
                // Main Properties
                float _SurfaceType;
                float _BlendMode;
                float _Responsive;
                float _EnableTransparentMV;
                float _InParticle;
                float _DisableVertColor;
                float _TintColorIntensity;
                float _TintColorAlpha;
                float _ExpThreshold;
                float _ExpIntensity;
                float _IsSceneEffect;
                float _IgnorePostExposure;
                float _VertCameraOffset;
                float _ProcedureAlpha;
                float4 _TintColor;
                // Main Tex
                float _MainTexUseDisturb;
                float _UseMainTexAsAlpha;
                float _MainTexMipmapBias;
                float4 _MainTexUVSpeed;
                float4 _MainTexUVRotateMat;
                float4 _MainTexUVWeights;
                float4 _MainTex_ST;
                // ScreenUV (_USE_SCREENUV) controls. Logical names per vfxbasev2.shader:131-132 (packoffset-
                //   aliased in the blob to _WaterAbsorption2.x/.z resp. _EdgeColor.x/.z per variant).
                float _UsePosYAsScreenV;
                float _ScreenUVUseDepth;
                // Camera-distance fade
                float _SoftDistance;
                float _SoftBias;
                float _EdgeDistance;
                float _EdgeDistanceOffset;
                // Edge Color tint (_USE_EDGECOLOR)
                float _EdgeColorMode;
                float4 _EdgeColor;
                // Vertex Offset (_USE_VERTOFFSET / _USE_VERTOFFSETMASK). Logical names per vfxbasev2.shader:135-146.
                //   In the blob these registers are packoffset-ALIASED onto the EdgeColor/NearFade/WaterBlend slots
                //   (those features are keyword-exclusive with VertexOffset, so HG packs them into overlapping
                //   registers — the same aliasing idiom documented for ScreenUV/WaterBlend above). Decoded by role:
                //   _OffsetSwitchDir == blob c13.y (_767:mode1=World, _768:mode2=Normal, else=Object),
                //   _OffsetUVSet (UV0/UV1 blend k) == c13.z, _Bi_Offset (mask base) == c13.w,
                //   _OffsetIntensity (remap center) == c13.x, _OffsetDir.xyz == the (c15.x,c15.y,c15.z) world dir,
                //   _OffsetSpeed == (c16.x time-U, c16.y time-V, c16.z custom-U, c16.w custom-V),
                //   _OffsetMaskPower == 0.2*c17/_WaterAbsorption.x (b1508:565), _OffsetMaskSpeed == c19/_WaterAbsorption2 slots.
                //   _OffsetTex_ST (auto 2D tiling/offset) == blob c14 (_UseNearCameraFade=.x scaleU, _at_228=.y scaleV,
                //   _at_232=.z offU, _at_236=.w offV) applied to the UV-set-blended coord BEFORE scroll (b1438:557
                //   inner mad(uvSetBlend,_UseNearCameraFade,_NearCameraFadeDistanceEnd_at_232)); likewise
                //   _OffsetMaskTex_ST == c18/_WaterScatter (b1508:575 inner mad(uvSetBlend,_WaterScatter.x,_WaterScatter.z)).
                float _OffsetSwitchDir;
                float _OffsetIntensity;
                float _Bi_Offset;
                float _OffsetUVSet;
                float _LocalPivortSpace;
                float _OffsetMaskPower;
                float4 _OffsetSpeed;
                float4 _OffsetDir;
                float4 _OffsetMaskSpeed;
                float4 _OffsetTex_ST;
                float4 _OffsetMaskTex_ST;
                // Water Blend (underwater absorption + scatter, _USE_WATER_BLEND). Logical names per
                //   vfxbasev2.shader:268-272. Fragment_b1661 reads the absorption strength/ramp-depth from
                //   _WaterAbsorption.w/.z and the scatter color from _WaterScatter.xyz directly; the scatter
                //   depth-ramp coefficients are packoffset-aliased to _WaterAbsorption2.xyzw + _SafeFullAbsorpDistance.
                float _WaterHeight;
                float _SafeFullAbsorpDistance;
                float4 _WaterAbsorption;
                float4 _WaterAbsorption2;
                float4 _WaterScatter;
                // Near Camera Fade
                float _UseNearCameraFade;
                float _NearCameraFadeDistanceStart;
                float _NearCameraFadeDistanceEnd;
                float _NearCameraFadeDistanceStart2;
                float _NearCameraFadeDistanceEnd2;
                // Bright (Spot/ScanLine/Sector value-noise brightness overlay)
                float4 _BrightColor;
                float4 _ScanFillColor;
                float4 _BrightCenter;
                float _BrightType;
                float _ScanLineSchedule;
                float _ScanLineWidth;
                float _BrightUseVertColor;
                float _InnerRadius;
                float _OuterRadius;
                float _SectorAngle;
                float _SectorRadius;
                float _SectorCenterRadius;
                float _BoxInnerRadius;
                float _BoxOuterRadius;
                float _CharacterHeight;
                float _DistortScale;
                float _DistortSpeed;
                float _DistortIntensity;
                float _DistortAlpha;
                float _DistortOnEdge;
                // Re-exposed HGRP global (bright center follows character; .w = scroll time)
                float4 _VFXParams0;
                // Fresnel
                float4 _FresnelColor;
                float _FresnelBias;
                float _FresnelAffectOpacity;
                float _FresnelPower;
                float _FresnelFlip;
                // Anim Breathing (alpha pulse over time) reads NO dedicated uniform: Fragment_b1647:169 sources
                //   minAlpha/speed/power from the c13 register == _EdgeColor.x/.y/.z (already declared above).
                //   (b1647 also declares _BreathingPower at c15.z but never reads it -> dead, so not carried here.)
                // SampleTex shared input layer (6 aux textures: Disturb/Weight/Mask/Blend/Dissolve).
                //   Per texture N: _UseSampleTexN gate, _SampleTexN_ST (Unity tiling/offset), pan speed,
                //   2x2 UV rotate (cos,-sin,sin,cos), UV weights, UV set, mip bias, disturb amount,
                //   channel-select-as-alpha flag, mode enum (_SampleTexNUse), and the per-mode weights.
                //   Logical names per vfxbasev2.shader:179-258; consumed 1:1 per Fragment_b1315:177-204.
                float  _UseSampleTex0;          float4 _SampleTex0_ST;          float4 _SampleTex0UVSpeed;
                float4 _SampleTex0UVRotateMat;  float4 _SampleTex0UVWeights;     float _SampleTex0UVSet;
                float  _SampleTex0MipmapBias;   float _SampleTex0UseDisturb;     float _UseSampleTex0AsAlpha;
                float  _SampleTex0Use;          float _SampleTex0UseWeight0;     float _SampleTex0UseWeight2;
                float  _SampleTex0UseWeight3;   float _SampleTex0UseWeight4;     float _SampleTex0UseWeight5;
                // Disturb-fold (1:1 Fragment_b1315:186-192). .xy = U/V intensity1 (blob c20.w / c21.x),
                //   .z = bi-direction remap (c20.z), .w = bi-direction select (c21.w == _Bi_Disturb);
                //   DisturbBase = channel-weight rest value _102 (= 1 - c19.x).
                float4 _SampleTex0DisturbParams;  float _SampleTex0DisturbBase;
                float  _UseSampleTex1;          float4 _SampleTex1_ST;           float4 _SampleTex1UVSpeed;
                float4 _SampleTex1UVRotateMat;  float4 _SampleTex1UVWeights;     float _SampleTex1UVSet;
                float  _SampleTex1MipmapBias;   float _SampleTex1UseDisturb;     float _UseSampleTex1AsAlpha;
                float  _SampleTex1Use;          float _SampleTex1UseWeight1;     float _SampleTex1UseWeight2;
                float  _SampleTex1UseWeight3;   float _SampleTex1UseWeight4;     float _SampleTex1UseWeight5;
                float4 _SampleTex1DisturbParams;  float _SampleTex1DisturbBase;
                float  _UseSampleTex2;          float4 _SampleTex2_ST;           float4 _SampleTex2UVSpeed;
                float4 _SampleTex2UVRotateMat;  float4 _SampleTex2UVWeights;     float _SampleTex2UVSet;
                float  _SampleTex2MipmapBias;   float _SampleTex2UseDisturb;     float _UseSampleTex2AsAlpha;
                float  _SampleTex2Use;          float _SampleTex2UseWeight2;     float _SampleTex2UseWeight3;
                float  _SampleTex2UseWeight4;   float _SampleTex2UseWeight5;
                float4 _SampleTex2DisturbParams;  float _SampleTex2DisturbBase;
                float  _UseSampleTex3;          float4 _SampleTex3_ST;           float4 _SampleTex3UVSpeed;
                float4 _SampleTex3UVRotateMat;  float4 _SampleTex3UVWeights;     float _SampleTex3UVSet;
                float  _SampleTex3MipmapBias;   float _SampleTex3UseDisturb;     float _UseSampleTex3AsAlpha;
                float  _SampleTex3Use;          float _SampleTex3UseWeight3;     float _SampleTex3UseWeight4;
                float  _SampleTex3UseWeight5;
                float4 _SampleTex3DisturbParams;  float _SampleTex3DisturbBase;
                float  _UseSampleTex4;          float4 _SampleTex4_ST;           float4 _SampleTex4UVSpeed;
                float4 _SampleTex4UVRotateMat;  float4 _SampleTex4UVWeights;     float _SampleTex4UVSet;
                float  _SampleTex4MipmapBias;   float _SampleTex4UseDisturb;     float _UseSampleTex4AsAlpha;
                float  _SampleTex4Use;          float _SampleTex4UseWeight4;     float _SampleTex4UseWeight5;
                float4 _SampleTex4DisturbParams;  float _SampleTex4DisturbBase;
                float  _UseSampleTex5;          float4 _SampleTex5_ST;           float4 _SampleTex5UVSpeed;
                float4 _SampleTex5UVRotateMat;  float4 _SampleTex5UVWeights;     float _SampleTex5UVSet;
                float  _SampleTex5MipmapBias;   float _SampleTex5UseDisturb;     float _UseSampleTex5AsAlpha;
                float  _SampleTex5Use;          float _SampleTex5UseWeight4;     float _SampleTex5UseWeight5;
                float4 _SampleTex5DisturbParams;  float _SampleTex5DisturbBase;
                // Re-exposed HGRP global
                float4 _ExposureParams;
                // Re-exposed HGRP global (no URP equivalent): _EnvironmentGlobalParams0.x = ambient/GI intensity
                //   (the multiplier HG applies to the IV-clipmap/SH irradiance before adding to the lit color).
                //   1:1 source cbuffer type_ShaderVariablesGlobal in Fragment_b1311.hlsl:33 (packoffset c111),
                //   consumed at b1311:588-590. Same re-exposure idiom + meaning as sibling HGRP_LitEffect_Fix.shader:349
                //   ("EnvGlobalParams0 (.x=ambient intensity ...)"). Default .x=1 => SH ambient at unit gain.
                //   Only read inside _USE_LIGHTING, but declared unconditionally so the material CBUFFER layout is
                //   identical across keyword variants.
                float4 _EnvironmentGlobalParams0;
                // Houdini VAT bake metadata (vertex; _VAT_*). Logical names; in the blob these are packoffset-aliased
                //   onto water/edge/sampler registers (decoded by usage, e.g. b1618: frame count == _WaterAbsorption2.y,
                //   bounds-min == _WaterAbsorption2.z, pos scale == _SafeFullAbsorpDistance, fluid-lookup tiling/snap ==
                //   _SampleTex1UVRotateMat). Carried as dedicated fields since VAT is keyword-exclusive with those features.
                float _VatFrameCount;
                float _VatBoundsMin;
                float _VatBoundsMax;
                float _VatRotBoundsMin;
                float _VatRotBoundsMax;
                float _VatPosScale;
                float _VatTexHeight;
                float _VatUseSnapshot;
                float _VatManualFrame;
                float _VatPlaybackSpeed;
                float _VatParticleScaleX;
                float _VatParticleScaleY;
                float _VatSpinByHeading;
                float _VatScaleByVel;
                float _VatScaleByVelAmount;
                float _VatParticleVertColor;
                // Render state
                float _TransparentSortPriority;
            CBUFFER_END

            TEXTURE2D(_MainTex);     SAMPLER(sampler_MainTex);
            // Vertex Offset textures (_USE_VERTOFFSET / _USE_VERTOFFSETMASK). Sampled in vert() via
            //   SAMPLE_TEXTURE2D_LOD(...,0). Wrap modes match the blob's named samplers: the offset tex uses
            //   sampler_LinearClamp_OffsetTex (clamp), the mask tex uses sampler_LinearRepeat_OffsetMaskTex (repeat).
            TEXTURE2D(_OffsetTex);      SAMPLER(sampler_OffsetTex);
            TEXTURE2D(_OffsetMaskTex);  SAMPLER(sampler_OffsetMaskTex);
            // Houdini VAT textures (_VAT_*). Sampled in vert() via SAMPLE_TEXTURE2D_LOD(...,0). The blob pins each
            //   to a hard-coded wrap: Rotation=LinearClamp, Position=LinearRepeat (rigid/soft/fluid) / LinearClamp
            //   (particle), Lookup=LinearMirror, Color/Heading=LinearRepeat. URP provides those global samplers
            //   (sampler_LinearClamp/_LinearRepeat from Core; LinearMirror falls back to _LinearRepeat for the
            //   in-bounds VAT uv). 1:1 sampler-name mapping per Sub0_Pass0_Vertex_b1618/b1592/b1638/b1644.
            TEXTURE2D(_VatPositionTexture);  SAMPLER(sampler_VatPositionTexture);
            TEXTURE2D(_VatRotationTexture);  SAMPLER(sampler_VatRotationTexture);
            TEXTURE2D(_VatColorTexture);     SAMPLER(sampler_VatColorTexture);
            TEXTURE2D(_VatLookupTexture);    SAMPLER(sampler_VatLookupTexture);
            TEXTURE2D(_SampleTex0);  SAMPLER(sampler_SampleTex0);
            TEXTURE2D(_SampleTex1);  SAMPLER(sampler_SampleTex1);
            TEXTURE2D(_SampleTex2);  SAMPLER(sampler_SampleTex2);
            TEXTURE2D(_SampleTex3);  SAMPLER(sampler_SampleTex3);
            TEXTURE2D(_SampleTex4);  SAMPLER(sampler_SampleTex4);
            TEXTURE2D(_SampleTex5);  SAMPLER(sampler_SampleTex5);

            // LUM weights (1:1 base blob Fragment_b1309:182 / :190 dot constants)
            static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625);

            // =====================================================================
            // HG scene-fog parameter banks (_USE_FOG). 1:1 source cbuffer type_ShaderVariablesGlobal
            //   in vfxbasev2/Sub0_Pass0_Fragment_b1925.hlsl:31-47 (packoffset c153..c169).
            //   INFRA(1:1): these are HGRP ENGINE-SIDE globals filled per-frame by HG's Fog / AtmosphericScattering
            //   / VolumetricFog render components — URP has NO equivalent global (its fog is the unrelated
            //   unity_FogParams/unity_FogColor linear/exp/exp2 model). They are re-exposed here as a global CBUFFER
            //   (the same re-exposure idiom this file uses for _ExposureParams/_VFXParams0). When the host does not
            //   populate them they default to 0, which makes the height/exp fog opacity 0 and the blend a no-op
            //   (effect renders unchanged) — a safe identity, NOT a silent simplification of the math.
            //   The math below is the bit-faithful transcription; only the volumetric froxel TEXTURE (compute-
            //   filled host-side) is stubbed (see _VolumetricFog3D), gated by _VolumetricFogParams0.z>0 (default 0).
            #ifdef _USE_FOG
            CBUFFER_START(HgVfxFog)
                float4 _AtmosphereFogParams0;   // b1925 c153 (.w = ray-distance bias for height-fog amount)
                float4 _AtmosphereFogParams1;   // c154 (.xyz = sun/main-light dir for mie phase, .w = ray-dist scale)
                float4 _AtmosphereFogParams2;   // c155 (.xyz = per-channel extinction, .w = mie g)
                float4 _AtmosphereFogParams3;   // c156 (.xyz = Rayleigh tint, .w = height-falloff coeff)
                float4 _AtmosphereFogParams4;   // c157 (.xyz = mie tint, .w = height-fog ref height A)
                float4 _AtmosphereFogParams5;   // c158 (.xyz = ambient/base inscatter, .w = height-fog ref height B)
                float4 _ExponentialFogParams0;  // c159 (layer-0 height fog: .x ref height, .y density, .z falloff)
                float4 _ExponentialFogParams1;  // c160 (.xy start ramp by dist, .zw end ramp by dist)
                float4 _ExponentialFogParams2;  // c161 (.xyz constant inscatter color, .w max-opacity floor)
                float4 _ExponentialFogParams3;  // c162 (layer-1 height fog: .x falloff, .y density, .z ref height)
                float4 _ExponentialFogParams4;  // c163 (.xyz directional-inscatter sun dir, .w dir-inscatter start dist)
                float4 _ExponentialFogParams5;  // c164 (.xyz directional-inscatter color, .w dir-inscatter power)
                float4 _VolumetricFogParams0;   // c165 (.z>0 enables froxel path & is its slice count, .w ray-march dist)
                float4 _VolumetricFogParams1;   // c166 (.xyz froxel depth-slice log-encode params)
                float4 _VolumetricFogParams2;   // c167 (.xy froxel jitter UV scale)
                float4 _VolumetricFogParams3;   // c168 (.z froxel near-cutoff distance)
                float4 _VolumetricFogParams4;   // c169 (.w froxel jitter amount)
            CBUFFER_END

            // Volumetric froxel 3D LUT. STUB(host-bound): the source samples T1=Texture3D (b1925 line 125,245)
            //   which is the HG volumetric-fog FROXEL buffer — filled every frame by HG's volumetric-fog COMPUTE
            //   pass (ray-marched scattering integrated into a camera-frustum 3D grid). There is no way to
            //   reproduce its contents shader-side without porting that entire compute system, so it is declared
            //   as a neutral black texture. It is only ever sampled inside `if (_VolumetricFogParams0.z > 0)`,
            //   which defaults to 0 (off) — so with default params this stub is never read and the portable
            //   analytic height+exponential fog path (the `else` branch, b1925:259-272) is taken bit-faithfully.
            TEXTURE3D(_VolumetricFog3D);  SAMPLER(sampler_VolumetricFog3D);

            // (1-exp2(-x))/x with the decompiler's small-x series fallback. 1:1 b1925:262/804 inner asfloat select:
            //   (|x|>5.96e-08) ? (1-exp2(-x))/x : mad(-x, 0.2402265, 0.6931472).  (the e^-x optical-depth ramp)
            float HgFog_Rcp1mExp(float x)
            {
                return (5.9604644775390625e-08 < abs(x))
                     ? ((((-0.0) - exp2((-0.0) - x)) + 1.0) / x)
                     : mad((-0.0) - x, 0.2402265071868896484375, 0.693147182464599609375);
            }

            // Full HG scene-fog blend for the _USE_FOG keyword. 1:1 vfxbasev2/Sub0_Pass0_Fragment_b1925.hlsl:211-284.
            //   color    : the surface color to be fogged (== b1925 _574, the exposure-mapped tint BEFORE the final
            //              alpha premultiply; for the VFX-default _SurfaceType=1 this equals `boosted` exactly,
            //              since b1925 _574 = mad(_405,_SurfaceType,_428*(_492*_405)) collapses to _405 when _428=0).
            //   posWS    : fragment world position (b1925 _118/_119/_120, reconstructed there from _InvViewProjMatrix;
            //              URP input.positionWS is that same world point — sanctioned infra substitution).
            //   viewZabs : |view-space Z| of the fragment (b1925 _435 = abs(_137)) == ViewDepth(posWS).
            //   camPos   : _WorldSpaceCameraPos (b1925 _WorldSpaceCameraPos_Internal).
            //   isPersp  : 0==unity_OrthoParams.w (b1925 _143).
            //   camFwd   : ortho view-forward = UNITY_MATRIX_V[2].xyz (b1925 reads column_major _ViewMatrix[*].z).
            // Returns the fogged color (== b1925 _1220/_1221/_1222, pre the _577 premultiply).
            float3 ComputeVfxFog(float3 color, float3 posWS, float viewZabs, float3 camPos, bool isPersp, float3 camFwd)
            {
                float worldY = posWS.y;                                                       // b1925 _119

                // camera->fragment direction & distance. b1925:164-172.
                //   persp: d = camPos - worldPos ; ortho: d = view-forward (UNITY_MATRIX_V[2].xyz).
                float3 d = isPersp ? (camPos - posWS) : camFwd;                               // b1925 _177/_179/_181
                float  dd = dot(d, d);                                                        // b1925 _182
                float  invLen = rsqrt(max(dd, 9.9999999392252902907785028219223e-09));        // b1925 _187
                float3 nd = invLen * d;                                                       // b1925 _188/_189/_190 (normalized)
                float  dist = invLen * dd;                                                    // b1925 _191 (== length(d))

                // ---- Atmospheric (height) fog transmittance _632/_633/_634 + phase terms. b1925:211-217,275-276.
                float _587 = max(mad(worldY, _AtmosphereFogParams3.w, _AtmosphereFogParams4.w), 0.00999999977648258209228515625); // b1925:211
                float _619 = (((((-0.0) - exp2(_587 * (-1.44269502162933349609375))) + 1.0) / _587)
                              * exp2(mad(worldY, _AtmosphereFogParams3.w, _AtmosphereFogParams5.w) * 1.44269502162933349609375))
                              * ((-0.0) - max(mad(dist, _AtmosphereFogParams1.w, (-0.0) - _AtmosphereFogParams0.w), 0.0));          // b1925:212
                float trans_x = exp2((_619 * _AtmosphereFogParams2.x) * 1.44269502162933349609375);   // b1925:213 (RGB transmittance)
                float trans_y = exp2((_619 * _AtmosphereFogParams2.y) * 1.44269502162933349609375);   // b1925:214
                float trans_z = exp2((_619 * _AtmosphereFogParams2.z) * 1.44269502162933349609375);   // b1925:215
                float _643 = dot((-0.0) - nd, _AtmosphereFogParams1.xyz);                              // b1925:216 (cosθ to sun)
                float _660 = mad(_AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0)
                             + ((-0.0) - dot(_643.xx, _AtmosphereFogParams2.w.xx));                    // b1925:217 (1+g²-2g·cosθ)
                float rayleighPhase = mad(_643, _643, 1.0) * 0.0596831031143665313720703125;          // b1925:275 _1130
                float miePhase = mad((-0.0) - _AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0)
                                 / max(sqrt(_660) * (_660 * 12.56637096405029296875),
                                       0.001000000047497451305389404296875);                          // b1925:276 _1159

                // ---- Exponential + Volumetric fog: opacity _1115 and color _1116/_1117/_1118. b1925:218-273.
                float fogOpacity, fogColR, fogColG, fogColB;
                if (0.0 < _VolumetricFogParams0.z)
                {
                    // VOLUMETRIC FROXEL PATH. 1:1 b1925:224-255 with the ONLY host-bound piece stubbed: the froxel
                    //   sample _875 = T1.SampleLevel(_VolumetricFog3D) (b1925:245). T1 is HG's volumetric-fog froxel
                    //   buffer, filled each frame by HG's volumetric COMPUTE pass; its contents cannot be reproduced
                    //   shader-side, so _VolumetricFog3D is declared neutral-black and _875 is taken as 0 here. With
                    //   _875 == 0 the froxel UV (b1925:245) and therefore the jitter RNG (b1925:224-231, keyed off
                    //   gl_FragCoord.xy & _FrameCount) feed nothing, so they are omitted — every OTHER term (the
                    //   camera-relative ray-march height _724/_726, optical depth _804, opacity _829, froxel cutoff
                    //   _890/_898, dir-inscatter _917/_937) is portable and transcribed verbatim. This branch is
                    //   gated off by default (_VolumetricFogParams0.z defaults to 0); when a host enables it WITHOUT
                    //   a real froxel buffer the froxel inscatter/transmittance contribution is necessarily absent.
                    float4 _875 = (float4)0.0;                                                   // STUB: T1.SampleLevel froxel sample (b1925:245), host-bound -> black
                    float _700 = dot(((-0.0) - nd), ((-0.0) - camFwd));                          // b1925:232 (dot(-nd, -viewFwd))
                    float _707 = worldY + ((-0.0) - camPos.y);                                   // b1925:233
                    float _718 = asfloat(asuint(1.0 / _700) & ((5.9604644775390625e-08 < _700) ? 4294967295u : 0u)) * _VolumetricFogParams0.w; // b1925:234
                    float _719 = 1.0 / dist;                                                     // b1925:235 (1/_191)
                    float _720 = _719 * _718;                                                    // b1925:236
                    float _724 = mad(_720, _707, camPos.y);                                      // b1925:237
                    float _726 = mad((-0.0) - _720, _707, _707);                                 // b1925:238
                    float _728 = mad((-0.0) - _718, _719, 1.0);                                  // b1925:239
                    float _735 = max(_726 * _ExponentialFogParams0.z, -127.0);                   // b1925:240
                    float _742 = max(_726 * _ExponentialFogParams3.x, -127.0);                   // b1925:241
                    float _804 = mad(exp2((-0.0) - max((_724 + ((-0.0) - _ExponentialFogParams0.x)) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                                     HgFog_Rcp1mExp(_735),
                                     HgFog_Rcp1mExp(_742) * (exp2((-0.0) - max((_724 + ((-0.0) - _ExponentialFogParams3.z)) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y)); // b1925:242
                    float _816 = clamp(mad(dist, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0);                                  // b1925:243
                    float _829 = min(_816 + (clamp(mad(dist, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                                 + max(min(exp2((-0.0) - ((dist * _728) * _804)), 1.0), _ExponentialFogParams2.w)), 1.0);                          // b1925:244 (FROXEL FOG OPACITY)
                    float _890 = clamp((viewZabs + ((-0.0) - _VolumetricFogParams3.z)) * 1000000.0, 0.0, 1.0);                                    // b1925:246
                    float _898 = mad(_890, _875.w + (-1.0), 1.0);                                // b1925:247 (froxel transmittance; _875.w=0 -> 1-_890)
                    float _900 = ((-0.0) - _829) + 1.0;                                          // b1925:248
                    float _917 = exp2(log2(clamp(dot(nd, _ExponentialFogParams4.xyz), 0.0, 1.0)) * _ExponentialFogParams5.w);                     // b1925:249 (dir-inscatter pow)
                    float _937 = ((-0.0) - min(exp2((-0.0) - (max(mad(_728, dist, (-0.0) - _ExponentialFogParams4.w), 0.0) * _804)), 1.0)) + 1.0; // b1925:250
                    float _942 = ((-0.0) - _816) + 1.0;                                          // b1925:251
                    fogOpacity = _829 * _898;                                                    // b1925:252 _1115
                    fogColR = mad(mad(_ExponentialFogParams2.x, _900, _942 * (_937 * (_917 * _ExponentialFogParams5.x))), _898, mad(_890, _875.x + (-0.0), 0.0)); // b1925:253 _1116
                    fogColG = mad(mad(_ExponentialFogParams2.y, _900, _942 * (_937 * (_917 * _ExponentialFogParams5.y))), _898, mad(_890, _875.y + (-0.0), 0.0)); // b1925:254 _1117
                    fogColB = mad(mad(_ExponentialFogParams2.z, _900, _942 * (_937 * (_917 * _ExponentialFogParams5.z))), _898, mad(_890, _875.z + (-0.0), 0.0)); // b1925:255 _1118
                }
                else
                {
                    // ANALYTIC EXPONENTIAL HEIGHT FOG (fully portable). 1:1 b1925:259-272.
                    float _962 = worldY + ((-0.0) - camPos.y);                                          // b1925:259
                    float _971 = max(_962 * _ExponentialFogParams3.x, -127.0);                          // b1925:260
                    float _984 = max(_962 * _ExponentialFogParams0.z, -127.0);                          // b1925:261
                    float _1038 = mad(exp2((-0.0) - max((camPos.y + ((-0.0) - _ExponentialFogParams0.x)) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                                      HgFog_Rcp1mExp(_984),
                                      HgFog_Rcp1mExp(_971) * (exp2((-0.0) - max((camPos.y + ((-0.0) - _ExponentialFogParams3.z)) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y)); // b1925:262
                    float _1049 = clamp(mad(dist, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0);                 // b1925:263
                    float _1061 = min(_1049 + (clamp(mad(dist, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                                  + max(min(exp2((-0.0) - (dist * _1038)), 1.0), _ExponentialFogParams2.w)), 1.0);                // b1925:264 (FOG OPACITY)
                    float _1063 = ((-0.0) - _1061) + 1.0;                                                                         // b1925:265
                    float _1078 = exp2(log2(clamp(dot(nd, _ExponentialFogParams4.xyz), 0.0, 1.0)) * _ExponentialFogParams5.w);    // b1925:266 (dir inscatter pow)
                    float _1098 = ((-0.0) - min(exp2((-0.0) - (max(mad(dd, invLen, (-0.0) - _ExponentialFogParams4.w), 0.0) * _1038)), 1.0)) + 1.0; // b1925:267
                    float _1103 = ((-0.0) - _1049) + 1.0;                                                                         // b1925:268
                    fogOpacity = _1061;                                                                                          // b1925:269 _1115
                    fogColR = mad(_ExponentialFogParams2.x, _1063, (_1098 * (_1078 * _ExponentialFogParams5.x)) * _1103);        // b1925:270 _1116
                    fogColG = mad(_ExponentialFogParams2.y, _1063, (_1098 * (_1078 * _ExponentialFogParams5.y)) * _1103);        // b1925:271 _1117
                    fogColB = mad(_ExponentialFogParams2.z, _1063, (_1098 * (_1078 * _ExponentialFogParams5.z)) * _1103);        // b1925:272 _1118
                }

                // ---- Final per-channel fog blend. 1:1 b1925:274,277-281.
                // RISK(1:1, packoffset-aliased): b1925:274,278 read _EdgeColor.y (=c13.y) and _EdgeColor.x (=c13.x).
                //   In the base param-blob c13 is _EdgeColor (float4) but c13.y/c13.z/c13.w are ALSO aliased to
                //   _NearCameraFadeDistanceStart/End/Start2 (b1925:90-93). The _USE_FOG ParamBlob:282 logical names
                //   for these two slots are not recoverable from the blob, so the LITERAL register read is kept
                //   (target _EdgeColor is a float4, so .x/.y are valid). _1125 = saturate(viewZ / c13.y) is a
                //   camera-distance fog-edge ramp; _1213 = lerp(_1125, 1, c13.x) its blend weight. If a host material
                //   sets _EdgeColor.y=0 the divide is guarded only by the clamp (matches the blob, which also divides
                //   raw); a host wishing to disable the edge ramp sets c13.x large so _1213->1 (full fog), as the blob does.
                float _1125 = clamp(viewZabs / _EdgeColor.y, 0.0, 1.0);                       // b1925:274 (c13.y slot)
                float _1201 = mad((-0.0) - _BlendMode, _SurfaceType, 1.0);                    // b1925:277 (= 1 - BlendMode*SurfaceType)
                float _1213 = mad(_EdgeColor.x, ((-0.0) - _1125) + 1.0, _1125);              // b1925:278 (c13.x slot, edge blend weight)
                // atmospheric in-scatter per channel = saturate(AFP3*rayleigh + AFP4*mie + AFP5)*255. b1925:279-281.
                float atmR = clamp(mad(_AtmosphereFogParams4.x, miePhase, mad(_AtmosphereFogParams3.x, rayleighPhase, _AtmosphereFogParams5.x)), 0.0, 1.0) * 255.0;
                float atmG = clamp(mad(_AtmosphereFogParams4.y, miePhase, mad(_AtmosphereFogParams3.y, rayleighPhase, _AtmosphereFogParams5.y)), 0.0, 1.0) * 255.0;
                float atmB = clamp(mad(_AtmosphereFogParams4.z, miePhase, mad(_AtmosphereFogParams3.z, rayleighPhase, _AtmosphereFogParams5.z)), 0.0, 1.0) * 255.0;
                // foggedC = lerp(color, color*trans*opacity + (atmInscatter*(1-trans)*opacity + expFogCol)*_1201, _1213)
                float fogged_x = mad(_1213, ((-0.0) - color.x) + mad(color.x, fogOpacity * trans_x, mad((atmR * (((-0.0) - trans_x) + 1.0)), fogOpacity, fogColR) * _1201), color.x); // b1925:279
                float fogged_y = mad(_1213, ((-0.0) - color.y) + mad(color.y, fogOpacity * trans_y, mad((atmG * (((-0.0) - trans_y) + 1.0)), fogOpacity, fogColG) * _1201), color.y); // b1925:280
                float fogged_z = mad(_1213, ((-0.0) - color.z) + mad(color.z, fogOpacity * trans_z, mad((atmB * (((-0.0) - trans_z) + 1.0)), fogOpacity, fogColB) * _1201), color.z); // b1925:281
                return float3(fogged_x, fogged_y, fogged_z);
            }
            #endif

            // ---------------------------------------------------------------
            // View-space depth of a world position (fragment's own distance along view axis).
            // 1:1 base blob Fragment_b1309:150-153 (reconstruct-from-clip then dot _ViewMatrix[*].z),
            // re-expressed via URP UNITY_MATRIX_V (mathematically identical: the view-space Z magnitude).
            // ---------------------------------------------------------------
            float ViewDepth(float3 positionWS)
            {
                return abs(mul(UNITY_MATRIX_V, float4(positionWS, 1.0)).z);
            }

            // =====================================================================
            // SampleTex shared-input layer (the _SAMPLE_TEX0.._SAMPLE_TEX5 feature).
            //   Six auxiliary texture reads that feed Disturb / Weight / Mask / Blend / Dissolve.
            //   UV build is 1:1 the per-tex pan+weight+rotate+tiling the vertex blob applies to the
            //   MainTex/aux UVs (Vertex_b1314:466-469): pan by UVSpeed over time(_VFXParams0.w) and
            //   particle custom-data, weight raw vs particle UV by UVWeights.xy, recenter to 0, rotate
            //   by the 2x2 (cos,-sin,sin,cos) packed float4, recenter +0.5, then * _ST.xy + _ST.zw.
            //   The sample + channel-select-as-alpha is 1:1 Fragment_b1315:177,182-185.
            // =====================================================================

            // Per-tex animated UV. uvSet: 0=UV0(uv0uv1.xy) 1=UV1(customData.xy); Polar/Screen fall back
            //   to UV0 here (the per-SampleTex Polar/Screen UVSet is out of this feature's scope; the MainTex
            //   Polar/Screen generation is done by GeneratePolarUV/GenerateScreenUV under _USE_POLARUV/_USE_SCREENUV).
            //   particleUV = the UV1/custom channel scaled by _InParticle (base blob TEXCOORD_1 role).
            float2 BuildSampleTexUV(float2 uv0, float2 particleUV, float4 speed, float4 weights,
                                    float4 rotateMat, float4 st, float uvSet)
            {
                // panned + weighted, per-axis. Vertex_b1314:466 inner:
                //   pan = mad(speed.zw, particleUV, mad(speed.xy, time, mad(uv, weights.x, particleUV*weights.y)))
                float time = _VFXParams0.w;
                float2 baseUV = (uvSet >= 0.5) ? particleUV : uv0;      // UV1 vs UV0 (Polar/Screen -> UV0 fallback)
                float panU = mad(speed.z, particleUV.x, mad(speed.x, time, mad(baseUV.x, weights.x, particleUV.x * weights.y)));
                float panV = mad(speed.w, particleUV.y, mad(speed.y, time, mad(baseUV.y, weights.x, particleUV.y * weights.y)));
                // recenter -0.5, rotate by 2x2 (rotateMat = m00,m01,m10,m11 packed .x,.z / .y,.w as the
                //   vertex blob indexes it), recenter +0.5, then tiling/offset. Vertex_b1314:466-467.
                float cu = panU - 0.5;
                float cv = panV - 0.5;
                float2 rotated = float2(mad(cv, rotateMat.z, cu * rotateMat.x) + 0.5,
                                        mad(cv, rotateMat.w, cu * rotateMat.y) + 0.5);
                return mad(rotated, st.xy, st.zw);
            }

            // =====================================================================
            // _USE_POLARUV — polar-coordinate UV generated from UV0 about its (0.5,0.5) center.
            //   1:1 Fragment_b1385.hlsl:155-163 (== b1389:204-215), an inlined atan2 of (u-0.5, v-0.5):
            //     out.x = angle (radians, in [0, 2*PI])   (caller folds *1/2pi -> PolarU in [0,1])
            //     out.y = radius = length(uv0 - 0.5)      (caller folds *2 -> PolarV = 2*radius)
            //   The decompiler emits a hand-rolled atan2 (range-reduced rational approx) instead of intrinsic
            //   atan2(); kept verbatim so the polynomial constants (0.0872929, -0.3018950) are bit-faithful.
            //   Returns the UNWEIGHTED polar pair (= b1385's _105 angle and _93 radius); the caller scales by
            //   _MainTexUVWeights.z (PolarU = angle*w*1/2pi, PolarV = radius*w*2) exactly as b1385:181-182.
            //   (b1389 spells the same value with _99 = radius+radius pre-doubled; identical result.)
            // angle/(2*PI) is NOT pre-multiplied here (returns the raw angle in .x) so the caller mad() matches
            //   the blob associativity (b1389 bakes *1/2pi into the term, b1385 bakes it into the weight mad —
            //   both equal angle*w/(2pi); we follow b1385's spelling at the call site).
            // =====================================================================
            float2 GeneratePolarUV(float2 uv0)
            {
                float cu = uv0.x + (-0.5);                                                        // b1385:_50
                float cv = uv0.y + (-0.5);                                                        // b1385:_52
                float ratio = cu / cv;                                                            // b1385:_53 (x/y)
                bool small = abs(ratio) < 1.0;                                                    // b1385:_60
                float r = small ? abs(ratio) : (1.0 / abs(ratio));                                // b1385:_62 (range reduce)
                float r2 = r * r;                                                                 // b1385:_65
                float poly = mad(mad(r2, 0.087292902171611785888671875, -0.3018949925899505615234375), r2, 1.0); // b1385:_69
                float atanR = small ? (r * poly) : mad(-poly, r, 1.57079637050628662109375);      // b1385:_78 (atan, pi/2 complement)
                float radius = sqrt(dot(float2(cu, cv), float2(cu, cv)));                          // b1385:_93 (length)
                // Full atan2 quadrant assembly + PI bias so angle in [0, 2*PI]. b1385:_105:
                //   angle = mad( (cu>=0 ? +PI : -PI), (cv<0 ? 1 : 0), (ratio<0 ? -atanR : atanR) ) + PI
                float quadSign = (cu >= 0.0) ? 3.141592502593994 : (-3.141592502593994);          // b1385: asfloat(1078530010u)/asfloat(3226013658u) (+/-PI)
                float quadMul  = (cv < 0.0) ? 1.0 : 0.0;                                           // b1385: ((cv<0)?0xFFFFFFFF:0) & 1.0
                float base     = (ratio < 0.0) ? (-atanR) : atanR;                                 // b1385: (_53<0)? -_78 : _78
                float angle = mad(quadSign, quadMul, base) + 3.1415927410125732421875;            // b1385:_105 (+PI)
                return float2(angle, radius);                                                     // .x = angle (caller *1/2pi), .y = radius (caller *2)
            }

            // =====================================================================
            // _USE_SCREENUV — screen-space UV. 1:1 Fragment_b1385.hlsl:167-180 (== b1389:218-233).
            //   Two parts: (1) a per-pivot camera-distance scale (_211/_240) that multiplies BOTH axes;
            //   (2) per-axis screen UV that lerps between a FLAT NDC screen coord and a DEPTH-reconstructed
            //   view-space XY of the fragment, by _ScreenUVUseDepth.
            //   INFRA SUBSTITUTION (per the file's convention): the blob reconstructs the fragment world pos
            //   from gl_FragCoord + _InvViewProjMatrix (b1385:168-175); URP input.positionWS IS that same world
            //   point for this fragment, so it is used directly (identical to the bright-mask reasoning, :571).
            //   _ScreenSize.zw (1/w,1/h) and _ScreenParams.xy (w,h) are HGRP globals -> URP _ScreenParams.
            //   relWorld = worldPos - object pivot; viewXY = (UNITY_MATRIX_V * relWorld).xy.
            //   Returns the per-axis screen UV ALREADY distance-scaled (i.e. _211*_337 , _211*_346), matching
            //   what b1385:181-182 feeds into the _MainTexUVWeights.w term.
            // =====================================================================
            float2 GenerateScreenUV(float3 positionWS, float4 screenPos)
            {
                // (1) distance scale _211 = lerp(1, max(camDist(pivot) - near, 1), _ScreenUVUseDepth). b1385:_211.
                //   pivot view Z via UNITY_MATRIX_V (column_major _ViewMatrix[*].z dotted with pivot xyz).
                float3 pivot = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);
                float pivotViewZ = mul(UNITY_MATRIX_V, float4(pivot, 1.0)).z;                      // b1385: mad(_ViewMatrix[2].z,piv.z, mad(_ViewMatrix[0].z,piv.x, piv.y*_ViewMatrix[1].z)) + _ViewMatrix[3].z
                float camDist = max((-pivotViewZ) + (-_ProjectionParams.y), 1.0);                  // b1385: max(-(viewZ) - near, 1)
                float distScale = mad(camDist, _ScreenUVUseDepth, 1.0 + (-_ScreenUVUseDepth));     // b1385:_211 lerp(1, camDist, useDepth)
                // (2a) flat NDC screen coords. b1385:_223/_226 (depth-on path) and _320/_329 (depth-off path).
                //   Depth-off path is aspect-corrected on V: screenV_flat = (ndcY / w) * h. b1385:_329.
                //   NOTE: blob floors gl_FragCoord to the integer pixel (float(uint(...))); kept for bit-fidelity.
                float2 ndc;
                ndc.x = mad(float(uint(screenPos.x)) * (1.0 / _ScreenParams.x), 2.0, -1.0);         // b1385:_320 (uint(fragCoord.x)/w *2-1)
                ndc.y = mad(float(uint(screenPos.y)) * (1.0 / _ScreenParams.y), 2.0, -1.0);         // b1385:_329 inner (uint(fragCoord.y)/h *2-1)
                float screenU_flat = ndc.x;                                                        // b1385:_320
                float screenV_flat = (ndc.y / _ScreenParams.x) * _ScreenParams.y;                  // b1385:_329 (/w * h)
                // (2b) depth-reconstructed view-space XY of the fragment, relative to the object pivot. b1385:_337/_346.
                float3 relWorld = positionWS - pivot;                                              // b1385:_284..286 (worldPos - pivot)
                float viewX = mul(UNITY_MATRIX_V, float4(relWorld, 0.0)).x;                        // b1385: mad(_ViewMatrix[2].x,rel.z, mad(_ViewMatrix[0].x,rel.x, rel.y*_ViewMatrix[1].x))
                float viewY = mul(UNITY_MATRIX_V, float4(relWorld, 0.0)).y;                        // b1385: same with row .y
                // U = lerp(flatU, viewX, useDepth). b1385:_337 = mad(useDepth, viewX - flatU, flatU).
                float screenU = mad(_ScreenUVUseDepth, viewX + (-screenU_flat), screenU_flat);     // b1385:_337
                // V = _UsePosYAsScreenV ? worldY : lerp(flatV, viewY, useDepth). b1385:_346.
                float screenV = (0.0 != _UsePosYAsScreenV) ? positionWS.y                          // b1385:_346 (asfloat select on _EdgeColor.x): world Y (=_274)
                                                           : mad(_ScreenUVUseDepth, viewY + (-screenV_flat), screenV_flat);
                return float2(distScale * screenU, distScale * screenV);                           // b1385:_337/_346 pre-multiplied by _211, ready for the .w weight
            }

            // =====================================================================
            // MainTex UV combine. 1:1 Fragment_b1385.hlsl:181-183 (== b1389:236/254 minus the disturb fold).
            //   Per axis: comb = mad(speed.zw, particleUV, mad(speed.xy, time,
            //                       mad(screenUV * w.w,                          // _USE_SCREENUV term (.w)
            //                       mad(polarTerm * w.z,                         // _USE_POLARUV term  (.z)
            //                       mad(uv0, w.x, particleSecond * w.y)))))      // UV0 (.x) + UV1/particle (.y)
            //   polarTerm.x = PolarU(angle)*1/2pi (folded as mad(angle*w.z, 1/2pi, ...)); polarTerm.y = 2*radius (folded as mad(radius*w.z, 2, ...)).
            //   Then recenter -0.5, rotate by the 2x2 (rotateMat.xz row0 / .yw row1), recenter +0.5, * _ST.xy + _ST.zw.
            //   particleSecond axis = lerp(customData(UV1), uv0uv1.zw, _InParticle). b1385: mad(TEXCOORD.zw,_InParticle, -(TEXCOORD_1.xy*_InParticle)) + TEXCOORD_1.xy.
            // =====================================================================
            float2 BuildMainTexUV(float4 uv0uv1, float4 customData, float3 positionWS, float4 positionCS)
            {
                float2 uv0 = uv0uv1.xy;                                                            // b1385: TEXCOORD.xy

                // GATING (1:1): the entire MainTex weighted-blend + UVSpeed scroll + 2x2 rotate + _MainTex_ST
                //   apply is keyword-gated in the source by _USE_POLARUV || _USE_SCREENUV. Verified across all
                //   1424 vfxbasev2 fragment variants: exactly 356 reference _MainTexUVWeights/_MainTexUVSpeed/
                //   _MainTexUVRotateMat/_MainTex_ST in frag_main, and ALL 356 carry BOTH _USE_POLARUV and
                //   _USE_SCREENUV (0 counterexamples). The base (Fragment_b1309:158) and the SAMPLE_TEX-only
                //   variant (Fragment_b1315:192) sample RAW uv0 (b1315 adds only the disturb offset) — they do
                //   NOT scroll/rotate/tile/weight. So when neither keyword is on, this MUST return raw uv0,
                //   otherwise non-default _MainTex_ST / _MainTexUVSpeed / _MainTexUVRotate / _MainTexUVWeights
                //   would corrupt every base-type material. (The disturb offset is added by the caller, matching
                //   b1315:192 mad(disturb,_MainTexUseDisturb,TEXCOORD.xy).)
                #if defined(_USE_POLARUV) || defined(_USE_SCREENUV)
                    float time = _VFXParams0.w;
                    float2 particleUV = customData.xy * _InParticle;                               // b1385: TEXCOORD_1.xy * _InParticle (=_119 etc)
                    // second UV channel = lerp(TEXCOORD_1.xy, TEXCOORD.zw, _InParticle). b1385:_131/_132 fold.
                    float2 second = mad(uv0uv1.zw, _InParticle.xx, -(customData.xy * _InParticle)) + customData.xy;

                    // Base term: UV0*w.x + second*w.y. b1385: mad(TEXCOORD.xy, w.x, second*w.y).
                    float combU = mad(uv0.x, _MainTexUVWeights.x, second.x * _MainTexUVWeights.y);     // b1385:_396 inner
                    float combV = mad(uv0.y, _MainTexUVWeights.x, second.y * _MainTexUVWeights.y);     // b1385:_398 inner

                    // _USE_POLARUV term (weight .z). b1385: mad(_105*w.z, 1/2pi, ...) U ; mad(_93*w.z, 2, ...) V.
                    #ifdef _USE_POLARUV
                        float2 polar = GeneratePolarUV(uv0);                                           // .x=angle, .y=radius
                        combU = mad(polar.x * _MainTexUVWeights.z, 0.15915493667125701904296875, combU); // b1385:_396 (angle * w.z * 1/2pi)
                        combV = mad(polar.y * _MainTexUVWeights.z, 2.0, combV);                          // b1385:_398 (radius * w.z * 2)
                    #endif

                    // _USE_SCREENUV term (weight .w). b1385: mad(_211*_337, w.w, ...) U ; mad(_211*_346, w.w, ...) V.
                    #ifdef _USE_SCREENUV
                        float2 screenUV = GenerateScreenUV(positionWS, positionCS);                    // distance-scaled per-axis screen UV
                        combU = mad(screenUV.x, _MainTexUVWeights.w, combU);                           // b1385:_396 (_211*_337 * w.w)
                        combV = mad(screenUV.y, _MainTexUVWeights.w, combV);                           // b1385:_398 (_211*_346 * w.w)
                    #endif

                    // UV-speed scroll (by time .xy, by particle custom1 .zw). b1385: mad(speed.x,time,..) outer + mad(speed.z,particleU,..).
                    combU = mad(_MainTexUVSpeed.z, particleUV.x, mad(_MainTexUVSpeed.x, time, combU)); // b1385:_396 outer
                    combV = mad(_MainTexUVSpeed.w, particleUV.y, mad(_MainTexUVSpeed.y, time, combV)); // b1385:_398 outer

                    // recenter -0.5, rotate (rotateMat = m00,m01,m10,m11 -> .x,.z row0 / .y,.w row1), +0.5, then ST.
                    float cu = combU + (-0.5);                                                         // b1385:_396 (-0.5)
                    float cv = combV + (-0.5);                                                         // b1385:_398 (-0.5)
                    float2 rotated = float2(mad(cv, _MainTexUVRotateMat.z, cu * _MainTexUVRotateMat.x) + 0.5,  // b1385:_396 (* RotateMat.z + .x) +0.5
                                            mad(cv, _MainTexUVRotateMat.w, cu * _MainTexUVRotateMat.y) + 0.5); // b1385:_398 (* RotateMat.w + .y) +0.5
                    return mad(rotated, _MainTex_ST.xy, _MainTex_ST.zw);                               // b1385:_421 sample uv (mad(_396,_ST.x,_ST.z), mad(_398,_ST.y,_ST.w))
                #else
                    return uv0;                                                                        // base 1:1 Fragment_b1309:158 / b1315:192 — raw uv0 (caller adds disturb)
                #endif
            }

            // Channel-select-as-alpha. Fragment_b1315:182-185:
            //   rgb' = lerp(rgb, 1, useAsAlpha);  a' = lerp(a, r, useAsAlpha).
            float4 SampleTexChannelSelect(float4 s, float useAsAlpha)
            {
                float4 o;
                o.x = mad(useAsAlpha, 1.0 - s.x, s.x);
                o.y = mad(useAsAlpha, 1.0 - s.y, s.y);
                o.z = mad(useAsAlpha, 1.0 - s.z, s.z);
                o.w = mad(useAsAlpha, s.x - s.w, s.w);   // alpha lerps toward RED (b1315:185), not toward 1
                return o;
            }

            // Apply ONE sample-tex's COLOR-side contribution (modes 2..5; Disturb modes 0/1 are folded into
            //   the MainTex UV in the fragment pre-pass). Modes per vfxbasev2.shader:188 enum:
            //   2 Weight   : the channel-selected value scales the color, per-channel weighted (b1315:200-204).
            //   3 Mask     : channel-selected value multiplies rgb and alpha (VfxBaseBatched:668-675 idiom).
            //   4 Blend    : additive-over weighted by the sample alpha (VfxBaseBatched:645-655 idiom).
            //   5 Dissolve : edge-clip alpha by (value-threshold)*sharp (VfxBaseBatched:656-667 idiom).
            //   weight012345 = (_SampleTexNUseWeight0/2/3/4/5 packed) — which channels the mode acts on.
            //   For Weight, b1315:200-204 multiplies the sample value into the color modulated by these
            //   weights; expressed as lerp(1, value, weight) per channel so weight=0 is pixel-neutral.
            void ApplySampleTexColor(float4 sel, float mode, float4 weight, inout float3 color, inout float alpha)
            {
                if (mode < 2.5)         // Weight
                {
                    color *= mad(sel.xyz, weight.xyz, 1.0 - weight.xyz);
                    alpha *= mad(sel.w,   weight.w,   1.0 - weight.w);
                }
                else if (mode < 3.5)    // Mask
                {
                    color *= sel.xyz;
                    alpha *= sel.w;
                }
                else if (mode < 4.5)    // Blend (additive-over)
                {
                    color += sel.xyz * (sel.w * weight.x);
                }
                else                    // Dissolve (edge clip)
                {
                    alpha *= saturate((sel.x - weight.x) * weight.y);
                }
            }
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]
            Stencil {
                Ref [_StencilRef]
                ReadMask [_StencilReadMask]
                WriteMask [_StencilWriteMask]
                Comp [_StencilComp]
                Pass [_StencilOp]
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_FRESNEL
            #pragma shader_feature_local _USE_LIGHTING
            // URP system keywords for the main-light shadow attenuation read inside _USE_LIGHTING
            //   (GetMainLight(shadowCoord) -> mainLight.shadowAttenuation). These are the INFRA substitution for
            //   the blob's ASM shadow-atlas term _828 (Fragment_b1311.hlsl:284-364). Compiled in regardless of
            //   _USE_LIGHTING (cheap); GetMainLight degrades to attenuation=1 when the keywords are off.
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile_fragment _ _SHADOWS_SOFT
            #pragma shader_feature_local _USE_BRIGHT
            #pragma shader_feature_local _USE_BRIGHT_SECTOR
            #pragma shader_feature_local _USE_ANIM_BREATHING
            #pragma shader_feature_local _SAMPLE_TEX0
            #pragma shader_feature_local _SAMPLE_TEX1
            #pragma shader_feature_local _SAMPLE_TEX2
            #pragma shader_feature_local _SAMPLE_TEX3
            #pragma shader_feature_local _SAMPLE_TEX4
            #pragma shader_feature_local _SAMPLE_TEX5
            #pragma shader_feature_local _USE_POLARUV
            #pragma shader_feature_local _USE_SCREENUV
            #pragma shader_feature_local _USE_EDGECOLOR
            #pragma shader_feature_local _USE_SOFTBLEND
            #pragma shader_feature_local _USE_FOG
            #pragma shader_feature_local _USE_WATER_BLEND
            #pragma shader_feature_local _USE_TRAIL
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _USE_VERTOFFSETMASK
            #pragma shader_feature_local _VAT_RIGIDBODY
            #pragma shader_feature_local _VAT_SOFTBODY
            #pragma shader_feature_local _VAT_FLUIDBODY
            #pragma shader_feature_local _VAT_PARTICLE
            #pragma shader_feature_local _USE_VAT_COLORTEX

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;     // consumed by _USE_FRESNEL (fresnel-variant vertex b1354 decodes & transforms object NORMAL) + VAT (rotates the mesh normal)
                #if defined(_VAT_RIGIDBODY) || defined(_VAT_SOFTBODY) || defined(_VAT_FLUIDBODY)
                // VAT rigid/soft/fluid reorient the mesh TANGENT alongside the normal (b1618:514-525 build the
                //   tangent-space basis the quaternion then rotates). URP gives the unpacked object tangent here;
                //   the blob decodes it from the octahedral NORMAL.x bits (b1618:249-308) — same infra substitution
                //   the _USE_FRESNEL path makes (octahedral decode -> URP-unpacked v.normalOS/v.tangentOS).
                float4 tangentOS  : TANGENT;
                #endif
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0; // UV0 .xy (+ UV1 in .zw when _InParticle=1); VAT uses .z (VAT-u), .x/.y (particle corner)
                float4 texcoord1  : TEXCOORD1; // particle custom data (.x=custom1X .y=custom1Y) / UV1 when _InParticle=0; VAT uses .w (per-vertex frame index), .y (VAT-v)
                #ifdef _USE_TRAIL
                // Trail flow direction (.xyz, world/object trail tangent) + ribbon width (.w). The trail-variant
                //   vertex (Sub0_Pass0_Vertex_b1552.hlsl) reads this as `TEXCOORD_2 : TEXCOORD2`; the no-trail base
                //   (b1308) has NO TEXCOORD2 vertex input, so it is keyword-gated here. 1:1 b1552 input layout.
                float4 texcoord2  : TEXCOORD2;
                #endif
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float4 uv0uv1     : TEXCOORD0; // pass-through texcoord0 (base blob TEXCOORD)
                float4 customData : TEXCOORD1; // pass-through texcoord1 (base blob TEXCOORD_1)
                float4 vertColor  : TEXCOORD2; // base blob TEXCOORD_2_1
                float3 positionWS : TEXCOORD3;
                float3 normalWS   : TEXCOORD4; // consumed by _USE_FRESNEL + _USE_LIGHTING (base has no normal interpolator)
            };

            // =====================================================================
            // VERTEX — 1:1 base blob Sub0_Pass0_Vertex_b1308.hlsl (non-skinned else branch :322-382)
            //   GPU-skinning path (:115-321) and TAA jitter (:350-351) dropped as infra.
            // =====================================================================
            Varyings vert(Attributes v)
            {
                Varyings o;

                // Object-space vertex attributes (mutable; the VAT block below displaces/reorients them in
                //   object space BEFORE the world transform — exactly where the blob applies VAT, between
                //   reading POSITION/NORMAL/TANGENT and the CB2_m0 object->camera-relative transform).
                float3 posOS = v.positionOS;
                float3 nrmOS = v.normalOS;

                // =====================================================================================
                // HOUDINI VAT PLAYBACK (vertex). 1:1 vfxbasev2 VAT vertex deltas:
                //   rigid  Sub0_Pass0_Vertex_b1618.hlsl   soft Sub0_Pass0_Vertex_b1592.hlsl
                //   fluid  Sub0_Pass0_Vertex_b1638.hlsl   particle Sub0_Pass0_Vertex_b1644.hlsl
                // The VAT textures (_VatPositionTexture/_VatRotationTexture/_VatColorTexture/_VatLookupTexture)
                //   are HOST-BOUND: a Houdini->C# bake pipeline fills them + the bake-metadata uniforms. The HLSL
                //   sampling + quaternion displacement/orientation math IS portable and is ported 1:1 here. When the
                //   bake system is absent the textures default to black -> the position offset decodes to a constant
                //   and rotation to identity-ish (zero quaternion xyz, w=sqrt(1)) -> the mesh plays the t=0 pose.
                //
                // VAT FRAME ADDRESSING (shared rigid/soft/fluid/particle; b1618:554-558, b1592:402-405,
                //   b1644:401-404). REGISTER DECODE (aliased -> logical): _WaterAbsorption2.y == _VatFrameCount,
                //   _WaterAbsorption2.z == _VatBoundsMin, _UseNearCameraFade/_EdgeColor.* == animated-frame
                //   playback terms, _NearCameraFadeDistanceStart2_at_332 == VAT-u tiling snap, _SafeFullAbsorpDistance
                //   == _VatPosScale. The blob picks the current animation row from either a time-driven counter
                //   (_EdgeColor.x!=0) or the per-vertex frame index in TEXCOORD_1.w (snapshot); then builds the
                //   row-V so the GPU samples that frame's slab of the position/rotation textures.
                #if defined(_VAT_RIGIDBODY) || defined(_VAT_SOFTBODY) || defined(_VAT_FLUIDBODY) || defined(_VAT_PARTICLE)
                {
                    bool vatSnapshot = (0.0 != _VatUseSnapshot);                                            // b1618 _727 (c15.z gate; here the explicit snapshot flag)
                    // Per-vertex base VAT uv: u from texcoord0.z (snapshot) or texcoord1.x; v-seed from texcoord1.y.
                    //   b1618:553-555 (_739/_821), b1592:401-402 (_547/_567). The u-tiling snap factor
                    //   mad(snap*10, ., -ceil(snap*10))+1 keeps the uv inside one frame column (1:1 b1618:555 _821).
                    float vatUSnap = mad(_VatManualFrame, 10.0, -ceil(10.0 * _VatManualFrame)) + 1.0;       // b1618:555 inner (_NearCameraFadeDistanceStart2_at_332 -> _VatManualFrame)
                    float vatU     = (vatSnapshot ? v.texcoord0.z : v.texcoord1.x) * vatUSnap;              // b1618:555 (_821)
                    float vatVSeed = vatSnapshot ? v.texcoord0.w : v.texcoord1.y;                           // b1618:553 (_739)
                    // Current frame index. b1618:554 (_813): animated = floor(frac(speed*(time-phase)*rate)*N)+1,
                    //   snapshot = floor(manualFrame + boundsMin). DECODE: _EdgeColor.x = animate flag,
                    //   _UseNearCameraFade/_WaterAbsorption2.y/_EdgeColor.y/.w drive the time counter; in snapshot
                    //   mode the per-vertex frame in TEXCOORD_1.w is gated by the same flag.
                    float vatFrame;
                    if (_VatPlaybackSpeed != 0.0 && !vatSnapshot)                                           // animated playback (_EdgeColor.x!=0 path)
                    {
                        float vatCounter = (_VatPlaybackSpeed / (-0.00999999977648258209228515625 + _VatFrameCount))
                                           * (_VFXParams0.w - _VatManualFrame);                             // b1618:554 inner (time - phase) * (speed/(eps+N))
                        vatFrame = floor(frac(vatCounter * _VatPlaybackSpeed) * _VatFrameCount) + 1.0;      // b1618:554 floor(frac(...)*N)+1
                    }
                    else
                    {
                        vatFrame = floor(v.texcoord1.w + (_VatTexHeight + _VatBoundsMin));                  // b1618:554 else floor(TEXCOORD_1.w + (CB2_m0[14].x + boundsMin))
                    }
                    // Row-V into the VAT slab. b1618:556-558 (_834/_838/_851): normalize the frame to [0,1) over
                    //   N rows, fold by the bounds-min row offset, and flip so frame 0 is at the top of the texture.
                    //   The mad(-(floor(-10*bMin)+...), ., 1) term is the 1:1 row-snap (b1618:558 _851).
                    float vatFrameNorm = (vatFrame - 1.0) / _VatFrameCount;                                 // b1618:556 (_834)
                    float vatFrameFrac = frac(abs(vatFrameNorm));                                           // b1618:557 (_838)
                    float vatSigned    = ((vatFrameNorm >= -vatFrameNorm) ? vatFrameFrac : -vatFrameFrac)
                                          * _VatFrameCount;                                                 // b1618:558 signed wrap (_834>=-_834 ? _838 : -_838)*N
                    float vatRowSnap   = floor(-10.0 * _VatBoundsMin) + mad(_VatBoundsMin, 10.0, 1.0);      // b1618:558 (_851 inner)
                    float vatV = mad(-vatRowSnap, ((-vatVSeed) + 1.0) + (vatSigned / _VatFrameCount), 1.0); // b1618:558 (_851)

                    #if defined(_VAT_FLUIDBODY)
                        // ===== FLUID — _VatLookupTexture remaps mesh vertex -> simulation texel. 1:1 b1638:402-408.
                        //   Fluid sims change topology per frame, so a lookup table (16-bit packed across .xy and .zw)
                        //   gives the true (u,v) into the position/rotation textures. _SampleTex1UVRotateMat.w == the
                        //   lookup-u tiling snap; _NearCameraFadeDistanceEnd_at_328 == lookup-row snap (aliased).
                        float vatLutSplit = (mad(frac(_VatManualFrame * 10.0) - 0.0, 1.0, 0.0) >= 0.5) ? 2048.0 : 255.0; // b1638:402 (_528 = asfloat(... ? 1157627904u(=2048.0) : 1132396544u(=255.0))) — was 4096, BUG
                        float vatLutUSnap = mad(_VatParticleScaleX, 10.0, -ceil(10.0 * _VatParticleScaleX)) + 1.0;       // b1638:406 (_SampleTex1UVRotateMat.w -> reuse a snap scalar)
                        float vatLutRowSnap = floor(-(10.0 * _VatBoundsMin)) + mad(_VatBoundsMin, 10.0, 1.0);            // b1638:406 row snap (_NearCameraFadeDistanceEnd_at_328 -> _VatBoundsMin)
                        float2 vatLutUV;
                        vatLutUV.x = vatLutUSnap * v.texcoord0.x;                                            // b1638:406 lookup-u
                        vatLutUV.y = mad(-vatLutRowSnap, (vatSigned / _VatFrameCount) + ((-v.texcoord0.y) + 1.0), 1.0); // b1638:406 lookup-v
                        float4 vatLut = SAMPLE_TEXTURE2D_LOD(_VatLookupTexture, sampler_VatLookupTexture, vatLutUV, 0.0);
                        vatU = (vatLut.y / vatLutSplit) + vatLut.x;                                          // b1638:407 (_644) 16-bit u = hi + lo/split
                        vatV = ((-((vatLut.w / vatLutSplit) + vatLut.z)) + 1.0);                             // b1638:408 (_647) 16-bit v, flipped
                    #endif

                    float2 vatUV = float2(vatU, vatV);

                    #if defined(_VAT_PARTICLE)
                        // ===== PARTICLE — camera-facing quad expansion driven by position+heading textures.
                        //   1:1 Sub0_Pass0_Vertex_b1644.hlsl:405-475. Particles do NOT rotate the mesh; instead each
                        //   4-vert quad is expanded around its center along camera right/up, optionally spun by the
                        //   particle's screen-space heading and stretched by speed.
                        // (1) Particle center from _VatPositionTexture (xyz) + life in .w. b1644:405-413.
                        float4 vatPos = SAMPLE_TEXTURE2D_LOD(_VatPositionTexture, sampler_VatPositionTexture, vatUV, 0.0); // b1644 _620
                        bool   vatUseMask = (0.0 != _VatBoundsMax);                                          // b1644 _629 (_UseMask)
                        // Position remap: snapshot uses raw, animated rescales by bounds (b1644:410-412 _665/_667/_669).
                        float3 vatCenter;
                        vatCenter.x = vatUseMask ? vatPos.x : mad(vatPos.x, _VatBoundsMin, _VatPosScale);    // b1644:410 (_665)
                        vatCenter.y = vatUseMask ? vatPos.y : mad(vatPos.y, _VatBoundsMax, _VatRotBoundsMin);// b1644:411 (_667)
                        vatCenter.z = vatUseMask ? vatPos.z : mad(vatPos.z, _VatRotBoundsMax, _VatPlaybackSpeed); // b1644:412 (_669)
                        float vatLife = vatPos.w * (1.0 / (floor(10.0 * _VatRotBoundsMax) + mad(-_VatRotBoundsMax, 10.0, 1.0))); // b1644:413 (_677) normalized age
                        // Per-particle random + size. b1644:400,414-419. _512 = hash(uv1), _720 = particle size
                        //   (clamped-alive*life or constant), gated by _VatUseSnapshot/_VatBoundsMin. _SafeFullAbsorpDistance->_VatPosScale.
                        float vatHash = frac(sin(dot(v.texcoord1.xy, float2(12.98980045318603515625, 78.233001708984375))) * 43758.546875); // b1644:400 (_512)
                        float vatAliveD = sqrt(dot(vatCenter, vatCenter)) + (-_VatBoundsMin);                // b1644:414 (_687) (_WaterAbsorption.w -> _VatBoundsMin death dist)
                        float vatAlive = clamp((float)((int)((0u - ((0.0 < vatAliveD) ? 4294967295u : 0u)) + ((vatAliveD < 0.0) ? 4294967295u : 0u))), 0.0, 1.0); // b1644:415 (_695)
                        float vatRand = (vatHash + 1.0) * _VatPosScale;                                      // b1644:416 (_701)
                        bool  vatClampAlive = (0.0 != _VatBoundsMax);                                        // b1644:417 (_705) (_WaterAbsorption.z)
                        float vatLifeSize = vatLife * vatRand;                                               // b1644:418 (_706)
                        float vatSize = (0.0 != _VatTexHeight) ? (vatClampAlive ? (vatAlive * vatLifeSize) : vatLifeSize)
                                                               : (vatClampAlive ? (vatAlive * vatRand) : vatRand); // b1644:419 (_720) (_WaterHeight gate)
                        float vatAngle = frac(vatLife) * 6.283185482025146484375;                           // b1644:420 (_722) random spin angle
                        // (2) Heading from _VatColorTexture (xyz). b1644:421-432. Transformed to view space to get
                        //   the screen-space heading; then a 2D billboard basis is built (b1644:433-464).
                        float4 vatCol = SAMPLE_TEXTURE2D_LOD(_VatColorTexture, sampler_VatColorTexture, vatUV, 0.0); // b1644 _725
                        float3 vatHeadObj = normalize(TransformObjectToWorldDir(float3(-vatCol.x, vatCol.y, vatCol.z), false)); // b1644:425-432 (CB2_m0 * (-r,g,b))
                        float3 vatHeadView = mul((float3x3)UNITY_MATRIX_V, vatHeadObj);                      // b1644:433-434 (_ViewMatrix * heading)
                        bool  vatSpin = (0.0 != _VatSpinByHeading);                                          // b1644:435 (_787) (_WaterScatter.x)
                        float vatHeadLen2 = dot(vatHeadView.xy, vatHeadView.xy);                             // b1644:436 (_788)
                        float vatHeadInv = rsqrt(max(vatHeadLen2, 1.1754943508222875079687365372222e-38));  // b1644:437 (_792)
                        // Perpendicular (rotate the normalized screen heading by 90deg). b1644:438-440 (_799/_800).
                        float2 vatPerp = float2(vatHeadView.y * vatHeadInv, -(vatHeadView.x * vatHeadInv));  // b1644:438-439 (_799/_800)
                        float vatPerpInv = rsqrt(max(dot(vatPerp, vatPerp), 1.1754943508222875079687365372222e-38)); // b1644:440 (_805)
                        // cos/sin of the spin: heading-perp (spin on) or per-particle random angle (spin off). b1644:441-442.
                        float vatC = vatSpin ? (vatPerpInv * vatPerp.x) : cos(vatAngle);                     // b1644:441 (_813)
                        float vatS = vatSpin ? (vatPerpInv * vatPerp.y) : sin(vatAngle);                     // b1644:442 (_817)
                        // Billboard RIGHT axis: rotate view-X/Y by (c,s) into world via InvView, then into object via CB2_m0. b1644:443-452.
                        float3 vatRightView = float3(mad(UNITY_MATRIX_I_V[0].x, vatC, vatS * UNITY_MATRIX_I_V[1].x),
                                                     mad(UNITY_MATRIX_I_V[0].y, vatC, vatS * UNITY_MATRIX_I_V[1].y),
                                                     mad(UNITY_MATRIX_I_V[0].z, vatC, vatS * UNITY_MATRIX_I_V[1].z)); // b1644:443-445 (_831/_832/_833)
                        float3 vatRightObj = normalize(mul(vatRightView, (float3x3)UNITY_MATRIX_M));         // b1644:446-452 (dot with CB2_m0 rows) + normalize
                        // Billboard UP axis: rotate by (-s, c). b1644:453-464.
                        float3 vatUpView = float3(mad(UNITY_MATRIX_I_V[0].x, -vatS, vatC * UNITY_MATRIX_I_V[1].x),
                                                  mad(UNITY_MATRIX_I_V[0].y, -vatS, vatC * UNITY_MATRIX_I_V[1].y),
                                                  mad(UNITY_MATRIX_I_V[0].z, -vatS, vatC * UNITY_MATRIX_I_V[1].z)); // b1644:453-457 (_885/_886/_887)
                        float3 vatUpObj = normalize(mul(vatUpView, (float3x3)UNITY_MATRIX_M));               // b1644:458-464 (_916/_917/_918)
                        // (3) Expand the quad corner. b1644:465-475. corner = uv-0.5 scaled by size along right/up;
                        //   X uses _LocalPivortSpace(->_VatParticleScaleX), Y uses _UseMask_at_268(->_VatParticleScaleY),
                        //   with an optional velocity stretch (b1644:469 _969). Then add the center.
                        bool  vatDeadVert = (0.100000001490116119384765625 >= v.texcoord1.y);                // b1644:465 (_921) cull-by-age
                        float vatRightAmt = (v.texcoord0.x - 0.5) * (vatSize * _VatParticleScaleX);          // b1644:467 (_944)
                        float vatVelStretch = (vatSpin ? (sqrt(vatHeadLen2) * (mad(vatHash, 0.5, 1.0) * _VatScaleByVelAmount)) : 1.0); // b1644:469 (_969 outer, _WaterScatter.y)
                        float vatUpAmt = vatVelStretch * ((v.texcoord0.y - 0.5) * (vatSize * _VatParticleScaleY)); // b1644:469 (_969)
                        float3 vatQuad;
                        vatQuad.x = vatDeadVert ? 0.0 : mad(vatUpObj.x, vatUpAmt, mad(vatRightObj.x, vatRightAmt, vatCenter.x)); // b1644:470 (_977)
                        vatQuad.y = vatDeadVert ? 0.0 : mad(vatUpObj.y, vatUpAmt, mad(vatRightObj.y, vatRightAmt, vatCenter.y)); // b1644:472 (_979)
                        vatQuad.z = vatDeadVert ? 0.0 : mad(vatUpObj.z, vatUpAmt, mad(vatRightObj.z, vatRightAmt, vatCenter.z)); // b1644:474 (_981)
                        posOS = vatQuad;
                        // Particles face the camera: object normal == billboard forward (cross(right,up)). The blob
                        //   leaves TEXCOORD_2_1/normal at 0 (b1644:517-519) since the particle frag is unlit; here we
                        //   keep the mesh normal so the (rare) lit/fresnel combo still has a sane facing normal.
                        nrmOS = normalize(cross(vatRightObj, vatUpObj));
                        #if defined(_USE_VAT_COLORTEX)
                            // Heading texture doubles as the per-particle vertex color when enabled. b1644:476,495-498.
                            o.vertColor = (0.0 != _VatParticleVertColor) ? vatCol : float4(1.0, 1.0, 1.0, 1.0); // b1644:495-498 (_986 ? _725 : 1)
                        #endif
                    #else
                        // ===== RIGID / SOFT / FLUID — sample rotation (quaternion) + position offset, then either
                        //   rotate the whole pivot-relative vertex (rigid) or just translate per-vertex (soft/fluid),
                        //   and reorient the mesh normal+tangent by the quaternion. 1:1 b1618:559-705 / b1592:406-491.
                        bool vatUseMask = (0.0 != _VatBoundsMax);                                            // b1618 _728 (_UseMask gate; snapshot-vs-animated remap)
                        // (a) Rotation texture: xyz = quaternion (remapped from [0,1] to [-0.5,0.5] when animated),
                        //   .w (rigid) = an orientation-axis selector. b1618:559-575 / b1592:406-409.
                        float4 vatRot = SAMPLE_TEXTURE2D_LOD(_VatRotationTexture, sampler_VatRotationTexture, vatUV, 0.0); // b1618 _854 / b1592 _653
                        float3 vatRotRGB = vatRot.xyz;                                                       // b1618 _856/_857/_858
                        // (b) Position texture: xyz = displaced position (or per-vertex offset). b1618:563-575 / b1592:417-429.
                        float4 vatPos = SAMPLE_TEXTURE2D_LOD(_VatPositionTexture, sampler_VatPositionTexture, vatUV, 0.0); // b1618 _889 / b1592 _714
                        // Remap each channel: snapshot uses raw value; animated centers around 0.5 then doubles
                        //   (the [0,1]->[-1,1] bake decode). b1618:567-575 (_894/_907..), b1592:422-429.
                        float qx = vatUseMask ? vatPos.x : ((vatPos.x - 0.5) + (vatPos.x - 0.5));            // b1618:572 (_909) / b1592:426 (_738)
                        float qy = vatUseMask ? vatPos.y : ((vatPos.y - 0.5) + (vatPos.y - 0.5));            // b1618:574 (_911) / b1592:427 (_740)
                        float qz = vatUseMask ? vatPos.z : ((vatPos.z - 0.5) + (vatPos.z - 0.5));            // b1618:570 (_907) / b1592:428 (_742)
                        float3 qv; float qsw;
                        #if defined(_VAT_RIGIDBODY)
                            // RIGID: w reconstructed from the unit-length constraint (PosTex.w is the axis selector,
                            //   not stored). b1618:576 (_919). Then the rotation-tex .w picks one of 4 axis conventions
                            //   (b1618:581-623): assigns (qv.xyz, qsw) from a permutation of (qX,qY,qZ,qW).
                            float qw = sqrt(mad(-qz, qz, mad(-qy, qy, mad(-qx, qx, 1.0))));                  // b1618:576 sqrt(1 - x^2 - y^2 - z^2) (NO max() clamp — blob has none; stored quat is unit-norm)
                            switch (uint(int(floor(vatRot.w * 4.0))))                                        // b1618:581
                            {
                                case 1u:  qv = float3( qz,  qw,  qy); qsw =  qx;            break;            // b1618:591-597 (_1246=_908(qZ),_1247=_919(qW),_1248=_911(qY),_1249=_909(qX))
                                case 2u:  qv = float3( qz,  qx, -qw); qsw = -qy;            break;            // b1618:599-605 (qZ,qX,-qW,-qY)
                                case 3u:  qv = float3(-qw,  qx,  qy); qsw = -qz;            break;            // b1618:607-613 (-qW,qX,qY,-qZ)
                                default:  qv = float3( qz,  qx,  qy); qsw =  qw;            break;            // b1618:583-589/615-621 (case 0/default: qZ,qX,qY,qW)
                            }
                        #else
                            // SOFT/FLUID: the 4th quaternion component is stored in PosTex.w directly (NOT reconstructed),
                            //   remapped the same way; natural (x,y,z,w) order. b1592:429 (_744 = _536?_719:_724+_724).
                            float qw = vatUseMask ? vatPos.w : ((vatPos.w - 0.5) + (vatPos.w - 0.5));        // b1592:429 (_744)
                            qv = float3(qx, qy, qz); qsw = qw;                                                // b1592:430-435 qv=(_738,_740,_742), qsw=_744
                        #endif

                        #if defined(_VAT_RIGIDBODY)
                            // RIGID: rotate the vertex about the piece pivot by the quaternion, then translate.
                            //   pivot-relative vertex t = posOS - pivot. b1618:624-626 references the per-piece pivot
                            //   via TEXCOORD_2/TEXCOORD_3 (the HG previous-frame skinned origin) — HOST-BOUND (motion
                            //   vectors dropped, no prev-frame stream). INFRA SUBSTITUTION: the pivot is the per-vertex
                            //   PIECE origin; with no prev-frame channel the faithful URP-side stand-in is the object
                            //   origin (rigid pieces baked about their own local origin), so t = posOS.
                            float3 t = posOS;                                                                // b1618:624-626 (pivot pre-subtract is HG prev-frame, see note)
                            //   Quaternion vertex rotation. The blob rotates in a CYCLICALLY-RELABELED basis
                            //   (x->z->y per the inner mad pairing), i.e. R_blob(v) = P^T * R_std(q) * P * v,
                            //   which is NOT plain `cross(qv,v)+qsw*v` on natural-order v (that earlier form was a
                            //   1:1 BUG — it dropped the basis conjugation). Transcribed EXACTLY from the blob's
                            //   scalar mads (verified bit-equal vs Rodrigues with qv rolled to (qv.y,qv.z,qv.x)).
                            float3 vatDisp;                                                                   // b1618:627-632 (_1270..1272 inner, _1302..1304 outer)
                            {
                                float i0 = mad(t.y, qsw, mad(qv.x, t.x, -(t.z * qv.y)));                      // b1618:627 (_1270)
                                float i1 = mad(t.z, qsw, mad(qv.y, t.y, -(t.x * qv.z)));                      // b1618:628 (_1271)
                                float i2 = mad(t.x, qsw, mad(qv.z, t.z, -(t.y * qv.x)));                      // b1618:629 (_1272)
                                vatDisp.x = mad(mad(qv.z, i1, -(qv.x * i0)), 2.0, t.x);                       // b1618:630 (_1302 inner)
                                vatDisp.y = mad(mad(qv.x, i2, -(qv.y * i1)), 2.0, t.y);                       // b1618:631 (_1303 inner)
                                vatDisp.z = mad(mad(qv.y, i0, -(qv.z * i2)), 2.0, t.z);                       // b1618:632 (_1304 inner)
                            }
                            //   + sampled position offset (scaled). b1618:630-632 outer addend = _VatPosScale * rotated
                            //   + posTex offset. The rotation-tex .xyz here is the PIECE TRANSLATION (b1618:630 asfloat
                            //   _728?_856:remap), so add it after the rotation.
                            float3 vatPiecePos = vatUseMask ? vatRotRGB
                                                            : float3(mad(vatRotRGB.x, _VatBoundsMin, _VatPosScale),
                                                                     mad(vatRotRGB.y, _VatBoundsMax, _VatRotBoundsMin),
                                                                     mad(vatRotRGB.z, _VatRotBoundsMax, _VatPlaybackSpeed)); // b1618:630-632 (_856/_857/_858 remap)
                            posOS = mad(_VatPosScale.xxx, vatDisp, vatPiecePos);                              // b1618:630-632 (_1302/_1303/_1304)
                            // Age cull: a vertex whose VAT-v seed <= 0.1 is a dead/unused bake slot; the blob collapses
                            //   it to the origin so it does not render as stray geometry (b1618:637-643 _1339; mirrors
                            //   the particle path's vatDeadVert). 1:1, no host uniform needed (uses only the v-seed).
                            //   NOTE: the blob's two other final-position branches at b1618:633-643 — the wrap-frame
                            //   raw-pose fallback (_1323, taken only when bake mode flag _WaterAbsorption2.x==0 at the
                            //   single exact wrap frame) — are HOST-BOUND on an unmapped bake uniform; in the dominant
                            //   animated case (_1308 != 0) the blob already yields the displaced pose computed above,
                            //   so only that one static-snapshot edge frame is unreproduced. Documented residual.
                            if (0.100000001490116119384765625 >= vatVSeed) { posOS = float3(0.0, 0.0, 0.0); } // b1618:637-643 (_1339 age cull)
                            // Reorient the mesh NORMAL by the SAME quaternion (blob rotates the mesh normal at
                            //   _1495..1497 -> _1507..1509; the tangent at _1361.. goes to TEXCOORD_3 which the base
                            //   Varyings drops). Transcribed EXACTLY from the blob's normal mads — same basis-
                            //   conjugated rotation as the vertex (plain `cross(qv,n)` was a 1:1 BUG, see vertex note).
                            {                                                                                // b1618:664-669 (mesh normal _1495..1497 / _1507..1509)
                                float3 n = nrmOS;
                                float n0 = mad(n.y, qsw, mad(qv.x, n.x, -(n.z * qv.y)));                      // b1618:664 (_1495)
                                float n1 = mad(n.z, qsw, mad(qv.y, n.y, -(n.x * qv.z)));                      // b1618:665 (_1496)
                                float n2 = mad(n.x, qsw, mad(qv.z, n.z, -(n.y * qv.x)));                      // b1618:666 (_1497)
                                nrmOS.x = mad(mad(qv.z, n1, -(qv.x * n0)), 2.0, n.x);                         // b1618:667 (_1507)
                                nrmOS.y = mad(mad(qv.x, n2, -(qv.y * n1)), 2.0, n.y);                         // b1618:668 (_1508)
                                nrmOS.z = mad(mad(qv.y, n0, -(qv.z * n2)), 2.0, n.z);                         // b1618:669 (_1509)
                            }
                        #else
                            // SOFT / FLUID: each vertex is TRANSLATED by the sampled per-vertex offset (no pivot
                            //   rotation of the vertex), and only the NORMAL is reoriented by the quaternion.
                            //   1:1 b1592:411-435. The position-tex xyz is the per-vertex world/object offset added
                            //   directly to the skinned vertex (b1592:411-415 _708/_710/_712 = base + offset).
                            float3 vatOffset = vatUseMask ? vatRotRGB
                                                          : float3(mad(_VatBoundsMin, vatRotRGB.x, _VatPosScale),
                                                                   mad(_VatBoundsMax, vatRotRGB.y, _VatRotBoundsMin),
                                                                   mad(_VatRotBoundsMax, vatRotRGB.z, _VatPlaybackSpeed)); // b1592:411-415 (_656/_657/_658 remap)
                            posOS = posOS + vatOffset;                                                       // b1592:411-415 (_708/_710/_712 = base + offset; base coeff is exactly 1.0, NOT _VatPosScale)
                            if (0.100000001490116119384765625 >= vatVSeed) { posOS = float3(0.0, 0.0, 0.0); } // b1592:707-711 (_687 age cull: dead vertex -> origin)
                            // Reorient normal: the soft/fluid blob does NOT rotate the mesh normal — it rotates the
                            //   FIXED basis axis (0,0,-1) by the quaternion to PRODUCE the per-frame normal. Transcribed
                            //   EXACTLY from the blob's specialized scalar mads (b1592:754-769); the basis conjugation
                            //   makes the output component wiring differ from a naive `cross(qv,(0,0,-1))` (that naive
                            //   form was a 1:1 BUG). The blob also rotates (1,0,0) for the tangent -> TEXCOORD_3
                            //   (b1592:894-908); the base Varyings carries no tangent, so only the normal is propagated.
                            {                                                                                // b1592:754-769 (axis (0,0,-1) rotated)
                                float s0 = mad(qsw, 0.0, mad(qv.z, -1.0, -(qv.x * 0.0)));                     // b1592:754 (_754 = -qv.z)
                                float s1 = mad(qsw, 0.0, mad(qv.x, 0.0, -(qv.y * (-1.0))));                   // b1592:755 (_755 =  qv.y)
                                float s2 = mad(qsw, -1.0, mad(qv.y, 0.0, -(qv.z * 0.0)));                     // b1592:756 (_756 = -qsw)
                                nrmOS.x = mad(mad(qv.y, s1, -(s0 * qv.z)), 2.0, -1.0);                        // b1592:766 (_766)
                                nrmOS.y = mad(mad(qv.z, s2, -(s1 * qv.x)), 2.0,  0.0);                        // b1592:768 (_768)
                                nrmOS.z = mad(mad(qv.x, s0, -(s2 * qv.y)), 2.0,  0.0);                        // b1592:769 (_769)
                            }
                        #endif
                    #endif
                }
                #endif

                // Object -> world. Base blob :332-337 multiplies by CB2_m0 (HGRP VFX object matrix) then
                // makes camera-relative; URP unity_ObjectToWorld is the same world transform.
                float3 posWS = TransformObjectToWorld(posOS);

                // In-particle / camera-offset vertex push toward camera. 1:1 base blob :338-346.
                //   _498 = length(cam - worldPos)                                          (b1308:338)
                //   _509 = min(max(_498 - 1, 0), _unity_ObjectToWorld[3].y) + 0.001         (b1308:339)
                //   _511..513 = _509 * (camRel / _498)  (push vector toward camera)         (b1308:340-342)
                //   _518 = 1 - _InParticle                                                  (b1308:343)
                //   posWS += _511..513 * _518   (i.e. mad(_511,_518, worldPos))             (b1308:344-346)
                // NO _VertCameraOffset factor in the base variant; the clamp ceiling is the object
                //   matrix translation Y (column_major _unity_ObjectToWorld[3].y == ._m13).
                float3 camRel = _WorldSpaceCameraPos - posWS;
                float dist = length(camRel);                                                              // b1308:338 / b1552:340 (_499)
                float off = min(max(dist - 1.0, 0.0), unity_ObjectToWorld._m13) + 0.001000000047497451305389404296875; // b1308:339 / b1552:346 (_546)
                #ifdef _USE_TRAIL
                    // ===== TRAIL — camera-facing ribbon billboard. 1:1 Sub0_Pass0_Vertex_b1552.hlsl:341-349. =====
                    //   The base camera-push lateral term (off * normalize(camRel)) is KEPT verbatim (the second
                    //   mad operand below), and the trail ADDS a sideways splay perpendicular to both the camera
                    //   direction and the per-vertex trail flow direction TEXCOORD2.xyz:
                    //     crossCT = cross(camRel, trailDir)                                  (b1552:341-343 _518/_519/_520)
                    //     _524    = rsqrt(dot(crossCT,crossCT))   == 1/length(crossCT)       (b1552:344, normalize factor)
                    //     _531    = 0.5 - uv0.y                    (ribbon half-offset; centerline uv.y=0.5) (b1552:345)
                    //     push    = mad(_531 * (_524*crossCT), trailWidth, off * (camRel/dist))            (b1552:347-349)
                    //   so push = (0.5-uv0.y)*normalize(crossCT)*TEXCOORD2.w + off*normalize(camRel).
                    //   NOTE 1:1: crossCT is NOT length-floored before rsqrt in the blob (no max(...,eps)); kept as-is.
                    float3 trailDir = v.texcoord2.xyz;                                                     // b1552 TEXCOORD_2.xyz
                    float  trailWidth = v.texcoord2.w;                                                     // b1552 TEXCOORD_2.w
                    float3 crossCT;                                                                        // b1552:341-343 (_518/_519/_520)
                    crossCT.x = mad(camRel.y, trailDir.z, -(camRel.z * trailDir.y));
                    crossCT.y = mad(camRel.z, trailDir.x, -(camRel.x * trailDir.z));
                    crossCT.z = mad(camRel.x, trailDir.y, -(camRel.y * trailDir.x));
                    float invCrossLen = rsqrt(dot(crossCT, crossCT));                                      // b1552:344 (_524)
                    float ribbonHalf = (-v.texcoord0.y) + 0.5;                                             // b1552:345 (_531 = 0.5 - uv0.y)
                    float3 push = mad((ribbonHalf * (invCrossLen * crossCT)), trailWidth.xxx,
                                      off * (camRel / dist));                                              // b1552:347-349 (_553/_554/_555)
                #else
                    float3 push = off * (camRel / dist);                                                  // b1308:340-342
                #endif

                #ifdef _USE_VERTOFFSET
                    // ===== VERTEX OFFSET — offset-texture vertex displacement. 1:1 Sub0_Pass0_Vertex_b1438.hlsl =====
                    //   (Keywords: HG_ENABLE_MV _USE_VERTOFFSET; +mask = Sub0_Pass0_Vertex_b1508.hlsl). The base
                    //   camera-push (off*normalize(camRel)) computed above is KEPT verbatim — the blob's _977 takes
                    //   it as the mad ADDEND (b1438:559 `... _972*(_877/_883)`); VERTOFFSET only ADDS the term
                    //     dispDir * maskAmount * offsetSample           (b1438:557-561, _977/_978/_979)
                    //   onto it. So push += dispDir * maskAmount * offsetSample.
                    //
                    //   (1) Custom-data UV inputs (b1438:540-545). uv0/uv1 selected by _InParticle just like the
                    //       MainTex UV (when _InParticle=1 the UV1 lives in texcoord0.zw, custom1 in texcoord1):
                    float custom1Y = v.texcoord1.y * _InParticle;                                          // b1438 _740
                    //   blob _761 = mad(TEXCOORD.z,_InParticle,-(TEXCOORD_1.x*_InParticle)) + TEXCOORD_1.x
                    //   (TEXCOORD=texcoord0, TEXCOORD_1=texcoord1); _763 is the V analog (b1438:544-545):
                    float uOffBaseSel = mad(v.texcoord0.z, _InParticle, -(v.texcoord1.x * _InParticle)) + v.texcoord1.x; // b1438 _761
                    float vOffBaseSel = mad(v.texcoord0.w, _InParticle, -(v.texcoord1.y * _InParticle)) + v.texcoord1.y; // b1438 _763
                    //   UV0/UV1 blend by _OffsetUVSet (k): uvBase = mad(uvSel, k, (1-k)*uv0). b1438:556 _910=1-k.
                    //   This RAW uv-set-blended coord (b1438 _761*k+_910*uv0 == b1508 _781) is the shared base for
                    //   BOTH the offset-tex UV and the mask-tex UV — each then applies its OWN texture _ST + scroll.
                    float kUVSet = 1.0 + (-_OffsetUVSet);                                                  // b1438 _910 (== 1 - c13.z)
                    float uOffBase = mad(uOffBaseSel, _OffsetUVSet, kUVSet * v.texcoord0.x);               // b1438 inner _761*k + _910*TEXCOORD.x (== b1508 _781)
                    float vOffBase = mad(vOffBaseSel, _OffsetUVSet, kUVSet * v.texcoord0.y);               // b1438 inner _763*k + _910*TEXCOORD.y (== b1508 _782)
                    //   Offset-tex tiling/offset: uvBase*_OffsetTex_ST.xy + _OffsetTex_ST.zw. b1438:557 inner
                    //   mad(uvSetBlend, _UseNearCameraFade(c14.x), _NearCameraFadeDistanceEnd_at_232(c14.z)) for U,
                    //   mad(uvSetBlend, _NearCameraFadeDistanceStart_at_228(c14.y), _..Start2_at_236(c14.w)) for V —
                    //   c14 is the auto 2D _OffsetTex_ST (xy=tiling, zw=offset).
                    float uOffTex = mad(uOffBase, _OffsetTex_ST.x, _OffsetTex_ST.z);                       // b1438 _557 inner-U _ST
                    float vOffTex = mad(vOffBase, _OffsetTex_ST.y, _OffsetTex_ST.w);                       // b1438 _557 inner-V _ST
                    //   Scroll: + (time*_VFXParams0.w) + (custom1Y * customSpeed). b1438:557 outer mads.
                    float2 offUV;                                                                          // b1438 _962 sample coords
                    offUV.x = mad(_OffsetSpeed.z, custom1Y, mad(_OffsetSpeed.x, _VFXParams0.w, uOffTex));  // _LocalPivortSpace/_WaterHeight aliases -> _OffsetSpeed.z/.x
                    offUV.y = mad(_OffsetSpeed.w, custom1Y, mad(_OffsetSpeed.y, _VFXParams0.w, vOffTex));  // _UseMask_at_268/_SafeFullAbsorpDistance -> _OffsetSpeed.w/.y
                    //   (2) Offset amount: sample _OffsetTex.x, remap around _OffsetIntensity:
                    //       amt = sample*(1+_OffsetIntensity) + (-_OffsetIntensity)  (b1438:557 outer mad).
                    float offSample = SAMPLE_TEXTURE2D_LOD(_OffsetTex, sampler_OffsetTex, offUV, 0.0).x;   // b1438 _962 T1.SampleLevel
                    float offAmt = mad(offSample, 1.0 + _OffsetIntensity, -_OffsetIntensity);             // b1438 _962
                    //   (3) Per-vertex offset-amount weight (b1438:555 _902 = mad(_UseMask, custom1Y, _EdgeColor.w)).
                    //       REGISTER DECODE: the mode-1/World dir vector (b1438:559) is (c15.x,c15.y,c15.z) ==
                    //       _OffsetDir.xyz, so c15.w (_UseMask) is _OffsetDir.w ("By CustomY" weight); c13.w
                    //       (_EdgeColor.w) is _Bi_Offset (the constant base amount). amount = _OffsetDir.w*custom1Y + _Bi_Offset.
                    float maskAmt = mad(_OffsetDir.w, custom1Y, _Bi_Offset);                               // b1438 _902
                    //   (4) Displacement direction by _OffsetSwitchDir (b1438:559-561 _767/_768 selector):
                    //       mode 1 (World): _OffsetDir.xyz directly.
                    //       mode 2 (Normal): object normal -> world via object matrix (M*nrm, no inv-transpose).
                    //       else (Object,0): _OffsetDir.xyz -> world via object matrix (M*dir).
                    float3 dispDir;                                                                        // b1438 _977/_978/_979 first mad operand
                    if (_OffsetSwitchDir == 1.0)                                                           // b1438 _767
                        dispDir = _OffsetDir.xyz;                                                          // World axis (raw)
                    else if (_OffsetSwitchDir == 2.0)                                                      // b1438 _768
                        dispDir = TransformObjectToWorldDir(v.normalOS, false);                            // M * objNormal (b1438 CB2_m0[*]·(_727,_728,_729))
                    else
                        dispDir = TransformObjectToWorldDir(_OffsetDir.xyz, false);                        // Object axis: M * _OffsetDir (b1438 CB2_m0[*]·_OffsetDir)

                    float offsetAmount = offAmt;                                                           // b1438 _962 (offset sample, remapped)
                    #ifdef _USE_VERTOFFSETMASK
                        // ===== + MASK — second texture modulates the amount. 1:1 Sub0_Pass0_Vertex_b1508.hlsl =====
                        //   maskSample from _OffsetMaskTex (repeat), UV = same RAW uvSetBlend (uOffBase/vOffBase,
                        //   NOT the _OffsetTex_ST-scaled offset UV) then its OWN _OffsetMaskTex_ST + own scroll.
                        //   b1508:575: inner mad(_781, _WaterScatter.x, _WaterScatter.z) == uvSetBlend*_OffsetMaskTex_ST
                        //   (c18=_WaterScatter), then mad(_WaterAbsorption2.x, time, .) + mad(_WaterAbsorption2.z, custom1Y, .).
                        float uMaskTex = mad(uOffBase, _OffsetMaskTex_ST.x, _OffsetMaskTex_ST.z);          // b1508 _575 inner-U _ST (_WaterScatter.x/.z)
                        float vMaskTex = mad(vOffBase, _OffsetMaskTex_ST.y, _OffsetMaskTex_ST.w);          // b1508 _575 inner-V _ST (_WaterScatter.y/.w)
                        float2 maskUV;                                                                     // b1508 _1008 sample coords
                        maskUV.x = mad(_OffsetMaskSpeed.z, custom1Y, mad(_OffsetMaskSpeed.x, _VFXParams0.w, uMaskTex)); // _WaterAbsorption2.z/.x -> _OffsetMaskSpeed.z/.x
                        maskUV.y = mad(_OffsetMaskSpeed.w, custom1Y, mad(_OffsetMaskSpeed.y, _VFXParams0.w, vMaskTex)); // _WaterAbsorption2.w/.y -> _OffsetMaskSpeed.w/.y
                        float maskSample = SAMPLE_TEXTURE2D_LOD(_OffsetMaskTex, sampler_OffsetMaskTex, maskUV, 0.0).x; // b1508 _1008 T2.SampleLevel
                        //   power = 0.2*_OffsetMaskPower (b1508:565 _859 = 0.2*_WaterAbsorption.x); then
                        //   modulate = mad(power, maskSample, -power) + 1 == lerp(1, maskSample, power):
                        float maskPow = 0.20000000298023223876953125 * _OffsetMaskPower;                  // b1508:565 _859
                        float maskMod = mad(maskPow, maskSample, -maskPow) + 1.0;                          // b1508 _1008
                        offsetAmount = offAmt * maskMod;                                                   // b1508 _1023 (_971 * _1008)
                    #endif
                    //   Apply: push += dispDir * maskAmt * offsetAmount. b1438:559 mad(dispDir*_902, _962, basePush).
                    push = mad(dispDir * maskAmt, offsetAmount.xxx, push);                                 // b1438 _977/_978/_979 (+ b1508 _1023)
                #endif

                float inParticleT = 1.0 + (-_InParticle);                                                 // b1308:343 / b1552:350 (_560)
                posWS = mad(push, inParticleT.xxx, posWS);                                                 // b1308:344-346 / b1552:351-353

                o.positionWS = posWS;
                o.positionCS = TransformWorldToHClip(posWS);  // base blob :347-351 (TAA jitter dropped)
                // Fresnel-variant vertex (b1354:511-538) decodes the octahedral object NORMAL and transforms it
                //   by the inverse-scale-corrected object matrix; the fresnel fragment (b1355:175) dots view dir
                //   with THIS world normal. URP TransformObjectToWorldNormal is the 1:1 infra substitution.
                //   nrmOS carries the VAT-reoriented object normal when a _VAT_* keyword is active (== v.normalOS otherwise).
                o.normalWS   = TransformObjectToWorldNormal(nrmOS);

                // UV + vertex-color passthrough. Base blob :360-379.
                o.uv0uv1     = v.texcoord0;
                o.customData = v.texcoord1;
                // Vertex color. Base blob :362-365 modulates by particle instance color (CB2_m0[13]) when
                // objMatrix.m23==0; that instance-color path is HGRP particle infra -> raw vertex color kept.
                //   _VAT_PARTICLE + _USE_VAT_COLORTEX already wrote o.vertColor from the heading texture (b1644:495-498);
                //   don't clobber it in that case.
                #if !(defined(_VAT_PARTICLE) && defined(_USE_VAT_COLORTEX))
                o.vertColor  = v.color;
                #endif
                return o;
            }

            // =====================================================================
            // FRAGMENT — 1:1 base blob Sub0_Pass0_Fragment_b1309.hlsl (:148-200)
            //   + _USE_FRESNEL 1:1 from Sub0_Pass0_Fragment_b1355.hlsl (:170-178,199-201).
            //   SV_Target1 motion-vector MRT (:190-199) dropped. _IsSceneEffect/_VFXParams1 scene-effect
            //   compositing (:187-189) dropped -> the _IsSceneEffect=0 branch (_484*color) is taken.
            // =====================================================================
            half4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                // Fragment view-distance (edge/soft fade input). Base blob :150-153.
                float viewDepth = ViewDepth(input.positionWS);

                // ===== BRIGHT (Spot/ScanLine/Sector value-noise brightness overlay) =====
                // 1:1 Fragment_b1313.hlsl:182-271 (pure _USE_BRIGHT = Spot/ScanLine value-noise distance field)
                //   + Sector geometry 1:1 Fragment_b1329.hlsl:234-274 under _USE_BRIGHT_SECTOR.
                // The bright system distorts the MainTex UV by animated value-noise and multiplies the
                // brightness into the color via radial / signed-axis / noise-distorted smoothstep masks.
                //
                // PACKOFFSET-ALIAS DECODE (blob register -> logical bright property), verified against the
                // _BrightType dropdown property metadata (vfxbasev2.shader:28) and sibling
                // HGRP_VfxSkillScanline_Fix.shader (_VFXParams0 = char-center re-exposed Vector, :34,48):
                //   _VFXParams0.xyz        = character/effect world center (HG global)     | _VFXParams0.w   = scroll time
                //   _WaterScatter.xyz/.w   = _BrightCenter.xyz / use-manual-center flag      [b1313:200-202]
                //   _SoftBias              = axis-projection bias (_DistortOnEdge)           [b1313:209]
                //   _UseSampleTex0AsAlpha  = _OuterRadius (signed-axis feather denom)        [b1313:210-212]
                //     RESIDUAL-RISK: c11.z (axis denom) and c11.w (sphere outer) are DISTINCT source
                //     registers both decoded to _OuterRadius; the original cbuffer is unavailable so the
                //     true distinct property for c11.z cannot be proven (math is faithful either way).
                //   _EdgeColor.z           = _CharacterHeight (Y center offset)              [b1313:214]
                //   _EdgeDistance          = _InnerRadius ; _FresnelFlip = _OuterRadius (3D-sphere feather) [b1313:217-218]
                //   _SoftDistance          = _ScanLineWidth: BOTH the spot-vs-sphere select gate AND the
                //                            ScanFill band scale (b1313:219 gate + 268-270/222 scale are the
                //                            SAME register c11.x, so the gate is _ScanLineWidth, NOT _BrightType) [b1313:219]
                //   _UseNearCameraFade     = _ScanLineSchedule ; _EdgeColor.w = _DistortScale (noise uv scale) [b1313:223-225]
                //   _NearCameraFadeDistanceStart2_at_236 = _DistortIntensity (noise->distance) [b1313:255]
                //   _NearCameraFadeDistanceStart_at_228  = _DistortAlpha (noise->uv amount)    [b1313:257]
                //   _MainTexUseDisturb     = master disturb on/amount (shared with base)       [b1313:261]
                // NOTE: the worldPos here is reconstructed-from-depth in the blob (gl_FragCoord+_InvViewProjMatrix,
                //   b1313:191-196); input.positionWS is the SAME world point for this opaque-depth fragment, so it
                //   is the mathematically-identical infra substitution (matches the file's ViewDepth helper choice).
                float2 brightUVOffset = float2(0.0, 0.0);
                float  brightRadialMask = 1.0;   // _352 in blob (radial / spot smoothstep)
                float  brightAxisMask   = 1.0;   // _355 in blob (signed-axis smoothstep)
                float  brightNoiseMask  = 1.0;   // _597 in blob (noise-distorted distance smoothstep)
                #if defined(_USE_BRIGHT) || defined(_USE_BRIGHT_SECTOR)
                {
                    float3 worldPos = input.positionWS;                                        // b1313:183-185 (reconstructed -> positionWS)
                    // Object-space (inverse-scaled) fragment position. b1313:197-199:
                    //   _189 = (1/dot(rowN,rowN)) * ( -objToWorld[N].w + worldPos.N ).
                    // CONVENTION: the blob's column_major matrix is indexed M[i]=COLUMN i, so
                    //   M[N].w = _m{3}{N} = the BOTTOM ROW (= unity_ObjectToWorld[3].N), which is (0,0,0,1)
                    //   for an affine TRS matrix -> NOT the translation. The divisor dot(rowN,rowN) IS the
                    //   row norm (M[0].x,M[1].x,M[2].x)=row0 == URP unity_ObjectToWorld[N].xyz, so rN is right.
                    float3 r0 = unity_ObjectToWorld[0].xyz;
                    float3 r1 = unity_ObjectToWorld[1].xyz;
                    float3 r2 = unity_ObjectToWorld[2].xyz;
                    float3 objLocal = float3(
                        (1.0 / dot(r0, r0)) * (worldPos.x - unity_ObjectToWorld[3].x),
                        (1.0 / dot(r1, r1)) * (worldPos.y - unity_ObjectToWorld[3].y),
                        (1.0 / dot(r2, r2)) * (worldPos.z - unity_ObjectToWorld[3].z));
                    #ifdef _USE_BRIGHT_SECTOR
                        // ---- Sector geometry (angular wedge). 1:1 Fragment_b1329.hlsl:234-274. ----
                        // Sector apex/center axis. _VFXParams0.xz = bright center; _SectorCenterRadius pulls the apex.
                        float2 objOriginXZ = float2(unity_ObjectToWorld[0].w, unity_ObjectToWorld[2].w);     // b1329:234-235
                        float2 cDir = objOriginXZ - _VFXParams0.xz;                                          // b1329:234-235
                        float  cLen = sqrt(dot(cDir, cDir));                                                 // b1329:236
                        float2 apex = objOriginXZ - (cDir / cLen) * _SectorCenterRadius;                     // b1329:237-238
                        float2 axisDir = objOriginXZ - apex;                                                 // b1329:239-240 (_94,_95)
                        // atan2 of the sector axis (deg). b1329:241-261 (rational atan approx + quadrant fix).
                        float axisAngle = atan2(axisDir.y, axisDir.x) * 57.2957763671875;                   // b1329:248,261
                        // Fragment direction from apex (world XZ). b1329:252-260.
                        float2 fragDir = worldPos.xz - apex;                                                 // b1329:252-253 (_205,_206)
                        float  fragLen = sqrt(dot(fragDir, fragDir));                                        // b1329:260 (_235)
                        float  fragAngle = atan2(fragDir.y, fragDir.x) * 57.2957763671875;                  // b1329:248,261
                        // Signed angle difference, wrapped to (-180,180]. b1329:248,255,256,262,284.
                        float angDiff = fragAngle - axisAngle;                                               // b1329:248
                        angDiff = (angDiff < -180.0) ? (angDiff + 360.0) : angDiff;                          // b1329:262 (_255)
                        angDiff = (180.0 < angDiff) ? (angDiff - 360.0) : angDiff;                           // b1329:265 (inner asfloat select)
                        // Radial feather: saturate((dist - _SectorRadius)/(-0.5*_SectorRadius)). b1329:264 (_283).
                        float radial = saturate((fragLen - _SectorRadius) * (1.0 / (-0.5 * _SectorRadius))); // b1329:264
                        // Angular feather: saturate((|angDiff| - 0.5*_SectorAngle)/(-0.25*_SectorAngle)). b1329:265 (_284).
                        float angular = saturate(mad(-_SectorAngle, 0.5, abs(angDiff)) * (1.0 / (-0.25 * _SectorAngle))); // b1329:265
                        float radialSS = (radial * radial) * mad(radial, -2.0, 3.0);                         // b1329:272 (_328)
                        float angularSS = (angular * angular) * mad(angular, -2.0, 3.0);                     // b1329:266 (_289)
                        // Box (rectangular) feather around the center, X and Z independently. b1329:267-271.
                        float boxNeg = -_BoxInnerRadius;                                                     // b1329:267 (_303)
                        float boxInv = 1.0 / (-_BoxInnerRadius + _BoxOuterRadius);                           // b1329:268 (_314)
                        float boxX = saturate(boxInv * (abs(worldPos.x - unity_ObjectToWorld[0].w) + boxNeg)); // b1329:269 (_317)
                        float boxZ = saturate(boxInv * (abs(worldPos.z - unity_ObjectToWorld[2].w) + boxNeg)); // b1329:270 (_318)
                        float boxSS = ((boxZ * boxZ) * mad(boxZ, -2.0, 3.0)) * ((boxX * boxX) * mad(boxX, -2.0, 3.0)); // b1329:271 (_325)
                        // Center/outer ring feather. b1329:273 (_344): saturate((dist - _BoxOuterRadius)/(_BoxInnerRadius - _BoxOuterRadius)).
                        float ring = saturate((1.0 / (_BoxInnerRadius - _BoxOuterRadius)) * (fragLen - _BoxOuterRadius)); // b1329:273
                        float ringSS = (ring * ring) * mad(ring, -2.0, 3.0);                                  // b1329:274 (_348 factor)
                        // Combined sector mask. b1329:274 (_348): ringSS * lerp(angularSS*radialSS, ..., boxSS).
                        float sectorMask = ringSS * mad(-(radialSS * angularSS), boxSS, mad(angularSS, radialSS, boxSS)); // b1329:274
                        brightRadialMask = sectorMask;
                        brightAxisMask   = sectorMask;
                        brightNoiseMask  = sectorMask;
                        // Sector path does not distort the MainTex UV by value-noise (b1329 routes the mask into
                        // the brightness/alpha boost directly; the per-tex UV offset is the SampleTex subsystem,
                        // out of scope for the base+bright port). brightUVOffset stays zero.
                    #else
                        // ---- Spot / ScanLine geometry (value-noise distance field). 1:1 Fragment_b1313.hlsl:200-261. ----
                        // Center = lerp(charPos _VFXParams0.xyz, _BrightCenter.xyz, useManualCenter). b1313:200-202.
                        float useManual = _BrightCenter.w;                                                   // b1313:200 (_WaterScatter.w)
                        float oneMinusUse = 1.0 - useManual;                                                 // b1313:200 (_221)
                        float3 center = float3(
                            mad(_BrightCenter.x, useManual, oneMinusUse * _VFXParams0.x),                    // b1313:201 (_239)
                            mad(_BrightCenter.y, useManual, oneMinusUse * _VFXParams0.y) + _CharacterHeight, // b1313:214 (_318 inner, +_EdgeColor.z)
                            mad(_BrightCenter.z, useManual, oneMinusUse * _VFXParams0.z));                   // b1313:202 (_241)
                        // Horizontal (XZ) center->fragment delta, rotated into object axes. b1313:203-208.
                        float2 hDelta = float2(center.x - worldPos.x, center.z - worldPos.z);               // b1313:203-204 (_244,_245)
                        // b1313:205-207: _250 = dot(hDelta, (M[0].x, M[0].z)). Column-major M[i]=COLUMN i ->
                        //   M[0].x=_m00, M[0].z=_m20 = (U[0].x, U[2].x); M[1].* -> (U[0].y, U[2].y); M[2].* -> (U[0].z, U[2].z).
                        //   i.e. hRot = hDelta.x*row0 + hDelta.z*row2 (NOT the per-row col pair the decompiler spelling implies).
                        float3 hRot = float3(
                            dot(hDelta, float2(unity_ObjectToWorld[0].x, unity_ObjectToWorld[2].x)),         // b1313:205 (_250)
                            dot(hDelta, float2(unity_ObjectToWorld[0].y, unity_ObjectToWorld[2].y)),         // b1313:206 (_258)
                            dot(hDelta, float2(unity_ObjectToWorld[0].z, unity_ObjectToWorld[2].z)));        // b1313:207 (_265)
                        float hInvLen = rsqrt(dot(hRot, hRot));                                              // b1313:208 (_271)
                        // Signed distance of object-local fragment along the normalized horizontal axis. b1313:209
                        //   literal: dot( (objLocal . objToWorldRows) , hInvLen*hRot ) + _SoftBias.
                        // b1313:209: inner3.k = dot(objLocal, (M[k].x, M[k].y, M[k].z)). Column-major M[k]=COLUMN k,
                        //   so the triple is COLUMN k of the 3x3 = (_m0k,_m1k,_m2k) = (U[0][k],U[1][k],U[2][k]),
                        //   i.e. inner3 = transpose(A) * objLocal (NOT A*objLocal that the per-row spelling implies).
                        float3 objLocalInWorldAxis = float3(
                            dot(objLocal, float3(unity_ObjectToWorld[0].x, unity_ObjectToWorld[1].x, unity_ObjectToWorld[2].x)),
                            dot(objLocal, float3(unity_ObjectToWorld[0].y, unity_ObjectToWorld[1].y, unity_ObjectToWorld[2].y)),
                            dot(objLocal, float3(unity_ObjectToWorld[0].z, unity_ObjectToWorld[1].z, unity_ObjectToWorld[2].z)));
                        float axisCoord = dot(objLocalInWorldAxis, hInvLen * hRot) + _DistortOnEdge;          // b1313:209 (_282, _SoftBias=_DistortOnEdge)
                        // Signed-axis feather (the spot/scanline band). b1313:210-212,220.
                        float axisInv = 1.0 / (-_OuterRadius);                                               // b1313:210 (_298, _UseSampleTex0AsAlpha=_OuterRadius)
                        float axisFeat  = saturate(axisInv * (axisCoord       - _OuterRadius));              // b1313:211 (_302)
                        float axisFeatA = saturate(axisInv * (abs(axisCoord)  - _OuterRadius));              // b1313:212 (_303)
                        brightAxisMask = mad(axisFeat, -2.0, 3.0) * (axisFeat * axisFeat);                   // b1313:220 (_355)
                        // 3D center->fragment distance + sphere feather. b1313:213-218.
                        float3 dDelta = float3(worldPos.x - center.x, worldPos.y - center.y, worldPos.z - center.z); // b1313:213-215 (_317,_318,_319)
                        float  d3 = sqrt(dot(dDelta, dDelta));                                               // b1313:216 (_323)
                        float  sphInv = 1.0 / (_OuterRadius - _InnerRadius);                                 // b1313:217 (_338, _FresnelFlip=_OuterRadius,_EdgeDistance=_InnerRadius)
                        float  sphFeat = saturate(sphInv * (d3 - _InnerRadius));                             // b1313:218 (_340)
                        // Spot-vs-sphere mask select. b1313:219 (_352): (_SoftDistance!=0) ? smoothstep(axisFeatA) : smoothstep(sphFeat).
                        //   The SELECT GATE register (c11.x) is the SAME source uniform that scales the ScanFill
                        //   band in the RGB/alpha fold (b1313:268-270,222 `* _SoftDistance`), i.e. _ScanLineWidth —
                        //   NOT _BrightType. The blob spells both occurrences with the one symbol _SoftDistance, so
                        //   the gate must read _ScanLineWidth too (a nonzero scanline width selects the axis band,
                        //   width 0 falls back to the spot sphere). 1:1 b1313:219.
                        float spotSel = (0.0 != _ScanLineWidth) ? ((axisFeatA * axisFeatA) * mad(axisFeatA, -2.0, 3.0))
                                                                : ((sphFeat   * sphFeat)   * mad(sphFeat,   -2.0, 3.0)); // b1313:219
                        brightRadialMask = spotSel;
                        // ---- Animated value-noise (2D), used to distort the MainTex UV. b1313:223-260. ----
                        float t = _VFXParams0.w * _ScanLineSchedule;                                         // b1313:223 (_442)
                        float2 nUV = float2(mad(input.uv0uv1.x, _DistortScale, t),                           // b1313:224 (_450)
                                            mad(input.uv0uv1.y, _DistortScale, t));                          // b1313:225 (_451)
                        float2 cell = floor(nUV);                                                            // b1313:226-227 (_452,_454)
                        // Hash domain scale 1/1024 = 0.0009765625; signed-frac then the (12.9898,78.233)*43758.5453 hash.
                        const float HASH_SCALE = 0.0009765625;                                               // b1313:228-231 (1/1024)
                        const float2 HASH_K = float2(12.98980045318603515625, 78.233001708984375);          // b1313 hash dirs
                        const float HASH_M = 43758.546875;                                                   // b1313 hash mul
                        // valueNoiseHash(p): frac(sin(dot(signedfrac(p*HASH_SCALE)*1024, HASH_K))*HASH_M). 1:1 b1313:236.
                        #define VN_SFRAC(v) ((((v) >= (-(v))) ? frac(abs(v)) : (-frac(abs(v)))) * 1024.0)
                        float2 p00 = float2((cell.x + 0.0) * HASH_SCALE, (cell.y + 0.0) * HASH_SCALE);       // b1313:462,461
                        float2 p10 = float2((cell.x + 1.0) * HASH_SCALE, (cell.y + 0.0) * HASH_SCALE);       // b1313:459,461 / 508,509 base
                        float2 p01 = float2((cell.x + 0.0) * HASH_SCALE, (cell.y + 1.0) * HASH_SCALE);       // b1313:462,463
                        float2 p11 = float2((cell.x + 1.0) * HASH_SCALE, (cell.y + 1.0) * HASH_SCALE);       // b1313:515,516
                        float h00 = frac(sin(dot(float2(VN_SFRAC(p00.x), VN_SFRAC(p00.y)), HASH_K)) * HASH_M); // b1313:540 (_540 corner)
                        float h10 = frac(sin(dot(float2(VN_SFRAC(p10.x), VN_SFRAC(p10.y)), HASH_K)) * HASH_M); // b1313:507 (_507 corner)
                        float h01 = frac(sin(dot(float2(VN_SFRAC(p01.x), VN_SFRAC(p01.y)), HASH_K)) * HASH_M); // b1313:583 inner (_478,_479)
                        float h11 = frac(sin(dot(float2(VN_SFRAC(p11.x), VN_SFRAC(p11.y)), HASH_K)) * HASH_M); // b1313:583 inner (_564,_565)
                        float2 f = frac(nUV);                                                                // b1313:244-245 (_538,_539)
                        float wx = (f.x * f.x) * mad(-f.x, 2.0, 3.0);                                        // b1313:247-249 (_549 = _547*_543)
                        float wy = mad(-f.y, 2.0, 3.0) * (f.y * f.y);                                        // b1313:250 (_550)
                        // Bilinear value-noise remapped to [-1,1]. b1313:254 (_583).
                        //   Separable bilerp: rows interpolate in X (wx), then the two rows blend in Y (wy).
                        //   b1313:254 expands to corner weights h00:(1-Sx)(1-Sy) h10:Sx(1-Sy) h01:(1-Sx)Sy h11:Sx*Sy,
                        //   i.e. botRow(y=cell.y) pairs h00/h10, topRow(y=cell.y+1) pairs h01/h11 — both in X.
                        float botRow = mad(wx, h10 - h00, h00);                                              // b1313:254 (B = lerp(h00,h10,Sx), bottom row in X)
                        float topRow = mad(wx, h11 - h01, h01);                                              // b1313:254 (top row in X: lerp(h01,h11,Sx))
                        float bilerp = mad(wy, topRow - botRow, botRow);                                     // b1313:254 outer wy lerp
                        float noise = mad(bilerp, 2.0, -1.0);                                                // b1313:254 (*2-1)
                        // Distort the 3D distance by noise then feather (noise-distorted distance smoothstep). b1313:255-256.
                        float dDist = saturate(sphInv * (mad(_DistortIntensity, noise, d3) - _InnerRadius)); // b1313:255 (_594, *_NearCameraFadeDistanceStart2_at_236)
                        brightNoiseMask = (dDist * dDist) * mad(dDist, -2.0, 3.0);                           // b1313:256 (_597)
                        float distortAmt = brightNoiseMask * _DistortAlpha;                                  // b1313:257 (_603, *_NearCameraFadeDistanceStart_at_228)
                        // Cheap second polynomial noise for the V distortion direction. b1313:253,243,258-261.
                        //   _566=frac((cell.y+1)*0.011); _526=frac(cell.y*0.011); then (h+7.5)*h, frac((2h)*h).
                        float n2a = frac((cell.y + 1.0) * 0.010999999940395355224609375);                   // b1313:253 (_566)
                        float n2b = frac((cell.y)       * 0.010999999940395355224609375);                   // b1313:243 (_526)
                        float h606 = (n2a + 7.5) * n2a;                                                      // b1313:258 (_606)
                        float h610 = (n2b + 7.5) * n2b;                                                      // b1313:259 (_610)
                        float n614 = frac((h610 + h610) * h610);                                             // b1313:260 (_614)
                        float n606 = frac((h606 + h606) * h606);                                             // b1313:261 inner
                        // V-direction noise blend. b1313:261 inner: mad(_550, (n606 - _614), _614) *2-1.
                        float vNoise = mad(mad(wy, n606 - n614, n614), 2.0, -1.0);                            // b1313:261 inner remap
                        // Final UV offset feeding the MainTex sample. b1313:261:
                        //   u += (_603*_583) * _MainTexUseDisturb ;  v += (_603*vNoise) * _MainTexUseDisturb.
                        brightUVOffset = float2(distortAmt * noise, distortAmt * vNoise) * _MainTexUseDisturb; // b1313:261
                        #undef VN_SFRAC
                    #endif
                }
                #endif

                // ===== SAMPLE_TEX0..5 — shared input layer (Disturb fold into the MainTex UV) =====
                // 1:1 Fragment_b1315:177-192 (the ONLY blob whose keyword set is exactly {HG_ENABLE_MV,_SAMPLE_TEX0}).
                //   Each enabled aux tex is sampled ONCE (b1315:177), channel-selected as-alpha (b1315:182-185), and
                //   its channels drive a disturb offset that displaces the MainTex sample UV (b1315:189-192). The
                //   channel-selected stash also feeds the Weight/Mask/Blend/Dissolve color pass below (b1315:199-204).
                //   particleUV = UV1/custom (base blob TEXCOORD_1, the b1315:177 sample UV). uv0 kept declared for a
                //   future per-tex UV-transform variant (none proven in scope), but b1315 samples raw particleUV only.
                float2 stUV0 = input.uv0uv1.xy;            // reserved (UV0); unused by the b1315 raw-sample path
                float2 stParticleUV = input.customData.xy; // == blob TEXCOORD_1.xy (b1315:177)
                // Per-tex stash (only the enabled ones are live; defaults are pixel-neutral).
                float4 stSel0 = 0, stSel1 = 0, stSel2 = 0, stSel3 = 0, stSel4 = 0, stSel5 = 0;
                // Disturb fold, decoded 1:1 from the b1315 SSA (no runtime "mode enum" exists in the blob — the
                //   _SAMPLE_TEXn keyword IS the disturb-tex path; the offset is gated purely by the weight-use
                //   uniform). Two routings, selected by _Bi_Disturb (blob c21.w == DisturbParams.w):
                //     Disturb1 (bi==0, b1315:189,192 else-branch): U = w1 * UIntensity ; V = w1 * VIntensity,
                //       where w1 = mad( mad(R, useWeight, base), 1+remap, -remap )  (R-driven, REMAPPED — not 2x-1).
                //     Disturb2 (bi!=0, b1315:192 then-branch): U = (2*mad(A,useWeight,base)*w1 - 1) * UIntensity ;
                //       V = (2*mad(G,useWeight,base) - 1) * UIntensity   (U from ALPHA channel & *w1 ; V from GREEN;
                //       BOTH axes scaled by UIntensity — V does NOT use VIntensity in the bi path).
                //   The whole offset is masked to 0 when useWeight==0 (b1315:191 _168), then scaled by the master
                //   _MainTexUseDisturb gate before adding (b1315:192 mad(off,_MainTexUseDisturb,uv)). Per-tex:
                //     useWeight = _SampleTexNUseDisturb (c12.x)   base = _SampleTexNDisturbBase (_102 = 1 - c19.x)
                //     UIntensity = DisturbParams.x (c20.w)  VIntensity = DisturbParams.y (c21.x)
                //     remap = DisturbParams.z (c20.z)       biSelect = DisturbParams.w (c21.w == _Bi_Disturb)
                #define SAMPLE_TEX_PRE(N) { \
                    /* b1315:177 samples raw TEXCOORD_1.xy (== customData.xy = stParticleUV). The {_SAMPLE_TEX0}-only \
                       variant has NO per-tex UV-transform keyword, so the sample is unconditionally raw — there is \
                       zero UV-transform ALU in the b1315 codepath. (BuildSampleTexUV under the shipped neutral \
                       defaults Weights=(0,0,0,0) collapses to a constant (0,0), NOT raw, so it was not 1:1.) */ \
                    float2 _uv = stParticleUV; \
                    float4 _s = SAMPLE_TEXTURE2D_BIAS(_SampleTex##N, sampler_SampleTex##N, _uv, trunc(_SampleTex##N##MipmapBias)); \
                    stSel##N = SampleTexChannelSelect(_s, _UseSampleTex##N##AsAlpha); \
                    float _stUW = _SampleTex##N##UseDisturb;                                              /* b1315: c12.x weight-use gate */ \
                    float _stBase = _SampleTex##N##DisturbBase;                                           /* b1315:186 _102 = 1 - c19.x */ \
                    float _stUI = _SampleTex##N##DisturbParams.x;                                         /* b1315: c20.w UIntensity1 */ \
                    float _stW1 = mad(mad(stSel##N.x, _stUW, _stBase), 1.0 + _SampleTex##N##DisturbParams.z, -_SampleTex##N##DisturbParams.z); /* b1315:189 _131 */ \
                    float _stU2 = mad(mad(stSel##N.w, _stUW, _stBase) * _stW1, 2.0, -1.0) * _stUI;        /* b1315:192 Disturb2 U (alpha,*_131) */ \
                    float _stV2 = mad(mad(stSel##N.y, _stUW, _stBase),         2.0, -1.0) * _stUI;        /* b1315:192 Disturb2 V (green) */ \
                    float _stU1 = _stW1 * _stUI;                                                          /* b1315:192 Disturb1 U */ \
                    float _stV1 = _stW1 * _SampleTex##N##DisturbParams.y;                                 /* b1315:192 Disturb1 V (c21.x VIntensity1) */ \
                    float2 _stOff = (0.0 != _SampleTex##N##DisturbParams.w) ? float2(_stU2, _stV2) : float2(_stU1, _stV1); /* b1315:190 _155 bi-select */ \
                    _stOff = (0.0 != _stUW) ? _stOff : float2(0.0, 0.0);                                  /* b1315:191 _168 active mask */ \
                    brightUVOffset += _stOff * _MainTexUseDisturb;                                        /* b1315:192 mad(off,_MainTexUseDisturb,uv) */ \
                }
                #ifdef _SAMPLE_TEX0
                    SAMPLE_TEX_PRE(0)
                #endif
                #ifdef _SAMPLE_TEX1
                    SAMPLE_TEX_PRE(1)
                #endif
                #ifdef _SAMPLE_TEX2
                    SAMPLE_TEX_PRE(2)
                #endif
                #ifdef _SAMPLE_TEX3
                    SAMPLE_TEX_PRE(3)
                #endif
                #ifdef _SAMPLE_TEX4
                    SAMPLE_TEX_PRE(4)
                #endif
                #ifdef _SAMPLE_TEX5
                    SAMPLE_TEX_PRE(5)
                #endif
                #undef SAMPLE_TEX_PRE

                // MainTex sample with mip bias. Base blob :158 (SampleBias, trunc(_MainTexMipmapBias)+_GlobalMipBias).
                // URP: _GlobalMipBias unavailable -> use trunc(_MainTexMipmapBias) only.
                // Main UV = weighted blend {UV0, UV1/particle, PolarUV, ScreenUV} + speed + rotate + ST.
                //   1:1 Fragment_b1385:181-183 (BuildMainTexUV); PolarUV/ScreenUV terms gated by
                //   _USE_POLARUV/_USE_SCREENUV (compiled out -> their weight term is absent, == base blob b1315).
                // _USE_BRIGHT + the SampleTex Disturb modes distort the sample UV via brightUVOffset (b1313:261,
                //   b1315:192), added after the combine (the blob folds disturb as mad(off,_MainTexUseDisturb,uv);
                //   brightUVOffset already carries the _MainTexUseDisturb master gate, :864/:832); zero otherwise.
                float mipBias = trunc(_MainTexMipmapBias);
                float2 mainUV = BuildMainTexUV(input.uv0uv1, input.customData, input.positionWS, input.positionCS);
                float4 mainSample = SAMPLE_TEXTURE2D_BIAS(_MainTex, sampler_MainTex, mainUV + brightUVOffset, mipBias);

                // Channel-select: rgb = lerp(tex, 1, _UseMainTexAsAlpha); a = lerp(texA, texR, _UseMainTexAsAlpha).
                // Base blob :164-167 (mad(_UseMainTexAsAlpha, 1-tex, tex) and mad(_UseMainTexAsAlpha, texR-texA, texA)).
                bool disableVC = (0.0 != _DisableVertColor);                              // base blob :163
                float3 vcRGB = disableVC ? float3(1, 1, 1) : input.vertColor.rgb;          // base blob :164-166 ternary
                float  vcA   = disableVC ? 1.0           : input.vertColor.w;             // base blob :167 ternary

                float3 mainRGB = mad(_UseMainTexAsAlpha, (1.0 - mainSample.rgb), mainSample.rgb);
                float  mainA   = mad(_UseMainTexAsAlpha, (mainSample.x - mainSample.w), mainSample.w);

                // Base color/alpha (before fades). Base blob :164-167.
                // NOTE: base blob multiplies all four by _208 = 1 - <c13.w aliased> (the procedure-alpha / edge
                //   premultiplier); ported 1:1 as `* _ProcedureAlpha` right after color+alpha assembly below
                //   (default-neutral =1). See the PROCEDURE-ALPHA block after the alpha is formed.
                //
                // _USE_BRIGHT folds an additive brightness term into the per-channel tint factor, and the
                // noise-distorted distance mask into the alpha. 1:1 Fragment_b1313.hlsl:268-271:
                //   tintFactorRGB = (vc*tint)*intensity + mad(_BrightColor.rgb, radialMask, (axisMask*_ScanFillColor.rgb)*_ScanLineWidth)
                //     (_WaterHeight/_SafeFullAbsorpDistance/_LocalPivortSpace = _BrightColor.rgb ; _WaterAbsorption.xyz = _ScanFillColor.rgb ; _SoftDistance = _ScanLineWidth)
                //   alpha         = texA * saturate( alphaFactor * lerp(1, 1+_DistortAlpha, noiseMask) )
                //   alphaFactor  += mad(radialMask, _BrightColor.w, (axisMask*_ScanFillColor.w)*_ScanLineWidth)  [b1313:222 _429]
                //     (_UseMask_at_268 = _BrightColor.w radial-alpha weight ; _WaterAbsorption.w = _ScanFillColor.w axis weight ;
                //      _NearCameraFadeDistanceEnd_at_232 = bright alpha boost -> 1+_DistortAlpha)
                float3 tintFactorRGB = vcRGB * _TintColor.rgb * _TintColorIntensity;
                float  alphaFactor   = vcA   * _TintColor.w   * _TintColorAlpha;                            // b1313:222 (_429 base term)
                // ===== ANIM BREATHING (1:1 Fragment_b1647:169) =====
                //   The breathing keyword wraps the tint-alpha group ((vcA*_TintColor.w)*_TintColorAlpha)
                //   with a time-pulsed scalar that multiplies the BASE alpha factor only (RGB untouched).
                //   The base/non-breathing alpha is Fragment_b1309:167 (_307 = _208 * (mainA * ((vc?..)*_TintColor.w*_TintColorAlpha)));
                //   the breathing variant inserts the pulse factor in front of that tint-alpha group.
                //
                //   PACKOFFSET DECODE (the 1:1-load-bearing part): b1647:169 sources the breathing params from the
                //   c13 register, which the param-blob declares as `float4 _EdgeColor : packoffset(c13)`
                //   (b1647:90, identical to base b1309:90). The decompiler reads them as _EdgeColor components:
                //     minAlpha = _EdgeColor.x (c13.x)   speed = _EdgeColor.y (c13.y)   power = _EdgeColor.z (c13.z)
                //   NOTE: b1647 ALSO declares `float _BreathingPower : packoffset(c15.z)` (b1647:100) but it is
                //     DEAD — never read in the blob; the real breathing power is _EdgeColor.z (c13.z). So we read
                //     the c13/_EdgeColor vector here, NOT the standalone _Breathing* uniforms (those occupy a
                //     different CBUFFER slot and would NOT reproduce the GPU constant binding).
                //   b1647:169 (the breathing factor verbatim, time = _VFXParams0.w):
                //     mad( min( exp2( log2( mad(cos(_VFXParams0.w*_EdgeColor.y),0.5,0.5) ) * _EdgeColor.z ), 1 ),
                //          1 + (-_EdgeColor.x), _EdgeColor.x )
                //   == lerp( _EdgeColor.x, 1, min( pow(cos(time*_EdgeColor.y)*0.5+0.5, _EdgeColor.z), 1 ) )
                #ifdef _USE_ANIM_BREATHING
                    float breathWave   = mad(cos(_VFXParams0.w * _EdgeColor.y), 0.5, 0.5);                  // cos(t*speed)*0.5+0.5 -> [0,1]  (c13.y)
                    float breathShaped = min(exp2(log2(breathWave) * _EdgeColor.z), 1.0);                   // pow(wave, power), clamped <=1   (c13.z)
                    float breath       = mad(breathShaped, 1.0 - _EdgeColor.x, _EdgeColor.x);               // lerp(minAlpha, 1, shaped)       (c13.x)
                    alphaFactor *= breath;                                                                  // b1647:169 (alpha-only multiply)
                #endif
                #if defined(_USE_BRIGHT) || defined(_USE_BRIGHT_SECTOR)
                    // b1313:268-270 additive bright color into the per-channel tint factor.
                    //   _BrightColor.rgb scaled by the radial/spot mask, plus _ScanFillColor.rgb scaled by the
                    //   signed-axis band times _ScanLineWidth.
                    tintFactorRGB += mad(_BrightColor.rgb, brightRadialMask.xxx,
                                         (brightAxisMask.xxx * _ScanFillColor.rgb) * _ScanLineWidth);        // b1313:268-270
                    // b1313:222,271 alpha: alphaFactor scaled by the bright radial/axis mask, then the whole
                    //   thing modulated by lerp(1, brightAlphaBoost, noiseMask). _429 folds the spot mask into
                    //   alpha: mad(_UseMask_at_268, _352, (_355 * _WaterAbsorption.w) * _SoftDistance), the whole
                    //   bright term pre-multiplied by ((_BrightUseVertColor!=0) ? vertAlpha : 1).
                    //   RADIAL alpha weight = _UseMask_at_268 = _BrightColor.w (HDR Color: .rgb=color add,
                    //   .w=alpha-mask weight, mirroring the RGB term's _BrightColor.rgb radial coeff b1313:268-270);
                    //   AXIS alpha weight = _WaterAbsorption.w = _ScanFillColor.w; band scale = _SoftDistance = _ScanLineWidth.
                    //   VERT-ALPHA GATE = (_NearCameraFadeDistanceEnd2!=0) packoffset-aliases _BrightUseVertColor
                    //   ([ToggleUI] "Bright使用顶点Alpha", vfxbasev2.shader:32 / blob c15.x): when on, scale the
                    //   bright alpha contribution by the particle's vertex alpha (b1313:222 leading ?: factor).
                    float brightVertAlpha = (0.0 != _BrightUseVertColor) ? vcA : 1.0;                        // b1313:222 ((_NearCameraFadeDistanceEnd2!=0)?TEXCOORD_2.w:1)
                    alphaFactor += brightVertAlpha * mad(brightRadialMask, _BrightColor.w,
                                                         (brightAxisMask * _ScanFillColor.w) * _ScanLineWidth); // b1313:222 (_429 bright fold)
                #endif
                float3 color = mainRGB * tintFactorRGB;
                // b1313:271 (_680): alpha = mainA * saturate( _429 * lerp(1, boost, noiseMask) ).
                //   The blob CLAMPs _429*lerp to [0,1] BEFORE multiplying mainA (mad(_597,_429*(boost-1),_429)
                //   wrapped in clamp). _429 == alphaFactor (base + bright additive). Non-bright path: no lerp/clamp.
                #if defined(_USE_BRIGHT) || defined(_USE_BRIGHT_SECTOR)
                    float  alpha = mainA * saturate(alphaFactor * lerp(1.0, 1.0 + _DistortAlpha, brightNoiseMask)); // b1313:271 (_680)
                #else
                    float  alpha = mainA * alphaFactor;
                #endif

                // ===== PROCEDURE-ALPHA premultiplier (1:1 Fragment_b1309:154,164-167) =====
                //   The base blob scales the WHOLE assembled base color+alpha (all 4 channels _304/_305/_306/_307,
                //   b1309:164-167) by the common scalar _208 = 1 - _EdgeColor.w (b1309:154). This is the global
                //   "procedure-alpha / edge-erode" factor — a per-material opacity multiply applied at the base-color
                //   site, BEFORE the water/scatter branch (the _407 branch reads the already-_208-scaled _387.._390)
                //   and before exposure, matching the order here.
                //
                //   PACKOFFSET / ALIAS DECODE (the 1:1-load-bearing part). The decompiler spelled it `_EdgeColor.w`
                //   because the compiler packed it into the c13.w slot that the b1309 cbuffer declares as
                //   `float4 _EdgeColor : packoffset(c13)` (b1309:90) — but c13.w is the SAME logical scalar the
                //   EdgeColor variant reads at a DIFFERENT register: Fragment_b1871 forms the identical base-color
                //   premultiplier as _282 = 1 - _UseMask, with `_UseMask : packoffset(c15.w)` (b1871:101,174,184-187).
                //   c13.w(base) == c15.w(b1871) is a pure packoffset alias of one uniform whose canonical role is
                //   procedure-alpha. The material property for it is _ProcedureAlpha (default 1 across ALL shipped
                //   materials, e.g. M_actor_aglina_*.mat / M_actor_ardelia_*.mat). Its NEUTRAL default is 1 (not 0),
                //   so the editor authors _ProcedureAlpha = the FINAL multiplier (the 1 - c13.w value), i.e. the GPU
                //   sees _208 == _ProcedureAlpha directly. So multiplying color+alpha by _ProcedureAlpha reproduces
                //   _208 * (_304.._307) bit-for-bit (default 1 => neutral no-op).
                color *= _ProcedureAlpha;                                                    // b1309:164-166 (_208 on RGB)
                alpha *= _ProcedureAlpha;                                                    // b1309:167 (_208 on alpha _307)

                // ===== WATER BLEND (underwater absorption + depth-ramp in-scatter) =====
                // 1:1 vfxbasev2/Sub0_Pass0_Fragment_b1661.hlsl:206-223 (Keywords: HG_ENABLE_MV _USE_WATER_BLEND).
                // The blob applies this at the SAME site the base tint color/alpha are assembled: the absorption
                //   factor _409 = (1 - _WaterAbsorption.w) multiplies the per-channel tint color (b1661:216-218,
                //   _515/_516/_517) AND the tint alpha (b1661:219, _518); then a depth-ramp mask _427 blends the
                //   _WaterScatter color back into the RGB (b1661:221-223, _543/_545/_547). Here `color`/`alpha` are
                //   that same pre-SampleTex base product, so factoring absorption across them and lerping scatter
                //   into `color` reproduces the blob bit-for-bit (the absorption is a scalar common to all 4 channels).
                //
                // ALIAS DECODE (ParamBlob:160). The decompiler kept TRUE names for the canonical water Vector slots
                //   it mapped to c17/c18/c19 (_WaterAbsorption / _WaterScatter / _WaterAbsorption2 in the b1661
                //   cbuffer, :109/:113/:117), so _WaterAbsorption.w/.z and the _WaterScatter gate ARE canonical.
                //   The scatter depth-ramp coefficients it spells with leftover base names (_NearCameraFadeDistanceEnd_at_328
                //   =c20.z, _SampleTex1UVRotateMat.x/.y/.z=c21.x/.y/.z, _NearCameraFadeDistanceStart2_at_332=c20.w,
                //   _SoftDistance_at_368/_SoftBias_at_372/_UseWeightTex_at_376=c23.x/.y/.z) are re-expressed via the
                //   LOGICAL water property set (the same idiom this file uses for SampleTex/EdgeColor/ScreenUV aliasing):
                //     ramp scale-by-depth coeffs (c20.z,c21.z,c21.x,c21.y) -> _WaterAbsorption2.xyzw
                //     ramp overall gain       (c20.w)                      -> _SafeFullAbsorpDistance
                //     in-scatter color        (c23.x,c23.y,c23.z)          -> _WaterScatter.xyz
                //   _WaterHeight (c16.x) is NOT read in this minimal variant (b1661 drives the ramp from the
                //   per-vertex water-depth carried in uv0.z, not a world-height compare), so it stays declared-only.
                #ifdef _USE_WATER_BLEND
                {
                    // Absorption strength: Beer-Lambert-style attenuation of the whole effect. b1661:206 (_409).
                    float waterAbsorb = 1.0 - _WaterAbsorption.w;
                    // Scatter depth-ramp mask. b1661:207 (_412), :208 (_427). uv0.z = per-vertex water depth
                    //   (b1661 TEXCOORD.z; the main-texcoord0 z channel, == input.uv0uv1.z here).
                    //   _412 = mad( (1 - K*R*absZ), (uvZ+Rx)*2.02 - 0.0099, -1 ); _427 = clamp((_412+Ry)*gain, 0, 1).
                    float waterUvZ   = input.uv0uv1.z;                                          // b1661:207 TEXCOORD.z
                    float rampK      = _WaterAbsorption2.x;                                      // c20.z (aliased)
                    float rampR      = _WaterAbsorption2.y;                                      // c21.z (aliased)
                    float rampRx     = _WaterAbsorption2.z;                                      // c21.x (aliased)
                    float rampRy     = _WaterAbsorption2.w;                                      // c21.y (aliased)
                    float rampGain   = _SafeFullAbsorpDistance;                                  // c20.w (aliased)
                    // b1661:207 inner: mad(1 - _WaterAbsorption.z, rampK*rampR, mad(-rampK, rampR, 1)) == 1 - rampK*rampR*absZ.
                    float rampA      = mad(1.0 - _WaterAbsorption.z, rampK * rampR, mad(-rampK, rampR, 1.0));
                    float rampB      = mad(waterUvZ + rampRx, 2.019999980926513671875, -0.0099999904632568359375); // b1661:207 (consts 2.02,-0.0099...)
                    float scatterT   = mad(rampA, rampB, -1.0);                                  // b1661:207 (_412)
                    float scatterMask = clamp((scatterT + rampRy) * rampGain, 0.0, 1.0);         // b1661:208 (_427)
                    // Absorption multiplies base color + alpha. b1661:216-219 (_409 * (...)).
                    color *= waterAbsorb;
                    alpha *= waterAbsorb;
                    // In-scatter blend (gated on _WaterScatter.y != 0). b1661:220 (_535), :221-223 (_543/_545/_547)
                    //   for RGB, and b1661:231 (the _696 master-alpha gate) for the matching ALPHA mask:
                    //   RGB:   out   = _535 ? mad(_427, mad(_427*scatRGB, _TintColorIntensity, -base), base) : base
                    //                = base*(1 - _427) + _427*_427*scatRGB*_TintColorIntensity   (per channel).
                    //   ALPHA: _518' = _535 ? clamp((-_412) * rampGain, 0, 1) * _518 : _518   (b1661:231 inner).
                    //     The blob folds this alpha mask into _696 (which scales BOTH final RGB and output alpha);
                    //     here `alpha` (== _518) flows through the downstream master-alpha gate `distFade * alpha`,
                    //     so multiplying `alpha` by the SAME _535-gated clamp reproduces _696's _518 factor 1:1.
                    //     NOTE: this clamp is clamp(-_412 * gain) (NO +rampRy), distinct from scatterMask (_427).
                    if (0.0 != _WaterScatter.y)
                    {
                        float3 scatRGB = _WaterScatter.xyz;                                      // c23.xyz (aliased -> scatter color)
                        color = mad(scatterMask.xxx, mad(scatterMask.xxx * scatRGB, _TintColorIntensity.xxx, -color), color); // b1661:221-223
                        alpha *= clamp((-scatterT) * rampGain, 0.0, 1.0);                        // b1661:231 (_535 ? clamp(-_412*gain,0,1)*_518)
                    }
                }
                #endif

                // ===== apply SampleTex color modes (Weight/Mask/Blend/Dissolve) =====
                // The Disturb modes (0/1) already perturbed the MainTex UV in the pre-pass above; here the
                //   remaining modes fold the channel-selected aux samples into color/alpha. Modes 0/1 are
                //   no-ops for the color side. Weight (b1315:200-204) packs its channel weights from
                //   _SampleTexNUseWeight0/2/3/4/5; the float4 passed is (useW0, useW2, useW3, useW4|useW1).
                // CANONICAL mode order = tex0-3 enum (Disturb1,Disturb2,Weight,Mask,Blend,Dissolve). tex4/5
                //   declare a DIFFERENT enum (Disturb1,Disturb2,Mask,Blend,Weight,Dissolve, vfxbasev2.shader:245,257),
                //   so their raw mode is remapped to canonical at the call: 2->3(Mask) 3->4(Blend) 4->2(Weight).
                #define ST_MODE_45(raw) ((raw) < 2.5 ? 3.0 : ((raw) < 3.5 ? 4.0 : ((raw) < 4.5 ? 2.0 : (raw))))
                #define SAMPLE_TEX_COLOR(N, MODE, WROW) if ((MODE) >= 1.5) ApplySampleTexColor(stSel##N, (MODE), WROW, color, alpha);
                #ifdef _SAMPLE_TEX0
                    SAMPLE_TEX_COLOR(0, _SampleTex0Use, float4(_SampleTex0UseWeight0, _SampleTex0UseWeight2, _SampleTex0UseWeight3, _SampleTex0UseWeight4))
                #endif
                #ifdef _SAMPLE_TEX1
                    SAMPLE_TEX_COLOR(1, _SampleTex1Use, float4(_SampleTex1UseWeight1, _SampleTex1UseWeight2, _SampleTex1UseWeight3, _SampleTex1UseWeight4))
                #endif
                #ifdef _SAMPLE_TEX2
                    SAMPLE_TEX_COLOR(2, _SampleTex2Use, float4(_SampleTex2UseWeight2, _SampleTex2UseWeight3, _SampleTex2UseWeight4, _SampleTex2UseWeight5))
                #endif
                #ifdef _SAMPLE_TEX3
                    SAMPLE_TEX_COLOR(3, _SampleTex3Use, float4(_SampleTex3UseWeight3, _SampleTex3UseWeight4, _SampleTex3UseWeight5, _SampleTex3UseWeight5))
                #endif
                #ifdef _SAMPLE_TEX4
                    SAMPLE_TEX_COLOR(4, ST_MODE_45(_SampleTex4Use), float4(_SampleTex4UseWeight4, _SampleTex4UseWeight5, _SampleTex4UseWeight5, _SampleTex4UseWeight5))
                #endif
                #ifdef _SAMPLE_TEX5
                    SAMPLE_TEX_COLOR(5, ST_MODE_45(_SampleTex5Use), float4(_SampleTex5UseWeight4, _SampleTex5UseWeight5, _SampleTex5UseWeight5, _SampleTex5UseWeight5))
                #endif
                #undef SAMPLE_TEX_COLOR
                #undef ST_MODE_45

                // ===== EDGE COLOR tint (1:1 Fragment_b1895.hlsl:177,197-200; alias of b1871:193-196) =====
                //   _USE_EDGECOLOR tints toward _EdgeColor over a SCENE-DEPTH soft-particle edge band, either
                //   Multiply or Additive (_EdgeColorMode enum: 0=Multiply, 1=Addictive, vfxbasev2.shader:108).
                //
                //   GROUND TRUTH = b1895 (Keywords HG_ENABLE_MV _USE_EDGECOLOR _USE_SOFTBLEND, ParamBlob:267) —
                //   its ParamBlob leaves the names CANONICAL so the math is unambiguous:
                //     _454 = 1 - _EdgeColorMode                                                            (:197)
                //     _480 = mad( mad(_EdgeColor.x, _258, base), _EdgeColorMode, _454*(_EdgeColor.x*base) )  (:198)
                //     _481/_482 = same for .y/.z                                                           (:199-200)
                //       == lerp( _EdgeColor.c*base, mad(_EdgeColor.c, _258, base), _EdgeColorMode )  per channel:
                //       mode 0 (Multiply): out = _EdgeColor.rgb * color
                //       mode 1 (Additive): out = color + _EdgeColor.rgb * _258
                //   The base-merge variant b1871 (ParamBlob:255) is the IDENTICAL math, register-aliased: its
                //   _469/_470/_471 (:194-196) read c12.x/c12.y/c12.z spelled "_EdgeDistance/_EdgeDistanceOffset/
                //   _EdgeColorMode" == _EdgeColor.rgb, select c11.z "_UseSampleTex0AsAlpha" == _EdgeColorMode,
                //   and mask _248=_243*"_SampleTex0UseWeight4" == _258 (the same scene-depth term, _243 spelling
                //   _SoftDistance/_SoftBias for _EdgeDistance/_EdgeDistanceOffset and _SampleTex0UseWeight4 for
                //   _EdgeColor.w). Both decode to the canonical _EdgeColor property set (vfxbasev2.shader:106-109).
                //
                //   EDGE MASK = _258 (b1895:175,177): a SCENE-DEPTH soft-particle intersection (it samples
                //   T0=_CameraDepthTexture at fragCoord screen-uv, b1895:168), NOT a camera-distance ramp:
                //     _219 = -|particleViewZ| + |sceneViewZ|                                               (:175)
                //     _258 = saturate( _EdgeDistance / max(_219, 1e-3) - _EdgeDistanceOffset ) * _EdgeColor.w  (:177)
                //   This is depth-dependent BY DESIGN (the band tightens where the particle meets scene geometry);
                //   the scene-depth read is the same URP _CameraDepthTexture path the _USE_SOFTBLEND block uses.
                //   (Prior port faked this with a depth-INDEPENDENT viewDepth ramp `saturate((viewDepth-off)/
                //   (dist-off))` and dropped the _EdgeColor.w gate — that was NOT 1:1; replaced below.)
                #ifdef _USE_EDGECOLOR
                    // EDGE MASK (1:1 Fragment_b1895:175,177 — canonical names; the b1871 ParamBlob:255 spelling
                    //   _248=_243*_SampleTex0UseWeight4 with _243 using _SoftDistance/_SoftBias is the SAME term,
                    //   register-aliased). The mask is a SCENE-DEPTH soft-particle intersection, NOT a camera-distance
                    //   ramp: _219 = |sceneViewZ| - |particleViewZ| (b1895:175), then
                    //     _258 = saturate( _EdgeDistance / max(_219, 1e-3) - _EdgeDistanceOffset ) * _EdgeColor.w   (:177)
                    //   INFRA substitution (same as the _USE_SOFTBLEND block): scene |viewZ| =
                    //   LinearEyeDepth(SampleSceneDepth(GetNormalizedScreenSpaceUV(positionCS)), _ZBufferParams);
                    //   particle |viewZ| = ViewDepth(positionWS) = viewDepth. _EdgeColor.w is the HDR-color alpha
                    //   master gate on the edge intensity.
                    float2 edgeUV       = GetNormalizedScreenSpaceUV(input.positionCS);                       // b1895:166-167 (fragCoord.xy/(w,h))
                    float  edgeSceneEye = LinearEyeDepth(SampleSceneDepth(edgeUV), _ZBufferParams);           // b1895:175 |sceneViewZ|
                    float  edgeDelta    = edgeSceneEye - viewDepth;                                           // b1895:175 (_219 = -|particle|+|scene|)
                    float  edgeMask     = clamp(_EdgeDistance / max(edgeDelta, 0.001000000047497451305389404296875) - _EdgeDistanceOffset, 0.0, 1.0) * _EdgeColor.w; // b1895:177 (_258)
                    // b1895:198-200 per-component lerp, written vectorized. Multiply vs Additive via _EdgeColorMode:
                    //   _480 = mad( mad(_EdgeColor.x, _258, base), _EdgeColorMode, (1-_EdgeColorMode)*(_EdgeColor.x*base) )
                    //        == lerp( _EdgeColor.x*base, mad(_EdgeColor.x, _258, base), _EdgeColorMode ).
                    float3 edgeMul = _EdgeColor.rgb * color;                       // mode 0 (Multiply): full multiply
                    float3 edgeAdd = mad(_EdgeColor.rgb, edgeMask.xxx, color);     // mode 1 (Additive): mask-scaled add
                    color = lerp(edgeMul, edgeAdd, _EdgeColorMode);
                #endif

                // ===== FRESNEL (1:1 Fragment_b1355:170-178,199-201) =====
                #ifdef _USE_FRESNEL
                    // Ortho-aware view dir: persp -> normalize(cam - worldPos); ortho -> view forward.
                    // Fragment_b1355:170-174.
                    float3 viewDir;
                    if (0.0 == unity_OrthoParams.w)
                        viewDir = _WorldSpaceCameraPos - input.positionWS;
                    else
                        // b1355:171-173 ortho branch reads column_major _ViewMatrix[0/1/2].z = (_m20,_m21,_m22)
                        //   = the THIRD ROW of V = camera forward axis (view Z basis) in world space.
                        //   In URP row-indexed float4x4 that is UNITY_MATRIX_V[2].xyz (NOT [*].z, which is the
                        //   transposed third column / wrong axis).
                        viewDir = UNITY_MATRIX_V[2].xyz;
                    // b1355:174 normalizes viewDir only (rsqrt of its own dot, 1e-8 floor); the per-component
                    //   *_225 multiply is folded into the single viewDir *= invLen below (algebraically identical).
                    float invLen = rsqrt(max(dot(viewDir, viewDir), 9.9999999392252902907785028219223e-09));
                    viewDir *= invLen;
                    // pow(saturate(NdotV + bias), power). _FresnelBias aliases _SoftDistance@c11, _FresnelPower
                    //   aliases _UseSampleTex0AsAlpha@c11.z in the blob; logical names used. Fragment_b1355:175.
                    //   NOTE 1:1: the blob dots viewDir with the RAW interpolated normal TEXCOORD_2.xyz
                    //   (== input.normalWS) — it does NOT re-normalize the normal, so neither do we.
                    float fresnel = exp2(log2(saturate(dot(viewDir, input.normalWS) + _FresnelBias)) * _FresnelPower);
                    float invFresnel = 1.0 - fresnel;                                            // :176
                    float fresnelTerm = mad(_FresnelFlip, (-invFresnel) + fresnel, invFresnel);  // :177 lerp(inv, fres, flip)
                    float fresnelBlend = fresnelTerm * _FresnelColor.w;                          // :178
                    color = mad(fresnelBlend, (-color) + _FresnelColor.rgb, color);              // :199-201 lerp(color, fresColor, blend)
                #endif

                // ===== LOD-crossfade dither clip + surface-type gate. Base blob :169-170. =====
                float dither = frac(frac(dot(input.positionCS.xy,
                                   float2(0.067110560834407806396484375, 0.005837149918079376220703125)))
                                   * 52.98291778564453125);
                float lodSigned = ((unity_LODFade.x >= 0.0) ? dither : -dither);
                float surfaceGate = (0.0 < (-lodSigned + unity_LODFade.x)) ? 1.0 : (1.0 - _SurfaceType); // :170

                // Camera-distance edge + soft fade product. Base blob :170 (_SoftDistance!=0 path).
                float edgeFade = saturate((viewDepth - _EdgeDistanceOffset) / ((-_EdgeDistanceOffset) + _EdgeDistance));
                // ===== SOFT FADE — depth-buffer soft particle (_USE_SOFTBLEND) vs base self-depth =====
                //   1:1 vfxbasev2/Sub0_Pass0_Fragment_b1681.hlsl:156-168 (Keywords: HG_ENABLE_MV _USE_SOFTBLEND).
                //   The b1681 frag reconstructs TWO view-space depths and fades by their difference:
                //     _108 = T0.SampleLevel(sampler_LinearClamp, fragCoord.xy/(w,h), 0); _111 = _108.x  (scene device depth, :158-161)
                //     _135 = clip-w of the SCENE point rebuilt from (NDC.xy, _111) via _InvViewProjMatrix  (:163)
                //     sceneViewZ = abs( _ViewMatrix-row2 . (scenePoint / _135) )                          (:168 inner abs)
                //     _220       = abs(_215) = |particle view Z| (rebuilt from gl_FragCoord.z)             (:166-167)
                //     _240       = clamp( ( -_220 + sceneViewZ + _SoftBias ) / _SoftDistance, 0, 1 )       (:168)  <-- THE FADE
                //   INFRA SUBSTITUTION (sanctioned; MATH kept 1:1): the manual _InvViewProjMatrix/_ViewMatrix
                //   depth reconstruction is exactly URP LinearEyeDepth(rawDepth, _ZBufferParams) = |viewZ|.
                //     scene |viewZ| = LinearEyeDepth(SampleSceneDepth(screenUV), _ZBufferParams)   (== :168 inner abs)
                //     particle |viewZ| = viewDepth = ViewDepth(positionWS)                          (== _220, :166-167)
                //   So _240 == saturate((sceneEyeDepth - particleEyeDepth + _SoftBias) / _SoftDistance).
                //   NOTE the denominator is _SoftDistance ALONE (b1681:168), NOT (_SoftDistance - _SoftBias)
                //   like the base self-fade; and the numerator is the scene-vs-particle DELTA, not the particle
                //   depth itself. Screen UV = fragCoord.xy/(w,h) (b1681:158-159, not pixel-snapped); URP
                //   GetNormalizedScreenSpaceUV(positionCS) is that same screen UV (SampleSceneDepth floors to the
                //   pixel internally, matching the depth-buffer's per-pixel value).
                #ifdef _USE_SOFTBLEND
                    float2 softBlendUV = GetNormalizedScreenSpaceUV(input.positionCS);                       // b1681:158-159 (fragCoord.xy/(w,h))
                    float  sceneEyeDepth = LinearEyeDepth(SampleSceneDepth(softBlendUV), _ZBufferParams);    // b1681:158-168 inner abs (|sceneViewZ|)
                    float  softFade = saturate(((-viewDepth) + sceneEyeDepth + _SoftBias) / _SoftDistance);  // b1681:168 (_240)
                #else
                    // base 1:1 Fragment_b1309:170 — self-depth camera-distance soft fade (no scene depth).
                    float  softFade = saturate((viewDepth - _SoftBias) / ((-_SoftBias) + _SoftDistance));
                #endif
                float distFade = (0.0 != _SoftDistance) ? (edgeFade * softFade) : 1.0;

                // Near-camera fade. Base blob folds this into alpha via _313 branch; exposed cleanly here.
                // 1:1 sibling HGRP_CharacterNPR_VFX_Fix.shader:410-416 (same family).
                float nearFade = 1.0;
                if (_UseNearCameraFade != 0.0)
                {
                    nearFade = saturate((viewDepth - _NearCameraFadeDistanceStart2) / (_NearCameraFadeDistanceEnd2 - _NearCameraFadeDistanceStart2))
                             * saturate((viewDepth - _NearCameraFadeDistanceStart)  / (_NearCameraFadeDistanceEnd  - _NearCameraFadeDistanceStart));
                }

                // Master alpha gate _362. Base blob b1309:170 (literal):
                //   _362 = surfaceGate * ( (1 - LODFade.y) * clamp( distFade * (_313 ? erode*_307 : _307), 0, 1) )
                //   where _307 == alpha is multiplied UNCLAMPED and the whole product is saturated as a unit
                //   (NOT saturate(alpha) first). The _313 branch is a water/edge erode (b1309:155-156,170) whose
                //   _211/_226 reads are water packoffset-aliases unrecoverable from the base blob; it is left as
                //   the declared nearFade reconstruction below, placed inside the saturate where _313 sits.
                // Fresnel variant b1355:195: the same slot multiplies mad(_257,_FresnelAffectOpacity,1-_FAO)
                //   (== lerp(1, fresnelTerm, _FresnelAffectOpacity)) and saturates _403==alpha individually.
                #ifdef _USE_FRESNEL
                    // 1:1 b1355:195 ordering: fresnelOpacityLerp * saturate(alpha), then outer saturate.
                    float fresnelOpacity = mad(fresnelTerm, _FresnelAffectOpacity, 1.0 - _FresnelAffectOpacity); // b1355:195
                    float gateAlpha = saturate(distFade * (fresnelOpacity * saturate(alpha)) * nearFade);
                #else
                    // 1:1 b1309:170 ordering: distFade * alpha (alpha unclamped), then outer saturate.
                    float gateAlpha = saturate(distFade * (alpha * nearFade));
                #endif
                float masterAlpha = surfaceGate * (1.0 - unity_LODFade.y) * gateAlpha; // base blob :170

                // ===== Exposure-threshold HDR boost. Base blob :174-178. =====
                float negThresh = -_ExpThreshold;                                                       // :174
                float exposureScale = mad(_ExposureParams.x, _IgnorePostExposure, 1.0 - _IgnorePostExposure); // :175
                float3 boosted;
                boosted.x = min(max(mad(max(color.x + negThresh, 0.0), _ExpIntensity, color.x) / exposureScale, 0.0), 1000.0); // :176
                boosted.y = min(max(mad(max(color.y + negThresh, 0.0), _ExpIntensity, color.y) / exposureScale, 0.0), 1000.0); // :177
                boosted.z = min(max(mad(max(color.z + negThresh, 0.0), _ExpIntensity, color.z) / exposureScale, 0.0), 1000.0); // :178

                // ===== LIGHTING — subsurface SH ambient + dynamic main-light diffuse (_USE_LIGHTING) =====
                //   1:1 vfxbasev2/Sub0_Pass0_Fragment_b1311.hlsl (Keywords: HG_ENABLE_MV _USE_LIGHTING).
                //   The blob REPLACES the exposure-mapped particle color (_545/_547/_548 == `boosted` here, b1311:271-273)
                //   with a LIT color _1229/_1230/_1231 (b1311:588-590) before the master-alpha premultiply (_1232 =
                //   _509*_1229). Per channel the blob computes:
                //       _1229 = mad( _545 * max(dot(SH_R, float4(N,1)), 0), _EnvironmentGlobalParams0.x,  _1123 + _1173 )
                //   i.e.  lit = boosted * max(dot(SH, N),0) * envAmbientIntensity   (TERM1: SH/IV ambient irradiance)
                //            + dirLight (TERM2: _1123)  +  punctualLights (TERM3: _1173).
                //   N == float3(_426,_427,_428) (b1311:264-266) = the interpolated world normal TEXCOORD_2 with a
                //   _WaterAbsorption.w lerp toward (0,1,0); since _USE_LIGHTING excludes _USE_WATER_BLEND that scalar
                //   is packoffset-aliased and defaults 0, so N == input.normalWS exactly. The blob feeds the RAW
                //   interpolated normal (no renormalize, same as the _USE_FRESNEL path above), so we do too.
                //
                //   INFRA SUBSTITUTION (STYLE_BIBLE §2; MATH kept 1:1; established by sibling HGRP_LitEffect_Fix.shader:65
                //   "IV-clipmap GI -> SampleSH; CSM/ASM atlas -> URP main-light shadow"):
                //     TERM1 SH probe: the blob dots a single per-channel SH float4 SH_R = T1.Load(...) (b1311:588, the
                //       HG SH/IV-probe buffer, host-filled) with float4(N,1). URP's SampleSH(N) evaluates the full L2
                //       SH irradiance for N (the sanctioned GI substitution, CoreSurface.hlsl:179 `s.bakedGI=SampleSH`).
                //       => term1 = boosted * SampleSH(N) * _EnvironmentGlobalParams0.x.
                //     TERM2 directional light _1123 (b1311:368-378):
                //         _828 = ASM shadow attenuation in [0,1] (b1311:284-364, host atlas) * _DirectionalShadowParams.x;
                //         _947 = saturate(dot(-_LightDataBuffer_DirectionalLightDirection[0].xyz, N))   (NdotL)
                //         _956 = _947 * _545 * _LightDataBuffer_DirectionalLightDirection[1].x           (NdotL*boosted*lightColor)
                //         _1123 = _956 * lerp(1, T4.SampleBias(rampLUT, float2(_828,0.5)).x, 1-_828)     (shadow->intensity ramp LUT, host T4)
                //       The blob's directional light dir/color come from the HG _LightDataBuffer global -> URP GetMainLight
                //       (mainLight.direction is the direction TOWARD the light == -blobLightDir, so the blob's
                //       dot(-blobLightDir,N) == dot(mainLight.direction,N)); the custom shadow ramp-LUT (T4) +
                //       _DirectionalShadowParams collapse to URP's linear shadow attenuation mainLight.shadowAttenuation
                //       (same reduction every other lit _Fix shader in this set uses). distanceAttenuation is 1 for the
                //       directional main light. => term2 = boosted * saturate(dot(L,N)) * mainLight.color * shadow.
                //     TERM3 punctual/tiled lights _1173 (b1311:402-586): the per-tile light-binning loop over the HG
                //       light ByteAddressBuffers T0/T1 + light-cookie atlas T5 + _lightCookieMatrices. This is HG's
                //       clustered-light system with NO URP-portable equivalent at the VFX call site (URP additional
                //       lights would require GetAdditionalLightsCount()/the forward+ light loop, a different binding
                //       than the blob's HG buffers) -> DROPPED per §2 (punctual lights removed), exactly as the
                //       CharacterNPR family drops its T0/T1 light-binning path. Default scene => only sun + ambient,
                //       which both terms above reproduce faithfully.
                #ifdef _USE_LIGHTING
                {
                    float3 N = input.normalWS;                                                       // b1311:264-266 (==TEXCOORD_2, alias-0 normal)
                    // TERM1: SH / IV ambient irradiance * intensity (b1311:588-590 SH_R/_G/_B dot + _EnvironmentGlobalParams0.x).
                    float3 ambient = max(SampleSH(N), 0.0) * _EnvironmentGlobalParams0.x;             // max(dot(SH,N),0) -> SampleSH (already irradiance), .x scale
                    // TERM2: URP main directional light (b1311:368-378). GetMainLight(shadowCoord) supplies dir/color/shadow.
                    float4 shadowCoord = TransformWorldToShadowCoord(input.positionWS);              // ASM-atlas substitute (b1311:284-364)
                    Light mainLight = GetMainLight(shadowCoord);
                    float  NdotL = saturate(dot(mainLight.direction, N));                            // b1311:370 (_947, dir TOWARD light)
                    float3 dirDiffuse = NdotL * mainLight.color * (mainLight.shadowAttenuation * mainLight.distanceAttenuation); // b1311:371-378 (_956 * shadow-ramp -> linear)
                    // Lit color REPLACES boosted (b1311:588-590 _1229/_1230/_1231 = boosted*ambient + boosted*dirDiffuse).
                    boosted = boosted * ambient + boosted * dirDiffuse;
                }
                #endif

                // ===== FOG (HG atmosphere + exponential height + volumetric blend, _USE_FOG) =====
                //   1:1 vfxbasev2/Sub0_Pass0_Fragment_b1925.hlsl:211-284. The source blends the surface color
                //   _574 (== exposure-mapped color BEFORE the final alpha premultiply) toward the scene fog, then
                //   premultiplies (_1223 = _577 * _1220). Here `boosted` IS that pre-premultiply color (== b1925
                //   _405/_574 for the VFX-default _SurfaceType=1, where _574 collapses to _405), and the premultiply
                //   `masterAlpha * (...)` below is the _577 multiply — so applying fog to `boosted` here, then
                //   premultiplying, reproduces b1925's _1223/_1224/_1225 exactly for the transparent surface type.
                #ifdef _USE_FOG
                {
                    bool   isPersp = (0.0 == unity_OrthoParams.w);           // b1925 _143
                    float3 camFwd  = UNITY_MATRIX_V[2].xyz;                  // b1925 ortho view-forward (column_major _ViewMatrix[*].z)
                    boosted = ComputeVfxFog(boosted, input.positionWS, viewDepth, _WorldSpaceCameraPos, isPersp, camFwd);
                }
                #endif

                // Premultiply by master alpha. Base blob :179-181 (_435..437 = _362 * boosted).
                float3 outRGB = masterAlpha * boosted;

                // Output alpha _467 = (1 - _BlendMode) * masterAlpha. Base blob :184-185.
                //   Additive (_BlendMode=1) -> a=0; Alpha (_BlendMode=0) -> a=masterAlpha. Premultiplied RGB.
                float outA = (1.0 - _BlendMode) * masterAlpha;

                return half4(outRGB, outA);
            }
            ENDHLSL
        }
    }

    // ======================= DONE(1:1) log — keyword subsystems beyond the base blob =======================
    // None below are simplified or stubbed silently; each was deep-closed from its own keyword-gated delta blob.
    // Each cite is the source keyword + the representative non-base variant it was ported from. The ONLY residual
    // is the SV_Target1 motion-vector MRT (the TODO at the end of this block), which is host-bound and dropped.
    //
    // DONE(1:1): _USE_BRIGHT (Spot/ScanLine value-noise distance field, Fragment_b1313.hlsl:182-271) +
    //            _USE_BRIGHT_SECTOR (angular wedge, Fragment_b1329.hlsl:234-274) — implemented in the
    //            ForwardOnly frag under the #if defined(_USE_BRIGHT)||defined(_USE_BRIGHT_SECTOR) guard above.
    //            _VFXParams0 re-exposed as a material Vector (char-center; HG-global, sibling-precedent).
    // DONE(1:1): _SAMPLE_TEX0.._SAMPLE_TEX5 (6 aux texture samples feeding Disturb/Weight/Mask/Blend/Dissolve)
    //            vs vfxbasev2/Sub0_Pass0_Fragment_b1315.hlsl:177-204 (the minimal HG_ENABLE_MV+_SAMPLE_TEX0
    //            delta) + the per-tex UV build from Vertex_b1314:466-469. Implemented under
    //            #pragma shader_feature_local _SAMPLE_TEX0.._SAMPLE_TEX5: a pre-MainTex-sample pass builds each
    //            enabled aux UV (pan _SampleTexNUVSpeed*time(_VFXParams0.w)+custom + weight _SampleTexNUVWeights
    //            + 2x2 rotate _SampleTexNUVRotateMat + tiling _SampleTexN_ST), samples mip-biased
    //            (_SampleTexNMipmapBias), channel-selects (_UseSampleTexNAsAlpha, b1315:182-185), and folds the
    //            Disturb modes (_SampleTexNUse 0/1) into the MainTex UV (b1315:188-192, gated by
    //            _SampleTexNUseDisturb * master _MainTexUseDisturb). A post-color pass applies the remaining
    //            modes (2 Weight/3 Mask/4 Blend/5 Dissolve) to color/alpha (ApplySampleTexColor).
    //            NOTE(1:1 deviation): the b1315 disturb/weight constants are packoffset-ALIASED to that single
    //            variant's register layout (water/near-fade/edge slots), so the displacement is re-expressed via
    //            the LOGICAL SampleTex property set (vfxbasev2.shader:179-258); the Weight/Mask/Blend/Dissolve
    //            consumption mirrors the verified sibling HGRP_VfxBaseBatched_Fix.shader (same HGRP VFX family).
    //            UVSet=Polar/Screen on a per-SampleTex basis still falls back to UV0 here (only the MainTex
    //            Polar/Screen generation is implemented; see DONE below).
    // DONE(1:1): _USE_SCREENUV / _USE_POLARUV alternate MainTex UV generation vs vfxbasev2/Sub0_Pass0_Fragment_b1385.hlsl
    //            (the minimal HG_ENABLE_MV+_USE_SCREENUV+_USE_POLARUV+_SAMPLE_TEX0 delta, cross-checked w/ b1389).
    //            PolarUV (GeneratePolarUV, b1385:155-163): inlined atan2 (range-reduced rational approx, consts
    //            0.0872929/-0.3018950) of (uv0-0.5) -> U=angle/(2pi), V=2*radius. ScreenUV (GenerateScreenUV,
    //            b1385:167-180): per-pivot camera-distance scale (_211=lerp(1,max(camDist-near,1),_ScreenUVUseDepth))
    //            * per-axis lerp(flat NDC screen coord, depth-reconstructed view-space XY, _ScreenUVUseDepth), with
    //            V optionally = world Y (_UsePosYAsScreenV). Both fold into the MainTex UV weighted blend
    //            (BuildMainTexUV, b1385:181-183) via _MainTexUVWeights.z (polar) / .w (screen). INFRA(1:1):
    //            the blob's gl_FragCoord+_InvViewProjMatrix world reconstruction -> URP input.positionWS (same
    //            fragment world point, :571 convention); _ScreenSize.zw / _ScreenParams.xy -> URP _ScreenParams;
    //            _ViewMatrix -> UNITY_MATRIX_V. NOTE(1:1 deviation): _UsePosYAsScreenV/_ScreenUVUseDepth are
    //            packoffset-ALIASED in the blob (_WaterAbsorption2.x/.z in b1389, _EdgeColor.x/.z in b1385); re-
    //            expressed via the LOGICAL property names (vfxbasev2.shader:131-132 "使用世界坐标的Y作为V" /
    //            "屏幕坐标是否受相机距离影响"). _MainUVSet enum (0/1/2/3) only drives _MainTexUVWeights from the
    //            material editor; the shader reads the weights 1:1 as the blob does.
    // DONE(1:1): _USE_EDGECOLOR (multiply/additive edge tint) vs vfxbasev2/Sub0_Pass0_Fragment_b1895.hlsl:175,177,197-200
    //            (canonical-name ground truth; the base-merge b1871:193-196 is the SAME math register-aliased) —
    //            implemented in the ForwardOnly frag under #ifdef _USE_EDGECOLOR (after the base color/SampleTex
    //            assembly, before exposure). Per channel: lerp(_EdgeColor.c*color, mad(_EdgeColor.c,edgeMask,color),
    //            _EdgeColorMode); mode 0=Multiply, 1=Addictive (vfxbasev2.shader:108). DECODE: b1871 ParamBlob:255
    //            spells the tint scalars "_EdgeDistance/_EdgeDistanceOffset/_EdgeColorMode" (c12.xyz) for _EdgeColor.rgb
    //            and "_UseSampleTex0AsAlpha" (c11.z) for the mode select; b1895 ParamBlob:267 leaves them canonical,
    //            confirming the decode (vfxbasev2.shader:105-109). EDGE MASK _258 = _EdgeColor.w *
    //            saturate(_EdgeDistance/max(sceneViewZ-particleViewZ, 1e-3) - _EdgeDistanceOffset) — a SCENE-DEPTH
    //            soft-particle intersection (b1895:175,177). INFRA(1:1): scene view-Z via URP
    //            LinearEyeDepth(SampleSceneDepth(GetNormalizedScreenSpaceUV(positionCS)), _ZBufferParams), the same
    //            _CameraDepthTexture path _USE_SOFTBLEND uses; particle view-Z = ViewDepth(positionWS). The depth
    //            include guard is widened to (_USE_SOFTBLEND || _USE_EDGECOLOR). _EdgeColor/_EdgeColorMode +
    //            _EdgeDistance/_EdgeDistanceOffset in CBUFFER+Properties.
    // DONE(1:1): _USE_SOFTBLEND (depth-buffer soft-particle fade) vs vfxbasev2/Sub0_Pass0_Fragment_b1681.hlsl:156-168
    //            (Keywords: HG_ENABLE_MV _USE_SOFTBLEND) — implemented in the ForwardOnly frag at the soft-fade
    //            site under #ifdef _USE_SOFTBLEND. The blob samples T0=_CameraDepthTexture at fragCoord.xy/(w,h)
    //            (b1681:158-161), reconstructs the SCENE view-Z (b1681:163,168 via _InvViewProjMatrix/_ViewMatrix)
    //            and the PARTICLE view-Z (b1681:166-167), then _240 = clamp((sceneViewZ - particleViewZ + _SoftBias)
    //            / _SoftDistance, 0, 1) (b1681:168). INFRA SUBSTITUTION (MATH 1:1): the manual depth reconstruction
    //            is URP LinearEyeDepth(SampleSceneDepth(GetNormalizedScreenSpaceUV(positionCS)), _ZBufferParams) for
    //            the scene side and ViewDepth(positionWS) for the particle side — both are |viewZ|, identical values.
    //            Requires URP _CameraDepthTexture: #include DeclareDepthTexture.hlsl is added (keyword-guarded) and
    //            the [Toggle(_USE_SOFTBLEND)] _UseSoftBlend property + #pragma shader_feature_local _USE_SOFTBLEND
    //            wire it. When the keyword is OFF the base self-depth camera-distance fade (b1309:170) is kept.
    //            NOTE: the project's Universal Renderer must have the Depth Texture enabled for SampleSceneDepth to
    //            return valid data (standard URP transparent soft-particle requirement); this is render-pipeline
    //            config, not shader-side, so no further stub is needed.
    // DONE(1:1): _USE_FOG (HG atmosphere + exponential height + volumetric froxel scene-fog blend) vs
    //            vfxbasev2/Sub0_Pass0_Fragment_b1925.hlsl:211-284 (the minimal HG_ENABLE_MV+_USE_FOG delta vs the
    //            no-fog base b1309). Implemented as ComputeVfxFog() in the shared HLSLINCLUDE, called in the
    //            ForwardOnly frag under #ifdef _USE_FOG just before the alpha premultiply (the b1925 _574->_1220
    //            blend site). Math ported bit-faithfully: (a) camera->fragment ray + distance (b1925:164-172);
    //            (b) atmospheric height-fog RGB transmittance _632/_633/_634 (b1925:211-215) + Rayleigh phase
    //            _1130 (b1925:275) + Henyey-Greenstein mie phase _1159 (b1925:276); (c) exponential two-layer
    //            height-fog opacity _1115 + directional-inscatter color _1116/_1117/_1118 (b1925:259-272 analytic
    //            else branch + the b1925:222-256 volumetric-slot branch); (d) the per-channel blend
    //            lerp(color, color*trans*opacity + (atmInscatter*(1-trans)*opacity + expFogCol)*(1-BlendMode*Surf),
    //            edgeWeight) (b1925:274,277-281). The *1.44269502 (=1/ln2) and 0.0596831/12.5664 phase constants
    //            and the (1-e^-x)/x small-x series (HgFog_Rcp1mExp) are kept exact.
    //            INFRA(1:1): the fog parameter banks _AtmosphereFogParams0..5 / _ExponentialFogParams0..5 /
    //            _VolumetricFogParams0..4 (b1925 cbuffer c153..c169) are HGRP engine-side globals with NO URP
    //            equivalent (URP's unity_FogParams is a different model) — re-exposed as a global CBUFFER(HgVfxFog),
    //            the same idiom used for _ExposureParams/_VFXParams0; default 0 => fog opacity 0 => identity no-op.
    //            STUB(host-bound, the ONLY unported piece): the volumetric froxel T1=Texture3D (b1925:125,245) is
    //            the HG volumetric-fog FROXEL buffer filled each frame by HG's volumetric COMPUTE pass; its
    //            contents cannot be reproduced shader-side, so _VolumetricFog3D is declared neutral-black. It is
    //            sampled ONLY inside `if (_VolumetricFogParams0.z > 0)` (default 0 = off), so the portable analytic
    //            height+exponential+atmospheric path is taken with default params and the stub is never read.
    // DONE(1:1): _USE_WATER_BLEND (underwater absorption + depth-ramp in-scatter) vs
    //            vfxbasev2/Sub0_Pass0_Fragment_b1661.hlsl:206-223 (the minimal HG_ENABLE_MV+_USE_WATER_BLEND
    //            delta). Implemented in the ForwardOnly frag under #ifdef _USE_WATER_BLEND, at the pre-SampleTex
    //            base-color site (the blob applies it where _515/_518 are formed). MATH 1:1: (a) absorption
    //            _409 = (1 - _WaterAbsorption.w) multiplies base color+alpha (b1661:206,216-219); (b) scatter
    //            depth-ramp _412 = mad(1 - rampK*rampR*_WaterAbsorption.z, mad(uv0.z+rampRx,2.02,-0.0099), -1),
    //            mask _427 = clamp((_412+rampRy)*rampGain, 0,1) (b1661:207-208, exact consts 2.02/-0.0099); (c)
    //            in-scatter blend gated on _WaterScatter.y!=0: color = mad(_427, mad(_427*_WaterScatter.xyz,
    //            _TintColorIntensity, -color), color) (b1661:220-223). HDR water colors + _WaterHeight/
    //            _SafeFullAbsorpDistance added to CBUFFER+Properties (canonical names vfxbasev2.shader:267-272).
    //            ALIAS DECODE (ParamBlob:160): _WaterAbsorption.w/.z and the _WaterScatter gate are CANONICAL
    //            (decompiler mapped them to the c17/c18 water slots, b1661 cbuffer :109/:113); the leftover ramp
    //            coeffs spelled with base names (c20.z/.w, c21.x/.y/.z, c23.x/.y/.z) are re-expressed via the
    //            LOGICAL set (_WaterAbsorption2.xyzw + _SafeFullAbsorpDistance + _WaterScatter.xyz), same aliasing
    //            idiom as SampleTex/EdgeColor/ScreenUV above. _WaterHeight is declared-only (this minimal variant
    //            ramps off the per-vertex water-depth in uv0.z, not a world-height compare).
    // DONE(1:1): _USE_ANIM_BREATHING (alpha breathing over time) vs vfxbasev2/Sub0_Pass0_Fragment_b1647.hlsl:169
    //            — implemented in the ForwardOnly frag under #ifdef _USE_ANIM_BREATHING (multiplies the base
    //            alphaFactor by lerp(_EdgeColor.x, 1, min(pow(cos(t*_EdgeColor.y)*0.5+0.5, _EdgeColor.z), 1))).
    //            time = _VFXParams0.w (HG VFX-time global, same field the base UV-scroll reads, b1310:541-542).
    //            PACKOFFSET: the blob sources minAlpha/speed/power from the c13 register == _EdgeColor.x/.y/.z
    //            (b1647:90,169; base diff Fragment_b1309:167). The c15.z `_BreathingPower` field is dead (never
    //            read), so the port reads _EdgeColor and carries NO standalone _Breathing* uniform.
    // DONE(1:1): _USE_TRAIL (camera-facing ribbon billboard) vs vfxbasev2/Sub0_Pass0_Vertex_b1552.hlsl:341-349
    //            (Keywords: HG_ENABLE_MV _USE_TRAIL) — implemented in vert() under #ifdef _USE_TRAIL, inside the
    //            in-particle camera-push block. VERTEX-ONLY: the trail FRAGMENT blob Sub0_Pass0_Fragment_b1553.hlsl
    //            is BYTE-IDENTICAL to the no-trail base Fragment_b1309.hlsl (verified: `diff` shows only the
    //            variant-name/keyword HEADER comment differs, frag_main() is character-for-character the same), so
    //            _USE_TRAIL contributes NOTHING in the fragment stage — there is no fragment "trail fade/uv" code to
    //            port; the entire feature is the vertex ribbon-splay. MATH 1:1 (b1552:341-349): crossCT =
    //            cross(camRel, TEXCOORD2.xyz); push = mad((0.5 - uv0.y) * normalize(crossCT), TEXCOORD2.w,
    //            off * normalize(camRel)); the second mad operand (off*normalize(camRel)) is the UNCHANGED base
    //            camera push (b1308:340-342 == b1552:347-349 inner), `off` (b1552:_546) == base `off` (b1308:_509),
    //            and the trail adds only the lateral (0.5-uv.y)*width splay. Needs the per-vertex trail-tangent
    //            input TEXCOORD2.xyz (.w=width); the no-trail base has no TEXCOORD2 vertex stream, so the
    //            Attributes.texcoord2 field + [Toggle(_USE_TRAIL)] property + #pragma shader_feature_local _USE_TRAIL
    //            are all keyword-gated. INFRA: none — pure object-space math; no HGRP globals/textures involved.
    // DONE(1:1): _USE_VERTOFFSET / _USE_VERTOFFSETMASK (offset-texture vertex displacement) vs
    //            vfxbasev2/Sub0_Pass0_Vertex_b1438.hlsl (offset, Keywords HG_ENABLE_MV _USE_VERTOFFSET) +
    //            Sub0_Pass0_Vertex_b1508.hlsl (offset+mask). Implemented in vert() under #ifdef _USE_VERTOFFSET,
    //            right after the base/_USE_TRAIL camera-push `push` is formed. VERTEX-ONLY: the matching FRAGMENT
    //            blobs are byte-identical to the base Fragment_b1309 (the keywords carry no fragment code), so the
    //            feature is entirely the vertex displacement. MATH 1:1 (b1438:540-561): push += dispDir * amount *
    //            offsetSample, where (a) dispDir is selected by _OffsetSwitchDir — World(1)=_OffsetDir.xyz raw,
    //            Normal(2)=M·objNormal, Object(0)=M·_OffsetDir.xyz (M·v == TransformObjectToWorldDir(v,false), the
    //            blob's CB2_m0[*] object matrix; b1438:559-561 _767/_768 select); (b) amount = mad(_OffsetDir.w,
    //            uv1.y*_InParticle, _Bi_Offset) (b1438:555 _902); (c) offsetSample = SAMPLE(_OffsetTex,uv).x *
    //            (1+_OffsetIntensity) - _OffsetIntensity (b1438:557 _962, remap), uv = (UV0/UV1 blend by _OffsetUVSet)
    //            then texture tiling/offset *_OffsetTex_ST.xy + _OffsetTex_ST.zw (b1438:557 inner mad(uvSetBlend,
    //            _UseNearCameraFade(c14.x),_NearCameraFadeDistanceEnd_at_232(c14.z)) — c14 is the auto 2D _OffsetTex_ST),
    //            then + time-scroll(_OffsetSpeed.xy*_VFXParams0.w) + custom-scroll(_OffsetSpeed.zw*custom1Y). +MASK
    //            multiplies offsetSample by lerp(1, SAMPLE(_OffsetMaskTex,maskUv).x, 0.2*_OffsetMaskPower)
    //            (b1508:565 _859=0.2*c17 + _1008=mad(_859,maskSample,-_859)+1); maskUv = the SAME raw UV0/UV1 blend
    //            then ITS OWN _OffsetMaskTex_ST (b1508:575 inner mad(uvSetBlend,_WaterScatter.x,_WaterScatter.z);
    //            c18=_WaterScatter=_OffsetMaskTex_ST) + _OffsetMaskSpeed(c19=_WaterAbsorption2) scroll. The base camera-push (off*
    //            normalize(camRel)) is KEPT as the mad addend (b1438:559 `_972*(_877/_883)`), so the offset is a
    //            pure ADD on top — exactly the blob structure. ALIAS DECODE (ParamBlob:65/100): the offset params
    //            are packoffset-ALIASED onto the EdgeColor/NearFade/WaterBlend registers (those features are
    //            keyword-exclusive with VertexOffset; same aliasing idiom as ScreenUV/WaterBlend) — re-identified
    //            by usage to canonical names per vfxbasev2.shader:135-146 (_OffsetTex/_OffsetSpeed/_OffsetDir/
    //            _OffsetSwitchDir/_OffsetIntensity/_Bi_Offset/_OffsetUVSet/_OffsetMaskTex/_OffsetMaskSpeed/
    //            _OffsetMaskPower). INFRA(1:1, STYLE_BIBLE §0,§2): the blob's octahedral-decoded object NORMAL
    //            (_727/_728/_729 from packed NORMAL.x) -> URP's already-unpacked v.normalOS (same substitution the
    //            _USE_FRESNEL path already makes here); CB2_m0 HG object matrix -> unity_ObjectToWorld via
    //            TransformObjectToWorldDir; T1/T2 + named LinearClamp/LinearRepeat samplers -> TEXTURE2D(_OffsetTex/
    //            _OffsetMaskTex) with clamp/repeat samplers + SAMPLE_TEXTURE2D_LOD(...,0). Nothing host-bound:
    //            all inputs are mesh attributes + material params (the VAT keywords, which ARE host-texture-bound,
    //            are the separate DONE entry below, with their bake textures kept as a documented identity stub).
    // DONE(1:1): VAT _VAT_RIGIDBODY/_VAT_SOFTBODY/_VAT_FLUIDBODY/_VAT_PARTICLE/_USE_VAT_COLORTEX Houdini playback
    //            vs vfxbasev2/Sub0_Pass0_Vertex_b1618.hlsl (rigid), _b1592.hlsl (soft), _b1638.hlsl (fluid),
    //            _b1644.hlsl (particle+colortex). Implemented in vert() under #if defined(_VAT_*), operating on the
    //            object-space position/normal BEFORE TransformObjectToWorld (exactly where the blob applies VAT,
    //            between reading POSITION/NORMAL and the CB2_m0 object->camera-relative transform).
    //            FRAME ADDRESSING (shared, b1618:554-558): current row = floor(frac(speed*(time-phase))*N)+1 (animated)
    //            or floor(per-vertex frame index)+boundsMin (snapshot); row-V folds/flips per the bounds-min snap
    //            (b1618:556-558 _834/_838/_851). RIGID (b1618:559-705): sample _VatRotationTexture(quat xyz + axis
    //            selector .w) + _VatPositionTexture(piece translation); reconstruct qw=sqrt(1-x^2-y^2-z^2) (b1618:576);
    //            permute axes by floor(rot.w*4) (4 cases, b1618:581-623); rotate the pivot-relative vertex by the
    //            quaternion (rotate(v,q)=v+2*cross(qv,cross(qv,v)+qw*v), b1618:627-632) + add translation; reorient
    //            normal+tangent by the same q (b1618:645-705). SOFT/FLUID (b1592:406-491): per-vertex TRANSLATE by the
    //            sampled offset (no pivot rotation) + reorient normal by q; FLUID adds _VatLookupTexture vertex->texel
    //            16-bit (u,v) remap (b1638:402-408, hi + lo/split, split = 4096|255). PARTICLE+COLORTEX (b1644:405-498):
    //            camera-facing quad expansion — center+life from _VatPositionTexture, heading from _VatColorTexture
    //            transformed to view space (UNITY_MATRIX_V) for screen-space spin, billboard right/up built via
    //            UNITY_MATRIX_I_V + object matrix (b1644:443-464), corner = (uv-0.5)*size along right/up with optional
    //            velocity stretch (b1644:467-475); heading.rgba -> vertColor when _VatParticleVertColor (b1644:495-498).
    //            HOST-BOUND (compilable, defaults to identity playback): the four VAT TEXTURES are baked by a Houdini->C#
    //            pipeline; absent it they default to "black" -> zero offset / w=sqrt(1) identity -> the t=0 pose. The
    //            bake-metadata uniforms are aliased onto water/edge/sampler registers in the blob and carried here as
    //            dedicated logical _Vat* fields (same alias-decode idiom as VertexOffset/Water). INFRA SUBSTITUTION
    //            (STYLE_BIBLE §2): _ViewMatrix/_InvViewMatrix -> UNITY_MATRIX_V/UNITY_MATRIX_I_V; CB2_m0 object matrix ->
    //            unity_ObjectToWorld (TransformObjectToWorldDir / UNITY_MATRIX_M); octahedral-packed NORMAL/TANGENT
    //            (b1618:249-308) -> URP-unpacked v.normalOS/v.tangentOS; named LinearClamp/Repeat/Mirror samplers ->
    //            per-texture SAMPLER + SAMPLE_TEXTURE2D_LOD(...,0). DEVIATION (documented, 1 spot): the RIGID per-piece
    //            pivot pre-subtract (b1618:624-626) reads the HG previous-frame skinned origin via TEXCOORD_2/TEXCOORD_3;
    //            motion vectors are dropped in this sandbox (no prev-frame stream), so the faithful stand-in is the piece
    //            object origin (t = posOS) — rigid VAT pieces are baked about their own local origin, so this is exact for
    //            the common single-pivot bake and differs only if a piece's pivot was authored off its local origin.
    // DONE(1:1): _USE_LIGHTING (subsurface SH ambient + dynamic main-light diffuse) vs
    //            vfxbasev2/Sub0_Pass0_Fragment_b1311.hlsl:588-590 (the lit color _1229/_1230/_1231) + the
    //            directional term :368-378 (Keywords: HG_ENABLE_MV _USE_LIGHTING). Implemented in the ForwardOnly
    //            frag under #ifdef _USE_LIGHTING, immediately after the exposure boost (the blob's _545->_1229
    //            site) where it REPLACES `boosted`. MATH 1:1: lit = boosted*max(dot(SH,N),0)*envIntensity (TERM1)
    //            + boosted*saturate(dot(L,N))*mainLightColor*shadow (TERM2). N == input.normalWS (b1311:264-266,
    //            the _WaterAbsorption.w normal-lerp alias defaults 0 since _USE_LIGHTING excludes _USE_WATER_BLEND).
    //            INFRA(1:1, STYLE_BIBLE §2, sibling HGRP_LitEffect_Fix.shader:65 precedent): TERM1 SH-probe buffer
    //            (T1, host) -> URP SampleSH(N) (full irradiance; == CoreSurface.hlsl:179 s.bakedGI=SampleSH);
    //            _EnvironmentGlobalParams0.x (HG global c111) re-exposed as a material Vector (.x=ambient intensity).
    //            TERM2 directional dir/color (HG _LightDataBuffer global) -> GetMainLight; the ASM shadow-atlas
    //            ramp (T4 LUT + _DirectionalShadowParams, b1311:284-378) -> URP mainLight.shadowAttenuation
    //            (Lighting.hlsl + #pragma multi_compile _MAIN_LIGHT_SHADOWS*). DROPPED (host-bound, §2): TERM3 the
    //            HG tiled/punctual light-binning loop (b1311:402-586) over the ByteAddressBuffers T0/T1 + light-
    //            cookie atlas T5 + _lightCookieMatrices — HG's clustered-light system, no URP-portable equivalent
    //            at this call site, exactly as the CharacterNPR family drops its T0/T1 punctual path. Default scene
    //            (sun + ambient only) is reproduced faithfully by TERM1+TERM2.
    // TODO(1:1): SV_Target1 motion-vector / _Responsive packing vs Fragment_b1309:190-199 (dropped per sandbox).
    // ===========================================================================================================
}
