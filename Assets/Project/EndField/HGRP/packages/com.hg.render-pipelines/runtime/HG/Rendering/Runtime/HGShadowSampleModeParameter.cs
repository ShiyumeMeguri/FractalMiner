using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public sealed class HGShadowSampleModeParameter : VolumeParameter<HGShadowSampleMode>
	{
		public HGShadowSampleModeParameter(HGShadowSampleMode value, [MetadataOffset(Offset = "0x01F90E57")] bool overrideState = false)
		{
			// // HGShadowSampleModeParameter(HGShadowSampleMode, Boolean)
			// void HG::Rendering::Runtime::HGShadowSampleModeParameter::HGShadowSampleModeParameter(
			//         HGShadowSampleModeParameter *this,
			//         HGShadowSampleMode__Enum value,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( byte_18D8EDD16 )
			//   {
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//   }
			//   else
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::HGShadowSampleMode>::VolumeParameter);
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//     byte_18D8EDD16 = 1;
			//   }
			// }
			// 
		}
	}
}
