// HGRP VFXAdvance — unified transparent particle/VFX surface, single ForwardOnly pass (HGRP/Effect/VFXAdvance).
// Merged from: vfxadvance.shader, per-stage catch-all + (shared-family) feature blobs:
//   Vertex   base: vfxadvance/Sub0_Pass0_Vertex_b154.hlsl   (ladder #else, vfxadvance.shader:719-722)
//   Fragment base: vfxadvance/Sub0_Pass0_Fragment_b155.hlsl (ladder #else, vfxadvance.shader:1189-1192)
//   Shared VFX features (Mask/Disturb/Blend/Bright/SoftBlend) re-use the VERIFIED 1:1 math from the
//   sibling exemplar HGRP_VfxBaseBatched_Fix.shader (same HGRP VFX particle family; identical helper/blob math).
//   (Fresnel + Dissolve are verified directly against the vfxadvance blobs b169 / b193 — see DONE(1:1) below.)
//   Feature-blob ladder cites (vfxadvance fragment ladder, vfxadvance.shader:729-1193):
//     _USE_AIRWALL=b157  _USE_CUT_OFF=b159  _USE_UNDER_GROUND=b161  _USE_SLUDGE=b163  _INK_DISTORT=b167
//     _USE_FRESNEL(+cutoff)=b169  ... combinatorial deltas b157..b461.
//
// Keywords (this pass): _USE_AIRWALL _USE_CUT_OFF _USE_UNDER_GROUND _USE_SLUDGE _INK_COLOR_DISTORT _INK_DISTORT
//   _USE_FRESNEL _USE_BLEND _USE_MASK _USE_DISSOLVE _USE_BRIGHT _USE_VERTOFFSET_CHARPOS _USE_VERTOFFSET
//   _USE_BRIGHT_DOUGHNUT _USE_SCREENUV _NORMAL_MAP _HEIGHT_COLOR_GRADIENT _EMISSION _USE_DISTURB _USE_SOFTBLEND
//   _USE_EDGECOLOR _USE_FOG  (HG_ENABLE_MV / HG_COMPOSE_VOLUMETRIC / SRP_INSTANCING_ON dropped as infra).
//
// Kept (math 1:1): MainTex rotate(_MainTexUVRotateMat about 0.5)+pan(speed time+custom1.x)+UVweights select +_ST;
//   UseMainTexAsAlpha rgb<->alpha lerp; vertColor(*_DisableVertColor)*_TintColor*_TintColorIntensity / postExposure;
//   alpha = (1-LODFade.y)*softDepthGate*lerp(a,r,UseMainAsAlpha)*vertA*_TintColor.w*_TintColorAlpha;
//   VFX color grade (Rec709-luma desaturate by _VFXParams1.w, *_VFXParams1.xyz) on ALPHA-PREMULTIPLIED rgb;
//   out.a = (1-_BlendMode)*alpha (Additive zeros dst-alpha); + shared features (mask/disturb/blend/dissolve/fresnel/bright/soft).
// Removed (HGRP pipeline infra with no URP single-RT equivalent; mirrors HGRP_VfxBaseBatched_Fix / HGRP_CharacterNPR_VFX_Fix):
//   Motion Vectors / SV_Target1 (HGRP MRT-1 transparent MV, Fragment_b155:137-146); TAA jitter (_TaaJitterStrength, Vertex_b154:299-300);
//   camera-relative-world rebase (_WorldSpaceCameraPos add-back, Vertex_b154:293-295); GPU skinning (Vertex_b154:85-281);
//   SRP-instancing per-draw particle color scale (CB1_m0[13], Vertex_b154:306-309 -> identity); LOD crossfade dither.
//   _VFXParams0.w (custom particle time) -> _Time.y.
//
// NOTE: _VFXParams1 = HGRP per-batch VFX color modifier (xyz RGB multiply, w desaturation). Exposed as material Vector,
//   identity default (1,1,1,0). _ExposureParams.x = HGRP global post-exposure (default 1). _VFXParams0.xyz = effect spot center.
// NOTE: BASE rgb is ALPHA-PREMULTIPLIED before the VFX grade (Fragment_b155:133-135 multiply _391*_371). Default blend
//   _SrcBlend=One(1) _DstBlend=Zero(0) per source (Additive variant flips via material _BlendMode + _DstBlend).
// NOTE: A few vfxadvance-UNIQUE features remain genuinely host-bound in this pass (no URP single-RT equivalent):
//   VolumetricFog froxel/atmosphere stack (host-bound, see _USE_FOG block), Ink ColorDistortScene scene-grab (needs
//   _CameraOpaqueTexture), BrightDoughnut ring variant.
//   ( _USE_SLUDGE DONE(1:1): VERTEX-stage height-texture geometry erosion (sample _SludgeHeightTexture at a world-pivot-derived
//     UV; if height.z < 0.1 NaN the clip pos -> primitive culled). Source = vfxadvance Vertex_b162.hlsl:357-364 (the sludge
//     FRAGMENT b163 is identical to base b155 — sludge's distinctive math is vertex-only). See vert() + fragment RESIDUAL note. )
// DONE(1:1): _USE_BRIGHT — 2-octave value-noise UV distortion, spot-distance gated (NOT spot/scanline COLOR — vfxadvance's
//   _USE_BRIGHT is distort-only; _BrightColor/_ScanFillColor/_BrightType/_ScanLine* are unused by ALL 148 vfxadvance frag
//   blobs, that is a vfxbasebatched-only feature). noiseUV = HashCell bilerp of (mainUV*_DistortScale + _Time.y*_DistortSpeed),
//   amount = smoothstep(saturate((_DistortOnEdge*noise + |worldPos-center| - _OuterRadius)/(_InnerRadius-_OuterRadius)))
//   *_DistortIntensity; center = lerp(_VFXParams0.xyz, _BrightCenter.xyz, _BrightCenter.w) + _CharacterHeight.y; offset folds
//   into MainTex UV (*_MainTexUseDisturb) and MaskTex UV (*_MaskTexUseDisturb). Source = vfxadvance Fragment_b211.hlsl:176-228.
// DONE(1:1): _USE_EDGECOLOR — soft-particle depth-rim edge glow. rim=clamp(_EdgeDistance/max(sceneViewZ-fragViewZ,0.001)
//   -_EdgeDistanceOffset,0,1); rgb += _EdgeColor.rgb (flat, pre-exposure); alpha += _EdgeColor.a*rim (under softGate*lodFade).
//   Scene depth via URP SampleSceneDepth (Fragment_b249:162-168 vs airwall-only sibling b157).
// DONE(1:1): _USE_UNDER_GROUND — below-ground reveal: scene-depth Y-plane HARD gate * soft depth fade². Reconstruct scene
//   worldPos from SampleSceneDepth(screenUV); step = (sceneWorldPos.y - unity_ObjectToWorld._m13 + _UnderGroundPlaneYOffset <= 0)
//   keeps only the under-ground half-space; fade = clamp((sceneViewZ - fragViewZ)/_UnderGroundFadeDistance + 1, 0, 1); opacity
//   folds step*fade² into the BASE alpha inner (softGate*lodFade, single clamp); alpha-only. Source = vfxadvance Fragment_b161.hlsl
//   :128-143 (isolated under-ground variant, vs airwall-only sibling b157). Slots c13.x=_UnderGroundPlaneYOffset c13.y=_UnderGroundFadeDistance.
// DONE(1:1): _USE_SOFTBLEND — depth-buffer soft-particle fade. soft=clamp((|sceneViewZ|-|fragViewZ|+_SoftBias)/_SoftDistance,
//   0,1); opacity *= soft (folded under the BASE softGate*lodFade product, single outer clamp). Scene depth via URP
//   SampleSceneDepth (Fragment_b243:103-126 == sibling HGRP_VfxBaseBatched_Fix:676-684).
// DONE(1:1): _NORMAL_MAP — tangent-space normal sample + TBN, fed into the fresnel dot (Fragment_b229:237-260).
// DONE(1:1): _USE_SCREENUV — screen-space term (depth-scaled, view-local/world-Y options) injected into the main-UV
//   sel coords, weighted by _MainTexUVWeights.w; BuildVfxScreenUV() (Fragment_b215:147-160 vs sibling b169:156).
// DONE(1:1): _USE_DISSOLVE — dissolve threshold clip + emissive burning edge. Dissolve tex R vs schedule
//   (custom1.z*_InParticle + _DissolveScheduleOffset), edge=clamp((_DissolveEmissiveEdge-drive)*_DissolveEdgeSharp),
//   color lerps to _DissolveEmissiveColor*_TintColorIntensity, opacity*=clamp(drive*_DissolveEdgeSharp) (Fragment_b193:164-182).
// DONE(1:1): _USE_CUT_OFF — oriented-plane directional cut / teleport fade (alpha threshold). pos = lerp(objectPos,
//   worldPos, _CutOffSpace); signed = _CutOffPosY - dot(pos, _CutOffDirection.xyz); cutGate = lerp(1, step(0,signed)*
//   clamp(1 - max(signed-_CutOffWidth,0)/_CutOffTransition, 0,1), _CutOffAffectOpacity); opacity folds cutGate into the BASE
//   alpha nesting. objectPos = new positionOSCut varying (blob TEXCOORD_6), worldPos = input.positionWS. Verified directly
//   against vfxadvance Fragment_b159.hlsl:130-131,141 (isolated cutoff variant), cross-checked b193/b169. Cutoff->dissolve
//   schedule coupling (_CutOffAffectDissolve, b193:165) documented as a cross-feature contract (absent in the isolated b159).
// DONE(1:1): _USE_FRESNEL — view-angle rim term, verified directly against vfxadvance Fragment_b169.hlsl:145-176.
//   vdir = ortho ? camPos-particlePosWS : UNITY_MATRIX_V[2].xyz; ndv = clamp(dot(normalize(vdir), frontFaceFlip(N)) +
//   _FresnelBias, 0,1); fres = ndv^_FresnelPower; fresFlipped = lerp(1-fres, fres, _FresnelFlip); fresW = fresFlipped*
//   _FresnelColor.w. rgb = clamp(lerp(mainRGB*tint, _FresnelColor.rgb, fresW)/postExposure, 0,1000); opacity *=
//   lerp(1, fresFlipped, _FresnelAffectOpacity). Slot-aliased in b169 onto mask/disturb cbuffer slots + _Globals_FresnelColor.
//   N = _NORMAL_MAP-perturbed normal when that keyword is on (b229:257), else the geometric normal (b169:151).

Shader "HGRP/VfxAdvance_Fix" {
    Properties {
        [Header(Surface)]
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        _VertCameraOffset ("Vertex Camera Offset (m)", Float) = 0
        [ToggleUI] _DisableVertColor ("Disable VertColor", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 1
        [ToggleUI] _DisableParticleInstanceColor ("Disable Particle Instance Color", Float) = 0
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        [HideInInspector] _ProcedureAlpha ("Procedure Alpha", Float) = 1
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0
        [ToggleUI] _EnableTransparentMV ("Enable Transparent MV", Float) = 0

        [Header(Tint)]
        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity", Range(1, 100)) = 1
        _ExpThreshold ("Exp Threshold", Range(0, 1)) = 1
        _ExpIntensity ("Exp Intensity", Range(0, 100)) = 0
        _TintColorAlpha ("Tint Color Alpha", Range(0, 10)) = 1
        _VFXParams1 ("VFX Color Modifier (xyz mul, w desat)", Vector) = (1, 1, 1, 0)
        _VFXParams0 ("VFX Params0 (xyz = effect spot center)", Vector) = (0, 0, 0, 0)
        _ExposureParams ("Exposure Params (.x post-exposure mul)", Vector) = (1, 0, 0, 0)

        [Header(Main Tex)]
        _MainTex ("Main Tex", 2D) = "white" {}
        _MainTexUseDisturb ("Main Tex Use Disturb", Range(0, 1)) = 1
        [ToggleUI] _MainTexUseFlowmap ("Main Tex Use Flowmap", Float) = 0
        [ToggleUI] _UseMainTexAsAlpha ("UseMainTexAsAlpha", Float) = 1
        _MainTexUVSpeed ("MainTexUVSpeed(XY:Time, ZW:Custom1.X)", Vector) = (0, 0, 0, 0)
        _MainTexUVRotate ("MainTexUVRotate(Degree)", Float) = 0
        [HideInInspector] _MainTexUVRotateMat ("MainTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MainUVSet ("Main UV Set", Float) = 0
        [HideInInspector] _MainTexUVWeights ("MainTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask (alpha only)", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        _MaskTexUseDisturb ("Mask Tex Use Disturb", Range(0, 1)) = 0
        [ToggleUI] _UseMaskTexAsAlpha ("UseMaskTexAsAlpha", Float) = 1
        _MaskTexUVSpeed ("MaskTexUVSpeed(XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _MaskTexUVRotate ("MaskTexUVRotate(Degree)", Float) = 0
        [HideInInspector] _MaskTexUVRotateMat ("MaskTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MaskUVSet ("Mask UV Set", Float) = 0
        [HideInInspector] _MaskTexUVWeights ("MaskTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Blend)]
        [Toggle(_USE_BLEND)] _UseBlend ("Use Blend", Float) = 0
        _BlendTex ("Blend Tex", 2D) = "black" {}
        [ToggleUI] _BlendTexMipmapBias ("BlendTexMipmapBias", Float) = 0
        _BlendTexUseDisturb ("Blend Tex Use Disturb", Range(0, 1)) = 0
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _BlendUVSet ("Blend UV Set", Float) = 0
        [HideInInspector] _BlendTexUVWeights ("BlendTexUVWeights", Vector) = (1, 0, 0, 0)
        [HDR] [Gamma] _BlendTint ("BlendTint", Color) = (1, 1, 1, 1)
        _BlendTexUVSpeed ("BlendTexUVSpeed(XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _BlendTexUVRotate ("BlendTexUVRotate(Degree)", Float) = 0
        [HideInInspector] _BlendTexUVRotateMat ("BlendTexUVRotateMat", Vector) = (1, 0, 0, 1)

        [Header(Disturb)]
        [Toggle(_USE_DISTURB)] _UseDisturb ("Use Disturb", Float) = 0
        _DisturbTex1 ("Disturb Tex 1", 2D) = "white" {}
        _DisturbUVSpeed1 ("DisturbUVSpeed(XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _DisturbUVRotate1 ("DisturbUVRotate(Degree)", Float) = 0
        [HideInInspector] _DisturbUVRotateMat1 ("DisturbUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _DisturbUVSet1 ("DisturbTex UV Set", Float) = 0
        [HideInInspector] _DisturbUVWeights1 ("DisturbTexUVWeights", Vector) = (1, 0, 0, 0)
        [ToggleUI] _Bi_Disturb ("Disturb in 2 Direction", Float) = 0
        [ToggleUI] _DisturbTex1Normal ("Disturb Tex1 is Normal", Float) = 0
        _DisturbUIntensity1 ("UIntensity1", Float) = 0
        _DisturbVIntensity1 ("VIntensity1 (Unused In Normal)", Float) = 0

        [Header(Dissolve)]
        [Toggle(_USE_DISSOLVE)] _UseDissolve ("Use Dissolve", Float) = 0
        _DissolveTex ("Dissolve Tex", 2D) = "white" {}
        _DissolveTexUseDisturb ("Dissolve Tex Use Disturb", Range(0, 1)) = 1
        _DissolveUVSpeed ("DissolveUVSpeed(XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _DissolveUVRotate ("DissolveUVRotate(Degree)", Float) = 0
        [HideInInspector] _DissolveUVRotateMat ("DissolveUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _DissolveUVSet ("Dissolve UV Set", Float) = 0
        [HideInInspector] _DissolveUVWeights ("DissolveUVWeights", Vector) = (1, 0, 0, 0)
        _DissolveScheduleOffset ("Dissolve Schedule Offset", Range(0, 2)) = 0
        _DissolveEdgeSharp ("Dissolve Edge Sharp", Range(0.001, 100)) = 1
        _DissolveEmissiveEdge ("Dissolve Edge Emissive", Range(0, 0.5)) = 0
        [HDR] [Gamma] _DissolveEmissiveColor ("Dissolve Edge Emissive Color", Color) = (0, 0, 0, 0)

        [Header(Bright)]
        [Toggle(_USE_BRIGHT)] _UseBright ("Use Bright", Float) = 0
        [HDR] [Gamma] _BrightColor ("Bright (Scanline) Color", Color) = (1, 1, 1, 1)
        [Enum(Spot, 0, Doughnut, 1)] _BrightType ("Bright Type", Float) = 0
        [ToggleUI] _BrightUseVertColor ("Bright uses vertex Alpha", Float) = 0
        _InnerRadius ("Inner Radius (feather)", Range(0, 10)) = 0
        _OuterRadius ("Outer Radius (feather)", Range(0, 10)) = 2
        _CharacterHeight ("Character Height", Float) = 1.5
        _DistortScale ("Distort Scale", Float) = 5
        _DistortSpeed ("Distort Speed", Float) = 1
        _DistortIntensity ("Distort Intensity", Range(0, 1)) = 0
        _DistortAlpha ("Distort Alpha", Range(-1, 1)) = 1
        _DistortOnEdge ("Distort On Edge", Float) = 0
        _DoughnutRadius ("Doughnut Radius", Range(0, 50)) = 10
        _DoughnutWidth ("Doughnut Width", Range(0, 20)) = 5
        _BrightCenter ("Override center (0 = main actor pos)", Vector) = (0, 0, 0, 0)

        [Header(CubeMap)]
        [Toggle(_USE_CUBEMAP)] _UseCubeMap ("Use CubeMap (rgb only)", Float) = 0
        _CubeMap ("Cube Map", Cube) = "blackCube" {}
        _CubeMapColor ("Cube Map Color", Color) = (1, 1, 1, 1)

        [Header(Fresnel)]
        [Toggle(_USE_FRESNEL)] _UseFresnel ("Use Fresnel", Float) = 0
        [HDR] [Gamma] _FresnelColor ("Fresnel Color", Color) = (1, 1, 1, 1)
        _FresnelBias ("Fresnel Bias", Range(-1, 2)) = 0
        _FresnelAffectOpacity ("Fresnel Affect Opacity", Range(0, 1)) = 1
        _FresnelPower ("Fresnel Power", Range(1, 10)) = 1
        [ToggleUI] _FresnelFlip ("Fresnel Flip", Float) = 0.001

        [Header(EdgeColor)]
        [Toggle(_USE_EDGECOLOR)] _UseEdgeColor ("Use EdgeColor", Float) = 0
        _EdgeDistance ("Edge Distance", Range(0.001, 10)) = 0.001
        _EdgeDistanceOffset ("Edge Distance Offset", Range(0.0001, 10)) = 0.001
        [HDR] [Gamma] _EdgeColor ("Edge Color", Color) = (1, 1, 1, 1)

        [Header(Height Color Gradient)]
        [Toggle(_HEIGHT_COLOR_GRADIENT)] _UseHeightColorGradient ("Use Height Color Gradient", Float) = 0
        [HDR] [Gamma] _HeightColorGradientColor ("Height Gradient Color", Color) = (1.85, 1.85, 1.85, 1)
        _HeightColorGradientLocationDown ("Gradient Location Down", Float) = 1.42
        _HeightColorGradientLocationTop ("Gradient Location Top", Float) = 100
        _HeightColorGradientSmooth ("Gradient Smooth", Range(0.01, 0.8)) = 0.78
        _HeightColorGradientAffectColor ("Gradient Affect Color", Range(0, 1)) = 1
        _HeightColorGradientAffectAlpha ("Gradient Affect Alpha", Range(0, 1)) = 0
        [Space] [HDR] [Gamma] _HeightColorGradientColor2 ("Height Gradient Color2", Color) = (0, 0, 0, 0)
        _HeightColorGradientLocationDown2 ("Gradient Location Down2", Float) = -10
        _HeightColorGradientLocationTop2 ("Gradient Location Top2", Float) = 0.3
        _HeightColorGradientSmooth2 ("Gradient Smooth2", Range(0.01, 0.8)) = 0.3
        _HeightColorGradientAffectColor2 ("Gradient Affect Color2", Range(0, 1)) = 0
        _HeightColorGradientAffectAlpha2 ("Gradient Affect Alpha2", Range(0, 1)) = 0

        [Header(Emission)]
        [Toggle(_EMISSION)] _UseEmission ("Use Emission", Float) = 0
        _EmissionTex ("Emission Tex", 2D) = "black" {}
        [HDR] [Gamma] _EmissionColor ("Emission Color", Color) = (1, 1, 1, 1)

        [Header(Vertex Offset)]
        [Toggle(_USE_VERTOFFSET)] _UseVertexOffset ("Use Vertex Offset", Float) = 0
        _OffsetTex ("Offset Tex", 2D) = "white" {}
        _OffsetSpeed ("Offset Speed(XY:Time, ZW:Custom)", Vector) = (0, 0, 0, 0)
        _OffsetDir ("Offset Dir(XYZ:Axis, W:Custom.Y)", Vector) = (0, 0, 0, 0)
        [Enum(Object, 0, World, 1, Normal, 2)] _OffsetSwitchDir ("Dir Switcher", Float) = 0
        _OffsetIntensity ("Offset Intensity", Float) = 0
        [ToggleUI] _Bi_Offset ("Use Two Direction Offset", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _OffsetUVSet ("Vertex Offset UV Set", Float) = 0
        [Toggle(_USE_VERTOFFSETMASK)] _UseVertexOffsetMask ("Use Vertex Offset Mask", Float) = 0
        _OffsetMaskTex ("Offset Mask Tex", 2D) = "white" {}
        _OffsetMaskSpeed ("Offset Mask Speed(XY:Time, ZW:Custom)", Vector) = (0, 0, 0, 0)
        _OffsetMaskPower ("Offset Mask Power", Range(0, 5)) = 0
        [Toggle(_USE_VERTOFFSET_CHARPOS)] _UseVertexOffsetCharPos ("Ring offset around actor", Float) = 0
        _VertexOffsetDoughnutIntensity ("Ring offset intensity", Float) = 0
        _VertexOffsetDoughnutRadius ("Ring offset radius", Range(0, 100)) = 5
        _VertexOffsetDoughnutWidth ("Ring offset width", Range(0, 200)) = 10

        [Header(AirWall)]
        [Toggle(_USE_AIRWALL)] _UseAirWallTexture ("Use AirWall texture", Float) = 0
        _AirWallTex ("AirWall Tex", 2D) = "white" {}
        [ToggleUI] _UseAirWallTexAsAlpha ("Use AirWall Tex As Alpha", Float) = 0
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _AirWallUVSet ("Air Wall UV Set", Float) = 0
        [HideInInspector] _AirWallUVWeights ("AirWallUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Under Ground)]
        [Toggle(_USE_UNDER_GROUND)] _UseUnderGround ("Under-ground fade FX", Float) = 0
        _UnderGroundPlaneYOffset ("Ground plane Y offset", Float) = 0
        _UnderGroundFadeDistance ("Under-ground fade distance", Float) = 1

        [Header(Cut Off)]
        [Toggle(_USE_CUT_OFF)] _UseCutOff ("Directional cut / teleport", Float) = 0
        [Enum(Object, 0, World, 1)] _CutOffSpace ("Space (World = asset FX)", Float) = 0
        _CutOffPosY ("Cut Off Pos Y", Float) = 1
        _CutOffDirection ("Cut Off Direction", Vector) = (0, 1, 0, 0)
        _CutOffWidth ("Solid kept width", Range(0, 50)) = 1
        _CutOffTransition ("Transition fade width", Range(0.001, 5)) = 1
        _CutOffAffectOpacity ("Cut affects opacity", Range(0, 1)) = 1
        _CutOffAffectDissolve ("Cut affects dissolve", Range(-2, 2)) = 0

        [Header(Screen UV)]
        [Toggle(_USE_SCREENUV)] _UseScreenUV ("Use Screen UV", Float) = 0
        [ToggleUI] _UsePosYAsScreenV ("Use world-Y as V", Float) = 0
        [ToggleUI] _ScreenUVUseDepth ("Screen UV affected by depth", Float) = 1
        _LocalPivortSpace ("Local Pivot Space (0=screen, 1=view-local)", Range(0, 1)) = 0

        [Header(Fog)]
        [Toggle(_USE_FOG)] _UseFog ("Use Fog", Float) = 0

        [Header(Flowmap)]
        [Toggle(_USE_FLOWMAP)] _UseFlowmap ("Use Flowmap", Float) = 0
        _FlowmapTex ("Flowmap Tex", 2D) = "white" {}
        _FlowmapUVPannerSpeed ("FlowmapUVSpeed(XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _FlowmapUVRotate ("FlowmapUVRotate(Degree)", Float) = 0
        _FlowmapStrength ("Flowmap Disturb Strength", Float) = 0.5
        _FlowmapSpeed ("Flowmap Velocity", Float) = 0.1

        [Header(Sludge)]
        [Toggle(_USE_SLUDGE)] _UseSludge ("Sludge erosion range", Float) = 0
        _SludgeHeightTextureParams0 ("SludgeHeightTextureParams0", Vector) = (0, 0, 0, 0)
        _SludgeHeightTextureParams1 ("SludgeHeightTextureParams1", Vector) = (0, 0, 0, 0)
        _SludgeHeightTextureParams2 ("SludgeHeightTextureParams2", Vector) = (0, 0, 0, 0)
        _SludgeHeightTextureParams3 ("SludgeHeightTextureParams3", Vector) = (0, 0, 0, 0)
        _SludgeHeightTexture ("SludgeHeightTexture", 2D) = "white" {}
        _SludgeHeightTextureEdgeSharp ("Sludge edge alpha sharpness", Float) = 20

        [Header(Normal Map)]
        [Toggle(_NORMAL_MAP)] _EnableNormalMap ("Normal Map", Float) = 0
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 3)) = 1
        _NormalMapUVSpeed ("NormalMapUVSpeed(XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _NormalMapUVRotate ("NormalMap UVRotate", Float) = 0
        [HideInInspector] _NormalMapUVRotateMat ("NormalMapUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _NormalMapUVSet ("NormalMap UV Set", Float) = 0
        [HideInInspector] _NormalMapUVWeights ("NormalMapUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Near Camera Fade)]
        _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Start 1", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Fade End 1", Range(0.001, 3000)) = 10
        _NearCameraFadeDistanceEnd2 ("Fade End 2", Range(0.002, 3000)) = 100
        _NearCameraFadeDistanceStart2 ("Fade Start 2", Range(0.001, 3000)) = 120

        [Header(Soft Blend)]
        [Toggle(_USE_SOFTBLEND)] _UseSoftBlend ("Use SoftBlend", Float) = 0
        _SoftDistance ("Soft Distance", Range(0.001, 10)) = 0.001
        _SoftBias ("Soft Bias", Float) = 0

        [Header(Ink Simulation)]
        [Toggle(_USE_INK_SIMULATION)] _UseInkSimulation ("Use ink (water-ink) FX", Float) = 0
        [Enum(ColorDistortScene, 0, ColorDistort, 1, Distort, 2)] _InkSimulationType ("Ink influence type", Float) = 2
        _InkColor ("Ink Color", Color) = (0, 0, 0, 1)
        _InkStrength ("Ink Strength", Float) = 15
        _InkMaxAlpha ("Ink Max Alpha", Range(0, 1)) = 0.8
        _InkDisturbOffset ("Effect distort strength", Range(0, 0.1)) = 0.025
        _InkSceneDisturbOffset ("Scene distort strength", Range(0, 0.1)) = 0.025
        // HGRP ink-simulation render targets + world->UV xform (globals in source, re-exposed as material slots; see CBUFFER note).
        [HideInInspector] _InkSimulationTex ("Ink Sim Displacement (RG)", 2D) = "black" {}
        [HideInInspector] _InkSimulationColorTex ("Ink Sim Coverage (R)", 2D) = "black" {}
        [HideInInspector] _InkSimulationWorldToUV ("Ink Sim World->UV (xy=off .z=offV .w=scale)", Vector) = (0, 0, 0, 0)

        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
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
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Surface flags (Fragment_b155:54-66)
                float _SurfaceType;
                float _BlendMode;
                float _Responsive;
                float _EnableTransparentMV;
                float _InParticle;
                float _DisableVertColor;
                float _DisableParticleInstanceColor;
                float _IgnorePostExposure;
                float _VertCameraOffset;
                float _ProcedureAlpha;
                // Tint / exposure / glow (Fragment_b155:62-67)
                float4 _TintColor;
                float _TintColorIntensity;
                float _TintColorAlpha;
                float _ExpThreshold;
                float _ExpIntensity;
                float4 _VFXParams1;
                float4 _VFXParams0;
                float4 _ExposureParams;
                // Main tex (Fragment_b155:68-73)
                float4 _MainTex_ST;
                float _MainTexUseDisturb;
                float _MainTexUseFlowmap;
                float _UseMainTexAsAlpha;
                float4 _MainTexUVSpeed;
                float _MainTexUVRotate;
                float4 _MainTexUVRotateMat;
                float _MainUVSet;
                float4 _MainTexUVWeights;
                // Mask (Fragment_b155:74-82 / b157 mask slots)
                float4 _MaskTex_ST;
                float _MaskTexUseDisturb;
                float _UseMaskTexAsAlpha;
                float4 _MaskTexUVSpeed;
                float _MaskTexUVRotate;
                float4 _MaskTexUVRotateMat;
                float _MaskUVSet;
                float4 _MaskTexUVWeights;
                // Blend
                float4 _BlendTex_ST;
                float _BlendTexMipmapBias;
                float _BlendTexUseDisturb;
                float _BlendUVSet;
                float4 _BlendTexUVWeights;
                float4 _BlendTint;
                float4 _BlendTexUVSpeed;
                float _BlendTexUVRotate;
                float4 _BlendTexUVRotateMat;
                // Disturb
                float4 _DisturbTex1_ST;
                float4 _DisturbUVSpeed1;
                float _DisturbUVRotate1;
                float4 _DisturbUVRotateMat1;
                float _DisturbUVSet1;
                float4 _DisturbUVWeights1;
                float _Bi_Disturb;
                float _DisturbTex1Normal;
                float _DisturbUIntensity1;
                float _DisturbVIntensity1;
                // Dissolve
                float4 _DissolveTex_ST;
                float _DissolveTexUseDisturb;
                float4 _DissolveUVSpeed;
                float _DissolveUVRotate;
                float4 _DissolveUVRotateMat;
                float _DissolveUVSet;
                float4 _DissolveUVWeights;
                float _DissolveScheduleOffset;
                float _DissolveEdgeSharp;
                float _DissolveEmissiveEdge;
                float4 _DissolveEmissiveColor;
                // Bright / distort
                float4 _BrightColor;
                float _BrightType;
                float _BrightUseVertColor;
                float _InnerRadius;
                float _OuterRadius;
                float _CharacterHeight;
                float _DistortScale;
                float _DistortSpeed;
                float _DistortIntensity;
                float _DistortAlpha;
                float _DistortOnEdge;
                float _DoughnutRadius;
                float _DoughnutWidth;
                float4 _BrightCenter;
                // CubeMap
                float4 _CubeMapColor;
                // Fresnel
                float4 _FresnelColor;
                float _FresnelBias;
                float _FresnelAffectOpacity;
                float _FresnelPower;
                float _FresnelFlip;
                // EdgeColor
                float _EdgeDistance;
                float _EdgeDistanceOffset;
                float4 _EdgeColor;
                // Height color gradient
                float4 _HeightColorGradientColor;
                float _HeightColorGradientLocationDown;
                float _HeightColorGradientLocationTop;
                float _HeightColorGradientSmooth;
                float _HeightColorGradientAffectColor;
                float _HeightColorGradientAffectAlpha;
                float4 _HeightColorGradientColor2;
                float _HeightColorGradientLocationDown2;
                float _HeightColorGradientLocationTop2;
                float _HeightColorGradientSmooth2;
                float _HeightColorGradientAffectColor2;
                float _HeightColorGradientAffectAlpha2;
                // Emission
                float4 _EmissionTex_ST;
                float4 _EmissionColor;
                // Vertex offset
                float4 _OffsetTex_ST;
                float4 _OffsetSpeed;
                float4 _OffsetDir;
                float _OffsetSwitchDir;
                float _OffsetIntensity;
                float _Bi_Offset;
                float _OffsetUVSet;
                float4 _OffsetMaskTex_ST;
                float4 _OffsetMaskSpeed;
                float _OffsetMaskPower;
                float _VertexOffsetDoughnutIntensity;
                float _VertexOffsetDoughnutRadius;
                float _VertexOffsetDoughnutWidth;
                // AirWall
                float4 _AirWallTex_ST;
                float _UseAirWallTexAsAlpha;
                float _AirWallUVSet;
                float4 _AirWallUVWeights;
                // Under ground
                float _UnderGroundPlaneYOffset;
                float _UnderGroundFadeDistance;
                // Cut off
                float _CutOffSpace;
                float _CutOffPosY;
                float4 _CutOffDirection;
                float _CutOffWidth;
                float _CutOffTransition;
                float _CutOffAffectOpacity;
                float _CutOffAffectDissolve;
                // Screen UV
                float _UsePosYAsScreenV;
                float _ScreenUVUseDepth;
                float _LocalPivortSpace;
                // Flowmap
                float4 _FlowmapTex_ST;
                float4 _FlowmapUVPannerSpeed;
                float _FlowmapUVRotate;
                float _FlowmapStrength;
                float _FlowmapSpeed;
                // Sludge
                float4 _SludgeHeightTextureParams0;
                float4 _SludgeHeightTextureParams1;
                float4 _SludgeHeightTextureParams2;
                float4 _SludgeHeightTextureParams3;
                float4 _SludgeHeightTexture_ST;
                float _SludgeHeightTextureEdgeSharp;
                // Normal map
                float4 _NormalMap_ST;
                float _NormalScale;
                float4 _NormalMapUVSpeed;
                float _NormalMapUVRotate;
                float4 _NormalMapUVRotateMat;
                float _NormalMapUVSet;
                float4 _NormalMapUVWeights;
                // Near camera fade
                float _UseNearCameraFade;
                float _NearCameraFadeDistanceStart;
                float _NearCameraFadeDistanceEnd;
                float _NearCameraFadeDistanceStart2;
                float _NearCameraFadeDistanceEnd2;
                // Soft blend
                float _SoftDistance;
                float _SoftBias;
                // Ink simulation
                float _InkSimulationType;
                float4 _InkColor;
                float _InkStrength;
                float _InkMaxAlpha;
                float _InkDisturbOffset;
                float _InkSceneDisturbOffset;
                // HGRP ink-simulation world->UV transform (source: cbuffer type_ShaderVariablesGlobal _InkSimulationWorldToUV,
                //   Fragment_b167:46 / b165:46, packoffset c206). URP has no ink-simulation global -> re-exposed as a material
                //   Vector (STYLE_BIBLE §2 HGRP-global -> material). .xy = world->UV offset (X,Z planes), .w = world->UV scale.
                float4 _InkSimulationWorldToUV;
            CBUFFER_END

            TEXTURE2D(_MainTex);      SAMPLER(sampler_MainTex);
            TEXTURE2D(_MaskTex);      SAMPLER(sampler_MaskTex);
            TEXTURE2D(_BlendTex);     SAMPLER(sampler_BlendTex);
            TEXTURE2D(_DisturbTex1);  SAMPLER(sampler_DisturbTex1);
            TEXTURE2D(_DissolveTex);  SAMPLER(sampler_DissolveTex);
            TEXTURE2D(_EmissionTex);  SAMPLER(sampler_EmissionTex);
            TEXTURE2D(_NormalMap);    SAMPLER(sampler_NormalMap);
            TEXTURE2D(_AirWallTex);   SAMPLER(sampler_AirWallTex);
            TEXTURE2D(_FlowmapTex);   SAMPLER(sampler_FlowmapTex);
            TEXTURE2D(_SludgeHeightTexture); SAMPLER(sampler_SludgeHeightTexture); // sludge erosion height map (vertex-stage, Vertex_b162:360)
            TEXTURE2D(_OffsetTex);    SAMPLER(sampler_OffsetTex);  // vertex-offset magnitude mask (vertex-stage, Vertex_b212:352 T1.SampleLevel LOD0)
            TEXTURECUBE(_CubeMap);    SAMPLER(sampler_CubeMap);
            // Ink-simulation render targets (source globals T1/T2 sampled with sampler_LinearClamp at LOD0; Fragment_b167:90 /
            //   b165:94-95). HGRP ink-sim buffers -> no URP equivalent -> material textures (STYLE_BIBLE §2). _InkSimulationTex
            //   RG = water-ink displacement; _InkSimulationColorTex R = ink coverage/density (only the _INK_COLOR_DISTORT path).
            TEXTURE2D(_InkSimulationTex);      SAMPLER(sampler_InkSimulationTex);
            TEXTURE2D(_InkSimulationColorTex); SAMPLER(sampler_InkSimulationColorTex);

            // Rec.709 luma. Blob: float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625) (Fragment_b155:131)
            static const float3 LUM = float3(0.2126729041, 0.7151522040, 0.0721750036);
            // deg -> rad. Blob (sibling Vertex): 0.01745329238474369049072265625
            static const float DEG2RAD = 0.0174532924;
            // view-length epsilon. Blob: 9.9999999392252902907785028219223e-09 == 1e-8 (Fragment_b155:138-139)
            static const float VIEW_EPS = 9.9999999e-09;
            static const float ONE = 1.0; // asfloat(1065353216u)
            // value-noise hash consts (_USE_BRIGHT distort). Blob: float2(12.98980045318603515625, 78.233001708984375), 43758.546875 (b211:191)
            static const float2 HASH_K = float2(12.98980045318603515625, 78.233001708984375);
            static const float  HASH_M = 43758.546875;
            // 1/1024 noise-cell step. Blob: 0.0009765625 (b211:183-186). V-lane const: 0.010999999940395355224609375 (b211:199,206).
            static const float  NOISE_STEP = 0.0009765625;
            static const float  NOISE_K011 = 0.010999999940395355224609375;

            // World position from screen UV + raw device depth. (Fragment_b155:114-116 NDC->clip->world via _InvViewProjMatrix).
            // URP: UNITY_MATRIX_I_VP. Note blob y-flip: ndcY = -(uv.y*2-1).
            float3 ReconstructWorldPos(float2 screenUV, float deviceZ)
            {
                float ndcX = mad(screenUV.x, 2.0, -1.0);
                float ndcY = (-0.0) - mad(screenUV.y, 2.0, -1.0);
                float4 hpos = mul(UNITY_MATRIX_I_VP, float4(ndcX, ndcY, deviceZ, 1.0));
                return hpos.xyz / hpos.w;
            }

            // |view-space Z| of a world point. (Fragment_b155:117 expands _ViewMatrix row-2 dot then abs())
            float ViewSpaceZAbs(float3 posWS)
            {
                return abs(mul(UNITY_MATRIX_V, float4(posWS, 1.0)).z);
            }

            // post-exposure divisor lerp(1, _ExposureParams.x, _IgnorePostExposure). (Fragment_b155:127)
            float PostExposure()
            {
                return mad(_ExposureParams.x, _IgnorePostExposure, 1.0 + ((-0.0) - _IgnorePostExposure));
            }

            // vertColor select: lerp(vc, 1, _DisableVertColor) per channel = mad(_DisableVertColor, 1-vc, vc). (Fragment_b155:126-130)
            float3 VertColorRGB(float3 vc)
            {
                float3 o;
                o.x = mad(_DisableVertColor, ((-0.0) - vc.x) + 1.0, vc.x);
                o.y = mad(_DisableVertColor, ((-0.0) - vc.y) + 1.0, vc.y);
                o.z = mad(_DisableVertColor, ((-0.0) - vc.z) + 1.0, vc.z);
                return o;
            }
            float VertColorA(float va) { return mad(_DisableVertColor, ((-0.0) - va) + 1.0, va); }

            // lerp(rgb, 1, _useAsAlpha) per channel. (Fragment_b155:128-130 mad(_UseMainTexAsAlpha, 1-rgb, rgb))
            float3 UseTexAsAlphaRGB(float3 rgb, float useAsAlpha)
            {
                float3 o;
                o.x = mad(useAsAlpha, ((-0.0) - rgb.x) + ONE, rgb.x);
                o.y = mad(useAsAlpha, ((-0.0) - rgb.y) + ONE, rgb.y);
                o.z = mad(useAsAlpha, ((-0.0) - rgb.z) + ONE, rgb.z);
                return o;
            }

            // Build main/secondary anim UV: rotate(about 0.5 via rotateMat)+pan(speed.xy*time, speed.zw*custom)+UVweights select.
            // (Fragment_b155:119 main-tex UV expression, generalized.) rotateMat = (cos, sin, -sin, cos) packed (x,y,z,w).
            // uvSel: blend of (uv0.xy) and the precomputed polar pair (uv0.zw rebuilt vs uv1.xy) via _MainTexUVWeights.x/.y.
            float2 BuildVfxUV(float4 uv0, float4 uv1, float4 speed, float4 weights, float4 rotateMat, float4 st, float chanScroll, float customTime)
            {
                float inP = _InParticle;
                // selected base coordinate (Fragment_b155:119 inner: mad(uv0.x,wx, polarX*wy))
                float polarX = mad(uv0.z, inP, ((-0.0) - (uv1.x * inP))) + uv1.x;
                float polarY = mad(uv0.w, inP, ((-0.0) - (uv1.y * inP))) + uv1.y;
                float selX = mad(uv0.x, weights.x, polarX * weights.y);
                float selY = mad(uv0.y, weights.x, polarY * weights.y);
                // pan + center to -0.5 (Fragment_b155:119: mad(speed.z,chanScroll, mad(speed.x,customTime, sel)) + (-0.5))
                float panX = mad(speed.z, chanScroll, mad(speed.x, customTime, selX)) + (-0.5);
                float panY = mad(speed.w, chanScroll, mad(speed.y, customTime, selY)) + (-0.5);
                // rotate about origin by rotateMat then + 0.5 then *ST  (Fragment_b155:119 outer)
                float rotX = (panY * rotateMat.z) + (panX * rotateMat.x) + 0.5;
                float rotY = (panY * rotateMat.w) + (panX * rotateMat.y) + 0.5;
                return float2(mad(rotX, st.x, st.z), mad(rotY, st.y, st.w));
            }

            // Value-noise cell hash for the _USE_BRIGHT distort. 1:1 source = vfxadvance Fragment_b211.hlsl:191
            //   (frac(sin(dot(sign(cell)*frac(abs(cell))*1024, HASH_K))*HASH_M)); the decompiler spells the sign() as the
            //   ternary (cell>=-cell ? a : -a). Identical hash to the sibling exemplar HGRP_VfxBaseBatched_Fix:365-372.
            float HashCell(float2 cell)
            {
                float2 a = frac(abs(cell));
                float2 sgn;
                sgn.x = (cell.x >= ((-0.0) - cell.x)) ? a.x : ((-0.0) - a.x);
                sgn.y = (cell.y >= ((-0.0) - cell.y)) ? a.y : ((-0.0) - a.y);
                return frac(sin(dot(sgn * 1024.0, HASH_K)) * HASH_M);
            }

        #if defined(_USE_SCREENUV)
            // _USE_SCREENUV main-UV variant. 1:1 source = vfxadvance Fragment_b215.hlsl:147-160 (HG_ENABLE_MV+_USE_CUT_OFF+
            //   _USE_FRESNEL+_USE_SCREENUV), isolated against the no-screenUV sibling Fragment_b169.hlsl:156. The ONLY delta is
            //   that the BASE selX/selY (BuildVfxUV) gain a screen-space term: selX += (depthScale * screenX) * weights.w
            //   (b215:158 mad(_104*_175, _MainTexUVWeights.w, <base selX>)), selY += (depthScale * screenY) * weights.w (b215:159).
            //   weights.w == _MainTexUVWeights.w (free in the base UV, which uses only .x/.y) is the screen-UV blend weight.
            //   Everything downstream (pan/rotate/+0.5/*ST) is identical to BuildVfxUV. Slot-aliasing in b215 (these three
            //   are lifted from _MaskTexUVRotateMat.xyz to named scalar props): _UsePosYAsScreenV=_MaskTexUVRotateMat.x,
            //   _ScreenUVUseDepth=_MaskTexUVRotateMat.y, _LocalPivortSpace=_MaskTexUVRotateMat.z.
            float2 BuildVfxScreenUV(float4 uv0, float4 uv1, float4 speed, float4 weights, float4 rotateMat, float4 st,
                                    float chanScroll, float customTime, float3 positionWS, float4 positionCS)
            {
                float inP = _InParticle;
                // --- screen-space coordinates from pixel position (b215:153-154) ---
                // ndcX = fragCoord.x/screen.x*2-1 ; ndcY = fragCoord.y/screen.y*2-1, aspect-scaled by (screen.y/screen.x).
                float ndcX = mad(positionCS.x / _ScreenParams.x, 2.0, -1.0);                        // (b215:153 _156)
                float ndcY = (mad(positionCS.y / _ScreenParams.y, 2.0, -1.0) / _ScreenParams.x) * _ScreenParams.y; // (b215:154 _167)
                // --- view-space position relative to the object pivot (b215:150-152,155-156) ---
                float3 objOrigin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23); // (b215:150-152 _unity_ObjectToWorld[3u].xyz)
                float3 rel = positionWS - objOrigin;                                                // (b215:150-152 _120/_121/_122)
                float3 viewRel = mul((float3x3)UNITY_MATRIX_V, rel);                                // V-row0/1 dot rel = view X/Y (b215:155 inner, b215:156 inner)
                // local-pivot blend: lerp(ndc, viewRel, _LocalPivortSpace). (b215:155 _175, b215:156 else _184)
                float screenX = mad(_LocalPivortSpace, viewRel.x + ((-0.0) - ndcX), ndcX);          // (b215:155 _175)
                float screenYView = mad(_LocalPivortSpace, viewRel.y + ((-0.0) - ndcY), ndcY);      // (b215:156 else-branch)
                // V can be overridden by world-Y. (b215:156 _184 ternary on _MaskTexUVRotateMat.x)
                float screenY = (0.0 != _UsePosYAsScreenV) ? positionWS.y : screenYView;            // (b215:156 _184)
                // --- depth scale on the object pivot's view-space Z (b215:149 _104) ---
                // viewZobj = (V * float4(objOrigin,1)).z ; depthScale = lerp(1, max(-viewZobj - near, 1), _ScreenUVUseDepth).
                float viewZobj = mul(UNITY_MATRIX_V, float4(objOrigin, 1.0)).z;                     // (b215:149 inner)
                float depthClamp = max((((-0.0) - viewZobj) + ((-0.0) - _ProjectionParams.y)), 1.0); // (b215:149 max(...,1))
                float depthScale = mad(depthClamp, _ScreenUVUseDepth, 1.0 + ((-0.0) - _ScreenUVUseDepth)); // (b215:149 _104)
                // --- BASE sel coords (identical to BuildVfxUV) + injected screen term (b215:158-159) ---
                float polarX = mad(uv0.z, inP, ((-0.0) - (uv1.x * inP))) + uv1.x;                   // (b215:158 inner polar)
                float polarY = mad(uv0.w, inP, ((-0.0) - (uv1.y * inP))) + uv1.y;                   // (b215:159 inner polar)
                float selX = mad(depthScale * screenX, weights.w, mad(uv0.x, weights.x, polarX * weights.y)); // (b215:158)
                float selY = mad(depthScale * screenY, weights.w, mad(uv0.y, weights.x, polarY * weights.y)); // (b215:159)
                // pan + center + rotate + ST (identical to BuildVfxUV; b215:158-159 outer == b169:156)
                float panX = mad(speed.z, chanScroll, mad(speed.x, customTime, selX)) + (-0.5);
                float panY = mad(speed.w, chanScroll, mad(speed.y, customTime, selY)) + (-0.5);
                float rotX = (panY * rotateMat.z) + (panX * rotateMat.x) + 0.5;
                float rotY = (panY * rotateMat.w) + (panX * rotateMat.y) + 0.5;
                return float2(mad(rotX, st.x, st.z), mad(rotY, st.y, st.w));
            }
        #endif
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }

            // Source: Blend 0 [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend]  (vfxadvance.shader:215)
            //   + Blend 1 MV (dropped with SV_Target1). ZClip On / ZTest [_ZTest] / ZWrite [_ZWrite] / Cull [_CullMode].
            Blend [_SrcBlend] [_DstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            // URP system keyword for camera-distance fog (FOG_LINEAR/FOG_EXP/FOG_EXP2). Drives MixFog()
            //   under #ifdef _USE_FOG below (STYLE_BIBLE §3.1 "URP system keywords use #pragma multi_compile").
            #pragma multi_compile_fog

            #pragma shader_feature_local _USE_MASK
            #pragma shader_feature_local _USE_BLEND
            #pragma shader_feature_local _USE_DISTURB
            #pragma shader_feature_local _USE_DISSOLVE
            #pragma shader_feature_local _USE_FRESNEL
            #pragma shader_feature_local _USE_BRIGHT
            #pragma shader_feature_local _USE_SOFTBLEND
            #pragma shader_feature_local _USE_CUBEMAP
            // vfxadvance-unique feature keywords (ported 1:1 below from the isolated per-feature blobs):
            #pragma shader_feature_local _USE_AIRWALL
            #pragma shader_feature_local _USE_CUT_OFF
            #pragma shader_feature_local _USE_UNDER_GROUND
            // _USE_SLUDGE: VERTEX-stage height-texture geometry erosion (NaN clip-cull). Math ported in vert() (Vertex_b162:357-364).
            #pragma shader_feature_local _USE_SLUDGE
            #pragma shader_feature_local _INK_DISTORT
            #pragma shader_feature_local _INK_COLOR_DISTORT
            #pragma shader_feature_local _USE_SCREENUV
            #pragma shader_feature_local _NORMAL_MAP
            #pragma shader_feature_local _HEIGHT_COLOR_GRADIENT
            #pragma shader_feature_local _EMISSION
            #pragma shader_feature_local _USE_EDGECOLOR
            #pragma shader_feature_local _USE_FOG
            #pragma shader_feature_local _USE_FLOWMAP
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _USE_VERTOFFSET_CHARPOS

            struct Attributes
            {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;
                float4 uv0        : TEXCOORD0;
                float4 uv1        : TEXCOORD1;
            #if defined(_USE_SLUDGE)
                // Per-particle world-pivot for sludge height erosion. The sludge vertex blobs add an extra TEXCOORD2
                //   input (Vertex_b162 SPIRV_Cross_Input adds `float4 TEXCOORD_2 : TEXCOORD2`, absent in base b154) that is
                //   transformed by ObjectToWorld (NO camera-relative rebase) to drive the height-texture lookup (Vertex_b162:357-359).
                float4 uv2        : TEXCOORD2;
            #endif
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float4 uvMain     : TEXCOORD0; // xy = raw uv0.xy, zw = main rotated+ST uv (Vertex_b154 outputs uv0->TEXCOORD1, frag rebuilds)
                float4 color      : TEXCOORD1; // vertex color rgba (Vertex_b154:306-309, particle scale dropped)
                float4 custom     : TEXCOORD2; // uv1 (particle custom data; .x=custom1.x, .y=custom1.y) (Vertex_b154 TEXCOORD2)
                float3 positionWS : TEXCOORD3;
            #if defined(_USE_FRESNEL) || defined(_NORMAL_MAP) || defined(_INK_DISTORT) || defined(_INK_COLOR_DISTORT)
                // Ink FX also reads the interpolated world normal (its .y drives the ink distort/coverage factor,
                //   Fragment_b167:140 / b165:138 rsqrt(dot(N,N))*N.y) -> share this varying with fresnel/normal-map.
                float3 normalWS   : TEXCOORD4;
            #endif
            #if defined(_NORMAL_MAP)
                // World tangent (.xyz) + bitangent sign (.w). Blob Vertex_b228:482-486:
                //   TEXCOORD_3.xyz = normalize(world tangent), .w = oddNegativeScale_sign * tangent.w.
                float4 tangentWS  : TEXCOORD5;
                // Pre-built normal-map anim UV (rotate+pan+ST), same vertex-built idiom as the sibling's
                //   secondary UVs (HGRP_VfxBaseBatched_Fix:455-470). Needs the true uv0.zw polar pair, only in vert.
                float2 uvNormal   : TEXCOORD6;
            #endif
            #if defined(_USE_SCREENUV)
                // Polar pair uv0.zw, needed to rebuild the BASE main-UV sel coords in the fragment
                //   (screen-UV injects a fragment-only term into selX/selY, so the whole UV is reassembled in frag).
                //   Source frag carries full uv0 as TEXCOORD_1 (Fragment_b215:115,129); base path drops uv0.zw as an opt.
                float2 uvPolarSrc : TEXCOORD7;
            #endif
            #if defined(_USE_DISTURB)
                // Pre-built disturb-sample UV (full rotate+weights+pan+ST via _Disturb* slots), same vertex-built idiom
                //   as the main/normal UVs. Needs uv0.zw polar pair (only in vert), so built here not in frag.
                //   Source Fragment_b255:193 builds it through the SSA-aliased _MaskTex* slots (the disturb dedicated slots).
                float2 uvDisturb  : TEXCOORD8;
            #endif
            #if defined(_USE_FLOWMAP)
                // Pre-built flowmap-sample UV (rotate-from-degrees + pan + _ST on the _Flowmap* slots), same vertex-built
                //   idiom as uvNormal/uvDisturb. Built in vert because BuildVfxUV needs the uv0.zw polar pair (vert-only).
                float2 uvFlowmap  : TEXCOORD9;
            #endif
            #if defined(_USE_DISSOLVE)
                // Pre-built dissolve-sample UV (full rotate+weights+pan+_ST via the dedicated _Dissolve* slots), same
                //   vertex-built idiom as uvDisturb/uvNormal/uvFlowmap. The vfxadvance blob builds this UV in the FRAGMENT
                //   (Fragment_b193:164 routes through the SSA-aliased _MaskTex* slots = the dissolve UV slots), but the base
                //   Varyings drop uv0.zw (the polar pair BuildVfxUV needs), so it is built in vert here — functionally 1:1
                //   (BuildVfxUV is pure given uv0/uv1/uniforms). chanScroll = custom1.y (Fragment_b193:164 _155 = uv1.y*_InParticle).
                float2 uvDissolve : TEXCOORD10;
            #endif
            #if defined(_USE_CUT_OFF)
                // Object/local-space vertex position for the cutoff plane's Object-space branch. Blob TEXCOORD_6
                //   (semantic TEXCOORD7) = raw POSITION.xyz in the non-skinned path (Vertex_b312:323-325 _445/_447/_449,
                //   carried out_var_TEXCOORD7 :369-371). The cutoff plane test lerps between this object-space pos and the
                //   world-space surface pos (input.positionWS == blob TEXCOORD) by _CutOffSpace (Fragment_b159:130-131).
                float3 positionOSCut : TEXCOORD11;
            #endif
            #if defined(_USE_AIRWALL)
                // Pre-built AirWall-sample UV. Unlike the other secondary UVs this is NOT a full BuildVfxUV: the airwall
                //   permutation b157:131 applies ONLY the HGVFX UV-set weights select + _ST (no speed pan, no rotate matrix,
                //   no -0.5/+0.5 pivot) — the airwall has no _AirWallUVSpeed/_AirWallUVRotateMat property (vfxadvance.shader
                //   :135-138 exposes only _AirWallTex/_AirWallUVSet/_AirWallUVWeights/_AirWallTex_ST). Built in vert because
                //   the weights-select needs the uv0.zw polar pair (vert-only), same reason as uvDisturb/uvDissolve.
                float2 uvAirWall  : TEXCOORD12;
            #endif
            };

            Varyings vert(Attributes input)
            {
                Varyings o = (Varyings)0;
                float customTime = _Time.y; // _VFXParams0.w in blob (Fragment_b155:119)

                // Object->World (camera-relative rebase dropped). (Vertex_b154:293-295 -> URP TransformObjectToWorld)
                float3 positionWS = TransformObjectToWorld(input.positionOS);

            #if defined(_USE_VERTOFFSET)
                // ----- _USE_VERTOFFSET: per-vertex world-space displacement (+ _USE_VERTOFFSET_CHARPOS ring around actor) -----
                // 1:1 source = vfxadvance Vertex_b212.hlsl:347-368,584-586 (the ONLY non-instanced blob carrying _USE_VERTOFFSET;
                //   its keyword set HG_ENABLE_MV+_USE_MASK+_USE_BRIGHT+_USE_BRIGHT_DOUGHNUT+_USE_VERTOFFSET+_USE_VERTOFFSET_CHARPOS
                //   is the only permutation the multi_compile emitted with vertoffset active, instanced twin = b366). Isolated
                //   against the closest non-vertoffset sibling b210 (AIRWALL+MASK+BRIGHT): b210 has NO _OffsetTex sample, NO
                //   _VFXParams0 ring, NO (1-O2W._m10) push, NO T1 texture, and its clip pos derives straight from the unmodified
                //   world position (b210:299 gl_Position.x <- _531) -> these b212 lines ARE the vertoffset delta.
                //
                // SSA slot-aliasing decoded (STYLE_BIBLE §0/§2 — the compiled b212 packs the authored _Offset*/_VertexOffsetDoughnut*
                //   uniforms onto stale pooled cbuffer labels by byte position; de-aliased here to the authored names by semantic role):
                //     _DissolveTex_ST.xyzw        (c23) = _OffsetDir.xyzw   (.xyz axis, .w "By Custom.Y" term)         (b212:350,353-355)
                //     _BlendTint.x                (c21.x) = _Bi_Offset      (two-direction: remap sample to [-x,1])      (b212:352)
                //     _BlendTint.y                (c21.y) = _OffsetSwitchDir(0=Object,1=World,2=Normal)                 (b212:348-349)
                //     _BlendTint.z                (c21.z) = _OffsetUVSet     (uv0<->polar select weight)                 (b212:351-352)
                //     _BlendTint.w                (c21.w) = _OffsetIntensity (base offset scale + ring blend floor)      (b212:350,364)
                //     _DissolveUVSpeed.xyzw       (c24) = _OffsetSpeed.xyzw (.xy By Time, .zw By Custom)                (b212:352)
                //     _DissolveTexUseDisturb,_DissolveScheduleOffset = _OffsetTex_ST.xy (scale)                        (b212:352)
                //     _DissolveEdgeSharp_at_360,_DissolveEmissiveEdge_at_364 = _OffsetTex_ST.zw (offset)               (b212:352)
                //     _DissolveEmissiveColor.xyz  (c27) = (_VertexOffsetDoughnutRadius, _VertexOffsetDoughnutWidth,
                //                                          _VertexOffsetDoughnutIntensity)                              (b212:360-364)
                //     _VFXParams0.xyz/.w (global)        = effect-spot/actor center / particle custom time (==_Time.y)  (b212:356-358,352)
                //     _unity_ObjectToWorld[1u].x (O2W._m10)  = host particle object->world matrix element              (b212:368)
                float vofCustomY = input.uv1.y * _InParticle;                                          // (b212:347 _460 = TEXCOORD_1.y*_InParticle)

                // --- offset-mask UV: pan(_OffsetSpeed) + _ST on the uv0<->polar selected coord. NOTE this is NOT BuildVfxUV:
                //     the offset UV has NO -0.5/+0.5 center pivot and NO rotate matrix (vfxadvance has no _OffsetUVRotateMat /
                //     _OffsetUVWeights property, shaderlab:119-125) -> bare sel*scale+offset then pan. (b212:352 inner) ---
                float vofInP = _InParticle;
                float vofPolarX = mad(input.uv0.z, vofInP, ((-0.0) - (input.uv1.x * vofInP))) + input.uv1.x; // (b212:352 polar == BuildVfxUV polar)
                float vofPolarY = mad(input.uv0.w, vofInP, ((-0.0) - (input.uv1.y * vofInP))) + input.uv1.y;
                float vofSelX = mad(vofPolarX, _OffsetUVSet, (1.0 + ((-0.0) - _OffsetUVSet)) * input.uv0.x); // (b212:351-352 mad(polar,_BlendTint.z, _579*TEXCOORD.x), _579=1-_BlendTint.z)
                float vofSelY = mad(vofPolarY, _OffsetUVSet, (1.0 + ((-0.0) - _OffsetUVSet)) * input.uv0.y);
                float vofUvX = mad(_OffsetSpeed.z, vofCustomY, mad(_OffsetSpeed.x, customTime,
                                   mad(vofSelX, _OffsetTex_ST.x, _OffsetTex_ST.z)));                    // (b212:352 X path)
                float vofUvY = mad(_OffsetSpeed.w, vofCustomY, mad(_OffsetSpeed.y, customTime,
                                   mad(vofSelY, _OffsetTex_ST.y, _OffsetTex_ST.w)));                    // (b212:352 Y path)
                // sample magnitude mask (LOD 0), remap by _Bi_Offset: bi=0 -> [0,1] one-sided, bi=1 -> [-1,1] two-sided. (b212:352 outer)
                float vofMask = mad(SAMPLE_TEXTURE2D_LOD(_OffsetTex, sampler_OffsetTex, float2(vofUvX, vofUvY), 0.0).x,
                                    1.0 + _Bi_Offset, (-0.0) - _Bi_Offset);
                // base offset scale = _OffsetDir.w * custom1.y + _OffsetIntensity. (b212:350 _554)
                float vofScale = mad(_OffsetDir.w, vofCustomY, _OffsetIntensity);

                // --- direction select by _OffsetSwitchDir (b212:348-349,353-355): 0=Object(O2W*dir), 1=World(dir), 2=Normal(O2W*normalOS) ---
                float3 vofDir;
                if (1.0 == _OffsetSwitchDir)                                                           // World
                {
                    vofDir = _OffsetDir.xyz;                                                           // (b212:353-355 _467 ? _DissolveTex_ST.xyz)
                }
                else if (2.0 == _OffsetSwitchDir)                                                      // Normal
                {
                    vofDir = TransformObjectToWorldDir(input.normalOS, false);                         // (b212:353-355 _468 ? O2W_3x3 * objNormal; plain matrix mul, NOT inverse-transpose)
                }
                else                                                                                  // Object
                {
                    vofDir = TransformObjectToWorldDir(_OffsetDir.xyz, false);                         // (b212:353-355 else: O2W_3x3 * _DissolveTex_ST.xyz == _OffsetDir.xyz)
                }
                float3 vofOffset = (vofMask * vofScale) * vofDir;                                      // (b212:353-355 _633/_634/_635)

                // --- _USE_VERTOFFSET_CHARPOS: distance-ring (doughnut) gate around the effect-spot center _VFXParams0.xyz ---
                //     ringFactor = (smooth01((d-(R-W))/W) + smooth01((d-(R+W))/(-W)) - 1) * (_DoughnutIntensity - _OffsetIntensity).
                //     The displacement then scales by (1 + ringFactor): outside CHARPOS this term is 0 (offset unchanged). (b212:356-365)
                float vofRing = 0.0;
            #if defined(_USE_VERTOFFSET_CHARPOS)
                float3 vofToCenter = positionWS - _VFXParams0.xyz;                                     // (b212:356-358 worldPos - _VFXParams0.xyz)
                float vofDist = sqrt(dot(vofToCenter, vofToCenter));                                   // (b212:359 _658)
                float vofInner = ((-0.0) - _VertexOffsetDoughnutWidth) + _VertexOffsetDoughnutRadius;  // (b212:360 _667 = -_DEC.y + _DEC.x = R-W)
                float vofTInner = clamp((vofDist + ((-0.0) - vofInner)) * (1.0 / (((-0.0) - vofInner) + _VertexOffsetDoughnutRadius)), 0.0, 1.0); // (b212:361 _677)
                float vofOuter = _VertexOffsetDoughnutWidth + _VertexOffsetDoughnutRadius;             // (b212:362 _688 = R+W)
                float vofTOuter = clamp((vofDist + ((-0.0) - vofOuter)) * (1.0 / (((-0.0) - vofOuter) + _VertexOffsetDoughnutRadius)), 0.0, 1.0); // (b212:363 _698)
                // smoothstep(0,1,t) = t*t*(3-2t); ring = sInner + sOuter - 1, scaled by (intensity - baseIntensity). (b212:364 _712)
                vofRing = mad(mad(vofTInner, -2.0, 3.0), vofTInner * vofTInner,
                              (vofTOuter * vofTOuter) * mad(vofTOuter, -2.0, 3.0)) + (-1.0);
                vofRing = vofRing * (((-0.0) - _OffsetIntensity) + _VertexOffsetDoughnutIntensity);
            #endif
                // final displaced offset = vofOffset * (1 + ring) * (1 - O2W._m10). (b212:365-368,584-586)
                float3 vofFinal = mad(vofOffset, vofRing.xxx, vofOffset);                              // (b212:365-367 _713 = mad(_633,_712,_633))
                float vofPush = 1.0 + ((-0.0) - unity_ObjectToWorld._m10);                             // (b212:368 _720 = 1 - _unity_ObjectToWorld[1u].x)
                positionWS = mad(vofFinal, vofPush.xxx, positionWS);                                   // (b212:584-586 _1076 = mad(_713,_720,_342))
            #endif

                o.positionWS = positionWS;
                // Clip pos (TAA jitter dropped). (Vertex_b154:296-317 NonJitteredViewNoTransProj -> URP VP)
                o.positionCS = TransformWorldToHClip(positionWS);

            #if defined(_USE_SLUDGE)
                // ----- _USE_SLUDGE: height-texture VERTEX EROSION (geometry discard) -----
                // 1:1 source = vfxadvance Vertex_b162.hlsl:357-364 (HG_ENABLE_MV+_USE_SLUDGE, the minimal sludge vertex variant;
                //   the SAME erosion block is byte-identical in ALL 12 sludge vertex blobs b162/b178/b196/b242/b244/b246 +
                //   SRP_INSTANCING mirrors b316/b332/b350/b396/b398/b400 — each carries this T1.SampleLevel + 4 NaN clip writes,
                //   while the base b154 has NONE). This is the "淤泥侵蚀范围控制" feature (vfxadvance.shader:160 _UseSludge).
                //   NOTE: the distinctive sludge math lives in the VERTEX stage, NOT the fragment — the sludge FRAGMENT blob
                //   (b163) is indeed identical to the base fragment (b155), which is why a fragment-only diff wrongly read no-op.
                //
                // Algorithm (b162:357-360): take the particle world-pivot (ObjectToWorld * uv2.xyz, absolute world — NO
                //   camera-relative rebase), subtract the pivot offset (Params0.xyz), project onto two axes to form a UV,
                //   clamp each projection to [0, ceil] (ceil = Params0.w), apply scale/offset, sample the height texture, and
                //   if the sampled height (.z channel) < 0.1 NaN-out the clip position so the whole primitive is rasterizer-culled.
                //   SSA slot-aliasing (STYLE_BIBLE §0/§2): the b162 reflection labels these 4 sludge vectors with stale pooled
                //   names (_MaskTexUVRotateMat / _MaskTexUVWeights / {_BlendTexUseDisturb,_BlendDisableVertColor,_DissolveEdgeSharp}
                //   / _BlendTex_ST); decoded to the authored properties _SludgeHeightTextureParams0..3 (vfxadvance.shader:161-164)
                //   by cbuffer position. Params0 = pivot.xyz + clamp-ceil.w; Params1/Params2 = the two world-space projection
                //   axes; Params3 = (offsetU.x, offsetV.y, scaleU.z, scaleV.w). (See RESIDUAL note in the fragment sludge block.)
                float3 sludgeWorld = TransformObjectToWorld(input.uv2.xyz);                       // (b162:357-359 ObjectToWorld*TEXCOORD_2)
                float3 sludgeOffset = sludgeWorld - _SludgeHeightTextureParams0.xyz;              // (b162:357-359  - _MaskTexUVRotateMat.xyz)
                float  sludgeCeil = _SludgeHeightTextureParams0.w;                                // (b162:360 _MaskTexUVRotateMat.w)
                float  sludgeU = mad(max(min(dot(sludgeOffset, _SludgeHeightTextureParams2.xyz), sludgeCeil), 0.0),
                                     _SludgeHeightTextureParams3.z, _SludgeHeightTextureParams3.x); // (b162:360 mad(...,_BlendTex_ST.z,_BlendTex_ST.x))
                float  sludgeV = mad(max(min(dot(sludgeOffset, _SludgeHeightTextureParams1.xyz), sludgeCeil), 0.0),
                                     _SludgeHeightTextureParams3.w, _SludgeHeightTextureParams3.y); // (b162:360 mad(...,_BlendTex_ST.w,_BlendTex_ST.y))
                float  sludgeHeight = SAMPLE_TEXTURE2D_LOD(_SludgeHeightTexture, sampler_SludgeHeightTexture,
                                                           float2(sludgeU, sludgeV), 0.0).z;       // (b162:360 T1.SampleLevel(...,0).z)
                if (sludgeHeight < 0.100000001490116119384765625)                                  // (b162:360 < 0.1; :361-364 NaN clip cull)
                {
                    float sludgeNaN = asfloat(0x7fc00000u);                                          // (b162:361-364 asfloat(0x7fc00000u /* nan */) on all 4 clip lanes)
                    o.positionCS = float4(sludgeNaN, sludgeNaN, sludgeNaN, sludgeNaN);
                }
            #endif

                // Main UV. chanScroll = uv1.x*_InParticle (Fragment_b155:118 _183). (Fragment_b155:119)
                float2 mainUV = BuildVfxUV(input.uv0, input.uv1, _MainTexUVSpeed, _MainTexUVWeights, _MainTexUVRotateMat, _MainTex_ST, input.uv1.x * _InParticle, customTime);
                o.uvMain = float4(input.uv0.x, input.uv0.y, mainUV.x, mainUV.y);
            #if defined(_USE_SCREENUV)
                o.uvPolarSrc = input.uv0.zw; // polar pair for the frag-side screen-UV main-UV rebuild
            #endif
            #if defined(_USE_DISTURB)
                // Disturb-sample UV: full BuildVfxUV on the dedicated _Disturb* slots (rotate+weights+pan+_ST), chanScroll = custom1.y.
                //   1:1 source = Fragment_b255:193 (the SSA scrambler spelled these as _MaskTex* slots; de-aliased to _Disturb*).
                //   custom1.y term == _212 = uv1.y*_InParticle; pan time _VFXParams0.w -> _Time.y (customTime).
                o.uvDisturb = BuildVfxUV(input.uv0, input.uv1, _DisturbUVSpeed1, _DisturbUVWeights1,
                                         _DisturbUVRotateMat1, _DisturbTex1_ST, input.uv1.y * _InParticle, customTime);
            #endif
            #if defined(_USE_FLOWMAP)
                // Flowmap-sample UV: same HGVFX rotate+pan+_ST as MainTex (BuildVfxUV, 1:1 Fragment_b155:119) on the _Flowmap*
                //   slots. chanScroll = custom1.y (property _FlowmapUVPannerSpeed ZW = "By Custom1.Y"); pan time = customTime
                //   (_Time.y; blob _VFXParams0.w). Flowmap exposes _FlowmapUVRotate as DEGREES with NO editor-baked
                //   _FlowmapUVRotateMat (unlike the other slots), so build the (m00,m10,-m10,m00)=(cos,sin,-sin,cos) matrix here.
                //   No UV-set/weights property exists (vfxadvance.shader:155-159 = tex/speed/rotate/strength/speed only) -> uv0,
                //   neutral weights (1,0,0,0).
                float flowRotRad = radians(_FlowmapUVRotate);
                float flowSin, flowCos;
                sincos(flowRotRad, flowSin, flowCos);
                float4 flowRotMat = float4(flowCos, flowSin, ((-0.0) - flowSin), flowCos);
                o.uvFlowmap = BuildVfxUV(input.uv0, input.uv1, _FlowmapUVPannerSpeed, float4(1.0, 0.0, 0.0, 0.0),
                                         flowRotMat, _FlowmapTex_ST, input.uv1.y * _InParticle, customTime);
            #endif
            #if defined(_USE_DISSOLVE)
                // Dissolve-sample UV: full BuildVfxUV on the dedicated _Dissolve* slots (rotate+weights+pan+_ST), chanScroll = custom1.y.
                //   1:1 source = vfxadvance Fragment_b193:164 (the SSA scrambler spelled the dissolve UV through _MaskTexUVSpeed/
                //   _MaskTexUVWeights/_MaskTexUVRotateMat/_MaskTex_ST slots; de-aliased to the dedicated _Dissolve* slots). Built in
                //   vert (needs uv0.zw polar pair); same idiom as uvDisturb. pan time _VFXParams0.w -> _Time.y (customTime).
                o.uvDissolve = BuildVfxUV(input.uv0, input.uv1, _DissolveUVSpeed, _DissolveUVWeights,
                                          _DissolveUVRotateMat, _DissolveTex_ST, input.uv1.y * _InParticle, customTime);
            #endif
            #if defined(_USE_CUT_OFF)
                // Object/local-space position for the cutoff plane (Object-space branch). Blob Vertex_b312:323-325 sets
                //   _445/_447/_449 = POSITION.xyz directly in the non-pivot/non-skinned path (the GPU-skinning + _LocalPivortSpace
                //   matrix transform of that blob is HGRP baked-skinning infra, dropped per STYLE_BIBLE §2 -> raw object pos).
                o.positionOSCut = input.positionOS;
            #endif
            #if defined(_USE_AIRWALL)
                // AirWall-sample UV = HGVFX UV-set weights select + _ST ONLY (1:1 Fragment_b157:131). The airwall mask UV
                //   in b157 is the bare "select(uvWeights) then *_ST" form — no pan, no rotate, no center pivot — so it is
                //   NOT BuildVfxUV (which adds speed-pan + -0.5/+0.5 rotate-about-center). polarX/Y = lerp(uv1.xy, uv0.zw,
                //   _InParticle) is the SAME particle-blended polar pair BuildVfxUV computes (Fragment_b157:129-130 _79/_80,
                //   identical to BuildVfxUV's polarX/polarY at target:588-589). selX/Y = mad(uv0.xy, _AirWallUVWeights.x,
                //   polar*_AirWallUVWeights.y) — the standard HGVFX UV-set weights select (Fragment_b157:131 inner mad).
                //   b157 SSA slot-aliasing decoded (STYLE_BIBLE §0/§2 — the compiled airwall permutation packs the airwall
                //   uniforms onto the c14/c15 float4 slots the stale reflection labels _MaskTexUVRotateMat/_MaskTexUVWeights):
                //     _MaskTexUVWeights.xy (c15.xy) = _AirWallUVWeights.xy (the UV-set select weights baked by _AirWallUVSet)
                //     _MaskTexUVRotateMat.xyzw (c14.xyzw) = _AirWallTex_ST.xyzw (scale .xy, offset .zw — b157 applies them as
                //       mad(sel, RotMat.x, RotMat.z)/mad(sel, RotMat.y, RotMat.w), i.e. exactly the _ST mad, NOT a rotation).
                float airP = _InParticle;
                float airPolarX = mad(input.uv0.z, airP, ((-0.0) - (input.uv1.x * airP))) + input.uv1.x; // (b157:129 _79 == BuildVfxUV polarX)
                float airPolarY = mad(input.uv0.w, airP, ((-0.0) - (input.uv1.y * airP))) + input.uv1.y; // (b157:130 _80 == BuildVfxUV polarY)
                float airSelX = mad(input.uv0.x, _AirWallUVWeights.x, airPolarX * _AirWallUVWeights.y);   // (b157:131 inner mad)
                float airSelY = mad(input.uv0.y, _AirWallUVWeights.x, airPolarY * _AirWallUVWeights.y);   // (b157:131 inner mad)
                o.uvAirWall = float2(mad(airSelX, _AirWallTex_ST.x, _AirWallTex_ST.z),
                                     mad(airSelY, _AirWallTex_ST.y, _AirWallTex_ST.w));                    // (b157:131 outer mad == _ST)
            #endif

                // Vertex color: SRP per-draw particle scale dropped -> identity (Vertex_b154:306-309).
                o.color  = input.color;
                o.custom = input.uv1;

            #if defined(_USE_FRESNEL) || defined(_NORMAL_MAP) || defined(_INK_DISTORT) || defined(_INK_COLOR_DISTORT)
                o.normalWS = TransformObjectToWorldNormal(input.normalOS);
            #endif
            #if defined(_NORMAL_MAP)
                // World tangent + bitangent sign for the TBN basis. (Vertex_b228:482-486)
                //   .xyz = normalize(TransformObjectToWorldDir(tangentOS.xyz)); blob rsqrt(max(dot,FLT_MIN)) == SafeNormalize.
                //   .w   = oddNegativeScale_sign * tangentOS.w  (blob CB1_m0[5].w sign * TANGENT.w; URP GetOddNegativeScale()).
                o.tangentWS = float4(normalize(TransformObjectToWorldDir(input.tangentOS.xyz)),
                                     input.tangentOS.w * GetOddNegativeScale());
                // Normal-map anim UV: rotate(_NormalMapUVRotateMat)+pan(_NormalMapUVSpeed: xy*time, zw*custom1.y)+_ST.
                //   chanScroll = custom1.y (property _NormalMapUVSpeed ZW = Custom1.Y). Same BuildVfxUV as MainTex.
                o.uvNormal = BuildVfxUV(input.uv0, input.uv1, _NormalMapUVSpeed, _NormalMapUVWeights,
                                        _NormalMapUVRotateMat, _NormalMap_ST, input.uv1.y * _InParticle, customTime);
            #endif
                return o;
            }

            float4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                float2 mainUV    = input.uvMain.zw;
                float3 vertColor = input.color.xyz;
                float  vertAlpha = input.color.w;
                float  custom1x  = input.custom.x * _InParticle; // (Fragment_b155:118 _183)
                float  custom1y  = input.custom.y * _InParticle;

                // Screen UV + reconstructed world / |view-Z| (used for soft-depth gate). (Fragment_b155:114-117)
                float2 screenUV = input.positionCS.xy / _ScreenParams.xy;
                float3 worldPos = ReconstructWorldPos(screenUV, input.positionCS.z);
                float  viewZ    = ViewSpaceZAbs(worldPos);

            #if defined(_USE_SCREENUV)
                // _USE_SCREENUV: rebuild the main UV with a fragment-only screen-space term injected into the sel coords.
                //   1:1 source = Fragment_b215.hlsl:147-160 (vs no-screenUV sibling b169:156). uv0 = (uvMain.xy, uvPolarSrc).
                //   Uses the interpolated world-position varying (input.positionWS == blob TEXCOORD), NOT the depth-reconstruct.
                float4 uv0Screen = float4(input.uvMain.xy, input.uvPolarSrc);
                mainUV = BuildVfxScreenUV(uv0Screen, input.custom, _MainTexUVSpeed, _MainTexUVWeights, _MainTexUVRotateMat,
                                          _MainTex_ST, input.custom.x * _InParticle, _Time.y, input.positionWS, input.positionCS);
            #endif

                // ----- _USE_DISTURB: sample disturb tex with rotate+weights+panned uv, fold, offset main UV -----
                // 1:1 source = vfxadvance Fragment ladder b255 lines 193-197 (the _INK_COLOR_DISTORT+_USE_DISTURB+_USE_FOG
                //   permutation; the minimal disturb isolation available in vfxadvance — no pure _USE_DISTURB-only variant exists).
                //   That compiled blob SSA-aliases the disturb slots onto MaskTex temporaries: the UV build (b255:193) routes
                //   through _MaskTexUVSpeed/_MaskTexUVWeights/_MaskTexUVRotateMat/_MaskTex_ST, _Bi_Disturb -> _UseMaskTexAsAlpha
                //   (b255:195), _DisturbTex1Normal -> _MaskTexUseDisturb (b255:196). De-aliased to the dedicated _Disturb* slots.
                //   NOTE: vfxadvance's disturb UV is the FULL rotate+weights pipeline (dedicated _DisturbUVRotateMat1/_DisturbUVSet1/
                //   _DisturbUVWeights1 exist — vfxadvance.shader:55-57), so it is NOT BaseBatched b43's bare-pan form. UV built in vert
                //   (BuildVfxUV on _Disturb* slots) above; only the fold/offset (b255:195-197) lives here.
            #if defined(_USE_DISTURB)
                // Disturb UV is the FULL HGVFX rotate+weights+pan+_ST build on the dedicated _Disturb* slots, NOT a bare
                //   _DisturbUVSpeed1 pan: vfxadvance has _DisturbUVRotateMat1/_DisturbUVWeights1 (shaderlab lines 55,57) that
                //   vfxbasebatched's b43 lacks. Built in vert (needs uv0.zw polar pair). 1:1 source = Fragment_b255:193.
                float2 disturbUV = input.uvDisturb;
                float4 dSamp = SAMPLE_TEXTURE2D_BIAS(_DisturbTex1, sampler_DisturbTex1, disturbUV, _GlobalMipBias.x); // (b255:194 T1.SampleBias)
                // bi-fold X: lerp(-_Bi_Disturb .. 1) -> mad(x, 1+_Bi_Disturb, -_Bi_Disturb). (b255:195)
                float biX = mad(dSamp.x, 1.0 + _Bi_Disturb, ((-0.0) - _Bi_Disturb));
                bool dNormal = (0.0 != _DisturbTex1Normal); // (b255:196)
                // normal mode: unpack .w/.y to [-1,1]*UIntensity; scalar mode: biX*UIntensity (U) / biX*VIntensity (V). (b255:197)
                float offU = dNormal ? (mad(dSamp.w * biX, 2.0, -1.0) * _DisturbUIntensity1)
                                     : (biX * _DisturbUIntensity1);
                float offV = dNormal ? (mad(dSamp.y, 2.0, -1.0) * _DisturbUIntensity1)
                                     : (biX * _DisturbVIntensity1);
                mainUV.x = mad(offU, _MainTexUseDisturb, mainUV.x); // (b255:197 mad(.., _MainTexUseDisturb, _367))
                mainUV.y = mad(offV, _MainTexUseDisturb, mainUV.y);
            #endif

                // ----- _USE_FLOWMAP: flowmap-driven main-UV distortion (vfxadvance-unique) -----
                // PROVENANCE: vfxadvance declares [Toggle(_USE_FLOWMAP)] (vfxadvance.shader:154) + the five flowmap slots
                //   _FlowmapTex/_FlowmapUVPannerSpeed/_FlowmapUVRotate/_FlowmapStrength/_FlowmapSpeed (vfxadvance.shader:155-159),
                //   but it emits NO `#pragma multi_compile_local _ _USE_FLOWMAP` (pragma list vfxadvance.shader:230-254) and every
                //   reference material ships _UseFlowmap=0, so the branch is dead-code-eliminated in ALL ~150 decompiled fragment
                //   blobs (verified: zero blobs reference any _Flowmap* uniform). No SSA blob math exists to transcribe.
                //   Reconstructed 1:1 from (a) the property spec — the labels ARE the contract: _FlowmapUVPannerSpeed
                //   "(XY:By Time,ZW:By Custom1.Y)", _FlowmapUVRotate "(Degree)", _FlowmapStrength "Disturb Stength"=0.5,
                //   _FlowmapSpeed "Velocity"=0.1 — and (b) the in-tree HG flowmap idiom: the UV-sample panner is the SAME
                //   rotate+pan+_ST pipeline as every other vfxadvance texture slot (BuildVfxUV, 1:1 Fragment_b155:119), and the
                //   distortion is the canonical HG flow offset added into the main UV (cf. waterdecal Fragment_b28:195, which
                //   folds a flowmap sample * strength into its sample UV via the same mad-offset form, with sibling slot names).
                //   The ONLY slot peculiarity: flowmap exposes _FlowmapUVRotate as DEGREES (vfxadvance.shader:157) and has NO
                //   editor-baked _FlowmapUVRotateMat (unlike _MainTex/_Mask/_Normal which carry a [HideInInspector] *UVRotateMat),
                //   so the 2x2 rotation is built in-shader (sincos of radians) into BuildVfxUV's (m00,m10,-m10,m00) layout.
            #if defined(_USE_FLOWMAP)
                // Sample the flowmap on its pre-built panned/rotated UV (input.uvFlowmap, built in vert). RG carry the flow
                //   direction; remap [0,1] -> [-1,1].
                float4 flowSample = SAMPLE_TEXTURE2D_BIAS(_FlowmapTex, sampler_FlowmapTex, input.uvFlowmap, _GlobalMipBias.x);
                float2 flowDir = mad(flowSample.xy, 2.0, -1.0);
                // Distort the main UV by the flow: static disturb (* _FlowmapStrength) + time-scrolled velocity along the flow
                //   (* _FlowmapSpeed * _Time.y). Property labels: _FlowmapStrength="Flowmap Disturb Stength"=0.5 (constant offset
                //   magnitude), _FlowmapSpeed="Flowmap Velocity"=0.1 (scroll rate along the flow over time). (vfxadvance.shader:158-159)
                float2 flowOffset = flowDir * mad(_FlowmapSpeed, _Time.y, _FlowmapStrength);
                // Gate the main-UV perturbation by _MainTexUseFlowmap (vfxadvance.shader:25, [ToggleUI] "Main Tex Use Flowmap"
                //   =0), the exact naming-pair sibling of _MainTexUseDisturb. The verified disturb path folds its offset into the
                //   main UV as mad(offset, _MainTexUseDisturb, baseUV) (1:1 Fragment_b255:197, target:810-811); the flowmap offset
                //   is the same per-texture toggle, so at the default _MainTexUseFlowmap=0 the flowmap must NOT touch the main UV.
                mainUV.x = mad(flowOffset.x, _MainTexUseFlowmap, mainUV.x);
                mainUV.y = mad(flowOffset.y, _MainTexUseFlowmap, mainUV.y);
            #endif

                // ----- _USE_BRIGHT: 2-octave value-noise UV distortion, spatially gated by a spot-distance falloff -----
                // GROUND TRUTH = vfxadvance Fragment_b211.hlsl:176-228 (Keywords HG_ENABLE_MV _USE_AIRWALL _USE_BRIGHT
                //   _USE_MASK; the airwall/mask co-features contribute nothing to this block — verified by diff vs the
                //   airwall-only sibling b157, which has NEITHER the value-noise NOR the distort fold). All 8 vfxadvance
                //   _USE_BRIGHT fragment blobs (and ONLY those) carry this `43758.546875` value-noise; ZERO no-bright blobs
                //   do. CRITICAL: vfxadvance's _USE_BRIGHT is UV-distort ONLY — it does NOT inject _BrightColor/_ScanFillColor/
                //   spot-scanline color. None of the 148 vfxadvance fragment blobs reference _BrightColor/_ScanFillColor/
                //   _ScanLineSchedule/_ScanLineWidth/_BrightType/_InnerRadius/_OuterRadius/_DistortScale/_DistortOnEdge by the
                //   compiled name (all 0). The spot/scanline-color "Bright" is a DIFFERENT, vfxbasebatched-only feature
                //   (Fragment_b37; the old TODO's "== VfxBaseBatched 516-626" conflated the two — they share ONLY the
                //   value-noise hash). The 2-octave value-noise core here is byte-identical to the sibling's (HGRP_VfxBaseBatched_Fix
                //   :559-592 / Fragment_b37:164-202); only the spatial GATE differs (vfxadvance: a spherical spot-distance
                //   smoothstep around the effect center; vfxbasebatched: the same _InnerRadius/_OuterRadius spot).
                //
                // b211 SSA slot-aliasing decoded by usage (STYLE_BIBLE §0/§2 — the compiled permutation packs the distort
                //   uniforms onto unused Blend/Dissolve cbuffer slots; each appears ONLY in this distort math):
                //     _BlendTex_ST.x(c17.x)=_DistortScale  _BlendTex_ST.y(c17.y)=_DistortSpeed  _BlendTex_ST.z(c17.z)=_DistortIntensity
                //     _BlendTexUVSpeed.x(c18.x)=_DistortOnEdge  _DissolveEdgeSharp(c16.z)=_OuterRadius  _BlendDisableVertColor(c16.y)=_InnerRadius
                //     _DissolveEmissiveEdge(c16.w)=_CharacterHeight (center Y offset)  _BlendTexUVWeights.xyz(c20)+ .w(c20.w)=_BrightCenter.xyz + .w
                //   The center reconstruct `_BrightCenter.xyz*w + (1-w)*_VFXParams0.xyz` (b211:208,215-217) IS the host
                //   _BrightCenter "Override center (0 = main actor pos)" contract: w=_BrightCenter.w blends the explicit
                //   override toward the engine effect-center _VFXParams0.xyz.
                float brightDistortU = 0.0; // distort offset folded into MainTex UV here AND MaskTex UV in _USE_MASK (b211:229 vs :239)
                float brightDistortV = 0.0;
            #if defined(_USE_BRIGHT)
                // Noise sample coordinate = main rotated UV scaled by _DistortScale, panned by time*_DistortSpeed.
                //   (b211:176-178 _164 = time(_VFXParams0.w==_Time.y) * _DistortSpeed; _168 = mad(mainUV.x, _DistortScale, _164))
                float brightDistTime = _Time.y * _DistortSpeed;
                float bnu = mad(mainUV.x, _DistortScale, brightDistTime);
                float bnv = mad(mainUV.y, _DistortScale, brightDistTime);
                float bfu = floor(bnu);                                                                 // (b211:179 _170)
                float bfv = floor(bnv);                                                                 // (b211:180 _172)
                float bru = frac(bnu);                                                                  // (b211:181 _173)
                float brv = frac(bnv);                                                                  // (b211:182 _174)
                // smoothstep interpolation weights su/sv = (3-2t)*t^2 per axis. (b211:200-203 _265/_269/_273/_274)
                float bsu = mad((-0.0) - bru, 2.0, 3.0) * (bru * bru);                                  // (b211:200-202)
                float bsv = mad((-0.0) - brv, 2.0, 3.0) * (brv * brv);                                  // (b211:203 _274)
                // four cell hashes on the 1/1024 grid (cells _170/_172 == bfu/bfv, step 0.0009765625).
                //   Blob SSA temp -> corner: _261=hash(fu,fv)=h00 ; _231=hash(fu+1,fv)=h10 ;
                //   inline(_184,_185)=hash(fu,fv+1)=h01 ; inline(_239,_240)=hash(fu+1,fv+1)=h11.
                float bh00 = HashCell(float2(bfu * NOISE_STEP, bfv * NOISE_STEP));                      // (b211:192-198 _261 = hash(_232,_233))
                float bh10 = HashCell(float2((bfu + 1.0) * NOISE_STEP, bfv * NOISE_STEP));              // (b211:183-184,187-188,191 _231 = hash(_181,_183))
                float bh01 = HashCell(float2(bfu * NOISE_STEP, (bfv + 1.0) * NOISE_STEP));              // (b211:185-186,189-190,207 inline = hash(_184,_185))
                float bh11 = HashCell(float2((bfu + 1.0) * NOISE_STEP, (bfv + 1.0) * NOISE_STEP));      // (b211:194-195,204-205,207 inline = hash(_239,_240))
                // bilerp (U then V) remapped to [-1,1]. noiseRaw == b211:207 _307 (mad(.., 2, -1) of the nested lerp).
                float bLerpU0 = lerp(bh00, bh10, bsu);
                float bLerpU1 = lerp(bh01, bh11, bsu);
                float brightNoiseU = mad(lerp(bLerpU0, bLerpU1, bsv), 2.0, -1.0);                       // (b211:207 _307)
                // Separate 1D value-noise lane for the V-axis warp (the inner mad of b211:228 _463):
                //   n1(f)=frac(f*0.011); g(x)=(x+7.5)*x; h(x)=frac(x*(x+x)); V=lerp(h(g(n1(fv))), h(g(n1(fv+1))), sv)*2-1.
                //   (b211:199,206 _262/_290 ; :224-226 _449/_454/_457 ; :228 inner)
                float bn0 = frac(bfv * NOISE_K011);                                                     // (b211:199 _262)
                float bn1 = frac((bfv + 1.0) * NOISE_K011);                                             // (b211:206 _290)
                float bg0 = (bn0 + 7.5) * bn0;                                                          // (b211:225 _454)
                float bg1 = bn1 * (bn1 + 7.5);                                                          // (b211:224 _449)
                float bhv0 = frac(bg0 * (bg0 + bg0));                                                   // (b211:226 _457)
                float bhv1 = frac(bg1 * (bg1 + bg1));                                                   // (b211:228 inner frac)
                float brightNoiseV = mad(mad(bsv, bhv1 + ((-0.0) - bhv0), bhv0), 2.0, -1.0);            // (b211:228 _463 inner)

                // Spot-distance gate: world distance from the fragment to the (overridable) effect center, with a Y offset.
                //   center = _BrightCenter.xyz*_BrightCenter.w + (1-_BrightCenter.w)*_VFXParams0.xyz ; centerY += _CharacterHeight.
                //   (b211:208 _314=1-w ; :215-217 _404/_405/_406 = -center + worldPos, with _DissolveEmissiveEdge==_CharacterHeight on Y)
                float brightCenterW = 1.0 + ((-0.0) - _BrightCenter.w);                                 // (b211:208 _314)
                float3 brightCenter = float3(mad(_BrightCenter.x, _BrightCenter.w, brightCenterW * _VFXParams0.x),
                                             mad(_BrightCenter.y, _BrightCenter.w, brightCenterW * _VFXParams0.y) + _CharacterHeight,
                                             mad(_BrightCenter.z, _BrightCenter.w, brightCenterW * _VFXParams0.z)); // (b211:215-217)
                float3 brightDelta = ((-0.0) - brightCenter) + worldPos;                                // (b211:215-217 _404/_405/_406)
                float brightDist = sqrt(dot(brightDelta, brightDelta));                                 // (b211:218 _410)
                // gate t = saturate( (_DistortOnEdge*noiseRaw + dist - _OuterRadius) / (_InnerRadius - _OuterRadius) ), smoothstep'd.
                //   (b211:219 _434=1/(-_OuterRadius+_InnerRadius) ; :220 _436 ; :222 _442=smoothstep(_436))
                float brightRadInv = 1.0 / (((-0.0) - _OuterRadius) + _InnerRadius);                    // (b211:219 _434)
                float brightGateT = clamp((mad(_DistortOnEdge, brightNoiseU, brightDist) + ((-0.0) - _OuterRadius)) * brightRadInv, 0.0, 1.0); // (b211:220 _436)
                float brightGate = (brightGateT * brightGateT) * mad(brightGateT, -2.0, 3.0);           // (b211:222 _442 smoothstep)
                // distort amount = smoothstep-gate * _DistortIntensity ; per-axis offset = amount * noise lane.
                //   (b211:223 _446=_442*_DistortIntensity ; :227 _462=_446*noiseU ; :228 _463=_446*noiseV)
                float brightAmt = brightGate * _DistortIntensity;                                       // (b211:223 _446)
                brightDistortU = brightAmt * brightNoiseU;                                              // (b211:227 _462)
                brightDistortV = brightAmt * brightNoiseV;                                              // (b211:228 _463)
                // fold into the MainTex UV, gated per-texture by _MainTexUseDisturb. (b211:229 _475 sample UV)
                mainUV.x = mad(brightDistortU, _MainTexUseDisturb, mainUV.x);
                mainUV.y = mad(brightDistortV, _MainTexUseDisturb, mainUV.y);
            #endif

                // ----- _INK_DISTORT / _INK_COLOR_DISTORT: water-ink simulation distortion (effect UV warp + color blend) -----
                // GROUND TRUTH (UV warp, both keywords): vfxadvance/Sub0_Pass0_Fragment_b167.hlsl:130-149 (HG_ENABLE_MV _INK_DISTORT,
                //   the ISOLATED ink-distort variant) and Sub0_Pass0_Fragment_b165.hlsl:130-155 (HG_ENABLE_MV _INK_COLOR_DISTORT,
                //   the ISOLATED ink-color-distort variant; vfxadvance.shader:742/745). Both blobs reconstruct the FRAGMENT's own
                //   world pos from gl_FragCoord.z via _InvViewProjMatrix (b167:127-129 _117/_118/_120 == b165:132-134) -> here the
                //   shared `worldPos` (target:1011, ReconstructWorldPos(UNITY_MATRIX_I_VP) — same NDC->world, NOT a depth-buffer
                //   sample; the blob feeds gl_FragCoord.z, i.e. the surface's own depth). The ink-sim displacement buffer T1
                //   (b167:139 / b165:146) is sampled with sampler_LinearClamp at LOD0 on a world-derived UV; T2 (b165:173) is the
                //   ink coverage/density buffer (only the _INK_COLOR_DISTORT path).
                //
                // SSA slot-aliasing decoded by usage onto the real _Ink* props (STYLE_BIBLE §0/§2; the compiled permutations pack
                //   the ink scalars onto the c13 register bank, which the decompiler spells via WHATEVER cbuffer member overlaps
                //   that bank in each permutation — _MaskTexUVSpeed.<lane> in the isolated blobs, _BlendTexUVSpeed.<lane> once the
                //   mask feature reorders the bank (cf. b183:166-167). The ink COLOR lands on c14 (decompiler: _MaskTexUVRotateMat).
                //   The c13 lane->property map is PINNED by b165, which reads three of the four lanes with known property semantics:
                //     c13.x = _InkStrength  ("Ink Strength"=15, b165:173  T2.r * _MaskTexUVSpeed.x        -> coverage strength).
                //     c13.y = _InkMaxAlpha  ("Ink Max Alpha"=0.8, b165:173 min(.., _MaskTexUVSpeed.y)      -> coverage max-clamp).
                //     c13.z = _InkDisturbOffset ("Effect distort strength"=0.025, b165:147-148 _MaskTexUVSpeed.z -> UV-warp strength).
                //     c14.xyz = _InkColor.rgb ("Ink Color", b165:176-178 _MaskTexUVRotateMat.xyz, the C-term of the over-composite).
                //   *** CRITICAL: the distort-ONLY b167:141-142 warps with _MaskTexUVSpeed.x == c13.x == _InkStrength (NOT c13.z).
                //   b167's cbuffer is byte-identical to b165's (it still declares _InkDisturbOffset at c13.z, unused in code), so the
                //   .x lane is a genuinely DIFFERENT uniform than the color path's .z — the two source variants drive the warp from
                //   different properties: _INK_DISTORT -> _InkStrength, _INK_COLOR_DISTORT -> _InkDisturbOffset. Resolved per-keyword below.
                //   (_InkSceneDisturbOffset "Scene distort strength" is the type-0 ColorDistortScene scene-grab UV warp — NOT used by
                //    either isolated keyword here, which warp the EFFECT's own UV; left unconsumed, matching the property semantics.)
                bool  inkInBounds    = false;
                float inkCoverage    = 0.0;   // b165 _403 = inkNormalFactor * min(T2.r*_InkStrength, _InkMaxAlpha)
            #if defined(_INK_DISTORT) || defined(_INK_COLOR_DISTORT)
                // World->UV: inkUV = worldPos.xz * scale + offset. (b167:133-134 _252/_253 mad(worldX/worldZ, _InkSimulationWorldToUV.w,
                //   _InkSimulationWorldToUV.x / .z) == b165:139-140 _283/_284.) X-plane uses .x offset, Z-plane uses .z offset.
                float2 inkUV = float2(mad(worldPos.x, _InkSimulationWorldToUV.w, _InkSimulationWorldToUV.x),
                                      mad(worldPos.z, _InkSimulationWorldToUV.w, _InkSimulationWorldToUV.z));
                // In-bounds gate: keep only where the remapped UV is inside the ink-sim viewport, i.e. max(|uv*2-1|) <= 1.
                //   (b167:137 / b165:141 `1.0 >= max(abs(mad(uvV,2,-1)), abs(mad(uvU,2,-1)))`.)
                inkInBounds = (1.0 >= max(abs(mad(inkUV.y, 2.0, -1.0)), abs(mad(inkUV.x, 2.0, -1.0))));
                // Normal-facing factor: clamp(|normalize(N).y| - 0.2, 0, 1) * 1.25 — fades ink on edge-on (low world-up) surfaces.
                //   (b167:140 / b165:138 _301/_273; rsqrt(max(dot(N,N), FLT_MIN)) == SafeNormalize, FLT_MIN==1.175e-38 STYLE_BIBLE §4.)
                float3 inkN = input.normalWS;
                float inkNormalFactor = clamp(abs(rsqrt(max(dot(inkN, inkN), 1.1754943508222875079687365372222e-38)) * inkN.y)
                                              + (-0.20000000298023223876953125), 0.0, 1.0) * 1.25;
                if (inkInBounds)
                {
                    // Sample ink displacement (RG) at LOD0, clamp-addressed. (b167:139 / b165:146 T1.SampleLevel(sampler_LinearClamp, inkUV, 0))
                    float4 inkDisp = SAMPLE_TEXTURE2D_LOD(_InkSimulationTex, sampler_InkSimulationTex, inkUV, 0.0);
                    // UV-warp strength is keyword-dependent (see slot map above): the isolated _INK_DISTORT b167 warps with c13.x
                    //   (= _InkStrength), the isolated _INK_COLOR_DISTORT b165 warps with c13.z (= _InkDisturbOffset). Distinct uniforms.
                #if defined(_INK_COLOR_DISTORT)
                    float inkDisturbStrength = _InkDisturbOffset;   // b165:147-148 _MaskTexUVSpeed.z (c13.z)
                #else
                    float inkDisturbStrength = _InkStrength;        // b167:141-142 _MaskTexUVSpeed.x (c13.x)
                #endif
                    // Distort the EFFECT's MainTex UV by inkDisp.xy * inkDisturbStrength * normalFactor. (b167:141-142 _305/_306
                    //   mad(_265.y * strength, _301, _243) / mad(_265.x * strength, _301, _242) == b165:147-148 _307/_308.)
                    //   .x channel -> U, .y channel -> V (blob writes _306<-.x onto the U coord _242, _305<-.y onto the V coord _243).
                    mainUV.x = mad(inkDisp.x * inkDisturbStrength, inkNormalFactor, mainUV.x);
                    mainUV.y = mad(inkDisp.y * inkDisturbStrength, inkNormalFactor, mainUV.y);
                #if defined(_INK_COLOR_DISTORT)
                    // Ink coverage (color path only): normalFactor * min(inkColorTex.r * _InkStrength, _InkMaxAlpha).
                    //   (b165:173 _403 = _273 * min(T2.SampleLevel(sampler_LinearClamp, inkUV, 0).x * _MaskTexUVSpeed.x(=_InkStrength), _MaskTexUVSpeed.y(=_InkMaxAlpha)).)
                    float inkCov = SAMPLE_TEXTURE2D_LOD(_InkSimulationColorTex, sampler_InkSimulationColorTex, inkUV, 0.0).x;
                    inkCoverage = inkNormalFactor * min(inkCov * _InkStrength, _InkMaxAlpha);
                #endif
                }
            #endif

                // ----- Main texture + UseMainTexAsAlpha (BASE, Fragment_b155:120-130) -----
                // _GlobalMipBias is float2 in URP (Input.hlsl:112); SAMPLE_TEXTURE2D_BIAS bias arg is scalar -> use .x.
                // (Blob: T0.SampleBias(sampler_LinearClamp, _289, _GlobalMipBias) where blob _GlobalMipBias is scalar c108.)
                float4 mainSample = SAMPLE_TEXTURE2D_BIAS(_MainTex, sampler_MainTex, mainUV, _GlobalMipBias.x);
                float3 mainRGB = UseTexAsAlphaRGB(mainSample.xyz, _UseMainTexAsAlpha);
                // alpha lerp a<->r by _UseMainTexAsAlpha (Fragment_b155:126 inner: mad(_UseMainTexAsAlpha, -a+r, a))
                float mainAlpha = mad(_UseMainTexAsAlpha, ((-0.0) - mainSample.w) + mainSample.x, mainSample.w);

                float postExposure = PostExposure();           // (Fragment_b155:127)
                float3 vc  = VertColorRGB(vertColor);            // (Fragment_b155:128-130)
                float  vcA = VertColorA(vertAlpha);              // (Fragment_b155:126)

                // RGB color (pre-grade), clamp [0,1000]: lerp(mainTex,1,UseAsAlpha)*vertColor*_TintColor.rgb*_TintColorIntensity / exposure.
                // (Fragment_b155:128-130)
                float3 color;
                color.x = min(max((mainRGB.x * ((vc.x * _TintColor.x) * _TintColorIntensity)) / postExposure, 0.0), 1000.0);
                color.y = min(max((mainRGB.y * ((vc.y * _TintColor.y) * _TintColorIntensity)) / postExposure, 0.0), 1000.0);
                color.z = min(max((mainRGB.z * ((vc.z * _TintColor.z) * _TintColorIntensity)) / postExposure, 0.0), 1000.0);

                // ----- ALPHA (BASE, Fragment_b155:126) -----
                // softGate = _UseMaskTexAsAlpha ? (clamp((viewZ-_DisturbVIntensity1)/(_MaskTex_ST.x-_DisturbVIntensity1)) *
                //                                  clamp((viewZ-_MaskTexUseDisturb)/(_DisturbUIntensity1-_MaskTexUseDisturb))) : 1
                //   (decompiler repurposes these slots for a depth soft-fade in the base variant).
                float softV = clamp((viewZ + ((-0.0) - _DisturbVIntensity1)) / (((-0.0) - _DisturbVIntensity1) + _MaskTex_ST.x), 0.0, 1.0);
                float softU = clamp((viewZ + ((-0.0) - _MaskTexUseDisturb)) / (((-0.0) - _MaskTexUseDisturb) + _DisturbUIntensity1), 0.0, 1.0);
                float softGate = (0.0 != _UseMaskTexAsAlpha) ? (softV * softU) : 1.0;
                float lodFadeTerm = 1.0 + ((-0.0) - unity_LODFade.y); // (Fragment_b155:126; URP unity_LODFade.y)
                float baseAlpha = clamp(lodFadeTerm * (softGate * (mainAlpha * ((vcA * _TintColor.w) * _TintColorAlpha))), 0.0, 1.0);

                float opacity = baseAlpha;

            #if defined(_INK_COLOR_DISTORT)
                // ----- _INK_COLOR_DISTORT color/alpha composite: ink color "over" the base, gated to the ink-sim viewport -----
                // 1:1 source = Fragment_b165.hlsl:160-189 (the color-blend tail of the isolated _INK_COLOR_DISTORT variant; the
                //   UV-warp head + coverage `inkCoverage` were computed pre-sample above). Out-of-bounds (b165 else, :183-186)
                //   keeps the base color/alpha verbatim, so the whole rebuild is gated on inkInBounds; in-bounds it REPLACES the
                //   base numerator/alpha-inner with the ink-composited ones and re-applies the SAME /postExposure + softGate*lodFade.
                if (inkInBounds)
                {
                    // Base pre-exposure color numerator R/G/B (== b165:163-165 _387/_388/_389) and base alpha inner (== b165:166 _390).
                    float baseNumR = mainRGB.x * ((vc.x * _TintColor.x) * _TintColorIntensity);
                    float baseNumG = mainRGB.y * ((vc.y * _TintColor.y) * _TintColorIntensity);
                    float baseNumB = mainRGB.z * ((vc.z * _TintColor.z) * _TintColorIntensity);
                    float vertTintA = (vcA * _TintColor.w) * _TintColorAlpha;                 // b165:160 _369
                    float baseAlphaInner = mainAlpha * vertTintA;                             // b165:166 _390 (== _386*_369)
                    // Over-composite alpha: inkCoverage OVER baseAlphaInner = baseAlphaInner + inkCoverage*(1 - baseAlphaInner).
                    //   (b165:174 _406 = mad(-_390, _403, mad(_369, _386, _403)); mad(_369,_386,_403)==_390+_403.)
                    float inkAlphaInner = mad((-0.0) - baseAlphaInner, inkCoverage, mad(vertTintA, mainAlpha, inkCoverage));
                    float inkAlphaDiv = max(inkAlphaInner, 0.001000000047497451305389404296875); // b165:175 _425
                    // Un-premultiplied "over": colorOut = (inkColor*cov + baseNum*baseAlpha*(1-cov)) / inkAlphaInner.
                    //   (b165:176-178 _430 = mad(_403, mad(-_387, _390, _InkColor.x), _390*_387) / _425; _MaskTexUVRotateMat.xyz==_InkColor.rgb.)
                    float inkNumR = mad(inkCoverage, mad((-0.0) - baseNumR, baseAlphaInner, _InkColor.x), baseAlphaInner * baseNumR) / inkAlphaDiv;
                    float inkNumG = mad(inkCoverage, mad((-0.0) - baseNumG, baseAlphaInner, _InkColor.y), baseAlphaInner * baseNumG) / inkAlphaDiv;
                    float inkNumB = mad(inkCoverage, mad((-0.0) - baseNumB, baseAlphaInner, _InkColor.z), baseAlphaInner * baseNumB) / inkAlphaDiv;
                    // Re-apply the BASE /postExposure + [0,1000] clamp (b165:191-193 _500/_502/_503) and softGate*lodFade alpha
                    //   clamp (b165:189 _480) — now with the ink-composited numerator/alpha replacing the base ones.
                    color.x = min(max(inkNumR / postExposure, 0.0), 1000.0);
                    color.y = min(max(inkNumG / postExposure, 0.0), 1000.0);
                    color.z = min(max(inkNumB / postExposure, 0.0), 1000.0);
                    opacity = clamp(lodFadeTerm * (softGate * inkAlphaInner), 0.0, 1.0);
                }
            #endif

                // ----- Shared VFX features (1:1 verified in HGRP_VfxBaseBatched_Fix; vfxadvance ladder b157.. deltas) -----
                // These re-color/re-alpha 'color'/'opacity'. Each mirrors its own feature blob (see manifest).

            #if defined(_NORMAL_MAP)
                // ----- _NORMAL_MAP: tangent-space normal sample + unpack + TBN -> world-space perturbed normal -----
                // Source variant: vfxadvance Fragment ladder b229 (HG_ENABLE_MV+_USE_FRESNEL+_USE_BRIGHT+_NORMAL_MAP),
                //   isolated against the no-normal-map sibling b169 (b169:151 uses the raw geometric normal in the fresnel
                //   dot; b229:257 uses this TBN-perturbed normal instead). Blob math = Fragment_b229.hlsl:237-260.
                // The blob's normal-map UV is aliased onto the dissolve/blend temporaries in that compiled permutation;
                //   the faithful per-feature UV uses the dedicated _NormalMap* slots, built in vert (uvNormal) from the
                //   true uv0/uv1 — same vertex-built idiom as the sibling's secondary UVs (HGRP_VfxBaseBatched_Fix:455-470).
                float2 normalUV = input.uvNormal;
                float4 nmSample = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap, normalUV, _GlobalMipBias.x);
                // Unpack AG-style (X = r*a, Y = g), remap [0,1]->[-1,1]. (b229:238-239)
                float nmX = mad(nmSample.x * nmSample.w, 2.0, -1.0);
                float nmY = mad(nmSample.y, 2.0, -1.0);
                // Scale only XY by _NormalScale (blob slot _BlendTexUVRotateMat.x). (b229:240-241)
                float nmSX = nmX * _NormalScale;
                float nmSY = nmY * _NormalScale;
                // Reconstruct Z from the UNSCALED xy, clamp to >=1e-16. (b229:242  1.000000016862383526387164645044e-16f)
                float nmZ = max(sqrt(((-0.0) - min(dot(float2(nmX, nmY), float2(nmX, nmY)), 1.0)) + 1.0), 1.000000017e-16);
                // Normalize the (scaledXY, Z) tangent-space normal. (b229:243-246)
                float nmInv = rsqrt(dot(float3(nmSX, nmSY, nmZ), float3(nmSX, nmSY, nmZ)));
                float3 nTS = float3(nmInv * nmSX, nmInv * nmSY, nmInv * nmZ);
                // TBN: N = input.normalWS, T = input.tangentWS.xyz, B = sign(tangentWS.w) * cross(N, T). (b229:247-250)
                float3 Nws = input.normalWS;
                float3 Tws = input.tangentWS.xyz;
                float  bSign = (0.0 < input.tangentWS.w) ? 1.0 : -1.0;                                  // (b229:247 _603)
                float3 Bws = bSign * cross(Nws, Tws);                                                   // cross(N,T): (b229:248-250 inner)
                // worldNormal = nTS.x*T + nTS.y*B + nTS.z*N. (b229:248-250 outer mad chain)
                float3 perturbedNormalWS = nTS.x * Tws + nTS.y * Bws + nTS.z * Nws;
            #endif

            #if defined(_USE_FRESNEL)
                // Fresnel rim. 1:1 source = vfxadvance/Sub0_Pass0_Fragment_b169.hlsl:145-154,170-176 (Keywords
                //   HG_ENABLE_MV _USE_CUT_OFF _USE_FRESNEL — the cleanest fresnel-bearing vfxadvance variant; NO
                //   pure-fresnel-only blob exists in the ladder). The co-occurring _USE_CUT_OFF/maskdepth alpha pipeline
                //   (b169:174-177 _445/_522) is NOT applied here — it belongs to _USE_CUT_OFF (see opacity residual note).
                //   Verified directly against the b169 SSA (this trace; NOT inherited from the sibling exemplar).
                //   b169 type_UnityPerMaterial slot-aliasing (the compiled permutation packs the fresnel uniforms onto
                //   unused mask/disturb slots): _FresnelBias=_UseMaskTexAsAlpha(c11), _FresnelPower=_DisturbUIntensity1(c11.z),
                //   _FresnelFlip=_DisturbVIntensity1(c11.w), _FresnelAffectOpacity=_MaskTexUseDisturb(c11.y),
                //   _FresnelColor=type_Globals::_Globals_FresnelColor(b2). Re-exposed as the real _Fresnel* material props.
                bool isOrtho = (0.0 == unity_OrthoParams.w);                                          // (b169:145 _61)
                // vdir: ortho => camPos - particlePosWS ; perspective => view-matrix forward basis.
                //   b169:146-148 perspective branch reads _ViewMatrix[0u].z/[1u].z/[2u].z. _ViewMatrix is column_major, and
                //   SPIRV-Cross indexes a column_major matrix BY COLUMN, so [k].z = mathematical (row2,colk) = V._m2k =>
                //   UNITY_MATRIX_V[2].xyz (== row 2, the camera -Z/forward basis in world). (matches STYLE_BIBLE §2 _m20/_m21/_m22)
                float3 camFwd = float3(UNITY_MATRIX_V[2][0], UNITY_MATRIX_V[2][1], UNITY_MATRIX_V[2][2]);
                // ortho branch: (-TEXCOORD.xyz) + _WorldSpaceCameraPos (b169:146-148). blob TEXCOORD (semantic TEXCOORD1) is the
                //   interpolated particle SURFACE world position. PROVENANCE (paired vertex of b169 = Vertex_b168, NOT base b154):
                //   b168:450-452 _692 = (ObjectToWorld*posOS) - camPos  (camera-relative RWS); b168:481-483 TEXCOORD_2 = _692 + camPos
                //   => absolute surface worldPos. So frag _91 = -TEXCOORD.x + camPos.x = camPos.x - worldPos.x (camPos cancels the
                //   RWS rebase) = the camera->surface vector. The 1:1 URP surrogate is input.positionWS (== TransformObjectToWorld,
                //   target:734) — the particle SURFACE posWS — NOT the depth-buffer ReconstructWorldPos (scene-behind, wrong for a
                //   transparent particle under an ortho camera). vdir = (-input.positionWS) + _WorldSpaceCameraPos.
                float3 vdir = isOrtho ? ((-input.positionWS) + _WorldSpaceCameraPos.xyz) : camFwd;
                float invVlen = rsqrt(max(dot(vdir, vdir), VIEW_EPS));                                // (b169:149 _112)
                // Normal feeding the fresnel dot: geometric (b169:151) OR _NORMAL_MAP-perturbed (b229:257).
            #if defined(_NORMAL_MAP)
                float3 fresNormalWS = perturbedNormalWS;
            #else
                float3 fresNormalWS = input.normalWS;
            #endif
                // front-face normal flip: gl_FrontFacing ? n : -n. (b169:150-151 _119 ? TEXCOORD_3 : -TEXCOORD_3)
                float3 nFres = isFrontFace ? fresNormalWS : (-fresNormalWS);
                // ndv = clamp(dot(normalize(vdir), flippedNormal) + _FresnelBias, 0, 1). (b169:151 inner clamp; bias = _UseMaskTexAsAlpha)
                float ndv = clamp(dot(vdir * invVlen, nFres) + _FresnelBias, 0.0, 1.0);               // (b169:151)
                // fres = ndv ^ _FresnelPower via exp2(log2(ndv)*power). (b169:151 _153) max() guards log2(0)=-inf (->0, same value).
                float fres = exp2(log2(max(ndv, VIEW_EPS)) * _FresnelPower);                          // (b169:151 _153)
                float invF = ((-0.0) - fres) + 1.0;                                                   // (b169:152 _155 = 1 - fres)
                float fresFlipped = mad(_FresnelFlip, ((-0.0) - invF) + fres, invF);                  // (b169:153 _161 = lerp(invF, fres, _FresnelFlip))
                float fresW = fresFlipped * _FresnelColor.w;                                          // (b169:154 _165 = _161 * _Globals_FresnelColor.w)
                // rgb = clamp( lerp(mainRGB*tintFactor, _FresnelColor.rgb, fresW) / postExposure, 0, 1000 ). (b169:170-172 _391/_393/_394)
                //   blob: mad(_165, mad(-tintFactor, mainRGB, FresnelColor), mainRGB*tintFactor) == lerp(basePre, FresnelColor, _165).
                //   Lerp is on the PRE-exposure color and the blended result (incl. FresnelColor) is divided by exposure, then clamped.
                float3 tintFactor = float3(vc.x * _TintColor.x, vc.y * _TintColor.y, vc.z * _TintColor.z) * _TintColorIntensity; // (b169:166-168 _349/_350/_351)
                float3 basePre = mainRGB * tintFactor;                                                // (b169:170 _299 * _349)
                color.x = min(max(mad(fresW, mad((-0.0) - tintFactor.x, mainRGB.x, _FresnelColor.x), basePre.x) / postExposure, 0.0), 1000.0);
                color.y = min(max(mad(fresW, mad((-0.0) - tintFactor.y, mainRGB.y, _FresnelColor.y), basePre.y) / postExposure, 0.0), 1000.0);
                color.z = min(max(mad(fresW, mad((-0.0) - tintFactor.z, mainRGB.z, _FresnelColor.z), basePre.z) / postExposure, 0.0), 1000.0);
                // opacity factor: lerp(1, fresFlipped, _FresnelAffectOpacity). (b169:176 _522 first factor:
                //   mad(_161, _MaskTexUseDisturb, 1 - _MaskTexUseDisturb), where _FresnelAffectOpacity = _MaskTexUseDisturb(c11.y).)
                float fresOpacityMul = mad(fresFlipped, _FresnelAffectOpacity, 1.0 + ((-0.0) - _FresnelAffectOpacity));
                // Faithful fresnel alpha NESTING. b169:176-177 _522/_523 (cross-checked vs the cutoff-free sibling b229:275 _962)
                //   clamp the mainAlpha*tintAlpha CORE alone, multiply fresOpacityMul (A) INSIDE, then the depth/lod gates OUTSIDE
                //   that inner clamp, then re-clamp [0,1]:  _523 = clamp( A * clamp(B,0,1) * <cutoff C> * <maskdepth D> * lodFade , 0, 1 ).
                //   This is a DIFFERENT nesting from the BASE b155 alpha (clamp(lodFade*(softGate*B),0,1) — B not clamped alone), so we
                //   must NOT reuse baseAlpha: `fresOpacityMul * baseAlpha` clamps lodFade*softGate*B as a unit and diverges from the
                //   blob whenever B>1 with the gates<1. Recompute the b169 nesting from in-scope terms.
                //   - clamp(B,0,1): B = mainAlpha * (vertColorA * _TintColor.w * _TintColorAlpha).  (b169:176 inner clamp)
                //   - Deferred to _USE_CUT_OFF (TODO, == 1 when off): cutoff PLANE term C (b169 _445) AND the maskdepth soft-gate D
                //     (b169 _486=1/w with _MaskTex_ST slots) — both live on cutoff-owned slots; b169's disturb slots are ALL fresnel
                //     here (c11.y/z/w = AffectOpacity/Power/Flip), so b169 carries NO base depth softGate.
                //   - softGate (the base b155 depth fade) is kept as the BASE-layer contribution under feature composition; it is the
                //     identity (==1) at the default _UseMaskTexAsAlpha=0, so for any pure-fresnel material this == b169 _523 exactly.
                float fresAlphaCore = clamp(mainAlpha * ((vcA * _TintColor.w) * _TintColorAlpha), 0.0, 1.0); // clamp(B,0,1) (b169:176)
                opacity = clamp(fresOpacityMul * fresAlphaCore * softGate * lodFadeTerm, 0.0, 1.0);          // (b169:176-177 _522/_523)
            #endif

            #ifdef _USE_MASK
                // ----- _USE_MASK: panned mask sample -> per-channel tint + opacity multiply -----
                // 1:1 source = vfxadvance Fragment_b175.hlsl (pure HG_ENABLE_MV+_USE_CUT_OFF+_USE_MASK; mask math is
                //   cutoff-independent). The mask-KEYWORD variant repurposes _MaskTex*/_UseMaskTexAsAlpha as a REAL
                //   texture mask and DROPS the base depth soft-fade (softGate) that the no-mask permutation folds onto
                //   the same cbuffer slots (b155 vs b175): b175's alpha (_491) has NO softV*softU term, only maskAlphaMul.
                //   So here we OVERRIDE the base color/baseAlpha/opacity computed above with the mask-multiplied form.
                //
                // Mask UV: identical BuildVfxUV idiom as MainTex but on the _MaskTex* slots, chanScroll = custom1.y
                //   (b175:156 _179 uses _MaskTexUVSpeed.z/.w * _63, _63 == custom1y), time = _VFXParams0.w == _Time.y.
                float2 maskUV = BuildVfxUV(input.uv0, input.uv1, _MaskTexUVSpeed, _MaskTexUVWeights,
                                           _MaskTexUVRotateMat, _MaskTex_ST, custom1y, customTime);
                // _USE_BRIGHT distort also warps the MASK UV, gated by _MaskTexUseDisturb (b211:239 _701 sample folds
                //   _462/_463 == brightDistortU/V via mad(.., _MaskTexUseDisturb, maskUV)). brightDistortU/V == 0 unless
                //   _USE_BRIGHT is on (computed pre-sample above), so this matches b211 (mask+bright) without affecting
                //   the pure-mask permutation. Same noise lanes as the MainTex fold (one shared distort, two textures).
                maskUV.x = mad(brightDistortU, _MaskTexUseDisturb, maskUV.x);
                maskUV.y = mad(brightDistortV, _MaskTexUseDisturb, maskUV.y);
                // Mask sample (b175:157 _177 = T1.SampleBias(sampler_LinearRepeat_MaskTex, _179, _GlobalMipBias)).
                float4 maskSample = SAMPLE_TEXTURE2D_BIAS(_MaskTex, sampler_MaskTex, maskUV, _GlobalMipBias.x);
                // Per-channel RGB multiplier: lerp(maskChannel, 1, _UseMaskTexAsAlpha)
                //   (b175:170-172 mad(_UseMaskTexAsAlpha, -mask.rgb + _327, mask.rgb); _327 == 1.0).
                float maskMulR = mad(_UseMaskTexAsAlpha, ((-0.0) - maskSample.x) + 1.0, maskSample.x);
                float maskMulG = mad(_UseMaskTexAsAlpha, ((-0.0) - maskSample.y) + 1.0, maskSample.y);
                float maskMulB = mad(_UseMaskTexAsAlpha, ((-0.0) - maskSample.z) + 1.0, maskSample.z);
                // Alpha multiplier: lerp(maskA, maskR, _UseMaskTexAsAlpha)
                //   (b175:176 mad(_UseMaskTexAsAlpha, -mask.w + mask.x, mask.w)).
                float maskMulA = mad(_UseMaskTexAsAlpha, ((-0.0) - maskSample.w) + maskSample.x, maskSample.w);

                // RGB: fold maskMul into the base color numerator, inside the same exposure-divide + [0,1000] clamp.
                //   (b175:170-172 _368/_370/_371 == base color expr with the maskMul factor multiplied in pre-divide.)
                color.x = min(max((mainRGB.x * ((vc.x * _TintColor.x) * _TintColorIntensity) * maskMulR) / postExposure, 0.0), 1000.0);
                color.y = min(max((mainRGB.y * ((vc.y * _TintColor.y) * _TintColorIntensity) * maskMulG) / postExposure, 0.0), 1000.0);
                color.z = min(max((mainRGB.z * ((vc.z * _TintColor.z) * _TintColorIntensity) * maskMulB) / postExposure, 0.0), 1000.0);
                // Alpha: base softGate is REPLACED by maskMulA (b175 has no depth soft-fade in the mask variant).
                //   (b175:176-177 _491/_492 == lodFade * (maskAlphaMul * (mainAlpha * vertColorAlpha)), clamp[0,1].)
                opacity = clamp(lodFadeTerm * (maskMulA * (mainAlpha * ((vcA * _TintColor.w) * _TintColorAlpha))), 0.0, 1.0);
            #endif

            #if defined(_USE_DISSOLVE)
                // ----- _USE_DISSOLVE: dissolve threshold clip + emissive burning edge -----
                // 1:1 source = vfxadvance Fragment_b193.hlsl:164-182,177 (HG_ENABLE_MV+_USE_CUT_OFF+_USE_DISSOLVE; the cleanest
                //   dissolve-bearing vfxadvance variant). The _USE_CUT_OFF co-feature contributes ONLY the schedule term
                //   _97*_BlendTexUVWeights.y (== _CutOffAffectDissolve, b193:165) and the opacity factor mad(.., _CutOffWidth,..)
                //   (b193:177); both are dropped here as they belong to _USE_CUT_OFF, leaving the pure dissolve math.
                //   The math is identical to the de-aliased sibling HGRP_VfxBaseBatched_Fix:656-667 (Fragment_b47:130-148),
                //   with two vfxadvance-specific facts honored: (a) the dissolve schedule carries a particle term
                //   custom1.z*_InParticle (b193:165 TEXCOORD_2.z*_InParticle) that b47 lacked; (b) the exposure divide + [0,1000]
                //   clamp wrap the WHOLE edge-blended color incl. the emissive term (b193:180-182), matching this shader's BASE form.
                //   b193 SSA slot-aliasing decoded: _MaskTexUseDisturb(c11.y)=_DissolveScheduleOffset, _DisturbVIntensity1(c11.w)=
                //   _DissolveEmissiveEdge, _DisturbUIntensity1(c11.z)=_DissolveEdgeSharp, _BlendTexUseDisturb(c16)/_BlendDisableVertColor
                //   (c16.y)/_DissolveEdgeSharp(c16.z)=_DissolveEmissiveColor.xyz, T1=_DissolveTex.
                // Dissolve UV built in vert (input.uvDissolve) on the dedicated _Dissolve* slots. Sample R channel. (b193:164 _264)
                float dissTex = SAMPLE_TEXTURE2D_BIAS(_DissolveTex, sampler_DissolveTex, input.uvDissolve, _GlobalMipBias.x).x;
                // Schedule: custom1.z*_InParticle + _DissolveScheduleOffset (cutoff term _CutOffAffectDissolve dropped). (b193:165)
                float dissolveSchedule = mad(input.custom.z, _InParticle, _DissolveScheduleOffset);
                // dissolveDrive = dissTex - (schedule*2.02 - 1.01). (b193:165 _269; consts asfloat 2.019999980926513671875/-1.0099999904632568359375)
                float dissolveDrive = ((-0.0) - mad(dissolveSchedule, 2.019999980926513671875, -1.0099999904632568359375)) + dissTex;
                // Emissive edge mask: clamp((_DissolveEmissiveEdge - dissolveDrive) * _DissolveEdgeSharp, 0, 1). (b193:175 _426)
                float dissEdge = clamp((((-0.0) - dissolveDrive) + _DissolveEmissiveEdge) * _DissolveEdgeSharp, 0.0, 1.0);
                // Color: lerp(basePre, _DissolveEmissiveColor*_TintColorIntensity, dissEdge) folded as mad, /postExposure, clamp[0,1000].
                //   basePre = mainRGB * (vc*_TintColor*_TintColorIntensity)  (pre-exposure). (b193:180-182 _517/_519/_520 via _407..409)
                float3 dissBasePre = float3(mainRGB.x * ((vc.x * _TintColor.x) * _TintColorIntensity),
                                            mainRGB.y * ((vc.y * _TintColor.y) * _TintColorIntensity),
                                            mainRGB.z * ((vc.z * _TintColor.z) * _TintColorIntensity));
                color.x = min(max(mad(dissEdge, mad(dissEdge * _DissolveEmissiveColor.x, _TintColorIntensity, ((-0.0) - dissBasePre.x)), dissBasePre.x) / postExposure, 0.0), 1000.0);
                color.y = min(max(mad(dissEdge, mad(dissEdge * _DissolveEmissiveColor.y, _TintColorIntensity, ((-0.0) - dissBasePre.y)), dissBasePre.y) / postExposure, 0.0), 1000.0);
                color.z = min(max(mad(dissEdge, mad(dissEdge * _DissolveEmissiveColor.z, _TintColorIntensity, ((-0.0) - dissBasePre.z)), dissBasePre.z) / postExposure, 0.0), 1000.0);
                // Opacity: dissolveAlpha = clamp(dissolveDrive * _DissolveEdgeSharp, 0, 1). b193 KEEPS the base depth soft-gate in
                //   the dissolve variant (b193:177 retains the softV*softU wrapper), unlike the mask variant. b193:177 folds
                //   dissolveAlpha INSIDE the SINGLE outer clamp[0,1], wrapping the UNCLAMPED base product (lodFade*softGate*
                //   dissolveAlpha*mainAlpha*vcA*_TintColor.w*_TintColorAlpha). Reusing the already-[0,1]-clamped baseAlpha and
                //   multiplying after would double-clamp (diverges when the base product > 1, e.g. _TintColorAlpha up to 10),
                //   so rebuild the product here with dissolveAlpha inside one clamp, mirroring b193:177's nesting exactly.
                float dissolveAlpha = clamp(dissolveDrive * _DissolveEdgeSharp, 0.0, 1.0);
                opacity = clamp(lodFadeTerm * (softGate * (dissolveAlpha * (mainAlpha * ((vcA * _TintColor.w) * _TintColorAlpha)))), 0.0, 1.0);
            #endif

            #if defined(_USE_BLEND)
                // ----- _USE_BLEND: secondary _BlendTex added OVER the tinted main color, weighted by combined alpha -----
                // 1:1 source = vfxadvance/Sub0_Pass0_Fragment_b171.hlsl:160-161,173-174,176-178,188 (Keywords
                //   HG_ENABLE_MV _USE_BLEND _USE_CUT_OFF = the minimal in-ladder _USE_BLEND vfxadvance variant the fragment
                //   ladder selects, vfxadvance.shader:281). This is THIS file's own family, so it is the §B ground truth.
                //   b171 is SSA-scrambled: the secondary (blend) texture T1 reads the slots LABELED _MaskTex* (UVSpeed/UVWeights/
                //   UVRotateMat/_ST, c12-c15) and the c16.xyzw tint channels are aliased _BlendTexUseDisturb/_BlendDisableVertColor/
                //   _DissolveEdgeSharp/_DissolveEmissiveEdge — stale reflection names (STYLE_BIBLE §0). The de-aliased vfxbasebatched
                //   blob b41 (Keywords "HG_ENABLE_MV _USE_BLEND" only; b41:83,89,94) was used ONLY to confirm the TRUE blend UV/tint
                //   slots are the named _BlendTex_ST/_BlendTint/_BlendTexUV* — so this port maps by SEMANTIC ROLE onto the named
                //   _BlendTex* uniforms (matching every other feature in this file). NOTE: b41 (a DIFFERENT shader, vfxbasebatched)
                //   uses RAW vertColor in the blend term; vfxadvance instead folds lerp(vertColor,1,_MaskTexUseDisturb) on the blend
                //   weight AND each RGB channel (b171:174,176-178). This is a genuine vfxadvance _USE_BLEND trait, NOT a cutoff
                //   artifact — proven by the no-_USE_CUT_OFF sibling b195:192-195 which carries the IDENTICAL lerp. Ported below.
                //
                // Blend UV: same BuildVfxUV idiom as MainTex/MaskTex but on the _BlendTex* slots. vfxadvance builds this UV in
                //   the FRAGMENT (b171:160 _179 = full pan/rotate/ST expansion); chanScroll = custom1.y (property contract:
                //   _BlendTexUVSpeed ZW = "By Custom1.Y", vfxadvance.shader:48), pan time = _VFXParams0.w == _Time.y.
                //   (b41:139 used the simpler vertex-prebaked TEXCOORD_1.xy*_BlendTex_ST.xy+.zw; vfxadvance's fragment-built
                //    full-transform form b171:160 is the faithful vfxadvance spelling and the one this file uses everywhere.)
                float2 blendUV = BuildVfxUV(input.uv0, input.uv1, _BlendTexUVSpeed, _BlendTexUVWeights,
                                            _BlendTexUVRotateMat, _BlendTex_ST, custom1y, customTime);
                // _USE_BRIGHT distort also warps the BLEND UV, gated by _BlendTexUseDisturb (b171:161 samples T1 with the same
                //   per-texture disturb fold the MainTex/MaskTex use; brightDistortU/V == 0 unless _USE_BRIGHT is on). Same two
                //   shared distort lanes as the MainTex fold above (one distort, propagated to each texture by its own gate).
                blendUV.x = mad(brightDistortU, _BlendTexUseDisturb, blendUV.x);
                blendUV.y = mad(brightDistortV, _BlendTexUseDisturb, blendUV.y);
                // Blend sample (b171:161 _177 = T1.SampleBias(sampler_LinearRepeat_MainTex, blendUV, _GlobalMipBias)).
                //   T1 == _BlendTex; the global blob sampler -> per-texture SAMPLER(sampler_BlendTex) (URP infra, same LinearRepeat
                //   semantics, STYLE_BIBLE §2). _GlobalMipBias is float2 in URP -> .x (matches MainTex above).
                float4 blendSample = SAMPLE_TEXTURE2D_BIAS(_BlendTex, sampler_BlendTex, blendUV, _GlobalMipBias.x);
                // Combined-alpha weight: clamp( (tintA*mainAlpha + blendSample.w) * (blendVertA * _BlendTint.w), 0, 1 ).
                //   GROUND TRUTH = the in-ladder vfxadvance blob (NOT the vfxbasebatched b41 surrogate): b171:174 _357 =
                //   clamp((mad(_MaskTexUseDisturb,1-vcA,vcA) * _BlendTint.w) * mad(_349,_271,_177.w), 0, 1). The blend layer's
                //   vert-alpha is lerp(vertAlpha,1,_MaskTexUseDisturb) — a per-blend "disable vert color" fold on the aliased
                //   slot c11.y. (b41's vfxbasebatched form drops this; vfxadvance keeps it — proven cutoff-INDEPENDENT by the
                //   no-_USE_CUT_OFF sibling b195:192. _MaskTexUseDisturb Range(0,1)=0 default => identity for default materials.)
                float tintA      = (vcA * _TintColor.w) * _TintColorAlpha;                                  // (b171:173 _349)
                float blendVertA = mad(_MaskTexUseDisturb, ((-0.0) - vertAlpha) + 1.0, vertAlpha);          // (b171:174 mad(_MaskTexUseDisturb,_288,TEXCOORD_3.w))
                float blendW     = clamp(mad(tintA, mainAlpha, blendSample.w) * (blendVertA * _BlendTint.w), 0.0, 1.0); // (b171:174 _357)
                // RGB: additive (blendW * blendSample.rgb) * (blendVertColor.rgb * _BlendTint.rgb) folded OVER the BASE tinted color.
                //   b171:176-178 add the blend term AFTER the exposure-divide (the base numerator alone is /_376, the additive
                //   blend term is NOT divided), all inside the [0,1000] clamp. Mirror that nesting: keep this file's BASE
                //   numerator/postExposure, then mad() the blend term on top, then clamp[0,1000]. (b171:176-178 _383/_385/_386)
                //   The blend term's vert color is lerp(vertColor,1,_MaskTexUseDisturb) — the SAME per-blend vert-disable fold as
                //   the weight above (b171:176 mad(_MaskTexUseDisturb,_284,TEXCOORD_3.x)*_BlendTexUseDisturb; the c16.xyz tint
                //   channels are aliased _BlendTexUseDisturb/_BlendDisableVertColor/_DissolveEdgeSharp == _BlendTint.xyz). The
                //   vfxbasebatched b41 surrogate uses RAW vertColor and dropped this — corrected to the vfxadvance ground truth.
                float3 blendVertColor = float3(mad(_MaskTexUseDisturb, ((-0.0) - vertColor.x) + 1.0, vertColor.x),
                                               mad(_MaskTexUseDisturb, ((-0.0) - vertColor.y) + 1.0, vertColor.y),
                                               mad(_MaskTexUseDisturb, ((-0.0) - vertColor.z) + 1.0, vertColor.z)); // (b171:176-178)
                float3 baseNumerator = float3(mainRGB.x * ((vc.x * _TintColor.x) * _TintColorIntensity),
                                              mainRGB.y * ((vc.y * _TintColor.y) * _TintColorIntensity),
                                              mainRGB.z * ((vc.z * _TintColor.z) * _TintColorIntensity));
                color.x = min(max(mad(blendW * blendSample.x, blendVertColor.x * _BlendTint.x, baseNumerator.x / postExposure), 0.0), 1000.0);
                color.y = min(max(mad(blendW * blendSample.y, blendVertColor.y * _BlendTint.y, baseNumerator.y / postExposure), 0.0), 1000.0);
                color.z = min(max(mad(blendW * blendSample.z, blendVertColor.z * _BlendTint.z, baseNumerator.z / postExposure), 0.0), 1000.0);
                // Opacity: blend does NOT add its own alpha gate — b171:188 SV_Target.w = (1-_BlendMode)*_507, where _507
                //   (b171:182) = clamp((mainAlpha*tintA) * <cutoff/nearFade gates> * lodFade, 0, 1), i.e. the BASE alpha product
                //   times only inherited gates. Keep this file's BASE opacity (softGate*lodFade wrapper) unchanged. (b171:182,188)
            #endif

                // DONE(1:1): _USE_BRIGHT  -> 2-octave value-noise UV distortion, spot-distance gated. Ported ABOVE in the pre-sample
                //   UV section (it must run BEFORE the MainTex/MaskTex samples) from vfxadvance Fragment_b211.hlsl:176-228.
                //   FINDING (corrects the old TODO): vfxadvance's _USE_BRIGHT is UV-DISTORT ONLY — it does NOT do spot/scanline
                //   _BrightColor injection. ZERO of the 148 vfxadvance fragment blobs reference _BrightColor/_ScanFillColor/
                //   _ScanLineSchedule/_ScanLineWidth/_BrightType/_InnerRadius/_OuterRadius/_DistortScale/_DistortOnEdge by name;
                //   the `43758.546875` value-noise appears in EXACTLY the 8 _USE_BRIGHT blobs and no others. The spot/scanline
                //   color "Bright" lives only in the sibling family (vfxbasebatched Fragment_b37); the two features share ONLY
                //   the value-noise hash, so the old "== VfxBaseBatched 516-626" cite was a conflation. No color/alpha injection
                //   belongs here for vfxadvance — the distort feeds the texture sampling and propagates through BASE color/alpha.
                //   NOTE: _USE_BRIGHT_DOUGHNUT (ring variant, _DoughnutRadius/_DoughnutWidth) remains a separate TODO — it is a
                //   distinct keyword/permutation in the vfxadvance ladder, not covered by this value-noise distort.
            #if defined(_USE_SOFTBLEND)
                // ----- _USE_SOFTBLEND: depth-buffer soft-particle fade -----
                // 1:1 source = vfxadvance Fragment_b243.hlsl:103-126 (HG_ENABLE_MV+_USE_SLUDGE+_USE_SOFTBLEND), the minimal
                //   _USE_SOFTBLEND-bearing variant (blob headers carrying the keyword: b243/b245/b247/b397/b399/b401). Verified
                //   identical to the sibling exemplar HGRP_VfxBaseBatched_Fix.shader:676-684 (same HGRP VFX particle family, same
                //   compiled soft-fade math). b243 packs the material cbuffer into CB2_m0[14]; SSA slots decoded by usage
                //   (STYLE_BIBLE §0/§2): the only SoftBlend-unique uniforms are CB2_m0[13].x=_SoftDistance, CB2_m0[13].y=_SoftBias
                //   (they appear ONLY in the b243:115 soft-fade clamp; cross-checked vs the named-field property contract
                //   _SoftDistance "Soft Distance"(Range 0.001,10)=0.001 / _SoftBias "Soft Bias"=0, vfxadvance.shader:272-273).
                // b243 reads scene depth as _109 = T0.SampleLevel(sampler_LinearClamp, gl_FragCoord.xy*_ScreenSize.zw, 0).x (the
                //   HGRP camera depth texture) -> URP infra-substitute = SampleSceneDepth(screenUV) (STYLE_BIBLE §2 HGRP depth-
                //   global -> URP; same path as the already-1:1 _USE_EDGECOLOR below, target:1063). Scene |view-Z| reconstructs
                //   the SAME way as the fragment's own viewZ: ReconstructWorldPos(UNITY_MATRIX_I_VP) then ViewSpaceZAbs
                //   (b243:110-115 _136/_195/_216 expand _InvViewProjMatrix-unproject + _ViewMatrix row-2 dot + abs()); exact, not
                //   approximate. Fragment |view-Z| == BASE-computed 'viewZ' (target:798 == b243:113-114 _221=abs(_216)).
                float softSceneDeviceZ = SampleSceneDepth(screenUV);
                float3 softSceneWorldPos = ReconstructWorldPos(screenUV, softSceneDeviceZ);
                float softSceneViewZ = ViewSpaceZAbs(softSceneWorldPos);
                // soft = clamp((-|fragViewZ| + |sceneViewZ| + _SoftBias) / _SoftDistance, 0, 1). (b243:115 _241)
                //   abs(viewZ)/abs(sceneViewZ) are redundant here (ViewSpaceZAbs already abs's), but kept to mirror the blob's
                //   explicit abs() spelling 1:1 (== VfxBaseBatched_Fix:681).
                float softFade = clamp((((-0.0) - abs(viewZ)) + abs(softSceneViewZ) + _SoftBias) / _SoftDistance, 0.0, 1.0);
                // softFade multiplies INTO the alpha product alongside the BASE softGate * lodFade. b243:125-126 places _241 in
                //   the same leading slot the BASE keeps softGate (b243 has no MaskTexAsAlpha gate in this permutation, so its
                //   own softGate==1), then b243:126 _468 = clamp((1-LODFade.y)*_461, 0, 1). Rebuild the product with softFade
                //   inside the SINGLE outer clamp (matching b243:126 / the Dissolve+Edge nesting above), NOT baseAlpha*softFade,
                //   which would double-clamp when the unclamped base product > 1 (e.g. _TintColorAlpha up to 10). (b243:125 _461 / :126 _468)
                opacity = clamp(lodFadeTerm * (softGate * (softFade * (mainAlpha * ((vcA * _TintColor.w) * _TintColorAlpha)))), 0.0, 1.0);
            #endif
            #if defined(_EMISSION)
                // ----- _EMISSION: VERIFIED NO-OP in the vfxadvance fragment export (compile-safe stub, NOT fabricated math) -----
                // FINDING (corrects the old TODO `+= _EmissionTex.rgb * _EmissionColor`): that additive term does NOT exist in any
                //   exported vfxadvance fragment blob. The `_EMISSION` keyword IS in the fragment permutation matrix
                //   (vfxadvance.shader:248 `#pragma multi_compile_local _ _EMISSION`) and the `_EmissionTex`(2D "black") /
                //   `[HDR][Gamma] _EmissionColor`(white) properties DO exist (vfxadvance.shader:116-117), but the compiled
                //   fragment code for every `_EMISSION`-defined permutation is byte-identical to its `_EMISSION`-undefined sibling
                //   — emission contributes ZERO texture binds and ZERO math. Exhaustive ground-truth proof (§B):
                //   1. The fragment ladder selects `_EMISSION` only in combo with _USE_FRESNEL+_USE_MASK+_NORMAL_MAP, including
                //      vfxadvance/Sub0_Pass0_Fragment_b235.hlsl (non-instanced, vfxadvance.shader:847-849) and its SRP_INSTANCING_ON
                //      twin b389 (vfxadvance.shader:1078-1080). b235 reads its WHOLE body: it declares only T0..T3
                //      (MainTex/NormalMap/MaskTex/DissolveTex, b235:141-144), samples no 4th color texture, and its color tail
                //      (b235:229,238-240 `_688`/`_Globals_FresnelColor` lerp + b235:243-245 SV_Target) is pure FRESNEL+MASK
                //      compositing. There is NO `_EmissionTex`/`_EmissionColor` symbol anywhere in b235 or b389 (the only two
                //      `_EMISSION` frag blobs); the earlier case-insensitive grep "hit" was the substring inside
                //      `_DissolveEmissiveEdge` (b235:102,126), not an emission term.
                //   2. b235's entire color/alpha math is ALREADY ported 1:1 by the existing blocks in this file: the FRESNEL
                //      color lerp -> `_USE_FRESNEL` (target:1229-1276, blob b169), the mask-as-alpha gate -> `_USE_MASK`, and the
                //      tangent-space normal -> `_NORMAL_MAP`. `_EMISSION` adds nothing on top of those.
                //   3. The exporter emitted only the `_EMISSION`-ON permutation for the FRESNEL+MASK+NORMAL+MV combo (no OFF twin
                //      exists) — i.e. it deduped the two because they compile identically, the signature of a dead keyword.
                //   Therefore the faithful 1:1 behavior is the no-op the export encodes. Writing `color += _EmissionTex.rgb *
                //   _EmissionColor` would be invented math with no blob backing (a §B/§E violation), so it is deliberately NOT done.
                //   The `_EmissionTex`/`_EmissionColor` decls (properties:214-215, CBUFFER:446-447, TEXTURE2D:526) are retained for
                //   material/inspector compatibility (and any non-fragment HG pass / C# VFX binder that authors them); a zero-weight
                //   touch keeps the bound texture/color in this variant's signature without altering output (× 0 == identity).
                color += (SAMPLE_TEXTURE2D_BIAS(_EmissionTex, sampler_EmissionTex, input.uv0.xy, _GlobalMipBias.x).rgb * _EmissionColor.rgb) * 0.0; // verified-no-op (b235/b389 carry no emission add)
            #endif
            #ifdef _HEIGHT_COLOR_GRADIENT
                // ----- _HEIGHT_COLOR_GRADIENT: 2-band world-Y gradient that lerps color (by AffectColor) and alpha
                //   (by AffectAlpha) toward two HDR band colors, each band a double-smoothstep window in world-space Y. -----
                // 1:1 source = vfxadvance/Sub0_Pass0_Fragment_b231.hlsl:176-181,203-215,235 (Keywords HG_ENABLE_MV
                //   _HEIGHT_COLOR_GRADIENT _USE_DISSOLVE _USE_FRESNEL = the MINIMAL in-ladder _HEIGHT_COLOR_GRADIENT
                //   variant the fragment ladder selects, vfxadvance.shader:841; no fewer-keyword HCG blob exists). This is
                //   THIS file's own family, so it is the §B ground truth. Verified directly against the b231 SSA (this trace).
                //
                // WORLD-Y PROVENANCE (the one infra substitution): the blob reads world-Y from the interpolated varying
                //   TEXCOORD_7.y. Its paired vertex Vertex_b230.hlsl:511-513 sets TEXCOORD_7 = (_640,_642,_638) where
                //   _638/_640/_642 = dot(ObjectToWorld_row, POSITION) (b230:426-431) = the object->world SURFACE position.
                //   The 1:1 URP surrogate is input.positionWS (== TransformObjectToWorld(positionOS), target:797) — the SAME
                //   particle SURFACE worldPos every other feature in this file uses for TEXCOORD (fresnel target:1252, cutoff
                //   target:1691). So worldY = input.positionWS.y. (When _USE_VERTOFFSET co-exists, positionWS already carries
                //   the vert push (target:877); b231 has no _USE_VERTOFFSET, so for the gradient-in-isolation truth this is exact.)
                //
                // b231 type_UnityPerMaterial slot-aliasing decoded (STYLE_BIBLE §0; the compiled permutation packs the HCG
                //   uniforms onto the unused blend/dissolve cbuffer slots — c20=_BlendTexUVWeights, c21=_BlendTint, c22=dissolve
                //   tail, c23=_DissolveTex_ST, c24=_DissolveUVSpeed): band-1 packed vector _BlendTexUVWeights(c20) =
                //   (_HeightColorGradientSmooth, _HeightColorGradientLocationTop, _HeightColorGradientLocationDown,
                //   _HeightColorGradientAffectColor) — note b231:115-117 KEEP the real names on c20.y/.z/.w, proving the alias.
                //   band-2 packed vector _BlendTint(c21) = (Smooth2, LocTop2, LocDown2, AffectColor2). Band-1 color RGBA =
                //   _DissolveTexUseDisturb(c22.x)/_DissolveScheduleOffset(c22.y)/_DissolveEdgeSharp_at_360(c22.z)/
                //   _DissolveEmissiveEdge_at_364(c22.w) = _HeightColorGradientColor.xyzw. Band-2 color RGBA = _DissolveTex_ST(c23) =
                //   _HeightColorGradientColor2.xyzw. AffectAlpha = _DissolveUVSpeed.x(c24.x), AffectAlpha2 = _DissolveUVSpeed.y(c24.y).
                //   Re-mapped by SEMANTIC ROLE onto the real _HeightColorGradient* material props (matching every feature here).
                //
                // COMPOSITION: in b231 the band color overlay is built ON the base tinted color (_402 = _329*_379, the base
                //   color only — no dissolve/fresnel mixed in yet) and band-2 OVER band-1 (_477), THEN fresnel lerps on top
                //   (_756). This file composes features as ordered overrides of the running color/opacity, so HCG lerps the
                //   CURRENT color/opacity toward each band — identical lerp structure mad(weight*affect, target-cur, cur),
                //   the exact spelling the blob uses for both the color (b231:203-206,213-215) and alpha (b231:206,235) folds.
                float hcgWorldY = input.positionWS.y;                                                  // (b231 TEXCOORD_7.y == Vertex_b230:512 _642 world-Y)
                // Band 1 window (_BlendTexUVWeights = Smooth/LocTop/LocDown/AffectColor). b231:176-181.
                float _hcg68 = _HeightColorGradientSmooth + _HeightColorGradientLocationTop;           // (b231:176 _68)
                float _hcg79 = (-0.0) - _HeightColorGradientSmooth;                                    // (b231:177 _79)
                float _hcg85 = _hcg79 + _HeightColorGradientLocationDown;                              // (b231:178 _85)
                float _hcg101 = clamp((1.0 / (((-0.0) - _hcg68) + (_hcg79 + _HeightColorGradientLocationTop))) * (((-0.0) - _hcg68) + hcgWorldY), 0.0, 1.0);  // (b231:179 _101 upper edge @LocTop)
                float _hcg102 = clamp((1.0 / ((_HeightColorGradientSmooth + _HeightColorGradientLocationDown) + ((-0.0) - _hcg85))) * (((-0.0) - _hcg85) + hcgWorldY), 0.0, 1.0); // (b231:180 _102 lower edge @LocDown)
                float band1W = ((_hcg102 * _hcg102) * mad(_hcg102, -2.0, 3.0)) * ((_hcg101 * _hcg101) * mad(_hcg101, -2.0, 3.0)); // (b231:181 _111 smoothstep*smoothstep)
                // Band 2 window (_BlendTint = Smooth2/LocTop2/LocDown2/AffectColor2). b231:207-212.
                float _hcg429 = _HeightColorGradientSmooth2 + _HeightColorGradientLocationTop2;        // (b231:207 _429)
                float _hcg438 = (-0.0) - _HeightColorGradientSmooth2;                                  // (b231:208 _438)
                float _hcg444 = _hcg438 + _HeightColorGradientLocationDown2;                           // (b231:209 _444)
                float _hcg455 = clamp((1.0 / ((_HeightColorGradientSmooth2 + _HeightColorGradientLocationDown2) + ((-0.0) - _hcg444))) * (((-0.0) - _hcg444) + hcgWorldY), 0.0, 1.0); // (b231:210 _455 lower edge @LocDown2)
                float _hcg458 = clamp((1.0 / (((-0.0) - _hcg429) + (_hcg438 + _HeightColorGradientLocationTop2))) * (((-0.0) - _hcg429) + hcgWorldY), 0.0, 1.0); // (b231:211 _458 upper edge @LocTop2)
                float band2W = ((_hcg455 * _hcg455) * mad(_hcg455, -2.0, 3.0)) * ((_hcg458 * _hcg458) * mad(_hcg458, -2.0, 3.0)); // (b231:212 _465 smoothstep*smoothstep)
                // Color: band-1 lerp toward _HeightColorGradientColor.rgb by band1W*AffectColor (b231:203-205 _402/403/404),
                //   then band-2 lerp toward _HeightColorGradientColor2.rgb by band2W*AffectColor2 (b231:213-215 _477/478/479).
                //   Same mad(weight, target-cur, cur) lerp the blob emits; applied to the running post-exposure color this file holds.
                float hcgColorW1 = band1W * _HeightColorGradientAffectColor;                           // (b231:203 _111 * _BlendTexUVWeights.w)
                color.x = mad(hcgColorW1, ((-0.0) - color.x) + _HeightColorGradientColor.x, color.x);  // (b231:203 _402)
                color.y = mad(hcgColorW1, ((-0.0) - color.y) + _HeightColorGradientColor.y, color.y);  // (b231:204 _403)
                color.z = mad(hcgColorW1, ((-0.0) - color.z) + _HeightColorGradientColor.z, color.z);  // (b231:205 _404)
                float hcgColorW2 = band2W * _HeightColorGradientAffectColor2;                          // (b231:213 _465 * _BlendTint.w)
                color.x = mad(hcgColorW2, ((-0.0) - color.x) + _HeightColorGradientColor2.x, color.x); // (b231:213 _477)
                color.y = mad(hcgColorW2, ((-0.0) - color.y) + _HeightColorGradientColor2.y, color.y); // (b231:214 _478)
                color.z = mad(hcgColorW2, ((-0.0) - color.z) + _HeightColorGradientColor2.z, color.z); // (b231:215 _479)
                // Alpha: band-1 lerp toward _HeightColorGradientColor.w by band1W*AffectAlpha (b231:206 _405), then band-2 lerp
                //   toward _HeightColorGradientColor2.w by band2W*AffectAlpha2 (b231:235 inner mad). The blob lerps the UNCLAMPED
                //   base-alpha core then re-clamps inside _744's outer clamp; this file holds the already-[0,1] composited opacity,
                //   so apply the SAME two lerps to it and re-clamp[0,1] once (the blob's _744 wrapper also ends in clamp(.,0,1)).
                opacity = mad(band1W * _HeightColorGradientAffectAlpha, ((-0.0) - opacity) + _HeightColorGradientColor.w, opacity);    // (b231:206 _405 alpha lerp -> GradColor.w)
                opacity = clamp(mad(band2W * _HeightColorGradientAffectAlpha2, ((-0.0) - opacity) + _HeightColorGradientColor2.w, opacity), 0.0, 1.0); // (b231:235 _405 lerp -> GradColor2.w, inside _744 clamp)
            #endif
            #ifdef _USE_CUBEMAP
                // ----- _USE_CUBEMAP: world-space reflection of the view ray sampled from _CubeMap, tinted by
                //   _CubeMapColor, ADDED into rgb only (the property literally reads "Use CubeMap (rgb only)",
                //   vfxadvance.shader:89/HGRP_VfxAdvance_Fix:165; alpha/opacity is left untouched). -----
                //
                // PROVENANCE / why no in-ladder blob cite: _USE_CUBEMAP is one of the vfxadvance [Toggle] keywords
                //   (vfxadvance.shader:89) that is EXCLUDED from the exported fragment multi_compile permutation matrix
                //   (the ladder vfxadvance.shader:730-1180 enumerates only 22 keywords — _USE_AIRWALL/_USE_CUT_OFF/.../
                //   _USE_FOG — and _USE_CUBEMAP is NOT among them). Verified exhaustively: ZERO of the 148 vfxadvance
                //   fragment blobs declare a `TextureCube`, call `reflect(`, or run `SAMPLE_TEXTURECUBE*` (grep over
                //   .../effect/vfxadvance/*.hlsl). So there is no SSA blob body to transcribe for THIS shader — the
                //   feature math is unrecoverable from the vfxadvance export and is reconstructed from (a) the property
                //   contract (_CubeMap Cube + _CubeMapColor Color "rgb only") and (b) two ground-truth conventions that
                //   ARE in evidence:
                //     1. The HG-family cubemap reflection idiom — incident view ray reflected about the surface normal,
                //        then sampled from the cube — is ground truth in the sibling characternpr blob set
                //        (HGRP_CharacterNPR_Fix.shader:673-675: `reflDir = reflect(-V, N); SAMPLE_TEXTURECUBE_LOD(...)`).
                //        Only the reflect+sample STRUCTURE is borrowed; characternpr's PBR-IBL weighting (envBRDF, the
                //        roughness->mip `log2(rough)*1.2+5`, ambient-exposure scale) is deliberately NOT copied — that is
                //        a lit-surface IBL term, whereas vfxadvance's "rgb only" cube is an unlit VFX color add.
                //     2. The additive-over-base compositing nesting for an extra rgb term in THIS shader is established
                //        1:1 by _USE_BLEND (target:1238-1254, blob b171:176-178) and _USE_EDGECOLOR (target:1384-1386,
                //        blob b249:166-168): the extra rgb is added on top of the BASE pre-exposure numerator and the SUM
                //        is divided by postExposure, inside the same min(max(.,0),1000) clamp every rgb writer in this file
                //        uses. The cube tint follows that exact nesting (added to the BASE numerator, /postExposure, clamp).
                //
                // View vector V = surface -> camera, reconstructed the SAME way the _USE_FRESNEL block builds its `vdir`
                //   for this shader (target:1064-1077, blob b169:145-149): ortho => normalize(camPos - surfacePosWS);
                //   perspective => the _ViewMatrix row-2 forward basis (UNITY_MATRIX_V[2].xyz). NOTE: this is V (toward the
                //   camera), NOT the incident ray. The characternpr ground-truth cube idiom is reflect(-V, N)
                //   (HGRP_CharacterNPR_Fix:270-273,673: V = normalize(camPos - posWS); reflDir = reflect(-V, N)) — HLSL
                //   reflect(i,n) takes i = incident = camera->surface = -V, so V must be NEGATED at the reflect() call below.
                bool cubeIsOrtho = (0.0 == unity_OrthoParams.w);
                float3 cubeCamFwd = float3(UNITY_MATRIX_V[2][0], UNITY_MATRIX_V[2][1], UNITY_MATRIX_V[2][2]);
                float3 cubeViewDir = cubeIsOrtho ? ((-input.positionWS) + _WorldSpaceCameraPos.xyz) : cubeCamFwd;
                cubeViewDir = cubeViewDir * rsqrt(max(dot(cubeViewDir, cubeViewDir), VIEW_EPS));
                // Reflect about the perturbed normal when _NORMAL_MAP is on (perturbedNormalWS computed above at
                //   target:1050), else the interpolated geometric normal (input.normalWS). Apply the same front-face
                //   flip the fresnel normal uses (target:1085, blob b169:150) so a double-sided particle reflects on its
                //   visible side.
                #if defined(_NORMAL_MAP)
                    float3 cubeNormalWS = perturbedNormalWS;
                #else
                    float3 cubeNormalWS = input.normalWS;
                #endif
                cubeNormalWS = isFrontFace ? cubeNormalWS : (-cubeNormalWS);
                // Incident = camera -> surface = -V (characternpr ground truth reflect(-V, N), HGRP_CharacterNPR_Fix:673).
                float3 cubeReflDir = reflect(-cubeViewDir, cubeNormalWS);
                // Cube sample (mip 0 — the "rgb only" VFX cube carries no roughness term, unlike the characternpr IBL
                //   path which derives a mip from surface roughness). _GlobalMipBias matches every other sample in this
                //   shader (SAMPLE_TEXTURECUBE_BIAS is the cube analogue of the SampleBias used throughout the blobs).
                float3 cubeSample = SAMPLE_TEXTURECUBE_BIAS(_CubeMap, sampler_CubeMap, cubeReflDir, _GlobalMipBias.x).rgb;
                // Tint by _CubeMapColor.rgb and ADD over the BASE tinted rgb, INSIDE the same /postExposure divide + [0,1000]
                //   clamp every rgb writer in this file uses (rgb only — opacity is NOT touched). The cited additive
                //   precedents BOTH fold the extra rgb term through the exposure divide: _USE_BLEND b171:176-178 divides the
                //   whole mad(blendTerm, .., baseNumerator) by /_376(postExposure); _USE_EDGECOLOR b249:166-168 puts
                //   (numerator + _EdgeColor) inside /_557(postExposure). So the cube tint is added to the BASE pre-exposure
                //   numerator and the SUM is divided by postExposure, matching that 1:1 nesting (NOT added raw to the
                //   already-divided `color`, which would over-brighten by a factor of postExposure relative to the precedent).
                float3 cubeBaseNumerator = float3(mainRGB.x * ((vc.x * _TintColor.x) * _TintColorIntensity),
                                                  mainRGB.y * ((vc.y * _TintColor.y) * _TintColorIntensity),
                                                  mainRGB.z * ((vc.z * _TintColor.z) * _TintColorIntensity));
                float3 cubeContrib = cubeSample * _CubeMapColor.rgb;
                color.x = min(max((cubeBaseNumerator.x + cubeContrib.x) / postExposure, 0.0), 1000.0);
                color.y = min(max((cubeBaseNumerator.y + cubeContrib.y) / postExposure, 0.0), 1000.0);
                color.z = min(max((cubeBaseNumerator.z + cubeContrib.z) / postExposure, 0.0), 1000.0);
            #endif
            #if defined(_USE_EDGECOLOR)
                // ----- _USE_EDGECOLOR: soft-particle depth-rim edge glow (additive _EdgeColor) -----
                // 1:1 source = vfxadvance Fragment_b249.hlsl:162-168 (HG_ENABLE_MV+_USE_AIRWALL+_USE_EDGECOLOR), isolated
                //   against the airwall-only sibling b157 (b157 has NEITHER the _493 rim term NOR the additive edge color in
                //   rgb/alpha). b249 SSA slot-aliasing decoded by usage (STYLE_BIBLE §0/§2 "re-identify slots by usage"; the
                //   decompiler mislabels these cbuffer offsets with mask-slot names, but each appears ONLY in the edge math):
                //   _MaskTexUVSpeed.x(c13.x)=_EdgeDistance, _MaskTexUVSpeed.y(c13.y)=_EdgeDistanceOffset,
                //   _MaskTexUVRotateMat(c14).xyzw=_EdgeColor.rgba. (In THIS edge permutation b249 also reads _MaskTexUVWeights.x
                //   (c15) on the airwall UV-select path b249:149/163/166 — that is the airwall feature's own term and is ported
                //   1:1 in the _USE_AIRWALL block below as _AirWallUVWeights; the airwall-only blob b157 is the authoritative
                //   decode for those slots, see target:1458+.) The b249 scene-depth read
                //   _364=T0.SampleLevel(sampler_LinearClamp, gl_FragCoord.xy*_ScreenSize.zw, 0).x is the camera depth texture;
                //   URP infra-substitute = SampleSceneDepth(screenUV) (STYLE_BIBLE §2 HGRP depth-global -> URP). The fragment's
                //   own |viewZ| (b249:_471=abs(_466)) is the BASE-computed 'viewZ' (target:795); both reconstruct view-Z the
                //   SAME way (ReconstructWorldPos via UNITY_MATRIX_I_VP then ViewSpaceZAbs), so this is exact, not approximate.
                // Reconstruct scene-surface |view-Z| from the depth buffer at this pixel. (b249:154 _362 / :160 _466-analogue)
                float edgeSceneDeviceZ = SampleSceneDepth(screenUV);
                float3 edgeSceneWorldPos = ReconstructWorldPos(screenUV, edgeSceneDeviceZ);
                float edgeSceneViewZ = ViewSpaceZAbs(edgeSceneWorldPos);
                // Rim factor: clamp(_EdgeDistance / max(sceneViewZ - fragViewZ, 0.001) - _EdgeDistanceOffset, 0, 1). (b249:162 _493)
                //   eps 0.001 == blob 0.001000000047497451305389404296875f. fragViewZ == viewZ (BASE, target:795 == b249 _471).
                float edgeDenom = max(((-0.0) - viewZ) + edgeSceneViewZ, 0.001);
                float edgeRim = clamp(_EdgeDistance / edgeDenom + ((-0.0) - _EdgeDistanceOffset), 0.0, 1.0);
                // RGB: additive _EdgeColor.rgb folded into the pre-exposure numerator (NOT rim-gated), inside the same
                //   /postExposure divide + [0,1000] clamp as BASE. (b249:166-168 "+ _MaskTexUVRotateMat.x) / _557")
                //   The rim reveals this flat emissive add via the rim-boosted alpha below (premultiplied out = rgb*alpha).
                color.x = min(max((mainRGB.x * ((vc.x * _TintColor.x) * _TintColorIntensity) + _EdgeColor.x) / postExposure, 0.0), 1000.0);
                color.y = min(max((mainRGB.y * ((vc.y * _TintColor.y) * _TintColorIntensity) + _EdgeColor.y) / postExposure, 0.0), 1000.0);
                color.z = min(max((mainRGB.z * ((vc.z * _TintColor.z) * _TintColorIntensity) + _EdgeColor.z) / postExposure, 0.0), 1000.0);
                // Alpha: additive _EdgeColor.a * edgeRim folded INTO the alpha inner, kept under the BASE softGate * lodFade
                //   wrapper + final [0,1] clamp. (b249:163 mad(_MaskTexUVRotateMat.w, _493, alphaInner) * mask * lodFade)
                float edgeAlphaInner = mad(_EdgeColor.w, edgeRim, mainAlpha * ((vcA * _TintColor.w) * _TintColorAlpha));
                opacity = clamp(lodFadeTerm * (softGate * edgeAlphaInner), 0.0, 1.0);
            #endif

                // DONE(1:1): _NORMAL_MAP  -> sample+unpack _NormalMap + TBN -> perturbedNormalWS, fed into the fresnel dot
                //   above (b229:237-260, vs no-normal-map sibling b169:151). Cubemap reflection consumer still TODO above.
                // DONE(1:1): _USE_SCREENUV -> screen-space UV term injected into the main-UV sel coords (depth-scaled via
                //   _ScreenUVUseDepth, view-local blend via _LocalPivortSpace, world-Y override via _UsePosYAsScreenV),
                //   weighted by _MainTexUVWeights.w. Computed in BuildVfxScreenUV() + applied above before the main sample.
                //   Source = Fragment_b215.hlsl:147-160 vs no-screenUV sibling b169:156.
                // DONE(1:1): _USE_AIRWALL -> _AirWallTex tinted overlay ADDED into the BASE color numerator + alpha inner.
                //   Ported below from the isolated airwall-only blob Fragment_b157.
            #if defined(_USE_AIRWALL)
                // ----- _USE_AIRWALL: _AirWallTex game-overlay tint folded additively into color + alpha -----
                // GROUND TRUTH = vfxadvance/Sub0_Pass0_Fragment_b157.hlsl:131-148 (Keywords HG_ENABLE_MV _USE_AIRWALL — the
                //   ISOLATED airwall variant, every other feature off; vfxadvance.shader:260). Diffed against the BASE blob
                //   b155 (HG_ENABLE_MV only): the ONLY airwall delta is (a) one extra texture sample T1 (the airwall mask,
                //   sampled with sampler_LinearRepeat_MainTex -> URP per-texture sampler_AirWallTex, STYLE_BIBLE §2), (b) an
                //   additive tinted term folded into the BASE pre-exposure color numerator, and (c) an additive term folded
                //   into the BASE alpha inner product. The view-Z / motion-vector / softGate tail of b157 is byte-identical
                //   to b155 (just renumbered SSA) and is already the BASE path above — nothing else changes.
                //
                // b157 SSA slot-aliasing decoded by usage (STYLE_BIBLE §0/§2 — the compiled airwall permutation packs the
                //   airwall uniforms onto the stale-labelled mask cbuffer slots; each de-aliased onto the REAL _AirWall*
                //   property the shaderlab exposes, vfxadvance.shader:134-138):
                //     T1 (register t1)                = _AirWallTex
                //     _MaskTexUVWeights.xy (c15.xy)   = _AirWallUVWeights.xy   (UV-set select weights; baked by _AirWallUVSet)
                //     _MaskTexUVRotateMat   (c14)     = _AirWallTex_ST         (scale .xy / offset .zw — applied in the UV build)
                //     _MaskTexUVSpeed.x (c13.x)       = _UseAirWallTexAsAlpha  (the [ToggleUI] "Use AirWall Tex As Alpha")
                //   PROOF the c13.x slot IS _UseAirWallTexAsAlpha (not an invented strength): b157 uses it in the EXACT
                //   "use-tex-as-alpha" idiom the main tex uses for _UseMainTexAsAlpha (target:1013-1015 / b155:126,128-130):
                //     RGB term  mad(1.0, c13.x, airwall.rgb*(1-c13.x))  == lerp(airwall.rgb, 1, c13.x) == UseTexAsAlphaRGB.
                //     alpha term mad(airwall.r, c13.x, airwall.a*(1-c13.x)) == lerp(airwall.a, airwall.r, c13.x). Both are the
                //     identical "rgb->1 / alpha a<->r" pair _UseMainTexAsAlpha drives, so c13.x is that toggle, exactly.
                //
                // Sample the airwall mask on its pre-built (weights-select + _ST) UV (uvAirWall, built in vert). (b157:131-132 _121)
                float4 airWallSample = SAMPLE_TEXTURE2D_BIAS(_AirWallTex, sampler_AirWallTex, input.uvAirWall, _GlobalMipBias.x);
                // RGB overlay: lerp(airwall.rgb, 1, _UseAirWallTexAsAlpha) * _TintColor.rgb  (b157:141-143 the C term of mad(A,B,C):
                //   mad(asfloat(1065353216u), _MaskTexUVSpeed.x, airwall.rgb*_275)*_TintColor.rgb ; asfloat(1065353216u)==1.0,
                //   _275==1-_UseAirWallTexAsAlpha). UseTexAsAlphaRGB is the byte-identical lerp(rgb,1,u) form (target:572-579).
                float3 airWallRGB = UseTexAsAlphaRGB(airWallSample.xyz, _UseAirWallTexAsAlpha);
                float3 airWallTinted = airWallRGB * _TintColor.xyz;
                // Alpha overlay: lerp(airwall.a, airwall.r, _UseAirWallTexAsAlpha) * _TintColor.w  (b157:148 the C term:
                //   mad(_127, _MaskTexUVSpeed.x, airwall.w*_275)*_TintColor.w ; _127==airwall.r). NOTE the asymmetry vs RGB:
                //   the airwall ALPHA lerps toward the airwall RED channel (not toward 1) by _UseAirWallTexAsAlpha — this is
                //   the same a<->r main-tex-as-alpha lerp, kept 1:1.
                float airWallA = mad(airWallSample.x, _UseAirWallTexAsAlpha, airWallSample.w * (1.0 + ((-0.0) - _UseAirWallTexAsAlpha))) * _TintColor.w;
                // RGB: ADD the airwall tint onto the BASE pre-exposure numerator (mainRGB*vc*_TintColor.rgb*_TintColorIntensity ==
                //   the A*B of b157:141), inside the SAME /postExposure divide + [0,1000] clamp every rgb writer uses. This is the
                //   identical additive-inside-exposure nesting as _USE_EDGECOLOR (target:1413-1415, b249:166-168 (num+_EdgeColor)/exp).
                //   (b157:141-143 _324/_326/_327 = min(max(mad(A,B,C)/_316,0),1000), A*B == baseNumerator, C == airWallTinted.)
                float3 airWallBaseNum = float3(mainRGB.x * ((vc.x * _TintColor.x) * _TintColorIntensity),
                                               mainRGB.y * ((vc.y * _TintColor.y) * _TintColorIntensity),
                                               mainRGB.z * ((vc.z * _TintColor.z) * _TintColorIntensity));
                color.x = min(max((airWallBaseNum.x + airWallTinted.x) / postExposure, 0.0), 1000.0);
                color.y = min(max((airWallBaseNum.y + airWallTinted.y) / postExposure, 0.0), 1000.0);
                color.z = min(max((airWallBaseNum.z + airWallTinted.z) / postExposure, 0.0), 1000.0);
                // Alpha: fold airWallA additively into the BASE alpha inner (mad(tintA, mainAlpha, airWallA)), keeping the BASE
                //   softGate * lodFade wrapper + single outer clamp[0,1]. b157:148-149 _455/_456 = clamp( (mad((vcA*_TintColor.w*
                //   _TintColorAlpha), mainAlpha, airWallA) * <maskGate==softGate>) * lodFade , 0, 1). Rebuild the product with the
                //   airwall term inside the SINGLE outer clamp (same nesting discipline as Dissolve/Edge/Cut above), NOT
                //   opacity*=, which would double-clamp the already-[0,1] baseAlpha.
                float airWallTintA = (vcA * _TintColor.w) * _TintColorAlpha;                                  // (b157:148 A term)
                opacity = clamp(lodFadeTerm * (softGate * mad(airWallTintA, mainAlpha, airWallA)), 0.0, 1.0);  // (b157:148-149 _455/_456)
            #endif
            #if defined(_USE_CUT_OFF)
                // ----- _USE_CUT_OFF: oriented-plane directional cut / teleport fade (alpha threshold) -----
                // GROUND TRUTH = vfxadvance/Sub0_Pass0_Fragment_b159.hlsl:130-131,141 (Keywords HG_ENABLE_MV _USE_CUT_OFF —
                //   the ISOLATED cutoff variant, every other feature off; vfxadvance.shader:733-735). Cross-checked against the
                //   cutoff term in b193:157,177,165 (cutoff+dissolve) and b169 (cutoff+fresnel) — identical math, different SSA
                //   register aliasing per permutation, so the slots are mapped by SEMANTIC ROLE onto the real _CutOff* props.
                //
                // b159 SSA slot-aliasing decoded (the compiled cutoff-only permutation packs the cutoff uniforms onto the
                //   c13/c14/c15 float4 slots the stale reflection labels _MaskTexUVSpeed/_MaskTexUVRotateMat/_MaskTexUVWeights;
                //   STYLE_BIBLE §0 — packoffset is ground truth, the float4 names are decompiler reconstructions):
                //     _MaskTexUVSpeed.x (c13.x) = _CutOffPosY        (plane signed-distance offset)
                //     _MaskTexUVSpeed.y (c13.y) = _CutOffSpace       (0 = object space, 1 = world space; lerp selector)
                //     _MaskTexUVSpeed.z (c13.z) = _CutOffWidth       (kept-solid band before the transition starts)
                //     _MaskTexUVSpeed.w (c13.w) = _CutOffTransition  (soft fade width past the solid band)
                //     _MaskTexUVWeights.xyz (c15.xyz) = _CutOffDirection.xyz (oriented-plane normal)
                //     _MaskTexUVRotateMat.x (c14.x) = _CutOffAffectOpacity   (lerp(1, cutMask, this); 0 => cut ignored)
                //   (b193's de-aliased equivalents confirm the grouping: there the same terms land on _BlendTexUVRotateMat.xyzw =
                //    {PosY,Space,Width,Transition}, _BlendTint.xyz = direction, _BlendTexUVWeights.x = AffectOpacity, .y = AffectDissolve.)
                //
                // pos = lerp(objectPos, worldPos, _CutOffSpace). objectPos = input.positionOSCut (blob TEXCOORD_6, Vertex_b312:369-371);
                //   worldPos = input.positionWS (blob TEXCOORD/semantic TEXCOORD1 = particle SURFACE worldPos, Vertex_b312:343-345 +camPos;
                //   NOT the depth-reconstructed scene `worldPos` at target:836). (b159:130-131 mad(TEXCOORD, k, (1-k)*TEXCOORD_6))
                float cutSpace = _CutOffSpace;
                float3 cutPos = float3(mad(input.positionWS.x, cutSpace, (1.0 + ((-0.0) - cutSpace)) * input.positionOSCut.x),
                                       mad(input.positionWS.y, cutSpace, (1.0 + ((-0.0) - cutSpace)) * input.positionOSCut.y),
                                       mad(input.positionWS.z, cutSpace, (1.0 + ((-0.0) - cutSpace)) * input.positionOSCut.z));
                // Signed distance to the oriented cut plane: _CutOffPosY - dot(pos, _CutOffDirection.xyz). (b159:131 _93)
                //   _93 >= 0 == on the kept side; the plane sweeps along _CutOffDirection as _CutOffPosY animates (teleport).
                float cutSigned = ((-0.0) - dot(cutPos, _CutOffDirection.xyz)) + _CutOffPosY;
                // Soft fade ramp across the transition band, hard-gated to the kept half-space. (b159:141 inner)
                //   ramp = clamp(1 - max(cutSigned - _CutOffWidth, 0) / _CutOffTransition, 0, 1) ; keep solid for the first
                //   _CutOffWidth units past the plane, then fall off over _CutOffTransition; step(0, cutSigned) zeroes the cut side.
                float cutRamp = clamp((((-0.0) - (max(cutSigned + ((-0.0) - _CutOffWidth), 0.0) / _CutOffTransition)) + 1.0), 0.0, 1.0);
                float cutSide = asfloat(((cutSigned >= 0.0) ? 0xFFFFFFFFu : 0u) & 0x3F800000u); // step(0, cutSigned); blob (_93>=0?-1:0)&1.0f
                // cutGate = lerp(1, cutRamp*cutSide, _CutOffAffectOpacity): _CutOffAffectOpacity=0 => 1 (cutoff disabled). (b159:141 mad)
                float cutGate = mad(cutRamp * cutSide, _CutOffAffectOpacity, 1.0 + ((-0.0) - _CutOffAffectOpacity));
                // Fold cutGate into the SAME alpha nesting as the BASE (b159:141 _364): clamp(lodFade*(softGate*(cutGate*(mainAlpha*
                //   vertA*_TintColor.w*_TintColorAlpha))),0,1). Rebuild the product with cutGate INSIDE the single outer clamp rather
                //   than `opacity *= cutGate`, which would double-clamp the already-[0,1] baseAlpha and diverge when the base product
                //   exceeds 1 (e.g. _TintColorAlpha up to 10) — same nesting discipline as the dissolve/fresnel blocks above.
                opacity = clamp(lodFadeTerm * (softGate * (cutGate * (mainAlpha * ((vcA * _TintColor.w) * _TintColorAlpha)))), 0.0, 1.0);
                // CO-FEATURE (cutoff -> dissolve schedule): in the cutoff+dissolve permutation b193:165 the dissolve drive adds
                //   mad(_93, _CutOffAffectDissolve, ...) so the plane sweep also advances the dissolve front (_CutOffAffectDissolve =
                //   b193 _BlendTexUVWeights.y). The dissolve block (target:1160) runs BEFORE this and computes its schedule without
                //   the cutoff term; the isolated b159 has NO dissolve so this coupling is absent here. Honored as the documented
                //   cross-feature contract (see the dissolve block's note at target:1163-1165): when BOTH keywords are on, the cut
                //   plane is meant to bias the dissolve schedule by _CutOffAffectDissolve — left to the dissolve owner to avoid
                //   recomputing the (already-consumed) dissolve drive here. Pure-cutoff opacity (the load-bearing clip) is exact above.
            #endif
            #if defined(_USE_UNDER_GROUND)
                // ----- _USE_UNDER_GROUND: below-ground reveal — scene-depth Y-plane hard gate + soft depth fade -----
                // GROUND TRUTH = vfxadvance/Sub0_Pass0_Fragment_b161.hlsl:128-143 (Keywords HG_ENABLE_MV _USE_UNDER_GROUND —
                //   the ISOLATED under-ground variant, every other feature off; vfxadvance.shader:736-738, ParamBlob 3).
                //   Diffed against the airwall-only sibling b157 (HG_ENABLE_MV _USE_AIRWALL): the BASE MainTex sample, the
                //   /postExposure rgb numerator (b161:145-148 _503/_505/_506 == plain base, NO additive term), the
                //   SV_Target.xyz grade (b161:150-153), and the SV_Target_1 motion-vector tail (b161:154,161-163) are all
                //   byte-identical to base — UNDER_GROUND touches ALPHA ONLY (two extra multipliers folded into the inner
                //   alpha product, exactly like Edge/Cut/Airwall). No rgb, no texture, no SV_Target_1 change.
                //
                // b161 SSA slot-aliasing decoded by usage (STYLE_BIBLE §0/§2 — the compiled permutation packs the two
                //   under-ground scalars onto the stale _MaskTexUVSpeed cbuffer slots c13.x/c13.y; each de-aliased onto the
                //   real property the shaderlab exposes, vfxadvance.shader:139-141):
                //     _MaskTexUVSpeed.x (c13.x) = _UnderGroundPlaneYOffset  ("地面平面Y高度偏移", added to the scene-vs-object Y delta)
                //     _MaskTexUVSpeed.y (c13.y) = _UnderGroundFadeDistance  ("地面下的渐变距离" =1, the soft-fade depth divisor)
                //   PROOF of role: c13.x appears ONLY as the additive Y-plane bias inside the `<= 0` step (b161:142 _482 gate),
                //   and c13.y appears ONLY as the divisor of the (sceneViewZ - fragViewZ) soft ramp (b161:141 _473) — the exact
                //   semantics of a ground-plane height offset and an under-ground fade distance.
                //
                // Reconstruct the SCENE surface from the camera depth buffer at this pixel. b161 reads the HGRP camera depth
                //   T0.SampleLevel(sampler_LinearClamp, gl_FragCoord.xy*_ScreenSize.zw, 0).x (b161:128-131 _255/_256/_263/_265)
                //   -> URP infra-substitute SampleSceneDepth(screenUV) (STYLE_BIBLE §2 HGRP depth-global -> URP), then the SAME
                //   NDC->world via _InvViewProjMatrix (b161:139-140 _429/_431) == ReconstructWorldPos(UNITY_MATRIX_I_VP). b161's
                //   integer pixel-snap float(uint(gl_FragCoord.xy))*_ScreenSize.zw (b161:137-138 _387/_389) collapses to the shared
                //   `screenUV` here (the snap is a decompiler integer-load artifact; same convention as Edge/SoftBlend target:1379/1478).
                float undergroundSceneDeviceZ = SampleSceneDepth(screenUV);
                float3 undergroundSceneWorldPos = ReconstructWorldPos(screenUV, undergroundSceneDeviceZ); // (b161:139-140 _429/_431 -> .y = sceneWorldPos.y)
                float undergroundSceneViewZ = ViewSpaceZAbs(undergroundSceneWorldPos);                    // (b161:141 inner abs(mul(_ViewMatrix, sceneWorldPos).z))
                // Soft depth fade: clamp((sceneViewZ - fragViewZ)/_UnderGroundFadeDistance + 1, 0, 1), squared into alpha.
                //   (b161:141 _473 = clamp((-abs(_331) + abs(sceneViewZ))/_MaskTexUVSpeed.y + 1, 0, 1); b161:142 alpha *= _473*_473).
                //   fragViewZ == BASE viewZ (target:929 == b161 _332; both reconstruct the fragment's own |view-Z| identically).
                //   The explicit -viewZ + sceneViewZ mirrors the blob's abs/abs (redundant since both are already abs'd; kept 1:1,
                //   same as the SoftBlend block note target:1382-1383).
                float undergroundFade = clamp((((-0.0) - viewZ) + undergroundSceneViewZ) / _UnderGroundFadeDistance + 1.0, 0.0, 1.0);
                // Hard gate: step(sceneWorldY - objectOriginY + _UnderGroundPlaneYOffset <= 0) -> keep ONLY where the scene
                //   surface lies below the object's ground plane (the "under-ground" half-space). (b161:142 _482 leading factor:
                //   asfloat((0 >= ((_431 - _unity_ObjectToWorld[3u].y) + _MaskTexUVSpeed.x)) ? 0xFFFFFFFF : 0) & 0x3F800000(==1.0)).
                //   objectOriginY = unity_ObjectToWorld._m13 (STYLE_BIBLE §2 _unity_ObjectToWorld[3u].y; same idiom as target:635).
                float undergroundSigned = (undergroundSceneWorldPos.y + ((-0.0) - unity_ObjectToWorld._m13)) + _UnderGroundPlaneYOffset;
                float undergroundStep = asfloat(((0.0 >= undergroundSigned) ? 0xFFFFFFFFu : 0u) & 0x3F800000u); // step(0 >= signed)
                // Fold BOTH extra multipliers (hard step + fade²) into the BASE alpha inner, under the SAME softGate * lodFade
                //   wrapper + single outer clamp[0,1] every alpha writer uses (Edge/Cut/Airwall discipline). b161:142-143 _482/_483 =
                //   clamp( ((step & 1.0) * ((mainAlpha * (vcA*_TintColor.w*_TintColorAlpha)) * softGate) * (_473*_473)) * lodFadeTerm , 0, 1 ).
                //   Rebuild with the under-ground terms INSIDE the single clamp (NOT opacity *=, which would double-clamp the
                //   already-[0,1] baseAlpha and diverge when the base product exceeds 1, e.g. _TintColorAlpha up to 10).
                opacity = clamp(lodFadeTerm * (softGate * ((undergroundStep * (undergroundFade * undergroundFade)) * (mainAlpha * ((vcA * _TintColor.w) * _TintColorAlpha)))), 0.0, 1.0);
            #endif
                // _USE_SLUDGE: the FRAGMENT stage contributes nothing — sludge is a VERTEX-stage height erosion (geometry
                //   discard), ported in vert() above (target ~793, 1:1 source Vertex_b162.hlsl:357-364). The sludge FRAGMENT
                //   blob b163 is byte-identical to the base fragment b155 (verified by isolation: same MainTex sample, same
                //   SV_Target/SV_Target_1 writes; b163's only alpha gate is the BASE _USE_MASK-family near-camera distance band,
                //   present with or without the keyword and already covered by the BASE alpha path). The fragment Texture2D count
                //   is invariant to _USE_SLUDGE (b163=1 tex == base b155) precisely BECAUSE the height texture is sampled in the
                //   VERTEX stage, not here. No fragment math to add.
                //
                // RESIDUAL (load-bearing for byte-exactness, recoverable from a material asset): the 4 sludge param VECTORS the
                //   vertex erosion consumes (decoded to _SludgeHeightTextureParams0..3, vfxadvance.shader:161-164) cannot be
                //   pinned to an absolute Params-index purely from the export — the SSA decompiler assigns DIFFERENT stale pooled
                //   alias names per ParamBlob (b162 spells them _MaskTexUVRotateMat/_MaskTexUVWeights/_BlendTex_ST; b178 spells
                //   the SAME slots _BlendTint/_BlendTexUVRotateMat/_DissolveEdgeSharp; b242 spells them _BlendTex_ST/_BlendTexUVSpeed;
                //   b196 spells them _DissolveEmissiveColor/_DissolveUVRotateMat) and the reflected packoffsets are register-allocator
                //   scrambled (no *Param* manifest exists in vfxadvance/). The erosion ALGORITHM, the world-pivot input (uv2 TEXCOORD2),
                //   the [0,ceil] clamp bounds, the .z<0.1 threshold, and the NaN clip-cull are byte-exact; only the Params1<->Params2
                //   (U-axis vs V-axis) and the within-Params3 .xzyw lane assignment carry that residual ambiguity. Ported using the
                //   b162 positional reading (Params0=pivot/ceil, Params2=U-axis, Params1=V-axis, Params3=offU.x/offV.y/sclU.z/sclV.w).
                // DONE(1:1): _USE_UNDER_GROUND ported above (b161:128-143) — scene-depth Y-plane hard gate (sceneWorldY vs
                //   unity_ObjectToWorld._m13 + _UnderGroundPlaneYOffset) * soft depth fade² (/_UnderGroundFadeDistance); alpha-only.
                // DONE(1:1): _INK_DISTORT / _INK_COLOR_DISTORT — water-ink simulation. The EFFECT-UV warp (both keywords, b167:130-149 /
                //   b165:130-155) is folded into mainUV BEFORE the main sample (target ~1184); the _INK_COLOR_DISTORT ink-color "over"
                //   composite (b165:160-189) rebuilds color/opacity right after the BASE alpha (target ~1265). World->UV via
                //   _InkSimulationWorldToUV; T1/T2 -> _InkSimulationTex/_InkSimulationColorTex (HGRP ink-sim RTs, STYLE_BIBLE §2).
                //   NOTE: type-0 "ColorDistortScene" (_InkSceneDisturbOffset, scene-grab) is a SEPARATE keyword combo not in either
                //   isolated blob (it would need _CameraOpaqueTexture); the two ported keywords warp the effect's own UV, not the scene.
            #if defined(_USE_FOG)
                // ----- _USE_FOG: camera-distance fog blend applied to the pre-grade post-exposure rgb -----
                // 1:1 source = vfxadvance Fragment_b255.hlsl:243-310 (HG_ENABLE_MV+_INK_COLOR_DISTORT+_USE_DISTURB+_USE_FOG,
                //   the minimal _USE_FOG-bearing fragment variant; HG_ENABLE_MV/_INK_COLOR_DISTORT/_USE_DISTURB are independent
                //   features, _USE_FOG is the LAST keyword applied so it owns the whole color-composite immediately before the
                //   VFX grade). In b255 the grade's rgb input is swapped from the BASE `color*opacity` (b155:133 `mad(_391,_371,…)`)
                //   to the fog-composited `_659*_1358` (b255:314 `mad(_1358,_659,…)`), i.e. fog REPLACES `color` in place exactly
                //   here — the same injection point as this stub. _659==BASE opacity, _679/_681/_682==BASE post-exposure `color`.
                //
                // The HGRP composite (b255:243-310) is the FULL aerial-perspective + height/exponential + froxel-volumetric
                //   stack, and is genuinely HOST-BOUND engine-side (STYLE_BIBLE §2 INFRA -> URP): it reads HGRP-only globals
                //   with NO URP equivalent —
                //     _AtmosphereFogParams0..5  (b255:27-32, c153-158): aerial-perspective in-scatter + extinction + phase.
                //         transmittance per ch _810/_811/_812 = exp2(_797*_AtmosphereFogParams2.xyz*log2e) (b255:244-247);
                //         Rayleigh/Mie phase _1299/_1327 (b255:306-307) feeding the 255-scaled aerial term (b255:308 inner).
                //     _ExponentialFogParams0..5 (b255:33-38, c159-164): exponential/height fog density+color (b255:274-304).
                //     _VolumetricFogParams0..4  (b255:39-43, c165-169) + Texture3D T4 froxel volume (b255:117,277): per-pixel
                //         temporally-jittered (PCG hash off _FrameCount, b255:256-263) froxel sample _1051 (b255:277), gated by
                //         `0 < _VolumetricFogParams0.z` (b255:254). URP produces NO froxel volume texture, NO atmosphere LUT,
                //         NO _FogParams of this shape -> cannot be reconstructed in URP.
                //   URP infra-substitute (STYLE_BIBLE §2; the established mapping for HGRP fog) = the same camera-distance fog
                //   blend, evaluated from URP's distance fog: MixFog == lerp(unity_FogColor, color, ComputeFogIntensity(fogFactor)).
                //   This preserves the load-bearing 1:1 BEHAVIOR _USE_FOG names — distance-graded blend of the VFX rgb toward the
                //   scene fog color, applied to the post-exposure `color` BEFORE the grade premultiply — using URP's Core.hlsl fog
                //   (FOG_* keywords via #pragma multi_compile_fog above; far -> fogFactor 0 -> full fog, near -> 1 -> unfogged).
                //   The HGRP transmittance/in-scatter/froxel terms above stay host-bound (no URP froxel/atmosphere source).
                // Fog distance == the BASE fragment view-space depth `viewZ` (target:801 ViewSpaceZAbs(worldPos)), matching b255
                //   driving fog from the FRAGMENT view distance (b255:169 _201 / :230 _618=abs(_147)) — NOT an interpolated vertex
                //   clip-Z. ComputeFogFactorZ0ToFar takes linear eye-space Z (0->far) directly (URP ShaderVariablesFunctions:326),
                //   so feed `viewZ` (already abs'd, eye-space) rather than ComputeFogFactor(positionCS.z) (that path expects raw
                //   pre-divide clip Z, only valid in the vertex stage; SV_Position.z here is z/w NDC depth).
                color = MixFog(color, ComputeFogFactorZ0ToFar(viewZ));
            #endif

                // ----- VFX color grade on ALPHA-PREMULTIPLIED rgb (BASE, Fragment_b155:131-135) -----
                // premul = color * opacity ; luma = dot(premul, Rec709) ; out = lerp(luma, premul, _VFXParams1.w) * _VFXParams1.xyz
                float3 premul = color * opacity;
                float luma = dot(premul, LUM);
                float negLuma = (-0.0) - luma;
                float3 graded;
                graded.x = mad(_VFXParams1.w, premul.x + negLuma, luma) * _VFXParams1.x;
                graded.y = mad(_VFXParams1.w, premul.y + negLuma, luma) * _VFXParams1.y;
                graded.z = mad(_VFXParams1.w, premul.z + negLuma, luma) * _VFXParams1.z;

                // ----- Output alpha (BASE, Fragment_b155:136): (1 - _BlendMode) * alpha -----
                // Additive (_BlendMode=1) -> dst-alpha contribution 0; Alpha (_BlendMode=0) -> alpha kept.
                float outAlpha = (1.0 + ((-0.0) - _BlendMode)) * opacity;
                // Opaque surface writes 1 (STYLE_BIBLE §6); transparent keeps blended alpha.
                outAlpha = (_SurfaceType == 1.0) ? outAlpha : 1.0;

                return float4(graded, outAlpha);
            }
            ENDHLSL
        }
    }
}
