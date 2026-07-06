// ============================================================================================
// HGRP/LitHLOD — EndField lithlod.shader 的 URP 1:1 单文件重构。
// 真值 = AllShader_1.3.3 出货变体反编译: lithlod/Sub0_Pass0_{Vertex_b1,Fragment_b2}(HGBuffer,
// LIGHTMAP_ON 恒开唯一形态)、Pass2 Depth b10/b11(+DITHER b12 对)。ShadowCaster 无特性。
// HLOD = 烘焙双贴图: T0=_BaseColorMap(raw uv0, 无 _ST): rgb=固有色, a=自发光遮罩兼 AO;
//        T1=_NormalMap(raw uv0): xy=法线(0.012 死区,无 scale 无双面), z=raw 粗糙度, w=金属度。
// 引擎面替换(同 lit 家族): HG 5-MRT GBuffer→URP 4-RT PackGBuffersBRDFData; IV-clipmap SH→SampleSH;
// probe 分箱→GlossyEnvironmentReflection; CSM/ASM→URP 主光阴影; 雾→MixFog; MV RT1→弃(URP MotionVectors 域)。
// ============================================================================================
Shader "HGRP/LitHLOD"
{
    Properties
    {
        _MainProperties ("基础材质", Float) = 0
        _BaseColorMap ("固有色贴图(RGB;A=自发光遮罩/AO)", 2D) = "white" {}
        _NormalMap ("法线贴图(XY;Z=粗糙度;W=金属度)", 2D) = "bump" {}
        _PackedEmissiveIntensity ("Packed Emissive Intensity", Float) = 0
        _AdvancedOptions ("Advanced Options", Float) = 0
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        _DitherScale ("Dither Scale", Range(0, 1)) = 1
        [Toggle(DITHER)] _KwDither ("KW DITHER(深度 pass LOD 抖动淡出)", Float) = 0
        [HideInInspector] _DitherTransparentOffset ("Dither Transparent Offset", Range(0, 1)) = 0.1
        [HideInInspector] _CutOffPosY ("_CutOffPosY", Float) = 0
        [HideInInspector] _UseCutOff ("_UseCutOff", Float) = 0
        [HideInInspector] _CutOffDirection ("_CutOffDirection", Vector) = (0, 1, 0, 0)
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _ShadingModel ("_ShadingModel", Float) = 0
        [HideInInspector] _UseDeferredRendering ("Render Mode", Float) = 1
        [HideInInspector] _ShadowBias ("_ShadowBias", Float) = 0
        [HideInInspector] _ShadowCullMode ("_ShadowCullMode", Float) = 2
        [HideInInspector] _AntiFlicker ("TAAU抗闪烁优化开关", Float) = 0
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

        CBUFFER_START(UnityPerMaterial)
            float _PackedEmissiveIntensity;
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

        // 反编译幻数(位型逐位保留)
        static const float HG_EPS_VIEWLEN     = 9.9999999392252902907785028219223e-09; // 1e-8 视向量守卫, b11:258
        static const float HG_EPS_HALF        = 6.103515625e-05;                        // 2^-14 半向量守卫, b11:929
        static const float HG_EPS_VIS         = 9.9999997473787516355514526367188e-05;  // 1e-4 Smith Vis 地板, b11:961
        static const float HG_GRAZING_FLOOR   = 0.0476190485060214996337890625;          // 1/21 掠射地板, b11:957
        static const float HG_NORMAL_DEADZONE = 0.01200000010430812835693359375;         // 法线死区, b2:98
        static const float HG_DIELECTRIC_F0   = 0.039999999105930328369140625;           // HLOD F0=0.04(无 _Specular 属性, =0.08×0.5 默认)

        struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS   : NORMAL;
            float4 tangentOS  : TANGENT;
            float2 uv0        : TEXCOORD0;
            UNITY_VERTEX_INPUT_INSTANCE_ID
        };

        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float3 positionWS : TEXCOORD0;
            float2 uv         : TEXCOORD1;   // raw uv0 (b2:68 无 _ST)
            float3 normalWS   : TEXCOORD2;
            float4 tangentWS  : TEXCOORD3;   // .w = 切线符号
            float  fogFactor  : TEXCOORD4;
            UNITY_VERTEX_INPUT_INSTANCE_ID
            UNITY_VERTEX_OUTPUT_STEREO
        };

        // 共享顶点(b1: 对象→世界→裁剪 + TBN; GPU skinning/八面体流/MV 双帧=引擎面弃)
        Varyings HlodVertex(Attributes IN)
        {
            Varyings OUT = (Varyings)0;
            UNITY_SETUP_INSTANCE_ID(IN);
            UNITY_TRANSFER_INSTANCE_ID(IN, OUT);
            UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(OUT);
            OUT.positionWS = TransformObjectToWorld(IN.positionOS);
            OUT.positionCS = TransformWorldToHClip(OUT.positionWS);
            OUT.normalWS   = TransformObjectToWorldNormal(IN.normalOS);
            OUT.tangentWS  = float4(TransformObjectToWorldDir(IN.tangentOS.xyz), IN.tangentOS.w * GetOddNegativeScale());
            OUT.uv         = IN.uv0;
            OUT.fogFactor  = ComputeFogFactor(OUT.positionCS.z);
            return OUT;
        }

        // HLOD 表面(b2:65-119 逐位)
        struct HlodSurface
        {
            float3 albedo;
            float3 normalWS;
            float  metallic;
            float  roughness;   // raw (b2:97, 无 Min/Max 重映射)
            float  occlusion;
            float3 emission;
            float3 f0;
            float3 diffuse;
        };

        HlodSurface HlodBuildSurface(Varyings IN)
        {
            HlodSurface s = (HlodSurface)0;
            float4 baked = SAMPLE_TEXTURE2D(_BaseColorMap, sampler_BaseColorMap, IN.uv);   // b2:68 (raw uv0)
            float4 nrmP  = SAMPLE_TEXTURE2D(_NormalMap,    sampler_NormalMap,    IN.uv);   // b2:92
            float emMask = clamp(mad(baked.w, 1.111111164093017578125, -0.11111111938953399658203125), 0.0, 1.0) * _PackedEmissiveIntensity; // b2:73
            s.emission = baked.rgb * emMask;                                               // b2:74-76
            s.albedo   = baked.rgb;                                                        // b2:87-89 (无 tint)
            // occlusion = _PackedEmissiveIntensity>0 ? a : 1−a (b2:86 mad(saturate(-sign(P)), 1-a, a))
            float occSel = clamp(float(int((0u - ((0.0 < _PackedEmissiveIntensity) ? 0xFFFFFFFFu : 0u)) + ((_PackedEmissiveIntensity < 0.0) ? 0xFFFFFFFFu : 0u))), 0.0, 1.0);
            s.occlusion = mad(occSel, -baked.w + 1.0, baked.w);
            s.metallic  = nrmP.w;                                                          // b2:93
            s.roughness = nrmP.z;                                                          // b2:97
            float nxRaw = mad(nrmP.x, 2.0, -1.0);
            float nyRaw = mad(nrmP.y, 2.0, -1.0);
            float nx = (abs(nxRaw) < HG_NORMAL_DEADZONE) ? 0.0 : nxRaw;                    // b2:98-99
            float ny = (abs(nyRaw) < HG_NORMAL_DEADZONE) ? 0.0 : nyRaw;
            float nz = sqrt(max(1.0 - dot(float2(nx, ny), float2(nx, ny)), 0.0));          // b2:100 (无双面翻转)
            float tSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;
            float3 bitan = tSign * cross(IN.normalWS, IN.tangentWS.xyz);
            float3 nWS = IN.normalWS * nz + IN.tangentWS.xyz * nx + bitan * ny;            // b2:101-103
            s.normalWS = normalize(nWS * rsqrt(max(dot(nWS, nWS), 1.1754943508222875079687365372222e-38))); // b2:104-111 双重归一
            s.f0      = lerp(HG_DIELECTRIC_F0.xxx, s.albedo, s.metallic);                  // 家族 F0 分裂(b11:298-305 同式, HLOD 无 _Specular→0.04)
            s.diffuse = s.albedo * (1.0 - s.metallic);
            return s;
        }

        // Karis 解析 EnvBRDF (b11:306-309,1241 逐位)
        void HgEnvBRDF(float roughness, float NoV, float3 f0, out float envScale, out float envBias)
        {
            float omr  = mad(roughness, -1.0, 1.0);
            float envF = mad(min(omr * omr, exp2(NoV * -9.27999973297119140625)), omr,
                             mad(roughness, -0.0274999998509883880615234375, 0.0425000004470348358154296875));
            envScale = mad(envF, -1.03999996185302734375, mad(roughness, -0.572000026702880859375, 1.03999996185302734375));
            envBias  = mad(envF,  1.03999996185302734375, mad(roughness,  0.02199999988079071044921875, -0.039999999105930328369140625))
                     * saturate(f0.g * 50.0);
        }

        // EnvBRDFApprox 有理 DFG (b11:955; T8 分离和 LUT=引擎预积分图无绑定, 解析式为其替代)
        float HgEnvBRDFApproxDFG(float roughness)
        {
            float t = mad(roughness, -1.0, 1.0);
            return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875, -0.076194703578948974609375),
                                  1.04997003078460693359375), 0.4092549979686737060546875),
                       0.999000012874603271484375);
        }

        // 单光源能量括号 (b11:944-965 逐位): GGX a2=rough⁴ + Smith 高度相关 Vis + Schlick F + 多散射漫反射
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

        // 视向量(b11:253-262): 透视=normalize(camPos−P)(1e-8 守卫); 正交=−View 行2
        float3 HgViewDirWS(float3 positionWS)
        {
            float3 raw;
            if (unity_OrthoParams.w == 0.0)
                raw = _WorldSpaceCameraPos - positionWS;
            else
                raw = float3(-UNITY_MATRIX_V[2].x, -UNITY_MATRIX_V[2].y, -UNITY_MATRIX_V[2].z);
            return raw * rsqrt(max(dot(raw, raw), HG_EPS_VIEWLEN));
        }

        // DITHER(深度 pass, lit b1167:128-137 同式逐位; unity_LODFade URP 原生同布局零替换)
        void HlodDitherClip(float4 positionCS, float3 positionWS)
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
        // Pass 1: UniversalForward — b11 前向合成(引擎面按文件头表换 URP)
        // ============================================================================================
        Pass
        {
            Name "ForwardLit"
            Tags { "LightMode" = "UniversalForward" }
            ZWrite On
            ZTest LEqual
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex HlodVertex
            #pragma fragment HlodForwardFragment
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

            float4 HlodForwardFragment(Varyings IN) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                HlodSurface s = HlodBuildSurface(IN);
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
                    color += mad(energy, NoL.xxx, s.diffuse * NoL) * (light.color * (light.distanceAttenuation * light.shadowAttenuation));
                LIGHT_LOOP_END
            #endif
                color += s.emission;
                color = MixFog(color, IN.fogFactor);
                return float4(color, 1.0);
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 2: UniversalGBuffer — HG 5-MRT(porosity/profile 无 URP 载体, 文档化弃)→URP 原生打包
        // ============================================================================================
        Pass
        {
            Name "GBuffer"
            Tags { "LightMode" = "UniversalGBuffer" }
            ZWrite On
            ZTest LEqual
            Cull [_CullMode]
            Stencil { Ref [_StencilRef] Comp Always Pass Replace }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma exclude_renderers gles3 glcore
            #pragma vertex HlodVertex
            #pragma fragment HlodGBufferFragment
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_BOX_PROJECTION
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_ATLAS
            #pragma multi_compile_instancing

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/UnityGBuffer.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/GBufferOutput.hlsl"

            GBufferFragOutput HlodGBufferFragment(Varyings IN)
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                HlodSurface s = HlodBuildSurface(IN);
                float3 N = s.normalWS;
                float3 V = HgViewDirWS(IN.positionWS);
                float NoV = max(dot(N, V), 0.0);
                float envScale, envBias;
                HgEnvBRDF(s.roughness, NoV, s.f0, envScale, envBias);
                float3 reflection = GlossyEnvironmentReflection(reflect(-V, N), s.roughness, 1.0);
                float3 giColor = s.diffuse * SampleSH(N) * s.occlusion * _EnvironmentGlobalParams0.x
                               + mad(s.f0, envScale.xxx, envBias.xxx) * reflection * _EnvironmentGlobalParams0.y;
                half alpha = half(1.0);
                BRDFData brdfData;
                InitializeBRDFData(half3(s.albedo), half(s.metallic), half3(0, 0, 0), half(1.0 - saturate(s.roughness)), alpha, brdfData);
                InputData inputData = (InputData)0;
                inputData.positionWS = IN.positionWS;
                inputData.positionCS = IN.positionCS;
                inputData.normalWS = half3(N);
                inputData.viewDirectionWS = half3(V);
                inputData.normalizedScreenSpaceUV = GetNormalizedScreenSpaceUV(IN.positionCS);
                return PackGBuffersBRDFData(brdfData, inputData, half(1.0 - saturate(s.roughness)),
                                            half3(s.emission + giColor), half(s.occlusion));
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 3: ShadowCaster (源: 无特性 keyword; b 系空片元)
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
            #pragma vertex HlodShadowVertex
            #pragma fragment HlodShadowFragment
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW
            #pragma multi_compile_instancing

            float3 _LightDirection;
            float3 _LightPosition;

            Varyings HlodShadowVertex(Attributes IN)
            {
                Varyings OUT = HlodVertex(IN);
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

            half4 HlodShadowFragment(Varyings IN) : SV_Target
            {
                return 0;
            }
            ENDHLSL
        }

        // ============================================================================================
        // Pass 4: DepthOnly (源 kw: DITHER)
        // ============================================================================================
        Pass
        {
            Name "DepthOnly"
            Tags { "LightMode" = "DepthOnly" }
            ZWrite On
            ZTest LEqual
            ColorMask R
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex HlodVertex
            #pragma fragment HlodDepthFragment
            #pragma shader_feature_local DITHER
            #pragma multi_compile_instancing

            half4 HlodDepthFragment(Varyings IN) : SV_Target
            {
                UNITY_SETUP_INSTANCE_ID(IN);
                HlodDitherClip(IN.positionCS, IN.positionWS);
                return 0;
            }
            ENDHLSL
        }
    }
}
