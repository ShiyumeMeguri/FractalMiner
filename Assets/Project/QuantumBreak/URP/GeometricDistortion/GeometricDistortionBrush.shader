Shader "Ruri/Particles/GeometricDistortionBrush"
{
    Properties
    {
        _MainTex ("Distortion Shape", 2D) = "white" {}
        _Strength ("Strength", Float) = 1.0
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" "LightMode"="GeometricDistortion" }
        LOD 100
        
        // 绘制到中间缓冲，可以混合也可以直接覆盖，取决于是否允许多个笔刷重叠
        // 既然是波源，重叠应该是叠加的
        Blend One One
        ZClip Off
        ZWrite Off
        ZTest LEqual // [Fix] RenderDoc shows Depth Test is active
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
                float _Strength;
            CBUFFER_END

            Varyings Vert(Attributes input)
            {
                Varyings output;
                output.positionCS = TransformObjectToHClip(input.positionOS.xyz);
                output.uv = input.uv;
                output.color = input.color;
                return output;
            }

            float4 Frag(Varyings input) : SV_Target
            {
                float shape = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, input.uv).r;
                
                // Remap 0..1 to -1..1
                float force = shape * 2.0 - 1.0; 
                
                float finalForce = force * input.color.a * _Strength;

                return float4(finalForce, 0, 0, 1);
            }
            ENDHLSL
        }
    }
}