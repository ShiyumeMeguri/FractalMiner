// 给我最小修改 根据代码实际逻辑推断出所有变量正确名字 保证代码完全等价的情况下 重构为更易读的形式 Properties和sampler2D和cb的名字不要改 不准省略任何代码
Shader "Custom/WWToon"
{
    Properties
    {
        // Properties block is unchanged as requested
        _IN0("IN0", 2D) = "white" {}
        _IN1("IN1", 2D) = "white" {}
        _IN2("IN2", 2D) = "white" {}
        _IN3("IN3", 2D) = "white" {}
        _IN4("IN4", 2D) = "white" {}
        _IN5("IN5", 2D) = "white" {}
        _IN6("IN6", 2D) = "white" {}
        _IN7("IN7", 2D) = "white" {}
        _IN8("IN8", 2D) = "white" {}
        _IN9("IN9", 2D) = "white" {}
    }

    SubShader
    {
        Pass
        {
            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct VertexInput
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct VertexToFragment
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            
            // Texture inputs renamed based on known data
            sampler2D _IN0; // IN0: Depth+Stencil
            sampler2D _IN1;           // IN1: Normals
            sampler2D _IN2;         // IN2: Material Properties (deduced)
            sampler2D _IN3;           // IN3: Albedo+Alpha
            sampler2D _IN4;           // IN4: Unknown custom data
            sampler2D _IN5;           // IN5: Unknown custom data
            sampler2D _IN6;     // IN6: R16 Depth
            sampler2D _IN7;          // IN7: 1x1 all zero
            sampler2D _IN8; // IN8: SSAO
            sampler2D _IN9;    // IN9: 1x1 global constants

            // Corresponding texture transform variables
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

            VertexToFragment vert (VertexInput vertexInput)
            {
                VertexToFragment output;
                output.vertex = UnityObjectToClipPos(vertexInput.vertex);
                output.uv = vertexInput.uv;
                return output;
            }
            
            StructuredBuffer<float4> cb0;
            StructuredBuffer<float4> cb1;
            StructuredBuffer<float4> cb2;
            
            // 已知 IN0 是深度+Stencil 
            // 已知 IN1 XYZ是法线 A未知
            // 未知 IN2 
            // 已知 IN3 是Albedo和Alpha
            // 未知 IN4
            // 未知 IN5
            // 已知 IN6 R16深度
            // 已知 IN7 1x1像素 全0
            // 已知 IN8 MSSAO
            // 已知 IN9 1x1像素 R32G32B32A32 值看上去是 1.0 0.98065 0.07967 0.43407
            
            fixed4 frag (VertexToFragment fragmentInput) : SV_Target
            {
                // Based on input uv, define screenUV, providing default values for zw components
                float4 screenUV = float4(fragmentInput.uv.xy, 0.0, 0.0); 

                float4 finalColor = 0;
                
                // Temporary registers renamed for clarity. Due to heavy reuse (common in compiled shaders),
                // names reflect their initial or most significant role.
                float4 packedNormalAndMiscData, materialAndWorldNormal, albedoAndDepth, shadingParams1, shadingInfo, shadingParams2, worldPosAndNormal, lightingTempA, lightingTempB, lightingTempC, accumulatedLightColor, lightLoopTempA, lightLoopTempB, lightLoopTempC, lightLoopTempD, lightLoopTempE, lightLoopTempF;
                uint4 bitmask, uiDest;
                float4 fDest;

                packedNormalAndMiscData.xyzw = tex2Dlod(_IN1, float4(screenUV.xy, 0, 0)).wxyz;
                materialAndWorldNormal.xyzw = tex2Dlod(_IN2, float4(screenUV.xy, 0, 0)).xyzw;
                albedoAndDepth.xyz = tex2Dlod(_IN3, float4(screenUV.xy, 0, 0)).xyz;
                shadingParams1.xyz = tex2Dlod(_IN4, float4(screenUV.xy, 0, 0)).yxz;
                albedoAndDepth.w = tex2Dlod(_IN0, float4(screenUV.xy, 0, 0)).x;
                shadingParams1.w = albedoAndDepth.w * cb1[65].x + cb1[65].y;
                albedoAndDepth.w = albedoAndDepth.w * cb1[65].z + -cb1[65].w;
                albedoAndDepth.w = 1 / albedoAndDepth.w;
                albedoAndDepth.w = shadingParams1.w + albedoAndDepth.w;
                shadingInfo.xy = cb1[138].xy * screenUV.xy;
                shadingInfo.xy = (uint2)shadingInfo.xy;
                shadingParams1.w = (uint)cb1[158].x;
                shadingInfo.x = (int)shadingInfo.y + (int)shadingInfo.x;
                shadingParams1.w = (int)shadingParams1.w + (int)shadingInfo.x;
                shadingParams1.w = (int)shadingParams1.w & 1;
                materialAndWorldNormal.w = 255 * materialAndWorldNormal.w;
                materialAndWorldNormal.w = round(materialAndWorldNormal.w);
                materialAndWorldNormal.w = (uint)materialAndWorldNormal.w;
                shadingInfo.xy = (int2)materialAndWorldNormal.ww & int2(15,-16);
                materialAndWorldNormal.w = ((int)shadingInfo.x != 12) ? 1.0 : 0.0;
                shadingParams2.xyz = ((int3)shadingInfo.xxx == int3(13,14,15)) ? 1.0 : 0.0;
                shadingInfo.z = (int)shadingParams2.z | (int)shadingParams2.y;
                shadingInfo.z = (int)shadingInfo.z | (int)shadingParams2.x;
                materialAndWorldNormal.w = materialAndWorldNormal.w ? shadingInfo.z : -1;
                if (materialAndWorldNormal.w != 0) {
                    shadingInfo.x = shadingParams2.x ? 13 : 12;
                    shadingParams2.xz = shadingParams2.yz ? float2(1,1) : 0;
                    shadingInfo.zw = packedNormalAndMiscData.yz * float2(2,2) + float2(-1,-1);
                    materialAndWorldNormal.w = dot(float2(1,1), abs(shadingInfo.zw));
                    worldPosAndNormal.z = 1 + -materialAndWorldNormal.w;
                    materialAndWorldNormal.w = max(0, -worldPosAndNormal.z);
                    lightingTempA.xy = (shadingInfo.zw >= float2(0,0)) ? 1.0 : 0.0;
                    lightingTempA.xy = lightingTempA.xy ? float2(0.5,0.5) : float2(-0.5,-0.5);
                    lightingTempA.xy = lightingTempA.xy * materialAndWorldNormal.ww;
                    worldPosAndNormal.xy = lightingTempA.xy * float2(-2,-2) + shadingInfo.zw;
                    materialAndWorldNormal.w = dot(worldPosAndNormal.xyz, worldPosAndNormal.xyz);
                    materialAndWorldNormal.w = rsqrt(materialAndWorldNormal.w);
                    worldPosAndNormal.xyz = worldPosAndNormal.xyz * materialAndWorldNormal.www;
                    lightingTempA.xyz = materialAndWorldNormal.xyz * materialAndWorldNormal.xyz;
                    shadingParams2.y = shadingParams1.z;
                } else {
                    materialAndWorldNormal.w = ((int)shadingInfo.x == 10) ? 1.0 : 0.0;
                    materialAndWorldNormal.xyz = saturate(materialAndWorldNormal.xyz);
                    materialAndWorldNormal.xyz = float3(16777215,65535,255) * materialAndWorldNormal.xyz;
                    materialAndWorldNormal.xyz = round(materialAndWorldNormal.xyz);
                    materialAndWorldNormal.xyz = (uint3)materialAndWorldNormal.xyz;
                    bitmask.y = ((~(-1 << 8)) << 0) & 0xffffffff;  materialAndWorldNormal.y = (((uint)materialAndWorldNormal.z << 0) & bitmask.y) | ((uint)materialAndWorldNormal.y & ~bitmask.y);
                    bitmask.x = ((~(-1 << 16)) << 0) & 0xffffffff;  materialAndWorldNormal.x = (((uint)materialAndWorldNormal.y << 0) & bitmask.x) | ((uint)materialAndWorldNormal.x & ~bitmask.x);
                    materialAndWorldNormal.x = (uint)materialAndWorldNormal.x;
                    materialAndWorldNormal.x = 5.96046519e-008 * materialAndWorldNormal.x;
                    materialAndWorldNormal.y = materialAndWorldNormal.x * cb1[65].x + cb1[65].y;
                    materialAndWorldNormal.x = materialAndWorldNormal.x * cb1[65].z + -cb1[65].w;
                    materialAndWorldNormal.x = 1 / materialAndWorldNormal.x;
                    materialAndWorldNormal.x = materialAndWorldNormal.y + materialAndWorldNormal.x;
                    albedoAndDepth.w = materialAndWorldNormal.w ? materialAndWorldNormal.x : albedoAndDepth.w;
                    worldPosAndNormal.xyz = packedNormalAndMiscData.yzw * float3(2,2,2) + float3(-1,-1,-1);
                    lightingTempA.xyz = float3(0,0,0);
                    shadingParams2.xyz = float3(0,0,0);
                    packedNormalAndMiscData.xw = float2(0,0);
                    shadingParams1.xy = float2(0,0);
                }
                packedNormalAndMiscData.y = dot(worldPosAndNormal.xyz, worldPosAndNormal.xyz);
                packedNormalAndMiscData.y = rsqrt(packedNormalAndMiscData.y);
                materialAndWorldNormal.xyz = worldPosAndNormal.xyz * packedNormalAndMiscData.yyy;
                packedNormalAndMiscData.yz = ((int2)shadingInfo.xx == int2(5,13)) ? 1.0 : 0.0;
                materialAndWorldNormal.w = (0 < cb1[162].y) ? 1.0 : 0.0;
                shadingInfo.z = (0 < cb1[220].z) ? 1.0 : 0.0;
                materialAndWorldNormal.w = materialAndWorldNormal.w ? shadingInfo.z : 0;
                shadingInfo.z = (0 != cb1[162].y) ? 1.0 : 0.0;
                worldPosAndNormal.xyz = shadingInfo.zzz ? float3(1,1,1) : albedoAndDepth.xyz;
                shadingParams1.w = shadingParams1.w ? 1 : 0;
                worldPosAndNormal.xyz = materialAndWorldNormal.www ? shadingParams1.www : worldPosAndNormal.xyz;
                albedoAndDepth.xyz = packedNormalAndMiscData.yyy ? worldPosAndNormal.xyz : albedoAndDepth.xyz;
                packedNormalAndMiscData.y = tex2Dlod(_IN9, float4(0, 0, 0, 0)).x;
                shadingInfo.zw = screenUV.zw * albedoAndDepth.ww; // This will be 0 due to screenUV.zw initialization
                worldPosAndNormal.xyz = cb1[49].xyz * shadingInfo.www;
                worldPosAndNormal.xyz = shadingInfo.zzz * cb1[48].xyz + worldPosAndNormal.xyz;
                worldPosAndNormal.xyz = albedoAndDepth.www * cb1[50].xyz + worldPosAndNormal.xyz;
                worldPosAndNormal.xyz = cb1[51].xyz + worldPosAndNormal.xyz;
                shadingInfo.zw = tex2Dlod(_IN5, float4(screenUV.xy, 0, 0)).xz;
                shadingInfo.zw = shadingInfo.zw * shadingInfo.zw;
                materialAndWorldNormal.w = shadingInfo.z * shadingInfo.w;
                shadingParams1.w = cb1[253].y * materialAndWorldNormal.w;
                if (cb1[255].x != 0) {
                    lightingTempB.xyz = float3(0,0,0);
                    shadingInfo.zw = float2(0,0);
                    shadingParams2.w = 0;
                    worldPosAndNormal.w = 0;
                    while (true) {
                    lightingTempA.w = ((int)shadingInfo.z >= 3) ? 1.0 : 0.0;
                    if (lightingTempA.w != 0) break;
                    shadingInfo.w = 0.000833333295 + shadingInfo.w;
                    lightingTempC.xyz = lightingTempB.xyz;
                    lightingTempA.w = shadingParams2.w;
                    lightingTempB.w = worldPosAndNormal.w;
                    lightingTempC.w = 0;
                    while (true) {
                        accumulatedLightColor.x = ((int)lightingTempC.w >= 3) ? 1.0 : 0.0;
                        if (accumulatedLightColor.x != 0) break;
                        lightingTempA.w = 1 + lightingTempA.w;
                        accumulatedLightColor.x = 2.09439516 * lightingTempA.w;
                        sincos(accumulatedLightColor.x, accumulatedLightColor.x, lightLoopTempA.x);
                        lightLoopTempA.x = lightLoopTempA.x * shadingInfo.w + screenUV.x;
                        lightLoopTempA.y = accumulatedLightColor.x * shadingInfo.w + screenUV.y;
                        accumulatedLightColor.xyz = tex2D(_IN7, lightLoopTempA.xy).xyz;
                        lightingTempC.xyz = accumulatedLightColor.xyz * shadingInfo.www + lightingTempC.xyz;
                        lightingTempB.w = lightingTempB.w + shadingInfo.w;
                        lightingTempC.w = (int)lightingTempC.w + 1;
                    }
                    lightingTempB.xyz = lightingTempC.xyz;
                    worldPosAndNormal.w = lightingTempB.w;
                    shadingParams2.w = 0.620000005 + lightingTempA.w;
                    shadingInfo.z = (int)shadingInfo.z + 1;
                    }
                    lightingTempB.xyz = lightingTempB.xyz / worldPosAndNormal.www;
                    lightingTempC.xyz = (float3(0.644999981,0.312000006,0.978999972) < packedNormalAndMiscData.xxx) ? 1.0 : 0.0;
                    accumulatedLightColor.xyz = (packedNormalAndMiscData.xxx < float3(0.685000002,0.351999998,1.02100003)) ? 1.0 : 0.0;
                    lightingTempC.xyz = lightingTempC.xyz ? accumulatedLightColor.xyz : 0;
                    packedNormalAndMiscData.x = lightingTempC.z ? 1.000000 : 0;
                    packedNormalAndMiscData.x = lightingTempC.y ? 0 : packedNormalAndMiscData.x;
                    packedNormalAndMiscData.x = lightingTempC.x ? 1 : packedNormalAndMiscData.x;
                    shadingInfo.z = (int)lightingTempC.y | (int)lightingTempC.z;
                    shadingInfo.z = (int)shadingInfo.z & 0x3f800000;
                    shadingInfo.z = lightingTempC.x ? 0 : shadingInfo.z;
                    shadingParams1.x = 255 * shadingParams1.x;
                    shadingParams1.x = round(shadingParams1.x);
                    shadingParams1.x = (uint)shadingParams1.x;
                    lightingTempC.xyzw = (int4)shadingParams1.xxxx & int4(15,240,240,15);
                    lightingTempC.xyzw = (uint4)lightingTempC.xyzw;
                    shadingParams1.x = saturate(packedNormalAndMiscData.w + packedNormalAndMiscData.w);
                    shadingInfo.w = shadingParams1.x * -2 + 3;
                    shadingParams1.x = shadingParams1.x * shadingParams1.x;
                    shadingParams1.x = shadingInfo.w * shadingParams1.x;
                    shadingInfo.w = -0.5 + packedNormalAndMiscData.w;
                    shadingInfo.w = saturate(shadingInfo.w + shadingInfo.w);
                    shadingParams2.w = shadingInfo.w * -2 + 3;
                    shadingInfo.w = shadingInfo.w * shadingInfo.w;
                    shadingInfo.w = shadingParams2.w * shadingInfo.w;
                    accumulatedLightColor.xyz = cb1[262].xyz + -cb1[261].xyz;
                    shadingParams2.w = dot(abs(accumulatedLightColor.xyz), float3(0.300000012,0.589999974,0.109999999));
                    shadingParams2.w = 10 * shadingParams2.w;
                    shadingParams2.w = min(1, shadingParams2.w);
                    worldPosAndNormal.w = shadingParams2.w * -2 + 3;
                    shadingParams2.w = shadingParams2.w * shadingParams2.w;
                    shadingParams2.w = worldPosAndNormal.w * shadingParams2.w;
                    worldPosAndNormal.w = shadingParams2.w * shadingInfo.w;
                    lightingTempA.w = cb1[265].y + -cb1[265].x;
                    lightingTempB.w = materialAndWorldNormal.w * cb1[253].y + -cb1[265].x;
                    lightingTempA.w = 1 / lightingTempA.w;
                    lightingTempB.w = saturate(lightingTempB.w * lightingTempA.w);
                    accumulatedLightColor.x = lightingTempB.w * -2 + 3;
                    lightingTempB.w = lightingTempB.w * lightingTempB.w;
                    lightingTempB.w = accumulatedLightColor.x * lightingTempB.w;
                    lightingTempB.w = lightingTempB.w * worldPosAndNormal.w;
                    accumulatedLightColor.x = materialAndWorldNormal.w * cb1[253].y + -lightingTempB.w;
                    lightingTempB.w = cb1[265].z * accumulatedLightColor.x + lightingTempB.w;
                    accumulatedLightColor.x = -cb1[265].x + lightingTempB.w;
                    lightingTempA.w = saturate(accumulatedLightColor.x * lightingTempA.w);
                    accumulatedLightColor.x = lightingTempA.w * -2 + 3;
                    lightingTempA.w = lightingTempA.w * lightingTempA.w;
                    lightingTempA.w = accumulatedLightColor.x * lightingTempA.w;
                    worldPosAndNormal.w = lightingTempA.w * worldPosAndNormal.w;
                    shadingInfo.w = shadingInfo.w * shadingParams2.w + -worldPosAndNormal.w;
                    shadingInfo.w = cb1[265].z * shadingInfo.w + worldPosAndNormal.w;
                    shadingParams2.w = -1 + lightingTempB.w;
                    shadingParams2.w = cb1[260].y * shadingParams2.w + 1;
                    worldPosAndNormal.w = shadingParams1.w * shadingInfo.w + -shadingParams2.w;
                    shadingParams2.w = shadingParams2.x * worldPosAndNormal.w + shadingParams2.w;
                    worldPosAndNormal.w = shadingParams1.w * shadingInfo.w + -shadingInfo.w;
                    accumulatedLightColor.x = shadingParams2.x * worldPosAndNormal.w + shadingInfo.w;
                    shadingInfo.w = (lightingTempB.y >= lightingTempB.z) ? 1.0 : 0.0;
                    shadingInfo.w = shadingInfo.w ? 1.000000 : 0;
                    lightLoopTempA.xy = lightingTempB.zy;
                    lightLoopTempA.zw = float2(-1,0.666666687);
                    lightLoopTempB.xy = -lightLoopTempA.xy + lightingTempB.yz;
                    lightLoopTempB.zw = float2(1,-1);
                    lightLoopTempA.xyzw = shadingInfo.wwww * lightLoopTempB.xyzw + lightLoopTempA.xyzw;
                    shadingInfo.w = (lightingTempB.x >= lightLoopTempA.x) ? 1.0 : 0.0;
                    shadingInfo.w = shadingInfo.w ? 1.000000 : 0;
                    lightLoopTempB.xyz = lightLoopTempA.xyw;
                    lightLoopTempB.w = lightingTempB.x;
                    lightLoopTempA.xyw = lightLoopTempB.wyx;
                    lightLoopTempA.xyzw = lightLoopTempA.xyzw + -lightLoopTempB.xyzw;
                    lightLoopTempA.xyzw = shadingInfo.wwww * lightLoopTempA.xyzw + lightLoopTempB.xyzw;
                    shadingInfo.w = min(lightLoopTempA.w, lightLoopTempA.y);
                    shadingInfo.w = lightLoopTempA.x + -shadingInfo.w;
                    worldPosAndNormal.w = lightLoopTempA.w + -lightLoopTempA.y;
                    lightingTempA.w = shadingInfo.w * 6 + 0.00100000005;
                    worldPosAndNormal.w = worldPosAndNormal.w / lightingTempA.w;
                    worldPosAndNormal.w = lightLoopTempA.z + worldPosAndNormal.w;
                    lightingTempA.w = 0.00100000005 + lightLoopTempA.x;
                    shadingInfo.w = shadingInfo.w / lightingTempA.w;
                    lightingTempA.w = lightLoopTempA.x * 0.300000012 + 1;
                    lightLoopTempA.xyzw = lightingTempC.xyzw * float4(0.0400000028,0.0027450982,0.00392156886,0.0666666701) + float4(0.400000006,0.400000006,1,0.5);
                    lightingTempB.w = (lightingTempC.z >= 2.54999971) ? 1.0 : 0.0;
                    lightingTempB.w = lightingTempB.w ? 1.000000 : 0;
                    lightingTempC.x = lightLoopTempA.y + -lightLoopTempA.x;
                    lightingTempC.x = lightingTempB.w * lightingTempC.x + lightLoopTempA.x;
                    shadingInfo.w = lightingTempC.x * shadingInfo.w;
                    shadingInfo.w = min(0.349999994, shadingInfo.w);
                    lightingTempC.x = max(0, shadingInfo.w);
                    lightingTempC.yzw = float3(1,0.666666687,0.333333343) + abs(worldPosAndNormal.www);
                    lightingTempC.yzw = frac(lightingTempC.yzw);
                    lightingTempC.yzw = lightingTempC.yzw * float3(6,6,6) + float3(-3,-3,-3);
                    lightingTempC.yzw = saturate(float3(-1,-1,-1) + abs(lightingTempC.yzw));
                    lightingTempC.yzw = float3(-1,-1,-1) + lightingTempC.yzw;
                    lightingTempC.xyz = lightingTempC.xxx * lightingTempC.yzw + float3(1,1,1);
                    shadingInfo.w = 1 + shadingInfo.w;
                    lightLoopTempB.xyz = lightingTempC.xyz * shadingInfo.www;
                    lightLoopTempC.xyz = lightingTempC.xyz * shadingInfo.www + float3(-1,-1,-1);
                    lightLoopTempC.xyz = lightLoopTempC.xyz * float3(0.600000024,0.600000024,0.600000024) + float3(1,1,1);
                    lightingTempC.xyz = -lightingTempC.xyz * shadingInfo.www + lightLoopTempC.xyz;
                    lightingTempC.xyz = packedNormalAndMiscData.xxx * lightingTempC.xyz + lightLoopTempB.xyz;
                    lightLoopTempB.xyz = lightingTempC.xyz + -albedoAndDepth.xyz;
                    lightLoopTempB.xyz = lightLoopTempB.xyz * float3(0.850000024,0.850000024,0.850000024) + albedoAndDepth.xyz;
                    lightLoopTempA.xyz = lightLoopTempA.zzz * lightLoopTempB.xyz + -lightingTempC.xyz;
                    lightingTempC.xyz = lightingTempB.www * lightLoopTempA.xyz + lightingTempC.xyz;
                    lightingTempC.xyz = float3(-1,-1,-1) + lightingTempC.xyz;
                    lightingTempC.xyz = lightLoopTempA.www * lightingTempC.xyz + float3(1,1,1);
                    lightLoopTempA.xyz = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
                    lightLoopTempB.xyz = cb1[262].xyz * float3(0.5,0.5,0.5) + -lightLoopTempA.xyz;
                    lightLoopTempA.xyz = shadingParams2.www * lightLoopTempB.xyz + lightLoopTempA.xyz;
                    lightLoopTempA.xyz = cb1[260].xxx * lightLoopTempA.xyz;
                    lightLoopTempA.xyz = lightLoopTempA.xyz * albedoAndDepth.xyz;
                    lightLoopTempB.xyz = lightLoopTempA.xyz * lightingTempA.xyz;
                    lightLoopTempC.xyz = cb1[261].xyz * albedoAndDepth.xyz;
                    packedNormalAndMiscData.x = shadingParams1.x * 0.300000012 + 0.699999988;
                    lightLoopTempD.xyz = lightLoopTempC.xyz * packedNormalAndMiscData.xxx;
                    lightLoopTempE.xyz = cb1[262].xyz * albedoAndDepth.xyz;
                    lightLoopTempB.xyz = lightLoopTempC.xyz * packedNormalAndMiscData.xxx + lightLoopTempB.xyz;
                    lightLoopTempC.xyz = albedoAndDepth.xyz * cb1[262].xyz + -lightLoopTempD.xyz;
                    lightLoopTempC.xyz = lightLoopTempC.xyz * float3(0.400000006,0.400000006,0.400000006) + lightLoopTempD.xyz;
                    lightLoopTempF.xyz = lightLoopTempD.xyz * lightingTempC.xyz;
                    lightLoopTempC.xyz = lightLoopTempC.xyz * lightingTempC.xyz + -lightLoopTempF.xyz;
                    lightLoopTempC.xyz = accumulatedLightColor.xxx * lightLoopTempC.xyz + lightLoopTempF.xyz;
                    lightLoopTempA.xyz = lightLoopTempA.xyz * lightingTempA.xyz + lightLoopTempC.xyz;
                    lightLoopTempB.xyz = lightLoopTempB.xyz * lightingTempC.xyz;
                    lightLoopTempC.xyz = lightLoopTempE.xyz * lightingTempA.www;
                    lightingTempC.xyz = lightLoopTempC.xyz * lightingTempC.xyz + -lightLoopTempB.xyz;
                    lightingTempC.xyz = accumulatedLightColor.xxx * lightingTempC.xyz + lightLoopTempB.xyz;
                    packedNormalAndMiscData.x = tex2Dlod(_IN8, float4(screenUV.xy, 0, 0)).x;
                    packedNormalAndMiscData.x = -1 + packedNormalAndMiscData.x;
                    packedNormalAndMiscData.x = shadingInfo.z * packedNormalAndMiscData.x + 1;
                    lightingTempC.xyz = lightingTempC.xyz + -lightLoopTempA.xyz;
                    lightingTempC.xyz = shadingParams2.www * lightingTempC.xyz + lightLoopTempA.xyz;
                    lightLoopTempA.xyz = float3(1,1,1) + -lightingTempB.xyz;
                    lightingTempB.xyz = packedNormalAndMiscData.xxx * lightLoopTempA.xyz + lightingTempB.xyz;
                    lightingTempB.xyz = lightingTempC.xyz * lightingTempB.xyz;
                } else {
                    packedNormalAndMiscData.x = saturate(packedNormalAndMiscData.w + packedNormalAndMiscData.w);
                    shadingParams1.x = packedNormalAndMiscData.x * -2 + 3;
                    packedNormalAndMiscData.x = packedNormalAndMiscData.x * packedNormalAndMiscData.x;
                    packedNormalAndMiscData.x = shadingParams1.x * packedNormalAndMiscData.x;
                    shadingParams1.x = -0.5 + packedNormalAndMiscData.w;
                    shadingParams1.x = saturate(shadingParams1.x + shadingParams1.x);
                    shadingInfo.z = shadingParams1.x * -2 + 3;
                    shadingParams1.x = shadingParams1.x * shadingParams1.x;
                    shadingParams1.x = shadingInfo.z * shadingParams1.x;
                    lightingTempC.xyz = cb1[262].xyz + -cb1[261].xyz;
                    shadingInfo.z = dot(abs(lightingTempC.xyz), float3(0.300000012,0.589999974,0.109999999));
                    shadingInfo.z = 10 * shadingInfo.z;
                    shadingInfo.z = min(1, shadingInfo.z);
                    shadingInfo.w = shadingInfo.z * -2 + 3;
                    shadingInfo.z = shadingInfo.z * shadingInfo.z;
                    shadingInfo.z = shadingInfo.w * shadingInfo.z;
                    shadingInfo.w = shadingInfo.z * shadingParams1.x;
                    shadingParams2.w = cb1[265].y + -cb1[265].x;
                    worldPosAndNormal.w = materialAndWorldNormal.w * cb1[253].y + -cb1[265].x;
                    shadingParams2.w = 1 / shadingParams2.w;
                    worldPosAndNormal.w = saturate(worldPosAndNormal.w * shadingParams2.w);
                    lightingTempA.w = worldPosAndNormal.w * -2 + 3;
                    worldPosAndNormal.w = worldPosAndNormal.w * worldPosAndNormal.w;
                    worldPosAndNormal.w = lightingTempA.w * worldPosAndNormal.w;
                    worldPosAndNormal.w = worldPosAndNormal.w * shadingInfo.w;
                    materialAndWorldNormal.w = materialAndWorldNormal.w * cb1[253].y + -worldPosAndNormal.w;
                    materialAndWorldNormal.w = cb1[265].z * materialAndWorldNormal.w + worldPosAndNormal.w;
                    worldPosAndNormal.w = -cb1[265].x + materialAndWorldNormal.w;
                    shadingParams2.w = saturate(worldPosAndNormal.w * shadingParams2.w);
                    worldPosAndNormal.w = shadingParams2.w * -2 + 3;
                    shadingParams2.w = shadingParams2.w * shadingParams2.w;
                    shadingParams2.w = worldPosAndNormal.w * shadingParams2.w;
                    shadingInfo.w = shadingParams2.w * shadingInfo.w;
                    shadingParams1.x = shadingParams1.x * shadingInfo.z + -shadingInfo.w;
                    shadingParams1.x = cb1[265].z * shadingParams1.x + shadingInfo.w;
                    shadingInfo.z = materialAndWorldNormal.w * shadingParams2.y;
                    shadingInfo.z = 10 * shadingInfo.z;
                    materialAndWorldNormal.w = -1 + materialAndWorldNormal.w;
                    materialAndWorldNormal.w = cb1[260].y * materialAndWorldNormal.w + 1;
                    shadingInfo.w = shadingParams1.w * shadingParams1.x + -materialAndWorldNormal.w;
                    materialAndWorldNormal.w = shadingParams2.x * shadingInfo.w + materialAndWorldNormal.w;
                    shadingInfo.w = shadingParams1.w * shadingParams1.x + -shadingParams1.x;
                    accumulatedLightColor.x = shadingParams2.x * shadingInfo.w + shadingParams1.x;
                    shadingParams2.xyw = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
                    lightingTempC.xyz = cb1[262].xyz * float3(0.5,0.5,0.5) + -shadingParams2.xyw;
                    shadingParams2.xyw = materialAndWorldNormal.www * lightingTempC.xyz + shadingParams2.xyw;
                    shadingParams2.xyw = cb1[260].xxx * shadingParams2.xyw;
                    shadingParams2.xyw = shadingParams2.xyw * albedoAndDepth.xyz;
                    lightingTempC.xyz = shadingParams2.xyw * lightingTempA.xyz;
                    lightLoopTempA.xyz = cb1[261].xyz * albedoAndDepth.xyz;
                    packedNormalAndMiscData.x = packedNormalAndMiscData.x * 0.300000012 + 0.699999988;
                    lightLoopTempD.xyz = lightLoopTempA.xyz * packedNormalAndMiscData.xxx;
                    lightLoopTempA.xyz = lightLoopTempA.xyz * packedNormalAndMiscData.xxx + lightingTempC.xyz;
                    lightingTempC.xyz = lightingTempC.xyz * shadingInfo.zzz + lightLoopTempA.xyz;
                    lightLoopTempA.xyz = albedoAndDepth.xyz * cb1[262].xyz + -lightLoopTempD.xyz;
                    lightLoopTempA.xyz = lightLoopTempA.xyz * accumulatedLightColor.xxx;
                    lightLoopTempA.xyz = lightLoopTempA.xyz * float3(0.400000006,0.400000006,0.400000006) + lightLoopTempD.xyz;
                    shadingParams2.xyw = shadingParams2.xyw * lightingTempA.xyz + lightLoopTempA.xyz;
                    lightLoopTempA.xyz = albedoAndDepth.xyz * cb1[262].xyz + -lightingTempC.xyz;
                    lightingTempC.xyz = accumulatedLightColor.xxx * lightLoopTempA.xyz + lightingTempC.xyz;
                    lightingTempC.xyz = lightingTempC.xyz + -shadingParams2.xyw;
                    lightingTempB.xyz = materialAndWorldNormal.www * lightingTempC.xyz + shadingParams2.xyw;
                }
                packedNormalAndMiscData.x = -0.400000006 + packedNormalAndMiscData.w;
                packedNormalAndMiscData.x = saturate(10.000001 * packedNormalAndMiscData.x);
                packedNormalAndMiscData.w = packedNormalAndMiscData.x * -2 + 3;
                packedNormalAndMiscData.x = packedNormalAndMiscData.x * packedNormalAndMiscData.x;
                accumulatedLightColor.y = packedNormalAndMiscData.w * packedNormalAndMiscData.x;
                shadingParams2.xyw = lightingTempB.xyz * float3(0.5,0.5,0.5) + cb1[261].xyz;
                shadingParams2.xyw = shadingParams2.xyw * albedoAndDepth.xyz;
                lightingTempC.xyz = cb1[261].xyz * albedoAndDepth.xyz;
                shadingParams2.xyw = cb1[255].xxx ? shadingParams2.xyw : lightingTempC.xyz;
                lightingTempC.xyz = packedNormalAndMiscData.zzz ? shadingParams2.xyw : lightLoopTempD.xyz;
                shadingParams2.xyw = packedNormalAndMiscData.zzz ? shadingParams2.xyw : lightingTempB.xyz;
                packedNormalAndMiscData.xw = packedNormalAndMiscData.zz ? float2(0,0) : accumulatedLightColor.xy;
                lightingTempB.xyz = cb1[264].xyz + cb1[264].xyz;
                lightingTempB.xyz = packedNormalAndMiscData.xxx * lightingTempB.xyz + -cb1[264].xyz;
                accumulatedLightColor.xyz = float3(0,0,0);
                materialAndWorldNormal.w = 1;
                shadingParams1.x = 0;
                while (true) {
                    shadingInfo.z = ((uint)shadingParams1.x >= asuint(cb2[128].x)) ? 1.0 : 0.0;
                    if (shadingInfo.z != 0) break;
                    bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  shadingInfo.z = (((uint)shadingParams1.x << 3) & bitmask.z) | ((uint)7 & ~bitmask.z);
                    bitmask.w = ((~(-1 << 3)) << 5) & 0xffffffff;  shadingInfo.w = (((uint)cb2[shadingInfo.z+0].w << 5) & bitmask.w) | ((uint)0 & ~bitmask.w);
                    shadingInfo.w = (int)shadingInfo.y & (int)shadingInfo.w;
                    if (shadingInfo.w == 0) {
                    shadingInfo.w = (int)shadingParams1.x + 1;
                    shadingParams1.x = shadingInfo.w;
                    continue;
                    }
                    shadingInfo.w = (uint)shadingParams1.x << 3;
                    lightLoopTempA.xyz = cb2[shadingInfo.w+0].xyz + -worldPosAndNormal.xyz;
                    worldPosAndNormal.w = cb2[shadingInfo.w+0].w * cb2[shadingInfo.w+0].w;
                    lightingTempA.w = dot(lightLoopTempA.xyz, lightLoopTempA.xyz);
                    worldPosAndNormal.w = lightingTempA.w * worldPosAndNormal.w;
                    lightingTempB.w = (1 >= worldPosAndNormal.w) ? 1.0 : 0.0;
                    if (lightingTempB.w != 0) {
                    bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  lightLoopTempB.x = (((uint)shadingParams1.x << 3) & bitmask.x) | ((uint)1 & ~bitmask.x);
                    bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  lightLoopTempB.y = (((uint)shadingParams1.x << 3) & bitmask.y) | ((uint)2 & ~bitmask.y);
                    bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  lightLoopTempB.z = (((uint)shadingParams1.x << 3) & bitmask.z) | ((uint)3 & ~bitmask.z);
                    bitmask.w = ((~(-1 << 29)) << 3) & 0xffffffff;  lightLoopTempB.w = (((uint)shadingParams1.x << 3) & bitmask.w) | ((uint)4 & ~bitmask.w);
                    bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  lightLoopTempC.x = (((uint)shadingParams1.x << 3) & bitmask.x) | ((uint)5 & ~bitmask.x);
                    bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  lightLoopTempC.y = (((uint)shadingParams1.x << 3) & bitmask.y) | ((uint)6 & ~bitmask.y);
                    worldPosAndNormal.w = saturate(worldPosAndNormal.w * 2.5 + -1.5);
                    lightingTempB.w = worldPosAndNormal.w * worldPosAndNormal.w;
                    worldPosAndNormal.w = -worldPosAndNormal.w * 2 + 3;
                    worldPosAndNormal.w = -lightingTempB.w * worldPosAndNormal.w + 1;
                    lightingTempA.w = rsqrt(lightingTempA.w);
                    lightLoopTempD.xyz = lightLoopTempA.xyz * lightingTempA.www;
                    lightingTempA.w = dot(materialAndWorldNormal.xyz, lightLoopTempD.xyz);
                    lightingTempA.w = 1 + lightingTempA.w;
                    lightLoopTempC.zw = cb2[lightLoopTempC.x+0].ww * float2(0.939999998,0.0600000024);
                    lightingTempA.w = lightingTempA.w * 0.5 + -lightLoopTempC.z;
                    lightingTempB.w = 1 / lightLoopTempC.w;
                    lightingTempA.w = saturate(lightingTempB.w * lightingTempA.w);
                    lightingTempB.w = lightingTempA.w * -2 + 3;
                    lightingTempA.w = lightingTempA.w * lightingTempA.w;
                    lightingTempA.w = lightingTempB.w * lightingTempA.w;
                    lightingTempA.w = min(1, lightingTempA.w);
                    lightLoopTempE.xyz = cb2[lightLoopTempC.y+0].xyz * lightingTempC.xyz;
                    lightLoopTempC.xzw = albedoAndDepth.xyz * cb2[lightLoopTempC.x+0].xyz + -lightLoopTempE.xyz;
                    lightLoopTempC.xzw = lightingTempA.www * lightLoopTempC.xzw + lightLoopTempE.xyz;
                    lightLoopTempC.xzw = cb2[shadingInfo.z+0].xxx * lightLoopTempC.xzw;
                    lightLoopTempA.xyz = cb2[shadingInfo.w+0].www * lightLoopTempA.xyz;
                    shadingInfo.w = dot(lightLoopTempA.xyz, lightLoopTempA.xyz);
                    shadingInfo.w = shadingInfo.w * cb2[lightLoopTempB.w+0].x + cb2[lightLoopTempB.w+0].y;
                    shadingInfo.w = 9.99999975e-005 + shadingInfo.w;
                    shadingInfo.w = 1 / shadingInfo.w;
                    shadingInfo.w = -1 + shadingInfo.w;
                    shadingInfo.w = cb2[lightLoopTempB.w+0].z * shadingInfo.w;
                    shadingInfo.w = shadingInfo.w * shadingInfo.w;
                    shadingInfo.w = min(1, shadingInfo.w);
                    if (4 == 0) lightingTempA.w = 0; else if (4+16 < 32) {       lightingTempA.w = (uint)cb2[lightLoopTempB.x+0].w << (32-(4 + 16)); lightingTempA.w = (uint)lightingTempA.w >> (32-4);      } else lightingTempA.w = (uint)cb2[lightLoopTempB.x+0].w >> 16;
                    lightingTempA.w = ((int)lightingTempA.w == 2) ? 1.0 : 0.0;
                    lightingTempB.w = dot(lightLoopTempD.xyz, cb2[lightLoopTempB.x+0].xyz);
                    lightingTempB.w = -cb2[lightLoopTempB.y+0].x + lightingTempB.w;
                    lightingTempB.w = saturate(cb2[lightLoopTempB.y+0].y * lightingTempB.w);
                    lightingTempB.w = lightingTempB.w * lightingTempB.w;
                    lightingTempB.w = lightingTempB.w * lightingTempB.w;
                    lightingTempB.w = lightingTempB.w * shadingInfo.w;
                    shadingInfo.w = lightingTempA.w ? lightingTempB.w : shadingInfo.w;
                    lightingTempA.w = dot(lightingTempB.xyz, lightLoopTempD.xyz);
                    lightingTempA.w = saturate(lightingTempA.w * 0.5 + 0.5);
                    lightingTempA.w = packedNormalAndMiscData.w * lightingTempA.w + -packedNormalAndMiscData.x;
                    lightingTempA.w = cb2[lightLoopTempB.w+0].w * lightingTempA.w + packedNormalAndMiscData.x;
                    lightLoopTempA.xyz = cb2[lightLoopTempB.z+0].www * lightingTempC.xyz;
                    lightLoopTempB.xyw = -lightingTempC.xyz * cb2[lightLoopTempB.z+0].www + albedoAndDepth.xyz;
                    lightLoopTempA.xyz = lightingTempA.www * lightLoopTempB.xyw + lightLoopTempA.xyz;
                    lightLoopTempA.xyz = cb2[lightLoopTempB.z+0].xyz * lightLoopTempA.xyz;
                    lightingTempA.w = cb2[lightLoopTempB.z+0].x + cb2[lightLoopTempB.z+0].y;
                    lightingTempA.w = cb2[lightLoopTempB.z+0].z + lightingTempA.w;
                    lightingTempA.w = cb2[shadingInfo.z+0].x + lightingTempA.w;
                    lightingTempA.w = saturate(10 * lightingTempA.w);
                    shadingInfo.z = cb2[shadingInfo.z+0].y * lightingTempA.w;
                    lightLoopTempB.xyz = lightLoopTempC.xzw * shadingInfo.www;
                    lightLoopTempA.xyz = lightLoopTempA.xyz * shadingInfo.www + lightLoopTempB.xyz;
                    worldPosAndNormal.w = worldPosAndNormal.w + -shadingInfo.w;
                    shadingInfo.w = cb2[lightLoopTempC.y+0].w * worldPosAndNormal.w + shadingInfo.w;
                    accumulatedLightColor.xyz = lightLoopTempA.xyz * materialAndWorldNormal.www + accumulatedLightColor.xyz;
                    shadingInfo.z = -shadingInfo.w * shadingInfo.z + 1;
                    materialAndWorldNormal.w = shadingInfo.z * materialAndWorldNormal.w;
                    }
                    shadingParams1.x = (int)shadingParams1.x + 1;
                }
                shadingInfo.yzw = materialAndWorldNormal.www * shadingParams2.xyw + accumulatedLightColor.xyz;
                packedNormalAndMiscData.x = ((int)shadingInfo.x != 13) ? 1.0 : 0.0;
                if (packedNormalAndMiscData.x != 0) {
                    packedNormalAndMiscData.x = ((int)shadingInfo.x == 1) ? 1.0 : 0.0;
                    packedNormalAndMiscData.x = packedNormalAndMiscData.x ? shadingParams1.z : shadingParams1.y;
                    shadingParams1.xyz = cb1[67].xyz + -worldPosAndNormal.xyz;
                    packedNormalAndMiscData.w = dot(shadingParams1.xyz, shadingParams1.xyz);
                    packedNormalAndMiscData.w = rsqrt(packedNormalAndMiscData.w);
                    shadingParams1.xyz = shadingParams1.xyz * packedNormalAndMiscData.www;
                    packedNormalAndMiscData.w = saturate(-0.100000001 + packedNormalAndMiscData.x);
                    packedNormalAndMiscData.x = saturate(10 * packedNormalAndMiscData.x);
                    materialAndWorldNormal.w = packedNormalAndMiscData.w * 2000 + 50;
                    shadingInfo.x = packedNormalAndMiscData.w + packedNormalAndMiscData.w;
                    packedNormalAndMiscData.x = cb0[0].x * packedNormalAndMiscData.x;
                    packedNormalAndMiscData.x = packedNormalAndMiscData.x * 0.800000012 + shadingInfo.x;
                    shadingParams2.xyw = cb1[21].xyz * materialAndWorldNormal.yyy;
                    shadingParams2.xyw = materialAndWorldNormal.xxx * cb1[20].xyz + shadingParams2.xyw;
                    shadingParams2.xyw = materialAndWorldNormal.zzz * cb1[22].xyz + shadingParams2.xyw;
                    shadingInfo.x = asint(cb0[0].w);
                    shadingInfo.x = (0.5 < shadingInfo.x) ? 1.0 : 0.0;
                    shadingParams1.xyz = shadingInfo.xxx ? float3(0,0,0) : shadingParams1.xyz;
                    worldPosAndNormal.xy = shadingInfo.xx ? cb0[0].yz : cb1[264].xy;
                    worldPosAndNormal.z = shadingInfo.x ? 0.5 : cb1[264].z;
                    materialAndWorldNormal.xyz = shadingInfo.xxx ? shadingParams2.xyw : materialAndWorldNormal.xyz;
                    shadingInfo.x = dot(worldPosAndNormal.xyz, materialAndWorldNormal.xyz);
                    lightingTempB.xy = float2(0.200000003,1) + shadingInfo.xx;
                    shadingInfo.x = 5 * lightingTempB.x;
                    shadingInfo.x = saturate(shadingInfo.x);
                    shadingParams2.w = shadingInfo.x * -2 + 3;
                    shadingInfo.x = shadingInfo.x * shadingInfo.x;
                    shadingInfo.x = shadingParams2.w * shadingInfo.x;
                    lightingTempB.xzw = worldPosAndNormal.xyz + shadingParams1.xyz;
                    shadingParams2.w = dot(lightingTempB.xzw, lightingTempB.xzw);
                    shadingParams2.w = rsqrt(shadingParams2.w);
                    lightingTempB.xzw = lightingTempB.xzw * shadingParams2.www;
                    shadingParams2.w = saturate(dot(materialAndWorldNormal.xyz, lightingTempB.xzw));
                    shadingParams2.w = shadingParams2.w * shadingParams2.w;
                    shadingParams2.w = shadingParams2.w * -0.800000012 + 1;
                    shadingParams2.w = shadingParams2.w * shadingParams2.w;
                    shadingParams2.w = 3.14159274 * shadingParams2.w;
                    shadingParams2.w = 0.200000003 / shadingParams2.w;
                    shadingParams2.w = shadingParams2.w * shadingParams1.w;
                    worldPosAndNormal.x = dot(worldPosAndNormal.xyz, shadingParams1.xyz);
                    worldPosAndNormal.xy = float2(-0.5,1) + -worldPosAndNormal.xx;
                    worldPosAndNormal.x = saturate(worldPosAndNormal.x + worldPosAndNormal.x);
                    worldPosAndNormal.z = worldPosAndNormal.x * -2 + 3;
                    worldPosAndNormal.x = worldPosAndNormal.x * worldPosAndNormal.x;
                    worldPosAndNormal.x = worldPosAndNormal.z * worldPosAndNormal.x + 1;
                    materialAndWorldNormal.x = saturate(dot(shadingParams1.xyz, materialAndWorldNormal.xyz));
                    materialAndWorldNormal.x = 0.800000012 + -materialAndWorldNormal.x;
                    materialAndWorldNormal.x = max(0, materialAndWorldNormal.x);
                    materialAndWorldNormal.y = max(0, cb1[133].x);
                    materialAndWorldNormal.y = min(1.74532926, materialAndWorldNormal.y);
                    materialAndWorldNormal.xy = float2(1.5,0.572957814) * materialAndWorldNormal.xy;
                    materialAndWorldNormal.z = max(0, albedoAndDepth.w);
                    shadingParams1.xy = min(float2(3000,50), materialAndWorldNormal.zz);
                    shadingParams1.xy = float2(3000,50) + -shadingParams1.xy;
                    shadingParams1.xy = float2(0.00033333333,0.0199999996) * shadingParams1.xy;
                    materialAndWorldNormal.z = shadingParams1.x * shadingParams1.x;
                    materialAndWorldNormal.z = materialAndWorldNormal.z * materialAndWorldNormal.z;
                    materialAndWorldNormal.z = materialAndWorldNormal.z * materialAndWorldNormal.z + shadingParams1.y;
                    materialAndWorldNormal.z = -1 + materialAndWorldNormal.z;
                    materialAndWorldNormal.y = materialAndWorldNormal.y * materialAndWorldNormal.z + 1;
                    materialAndWorldNormal.z = 1 + -materialAndWorldNormal.y;
                    materialAndWorldNormal.y = packedNormalAndMiscData.w * materialAndWorldNormal.z + materialAndWorldNormal.y;
                    materialAndWorldNormal.z = lightingTempB.y * 0.25 + 0.5;
                    materialAndWorldNormal.x = materialAndWorldNormal.z * materialAndWorldNormal.x;
                    materialAndWorldNormal.x = materialAndWorldNormal.x * materialAndWorldNormal.y;
                    materialAndWorldNormal.x = materialAndWorldNormal.x * worldPosAndNormal.x;
                    materialAndWorldNormal.x = 0.00999999978 * materialAndWorldNormal.x;
                    shadingParams1.xy = float2(9.99999975e-005,9.99999975e-005) + shadingParams2.xy;
                    materialAndWorldNormal.z = dot(shadingParams1.xy, shadingParams1.xy);
                    materialAndWorldNormal.z = rsqrt(materialAndWorldNormal.z);
                    shadingParams1.xy = shadingParams1.xy * materialAndWorldNormal.zz;
                    shadingParams1.xy = shadingParams1.xy * packedNormalAndMiscData.xx;
                    shadingParams1.z = shadingParams1.y * materialAndWorldNormal.x;
                    materialAndWorldNormal.y = -0.5;
                    materialAndWorldNormal.xy = shadingParams1.xz * materialAndWorldNormal.xy;
                    packedNormalAndMiscData.x = 0.400000006 * worldPosAndNormal.y;
                    materialAndWorldNormal.z = shadingInfo.x * 0.800000012 + 0.200000003;
                    shadingParams1.x = shadingParams2.w * shadingInfo.x;
                    shadingParams1.x = 1.5 * shadingParams1.x;
                    packedNormalAndMiscData.x = packedNormalAndMiscData.x * materialAndWorldNormal.z + shadingParams1.x;
                    materialAndWorldNormal.z = shadingParams1.w * 0.5 + 0.5;
                    packedNormalAndMiscData.x = materialAndWorldNormal.z * packedNormalAndMiscData.x;
                    shadingParams1.xy = screenUV.xy * cb1[138].xy + -cb1[134].xy;
                    materialAndWorldNormal.xy = shadingParams1.xy * cb1[135].zw + materialAndWorldNormal.xy;
                    materialAndWorldNormal.xy = materialAndWorldNormal.xy * cb1[135].xy + cb1[134].xy;
                    materialAndWorldNormal.xy = cb1[138].zw * materialAndWorldNormal.xy;
                    materialAndWorldNormal.x = tex2D(_IN6, materialAndWorldNormal.xy).x;
                    materialAndWorldNormal.y = materialAndWorldNormal.x * cb1[65].x + cb1[65].y;
                    materialAndWorldNormal.x = materialAndWorldNormal.x * cb1[65].z + -cb1[65].w;
                    materialAndWorldNormal.x = 1 / materialAndWorldNormal.x;
                    materialAndWorldNormal.x = materialAndWorldNormal.y + materialAndWorldNormal.x;
                    materialAndWorldNormal.x = materialAndWorldNormal.x + -albedoAndDepth.w;
                    materialAndWorldNormal.x = max(9.99999975e-005, materialAndWorldNormal.x);
                    packedNormalAndMiscData.w = -packedNormalAndMiscData.w * 1000 + materialAndWorldNormal.x;
                    materialAndWorldNormal.x = 1 / materialAndWorldNormal.w;
                    packedNormalAndMiscData.w = saturate(materialAndWorldNormal.x * packedNormalAndMiscData.w);
                    materialAndWorldNormal.x = packedNormalAndMiscData.w * -2 + 3;
                    packedNormalAndMiscData.w = packedNormalAndMiscData.w * packedNormalAndMiscData.w;
                    packedNormalAndMiscData.w = materialAndWorldNormal.x * packedNormalAndMiscData.w;
                    packedNormalAndMiscData.w = min(1, packedNormalAndMiscData.w);
                    materialAndWorldNormal.x = dot(cb1[263].xyz, float3(0.300000012,0.589999974,0.109999999));
                    materialAndWorldNormal.yzw = cb1[263].xyz + -materialAndWorldNormal.xxx;
                    materialAndWorldNormal.xyz = materialAndWorldNormal.yzw * float3(0.75,0.75,0.75) + materialAndWorldNormal.xxx;
                    shadingParams1.xyz = cb1[263].xyz + -materialAndWorldNormal.xyz;
                    materialAndWorldNormal.xyz = shadingParams1.www * shadingParams1.xyz + materialAndWorldNormal.xyz;
                    materialAndWorldNormal.xyz = materialAndWorldNormal.xyz * packedNormalAndMiscData.xxx;
                    materialAndWorldNormal.xyz = float3(0.100000001,0.100000001,0.100000001) * materialAndWorldNormal.xyz;
                    shadingParams1.xyz = float3(1,1,1) + albedoAndDepth.xyz;
                    shadingParams1.xyz = shadingParams1.xyz * materialAndWorldNormal.xyz;
                    shadingParams2.xyw = albedoAndDepth.xyz * float3(1.20000005,1.20000005,1.20000005) + float3(-1,-1,-1);
                    shadingParams2.xyw = saturate(-shadingParams2.xyw);
                    worldPosAndNormal.xyz = shadingParams2.xyw * float3(-2,-2,-2) + float3(3,3,3);
                    shadingParams2.xyw = shadingParams2.xyw * shadingParams2.xyw;
                    shadingParams2.xyw = worldPosAndNormal.xyz * shadingParams2.xyw;
                    shadingParams2.xyw = shadingParams2.xyw * float3(14,14,14) + float3(1,1,1);
                    materialAndWorldNormal.xyz = shadingParams2.xyw * materialAndWorldNormal.xyz;
                    materialAndWorldNormal.xyz = materialAndWorldNormal.xyz * albedoAndDepth.xyz + -shadingParams1.xyz;
                    materialAndWorldNormal.xyz = cb1[260].zzz * materialAndWorldNormal.xyz + shadingParams1.xyz;
                    materialAndWorldNormal.xyz = materialAndWorldNormal.xyz * packedNormalAndMiscData.www;
                    packedNormalAndMiscData.x = -10000 + albedoAndDepth.w;
                    packedNormalAndMiscData.x = max(0, packedNormalAndMiscData.x);
                    packedNormalAndMiscData.x = min(5000, packedNormalAndMiscData.x);
                    packedNormalAndMiscData.x = 5000 + -packedNormalAndMiscData.x;
                    packedNormalAndMiscData.x = 0.000199999995 * packedNormalAndMiscData.x;
                    materialAndWorldNormal.xyz = packedNormalAndMiscData.xxx * materialAndWorldNormal.xyz;
                    materialAndWorldNormal.xyz = cb0[1].xyz * materialAndWorldNormal.xyz;
                } else {
                    materialAndWorldNormal.xyz = float3(0,0,0);
                }
                packedNormalAndMiscData.x = (0 != shadingParams2.z) ? 1.0 : 0.0;
                albedoAndDepth.xyz = shadingInfo.yzw * lightingTempA.xyz;
                albedoAndDepth.xyz = cb1[263].xyz * albedoAndDepth.xyz;
                albedoAndDepth.xyz = albedoAndDepth.xyz * float3(0.5,0.5,0.5) + -shadingInfo.yzw;
                albedoAndDepth.xyz = packedNormalAndMiscData.www * albedoAndDepth.xyz + shadingInfo.yzw;
                materialAndWorldNormal.xyz = shadingInfo.yzw + materialAndWorldNormal.xyz;
                materialAndWorldNormal.xyz = packedNormalAndMiscData.xxx ? albedoAndDepth.xyz : materialAndWorldNormal.xyz;
                packedNormalAndMiscData.xzw = packedNormalAndMiscData.zzz ? shadingInfo.yzw : materialAndWorldNormal.xyz;
                packedNormalAndMiscData.xyz = packedNormalAndMiscData.xzw / packedNormalAndMiscData.yyy;
                packedNormalAndMiscData.xyz = min(float3(0,0,0), -packedNormalAndMiscData.xyz);
                finalColor.xyz = -packedNormalAndMiscData.xyz;
                return finalColor;
            }
            ENDCG
        }
    }
}