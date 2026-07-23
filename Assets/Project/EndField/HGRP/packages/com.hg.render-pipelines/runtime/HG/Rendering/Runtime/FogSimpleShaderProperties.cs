using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class FogSimpleShaderProperties // TypeDefIndex: 37925
	{
		// Fields
		private static readonly int SRC_BLEND; // 0x00
		private static readonly int DST_BLEND; // 0x04
		private static readonly int ALPHA_SRC_BLEND; // 0x08
		private static readonly int ALPHA_DST_BLEND; // 0x0C
		internal static readonly int CULL_MODE; // 0x10
		internal static readonly int BLEND_MODE; // 0x14
		internal static readonly int BASE_COLOR; // 0x18
		internal static readonly int BASE_ALPHA_INTENSITY; // 0x1C
		internal static readonly int MAIN_TEX; // 0x20
		internal static readonly int FOG_NOISE_INTENSITY; // 0x24
		internal static readonly int USE_WIND; // 0x28
		internal static readonly int NOISE_TEX; // 0x2C
		internal static readonly int WIND_NOISE_INTENSITY; // 0x30
		internal static readonly int WIND_NOISE_CONTRAST; // 0x34
		internal static readonly int WIND_DIR_X; // 0x38
		internal static readonly int WIND_DIR_Y; // 0x3C
		internal static readonly int WIND_SPEED; // 0x40
		internal static readonly int WIND_SCALE; // 0x44
		internal static readonly int USE_SEPARATE_SCALE; // 0x48
		internal static readonly int WIND_SCALE_X; // 0x4C
		internal static readonly int WIND_SCALE_Y; // 0x50
		internal const string USE_SOFT_LIGHTING = "_USE_LIGHTING"; // Metadata: 0x023035D1
		internal static readonly int USE_LIGHTING; // 0x54
		internal static readonly int USE_NORMAL_TEX; // 0x58
		internal static readonly int NORMAL_TEX; // 0x5C
		internal static readonly int NORMAL_SCALE; // 0x60
		internal static readonly int TWO_SIDED_NORMAL; // 0x64
		internal static readonly int INDIRECT_COLOR; // 0x68
		internal static readonly int LIGHT_FACTOR; // 0x6C
		internal static readonly int USE_FRESNEL; // 0x70
		internal static readonly int FLIP_FRESNEL; // 0x74
		internal static readonly int FRESNEL_INTENSITY; // 0x78
		internal static readonly int FRESNEL_CONTRACT; // 0x7C
		internal static readonly int DISTANCE_FADE; // 0x80
		internal static readonly int DISTANCE_FADE_START; // 0x84
		internal static readonly int DISTANCE_FADE_END; // 0x88
		internal static readonly int NEAR_CAMERA_FADE_DISTANCE_START; // 0x8C
		internal static readonly int NEAR_CAMERA_FADE_DISTANCE_END; // 0x90
		internal static readonly int TOP_FADE; // 0x94
		internal static readonly int TOP_FADE_CONTRACT; // 0x98
		internal static readonly int TOP_FADE_OFFSET; // 0x9C
		internal const string USE_SOFT_BLEND_KEYWORD = "_USE_SOFTBLEND"; // Metadata: 0x023035DF
		internal static readonly int USE_SOFT_BLEND; // 0xA0
		internal static readonly int SOFT_DISTANCE; // 0xA4
		internal const string USE_FOG_KEYWORD = "_USE_FOG"; // Metadata: 0x023035EE
		internal static readonly int USE_FOG; // 0xA8
		internal static readonly int FOG_INTENSITY; // 0xAC
		internal static readonly int FOG_INTENSITY_FADE_OUT_DISTANCE; // 0xB0
		internal static readonly int USE_PRE_DEPTH; // 0xB4
		internal static readonly int DEPTH_PREPASS_ALPHA_THRESHOLD; // 0xB8
		private static readonly int TRANSPARENT_SORT_PRIORITY; // 0xBC
	
		// Constructors
		static FogSimpleShaderProperties() {} // 0x0000000189B576DC-0x0000000189B57CE4
		// FogSimpleShaderProperties()
		void HG::Rendering::Runtime::FogSimpleShaderProperties::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->SRC_BLEND = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_SrcBlend",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->DST_BLEND = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_DstBlend",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->ALPHA_SRC_BLEND = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_AlphaSrcBlend",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->ALPHA_DST_BLEND = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_AlphaDstBlend",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->CULL_MODE = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_CullMode",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->BLEND_MODE = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_BlendMode",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->BASE_COLOR = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_BaseColor",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->BASE_ALPHA_INTENSITY = UnityEngine::Shader::PropertyToID((String *)"_BaseAlphaIntensity", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->MAIN_TEX = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_MainTex",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->FOG_NOISE_INTENSITY = UnityEngine::Shader::PropertyToID((String *)"_FogNoiseIntensity", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->USE_WIND = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_UseWind",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->NOISE_TEX = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_NoiseTex",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->WIND_NOISE_INTENSITY = UnityEngine::Shader::PropertyToID((String *)"_WindNoiseIntensity", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->WIND_NOISE_CONTRAST = UnityEngine::Shader::PropertyToID((String *)"_WindNoiseContrast", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->WIND_DIR_X = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_WindDirX",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->WIND_DIR_Y = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_WindDirY",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->WIND_SPEED = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_WindSpeed",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->WIND_SCALE = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_WindScale",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->USE_SEPARATE_SCALE = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_UseSeparateScale",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->WIND_SCALE_X = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_WindScaleX",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->WIND_SCALE_Y = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_WindScaleY",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->USE_LIGHTING = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_UseLighting",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->USE_NORMAL_TEX = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_UseNormalTex",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->NORMAL_TEX = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_NormalTex",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->NORMAL_SCALE = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_NormalScale",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->TWO_SIDED_NORMAL = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_TwoSidedNormal",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->INDIRECT_COLOR = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_IndirectColor",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->LIGHT_FACTOR = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_LightFactor",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->USE_FRESNEL = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_UseFresnel",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->FLIP_FRESNEL = UnityEngine::Shader::PropertyToID(
		                                                                                               (String *)"_FlipFresnel",
		                                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->FRESNEL_INTENSITY = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_FresnelIntensity",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->FRESNEL_CONTRACT = UnityEngine::Shader::PropertyToID(
		                                                                                                   (String *)"_FresnelContract",
		                                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->DISTANCE_FADE = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_DistanceFade",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->DISTANCE_FADE_START = UnityEngine::Shader::PropertyToID((String *)"_DistanceFadeStart", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->DISTANCE_FADE_END = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_DistanceFadeEnd",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->NEAR_CAMERA_FADE_DISTANCE_START = UnityEngine::Shader::PropertyToID((String *)"_NearCameraFadeDistanceStart", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->NEAR_CAMERA_FADE_DISTANCE_END = UnityEngine::Shader::PropertyToID((String *)"_NearCameraFadeDistanceEnd", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->TOP_FADE = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_TopFade",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->TOP_FADE_CONTRACT = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_TopFadeContract",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->TOP_FADE_OFFSET = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_TopFadeOffset",
		                                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->USE_SOFT_BLEND = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_UseSoftBlend",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->SOFT_DISTANCE = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_SoftDistance",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->USE_FOG = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_UseFog",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->FOG_INTENSITY = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_FogIntensity",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->FOG_INTENSITY_FADE_OUT_DISTANCE = UnityEngine::Shader::PropertyToID((String *)"_FogIntensityFadeOutDistance", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->USE_PRE_DEPTH = UnityEngine::Shader::PropertyToID(
		                                                                                                (String *)"_UsePreDepth",
		                                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->DEPTH_PREPASS_ALPHA_THRESHOLD = UnityEngine::Shader::PropertyToID((String *)"_DepthPrePassAlphaThreshold", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FogSimpleShaderProperties->static_fields->TRANSPARENT_SORT_PRIORITY = UnityEngine::Shader::PropertyToID((String *)"_TransparentSortPriority", 0LL);
		}
		
	}
}
