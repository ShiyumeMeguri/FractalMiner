// Simplified HGRP CharacterNPR OverlayShadow -- ForwardLitOnly (eye white shadow).
// Based on: HGRP_CharacterNPR_OverlayShadow_30f21cbd.shader
//
// Multiplicative shadow overlay that darkens the framebuffer under the mesh.
// Used for the shadow cast by the upper eyelid onto the eye white area.
//
// Kept: Base texture sampling, _UseGrayAsAlpha, _BaseColor tint, multiplicative blending,
//   _ShadowAngleRange (view-space X offset by light direction).
// Removed: GPU skinning, instancing, TAA jitter, punctual light shadow loop,
//   fog (atmosphere + exponential + volumetric), VFX color adjustment, depth-only prepass.
//
// Sandbox fix: Stencil prevents overlapping OverlayShadow meshes from double-darkening.
// Original HGRP used a separate PreDepth pass (all PreDepth first, then all OverlayShadow)
// to achieve the same result via depth test. In URP single-pass, stencil is used instead.
//
// With _UseGrayAsAlpha=1: R channel becomes shadow mask, RGB → 1.0.
// Blend Zero SrcColor: framebuffer.rgb *= lerp(1, _BaseColor.rgb, texR * _BaseColor.a^2)
//
// URP built-ins used: GetVertexPositionInputs(), GetMainLight()

Shader "HGRP/CharacterNPR_OverlayShadow_Fix" {
    Properties {
        _BaseColor ("Color", Color) = (0.35, 0.33016667, 0.32025, 1)
        _BaseMap ("Base Map", 2D) = "white" {}
        [ToggleUI] _UseGrayAsAlpha ("Use Gray As Alpha", Float) = 1
        _ShadowAngleRange ("Shadow Angle Range", Range(-0.01, 0.01)) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
    }
    SubShader {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Transparent" "Queue"="Transparent-100" }
        LOD 200

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _BaseColor;
                float4 _BaseMap_ST;
                float _UseGrayAsAlpha;
                float _ShadowAngleRange;
            CBUFFER_END

            TEXTURE2D(_BaseMap); SAMPLER(sampler_BaseMap);
        ENDHLSL

        Pass {
            Name "OverlayShadow"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend Zero SrcColor, One One
            ZWrite Off
            ZTest LEqual
            Cull Back
            Stencil {
                Ref 1
                ReadMask 1
                WriteMask 1
                Comp NotEqual
                Pass Replace
            }

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature DISABLE_DRAW_UNDER_HAIR

            struct Attributes {
                float3 positionOS : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct Varyings {
                float4 positionCS : SV_Position;
                float2 uv : TEXCOORD0;
            };

            Varyings vert(Attributes input) {
                Varyings o = (Varyings)0;
                VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);

                // Shadow angle range: offset view-space X by light direction.
                // Decompiled (line 292/615): mad(-_DirectionalLightDirection.x, _ShadowAngleRange, viewX)
                // HGRP _DirectionalLightDirection = toward surface = -URP direction
                // So: viewX += URP_mainLightDir.x * _ShadowAngleRange
                float3 viewPos = mul(UNITY_MATRIX_V, float4(posIn.positionWS, 1.0)).xyz;
                Light mainLight = GetMainLight();
                viewPos.x += mainLight.direction.x * _ShadowAngleRange;
                o.positionCS = mul(UNITY_MATRIX_P, float4(viewPos, 1.0));

                o.uv = input.uv * _BaseMap_ST.xy + _BaseMap_ST.zw;
                return o;
            }

            float4 frag(Varyings input) : SV_Target {
                // Sample base map (decompiled line 704)
                float4 tex = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, input.uv);

                // _UseGrayAsAlpha: RGB channels lerp toward 1.0, Alpha lerps toward R channel.
                // Decompiled lines 710-712: mad(_UseGrayAsAlpha, -channel + 1, channel)
                float3 rgb;
                rgb.r = lerp(tex.r, 1.0, _UseGrayAsAlpha);
                rgb.g = lerp(tex.g, 1.0, _UseGrayAsAlpha);
                rgb.b = lerp(tex.b, 1.0, _UseGrayAsAlpha);
                // Decompiled line 909: mad(_UseGrayAsAlpha, -tex.a + tex.r, tex.a)
                float alpha = lerp(tex.a, tex.r, _UseGrayAsAlpha);

                // Shadow alpha (decompiled line 909, no punctual lights so _165=0)
                // _174 = (1 - 0) * alpha * _BaseColor.a
                float shadowAlpha = alpha * _BaseColor.a;

                // No fog: _350 = shadowAlpha

                // VFX color adjustment off (decompiled line 999, _EnableVFXColorAdjustment=0)
                // _396 = _350 * _BaseColor.a * 1
                float finalIntensity = shadowAlpha * _BaseColor.a;

                // Output RGB (decompiled lines 1000-1002):
                // mad(_396, rgb * _BaseColor.rgb - 1, 1) = 1 + finalIntensity * (blended - 1)
                float3 blended = rgb * _BaseColor.rgb;
                float3 finalColor = 1.0 + finalIntensity * (blended - 1.0);

                // Output alpha = _350 = shadowAlpha (decompiled line 1003)
                return float4(finalColor, shadowAlpha);
            }
            ENDHLSL
        }
    }
}
