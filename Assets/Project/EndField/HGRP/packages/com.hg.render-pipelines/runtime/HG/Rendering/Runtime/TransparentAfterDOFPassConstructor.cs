using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class TransparentAfterDOFPassConstructor : IPassConstructor // TypeDefIndex: 38289
	{
		// Fields
		public ShadowResult shadowResult; // 0x10
		private static readonly RenderFunc<ForwardPassUtils.ForwardTransparentAfterDOFPassData> s_forwardTransparentAfterDOFRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38286
		{
			// Fields
			internal bool characterOutlineEnabled; // 0x00
			internal uint forwardTransparentAfterDOFECSList; // 0x04
			internal uint screenCullingLayerMask; // 0x08
			internal float screenCullingRatio; // 0x0C
			internal float screenCullingRatioDistance; // 0x10
			internal PerObjectData bakedLightConfig; // 0x14
			internal ShadowResult shadowResult; // 0x18
			internal CullingResults cullingResults; // 0x58
			internal TextureHandle sceneColor; // 0x68
			internal TextureHandle sceneDepth; // 0x78
			internal TextureHandle sceneMV; // 0x88
			internal HGRenderPipeline hgrp; // 0x98
		}
	
		internal struct PassOutput // TypeDefIndex: 38287
		{
			// Fields
			internal TextureHandle sceneColor; // 0x00
		}
	
		// Constructors
		public TransparentAfterDOFPassConstructor() {} // Dummy constructor
		internal TransparentAfterDOFPassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static TransparentAfterDOFPassConstructor() {} // 0x0000000184D2C580-0x0000000184D2C610
		// TransparentAfterDOFPassConstructor()
		void HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::cctor(MethodInfo *method)
		{
		  struct TransparentAfterDOFPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_ForwardPassUtils_ForwardTransparentAfterDOFPassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentAfterDOFPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_ForwardPassUtils_ForwardTransparentAfterDOFPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::__c::__cctor_b__10_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor->static_fields->s_forwardTransparentAfterDOFRenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189BB2E40-0x0000000189BB34A8
		// Void ConstructPass(TransparentAfterDOFPassConstructor+PassInput ByRef, TransparentAfterDOFPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::ConstructPass(
		        TransparentAfterDOFPassConstructor *this,
		        TransparentAfterDOFPassConstructor_PassInput *input,
		        TransparentAfterDOFPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  ProfilingSampler *v12; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Object *v15; // r14
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  TextureHandle v18; // xmm0
		  TextureDesc *TextureDescRef; // rax
		  TransparentAfterDOFPassConstructor_PassOutput *Texture; // rax
		  Color v21; // xmm0
		  __int128 v22; // xmm6
		  __int128 v23; // xmm7
		  __int64 v24; // rdx
		  HGGraphicsFeatureSwitch *forwardTransparent; // rcx
		  __int64 v26; // rcx
		  bool enabledForCPUCommands; // r15
		  Object *v28; // rdx
		  unsigned int v29; // edx
		  unsigned __int64 v30; // r8
		  char v31; // dl
		  signed __int64 v32; // rtt
		  RendererListHandle *v33; // r14
		  RendererListHandle InvalidHandle; // rax
		  RendererListHandle v35; // rdx
		  RendererListHandle v36; // rcx
		  RendererListHandle *v37; // r14
		  unsigned int bakedLightConfig; // ecx
		  float screenCullingRatio; // xmm2_4
		  float screenCullingRatioDistance; // xmm1_4
		  uint32_t screenCullingLayerMask; // eax
		  RendererListDesc *v42; // rax
		  RendererListHandle v43; // rax
		  RendererListHandle v44; // rdx
		  RendererListHandle v45; // rcx
		  __int64 forwardTransparentAfterDOFECSList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  Object *v50; // [rsp+50h] [rbp-2E8h] BYREF
		  CullingResults si128; // [rsp+60h] [rbp-2D8h] BYREF
		  FrameSettings frameSettings_k__BackingField; // [rsp+70h] [rbp-2C8h] BYREF
		  HGRenderGraphBuilder v53; // [rsp+88h] [rbp-2B0h] BYREF
		  RendererListHandle inputa[2]; // [rsp+B0h] [rbp-288h] BYREF
		  _QWORD v55[2]; // [rsp+C0h] [rbp-278h] BYREF
		  HGRenderGraphBuilder v56; // [rsp+D0h] [rbp-268h] BYREF
		  Il2CppExceptionWrapper *v57; // [rsp+F0h] [rbp-248h] BYREF
		  ShadowResult v58; // [rsp+F8h] [rbp-240h] BYREF
		  RendererListDesc desc; // [rsp+140h] [rbp-1F8h] BYREF
		  RendererListDesc v60; // [rsp+220h] [rbp-118h] BYREF
		
		  v50 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3182, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3182, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v49, v48);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1176(
		      Patch,
		      (Object *)this,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else
		  {
		    if ( !hgCamera )
		      sub_1800D8260(v11, v10);
		    frameSettings_k__BackingField = hgCamera->fields._frameSettings_k__BackingField;
		    if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		           &frameSettings_k__BackingField,
		           FrameSettingsField__Enum_TransparentObjects,
		           0LL) )
		    {
		      v12 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x92u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !renderGraph )
		        sub_1800D8260(v14, v13);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v56,
		        renderGraph,
		        (String *)"Forward Transparent After DOF",
		        &v50,
		        v12,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentAfterDOFPassData>);
		      v53 = v56;
		      v55[0] = 0LL;
		      v55[1] = &v53;
		      try
		      {
		        v15 = v50;
		        v18 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                 (TextureHandle *)&si128,
		                 &v53,
		                 &input->sceneColor,
		                 0LL);
		        if ( !v15 )
		          sub_1800D8250(v17, v16);
		        v15[2] = (Object)v18;
		        TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
		                           renderGraph,
		                           &input->sceneColor,
		                           0LL);
		        Texture = (TransparentAfterDOFPassConstructor_PassOutput *)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                                     (TextureHandle *)&si128,
		                                                                     renderGraph,
		                                                                     TextureDescRef,
		                                                                     0LL);
		        v21 = (Color)*Texture;
		        *output = *Texture;
		        si128 = (CullingResults)v21;
		        *(__m128i *)&inputa[0].m_IsValid = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v56,
		          &v53,
		          (TextureHandle *)&si128,
		          0,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)inputa,
		          0,
		          0LL);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		          (TextureHandle *)&v56,
		          &v53,
		          &input->sceneDepth,
		          DepthAccess__Enum_Read,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->sceneMV, 0LL) )
		        {
		          si128 = (CullingResults)_mm_load_si128((const __m128i *)&xmmword_18B959540);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            (TextureHandle *)&v56,
		            &v53,
		            &input->sceneMV,
		            1,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_Store,
		            (Color *)&si128,
		            0,
		            0LL);
		        }
		        frameSettings_k__BackingField = hgCamera->fields._frameSettings_k__BackingField;
		        if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		               &frameSettings_k__BackingField,
		               FrameSettingsField__Enum_ShadowMaps,
		               0LL)
		          || (frameSettings_k__BackingField = hgCamera->fields._frameSettings_k__BackingField,
		              HG::Rendering::Runtime::FrameSettings::IsEnabled(
		                &frameSettings_k__BackingField,
		                FrameSettingsField__Enum_CharacterShadowMaps,
		                0LL)) )
		        {
		          v22 = *(_OWORD *)&v53.m_RenderPass;
		          v23 = *(_OWORD *)&v53.m_RenderGraph;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
		          *(_OWORD *)&v56.m_RenderPass = v22;
		          *(_OWORD *)&v56.m_RenderGraph = v23;
		          HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(&v58, &input->shadowResult, &v56, 0LL);
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		        forwardTransparent = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardTransparent;
		        if ( !forwardTransparent )
		          sub_1800D8250(0LL, v24);
		        enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                  forwardTransparent,
		                                  0LL);
		        v28 = v50;
		        if ( !v50 )
		          sub_1800D8250(v26, 0LL);
		        v50[1].monitor = (MonitorData *)hgCamera;
		        if ( dword_18F35FD08 )
		        {
		          v29 = ((unsigned __int64)&v28[1].monitor >> 12) & 0x1FFFFF;
		          v30 = (unsigned __int64)v29 >> 6;
		          v31 = v29 & 0x3F;
		          _m_prefetchw(&qword_18F103690[v30]);
		          do
		            v32 = qword_18F103690[v30];
		          while ( v32 != _InterlockedCompareExchange64(&qword_18F103690[v30], v32 | (1LL << v31), v32) );
		        }
		        v33 = (RendererListHandle *)v50;
		        InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		        if ( !v33 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v36, v35);
		        v33[6] = InvalidHandle;
		        if ( !v50 )
		          ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v36, v35);
		        LODWORD(v50[1].klass) = -1;
		        frameSettings_k__BackingField = hgCamera->fields._frameSettings_k__BackingField;
		        if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		               &frameSettings_k__BackingField,
		               FrameSettingsField__Enum_TransparentObjects,
		               0LL)
		          && enabledForCPUCommands )
		        {
		          v37 = (RendererListHandle *)v50;
		          bakedLightConfig = input->bakedLightConfig;
		          screenCullingRatio = input->screenCullingRatio;
		          screenCullingRatioDistance = input->screenCullingRatioDistance;
		          screenCullingLayerMask = input->screenCullingLayerMask;
		          si128 = input->cullingResults;
		          v42 = HG::Rendering::Runtime::ForwardPassUtils::PrepareAfterDOFTranparentRendererList(
		                  &v60,
		                  input->hgrp,
		                  hgCamera,
		                  input->characterOutlineEnabled,
		                  &si128,
		                  (PerObjectData__Enum)bakedLightConfig,
		                  screenCullingRatio,
		                  screenCullingRatioDistance,
		                  screenCullingLayerMask,
		                  0LL);
		          *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v42->sortingCriteria;
		          desc.stateBlock = v42->stateBlock;
		          v42 = (RendererListDesc *)((char *)v42 + 128);
		          *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v42->sortingCriteria;
		          *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v42->stateBlock.hasValue;
		          *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v42->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		          *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v42->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		          *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v42->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		          *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v42->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		          inputa[0] = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		          v43 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v53, inputa, 0LL);
		          if ( !v37 )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v45, v44);
		          v37[6] = v43;
		          forwardTransparentAfterDOFECSList = input->forwardTransparentAfterDOFECSList;
		          if ( !v50 )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(forwardTransparentAfterDOFECSList, v44);
		          LODWORD(v50[1].klass) = forwardTransparentAfterDOFECSList;
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v53,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor->static_fields->s_forwardTransparentAfterDOFRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentAfterDOFPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v57 )
		      {
		        v55[0] = v57->ex;
		      }
		      sub_180268AE0(v55);
		    }
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BB3550-0x0000000189BB35A4
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        TransparentAfterDOFPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3183, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3183, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BB34FC-0x0000000189BB3550
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        TransparentAfterDOFPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3184, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3184, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BB34A8-0x0000000189BB34FC
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        TransparentAfterDOFPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3185, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3185, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D7FD80-0x0000000184D7FDB0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        TransparentAfterDOFPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3186, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3186, 0LL);
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
