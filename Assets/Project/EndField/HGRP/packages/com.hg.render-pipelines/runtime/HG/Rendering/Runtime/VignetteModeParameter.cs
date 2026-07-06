using System;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public sealed class VignetteModeParameter : VolumeParameter<VignetteMode>
	{
		public VignetteModeParameter(VignetteMode value, [MetadataOffset(Offset = "0x01F9144A")] bool overrideState = false)
		{
			// // VignetteModeParameter(VignetteMode, Boolean)
			// void HG::Rendering::Runtime::VignetteModeParameter::VignetteModeParameter(
			//         VignetteModeParameter *this,
			//         VignetteMode__Enum value,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( byte_18D8ED9EC )
			//   {
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//   }
			//   else
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::HyperGryphEngineCode::VignetteMode>::VolumeParameter);
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//     byte_18D8ED9EC = 1;
			//   }
			// }
			// 
		}
	}
}
