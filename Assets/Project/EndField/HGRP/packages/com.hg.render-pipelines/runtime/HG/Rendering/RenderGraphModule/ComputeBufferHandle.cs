using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("ComputeBuffer ({handle.index})")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
	public struct ComputeBufferHandle
	{
		// (get) Token: 0x0600026C RID: 620 RVA: 0x000025D2 File Offset: 0x000007D2
		public static ComputeBufferHandle nullHandle
		{
			get
			{
				// // ComputeBufferHandle get_nullHandle()
				// ComputeBufferHandle HG::Rendering::RenderGraphModule::ComputeBufferHandle::get_nullHandle(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct ComputeBufferHandle__Class *v2; // rax
				// 
				//   if ( !byte_18D919369 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
				//     byte_18D919369 = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle;
				//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle, v1);
				//     v2 = TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle;
				//   }
				//   return v2.static_fields.s_NullHandle;
				// }
				// 
				return null;
			}
		}

		internal ComputeBufferHandle(int handle, [MetadataOffset(Offset = "0x01F90A00")] bool shared = false)
		{
			// // ComputeBufferHandle(Int32, Boolean)
			// void HG::Rendering::RenderGraphModule::ComputeBufferHandle::ComputeBufferHandle(
			//         ComputeBufferHandle *this,
			//         int32_t handle,
			//         bool shared,
			//         MethodInfo *method)
			// {
			//   ResourceHandle v5; // [rsp+40h] [rbp+8h] BYREF
			// 
			//   v5 = 0LL;
			//   HG::Rendering::RenderGraphModule::ResourceHandle::ResourceHandle(
			//     &v5,
			//     handle,
			//     HGRenderGraphResourceType__Enum_ComputeBuffer,
			//     shared,
			//     0LL);
			//   this.handle = v5;
			// }
			// 
		}

		public static implicit operator ComputeBuffer(ComputeBufferHandle buffer)
		{
			// // ComputeBuffer op_Implicit(ComputeBufferHandle)
			// ComputeBuffer *HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(
			//         ComputeBufferHandle buffer,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ComputeBufferHandle handle; // [rsp+30h] [rbp+8h] BYREF
			// 
			//   handle = buffer;
			//   if ( !byte_18D91936A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//     byte_18D91936A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(279, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(279, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_134(Patch, buffer, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//     if ( HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(&handle, 0LL) )
			//     {
			//       v3 = (HGRenderGraphResourceRegistry *)sub_1885A7CFC();
			//       if ( v3 )
			//         return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBuffer(v3, &handle, 0LL);
			// LABEL_9:
			//       sub_180B536AC(v5, v4);
			//     }
			//     return 0LL;
			//   }
			// }
			// 
			return null;
		}

		public bool IsValid()
		{
			// // Boolean IsValid()
			// bool HG::Rendering::RenderGraphModule::ComputeBufferHandle::IsValid(ComputeBufferHandle *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D91936B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D91936B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(280, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(280, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_131(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     return HG::Rendering::RenderGraphModule::ResourceHandle::IsValid(&this.handle, 0LL);
			//   }
			// }
			// 
			return default(bool);
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static ComputeBufferHandle s_NullHandle;

		internal ResourceHandle handle;
	}
}
