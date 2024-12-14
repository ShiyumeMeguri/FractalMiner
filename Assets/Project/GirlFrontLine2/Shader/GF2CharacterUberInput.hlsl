#ifndef GF2_CHARACTER_UBER_INPUT_INCLUDED
#define GF2_CHARACTER_UBER_INPUT_INCLUDED

#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/SurfaceInput.hlsl"
#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl" 

CBUFFER_START(UnityPerMaterial)
float4 _BaseMap_ST;
float4 _BaseColor;
float4 _FinalTint;
float _EmissiveIntensity;

float4 _StockingCenterColor;
float4 _StockingFalloffColor;
float _StockingFalloffPower;

float _AnisotropicGGX;
float _Anisotropy;
float _AnisotropyShift;

float _BlendSmoothness;
float _UseRampMap;
float _UseSpecularUV2;
float _UseGIFlatten;

// Outline
float4 _OutlineColor;
float4 _OutlineShadowColor;
float _OutlineWidth;
float _OutlineZBias;
float _OutlineIntensity;
CBUFFER_END

//TEXTURE2D(_BaseMap);            SAMPLER(sampler_BaseMap);
//TEXTURE2D(_BumpMap);           SAMPLER(sampler_BumpMap);
TEXTURE2D(_RMOTex);         SAMPLER(sampler_RMOTex);
TEXTURE2D(_DissolveTex);          SAMPLER(sampler_DissolveTex);
TEXTURE2D(_BlendTex);       SAMPLER(sampler_BlendTex);
TEXTURE2D(_RampMap);         SAMPLER(sampler_RampMap);

struct appdata_ex
{
    float4 vertex : POSITION;
    float4 tangent : TANGENT;
    float3 normal : NORMAL;
    float4 color : COLOR;
    float2 texcoord : TEXCOORD0;
    float2 texcoord1 : TEXCOORD1;
};

struct v2f
{
    float4 position : SV_POSITION0;
    float4 uv : TEXCOORD0;
    float4 normalWS : TEXCOORD1;
    float4 tangentWS : TEXCOORD2;
    float4 binormalWS : TEXCOORD3;
    float3 positionWS : TEXCOORD4;
    float3 viewDirWS : TEXCOORD5;
};

struct v2fOutline
{
    float4 position : SV_POSITION0;
    float2 uv : TEXCOORD0;
    float4 outlineColor : TEXCOORD1;
};

#endif
