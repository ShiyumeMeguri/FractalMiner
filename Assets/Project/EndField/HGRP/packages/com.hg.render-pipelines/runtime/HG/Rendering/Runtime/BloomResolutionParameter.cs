using System;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public sealed class BloomResolutionParameter : VolumeParameter<BloomResolution>
	{
		public BloomResolutionParameter(BloomResolution value, [MetadataOffset(Offset = "0x01F9140C")] bool overrideState = false)
		{
			// // BloomResolutionParameter(BloomResolution, Boolean)
			// void HG::Rendering::Runtime::BloomResolutionParameter::BloomResolutionParameter(
			//         BloomResolutionParameter *this,
			//         BloomResolution__Enum value,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( byte_18D8ED9BF )
			//   {
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//   }
			//   else
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::HyperGryphEngineCode::BloomResolution>::VolumeParameter);
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//     byte_18D8ED9BF = 1;
			//   }
			// }
			// 
		}
	}
}
