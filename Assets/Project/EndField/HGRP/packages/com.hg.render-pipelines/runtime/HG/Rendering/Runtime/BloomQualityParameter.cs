using System;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public sealed class BloomQualityParameter : VolumeParameter<BloomQuality>
	{
		public BloomQualityParameter(BloomQuality value, [MetadataOffset(Offset = "0x01F9140D")] bool overrideState = false)
		{
			// // BloomQualityParameter(BloomQuality, Boolean)
			// void HG::Rendering::Runtime::BloomQualityParameter::BloomQualityParameter(
			//         BloomQualityParameter *this,
			//         BloomQuality__Enum value,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( byte_18D8ED9C0 )
			//   {
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//   }
			//   else
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::HyperGryphEngineCode::BloomQuality>::VolumeParameter);
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//     byte_18D8ED9C0 = 1;
			//   }
			// }
			// 
		}
	}
}
