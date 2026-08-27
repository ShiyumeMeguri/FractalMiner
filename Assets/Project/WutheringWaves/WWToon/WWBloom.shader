Shader "Custom/WWUber"
{
    Properties
    {
        _BlitTexture("Source Texture (Base Color)", 2D) = "white" {}
        _BloomTexture("Bloom Texture", 2D) = "white" {}
    }

    SubShader
    {
        // 关闭剔除、深度测试和写入，这是标准后处理操作
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            HLSLPROGRAM

            #pragma vertex vert
            #pragma fragment frag

            // 包含必要的URP库
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/Shaders/PostProcessing/Common.hlsl" // 提供 sampler_LinearClamp

            // 资源声明
            TEXTURE2D(_BloomTexture);
            // 注意: sampler_LinearClamp 是在 Common.hlsl 中定义的标准采样器

            // 顶点着色器的输入 (一个全屏四边形)
            struct AttributesCus
            {
                float4 positionOS   : POSITION;
                float2 uv           : TEXCOORD0;
            };

            // 从顶点到片元的传递结构
            struct VaryingsCus
            {
                float4 positionCS   : SV_POSITION;
                float2 uv           : TEXCOORD0;
            };

            //=========================================================================================
            // 顶点着色器 (Vertex Shader)
            // 功能: 将顶点转换到裁剪空间，并传递UV坐标。
            //=========================================================================================
            VaryingsCus vert(AttributesCus IN)
            {
                VaryingsCus OUT;
                // 使用Unity标准函数将顶点位置从对象空间转换到裁剪空间
                OUT.positionCS = TransformObjectToHClip(IN.positionOS.xyz);
                // 直接传递UV坐标
                OUT.uv = IN.uv;
                return OUT;
            }

            //=========================================================================================
            // 片元着色器 (Fragment/Pixel Shader)
            // 功能: 执行您要求的采样、曝光和辉光叠加。
            //=========================================================================================
            float4 frag(VaryingsCus IN) : SV_Target
            {
                // 使用从顶点着色器传来的UV坐标作为基础采样坐标
                float2 baseUV = IN.uv;
                
                // 1. 采样基础颜色
                // 使用 SAMPLE_TEXTURE2D 宏和 URP 预定义的线性钳位采样器
                float3 baseColor = SAMPLE_TEXTURE2D(_BlitTexture, sampler_LinearClamp, baseUV).xyz;
                
                // 2. 采样辉光颜色
                float3 bloomColor = SAMPLE_TEXTURE2D(_BloomTexture, sampler_LinearClamp, baseUV).xyz;
                
                // 3. 应用曝光并叠加辉光
                // 将曝光值硬编码为1.3
                float eyeAdaptation = 1.3;
                float3 color_with_bloom = baseColor * eyeAdaptation + bloomColor;

                // 4. 返回最终颜色
                // 按照您的要求使用 .xyzz swizzle, Alpha通道将等于Blue通道的值
                return color_with_bloom.xyzz;
            }

            ENDHLSL
        }
    }
}