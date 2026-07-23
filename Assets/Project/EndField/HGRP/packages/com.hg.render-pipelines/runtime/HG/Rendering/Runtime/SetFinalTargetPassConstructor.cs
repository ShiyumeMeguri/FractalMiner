using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class SetFinalTargetPassConstructor : IPassConstructor // TypeDefIndex: 38416
	{
		// Fields
		private Material m_CopyDepth; // 0x10
		private static readonly RenderFunc<SetFinalTargetPassData> s_setFinalTargetRenderFunc; // 0x00
		private static readonly RenderFunc<SetFinalTargetPassData> s_copyColorFunc; // 0x08
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38412
		{
			// Fields
			internal TextureHandle finalResult; // 0x00
			internal TextureHandle sceneDepth; // 0x10
			internal TextureHandle backBufferColor; // 0x20
			internal TextureHandle backBufferDepth; // 0x30
		}
	
		internal struct PassOutput // TypeDefIndex: 38413
		{
		}
	
		private class SetFinalTargetPassData // TypeDefIndex: 38414
		{
			// Fields
			public TextureHandle finalResult; // 0x10
			public TextureHandle finalTarget; // 0x20
			public TextureHandle depthBuffer; // 0x30
			public bool flipY; // 0x40
			public Material copyDepthMaterial; // 0x48
	
			// Constructors
			public SetFinalTargetPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public SetFinalTargetPassConstructor() {} // Dummy constructor
		internal SetFinalTargetPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000184CCB070-0x0000000184CCB0C0
		// SetFinalTargetPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::SetFinalTargetPassConstructor::SetFinalTargetPassConstructor(
		        SetFinalTargetPassConstructor *this,
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
		  this->fields.m_CopyDepth = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                               materialCollector,
		                               shaders->fields.copyDepthBufferPS,
		                               0,
		                               0LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v6, v7, v8, v9);
		}
		
		static SetFinalTargetPassConstructor() {} // 0x0000000184CB3E40-0x0000000184CB3F40
		// SetFinalTargetPassConstructor()
		void HG::Rendering::Runtime::SetFinalTargetPassConstructor::cctor(MethodInfo *method)
		{
		  struct SetFinalTargetPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node__Class *v6; // rbx
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rdi
		  RenderFunc_1_System_Object_ *v11; // rax
		  MonitorData *v12; // rbx
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::SetFinalTargetPassConstructor::SetFinalTargetPassData>);
		  v6 = (HGRuntimeGrassQuery_Node__Class *)v3;
		  if ( !v3
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v3,
		          v2,
		          MethodInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor::__c::__cctor_b__12_0,
		          0LL),
		        static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor->static_fields,
		        static_fields->klass = v6,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor->static_fields,
		          static_fields,
		          v8,
		          v9,
		          v16),
		        v10 = (Object *)TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor::__c->static_fields->__9,
		        v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::SetFinalTargetPassConstructor::SetFinalTargetPassData>),
		        (v12 = (MonitorData *)v11) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v11,
		    v10,
		    MethodInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor::__c::__cctor_b__12_1,
		    0LL);
		  v13 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor->static_fields;
		  v13->monitor = v12;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor->static_fields->s_copyColorFunc,
		    v13,
		    v14,
		    v15,
		    v17);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BD0018-0x0000000189BD006C
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::SetFinalTargetPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        SetFinalTargetPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3331, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3331, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BCFFC4-0x0000000189BD0018
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::SetFinalTargetPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        SetFinalTargetPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3332, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3332, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BCFA74-0x0000000189BCFF70
		// Void ConstructPass(SetFinalTargetPassConstructor+PassInput ByRef, SetFinalTargetPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::SetFinalTargetPassConstructor::ConstructPass(
		        SetFinalTargetPassConstructor *this,
		        SetFinalTargetPassConstructor_PassInput *input,
		        SetFinalTargetPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  Object *v6; // r14
		  SetFinalTargetPassConstructor_PassInput *v8; // rsi
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Object_1 *targetTexture; // rbx
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  RenderTexture *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  __int64 v20; // r8
		  TextureHandle *v21; // rbx
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  TextureHandle v24; // xmm0
		  __int64 v25; // rbx
		  bool isMainGameView; // al
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  __int64 v29; // rdx
		  unsigned int v30; // edx
		  unsigned __int64 v31; // r8
		  char v32; // dl
		  signed __int64 v33; // rtt
		  ResourceHandle handle; // rbx
		  TextureHandle *nullHandle; // rax
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  Object *v38; // rbx
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  TextureHandle v41; // xmm0
		  Object *v42; // rbx
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  TextureHandle v45; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  __int64 v49; // [rsp+50h] [rbp-B8h] BYREF
		  Il2CppException *ex; // [rsp+58h] [rbp-B0h] BYREF
		  HGRenderGraphBuilder *v51; // [rsp+60h] [rbp-A8h]
		  Object *v52; // [rsp+68h] [rbp-A0h] BYREF
		  HGRenderGraphBuilder v53; // [rsp+70h] [rbp-98h] BYREF
		  HGRenderGraphBuilder v54; // [rsp+90h] [rbp-78h] BYREF
		  HGRenderGraphBuilder v55; // [rsp+B0h] [rbp-58h] BYREF
		  __m128i si128; // [rsp+D0h] [rbp-38h] BYREF
		  Il2CppExceptionWrapper *v57; // [rsp+E0h] [rbp-28h] BYREF
		  Il2CppExceptionWrapper *v58; // [rsp+E8h] [rbp-20h] BYREF
		
		  v6 = (Object *)renderGraph;
		  v8 = input;
		  memset(&v54, 0, sizeof(v54));
		  v49 = 0LL;
		  memset(&v55, 0, sizeof(v55));
		  v52 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3333, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3333, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v48, v47);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1223(Patch, (Object *)this, v8, output, v6, (Object *)camera, 0LL);
		  }
		  else
		  {
		    if ( !camera )
		      sub_1800D8260(v11, v10);
		    if ( !camera->fields.camera )
		      sub_1800D8260(v11, v10);
		    targetTexture = (Object_1 *)UnityEngine::Camera::get_targetTexture(camera->fields.camera, 0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(targetTexture, 0LL, 0LL) )
		    {
		      if ( !camera->fields.camera )
		        sub_1800D8260(v14, v13);
		      v15 = UnityEngine::Camera::get_targetTexture(camera->fields.camera, 0LL);
		      if ( !v15 )
		        sub_1800D8260(v17, v16);
		      if ( UnityEngine::RenderTexture::get_depth(v15, 0LL) )
		      {
		        if ( !v6 )
		          sub_1800D8260(v19, v18);
		        v54 = *(HGRenderGraphBuilder *)sub_1808AF9E8(&v53, v6, v20, &v49);
		        ex = 0LL;
		        v51 = &v54;
		        try
		        {
		          si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            (TextureHandle *)&v53,
		            &v54,
		            &v8->backBufferColor,
		            0,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_Store,
		            (Color *)&si128,
		            0,
		            0LL);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		            (TextureHandle *)&v53,
		            &v54,
		            &v8->backBufferDepth,
		            DepthAccess__Enum_Write,
		            0,
		            0LL);
		          v21 = (TextureHandle *)v49;
		          v24 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                   (TextureHandle *)&v53,
		                   &v54,
		                   &v8->sceneDepth,
		                   0LL);
		          if ( !v21 )
		            sub_1800D8250(v23, v22);
		          v21[3] = v24;
		          v25 = v49;
		          isMainGameView = HG::Rendering::Runtime::HGCamera::get_isMainGameView(camera, 0LL);
		          if ( !v25 )
		            sub_1800D8250(v28, v27);
		          *(_BYTE *)(v25 + 64) = isMainGameView;
		          v29 = v49;
		          if ( !v49 )
		            sub_1800D8250(v28, 0LL);
		          *(_QWORD *)(v49 + 72) = this->fields.m_CopyDepth;
		          if ( dword_18F35FD08 )
		          {
		            v30 = ((unsigned __int64)(v29 + 72) >> 12) & 0x1FFFFF;
		            v31 = (unsigned __int64)v30 >> 6;
		            v32 = v30 & 0x3F;
		            _m_prefetchw(&qword_18F103690[v31]);
		            do
		              v33 = qword_18F103690[v31];
		            while ( v33 != _InterlockedCompareExchange64(&qword_18F103690[v31], v33 | (1LL << v32), v33) );
		          }
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		            &v54,
		            (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor->static_fields->s_setFinalTargetRenderFunc,
		            0LL,
		            0,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SetFinalTargetPassConstructor::SetFinalTargetPassData>);
		        }
		        catch ( Il2CppExceptionWrapper *v57 )
		        {
		          ex = v57->ex;
		          sub_180268AE0(&ex);
		          v6 = (Object *)renderGraph;
		          v8 = input;
		          goto LABEL_18;
		        }
		        sub_180268AE0(&ex);
		      }
		    }
		LABEL_18:
		    handle = v8->finalResult.handle;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::ResourceHandle);
		    handle.m_Value = HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(handle, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle((TextureHandle *)&v53, 0LL);
		    if ( handle.m_Value != HG::Rendering::RenderGraphModule::ResourceHandle::op_Implicit(nullHandle->handle, 0LL) )
		    {
		      if ( !v6 )
		        sub_1800D8250(v37, v36);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v53,
		        (HGRenderGraph *)v6,
		        (String *)"Set Final Target",
		        &v52,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::SetFinalTargetPassConstructor::SetFinalTargetPassData>);
		      v55 = v53;
		      ex = 0LL;
		      v51 = &v55;
		      try
		      {
		        v38 = v52;
		        v41 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&v53,
		                 &v55,
		                 &v8->finalResult,
		                 0LL);
		        if ( !v38 )
		          sub_1800D8250(v40, v39);
		        v38[1] = (Object)v41;
		        v42 = v52;
		        v45 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                 (TextureHandle *)&v53,
		                 &v55,
		                 &v8->backBufferColor,
		                 0LL);
		        if ( !v42 )
		          sub_1800D8250(v44, v43);
		        v42[2] = (Object)v45;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v55,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::SetFinalTargetPassConstructor->static_fields->s_copyColorFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SetFinalTargetPassConstructor::SetFinalTargetPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v58 )
		      {
		        ex = v58->ex;
		        sub_180268AE0(&ex);
		        return;
		      }
		      sub_180268AE0(&ex);
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BCFF70-0x0000000189BCFFC4
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::SetFinalTargetPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        SetFinalTargetPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3334, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3334, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D7FF00-0x0000000184D7FF30
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::SetFinalTargetPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        SetFinalTargetPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3335, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3335, 0LL);
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
