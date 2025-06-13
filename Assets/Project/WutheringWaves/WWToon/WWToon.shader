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
            #pragma target 5.0
            //#pragma enable_d3d11_debug_symbols
            
            #include "UnityCG.cginc"

            struct VertexInput
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct VertexToFragment
            {
                float4 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };
            
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
            float4 _ScaledScreenParams;     // cb1[138] zw不等价需要-1

            VertexToFragment vert (VertexInput vertexInput)
            {
                VertexToFragment output;
                output.vertex = UnityObjectToClipPos(vertexInput.vertex);
                output.uv.xy = vertexInput.uv;
                // 计算 NDC x（clip.x / clip.w）并复制到 zw
                float ndcX = output.vertex.x / output.vertex.w;
                output.uv.zw = ndcX;
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
            // 已知 _IN5 R是阴影 G未使用 B是阴影强度 A通道为什么和B一样
            // 已知 _IN6 R16深度
            // 已知 _IN7 1x1像素 全0
            // 已知 _IN8 MSSAO 多分辨率屏幕空间AO
            // 已知 _IN9 1x1像素 控制屏幕亮度
            
float4 frag (VertexToFragment fragmentInput) : SV_Target
{
    // 基于输入uv定义screenUV_ndcUV，zw分量是NDC x（clip.x / clip.w）并复制到 zw
    float4 screenUV_ndcUV = fragmentInput.uv; 

    float4 color = 0;
    
    float4 normal_perObjectData = 0, msr_shadingModelID = 0, albedo_alpha = 0, customData = 0, model15_modelN16 = 0, r5 = 0, r6 = 0, r7 = 0, r8 = 0, r9 = 0, r10 = 0, r11 = 0, r12 = 0, r13 = 0, r14 = 0, r15 = 0, r16 = 0;
uint4 bitmask = 0, uiDest = 0;
float4 fDest = 0;
    float alpha_dynamic;
    float cb1_158;
    float shadingModelID;
    float depth;

    normal_perObjectData.xyzw = tex2Dlod(_IN1, float4(screenUV_ndcUV.xy, 0, 0)).wxyz;
    msr_shadingModelID.xyzw = tex2Dlod(_IN2, float4(screenUV_ndcUV.xy, 0, 0)).xyzw;
    albedo_alpha.xyz = tex2Dlod(_IN3, float4(screenUV_ndcUV.xy, 0, 0)).xyz;
    customData.xyz = tex2Dlod(_IN4, float4(screenUV_ndcUV.xy, 0, 0)).yxz;
    
    depth = tex2Dlod(_IN0, float4(screenUV_ndcUV.xy, 0, 0)).x;
    alpha_dynamic = depth * cb1[65].x + cb1[65].y;
    depth = depth * cb1[65].z + -cb1[65].w;
    depth = 1 / depth;
    depth = alpha_dynamic + depth;
    
    uint2 uv_scaled = _ScaledScreenParams.xy * screenUV_ndcUV.xy;
    uv_scaled = (uint2)uv_scaled.xy;
    cb1_158 = (uint)cb1[158].x;
    uv_scaled.x = (int)uv_scaled.y + (int)uv_scaled.x;
    cb1_158 = (int)cb1_158 + (int)uv_scaled.x;
    cb1_158 = (int)cb1_158 & 1;
    
    shadingModelID = 255 * msr_shadingModelID.w;
    shadingModelID = round(shadingModelID);
    shadingModelID = (uint)shadingModelID;
    model15_modelN16.xy = (int2)shadingModelID & int2(15,-16);
    shadingModelID = ((int)model15_modelN16.x != 12) ? 1.0 : 0.0;
    r5.xyz = ((int3)model15_modelN16.xxx == int3(13,14,15)) ? 1.0 : 0.0;
    model15_modelN16.z = (int)r5.z | (int)r5.y;
    model15_modelN16.z = (int)model15_modelN16.z | (int)r5.x;
    shadingModelID = shadingModelID ? model15_modelN16.z : -1;
    if (shadingModelID != 0) {
        model15_modelN16.x = r5.x ? 13 : 12;
        r5.xz = r5.yz ? float2(1,1) : 0;
        model15_modelN16.zw = normal_perObjectData.yz * float2(2,2) + float2(-1,-1);
        shadingModelID = dot(float2(1,1), abs(model15_modelN16.zw));
        r6.z = 1 + -shadingModelID;
        shadingModelID = max(0, -r6.z);
        r7.xy = (model15_modelN16.zw >= float2(0,0)) ? 1.0 : 0.0;
        r7.xy = r7.xy ? float2(0.5,0.5) : float2(-0.5,-0.5);
        r7.xy = r7.xy * shadingModelID;
        r6.xy = r7.xy * float2(-2,-2) + model15_modelN16.zw;
        shadingModelID = dot(r6.xyz, r6.xyz);
        shadingModelID = rsqrt(shadingModelID);
        r6.xyz = r6.xyz * shadingModelID;
        r7.xyz = msr_shadingModelID.xyz * msr_shadingModelID.xyz;
        r5.y = customData.z;
    } else {
        shadingModelID = ((int)model15_modelN16.x == 10) ? 1.0 : 0.0;
        msr_shadingModelID.xyz = saturate(msr_shadingModelID.xyz);
        msr_shadingModelID.xyz = float3(16777215,65535,255) * msr_shadingModelID.xyz;
        msr_shadingModelID.xyz = round(msr_shadingModelID.xyz);
        msr_shadingModelID.xyz = (uint3)msr_shadingModelID.xyz;
        bitmask.y = ((~(-1 << 8)) << 0) & 0xffffffff;  msr_shadingModelID.y = (((uint)msr_shadingModelID.z << 0) & bitmask.y) | ((uint)msr_shadingModelID.y & ~bitmask.y);
        bitmask.x = ((~(-1 << 16)) << 0) & 0xffffffff;  msr_shadingModelID.x = (((uint)msr_shadingModelID.y << 0) & bitmask.x) | ((uint)msr_shadingModelID.x & ~bitmask.x);
        msr_shadingModelID.x = (uint)msr_shadingModelID.x;
        msr_shadingModelID.x = 5.96046519e-008 * msr_shadingModelID.x;
        msr_shadingModelID.y = msr_shadingModelID.x * cb1[65].x + cb1[65].y;
        msr_shadingModelID.x = msr_shadingModelID.x * cb1[65].z + -cb1[65].w;
        msr_shadingModelID.x = 1 / msr_shadingModelID.x;
        msr_shadingModelID.x = msr_shadingModelID.y + msr_shadingModelID.x;
        depth = shadingModelID ? msr_shadingModelID.x : depth;
        r6.xyz = normal_perObjectData.yzw * float3(2,2,2) + float3(-1,-1,-1);
        r7.xyz = float3(0,0,0);
        r5.xyz = float3(0,0,0);
        normal_perObjectData.xw = float2(0,0);
        customData.xy = float2(0,0);
    }
    normal_perObjectData.y = dot(r6.xyz, r6.xyz);
    normal_perObjectData.y = rsqrt(normal_perObjectData.y);
    msr_shadingModelID.xyz = r6.xyz * normal_perObjectData.yyy;
    normal_perObjectData.yz = ((int2)model15_modelN16.xx == int2(5,13)) ? 1.0 : 0.0;
    shadingModelID = (0 < cb1[162].y) ? 1.0 : 0.0;
    model15_modelN16.z = (0 < cb1[220].z) ? 1.0 : 0.0;
    shadingModelID = shadingModelID ? model15_modelN16.z : 0;
    model15_modelN16.z = (0 != cb1[162].y) ? 1.0 : 0.0;
    r6.xyz = model15_modelN16.zzz ? float3(1,1,1) : albedo_alpha.xyz;
    cb1_158 = cb1_158 ? 1 : 0;
    r6.xyz = shadingModelID ? cb1_158 : r6.xyz;
    albedo_alpha.xyz = normal_perObjectData.yyy ? r6.xyz : albedo_alpha.xyz;
    normal_perObjectData.y = tex2Dlod(_IN9, float4(0, 0, 0, 0)).x;
    model15_modelN16.zw = screenUV_ndcUV.zw * depth;
    r6.xyz = cb1[49].xyz * model15_modelN16.www;
    r6.xyz = model15_modelN16.zzz * cb1[48].xyz + r6.xyz;
    r6.xyz = depth * cb1[50].xyz + r6.xyz;
    r6.xyz = cb1[51].xyz + r6.xyz;
    model15_modelN16.zw = tex2Dlod(_IN5, float4(screenUV_ndcUV.xy, 0, 0)).xz;
    model15_modelN16.zw = model15_modelN16.zw * model15_modelN16.zw;
    shadingModelID = model15_modelN16.z * model15_modelN16.w;
    cb1_158 = cb1[253].y * shadingModelID;
    if (cb1[255].x != 0) {
        r8.xyz = float3(0,0,0);
        model15_modelN16.zw = float2(0,0);
        r5.w = 0;
        r6.w = 0;
        while (true) {
        r7.w = ((int)model15_modelN16.z >= 3) ? 1.0 : 0.0;
        if (r7.w != 0) break;
        model15_modelN16.w = 0.000833333295 + model15_modelN16.w;
        r9.xyz = r8.xyz;
        r7.w = r5.w;
        r8.w = r6.w;
        r9.w = 0;
        while (true) {
            r10.x = ((int)r9.w >= 3) ? 1.0 : 0.0;
            if (r10.x != 0) break;
            r7.w = 1 + r7.w;
            r10.x = 2.09439516 * r7.w;
            sincos(r10.x, r10.x, r11.x);
            r11.x = r11.x * model15_modelN16.w + screenUV_ndcUV.x;
            r11.y = r10.x * model15_modelN16.w + screenUV_ndcUV.y;
            r10.xyz = tex2D(_IN7, r11.xy).xyz;
            r9.xyz = r10.xyz * model15_modelN16.www + r9.xyz;
            r8.w = r8.w + model15_modelN16.w;
            r9.w = (int)r9.w + 1;
        }
        r8.xyz = r9.xyz;
        r6.w = r8.w;
        r5.w = 0.620000005 + r7.w;
        model15_modelN16.z = (int)model15_modelN16.z + 1;
        }
        r8.xyz = r8.xyz / r6.www;
        r9.xyz = (float3(0.644999981,0.312000006,0.978999972) < normal_perObjectData.xxx) ? 1.0 : 0.0;
        r10.xyz = (normal_perObjectData.xxx < float3(0.685000002,0.351999998,1.02100003)) ? 1.0 : 0.0;
        r9.xyz = r9.xyz ? r10.xyz : 0;
        normal_perObjectData.x = r9.z ? 1.000000 : 0;
        normal_perObjectData.x = r9.y ? 0 : normal_perObjectData.x;
        normal_perObjectData.x = r9.x ? 1 : normal_perObjectData.x;
        model15_modelN16.z = (int)r9.y | (int)r9.z;
        model15_modelN16.z = (int)model15_modelN16.z & 0x3f800000;
        model15_modelN16.z = r9.x ? 0 : model15_modelN16.z;
        customData.x = 255 * customData.x;
        customData.x = round(customData.x);
        customData.x = (uint)customData.x;
        r9.xyzw = (int4)customData.xxxx & int4(15,240,240,15);
        r9.xyzw = (uint4)r9.xyzw;
        customData.x = saturate(normal_perObjectData.w + normal_perObjectData.w);
        model15_modelN16.w = customData.x * -2 + 3;
        customData.x = customData.x * customData.x;
        customData.x = model15_modelN16.w * customData.x;
        model15_modelN16.w = -0.5 + normal_perObjectData.w;
        model15_modelN16.w = saturate(model15_modelN16.w + model15_modelN16.w);
        r5.w = model15_modelN16.w * -2 + 3;
        model15_modelN16.w = model15_modelN16.w * model15_modelN16.w;
        model15_modelN16.w = r5.w * model15_modelN16.w;
        r10.xyz = cb1[262].xyz + -cb1[261].xyz;
        r5.w = dot(abs(r10.xyz), float3(0.300000012,0.589999974,0.109999999));
        r5.w = 10 * r5.w;
        r5.w = min(1, r5.w);
        r6.w = r5.w * -2 + 3;
        r5.w = r5.w * r5.w;
        r5.w = r6.w * r5.w;
        r6.w = r5.w * model15_modelN16.w;
        r7.w = cb1[265].y + -cb1[265].x;
        r8.w = shadingModelID * cb1[253].y + -cb1[265].x;
        r7.w = 1 / r7.w;
        r8.w = saturate(r8.w * r7.w);
        r10.x = r8.w * -2 + 3;
        r8.w = r8.w * r8.w;
        r8.w = r10.x * r8.w;
        r8.w = r8.w * r6.w;
        r10.x = shadingModelID * cb1[253].y + -r8.w;
        r8.w = cb1[265].z * r10.x + r8.w;
        r10.x = -cb1[265].x + r8.w;
        r7.w = saturate(r10.x * r7.w);
        r10.x = r7.w * -2 + 3;
        r7.w = r7.w * r7.w;
        r7.w = r10.x * r7.w;
        r6.w = r7.w * r6.w;
        model15_modelN16.w = model15_modelN16.w * r5.w + -r6.w;
        model15_modelN16.w = cb1[265].z * model15_modelN16.w + r6.w;
        r5.w = -1 + r8.w;
        r5.w = cb1[260].y * r5.w + 1;
        r6.w = cb1_158 * model15_modelN16.w + -r5.w;
        r5.w = r5.x * r6.w + r5.w;
        r6.w = cb1_158 * model15_modelN16.w + -model15_modelN16.w;
        r10.x = r5.x * r6.w + model15_modelN16.w;
        model15_modelN16.w = (r8.y >= r8.z) ? 1.0 : 0.0;
        model15_modelN16.w = model15_modelN16.w ? 1.000000 : 0;
        r11.xy = r8.zy;
        r11.zw = float2(-1,0.666666687);
        r12.xy = -r11.xy + r8.yz;
        r12.zw = float2(1,-1);
        r11.xyzw = model15_modelN16.wwww * r12.xyzw + r11.xyzw;
        model15_modelN16.w = (r8.x >= r11.x) ? 1.0 : 0.0;
        model15_modelN16.w = model15_modelN16.w ? 1.000000 : 0;
        r12.xyz = r11.xyw;
        r12.w = r8.x;
        r11.xyw = r12.wyx;
        r11.xyzw = r11.xyzw + -r12.xyzw;
        r11.xyzw = model15_modelN16.wwww * r11.xyzw + r12.xyzw;
        model15_modelN16.w = min(r11.w, r11.y);
        model15_modelN16.w = r11.x + -model15_modelN16.w;
        r6.w = r11.w + -r11.y;
        r7.w = model15_modelN16.w * 6 + 0.00100000005;
        r6.w = r6.w / r7.w;
        r6.w = r11.z + r6.w;
        r7.w = 0.00100000005 + r11.x;
        model15_modelN16.w = model15_modelN16.w / r7.w;
        r7.w = r11.x * 0.300000012 + 1;
        r11.xyzw = r9.xyzw * float4(0.0400000028,0.0027450982,0.00392156886,0.0666666701) + float4(0.400000006,0.400000006,1,0.5);
        r8.w = (r9.z >= 2.54999971) ? 1.0 : 0.0;
        r8.w = r8.w ? 1.000000 : 0;
        r9.x = r11.y + -r11.x;
        r9.x = r8.w * r9.x + r11.x;
        model15_modelN16.w = r9.x * model15_modelN16.w;
        model15_modelN16.w = min(0.349999994, model15_modelN16.w);
        r9.x = max(0, model15_modelN16.w);
        r9.yzw = float3(1,0.666666687,0.333333343) + abs(r6.www);
        r9.yzw = frac(r9.yzw);
        r9.yzw = r9.yzw * float3(6,6,6) + float3(-3,-3,-3);
        r9.yzw = saturate(float3(-1,-1,-1) + abs(r9.yzw));
        r9.yzw = float3(-1,-1,-1) + r9.yzw;
        r9.xyz = r9.xxx * r9.yzw + float3(1,1,1);
        model15_modelN16.w = 1 + model15_modelN16.w;
        r12.xyz = r9.xyz * model15_modelN16.www;
        r13.xyz = r9.xyz * model15_modelN16.www + float3(-1,-1,-1);
        r13.xyz = r13.xyz * float3(0.600000024,0.600000024,0.600000024) + float3(1,1,1);
        r9.xyz = -r9.xyz * model15_modelN16.www + r13.xyz;
        r9.xyz = normal_perObjectData.xxx * r9.xyz + r12.xyz;
        r12.xyz = r9.xyz + -albedo_alpha.xyz;
        r12.xyz = r12.xyz * float3(0.850000024,0.850000024,0.850000024) + albedo_alpha.xyz;
        r11.xyz = r11.zzz * r12.xyz + -r9.xyz;
        r9.xyz = r8.www * r11.xyz + r9.xyz;
        r9.xyz = float3(-1,-1,-1) + r9.xyz;
        r9.xyz = r11.www * r9.xyz + float3(1,1,1);
        r11.xyz = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
        r12.xyz = cb1[262].xyz * float3(0.5,0.5,0.5) + -r11.xyz;
        r11.xyz = r5.www * r12.xyz + r11.xyz;
        r11.xyz = cb1[260].xxx * r11.xyz;
        r11.xyz = r11.xyz * albedo_alpha.xyz;
        r12.xyz = r11.xyz * r7.xyz;
        r13.xyz = cb1[261].xyz * albedo_alpha.xyz;
        normal_perObjectData.x = customData.x * 0.300000012 + 0.699999988;
        r14.xyz = r13.xyz * normal_perObjectData.xxx;
        r15.xyz = cb1[262].xyz * albedo_alpha.xyz;
        r12.xyz = r13.xyz * normal_perObjectData.xxx + r12.xyz;
        r13.xyz = albedo_alpha.xyz * cb1[262].xyz + -r14.xyz;
        r13.xyz = r13.xyz * float3(0.400000006,0.400000006,0.400000006) + r14.xyz;
        r16.xyz = r14.xyz * r9.xyz;
        r13.xyz = r13.xyz * r9.xyz + -r16.xyz;
        r13.xyz = r10.xxx * r13.xyz + r16.xyz;
        r11.xyz = r11.xyz * r7.xyz + r13.xyz;
        r12.xyz = r12.xyz * r9.xyz;
        r13.xyz = r15.xyz * r7.www;
        r9.xyz = r13.xyz * r9.xyz + -r12.xyz;
        r9.xyz = r10.xxx * r9.xyz + r12.xyz;
        normal_perObjectData.x = tex2Dlod(_IN8, float4(screenUV_ndcUV.xy, 0, 0)).x;
        normal_perObjectData.x = -1 + normal_perObjectData.x;
        normal_perObjectData.x = model15_modelN16.z * normal_perObjectData.x + 1;
        r9.xyz = r9.xyz + -r11.xyz;
        r9.xyz = r5.www * r9.xyz + r11.xyz;
        r11.xyz = float3(1,1,1) + -r8.xyz;
        r8.xyz = normal_perObjectData.xxx * r11.xyz + r8.xyz;
        r8.xyz = r9.xyz * r8.xyz;
    } else {
        normal_perObjectData.x = saturate(normal_perObjectData.w + normal_perObjectData.w);
        customData.x = normal_perObjectData.x * -2 + 3;
        normal_perObjectData.x = normal_perObjectData.x * normal_perObjectData.x;
        normal_perObjectData.x = customData.x * normal_perObjectData.x;
        customData.x = -0.5 + normal_perObjectData.w;
        customData.x = saturate(customData.x + customData.x);
        model15_modelN16.z = customData.x * -2 + 3;
        customData.x = customData.x * customData.x;
        customData.x = model15_modelN16.z * customData.x;
        r9.xyz = cb1[262].xyz + -cb1[261].xyz;
        model15_modelN16.z = dot(abs(r9.xyz), float3(0.300000012,0.589999974,0.109999999));
        model15_modelN16.z = 10 * model15_modelN16.z;
        model15_modelN16.z = min(1, model15_modelN16.z);
        model15_modelN16.w = model15_modelN16.z * -2 + 3;
        model15_modelN16.z = model15_modelN16.z * model15_modelN16.z;
        model15_modelN16.z = model15_modelN16.w * model15_modelN16.z;
        model15_modelN16.w = model15_modelN16.z * customData.x;
        r5.w = cb1[265].y + -cb1[265].x;
        r6.w = shadingModelID * cb1[253].y + -cb1[265].x;
        r5.w = 1 / r5.w;
        r6.w = saturate(r6.w * r5.w);
        r7.w = r6.w * -2 + 3;
        r6.w = r6.w * r6.w;
        r6.w = r7.w * r6.w;
        r6.w = r6.w * model15_modelN16.w;
        shadingModelID = shadingModelID * cb1[253].y + -r6.w;
        shadingModelID = cb1[265].z * shadingModelID + r6.w;
        r6.w = -cb1[265].x + shadingModelID;
        r5.w = saturate(r6.w * r5.w);
        r6.w = r5.w * -2 + 3;
        r5.w = r5.w * r5.w;
        r5.w = r6.w * r5.w;
        model15_modelN16.w = r5.w * model15_modelN16.w;
        customData.x = customData.x * model15_modelN16.z + -model15_modelN16.w;
        customData.x = cb1[265].z * customData.x + model15_modelN16.w;
        model15_modelN16.z = shadingModelID * r5.y;
        model15_modelN16.z = 10 * model15_modelN16.z;
        shadingModelID = -1 + shadingModelID;
        shadingModelID = cb1[260].y * shadingModelID + 1;
        model15_modelN16.w = cb1_158 * customData.x + -shadingModelID;
        shadingModelID = r5.x * model15_modelN16.w + shadingModelID;
        model15_modelN16.w = cb1_158 * customData.x + -customData.x;
        r10.x = r5.x * model15_modelN16.w + customData.x;
        r5.xyw = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
        r9.xyz = cb1[262].xyz * float3(0.5,0.5,0.5) + -r5.xyw;
        r5.xyw = shadingModelID * r9.xyz + r5.xyw;
        r5.xyw = cb1[260].xxx * r5.xyw;
        r5.xyw = r5.xyw * albedo_alpha.xyz;
        r9.xyz = r5.xyw * r7.xyz;
        r11.xyz = cb1[261].xyz * albedo_alpha.xyz;
        normal_perObjectData.x = normal_perObjectData.x * 0.300000012 + 0.699999988;
        r14.xyz = r11.xyz * normal_perObjectData.xxx;
        r11.xyz = r11.xyz * normal_perObjectData.xxx + r9.xyz;
        r9.xyz = r9.xyz * model15_modelN16.zzz + r11.xyz;
        r11.xyz = albedo_alpha.xyz * cb1[262].xyz + -r14.xyz;
        r11.xyz = r11.xyz * r10.xxx;
        r11.xyz = r11.xyz * float3(0.400000006,0.400000006,0.400000006) + r14.xyz;
        r5.xyw = r5.xyw * r7.xyz + r11.xyz;
        r11.xyz = albedo_alpha.xyz * cb1[262].xyz + -r9.xyz;
        r9.xyz = r10.xxx * r11.xyz + r9.xyz;
        r9.xyz = r9.xyz + -r5.xyw;
        r8.xyz = shadingModelID * r9.xyz + r5.xyw;
    }
    normal_perObjectData.x = -0.400000006 + normal_perObjectData.w;
    normal_perObjectData.x = saturate(10.000001 * normal_perObjectData.x);
    normal_perObjectData.w = normal_perObjectData.x * -2 + 3;
    normal_perObjectData.x = normal_perObjectData.x * normal_perObjectData.x;
    r10.y = normal_perObjectData.w * normal_perObjectData.x;
    r5.xyw = r8.xyz * float3(0.5,0.5,0.5) + cb1[261].xyz;
    r5.xyw = r5.xyw * albedo_alpha.xyz;
    r9.xyz = cb1[261].xyz * albedo_alpha.xyz;
    r5.xyw = cb1[255].xxx ? r5.xyw : r9.xyz;
    r9.xyz = normal_perObjectData.zzz ? r5.xyw : r14.xyz;
    r5.xyw = normal_perObjectData.zzz ? r5.xyw : r8.xyz;
    normal_perObjectData.xw = normal_perObjectData.zz ? float2(0,0) : r10.xy;
    r8.xyz = cb1[264].xyz + cb1[264].xyz;
    r8.xyz = normal_perObjectData.xxx * r8.xyz + -cb1[264].xyz;
    r10.xyz = float3(0,0,0);
    shadingModelID = 1;
    customData.x = 0;
    while (true) {
        model15_modelN16.z = ((uint)customData.x >= asuint(cb2[128].x)) ? 1.0 : 0.0;
        if (model15_modelN16.z != 0) break;
        bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  model15_modelN16.z = (((uint)customData.x << 3) & bitmask.z) | ((uint)7 & ~bitmask.z);
        bitmask.w = ((~(-1 << 3)) << 5) & 0xffffffff;  model15_modelN16.w = (((uint)cb2[model15_modelN16.z+0].w << 5) & bitmask.w) | ((uint)0 & ~bitmask.w);
        model15_modelN16.w = (int)model15_modelN16.y & (int)model15_modelN16.w;
        if (model15_modelN16.w == 0) {
        model15_modelN16.w = (int)customData.x + 1;
        customData.x = model15_modelN16.w;
        continue;
        }
        model15_modelN16.w = (uint)customData.x << 3;
        r11.xyz = cb2[model15_modelN16.w+0].xyz + -r6.xyz;
        r6.w = cb2[model15_modelN16.w+0].w * cb2[model15_modelN16.w+0].w;
        r7.w = dot(r11.xyz, r11.xyz);
        r6.w = r7.w * r6.w;
        r8.w = (1 >= r6.w) ? 1.0 : 0.0;
        if (r8.w != 0) {
        bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.x = (((uint)customData.x << 3) & bitmask.x) | ((uint)1 & ~bitmask.x);
        bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.y = (((uint)customData.x << 3) & bitmask.y) | ((uint)2 & ~bitmask.y);
        bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.z = (((uint)customData.x << 3) & bitmask.z) | ((uint)3 & ~bitmask.z);
        bitmask.w = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.w = (((uint)customData.x << 3) & bitmask.w) | ((uint)4 & ~bitmask.w);
        bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  r13.x = (((uint)customData.x << 3) & bitmask.x) | ((uint)5 & ~bitmask.x);
        bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  r13.y = (((uint)customData.x << 3) & bitmask.y) | ((uint)6 & ~bitmask.y);
        r6.w = saturate(r6.w * 2.5 + -1.5);
        r8.w = r6.w * r6.w;
        r6.w = -r6.w * 2 + 3;
        r6.w = -r8.w * r6.w + 1;
        r7.w = rsqrt(r7.w);
        r14.xyz = r11.xyz * r7.www;
        r7.w = dot(msr_shadingModelID.xyz, r14.xyz);
        r7.w = 1 + r7.w;
        r13.zw = cb2[r13.x+0].ww * float2(0.939999998,0.0600000024);
        r7.w = r7.w * 0.5 + -r13.z;
        r8.w = 1 / r13.w;
        r7.w = saturate(r8.w * r7.w);
        r8.w = r7.w * -2 + 3;
        r7.w = r7.w * r7.w;
        r7.w = r8.w * r7.w;
        r7.w = min(1, r7.w);
        r15.xyz = cb2[r13.y+0].xyz * r9.xyz;
        r13.xzw = albedo_alpha.xyz * cb2[r13.x+0].xyz + -r15.xyz;
        r13.xzw = r7.www * r13.xzw + r15.xyz;
        r13.xzw = cb2[model15_modelN16.z+0].xxx * r13.xzw;
        r11.xyz = cb2[model15_modelN16.w+0].www * r11.xyz;
        model15_modelN16.w = dot(r11.xyz, r11.xyz);
        model15_modelN16.w = model15_modelN16.w * cb2[r12.w+0].x + cb2[r12.w+0].y;
        model15_modelN16.w = 9.99999975e-005 + model15_modelN16.w;
        model15_modelN16.w = 1 / model15_modelN16.w;
        model15_modelN16.w = -1 + model15_modelN16.w;
        model15_modelN16.w = cb2[r12.w+0].z * model15_modelN16.w;
        model15_modelN16.w = model15_modelN16.w * model15_modelN16.w;
        model15_modelN16.w = min(1, model15_modelN16.w);
        if (4 == 0) r7.w = 0; else if (4+16 < 32) {       r7.w = (uint)cb2[r12.x+0].w << (32-(4 + 16)); r7.w = (uint)r7.w >> (32-4);      } else r7.w = (uint)cb2[r12.x+0].w >> 16;
        r7.w = ((int)r7.w == 2) ? 1.0 : 0.0;
        r8.w = dot(r14.xyz, cb2[r12.x+0].xyz);
        r8.w = -cb2[r12.y+0].x + r8.w;
        r8.w = saturate(cb2[r12.y+0].y * r8.w);
        r8.w = r8.w * r8.w;
        r8.w = r8.w * r8.w;
        r8.w = r8.w * model15_modelN16.w;
        model15_modelN16.w = r7.w ? r8.w : model15_modelN16.w;
        r7.w = dot(r8.xyz, r14.xyz);
        r7.w = saturate(r7.w * 0.5 + 0.5);
        r7.w = normal_perObjectData.w * r7.w + -normal_perObjectData.x;
        r7.w = cb2[r12.w+0].w * r7.w + normal_perObjectData.x;
        r11.xyz = cb2[r12.z+0].www * r9.xyz;
        r12.xyw = -r9.xyz * cb2[r12.z+0].www + albedo_alpha.xyz;
        r11.xyz = r7.www * r12.xyw + r11.xyz;
        r11.xyz = cb2[r12.z+0].xyz * r11.xyz;
        r7.w = cb2[r12.z+0].x + cb2[r12.z+0].y;
        r7.w = cb2[r12.z+0].z + r7.w;
        r7.w = cb2[model15_modelN16.z+0].x + r7.w;
        r7.w = saturate(10 * r7.w);
        model15_modelN16.z = cb2[model15_modelN16.z+0].y * r7.w;
        r12.xyz = r13.xzw * model15_modelN16.www;
        r11.xyz = r11.xyz * model15_modelN16.www + r12.xyz;
        r6.w = r6.w + -model15_modelN16.w;
        model15_modelN16.w = cb2[r13.y+0].w * r6.w + model15_modelN16.w;
        r10.xyz = r11.xyz * shadingModelID + r10.xyz;
        model15_modelN16.z = -model15_modelN16.w * model15_modelN16.z + 1;
        shadingModelID = model15_modelN16.z * shadingModelID;
        }
        customData.x = (int)customData.x + 1;
    }
    model15_modelN16.yzw = shadingModelID * r5.xyw + r10.xyz;
    normal_perObjectData.x = ((int)model15_modelN16.x != 13) ? 1.0 : 0.0;
    if (normal_perObjectData.x != 0) {
        normal_perObjectData.x = ((int)model15_modelN16.x == 1) ? 1.0 : 0.0;
        normal_perObjectData.x = normal_perObjectData.x ? customData.z : customData.y;
        customData.xyz = cb1[67].xyz + -r6.xyz;
        normal_perObjectData.w = dot(customData.xyz, customData.xyz);
        normal_perObjectData.w = rsqrt(normal_perObjectData.w);
        customData.xyz = customData.xyz * normal_perObjectData.www;
        normal_perObjectData.w = saturate(-0.100000001 + normal_perObjectData.x);
        normal_perObjectData.x = saturate(10 * normal_perObjectData.x);
        shadingModelID = normal_perObjectData.w * 2000 + 50;
        model15_modelN16.x = normal_perObjectData.w + normal_perObjectData.w;
        normal_perObjectData.x = cb0[0].x * normal_perObjectData.x;
        normal_perObjectData.x = normal_perObjectData.x * 0.800000012 + model15_modelN16.x;
        r5.xyw = cb1[21].xyz * msr_shadingModelID.yyy;
        r5.xyw = msr_shadingModelID.xxx * cb1[20].xyz + r5.xyw;
        r5.xyw = msr_shadingModelID.zzz * cb1[22].xyz + r5.xyw;
        model15_modelN16.x = asint(cb0[0].w);
        model15_modelN16.x = (0.5 < model15_modelN16.x) ? 1.0 : 0.0;
        customData.xyz = model15_modelN16.xxx ? float3(0,0,0) : customData.xyz;
        r6.xy = model15_modelN16.xx ? cb0[0].yz : cb1[264].xy;
        r6.z = model15_modelN16.x ? 0.5 : cb1[264].z;
        msr_shadingModelID.xyz = model15_modelN16.xxx ? r5.xyw : msr_shadingModelID.xyz;
        model15_modelN16.x = dot(r6.xyz, msr_shadingModelID.xyz);
        r8.xy = float2(0.200000003,1) + model15_modelN16.xx;
        model15_modelN16.x = 5 * r8.x;
        model15_modelN16.x = saturate(model15_modelN16.x);
        r5.w = model15_modelN16.x * -2 + 3;
        model15_modelN16.x = model15_modelN16.x * model15_modelN16.x;
        model15_modelN16.x = r5.w * model15_modelN16.x;
        r8.xzw = r6.xyz + customData.xyz;
        r5.w = dot(r8.xzw, r8.xzw);
        r5.w = rsqrt(r5.w);
        r8.xzw = r8.xzw * r5.www;
        r5.w = saturate(dot(msr_shadingModelID.xyz, r8.xzw));
        r5.w = r5.w * r5.w;
        r5.w = r5.w * -0.800000012 + 1;
        r5.w = r5.w * r5.w;
        r5.w = 3.14159274 * r5.w;
        r5.w = 0.200000003 / r5.w;
        r5.w = r5.w * cb1_158;
        r6.x = dot(r6.xyz, customData.xyz);
        r6.xy = float2(-0.5,1) + -r6.xx;
        r6.x = saturate(r6.x + r6.x);
        r6.z = r6.x * -2 + 3;
        r6.x = r6.x * r6.x;
        r6.x = r6.z * r6.x + 1;
        msr_shadingModelID.x = saturate(dot(customData.xyz, msr_shadingModelID.xyz));
        msr_shadingModelID.x = 0.800000012 + -msr_shadingModelID.x;
        msr_shadingModelID.x = max(0, msr_shadingModelID.x);
        msr_shadingModelID.y = max(0, cb1[133].x);
        msr_shadingModelID.y = min(1.74532926, msr_shadingModelID.y);
        msr_shadingModelID.xy = float2(1.5,0.572957814) * msr_shadingModelID.xy;
        msr_shadingModelID.z = max(0, depth);
        customData.xy = min(float2(3000,50), msr_shadingModelID.zz);
        customData.xy = float2(3000,50) + -customData.xy;
        customData.xy = float2(0.00033333333,0.0199999996) * customData.xy;
        msr_shadingModelID.z = customData.x * customData.x;
        msr_shadingModelID.z = msr_shadingModelID.z * msr_shadingModelID.z;
        msr_shadingModelID.z = msr_shadingModelID.z * msr_shadingModelID.z + customData.y;
        msr_shadingModelID.z = -1 + msr_shadingModelID.z;
        msr_shadingModelID.y = msr_shadingModelID.y * msr_shadingModelID.z + 1;
        msr_shadingModelID.z = 1 + -msr_shadingModelID.y;
        msr_shadingModelID.y = normal_perObjectData.w * msr_shadingModelID.z + msr_shadingModelID.y;
        msr_shadingModelID.z = r8.y * 0.25 + 0.5;
        msr_shadingModelID.x = msr_shadingModelID.z * msr_shadingModelID.x;
        msr_shadingModelID.x = msr_shadingModelID.x * msr_shadingModelID.y;
        msr_shadingModelID.x = msr_shadingModelID.x * r6.x;
        msr_shadingModelID.x = 0.00999999978 * msr_shadingModelID.x;
        customData.xy = float2(9.99999975e-005,9.99999975e-005) + r5.xy;
        msr_shadingModelID.z = dot(customData.xy, customData.xy);
        msr_shadingModelID.z = rsqrt(msr_shadingModelID.z);
        customData.xy = customData.xy * msr_shadingModelID.zz;
        customData.xy = customData.xy * normal_perObjectData.xx;
        customData.z = customData.y * msr_shadingModelID.x;
        msr_shadingModelID.y = -0.5;
        msr_shadingModelID.xy = customData.xz * msr_shadingModelID.xy;
        normal_perObjectData.x = 0.400000006 * r6.y;
        msr_shadingModelID.z = model15_modelN16.x * 0.800000012 + 0.200000003;
        customData.x = r5.w * model15_modelN16.x;
        customData.x = 1.5 * customData.x;
        normal_perObjectData.x = normal_perObjectData.x * msr_shadingModelID.z + customData.x;
        msr_shadingModelID.z = cb1_158 * 0.5 + 0.5;
        normal_perObjectData.x = msr_shadingModelID.z * normal_perObjectData.x;
        customData.xy = screenUV_ndcUV.xy * _ScaledScreenParams.xy + -cb1[134].xy;
        msr_shadingModelID.xy = customData.xy * cb1[135].zw + msr_shadingModelID.xy;
        msr_shadingModelID.xy = msr_shadingModelID.xy * cb1[135].xy + cb1[134].xy;
        msr_shadingModelID.xy = ((_ScaledScreenParams.zw - 1) * msr_shadingModelID.xy); // unity需要多一步 因为是1开头的
        msr_shadingModelID.x = tex2D(_IN6, msr_shadingModelID.xy).x;
        msr_shadingModelID.y = msr_shadingModelID.x * cb1[65].x + cb1[65].y;
        msr_shadingModelID.x = msr_shadingModelID.x * cb1[65].z + -cb1[65].w;
        msr_shadingModelID.x = 1 / msr_shadingModelID.x;
        msr_shadingModelID.x = msr_shadingModelID.y + msr_shadingModelID.x;
        msr_shadingModelID.x = msr_shadingModelID.x + -depth;
        msr_shadingModelID.x = max(9.99999975e-005, msr_shadingModelID.x);
        normal_perObjectData.w = -normal_perObjectData.w * 1000 + msr_shadingModelID.x;
        msr_shadingModelID.x = 1 / shadingModelID;
        normal_perObjectData.w = saturate(msr_shadingModelID.x * normal_perObjectData.w);
        msr_shadingModelID.x = normal_perObjectData.w * -2 + 3;
        normal_perObjectData.w = normal_perObjectData.w * normal_perObjectData.w;
        normal_perObjectData.w = msr_shadingModelID.x * normal_perObjectData.w;
        normal_perObjectData.w = min(1, normal_perObjectData.w);
        msr_shadingModelID.x = dot(cb1[263].xyz, float3(0.300000012,0.589999974,0.109999999));
        msr_shadingModelID.yzw = cb1[263].xyz + -msr_shadingModelID.xxx;
        msr_shadingModelID.xyz = msr_shadingModelID.yzw * float3(0.75,0.75,0.75) + msr_shadingModelID.xxx;
        customData.xyz = cb1[263].xyz + -msr_shadingModelID.xyz;
        msr_shadingModelID.xyz = cb1_158 * customData.xyz + msr_shadingModelID.xyz;
        msr_shadingModelID.xyz = msr_shadingModelID.xyz * normal_perObjectData.xxx;
        msr_shadingModelID.xyz = float3(0.100000001,0.100000001,0.100000001) * msr_shadingModelID.xyz;
        customData.xyz = float3(1,1,1) + albedo_alpha.xyz;
        customData.xyz = customData.xyz * msr_shadingModelID.xyz;
        r5.xyw = albedo_alpha.xyz * float3(1.20000005,1.20000005,1.20000005) + float3(-1,-1,-1);
        r5.xyw = saturate(-r5.xyw);
        r6.xyz = r5.xyw * float3(-2,-2,-2) + float3(3,3,3);
        r5.xyw = r5.xyw * r5.xyw;
        r5.xyw = r6.xyz * r5.xyw;
        r5.xyw = r5.xyw * float3(14,14,14) + float3(1,1,1);
        msr_shadingModelID.xyz = r5.xyw * msr_shadingModelID.xyz;
        msr_shadingModelID.xyz = msr_shadingModelID.xyz * albedo_alpha.xyz + -customData.xyz;
        msr_shadingModelID.xyz = cb1[260].zzz * msr_shadingModelID.xyz + customData.xyz;
        msr_shadingModelID.xyz = msr_shadingModelID.xyz * normal_perObjectData.www;
        normal_perObjectData.x = -10000 + depth;
        normal_perObjectData.x = max(0, normal_perObjectData.x);
        normal_perObjectData.x = min(5000, normal_perObjectData.x);
        normal_perObjectData.x = 5000 + -normal_perObjectData.x;
        normal_perObjectData.x = 0.000199999995 * normal_perObjectData.x;
        msr_shadingModelID.xyz = normal_perObjectData.xxx * msr_shadingModelID.xyz;
        msr_shadingModelID.xyz = cb0[1].xyz * msr_shadingModelID.xyz;
    } else {
        msr_shadingModelID.xyz = float3(0,0,0);
    }
    normal_perObjectData.x = (0 != r5.z) ? 1.0 : 0.0;
    albedo_alpha.xyz = model15_modelN16.yzw * r7.xyz;
    albedo_alpha.xyz = cb1[263].xyz * albedo_alpha.xyz;
    albedo_alpha.xyz = albedo_alpha.xyz * float3(0.5,0.5,0.5) + -model15_modelN16.yzw;
    albedo_alpha.xyz = normal_perObjectData.www * albedo_alpha.xyz + model15_modelN16.yzw;
    msr_shadingModelID.xyz = model15_modelN16.yzw + msr_shadingModelID.xyz;
    msr_shadingModelID.xyz = normal_perObjectData.xxx ? albedo_alpha.xyz : msr_shadingModelID.xyz;
    normal_perObjectData.xzw = normal_perObjectData.zzz ? model15_modelN16.yzw : msr_shadingModelID.xyz;
    normal_perObjectData.xyz = normal_perObjectData.xzw / normal_perObjectData.yyy;
    normal_perObjectData.xyz = min(float3(0,0,0), -normal_perObjectData.xyz);
    color.xyz = -normal_perObjectData.xyz;
    return color;
}
            ENDCG
        }
    }
}