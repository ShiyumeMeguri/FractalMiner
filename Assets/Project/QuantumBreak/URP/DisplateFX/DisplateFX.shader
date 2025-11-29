Shader "Ruri/Particles/DisplateFX"
{
    Properties
    {
        [MainTexture] _BaseMap("g_sColorMap", 2D) = "white" {}
        [HDR] _BaseColor("Intensity Modulator", Color) = (1,1,1,1)
        _DistortionIntensity ("Distortion Intensity", Float) = 2.0
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" "RenderPipeline" = "UniversalPipeline" }

        Pass
        {
            // Pass Name 用于 UsePass 查找
            Name "DisplateFX"
            Tags { "LightMode" = "DisplateComposite" }
            Blend One One 
            ZWrite Off ZTest LEqual Cull Off

            HLSLPROGRAM
            #pragma vertex Vert
            #pragma fragment FragDistort
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            struct Attributes { float4 positionOS : POSITION; float2 uv : TEXCOORD0; float4 color : COLOR; };
            struct Varyings { float4 positionCS : SV_POSITION; float2 uv : TEXCOORD0; float4 color : COLOR; };

            TEXTURE2D(_BaseMap); SAMPLER(sampler_BaseMap);
            CBUFFER_START(UnityPerMaterial)
                float4 _BaseMap_ST; 
                float4 _BaseColor; 
                float _DistortionIntensity;
            CBUFFER_END

            Varyings Vert(Attributes input) {
                Varyings output;
                VertexPositionInputs vertexInput = GetVertexPositionInputs(input.positionOS.xyz);
                output.positionCS = vertexInput.positionCS;
                output.uv = TRANSFORM_TEX(input.uv, _BaseMap);
                output.color = input.color;
                return output;
            }

            float4 FragDistort(Varyings input) : SV_Target {
                float2 timeOffset = _Time.y * float2(0.1, 0.2);
                float noise = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, input.uv + timeOffset).r;
                return float4((noise * 2.0 - 1.0).xx * _DistortionIntensity * input.color.a, 0, 1); 
            }
            ENDHLSL
        }
    }
}