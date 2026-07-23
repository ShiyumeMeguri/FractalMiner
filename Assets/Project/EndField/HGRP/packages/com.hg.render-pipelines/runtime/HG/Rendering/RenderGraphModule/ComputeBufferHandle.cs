using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("ComputeBuffer ({handle.index})")]
	public struct ComputeBufferHandle // TypeDefIndex: 37450
	{
		// Fields
		private static ComputeBufferHandle s_NullHandle; // 0x00
		internal ResourceHandle handle; // 0x00
	
		// Properties
		public static ComputeBufferHandle nullHandle { get => default; } // 0x0000000184CDE640-0x0000000184CDE690 
		// ComputeBufferHandle get_nullHandle()
		ComputeBufferHandle HG::Rendering::RenderGraphModule::ComputeBufferHandle::get_nullHandle(MethodInfo *method)
		{
		  struct ComputeBufferHandle__Class *v1; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(284, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(284, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_134(Patch, 0LL);
		  }
		  else
		  {
		    v1 = TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle;
		    if ( !TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		      v1 = TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle;
		    }
		    return v1->static_fields->s_NullHandle;
		  }
		}
		
	
		// Constructors
		internal ComputeBufferHandle(int handle, bool shared = false /* Metadata: 0x02302D70 */) : this() {
			this.handle = default;
		} // 0x0000000189B34D6C-0x0000000189B34DA4
		// ComputeBufferHandle(Int32, Boolean)
		void HG::Rendering::RenderGraphModule::ComputeBufferHandle::ComputeBufferHandle(
		        ComputeBufferHandle *this,
		        int32_t handle,
		        bool shared,
		        MethodInfo *method)
		{
		  ResourceHandle v5; // [rsp+40h] [rbp+8h] BYREF
		
		  v5 = 0LL;
		  HG::Rendering::RenderGraphModule::ResourceHandle::ResourceHandle(
		    &v5,
		    handle,
		    HGRenderGraphResourceType__Enum_ComputeBuffer,
		    shared,
		    0LL);
		  this->handle = v5;
		}
		
		static ComputeBufferHandle() {
			s_NullHandle = default;
		} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		public static implicit operator ComputeBuffer(ComputeBufferHandle buffer) => default; // 0x0000000189B34DA4-0x0000000189B34E34
		// ComputeBuffer op_Implicit(ComputeBufferHandle)
		ComputeBuffer *HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(
		        ComputeBufferHandle buffer,
		        MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry *current; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ComputeBufferHandle handle; // [rsp+30h] [rbp+8h] BYREF
		
		  handle = buffer;
		  if ( IFix::WrappersManagerImpl::IsPatched(285, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(285, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_139(Patch, buffer, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
		    if ( HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&handle, 0LL) )
		    {
		      current = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::get_current(0LL);
		      if ( current )
		        return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBuffer(current, &handle, 0LL);
		LABEL_7:
		      sub_1800D8260(v5, v4);
		    }
		    return 0LL;
		  }
		}
		
		public bool IsValid() => default; // 0x0000000189B34D0C-0x0000000189B34D6C
		// Boolean IsValid()
		bool HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(ComputeBufferHandle *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(286, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(286, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_135(Patch, this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    return HG::Rendering::RenderGraphModule::ResourceHandle::IsValid(&this->handle, 0LL);
		  }
		}
		
	}
}
