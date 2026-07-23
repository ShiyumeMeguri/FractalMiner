using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class DepthPyramidNoLDSRenderingPass // TypeDefIndex: 38236
	{
		// Fields
		private ComputeShader m_computeShader; // 0x10
		private TextureHandle m_depthPyramidTexture; // 0x18
	
		// Properties
		public TextureHandle depthPyramidTexture { get => default; } // 0x0000000189BA4A4C-0x0000000189BA4AB4 
		// TextureHandle get_depthPyramidTexture()
		TextureHandle *HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::get_depthPyramidTexture(
		        TextureHandle *__return_ptr retstr,
		        DepthPyramidNoLDSRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_depthPyramidTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3094, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3094, 0LL);
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
		private class PassData // TypeDefIndex: 38234
		{
			// Fields
			public int maxMip; // 0x10
			public Vector2Int depthTextureSize; // 0x14
			public Vector2Int depthPyramidTextureSize; // 0x1C
			public TextureHandle depthTexture; // 0x24
			public TextureHandle depthPyramidTexture; // 0x34
			public ComputeShader computeShader; // 0x48
	
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
		public DepthPyramidNoLDSRenderingPass() {} // Dummy constructor
		public DepthPyramidNoLDSRenderingPass(HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDACC0-0x0000000182EDAD30
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
		public void Render(HGRenderGraph renderGraph, TextureHandle depthTexture, Vector2Int depthTextureSize) {} // 0x0000000189BA4498-0x0000000189BA4A4C
		// Void Render(HGRenderGraph, TextureHandle, Vector2Int)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::Render(
		        DepthPyramidNoLDSRenderingPass *this,
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
		  Object *v36; // rdx
		  unsigned __int64 v37; // rdx
		  unsigned __int64 v38; // r8
		  char v39; // dl
		  signed __int64 v40; // rtt
		  RenderFunc_1_HG_Rendering_Runtime_DepthPyramidNoLDSRenderingPass_PassData_ *_9__6_0; // rdi
		  Object *v42; // rsi
		  RenderFunc_1_System_Object_ *v43; // rax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  unsigned __int64 v46; // rdx
		  char v47; // r8
		  signed __int64 v48; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v50; // rdx
		  __int64 v51; // rcx
		  Object *v52; // [rsp+40h] [rbp-1A8h] BYREF
		  TextureHandle v53; // [rsp+48h] [rbp-1A0h] BYREF
		  HGRenderGraphBuilder v54; // [rsp+60h] [rbp-188h] BYREF
		  HGRenderGraphBuilder v55; // [rsp+80h] [rbp-168h] BYREF
		  __int128 v56; // [rsp+A0h] [rbp-148h] BYREF
		  __int128 v57; // [rsp+B0h] [rbp-138h]
		  __int128 v58; // [rsp+C0h] [rbp-128h]
		  __int128 v59; // [rsp+D0h] [rbp-118h] BYREF
		  __int128 v60; // [rsp+E0h] [rbp-108h]
		  Color v61; // [rsp+F0h] [rbp-F8h]
		  Il2CppExceptionWrapper *v62; // [rsp+100h] [rbp-E8h] BYREF
		  TextureDesc v63; // [rsp+110h] [rbp-D8h] BYREF
		  TextureDesc v64; // [rsp+170h] [rbp-78h] BYREF
		  int32_t m_Y; // [rsp+20Ch] [rbp+24h]
		
		  m_Y = depthTextureSize.m_Y;
		  v52 = 0LL;
		  sub_18033B9D0(&v64, 0LL, 96LL);
		  sub_18033B9D0(&v56, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3095, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3095, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v51, v50);
		    *(TextureHandle *)&v54.m_RenderPass = *depthTexture;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1145(
		      Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      (TextureHandle *)&v54,
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
		      &v54,
		      renderGraph,
		      (String *)"Depth Pyramid",
		      &v52,
		      v9,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::PassData>);
		    v55 = v54;
		    v54.m_RenderPass = 0LL;
		    v54.m_Resources = (HGRenderGraphResourceRegistry *)&v55;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v55, 0, 0LL);
		      v12 = v52;
		      sub_182F114D0();
		      v16 = sub_1834464B0(v14, v13, v15);
		      if ( !v12 )
		        sub_1800D8250(v18, v17);
		      LODWORD(v12[1].klass) = v16;
		      v19 = v52;
		      v22 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v53, &v55, depthTexture, 0LL);
		      if ( !v19 )
		        sub_1800D8250(v21, v20);
		      *(TextureHandle *)((char *)&v19[2] + 4) = v22;
		      if ( !v52 )
		        sub_1800D8250(v21, v20);
		      *(Vector2Int *)((char *)&v52[1].klass + 4) = depthTextureSize;
		      v23 = (unsigned int)((depthTextureSize.m_X + 1) >> 31);
		      v53.handle.m_Value = (depthTextureSize.m_X + 1) / 2 + (depthTextureSize.m_X + 3) / 4;
		      v53.handle._type_k__BackingField = (m_Y + 1) / 2;
		      v24 = v52;
		      if ( !v52 )
		        sub_1800D8250(0LL, v23);
		      *(MonitorData **)((char *)&v52[1].monitor + 4) = (MonitorData *)v53.handle;
		      if ( !v52 )
		        sub_1800D8250(v24, v23);
		      monitor_high = HIDWORD(v52[1].monitor);
		      klass = (int32_t)v52[2].klass;
		      sub_18033B9D0(&v63, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v63, monitor_high, klass, 0LL);
		      v27 = *(_OWORD *)&v63.width;
		      v56 = *(_OWORD *)&v63.width;
		      v57 = *(_OWORD *)&v63.colorFormat;
		      v58 = *(_OWORD *)&v63.enableRandomWrite;
		      *(_QWORD *)&v59 = *(_QWORD *)&v63.bindTextureMS;
		      v28 = *(_OWORD *)&v63.fastMemoryDesc.inFastMemory;
		      v60 = *(_OWORD *)&v63.fastMemoryDesc.inFastMemory;
		      clearColor = v63.clearColor;
		      v61 = v63.clearColor;
		      *((_QWORD *)&v59 + 1) = "DepthPyramid";
		      if ( dword_18F35FD08 )
		      {
		        v30 = ((((unsigned __int64)&v59 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v30 + 36190]);
		        do
		          v31 = qword_18F0BCBA0[v30 + 36190];
		        while ( v31 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v30 + 36190],
		                         v31 | (1LL << ((((unsigned __int64)&v59 + 8) >> 12) & 0x3F)),
		                         v31) );
		        clearColor = v61;
		        v28 = v60;
		        v27 = v56;
		      }
		      LODWORD(v57) = 21;
		      LOWORD(v58) = 1;
		      BYTE2(v58) = 0;
		      *(_OWORD *)&v64.width = v27;
		      *(_OWORD *)&v64.colorFormat = v57;
		      *(_OWORD *)&v64.enableRandomWrite = v58;
		      *(_OWORD *)&v64.bindTextureMS = v59;
		      *(_OWORD *)&v64.fastMemoryDesc.inFastMemory = v28;
		      v64.clearColor = clearColor;
		      this->fields.m_depthPyramidTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                              &v53,
		                                              renderGraph,
		                                              &v64,
		                                              0LL);
		      v32 = v52;
		      v35 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
		               &v53,
		               &v55,
		               &this->fields.m_depthPyramidTexture,
		               0LL);
		      if ( !v32 )
		        sub_1800D8250(v34, v33);
		      *(TextureHandle *)((char *)&v32[3] + 4) = v35;
		      v36 = v52;
		      if ( !v52 )
		        sub_1800D8250(v34, 0LL);
		      v52[4].monitor = (MonitorData *)this->fields.m_computeShader;
		      if ( dword_18F35FD08 )
		      {
		        v37 = ((unsigned __int64)&v36[4].monitor >> 12) & 0x1FFFFF;
		        v38 = v37 >> 6;
		        v39 = v37 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v38 + 36190]);
		        do
		          v40 = qword_18F0BCBA0[v38 + 36190];
		        while ( v40 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v38 + 36190], v40 | (1LL << v39), v40) );
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c);
		      _9__6_0 = TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c->static_fields->__9__6_0;
		      if ( !_9__6_0 )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c);
		        v42 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c->static_fields->__9;
		        v43 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::PassData>);
		        _9__6_0 = (RenderFunc_1_HG_Rendering_Runtime_DepthPyramidNoLDSRenderingPass_PassData_ *)v43;
		        if ( !v43 )
		          sub_1800D8250(v45, v44);
		        HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v43,
		          v42,
		          MethodInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c::_Render_b__6_0,
		          0LL);
		        TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c->static_fields->__9__6_0 = _9__6_0;
		        if ( dword_18F35FD08 )
		        {
		          v46 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c->static_fields->__9__6_0 >> 12) & 0x1FFFFF) >> 6;
		          v47 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::__c->static_fields->__9__6_0 >> 12) & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v46 + 36190]);
		          do
		            v48 = qword_18F0BCBA0[v46 + 36190];
		          while ( v48 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v46 + 36190], v48 | (1LL << v47), v48) );
		        }
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v55,
		        (RenderFunc_1_System_Object_ *)_9__6_0,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthPyramidNoLDSRenderingPass::PassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v62 )
		    {
		      v54.m_RenderPass = (HGRenderGraphPass *)v62->ex;
		    }
		    sub_180268AE0(&v54);
		  }
		}
		
	}
}
