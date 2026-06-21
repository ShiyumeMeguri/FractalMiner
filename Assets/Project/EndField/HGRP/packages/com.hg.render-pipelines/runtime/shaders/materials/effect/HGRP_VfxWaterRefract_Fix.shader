// HGRP VFX Water Refract — screen-space refraction of the camera color buffer through a tinted,
//   optionally PBR-lit water/glass surface — single transparent "Distortion" pass.
// Merged from: vfxwaterrefract.shader (HGRP/Effect/VFXWaterRefract),
//   base blob Sub0_Pass0_Fragment_b7.hlsl + Sub0_Pass0_Vertex_b6.hlsl (the catch-all `#else` =
//   NONE of the 6 multi_compile keywords defined; the blobs' own `// Keywords: HG_ENABLE_MV` header is
//   just the keyword-namespace tag, NOT a defined keyword — HG_ENABLE_MV is the b8..b16 `#if` branches).
//   The keyword ladder (HG_ENABLE_MV / _USE_MASK / _NORMAL_MAP / _VAT_SOFTBODY / _USE_DISSOLVE /
//   SRP_INSTANCING_ON) swaps interpolator-packing / GPU-skin / instancing infra around the SAME
//   surface+refraction+lighting math; the feature deltas (mask/normal/dissolve sampling + VAT vertex
//   displace) are now ported into #ifdef branches (base `#else` blob = catch-all ground truth).
//   (b7 reads prev-frame MV regs only for the dropped SV_Target_1; see engine-side TODO below.)
// Keywords: _NORMAL_MAP, _USE_MASK, _USE_DISSOLVE, _VAT_SOFTBODY
//   (HG_ENABLE_MV + SRP_INSTANCING_ON dropped: MV MRT is engine-side; instancing not used.)
// Kept (1:1 math, cite = blob b7 line; feature deltas cite b9/b11/b8):
//   - _NORMAL_MAP: tangent-space normal map, DXT5nm unpack + _NormalScale + TBN, replaces geo normal (b9 363/376-392).
//   - _USE_MASK: mask tex, lerp(maskA,maskR,_UseMaskTexAsAlpha) into opacity + lerp(maskR,1,..) into tint (b9 368/393/396).
//   - _USE_DISSOLVE: dissolve tex soft-erode of opacity + emissive edge glow into tint (b11 404-406/411/414-416).
//   - _VAT_SOFTBODY: Houdini VAT vertex displace (sample _PositionTexture) + quaternion normal/tangent rebuild
//     (sample _RotationTexture), frame-time driven by host VAT-playback uniforms (b8 137-227).
//   - Snell's-law refraction vector through the surface normal with total-internal-reflection mask,
//     view-space-projected screen offset scaled by opacity*_RefractThickness, sampling the camera
//     opaque texture as the refracted background (b7 lines 337-345, 1272-1274).
//   - Tint color (mainTex * _TintColor * _TintColorIntensity), post-exposure de-scale, opacity
//     assembly (vertColor.a * _TintColor.a * _TintColorAlpha * near-fade * Fresnel-opacity) (b7 328-359).
//   - Indirect SH ambient (_IVDefaultSHA·N -> URP SampleSH) with _IndirectSaturation grade (b7 366-373).
//   - Direct main-light PBR: GGX-D + Smith height-correlated Vis + Schlick F, EnvBRDFApprox DFG
//     multiscatter-diffuse, 1/21 grazing floor, _DirSpecularStrength (b7 601-655) — identical spine
//     to _core/CoreMath.hlsl HgDirectLightEnergy (mirrored inline below, not #included to avoid the
//     lit-family LitSurfaceData/CBUFFER collisions).
//   - _UseLighting / _IsSceneEffect / _BlendMode (additive vs alpha) compositing, VFX saturation
//     color-grade (_VFXParams1 -> exposed _VfxColorGrade) (b7 1271-1287).
//   - Near-camera dual-band view-depth fade (b7 328 _560 _UseNearCameraFade branch).
// Removed (pixel-neutral pipeline infra substituted by URP, or HGRP-only framework with no URP analog):
//   GPU skinning + packed-octahedral vertex stream (b6 143-203), TAA jitter (_TaaJitterStrength,
//   b6 231-232 -> identity TransformWorldToHClip), HGRP global cbuffers (_ViewMatrix/_InvViewProjMatrix/
//   _NonJitteredViewNoTransProjMatrix/_WorldSpaceCameraPos_Internal/_ScreenSize/_GlobalMipBias ->
//   URP UNITY_MATRIX_V / _WorldSpaceCameraPos / _ScreenParams / mip-bias 0), GPU instancing
//   (SRP_INSTANCING_ON), LOD crossfade (_unity_LODFade, b7 328/329), the full HGRP CSM+ASM+cloud
//   shadow stack (b7 376-596 -> URP main-light shadow attenuation), the tile/Z-bin punctual-light
//   cluster (b7 664-1205 -> URP GetAdditionalLight loop), HGRP atmosphere+exp+volumetric froxel fog
//   (b7 1206-1266 -> URP MixFog), the planar-reflection reproject (b7 360-364, _GraphicsFeaturesGlobalParam1.y),
//   and the "Distortion" 2nd MRT motion-vector target (SV_Target_1, b7 1283-1285) — URP has no
//   Distortion-pass MV MRT for a custom transparent shader; left engine-side (needs a host C#
//   ScriptableRendererFeature to bind the MV MRT). See TODO(engine-side) in frag.
//
// NOTE: this samples the camera color buffer, so it requires URP Opaque Texture ON
//   (_CameraOpaqueTexture). It must render in the Transparent queue AFTER opaques.
// NOTE: _VFXParams0.w (HGRP per-particle time) is substituted by _Time.y; particle custom1 data
//   rides COLOR/UV like the source (_InParticle gates it).

Shader "HGRP/VfxWaterRefract_Fix" {
    Properties {
        [Header(Base)]
        [Enum(Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        [ToggleUI] _DisableVertColor ("Disable VertColor", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 0
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 0
        [ToggleUI] _IsSceneEffect ("Is Scene Effect (follows scene darkening)", Float) = 0
        [ToggleUI] _UseLighting ("Use Lighting", Float) = 1
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0
        [ToggleUI] _EnableTransparentMV ("Enable Transparent MV", Float) = 0

        [Header(Main Tex)]
        _MainTex ("Main Tex", 2D) = "white" {}
        [ToggleUI] _UseMainTexAsAlpha ("UseMainTexAsAlpha", Float) = 1
        _MainTexUVSpeed ("MainTexUVSpeed(XY:By Time, ZW:By Custom1.X)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _MainTexUVRotateMat ("MainTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MainUVSet ("Main UV Set", Float) = 0
        [HideInInspector] _MainTexUVWeights ("_MainTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Tint)]
        [HDR] _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity (Default 1)", Range(1, 100)) = 1
        _TintColorAlpha ("Tint Color Alpha (Default 1)", Range(0, 10)) = 1

        [Header(PBR)]
        _Roughness ("Roughness", Range(0, 1)) = 1
        _Specular ("Specular", Range(0, 1)) = 1
        _DirSpecularStrength ("Direct Specular Strength", Range(0, 10)) = 1
        _FresnelStrength ("Fresnel Strength (opacity)", Float) = 0
        [ToggleUI] _UseVertexColorAsOpacity ("Use Vertex Color As Opacity", Float) = 0
        [ToggleUI] _UseFresnelAsOpacity ("Use Fresnel As Opacity", Float) = 0
        _IndirectSaturation ("Indirect Saturation", Range(0, 1)) = 0

        [Header(Refract)]
        // NOTE: _RefractTint is declared in the source but NOT consumed by the base (#else) variant
        //   (b7 1272-1274 sample the scene color untinted). Kept for material-inspector parity only.
        _RefractTint ("Refract Tint (unused in base variant)", Color) = (1, 1, 1, 1)
        _RefractThickness ("Refract Thickness", Range(0, 1)) = 0.01
        _IoR ("IoR", Range(0, 0.5)) = 0.8
        _RefractBrightness ("Refract Brightness", Range(0, 2)) = 1
        [ToggleUI] _UseMaskTexAsAlpha ("Use Mask Tex As Alpha (refract bright gate)", Float) = 1

        [Header(Normal Map)]
        [Toggle(_NORMAL_MAP)] _EnableNormalMap ("Enable Normal Map", Float) = 0
        [Normal] _NormalMap ("Normal Map (DXT5nm)", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 3)) = 1
        _NormalMapUVSpeed ("NormalMapUVSpeed (XY:By Time, ZW:By Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _NormalMapUVRotateMat ("NormalMapUVRotateMat", Vector) = (1, 0, 0, 1)
        [HideInInspector] _NormalMapUVWeights ("_NormalMapUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Enable Mask (Alpha only)", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        _MaskTexUVSpeed ("MaskTexUVSpeed (XY:By Time, ZW:By Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _MaskTexUVRotateMat ("MaskTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [HideInInspector] _MaskTexUVWeights ("_MaskTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Dissolve)]
        [Toggle(_USE_DISSOLVE)] _UseDissolve ("Enable Dissolve", Float) = 0
        _DissolveTex ("Dissolve Tex (R=weight)", 2D) = "white" {}
        _DissolveUVSpeed ("DissolveUVSpeed (XY:By Time, ZW:By Custom1.Y)", Vector) = (0, 0, 0, 0)
        [HideInInspector] _DissolveUVRotateMat ("DissolveUVRotateMat", Vector) = (1, 0, 0, 1)
        [HideInInspector] _DissolveUVWeights ("_DissolveUVWeights", Vector) = (1, 0, 0, 0)
        _DissolveScheduleOffset ("Dissolve Schedule Offset", Range(0, 2)) = 0
        _DissolveEdgeSharp ("Dissolve Edge Sharp", Range(0.001, 100)) = 1
        _DissolveEmissiveEdge ("Dissolve Emissive Edge", Range(0, 2)) = 0
        [HDR] _DissolveEmissiveColor ("Dissolve Emissive Color", Color) = (1, 1, 1, 1)
        [ToggleUI] _UseVertexColorAlphaAsDissolveWeight ("Use VertColor Alpha As Dissolve Weight", Float) = 0
        [Enum(R, 0, G, 1, B, 2)] _DissolveVertexChannel ("Dissolve Vertex Channel", Float) = 0
        _DissolveVertexRange ("Dissolve Vertex Range", Range(-1, 1)) = 0

        [Header(Houdini VAT (SoftBody))]
        // NOTE: _PositionTexture/_RotationTexture are baked offline (Houdini VAT exporter); the frame-time / bounds
        //   uniforms below are driven by a host C# VAT playback system. The vertex displacement + normal rebuild ARE
        //   ported (b8 143-227). See _VAT_SOFTBODY vert branch.
        [Toggle(_VAT_SOFTBODY)] _EnableHoudiniVAT ("Enable Houdini VAT", Float) = 0
        _PositionTexture ("Position Texture (VAT)", 2D) = "white" {}
        _RotationTexture ("Rotation Texture (VAT)", 2D) = "white" {}
        [ToggleUI] _TextureFormat ("Texture Format (1:HDR raw, 0:LDR remap)", Float) = 1
        [ToggleUI] _B_surfaceNormals ("Use Surface Normals (VAT)", Float) = 0
        _gameTimeAtFirstFrame ("VAT Time At First Frame", Float) = 0
        _houdiniFPS ("VAT Houdini FPS", Float) = 0
        _PlaybackSpeed ("VAT Playback Speed", Float) = 1
        _frameCount ("VAT Frame Count", Float) = 0
        _boundMinX ("VAT Bound Min X", Float) = 0
        _boundMinY ("VAT Bound Min Y", Float) = 0
        _boundMinZ ("VAT Bound Min Z", Float) = 0
        _boundMaxX ("VAT Bound Max X", Float) = 0
        _boundMaxY ("VAT Bound Max Y", Float) = 0
        _boundMaxZ ("VAT Bound Max Z", Float) = 0

        [Header(Near Camera Fade)]
        _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Start 1 (disappear)", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Fade End 1 (appear)", Range(0.001, 3000)) = 10
        _NearCameraFadeDistanceEnd2 ("Fade End 2 (appear)", Range(0.002, 3000)) = 100
        _NearCameraFadeDistanceStart2 ("Fade Start 2 (disappear)", Range(0.001, 3000)) = 120

        [Header(Pipeline Params)]
        // HGRP globals re-exposed as material params (no URP global equivalent), neutral defaults.
        _ExposureParams ("ExposureParams (.x=exposure)", Vector) = (1, 0, 0, 0)
        _EnvironmentGlobalParams0 ("Env Ambient Intensity (.x)", Vector) = (1, 0, 0, 0)
        // _VFXParams1: .xyz = post tint, .w = saturation amount (1 = no desat). Source _VFXParams1.
        _VfxColorGrade ("VFX Color Grade (.xyz tint, .w saturation)", Vector) = (1, 1, 1, 1)

        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 0
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
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
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareOpaqueTexture.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Base
                float _SurfaceType;
                float _BlendMode;
                float _InParticle;
                float _DisableVertColor;
                float _IgnorePostExposure;
                float _IsSceneEffect;
                float _UseLighting;
                float _Responsive;
                float _EnableTransparentMV;
                // Main Tex
                float _UseMainTexAsAlpha;
                float4 _MainTex_ST;
                float4 _MainTexUVSpeed;
                float4 _MainTexUVRotateMat;
                float4 _MainTexUVWeights;
                // Tint
                float4 _TintColor;
                float _TintColorIntensity;
                float _TintColorAlpha;
                // PBR
                float _Roughness;
                float _Specular;
                float _DirSpecularStrength;
                float _FresnelStrength;
                float _UseVertexColorAsOpacity;
                float _UseFresnelAsOpacity;
                float _IndirectSaturation;
                // Refract
                float4 _RefractTint;
                float _RefractThickness;
                float _IoR;
                float _RefractBrightness;
                float _UseMaskTexAsAlpha;
                // Normal Map (_NORMAL_MAP)
                float _NormalScale;
                float4 _NormalMap_ST;
                float4 _NormalMapUVSpeed;
                float4 _NormalMapUVRotateMat;
                float4 _NormalMapUVWeights;
                // Mask (_USE_MASK)
                float4 _MaskTex_ST;
                float4 _MaskTexUVSpeed;
                float4 _MaskTexUVRotateMat;
                float4 _MaskTexUVWeights;
                // Dissolve (_USE_DISSOLVE)
                float4 _DissolveTex_ST;
                float4 _DissolveUVSpeed;
                float4 _DissolveUVRotateMat;
                float4 _DissolveUVWeights;
                float _DissolveScheduleOffset;
                float _DissolveEdgeSharp;
                float _DissolveEmissiveEdge;
                float4 _DissolveEmissiveColor;
                float _UseVertexColorAlphaAsDissolveWeight;
                float _DissolveVertexChannel;
                float _DissolveVertexRange;
                // Houdini VAT (_VAT_SOFTBODY) — textures baked offline, frame/bounds driven by host C# VAT playback.
                float _TextureFormat;
                float _B_surfaceNormals;
                float _gameTimeAtFirstFrame;
                float _houdiniFPS;
                float _PlaybackSpeed;
                float _frameCount;
                float _boundMinX;
                float _boundMinY;
                float _boundMinZ;
                float _boundMaxX;
                float _boundMaxY;
                float _boundMaxZ;
                // Near Camera Fade
                float _UseNearCameraFade;
                float _NearCameraFadeDistanceStart;
                float _NearCameraFadeDistanceEnd;
                float _NearCameraFadeDistanceEnd2;
                float _NearCameraFadeDistanceStart2;
                // Pipeline params (HGRP globals re-exposed)
                float4 _ExposureParams;
                float4 _EnvironmentGlobalParams0;
                float4 _VfxColorGrade;
                // Render state
                float _TransparentSortPriority;
            CBUFFER_END

            TEXTURE2D(_MainTex);          SAMPLER(sampler_MainTex);
            TEXTURE2D(_NormalMap);        SAMPLER(sampler_NormalMap);        // _NORMAL_MAP (b9 T3)
            TEXTURE2D(_MaskTex);          SAMPLER(sampler_MaskTex);          // _USE_MASK   (b9 T2)
            TEXTURE2D(_DissolveTex);      SAMPLER(sampler_DissolveTex);      // _USE_DISSOLVE (b11 T4)
            TEXTURE2D(_PositionTexture);  SAMPLER(sampler_PositionTexture);  // _VAT_SOFTBODY (b8 T1)
            TEXTURE2D(_RotationTexture);  SAMPLER(sampler_RotationTexture);  // _VAT_SOFTBODY (b8 T0)

            // VFX time driver: source reads _VFXParams0.w (HGRP per-particle time); URP uses _Time.y. (b7: _VFXParams0.w)
            #define _VFXTime (_Time.y)

            // ===== Decoded magic constants (denormalized-float bit patterns -> real values) =====
            // Rec.709 luma (b7 1267/1278): dot(c, LUM). 1:1 from CORE_MATH §0.4.
            static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625);
            static const float  EPS_VIEWLEN    = 9.9999999392252902907785028219223e-09; // 1e-8 ; view rsqrt guard (b7 309)
            static const float  EPS_HALF_RSQRT = 6.103515625e-05;                        // 2^-14 ; half-rsqrt guard (b7 612/623)
            static const float  EPS_VIS        = 9.9999997473787516355514526367188e-05;  // 1e-4 ; Smith-vis denom floor (b7 644)
            static const float  DIELECTRIC_F0  = 0.07999999821186065673828125;           // 0.08 ; dielectric F0 = 0.08*_Specular (b7 352)
            static const float  GRAZING_FLOOR  = 0.0476190485060214996337890625;         // 1/21 ; multiscatter-diffuse grazing floor (b7 640-642)

            // ===== EnvBRDFApprox DFG (Karis/Lazarov), 1:1 from CORE_MATH HgEnvBRDFApproxDFG =====
            // t=1-roughness ; min( t*(t*((-t)*0.38302600 - 0.07619470) + 1.04997003) + 0.40925499, 0.999 ). (b7 638 _1291)
            float EnvBRDFApproxDFG(float roughness)
            {
                float t = mad(roughness, -1.0, 1.0);
                return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875,
                                              -0.076194703578948974609375),
                                        1.04997003078460693359375),
                               0.4092549979686737060546875),
                           0.999000012874603271484375);
            }

            // ===== Cook-Torrance GGX-D + Smith height-correlated Vis + Schlick F. 1:1 from
            //       CORE_MATH HgDirectSpecular. Returns specular RGB (NOT yet * NoL). (b7 630-644)
            //   a=roughness^2 ; a2=a*a ; NoV'=min(NoV,1)
            //   d=(NoH*a2-NoH)*NoH+1 ; D=a2/(d*d)
            //   Vis=0.5/(NoV'*sqrt((-NoL*a2+NoL)*NoL+a2) + NoL*sqrt((-NoV'*a2+NoV')*NoV'+a2) + 1e-4)
            //   Fc=(1-VoH)^5 ; F=lerp(F0,1,Fc)=mad(F0,1-Fc,Fc) ; spec=(D*Vis)*F
            float3 DirectSpecular(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float a   = roughness * roughness;                              // b7 630 (_1264)
                float a2  = a * a;                                              // b7 631 (_1265)
                float nv  = min(NoV, 1.0);
                float d   = mad(mad(NoH, a2, -NoH), NoH, 1.0);                  // b7 632 (_1268)
                float visDenom = nv  * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2))   // b7 644 (_1326 denom term 1)
                               + NoL * sqrt(mad(mad(-nv,  a2, nv ), nv , a2))   // b7 644 (_1326 denom term 2)
                               + EPS_VIS;
                float DV  = (a2 / (d * d)) * (0.5 / visDenom);                  // b7 644 (_1326 = D*Vis)
                float oneMinusVoH = mad(-VoH, 1.0, 1.0);                        // b7 633 (_1274)
                float sq   = oneMinusVoH * oneMinusVoH;                         // b7 634 (_1275)
                float quad = sq * sq;                                           // b7 635 (_1276)
                float Fc   = oneMinusVoH * quad;                               // b7 636 (_1277)
                float oneMinusFc = mad(-quad, oneMinusVoH, 1.0);              // b7 643 (_1306)
                float3 F   = mad(f0, oneMinusFc.xxx, Fc.xxx);                 // lerp(F0,1,Fc)
                return DV * F;
            }

            // ===== Full per-light energy bracket. 1:1 from CORE_MATH HgDirectLightEnergy. (b7 638-647)
            //   specE=(D*Vis)*F ; dfg=EnvBRDFApproxDFG(rough)
            //   gz=lerp(F0,1,1/21) ; msDiff=(dfg/(1-dfg) * gz^2)/(1 - gz*(1-dfg))  [per channel]
            //   energy=min(max(msDiff + min(specE,2048), 0), 1000)
            //   The HG split-sum 2D DFG LUT product (T9, b7 645 _1355) is engine infra with no URP
            //   binding -> analytic dfg substitute (CORE_MATH §2.6/§2.12). Poly + 1/21 ARE the 1:1 math.
            float3 DirectLightEnergy(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
            {
                float3 specE = DirectSpecular(roughness, f0, NoL, NoH, NoV, VoH);     // b7 644·647 (_1326*_DirSpecularStrength applied at call)
                float  dfg   = EnvBRDFApproxDFG(roughness);                          // b7 638 (_1291)
                float  oneMinusDfg = mad(-dfg, 1.0, 1.0);                            // b7 639 (_1294)
                float  dfgEnergy = dfg / oneMinusDfg;                                // b7 645 analytic _1355 (T9 product -> dfg)
                float3 gz    = mad((float3(1.0, 1.0, 1.0) - f0), GRAZING_FLOOR, f0); // b7 640-642 (_1301..1304)
                float3 msDiff = (dfgEnergy * (gz * gz)) / mad(-gz, oneMinusDfg, float3(1.0, 1.0, 1.0)); // b7 647 term A
                return min(max(msDiff + min(specE, 2048.0), 0.0), 1000.0);           // b7 647 (min(...,1000))
            }

        #ifdef _VAT_SOFTBODY
            // ===== Houdini VAT (SoftBody) object-space vertex displace + quaternion normal/tangent rebuild. =====
            //   1:1 from vfxwaterrefract/Sub0_Pass0_Vertex_b8.hlsl lines 137-227. Frame V-row addressing is driven by
            //   host VAT-playback uniforms (_VFXTime/_houdiniFPS/_frameCount/_gameTimeAtFirstFrame, declared in CBUFFER).
            //   _PositionTexture/_RotationTexture are baked offline. _TextureFormat selects HDR raw (=_111 true) vs LDR remap.
            struct VatResult { float3 positionOS; float3 normalOS; float3 tangentOS; };
            VatResult SampleVAT(float3 positionOS, float2 vatUV0)
            {
                VatResult r;
                bool isHDR = (0.0 != _TextureFormat);                                   // b8 136 (_111 = _TextureFormat: HDR raw vs LDR remap)
                // Frame phase (auto-playback): floor(frac((fps/(frameCount-0.01))*(time-firstFrame)*playbackSpeed) * frameCount). (b8 137)
                //   The *_PlaybackSpeed factor is INSIDE frac (applied to the whole product before frac), b8:137.
                float framePhase = (floor(frac((_houdiniFPS / (-0.00999999977648258209228515625 + _frameCount))
                                               * (_VFXTime - _gameTimeAtFirstFrame) * _PlaybackSpeed) * _frameCount) + 1.0 - 1.0) / _frameCount;
                float fp = frac(abs(framePhase));                                       // b8 138 (_136)
                float fpSigned = (framePhase >= -framePhase) ? fp : -fp;                // b8 140 (sign carry)
                // V-row: (-(floor(-10*boundMaxX)+boundMaxX*10+1)) * (fpSigned + (1 - meshV)) + 1. (b8 140 _175)
                float rowEnc = floor(-10.0 * _boundMaxX) + mad(_boundMaxX, 10.0, 1.0);
                float vatV = mad(-rowEnc, ((fpSigned * _frameCount) / _frameCount) + (1.0 - vatUV0.y), 1.0);
                // U: (boundMinZ*10 - ceil(10*boundMinZ) + 1) * meshU. (b8 141 _188)
                float vatU = (mad(_boundMinZ, 10.0, -ceil(10.0 * _boundMinZ)) + 1.0) * vatUV0.x;
                bool cull = (0.100000001490116119384765625 >= vatUV0.y);                 // b8 142 (_189 cull when V<=0.1)

                float4 rotTex = SAMPLE_TEXTURE2D_LOD(_RotationTexture, sampler_RotationTexture, float2(vatU, vatV), 0.0); // b8 143 (T0)
                float4 posTex = SAMPLE_TEXTURE2D_LOD(_PositionTexture, sampler_PositionTexture, float2(vatU, vatV), 0.0); // b8 147 (T1)

                // Position decode: HDR raw, else lerp(boundMin, boundMax, posTex); add to object position; zero when culled. (b8 152-154)
                float3 boundMin = float3(_boundMinX, _boundMinY, _boundMinZ);
                float3 boundMax = float3(_boundMaxX, _boundMaxY, _boundMaxZ);
                float3 posDecoded = isHDR ? posTex.xyz : mad(boundMax - boundMin, posTex.xyz, boundMin);
                r.positionOS = cull ? float3(0.0, 0.0, 0.0) : (posDecoded + positionOS);

                // Quaternion (x,y,z,w): HDR raw, else (v-0.5)*2. (b8 176-183)
                float4 q = isHDR ? rotTex : ((rotTex - 0.5) * 2.0);
                float qx = q.x, qy = q.y, qz = q.z, qw = q.w;
                // Normal = quat-rotated +Y axis: (2(xy-wz), 1-2(x^2+z^2), 2(wx+yz)). (b8 184-189 _443/_444/_445)
                r.normalOS = float3(mad(qy * qx - qz * qw, 2.0, 0.0),
                                    mad(qz * (-qz) - qx * qx, 2.0, 1.0),
                                    mad(qx * qw - qy * (-qz), 2.0, 0.0));
                // Tangent = quat-rotated -X axis: (2(y^2+z^2)-1, -2(zw+xy), 2(yw-xz)). (b8 210-215 _571/_572/_573)
                float3 tangentRot = float3(mad(qy * qy - qz * (-qz), 2.0, -1.0),
                                           mad(qz * (-qw) - qx * qy, 2.0, 0.0),
                                           mad(qx * (-qz) - qy * (-qw), 2.0, 0.0));
                // _B_surfaceNormals gate: the VAT tangent is ZEROED when _B_surfaceNormals==0 (the default), kept when !=0.
                //   (b8 217-220 _585 = (_B_surfaceNormals!=0)?~0:0 ; _590/_592/_594 = tangentRot & _585). The normal is NOT gated.
                r.tangentOS = (0.0 != _B_surfaceNormals) ? tangentRot : float3(0.0, 0.0, 0.0);
                return r;
            }
        #endif
        ENDHLSL

        Pass {
            Name "Refraction"
            Tags { "LightMode"="UniversalForwardOnly" }
            // Source: Blend 0 [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend] (vfxwaterrefract.shader line 168).
            Blend [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            // Source multi_compile_local _ _KW -> URP shader_feature (driven by [Toggle(_KW)]). (source .shader 184-186)
            #pragma shader_feature_local _NORMAL_MAP
            #pragma shader_feature_local _USE_MASK
            #pragma shader_feature_local _USE_DISSOLVE
            #pragma shader_feature_local _VAT_SOFTBODY

            // URP main-light shadow keywords (HG CSM/ASM/cloud stack -> URP main-light shadow attenuation).
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
            #pragma multi_compile_fragment _ _SHADOWS_SOFT

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0; // mesh UV .xy (+ .zw spare); particle custom rides here (b6 TEXCOORD)
                float4 texcoord1  : TEXCOORD1; // particle center / UV1 / custom1 (b6 TEXCOORD_1)
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float4 uv0        : TEXCOORD0; // pass-through texcoord0          (b6 TEXCOORD_2 / b7 TEXCOORD)
                float4 uv1        : TEXCOORD1; // pass-through texcoord1          (b6 TEXCOORD_1_1 / b7 TEXCOORD_1)
                float3 normalWS   : TEXCOORD2; // world geo normal               (b6 TEXCOORD_2_1 / b7 TEXCOORD_2)
                float4 vertColor  : TEXCOORD3; // vertex color (exposure-adjusted)(b6 TEXCOORD_4_1 / b7 TEXCOORD_4)
                float3 positionWS : TEXCOORD4; // world position                 (b7 _176/_177/_178 reconstruction == own WS)
                float  fogFactor  : TEXCOORD5; // URP fog factor (HG fog stack substitute; b7 1206-1266)
                float4 tangentWS  : TEXCOORD6; // world tangent + handedness .w   (b9 TEXCOORD_3 ; _NORMAL_MAP TBN)
            };

            Varyings vert(Attributes v)
            {
                Varyings o;
                float3 positionOS = v.positionOS;
                float3 normalOS   = v.normalOS;
                float4 tangentOS  = v.tangentOS;
            #ifdef _VAT_SOFTBODY
                // Houdini VAT: displace object position + rebuild normal/tangent from the baked rotation quaternion
                // BEFORE the world transform (b8 137-227). Frame time driven by host VAT-playback uniforms.
                // VAT row/column mesh-UV addressing: base path (_HoudiniVATInParticle=0, the catch-all/default) reads
                //   TEXCOORD_1.xy = texcoord1 (UV1), NOT texcoord0; the particle path (=1) would use texcoord0.zw. (b8 139/141 _158/_188)
                VatResult vat = SampleVAT(positionOS, v.texcoord1.xy);
                positionOS = vat.positionOS;
                normalOS   = vat.normalOS;
                tangentOS  = float4(vat.tangentOS, v.tangentOS.w);
            #endif
                // World->clip. Source builds NonJitteredViewNoTransProj manually then removes TAA jitter
                // (b6 lines 228-232); the jitter-free result == URP TransformWorldToHClip.
                VertexPositionInputs posInputs = GetVertexPositionInputs(positionOS);
                o.positionCS = posInputs.positionCS;
                o.positionWS = posInputs.positionWS;

                // World geo normal (b6 lines 238-241: normalize(inverse-transpose * normalOS)).
                VertexNormalInputs nrmInputs = GetVertexNormalInputs(normalOS, tangentOS);
                o.normalWS  = nrmInputs.normalWS;
                o.tangentWS = float4(nrmInputs.tangentWS, tangentOS.w * GetOddNegativeScale()); // b9 347 (_209 = sign(tangent.w))

                o.uv0 = v.texcoord0;       // b6 lines 259-262
                o.uv1 = v.texcoord1;       // b6 lines 263-266
                // Vertex color exposure de-scale (b6 lines 247-250): (1 - _SurfaceType[13])*COLOR when not
                // camera-relative; the HGRP exposure param _SurfaceType[13] has no URP analog -> identity.
                o.vertColor = v.color;
                o.fogFactor = ComputeFogFactor(o.positionCS.z); // HG fog stack -> URP fog (b7 1206-1266)
                return o;
            }

            half4 frag(Varyings input, bool facing : SV_IsFrontFace) : SV_Target
            {
                float3 P = input.positionWS;                    // b7 _176/_177/_178 (depth-reconstructed WS == own surface WS)
                float2 screenUV = input.positionCS.xy / _ScreenParams.xy; // b7 297-298 gl_FragCoord.xy * _ScreenSize.zw

                // ---- View vector V (world, pointing toward camera) ----  (b7 304-313)
                // perspective: normalize(camPos - P) ; ortho: +V[2] (third row of V = toward-camera dir).
                // b7 305-307: ortho branch = _ViewMatrix[0].z/[1].z/[2].z (third ROW of column-major V) with
                //   NO negation. URP's GetWorldSpaceViewDir ortho = -GetViewForwardDir() = +UNITY_MATRIX_V[2].xyz
                //   (GetViewForwardDir() itself = -viewMat[2].xyz), so the faithful map is +UNITY_MATRIX_V[2].xyz,
                //   NOT -UNITY_MATRIX_V[2].xyz. (A leading minus here flips cosI/Fresnel/refraction under ortho.)
                bool isOrtho = (0.0 != unity_OrthoParams.w);                // b7 304 (_200 = 0==ortho.w; inverted here)
                float3 viewRaw = isOrtho ? UNITY_MATRIX_V[2].xyz            // b7 305-307 (_ViewMatrix[*].z third row, NO negate)
                                         : (_WorldSpaceCameraPos - P);
                float distSq = dot(viewRaw, viewRaw);                       // b7 308 (_238)
                float invLen = rsqrt(max(distSq, EPS_VIEWLEN));            // b7 309 (_243)
                float3 V = viewRaw * invLen;                              // b7 310-312 (_244/_245/_246)
                float  viewDist = distSq * invLen;                       // b7 313 (_247 linear eye dist)

                // ---- Main tex UV (channel/polar/screen select -> scroll -> rotate -> ST -> random-UV jitter) ----  (b7 316-318)
                // Particle-aware: custom1X = TEXCOORD_1.x * _InParticle (b7 314 _256).
                float custom1X = input.uv1.x * _InParticle;                 // b7 314 (_256)
                float worldHash = frac(unity_ObjectToWorld._m03 + unity_ObjectToWorld._m13 + unity_ObjectToWorld._m23); // b7 315 (_365 _WaterRandomUV jitter)
                // The full HG UV is a polar/screen/mesh selector folded into _MainTexUVWeights + _MainTexUVRotateMat.
                // Base material (_MainUVSet=0, weights=(1,0,0,0), rotateMat=identity) reduces to mesh UV0 scrolled by
                // speed; the generic mad-chain is preserved structurally (b7 316-317).
                float2 uv0 = input.uv0.xy;
                float2 scrolled = mad(_MainTexUVSpeed.xy, _VFXTime, uv0);   // b7 316-317 (speed.xy by time)
                scrolled = mad(_MainTexUVSpeed.zw, custom1X, scrolled);     // (speed.zw by custom1X)
                float2 c = scrolled - 0.5;                                  // b7 316-317 (+(-0.5) centering)
                float2 rotV;
                rotV.x = mad(c.x, _MainTexUVRotateMat.x, c.y * _MainTexUVRotateMat.z) + 0.5; // b7 317 rotate (.x/.z row)
                rotV.y = mad(c.x, _MainTexUVRotateMat.y, c.y * _MainTexUVRotateMat.w) + 0.5; // b7 316 rotate (.y/.w row)
                float2 stUV = mad(rotV, _MainTex_ST.xy, _MainTex_ST.zw);    // b7 316-317 ST
                // b7 316 _373: the V coordinate (post-ST) is scaled by (min(worldHash*_MainTexUVSpeed.z, 0.5)+1) BEFORE the
                //   random-UV add. The U has no such factor. Both axes then add the random-UV jitter _MainTexUVSpeed.z*worldHash.
                float vScale = min(worldHash * _MainTexUVSpeed.z, 0.5) + 1.0;            // b7 316 (min(_365*speed.z,0.5)+1)
                float2 mainUV;
                mainUV.x = mad(_MainTexUVSpeed.z, worldHash, stUV.x);                    // b7 317 (_377 = mad(speed.z, _365, ST-U))
                mainUV.y = mad(_MainTexUVSpeed.z, worldHash, stUV.y * vScale);           // b7 316/318 (mad(speed.z, _365, _373=vScale*ST-V))
                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, mainUV); // b7 318 (_385)

                // mainTex alpha source: R when _UseMainTexAsAlpha else A.  HG: mad(_gameTimeAtFirstFrame, A->R...).
                // _gameTimeAtFirstFrame in the source is the actual blend weight register; non-VAT material = 1
                // (R-as-alpha). 1:1 reduces to lerp(A, R, _UseMainTexAsAlpha) form. (b7 328 _391/_388 lerp)
                float mainAlpha = lerp(mainSample.a, mainSample.r, _UseMainTexAsAlpha); // b7 328 (_388 vs _391)

                // ---- Mask tex (alpha-only gate) ----  (b9 368/393/396, _USE_MASK)
                // maskAlpha = lerp(maskA, maskR, _UseMaskTexAsAlpha) folds into opacity; maskColor = lerp(maskR, 1, _UseMaskTexAsAlpha) folds into tint.
                float maskAlpha = 1.0;
                float maskColor = 1.0;
            #ifdef _USE_MASK
                float2 mc = mad(_MaskTexUVSpeed.xy, _VFXTime, input.uv0.xy) - 0.5;       // b9 368 (mask scroll + center)
                float2 maskRot;
                maskRot.x = mad(mc.x, _MaskTexUVRotateMat.x, mc.y * _MaskTexUVRotateMat.z) + 0.5; // b9 368 rotate (.x/.z)
                maskRot.y = mad(mc.x, _MaskTexUVRotateMat.y, mc.y * _MaskTexUVRotateMat.w) + 0.5; // b9 368 rotate (.y/.w)
                float2 maskUV = mad(maskRot, _MaskTex_ST.xy, _MaskTex_ST.zw);            // b9 368 ST
                float4 maskSample = SAMPLE_TEXTURE2D(_MaskTex, sampler_MaskTex, maskUV);  // b9 368 (_478 = T2 mask)
                maskAlpha = lerp(maskSample.a, maskSample.r, _UseMaskTexAsAlpha);        // b9 393 (mad(_UseMaskTexAsAlpha, -_483+_480, _483))
                maskColor = lerp(maskSample.r, 1.0, _UseMaskTexAsAlpha);                 // b9 396 (mad(_UseMaskTexAsAlpha, -_480+1, _480))
            #endif

                // ---- Dissolve (soft erode of opacity + emissive edge glow) ----  (b11 404-406/411/414-416, _USE_DISSOLVE)
                float dissolveGate = 1.0;   // multiplies opacity (b11 411 clamp(_848*_DissolveEdgeSharp,0,1))
                float dissolveEdge = 0.0;   // emissive edge factor (b11 406 _863)
            #ifdef _USE_DISSOLVE
                float2 dc = mad(_DissolveUVSpeed.xy, _VFXTime, input.uv0.xy) - 0.5;      // b11 404 (dissolve scroll + center)
                float2 dRot;
                dRot.x = mad(dc.x, _DissolveUVRotateMat.x, dc.y * _DissolveUVRotateMat.z) + 0.5; // b11 404 rotate (.x/.z)
                dRot.y = mad(dc.x, _DissolveUVRotateMat.y, dc.y * _DissolveUVRotateMat.w) + 0.5; // b11 404 rotate (.y/.w)
                float2 dUV = mad(dRot, _DissolveTex_ST.xy, _DissolveTex_ST.zw);          // b11 404 ST
                float dTex = SAMPLE_TEXTURE2D(_DissolveTex, sampler_DissolveTex, dUV).x;  // b11 404 (_807.x = T4 dissolve R)
                // Vertex-color dissolve weight: lerp(vc.r, vc.a, _DissolveVertexChannel) style select, gated by toggle, minus range. (b11 405)
                float vtxChan = mad(_DissolveVertexChannel, -input.vertColor.r + input.vertColor.a, input.vertColor.r); // b11 405 (mad(_DissolveVertexChannel, -vc.x+vc.w, vc.x))
                float vtxWeight = clamp(mad(_UseVertexColorAlphaAsDissolveWeight, vtxChan - 1.0, 1.0) - _DissolveVertexRange, 0.0, 1.0); // b11 405
                // Schedule remap: (custom1.z*_InParticle + _DissolveScheduleOffset) * 2.02 - 0.0099... (b11 405)
                //   Blob uses TEXCOORD_1.z (particle custom1 .z channel) scaled ONCE by _InParticle via the mad; NOT .y, NOT _InParticle^2.
                float schedule = mad(mad(input.uv1.z, _InParticle, _DissolveScheduleOffset), 2.019999980926513671875, -0.0099999904632568359375); // b11 405 (mad(TEXCOORD_1.z, _InParticle, _DissolveScheduleOffset))
                float dissolveVal = dTex - mad(vtxWeight, schedule, -1.0);               // b11 405 (_848 = _807.x - mad(vtxWeight, schedule, -1))
                dissolveEdge = clamp(mad(-dissolveVal, 1.0, _DissolveEmissiveEdge) * _DissolveEdgeSharp, 0.0, 1.0); // b11 406 (_863)
                dissolveGate = clamp(dissolveVal * _DissolveEdgeSharp, 0.0, 1.0);        // b11 411 (opacity gate)
            #endif

                // ---- Front-face normal flip (geo normal; replaced by tangent-space normal map under _NORMAL_MAP) ----  (b7 324-327 / b9 376-392)
                float3 geoN = input.normalWS;
            #ifdef _NORMAL_MAP
                // Normal-map UV (same construction as main tex, with _NormalMap* params; reduced base form). (b9 363)
                float2 nc = mad(_NormalMapUVSpeed.xy, _VFXTime, input.uv0.xy) - 0.5;     // b9 363 (nmap scroll + center)
                float2 nmRot;
                nmRot.x = mad(nc.x, _NormalMapUVRotateMat.x, nc.y * _NormalMapUVRotateMat.z) + 0.5; // b9 363 rotate (.x/.z)
                nmRot.y = mad(nc.x, _NormalMapUVRotateMat.y, nc.y * _NormalMapUVRotateMat.w) + 0.5; // b9 363 rotate (.y/.w)
                float2 nmUV = mad(nmRot, _NormalMap_ST.xy, _NormalMap_ST.zw);            // b9 363 ST
                float4 nSample = SAMPLE_TEXTURE2D(_NormalMap, sampler_NormalMap, nmUV);   // b9 376 (_649 = T3 normal)
                // DXT5nm unpack: nx = nSample.x*nSample.w*2-1 ; ny = nSample.y*2-1 ; nz = sqrt(1 - min(dot(xy,xy),1)). (b9 377-379)
                float nx = mad(nSample.x * nSample.w, 2.0, -1.0);                        // b9 377 (_655)
                float ny = mad(nSample.y, 2.0, -1.0);                                    // b9 378 (_656)
                float nz = max(sqrt(-min(dot(float2(nx, ny), float2(nx, ny)), 1.0) + 1.0), 1.000000016862383526387164645044e-16); // b9 379 (_664)
                // Scale tangent XY by _NormalScale, renormalize. (b9 380-385)
                float3 tn = float3(nx * _NormalScale, ny * _NormalScale, nz);           // b9 380-381 (_669/_670, scaled by _NormalScale)
                tn = tn * rsqrt(dot(tn, tn));                                            // b9 382-385 (_674 renormalize)
                // TBN: bitangent = tangent.w_sign * cross(geoN, tangentWS); worldN = tn.z*geoN + tn.x*tangentWS + tn.y*bitangent. (b9 386-388)
                float3 T = input.tangentWS.xyz;
                float3 B = input.tangentWS.w * cross(input.normalWS, T);                 // b9 386-388 (_209 * cross(TEXCOORD_2, TEXCOORD_3))
                geoN = tn.z * input.normalWS + tn.x * T + tn.y * B;                      // b9 386-388 (_732/_733/_734)
            #endif
                float3 N = facing ? geoN : -geoN;                           // b7 324-327 / b9 390-392 (_482/_483/_484 = front-flip of mapped N)

                // ---- Opacity assembly ----  (b7 328-329 _560/_561)
                // near-fade (dual band) * vertColor.a(DisableVertColor) * _TintColor.a * _TintColorAlpha *
                //   Fresnel-opacity * mainAlpha , clamped [0,1].
                float nearFade = 1.0;
                if (0.0 != _UseNearCameraFade) {                            // b7 328 (_UseNearCameraFade branch)
                    float d = abs(dot(UNITY_MATRIX_V[2].xyz, P) + UNITY_MATRIX_V[2].w); // view-space depth (b7 303 _195)
                    nearFade = saturate((d - _NearCameraFadeDistanceStart)  / (_NearCameraFadeDistanceEnd  - _NearCameraFadeDistanceStart))
                             * saturate((d - _NearCameraFadeDistanceEnd2)   / (_NearCameraFadeDistanceStart2 - _NearCameraFadeDistanceEnd2));
                }
                float vertA = lerp(input.vertColor.a, 1.0, _DisableVertColor); // b7 328 (mad(_DisableVertColor, 1-vc.a, vc.a))
                // Vertex-color-as-opacity gate (b7 328 mad(X, vc.w-1, 1) = lerp(1, vc.w, X)).
                //   Identified by MATH STRUCTURE: lerp(1, vertColor.a, X) is exactly "use vertex color as opacity",
                //   and _UseVertexColorAsOpacity is the one source Property otherwise unconsumed. The decompiler
                //   labels X differently per variant (_MainTexUVSpeed.x in b7 c15.x / _NormalMap_ST.x in b9 c34.x —
                //   the HG graph packs the flag into a free slot per permutation), so the cite is the operation, not
                //   the slot. Uses RAW vertColor.a (NOT the _DisableVertColor-blended vertA — that is a separate factor).
                float vcOpacity = lerp(1.0, input.vertColor.a, _UseVertexColorAsOpacity); // b7 328 (mad(_UseVertexColorAsOpacity, TEXCOORD_4.w-1, 1))
                float fresnelOpacity = 1.0;
                if (0.0 != _UseFresnelAsOpacity) {                          // b7 328 (mad(_UseFresnelAsOpacity, pow(|N.V|,_FresnelStrength)-1, 1))
                    float ndotv = abs(dot(input.normalWS, V));            // b7 328 |dot(TEXCOORD_2, V)| (raw, not flipped)
                    fresnelOpacity = pow(ndotv, _FresnelStrength);
                }
                float opacity = saturate(dissolveGate * mainAlpha * (vertA * _TintColor.a) * _TintColorAlpha * maskAlpha * nearFade * vcOpacity * fresnelOpacity); // b7 328-329 (_561) ; *maskAlpha (b9 393) ; *dissolveGate (b11 411)

                // ---- Tint color ----  (b7 331-336)
                // tintCol = mainTex.rgb (R-as-alpha gated) * vertColor.rgb * _TintColor.rgb * _TintColorIntensity / exposureDeScale.
                float exposureScale = mad(_ExposureParams.x, _IgnorePostExposure, 1.0 - _IgnorePostExposure); // b7 330 (_574)
                // b7 331-333: per channel = mad(_UseMainTexAsAlpha, 1 - mainSample.c, mainSample.c) = lerp(mainSample.c, 1, X).
                //   When _UseMainTexAsAlpha=1 (DEFAULT) the color factor is forced to WHITE (1,1,1) — the texture is
                //   consumed as alpha only and the tint is pure _TintColor*_TintColorIntensity. (NOT lerp(rgb, mainAlpha, X).)
                float3 mainColorFactor = lerp(mainSample.rgb, float3(1.0, 1.0, 1.0), _UseMainTexAsAlpha);      // b7 331-333 (_581/_583/_584 first factor, _442=1.0)
                // b7 331-333 vertex modulation is per-channel vertColor.RGB (TEXCOORD_4.xyz), NOT alpha (vertA is alpha-only,
                //   used in opacity). lerp(vertColor.rgb, 1, _DisableVertColor).
                float3 vertRGB = lerp(input.vertColor.rgb, float3(1.0, 1.0, 1.0), _DisableVertColor);          // b7 331-333 (mad(_DisableVertColor, 1-vc.xyz, vc.xyz))
                float3 tintCol = min(max((mainColorFactor * (vertRGB * _TintColor.rgb)) * _TintColorIntensity * maskColor / exposureScale, 0.0), 1000.0); // b7 331-333 (_581/_583/_584) ; *maskColor (b9 396)
            #ifdef _USE_DISSOLVE
                // Emissive edge glow blended into the tint: lerp(tintCol, dissolveEdge*emColor*intensity, dissolveEdge). (b11 414-416)
                float3 dissolveEmissive = dissolveEdge * (_DissolveEmissiveColor.rgb * _TintColorIntensity) / exposureScale; // b11 414-416 (_863*emColor*_TintColorIntensity / _985)
                tintCol = min(max(mad(dissolveEdge, dissolveEmissive - tintCol, tintCol), 0.0), 1000.0); // b11 414-416 (mad(_863, X-_572, _572))
            #endif
                float3 litTint = tintCol * _UseLighting;                    // b7 334-336 (_589/_590/_591)

                // ---- Refraction: Snell's law through N, view-space-projected screen offset ----  (b7 337-345)
                float cosI = dot(-V, N);                                    // b7 337 (_595 = dot(-V, N))
                float k = mad(-(_IoR * _IoR), mad(-cosI, cosI, 1.0), 1.0);  // b7 338 (_609 = 1 - IoR^2*(1-cosI^2))
                float kSqrt = mad(_IoR, cosI, sqrt(k));                     // b7 339 (_614 = IoR*cosI + sqrt(k))
                bool noTIR = (k >= 0.0);                                    // b7 340 (_616 mask)
                float refStrength = opacity * _RefractThickness;            // b7 341 (_645 = _561 * _RefractThickness)
                // refracted ray (world): IoR*(-V) - N*kSqrt , masked by total-internal-reflection (b7 342-344).
                float3 refrDir = noTIR ? (_IoR * (-V) - N * kSqrt) : float3(0, 0, 0); // b7 342-344 (_646/_647/_648 dir)
                float3 refrOffsetWS = refStrength * refrDir;                // b7 342-344 (_645 * dir)
                // project the world offset into view to get a screen-space UV offset (b7 345: mul(_ViewMatrix, offset)).
                float2 refrOffsetVS = mul((float3x3)UNITY_MATRIX_V, refrOffsetWS).xy; // b7 345 (_ViewMatrix[*].xy · offset)
                float2 refrUV = screenUV + refrOffsetVS;                    // b7 345 (gl_FragCoord.xy*_ScreenSize.zw + viewOffset)
                // 1:1: base blob b7 1272-1274 multiplies the camera-opaque sample (_681.x/.y/.z) DIRECTLY by
                //   the brightness factor — there is NO _RefractTint multiply in the base (#else) variant.
                //   (_RefractTint is declared in the source Properties but unused in this base path.)
                float3 sceneRefr = SAMPLE_TEXTURE2D_X(_CameraOpaqueTexture, sampler_CameraOpaqueTexture, refrUV).rgb; // b7 345 (_681 = T2 scene color, no tint)

                // ---- Diffuse / F0 split ----  (b7 352-359)
                float dielF0 = DIELECTRIC_F0 * _Specular;                   // b7 352 (_756)
                // HG blends mainTex-as-alpha into the diffuse/F0 (b7 353-359). _770 = _589 - _589*_UseMainTexAsAlpha,
                //   where _589 = litTint (= tint * _UseLighting) -> diffuseCol = litTint * (1 - _UseMainTexAsAlpha).
                float3 diffuseCol = litTint * (1.0 - _UseMainTexAsAlpha);    // b7 353-355 (_770/_771/_772)
                float  f0Scalar  = mad(-dielF0, _UseMainTexAsAlpha, dielF0); // b7 356 (_777 = dielF0*(1-_UseMainTexAsAlpha))
                float3 f0Diff    = mad(litTint, _UseMainTexAsAlpha, f0Scalar.xxx); // b7 357-359 (_781/_782/_783) -> F0-ish blended albedo
                float3 f0        = f0Diff;                                   // b7 used directly as the F0 in GGX grazing/Fresnel

                // ---- Indirect SH ambient ----  (b7 366-373)
                // HG: diffuseCol * dot(_IVDefaultSHA[rgb], float4(N, 1)) -> URP SampleSH(N) per channel.
                float3 sh = SampleSH(N);                                     // b7 366-368 (_IVDefaultSHA·N -> SampleSH)
                float3 indirect = diffuseCol * sh * _EnvironmentGlobalParams0.x; // b7 369 (_904/_905/_906 * envParams.x)
                float  indLuma = dot(indirect, float3(1.0, 1.0, 1.0)) * 0.3333333432674407958984375; // b7 369 (_918 avg)
                float3 indirectGraded = mad(indirect - indLuma.xxx, _IndirectSaturation, indLuma.xxx); // b7 370-373 (_930/_931/_932 saturation grade)

                // ---- Direct main light (PBR) ----  (b7 601-655)
                float4 shadowCoord = TransformWorldToShadowCoord(P);        // HG CSM/ASM -> URP shadow coord
                Light mainLight = GetMainLight(shadowCoord, P, half4(1, 1, 1, 1));
                float  mainAtten = mainLight.distanceAttenuation * mainLight.shadowAttenuation; // b7 597 (_1007 final shadow)
                float3 directLight = float3(0, 0, 0);
                {
                    float3 L = mainLight.direction;                        // b7 607-619 (light dir, area-soften dropped)
                    float3 H = normalize(L + V);                          // b7 620-626 (_1235..1245)
                    float NoL = saturate(dot(L, N));                      // b7 627 (_1249)
                    float NoH = saturate(dot(N, H));                      // b7 628 (_1253)
                    float NoV = saturate(dot(N, V));                      // b7 629 (_1257)
                    float VoH = saturate(dot(V, H));                      // Schlick VoH (b7 633 base dot)
                    // energyBracket = msDiff + min(D*Vis*F, 2048), clamped [0,1000] (lightScale folded into URP color). (b7 647)
                    float3 energyBracket = DirectLightEnergy(_Roughness, f0, NoL, NoH, NoV, VoH); // b7 638-647 (_1326/_1355 bracket)
                    // HG then: /max(opacity,0.01), min(...,1000), *_DirSpecularStrength applied to the WHOLE bracket (b7 646-647).
                    float opacityFloor = max(opacity, 0.00999999977648258209228515625); // b7 646 (_1386)
                    float3 energyDir = min(energyBracket / opacityFloor, 1000.0) * _DirSpecularStrength; // b7 647 (/_1386, min, *_DirSpecularStrength)
                    // out = (energyDir*NoL + diffuseCol*NoL) * lightColor * atten   (b7 647 mad(...,_1249, _770*_1249) * lightCol)
                    // HG T8 shadow-falloff ramp (b7 650-652 _1420/_1426) is engine infra -> URP shadowAttenuation; dropped.
                    directLight = mad(energyDir, NoL, diffuseCol * NoL) * (mainAtten * mainLight.color); // b7 647-654 (_1411/_1412/_1413)
                }

                // ---- Additional (punctual) lights ----  (b7 664-1205 cluster -> URP loop)
                float3 addLight = float3(0, 0, 0);
            #if defined(_ADDITIONAL_LIGHTS)
                uint addCount = GetAdditionalLightsCount();
                for (uint li = 0u; li < addCount; ++li)                     // b7 705 outer light loop -> URP GetAdditionalLight
                {
                    Light l = GetAdditionalLight(li, P, half4(1, 1, 1, 1));
                    float3 L = l.direction;
                    float3 H = normalize(L + V);
                    float NoL = saturate(dot(L, N));
                    float NoH = saturate(dot(N, H));
                    float NoV = saturate(dot(N, V));
                    float VoH = saturate(dot(V, H));
                    float3 energy = DirectLightEnergy(_Roughness, f0, NoL, NoH, NoV, VoH); // b7 993-1000 (same BRDF per light)
                    float atten = l.distanceAttenuation * l.shadowAttenuation;
                    addLight += mad(energy, NoL, diffuseCol * NoL) * (atten * l.color);    // b7 998-1000 (_3645/_3647/_3649)
                }
            #endif

                // ---- Surface lit color = unlit-tint + VFX-graded indirect + direct + add lights ----  (b7 1275 LIGHTING_SUM)
                float sceneDarken = 1.0 - _IsSceneEffect;                   // b7 374 (_937)
                // unlit-tint passthrough: tintCol * (1 - _UseLighting)  (b7 1275 mad(_581, _1871, ...); _1871=1-_UseLighting, _581=tintCol)
                float3 unlitTint = tintCol * (1.0 - _UseLighting);          // b7 1275 (_581 * _1871)
                // VFX saturation grade of the indirect term, gated by _IsSceneEffect (b7 1275 inner mad):
                //   grade = (_VfxColorGrade.w*(indirectGraded - luma) + luma) * _VfxColorGrade.xyz  (b7 1275 _2850/_2856)
                float indLumaGrade = dot(indirectGraded, LUM);             // b7 1267 (_2850)
                float3 indirectVfx = mad(_VfxColorGrade.w, indirectGraded - indLumaGrade.xxx, indLumaGrade.xxx) * _VfxColorGrade.xyz; // b7 1275 (VFX grade)
                float3 indirectTerm = mad(indirectVfx, _IsSceneEffect, indirectGraded * sceneDarken); // b7 1275 mad(grade, _IsSceneEffect, _930*_937)
                float3 lightingSum = unlitTint + indirectTerm + (directLight + addLight); // b7 1275 (_581*_1871 + indirectTerm + (_1957*_1953 + _1802))

                // ---- Fog: HG atmosphere+exp+volumetric (b7 1206-1266 / 1275 _2213*_2849 transmittance + _2957*inscatter) -> URP MixFog.
                //   MixFog(c, f) = c*f + fogColor*(1-f) == LIGHTING_SUM*transmittance + inscatter (the _2957=1-_BlendMode
                //   factor inside the HG inscatter is folded into URP's fog color blend; additive-blend in-scatter delta is dropped).
                float3 surfFogged = MixFog(lightingSum, input.fogFactor);   // b7 1275 (_2213*_2849 + _2957*FOG_INSCATTER)

                // ---- Composite: opacity^2 * litSurface  +  (1-opacity) * refractedBackground ----  (b7 1272-1277)
                // refracted background brightened: lerp(scene, scene*_RefractBrightness, opacity*_UseMaskTexAsAlpha) (b7 1272-1274)
                float3 refrBg = mad(opacity, mad(_UseMaskTexAsAlpha, _RefractBrightness, -1.0), 1.0) * sceneRefr; // b7 1272-1274 (_2978/_2979/_2980)
                // b7 1275 fully expanded: _2987 = _561 * (surfFogged*_561 - refrBg) + refrBg = _561^2*surfFogged + (1-_561)*refrBg.
                float3 composite = mad(opacity, mad(surfFogged, opacity, -refrBg), refrBg); // b7 1275-1277 (_2987/_2988/_2989)

                // ---- Final VFX saturation color-grade ----  (b7 1278-1282)
                float compLuma = dot(composite, LUM);                       // b7 1278 (_2990)
                float3 graded = mad(_VfxColorGrade.w, composite - compLuma.xxx, compLuma.xxx) * _VfxColorGrade.xyz; // b7 1280-1282 (VFXParams1 grade)
                float3 outRGB = mad(graded, _IsSceneEffect, sceneDarken * composite); // b7 1280-1282 (mad(grade, _IsSceneEffect, _937*comp))

                // ---- Output (RT0). Alpha = 1 (b7 1286 SV_Target.w = 1.0). ----
                return half4(outRGB, 1.0);

                // TODO(engine-side): the HGRP "Distortion" pass writes a 2nd MRT (SV_Target_1) = packed transparent
                //   motion vectors (b7 1283-1284, encode sign(d)*sqrt(sqrt(|d*0.5|))*0.5+0.5 per channel,
                //   gated by clamp(1+_EnableTransparentMV-_SurfaceType)) plus a responsive-transparent flag
                //   bit in .w (b7 1285, _SurfaceType*_Responsive). This is NOT a material texture/math delta — it
                //   requires a host C# ScriptableRendererFeature that binds a second transparent-motion-vector MRT
                //   to this pass (URP's stock UniversalForwardOnly has a single color target). Until that feature
                //   exists there is no target to write. If added, port: cur/prev clip positions interpolated via two
                //   extra Varyings (b8 TEXCOORD_5 = NonJitteredVP*posWS, TEXCOORD_6 = PrevNonJitteredVP*prevPosWS),
                //   d = TEXCOORD_5.xy/TEXCOORD_5.z - TEXCOORD_6.xy/TEXCOORD_6.z (b7 1283).
            }
            ENDHLSL
        }
    }
}
