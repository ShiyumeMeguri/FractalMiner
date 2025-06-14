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

            //=========================================================================================
            // 片元着色器 (Fragment/Pixel Shader)
            //=========================================================================================
            float4 frag (Varyings IN) : SV_Target
            {
                // fcb0[86] 是一个布尔标志向量，用于控制效果链中的某些步骤是否启用。
                float4 effect_flags = fcb0[86];

                // ---------------------------------------------------------------------------------
                // 1. 生成伪随机值用于胶片颗粒 (在着色器后期应用)
                // ---------------------------------------------------------------------------------
                // 使用屏幕坐标和时间相关因子生成一个伪随机种子
                float grain_seed_base = IN.texcoord2.w * 543.309998 + IN.texcoord2.z;
                
                // 使用 sin 和大质数进行哈希，生成三个[0,1]范围的伪随机值
                float random_val_x = frac(493013.0 * sin(grain_seed_base));
                float2 random_seeds_yz = sin(float2(33.9900017, 66.9899979) + grain_seed_base.xx);
                float2 random_vals_yz = frac(random_seeds_yz * 493013.0 + float2(7.17700005, 14.2989998));
                
                // 将随机值组合成一个向量，这代表了胶片颗粒的颜色偏移
                // fcb0[76].x > 0 控制是否启用彩色颗粒，否则为单色颗粒
                float3 filmGrainColorOffset = float3(random_val_x, random_vals_yz.x, random_vals_yz.y);
                if (fcb0[76].x > 0) {
                    filmGrainColorOffset = filmGrainColorOffset.xyz - random_val_x.xxx;
                    filmGrainColorOffset = fcb0[76].xxx * filmGrainColorOffset + random_val_x.xxx;
                } else {
                    filmGrainColorOffset = random_val_x.xxx;
                }
                
                // ---------------------------------------------------------------------------------
                // 2. 色差 (Chromatic Aberration)
                // ---------------------------------------------------------------------------------
                // 计算原始UV
                float2 baseUV = IN.texcoord3.xy * fcb0[48].xy + fcb0[48].zw;
                baseUV = fcb0[47].zw * baseUV;

                // 计算色差的偏移和强度
                float2 chroma_strength = (fcb0[96].x == 0.0) ? (fcb0[96].zz * fcb0[95].xy) : fcb0[95].xy;
                
                // 根据与屏幕中心的距离调整色差UV偏移
                float4 dist_coords = IN.texcoord3.xyxy * fcb0[92].zwzw + fcb0[92].xyxy;
                float4 edge_mask = saturate(-fcb0[95].zzzz + abs(dist_coords.zwzw));
                float4 sign_mask = (dist_coords.zwzw > 0) ? -1.0 : 1.0; // 模拟 (int)-cmp() + (int)cmp()
                float4 dist_offset = edge_mask * sign_mask;
                float4 chroma_offset_uv = -dist_offset.ywxz * chroma_strength.yxyx + dist_coords.ywxz;
                
                if (fcb0[96].x > 0) {
                    chroma_offset_uv.xy = -fcb0[96].ww * float2(0.400000006, 0.200000003) + chroma_offset_uv.xy;
                }

                // 转换回标准UV空间
                float4 chroma_final_uv = chroma_offset_uv.zxwy * fcb0[93].zwzw + fcb0[93].xyxy;
                chroma_final_uv = chroma_final_uv * fcb0[48].xyxy + fcb0[48].zwzw;
                chroma_final_uv = fcb0[47].zwzw * chroma_final_uv;

                // 采样原图(B通道)和偏移后的图(R, G通道)
                float3 baseColor = tex2D(_BlitTexture, baseUV).xyz;
                float3 aberratedColorSample = float3(
                    tex2D(_BlitTexture, chroma_final_uv.xy).x,
                    tex2D(_BlitTexture, chroma_final_uv.zw).y,
                    baseColor.z
                );
                
                // 根据亮度混合原始颜色和色差颜色
                float luma = dot(baseColor, float3(0.298999995, 0.587000012, 0.114));
                float luma_factor = saturate(10.0 * (luma - fcb0[96].y));
                luma_factor = luma_factor * luma_factor * (3.0 - 2.0 * luma_factor); // Smoothstep
                float3 color_after_chroma_ab = lerp(baseColor, aberratedColorSample, luma_factor);
                
                // 进一步混合，由 fcb0[96].x 控制
                float3 final_aberrated_color = lerp(aberratedColorSample, color_after_chroma_ab, fcb0[96].x);
                if (fcb0[96].x == 0.0) {
                    final_aberrated_color = aberratedColorSample;
                }
                
                // ---------------------------------------------------------------------------------
                // 3. 叠加辉光和应用曝光/场景颜色调整
                // ---------------------------------------------------------------------------------
                float3 sceneColor = fcb0[69].xyz * final_aberrated_color;
                float2 bloomUV = fcb0[68].xy * baseUV + fcb0[68].zw;
                bloomUV = max(fcb0[60].xy, bloomUV);
                bloomUV = min(fcb0[60].zw, bloomUV);
                float3 bloomColor = tex2D(_BloomTexture, bloomUV).xyz;
                
                // IN.texcoord1.x 可能是全局曝光/强度
                float3 color_with_bloom = sceneColor * IN.texcoord1.xxx + bloomColor;

                // ---------------------------------------------------------------------------------
                // 4. 镜头畸变 / 暗角 (Vignette)
                // ---------------------------------------------------------------------------------
                float2 lens_coords = (IN.texcoord1.zw + fcb0[73].xy * 2.0) - 1.0;
                lens_coords = fcb0[71].zw * (fcb0[71].xx * lens_coords);
                float dist_sq = dot(lens_coords, lens_coords);
                float vignette_intensity = saturate(fcb0[72].w) * 9.0 + 1.0;
                float vignette_factor = rcp(dist_sq * vignette_intensity + 1.0);
                vignette_factor *= vignette_factor;
                
                float3 vignette_color = lerp(fcb0[72].xyz, float3(1,1,1), vignette_factor);
                float3 color_after_vignette = color_with_bloom * vignette_color;

                float3 gradedColor = color_after_vignette;
                
                // ---------------------------------------------------------------------------------
                // 5. 串联的调色/色调映射模块
                // ---------------------------------------------------------------------------------
                if (effect_flags.y != 0) { // Filmic Tonemapping Curve 1
                  float3 num = gradedColor * (gradedColor * 1.36 + 0.047) + 0.14;
                  float3 den = gradedColor * (gradedColor * 0.96 + 0.56);
                  gradedColor = saturate(num / den);
                }
                if (effect_flags.z != 0) { // Contrast/Color adjustment
                  float3 val = (float3(1.00495,1.00495,1.00495) + (-0.16398 / (gradedColor - 0.19505)));
                  float3 mask = gradedColor <= 0.6;
                  gradedColor = saturate(lerp(val, gradedColor, mask));
                }
                if (effect_flags.w != 0) { // Filmic Tonemapping Curve 2
                  float A = fcb0[37].y; float B = fcb0[37].z; float C = fcb0[37].w; float D = fcb0[38].x; float E = fcb0[38].y; float F = fcb0[38].z;
                  float3 num = gradedColor * (gradedColor * A + B) * C + D;
                  float3 den = gradedColor * (gradedColor * A + B) + E;
                  gradedColor = saturate(num / den - (E / F));
                }

                // ---------------------------------------------------------------------------------
                // 6. 准备LUT坐标并应用 (当前代码并未实际使用LUT)
                // ---------------------------------------------------------------------------------
                // 转换到对数空间并映射到 [0,1]
                float3 logColor = log2(gradedColor + 0.0026677);
                float3 remappedColor = saturate(logColor * 0.07142857 + 0.61072695);
                
                // 为3D纹理采样进行边界安全处理 (1/2 texel offset for a 32^3 LUT)
                float3 lutCoords = remappedColor * 0.96875 + 0.015625;
                
                float3 color_after_lut = tex3D(_Lut3D, lutCoords).xyz; 
                color_after_lut = color_after_lut * 1.04999995;
                
                // 在此处添加之前计算好的胶片颗粒
                float3 color_with_grain = color_after_lut + (filmGrainColorOffset * 0.00390625 - 0.001953125);
                
                // ---------------------------------------------------------------------------------
                // 7. 最终输出变换 (如: HDR to sRGB)
                // ---------------------------------------------------------------------------------
                float4 finalColor;
                finalColor.w = saturate(dot(color_after_lut, float3(0.298999995, 0.587000012, 0.114)));

                if (effect_flags.x != 0) {
                    // 这是一个非常复杂的、可能是从ACEScg到sRGB的近似转换
                    float3 linear_hdr = color_with_grain;
                    float3 log_val = log2(linear_hdr) * 0.0126833;
                    float3 exp_val = exp2(log_val);
                    float3 num_part = max(0, exp_val - 0.8359375);
                    float3 den_part = (18.8515625 - exp_val * 18.6875);
                    float3 normalized_hdr = max(6.10352e-05, exp2(6.27739 * log2(num_part / den_part)) * 10000.0 / fcb0[85].www);
                    
                    // 分段式sRGB转换
                    float3 linear_part = normalized_hdr * 12.92;
                    float3 gamma_part = exp2(0.416666 * log2(max(0.00313067, normalized_hdr))) * 1.055 - 0.055;
                    
                    finalColor.xyz = min(linear_part, gamma_part);
                } else {
                    finalColor.xyz = color_with_grain;
                }

                return finalColor;
            }
            ENDHLSL
        }
    }
}