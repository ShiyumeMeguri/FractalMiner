using System;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public sealed class BloomBlendModeParameter : VolumeParameter<BloomBlendMode>
	{
		public BloomBlendModeParameter(BloomBlendMode value, [MetadataOffset(Offset = "0x01F9140E")] bool overrideState = false)
		{
			// // BloomBlendModeParameter(BloomBlendMode, Boolean)
			// void HG::Rendering::Runtime::BloomBlendModeParameter::BloomBlendModeParameter(
			//         BloomBlendModeParameter *this,
			//         BloomBlendMode__Enum value,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( byte_18D8ED9C1 )
			//   {
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//   }
			//   else
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::HyperGryphEngineCode::BloomBlendMode>::VolumeParameter);
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//     byte_18D8ED9C1 = 1;
			//   }
			// }
			// 
		}
	}
}
