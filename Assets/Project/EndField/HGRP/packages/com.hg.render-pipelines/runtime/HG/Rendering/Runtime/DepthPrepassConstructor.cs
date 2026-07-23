using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class DepthPrepassConstructor : IPassConstructor // TypeDefIndex: 38232
	{
		// Fields
		private static readonly RenderFunc<DepthPrepassData> s_depthPrepassRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38228
		{
			// Fields
			internal TextureHandle sceneDepth; // 0x00
			internal TextureHandle gBufferDepth; // 0x10
			internal HGRenderPipeline hgrp; // 0x20
			internal CullingResults cullingResults; // 0x28
			internal bool characterDepthOnlyEnable; // 0x38
			internal float screenCullingRatio; // 0x3C
			internal float screenCullingRatioDistance; // 0x40
			internal uint screenCullingLayerMask; // 0x44
			internal uint deferredOpaquePreZGPUDrivenList; // 0x48
			internal uint deferredOpaqueGPUDrivenList; // 0x4C
			internal uint deferredOpaquePreZECSList; // 0x50
			internal uint forwardOpaquePreZECSList; // 0x54
			internal uint deferredGrassPreZECSList; // 0x58
			internal uint deferredTreePreZECSList; // 0x5C
		}
	
		internal struct PassOutput // TypeDefIndex: 38229
		{
		}
	
		private class DepthPrepassData // TypeDefIndex: 38230
		{
			// Fields
			public int cameraGuid; // 0x10
			public int cameraCullingMask; // 0x14
			public FrameSettings frameSettings; // 0x18
			public RendererListHandle rendererList; // 0x30
			internal uint deferredOpaquePreZGPUDrivenList; // 0x38
			internal uint deferredOpaqueGPUDrivenList; // 0x3C
			internal uint deferredOpaquePreZECSList; // 0x40
			internal uint forwardOpaquePreZECSList; // 0x44
			internal uint deferredGrassPreZECSList; // 0x48
			internal uint deferredTreePreZECSList; // 0x4C
	
			// Constructors
			public DepthPrepassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public DepthPrepassConstructor() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static DepthPrepassConstructor() {} // 0x0000000184D2D030-0x0000000184D2D0C0
		// DepthPrepassConstructor()
		void HG::Rendering::Runtime::DepthPrepassConstructor::cctor(MethodInfo *method)
		{
		  struct DepthPrepassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_DepthPrepassConstructor_DepthPrepassData_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthPrepassConstructor::DepthPrepassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_DepthPrepassConstructor_DepthPrepassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::DepthPrepassConstructor::__c::__cctor_b__10_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor->static_fields->s_depthPrepassRenderFunc = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189B9C248-0x0000000189B9C29C
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::DepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        DepthPrepassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3088, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3088, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189B9C1F4-0x0000000189B9C248
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        DepthPrepassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3089, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3089, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189B9BC3C-0x0000000189B9C1A0
		// Void ConstructPass(DepthPrepassConstructor+PassInput ByRef, DepthPrepassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::DepthPrepassConstructor::ConstructPass(
		        DepthPrepassConstructor *this,
		        DepthPrepassConstructor_PassInput *input,
		        DepthPrepassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  HGGraphicsFeatureSwitch *preZ; // rcx
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  MonitorData *v17; // xmm1_8
		  Object *v18; // rcx
		  HGRenderPipeline *hgrp; // rax
		  ShaderTagId__Array *depthOnlyPassNames; // r15
		  float screenCullingRatio; // xmm7_4
		  float screenCullingRatioDistance; // xmm6_4
		  uint32_t screenCullingLayerMask; // ebx
		  RendererListDesc *v24; // rax
		  RendererListHandle InvalidHandle; // rax
		  RendererListHandle *v26; // rbx
		  RendererListHandle v27; // rax
		  RendererListHandle v28; // rdx
		  RendererListHandle v29; // rcx
		  Object *v30; // rbx
		  Object_1 *v31; // rcx
		  int32_t InstanceID; // eax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  Object *v35; // rbx
		  Camera *v36; // rcx
		  int32_t cullingMask; // eax
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  __int64 deferredOpaquePreZGPUDrivenList; // rcx
		  __int64 deferredOpaqueGPUDrivenList; // rcx
		  __int64 deferredOpaquePreZECSList; // rcx
		  __int64 forwardOpaquePreZECSList; // rcx
		  __int64 deferredGrassPreZECSList; // rcx
		  __int64 deferredTreePreZECSList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  Object *v49; // [rsp+70h] [rbp-278h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderQueueRange_ inputa; // [rsp+80h] [rbp-268h] BYREF
		  _QWORD v51[2]; // [rsp+90h] [rbp-258h] BYREF
		  HGRenderGraphBuilder v52; // [rsp+A0h] [rbp-248h] BYREF
		  HGRenderGraphBuilder v53; // [rsp+C0h] [rbp-228h] BYREF
		  Il2CppExceptionWrapper *v54; // [rsp+E0h] [rbp-208h] BYREF
		  RendererListDesc desc; // [rsp+F0h] [rbp-1F8h] BYREF
		  RendererListDesc v56; // [rsp+1D0h] [rbp-118h] BYREF
		
		  v49 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3090, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3090, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v48, v47);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1143(
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
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x14u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v52,
		      renderGraph,
		      (String *)"DepthPrepass",
		      &v49,
		      v10,
		      1,
		      ProfilingHGPass__Enum_PreDepth,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthPrepassConstructor::DepthPrepassData>);
		    v53 = v52;
		    v51[0] = 0LL;
		    v51[1] = &v53;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		        (TextureHandle *)&v52,
		        &v53,
		        &input->sceneDepth,
		        DepthAccess__Enum_Write,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->gBufferDepth, 0LL) )
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v52,
		          &v53,
		          &input->gBufferDepth,
		          0,
		          0,
		          0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      preZ = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->preZ;
		      if ( !preZ )
		        sub_1800D8250(0LL, v13);
		      LOBYTE(v15) = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(preZ, 0LL);
		      if ( !camera )
		        sub_1800D8250(v16, v15);
		      v17 = *(MonitorData **)&camera->fields._frameSettings_k__BackingField.materialQuality;
		      v18 = v49;
		      if ( !v49 )
		        sub_1800D8250(0LL, v15);
		      *(BitArray128 *)((char *)v49 + 24) = camera->fields._frameSettings_k__BackingField.bitDatas;
		      v18[2].monitor = v17;
		      hgrp = input->hgrp;
		      if ( !hgrp )
		        sub_1800D8250(v18, v15);
		      depthOnlyPassNames = hgrp->fields.depthOnlyPassNames;
		      if ( (_BYTE)v15 )
		      {
		        screenCullingRatio = input->screenCullingRatio;
		        screenCullingRatioDistance = input->screenCullingRatioDistance;
		        screenCullingLayerMask = input->screenCullingLayerMask;
		        *(_QWORD *)&inputa.hasValue = 0LL;
		        sub_18033B9D0(&desc, 0LL, 112LL);
		        inputa.value.m_UpperBound = 0;
		        *(CullingResults *)&v52.m_RenderPass = input->cullingResults;
		        v24 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
		                &v56,
		                (CullingResults *)&v52,
		                camera->fields.camera,
		                depthOnlyPassNames,
		                screenCullingRatio,
		                screenCullingRatioDistance,
		                screenCullingLayerMask,
		                PerObjectData__Enum_None,
		                &inputa,
		                (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&desc,
		                0LL,
		                0,
		                0LL);
		        *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v24->sortingCriteria;
		        desc.stateBlock = v24->stateBlock;
		        v24 = (RendererListDesc *)((char *)v24 + 128);
		        *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v24->sortingCriteria;
		        *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v24->stateBlock.hasValue;
		        *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v24->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v24->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v24->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		        *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v24->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		        InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		      }
		      else
		      {
		        InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		      }
		      *(RendererListHandle *)&inputa.hasValue = InvalidHandle;
		      v26 = (RendererListHandle *)v49;
		      v27 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		              &v53,
		              (RendererListHandle *)&inputa,
		              0LL);
		      if ( !v26 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v29, v28);
		      v26[6] = v27;
		      v30 = v49;
		      v31 = (Object_1 *)camera->fields.camera;
		      if ( !v31 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(0LL, v28);
		      InstanceID = UnityEngine::Object::GetInstanceID(v31, 0LL);
		      if ( !v30 )
		        sub_1800D8250(v34, v33);
		      LODWORD(v30[1].klass) = InstanceID;
		      v35 = v49;
		      v36 = camera->fields.camera;
		      if ( !v36 )
		        sub_1800D8250(0LL, v33);
		      cullingMask = UnityEngine::Camera::get_cullingMask(v36, 0LL);
		      if ( !v35 )
		        sub_1800D8250(v39, v38);
		      HIDWORD(v35[1].klass) = cullingMask;
		      deferredOpaquePreZGPUDrivenList = input->deferredOpaquePreZGPUDrivenList;
		      if ( !v49 )
		        sub_1800D8250(deferredOpaquePreZGPUDrivenList, v38);
		      LODWORD(v49[3].monitor) = deferredOpaquePreZGPUDrivenList;
		      deferredOpaqueGPUDrivenList = input->deferredOpaqueGPUDrivenList;
		      if ( !v49 )
		        sub_1800D8250(deferredOpaqueGPUDrivenList, v38);
		      HIDWORD(v49[3].monitor) = deferredOpaqueGPUDrivenList;
		      deferredOpaquePreZECSList = input->deferredOpaquePreZECSList;
		      if ( !v49 )
		        sub_1800D8250(deferredOpaquePreZECSList, v38);
		      LODWORD(v49[4].klass) = deferredOpaquePreZECSList;
		      forwardOpaquePreZECSList = input->forwardOpaquePreZECSList;
		      if ( !v49 )
		        sub_1800D8250(forwardOpaquePreZECSList, v38);
		      HIDWORD(v49[4].klass) = forwardOpaquePreZECSList;
		      deferredGrassPreZECSList = input->deferredGrassPreZECSList;
		      if ( !v49 )
		        sub_1800D8250(deferredGrassPreZECSList, v38);
		      LODWORD(v49[4].monitor) = deferredGrassPreZECSList;
		      deferredTreePreZECSList = input->deferredTreePreZECSList;
		      if ( !v49 )
		        sub_1800D8250(deferredTreePreZECSList, v38);
		      HIDWORD(v49[4].monitor) = deferredTreePreZECSList;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v53,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DepthPrepassConstructor->static_fields->s_depthPrepassRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthPrepassConstructor::DepthPrepassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v54 )
		    {
		      v51[0] = v54->ex;
		    }
		    sub_180268AE0(v51);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189B9C1A0-0x0000000189B9C1F4
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        DepthPrepassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3091, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3091, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D806E0-0x0000000184D80710
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::DepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        DepthPrepassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3092, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3092, 0LL);
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
