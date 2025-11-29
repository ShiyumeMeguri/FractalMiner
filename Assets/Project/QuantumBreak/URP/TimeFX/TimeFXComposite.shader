Shader "Hidden/Ruri/TimeFXComposite"
{
    Properties
    {
        _VelocityTex ("Velocity", 2D) = "black" {}
        _TimeFXTexture ("Time FX Texture", 2D) = "black" {}
        _BlitTexture ("Main Camera Color", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" "RenderPipeline" = "UniversalPipeline" }
        LOD 100
        ZTest Always ZWrite Off Cull Off

        Pass
        {
            Name "TimeFX_Composite"
            HLSLPROGRAM
            #pragma vertex Vert
            #pragma fragment Frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Common.hlsl"

            struct Attributes { uint vertexID : SV_VertexID; };
            struct Varyings { float4 positionCS : SV_POSITION; float2 uv : TEXCOORD0; };

            TEXTURE2D(_VelocityTex);    SAMPLER(sampler_VelocityTex);
            TEXTURE2D(_TimeFXTexture);  SAMPLER(sampler_TimeFXTexture); // Renamed
            TEXTURE2D(_BlitTexture);    SAMPLER(sampler_BlitTexture);

            float _SimulationTime; 
            float4 _Params; // x: Stutter, y: Aberration, z: Intensity, w: Time

            Varyings Vert(Attributes input)
            {
                Varyings output;
                output.positionCS = GetFullScreenTriangleVertexPosition(input.vertexID);
                output.uv = GetFullScreenTriangleTexCoord(input.vertexID);
                return output;
            }

            float4 Frag(Varyings input) : SV_Target
            {
                float2 uv = input.uv;

                // 1. Distortion
                float2 velocity = SAMPLE_TEXTURE2D(_VelocityTex, sampler_VelocityTex, uv).xy;
                // [Fix] Renamed sampler usage
                float fxMask = SAMPLE_TEXTURE2D(_TimeFXTexture, sampler_TimeFXTexture, uv).z; 
                
                velocity *= 25.0 * fxMask * _ScreenSize.zw; 
                velocity = clamp(velocity, -0.05, 0.05);

                float2 distortedUV = uv + velocity;

                // 2. Chromatic Aberration
                float t1 = _SimulationTime * 0.45 + 1.5;
                float t1_scaled = t1 * 3.0;
                float stutter = frac(t1_scaled) * ((t1_scaled >= -t1_scaled) ? 3.0 : -3.0);
                
                float aberrationFactor = stutter * _Params.y * 0.02;
                float2 offsetR = velocity * aberrationFactor;
                float2 offsetB = velocity * aberrationFactor * 0.5;

                half4 bgBase = SAMPLE_TEXTURE2D(_BlitTexture, sampler_BlitTexture, distortedUV);
                half4 bgR = SAMPLE_TEXTURE2D(_BlitTexture, sampler_BlitTexture, distortedUV + offsetR);
                half4 bgB = SAMPLE_TEXTURE2D(_BlitTexture, sampler_BlitTexture, distortedUV - offsetB);
                
                half3 bgCombined = half3(bgR.r, bgBase.g, bgB.b);

                // 3. FX Accumulation
                float fxAccum = 0;
                float startOffset = -_ScreenSize.w * 7.5; 
                float stepOffset = _ScreenSize.w * 3.0;
                
                [unroll]
                for(int i = 0; i < 5; i++)
                {
                    float yOff = startOffset + (float)i * stepOffset;
                    // [Fix] Renamed sampler usage
                    float intensitySamp = SAMPLE_TEXTURE2D(_TimeFXTexture, sampler_TimeFXTexture, uv + float2(0, yOff)).y;
                    fxAccum += intensitySamp;
                }
                
                float fxIntensity = fxAccum * 0.2 * _Params.z; 

                // 4. Grading
                half3 invBG = 1.0 - bgCombined;
                half3 curveParams = half3(-0.0909, 0.11, 0.20); 
                
                half3 gradedColor = saturate(invBG * curveParams + bgCombined);
                gradedColor *= 1.15;
                gradedColor = pow(max(gradedColor, 0.0001), half3(0.7735, 0.7017, 0.8147));
                gradedColor = min(gradedColor, 1.0);

                // 5. Mix
                half3 finalColor = lerp(bgCombined, gradedColor, saturate(fxIntensity));

                return float4(finalColor, 1.0);
            }
            ENDHLSL
        }
    }
}