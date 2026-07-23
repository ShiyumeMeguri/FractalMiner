using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public sealed class VignetteModeParameter : VolumeParameter<VignetteMode> // TypeDefIndex: 38067
	{
		// Constructors
		public VignetteModeParameter() {} // Dummy constructor
		public VignetteModeParameter(VignetteMode value, bool overrideState = false /* Metadata: 0x02303876 */) {} // 0x0000000184DA09B0-0x0000000184DA09C0
		// VolumeParameter`1[UnityEngine.LayerMask](LayerMask, Boolean)
		void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::VolumeParameter(
		        VolumeParameter_1_UnityEngine_LayerMask_ *this,
		        LayerMask value,
		        bool overrideState,
		        MethodInfo *method)
		{
		  this->fields.m_Value = value;
		  this->fields._.overrideState = overrideState;
		}
		
	}
}
