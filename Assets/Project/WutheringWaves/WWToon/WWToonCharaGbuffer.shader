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
        // G-Buffer Pass for URP Deferred Rendering
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
            
            // URP管线需要的多重编译指令
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS_CASCADE
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VETEX _ADDITIONAL_LIGHTS
            #pragma multi_compile _ _SHADOWS_SOFT

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"
            
            // --- 结构体定义 ---

            // 输入到顶点着色器的数据 (来自Mesh)
            struct Attributes
            {
                float4 positionOS   : POSITION;
                float2 uv           : TEXCOORD0;
                float3 normalOS     : NORMAL;       // 模型空间的法线
                float4 tangentOS    : TANGENT;      // 模型空间的切线 (w分量用于计算副切线方向)
            };

            // 从顶点着色器传递到片元着色器的数据
            struct Varyings
            {
                float4 positionCS   : SV_POSITION;  // 裁剪空间位置
                float4 uv           : TEXCOORD0;    // UV坐标
                
                // TBN 矩阵的三个轴，在世界空间中
                float3 normalWS     : TEXCOORD1;    // 世界空间法线
                float3 tangentWS    : TEXCOORD2;    // 世界空间切线
                float3 bitangentWS  : TEXCOORD3;    // 世界空间副切线
                
                float3 lightDirWS   : TEXCOORD4;    // 世界空间主光源方向
                float3 viewDirWS    : TEXCOORD5;    // 世界空间视角方向
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
            
            // --- 顶点着色器 ---
            Varyings vert (Attributes i)
            {
                Varyings o;

                // 1. 转换顶点位置
                o.positionCS = TransformObjectToHClip(i.positionOS.xyz);
                float3 positionWS = TransformObjectToWorld(i.positionOS.xyz);

                // 2. 传递UV坐标 (使用TRANSFORM_TEX宏来处理Tiling/Offset)
                o.uv.xy = i.uv;
                float2 ndc = o.positionCS.xy / o.positionCS.w;
                o.uv.zw = ndc;

                // 3. 计算世界空间下的法线、切线和副切线 (TBN)
                o.normalWS = TransformObjectToWorldNormal(i.normalOS);
                o.tangentWS = TransformObjectToWorldDir(i.tangentOS.xyz);
                // 使用法线和切线计算副切线，并乘以tangent.w来确保正确的方向（左右手坐标系问题）
                o.bitangentWS = cross(o.normalWS, o.tangentWS) * i.tangentOS.w;
                
                // 4. 获取主光源信息
                Light mainLight = GetMainLight();
                o.lightDirWS = mainLight.direction; // 方向是从物体指向光源

                // 5. 获取世界空间的视角方向
                o.viewDirWS = GetWorldSpaceViewDir(positionWS);

                return o;
            }
            
            StructuredBuffer<float4> cb0;
            StructuredBuffer<float4> cb1;
            StructuredBuffer<float4> cb2;
            StructuredBuffer<float4> cb3;
            StructuredBuffer<float4> cb4;
            
            // --- 片元着色器 G-Buffer 输出 ---
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

//=========================================================================================
//  重命名后的片元着色器函数
//=========================================================================================
FragOutput frag(Varyings fragmentInput)
{
    FragOutput OUT;
    // 从Varyings结构体中获取插值后的数据
    float4 interpolatedUV = fragmentInput.uv;
    float3 worldTangent = fragmentInput.tangentWS;
    float3 worldBitangent = fragmentInput.bitangentWS;

    // --- 变量声明 (对应原始 u_xlat... 变量) ---
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
    
    // --- 1. 从屏幕坐标反算世界坐标，并计算视角方向 ---
    // 使用逆视图投影矩阵 (存储在 cb0[44] 到 cb0[47]) 将裁剪空间位置转换回世界空间位置
    float4 clipSpacePosition = fragmentInput.positionCS;
    tempVector0 = cb0[45] * clipSpacePosition.yyyy;
    tempVector1 = cb0[44];
    tempVector0 = clipSpacePosition.xxxx * tempVector1 + tempVector0;
    tempVector1 = cb0[46];
    tempVector0 = clipSpacePosition.zzzz * tempVector1 + tempVector0;
    tempVector1 = cb0[47];
    tempVector0 = tempVector0 + tempVector1;
    
    // 透视除法，得到世界空间位置
    float3 worldPosition = tempVector0.xyz / tempVector0.www;
    
    // 计算并归一化视角方向（从片元指向摄像机）
    tempScalar2 = dot((-worldPosition.xyz), (-worldPosition.xyz));
    tempScalar2 = rsqrt(tempScalar2);
    float3 viewDirectionWS = float3(tempScalar2, tempScalar2, tempScalar2) * (-worldPosition.xyz);

    // --- 2. 计算扰动后的世界空间法线 ---
    float mipBias = cb0[149].y;
    float normalMapSample = _IN0.SampleBias(sampler_IN0, interpolatedUV.xy, mipBias).x;
    float unpackedNormalX = normalMapSample * 2.0 - 1.0;
    
    float normalPerturbationStrength = cb4[64].w;
    unpackedNormalX = unpackedNormalX * normalPerturbationStrength;
    
    // 基于一个参数进行自定义的法线扰动计算
    float normalBlendFactor = cb0[144].w;
    tempVector1.xyz = unpackedNormalX.xxx * worldTangent.xyz + worldBitangent.xyz;
    tempVector2.x = (-normalBlendFactor) + 1.0;
    tempVector2.xyz = tempVector2.xxx * worldBitangent.xyz;
    tempVector1.xyz = tempVector1.xyz * float3(normalBlendFactor, normalBlendFactor, normalBlendFactor) + tempVector2.xyz;
    
    // 归一化得到最终的扰动法线
    tempScalar3 = dot(tempVector1.xyz, tempVector1.xyz);
    tempScalar3 = rsqrt(tempScalar3);
    float3 perturbedNormalWS = tempVector1.xyz * float3(tempScalar3, tempScalar3, tempScalar3);

    // --- 3. 根据遮罩纹理计算着色模式 ---
    float2 maskSample = _IN1.SampleLevel(sampler_IN1, interpolatedUV.xy, mipBias).xy;
    
    // 比较遮罩值与多个阈值，以确定其所属区间
    tempBool4_0 = maskSample.xxxx >= float4(0.0500000007, 0.300000012, 0.5, 0.899999976);
    tempVector3D_4.x = tempBool4_0.y ? float(1.0) : 0.0; // mask.x >= 0.3
    tempVector3D_4.y = tempBool4_0.z ? float(1.0) : 0.0; // mask.x >= 0.5
    tempVector3D_4.z = tempBool4_0.w ? float(1.0) : 0.0; // mask.x >= 0.9
    
    tempBool4_1 = float4(0.0500000007, 0.300000012, 0.5, 0.899999976) >= maskSample.xxxx;
    tempVector2.x = tempBool4_1.z ? float(1.0) : 0.0; // mask.x <= 0.5
    tempVector2.z = tempBool4_1.w ? float(1.0) : 0.0; // mask.x <= 0.9
    
    // 计算区间遮罩
    tempVector2.xz = tempVector3D_4.xy * tempVector2.xz; // .x: in [0.3, 0.5], .z: in [0.5, 0.9]
    
    tempScalar3 = (tempBool4_1.y) ? 0.0 : 1.0;
    tempScalar3 = (tempBool4_0.x) ? tempScalar3 : 1.0;
    tempScalar3 = (tempBool4_1.x) ? 1.0 : tempScalar3;
    tempScalar3 = (-tempVector2.x) * tempScalar3 + 1.0;
    tempScalar3 = (-tempVector2.z) * tempScalar3 + 1.0;
    float shadeModeSelector = tempScalar3 * tempVector3D_4.z;
    
    // 根据参数选择和混合着色模式
    float3 shadeModeParams = cb4[65].xyz;
    tempBool0 = shadeModeParams.y >= 0.5;
    float shadeMode = (tempBool0) ? shadeModeSelector : shadeModeParams.x;
    tempVector2.x = (-shadeMode) + 1.0;
    float finalShadeFactor = shadeModeParams.z * tempVector2.x + shadeMode; // lerp(shadeMode, 1.0, shadeModeParams.z)

    // --- 4. 计算光照和阴影 ---
    float shadowMapSample = _IN2.SampleBias(sampler_IN2, interpolatedUV.xy, mipBias).w;
    NdotV = dot(perturbedNormalWS.xyz, viewDirectionWS.xyz);
    NdotV = clamp(NdotV, 0.0, 1.0);

    // --- 4a. 计算自定义的最终光照方向 ---
    // (这是一个非常复杂的过程，混合了多个位置和参数来动态生成光照方向)
    tempVector3D_1.xyz = cb3[36].xyz;
    tempVector3D_2.xyz = cb3[17].xyz;
    tempVector3D_2.xyz = (-tempVector3D_1.xyz) + tempVector3D_2.xyz;
    tempScalar4 = cb4[67].y;
    tempVector3D_2.xyz = tempVector3D_2.xyz * float3(tempScalar4, tempScalar4, tempScalar4);
    tempScalar4 = cb4[66].w;
    tempBool2 = tempScalar4 >= 0.5;
    tempScalar4 = tempBool2 ? 1.0 : float(0.0);
    tempVector3D_1.xyz = float3(tempScalar4, tempScalar4, tempScalar4) * tempVector3D_2.xyz + tempVector3D_1.xyz;
    tempScalar4 = dot(tempVector3D_1.xyz, tempVector3D_1.xyz);
    tempScalar4 = sqrt(tempScalar4);
    tempVector3D_1.xyz = tempVector3D_1.xyz / float3(tempScalar4, tempScalar4, tempScalar4);
    tempVector3D_2.xyz = cb4[8].xyz;
    tempVector4.xyz = cb2[5].xyz;
    tempVector3D_2.xyz = tempVector3D_2.xyz + tempVector4.xyz;
    tempVector4 = cb1[0];
    tempVector4.xyz = (-tempVector3D_2.xyz) + tempVector4.xyz;
    tempScalar4 = dot(tempVector4.xyz, tempVector4.xyz);
    tempScalar4 = sqrt(tempScalar4);
    tempVector4.xyz = tempVector4.xyz / float3(tempScalar4, tempScalar4, tempScalar4);
    tempVector3D_3.xyz = cb1[0].xyz;
    tempVector3D_2.xyz = tempVector3D_2.xyz + (-tempVector3D_3.xyz);
    tempScalar4 = dot(tempVector3D_2.xyz, tempVector3D_2.xyz);
    tempScalar4 = sqrt(tempScalar4);
    tempScalar4 = tempScalar4 * tempVector4.w;
    tempScalar4 = clamp(tempScalar4, 0.0, 1.0);
    tempVector3D_2.xyz = tempVector3D_1.xyz + (-tempVector4.xyz);
    tempVector3D_2.xyz = float3(tempScalar4, tempScalar4, tempScalar4) * tempVector3D_2.xyz + tempVector4.xyz;
    tempVector3D_2.xyz = (-tempVector3D_1.xyz) + tempVector3D_2.xyz;
    tempScalar4 = cb1[1].z;
    tempVector3D_1.xyz = float3(tempScalar4, tempScalar4, tempScalar4) * tempVector3D_2.xyz + tempVector3D_1.xyz;
    tempScalar4 = cb2[27].y;
    tempScalar4 = tempScalar4;
    tempScalar4 = clamp(tempScalar4, 0.0, 1.0);
    tempVector3D_1.xyz = float3(tempScalar4, tempScalar4, tempScalar4) * (-tempVector3D_1.xyz) + tempVector3D_1.xyz;
    tempScalar4 = dot(tempVector3D_1.xyz, tempVector3D_1.xyz);
    tempScalar4 = sqrt(tempScalar4);
    float3 finalLightDirection = tempVector3D_1.xyz / float3(tempScalar4, tempScalar4, tempScalar4);
    
    // --- 4b. 计算高光项 ---
    tempVector0.x = dot(finalLightDirection.xyz, viewDirectionWS.xyz);
    tempVector2D_1.x = -abs(viewDirectionWS.z) + 1.0;
    tempVector0.x = tempVector0.x * tempVector2D_1.x + 1.0;
    tempVector0.x = tempVector0.x * 0.5;
    float2 specularParams = cb4[68].xy;
    tempScalar4 = cb4[67].w;
    tempVector2D_1.x = (-specularParams.x) + tempScalar4;
    tempScalar4 = cb4[68].x;
    tempVector0.x = tempVector0.x * tempVector2D_1.x + tempScalar4;
    tempVector2D_1.x = (-NdotV) + 1.0;
    float finalSpecularTerm = tempVector0.x * tempVector2D_1.x + specularParams.y;

    // --- 4c. 计算复杂的阴影ランプ项 ---
    float shadowMapScale = cb4[68].w;
    float scaledShadowValue = shadowMapSample * shadowMapScale;
    scaledShadowValue = max(scaledShadowValue, 0.0);
    float shadowMapMax = cb4[69].x;
    scaledShadowValue = min(scaledShadowValue, shadowMapMax);
    float normalizedShadowValue = scaledShadowValue / shadowMapMax;
    
    float2 shadowRampParams = cb4[69].zz; // .z: Ramp End, .z: Ramp Intensity
    float rampWidthInv = 1.0 / (1.0 - shadowRampParams.x);
    tempScalar4 = normalizedShadowValue - shadowRampParams.x;
    float rampT = tempScalar4 * rampWidthInv;
    rampT = clamp(rampT, 0.0, 1.0);
    
    // Smoothstep: t*t*(3-2t)
    tempScalar4 = rampT * -2.0 + 3.0;
    rampT = rampT * rampT;
    float smoothedRampT = rampT * tempScalar4;
    float rampedShadow = smoothedRampT * shadowRampParams.y;
    
    // 应用幂函数调整
    tempBool0 = 2.98023295e-08 >= rampedShadow;
    rampedShadow = log2(rampedShadow);
    float3 shadowPowerParams = cb4[70].xyz; // .x: power, .y: scale, .z: compress
    rampedShadow = rampedShadow * shadowPowerParams.x;
    rampedShadow = exp2(rampedShadow);
    rampedShadow = rampedShadow * shadowPowerParams.y;
    float shadowTerm = (tempBool0) ? 0.0 : rampedShadow;
    
    // --- 4d. 组合光照与阴影，计算最终的 Ramp U 坐标 ---
    float NdotL = dot(perturbedNormalWS.xyz, finalLightDirection.xyz);
    float diffuseShadowTerm = NdotL * 0.5 + shadowTerm;
    diffuseShadowTerm = diffuseShadowTerm + 0.5;

    float compressedShadow = min(normalizedShadowValue, shadowRampParams.x);
    compressedShadow = compressedShadow / shadowPowerParams.z;
    
    float clampedDiffuseShadow = max(diffuseShadowTerm, 0.0);
    float2 remapParams = cb4[85].zz; // .z: remapMax
    clampedDiffuseShadow = min(clampedDiffuseShadow, remapParams.x);
    
    float overflowDiffuseShadow = diffuseShadowTerm - clampedDiffuseShadow;
    float blendedShadowTerm = compressedShadow * overflowDiffuseShadow + clampedDiffuseShadow;
    blendedShadowTerm = blendedShadowTerm + 0.5;
    
    float rampLookupU = (-finalSpecularTerm) + blendedShadowTerm;
    rampLookupU = clamp(rampLookupU, 0.0, 1.0);

    // --- 5. 计算 Ramp V 坐标 ---
    float rampVOffset = -remapParams.y + 0.100000001; // remapParams.y is same as .x
    float rampVScale = cb4[85].w;
    float rampLookupV = finalShadeFactor * rampVOffset + rampVScale;
    
    // --- 6. 采样Ramp贴图并混合最终颜色 ---
    float2 rampUV = float2(rampLookupU, rampLookupV);
    float3 rampedColor = _IN4.SampleBias(sampler_IN4, rampUV, mipBias).xyz;

    float skinMaskEnableFactor = cb3[1].w;
    tempBool1 = skinMaskEnableFactor >= 0.0500000007;
    float isSkinMaskEnabled = tempBool1 ? 1.0 : float(0.0);
    float skinMaskValue = maskSample.y;
    float finalSkinMask = isSkinMaskEnabled * skinMaskValue;
    
    float3 colorA = cb4[62].xyz;
    float3 colorB = cb4[61].xyz;
    float3 shadeFactorBlendedColor = lerp(colorA, colorB, finalShadeFactor);
    
    // 使用皮肤遮罩在 ramp 颜色和基础混合色之间插值
    float3 finalColor = lerp(shadeFactorBlendedColor, rampedColor, finalSkinMask);
    
    // --- 7. 调整饱和度 ---
    float luma = dot(finalColor.xyz, float3(0.300000012, 0.589999974, 0.109999999));
    float3 desaturatedColor = float3(luma, luma, luma);
    float saturation = cb4[86].x;
    float3 finalSaturatedColor = lerp(finalColor, desaturatedColor, saturation);
    
    // --- 8. 输出到G-Buffer ---
    int branchCondition = int(cb0[249].x);
    tempBool1 = branchCondition == 1;
    if (tempBool1) {
        finalSaturatedColor = finalSaturatedColor;
        finalSaturatedColor = clamp(finalSaturatedColor, 0.0, 1.0);
        // 对颜色进行伽马校正(Linear -> sRGB)并输出
        OUT.o0_GI.xyz = sqrt(finalSaturatedColor.xyz);
        
        // 打包材质数据到w通道
        float packedDataInput = cb2[23].w;
        tempUint1 = asuint(packedDataInput);
        {
            uint mask = ~(((1u << 3) - 1) << 5); // 清空 bits 5,6,7
            // 将输入数据的低3位移动到5,6,7位，并与一个常量(12)合并
            tempUint1 = (12u & mask) | ((tempUint1 & 7u) << 5);
        }
        float packedDataOutput = asfloat(tempUint1);
        OUT.o0_GI.w = packedDataOutput * 0.00392156886; // 1.0/255.0
    }
    else {
        // 这段逻辑与if分支完全相同，为保持字节级一致性而保留
        finalSaturatedColor = finalSaturatedColor;
        finalSaturatedColor = clamp(finalSaturatedColor, 0.0, 1.0);
        OUT.o0_GI.xyz = sqrt(finalSaturatedColor.xyz);

        float packedDataInput = cb2[23].w;
        tempUint0 = asuint(packedDataInput);
        {
            uint mask = ~(((1u << 3) - 1) << 5);
            tempUint0 = (12u & mask) | ((tempUint0 & 7u) << 5);
        }
        float packedDataOutput = asfloat(tempUint0);
        OUT.o0_GI.w = packedDataOutput * 0.00392156886;
    }
    
    // 初始化其他G-Buffer目标
    OUT.o1_Normal_Diffuse_FaceSDFMask = float4(0.0, 0.0, 0.0, 0.0);
    OUT.o2_ShadowColor_PackShadeMode_OutputMask = float4(0.0, 0.0, 0.0, 0.0);
    OUT.o3_BaseColor_ToonSkinMask = float4(0.0, 0.0, 0.0, 0.0);
    OUT.o4 = float4(0.0, 0.0, 0.0, 0.0);
    OUT.o5_RimDepth = float4(0.0, 0.0, 0.0, 0.0);
    OUT.o6_rimStrength_HSVPack_groundSpec_charRegion = float4(0.0, 0.0, 0.0, 0.0);
    OUT.o0_GI = pow(OUT.o0_GI, 5);
    
    return OUT;
}
            ENDHLSL
        }
    }
}