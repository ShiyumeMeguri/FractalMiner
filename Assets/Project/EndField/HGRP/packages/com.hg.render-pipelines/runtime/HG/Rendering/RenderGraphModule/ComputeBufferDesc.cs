using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	public struct ComputeBufferDesc // TypeDefIndex: 37451
	{
		// Fields
		public int count; // 0x00
		public int stride; // 0x04
		public ComputeBufferType type; // 0x08
		public string name; // 0x10
	
		// Constructors
		public ComputeBufferDesc(int count, int stride) {
			this.count = default;
			this.stride = default;
			type = default;
			name = default;
		} // 0x0000000184DA11E0-0x0000000184DA1200
		// ComputeBufferDesc(Int32, Int32)
		void UnityEngine::Experimental::Rendering::RenderGraphModule::ComputeBufferDesc::ComputeBufferDesc(
		        ComputeBufferDesc_1 *this,
		        int32_t count,
		        int32_t stride,
		        MethodInfo *method)
		{
		  *(_QWORD *)(&this->type + 1) = 0LL;
		  HIDWORD(this->name) = 0;
		  this->count = count;
		  this->stride = stride;
		  this->type = 0;
		}
		
		public ComputeBufferDesc(int count, int stride, ComputeBufferType type) {
			this.count = default;
			this.stride = default;
			this.type = default;
			name = default;
		} // 0x0000000184DA11C0-0x0000000184DA11E0
		// ComputeBufferDesc(Int32, Int32, ComputeBufferType)
		void UnityEngine::Experimental::Rendering::RenderGraphModule::ComputeBufferDesc::ComputeBufferDesc(
		        ComputeBufferDesc_1 *this,
		        int32_t count,
		        int32_t stride,
		        ComputeBufferType__Enum type,
		        MethodInfo *method)
		{
		  *(_QWORD *)(&this->type + 1) = 0LL;
		  HIDWORD(this->name) = 0;
		  this->count = count;
		  this->stride = stride;
		  this->type = type;
		}
		
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189B34C78-0x0000000189B34CD4
		// Int32 GetHashCode()
		int32_t HG::Rendering::RenderGraphModule::ComputeBufferDesc::GetHashCode(ComputeBufferDesc *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(290, 0LL) )
		    return this->type + 23 * (this->stride + 23 * (this->count + 391));
		  Patch = IFix::WrappersManagerImpl::GetPatch(290, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_140(Patch, this, 0LL);
		}
		
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000189B34CD4-0x0000000189B34D0C
		// Int32 <>iFixBaseProxy_GetHashCode()
		int32_t HG::Rendering::RenderGraphModule::ComputeBufferDesc::__iFixBaseProxy_GetHashCode(
		        ComputeBufferDesc *this,
		        MethodInfo *method)
		{
		  String *name; // xmm1_8
		  ValueType *v3; // rax
		  __int128 v5; // [rsp+20h] [rbp-28h] BYREF
		  String *v6; // [rsp+30h] [rbp-18h]
		
		  name = this->name;
		  v5 = *(_OWORD *)&this->count;
		  v6 = name;
		  v3 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferDesc, &v5);
		  return System::ValueType::GetHashCode(v3, 0LL);
		}
		
	}
}
