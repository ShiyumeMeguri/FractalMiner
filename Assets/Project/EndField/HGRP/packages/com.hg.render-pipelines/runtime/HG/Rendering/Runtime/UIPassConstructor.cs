using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class UIPassConstructor : ComposablePass, IPassConstructor // TypeDefIndex: 38186
	{
		// Fields
		private const string UI_2D_PASS_NAME = "2D UI Pass"; // Metadata: 0x02303BBB
		private const string UI_3D_PASS_NAME = "3D UI Pass"; // Metadata: 0x02303BC6
		private ProfilingSampler m_cullingSampler; // 0x10
		private HGRenderGraphBuilder m_renderGraphBuilder; // 0x18
		internal static readonly RenderFunc<UIPassData> s_UIRenderFunc; // 0x00
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38181
		{
			// Fields
			internal CullingResults cullingResults; // 0x00
			internal LayerMask uiLayerMask; // 0x10
			internal float renderingScale; // 0x14
			internal TextureHandle target; // 0x18
			internal TextureHandle sceneDepth; // 0x28
			internal HGRenderPipeline hgrp; // 0x38
			internal float screenCullingRatio; // 0x40
			internal float screenCullingRatioDistance; // 0x44
			internal uint screenCullingLayerMask; // 0x48
		}
	
		internal struct PassOutput // TypeDefIndex: 38182
		{
		}
	
		internal class UIPassData // TypeDefIndex: 38183
		{
			// Fields
			public HGCamera camera; // 0x10
			public TextureHandle sceneDepth; // 0x18
			public uint ecsRenderList; // 0x28
			public uint afterUIEcsRenderList; // 0x2C
			public uint hgUiHandle; // 0x30
			public CullingResults cullResult; // 0x38
			public RendererListHandle renderList; // 0x48
	
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
	
		private class BlitBackBufferData // TypeDefIndex: 38184
		{
			// Fields
			public TextureHandle inputBuffer; // 0x10
			public TextureHandle outputBuffer; // 0x20
			public Material blitMaterial; // 0x30
			public HGCamera camera; // 0x38
	
			// Constructors
			public BlitBackBufferData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public UIPassConstructor() {} // 0x0000000183B94A90-0x0000000183B94AE0
		// UIPassConstructor()
		void HG::Rendering::Runtime::UIPassConstructor::UIPassConstructor(UIPassConstructor *this, MethodInfo *method)
		{
		  ProfilingSampler *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ProfilingSampler *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v3 = (ProfilingSampler *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::ProfilingSampler);
		  v6 = v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  UnityEngine::Rendering::ProfilingSampler::ProfilingSampler(v3, (String *)"UI Culling", 0LL);
		  this->fields.m_cullingSampler = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v10);
		}
		
		static UIPassConstructor() {} // 0x0000000184D2C3D0-0x0000000184D2C460
		// UIPassConstructor()
		void HG::Rendering::Runtime::UIPassConstructor::cctor(MethodInfo *method)
		{
		  struct UIPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_UIPassConstructor_UIPassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::UIPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::UIPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::UIPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::UIPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::UIPassConstructor::UIPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_UIPassConstructor_UIPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::UIPassConstructor::__c::__cctor_b__18_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::UIPassConstructor->static_fields->s_UIRenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::UIPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		internal static void PrepareUIPassData(ref PassInput input, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, UIPassData passData) {} // 0x0000000189BA32F4-0x0000000189BA3900
		// Void PrepareUIPassData(UIPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, HGRenderGraphBuilder, UIPassConstructor+UIPassData)
		void HG::Rendering::Runtime::UIPassConstructor::PrepareUIPassData(
		        UIPassConstructor_PassInput *input,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGRenderGraphBuilder *builder,
		        UIPassConstructor_UIPassData *passData,
		        MethodInfo *method)
		{
		  Object *v6; // rsi
		  __int64 v10; // rdx
		  HGGraphicsFeatureSwitch *UISprite; // rcx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  UIPassConstructor_UIPassData__Fields *p_fields; // rcx
		  int32_t m_Mask; // edi
		  MethodInfo *v16; // r8
		  TextureHandle target; // xmm6
		  int sortingOrderMax; // ebx
		  HGRenderPipeline *hgrp; // r14
		  CullingResults cullingResults; // xmm8
		  ShaderTagId__Array *uiPassNames; // r14
		  int32_t v22; // esi
		  float screenCullingRatio; // xmm7_4
		  float screenCullingRatioDistance; // xmm6_4
		  uint32_t screenCullingLayerMask; // edi
		  RendererListDesc *v26; // rax
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm0
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  RendererListHandle InvalidHandle; // rax
		  char v40; // r14
		  RendererListHandle v41; // rax
		  uint32_t v42; // edi
		  uint32_t RendererList; // eax
		  HGRenderGraphContext *HGContext; // rbx
		  uint32_t v45; // eax
		  uint32_t cullingViewHandle; // edi
		  HGRenderGraphContext *v47; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v49; // xmm1
		  MethodInfo *sortingOrderMin; // [rsp+28h] [rbp-F0h]
		  HGRenderKeyword__Enum sortingOrderMina; // [rsp+28h] [rbp-F0h]
		  int32_t cameraInstanceID; // [rsp+9Ch] [rbp-7Ch]
		  uint32_t cullingLayerMask[4]; // [rsp+A8h] [rbp-70h] BYREF
		  Color inputa; // [rsp+B8h] [rbp-60h] BYREF
		  HGRenderGraphBuilder v55; // [rsp+C8h] [rbp-50h] BYREF
		  RendererListDesc desc; // [rsp+E8h] [rbp-30h] BYREF
		  RendererListDesc v57; // [rsp+1C8h] [rbp+B0h] BYREF
		
		  v6 = (Object *)renderGraph;
		  if ( IFix::WrappersManagerImpl::IsPatched(3019, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3019, 0LL);
		    if ( Patch )
		    {
		      v49 = *(_OWORD *)&builder->m_RenderGraph;
		      *(_OWORD *)&v55.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		      *(_OWORD *)&v55.m_RenderGraph = v49;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1121(
		        Patch,
		        input,
		        v6,
		        (Object *)camera,
		        &v55,
		        (Object *)passData,
		        0LL);
		      return;
		    }
		    goto LABEL_34;
		  }
		  if ( !passData )
		    goto LABEL_34;
		  p_fields = &passData->fields;
		  if ( !camera )
		  {
		    passData->fields.camera = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)p_fields, (HGRuntimeGrassQuery_Node *)v10, v12, v13, sortingOrderMin);
		    return;
		  }
		  passData->fields.camera = camera;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)p_fields, (HGRuntimeGrassQuery_Node *)v10, v12, v13, sortingOrderMin);
		  m_Mask = input->uiLayerMask.m_Mask;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  *(_OWORD *)&v55.m_RenderPass = 0LL;
		  *(Color *)&v55.m_RenderPass = *UnityEngine::Color::op_Implicit(&inputa, (Vector4 *)&v55, v16);
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		    (TextureHandle *)&inputa,
		    builder,
		    &input->target,
		    0,
		    (RenderBufferLoadAction__Enum)(m_Mask == TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields->UI_3D_LAYER.m_Mask),
		    RenderBufferStoreAction__Enum_Store,
		    (Color *)&v55,
		    0,
		    0LL);
		  target = input->target;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  *(TextureHandle *)&v55.m_RenderPass = target;
		  *(TextureHandle *)&v55.m_RenderPass = *HG::Rendering::Runtime::HGUtils::GeneratePairedDepthTarget(
		                                           (TextureHandle *)&inputa,
		                                           (HGRenderGraph *)v6,
		                                           camera,
		                                           (TextureHandle *)&v55,
		                                           0LL);
		  HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		    (TextureHandle *)&inputa,
		    builder,
		    (TextureHandle *)&v55,
		    DepthAccess__Enum_ReadWrite,
		    RenderBufferLoadAction__Enum_Clear,
		    RenderBufferStoreAction__Enum_DontCare,
		    1.0,
		    0,
		    0,
		    0LL);
		  if ( camera->fields.sortingOrdersToBlurInternal.m_Length <= 0 )
		    LOWORD(sortingOrderMax) = 0x7FFF;
		  else
		    sortingOrderMax = *(_DWORD *)camera->fields.sortingOrdersToBlurInternal.m_Buffer - 1;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		  UISprite = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->UISprite;
		  if ( !UISprite )
		    goto LABEL_34;
		  if ( !HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(UISprite, 0LL) )
		    goto LABEL_14;
		  UISprite = (HGGraphicsFeatureSwitch *)camera->fields.camera;
		  if ( !UISprite )
		    goto LABEL_34;
		  if ( (UnityEngine::Camera::get_cullingMask((Camera *)UISprite, 0LL) & input->uiLayerMask.m_Mask) != 0 )
		  {
		    hgrp = input->hgrp;
		    *(_QWORD *)&inputa.r = camera->fields.camera;
		    cullingResults = input->cullingResults;
		    if ( !hgrp )
		      goto LABEL_34;
		    uiPassNames = hgrp->fields.uiPassNames;
		    v22 = input->uiLayerMask.m_Mask;
		    screenCullingRatio = input->screenCullingRatio;
		    screenCullingRatioDistance = input->screenCullingRatioDistance;
		    screenCullingLayerMask = input->screenCullingLayerMask;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
		    v55.m_RenderPass = (HGRenderGraphPass *)1;
		    LODWORD(v55.m_Resources) = 0;
		    sub_18033B9D0(&desc, 0LL, 112LL);
		    LODWORD(v55.m_Resources) = 5000;
		    *(CullingResults *)cullingLayerMask = cullingResults;
		    v26 = HG::Rendering::Runtime::HGRendererListUtils::CreateUIRendererListDesc(
		            &v57,
		            (CullingResults *)cullingLayerMask,
		            *(Camera **)&inputa.r,
		            uiPassNames,
		            v22,
		            screenCullingRatio,
		            screenCullingRatioDistance,
		            screenCullingLayerMask,
		            PerObjectData__Enum_None,
		            (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v55,
		            (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&desc,
		            0LL,
		            0,
		            SortingCriteria__Enum_SortingLayer,
		            0x8000,
		            sortingOrderMax,
		            0LL);
		    v6 = (Object *)renderGraph;
		    v10 = 128LL;
		    v27 = *(_OWORD *)&v26->stateBlock.hasValue;
		    *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v26->sortingCriteria;
		    v28 = *(_OWORD *)&v26->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc.stateBlock.hasValue = v27;
		    v29 = *(_OWORD *)&v26->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v28;
		    v30 = *(_OWORD *)&v26->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v29;
		    v31 = *(_OWORD *)&v26->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v30;
		    v32 = *(_OWORD *)&v26->stateBlock.value.m_RasterState.m_OffsetFactor;
		    *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v31;
		    *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v32;
		    UISprite = (HGGraphicsFeatureSwitch *)&desc.overrideMaterial;
		    v33 = *(_OWORD *)&v26->stateBlock.value.m_StencilState.m_FailOperationFront;
		    v26 = (RendererListDesc *)((char *)v26 + 128);
		    *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v33;
		    v34 = *(_OWORD *)&v26->stateBlock.hasValue;
		    *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v26->sortingCriteria;
		    v35 = *(_OWORD *)&v26->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc.overrideMaterialPassIndex = v34;
		    v36 = *(_OWORD *)&v26->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc.sortingLayerMin = v35;
		    v37 = *(_OWORD *)&v26->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc.drawableFeedbackPtr = v36;
		    v38 = *(_OWORD *)&v26->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		    *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v37;
		    *(_OWORD *)&desc._passName_k__BackingField.m_Id = v38;
		    if ( !renderGraph )
		      goto LABEL_34;
		    InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		    v40 = 1;
		  }
		  else
		  {
		LABEL_14:
		    v40 = 0;
		    InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		  }
		  *(RendererListHandle *)&inputa.r = InvalidHandle;
		  v41 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		          builder,
		          (RendererListHandle *)&inputa,
		          0LL);
		  v10 = 0LL;
		  passData->fields.renderList = v41;
		  v42 = -1;
		  if ( v40 )
		  {
		    UISprite = (HGGraphicsFeatureSwitch *)camera->fields.camera;
		    cullingLayerMask[0] = input->uiLayerMask.m_Mask;
		    if ( !UISprite )
		      goto LABEL_34;
		    cameraInstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)UISprite, 0LL);
		    if ( !v6 )
		      goto LABEL_34;
		    *(_QWORD *)&inputa.r = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext((HGRenderGraph *)v6, 0LL);
		    if ( !*(_QWORD *)&inputa.r )
		      goto LABEL_34;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    RendererList = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
		                     cullingLayerMask[0],
		                     0,
		                     0,
		                     0x2002060u,
		                     0x8000,
		                     sortingOrderMax,
		                     cameraInstanceID,
		                     *(void **)(*(_QWORD *)&inputa.r + 16LL),
		                     0,
		                     3.4028235e38,
		                     0LL);
		  }
		  else
		  {
		    RendererList = -1;
		  }
		  passData->fields.hgUiHandle = RendererList;
		  if ( v40 )
		  {
		    cullingLayerMask[0] = camera->fields.cullingViewHandle;
		    if ( !v6 )
		      goto LABEL_34;
		    HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext((HGRenderGraph *)v6, 0LL);
		    if ( !HGContext )
		      goto LABEL_34;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    LOWORD(sortingOrderMina) = 0;
		    v45 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		            cullingLayerMask[0],
		            HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
		            HGRenderFlags__Enum_Transparent,
		            HGShaderLightMode__Enum_SRPDefaultUnlit|HGShaderLightMode__Enum_Forward|HGShaderLightMode__Enum_ForwardOnly,
		            sortingOrderMina,
		            HGContext->fields.renderContext.m_Ptr,
		            0,
		            1,
		            input->uiLayerMask.m_Mask,
		            0,
		            0,
		            0LL);
		  }
		  else
		  {
		    v45 = -1;
		  }
		  passData->fields.ecsRenderList = v45;
		  if ( !v40 )
		    goto LABEL_30;
		  cullingViewHandle = camera->fields.cullingViewHandle;
		  if ( !v6 || (v47 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext((HGRenderGraph *)v6, 0LL)) == 0LL )
		LABEL_34:
		    sub_1800D8260(UISprite, v10);
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		  LOWORD(sortingOrderMina) = 0;
		  v42 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		          cullingViewHandle,
		          HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
		          HGRenderFlags__Enum_Transparent,
		          HGShaderLightMode__Enum_ForwardAfterUI,
		          sortingOrderMina,
		          v47->fields.renderContext.m_Ptr,
		          0,
		          1,
		          input->uiLayerMask.m_Mask,
		          0,
		          0,
		          0LL);
		LABEL_30:
		  passData->fields.afterUIEcsRenderList = v42;
		  passData->fields.sceneDepth = input->sceneDepth;
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input->sceneDepth, 0LL) )
		    HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		      (TextureHandle *)&v55,
		      builder,
		      &input->sceneDepth,
		      0LL);
		}
		
		private bool CullUI(CommandBuffer cmd, ScriptableRenderContext ctx, Camera camera, LayerMask uiLayerMask, out CullingResults cullResults) {
			cullResults = default;
			return default;
		} // 0x0000000189BA2F74-0x0000000189BA3138
		// Boolean CullUI(CommandBuffer, ScriptableRenderContext, Camera, LayerMask, CullingResults ByRef)
		// Hidden C++ exception states: #wind=1
		bool HG::Rendering::Runtime::UIPassConstructor::CullUI(
		        UIPassConstructor *this,
		        CommandBuffer *cmd,
		        ScriptableRenderContext ctx,
		        Camera *camera,
		        LayerMask uiLayerMask,
		        CullingResults *cullResults,
		        MethodInfo *method)
		{
		  bool v11; // di
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  bool CullingParameters_Internal; // al
		  CullingResults *v16; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  char v21; // [rsp+41h] [rbp-687h] BYREF
		  Il2CppException *ex; // [rsp+48h] [rbp-680h]
		  char *v23; // [rsp+50h] [rbp-678h]
		  Il2CppExceptionWrapper *v24; // [rsp+58h] [rbp-670h] BYREF
		  CullingResults v25; // [rsp+60h] [rbp-668h] BYREF
		  ScriptableCullingParameters cullingParameters; // [rsp+70h] [rbp-658h] BYREF
		  ScriptableRenderContext v27; // [rsp+6E0h] [rbp+18h] BYREF
		
		  v27.m_Ptr = ctx.m_Ptr;
		  v11 = 0;
		  v21 = 0;
		  sub_18033B9D0(&cullingParameters, 0LL, 1592LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(3020, 0LL) )
		  {
		    try
		    {
		      ex = 0LL;
		      v23 = &v21;
		      if ( !camera )
		        sub_1800D8250(v14, v13);
		      CullingParameters_Internal = UnityEngine::Camera::GetCullingParameters_Internal(
		                                     camera,
		                                     0,
		                                     &cullingParameters,
		                                     1592,
		                                     0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v24 )
		    {
		      ex = v24->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      return 0;
		    }
		    if ( CullingParameters_Internal )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		      cullingParameters.m_CameraProperties.cameraWorldToClip.m31 = 0.0;
		      LODWORD(cullingParameters.m_CameraProperties.cameraFar) = (LayerMask)uiLayerMask.m_Mask;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      v16 = UnityEngine::Rendering::ScriptableRenderContext::Cull(&v25, &v27, &cullingParameters, 0LL);
		      *cullResults = *v16;
		      return 1;
		    }
		    else
		    {
		      *cullResults = 0LL;
		    }
		    return v11;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3020, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v20, v19);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1122(
		           Patch,
		           (Object *)this,
		           (Object *)cmd,
		           ctx,
		           (Object *)camera,
		           uiLayerMask,
		           cullResults,
		           0LL);
		}
		
		protected override HGRenderGraphBuilder? GetRenderGraphBuilder(HGRenderGraph renderGraph) => default; // 0x0000000189BA3138-0x0000000189BA31EC
		// Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] GetRenderGraphBuilder(HGRenderGraph)
		Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::UIPassConstructor::GetRenderGraphBuilder(
		        Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
		        UIPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int128 v7; // xmm2
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v12; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3021, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3021, 0LL);
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
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BA32A0-0x0000000189BA32F4
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::UIPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        UIPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3022, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3022, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BA3240-0x0000000189BA32A0
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::UIPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        UIPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3023, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3023, 0LL);
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
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera, HGSettingParameters settingParameters) {} // 0x0000000189BA2CE4-0x0000000189BA2F74
		// Void ConstructPass(UIPassConstructor+PassInput ByRef, UIPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::UIPassConstructor::ConstructPass(
		        UIPassConstructor *this,
		        UIPassConstructor_PassInput *input,
		        UIPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  int32_t m_Mask; // ebx
		  __int64 v12; // rdx
		  HGUtils__StaticFields *static_fields; // rcx
		  char *v14; // rsi
		  unsigned __int64 v15; // r8
		  signed __int64 v16; // rtt
		  UIPassConstructor_UIPassData *v17; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  UIPassConstructor_UIPassData *v21; // [rsp+40h] [rbp-98h] BYREF
		  _QWORD v22[2]; // [rsp+48h] [rbp-90h] BYREF
		  HGRenderGraphBuilder v23; // [rsp+58h] [rbp-80h] BYREF
		  HGRenderGraphBuilder v24; // [rsp+80h] [rbp-58h] BYREF
		  HGRenderGraphBuilder v25; // [rsp+A0h] [rbp-38h] BYREF
		  Il2CppExceptionWrapper *v26; // [rsp+C0h] [rbp-18h] BYREF
		
		  v21 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3024, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3024, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v20, v19);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1123(
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
		    m_Mask = input->uiLayerMask.m_Mask;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGUtils->static_fields;
		    v14 = "3D UI Pass";
		    if ( m_Mask == static_fields->UI_2D_LAYER.m_Mask )
		      v14 = "2D UI Pass";
		    if ( !renderGraph )
		      sub_1800D8260(static_fields, v12);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v25,
		      renderGraph,
		      (String *)v14,
		      (Object **)&v21,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UIPassConstructor::UIPassData>);
		    v23 = v25;
		    v22[0] = 0LL;
		    v22[1] = &v23;
		    try
		    {
		      *(_OWORD *)&v24.m_RenderPass = *(_OWORD *)&v23.m_RenderPass;
		      *(_OWORD *)&this->fields.m_renderGraphBuilder.m_RenderPass = *(_OWORD *)&v23.m_RenderPass;
		      *(_OWORD *)&v25.m_RenderPass = *(_OWORD *)&v23.m_RenderGraph;
		      *(_OWORD *)&this->fields.m_renderGraphBuilder.m_RenderGraph = *(_OWORD *)&v23.m_RenderGraph;
		      if ( dword_18F35FD08 )
		      {
		        v15 = (((unsigned __int64)&this->fields.m_renderGraphBuilder >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F103690[v15]);
		        do
		          v16 = qword_18F103690[v15];
		        while ( v16 != _InterlockedCompareExchange64(
		                         &qword_18F103690[v15],
		                         v16 | (1LL << (((unsigned __int64)&this->fields.m_renderGraphBuilder >> 12) & 0x3F)),
		                         v16) );
		        *(_OWORD *)&v25.m_RenderPass = *(_OWORD *)&v23.m_RenderGraph;
		        *(_OWORD *)&v24.m_RenderPass = *(_OWORD *)&v23.m_RenderPass;
		      }
		      v17 = v21;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
		      *(_OWORD *)&v24.m_RenderGraph = *(_OWORD *)&v25.m_RenderPass;
		      HG::Rendering::Runtime::UIPassConstructor::PrepareUIPassData(input, renderGraph, camera, &v24, v17, 0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v23,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UIPassConstructor->static_fields->s_UIRenderFunc,
		        (Object *)camera,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIPassConstructor::UIPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v26 )
		    {
		      v22[0] = v26->ex;
		    }
		    sub_180268AE0(v22);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BA31EC-0x0000000189BA3240
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::UIPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        UIPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3025, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3025, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000183946110-0x0000000183946140
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::UIPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        UIPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3026, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3026, 0LL);
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
