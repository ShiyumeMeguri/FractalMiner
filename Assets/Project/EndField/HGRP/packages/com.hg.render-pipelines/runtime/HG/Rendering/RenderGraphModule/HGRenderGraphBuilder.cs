using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	public struct HGRenderGraphBuilder : IDisposable // TypeDefIndex: 37434
	{
		// Fields
		private HGRenderGraphPass m_RenderPass; // 0x00
		private HGRenderGraphResourceRegistry m_Resources; // 0x08
		private HGRenderGraph m_RenderGraph; // 0x10
		private bool m_Disposed; // 0x18
	
		// Constructors
		internal HGRenderGraphBuilder(HGRenderGraphPass renderPass, HGRenderGraphResourceRegistry resources, HGRenderGraph renderGraph) {
			m_RenderPass = default;
			m_Resources = default;
			m_RenderGraph = default;
			m_Disposed = default;
		} // 0x0000000189B369D8-0x0000000189B36A10
		// RenderGraphBuilder(RenderGraphPass, RenderGraphResourceRegistry, RenderGraph)
		void UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphBuilder::RenderGraphBuilder(
		        RenderGraphBuilder *this,
		        RenderGraphPass *renderPass,
		        RenderGraphResourceRegistry *resources,
		        RenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int64 v5; // r10
		  __int64 v6; // r11
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Int32__Array **v10; // r9
		  __int64 v11; // r11
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  __int64 v14; // r11
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		
		  this->m_RenderPass = renderPass;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)this,
		    (Type *)renderPass,
		    (PropertyInfo_1 *)resources,
		    (Int32__Array **)renderGraph,
		    v15);
		  *(_QWORD *)(v6 + 8) = v5;
		  sub_18002D1B0((SingleFieldAccessor *)(v6 + 8), v7, v8, v9, v16);
		  *(_QWORD *)(v11 + 16) = v10;
		  sub_18002D1B0((SingleFieldAccessor *)(v11 + 16), v12, v13, v10, v17);
		  *(_BYTE *)(v14 + 24) = 0;
		}
		
	
		// Methods
		[IDTag(0)]
		public TextureHandle SetColorAttachment([IsReadOnly] in TextureHandle input, int index, uint depthSlice = 0 /* Metadata: 0x02302D5E */) => default; // 0x0000000189B363EC-0x0000000189B364D0
		// TextureHandle SetColorAttachment(TextureHandle ByRef, Int32, UInt32)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphBuilder *this,
		        TextureHandle *input,
		        int32_t index,
		        uint32_t depthSlice,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  TextureHandle v12; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v14; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(222, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(222, 0LL);
		    if ( Patch )
		    {
		      v12 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_113(
		               &v14,
		               Patch,
		               this,
		               input,
		               (DepthAccess__Enum)index,
		               depthSlice,
		               0LL);
		      goto LABEL_8;
		    }
		LABEL_6:
		    sub_1800D8260(m_Resources, Patch);
		  }
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input->handle, 1, 0LL);
		  m_Resources = this->m_Resources;
		  if ( !m_Resources )
		    goto LABEL_6;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input->handle, 0LL);
		  m_Resources = (HGRenderGraphResourceRegistry *)this->m_RenderPass;
		  if ( !this->m_RenderPass )
		    goto LABEL_6;
		  v14 = *input;
		  HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
		    (HGRenderGraphPass *)m_Resources,
		    &v14,
		    index,
		    depthSlice,
		    0LL);
		  v12 = *input;
		LABEL_8:
		  result = retstr;
		  *retstr = v12;
		  return result;
		}
		
		[IDTag(1)]
		public TextureHandle SetColorAttachment([IsReadOnly] in TextureHandle input, int index, UnityEngine.Color clearColor, uint depthSlice = 0 /* Metadata: 0x02302D5F */) => default; // 0x0000000189B364D0-0x0000000189B365EC
		// TextureHandle SetColorAttachment(TextureHandle ByRef, Int32, Color, UInt32)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphBuilder *this,
		        TextureHandle *input,
		        int32_t index,
		        Color *clearColor,
		        uint32_t depthSlice,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  Color v13; // xmm0
		  TextureHandle v14; // xmm0
		  TextureHandle *result; // rax
		  Color v16; // [rsp+40h] [rbp-28h] BYREF
		  TextureHandle v17; // [rsp+50h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(230, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(230, 0LL);
		    if ( Patch )
		    {
		      v17 = (TextureHandle)*clearColor;
		      v14 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_109(
		               (TextureHandle *)&v16,
		               Patch,
		               this,
		               input,
		               index,
		               (Color *)&v17,
		               depthSlice,
		               0LL);
		      goto LABEL_8;
		    }
		LABEL_6:
		    sub_1800D8260(m_Resources, Patch);
		  }
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input->handle, 1, 0LL);
		  m_Resources = this->m_Resources;
		  if ( !m_Resources )
		    goto LABEL_6;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input->handle, 0LL);
		  m_Resources = (HGRenderGraphResourceRegistry *)this->m_RenderPass;
		  if ( !this->m_RenderPass )
		    goto LABEL_6;
		  v13 = *clearColor;
		  v17 = *input;
		  v16 = v13;
		  HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
		    (HGRenderGraphPass *)m_Resources,
		    &v17,
		    index,
		    &v16,
		    depthSlice,
		    0LL);
		  v14 = *input;
		LABEL_8:
		  result = retstr;
		  *retstr = v14;
		  return result;
		}
		
		[IDTag(2)]
		public TextureHandle SetColorAttachment([IsReadOnly] in TextureHandle input, int index, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, UnityEngine.Color clearColor, uint depthSlice = 0 /* Metadata: 0x02302D60 */) => default; // 0x0000000189B3629C-0x0000000189B363EC
		// TextureHandle SetColorAttachment(TextureHandle ByRef, Int32, RenderBufferLoadAction, RenderBufferStoreAction, Color, UInt32)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphBuilder *this,
		        TextureHandle *input,
		        int32_t index,
		        RenderBufferLoadAction__Enum loadAction,
		        RenderBufferStoreAction__Enum storeAction,
		        Color *clearColor,
		        uint32_t depthSlice,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  TextureHandle v15; // xmm1
		  TextureHandle v16; // xmm0
		  TextureHandle *result; // rax
		  Color v18; // [rsp+50h] [rbp-28h] BYREF
		  TextureHandle v19; // [rsp+60h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(231, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(231, 0LL);
		    if ( Patch )
		    {
		      v19 = (TextureHandle)*clearColor;
		      v16 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_111(
		               (TextureHandle *)&v18,
		               Patch,
		               this,
		               input,
		               index,
		               loadAction,
		               storeAction,
		               (Color *)&v19,
		               depthSlice,
		               0LL);
		      goto LABEL_8;
		    }
		LABEL_6:
		    sub_1800D8260(m_Resources, Patch);
		  }
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input->handle, 1, 0LL);
		  m_Resources = this->m_Resources;
		  if ( !m_Resources )
		    goto LABEL_6;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input->handle, 0LL);
		  m_Resources = (HGRenderGraphResourceRegistry *)this->m_RenderPass;
		  if ( !this->m_RenderPass )
		    goto LABEL_6;
		  v15 = *input;
		  v18 = *clearColor;
		  v19 = v15;
		  HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetColorAttachment(
		    (HGRenderGraphPass *)m_Resources,
		    &v19,
		    index,
		    loadAction,
		    storeAction,
		    &v18,
		    depthSlice,
		    0LL);
		  v16 = *input;
		LABEL_8:
		  result = retstr;
		  *retstr = v16;
		  return result;
		}
		
		[IDTag(0)]
		public TextureHandle SetDepthAttachment([IsReadOnly] in TextureHandle input, DepthAccess flags, uint depthSlice = 0 /* Metadata: 0x02302D61 */) => default; // 0x0000000189B365EC-0x0000000189B366D0
		// TextureHandle SetDepthAttachment(TextureHandle ByRef, DepthAccess, UInt32)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphBuilder *this,
		        TextureHandle *input,
		        DepthAccess__Enum flags,
		        uint32_t depthSlice,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  TextureHandle v12; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v14; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(233, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(233, 0LL);
		    if ( Patch )
		    {
		      v12 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_113(&v14, Patch, this, input, flags, depthSlice, 0LL);
		      goto LABEL_8;
		    }
		LABEL_6:
		    sub_1800D8260(m_Resources, Patch);
		  }
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input->handle, 1, 0LL);
		  m_Resources = this->m_Resources;
		  if ( !m_Resources )
		    goto LABEL_6;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input->handle, 0LL);
		  m_Resources = (HGRenderGraphResourceRegistry *)this->m_RenderPass;
		  if ( !this->m_RenderPass )
		    goto LABEL_6;
		  v14 = *input;
		  HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetDepthAttachment(
		    (HGRenderGraphPass *)m_Resources,
		    &v14,
		    flags,
		    depthSlice,
		    0LL);
		  v12 = *input;
		LABEL_8:
		  result = retstr;
		  *retstr = v12;
		  return result;
		}
		
		[IDTag(1)]
		public TextureHandle SetDepthAttachment([IsReadOnly] in TextureHandle input, DepthAccess flags, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, float clearDepth, byte clearStencil, uint depthSlice = 0 /* Metadata: 0x02302D62 */) => default; // 0x0000000189B366D0-0x0000000189B36820
		// TextureHandle SetDepthAttachment(TextureHandle ByRef, DepthAccess, RenderBufferLoadAction, RenderBufferStoreAction, Single, Byte, UInt32)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphBuilder *this,
		        TextureHandle *input,
		        DepthAccess__Enum flags,
		        RenderBufferLoadAction__Enum loadAction,
		        RenderBufferStoreAction__Enum storeAction,
		        float clearDepth,
		        uint8_t clearStencil,
		        uint32_t depthSlice,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  TextureHandle v16; // xmm0
		  TextureHandle *result; // rax
		  TextureHandle v18; // [rsp+60h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(236, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(236, 0LL);
		    if ( Patch )
		    {
		      v16 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_115(
		               &v18,
		               Patch,
		               this,
		               input,
		               flags,
		               loadAction,
		               storeAction,
		               clearDepth,
		               clearStencil,
		               depthSlice,
		               0LL);
		      goto LABEL_8;
		    }
		LABEL_6:
		    sub_1800D8260(m_Resources, Patch);
		  }
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input->handle, 1, 0LL);
		  m_Resources = this->m_Resources;
		  if ( !m_Resources )
		    goto LABEL_6;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input->handle, 0LL);
		  m_Resources = (HGRenderGraphResourceRegistry *)this->m_RenderPass;
		  if ( !this->m_RenderPass )
		    goto LABEL_6;
		  v18 = *input;
		  HG::Rendering::RenderGraphModule::HGRenderGraphPass::SetDepthAttachment(
		    (HGRenderGraphPass *)m_Resources,
		    &v18,
		    flags,
		    loadAction,
		    storeAction,
		    clearDepth,
		    clearStencil,
		    depthSlice,
		    0LL);
		  v16 = *input;
		LABEL_8:
		  result = retstr;
		  *retstr = v16;
		  return result;
		}
		
		public TextureHandle ReadTexture([IsReadOnly] in TextureHandle input) => default; // 0x0000000189B35FBC-0x0000000189B361D8
		// TextureHandle ReadTexture(TextureHandle ByRef)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphBuilder *this,
		        TextureHandle *input,
		        MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry *v7; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  MethodInfo *v9; // rdx
		  TextureDesc *TextureResourceDesc; // rcx
		  __m128i v11; // xmm7
		  Quaternion *identity; // rax
		  HGRenderGraphResourceRegistry *v13; // rcx
		  TextureHandle blackTextureXR_k__BackingField; // xmm0
		  TextureDimension__Enum dimension; // eax
		  HGRenderGraph *m_RenderGraph; // r8
		  HGRenderGraphDefaultResources *v17; // rax
		  HGRenderGraphDefaultResources *v18; // rax
		  HGRenderGraphDefaultResources *defaultResources; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle *result; // rax
		  Quaternion v22[7]; // [rsp+38h] [rbp-D0h] BYREF
		  TextureDesc v23; // [rsp+A8h] [rbp-60h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(238, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(238, 0LL);
		    if ( Patch )
		    {
		      blackTextureXR_k__BackingField = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_119(
		                                          (TextureHandle *)v22,
		                                          Patch,
		                                          this,
		                                          input,
		                                          0LL);
		      goto LABEL_28;
		    }
		    goto LABEL_26;
		  }
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input->handle, 0, 0LL);
		  m_Resources = this->m_Resources;
		  if ( !m_Resources )
		    goto LABEL_26;
		  if ( HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IsRenderGraphResourceImported(
		         m_Resources,
		         &input->handle,
		         0LL) )
		  {
		    goto LABEL_12;
		  }
		  m_Resources = this->m_Resources;
		  if ( !m_Resources )
		    goto LABEL_26;
		  if ( !HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::TextureNeedsFallback(m_Resources, input, 0LL) )
		    goto LABEL_12;
		  v7 = this->m_Resources;
		  if ( !v7 )
		    goto LABEL_26;
		  TextureResourceDesc = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDesc(
		                          &v23,
		                          v7,
		                          &input->handle,
		                          0LL);
		  v11 = *(__m128i *)&TextureResourceDesc->colorFormat;
		  if ( !(unsigned __int8)*(_DWORD *)&TextureResourceDesc->bindTextureMS )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::TextureXR);
		    dimension = UnityEngine::Rendering::TextureXR::get_dimension(0LL);
		    m_RenderGraph = this->m_RenderGraph;
		    m_Resources = (HGRenderGraphResourceRegistry *)(unsigned int)_mm_cvtsi128_si32(_mm_srli_si128(v11, 12));
		    if ( (_DWORD)m_Resources == dimension )
		    {
		      if ( m_RenderGraph )
		      {
		        defaultResources = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(
		                             this->m_RenderGraph,
		                             0LL);
		        if ( defaultResources )
		        {
		          blackTextureXR_k__BackingField = defaultResources->fields._blackTextureXR_k__BackingField;
		          goto LABEL_28;
		        }
		      }
		    }
		    else if ( _mm_srli_si128(v11, 8).m128i_i32[1] == 3 )
		    {
		      if ( m_RenderGraph )
		      {
		        v18 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(this->m_RenderGraph, 0LL);
		        if ( v18 )
		        {
		          blackTextureXR_k__BackingField = v18->fields._blackTexture3DXR_k__BackingField;
		          goto LABEL_28;
		        }
		      }
		    }
		    else if ( m_RenderGraph )
		    {
		      v17 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(this->m_RenderGraph, 0LL);
		      if ( v17 )
		      {
		        blackTextureXR_k__BackingField = v17->fields._blackTexture_k__BackingField;
		        goto LABEL_28;
		      }
		    }
		LABEL_26:
		    sub_1800D8260(m_Resources, v7);
		  }
		  if ( !(unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&TextureResourceDesc->fastMemoryDesc.inFastMemory, 13)) )
		  {
		    identity = UnityEngine::Quaternion::get_identity(v22, v9);
		    if ( !this->m_Resources )
		      goto LABEL_26;
		    v13 = this->m_Resources;
		    v22[0] = *identity;
		    HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::ForceTextureClear(
		      v13,
		      &input->handle,
		      (Color *)v22,
		      0LL);
		  }
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture((TextureHandle *)v22, this, input, 0LL);
		LABEL_12:
		  m_Resources = (HGRenderGraphResourceRegistry *)this->m_RenderPass;
		  if ( !this->m_RenderPass )
		    goto LABEL_26;
		  HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceRead(
		    (HGRenderGraphPass *)m_Resources,
		    &input->handle,
		    0LL);
		  blackTextureXR_k__BackingField = *input;
		LABEL_28:
		  result = retstr;
		  *retstr = blackTextureXR_k__BackingField;
		  return result;
		}
		
		public TextureHandle WriteTexture([IsReadOnly] in TextureHandle input) => default; // 0x0000000189B36928-0x0000000189B369D8
		// TextureHandle WriteTexture(TextureHandle ByRef)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphBuilder *this,
		        TextureHandle *input,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  TextureHandle v9; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle *result; // rax
		  TextureHandle v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(246, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(246, 0LL);
		    if ( Patch )
		    {
		      v9 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_119(&v12, Patch, this, input, 0LL);
		      goto LABEL_8;
		    }
		LABEL_6:
		    sub_1800D8260(m_Resources, v7);
		  }
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input->handle, 0, 0LL);
		  m_Resources = this->m_Resources;
		  if ( !m_Resources )
		    goto LABEL_6;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input->handle, 0LL);
		  m_Resources = (HGRenderGraphResourceRegistry *)this->m_RenderPass;
		  if ( !this->m_RenderPass )
		    goto LABEL_6;
		  HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceWrite(
		    (HGRenderGraphPass *)m_Resources,
		    &input->handle,
		    0LL);
		  v9 = *input;
		LABEL_8:
		  result = retstr;
		  *retstr = v9;
		  return result;
		}
		
		public TextureHandle ReadWriteTexture([IsReadOnly] in TextureHandle input) => default; // 0x0000000189B361D8-0x0000000189B3629C
		// TextureHandle ReadWriteTexture(TextureHandle ByRef)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphBuilder *this,
		        TextureHandle *input,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  TextureHandle v9; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle *result; // rax
		  TextureHandle v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(247, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(247, 0LL);
		    if ( Patch )
		    {
		      v9 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_119(&v12, Patch, this, input, 0LL);
		      goto LABEL_9;
		    }
		LABEL_7:
		    sub_1800D8260(m_Resources, v7);
		  }
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input->handle, 0, 0LL);
		  m_Resources = this->m_Resources;
		  if ( !m_Resources )
		    goto LABEL_7;
		  HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(m_Resources, &input->handle, 0LL);
		  m_Resources = (HGRenderGraphResourceRegistry *)this->m_RenderPass;
		  if ( !this->m_RenderPass )
		    goto LABEL_7;
		  HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceWrite(
		    (HGRenderGraphPass *)m_Resources,
		    &input->handle,
		    0LL);
		  m_Resources = (HGRenderGraphResourceRegistry *)this->m_RenderPass;
		  if ( !this->m_RenderPass )
		    goto LABEL_7;
		  HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceRead(
		    (HGRenderGraphPass *)m_Resources,
		    &input->handle,
		    0LL);
		  v9 = *input;
		LABEL_9:
		  result = retstr;
		  *retstr = v9;
		  return result;
		}
		
		[IDTag(0)]
		public TextureHandle CreateTransientTexture(ref TextureDesc desc) => default; // 0x0000000189B35B48-0x0000000189B35C08
		// TextureHandle CreateTransientTexture(TextureDesc ByRef)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphBuilder *this,
		        TextureDesc *desc,
		        MethodInfo *method)
		{
		  HGRenderGraphPass *m_RenderPass; // rcx
		  HGRenderGraphResourceRegistry *m_Resources; // rdx
		  TextureHandle *Texture; // rax
		  TextureHandle v10; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle *result; // rax
		  ResourceHandle res[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(248, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(248, 0LL);
		    if ( Patch )
		    {
		      v10 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_120((TextureHandle *)res, Patch, this, desc, 0LL);
		      goto LABEL_9;
		    }
		LABEL_7:
		    sub_1800D8260(m_RenderPass, m_Resources);
		  }
		  m_Resources = this->m_Resources;
		  if ( !this->m_RenderPass )
		    goto LABEL_7;
		  if ( !m_Resources )
		    goto LABEL_7;
		  Texture = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTexture(
		              (TextureHandle *)res,
		              m_Resources,
		              desc,
		              this->m_RenderPass->fields._index_k__BackingField,
		              0LL);
		  m_RenderPass = this->m_RenderPass;
		  *(TextureHandle *)&res[0].m_Value = *Texture;
		  if ( !m_RenderPass )
		    goto LABEL_7;
		  HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddTransientResource(m_RenderPass, res, 0LL);
		  v10 = *(TextureHandle *)&res[0].m_Value;
		LABEL_9:
		  result = retstr;
		  *retstr = v10;
		  return result;
		}
		
		[IDTag(1)]
		public TextureHandle CreateTransientTexture(ref TextureHandle texture) => default; // 0x0000000189B35C08-0x0000000189B35CDC
		// TextureHandle CreateTransientTexture(TextureHandle ByRef)
		TextureHandle *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		        TextureHandle *__return_ptr retstr,
		        HGRenderGraphBuilder *this,
		        TextureHandle *texture,
		        MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry *v7; // rdx
		  void *m_Resources; // rcx
		  TextureDesc *TextureResourceDescRef; // rax
		  TextureHandle *v10; // rax
		  TextureHandle v11; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle *result; // rax
		  ResourceHandle res[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(250, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(250, 0LL);
		    if ( Patch )
		    {
		      v11 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_121((TextureHandle *)res, Patch, this, texture, 0LL);
		      goto LABEL_10;
		    }
		LABEL_8:
		    sub_1800D8260(m_Resources, v7);
		  }
		  m_Resources = this->m_Resources;
		  if ( !m_Resources )
		    goto LABEL_8;
		  TextureResourceDescRef = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetTextureResourceDescRef(
		                             (HGRenderGraphResourceRegistry *)m_Resources,
		                             &texture->handle,
		                             0LL);
		  m_Resources = this->m_RenderPass;
		  v7 = this->m_Resources;
		  if ( !this->m_RenderPass )
		    goto LABEL_8;
		  if ( !v7 )
		    goto LABEL_8;
		  v10 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateTexture(
		          (TextureHandle *)res,
		          v7,
		          TextureResourceDescRef,
		          *((_DWORD *)m_Resources + 6),
		          0LL);
		  m_Resources = this->m_RenderPass;
		  *(TextureHandle *)&res[0].m_Value = *v10;
		  if ( !m_Resources )
		    goto LABEL_8;
		  HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddTransientResource((HGRenderGraphPass *)m_Resources, res, 0LL);
		  v11 = *(TextureHandle *)&res[0].m_Value;
		LABEL_10:
		  result = retstr;
		  *retstr = v11;
		  return result;
		}
		
		public RendererListHandle UseRendererList([IsReadOnly] in RendererListHandle input) => default; // 0x0000000189B36820-0x0000000189B36898
		// RendererListHandle UseRendererList(RendererListHandle ByRef)
		RendererListHandle HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		        HGRenderGraphBuilder *this,
		        RendererListHandle *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphPass *m_RenderPass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(251, 0LL) )
		  {
		    if ( !HG::Rendering::RenderGraphModule::RendererListHandle::IsValid(input, 0LL) )
		      return *input;
		    m_RenderPass = this->m_RenderPass;
		    if ( this->m_RenderPass )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphPass::UseRendererList(m_RenderPass, *input, 0LL);
		      return *input;
		    }
		LABEL_7:
		    sub_1800D8260(m_RenderPass, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(251, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_123(Patch, this, input, 0LL);
		}
		
		public ComputeBufferHandle ReadComputeBuffer([IsReadOnly] in ComputeBufferHandle input) => default; // 0x0000000189B35F40-0x0000000189B35FBC
		// ComputeBufferHandle ReadComputeBuffer(ComputeBufferHandle ByRef)
		ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadComputeBuffer(
		        HGRenderGraphBuilder *this,
		        ComputeBufferHandle *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphPass *m_RenderPass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(253, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input->handle, 0, 0LL);
		    m_RenderPass = this->m_RenderPass;
		    if ( this->m_RenderPass )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceRead(m_RenderPass, &input->handle, 0LL);
		      return *input;
		    }
		LABEL_5:
		    sub_1800D8260(m_RenderPass, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(253, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_124(Patch, this, input, 0LL);
		}
		
		public ComputeBufferHandle WriteComputeBuffer([IsReadOnly] in ComputeBufferHandle input) => default; // 0x0000000189B36898-0x0000000189B36928
		// ComputeBufferHandle WriteComputeBuffer(ComputeBufferHandle ByRef)
		ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(
		        HGRenderGraphBuilder *this,
		        ComputeBufferHandle *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphPass *m_RenderPass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(254, 0LL) )
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(this, &input->handle, 0, 0LL);
		    m_RenderPass = this->m_RenderPass;
		    if ( this->m_RenderPass )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddResourceWrite(m_RenderPass, &input->handle, 0LL);
		      m_RenderPass = (HGRenderGraphPass *)this->m_Resources;
		      if ( m_RenderPass )
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::IncrementWriteCount(
		          (HGRenderGraphResourceRegistry *)m_RenderPass,
		          &input->handle,
		          0LL);
		        return *input;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(m_RenderPass, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(254, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_124(Patch, this, input, 0LL);
		}
		
		[IDTag(0)]
		public ComputeBufferHandle CreateTransientComputeBuffer([IsReadOnly] in ComputeBufferDesc desc) => default; // 0x0000000189B35AB4-0x0000000189B35B48
		// ComputeBufferHandle CreateTransientComputeBuffer(ComputeBufferDesc ByRef)
		ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientComputeBuffer(
		        HGRenderGraphBuilder *this,
		        ComputeBufferDesc *desc,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphResourceRegistry *m_Resources; // rcx
		  ComputeBufferHandle ComputeBuffer; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ResourceHandle res; // [rsp+48h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(255, 0LL) )
		  {
		    m_Resources = this->m_Resources;
		    if ( this->m_RenderPass )
		    {
		      if ( m_Resources )
		      {
		        ComputeBuffer = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateComputeBuffer(
		                          m_Resources,
		                          desc,
		                          this->m_RenderPass->fields._index_k__BackingField,
		                          0LL);
		        m_Resources = (HGRenderGraphResourceRegistry *)this->m_RenderPass;
		        res = ComputeBuffer.handle;
		        if ( m_Resources )
		        {
		          HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddTransientResource(
		            (HGRenderGraphPass *)m_Resources,
		            &res,
		            0LL);
		          return (ComputeBufferHandle)res;
		        }
		      }
		    }
		LABEL_7:
		    sub_1800D8260(m_Resources, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(255, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_125(Patch, this, desc, 0LL);
		}
		
		[IDTag(1)]
		public ComputeBufferHandle CreateTransientComputeBuffer([IsReadOnly] in ComputeBufferHandle computebuffer) => default; // 0x0000000189B359F0-0x0000000189B35AB4
		// ComputeBufferHandle CreateTransientComputeBuffer(ComputeBufferHandle ByRef)
		ComputeBufferHandle HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientComputeBuffer(
		        HGRenderGraphBuilder *this,
		        ComputeBufferHandle *computebuffer,
		        MethodInfo *method)
		{
		  HGRenderGraphResourceRegistry *v5; // rcx
		  HGRenderGraphResourceRegistry *m_Resources; // rdx
		  ComputeBufferDesc *ComputeBufferResourceDesc; // rax
		  HGRenderGraphPass *m_RenderPass; // r8
		  ComputeBufferHandle v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ComputeBufferDesc desc; // [rsp+20h] [rbp-38h] BYREF
		  ComputeBufferDesc v13; // [rsp+38h] [rbp-20h] BYREF
		  ResourceHandle res; // [rsp+78h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(256, 0LL) )
		  {
		    m_Resources = this->m_Resources;
		    if ( m_Resources )
		    {
		      ComputeBufferResourceDesc = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::GetComputeBufferResourceDesc(
		                                    &v13,
		                                    m_Resources,
		                                    &computebuffer->handle,
		                                    0LL);
		      m_RenderPass = this->m_RenderPass;
		      v5 = this->m_Resources;
		      desc = *ComputeBufferResourceDesc;
		      if ( m_RenderPass )
		      {
		        if ( v5 )
		        {
		          v9 = HG::Rendering::RenderGraphModule::HGRenderGraphResourceRegistry::CreateComputeBuffer(
		                 v5,
		                 &desc,
		                 m_RenderPass->fields._index_k__BackingField,
		                 0LL);
		          v5 = (HGRenderGraphResourceRegistry *)this->m_RenderPass;
		          res = v9.handle;
		          if ( v5 )
		          {
		            HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddTransientResource(
		              (HGRenderGraphPass *)v5,
		              &res,
		              0LL);
		            return (ComputeBufferHandle)res;
		          }
		        }
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v5, m_Resources);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(256, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_124(Patch, this, computebuffer, 0LL);
		}
		
		public void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc, object camera = null, int funcIndex = 0 /* Metadata: 0x02302D63 */)
			where PassData : class, new() {}
		public unsafe void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc, object camera, void* customPayload, int funcIndex = 0 /* Metadata: 0x02302D64 */)
			where PassData : class, new() {}
		public void SetPreRenderPassFunc<PassData>(RenderFunc<PassData> renderFunc)
			where PassData : class, new() {}
		public void SetPostRenderPassFunc<PassData>(RenderFunc<PassData> renderFunc)
			where PassData : class, new() {}
		public void SetupSubpass<PassData>(int subpassIndex, NativeArray<int> colorRTIndices, RenderFunc<PassData> renderFunc, ProfilingHGPass profilingHgPass)
			where PassData : class, new() {}
		public unsafe void SetupSubpass<PassData>(int subpassIndex, NativeArray<int> colorRTIndices, RenderFunc<PassData> renderFunc, ProfilingHGPass profilingHgPass, object camera, void* customPayload)
			where PassData : class, new() {}
		public void SetupSubpass<PassData>(int subpassIndex, NativeArray<int> colorRTIndices, NativeArray<int> inputRTIndices, bool depthAsInput, RenderFunc<PassData> renderFunc, ProfilingHGPass profilingHgPass, object camera = null)
			where PassData : class, new() {}
		public unsafe void SetupSubpass<PassData>(int subpassIndex, NativeArray<int> colorRTIndices, NativeArray<int> inputRTIndices, bool depthAsInput, RenderFunc<PassData> renderFunc, ProfilingHGPass profilingHgPass, object camera, void* customPayload)
			where PassData : class, new() {}
		public void SetupRenderFunc<PassData>(int funcIndex, RenderFunc<PassData> renderFunc)
			where PassData : class, new() {}
		public unsafe void SetupRenderFunc<PassData>(int funcIndex, RenderFunc<PassData> renderFunc, object camera, void* customPayload)
			where PassData : class, new() {}
		public void SetupRenderFunc<PassData>(int subpassIndex, int funcIndex, RenderFunc<PassData> renderFunc)
			where PassData : class, new() {}
		public unsafe void SetupRenderFunc<PassData>(int subpassIndex, int funcIndex, RenderFunc<PassData> renderFunc, object camera, void* customPayload)
			where PassData : class, new() {}
		public void AddChildPass(HGRenderGraphBuilder builder) {} // 0x0000000189B35838-0x0000000189B358B8
		// Void AddChildPass(HGRenderGraphBuilder)
		void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AddChildPass(
		        HGRenderGraphBuilder *this,
		        HGRenderGraphBuilder *builder,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphPass *m_RenderPass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v8; // xmm1
		  HGRenderGraphBuilder v9; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(257, 0LL) )
		  {
		    m_RenderPass = this->m_RenderPass;
		    if ( this->m_RenderPass )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphPass::AddChildPass(m_RenderPass, builder->m_RenderPass, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_RenderPass, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(257, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v8 = *(_OWORD *)&builder->m_RenderGraph;
		  *(_OWORD *)&v9.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		  *(_OWORD *)&v9.m_RenderGraph = v8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_126(Patch, this, &v9, 0LL);
		}
		
		public void EnableAsyncCompute(bool value) {} // 0x0000000189B35E70-0x0000000189B35ED8
		// Void EnableAsyncCompute(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::EnableAsyncCompute(
		        HGRenderGraphBuilder *this,
		        bool value,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphPass *m_RenderPass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(259, 0LL) )
		  {
		    m_RenderPass = this->m_RenderPass;
		    if ( this->m_RenderPass )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphPass::EnableAsyncCompute(m_RenderPass, value, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_RenderPass, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(259, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_94(Patch, this, value, 0LL);
		}
		
		public void AllowPassCulling(bool value) {} // 0x0000000189B358B8-0x0000000189B35920
		// Void AllowPassCulling(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(
		        HGRenderGraphBuilder *this,
		        bool value,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphPass *m_RenderPass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(201, 0LL) )
		  {
		    m_RenderPass = this->m_RenderPass;
		    if ( this->m_RenderPass )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphPass::AllowPassCulling(m_RenderPass, value, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_RenderPass, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(201, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_94(Patch, this, value, 0LL);
		}
		
		[IDTag(1)]
		public void Dispose() {} // 0x0000000189B35DA4-0x0000000189B35DFC
		// Void Dispose()
		void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::Dispose(HGRenderGraphBuilder *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(207, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(207, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_98(Patch, this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::Dispose(this, 1, 0LL);
		  }
		}
		
		public void AllowRendererListCulling(bool value) {} // 0x0000000189B35920-0x0000000189B35988
		// Void AllowRendererListCulling(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowRendererListCulling(
		        HGRenderGraphBuilder *this,
		        bool value,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphPass *m_RenderPass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(262, 0LL) )
		  {
		    m_RenderPass = this->m_RenderPass;
		    if ( this->m_RenderPass )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphPass::AllowRendererListCulling(m_RenderPass, value, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_RenderPass, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(262, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_94(Patch, this, value, 0LL);
		}
		
		public RendererListHandle DependsOn([IsReadOnly] in RendererListHandle input) => default; // 0x0000000189B35CDC-0x0000000189B35D48
		// RendererListHandle DependsOn(RendererListHandle ByRef)
		RendererListHandle HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::DependsOn(
		        HGRenderGraphBuilder *this,
		        RendererListHandle *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphPass *m_RenderPass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(265, 0LL) )
		  {
		    m_RenderPass = this->m_RenderPass;
		    if ( this->m_RenderPass )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphPass::UseRendererList(m_RenderPass, *input, 0LL);
		      return *input;
		    }
		LABEL_5:
		    sub_1800D8260(m_RenderPass, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(265, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_123(Patch, this, input, 0LL);
		}
		
		public bool DepthRequiredIfMRT() => default; // 0x0000000189B35D48-0x0000000189B35DA4
		// Boolean DepthRequiredIfMRT()
		bool HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::DepthRequiredIfMRT(
		        HGRenderGraphBuilder *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rcx
		  HGRenderGraphPass *m_RenderPass; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(266, 0LL) )
		  {
		    m_RenderPass = this->m_RenderPass;
		    if ( this->m_RenderPass )
		      return sub_180006280(9LL, m_RenderPass);
		LABEL_5:
		    sub_1800D8260(v3, m_RenderPass);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(266, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_127(Patch, this, 0LL);
		}
		
		[IDTag(0)]
		private void Dispose(bool disposing) {} // 0x0000000189B35DFC-0x0000000189B35E70
		// Void Dispose(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::Dispose(
		        HGRenderGraphBuilder *this,
		        bool disposing,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraph *m_RenderGraph; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(208, 0LL) )
		  {
		    if ( this->m_Disposed )
		      return;
		    m_RenderGraph = this->m_RenderGraph;
		    if ( m_RenderGraph )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraph::OnPassAdded(m_RenderGraph, this->m_RenderPass, 0LL);
		      this->m_Disposed = 1;
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(m_RenderGraph, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(208, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_94(Patch, this, disposing, 0LL);
		}
		
		private void CheckResource([IsReadOnly] in ResourceHandle res, bool dontCheckTransientReadWrite = false /* Metadata: 0x02302D65 */) {} // 0x0000000189B35988-0x0000000189B359F0
		// Void CheckResource(ResourceHandle ByRef, Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CheckResource(
		        HGRenderGraphBuilder *this,
		        ResourceHandle *res,
		        bool dontCheckTransientReadWrite,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(223, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(223, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_104(Patch, this, res, dontCheckTransientReadWrite, 0LL);
		  }
		}
		
		internal void GenerateDebugData(bool value) {} // 0x0000000189B35ED8-0x0000000189B35F40
		// Void GenerateDebugData(Boolean)
		void HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::GenerateDebugData(
		        HGRenderGraphBuilder *this,
		        bool value,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderGraphPass *m_RenderPass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(204, 0LL) )
		  {
		    m_RenderPass = this->m_RenderPass;
		    if ( this->m_RenderPass )
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphPass::GenerateDebugData(m_RenderPass, value, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_RenderPass, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(204, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_94(Patch, this, value, 0LL);
		}
		
	}
}
