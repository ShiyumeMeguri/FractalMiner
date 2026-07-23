using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class BakeFogLutPassConstructor : IPassConstructor // TypeDefIndex: 38176
	{
		// Fields
		private Material m_bakeFogLutMaterial; // 0x10
		private TextureHandle m_fogBakeLutTexture; // 0x18
		private static readonly RenderFunc<BakeFogLutPassData> s_bakeFogLutFunc; // 0x00
	
		// Properties
		public TextureHandle FogBakeLutTexture { get => default; } // 0x0000000189B88540-0x0000000189B885A8 
		// TextureHandle get_FogBakeLutTexture()
		TextureHandle *HG::Rendering::Runtime::BakeFogLutPassConstructor::get_FogBakeLutTexture(
		        TextureHandle *__return_ptr retstr,
		        BakeFogLutPassConstructor *this,
		        MethodInfo *method)
		{
		  TextureHandle m_fogBakeLutTexture; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  TextureHandle *result; // rax
		  TextureHandle v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3003, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3003, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    m_fogBakeLutTexture = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_fogBakeLutTexture = this->fields.m_fogBakeLutTexture;
		  }
		  result = retstr;
		  *retstr = m_fogBakeLutTexture;
		  return result;
		}
		
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38172
		{
			// Fields
			internal HGAtmosphereSettingParameters atmosphereParams; // 0x00
		}
	
		internal struct PassOutput // TypeDefIndex: 38173
		{
		}
	
		private class BakeFogLutPassData // TypeDefIndex: 38174
		{
			// Fields
			public HGCamera hgCamera; // 0x10
			public Material bakeFogLutMaterial; // 0x18
	
			// Constructors
			public BakeFogLutPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public BakeFogLutPassConstructor() {} // Dummy constructor
		internal BakeFogLutPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184CCB110-0x0000000184CCB160
		// BakeFogLutPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::BakeFogLutPassConstructor::BakeFogLutPassConstructor(
		        BakeFogLutPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( !resources->defaultResources
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector )
		  {
		    sub_1800D8260(this, materialCollector);
		  }
		  this->fields.m_bakeFogLutMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                        materialCollector,
		                                        shaders->fields.bakeFogLutPS,
		                                        0,
		                                        0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v6, v7, v8, v9);
		}
		
		static BakeFogLutPassConstructor() {} // 0x0000000184D2D270-0x0000000184D2D300
		// BakeFogLutPassConstructor()
		void HG::Rendering::Runtime::BakeFogLutPassConstructor::cctor(MethodInfo *method)
		{
		  struct BakeFogLutPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_BakeFogLutPassConstructor_BakeFogLutPassData_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::BakeFogLutPassConstructor::BakeFogLutPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_BakeFogLutPassConstructor_BakeFogLutPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor::__c::__cctor_b__14_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor->static_fields->s_bakeFogLutFunc = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189B884EC-0x0000000189B88540
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::BakeFogLutPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        BakeFogLutPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3004, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3004, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189B88498-0x0000000189B884EC
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::BakeFogLutPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        BakeFogLutPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3005, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3005, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189B880E4-0x0000000189B88444
		// Void ConstructPass(BakeFogLutPassConstructor+PassInput ByRef, BakeFogLutPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::BakeFogLutPassConstructor::ConstructPass(
		        BakeFogLutPassConstructor *this,
		        BakeFogLutPassConstructor_PassInput *input,
		        BakeFogLutPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  Object *v14; // rcx
		  int v15; // eax
		  unsigned __int64 v16; // r9
		  signed __int64 v17; // rtt
		  Object *v18; // r9
		  MonitorData *m_bakeFogLutMaterial; // rcx
		  unsigned int v20; // r9d
		  unsigned __int64 v21; // r8
		  char v22; // r9
		  signed __int64 v23; // rtt
		  HGAtmosphereSettingParameters *atmosphereParams; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  Object *v28; // [rsp+40h] [rbp-128h] BYREF
		  TextureHandle v29; // [rsp+48h] [rbp-120h] BYREF
		  HGRenderGraphBuilder v30; // [rsp+58h] [rbp-110h] BYREF
		  HGRenderGraphBuilder v31; // [rsp+78h] [rbp-F0h] BYREF
		  Il2CppExceptionWrapper *v32; // [rsp+98h] [rbp-D0h] BYREF
		  TextureDesc v33; // [rsp+A0h] [rbp-C8h] BYREF
		  TextureDesc v34; // [rsp+100h] [rbp-68h] BYREF
		
		  v28 = 0LL;
		  sub_18033B9D0(&v33, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3006, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3006, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v27, v26);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1118(
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
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPathScene);
		    if ( HG::Rendering::Runtime::HGRenderPathScene::ShouldBakeFogLut(camera, 0LL) )
		    {
		      v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x2Fu,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8260(v12, v11);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v30,
		        renderGraph,
		        (String *)"Bake Fog LUT",
		        &v28,
		        v10,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::BakeFogLutPassConstructor::BakeFogLutPassData>);
		      v31 = v30;
		      v30.m_RenderPass = 0LL;
		      v30.m_Resources = (HGRenderGraphResourceRegistry *)&v31;
		      try
		      {
		        v14 = v28;
		        if ( !v28 )
		          sub_1800D8250(0LL, v13);
		        v28[1].klass = (Object__Class *)camera;
		        v15 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v16 = (((unsigned __int64)&v14[1] >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v16 + 36190]);
		          do
		            v17 = qword_18F0BCBA0[v16 + 36190];
		          while ( v17 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v16 + 36190],
		                           v17 | (1LL << (((unsigned __int64)&v14[1] >> 12) & 0x3F)),
		                           v17) );
		          v15 = dword_18F35FD08;
		        }
		        v18 = v28;
		        m_bakeFogLutMaterial = (MonitorData *)this->fields.m_bakeFogLutMaterial;
		        if ( !v28 )
		          sub_1800D8250(m_bakeFogLutMaterial, qword_18F0BCBA0);
		        v28[1].monitor = m_bakeFogLutMaterial;
		        if ( v15 )
		        {
		          v20 = ((unsigned __int64)&v18[1].monitor >> 12) & 0x1FFFFF;
		          v21 = (unsigned __int64)v20 >> 6;
		          v22 = v20 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v21 + 36190]);
		          do
		            v23 = qword_18F0BCBA0[v21 + 36190];
		          while ( v23 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v21 + 36190], v23 | (1LL << v22), v23) );
		        }
		        atmosphereParams = input->atmosphereParams;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		        v33 = *HG::Rendering::Runtime::HGAtmosphereRenderer::CreateBakeFogLutDesc(&v34, atmosphereParams, 0LL);
		        this->fields.m_fogBakeLutTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                              &v29,
		                                              renderGraph,
		                                              &v33,
		                                              0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          &v29,
		          &v31,
		          &this->fields.m_fogBakeLutTexture,
		          0,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v31,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::BakeFogLutPassConstructor->static_fields->s_bakeFogLutFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::BakeFogLutPassConstructor::BakeFogLutPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v32 )
		      {
		        v30.m_RenderPass = (HGRenderGraphPass *)v32->ex;
		      }
		      sub_180268AE0(&v30);
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189B88444-0x0000000189B88498
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::BakeFogLutPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        BakeFogLutPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3007, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3007, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80890-0x0000000184D808C0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::BakeFogLutPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        BakeFogLutPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3008, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3008, 0LL);
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
