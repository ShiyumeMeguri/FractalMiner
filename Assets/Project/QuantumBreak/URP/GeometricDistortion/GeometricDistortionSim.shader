Shader "Hidden/Ruri/GeometricDistortionSim"
{
    Properties
    {
        _WavePreFrame ("Pre Frame", 2D) = "black" {}
        _WaveSuperPreFrame ("Super Pre Frame", 2D) = "black" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" "RenderPipeline" = "UniversalPipeline" }
        LOD 100
        ZTest Always ZWrite Off Cull Off

        Pass
        {
            Name "GeometricDistortionSimulation"
            HLSLPROGRAM
            #pragma vertex Vert
            #pragma fragment Frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
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

            TEXTURE2D(_WavePreFrame);
            SAMPLER(sampler_WavePreFrame); 
            
            TEXTURE2D(_WaveSuperPreFrame);
            SAMPLER(sampler_WaveSuperPreFrame);

            // 对应 RenderDoc Buffer ID 90537
            // x: DecayFactor (RenderDoc ~1.5) 
            // y: Clamping (RenderDoc ~6.0)
            // z: RippleTimeDelta (关键！RenderDoc ~0.033)
            // w: Unused
            float4 cubeData;
            
            float4 _SimulationTexelSize;

            Varyings Vert(Attributes input)
            {
                Varyings output;
                output.positionCS = GetFullScreenTriangleVertexPosition(input.vertexID);
                output.uv = GetFullScreenTriangleTexCoord(input.vertexID);
                return output;
            }

            // [Strict Port] 严格复刻 Shader ID 603
            float Frag(Varyings input) : SV_Target
            {
                float2 uv = input.uv;
                float2 texelSize = _SimulationTexelSize.xy;

                // --- Sampling (Lines 0-9) ---
                float3 off = float3(texelSize.xy, 0);
                float center = SAMPLE_TEXTURE2D(_WavePreFrame, sampler_WavePreFrame, uv).r;
                
                // r0.x 累加邻居
                float accum = SAMPLE_TEXTURE2D(_WavePreFrame, sampler_WavePreFrame, uv - off.zy).r; // Top
                accum += SAMPLE_TEXTURE2D(_WavePreFrame, sampler_WavePreFrame, uv + off.zy).r;      // Bottom
                accum += SAMPLE_TEXTURE2D(_WavePreFrame, sampler_WavePreFrame, uv - off.xz).r;      // Left
                accum += SAMPLE_TEXTURE2D(_WavePreFrame, sampler_WavePreFrame, uv + off.xz).r;      // Right

                // 10: mad r0.x, -r0.y, l(4.000000), r0.x
                // Laplacian = Neighbors - 4 * Center
                float laplacian = accum - 4.0 * center;

                // 11: mul r0.z, g_fRippleTimeDelta.x, g_fRippleTimeDelta.x
                // 12: mul r0.x, r0.x, r0.z
                // term1 = Laplacian * dt^2
                float dt = cubeData.z;
                float term1 = laplacian * (dt * dt);

                // 13: sample SuperPreFrame -> r0.z
                float superPrev = SAMPLE_TEXTURE2D(_WaveSuperPreFrame, sampler_WaveSuperPreFrame, uv).r;

                // 14: mad r0.w, g_fRippleTimeDelta.x, g_fDecayFactor.x, l(-1.000000)
                // weight1 = dt * decay - 1.0
                float decay = cubeData.x;
                float weight1 = dt * decay - 1.0;

                // 15: mul r0.z, r0.z, r0.w
                // term2 = SuperPrev * weight1
                float term2 = superPrev * weight1;

                // 16: mad r0.w, -g_fRippleTimeDelta.x, g_fDecayFactor.x, l(2.000000)
                // weight2 = 2.0 - dt * decay
                float weight2 = 2.0 - (dt * decay);

                // 17: mad r0.y, r0.w, r0.y, r0.z
                // term3 = Center * weight2 + term2
                float term3 = center * weight2 + term2;

                // 18: mad r0.x, r0.x, l(400.000000), r0.y
                // Result = term1 * 400.0 + term3
                // 这里的 400.0 是原版硬编码的波速平方系数
                float result = term1 * 400.0 + term3;

                // 19: mul r0.y, g_fRippleTimeDelta.x, l(-0.043943)
                // 20: exp r0.y, r0.y
                // 21: mul r0.x, r0.y, r0.x
                // Apply Global Exponential Decay
                float globalDecay = exp(dt * -0.043943);
                result *= globalDecay;

                // 22: max r0.x, r0.x, -g_fClamping.x
                // 23: min o0.x, r0.x, g_fClamping.x
                float clamping = cubeData.y;
                result = clamp(result, -clamping, clamping);

                // [Safety] 浮点数精度截断（非原版，但对 Unity 这种非定点数环境是必须的）
                // 防止极小数值在 float 精度边缘震荡（Denormal numbers issue）
                if (abs(result) < 0.0001) result = 0;

                return result;
            }
            ENDHLSL
        }
    }
}