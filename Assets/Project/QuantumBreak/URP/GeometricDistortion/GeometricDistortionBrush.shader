Shader "Ruri/Particles/GeometricDistortionBrush"
{
    Properties
    {
        _MainTex ("Distortion Shape", 2D) = "white" {}
        _DistortionScale ("Distortion Scale", Float) = 1.0
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" "LightMode"="GeometricDistortion" }
        LOD 100
        
        // 叠加模式：累积力场
        Blend One One
        ZClip Off
        ZWrite Off
        ZTest Always // 忽略深度，确保波源即使在物体内部也能产生效果
        Cull Off

        Pass
        {
            HLSLPROGRAM
            #pragma vertex Vert
            #pragma fragment Frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            struct Attributes
            {
                float4 positionOS : POSITION;
                float4 color : COLOR;
                float2 uv : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float4 color : COLOR;
                float2 uv : TEXCOORD0;
            };

            TEXTURE2D(_MainTex);
            SAMPLER(sampler_MainTex);
            
            CBUFFER_START(UnityPerMaterial)
                float _DistortionScale;
            CBUFFER_END

            Varyings Vert(Attributes input)
            {
                Varyings output;
                output.positionCS = TransformObjectToHClip(input.positionOS.xyz);
                output.uv = input.uv;
                output.color = input.color;
                return output;
            }

            // 还原自 Shader ID 601 (Pixel Shader)
            /*
                0: sample_indexable(texture2d) r0.x, v1.xyxx ...
                1: mad r0.x, r0.x, l(2.000000), l(-1.035294)
                2: mul r0.y, g_fDistortionScale.x, l(0.100000)
                3: mul o0.xyz, r0.xxxx, r0.yyyy
            */
            float4 Frag(Varyings input) : SV_Target
            {
                float shape = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, input.uv).r;
                
                // [Quantum Break Logic]
                // 映射 [0, 1] -> [-1.035, 0.965]
                // 这种非对称映射（略微偏负）是让黑色背景产生下压力(Dip)的关键
                float force = shape * 2.0 - 1.035294;
                
                // 原版还有一个 0.1 的系数，这里我们也乘上，或者让用户通过 _DistortionScale 控制
                // input.color.a 用来控制粒子生命周期的淡入淡出
                float finalForce = force * (_DistortionScale * 0.1) * input.color.a;

                // 输出到 R 通道 (需要 RFloat 格式 RT)
                return float4(finalForce, 0, 0, 1);
            }
            ENDHLSL
        }
    }
}