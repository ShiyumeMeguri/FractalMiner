// ============================================================================================
// HGRP/LitEffect → URP 单文件 1:1 移植(家族纯净版)。
// 真源 = AllShader_1.3.3/materials/lit/liteffect.shader 骨架 + liteffect/ 反编译变体 blob。
// 家族事实(全部以 blob 逐位为准):
//   - 参考仅 3 pass: HGBuffer(GBuffer 5-MRT) / ShadowCaster / DepthOnly, 不透明延迟专用;
//     URP 系统化 = UniversalGBuffer + ShadowCaster + DepthOnly, 另给 UniversalForward
//     (同一表面数据 × litforward b11 前向核, 供 Forward/Forward+ 路径可用;参考无前向真值, 该
//     pass 为管线适配而非家族新行为)。
//   - 自发光家族带 `×_EmissiveRemap` 尾乘(b227:420 mad(基础自发光,_EmissiveRemap,视差项);
//     lit/litforward/lithlod 家族无此乘)。
//   - 溶解 clip = sat(dissolve×_DissolveEdgeSharp) − 0.02 (b249/b259:199, 无 alpha 乘、阈值
//     0.02 —— littransparent 家族是 clip(α×edge−0.01), 两族不同, 勿混)。
//   - 视差自发光(_PARALLAX_MAP, b221:185-348 全链)+ 世界空间扩展(_PARALLAX_MAP_WORLDSPACE,
//     b227→b333 融合差分;单开 WORLDSPACE 无 _PARALLAX_MAP 时只添死插值器 = 出货 no-op)。
//   - VAT: 软体(b268/lit b516)/刚体(b290)/压缩旋转(_UNLOAD_ROT_TEX, b308)。
//   - _UV_ANIMATION 与 _USE_VERTOFFSETMASK 在本家族任何 pass 的 multi_compile 列表中都不存在
//     (骨架 L232-250/L1388/L1797) = 出货不编译;材质切换这些 keyword 无效, 故不移植。
//   - 死 uniform(出货 blob 无读取): _DissolveEmissiveEdge/_UseScanDissolve/_DissolveSpeed/
//     _B_pscaleAreInPosA/_B_stretchByVel/_stretchByVelAmount/_B_twoSidedNorms/
//     _DirectLightRoughnessOffset(该 hack 只在 liteffectblend 家族生效)。
// 引擎面 → URP 替换表(与 lit.shader 同): IV-clipmap SH→SampleSH; probe 分箱→URP 反射;
//   CSM/ASM/ramp/云影→mainLight.shadowAttenuation; zbin 点光→URP additional lights;
//   大气/froxel 雾→MixFog; MV RT/TAA jitter→URP MotionVectors 域(弃); 自动曝光=1;
//   SceneEffect per-draw(Float4x5_Param0/2/3/4)=中性; 时间槽(_VFXParams0.w/PerDraw 保留槽)→_Time.y;
//   片元 InvViewProj 世界重建→positionWS 插值器; _VFXParams0.xyz/_VFXParams2(角色位置/交互信号
//   全局)保留全局声明, 无宿主时按其门控自然退化。
// ============================================================================================
Shader "HGRP/LitEffect"
{
    Properties
    {
        _MainProperties ("基础材质", Float) = 0
        [Enum(Three, 0, Two, 1, TwoWithNoMetallic, 2)] _BaseTextureMapCount ("基础 PBR 贴图设置", Float) = 0
        _BaseColorSection ("基础固有色贴图", Float) = 0
        _BaseColorMap ("固有色贴图", 2D) = "white" {}
        [Enum(UV0, 0, UV1, 1)] _BaseUVSet ("UV 通道", Float) = 0
        _BaseColor ("底色", Color) = (1, 1, 1, 1)
        _BaseColorTintCover ("底色覆盖贴图颜色", Range(0, 1)) = 0
        _BaseColorBrighterScale ("固有色变亮", Range(1, 3)) = 1
        _BasePbrMapSection ("基础法线与 PBR 材质贴图", Float) = 0
        _NormalMap ("法线贴图", 2D) = "bump" {}
        _MROMap ("MRO 贴图", 2D) = "white" {}
        [Enum(UV0, 0, UV1, 1)] _BasePbrMapUVSet ("UV 通道", Float) = 0
        _NormalScale ("法线贴图强度", Range(0, 1)) = 1
        [ToggleUI] _TwoSidedNormal ("双面材质反转背面法线", Float) = 1
        _BasePbrCfgSection ("基础 PBR 材质设置", Float) = 0
        _Metallic ("金属度滑杆", Range(0, 1)) = 0
        _Specular ("Specular (Default 0.5)", Range(0, 1)) = 0.5
        _RoughnessMin ("最小粗糙度", Range(0, 1)) = 0
        _RoughnessMax ("最大粗糙度", Range(0, 1)) = 1
        _OcclusionStrength ("AO 强度", Range(0, 1)) = 1
        _PorositySection ("吸水度", Float) = 1
        _PorosityFactorX ("吸水度影响因素X,受粗糙度影响", Range(-1, 1)) = 0.2
        _PorosityFactorY ("吸水度影响因素Y", Range(0, 1)) = 0.4
        [HideInInspector] _ShadowCullMode ("Shadow Render Face", Float) = 2
        [HideInInspector] _ShadowBias ("Shadow Bias", Float) = 0
        _EnableEmissiveMap ("自发光/自发光贴图", Float) = 0
        [Enum(EmissiveMap, 0, BaseColor A, 1, NormalMap B, 2, NormalMap A, 3, MRO A, 4, NOMAP, 5)] _EmissiveMaskChannel ("自发光通道", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _EmissiveUVSet ("UV 通道", Float) = 0
        [Enum(ChannelR, 0, ChannelRGBA, 1)] _EmissiveType ("单/四通道", Float) = 0
        _EmissiveMap ("自发光贴图", 2D) = "black" {}
        [ToggleUI] _AlbedoAffectEmissive ("自发光不受固有色影响", Float) = 1
        [ToggleUI] _IgnorePostExposure ("不受自动曝光影响", Float) = 1
        [HDR] [Gamma] _EmissiveColor ("自发光颜色", Color) = (1, 1, 1, 1)
        [HDR] [Gamma] _EmissiveColorG ("自发光颜色(G通道)", Color) = (0, 0, 0, 1)
        [HDR] [Gamma] _EmissiveColorB ("自发光颜色(B通道)", Color) = (0, 0, 0, 1)
        [HDR] [Gamma] _EmissiveColorA ("自发光颜色(A通道)", Color) = (0, 0, 0, 1)
        [HideInInspector] _EmissiveSpeed ("Emissive Speed", Vector) = (0, 0, 0, 0)
        _EmissiveRemap ("Emissive Remap", Range(1, 2)) = 1
        [Toggle(_EMISSIVE_ANIM)] _EnableEmissiveAnim ("自发光/自发光呼吸", Float) = 0
        _EmissiveMapTilling ("Emmisive Tilling", Range(0.01, 20)) = 1
        _EmissiveAnimSpeed ("呼吸速度", Range(0, 80)) = 0
        _EmissiveAnimInterval ("呼吸时间比例(1是一直亮，2是一半时间亮)", Range(1, 10)) = 1
        [ToggleUI] _EmissiveAnimRandom ("Emmisive Anim Random", Float) = 0
        _EmissiveMinBrightness ("Emmisive Min brightness", Range(0, 0.5)) = 0
        [Toggle(_EMISSIVE_ANIM_SWEEP)] _EnableEmissiveAnimSweep ("自发光/自发光扫光", Float) = 0
        _EmissiveSweepSpeed ("扫光速度", Range(0.01, 20)) = 3
        _EmissiveSweepInterval ("扫光间隔时间", Range(0.01, 20)) = 3
        _EmissiveSweepWidth ("扫光宽度", Range(0.01, 10)) = 0.8
        _EmissiveSweepFalloff ("扫光边缘硬度", Range(1, 10)) = 1
        [ToggleUI] _EmissiveSweepRandom ("扫光在不同位置随机先后(会移动的物体不要开)", Float) = 0
        _EmissiveSweepAlbedoScale ("受固有色影响加强", Range(0, 5)) = 0
        [Toggle(_DETAIL_MAP)] _EnableDetailMap ("混合/细节贴图", Float) = 0
        _DetailMap ("细节贴图", 2D) = "bump" {}
        [Enum(UV0, 0, UV1, 1)] _DetailUVSet ("UV 通道", Float) = 0
        [Enum(Normal_Roughness_AlbedoTint , 0, Normal_Roughness_AO, 1)] _DetailMode ("模式", Float) = 0
        [Enum(AllPass, 0, DetailMap A, 1, BaseColor A, 2, NormalMap B, 3, NormalMap A, 4, MRO A, 5)] _DetailMaskMode ("蒙版通道", Float) = 0
        _DetailNormalIntensity ("法线贴图强度", Range(0, 3)) = 1
        _DetailOverlayColor ("细节叠色", Color) = (0, 0, 0, 0)
        _DetailBaseColorBrighterScale ("细节固有色变亮", Range(1, 3)) = 1
        _DetailPBRIntensity ("PBR 属性覆盖程度", Range(0, 1)) = 1
        _DetailFalloffStart ("深度渐隐起始距离", Range(0, 800)) = 750
        _DetailFalloffEnd ("深度渐隐结束距离", Range(0, 800)) = 800
        [Toggle(_TRI_CHANNEL_MASK)] _EnableTriChannelMask ("混合/三通道 Mask 材质控制", Float) = 0
        _MaskMap ("三通道 Mask", 2D) = "black" {}
        [Enum(UV0, 0, UV1, 1)] _MaskUVSet ("UV 通道", Float) = 0
        _MaskAlbedoR ("Mask R Color", Color) = (1, 0, 0, 1)
        _MaskRoghnessR ("Mask R Roughness", Range(0, 1)) = 0.25
        _MaskMetallicR ("Mask R Metallic", Range(0, 1)) = 0
        _MaskAlbedoG ("Mask G Color", Color) = (0, 1, 0, 1)
        _MaskRoghnessG ("Mask G Roughness", Range(0, 1)) = 0.25
        _MaskMetallicG ("Mask G Metallic", Range(0, 1)) = 0
        _MaskAlbedoB ("Mask B Color", Color) = (0, 0, 1, 1)
        _MaskRoghnessB ("Mask B Roughness", Range(0, 1)) = 0.25
        _MaskMetallicB ("Mask B Metallic", Range(0, 1)) = 0
        [Toggle(_USE_DISTURB)] _UseDisturb ("溶解/Use Disturb", Float) = 0
        [ToggleUI] _Bi_Disturb ("Disturbe in 2 Direction", Float) = 0
        _DisturbTex ("Dissolve Disturb Tex", 2D) = "white" {}
        _DisturbUVSpeed ("Disturb UV Speed(XY:By Time,ZW:Unused)", Vector) = (0, 0, 0, 0)
        _DisturbUIntensity ("UIntensity", Float) = 0
        _DisturbVIntensity ("VIntensity", Float) = 0
        [Toggle(_PARALLAX_MAP)] _EnableParallaxMap ("视差/Parallax Map", Float) = 0
        _ParallaxMaskChannel ("自发光通道", Float) = 0
        [ToggleUI] _UseParallaxMask ("Use Parallax Mask 2U", Float) = 0
        _ParallaxNoiseMap ("Parallax Noise Map", 2D) = "black" {}
        _ParallaxNoiseMapTilling ("Parallax Noise Map Tilling", Range(0.01, 20)) = 1
        _ParallaxMaskMap ("Parallax Mask Map", 2D) = "black" {}
        [Enum(UV0, 0, UV1, 1)] _ParallaxMapUVType ("Parallax Map UV Type", Float) = 0
        _ParallaxMap ("Parallax Map", 2D) = "black" {}
        _ParallaxStrength ("Parallax Strength", Range(0, 1)) = 0
        _ParallaxMarchNum ("Parallax Ray March Num", Range(2, 5)) = 2
        _ParallaxTilling ("Parallax Tilling", Range(0.01, 20)) = 1
        [HDR] _ParallaxColor ("Parallax Color", Color) = (0, 0, 0, 1)
        [HDR] _ParallaxColorDark ("Parallax Color Dark", Color) = (0, 0, 0, 1)
        _ParallaxAnimSpeed ("Parallax Anim Speed", Range(0, 50)) = 0
        [ToggleUI] _ParallaxAnimRandom ("Parallax Anim Random", Float) = 0
        [ToggleUI] _ParallaxCharPos ("Parallax Affected By CharPos", Float) = 0
        _ParallaxBrightOuterRadius ("Parallax Bright OuterRadius", Range(0, 50)) = 20
        _ParallaxBrightInnerRadius ("Parallax Bright InnerRadius", Range(0, 50)) = 10
        _ParallaxBrightStrength ("Parallax Bright Strength", Range(0, 20)) = 1
        _ParallaxMinBrightness ("Parallax Min brightness", Range(0, 0.5)) = 0
        _ParallaxFresnelStrength ("Parallax Fresnel Strength", Range(0.001, 10)) = 1
        [ToggleUI] _ParallaxMaskByLayerBlend ("Parallax Mask By Layer Blend", Float) = 0
        [ToggleUI] _ParallaxIgnorePostExposure ("Parallax Ignore Post Exposure", Float) = 1
        [Toggle(_PARALLAX_MAP_WORLDSPACE)] _UseWorldSpaceParallaxMask ("Use World Space Parallax Mask", Float) = 0
        [HDR] _ParallaxPatternColor ("Parallax Pattern Color", Color) = (0, 0, 0, 1)
        [HDR] _ParallaxPatternColorDark ("Parallax Pattern Color Dark", Color) = (0, 0, 0, 1)
        _ParallaxMaskMapColorStrength ("Parallax MaskMap Color Strength", Range(0, 20)) = 1
        _ParallaxLerpSchedule ("Parallax Lerp Schedule", Range(0, 30)) = 0
        _MaskWorldPosParams ("xz-世界坐标xz，y旋转，w范围", Vector) = (0, 0, 0, 1)
        _ParallaxSignControl ("交互物信号控制", Float) = 0
        [HDR] _WorldParallaxAdditionalColor ("World Parallax Additional Color", Color) = (0, 0, 0, 1)
        _WorldParallaxAdditionalLightMaskChannel ("WorldParallax Additional Light Mask", Float) = 0
        _ParallaxSignLerpFactor0 ("交互物信号控制强度(1,2,3,4强度)", Vector) = (0, 0, 0, 0)
        _ParallaxSignLerpFactor2 ("交互物信号控制强度(5强度)", Float) = 0
        _ParallaxSignLerpFactor1 ("交互物信号控制强度(5强度,视差世界高度，暂空，视差本地颜色叠加范围)", Vector) = (0, 0, 0, 0)
        _ParallaxIntensity ("Parallax整体强度", Range(0, 1)) = 1
        [Toggle(_USE_DISSOLVE)] _UseDissolve ("溶解/Use Dissolve", Float) = 0
        _DissolveEdgeSharp ("Dissolve Edge Sharp", Float) = 0
        _DissolveScheduleOffset ("Dissolve Schedule Offset", Float) = 0
        _DissolveEmissiveEdge ("Dissolve Emissive Edge", Float) = 0
        _DissolveUVSpeed ("Dissolve UV Speed(XY:By Time)", Vector) = (0, 0, 0, 0)
        [HDR] _DissolveEmissiveColor ("Dissolve Emissive Color", Color) = (0, 0, 0, 1)
        _DissolveTex ("Dissolve Tex", 2D) = "white" {}
        [HideInInspector] _UseScanDissolve ("Use Scan Dissolve", Float) = 0
        _DissolveUVRotate ("DissolveUVRotate(Degree)", Float) = 0
        [ToggleUI] _DissolveTexUseDisturb ("Dissolve Tex Use Disturb", Float) = 0
        _DissolveDir ("Dissolve Dir", Vector) = (0, 0, 0, 0)
        [HideInInspector] _DissolveSpeed ("Dissolve Speed(XY:By Time,ZW:Unused)", Vector) = (0, 0, 0, 0)
        _DissolveScanSchedule ("Scan Schedule", Float) = -1
        _DissolveScanWidth ("Scan Width", Range(0.1, 1)) = 0
        _DissolveEmissiveWidth ("Emissive Width", Range(0, 5)) = 0
        [Toggle(_USE_VERTOFFSET)] _UseVertexOffset ("顶点相关/Use Vertex Offset", Float) = 0
        _OffsetTex ("Offset Tex", 2D) = "white" {}
        _OffsetSpeed ("Offset Speed(XY: By Time,ZW:By Custom)", Vector) = (0, 0, 0, 0)
        _OffsetDir ("Offset Dir(XYZ: Axis,W:By CustomY)", Vector) = (0, 0, 0, 0)
        [Enum(Object, 0, World, 1, Normal, 2)] _OffsetSwitchDir ("Dir Switcher", Float) = 0
        _OffsetIntensity ("Offset Intensity", Float) = 0
        [ToggleUI] _Bi_Offset ("Use Two Direction Offset", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _OffsetUVSet ("Vertex Offset UV Set", Float) = 0
        [ToggleUI] _UseVertexColorMask ("以顶点色(A通道)为顶点偏移遮罩", Float) = 0
        // _USE_VERTOFFSETMASK/_OffsetMaskTex 系: 本家族任何 pass 都不编译该 keyword(骨架 L232-250)
        // = 出货 no-op;属性保留供材质数据兼容, 逻辑不移植。
        [ToggleUI] _UseVertexOffsetMask ("使用顶点偏移遮罩贴图(本家族出货未编译)", Float) = 0
        _OffsetMaskTex ("Offset Mask Tex", 2D) = "white" {}
        _OffsetMaskSpeed ("Offset Mask Speed(XY: By Time,ZW:By Custom)", Vector) = (0, 0, 0, 0)
        _OffsetMaskPower ("Offset Mask Power", Range(0, 5)) = 0
        _EnableHoudiniVAT ("顶点相关/Houdini VAT", Float) = 0
        // 材质系统按此枚举切 _VAT_RIGIDBODY/_VAT_SOFTBODY keyword(骨架 L148)
        [Enum(RigidBody, 0, SoftBody, 1)] _HoudiniVATType ("VAT类型", Float) = 0
        [ToggleUI] _HoudiniVATInParticle ("在粒子系统中使用Houdini VAT", Float) = 0
        [ToggleUI] _B_autoPlayback ("Auto Playback", Float) = 0
        _gameTimeAtFirstFrame ("Game Time at First Time", Float) = 0
        _displayFrame ("Display Frame", Float) = 0
        _playbackSpeed ("Playback Speed", Float) = 0
        _houdiniFPS ("Houdini FPS", Float) = 0
        [ToggleUI] _TextureFormat ("Texture Format(On:HDR;Off:LDR)", Float) = 1
        _PositionTexture ("Position Texture", 2D) = "white" {}
        [ToggleUI] _BlendMeshNormalAndTangent ("使用Mesh的Normal和Tangent", Float) = 0
        [Toggle(_UNLOAD_ROT_TEX)] _B_UNLOAD_ROT_TEX ("使用压缩ROT(存在PosTex.a)", Float) = 0
        _RotationTexture ("Rotation Texture", 2D) = "white" {}
        [ToggleUI] _B_surfaceNormals ("Support Surface Normal Maps", Float) = 0
        [ToggleUI] _B_twoSidedNorms ("Two Sided Normals", Float) = 0
        [ToggleUI] _B_pscaleAreInPosA ("Piece Scales Are In Position Alpha", Float) = 0
        _globalPscaleMul ("Global Piece Scale Multiplier", Float) = 1
        [ToggleUI] _B_stretchByVel ("Stretch by Velocity", Float) = 0
        _stretchByVelAmount ("Stretch by Velocity Amount", Float) = 0
        [ToggleUI] _B_animateFirstFrame ("Animate First Frame", Float) = 0
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Alpha Test", Float) = 0
        _AlphaMaskChannel ("透贴通道(0=BaseColor A/1=NRO A)", Float) = 0
        _AlphaClipThreshold ("Clip Threshold", Range(0, 1)) = 0.5
        // _UV_ANIMATION: 本家族任何 pass 都不编译该 keyword = 出货 no-op;属性保留。
        [ToggleUI] _EnableUVAnimation ("UV动画(本家族出货未编译)", Float) = 0
        _UVAnimationSpeed ("速度，xy是第1套UV，zw是第2套UV", Vector) = (0, 0, 0, 0)
        _AdvancedOptions ("Advanced Options", Float) = 0
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        _DitherScale ("Dither Scale", Range(0, 1)) = 1
        [ToggleUI] _DisableVerticalOcclusion ("不参与雨遮蔽", Float) = 0
        _VerticalOcclusionDepthBias ("雨遮蔽偏移", Range(0, 0.3)) = 0
        [HideInInspector] _CutOffPosY ("_CutOffPosY", Float) = 0
        [HideInInspector] _UseCutOff ("_UseCutOff", Float) = 0
        [HideInInspector] _CutOffDirection ("_CutOffDirection", Vector) = (0, 1, 0, 0)
        _EnableInstancing ("Enable GPU Instancing", Float) = 0
        [ToggleUI] _TAAUNormalBiasReverse ("TAAU Normal偏移补偿", Float) = 0
        [ToggleUI] _ReceiveDecals ("Receive Decals", Float) = 1
        [ToggleUI] _UseSceneEffect ("Use SceneEffect(Dark)", Float) = 1
        [ToggleUI] _EnableBakedEmissive ("Enable Baked Emissive", Float) = 0
        [HideInInspector] _DirectLightRoughnessOffset ("(Hack) Direct Light Roughness Offset", Range(-1, 1)) = 0
        [HideInInspector] _DitherTransparentAlpha ("Dither Transparent Alpha", Range(0, 1)) = 1
        [HideInInspector] _DitherTransparentOffset ("Dither Transparent Offset", Range(0, 1)) = 0.1
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _StencilOpGBuffer ("__stencilOpGBuffer", Float) = 2
        [HideInInspector] _StencilOpPreZ ("__stencilOpPreZ", Float) = 0
        [HideInInspector] _ZTestGBuffer ("_ZTestGBuffer", Float) = 4
        [HideInInspector] _ShadingModel ("_ShadingModel", Float) = 0
        [HideInInspector] _HlodBakeMaxEmissiveIntensity ("_HlodBakeMaxEmissiveIntensity", Float) = 0
        [HideInInspector] _UseDeferredRendering ("Render Mode", Float) = 1
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
        [HideInInspector] _frameCount ("Frame Count", Float) = 0
        [HideInInspector] _boundMaxX ("Bound Max X", Float) = 0
        [HideInInspector] _boundMaxY ("Bound Max Y", Float) = 0
        [HideInInspector] _boundMaxZ ("Bound Max Z", Float) = 0
        [HideInInspector] _boundMinX ("Bound Min X", Float) = 0
        [HideInInspector] _boundMinY ("Bound Min Y", Float) = 0
        [HideInInspector] _boundMinZ ("Bound Min Z", Float) = 0
        // ---- URP 移植追加(引擎全局 dial 的材质级中性落位, 与 lit.shader 同) ----
        [HideInInspector] _EnvironmentGlobalParams0 ("EnvGlobalParams0", Vector) = (1, 1, 1, 0)
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Opaque"
            "Queue" = "Geometry"
        }
        LOD 600

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"

        // ====================================================================================
        // UnityPerMaterial — liteffect 家族 uniform 全集(单 CBUFFER, SRP Batcher)。
        // 反编译 CB 槽名跨变体混叠, 一律按公式角色回填真名(与骨架 Properties 对照)。
        // ====================================================================================
        CBUFFER_START(UnityPerMaterial)
            // ---- 基面 ----
            float4 _BaseColor;
            float4 _BaseColorMap_ST;
            float4 _NormalMap_ST;
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
            float _PorosityFactorX;
            float _PorosityFactorY;
            float _DisableVerticalOcclusion;
            float _VerticalOcclusionDepthBias;
            float _AlphaMaskChannel;
            float _AlphaClipThreshold;
            float _DitherScale;
            float _UseSceneEffect;
            float _DirectLightRoughnessOffset;   // 死: 本家族无前向真值, hack 只在 liteffectblend 生效
            // ---- 自发光家族(带 _EmissiveRemap 尾乘) ----
            float4 _EmissiveMap_ST;
            float4 _EmissiveColor;
            float4 _EmissiveColorG;
            float4 _EmissiveColorB;
            float4 _EmissiveColorA;
            float4 _EmissiveSpeed;
            float _EnableEmissiveMap;    // MASK 路径乘数真身(liteffect b209:185 交叉证)
            float _EmissiveUVSet;
            float _EmissiveType;
            float _EmissiveMaskChannel;
            float _EmissiveRemap;
            float _AlbedoAffectEmissive;
            float _IgnorePostExposure;
            float _EmissiveMapTilling;
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
            // ---- 细节贴图 ----
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
            // ---- 三通道 Mask ----
            float4 _MaskMap_ST;
            float4 _MaskAlbedoR;
            float4 _MaskAlbedoG;
            float4 _MaskAlbedoB;
            float _MaskUVSet;
            float _MaskRScale;      // liteffect 骨架无 Scale/Offset 滑杆(lit 家族有), 材质默认 0 → 公式退化 sat(mask.c)×w; 槽保留=公式载体
            float _MaskROffset;
            float _MaskRoghnessR;
            float _MaskMetallicR;
            float _MaskGScale;
            float _MaskGOffset;
            float _MaskRoghnessG;
            float _MaskMetallicG;
            float _MaskBScale;
            float _MaskBOffset;
            float _MaskRoghnessB;
            float _MaskMetallicB;
            // ---- 视差自发光 / 世界空间视差 ----
            float4 _ParallaxColor;
            float4 _ParallaxColorDark;
            float4 _ParallaxPatternColor;
            float4 _ParallaxPatternColorDark;
            float4 _MaskWorldPosParams;          // xz=世界中心 y=旋转(度) w=范围(极坐标缩放, ≥0.1)
            float4 _ParallaxSignLerpFactor0;     // 交互信号 1-4 强度
            float4 _ParallaxSignLerpFactor1;     // .y=视差世界高度带阈值(b333:441) .w=主项高度门参数(b333:1177 角色回填)
            float4 _WorldParallaxAdditionalColor;
            float _ParallaxMaskChannel;
            float _UseParallaxMask;
            float _ParallaxNoiseMapTilling;
            float _ParallaxMapUVType;
            float _ParallaxStrength;
            float _ParallaxMarchNum;             // 出货 CB 存 int 位型(b221:254 float(asuint())); URP Float 数值等价直用
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
            float _ParallaxSignLerpFactor2;      // 交互信号 5 强度
            float _ParallaxIntensity;
            // ---- 扰动 / 溶解 ----
            float4 _DisturbTex_ST;
            float4 _DisturbUVSpeed;
            float4 _DissolveTex_ST;
            float4 _DissolveUVSpeed;
            float4 _DissolveEmissiveColor;
            float4 _DissolveDir;
            float4 _DissolveSpeed;               // 死 uniform(隐藏属性, blob 无读取)
            float _Bi_Disturb;
            float _DisturbUIntensity;
            float _DisturbVIntensity;
            float _DissolveEdgeSharp;
            float _DissolveScheduleOffset;
            float _DissolveEmissiveEdge;         // 死 uniform(blob 无读取)
            float _UseScanDissolve;              // 死 uniform
            float _DissolveUVRotate;
            float _DissolveTexUseDisturb;
            float _DissolveScanSchedule;
            float _DissolveScanWidth;
            float _DissolveEmissiveWidth;
            // ---- 顶点偏移 ----
            float4 _OffsetTex_ST;
            float4 _OffsetSpeed;
            float4 _OffsetDir;
            float _OffsetSwitchDir;
            float _OffsetIntensity;
            float _Bi_Offset;
            float _OffsetUVSet;
            float _UseVertexColorMask;
            // ---- Houdini VAT ----
            float _HoudiniVATType;
            float _HoudiniVATInParticle;         // VAT uv 源: on=uv0.zw/uv1.w, off=uv1.xy(b268:546 真名)
            float _B_autoPlayback;
            float _gameTimeAtFirstFrame;
            float _displayFrame;
            float _playbackSpeed;
            float _houdiniFPS;
            float _TextureFormat;                // On:HDR(原始浮点, 免 bounds/0.5 解码) Off:LDR(b268:547 真名)
            float _BlendMeshNormalAndTangent;    // VAT 基向 mesh 基的 lerp 因子(b516:603-605/668 槽角色回填)
            float _B_surfaceNormals;             // VAT 法线 mask 门(b516:598 槽角色回填)
            float _B_twoSidedNorms;              // 死: 出货 blob 无读取
            float _B_pscaleAreInPosA;            // 死
            float _globalPscaleMul;
            float _B_stretchByVel;               // 死
            float _stretchByVelAmount;           // 死
            float _B_animateFirstFrame;
            float _frameCount;
            float _boundMaxX;                    // 整数位=界, 小数位藏 V 翻转系数(b516:566)
            float _boundMaxY;
            float _boundMaxZ;
            float _boundMinX;
            float _boundMinY;
            float _boundMinZ;                    // 小数位藏 U pad 系数(b516:563)
            // ---- 杂项 ----
            float _DitherTransparentAlpha;
            float _DitherTransparentOffset;
            float _CutOffPosY;
            float _UseCutOff;
            float4 _CutOffDirection;
            // HG 引擎全局 dial 的材质级落位(URP 无对应全局;默认中性 1,1)
            float4 _EnvironmentGlobalParams0;
        CBUFFER_END

        // ====================================================================================
        // 引擎面全局(HG VFX 系统喂入;URP 宿主可 Shader.SetGlobalVector 供给, 未设时:
        //   _VFXParams0=0 → 角色距离环仅在 _ParallaxCharPos 门开时以原点为球心退化;
        //   _VFXParams2=0 → 交互信号环 sat(-inf)=0 自然消隐)。.w 时间槽已换 _Time.y 不经此变量。
        // ====================================================================================
        float4 _VFXParams0;   // xyz = 角色世界位置(视差亮环球心, b221:327-330)
        float4 _VFXParams2;   // xy = 交互信号世界 XZ, z = 半径, w = 强度(b221:331-334)

        // ====================================================================================
        // 纹理绑定(逐纹理 sampler;反编译 sampler 名跨纹理乱接线, 语义以贴图导入设置为准)
        // ====================================================================================
        TEXTURE2D(_BaseColorMap);     SAMPLER(sampler_BaseColorMap);
        TEXTURE2D(_NormalMap);        SAMPLER(sampler_NormalMap);
        TEXTURE2D(_MROMap);           SAMPLER(sampler_MROMap);
        TEXTURE2D(_EmissiveMap);      SAMPLER(sampler_EmissiveMap);
        TEXTURE2D(_DetailMap);        SAMPLER(sampler_DetailMap);
        TEXTURE2D(_MaskMap);          SAMPLER(sampler_MaskMap);
        TEXTURE2D(_ParallaxMap);      SAMPLER(sampler_ParallaxMap);
        TEXTURE2D(_ParallaxNoiseMap); SAMPLER(sampler_ParallaxNoiseMap);
        TEXTURE2D(_ParallaxMaskMap);  SAMPLER(sampler_ParallaxMaskMap);
        TEXTURE2D(_DisturbTex);       SAMPLER(sampler_DisturbTex);
        TEXTURE2D(_DissolveTex);      SAMPLER(sampler_DissolveTex);
        TEXTURE2D(_OffsetTex);        SAMPLER(sampler_OffsetTex);
        TEXTURE2D(_PositionTexture);  SAMPLER(sampler_PositionTexture);
        TEXTURE2D(_RotationTexture);  SAMPLER(sampler_RotationTexture);
        // 视差噪声 march 累加 UV 会越界 → 点采样 + repeat(b221:294 SampleGrad Point*)
        SamplerState hg_point_repeat_sampler;
        // VAT 纹理采样态(b516:136-139 声明序): 位置=LinearClamp, 旋转=LinearRepeat
        SamplerState hg_linear_clamp_sampler;
        SamplerState hg_linear_repeat_sampler;

        // ====================================================================================
        // 反编译幻数常量(位型逐位保留)
        // ====================================================================================
        static const float HG_EPS_VIEWLEN   = 9.9999999392252902907785028219223e-09; // 1e-8 视向量 rsqrt 守卫, b11:258
        static const float HG_EPS_NORMAL_Z  = 1.000000016862383526387164645044e-16;  // 1e-16 法线 Z 下限, b283:177
        static const float HG_EPS_HALF      = 6.103515625e-05;                        // 2^-14 半精度 rsqrt 守卫, b11:929
        static const float HG_EPS_VIS       = 9.9999997473787516355514526367188e-05;  // 1e-4 Smith Vis 分母下限, b11:961
        static const float HG_DIELECTRIC_F0 = 0.07999999821186065673828125;           // 0.08*_Specular 电介质 F0 基, b11:298
        static const float HG_GRAZING_FLOOR = 0.0476190485060214996337890625;          // 1/21 多散射掠射地板, b11:957
        static const float HG_NORMAL_DEADZONE = 0.01200000010430812835693359375;       // 法线死区, b191:160
        static const float HG_VAT_UNPACK_31_5 = 0.12698413431644439697265625;          // 4/31.5, UNLOAD 法线解包, b308:562

        // ====================================================================================
        // 顶点输入/插值器。VAT 需要 4 分量 UV 流(uv0.zw/uv1.zw=VAT 索引与帧, uv2/uv3=刚体 pivot,
        // b290:173-180 attributes float4×5);GPU skinning 分支=引擎面, URP 原生蒙皮前置替代。
        // ====================================================================================
        struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS   : NORMAL;
            float4 tangentOS  : TANGENT;
            float4 color      : COLOR;
            float4 uv0        : TEXCOORD0;   // xy=材质 UV0; zw=VAT uv(粒子模式, b268:546/562)
            float4 uv1        : TEXCOORD1;   // xy=材质 UV1/VAT uv; w=VAT 逐粒子帧(b268:550)
            float4 uv2        : TEXCOORD2;   // 刚体 pivot: x=-pivotX; zw=粒子模式 pivotYZ 源(b290:631-633)
            float4 uv3        : TEXCOORD3;   // 刚体 pivot: x=pivotY, y=1-pivotZ(非粒子)
            UNITY_VERTEX_INPUT_INSTANCE_ID
        };

        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float3 positionWS : TEXCOORD0;
            float4 uv         : TEXCOORD1;   // .xy=uv0 .zw=uv1 (raw; _ST/UV 集选择在片元)
            float3 normalWS   : TEXCOORD2;
            float4 tangentWS  : TEXCOORD3;   // .w = 切线符号(VAT 下已含 _BlendMeshNormalAndTangent 折算)
            float4 color      : TEXCOORD4;
            float  fogFactor  : TEXCOORD5;
            UNITY_VERTEX_INPUT_INSTANCE_ID
            UNITY_VERTEX_OUTPUT_STEREO
        };

        struct HgSurface
        {
            float3 albedo;
            float3 normalWS;
            float  metallic;
            float  roughness;
            float  occlusion;
            float3 emission;
            float  alpha;
            float3 f0;
            float3 diffuse;
        };

        // ====================================================================================
        // 基础工具(litforward b11 逐位, 家族共享织物)
        // ====================================================================================
        float4 HgViewDirWS(float3 positionWS)
        {
            float3 raw;
            if (unity_OrthoParams.w == 0.0)
                raw = _WorldSpaceCameraPos - positionWS;
            else
                raw = float3(-UNITY_MATRIX_V[2].x, -UNITY_MATRIX_V[2].y, -UNITY_MATRIX_V[2].z);
            float distSq = dot(raw, raw);
            float invLen = rsqrt(max(distSq, HG_EPS_VIEWLEN));
            return float4(raw * invLen, invLen * distSq);
        }

        void HgEnvBRDF(float roughness, float NoV, float3 f0, out float envScale, out float envBias)
        {
            float omr  = mad(roughness, -1.0, 1.0);
            float envF = mad(min(omr * omr, exp2(NoV * -9.27999973297119140625)), omr,
                             mad(roughness, -0.0274999998509883880615234375, 0.0425000004470348358154296875));
            envScale = mad(envF, -1.03999996185302734375, mad(roughness, -0.572000026702880859375, 1.03999996185302734375));
            envBias  = mad(envF,  1.03999996185302734375, mad(roughness,  0.02199999988079071044921875, -0.039999999105930328369140625))
                     * saturate(f0.g * 50.0);
        }

        float HgEnvBRDFApproxDFG(float roughness)
        {
            float t = mad(roughness, -1.0, 1.0);
            return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875, -0.076194703578948974609375),
                                  1.04997003078460693359375), 0.4092549979686737060546875),
                       0.999000012874603271484375);
        }

        // 单光源能量括号(b11:944-965 == b11:1198-1214 点光同式)
        float3 HgDirectLightEnergy(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
        {
            float a2 = (roughness * roughness) * (roughness * roughness);
            float nv = min(NoV, 1.0);
            float d  = mad(mad(NoH, a2, -NoH), NoH, 1.0);
            float visDenom = nv  * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2))
                           + NoL * sqrt(mad(mad(-nv,  a2, nv),  nv,  a2))
                           + HG_EPS_VIS;
            float DVis = (a2 / (d * d)) * (0.5 / visDenom);

            float omVoH = mad(-VoH, 1.0, 1.0);
            float sq    = omVoH * omVoH;
            float quad  = sq * sq;
            float Fc    = omVoH * quad;
            float omFc  = mad(-quad, omVoH, 1.0);

            float  dfg   = HgEnvBRDFApproxDFG(roughness);
            float  omDfg = mad(-dfg, 1.0, 1.0);
            float  dfgE  = dfg / omDfg;
            float3 gz    = mad(1.0.xxx - f0, HG_GRAZING_FLOOR, f0);
            float3 msDiff = (dfgE * (gz * gz)) / mad(-gz, omDfg, 1.0.xxx);
            float3 specE  = DVis * mad(f0, omFc.xxx, Fc.xxx);
            return min(max(msDiff + min(specE, 2048.0.xxx), 0.0.xxx), 1000.0.xxx);
        }

        // ====================================================================================
        // Houdini VAT 顶点模块(对象空间整体改写)。
        //   帧钟/图集 UV: b268:546-566(liteffect 真源, 时钟 _VFXParams0.w→_Time.y,
        //     逐实例帧偏移 Float4x5_Param3.x=SceneEffect per-draw→中性 0)。
        //   软体: b516:560-668(lit 同织物交叉证)。刚体: b290:558-720。压缩旋转: b308:561-584。
        //   bounds 整数位=包围盒, 小数位藏系数: U pad=mad(_boundMinZ,10,-ceil(10*_boundMinZ))+1;
        //     V 翻转=mad(_boundMaxX,10,1)+floor(-10*_boundMaxX)。
        // ====================================================================================
        #if defined(_VAT_SOFTBODY) || defined(_VAT_RIGIDBODY)

        // 软体四元数旋转基(b516:591-597/621-627 展开式逐位):
        //   法线 = R(q)·(-1,0,0), 切线 = R(q)·(0,1,0)
        float3 HgVatSoftRotateNormal(float4 q)
        {
            return float3(mad(2.0, q.y * q.y + q.z * q.z, -1.0),                 // b516:594 (_878)
                          -2.0 * (q.x * q.y + q.w * q.z),                        // b516:595 (_879)
                          2.0 * (q.w * q.y - q.x * q.z));                        // b516:596 (_880)
        }
        float3 HgVatSoftRotateTangent(float4 q)
        {
            return float3(2.0 * (q.x * q.y - q.z * q.w),                         // b516:624 (_1050)
                          mad(-2.0, q.x * q.x + q.z * q.z, 1.0),                 // b516:625 (_1051)
                          2.0 * (q.w * q.x + q.y * q.z));                        // b516:626 (_1052)
        }

        // 刚体旋转(b290:634-641 专用 mad 型, 分量置换随小三分量存储布局, 逐位保形):
        float3 HgVatRigidRotate(float4 q, float3 v)
        {
            float t1 = mad(v.y, q.w, mad(q.x, v.x, -(v.z * q.y)));               // b290:634 (_1184)
            float t2 = mad(v.z, q.w, mad(q.y, v.y, -(v.x * q.z)));               // b290:635 (_1185)
            float t3 = mad(v.x, q.w, mad(q.z, v.z, -(v.y * q.x)));               // b290:636 (_1186)
            return float3(mad(mad(q.z, t2, -(q.x * t1)), 2.0, v.x),              // b290:637 (_1214 内层)
                          mad(mad(q.x, t3, -(q.y * t2)), 2.0, v.y),              // b290:638 (_1215 内层)
                          mad(mad(q.y, t1, -(q.z * t3)), 2.0, v.z));             // b290:639 (_1216 内层)
        }

        void HgApplyHoudiniVat(Attributes IN, inout float3 positionOS, inout float3 normalOS, inout float4 tangentOS)
        {
            bool inParticle = _HoudiniVATInParticle != 0.0;                       // b268:546 (_636)
            bool hdr        = _TextureFormat != 0.0;                              // b268:547 (_637)
            float uvY = inParticle ? IN.uv0.w : IN.uv1.y;                         // b516:562 (_659)

            // 帧: 自动播放=floor(frac(fps/(cnt-0.01)*(t-t0)*speed)*cnt)+1;
            //     手动=floor([粒子帧 uv1.w] + 逐实例偏移(中性0) + _displayFrame) (b268:550/b290:561)
            float frameRaw = (_B_autoPlayback != 0.0)
                ? floor(frac(((_houdiniFPS / (-0.00999999977648258209228515625 + _frameCount))
                              * (_Time.y - _gameTimeAtFirstFrame)) * _playbackSpeed) * _frameCount) + 1.0
                : floor((inParticle ? IN.uv1.w : 0.0) + _displayFrame);
            float frame01 = (frameRaw - 1.0) / _frameCount;                       // b516:564 (_746)
            float fracF   = frac(abs(frame01));                                   // b516:565
            float signedF = (frame01 >= -frame01) ? fracF : -fracF;               // b516:566 符号保形 frac

            float uPad  = mad(_boundMinZ, 10.0, -ceil(10.0 * _boundMinZ)) + 1.0;  // b516:563 小数位解码
            float vFlip = mad(_boundMaxX, 10.0, 1.0) + floor(-10.0 * _boundMaxX); // b516:566 小数位解码
            float2 vatUV;
            vatUV.x = (inParticle ? IN.uv0.z : IN.uv1.x) * uPad;                  // b516:563 (_679)
            vatUV.y = mad(-vFlip, ((signedF * _frameCount) / _frameCount) + (1.0 - uvY), 1.0); // b516:566 (_763)

            float4 posTex = SAMPLE_TEXTURE2D_LOD(_PositionTexture, hg_linear_clamp_sampler, vatUV, 0.0); // b516:567 (t1)
            bool keepRest = 0.100000001490116119384765625 >= uvY;                 // b516:571 (_799) V≈0 行

            float blendMesh = _BlendMeshNormalAndTangent;
            float maskN = (_B_surfaceNormals != 0.0) ? 1.0 : 0.0;                 // b516:598 (_892 掩码)

        #if defined(_VAT_SOFTBODY)
            // ---- 软体: 位置差 + 四元数旋转基 ----
            float3 posDelta = hdr ? posTex.xyz
                : float3(mad(_boundMaxX - _boundMinX, posTex.x, _boundMinX),      // b516:572 (_819)
                         mad(_boundMaxY - _boundMinY, posTex.y, _boundMinY),      // b516:574 (_821, _boundMaxY=槽角色回填)
                         mad(_boundMaxZ - _boundMinZ, posTex.z, _boundMinZ));     // b516:576 (_823)
            // V≤0.1 行塌到原点(出货行为保形, b516:572 _799?0:...)
            float3 vatPos = keepRest ? float3(0.0, 0.0, 0.0) : (posDelta + positionOS);

            float3 vatN;
            float3 vatT;
        #if defined(_UNLOAD_ROT_TEX)
            // 压缩旋转: posTex.a 十位(5+5) Lambert 方位角法线(b308:561-565,581-584); 切线无 VAT 源
            {
                float high = floor(posTex.w * 32.0);                              // b308:561 (_814)
                float f1 = mad(high, HG_VAT_UNPACK_31_5, -2.0);                   // b308:562 (_817)
                float f2 = mad(mad(-high, 32.0, posTex.w * 1024.0), HG_VAT_UNPACK_31_5, -2.0); // b308:563 (_820)
                float negSum = -dot(float2(f1, f2), float2(f1, f2));              // b308:564 (_824)
                float s = sqrt(mad(negSum, 0.25, 1.0));                           // b308:565 (_829)
                vatN = float3(min(max(-(f1 * s), -1.0), 1.0),                     // b308:581 (_945)
                              min(max(mad(negSum, 0.5, 1.0), -1.0), 1.0),         // b308:582 (_946)
                              min(max(f2 * s, -1.0), 1.0));                       // b308:583 (_947)
                vatN *= rsqrt(dot(vatN, vatN));                                   // b308:584 (_951)
                vatT = float3(0.0, 0.0, 0.0);                                     // b308:566-568: 切线=mesh 切线×blend
            }
        #else
            {
                float4 rotTex = SAMPLE_TEXTURE2D_LOD(_RotationTexture, hg_linear_repeat_sampler, vatUV, 0.0); // b516:578 (t2)
                float4 q = hdr ? rotTex : (rotTex - 0.5) * 2.0;                   // b516:583-590
                float3 rn = HgVatSoftRotateNormal(q);
                float3 rt = HgVatSoftRotateTangent(q);
                vatN = rn * rsqrt(dot(rn, rn));                                   // b516:597 (_884)
                vatT = rt * rsqrt(dot(rt, rt));                                   // b516:627 (_1056)
            }
        #endif
            positionOS = vatPos;
            // lerp(掩码后 VAT 基, mesh 基, _BlendMeshNormalAndTangent) (b516:603-605 / 628-630;
            // 实例矩阵 1/‖col‖² 因子随归一化消去, 注)
            normalOS      = lerp(vatN * maskN, normalOS, blendMesh);
            tangentOS.xyz = lerp(vatT * maskN, tangentOS.xyz, blendMesh);
            tangentOS.w   = lerp(0.0, tangentOS.w, blendMesh);                    // b516:668 (符号项由 TBN 期 GetOddNegativeScale 施加)
        #endif // _VAT_SOFTBODY

        #if defined(_VAT_RIGIDBODY)
            // ---- 刚体: 小三分量四元数 + pivot 旋转 ----
            float4 rotTexR = SAMPLE_TEXTURE2D_LOD(_RotationTexture, hg_linear_repeat_sampler, vatUV, 0.0); // b290:570 (t2)
            // 解码顺序保形: a←tex.z, b←tex.x, c←tex.y (b290:577-582)
            float qa = hdr ? rotTexR.z : (rotTexR.z - 0.5) * 2.0;                 // (_822)
            float qb = hdr ? rotTexR.x : (rotTexR.x - 0.5) * 2.0;                 // (_824)
            float qc = hdr ? rotTexR.y : (rotTexR.y - 0.5) * 2.0;                 // (_826)
            float qBig = sqrt(mad(-qa, qa, mad(-qc, qc, mad(-qb, qb, 1.0))));     // b290:583 (_833)
            // posTex.a×4 = 最大分量索引 → 分量重组(b290:588-630 switch 逐位)
            float4 q;
            switch (uint(int(floor(posTex.w * 4.0))))
            {
                case 0u:  q = float4(qa, qb, qc, qBig);   break;
                case 1u:  q = float4(qa, qBig, qc, qb);   break;
                case 2u:  q = float4(qa, qb, -qBig, -qc); break;
                case 3u:  q = float4(-qBig, qb, qc, -qa); break;
                default:  q = float4(qa, qb, qc, qBig);   break;
            }
            // pivot(写入 uv2/uv3): (-uv2.x, [粒子?uv2.z:uv3.x], 1-[粒子?uv2.w:uv3.y]) (b290:631-633)
            float3 offset;
            offset.x = IN.uv2.x + positionOS.x;                                   // b290:631 (_1172, pivotX=-uv2.x)
            offset.y = positionOS.y - (inParticle ? IN.uv2.z : IN.uv3.x);         // b290:632 (_1173)
            offset.z = positionOS.z - (1.0 - (inParticle ? IN.uv2.w : IN.uv3.y)); // b290:633 (_1174)
            float3 rotated = HgVatRigidRotate(q, offset);
            float3 posDecodedR = hdr ? posTex.xyz
                : float3(mad(posTex.x, _boundMaxX - _boundMinX, _boundMinX),      // b290:637 (_1214 尾)
                         mad(posTex.y, _boundMaxY - _boundMinY, _boundMinY),
                         mad(posTex.z, _boundMaxZ - _boundMinZ, _boundMinZ));
            float3 vatPosR = mad(_globalPscaleMul.xxx, rotated, posDecodedR);     // b290:637-639

            // 帧 1 守卫: 非 animateFirstFrame 且当前帧=1 → 保持原 mesh 位(b290:640-649)
            float fr01 = frameRaw / _frameCount;                                  // b290:641 (_1224)
            float frF  = frac(abs(fr01));
            bool isFrame1 = (((fr01 >= -fr01) ? frF : -frF) * _frameCount) == 1.0; // b290:643 (_1235)
            float3 finalPos = (_B_animateFirstFrame != 0.0) ? vatPosR : (isFrame1 ? positionOS : vatPosR);
            positionOS = keepRest ? float3(0.0, 0.0, 0.0) : finalPos;             // b290:645-649

            float3 rnR = HgVatRigidRotate(q, normalOS);                           // b290:652-660
            float3 rtR = HgVatRigidRotate(q, tangentOS.xyz);                      // b290:678-688
            normalOS      = lerp((rnR * rsqrt(dot(rnR, rnR))) * maskN, normalOS, blendMesh);      // b290:661-671
            tangentOS.xyz = lerp((rtR * rsqrt(dot(rtR, rtR))) * maskN, tangentOS.xyz, blendMesh); // b290:689-699
            tangentOS.w   = lerp(0.0, tangentOS.w, blendMesh);                    // b290:707 (TEXCOORD_5_1.w)
        #endif // _VAT_RIGIDBODY
        }
        #endif // VAT

        // 对象空间顶点动画(VAT 整体改写)
        void HgApplyVertexAnimationOS(Attributes IN, inout float3 positionOS, inout float3 normalOS, inout float4 tangentOS)
        {
        #if defined(_VAT_SOFTBODY) || defined(_VAT_RIGIDBODY)
            HgApplyHoudiniVat(IN, positionOS, normalOS, tangentOS);
        #endif
        }

        // 世界空间加性位移(_USE_VERTOFFSET, lit b508 同织物; 本家族无 MASK 变体)
        float3 HgVertexAnimationDeltaWS(Attributes IN, float3 positionWS, float3 normalWS)
        {
            float3 deltaWS = float3(0.0, 0.0, 0.0);
        #ifdef _USE_VERTOFFSET
            {
                float2 uvSel = mad(IN.uv1.xy, _OffsetUVSet.xx, (1.0 - _OffsetUVSet) * IN.uv0.xy);       // b508:259-261
                float2 offUV = mad(uvSel, _OffsetTex_ST.xy, _OffsetTex_ST.zw) + _OffsetSpeed.xy * _Time.y; // b508:260-261
                float offsetScalar = mad(SAMPLE_TEXTURE2D_LOD(_OffsetTex, sampler_OffsetTex, offUV, 0.0).x,
                                         1.0 + _Bi_Offset, -_Bi_Offset);                                 // b508:262
                float3 dirWS;
                if (_OffsetSwitchDir == 1.0)
                    dirWS = _OffsetDir.xyz;                                                              // World
                else if (_OffsetSwitchDir == 2.0)
                    dirWS = TransformObjectToWorldDir(IN.normalOS, false);                               // Normal(正变换)
                else
                    dirWS = TransformObjectToWorldDir(_OffsetDir.xyz, false);                            // Object
                dirWS *= _OffsetIntensity;
                float vertexColorMask = (0.0 < _UseVertexColorMask) ? IN.color.w : 1.0;                  // b508:273
                float perDrawScale = 1.0 - unity_ObjectToWorld._m01;                                     // b508:274 per-draw 项
                deltaWS += dirWS * (offsetScalar * vertexColorMask * perDrawScale);                      // b508:588-590
            }
        #endif
            return deltaWS;
        }

        // 共享顶点内核
        Varyings HgVertexCore(Attributes IN)
        {
            Varyings OUT = (Varyings)0;
            UNITY_SETUP_INSTANCE_ID(IN);
            UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
            UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);

            float3 positionOS = IN.positionOS;
            float3 normalOS   = IN.normalOS;
            float4 tangentOS  = IN.tangentOS;
            HgApplyVertexAnimationOS(IN, positionOS, normalOS, tangentOS);

            float3 positionWS = TransformObjectToWorld(positionOS);
            float3 normalWS   = TransformObjectToWorldNormal(normalOS);
            float3 tangentWS  = TransformObjectToWorldDir(tangentOS.xyz);
            positionWS += HgVertexAnimationDeltaWS(IN, positionWS, normalWS);

            OUT.positionWS = positionWS;
            OUT.positionCS = TransformWorldToHClip(positionWS);
            OUT.normalWS   = normalWS;
            OUT.tangentWS  = float4(tangentWS, tangentOS.w * GetOddNegativeScale()); // b290:707 flip 符号同义
            OUT.uv         = float4(IN.uv0.xy, IN.uv1.xy);
            OUT.color      = IN.color;
            OUT.fogFactor  = ComputeFogFactor(OUT.positionCS.z);
            return OUT;
        }

        // 片元 UV 派生(b11:263-267 同织物)
        void HgComputeBaseUVs(float4 uv, out float2 uvBase, out float2 uvPbr)
        {
            float2 duv = uv.zw - uv.xy;
            uvBase = mad(mad(_BaseUVSet.xx,       duv, uv.xy), _BaseColorMap_ST.xy, _BaseColorMap_ST.zw);
            uvPbr  = mad(mad(_BasePbrMapUVSet.xx, duv, uv.xy), _NormalMap_ST.xy,    _NormalMap_ST.zw);
        }

        // ====================================================================================
        // 溶解值(liteffect b249/b259 逐位): 供主 pass(边带+clip)与 DepthOnly(clip)共用。
        //   uv=(uv0×_DissolveTex_ST+速度×t)−0.5 → 旋转(π/180) → +0.5 [+扰动];
        //   dissolve = tex − mad(Param4.x(中性0)+_DissolveScheduleOffset, 2.02, −1.01)
        //            + dot(P−objOrigin, O2W·_DissolveDir)/_DissolveScanWidth − _DissolveScanSchedule − 1
        // ====================================================================================
        #ifdef _USE_DISSOLVE
        float HgDissolveValue(Varyings IN)
        {
            float rotA = 0.01745329238474369049072265625 * _DissolveUVRotate;     // b259:224 (_280) 真 π/180
            float sR = sin(rotA), cR = cos(rotA);
            float2 uvD = mad(_DissolveUVSpeed.xy, _Time.y, mad(IN.uv.xy, _DissolveTex_ST.xy, _DissolveTex_ST.zw)) - 0.5; // b249:195-196
            float2 uvDR = float2(dot(uvD, float2(cR, sR)) + 0.5, dot(uvD, float2(-sR, cR)) + 0.5);

        #ifdef _USE_DISTURB
            // ============================================================
            // _USE_DISTURB(b239→b259 差分逐位): 扰动只写溶解 UV, 门=_DissolveTexUseDisturb。
            //   扰动 UV 基 = 世界差按列长平方缩放后与 O2W 行0/行2 点积(字面保形, 非规范逆变换);
            //   scalar = tex.x×(1+_Bi_Disturb) − _Bi_Disturb;
            //   溶解 uv += scalar×(_DisturbUIntensity,_DisturbVIntensity)×_DissolveTexUseDisturb。
            // ============================================================
            {
                float3 colLenSq = float3(
                    dot(float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20),
                        float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20)),
                    dot(float3(unity_ObjectToWorld._m01, unity_ObjectToWorld._m11, unity_ObjectToWorld._m21),
                        float3(unity_ObjectToWorld._m01, unity_ObjectToWorld._m11, unity_ObjectToWorld._m21)),
                    dot(float3(unity_ObjectToWorld._m02, unity_ObjectToWorld._m12, unity_ObjectToWorld._m22),
                        float3(unity_ObjectToWorld._m02, unity_ObjectToWorld._m12, unity_ObjectToWorld._m22)));
                float3 scaledDelta = float3(
                    (IN.positionWS.x - unity_ObjectToWorld._m03) / colLenSq.x,     // b259:220 (_219)
                    (IN.positionWS.y - unity_ObjectToWorld._m13) / colLenSq.y,     // b259:221 (_220)
                    (IN.positionWS.z - unity_ObjectToWorld._m23) / colLenSq.z);    // b259:222 (_221)
                float baseU = dot(scaledDelta, float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m01, unity_ObjectToWorld._m02)); // 行0
                float baseV = dot(scaledDelta, float3(unity_ObjectToWorld._m20, unity_ObjectToWorld._m21, unity_ObjectToWorld._m22)); // 行2
                float2 uvDist = float2(mad(_DisturbUVSpeed.x, _Time.y, mad(baseU, _DisturbTex_ST.x, _DisturbTex_ST.z)),
                                       mad(_DisturbUVSpeed.y, _Time.y, mad(baseV, _DisturbTex_ST.y, _DisturbTex_ST.w))); // b259:223
                float disturbScalar = mad(SAMPLE_TEXTURE2D(_DisturbTex, sampler_DisturbTex, uvDist).x,
                                          1.0 + _Bi_Disturb, -_Bi_Disturb);        // b259:223 (_275)
                uvDR.x = mad(disturbScalar * _DisturbUIntensity, _DissolveTexUseDisturb, uvDR.x); // b259:229
                uvDR.y = mad(disturbScalar * _DisturbVIntensity, _DissolveTexUseDisturb, uvDR.y);
            }
        #endif

            float texD = SAMPLE_TEXTURE2D(_DissolveTex, sampler_DissolveTex, uvDR).x; // b249:198
            float3 objOrigin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);
            float3 dirWS = mul((float3x3)unity_ObjectToWorld, _DissolveDir.xyz);      // b249:197 (O2W·Dir)
            return (texD
                    - mad(_DissolveScheduleOffset, 2.019999980926513671875, -1.0099999904632568359375)   // Param4.x 中性 0
                    + (dot(IN.positionWS - objOrigin, dirWS) / _DissolveScanWidth - _DissolveScanSchedule))
                   - 1.0;                                                          // b249:198 (_264)
        }
        #endif

        // ====================================================================================
        // 视差自发光模块(_PARALLAX_MAP, b221:185-348 全链逐位; 世界空间扩展 b333 融合差分)。
        // 返回加进 RT0/自发光的 RGB(已含 ×_ParallaxIntensity)。
        // ====================================================================================
        #ifdef _PARALLAX_MAP
        float3 HgParallaxEmissive(Varyings IN, float3 shadedNormalWS, float baseA, float nrmZ, float nrmW, float mroA)
        {
            // ---- 遮罩(b221:213-224): 2U 贴图路径 或 通道链×(1−_ParallaxMaskByLayerBlend) ----
            float mask;
            if (_UseParallaxMask != 0.0)
            {
                float chanNA = mad(_AlphaMaskChannel, -baseA + nrmW, baseA);       // b221:216 (_321)
                mask = mad(_UseParallaxMask,
                           mad(-chanNA, _BaseColor.w, SAMPLE_TEXTURE2D(_ParallaxMaskMap, sampler_ParallaxMaskMap, IN.uv.zw).x),
                           chanNA * _BaseColor.w);                                 // b221:217 (_368, raw uv1)
            }
            else
            {
                float sel = mad(clamp(_ParallaxMaskChannel, 0.0, 1.0), -baseA + nrmZ, baseA);       // b221:221 (_353)
                sel = mad(clamp(_ParallaxMaskChannel - 1.0, 0.0, 1.0), -sel + nrmW, sel);           // b221:222 (_361)
            #ifndef _TWO_BASEMAP
                sel = mad(clamp(_ParallaxMaskChannel - 2.0, 0.0, 1.0), -sel + mroA, sel);           // 3-map 链尾(MRO A)
            #endif
                mask = mad(_ParallaxMaskByLayerBlend, -sel, sel);                  // b221:223 (_368)
            }

            if (!(0.00999999977648258209228515625 < mask))                        // b221:228 门
                return float3(0.0, 0.0, 0.0);

            // ---- 视向量 + TBN 投影(b221:230-247; 片元世界重建→positionWS 插值器) ----
            float3 V = HgViewDirWS(IN.positionWS).xyz;
            float tSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
            float3 bitan = tSign * cross(IN.normalWS, IN.tangentWS.xyz);
            float tv = dot(IN.tangentWS.xyz, V);                                   // b221:244 (_487)
            float bv = dot(bitan, V);                                              // b221:245 (_490)
            float nv = dot(IN.normalWS, V);                                        // b221:246 (_499)
            float rlen = rsqrt(dot(float3(tv, bv, nv), float3(tv, bv, nv)));       // b221:247 (_505)

            float2 uvP = mad(_ParallaxMapUVType.xx, IN.uv.zw - IN.uv.xy, IN.uv.xy); // b221:248-249 (_516/_517)
            float2 gx = float2(ddx_coarse(IN.uv.x), ddx_coarse(IN.uv.y)) * _GlobalMipBias.y; // b221:250-253,264-267
            float2 gy = float2(ddy_coarse(IN.uv.x), ddy_coarse(IN.uv.y)) * _GlobalMipBias.y;

            float steps = min(_ParallaxMarchNum, 20.0);                            // b221:254 (出货 int 位型, 数值等价)
            float stepH = 1.0 / steps;                                             // b221:255 (_538)
            float viewBias = mad(nv, rlen, 0.4199999868869781494140625);           // b221:256 (_539)
            float viewDen  = max(rlen * nv, 0.001000000047497451305389404296875);  // b221:257 (_543)
            float2 dirUV = float2((((rlen * tv) / viewBias) / viewDen) * (-_ParallaxStrength),
                                  (((rlen * bv) / viewBias) / viewDen) * (-_ParallaxStrength)); // b221:258-260
            float2 stepUV = stepH * dirUV;                                         // b221:261-262 (_554/_555)

            // ---- 陡视差 march(b221:278-320 循环逐位) ----
            float height = 1.0 - stepH;                                            // b221:278 (_572)
            float2 offCur = stepUV;                                                // b221:285-286 (首采已进一步)
            float2 offPrev = float2(0.0, 0.0);                                     // (_578/_579)
            float texPrev = 0.0;                                                   // (_580)
            float heightPrev = 1.0;                                                // (_582)
            float texHit = 0.0;                                                    // (_789)
            float iter = 0.0;
            for (;;)
            {
                if (!(iter < steps + 1.0)) { texHit = texPrev; break; }            // b221:291,315-318
                float texCur = SAMPLE_TEXTURE2D_GRAD(_ParallaxNoiseMap, hg_point_repeat_sampler,
                                   mad(uvP, _ParallaxNoiseMapTilling.xx, offCur), gx, gy).x; // b221:294 (_778)
                if (height < texCur) { texHit = texCur; break; }                   // b221:297,312
                heightPrev = height;                                               // b221:299,308
                height -= stepH;                                                   // b221:300
                offPrev = offCur;                                                  // b221:301-306
                offCur += stepUV;
                texPrev = texCur;                                                  // b221:307
                iter += 1.0;                                                       // b221:309
            }
            float tBlend = (texPrev - heightPrev)
                         / (-heightPrev + (height + (texPrev - texHit)));          // b221:323 (_806)
            float2 hitUV = (uvP + mad(stepUV, tBlend.xx, offPrev)) * _ParallaxTilling; // b221:324
            float4 pMap = SAMPLE_TEXTURE2D(_ParallaxMap, sampler_ParallaxMap, hitUV); // b221:324 (_822)

            // ---- 亮暗色/菲涅尔/脉冲(b221:321-338) ----
            float3 colBD = float3(mad(pMap.y, _ParallaxColor.x - _ParallaxColorDark.x, _ParallaxColorDark.x),
                                  mad(pMap.y, _ParallaxColor.y - _ParallaxColorDark.y, _ParallaxColorDark.y),
                                  mad(pMap.y, _ParallaxColor.z - _ParallaxColorDark.z, _ParallaxColorDark.z)); // b221:336-338
            float fres = exp2(log2(max(clamp(dot(V, shadedNormalWS), 0.0, 1.0), 0.001000000047497451305389404296875))
                              * floor(_ParallaxFresnelStrength)) * (mask * mask);  // b221:326 (_862)

            // 角色距离亮环(球面, _VFXParams0.xyz=角色位; 门=_ParallaxCharPos) b221:327-330,334
            float3 dChar = IN.positionWS - _VFXParams0.xyz;
            float ringChar = clamp((sqrt(dot(dChar, dChar)) - _ParallaxBrightOuterRadius)
                                   * (1.0 / (-_ParallaxBrightOuterRadius + _ParallaxBrightInnerRadius)), 0.0, 1.0); // (_934)
            float charTerm = ((ringChar * ringChar) * mad(ringChar, -2.0, 3.0)) * _ParallaxBrightStrength;
            charTerm = (_ParallaxCharPos != 0.0) ? charTerm : 0.0;                 // b221:334 位掩码门

            // 交互信号环(XZ 平面, _VFXParams2) b221:331-333
            float2 dSign = float2(IN.positionWS.x - _VFXParams2.x, IN.positionWS.z - _VFXParams2.y);
            float ringSign = clamp((1.0 / (-_VFXParams2.z)) * (sqrt(dot(dSign, dSign)) - _VFXParams2.z), 0.0, 1.0); // (_972)

            // 呼吸+合成脉冲 b221:334 (_979)
            float omb = 1.0 - _ParallaxMinBrightness;                              // (_794)
            float objSum = (unity_ObjectToWorld._m13 + unity_ObjectToWorld._m03) + unity_ObjectToWorld._m23;
            float pulse = mad((ringSign * ringSign) * mad(ringSign, -2.0, 3.0), _VFXParams2.w,
                              mad(omb * (((1.0 + _ParallaxMinBrightness) / omb)
                                         + cos(mad(_Time.y * _ParallaxAnimSpeed, 0.0500000007450580596923828125,
                                                   objSum * _ParallaxAnimRandom))),
                                  0.5, charTerm));

            // 自动曝光除数(_ParallaxIgnorePostExposure 门): URP 曝光=1 → 中性
            float3 parallaxRGB = min(max(pulse * (fres * colBD), 0.0.xxx), 1000.0.xxx); // b221:336-338

        #ifdef _PARALLAX_MAP_WORLDSPACE
            // ============================================================
            // 世界空间扩展(b227→b333 融合差分逐位):
            //   ① 极坐标扫描图(_ParallaxMaskMap@世界XZ 旋转/缩放)乘入视差色 + 5 段交互信号带;
            //   ② 主项乘高度门 _1177; ③ 追加 (视差+0.3)×_WorldParallaxAdditionalColor×世界Y带×通道遮罩。
            // ============================================================
            {
                float2 dW = float2(IN.positionWS.x - _MaskWorldPosParams.x,
                                   IN.positionWS.z - _MaskWorldPosParams.z);       // b333:816-817
                float rotW = 0.01745329238474369049072265625 * _MaskWorldPosParams.y; // b333:821
                float sW = sin(rotW), cW = cos(rotW);
                float scaleW = max(0.100000001490116119384765625, _MaskWorldPosParams.w); // b333:828
                float2 polar = dW / scaleW;                                        // b333:829-830
                // LOD = mad(|N_geo.y|, -3, 3) (b333:851 法线越竖直 mip 越低)
                float4 scan = SAMPLE_TEXTURE2D_LOD(_ParallaxMaskMap, sampler_ParallaxMaskMap,
                                  float2(mad(pMap.x, _ParallaxMinBrightness, dot(polar, float2(cW, sW)) + 0.5),
                                         mad(pMap.y, _ParallaxMinBrightness, dot(polar, float2(-sW, cW)) + 0.5)),
                                  mad(abs(IN.normalWS.y), -3.0, 3.0));             // b333:851 (_851; 图案偏移系数=_ParallaxMinBrightness 槽同址)
                parallaxRGB *= scan.rgb * _ParallaxMaskMapColorStrength;           // b333:880-882 尾乘

                // 5 段信号带: scan.a 分段窗(≤0.18)×5 × _ParallaxSignControl 位 × 强度 (b333:886-986)
                uint signBits = uint(int(_ParallaxSignControl));                   // b333:886
                float sa = clamp(scan.w, 0.0, 1.0);
                float s1 = clamp(scan.w - 0.20000000298023223876953125, 0.0, 1.0);
                float s2 = clamp(scan.w - 0.4000000059604644775390625, 0.0, 1.0);
                float s3 = clamp(scan.w - 0.60000002384185791015625, 0.0, 1.0);
                float s4 = clamp(scan.w - 0.800000011920928955078125, 0.0, 1.0);
                float band = ((0.180000007152557373046875 >= sa) ? sa * 5.0 : 0.0) * float(int(signBits & 1u))          * _ParallaxSignLerpFactor0.x
                           + ((0.180000007152557373046875 >= s1) ? s1 * 5.0 : 0.0) * float(int((signBits >> 1u) & 1u)) * _ParallaxSignLerpFactor0.y
                           + ((0.180000007152557373046875 >= s2) ? s2 * 5.0 : 0.0) * float(int((signBits >> 2u) & 1u)) * _ParallaxSignLerpFactor0.z
                           + ((0.180000007152557373046875 >= s3) ? s3 * 5.0 : 0.0) * float(int((signBits >> 3u) & 1u)) * _ParallaxSignLerpFactor0.w
                           + ((0.180000007152557373046875 >= s4) ? s4 * 5.0 : 0.0) * float(int((signBits >> 4u) & 1u)) * _ParallaxSignLerpFactor2;
                // 波前 = sat(pMap.x×20 + 距离 − _ParallaxLerpSchedule); 顶点色 R 门带项 (b333:986)
                float wave = clamp(mad(pMap.x, 20.0, sqrt(dot(dW, dW))) - _ParallaxLerpSchedule, 0.0, 1.0);
                float pulseW = clamp(mad(band, IN.color.x, wave), 0.0, 1.0);       // (_987)

                // 图案亮暗色 lerp (b333:994-1011)
                float3 patDark   = parallaxRGB * _ParallaxPatternColorDark.rgb;
                float3 patBright = parallaxRGB * _ParallaxPatternColor.rgb;
                parallaxRGB = lerp(patDark, patBright, pulseW);

                // 主项高度门(重建世界Y→positionWS.y; 槽角色=_ParallaxSignLerpFactor1.w) (b333:1177)
                float hGate = mad(clamp(_ParallaxSignLerpFactor1.w, 0.0, 1.0),
                                  -baseA + clamp(-IN.positionWS.y + _ParallaxSignLerpFactor1.w, 0.0, 1.0),
                                  baseA);
                // 附加色通道遮罩链(BaseColorA→NormalMapB→NormalMapA) (b333:1147-1155)
                float mAdd = mad(clamp(_WorldParallaxAdditionalLightMaskChannel, 0.0, 1.0), -baseA + nrmZ, baseA);
                mAdd = mad(clamp(_WorldParallaxAdditionalLightMaskChannel - 1.0, 0.0, 1.0), -mAdd + nrmW, mAdd);
            #ifndef _TWO_BASEMAP
                mAdd = mad(clamp(_WorldParallaxAdditionalLightMaskChannel - 2.0, 0.0, 1.0), -mAdd + mroA, mAdd);
            #endif
                // 世界Y带(顶点世界Y; 阈值=_ParallaxSignLerpFactor1.y) (b333:1137)
                float yBand = clamp(IN.positionWS.y - _ParallaxSignLerpFactor1.y, 0.0, 1.0);
                float3 addTerm = mAdd * (yBand * ((parallaxRGB + 0.300000011920928955078125) * _WorldParallaxAdditionalColor.rgb)); // b333:SV 尾第三项
                return mad(parallaxRGB, (hGate * _ParallaxIntensity).xxx, addTerm); // b333:SV 尾 (主项×门×强度 + 附加项)
            }
        #else
            return parallaxRGB * _ParallaxIntensity;                               // b221:346-348 (_OffsetUVSet 槽=_ParallaxIntensity 角色)
        #endif
        }
        #endif // _PARALLAX_MAP

        // ====================================================================================
        // 基面装配(b187/b191 逐位 == lit b283/b11 同织物) + liteffect 特性模块。
        // ====================================================================================
        HgSurface HgBuildSurface(Varyings IN, bool isFrontFace)
        {
            HgSurface s = (HgSurface)0;

            float2 uvBase, uvPbr;
            HgComputeBaseUVs(IN.uv, uvBase, uvPbr);

            float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uvBase);          // b187:151
            float4 nrm     = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap, uvPbr, _TAAUNormalBiasReverse); // b187:161(+bias)

        #ifdef _TWO_BASEMAP
            float metallicT = baseTex.w;                                          // b191:147 (metallic=base.a)
            float roughT    = nrm.z;                                              // b191:178 槽
            float occT      = nrm.w;                                              // b191:155
            float mroA      = 0.0;
            float nxRaw = mad(nrm.x, 2.0, -1.0);                                  // b191:158
            float nyRaw = mad(nrm.y, 2.0, -1.0);                                  // b191:159
            float nxDec = (abs(nxRaw) < HG_NORMAL_DEADZONE) ? 0.0 : nxRaw;        // b191:160
            float nyDec = (abs(nyRaw) < HG_NORMAL_DEADZONE) ? 0.0 : nyRaw;        // b191:161
        #else
            float4 mro = SAMPLE_TEXTURE2D(_MROMap, sampler_MROMap, uvPbr);        // b187:157 (共用 uvPbr)
            float metallicT = mro.x;                                              // b187:159
            float roughT    = mro.y;
            float occT      = mro.z;                                              // b187:160
            float mroA      = mro.w;
            float nxDec = mad(nrm.x * nrm.w, 2.0, -1.0);                          // b187:162 DXT5nm
            float nyDec = mad(nrm.y,         2.0, -1.0);                          // b187:163
        #endif
            float nx = nxDec * _NormalScale;                                      // b187:164-165
            float ny = nyDec * _NormalScale;

            float3 albedoRaw = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale);      // b187:152-154
            float3 baseCol   = lerp(albedoRaw, _BaseColor.rgb, _BaseColorTintCover);                  // b187:182

            float roughness = lerp(_RoughnessMin, _RoughnessMax, roughT);
            float metallic  = lerp(metallicT, _Metallic, saturate(_BaseTextureMapCount - 1.0));       // b191:147
            float occlusion = lerp(1.0, occT, _OcclusionStrength);                                    // b187:160/b191:155

            float frontSign = isFrontFace ? 1.0 : ((_TwoSidedNormal > 0.0) ? -1.0 : 1.0);             // b187:166/b191:164
        #ifdef _TWO_BASEMAP
            float nz = sqrt(max(1.0 - dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 0.0)) * frontSign;                    // b191:164 (max0 形)
        #else
            float nz = max(sqrt(1.0 - min(dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 1.0)), HG_EPS_NORMAL_Z) * frontSign; // b187:166 (1e-16 形)
        #endif

            // ============================================================
            // _DETAIL_MAP(b349 融合差分 == lit b619 同织物): 视深渐隐+五路蒙版链+RNM+PBR/叠色
            // ============================================================
        #ifdef _DETAIL_MAP
            {
                float viewZ = abs(mad(UNITY_MATRIX_V[2].z, IN.positionWS.z, mad(UNITY_MATRIX_V[2].x, IN.positionWS.x, IN.positionWS.y * UNITY_MATRIX_V[2].y)) + UNITY_MATRIX_V[2].w);
                float falloff = clamp((-viewZ + _DetailFalloffEnd) / (-_DetailFalloffStart + _DetailFalloffEnd), 0.0, 1.0); // b349:234 尾

                float2 duvD = IN.uv.zw - IN.uv.xy;
                float2 uvDetail = mad(mad(_DetailUVSet.xx, duvD, IN.uv.xy), _DetailMap_ST.xy, _DetailMap_ST.zw); // b349:227
                float4 detailTex = SAMPLE_TEXTURE2D(_DetailMap, sampler_DetailMap, uvDetail);

                float m23 = mad(clamp(_DetailMaskMode - 2.0, 0.0, 1.0), nrm.z - baseTex.w, baseTex.w);   // b349:233
                float m01 = mad(clamp(_DetailMaskMode, 0.0, 1.0), detailTex.w - 1.0, 1.0);               // b349:231
                float m234 = mad(clamp(_DetailMaskMode - 3.0, 0.0, 1.0), nrm.w - m23, m23);              // b349:234
            #ifndef _TWO_BASEMAP
                m234 = mad(clamp(_DetailMaskMode - 4.0, 0.0, 1.0), mroA - m234, m234);
            #endif
                float detailWeight = falloff * mad(clamp(_DetailMaskMode - 1.0, 0.0, 1.0), m234 - m01, m01); // b349:234 (_412)

                float wN = detailWeight * _DetailNormalIntensity;                                        // b349:242 (_444)
                float dnx = mad(detailTex.x, 2.0, -1.0); dnx = (abs(dnx) < HG_NORMAL_DEADZONE) ? 0.0 : dnx; // b349:235-238
                float dny = mad(detailTex.y, 2.0, -1.0); dny = (abs(dny) < HG_NORMAL_DEADZONE) ? 0.0 : dny;
                float dX = wN * dnx;                                                                     // b349:244 (_446)
                float dY = wN * dny;                                                                     // b349:245 (_447)
                float dZ = sqrt(max(1.0 - dot(float2(dnx, dny), float2(dnx, dny)), 0.0));                // b349:246 (_454)
                float bZ1 = sqrt(max(1.0 - dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 0.0)) + 1.0; // b349:241 (_439)
                float rnmDot = dot(float3(nx, ny, bZ1), float3(-dX, -dY, dZ));                           // b349:247 (_458)
                nx = dX + (rnmDot * nx) / bZ1;                                                           // b349:248 (_469)
                ny = dY + (rnmDot * ny) / bZ1;                                                           // b349:249 (_470)
                nz = (rnmDot - dZ) * frontSign;                                                          // b349:257 (_552)

                float wPbr = detailWeight * _DetailPBRIntensity;                                         // b349:243 (_445)
                float detailRough = mad(_DetailMode, detailTex.z - detailTex.w, detailTex.w);
                roughness = mad(wPbr, detailRough - roughness, roughness);
                occlusion = mad(wPbr, (detailTex.w - 1.0) * _DetailMode, 1.0) * occlusion;

                float wTint = ((1.0 - detailTex.z) * (1.0 - _DetailMode)) * detailWeight;                // b349:253 (_515)
                float3 tintBase = clamp((baseCol * _DetailOverlayColor.rgb) * _DetailBaseColorBrighterScale, 0.0, 1.0); // b349:250-252
                baseCol = lerp(baseCol, lerp(tintBase, _DetailOverlayColor.rgb, _DetailOverlayColor.w), wTint); // b349:254-256
            }
        #endif

            // TBN → 世界法线
            float tangentSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
            float3 bitangent  = tangentSign * cross(IN.normalWS, IN.tangentWS.xyz);
            float3 normalWS   = normalize(IN.normalWS * nz + IN.tangentWS.xyz * nx + bitangent * ny);   // b187:168-171

            s.albedo    = baseCol;
            s.normalWS  = normalWS;
            s.metallic  = metallic;
            s.roughness = roughness;
            s.occlusion = occlusion;
            s.emission  = float3(0.0, 0.0, 0.0);
            s.alpha     = 1.0;   // 不透明家族

            // ============================================================
            // _TRI_CHANNEL_MASK(liteffect P0 差分 == lit b291 同式): B→G→R 改写。
            // 本家族骨架无 Scale/Offset 滑杆 → 材质值 0, 公式保形退化 sat(mask.c)×w。
            // ============================================================
        #ifdef _TRI_CHANNEL_MASK
            {
                float2 duvM = IN.uv.zw - IN.uv.xy;
                float2 uvMask = mad(mad(_MaskUVSet.xx, duvM, IN.uv.xy), _MaskMap_ST.xy, _MaskMap_ST.zw);
                float4 maskTex = SAMPLE_TEXTURE2D(_MaskMap, sampler_MaskMap, uvMask);
                float wB = clamp(mad(maskTex.z + _MaskBOffset, _MaskBScale + 1.0, _MaskBScale * (-0.5)), 0.0, 1.0) * _MaskAlbedoB.w; // (_254 式)
                float wG = clamp(mad(maskTex.y + _MaskGOffset, _MaskGScale + 1.0, _MaskGScale * (-0.5)), 0.0, 1.0) * _MaskAlbedoG.w; // (_351 式)
                float wR = clamp(mad(maskTex.x + _MaskROffset, _MaskRScale + 1.0, _MaskRScale * (-0.5)), 0.0, 1.0) * _MaskAlbedoR.w; // (_356 式)
                s.albedo = lerp(s.albedo, _MaskAlbedoB.rgb, wB);
                s.albedo = lerp(s.albedo, _MaskAlbedoG.rgb, wG);
                s.albedo = lerp(s.albedo, _MaskAlbedoR.rgb, wR);
                s.roughness = lerp(s.roughness, _MaskRoghnessB, wB);
                s.roughness = lerp(s.roughness, _MaskRoghnessG, wG);
                s.roughness = lerp(s.roughness, _MaskRoghnessR, wR);
                s.metallic  = lerp(s.metallic, _MaskMetallicB, wB);
                s.metallic  = lerp(s.metallic, _MaskMetallicG, wG);
                s.metallic  = lerp(s.metallic, _MaskMetallicR, wR);
            }
        #endif

            // ============================================================
            // 自发光家族(liteffect b213/b209/b333/b339 逐位): 呼吸/扫光 + 路由 + ×_EmissiveRemap。
            // SceneEffect per-draw 调色/自动曝光=中性; 时间→_Time.y。
            // ============================================================
        #if defined(_EMISSIVE_MAP) || defined(_EMISSIVE_MASK) || defined(_EMISSIVE_NOMAP)
            {
                float3 albedoAffect = lerp(s.albedo, float3(1.0, 1.0, 1.0), _AlbedoAffectEmissive);

                float animX = 0.0;
            #ifdef _EMISSIVE_ANIM
                float tri  = mad(clamp(frac(mad(_Time.y * _EmissiveAnimSpeed, 0.15915493667125701904296875, _EmissiveAnimRandom)) * _EmissiveAnimInterval, 0.0, 1.0), 2.0, -1.0); // b213:188
                float tri2 = tri * tri;
                float omb  = 1.0 - _EmissiveMinBrightness;
                animX = mad((((1.0 + _EmissiveMinBrightness) / omb) + (mad(tri2, -6.0, abs(tri * tri2) * 4.0) + 1.0)) * omb, 0.5, -1.0); // b213:191
            #endif
            #if defined(_EMISSIVE_ANIM_SWEEP) || defined(_EMISSIVE_NOMAP)
                float3 objOrigin  = float3(UNITY_MATRIX_M._m03, UNITY_MATRIX_M._m13, UNITY_MATRIX_M._m23);
                float3 objUpRow   = float3(UNITY_MATRIX_M._m10, UNITY_MATRIX_M._m11, UNITY_MATRIX_M._m12);
                float  upProj     = dot(objUpRow, IN.positionWS - objOrigin);
                float  phaseT     = mad(_EmissiveSweepRandom, objOrigin.x, _Time.y) / _EmissiveSweepInterval;
                float  phaseF     = frac(abs(phaseT));
                float  signedFsw  = (phaseT >= -phaseT) ? phaseF : -phaseF;
                float  sweepCoord = upProj - _EmissiveSweepSpeed * mad(signedFsw, _EmissiveSweepInterval, -(0.300000011920928955078125 * _EmissiveSweepInterval));
                float  band       = clamp(mad(-clamp(abs(sweepCoord) / _EmissiveSweepWidth, 0.0, 1.0), _EmissiveSweepFalloff, _EmissiveSweepFalloff), 0.0, 1.0);
                float  albedoTerm = max(mad(_EmissiveSweepAlbedoScale, dot(s.albedo, 0.333000004291534423828125.xxx) + (-0.20000000298023223876953125), 0.20000000298023223876953125) * 5.0, 0.0);
                float  sweepBoost = albedoTerm * (band * band);
                animX = sweepBoost - 1.0;
            #endif
                float fR = mad(_EmissiveColor.w,  animX, 1.0);
                float fG = mad(_EmissiveColorG.w, animX, 1.0);
                float fB = mad(_EmissiveColorB.w, animX, 1.0);
                float fA = mad(_EmissiveColorA.w, animX, 1.0);

            #ifdef _EMISSIVE_MAP
                float2 duvEm = IN.uv.zw - IN.uv.xy;
                float2 uvEm  = mad(_EmissiveSpeed.xy, _Time.y,
                                   mad(mad(_EmissiveUVSet.xx, duvEm, IN.uv.xy), _EmissiveMap_ST.xy, _EmissiveMap_ST.zw));
            #if defined(_EMISSIVE_ANIM) || defined(_EMISSIVE_ANIM_SWEEP)
                uvEm *= _EmissiveMapTilling;
            #endif
                float4 em = SAMPLE_TEXTURE2D(_EmissiveMap, sampler_EmissiveMap, uvEm);
                float3 route = _EmissiveColor.rgb * (em.x * fR)
                             + (_EmissiveColorG.rgb * (em.y * fG)
                                + _EmissiveColorB.rgb * (em.z * fB)
                                + _EmissiveColorA.rgb * (em.w * fA)) * _EmissiveType;
            #if defined(_EMISSIVE_ANIM) || defined(_EMISSIVE_ANIM_SWEEP)
                route = min(max(route, 0.0.xxx), 1000.0.xxx);
            #endif
                s.emission += route * albedoAffect * _EmissiveRemap;               // b227:420 尾乘(家族专有)
            #elif defined(_EMISSIVE_MASK)
                float sel = mad(clamp(_EmissiveMaskChannel - 1.0, 0.0, 1.0), -baseTex.w + nrm.z, baseTex.w); // b209:162
                sel = mad(clamp(_EmissiveMaskChannel - 2.0, 0.0, 1.0), nrm.w - sel, sel);
            #ifndef _TWO_BASEMAP
                sel = mad(clamp(_EmissiveMaskChannel - 3.0, 0.0, 1.0), mroA - sel, sel);
            #endif
                float chGate  = clamp(_EmissiveMaskChannel, 0.0, 1.0);
                float maskVal = clamp(mad(mad(chGate, sel - 1.0, 1.0), 1.111111164093017578125, -0.055555559694766998291015625), 0.0, 1.0); // b209:184
                s.emission += (_EmissiveColor.rgb * ((maskVal * fR) * _EnableEmissiveMap * chGate)) * albedoAffect * _EmissiveRemap; // b209:185
            #elif defined(_EMISSIVE_NOMAP)
                s.emission += (_EmissiveColor.rgb * sweepBoost) * albedoAffect * _EmissiveRemap;   // b339:192-194
            #endif
            }
        #endif

            // ============================================================
            // _PARALLAX_MAP → 自发光加项(参考写 RT0, URP=emission 载体同义)
            // ============================================================
        #ifdef _PARALLAX_MAP
            s.emission += HgParallaxEmissive(IN, s.normalWS, baseTex.w, nrm.z, nrm.w, mroA);
        #endif

            // ============================================================
            // _USE_DISSOLVE(b249/b259 逐位): clip(sat(d×sharp)−0.02) + 边缘发光带。
            // ============================================================
        #ifdef _USE_DISSOLVE
            {
                float dissolve = HgDissolveValue(IN);
                clip(clamp(dissolve * _DissolveEdgeSharp, 0.0, 1.0) - 0.0199999995529651641845703125); // b249:199
                float edgeBand = clamp((-dissolve + _DissolveEmissiveWidth) * _DissolveEdgeSharp, 0.0, 1.0); // b249:212 (_388)
                s.emission += _DissolveEmissiveColor.rgb * edgeBand;               // b249:213-215
                // _DissolveEmissiveEdge: 出货 blob 无读取(死 uniform), 不移植。
            }
        #endif

            s.f0      = lerp((HG_DIELECTRIC_F0 * _Specular).xxx, s.albedo, s.metallic);   // b11:298-305
            s.diffuse = s.albedo * (1.0 - s.metallic);
            return s;
        }

        // ====================================================================================
        // Alpha clip(_ALPHATEST_ON):
        //   阴影/深度 pass = baseA×_BaseColor.a (lit b911:135 同织物);
        //   主 pass = lerp(baseA, nrm.a, _AlphaMaskChannel)×_BaseColor.a (b609:175 通道式;
        //   原版靠 preZ+ZTest Equal, URP 各 pass 独立 clip=净行为等价)。
        // ====================================================================================
        void HgAlphaClipDepth(float4 uv)
        {
        #ifdef _ALPHATEST_ON
            float2 uvBase, uvPbr;
            HgComputeBaseUVs(uv, uvBase, uvPbr);
            float alpha = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uvBase).w * _BaseColor.w;
            clip(alpha - _AlphaClipThreshold);
        #endif
        }

        void HgAlphaClipMain(float4 uv)
        {
        #ifdef _ALPHATEST_ON
            float2 uvBase, uvPbr;
            HgComputeBaseUVs(uv, uvBase, uvPbr);
            float baseA = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uvBase).w;
            float nrmA  = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap, uvPbr, _TAAUNormalBiasReverse).w;
            float alpha = mad(_AlphaMaskChannel, -baseA + nrmA, baseA) * _BaseColor.w;
            clip(alpha - _AlphaClipThreshold);
        #endif
        }

        // DITHER: LOD 淡出/切割面抖动 discard(lit b1167:128-137 同织物, IGN 常数逐位)
        void HgDitherClip(float4 positionCS, float3 positionWS)
        {
        #ifdef DITHER
            float fadeInv = 1.0 - max(unity_LODFade.z, unity_LODFade.y);
            float3 objOrigin = float3(UNITY_MATRIX_M._m03, UNITY_MATRIX_M._m13, UNITY_MATRIX_M._m23);
            float distOffset = sqrt(dot(objOrigin, objOrigin)) * _DitherTransparentOffset;
            float fadeGate = (0.99993896484375 >= fadeInv) ? 1.0 : 0.0;
            float noise = frac(frac(dot(float2(mad(distOffset, fadeGate, positionCS.x),
                                                mad(distOffset, fadeGate, positionCS.y)),
                                        float2(0.067110560834407806396484375, 0.005837149918079376220703125)))
                               * 52.98291778564453125);
            float cutSide = (dot(positionWS, _CutOffDirection.xyz) >= _CutOffPosY) ? 1.0 : 0.0;
            float fadeTerm = min(fadeInv - noise,
                                 unity_LODFade.x - ((unity_LODFade.x >= 0.0) ? noise : -noise));
            clip(mad(-cutSide, _UseCutOff, fadeTerm));
        #endif
        }
        ENDHLSL

        // ============================================================================================
        // Pass 1: UniversalForward — 参考家族无前向 pass(延迟专用);此 pass = 同一表面数据 ×
        //   litforward b11 前向核(家族共享织物), 供 URP Forward/Forward+ 路径渲染。
        // ============================================================================================
        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForward" }
            ZWrite On
            ZTest [_ZTestGBuffer]
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex HgForwardVertex
            #pragma fragment HgForwardFragment

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _TWO_BASEMAP
            #pragma shader_feature_local _TRI_CHANNEL_MASK
            #pragma shader_feature_local _EMISSIVE_MAP
            #pragma shader_feature_local _EMISSIVE_MASK
            #pragma shader_feature_local _EMISSIVE_NOMAP
            #pragma shader_feature_local _EMISSIVE_ANIM
            #pragma shader_feature_local _EMISSIVE_ANIM_SWEEP
            #pragma shader_feature_local _PARALLAX_MAP
            #pragma shader_feature_local _PARALLAX_MAP_WORLDSPACE
            #pragma shader_feature_local _DETAIL_MAP
            #pragma shader_feature_local _USE_DISTURB
            #pragma shader_feature_local _USE_DISSOLVE
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _VAT_SOFTBODY
            #pragma shader_feature_local _VAT_RIGIDBODY
            #pragma shader_feature_local _UNLOAD_ROT_TEX

            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile _ _ADDITIONAL_LIGHTS
            #pragma multi_compile _ _CLUSTER_LIGHT_LOOP
            #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
            #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_BOX_PROJECTION
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_ATLAS
            #pragma multi_compile_fragment _ _LIGHT_COOKIES
            #pragma multi_compile_fog
            #pragma multi_compile_instancing

            Varyings HgForwardVertex(Attributes IN)
            {
                return HgVertexCore(IN);
            }

            float4 HgForwardFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                HgAlphaClipMain(IN.uv);
                HgSurface s = HgBuildSurface(IN, isFrontFace);

                // b11 前向合成(引擎面按文件头替换表换 URP)
                float3 N = s.normalWS;
                float4 viewData = HgViewDirWS(IN.positionWS);
                float3 V = viewData.xyz;
                float  NoV = max(dot(N, V), 0.0);

                float envScale, envBias;
                HgEnvBRDF(s.roughness, NoV, s.f0, envScale, envBias);
                float3 reflectVec = reflect(-V, N);
                float3 reflection = GlossyEnvironmentReflection(reflectVec, s.roughness, 1.0);
                float3 color = s.diffuse * SampleSH(N) * s.occlusion * _EnvironmentGlobalParams0.x
                             + mad(s.f0, envScale.xxx, envBias.xxx) * reflection * _EnvironmentGlobalParams0.y;

                float4 shadowCoord = TransformWorldToShadowCoord(IN.positionWS);
                Light mainLight = GetMainLight(shadowCoord, IN.positionWS, half4(1, 1, 1, 1));
                {
                    float3 L = mainLight.direction;
                    float3 H = (L + V) * rsqrt(max(dot(L + V, L + V), HG_EPS_HALF));
                    float NoL = saturate(dot(L, N));
                    float NoH = saturate(dot(N, H));
                    float VoH = saturate(dot(V, H));
                    float3 energy = HgDirectLightEnergy(s.roughness, s.f0, NoL, NoH, NoV, VoH);
                    float atten = mainLight.distanceAttenuation * mainLight.shadowAttenuation;
                    color += mad(energy, NoL.xxx, s.diffuse * NoL) * (mainLight.color * atten);
                }

            #if defined(_ADDITIONAL_LIGHTS)
                uint lightCount = GetAdditionalLightsCount();
                InputData inputData = (InputData)0;
                inputData.positionWS = IN.positionWS;
                inputData.normalizedScreenSpaceUV = GetNormalizedScreenSpaceUV(IN.positionCS);
                LIGHT_LOOP_BEGIN(lightCount)
                    Light light = GetAdditionalLight(lightIndex, IN.positionWS, half4(1, 1, 1, 1));
                    float3 L = light.direction;
                    float3 H = (L + V) * rsqrt(max(dot(L + V, L + V), HG_EPS_HALF));
                    float NoL = saturate(dot(L, N));
                    float NoH = saturate(dot(N, H));
                    float VoH = saturate(dot(V, H));
                    float3 energy = HgDirectLightEnergy(s.roughness, s.f0, NoL, NoH, NoV, VoH);
                    color += mad(energy, NoL.xxx, s.diffuse * NoL) * (light.color * light.distanceAttenuation);
                LIGHT_LOOP_END
            #endif

                color += s.emission;
                color = MixFog(color, IN.fogFactor);
                return float4(color, s.alpha);
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2: UniversalGBuffer — 参考 P0 "HGBuffer"(GBuffer 5-MRT)的 URP 延迟对应。
        //   表面数学 1:1;打包走 URP PackGBuffersBRDFData(HG MRT 专属通道: 吸水度/profile 位/MV
        //   打包无 URP 载体, 文档化弃用, 与 lit.shader 同)。
        // ============================================================================================
        Pass
        {
            Name "GBuffer"
            Tags { "LightMode" = "UniversalGBuffer" }
            ZWrite On
            ZTest [_ZTestGBuffer]
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma exclude_renderers gles3 glcore
            #pragma vertex HgForwardVertex
            #pragma fragment HgGBufferFragment

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _TWO_BASEMAP
            #pragma shader_feature_local _TRI_CHANNEL_MASK
            #pragma shader_feature_local _EMISSIVE_MAP
            #pragma shader_feature_local _EMISSIVE_MASK
            #pragma shader_feature_local _EMISSIVE_NOMAP
            #pragma shader_feature_local _EMISSIVE_ANIM
            #pragma shader_feature_local _EMISSIVE_ANIM_SWEEP
            #pragma shader_feature_local _PARALLAX_MAP
            #pragma shader_feature_local _PARALLAX_MAP_WORLDSPACE
            #pragma shader_feature_local _DETAIL_MAP
            #pragma shader_feature_local _USE_DISTURB
            #pragma shader_feature_local _USE_DISSOLVE
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _VAT_SOFTBODY
            #pragma shader_feature_local _VAT_RIGIDBODY
            #pragma shader_feature_local _UNLOAD_ROT_TEX

            #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_BOX_PROJECTION
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_ATLAS
            #pragma multi_compile_instancing

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/UnityGBuffer.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/GBufferOutput.hlsl"

            Varyings HgForwardVertex(Attributes IN)
            {
                return HgVertexCore(IN);
            }

            GBufferFragOutput HgGBufferFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace)
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                HgAlphaClipMain(IN.uv);
                HgSurface s = HgBuildSurface(IN, isFrontFace);

                // 环境项(HG 延迟解算端 A/B 项在 URP 于 GBuffer 期落入 GI 目标, b11:3875 同式)
                float3 N = s.normalWS;
                float4 viewData = HgViewDirWS(IN.positionWS);
                float  NoV = max(dot(N, viewData.xyz), 0.0);
                float envScale, envBias;
                HgEnvBRDF(s.roughness, NoV, s.f0, envScale, envBias);
                float3 reflectVec = reflect(-viewData.xyz, N);
                float3 reflection = GlossyEnvironmentReflection(reflectVec, s.roughness, 1.0);
                float3 giColor = s.diffuse * SampleSH(N) * s.occlusion * _EnvironmentGlobalParams0.x
                               + mad(s.f0, envScale.xxx, envBias.xxx) * reflection * _EnvironmentGlobalParams0.y;

                half alpha = half(1.0);
                BRDFData brdfData;
                InitializeBRDFData(half3(s.albedo), half(s.metallic), half3(0, 0, 0), half(1.0 - saturate(s.roughness)), alpha, brdfData);

                InputData inputData = (InputData)0;
                inputData.positionWS = IN.positionWS;
                inputData.positionCS = IN.positionCS;
                inputData.normalWS = half3(N);
                inputData.viewDirectionWS = half3(viewData.xyz);
                inputData.normalizedScreenSpaceUV = GetNormalizedScreenSpaceUV(IN.positionCS);
                inputData.fogCoord = 0.0;

                return PackGBuffersBRDFData(brdfData, inputData, half(1.0 - saturate(s.roughness)),
                                            half3(s.emission + giColor), half(s.occlusion));
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 3: ShadowCaster — 参考 P1(骨架 L1373-1396: ALPHATEST/TWO_BASEMAP/VERTOFFSET/VAT/DITHER,
        //   无溶解)。HG 影 VP → URP ApplyShadowBias。
        // ============================================================================================
        Pass
        {
            Name "ShadowCaster"
            Tags { "LightMode" = "ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_ShadowCullMode]
            Offset [_ShadowBias], 0

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex HgShadowVertex
            #pragma fragment HgShadowFragment

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _TWO_BASEMAP
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _VAT_SOFTBODY
            #pragma shader_feature_local _VAT_RIGIDBODY
            #pragma shader_feature_local _UNLOAD_ROT_TEX
            #pragma shader_feature_local DITHER
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW
            #pragma multi_compile_instancing

            float3 _LightDirection;
            float3 _LightPosition;

            Varyings HgShadowVertex(Attributes IN)
            {
                Varyings OUT = HgVertexCore(IN);
            #if defined(_CASTING_PUNCTUAL_LIGHT_SHADOW)
                float3 lightDirectionWS = normalize(_LightPosition - OUT.positionWS);
            #else
                float3 lightDirectionWS = _LightDirection;
            #endif
                float4 positionCS = TransformWorldToHClip(ApplyShadowBias(OUT.positionWS, OUT.normalWS, lightDirectionWS));
            #if UNITY_REVERSED_Z
                positionCS.z = min(positionCS.z, UNITY_NEAR_CLIP_VALUE);
            #else
                positionCS.z = max(positionCS.z, UNITY_NEAR_CLIP_VALUE);
            #endif
                OUT.positionCS = positionCS;
                return OUT;
            }

            half4 HgShadowFragment(Varyings IN) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                HgAlphaClipDepth(IN.uv);
                HgDitherClip(IN.positionCS, IN.positionWS);
                return 0;
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 4: DepthOnly — 参考 P2(骨架 L1776-1806: P1 集 + _USE_DISSOLVE): 深度 + 溶解 clip。
        // ============================================================================================
        Pass
        {
            Name "DepthOnly"
            Tags { "LightMode" = "DepthOnly" }
            ZWrite On
            ZTest LEqual
            ColorMask R
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex HgDepthVertex
            #pragma fragment HgDepthFragment

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _TWO_BASEMAP
            #pragma shader_feature_local _USE_VERTOFFSET
            // 骨架 P2(L1797-1806)无 _USE_DISTURB → 深度 pass 溶解 UV 不吃扰动(与出货一致)
            #pragma shader_feature_local _USE_DISSOLVE
            #pragma shader_feature_local _VAT_SOFTBODY
            #pragma shader_feature_local _VAT_RIGIDBODY
            #pragma shader_feature_local _UNLOAD_ROT_TEX
            #pragma shader_feature_local DITHER
            #pragma multi_compile_instancing

            Varyings HgDepthVertex(Attributes IN)
            {
                return HgVertexCore(IN);
            }

            half4 HgDepthFragment(Varyings IN) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                HgAlphaClipDepth(IN.uv);
                HgDitherClip(IN.positionCS, IN.positionWS);
            #ifdef _USE_DISSOLVE
                clip(clamp(HgDissolveValue(IN) * _DissolveEdgeSharp, 0.0, 1.0) - 0.0199999995529651641845703125); // b249:199 同式
            #endif
                return 0;
            }
            ENDHLSL
        }
    }
}
