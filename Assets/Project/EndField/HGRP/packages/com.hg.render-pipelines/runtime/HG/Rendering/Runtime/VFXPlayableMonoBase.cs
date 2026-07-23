using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public abstract class VFXPlayableMonoBase : MonoBehaviour, IVFXPlayable // TypeDefIndex: 37974
	{
		// Fields
		private bool m_isPlaying; // 0x18
	
		// Constructors
		protected VFXPlayableMonoBase() {} // 0x0000000185394740-0x000000018539475C
		// P3dButtonClearAll()
		void PaintIn3D::P3dButtonClearAll::P3dButtonClearAll(P3dButtonClearAll *this, MethodInfo *method)
		{
		  this->fields.clearStates = 1;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		[ContextMenu("Play")]
		public void Play() {} // 0x00000001834FC8C0-0x00000001834FC910
		// Void Play()
		void HG::Rendering::Runtime::VFXPlayableMonoBase::Play(VFXPlayableMonoBase *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2602, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2602, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( !this->fields.m_isPlaying )
		  {
		    this->fields.m_isPlaying = 1;
		    if ( UnityEngine::Behaviour::get_isActiveAndEnabled((Behaviour *)this, 0LL) )
		      sub_180003290(6LL, this);
		  }
		}
		
		[ContextMenu("Stop")]
		public void Stop() {} // 0x000000018420D0C0-0x000000018420D110
		// Void Stop()
		void HG::Rendering::Runtime::VFXPlayableMonoBase::Stop(VFXPlayableMonoBase *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2604, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2604, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.m_isPlaying )
		  {
		    this->fields.m_isPlaying = 0;
		    if ( UnityEngine::Behaviour::get_isActiveAndEnabled((Behaviour *)this, 0LL) )
		      sub_180003290(7LL, this);
		  }
		}
		
		public void OnEnable() {} // 0x00000001842EE260-0x00000001842EE2A0
		// Void OnEnable()
		void HG::Rendering::Runtime::VFXPlayableMonoBase::OnEnable(VFXPlayableMonoBase *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2606, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2606, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.m_isPlaying )
		  {
		    sub_180003290(6LL, this);
		  }
		}
		
		public void OnDisable() {} // 0x00000001843A8F70-0x00000001843A8FB0
		// Void OnDisable()
		void HG::Rendering::Runtime::VFXPlayableMonoBase::OnDisable(VFXPlayableMonoBase *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2607, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2607, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.m_isPlaying )
		  {
		    sub_180003290(7LL, this);
		  }
		}
		
		protected virtual void OnPlay() {} // 0x0000000184D25E60-0x0000000184D25E90
		// Void OnPlay()
		void HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay(VFXPlayableMonoBase *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2603, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2603, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		protected virtual void OnStop() {} // 0x0000000184300770-0x00000001843007A0
		// Void OnStop()
		void HG::Rendering::Runtime::VFXPlayableMonoBase::OnStop(VFXPlayableMonoBase *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2605, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2605, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
	}
}
