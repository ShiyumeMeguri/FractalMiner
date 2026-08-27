/*
===============================================================
Shader Variants:
	- "_ANISOTROPIC_SPECULAR"
	- "_USE_STOCKING"
	- "_USE_BLEND_TEX"
Instructions:
	VectorColor 	=	Outline Smooth Normal
	HairBlendTex 	=	RGB: Color
						A:ShadowMask
	FaceBlendTex 	=	R:SDF
						G:SpecularArea
						B:SpecularIntensity
						A:FaceMask
	RMOTex 			=	R:Roughness
						G:Metallic
						B:Occlusion
						A:Not Use
================================================================
*/

Shader "GF2/Character/Uber"
{
    Properties
    {
        [Header(Albedo)] _BaseColor ("Color", Color) = (0.5,0.5,0.5,1)
        _FinalTint ("Final Tint", Color) = (1,1,1,1)
        _BaseMap ("Albedo Map (RGBA)", 2D) = "white" {}
        _OutlineColor ("Outline Color", Color) = (0.6,0.6,0.6,0.1)
        _OutlineShadowColor ("Outline Shadow Color", Color) = (0.6,0.6,0.6,1)
        [Header(Normalmap)] [Normal] _BumpMap ("Normal Map", 2D) = "bump" {}
        [Header(Stocking)] [Toggle(_USE_STOCKING)] _UseStockingFalloff ("Use Stocking Falloff", Float) = 0
        [HiddenByKeyword(_USE_STOCKING)] _StockingCenterColor ("Stocking Center Color", Color) = (1,1,1,1)
        [HiddenByKeyword(_USE_STOCKING)] _StockingFalloffColor ("Stocking Falloff Color", Color) = (0.1,0,0,1)
        [HiddenByKeyword(_USE_STOCKING)] _StockingFalloffPower ("Stocking Falloff Power", Range(0.1, 5)) = 1
        [HiddenByKeyword(_USE_STOCKING)] _AnisotropicGGX ("Anisotropic GGX", Range(-1, 1)) = 0
        [Header(Roghness Metallic Occlusion)] _RMOTex ("RMO Map (RGB)", 2D) = "white" {}
        _EmissiveIntensity ("Emissive Intensity", Range(0, 19990)) = 0
        [Toggle(_RAMPMAP)] _UseRampMap ("Use Ramp Map", Float) = 0
        [NoScaleOffset] _RampMap ("Diffuse Ramp Map", 2D) = "white" {}
        [Toggle(_GI_FLATTEN)] _UseGIFlatten ("Use GI Flatten", Float) = 0
        _OutlineWidth ("Outline width", Range(0, 10)) = 1
        _OutlineZBias ("Outline Z-Bias", Range(0, 1)) = 0
        _OutlineIntensity ("Outline Intensity", Range(1, 30)) = 1
        [Toggle(_ANISOTROPIC_SPECULAR)] _AnisotropicSpecular ("Use Anisotropic Specular", Float) = 0
        _Anisotropy ("Anisotropy", Range(0, 5)) = 1
        _AnisotropyShift ("Anisotropy Shift", Range(0, 1)) = 0.05
        [Toggle(_BLEND_UV2)] _UseSpecularUV2 ("Use UV2", Float) = 0
        [Toggle(_USE_BLEND_TEX)] _UseBlendTex ("Use Blend Tex", Float) = 0
        _BlendTex ("Blend Tex", 2D) = "gray" {}
        _BlendSmoothness ("Blend Smoothness", Range(0, 1)) = 0.1
    }
    SubShader
    {
        Tags
        {
            "IGNOREPROJECTOR" = "true" "QUEUE" = "Geometry+10" "RenderPipeline" = "UniversalPipeline" "RenderType" = "GfCharacter"
        }
        Pass
        {
            Name "GFCharForward"
            Tags
            {
                "LIGHTMODE" = "GFCharForward"
            }
            Cull Off
            Stencil
            {
                WriteMask 0
                Comp [Disabled]
                Pass Keep
                Fail Keep
                ZFail Keep
            }
            HLSLPROGRAM
            #pragma vertex GF2Vertex
            #pragma fragment GF2Fragment

            #pragma shader_feature _ANISOTROPIC_SPECULAR
            #pragma shader_feature _USE_STOCKING
            #pragma shader_feature _USE_BLEND_TEX

            #include "GF2CharacterUberFunctions.hlsl"
            ENDHLSL
        }
        Pass
        {
            Name "GFOutline"
            Tags
            {
                "LIGHTMODE" = "GFOutline"
            }
            Cull Front
            Stencil
            {
                WriteMask 0
                Comp [Disabled]
                Pass Replace
                Fail Keep
                ZFail Keep
            }
            HLSLPROGRAM
            #pragma vertex GF2VertexOutline
            #pragma fragment GF2FragmentOutline
            
            #include "GF2CharacterUberOutlineFunctions.hlsl"
            ENDHLSL
        }
        Pass
        {
            Name "ShadowCaster"
            Tags
            {
                "LIGHTMODE" = "SHADOWCASTER"
            }
            Cull Off
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct v2f
            {
                float4 position : SV_POSITION0;
            };

            v2f vert(appdata_full v)
            {
                v2f o;
                float4 clip_world = UnityObjectToClipPos(v.vertex);
                o.position.z = min(clip_world.w, clip_world.z);
                o.position.xyw = clip_world.xyw;
                return o;
            }

            half4 frag(v2f o) : SV_Target
            {
                return 0;
            }
            ENDCG
        }
    }
    Fallback "Hidden/Universal Render Pipeline/FallbackError"
}