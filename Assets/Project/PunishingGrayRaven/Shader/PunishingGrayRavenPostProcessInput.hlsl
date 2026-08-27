#ifndef GRAY_RAVEN_POST_FX_INPUT_INCLUDED
#define GRAY_RAVEN_POST_FX_INPUT_INCLUDED

TEXTURE2D(_CameraDepthTexture);   SAMPLER(sampler_CameraDepthTexture);
TEXTURE2D(_ParticleDepthTexture);   SAMPLER(sampler_ParticleDepthTexture);
TEXTURE2D(_BloomTex0);   SAMPLER(sampler_BloomTex0);
TEXTURE2D(_BloomTex1);   SAMPLER(sampler_BloomTex1);
TEXTURE2D(_BloomTex2);   SAMPLER(sampler_BloomTex2);
TEXTURE2D(_BloomTex3);   SAMPLER(sampler_BloomTex3);
TEXTURE2D(_BloomTex);   SAMPLER(sampler_BloomTex);
TEXTURE2D(_UserLut);   SAMPLER(sampler_UserLut);

float _FilterThreshold;
float _FilterScaler;
float4 _BlurDir;
float4 _BloomCombineCoeff;
float4 _FinalBlendFactor;
float4 _ConsoleSettings;
float _Exposure;
float _Contrast;
float4 _UserLut_Params;
// 用于压缩强度，是一个0~1范围的数，在最终的后处理阶段进行反相操作
uniform float _GlobalDissolveScale;

#endif  // GRAY_RAVEN_POST_FX_INPUT_INCLUDED
