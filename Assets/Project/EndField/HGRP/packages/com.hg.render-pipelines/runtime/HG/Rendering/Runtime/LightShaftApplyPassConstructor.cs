using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class LightShaftApplyPassConstructor : IPassConstructor // TypeDefIndex: 38394
	{
		// Fields
		private Material m_lightShaftMaterial; // 0x10
		private static readonly MaterialPropertyBlock s_lightShaftMaterialPropertyBlock; // 0x00
		private static readonly RenderFunc<LightShaftApplyPassData> s_lightShaftApplyRenderFunc; // 0x08
		private static readonly string[] s_lightShaftPingPongRTName; // 0x10
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38390
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
			internal TextureHandle lightShaftBlurResult; // 0x10
			internal bool enableLightShaft; // 0x20
		}
	
		internal struct PassOutput // TypeDefIndex: 38391
		{
		}
	
		private class LightShaftApplyPassData // TypeDefIndex: 38392
		{
			// Fields
			public Material lightShaftMaterial; // 0x10
			public TextureHandle lightShaftBlurResult; // 0x18
			public TextureHandle targetRT; // 0x28
	
			// Constructors
			public LightShaftApplyPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public LightShaftApplyPassConstructor() {} // Dummy constructor
		internal LightShaftApplyPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184CCB0C0-0x0000000184CCB110
		// LightShaftApplyPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPassConstructor(
		        LightShaftApplyPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( !resources->defaultResources
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector )
		  {
		    sub_1800D8260(this, materialCollector);
		  }
		  this->fields.m_lightShaftMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                        materialCollector,
		                                        shaders->fields.lightShaftPS,
		                                        0,
		                                        0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v6, v7, v8, v9);
		}
		
		static LightShaftApplyPassConstructor() {} // 0x0000000184B41150-0x0000000184B412A0
		// LightShaftApplyPassConstructor()
		void HG::Rendering::Runtime::LightShaftApplyPassConstructor::cctor(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  __int64 v2; // rcx
		  __int64 v3; // rbx
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v5; // r8
		  Int32__Array **v6; // r9
		  struct LightShaftApplyPassConstructor_c__Class *v7; // r9
		  Object *v8; // rdi
		  RenderFunc_1_System_Object_ *v9; // rax
		  MonitorData *v10; // rbx
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  __int64 v14; // rax
		  String__Array *v15; // rbx
		  LightShaftApplyPassConstructor__StaticFields *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+50h] [rbp+28h]
		
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v3 )
		    goto LABEL_2;
		  *(_QWORD *)(v3 + 16) = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor->static_fields;
		  static_fields->klass = (HGRuntimeGrassQuery_Node__Class *)v3;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor->static_fields,
		    static_fields,
		    v5,
		    v6,
		    v19);
		  v7 = TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor::__c);
		    v7 = TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor::__c;
		  }
		  v8 = (Object *)v7->static_fields->__9;
		  v9 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPassData>);
		  v10 = (MonitorData *)v9;
		  if ( !v9
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v9,
		          v8,
		          MethodInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor::__c::__cctor_b__14_0,
		          0LL),
		        v11 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor->static_fields,
		        v11->monitor = v10,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor->static_fields->s_lightShaftApplyRenderFunc,
		          v11,
		          v12,
		          v13,
		          v20),
		        v14 = il2cpp_array_new_specific_1(TypeInfo::System::String, 2LL),
		        (v15 = (String__Array *)v14) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(v2, v1);
		  }
		  sub_180005370(v14, 0LL, "_LightShaftPingPongRT0");
		  sub_180005370(v15, 1LL, "_LightShaftPingPongRT1");
		  v16 = TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor->static_fields;
		  v16->s_lightShaftPingPongRTName = v15;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor->static_fields->s_lightShaftPingPongRTName,
		    (HGRuntimeGrassQuery_Node *)v16,
		    v17,
		    v18,
		    v21);
		}
		
	
		// Methods
		private void LightShaftApplyPass(ref PassInput input, HGRenderGraph renderGraph) {} // 0x0000000189BCD2BC-0x0000000189BCD62C
		// Void LightShaftApplyPass(LightShaftApplyPassConstructor+PassInput ByRef, HGRenderGraph)
		// Hidden C++ exception states: #wind=2 #try_helpers=1
		void HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPass(
		        LightShaftApplyPassConstructor *this,
		        LightShaftApplyPassConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ProfilingSampler *v7; // rax
		  ProfilingSampler *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // rcx
		  Object *v12; // rdx
		  unsigned int v13; // edx
		  unsigned __int64 v14; // r8
		  char v15; // dl
		  signed __int64 v16; // rtt
		  Object *v17; // rbx
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  TextureHandle v20; // xmm0
		  Object *v21; // rbx
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  TextureHandle v24; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  Object *v28; // [rsp+50h] [rbp-B8h] BYREF
		  Color v29; // [rsp+60h] [rbp-A8h] BYREF
		  _QWORD v30[2]; // [rsp+70h] [rbp-98h] BYREF
		  _QWORD v31[2]; // [rsp+80h] [rbp-88h] BYREF
		  HGRenderGraphBuilder v32; // [rsp+90h] [rbp-78h] BYREF
		  HGRenderGraphProfilingScope v33; // [rsp+B0h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v34; // [rsp+C8h] [rbp-40h] BYREF
		  HGRenderGraphBuilder v35; // [rsp+D8h] [rbp-30h] BYREF
		
		  memset(&v33, 0, sizeof(v33));
		  memset(&v32, 0, sizeof(v32));
		  v28 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3300, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3300, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v27, v26);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1214(Patch, (Object *)this, input, (Object *)renderGraph, 0LL);
		  }
		  else if ( input->enableLightShaft )
		  {
		    v7 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0xA3u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
		      &v33,
		      renderGraph,
		      v7,
		      0LL);
		    v31[0] = 0LL;
		    v31[1] = &v33;
		    v8 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0xA6u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8250(v10, v9);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v35,
		      renderGraph,
		      (String *)"Apply Light Shaft",
		      &v28,
		      v8,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPassData>);
		    v32 = v35;
		    v30[0] = 0LL;
		    v30[1] = &v32;
		    try
		    {
		      v12 = v28;
		      if ( !v28 )
		        sub_1800D8250(v11, 0LL);
		      v28[1].klass = (Object__Class *)this->fields.m_lightShaftMaterial;
		      if ( dword_18F35FD08 )
		      {
		        v13 = ((unsigned __int64)&v12[1] >> 12) & 0x1FFFFF;
		        v14 = (unsigned __int64)v13 >> 6;
		        v15 = v13 & 0x3F;
		        _m_prefetchw(&qword_18F103690[v14]);
		        do
		          v16 = qword_18F103690[v14];
		        while ( v16 != _InterlockedCompareExchange64(&qword_18F103690[v14], v16 | (1LL << v15), v16) );
		      }
		      v17 = v28;
		      v20 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               (TextureHandle *)&v29,
		               &v32,
		               &input->lightShaftBlurResult,
		               0LL);
		      if ( !v17 )
		        sub_1800D8250(v19, v18);
		      *(TextureHandle *)&v17[1].monitor = v20;
		      v21 = v28;
		      v24 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		               (TextureHandle *)&v29,
		               &v32,
		               &input->sceneColor,
		               0LL);
		      if ( !v21 )
		        sub_1800D8250(v23, v22);
		      *(TextureHandle *)&v21[2].monitor = v24;
		      if ( !v28 )
		        sub_1800D8250(v23, v22);
		      v29 = 0LL;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v35,
		        &v32,
		        (TextureHandle *)&v28[2].monitor,
		        0,
		        RenderBufferLoadAction__Enum_Load,
		        RenderBufferStoreAction__Enum_Store,
		        &v29,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v32,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::LightShaftApplyPassConstructor->static_fields->s_lightShaftApplyRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v34 )
		    {
		      v30[0] = v34->ex;
		    }
		    sub_180268AE0(v30);
		    sub_180269330(v31);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BCD268-0x0000000189BCD2BC
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::LightShaftApplyPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        LightShaftApplyPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3301, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3301, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BCD214-0x0000000189BCD268
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::LightShaftApplyPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        LightShaftApplyPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3302, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3302, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BCD10C-0x0000000189BCD1C0
		// Void ConstructPass(LightShaftApplyPassConstructor+PassInput ByRef, LightShaftApplyPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		void HG::Rendering::Runtime::LightShaftApplyPassConstructor::ConstructPass(
		        LightShaftApplyPassConstructor *this,
		        LightShaftApplyPassConstructor_PassInput *input,
		        LightShaftApplyPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3303, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3303, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1215(
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
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    if ( HG::Rendering::Runtime::UberPostPassUtils::ShouldRenderPostProcess(camera, 0LL) )
		      HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPass(this, input, renderGraph, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BCD1C0-0x0000000189BCD214
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::LightShaftApplyPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        LightShaftApplyPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3304, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3304, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D3AC00-0x0000000184D3AC70
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::LightShaftApplyPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        LightShaftApplyPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  Object_1 *m_lightShaftMaterial; // rdi
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3305, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3305, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    m_lightShaftMaterial = (Object_1 *)this->fields.m_lightShaftMaterial;
		    if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::Destroy(m_lightShaftMaterial, 0LL);
		    this->fields.m_lightShaftMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v6, v7, v8, v12);
		  }
		}
		
	}
}
