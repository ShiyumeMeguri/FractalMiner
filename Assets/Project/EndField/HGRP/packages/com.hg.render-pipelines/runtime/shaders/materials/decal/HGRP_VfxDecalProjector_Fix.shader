// HGRP VFX Decal Projector — single screen-space deferred decal pass (depth-reconstructed, procedural-shape-clipped, writes G-buffer color+alpha via ColorMask RA).
// Merged from: ReferenceProjects/RuriBeyondShader/.../materials/decal/vfxdecalprojector.shader (HGRP fork of HDRP).
//   Base ground truth: vfxdecalprojector/Sub0_Pass0_Vertex_b6.hlsl (catch-all #else, vertex) + Sub0_Pass0_Fragment_b7.hlsl (catch-all #else, fragment).
//   Keyword deltas ported 1:1: Fragment_b9 (_USE_MAINTEX/_USE_NORMALBLEND), Fragment_b11 (_USE_BLEND/_USE_OUTLINETEX),
//   Fragment_b13 (_BOMB_PATTERN noise + point-stipple + gap-angle box outline), Fragment_b15 (_USE_MASK/_USE_DISTURB/_USE_DISTURB_TEX2),
//   Fragment_b17 (_USE_POLARUV polar UV remap).
// Keywords (exposed as shader_feature_local): _USE_MAINTEX, _USE_MASK, _USE_BLEND, _USE_OUTLINETEX, _USE_DISTURB, _USE_DISTURB_TEX2, _USE_NORMALBLEND, _BOMB_PATTERN, _PROGRESS_BAR_DECO, _USE_POLARUV.
// Kept (1:1 math): camera-depth world-position reconstruction (inverse view-proj), world->decal-object-space projection,
//   procedural shape clip via packedMisc&255 (0=box |xyz|<.5, 1=disc XZ radius<.5 + Y slab, 2=SECTOR atan2-angle band, 3=sphere radius3D<.5),
//   gradient fill (radius2D / radius3D / height forms, decompiler smoothstep s*s*(3-2s)),
//   progress-bar ring + progress-outer-outline (uvTilingOffset.zw = progress begin/end fractions; sector form uses the shared tangent-arc edge field),
//   effect-outline (inner shape vs sector arc), main outline ring at radius .5, height fade, packed vertex color (RGB bytes + intensity + alpha byte),
//   exposure divide, premultiplied-alpha decal output, ColorMask RA G-buffer write semantics.
// Texture-stack deltas (now CLOSED, folded into the vertex-color base term per b9/b11/b15, not post-composite):
//   _USE_MAINTEX  = sample _MainTex (rotate-about-.5 + scroll + box-stretch-by-sclZ), albedo + alpha-as-r (b9:312-333).
//   _USE_MASK     = sample _MaskTex, alpha-as-r term multiplies the vertex-color factor (b15:358-378).
//   _USE_BLEND    = sample _BlendTex, weight=saturate((vcA*mainA*maskA + blend.a)*_BlendTint.w), += weight*blend.rgb*_BlendTint (b11:331-348/b15:379-381).
//   _USE_DISTURB(_TEX2) = sample _DisturbTex1(/2), offset = mad(t2,intensity2, t1*intensity1) added to every channel UV (b15:339-345).
//   _USE_OUTLINETEX = 2nd ring on _OutlineTexWidth sampling _OutlineTex (polar/box edge UV), .x scales _OutlineColor (b11:597-720).
//   _BOMB_PATTERN  = value-noise scales _OutlineColor + point-grid floor(frac()) stipple gates alpha + gap-angle box-outline shape (b13:534-622).
//   _USE_POLARUV   = mesh-UV seed becomes (radiusXZ remap, atan2/2pi) for all texture channels (b17:328-348).
//   _USE_NORMALBLEND = final alpha *= pow(saturate(dot(decalAxisY_WS, reconstructedSurfaceNormal)), _AngleBlendFallOff) (b9:592).
// Removed (pixel-neutral pipeline infra substituted by URP or dropped): SPIRV-Cross plumbing (gl_FragCoord/SPIRV_Cross_*/static I/O),
//   spvBitfieldUExtract/SExtract polyfills (-> HLSL >>/& + asuint), discard_state bookkeeping (-> clip()),
//   ECS GPU-instancing draw array indexed by SV_InstanceID (-> URP unity_ObjectToWorld/unity_WorldToObject single-instance + per-instance feed as [HideInInspector] uniforms),
//   HGRP global cbuffer (_ViewMatrix/_InvViewProjMatrix/_ScreenSize/_unity_OrthoParams/_WorldSpaceCameraPos_Internal -> UNITY_MATRIX_V / UNITY_MATRIX_I_VP / _ScreenParams / unity_OrthoParams / _WorldSpaceCameraPos),
//   HGRP per-decal fog (Atmosphere/Exponential/Volumetric fog cbuffers + 3D froxel LUT T1 -> dropped; URP has no per-decal scattering — see gaps),
//   HG_ENABLE_MV / SV_Target1 motion-vector + responsive path (single bound target here), denormalized-float magic literals (decoded inline).
//
// NOTE: This is a SCREEN-SPACE DEFERRED DECAL, not a lit/PBR surface. It rasterizes the projector volume in
//   Cull Front / ZTest Always, reconstructs the underlying opaque surface world position from the camera depth buffer,
//   transforms it into the projector's object space, evaluates a procedural shape+pattern, and writes the decal color
//   into the G-buffer (ColorMask RA -> only .r/.a reach the bound color/blend RTs). No GetMainLight / BRDF / SH (so _core/CoreMath is intentionally NOT included).
// NOTE: per-instance feed (objectToWorld/worldToObject/uvTilingOffset/packedColor/packedColorIntensity/sectorAngle/packedMisc)
//   is HGRP ECS decal-batch data with no URP equivalent. Mapped to unity_ObjectToWorld/unity_WorldToObject (single instance)
//   + documented [HideInInspector] uniforms so the math is 1:1. uvTilingOffset.z/.w = progress begin/end.
// Texture channel legend: camera depth = URP _CameraDepthTexture (source T0). Reconstructed surface NORMAL =
//   URP _CameraNormalsTexture (DepthNormals prepass) substituting the HGRP octahedral normal G-buffer (b9:289-295 T2.Load).
//   _MainTex/_MaskTex/_BlendTex/_OutlineTex/_DisturbTex1/_DisturbTex2 = the decal multi-texture stack (all CLOSED above).
// ENGINE-SIDE gaps remaining (NOT closeable in a material shader): (a) per-instance ECS decal feed
//   (objectToWorld/worldToObject/uvTilingOffset/packedColor/packedColorIntensity/sectorAngle/packedMisc) — needs the HGRP
//   ECS decal-batch renderer / a C# ScriptableRenderFeature to fill the StructuredBuffer; mapped to single-instance uniforms here.
//   (b) decal-receiver Stencil ref (ReadMask 32) — bound by the HGRP decal system; URP has no equivalent global stencil bit.
//   (c) per-decal fog in-scattering (Atmosphere/Exponential/Volumetric froxel LUT) — needs URP's volumetric-fog render pass.

Shader "HGRP/VfxDecalProjector_Fix" {
    Properties {
        _MainProperties ("Main Properties", Float) = 0
        [Enum(Alpha, 0, Additive, 1, Premultiply, 4)] _BlendMode ("Blend Type", Float) = 0
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        _FadeHeight ("Fade By Height", Float) = 0

        [Header(Outline)]
        _Outline ("Outline Width", Range(0, 0.5)) = 0.03
        [HDR] _OutlineColor ("Outline Color", Color) = (1, 1, 1, 1)

        [Header(Progress Bar)]
        _ProgressOutline ("Progress Outer Outline Width", Range(0, 0.5)) = 0.02
        [HDR] _MainColor ("Progress Bar Color", Color) = (1, 1, 1, 1)
        [HDR] _ProgressOutlineColor ("Progress Outer Outline Color", Color) = (1, 1, 1, 1)
        [Toggle(_PROGRESS_BAR_DECO)] _ProgressBarDeco ("Progress Bar FX Texture", Float) = 0

        [Header(Gradient Effect)]
        _GradientMin ("Gradient Inner Range", Range(0, 0.5)) = 0
        _GradientMax ("Gradient Outer Range", Range(0, 0.5)) = 0.5
        [HDR] _GradientColor ("Gradient Fill Color", Color) = (1, 1, 1, 1)

        [Header(Decorative Edge Only In Sector)]
        _EffectOutline ("Effect Outline", Range(0, 0.5)) = 0
        _EffectOutlineWidth ("Effect Outline Width", Range(0, 0.5)) = 0
        [HDR] _EffectColor ("Effect Outline Color", Color) = (1, 1, 1, 1)

        [Header(Main Tex)]
        [Toggle(_USE_MAINTEX)] _UseMain ("Use Main", Float) = 0
        _MainTex ("Main Tex", 2D) = "white" {}
        [ToggleUI] _MainTexUseDisturb ("Main Tex Use Disturb", Float) = 0
        [ToggleUI] _UseMainTexAsAlpha ("Use MainTex As Alpha", Float) = 1
        [Enum(Repeat, 0, Stretch, 1)] _MainTexUVMode ("Main UV Mode (Box)", Float) = 0
        [Enum(MeshUV, 0, PolarUV, 2)] _MainSwitchUV ("Main UV Switcher", Float) = 0
        _MainTexUVSpeed ("Main UV Speed (XY:Time, ZW:Custom1.X)", Vector) = (0, 0, 0, 0)
        _MainTexUVRotate ("Main UV Rotate (Degree)", Float) = 0
        [HideInInspector] _MainTexUVRotateMat ("Main UV Rotate Mat", Vector) = (1, 0, 0, 1)

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        [ToggleUI] _MaskTexUseDisturb ("Mask Tex Use Disturb", Float) = 0
        [ToggleUI] _UseMaskTexAsAlpha ("Use MaskTex As Alpha", Float) = 1
        [Enum(Repeat, 0, Stretch, 1)] _MaskTexUVMode ("Mask UV Mode (Box)", Float) = 0
        [Enum(MeshUV, 0, PolarUV, 2)] _MaskSwitchUV ("Mask UV Switcher", Float) = 0
        _MaskTexUVSpeed ("Mask UV Speed (XY:Time)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _MaskTexUVRotateMat ("Mask UV Rotate Mat", Vector) = (1, 0, 0, 1)

        [Header(Blend)]
        [Toggle(_USE_BLEND)] _UseBlend ("Use Blend", Float) = 0
        _BlendTex ("Blend Tex", 2D) = "black" {}
        [ToggleUI] _BlendTexUseDisturb ("Blend Tex Use Disturb", Float) = 0
        [Enum(Repeat, 0, Stretch, 1)] _BlendTexUVMode ("Blend UV Mode (Box)", Float) = 0
        [Enum(MeshUV, 0, PolarUV, 2)] _BlendSwitchUV ("Blend UV Switcher", Float) = 0
        [HDR] _BlendTint ("Blend Tint", Color) = (1, 1, 1, 1)
        [HDR] _BlendTintProgressBar ("Blend Tint Progress Bar", Color) = (1, 1, 1, 1)
        _BlendTexUVSpeed ("Blend UV Speed (XY:Time)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _BlendTexUVRotateMat ("Blend UV Rotate Mat", Vector) = (1, 0, 0, 1)

        [Header(Disturb)]
        [Toggle(_USE_DISTURB)] _UseDisturb ("Use Disturb", Float) = 0
        [ToggleUI] _Bi_Disturb ("Disturb In 2 Direction", Float) = 0
        [Enum(Repeat, 0, Stretch, 1)] _DisturbTexUVMode ("Disturb UV Mode (Box)", Float) = 0
        [Enum(MeshUV, 0, PolarUV, 2)] _DisturbSwitchUV ("Disturb UV Switcher", Float) = 0
        _DisturbTex1 ("Disturb1 Tex", 2D) = "white" {}
        _DisturbUVSpeed1 ("Disturb1 UV Speed (XY:Time)", Vector) = (0, 0, 0, 0)
        _DisturbUIntensity1 ("U Intensity 1", Float) = 0
        _DisturbVIntensity1 ("V Intensity 1", Float) = 0
        [Toggle(_USE_DISTURB_TEX2)] _UseDisturb2 ("Use Disturb Tex2", Float) = 0
        _DisturbTex2 ("Disturb2 Tex", 2D) = "white" {}
        _DisturbUVSpeed2 ("Disturb2 UV Speed (XY:Time)", Vector) = (0, 0, 0, 0)
        _DisturbUIntensity2 ("U Intensity 2", Float) = 0
        _DisturbVIntensity2 ("V Intensity 2", Float) = 0

        [Header(Outline Tex)]
        [Toggle(_USE_OUTLINETEX)] _UseOutlineTex ("Use Outline Tex", Float) = 0
        _OutlineTex ("Outline Tex", 2D) = "white" {}
        _OutlineTexWidth ("Outline Tex Width", Range(0, 0.5)) = 0
        _OutlineTexUVSpeed ("Outline Tex UV Speed (XY:Time)", Vector) = (0, 0, 0, 0)

        [Header(Bomb Pattern)]
        [Toggle(_BOMB_PATTERN)] _BombPattern ("Bomb Specialized Texture", Float) = 0
        _BombPointsSpace ("Bomb Point Spacing", Range(0.01, 10)) = 1
        _BombPointSize ("Bomb Point Size", Range(0, 0.5)) = 0.1
        _BombNormalBlendFallOff ("Bomb Normal Blend FallOff", Range(0, 1)) = 0.8
        _BombOutlinePatternAngle ("Bomb Outline Gap Angle", Range(0, 90)) = 0
        _BombOutlineNoiseDensity ("Bomb Outline Noise Density", Range(0.1, 10)) = 5
        _BombOutlineNoiseAlpha ("Bomb Outline Noise Min Alpha", Range(0, 1)) = 0.3

        [Header(Normal Angle Blend)]
        [Toggle(_USE_NORMALBLEND)] _UseNormalBlend ("Use Normal Angle Blend", Float) = 0
        _AngleBlendFallOff ("Angle Blend FallOff", Range(0.1, 5)) = 1

        [Header(Polar UV)]
        [Toggle(_USE_POLARUV)] _UsePolarUV ("Use Polar UV", Float) = 0

        // --- Per-instance decal feed (HGRP ECSPerDrawArray; no URP equivalent). Single-instance mapping. ---
        // TODO(1:1): normally bound per-instance by the HGRP ECS decal renderer; exposed so the math compiles & is 1:1.
        [HideInInspector] _UVTilingOffset ("Decal UV Tiling/Offset (zw=progress begin/end)", Vector) = (1, 1, 0, 1)
        [HideInInspector] _PackedColor ("Packed Color (uint bits)", Float) = 0
        [HideInInspector] _PackedColorIntensity ("Packed Color Intensity", Float) = 1
        [HideInInspector] _SectorAngle ("Sector Angle (deg)", Float) = 0
        [HideInInspector] _PackedMisc ("Packed Misc (uint bits; &255 = shape)", Float) = 0

        // --- Render-state plumbing (driven by material editor; source had _SrcBlend/_DstBlend/_DrawOrder) ---
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _DrawOrder ("__DrawOrder", Float) = 0
    }

    SubShader {
        Tags {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
        }
        LOD 100

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

        CBUFFER_START(UnityPerMaterial)
            // Core blend / responsive / fade (source type_UnityPerMaterial, Fragment_b7 lines 62-70).
            float _BlendMode;
            float _Responsive;
            float _FadeHeight;
            float _IgnorePostExposure;
            // Gradient (Fragment_b7 lines 65-66, 102).
            float _GradientMin;
            float _GradientMax;
            float4 _GradientColor;
            // Outline / progress / effect (Fragment_b7 lines 90-105).
            float _Outline;
            float _EffectOutline;
            float _EffectOutlineWidth;
            float _ProgressOutline;
            float _OutlineTexWidth;
            float _ProgressBarDeco;
            float4 _OutlineColor;
            float4 _MainColor;
            float4 _EffectColor;
            float4 _ProgressOutlineColor;
            float4 _BlendTint;
            float4 _BlendTintProgressBar;
            // Main-tex stack scalars (Fragment_b7 lines 67-89).
            float _UseMainTexAsAlpha;
            float _UseMaskTexAsAlpha;
            float _MainTexUseDisturb;
            float _MaskTexUseDisturb;
            float _BlendTexUseDisturb;
            float _MainSwitchUV;
            float _MaskSwitchUV;
            float _BlendSwitchUV;
            float _DisturbSwitchUV;
            float _MainTexUVMode;
            float _BlendTexUVMode;
            float _MaskTexUVMode;
            float _DisturbTexUVMode;
            float4 _MainTexUVSpeed;
            float4 _MainTexUVRotateMat;
            float4 _MainTex_ST;
            float4 _MainTex_TexelSize;
            // Mask / Blend / Disturb / OutlineTex UV transforms (source type_UnityPerMaterial, b15 c22-c38 / b11 c25,c35).
            float4 _MaskTexUVSpeed;
            float4 _MaskTexUVRotateMat;
            float4 _MaskTex_ST;
            float4 _BlendTexUVSpeed;
            float4 _BlendTexUVRotateMat;
            float4 _BlendTex_ST;
            float4 _OutlineTexUVSpeed;
            float4 _OutlineTex_ST;
            float4 _DisturbUVSpeed1;
            float4 _DisturbUVSpeed2;
            float4 _DisturbTex1_ST;
            float4 _DisturbTex2_ST;
            // Disturb (Fragment_b7 lines 73-77).
            float _Bi_Disturb;
            float _DisturbUIntensity1;
            float _DisturbVIntensity1;
            float _DisturbUIntensity2;
            float _DisturbVIntensity2;
            // Bomb pattern (Fragment_b7 lines 71-98).
            float _BombOutlineNoiseDensity;
            float _BombOutlineNoiseAlpha;
            float _BombPointsSpace;
            float _BombPointSize;
            float _BombNormalBlendFallOff;
            float _BombOutlinePatternAngle;
            // Normal angle blend (Fragment_b7 line 69).
            float _AngleBlendFallOff;
            // Exposure (source _ExposureParams.x is an HGRP global; URP has none -> material Vector).
            float4 _ExposureParams;
            // Per-instance decal feed (source ECSPerDrawArray; single-instance).
            float4 _UVTilingOffset;
            float _PackedColor;
            float _PackedColorIntensity;
            float _SectorAngle;
            float _PackedMisc;
        CBUFFER_END

        TEXTURE2D(_MainTex);     SAMPLER(sampler_MainTex);
        TEXTURE2D(_MaskTex);     SAMPLER(sampler_MaskTex);     // source T2 (_USE_MASK), sampler_LinearMirrorOnce
        TEXTURE2D(_BlendTex);    SAMPLER(sampler_BlendTex);    // source T3 (_USE_BLEND), sampler_PointClamp
        TEXTURE2D(_OutlineTex);  SAMPLER(sampler_OutlineTex);  // source T2 (_USE_OUTLINETEX), sampler_LinearMirrorOnce
        TEXTURE2D(_DisturbTex1); SAMPLER(sampler_DisturbTex1); // source T4 (_USE_DISTURB), sampler_PointRepeat
        TEXTURE2D(_DisturbTex2); SAMPLER(sampler_DisturbTex2); // source T5 (_USE_DISTURB_TEX2), sampler_PointMirror
        // Screen-space camera normals for _USE_NORMALBLEND (source T1/T2 .Load of the HGRP normal G-buffer -> URP DepthNormals prepass).
        TEXTURE2D(_CameraNormalsTexture); SAMPLER(sampler_CameraNormalsTexture);

        // ---- magic-constant decodes (cites against Fragment_b7) ----
        static const float INV_255  = 0.0039215688593685626983642578125; // 1/255            (b7:281)
        static const float DEG2RAD  = 0.01745329238474369049072265625;   // pi/180           (b7:330)
        static const float RAD2DEG  = 57.295780181884765625;             // 180/pi           (b7:254)
        static const float HALF_PI  = 1.57079637050628662109375;         // pi/2             (b7:250)
        static const float NEG_PI   = -3.1415927410125732421875;         // asfloat(3226013659u) = -pi (b7:250)

        // Decompiler smoothstep: s*s*(3-2s) on a saturated argument. (b7:290 _551 etc.)
        float SmoothStep01(float t)
        {
            float s = saturate(t);
            return (s * s) * mad(s, -2.0, 3.0);
        }

        // atan2(y, x) reconstructed exactly as the decompiler (radians, (-pi, pi]).
        // In the source swizzle y plays localZ (_184) and x plays localX (_183). (b7:247-253)
        float Atan2Src(float y, float x)
        {
            float t  = (1.0 / max(abs(y), abs(x))) * min(abs(y), abs(x));          // b7:247
            float t2 = t * t;                                                       // b7:248
            float poly = mad(t2, mad(t2, mad(t2, mad(t2,
                          0.02083509974181652069091796875, -0.08513300120830535888671875),
                          0.1801410019397735595703125), -0.33029949665069580078125),
                          0.999866008758544921875);                                 // b7:249
            // b7:250 sign mask = (localX<0 ? -pi : 0). localX is the decompiler's _183 = our 'x'. (fixed: was testing y)
            float signTerm = (x < 0.0) ? NEG_PI : 0.0;                              // b7:250 (asfloat((_183<-_183) & 3226013659u))
            // b7:250 EXACT order: t*poly + ((|x|<|y|) ? (pi/2 - 2*t*poly) : 0). The decompiler adds t*poly
            // UNCONDITIONALLY then adds the reciprocal-branch fixup; collapsing to a 2-way select dropped the
            // leading t*poly in the |x|<|y| branch (gave pi/2 - 2*t*poly instead of pi/2 - t*poly). Restore source form.
            float quad = mad(t, poly, ((abs(x) < abs(y)) ? mad(poly * t, -2.0, HALF_PI) : 0.0)); // b7:250
            float ang = signTerm + quad;
            if ((min(y, x) < 0.0) && (max(y, x) >= 0.0)) ang = -ang;                // b7:253 (_271)
            return ang;
        }

        // angle of (localX, localZ) in DEGREES, wrapped to [0,360). (b7:254 _280)
        float SectorAngleDeg(float localX, float localZ)
        {
            float ang = Atan2Src(localZ, localX);
            return (ang < 0.0) ? mad(ang, RAD2DEG, 360.0) : (ang * RAD2DEG);
        }

        // ----------------------------------------------------------------------------
        // Shared SECTOR tangent-arc edge field. This single helper IS the algorithm the decompiler emits
        // THREE times byte-identically — for the progress outline (b7:325-355, width=_ProgressOutline),
        // the effect outline (b7:442-468, width=_EffectOutlineWidth) and the main outline (b7:515-543,
        // width=_Outline) — differing ONLY in the 'width' input and the outer/inner ellipse masks passed in.
        // It computes the two angular sector edges (at +/- sectorAngle/2 around the +90deg axis), builds a
        // tangent-line distance smoothstep for each, AABB-tests the pixel against the quadrant the edge lives in,
        // and ANDs with the inner/outer radial masks. 'sclX'=world X-scale (objectToWorld col0 len, _446);
        // 'sclZ'=world Z-scale (objectToWorld col2 len, _478). The second planar coord 'ly' MUST be the decal-space
        // Z (source _184 = localZ), NOT localY — callers pass lz.
        // Returns 1 when the pixel is inside the (sector ∩ ring) band, else 0 ; OR 1 when width==0 (no outline).
        // ----------------------------------------------------------------------------
        float SectorArcField(float lx, float ly, float sclX, float sclZ, float width, float sectorAngle, bool outerMask, bool innerMask)
        {
            // b7:327-329 : the two edge angles (deg). edgeB = sectorAngle/2 + 90 ; edgeA = (sectorAngle>=180) ? (-sectorAngle/2+450) : (-sectorAngle/2+90).
            float negS  = -sectorAngle;                                                  // _874
            float edgeA = (sectorAngle >= 180.0) ? mad(negS, 0.5, 450.0) : mad(negS, 0.5, 90.0); // _879 (as angle)
            float edgeB = mad(sectorAngle, 0.5, 90.0);                                   // _884

            // --- edge B tangent test (b7:329-343) ---
            float radB = edgeB * DEG2RAD;        // _885
            float cB   = cos(radB);              // _888
            float tanB = sin(radB) / cB;         // _889
            // quadrant AABB gates (b7:333-338). Note _896 uses width too.
            bool gW   = ly >= ((-width) / sclZ); // _896
            bool gxP  = lx >= 0.0;               // _899
            bool gyP  = ly >= 0.0;               // _900
            bool gxLe = (width / sclX) >= lx;    // _902 = (_645 >= _183) ; _645 = _ProgressOutline/_446 = width/sclX (fixed: was sclZ)
            bool gyLe = (width / sclZ) >= ly;    // _904 (_649 = width/sclZ)
            bool gx0  = 0.0 >= lx;               // _906
            float distB = (width / cB) / sclZ;   // _911
            float interB = mad(tanB, lx, -distB);// _913
            float uB = clamp((1.0 / mad(tanB, lx, -interB)) * (ly - interB), 0.0, 1.0); // _920
            float vB = clamp(mad(-tanB, lx, ly) * (1.0 / distB), 0.0, 1.0);             // _927
            float ssB = mad(mad(uB, -2.0, 3.0), uB * uB, -((vB * vB) * mad(vB, -2.0, 3.0))); // _932 (smoothstep difference)

            // --- edge A tangent test (b7:344-351) ---
            float radA = edgeA * DEG2RAD;        // _934
            float cA   = cos(radA);              // _936
            float tanA = sin(radA) / cA;         // _937
            float distA = (width / cA) / sclZ;   // _942
            float interA = mad(tanA, lx, -distA);// _944
            float uA = clamp((1.0 / mad(tanA, lx, -interA)) * (ly - interA), 0.0, 1.0);  // _951
            float vA = clamp((1.0 / distA) * mad(-tanA, lx, ly), 0.0, 1.0);              // _957
            float ssA = mad(mad(uA, -2.0, 3.0), uA * uA, -((vA * vA) * mad(vA, -2.0, 3.0))); // _963

            // edge-A quadrant select (b7:354 first group, evaluated against edgeA). 1.0 when the pixel's
            // quadrant matches the edge's angular octant, else 0. Mirrors the nested mask in the blob.
            bool selA = (gxP  && gyLe && (270.0 < edgeA) && (edgeA < 360.0))
                     || (gW   && gxP  && (edgeA >= 0.0)   && (90.0  >= edgeA))
                     || (gxLe && gyP  && (180.0 >= edgeA) && (90.0  < edgeA))
                     || (gx0  && gyLe && (270.0 >= edgeA) && (180.0 < edgeA));
            float fA = selA ? 1.0 : 0.0;
            // term must be ==0 to keep pixel: ((ssA/(25-24*ssA)) * fA) == 0  (b7:354)
            bool keepA = ((ssA / mad(ssA, -24.0, 25.0)) * fA) == 0.0;

            // edge-B quadrant select (b7:354 second group, against edgeB).
            bool selB = (gxP  && gyLe && (270.0 < edgeB) && (edgeB < 360.0))
                     || (gW   && gxP  && (edgeB >= 0.0)   && (90.0  >= edgeB))
                     || (gxLe && gyP  && (180.0 >= edgeB) && (90.0  < edgeB))
                     || (gx0  && gyLe && (270.0 >= edgeB) && (180.0 < edgeB));
            float fB = selB ? 1.0 : 0.0;
            bool keepB = ((ssB / mad(ssB, -24.0, 25.0)) * fB) == 0.0;

            // b7:354 : (keepA && keepB) AND outer AND inner radial masks ; b7:355 : OR width==0.
            bool inBand = keepA && keepB && outerMask && innerMask;
            return (inBand || (width == 0.0)) ? 1.0 : 0.0;
        }

        // ============================================================================
        // Texture-stack UV helpers (shared by _USE_MAINTEX/_USE_MASK/_USE_BLEND/_USE_DISTURB stack).
        // The source builds, per textured channel, the SAME UV transform (decompiled in b9:312-314,
        // b11:323-324/331-332, b15:346-347/358-360/379-380): rotate the [meshU,meshV] about 0.5 by the
        // channel's 2x2 _XxxTexUVRotateMat, scroll by _XxxTexUVSpeed.xy * time (time = source _VFXParams0.w
        // -> URP _Time.y), apply *_ST.xy + _ST.zw, and — ONLY when the box (shapeMode==0) is NOT a procedural
        // shape (_217==0) AND the channel UV mode is Repeat (_XxxTexUVMode==0) — STRETCH the V by the world
        // Z-scale sclZ (decompiler '_543 * uv', i.e. _526 in b9). For procedural shapes / Stretch mode the raw
        // rotated-scrolled V is used. 'meshUV' carries the chosen mesh-or-polar planar coords (.x=U seed, .y=V seed).
        // ============================================================================
        float2 DecalChannelUV(float2 meshUV, float2 rotMatRow0, float2 rotMatRow1, float4 speed, float4 st,
                              float2 disturbOff, float useDisturb, bool isProcShape, bool uvModeStretch, float sclZ)
        {
            float time = _Time.y;                                                     // source _VFXParams0.w
            float2 c = float2(mad(speed.x, time, meshUV.x) - 0.5, mad(speed.y, time, meshUV.y) - 0.5);
            // 2x2 rotate about 0.5 (rows are .x/.z then .y/.w of the RotateMat, per b9:312-314 ordering).
            float uRot = mad(c.x, rotMatRow0.x, c.y * rotMatRow0.y) + 0.5;            // row uses _Mat.x,_Mat.z
            float vRot = mad(c.x, rotMatRow1.x, c.y * rotMatRow1.y) + 0.5;            // row uses _Mat.y,_Mat.w
            float u = mad(uRot, st.x, st.z);                                          // *_ST.xy + _ST.zw (U)
            float vBase = mad(vRot, st.y, st.w);                                      // (V before stretch)
            // V stretch select (b9:314 / b15:347): proc-shape -> raw ; box+Repeat -> sclZ*vBase ; box+Stretch -> vBase.
            float v = (isProcShape || uvModeStretch) ? vBase : (sclZ * vBase);
            // disturb offset folded into BOTH axes, gated by the channel's UseDisturb scalar (b15:347 mad(_727,_MainTexUseDisturb,..)).
            return float2(mad(disturbOff.x, useDisturb, u), mad(disturbOff.y, useDisturb, v));
        }

        // Value-noise hash (b13:596): frac(sin(dot(sign(p)*frac(|p|)*1024, (12.9898,78.233))) * 43758.546875).
        // The blob takes the signed-frac of each lattice coordinate before the dot (preserves the cell sign).
        float ValueHash2(float px, float py)
        {
            float fpx = frac(abs(px));
            float fpy = frac(abs(py));
            float sx = ((px >= -px) ? fpx : -fpx) * 1024.0;   // sign-preserved frac (b13 _1730/_1721 select)
            float sy = ((py >= -py) ? fpy : -fpy) * 1024.0;
            return frac(sin(dot(float2(sx, sy), float2(12.98980045318603515625, 78.233001708984375))) * 43758.546875);
        }

        // Disturb offset pair (b15:339-345). disturbA -> mainUV/blendUV axes (_727/_728 == _725/_726 byte-identical),
        // returns float2(uOff,vOff). Samples _DisturbTex1 (.x) and optionally _DisturbTex2 (.x) at their own scrolled UVs.
        // '_Bi_Disturb' remaps the [0,1] sample to [-1,1]-ish via mad(s, 1+bi, -bi). When TEX2 absent, d2 term = 0.
        float2 DisturbOffset(float2 meshUVseed, float sclZ, bool isProcShape, bool disturbStretch)
        {
            float bi = _Bi_Disturb;
            float time = _Time.y;
            // disturb tex1 UV: scroll seed by _DisturbUVSpeed1.xy then *_ST ; V stretch by sclZ when box+Repeat (b15:340).
            float d1u = mad(mad(_DisturbUVSpeed1.x, time, meshUVseed.x), _DisturbTex1_ST.x, _DisturbTex1_ST.z);
            float d1vBase = mad(mad(_DisturbUVSpeed1.y, time, meshUVseed.y), _DisturbTex1_ST.y, _DisturbTex1_ST.w);
            float d1v = (isProcShape || disturbStretch) ? d1vBase : (sclZ * d1vBase);
            float s1 = SAMPLE_TEXTURE2D_BIAS(_DisturbTex1, sampler_DisturbTex1, float2(d1u, d1v), 0.0).x;
            float t1 = mad(s1, 1.0 + bi, -bi);                                        // _698 = mad(sample, _693, -_Bi_Disturb)
            float t2 = 0.0;
            #ifdef _USE_DISTURB_TEX2
                float d2u = mad(mad(_DisturbUVSpeed2.x, time, meshUVseed.x), _DisturbTex2_ST.x, _DisturbTex2_ST.z);
                float d2v = mad(mad(_DisturbUVSpeed2.y, time, meshUVseed.y), _DisturbTex2_ST.y, _DisturbTex2_ST.w);
                float s2 = SAMPLE_TEXTURE2D_BIAS(_DisturbTex2, sampler_DisturbTex2, float2(d2u, d2v), 0.0).x;
                t2 = mad(s2, 1.0 + bi, -bi);                                          // _720
            #endif
            // _725 = mad(t2,_DisturbUIntensity2, t1*_DisturbUIntensity1) ; _726 = same with V intensities.
            float uOff = mad(t2, _DisturbUIntensity2, t1 * _DisturbUIntensity1);
            float vOff = mad(t2, _DisturbVIntensity2, t1 * _DisturbVIntensity1);
            return float2(uOff, vOff);
        }
        ENDHLSL

        Pass {
            Name "ForwardDecal"
            // Source render-state (vfxdecalprojector.shader lines 104-117): a second MRT (Blend 1 One One) plus
            // ColorMask RA select which G-buffer channels the decal writes. URP single-target approximation keeps the
            // first MRT's blend + ColorMask RA; ZClip On / ZTest Always / ZWrite Off / Cull Front preserved 1:1.
            Blend [_SrcBlend] [_DstBlend], [_SrcBlend] [_DstBlend]
            ColorMask RA
            ZClip On
            ZTest Always
            ZWrite Off
            Cull Front
            // Source Stencil { ReadMask 32  Comp Equal  Pass/Fail/ZFail Keep } = HGRP decal-receiver bit.
            // TODO(1:1): _StencilRef (decal-layer/receiver mask) is bound by the HGRP decal system; URP has no
            //   equivalent global. Omitted (binding Ref=unset here would reject every pixel). See gaps.

            Tags { "LightMode" = "SRPDefaultUnlit" }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_MAINTEX
            #pragma shader_feature_local _USE_NORMALBLEND
            #pragma shader_feature_local _USE_OUTLINETEX
            #pragma shader_feature_local _USE_BLEND
            #pragma shader_feature_local _BOMB_PATTERN
            #pragma shader_feature_local _USE_MASK
            #pragma shader_feature_local _USE_DISTURB
            #pragma shader_feature_local _USE_DISTURB_TEX2
            #pragma shader_feature_local _PROGRESS_BAR_DECO
            #pragma shader_feature_local _USE_POLARUV

            struct Attributes
            {
                float3 positionOS : POSITION;
            };

            struct Varyings
            {
                float4 positionCS  : SV_POSITION;
                nointerpolation uint shapeMode : TEXCOORD0; // packedMisc & 255 (source nointerpolation TEXCOORD_3 use)
            };

            // ============================================================
            // Vertex: rasterize the projector volume so the fragment depth-reconstruction runs over its screen footprint.
            // Source (Vertex_b6 lines 122-161) additionally bakes a custom disc/sector vertex deformation driven by CB1
            // global arrays + ECS worldToObject offsets (HGRP ECS-decal-specific procedural mesh, no URP feed). We
            // rasterize the projector mesh straight through object->world->clip; the real per-pixel work (the procedural
            // shape evaluated from reconstructed depth) is 1:1 in the fragment. (Documented in gaps.)
            // ============================================================
            Varyings vert(Attributes input)
            {
                Varyings o = (Varyings)0;
                float3 posWS = TransformObjectToWorld(input.positionOS);
                o.positionCS = TransformWorldToHClip(posWS);
                o.shapeMode  = 255u & asuint(_PackedMisc);
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                uint shapeMode = input.shapeMode;

                // ===== Reconstruct world position of the underlying opaque surface from depth (b7:213-228). =====
                // Source: NDC from gl_FragCoord, inv-view-proj * (ndc, sampledDepth). T0 = camera depth, point-sampled.
                // input.positionCS.xy here = pixel coordinates (SV_POSITION in a fragment delivers screen-space xy).
                float2 screenUV = input.positionCS.xy * rcp(_ScreenParams.xy); // pixel-center (raster already added .5)
                float rawDepth  = SampleSceneDepth(screenUV);              // T0.SampleLevel(LinearClamp,...).x (b7:223)
                float ndcX = mad(screenUV.x, 2.0, -1.0);                   // b7:215
                float ndcY = -mad(screenUV.y, 2.0, -1.0);                  // b7:216
                float4 worldH = mul(UNITY_MATRIX_I_VP, float4(ndcX, ndcY, rawDepth, 1.0)); // b7:217-228
                float3 surfaceWS = worldH.xyz / worldH.w;

                // Reconstructed surface normal (used by _USE_NORMALBLEND + _BOMB_PATTERN point-stipple).
                // Source octahedral-decodes the HGRP normal G-buffer (b9:289-295 T2.Load -> _451/_428/_453). URP's
                // DepthNormals prepass stores world-space normals directly, so we sample _CameraNormalsTexture (INFRA sub).
                float3 decalNormalRecon = float3(0.0, 1.0, 0.0);
                #if defined(_USE_NORMALBLEND) || defined(_BOMB_PATTERN)
                    decalNormalRecon = SAMPLE_TEXTURE2D(_CameraNormalsTexture, sampler_CameraNormalsTexture, screenUV).xyz;
                #endif

                // ===== World -> decal object space (b7:230-232: worldToObject * surfaceWS). =====
                float3 localP = mul(unity_WorldToObject, float4(surfaceWS, 1.0)).xyz;
                float lx = localP.x;
                float ly = localP.y;
                float lz = localP.z;

                float radiusXZ = sqrt(dot(float2(lx, lz), float2(lx, lz)));            // _205 (b7:236)
                float radius3D = sqrt(dot(float3(lx, ly, lz), float3(lx, ly, lz)));    // _213 (b7:238)

                bool isSphere = (shapeMode == 3u); // _214
                bool isDisc   = (shapeMode == 1u); // _216
                bool isSector = (shapeMode == 2u); // _217

                bool yLo = (-0.5) < ly;   // _199
                bool yHi = ly < 0.5;      // _201
                bool xLo = (-0.5) < lx;
                bool xHi = lx < 0.5;
                bool zLo = (-0.5) < lz;
                bool zHi = lz < 0.5;
                bool discXZ = radiusXZ < 0.5;
                bool inDiscSlab = yLo && yHi && discXZ; // _209

                // ===== Primary shape membership -> clip (b7:244-262). =====
                float shapeMask;
                if (isSector)
                {
                    float deg = SectorAngleDeg(lx, lz);                  // _280
                    float negSector = -_SectorAngle;                     // _293
                    bool wrapHi  = (deg < 360.0) && (deg >= mad(negSector, 0.5, 450.0));        // b7:256 grp1
                    bool mainArc = (mad(_SectorAngle, 0.5, 90.0) >= deg) && (deg >= mad(negSector, 0.5, 90.0)); // b7:256 grp2
                    shapeMask = ((wrapHi || mainArc) && inDiscSlab) ? 1.0 : 0.0;
                }
                else
                {
                    bool box = zLo && yLo && xLo && zHi && yHi && xHi;   // b7:260 last group
                    shapeMask = isSphere ? (radius3D < 0.5 ? 1.0 : 0.0)
                              : (isDisc   ? (inDiscSlab ? 1.0 : 0.0)
                              : ((shapeMode != 0u) ? 1.0 : (box ? 1.0 : 0.0)));
                }
                clip(shapeMask > 0.0 ? 1.0 : -1.0); // discard when NOT inside (b7:262)

                // world per-axis scale = objectToWorld column lengths (b7:446,477,478).
                float sclX = length(float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20)); // _446
                float sclY = length(float3(unity_ObjectToWorld._m01, unity_ObjectToWorld._m11, unity_ObjectToWorld._m21)); // _477
                float sclZ = length(float3(unity_ObjectToWorld._m02, unity_ObjectToWorld._m12, unity_ObjectToWorld._m22)); // _478

                // ===== Packed vertex color (b7:281-287). =====
                uint pc = asuint(_PackedColor);
                float vcR = (float(255u & pc) * INV_255) * _PackedColorIntensity;        // _492
                float vcG = (float((pc >> 8u)  & 255u) * INV_255) * _PackedColorIntensity; // _520
                float vcB = (float((pc >> 16u) & 255u) * INV_255) * _PackedColorIntensity; // _521
                float vcA = float(pc >> 24u) * INV_255;                                    // _529
                bool discOrSector = isSector || isDisc;                                    // _530

                // ===== Gradient fill, 3 forms (b7:288-300). =====
                float invGrad = 1.0 / (_GradientMin - _GradientMax);                       // _545
                float gradRad2D = SmoothStep01(invGrad * (radiusXZ - _GradientMax));       // _551
                float gradRad3D = SmoothStep01(invGrad * (radius3D - _GradientMax));       // _573
                float gMax2 = mad(_GradientMax, 2.0, -0.5);                                // _588
                float gradHeight = SmoothStep01((lz - gMax2) * (1.0 / (mad(_GradientMin, 2.0, -0.5) - gMax2))); // _602 (b7:294 uses _184=localZ, NOT localY)
                float gradT = discOrSector ? gradRad2D : (isSphere ? gradRad3D : gradHeight); // b7:296-300

                // progress begin/end fractions (b7:309-314 use uvTilingOffset.z/.w). Hoisted above the texture
                // stack because the PolarUV / procedural-shape U remap divides by progBegin (b15:328 _603).
                float progBegin = _UVTilingOffset.z;
                float progEnd   = _UVTilingOffset.w;

                // ===== Texture stack (main/mask/blend/disturb), folded into the vertex-color base term.
                // Source folds these INTO baseColor (b9:330-333 maintex; b11:345-348 +blend; b15:396-398 +mask),
                // NOT as a post-composite multiply. Mesh-UV seed = (localX+0.5, localZ+0.5) (b9:312 _191+0.5,_192+0.5).
                // Procedural-shape (shapeMode!=0 -> _217) and PolarUV remap the seed (b15:328-333 / b17:338-348). =====
                bool isProcShape = (shapeMode != 0u);                                       // _217 != 0u (shapeMode != 0)
                // MAIN (non-progress-bar) baseColor seed = RAW mesh (localX+0.5, localZ+0.5). Verified against b9:312
                // (_191+0.5,_192+0.5 RAW, no remap) AND b15:347 (_792 sample uses _595/_596 = RAW). The progBegin
                // radial proc-remap (_619/_623 = mad(local,_603,.5)) is the PROGRESS-BAR duplicate seed (_853 -> _1455,
                // _BlendTintProgressBar) which this single-baseColor port does not compute; applying it to the MAIN seed
                // was a deviation (prior pass mis-cited b15:332-333). So NO proc-shape remap on the main seed.
                float2 meshUV = float2(lx + 0.5, lz + 0.5);                                  // _595,_596 (RAW mesh seed)
                #if defined(_USE_POLARUV)
                    // PolarUV channel seed (b17, Switch==2, non-progress path _859 via _789/_793): U = angle = _648 =
                    // (atan2(localX,localZ)+pi)/2pi ; V = _650 = 2*radiusXZ. The prior pass had U/V swapped and wrong
                    // (U=mad(lx,polarScale,.5)=the _609 progress seed, V=angle). Corrected to (angle, 2*radius).
                    float polarAngle = (Atan2Src(lx, lz) + 3.1415927410125732421875) * 0.15915493667125701904296875; // _648 = _782 (U)
                    meshUV = float2(polarAngle, radiusXZ + radiusXZ);                        // _650 = _225+_225 = 2*radiusXZ (V)
                #endif

                // disturb offset (b15:339-345); zero when _USE_DISTURB off.
                float2 disturbOff = float2(0.0, 0.0);
                #ifdef _USE_DISTURB
                    bool disturbStretch = (_DisturbTexUVMode != 0.0);
                    disturbOff = DisturbOffset(meshUV, sclZ, isProcShape, disturbStretch);
                #endif

                // mainTex alpha-term (lerp(mainTex.r,1,_UseMainTexAsAlpha)). Source folds maintex into vc via its .r
                // (alpha-term) and .w only — the maintex .rgb does NOT multiply the color (b9:330-333 _773/_776).
                float mainTexAlphaTerm = 1.0;   // _679-style ; 1.0 when no maintex (vc unchanged)
                float mainTexW_lerp = 1.0;      // mad(_UseMainTexAsAlpha, -mainTex.w+mainTex.r, mainTex.w) ; 1 default
                #ifdef _USE_MAINTEX
                    bool mainStretch = (_MainTexUVMode != 0.0);
                    float2 mUV = DecalChannelUV(meshUV, float2(_MainTexUVRotateMat.x, _MainTexUVRotateMat.z),
                                                float2(_MainTexUVRotateMat.y, _MainTexUVRotateMat.w),
                                                _MainTexUVSpeed, _MainTex_ST, disturbOff, _MainTexUseDisturb,
                                                isProcShape, mainStretch, sclZ);
                    float4 mainTex = SAMPLE_TEXTURE2D_BIAS(_MainTex, sampler_MainTex, mUV, 0.0);
                    mainTexAlphaTerm = mad(_UseMainTexAsAlpha, (1.0 - mainTex.r), mainTex.r);          // lerp(r,1,flag) (b9:330 _773 term)
                    mainTexW_lerp    = mad(_UseMainTexAsAlpha, (mainTex.r - mainTex.w), mainTex.w);    // b9:333 _776 inner
                #endif

                // mask has TWO distinct terms in the blob (b15): the RGB-color term lerp(mask.x,1,flag) (_945-form,
                // b15:396) and the ALPHA/weight term lerp(mask.w,mask.x,flag) (_960, b15:368). They are NOT the same
                // function — the prior pass collapsed both to _960 and (wrongly) used it for RGB. Both default to 1.
                float maskColorTerm = 1.0;   // b15:396 mad(_UseMaskTexAsAlpha, 1-mask.x, mask.x) = lerp(mask.x,1,flag) -> RGB
                float maskAlphaTerm = 1.0;   // b15:368 _960 mad(_UseMaskTexAsAlpha, mask.x-mask.w, mask.w) = lerp(mask.w,mask.x,flag) -> alpha/blendWeight
                #ifdef _USE_MASK
                    bool maskStretch = (_MaskTexUVMode != 0.0);
                    float2 maskUV = DecalChannelUV(meshUV, float2(_MaskTexUVRotateMat.x, _MaskTexUVRotateMat.z),
                                                   float2(_MaskTexUVRotateMat.y, _MaskTexUVRotateMat.w),
                                                   _MaskTexUVSpeed, _MaskTex_ST, disturbOff, _MaskTexUseDisturb,
                                                   isProcShape, maskStretch, sclZ);
                    float4 maskTex = SAMPLE_TEXTURE2D_BIAS(_MaskTex, sampler_MaskTex, maskUV, 1.0);
                    maskColorTerm  = mad(_UseMaskTexAsAlpha, (1.0 - maskTex.x), maskTex.x);             // b15:396 _945-form (RGB)
                    maskAlphaTerm  = mad(_UseMaskTexAsAlpha, (maskTex.x - maskTex.w), maskTex.w);       // b15:368 _960 (alpha/weight)
                #endif

                // blend tex (b11:331-348 / b15:379-381): weight = saturate((vcA*mainTexW_lerp*maskAlphaTerm + blend.w)*_BlendTint.w).
                // NOTE: blendWeight's vcA factor uses mainTexW_lerp (b15 _944 = _594*_679/_944, lerp(w,r,flag)) and the
                // ALPHA mask term maskAlphaTerm (_960), NOT the RGB color terms — verified b15:381 mad(_944,_960,blend.w).
                float3 blendAdd = float3(0.0, 0.0, 0.0);
                #ifdef _USE_BLEND
                    bool blendStretch = (_BlendTexUVMode != 0.0);
                    float2 blendUV = DecalChannelUV(meshUV, float2(_BlendTexUVRotateMat.x, _BlendTexUVRotateMat.z),
                                                    float2(_BlendTexUVRotateMat.y, _BlendTexUVRotateMat.w),
                                                    _BlendTexUVSpeed, _BlendTex_ST, disturbOff, _BlendTexUseDisturb,
                                                    isProcShape, blendStretch, sclZ);
                    float4 blendTex = SAMPLE_TEXTURE2D_BIAS(_BlendTex, sampler_BlendTex, blendUV, 1.0);
                    float blendWeight = saturate(mad(vcA * mainTexW_lerp * maskAlphaTerm, 1.0, blendTex.w) * _BlendTint.w); // b15:381 _1139
                    blendAdd = blendWeight * blendTex.rgb * _BlendTint.rgb;                            // b11:345-347 mad first arg
                #endif

                float4 baseColor;
                float vcMul = mainTexAlphaTerm * maskColorTerm;                              // vc.rgb common factor (b15:396 RGB terms)
                baseColor.x = mad(blendAdd.x, 1.0, vcR * vcMul) + _GradientColor.x * gradT;  // b15:396 (_557*term + blendAdd + grad)
                baseColor.y = mad(blendAdd.y, 1.0, vcG * vcMul) + _GradientColor.y * gradT;
                baseColor.z = mad(blendAdd.z, 1.0, vcB * vcMul) + _GradientColor.z * gradT;
                baseColor.w = vcA * mainTexW_lerp * maskAlphaTerm + _GradientColor.w * gradT; // b15:399 _1346 (_944*_960 = vcA*mainTexW_lerp*maskAlphaTerm)

                // ===== Progress / main color (b7:301-405). =====
                float4 mainOut;
                if (discOrSector)
                {
                    // ellipse radii on progress edges (b7:307-314).
                    float poR = _ProgressOutline / sclX;   // _645
                    float poZ = _ProgressOutline / sclZ;   // _649
                    float innerZ = -poR + progBegin;       // _655
                    float lx2 = lx * lx;                   // _656
                    float lz2 = lz * lz;                   // _657
                    float innerW = -poZ + progBegin;       // _663
                    float outR = poR + progEnd;            // _668
                    float outW = poZ + progEnd;            // _673
                    bool outerMask = (progEnd == 0.0) || (sqrt((lz2 / (outW * outW)) + (lx2 / (outR * outR))) > 1.0); // _688
                    bool innerMask = sqrt((lz2 / (innerW * innerW)) + (lx2 / (innerZ * innerZ))) < 1.0;               // _696

                    float progField;
                    if (isSector)
                    {
                        // shared sector tangent-arc edge field, width=_ProgressOutline (b7:325-355).
                        // 2nd arg = lz (source _184 = localZ), NOT ly.
                        progField = SectorArcField(lx, lz, sclX, sclZ, _ProgressOutline, _SectorAngle, outerMask, innerMask);
                    }
                    else
                    {
                        // disc progress = ellipse ring ONLY. b7:318-321: for isDisc the branch is _799 = _688 & _696
                        // (outerMask & innerMask). The AABB 'band' at b7:359 is the else-of-if(isSector) inside
                        // discOrSector and is therefore unreachable for the base variant — do NOT AND it in.
                        progField = (outerMask && innerMask) ? 1.0 : 0.0; // b7:320
                    }

                    bool atProgress = progBegin >= radiusXZ;             // _805
                    float insideProg = atProgress ? 1.0 : 0.0;          // _808
                    bool useDeco = 0.0 != _ProgressBarDeco;             // _812
                    bool onEdge = progField != 0.0;                     // _831
                    float invInside = atProgress ? 0.0 : 1.0;           // _854
                    float4 progColor = useDeco ? float4(vcR, vcG, vcB, vcA) : _MainColor; // _812 select
                    float4 edgeColor = onEdge ? float4(0, 0, 0, 0) : _ProgressOutlineColor; // _831 select
                    mainOut = mad(edgeColor + progColor, insideProg.xxxx, invInside.xxxx * baseColor); // b7:368-371
                }
                else if (isSphere)
                {
                    bool atProg = progBegin >= radius3D;                // _705
                    float ins = atProg ? 1.0 : 0.0;                     // _709
                    float outs = atProg ? 0.0 : 1.0;                    // _711
                    mainOut = mad(_MainColor, ins.xxxx, outs.xxxx * baseColor); // b7:384-387
                }
                else
                {
                    bool atProg = mad(progBegin, 2.0, -0.5) >= lz;      // _733 (b7:391 uses _184=localZ)
                    float ins = atProg ? 1.0 : 0.0;                     // _736
                    bool useDeco = 0.0 != _ProgressBarDeco;             // _740
                    bool band2 = mad((-(_ProgressOutline / sclZ)) + progBegin, 2.0, -0.5) >= lz; // b7:394 inner test (uses _184=localZ)
                    float bandTerm = ins + (band2 ? -1.0 : -0.0);       // _776 (asfloat 3212836864u=-1, 2147483648u=-0)
                    float outs = atProg ? 0.0 : 1.0;                    // _789
                    float4 progColor = useDeco ? float4(vcR, vcG, vcB, vcA) : _MainColor; // _740 select
                    mainOut = mad(mad(_ProgressOutlineColor, bandTerm.xxxx, progColor), ins.xxxx, outs.xxxx * baseColor); // b7:396-399
                }

                // ===== Effect outline, only in sector (b7:406-483). =====
                float4 effOut = mainOut;
                if (isSector)
                {
                    float ewX = _EffectOutlineWidth / sclX; // _1092
                    float ewZ = _EffectOutlineWidth / sclZ; // _1096
                    // outer/inner masks for the effect ring (b7:416-433). For disc/sector path (discOrSector true here
                    // since isSector) it is the ellipse pair on _EffectOutline edges; sector uses the shared arc field.
                    float lx2 = lx * lx;                    // _1120
                    float lz2 = lz * lz;                    // _1121
                    float innerEffZ = -ewX + _EffectOutline; // _1119
                    float innerEffW = -ewZ + _EffectOutline; // _1126
                    float outEffZ = ewX + _UVTilingOffset.w; // _1131
                    float outEffW = ewZ + _UVTilingOffset.w; // _1136
                    bool effOuter = (_UVTilingOffset.w == 0.0) || (sqrt((lx2 / (outEffZ * outEffZ)) + (lz2 / (outEffW * outEffW))) > 1.0); // _1260
                    bool effInnerM = sqrt((lx2 / (innerEffZ * innerEffZ)) + (lz2 / (innerEffW * innerEffW))) < 1.0; // _1261
                    float effField = SectorArcField(lx, lz, sclX, sclZ, _EffectOutlineWidth, _SectorAngle, effOuter, effInnerM); // b7:442-468 (2nd arg=lz=localZ)
                    bool atEff = _EffectOutline >= radiusXZ;            // _1464
                    float effInside = atEff ? 1.0 : 0.0;
                    bool onEff = effField != 0.0;                       // _1476
                    effOut = (onEff ? float4(0, 0, 0, 0) : (effInside.xxxx * _EffectColor)) + mainOut; // b7:472-475
                }

                // ===== Main outline ring (b7:484-549). =====
                float owX = _Outline / sclX; // _1109
                float owZ = _Outline / sclZ; // _1113
                float outlineField;
                if (discOrSector)
                {
                    float lx2 = lx * lx;                 // _1198
                    float lz2 = lz * lz;                 // _1199
                    float innerOZ = -owX + 0.5;          // _1197
                    float innerOW = -owZ + 0.5;          // _1201
                    float outOZ = owX + _UVTilingOffset.w; // _1206
                    float outOW = owZ + _UVTilingOffset.w; // _1211
                    bool oOuter = (_UVTilingOffset.w == 0.0) || (sqrt((lx2 / (outOZ * outOZ)) + (lz2 / (outOW * outOW))) > 1.0); // _1264
                    bool oInner = sqrt((lx2 / (innerOZ * innerOZ)) + (lz2 / (innerOW * innerOW))) < 1.0;                          // _1265
                    if (isSector)
                        outlineField = SectorArcField(lx, lz, sclX, sclZ, _Outline, _SectorAngle, oOuter, oInner); // b7:515-543 (2nd arg=lz=localZ)
                    else
                        outlineField = (oOuter && oInner) ? 1.0 : 0.0; // disc ring (b7:510)
                }
                else
                {
                    // sphere/box outline: shell test on radius3D (b7:501-505, 547).
                    if (isSphere)
                    {
                        float innerOX = -owX + 0.5;     // _1236 (owX axis)
                        float innerOZ = -owZ + 0.5;     // _1238 (owZ axis)
                        float innerOY = -(_Outline / sclY) + 0.5; // _1244 (owY axis)
                        // b7:505 pairs _183(localX)/_1236, _184(localZ)/_1238, _185(localY)/_1244.
                        bool shell = sqrt(((lx * lx) / (innerOX * innerOX)) + ((lz * lz) / (innerOZ * innerOZ)) + ((ly * ly) / (innerOY * innerOY))) < 1.0; // _1265 sphere
                        outlineField = shell ? 1.0 : 0.0;
                    }
                    else
                    {
                        #ifdef _BOMB_PATTERN
                            // Bomb box outline = gap-angle band split into two 3D-ellipse halves (b13:523-538).
                            float owY = _Outline / sclY;                                          // _1350
                            float in05X = -owX + 0.5, in05Z = -owZ + 0.5, in05Y = -owY + 0.5;       // _1352,_1354,_1356
                            float inHX = mad(-owX, 0.5, 0.5), inHZ = mad(-owZ, 0.5, 0.5), inHY = mad(-owY, 0.5, 0.5); // _1358,_1360,_1362
                            float lx2b = lx * lx, lz2b = lz * lz, ly2b = ly * ly;                  // _1363,_1364,_1365
                            float zx = lz * lx;                                                    // _1366 (_189*_191)
                            float gapC = cos((90.0 - _BombOutlinePatternAngle) * DEG2RAD);         // _1373
                            bool gapBand = (lx < (gapC * 0.5)) && ((gapC * -0.5) < lx);            // _1380
                            bool ell3D = (abs(lx) < 0.001000000047497451305389404296875)
                                       || (sqrt((lx2b / (in05X * in05X)) + (lz2b / (in05Z * in05Z)) + (ly2b / (in05Y * in05Y))) < 1.0); // _1395
                            bool ellHalfOut = sqrt((ly2b / (inHY * inHY)) + ((lx2b / (inHX * inHX)) + (lz2b / (inHZ * inHZ)))) > 1.0;    // _1362-ellipse >1
                            bool bombBox = (gapBand && (zx < 0.0))
                                         || ((gapBand && (0.0 < zx)) ? ell3D : (ellHalfOut || ell3D)); // _1424
                            outlineField = bombBox ? 1.0 : 0.0;
                        #else
                            // box outline (b7:547): inner box of (.5 - owX/owZ) ; on-edge = outside inner box.
                            bool insideInner = ((owX + (-0.5)) < lx) && (lx < (-owX + 0.5)) && (lz < (-owZ + 0.5)) && ((owZ + (-0.5)) < lz);
                            outlineField = insideInner ? 1.0 : 0.0;
                        #endif
                    }
                }
                bool onOutline = outlineField != 0.0;        // _1506
                float outlineInside = outlineField != 0.0 ? 1.0 : 0.0; // _1504

                // progress-bar-deco gate (b7:551-554): disc/sector ellipse on uvTilingOffset.w hides interior.
                float tw2 = _UVTilingOffset.w * _UVTilingOffset.w; // _1501
                bool decoEllipse = discOrSector && (_UVTilingOffset.w != 0.0)
                                 && (sqrt((lz * lz / tw2) + (lx * lx / tw2)) < 1.0); // b7:554 uses _184=localZ + _183=localX
                float decoGate = decoEllipse ? 0.0 : 1.0;    // _1546 (0 -> hidden)

                // ===== Outline color modulators: outline-tex sample (_USE_OUTLINETEX) or bomb noise (_BOMB_PATTERN). =====
                // Both multiply _OutlineColor at the non-edge location by a scalar (b11:716-718 outlineTex.x ; b13:619-622 _1879 noise).
                float3 outlineColMod = _OutlineColor.xyz;   // default: plain outline color
                float  outlineAlphaMod = _OutlineColor.w;
                float  pointStipple = 1.0;                  // bomb point-grid alpha gate (b13:622), 1 default

                #ifdef _USE_OUTLINETEX
                {
                    // Second outline ring on _OutlineTexWidth, sampling _OutlineTex with a polar/box edge coordinate
                    // (b11:597-713). For disc/sector: U = angle/2pi (_2087), V = radial band smoothstep (_2088); for box:
                    // U = on-edge axis projection, V = 4-edge smoothstep sum. We reproduce the disc/sector + box coords.
                    float otU, otV;
                    float lx2o = lx * lx, lz2o = lz * lz;
                    if (discOrSector)
                    {
                        float otIn = (_OutlineTexWidth / sclX);                                  // _1731
                        float otInZ = (_OutlineTexWidth / sclZ);                                 // _1735
                        float innerA = -otIn + 0.5, innerB = -otInZ + 0.5;                       // _1941,_1945
                        float outA = otIn + _UVTilingOffset.w, outB = otInZ + _UVTilingOffset.w; // _1955,_1960
                        float band1 = sqrt((lz2o / (innerB * innerB)) + (lx2o / (innerA * innerA)));  // _1966
                        float tw2o = _UVTilingOffset.w * _UVTilingOffset.w;                      // _2012
                        float band2 = sqrt((lz2o / tw2o) + (lx2o / tw2o));                       // _2030
                        float sIn = clamp((1.0 - band1) * rcp((sqrt((lz2o + lx2o) * 4.0) - band1)), 0.0, 1.0);   // _2024
                        float sOut = clamp((1.0 - band2) * rcp(sqrt((lx2o / (outA * outA)) + (lz2o / (outB * outB))) - band2), 0.0, 1.0); // _2037
                        // _2087: blob ratio _199/_200 = localX/localZ -> atan2(localX, localZ) (NOT atan2(localZ,localX)).
                        otU = (Atan2Src(lx, lz) + 3.1415927410125732421875) * 0.15915493667125701904296875;     // _2087 (atan2(localX,localZ)/2pi)
                        otV = mad(mad(sIn, -2.0, 3.0), sIn * sIn, (sOut * sOut) * mad(sOut, -2.0, 3.0));          // _2088
                    }
                    else
                    {
                        // box outline-tex coordinate (b11:692-704): U = on-edge axis projection, V = 4-edge smoothstep sum.
                        float otIn = (_OutlineTexWidth / sclX);                                  // _1731
                        float otInZ = (_OutlineTexWidth / sclZ);                                 // _1735
                        float ax0 = -otIn + 0.5, ax1 = otIn - 0.5;                               // _2522,_2523
                        float az0 = -otInZ + 0.5, az1 = otInZ - 0.5;                             // _2525,_2526
                        bool ex0 = ax0 < lx, ex1 = lx < ax1;                                     // _2528,_2530
                        // denominators reduce: (-_2522+.5)=otIn ; (-_2523-.5)=-otIn ; (-_2525+.5)=otInZ ; (-_2526-.5)=-otInZ.
                        float sX0 = clamp((lx - ax0) * rcp(otIn), 0.0, 1.0);                     // _2549
                        float sX1 = clamp((lx - ax1) * rcp(-otIn), 0.0, 1.0);                    // _2562
                        float sZ0 = clamp(rcp(otInZ) * (lz - az0), 0.0, 1.0);                    // _2578
                        float sZ1 = clamp((lz - az1) * rcp(-otInZ), 0.0, 1.0);                   // _2594
                        otU = (ex1 || ex0) ? (sclZ * lz) : (sclX * lx);                          // _2097
                        float ssX1 = (sX1 * sX1) * mad(sX1, -2.0, 3.0);
                        float ssX0 = (sX0 * sX0) * mad(sX0, -2.0, 3.0);
                        float ssZ0 = (sZ0 * sZ0) * mad(sZ0, -2.0, 3.0);
                        float ssZ1 = (sZ1 * sZ1) * mad(sZ1, -2.0, 3.0);
                        otV = (ex1 ? ssX1 : 0.0) + (ex0 ? ssX0 : 0.0) + ((az0 < lz) ? ssZ0 : 0.0) + ((lz < az1) ? ssZ1 : 0.0); // _2099
                    }
                    // sample _OutlineTex with scroll (b11:713): U += speed.x*time after *_ST ; V = clamp(otV)*_ST + speed.y*time.
                    float t = _Time.y;
                    float2 otUV = float2(mad(_OutlineTexUVSpeed.x, t, mad(otU, _OutlineTex_ST.x, _OutlineTex_ST.z)),
                                         mad(_OutlineTexUVSpeed.y, t, mad(saturate(otV), _OutlineTex_ST.y, _OutlineTex_ST.w)));
                    float otSample = SAMPLE_TEXTURE2D_BIAS(_OutlineTex, sampler_OutlineTex, otUV, 0.0).x;        // _2156
                    outlineColMod   = otSample * _OutlineColor.xyz;                              // b11:716-718
                    outlineAlphaMod = otSample * _OutlineColor.w;                                // b11:720
                }
                #endif

                #ifdef _BOMB_PATTERN
                {
                    // Bomb outline noise (b13:586-617): value-noise on the reconstructed-surface XZ * _BombOutlineNoiseDensity.
                    float t = _Time.y;
                    float nX = mad(surfaceWS.x, _BombOutlineNoiseDensity, t);   // _1715 (b13 uses _142=surfWS.x via depth)
                    float nZ = mad(surfaceWS.z, _BombOutlineNoiseDensity, t);   // _1716 (b13 _144=surfWS.z)
                    float fX = floor(nX), fZ = floor(nZ);
                    float frX = frac(nX), frZ = frac(nZ);
                    float cellSize = 0.0009765625;                              // 1/1024 (b13 _1721 etc.)
                    float h00 = ValueHash2(fX * cellSize, fZ * cellSize);                          // _1747
                    float h10 = ValueHash2((fX + 1.0) * cellSize, (fZ + 0.0) * cellSize);          // _1789 (top-right used as 01 in b13)
                    float h01 = ValueHash2((fX + 0.0) * cellSize, (fZ + 1.0) * cellSize);          // _1747-pair _1754/_1755
                    float h11 = ValueHash2((fX + 1.0) * cellSize, (fZ + 1.0) * cellSize);          // _1845/_1846
                    float sx = frX * frX * mad(frX, -2.0, 3.0);                                    // _1796 (Hermite weight x)
                    float sz = frZ * frZ * mad(frZ, -2.0, 3.0);                                    // _1797 (weight z)
                    // bilinear hermite lerp of the 4 hashes (b13:617), then remap to [_BombOutlineNoiseAlpha,1].
                    float nbX0 = lerp(h00, h01, sz);                                               // along z at x0
                    float nbX1 = lerp(h10, h11, sz);                                               // along z at x1
                    float noise = lerp(nbX0, nbX1, sx);
                    float noiseA = mad(noise, 1.0 - _BombOutlineNoiseAlpha, _BombOutlineNoiseAlpha); // _1879
                    outlineColMod   = noiseA * _OutlineColor.xyz;                                  // b13:619-621
                    outlineAlphaMod = noiseA * _OutlineColor.w;
                    // bomb point-grid stipple on alpha (b13:622): per-axis floor(frac(scl*local*_BombPointsSpace)+_BombPointSize),
                    // bypassed to 1 on the axis whose normal-aligned component exceeds _BombNormalBlendFallOff.
                    float surfN = rsqrt(dot(decalNormalRecon, decalNormalRecon)); // reconstructed surface-normal len (b13 _457)
                    float pgX = (_BombNormalBlendFallOff < abs(surfN * decalNormalRecon.x)) ? 1.0 : floor(frac((sclX * lx) * _BombPointsSpace) + _BombPointSize);
                    float pgY = (_BombNormalBlendFallOff < abs(surfN * decalNormalRecon.y)) ? 1.0 : floor(frac((sclY * ly) * _BombPointsSpace) + _BombPointSize);
                    float pgZ = (_BombNormalBlendFallOff < abs(surfN * decalNormalRecon.z)) ? 1.0 : floor(frac((sclZ * lz) * _BombPointsSpace) + _BombPointSize);
                    pointStipple = pgX * pgY * pgZ;                                                // b13:622 triple product
                }
                #endif

                // ===== Composite final color (b7:555-558). =====
                float4 composed;
                composed.xyz = decoGate * mad(effOut.xyz, outlineInside.xxx, (onOutline ? float3(0,0,0) : outlineColMod));
                float heightFade = clamp(mad(sclY, 0.5, -(abs(ly) * _FadeHeight)), 0.0, 1.0); // b7:558
                composed.w = heightFade * (decoGate * pointStipple * mad(effOut.w, outlineInside, (onOutline ? 0.0 : outlineAlphaMod)));

                // ===== Normal-angle blend (_USE_NORMALBLEND): fade alpha by surface-vs-decal normal alignment. =====
                // Source (b9:592) multiplies final alpha by pow(saturate(dot(decalNormalWS, reconstructedSurfaceNormal)), _AngleBlendFallOff).
                #ifdef _USE_NORMALBLEND
                    float3 nDecal = normalize(TransformObjectToWorldDir(float3(0.0, 1.0, 0.0))); // decal projector +Y in world (b9 TEXCOORD_1)
                    float3 nSurf  = normalize(decalNormalRecon);                                 // reconstructed surface normal (b9 _451/_428/_453)
                    float ndotn = saturate(dot(nDecal, nSurf));
                    composed.w *= exp2(log2(max(ndotn, 1.175494e-38)) * _AngleBlendFallOff);      // exp2(log2(x)*k) == pow(x,k) (b9:592)
                #endif

                // ===== Exposure divide (b7:559). =====
                float exposure = mad(_IgnorePostExposure, (-1.0) + _ExposureParams.x, 1.0); // _1568
                composed.xyz /= exposure;

                // ===== Premultiplied-alpha decal output (b7:624-629, fog dropped). =====
                // SV_Target.xyz = _1559 * (color/exposure) (premultiplied by alpha) ; SV_Target.w = _1559 (PLAIN).
                // The decompiler's _2389 = (1 - _BlendMode) multiplies ONLY the in-scattered FOG-additive term in
                // RGB (b7:625-627); since fog is dropped here _2389 vanishes entirely and must NOT scale the alpha.
                // (Source b7:629: SV_Target.w = _1559, no _2389 factor.) With ColorMask RA only .r/.a reach the RTs.
                float finalAlpha = composed.w;            // _1559
                float3 outRGB = finalAlpha * composed.xyz;
                return half4(outRGB.r, outRGB.g, outRGB.b, finalAlpha);
            }
            ENDHLSL
        }
    }
}
