using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Texture ({handle.index})")]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	public struct TextureHandle
	{
		// (get) Token: 0x0600030A RID: 778 RVA: 0x000025D2 File Offset: 0x000007D2
		public static TextureHandle nullHandle
		{
			get
			{
				// // TextureHandle get_nullHandle()
				// TextureHandle *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
				//         TextureHandle *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   struct TextureHandle__Class *v3; // rax
				//   TextureHandle s_NullHandle; // xmm0
				//   TextureHandle *result; // rax
				// 
				//   if ( !byte_18D9193AE )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//     byte_18D9193AE = 1;
				//   }
				//   v3 = TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle;
				//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, method);
				//     v3 = TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle;
				//   }
				//   s_NullHandle = v3.static_fields.s_NullHandle;
				//   result = retstr;
				//   *retstr = s_NullHandle;
				//   return result;
				// }
				// 
				return null;
			}
		}

		internal TextureHandle(int handle, [MetadataOffset(Offset = "0x01F90A22")] bool shared = false)
		{
			// // TextureHandle(Int32, Boolean)
			// void HG::Rendering::RenderGraphModule::TextureHandle::TextureHandle(
			//         TextureHandle *this,
			//         int32_t handle,
			//         bool shared,
			//         MethodInfo *method)
			// {
			//   ResourceHandle v7; // [rsp+40h] [rbp+8h] BYREF
			// 
			//   if ( !byte_18D9193AF )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D9193AF = 1;
			//   }
			//   v7 = 0LL;
			//   HG::Rendering::RenderGraphModule::ResourceHandle::ResourceHandle(
			//     &v7,
			//     handle,
			//     HGRenderGraphResourceType__Enum_Texture,
			//     shared,
			//     0LL);
			//   this.handle = v7;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   this.fallBackResource = TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle.static_fields.s_NullHandle.handle;
			// }
			// 
		}

		[IDTag(0)]
		public static implicit operator RenderTargetIdentifier(TextureHandle texture)
		{
			// // RenderTargetIdentifier op_Implicit(TextureHandle)
			// RenderTargetIdentifier *HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
			//         RenderTargetIdentifier *__return_ptr retstr,
			//         TextureHandle *texture,
			//         MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   RTHandle *v8; // rax
			//   RenderTargetIdentifier *v9; // rax
			//   __int64 v10; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v12; // xmm1
			//   TextureHandle v14; // [rsp+20h] [rbp-48h] BYREF
			//   RenderTargetIdentifier v15; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9193B0 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D9193B0 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(313, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(313, 0LL);
			//     if ( Patch )
			//     {
			//       v14 = *texture;
			//       v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_144(&v15, Patch, &v14, 0LL);
			//       goto LABEL_11;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v7, v6);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(texture, 0LL) )
			//   {
			//     v5 = (HGRenderGraphResourceRegistry *)sub_1885A7CFC();
			//     if ( v5 )
			//     {
			//       v8 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTexture(v5, texture, 0LL);
			//       v9 = UnityEngine::Rendering::RTHandle::op_Implicit(&v15, v8, 0LL);
			// LABEL_11:
			//       v12 = *(_OWORD *)&v9.m_BufferPointer;
			//       *(_OWORD *)&retstr.m_Type = *(_OWORD *)&v9.m_Type;
			//       v10 = *(_QWORD *)&v9.m_DepthSlice;
			//       *(_OWORD *)&retstr.m_BufferPointer = v12;
			//       goto LABEL_12;
			//     }
			//     goto LABEL_9;
			//   }
			//   *(_OWORD *)&retstr.m_Type = 0LL;
			//   *(_QWORD *)&v15.m_DepthSlice = 0LL;
			//   *(_OWORD *)&retstr.m_BufferPointer = 0LL;
			//   v10 = *(_QWORD *)&v15.m_DepthSlice;
			// LABEL_12:
			//   *(_QWORD *)&retstr.m_DepthSlice = v10;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static implicit operator Texture(TextureHandle texture)
		{
			// // Texture op_Implicit(TextureHandle)
			// Texture *HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(TextureHandle *texture, MethodInfo *method)
			// {
			//   RTHandle *v2; // rbx
			//   HGRenderGraphResourceRegistry *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v9; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   v2 = 0LL;
			//   if ( !byte_18D9193B1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D9193B1 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(314, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(texture, 0LL) )
			//       return UnityEngine::Rendering::RTHandle::op_Implicit(v2, 0LL);
			//     v4 = (HGRenderGraphResourceRegistry *)sub_1885A7CFC();
			//     if ( v4 )
			//     {
			//       v2 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTexture(v4, texture, 0LL);
			//       return UnityEngine::Rendering::RTHandle::op_Implicit(v2, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(314, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   v9 = *texture;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_145(Patch, &v9, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static implicit operator RenderTexture(TextureHandle texture)
		{
			// // RenderTexture op_Implicit(TextureHandle)
			// RenderTexture *HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(TextureHandle *texture, MethodInfo *method)
			// {
			//   RenderTexture *v2; // rbx
			//   HGRenderGraphResourceRegistry *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   RTHandle *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   v2 = 0LL;
			//   if ( !byte_18D9193B2 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D9193B2 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(315, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(texture, 0LL) )
			//       return v2;
			//     v4 = (HGRenderGraphResourceRegistry *)sub_1885A7CFC();
			//     if ( v4 )
			//     {
			//       v7 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTexture(v4, texture, 0LL);
			//       if ( v7 )
			//         return v7.fields.m_RT;
			//       return v2;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(315, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   v10 = *texture;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_146(Patch, &v10, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(3)]
		public static implicit operator RTHandle(TextureHandle texture)
		{
			// // RTHandle op_Implicit(TextureHandle)
			// RTHandle *HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(TextureHandle *texture, MethodInfo *method)
			// {
			//   HGRenderGraphResourceRegistry *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v8; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9193B3 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D9193B3 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(316, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(316, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     v8 = *texture;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_147(Patch, &v8, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(texture, 0LL) )
			//     {
			//       v3 = (HGRenderGraphResourceRegistry *)sub_1885A7CFC();
			//       if ( v3 )
			//         return HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTexture(v3, texture, 0LL);
			// LABEL_9:
			//       sub_180B536AC(v5, v4);
			//     }
			//     return 0LL;
			//   }
			// }
			// 
			return null;
		}

		public readonly bool IsValid()
		{
			// // Boolean IsValid()
			// bool HG::Rendering::RenderGraphModule::TextureHandle::IsValid(TextureHandle *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9193B4 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
			//     byte_18D9193B4 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(150, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(150, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_72(Patch, this, 0LL);
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

		public void SetFallBackResource(TextureHandle texture)
		{
			// // Void SetFallBackResource(TextureHandle)
			// void HG::Rendering::RenderGraphModule::TextureHandle::SetFallBackResource(
			//         TextureHandle *this,
			//         TextureHandle *texture,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   TextureHandle v8; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(317, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(317, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = *texture;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_148(Patch, this, &v8, 0LL);
			//   }
			//   else
			//   {
			//     this.fallBackResource = texture.handle;
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static TextureHandle s_NullHandle;

		internal ResourceHandle handle;

		internal ResourceHandle fallBackResource;
	}
}
