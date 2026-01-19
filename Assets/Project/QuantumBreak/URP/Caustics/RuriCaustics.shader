Shader "Hidden/Ruri/Caustics"
{
    Properties
    {
        _CausticsTexture ("Caustics Texture", 2D) = "black" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" "RenderPipeline" = "UniversalPipeline" }
        LOD 100
        
        // 叠加模式：Additive (黑底叠加)
        Blend One One
        ZTest Always 
        ZWrite Off 
        Cull Off

        Pass
        {
            Name "RuriCausticsPass"
            HLSLPROGRAM
            #pragma vertex Vert
            #pragma fragment Frag

            // -------------------------------------------------------------------------
            // URP Keywords for Shadows
            // -------------------------------------------------------------------------
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile _ _SHADOWS_SOFT

            // -------------------------------------------------------------------------
            // Includes
            // -------------------------------------------------------------------------
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Common.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Shadows.hlsl"
            
            #include "Assets/RuriAssembly/Ruri.RenderPipelines/Resources/Shaders/Common/Ruri_Deferred.hlsl"
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/DynamicScalingClamping.hlsl"

            float4 _CameraDepthTexture_TexelSize;

            #define sampler_CameraDepthTexture sampler_PointClamp

            float SampleSceneDepth(float2 uv, SAMPLER(samplerParam))
            {
                uv = ClampAndScaleUVForBilinear(UnityStereoTransformScreenSpaceTex(uv), _CameraDepthTexture_TexelSize.xy);
                return SAMPLE_TEXTURE2D_X(_CameraDepthTexture, samplerParam, uv).r;
            }

            float SampleSceneDepth(float2 uv)
            {
                return SampleSceneDepth(uv, sampler_PointClamp);
            }

            struct Attributes
            {
                uint vertexID : SV_VertexID;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            // 全局纹理 (由 GeometricDistortionFeature 生成)
            TEXTURE2D(_GeometricDistortionMap);
            // 焦散纹理
            TEXTURE2D(_CausticsTexture);

            CBUFFER_START(UnityPerMaterial)
                float4 _CausticsParams; // x: Scale, y: Speed, z: DistortionInfluence, w: Intensity
                float4 _CausticsColor;  // Color
                float4 _ProjectionParams_Ruri; // x: HeightFalloff, y: NormalThreshold
            CBUFFER_END

            // 来自 GeometricDistortion.cs 的全局参数
            float4 _DistortionParams; 
            float4 _DistortionCenter; 
            float4x4 _DistortionMatrixVP; 

            Varyings Vert(Attributes input)
            {
                Varyings output;
                output.positionCS = GetFullScreenTriangleVertexPosition(input.vertexID);
                output.uv = GetFullScreenTriangleTexCoord(input.vertexID);
                return output;
            }

            float4 Frag(Varyings input) : SV_Target
            {
                float2 uv = input.uv;

                // 1. 重建世界坐标
                // 必须使用像素坐标进行 GBuffer 读取
                uint2 pixelCoord = uint2(uv * _ScreenSize.xy);
                RuriGBufferData gBufferData = UnpackRuriGBuffers(pixelCoord);
                
                float depth = gBufferData.depth;
                
                // 剔除天空盒 (Depth == 0 or 1 depending on ReversedZ)
                #if UNITY_REVERSED_Z
                    if (depth <= 0.0001) return 0;
                #else
                    if (depth >= 0.9999) return 0;
                #endif

                float3 positionWS = ComputeWorldSpacePosition(uv, depth, UNITY_MATRIX_I_VP);

                // 2. 计算扭曲场的 UV 和 采样值
                float4 distortionClipPos = mul(_DistortionMatrixVP, float4(positionWS, 1.0));
                float2 distUV = (distortionClipPos.xy / distortionClipPos.w) * 0.5 + 0.5;
                
                // 计算边界遮罩 (Box Mask & Sphere Mask)
                // 这里的 Sphere Mask 使用 _DistortionParams.z (OuterRadius)
                float distToCenter = distance(positionWS, _DistortionCenter.xyz);
                float radiusMask = 1.0 - saturate((distToCenter - _DistortionParams.y) / (_DistortionParams.z - _DistortionParams.y + 0.001)); // y: Inner, z: Outer
                
                float2 borderDist = min(distUV, 1.0 - distUV);
                float inBounds = step(0.0, min(borderDist.x, borderDist.y)) * radiusMask;
                
                // [修复] 核心逻辑修正：如果没有在扭曲范围内，直接剔除
                if (inBounds <= 0.001) return 0;

                // 采样扭曲强度
                float distortionVal = SAMPLE_TEXTURE2D_LOD(_GeometricDistortionMap, sampler_LinearClamp, distUV, 0).x;
                
                // 使用 distortionVal 作为可见性遮罩 (Mask)
                // abs(distortionVal) 代表波浪的幅度（能量），平坦区域为0
                // 还原参考逻辑：仅在波浪经过的区域显示焦散
                float waveMask = smoothstep(0.05, 0.5, abs(distortionVal)); 
                
                // 如果该像素没有波浪经过，直接剔除
                if (waveMask <= 0.001) return 0;

                // 3. 读取法线 & 光照方向
                float3 normalWS = gBufferData.normalWS;
                float4 shadowCoord = TransformWorldToShadowCoord(positionWS);
                Light mainLight = GetMainLight(shadowCoord, positionWS, 1.0); 
                
                float NdotL = dot(normalWS, mainLight.direction);
                
                // 法线剔除 (背光面不显示焦散)
                if (NdotL < _ProjectionParams_Ruri.y)
                    return 0;

                // 4. 计算焦散
                // 使用平面投影 XZ
                float2 causticUV = positionWS.xz * _CausticsParams.x;
                float timeOffset = _Time.y * _CausticsParams.y;
                // 使用 distortionVal 偏移 UV，模拟水波折射效果
                float2 distortionOffset = distortionVal * _CausticsParams.z; 
                
                float2 uv1 = causticUV + float2(timeOffset, timeOffset) + distortionOffset;
                float2 uv2 = causticUV * 0.8 - float2(timeOffset, 0) - distortionOffset; 

                float3 c1 = SAMPLE_TEXTURE2D(_CausticsTexture, sampler_LinearRepeat, uv1).rgb;
                float3 c2 = SAMPLE_TEXTURE2D(_CausticsTexture, sampler_LinearRepeat, uv2).rgb;
                
                float intensity1 = max(c1.r, max(c1.g, c1.b));
                float intensity2 = max(c2.r, max(c2.g, c2.b));
                
                // 混合两层采样，模拟焦散网格
                float causticSignal = min(intensity1, intensity2) * 2.0; 

                // 5. 高度衰减 (Relative to Center Height)
                // 限制焦散只出现在波浪中心高度附近，避免无限延伸
                float heightAtten = 1.0 - saturate(abs(positionWS.y - _DistortionCenter.y) / _ProjectionParams_Ruri.x); // x: HeightFalloff

                // 6. 最终合成
                float3 finalColor = causticSignal * _CausticsColor.rgb;
                
                finalColor *= _CausticsParams.w; // User Intensity (Slider)
                finalColor *= saturate(NdotL);   // Light Incidence
                finalColor *= mainLight.shadowAttenuation; // Shadows (Cast shadows block caustics)
                finalColor *= heightAtten;       // Height Mask
                
                // [关键修正]
                // 移除原先的 `* (1.0 + abs(distortionVal) * 5.0)` 爆炸倍率。
                // 仅使用 waveMask 确保焦散跟随波浪。
                // 如果希望波峰稍微亮一点点，可以加一个很小的系数，例如 0.5，但绝不是 5.0。
                finalColor *= waveMask;

                return float4(finalColor, 1.0);
            }
            ENDHLSL
        }
    }
}