Shader "Ruri/Particles/TimeFX"
{
    Properties
    {
        [MainTexture] _BaseMap("g_sColorMap", 2D) = "white" {}
        [HDR] _BaseColor("Intensity Modulator", Color) = (1,1,1,1)
        
        _ExplosionIntensity ("Visual Intensity", Float) = 2.5
        _NearFadeDistance ("Near Fade Distance", Float) = 1.0
        _SoftParticleFade ("Soft Particle Fade", Float) = 1.0 
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" "RenderPipeline" = "UniversalPipeline" }

        Pass
        {
            // Pass Name 用于 UsePass 查找
            Name "TimeFX"
            Tags { "LightMode" = "TimeFX" }
            Blend One One 
            ZWrite Off ZTest LEqual Cull Off

            HLSLPROGRAM
            #pragma vertex Vert
            #pragma fragment FragData

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

            struct Attributes { float4 positionOS : POSITION; float2 uv : TEXCOORD0; float4 color : COLOR; };
            struct Varyings { float4 positionCS : SV_POSITION; float4 screenPos : TEXCOORD1; float2 uv : TEXCOORD0; float4 color : COLOR; float3 viewPos : TEXCOORD3; };

            TEXTURE2D(_BaseMap); SAMPLER(sampler_BaseMap);
            CBUFFER_START(UnityPerMaterial)
                float4 _BaseMap_ST; 
                float4 _BaseColor; 
                float _ExplosionIntensity; 
                float _NearFadeDistance; 
                float _SoftParticleFade;
            CBUFFER_END

            Varyings Vert(Attributes input) {
                Varyings output;
                VertexPositionInputs vertexInput = GetVertexPositionInputs(input.positionOS.xyz);
                output.positionCS = vertexInput.positionCS;
                output.screenPos = ComputeScreenPos(output.positionCS);
                output.uv = TRANSFORM_TEX(input.uv, _BaseMap);
                output.color = input.color;
                output.viewPos = vertexInput.positionVS; 
                return output;
            }

            float4 FragData(Varyings input) : SV_Target
            {
                float viewDepth = -input.viewPos.z; 
                
                float graphBlue = _BaseColor.b * input.color.b;
                float graphRed  = _BaseColor.r * input.color.r;
                float intensityMod = graphBlue;

                float4 scrollSpeed = float4(0.015, -0.0099, -0.0066, 0.0132);
                float4 uvOffset = scrollSpeed * _Time.y;
                
                float4 sampleUV;
                sampleUV.xy = input.uv * 0.19 + uvOffset.xy;
                sampleUV.zw = input.uv * 0.11 + uvOffset.zw;
                
                float noise1 = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, sampleUV.xy).r;
                float noise2 = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, sampleUV.zw).r;
                float noiseSum = noise1 + noise2; 

                float nearFade = saturate(viewDepth - _NearFadeDistance);

                float2 screenUV = input.screenPos.xy / input.screenPos.w;
                float sceneDepth = LinearEyeDepth(SampleSceneDepth(screenUV), _ZBufferParams);
                float softFade = saturate((sceneDepth - viewDepth) * _SoftParticleFade);

                float2 fadeFactors = nearFade.xx * softFade;
                fadeFactors.y *= noiseSum; 
                fadeFactors *= graphRed;

                float2 finalIntensity = intensityMod * fadeFactors;
                float proximityScale = _ExplosionIntensity * rcp(max(viewDepth, 0.001));

                float2 outputXY = proximityScale * finalIntensity;
                float outputZ = viewDepth * 0.00392157;

                return float4(outputXY.x, outputXY.y, outputZ, 0);
            }
            ENDHLSL
        }
    }
}