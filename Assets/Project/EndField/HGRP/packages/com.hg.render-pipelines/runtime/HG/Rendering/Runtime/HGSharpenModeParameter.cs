using System;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public sealed class HGSharpenModeParameter : VolumeParameter<HGSharpenMode>
	{
		public HGSharpenModeParameter(HGSharpenMode value, [MetadataOffset(Offset = "0x01F9143A")] bool overrideState = false)
		{
			// // HGSharpenModeParameter(HGSharpenMode, Boolean)
			// void HG::Rendering::Runtime::HGSharpenModeParameter::HGSharpenModeParameter(
			//         HGSharpenModeParameter *this,
			//         HGSharpenMode__Enum value,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( byte_18D8ED9DF )
			//   {
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//   }
			//   else
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::HyperGryphEngineCode::HGSharpenMode>::VolumeParameter);
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//     byte_18D8ED9DF = 1;
			//   }
			// }
			// 
		}
	}
}
