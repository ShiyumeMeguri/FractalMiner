Shader "Custom/WWUber"
{
    Properties
    {
        _BlitTexture("BlitTexture", 2D) = "white" {}
        _BloomTexture("BloomTexture", 2D) = "white" {}
        _Lut3D("Lut3D", 3D) = "white" {} // 根据反编译代码修正为 3D 纹理
    }

    SubShader
    {
        Pass
        {
            HLSLPROGRAM

            #pragma vertex vert
            #pragma fragment frag
            #pragma target 5.0

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            // 顶点着色器的输入结构
            struct Attributes
            {
                float4 positionOS   : POSITION;     // 对应 v0
                float2 uv           : TEXCOORD0;    // 对应 v1
            };

            // 顶点到片元着色器的传递结构
            struct Varyings
            {
                float4 positionCS   : SV_POSITION;       // 对应 o4 (SV_POSITION0)
                linear noperspective float2 texcoord0  : TEXCOORD0;   // 对应 o0
                linear noperspective float4 texcoord1  : TEXCOORD1;   // 对应 o1
                linear noperspective float4 texcoord2  : TEXCOORD2;   // 对应 o2
                linear noperspective float2 texcoord3  : TEXCOORD3;   // 对应 p0
                float2 texcoord4  : TEXCOORD4;                      // 对应 o3
            };

            // 资源声明
            sampler2D _BlitTexture;
            sampler2D _BloomTexture;
            sampler3D _Lut3D;
            
            // 常量缓冲声明
            StructuredBuffer<float4> vcb0; // 顶点CB
            StructuredBuffer<float4> vcb1; // 顶点CB
            StructuredBuffer<float4> fcb0; // 片元CB

            // 3Dmigoto 宏定义
            #define cmp -

            //=========================================================================================
            // 顶点着色器 (Vertex Shader)
            //=========================================================================================
            Varyings vert (Attributes IN)
            {
                Varyings OUT;
                float4 r0, r1;
                
                // --- 开始移植反编译代码 (VS) ---
                r0.xy = IN.uv.xy * vcb1[1].xy + vcb1[1].zw;
                r0.zw = vcb1[2].zw * r0.xy;
                OUT.texcoord2.zw = r0.xy * vcb1[2].zw + vcb0[74].xy;
                OUT.texcoord0.xy = r0.zw;
                r0.xy = r0.zw * vcb0[47].xy + -vcb0[48].zw;
                OUT.texcoord2.xy = vcb0[47].zw * float2(-0.5,0.5) + r0.zw;
                r0.xy = r0.xy / vcb0[48].xy;
                r0.zw = r0.xy * vcb0[91].zw + vcb0[91].xy;
                OUT.texcoord3.xy = r0.xy;
                r1.z = 1;
                r1.w = vcb0[64].y * vcb0[64].z;
                r0.xy = r1.zw * r0.zw;
                r0.z = r1.w * r1.w + 1;
                r0.z = sqrt(r0.z);
                r0.z = 1.41421354 / r0.z;
                OUT.texcoord1.zw = r0.xy * r0.zz;
                r0.xy = _BlitTexture.Load(int3(0,0,0)).xw;
                OUT.texcoord1.xy = r0.xy;
                r0.xyzw = IN.positionOS.xyxy * vcb1[0].xyxy + vcb1[0].zwzw;
                r0.xyzw = vcb1[2].xyxy * r0.xyzw;
                r0.xyzw = r0.xyzw * float4(2,2,2,2) + float4(-1,-1,-1,-1);
                OUT.texcoord4.xy = r0.zw * float2(0.5,0.5) + float2(0.5,0.5);
                r0.xy = float2(1,-1) * r0.xy;
                OUT.positionCS.xy = r0.xy;
                OUT.positionCS.zw = IN.positionOS.zw;
                // --- 结束移植反编译代码 (VS) ---
                
                return OUT;
            }
            
            //=========================================================================================
            // 片元着色器 (Fragment/Pixel Shader)
            //=========================================================================================
            float4 frag (Varyings IN) : SV_Target
            {
                float4 o0; // 输出颜色
                float4 r0,r1,r2,r3,r4,r5;
                
                // --- 开始移植反编译代码 (PS) ---
                r0.xy = IN.texcoord3.xy * fcb0[48].xy + fcb0[48].zw;
                r0.xy = fcb0[47].zw * r0.xy;
                r0.z = IN.texcoord2.w * 543.309998 + IN.texcoord2.z;
                r0.w = sin(r0.z);
                r0.w = 493013 * r0.w;
                r1.x = frac(r0.w);
                r0.w = cmp(0 < fcb0[76].x);
                r2.xy = float2(33.9900017,66.9899979) + r0.zz;
                r2.xy = sin(r2.xy);
                r2.xy = r2.xy * float2(493013,493013) + float2(7.17700005,14.2989998);
                r1.yz = frac(r2.xy);
                r1.yzw = r1.xyz + -r1.xxx;
                r1.yzw = fcb0[76].xxx * r1.yzw + r1.xxx;
                r1.xyz = r0.www ? r1.yzw : r1.xxx;
                r2.yw = fcb0[96].zz * fcb0[95].xy;
                r0.z = cmp(fcb0[96].x == 0.000000);
                r2.xz = r0.zz ? r2.yw : fcb0[95].xy;
                r3.xyzw = IN.texcoord3.xyxy * fcb0[92].zwzw + fcb0[92].xyxy;
                r4.xyzw = cmp(float4(0,0,0,0) < r3.zwzw);
                r5.xyzw = cmp(r3.zwzw < float4(0,0,0,0));
                r4.xyzw = (int4)-r4.xyzw + (int4)r5.xyzw;
                r4.xyzw = (int4)r4.xyzw;
                r5.xyzw = saturate(-fcb0[95].zzzz + abs(r3.zwzw));
                r4.xyzw = r5.xyzw * r4.xyzw;
                r2.xyzw = -r4.ywxz * r2.ywxz + r3.ywxz;
                r0.z = cmp(0 < fcb0[96].x);
                r3.xy = -fcb0[96].ww * float2(0.400000006,0.200000003) + r2.xy;
                r2.xy = r0.zz ? r3.xy : r2.xy;
                r2.xyzw = r2.zxwy * fcb0[93].zwzw + fcb0[93].xyxy;
                r2.xyzw = r2.xyzw * fcb0[48].xyxy + fcb0[48].zwzw;
                r2.xyzw = fcb0[47].zwzw * r2.xyzw;
                r3.xyz = _BlitTexture.Sample(sampler_BlitTexture, r0.xy).xyz;
                r4.x = _BlitTexture.Sample(sampler_BlitTexture, r2.xy).x;
                r4.y = _BlitTexture.Sample(sampler_BlitTexture, r2.zw).y;
                r0.w = dot(r3.xyz, float3(0.298999995,0.587000012,0.114));
                r0.w = -fcb0[96].y + r0.w;
                r0.w = saturate(10 * r0.w);
                r1.w = r0.w * -2 + 3;
                r0.w = r0.w * r0.w;
                r0.w = r1.w * r0.w;
                r4.z = r3.z;
                r2.xyz = r4.xyz + -r3.xyz;
                r2.xyz = r0.www * r2.xyz + r3.xyz;
                r2.xyz = r2.xyz + -r4.xyz;
                r2.xyz = fcb0[96].xxx * r2.xyz + r4.xyz;
                r2.xyz = r0.zzz ? r2.xyz : r4.xyz;
                r2.xyz = fcb0[69].xyz * r2.xyz;
                r0.xy = fcb0[68].xy * r0.xy + fcb0[68].zw;
                r0.xy = max(fcb0[60].xy, r0.xy);
                r0.xy = min(fcb0[60].zw, r0.xy);
                r0.xyz = _BloomTexture.Sample(sampler_BloomTexture, r0.xy).xyz;
                r0.xyz = r2.xyz * IN.texcoord1.xxx + r0.xyz;
                r2.xy = fcb0[73].xy * float2(2,2) + IN.texcoord1.zw;
                r2.xy = float2(-1,-1) + r2.xy;
                r2.xy = fcb0[71].xx * r2.xy;
                r2.xy = fcb0[71].zw * r2.xy;
                r0.w = dot(r2.xy, r2.xy);
                r1.w = saturate(fcb0[72].w);
                r1.w = r1.w * 9 + 1;
                r0.w = r0.w * r1.w + 1;
                r0.w = rcp(r0.w);
                r0.w = r0.w * r0.w;
                r2.xyz = float3(1,1,1) + -fcb0[72].xyz;
                r2.xyz = r0.www * r2.xyz + fcb0[72].xyz;
                r0.xyz = r2.xyz * r0.xyz;
                if (fcb0[86].y != 0) {
                  r2.xyz = r0.xyz * float3(1.36000001,1.36000001,1.36000001) + float3(0.0469999984,0.0469999984,0.0469999984);
                  r2.xyz = r2.xyz * r0.xyz;
                  r3.xyz = r0.xyz * float3(0.959999979,0.959999979,0.959999979) + float3(0.560000002,0.560000002,0.560000002);
                  r3.xyz = r0.xyz * r3.xyz + float3(0.140000001,0.140000001,0.140000001);
                  r0.xyz = saturate(r2.xyz / r3.xyz);
                }
                if (fcb0[86].z != 0) {
                  r2.xyz = float3(-0.195050001,-0.195050001,-0.195050001) + r0.xyz;
                  r2.xyz = float3(-0.163980007,-0.163980007,-0.163980007) / r2.xyz;
                  r2.xyz = float3(1.00495005,1.00495005,1.00495005) + r2.xyz;
                  r3.xyz = cmp(float3(0.600000024,0.600000024,0.600000024) >= r0.xyz);
                  r3.xyz = r3.xyz ? float3(1,1,1) : 0;
                  r4.xyz = -r2.xyz + r0.xyz;
                  r0.xyz = saturate(r3.xyz * r4.xyz + r2.xyz);
                }
                if (fcb0[86].w != 0) {
                  r2.xyz = fcb0[37].yyy * r0.xyz;
                  r2.xyz = fcb0[37].www * fcb0[37].zzz + r2.xyz;
                  r3.xy = fcb0[38].xx * fcb0[38].yz;
                  r2.xyz = r0.xyz * r2.xyz + r3.xxx;
                  r3.xzw = r0.xyz * fcb0[37].yyy + fcb0[37].zzz;
                  r3.xyz = r0.xyz * r3.xzw + r3.yyy;
                  r2.xyz = r2.xyz / r3.xyz;
                  r0.w = fcb0[38].y / fcb0[38].z;
                  r0.xyz = saturate(r2.xyz + -r0.www);
                }
                r0.xyz = float3(0.00266771927,0.00266771927,0.00266771927) + r0.xyz;
                r0.xyz = log2(r0.xyz);
                r0.xyz = saturate(r0.xyz * float3(0.0714285746,0.0714285746,0.0714285746) + float3(0.610726953,0.610726953,0.610726953));
                r0.xyz = r0.xyz * float3(0.96875,0.96875,0.96875) + float3(0.015625,0.015625,0.015625);
                r0.xyz = _Lut3D.Sample(sampler_Lut3D, r0.xyz).xyz;
                r0.xyz = float3(1.04999995,1.04999995,1.04999995) * r0.xyz;
                o0.w = saturate(dot(r0.xyz, float3(0.298999995,0.587000012,0.114)));
                r0.xyz = r1.xyz * float3(0.00390625,0.00390625,0.00390625) + r0.xyz;
                r0.xyz = float3(-0.001953125,-0.001953125,-0.001953125) + r0.xyz;
                if (fcb0[86].x != 0) {
                  r1.xyz = log2(r0.xyz);
                  r1.xyz = float3(0.0126833133,0.0126833133,0.0126833133) * r1.xyz;
                  r1.xyz = exp2(r1.xyz);
                  r2.xyz = float3(-0.8359375,-0.8359375,-0.8359375) + r1.xyz;
                  r2.xyz = max(float3(0,0,0), r2.xyz);
                  r1.xyz = -r1.xyz * float3(18.6875,18.6875,18.6875) + float3(18.8515625,18.8515625,18.8515625);
                  r1.xyz = r2.xyz / r1.xyz;
                  r1.xyz = log2(r1.xyz);
                  r1.xyz = float3(6.27739477,6.27739477,6.27739477) * r1.xyz;
                  r1.xyz = exp2(r1.xyz);
                  r1.xyz = float3(10000,10000,10000) * r1.xyz;
                  r1.xyz = r1.xyz / fcb0[85].www;
                  r1.xyz = max(float3(6.10351999e-005,6.10351999e-005,6.10351999e-005), r1.xyz);
                  r2.xyz = float3(12.9200001,12.9200001,12.9200001) * r1.xyz;
                  r1.xyz = max(float3(0.00313066994,0.00313066994,0.00313066994), r1.xyz);
                  r1.xyz = log2(r1.xyz);
                  r1.xyz = float3(0.416666657,0.416666657,0.416666657) * r1.xyz;
                  r1.xyz = exp2(r1.xyz);
                  r1.xyz = r1.xyz * float3(1.05499995,1.05499995,1.05499995) + float3(-0.0549999997,-0.0549999997,-0.0549999997);
                  o0.xyz = min(r2.xyz, r1.xyz);
                } else {
                  o0.xyz = r0.xyz;
                }
                // --- 结束移植反编译代码 (PS) ---
                return o0;
            }
            ENDHLSL
        }
    }
}