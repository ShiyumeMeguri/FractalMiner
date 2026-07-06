using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public abstract class VFXPlayableMonoBase : MonoBehaviour, IVFXPlayable
	{
		protected VFXPlayableMonoBase()
		{
			// // P3dButtonClearAll()
			// void PaintIn3D::P3dButtonClearAll::P3dButtonClearAll(P3dButtonClearAll *this, MethodInfo *method)
			// {
			//   this.fields.clearStates = 1;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		[ContextMenu("Play")]
		public void Play()
		{
			// // Void Play()
			// void HG::Rendering::Runtime::VFXPlayableMonoBase::Play(VFXPlayableMonoBase *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2153, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2153, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( !this.fields.m_isPlaying )
			//   {
			//     this.fields.m_isPlaying = 1;
			//     if ( UnityEngine::EventSystems::UIBehaviour::IsActive((UIBehaviour *)this, 0LL) )
			//       sub_180040B30(6LL, this);
			//   }
			// }
			// 
		}

		[ContextMenu("Stop")]
		public void Stop()
		{
			// // Void Stop()
			// void HG::Rendering::Runtime::VFXPlayableMonoBase::Stop(VFXPlayableMonoBase *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2155, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2155, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.m_isPlaying )
			//   {
			//     this.fields.m_isPlaying = 0;
			//     if ( UnityEngine::EventSystems::UIBehaviour::IsActive((UIBehaviour *)this, 0LL) )
			//       sub_180040B30(7LL, this);
			//   }
			// }
			// 
		}

		public void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::VFXPlayableMonoBase::OnEnable(VFXPlayableMonoBase *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2157, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2157, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.m_isPlaying )
			//   {
			//     sub_180040B30(6LL, this);
			//   }
			// }
			// 
		}

		public void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::VFXPlayableMonoBase::OnDisable(VFXPlayableMonoBase *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2158, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2158, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.m_isPlaying )
			//   {
			//     sub_180040B30(7LL, this);
			//   }
			// }
			// 
		}

		protected virtual void OnPlay()
		{
			// // Void OnPlay()
			// void HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay(VFXPlayableMonoBase *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2154, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2154, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		protected virtual void OnStop()
		{
			// // Void OnStop()
			// void HG::Rendering::Runtime::VFXPlayableMonoBase::OnStop(VFXPlayableMonoBase *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2156, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2156, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		private bool m_isPlaying;
	}
}
