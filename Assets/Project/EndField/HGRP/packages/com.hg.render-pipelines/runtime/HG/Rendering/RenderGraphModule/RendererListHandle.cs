using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine.Rendering.RendererUtils;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("RendererList ({handle})")]
	public struct RendererListHandle // TypeDefIndex: 37462
	{
		// Fields
		private bool m_IsValid; // 0x00
	
		// Properties
		internal int handle { [IsReadOnly] get; private set; } // 0x0000000184D88B20-0x0000000184D88B30 0x0000000184D88B50-0x0000000184D88B60
		// Int32 get_endIndex()
		int32_t Beyond::Gameplay::Factory::WireRendererInfoCollection<Beyond::Gameplay::Factory::WireRendererInfo>::get_endIndex(
		        WireRendererInfoCollection_1_WireRendererInfo_ *this,
		        MethodInfo *method)
		{
		  return this->m_endIndex;
		}
		

		// Void set_area(Int32)
		void UnityEngine::AI::NavMeshBuildMarkup::set_area(NavMeshBuildMarkup *this, int32_t value, MethodInfo *method)
		{
		  this->m_Area = value;
		}
		
		public static RendererListHandle InvalidHandle { get => default; } // 0x0000000189B3F81C-0x0000000189B3F85C 
		// RendererListHandle get_InvalidHandle()
		RendererListHandle HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(313, 0LL) )
		    return 0LL;
		  Patch = IFix::WrappersManagerImpl::GetPatch(313, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_147(Patch, 0LL);
		}
		
	
		// Constructors
		internal RendererListHandle(int handle) : this() {
			m_IsValid = default;
		} // 0x0000000184D9D420-0x0000000184D9D430
		// Nullable`1[HG.Rendering.Runtime.CustomDepthOnlyRequestManager+VSMSupport](CustomDepthOnlyRequestManager+VSMSupport)
		void System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::VSMSupport>::Nullable(
		        Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_VSMSupport_ *this,
		        CustomDepthOnlyRequestManager_VSMSupport value,
		        MethodInfo *method)
		{
		  this->value = value;
		  this->hasValue = 1;
		}
		
	
		// Methods
		[IDTag(0)]
		public static implicit operator int(RendererListHandle handle) => default; // 0x0000000189B3F85C-0x0000000189B3F8AC
		// Int32 op_Implicit(RendererListHandle)
		int32_t HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(
		        RendererListHandle handle,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  int32_t handle_k__BackingField; // [rsp+34h] [rbp+Ch]
		
		  handle_k__BackingField = handle._handle_k__BackingField;
		  if ( !IFix::WrappersManagerImpl::IsPatched(57, 0LL) )
		    return handle_k__BackingField;
		  Patch = IFix::WrappersManagerImpl::GetPatch(57, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_29(Patch, handle, 0LL);
		}
		
		[IDTag(1)]
		public static implicit operator RendererList(RendererListHandle rendererList) => default; // 0x0000000189B3F8AC-0x0000000189B3F960
		// RendererList op_Implicit(RendererListHandle)
		RendererList *HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(
		        RendererList *__return_ptr retstr,
		        RendererListHandle rendererList,
		        MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry *current; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  RendererList *v8; // rax
		  RendererList nullRendererList; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RendererList *result; // rax
		  RendererList v12; // [rsp+20h] [rbp-18h] BYREF
		  RendererListHandle v13; // [rsp+48h] [rbp+10h] BYREF
		
		  v13 = rendererList;
		  if ( IFix::WrappersManagerImpl::IsPatched(315, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(315, 0LL);
		    if ( Patch )
		    {
		      v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_148(&v12, Patch, rendererList, 0LL);
		      goto LABEL_9;
		    }
		LABEL_7:
		    sub_1800D8260(v7, v6);
		  }
		  if ( HG::Rendering::RenderGraphModule::RendererListHandle::IsValid(&v13, 0LL) )
		  {
		    current = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::get_current(0LL);
		    if ( current )
		    {
		      v8 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetRendererList(&v12, current, &v13, 0LL);
		LABEL_9:
		      nullRendererList = *v8;
		      goto LABEL_10;
		    }
		    goto LABEL_7;
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
		  nullRendererList = TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList->static_fields->nullRendererList;
		LABEL_10:
		  result = retstr;
		  *retstr = nullRendererList;
		  return result;
		}
		
		[IsReadOnly]
		public bool IsValid() => default; // 0x0000000189B3F7D4-0x0000000189B3F81C
		// Boolean IsValid()
		bool HG::Rendering::RenderGraphModule::RendererListHandle::IsValid(RendererListHandle *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(64, 0LL) )
		    return this->m_IsValid;
		  Patch = IFix::WrappersManagerImpl::GetPatch(64, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_31(Patch, this, 0LL);
		}
		
	}
}
