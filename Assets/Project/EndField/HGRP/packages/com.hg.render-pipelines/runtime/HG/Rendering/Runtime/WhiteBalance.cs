using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("Post-processing/White Balance", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class WhiteBalance : VolumeComponent, IPostProcessComponent
	{
		public WhiteBalance()
		{
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::WhiteBalance::IsActive(WhiteBalance *this, MethodInfo *method)
			// {
			//   float v2; // xmm2_4
			//   __int64 v4; // rcx
			//   ClampedFloatParameter *temperature; // rdx
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v6; // rcx
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2249, 0LL) )
			//   {
			//     temperature = this.fields.temperature;
			//     if ( temperature )
			//     {
			//       sub_18003F9B0(10LL, temperature);
			//       if ( !(unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(v6, 0.0, v2) )
			//         return 1;
			//       temperature = this.fields.tint;
			//       if ( temperature )
			//       {
			//         sub_18003F9B0(10LL, temperature);
			//         return UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(v8, 0.0, v2) ^ 1;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(v4, temperature);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2249, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		[Tooltip("Controls the color temperature HGRP uses for white balancing.")]
		public ClampedFloatParameter temperature;

		[Tooltip("Controls the white balance color to compensate for a green or magenta tint.")]
		public ClampedFloatParameter tint;
	}
}
