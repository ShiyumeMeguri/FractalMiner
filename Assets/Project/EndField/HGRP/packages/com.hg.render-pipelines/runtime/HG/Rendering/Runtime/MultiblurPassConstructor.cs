using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class MultiblurPassConstructor : IPassConstructor // TypeDefIndex: 38365
	{
		// Fields
		private UberPostPassUtils.FrostedGlassPSMaterials m_frostedGlassPSMaterials; // 0x10
		private static readonly RenderFunc<UIPassData> s_UIRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38361
		{
			// Fields
			public TextureHandle target; // 0x00
			public HGRenderPipeline hgrp; // 0x10
			public CullingResults cullingResults; // 0x18
			public float screenCullingRatio; // 0x28
			public float screenCullingRatioDistance; // 0x2C
			public uint screenCullingLayerMask; // 0x30
		}
	
		internal struct PassOutput // TypeDefIndex: 38362
		{
		}
	
		private class UIPassData // TypeDefIndex: 38363
		{
			// Fields
			public HGCamera camera; // 0x10
			public TextureHandle sceneDepth; // 0x18
			public CullingResults cullResult; // 0x28
			public RendererListHandle renderList; // 0x38
			public uint ecsRenderList; // 0x40
			public uint hgUIRendererList; // 0x44
	
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
		public MultiblurPassConstructor() {} // Dummy constructor
		internal MultiblurPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000183B94AE0-0x0000000183B94B30
		// MultiblurPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::MultiblurPassConstructor::MultiblurPassConstructor(
		        MultiblurPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  MultiblurPassConstructor__Fields *p_fields; // rsi
		
		  p_fields = &this->fields;
		  if ( !TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		  HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassPSMaterials(
		    materialCollector,
		    &p_fields->m_frostedGlassPSMaterials,
		    resources->defaultResources,
		    0LL);
		}
		
		static MultiblurPassConstructor() {} // 0x0000000184D2C970-0x0000000184D2CA00
		// MultiblurPassConstructor()
		void HG::Rendering::Runtime::MultiblurPassConstructor::cctor(MethodInfo *method)
		{
		  struct MultiblurPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_MultiblurPassConstructor_UIPassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::MultiblurPassConstructor::UIPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_MultiblurPassConstructor_UIPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::MultiblurPassConstructor::__c::__cctor_b__11_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor->static_fields->s_UIRenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BBEF4C-0x0000000189BBEFA0
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::MultiblurPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        MultiblurPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3263, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3263, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BBEEF8-0x0000000189BBEF4C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::MultiblurPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        MultiblurPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3264, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3264, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera, HGSettingParameters settingParameters) {} // 0x0000000189BBE6F0-0x0000000189BBEEA4
		// Void ConstructPass(MultiblurPassConstructor+PassInput ByRef, MultiblurPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::MultiblurPassConstructor::ConstructPass(
		        MultiblurPassConstructor *this,
		        MultiblurPassConstructor_PassInput *input,
		        MultiblurPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  Object *v7; // r12
		  MultiblurPassConstructor_PassInput *v9; // r15
		  MultiblurPassConstructor *v10; // r13
		  HGCamera *v11; // rsi
		  int i; // r14d
		  TextureHandle target; // xmm6
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // rcx
		  Object *v17; // rdx
		  unsigned int v18; // edx
		  unsigned __int64 v19; // r8
		  char v20; // dl
		  signed __int64 v21; // rtt
		  TextureHandle v22; // xmm6
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  CullingResults cullingResults; // xmm8
		  HGRenderPipeline *hgrp; // rax
		  Camera *v27; // rcx
		  float screenCullingRatio; // xmm6_4
		  float screenCullingRatioDistance; // xmm7_4
		  uint32_t screenCullingLayerMask; // r13d
		  RendererListDesc *v31; // rax
		  RendererListHandle *v32; // rbx
		  RendererListHandle v33; // rax
		  RendererListHandle v34; // rdx
		  RendererListHandle v35; // rcx
		  Object *v36; // rbx
		  Camera *v37; // rcx
		  __int64 v38; // rdx
		  Object_1 *v39; // rcx
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  HGRenderGraphContext *HGContext; // r13
		  uint32_t RendererList; // eax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  int16_t sortingOrderMax[2]; // [rsp+90h] [rbp-3B8h]
		  int v50; // [rsp+94h] [rbp-3B4h]
		  int32_t cullingMask; // [rsp+98h] [rbp-3B0h]
		  int32_t cameraInstanceID; // [rsp+98h] [rbp-3B0h]
		  int16_t sortingOrderMin[2]; // [rsp+9Ch] [rbp-3ACh]
		  Object *v54; // [rsp+A0h] [rbp-3A8h] BYREF
		  uint32_t cullingLayerMask[4]; // [rsp+B0h] [rbp-398h] BYREF
		  HGRenderGraphBuilder inputa; // [rsp+C0h] [rbp-388h] BYREF
		  __int64 v57; // [rsp+E0h] [rbp-368h]
		  __int128 v58; // [rsp+F0h] [rbp-358h]
		  _QWORD v59[2]; // [rsp+100h] [rbp-348h] BYREF
		  HGRenderGraphBuilder v60; // [rsp+110h] [rbp-338h] BYREF
		  ShaderTagId__Array *uiPassNames; // [rsp+130h] [rbp-318h]
		  Nullable_1_UnityEngine_Rendering_RenderQueueRange_ v62; // [rsp+140h] [rbp-308h] BYREF
		  Il2CppExceptionWrapper *v63; // [rsp+150h] [rbp-2F8h] BYREF
		  TextureHandle v64; // [rsp+158h] [rbp-2F0h] BYREF
		  TextureHandle v65; // [rsp+168h] [rbp-2E0h] BYREF
		  TextureHandle v66; // [rsp+178h] [rbp-2D0h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v67; // [rsp+190h] [rbp-2B8h] BYREF
		  RendererListDesc desc; // [rsp+200h] [rbp-248h] BYREF
		  RendererListDesc v69; // [rsp+2E0h] [rbp-168h] BYREF
		
		  v7 = (Object *)renderGraph;
		  v9 = input;
		  v10 = this;
		  memset(&v60, 0, sizeof(v60));
		  v54 = 0LL;
		  sub_18033B9D0(&v67, 0LL, 112LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3265, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3265, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v48, v47);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1199(
		      Patch,
		      (Object *)v10,
		      v9,
		      output,
		      v7,
		      (Object *)camera,
		      (Object *)settingParameters,
		      0LL);
		  }
		  else
		  {
		    v11 = camera;
		    if ( camera )
		    {
		      for ( i = 1; ; ++i )
		      {
		        v50 = i;
		        if ( i > v11->fields.sortingOrdersToBlurInternal.m_Length )
		          break;
		        *(_DWORD *)sortingOrderMin = *(_DWORD *)&v11->fields.sortingOrdersToBlurInternal.m_Buffer[4 * i - 4];
		        if ( i == v11->fields.sortingOrdersToBlurInternal.m_Length )
		          sortingOrderMax[0] = 0x7FFF;
		        else
		          *(_DWORD *)sortingOrderMax = *(_DWORD *)&v11->fields.sortingOrdersToBlurInternal.m_Buffer[4 * i] - 1;
		        target = v9->target;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		        *(TextureHandle *)&inputa.m_RenderPass = target;
		        HG::Rendering::Runtime::UberPostPassUtils::RenderUIFrostedGlass(
		          (TextureHandle *)&inputa,
		          (HGRenderGraph *)v7,
		          v11,
		          settingParameters,
		          &v10->fields.m_frostedGlassPSMaterials,
		          0LL);
		        if ( !v7 )
		          sub_1800D8260(v15, v14);
		        HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		          &inputa,
		          (HGRenderGraph *)v7,
		          (String *)"Post Frosted Glass UI",
		          &v54,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::MultiblurPassConstructor::UIPassData>);
		        v60 = inputa;
		        v59[0] = 0LL;
		        v59[1] = &v60;
		        try
		        {
		          v17 = v54;
		          if ( !v54 )
		            sub_1800D8250(v16, 0LL);
		          v54[1].klass = (Object__Class *)v11;
		          if ( dword_18F35FD08 )
		          {
		            v18 = ((unsigned __int64)&v17[1] >> 12) & 0x1FFFFF;
		            v19 = (unsigned __int64)v18 >> 6;
		            v20 = v18 & 0x3F;
		            _m_prefetchw(&qword_18F103690[v19]);
		            do
		              v21 = qword_18F103690[v19];
		            while ( v21 != _InterlockedCompareExchange64(&qword_18F103690[v19], v21 | (1LL << v20), v21) );
		            v50 = i;
		          }
		          LODWORD(v58) = 0;
		          DWORD1(v58) = _mm_shuffle_ps((__m128)0LL, (__m128)0LL, 85).m128_u32[0];
		          *((_QWORD *)&v58 + 1) = _mm_shuffle_ps((__m128)0LL, (__m128)0LL, 170).m128_u32[0];
		          *(_OWORD *)&inputa.m_RenderPass = v58;
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            &v64,
		            &v60,
		            &v9->target,
		            0,
		            RenderBufferLoadAction__Enum_Load,
		            RenderBufferStoreAction__Enum_Store,
		            (Color *)&inputa,
		            0,
		            0LL);
		          v22 = v9->target;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		          *(TextureHandle *)&inputa.m_RenderPass = v22;
		          *(TextureHandle *)&inputa.m_RenderPass = *HG::Rendering::Runtime::HGUtils::GeneratePairedDepthTarget(
		                                                      &v65,
		                                                      (HGRenderGraph *)v7,
		                                                      v11,
		                                                      (TextureHandle *)&inputa,
		                                                      0LL);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		            &v66,
		            &v60,
		            (TextureHandle *)&inputa,
		            DepthAccess__Enum_ReadWrite,
		            RenderBufferLoadAction__Enum_Clear,
		            RenderBufferStoreAction__Enum_DontCare,
		            1.0,
		            0,
		            0,
		            0LL);
		          cullingResults = v9->cullingResults;
		          inputa.m_RenderPass = (HGRenderGraphPass *)v11->fields.camera;
		          hgrp = v9->hgrp;
		          if ( !hgrp )
		            sub_1800D8250(v24, v23);
		          uiPassNames = hgrp->fields.uiPassNames;
		          v27 = v11->fields.camera;
		          if ( !v27 )
		            sub_1800D8250(0LL, v23);
		          cullingMask = UnityEngine::Camera::get_cullingMask(v27, 0LL);
		          screenCullingRatio = v9->screenCullingRatio;
		          screenCullingRatioDistance = v9->screenCullingRatioDistance;
		          screenCullingLayerMask = v9->screenCullingLayerMask;
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
		          *(_QWORD *)cullingLayerMask = 0x138800000000LL;
		          v57 = 1LL;
		          sub_18033B9D0(&v67, 0LL, 112LL);
		          *(_QWORD *)&v62.hasValue = v57;
		          v62.value.m_UpperBound = 5000;
		          *(CullingResults *)cullingLayerMask = cullingResults;
		          v31 = HG::Rendering::Runtime::HGRendererListUtils::CreateUIRendererListDesc(
		                  &v69,
		                  (CullingResults *)cullingLayerMask,
		                  (Camera *)inputa.m_RenderPass,
		                  uiPassNames,
		                  cullingMask,
		                  screenCullingRatio,
		                  screenCullingRatioDistance,
		                  screenCullingLayerMask,
		                  PerObjectData__Enum_None,
		                  &v62,
		                  &v67,
		                  0LL,
		                  0,
		                  SortingCriteria__Enum_SortingLayer,
		                  sortingOrderMin[0],
		                  sortingOrderMax[0],
		                  0LL);
		          *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v31->sortingCriteria;
		          desc.stateBlock = v31->stateBlock;
		          v31 = (RendererListDesc *)((char *)v31 + 128);
		          *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v31->sortingCriteria;
		          *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v31->stateBlock.hasValue;
		          *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v31->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		          *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v31->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		          *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v31->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		          *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v31->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		          inputa.m_RenderPass = (HGRenderGraphPass *)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                                                       (HGRenderGraph *)v7,
		                                                       &desc,
		                                                       0LL);
		          v32 = (RendererListHandle *)v54;
		          v33 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                  &v60,
		                  (RendererListHandle *)&inputa,
		                  0LL);
		          if ( !v32 )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v35, v34);
		          v32[7] = v33;
		          if ( !v54 )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v35, v34);
		          LODWORD(v54[4].klass) = -1;
		          v36 = v54;
		          v37 = v11->fields.camera;
		          if ( !v37 )
		            ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(0LL, v34);
		          cullingLayerMask[0] = UnityEngine::Camera::get_cullingMask(v37, 0LL);
		          v39 = (Object_1 *)v11->fields.camera;
		          if ( !v39 )
		            sub_1800D8250(0LL, v38);
		          cameraInstanceID = UnityEngine::Object::GetInstanceID(v39, 0LL);
		          HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext((HGRenderGraph *)v7, 0LL);
		          if ( !HGContext )
		            sub_1800D8250(v41, v40);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          RendererList = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
		                           cullingLayerMask[0],
		                           0,
		                           0,
		                           0x2002060u,
		                           sortingOrderMin[0],
		                           sortingOrderMax[0],
		                           cameraInstanceID,
		                           HGContext->fields.renderContext.m_Ptr,
		                           0,
		                           3.4028235e38,
		                           0LL);
		          if ( !v36 )
		            sub_1800D8250(v45, v44);
		          HIDWORD(v36[4].klass) = RendererList;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		            &v60,
		            (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor->static_fields->s_UIRenderFunc,
		            (Object *)v11,
		            0,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::MultiblurPassConstructor::UIPassData>);
		        }
		        catch ( Il2CppExceptionWrapper *v63 )
		        {
		          v59[0] = v63->ex;
		          sub_180268AE0(v59);
		          v11 = camera;
		          v7 = (Object *)renderGraph;
		          v9 = input;
		          i = v50;
		          goto LABEL_25;
		        }
		        sub_180268AE0(v59);
		LABEL_25:
		        v10 = this;
		      }
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BBEEA4-0x0000000189BBEEF8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::MultiblurPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        MultiblurPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3266, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3266, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000183946190-0x00000001839461F0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::MultiblurPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        MultiblurPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3267, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3267, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::UberPostPassUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
		    HG::Rendering::Runtime::UberPostPassUtils::DisposeFrostedGlassPSMaterials(
		      &this->fields.m_frostedGlassPSMaterials,
		      0LL);
		  }
		}
		
	}
}
