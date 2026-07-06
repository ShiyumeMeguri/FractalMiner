using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public sealed class LightShadowResolutionParameter : VolumeParameter<LightShadowResolution>
	{
		public LightShadowResolutionParameter(LightShadowResolution value, [MetadataOffset(Offset = "0x01F90E56")] bool overrideState = false)
		{
			// // LightShadowResolutionParameter(LightShadowResolution, Boolean)
			// void HG::Rendering::Runtime::LightShadowResolutionParameter::LightShadowResolutionParameter(
			//         LightShadowResolutionParameter *this,
			//         LightShadowResolution__Enum value,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( byte_18D8EDD15 )
			//   {
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//   }
			//   else
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Rendering::LightShadowResolution>::VolumeParameter);
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//     byte_18D8EDD15 = 1;
			//   }
			// }
			// 
		}
	}
}
