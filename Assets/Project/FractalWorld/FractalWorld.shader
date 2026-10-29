Shader "Ruri/Fractal/FractalWorld" {
    Properties {
        [Header(Global Settings)]
        _FractalOffset ("Fractal Offset", Vector) = (0,0,0,0)
        _RaymarchingMinDist ("Raymarching Min Distance", Float) = 0.00035
        _RaymarchingMaxDist ("Raymarching Max Distance", Float) = 5.0

        [Header(Raymarching)]
        _MaxSteps ("Max Steps", Range(16, 1024)) = 384
        _StartStep ("Start Step", Float) = 0.015
        _PixelAngle ("Pixel Angle", Float) = 0.002
        _EpsilonScale ("Hit Tolerance Scale", Float) = 1.0
        _MinimumStepScale ("Minimum Step Scale", Float) = 0.25
        _SafetyFactor ("Step Safety Factor", Float) = 1.0
        _NormalScale ("Normal Epsilon Scale", Float) = 1.0
        _GlowScale ("Glow Scale", Float) = 0.866
        _GlowExponent ("Glow Exponent", Float) = 0.58

        [Header(Animation)]
        _FractalAnimationTime ("Fractal Animation Time", Float) = 18.7
        _ColorAnimationTime ("Color Animation Time", Float) = 18.7

        [Header(Mandelbrot Fractal)]
        _MandelbrotPower ("Power (Real, Imag)", Vector) = (2,0,0,0)
        _MandelbrotIterations ("Iterations", Range(1, 100)) = 10
        _MandelbrotCenterX ("Center X", Float) = 0.0
        _MandelbrotCenterY ("Center Y", Float) = 0.0
        _MandelbrotScale ("Scale", Float) = 1.0
        _MandelbrotCX ("CX", Float) = -0.8
        _MandelbrotCY ("CY", Float) = 0.156
        [Toggle] _MandelbrotUseJulia ("Enable Julia", Float) = 0.0
        [Toggle] _MandelbrotReverse ("Enable Reverse", Float) = 0.0

        [Header(Kleinian Fractal)]
        _KleinianIterations ("Iterations", Range(1, 100)) = 10

        [Header(RenderState)]
        _DepthOffsetFactor ("Depth Offset Factor", Range(-1, 1)) = 0
        _DepthOffsetUnits ("Depth Offset Units", Range(-1, 1)) = 0
        [Enum(UnityEngine.Rendering.BlendOp)] _BlendOp ("Blend Operation", Int) = 0
        [Enum(UnityEngine.Rendering.BlendMode)] _SrcAlpha ("Source Alpha Blend Mode", Int) = 1
        [Enum(UnityEngine.Rendering.BlendMode)] _DstAlpha ("Destination Alpha Blend Mode", Int) = 0
        [Enum(UnityEngine.Rendering.CullMode)] _Cull ("Cull Mode", Int) = 0
        [Enum(UnityEngine.Rendering.CompareFunction)] _ZTest ("Depth Test Function", Int) = 4
        [Enum(Off, 0, On, 1)] _ZWrite ("Depth Write", Int) = 1
    }
    SubShader {
        Tags {
            "Queue" = "Geometry+100"
            "RenderType" = "Opaque"
            "RenderPipeline" = "UniversalPipeline"
            "UniversalMaterialType" = "Unlit"
        }
        Pass {
            Name "FractalWorld"
            BlendOp [_BlendOp]
            Blend [_SrcAlpha] [_DstAlpha]
            Cull [_Cull]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Offset [_DepthOffsetFactor], [_DepthOffsetUnits]

            HLSLPROGRAM
            #pragma target 3.5
            #pragma vertex vert
            #pragma fragment frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            struct VertexInput
            {
                float4 positionOS : POSITION;
            };

            struct VertexOutput
            {
                float4 position : SV_POSITION;
                float3 worldPosition : TEXCOORD0;
            };

            struct FragmentOutput
            {
                float4 color : SV_Target;
                float depth : SV_Depth;
            };

            struct FractalSample
            {
                float field;
                float stepBound;
                float magnitude;
            };

            CBUFFER_START(UnityPerMaterial)
                float4 _FractalOffset;
                float _RaymarchingMinDist;
                float _RaymarchingMaxDist;
                float _MaxSteps;
                float _StartStep;
                float _PixelAngle;
                float _EpsilonScale;
                float _MinimumStepScale;
                float _SafetyFactor;
                float _NormalScale;
                float _GlowScale;
                float _GlowExponent;
                float _FractalAnimationTime;
                float _ColorAnimationTime;
                float4 _MandelbrotPower;
                float _MandelbrotIterations;
                float _MandelbrotCenterX;
                float _MandelbrotCenterY;
                float _MandelbrotScale;
                float _MandelbrotCX;
                float _MandelbrotCY;
                float _MandelbrotUseJulia;
                float _MandelbrotReverse;
                float _KleinianIterations;
            CBUFFER_END

            VertexOutput vert(VertexInput input)
            {
                VertexOutput output;
                float3 worldPosition = TransformObjectToWorld(input.positionOS.xyz);
                output.position = TransformWorldToHClip(worldPosition);
                output.worldPosition = worldPosition;
                return output;
            }

            float2 ComplexPower(float2 value, float2 power)
            {
                if (value.x == 0.0 && value.y == 0.0)
                {
                    return float2(0.0, 0.0);
                }
                float logRadius = 0.5 * log(dot(value, value));
                float theta = atan2(value.y, value.x);
                float realPart = power.x * logRadius - power.y * theta;
                float imaginaryPart = power.x * theta + power.y * logRadius;
                float radius = exp(realPart);
                return float2(radius * cos(imaginaryPart), radius * sin(imaginaryPart));
            }

            void MandelbrotAnalysis(float2 coordinate, out float2 finalValue, out float derivative, out float seam)
            {
                float2 power = _MandelbrotPower.xy;
                float powerLength = length(power);
                bool isSquare = power.x == 2.0 && power.y == 0.0;
                bool useJulia = _MandelbrotUseJulia > 0.5;
                float2 addend = useJulia ? float2(_MandelbrotCX, _MandelbrotCY) : coordinate;
                float2 value = useJulia ? coordinate : float2(0.0, 0.0);
                int iterations = (int)_MandelbrotIterations;
                bool alive = true;
                derivative = 1.0;
                seam = 3.0e38;
                [loop]
                for (int index = 0; index < iterations; index++)
                {
                    float squared = dot(value, value);
                    float magnitude = sqrt(squared);
                    if (squared > 4.0)
                    {
                        seam = min(seam, (magnitude - 2.0) / derivative);
                        alive = false;
                        break;
                    }
                    seam = min(seam, (2.0 - magnitude) / derivative);
                    float2 raised;
                    float growth;
                    if (isSquare)
                    {
                        raised = float2(value.x * value.x - value.y * value.y, 2.0 * value.x * value.y);
                        growth = magnitude;
                    }
                    else
                    {
                        raised = ComplexPower(value, power);
                        growth = pow(squared, (power.x - 1.0) * 0.5);
                    }
                    derivative = powerLength * growth * derivative + 1.0;
                    value = raised + addend;
                }
                if (alive)
                {
                    seam = min(seam, (2.0 - length(value)) / derivative);
                }
                finalValue = value;
            }

            float KleinianDistance(float3 position, float4 minParams, float4 maxParams)
            {
                float scale = 1.0;
                float3 folded = position;
                int iterations = (int)_KleinianIterations;
                [loop]
                for (int index = 0; index < iterations; index++)
                {
                    float3 lowerBound = max(minParams.xyz, folded);
                    float3 clamped = min(maxParams.xyz, lowerBound);
                    folded = 2.0 * clamped - folded;
                    float inversion = max(minParams.w / dot(folded, folded), 1.0);
                    folded *= inversion;
                    scale *= inversion;
                }
                float viewLength = length(folded.xy);
                float positionLength = length(folded);
                float viewHitDistance = viewLength - maxParams.w;
                float worldHitDistance = folded.z * viewLength;
                return max(worldHitDistance / positionLength, viewHitDistance) / scale;
            }

            FractalSample SampleFractal(float3 position, float4 minParams, float4 maxParams)
            {
                float3 fractalPosition = float3(position.x, -position.z, position.y);
                float2 coordinate = (fractalPosition.xy - float2(_MandelbrotCenterX, _MandelbrotCenterY)) / _MandelbrotScale;
                float coordinateDerivative = 1.0 / _MandelbrotScale;
                if (_MandelbrotReverse > 0.5)
                {
                    float denominator = dot(coordinate, coordinate);
                    if (denominator > 1e-9)
                    {
                        coordinate /= denominator;
                        coordinateDerivative /= denominator;
                    }
                }
                float2 finalValue;
                float derivative;
                float seam;
                MandelbrotAnalysis(coordinate, finalValue, derivative, seam);
                float magnitude = length(finalValue);
                FractalSample result;
                result.magnitude = magnitude;
                result.field = KleinianDistance(fractalPosition * magnitude, minParams, maxParams);
                float lipschitz = (magnitude + length(position) * derivative * coordinateDerivative) * _SafetyFactor;
                float surface = result.field / lipschitz;
                result.stepBound = result.field < 0.0 ? surface : min(surface, seam / coordinateDerivative);
                return result;
            }

            float3 CalcNormal(float3 position, float stepLength, float4 minParams, float4 maxParams)
            {
                float epsilon = 0.0005 * stepLength * 0.57;
                if (_NormalScale > 0.0)
                {
                    epsilon = max(epsilon, stepLength * _PixelAngle * _NormalScale);
                }
                float3 offset = epsilon * float3(1, -1, 0);
                return normalize(
                    offset.xyy * SampleFractal(position + offset.xyy, minParams, maxParams).field +
                    offset.yyx * SampleFractal(position + offset.yyx, minParams, maxParams).field +
                    offset.yxy * SampleFractal(position + offset.yxy, minParams, maxParams).field +
                    offset.xxx * SampleFractal(position + offset.xxx, minParams, maxParams).field
                );
            }

            void CalcAnimation(float fractalAnimationTime, out float4 minParams, out float4 maxParams)
            {
                float4 minsAnimation[12];
                float4 maxsAnimation[12];
                minsAnimation[0]  = float4(-0.3252, -0.7862, -0.0948,  0.678);
                minsAnimation[1]  = float4(-1.05,   -1.05,   -0.0001,  0.7);
                minsAnimation[2]  = float4(-1.21,   -0.954,  -0.0001,  1.684);
                minsAnimation[3]  = float4(-1.22,   -1.17,   -0.032,   1.49);
                minsAnimation[4]  = float4(-1.04,   -0.79,   -0.126,   0.833);
                minsAnimation[5]  = float4(-0.737,  -0.73,   -1.23,    0.627);
                minsAnimation[6]  = float4(-10.0,   -0.75,   -0.787,   0.826);
                minsAnimation[7]  = float4(-1.653,  -0.2,    -0.822,   0.8976);
                minsAnimation[8]  = float4(-0.653,  -1.0,    -1.073,   0.89);
                minsAnimation[9]  = float4(-1.0,    -1.75,   -10.787,  0.826);
                minsAnimation[10] = float4(-1.05,   -1.05,   -10.0001, 0.93);
                minsAnimation[11] = float4(-0.5,    -0.62,   -1.0,     0.88);

                maxsAnimation[0]  = float4( 0.3457,  1.0218,  1.2215,   0.9);
                maxsAnimation[1]  = float4( 1.05,    1.05,    1.27,     0.95);
                maxsAnimation[2]  = float4( 0.39,    0.65,    1.27,     2.74);
                maxsAnimation[3]  = float4( 0.85,    0.65,    1.27,     1.23);
                maxsAnimation[4]  = float4( 0.3457,  1.0218,  1.2215,   0.9834);
                maxsAnimation[5]  = float4( 0.73,    0.73,    0.73,     0.8335);
                maxsAnimation[6]  = float4( 5.0,     1.67,    0.775,    1.172);
                maxsAnimation[7]  = float4( 0.888,   0.1665,  1.2676,   0.7798);
                maxsAnimation[8]  = float4( 0.735,   0.2,     0.72,     0.94);
                maxsAnimation[9]  = float4( 5.0,     1.67,    0.775,    1.172);
                maxsAnimation[10] = float4( 1.05,    1.05,    0.84,     0.93);
                maxsAnimation[11] = float4( 0.06,    1.0,     0.84,     1.0);

                float fractalMoveTime = fractalAnimationTime * 0.01;
                float curFractalMoveTime = frac(fractalMoveTime);
                float scaledMoveTime = curFractalMoveTime * -2.0 + 3.0;
                float quadraticMoveTime = curFractalMoveTime * curFractalMoveTime;
                float minsFactor = quadraticMoveTime * scaledMoveTime;
                float maxsFactor = quadraticMoveTime * -scaledMoveTime + 1.0;
                bool isTransition = minsFactor < 0.5;
                float transitionFactor = isTransition ? minsFactor : maxsFactor;
                transitionFactor = pow(transitionFactor * 2.0, 32.0);
                float halfTransitionFactor = transitionFactor * 0.5;
                transitionFactor = 0.5 * -transitionFactor + 1.0;
                float finalTransitionFactor = isTransition ? halfTransitionFactor : transitionFactor;
                uint loopCounter = uint(fractalMoveTime);
                uint prevLoopCounter = loopCounter % 10u;
                uint nextloopCounter = (loopCounter + 1u) % 10u;
                float4 minsStart = minsAnimation[int(prevLoopCounter)];
                float4 minsEnd = minsAnimation[int(nextloopCounter)];
                float4 minsDifference = minsEnd - minsStart;
                minParams = finalTransitionFactor * minsDifference + minsStart;
                float4 maxsStart = maxsAnimation[int(prevLoopCounter)];
                float4 maxsEnd = maxsAnimation[int(nextloopCounter)];
                float4 maxsDifference = maxsEnd - maxsStart;
                maxParams = finalTransitionFactor * maxsDifference + maxsStart;
            }

            float3 CalcColor(float stepLength, float fractalDistance, float diffuseFactor)
            {
                float3 glowTransitionTime = _ColorAnimationTime * float3(0.714285731, 0.053475935, 0.0515463911);
                float glowColor1 = stepLength * 8.0 + glowTransitionTime.x;
                glowColor1 = sin(glowColor1) * 0.0625 + stepLength;
                glowColor1 *= fractalDistance * 0.0263157897;
                glowColor1 *= 0.75;
                float glowColor2 = saturate(glowColor1 / stepLength);
                float glowColor3 = glowColor2 * glowColor2;
                float2 baseGlowColor = sin(glowTransitionTime.yz) * 0.1 + 0.8;
                float4 fractalGlowColor1 = float4(1.0, glowColor2, glowColor3, glowColor2 * glowColor3);
                float2 fractalGlowColorMix = fractalGlowColor1.yw * fractalGlowColor1.wy * fractalGlowColor1.xy;
                float3 baseFractalColors1;
                fractalGlowColor1.x = -0.0232269596;
                baseFractalColors1.x = dot(float4(1.0, 1.08715439, -0.109964743, 6.33366585), fractalGlowColor1);
                baseFractalColors1.x += dot(fractalGlowColorMix.xy, float2(-11.6405964, 5.3376255));
                fractalGlowColor1.x = 0.0106809931;
                baseFractalColors1.y = dot(float4(1.0, 0.176613778, 1.63822746, -6.74352217), fractalGlowColor1);
                baseFractalColors1.y += dot(fractalGlowColorMix.xy, float2(11.4263973, -5.52323627));
                fractalGlowColor1.x = -0.00826078188;
                baseFractalColors1.z = dot(float4(1.0, 2.24428606, 3.00558758, -24.2797699), fractalGlowColor1);
                baseFractalColors1.z += dot(fractalGlowColorMix.xy, float2(32.4843102, -12.6882601));
                baseFractalColors1 = baseGlowColor.xxx - baseFractalColors1 * diffuseFactor;
                float3 baseFractalColors2;
                fractalGlowColor1.x = 0.280268013;
                baseFractalColors2.x = dot(float4(1.0, -0.143510506, 2.22579384, -14.8150892), fractalGlowColor1);
                baseFractalColors2.x += dot(fractalGlowColorMix.xy, float2(25.2127514, -11.7725897));
                fractalGlowColor1.x = -0.00211754604;
                baseFractalColors2.y = dot(float4(1.0, 1.6171093, -1.9093051, 2.7011528), fractalGlowColor1);
                baseFractalColors2.y += dot(fractalGlowColorMix.xy, float2(-1.68528843, 0.178738877));
                fractalGlowColor1.x = 0.300805509;
                baseFractalColors2.z = dot(float4(1.0, 2.61465025, -12.0191393, 28.9335594), fractalGlowColor1);
                baseFractalColors2.z += dot(fractalGlowColorMix.xy, float2(-33.4912949, 13.7620535));
                baseFractalColors2 = baseGlowColor.yyy - baseFractalColors2 * diffuseFactor;
                float adjustedColorTime = sin(_ColorAnimationTime * 0.0558659248);
                float colorIntensityFactor = 0.4 * -stepLength + 1.1;
                float3 colorMix = baseFractalColors2 - baseFractalColors1;
                colorMix = adjustedColorTime * colorMix + baseFractalColors1;
                colorMix = colorIntensityFactor * colorMix + float3(0.0, 0.05, 0.0);
                return saturate(0.7 - colorMix);
            }

            FragmentOutput frag(VertexOutput input)
            {
                FragmentOutput output;

                float4 minParams, maxParams;
                CalcAnimation(_FractalAnimationTime, minParams, maxParams);

                float3 cameraPosition = TransformWorldToObject(_WorldSpaceCameraPos);
                float3 rayOrigin = cameraPosition + _FractalOffset.xyz;
                float3 rayDirection = normalize(mul((float3x3)GetWorldToObjectMatrix(), normalize(input.worldPosition - _WorldSpaceCameraPos)));

                float stepLength = _StartStep;
                float stepCount = 0.0;
                float3 fractalPosition = rayOrigin + rayDirection * stepLength;
                int maxSteps = (int)_MaxSteps;
                [loop]
                for (int index = 0; index < maxSteps; index++)
                {
                    fractalPosition = rayOrigin + rayDirection * stepLength;
                    float footprint = stepLength * _PixelAngle;
                    FractalSample fractalSample = SampleFractal(fractalPosition, minParams, maxParams);
                    float threshold = _RaymarchingMinDist + footprint * fractalSample.magnitude * _EpsilonScale;
                    if (fractalSample.field < threshold || stepLength >= _RaymarchingMaxDist)
                    {
                        break;
                    }
                    stepCount += 1.0;
                    stepLength += max(fractalSample.stepBound, footprint * _MinimumStepScale);
                }

                float3 normalFactor = CalcNormal(fractalPosition, stepLength, minParams, maxParams);
                float diffuseFactor = 0.5 * dot(normalFactor, normalize(_MainLightPosition.xyz)) + 0.5;
                float glow = min(_GlowScale * pow(stepCount, _GlowExponent), 40.0);

                output.color = float4(CalcColor(stepLength, glow, diffuseFactor), 1.0);

                float4 clipPosition = TransformWorldToHClip(TransformObjectToWorld(fractalPosition - _FractalOffset.xyz));
                output.depth = clipPosition.z / clipPosition.w;
                return output;
            }
            ENDHLSL
        }
    }
}
