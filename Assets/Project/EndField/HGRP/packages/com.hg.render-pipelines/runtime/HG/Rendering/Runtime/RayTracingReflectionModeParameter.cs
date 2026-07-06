using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public sealed class RayTracingReflectionModeParameter : VolumeParameter<RayTracingReflectionMode>
	{
		public RayTracingReflectionModeParameter(RayTracingReflectionMode value, [MetadataOffset(Offset = "0x01F91442")] bool overrideState = false)
		{
			// // RayTracingReflectionModeParameter(RayTracingReflectionMode, Boolean)
			// void HG::Rendering::Runtime::RayTracingReflectionModeParameter::RayTracingReflectionModeParameter(
			//         RayTracingReflectionModeParameter *this,
			//         RayTracingReflectionMode__Enum value,
			//         bool overrideState,
			//         MethodInfo *method)
			// {
			//   if ( byte_18D8ED9E4 )
			//   {
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//   }
			//   else
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<HG::Rendering::Runtime::RayTracingReflectionMode>::VolumeParameter);
			//     this.fields._.m_Value = value;
			//     this.fields._._.overrideState = overrideState;
			//     byte_18D8ED9E4 = 1;
			//   }
			// }
			// 
		}
	}
}
