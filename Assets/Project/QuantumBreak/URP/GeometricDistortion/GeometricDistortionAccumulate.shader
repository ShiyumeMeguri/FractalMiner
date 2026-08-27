Shader "Hidden/Ruri/GeometricDistortionAccumulate"
{
    Properties
    {
        _DistortionInput ("Input", 2D) = "black" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" "RenderPipeline" = "UniversalPipeline" }
        LOD 100
        ZTest Always ZWrite Off Cull Off
        Blend One One // Additive blend to History

        Pass
        {
            Name "Accumulate"
            HLSLPROGRAM
            #pragma vertex Vert
            #pragma fragment Frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            // 引入 Common.hlsl 以使用 GetFullScreenTriangleVertexPosition
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Common.hlsl" 

            struct Attributes
            {
                uint vertexID : SV_VertexID;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            TEXTURE2D(_DistortionInput);
            SAMPLER(sampler_DistortionInput);

            Varyings Vert(Attributes input)
            {
                Varyings output;
                // 使用程序化全屏三角形生成坐标，修复输入顶点为 000 的问题
                output.positionCS = GetFullScreenTriangleVertexPosition(input.vertexID);
                output.uv = GetFullScreenTriangleTexCoord(input.vertexID);
                return output;
            }

            float4 Frag(Varyings input) : SV_Target
            {
                float force = SAMPLE_TEXTURE2D(_DistortionInput, sampler_DistortionInput, input.uv).r;
                return float4(force, 0, 0, 0);
            }
            ENDHLSL
        }
    }
}