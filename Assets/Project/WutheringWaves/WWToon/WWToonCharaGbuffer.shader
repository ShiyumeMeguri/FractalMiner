Shader "Custom/WWToonCharaGBuffer"
{
    Properties
    {
        _IN0("IN0", 2D) = "white" {}
        _IN1("IN1", 2D) = "white" {}
        _IN2("IN2", 2D) = "white" {}
        _IN3("IN3", 2D) = "white" {}
        _IN4("InTex4", 2D) = "white" {}
        _IN5("IN5", 2D) = "white" {}
        _IN6("IN6", 2D) = "white" {}
        _IN7("IN7", 2D) = "white" {}
        _IN8("IN8", 2D) = "white" {}
        _IN9("IN9", 2D) = "white" {}
    }

    SubShader
    {
        Tags
        {
            "Queue" = "Geometry+1000"
        }
        
        Pass
        {
            HLSLPROGRAM

            #pragma vertex vert
            #pragma fragment frag
            #pragma target 5.0
            
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS_CASCADE
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VETEX _ADDITIONAL_LIGHTS
            #pragma multi_compile _ _SHADOWS_SOFT

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            
            struct Attributes
            {
                float4 positionOS   : POSITION;
                float2 uv           : TEXCOORD0;
                float3 normalOS     : NORMAL;       
                float4 tangentOS    : TANGENT;      
            };

            struct Varyings
            {
                float4 positionCS   : SV_POSITION;  
                float4 uv           : TEXCOORD0;    
                float3 normalWS     : TEXCOORD1;    
                float3 tangentWS    : TEXCOORD2;    
                float3 bitangentWS  : TEXCOORD3;    
                float3 lightDirWS   : TEXCOORD4;    
                float3 viewDirWS    : TEXCOORD5;    
            };
            
            TEXTURE2D(_IN0); SAMPLER(sampler_IN0);
            TEXTURE2D(_IN1); SAMPLER(sampler_IN1);
            TEXTURE2D(_IN2); SAMPLER(sampler_IN2);
            TEXTURE2D(_IN3); SAMPLER(sampler_IN3);
            TEXTURE2D(_IN4); SAMPLER(sampler_IN4);

            float4 _IN0_ST;
            float4 _IN1_ST;
            float4 _IN2_ST;
            float4 _IN3_ST;
            float4 _IN4_ST;
            float4 _IN5_ST;
            float4 _IN6_ST;
            float4 _IN7_ST;
            float4 _IN8_ST;
            float4 _IN9_ST;

            // ---- 全局参数变量定义 (替代 Structured Buffers) ----
            // cb0
            float4 g_Cb0_44, g_Cb0_45, g_Cb0_46, g_Cb0_47;
            float4 g_Cb0_144, g_Cb0_149, g_Cb0_249;
            // cb1
            float4 g_Cb1_0, g_Cb1_1;
            // cb2
            float4 g_Cb2_5, g_Cb2_23, g_Cb2_27;
            // cb3
            float4 g_Cb3_1, g_Cb3_17, g_Cb3_36;
            // cb4
            float4 g_Cb4_8, g_Cb4_61, g_Cb4_62, g_Cb4_64, g_Cb4_65, g_Cb4_66, g_Cb4_67;
            float4 g_Cb4_68, g_Cb4_69, g_Cb4_70, g_Cb4_85, g_Cb4_86;

            Varyings vert (Attributes i)
            {
                Varyings o;

                // 手动计算世界空间位置
                float4 positionWS4 = mul(unity_ObjectToWorld, i.positionOS);
                float3 positionWS = positionWS4.xyz;

                // 手动计算裁剪空间位置
                o.positionCS = mul(UNITY_MATRIX_VP, positionWS4);

                o.uv.xy = i.uv;
                float2 ndc = o.positionCS.xy / o.positionCS.w;
                o.uv.zw = ndc;

                // 手动计算世界空间法线、切线和副切线
                o.normalWS = normalize(mul((float3x3)unity_ObjectToWorld, i.normalOS));
                o.tangentWS = normalize(mul((float3x3)unity_ObjectToWorld, i.tangentOS.xyz));
                o.bitangentWS = cross(o.normalWS, o.tangentWS) * i.tangentOS.w;
                
                // 直接从全局变量获取主光源方向
                o.lightDirWS = _MainLightPosition.xyz; 

                // 手动计算世界空间视线方向
                o.viewDirWS = normalize(_WorldSpaceCameraPos.xyz - positionWS);

                return o;
            }
            
            struct FragOutput
            {
                float4 o0_GI : SV_Target0;
                float4 o1_Normal_Diffuse_FaceSDFMask : SV_Target1;
                float4 o2_ShadowColor_PackShadeMode_OutputMask : SV_Target2;
                float4 o3_BaseColor_ToonSkinMask : SV_Target3;
                float4 o4 : SV_Target4;
                float4 o5_RimDepth : SV_Target5;
                float4 o6_rimStrength_HSVPack_groundSpec_charRegion : SV_Target6;
            };

            FragOutput frag(Varyings fragmentInput)
            {
                // ---- 在 frag 开始时为全局参数变量赋值 ----
                g_Cb0_44 = float4(-0.001, 0.00027, 0.00, 0.00);
                g_Cb0_45 = float4(-0.00011, -0.0004, -0.00095, 0.00);
                g_Cb0_46 = float4(0.00, 0.00, 0.00, 0.10);
                g_Cb0_47 = float4(1.02657, 0.84954, -0.00344, 0.00);
                g_Cb0_144 = float4(0.00, 0.00, 0.00, 1.00);
                g_Cb0_149 = float4(0.01525, -0.37648, 0.77031, 3.99356E-41);
                g_Cb0_249 = float4(0.00, 0.00, 0.00, 0.00);
                g_Cb1_0 = float4(0.00, 0.00, 0.00, 1.00);
                g_Cb1_1 = float4(0.00, 0.00, 0.00, 1.00);
                g_Cb2_5 = float4(4046.79565, 15060.82422, 9682.03906, 69.95145);
                g_Cb2_23 = float4(-63.72506, -75.28133, -0.06375, 1.40130E-45);
                g_Cb2_27 = float4(0.00, 0.00, 0.09153, -0.69992);
                g_Cb3_1 = float4(0.50, 1.00, 0.00, 4.70083);
                g_Cb3_17 = float4(-0.99005, 0.14073, 0.00, 1.00);
                g_Cb3_36 = float4(-0.70007, 0.09951, 0.70711, 1.00);
                g_Cb4_8 = float4(0.00, 0.00, 100.00, 0.00);
                g_Cb4_61 = float4(0.93869, 0.60383, 0.40724, 0.00);
                g_Cb4_62 = float4(0.76803, 0.78755, 0.82292, 0.00);
                g_Cb4_64 = float4(0.00, 0.00, 0.50, 1.00);
                g_Cb4_65 = float4(0.00, 1.00, 0.00, 1.00);
                g_Cb4_66 = float4(1.00, 2.00, 5.00, 30.00);
                g_Cb4_67 = float4(0.66667, 0.66667, 0.55, 0.40);
                g_Cb4_68 = float4(-0.10, 0.55, 0.10, 1.00);
                g_Cb4_69 = float4(0.50, 0.90, 0.20, 1.00);
                g_Cb4_70 = float4(1.00, 0.00, 0.20, 0.00);
                g_Cb4_85 = float4(0.00, 0.00, 0.40, 0.50);
                g_Cb4_86 = float4(0.00, 0.30, 0.00, 0.00);

                FragOutput fragOutput;
                
                float4 interpolatedUV = fragmentInput.uv;
                float3 worldTangent = fragmentInput.tangentWS;
                float3 worldBitangent = fragmentInput.bitangentWS;

                float4 tempVector0;
                float3 tempVector3D_0;
                uint tempUint0;
                float4 tempVector1;
                float tempScalar0;
                float4 tempVector2;
                float2 tempVector2D_0;
                float3 tempVector3D_1;
                bool4 tempBool4_0;
                float3 tempVector3D_2;
                bool4 tempBool4_1;
                float4 tempVector4;
                float3 tempVector3D_3;
                float2 tempVector2D_1;
                float2 tempVector2D_2;
                float3 tempVector3D_4;
                float tempScalar1;
                float NdotV;
                bool tempBool0;
                float tempScalar2;
                int tempInt0;
                uint tempUint1;
                bool tempBool1;
                float tempScalar3;
                float tempScalar4;
                bool tempBool2;
                
                float4 clipSpacePosition = fragmentInput.positionCS;
                tempVector0 = g_Cb0_45 * clipSpacePosition.yyyy;
                tempVector1 = g_Cb0_44;
                tempVector0 = clipSpacePosition.xxxx * tempVector1 + tempVector0;
                tempVector1 = g_Cb0_46;
                tempVector0 = clipSpacePosition.zzzz * tempVector1 + tempVector0;
                tempVector1 = g_Cb0_47;
                tempVector0 = tempVector0 + tempVector1;
                
                float3 worldPosition = tempVector0.xyz / tempVector0.www;
                
                tempScalar2 = dot((-worldPosition.xyz), (-worldPosition.xyz));
                tempScalar2 = rsqrt(tempScalar2);
                float3 viewDirectionWS = float3(tempScalar2, tempScalar2, tempScalar2) * (-worldPosition.xyz);

                float mipBias = g_Cb0_149.y;
                float normalMapSample = _IN0.SampleBias(sampler_IN0, interpolatedUV.xy, mipBias).x;
                float unpackedNormalX = normalMapSample * 2.0 - 1.0;
                
                float normalPerturbationStrength = g_Cb4_64.w;
                unpackedNormalX = unpackedNormalX * normalPerturbationStrength;
                
                float normalBlendFactor = g_Cb0_144.w;
                tempVector1.xyz = unpackedNormalX.xxx * worldTangent.xyz + worldBitangent.xyz;
                tempVector2.x = (-normalBlendFactor) + 1.0;
                tempVector2.xyz = tempVector2.xxx * worldBitangent.xyz;
                tempVector1.xyz = tempVector1.xyz * float3(normalBlendFactor, normalBlendFactor, normalBlendFactor) + tempVector2.xyz;
                
                tempScalar3 = dot(tempVector1.xyz, tempVector1.xyz);
                tempScalar3 = rsqrt(tempScalar3);
                float3 perturbedNormalWS = tempVector1.xyz * float3(tempScalar3, tempScalar3, tempScalar3);

                float2 maskSample = _IN1.SampleLevel(sampler_IN1, interpolatedUV.xy, mipBias).xy;
                
                tempBool4_0 = maskSample.xxxx >= float4(0.0500000007, 0.300000012, 0.5, 0.899999976);
                tempVector3D_4.x = tempBool4_0.y ? float(1.0) : 0.0; 
                tempVector3D_4.y = tempBool4_0.z ? float(1.0) : 0.0; 
                tempVector3D_4.z = tempBool4_0.w ? float(1.0) : 0.0; 
                
                tempBool4_1 = float4(0.0500000007, 0.300000012, 0.5, 0.899999976) >= maskSample.xxxx;
                tempVector2.x = tempBool4_1.z ? float(1.0) : 0.0; 
                tempVector2.z = tempBool4_1.w ? float(1.0) : 0.0; 
                
                tempVector2.xz = tempVector3D_4.xy * tempVector2.xz; 
                
                tempScalar3 = (tempBool4_1.y) ? 0.0 : 1.0;
                tempScalar3 = (tempBool4_0.x) ? tempScalar3 : 1.0;
                tempScalar3 = (tempBool4_1.x) ? 1.0 : tempScalar3;
                tempScalar3 = (-tempVector2.x) * tempScalar3 + 1.0;
                tempScalar3 = (-tempVector2.z) * tempScalar3 + 1.0;
                float shadeModeSelector = tempScalar3 * tempVector3D_4.z;
                
                float3 shadeModeParams = g_Cb4_65.xyz;
                tempBool0 = shadeModeParams.y >= 0.5;
                float shadeMode = (tempBool0) ? shadeModeSelector : shadeModeParams.x;
                tempVector2.x = (-shadeMode) + 1.0;
                float finalShadeFactor = shadeModeParams.z * tempVector2.x + shadeMode; 

                float shadowMapSample = _IN2.SampleBias(sampler_IN2, interpolatedUV.xy, mipBias).w;
                NdotV = dot(perturbedNormalWS.xyz, viewDirectionWS.xyz);
                NdotV = clamp(NdotV, 0.0, 1.0);

                tempVector3D_1.xyz = g_Cb3_36.xyz;
                tempVector3D_2.xyz = g_Cb3_17.xyz;
                tempVector3D_2.xyz = (-tempVector3D_1.xyz) + tempVector3D_2.xyz;
                tempScalar4 = g_Cb4_67.y;
                tempVector3D_2.xyz = tempVector3D_2.xyz * float3(tempScalar4, tempScalar4, tempScalar4);
                tempScalar4 = g_Cb4_66.w;
                tempBool2 = tempScalar4 >= 0.5;
                tempScalar4 = tempBool2 ? 1.0 : float(0.0);
                tempVector3D_1.xyz = float3(tempScalar4, tempScalar4, tempScalar4) * tempVector3D_2.xyz + tempVector3D_1.xyz;
                tempScalar4 = dot(tempVector3D_1.xyz, tempVector3D_1.xyz);
                tempScalar4 = sqrt(tempScalar4);
                tempVector3D_1.xyz = tempVector3D_1.xyz / float3(tempScalar4, tempScalar4, tempScalar4);
                tempVector3D_2.xyz = g_Cb4_8.xyz;
                tempVector4.xyz = g_Cb2_5.xyz;
                tempVector3D_2.xyz = tempVector3D_2.xyz + tempVector4.xyz;
                tempVector4 = g_Cb1_0;
                tempVector4.xyz = (-tempVector3D_2.xyz) + tempVector4.xyz;
                tempScalar4 = dot(tempVector4.xyz, tempVector4.xyz);
                tempScalar4 = sqrt(tempScalar4);
                tempVector4.xyz = tempVector4.xyz / float3(tempScalar4, tempScalar4, tempScalar4);
                tempVector3D_3.xyz = g_Cb1_0.xyz;
                tempVector3D_2.xyz = tempVector3D_2.xyz + (-tempVector3D_3.xyz);
                tempScalar4 = dot(tempVector3D_2.xyz, tempVector3D_2.xyz);
                tempScalar4 = sqrt(tempScalar4);
                tempScalar4 = tempScalar4 * tempVector4.w;
                tempScalar4 = clamp(tempScalar4, 0.0, 1.0);
                tempVector3D_2.xyz = tempVector3D_1.xyz + (-tempVector4.xyz);
                tempVector3D_2.xyz = float3(tempScalar4, tempScalar4, tempScalar4) * tempVector3D_2.xyz + tempVector4.xyz;
                tempVector3D_2.xyz = (-tempVector3D_1.xyz) + tempVector3D_2.xyz;
                tempScalar4 = g_Cb1_1.z;
                tempVector3D_1.xyz = float3(tempScalar4, tempScalar4, tempScalar4) * tempVector3D_2.xyz + tempVector3D_1.xyz;
                tempScalar4 = g_Cb2_27.y;
                tempScalar4 = tempScalar4;
                tempScalar4 = clamp(tempScalar4, 0.0, 1.0);
                tempVector3D_1.xyz = float3(tempScalar4, tempScalar4, tempScalar4) * (-tempVector3D_1.xyz) + tempVector3D_1.xyz;
                tempScalar4 = dot(tempVector3D_1.xyz, tempVector3D_1.xyz);
                tempScalar4 = sqrt(tempScalar4);
                float3 finalLightDirection = tempVector3D_1.xyz / float3(tempScalar4, tempScalar4, tempScalar4);
                
                tempVector0.x = dot(finalLightDirection.xyz, viewDirectionWS.xyz);
                tempVector2D_1.x = -abs(viewDirectionWS.z) + 1.0;
                tempVector0.x = tempVector0.x * tempVector2D_1.x + 1.0;
                tempVector0.x = tempVector0.x * 0.5;
                float2 specularParams = g_Cb4_68.xy;
                tempScalar4 = g_Cb4_67.w;
                tempVector2D_1.x = (-specularParams.x) + tempScalar4;
                tempScalar4 = g_Cb4_68.x;
                tempVector0.x = tempVector0.x * tempVector2D_1.x + tempScalar4;
                tempVector2D_1.x = (-NdotV) + 1.0;
                float finalSpecularTerm = tempVector0.x * tempVector2D_1.x + specularParams.y;

                float shadowMapScale = g_Cb4_68.w;
                float scaledShadowValue = shadowMapSample * shadowMapScale;
                scaledShadowValue = max(scaledShadowValue, 0.0);
                float shadowMapMax = g_Cb4_69.x;
                scaledShadowValue = min(scaledShadowValue, shadowMapMax);
                float normalizedShadowValue = scaledShadowValue / shadowMapMax;
                
                float2 shadowRampParams = g_Cb4_69.zz; 
                float rampWidthInv = 1.0 / (1.0 - shadowRampParams.x);
                tempScalar4 = normalizedShadowValue - shadowRampParams.x;
                float rampT = tempScalar4 * rampWidthInv;
                rampT = clamp(rampT, 0.0, 1.0);
                
                tempScalar4 = rampT * -2.0 + 3.0;
                rampT = rampT * rampT;
                float smoothedRampT = rampT * tempScalar4;
                float rampedShadow = smoothedRampT * shadowRampParams.y;
                
                tempBool0 = 2.98023295e-08 >= rampedShadow;
                rampedShadow = log2(rampedShadow);
                float3 shadowPowerParams = g_Cb4_70.xyz; 
                rampedShadow = rampedShadow * shadowPowerParams.x;
                rampedShadow = exp2(rampedShadow);
                rampedShadow = rampedShadow * shadowPowerParams.y;
                float shadowTerm = (tempBool0) ? 0.0 : rampedShadow;
                
                float NdotL = dot(perturbedNormalWS.xyz, finalLightDirection.xyz);
                float diffuseShadowTerm = NdotL * 0.5 + shadowTerm;
                diffuseShadowTerm = diffuseShadowTerm + 0.5;

                float compressedShadow = min(normalizedShadowValue, shadowRampParams.x);
                compressedShadow = compressedShadow / shadowPowerParams.z;
                
                float clampedDiffuseShadow = max(diffuseShadowTerm, 0.0);
                float2 remapParams = g_Cb4_85.zz; 
                clampedDiffuseShadow = min(clampedDiffuseShadow, remapParams.x);
                
                float overflowDiffuseShadow = diffuseShadowTerm - clampedDiffuseShadow;
                float blendedShadowTerm = compressedShadow * overflowDiffuseShadow + clampedDiffuseShadow;
                blendedShadowTerm = blendedShadowTerm + 0.5;
                
                float rampLookupU = (-finalSpecularTerm) + blendedShadowTerm;
                rampLookupU = clamp(rampLookupU, 0.0, 1.0);

                float rampVOffset = -remapParams.y + 0.100000001; 
                float rampVScale = g_Cb4_85.w;
                float rampLookupV = finalShadeFactor * rampVOffset + rampVScale;
                
                float2 rampUV = float2(rampLookupU, rampLookupV);
                float3 rampedColor = _IN4.SampleBias(sampler_IN4, rampUV, mipBias).xyz;

                float skinMaskEnableFactor = g_Cb3_1.w;
                tempBool1 = skinMaskEnableFactor >= 0.0500000007;
                float isSkinMaskEnabled = tempBool1 ? 1.0 : float(0.0);
                float skinMaskValue = maskSample.y;
                float finalSkinMask = isSkinMaskEnabled * skinMaskValue;
                
                float3 colorA = g_Cb4_62.xyz;
                float3 colorB = g_Cb4_61.xyz;
                float3 shadeFactorBlendedColor = lerp(colorA, colorB, finalShadeFactor);
                
                float3 finalColor = lerp(shadeFactorBlendedColor, rampedColor, finalSkinMask);
                
                float luma = dot(finalColor.xyz, float3(0.300000012, 0.589999974, 0.109999999));
                float3 desaturatedColor = float3(luma, luma, luma);
                float saturation = g_Cb4_86.x;
                float3 finalSaturatedColor = lerp(finalColor, desaturatedColor, saturation);
                
                int branchCondition = int(g_Cb0_249.x);
                tempBool1 = branchCondition == 1;
                if (tempBool1) {
                    finalSaturatedColor = finalSaturatedColor;
                    finalSaturatedColor = clamp(finalSaturatedColor, 0.0, 1.0);
                    
                    fragOutput.o0_GI.xyz = sqrt(finalSaturatedColor.xyz);
                    
                    float packedDataInput = g_Cb2_23.w;
                    tempUint1 = asuint(packedDataInput);
                    {
                        uint mask = ~(((1u << 3) - 1) << 5); 
                        tempUint1 = (12u & mask) | ((tempUint1 & 7u) << 5);
                    }
                    float packedDataOutput = asfloat(tempUint1);
                    fragOutput.o0_GI.w = packedDataOutput * 0.00392156886; 
                }
                else {
                    finalSaturatedColor = finalSaturatedColor;
                    finalSaturatedColor = clamp(finalSaturatedColor, 0.0, 1.0);
                    fragOutput.o0_GI.xyz = sqrt(finalSaturatedColor.xyz);

                    float packedDataInput = g_Cb2_23.w;
                    tempUint0 = asuint(packedDataInput);
                    {
                        uint mask = ~(((1u << 3) - 1) << 5);
                        tempUint0 = (12u & mask) | ((tempUint0 & 7u) << 5);
                    }
                    float packedDataOutput = asfloat(tempUint0);
                    fragOutput.o0_GI.w = packedDataOutput * 0.00392156886;
                }
                
                // debug用 不要删
                fragOutput.o0_GI = pow(fragOutput.o0_GI, 5);
                return fragOutput;
                
                fragOutput.o1_Normal_Diffuse_FaceSDFMask = float4(0.0, 0.0, 0.0, 0.0);
                fragOutput.o2_ShadowColor_PackShadeMode_OutputMask = float4(0.0, 0.0, 0.0, 0.0);
                fragOutput.o3_BaseColor_ToonSkinMask = float4(0.0, 0.0, 0.0, 0.0);
                fragOutput.o4 = float4(0.0, 0.0, 0.0, 0.0);
                fragOutput.o5_RimDepth = float4(0.0, 0.0, 0.0, 0.0);
                fragOutput.o6_rimStrength_HSVPack_groundSpec_charRegion = float4(0.0, 0.0, 0.0, 0.0);
                
                return fragOutput;
            }
            ENDHLSL
        }
    }
}