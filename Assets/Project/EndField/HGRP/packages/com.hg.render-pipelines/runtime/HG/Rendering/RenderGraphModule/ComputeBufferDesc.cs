using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.RenderGraphModule
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
	public struct ComputeBufferDesc
	{
		public ComputeBufferDesc(int count, int stride)
		{
			// // ComputeBufferDesc(Int32, Int32)
			// void UnityEngine::Experimental::Rendering::RenderGraphModule::ComputeBufferDesc::ComputeBufferDesc(
			//         ComputeBufferDesc_1 *this,
			//         int32_t count,
			//         int32_t stride,
			//         MethodInfo *method)
			// {
			//   *(_QWORD *)(&this.type + 1) = 0LL;
			//   HIDWORD(this.name) = 0;
			//   this.count = count;
			//   this.stride = stride;
			//   this.type = 0;
			// }
			// 
		}

		public ComputeBufferDesc(int count, int stride, ComputeBufferType type)
		{
			// // ComputeBufferDesc(Int32, Int32, ComputeBufferType)
			// void UnityEngine::Experimental::Rendering::RenderGraphModule::ComputeBufferDesc::ComputeBufferDesc(
			//         ComputeBufferDesc_1 *this,
			//         int32_t count,
			//         int32_t stride,
			//         ComputeBufferType__Enum type,
			//         MethodInfo *method)
			// {
			//   *(_QWORD *)(&this.type + 1) = 0LL;
			//   HIDWORD(this.name) = 0;
			//   this.count = count;
			//   this.stride = stride;
			//   this.type = type;
			// }
			// 
		}

		public override int GetHashCode()
		{
			// // Int32 GetHashCode()
			// int32_t HG::Rendering::RenderGraphModule::ComputeBufferDesc::GetHashCode(ComputeBufferDesc *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(283, 0LL) )
			//     return this.type + 23 * (this.stride + 23 * (this.count + 391));
			//   Patch = IFix::WrappersManagerImpl::GetPatch(283, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_135(Patch, this, 0LL);
			// }
			// 
			return 0;
		}

		public int <>iFixBaseProxy_GetHashCode()
		{
			// // Int32 <>iFixBaseProxy_GetHashCode()
			// int32_t HG::Rendering::RenderGraphModule::ComputeBufferDesc::__iFixBaseProxy_GetHashCode(
			//         ComputeBufferDesc *this,
			//         MethodInfo *method)
			// {
			//   __int64 v2; // r8
			//   String *name; // xmm1_8
			//   ValueType *v5; // rax
			//   __int128 v7; // [rsp+20h] [rbp-28h] BYREF
			//   String *v8; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D91936C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferDesc);
			//     byte_18D91936C = 1;
			//   }
			//   name = this.name;
			//   v7 = *(_OWORD *)&this.count;
			//   v8 = name;
			//   v5 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferDesc, &v7, v2);
			//   return System::ValueType::GetHashCode(v5, 0LL);
			// }
			// 
			return 0;
		}

		public int count;

		public int stride;

		public ComputeBufferType type;

		public string name;
	}
}
