// ============================================================================================
// HGRP/LitForward — EndField litforward.shader 的 URP 1:1 单文件重构。
// 真值 = AllShader_1.3.3 出货变体反编译:
//   ForwardLit: b10/b11(基, 前向光照全内核) b13(_RECEIVE_LOCAL_LIGHT_SHADOW) b15/b17(_EMISSIVE_MASK,
//     _CUSTOM_IBL) b19/b21(_LAYERBLEND_MASK, _THIN_FILM) b23(_PLANAR_REFLECTION)
//   DepthOnly: b26/27(+DITHER); ShadowCaster: b32/33(+DITHER)。
// 出货事实: _PLANAR_REFLECTION 在全部出货片元中编译为 no-op(b13↔b23 无功能差)——只声明不引用。
// 引擎面替换(逐处注): IV-clipmap SH(T9-15)→SampleSH; probe 分箱→GlossyEnvironmentReflection;
//   CSM/ASM/阴影ramp/云影→URP 主光阴影; 点光 zbin→URP additional(局部光影按 _RECEIVE_LOCAL_LIGHT_SHADOW 门,
//   源默认关); DFG LUT(T8 双查)→解析多项式(同源); 大气/指数/froxel 雾→MixFog; MV RT1/TAA→弃;
//   SceneEffect per-draw→中性; 自动曝光=1。太阳盘 MRP 方向修正(b11:928-936, 引擎太阳参数无绑定)→主光方向直接。
// ============================================================================================
Shader "HGRP/LitForward"
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

        // ---- 自发光(骑通道, _EMISSIVE_MASK) ----
        _EnableEmissiveMap ("自发光/自发光", Float) = 0
        [Enum(EmissiveMap, 0, BaseColor A, 1, NormalMap B, 2, NormalMap A, 3, MRO A, 4, NOMAP, 5)] _EmissiveMaskChannel ("自发光通道", Float) = 0
        [ToggleUI] _AlbedoAffectEmissive ("自发光不受固有色影响", Float) = 1
        [ToggleUI] _IgnorePostExposure ("不受自动曝光影响", Float) = 1
        [HDR] _EmissiveColor ("自发光颜色", Color) = (1, 1, 1, 1)
        _EmissiveMapTilling ("Emmisive Tilling", Range(0.01, 20)) = 1
        [Toggle(_EMISSIVE_MASK)] _KwEmissiveMask ("KW _EMISSIVE_MASK(=通道 1-4)", Float) = 0
        [Toggle(_EMISSIVE_ANIM_SWEEP)] _EnableEmissiveAnimSweep ("自发光/自发光扫光(骨架属性, 本家无出货变体)", Float) = 0
        _EmissiveSweepSpeed ("扫光速度", Range(0.01, 20)) = 3
        _EmissiveSweepInterval ("扫光间隔时间", Range(0.01, 20)) = 3
        _EmissiveSweepWidth ("扫光宽度", Range(0.01, 10)) = 0.8
        _EmissiveSweepFalloff ("扫光边缘硬度", Range(1, 10)) = 1
        [ToggleUI] _EmissiveSweepRandom ("扫光随机", Float) = 0
        _EmissiveSweepAlbedoScale ("受固有色影响加强", Range(0, 5)) = 0

        // ---- Layer Blend(MASK 模式) ----
        _LayerBlend ("混合/Layer Blend", Float) = 1
        [Toggle(_LAYERBLEND_MASK)] _KwLayerBlendMask ("KW _LAYERBLEND_MASK", Float) = 0
        [Enum(MaskMapR, 0, NROA, 1)] _LayerBlendMaskType ("混合区域Mask来源", Float) = 0
        _TopBlendSmoothness ("顶部混合过渡区域调整", Range(0.01, 1)) = 0.5
        _TopBlendThreshold ("顶部混合阈值", Range(-1, 1)) = 0.5
        _TopBlendWithBumpMap ("顶部混合使用基底贴图法线", Range(0, 1)) = 0
        [Enum(UV1, 0, UV0, 1)] _LayerBlendMaskUVType ("混合区域MaskUV通道", Float) = 1
        _LayerBlendMaskMap ("混合区域MaskMap(R)", 2D) = "white" {}
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
        [ToggleUI] _LayerBlendHeight ("是否计算高度混合", Float) = 0
        _BaseHeightMap ("基底层高度", 2D) = "grey" {}
        _LayerBlendHeightTransition ("高度混合过渡效果调整", Range(0.01, 1)) = 1
        [Toggle(_LAYERBLEND_NOISEBLEND)] _LayerBlendNoise ("Layer Blend Noise(骨架属性, 本家无出货变体)", Float) = 0
        _LayerBlendNoiseLevel ("Noise 程度", Range(0, 1)) = 0
        _LayerBlendNoiseThreshold ("Noise 阈值", Range(0, 1)) = 1
        _LayerBlendNoiseNormalStrength ("Noise 法线强度", Range(0, 5)) = 1
        _LayerBlendNoiseNormalSmoothness ("Noise 顺滑度", Range(0, 5)) = 1
        _LayerBlendVerticalFlowThreshold ("墙壁水流阈值", Range(0, 1)) = 0
        [Enum(NROA, 0, Close, 1)] _LayerAOType ("AO来源", Float) = 0

        // ---- 自定义反射球(_CUSTOM_IBL) ----
        [Toggle(_CUSTOM_IBL)] _EnabledCustomIBL ("自定义反射球", Float) = 0
        _CustomIBL ("自定义反射球", Cube) = "black" {}
        _CustomIBLIntensity ("反射强度", Range(0, 3)) = 1

        // ---- 薄膜干涉(_THIN_FILM) ----
        [Toggle(_THIN_FILM)] _EnableThinFilmInterference ("薄膜干涉效果", Float) = 0
        _ThinFilmIntensity ("薄膜干涉整体强度", Range(0, 2)) = 1
        [HDR] _ThinFilmAffectTintColor ("薄膜干涉 Color Tint", Color) = (1, 1, 1, 1)
        _ThinFilmLUT ("薄膜干涉 Color LUT", 2D) = "black" {}
        _ThinFilmCustomNormal ("薄膜干涉使用自定义法线", Range(0, 1)) = 0
        _ThinFilmNormal ("薄膜干涉法线", 2D) = "bump" {}
        _ThinFilmNormalScale ("薄膜干涉法线强度", Range(0, 2)) = 1
        [Enum(None, 0, 45Degree, 1, 45DegreeNegetive, 2)] _ThinFilmUVRotation ("薄膜干涉法线旋转", Float) = 0
        [ToggleUI] _ThinFilmAffectBaseColor ("薄膜干涉影响BaseColor", Float) = 0
        [ToggleUI] _ThinFilmAffectEmissive ("薄膜干涉影响Emissive", Float) = 1
        [ToggleUI] _ThinFilmMask ("薄膜干涉Mask[使用LayerBlendMask]", Float) = 0

        // ---- 平面反射(出货 no-op, 声明保真) ----
        [Toggle(_PLANAR_REFLECTION)] _EnabledPlanarReflection ("平面反射(出货 no-op)", Float) = 0
        [HDR] _PlanarReflectionTint ("平面反射颜色", Color) = (1, 1, 1, 1)

        // ---- 局部光阴影 ----
        [Toggle(_RECEIVE_LOCAL_LIGHT_SHADOW)] _ReceiveLocalLightShadow ("接收局部光投影", Float) = 0

        [Toggle(DITHER)] _KwDither ("KW DITHER(深度/阴影 LOD 抖动淡出)", Float) = 0
        [ToggleUI] _Use_VerexTexColorAsOpacity ("用顶点色控制Opacity", Float) = 0

        _AdvancedOptions ("Advanced Options", Float) = 0
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _TAAUNormalBiasReverse ("TAAU Normal偏移补偿", Float) = 0
        [ToggleUI] _ReceiveDecals ("Receive Decals", Float) = 1
        [ToggleUI] _UseCustomRenderQueue ("Custom Render Queue", Float) = 0
        _CustomRenderQueue ("Render Queue", Range(-1, 5000)) = -1
        [ToggleUI] _DisablePreDepth ("关闭PreDepth", Float) = 0
        [Enum(Off, 0, On, 1)] _ZWrite ("ZWrite", Float) = 1
        [HideInInspector] _ZTestGBuffer ("_ZTestGBuffer", Float) = 4
        [HideInInspector] _PreDepthStencilRef ("PreDepthStencilRef", Float) = 5
        [HideInInspector] _DitherTransparentOffset ("Dither Transparent Offset", Range(0, 1)) = 0.1
        [HideInInspector] _CutOffPosY ("_CutOffPosY", Float) = 0
        [HideInInspector] _UseCutOff ("_UseCutOff", Float) = 0
        [HideInInspector] _CutOffDirection ("_CutOffDirection", Vector) = (0, 1, 0, 0)
        [HideInInspector] _SurfaceType ("Surface Type", Float) = 0
        [HideInInspector] _EnableAlphaBlend ("Alpha Blend", Float) = 0
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
        [HideInInspector] _RenderTransparentAfterDistortion ("Transparent After Distortion", Float) = 0
        [HideInInspector] _RenderTransparentAfterDOF ("Transparent After DOF", Float) = 0
        [HideInInspector] _HlodBakeMaxEmissiveIntensity ("_HlodBakeMaxEmissiveIntensity", Float) = 0
        // HG 引擎全局 dial 的材质级落位(默认中性)
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
            float _SurfaceType;
            // 自发光(mask)
            float4 _EmissiveColor;
            float _EnableEmissiveMap;   // MASK 路径乘数真身(b209/b17 双证; HG 编辑器启用时写 1)
            float _EmissiveMaskChannel;
            float _AlbedoAffectEmissive;
            float _IgnorePostExposure;
            float _EmissiveMapTilling;
            // LayerBlend(MASK)
            float4 _Layer1TintColor;
            float _LayerBlendMaskType;
            float _LayerBlendMaskUVType;
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
            float _LayerAOType;
            float _TopBlendSmoothness;
            float _TopBlendThreshold;
            float _TopBlendWithBumpMap;
            // CustomIBL / ThinFilm
            float _CustomIBLIntensity;
            float4 _ThinFilmAffectTintColor;
            float4 _ThinFilmNormal_ST;
            float4 _ThinFilmLUT_ST;
            float _ThinFilmIntensity;
            float _ThinFilmCustomNormal;
            float _ThinFilmNormalScale;
            float _ThinFilmUVRotation;
            float _ThinFilmAffectBaseColor;
            float _ThinFilmAffectEmissive;
            float _ThinFilmMask;
            float4 _PlanarReflectionTint;
            // Dither/CutOff
            float _DitherTransparentOffset;
            float _CutOffPosY;
            float _UseCutOff;
            float4 _CutOffDirection;
            float4 _EnvironmentGlobalParams0;
        CBUFFER_END

        TEXTURE2D(_BaseColorMap);     SAMPLER(sampler_BaseColorMap);
        TEXTURE2D(_NormalMap);        SAMPLER(sampler_NormalMap);
        TEXTURE2D(_MROMap);           SAMPLER(sampler_MROMap);
        TEXTURE2D(_LayerBlendMaskMap);SAMPLER(sampler_LayerBlendMaskMap);
        TEXTURE2D(_Layer1BaseMap);    SAMPLER(sampler_Layer1BaseMap);
        TEXTURE2D(_Layer1BumpMap);    SAMPLER(sampler_Layer1BumpMap);
        TEXTURE2D(_BaseHeightMap);    SAMPLER(sampler_BaseHeightMap);
        TEXTURECUBE(_CustomIBL);      SAMPLER(sampler_CustomIBL);
        TEXTURE2D(_ThinFilmLUT);      SAMPLER(sampler_ThinFilmLUT);
        TEXTURE2D(_ThinFilmNormal);   SAMPLER(sampler_ThinFilmNormal);

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
            float2 uv2        : TEXCOORD2;
            UNITY_VERTEX_INPUT_INSTANCE_ID
        };

        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float3 positionWS : TEXCOORD0;
            float4 uv         : TEXCOORD1;   // .xy=uv0 .zw=uv1 (raw)
            float3 normalWS   : TEXCOORD2;
            float4 tangentWS  : TEXCOORD3;
            float4 color      : TEXCOORD4;
            float  fogFactor  : TEXCOORD5;
            float2 uv2        : TEXCOORD6;
            UNITY_VERTEX_INPUT_INSTANCE_ID
            UNITY_VERTEX_OUTPUT_STEREO
        };

        Varyings LfwVertex(Attributes IN)
        {
            Varyings OUT = (Varyings)0;
            UNITY_SETUP_INSTANCE_ID(IN);
            UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
            UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);
            OUT.positionWS = TransformObjectToWorld(IN.positionOS);
            OUT.positionCS = TransformWorldToHClip(OUT.positionWS);
            OUT.normalWS   = TransformObjectToWorldNormal(IN.normalOS);
            OUT.tangentWS  = float4(TransformObjectToWorldDir(IN.tangentOS.xyz), IN.tangentOS.w * GetOddNegativeScale());
            OUT.uv         = float4(IN.uv0, IN.uv1);
            OUT.color      = IN.color;
            OUT.fogFactor  = ComputeFogFactor(OUT.positionCS.z);
            OUT.uv2        = IN.uv2;
            return OUT;
        }

        void LfwComputeUVs(float4 uv, out float2 uvBase, out float2 uvPbr)
        {
            float2 duv = uv.zw - uv.xy;
            uvBase = mad(mad(_BaseUVSet.xx,       duv, uv.xy), _BaseColorMap_ST.xy, _BaseColorMap_ST.zw);
            uvPbr  = mad(mad(_BasePbrMapUVSet.xx, duv, uv.xy), _NormalMap_ST.xy,    _NormalMap_ST.zw);
        }

        struct LfwSurface
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
            float  layerBlend;   // _LAYERBLEND_MASK 的混合因子(薄膜 Mask 消费, b21:362)
        };

        // ---- 基面 + LayerBlend(MASK) + 自发光(MASK) + 薄膜 (b11/b365/b17/b21 逐位) ----
        LfwSurface LfwBuildSurface(Varyings IN, bool isFrontFace)
        {
            LfwSurface s = (LfwSurface)0;
            float2 uvBase, uvPbr;
            LfwComputeUVs(IN.uv, uvBase, uvPbr);

            float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uvBase);
            float4 nrm     = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap, uvPbr, _TAAUNormalBiasReverse);

        #ifdef _TWO_BASEMAP
            float metallicT  = baseTex.w;                                        // b11:282
            float roughT     = nrm.z;                                            // b11:281
            float occT       = nrm.w;                                            // b11:1240
            float nxRaw = mad(nrm.x, 2.0, -1.0);                                 // b11:268
            float nyRaw = mad(nrm.y, 2.0, -1.0);
            float nxDec = (abs(nxRaw) < HG_NORMAL_DEADZONE) ? 0.0 : nxRaw;       // b11:270
            float nyDec = (abs(nyRaw) < HG_NORMAL_DEADZONE) ? 0.0 : nyRaw;
        #else
            float4 mro = SAMPLE_TEXTURE2D(_MROMap, sampler_MROMap, uvPbr);
            float metallicT  = mro.x;
            float roughT     = mro.y;
            float occT       = mro.z;
            float nxDec = mad(nrm.x * nrm.w, 2.0, -1.0);                         // DXT5nm
            float nyDec = mad(nrm.y,         2.0, -1.0);
        #endif
            float nx = nxDec * _NormalScale;
            float ny = nyDec * _NormalScale;

            float3 albedoRaw = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale); // b11:274-279
            float3 baseCol   = lerp(albedoRaw, _BaseColor.rgb, _BaseColorTintCover);

            float roughness = lerp(_RoughnessMin, _RoughnessMax, roughT);        // b11:281
            float metallic  = lerp(metallicT, _Metallic, saturate(_BaseTextureMapCount - 1.0)); // b11:282
            float occlusion = lerp(1.0, occT, _OcclusionStrength);               // b11:1240
            float frontSign = isFrontFace ? 1.0 : ((_TwoSidedNormal > 0.0) ? -1.0 : 1.0);
            float nz = sqrt(max(1.0 - dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 0.0)) * frontSign; // b11:283(前向形, 无 1e-16)

            float blend = 0.0;
            // ============================================================
            // _LAYERBLEND_MASK(lit b357/b365 同构, litforward b21:311-319 交叉证):
            //   wL = _LayerBlendMaskType NROA→nrm.a, 否则遮罩图R(UV 枚举 UV1=0/UV0=1);
            //   高度混合归一化 + albedo 饱和度/Tint/Brighter + PBR 链 + RNM 法线。
            // ============================================================
        #ifdef _LAYERBLEND_MASK
            {
                float2 uvLB;
                if (_LayerBlendUVType == 1.0)      uvLB = IN.positionWS.xz;
                else if (_LayerBlendUVType == 2.0) uvLB = IN.uv2;
                else                               uvLB = IN.uv.xy;
                uvLB *= _Layer1Tilling;                                                              // b21:311

                float4 layerBase = SAMPLE_TEXTURE2D(_Layer1BaseMap, sampler_Layer1BaseMap, uvLB);    // b21:312
                float4 layerNRO  = SAMPLE_TEXTURE2D(_Layer1BumpMap, sampler_Layer1BumpMap, uvLB);    // b21:315
                float  hBase     = SAMPLE_TEXTURE2D(_BaseHeightMap, sampler_BaseHeightMap, uvLB).x;
                float  hLayer    = layerBase.w;

                float2 uvMaskLB = (_LayerBlendMaskUVType == 1.0) ? IN.uv.xy : IN.uv.zw;              // 枚举 UV1=0/UV0=1
                float wL = clamp((_LayerBlendMaskType != 0.0) ? nrm.w
                          : SAMPLE_TEXTURE2D(_LayerBlendMaskMap, sampler_LayerBlendMaskMap, uvMaskLB).x, 0.0, 1.0); // b21:318 (_447)
                float wB = 1.0 - wL;
                float maxH = max(hLayer * wL, hBase * wB);                                           // b357:209
                float termL = wL * (max(-maxH + mad(wL, hLayer, _LayerBlendHeightTransition), 0.0) + 9.9999999747524270787835121154785e-07);
                float termB = wB * (max(-maxH + mad(wB, hBase, _LayerBlendHeightTransition), 0.0) + 9.9999999747524270787835121154785e-07);
                blend = (_LayerBlendHeight != 0.0)
                      ? termL / max(termL + termB, 1.1754943508222875079687365372222e-38)
                      : wL;                                                                          // b357:211

                float lumaL = dot(layerBase.rgb, HG_LUMA);
                float satW = clamp(1.0 + _Layer1Saturation, 0.0, 1.0);
                float3 layerCol = float3(mad(satW, -lumaL + layerBase.x, lumaL),
                                         mad(satW, -lumaL + layerBase.y, lumaL),
                                         mad(satW, -lumaL + layerBase.z, lumaL))
                                * _Layer1TintColor.rgb * _Layer1ColorBrighterScale;                  // b357:265-273
                baseCol = lerp(baseCol, layerCol, blend);

                float layerMetal = (_LayerMetallicType != 0.0) ? layerBase.w : _Layer1Metallic;      // b21:337
                metallic  = lerp(metallic, layerMetal, blend);
                roughness = lerp(roughness, layerNRO.z, blend);                                      // b21:339
                float layerOcc = (_LayerAOType != 0.0) ? 1.0 : lerp(1.0, layerNRO.w, _Layer1AOStrength);
                occlusion = lerp(occlusion, layerOcc, blend);

                // 层法线 RNM + _Layer1BaseNormalIntensity 内插(b21:335-343 == b357:236-254)
                float lnxRaw = mad(layerNRO.x, 2.0, -1.0);
                float lnyRaw = mad(layerNRO.y, 2.0, -1.0);
                float lnxDec = (abs(lnxRaw) < HG_NORMAL_DEADZONE) ? 0.0 : lnxRaw;
                float lnyDec = (abs(lnyRaw) < HG_NORMAL_DEADZONE) ? 0.0 : lnyRaw;
                float lnx = lnxDec * _Layer1BumpScale;
                float lny = lnyDec * _Layer1BumpScale;
                float lnz = max(sqrt(1.0 - min(dot(float2(lnxDec, lnyDec), float2(lnxDec, lnyDec)), 1.0)), HG_EPS_NORMAL_Z);
                float bnz1 = sqrt(max(1.0 - dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 0.0)) + 1.0;
                float rnmL = dot(float3(nx, ny, bnz1), float3(-lnx, -lny, lnz));                     // b21:335 (_510 同构)
                float xI = mad(_Layer1BaseNormalIntensity, -lnx + (lnx + (rnmL * nx) / bnz1), lnx);  // b21:335 (_544)
                float yI = mad(_Layer1BaseNormalIntensity, -lny + (lny + (rnmL * ny) / bnz1), lny);
                float zI = mad(_Layer1BaseNormalIntensity, -lnz + (rnmL - lnz), lnz);                // b21:340 内层
                float bnzS = sqrt(max(1.0 - dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 0.0));
                nx = mad(blend, -nx + xI, nx);
                ny = mad(blend, -ny + yI, ny);
                nz = frontSign * mad(blend, -bnzS + zI, bnzS);                                        // b21:340 (_609)
            }
        #endif

            float tangentSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
            float3 bitangent  = tangentSign * cross(IN.normalWS, IN.tangentWS.xyz);
            float3 normalWS   = normalize(IN.normalWS * nz + IN.tangentWS.xyz * nx + bitangent * ny); // b11:284-290

            s.albedo    = baseCol;
            s.normalWS  = normalWS;
            s.metallic  = metallic;
            s.roughness = roughness;
            s.occlusion = occlusion;
            s.layerBlend = blend;
            s.alpha     = mad(_Use_VerexTexColorAsOpacity, IN.color.x - 1.0, 1.0);                    // b11:280 (_348)
            s.emission  = float3(0.0, 0.0, 0.0);

            // ============================================================
            // _EMISSIVE_MASK(lit b315 == liteffect b209 == 本家 b17 三证):
            //   sel 链 1=BaseA 2=NormalB 3=NormalA (4=MROA, 3-map); maskVal=saturate((lerp(1,sel,sat(ch))−0.05)/0.9);
            //   emission = _EmissiveColor.rgb × maskVal × saturate(ch) × _EnableEmissiveMap × albedoAffect。
            // ============================================================
        #ifdef _EMISSIVE_MASK
            {
                float3 albedoAffect = lerp(s.albedo, float3(1.0, 1.0, 1.0), _AlbedoAffectEmissive);
                float mroA = 0.0;
            #ifndef _TWO_BASEMAP
                mroA = SAMPLE_TEXTURE2D(_MROMap, sampler_MROMap, uvPbr).w;
            #endif
                float sel = mad(clamp(_EmissiveMaskChannel - 1.0, 0.0, 1.0), -baseTex.w + nrm.z, baseTex.w); // b315:165
                sel = mad(clamp(_EmissiveMaskChannel - 2.0, 0.0, 1.0), nrm.w - sel, sel);                    // b315:167
            #ifndef _TWO_BASEMAP
                sel = mad(clamp(_EmissiveMaskChannel - 3.0, 0.0, 1.0), mroA - sel, sel);
            #endif
                float chGate  = clamp(_EmissiveMaskChannel, 0.0, 1.0);
                float maskVal = clamp(mad(mad(chGate, sel - 1.0, 1.0), 1.111111164093017578125, -0.055555559694766998291015625), 0.0, 1.0); // b315:167
                s.emission += (_EmissiveColor.rgb * ((maskVal * chGate) * _EnableEmissiveMap)) * albedoAffect; // b209:185/b17:1132
            }
        #endif

            // ============================================================
            // _THIN_FILM(b21:348-379,1266-1268 逐位): 干涉 LUT 虹彩。
            //   旋转: rotC=mad(rot−1,−√2,√2/2); r644=uv0.x·(√2/2)−uv0.y·rotC;
            //     uvTF.x=mad(rot, −uv0.x+r644, uv0.x)×ST; uvTF.y=mad(rot, rotC·r644+uv0.y·(−0.29289323), uv0.y)×ST;
            //   TF 法线 ×_ThinFilmNormalScale → TBN → lerp(着色N, tfN, _ThinFilmCustomNormal);
            //   LUT@(saturate(dot(V,N_lut))×LUT_ST.x+.z, 0.5×LUT_ST.y+.w);
            //   film = LUT.rgb×LUT.w×Intensity×lerp(1, 1−layerBlend, _ThinFilmMask);
            //   emission += film×_ThinFilmAffectEmissive;
            //   albedo = lerp(albedo, film×TintColor, Intensity×_ThinFilmAffectBaseColor)(字面 Intensity² 保留)。
            // ============================================================
        #ifdef _THIN_FILM
            {
                float3 Vt;
                {
                    float3 raw = (unity_OrthoParams.w == 0.0)
                               ? (_WorldSpaceCameraPos - IN.positionWS)
                               : float3(-UNITY_MATRIX_V[2].x, -UNITY_MATRIX_V[2].y, -UNITY_MATRIX_V[2].z);
                    Vt = raw * rsqrt(max(dot(raw, raw), HG_EPS_VIEWLEN));
                }
                float rotC = mad(_ThinFilmUVRotation - 1.0, -1.41421353816986083984375, 0.707106769084930419921875); // b21:348
                float r644 = mad(-IN.uv.y, rotC, IN.uv.x * 0.707106769084930419921875);                              // b21:349
                float2 uvTF = float2(
                    mad(mad(_ThinFilmUVRotation, -IN.uv.x + r644, IN.uv.x), _ThinFilmNormal_ST.x, _ThinFilmNormal_ST.z),
                    mad(mad(_ThinFilmUVRotation, (rotC * r644) + (IN.uv.y * (-0.292893230915069580078125)), IN.uv.y), _ThinFilmNormal_ST.y, _ThinFilmNormal_ST.w)); // b21:350
                float4 tfTex = SAMPLE_TEXTURE2D(_ThinFilmNormal, sampler_ThinFilmNormal, uvTF);
                float tfx = mad(tfTex.x, 2.0, -1.0) * _ThinFilmNormalScale;                                          // b21:354
                float tfy = mad(tfTex.y, 2.0, -1.0) * _ThinFilmNormalScale;                                          // b21:355
                float tfz = sqrt(max(1.0 - dot(float2(mad(tfTex.x, 2.0, -1.0), mad(tfTex.y, 2.0, -1.0)),
                                               float2(mad(tfTex.x, 2.0, -1.0), mad(tfTex.y, 2.0, -1.0))), 0.0));
                float3 tfN = normalize(IN.normalWS * tfz + IN.tangentWS.xyz * tfx + bitangent * tfy);
                float3 nLut = float3(mad(_ThinFilmCustomNormal, tfN.x - s.normalWS.x, s.normalWS.x),
                                     mad(_ThinFilmCustomNormal, tfN.y - s.normalWS.y, s.normalWS.y),
                                     mad(_ThinFilmCustomNormal, tfN.z - s.normalWS.z, s.normalWS.z));                // b21:360 内联
                float2 uvLut = float2(mad(clamp(dot(Vt, nLut), 0.0, 1.0), _ThinFilmLUT_ST.x, _ThinFilmLUT_ST.z),
                                      mad(0.5, _ThinFilmLUT_ST.y, _ThinFilmLUT_ST.w));                               // b21:360
                float4 lut = SAMPLE_TEXTURE2D(_ThinFilmLUT, sampler_ThinFilmLUT, uvLut);
                float maskTF = mad(1.0 - s.layerBlend, _ThinFilmMask, 1.0 - _ThinFilmMask);                          // b21:362 (_775)
                float3 film = (lut.w * lut.rgb) * (_ThinFilmIntensity * maskTF);                                     // b21:361,363-365
                s.emission += film * _ThinFilmAffectEmissive;                                                        // b21:1266-1268
                float affB = _ThinFilmIntensity * _ThinFilmAffectBaseColor;                                          // b21:378 (_860)
                s.albedo = float3(mad(affB, mad(film.x, _ThinFilmAffectTintColor.x, -s.albedo.x), s.albedo.x),       // b21:379 (_873)
                                  mad(affB, mad(film.y, _ThinFilmAffectTintColor.y, -s.albedo.y), s.albedo.y),
                                  mad(affB, mad(film.z, _ThinFilmAffectTintColor.z, -s.albedo.z), s.albedo.z));
            }
        #endif

            s.f0      = lerp((HG_DIELECTRIC_F0 * _Specular).xxx, s.albedo, s.metallic);              // b11:298-305
            s.diffuse = s.albedo * (1.0 - s.metallic);
            return s;
        }

        // ---- b11 光照内核(逐位) ----
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

        void LfwDitherClip(float4 positionCS, float3 positionWS)
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
        // Pass 1: ForwardLit(源 LIGHTMODE=ForwardOnly → URP UniversalForward)
        // ============================================================================================
        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForward" }
            ZWrite [_ZWrite]
            ZTest [_ZTestGBuffer]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex LfwVertex
            #pragma fragment LfwForwardFragment
            #pragma shader_feature_local _TWO_BASEMAP
            #pragma shader_feature_local _RECEIVE_LOCAL_LIGHT_SHADOW
            #pragma shader_feature_local _EMISSIVE_MASK
            #pragma shader_feature_local _CUSTOM_IBL
            #pragma shader_feature_local _LAYERBLEND_MASK
            #pragma shader_feature_local _THIN_FILM
            #pragma shader_feature_local _PLANAR_REFLECTION   // 出货 no-op(b13↔b23), 声明保真
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

            float4 LfwForwardFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                LfwSurface s = LfwBuildSurface(IN, isFrontFace);
                float3 N = s.normalWS;
                float3 V = HgViewDirWS(IN.positionWS);
                float NoV = max(dot(N, V), 0.0);
                float envScale, envBias;
                HgEnvBRDF(s.roughness, NoV, s.f0, envScale, envBias);
                float3 reflectVec = reflect(-V, N);
            #ifdef _CUSTOM_IBL
                // b17:1128: 自定义 cube 替换 probe 反射, HG mip=mipCount−2+1.2·log2(max(rough,0.001));
                // GFGP1.x(引擎 mip 数全局)→cube 自身 mip 数(GetDimensions)。term B ×_CustomIBLIntensity (b17:1132-1134)。
                float3 reflection;
                {
                    uint w, h, mipCount;
                    _CustomIBL.GetDimensions(0, w, h, mipCount);
                    float hgMip = ((-1.0) + float(mipCount)) + (-(mad(-log2(max(s.roughness, 0.001000000047497451305389404296875)), 1.2000000476837158203125, 1.0)));
                    reflection = SAMPLE_TEXTURECUBE_LOD(_CustomIBL, sampler_CustomIBL, reflectVec, hgMip).rgb * _CustomIBLIntensity;
                }
            #else
                float3 reflection = GlossyEnvironmentReflection(reflectVec, s.roughness, 1.0);
            #endif
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
                    color += mad(energy, NoL.xxx, s.diffuse * NoL) * (mainLight.color * (mainLight.distanceAttenuation * mainLight.shadowAttenuation));
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
                #ifdef _RECEIVE_LOCAL_LIGHT_SHADOW
                    float localShadow = light.shadowAttenuation;   // HG 局部光图集 → URP additional shadows (b13)
                #else
                    float localShadow = 1.0;                       // 源默认关(材质切, litforward b11 基线)
                #endif
                    color += mad(energy, NoL.xxx, s.diffuse * NoL) * (light.color * (light.distanceAttenuation * localShadow));
                LIGHT_LOOP_END
            #endif
                color += s.emission;
                color = MixFog(color, IN.fogFactor);
                return float4(color, s.alpha);   // b11:1323 (SV_Target.w=_348 无条件)
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2: DepthOnly(源 Stencil [_PreDepthStencilRef]; kw: DITHER)
        // ============================================================================================
        Pass
        {
            Name "DepthOnly"
            Tags { "LightMode" = "DepthOnly" }
            ZWrite On
            ZTest LEqual
            ColorMask R
            Cull [_CullMode]
            Stencil { Ref [_PreDepthStencilRef] Comp Always Pass Replace }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex LfwVertex
            #pragma fragment LfwDepthFragment
            #pragma shader_feature_local DITHER
            #pragma multi_compile_instancing

            half4 LfwDepthFragment(Varyings IN) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                LfwDitherClip(IN.positionCS, IN.positionWS);
                return 0;
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 3: ShadowCaster(kw: DITHER)
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
            #pragma vertex LfwShadowVertex
            #pragma fragment LfwShadowFragment
            #pragma shader_feature_local DITHER
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW
            #pragma multi_compile_instancing

            float3 _LightDirection;
            float3 _LightPosition;

            Varyings LfwShadowVertex(Attributes IN)
            {
                Varyings OUT = LfwVertex(IN);
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

            half4 LfwShadowFragment(Varyings IN) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                LfwDitherClip(IN.positionCS, IN.positionWS);
                return 0;
            }
            ENDHLSL
        }
    }
}
