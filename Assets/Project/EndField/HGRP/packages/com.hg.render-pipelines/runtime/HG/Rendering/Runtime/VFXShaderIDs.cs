using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class VFXShaderIDs // TypeDefIndex: 37978
	{
		// Fields
		public static int s_MainTex; // 0x00
		public static int s_ProcedureAlpha; // 0x04
		public static int s_DisableVertColor; // 0x08
		public static int s_DisableParticleInstanceColor; // 0x0C
		public static int s_TintColor; // 0x10
		public static int s_TintColorIntensity; // 0x14
		public static int s_ExpThreshold; // 0x18
		public static int s_ExpIntensity; // 0x1C
		public static int s_TintColorAlpha; // 0x20
		public static int s_UseBright; // 0x24
		public static int s_BrightColor; // 0x28
		public static int s_ScanFillColor; // 0x2C
		public static int s_BrightCenter; // 0x30
		public static int s_EnemyHitFlashBrightCenter; // 0x34
		public static int s_UseBlend; // 0x38
		public static int s_BlendTint; // 0x3C
		public static int s_UseFresnel; // 0x40
		public static int s_FresnelColor; // 0x44
		public static int s_UseEdgeColor; // 0x48
		public static int s_EdgeColorMode; // 0x4C
		public static int s_EdgeColor; // 0x50
		public static int s_UseDissolve; // 0x54
		public static int s_DissolveScheduleOffset; // 0x58
		public static int s_DissolveTex; // 0x5C
		public static int s_DissolveTex_ST; // 0x60
		public static int s_DissolveEdgeSharp; // 0x64
		public static int s_DissolveEmissiveColor; // 0x68
		public static int s_DissolveEmissiveEdge; // 0x6C
		public static int s_DissolveUseViewUV; // 0x70
		public static int s_DissolveUVSet; // 0x74
		public static int s_UseCutOff; // 0x78
		public static int s_CutOffPosY; // 0x7C
		public static int s_CutOffDirection; // 0x80
		public static int s_ScanScheduleOffset; // 0x84
	
		// Constructors
		static VFXShaderIDs() {} // 0x0000000184824330-0x0000000184824760
		// VFXShaderIDs()
		void HG::Rendering::Runtime::VFXShaderIDs::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_MainTex = UnityEngine::Shader::PropertyToID(
		                                                                               (String *)"_MainTex",
		                                                                               0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_ProcedureAlpha = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_ProcedureAlpha",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_DisableVertColor = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_DisableVertColor",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_DisableParticleInstanceColor = UnityEngine::Shader::PropertyToID(
		                                                                                                    (String *)"_DisableParticleInstanceColor",
		                                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_TintColor = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_TintColor",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_TintColorIntensity = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_TintColorIntensity",
		                                                                                          0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_ExpThreshold = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_ExpThreshold",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_ExpIntensity = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_ExpIntensity",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_TintColorAlpha = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_TintColorAlpha",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_UseBright = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_UseBright",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_BrightColor = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_BrightColor",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_ScanFillColor = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_ScanFillColor",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_BrightCenter = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_BrightCenter",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_EnemyHitFlashBrightCenter = UnityEngine::Shader::PropertyToID(
		                                                                                                 (String *)"_EnemyHitFlashBrightCenter",
		                                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_UseBlend = UnityEngine::Shader::PropertyToID(
		                                                                                (String *)"_UseBlend",
		                                                                                0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_BlendTint = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_BlendTint",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_UseFresnel = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_UseFresnel",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_FresnelColor = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_FresnelColor",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_UseEdgeColor = UnityEngine::Shader::PropertyToID(
		                                                                                    (String *)"_UseEdgeColor",
		                                                                                    0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_EdgeColorMode = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_EdgeColorMode",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_EdgeColor = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_EdgeColor",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_UseDissolve = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_UseDissolve",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_DissolveScheduleOffset = UnityEngine::Shader::PropertyToID(
		                                                                                              (String *)"_DissolveScheduleOffset",
		                                                                                              0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_DissolveTex = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_DissolveTex",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_DissolveTex_ST = UnityEngine::Shader::PropertyToID(
		                                                                                      (String *)"_DissolveTex_ST",
		                                                                                      0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_DissolveEdgeSharp = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_DissolveEdgeSharp",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_DissolveEmissiveColor = UnityEngine::Shader::PropertyToID(
		                                                                                             (String *)"_DissolveEmissiveColor",
		                                                                                             0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_DissolveEmissiveEdge = UnityEngine::Shader::PropertyToID(
		                                                                                            (String *)"_DissolveEmissiveEdge",
		                                                                                            0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_DissolveUseViewUV = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_DissolveUseViewUV",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_DissolveUVSet = UnityEngine::Shader::PropertyToID(
		                                                                                     (String *)"_DissolveUVSet",
		                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_UseCutOff = UnityEngine::Shader::PropertyToID(
		                                                                                 (String *)"_UseCutOff",
		                                                                                 0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_CutOffPosY = UnityEngine::Shader::PropertyToID(
		                                                                                  (String *)"_CutOffPosY",
		                                                                                  0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_CutOffDirection = UnityEngine::Shader::PropertyToID(
		                                                                                       (String *)"_CutOffDirection",
		                                                                                       0LL);
		  TypeInfo::HG::Rendering::Runtime::VFXShaderIDs->static_fields->s_ScanScheduleOffset = UnityEngine::Shader::PropertyToID(
		                                                                                          (String *)"_ScanLineSchedule",
		                                                                                          0LL);
		}
		
	}
}
