using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using Unity.Collections;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
	internal struct GBufferOutput
	{
		internal GBufferOutput(ref NativeArray<TextureHandle> attachments, ref NativeArray<int> gBufferMapping)
		{
			// // GBufferOutput(NativeArray`1[HG.Rendering.RenderGraphModule.TextureHandle]&, NativeArray`1[System.Int32]&)
			// void HG::Rendering::Runtime::GBufferOutput::GBufferOutput(
			//         GBufferOutput *this,
			//         NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *attachments,
			//         NativeArray_1_System_Int32_ *gBufferMapping,
			//         MethodInfo *method)
			// {
			//   this.m_attachments = *attachments;
			//   this.m_gbufferMapping = *gBufferMapping;
			// }
			// 
		}

		[IDTag(1)]
		internal TextureHandle GetGBufferAttachment(GBufferID gBufferID)
		{
			// // TextureHandle GetGBufferAttachment(GBufferID)
			// TextureHandle *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//         TextureHandle *__return_ptr retstr,
			//         GBufferOutput *this,
			//         GBufferID__Enum gBufferID,
			//         MethodInfo *method)
			// {
			//   TextureHandle *GBufferAttachment; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   TextureHandle v11; // xmm0
			//   TextureHandle *result; // rax
			//   TextureHandle v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1776, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1776, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     GBufferAttachment = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_688(&v13, Patch, this, gBufferID, 0LL);
			//   }
			//   else
			//   {
			//     GBufferAttachment = HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(&v13, this, gBufferID, 0LL);
			//   }
			//   v11 = *GBufferAttachment;
			//   result = retstr;
			//   *retstr = v11;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		internal TextureHandle GetGBufferAttachment(int index)
		{
			// // TextureHandle GetGBufferAttachment(Int32)
			// TextureHandle *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//         TextureHandle *__return_ptr retstr,
			//         GBufferOutput *this,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rsi
			//   Void *m_Buffer; // rax
			//   TextureHandle v8; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   TextureHandle *result; // rax
			//   TextureHandle v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   v5 = index;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1777, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1777, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     v8 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_687(&v13, Patch, this, v5, 0LL);
			//   }
			//   else
			//   {
			//     m_Buffer = this.m_gbufferMapping.m_Buffer;
			//     if ( *(_DWORD *)&m_Buffer[4 * v5] == -1 )
			//       v8 = 0LL;
			//     else
			//       v8 = *(TextureHandle *)&this.m_attachments.m_Buffer[16 * *(int *)&m_Buffer[4 * v5]];
			//   }
			//   result = retstr;
			//   *retstr = v8;
			//   return result;
			// }
			// 
			return null;
		}

		private NativeArray<TextureHandle> m_attachments;

		private NativeArray<int> m_gbufferMapping;
	}
}
