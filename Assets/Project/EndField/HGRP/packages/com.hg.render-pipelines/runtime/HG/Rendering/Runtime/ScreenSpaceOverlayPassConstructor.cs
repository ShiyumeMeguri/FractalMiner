using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class ScreenSpaceOverlayPassConstructor : ComposablePass, IPassConstructor // TypeDefIndex: 38404
	{
		// Fields
		private HGRenderGraphBuilder m_renderGraphBuilder; // 0x10
		private static readonly RenderFunc<UIPassData> s_UIRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38400
		{
			// Fields
			internal TextureHandle target; // 0x00
			internal HGCamera camera; // 0x10
		}
	
		internal struct PassOutput // TypeDefIndex: 38401
		{
		}
	
		private class UIPassData // TypeDefIndex: 38402
		{
			// Fields
			public HGCamera camera; // 0x10
	
			// Constructors
			public UIPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public ScreenSpaceOverlayPassConstructor() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static ScreenSpaceOverlayPassConstructor() {} // 0x0000000184D2C7C0-0x0000000184D2C850
		// ScreenSpaceOverlayPassConstructor()
		void HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::cctor(MethodInfo *method)
		{
		  struct ScreenSpaceOverlayPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_ScreenSpaceOverlayPassConstructor_UIPassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::UIPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_ScreenSpaceOverlayPassConstructor_UIPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::__c::__cctor_b__12_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor->static_fields->s_UIRenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		protected override HGRenderGraphBuilder? GetRenderGraphBuilder(HGRenderGraph renderGraph) => default; // 0x0000000189BCF8B8-0x0000000189BCF96C
		// Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] GetRenderGraphBuilder(HGRenderGraph)
		Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::GetRenderGraphBuilder(
		        Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
		        ScreenSpaceOverlayPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int128 v7; // xmm2
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v12; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3312, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3312, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1090(&v12, Patch, (Object *)this, (Object *)renderGraph, 0LL);
		  }
		  else
		  {
		    v7 = *(_OWORD *)&this->fields.m_renderGraphBuilder.m_RenderGraph;
		    *(_OWORD *)&v12.hasValue = *(_OWORD *)&this->fields.m_renderGraphBuilder.m_RenderPass;
		    *(_OWORD *)&retstr->hasValue = 0LL;
		    *(_OWORD *)&retstr->value.m_Resources = 0LL;
		    *(_QWORD *)&retstr->value.m_Disposed = 0LL;
		    *(_OWORD *)&v12.value.m_Resources = v7;
		    sub_1803683D4(retstr, &v12);
		  }
		  return retstr;
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BCFA20-0x0000000189BCFA74
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        ScreenSpaceOverlayPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3313, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3313, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BCF9C0-0x0000000189BCFA20
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        ScreenSpaceOverlayPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3314, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3314, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		  else
		  {
		    *(_OWORD *)&this->fields.m_renderGraphBuilder.m_RenderPass = 0LL;
		    *(_OWORD *)&this->fields.m_renderGraphBuilder.m_RenderGraph = 0LL;
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera, HGSettingParameters settingParameters) {} // 0x0000000189BCF610-0x0000000189BCF8B8
		// Void ConstructPass(ScreenSpaceOverlayPassConstructor+PassInput ByRef, ScreenSpaceOverlayPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::ConstructPass(
		        ScreenSpaceOverlayPassConstructor *this,
		        ScreenSpaceOverlayPassConstructor_PassInput *input,
		        ScreenSpaceOverlayPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  int v13; // eax
		  unsigned __int64 v14; // r9
		  signed __int64 v15; // rtt
		  Object *v16; // r9
		  Object__Class *v17; // rcx
		  unsigned int v18; // r9d
		  unsigned __int64 v19; // r8
		  char v20; // r9
		  signed __int64 v21; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  Object *v25; // [rsp+40h] [rbp-78h] BYREF
		  TextureHandle v26; // [rsp+48h] [rbp-70h] BYREF
		  HGRenderGraphBuilder v27; // [rsp+58h] [rbp-60h] BYREF
		  HGRenderGraphBuilder v28; // [rsp+78h] [rbp-40h] BYREF
		  Void customPayload[16]; // [rsp+98h] [rbp-20h] BYREF
		  Il2CppExceptionWrapper *v30; // [rsp+A8h] [rbp-10h] BYREF
		
		  v25 = 0LL;
		  *(_OWORD *)customPayload = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3315, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3315, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v24, v23);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1218(
		      Patch,
		      (Object *)this,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)camera,
		      (Object *)settingParameters,
		      0LL);
		  }
		  else
		  {
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v27,
		      renderGraph,
		      (String *)"ScreenSpaceOverlay",
		      &v25,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::UIPassData>);
		    v28 = v27;
		    v27.m_RenderPass = 0LL;
		    v27.m_Resources = (HGRenderGraphResourceRegistry *)&v28;
		    try
		    {
		      this->fields.m_renderGraphBuilder = v28;
		      v13 = dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v14 = (((unsigned __int64)&this->fields >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v14 + 36190]);
		        do
		          v15 = qword_18F0BCBA0[v14 + 36190];
		        while ( v15 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v14 + 36190],
		                         v15 | (1LL << (((unsigned __int64)&this->fields >> 12) & 0x3F)),
		                         v15) );
		        v13 = dword_18F35FD08;
		      }
		      v16 = v25;
		      v17 = (Object__Class *)input->camera;
		      if ( !v25 )
		        sub_1800D8250(v17, qword_18F0BCBA0);
		      v25[1].klass = v17;
		      if ( v13 )
		      {
		        v18 = ((unsigned __int64)&v16[1] >> 12) & 0x1FFFFF;
		        v19 = (unsigned __int64)v18 >> 6;
		        v20 = v18 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v19 + 36190]);
		        do
		          v21 = qword_18F0BCBA0[v19 + 36190];
		        while ( v21 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v19 + 36190], v21 | (1LL << v20), v21) );
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(&v26, &v28, &input->target, 0, 0, 0LL);
		      v26 = 0LL;
		      v26.handle._type_k__BackingField = 1065353216;
		      *(TextureHandle *)customPayload = v26;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v28,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor->static_fields->s_UIRenderFunc,
		        0LL,
		        customPayload,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::UIPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v30 )
		    {
		      v27.m_RenderPass = (HGRenderGraphPass *)v30->ex;
		    }
		    sub_180268AE0(&v27);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BCF96C-0x0000000189BCF9C0
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        ScreenSpaceOverlayPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3316, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3316, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x00000001839460E0-0x0000000183946110
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        ScreenSpaceOverlayPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3317, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3317, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		}
		
		public HGRenderGraphBuilder? __iFixBaseProxy_GetRenderGraphBuilder(HGRenderGraph P0) => default; // 0x0000000189B8D878-0x0000000189B8D8B0
		// Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] <>iFixBaseProxy_GetRenderGraphBuilder(HGRenderGraph)
		Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::__iFixBaseProxy_GetRenderGraphBuilder(
		        Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
		        ScreenSpaceOverlayPassConstructor *this,
		        HGRenderGraph *P0,
		        MethodInfo *method)
		{
		  Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *RenderGraphBuilder; // rax
		  __int128 v6; // xmm1
		  __int64 v7; // xmm0_8
		  Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *result; // rax
		  Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v9; // [rsp+20h] [rbp-38h] BYREF
		
		  RenderGraphBuilder = HG::Rendering::Runtime::ComposablePass::GetRenderGraphBuilder(
		                         &v9,
		                         (ComposablePass *)this,
		                         P0,
		                         0LL);
		  v6 = *(_OWORD *)&RenderGraphBuilder->value.m_Resources;
		  *(_OWORD *)&retstr->hasValue = *(_OWORD *)&RenderGraphBuilder->hasValue;
		  v7 = *(_QWORD *)&RenderGraphBuilder->value.m_Disposed;
		  result = retstr;
		  *(_OWORD *)&retstr->value.m_Resources = v6;
		  *(_QWORD *)&retstr->value.m_Disposed = v7;
		  return result;
		}
		
	}
}
