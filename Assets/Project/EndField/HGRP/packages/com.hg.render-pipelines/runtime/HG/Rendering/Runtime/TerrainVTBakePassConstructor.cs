using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class TerrainVTBakePassConstructor : IPassConstructor // TypeDefIndex: 38456
	{
		// Fields
		private static readonly RenderFunc<TerrainVTBakePassData> s_terrainVTBakePassRenderFunc; // 0x00
	
		// Nested types
		public class TerrainVTBakePassData // TypeDefIndex: 38454
		{
			// Fields
			internal int feedbackViewId; // 0x10
	
			// Constructors
			public TerrainVTBakePassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public TerrainVTBakePassConstructor() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static TerrainVTBakePassConstructor() {} // 0x0000000184D2C610-0x0000000184D2C6A0
		// TerrainVTBakePassConstructor()
		void HG::Rendering::Runtime::TerrainVTBakePassConstructor::cctor(MethodInfo *method)
		{
		  struct TerrainVTBakePassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_TerrainVTBakePassConstructor_TerrainVTBakePassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::TerrainVTBakePassConstructor::TerrainVTBakePassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_TerrainVTBakePassConstructor_TerrainVTBakePassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor::__c::__cctor_b__8_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor->static_fields->s_terrainVTBakePassRenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		internal void ConstructPass(HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BD5E54-0x0000000189BD5EBC
		// Void ConstructPass(HGRenderGraph, HGCamera)
		void HG::Rendering::Runtime::TerrainVTBakePassConstructor::ConstructPass(
		        TerrainVTBakePassConstructor *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3429, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3429, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BD60C8-0x0000000189BD611C
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::TerrainVTBakePassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        TerrainVTBakePassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3430, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3430, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BD5F10-0x0000000189BD60C8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::TerrainVTBakePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        TerrainVTBakePassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  HGRenderGraph *renderGraph; // rdi
		  ProfilingSampler *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 vtFeedbackViewId; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Il2CppExceptionWrapper *v15; // [rsp+40h] [rbp-58h] BYREF
		  HGRenderGraphBuilder v16; // [rsp+48h] [rbp-50h] BYREF
		  HGRenderGraphBuilder v17; // [rsp+68h] [rbp-30h] BYREF
		  Object *v18; // [rsp+B8h] [rbp+20h] BYREF
		
		  v18 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3431, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3431, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		  else
		  {
		    renderGraph = input->renderGraph;
		    v6 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0x11u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v8, v7);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v16,
		      renderGraph,
		      (String *)"TerrainVTBakePass",
		      &v18,
		      v6,
		      1,
		      ProfilingHGPass__Enum_PreDepth,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainVTBakePassConstructor::TerrainVTBakePassData>);
		    v17 = v16;
		    v16.m_RenderPass = 0LL;
		    v16.m_Resources = (HGRenderGraphResourceRegistry *)&v17;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v17, 0, 0LL);
		      if ( !input->camera )
		        sub_1800D8250(v10, v9);
		      vtFeedbackViewId = (unsigned int)input->camera->fields.vtFeedbackViewId;
		      if ( !v18 )
		        sub_1800D8250(vtFeedbackViewId, v9);
		      LODWORD(v18[1].klass) = vtFeedbackViewId;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v17,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TerrainVTBakePassConstructor->static_fields->s_terrainVTBakePassRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainVTBakePassConstructor::TerrainVTBakePassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v15 )
		    {
		      v16.m_RenderPass = (HGRenderGraphPass *)v15->ex;
		    }
		    sub_180268AE0(&v16);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BD5EBC-0x0000000189BD5F10
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::TerrainVTBakePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        TerrainVTBakePassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3432, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3432, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D7FDB0-0x0000000184D7FDE0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::TerrainVTBakePassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        TerrainVTBakePassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3433, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3433, 0LL);
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
