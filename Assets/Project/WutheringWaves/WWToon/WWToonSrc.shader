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
    // 基于输入uv定义v0，zw分量是NDC x（clip.x / clip.w）并复制到 zw
    float4 v0 = fragmentInput.uv; 

    float4 color = 0;
    
    float4 r0,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14,r15,r16;
    uint4 bitmask, uiDest;
    float4 fDest;

    r0.xyzw = tex2Dlod(_IN1, float4(v0.xy, 0, 0)).wxyz;
    r1.xyzw = tex2Dlod(_IN2, float4(v0.xy, 0, 0)).xyzw;
    r2.xyz = tex2Dlod(_IN3, float4(v0.xy, 0, 0)).xyz;
    r3.xyz = tex2Dlod(_IN4, float4(v0.xy, 0, 0)).yxz;
    r2.w = tex2Dlod(_IN0, float4(v0.xy, 0, 0)).x;
    r3.w = r2.w * cb1[65].x + cb1[65].y;
    r2.w = r2.w * cb1[65].z + -cb1[65].w;
    r2.w = 1 / r2.w;
    r2.w = r3.w + r2.w;
    r4.xy = cb1[138].xy * v0.xy;
    r4.xy = (uint2)r4.xy;
    r3.w = (uint)cb1[158].x;
    r4.x = (int)r4.y + (int)r4.x;
    r3.w = (int)r3.w + (int)r4.x;
    r3.w = (int)r3.w & 1;
    r1.w = 255 * r1.w;
    r1.w = round(r1.w);
    r1.w = (uint)r1.w;
    r4.xy = (int2)r1.ww & int2(15,-16);
    r1.w = ((int)r4.x != 12) ? 1.0 : 0.0;
    r5.xyz = ((int3)r4.xxx == int3(13,14,15)) ? 1.0 : 0.0;
    r4.z = (int)r5.z | (int)r5.y;
    r4.z = (int)r4.z | (int)r5.x;
    r1.w = r1.w ? r4.z : -1;
    if (r1.w != 0) {
        r4.x = r5.x ? 13 : 12;
        r5.xz = r5.yz ? float2(1,1) : 0;
        r4.zw = r0.yz * float2(2,2) + float2(-1,-1);
        r1.w = dot(float2(1,1), abs(r4.zw));
        r6.z = 1 + -r1.w;
        r1.w = max(0, -r6.z);
        r7.xy = (r4.zw >= float2(0,0)) ? 1.0 : 0.0;
        r7.xy = r7.xy ? float2(0.5,0.5) : float2(-0.5,-0.5);
        r7.xy = r7.xy * r1.ww;
        r6.xy = r7.xy * float2(-2,-2) + r4.zw;
        r1.w = dot(r6.xyz, r6.xyz);
        r1.w = rsqrt(r1.w);
        r6.xyz = r6.xyz * r1.www;
        r7.xyz = r1.xyz * r1.xyz;
        r5.y = r3.z;
    } else {
        r1.w = ((int)r4.x == 10) ? 1.0 : 0.0;
        r1.xyz = saturate(r1.xyz);
        r1.xyz = float3(16777215,65535,255) * r1.xyz;
        r1.xyz = round(r1.xyz);
        r1.xyz = (uint3)r1.xyz;
        bitmask.y = ((~(-1 << 8)) << 0) & 0xffffffff;  r1.y = (((uint)r1.z << 0) & bitmask.y) | ((uint)r1.y & ~bitmask.y);
        bitmask.x = ((~(-1 << 16)) << 0) & 0xffffffff;  r1.x = (((uint)r1.y << 0) & bitmask.x) | ((uint)r1.x & ~bitmask.x);
        r1.x = (uint)r1.x;
        r1.x = 5.96046519e-008 * r1.x;
        r1.y = r1.x * cb1[65].x + cb1[65].y;
        r1.x = r1.x * cb1[65].z + -cb1[65].w;
        r1.x = 1 / r1.x;
        r1.x = r1.y + r1.x;
        r2.w = r1.w ? r1.x : r2.w;
        r6.xyz = r0.yzw * float3(2,2,2) + float3(-1,-1,-1);
        r7.xyz = float3(0,0,0);
        r5.xyz = float3(0,0,0);
        r0.xw = float2(0,0);
        r3.xy = float2(0,0);
    }
    r0.y = dot(r6.xyz, r6.xyz);
    r0.y = rsqrt(r0.y);
    r1.xyz = r6.xyz * r0.yyy;
    r0.yz = ((int2)r4.xx == int2(5,13)) ? 1.0 : 0.0;
    r1.w = (0 < cb1[162].y) ? 1.0 : 0.0;
    r4.z = (0 < cb1[220].z) ? 1.0 : 0.0;
    r1.w = r1.w ? r4.z : 0;
    r4.z = (0 != cb1[162].y) ? 1.0 : 0.0;
    r6.xyz = r4.zzz ? float3(1,1,1) : r2.xyz;
    r3.w = r3.w ? 1 : 0;
    r6.xyz = r1.www ? r3.www : r6.xyz;
    r2.xyz = r0.yyy ? r6.xyz : r2.xyz;
    r0.y = tex2Dlod(_IN9, float4(0, 0, 0, 0)).x;
    r4.zw = v0.zw * r2.ww;
    r6.xyz = cb1[49].xyz * r4.www;
    r6.xyz = r4.zzz * cb1[48].xyz + r6.xyz;
    r6.xyz = r2.www * cb1[50].xyz + r6.xyz;
    r6.xyz = cb1[51].xyz + r6.xyz;
    r4.zw = tex2Dlod(_IN5, float4(v0.xy, 0, 0)).xz;
    r4.zw = r4.zw * r4.zw;
    r1.w = r4.z * r4.w;
    r3.w = cb1[253].y * r1.w;
    if (cb1[255].x != 0) {
        r8.xyz = float3(0,0,0);
        r4.zw = float2(0,0);
        r5.w = 0;
        r6.w = 0;
        while (true) {
        r7.w = ((int)r4.z >= 3) ? 1.0 : 0.0;
        if (r7.w != 0) break;
        r4.w = 0.000833333295 + r4.w;
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
            r11.x = r11.x * r4.w + v0.x;
            r11.y = r10.x * r4.w + v0.y;
            r10.xyz = tex2D(_IN7, r11.xy).xyz;
            r9.xyz = r10.xyz * r4.www + r9.xyz;
            r8.w = r8.w + r4.w;
            r9.w = (int)r9.w + 1;
        }
        r8.xyz = r9.xyz;
        r6.w = r8.w;
        r5.w = 0.620000005 + r7.w;
        r4.z = (int)r4.z + 1;
        }
        r8.xyz = r8.xyz / r6.www;
        r9.xyz = (float3(0.644999981,0.312000006,0.978999972) < r0.xxx) ? 1.0 : 0.0;
        r10.xyz = (r0.xxx < float3(0.685000002,0.351999998,1.02100003)) ? 1.0 : 0.0;
        r9.xyz = r9.xyz ? r10.xyz : 0;
        r0.x = r9.z ? 1.000000 : 0;
        r0.x = r9.y ? 0 : r0.x;
        r0.x = r9.x ? 1 : r0.x;
        r4.z = (int)r9.y | (int)r9.z;
        r4.z = (int)r4.z & 0x3f800000;
        r4.z = r9.x ? 0 : r4.z;
        r3.x = 255 * r3.x;
        r3.x = round(r3.x);
        r3.x = (uint)r3.x;
        r9.xyzw = (int4)r3.xxxx & int4(15,240,240,15);
        r9.xyzw = (uint4)r9.xyzw;
        r3.x = saturate(r0.w + r0.w);
        r4.w = r3.x * -2 + 3;
        r3.x = r3.x * r3.x;
        r3.x = r4.w * r3.x;
        r4.w = -0.5 + r0.w;
        r4.w = saturate(r4.w + r4.w);
        r5.w = r4.w * -2 + 3;
        r4.w = r4.w * r4.w;
        r4.w = r5.w * r4.w;
        r10.xyz = cb1[262].xyz + -cb1[261].xyz;
        r5.w = dot(abs(r10.xyz), float3(0.300000012,0.589999974,0.109999999));
        r5.w = 10 * r5.w;
        r5.w = min(1, r5.w);
        r6.w = r5.w * -2 + 3;
        r5.w = r5.w * r5.w;
        r5.w = r6.w * r5.w;
        r6.w = r5.w * r4.w;
        r7.w = cb1[265].y + -cb1[265].x;
        r8.w = r1.w * cb1[253].y + -cb1[265].x;
        r7.w = 1 / r7.w;
        r8.w = saturate(r8.w * r7.w);
        r10.x = r8.w * -2 + 3;
        r8.w = r8.w * r8.w;
        r8.w = r10.x * r8.w;
        r8.w = r8.w * r6.w;
        r10.x = r1.w * cb1[253].y + -r8.w;
        r8.w = cb1[265].z * r10.x + r8.w;
        r10.x = -cb1[265].x + r8.w;
        r7.w = saturate(r10.x * r7.w);
        r10.x = r7.w * -2 + 3;
        r7.w = r7.w * r7.w;
        r7.w = r10.x * r7.w;
        r6.w = r7.w * r6.w;
        r4.w = r4.w * r5.w + -r6.w;
        r4.w = cb1[265].z * r4.w + r6.w;
        r5.w = -1 + r8.w;
        r5.w = cb1[260].y * r5.w + 1;
        r6.w = r3.w * r4.w + -r5.w;
        r5.w = r5.x * r6.w + r5.w;
        r6.w = r3.w * r4.w + -r4.w;
        r10.x = r5.x * r6.w + r4.w;
        r4.w = (r8.y >= r8.z) ? 1.0 : 0.0;
        r4.w = r4.w ? 1.000000 : 0;
        r11.xy = r8.zy;
        r11.zw = float2(-1,0.666666687);
        r12.xy = -r11.xy + r8.yz;
        r12.zw = float2(1,-1);
        r11.xyzw = r4.wwww * r12.xyzw + r11.xyzw;
        r4.w = (r8.x >= r11.x) ? 1.0 : 0.0;
        r4.w = r4.w ? 1.000000 : 0;
        r12.xyz = r11.xyw;
        r12.w = r8.x;
        r11.xyw = r12.wyx;
        r11.xyzw = r11.xyzw + -r12.xyzw;
        r11.xyzw = r4.wwww * r11.xyzw + r12.xyzw;
        r4.w = min(r11.w, r11.y);
        r4.w = r11.x + -r4.w;
        r6.w = r11.w + -r11.y;
        r7.w = r4.w * 6 + 0.00100000005;
        r6.w = r6.w / r7.w;
        r6.w = r11.z + r6.w;
        r7.w = 0.00100000005 + r11.x;
        r4.w = r4.w / r7.w;
        r7.w = r11.x * 0.300000012 + 1;
        r11.xyzw = r9.xyzw * float4(0.0400000028,0.0027450982,0.00392156886,0.0666666701) + float4(0.400000006,0.400000006,1,0.5);
        r8.w = (r9.z >= 2.54999971) ? 1.0 : 0.0;
        r8.w = r8.w ? 1.000000 : 0;
        r9.x = r11.y + -r11.x;
        r9.x = r8.w * r9.x + r11.x;
        r4.w = r9.x * r4.w;
        r4.w = min(0.349999994, r4.w);
        r9.x = max(0, r4.w);
        r9.yzw = float3(1,0.666666687,0.333333343) + abs(r6.www);
        r9.yzw = frac(r9.yzw);
        r9.yzw = r9.yzw * float3(6,6,6) + float3(-3,-3,-3);
        r9.yzw = saturate(float3(-1,-1,-1) + abs(r9.yzw));
        r9.yzw = float3(-1,-1,-1) + r9.yzw;
        r9.xyz = r9.xxx * r9.yzw + float3(1,1,1);
        r4.w = 1 + r4.w;
        r12.xyz = r9.xyz * r4.www;
        r13.xyz = r9.xyz * r4.www + float3(-1,-1,-1);
        r13.xyz = r13.xyz * float3(0.600000024,0.600000024,0.600000024) + float3(1,1,1);
        r9.xyz = -r9.xyz * r4.www + r13.xyz;
        r9.xyz = r0.xxx * r9.xyz + r12.xyz;
        r12.xyz = r9.xyz + -r2.xyz;
        r12.xyz = r12.xyz * float3(0.850000024,0.850000024,0.850000024) + r2.xyz;
        r11.xyz = r11.zzz * r12.xyz + -r9.xyz;
        r9.xyz = r8.www * r11.xyz + r9.xyz;
        r9.xyz = float3(-1,-1,-1) + r9.xyz;
        r9.xyz = r11.www * r9.xyz + float3(1,1,1);
        r11.xyz = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
        r12.xyz = cb1[262].xyz * float3(0.5,0.5,0.5) + -r11.xyz;
        r11.xyz = r5.www * r12.xyz + r11.xyz;
        r11.xyz = cb1[260].xxx * r11.xyz;
        r11.xyz = r11.xyz * r2.xyz;
        r12.xyz = r11.xyz * r7.xyz;
        r13.xyz = cb1[261].xyz * r2.xyz;
        r0.x = r3.x * 0.300000012 + 0.699999988;
        r14.xyz = r13.xyz * r0.xxx;
        r15.xyz = cb1[262].xyz * r2.xyz;
        r12.xyz = r13.xyz * r0.xxx + r12.xyz;
        r13.xyz = r2.xyz * cb1[262].xyz + -r14.xyz;
        r13.xyz = r13.xyz * float3(0.400000006,0.400000006,0.400000006) + r14.xyz;
        r16.xyz = r14.xyz * r9.xyz;
        r13.xyz = r13.xyz * r9.xyz + -r16.xyz;
        r13.xyz = r10.xxx * r13.xyz + r16.xyz;
        r11.xyz = r11.xyz * r7.xyz + r13.xyz;
        r12.xyz = r12.xyz * r9.xyz;
        r13.xyz = r15.xyz * r7.www;
        r9.xyz = r13.xyz * r9.xyz + -r12.xyz;
        r9.xyz = r10.xxx * r9.xyz + r12.xyz;
        r0.x = tex2Dlod(_IN8, float4(v0.xy, 0, 0)).x;
        r0.x = -1 + r0.x;
        r0.x = r4.z * r0.x + 1;
        r9.xyz = r9.xyz + -r11.xyz;
        r9.xyz = r5.www * r9.xyz + r11.xyz;
        r11.xyz = float3(1,1,1) + -r8.xyz;
        r8.xyz = r0.xxx * r11.xyz + r8.xyz;
        r8.xyz = r9.xyz * r8.xyz;
    } else {
        r0.x = saturate(r0.w + r0.w);
        r3.x = r0.x * -2 + 3;
        r0.x = r0.x * r0.x;
        r0.x = r3.x * r0.x;
        r3.x = -0.5 + r0.w;
        r3.x = saturate(r3.x + r3.x);
        r4.z = r3.x * -2 + 3;
        r3.x = r3.x * r3.x;
        r3.x = r4.z * r3.x;
        r9.xyz = cb1[262].xyz + -cb1[261].xyz;
        r4.z = dot(abs(r9.xyz), float3(0.300000012,0.589999974,0.109999999));
        r4.z = 10 * r4.z;
        r4.z = min(1, r4.z);
        r4.w = r4.z * -2 + 3;
        r4.z = r4.z * r4.z;
        r4.z = r4.w * r4.z;
        r4.w = r4.z * r3.x;
        r5.w = cb1[265].y + -cb1[265].x;
        r6.w = r1.w * cb1[253].y + -cb1[265].x;
        r5.w = 1 / r5.w;
        r6.w = saturate(r6.w * r5.w);
        r7.w = r6.w * -2 + 3;
        r6.w = r6.w * r6.w;
        r6.w = r7.w * r6.w;
        r6.w = r6.w * r4.w;
        r1.w = r1.w * cb1[253].y + -r6.w;
        r1.w = cb1[265].z * r1.w + r6.w;
        r6.w = -cb1[265].x + r1.w;
        r5.w = saturate(r6.w * r5.w);
        r6.w = r5.w * -2 + 3;
        r5.w = r5.w * r5.w;
        r5.w = r6.w * r5.w;
        r4.w = r5.w * r4.w;
        r3.x = r3.x * r4.z + -r4.w;
        r3.x = cb1[265].z * r3.x + r4.w;
        r4.z = r1.w * r5.y;
        r4.z = 10 * r4.z;
        r1.w = -1 + r1.w;
        r1.w = cb1[260].y * r1.w + 1;
        r4.w = r3.w * r3.x + -r1.w;
        r1.w = r5.x * r4.w + r1.w;
        r4.w = r3.w * r3.x + -r3.x;
        r10.x = r5.x * r4.w + r3.x;
        r5.xyw = float3(0.200000003,0.200000003,0.200000003) * cb1[261].xyz;
        r9.xyz = cb1[262].xyz * float3(0.5,0.5,0.5) + -r5.xyw;
        r5.xyw = r1.www * r9.xyz + r5.xyw;
        r5.xyw = cb1[260].xxx * r5.xyw;
        r5.xyw = r5.xyw * r2.xyz;
        r9.xyz = r5.xyw * r7.xyz;
        r11.xyz = cb1[261].xyz * r2.xyz;
        r0.x = r0.x * 0.300000012 + 0.699999988;
        r14.xyz = r11.xyz * r0.xxx;
        r11.xyz = r11.xyz * r0.xxx + r9.xyz;
        r9.xyz = r9.xyz * r4.zzz + r11.xyz;
        r11.xyz = r2.xyz * cb1[262].xyz + -r14.xyz;
        r11.xyz = r11.xyz * r10.xxx;
        r11.xyz = r11.xyz * float3(0.400000006,0.400000006,0.400000006) + r14.xyz;
        r5.xyw = r5.xyw * r7.xyz + r11.xyz;
        r11.xyz = r2.xyz * cb1[262].xyz + -r9.xyz;
        r9.xyz = r10.xxx * r11.xyz + r9.xyz;
        r9.xyz = r9.xyz + -r5.xyw;
        r8.xyz = r1.www * r9.xyz + r5.xyw;
    }
    r0.x = -0.400000006 + r0.w;
    r0.x = saturate(10.000001 * r0.x);
    r0.w = r0.x * -2 + 3;
    r0.x = r0.x * r0.x;
    r10.y = r0.w * r0.x;
    r5.xyw = r8.xyz * float3(0.5,0.5,0.5) + cb1[261].xyz;
    r5.xyw = r5.xyw * r2.xyz;
    r9.xyz = cb1[261].xyz * r2.xyz;
    r5.xyw = cb1[255].xxx ? r5.xyw : r9.xyz;
    r9.xyz = r0.zzz ? r5.xyw : r14.xyz;
    r5.xyw = r0.zzz ? r5.xyw : r8.xyz;
    r0.xw = r0.zz ? float2(0,0) : r10.xy;
    r8.xyz = cb1[264].xyz + cb1[264].xyz;
    r8.xyz = r0.xxx * r8.xyz + -cb1[264].xyz;
    r10.xyz = float3(0,0,0);
    r1.w = 1;
    r3.x = 0;
    while (true) {
        r4.z = ((uint)r3.x >= asuint(cb2[128].x)) ? 1.0 : 0.0;
        if (r4.z != 0) break;
        bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  r4.z = (((uint)r3.x << 3) & bitmask.z) | ((uint)7 & ~bitmask.z);
        bitmask.w = ((~(-1 << 3)) << 5) & 0xffffffff;  r4.w = (((uint)cb2[r4.z+0].w << 5) & bitmask.w) | ((uint)0 & ~bitmask.w);
        r4.w = (int)r4.y & (int)r4.w;
        if (r4.w == 0) {
        r4.w = (int)r3.x + 1;
        r3.x = r4.w;
        continue;
        }
        r4.w = (uint)r3.x << 3;
        r11.xyz = cb2[r4.w+0].xyz + -r6.xyz;
        r6.w = cb2[r4.w+0].w * cb2[r4.w+0].w;
        r7.w = dot(r11.xyz, r11.xyz);
        r6.w = r7.w * r6.w;
        r8.w = (1 >= r6.w) ? 1.0 : 0.0;
        if (r8.w != 0) {
        bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.x = (((uint)r3.x << 3) & bitmask.x) | ((uint)1 & ~bitmask.x);
        bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.y = (((uint)r3.x << 3) & bitmask.y) | ((uint)2 & ~bitmask.y);
        bitmask.z = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.z = (((uint)r3.x << 3) & bitmask.z) | ((uint)3 & ~bitmask.z);
        bitmask.w = ((~(-1 << 29)) << 3) & 0xffffffff;  r12.w = (((uint)r3.x << 3) & bitmask.w) | ((uint)4 & ~bitmask.w);
        bitmask.x = ((~(-1 << 29)) << 3) & 0xffffffff;  r13.x = (((uint)r3.x << 3) & bitmask.x) | ((uint)5 & ~bitmask.x);
        bitmask.y = ((~(-1 << 29)) << 3) & 0xffffffff;  r13.y = (((uint)r3.x << 3) & bitmask.y) | ((uint)6 & ~bitmask.y);
        r6.w = saturate(r6.w * 2.5 + -1.5);
        r8.w = r6.w * r6.w;
        r6.w = -r6.w * 2 + 3;
        r6.w = -r8.w * r6.w + 1;
        r7.w = rsqrt(r7.w);
        r14.xyz = r11.xyz * r7.www;
        r7.w = dot(r1.xyz, r14.xyz);
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
        r13.xzw = r2.xyz * cb2[r13.x+0].xyz + -r15.xyz;
        r13.xzw = r7.www * r13.xzw + r15.xyz;
        r13.xzw = cb2[r4.z+0].xxx * r13.xzw;
        r11.xyz = cb2[r4.w+0].www * r11.xyz;
        r4.w = dot(r11.xyz, r11.xyz);
        r4.w = r4.w * cb2[r12.w+0].x + cb2[r12.w+0].y;
        r4.w = 9.99999975e-005 + r4.w;
        r4.w = 1 / r4.w;
        r4.w = -1 + r4.w;
        r4.w = cb2[r12.w+0].z * r4.w;
        r4.w = r4.w * r4.w;
        r4.w = min(1, r4.w);
        if (4 == 0) r7.w = 0; else if (4+16 < 32) {       r7.w = (uint)cb2[r12.x+0].w << (32-(4 + 16)); r7.w = (uint)r7.w >> (32-4);      } else r7.w = (uint)cb2[r12.x+0].w >> 16;
        r7.w = ((int)r7.w == 2) ? 1.0 : 0.0;
        r8.w = dot(r14.xyz, cb2[r12.x+0].xyz);
        r8.w = -cb2[r12.y+0].x + r8.w;
        r8.w = saturate(cb2[r12.y+0].y * r8.w);
        r8.w = r8.w * r8.w;
        r8.w = r8.w * r8.w;
        r8.w = r8.w * r4.w;
        r4.w = r7.w ? r8.w : r4.w;
        r7.w = dot(r8.xyz, r14.xyz);
        r7.w = saturate(r7.w * 0.5 + 0.5);
        r7.w = r0.w * r7.w + -r0.x;
        r7.w = cb2[r12.w+0].w * r7.w + r0.x;
        r11.xyz = cb2[r12.z+0].www * r9.xyz;
        r12.xyw = -r9.xyz * cb2[r12.z+0].www + r2.xyz;
        r11.xyz = r7.www * r12.xyw + r11.xyz;
        r11.xyz = cb2[r12.z+0].xyz * r11.xyz;
        r7.w = cb2[r12.z+0].x + cb2[r12.z+0].y;
        r7.w = cb2[r12.z+0].z + r7.w;
        r7.w = cb2[r4.z+0].x + r7.w;
        r7.w = saturate(10 * r7.w);
        r4.z = cb2[r4.z+0].y * r7.w;
        r12.xyz = r13.xzw * r4.www;
        r11.xyz = r11.xyz * r4.www + r12.xyz;
        r6.w = r6.w + -r4.w;
        r4.w = cb2[r13.y+0].w * r6.w + r4.w;
        r10.xyz = r11.xyz * r1.www + r10.xyz;
        r4.z = -r4.w * r4.z + 1;
        r1.w = r4.z * r1.w;
        }
        r3.x = (int)r3.x + 1;
    }
    r4.yzw = r1.www * r5.xyw + r10.xyz;
    r0.x = ((int)r4.x != 13) ? 1.0 : 0.0;
    if (r0.x != 0) {
        r0.x = ((int)r4.x == 1) ? 1.0 : 0.0;
        r0.x = r0.x ? r3.z : r3.y;
        r3.xyz = cb1[67].xyz + -r6.xyz;
        r0.w = dot(r3.xyz, r3.xyz);
        r0.w = rsqrt(r0.w);
        r3.xyz = r3.xyz * r0.www;
        r0.w = saturate(-0.100000001 + r0.x);
        r0.x = saturate(10 * r0.x);
        r1.w = r0.w * 2000 + 50;
        r4.x = r0.w + r0.w;
        r0.x = cb0[0].x * r0.x;
        r0.x = r0.x * 0.800000012 + r4.x;
        r5.xyw = cb1[21].xyz * r1.yyy;
        r5.xyw = r1.xxx * cb1[20].xyz + r5.xyw;
        r5.xyw = r1.zzz * cb1[22].xyz + r5.xyw;
        r4.x = asint(cb0[0].w);
        r4.x = (0.5 < r4.x) ? 1.0 : 0.0;
        r3.xyz = r4.xxx ? float3(0,0,0) : r3.xyz;
        r6.xy = r4.xx ? cb0[0].yz : cb1[264].xy;
        r6.z = r4.x ? 0.5 : cb1[264].z;
        r1.xyz = r4.xxx ? r5.xyw : r1.xyz;
        r4.x = dot(r6.xyz, r1.xyz);
        r8.xy = float2(0.200000003,1) + r4.xx;
        r4.x = 5 * r8.x;
        r4.x = saturate(r4.x);
        r5.w = r4.x * -2 + 3;
        r4.x = r4.x * r4.x;
        r4.x = r5.w * r4.x;
        r8.xzw = r6.xyz + r3.xyz;
        r5.w = dot(r8.xzw, r8.xzw);
        r5.w = rsqrt(r5.w);
        r8.xzw = r8.xzw * r5.www;
        r5.w = saturate(dot(r1.xyz, r8.xzw));
        r5.w = r5.w * r5.w;
        r5.w = r5.w * -0.800000012 + 1;
        r5.w = r5.w * r5.w;
        r5.w = 3.14159274 * r5.w;
        r5.w = 0.200000003 / r5.w;
        r5.w = r5.w * r3.w;
        r6.x = dot(r6.xyz, r3.xyz);
        r6.xy = float2(-0.5,1) + -r6.xx;
        r6.x = saturate(r6.x + r6.x);
        r6.z = r6.x * -2 + 3;
        r6.x = r6.x * r6.x;
        r6.x = r6.z * r6.x + 1;
        r1.x = saturate(dot(r3.xyz, r1.xyz));
        r1.x = 0.800000012 + -r1.x;
        r1.x = max(0, r1.x);
        r1.y = max(0, cb1[133].x);
        r1.y = min(1.74532926, r1.y);
        r1.xy = float2(1.5,0.572957814) * r1.xy;
        r1.z = max(0, r2.w);
        r3.xy = min(float2(3000,50), r1.zz);
        r3.xy = float2(3000,50) + -r3.xy;
        r3.xy = float2(0.00033333333,0.0199999996) * r3.xy;
        r1.z = r3.x * r3.x;
        r1.z = r1.z * r1.z;
        r1.z = r1.z * r1.z + r3.y;
        r1.z = -1 + r1.z;
        r1.y = r1.y * r1.z + 1;
        r1.z = 1 + -r1.y;
        r1.y = r0.w * r1.z + r1.y;
        r1.z = r8.y * 0.25 + 0.5;
        r1.x = r1.z * r1.x;
        r1.x = r1.x * r1.y;
        r1.x = r1.x * r6.x;
        r1.x = 0.00999999978 * r1.x;
        r3.xy = float2(9.99999975e-005,9.99999975e-005) + r5.xy;
        r1.z = dot(r3.xy, r3.xy);
        r1.z = rsqrt(r1.z);
        r3.xy = r3.xy * r1.zz;
        r3.xy = r3.xy * r0.xx;
        r3.z = r3.y * r1.x;
        r1.y = -0.5;
        r1.xy = r3.xz * r1.xy;
        r0.x = 0.400000006 * r6.y;
        r1.z = r4.x * 0.800000012 + 0.200000003;
        r3.x = r5.w * r4.x;
        r3.x = 1.5 * r3.x;
        r0.x = r0.x * r1.z + r3.x;
        r1.z = r3.w * 0.5 + 0.5;
        r0.x = r1.z * r0.x;
        r3.xy = v0.xy * cb1[138].xy + -cb1[134].xy;
        r1.xy = r3.xy * cb1[135].zw + r1.xy;
        r1.xy = r1.xy * cb1[135].xy + cb1[134].xy;
        r1.xy = cb1[138].zw * r1.xy;
        r1.x = tex2D(_IN6, r1.xy).x;
        r1.y = r1.x * cb1[65].x + cb1[65].y;
        r1.x = r1.x * cb1[65].z + -cb1[65].w;
        r1.x = 1 / r1.x;
        r1.x = r1.y + r1.x;
        r1.x = r1.x + -r2.w;
        r1.x = max(9.99999975e-005, r1.x);
        r0.w = -r0.w * 1000 + r1.x;
        r1.x = 1 / r1.w;
        r0.w = saturate(r1.x * r0.w);
        r1.x = r0.w * -2 + 3;
        r0.w = r0.w * r0.w;
        r0.w = r1.x * r0.w;
        r0.w = min(1, r0.w);
        r1.x = dot(cb1[263].xyz, float3(0.300000012,0.589999974,0.109999999));
        r1.yzw = cb1[263].xyz + -r1.xxx;
        r1.xyz = r1.yzw * float3(0.75,0.75,0.75) + r1.xxx;
        r3.xyz = cb1[263].xyz + -r1.xyz;
        r1.xyz = r3.www * r3.xyz + r1.xyz;
        r1.xyz = r1.xyz * r0.xxx;
        r1.xyz = float3(0.100000001,0.100000001,0.100000001) * r1.xyz;
        r3.xyz = float3(1,1,1) + r2.xyz;
        r3.xyz = r3.xyz * r1.xyz;
        r5.xyw = r2.xyz * float3(1.20000005,1.20000005,1.20000005) + float3(-1,-1,-1);
        r5.xyw = saturate(-r5.xyw);
        r6.xyz = r5.xyw * float3(-2,-2,-2) + float3(3,3,3);
        r5.xyw = r5.xyw * r5.xyw;
        r5.xyw = r6.xyz * r5.xyw;
        r5.xyw = r5.xyw * float3(14,14,14) + float3(1,1,1);
        r1.xyz = r5.xyw * r1.xyz;
        r1.xyz = r1.xyz * r2.xyz + -r3.xyz;
        r1.xyz = cb1[260].zzz * r1.xyz + r3.xyz;
        r1.xyz = r1.xyz * r0.www;
        r0.x = -10000 + r2.w;
        r0.x = max(0, r0.x);
        r0.x = min(5000, r0.x);
        r0.x = 5000 + -r0.x;
        r0.x = 0.000199999995 * r0.x;
        r1.xyz = r0.xxx * r1.xyz;
        r1.xyz = cb0[1].xyz * r1.xyz;
    } else {
        r1.xyz = float3(0,0,0);
    }
    r0.x = (0 != r5.z) ? 1.0 : 0.0;
    r2.xyz = r4.yzw * r7.xyz;
    r2.xyz = cb1[263].xyz * r2.xyz;
    r2.xyz = r2.xyz * float3(0.5,0.5,0.5) + -r4.yzw;
    r2.xyz = r0.www * r2.xyz + r4.yzw;
    r1.xyz = r4.yzw + r1.xyz;
    r1.xyz = r0.xxx ? r2.xyz : r1.xyz;
    r0.xzw = r0.zzz ? r4.yzw : r1.xyz;
    r0.xyz = r0.xzw / r0.yyy;
    r0.xyz = min(float3(0,0,0), -r0.xyz);
    color.xyz = -r0.xyz;
    return color;
}
            ENDCG
        }
    }
}