using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
	public struct SubsurfaceData
	{
		public bool Equals(ref SubsurfaceData other)
		{
			// // Boolean Equals(SubsurfaceData ByRef)
			// bool HG::Rendering::Runtime::SubsurfaceData::Equals(SubsurfaceData *this, SubsurfaceData *other, MethodInfo *method)
			// {
			//   float v3; // xmm2_4
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v6; // rcx
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v7; // rcx
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v8; // rcx
			//   UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat *v9; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3294, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3294, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1171(Patch, this, other, 0LL);
			//   }
			//   else if ( (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
			//                                v6,
			//                                other.SubsurfaceColor.r,
			//                                v3)
			//          && (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
			//                                v7,
			//                                other.SubsurfaceColor.g,
			//                                v3)
			//          && (unsigned __int8)UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(
			//                                v8,
			//                                other.SubsurfaceColor.b,
			//                                v3) )
			//   {
			//     return UnityEngine::UIElements::StylePropertyAnimationSystem::ValuesFloat::IsSame(v9, other.SubsurfaceIndirect, v3);
			//   }
			//   else
			//   {
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		public int RefCount;

		public Color SubsurfaceColor;

		public float SubsurfaceIndirect;
	}
}
