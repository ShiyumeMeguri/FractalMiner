using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public sealed class AutoExposureModeParameter : VolumeParameter<AutoExposureMode>
	{
		public AutoExposureModeParameter(AutoExposureMode value, [MetadataOffset(Offset = "0x01F91413")] bool overrideState = false)
		{
			// // AutoExposureModeParameter(AutoExposureMode, Boolean)
			// void HG::Rendering::Runtime::AutoExposureModeParameter::AutoExposureModeParameter(
			//         AutoExposureModeParameter *this,
			//         AutoExposureMode__Enum value,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( byte_18D8ED9CA )
			//   {
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//   }
			//   else
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::AutoExposureMode>::VolumeParameter);
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//     byte_18D8ED9CA = 1;
			//   }
			// }
			// 
		}
	}
}
