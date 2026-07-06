// ============================================================================================
// HGRP/LitTransparent — EndField littransparent.shader 的 URP 1:1 单文件重构。
// 真值 = AllShader_1.3.3 出货变体反编译:
//   ForwardLit: b25/b26(基, 含 _EMISSIVE_MAP) b38(_EMISSIVE_MASK) b40(_USE_REFRACTION)
//     b46(_GLASS_REFRACTION_SCENECOLOR) b50(_USE_DISSOLVE) b52(_SUBSURFACE) b56(_USE_FRESNEL)
//     b58/104(_TRI_CHANNEL_MASK) b54/100(_MATCAP) b60(_SIMPLE_VERTEXANIM_CLOTH) b66(_USE_HIGH_REFLECTION)
//     b80(DITHER) b70/80(_TWO_BASEMAP)
//   ShadowCaster: b119/120 + SVA 对; ForwardReflection: b128/b129(八面体法线+粗糙度 → 平面反射解算输入)。
// 引擎面替换(逐处注): IV-clipmap SH→SampleSH; probe 分箱→GlossyEnvironmentReflection;
//   CSM/ASM/云影/ramp→URP 主光阴影; 点光 zbin+cube 影集→URP additional(源恒开局部影);
//   DFG LUT→解析多项式; 雾→MixFog; 场景色 T5→_CameraOpaqueTexture; 场景深度→_CameraDepthTexture;
//   MV RT1(Blend1 One One/ColorMask R)→弃(URP MotionVectors 域); SceneEffect per-draw→中性; 曝光=1。
// ============================================================================================
Shader "HGRP/LitTransparent"
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
        _BaseColorBrighterScale ("固有色变亮", Range(1, 2)) = 1
        _BasePbrMapSection ("基础法线与 PBR 材质贴图", Float) = 0
        _NormalMap ("法线贴图", 2D) = "bump" {}
        _MROMap ("MRO 贴图", 2D) = "white" {}
        [Enum(UV0, 0, UV1, 1)] _BasePbrMapUVSet ("UV 通道", Float) = 0
        _NormalScale ("法线贴图强度", Range(0, 2)) = 1
        [ToggleUI] _TwoSidedNormal ("双面材质反转背面法线", Float) = 1
        _BasePbrCfgSection ("基础 PBR 材质设置", Float) = 0
        _Metallic ("金属度滑杆", Range(0, 1)) = 0
        _Specular ("Specular (Default 0.5)", Range(0, 1)) = 0.5
        _RoughnessMin ("最小粗糙度", Range(0, 1)) = 0
        _RoughnessMax ("最大粗糙度", Range(0, 1)) = 1
        _OcclusionStrength ("AO 强度", Range(0, 1)) = 1
        [Toggle(_TWO_BASEMAP)] _KwTwoBaseMap ("KW _TWO_BASEMAP(双贴图打包)", Float) = 0

        _BaseAlphaSection ("基础透明设置", Float) = 0
        [ToggleUI] _Use_VerexTexColorAsOpacity ("用顶点色控制Opacity", Float) = 0
        _AlphaMaskChannel ("透贴通道", Float) = 0

        // ---- 自发光 ----
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
        _EmissiveRemap ("Emissive Remap", Float) = 1
        _EmissiveAnimSpeed ("呼吸频率(骨架属性)", Range(0, 20)) = 0
        [Toggle(_EMISSIVE_MAP)] _KwEmissiveMap ("KW _EMISSIVE_MAP(=通道 0)", Float) = 0
        [Toggle(_EMISSIVE_MASK)] _KwEmissiveMask ("KW _EMISSIVE_MASK(=通道 1-4)", Float) = 0

        // ---- 三通道 Mask ----
        [Toggle(_TRI_CHANNEL_MASK)] _EnableTriChannelMask ("混合/三通道 Mask 材质控制", Float) = 0
        _MaskMap ("三通道 Mask", 2D) = "black" {}
        [Enum(UV0, 0, UV1, 1)] _MaskUVSet ("UV 通道", Float) = 0
        [Header(R Channel)] [Space(10)] _MaskAlbedoR ("Mask R Color", Color) = (1, 0, 0, 1)
        _MaskRScale ("Mask R Scale", Range(0, 3)) = 0
        _MaskROffset ("Mask R Offset", Range(-1, 1)) = 0
        _MaskRoghnessR ("Mask R Roughness", Range(0, 1)) = 0.25
        _MaskMetallicR ("Mask R Metallic", Range(0, 1)) = 0
        [Header(G Channel)] _MaskAlbedoG ("Mask G Color", Color) = (0, 1, 0, 1)
        _MaskGScale ("Mask G Scale", Range(0, 3)) = 0
        _MaskGOffset ("Mask G Offset", Range(-1, 1)) = 0
        _MaskRoghnessG ("Mask G Roughness", Range(0, 1)) = 0.25
        _MaskMetallicG ("Mask G Metallic", Range(0, 1)) = 0
        [Header(B Channel)] _MaskAlbedoB ("Mask B Color", Color) = (0, 0, 1, 1)
        _MaskBScale ("Mask B Scale", Range(0, 3)) = 0
        _MaskBOffset ("Mask B Offset", Range(-1, 1)) = 0
        _MaskRoghnessB ("Mask B Roughness", Range(0, 1)) = 0.25
        _MaskMetallicB ("Mask B Metallic", Range(0, 1)) = 0

        // ---- 菲涅尔 ----
        [Toggle(_USE_FRESNEL)] _UseFresnel ("其他/Use Fresnel", Float) = 0
        [Enum(None, 0, BaseColor A, 1, NormalMap B, 2, NormalMap A, 3, MRO A, 4)] _FresnelMapChannel ("菲涅尔蒙版通道", Float) = 0
        _FresnelMaskOffset ("Fresnel Mask Offset", Range(0, 1)) = 0
        [HDR] [Gamma] _FresnelColor ("Fresnel Color", Color) = (1, 1, 1, 1)
        _FresnelBias ("Fresnel Bias(Default:0)", Range(-1, 2)) = 0
        _FresnelAffectOpacity ("Fresnel Affect Opacity", Range(0, 1)) = 1
        _FresnelPower ("Fresnel Power(Default:1)", Range(1, 100)) = 1
        [ToggleUI] _Use_VerexGAsFresnelOpacity ("使用顶点色G通道控制菲涅尔强度", Float) = 0
        [ToggleUI] _FresnelUseMeshNormal ("菲涅尔效果使用模型法线", Float) = 0
        [ToggleUI] _FresnelFlip ("Fresnel Flip", Float) = 0.001

        // ---- 折射/玻璃 ----
        [Toggle(_USE_REFRACTION)] _UseRefraction ("折射反射/Use Refraction", Float) = 0
        _IoRLowTier ("_IoRLowTier", Range(0, 1)) = 0
        _RefractionIntensity ("_RefractionIntensity", Range(0, 1)) = 0
        [Toggle(_GLASS_REFRACTION_SCENECOLOR)] _EnableGlassRefraction ("折射反射/玻璃折射", Float) = 0
        [Enum(RefractiveIndex, 0, CustomTex, 1)] _UseCustomRefractTex ("折射类型", Float) = 0
        _RefractTint ("折射染色 Refract Tint", Color) = (1, 1, 1, 1)
        _RefractionContribution ("折射贡献 Refraction Contribution", Range(0, 1)) = 0.8
        _RefractThickness ("厚度 Refract Thickness", Range(0, 1)) = 0.01
        [Enum(Solid, 0, Shell, 1)] _IsShell ("玻璃类型:Solid实心/Shell壳", Float) = 1
        _IoR ("折射率 IoR", Range(-1, 1)) = 0.8
        _RefractTex ("自定义折射贴图", 2D) = "black" {}
        _RefractTexIntensity ("折射贴图强度", Range(0, 1)) = 0.01
        _RefractBrightness ("折射亮度", Range(0, 1)) = 1
        [Toggle(_USE_HIGH_REFLECTION)] _KwUseHighReflection ("折射反射/高反射", Float) = 0
        // _FULLY_TRANSPARENT: 死 keyword(全 rip 无出货变体)
        [Toggle(_FULLY_TRANSPARENT)] _EnableFullyTransparent ("折射反射/全透明玻璃(未出货)", Float) = 0

        // ---- 次表面散射(本家仅 _SUBSURFACE 单键) ----
        [Toggle(_SUBSURFACE)] _KwSubsurface ("次表面3S/次表面散射", Float) = 0
        _EnableSubsurface ("次表面3S(编辑器槽)", Float) = 0
        [Enum(Default, 0, BaseColor, 1)] _SubsurfaceShadingMode ("次表面散射模式", Float) = 0
        [HDR] _SubsurfaceColor ("次表面散射颜色", Color) = (1, 1, 1, 1)
        _SubsurfaceIndirect ("次表面散射对间接光影响", Range(0, 1)) = 1
        _MinSubsurfaceThickness ("最小厚度", Range(0, 1)) = 0
        _MaxSubsurfaceThickness ("最大厚度", Range(0, 1)) = 1
        [Toggle(_SUBSURFACE_THICKNESSMAP)] _EnableSubsurfaceThicknessMap ("使用厚度图(骨架属性)", Float) = 0
        [Enum(General, 0, Fresnel, 1)] _SubsurfaceThicknessApproxMode ("厚度模拟选项", Float) = 0
        _SubsurfaceParallaxFresnel ("厚度菲尼尔模拟", Range(0, 5)) = 0
        [Enum(UV1, 0, UV0, 1)] _SubsurfaceMapMaskUVType ("次表面散射遮罩UV", Float) = 0
        _SubsurfaceMap ("次表面散射遮罩(R)", 2D) = "white" {}
        [ToggleUI] _SubsurfaceEnableSelfShadowBias ("背投次表面自阴影", Float) = 0
        _SubsurfaceSelfShadowBias ("背投次表面自阴影偏移", Range(0, 10)) = 0
        [ToggleUI] _SubsurfaceApplyLayerBlend ("应用Layer Blend的混合结果", Float) = 0
        [HideInInspector] _SubsurfaceHue ("Subsurface Hue", Float) = 1
        [HideInInspector] _SubsurfaceSaturation ("Subsurface Saturation", Float) = 1
        [HideInInspector] _SubsurfaceValue ("Subsurface Value", Float) = 1

        // ---- 溶解 ----
        [Toggle(_USE_DISSOLVE)] _UseDissolve ("溶解/Use Dissolve", Float) = 0
        _DissolveEdgeSharp ("Dissolve Edge Sharp", Float) = 0
        _DissolveScheduleOffset ("Dissolve Schedule Offset", Float) = 0
        _DissolveEmissiveEdge ("Dissolve Emissive Edge(出货未读)", Float) = 0
        _DissolveUVSpeed ("Dissolve UV Speed(XY:By Time)", Vector) = (0, 0, 0, 0)
        [HDR] _DissolveEmissiveColor ("Dissolve Emissive Color", Color) = (0, 0, 0, 1)
        _DissolveTex ("Dissolve Tex", 2D) = "white" {}
        [HideInInspector] _UseScanDissolve ("Use Scan Dissolve", Float) = 0
        _DissolveUVRotate ("DissolveUVRotate(Degree)", Float) = 0
        [ToggleUI] _DissolveTexUseDisturb ("Dissolve Tex Use Disturb", Float) = 0
        _DissolveDir ("Dissolve Dir", Vector) = (0, 0, 0, 0)
        [HideInInspector] _DissolveSpeed ("Dissolve Speed", Vector) = (0, 0, 0, 0)
        _DissolveScanSchedule ("Scan Schedule", Float) = -1
        _DissolveScanWidth ("Scan Width", Range(0.1, 1)) = 0
        _DissolveEmissiveWidth ("Emissive Width", Range(0, 5)) = 0

        // ---- Matcap ----
        [Toggle(_MATCAP)] _EnableMatcap ("其他/Matcap", Float) = 0
        _MatcapMap ("Matcap Map", 2D) = "black" {}
        _MatcapMapStrength ("MatcapMapStrength", Range(0, 1)) = 0.2
        [ToggleUI] _MatCapIgnorePostExposure ("不受自动曝光影响", Float) = 1

        // ---- 简单顶点动画(本家=CLOTH) ----
        [Toggle(_SIMPLE_VERTEXANIM)] _EnableSimpleVertexAnim ("顶点相关/简单顶点动画", Float) = 0
        [Toggle(_SIMPLE_VERTEXANIM_CLOTH)] _KwSvaCloth ("KW _SIMPLE_VERTEXANIM_CLOTH(=类型0)", Float) = 0
        [Enum(ClothAndKite, 0, Rope, 1, Pendulum, 2)] _SimpleVertexAnimationType ("物体类型", Float) = 0
        [ToggleUI] _Use_Gravity ("根据重力下垂", Float) = 0
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
        _DirectionTendency ("方向倾向性", Range(-5, 5)) = 0
        _Stability ("物体刚度", Range(0, 1)) = 1
        _RopeAnchorAdjust ("绳子锚点矫正", Float) = 3
        [ToggleUI] _Add_Noise ("是否增加扰动", Float) = 0
        _NoiseOffsetTex ("扰动贴图", 2D) = "black" {}
        _NoiseOffsetTexTilling ("扰动贴图Tilling", Range(0, 5)) = 0.12
        _NoiseOffsetIntensity ("扰动强度", Range(0, 10)) = 1
        _NoiseOffsetSpeed ("扰动速度", Vector) = (4, 1, 0, 0)
        _NoiseOffsetDir ("扰动方向(模型空间的xyz)", Vector) = (-0.3, -0.2, -0.2, 0)

        [Toggle(DITHER)] _KwDither ("KW DITHER(LOD 抖动淡出)", Float) = 0
        [ToggleUI] _RenderTransparentForReflection ("Transparent For Reflection", Float) = 0

        _AdvancedOptions ("Advanced Options", Float) = 0
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _TAAUNormalBiasReverse ("TAAU Normal偏移补偿", Float) = 0
        [ToggleUI] _ReceiveDecals ("Receive Decals", Float) = 1
        [Enum(Traditional, 0, Premultiplied, 1, Soft Additive, 2, Multiplicative, 3)] _TransparentBlendMode ("透明混合模式", Float) = 0
        [HideInInspector] _SrcBlend ("__src", Float) = 5
        [HideInInspector] _DstBlend ("__dst", Float) = 10
        [Enum(Off, 0, On, 1)] _Zwrite ("_Zwrite", Float) = 0
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _SurfaceType ("Surface Type", Float) = 1
        [HideInInspector] _EnableAlphaBlend ("Alpha Blend", Float) = 1
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
        [HideInInspector] _RenderTransparentAfterDistortion ("Transparent After Distortion", Float) = 0
        [HideInInspector] _RenderTransparentAfterDOF ("Transparent After DOF", Float) = 0
        [HideInInspector] _HlodBakeMaxEmissiveIntensity ("_HlodBakeMaxEmissiveIntensity", Float) = 0
        [HideInInspector] _DitherTransparentOffset ("Dither Transparent Offset", Range(0, 1)) = 0.1
        [HideInInspector] _CutOffPosY ("_CutOffPosY", Float) = 0
        [HideInInspector] _UseCutOff ("_UseCutOff", Float) = 0
        [HideInInspector] _CutOffDirection ("_CutOffDirection", Vector) = (0, 1, 0, 0)
        [HideInInspector] _frameCount ("Frame Count", Float) = 0
        [HideInInspector] _boundMaxX ("Bound Max X", Float) = 0
        [HideInInspector] _boundMaxY ("Bound Max Y", Float) = 0
        [HideInInspector] _boundMaxZ ("Bound Max Z", Float) = 0
        [HideInInspector] _boundMinX ("Bound Min X", Float) = 0
        [HideInInspector] _boundMinY ("Bound Min Y", Float) = 0
        [HideInInspector] _boundMinZ ("Bound Min Z", Float) = 0
        [HideInInspector] _B_pscaleAreInPosA ("Piece Scales Are In Position Alpha", Float) = 0
        [HideInInspector] _globalPscaleMul ("Global Piece Scale Multiplier", Float) = 1
        [HideInInspector] _B_stretchByVel ("Stretch by Velocity", Float) = 0
        [HideInInspector] _stretchByVelAmount ("Stretch by Velocity Amount", Float) = 0
        [HideInInspector] _B_animateFirstFrame ("Animate First Frame", Float) = 0
        [HideInInspector] _Padding ("_Padding", Float) = 0
        [HideInInspector] _Padding1 ("Padding1", Float) = 0
        [HideInInspector] _Padding2 ("Padding2", Float) = 0
        // HG 引擎全局 dial 的材质级落位(默认中性)
        [HideInInspector] _EnvironmentGlobalParams0 ("EnvGlobalParams0", Vector) = (1, 1, 1, 0)
    }

    SubShader
    {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" "Queue" = "Transparent" }
        LOD 600

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareOpaqueTexture.hlsl"

        CBUFFER_START(UnityPerMaterial)
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
            float _Use_VerexTexColorAsOpacity;
            float _AlphaMaskChannel;
            // 自发光
            float4 _EmissiveMap_ST;
            float4 _EmissiveColor;
            float4 _EmissiveColorG;
            float4 _EmissiveColorB;
            float4 _EmissiveColorA;
            float4 _EmissiveSpeed;
            float _EnableEmissiveMap;
            float _EmissiveUVSet;
            float _EmissiveType;
            float _EmissiveMaskChannel;
            float _EmissiveRemap;
            float _AlbedoAffectEmissive;
            float _IgnorePostExposure;
            // 三通道
            float4 _MaskMap_ST;
            float4 _MaskAlbedoR;
            float4 _MaskAlbedoG;
            float4 _MaskAlbedoB;
            float _MaskUVSet;
            float _MaskRScale;
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
            // 菲涅尔
            float4 _FresnelColor;
            float _FresnelMapChannel;
            float _FresnelMaskOffset;
            float _FresnelBias;
            float _FresnelAffectOpacity;
            float _FresnelPower;
            float _Use_VerexGAsFresnelOpacity;
            float _FresnelUseMeshNormal;
            float _FresnelFlip;
            // 折射/玻璃
            float4 _RefractTint;
            float4 _RefractTex_ST;
            float _IoRLowTier;
            float _RefractionIntensity;
            float _UseCustomRefractTex;
            float _RefractionContribution;
            float _RefractThickness;
            float _IsShell;
            float _IoR;
            float _RefractTexIntensity;
            float _RefractBrightness;
            // SSS
            float4 _SubsurfaceColor;
            float _SubsurfaceShadingMode;
            float _SubsurfaceIndirect;
            float _MinSubsurfaceThickness;
            float _MaxSubsurfaceThickness;
            float _SubsurfaceThicknessApproxMode;
            float _SubsurfaceParallaxFresnel;
            float _SubsurfaceMapMaskUVType;
            float _SubsurfaceEnableSelfShadowBias;
            float _SubsurfaceSelfShadowBias;
            float _SubsurfaceApplyLayerBlend;
            float _SubsurfaceHue;
            float _SubsurfaceSaturation;
            float _SubsurfaceValue;
            // 溶解
            float4 _DissolveUVSpeed;
            float4 _DissolveEmissiveColor;
            float4 _DissolveTex_ST;
            float4 _DissolveDir;
            float _DissolveEdgeSharp;
            float _DissolveScheduleOffset;
            float _DissolveUVRotate;
            float _DissolveScanSchedule;
            float _DissolveScanWidth;
            float _DissolveEmissiveWidth;
            // Matcap
            float _MatcapMapStrength;
            float _MatCapIgnorePostExposure;
            // SVA(CLOTH)
            float _SimpleVertexAnimationWindIntensity;
            float _SimpleVertexAnimationWindFreq;
            float _SimpleVertexAnimationWindSoftFactor;
            float _Use_Custom_WindDir;
            float _MainDirectionAngle;
            float _DirectionTendency;
            float _Kite;
            float _NoiseOffsetIntensity;
            // Dither/CutOff
            float _DitherTransparentOffset;
            float _CutOffPosY;
            float _UseCutOff;
            float4 _CutOffDirection;
            float4 _EnvironmentGlobalParams0;
        CBUFFER_END

        TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);
        TEXTURE2D(_NormalMap);      SAMPLER(sampler_NormalMap);
        TEXTURE2D(_MROMap);         SAMPLER(sampler_MROMap);
        TEXTURE2D(_EmissiveMap);    SAMPLER(sampler_EmissiveMap);
        TEXTURE2D(_MaskMap);        SAMPLER(sampler_MaskMap);
        TEXTURE2D(_RefractTex);     SAMPLER(sampler_RefractTex);
        TEXTURE2D(_SubsurfaceMap);  SAMPLER(sampler_SubsurfaceMap);
        TEXTURE2D(_DissolveTex);    SAMPLER(sampler_DissolveTex);
        TEXTURE2D(_MatcapMap);      SAMPLER(sampler_MatcapMap);
        // 平面反射 RT + 权重(_USE_HIGH_REFLECTION, b66; 宿主 SetGlobalTexture, 无宿主=黑→安全退化)
        TEXTURE2D(_FakePlanarReflectionTexture);     SAMPLER(sampler_FakePlanarReflectionTexture);
        TEXTURE2D(_FakePlanarReflectionMaskTexture); SAMPLER(sampler_FakePlanarReflectionMaskTexture);

        static const float3 HG_LUMA = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625);
        static const float HG_EPS_VIEWLEN     = 9.9999999392252902907785028219223e-09;
        static const float HG_EPS_NORMAL_Z    = 1.000000016862383526387164645044e-16;
        static const float HG_EPS_HALF        = 6.103515625e-05;
        static const float HG_EPS_VIS         = 9.9999997473787516355514526367188e-05;
        static const float HG_DIELECTRIC_F0   = 0.07999999821186065673828125;
        static const float HG_GRAZING_FLOOR   = 0.0476190485060214996337890625;
        static const float HG_NORMAL_DEADZONE = 0.01200000010430812835693359375;

        struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS   : NORMAL;
            float4 tangentOS  : TANGENT;
            float4 color      : COLOR;
            float2 uv0        : TEXCOORD0;
            float2 uv1        : TEXCOORD1;
            UNITY_VERTEX_INPUT_INSTANCE_ID
        };

        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float3 positionWS : TEXCOORD0;
            float4 uv         : TEXCOORD1;
            float3 normalWS   : TEXCOORD2;
            float4 tangentWS  : TEXCOORD3;
            float4 color      : TEXCOORD4;
            float  fogFactor  : TEXCOORD5;
            UNITY_VERTEX_INPUT_INSTANCE_ID
            UNITY_VERTEX_OUTPUT_STEREO
        };

        // ============================================================
        // _SIMPLE_VERTEXANIM(+CLOTH)(b59 干净名逐位):
        //   门: 顶点色A≠0 且 (风幅+扰动幅)≠0; ⚠deg→rad=0.01746725477278232574462890625(非 π/180, 保位);
        //   cos/sin 4/5 阶多项式; 风向=lerp(引擎全局风(_WindGlobalParams0.zw, 无宿主→自定基), 自定基, flag);
        //   kite: 0.05幅·sin(Kite·(posOS.y·soft−colorW·π)+phase+m03)·posOS.y(对象空间Y!);
        //   非 kite: 0.5幅·sin(−colorW·3.14−worldZ·soft+phase+m03); Δ=(amp·(wave+Tendency+1)·dir)·colorW·(1−m01)。
        //   风钟 _WindGlobalParams0.y→_Time.y; Last 钟二次求值=MV 弃。
        // ============================================================
        float3 LtrVertexAnimDeltaWS(Attributes IN, float3 positionWS)
        {
            float3 deltaWS = float3(0.0, 0.0, 0.0);
        #if defined(_SIMPLE_VERTEXANIM)
            if (!(IN.color.w == 0.0 || (_SimpleVertexAnimationWindIntensity + _NoiseOffsetIntensity) == 0.0)) // b59:188
            {
                float ang = 0.01746725477278232574462890625 * _MainDirectionAngle;   // b59:193
                float a2 = ang * ang;
                float a3 = ang * a2;
                float windCos = mad(a2 * a2, 0.013899999670684337615966796875, mad(-a2, 0.500400006771087646484375, 1.0));      // b59:196
                float windSin = mad(a2 * a3, 0.008340000174939632415771484375, mad(-a3, 0.1667999923229217529296875, ang));     // b59:197
                float dirX = mad(_Use_Custom_WindDir, windCos - windCos, windCos);   // 引擎风向无宿主→自定基回退
                float dirZ = mad(_Use_Custom_WindDir, windSin - windSin, windSin);
                float instPhase = UNITY_MATRIX_M._m03;                               // b59:205 (CB2[inst+3].x)
                float phase = _Time.y * _SimpleVertexAnimationWindFreq;              // b59:198
                float amplitude, wave;
                if (_Kite != 0.0)                                                    // b59:199
                {
                    amplitude = 0.0500000007450580596923828125 * _SimpleVertexAnimationWindIntensity;  // b59:204
                    wave = sin(mad(_Kite, mad(IN.positionOS.y, _SimpleVertexAnimationWindSoftFactor, -(IN.color.w * 3.1415927410125732421875)), phase) + instPhase) * IN.positionOS.y; // b59:205
                }
                else
                {
                    amplitude = 0.5 * _SimpleVertexAnimationWindIntensity;           // b59:192
                    wave = sin(mad(-IN.color.w, 3.1400001049041748046875, mad(-positionWS.z, _SimpleVertexAnimationWindSoftFactor, phase)) + instPhase); // b59:210
                }
                float waveScaled = (wave + _DirectionTendency) + 1.0;                // b59:230/235
                float perDrawScale = 1.0 - unity_ObjectToWorld._m01;                 // b59 (_226)
                deltaWS = float3(amplitude * (waveScaled * dirX), 0.0, amplitude * (waveScaled * dirZ)) * (IN.color.w * perDrawScale); // b59:239-241
            }
        #endif
            return deltaWS;
        }

        Varyings LtrVertex(Attributes IN)
        {
            Varyings OUT = (Varyings)0;
            UNITY_SETUP_INSTANCE_ID(IN);
            UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
            UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);
            float3 positionWS = TransformObjectToWorld(IN.positionOS);
            positionWS += LtrVertexAnimDeltaWS(IN, positionWS);
            OUT.positionWS = positionWS;
            OUT.positionCS = TransformWorldToHClip(positionWS);
            OUT.normalWS   = TransformObjectToWorldNormal(IN.normalOS);
            OUT.tangentWS  = float4(TransformObjectToWorldDir(IN.tangentOS.xyz), IN.tangentOS.w * GetOddNegativeScale());
            OUT.uv         = float4(IN.uv0, IN.uv1);
            OUT.color      = IN.color;
            OUT.fogFactor  = ComputeFogFactor(OUT.positionCS.z);
            return OUT;
        }

        void LtrComputeUVs(float4 uv, out float2 uvBase, out float2 uvPbr)
        {
            float2 duv = uv.zw - uv.xy;
            uvBase = mad(mad(_BaseUVSet.xx,       duv, uv.xy), _BaseColorMap_ST.xy, _BaseColorMap_ST.zw);   // b26:368-372
            uvPbr  = mad(mad(_BasePbrMapUVSet.xx, duv, uv.xy), _NormalMap_ST.xy,    _NormalMap_ST.zw);
        }

        struct LtrSurface
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
            float3 sssTint;
            float  sssAmount;
        };

        // ---- b11 光照内核(逐位, 同 lit 家族) ----
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

        float3 HgViewDirWS(float3 positionWS)
        {
            float3 raw;
            if (unity_OrthoParams.w == 0.0)
                raw = _WorldSpaceCameraPos - positionWS;
            else
                raw = float3(-UNITY_MATRIX_V[2].x, -UNITY_MATRIX_V[2].y, -UNITY_MATRIX_V[2].z);
            return raw * rsqrt(max(dot(raw, raw), HG_EPS_VIEWLEN));
        }

        // SSS 直接光波瓣(b52:1207-1213 逐位): wrap ⅔+⅓ / curve 1.6667·wrap^1.5 / 背透 pow12·(3−2.9t) / 自阴影门
        float HgSssLobe(float amount, float rawNoL, float VdotL)
        {
            float wrap  = clamp(mad(rawNoL, 0.666666686534881591796875, 0.3333333432674407958984375), 0.0, 1.0);
            float curve = mad(amount, mad(wrap * sqrt(wrap), 1.66666662693023681640625, -1.0), 1.0);
            float back  = exp2(log2(clamp(-VdotL, 0.0, 1.0)) * 12.0) * mad(amount, -2.900000095367431640625, 3.0);
            float lobe  = mad(back, mad(-curve, 0.15915493667125701904296875, 1.0), curve * 0.15915493667125701904296875);
            float gate  = clamp((rawNoL - _SubsurfaceSelfShadowBias * _SubsurfaceEnableSelfShadowBias) + 2.0, 0.0, 1.0);
            return lobe * gate;
        }

        void LtrDitherClip(float4 positionCS, float3 positionWS)
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

        // ---- 表面装配(b26 基 + 各特性模块, 全部逐位) ----
        LtrSurface LtrBuildSurface(Varyings IN, bool isFrontFace)
        {
            LtrSurface s = (LtrSurface)0;
            float2 uvBase, uvPbr;
            LtrComputeUVs(IN.uv, uvBase, uvPbr);

            float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uvBase);                    // b26:372
            float4 nrm     = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap, uvPbr, _TAAUNormalBiasReverse); // b26:373

        #ifdef _TWO_BASEMAP
            float metallicT  = baseTex.w;
            float roughT     = nrm.z;
            float occT       = nrm.w;
            float nxRaw = mad(nrm.x, 2.0, -1.0);
            float nyRaw = mad(nrm.y, 2.0, -1.0);
            float nxDec = (abs(nxRaw) < HG_NORMAL_DEADZONE) ? 0.0 : nxRaw;
            float nyDec = (abs(nyRaw) < HG_NORMAL_DEADZONE) ? 0.0 : nyRaw;
        #else
            float4 mro = SAMPLE_TEXTURE2D(_MROMap, sampler_MROMap, uvPbr);                                     // b26:378
            float metallicT  = mro.x;
            float roughT     = mro.y;
            float occT       = mro.z;
            float nxDec = mad(nrm.x * nrm.w, 2.0, -1.0);                                                       // b26:374 (DXT5nm)
            float nyDec = mad(nrm.y,         2.0, -1.0);
        #endif
            float nx = nxDec * _NormalScale;                                                                   // b26:376-377
            float ny = nyDec * _NormalScale;

            float3 albedoRaw = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale);               // b26:392-394
            float3 baseCol   = lerp(albedoRaw, _BaseColor.rgb, _BaseColorTintCover);                           // b26:395-397

            float roughness = lerp(_RoughnessMin, _RoughnessMax, roughT);                                      // b26:382
            float metallic  = lerp(metallicT, _Metallic, saturate(_BaseTextureMapCount - 1.0));                // b26:383
            float occlusion = lerp(1.0, occT, _OcclusionStrength);                                             // b26:1616
            float frontSign = isFrontFace ? 1.0 : ((_TwoSidedNormal > 0.0) ? -1.0 : 1.0);
            float nz = max(sqrt(1.0 - min(dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 1.0)), HG_EPS_NORMAL_Z) * frontSign; // b26:405
            float tangentSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
            float3 bitangent  = tangentSign * cross(IN.normalWS, IN.tangentWS.xyz);
            float3 normalWS   = normalize(IN.normalWS * nz + IN.tangentWS.xyz * nx + bitangent * ny);          // b26:406-412

            // alpha(b26:380-381): baseA×_BaseColor.a, 可选×顶点色.x
            float baseAlpha = baseTex.w * _BaseColor.w;
            float alpha = lerp(baseAlpha, baseAlpha * IN.color.x, _Use_VerexTexColorAsOpacity);                // b26:381 (_387)

            s.albedo    = baseCol;
            s.normalWS  = normalWS;
            s.metallic  = metallic;
            s.roughness = roughness;
            s.occlusion = occlusion;
            s.alpha     = alpha;
            s.emission  = float3(0.0, 0.0, 0.0);

            // ============================================================
            // _TRI_CHANNEL_MASK(lit b291 == 本家 b104 同构): B→G→R 链
            // ============================================================
        #ifdef _TRI_CHANNEL_MASK
            {
                float2 duvM = IN.uv.zw - IN.uv.xy;
                float2 uvMask = mad(mad(_MaskUVSet.xx, duvM, IN.uv.xy), _MaskMap_ST.xy, _MaskMap_ST.zw);
                float4 maskTex = SAMPLE_TEXTURE2D(_MaskMap, sampler_MaskMap, uvMask);
                float wB = clamp(mad(maskTex.z + _MaskBOffset, _MaskBScale + 1.0, _MaskBScale * (-0.5)), 0.0, 1.0) * _MaskAlbedoB.w;
                float wG = clamp(mad(maskTex.y + _MaskGOffset, _MaskGScale + 1.0, _MaskGScale * (-0.5)), 0.0, 1.0) * _MaskAlbedoG.w;
                float wR = clamp(mad(maskTex.x + _MaskROffset, _MaskRScale + 1.0, _MaskRScale * (-0.5)), 0.0, 1.0) * _MaskAlbedoR.w;
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
            // 自发光(b26:384-405 逐位; SceneEffect per-draw 中性; 时间=_VFXParams0.w→_Time.y)
            // ============================================================
        #if defined(_EMISSIVE_MAP) || defined(_EMISSIVE_MASK)
            {
                float3 albedoAffect = lerp(s.albedo, float3(1.0, 1.0, 1.0), _AlbedoAffectEmissive);
            #ifdef _EMISSIVE_MAP
                float2 duvEm = IN.uv.zw - IN.uv.xy;
                float2 uvEm = mad(_EmissiveSpeed.xy, _Time.y,
                                  mad(mad(_EmissiveUVSet.xx, duvEm, IN.uv.xy), _EmissiveMap_ST.xy, _EmissiveMap_ST.zw)); // b26:384
                float4 em = SAMPLE_TEXTURE2D(_EmissiveMap, sampler_EmissiveMap, uvEm);
                float3 route = _EmissiveColor.rgb * em.x
                             + (_EmissiveColorG.rgb * em.y + _EmissiveColorB.rgb * em.z + _EmissiveColorA.rgb * em.w) * _EmissiveType; // b26 家族路由
                s.emission += route * albedoAffect * _EmissiveRemap;
            #elif defined(_EMISSIVE_MASK)
                float mroA = 0.0;
            #ifndef _TWO_BASEMAP
                mroA = SAMPLE_TEXTURE2D(_MROMap, sampler_MROMap, uvPbr).w;
            #endif
                float sel = mad(clamp(_EmissiveMaskChannel - 1.0, 0.0, 1.0), -baseTex.w + nrm.z, baseTex.w);   // b315:165 同构(b38)
                sel = mad(clamp(_EmissiveMaskChannel - 2.0, 0.0, 1.0), nrm.w - sel, sel);
            #ifndef _TWO_BASEMAP
                sel = mad(clamp(_EmissiveMaskChannel - 3.0, 0.0, 1.0), mroA - sel, sel);
            #endif
                float chGate  = clamp(_EmissiveMaskChannel, 0.0, 1.0);
                float maskVal = clamp(mad(mad(chGate, sel - 1.0, 1.0), 1.111111164093017578125, -0.055555559694766998291015625), 0.0, 1.0);
                s.emission += (_EmissiveColor.rgb * ((maskVal * chGate) * _EnableEmissiveMap)) * albedoAffect * _EmissiveRemap;
            #endif
            }
        #endif

            // ============================================================
            // _MATCAP(lit b501 == 本家 b100 同构): 视空间法线 xy→[0,1]
            // ============================================================
        #ifdef _MATCAP
            {
                float3 viewN = mul((float3x3)UNITY_MATRIX_V, s.normalWS);
                float2 uvMatcap = float2((viewN.x + 1.0) * 0.5, (viewN.y + 1.0) * 0.5);
                s.emission += SAMPLE_TEXTURE2D(_MatcapMap, sampler_MatcapMap, uvMatcap).rgb * _MatcapMapStrength;
            }
        #endif

            // ============================================================
            // _USE_DISSOLVE(b50 逐位): 方向扫描溶解 + 边缘自发光
            // ============================================================
        #ifdef _USE_DISSOLVE
            {
                float rotA = 0.01745329238474369049072265625 * _DissolveUVRotate;                // b50:438 (真 π/180)
                float sR = sin(rotA), cR = cos(rotA);
                float2 uvD = mad(_DissolveUVSpeed.xy, _Time.y, mad(IN.uv.xy, _DissolveTex_ST.xy, _DissolveTex_ST.zw)) - 0.5; // b50:441-442
                float2 uvDR = float2(dot(uvD, float2(cR, sR)) + 0.5, dot(uvD, float2(-sR, cR)) + 0.5);
                float texD = SAMPLE_TEXTURE2D(_DissolveTex, sampler_DissolveTex, uvDR).x;
                float3 objOriginD = float3(UNITY_MATRIX_M._m03, UNITY_MATRIX_M._m13, UNITY_MATRIX_M._m23);
                float3 dirWS_D = mul((float3x3)unity_ObjectToWorld, _DissolveDir.xyz);           // b50:443
                float dissolve = (-(mad(_DissolveScheduleOffset, 2.019999980926513671875, -1.0099999904632568359375))
                               + texD
                               + (dot(IN.positionWS - objOriginD, dirWS_D) / _DissolveScanWidth - _DissolveScanSchedule)) - 1.0; // b50:443 (_450)
                float edgeClip = clamp(dissolve * _DissolveEdgeSharp, 0.0, 1.0);                 // b50:445
                float alphaD = mad(_AlphaMaskChannel, -baseTex.w + nrm.w, baseTex.w) * _BaseColor.w; // b50:436 (通道式)
                alphaD = lerp(alphaD, alphaD * IN.color.x, _Use_VerexTexColorAsOpacity);         // b50:444
                clip(mad(alphaD, edgeClip, -0.00999999977648258209228515625));                   // b50:447
                float edgeBand = clamp((-dissolve + _DissolveEmissiveWidth) * _DissolveEdgeSharp, 0.0, 1.0); // b50:496
                s.emission += _DissolveEmissiveColor.rgb * edgeBand;                             // b52:1761
            }
        #endif

            // ============================================================
            // _SUBSURFACE(b52 逐位, 本家仅 fresnel-approx 厚度路径):
            //   厚度反=lerp(1−Min, 1−Max, lerp(1, max((dot(V,N_geo)+F)/(1+F),0), 模式));
            //   量=厚度反×sat(遮罩R)×_SubsurfaceValue; 色调=HSV 三角(Hue/Sat 隐藏属性=编辑器烤入)。
            // ============================================================
        #ifdef _SUBSURFACE
            {
                float3 sssView = HgViewDirWS(IN.positionWS);
                float2 uvSss = lerp(IN.uv.zw, IN.uv.xy, _SubsurfaceMapMaskUVType);   // 枚举 UV1=0/UV0=1
                float maskR = SAMPLE_TEXTURE2D(_SubsurfaceMap, sampler_SubsurfaceMap, uvSss).x;
                float approxTerm = mad(_SubsurfaceThicknessApproxMode,
                                       max((dot(sssView, IN.normalWS) + _SubsurfaceParallaxFresnel) / (1.0 + _SubsurfaceParallaxFresnel), 0.0) - 1.0,
                                       1.0);                                          // b52:509
                float thickInv = mad(approxTerm, -(1.0 - _MinSubsurfaceThickness) + (1.0 - _MaxSubsurfaceThickness), 1.0 - _MinSubsurfaceThickness); // b52:509 (_820)
                float amount = thickInv * _SubsurfaceValue * clamp(maskR, 0.0, 1.0);  // b52:510-512 (无 LayerBlend 家)
                float3 hueTri = float3(
                    mad(_SubsurfaceSaturation, clamp(abs(mad(frac(1.0 + _SubsurfaceHue), 6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0),
                    mad(_SubsurfaceSaturation, clamp(abs(mad(frac(0.666666686534881591796875 + _SubsurfaceHue), 6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0),
                    mad(_SubsurfaceSaturation, clamp(abs(mad(frac(0.3333333432674407958984375 + _SubsurfaceHue), 6.0, -3.0)) - 1.0, 0.0, 1.0) - 1.0, 1.0)); // b52:809-811
                s.sssAmount = amount;
                s.sssTint = amount * hueTri;
            }
        #endif

            s.f0      = lerp((HG_DIELECTRIC_F0 * _Specular).xxx, s.albedo, s.metallic);            // b26:419-426
            s.diffuse = s.albedo * (1.0 - s.metallic);                                              // b26:420-422
            return s;
        }
        ENDHLSL

        // ============================================================================================
        // Pass 1: ForwardLit(源 Blend0 [_SrcBlend][_DstBlend], One OneMinusSrcAlpha; RT1(MV位)弃)
        // ============================================================================================
        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForward" }
            Blend [_SrcBlend] [_DstBlend], One OneMinusSrcAlpha
            ZWrite [_Zwrite]
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex LtrVertex
            #pragma fragment LtrForwardFragment
            #pragma shader_feature_local _TWO_BASEMAP
            #pragma shader_feature_local _EMISSIVE_MAP
            #pragma shader_feature_local _EMISSIVE_MASK
            #pragma shader_feature_local _USE_REFRACTION
            #pragma shader_feature_local _GLASS_REFRACTION_SCENECOLOR
            #pragma shader_feature_local _USE_FRESNEL
            #pragma shader_feature_local _SUBSURFACE
            #pragma shader_feature_local _USE_DISSOLVE
            #pragma shader_feature_local _MATCAP
            #pragma shader_feature_local _TRI_CHANNEL_MASK
            #pragma shader_feature_local _SIMPLE_VERTEXANIM
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_CLOTH
            #pragma shader_feature_local _USE_HIGH_REFLECTION
            #pragma shader_feature_local DITHER
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile _ _ADDITIONAL_LIGHTS
            #pragma multi_compile _ _CLUSTER_LIGHT_LOOP
            #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
            #pragma multi_compile_fragment _ _SHADOWS_SOFT _SHADOWS_SOFT_LOW _SHADOWS_SOFT_MEDIUM _SHADOWS_SOFT_HIGH
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_BOX_PROJECTION
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_ATLAS
            #pragma multi_compile_fog
            #pragma multi_compile_instancing

            float4 LtrForwardFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                LtrDitherClip(IN.positionCS, IN.positionWS);
                LtrSurface s = LtrBuildSurface(IN, isFrontFace);
                float3 N = s.normalWS;
                float3 V = HgViewDirWS(IN.positionWS);
                float NoV = max(dot(N, V), 0.0);
                float envScale, envBias;
                HgEnvBRDF(s.roughness, NoV, s.f0, envScale, envBias);
                float3 reflection = GlossyEnvironmentReflection(reflect(-V, N), s.roughness, 1.0);
            #ifdef _USE_HIGH_REFLECTION
                // b66:772-778: 平面反射 RT(像素 UV)按权重图替换基础反射(无宿主=黑→退化 base)
                {
                    float2 pixelUVH = GetNormalizedScreenSpaceUV(IN.positionCS);
                    float3 planarCol = SAMPLE_TEXTURE2D(_FakePlanarReflectionTexture, sampler_FakePlanarReflectionTexture, pixelUVH).rgb;
                    float  planarW   = SAMPLE_TEXTURE2D(_FakePlanarReflectionMaskTexture, sampler_FakePlanarReflectionMaskTexture, pixelUVH).x;
                    reflection = mad(planarCol, planarW.xxx, reflection * (1.0 - planarW));
                }
            #endif
                float3 ambientDiffuse = s.diffuse;
            #ifdef _SUBSURFACE
                ambientDiffuse = mad(s.sssTint, _SubsurfaceIndirect.xxx, s.diffuse);   // b52:1761 环境 A 项折入间接 SSS
            #endif
                float3 color = ambientDiffuse * SampleSH(N) * s.occlusion * _EnvironmentGlobalParams0.x
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
                    float3 perLight = mad(energy, NoL.xxx, s.diffuse * NoL);
                #ifdef _SUBSURFACE
                    perLight += HgSssLobe(s.sssAmount, dot(L, N), dot(V, L)) * s.sssTint;  // b52:1207-1213
                #endif
                    color += perLight * (mainLight.color * (mainLight.distanceAttenuation * mainLight.shadowAttenuation));
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
                    float3 perAddLight = mad(energy, NoL.xxx, s.diffuse * NoL);
                #ifdef _SUBSURFACE
                    perAddLight += HgSssLobe(s.sssAmount, dot(L, N), dot(V, L)) * s.sssTint;  // b52:1543-1550
                #endif
                    // 本家点光影恒开(b26 基线含 cube 影集采样) → URP additional shadowAttenuation
                    color += perAddLight * (light.color * (light.distanceAttenuation * light.shadowAttenuation));
                LIGHT_LOOP_END
            #endif
                color += s.emission;
                float alphaOut = s.alpha;

                // ============================================================
                // _GLASS_REFRACTION_SCENECOLOR(b46 逐位): 场景色折射玻璃(雾前混合)
                // ============================================================
            #ifdef _GLASS_REFRACTION_SCENECOLOR
                {
                    float NoVg = dot(s.normalWS, V);
                    float scaleG = mad(_IsShell, (_RefractThickness / max(NoVg * IN.positionCS.z, 0.5)) - _RefractThickness, _RefractThickness); // b46:402
                    float3 refr = refract(-V, s.normalWS, _IoR);                                            // b46:403-405 (TIR 掩零同义)
                    float2 offVS = float2(dot(UNITY_MATRIX_V[0].xyz, refr), dot(UNITY_MATRIX_V[1].xyz, refr)) * scaleG; // b46:406-407
                    float2 uvRT = mad(IN.uv.xy, _RefractTex_ST.xy, _RefractTex_ST.zw);                       // b46:397
                    float2 texOff = (SAMPLE_TEXTURE2D(_RefractTex, sampler_RefractTex, uvRT).xy * 2.0 - 1.0) * _RefractTexIntensity;
                    float2 off = float2(mad(_UseCustomRefractTex, texOff.x - offVS.x, offVS.x),
                                        mad(_UseCustomRefractTex, texOff.y - offVS.y, offVS.y));             // b46:408-409
                    float2 pixelUV = GetNormalizedScreenSpaceUV(IN.positionCS);
                    float2 uvFull = pixelUV + off;                                                           // b46:410-411
                    float  surfEye = LinearEyeDepth(IN.positionCS.z, _ZBufferParams);
                    float  gateQ = (LinearEyeDepth(SampleSceneDepth(pixelUV + off * 0.25), _ZBufferParams) >= surfEye) ? 1.0 : 0.0; // b46:414
                    float2 uvSel = float2(mad(gateQ, off.x * 0.25, pixelUV.x), mad(gateQ, off.y * 0.25, pixelUV.y));                // b46:415-416
                    float  gateF = (LinearEyeDepth(SampleSceneDepth(uvFull), _ZBufferParams) >= surfEye) ? 1.0 : 0.0;               // b46:417
                    uvSel = float2(mad(gateF, uvFull.x - uvSel.x, uvSel.x), mad(gateF, uvFull.y - uvSel.y, uvSel.y));               // b46:418
                    float3 sceneCol = SampleSceneColor(uvSel) * (_RefractTint.rgb * _RefractBrightness);
                    color = lerp(color, sceneCol, saturate(_RefractionContribution));
                }
            #endif

                // ============================================================
                // _USE_FRESNEL(b56 逐位): 菲涅尔叠色 + 透明度调制(雾前加色)
                // ============================================================
            #ifdef _USE_FRESNEL
                {
                    float2 uvBaseF, uvPbrF;
                    LtrComputeUVs(IN.uv, uvBaseF, uvPbrF);
                    float baseAF = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uvBaseF).w;
                    float4 nrmF  = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap, uvPbrF, _TAAUNormalBiasReverse);
                    float selF = clamp(_FresnelMapChannel, 0.0, 1.0) * baseAF;
                    selF = mad(clamp(_FresnelMapChannel - 1.0, 0.0, 1.0), nrmF.z - selF, selF);
                    selF = mad(clamp(_FresnelMapChannel - 2.0, 0.0, 1.0), nrmF.w - selF, selF);              // b56:392 端点
                #ifndef _TWO_BASEMAP
                    selF = mad(clamp(_FresnelMapChannel - 3.0, 0.0, 1.0), SAMPLE_TEXTURE2D(_MROMap, sampler_MROMap, uvPbrF).w - selF, selF);
                #endif
                    float maskF = clamp((1.0 + _FresnelMaskOffset) - selF, 0.0, 1.0);                        // b56:392 (_560)
                    float3 nF = lerp(s.normalWS, IN.normalWS, _FresnelUseMeshNormal);                        // b56:393-395
                    float3 nFlip = isFrontFace ? nF : -nF;                                                   // b56:396-397 (_582)
                    float fPos = exp2(log2(clamp(dot(V, nFlip) + _FresnelBias, 0.0, 1.0)) * _FresnelPower);  // b56:397 (_603)
                    float fVal = mad(_FresnelFlip, fPos - (1.0 - fPos), 1.0 - fPos);                         // b56:398-399 (_611)
                    float outerF = mad(_Use_VerexGAsFresnelOpacity, mad(maskF, IN.color.y, -maskF), maskF);  // b56:1622 (_3212)
                    float weightF = fVal * _FresnelColor.w;                                                  // b56:1621 (_3190)
                    color += outerF * lerp(s.albedo, _FresnelColor.rgb, weightF);                            // b56:1686-1688
                    alphaOut *= mad(fVal, _FresnelAffectOpacity, 1.0 - _FresnelAffectOpacity);               // b56:400 (_629)
                }
            #endif

                color = MixFog(color, IN.fogFactor);

                // ============================================================
                // _USE_REFRACTION(b40 逐位): 低阶屏幕空间假折射(雾后 lerp)
                // ============================================================
            #ifdef _USE_REFRACTION
                {
                    float3 viewNR = mul((float3x3)UNITY_MATRIX_V, s.normalWS);
                    float2 pixelUVR = GetNormalizedScreenSpaceUV(IN.positionCS);
                    float2 uvR = float2(mad(viewNR.x * _IoRLowTier, alphaOut, pixelUVR.x),
                                        mad(viewNR.y * _IoRLowTier, alphaOut, pixelUVR.y));                  // b40:368
                    float3 refrTex = SAMPLE_TEXTURE2D(_RefractTex, sampler_RefractTex, uvR).rgb;
                    color = float3(mad(alphaOut, color.x - refrTex.x, refrTex.x),
                                   mad(alphaOut, color.y - refrTex.y, refrTex.y),
                                   mad(alphaOut, color.z - refrTex.z, refrTex.z));                            // b40:1646-1648
                }
            #endif
                return float4(color, alphaOut);
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2: ShadowCaster(kw: TWO_BASEMAP/SVA/SVA_CLOTH; 空片元, 无 clip — 本家无 _ALPHATEST_ON)
        // ============================================================================================
        Pass
        {
            Name "ShadowCaster"
            Tags { "LightMode" = "ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex LtrShadowVertex
            #pragma fragment LtrShadowFragment
            #pragma shader_feature_local _TWO_BASEMAP
            #pragma shader_feature_local _SIMPLE_VERTEXANIM
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_CLOTH
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW
            #pragma multi_compile_instancing

            float3 _LightDirection;
            float3 _LightPosition;

            Varyings LtrShadowVertex(Attributes IN)
            {
                Varyings OUT = LtrVertex(IN);
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

            half4 LtrShadowFragment(Varyings IN) : SV_Target
            {
                return 0;
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 3: ForwardReflection(b128/b129 逐位): 向平面反射解算器输出(八面体法线 xy, 粗糙度)。
        //   LightMode 保留源名 — 仅当宿主平面反射 feature 请求该 LightMode 时绘制, URP 默认零开销。
        // ============================================================================================
        Pass
        {
            Name "ForwardReflection"
            Tags { "LightMode" = "ForwardReflection" }
            ColorMask RGB
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex LtrVertex
            #pragma fragment LtrReflectionFragment
            #pragma shader_feature_local _TWO_BASEMAP
            #pragma shader_feature_local _SIMPLE_VERTEXANIM
            #pragma shader_feature_local _SIMPLE_VERTEXANIM_CLOTH
            #pragma multi_compile_instancing

            float4 LtrReflectionFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                float2 uvBase, uvPbr;
                LtrComputeUVs(IN.uv, uvBase, uvPbr);
                float4 nrm = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap, uvPbr, _TAAUNormalBiasReverse); // b129:140
            #ifdef _TWO_BASEMAP
                float nxRaw = mad(nrm.x, 2.0, -1.0);
                float nyRaw = mad(nrm.y, 2.0, -1.0);
                float nxDec = (abs(nxRaw) < HG_NORMAL_DEADZONE) ? 0.0 : nxRaw;
                float nyDec = (abs(nyRaw) < HG_NORMAL_DEADZONE) ? 0.0 : nyRaw;
                float roughT = nrm.z;
            #else
                float nxDec = mad(nrm.x * nrm.w, 2.0, -1.0);                                                  // b129:145
                float nyDec = mad(nrm.y,         2.0, -1.0);                                                  // b129:148
                float roughT = SAMPLE_TEXTURE2D(_MROMap, sampler_MROMap, uvPbr).y;
            #endif
                float nx = nxDec * _NormalScale;
                float ny = nyDec * _NormalScale;
                float frontSign = isFrontFace ? 1.0 : ((_TwoSidedNormal > 0.0) ? -1.0 : 1.0);
                float nz = sqrt(max(1.0 - dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 0.0)) * frontSign; // b129:196
                float tSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
                float3 bitan = tSign * cross(IN.normalWS, IN.tangentWS.xyz);
                float3 nWS = IN.normalWS * nz + IN.tangentWS.xyz * nx + bitan * ny;                            // b129:203-205
                nWS *= rsqrt(dot(nWS, nWS));
                // 八面体编码(b129:216-...): oct = n.xy/L1, z<0 wrap, →[0,1]
                float l1 = dot(1.0.xxx, abs(nWS));
                float ox = nWS.x / l1;
                float oz = nWS.z / l1;
                bool wrap = (0.0 >= nWS.y);
                float ex = wrap ? (((ox >= 0.0) ? 1.0 : -1.0) * (1.0 - abs(oz))) : ox;   // b129 SV_Target.x
                float ey = wrap ? (((oz >= 0.0) ? 1.0 : -1.0) * (1.0 - abs(ox))) : oz;   // b129 SV_Target.y
                return float4(mad(ex, 0.5, 0.5), mad(ey, 0.5, 0.5),
                              mad(roughT, -_RoughnessMin + _RoughnessMax, _RoughnessMin), 0.0);               // b129 SV_Target
            }
            ENDHLSL
        }
    }
}
