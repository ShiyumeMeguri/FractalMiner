using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public sealed class AutoExposureMeteringModeParameter : VolumeParameter<AutoExposureMeteringMode>
	{
		public AutoExposureMeteringModeParameter(AutoExposureMeteringMode value, [MetadataOffset(Offset = "0x01F91414")] bool overrideState = false)
		{
			// // AutoExposureMeteringModeParameter(AutoExposureMeteringMode, Boolean)
			// void HG::Rendering::Runtime::AutoExposureMeteringModeParameter::AutoExposureMeteringModeParameter(
			//         AutoExposureMeteringModeParameter *this,
			//         AutoExposureMeteringMode__Enum value,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( byte_18D8ED9CB )
			//   {
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//   }
			//   else
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::AutoExposureMeteringMode>::VolumeParameter);
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//     byte_18D8ED9CB = 1;
			//   }
			// }
			// 
		}
	}
}
