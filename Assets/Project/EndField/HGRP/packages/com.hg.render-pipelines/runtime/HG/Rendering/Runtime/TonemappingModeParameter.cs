using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public sealed class TonemappingModeParameter : VolumeParameter<TonemappingMode>
	{
		public TonemappingModeParameter(TonemappingMode value, [MetadataOffset(Offset = "0x01F91449")] bool overrideState = false)
		{
			// // TonemappingModeParameter(TonemappingMode, Boolean)
			// void HG::Rendering::Runtime::TonemappingModeParameter::TonemappingModeParameter(
			//         TonemappingModeParameter *this,
			//         TonemappingMode__Enum value,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( byte_18D8ED9EA )
			//   {
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//   }
			//   else
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::TonemappingMode>::VolumeParameter);
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//     byte_18D8ED9EA = 1;
			//   }
			// }
			// 
		}
	}
}
