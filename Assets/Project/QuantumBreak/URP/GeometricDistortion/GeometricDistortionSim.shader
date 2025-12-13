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

            // 对应 RenderDoc Buffer 81402 (Scene Pass) 或 90537 (Context)
            // x: DecayFactor (RenderDoc ~1.5) 
            // y: Clamping (RenderDoc ~6.0)
            // z: RippleTimeDelta (RenderDoc ~0.033)
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
            // 逻辑: Wave Equation 求解 u_{t+1}
            float Frag(Varyings input) : SV_Target
            {
                float2 uv = input.uv;
                float2 texelSize = _SimulationTexelSize.xy;

                // --- 1. Laplacian (Line 0-10) ---
                // 采样中心点
                float center = SAMPLE_TEXTURE2D(_WavePreFrame, sampler_WavePreFrame, uv).r;
                
                // 采样四周邻居
                float3 off = float3(texelSize.xy, 0);
                float accum = SAMPLE_TEXTURE2D(_WavePreFrame, sampler_WavePreFrame, uv - off.zy).r; // Top
                accum += SAMPLE_TEXTURE2D(_WavePreFrame, sampler_WavePreFrame, uv + off.zy).r;      // Bottom
                accum += SAMPLE_TEXTURE2D(_WavePreFrame, sampler_WavePreFrame, uv - off.xz).r;      // Left
                accum += SAMPLE_TEXTURE2D(_WavePreFrame, sampler_WavePreFrame, uv + off.xz).r;      // Right

                // line 10: mad r0.x, -r0.y, l(4.000000), r0.x
                // Laplacian = Sum(Neighbors) - 4 * Center
                float laplacian = accum - 4.0 * center;

                // --- 2. Wave Propagation (Line 11-18) ---
                float dt = cubeData.z;
                float decay = cubeData.x;
                float clamping = cubeData.y;

                // line 11-12: term1 = Laplacian * dt^2
                float term1 = laplacian * (dt * dt);

                // line 13: sample SuperPreFrame (u_{t-1})
                float superPrev = SAMPLE_TEXTURE2D(_WaveSuperPreFrame, sampler_WaveSuperPreFrame, uv).r;

                // line 14: mad r0.w, dt, decay, l(-1.000000)
                // weight1 = dt * decay - 1.0
                float weight1 = dt * decay - 1.0;

                // line 15: term2 = SuperPrev * weight1
                float term2 = superPrev * weight1;

                // line 16: mad r0.w, -dt, decay, l(2.000000)
                // weight2 = 2.0 - dt * decay
                float weight2 = 2.0 - (dt * decay);

                // line 17: term3 = Center * weight2 + term2
                float term3 = center * weight2 + term2;

                // line 18: mad r0.x, r0.x, l(400.000000), r0.y
                // u_{t+1} = term1 * 400.0 + term3
                // 400.0 是波速平方系数 (c^2)
                float result = term1 * 400.0 + term3;

                // --- 3. Damping (Line 19-21) ---
                // line 19-20: damping = exp(dt * -0.043943)
                float damping = exp(dt * -0.043943);
                
                // line 21: result *= damping
                result *= damping;

                // --- 4. Clamping (Line 22-23) ---
                result = clamp(result, -clamping, clamping);

                // [Fix] 防止浮点数下溢 (Denormal Flush)
                if (abs(result) < 1e-5) result = 0;

                return result;
            }
            ENDHLSL
        }
    }
}