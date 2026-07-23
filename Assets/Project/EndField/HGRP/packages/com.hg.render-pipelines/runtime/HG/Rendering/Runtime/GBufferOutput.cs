using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using Unity.Collections;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal struct GBufferOutput // TypeDefIndex: 38115
	{
		// Fields
		private NativeArray<TextureHandle> m_attachments; // 0x00
		private NativeArray<int> m_gbufferMapping; // 0x10
	
		// Constructors
		internal GBufferOutput(ref NativeArray<TextureHandle> attachments, ref NativeArray<int> gBufferMapping) {
			m_attachments = default;
			m_gbufferMapping = default;
		} // 0x0000000184DA1780-0x0000000184DA1790
		// GBufferOutput(NativeArray`1[HG.Rendering.RenderGraphModule.TextureHandle]&, NativeArray`1[System.Int32]&)
		void HG::Rendering::Runtime::GBufferOutput::GBufferOutput(
		        GBufferOutput *this,
		        NativeArray_1_HG_Rendering_RenderGraphModule_TextureHandle_ *attachments,
		        NativeArray_1_System_Int32_ *gBufferMapping,
		        MethodInfo *method)
		{
		  this->m_attachments = *attachments;
		  this->m_gbufferMapping = *gBufferMapping;
		}
		
	
		// Methods
		[IDTag(1)]
		internal TextureHandle GetGBufferAttachment(GBufferID gBufferID) => default; // 0x0000000189B762AC-0x0000000189B76334
		// TextureHandle GetGBufferAttachment(GBufferID)
		TextureHandle *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		        TextureHandle *__return_ptr retstr,
		        GBufferOutput *this,
		        GBufferID__Enum gBufferID,
		        MethodInfo *method)
		{
		  TextureHandle *GBufferAttachment; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  TextureHandle v11; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2099, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2099, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    GBufferAttachment = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_844(&v13, Patch, this, gBufferID, 0LL);
		  }
		  else
		  {
		    GBufferAttachment = HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(&v13, this, gBufferID, 0LL);
		  }
		  v11 = *GBufferAttachment;
		  result = retstr;
		  *retstr = v11;
		  return result;
		}
		
		[IDTag(0)]
		internal TextureHandle GetGBufferAttachment(int index) => default; // 0x0000000189B76218-0x0000000189B762AC
		// TextureHandle GetGBufferAttachment(Int32)
		TextureHandle *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
		        TextureHandle *__return_ptr retstr,
		        GBufferOutput *this,
		        int32_t index,
		        MethodInfo *method)
		{
		  __int64 v5; // rsi
		  Void *m_Buffer; // rax
		  TextureHandle v8; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v13; // [rsp+30h] [rbp-18h] BYREF
		
		  v5 = index;
		  if ( IFix::WrappersManagerImpl::IsPatched(2100, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2100, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    v8 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_844(&v13, Patch, this, (GBufferID__Enum)v5, 0LL);
		  }
		  else
		  {
		    m_Buffer = this->m_gbufferMapping.m_Buffer;
		    if ( *(_DWORD *)&m_Buffer[4 * v5] == -1 )
		      v8 = 0LL;
		    else
		      v8 = *(TextureHandle *)&this->m_attachments.m_Buffer[16 * *(int *)&m_Buffer[4 * v5]];
		  }
		  result = retstr;
		  *retstr = v8;
		  return result;
		}
		
	}
}
