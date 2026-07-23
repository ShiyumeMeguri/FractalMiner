using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class SkyAtmospherePassConstructor : IPassConstructor // TypeDefIndex: 38421
	{
		// Fields
		private Material m_renderAtmosphereLutMaterial; // 0x10
		private ComputeShader m_renderAtmosphereLutCS; // 0x18
		private static readonly RenderFunc<SkyAtmospherePassData> s_skyAtmosphereRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38417
		{
			// Fields
			internal HGAtmosphereSettingParameters atmosphereParams; // 0x00
		}
	
		internal struct PassOutput // TypeDefIndex: 38418
		{
		}
	
		private class SkyAtmospherePassData // TypeDefIndex: 38419
		{
			// Fields
			public HGCamera hgCamera; // 0x10
			public Material renderAtmosphereLutMaterial; // 0x18
			public ComputeShader renderAtmosphereLutCS; // 0x20
			public HGAtmosphereSettingParameters atmosphereParams; // 0x28
	
			// Constructors
			public SkyAtmospherePassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public SkyAtmospherePassConstructor() {} // Dummy constructor
		internal SkyAtmospherePassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184B39A80-0x0000000184B39B00
		// SkyAtmospherePassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::SkyAtmospherePassConstructor::SkyAtmospherePassConstructor(
		        SkyAtmospherePassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v12; // rax
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+50h] [rbp+28h]
		
		  if ( !resources->defaultResources
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector
		    || (this->fields.m_renderAtmosphereLutMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                       materialCollector,
		                                                       shaders->fields.renderAtmosphereLutPS,
		                                                       0,
		                                                       0LL),
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v13),
		        !resources->defaultResources)
		    || (v12 = resources->defaultResources->fields.shaders) == 0LL )
		  {
		    sub_1800D8260(this, materialCollector);
		  }
		  this->fields.m_renderAtmosphereLutCS = v12->fields.renderAtmosphereLutCS;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_renderAtmosphereLutCS,
		    (HGRuntimeGrassQuery_Node *)materialCollector,
		    v10,
		    v11,
		    v14);
		}
		
		static SkyAtmospherePassConstructor() {} // 0x0000000184D2C730-0x0000000184D2C7C0
		// SkyAtmospherePassConstructor()
		void HG::Rendering::Runtime::SkyAtmospherePassConstructor::cctor(MethodInfo *method)
		{
		  struct SkyAtmospherePassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_SkyAtmospherePassConstructor_SkyAtmospherePassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::SkyAtmospherePassConstructor::SkyAtmospherePassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_SkyAtmospherePassConstructor_SkyAtmospherePassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor::__c::__cctor_b__12_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor->static_fields->s_skyAtmosphereRenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BD047C-0x0000000189BD04D0
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::SkyAtmospherePassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        SkyAtmospherePassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3336, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3336, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BD0428-0x0000000189BD047C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::SkyAtmospherePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        SkyAtmospherePassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3337, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3337, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BD006C-0x0000000189BD03D4
		// Void ConstructPass(SkyAtmospherePassConstructor+PassInput ByRef, SkyAtmospherePassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::SkyAtmospherePassConstructor::ConstructPass(
		        SkyAtmospherePassConstructor *this,
		        SkyAtmospherePassConstructor_PassInput *input,
		        SkyAtmospherePassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  HGAtmosphereSettingParameters *atmosphereParams; // rbx
		  bool ShouldRenderAtmosphereLutUsingCompute; // r12
		  char *v12; // rbx
		  ProfilingSampler *v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // rdx
		  Object *v17; // rcx
		  int v18; // eax
		  unsigned __int64 v19; // r9
		  signed __int64 v20; // rtt
		  Object *v21; // r8
		  MonitorData *m_renderAtmosphereLutMaterial; // rcx
		  unsigned __int64 v23; // r8
		  unsigned __int64 v24; // r9
		  char v25; // r8
		  signed __int64 v26; // rtt
		  Object *v27; // r8
		  Object__Class *m_renderAtmosphereLutCS; // rcx
		  unsigned __int64 v29; // r8
		  unsigned __int64 v30; // r9
		  char v31; // r8
		  signed __int64 v32; // rtt
		  Object *v33; // r8
		  MonitorData *v34; // rcx
		  unsigned __int64 v35; // r8
		  unsigned __int64 v36; // r9
		  char v37; // r8
		  signed __int64 v38; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  Object *v42; // [rsp+40h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v43; // [rsp+50h] [rbp-68h] BYREF
		  HGRenderGraphBuilder v44; // [rsp+58h] [rbp-60h] BYREF
		  HGRenderGraphBuilder v45; // [rsp+78h] [rbp-40h] BYREF
		
		  v42 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3338, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3338, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v41, v40);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1224(
		      Patch,
		      (Object *)this,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    atmosphereParams = input->atmosphereParams;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		    ShouldRenderAtmosphereLutUsingCompute = HG::Rendering::Runtime::HGAtmosphereRenderer::ShouldRenderAtmosphereLutUsingCompute(
		                                              atmosphereParams,
		                                              0LL);
		    v12 = "Render Sky Atmosphere";
		    if ( ShouldRenderAtmosphereLutUsingCompute )
		      v12 = "Compute Sky Atmosphere";
		    v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x2Cu,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v15, v14);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v44,
		      renderGraph,
		      (String *)v12,
		      &v42,
		      v13,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::SkyAtmospherePassConstructor::SkyAtmospherePassData>);
		    v45 = v44;
		    v44.m_RenderPass = 0LL;
		    v44.m_Resources = (HGRenderGraphResourceRegistry *)&v45;
		    try
		    {
		      v17 = v42;
		      if ( !v42 )
		        sub_1800D8250(0LL, v16);
		      v42[1].klass = (Object__Class *)camera;
		      v18 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v19 = (((unsigned __int64)&v17[1] >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v19 + 36190]);
		        do
		          v20 = qword_18F0BCBA0[v19 + 36190];
		        while ( v20 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v19 + 36190],
		                         v20 | (1LL << (((unsigned __int64)&v17[1] >> 12) & 0x3F)),
		                         v20) );
		        v18 = dword_18F35FD08;
		      }
		      v21 = v42;
		      m_renderAtmosphereLutMaterial = (MonitorData *)this->fields.m_renderAtmosphereLutMaterial;
		      if ( !v42 )
		        sub_1800D8250(m_renderAtmosphereLutMaterial, qword_18F0BCBA0);
		      v42[1].monitor = m_renderAtmosphereLutMaterial;
		      if ( v18 )
		      {
		        v23 = ((unsigned __int64)&v21[1].monitor >> 12) & 0x1FFFFF;
		        v24 = v23 >> 6;
		        v25 = v23 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v24 + 36190]);
		        do
		          v26 = qword_18F0BCBA0[v24 + 36190];
		        while ( v26 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v24 + 36190], v26 | (1LL << v25), v26) );
		        v18 = dword_18F35FD08;
		      }
		      v27 = v42;
		      m_renderAtmosphereLutCS = (Object__Class *)this->fields.m_renderAtmosphereLutCS;
		      if ( !v42 )
		        sub_1800D8250(m_renderAtmosphereLutCS, qword_18F0BCBA0);
		      v42[2].klass = m_renderAtmosphereLutCS;
		      if ( v18 )
		      {
		        v29 = ((unsigned __int64)&v27[2] >> 12) & 0x1FFFFF;
		        v30 = v29 >> 6;
		        v31 = v29 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v30 + 36190]);
		        do
		          v32 = qword_18F0BCBA0[v30 + 36190];
		        while ( v32 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v30 + 36190], v32 | (1LL << v31), v32) );
		        v18 = dword_18F35FD08;
		      }
		      v33 = v42;
		      v34 = (MonitorData *)input->atmosphereParams;
		      if ( !v42 )
		        sub_1800D8250(v34, qword_18F0BCBA0);
		      v42[2].monitor = v34;
		      if ( v18 )
		      {
		        v35 = ((unsigned __int64)&v33[2].monitor >> 12) & 0x1FFFFF;
		        v36 = v35 >> 6;
		        v37 = v35 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v36 + 36190]);
		        do
		          v38 = qword_18F0BCBA0[v36 + 36190];
		        while ( v38 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v36 + 36190], v38 | (1LL << v37), v38) );
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v45,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::SkyAtmospherePassConstructor->static_fields->s_skyAtmosphereRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SkyAtmospherePassConstructor::SkyAtmospherePassData>);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::EnableAsyncCompute(
		        &v45,
		        ShouldRenderAtmosphereLutUsingCompute,
		        0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v43 )
		    {
		      v44.m_RenderPass = (HGRenderGraphPass *)v43->ex;
		    }
		    sub_180268AE0(&v44);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BD03D4-0x0000000189BD0428
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::SkyAtmospherePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        SkyAtmospherePassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3339, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3339, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D7FEA0-0x0000000184D7FED0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::SkyAtmospherePassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        SkyAtmospherePassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3340, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3340, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		}
		
	}
}
