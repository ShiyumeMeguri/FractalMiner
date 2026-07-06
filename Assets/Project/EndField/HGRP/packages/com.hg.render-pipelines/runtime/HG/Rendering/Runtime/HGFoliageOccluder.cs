using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGFoliageOccluder : MonoBehaviour
	{
		public HGFoliageOccluder()
		{
			// // Singleton`1[System.Object]()
			// void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
			// {
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGFoliageOccluder::OnEnable(HGFoliageOccluder *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2164, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2164, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGFoliageOccluder::_AddToFoliageOccluderManager(this, 0LL);
			//   }
			// }
			// 
		}

		private void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::HGFoliageOccluder::OnDisable(HGFoliageOccluder *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2166, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2166, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGFoliageOccluder::_RemoveFromFoliageOccluderManager(this, 0LL);
			//   }
			// }
			// 
		}

		public void SyncPosition()
		{
			// // Void SyncPosition()
			// void HG::Rendering::Runtime::HGFoliageOccluder::SyncPosition(HGFoliageOccluder *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2168, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2168, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGFoliageOccluder::_UpdateFromFoliageOccluderManager(this, 0LL);
			//   }
			// }
			// 
		}

		private void _AddToFoliageOccluderManager()
		{
			// // Void _AddToFoliageOccluderManager()
			// void HG::Rendering::Runtime::HGFoliageOccluder::_AddToFoliageOccluderManager(
			//         HGFoliageOccluder *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2165, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2165, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		private void _RemoveFromFoliageOccluderManager()
		{
			// // Void _RemoveFromFoliageOccluderManager()
			// void HG::Rendering::Runtime::HGFoliageOccluder::_RemoveFromFoliageOccluderManager(
			//         HGFoliageOccluder *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2167, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2167, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		private void _UpdateFromFoliageOccluderManager()
		{
			// // Void _UpdateFromFoliageOccluderManager()
			// void HG::Rendering::Runtime::HGFoliageOccluder::_UpdateFromFoliageOccluderManager(
			//         HGFoliageOccluder *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2169, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2169, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}
	}
}
