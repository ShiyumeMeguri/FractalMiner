using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class DepthPyramidLDSRenderingPass // TypeDefIndex: 38239
	{
		// Fields
		private ComputeShader m_computeShader; // 0x10
		private TextureHandle m_depthPyramidTexture; // 0x18
	
		// Properties
		public TextureHandle depthPyramidTexture { get => default; } // 0x0000000189BA4430-0x0000000189BA4498 
		// TextureHandle get_depthPyramidTexture()
		TextureHandle *HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::get_depthPyramidTexture(
		        TextureHandle *__return_ptr retstr,
		        DepthPyramidLDSRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_depthPyramidTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3099, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3099, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_depthPyramidTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_depthPyramidTexture = this->fields.m_depthPyramidTexture;
		  }
		  result = retstr;
		  *retstr = m_depthPyramidTexture;
		  return result;
		}
		
	
		// Nested types
		private class PassData // TypeDefIndex: 38237
		{
			// Fields
			public int maxMip; // 0x10
			public Vector2Int depthTextureSize; // 0x14
			public Vector2Int depthPyramidTextureSize; // 0x1C
			public TextureHandle depthTexture; // 0x24
			public TextureHandle depthPyramidTexture; // 0x34
			public ComputeBufferHandle globalAtomicBuffer; // 0x44
			public ComputeShader computeShader; // 0x50
	
			// Constructors
			public PassData() {} // 0x00000001841E1670-0x00000001841E1680
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
			
		}
	
		// Constructors
		public DepthPyramidLDSRenderingPass() {} // Dummy constructor
		public DepthPyramidLDSRenderingPass(HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDACC0-0x0000000182EDAD30
		// DepthPyramidCustomMipsRenderingPass(HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::DepthPyramidCustomMipsRenderingPass(
		        DepthPyramidCustomMipsRenderingPass *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  __int64 v6; // rcx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  TextureHandle v9; // xmm0
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  TextureHandle v12; // [rsp+20h] [rbp-18h] BYREF
		  MethodInfo *v13; // [rsp+60h] [rbp+28h]
		
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  v9 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v12, 0LL);
		  defaultResources = resources->defaultResources;
		  this->fields.m_depthPyramidTexture = v9;
		  if ( !defaultResources || (shaders = defaultResources->fields.shaders) == 0LL )
		    sub_1800D8260(v6, v5);
		  this->fields.m_computeShader = shaders->fields.depthPyramidCS;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v5, v7, v8, v13);
		}
		
	
		// Methods
		public void Render(HGRenderGraph renderGraph, TextureHandle depthTexture, Vector2Int depthTextureSize) {} // 0x0000000189BA3E2C-0x0000000189BA4430
		// Void Render(HGRenderGraph, TextureHandle, Vector2Int)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::Render(
		        DepthPyramidLDSRenderingPass *this,
		        HGRenderGraph *renderGraph,
		        TextureHandle *depthTexture,
		        Vector2Int depthTextureSize,
		        MethodInfo *method)
		{
		  ProfilingSampler *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Object *v12; // rdi
		  char v13; // dl
		  __int64 v14; // rcx
		  int v15; // r8d
		  int v16; // eax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  Object *v19; // rdi
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  TextureHandle v22; // xmm0
		  __int64 v23; // rdx
		  Object *v24; // rcx
		  int32_t monitor_high; // edi
		  int32_t klass; // ebx
		  __int128 v27; // xmm2
		  __int128 v28; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v30; // r8
		  signed __int64 v31; // rtt
		  Object *v32; // rdi
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  TextureHandle v35; // xmm0
		  Object *v36; // rdi
		  ComputeBufferHandle v37; // rax
		  ComputeBufferHandle v38; // rdx
		  ComputeBufferHandle v39; // rcx
		  Object *v40; // rdx
		  unsigned __int64 v41; // rdx
		  unsigned __int64 v42; // r8
		  char v43; // dl
		  signed __int64 v44; // rtt
		  RenderFunc_1_HG_Rendering_Runtime_DepthPyramidLDSRenderingPass_PassData_ *_9__6_0; // rdi
		  Object *v46; // rsi
		  RenderFunc_1_System_Object_ *v47; // rax
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  unsigned __int64 v50; // rdx
		  char v51; // r8
		  signed __int64 v52; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v54; // rdx
		  __int64 v55; // rcx
		  Object *v56; // [rsp+40h] [rbp-1A8h] BYREF
		  ComputeBufferDesc desc; // [rsp+48h] [rbp-1A0h] BYREF
		  HGRenderGraphBuilder v58; // [rsp+60h] [rbp-188h] BYREF
		  HGRenderGraphBuilder v59; // [rsp+80h] [rbp-168h] BYREF
		  __int128 v60; // [rsp+A0h] [rbp-148h] BYREF
		  __int128 v61; // [rsp+B0h] [rbp-138h]
		  __int128 v62; // [rsp+C0h] [rbp-128h]
		  __int128 v63; // [rsp+D0h] [rbp-118h] BYREF
		  __int128 v64; // [rsp+E0h] [rbp-108h]
		  Color v65; // [rsp+F0h] [rbp-F8h]
		  Il2CppExceptionWrapper *v66; // [rsp+100h] [rbp-E8h] BYREF
		  TextureDesc v67; // [rsp+110h] [rbp-D8h] BYREF
		  TextureDesc v68; // [rsp+170h] [rbp-78h] BYREF
		  int32_t m_Y; // [rsp+20Ch] [rbp+24h]
		
		  m_Y = depthTextureSize.m_Y;
		  v56 = 0LL;
		  sub_18033B9D0(&v68, 0LL, 96LL);
		  sub_18033B9D0(&v60, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3100, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3100, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v55, v54);
		    *(TextureHandle *)&v58.m_RenderPass = *depthTexture;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1145(
		      Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      (TextureHandle *)&v58,
		      depthTextureSize,
		      0LL);
		  }
		  else
		  {
		    v9 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x26u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v11, v10);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v58,
		      renderGraph,
		      (String *)"Depth Pyramid",
		      &v56,
		      v9,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::PassData>);
		    v59 = v58;
		    v58.m_RenderPass = 0LL;
		    v58.m_Resources = (HGRenderGraphResourceRegistry *)&v59;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v59, 0, 0LL);
		      v12 = v56;
		      sub_182F114D0();
		      v16 = sub_1834464B0(v14, v13, v15);
		      if ( !v12 )
		        sub_1800D8250(v18, v17);
		      LODWORD(v12[1].klass) = v16;
		      v19 = v56;
		      v22 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&desc,
		               &v59,
		               depthTexture,
		               0LL);
		      if ( !v19 )
		        sub_1800D8250(v21, v20);
		      *(TextureHandle *)((char *)&v19[2] + 4) = v22;
		      if ( !v56 )
		        sub_1800D8250(v21, v20);
		      *(Vector2Int *)((char *)&v56[1].klass + 4) = depthTextureSize;
		      v23 = (unsigned int)((depthTextureSize.m_X + 1) >> 31);
		      desc.count = (depthTextureSize.m_X + 1) / 2 + (depthTextureSize.m_X + 3) / 4;
		      desc.stride = (m_Y + 1) / 2;
		      v24 = v56;
		      if ( !v56 )
		        sub_1800D8250(0LL, v23);
		      *(MonitorData **)((char *)&v56[1].monitor + 4) = *(MonitorData **)&desc.count;
		      if ( !v56 )
		        sub_1800D8250(v24, v23);
		      monitor_high = HIDWORD(v56[1].monitor);
		      klass = (int32_t)v56[2].klass;
		      sub_18033B9D0(&v67, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v67, monitor_high, klass, 0LL);
		      v27 = *(_OWORD *)&v67.width;
		      v60 = *(_OWORD *)&v67.width;
		      v61 = *(_OWORD *)&v67.colorFormat;
		      v62 = *(_OWORD *)&v67.enableRandomWrite;
		      *(_QWORD *)&v63 = *(_QWORD *)&v67.bindTextureMS;
		      v28 = *(_OWORD *)&v67.fastMemoryDesc.inFastMemory;
		      v64 = *(_OWORD *)&v67.fastMemoryDesc.inFastMemory;
		      clearColor = v67.clearColor;
		      v65 = v67.clearColor;
		      *((_QWORD *)&v63 + 1) = "DepthPyramid";
		      if ( dword_18F35FD08 )
		      {
		        v30 = ((((unsigned __int64)&v63 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v30 + 36190]);
		        do
		          v31 = qword_18F0BCBA0[v30 + 36190];
		        while ( v31 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v30 + 36190],
		                         v31 | (1LL << ((((unsigned __int64)&v63 + 8) >> 12) & 0x3F)),
		                         v31) );
		        clearColor = v65;
		        v28 = v64;
		        v27 = v60;
		      }
		      LODWORD(v61) = 21;
		      LOWORD(v62) = 1;
		      BYTE2(v62) = 0;
		      *(_OWORD *)&v68.width = v27;
		      *(_OWORD *)&v68.colorFormat = v61;
		      *(_OWORD *)&v68.enableRandomWrite = v62;
		      *(_OWORD *)&v68.bindTextureMS = v63;
		      *(_OWORD *)&v68.fastMemoryDesc.inFastMemory = v28;
		      v68.clearColor = clearColor;
		      this->fields.m_depthPyramidTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                              (TextureHandle *)&desc,
		                                              renderGraph,
		                                              &v68,
		                                              0LL);
		      v32 = v56;
		      v35 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
		               (TextureHandle *)&desc,
		               &v59,
		               &this->fields.m_depthPyramidTexture,
		               0LL);
		      if ( !v32 )
		        sub_1800D8250(v34, v33);
		      *(TextureHandle *)((char *)&v32[3] + 4) = v35;
		      *(_QWORD *)(&desc.type + 1) = 0LL;
		      HIDWORD(desc.name) = 0;
		      desc.count = 1;
		      desc.stride = 4;
		      desc.type = 1;
		      v36 = v56;
		      v37 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientComputeBuffer(&v59, &desc, 0LL);
		      if ( !v36 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v39, v38);
		      *(ComputeBufferHandle *)((char *)&v36[4].klass + 4) = v37;
		      v40 = v56;
		      if ( !v56 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v39, 0LL);
		      v56[5].klass = (Object__Class *)this->fields.m_computeShader;
		      if ( dword_18F35FD08 )
		      {
		        v41 = ((unsigned __int64)&v40[5] >> 12) & 0x1FFFFF;
		        v42 = v41 >> 6;
		        v43 = v41 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v42 + 36190]);
		        do
		          v44 = qword_18F0BCBA0[v42 + 36190];
		        while ( v44 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v42 + 36190], v44 | (1LL << v43), v44) );
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c);
		      _9__6_0 = TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c->static_fields->__9__6_0;
		      if ( !_9__6_0 )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c);
		        v46 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c->static_fields->__9;
		        v47 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::PassData>);
		        _9__6_0 = (RenderFunc_1_HG_Rendering_Runtime_DepthPyramidLDSRenderingPass_PassData_ *)v47;
		        if ( !v47 )
		          sub_1800D8250(v49, v48);
		        HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v47,
		          v46,
		          MethodInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c::_Render_b__6_0,
		          0LL);
		        TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c->static_fields->__9__6_0 = _9__6_0;
		        if ( dword_18F35FD08 )
		        {
		          v50 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c->static_fields->__9__6_0 >> 12) & 0x1FFFFF) >> 6;
		          v51 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::__c->static_fields->__9__6_0 >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v50 + 36190]);
		          do
		            v52 = qword_18F0BCBA0[v50 + 36190];
		          while ( v52 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v50 + 36190], v52 | (1LL << v51), v52) );
		        }
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v59,
		        (RenderFunc_1_System_Object_ *)_9__6_0,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthPyramidLDSRenderingPass::PassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v66 )
		    {
		      v58.m_RenderPass = (HGRenderGraphPass *)v66->ex;
		    }
		    sub_180268AE0(&v58);
		  }
		}
		
	}
}
