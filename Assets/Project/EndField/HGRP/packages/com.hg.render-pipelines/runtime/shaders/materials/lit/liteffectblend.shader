// ============================================================================================
// Hidden/HGRP/LitEffectBlend — EndField liteffectblend.shader 的 URP 1:1 单文件重构。
// 真值 = AllShader_1.3.3 出货变体反编译:
//   Sub0_Pass0_{Vertex_b6/b8, Fragment_b7/b9}(LIGHTMODE=Erosion, 软深度相交混合)
//   Sub0_Pass1(ShadowCaster b24/25 空片元, +DITHER 对) / Sub0_Pass2(DepthOnly b44/45, +DITHER 对)
// 出货事实: 该家族片元恒为 3 贴图基面+侵蚀 alpha; 骨架声明的 _TWO_BASEMAP/_EMISSIVE_MAP/
//   _PARALLAX_MAP/_PARALLAX_MAP_WORLDSPACE 四个 keyword 在全部出货 blob 中编译为同一代码(no-op,
//   b7↔b9/b13 别名互证)。本文件同样只声明不引用 —— 与出货逐位对齐。
// 侵蚀(b7:108-121): alpha=min(pow(|(|sceneViewZ|−|surfViewZ|)·_ObjectBlendFactor|, _ObjectBlendFallOff),1)
//   且仅表面在场景前时非零; HG InvViewProj 双侧重建→URP LinearEyeDepth 双侧同函数(正视深等价)。
// 引擎面替换: HG 5-MRT Erosion 混合写(全 MRT .w=侵蚀)→URP 前向透明(SrcAlpha OneMinusSrcAlpha,
//   alpha=侵蚀); IV-clipmap SH→SampleSH; probe 分箱→GlossyEnvironmentReflection; CSM/ASM→URP 主光
//   阴影; 点光 zbin→URP additional; 雾→MixFog; MV/TAA/SceneEffect per-draw→弃(中性)。
// ============================================================================================
Shader "Hidden/HGRP/LitEffectBlend"
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
        _PorositySection ("吸水度", Float) = 1
        _PorosityFactorX ("吸水度影响因素X,受粗糙度影响", Range(-1, 1)) = 0.2
        _PorosityFactorY ("吸水度影响因素Y", Range(0, 1)) = 0.4
        _BasePbrCfgSection ("基础 PBR 材质设置", Float) = 0
        _Metallic ("金属度滑杆", Range(0, 1)) = 0
        _Specular ("Specular (Default 0.5)", Range(0, 1)) = 0.5
        _RoughnessMin ("最小粗糙度", Range(0, 1)) = 0
        _RoughnessMax ("最大粗糙度", Range(0, 1)) = 1
        _OcclusionStrength ("AO 强度", Range(0, 1)) = 1

        // ---- 骨架声明、出货 no-op 的 keyword(声明保真, 不引用) ----
        [Toggle(_TWO_BASEMAP)] _KwTwoBaseMap ("KW _TWO_BASEMAP(出货 no-op)", Float) = 0
        [Toggle(_EMISSIVE_MAP)] _KwEmissiveMap ("KW _EMISSIVE_MAP(出货 no-op)", Float) = 0
        [Toggle(_PARALLAX_MAP)] _KwParallaxMap ("KW _PARALLAX_MAP(出货 no-op)", Float) = 0
        [Toggle(_PARALLAX_MAP_WORLDSPACE)] _KwParallaxWorld ("KW _PARALLAX_MAP_WORLDSPACE(出货 no-op)", Float) = 0
        // 对应的自发光/视差属性组保留(材质序列化兼容)
        _EnableEmissiveMap ("自发光/自发光", Float) = 0
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
        _EmissiveRemap ("Emissive Remap", Range(1, 2)) = 1
        _EnableParallaxMap ("视差/Parallax Map", Float) = 0
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
        _ParallaxSignLerpFactor1 ("交互物信号(y阈值,z高度,w范围)", Vector) = (0, 0, 0, 0)
        _ParallaxIntensity ("Parallax整体强度", Range(0, 1)) = 1

        // ---- 侵蚀(本家族定义特性, 恒开) ----
        _ObjectBlendSection ("模型Blend功能", Float) = 1
        _ObjectBlendFactor ("Object Blend Factor", Float) = 1
        _ObjectBlendFallOff ("Object Blend FallOff", Float) = 1

        [Toggle(DITHER)] _KwDither ("KW DITHER(阴影/深度 LOD 抖动淡出)", Float) = 0
        [ToggleUI] _UseSceneEffect ("Use SceneEffect(Dark)", Float) = 1
        [HideInInspector] _DirectLightRoughnessOffset ("(Hack) Direct Light Roughness Offset", Range(-1, 1)) = 0

        _AdvancedOptions ("Advanced Options", Float) = 0
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        _DitherScale ("Dither Scale", Range(0, 1)) = 1
        [ToggleUI] _DisableVerticalOcclusion ("不参与雨遮蔽", Float) = 0
        _VerticalOcclusionDepthBias ("雨遮蔽偏移", Range(0, 0.3)) = 0
        [ToggleUI] _TAAUNormalBiasReverse ("TAAU Normal偏移补偿", Float) = 0
        [ToggleUI] _ReceiveDecals ("Receive Decals", Float) = 1
        [ToggleUI] _EnableBakedEmissive ("Enable Baked Emissive", Float) = 0
        [HideInInspector] _DitherTransparentAlpha ("Dither Transparent Alpha", Range(0, 1)) = 1
        [HideInInspector] _DitherTransparentOffset ("Dither Transparent Offset", Range(0, 1)) = 0.1
        [HideInInspector] _CutOffPosY ("_CutOffPosY", Float) = 0
        [HideInInspector] _UseCutOff ("_UseCutOff", Float) = 0
        [HideInInspector] _CutOffDirection ("_CutOffDirection", Vector) = (0, 1, 0, 0)
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _StencilOpGBuffer ("__stencilOpGBuffer", Float) = 2
        [HideInInspector] _StencilOpPreZ ("__stencilOpPreZ", Float) = 0
        [HideInInspector] _ZTestGBuffer ("_ZTestGBuffer", Float) = 4
        [HideInInspector] _ShadingModel ("_ShadingModel", Float) = 0
        [HideInInspector] _UseDeferredRendering ("Render Mode", Float) = 1
        [HideInInspector] _ShadowBias ("_ShadowBias", Float) = 0
        [HideInInspector] _ShadowCullMode ("_ShadowCullMode", Float) = 2
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
        [HideInInspector] _AntiFlicker ("TAAU抗闪烁优化开关", Float) = 0
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
        // 场景深度(侵蚀 b7:108-119 手动 InvViewProj 重建 → URP _CameraDepthTexture)
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

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
            float _ObjectBlendFactor;
            float _ObjectBlendFallOff;
            float _DirectLightRoughnessOffset;
            float _DitherScale;
            float _DitherTransparentOffset;
            float _CutOffPosY;
            float _UseCutOff;
            float4 _CutOffDirection;
            float _AntiFlicker;
            float4 _EnvironmentGlobalParams0;
        CBUFFER_END

        TEXTURE2D(_BaseColorMap); SAMPLER(sampler_BaseColorMap);
        TEXTURE2D(_NormalMap);    SAMPLER(sampler_NormalMap);
        TEXTURE2D(_MROMap);       SAMPLER(sampler_MROMap);

        static const float HG_EPS_VIEWLEN     = 9.9999999392252902907785028219223e-09; // 1e-8, b11:258
        static const float HG_EPS_NORMAL_Z    = 1.000000016862383526387164645044e-16;  // 1e-16 法线Z下限, b7:157
        static const float HG_EPS_HALF        = 6.103515625e-05;                        // 2^-14, b11:929
        static const float HG_EPS_VIS         = 9.9999997473787516355514526367188e-05;  // 1e-4, b11:961
        static const float HG_DIELECTRIC_F0   = 0.07999999821186065673828125;           // 0.08×_Specular 基, b11:298
        static const float HG_GRAZING_FLOOR   = 0.0476190485060214996337890625;          // 1/21, b11:957

        struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS   : NORMAL;
            float4 tangentOS  : TANGENT;
            float2 uv0        : TEXCOORD0;
            float2 uv1        : TEXCOORD1;
            UNITY_VERTEX_INPUT_INSTANCE_ID
        };

        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float3 positionWS : TEXCOORD0;
            float4 uv         : TEXCOORD1;   // .xy=uv0 .zw=uv1 (raw; 片元做 UV 集选择+_ST, b7:140-147)
            float3 normalWS   : TEXCOORD2;
            float4 tangentWS  : TEXCOORD3;
            float  fogFactor  : TEXCOORD4;
            UNITY_VERTEX_INPUT_INSTANCE_ID
            UNITY_VERTEX_OUTPUT_STEREO
        };

        Varyings LebVertex(Attributes IN)
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
            OUT.fogFactor  = ComputeFogFactor(OUT.positionCS.z);
            return OUT;
        }

        void LebComputeUVs(float4 uv, out float2 uvBase, out float2 uvPbr)
        {
            float2 duv = uv.zw - uv.xy;
            uvBase = mad(mad(_BaseUVSet.xx,       duv, uv.xy), _BaseColorMap_ST.xy, _BaseColorMap_ST.zw);   // b7:142
            uvPbr  = mad(mad(_BasePbrMapUVSet.xx, duv, uv.xy), _NormalMap_ST.xy,    _NormalMap_ST.zw);      // b7:146-147
        }

        struct LebSurface
        {
            float3 albedo;
            float3 normalWS;
            float  metallic;
            float  roughness;
            float  occlusion;
            float3 f0;
            float3 diffuse;
        };

        // 基面(b7:140-177 逐位, 恒 3 贴图: 该家族 _TWO_BASEMAP=出货 no-op)
        LebSurface LebBuildSurface(Varyings IN, bool isFrontFace)
        {
            LebSurface s = (LebSurface)0;
            float2 uvBase, uvPbr;
            LebComputeUVs(IN.uv, uvBase, uvPbr);

            float4 baseTex = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, uvBase);                    // b7:142
            float4 mro     = SAMPLE_TEXTURE2D(_MROMap, sampler_MROMap, uvPbr);                                 // b7:148
            float4 nrm     = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap, uvPbr, _TAAUNormalBiasReverse); // b7:152

            float3 albedoRaw = saturate(baseTex.rgb * _BaseColor.rgb * _BaseColorBrighterScale);               // b7:143-145
            float3 baseCol   = lerp(albedoRaw, _BaseColor.rgb, _BaseColorTintCover);                           // b7:175-177

            float nxDec = mad(nrm.x * nrm.w, 2.0, -1.0);                                                       // b7:153 (DXT5nm)
            float nyDec = mad(nrm.y,         2.0, -1.0);                                                       // b7:154
            float nx = nxDec * _NormalScale;                                                                   // b7:155
            float ny = nyDec * _NormalScale;                                                                   // b7:156
            float frontSign = isFrontFace ? 1.0 : ((_TwoSidedNormal > 0.0) ? -1.0 : 1.0);
            float nz = max(sqrt(1.0 - min(dot(float2(nxDec, nyDec), float2(nxDec, nyDec)), 1.0)), HG_EPS_NORMAL_Z) * frontSign; // b7:157
            float tSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
            float3 bitan = tSign * cross(IN.normalWS, IN.tangentWS.xyz);
            s.normalWS = normalize(IN.normalWS * nz + IN.tangentWS.xyz * nx + bitan * ny);                     // b7:158-165

            s.metallic  = lerp(mro.x, _Metallic, saturate(_BaseTextureMapCount - 1.0));                        // b7:149-150
            s.roughness = lerp(_RoughnessMin, _RoughnessMax, mro.y);                                           // b7:174
            s.occlusion = lerp(1.0, mro.z, _OcclusionStrength);                                                // b7:151
            s.albedo    = baseCol;
            s.f0        = lerp((HG_DIELECTRIC_F0 * _Specular).xxx, baseCol, s.metallic);                       // b11:298-305 同式
            s.diffuse   = baseCol * (1.0 - s.metallic);
            return s;
        }

        // ---- b11 光照内核(逐位; 引擎面按文件头表换 URP) ----
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

        // 侵蚀 alpha(b7:108-121 逐位)
        float LebErosionBlend(float4 positionCS)
        {
            float2 screenUV  = GetNormalizedScreenSpaceUV(positionCS);
            float  sceneRaw  = SampleSceneDepth(screenUV);                          // b7:108 (_92)
            float  sceneEyeZ = LinearEyeDepth(sceneRaw, _ZBufferParams);            // b7:118 |_211|
            float  surfEyeZ  = LinearEyeDepth(positionCS.z, _ZBufferParams);        // b7:119 |_212|
            float  blend = min(exp2(log2(abs((sceneEyeZ - surfEyeZ) * _ObjectBlendFactor)) * _ObjectBlendFallOff), 1.0); // b7:120
            return (surfEyeZ < sceneEyeZ) ? blend : 0.0;                            // b7:120 近侧门
        }

        // DITHER(阴影/深度, lit b1167 同式逐位)
        void LebDitherClip(float4 positionCS, float3 positionWS)
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
        // Pass 1: ForwardLit — 源 Erosion pass(Blend SrcAlpha OneMinusSrcAlpha, 骨架 L114)重表达:
        //   HG 5-MRT 混合写 → URP 前向着色 + alpha=侵蚀因子(直接赋值, b7:121 非乘)。
        // ============================================================================================
        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForward" }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            ZTest [_ZTestGBuffer]
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex LebVertex
            #pragma fragment LebForwardFragment
            // 骨架声明的四个材质 keyword(出货 no-op, 声明保真)
            #pragma shader_feature_local _TWO_BASEMAP
            #pragma shader_feature_local _EMISSIVE_MAP
            #pragma shader_feature_local _PARALLAX_MAP
            #pragma shader_feature_local _PARALLAX_MAP_WORLDSPACE
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

            float4 LebForwardFragment(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                LebSurface s = LebBuildSurface(IN, isFrontFace);
                float3 N = s.normalWS;
                float3 V = HgViewDirWS(IN.positionWS);
                float NoV = max(dot(N, V), 0.0);
                float envScale, envBias;
                HgEnvBRDF(s.roughness, NoV, s.f0, envScale, envBias);
                float3 reflection = GlossyEnvironmentReflection(reflect(-V, N), s.roughness, 1.0);
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
                    // _DirectLightRoughnessOffset: HG 延迟解算端 hack 的前向等价位(直接光粗糙度偏移)
                    float3 energy = HgDirectLightEnergy(s.roughness + _DirectLightRoughnessOffset, s.f0, NoL, NoH, NoV, VoH);
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
                    float3 energy = HgDirectLightEnergy(s.roughness + _DirectLightRoughnessOffset, s.f0, NoL, NoH, NoV, VoH);
                    color += mad(energy, NoL.xxx, s.diffuse * NoL) * (light.color * (light.distanceAttenuation * light.shadowAttenuation));
                LIGHT_LOOP_END
            #endif
                color = MixFog(color, IN.fogFactor);
                return float4(color, LebErosionBlend(IN.positionCS));   // b7:121 (alpha=侵蚀, 直接赋值)
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2: ShadowCaster (b24/25 空片元 + DITHER 对)
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
            #pragma vertex LebShadowVertex
            #pragma fragment LebShadowFragment
            #pragma shader_feature_local DITHER
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW
            #pragma multi_compile_instancing

            float3 _LightDirection;
            float3 _LightPosition;

            Varyings LebShadowVertex(Attributes IN)
            {
                Varyings OUT = LebVertex(IN);
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

            half4 LebShadowFragment(Varyings IN) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                LebDitherClip(IN.positionCS, IN.positionWS);
                return 0;
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 3: DepthOnly (b44/45 空片元 + DITHER 对)
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
            #pragma vertex LebVertex
            #pragma fragment LebDepthFragment
            #pragma shader_feature_local DITHER
            #pragma multi_compile_instancing

            half4 LebDepthFragment(Varyings IN) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                LebDitherClip(IN.positionCS, IN.positionWS);
                return 0;
            }
            ENDHLSL
        }
    }
}
