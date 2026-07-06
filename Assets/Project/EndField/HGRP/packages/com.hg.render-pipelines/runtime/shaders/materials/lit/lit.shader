// ============================================================================================
// HGRP/Lit — EndField(HGRP) lit 家族 → Unity URP 单文件 1:1 系统化等价重构。
//
// 合并的六个源 shader(AllShader_1.3.3 rip, 相对同路径):
//   lit.shader           (GBuffer 延迟主材质: 全特性面)         litforward.shader (ForwardOnly 不透明前向)
//   liteffect.shader     (lit + 扰动/溶解 VFX 面)               littransparent.shader (透明前向: 折射/菲涅尔/玻璃)
//   liteffectblend.shader(Erosion 软深度相交混合)               lithlod.shader (HLOD 烘焙贴图)
//
// 真值 = 出货变体的 SPIR-V 反编译 (bNNN.hlsl)。材质数学逐位 1:1;引擎面按下表替换成 URP 系统:
//   HG IV-clipmap SH 级联(T9-T15)            → SampleSH(N)
//   反射 probe 分箱八面体图集(zbin+box投影)   → GlossyEnvironmentReflection(R, perceptualRoughness, occlusion=1)
//   CSM 5x5tent + ASM 图集 + 阴影 ramp + 云影 → mainLight.shadowAttenuation (URP 级联/软阴影)
//   点光 zbin/tile 分箱循环 + cube 阴影图集   → URP additional-lights 循环 (Forward+/clustered 原生)
//   DFG 分离和 LUT(T8 双查)                  → EnvBRDFApprox 解析多项式 (b11:975 同式;LUT 为引擎预积分图无绑定)
//   大气+指数双层+froxel 体积雾               → URP fogFactor + MixFog
//   HG MV 打包(SV_Target1)/TAA jitter        → 弃 (URP MotionVectors pass 域)
//   SceneEffect per-draw 调色(Float4x5_Param) → 中性恒等 (宿主 C# 特性,URP 无绑定)
//   _ExposureParams 自动曝光                 → 1 (公式保留,IgnorePostExposure 语义不变)
//   GPU skinning/八面体顶点解码/SRP instancing buffer → Unity 原生 mesh + multi_compile_instancing
//   RayTracingReflection pass                → 无出货变体(Vulkan 包未编译),不移植
//   preZ+ZTest Equal 的 GBuffer 无 clip 设计  → 各 pass 独立 clip(_ALPHATEST_ON;净行为等价)
//
// 出货但属性存在而变体从未编译的死 keyword(仅保属性,无代码): _MACRO_NORMAL_MAP, _FAKEGLINT, _FULLY_TRANSPARENT。
// 逐模块的 blob 行号引证见各代码段头注。反编译 cbuffer 字段名不可信(Properties 错位混叠),一切按公式角色解码。
// ============================================================================================
Shader "HGRP/Lit"
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
        _NormalScale ("法线贴图强度", Range(0, 2)) = 1
        [ToggleUI] _TwoSidedNormal ("双面材质反转背面法线", Float) = 1
        // _MACRO_NORMAL_MAP: 死 keyword(全 rip 无出货变体), 属性保留仅为材质兼容
        [Toggle(_MACRO_NORMAL_MAP)] _UseMacroNormalMap ("使用本体法线(未出货)", Float) = 0
        _MacroNormalMap ("本体法线", 2D) = "bump" {}
        _MacroNormalMapScale ("本体法线贴图强度", Range(0, 2)) = 1
        _PorositySection ("吸水度", Float) = 1
        _PorosityFactorX ("吸水度影响因素X,受粗糙度影响", Range(-1, 1)) = 0.2
        _PorosityFactorY ("吸水度影响因素Y", Range(0, 1)) = 0.4
        _PorosityFactorZ ("吸水度影响因素Z,受金属度影响", Range(-1, 0)) = 0
        _BasePbrCfgSection ("基础 PBR 材质设置", Float) = 0
        _Metallic ("金属度滑杆", Range(0, 1)) = 0
        _Specular ("Specular (Default 0.5)", Range(0, 1)) = 0.5
        _RoughnessMin ("最小粗糙度", Range(0, 1)) = 0
        _RoughnessMax ("最大粗糙度", Range(0, 1)) = 1
        _OcclusionStrength ("AO 强度", Range(0, 1)) = 1

        _EnableEmissiveMap ("自发光/自发光", Float) = 0
        [Enum(EmissiveMap, 0, BaseColor A, 1, NormalMap B, 2, NormalMap A, 3, MRO A, 4, NOMAP, 5)] _EmissiveMaskChannel ("自发光通道", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _EmissiveUVSet ("UV 通道", Float) = 0
        [Enum(ChannelR, 0, ChannelRGBA, 1)] _EmissiveType ("单/四通道", Float) = 0
        _EmissiveMap ("自发光贴图", 2D) = "black" {}
        [ToggleUI] _AlbedoAffectEmissive ("自发光不受固有色影响", Float) = 1
        [ToggleUI] _IgnorePostExposure ("不受自动曝光影响", Float) = 1
        [HDR] _EmissiveColor ("自发光颜色", Color) = (1, 1, 1, 1)
        [HDR] _EmissiveColorG ("自发光颜色(G通道)", Color) = (0, 0, 0, 1)
        [HDR] _EmissiveColorB ("自发光颜色(B通道)", Color) = (0, 0, 0, 1)
        [HDR] _EmissiveColorA ("自发光颜色(A通道)", Color) = (0, 0, 0, 1)
        _EmissiveSpeed ("Emissive Speed", Vector) = (0, 0, 0, 0)
        [Toggle(_EMISSIVE_ANIM)] _EnableEmissiveAnim ("自发光/自发光呼吸", Float) = 0
        _EmissiveMapTilling ("Emmisive Tilling", Range(0.01, 20)) = 1
        _EmissiveAnimSpeed ("呼吸/故障闪烁的频率", Range(0, 80)) = 0
        _EmissiveAnimInterval ("呼吸时间比例(1是一直亮,2是一半时间亮)", Range(1, 10)) = 1
        [ToggleUI] _EmissiveAnimRandom ("Emmisive Anim Random", Float) = 0
        _EmissiveMinBrightness ("呼吸的最小亮度", Range(0, 0.5)) = 0
        [ToggleUI] _EnableEmissiveAnimFlicker ("故障闪烁效果", Float) = 0
        _BrightDarkRatio ("闪烁亮暗比例", Range(0.001, 0.99)) = 0.15
        [ToggleUI] _EnableRandomFlicker ("故障闪烁逐物件随机", Float) = 1
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
        [Enum(Normal_Roughness_AlbedoTint, 0, Normal_Roughness_AO, 1)] _DetailMode ("模式", Float) = 0
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
        [Enum(Off, 0, Legacy, 1, GWithNormal, 2)] _SwitchTriChannelTexture ("三通道Mask贴图 - 仅PC", Float) = 0
        [Header(R Channel)] [Space(10)] _MaskAlbedoR ("Mask R Color", Color) = (1, 0, 0, 1)
        _MaskRScale ("Mask R Scale", Range(0, 3)) = 0
        _MaskROffset ("Mask R Offset", Range(-1, 1)) = 0
        _MaskRoghnessR ("Mask R Roughness", Range(0, 1)) = 0.25
        _MaskMetallicR ("Mask R Metallic", Range(0, 1)) = 0
        [Header(G Channel)] _MaskAlbedoGTex ("Mask G Color Texture", 2D) = "white" {}
        _MaskNormalG ("Mask G Normal Texture", 2D) = "bump" {}
        _MaskNormalGStrength ("Mask G Normal Strength", Range(0, 2)) = 1
        _MaskAOGStrength ("Mask G AO Strength", Range(0, 1)) = 1
        _MaskAlbedoGUVTilling ("Mask G Color Tilling", Range(0, 20)) = 1
        _MaskAlbedoG ("Mask G Color", Color) = (0, 1, 0, 1)
        _MaskAlbedoTintG ("Mask G Color Tint", Color) = (0, 1, 0, 1)
        _MaskGScale ("Mask G Scale", Range(0, 3)) = 0
        _MaskGOffset ("Mask G Offset", Range(-1, 1)) = 0
        _MaskRoghnessGMin ("Mask G Roughness Min", Range(0, 1)) = 0
        _MaskRoghnessGMax ("Mask G Roughness Max", Range(0, 1)) = 1
        _MaskRoghnessG ("Mask G Roughness", Range(0, 1)) = 0.25
        _MaskMetallicG ("Mask G Metallic", Range(0, 1)) = 0
        [Header(B Channel)] _MaskAlbedoBTex ("Mask B Color Texture", 2D) = "white" {}
        _MaskAlbedoBUVTilling ("Mask B Color Tilling", Range(0, 20)) = 1
        _MaskAlbedoB ("Mask B Color", Color) = (0, 0, 1, 1)
        _MaskAlbedoTintB ("Mask B Color Tint", Color) = (0, 0, 1, 1)
        _MaskBScale ("Mask B Scale", Range(0, 3)) = 0
        _MaskBOffset ("Mask B Offset", Range(-1, 1)) = 0
        _MaskRoghnessBMin ("Mask B Roughness Min", Range(0, 1)) = 0
        _MaskRoghnessBMax ("Mask B Roughness Max", Range(0, 1)) = 1
        _MaskRoghnessB ("Mask B Roughness", Range(0, 1)) = 0.25
        _MaskMetallicB ("Mask B Metallic", Range(0, 1)) = 0

        _EnableParallaxMap ("视差/Parallax Map", Float) = 0
        [Enum(ParallaxEmissive, 0, PBR, 1)] _ParallaxMappingType ("视差模式", Float) = 0
        _ParallaxMaskChannel ("视差自发光蒙版通道", Float) = 0
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
        [ToggleUI] _UseWorldSpaceParallaxMask ("Use World Space Parallax Mask", Float) = 0
        [HDR] _ParallaxPatternColor ("Parallax Pattern Color", Color) = (0, 0, 0, 1)
        [HDR] _ParallaxPatternColorDark ("Parallax Pattern Color Dark", Color) = (0, 0, 0, 1)
        _ParallaxMaskMapColorStrength ("Parallax MaskMap Color Strength", Range(0, 20)) = 1
        _ParallaxLerpSchedule ("Parallax Lerp Schedule", Range(0, 30)) = 0
        _MaskWorldPosParams ("xz-世界坐标xz,y旋转,w范围", Vector) = (0, 0, 0, 1)
        _ParallaxSignControl ("交互物信号控制", Float) = 0
        [HDR] _WorldParallaxAdditionalColor ("World Parallax Additional Color", Color) = (0, 0, 0, 1)
        _WorldParallaxAdditionalLightMaskChannel ("WorldParallax Additional Light Mask", Float) = 0
        _ParallaxSignLerpFactor0 ("交互物信号控制强度(1,2,3,4强度)", Vector) = (0, 0, 0, 0)
        _ParallaxSignLerpFactor2 ("交互物信号控制强度(5强度)", Float) = 0
        _ParallaxSignLerpFactor1 ("交互物信号(y阈值,z视差世界高度,w视差本地颜色叠加范围)", Vector) = (0, 0, 0, 0)
        _ParallaxIntensity ("Parallax整体强度", Range(0, 1)) = 1

        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Alpha Test", Float) = 0
        _AlphaMaskChannel ("透贴通道", Float) = 0
        _AlphaClipThreshold ("Clip Threshold", Range(0, 1)) = 0.5

        _EnableInteriorMapping ("视差/InteriorMapping", Float) = 0
        _InteriorMappingIoR ("Interior Mapping IoR", Range(0, 2)) = 1
        [Enum(UV0, 0, UV1, 1)] _InteriorUVSet ("Interior parallax map UV set", Float) = 0
        [Enum(InteriorMapping, 0, InteriorParallax, 1)] InteriorParallaxMode ("Interior Parallax Mode", Float) = 0
        [Header(InteriorTex)] _InteriorCubeMap ("房间 Cube Map", Cube) = "black" {}
        _InteriorCurtainTex ("窗帘 Tex", 2D) = "black" {}
        [Header(RoomAttributes)] _InteriorMappingTillingScale ("房间Tilling", Float) = 1
        _InteriorRoomDepth ("房间Depth", Range(0.001, 0.999)) = 0.5
        _InteriorRotation ("CubeMap Rotation", Range(0, 3.99)) = 0
        _InteriorTextureRoughness ("室内纹理粗糙度", Range(0, 1)) = 0
        [Header(CurtainAttributes)] _CurtainTillingScale ("窗帘Tilling", Float) = 1
        _InteriorCurtainHeight ("窗帘上收高度", Range(0, 1)) = 0
        _CurtainParallaxMap ("视差阴影 Tex", 2D) = "black" {}
        _InteriorCurtainDistance ("视差阴影深度", Range(0, 0.5)) = 0.02
        _CurtainParallaxShadowStrength ("视差阴影强度", Range(0, 1)) = 1
        _CurtainParallaxRoughness ("视差阴影虚化程度", Range(0, 1)) = 0
        [Header(Color)] _Brightness ("Brightness", Range(0, 10)) = 1
        _HueShift ("HueShift", Range(-1, 1)) = 0
        _Saturation ("Saturation", Range(0, 10)) = 1
        _InteriorParallaxMap ("Interior parallax map", 2D) = "white" {}
        [HDR] _InteriorDepthColor ("Interior Depth Color", Color) = (1, 1, 1, 1)

        [Toggle(_TERRAIN_BLEND)] _EnableTerrainBlend ("混合/Terrain Blend", Float) = 0
        _TerrainBlendFactor ("Blend Factor", Float) = 1
        _TerrainBlendFallOff ("Blend FallOff", Float) = 1
        _TerrainBlendNormalFactor ("Normal Factor", Range(0, 1)) = 0
        _TerrainWetBlendFactor ("Blend Wet Factor", Float) = 1
        _TerrainWetBlendFallOff ("Blend Wet FallOff", Float) = 1
        _TerrainWetBaseColorFactor ("Terrain Wet BaseColor Factor", Range(0, 1)) = 0.5
        _TerrainWetRoughnessFactor ("Terrain Wet Roughness Factor", Range(0, 1)) = 0.3
        [ToggleUI] _WetBlendIgnoreDepth ("Wet Blend Ignore Depth", Float) = 0
        [ToggleUI] _TerrainBlendNoise ("Noise融合", Float) = 0
        _TerrainBlendNoiseTex ("Noise贴图", 2D) = "white" {}
        _TerrainBlendNoiseLerp ("Noise混合比例", Range(0, 1)) = 0.5
        [ToggleUI] _TerrainBlendFromHeight ("高度融合", Float) = 0
        _TerrainBlendHeightOffset ("高度融合偏移", Float) = 0
        _TerrainBlendLocalHeightOffset ("高度融合局部偏移", Range(0, 1)) = 0
        _TerrainBlendLocalHeightTransition ("高度融合局部范围", Range(0, 1)) = 0.01
        [ToggleUI] _TerrainBlendWithDeform ("形变融合", Float) = 0

        [Toggle(_PARALLAX_DEFORM)] _ParallaxDeform ("视差/Parallax Deform", Float) = 0
        [HideInInspector] _DeformMarchStep ("形变POM步数", Range(10, 20)) = 12
        _DeformHeightScale ("形变高度", Range(0, 0.5)) = 0.1
        _DeformNormalScale ("形变法线缩放", Range(0, 5)) = 1
        _DeformDetailNormalIntensity ("形变细节法线强度", Range(0, 1)) = 1
        [ToggleUI] _ParallaxDeformApplyLayerBlend ("形变应用Layer Blend混合结果", Float) = 0

        _LayerBlend ("混合/Layer Blend", Float) = 0
        [Enum(VertexColor, 0, MaskMap, 1, WorldTop, 2)] _LayerBlendType ("混合类型", Float) = 0
        [Enum(MaskMapR, 0, NROA, 1)] _LayerBlendMaskType ("混合区域Mask来源", Float) = 0
        _TopBlendSmoothness ("顶部混合过渡区域调整", Range(0.01, 1)) = 0.5
        _TopBlendThreshold ("顶部混合阈值", Range(-1, 1)) = 0.5
        _TopBlendWithBumpMap ("顶部混合使用基底贴图法线", Range(0, 1)) = 0
        [Enum(UV1, 0, UV0, 1)] _LayerBlendMaskUVType ("混合区域MaskUV通道", Float) = 0
        _LayerBlendMaskMap ("混合区域MaskMap(R)", 2D) = "white" {}
        [ToggleUI] _LayerBlendMaskParallaxPBR ("使用PBR视差", Float) = 0
        _LayerBlendMaskParallaxPBRStrength ("PBR视差强度", Range(0, 1)) = 0
        [Enum(UV0, 0, WorldXZ, 1, UV2, 2)] _LayerBlendUVType ("混合层UV通道", Float) = 0
        _Layer1BaseNormalIntensity ("混合后基底法线强度", Range(0, 1)) = 0
        _Layer1BaseMap ("BaseMap(RGB-固有色;A-可选)", 2D) = "white" {}
        _Layer1BumpMap ("NRO(RG-法线;B-粗糙度;A-AO)", 2D) = "bump" {}
        _Layer1Tilling ("混合层Tilling", Float) = 1
        _Layer1TintColor ("混合层Tint Color", Color) = (1, 1, 1, 1)
        _Layer1Saturation ("混合层饱和度", Range(-1, 0)) = 0
        _Layer1ColorBrighterScale ("混合层固有色变亮", Range(1, 3)) = 1
        _Layer1BumpScale ("混合层法线强度", Range(0, 2)) = 1
        [Enum(Slider, 0, BaseColorA, 1)] _LayerMetallicType ("金属度来源", Float) = 0
        _Layer1Metallic ("混合层金属度", Range(0, 1)) = 0
        _Layer1AOStrength ("混合层AO强度", Range(0, 1)) = 1
        [ToggleUI] _LayerBlendHeight ("是否计算高度混合", Float) = 1
        _BaseHeightMap ("基底层高度", 2D) = "grey" {}
        _LayerBlendHeightTransition ("高度混合过渡效果调整", Range(0.01, 1)) = 1
        [Toggle(_LAYERBLEND_NOISEBLEND)] _LayerBlendNoise ("开启Layer Blend Noise", Float) = 0
        _LayerBlendNoiseLevel ("Layer Blend Noise 程度", Range(0, 1)) = 0
        _LayerBlendNoiseThreshold ("Layer Blend Noise 阈值", Range(0, 1)) = 1
        _LayerBlendNoiseNormalStrength ("Layer Blend Noise 法线强度", Range(0, 5)) = 1
        _LayerBlendNoiseNormalSmoothness ("Layer Blend Noise 顺滑度", Range(0.01, 5)) = 1
        _LayerBlendVerticalFlowThreshold ("Layer Blend墙壁水流阈值", Range(0, 1)) = 0
        [Toggle(_LAYERBLEND_MOSS)] _LayerBlendMoss ("混合/Layer Blend Use Moss Shading", Float) = 0
        _Layer1FuzzyCoreDarkness ("Core Darkness", Range(0, 1)) = 0.2
        _Layer1FuzzyEdgeBrightness ("Edge Brightness", Range(0, 8)) = 1
        _Layer1FuzzyDarkPower ("Power Dark", Range(0.1, 10)) = 1
        _Layer1FuzzyBrightPower ("Power Bright", Range(0.1, 10)) = 6
        _Layer1FuzzyEdgeShadowRange ("Edge Shadow Range", Range(0.01, 1)) = 0.01
        _Layer1FuzzyEdgeShadowOffset ("Edge Shadow Offset", Range(0, 1)) = 0
        _Layer1FuzzyEdgeShadowIntensity ("Edge Shadow Intensity", Range(0, 1)) = 1
        _Layer1FuzzyNormalStrength ("Edge Normal Strength", Range(0, 1)) = 0

        [Toggle(_FOLIAGE_TRUNK)] _EnableFoliageTrunk ("植被/树干材质", Float) = 0
        [ToggleUI] _AnimateVertexHasPivot ("是否导出了pivot", Float) = 0
        _TrunkVertexAoStrength ("顶点色AO强度", Range(0, 1)) = 1
        [Space] _AnimateVertexTrunkIntensity ("树干风动幅度", Range(0, 2)) = 1
        _AnimateVertexTrunkFrequency ("树干风动频率", Range(0, 10)) = 2.5
        _AnimateVertexTrunkThreshold ("树干风动距离底部阈值", Range(0, 1)) = 0
        _AnimateVertexTrunkLeanFactor ("树干沿风向倾斜", Range(0, 1.5)) = 0.5
        [Space] [ToggleUI] _SwitchBranchWindMode ("切换(竹子)树枝风动效果", Float) = 0
        _AnimateVertexBranchIntensity ("树枝风动幅度", Range(0, 1.5)) = 0.25
        _AnimateVertexBranchFrequency ("树枝风动频率", Range(0, 20)) = 7
        _AnimateVertexBranchStiffness ("树枝摇摆硬度", Range(0, 1)) = 1
        _AnimateVertexBranchShapeCurve ("树枝形状曲线", Range(1, 3)) = 2
        _AnimateVertexBranchLeanFactor ("树枝沿风向倾斜", Range(0, 1.5)) = 0.5
        _AnimateVertexBranchDensity ("树枝风动噪声密度", Range(0.1, 3)) = 1.2
        [ToggleUI] _BranchWindUseLengthFactor ("树枝风动使用长度系数", Float) = 0
        [ToggleUI] _EnableTrunkRamp ("树干颜色渐变", Float) = 0
        _TrunkRampColor ("渐变颜色", Color) = (1, 1, 1, 1)
        _TrunkRampIntensity ("渐变强度", Range(0, 1)) = 1
        _TrunkRampRange ("渐变范围", Range(0, 1)) = 0
        _TrunkRampTransitionRange ("渐变过渡范围", Range(0.01, 1)) = 0.01
        [Toggle(_MOVING_BAMBOO)] _EnableMovingBamboo ("植被/竹子移动", Float) = 0
        _MovingBambooTrunkCurve ("主干弯曲曲线,0是直线", Range(0, 1)) = 0.3
        _MovingBambooTrunkIntensity ("主干晃动幅度", Range(0.01, 5)) = 1

        [Toggle(_SIMPLE_VERTEXANIM)] _EnableSimpleVertexAnim ("顶点相关/简单顶点动画", Float) = 0
        [Enum(ClothAndKite, 0, Rope, 1, Pendulum, 2)] _SimpleVertexAnimationType ("物体类型(布料风筝/绳子/摆锤类)", Float) = 0
        [ToggleUI] _Use_Gravity ("根据重力下垂(请先将pivot写入uv2uv3)", Float) = 0
        _GravityDir ("重力方向(默认y负)", Vector) = (0, -1, 0, 0)
        [ToggleUI] _Kite ("特殊物件-风筝", Float) = 0
        [ToggleUI] _Use_Custom_Anchor ("使用自定义摆锤运动锚点", Float) = 0
        _AnchorPoint ("自定义摆锤运动锚点", Vector) = (0, 0, 0, 0)
        _SimpleVertexAnimationWindIntensity ("动画幅度", Range(0, 20)) = 1
        _SimpleVertexAnimationWindFreq ("动画频率", Range(0, 50)) = 7
        _SimpleVertexAnimationWindSoftFactor ("动画软度,波浪宽度", Range(0, 1)) = 1
        _SelfRotationRange ("物体自转摆动幅度", Range(0, 90)) = 0
        _SelfRotationSpeed ("物体自转摆动速度", Range(0.1, 100)) = 5
        [ToggleUI] _Use_Custom_WindDir ("使用自定义风向", Float) = 0
        _MainDirectionAngle ("自定义风向", Range(-180, 180)) = 0
        _DirectionTendency ("方向倾向性(用于减轻穿模)", Range(-5, 5)) = 0
        _Stability ("物体刚度", Range(0, 1)) = 1
        _RopeAnchorAdjust ("绳子锚点矫正", Float) = 3
        [ToggleUI] _Add_Noise ("是否增加扰动", Float) = 0
        _NoiseOffsetTex ("扰动贴图", 2D) = "black" {}
        _NoiseOffsetTexTilling ("扰动贴图Tilling", Range(0, 5)) = 0.12
        _NoiseOffsetIntensity ("扰动强度", Range(0, 10)) = 1
        _NoiseOffsetSpeed ("扰动速度(XY:贴图在UV方向上的速度)", Vector) = (4, 1, 0, 0)
        _NoiseOffsetDir ("扰动方向(模型空间的xyz)", Vector) = (-0.3, -0.2, -0.2, 0)
        [Toggle(_GPU_CLOTH)] _EnableGpuCloth ("顶点相关/布料材质", Float) = 0
        [ToggleUI] _EnableClothNormalInfluence ("开启Mobile布料法线权重", Float) = 1

        _EnableSubsurface ("次表面3S/次表面散射", Float) = 0
        [Enum(Default, 0, BaseColor, 1)] _SubsurfaceShadingMode ("次表面散射模式", Float) = 0
        [HDR] _SubsurfaceColor ("次表面散射颜色", Color) = (1, 1, 1, 1)
        _SubsurfaceIndirect ("次表面散射对间接光影响", Range(0, 1)) = 1
        _MinSubsurfaceThickness ("最小厚度", Range(0, 1)) = 0
        _MaxSubsurfaceThickness ("最大厚度", Range(0, 1)) = 1
        _SubsurfaceWrapNoLBias ("背光偏移", Range(0, 2)) = 0
        [Toggle(_SUBSURFACE_THICKNESSMAP)] _EnableSubsurfaceThicknessMap ("使用厚度图", Float) = 0
        [Enum(General, 0, Fresnel, 1)] _SubsurfaceThicknessApproxMode ("厚度模拟选项", Float) = 0
        _SubsurfaceParallaxFresnel ("厚度菲尼尔模拟", Range(0, 5)) = 0
        [Enum(UV1, 0, UV0, 1)] _SubsurfaceMapMaskUVType ("次表面散射遮罩UV", Float) = 0
        _SubsurfaceMap ("次表面散射遮罩(R)", 2D) = "white" {}
        [Enum(SubsurfaceMap A, 0, BaseColor A, 1, NormalMap B, 2, NormalMap A, 3, MRO A, 4)] _SubsurfaceThicknessMapChannel ("厚度蒙版通道", Float) = 0
        _SubsurfaceParallaxMappingDistance ("厚度图视差距离", Range(0, 0.05)) = 0
        _SubsurfaceParallaxMappingLod ("厚度图视差LOD", Range(0, 5)) = 0
        [ToggleUI] _SubsurfaceEnableSelfShadowBias ("背投次表面自阴影", Float) = 0
        _SubsurfaceSelfShadowBias ("背投次表面自阴影偏移", Range(0, 10)) = 0
        [ToggleUI] _SubsurfaceApplyLayerBlend ("应用Layer Blend的混合结果", Float) = 0
        [ToggleUI] _SubsurfaceApplyLayerBlendInverse ("混合相反Layer Blend结果", Float) = 0
        [HideInInspector] _SubsurfaceHue ("Subsurface Hue", Float) = 1
        [HideInInspector] _SubsurfaceSaturation ("Subsurface Saturation", Float) = 1
        [HideInInspector] _SubsurfaceValue ("Subsurface Value", Float) = 1
        [Toggle] _UseSubsurfaceProfile ("次表面3S/预积分3S", Float) = 0
        [ToggleUI] _UseSimpleSubsurfaceProfile ("Simple预积分3S(使用地形profile)", Float) = 0
        _SubsurfaceNormalCurvatureTex ("预积分次表面法线曲率", 2D) = "black" {}
        _SubsurfaceNormalStrength ("次表面法线强度", Range(0, 1)) = 1
        _SubsurfaceCurvatureOffset ("次表面曲率偏移", Range(-1, 1)) = 0
        _SubsurfaceCurvatureScale ("次表面曲率缩放", Range(0, 5)) = 1
        [ToggleUI] _SubsurfaceProfileApplyLayerBlend ("预积分次表面应用Layer Blend混合结果", Float) = 0
        [ToggleUI] _SubsurfaceProfileApplyLayerBlendInverse ("混合相反Layer Blend结果", Float) = 0
        [HideInInspector] _SubsurfaceOriginNormalTex ("_SubsurfaceOriginNormalTex", 2D) = "black" {}
        [HideInInspector] _SubsurfaceNormalWorldRange ("_SubsurfaceNormalWorldRange", Float) = 1
        [HideInInspector] _SubsurfaceCurvatureTex ("_SubsurfaceCurvatureTex", 2D) = "black" {}

        _EnableCommonVAT ("顶点相关/CommonVAT 顶点动画", Float) = 0
        _CommonVATMap ("VAT 动画贴图(pos+rot矩阵)", 2D) = "black" {}
        _CommonVATMapParams ("VAT 参数(宽度,高度,保留,保留)", Vector) = (0, 0, 0, 0)
        _CommonVATCurrentFrame ("当前帧", Float) = 0
        [ToggleUI] _CommonVATAutoPlay ("自动播放", Float) = 1
        _CommonVATFPS ("动画帧率", Float) = 30
        _CommonVATBlendNormal ("法线混合强度", Range(0, 1)) = 0
        [IntRange] _CommonVATBoneCount ("实际骨骼数量(1-4)", Range(0, 4)) = 0
        [ToggleUI] _CommonVATAntiGhosting ("开启抗残影", Float) = 1

        [Toggle(_MATCAP)] _EnableMatcap ("其他/Matcap", Float) = 0
        _MatcapMap ("Matcap Map", 2D) = "black" {}
        _MatcapMapStrength ("MatcapMapStrength", Range(0, 1)) = 0.2
        [ToggleUI] _MatCapIgnorePostExposure ("不受自动曝光影响", Float) = 1

        // _FAKEGLINT: 死 keyword(全 rip 无出货变体), 属性保留仅为材质兼容
        [Toggle(_FAKEGLINT)] _EnableFakeGlint ("其他/FakeGlint(未出货)", Float) = 0
        [Enum(WorldTop, 0, UV0, 1, UV1, 2)] _GlintUVChannel ("UV选择", Float) = 0
        _GlintTopBlendSmoothness ("Glint Top Blend Smoothness", Range(0.01, 1)) = 0.5
        _GlintTopBlendThreshold ("Glint Top Blend Threshold", Range(-1, 1)) = 0.5
        _GlintStrength ("Glint强度", Range(0, 1.8)) = 1
        _GlintScale ("Glint缩放", Float) = 6
        _GlintThreshold ("Glint阈值", Range(0.93, 1)) = 0.98
        _GlintFadeDistance ("Glint消失距离", Range(0.1, 15)) = 5
        [HDR] _GlintColor ("Glint颜色", Color) = (1, 1, 1, 1)

        [Toggle(_FAKE_VOLUME)] _EnableFakeVolume ("视差/伪体积材质", Float) = 0
        _FakeVolumeBaseColor ("伪体积底色", Color) = (0, 0, 0, 0)
        _FakeVolumeIoR ("伪体积折射率", Range(0, 2)) = 1
        _FakeVolumeFresnelStrength ("伪体积菲涅尔", Range(0, 5)) = 0
        [Enum(TwoLayers, 0, TwoLayersCSM, 1, ThreeLayers, 2, SingleCSM, 3)] _FakeVolumeMode ("伪体积层级模式", Float) = 0
        _FakeVolumeMask ("伪体积蒙版", 2D) = "white" {}
        [ToggleUI] _FakeCrackUseLayerBlend ("裂缝使用LayerBlend结果", Float) = 0
        [Enum(UV0, 0, UV1, 1, WorldXZ, 2)] _FakeCrackUVSet ("裂缝层UV", Float) = 0
        _FakeCrackLayerTiling ("裂缝层Tiling缩放", Range(0, 5)) = 1
        [HDR] _FakeCrackTint ("裂缝底色", Color) = (1, 1, 1, 1)
        _FakeCrackHeightScale ("裂缝高度缩放", Range(0, 1)) = 0
        _FakeCrackDepth ("裂缝深度偏移", Range(0, 1)) = 0
        _FakeCrackMarchSteps ("裂缝步进数", Range(1, 3)) = 1
        [ToggleUI] _FakeRefractionUseLayerBlend ("折射使用LayerBlend结果", Float) = 0
        [Enum(UV0, 0, UV1, 1, WorldXZ, 2)] _FakeRefractionUVSet ("折射层UV", Float) = 0
        [HDR] _FakeRefractionTint ("折射底色", Color) = (1, 1, 1, 1)
        _FakeRefractionLayerTiling ("折射层Tiling缩放", Range(0, 5)) = 1
        [HDR] _FakeVolumeScatterExtinction ("散射层吸收率", Color) = (0, 0, 0, 1)
        [HDR] _FakeVolumeScatterAlbedo ("散射层反照率", Color) = (1, 1, 1, 1)
        _FakeRefractionHeightScale ("折射高度缩放", Range(0, 1)) = 0
        _FakeRefractionDepth ("折射深度偏移", Range(0, 5)) = 0
        _FakeRefractionMarchSteps ("折射步进数", Range(1, 3)) = 1
        [ToggleUI] _FakeDustUseLayerBlend ("杂质使用LayerBlend结果", Float) = 0
        [Enum(UV0, 0, UV1, 1, WorldXZ, 2)] _FakeDustUVSet ("杂质层UV", Float) = 0
        _FakeDustLayerTiling ("杂质层Tiling缩放", Range(0, 5)) = 1
        _FakeDustDepth ("杂质层深度偏移", Range(0, 1)) = 0
        _FakeDustFlowSpeed ("杂质层流动速度", Vector) = (0, 0, 0, 0)
        [HDR] _FakeDustTint ("杂质层底色", Color) = (1, 1, 1, 1)

        [Toggle(_USE_VERTOFFSET)] _UseVertexOffset ("顶点相关/Use Vertex Offset", Float) = 0
        _OffsetTex ("Offset Tex", 2D) = "white" {}
        _OffsetSpeed ("Offset Speed(XY: By Time,ZW:By Custom)", Vector) = (0, 0, 0, 0)
        _OffsetDir ("Offset Dir(XYZ: Axis,W:By CustomY)", Vector) = (0, 0, 0, 0)
        [Enum(Object, 0, World, 1, Normal, 2)] _OffsetSwitchDir ("Dir Switcher", Float) = 0
        _OffsetIntensity ("Offset Intensity", Float) = 0
        [ToggleUI] _Bi_Offset ("Use Two Direction Offset", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _OffsetUVSet ("Vertex Offset UV Set", Float) = 0
        [ToggleUI] _UseVertexColorMask ("以顶点色(A通道)为顶点偏移遮罩", Float) = 0
        [Toggle(_USE_VERTOFFSETMASK)] _UseVertexOffsetMask ("使用顶点偏移遮罩贴图", Float) = 0
        _OffsetMaskTex ("Offset Mask Tex", 2D) = "white" {}
        _OffsetMaskSpeed ("Offset Mask Speed(XY: By Time,ZW:By Custom)", Vector) = (0, 0, 0, 0)
        _OffsetMaskPower ("Offset Mask Power", Range(0, 5)) = 0
        [Toggle(_UV_ANIMATION)] _EnableUVAnimation ("UV动画/UV动画", Float) = 0
        _UVAnimationSpeed ("速度,xy是第1套UV,zw是第2套UV", Vector) = (0, 0, 0, 0)


        // ---- keyword 接线(港新增, 无 uniform;对应 HG 编辑器 dropdown→keyword 的映射) ----
        [Toggle(_TWO_BASEMAP)] _KwTwoBaseMap ("KW _TWO_BASEMAP(双贴图打包: metallic=base.a rough=nrm.b occ=nrm.a)", Float) = 0
        [Toggle(_EMISSIVE_MAP)] _KwEmissiveMap ("KW _EMISSIVE_MAP(=_EmissiveMaskChannel 0)", Float) = 0
        [Toggle(_EMISSIVE_MASK)] _KwEmissiveMask ("KW _EMISSIVE_MASK(=通道 1-4)", Float) = 0
        [Toggle(_EMISSIVE_NOMAP)] _KwEmissiveNoMap ("KW _EMISSIVE_NOMAP(=通道 5)", Float) = 0
        [Toggle(_TRI_CHANNEL_MASK_SWITCH_TEXTURE)] _KwTriChannelSwitchTex ("KW _TRI_CHANNEL_MASK_SWITCH_TEXTURE(=_SwitchTriChannelTexture>0)", Float) = 0
        [Toggle(_PARALLAX_MAP)] _KwParallaxMap ("KW _PARALLAX_MAP(=_EnableParallaxMap 且模式0)", Float) = 0
        [Toggle(_PARALLAX_MAP_PBR)] _KwParallaxMapPbr ("KW _PARALLAX_MAP_PBR(=模式1)", Float) = 0
        [Toggle(_PARALLAX_MAP_WORLDSPACE)] _KwParallaxWorld ("KW _PARALLAX_MAP_WORLDSPACE(=_UseWorldSpaceParallaxMask)", Float) = 0
        [Toggle(_INTERIORMAPPING)] _KwInteriorMapping ("KW _INTERIORMAPPING(=InteriorParallaxMode 0)", Float) = 0
        [Toggle(_INTERIOR_PARALLAX)] _KwInteriorParallax ("KW _INTERIOR_PARALLAX(=InteriorParallaxMode 1)", Float) = 0
        [Toggle(_LAYERBLEND)] _KwLayerBlend ("KW _LAYERBLEND(=_LayerBlendType 0 顶点色)", Float) = 0
        [Toggle(_LAYERBLEND_MASK)] _KwLayerBlendMask ("KW _LAYERBLEND_MASK(=_LayerBlendType 1)", Float) = 0
        [Toggle(_LAYERBLEND_TOP)] _KwLayerBlendTop ("KW _LAYERBLEND_TOP(=_LayerBlendType 2)", Float) = 0
        [Toggle(_TERRAIN_BLEND_NOISE)] _KwTerrainBlendNoise ("KW _TERRAIN_BLEND_NOISE(=_TerrainBlendNoise)", Float) = 0
        [Toggle(_TERRAIN_BLEND_FROM_HEIGHT)] _KwTerrainBlendHeight ("KW _TERRAIN_BLEND_FROM_HEIGHT(=_TerrainBlendFromHeight)", Float) = 0
        [Toggle(_SUBSURFACE)] _KwSubsurface ("KW _SUBSURFACE(=_EnableSubsurface 且模式1 BaseColor)", Float) = 0
        [Toggle(_SUBSURFACE_DEFAULTLIT)] _KwSubsurfaceDefaultLit ("KW _SUBSURFACE_DEFAULTLIT(=模式0 Default)", Float) = 0
        [Toggle(_SIMPLE_VERTEXANIM_CLOTH)] _KwSvaCloth ("KW _SIMPLE_VERTEXANIM_CLOTH(=类型0)", Float) = 0
        [Toggle(_SIMPLE_VERTEXANIM_ROPE)] _KwSvaRope ("KW _SIMPLE_VERTEXANIM_ROPE(=类型1)", Float) = 0
        [Toggle(_SIMPLE_VERTEXANIM_PENDULUM)] _KwSvaPendulum ("KW _SIMPLE_VERTEXANIM_PENDULUM(=类型2)", Float) = 0
        [Toggle(_VAT_SOFTBODY)] _KwVatSoftbody ("KW _VAT_SOFTBODY(=_EnableHoudiniVAT 且类型软体)", Float) = 0
        [Toggle(_VAT_RIGIDBODY)] _KwVatRigidbody ("KW _VAT_RIGIDBODY(=类型刚体)", Float) = 0
        [Toggle(_UNLOAD_ROT_TEX)] _KwUnloadRotTex ("KW _UNLOAD_ROT_TEX(=_B_UNLOAD_ROT_TEX)", Float) = 0
        [Toggle(_COMMONVAT_BONE_1)] _KwCommonVatBone1 ("KW _COMMONVAT_BONE_1(=_CommonVATBoneCount 1)", Float) = 0
        [Toggle(_COMMONVAT_BONE_3)] _KwCommonVatBone3 ("KW _COMMONVAT_BONE_3(=_CommonVATBoneCount 2-3)", Float) = 0
        [Toggle(_COMMONVAT_BONE_4)] _KwCommonVatBone4 ("KW _COMMONVAT_BONE_4(=_CommonVATBoneCount 4)", Float) = 0
        [Toggle(DITHER)] _KwDither ("KW DITHER(阴影/深度 LOD 抖抖淡出)", Float) = 0

        // ---- Advanced / 渲染状态 ----
        _AdvancedOptions ("Advanced Options", Float) = 0
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        _DitherScale ("Dither Scale", Range(0, 1)) = 1
        [ToggleUI] _DisableVerticalOcclusion ("不参与雨遮蔽", Float) = 0
        _VerticalOcclusionDepthBias ("雨遮蔽偏移", Range(0, 0.3)) = 0
        [ToggleUI] _DisableVerticalFlow ("没有墙壁水流", Float) = 0
        [ToggleUI] _TAAUNormalBiasReverse ("TAAU Normal偏移补偿", Float) = 0
        [Enum(Open, 0, Close, 1)] _AntiFlicker ("TAAU抗闪烁优化开关", Float) = 0
        [Toggle(_ZWRITE_OFF)] _DisableZWrite ("关闭深度写入(须同步设 _ZWrite=0)", Float) = 0
        [ToggleUI] _ReceiveDecals ("Receive Decals", Float) = 1
        [ToggleUI] _EnableBakedEmissive ("Enable Baked Emissive", Float) = 0
        [Toggle(_ENABLE_VERT_DEPTH_CLAMP)] _EnableVertDepthClamp ("支持mobile超远距离投影", Float) = 0
        [HideInInspector] _DitherTransparentAlpha ("Dither Transparent Alpha", Range(0, 1)) = 1
        [HideInInspector] _DitherTransparentOffset ("Dither Transparent Offset", Range(0, 1)) = 0.1
        [HideInInspector] _CutOffPosY ("_CutOffPosY", Float) = 0
        [HideInInspector] _UseCutOff ("_UseCutOff", Float) = 0
        [HideInInspector] _CutOffDirection ("_CutOffDirection", Vector) = (0, 1, 0, 0)

        // ---- Houdini VAT 数据属性(顶点动画驱动) ----
        [HideInInspector] _frameCount ("Frame Count", Float) = 0
        [HideInInspector] _boundMaxX ("Bound Max X", Float) = 0
        [HideInInspector] _boundMaxY ("Bound Max Y", Float) = 0
        [HideInInspector] _boundMaxZ ("Bound Max Z", Float) = 0
        [HideInInspector] _boundMinX ("Bound Min X", Float) = 0
        [HideInInspector] _boundMinY ("Bound Min Y", Float) = 0
        [HideInInspector] _boundMinZ ("Bound Min Z", Float) = 0
        [HideInInspector] _EnableHoudiniVAT ("Houdini VAT", Float) = 0
        [HideInInspector] _HoudiniVATType ("VAT类型", Float) = 0
        [HideInInspector] _B_autoPlayback ("Auto Playback", Float) = 0
        [HideInInspector] _gameTimeAtFirstFrame ("Game Time at First Time", Float) = 0
        [HideInInspector] _displayFrame ("Display Frame", Float) = 0
        [HideInInspector] _playbackSpeed ("Playback Speed", Float) = 0
        [HideInInspector] _houdiniFPS ("Houdini FPS", Float) = 0
        [HideInInspector] _TextureFormat ("Texture Format(On:HDR;Off:LDR)", Float) = 1
        [HideInInspector] _PositionTexture ("Position Texture", 2D) = "white" {}
        [HideInInspector] _BlendMeshNormalAndTangent ("使用Mesh的Normal和Tangent", Float) = 0
        [HideInInspector] _B_UNLOAD_ROT_TEX ("使用压缩ROT(存在PosTex.a)", Float) = 0
        [HideInInspector] _RotationTexture ("Rotation Texture", 2D) = "white" {}
        [HideInInspector] _B_surfaceNormals ("Support Surface Normal Maps", Float) = 0
        [HideInInspector] _B_pscaleAreInPosA ("Piece Scales Are In Position Alpha", Float) = 0
        [HideInInspector] _globalPscaleMul ("Global Piece Scale Multiplier", Float) = 1
        [HideInInspector] _B_stretchByVel ("Stretch by Velocity", Float) = 0
        [HideInInspector] _stretchByVelAmount ("Stretch by Velocity Amount", Float) = 0
        [HideInInspector] _B_animateFirstFrame ("Animate First Frame", Float) = 0

        // ---- 渲染状态插槽(材质驱动;对应各家族固定状态) ----
        [HideInInspector] _ZTestGBuffer ("_ZTestGBuffer", Float) = 4
        [HideInInspector] _ZWriteGBuffer ("_ZWrite", Float) = 1
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _StencilOpGBuffer ("__stencilOpGBuffer", Float) = 2
        [HideInInspector] _StencilOpPreZ ("__stencilOpPreZ", Float) = 0
        [HideInInspector] _ShadowBias ("_ShadowBias", Float) = 0
        [HideInInspector] _ShadowCullMode ("_ShadowCullMode", Float) = 2
        [HideInInspector] _ShadingModel ("_ShadingModel", Float) = 0
        [HideInInspector] _UseDeferredRendering ("Render Mode", Float) = 1
        [HideInInspector] _HlodBakeMaxEmissiveIntensity ("_HlodBakeMaxEmissiveIntensity", Float) = 0
        // HG 引擎全局 dial 的材质级落位(URP 无该引擎全局;默认中性)。.x=环境漫反射强度 .y=反射强度
        [HideInInspector] _EnvironmentGlobalParams0 ("EnvGlobalParams0", Vector) = (1, 1, 1, 0)
    }

    SubShader
    {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" "Queue" = "Geometry" }
        LOD 600

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"

        // ====================================================================================
        // UnityPerMaterial — 六家族 uniform 并集, 单 CBUFFER(SRP Batcher)。
        // 反编译里这些值散在 CB2UBO/type_UnityPerMaterial 原始槽位, 名字按公式角色回填。
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
            float _PorosityFactorZ;
            float _DisableVerticalOcclusion;
            float _AntiFlicker;
            float _AlphaMaskChannel;
            float _AlphaClipThreshold;
            float _DitherScale;
            // ---- 自发光家族 ----
            float4 _EmissiveMap_ST;
            float4 _EmissiveColor;
            float4 _EmissiveColorG;
            float4 _EmissiveColorB;
            float4 _EmissiveColorA;
            float4 _EmissiveSpeed;
            float _EnableEmissiveMap;   // MASK 路径乘数真身(b209:185 _NormalMap_ST.x 槽角色回填; HG 编辑器启用时写 1)
            float _EmissiveUVSet;
            float _EmissiveType;
            float _EmissiveMaskChannel;
            float _AlbedoAffectEmissive;
            float _IgnorePostExposure;
            float _EmissiveMapTilling;
            float _EmissiveAnimSpeed;
            float _EmissiveAnimInterval;
            float _EmissiveAnimRandom;
            float _EmissiveMinBrightness;
            float _EnableEmissiveAnimFlicker;
            float _BrightDarkRatio;
            float _EnableRandomFlicker;
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
            float4 _MaskAlbedoTintG;
            float4 _MaskAlbedoTintB;
            float _MaskUVSet;
            float _SwitchTriChannelTexture;
            float _MaskRScale;
            float _MaskROffset;
            float _MaskRoghnessR;
            float _MaskMetallicR;
            float _MaskNormalGStrength;
            float _MaskAOGStrength;
            float _MaskAlbedoGUVTilling;
            float _MaskGScale;
            float _MaskGOffset;
            float _MaskRoghnessGMin;
            float _MaskRoghnessGMax;
            float _MaskRoghnessG;
            float _MaskMetallicG;
            float _MaskAlbedoBUVTilling;
            float _MaskBScale;
            float _MaskBOffset;
            float _MaskRoghnessBMin;
            float _MaskRoghnessBMax;
            float _MaskRoghnessB;
            float _MaskMetallicB;
            // ---- 视差自发光/世界视差 ----
            float4 _ParallaxColor;
            float4 _ParallaxColorDark;
            float4 _ParallaxPatternColor;
            float4 _ParallaxPatternColorDark;
            float4 _MaskWorldPosParams;
            float4 _ParallaxSignLerpFactor0;
            float4 _ParallaxSignLerpFactor1;
            float4 _WorldParallaxAdditionalColor;
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
            // ---- InteriorMapping / InteriorParallax ----
            float4 _InteriorDepthColor;
            float _InteriorMappingIoR;
            float _InteriorUVSet;
            float _InteriorMappingTillingScale;
            float _InteriorRoomDepth;
            float _InteriorRotation;
            float _InteriorTextureRoughness;
            float _CurtainTillingScale;
            float _InteriorCurtainHeight;
            float _InteriorCurtainDistance;
            float _CurtainParallaxShadowStrength;
            float _CurtainParallaxRoughness;
            float _Brightness;
            float _HueShift;
            float _Saturation;
            // ---- Terrain Blend ----
            float _TerrainBlendFactor;
            float _TerrainBlendFallOff;
            float _TerrainBlendNormalFactor;
            float _TerrainWetBlendFactor;
            float _TerrainWetBlendFallOff;
            float _TerrainWetBaseColorFactor;
            float _TerrainWetRoughnessFactor;
            float _WetBlendIgnoreDepth;
            float _TerrainBlendNoiseLerp;
            float _TerrainBlendHeightOffset;
            float _TerrainBlendLocalHeightOffset;
            float _TerrainBlendLocalHeightTransition;
            float _TerrainBlendWithDeform;
            // ---- Parallax Deform ----
            float _DeformMarchStep;
            float _DeformHeightScale;
            float _DeformNormalScale;
            float _DeformDetailNormalIntensity;
            float _ParallaxDeformApplyLayerBlend;
            // ---- Layer Blend ----
            float4 _Layer1TintColor;
            float4 _TrunkRampColor;
            float _LayerBlendType;
            float _LayerBlendMaskType;
            float _TopBlendSmoothness;
            float _TopBlendThreshold;
            float _TopBlendWithBumpMap;
            float _LayerBlendMaskUVType;
            float _LayerBlendMaskParallaxPBR;
            float _LayerBlendMaskParallaxPBRStrength;
            float _LayerBlendUVType;
            float _Layer1BaseNormalIntensity;
            float _Layer1Tilling;
            float _Layer1Saturation;
            float _Layer1ColorBrighterScale;
            float _Layer1BumpScale;
            float _LayerMetallicType;
            float _Layer1Metallic;
            float _Layer1AOStrength;
            float _LayerBlendHeight;
            float _LayerBlendHeightTransition;
            float _LayerBlendNoiseLevel;
            float _LayerBlendNoiseThreshold;
            float _LayerBlendNoiseNormalStrength;
            float _LayerBlendNoiseNormalSmoothness;
            float _LayerBlendVerticalFlowThreshold;
            float _Layer1FuzzyCoreDarkness;
            float _Layer1FuzzyEdgeBrightness;
            float _Layer1FuzzyDarkPower;
            float _Layer1FuzzyBrightPower;
            float _Layer1FuzzyEdgeShadowRange;
            float _Layer1FuzzyEdgeShadowOffset;
            float _Layer1FuzzyEdgeShadowIntensity;
            float _Layer1FuzzyNormalStrength;
            // ---- 植被(树干/竹子) ----
            float _AnimateVertexHasPivot;
            float _TrunkVertexAoStrength;
            float _AnimateVertexTrunkIntensity;
            float _AnimateVertexTrunkFrequency;
            float _AnimateVertexTrunkThreshold;
            float _AnimateVertexTrunkLeanFactor;
            float _SwitchBranchWindMode;
            float _AnimateVertexBranchIntensity;
            float _AnimateVertexBranchFrequency;
            float _AnimateVertexBranchStiffness;
            float _AnimateVertexBranchShapeCurve;
            float _AnimateVertexBranchLeanFactor;
            float _AnimateVertexBranchDensity;
            float _BranchWindUseLengthFactor;
            float _EnableTrunkRamp;
            float _TrunkRampIntensity;
            float _TrunkRampRange;
            float _TrunkRampTransitionRange;
            float _MovingBambooTrunkCurve;
            float _MovingBambooTrunkIntensity;
            // ---- 简单顶点动画 ----
            float4 _GravityDir;
            float4 _AnchorPoint;
            float4 _NoiseOffsetSpeed;
            float4 _NoiseOffsetDir;
            float _SimpleVertexAnimationType;
            float _Use_Gravity;
            float _Kite;
            float _Use_Custom_Anchor;
            float _SimpleVertexAnimationWindIntensity;
            float _SimpleVertexAnimationWindFreq;
            float _SimpleVertexAnimationWindSoftFactor;
            float _SelfRotationRange;
            float _SelfRotationSpeed;
            float _Use_Custom_WindDir;
            float _MainDirectionAngle;
            float _DirectionTendency;
            float _Stability;
            float _RopeAnchorAdjust;
            float _Add_Noise;
            float _NoiseOffsetTexTilling;
            float _NoiseOffsetIntensity;
            float _EnableClothNormalInfluence;
            // ---- 次表面散射 ----
            float4 _SubsurfaceColor;
            float _SubsurfaceShadingMode;
            float _SubsurfaceIndirect;
            float _MinSubsurfaceThickness;
            float _MaxSubsurfaceThickness;
            float _SubsurfaceWrapNoLBias;
            float _SubsurfaceThicknessApproxMode;
            float _SubsurfaceParallaxFresnel;
            float _SubsurfaceMapMaskUVType;
            float _SubsurfaceThicknessMapChannel;
            float _SubsurfaceParallaxMappingDistance;
            float _SubsurfaceParallaxMappingLod;
            float _SubsurfaceEnableSelfShadowBias;
            float _SubsurfaceSelfShadowBias;
            float _SubsurfaceApplyLayerBlend;
            float _SubsurfaceApplyLayerBlendInverse;
            float _SubsurfaceHue;
            float _SubsurfaceSaturation;
            float _SubsurfaceValue;
            float _UseSubsurfaceProfile;
            float _UseSimpleSubsurfaceProfile;
            float _SubsurfaceNormalStrength;
            float _SubsurfaceCurvatureOffset;
            float _SubsurfaceCurvatureScale;
            float _SubsurfaceProfileApplyLayerBlend;
            float _SubsurfaceProfileApplyLayerBlendInverse;
            float _SubsurfaceNormalWorldRange;
            // ---- CommonVAT / Houdini VAT ----
            float4 _CommonVATMapParams;
            float _CommonVATCurrentFrame;
            float _CommonVATAutoPlay;
            float _CommonVATFPS;
            float _CommonVATBlendNormal;
            float _CommonVATAntiGhosting;
            float _frameCount;
            float _boundMaxX;
            float _boundMaxY;
            float _boundMaxZ;
            float _boundMinX;
            float _boundMinY;
            float _boundMinZ;
            float _HoudiniVATType;
            float _HoudiniVATInParticle;     // VAT uv 源开关(liteffect b268:546 真名; lit b516 同槽 _CutOffPosY 混叠)
            float _B_autoPlayback;
            float _gameTimeAtFirstFrame;
            float _displayFrame;
            float _playbackSpeed;
            float _houdiniFPS;
            float _TextureFormat;
            float _BlendMeshNormalAndTangent;
            float _B_surfaceNormals;
            float _B_pscaleAreInPosA;
            float _globalPscaleMul;
            float _B_stretchByVel;
            float _stretchByVelAmount;
            float _B_animateFirstFrame;
            // ---- Matcap ----
            float _MatcapMapStrength;
            float _MatCapIgnorePostExposure;
            // ---- FakeVolume 家族 ----
            float4 _FakeVolumeBaseColor;
            float4 _FakeCrackTint;
            float4 _FakeRefractionTint;
            float4 _FakeVolumeScatterExtinction;
            float4 _FakeVolumeScatterAlbedo;
            float4 _FakeDustFlowSpeed;
            float4 _FakeDustTint;
            float _FakeVolumeIoR;
            float _FakeVolumeFresnelStrength;
            float _FakeVolumeMode;
            float _FakeCrackUseLayerBlend;
            float _FakeCrackUVSet;
            float _FakeCrackLayerTiling;
            float _FakeCrackHeightScale;
            float _FakeCrackDepth;
            float _FakeCrackMarchSteps;
            float _FakeRefractionUseLayerBlend;
            float _FakeRefractionUVSet;
            float _FakeRefractionLayerTiling;
            float _FakeRefractionHeightScale;
            float _FakeRefractionDepth;
            float _FakeRefractionMarchSteps;
            float _FakeDustUseLayerBlend;
            float _FakeDustUVSet;
            float _FakeDustLayerTiling;
            float _FakeDustDepth;
            // ---- 顶点偏移 / UV 动画 ----
            float4 _OffsetTex_ST;
            float4 _OffsetMaskTex_ST;
            float4 _OffsetSpeed;
            float4 _OffsetDir;
            float4 _OffsetMaskSpeed;
            float4 _UVAnimationSpeed;
            float _OffsetSwitchDir;
            float _OffsetIntensity;
            float _Bi_Offset;
            float _OffsetUVSet;
            float _UseVertexColorMask;
            float _OffsetMaskPower;
            // ---- 通用杂项 ----
            float _VerticalOcclusionDepthBias;
            float _DisableVerticalFlow;
            float _DitherTransparentAlpha;
            float _DitherTransparentOffset;
            float _CutOffPosY;
            float _UseCutOff;
            float4 _CutOffDirection;
            // HG 引擎全局 dial 的材质级落位(URP 无对应全局;默认=中性)。
            // .x=环境漫反射强度(_EnvironmentGlobalParams0.x) .y=反射强度(已折入 GFGP0.z)。
            float4 _EnvironmentGlobalParams0;
        CBUFFER_END

        // ====================================================================================
        // 纹理绑定(逐纹理 sampler;反编译 sampler 名跨纹理乱接线, 唯一可靠语义=贴图导入设置)
        // ====================================================================================
        TEXTURE2D(_BaseColorMap);        SAMPLER(sampler_BaseColorMap);
        TEXTURE2D(_NormalMap);           SAMPLER(sampler_NormalMap);
        TEXTURE2D(_MROMap);              SAMPLER(sampler_MROMap);
        TEXTURE2D(_EmissiveMap);         SAMPLER(sampler_EmissiveMap);
        TEXTURE2D(_DetailMap);           SAMPLER(sampler_DetailMap);
        TEXTURE2D(_MaskMap);             SAMPLER(sampler_MaskMap);
        TEXTURE2D(_MaskAlbedoGTex);      SAMPLER(sampler_MaskAlbedoGTex);
        TEXTURE2D(_MaskNormalG);         SAMPLER(sampler_MaskNormalG);
        TEXTURE2D(_MaskAlbedoBTex);      SAMPLER(sampler_MaskAlbedoBTex);
        TEXTURE2D(_ParallaxMap);         SAMPLER(sampler_ParallaxMap);
        TEXTURE2D(_ParallaxNoiseMap);    SAMPLER(sampler_ParallaxNoiseMap);
        TEXTURE2D(_ParallaxMaskMap);     SAMPLER(sampler_ParallaxMaskMap);
        TEXTURECUBE(_InteriorCubeMap);   SAMPLER(sampler_InteriorCubeMap);
        TEXTURE2D(_InteriorCurtainTex);  SAMPLER(sampler_InteriorCurtainTex);
        TEXTURE2D(_CurtainParallaxMap);  SAMPLER(sampler_CurtainParallaxMap);
        TEXTURE2D(_InteriorParallaxMap); SAMPLER(sampler_InteriorParallaxMap);
        TEXTURE2D(_TerrainBlendNoiseTex);SAMPLER(sampler_TerrainBlendNoiseTex);
        TEXTURE2D(_LayerBlendMaskMap);   SAMPLER(sampler_LayerBlendMaskMap);
        TEXTURE2D(_Layer1BaseMap);       SAMPLER(sampler_Layer1BaseMap);
        TEXTURE2D(_Layer1BumpMap);       SAMPLER(sampler_Layer1BumpMap);
        TEXTURE2D(_BaseHeightMap);       SAMPLER(sampler_BaseHeightMap);
        TEXTURE2D(_SubsurfaceMap);       SAMPLER(sampler_SubsurfaceMap);
        TEXTURE2D(_SubsurfaceNormalCurvatureTex); SAMPLER(sampler_SubsurfaceNormalCurvatureTex);
        TEXTURE2D(_MatcapMap);           SAMPLER(sampler_MatcapMap);
        TEXTURE2D(_FakeVolumeMask);      SAMPLER(sampler_FakeVolumeMask);
        TEXTURE2D(_OffsetTex);           SAMPLER(sampler_OffsetTex);
        TEXTURE2D(_OffsetMaskTex);       SAMPLER(sampler_OffsetMaskTex);
        TEXTURE2D(_NoiseOffsetTex);      SAMPLER(sampler_NoiseOffsetTex);
        TEXTURE2D(_CommonVATMap);        SAMPLER(sampler_CommonVATMap);
        TEXTURE2D(_PositionTexture);     SAMPLER(sampler_PositionTexture);
        TEXTURE2D(_RotationTexture);     SAMPLER(sampler_RotationTexture);
        // VAT 采样态(b516:136-139 声明序): 位置=LinearClamp, 旋转=LinearRepeat(内联采样器)
        SamplerState hg_linear_clamp_sampler;
        SamplerState hg_linear_repeat_sampler;
        // 视差噪声 march 越界累加 -> 点采样 + repeat(b717/b221:294 SampleGrad Point*)
        SamplerState hg_point_repeat_sampler;

        // ====================================================================================
        // 引擎面全局(HG VFX 系统喂入;宿主可 Shader.SetGlobalVector, 未设时按门控自然退化:
        //   _VFXParams0=0 → 角色距离环仅 _ParallaxCharPos 开时以原点为球心;
        //   _VFXParams2=0 → 交互信号环 sat(-inf)=0 消隐)。.w 时间槽已换 _Time.y 不经此变量。
        // ====================================================================================
        float4 _VFXParams0;   // xyz = 角色世界位置(视差亮环球心, b717/b221:327-330)
        float4 _VFXParams2;   // xy = 交互信号世界 XZ, z = 半径, w = 强度(b717/b221:331-334)

        // ====================================================================================
        // 反编译幻数常量(位型逐位保留)
        // ====================================================================================
        static const float3 HG_LUMA = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709, b11:1308
        static const float HG_EPS_VIEWLEN   = 9.9999999392252902907785028219223e-09; // 1e-8 视向量 rsqrt 守卫, b11:258
        static const float HG_EPS_NORMAL_Z  = 1.000000016862383526387164645044e-16;  // 1e-16 法线 Z 下限, b283:177
        static const float HG_EPS_HALF      = 6.103515625e-05;                        // 2^-14 半精度 rsqrt 守卫, b11:929
        static const float HG_EPS_VIS       = 9.9999997473787516355514526367188e-05;  // 1e-4 Smith Vis 分母下限, b11:961
        static const float HG_DIELECTRIC_F0 = 0.07999999821186065673828125;           // 0.08*_Specular 电介质 F0 基, b11:298
        static const float HG_GRAZING_FLOOR = 0.0476190485060214996337890625;          // 1/21 多散射掠射地板, b11:957
        static const float HG_NORMAL_DEADZONE = 0.01200000010430812835693359375;       // _TWO_BASEMAP 法线死区, b11:270

        // ====================================================================================
        // 顶点输入/插值器(冻结接口)。HG 的 GPU skinning/八面体法线流/双帧 MV 插值器已由
        // Unity 原生 mesh + URP MotionVectors 域替代(移植纪律: 引擎面替换)。
        // ====================================================================================
        struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS   : NORMAL;
            float4 tangentOS  : TANGENT;
            float4 color      : COLOR;
            float4 uv0        : TEXCOORD0;   // xy=材质 UV0; zw=VAT uv(粒子模式, b516:562-563)
            float4 uv1        : TEXCOORD1;   // xy=材质 UV1/VAT uv; w=VAT 逐粒子帧(b516:564)
            float4 uv2        : TEXCOORD2;   // 植被 pivot(_FOLIAGE_TRUNK)/SVA 重力 pivot/刚体 VAT pivot(b520)
            float4 uv3        : TEXCOORD3;   // SVA 重力 pivot 下半(uv2uv3)/刚体 VAT pivot
            UNITY_VERTEX_INPUT_INSTANCE_ID
        };

        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float3 positionWS : TEXCOORD0;
            float4 uv         : TEXCOORD1;   // .xy=uv0 .zw=uv1 (raw; _ST/UV集选择在片元, b11:263-267)
            float3 normalWS   : TEXCOORD2;
            float4 tangentWS  : TEXCOORD3;   // .w = 切线符号
            float4 color      : TEXCOORD4;
            float  fogFactor  : TEXCOORD5;
            float2 uv2        : TEXCOORD6;   // LayerBlend UV2 模式/植被 pivot 消费
            UNITY_VERTEX_INPUT_INSTANCE_ID
            UNITY_VERTEX_OUTPUT_STEREO
        };

        // 表面数据(基面 + 模块扩展槽)
        struct HgSurface
        {
            float3 albedo;       // tint-cover 后固有色 (b11:277-279 _338..)
            float3 normalWS;
            float  metallic;
            float  roughness;    // 感知粗糙度 = lerp(_RoughnessMin,_RoughnessMax,tex) (b11:281 _360)
            float  occlusion;
            float3 emission;
            float  alpha;
            float3 f0;           // lerp(0.08*_Specular, albedo, metallic) (b11:298-305)
            float3 diffuse;      // albedo*(1-metallic) (b11:299-301 _506..)
            float3 sssTint;              // SSS 色调×量 (b52:809-811 HSV 三角×厚度)
            float  sssAmount;            // SSS 标量(厚度反×遮罩×Value)
        };

        // ====================================================================================
        // 基础工具(b11 逐位)
        // ====================================================================================
        // 视向量: 透视=normalize(camPos-P)(1e-8 守卫), 正交=-View 第2行 (b11:253-262)。
        // 返回 xyz=V, w=|camPos-P|(HG _207, 雾/细节渐隐用视距)。
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

        // Karis 解析 EnvBRDF: 环境反射的 F0 scale/bias (b11:306-309 _517-534 + b11:1241 _3100)。
        void HgEnvBRDF(float roughness, float NoV, float3 f0, out float envScale, out float envBias)
        {
            float omr  = mad(roughness, -1.0, 1.0);
            float envF = mad(min(omr * omr, exp2(NoV * -9.27999973297119140625)), omr,
                             mad(roughness, -0.0274999998509883880615234375, 0.0425000004470348358154296875));
            envScale = mad(envF, -1.03999996185302734375, mad(roughness, -0.572000026702880859375, 1.03999996185302734375));
            envBias  = mad(envF,  1.03999996185302734375, mad(roughness,  0.02199999988079071044921875, -0.039999999105930328369140625))
                     * saturate(f0.g * 50.0);
        }

        // EnvBRDFApprox 有理 DFG 多项式 (b11:955 _2180)。
        // HG 直接光多散射项额外乘 T8(NoV).x*T8(NoL).x 分离和 LUT 积(b11:962 _2237)——T8 为引擎
        // 预积分图无 URP 绑定, 解析 dfg 即其批准替代(同一多项式来源)。
        float HgEnvBRDFApproxDFG(float roughness)
        {
            float t = mad(roughness, -1.0, 1.0);
            return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875, -0.076194703578948974609375),
                                  1.04997003078460693359375), 0.4092549979686737060546875),
                       0.999000012874603271484375);
        }

        // 单光源能量括号 (b11:944-965 主光 == b11:1198-1214 点光, 完全同式):
        //   spec = D*Vis*F (GGX a2=rough⁴ + Smith 高度相关 Vis(1e-4 地板) + Schlick F)
        //   msDiff_c = (dfg/(1-dfg)) * gz_c² / (1 - gz_c*(1-dfg)), gz=lerp(F0,1,1/21)
        //   energy_c = min(max(msDiff_c + min(spec_c, 2048), 0), 1000)
        // 调用方: color += mad(energy, NoL, NoL*diffuse) * lightColor*atten (光强 scale 折入 lightColor)。
        float3 HgDirectLightEnergy(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
        {
            float a2 = (roughness * roughness) * (roughness * roughness);        // b11:947-948 (_2156/_2157)
            float nv = min(NoV, 1.0);                                            // b11:946 (_2155)
            float d  = mad(mad(NoH, a2, -NoH), NoH, 1.0);                        // b11:949 (_2160)
            float visDenom = nv  * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2))
                           + NoL * sqrt(mad(mad(-nv,  a2, nv),  nv,  a2))
                           + HG_EPS_VIS;                                         // b11:961 (_2214 分母)
            float DVis = (a2 / (d * d)) * (0.5 / visDenom);                      // b11:961 (_2214)

            float omVoH = mad(-VoH, 1.0, 1.0);                                   // b11:950 (_2166)
            float sq    = omVoH * omVoH;
            float quad  = sq * sq;
            float Fc    = omVoH * quad;                                          // (1-VoH)^5, b11:953 (_2169)
            float omFc  = mad(-quad, omVoH, 1.0);                                // 1-(1-VoH)^5, b11:960 (_2195)

            float  dfg   = HgEnvBRDFApproxDFG(roughness);                        // b11:955 (_2180)
            float  omDfg = mad(-dfg, 1.0, 1.0);                                  // b11:956 (_2183)
            float  dfgE  = dfg / omDfg;                                          // T8 LUT 积的解析替代 (b11:962 _2237)
            float3 gz    = mad(1.0.xxx - f0, HG_GRAZING_FLOOR, f0);              // b11:957-959 (_2190..)
            float3 msDiff = (dfgE * (gz * gz)) / mad(-gz, omDfg, 1.0.xxx);       // b11:963 A 项
            float3 specE  = DVis * mad(f0, omFc.xxx, Fc.xxx);                    // b11:963 min(_2214*mad(F0,_2195,_2169),2048)
            return min(max(msDiff + min(specE, 2048.0.xxx), 0.0.xxx), 1000.0.xxx);
        }

        // ====================================================================================
        // SSS 直接光波瓣(b52:1207-1213 前向真值 == b397:140-144 GBuffer DEFAULTLIT 同式):
        //   wrap = saturate(NoL*2/3 + 1/3); curve = lerp(1, 1.6667*wrap^1.5, amount);
        //   back = pow(saturate(-V·L), 12) * (3 - 2.9*amount);
        //   lobe = back*(1 - curve/2π) + curve/2π; ×saturate(NoL - 自阴影偏移 + 2) 门(b397:141)。
        // ====================================================================================
        float HgSssLobe(float amount, float rawNoL, float VdotL)
        {
            float wrap  = clamp(mad(rawNoL, 0.666666686534881591796875, 0.3333333432674407958984375), 0.0, 1.0); // b52:1207
            float curve = mad(amount, mad(wrap * sqrt(wrap), 1.66666662693023681640625, -1.0), 1.0);             // b397:142
            float back  = exp2(log2(clamp(-VdotL, 0.0, 1.0)) * 12.0) * mad(amount, -2.900000095367431640625, 3.0); // b52:1210
            float lobe  = mad(back, mad(-curve, 0.15915493667125701904296875, 1.0), curve * 0.15915493667125701904296875);
            float gate  = clamp((rawNoL - _SubsurfaceSelfShadowBias * _SubsurfaceEnableSelfShadowBias) + 2.0, 0.0, 1.0); // b397:141 (_530)
            return lobe * gate;
        }

        // ====================================================================================
        // <<HOOK:VERTEX_MODULES>>  顶点动画模块(逐特性填充)
        // ====================================================================================

        // _UV_ANIMATION: 顶点期 UV 滚动(lit b614 变体; 模块填充覆盖)。默认直通。
        float2 HgAnimatedUV0(float2 uv0)
        {
        #ifdef _UV_ANIMATION
            uv0 = mad(_UVAnimationSpeed.xy, _Time.y, uv0);   // b614: uv0 + speed.xy*t (HG 连续秒→_Time.y)
        #endif
            return uv0;
        }
        float2 HgAnimatedUV1(float2 uv1)
        {
        #ifdef _UV_ANIMATION
            uv1 = mad(_UVAnimationSpeed.zw, _Time.y, uv1);   // b614: uv1 + speed.zw*t
        #endif
            return uv1;
        }


        // ====================================================================================
        // Houdini VAT(对象空间整体改写)。lit 血统 blob: 软体 Sub0_Pass0_Vertex_b516 /
        // 刚体 b520 / 压缩旋转 _UNLOAD_ROT_TEX b552 对(liteffect b268/b290/b308 同织物交叉证)。
        //   帧钟: 自动=floor(frac(fps/(cnt-0.01)*(t-t0)*speed)*cnt)+1(时钟 PerDraw 保留槽→_Time.y);
        //         手动=floor([粒子帧 uv1.w] + 逐实例偏移(SceneEffect per-draw→中性0) + _displayFrame)。
        //   bounds 整数位=包围盒, 小数位藏系数: U pad=mad(_boundMinZ,10,-ceil(10*_boundMinZ))+1(b516:563);
        //   V 翻转=mad(_boundMaxX,10,1)+floor(-10*_boundMaxX)(b516:566)。V<=0.1 行塌原点保形(b516:571-577)。
        // ====================================================================================
        #if defined(_VAT_SOFTBODY) || defined(_VAT_RIGIDBODY)

        // 软体四元数旋转基(b516:591-597/621-627 展开式逐位): 法线=R(q)·(-1,0,0), 切线=R(q)·(0,1,0)
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
        // 刚体旋转(b520 == liteffect b290:634-641 专用 mad 型, 分量置换随小三分量布局, 逐位保形)
        float3 HgVatRigidRotate(float4 q, float3 v)
        {
            float t1 = mad(v.y, q.w, mad(q.x, v.x, -(v.z * q.y)));
            float t2 = mad(v.z, q.w, mad(q.y, v.y, -(v.x * q.z)));
            float t3 = mad(v.x, q.w, mad(q.z, v.z, -(v.y * q.x)));
            return float3(mad(mad(q.z, t2, -(q.x * t1)), 2.0, v.x),
                          mad(mad(q.x, t3, -(q.y * t2)), 2.0, v.y),
                          mad(mad(q.y, t1, -(q.z * t3)), 2.0, v.z));
        }

        void HgApplyHoudiniVat(Attributes IN, inout float3 positionOS, inout float3 normalOS, inout float4 tangentOS)
        {
            bool inParticle = _HoudiniVATInParticle != 0.0;                       // b516:560 (_647, 槽角色回填)
            bool hdr        = _TextureFormat != 0.0;                              // b516:561 (_648)
            float uvY = inParticle ? IN.uv0.w : IN.uv1.y;                         // b516:562 (_659)

            float frameRaw = (_B_autoPlayback != 0.0)
                ? floor(frac(((_houdiniFPS / (-0.00999999977648258209228515625 + _frameCount))
                              * (_Time.y - _gameTimeAtFirstFrame)) * _playbackSpeed) * _frameCount) + 1.0
                : floor((inParticle ? IN.uv1.w : 0.0) + _displayFrame);           // b516:564 (_746)
            float frame01 = (frameRaw - 1.0) / _frameCount;
            float fracF   = frac(abs(frame01));                                   // b516:565
            float signedF = (frame01 >= -frame01) ? fracF : -fracF;               // b516:566

            float uPad  = mad(_boundMinZ, 10.0, -ceil(10.0 * _boundMinZ)) + 1.0;  // b516:563
            float vFlip = mad(_boundMaxX, 10.0, 1.0) + floor(-10.0 * _boundMaxX); // b516:566
            float2 vatUV;
            vatUV.x = (inParticle ? IN.uv0.z : IN.uv1.x) * uPad;                  // b516:563 (_679)
            vatUV.y = mad(-vFlip, ((signedF * _frameCount) / _frameCount) + (1.0 - uvY), 1.0); // b516:566 (_763)

            float4 posTex = SAMPLE_TEXTURE2D_LOD(_PositionTexture, hg_linear_clamp_sampler, vatUV, 0.0); // b516:567 (t1)
            bool keepRest = 0.100000001490116119384765625 >= uvY;                 // b516:571 (_799)

            float blendMesh = _BlendMeshNormalAndTangent;                         // b516:603-605/668 槽角色回填
            float maskN = (_B_surfaceNormals != 0.0) ? 1.0 : 0.0;                 // b516:598 (_892)

        #if defined(_VAT_SOFTBODY)
            float3 posDelta = hdr ? posTex.xyz
                : float3(mad(_boundMaxX - _boundMinX, posTex.x, _boundMinX),      // b516:572 (_819)
                         mad(_boundMaxY - _boundMinY, posTex.y, _boundMinY),      // b516:574 (_821)
                         mad(_boundMaxZ - _boundMinZ, posTex.z, _boundMinZ));     // b516:576 (_823)
            float3 vatPos = keepRest ? float3(0.0, 0.0, 0.0) : (posDelta + positionOS);

            float3 vatN;
            float3 vatT;
        #if defined(_UNLOAD_ROT_TEX)
            // 压缩旋转: posTex.a 十位(5+5) Lambert 方位角法线(b552 对 == liteffect b308:561-584); 切线无 VAT 源
            {
                float high = floor(posTex.w * 32.0);
                float f1 = mad(high, 0.12698413431644439697265625, -2.0);          // 4/31.5
                float f2 = mad(mad(-high, 32.0, posTex.w * 1024.0), 0.12698413431644439697265625, -2.0);
                float negSum = -dot(float2(f1, f2), float2(f1, f2));
                float s = sqrt(mad(negSum, 0.25, 1.0));
                vatN = float3(min(max(-(f1 * s), -1.0), 1.0),
                              min(max(mad(negSum, 0.5, 1.0), -1.0), 1.0),
                              min(max(f2 * s, -1.0), 1.0));
                vatN *= rsqrt(dot(vatN, vatN));
                vatT = float3(0.0, 0.0, 0.0);
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
            // lerp(掩码后 VAT 基, mesh 基, blend) (b516:603-605/628-630; 实例矩阵 1/col长度平方 因子随归一化消去)
            normalOS      = lerp(vatN * maskN, normalOS, blendMesh);
            tangentOS.xyz = lerp(vatT * maskN, tangentOS.xyz, blendMesh);
            tangentOS.w   = lerp(0.0, tangentOS.w, blendMesh);                    // b516:668 (flip 符号由 TBN 期施加)
        #endif // _VAT_SOFTBODY

        #if defined(_VAT_RIGIDBODY)
            float4 rotTexR = SAMPLE_TEXTURE2D_LOD(_RotationTexture, hg_linear_repeat_sampler, vatUV, 0.0);
            // 小三分量解码顺序保形: a<-tex.z, b<-tex.x, c<-tex.y (b520 == b290:577-582)
            float qa = hdr ? rotTexR.z : (rotTexR.z - 0.5) * 2.0;
            float qb = hdr ? rotTexR.x : (rotTexR.x - 0.5) * 2.0;
            float qc = hdr ? rotTexR.y : (rotTexR.y - 0.5) * 2.0;
            float qBig = sqrt(mad(-qa, qa, mad(-qc, qc, mad(-qb, qb, 1.0))));
            float4 q;
            switch (uint(int(floor(posTex.w * 4.0))))                             // posTex.a*4=最大分量索引(b290:588-630)
            {
                case 0u:  q = float4(qa, qb, qc, qBig);   break;
                case 1u:  q = float4(qa, qBig, qc, qb);   break;
                case 2u:  q = float4(qa, qb, -qBig, -qc); break;
                case 3u:  q = float4(-qBig, qb, qc, -qa); break;
                default:  q = float4(qa, qb, qc, qBig);   break;
            }
            float3 offset;                                                        // pivot=(-uv2.x, [粒子?uv2.z:uv3.x], 1-[粒子?uv2.w:uv3.y])
            offset.x = IN.uv2.x + positionOS.x;                                   // b290:631 (_1172)
            offset.y = positionOS.y - (inParticle ? IN.uv2.z : IN.uv3.x);         // b290:632 (_1173)
            offset.z = positionOS.z - (1.0 - (inParticle ? IN.uv2.w : IN.uv3.y)); // b290:633 (_1174)
            float3 rotated = HgVatRigidRotate(q, offset);
            float3 posDecodedR = hdr ? posTex.xyz
                : float3(mad(posTex.x, _boundMaxX - _boundMinX, _boundMinX),
                         mad(posTex.y, _boundMaxY - _boundMinY, _boundMinY),
                         mad(posTex.z, _boundMaxZ - _boundMinZ, _boundMinZ));
            float3 vatPosR = mad(_globalPscaleMul.xxx, rotated, posDecodedR);     // b290:637-639

            float fr01 = frameRaw / _frameCount;                                  // 帧1守卫(b290:640-649)
            float frF  = frac(abs(fr01));
            bool isFrame1 = (((fr01 >= -fr01) ? frF : -frF) * _frameCount) == 1.0;
            float3 finalPos = (_B_animateFirstFrame != 0.0) ? vatPosR : (isFrame1 ? positionOS : vatPosR);
            positionOS = keepRest ? float3(0.0, 0.0, 0.0) : finalPos;

            float3 rnR = HgVatRigidRotate(q, normalOS);
            float3 rtR = HgVatRigidRotate(q, tangentOS.xyz);
            normalOS      = lerp((rnR * rsqrt(dot(rnR, rnR))) * maskN, normalOS, blendMesh);
            tangentOS.xyz = lerp((rtR * rsqrt(dot(rtR, rtR))) * maskN, tangentOS.xyz, blendMesh);
            tangentOS.w   = lerp(0.0, tangentOS.w, blendMesh);
        #endif // _VAT_RIGIDBODY
        }
        #endif // VAT

        // 对象空间顶点动画(VAT/GPU 布料: 整体改写 position/normal)。默认无操作。
        void HgApplyVertexAnimationOS(Attributes IN, inout float3 positionOS, inout float3 normalOS, inout float4 tangentOS)
        {
        #if defined(_VAT_SOFTBODY) || defined(_VAT_RIGIDBODY)
            HgApplyHoudiniVat(IN, positionOS, normalOS, tangentOS);
        #endif
            // <<HOOK:VERTEX_OS>>  (剩余: _GPU_CLOTH b556 / _COMMONVAT_BONE_1/3/4 b600/602/604)
        }

        // 世界空间加性位移(顶点偏移/风/植被)。默认零。
        float3 HgVertexAnimationDeltaWS(Attributes IN, float3 positionWS, float3 normalWS)
        {
            float3 deltaWS = float3(0.0, 0.0, 0.0);
            // <<HOOK:VERTEX_WS>>

            // ============================================================
            // _USE_VERTOFFSET(+MASK)(lit 顶点 b508/b510 逐位): 贴图驱动世界位移。
            //   uvSel=lerp(uv0,uv1,_OffsetUVSet)*_OffsetTex_ST+速度*t; scalar=tex.x*(1+_Bi_Offset)-_Bi_Offset;
            //   方向: 1=World(raw _OffsetDir) 2=Normal(O2W*法线, 正变换非逆转置) 其他=Object(O2W*_OffsetDir);
            //   Δ=dir*_OffsetIntensity*scalar*顶点色A遮罩*(1-m01 per-draw 项); MASK 再乘 mad(0.2*_OffsetMaskPower, maskTex-1, 1)。
            //   前帧二次求值(b510 _LastTimeParameters)=MV 域, URP 弃。
            // ============================================================
            // ============================================================
            // _SIMPLE_VERTEXANIM(littransparent b59 干净名真值; CLOTH/风筝分支):
            //   门: 顶点色A≠0 且 (风幅+扰动幅)≠0 (b59:188)。
            //   ⚠️deg→rad 常数=0.01746725477278232574462890625(非 π/180, 载荷级保位)。
            //   cos/sin 用 4/5 阶多项式(blob 原式), 风向=lerp(引擎全局风向(_WindGlobalParams0.zw,无宿主→退自定基), 自定基, _Use_Custom_WindDir)。
            //   风钟 _WindGlobalParams0.y(引擎风时)→_Time.y; MV 双钟第二求值=弃。
            // ============================================================
        #if defined(_SIMPLE_VERTEXANIM) && !defined(_SIMPLE_VERTEXANIM_ROPE) && !defined(_SIMPLE_VERTEXANIM_PENDULUM)
            if (!(IN.color.w == 0.0 || (_SimpleVertexAnimationWindIntensity + _NoiseOffsetIntensity) == 0.0)) // b59:188
            {
                float ang = 0.01746725477278232574462890625 * _MainDirectionAngle;   // b59:193 (_128)
                float a2 = ang * ang;
                float a3 = ang * a2;
                float windCos = mad(a2 * a2, 0.013899999670684337615966796875, mad(-a2, 0.500400006771087646484375, 1.0));       // b59:196 (_138)
                float windSin = mad(a2 * a3, 0.008340000174939632415771484375, mad(-a3, 0.1667999923229217529296875, ang));      // b59:197 (_144)
                // 引擎全局风向 _WindGlobalParams0.zw 无 URP 宿主 → 忠实中性=自定基(同角), custom=1 时严格 1:1
                float dirX = mad(_Use_Custom_WindDir, windCos - windCos, windCos);
                float dirZ = mad(_Use_Custom_WindDir, windSin - windSin, windSin);
                float instPhase = UNITY_MATRIX_M._m03;                                // b59:205 CB2[inst+3].x
                float phase = _Time.y * _SimpleVertexAnimationWindFreq;               // b59:198 (_WGP0.y→秒)
                float amplitude, wave;
                if (_Kite != 0.0)                                                     // b59:199
                {
                    amplitude = 0.0500000007450580596923828125 * _SimpleVertexAnimationWindIntensity;   // b59:204
                    wave = sin(mad(_Kite, mad(IN.positionOS.y, _SimpleVertexAnimationWindSoftFactor, -(IN.color.w * 3.1415927410125732421875)), phase) + instPhase) * IN.positionOS.y; // b59:205 (对象空间Y!)
                }
                else
                {
                    amplitude = 0.5 * _SimpleVertexAnimationWindIntensity;            // b59:192
                    wave = sin(mad(-IN.color.w, 3.1400001049041748046875, mad(-positionWS.z, _SimpleVertexAnimationWindSoftFactor, phase)) + instPhase); // b59:210 (世界Z)
                }
                float waveScaled = (wave + _DirectionTendency) + 1.0;                 // b59:230/235
                float perDrawScale = 1.0 - unity_ObjectToWorld._m01;                  // b59 _226 同 VERTOFFSET
                deltaWS += float3(amplitude * (waveScaled * dirX), 0.0, amplitude * (waveScaled * dirZ)) * (IN.color.w * perDrawScale); // b59:239-241
            }
        #endif

            // ============================================================
            // _SIMPLE_VERTEXANIM_ROPE(lit 顶点 rope 变体逐位): 绕锚高摆转 + 可选噪声。
            //   anchorY=m11·_RopeAnchorAdjust+m13; swing=(0.5I·sin(freq·t+m03))·0.1(多项式 sin/cos);
            //   轴=normalize2(m22,−m02); ΔX=−amp·swSin·ax(−m02)·armY; ΔY=amp·(anchorY+armY·swCos−worldY);
            //   噪声: uv=(uv0.x·Tilling+t·speed·0.1, 纯滚动), dir=M·float4(_NoiseOffsetDir), ×强度×tex;
            //   Δ×COLOR.w×(1−m01); Last 时钟二次求值=MV 弃。
            // ============================================================
        #if defined(_SIMPLE_VERTEXANIM) && defined(_SIMPLE_VERTEXANIM_ROPE)
            if (!(IN.color.w == 0.0 || (_SimpleVertexAnimationWindIntensity + _NoiseOffsetIntensity) == 0.0)) // 门同 b59:188
            {
                float halfI  = 0.5 * _SimpleVertexAnimationWindIntensity;                                   // b:275 (_146)
                float anchorY = mad(unity_ObjectToWorld._m11, _RopeAnchorAdjust, unity_ObjectToWorld._m13); // b:276 (_159)
                float swing = (halfI * sin(mad(_SimpleVertexAnimationWindFreq, _Time.y, unity_ObjectToWorld._m03))) * 0.100000001490116119384765625; // b:277
                float sw2 = swing * swing;
                float sw3 = sw2 * swing;
                float swSin = mad(sw2 * sw3, 0.008340000174939632415771484375, mad(-sw3, 0.1667999923229217529296875, swing));  // b:280
                float swCos = mad(sw2 * sw2, 0.013899999670684337615966796875, mad(-sw2, 0.500400006771087646484375, 1.0));      // b:293 内层
                float axA = unity_ObjectToWorld._m22;                                                        // b:282 (_197)
                float axB = -unity_ObjectToWorld._m02;                                                       // b:283 (_198)
                float axInv = rsqrt(dot(float2(axA, axB), float2(axA, axB)));                                // b:284
                float ax206 = axInv * (-unity_ObjectToWorld._m02);                                           // b:285
                float ax207 = axInv * ( unity_ObjectToWorld._m22);                                           // b:286
                float armY = positionWS.y - anchorY;                                                         // b:287 (_211)
                float amp = mad(_Stability, mad(-IN.color.w, halfI, 1.0), halfI * IN.color.w);               // b:288 (_223)
                float dX = amp * ((positionWS.x + (-(swSin * ax206)) * armY) - positionWS.x);                // b:292 (_237)
                float dY = amp * ((anchorY + armY * swCos) - positionWS.y);                                  // b:293 (_238)
                float dZ = amp * ((positionWS.z + (swSin * ax207) * armY) - positionWS.z);                   // b:294 (_239)
                if (_Add_Noise != 0.0)                                                                       // b:295 (_243)
                {
                    float2 nUV = float2(mad(IN.uv0.x, _NoiseOffsetTexTilling, (_Time.y * _NoiseOffsetSpeed.x) * 0.100000001490116119384765625),
                                        mad(IN.uv0.y, 0.0,                    (_Time.y * _NoiseOffsetSpeed.y) * 0.100000001490116119384765625)); // b:304 (V=纯滚动)
                    float nS = SAMPLE_TEXTURE2D_LOD(_NoiseOffsetTex, sampler_NoiseOffsetTex, nUV, 0.0).x;
                    float3 nDir = mul(unity_ObjectToWorld, float4(_NoiseOffsetDir.xyz, _NoiseOffsetDir.w)).xyz; // b:306-308 (M·float4, .w默认0=纯旋转)
                    dX = mad(nDir.x * _NoiseOffsetIntensity, nS, dX);
                    dY = mad(nDir.y * _NoiseOffsetIntensity, nS, dY);
                    dZ = mad(nDir.z * _NoiseOffsetIntensity, nS, dZ);
                }
                float perDrawScale = 1.0 - unity_ObjectToWorld._m01;
                deltaWS += float3(dX, dY, dZ) * (IN.color.w * perDrawScale);                                 // b:346-348,692
            }
        #endif

            // ============================================================
            // _SIMPLE_VERTEXANIM_PENDULUM(lit 顶点 pendulum 变体逐位): Rodrigues 绕风向轴刚摆 + 自转 sweep。
            //   轴=normalize(−风Z, 风X, −风X)(字面); 自转角=sin(t·_SelfRotationSpeed+m03)·_SelfRotationRange·0.008733627386391162872314453125;
            //   锚=lerp(实例原点, _AnchorPoint, _Use_Custom_Anchor); Δ=amp·(锚+R·arm(自转2D 旋 X/Z)−world)·colorW·(1−m01)。
            // ============================================================
        #if defined(_SIMPLE_VERTEXANIM) && defined(_SIMPLE_VERTEXANIM_PENDULUM)
            if (!(IN.color.w == 0.0 || (_SimpleVertexAnimationWindIntensity + _NoiseOffsetIntensity) == 0.0)) // b:268
            {
                float halfI = 0.5 * _SimpleVertexAnimationWindIntensity;
                float ang = 0.01746725477278232574462890625 * _MainDirectionAngle;
                float a2 = ang * ang;
                float a3 = ang * a2;
                float wCos = mad(a2 * a2, 0.013899999670684337615966796875, mad(-a2, 0.500400006771087646484375, 1.0));    // b:281 (_154)
                float wSin = mad(a2 * a3, 0.008340000174939632415771484375, mad(-a3, 0.1667999923229217529296875, ang));   // b:282 (_160)
                // 引擎全局风向 _WindGlobalParams0.zw 无宿主→自定基回退(custom=1 严格 1:1), b:283-284
                float dirX = mad(_Use_Custom_WindDir, wCos - wCos, wCos);
                float dirZ = mad(_Use_Custom_WindDir, wSin - wSin, wSin);
                float3 instOrigin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);
                float3 anchor = float3(mad(_Use_Custom_Anchor, _AnchorPoint.x - instOrigin.x, instOrigin.x),
                                       mad(_Use_Custom_Anchor, _AnchorPoint.y - instOrigin.y, instOrigin.y),
                                       mad(_Use_Custom_Anchor, _AnchorPoint.z - instOrigin.z, instOrigin.z));               // b:287-289
                float swing = (halfI * sin(mad(_SimpleVertexAnimationWindFreq, _Time.y, instOrigin.x))) * 0.100000001490116119384765625; // b:290
                float sw2 = swing * swing;
                float sw3 = swing * sw2;
                float swCos = mad(sw2 * sw2, 0.013899999670684337615966796875, mad(-sw2, 0.500400006771087646484375, 1.0)); // b:292 (_229)
                float swSin = mad(sw2 * sw3, 0.008340000174939632415771484375, mad(-sw3, 0.1667999923229217529296875, swing)); // b:294 (_234)
                float ax0 = -dirZ;                                                                                          // b:296 (_237)
                float ax1 = dirX;                                                                                           // b:297 (_240)
                float ax2 = -dirX;                                                                                          // b:298 (_241, 字面 −风X)
                float axInv = rsqrt(dot(float3(ax0, ax1, ax2), float3(ax0, ax1, ax2)));                                     // b:299
                float r0 = axInv * ax0;                                                                                     // b:300 (_246)
                float r1 = axInv * ax1;                                                                                     // b:301 (_248)
                float r2 = axInv * ax2;                                                                                     // b:302 (_249)
                float omc = 1.0 - swCos;                                                                                    // b:303 (_251)
                float sR1 = swSin * r1;                                                                                     // b:304 (_252)
                float sR0 = swSin * r0;                                                                                     // b:305 (_253)
                float sR2 = swSin * r2;                                                                                     // b:306 (_254)
                float3 arm = positionWS - anchor;                                                                           // b:307-309
                float srAng = (sin(mad(_Time.y, _SelfRotationSpeed, instOrigin.x)) * _SelfRotationRange) * 0.008733627386391162872314453125; // b:310 (_278)
                float sr2 = srAng * srAng;
                float sr3 = srAng * sr2;
                float srCos = mad(sr2 * sr2, 0.013899999670684337615966796875, mad(-sr2, 0.500400006771087646484375, 1.0)); // b:312 (_284)
                float srSin = mad(sr2 * sr3, 0.008340000174939632415771484375, mad(-sr3, 0.1667999923229217529296875, srAng)); // b:314 (_289)
                float t291 = r2 * r0;                                                                                       // b:315 (_291)
                float t292 = r1 * r0;                                                                                       // b:316 (_292)
                float t298 = r1 * r2;                                                                                       // b:317 (_298)
                float rotX = dot(float3(mad(r0 * r0, omc, swCos), mad(t291, omc, -sR1), mad(t292, omc, sR2)), arm);          // b:318 (_308)
                float rotZ = dot(float3(mad(t292, omc, -sR2), mad(t298, omc, sR0), mad(r1 * r1, omc, swCos)), arm);          // b:319 (_314)
                float rotY = dot(float3(mad(t291, omc, sR1), mad(r2 * r2, omc, swCos), mad(t298, omc, -sR0)), arm);          // b:351 Y 行
                float amp = mad(_Stability, mad(-IN.color.w, halfI, 1.0), halfI * IN.color.w);                               // b:320 (_337)
                float dX = (amp * (-positionWS.x + (anchor.x + dot(float2(srCos, srSin), float2(rotX, rotZ))))) * IN.color.w; // b:350 (_497)
                float dY = (amp * (-positionWS.y + (anchor.y + rotY))) * IN.color.w;                                          // b:351 (_498)
                float dZ = (amp * (-positionWS.z + (anchor.z + dot(float2(-srSin, srCos), float2(rotX, rotZ))))) * IN.color.w; // b:352 (_499)
                float perDrawScale = 1.0 - unity_ObjectToWorld._m01;
                deltaWS += float3(dX, dY, dZ) * perDrawScale;
            }
        #endif

        #ifdef _USE_VERTOFFSET
            {
                float2 uvSel = mad(IN.uv1.xy, _OffsetUVSet.xx, (1.0 - _OffsetUVSet) * IN.uv0.xy);              // b508:259-261
                float2 offUV = mad(uvSel, _OffsetTex_ST.xy, _OffsetTex_ST.zw) + _OffsetSpeed.xy * _Time.y;      // b508:260-261,587 (_TimeParameters.w→秒)
                float offsetScalar = mad(SAMPLE_TEXTURE2D_LOD(_OffsetTex, sampler_OffsetTex, offUV, 0.0).x,
                                         1.0 + _Bi_Offset, -_Bi_Offset);                                        // b508:262,587 (_979)
                float3 dirWS;
                if (_OffsetSwitchDir == 1.0)
                    dirWS = _OffsetDir.xyz;                                                                     // b508:263 World
                else if (_OffsetSwitchDir == 2.0)
                    dirWS = TransformObjectToWorldDir(IN.normalOS, false);                                      // b508:264,270 Normal(正变换)
                else
                    dirWS = TransformObjectToWorldDir(_OffsetDir.xyz, false);                                   // b508:270 Object
                dirWS *= _OffsetIntensity;                                                                      // b508:270 (_296 ×_CommonVATCurrentFrame槽)
                float vertexColorMask = (0.0 < _UseVertexColorMask) ? IN.color.w : 1.0;                          // b508:273 (_307)
                float perDrawScale = 1.0 - unity_ObjectToWorld._m01;                                             // b508:274 (_312)
            #ifdef _USE_VERTOFFSETMASK
                float2 maskUV = mad(uvSel, _OffsetMaskTex_ST.xy, _OffsetMaskTex_ST.zw) + _OffsetMaskSpeed.xy * _Time.y; // b510:290-291
                float maskFactor = mad(0.20000000298023223876953125 * _OffsetMaskPower,
                                       SAMPLE_TEXTURE2D_LOD(_OffsetMaskTex, sampler_OffsetMaskTex, maskUV, 0.0).x - 1.0, 1.0); // b510:292,607
                offsetScalar *= maskFactor;
            #endif
                deltaWS += dirWS * (offsetScalar * vertexColorMask * perDrawScale);                              // b508:588-590
            }
        #endif
            return deltaWS;
        }

        // 共享顶点内核: 对象→世界→裁剪 + TBN 基 + raw 双 UV(_ST/UV 集选择留给片元, b11:263-267)。
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
            OUT.tangentWS  = float4(tangentWS, tangentOS.w * GetOddNegativeScale());
            OUT.uv         = float4(HgAnimatedUV0(IN.uv0.xy), HgAnimatedUV1(IN.uv1.xy));
            OUT.color      = IN.color;
            OUT.fogFactor  = ComputeFogFactor(OUT.positionCS.z);
            OUT.uv2        = IN.uv2.xy;
            return OUT;
        }

        // ====================================================================================
        // 片元 UV 派生(b11:263-267): uv=(uv0+set*(uv1-uv0))*_ST.xy+_ST.zw, MRO 与法线共用。
        // ====================================================================================
        void HgComputeBaseUVs(float4 uv, out float2 uvBase, out float2 uvPbr)
        {
            float2 duv = uv.zw - uv.xy;
            uvBase = mad(mad(_BaseUVSet.xx,       duv, uv.xy), _BaseColorMap_ST.xy, _BaseColorMap_ST.zw);
            uvPbr  = mad(mad(_BasePbrMapUVSet.xx, duv, uv.xy), _NormalMap_ST.xy,    _NormalMap_ST.zw);
        }

        // ====================================================================================
        // <<HOOK:SURFACE_MODULES>>  片元表面特性模块(逐特性填充)
        // ====================================================================================


        // ====================================================================================
        // 视差自发光(_PARALLAX_MAP, lit b717 全链 == liteffect b221:185-348 同织物交叉证;
        // _PARALLAX_MAP_WORLDSPACE 扩展 = liteffect b227->b333 融合差分)。返回加进自发光的 RGB。
        // 引擎面: 片元 InvVP 世界重建->positionWS; _VFXParams0/2=角色位/交互信号全局;
        // 自动曝光除数(_ParallaxIgnorePostExposure 门)URP=1 中性。
        // _PARALLAX_MAP_PBR(b809)=另一模块(POM 改写基面 PBR 采样), 见 SURFACE_PRENORMAL 钩注。
        // ====================================================================================
        #ifdef _PARALLAX_MAP
        float3 HgParallaxEmissive(Varyings IN, float3 shadedNormalWS, float baseA, float nrmZ, float nrmW, float mroA)
        {
            // ---- 遮罩(b221:213-224): 2U 贴图路径 或 通道链x(1-_ParallaxMaskByLayerBlend) ----
            float mask;
            if (_UseParallaxMask != 0.0)
            {
                float chanNA = mad(_AlphaMaskChannel, -baseA + nrmW, baseA);       // b221:216 (_321)
                mask = mad(_UseParallaxMask,
                           mad(-chanNA, _BaseColor.w, SAMPLE_TEXTURE2D(_ParallaxMaskMap, sampler_ParallaxMaskMap, IN.uv.zw).x),
                           chanNA * _BaseColor.w);                                 // b221:217 (raw uv1)
            }
            else
            {
                float sel = mad(clamp(_ParallaxMaskChannel, 0.0, 1.0), -baseA + nrmZ, baseA);       // b221:221
                sel = mad(clamp(_ParallaxMaskChannel - 1.0, 0.0, 1.0), -sel + nrmW, sel);           // b221:222
            #ifndef _TWO_BASEMAP
                sel = mad(clamp(_ParallaxMaskChannel - 2.0, 0.0, 1.0), -sel + mroA, sel);           // 3-map 链尾(MRO A)
            #endif
                mask = mad(_ParallaxMaskByLayerBlend, -sel, sel);                  // b221:223 (_368)
            }
            if (!(0.00999999977648258209228515625 < mask))                        // b221:228 门
                return float3(0.0, 0.0, 0.0);

            float3 V = HgViewDirWS(IN.positionWS).xyz;
            float tSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
            float3 bitan = tSign * cross(IN.normalWS, IN.tangentWS.xyz);
            float tv = dot(IN.tangentWS.xyz, V);                                   // b221:244
            float bv = dot(bitan, V);                                              // b221:245
            float nv = dot(IN.normalWS, V);                                        // b221:246
            float rlen = rsqrt(dot(float3(tv, bv, nv), float3(tv, bv, nv)));       // b221:247

            float2 uvP = mad(_ParallaxMapUVType.xx, IN.uv.zw - IN.uv.xy, IN.uv.xy); // b221:248-249
            float2 gx = float2(ddx_coarse(IN.uv.x), ddx_coarse(IN.uv.y)) * _GlobalMipBias.y; // b221:250-253
            float2 gy = float2(ddy_coarse(IN.uv.x), ddy_coarse(IN.uv.y)) * _GlobalMipBias.y;

            float steps = min(_ParallaxMarchNum, 20.0);                            // b221:254 (出货 int 位型, 数值等价)
            float stepH = 1.0 / steps;                                             // b221:255
            float viewBias = mad(nv, rlen, 0.4199999868869781494140625);           // b221:256
            float viewDen  = max(rlen * nv, 0.001000000047497451305389404296875);  // b221:257
            float2 dirUV = float2((((rlen * tv) / viewBias) / viewDen) * (-_ParallaxStrength),
                                  (((rlen * bv) / viewBias) / viewDen) * (-_ParallaxStrength)); // b221:258-260
            float2 stepUV = stepH * dirUV;                                         // b221:261-262

            // 陡视差 march(b221:278-320 逐位)
            float height = 1.0 - stepH;
            float2 offCur = stepUV;                                                // 首采已进一步
            float2 offPrev = float2(0.0, 0.0);
            float texPrev = 0.0;
            float heightPrev = 1.0;
            float texHit = 0.0;
            float iter = 0.0;
            for (;;)
            {
                if (!(iter < steps + 1.0)) { texHit = texPrev; break; }
                float texCur = SAMPLE_TEXTURE2D_GRAD(_ParallaxNoiseMap, hg_point_repeat_sampler,
                                   mad(uvP, _ParallaxNoiseMapTilling.xx, offCur), gx, gy).x; // b221:294
                if (height < texCur) { texHit = texCur; break; }
                heightPrev = height;
                height -= stepH;
                offPrev = offCur;
                offCur += stepUV;
                texPrev = texCur;
                iter += 1.0;
            }
            float tBlend = (texPrev - heightPrev)
                         / (-heightPrev + (height + (texPrev - texHit)));          // b221:323
            float2 hitUV = (uvP + mad(stepUV, tBlend.xx, offPrev)) * _ParallaxTilling; // b221:324
            float4 pMap = SAMPLE_TEXTURE2D(_ParallaxMap, sampler_ParallaxMap, hitUV);

            float3 colBD = float3(mad(pMap.y, _ParallaxColor.x - _ParallaxColorDark.x, _ParallaxColorDark.x),
                                  mad(pMap.y, _ParallaxColor.y - _ParallaxColorDark.y, _ParallaxColorDark.y),
                                  mad(pMap.y, _ParallaxColor.z - _ParallaxColorDark.z, _ParallaxColorDark.z)); // b221:336-338
            float fres = exp2(log2(max(clamp(dot(V, shadedNormalWS), 0.0, 1.0), 0.001000000047497451305389404296875))
                              * floor(_ParallaxFresnelStrength)) * (mask * mask);  // b221:326

            float3 dChar = IN.positionWS - _VFXParams0.xyz;                        // 角色距离亮环 b221:327-330
            float ringChar = clamp((sqrt(dot(dChar, dChar)) - _ParallaxBrightOuterRadius)
                                   * (1.0 / (-_ParallaxBrightOuterRadius + _ParallaxBrightInnerRadius)), 0.0, 1.0);
            float charTerm = ((ringChar * ringChar) * mad(ringChar, -2.0, 3.0)) * _ParallaxBrightStrength;
            charTerm = (_ParallaxCharPos != 0.0) ? charTerm : 0.0;                 // b221:334 位掩码门

            float2 dSign = float2(IN.positionWS.x - _VFXParams2.x, IN.positionWS.z - _VFXParams2.y); // 交互环 b221:331-333
            float ringSign = clamp((1.0 / (-_VFXParams2.z)) * (sqrt(dot(dSign, dSign)) - _VFXParams2.z), 0.0, 1.0);

            float omb = 1.0 - _ParallaxMinBrightness;                              // 呼吸 b221:334
            float objSum = (unity_ObjectToWorld._m13 + unity_ObjectToWorld._m03) + unity_ObjectToWorld._m23;
            float pulse = mad((ringSign * ringSign) * mad(ringSign, -2.0, 3.0), _VFXParams2.w,
                              mad(omb * (((1.0 + _ParallaxMinBrightness) / omb)
                                         + cos(mad(_Time.y * _ParallaxAnimSpeed, 0.0500000007450580596923828125,
                                                   objSum * _ParallaxAnimRandom))),
                                  0.5, charTerm));

            float3 parallaxRGB = min(max(pulse * (fres * colBD), 0.0.xxx), 1000.0.xxx); // b221:336-338

        #ifdef _PARALLAX_MAP_WORLDSPACE
            // 世界空间扩展(liteffect b227->b333 融合差分逐位; lit 同织物)
            {
                float2 dW = float2(IN.positionWS.x - _MaskWorldPosParams.x,
                                   IN.positionWS.z - _MaskWorldPosParams.z);       // b333:816-817
                float rotW = 0.01745329238474369049072265625 * _MaskWorldPosParams.y;
                float sW = sin(rotW), cW = cos(rotW);
                float scaleW = max(0.100000001490116119384765625, _MaskWorldPosParams.w);
                float2 polar = dW / scaleW;
                float4 scan = SAMPLE_TEXTURE2D_LOD(_ParallaxMaskMap, sampler_ParallaxMaskMap,
                                  float2(mad(pMap.x, _ParallaxMinBrightness, dot(polar, float2(cW, sW)) + 0.5),
                                         mad(pMap.y, _ParallaxMinBrightness, dot(polar, float2(-sW, cW)) + 0.5)),
                                  mad(abs(IN.normalWS.y), -3.0, 3.0));             // b333:851
                parallaxRGB *= scan.rgb * _ParallaxMaskMapColorStrength;           // b333:880-882

                uint signBits = uint(int(_ParallaxSignControl));                   // 5 段信号带 b333:886-986
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
                float wave = clamp(mad(pMap.x, 20.0, sqrt(dot(dW, dW))) - _ParallaxLerpSchedule, 0.0, 1.0); // b333:986
                float pulseW = clamp(mad(band, IN.color.x, wave), 0.0, 1.0);

                float3 patDark   = parallaxRGB * _ParallaxPatternColorDark.rgb;    // b333:994-1011
                float3 patBright = parallaxRGB * _ParallaxPatternColor.rgb;
                parallaxRGB = lerp(patDark, patBright, pulseW);

                float hGate = mad(clamp(_ParallaxSignLerpFactor1.w, 0.0, 1.0),     // 主项高度门 b333:1177(槽角色回填)
                                  -baseA + clamp(-IN.positionWS.y + _ParallaxSignLerpFactor1.w, 0.0, 1.0),
                                  baseA);
                float mAdd = mad(clamp(_WorldParallaxAdditionalLightMaskChannel, 0.0, 1.0), -baseA + nrmZ, baseA); // b333:1147-1155
                mAdd = mad(clamp(_WorldParallaxAdditionalLightMaskChannel - 1.0, 0.0, 1.0), -mAdd + nrmW, mAdd);
            #ifndef _TWO_BASEMAP
                mAdd = mad(clamp(_WorldParallaxAdditionalLightMaskChannel - 2.0, 0.0, 1.0), -mAdd + mroA, mAdd);
            #endif
                float yBand = clamp(IN.positionWS.y - _ParallaxSignLerpFactor1.y, 0.0, 1.0); // b333:1137
                float3 addTerm = mAdd * (yBand * ((parallaxRGB + 0.300000011920928955078125) * _WorldParallaxAdditionalColor.rgb));
                return mad(parallaxRGB, (hGate * _ParallaxIntensity).xxx, addTerm); // b333 SV 尾
            }
        #else
            return parallaxRGB * _ParallaxIntensity;                               // b221:346-348
        #endif
        }
        #endif // _PARALLAX_MAP

        // ====================================================================================
        // 基面装配(b283:153-195 GBuffer == b11:263-305 forward, 同一数学)。
        //   3 贴图: MRO 独立, 法线 DXT5nm(x in .a);
        //   _TWO_BASEMAP: metallic=base.a, rough=nrm.z, occ=nrm.a, 法线无 *.a + 0.012 死区。
        //   nz 用未缩放解码分量(b283:177 dot(_348,_350)), 缩放分量只进 TBN。
        // ====================================================================================
        HgSurface HgBuildSurface(Varyings IN, bool isFrontFace)
        {
            HgSurface s = (HgSurface)0;


            float2 uvBase, uvPbr;
            HgComputeBaseUVs(IN.uv, uvBase, uvPbr);

            // URP 的 SAMPLE_TEXTURE2D 自带全局 mip bias(TAAU), 对应 HG SampleBias(_GlobalMipBias);
            // 法线额外 +_TAAUNormalBiasReverse (b283:172)。
            float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uvBase);
            float4 nrm     = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap, uvPbr, _TAAUNormalBiasReverse);

        #ifdef _TWO_BASEMAP
            float metallicT  = baseTex.w;                                        // b11:282 (_371 源)
            float roughT     = nrm.z;                                            // b11:281 (_360 源)
            float occT       = nrm.w;                                            // b11:1240 (_3081 源)
            float nxRaw = mad(nrm.x, 2.0, -1.0);                                 // b11:268
            float nyRaw = mad(nrm.y, 2.0, -1.0);                                 // b11:269
            float nxDec = (abs(nxRaw) < HG_NORMAL_DEADZONE) ? 0.0 : nxRaw;       // b11:270 (_297)
            float nyDec = (abs(nyRaw) < HG_NORMAL_DEADZONE) ? 0.0 : nyRaw;       // b11:271 (_299)
        #else
            float4 mro = SAMPLE_TEXTURE2D(_MROMap, sampler_MROMap, uvPbr);       // b283:161 (共用 uvPbr)
            float metallicT  = mro.x;
            float roughT     = mro.y;
            float occT       = mro.z;
            float nxDec = mad(nrm.x * nrm.w, 2.0, -1.0);                         // b283:173 DXT5nm
            float nyDec = mad(nrm.y,         2.0, -1.0);                         // b283:174
        #endif
            float nx = nxDec * _NormalScale;                                     // b283:175-176
            float ny = nyDec * _NormalScale;

            // <<HOOK:SURFACE_PRENORMAL>>  (形变法线 在 TBN 前混入 nx/ny)

            // 固有色 tint-cover (b283:156-158,192-194)
            float3 albedoRaw = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale);
            float3 baseCol   = lerp(albedoRaw, _BaseColor.rgb, _BaseColorTintCover);

            float roughness = lerp(_RoughnessMin, _RoughnessMax, roughT);        // b283:165-167
            float metallic  = lerp(metallicT, _Metallic, saturate(_BaseTextureMapCount - 1.0)); // b283:163
            float occlusion = lerp(1.0, occT, _OcclusionStrength);               // b283:166

            // 双面法线 Z (b283:177; forward b11:283 少 1e-16 钳制, 仅退化法线时位差)
            float frontSign = isFrontFace ? 1.0 : ((_TwoSidedNormal > 0.0) ? -1.0 : 1.0);
            float nz = max(sqrt(1.0 - min(dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 1.0)), HG_EPS_NORMAL_Z) * frontSign;

            // ============================================================
            // _DETAIL_MAP(lit b619 逐位): 视深渐隐 + 五路蒙版链 + RNM 重定向法线混合 +
            //   粗糙度/AO 按 _DetailMode + 反照率叠色(mode0)。
            // ============================================================
        #ifdef _DETAIL_MAP
            float detailWeight;
            float4 detailTex;
            {
                // 视深渐隐 (b619:184-187): dist=|视空间Z|, w=saturate((End-dist)/(End-Start))
                float viewZ = abs(mad(UNITY_MATRIX_V[2].z, IN.positionWS.z, mad(UNITY_MATRIX_V[2].x, IN.positionWS.x, IN.positionWS.y * UNITY_MATRIX_V[2].y)) + UNITY_MATRIX_V[2].w);
                float falloff = clamp((-viewZ + _DetailFalloffEnd) / (-_DetailFalloffStart + _DetailFalloffEnd), 0.0, 1.0);

                float2 duvD = IN.uv.zw - IN.uv.xy;
                float2 uvDetail = mad(mad(_DetailUVSet.xx, duvD, IN.uv.xy), _DetailMap_ST.xy, _DetailMap_ST.zw); // b619:193
                detailTex = SAMPLE_TEXTURE2D(_DetailMap, sampler_DetailMap, uvDetail);

                // 蒙版链 (b619:198-201): 0=AllPass 1=DetailA 2=BaseA 3=NormalB 4=NormalA (5=MROA, 3-map)
                float mroAD = 0.0;
            #ifndef _TWO_BASEMAP
                mroAD = SAMPLE_TEXTURE2D(_MROMap, sampler_MROMap, uvPbr).w;
            #endif
                float m23 = mad(clamp(_DetailMaskMode - 2.0, 0.0, 1.0), nrm.z - baseTex.w, baseTex.w);          // b619:198 (_395)
                float m01 = mad(clamp(_DetailMaskMode, 0.0, 1.0), detailTex.w - 1.0, 1.0);                       // b619:200 (_404)
                float m234 = mad(clamp(_DetailMaskMode - 3.0, 0.0, 1.0), nrm.w - m23, m23);                      // b619:201 内层
            #ifndef _TWO_BASEMAP
                m234 = mad(clamp(_DetailMaskMode - 4.0, 0.0, 1.0), mroAD - m234, m234);
            #endif
                detailWeight = falloff * mad(clamp(_DetailMaskMode - 1.0, 0.0, 1.0), m234 - m01, m01);           // b619:201 (_412)

                // RNM 重定向法线混合 (b619:223-235): t=(base.xy*scale, nzBase+1), u=(-detail.xy*wN, nzDetail)
                float wN = detailWeight * _DetailNormalIntensity;                                                // b619:202 (_417)
                float dnx = mad(detailTex.x, 2.0, -1.0); dnx = (abs(dnx) < HG_NORMAL_DEADZONE) ? 0.0 : dnx;      // b619:213,221
                float dny = mad(detailTex.y, 2.0, -1.0); dny = (abs(dny) < HG_NORMAL_DEADZONE) ? 0.0 : dny;
                float dX = wN * dnx;                                                                             // b619:223 (_533)
                float dY = wN * dny;                                                                             // b619:224 (_534)
                float dZ = sqrt(max(1.0 - dot(float2(dnx, dny), float2(dnx, dny)), 0.0));                        // b619:225 (_541)
                float bZ1 = sqrt(max(1.0 - dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 0.0)) + 1.0;         // b619:230 (_569)
                float rnmDot = dot(float3(nx, ny, bZ1), float3(-dX, -dY, dZ));                                   // b619:231 (_570)
                nx = dX + (rnmDot * nx) / bZ1;                                                                   // b619:232 (_581)
                ny = dY + (rnmDot * ny) / bZ1;                                                                   // b619:233 (_582)
                nz = (rnmDot - dZ) * frontSign;                                                                  // b619:235 (_649)

                // 粗糙度/AO (b619:205,215): rough=lerp(base, lerp(detail.a, detail.b, mode), w*PBRIntensity)
                float wPbr = detailWeight * _DetailPBRIntensity;                                                 // b619:203 (_418)
                float detailRough = mad(_DetailMode, detailTex.z - detailTex.w, detailTex.w);                    // b619:205 内层
                roughness = mad(wPbr, detailRough - roughness, roughness);                                       // b619:205 (_439)
                occlusion = mad(wPbr, (detailTex.w - 1.0) * _DetailMode, 1.0) * occlusion;                       // b619:215

                // 反照率叠色 mode0 (b619:249-258): albedo=lerp(albedo, lerp(sat(albedo*Overlay*Brighter), Overlay, Overlay.w), (1-detail.b)(1-mode)w)
                float wTint = ((1.0 - detailTex.z) * (1.0 - _DetailMode)) * detailWeight;                        // b619:249 (_707)
                float3 tintBase = clamp((baseCol * _DetailOverlayColor.rgb) * _DetailBaseColorBrighterScale, 0.0, 1.0); // b619:253-255
                baseCol = lerp(baseCol, lerp(tintBase, _DetailOverlayColor.rgb, _DetailOverlayColor.w), wTint);  // b619:256-258
            }
        #endif

            // ============================================================
            // _LAYERBLEND(lit b357 逐位, 顶点色模式基础): 第二材质层混合。
            //   uvLB = (uv0|worldXZ|uv2)[_LayerBlendUVType] × _Layer1Tilling;
            //   权重: wL=saturate(1−顶点色R); 高度混合(_LayerBlendHeight):
            //     maxH=max(hL·wL, hB·wB); termL=max(−maxH+wL·hL+Trans,0)+1e-7; termB 同式 hB;
            //     blend = wL·termL/max(wL·termL+wB·termB, FLT_MIN) (b357:206-211);
            //   hL=_Layer1BaseMap.A, hB=_BaseHeightMap.x(同 uvLB) (b357:200-204);
            //   albedo: lerp(luma, 层色, saturate(1+_Layer1Saturation))×Tint×Brighter → lerp(基,层,blend) (b357:265-273);
            //   rough=lerp(基, NRO.z, blend); metallic=lerp(基, [类型?基A:_Layer1Metallic], blend);
            //   occ=lerp(基, NRO.w 按 _Layer1AOStrength/关闭, blend); porosity×(层未覆盖门) (b357:220-232);
            //   法线: RNM(基,层×_Layer1BumpScale) 以 _Layer1BaseNormalIntensity 内插(0=纯层), 再 blend (b357:236-254)。
            //   MASK/TOP/MOSS/NOISEBLEND 变体=对 wL 源与叠加项的增量(后续模块)。
            // ============================================================
        #if defined(_LAYERBLEND) || defined(_LAYERBLEND_MASK) || defined(_LAYERBLEND_TOP)
            {
                // uv 选择(one-hot LUT, b357:198-199)
                float2 uvLB;
                if (_LayerBlendUVType == 1.0)      uvLB = IN.positionWS.xz;
                else if (_LayerBlendUVType == 2.0) uvLB = IN.uv2;
                else                               uvLB = IN.uv.xy;
                uvLB *= _Layer1Tilling;

                float4 layerBase = SAMPLE_TEXTURE2D(_Layer1BaseMap, sampler_Layer1BaseMap, uvLB);   // b357:202 (_302)
                float4 layerNRO  = SAMPLE_TEXTURE2D(_Layer1BumpMap, sampler_Layer1BumpMap, uvLB);   // b357:205 (_312)
                float  hBase     = SAMPLE_TEXTURE2D(_BaseHeightMap, sampler_BaseHeightMap, uvLB).x; // b357:200-201 (_297)
                float  hLayer    = layerBase.w;                                                     // b357:204 (_307)

                // 权重源(基础=顶点色模式): wL = saturate(1−vColor.r) (b357:206)
                float wL = clamp(1.0 - IN.color.x, 0.0, 1.0);
            #if defined(_LAYERBLEND_MASK)
                // b365:221 (_450): _LayerBlendMaskType NROA→nrm.a; 否则遮罩图R(UV 按 _LayerBlendMaskUVType: 枚举 UV1=0/UV0=1)
                float2 uvMaskLB = (_LayerBlendMaskUVType == 1.0) ? IN.uv.xy : IN.uv.zw;
                wL = clamp((_LayerBlendMaskType != 0.0) ? nrm.w
                          : SAMPLE_TEXTURE2D(_LayerBlendMaskMap, sampler_LayerBlendMaskMap, uvMaskLB).x, 0.0, 1.0);
            #elif defined(_LAYERBLEND_TOP)
                // b383:231-233 (_552): 世界上向窗 saturate((lerp(几何N.y, 凹凸N.y, _TopBlendWithBumpMap) − 阈值)/max(FLT_MIN, 平滑))
                {
                    float tSignLB = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
                    float3 bitanLB = tSignLB * cross(IN.normalWS, IN.tangentWS.xyz);
                    float3 nBump = IN.normalWS * abs(nz) + IN.tangentWS.xyz * nx + bitanLB * ny;    // b383:231 (_525, 未翻面)
                    float upY = mad(_TopBlendWithBumpMap, nBump.y * rsqrt(dot(nBump, nBump)) - IN.normalWS.y, IN.normalWS.y);
                    wL = clamp((upY - _TopBlendThreshold) / max(1.1754943508222875079687365372222e-38, _TopBlendSmoothness), 0.0, 1.0);
                }
            #endif
                float wB = 1.0 - wL;                                                                 // b357:207-208 (_324)
                float maxH = max(hLayer * wL, hBase * wB);                                           // b357:209 (−_334)
                float termL = wL * (max(-maxH + mad(wL, hLayer, _LayerBlendHeightTransition), 0.0) + 9.9999999747524270787835121154785e-07); // b357:210 (_343)
                float termB = wB * (max(-maxH + mad(wB, hBase, _LayerBlendHeightTransition), 0.0) + 9.9999999747524270787835121154785e-07);
                float blend = (_LayerBlendHeight != 0.0)
                            ? termL / max(termL + termB, 1.1754943508222875079687365372222e-38)
                            : wL;                                                                    // b357:211 (_358)

                // albedo(b357:265-273): 饱和度=lerp(luma, 层色, saturate(1+_Layer1Saturation)) ×Tint×Brighter
                float lumaL = dot(layerBase.rgb, HG_LUMA);
                float satW = clamp(1.0 + _Layer1Saturation, 0.0, 1.0);
                float3 layerCol = float3(mad(satW, -lumaL + layerBase.x, lumaL),
                                         mad(satW, -lumaL + layerBase.y, lumaL),
                                         mad(satW, -lumaL + layerBase.z, lumaL))
                                * _Layer1TintColor.rgb * _Layer1ColorBrighterScale;
                baseCol = lerp(baseCol, layerCol, blend);

                // PBR 链(b357:220-232)
                float layerMetal = (_LayerMetallicType != 0.0) ? layerBase.w : _Layer1Metallic;      // b357:220 (基A 源=层图A)
                metallic  = lerp(metallic, layerMetal, blend);
                roughness = lerp(roughness, layerNRO.z, blend);                                      // b357:224 (_500)
                float layerOcc = lerp(1.0, layerNRO.w, _Layer1AOStrength);                          // b357:232 (AO 源门=litforward 专属属性, lit 材质恒走 NROA)
                occlusion = lerp(occlusion, layerOcc, blend);

                // 法线 RNM(b357:236-254): 层法线(0.012 死区)×_Layer1BumpScale; I=_Layer1BaseNormalIntensity
                float lnxRaw = mad(layerNRO.x, 2.0, -1.0);
                float lnyRaw = mad(layerNRO.y, 2.0, -1.0);
                float lnxDec = (abs(lnxRaw) < HG_NORMAL_DEADZONE) ? 0.0 : lnxRaw;                    // b357:239 (_591)
                float lnyDec = (abs(lnyRaw) < HG_NORMAL_DEADZONE) ? 0.0 : lnyRaw;
                float lnx = lnxDec * _Layer1BumpScale;                                               // b357:236 (_572)
                float lny = lnyDec * _Layer1BumpScale;
                float lnz = max(sqrt(1.0 - min(dot(float2(lnxDec, lnyDec), float2(lnxDec, lnyDec)), 1.0)), HG_EPS_NORMAL_Z); // (_578)
                float bnz1 = sqrt(max(1.0 - dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 0.0)) + 1.0;   // b357:243,246 (_605+1)
                float rnmL = dot(float3(nx, ny, bnz1), float3(-lnx, -lny, lnz));                     // b357:247 (_609)
                float xI = mad(_Layer1BaseNormalIntensity, -lnx + (lnx + (rnmL * nx) / bnz1), lnx);  // b357:248 (_641 内层)
                float yI = mad(_Layer1BaseNormalIntensity, -lny + (lny + (rnmL * ny) / bnz1), lny);  // b357:249
                float zI = mad(_Layer1BaseNormalIntensity, -lnz + (rnmL - lnz), lnz);                // b357:251 内层(I=1→RNM, 0→纯层)
                float bnzS = sqrt(max(1.0 - dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 0.0));  // (_605)
                nx = mad(blend, -nx + xI, nx);                                                       // b357:248 (_641)
                ny = mad(blend, -ny + yI, ny);                                                       // b357:249 (_642)
                nz = frontSign * mad(blend, -bnzS + zI, bnzS);                                       // b357:251 (_708)
            }
        #endif

            // TBN → 世界法线 (b283:178-185): B = sign*cross(N_geo, T)
            float tangentSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
            float3 bitangent  = tangentSign * cross(IN.normalWS, IN.tangentWS.xyz);
            float3 normalWS   = normalize(IN.normalWS * nz + IN.tangentWS.xyz * nx + bitangent * ny);

            // 不透明家族: alpha 仅供 clip 路径(lit 骨架无 _SurfaceType/顶点色透明属性)
            s.alpha = 1.0;

            s.albedo    = baseCol;
            s.normalWS  = normalWS;
            s.metallic  = metallic;
            s.roughness = roughness;
            s.occlusion = occlusion;
            s.emission  = float3(0.0, 0.0, 0.0);

            // <<HOOK:SURFACE_POST>>  (Terrain/视差族/伪体积/切换三通道...)



            // ============================================================
            // _TRI_CHANNEL_MASK(lit b291 逐位, 3-map 变体): 三通道遮罩改写 albedo/rough/metallic。
            //   w_c = saturate((mask.c + Offset_c)*(Scale_c+1) - Scale_c*0.5) * MaskColor_c.w
            //   应用顺序 B→G→R(b291:227-243), occlusion/法线不动。
            //   Legacy 单值粗糙度路径; SWITCH_TEXTURE(GWithNormal/G贴图)见 b707 变体模块。
            // ============================================================
        #ifdef _TRI_CHANNEL_MASK
            {
                float2 duvM = IN.uv.zw - IN.uv.xy;
                float2 uvMask = mad(mad(_MaskUVSet.xx, duvM, IN.uv.xy), _MaskMap_ST.xy, _MaskMap_ST.zw);  // b291:219
                float4 maskTex = SAMPLE_TEXTURE2D(_MaskMap, sampler_MaskMap, uvMask);
                float wB = clamp(mad(maskTex.z + _MaskBOffset, _MaskBScale + 1.0, _MaskBScale * (-0.5)), 0.0, 1.0) * _MaskAlbedoB.w; // b291:223 (_359)
                float wG = clamp(mad(maskTex.y + _MaskGOffset, _MaskGScale + 1.0, _MaskGScale * (-0.5)), 0.0, 1.0) * _MaskAlbedoG.w; // b291:231 (_411)
                float wR = clamp(mad(maskTex.x + _MaskROffset, _MaskRScale + 1.0, _MaskRScale * (-0.5)), 0.0, 1.0) * _MaskAlbedoR.w; // b291:232 (_416)
                s.albedo = lerp(s.albedo, _MaskAlbedoB.rgb, wB);                 // b291:227-229 (_387..)
                s.albedo = lerp(s.albedo, _MaskAlbedoG.rgb, wG);                 // b291:233-235 (_417..)
                s.albedo = lerp(s.albedo, _MaskAlbedoR.rgb, wR);                 // b291:269-271 (RT4)
                s.roughness = lerp(s.roughness, _MaskRoghnessB, wB);             // b291:230 (_390)
                s.roughness = lerp(s.roughness, _MaskRoghnessG, wG);             // b291:236 (_420)
                s.roughness = lerp(s.roughness, _MaskRoghnessR, wR);             // b291:237 (_440)
                s.metallic  = lerp(s.metallic, _MaskMetallicB, wB);              // b291:240 (_465)
                s.metallic  = lerp(s.metallic, _MaskMetallicG, wG);              // b291:241 (_471)
                s.metallic  = lerp(s.metallic, _MaskMetallicR, wR);              // b291:242 (_477)
            }
        #endif

            // ============================================================
            // 自发光家族(lit b301/b315/b323/b333/b339 + liteffect b213/b209 逐位)。
            // SceneEffect per-draw 调色(Float4x5_Param0/2/4)/自动曝光除数=引擎面, 中性弃(文件头表)。
            // 时间槽(PerDraw[6/11] 保留槽/_VFXParams0.w)= 游戏秒 → _Time.y。
            // 闪烁三属性(_EnableEmissiveAnimFlicker 等)在 1.3.3 全部出货 blob 中无读取(死 uniform), 不移植。
            // ============================================================
        #if defined(_EMISSIVE_MAP) || defined(_EMISSIVE_MASK) || defined(_EMISSIVE_NOMAP)
            {
                float3 albedoAffect = lerp(s.albedo, float3(1.0, 1.0, 1.0), _AlbedoAffectEmissive); // b301 route 尾因子(SceneEffect 中性形)

                // ---- 呼吸(_EMISSIVE_ANIM, b213:188-191): 三角波→伪 cos 多项式, breath∈[minB-1, 0] ----
                float animX = 0.0;                              // 每通道因子 = mad(颜色.w, animX, 1)
            #ifdef _EMISSIVE_ANIM
                float tri  = mad(clamp(frac(mad(_Time.y * _EmissiveAnimSpeed, 0.15915493667125701904296875, _EmissiveAnimRandom)) * _EmissiveAnimInterval, 0.0, 1.0), 2.0, -1.0); // b213:188
                float tri2 = tri * tri;                                                                   // b213:189
                float omb  = 1.0 - _EmissiveMinBrightness;                                                // b213:190
                animX = mad((((1.0 + _EmissiveMinBrightness) / omb) + (mad(tri2, -6.0, abs(tri * tri2) * 4.0) + 1.0)) * omb, 0.5, -1.0); // b213:191
            #endif
                // ---- 扫光(_EMISSIVE_ANIM_SWEEP, b333:204-239 / NOMAP b339:168-194) ----
            #if defined(_EMISSIVE_ANIM_SWEEP) || defined(_EMISSIVE_NOMAP)
                float3 objOrigin  = float3(UNITY_MATRIX_M._m03, UNITY_MATRIX_M._m13, UNITY_MATRIX_M._m23);
                float3 objUpRow   = float3(UNITY_MATRIX_M._m10, UNITY_MATRIX_M._m11, UNITY_MATRIX_M._m12); // O2W 行1 = 对象局部 Y 投影
                float  upProj     = dot(objUpRow, IN.positionWS - objOrigin);                              // b333:208 世界差投到对象上轴
                float  phaseT     = mad(_EmissiveSweepRandom, objOrigin.x, _Time.y) / _EmissiveSweepInterval; // b333:205 (_196)
                float  phaseF     = frac(abs(phaseT));                                                     // b333:206
                float  signedF    = (phaseT >= -phaseT) ? phaseF : -phaseF;
                float  sweepCoord = upProj - _EmissiveSweepSpeed * mad(signedF, _EmissiveSweepInterval, -(0.300000011920928955078125 * _EmissiveSweepInterval)); // b333:208
                float  band       = clamp(mad(-clamp(abs(sweepCoord) / _EmissiveSweepWidth, 0.0, 1.0), _EmissiveSweepFalloff, _EmissiveSweepFalloff), 0.0, 1.0);
                float  albedoTerm = max(mad(_EmissiveSweepAlbedoScale, dot(s.albedo, 0.333000004291534423828125.xxx) + (-0.20000000298023223876953125), 0.20000000298023223876953125) * 5.0, 0.0); // b333:209
                float  sweepBoost = albedoTerm * (band * band);   // ×Param3.z 引擎 per-draw 门(无宿主=1)
                animX = sweepBoost - 1.0;                          // b333:209 (_265): 每通道因子 mad(w, boost-1, 1)
            #endif
                float fR = mad(_EmissiveColor.w,  animX, 1.0);     // b213:192 / b333:216
                float fG = mad(_EmissiveColorG.w, animX, 1.0);     // b213:193 / b333:210(_271)
                float fB = mad(_EmissiveColorB.w, animX, 1.0);     // b213:201 / b333:219(_410)
                float fA = mad(_EmissiveColorA.w, animX, 1.0);     // b213:202 / b333:220(_415)

            #ifdef _EMISSIVE_MAP
                float2 duvEm = IN.uv.zw - IN.uv.xy;
                float2 uvEm  = mad(_EmissiveSpeed.xy, _Time.y,
                                   mad(mad(_EmissiveUVSet.xx, duvEm, IN.uv.xy), _EmissiveMap_ST.xy, _EmissiveMap_ST.zw)); // b301:190
            #if defined(_EMISSIVE_ANIM) || defined(_EMISSIVE_ANIM_SWEEP)
                uvEm *= _EmissiveMapTilling;                       // b213:196 / b333:211 (Tilling 仅动画路径乘)
            #endif
                float4 em = SAMPLE_TEXTURE2D(_EmissiveMap, sampler_EmissiveMap, uvEm);
                // 路由: R 通道恒 _EmissiveColor, GBA ×_EmissiveType (b301:214 / b213:226)
                float3 route = _EmissiveColor.rgb * (em.x * fR)
                             + (_EmissiveColorG.rgb * (em.y * fG)
                                + _EmissiveColorB.rgb * (em.z * fB)
                                + _EmissiveColorA.rgb * (em.w * fA)) * _EmissiveType;
            #if defined(_EMISSIVE_ANIM) || defined(_EMISSIVE_ANIM_SWEEP)
                route = min(max(route, 0.0.xxx), 1000.0.xxx);      // b213:226 / b333:237 clamp 仅动画路径
            #endif
                s.emission += route * albedoAffect;                // lit 家族无 _EmissiveRemap 尾乘(le/leb/lt 专有)
            #elif defined(_EMISSIVE_MASK)
                // 自发光骑现有贴图通道 (b315:165-167 / b209:162-164): 1=BaseA 2=NormalB 3=NormalA 4=MROA
                float mroA = 0.0;
            #ifndef _TWO_BASEMAP
                mroA = SAMPLE_TEXTURE2D(_MROMap, sampler_MROMap, uvPbr).w;   // 3-map 家族 ch4 载体(枚举 MRO A)
            #endif
                float sel = mad(clamp(_EmissiveMaskChannel - 1.0, 0.0, 1.0), -baseTex.w + nrm.z, baseTex.w); // b315:165
                sel = mad(clamp(_EmissiveMaskChannel - 2.0, 0.0, 1.0), nrm.w - sel, sel);                    // b315:167 内层
            #ifndef _TWO_BASEMAP
                sel = mad(clamp(_EmissiveMaskChannel - 3.0, 0.0, 1.0), mroA - sel, sel);
            #endif
                float chGate  = clamp(_EmissiveMaskChannel, 0.0, 1.0);                                       // b315:166 (_171)
                float maskVal = clamp(mad(mad(chGate, sel - 1.0, 1.0), 1.111111164093017578125, -0.055555559694766998291015625), 0.0, 1.0); // b315:167
                s.emission += (_EmissiveColor.rgb * ((maskVal * fR) * _EnableEmissiveMap * chGate)) * albedoAffect; // b315:167 (lit 无 remap 尾乘)
            #elif defined(_EMISSIVE_NOMAP)
                // 纯扫光无贴图 (b339:192-194): emission = 颜色 × band²·albedoTerm
                s.emission += (_EmissiveColor.rgb * (sweepBoost)) * albedoAffect;   // b339:192-194
            #endif
            }
        #endif

            // ============================================================
            // _PARALLAX_MAP -> 自发光加项(lit b717 写 RT0; URP=emission 载体同义)。
            // 3-map 变体 MRO A 供通道链; _PARALLAX_MAP_PBR(b809 POM 改写基面)未落, 见钩注。
            // ============================================================
        #ifdef _PARALLAX_MAP
            {
                float mroAP = 0.0;
            #ifndef _TWO_BASEMAP
                mroAP = SAMPLE_TEXTURE2D(_MROMap, sampler_MROMap, uvPbr).w;
            #endif
                s.emission += HgParallaxEmissive(IN, s.normalWS, baseTex.w, nrm.z, nrm.w, mroAP);
            }
        #endif

            // ============================================================
            // _TERRAIN_BLEND(+_FROM_HEIGHT/_NOISE) —— 宿主缺口模块(显式, 非静默简化)。
            // 真源(lit b437 系): 采样 HG 地形虚拟纹理系统 = IndirectionMap 页表 + 地形图集 +
            // 地形深度 RT, 按世界高度差/湿度因子把地表色/法线/粗糙度混进基面
            // (_TerrainBlendFactor/FallOff/NormalFactor/Wet* 曲线)。三张输入全部是 HG 引擎
            // 每帧全局(页表/图集/深度 RT), URP 无对应宿主 -> 无输入可采, 模块保持基面直通。
            // keyword/uniform 全保留: 宿主侧未来提供 _TerrainIndirectionMap/_TerrainAtlas/
            // _TerrainDepthRT 全局后在此按 b437 逐位补链, 材质无需改动。
            // ============================================================
        #if defined(_TERRAIN_BLEND) || defined(_TERRAIN_BLEND_FROM_HEIGHT) || defined(_TERRAIN_BLEND_NOISE)
            // (宿主缺口: 地形虚拟纹理三全局缺席, 直通)
        #endif

            // ============================================================
            // 次表面散射(littransparent b52 前向真值, 干净名; lit b395/b397/b403 GBuffer 侧交叉证):
            //   厚度反 = lerp(1-Min, 1-Max, approxTerm);
            //   approxTerm: General=1 / Fresnel=max((dot(V,N_geo)+F)/(1+F),0) (b52:509 _SubsurfaceThicknessApproxMode 门)
            //   THICKNESSMAP: 沿切空间视向视差偏移采样厚度图+通道链 (b403:196-210)
            //   量 = 厚度反 × saturate(遮罩R) × _SubsurfaceValue (LayerBlend 门中性形 b52:510-512)
            //   色调 = HSV 三角(frac(K+_SubsurfaceHue)*6-3 折线, K=1,2/3,1/3) × 量 (b52:809-811)
            //   (编辑器把 _SubsurfaceColor 烤进 _SubsurfaceHue/Saturation/Value 隐藏属性 — rip 材质自带)
            // ============================================================
        #if defined(_SUBSURFACE) || defined(_SUBSURFACE_DEFAULTLIT)
            {
                float3 sssView = HgViewDirWS(IN.positionWS).xyz;
                float2 uvSss = lerp(IN.uv.zw, IN.uv.xy, _SubsurfaceMapMaskUVType);   // 枚举 UV1=0, UV0=1
                float maskR = SAMPLE_TEXTURE2D(_SubsurfaceMap, sampler_SubsurfaceMap, uvSss).x;
            #ifdef _SUBSURFACE_THICKNESSMAP
                // 厚度图: 切空间视向 / (z+0.42) × 距离 的视差偏移采样 + 通道链 (b403:192-210)
                float tS = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
                float3 bitanS = tS * cross(IN.normalWS, IN.tangentWS.xyz);
                float tv = dot(IN.tangentWS.xyz, sssView);
                float bv = dot(bitanS, sssView);
                float nv = dot(IN.normalWS, sssView);
                float rlen = rsqrt(dot(float3(tv, bv, nv), float3(tv, bv, nv)));
                float biasP = mad(nv, rlen, 0.4199999868869781494140625);            // b403:196 (_351)
                float2 uvThick = float2(mad(-((rlen * tv) / biasP), _SubsurfaceParallaxMappingDistance, uvSss.x),
                                        mad(-((rlen * bv) / biasP), _SubsurfaceParallaxMappingDistance, uvSss.y)); // b403:199
                float thickSample = clamp(SAMPLE_TEXTURE2D_BIAS(_SubsurfaceMap, sampler_SubsurfaceMap, uvThick, _SubsurfaceParallaxMappingLod).x, 0.0, 1.0); // b403:199 (_398)
                // 通道链 (b403:205,210): 0=SubsurfaceMapA(视差样) 1=BaseA 2=NormalB 3=NormalA (4=MROA)
                float selT = mad(clamp(_SubsurfaceThicknessMapChannel - 1.0, 0.0, 1.0), nrm.z - baseTex.w, baseTex.w);
                selT = mad(clamp(_SubsurfaceThicknessMapChannel - 2.0, 0.0, 1.0), nrm.w - selT, selT);
                float approxTerm = mad(clamp(_SubsurfaceThicknessMapChannel, 0.0, 1.0), selT - thickSample, thickSample); // b403:210 (_515 内层)
            #else
                float approxTerm = mad(_SubsurfaceThicknessApproxMode,
                                       max((dot(sssView, IN.normalWS) + _SubsurfaceParallaxFresnel) / (1.0 + _SubsurfaceParallaxFresnel), 0.0) - 1.0,
                                       1.0);                                          // b52:509 (_820 内层)
            #endif
                float thickInv = mad(approxTerm, -(1.0 - _MinSubsurfaceThickness) + (1.0 - _MaxSubsurfaceThickness), 1.0 - _MinSubsurfaceThickness); // b52:509 (_820)
                float amount = mad(_SubsurfaceApplyLayerBlend, mad(thickInv, 1.0 - _SubsurfaceApplyLayerBlendInverse, -thickInv), thickInv) * _SubsurfaceValue; // b52:510 (_836, LayerBlend 中性形)
                amount *= clamp(maskR, 0.0, 1.0);                                     // b52:511-512 (_837/_838)
                float3 hueTri = float3(
                    mad(_SubsurfaceSaturation, clamp(abs(mad(frac(1.0 + _SubsurfaceHue), 6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0),
                    mad(_SubsurfaceSaturation, clamp(abs(mad(frac(0.666666686534881591796875 + _SubsurfaceHue), 6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0),
                    mad(_SubsurfaceSaturation, clamp(abs(mad(frac(0.3333333432674407958984375 + _SubsurfaceHue), 6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0)); // b52:809-811
                s.sssAmount = amount;
                s.sssTint = amount * hueTri;
            }
        #endif

            // ============================================================
            // _MATCAP(lit b501 逐位): 视空间法线 xy→[0,1] 采样 matcap, 加进自发光。
            //   引擎把 View 矩阵停在 PerDraw 保留槽0(b501:172); URP=UNITY_MATRIX_V。
            //   自动曝光除数(_MatCapIgnorePostExposure 门)URP 中性=1。
            // ============================================================
        #ifdef _MATCAP
            {
                float3 viewN = mul((float3x3)UNITY_MATRIX_V, s.normalWS);
                float2 uvMatcap = float2((viewN.x + 1.0) * 0.5, (viewN.y + 1.0) * 0.5);         // b501:172
                s.emission += SAMPLE_TEXTURE2D(_MatcapMap, sampler_MatcapMap, uvMatcap).rgb * _MatcapMapStrength; // b501:174-176
            }
        #endif

            // ============================================================
            // _INTERIORMAPPING(lit b347 逐位): 房间盒内映射(窗户假室内)。
            //   视线经 IoR 折弯(手写 refract, TIR 掩零 b347:213-218) → 切空间 → 单位房间盒 slab 相交
            //   → cube 采样(90° 步进旋转, LOD=5×_InteriorTextureRoughness) → HSV 重调(Hue/Sat/Bright)
            //   → 写自发光; 窗帘层(_InteriorCurtainTex)盖 albedo, emission×(1−窗帘α)。
            //   albedo 曲线乘数 _917=1−槽.z: 角色候选=_InteriorDepthColor.w(已按此绑定, b347:309 注)。
            //   cell ST(_CommonVATMapParams)=Tilling 双份+0 偏移中性绑定(b349 交叉待证, 注)。
            // ============================================================
        #ifdef _INTERIORMAPPING
            {
                float3 Vi = HgViewDirWS(IN.positionWS).xyz;
                float3 Ni = s.normalWS;
                float cosI = dot(float3(-Vi.x, -Vi.y, -Vi.z), Ni);                                       // b347:212 (_364)
                float kI = mad(-(_InteriorMappingIoR * _InteriorMappingIoR), mad(-cosI, cosI, 1.0), 1.0); // b347:213 (_378)
                float3 refrI = (kI >= 0.0)
                             ? float3(mad(_InteriorMappingIoR, -Vi.x, -(Ni.x * (mad(_InteriorMappingIoR, cosI, sqrt(kI))))),
                                      mad(_InteriorMappingIoR, -Vi.y, -(Ni.y * (mad(_InteriorMappingIoR, cosI, sqrt(kI))))),
                                      mad(_InteriorMappingIoR, -Vi.z, -(Ni.z * (mad(_InteriorMappingIoR, cosI, sqrt(kI))))))
                             : float3(0.0, 0.0, 0.0);                                                   // b347:215-218 (_405-409)
                float tSi = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
                float3 Bi = tSi * cross(IN.normalWS, IN.tangentWS.xyz);                                 // b347:202-204 (_330-332 含符号)
                float rB = dot(Bi, -refrI);                                                             // b347:219 (_413)
                float rT = dot(IN.tangentWS.xyz, -refrI);                                               // b347:220 (_425)
                float rN = dot(IN.normalWS, -refrI);                                                    // b347:221 (_437)
                float rcpL = rsqrt(dot(float3(rT, rB, rN), float3(rT, rB, rN)));                        // b347:222 (_443)
                float biasI = mad(rN, rcpL, 0.4199999868869781494140625);                               // b347:225 (_447)
                float denI = max(rcpL * rN, 0.001000000047497451305389404296875);
                float rayU = ((rcpL * rT) / biasI) / denI;                                              // b347:223-224 (_444/_445, LebParallax 同构)
                float rayV = ((rcpL * rB) / biasI) / denI;
                // cell ST 中性绑定: P.xy=Tilling, P.zw=0 (b349 交叉待证, NOTES)
                float2 cellST = _InteriorMappingTillingScale.xx;
                float2 uvSelI = lerp(IN.uv.xy, IN.uv.zw, _InteriorUVSet) * _InteriorMappingTillingScale; // b347:228-229 (_475/476)
                float rdX = (-rayU) * cellST.x;                                                          // b347:226 (_459)
                float rdY = (-rayV) * cellST.y;                                                          // b347:227 (_460)
                float rdZ = ((-(rcpL * rN)) * cellST.x) * ((1.0 / (1.0 - _InteriorRoomDepth)) - 1.0);    // b347:230 (_484, RoomDepth 深度重映射)
                float3 cell = float3(mad(frac(mad(uvSelI.x, 1.0, 0.0)), 2.0, -1.0),
                                     mad(frac(mad(uvSelI.y, 1.0, 0.0)), 2.0, -1.0),
                                     1.0);                                                               // b347:234-236 (_508-510, z=1)
                float3 invR = clamp(1.0 / float3(rdX, rdY, rdZ), -16777216.0, 16777216.0);               // b347:231-233 (_492-495)
                float tHit = min(mad(-invR.z, cell.z, abs(invR.z)),
                                 min(mad(-invR.y, cell.y, abs(invR.y)), mad(-invR.x, cell.x, abs(invR.x)))); // b347:237 (_521)
                float3 hit = float3(mad(rdX, tHit, cell.x), mad(rdY, tHit, cell.y), mad(rdZ, tHit, cell.z)); // b347:238-240
                // 90° 步进旋转 (b347:241-247)
                float q = floor(_InteriorRotation);
                float qh = q * 0.5;
                float fq = frac(abs(qh));
                float sq2 = ((qh >= -qh) ? fq : -fq) * 2.0;
                float g38 = clamp(q - 1.0, 0.0, 1.0);
                float3 dirCube = float3(mad(g38, 2.0, -1.0) * mad(sq2, hit.x - hit.z, -hit.x),
                                        -1.0 * (-hit.y),
                                        mad(g38, -2.0, 1.0) * mad(sq2, hit.z - hit.x, -hit.z));
                float4 room = SAMPLE_TEXTURECUBE_LOD(_InteriorCubeMap, sampler_InteriorCubeMap, dirCube, 5.0 * _InteriorTextureRoughness); // b347:247 (_566)
                // HSV 重调 (b347:251-262)
                float selGB = (room.y >= room.z) ? 1.0 : 0.0;
                float cMax1 = mad(selGB, room.y - room.z, room.z);
                float cMin1 = mad(selGB, room.z - room.y, room.y);
                float hueBase = (selGB != 0.0) ? -1.0 : 0.666666686534881591796875;                      // b347:254 (_587, 位型 1059760811=2/3)
                float selR = (room.x >= cMax1) ? 1.0 : 0.0;
                float cMax = mad(selR, -cMax1 + room.x, cMax1);
                float cMid = cMin1;
                float cMin3 = mad(selR, -room.x + cMax1, room.x);
                float delta = cMax - min(cMid, cMin3);                                                   // b347:259 (_606)
                float hue = abs(((-cMid + cMin3) / mad(delta, 6.0, 9.9999997473787516355514526367188e-05))
                              + ((selR != 0.0) ? ((selGB != 0.0) ? 1.0 : -1.0) : hueBase)) + _HueShift;  // b347:260 (_619)
                float valI = cMax * _Brightness;                                                         // b347:261 (_648)
                float satI = (delta / (cMax + 9.9999997473787516355514526367188e-05)) * _Saturation;     // b347:262 (_653)
                float3 interiorRGB = float3(
                    valI * mad(satI, clamp(abs(mad(frac(hue + 1.0), 6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0),
                    valI * mad(satI, clamp(abs(mad(frac(hue + 0.666666686534881591796875), 6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0),
                    valI * mad(satI, clamp(abs(mad(frac(hue + 0.3333333432674407958984375), 6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0)); // b347:272-274
                // 窗帘 (b347:263-271,310-313)
                float2 uvCurt = float2(frac(uvSelI.x * _CurtainTillingScale), frac(uvSelI.y) - _InteriorCurtainHeight);
                float4 curt = SAMPLE_TEXTURE2D(_InteriorCurtainTex, sampler_InteriorCurtainTex, uvCurt);
                float inRange = ((uvCurt.y >= 0.0) ? 1.0 : 0.0) * ((1.0 >= uvCurt.y) ? 1.0 : 0.0);       // b347:269 (_689)
                float curtGateInv = mad(-curt.w, inRange, 1.0);                                          // b347:270 (_691)
                float curtGate = inRange * curt.w;                                                       // b347:271 (_692)
                s.emission += interiorRGB * curtGateInv;                                                 // b347:272-274 (RT0)
                float w917 = 1.0 - _InteriorDepthColor.w;                                                // b347:309 (_917, 槽.z 角色回填候选, NOTES)
                s.albedo = curtGate * (curt.rgb * lerp(s.albedo, float3(1.0, 1.0, 1.0), w917));          // b347:310-312 (_683·lerp(_901,1,_917))
            }
        #endif

            // F0/漫反射拆分 (b11:298-305)
            s.f0      = lerp((HG_DIELECTRIC_F0 * _Specular).xxx, s.albedo, s.metallic);
            s.diffuse = s.albedo * (1.0 - s.metallic);
            return s;
        }

        // ====================================================================================
        // 前向光照合成(b11:922-1323 逐位, 引擎面按文件头替换表换 URP):
        //   A 漫反射环境: diffuse*SH(N)*occ*EnvX          (b11:3875 A 项; IV-clipmap→SampleSH)
        //   B 镜面环境:   (f0*scale+bias)*refl*EnvY        (b11:3875 B 项; probe 分箱→URP 反射)
        //   直接光: mad(energy,NoL,NoL*diffuse)*color*atten (主光 b11:963-970 + 点光 b11:1212)
        //   雾: URP fogFactor+MixFog (大气+指数+froxel 替代)
        // ====================================================================================
        float4 HgForwardLighting(HgSurface s, Varyings IN, bool isFrontFaceGlobal)
        {
            float3 N = s.normalWS;
            float4 viewData = HgViewDirWS(IN.positionWS);
            float3 V = viewData.xyz;
            float  NoV = max(dot(N, V), 0.0);                                    // b11:307 (_528)

            float envScale, envBias;
            HgEnvBRDF(s.roughness, NoV, s.f0, envScale, envBias);                // b11:308-309,1241

            float3 ambientSH  = SampleSH(N);                                     // IV-clipmap 级联替代
            float3 reflectVec = reflect(-V, N);                                  // b11:558-562 (_988..)
            // occlusion=1: HG B 项不对反射施 AO(仅 A 项吃 _3081), b11:3875。
            float3 reflection = GlossyEnvironmentReflection(reflectVec, s.roughness, 1.0);

            float3 ambientDiffuse = s.diffuse;
        #if defined(_SUBSURFACE) || defined(_SUBSURFACE_DEFAULTLIT)
            ambientDiffuse = mad(s.sssTint, _SubsurfaceIndirect.xxx, s.diffuse);      // b52:1761 环境 A 项折入间接 SSS
        #endif
            float3 color = ambientDiffuse * ambientSH * s.occlusion * _EnvironmentGlobalParams0.x
                         + mad(s.f0, envScale.xxx, envBias.xxx) * reflection * _EnvironmentGlobalParams0.y;

            // ---- 主方向光 (b11:922-970; CSM/ASM/ramp/云影 → URP shadowAttenuation) ----
            float4 shadowCoord = TransformWorldToShadowCoord(IN.positionWS);
            Light mainLight = GetMainLight(shadowCoord, IN.positionWS, half4(1, 1, 1, 1));
            {
                float3 L = mainLight.direction;
                float3 H = (L + V) * rsqrt(max(dot(L + V, L + V), HG_EPS_HALF)); // b11:937-943 (_2136..)
                float NoL = saturate(dot(L, N));
                float NoH = saturate(dot(N, H));
                float VoH = saturate(dot(V, H));
                float3 energy = HgDirectLightEnergy(s.roughness, s.f0, NoL, NoH, NoV, VoH);
                float atten = mainLight.distanceAttenuation * mainLight.shadowAttenuation;
                float3 perLight = mad(energy, NoL.xxx, s.diffuse * NoL);
            #if defined(_SUBSURFACE) || defined(_SUBSURFACE_DEFAULTLIT)
                perLight += HgSssLobe(s.sssAmount, dot(L, N), dot(V, L)) * s.sssTint;   // b52:1207-1213 逐光叠加
            #endif
                color += perLight * (mainLight.color * atten);
            }

            // ---- 点光/聚光 (b11:978-1239 zbin 分箱循环 → URP additional-lights; 同能量括号) ----
        #if defined(_ADDITIONAL_LIGHTS)
            uint lightCount = GetAdditionalLightsCount();
            InputData inputData = (InputData)0;                                  // Forward+ LIGHT_LOOP 所需最小面
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
                float localShadow = 1.0;                                         // 局部光阴影 keyword=litforward 家族专属, lit 恒关
                float3 perAddLight = mad(energy, NoL.xxx, s.diffuse * NoL);
        #if defined(_SUBSURFACE) || defined(_SUBSURFACE_DEFAULTLIT)
                perAddLight += HgSssLobe(s.sssAmount, dot(L, N), dot(V, L)) * s.sssTint;  // b52:1543-1550 点光同波瓣
        #endif
                color += perAddLight * (light.color * (light.distanceAttenuation * localShadow));
            LIGHT_LOOP_END
        #endif

            color += s.emission;
            float alphaOut = s.alpha;
            // <<HOOK:FORWARD_POST>>

            color = MixFog(color, IN.fogFactor);
            return float4(color, alphaOut);
        }

        // ====================================================================================
        // Alpha clip 双形态(真源两套):
        //   阴影/深度 pass (b911:135 / b1099:133): baseA*_BaseColor.a < 阈值 (只读 BaseColor.A)。
        //   主 pass (_ZWRITE_OFF 变体 b609:175, preZ 关闭时自清): 带通道选择
        //     lerp(baseA, nrm.a, _AlphaMaskChannel)*_BaseColor.a < 阈值。
        // 原版主 pass 平时不 clip(靠 preZ+ZTest Equal);URP 各 pass 独立 clip=净行为等价, 主 pass 用完整通道式。
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
            float alpha = mad(_AlphaMaskChannel, -baseA + nrmA, baseA) * _BaseColor.w;   // b609:175
            clip(alpha - _AlphaClipThreshold);
        #endif
        }

        // ====================================================================================
        // DITHER: LOD 淡出/切割面抖动 discard(b1167:128-137 逐位)。
        //   noise = frac(frac(dot(screenPos + distOffset, (0.0671105608, 0.0058371499))) * 52.9829178)
        //   distOffset = |对象世界原点| * _DitherTransparentOffset, 仅淡出中(0.99993896>=1-maxYZ)生效
        //   discard 当 mad(-(dot(P,_CutOffDirection)>= _CutOffPosY ? 1:0), _UseCutOff,
        //               min(1-max(LODFade.z,LODFade.y)-noise, LODFade.x -+ noise)) < 0
        //   unity_LODFade URP 原生同布局, 全式零替换。
        // ====================================================================================
        void HgDitherClip(float4 positionCS, float3 positionWS)
        {
        #ifdef DITHER
            float fadeInv = 1.0 - max(unity_LODFade.z, unity_LODFade.y);                     // b1167:132 (_48)
            float3 objOrigin = float3(UNITY_MATRIX_M._m03, UNITY_MATRIX_M._m13, UNITY_MATRIX_M._m23);
            float distOffset = sqrt(dot(objOrigin, objOrigin)) * _DitherTransparentOffset;   // b1167:133 (_71)
            float fadeGate = (0.99993896484375 >= fadeInv) ? 1.0 : 0.0;                      // b1167:134 (_79)
            float noise = frac(frac(dot(float2(mad(distOffset, fadeGate, positionCS.x),
                                                mad(distOffset, fadeGate, positionCS.y)),
                                        float2(0.067110560834407806396484375, 0.005837149918079376220703125)))
                               * 52.98291778564453125);                                      // b1167:135 (_96) IGN
            float cutSide = (dot(positionWS, _CutOffDirection.xyz) >= _CutOffPosY) ? 1.0 : 0.0;
            float fadeTerm = min(fadeInv - noise,
                                 unity_LODFade.x - ((unity_LODFade.x >= 0.0) ? noise : -noise)); // b1167:136
            clip(mad(-cutSide, _UseCutOff, fadeTerm));                                        // <0 → discard
        #endif
        }
        ENDHLSL

        // ============================================================================================
        // Pass 1: UniversalForward — litforward/littransparent/liteffectblend 前向本体 + lit 全特性面。
        //   混合/深度状态材质驱动(不透明: One Zero+ZWrite; 透明: [_SrcBlend][_DstBlend], b littransparent 骨架)。
        // ============================================================================================
        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForward" }
            Blend One Zero
            ZWrite [_ZWriteGBuffer]
            ZTest [_ZTestGBuffer]
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex HgForwardVertex
            #pragma fragment HgForwardFragment

            // ---- 材质特性(六家族并集; HG multi_compile_local 出货组合 → URP shader_feature_local 按用采集) ----
            #pragma shader_feature_local _TWO_BASEMAP
            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _EMISSIVE_MAP
            #pragma shader_feature_local _EMISSIVE_MASK
            #pragma shader_feature_local _EMISSIVE_NOMAP
            #pragma shader_feature_local _EMISSIVE_ANIM
            #pragma shader_feature_local _EMISSIVE_ANIM_SWEEP
            #pragma shader_feature_local _TRI_CHANNEL_MASK
            #pragma shader_feature_local _TRI_CHANNEL_MASK_SWITCH_TEXTURE
            #pragma shader_feature_local _DETAIL_MAP
            #pragma shader_feature_local _PARALLAX_MAP
            #pragma shader_feature_local _PARALLAX_MAP_PBR
            #pragma shader_feature_local _PARALLAX_MAP_WORLDSPACE
            #pragma shader_feature_local _INTERIORMAPPING
            #pragma shader_feature_local _INTERIOR_PARALLAX
            #pragma shader_feature_local _LAYERBLEND
            #pragma shader_feature_local _LAYERBLEND_MASK
            #pragma shader_feature_local _LAYERBLEND_TOP
            #pragma shader_feature_local _LAYERBLEND_MOSS
            #pragma shader_feature_local _LAYERBLEND_NOISEBLEND
            #pragma shader_feature_local _TERRAIN_BLEND
            #pragma shader_feature_local _TERRAIN_BLEND_FROM_HEIGHT
            #pragma shader_feature_local _TERRAIN_BLEND_NOISE
            #pragma shader_feature_local _SUBSURFACE
            #pragma shader_feature_local _SUBSURFACE_DEFAULTLIT
            #pragma shader_feature_local _SUBSURFACE_THICKNESSMAP
            #pragma shader_feature_local _MATCAP
            #pragma shader_feature_local _FAKE_VOLUME
            #pragma shader_feature_local _FAKE_CRACK_LAYER
            #pragma shader_feature_local _FAKE_CRACK_CSM
            #pragma shader_feature_local _FAKE_REFRACTION
            #pragma shader_feature_local _FAKE_DUST_LAYER
            #pragma shader_feature_local _PARALLAX_DEFORM
            // ---- 顶点动画特性 ----
            #pragma shader_feature_local _UV_ANIMATION
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _USE_VERTOFFSETMASK
            #pragma shader_feature_local _SIMPLE_VERTEXANIM
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_CLOTH
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_ROPE
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_PENDULUM
            #pragma shader_feature_local _FOLIAGE_TRUNK
            #pragma shader_feature_local _MOVING_BAMBOO
            #pragma shader_feature_local _VAT_SOFTBODY
            #pragma shader_feature_local _VAT_RIGIDBODY
            #pragma shader_feature_local _UNLOAD_ROT_TEX
            #pragma shader_feature_local _GPU_CLOTH
            #pragma shader_feature_local _COMMONVAT_BONE_1
            #pragma shader_feature_local _COMMONVAT_BONE_3
            #pragma shader_feature_local _COMMONVAT_BONE_4

            // ---- URP 系统 keyword(替换 HG 引擎面的原生对应) ----
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
                HgDitherClip(IN.positionCS, IN.positionWS);
                HgSurface s = HgBuildSurface(IN, isFrontFace);
                float4 color = HgForwardLighting(s, IN, isFrontFace);
                return color;
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2: UniversalGBuffer — lit/liteffect/lithlod 的延迟路径, HG 5-MRT → URP 原生 4-RT 打包。
        //   表面数学 1:1;打包走 URP PackGBuffersBRDFData(StencilDeferred 解算需精确布局)。
        //   HG MRT 专属通道无 URP 载体, 文档化弃用: 吸水度(porosity)/地形SSS profile 位/MV 打包。
        //   F0 注: HG GBuffer 与 URP GBuffer 同样不携带 _Specular(双方解算端都重建 F0);
        //   _Specular=0.5 时 0.08*0.5=0.04 与 URP 电介质基完全一致 → 延迟路径默认逐位对齐。
        // ============================================================================================
        Pass
        {
            Name "GBuffer"
            Tags { "LightMode" = "UniversalGBuffer" }
            ZWrite [_ZWriteGBuffer]
            ZTest [_ZTestGBuffer]
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma exclude_renderers gles3 glcore
            #pragma vertex HgForwardVertex
            #pragma fragment HgGBufferFragment

            #pragma shader_feature_local _TWO_BASEMAP
            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _EMISSIVE_MAP
            #pragma shader_feature_local _EMISSIVE_MASK
            #pragma shader_feature_local _EMISSIVE_NOMAP
            #pragma shader_feature_local _EMISSIVE_ANIM
            #pragma shader_feature_local _EMISSIVE_ANIM_SWEEP
            #pragma shader_feature_local _TRI_CHANNEL_MASK
            #pragma shader_feature_local _TRI_CHANNEL_MASK_SWITCH_TEXTURE
            #pragma shader_feature_local _DETAIL_MAP
            #pragma shader_feature_local _PARALLAX_MAP
            #pragma shader_feature_local _PARALLAX_MAP_PBR
            #pragma shader_feature_local _PARALLAX_MAP_WORLDSPACE
            #pragma shader_feature_local _INTERIORMAPPING
            #pragma shader_feature_local _INTERIOR_PARALLAX
            #pragma shader_feature_local _LAYERBLEND
            #pragma shader_feature_local _LAYERBLEND_MASK
            #pragma shader_feature_local _LAYERBLEND_TOP
            #pragma shader_feature_local _LAYERBLEND_MOSS
            #pragma shader_feature_local _LAYERBLEND_NOISEBLEND
            #pragma shader_feature_local _TERRAIN_BLEND
            #pragma shader_feature_local _TERRAIN_BLEND_FROM_HEIGHT
            #pragma shader_feature_local _TERRAIN_BLEND_NOISE
            #pragma shader_feature_local _SUBSURFACE
            #pragma shader_feature_local _SUBSURFACE_DEFAULTLIT
            #pragma shader_feature_local _SUBSURFACE_THICKNESSMAP
            #pragma shader_feature_local _MATCAP
            #pragma shader_feature_local _FAKE_VOLUME
            #pragma shader_feature_local _FAKE_CRACK_LAYER
            #pragma shader_feature_local _FAKE_CRACK_CSM
            #pragma shader_feature_local _FAKE_REFRACTION
            #pragma shader_feature_local _FAKE_DUST_LAYER
            #pragma shader_feature_local _PARALLAX_DEFORM
            #pragma shader_feature_local _ZWRITE_OFF
            #pragma shader_feature_local _UV_ANIMATION
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _USE_VERTOFFSETMASK
            #pragma shader_feature_local _SIMPLE_VERTEXANIM
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_CLOTH
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_ROPE
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_PENDULUM
            #pragma shader_feature_local _FOLIAGE_TRUNK
            #pragma shader_feature_local _MOVING_BAMBOO
            #pragma shader_feature_local _VAT_SOFTBODY
            #pragma shader_feature_local _VAT_RIGIDBODY
            #pragma shader_feature_local _UNLOAD_ROT_TEX
            #pragma shader_feature_local _GPU_CLOTH
            #pragma shader_feature_local _COMMONVAT_BONE_1
            #pragma shader_feature_local _COMMONVAT_BONE_3
            #pragma shader_feature_local _COMMONVAT_BONE_4

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
                HgAlphaClipMain(IN.uv);          // b609:175(_ZWRITE_OFF 自清路径的通道式; URP 无 preZ 依赖→恒 clip)
                HgDitherClip(IN.positionCS, IN.positionWS);
                HgSurface s = HgBuildSurface(IN, isFrontFace);

                // 环境项(HG 延迟解算端的 A/B 项在 URP 于 GBuffer 期落入 GI 目标, 数学同 b11:3875)
                float3 N = s.normalWS;
                float4 viewData = HgViewDirWS(IN.positionWS);
                float  NoV = max(dot(N, viewData.xyz), 0.0);
                float envScale, envBias;
                HgEnvBRDF(s.roughness, NoV, s.f0, envScale, envBias);
                float3 reflectVec = reflect(-viewData.xyz, N);
                float3 reflection = GlossyEnvironmentReflection(reflectVec, s.roughness, 1.0);
                float3 giColor = s.diffuse * SampleSH(N) * s.occlusion * _EnvironmentGlobalParams0.x
                               + mad(s.f0, envScale.xxx, envBias.xxx) * reflection * _EnvironmentGlobalParams0.y;

            #ifdef _SUBSURFACE_DEFAULTLIT
                // b397:139-144: DefaultLit SSS 在 GBuffer 期用主光预点亮进自发光(源即无阴影), URP GetMainLight 等价。
                {
                    Light gbMain = GetMainLight();
                    s.emission += (HgSssLobe(s.sssAmount, dot(gbMain.direction, N), dot(viewData.xyz, gbMain.direction)) * s.sssTint) * gbMain.color;
                }
            #endif
                // _SUBSURFACE(非 DefaultLit)延迟形态=厚度写 HG RT2.x 由引擎解算(b395:185); URP 无解算器→该形态仅前向生效(文档)。

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
        // Pass 3: ShadowCaster — b910/b911 (位置管线 + baseA clip + DITHER + 顶点动画随动)。
        //   HG 影 VP 变换 → URP ApplyShadowBias(_CASTING_PUNCTUAL_LIGHT_SHADOW)。
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
            #pragma shader_feature_local DITHER
            #pragma shader_feature_local _UV_ANIMATION
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _USE_VERTOFFSETMASK
            #pragma shader_feature_local _SIMPLE_VERTEXANIM
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_CLOTH
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_ROPE
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_PENDULUM
            #pragma shader_feature_local _FOLIAGE_TRUNK
            #pragma shader_feature_local _MOVING_BAMBOO
            #pragma shader_feature_local _VAT_SOFTBODY
            #pragma shader_feature_local _VAT_RIGIDBODY
            #pragma shader_feature_local _UNLOAD_ROT_TEX
            #pragma shader_feature_local _GPU_CLOTH
            #pragma shader_feature_local _COMMONVAT_BONE_1
            #pragma shader_feature_local _COMMONVAT_BONE_3
            #pragma shader_feature_local _COMMONVAT_BONE_4
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
                HgAlphaClipDepth(IN.uv);     // b911:135 (baseA 单通道)
                HgDitherClip(IN.positionCS, IN.positionWS);
                return 0;
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 4: DepthOnly — b1098/b1099 (相机深度 + baseA clip + DITHER + 顶点动画随动)。
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
            #pragma shader_feature_local DITHER
            #pragma shader_feature_local _UV_ANIMATION
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _USE_VERTOFFSETMASK
            #pragma shader_feature_local _SIMPLE_VERTEXANIM
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_CLOTH
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_ROPE
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_PENDULUM
            #pragma shader_feature_local _FOLIAGE_TRUNK
            #pragma shader_feature_local _MOVING_BAMBOO
            #pragma shader_feature_local _VAT_SOFTBODY
            #pragma shader_feature_local _VAT_RIGIDBODY
            #pragma shader_feature_local _UNLOAD_ROT_TEX
            #pragma shader_feature_local _GPU_CLOTH
            #pragma shader_feature_local _COMMONVAT_BONE_1
            #pragma shader_feature_local _COMMONVAT_BONE_3
            #pragma shader_feature_local _COMMONVAT_BONE_4
            #pragma multi_compile_instancing

            Varyings HgDepthVertex(Attributes IN)
            {
                return HgVertexCore(IN);
            }

            half4 HgDepthFragment(Varyings IN) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                HgAlphaClipDepth(IN.uv);     // b1099:133 (baseA 单通道)
                HgDitherClip(IN.positionCS, IN.positionWS);
                return 0;
            }
            ENDHLSL
        }
    }
}
