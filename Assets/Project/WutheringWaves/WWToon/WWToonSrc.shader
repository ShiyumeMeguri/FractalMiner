Shader "Custom/WWToonSrc"
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
            sampler2D _IN0;
            sampler2D _IN1;
            sampler2D _IN2;
            sampler2D _IN3;
            sampler2D _IN4;
            sampler2D _IN5;
            sampler2D _IN6;
            sampler2D _IN7;
            sampler2D _IN8;
            sampler2D _IN9;

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
            
            // 已知 _IN0 是深度+Stencil 
            // 已知 _IN1 XYZ是法线 A是PerObjectData
            // 已知 _IN2 X是Metallic Y是Specular Z是Roughness W是ShadingModelID 
            // 已知 _IN3 是Albedo和Alpha
            // 未知 _IN4
            // 未知 _IN5 R是阴影 G不知道 B是反光强度? A为什么和B一样
            // 已知 _IN6 R16深度
            // 已知 _IN7 1x1像素 全0
            // 已知 _IN8 MSSAO 多分辨率屏幕空间AO
            // 已知 _IN9 1x1像素 R32G32B32A32 值看上去是 1.0 0.98065 0.07967 0.43407
            
            fixed4 frag (VertexToFragment fragmentInput) : SV_Target
            {
                float4 screenUV = float4(fragmentInput.uv.xy, 0.0, 0.0); 

                float4 finalColor = 0;
                
                // 临时寄存器被重命名以提高清晰度。由于这些变量被大量重用（在编译后的Shader中很常见），
                // 它们的名称反映了其初始或最重要的角色。在分析中会指出其含义的变化。
                float4 normalData_and_Temp, materialParams_and_Temp, albedo_and_ViewDepth, customDataA_and_Temp, shadingInfo_and_Temp, shadingModelFlags_and_Temp, worldNormal_and_WorldPos, lightingTempA, lightingTempB, lightingTempC, accumulatedLightColor, lightLoopTempA, lightLoopTempB, lightLoopTempC, lightLoopTempD, lightLoopTempE, lightLoopTempF;
                uint4 bitmask, uiDest;
                float4 fDest;

                normalData_and_Temp.xyzw = tex2Dlod(_IN1, float4(screenUV.xy, 0, 0)).wxyz;
                materialParams_and_Temp.xyzw = tex2Dlod(_IN2, float4(screenUV.xy, 0, 0)).xyzw;
                albedo_and_ViewDepth.xyz = tex2Dlod(_IN3, float4(screenUV.xy, 0, 0)).xyz;
                customDataA_and_Temp.xyz = tex2Dlod(_IN4, float4(screenUV.xy, 0, 0)).yxz;
                
                albedo_and_ViewDepth.w = tex2Dlod(_IN0, float4(screenUV.xy, 0, 0)).x;
                customDataA_and_Temp.w = albedo_and_ViewDepth.w * cb1[65].x + cb1[65].y;
                albedo_and_ViewDepth.w = albedo_and_ViewDepth.w * cb1[65].z + -cb1[65].w;
                albedo_and_ViewDepth.w = 1 / albedo_and_ViewDepth.w;
                albedo_and_ViewDepth.w = customDataA_and_Temp.w + albedo_and_ViewDepth.w;
                
                shadingInfo_and_Temp.xy = cb1[138].xy * screenUV.xy;
                shadingInfo_and_Temp.xy = (uint2)shadingInfo_and_Temp.xy;
                customDataA_and_Temp.w = (uint)cb1[158].x;
                shadingInfo_and_Temp.x = (int)shadingInfo_and_Temp.y + (int)shadingInfo_and_Temp.x;
                customDataA_and_Temp.w = (int)customDataA_and_Temp.w + (int)shadingInfo_and_Temp.x;
                customDataA_and_Temp.w = (int)customDataA_and_Temp.w & 1;
                materialParams_and_Temp.w = 255 * materialParams_and_Temp.w;
                materialParams_and_Temp.w = round(materialParams_and_Temp.w);
                materialParams_and_Temp.w = (uint)materialParams_and_Temp.w;
                shadingInfo_and_Temp.xy = (int2)materialParams_and_Temp.ww & int2(15,-16);
                materialParams_and_Temp.w = ((int)shadingInfo_and_Temp.x != 12) ? 1.0 : 0.0;
                shadingModelFlags_and_Temp.xyz = ((int3)shadingInfo_and_Temp.xxx == int3(13,14,15)) ? 1.0 : 0.0;
                shadingInfo_and_Temp.z = (int)shadingModelFlags_and_Temp.z | (int)shadingModelFlags_and_Temp.y;
                shadingInfo_and_Temp.z = (int)shadingInfo_and_Temp.z | (int)shadingModelFlags_and_Temp.x;
                materialParams_and_Temp.w = materialParams_and_Temp.w ? shadingInfo_and_Temp.z : -1;
                if (materialParams_and_Temp.w != 0) {
                    shadingInfo_and_Temp.x = shadingModelFlags_and_Temp.x ? 13 : 12;
                    shadingModelFlags_and_Temp.xz = shadingModelFlags_and_Temp.yz ? float2(1,1) : 0;
                    shadingInfo_and_Temp.zw = normalData_and_Temp.yz * float2(2,2) + float2(-1,-1);
                    materialParams_and_Temp.w = dot(float2(1,1), abs(shadingInfo_and_Temp.zw));
                    worldNormal_and_WorldPos.z = 1 + -materialParams_and_Temp.w;
                    materialParams_and_Temp.w = max(0, -worldNormal_and_WorldPos.z);
                    lightingTempA.xy = (shadingInfo_and_Temp.zw >= float2(0,0)) ? 1.0 : 0.0;
                    lightingTempA.xy = lightingTempA.xy ? float2(0.5,0.5) : float2(-0.5,-0.5);
                    lightingTempA.xy = lightingTempA.xy * materialParams_and_Temp.ww;
                    worldNormal_and_WorldPos.xy = lightingTempA.xy * float2(-2,-2) + shadingInfo_and_Temp.zw;
                    materialParams_and_Temp.w = dot(worldNormal_and_WorldPos.xyz, worldNormal_and_WorldPos.xyz);
                    materialParams_and_Temp.w = rsqrt(materialParams_and_Temp.w);
                    worldNormal_and_WorldPos.xyz = worldNormal_and_WorldPos.xyz * materialParams_and_Temp.www;
                    lightingTempA.xyz = materialParams_and_Temp.xyz * materialParams_and_Temp.xyz;
                    shadingModelFlags_and_Temp.y = customDataA_and_Temp.z;
                } else {
                    materialParams_and_Temp.w = ((int)shadingInfo_and_Temp.x == 10) ? 1.0 : 0.0;
                    materialParams_and_Temp.xyz = saturate(materialParams_and_Temp.xyz);
                    materialParams_and_Temp.xyz = float3(16777215,65535,255) * materialParams_and_Temp.xyz;
                    materialParams_and_Temp.xyz = round(materialParams_and_Temp.xyz);
                    materialParams_and_Temp.xyz = (uint3)materialParams_and_Temp.xyz;
                    bitmask.y = ((~(-1 << 8)) << 0) & 0xffffffff;  materialParams_and_Temp.y = (((uint)materialParams_and_Temp.z << 0) & bitmask.y) | ((uint)materialParams_and_Temp.y & ~bitmask.y);
                    bitmask.x = ((~(-1 << 16)) << 0) & 0xffffffff;  materialParams_and_Temp.x = (((uint)materialParams_and_Temp.y << 0) & bitmask.x) | ((uint)materialParams_and_Temp.x & ~bitmask.x);
                    materialParams_and_Temp.x = (uint)materialParams_and_Temp.x;
                    materialParams_and_Temp.x = 5.96046519e-008 * materialParams_and_Temp.x;
                    materialParams_and_Temp.y = materialParams_and_Temp.x * cb1[65].x + cb1[65].y;
                    materialParams_and_Temp.x = materialParams_and_Temp.x * cb1[65].z + -cb1[65].w;
                    materialParams_and_Temp.x = 1 / materialParams_and_Temp.x;
                    materialParams_and_Temp.x = materialParams_and_Temp.y + materialParams_and_Temp.x;
                    albedo_and_ViewDepth.w = materialParams_and_Temp.w ? materialParams_and_Temp.x : albedo_and_ViewDepth.w;
                    worldNormal_and_WorldPos.xyz = normalData_and_Temp.yzw * float3(2,2,2) + float3(-1,-1,-1);
                    lightingTempA.xyz = float3(0,0,0);
                    shadingModelFlags_and_Temp.xyz = float3(0,0,0);
                    normalData_and_Temp.xw = float2(0,0);
                    customDataA_and_Temp.xy = float2(0,0);
                }
                normalData_and_Temp.y = dot(worldNormal_and_WorldPos.xyz, worldNormal_and_WorldPos.xyz);
                normalData_and_Temp.y = rsqrt(normalData_and_Temp.y);
                materialParams_and_Temp.xyz = worldNormal_and_WorldPos.xyz * normalData_and_Temp.yyy;
                normalData_and_Temp.yz = ((int2)shadingInfo_and_Temp.xx == int2(5,13)) ? 1.0 : 0.0;
                materialParams_and_Temp.w = (0 < cb1[162].y) ? 1.0 : 0.0;
                shadingInfo_and_Temp.z = (0 < cb1[220].z) ? 1.0 : 0.0;
                materialParams_and_Temp.w = materialParams_and_Temp.w ? shadingInfo_and_Temp.z : 0;
                shadingInfo_and_Temp.z = (0 != cb1[162].y) ? 1.0 : 0.0;
                worldNormal_and_WorldPos.xyz = shadingInfo_and_Temp.zzz ? float3(1,1,1) : albedo_and_ViewDepth.xyz;
                customDataA_and_Temp.w = customDataA_and_Temp.w ? 1 : 0;
                worldNormal_and_WorldPos.xyz = materialParams_and_Temp.www ? customDataA_and_Temp.www : worldNormal_and_WorldPos.xyz;
                albedo_and_ViewDepth.xyz = normalData_and_Temp.yyy ? worldNormal_and_WorldPos.xyz : albedo_and_ViewDepth.xyz;
                normalData_and_Temp.y = tex2Dlod(_IN9, float4(0, 0, 0, 0)).x;
                shadingInfo_and_Temp.zw = screenUV.zw * albedo_and_ViewDepth.ww; // This will be 0 due to screenUV.zw initialization
                worldNormal_and_WorldPos.xyz = cb1[49].xyz * shadingInfo_and_Temp.www;
                worldNormal_and_WorldPos.xyz = shadingInfo_and_Temp.zzz * cb1[48].xyz + worldNormal_and_WorldPos.xyz;
                worldNormal_and_WorldPos.xyz = albedo_and_ViewDepth.www * cb1[50].xyz + worldNormal_and_WorldPos.xyz;
                worldNormal_and_WorldPos.xyz = cb1[51].xyz + worldNormal_and_WorldPos.xyz;
                shadingInfo_and_Temp.zw = tex2Dlod(_IN5, float4(screenUV.xy, 0, 0)).xz;
                shadingInfo_and_Temp.zw = shadingInfo_and_Temp.zw * shadingInfo_and_Temp.zw;
                materialParams_and_Temp.w = shadingInfo_and_Temp.z * shadingInfo_and_Temp.w;
                customDataA_and_Temp.w = cb1[253].y * materialParams_and_Temp.w;
                if (cb1[255].x != 0) {
                    lightingTempB.xyz = float3(0,0,0);
                    shadingInfo_and_Temp.zw = float2(0,0);
                    shadingModelFlags_and_Temp.w = 0;
                    worldNormal_and_WorldPos.w = 0;
                    while (true) {
                    lightingTempA.w = ((int)shadingInfo_and_Temp.z >= 3) ? 1.0 : 0.0;
                    if (lightingTempA.w != 0) break;
                    shadingInfo_and_Temp.w = 0.000833333295 + shadingInfo_and_Temp.w;
                    lightingTempC.xyz = lightingTempB.xyz;
                    lightingTempA.w = shadingModelFlags_and_Temp.w;
                    lightingTempB.w = worldNormal_and_WorldPos.w;
                    lightingTempC.w = 0;
                    while (true) {
                        accumulatedLightColor.x = ((int)lightingTempC.w >= 3) ? 1.0 : 0.0;
                        if (accumulatedLightColor.x != 0) break;
                        lightingTempA.w = 1 + lightingTempA.w;
                        accumulatedLightColor.x = 2.09439516 * lightingTempA.w;
                        sincos(accumulatedLightColor.x, accumulatedLightColor.x, lightLoopTempA.x);
                        lightLoopTempA.x = lightLoopTempA.x * shadingInfo_and_Temp.w + screenUV.x;
                        lightLoopTempA.y = accumulatedLightColor.x * shadingInfo_and_Temp.w + screenUV.y;
                        accumulatedLightColor.xyz = tex2D(_IN7, lightLoopTempA.xy).xyz;
                        lightingTempC.xyz = accumulatedLightColor.xyz * shadingInfo_and_Temp.www + lightingTempC.xyz;
                        lightingTempB.w = lightingTempB.w + shadingInfo_and_Temp.w;
                        lightingTempC.w = (int)lightingTempC.w + 1;
                    }
                    lightingTempB.xyz = lightingTempC.xyz;
                    worldNormal_and_WorldPos.w = lightingTempB.w;
                    shadingModelFlags_and_Temp.w = 0.620000005 + lightingTempA.w;
                    shadingInfo_and_Temp.z = (int)shadingInfo_and_Temp.z + 1;
                    }
                    lightingTempB.xyz = lightingTempB.xyz / worldNormal_and_WorldPos.www;
                    lightingTempC.xyz = (float3(0.644999981,0.312000006,0.978999972) < normalData_and_Temp.xxx) ? 1.0 : 0.0;
                    accumulatedLightColor.xyz = (normalData_and_Temp.xxx < float3(0.685000002,0.351999998,1.02100003)) ? 1.0 : 0.0;
                    lightingTempC.xyz = lightingTempC.xyz ? accumulatedLightColor.xyz : 0;
                    normalData_and_Temp.x = lightingTempC.z ? 1.000000 : 0;
                    normalData_and_Temp.x = lightingTempC.y ? 0 : normalData_and_Temp.x;
                    normalData_and_Temp.x = lightingTempC.x ? 1 : normalData_and_Temp.x;
                    shadingInfo_and_Temp.z = (int)lightingTempC.y | (int)lightingTempC.z;
                    shadingInfo_and_Temp.z = (int)shadingInfo_and_Temp.z & 0x3f800000;
                    shadingInfo_and_Temp.z = lightingTempC.x ? 0 : shadingInfo_and_Temp.z;
                    customDataA_and_Temp.x = 255 * customDataA_and_Temp.x;
                    customDataA_and_Temp.x = round(customDataA_and_Temp.x);
                    customDataA_and_Temp.x = (uint)customDataA_and_Temp.x;
                    lightingTempC.xyzw = (int4)customDataA_and_Temp.xxxx & int4(15,240,240,15);
                    lightingTempC.xyzw = (uint4)lightingTempC.xyzw;
                    customDataA_and_Temp.x = saturate(normalData_and_Temp.w + normalData_and_Temp.w);
                    shadingInfo_and_Temp.w = customDataA_and_Temp.x * -2 + 3;
                    customDataA_and_Temp.x = customDataA_and_Temp.x * customDataA_and_Temp.x;
                    customDataA_and_Temp.x = shadingInfo_and_Temp.w * customDataA_and_Temp.x;
                    shadingInfo_and_Temp.w = -0.5 + normalData_and_Temp.w;
                    shadingInfo_and_Temp.w = saturate(shadingInfo_and_Temp.w + shadingInfo_and_Temp.w);
                    shadingModelFlags_and_Temp.w = shadingInfo_and_Temp.w * -2 + 3;
                    shadingInfo_and_Temp.w = shadingInfo_and_Temp.w * shadingInfo_and_Temp.w;
                    shadingInfo_and_Temp.w = shadingModelFlags_and_Temp.w * shadingInfo_and_Temp.w;
                    accumulatedLightColor.xyz = cb1[262].xyz + -cb1[261].xyz;
                    shadingModelFlags_and_Temp.w = dot(abs(accumulatedLightColor.xyz), float3(0.300000012,0.589999974,0.109999999));
                    shadingModelFlags_and_Temp.w = 10 * shadingModelFlags_and_Temp.w;
                    shadingModelFlags_and_Temp.w = min(1, shadingModelFlags_and_Temp.w);
                    worldNormal_and_WorldPos.w = shadingModelFlags_and_Temp.w * -2 + 3;
                    shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.w * shadingModelFlags_and_Temp.w;
                    shadingModelFlags_and_Temp.w = worldNormal_and_WorldPos.w * shadingModelFlags_and_Temp.w;
                    worldNormal_and_WorldPos.w = shadingModelFlags_and_Temp.w * shadingInfo_and_Temp.w;
                    lightingTempA.w = cb1[265].y + -cb1[265].x;
                    lightingTempB.w = materialParams_and_Temp.w * cb1[253].y + -cb1[265].x;
                    lightingTempA.w = 1 / lightingTempA.w;
                    lightingTempB.w = saturate(lightingTempB.w * lightingTempA.w);
                    accumulatedLightColor.x = lightingTempB.w * -2 + 3;
                    lightingTempB.w = lightingTempB.w * lightingTempB.w;
                    lightingTempB.w = accumulatedLightColor.x * lightingTempB.w;
                    lightingTempB.w = lightingTempB.w * worldNormal_and_WorldPos.w;
                    accumulatedLightColor.x = materialParams_and_Temp.w * cb1[253].y + -lightingTempB.w;
                    lightingTempB.w = cb1[265].z * accumulatedLightColor.x + lightingTempB.w;
                    accumulatedLightColor.x = -cb1[265].x + lightingTempB.w;
                    lightingTempA.w = saturate(accumulatedLightColor.x * lightingTempA.w);
                    accumulatedLightColor.x = lightingTempA.w * -2 + 3;
                    lightingTempA.w = lightingTempA.w * lightingTempA.w;
                    lightingTempA.w = accumulatedLightColor.x * lightingTempA.w;
                    worldNormal_and_WorldPos.w = lightingTempA.w * worldNormal_and_WorldPos.w;
                    shadingInfo_and_Temp.w = shadingInfo_and_Temp.w * shadingModelFlags_and_Temp.w + -worldNormal_and_WorldPos.w;
                    shadingInfo_and_Temp.w = cb1[265].z * shadingInfo_and_Temp.w + worldNormal_and_WorldPos.w;
                    shadingModelFlags_and_Temp.w = -1 + lightingTempB.w;
                    shadingModelFlags_and_Temp.w = cb1[260].y * shadingModelFlags_and_Temp.w + 1;
                    worldNormal_and_WorldPos.w = customDataA_and_Temp.w * shadingInfo_and_Temp.w + -shadingModelFlags_and_Temp.w;
                    shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.x * worldNormal_and_WorldPos.w + shadingModelFlags_and_Temp.w;
                    worldNormal_and_WorldPos.w = customDataA_and_Temp.w * shadingInfo_and_Temp.w + -shadingInfo_and_Temp.w;
                    accumulatedLightColor.x = shadingModelFlags_and_Temp.x * worldNormal_and_WorldPos.w + shadingInfo_and_Temp.w;
                    shadingInfo_and_Temp.w = (lightingTempB.y >= lightingTempB.z) ? 1.0 : 0.0;
                    shadingInfo_and_Temp.w = shadingInfo_and_Temp.w ? 1.000000 : 0;
                    lightLoopTempA.xy = lightingTempB.zy;
                    lightLoopTempA.zw = float2(-1,0.666666687);
                    lightLoopTempB.xy = -lightLoopTempA.xy + lightingTempB.yz;
                    lightLoopTempB.zw = float2(1,-1);
                    lightLoopTempA.xyzw = shadingInfo_and_Temp.wwww * lightLoopTempB.xyzw + lightLoopTempA.xyzw;
                    shadingInfo_and_Temp.w = (lightingTempB.x >= lightLoopTempA.x) ? 1.0 : 0.0;
                    shadingInfo_and_Temp.w = shadingInfo_and_Temp.w ? 1.000000 : 0;
                    lightLoopTempB.xyz = lightLoopTempA.xyw;
                    lightLoopTempB.w = lightingTempB.x;
                    lightLoopTempA.xyw = lightLoopTempB.wyx;
                    lightLoopTempA.xyzw = lightLoopTempA.xyzw + -lightLoopTempB.xyzw;
                    lightLoopTempA.xyzw = shadingInfo_and_Temp.wwww * lightLoopTempA.xyzw + lightLoopTempB.xyzw;
                    shadingInfo_and_Temp.w = min(lightLoopTempA.w, lightLoopTempA.y);
                    shadingInfo_and_Temp.w = lightLoopTempA.x + -shadingInfo_and_Temp.w;
                    worldNormal_and_WorldPos.w = lightLoopTempA.w + -lightLoopTempA.y;
                    lightingTempA.w = shadingInfo_and_Temp.w * 6 + 0.00100000005;
                    worldNormal_and_WorldPos.w = worldNormal_and_WorldPos.w / lightingTempA.w;
                    worldNormal_and_WorldPos.w = lightLoopTempA.z + worldNormal_and_WorldPos.w;
                    lightingTempA.w = 0.00100000005 + lightLoopTempA.x;
                    shadingInfo_and_Temp.w = shadingInfo_and_Temp.w / lightingTempA.w;
                    lightingTempA.w = lightLoopTempA.x * 0.300000012 + 1;
                    lightLoopTempA.xyzw = lightingTempC.xyzw * float4(0.0400000028,0.0027450982,0.00392156886,0.0666666701) + float4(0.400000006,0.400000006,1,0.5);
                    lightingTempB.w = (lightingTempC.z >= 2.54999971) ? 1.0 : 0.0;
                    lightingTempB.w = lightingTempB.w ? 1.000000 : 0;
                    lightingTempC.x = lightLoopTempA.y + -lightLoopTempA.x;
                    lightingTempC.x = lightingTempB.w * lightingTempC.x + lightLoopTempA.x;
                    shadingInfo_and_Temp.w = lightingTempC.x * shadingInfo_and_Temp.w;
                    shadingInfo_and_Temp.w = min(0.349999994, shadingInfo_and_Temp.w);
                    lightingTempC.x = max(0, shadingInfo_and_Temp.w);
                    lightingTempC.yzw = float3(1,0.666666687,0.333333343) + abs(worldNormal_and_WorldPos.www);
                    lightingTempC.yzw = frac(lightingTempC.yzw);
                    lightingTempC.yzw = lightingTempC.yzw * float3(6,6,6) + float3(-3,-3,-3);
                    lightingTempC.yzw = saturate(float3(-1,-1,-1) + abs(lightingTempC.yzw));
                    lightingTempC.yzw = float3(-1,-1,-1) + lightingTempC.yzw;
                    lightingTempC.xyz = lightingTempC.xxx * lightingTempC.yzw + float3(1,1,1);
                    shadingInfo_and_Temp.w = 1 + shadingInfo_and_Temp.w;
                    lightLoopTempB.xyz = lightingTempC.xyz * shadingInfo_and_Temp.www;
                    lightLoopTempC.xyz = lightingTempC.xyz * shadingInfo_and_Temp.www + float3(-1,-1,-1);
                    lightLoopTempC.xyz = lightLoopTempC.xyz * float3(0.600000024,0.600000024,0.600000024) + float3(1,1,1);
                    lightingTempC.xyz = -lightingTempC.xyz * shadingInfo_and_Temp.www + lightLoopTempC.xyz;
                    lightingTempC.xyz = normalData_and_Temp.xxx * lightingTempC.xyz + lightLoopTempB.xyz;
                    lightLoopTempB.xyz = lightingTempC.xyz + -albedo_and_ViewDepth.xyz;
                    lightLoopTempB.xyz = lightLoopTempB.xyz * float3(0.850000024,0.850000024,0.850000024) + albedo_and_ViewDepth.xyz;
                    lightLoopTempA.xyz = lightLoopTempA.zzz * lightLoopTempB.xyz + -lightingTempC.xyz;
                    lightingTempC.xyz = lightingTempB.www * lightLoopTempA.xyz + lightingTempC.xyz;
                    lightingTempC.xyz = float3(-1,-1,-1) + lightingTempC.xyz;
                    lightingTempC.xyz = lightLoopTempA.www * lightingTempC.xyz + float3(1,1,1);
                    lightLoopTempA.xyz = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
                    lightLoopTempB.xyz = cb1[262].xyz * float3(0.5,0.5,0.5) + -lightLoopTempA.xyz;
                    lightLoopTempA.xyz = shadingModelFlags_and_Temp.www * lightLoopTempB.xyz + lightLoopTempA.xyz;
                    lightLoopTempA.xyz = cb1[260].xxx * lightLoopTempA.xyz;
                    lightLoopTempA.xyz = lightLoopTempA.xyz * albedo_and_ViewDepth.xyz;
                    lightLoopTempB.xyz = lightLoopTempA.xyz * lightingTempA.xyz;
                    lightLoopTempC.xyz = cb1[261].xyz * albedo_and_ViewDepth.xyz;
                    normalData_and_Temp.x = customDataA_and_Temp.x * 0.300000012 + 0.699999988;
                    lightLoopTempD.xyz = lightLoopTempC.xyz * normalData_and_Temp.xxx;
                    lightLoopTempE.xyz = cb1[262].xyz * albedo_and_ViewDepth.xyz;
                    lightLoopTempB.xyz = lightLoopTempC.xyz * normalData_and_Temp.xxx + lightLoopTempB.xyz;
                    lightLoopTempC.xyz = albedo_and_ViewDepth.xyz * cb1[262].xyz + -lightLoopTempD.xyz;
                    lightLoopTempC.xyz = lightLoopTempC.xyz * float3(0.400000006,0.400000006,0.400000006) + lightLoopTempD.xyz;
                    lightLoopTempF.xyz = lightLoopTempD.xyz * lightingTempC.xyz;
                    lightLoopTempC.xyz = lightLoopTempC.xyz * lightingTempC.xyz + -lightLoopTempF.xyz;
                    lightLoopTempC.xyz = accumulatedLightColor.xxx * lightLoopTempC.xyz + lightLoopTempF.xyz;
                    lightLoopTempA.xyz = lightLoopTempA.xyz * lightingTempA.xyz + lightLoopTempC.xyz;
                    lightLoopTempB.xyz = lightLoopTempB.xyz * lightingTempC.xyz;
                    lightLoopTempC.xyz = lightLoopTempE.xyz * lightingTempA.www;
                    lightingTempC.xyz = lightLoopTempC.xyz * lightingTempC.xyz + -lightLoopTempB.xyz;
                    lightingTempC.xyz = accumulatedLightColor.xxx * lightingTempC.xyz + lightLoopTempB.xyz;
                    normalData_and_Temp.x = tex2Dlod(_IN8, float4(screenUV.xy, 0, 0)).x;
                    normalData_and_Temp.x = -1 + normalData_and_Temp.x;
                    normalData_and_Temp.x = shadingInfo_and_Temp.z * normalData_and_Temp.x + 1;
                    lightingTempC.xyz = lightingTempC.xyz + -lightLoopTempA.xyz;
                    lightingTempC.xyz = shadingModelFlags_and_Temp.www * lightingTempC.xyz + lightLoopTempA.xyz;
                    lightLoopTempA.xyz = float3(1,1,1) + -lightingTempB.xyz;
                    lightingTempB.xyz = normalData_and_Temp.xxx * lightLoopTempA.xyz + lightingTempB.xyz;
                    lightingTempB.xyz = lightingTempC.xyz * lightingTempB.xyz;
                } else {
                    normalData_and_Temp.x = saturate(normalData_and_Temp.w + normalData_and_Temp.w);
                    customDataA_and_Temp.x = normalData_and_Temp.x * -2 + 3;
                    normalData_and_Temp.x = normalData_and_Temp.x * normalData_and_Temp.x;
                    normalData_and_Temp.x = customDataA_and_Temp.x * normalData_and_Temp.x;
                    customDataA_and_Temp.x = -0.5 + normalData_and_Temp.w;
                    customDataA_and_Temp.x = saturate(customDataA_and_Temp.x + customDataA_and_Temp.x);
                    shadingInfo_and_Temp.z = customDataA_and_Temp.x * -2 + 3;
                    customDataA_and_Temp.x = customDataA_and_Temp.x * customDataA_and_Temp.x;
                    customDataA_and_Temp.x = shadingInfo_and_Temp.z * customDataA_and_Temp.x;
                    lightingTempC.xyz = cb1[262].xyz + -cb1[261].xyz;
                    shadingInfo_and_Temp.z = dot(abs(lightingTempC.xyz), float3(0.300000012,0.589999974,0.109999999));
                    shadingInfo_and_Temp.z = 10 * shadingInfo_and_Temp.z;
                    shadingInfo_and_Temp.z = min(1, shadingInfo_and_Temp.z);
                    shadingInfo_and_Temp.w = shadingInfo_and_Temp.z * -2 + 3;
                    shadingInfo_and_Temp.z = shadingInfo_and_Temp.z * shadingInfo_and_Temp.z;
                    shadingInfo_and_Temp.z = shadingInfo_and_Temp.w * shadingInfo_and_Temp.z;
                    shadingInfo_and_Temp.w = shadingInfo_and_Temp.z * customDataA_and_Temp.x;
                    shadingModelFlags_and_Temp.w = cb1[265].y + -cb1[265].x;
                    worldNormal_and_WorldPos.w = materialParams_and_Temp.w * cb1[253].y + -cb1[265].x;
                    shadingModelFlags_and_Temp.w = 1 / shadingModelFlags_and_Temp.w;
                    worldNormal_and_WorldPos.w = saturate(worldNormal_and_WorldPos.w * shadingModelFlags_and_Temp.w);
                    lightingTempA.w = worldNormal_and_WorldPos.w * -2 + 3;
                    worldNormal_and_WorldPos.w = worldNormal_and_WorldPos.w * worldNormal_and_WorldPos.w;
                    worldNormal_and_WorldPos.w = lightingTempA.w * worldNormal_and_WorldPos.w;
                    worldNormal_and_WorldPos.w = worldNormal_and_WorldPos.w * shadingInfo_and_Temp.w;
                    materialParams_and_Temp.w = materialParams_and_Temp.w * cb1[253].y + -worldNormal_and_WorldPos.w;
                    materialParams_and_Temp.w = cb1[265].z * materialParams_and_Temp.w + worldNormal_and_WorldPos.w;
                    worldNormal_and_WorldPos.w = -cb1[265].x + materialParams_and_Temp.w;
                    shadingModelFlags_and_Temp.w = saturate(worldNormal_and_WorldPos.w * shadingModelFlags_and_Temp.w);
                    worldNormal_and_WorldPos.w = shadingModelFlags_and_Temp.w * -2 + 3;
                    shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.w * shadingModelFlags_and_Temp.w;
                    shadingModelFlags_and_Temp.w = worldNormal_and_WorldPos.w * shadingModelFlags_and_Temp.w;
                    shadingInfo_and_Temp.w = shadingModelFlags_and_Temp.w * shadingInfo_and_Temp.w;
                    customDataA_and_Temp.x = customDataA_and_Temp.x * shadingInfo_and_Temp.z + -shadingInfo_and_Temp.w;
                    customDataA_and_Temp.x = cb1[265].z * customDataA_and_Temp.x + shadingInfo_and_Temp.w;
                    shadingInfo_and_Temp.z = materialParams_and_Temp.w * shadingModelFlags_and_Temp.y;
                    shadingInfo_and_Temp.z = 10 * shadingInfo_and_Temp.z;
                    materialParams_and_Temp.w = -1 + materialParams_and_Temp.w;
                    materialParams_and_Temp.w = cb1[260].y * materialParams_and_Temp.w + 1;
                    shadingInfo_and_Temp.w = customDataA_and_Temp.w * customDataA_and_Temp.x + -materialParams_and_Temp.w;
                    materialParams_and_Temp.w = shadingModelFlags_and_Temp.x * shadingInfo_and_Temp.w + materialParams_and_Temp.w;
                    shadingInfo_and_Temp.w = customDataA_and_Temp.w * customDataA_and_Temp.x + -customDataA_and_Temp.x;
                    accumulatedLightColor.x = shadingModelFlags_and_Temp.x * shadingInfo_and_Temp.w + customDataA_and_Temp.x;
                    shadingModelFlags_and_Temp.xyw = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
                    lightingTempC.xyz = cb1[262].xyz * float3(0.5,0.5,0.5) + -shadingModelFlags_and_Temp.xyw;
                    shadingModelFlags_and_Temp.xyw = materialParams_and_Temp.www * lightingTempC.xyz + shadingModelFlags_and_Temp.xyw;
                    shadingModelFlags_and_Temp.xyw = cb1[260].xxx * shadingModelFlags_and_Temp.xyw;
                    shadingModelFlags_and_Temp.xyw = shadingModelFlags_and_Temp.xyw * albedo_and_ViewDepth.xyz;
                    lightingTempC.xyz = shadingModelFlags_and_Temp.xyw * lightingTempA.xyz;
                    lightLoopTempA.xyz = cb1[261].xyz * albedo_and_ViewDepth.xyz;
                    normalData_and_Temp.x = normalData_and_Temp.x * 0.300000012 + 0.699999988;
                    lightLoopTempD.xyz = lightLoopTempA.xyz * normalData_and_Temp.xxx;
                    lightLoopTempA.xyz = lightLoopTempA.xyz * normalData_and_Temp.xxx + lightingTempC.xyz;
                    lightingTempC.xyz = lightingTempC.xyz * shadingInfo_and_Temp.zzz + lightLoopTempA.xyz;
                    lightLoopTempA.xyz = albedo_and_ViewDepth.xyz * cb1[262].xyz + -lightLoopTempD.xyz;
                    lightLoopTempA.xyz = lightLoopTempA.xyz * accumulatedLightColor.xxx;
                    lightLoopTempA.xyz = lightLoopTempA.xyz * float3(0.400000006,0.400000006,0.400000006) + lightLoopTempD.xyz;
                    shadingModelFlags_and_Temp.xyw = shadingModelFlags_and_Temp.xyw * lightingTempA.xyz + lightLoopTempA.xyz;
                    lightLoopTempA.xyz = albedo_and_ViewDepth.xyz * cb1[262].xyz + -lightingTempC.xyz;
                    lightingTempC.xyz = accumulatedLightColor.xxx * lightLoopTempA.xyz + lightingTempC.xyz;
                    lightingTempC.xyz = lightingTempC.xyz + -shadingModelFlags_and_Temp.xyw;
                    lightingTempB.xyz = materialParams_and_Temp.www * lightingTempC.xyz + shadingModelFlags_and_Temp.xyw;
                }
                normalData_and_Temp.x = -0.400000006 + normalData_and_Temp.w;
                normalData_and_Temp.x = saturate(10.000001 * normalData_and_Temp.x);
                normalData_and_Temp.w = normalData_and_Temp.x * -2 + 3;
                normalData_and_Temp.x = normalData_and_Temp.x * normalData_and_Temp.x;
                accumulatedLightColor.y = normalData_and_Temp.w * normalData_and_Temp.x;
                shadingModelFlags_and_Temp.xyw = lightingTempB.xyz * float3(0.5,0.5,0.5) + cb1[261].xyz;
                shadingModelFlags_and_Temp.xyw = shadingModelFlags_and_Temp.xyw * albedo_and_ViewDepth.xyz;
                lightingTempC.xyz = cb1[261].xyz * albedo_and_ViewDepth.xyz;
                shadingModelFlags_and_Temp.xyw = cb1[255].xxx ? shadingModelFlags_and_Temp.xyw : lightingTempC.xyz;
                lightingTempC.xyz = normalData_and_Temp.zzz ? shadingModelFlags_and_Temp.xyw : lightLoopTempD.xyz;
                shadingModelFlags_and_Temp.xyw = normalData_and_Temp.zzz ? shadingModelFlags_and_Temp.xyw : lightingTempB.xyz;
                normalData_and_Temp.xw = normalData_and_Temp.zz ? float2(0,0) : accumulatedLightColor.xy;
                lightingTempB.xyz = cb1[264].xyz + cb1[264].xyz;
                lightingTempB.xyz = normalData_and_Temp.xxx * lightingTempB.xyz + -cb1[264].xyz;
                accumulatedLightColor.xyz = float3(0,0,0);
                materialParams_and_Temp.w = 1;
                customDataA_and_Temp.x = 0;
                while (true) {
                    shadingInfo_and_Temp.z = ((uint)customDataA_and_Temp.x >= asuint(cb2[128].x)) ? 1.0 : 0.0;
                    if (shadingInfo_and_Temp.z != 0) break;
                    bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  shadingInfo_and_Temp.z = (((uint)customDataA_and_Temp.x << 3) & bitmask.z) | ((uint)7 & ~bitmask.z);
                    bitmask.w = ((~(-1 << 3)) << 5) & 0xffffffff;  shadingInfo_and_Temp.w = (((uint)cb2[shadingInfo_and_Temp.z+0].w << 5) & bitmask.w) | ((uint)0 & ~bitmask.w);
                    shadingInfo_and_Temp.w = (int)shadingInfo_and_Temp.y & (int)shadingInfo_and_Temp.w;
                    if (shadingInfo_and_Temp.w == 0) {
                    shadingInfo_and_Temp.w = (int)customDataA_and_Temp.x + 1;
                    customDataA_and_Temp.x = shadingInfo_and_Temp.w;
                    continue;
                    }
                    shadingInfo_and_Temp.w = (uint)customDataA_and_Temp.x << 3;
                    lightLoopTempA.xyz = cb2[shadingInfo_and_Temp.w+0].xyz + -worldNormal_and_WorldPos.xyz;
                    worldNormal_and_WorldPos.w = cb2[shadingInfo_and_Temp.w+0].w * cb2[shadingInfo_and_Temp.w+0].w;
                    lightingTempA.w = dot(lightLoopTempA.xyz, lightLoopTempA.xyz);
                    worldNormal_and_WorldPos.w = lightingTempA.w * worldNormal_and_WorldPos.w;
                    lightingTempB.w = (1 >= worldNormal_and_WorldPos.w) ? 1.0 : 0.0;
                    if (lightingTempB.w != 0) {
                    bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  lightLoopTempB.x = (((uint)customDataA_and_Temp.x << 3) & bitmask.x) | ((uint)1 & ~bitmask.x);
                    bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  lightLoopTempB.y = (((uint)customDataA_and_Temp.x << 3) & bitmask.y) | ((uint)2 & ~bitmask.x);
                    bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  lightLoopTempB.z = (((uint)customDataA_and_Temp.x << 3) & bitmask.z) | ((uint)3 & ~bitmask.z);
                    bitmask.w = ((~(-1 << 29)) << 3) & 0xffffffff;  lightLoopTempB.w = (((uint)customDataA_and_Temp.x << 3) & bitmask.w) | ((uint)4 & ~bitmask.w);
                    bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  lightLoopTempC.x = (((uint)customDataA_and_Temp.x << 3) & bitmask.x) | ((uint)5 & ~bitmask.x);
                    bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  lightLoopTempC.y = (((uint)customDataA_and_Temp.x << 3) & bitmask.y) | ((uint)6 & ~bitmask.x);
                    worldNormal_and_WorldPos.w = saturate(worldNormal_and_WorldPos.w * 2.5 + -1.5);
                    lightingTempB.w = worldNormal_and_WorldPos.w * worldNormal_and_WorldPos.w;
                    worldNormal_and_WorldPos.w = -worldNormal_and_WorldPos.w * 2 + 3;
                    worldNormal_and_WorldPos.w = -lightingTempB.w * worldNormal_and_WorldPos.w + 1;
                    lightingTempA.w = rsqrt(lightingTempA.w);
                    lightLoopTempD.xyz = lightLoopTempA.xyz * lightingTempA.www;
                    lightingTempA.w = dot(materialParams_and_Temp.xyz, lightLoopTempD.xyz);
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
                    lightLoopTempC.xzw = albedo_and_ViewDepth.xyz * cb2[lightLoopTempC.x+0].xyz + -lightLoopTempE.xyz;
                    lightLoopTempC.xzw = lightingTempA.www * lightLoopTempC.xzw + lightLoopTempE.xyz;
                    lightLoopTempC.xzw = cb2[shadingInfo_and_Temp.z+0].xxx * lightLoopTempC.xzw;
                    lightLoopTempA.xyz = cb2[shadingInfo_and_Temp.w+0].www * lightLoopTempA.xyz;
                    shadingInfo_and_Temp.w = dot(lightLoopTempA.xyz, lightLoopTempA.xyz);
                    shadingInfo_and_Temp.w = shadingInfo_and_Temp.w * cb2[lightLoopTempB.w+0].x + cb2[lightLoopTempB.w+0].y;
                    shadingInfo_and_Temp.w = 9.99999975e-005 + shadingInfo_and_Temp.w;
                    shadingInfo_and_Temp.w = 1 / shadingInfo_and_Temp.w;
                    shadingInfo_and_Temp.w = -1 + shadingInfo_and_Temp.w;
                    shadingInfo_and_Temp.w = cb2[lightLoopTempB.w+0].z * shadingInfo_and_Temp.w;
                    shadingInfo_and_Temp.w = shadingInfo_and_Temp.w * shadingInfo_and_Temp.w;
                    shadingInfo_and_Temp.w = min(1, shadingInfo_and_Temp.w);
                    if (4 == 0) lightingTempA.w = 0; else if (4+16 < 32) {       lightingTempA.w = (uint)cb2[lightLoopTempB.x+0].w << (32-(4 + 16)); lightingTempA.w = (uint)lightingTempA.w >> (32-4);      } else lightingTempA.w = (uint)cb2[lightLoopTempB.x+0].w >> 16;
                    lightingTempA.w = ((int)lightingTempA.w == 2) ? 1.0 : 0.0;
                    lightingTempB.w = dot(lightLoopTempD.xyz, cb2[lightLoopTempB.x+0].xyz);
                    lightingTempB.w = -cb2[lightLoopTempB.y+0].x + lightingTempB.w;
                    lightingTempB.w = saturate(cb2[lightLoopTempB.y+0].y * lightingTempB.w);
                    lightingTempB.w = lightingTempB.w * lightingTempB.w;
                    lightingTempB.w = lightingTempB.w * lightingTempB.w;
                    lightingTempB.w = lightingTempB.w * shadingInfo_and_Temp.w;
                    shadingInfo_and_Temp.w = lightingTempA.w ? lightingTempB.w : shadingInfo_and_Temp.w;
                    lightingTempA.w = dot(lightingTempB.xyz, lightLoopTempD.xyz);
                    lightingTempA.w = saturate(lightingTempA.w * 0.5 + 0.5);
                    lightingTempA.w = normalData_and_Temp.w * lightingTempA.w + -normalData_and_Temp.x;
                    lightingTempA.w = cb2[lightLoopTempB.w+0].w * lightingTempA.w + normalData_and_Temp.x;
                    lightLoopTempA.xyz = cb2[lightLoopTempB.z+0].www * lightingTempC.xyz;
                    lightLoopTempB.xyw = -lightingTempC.xyz * cb2[lightLoopTempB.z+0].www + albedo_and_ViewDepth.xyz;
                    lightLoopTempA.xyz = lightingTempA.www * lightLoopTempB.xyw + lightLoopTempA.xyz;
                    lightLoopTempA.xyz = cb2[lightLoopTempB.z+0].xyz * lightLoopTempA.xyz;
                    lightingTempA.w = cb2[lightLoopTempB.z+0].x + cb2[lightLoopTempB.z+0].y;
                    lightingTempA.w = cb2[lightLoopTempB.z+0].z + lightingTempA.w;
                    lightingTempA.w = cb2[shadingInfo_and_Temp.z+0].x + lightingTempA.w;
                    lightingTempA.w = saturate(10 * lightingTempA.w);
                    shadingInfo_and_Temp.z = cb2[shadingInfo_and_Temp.z+0].y * lightingTempA.w;
                    lightLoopTempB.xyz = lightLoopTempC.xzw * shadingInfo_and_Temp.www;
                    lightLoopTempA.xyz = lightLoopTempA.xyz * shadingInfo_and_Temp.www + lightLoopTempB.xyz;
                    worldNormal_and_WorldPos.w = worldNormal_and_WorldPos.w + -shadingInfo_and_Temp.w;
                    shadingInfo_and_Temp.w = cb2[lightLoopTempC.y+0].w * worldNormal_and_WorldPos.w + shadingInfo_and_Temp.w;
                    accumulatedLightColor.xyz = lightLoopTempA.xyz * materialParams_and_Temp.www + accumulatedLightColor.xyz;
                    shadingInfo_and_Temp.z = -shadingInfo_and_Temp.w * shadingInfo_and_Temp.z + 1;
                    materialParams_and_Temp.w = shadingInfo_and_Temp.z * materialParams_and_Temp.w;
                    }
                    customDataA_and_Temp.x = (int)customDataA_and_Temp.x + 1;
                }
                shadingInfo_and_Temp.yzw = materialParams_and_Temp.www * shadingModelFlags_and_Temp.xyw + accumulatedLightColor.xyz;
                normalData_and_Temp.x = ((int)shadingInfo_and_Temp.x != 13) ? 1.0 : 0.0;
                if (normalData_and_Temp.x != 0) {
                    normalData_and_Temp.x = ((int)shadingInfo_and_Temp.x == 1) ? 1.0 : 0.0;
                    normalData_and_Temp.x = normalData_and_Temp.x ? customDataA_and_Temp.z : customDataA_and_Temp.y;
                    customDataA_and_Temp.xyz = cb1[67].xyz + -worldNormal_and_WorldPos.xyz;
                    normalData_and_Temp.w = dot(customDataA_and_Temp.xyz, customDataA_and_Temp.xyz);
                    normalData_and_Temp.w = rsqrt(normalData_and_Temp.w);
                    customDataA_and_Temp.xyz = customDataA_and_Temp.xyz * normalData_and_Temp.www;
                    normalData_and_Temp.w = saturate(-0.100000001 + normalData_and_Temp.x);
                    normalData_and_Temp.x = saturate(10 * normalData_and_Temp.x);
                    materialParams_and_Temp.w = normalData_and_Temp.w * 2000 + 50;
                    shadingInfo_and_Temp.x = normalData_and_Temp.w + normalData_and_Temp.w;
                    normalData_and_Temp.x = cb0[0].x * normalData_and_Temp.x;
                    normalData_and_Temp.x = normalData_and_Temp.x * 0.800000012 + shadingInfo_and_Temp.x;
                    shadingModelFlags_and_Temp.xyw = cb1[21].xyz * materialParams_and_Temp.yyy;
                    shadingModelFlags_and_Temp.xyw = materialParams_and_Temp.xxx * cb1[20].xyz + shadingModelFlags_and_Temp.xyw;
                    shadingModelFlags_and_Temp.xyw = materialParams_and_Temp.zzz * cb1[22].xyz + shadingModelFlags_and_Temp.xyw;
                    shadingInfo_and_Temp.x = asint(cb0[0].w);
                    shadingInfo_and_Temp.x = (0.5 < shadingInfo_and_Temp.x) ? 1.0 : 0.0;
                    customDataA_and_Temp.xyz = shadingInfo_and_Temp.xxx ? float3(0,0,0) : customDataA_and_Temp.xyz;
                    worldNormal_and_WorldPos.xy = shadingInfo_and_Temp.xx ? cb0[0].yz : cb1[264].xy;
                    worldNormal_and_WorldPos.z = shadingInfo_and_Temp.x ? 0.5 : cb1[264].z;
                    materialParams_and_Temp.xyz = shadingInfo_and_Temp.xxx ? shadingModelFlags_and_Temp.xyw : materialParams_and_Temp.xyz;
                    shadingInfo_and_Temp.x = dot(worldNormal_and_WorldPos.xyz, materialParams_and_Temp.xyz);
                    lightingTempB.xy = float2(0.200000003,1) + shadingInfo_and_Temp.xx;
                    shadingInfo_and_Temp.x = 5 * lightingTempB.x;
                    shadingInfo_and_Temp.x = saturate(shadingInfo_and_Temp.x);
                    shadingModelFlags_and_Temp.w = shadingInfo_and_Temp.x * -2 + 3;
                    shadingInfo_and_Temp.x = shadingInfo_and_Temp.x * shadingInfo_and_Temp.x;
                    shadingInfo_and_Temp.x = shadingModelFlags_and_Temp.w * shadingInfo_and_Temp.x;
                    lightingTempB.xzw = worldNormal_and_WorldPos.xyz + customDataA_and_Temp.xyz;
                    shadingModelFlags_and_Temp.w = dot(lightingTempB.xzw, lightingTempB.xzw);
                    shadingModelFlags_and_Temp.w = rsqrt(shadingModelFlags_and_Temp.w);
                    lightingTempB.xzw = lightingTempB.xzw * shadingModelFlags_and_Temp.www;
                    shadingModelFlags_and_Temp.w = saturate(dot(materialParams_and_Temp.xyz, lightingTempB.xzw));
                    shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.w * shadingModelFlags_and_Temp.w;
                    shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.w * -0.800000012 + 1;
                    shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.w * shadingModelFlags_and_Temp.w;
                    shadingModelFlags_and_Temp.w = 3.14159274 * shadingModelFlags_and_Temp.w;
                    shadingModelFlags_and_Temp.w = 0.200000003 / shadingModelFlags_and_Temp.w;
                    shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.w * customDataA_and_Temp.w;
                    worldNormal_and_WorldPos.x = dot(worldNormal_and_WorldPos.xyz, customDataA_and_Temp.xyz);
                    worldNormal_and_WorldPos.xy = float2(-0.5,1) + -worldNormal_and_WorldPos.xx;
                    worldNormal_and_WorldPos.x = saturate(worldNormal_and_WorldPos.x + worldNormal_and_WorldPos.x);
                    worldNormal_and_WorldPos.z = worldNormal_and_WorldPos.x * -2 + 3;
                    worldNormal_and_WorldPos.x = worldNormal_and_WorldPos.x * worldNormal_and_WorldPos.x;
                    worldNormal_and_WorldPos.x = worldNormal_and_WorldPos.z * worldNormal_and_WorldPos.x + 1;
                    materialParams_and_Temp.x = saturate(dot(customDataA_and_Temp.xyz, materialParams_and_Temp.xyz));
                    materialParams_and_Temp.x = 0.800000012 + -materialParams_and_Temp.x;
                    materialParams_and_Temp.x = max(0, materialParams_and_Temp.x);
                    materialParams_and_Temp.y = max(0, cb1[133].x);
                    materialParams_and_Temp.y = min(1.74532926, materialParams_and_Temp.y);
                    materialParams_and_Temp.xy = float2(1.5,0.572957814) * materialParams_and_Temp.xy;
                    materialParams_and_Temp.z = max(0, albedo_and_ViewDepth.w);
                    customDataA_and_Temp.xy = min(float2(3000,50), materialParams_and_Temp.zz);
                    customDataA_and_Temp.xy = float2(3000,50) + -customDataA_and_Temp.xy;
                    customDataA_and_Temp.xy = float2(0.00033333333,0.0199999996) * customDataA_and_Temp.xy;
                    materialParams_and_Temp.z = customDataA_and_Temp.x * customDataA_and_Temp.x;
                    materialParams_and_Temp.z = materialParams_and_Temp.z * materialParams_and_Temp.z;
                    materialParams_and_Temp.z = materialParams_and_Temp.z * materialParams_and_Temp.z + customDataA_and_Temp.y;
                    materialParams_and_Temp.z = -1 + materialParams_and_Temp.z;
                    materialParams_and_Temp.y = materialParams_and_Temp.y * materialParams_and_Temp.z + 1;
                    materialParams_and_Temp.z = 1 + -materialParams_and_Temp.y;
                    materialParams_and_Temp.y = normalData_and_Temp.w * materialParams_and_Temp.z + materialParams_and_Temp.y;
                    materialParams_and_Temp.z = lightingTempB.y * 0.25 + 0.5;
                    materialParams_and_Temp.x = materialParams_and_Temp.z * materialParams_and_Temp.x;
                    materialParams_and_Temp.x = materialParams_and_Temp.x * materialParams_and_Temp.y;
                    materialParams_and_Temp.x = materialParams_and_Temp.x * worldNormal_and_WorldPos.x;
                    materialParams_and_Temp.x = 0.00999999978 * materialParams_and_Temp.x;
                    customDataA_and_Temp.xy = float2(9.99999975e-005,9.99999975e-005) + shadingModelFlags_and_Temp.xy;
                    materialParams_and_Temp.z = dot(customDataA_and_Temp.xy, customDataA_and_Temp.xy);
                    materialParams_and_Temp.z = rsqrt(materialParams_and_Temp.z);
                    customDataA_and_Temp.xy = customDataA_and_Temp.xy * materialParams_and_Temp.zz;
                    customDataA_and_Temp.xy = customDataA_and_Temp.xy * normalData_and_Temp.xx;
                    customDataA_and_Temp.z = customDataA_and_Temp.y * materialParams_and_Temp.x;
                    materialParams_and_Temp.y = -0.5;
                    materialParams_and_Temp.xy = customDataA_and_Temp.xz * materialParams_and_Temp.xy;
                    normalData_and_Temp.x = 0.400000006 * worldNormal_and_WorldPos.y;
                    materialParams_and_Temp.z = shadingInfo_and_Temp.x * 0.800000012 + 0.200000003;
                    customDataA_and_Temp.x = shadingModelFlags_and_Temp.w * shadingInfo_and_Temp.x;
                    customDataA_and_Temp.x = 1.5 * customDataA_and_Temp.x;
                    normalData_and_Temp.x = normalData_and_Temp.x * materialParams_and_Temp.z + customDataA_and_Temp.x;
                    materialParams_and_Temp.z = customDataA_and_Temp.w * 0.5 + 0.5;
                    normalData_and_Temp.x = materialParams_and_Temp.z * normalData_and_Temp.x;
                    customDataA_and_Temp.xy = screenUV.xy * cb1[138].xy + -cb1[134].xy;
                    materialParams_and_Temp.xy = customDataA_and_Temp.xy * cb1[135].zw + materialParams_and_Temp.xy;
                    materialParams_and_Temp.xy = materialParams_and_Temp.xy * cb1[135].xy + cb1[134].xy;
                    materialParams_and_Temp.xy = cb1[138].zw * materialParams_and_Temp.xy;
                    float reprojectedDepth = tex2D(_IN6, materialParams_and_Temp.xy).x;
                    float reprojectedViewDepth = reprojectedDepth * cb1[65].x + cb1[65].y;
                    reprojectedDepth = reprojectedDepth * cb1[65].z + -cb1[65].w;
                    reprojectedDepth = 1 / reprojectedDepth;
                    reprojectedViewDepth = reprojectedViewDepth + reprojectedDepth;
                    reprojectedDepth = reprojectedViewDepth + -albedo_and_ViewDepth.w;
                    reprojectedDepth = max(9.99999975e-005, reprojectedDepth);
                    normalData_and_Temp.w = -normalData_and_Temp.w * 1000 + reprojectedDepth;
                    reprojectedDepth = 1 / materialParams_and_Temp.w;
                    normalData_and_Temp.w = saturate(reprojectedDepth * normalData_and_Temp.w);
                    reprojectedDepth = normalData_and_Temp.w * -2 + 3;
                    normalData_and_Temp.w = normalData_and_Temp.w * normalData_and_Temp.w;
                    normalData_and_Temp.w = reprojectedDepth * normalData_and_Temp.w;
                    normalData_and_Temp.w = min(1, normalData_and_Temp.w);
                    materialParams_and_Temp.x = dot(cb1[263].xyz, float3(0.300000012,0.589999974,0.109999999));
                    materialParams_and_Temp.yzw = cb1[263].xyz + -materialParams_and_Temp.xxx;
                    materialParams_and_Temp.xyz = materialParams_and_Temp.yzw * float3(0.75,0.75,0.75) + materialParams_and_Temp.xxx;
                    customDataA_and_Temp.xyz = cb1[263].xyz + -materialParams_and_Temp.xyz;
                    materialParams_and_Temp.xyz = customDataA_and_Temp.www * customDataA_and_Temp.xyz + materialParams_and_Temp.xyz;
                    materialParams_and_Temp.xyz = materialParams_and_Temp.xyz * normalData_and_Temp.xxx;
                    materialParams_and_Temp.xyz = float3(0.100000001,0.100000001,0.100000001) * materialParams_and_Temp.xyz;
                    customDataA_and_Temp.xyz = float3(1,1,1) + albedo_and_ViewDepth.xyz;
                    customDataA_and_Temp.xyz = customDataA_and_Temp.xyz * materialParams_and_Temp.xyz;
                    shadingModelFlags_and_Temp.xyw = albedo_and_ViewDepth.xyz * float3(1.20000005,1.20000005,1.20000005) + float3(-1,-1,-1);
                    shadingModelFlags_and_Temp.xyw = saturate(-shadingModelFlags_and_Temp.xyw);
                    worldNormal_and_WorldPos.xyz = shadingModelFlags_and_Temp.xyw * float3(-2,-2,-2) + float3(3,3,3);
                    shadingModelFlags_and_Temp.xyw = shadingModelFlags_and_Temp.xyw * shadingModelFlags_and_Temp.xyw;
                    shadingModelFlags_and_Temp.xyw = worldNormal_and_WorldPos.xyz * shadingModelFlags_and_Temp.xyw;
                    shadingModelFlags_and_Temp.xyw = shadingModelFlags_and_Temp.xyw * float3(14,14,14) + float3(1,1,1);
                    materialParams_and_Temp.xyz = shadingModelFlags_and_Temp.xyw * materialParams_and_Temp.xyz;
                    materialParams_and_Temp.xyz = materialParams_and_Temp.xyz * albedo_and_ViewDepth.xyz + -customDataA_and_Temp.xyz;
                    materialParams_and_Temp.xyz = cb1[260].zzz * materialParams_and_Temp.xyz + customDataA_and_Temp.xyz;
                    materialParams_and_Temp.xyz = materialParams_and_Temp.xyz * normalData_and_Temp.www;
                    normalData_and_Temp.x = -10000 + albedo_and_ViewDepth.w;
                    normalData_and_Temp.x = max(0, normalData_and_Temp.x);
                    normalData_and_Temp.x = min(5000, normalData_and_Temp.x);
                    normalData_and_Temp.x = 5000 + -normalData_and_Temp.x;
                    normalData_and_Temp.x = 0.000199999995 * normalData_and_Temp.x;
                    materialParams_and_Temp.xyz = normalData_and_Temp.xxx * materialParams_and_Temp.xyz;
                    materialParams_and_Temp.xyz = cb0[1].xyz * materialParams_and_Temp.xyz;
                } else {
                    materialParams_and_Temp.xyz = float3(0,0,0);
                }
                normalData_and_Temp.x = (0 != shadingModelFlags_and_Temp.z) ? 1.0 : 0.0;
                albedo_and_ViewDepth.xyz = shadingInfo_and_Temp.yzw * lightingTempA.xyz;
                albedo_and_ViewDepth.xyz = cb1[263].xyz * albedo_and_ViewDepth.xyz;
                albedo_and_ViewDepth.xyz = albedo_and_ViewDepth.xyz * float3(0.5,0.5,0.5) + -shadingInfo_and_Temp.yzw;
                albedo_and_ViewDepth.xyz = normalData_and_Temp.www * albedo_and_ViewDepth.xyz + shadingInfo_and_Temp.yzw;
                materialParams_and_Temp.xyz = shadingInfo_and_Temp.yzw + materialParams_and_Temp.xyz;
                materialParams_and_Temp.xyz = normalData_and_Temp.xxx ? albedo_and_ViewDepth.xyz : materialParams_and_Temp.xyz;
                normalData_and_Temp.xzw = normalData_and_Temp.zzz ? shadingInfo_and_Temp.yzw : materialParams_and_Temp.xyz;
                normalData_and_Temp.xyz = normalData_and_Temp.xzw / normalData_and_Temp.yyy;
                normalData_and_Temp.xyz = min(float3(0,0,0), -normalData_and_Temp.xyz);
                finalColor.xyz = -normalData_and_Temp.xyz;
                return finalColor;
            }
            ENDCG
        }
    }
}