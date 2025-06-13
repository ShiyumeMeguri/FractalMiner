Shader "Custom/WWToon"
{
    Properties
    {
        
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
            
float4 frag (VertexToFragment fragmentInput) : SV_Target
{
    float4 screenUV = float4(fragmentInput.uv.xy, 0.0, 0.0);
    
    float4 finalColor = float4(0.0, 0.0, 0.0, 0.0);

    float4 gbufferData_and_Temp;
    float4 materialParams_and_Lighting;
    float4 baseColor_and_Depth;
    float4 customDataA_and_Temp;
    float4 shadingInfo_and_Temp;
    float4 shadingModelFlags_and_Temp;
    float4 worldNormal_and_WorldPos;
    float4 lightingTempA;
    float4 lightingTempB;
    float4 lightingTempC;
    float4 accumulatedLightColor;
    float4 lightLoopTempA;
    float4 lightLoopTempB;
    float4 lightLoopTempC;
    float4 lightLoopTempD;
    float4 lightLoopTempE;
    float4 lightLoopTempF;

    gbufferData_and_Temp.xyzw = tex2Dlod(_IN1, float4(screenUV.xy, 0, 0)).wxyz;
    materialParams_and_Lighting.xyzw = tex2Dlod(_IN2, float4(screenUV.xy, 0, 0)).xyzw;
    baseColor_and_Depth.xyz = tex2Dlod(_IN3, float4(screenUV.xy, 0, 0)).xyz;
    customDataA_and_Temp.xyz = tex2Dlod(_IN4, float4(screenUV.xy, 0, 0)).yxz;

    baseColor_and_Depth.w = tex2Dlod(_IN0, float4(screenUV.xy, 0, 0)).x;
    customDataA_and_Temp.w = baseColor_and_Depth.w * cb1[65].x + cb1[65].y;
    baseColor_and_Depth.w = baseColor_and_Depth.w * cb1[65].z + -cb1[65].w;
    baseColor_and_Depth.w = 1.0 / baseColor_and_Depth.w;
    baseColor_and_Depth.w = customDataA_and_Temp.w + baseColor_and_Depth.w;
    
    shadingInfo_and_Temp.xy = cb1[138].xy * screenUV.xy;
    shadingInfo_and_Temp.xy = (uint2)shadingInfo_and_Temp.xy;
    customDataA_and_Temp.w = (uint)cb1[158].x;
    shadingInfo_and_Temp.x = (int)shadingInfo_and_Temp.y + (int)shadingInfo_and_Temp.x;
    customDataA_and_Temp.w = (int)customDataA_and_Temp.w + (int)shadingInfo_and_Temp.x;
    customDataA_and_Temp.w = (int)customDataA_and_Temp.w & 1;

    materialParams_and_Lighting.w = round(255.0 * materialParams_and_Lighting.w);
    shadingInfo_and_Temp.xy = (int2)((uint)materialParams_and_Lighting.w) & int2(15, -16);
    
    materialParams_and_Lighting.w = ((int)shadingInfo_and_Temp.x != 12) ? 1.0 : 0.0;
    shadingModelFlags_and_Temp.xyz = ((int3)shadingInfo_and_Temp.xxx == int3(13, 14, 15)) ? float3(1.0, 1.0, 1.0) : float3(0.0, 0.0, 0.0);
    shadingInfo_and_Temp.z = (int)shadingModelFlags_and_Temp.z | (int)shadingModelFlags_and_Temp.y;
    shadingInfo_and_Temp.z = (int)shadingInfo_and_Temp.z | (int)shadingModelFlags_and_Temp.x;
    materialParams_and_Lighting.w = materialParams_and_Lighting.w ? shadingInfo_and_Temp.z : -1.0;
    
    if (materialParams_and_Lighting.w != 0.0)
    {
        shadingInfo_and_Temp.x = shadingModelFlags_and_Temp.x ? 13.0 : 12.0;
        shadingModelFlags_and_Temp.xz = shadingModelFlags_and_Temp.yz ? float2(1.0, 1.0) : float2(0.0, 0.0);

        shadingInfo_and_Temp.zw = gbufferData_and_Temp.yz * 2.0 - 1.0;
        materialParams_and_Lighting.w = dot(float2(1.0, 1.0), abs(shadingInfo_and_Temp.zw));
        worldNormal_and_WorldPos.z = 1.0 - materialParams_and_Lighting.w;
        materialParams_and_Lighting.w = max(0.0, -worldNormal_and_WorldPos.z);
        
        lightingTempA.xy = (shadingInfo_and_Temp.zw >= float2(0.0, 0.0)) ? float2(1.0, 1.0) : float2(0.0, 0.0);
        lightingTempA.xy = lightingTempA.xy ? float2(0.5, 0.5) : float2(-0.5, -0.5);
        lightingTempA.xy = lightingTempA.xy * materialParams_and_Lighting.ww;
        worldNormal_and_WorldPos.xy = lightingTempA.xy * -2.0 + shadingInfo_and_Temp.zw;
        
        materialParams_and_Lighting.w = dot(worldNormal_and_WorldPos.xyz, worldNormal_and_WorldPos.xyz);
        materialParams_and_Lighting.w = rsqrt(materialParams_and_Lighting.w);
        worldNormal_and_WorldPos.xyz = worldNormal_and_WorldPos.xyz * materialParams_and_Lighting.www;
        
        lightingTempA.xyz = materialParams_and_Lighting.xyz * materialParams_and_Lighting.xyz;
        shadingModelFlags_and_Temp.y = customDataA_and_Temp.z;
    }
    else
    {
        materialParams_and_Lighting.w = ((int)shadingInfo_and_Temp.x == 10) ? 1.0 : 0.0;
        float3 clearCoatTemp = saturate(materialParams_and_Lighting.xyz);
        clearCoatTemp = round(float3(16777215.0, 65535.0, 255.0) * clearCoatTemp);
        uint3 clearCoatUint = (uint3)clearCoatTemp;
        
        clearCoatUint.y = (clearCoatUint.z & 0xff) | (clearCoatUint.y & ~0xff);
        clearCoatUint.x = (clearCoatUint.y & 0xffff) | (clearCoatUint.x & ~0xffff);
        
        float packed_depth_float = 5.96046519e-08 * (float)clearCoatUint.x;
        float linear_depth_temp = packed_depth_float * cb1[65].x + cb1[65].y;
        float linear_depth_p1 = packed_depth_float * cb1[65].z - cb1[65].w;
        float final_packed_depth = linear_depth_temp + (1.0 / linear_depth_p1);
        
        baseColor_and_Depth.w = materialParams_and_Lighting.w ? final_packed_depth : baseColor_and_Depth.w;
        
        worldNormal_and_WorldPos.xyz = gbufferData_and_Temp.yzw * 2.0 - 1.0;
        lightingTempA.xyz = float3(0.0, 0.0, 0.0);
        shadingModelFlags_and_Temp.xyz = float3(0.0, 0.0, 0.0);
        gbufferData_and_Temp.xw = float2(0.0, 0.0);
        customDataA_and_Temp.xy = float2(0.0, 0.0);
    }
    
    gbufferData_and_Temp.y = dot(worldNormal_and_WorldPos.xyz, worldNormal_and_WorldPos.xyz);
    gbufferData_and_Temp.y = rsqrt(gbufferData_and_Temp.y);
    materialParams_and_Lighting.xyz = worldNormal_and_WorldPos.xyz * gbufferData_and_Temp.yyy;
    
    gbufferData_and_Temp.yz = ((int2)shadingInfo_and_Temp.xx == int2(5, 13)) ? float2(1.0, 1.0) : float2(0.0, 0.0);
    materialParams_and_Lighting.w = (0.0 < cb1[162].y) ? 1.0 : 0.0;
    shadingInfo_and_Temp.z = (0.0 < cb1[220].z) ? 1.0 : 0.0;
    materialParams_and_Lighting.w = materialParams_and_Lighting.w ? shadingInfo_and_Temp.z : 0.0;
    shadingInfo_and_Temp.z = (0.0 != cb1[162].y) ? 1.0 : 0.0;
    
    worldNormal_and_WorldPos.xyz = shadingInfo_and_Temp.zzz ? float3(1.0, 1.0, 1.0) : baseColor_and_Depth.xyz;
    customDataA_and_Temp.w = customDataA_and_Temp.w ? 1.0 : 0.0;
    worldNormal_and_WorldPos.xyz = materialParams_and_Lighting.www ? customDataA_and_Temp.www : worldNormal_and_WorldPos.xyz;
    baseColor_and_Depth.xyz = gbufferData_and_Temp.yyy > 0.0 ? worldNormal_and_WorldPos.xyz : baseColor_and_Depth.xyz;
    
    gbufferData_and_Temp.y = tex2Dlod(_IN9, float4(0.0, 0.0, 0.0, 0.0)).x;
    
    shadingInfo_and_Temp.zw = screenUV.zw * baseColor_and_Depth.ww;
    worldNormal_and_WorldPos.xyz = cb1[49].xyz * shadingInfo_and_Temp.www;
    worldNormal_and_WorldPos.xyz = shadingInfo_and_Temp.zzz * cb1[48].xyz + worldNormal_and_WorldPos.xyz;
    worldNormal_and_WorldPos.xyz = baseColor_and_Depth.www * cb1[50].xyz + worldNormal_and_WorldPos.xyz;
    worldNormal_and_WorldPos.xyz = cb1[51].xyz + worldNormal_and_WorldPos.xyz;
    
    shadingInfo_and_Temp.zw = tex2Dlod(_IN5, float4(screenUV.xy, 0, 0)).xz;
    shadingInfo_and_Temp.zw = shadingInfo_and_Temp.zw * shadingInfo_and_Temp.zw;
    materialParams_and_Lighting.w = shadingInfo_and_Temp.z * shadingInfo_and_Temp.w;
    customDataA_and_Temp.w = cb1[253].y * materialParams_and_Lighting.w;
    
    if (cb1[255].x != 0.0)
    {
        lightingTempB.xyz = float3(0.0, 0.0, 0.0);
        shadingInfo_and_Temp.z = 0.0;
        shadingInfo_and_Temp.w = 0.0;
        shadingModelFlags_and_Temp.w = 0.0;
        worldNormal_and_WorldPos.w = 0.0;
        
        while (true)
        {
            if (((int)shadingInfo_and_Temp.z >= 3)) break;

            shadingInfo_and_Temp.w = 0.000833333295 + shadingInfo_and_Temp.w;
            lightingTempC.xyz = lightingTempB.xyz;
            lightingTempA.w = shadingModelFlags_and_Temp.w;
            lightingTempB.w = worldNormal_and_WorldPos.w;
            lightingTempC.w = 0.0;
            
            while (true)
            {
                if (((int)lightingTempC.w >= 3)) break;
                
                lightingTempA.w = 1.0 + lightingTempA.w;
                float angle_rad = 2.09439516 * lightingTempA.w;
                sincos(angle_rad, accumulatedLightColor.x, lightLoopTempA.x);
                lightLoopTempA.xy = float2(lightLoopTempA.x, accumulatedLightColor.x) * shadingInfo_and_Temp.w + screenUV.xy;
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

        lightingTempC.xyz = (float3(0.644999981, 0.312000006, 0.978999972) < gbufferData_and_Temp.xxx) ? float3(1.0, 1.0, 1.0) : float3(0.0, 0.0, 0.0);
        accumulatedLightColor.xyz = (gbufferData_and_Temp.xxx < float3(0.685000002, 0.351999998, 1.02100003)) ? float3(1.0, 1.0, 1.0) : float3(0.0, 0.0, 0.0);
        lightingTempC.xyz = lightingTempC.xyz ? accumulatedLightColor.xyz : float3(0.0, 0.0, 0.0);

        gbufferData_and_Temp.x = lightingTempC.z ? 1.0 : 0.0;
        gbufferData_and_Temp.x = lightingTempC.y ? 0.0 : gbufferData_and_Temp.x;
        gbufferData_and_Temp.x = lightingTempC.x ? 1.0 : gbufferData_and_Temp.x;

        shadingInfo_and_Temp.z = (int)lightingTempC.y | (int)lightingTempC.z;
        shadingInfo_and_Temp.z = asfloat(asuint(shadingInfo_and_Temp.z) & 0x3f800000);
        shadingInfo_and_Temp.z = lightingTempC.x ? 0.0 : shadingInfo_and_Temp.z;
        
        customDataA_and_Temp.x = round(255.0 * customDataA_and_Temp.x);
        lightingTempC.xyzw = (uint4)((int4)((uint)customDataA_and_Temp.xxxx) & int4(15, 240, 240, 15));
        
        customDataA_and_Temp.x = saturate(gbufferData_and_Temp.w + gbufferData_and_Temp.w);
        shadingInfo_and_Temp.w = customDataA_and_Temp.x * -2.0 + 3.0;
        customDataA_and_Temp.x = customDataA_and_Temp.x * customDataA_and_Temp.x;
        customDataA_and_Temp.x = shadingInfo_and_Temp.w * customDataA_and_Temp.x;
        
        shadingInfo_and_Temp.w = saturate((gbufferData_and_Temp.w - 0.5) * 2.0);
        shadingModelFlags_and_Temp.w = shadingInfo_and_Temp.w * -2.0 + 3.0;
        shadingInfo_and_Temp.w = shadingInfo_and_Temp.w * shadingInfo_and_Temp.w;
        shadingInfo_and_Temp.w = shadingModelFlags_and_Temp.w * shadingInfo_and_Temp.w;
        
        accumulatedLightColor.xyz = cb1[262].xyz - cb1[261].xyz;
        shadingModelFlags_and_Temp.w = dot(abs(accumulatedLightColor.xyz), float3(0.300000012, 0.589999974, 0.109999999));
        shadingModelFlags_and_Temp.w = min(1.0, 10.0 * shadingModelFlags_and_Temp.w);
        worldNormal_and_WorldPos.w = shadingModelFlags_and_Temp.w * -2.0 + 3.0;
        shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.w * shadingModelFlags_and_Temp.w;
        shadingModelFlags_and_Temp.w = worldNormal_and_WorldPos.w * shadingModelFlags_and_Temp.w;
        
        worldNormal_and_WorldPos.w = shadingModelFlags_and_Temp.w * shadingInfo_and_Temp.w;
        
        lightingTempA.w = 1.0 / (cb1[265].y - cb1[265].x);
        lightingTempB.w = customDataA_and_Temp.w - cb1[265].x;
        lightingTempB.w = saturate(lightingTempB.w * lightingTempA.w);
        accumulatedLightColor.x = lightingTempB.w * -2.0 + 3.0;
        lightingTempB.w = lightingTempB.w * lightingTempB.w;
        lightingTempB.w = accumulatedLightColor.x * lightingTempB.w;
        lightingTempB.w = lightingTempB.w * worldNormal_and_WorldPos.w;
        
        accumulatedLightColor.x = customDataA_and_Temp.w - lightingTempB.w;
        lightingTempB.w = cb1[265].z * accumulatedLightColor.x + lightingTempB.w;
        
        accumulatedLightColor.x = -cb1[265].x + lightingTempB.w;
        lightingTempA.w = saturate(accumulatedLightColor.x * lightingTempA.w);
        accumulatedLightColor.x = lightingTempA.w * -2.0 + 3.0;
        lightingTempA.w = lightingTempA.w * lightingTempA.w;
        lightingTempA.w = accumulatedLightColor.x * lightingTempA.w;
        
        worldNormal_and_WorldPos.w = lightingTempA.w * worldNormal_and_WorldPos.w;
        shadingInfo_and_Temp.w = shadingInfo_and_Temp.w * shadingModelFlags_and_Temp.w - worldNormal_and_WorldPos.w;
        shadingInfo_and_Temp.w = cb1[265].z * shadingInfo_and_Temp.w + worldNormal_and_WorldPos.w;
        
        shadingModelFlags_and_Temp.w = cb1[260].y * (lightingTempB.w - 1.0) + 1.0;
        worldNormal_and_WorldPos.w = customDataA_and_Temp.x * shadingInfo_and_Temp.w - shadingModelFlags_and_Temp.w;
        shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.x * worldNormal_and_WorldPos.w + shadingModelFlags_and_Temp.w;
        
        worldNormal_and_WorldPos.w = customDataA_and_Temp.x * shadingInfo_and_Temp.w - shadingInfo_and_Temp.w;
        accumulatedLightColor.x = shadingModelFlags_and_Temp.x * worldNormal_and_WorldPos.w + shadingInfo_and_Temp.w;
        
        shadingInfo_and_Temp.w = (lightingTempB.y >= lightingTempB.z) ? 1.0 : 0.0;
        lightLoopTempA.xy = lightingTempB.zy;
        lightLoopTempA.zw = float2(-1.0, 0.666666687);
        lightLoopTempB.xy = -lightLoopTempA.xy + lightingTempB.yz;
        lightLoopTempB.zw = float2(1.0, -1.0);
        lightLoopTempA.xyzw = shadingInfo_and_Temp.wwww * lightLoopTempB.xyzw + lightLoopTempA.xyzw;
        
        shadingInfo_and_Temp.w = (lightingTempB.x >= lightLoopTempA.x) ? 1.0 : 0.0;
        lightLoopTempB.xyz = lightLoopTempA.xyw;
        lightLoopTempB.w = lightingTempB.x;
        lightLoopTempA.xyw = lightLoopTempB.wyx;
        lightLoopTempA.xyzw = lightLoopTempA.xyzw - lightLoopTempB.xyzw;
        lightLoopTempA.xyzw = shadingInfo_and_Temp.wwww * lightLoopTempA.xyzw + lightLoopTempB.xyzw;
        
        shadingInfo_and_Temp.w = lightLoopTempA.x - min(lightLoopTempA.w, lightLoopTempA.y);
        worldNormal_and_WorldPos.w = (lightLoopTempA.w - lightLoopTempA.y) / (shadingInfo_and_Temp.w * 6.0 + 0.00100000005);
        worldNormal_and_WorldPos.w = lightLoopTempA.z + worldNormal_and_WorldPos.w;
        shadingInfo_and_Temp.w = shadingInfo_and_Temp.w / (lightLoopTempA.x + 0.00100000005);

        lightLoopTempA.xyzw = (float4)lightingTempC.xyzw * float4(0.0400000028, 0.0027450982, 0.00392156886, 0.0666666701) + float4(0.400000006, 0.400000006, 1.0, 0.5);
        lightingTempB.w = (lightingTempC.z >= 2.54999971) ? 1.0 : 0.0;
        lightingTempC.x = lightingTempB.w * (lightLoopTempA.y - lightLoopTempA.x) + lightLoopTempA.x;
        shadingInfo_and_Temp.w = min(0.349999994, lightingTempC.x * shadingInfo_and_Temp.w);
        lightingTempC.x = max(0.0, shadingInfo_and_Temp.w);

        lightingTempC.yzw = frac(float3(1.0, 0.666666687, 0.333333343) + abs(worldNormal_and_WorldPos.www));
        lightingTempC.yzw = saturate(abs(lightingTempC.yzw * 6.0 - 3.0) - 1.0);
        lightingTempC.yzw = lightingTempC.yzw - 1.0;
        lightingTempC.xyz = lightingTempC.xxx * lightingTempC.yzw + 1.0;

        shadingInfo_and_Temp.w = 1.0 + shadingInfo_and_Temp.w;
        lightLoopTempB.xyz = lightingTempC.xyz * shadingInfo_and_Temp.www;
        lightLoopTempC.xyz = lightingTempC.xyz * shadingInfo_and_Temp.www - 1.0;
        lightLoopTempC.xyz = lightLoopTempC.xyz * 0.600000024 + 1.0;
        lightingTempC.xyz = -lightingTempC.xyz * shadingInfo_and_Temp.www + lightLoopTempC.xyz;
        lightingTempC.xyz = gbufferData_and_Temp.xxx * lightingTempC.xyz + lightLoopTempB.xyz;
        lightLoopTempB.xyz = (lightingTempC.xyz - baseColor_and_Depth.xyz) * 0.850000024 + baseColor_and_Depth.xyz;
        lightLoopTempA.xyz = lightLoopTempA.zzz * lightLoopTempB.xyz - lightingTempC.xyz;
        lightingTempC.xyz = lightingTempB.www * lightLoopTempA.xyz + lightingTempC.xyz;
        lightingTempC.xyz = (lightingTempC.xyz - 1.0) * lightLoopTempA.www + 1.0;
        
        lightLoopTempA.xyz = 0.200000003 * cb1[261].xyz;
        lightLoopTempB.xyz = cb1[262].xyz * 0.5 - lightLoopTempA.xyz;
        lightLoopTempA.xyz = shadingModelFlags_and_Temp.www * lightLoopTempB.xyz + lightLoopTempA.xyz;
        lightLoopTempA.xyz = cb1[260].xxx * lightLoopTempA.xyz;
        lightLoopTempA.xyz = lightLoopTempA.xyz * baseColor_and_Depth.xyz;
        lightLoopTempB.xyz = lightLoopTempA.xyz * lightingTempA.xyz;
        lightLoopTempC.xyz = cb1[261].xyz * baseColor_and_Depth.xyz;
        gbufferData_and_Temp.x = customDataA_and_Temp.x * 0.300000012 + 0.699999988;
        lightLoopTempD.xyz = lightLoopTempC.xyz * gbufferData_and_Temp.xxx;
        lightLoopTempE.xyz = cb1[262].xyz * baseColor_and_Depth.xyz;
        lightLoopTempB.xyz = lightLoopTempC.xyz * gbufferData_and_Temp.xxx + lightLoopTempB.xyz;
        lightLoopTempC.xyz = baseColor_and_Depth.xyz * cb1[262].xyz - lightLoopTempD.xyz;
        lightLoopTempC.xyz = lightLoopTempC.xyz * 0.400000006 + lightLoopTempD.xyz;
        lightLoopTempF.xyz = lightLoopTempD.xyz * lightingTempC.xyz;
        lightLoopTempC.xyz = lightLoopTempC.xyz * lightingTempC.xyz - lightLoopTempF.xyz;
        lightLoopTempC.xyz = accumulatedLightColor.xxx * lightLoopTempC.xyz + lightLoopTempF.xyz;
        lightLoopTempA.xyz = lightLoopTempA.xyz * lightingTempA.xyz + lightLoopTempC.xyz;
        lightLoopTempB.xyz = lightLoopTempB.xyz * lightingTempC.xyz;
        lightLoopTempC.xyz = lightLoopTempE.xyz * lightLoopTempA.www;
        lightingTempC.xyz = lightLoopTempC.xyz * lightingTempC.xyz - lightLoopTempB.xyz;
        lightingTempC.xyz = accumulatedLightColor.xxx * lightingTempC.xyz + lightLoopTempB.xyz;

        gbufferData_and_Temp.x = tex2Dlod(_IN8, float4(screenUV.xy, 0, 0)).x;
        gbufferData_and_Temp.x = shadingInfo_and_Temp.z * (gbufferData_and_Temp.x - 1.0) + 1.0;
        
        lightingTempC.xyz = lightingTempC.xyz - lightLoopTempA.xyz;
        lightingTempC.xyz = shadingModelFlags_and_Temp.www * lightingTempC.xyz + lightLoopTempA.xyz;
        
        lightLoopTempA.xyz = 1.0 - lightLoopTempB.xyz;
        lightingTempB.xyz = gbufferData_and_Temp.xxx * lightLoopTempA.xyz + lightLoopTempB.xyz;
        lightingTempB.xyz = lightingTempC.xyz * lightingTempB.xyz;
    }
    else
    {
        gbufferData_and_Temp.x = saturate(gbufferData_and_Temp.w + gbufferData_and_Temp.w);
        customDataA_and_Temp.x = gbufferData_and_Temp.x * -2.0 + 3.0;
        gbufferData_and_Temp.x = gbufferData_and_Temp.x * gbufferData_and_Temp.x;
        gbufferData_and_Temp.x = customDataA_and_Temp.x * gbufferData_and_Temp.x;
        
        customDataA_and_Temp.x = saturate((gbufferData_and_Temp.w - 0.5) * 2.0);
        shadingInfo_and_Temp.z = customDataA_and_Temp.x * -2.0 + 3.0;
        customDataA_and_Temp.x = customDataA_and_Temp.x * customDataA_and_Temp.x;
        customDataA_and_Temp.x = shadingInfo_and_Temp.z * customDataA_and_Temp.x;

        lightingTempC.xyz = cb1[262].xyz - cb1[261].xyz;
        shadingInfo_and_Temp.z = dot(abs(lightingTempC.xyz), float3(0.300000012, 0.589999974, 0.109999999));
        shadingInfo_and_Temp.z = min(1.0, 10.0 * shadingInfo_and_Temp.z);
        shadingInfo_and_Temp.w = shadingInfo_and_Temp.z * -2.0 + 3.0;
        shadingInfo_and_Temp.z = shadingInfo_and_Temp.z * shadingInfo_and_Temp.z;
        shadingInfo_and_Temp.z = shadingInfo_and_Temp.w * shadingInfo_and_Temp.z;
        
        shadingInfo_and_Temp.w = shadingInfo_and_Temp.z * customDataA_and_Temp.x;

        shadingModelFlags_and_Temp.w = 1.0 / (cb1[265].y - cb1[265].x);
        worldNormal_and_WorldPos.w = materialParams_and_Lighting.w * cb1[253].y - cb1[265].x;
        worldNormal_and_WorldPos.w = saturate(worldNormal_and_WorldPos.w * shadingModelFlags_and_Temp.w);
        lightingTempA.w = worldNormal_and_WorldPos.w * -2.0 + 3.0;
        worldNormal_and_WorldPos.w = worldNormal_and_WorldPos.w * worldNormal_and_WorldPos.w;
        worldNormal_and_WorldPos.w = lightingTempA.w * worldNormal_and_WorldPos.w;
        worldNormal_and_WorldPos.w = worldNormal_and_WorldPos.w * shadingInfo_and_Temp.w;

        materialParams_and_Lighting.w = materialParams_and_Lighting.w * cb1[253].y - worldNormal_and_WorldPos.w;
        materialParams_and_Lighting.w = cb1[265].z * materialParams_and_Lighting.w + worldNormal_and_WorldPos.w;
        
        worldNormal_and_WorldPos.w = -cb1[265].x + materialParams_and_Lighting.w;
        shadingModelFlags_and_Temp.w = saturate(worldNormal_and_WorldPos.w * shadingModelFlags_and_Temp.w);
        worldNormal_and_WorldPos.w = shadingModelFlags_and_Temp.w * -2.0 + 3.0;
        shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.w * shadingModelFlags_and_Temp.w;
        shadingModelFlags_and_Temp.w = worldNormal_and_WorldPos.w * shadingModelFlags_and_Temp.w;
        
        shadingInfo_and_Temp.w = shadingModelFlags_and_Temp.w * shadingInfo_and_Temp.w;
        
        customDataA_and_Temp.x = customDataA_and_Temp.x * shadingInfo_and_Temp.z - shadingInfo_and_Temp.w;
        customDataA_and_Temp.x = cb1[265].z * customDataA_and_Temp.x + shadingInfo_and_Temp.w;
        
        materialParams_and_Lighting.w = cb1[260].y * (materialParams_and_Lighting.w - 1.0) + 1.0;
        
        shadingInfo_and_Temp.w = customDataA_and_Temp.w * customDataA_and_Temp.x - materialParams_and_Lighting.w;
        materialParams_and_Lighting.w = shadingModelFlags_and_Temp.x * shadingInfo_and_Temp.w + materialParams_and_Lighting.w;
        
        shadingInfo_and_Temp.w = customDataA_and_Temp.w * customDataA_and_Temp.x - customDataA_and_Temp.x;
        accumulatedLightColor.x = shadingModelFlags_and_Temp.x * shadingInfo_and_Temp.w + customDataA_and_Temp.x;
        
        shadingModelFlags_and_Temp.xyw = 0.200000003 * cb1[261].xyz;
        lightingTempC.xyz = cb1[262].xyz * 0.5 - shadingModelFlags_and_Temp.xyw;
        shadingModelFlags_and_Temp.xyw = materialParams_and_Lighting.www * lightingTempC.xyz + shadingModelFlags_and_Temp.xyw;
        shadingModelFlags_and_Temp.xyw = cb1[260].xxx * shadingModelFlags_and_Temp.xyw;
        shadingModelFlags_and_Temp.xyw = shadingModelFlags_and_Temp.xyw * baseColor_and_Depth.xyz;
        
        lightingTempC.xyz = shadingModelFlags_and_Temp.xyw * lightingTempA.xyz;
        lightLoopTempA.xyz = cb1[261].xyz * baseColor_and_Depth.xyz;
        gbufferData_and_Temp.x = gbufferData_and_Temp.x * 0.300000012 + 0.699999988;
        lightLoopTempD.xyz = lightLoopTempA.xyz * gbufferData_and_Temp.xxx;
        lightLoopTempA.xyz = lightLoopTempD.xyz + lightingTempC.xyz;
        lightingTempC.xyz = lightingTempC.xyz * shadingInfo_and_Temp.zzz + lightLoopTempA.xyz;
        
        lightLoopTempA.xyz = baseColor_and_Depth.xyz * cb1[262].xyz - lightLoopTempD.xyz;
        lightLoopTempA.xyz = lightLoopTempA.xyz * accumulatedLightColor.xxx;
        lightLoopTempA.xyz = lightLoopTempA.xyz * 0.400000006 + lightLoopTempD.xyz;
        
        shadingModelFlags_and_Temp.xyw = shadingModelFlags_and_Temp.xyw * lightingTempA.xyz + lightLoopTempA.xyz;
        
        lightLoopTempA.xyz = baseColor_and_Depth.xyz * cb1[262].xyz - lightingTempC.xyz;
        lightingTempC.xyz = accumulatedLightColor.xxx * lightLoopTempA.xyz + lightingTempC.xyz;
        
        lightingTempC.xyz = lightingTempC.xyz - shadingModelFlags_and_Temp.xyw;
        lightingTempB.xyz = materialParams_and_Lighting.www * lightingTempC.xyz + shadingModelFlags_and_Temp.xyw;
    }
    
    gbufferData_and_Temp.x = saturate(10.000001 * (gbufferData_and_Temp.w - 0.400000006));
    gbufferData_and_Temp.w = gbufferData_and_Temp.x * -2.0 + 3.0;
    gbufferData_and_Temp.x = gbufferData_and_Temp.x * gbufferData_and_Temp.x;
    accumulatedLightColor.y = gbufferData_and_Temp.w * gbufferData_and_Temp.x;
    
    shadingModelFlags_and_Temp.xyw = lightingTempB.xyz * 0.5 + cb1[261].xyz;
    shadingModelFlags_and_Temp.xyw = shadingModelFlags_and_Temp.xyw * baseColor_and_Depth.xyz;
    lightingTempC.xyz = cb1[261].xyz * baseColor_and_Depth.xyz;
    shadingModelFlags_and_Temp.xyw = cb1[255].xxx ? shadingModelFlags_and_Temp.xyw : lightingTempC.xyz;
    
    lightingTempC.xyz = gbufferData_and_Temp.zzz ? shadingModelFlags_and_Temp.xyw : lightLoopTempD.xyz;
    shadingModelFlags_and_Temp.xyw = gbufferData_and_Temp.zzz ? shadingModelFlags_and_Temp.xyw : lightingTempB.xyz;
    
    gbufferData_and_Temp.xw = gbufferData_and_Temp.zz ? float2(0.0, 0.0) : accumulatedLightColor.xy;
    
    lightingTempB.xyz = (cb1[264].xyz + cb1[264].xyz) * gbufferData_and_Temp.xxx - cb1[264].xyz;
    accumulatedLightColor.xyz = float3(0.0, 0.0, 0.0);
    materialParams_and_Lighting.w = 1.0;
    customDataA_and_Temp.x = 0;
    
    uint numLights = asuint(cb2[128].x);
    while ((uint)customDataA_and_Temp.x < numLights)
    {
        uint lightIndex_base = (uint)customDataA_and_Temp.x << 3;
        shadingInfo_and_Temp.z = lightIndex_base | 7;
        
        uint lightDataFlags = asuint(cb2[shadingInfo_and_Temp.z].w);
        uint lightTypeMask = (asuint(shadingInfo_and_Temp.y)) & ((lightDataFlags << 5) & 0xffffffe0);
        
        if (lightTypeMask != 0)
        {
            lightLoopTempA.xyz = cb2[lightIndex_base + 0].xyz - worldNormal_and_WorldPos.xyz;
            worldNormal_and_WorldPos.w = cb2[lightIndex_base + 0].w * cb2[lightIndex_base + 0].w;
            lightingTempA.w = dot(lightLoopTempA.xyz, lightLoopTempA.xyz);
            worldNormal_and_WorldPos.w = lightingTempA.w * worldNormal_and_WorldPos.w;
            
            if (1.0 >= worldNormal_and_WorldPos.w)
            {
                uint lightIndex_1 = lightIndex_base | 1;
                uint lightIndex_2 = lightIndex_base | 2;
                uint lightIndex_3 = lightIndex_base | 3;
                uint lightIndex_4 = lightIndex_base | 4;
                uint lightIndex_5 = lightIndex_base | 5;
                uint lightIndex_6 = lightIndex_base | 6;

                lightingTempB.w = saturate(worldNormal_and_WorldPos.w * 2.5 - 1.5);
                worldNormal_and_WorldPos.w = (lightingTempB.w * -2.0 + 3.0) * (-lightingTempB.w * lightingTempB.w) + 1.0;
                
                lightingTempA.w = rsqrt(lightingTempA.w);
                lightLoopTempD.xyz = lightLoopTempA.xyz * lightingTempA.www;
                
                lightingTempA.w = dot(materialParams_and_Lighting.xyz, lightLoopTempD.xyz);
                lightingTempA.w = (lightingTempA.w + 1.0) * 0.5 - (cb2[lightIndex_5].w * 0.939999998);
                lightingTempB.w = 1.0 / (cb2[lightIndex_5].w * 0.0600000024);
                lightingTempA.w = saturate(lightingTempB.w * lightingTempA.w);
                lightingTempB.w = lightingTempA.w * -2.0 + 3.0;
                lightingTempA.w = lightingTempA.w * lightingTempA.w;
                lightingTempA.w = min(1.0, lightingTempB.w * lightingTempA.w);

                lightLoopTempE.xyz = cb2[lightIndex_6].xyz * lightingTempC.xyz;
                lightLoopTempC.xzw = baseColor_and_Depth.xyz * cb2[lightIndex_5].xyz - lightLoopTempE.xyz;
                lightLoopTempC.xzw = lightingTempA.www * lightLoopTempC.xzw + lightLoopTempE.xyz;
                lightLoopTempC.xzw = cb2[shadingInfo_and_Temp.z].xxx * lightLoopTempC.xzw;

                shadingInfo_and_Temp.w = dot(lightLoopTempA.xyz, lightLoopTempA.xyz);
                shadingInfo_and_Temp.w = shadingInfo_and_Temp.w * cb2[lightIndex_4].x + cb2[lightIndex_4].y;
                shadingInfo_and_Temp.w = 1.0 / (9.99999975e-05 + shadingInfo_and_Temp.w);
                shadingInfo_and_Temp.w = (shadingInfo_and_Temp.w - 1.0) * cb2[lightIndex_4].z;
                shadingInfo_and_Temp.w = min(1.0, shadingInfo_and_Temp.w * shadingInfo_and_Temp.w);
                
                uint lightFlags = asuint(cb2[lightIndex_1].w) >> 16;
                if (lightFlags == 2)
                {
                    lightingTempB.w = dot(lightLoopTempD.xyz, cb2[lightIndex_1].xyz);
                    lightingTempB.w = saturate(cb2[lightIndex_2].y * (lightingTempB.w - cb2[lightIndex_2].x));
                    lightingTempB.w = lightingTempB.w * lightingTempB.w;
                    lightingTempB.w = lightingTempB.w * lightingTempB.w;
                    shadingInfo_and_Temp.w = lightingTempB.w * shadingInfo_and_Temp.w;
                }
                
                lightingTempA.w = saturate(dot(lightingTempB.xyz, lightLoopTempD.xyz) * 0.5 + 0.5);
                lightingTempA.w = gbufferData_and_Temp.w * lightingTempA.w - gbufferData_and_Temp.x;
                lightingTempA.w = cb2[lightIndex_4].w * lightingTempA.w + gbufferData_and_Temp.x;

                lightLoopTempA.xyz = cb2[lightIndex_3].www * lightLoopTempC.xzw;
                lightLoopTempB.xyw = -lightLoopTempC.xzw * cb2[lightIndex_3].www + baseColor_and_Depth.xyz;
                lightLoopTempA.xyz = lightingTempA.www * lightLoopTempB.xyw + lightLoopTempA.xyz;
                lightLoopTempA.xyz = cb2[lightIndex_3].xyz * lightLoopTempA.xyz;
                
                lightingTempA.w = cb2[lightIndex_3].x + cb2[lightIndex_3].y + cb2[lightIndex_3].z + cb2[shadingInfo_and_Temp.z].x;
                lightingTempA.w = saturate(10.0 * lightingTempA.w);
                shadingInfo_and_Temp.z = cb2[shadingInfo_and_Temp.z].y * lightingTempA.w;
                
                lightLoopTempB.xyz = lightLoopTempC.xzw * shadingInfo_and_Temp.www;
                lightLoopTempA.xyz = lightLoopTempA.xyz * shadingInfo_and_Temp.www + lightLoopTempB.xyz;
                
                worldNormal_and_WorldPos.w = worldNormal_and_WorldPos.w - shadingInfo_and_Temp.w;
                shadingInfo_and_Temp.w = cb2[lightIndex_6].w * worldNormal_and_WorldPos.w + shadingInfo_and_Temp.w;
                
                accumulatedLightColor.xyz = lightLoopTempA.xyz * materialParams_and_Lighting.www + accumulatedLightColor.xyz;
                shadingInfo_and_Temp.z = -shadingInfo_and_Temp.w * shadingInfo_and_Temp.z + 1.0;
                materialParams_and_Lighting.w = shadingInfo_and_Temp.z * materialParams_and_Lighting.w;
            }
        }
        customDataA_and_Temp.x = (int)customDataA_and_Temp.x + 1;
    }
    
    shadingInfo_and_Temp.yzw = materialParams_and_Lighting.www * shadingModelFlags_and_Temp.xyw + accumulatedLightColor.xyz;
    gbufferData_and_Temp.x = ((int)shadingInfo_and_Temp.x != 13) ? 1.0 : 0.0;
    
    if (gbufferData_and_Temp.x != 0.0)
    {
        gbufferData_and_Temp.x = ((int)shadingInfo_and_Temp.x == 1) ? 1.0 : 0.0;
        gbufferData_and_Temp.x = gbufferData_and_Temp.x ? customDataA_and_Temp.z : customDataA_and_Temp.y;
        
        customDataA_and_Temp.xyz = cb1[67].xyz - worldNormal_and_WorldPos.xyz;
        gbufferData_and_Temp.w = rsqrt(dot(customDataA_and_Temp.xyz, customDataA_and_Temp.xyz));
        customDataA_and_Temp.xyz = customDataA_and_Temp.xyz * gbufferData_and_Temp.www;
        
        gbufferData_and_Temp.w = saturate(gbufferData_and_Temp.x - 0.100000001);
        gbufferData_and_Temp.x = saturate(10.0 * gbufferData_and_Temp.x);
        
        materialParams_and_Lighting.w = gbufferData_and_Temp.w * 2000.0 + 50.0;
        shadingInfo_and_Temp.x = gbufferData_and_Temp.w + gbufferData_and_Temp.w;
        gbufferData_and_Temp.x = cb0[0].x * gbufferData_and_Temp.x;
        gbufferData_and_Temp.x = gbufferData_and_Temp.x * 0.800000012 + shadingInfo_and_Temp.x;
        
        shadingModelFlags_and_Temp.xyw = materialParams_and_Lighting.yyy * cb1[21].xyz;
        shadingModelFlags_and_Temp.xyw = materialParams_and_Lighting.xxx * cb1[20].xyz + shadingModelFlags_and_Temp.xyw;
        shadingModelFlags_and_Temp.xyw = materialParams_and_Lighting.zzz * cb1[22].xyz + shadingModelFlags_and_Temp.xyw;
        
        shadingInfo_and_Temp.x = (asint(cb0[0].w) > 0) ? 1.0 : 0.0;
        customDataA_and_Temp.xyz = shadingInfo_and_Temp.xxx ? float3(0.0, 0.0, 0.0) : customDataA_and_Temp.xyz;
        worldNormal_and_WorldPos.xy = shadingInfo_and_Temp.xx ? cb0[0].yz : cb1[264].xy;
        worldNormal_and_WorldPos.z = shadingInfo_and_Temp.x ? 0.5 : cb1[264].z;
        materialParams_and_Lighting.xyz = shadingInfo_and_Temp.xxx ? shadingModelFlags_and_Temp.xyw : materialParams_and_Lighting.xyz;
        
        shadingInfo_and_Temp.x = dot(worldNormal_and_WorldPos.xyz, materialParams_and_Lighting.xyz);
        
        lightingTempB.xy = float2(0.200000003, 1.0) + shadingInfo_and_Temp.xx;
        shadingInfo_and_Temp.x = saturate(5.0 * lightingTempB.x);
        shadingModelFlags_and_Temp.w = shadingInfo_and_Temp.x * -2.0 + 3.0;
        shadingInfo_and_Temp.x = shadingInfo_and_Temp.x * shadingInfo_and_Temp.x;
        shadingInfo_and_Temp.x = shadingModelFlags_and_Temp.w * shadingInfo_and_Temp.x;
        
        lightingTempB.xzw = worldNormal_and_WorldPos.xyz + customDataA_and_Temp.xyz;
        shadingModelFlags_and_Temp.w = rsqrt(dot(lightingTempB.xzw, lightingTempB.xzw));
        lightingTempB.xzw = lightingTempB.xzw * shadingModelFlags_and_Temp.www;
        shadingModelFlags_and_Temp.w = saturate(dot(materialParams_and_Lighting.xyz, lightingTempB.xzw));
        shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.w * shadingModelFlags_and_Temp.w;
        shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.w * -0.800000012 + 1.0;
        shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.w * shadingModelFlags_and_Temp.w;
        shadingModelFlags_and_Temp.w = 0.200000003 / (3.14159274 * shadingModelFlags_and_Temp.w);
        shadingModelFlags_and_Temp.w = shadingModelFlags_and_Temp.w * customDataA_and_Temp.w;

        worldNormal_and_WorldPos.x = dot(worldNormal_and_WorldPos.xyz, customDataA_and_Temp.xyz);
        worldNormal_and_WorldPos.x = saturate((worldNormal_and_WorldPos.x + worldNormal_and_WorldPos.x));
        worldNormal_and_WorldPos.z = worldNormal_and_WorldPos.x * -2.0 + 3.0;
        worldNormal_and_WorldPos.x = worldNormal_and_WorldPos.x * worldNormal_and_WorldPos.x;
        worldNormal_and_WorldPos.x = worldNormal_and_WorldPos.z * worldNormal_and_WorldPos.x + 1.0;

        materialParams_and_Lighting.x = max(0.0, 0.800000012 - saturate(dot(customDataA_and_Temp.xyz, materialParams_and_Lighting.xyz)));
        materialParams_and_Lighting.y = min(1.74532926, max(0.0, cb1[133].x));
        materialParams_and_Lighting.xy = float2(1.5, 0.572957814) * materialParams_and_Lighting.xy;

        materialParams_and_Lighting.z = max(0.0, baseColor_and_Depth.w);
        customDataA_and_Temp.xy = float2(3000.0, 50.0) - min(float2(3000.0, 50.0), materialParams_and_Lighting.zz);
        customDataA_and_Temp.xy = float2(0.00033333333, 0.0199999996) * customDataA_and_Temp.xy;
        materialParams_and_Lighting.z = customDataA_and_Temp.x * customDataA_and_Temp.x;
        materialParams_and_Lighting.z = materialParams_and_Lighting.z * materialParams_and_Lighting.z;
        materialParams_and_Lighting.z = materialParams_and_Lighting.z * materialParams_and_Lighting.z + customDataA_and_Temp.y;
        
        materialParams_and_Lighting.y = materialParams_and_Lighting.y * (materialParams_and_Lighting.z - 1.0) + 1.0;
        materialParams_and_Lighting.y = gbufferData_and_Temp.w * (1.0 - materialParams_and_Lighting.y) + materialParams_and_Lighting.y;

        materialParams_and_Lighting.z = lightingTempB.y * 0.25 + 0.5;
        materialParams_and_Lighting.x = materialParams_and_Lighting.z * materialParams_and_Lighting.x;
        materialParams_and_Lighting.x = materialParams_and_Lighting.x * materialParams_and_Lighting.y;
        materialParams_and_Lighting.x = materialParams_and_Lighting.x * worldNormal_and_WorldPos.x;
        materialParams_and_Lighting.x = 0.00999999978 * materialParams_and_Lighting.x;
        
        customDataA_and_Temp.xy = materialParams_and_Lighting.xy * materialParams_and_Lighting.xy + 9.99999975e-05;
        materialParams_and_Lighting.z = rsqrt(dot(customDataA_and_Temp.xy, float2(1.0, 1.0)));
        customDataA_and_Temp.xy = materialParams_and_Lighting.xy * materialParams_and_Lighting.zz;
        customDataA_and_Temp.xy = customDataA_and_Temp.xy * gbufferData_and_Temp.xx;
        
        customDataA_and_Temp.z = customDataA_and_Temp.y * materialParams_and_Lighting.x;
        materialParams_and_Lighting.y = -0.5;
        materialParams_and_Lighting.xy = customDataA_and_Temp.xz * materialParams_and_Lighting.xy;
        
        customDataA_and_Temp.xy = screenUV.xy * cb1[138].xy - cb1[134].xy;
        materialParams_and_Lighting.xy = customDataA_and_Temp.xy * cb1[135].zw + materialParams_and_Lighting.xy;
        materialParams_and_Lighting.xy = materialParams_and_Lighting.xy * cb1[135].xy + cb1[134].xy;
        materialParams_and_Lighting.xy = cb1[138].zw * materialParams_and_Lighting.xy;
        
        float reprojectedDepth = tex2D(_IN6, materialParams_and_Lighting.xy).x;
        float reprojectedViewDepth = reprojectedDepth * cb1[65].x + cb1[65].y;
        reprojectedDepth = 1.0 / (reprojectedDepth * cb1[65].z - cb1[65].w);
        reprojectedViewDepth = reprojectedViewDepth + reprojectedDepth;
        
        reprojectedDepth = max(9.99999975e-05, reprojectedViewDepth - baseColor_and_Depth.w);
        gbufferData_and_Temp.w = saturate((reprojectedDepth - gbufferData_and_Temp.w * 1000.0) / materialParams_and_Lighting.w);
        reprojectedDepth = gbufferData_and_Temp.w * -2.0 + 3.0;
        gbufferData_and_Temp.w = gbufferData_and_Temp.w * gbufferData_and_Temp.w;
        gbufferData_and_Temp.w = min(1.0, reprojectedDepth * gbufferData_and_Temp.w);
        
        materialParams_and_Lighting.x = dot(cb1[263].xyz, float3(0.300000012, 0.589999974, 0.109999999));
        materialParams_and_Lighting.yzw = cb1[263].xyz - materialParams_and_Lighting.xxx;
        materialParams_and_Lighting.xyz = materialParams_and_Lighting.yzw * 0.75 + materialParams_and_Lighting.xxx;
        customDataA_and_Temp.xyz = cb1[263].xyz - materialParams_and_Lighting.xyz;
        materialParams_and_Lighting.xyz = gbufferData_and_Temp.www * customDataA_and_Temp.xyz + materialParams_and_Lighting.xyz;
        materialParams_and_Lighting.xyz = materialParams_and_Lighting.xyz * gbufferData_and_Temp.xxx;
        materialParams_and_Lighting.xyz = 0.100000001 * materialParams_and_Lighting.xyz;
        
        customDataA_and_Temp.xyz = (1.0 + baseColor_and_Depth.xyz) * materialParams_and_Lighting.xyz;
        shadingModelFlags_and_Temp.xyw = saturate(baseColor_and_Depth.xyz * 1.20000005 - 1.0);
        worldNormal_and_WorldPos.xyz = shadingModelFlags_and_Temp.xyw * -2.0 + 3.0;
        shadingModelFlags_and_Temp.xyw = shadingModelFlags_and_Temp.xyw * shadingModelFlags_and_Temp.xyw;
        shadingModelFlags_and_Temp.xyw = worldNormal_and_WorldPos.xyz * shadingModelFlags_and_Temp.xyw;
        shadingModelFlags_and_Temp.xyw = shadingModelFlags_and_Temp.xyw * 14.0 + 1.0;
        
        materialParams_and_Lighting.xyz = shadingModelFlags_and_Temp.xyw * materialParams_and_Lighting.xyz;
        materialParams_and_Lighting.xyz = materialParams_and_Lighting.xyz * baseColor_and_Depth.xyz - customDataA_and_Temp.xyz;
        materialParams_and_Lighting.xyz = cb1[260].zzz * materialParams_and_Lighting.xyz + customDataA_and_Temp.xyz;
        materialParams_and_Lighting.xyz = materialParams_and_Lighting.xyz * gbufferData_and_Temp.www;
        
        gbufferData_and_Temp.x = 0.000199999995 * (5000.0 - min(5000.0, max(0.0, baseColor_and_Depth.w - 10000.0)));
        materialParams_and_Lighting.xyz = gbufferData_and_Temp.xxx * materialParams_and_Lighting.xyz;
        materialParams_and_Lighting.xyz = cb0[1].xyz * materialParams_and_Lighting.xyz;
    }
    else
    {
        materialParams_and_Lighting.xyz = float3(0.0, 0.0, 0.0);
    }
    
    gbufferData_and_Temp.x = (shadingModelFlags_and_Temp.z != 0.0) ? 1.0 : 0.0;
    
    baseColor_and_Depth.xyz = shadingInfo_and_Temp.yzw * lightingTempA.xyz;
    baseColor_and_Depth.xyz = cb1[263].xyz * baseColor_and_Depth.xyz;
    baseColor_and_Depth.xyz = baseColor_and_Depth.xyz * 0.5 - shadingInfo_and_Temp.yzw;
    baseColor_and_Depth.xyz = gbufferData_and_Temp.www * baseColor_and_Depth.xyz + shadingInfo_and_Temp.yzw;
    
    materialParams_and_Lighting.xyz = shadingInfo_and_Temp.yzw + materialParams_and_Lighting.xyz;
    materialParams_and_Lighting.xyz = gbufferData_and_Temp.xxx ? baseColor_and_Depth.xyz : materialParams_and_Lighting.xyz;
    
    gbufferData_and_Temp.xzw = gbufferData_and_Temp.zzz ? shadingInfo_and_Temp.yzw : materialParams_and_Lighting.xyz;
    
    gbufferData_and_Temp.xyz = gbufferData_and_Temp.xzw / gbufferData_and_Temp.yyy;
    gbufferData_and_Temp.xyz = min(float3(0.0, 0.0, 0.0), -gbufferData_and_Temp.xyz);
    
    finalColor.xyz = -gbufferData_and_Temp.xyz;
    return finalColor;
}
            ENDCG
        }
    }
}