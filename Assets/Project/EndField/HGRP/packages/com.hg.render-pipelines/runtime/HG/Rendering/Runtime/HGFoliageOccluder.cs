using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGFoliageOccluder : MonoBehaviour // TypeDefIndex: 37981
	{
		// Constructors
		public HGFoliageOccluder() {} // 0x0000000183695570-0x0000000183695590
		// LuaUIWidget()
		void Beyond::Lua::LuaUIWidget::LuaUIWidget(LuaUIWidget *this, MethodInfo *method)
		{
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		private void OnEnable() {} // 0x0000000184CE4E60-0x0000000184CE4EA0
		// Void OnEnable()
		void HG::Rendering::Runtime::HGFoliageOccluder::OnEnable(HGFoliageOccluder *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2613, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2613, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGFoliageOccluder::_AddToFoliageOccluderManager(this, 0LL);
		  }
		}
		
		private void OnDisable() {} // 0x0000000184CE4ED0-0x0000000184CE4F10
		// Void OnDisable()
		void HG::Rendering::Runtime::HGFoliageOccluder::OnDisable(HGFoliageOccluder *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2615, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2615, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGFoliageOccluder::_RemoveFromFoliageOccluderManager(this, 0LL);
		  }
		}
		
		public void SyncPosition() {} // 0x0000000189B6B5D0-0x0000000189B6B620
		// Void SyncPosition()
		void HG::Rendering::Runtime::HGFoliageOccluder::SyncPosition(HGFoliageOccluder *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2617, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2617, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGFoliageOccluder::_UpdateFromFoliageOccluderManager(this, 0LL);
		  }
		}
		
		private void _AddToFoliageOccluderManager() {} // 0x0000000184CE4EA0-0x0000000184CE4ED0
		// Void _AddToFoliageOccluderManager()
		void HG::Rendering::Runtime::HGFoliageOccluder::_AddToFoliageOccluderManager(
		        HGFoliageOccluder *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2614, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2614, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		private void _RemoveFromFoliageOccluderManager() {} // 0x0000000184CE4F10-0x0000000184CE4F40
		// Void _RemoveFromFoliageOccluderManager()
		void HG::Rendering::Runtime::HGFoliageOccluder::_RemoveFromFoliageOccluderManager(
		        HGFoliageOccluder *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2616, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2616, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		private void _UpdateFromFoliageOccluderManager() {} // 0x0000000189B6B620-0x0000000189B6B664
		// Void _UpdateFromFoliageOccluderManager()
		void HG::Rendering::Runtime::HGFoliageOccluder::_UpdateFromFoliageOccluderManager(
		        HGFoliageOccluder *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2618, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2618, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
	}
}
