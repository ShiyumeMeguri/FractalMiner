Shader "Custom/WWUber"
{
    Properties
    {
        _BlitTexture("BlitTexture", 2D) = "white" {}
        _BloomTexture("BloomTexture", 2D) = "white" {}
        _Lut3D("Lut3D", 3D) = "white" {}
        _Lut2D("Lut2D", 2D) = "white" {}
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
                float4 positionOS   : POSITION;
                float2 uv           : TEXCOORD0;
            };

            // 顶点到片元着色器的传递结构
            struct Varyings
            {
                float4 positionCS   : SV_POSITION;
                linear noperspective float2 texcoord0  : TEXCOORD0;
                linear noperspective float4 texcoord1  : TEXCOORD1;
                linear noperspective float4 texcoord2  : TEXCOORD2;
                linear noperspective float2 texcoord3  : TEXCOORD3;
                float2 texcoord4  : TEXCOORD4;
            };

            // 资源声明 (使用 sampler2D/3D 传统方式)
            sampler2D _BlitTexture;
            float4 _BlitTexture_TexelSize;
            sampler2D _BloomTexture;
            sampler3D _Lut3D;
        TEXTURE2D(_Lut2D);

            // 常量缓冲声明
            StructuredBuffer<float4> vcb0;
            StructuredBuffer<float4> vcb1;
            StructuredBuffer<float4> fcb0;

            // 3Dmigoto 宏定义
            #define cmp -

            //=========================================================================================
            // 顶点着色器 (Vertex Shader)
            //=========================================================================================
Varyings vert (Attributes IN)
            {
                Varyings OUT;

                // 使用Unity内置变量替换cb常量
                // _BlitTexture_TexelSize.xy = (1/width, 1/height)
                // _BlitTexture_TexelSize.zw = (width, height)
                float2 resolution = _BlitTexture_TexelSize.zw;
                float2 texelSize = _BlitTexture_TexelSize.xy;

                // -- 开始转换后的代码 --

                // 1. 计算各种UV坐标
                // 原始: r0.xy = IN.uv.xy * vcb1[1].xy + vcb1[1].zw;
                // 原始: r0.zw = vcb1[2].zw * r0.xy;
                // 简化后 r0.zw 等价于 IN.uv
                float2 main_uv = IN.uv;
                
                // 传递给 texcoord0 的是主UV
                // 原始: OUT.texcoord0.xy = r0.zw;
                OUT.texcoord0.xy = main_uv;

                // 计算偏移UV，用于 texcoord2.zw
                // 原始: OUT.texcoord2.zw = r0.xy * vcb1[2].zw + vcb0[74].xy;
                // vcb0[74].xy = (0.5, 0.33333)
                OUT.texcoord2.zw = main_uv + float2(0.5, 0.33333); 
                
                // 计算另一个偏移UV，用于 texcoord2.xy
                // 原始: OUT.texcoord2.xy = vcb0[47].zw * float2(-0.5,0.5) + r0.zw;
                // vcb0[47].zw 也是 texelSize
                OUT.texcoord2.xy = texelSize * float2(-0.5, 0.5) + main_uv;

                // 2. 计算镜头畸变相关的坐标
                // 将UV坐标转换到以屏幕中心为原点的[-1, 1]范围
                // 原始: r0.xy = r0.zw * vcb0[47].xy + -vcb0[48].zw;
                // vcb0[48].zw = (width/2, height/2)
                float2 centered_coords = main_uv * resolution - (resolution * 0.5);

                // 归一化中心坐标，但Y轴被翻转了
                // 原始: r0.xy = r0.xy / vcb0[48].xy;
                // vcb0[48].xy = (width/2, -height/2)
                float2 normalized_coords = centered_coords / float2(resolution.x * 0.5, -resolution.y * 0.5);

                // 传递归一化坐标给 texcoord3
                // 原始: r0.zw = r0.xy * vcb0[91].zw + vcb0[91].xy; OUT.texcoord3.xy = r0.xy;
                // vcb0[91] = (0,0,1,1)
                OUT.texcoord3.xy = normalized_coords;

                // 计算并应用畸变
                // 原始: r1.w = vcb0[64].y * vcb0[64].z;
                // vcb0[64].y 是 height, vcb0[64].z 是 1/width
                float aspect_ratio_factor = resolution.y * texelSize.x;

                // 原始: r0.xy = r1.zw * r0.zw;
                float2 aspect_corrected_coords = float2(1, aspect_ratio_factor) * normalized_coords;

                // 原始: r0.z = sqrt(r1.w * r1.w + 1); r0.z = 1.41421354 / r0.z;
                float lens_scale = 1.41421354 / sqrt(aspect_ratio_factor * aspect_ratio_factor + 1.0);

                // 传递最终的畸变坐标给 texcoord1.zw
                // 原始: OUT.texcoord1.zw = r0.xy * r0.zz;
                OUT.texcoord1.zw = aspect_corrected_coords * lens_scale;

                // 3. 从纹理左上角采样特殊值
                // 原始: r0.xy = tex2Dlod(_BlitTexture, float4(0, 0, 0, 0)).xw; OUT.texcoord1.xy = r0.xy;
                OUT.texcoord1.xy = tex2Dlod(_BlitTexture, float4(0, 0, 0, 0)).xw;
                
                // 4. 顶点位置和最后一个texcoord的计算
                // 原始代码的这部分非常复杂，是反编译的结果。
                // 它的作用是把全屏四边形的顶点转换到裁剪空间，并计算texcoord4。
                // 经过分析，其最终结果与Unity的标准做法等效。
                
                // 计算 OUT.texcoord4.xy
                // 原始逻辑: 
                // r0.xyzw = IN.positionOS.xyxy * vcb1[0].xyxy + vcb1[0].zwzw;
                // r0.xyzw = vcb1[2].xyxy * r0.xyzw;
                // r0.xyzw = r0.xyzw * float4(2,2,2,2) + float4(-1,-1,-1,-1);
                // OUT.texcoord4.xy = r0.zw * float2(0.5,0.5) + float2(0.5,0.5);
                // 这一系列操作简化后，OUT.texcoord4.xy 就等于 IN.uv.xy
                OUT.texcoord4.xy = IN.uv.xy;

                // 计算裁剪空间位置
                // 原始的 r0.xy 最后变成了裁剪空间坐标
                // 我们可以使用Unity的标准函数TransformObjectToHClip来获得完全相同的结果，
                // 这也是“适合Unity的格式”的最佳实践。
                OUT.positionCS = TransformObjectToHClip(IN.positionOS.xyz);
                
                // --- 结束转换后的代码 ---
                
                return OUT;
            }

// 2D LUT grading
// scaleOffset = (1 / lut_width, 1 / lut_height, lut_height - 1)
float3 ApplyLut2D(TEXTURE2D_PARAM(tex, samplerTex), float3 uvw, float3 scaleOffset)
{
    // Strip format where `height = sqrt(width)`
    uvw.z *= scaleOffset.z;
    float shift = floor(uvw.z);
    uvw.xy = uvw.xy * scaleOffset.z * scaleOffset.xy + scaleOffset.xy * 0.5;
    uvw.x += shift * scaleOffset.y;
    uvw.xyz = lerp(
        SAMPLE_TEXTURE2D_LOD(tex, samplerTex, uvw.xy, 0.0).rgb,
        SAMPLE_TEXTURE2D_LOD(tex, samplerTex, uvw.xy + float2(scaleOffset.y, 0.0), 0.0).rgb,
        uvw.z - shift
    );
    return uvw;
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
                // [修正] 使用 tex2D 替换 .Sample
                r3.xyz = tex2D(_BlitTexture, r0.xy).xyz;
                r4.x = tex2D(_BlitTexture, r2.xy).x;
                r4.y = tex2D(_BlitTexture, r2.zw).y;
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
                // [修正] 使用 tex2D 替换 .Sample
                r0.xyz = tex2D(_BloomTexture, r0.xy).xyz;
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
                return r0; // 妈的脑瘫UE 用尼玛tex3D
                // r0.xyz = tex3D(_Lut3D, r0.xyz).xyz;
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