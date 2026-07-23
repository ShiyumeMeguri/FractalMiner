using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class DepthPyramidCustomMipsRenderingPass // TypeDefIndex: 38243
	{
		// Fields
		private const int MAX_MIP_COUNT = 7; // Metadata: 0x02303BFE
		private ComputeShader m_computeShader; // 0x10
		private TextureHandle m_depthPyramidTexture; // 0x18
		private static readonly RenderFunc<PassData> s_RenderFunc; // 0x00
	
		// Properties
		public TextureHandle depthPyramidTexture { get => default; } // 0x0000000189BA3DC4-0x0000000189BA3E2C 
		// TextureHandle get_depthPyramidTexture()
		TextureHandle *HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::get_depthPyramidTexture(
		        TextureHandle *__return_ptr retstr,
		        DepthPyramidCustomMipsRenderingPass *this,
		        MethodInfo *method)
		{
		  TextureHandle m_depthPyramidTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3104, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3104, 0LL);
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
		public struct CBufferData // TypeDefIndex: 38240
		{
			// Fields
			public Vector4 prevTextureSize; // 0x00
			public Vector4 currTextureSize; // 0x10
			public Vector4 param0; // 0x20
		}
	
		private class PassData // TypeDefIndex: 38241
		{
			// Fields
			public Vector2Int depthTextureSize; // 0x10
			public Vector2Int depthPyramidTextureSize; // 0x18
			public TextureHandle depthTexture; // 0x20
			public TextureHandle depthPyramidTexture; // 0x30
			public ComputeShader computeShader; // 0x40
	
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
		public DepthPyramidCustomMipsRenderingPass() {} // Dummy constructor
		public DepthPyramidCustomMipsRenderingPass(HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDACC0-0x0000000182EDAD30
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
		
		static DepthPyramidCustomMipsRenderingPass() {} // 0x0000000184D2CFA0-0x0000000184D2D030
		// DepthPyramidCustomMipsRenderingPass()
		void HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::cctor(MethodInfo *method)
		{
		  struct DepthPyramidCustomMipsRenderingPass_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_DepthPyramidCustomMipsRenderingPass_PassData_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::PassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_DepthPyramidCustomMipsRenderingPass_PassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::__c::__cctor_b__10_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass->static_fields->s_RenderFunc = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		public void Render(HGRenderGraph renderGraph, HGCamera hgCamera, TextureHandle depthTexture) {} // 0x0000000189BA3900-0x0000000189BA3DC4
		// Void Render(HGRenderGraph, HGCamera, TextureHandle)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::Render(
		        DepthPyramidCustomMipsRenderingPass *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        TextureHandle *depthTexture,
		        MethodInfo *method)
		{
		  ProfilingSampler *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Object *v12; // rbx
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  TextureHandle v15; // xmm0
		  Object *v16; // rcx
		  int v17; // kr08_4
		  signed __int64 v18; // rcx
		  Object *v19; // rdx
		  unsigned int v20; // edx
		  unsigned __int64 v21; // r8
		  signed __int64 v22; // rtt
		  int32_t monitor; // edi
		  int32_t monitor_high; // ebx
		  __int128 v25; // xmm2
		  __int128 v26; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v28; // r8
		  signed __int64 v29; // rtt
		  Object *v30; // rbx
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  TextureHandle v33; // xmm0
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rbx
		  Object *v37; // [rsp+40h] [rbp-1A8h] BYREF
		  TextureHandle v38; // [rsp+48h] [rbp-1A0h] BYREF
		  HGRenderGraphBuilder v39; // [rsp+60h] [rbp-188h] BYREF
		  HGRenderGraphBuilder v40; // [rsp+80h] [rbp-168h] BYREF
		  __int128 v41; // [rsp+A0h] [rbp-148h] BYREF
		  __int128 v42; // [rsp+B0h] [rbp-138h]
		  __int128 v43; // [rsp+C0h] [rbp-128h]
		  __int128 v44; // [rsp+D0h] [rbp-118h] BYREF
		  __int128 v45; // [rsp+E0h] [rbp-108h]
		  Color v46; // [rsp+F0h] [rbp-F8h]
		  Il2CppExceptionWrapper *v47; // [rsp+100h] [rbp-E8h] BYREF
		  TextureDesc v48; // [rsp+110h] [rbp-D8h] BYREF
		  TextureDesc v49; // [rsp+170h] [rbp-78h] BYREF
		
		  v37 = 0LL;
		  sub_18033B9D0(&v49, 0LL, 96LL);
		  sub_18033B9D0(&v41, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3105, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3105, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v35, v34);
		    *(TextureHandle *)&v39.m_RenderPass = *depthTexture;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1092(
		      Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      (TextureHandle *)&v39,
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
		      &v39,
		      renderGraph,
		      (String *)"Depth Pyramid",
		      &v37,
		      v9,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::PassData>);
		    v40 = v39;
		    v39.m_RenderPass = 0LL;
		    v39.m_Resources = (HGRenderGraphResourceRegistry *)&v40;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v40, 0, 0LL);
		      v12 = v37;
		      v15 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v38, &v40, depthTexture, 0LL);
		      if ( !v12 )
		        sub_1800D8250(v14, v13);
		      v12[2] = (Object)v15;
		      if ( !hgCamera )
		        sub_1800D8250(v14, v13);
		      v16 = v37;
		      if ( !v37 )
		        sub_1800D8250(0LL, v13);
		      v37[1].klass = (Object__Class *)hgCamera->fields._sceneRTSize_k__BackingField;
		      if ( !v37 )
		        sub_1800D8250(v16, v13);
		      v17 = HIDWORD(v37[1].klass) + 1;
		      v18 = (unsigned int)(v17 / 2);
		      v38.handle.m_Value = (LODWORD(v37[1].klass) + 1) / 2;
		      v38.handle._type_k__BackingField = v17 / 2;
		      v37[1].monitor = (MonitorData *)v38.handle;
		      v19 = v37;
		      if ( !v37 )
		        sub_1800D8250(v18, 0LL);
		      v37[4].klass = (Object__Class *)this->fields.m_computeShader;
		      if ( dword_18F35FD08 )
		      {
		        v20 = ((unsigned __int64)&v19[4] >> 12) & 0x1FFFFF;
		        v21 = (unsigned __int64)v20 >> 6;
		        v19 = (Object *)(v20 & 0x3F);
		        _m_prefetchw(&qword_18F0BCBA0[v21 + 36190]);
		        do
		        {
		          v18 = qword_18F0BCBA0[v21 + 36190] | (1LL << (char)v19);
		          v22 = qword_18F0BCBA0[v21 + 36190];
		        }
		        while ( v22 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v21 + 36190], v18, v22) );
		      }
		      if ( !v37 )
		        sub_1800D8250(v18, v19);
		      monitor = (int32_t)v37[1].monitor;
		      monitor_high = HIDWORD(v37[1].monitor);
		      sub_18033B9D0(&v48, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v48, monitor, monitor_high, 0LL);
		      v25 = *(_OWORD *)&v48.width;
		      v41 = *(_OWORD *)&v48.width;
		      v42 = *(_OWORD *)&v48.colorFormat;
		      v43 = *(_OWORD *)&v48.enableRandomWrite;
		      *(_QWORD *)&v44 = *(_QWORD *)&v48.bindTextureMS;
		      v26 = *(_OWORD *)&v48.fastMemoryDesc.inFastMemory;
		      v45 = *(_OWORD *)&v48.fastMemoryDesc.inFastMemory;
		      clearColor = v48.clearColor;
		      v46 = v48.clearColor;
		      *((_QWORD *)&v44 + 1) = "DepthPyramid";
		      if ( dword_18F35FD08 )
		      {
		        v28 = ((((unsigned __int64)&v44 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v28 + 36190]);
		        do
		          v29 = qword_18F0BCBA0[v28 + 36190];
		        while ( v29 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v28 + 36190],
		                         v29 | (1LL << ((((unsigned __int64)&v44 + 8) >> 12) & 0x3F)),
		                         v29) );
		        clearColor = v46;
		        v26 = v45;
		        v25 = v41;
		      }
		      LODWORD(v42) = 49;
		      LOWORD(v43) = 257;
		      BYTE2(v43) = 0;
		      *(_OWORD *)&v49.width = v25;
		      *(_OWORD *)&v49.colorFormat = v42;
		      *(_OWORD *)&v49.enableRandomWrite = v43;
		      *(_OWORD *)&v49.bindTextureMS = v44;
		      *(_OWORD *)&v49.fastMemoryDesc.inFastMemory = v26;
		      v49.clearColor = clearColor;
		      this->fields.m_depthPyramidTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                              &v38,
		                                              renderGraph,
		                                              &v49,
		                                              0LL);
		      v30 = v37;
		      v33 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadWriteTexture(
		               &v38,
		               &v40,
		               &this->fields.m_depthPyramidTexture,
		               0LL);
		      if ( !v30 )
		        sub_1800D8250(v32, v31);
		      v30[3] = (Object)v33;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v40,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass->static_fields->s_RenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthPyramidCustomMipsRenderingPass::PassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v47 )
		    {
		      v39.m_RenderPass = (HGRenderGraphPass *)v47->ex;
		    }
		    sub_180268AE0(&v39);
		  }
		}
		
	}
}
