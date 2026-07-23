using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class ForwardPassUtils // TypeDefIndex: 38273
	{
		// Nested types
		internal class ForwardOpaquePassData // TypeDefIndex: 38269
		{
			// Fields
			internal HGCamera camera; // 0x10
			internal RendererListHandle opaqueRenderList; // 0x18
			internal RendererListHandle characterOutlineOpaqueRenderList; // 0x20
			internal uint forwardOpaqueECSRendererList; // 0x28
			internal uint forwardOpaqueEqualECSRendererList; // 0x2C
			internal uint characterOpaqueECSRendererList; // 0x30
			internal uint characterOutlineOpaqueECSRendererList; // 0x34
			internal uint characterOutlineOpaqueEqualECSRendererList; // 0x38
	
			// Constructors
			public ForwardOpaquePassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		internal class ForwardTransparentPassData // TypeDefIndex: 38270
		{
			// Fields
			internal HGCamera camera; // 0x10
			internal TextureHandle sceneColorToSample; // 0x18
			internal TextureHandle sceneDepthToSample; // 0x28
			internal TextureHandle sceneDepthWithWater; // 0x38
			internal GBufferProfileManager.GBufferProfileConfig gBufferProfileConfig; // 0x48
			internal TextureHandle[] gbuffer; // 0x50
			internal TextureHandle depthPyramidTexture; // 0x58
			internal RendererListHandle transparentRenderList; // 0x68
			internal RendererListHandle vfxDecalRenderList; // 0x70
			internal uint forwardTransparentECSList; // 0x78
			internal uint forwardDecalECSList; // 0x7C
			internal uint vfxDecalECSList; // 0x80
			internal uint hgUIRendererList; // 0x84
			internal uint forwardTransparentAfterUIECSList; // 0x88
			internal WaterOnePassDeferredRenderingPass waterRenderingPass; // 0x90
			internal bool transparentVRS; // 0x98
			internal int transparentVRRx; // 0x9C
			internal int transparentVRRy; // 0xA0
			internal bool lowResRendering; // 0xA4
			internal BasicTransformConstants basicTransformConstants; // 0xA8
			internal ShaderVariablesGlobal shaderVariablesGlobal; // 0x5C8
	
			// Constructors
			public ForwardTransparentPassData() {} // 0x0000000189BADC18-0x0000000189BADC68
			// ForwardPassUtils+ForwardTransparentPassData()
			void HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentPassData::ForwardTransparentPassData(
			        ForwardPassUtils_ForwardTransparentPassData *this,
			        MethodInfo *method)
			{
			  struct HGRenderGraph__Class *v2; // rax
			  Type *v4; // rdx
			  PropertyInfo_1 *v5; // r8
			  Int32__Array **v6; // r9
			  MethodInfo *v7; // [rsp+50h] [rbp+28h]
			
			  v2 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
			  if ( !TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
			    v2 = TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph;
			  }
			  this->fields.gbuffer = (TextureHandle__Array *)il2cpp_array_new_specific_1(
			                                                   TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle,
			                                                   v2->static_fields->kMaxMRTCount);
			  sub_18002D1B0((SingleFieldAccessor *)&this->fields.gbuffer, v4, v5, v6, v7);
			}
			
		}
	
		internal class ForwardTransparentAfterDOFPassData // TypeDefIndex: 38271
		{
			// Fields
			internal uint forwardTransparentAfterDOFECSList; // 0x10
			internal HGCamera camera; // 0x18
			internal TextureHandle sceneColorToSample; // 0x20
			internal RendererListHandle transparentRenderList; // 0x30
	
			// Constructors
			public ForwardTransparentAfterDOFPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		internal class ForwardPassData // TypeDefIndex: 38272
		{
			// Fields
			internal ForwardOpaquePassData opaqueData; // 0x10
			internal ForwardTransparentPassData transparentData; // 0x18
	
			// Constructors
			public ForwardPassData() {} // 0x0000000189BAB144-0x0000000189BAB1AC
			// ForwardPassUtils+ForwardPassData()
			void HG::Rendering::Runtime::ForwardPassUtils::ForwardPassData::ForwardPassData(
			        ForwardPassUtils_ForwardPassData *this,
			        MethodInfo *method)
			{
			  ForwardPassUtils_ForwardOpaquePassData *v3; // rax
			  Type *v4; // rdx
			  __int64 v5; // rcx
			  PropertyInfo_1 *v6; // r8
			  Int32__Array **v7; // r9
			  ForwardPassUtils_ForwardTransparentPassData *v8; // rax
			  ForwardPassUtils_ForwardTransparentPassData *v9; // rdi
			  Type *v10; // rdx
			  PropertyInfo_1 *v11; // r8
			  Int32__Array **v12; // r9
			  MethodInfo *v13; // [rsp+20h] [rbp-8h]
			  MethodInfo *v14; // [rsp+50h] [rbp+28h]
			
			  v3 = (ForwardPassUtils_ForwardOpaquePassData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::ForwardPassUtils::ForwardOpaquePassData);
			  if ( !v3
			    || (this->fields.opaqueData = v3,
			        sub_18002D1B0((SingleFieldAccessor *)&this->fields, v4, v6, v7, v13),
			        v8 = (ForwardPassUtils_ForwardTransparentPassData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentPassData),
			        (v9 = v8) == 0LL) )
			  {
			    sub_1800D8260(v5, v4);
			  }
			  HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentPassData::ForwardTransparentPassData(v8, 0LL);
			  this->fields.transparentData = v9;
			  sub_18002D1B0((SingleFieldAccessor *)&this->fields.transparentData, v10, v11, v12, v14);
			}
			
		}
	
		// Constructors
		public ForwardPassUtils() {} // 0x00000001841E1670-0x00000001841E1680
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
		
	
		// Methods
		internal static void PrepareOpaquePassData(HGRenderPipeline hgrp, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, CullingResults cullingResults, PerObjectData bakedLightingConfig, uint forwardOpaqueECSRendererList, uint forwardOpaqueEqualECSRendererList, uint characterOpaqueECSRendererList, uint characterOutlineOpaqueECSRendererList, uint characterOutlineOpaqueEqualECSRendererList, bool characterOutlineEnabled, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask, ForwardOpaquePassData opaqueData) {} // 0x0000000189BABE94-0x0000000189BAC2F8
		// Void PrepareOpaquePassData(HGRenderPipeline, HGRenderGraph, HGCamera, HGRenderGraphBuilder, CullingResults, PerObjectData, UInt32, UInt32, UInt32, UInt32, UInt32, Boolean, Single, Single, UInt32, ForwardPassUtils+ForwardOpaquePassData)
		void HG::Rendering::Runtime::ForwardPassUtils::PrepareOpaquePassData(
		        HGRenderPipeline *hgrp,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        HGRenderGraphBuilder *builder,
		        CullingResults *cullingResults,
		        PerObjectData__Enum bakedLightingConfig,
		        uint32_t forwardOpaqueECSRendererList,
		        uint32_t forwardOpaqueEqualECSRendererList,
		        uint32_t characterOpaqueECSRendererList,
		        uint32_t characterOutlineOpaqueECSRendererList,
		        uint32_t characterOutlineOpaqueEqualECSRendererList,
		        bool characterOutlineEnabled,
		        float screenCullingRatio,
		        float screenCullingRatioDistance,
		        uint32_t screenCullingLayerMask,
		        ForwardPassUtils_ForwardOpaquePassData *opaqueData,
		        MethodInfo *method)
		{
		  Type *static_fields; // rdx
		  HGGraphicsFeatureSwitch *forwardOpaque; // rcx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  bool enabledForCPUCommands; // r15
		  bool v26; // r12
		  __int64 v27; // xmm1_8
		  RendererListDesc *v28; // rax
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  __int128 v41; // xmm1
		  uint64_t InvalidHandle; // rax
		  RendererListDesc *v43; // rax
		  __int128 v44; // xmm1
		  __int128 v45; // xmm0
		  __int128 v46; // xmm1
		  __int128 v47; // xmm0
		  __int128 v48; // xmm1
		  __int128 v49; // xmm0
		  __int128 v50; // xmm1
		  __int128 v51; // xmm0
		  __int128 v52; // xmm1
		  __int128 v53; // xmm0
		  __int128 v54; // xmm1
		  __int128 v55; // xmm0
		  __int128 v56; // xmm1
		  uint64_t v57; // rax
		  RendererListHandle v58; // rax
		  MethodInfo *v59; // [rsp+28h] [rbp-F0h]
		  FrameSettings v60; // [rsp+98h] [rbp-80h] BYREF
		  HGRenderGraphBuilder v61; // [rsp+B8h] [rbp-60h] BYREF
		  RendererListDesc desc; // [rsp+D8h] [rbp-40h] BYREF
		  RendererListDesc v63; // [rsp+1B8h] [rbp+A0h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3147, 0LL) )
		  {
		    if ( opaqueData )
		    {
		      opaqueData->fields.camera = camera;
		      sub_18002D1B0((SingleFieldAccessor *)&opaqueData->fields, static_fields, v23, v24, v59);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      forwardOpaque = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardOpaque;
		      if ( forwardOpaque )
		      {
		        enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                  forwardOpaque,
		                                  0LL);
		        static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		        forwardOpaque = (HGGraphicsFeatureSwitch *)static_fields[9].monitor;
		        if ( forwardOpaque )
		        {
		          v26 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(forwardOpaque, 0LL);
		          if ( camera )
		          {
		            v27 = *(_QWORD *)&camera->fields._frameSettings_k__BackingField.materialQuality;
		            v60.bitDatas = camera->fields._frameSettings_k__BackingField.bitDatas;
		            *(_QWORD *)&v60.materialQuality = v27;
		            if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(&v60, FrameSettingsField__Enum_OpaqueObjects, 0LL) )
		            {
		              if ( enabledForCPUCommands )
		              {
		                v60.bitDatas = (BitArray128)*cullingResults;
		                v28 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardOpaqueRendererList(
		                        &v63,
		                        hgrp,
		                        camera,
		                        (CullingResults *)&v60,
		                        bakedLightingConfig,
		                        screenCullingRatio,
		                        screenCullingRatioDistance,
		                        screenCullingLayerMask,
		                        0LL);
		                v29 = *(_OWORD *)&v28->stateBlock.hasValue;
		                *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v28->sortingCriteria;
		                v30 = *(_OWORD *)&v28->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.stateBlock.hasValue = v29;
		                v31 = *(_OWORD *)&v28->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v30;
		                v32 = *(_OWORD *)&v28->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v31;
		                v33 = *(_OWORD *)&v28->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v32;
		                v34 = *(_OWORD *)&v28->stateBlock.value.m_RasterState.m_OffsetFactor;
		                *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v33;
		                v35 = *(_OWORD *)&v28->stateBlock.value.m_StencilState.m_FailOperationFront;
		                v28 = (RendererListDesc *)((char *)v28 + 128);
		                *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v34;
		                forwardOpaque = (HGGraphicsFeatureSwitch *)&desc.overrideMaterial;
		                v36 = *(_OWORD *)&v28->sortingCriteria;
		                *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v35;
		                v37 = *(_OWORD *)&v28->stateBlock.hasValue;
		                *(_OWORD *)&desc.overrideMaterial = v36;
		                v38 = *(_OWORD *)&v28->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.overrideMaterialPassIndex = v37;
		                v39 = *(_OWORD *)&v28->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.sortingLayerMin = v38;
		                v40 = *(_OWORD *)&v28->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.drawableFeedbackPtr = v39;
		                v41 = *(_OWORD *)&v28->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v40;
		                *(_OWORD *)&desc._passName_k__BackingField.m_Id = v41;
		                if ( !renderGraph )
		                  goto LABEL_21;
		                InvalidHandle = (uint64_t)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                                            renderGraph,
		                                            &desc,
		                                            0LL);
		              }
		              else
		              {
		                InvalidHandle = (uint64_t)HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		              }
		              v60.bitDatas.data1 = InvalidHandle;
		              opaqueData->fields.opaqueRenderList = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                                                      builder,
		                                                      (RendererListHandle *)&v60,
		                                                      0LL);
		              opaqueData->fields.forwardOpaqueECSRendererList = forwardOpaqueECSRendererList;
		              opaqueData->fields.forwardOpaqueEqualECSRendererList = forwardOpaqueEqualECSRendererList;
		              opaqueData->fields.characterOpaqueECSRendererList = characterOpaqueECSRendererList;
		              opaqueData->fields.characterOutlineOpaqueECSRendererList = characterOutlineOpaqueECSRendererList;
		              opaqueData->fields.characterOutlineOpaqueEqualECSRendererList = characterOutlineOpaqueEqualECSRendererList;
		            }
		            if ( !characterOutlineEnabled )
		            {
		              v58 = 0LL;
		              goto LABEL_19;
		            }
		            if ( !v26 )
		            {
		              v57 = (uint64_t)HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		              goto LABEL_17;
		            }
		            v43 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardOpaqueCharacterOutlineRendererList(
		                    &v63,
		                    hgrp,
		                    camera,
		                    cullingResults,
		                    bakedLightingConfig,
		                    screenCullingRatio,
		                    screenCullingRatioDistance,
		                    screenCullingLayerMask,
		                    0LL);
		            v44 = *(_OWORD *)&v43->stateBlock.hasValue;
		            *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v43->sortingCriteria;
		            v45 = *(_OWORD *)&v43->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc.stateBlock.hasValue = v44;
		            v46 = *(_OWORD *)&v43->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v45;
		            v47 = *(_OWORD *)&v43->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v46;
		            v48 = *(_OWORD *)&v43->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v47;
		            v49 = *(_OWORD *)&v43->stateBlock.value.m_RasterState.m_OffsetFactor;
		            *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v48;
		            v50 = *(_OWORD *)&v43->stateBlock.value.m_StencilState.m_FailOperationFront;
		            v43 = (RendererListDesc *)((char *)v43 + 128);
		            *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v49;
		            forwardOpaque = (HGGraphicsFeatureSwitch *)&desc.overrideMaterial;
		            v51 = *(_OWORD *)&v43->sortingCriteria;
		            *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v50;
		            v52 = *(_OWORD *)&v43->stateBlock.hasValue;
		            *(_OWORD *)&desc.overrideMaterial = v51;
		            v53 = *(_OWORD *)&v43->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc.overrideMaterialPassIndex = v52;
		            v54 = *(_OWORD *)&v43->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc.sortingLayerMin = v53;
		            v55 = *(_OWORD *)&v43->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc.drawableFeedbackPtr = v54;
		            v56 = *(_OWORD *)&v43->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		            *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v55;
		            *(_OWORD *)&desc._passName_k__BackingField.m_Id = v56;
		            if ( renderGraph )
		            {
		              v57 = (uint64_t)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                                renderGraph,
		                                &desc,
		                                0LL);
		LABEL_17:
		              v60.bitDatas.data1 = v57;
		              v58 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                      builder,
		                      (RendererListHandle *)&v60,
		                      0LL);
		LABEL_19:
		              opaqueData->fields.characterOutlineOpaqueRenderList = v58;
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_21:
		    sub_1800D8260(forwardOpaque, static_fields);
		  }
		  forwardOpaque = (HGGraphicsFeatureSwitch *)IFix::WrappersManagerImpl::GetPatch(3147, 0LL);
		  if ( !forwardOpaque )
		    goto LABEL_21;
		  *(_OWORD *)&v61.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		  v60.bitDatas = (BitArray128)*cullingResults;
		  *(_OWORD *)&v61.m_RenderGraph = *(_OWORD *)&builder->m_RenderGraph;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1159(
		    (ILFixDynamicMethodWrapper_2 *)forwardOpaque,
		    (Object *)hgrp,
		    (Object *)renderGraph,
		    (Object *)camera,
		    &v61,
		    (CullingResults *)&v60,
		    bakedLightingConfig,
		    forwardOpaqueECSRendererList,
		    forwardOpaqueEqualECSRendererList,
		    characterOpaqueECSRendererList,
		    characterOutlineOpaqueECSRendererList,
		    characterOutlineOpaqueEqualECSRendererList,
		    characterOutlineEnabled,
		    screenCullingRatio,
		    screenCullingRatioDistance,
		    screenCullingLayerMask,
		    (Object *)opaqueData,
		    0LL);
		}
		
		internal static void PrepareTransparentPassData(HGRenderPipeline hgrp, HGRenderGraph renderGraph, TextureHandle sceneColorToSample, TextureHandle sceneDepthToSample, TextureHandle sceneDepthWithWater, HGCamera camera, WaterOnePassDeferredRenderingPass waterRenderingPass, HGRenderGraphBuilder builder, CullingResults cullingResults, PerObjectData bakedLightingConfig, uint forwardTransparentECSList, bool characterOutlineEnabled, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask, ForwardTransparentPassData transparentData, bool transparentVRS = false /* Metadata: 0x02303C75 */, int transparentVRRx = 1 /* Metadata: 0x02303C76 */, int transparentVRRy = 1 /* Metadata: 0x02303C77 */, bool lowResRendering = false /* Metadata: 0x02303C78 */, [IsReadOnly] in BasicTransformConstants basicTransformConstants = null, [IsReadOnly] in ShaderVariablesGlobal shaderVariablesGlobal = null) {} // 0x0000000189BAC2F8-0x0000000189BACBB4
		// Void PrepareTransparentPassData(HGRenderPipeline, HGRenderGraph, TextureHandle, TextureHandle, TextureHandle, HGCamera, WaterOnePassDeferredRenderingPass, HGRenderGraphBuilder, CullingResults, PerObjectData, UInt32, Boolean, Single, Single, UInt32, ForwardPassUtils+ForwardTransparentPassData, Boolean, Int32, Int32, Boolean, BasicTransformConstants ByRef, ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::ForwardPassUtils::PrepareTransparentPassData(
		        HGRenderPipeline *hgrp,
		        HGRenderGraph *renderGraph,
		        TextureHandle *sceneColorToSample,
		        TextureHandle *sceneDepthToSample,
		        TextureHandle *sceneDepthWithWater,
		        HGCamera *camera,
		        WaterOnePassDeferredRenderingPass *waterRenderingPass,
		        HGRenderGraphBuilder *builder,
		        CullingResults *cullingResults,
		        PerObjectData__Enum bakedLightingConfig,
		        uint32_t forwardTransparentECSList,
		        bool characterOutlineEnabled,
		        float screenCullingRatio,
		        float screenCullingRatioDistance,
		        uint32_t screenCullingLayerMask,
		        ForwardPassUtils_ForwardTransparentPassData *transparentData,
		        bool transparentVRS,
		        int32_t transparentVRRx,
		        int32_t transparentVRRy,
		        bool lowResRendering,
		        BasicTransformConstants *basicTransformConstants,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  __int64 static_fields; // rdx
		  HGGraphicsFeatureSwitch *forwardTransparent; // rcx
		  PropertyInfo_1 *v29; // r8
		  WaterOnePassDeferredRenderingPass *v30; // r9
		  __int128 v31; // xmm1
		  Type *v32; // rdx
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **v34; // r9
		  bool enabledForCPUCommands; // bl
		  bool v36; // r12
		  HGRenderGraph *v37; // xmm1_8
		  RendererListDesc *v38; // rax
		  __int128 v39; // xmm1
		  __int128 v40; // xmm0
		  __int128 v41; // xmm1
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  __int128 v48; // xmm0
		  __int128 v49; // xmm1
		  __int128 v50; // xmm0
		  __int128 v51; // xmm1
		  RendererListHandle InvalidHandle; // rax
		  ShaderTagId__Array *vfxDecalPassNames; // rbx
		  RendererListDesc *TransparentRendererListDesc; // rax
		  __int128 v55; // xmm1
		  __int128 v56; // xmm0
		  __int128 v57; // xmm1
		  __int128 v58; // xmm0
		  __int128 v59; // xmm1
		  __int128 v60; // xmm0
		  __int128 v61; // xmm1
		  __int128 v62; // xmm0
		  __int128 v63; // xmm1
		  __int128 v64; // xmm0
		  __int128 v65; // xmm1
		  __int128 v66; // xmm0
		  __int128 v67; // xmm1
		  RendererListHandle v68; // rax
		  uint32_t cullingViewHandle; // r15d
		  HGRenderGraphContext *HGContext; // rbx
		  uint32_t RendererList; // eax
		  uint32_t v72; // r15d
		  HGRenderGraphContext *v73; // rbx
		  uint32_t v74; // eax
		  int32_t cullingMask; // ebx
		  LayerMask v76; // eax
		  int32_t m_Mask; // r15d
		  int32_t InstanceID; // esi
		  HGRenderGraphContext *v79; // rbx
		  uint32_t v80; // eax
		  __int128 v81; // xmm0
		  TextureHandle v82; // xmm0
		  TextureHandle v83; // xmm1
		  MethodInfo *globalKeywords; // [rsp+28h] [rbp-120h]
		  MethodInfo *globalKeywordsa; // [rsp+28h] [rbp-120h]
		  HGRenderKeyword__Enum globalKeywordsb; // [rsp+28h] [rbp-120h]
		  bool v87; // [rsp+C8h] [rbp-80h]
		  TextureHandle v88; // [rsp+D8h] [rbp-70h] BYREF
		  RendererListHandle input[2]; // [rsp+E8h] [rbp-60h] BYREF
		  CullingResults v90; // [rsp+F8h] [rbp-50h] BYREF
		  HGRenderGraphBuilder v91; // [rsp+108h] [rbp-40h] BYREF
		  HGRenderGraphBuilder v92; // [rsp+128h] [rbp-20h] BYREF
		  RendererListDesc desc; // [rsp+148h] [rbp+0h] BYREF
		  RendererListDesc v94; // [rsp+228h] [rbp+E0h] BYREF
		  RendererListDesc v95[14]; // [rsp+308h] [rbp+1C0h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3148, 0LL) )
		  {
		    if ( transparentData )
		    {
		      transparentData->fields.waterRenderingPass = waterRenderingPass;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&transparentData->fields.waterRenderingPass,
		        (Type *)static_fields,
		        v29,
		        (Int32__Array **)waterRenderingPass,
		        globalKeywords);
		      if ( v30 )
		      {
		        v31 = *(_OWORD *)&builder->m_RenderGraph;
		        *(_OWORD *)&v91.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		        *(_OWORD *)&v91.m_RenderGraph = v31;
		        HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PrepareInTransparentPass(v30, &v91, 0LL);
		      }
		      transparentData->fields.sceneColorToSample = *sceneColorToSample;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(sceneColorToSample, 0LL) )
		        transparentData->fields.sceneColorToSample = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                                        (TextureHandle *)&v91,
		                                                        builder,
		                                                        sceneColorToSample,
		                                                        0LL);
		      transparentData->fields.sceneDepthToSample = *sceneDepthToSample;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(sceneDepthToSample, 0LL) )
		        transparentData->fields.sceneDepthToSample = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                                        (TextureHandle *)&v91,
		                                                        builder,
		                                                        sceneDepthToSample,
		                                                        0LL);
		      transparentData->fields.sceneDepthWithWater = *sceneDepthWithWater;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(sceneDepthWithWater, 0LL) )
		        transparentData->fields.sceneDepthWithWater = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                                         (TextureHandle *)&v91,
		                                                         builder,
		                                                         sceneDepthWithWater,
		                                                         0LL);
		      transparentData->fields.camera = camera;
		      sub_18002D1B0((SingleFieldAccessor *)&transparentData->fields, v32, v33, v34, globalKeywordsa);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      forwardTransparent = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardTransparent;
		      if ( forwardTransparent )
		      {
		        enabledForCPUCommands = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(
		                                  forwardTransparent,
		                                  0LL);
		        static_fields = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		        forwardTransparent = *(HGGraphicsFeatureSwitch **)(static_fields + 208);
		        if ( forwardTransparent )
		        {
		          v87 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(forwardTransparent, 0LL);
		          static_fields = (__int64)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields;
		          forwardTransparent = *(HGGraphicsFeatureSwitch **)(static_fields + 248);
		          if ( forwardTransparent )
		          {
		            v36 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(forwardTransparent, 0LL);
		            transparentData->fields.forwardTransparentECSList = -1;
		            transparentData->fields.forwardDecalECSList = -1;
		            transparentData->fields.vfxDecalECSList = -1;
		            if ( camera )
		            {
		              v37 = *(HGRenderGraph **)&camera->fields._frameSettings_k__BackingField.materialQuality;
		              *(BitArray128 *)&v91.m_RenderPass = camera->fields._frameSettings_k__BackingField.bitDatas;
		              v91.m_RenderGraph = v37;
		              if ( !HG::Rendering::Runtime::FrameSettings::IsEnabled(
		                      (FrameSettings *)&v91,
		                      FrameSettingsField__Enum_TransparentObjects,
		                      0LL) )
		                return;
		              if ( enabledForCPUCommands )
		              {
		                v90 = *cullingResults;
		                v38 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardTransparentRendererList(
		                        &v94,
		                        hgrp,
		                        camera,
		                        0,
		                        characterOutlineEnabled,
		                        &v90,
		                        bakedLightingConfig,
		                        screenCullingRatio,
		                        screenCullingRatioDistance,
		                        screenCullingLayerMask,
		                        0LL);
		                static_fields = 128LL;
		                v39 = *(_OWORD *)&v38->stateBlock.hasValue;
		                *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v38->sortingCriteria;
		                v40 = *(_OWORD *)&v38->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.stateBlock.hasValue = v39;
		                v41 = *(_OWORD *)&v38->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v40;
		                v42 = *(_OWORD *)&v38->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v41;
		                v43 = *(_OWORD *)&v38->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v42;
		                v44 = *(_OWORD *)&v38->stateBlock.value.m_RasterState.m_OffsetFactor;
		                *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v43;
		                v45 = *(_OWORD *)&v38->stateBlock.value.m_StencilState.m_FailOperationFront;
		                v38 = (RendererListDesc *)((char *)v38 + 128);
		                *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v44;
		                forwardTransparent = (HGGraphicsFeatureSwitch *)&desc.overrideMaterial;
		                v46 = *(_OWORD *)&v38->sortingCriteria;
		                *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v45;
		                v47 = *(_OWORD *)&v38->stateBlock.hasValue;
		                *(_OWORD *)&desc.overrideMaterial = v46;
		                v48 = *(_OWORD *)&v38->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.overrideMaterialPassIndex = v47;
		                v49 = *(_OWORD *)&v38->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.sortingLayerMin = v48;
		                v50 = *(_OWORD *)&v38->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.drawableFeedbackPtr = v49;
		                v51 = *(_OWORD *)&v38->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v50;
		                *(_OWORD *)&desc._passName_k__BackingField.m_Id = v51;
		                if ( !renderGraph )
		                  goto LABEL_41;
		                InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
		                                  renderGraph,
		                                  &desc,
		                                  0LL);
		              }
		              else
		              {
		                InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		              }
		              input[0] = InvalidHandle;
		              transparentData->fields.transparentRenderList = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                                                                builder,
		                                                                input,
		                                                                0LL);
		              if ( v36 )
		              {
		                input[0] = (RendererListHandle)camera->fields.camera;
		                if ( !hgrp )
		                  goto LABEL_41;
		                vfxDecalPassNames = hgrp->fields.vfxDecalPassNames;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		                v88.handle = (ResourceHandle)1LL;
		                *(RenderQueueRange *)&v88.handle._type_k__BackingField = TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_All;
		                sub_18033B9D0(&v94, 0LL, 112LL);
		                LODWORD(v90.m_AllocationInfo) = v88.fallBackResource.m_Value;
		                v90.ptr = (void *)v88.handle;
		                v88 = (TextureHandle)*cullingResults;
		                TransparentRendererListDesc = HG::Rendering::Runtime::HGRendererListUtils::CreateTransparentRendererListDesc(
		                                                v95,
		                                                (CullingResults *)&v88,
		                                                *(Camera **)input,
		                                                vfxDecalPassNames,
		                                                screenCullingRatio,
		                                                screenCullingRatioDistance,
		                                                screenCullingLayerMask,
		                                                bakedLightingConfig,
		                                                (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v90,
		                                                (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&v94,
		                                                0LL,
		                                                0,
		                                                0LL);
		                static_fields = 128LL;
		                v55 = *(_OWORD *)&TransparentRendererListDesc->stateBlock.hasValue;
		                *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&TransparentRendererListDesc->sortingCriteria;
		                v56 = *(_OWORD *)&TransparentRendererListDesc->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.stateBlock.hasValue = v55;
		                v57 = *(_OWORD *)&TransparentRendererListDesc->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v56;
		                v58 = *(_OWORD *)&TransparentRendererListDesc->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v57;
		                v59 = *(_OWORD *)&TransparentRendererListDesc->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v58;
		                v60 = *(_OWORD *)&TransparentRendererListDesc->stateBlock.value.m_RasterState.m_OffsetFactor;
		                *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v59;
		                v61 = *(_OWORD *)&TransparentRendererListDesc->stateBlock.value.m_StencilState.m_FailOperationFront;
		                TransparentRendererListDesc = (RendererListDesc *)((char *)TransparentRendererListDesc + 128);
		                *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v60;
		                forwardTransparent = (HGGraphicsFeatureSwitch *)&desc.overrideMaterial;
		                v62 = *(_OWORD *)&TransparentRendererListDesc->sortingCriteria;
		                *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v61;
		                v63 = *(_OWORD *)&TransparentRendererListDesc->stateBlock.hasValue;
		                *(_OWORD *)&desc.overrideMaterial = v62;
		                v64 = *(_OWORD *)&TransparentRendererListDesc->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.overrideMaterialPassIndex = v63;
		                v65 = *(_OWORD *)&TransparentRendererListDesc->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.sortingLayerMin = v64;
		                v66 = *(_OWORD *)&TransparentRendererListDesc->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc.drawableFeedbackPtr = v65;
		                v67 = *(_OWORD *)&TransparentRendererListDesc->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		                *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v66;
		                *(_OWORD *)&desc._passName_k__BackingField.m_Id = v67;
		                if ( !renderGraph )
		                  goto LABEL_41;
		                v68 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
		              }
		              else
		              {
		                v68 = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
		              }
		              input[0] = v68;
		              transparentData->fields.vfxDecalRenderList = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
		                                                             builder,
		                                                             input,
		                                                             0LL);
		              if ( v87 )
		              {
		                cullingViewHandle = camera->fields.cullingViewHandle;
		                if ( !renderGraph )
		                  goto LABEL_41;
		                HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		                if ( !HGContext )
		                  goto LABEL_41;
		                sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                RendererList = UnityEngine::HyperGryph::HGDecalRender::CreateRendererList(
		                                 cullingViewHandle,
		                                 HGShaderLightMode__Enum_ForwardDecal,
		                                 HGContext->fields.renderContext.m_Ptr,
		                                 0LL);
		              }
		              else
		              {
		                RendererList = -1;
		              }
		              transparentData->fields.forwardDecalECSList = RendererList;
		              if ( v36 )
		              {
		                v72 = camera->fields.cullingViewHandle;
		                if ( !renderGraph )
		                  goto LABEL_41;
		                v73 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		                if ( !v73 )
		                  goto LABEL_41;
		                sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                LOWORD(globalKeywordsb) = 0;
		                v74 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                        v72,
		                        HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
		                        HGRenderFlags__Enum_Transparent,
		                        HGShaderLightMode__Enum_VFXDecal,
		                        globalKeywordsb,
		                        v73->fields.renderContext.m_Ptr,
		                        0,
		                        1,
		                        0xFFFFFFFF,
		                        0,
		                        0,
		                        0LL);
		              }
		              else
		              {
		                v74 = -1;
		              }
		              transparentData->fields.vfxDecalECSList = v74;
		              transparentData->fields.forwardTransparentECSList = forwardTransparentECSList;
		              forwardTransparent = (HGGraphicsFeatureSwitch *)camera->fields.camera;
		              if ( forwardTransparent )
		              {
		                cullingMask = UnityEngine::Camera::get_cullingMask((Camera *)forwardTransparent, 0LL);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		                v76.m_Mask = HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer((LayerMask)cullingMask, 0LL).m_Mask;
		                forwardTransparent = (HGGraphicsFeatureSwitch *)camera->fields.camera;
		                m_Mask = v76.m_Mask;
		                if ( forwardTransparent )
		                {
		                  InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)forwardTransparent, 0LL);
		                  if ( renderGraph )
		                  {
		                    v79 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		                    if ( v79 )
		                    {
		                      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                      v80 = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
		                              m_Mask,
		                              0,
		                              0,
		                              0x2002060u,
		                              0x8000,
		                              0x7FFF,
		                              InstanceID,
		                              v79->fields.renderContext.m_Ptr,
		                              0,
		                              3.4028235e38,
		                              0LL);
		                      transparentData->fields.forwardTransparentAfterUIECSList = -1;
		                      transparentData->fields.hgUIRendererList = v80;
		                      transparentData->fields.transparentVRS = transparentVRS;
		                      transparentData->fields.transparentVRRx = transparentVRRx;
		                      transparentData->fields.transparentVRRy = transparentVRRy;
		                      transparentData->fields.lowResRendering = lowResRendering;
		                      sub_18033B330(v95, basicTransformConstants, 1312LL);
		                      sub_18033B330(&transparentData->fields.basicTransformConstants, v95, 1312LL);
		                      sub_18033B330(v95, shaderVariablesGlobal, 3200LL);
		                      sub_18033B330(&transparentData->fields.shaderVariablesGlobal, v95, 3200LL);
		                      return;
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_41:
		    sub_1800D8260(forwardTransparent, static_fields);
		  }
		  forwardTransparent = (HGGraphicsFeatureSwitch *)IFix::WrappersManagerImpl::GetPatch(3148, 0LL);
		  if ( !forwardTransparent )
		    goto LABEL_41;
		  v90 = *cullingResults;
		  v81 = *(_OWORD *)&builder->m_RenderGraph;
		  *(_OWORD *)&v92.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		  *(_OWORD *)&v92.m_RenderGraph = v81;
		  v82 = *sceneDepthToSample;
		  v88 = *sceneDepthWithWater;
		  v83 = *sceneColorToSample;
		  *(TextureHandle *)&input[0].m_IsValid = v82;
		  *(TextureHandle *)&v91.m_RenderPass = v83;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1163(
		    (ILFixDynamicMethodWrapper_2 *)forwardTransparent,
		    (Object *)hgrp,
		    (Object *)renderGraph,
		    (TextureHandle *)&v91,
		    (TextureHandle *)input,
		    &v88,
		    (Object *)camera,
		    (Object *)waterRenderingPass,
		    &v92,
		    &v90,
		    bakedLightingConfig,
		    forwardTransparentECSList,
		    characterOutlineEnabled,
		    screenCullingRatio,
		    screenCullingRatioDistance,
		    screenCullingLayerMask,
		    (Object *)transparentData,
		    transparentVRS,
		    transparentVRRx,
		    transparentVRRy,
		    lowResRendering,
		    basicTransformConstants,
		    shaderVariablesGlobal,
		    0LL);
		}
		
		public static RendererListDesc PrepareForwardOpaqueRendererList(HGRenderPipeline hgrp, HGCamera camera, CullingResults cullingResults, PerObjectData backedLightingConfig, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask) => default; // 0x0000000189BAB6F8-0x0000000189BAB94C
		// RendererListDesc PrepareForwardOpaqueRendererList(HGRenderPipeline, HGCamera, CullingResults, PerObjectData, Single, Single, UInt32)
		RendererListDesc *HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardOpaqueRendererList(
		        RendererListDesc *__return_ptr retstr,
		        HGRenderPipeline *hgrp,
		        HGCamera *camera,
		        CullingResults *cullingResults,
		        PerObjectData__Enum backedLightingConfig,
		        float screenCullingRatio,
		        float screenCullingRatioDistance,
		        uint32_t screenCullingLayerMask,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v14; // rcx
		  __int64 v15; // xmm1_8
		  LitShaderMode__Enum litShaderMode; // eax
		  ShaderTagId__Array *forwardOnlyPassNames; // rsi
		  PerObjectData__Enum PerObjectDataConfig; // ebx
		  Camera *v19; // r8
		  RendererListDesc *v20; // rax
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm0
		  Material **p_overrideMaterial; // rax
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  RendererListDesc *result; // rax
		  Nullable_1_UnityEngine_Rendering_RenderQueueRange_ v35; // [rsp+78h] [rbp-90h] BYREF
		  FrameSettings v36; // [rsp+88h] [rbp-80h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v37; // [rsp+A8h] [rbp-60h] BYREF
		  RendererListDesc v38; // [rsp+118h] [rbp+10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3124, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3124, 0LL);
		    if ( Patch )
		    {
		      v36.bitDatas = (BitArray128)*cullingResults;
		      v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1152(
		              &v38,
		              Patch,
		              (Object *)hgrp,
		              (Object *)camera,
		              (CullingResults *)&v36,
		              backedLightingConfig,
		              screenCullingRatio,
		              screenCullingRatioDistance,
		              screenCullingLayerMask,
		              0LL);
		      goto LABEL_11;
		    }
		LABEL_9:
		    sub_1800D8260(v14, Patch);
		  }
		  if ( !camera )
		    goto LABEL_9;
		  v15 = *(_QWORD *)&camera->fields._frameSettings_k__BackingField.materialQuality;
		  v36.bitDatas = camera->fields._frameSettings_k__BackingField.bitDatas;
		  *(_QWORD *)&v36.materialQuality = v15;
		  litShaderMode = HG::Rendering::Runtime::FrameSettings::get_litShaderMode(&v36, 0LL);
		  if ( !hgrp )
		    goto LABEL_9;
		  if ( litShaderMode )
		    forwardOnlyPassNames = hgrp->fields.forwardOnlyPassNames;
		  else
		    forwardOnlyPassNames = hgrp->fields.forwardAndForwardOnlyPassNames;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  *(_QWORD *)&v35.hasValue = 0LL;
		  PerObjectDataConfig = HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
		  sub_18033B9D0(&v37, 0LL, 112LL);
		  v19 = camera->fields.camera;
		  v36.bitDatas = (BitArray128)*cullingResults;
		  v35.value.m_UpperBound = 0;
		  v20 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
		          &v38,
		          (CullingResults *)&v36,
		          v19,
		          forwardOnlyPassNames,
		          screenCullingRatio,
		          screenCullingRatioDistance,
		          screenCullingLayerMask,
		          (PerObjectData__Enum)(backedLightingConfig | PerObjectDataConfig),
		          &v35,
		          &v37,
		          0LL,
		          0,
		          0LL);
		LABEL_11:
		  v21 = *(_OWORD *)&v20->stateBlock.hasValue;
		  *(_OWORD *)&retstr->sortingCriteria = *(_OWORD *)&v20->sortingCriteria;
		  v22 = *(_OWORD *)&v20->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.hasValue = v21;
		  v23 = *(_OWORD *)&v20->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v22;
		  v24 = *(_OWORD *)&v20->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v23;
		  v25 = *(_OWORD *)&v20->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v24;
		  v26 = *(_OWORD *)&v20->stateBlock.value.m_RasterState.m_OffsetFactor;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v25;
		  *(_OWORD *)&retstr->stateBlock.value.m_RasterState.m_OffsetFactor = v26;
		  v27 = *(_OWORD *)&v20->stateBlock.value.m_StencilState.m_FailOperationFront;
		  p_overrideMaterial = &v20->overrideMaterial;
		  *(_OWORD *)&retstr->stateBlock.value.m_StencilState.m_FailOperationFront = v27;
		  v29 = *((_OWORD *)p_overrideMaterial + 1);
		  *(_OWORD *)&retstr->overrideMaterial = *(_OWORD *)p_overrideMaterial;
		  v30 = *((_OWORD *)p_overrideMaterial + 2);
		  *(_OWORD *)&retstr->overrideMaterialPassIndex = v29;
		  v31 = *((_OWORD *)p_overrideMaterial + 3);
		  *(_OWORD *)&retstr->sortingLayerMin = v30;
		  v32 = *((_OWORD *)p_overrideMaterial + 4);
		  *(_OWORD *)&retstr->drawableFeedbackPtr = v31;
		  v33 = *((_OWORD *)p_overrideMaterial + 5);
		  result = retstr;
		  *(_OWORD *)&retstr->_cullingResult_k__BackingField.m_AllocationInfo = v32;
		  *(_OWORD *)&retstr->_passName_k__BackingField.m_Id = v33;
		  return result;
		}
		
		public static RendererListDesc PrepareForwardOpaqueCharacterOutlineRendererList(HGRenderPipeline hgrp, HGCamera camera, ref CullingResults cullingResults, PerObjectData bakedLightingConfig, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask) => default; // 0x0000000189BAB4E4-0x0000000189BAB6F8
		// RendererListDesc PrepareForwardOpaqueCharacterOutlineRendererList(HGRenderPipeline, HGCamera, CullingResults ByRef, PerObjectData, Single, Single, UInt32)
		RendererListDesc *HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardOpaqueCharacterOutlineRendererList(
		        RendererListDesc *__return_ptr retstr,
		        HGRenderPipeline *hgrp,
		        HGCamera *camera,
		        CullingResults *cullingResults,
		        PerObjectData__Enum bakedLightingConfig,
		        float screenCullingRatio,
		        float screenCullingRatioDistance,
		        uint32_t screenCullingLayerMask,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v14; // rcx
		  ShaderTagId__Array *characterOutlinePassNames; // r15
		  PerObjectData__Enum PerObjectDataConfig; // ebx
		  Camera *v17; // r8
		  RendererListDesc *v18; // rax
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm0
		  Material **p_overrideMaterial; // rax
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  RendererListDesc *result; // rax
		  Nullable_1_UnityEngine_Rendering_RenderQueueRange_ v33; // [rsp+78h] [rbp-90h] BYREF
		  CullingResults v34; // [rsp+88h] [rbp-80h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v35; // [rsp+98h] [rbp-70h] BYREF
		  RendererListDesc v36; // [rsp+108h] [rbp+0h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3126, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3126, 0LL);
		    if ( Patch )
		    {
		      v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1153(
		              &v36,
		              Patch,
		              (Object *)hgrp,
		              (Object *)camera,
		              cullingResults,
		              bakedLightingConfig,
		              screenCullingRatio,
		              screenCullingRatioDistance,
		              screenCullingLayerMask,
		              0LL);
		      goto LABEL_8;
		    }
		LABEL_6:
		    sub_1800D8260(v14, Patch);
		  }
		  if ( !hgrp )
		    goto LABEL_6;
		  characterOutlinePassNames = hgrp->fields.characterOutlinePassNames;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  PerObjectDataConfig = HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
		  if ( !camera )
		    goto LABEL_6;
		  *(_QWORD *)&v33.hasValue = 0LL;
		  sub_18033B9D0(&v35, 0LL, 112LL);
		  v17 = camera->fields.camera;
		  v34 = *cullingResults;
		  v33.value.m_UpperBound = 0;
		  v18 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
		          &v36,
		          &v34,
		          v17,
		          characterOutlinePassNames,
		          screenCullingRatio,
		          screenCullingRatioDistance,
		          screenCullingLayerMask,
		          (PerObjectData__Enum)(bakedLightingConfig | PerObjectDataConfig),
		          &v33,
		          &v35,
		          0LL,
		          0,
		          0LL);
		LABEL_8:
		  v19 = *(_OWORD *)&v18->stateBlock.hasValue;
		  *(_OWORD *)&retstr->sortingCriteria = *(_OWORD *)&v18->sortingCriteria;
		  v20 = *(_OWORD *)&v18->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.hasValue = v19;
		  v21 = *(_OWORD *)&v18->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v20;
		  v22 = *(_OWORD *)&v18->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v21;
		  v23 = *(_OWORD *)&v18->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v22;
		  v24 = *(_OWORD *)&v18->stateBlock.value.m_RasterState.m_OffsetFactor;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v23;
		  *(_OWORD *)&retstr->stateBlock.value.m_RasterState.m_OffsetFactor = v24;
		  v25 = *(_OWORD *)&v18->stateBlock.value.m_StencilState.m_FailOperationFront;
		  p_overrideMaterial = &v18->overrideMaterial;
		  *(_OWORD *)&retstr->stateBlock.value.m_StencilState.m_FailOperationFront = v25;
		  v27 = *((_OWORD *)p_overrideMaterial + 1);
		  *(_OWORD *)&retstr->overrideMaterial = *(_OWORD *)p_overrideMaterial;
		  v28 = *((_OWORD *)p_overrideMaterial + 2);
		  *(_OWORD *)&retstr->overrideMaterialPassIndex = v27;
		  v29 = *((_OWORD *)p_overrideMaterial + 3);
		  *(_OWORD *)&retstr->sortingLayerMin = v28;
		  v30 = *((_OWORD *)p_overrideMaterial + 4);
		  *(_OWORD *)&retstr->drawableFeedbackPtr = v29;
		  v31 = *((_OWORD *)p_overrideMaterial + 5);
		  result = retstr;
		  *(_OWORD *)&retstr->_cullingResult_k__BackingField.m_AllocationInfo = v30;
		  *(_OWORD *)&retstr->_passName_k__BackingField.m_Id = v31;
		  return result;
		}
		
		[IDTag(0)]
		private static RendererListDesc PrepareForwardTransparentRendererList(CullingResults cullResults, HGCamera hgCamera, ShaderTagId[] passNames, bool preRefraction, PerObjectData backedLightingConfig, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask, PerObjectData additionalConfig = PerObjectData.None /* Metadata: 0x02303C79 */) => default; // 0x0000000189BABB58-0x0000000189BABE94
		// RendererListDesc PrepareForwardTransparentRendererList(CullingResults, HGCamera, ShaderTagId[], Boolean, PerObjectData, Single, Single, UInt32, PerObjectData)
		RendererListDesc *HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardTransparentRendererList(
		        RendererListDesc *__return_ptr retstr,
		        CullingResults *cullResults,
		        HGCamera *hgCamera,
		        ShaderTagId__Array *passNames,
		        bool preRefraction,
		        PerObjectData__Enum backedLightingConfig,
		        float screenCullingRatio,
		        float screenCullingRatioDistance,
		        uint32_t screenCullingLayerMask,
		        PerObjectData__Enum additionalConfig,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // xmm1_8
		  void *k_RenderQueue_Transparent; // rbx
		  __int64 v19; // xmm1_8
		  __int64 v20; // xmm1_8
		  Camera *camera; // r8
		  RendererListDesc *v22; // rax
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm0
		  Material **p_overrideMaterial; // rax
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  RendererListDesc *result; // rax
		  FrameSettings v37; // [rsp+70h] [rbp-98h] BYREF
		  __int64 v38; // [rsp+88h] [rbp-80h]
		  CullingResults v39; // [rsp+98h] [rbp-70h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v40; // [rsp+A8h] [rbp-60h] BYREF
		  RendererListDesc v41; // [rsp+118h] [rbp+10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3151, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3151, 0LL);
		    if ( Patch )
		    {
		      *(CullingResults *)&v37.bitDatas.data2 = *cullResults;
		      v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1161(
		              &v41,
		              Patch,
		              (CullingResults *)&v37.bitDatas.data2,
		              (Object *)hgCamera,
		              (Object *)passNames,
		              preRefraction,
		              backedLightingConfig,
		              screenCullingRatio,
		              screenCullingRatioDistance,
		              screenCullingLayerMask,
		              additionalConfig,
		              0LL);
		      goto LABEL_16;
		    }
		    goto LABEL_14;
		  }
		  if ( !preRefraction )
		  {
		    if ( hgCamera )
		    {
		      v17 = *(_QWORD *)&hgCamera->fields._frameSettings_k__BackingField.materialQuality;
		      *(BitArray128 *)&v37.bitDatas.data2 = hgCamera->fields._frameSettings_k__BackingField.bitDatas;
		      v38 = v17;
		      if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		             (FrameSettings *)&v37.bitDatas.data2,
		             FrameSettingsField__Enum_LowResTransparent,
		             0LL) )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		        k_RenderQueue_Transparent = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_Transparent;
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		        k_RenderQueue_Transparent = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_TransparentWithLowRes;
		      }
		      goto LABEL_8;
		    }
		LABEL_14:
		    sub_1800D8260(v16, Patch);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		  k_RenderQueue_Transparent = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_PreRefraction;
		  if ( !hgCamera )
		    goto LABEL_14;
		LABEL_8:
		  v19 = *(_QWORD *)&hgCamera->fields._frameSettings_k__BackingField.materialQuality;
		  *(BitArray128 *)&v37.bitDatas.data2 = hgCamera->fields._frameSettings_k__BackingField.bitDatas;
		  v38 = v19;
		  if ( !HG::Rendering::Runtime::FrameSettings::IsEnabled(
		          (FrameSettings *)&v37.bitDatas.data2,
		          FrameSettingsField__Enum_Refraction,
		          0LL) )
		  {
		    v20 = *(_QWORD *)&hgCamera->fields._frameSettings_k__BackingField.materialQuality;
		    *(BitArray128 *)&v37.bitDatas.data2 = hgCamera->fields._frameSettings_k__BackingField.bitDatas;
		    v38 = v20;
		    if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		           (FrameSettings *)&v37.bitDatas.data2,
		           FrameSettingsField__Enum_LowResTransparent,
		           0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		      k_RenderQueue_Transparent = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AllTransparent;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		      k_RenderQueue_Transparent = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AllTransparentWithLowRes;
		    }
		  }
		  LODWORD(v39.ptr) = 1;
		  *(void **)((char *)&v39.ptr + 4) = k_RenderQueue_Transparent;
		  sub_18033B9D0(&v40, 0LL, 112LL);
		  camera = hgCamera->fields.camera;
		  v37.materialQuality = (int32_t)v39.m_AllocationInfo;
		  v37.bitDatas.data2 = (uint64_t)v39.ptr;
		  v39 = *cullResults;
		  v22 = HG::Rendering::Runtime::HGRendererListUtils::CreateTransparentRendererListDesc(
		          &v41,
		          &v39,
		          camera,
		          passNames,
		          screenCullingRatio,
		          screenCullingRatioDistance,
		          screenCullingLayerMask,
		          (PerObjectData__Enum)(additionalConfig | backedLightingConfig),
		          (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v37.bitDatas.data2,
		          &v40,
		          0LL,
		          0,
		          0LL);
		LABEL_16:
		  v23 = *(_OWORD *)&v22->stateBlock.hasValue;
		  *(_OWORD *)&retstr->sortingCriteria = *(_OWORD *)&v22->sortingCriteria;
		  v24 = *(_OWORD *)&v22->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.hasValue = v23;
		  v25 = *(_OWORD *)&v22->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v24;
		  v26 = *(_OWORD *)&v22->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v25;
		  v27 = *(_OWORD *)&v22->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v26;
		  v28 = *(_OWORD *)&v22->stateBlock.value.m_RasterState.m_OffsetFactor;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v27;
		  *(_OWORD *)&retstr->stateBlock.value.m_RasterState.m_OffsetFactor = v28;
		  v29 = *(_OWORD *)&v22->stateBlock.value.m_StencilState.m_FailOperationFront;
		  p_overrideMaterial = &v22->overrideMaterial;
		  *(_OWORD *)&retstr->stateBlock.value.m_StencilState.m_FailOperationFront = v29;
		  v31 = *((_OWORD *)p_overrideMaterial + 1);
		  *(_OWORD *)&retstr->overrideMaterial = *(_OWORD *)p_overrideMaterial;
		  v32 = *((_OWORD *)p_overrideMaterial + 2);
		  *(_OWORD *)&retstr->overrideMaterialPassIndex = v31;
		  v33 = *((_OWORD *)p_overrideMaterial + 3);
		  *(_OWORD *)&retstr->sortingLayerMin = v32;
		  v34 = *((_OWORD *)p_overrideMaterial + 4);
		  *(_OWORD *)&retstr->drawableFeedbackPtr = v33;
		  v35 = *((_OWORD *)p_overrideMaterial + 5);
		  result = retstr;
		  *(_OWORD *)&retstr->_cullingResult_k__BackingField.m_AllocationInfo = v34;
		  *(_OWORD *)&retstr->_passName_k__BackingField.m_Id = v35;
		  return result;
		}
		
		[IDTag(1)]
		private static RendererListDesc PrepareForwardTransparentRendererList(HGRenderPipeline hgrp, HGCamera camera, bool preRefraction, bool enableOutline, CullingResults cullingResults, PerObjectData backedLightingConfig, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask) => default; // 0x0000000189BAB94C-0x0000000189BABB58
		// RendererListDesc PrepareForwardTransparentRendererList(HGRenderPipeline, HGCamera, Boolean, Boolean, CullingResults, PerObjectData, Single, Single, UInt32)
		RendererListDesc *HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardTransparentRendererList(
		        RendererListDesc *__return_ptr retstr,
		        HGRenderPipeline *hgrp,
		        HGCamera *camera,
		        bool preRefraction,
		        bool enableOutline,
		        CullingResults *cullingResults,
		        PerObjectData__Enum backedLightingConfig,
		        float screenCullingRatio,
		        float screenCullingRatioDistance,
		        uint32_t screenCullingLayerMask,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v16; // rcx
		  ShaderTagId__Array *allTransparentWithOutlinePassNames; // rbx
		  PerObjectData__Enum PerObjectMotionVectorConfig; // eax
		  RendererListDesc *v19; // rax
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  __int128 v26; // xmm0
		  Material **p_overrideMaterial; // rax
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  RendererListDesc *result; // rax
		  CullingResults v34; // [rsp+60h] [rbp-F8h] BYREF
		  RendererListDesc v35; // [rsp+70h] [rbp-E8h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3150, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3150, 0LL);
		    if ( Patch )
		    {
		      v34 = *cullingResults;
		      v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1162(
		              &v35,
		              Patch,
		              (Object *)hgrp,
		              (Object *)camera,
		              preRefraction,
		              enableOutline,
		              &v34,
		              backedLightingConfig,
		              screenCullingRatio,
		              screenCullingRatioDistance,
		              screenCullingLayerMask,
		              0LL);
		      goto LABEL_10;
		    }
		LABEL_8:
		    sub_1800D8260(v16, Patch);
		  }
		  if ( !hgrp )
		    goto LABEL_8;
		  if ( enableOutline )
		    allTransparentWithOutlinePassNames = hgrp->fields.allTransparentWithOutlinePassNames;
		  else
		    allTransparentWithOutlinePassNames = hgrp->fields.allTransparentPassNames;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  PerObjectMotionVectorConfig = HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectMotionVectorConfig(camera, 0LL);
		  v34 = *cullingResults;
		  v19 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardTransparentRendererList(
		          &v35,
		          &v34,
		          camera,
		          allTransparentWithOutlinePassNames,
		          preRefraction,
		          backedLightingConfig,
		          screenCullingRatio,
		          screenCullingRatioDistance,
		          screenCullingLayerMask,
		          (PerObjectData__Enum)(PerObjectMotionVectorConfig | 0x8000),
		          0LL);
		LABEL_10:
		  v20 = *(_OWORD *)&v19->stateBlock.hasValue;
		  *(_OWORD *)&retstr->sortingCriteria = *(_OWORD *)&v19->sortingCriteria;
		  v21 = *(_OWORD *)&v19->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.hasValue = v20;
		  v22 = *(_OWORD *)&v19->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v21;
		  v23 = *(_OWORD *)&v19->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v22;
		  v24 = *(_OWORD *)&v19->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v23;
		  v25 = *(_OWORD *)&v19->stateBlock.value.m_RasterState.m_OffsetFactor;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v24;
		  *(_OWORD *)&retstr->stateBlock.value.m_RasterState.m_OffsetFactor = v25;
		  v26 = *(_OWORD *)&v19->stateBlock.value.m_StencilState.m_FailOperationFront;
		  p_overrideMaterial = &v19->overrideMaterial;
		  *(_OWORD *)&retstr->stateBlock.value.m_StencilState.m_FailOperationFront = v26;
		  v28 = *((_OWORD *)p_overrideMaterial + 1);
		  *(_OWORD *)&retstr->overrideMaterial = *(_OWORD *)p_overrideMaterial;
		  v29 = *((_OWORD *)p_overrideMaterial + 2);
		  *(_OWORD *)&retstr->overrideMaterialPassIndex = v28;
		  v30 = *((_OWORD *)p_overrideMaterial + 3);
		  *(_OWORD *)&retstr->sortingLayerMin = v29;
		  v31 = *((_OWORD *)p_overrideMaterial + 4);
		  *(_OWORD *)&retstr->drawableFeedbackPtr = v30;
		  v32 = *((_OWORD *)p_overrideMaterial + 5);
		  result = retstr;
		  *(_OWORD *)&retstr->_cullingResult_k__BackingField.m_AllocationInfo = v31;
		  *(_OWORD *)&retstr->_passName_k__BackingField.m_Id = v32;
		  return result;
		}
		
		public static RendererListDesc PrepareAfterDOFTranparentRendererList(HGRenderPipeline hgrp, HGCamera hgCamera, bool enableOutline, CullingResults cullingResults, PerObjectData backedLightingConfig, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask) => default; // 0x0000000189BAB274-0x0000000189BAB4E4
		// RendererListDesc PrepareAfterDOFTranparentRendererList(HGRenderPipeline, HGCamera, Boolean, CullingResults, PerObjectData, Single, Single, UInt32)
		RendererListDesc *HG::Rendering::Runtime::ForwardPassUtils::PrepareAfterDOFTranparentRendererList(
		        RendererListDesc *__return_ptr retstr,
		        HGRenderPipeline *hgrp,
		        HGCamera *hgCamera,
		        bool enableOutline,
		        CullingResults *cullingResults,
		        PerObjectData__Enum backedLightingConfig,
		        float screenCullingRatio,
		        float screenCullingRatioDistance,
		        uint32_t screenCullingLayerMask,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v15; // rcx
		  ShaderTagId__Array *v16; // rsi
		  PerObjectData__Enum PerObjectMotionVectorConfig; // r15d
		  Camera *camera; // rbx
		  RendererListDesc *v19; // rax
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  __int128 v26; // xmm0
		  Material **p_overrideMaterial; // rax
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  RendererListDesc *result; // rax
		  CullingResults v34; // [rsp+78h] [rbp-90h] BYREF
		  CullingResults v35; // [rsp+88h] [rbp-80h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v36; // [rsp+98h] [rbp-70h] BYREF
		  RendererListDesc v37; // [rsp+108h] [rbp+0h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3152, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3152, 0LL);
		    if ( Patch )
		    {
		      v35 = *cullingResults;
		      v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1164(
		              &v37,
		              Patch,
		              (Object *)hgrp,
		              (Object *)hgCamera,
		              enableOutline,
		              &v35,
		              backedLightingConfig,
		              screenCullingRatio,
		              screenCullingRatioDistance,
		              screenCullingLayerMask,
		              0LL);
		      goto LABEL_11;
		    }
		LABEL_9:
		    sub_1800D8260(v15, Patch);
		  }
		  if ( !hgrp )
		    goto LABEL_9;
		  v16 = enableOutline
		      ? hgrp->fields.allTransparentPassWithOutlineAfterDOFPassNames
		      : hgrp->fields.allTransparentPassAfterDOFNames;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		  PerObjectMotionVectorConfig = HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectMotionVectorConfig(hgCamera, 0LL);
		  if ( !hgCamera )
		    goto LABEL_9;
		  camera = hgCamera->fields.camera;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		  v34.ptr = (void *)1;
		  *(void **)((char *)&v34.ptr + 4) = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AfterPostProcessTransparent;
		  sub_18033B9D0(&v36, 0LL, 112LL);
		  LODWORD(v35.m_AllocationInfo) = v34.m_AllocationInfo;
		  v35.ptr = v34.ptr;
		  v34 = *cullingResults;
		  v19 = HG::Rendering::Runtime::HGRendererListUtils::CreateTransparentRendererListDesc(
		          &v37,
		          &v34,
		          camera,
		          v16,
		          screenCullingRatio,
		          screenCullingRatioDistance,
		          screenCullingLayerMask,
		          (PerObjectData__Enum)(backedLightingConfig | PerObjectMotionVectorConfig),
		          (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v35,
		          &v36,
		          0LL,
		          0,
		          0LL);
		LABEL_11:
		  v20 = *(_OWORD *)&v19->stateBlock.hasValue;
		  *(_OWORD *)&retstr->sortingCriteria = *(_OWORD *)&v19->sortingCriteria;
		  v21 = *(_OWORD *)&v19->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.hasValue = v20;
		  v22 = *(_OWORD *)&v19->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v21;
		  v23 = *(_OWORD *)&v19->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v22;
		  v24 = *(_OWORD *)&v19->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v23;
		  v25 = *(_OWORD *)&v19->stateBlock.value.m_RasterState.m_OffsetFactor;
		  *(_OWORD *)&retstr->stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v24;
		  *(_OWORD *)&retstr->stateBlock.value.m_RasterState.m_OffsetFactor = v25;
		  v26 = *(_OWORD *)&v19->stateBlock.value.m_StencilState.m_FailOperationFront;
		  p_overrideMaterial = &v19->overrideMaterial;
		  *(_OWORD *)&retstr->stateBlock.value.m_StencilState.m_FailOperationFront = v26;
		  v28 = *((_OWORD *)p_overrideMaterial + 1);
		  *(_OWORD *)&retstr->overrideMaterial = *(_OWORD *)p_overrideMaterial;
		  v29 = *((_OWORD *)p_overrideMaterial + 2);
		  *(_OWORD *)&retstr->overrideMaterialPassIndex = v28;
		  v30 = *((_OWORD *)p_overrideMaterial + 3);
		  *(_OWORD *)&retstr->sortingLayerMin = v29;
		  v31 = *((_OWORD *)p_overrideMaterial + 4);
		  *(_OWORD *)&retstr->drawableFeedbackPtr = v30;
		  v32 = *((_OWORD *)p_overrideMaterial + 5);
		  result = retstr;
		  *(_OWORD *)&retstr->_cullingResult_k__BackingField.m_AllocationInfo = v31;
		  *(_OWORD *)&retstr->_passName_k__BackingField.m_Id = v32;
		  return result;
		}
		
		internal static void RenderForwardOpaque(HGRenderGraphContext context, ForwardOpaquePassData data) {} // 0x0000000189BACBB4-0x0000000189BACFCC
		// Void RenderForwardOpaque(HGRenderGraphContext, ForwardPassUtils+ForwardOpaquePassData)
		void HG::Rendering::Runtime::ForwardPassUtils::RenderForwardOpaque(
		        HGRenderGraphContext *context,
		        ForwardPassUtils_ForwardOpaquePassData *data,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  CommandBuffer *cmd; // rcx
		  BitArray128 *camera; // rbx
		  uint64_t data1; // xmm7_8
		  BitArray128 v9; // xmm6
		  uint64_t v10; // xmm1_8
		  uint32_t characterOpaqueECSRendererList; // ebx
		  CommandBuffer *v12; // r14
		  bool enabled; // al
		  RendererList *v14; // rax
		  void *m_Ptr; // rbx
		  CommandBuffer *v16; // r14
		  BitArray128 v17; // xmm8
		  bool v18; // al
		  uint32_t forwardOpaqueECSRendererList; // ebx
		  CommandBuffer *v20; // r14
		  bool v21; // al
		  uint32_t forwardOpaqueEqualECSRendererList; // ebx
		  CommandBuffer *v23; // r14
		  bool v24; // al
		  uint32_t characterOutlineOpaqueECSRendererList; // ebx
		  CommandBuffer *v26; // r14
		  bool v27; // al
		  uint32_t characterOutlineOpaqueEqualECSRendererList; // ebx
		  CommandBuffer *v29; // r14
		  bool v30; // al
		  RendererList *v31; // rax
		  void *v32; // rbx
		  CommandBuffer *v33; // r14
		  BitArray128 v34; // xmm8
		  bool v35; // al
		  HGCamera *v36; // rax
		  HGSkyRenderer *s_skyRenderer; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  FrameSettings v39; // [rsp+48h] [rbp-19h] BYREF
		  FrameSettings v40[3]; // [rsp+68h] [rbp+7h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3153, 0LL) )
		  {
		    if ( data )
		    {
		      camera = (BitArray128 *)data->fields.camera;
		      if ( camera )
		      {
		        data1 = camera[106].data1;
		        v9 = camera[105];
		        if ( context )
		        {
		          cmd = context->fields.cmd;
		          if ( cmd )
		          {
		            UnityEngine::Rendering::CommandBuffer::SetProfilingHGPassImpl(cmd, 4, 0LL);
		            v10 = camera[106].data1;
		            v39.bitDatas = camera[105];
		            *(_QWORD *)&v39.materialQuality = v10;
		            if ( !HG::Rendering::Runtime::FrameSettings::IsEnabled(&v39, FrameSettingsField__Enum_OpaqueObjects, 0LL) )
		              return;
		            characterOpaqueECSRendererList = data->fields.characterOpaqueECSRendererList;
		            v12 = context->fields.cmd;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		            cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardCharacter;
		            if ( cmd )
		            {
		              enabled = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                          (HGGraphicsFeatureSwitch *)cmd,
		                          0LL);
		              v39.bitDatas = v9;
		              *(_QWORD *)&v39.materialQuality = data1;
		              HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(
		                &v39,
		                characterOpaqueECSRendererList,
		                1,
		                v12,
		                enabled,
		                0LL);
		              v14 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(
		                      (RendererList *)&v39,
		                      data->fields.opaqueRenderList,
		                      0LL);
		              m_Ptr = context->fields.renderContext.m_Ptr;
		              v16 = context->fields.cmd;
		              v17 = (BitArray128)*v14;
		              cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardOpaque;
		              if ( cmd )
		              {
		                v18 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled((HGGraphicsFeatureSwitch *)cmd, 0LL);
		                v39.bitDatas = v17;
		                v40[0].bitDatas = v9;
		                *(_QWORD *)&v40[0].materialQuality = data1;
		                HG::Rendering::Runtime::HGRendererListUtils::RenderForwardRendererList(
		                  v40,
		                  (RendererList *)&v39,
		                  1,
		                  (ScriptableRenderContext)m_Ptr,
		                  v16,
		                  v18,
		                  0LL);
		                forwardOpaqueECSRendererList = data->fields.forwardOpaqueECSRendererList;
		                v20 = context->fields.cmd;
		                cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardOpaque;
		                if ( cmd )
		                {
		                  v21 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                          (HGGraphicsFeatureSwitch *)cmd,
		                          0LL);
		                  v40[0].bitDatas = v9;
		                  *(_QWORD *)&v40[0].materialQuality = data1;
		                  HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(
		                    v40,
		                    forwardOpaqueECSRendererList,
		                    1,
		                    v20,
		                    v21,
		                    0LL);
		                  forwardOpaqueEqualECSRendererList = data->fields.forwardOpaqueEqualECSRendererList;
		                  v23 = context->fields.cmd;
		                  cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardOpaqueEqual;
		                  if ( cmd )
		                  {
		                    v24 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                            (HGGraphicsFeatureSwitch *)cmd,
		                            0LL);
		                    v40[0].bitDatas = v9;
		                    *(_QWORD *)&v40[0].materialQuality = data1;
		                    HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(
		                      v40,
		                      forwardOpaqueEqualECSRendererList,
		                      1,
		                      v23,
		                      v24,
		                      0LL);
		                    characterOutlineOpaqueECSRendererList = data->fields.characterOutlineOpaqueECSRendererList;
		                    v26 = context->fields.cmd;
		                    cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->characterOutlineOpaque;
		                    if ( cmd )
		                    {
		                      v27 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                              (HGGraphicsFeatureSwitch *)cmd,
		                              0LL);
		                      v40[0].bitDatas = v9;
		                      *(_QWORD *)&v40[0].materialQuality = data1;
		                      HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(
		                        v40,
		                        characterOutlineOpaqueECSRendererList,
		                        1,
		                        v26,
		                        v27,
		                        0LL);
		                      characterOutlineOpaqueEqualECSRendererList = data->fields.characterOutlineOpaqueEqualECSRendererList;
		                      v29 = context->fields.cmd;
		                      cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->characterOutlineOpaqueEqual;
		                      if ( cmd )
		                      {
		                        v30 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                                (HGGraphicsFeatureSwitch *)cmd,
		                                0LL);
		                        v40[0].bitDatas = v9;
		                        *(_QWORD *)&v40[0].materialQuality = data1;
		                        HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(
		                          v40,
		                          characterOutlineOpaqueEqualECSRendererList,
		                          1,
		                          v29,
		                          v30,
		                          0LL);
		                        if ( HG::Rendering::RenderGraphModule::RendererListHandle::IsValid(
		                               &data->fields.characterOutlineOpaqueRenderList,
		                               0LL) )
		                        {
		                          v31 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(
		                                  (RendererList *)&v39,
		                                  data->fields.characterOutlineOpaqueRenderList,
		                                  0LL);
		                          v32 = context->fields.renderContext.m_Ptr;
		                          v33 = context->fields.cmd;
		                          v34 = (BitArray128)*v31;
		                          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		                          cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->characterOutlineOpaqueEqual;
		                          if ( !cmd )
		                            goto LABEL_24;
		                          v35 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled(
		                                  (HGGraphicsFeatureSwitch *)cmd,
		                                  0LL);
		                          v39.bitDatas = v34;
		                          v40[0].bitDatas = v9;
		                          *(_QWORD *)&v40[0].materialQuality = data1;
		                          HG::Rendering::Runtime::HGRendererListUtils::RenderForwardRendererList(
		                            v40,
		                            (RendererList *)&v39,
		                            1,
		                            (ScriptableRenderContext)v32,
		                            v33,
		                            v35,
		                            0LL);
		                        }
		                        v36 = data->fields.camera;
		                        if ( v36 )
		                        {
		                          cmd = (CommandBuffer *)v36->fields.camera;
		                          if ( cmd )
		                          {
		                            if ( UnityEngine::Camera::get_clearFlags((Camera *)cmd, 0LL) == CameraClearFlags__Enum_Skybox )
		                            {
		                              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		                              s_skyRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_skyRenderer(0LL);
		                              if ( !s_skyRenderer )
		                                goto LABEL_24;
		                              HG::Rendering::Runtime::HGSkyRenderer::Render(
		                                s_skyRenderer,
		                                context->fields.cmd,
		                                data->fields.camera,
		                                context->fields.renderContext,
		                                0,
		                                0LL);
		                            }
		                            cmd = context->fields.cmd;
		                            if ( cmd )
		                            {
		                              UnityEngine::Rendering::CommandBuffer::SetProfilingHGPassImpl(cmd, 0, 0LL);
		                              return;
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_24:
		    sub_1800D8260(cmd, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3153, 0LL);
		  if ( !Patch )
		    goto LABEL_24;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)context,
		    (Object *)data,
		    0LL);
		}
		
		internal static void RenderForwardTransparent(HGRenderGraphContext context, ForwardTransparentPassData data) {} // 0x0000000189BACFCC-0x0000000189BADC18
		// Void RenderForwardTransparent(HGRenderGraphContext, ForwardPassUtils+ForwardTransparentPassData)
		void HG::Rendering::Runtime::ForwardPassUtils::RenderForwardTransparent(
		        HGRenderGraphContext *context,
		        ForwardPassUtils_ForwardTransparentPassData *data,
		        MethodInfo *method)
		{
		  HGShaderIDs__StaticFields *static_fields; // rdx
		  void *cmd; // rcx
		  HGCamera *camera; // r14
		  BitArray128 bitDatas; // xmm0
		  Material *BlitMaterial; // r15
		  CommandBuffer *v10; // rbx
		  __m128i si128; // xmm0
		  __int64 BlitScaleBias; // rdx
		  CommandBuffer *v13; // rbx
		  TextureHandle sceneColorToSample; // xmm6
		  int32_t BlitTexture; // r12d
		  RenderTargetIdentifier *v16; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int128 v19; // xmm1
		  CommandBuffer *v20; // rbx
		  CommandBuffer *v21; // rbx
		  TextureHandle v22; // xmm6
		  int32_t SceneColorTexture; // r15d
		  RenderTargetIdentifier *v24; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  __int128 v27; // xmm1
		  int32_t v28; // ebx
		  TextureHandle__Array *gbuffer; // r15
		  TextureHandle *v30; // rax
		  CommandBuffer *v31; // r15
		  __int64 v32; // r9
		  int32_t v33; // r12d
		  RenderTargetIdentifier *v34; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  __int128 v37; // xmm1
		  CommandBuffer *v38; // rbx
		  TextureHandle sceneDepthToSample; // xmm6
		  int32_t CameraDepthTexture; // r15d
		  RenderTargetIdentifier *v41; // rax
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  __int128 v44; // xmm1
		  CommandBuffer *v45; // rbx
		  TextureHandle sceneDepthWithWater; // xmm6
		  int32_t DepthTextureWithWater; // r14d
		  RenderTargetIdentifier *v48; // rax
		  __int64 v49; // rdx
		  __int64 v50; // rcx
		  bool IsValid; // al
		  HGRenderGraphDefaultResources *defaultResources; // rax
		  TextureHandle blackTexture_k__BackingField; // xmm6
		  __int64 v54; // rdx
		  __int64 v55; // rcx
		  TextureHandle v56; // xmm6
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  __int128 v59; // xmm1
		  HGVFXManager *instance; // rax
		  HGCamera *v61; // rbx
		  Vector4 v62; // xmm6
		  Vector4 v63; // xmm8
		  __int64 v64; // rcx
		  uint32_t v65; // xmm2_4
		  uint32_t v66; // xmm4_4
		  CBHandle *ConstantBuffer; // rax
		  void *ptr; // xmm1_8
		  CBHandle *v69; // rax
		  void *v70; // xmm1_8
		  CommandBuffer *v71; // rbx
		  uint32_t forwardDecalECSList; // ebx
		  bool enabled; // al
		  bool v74; // bl
		  uint32_t forwardTransparentECSList; // ebx
		  RendererList v76; // xmm7
		  bool v77; // al
		  HGRainRenderer *s_rainRenderer; // rax
		  HGSnowRenderer *s_snowRenderer; // rax
		  CBHandle *v80; // rax
		  void *v81; // xmm1_8
		  CBHandle *v82; // rax
		  __int128 v83; // xmm0
		  void *v84; // xmm1_8
		  CommandBuffer *v85; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  FrameSettings v87; // [rsp+28h] [rbp-D8h] BYREF
		  __int128 v88; // [rsp+40h] [rbp-C0h]
		  __int64 v89; // [rsp+50h] [rbp-B0h]
		  CBHandle v90; // [rsp+60h] [rbp-A0h] BYREF
		  RenderTargetIdentifier value; // [rsp+80h] [rbp-80h] BYREF
		  RenderTargetIdentifier v92; // [rsp+B0h] [rbp-50h] BYREF
		  _BYTE v93[1312]; // [rsp+E0h] [rbp-20h] BYREF
		  _BYTE v94[3192]; // [rsp+600h] [rbp+500h] BYREF
		
		  *(_OWORD *)&v90.bufferId = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3158, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3158, 0LL);
		    if ( !Patch )
		      goto LABEL_76;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)context,
		      (Object *)data,
		      0LL);
		  }
		  else
		  {
		    if ( !data )
		      goto LABEL_76;
		    camera = data->fields.camera;
		    if ( !camera )
		      goto LABEL_76;
		    if ( !context )
		      goto LABEL_76;
		    cmd = context->fields.cmd;
		    if ( !cmd )
		      goto LABEL_76;
		    UnityEngine::Rendering::CommandBuffer::SetProfilingHGPassImpl((CommandBuffer *)cmd, 5, 0LL);
		    bitDatas = camera->fields._frameSettings_k__BackingField.bitDatas;
		    *(_QWORD *)&v88 = *(_QWORD *)&camera->fields._frameSettings_k__BackingField.materialQuality;
		    *(BitArray128 *)&v87.bitDatas.data2 = bitDatas;
		    if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
		           (FrameSettings *)&v87.bitDatas.data2,
		           FrameSettingsField__Enum_OpaqueObjects,
		           0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&data->fields.sceneColorToSample, 0LL) )
		      {
		        if ( !data->fields.lowResRendering )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		          BlitMaterial = HG::Rendering::Runtime::HGUtils::GetBlitMaterial(0, TextureDimension__Enum_Tex2D, 0, 0LL);
		          v10 = context->fields.cmd;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          si128 = _mm_load_si128((const __m128i *)&xmmword_18B959740);
		          BlitScaleBias = (unsigned int)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlitScaleBias;
		          if ( !v10 )
		            sub_1800D8260(TypeInfo::HG::Rendering::Runtime::HGShaderIDs, BlitScaleBias);
		          *(__m128i *)&value.m_Type = si128;
		          UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(v10, BlitScaleBias, (Vector4 *)&value, 0LL);
		          v13 = context->fields.cmd;
		          sceneColorToSample = data->fields.sceneColorToSample;
		          BlitTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_BlitTexture;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          *(TextureHandle *)&v87.bitDatas.data2 = sceneColorToSample;
		          v16 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
		                  &v92,
		                  (TextureHandle *)&v87.bitDatas.data2,
		                  0LL);
		          if ( !v13 )
		            sub_1800D8260(v18, v17);
		          v19 = *(_OWORD *)&v16->m_BufferPointer;
		          *(_OWORD *)&v87.bitDatas.data2 = *(_OWORD *)&v16->m_Type;
		          v89 = *(_QWORD *)&v16->m_DepthSlice;
		          v88 = v19;
		          UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
		            v13,
		            BlitTexture,
		            (RenderTargetIdentifier *)&v87.bitDatas.data2,
		            0LL);
		          v20 = context->fields.cmd;
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		          UnityEngine::Rendering::CoreUtils::DrawFullScreen(v20, BlitMaterial, 0LL, 0, 0LL);
		        }
		        v21 = context->fields.cmd;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        v22 = data->fields.sceneColorToSample;
		        SceneColorTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_SceneColorTexture;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        *(TextureHandle *)&v87.bitDatas.data2 = v22;
		        v24 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
		                &v92,
		                (TextureHandle *)&v87.bitDatas.data2,
		                0LL);
		        if ( !v21 )
		          sub_1800D8260(v26, v25);
		        v27 = *(_OWORD *)&v24->m_BufferPointer;
		        *(_OWORD *)&v87.bitDatas.data2 = *(_OWORD *)&v24->m_Type;
		        v89 = *(_QWORD *)&v24->m_DepthSlice;
		        v88 = v27;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
		          v21,
		          SceneColorTexture,
		          (RenderTargetIdentifier *)&v87.bitDatas.data2,
		          0LL);
		      }
		      if ( !data->fields.gBufferProfileConfig )
		      {
		        v28 = 0;
		        while ( 1 )
		        {
		          gbuffer = data->fields.gbuffer;
		          if ( !gbuffer )
		            break;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          v30 = (TextureHandle *)sub_1803C0774(gbuffer, v28);
		          if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(v30, 0LL) )
		          {
		            v31 = context->fields.cmd;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		            cmd = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		            static_fields = (HGShaderIDs__StaticFields *)*((_QWORD *)cmd + 70);
		            if ( !static_fields )
		              break;
		            if ( (unsigned int)v28 >= static_fields->_Input0 )
		              sub_1800D2AB0(cmd, static_fields);
		            cmd = data->fields.gbuffer;
		            v33 = *(&static_fields->_Input2 + v28);
		            if ( !cmd )
		              break;
		            sub_1803C0830(cmd, &v87.bitDatas.data2, v28, v32);
		            sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		            *(_OWORD *)&value.m_Type = *(_OWORD *)&v87.bitDatas.data2;
		            v34 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v92, (TextureHandle *)&value, 0LL);
		            if ( !v31 )
		              sub_1800D8260(v36, v35);
		            v37 = *(_OWORD *)&v34->m_BufferPointer;
		            *(_OWORD *)&value.m_Type = *(_OWORD *)&v34->m_Type;
		            *(_QWORD *)&value.m_DepthSlice = *(_QWORD *)&v34->m_DepthSlice;
		            *(_OWORD *)&value.m_BufferPointer = v37;
		            UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(v31, v33, &value, 0LL);
		          }
		          if ( ++v28 >= 4 )
		            goto LABEL_27;
		        }
		LABEL_76:
		        sub_1800D8260(cmd, static_fields);
		      }
		LABEL_27:
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&data->fields.sceneDepthToSample, 0LL) )
		      {
		        v38 = context->fields.cmd;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        sceneDepthToSample = data->fields.sceneDepthToSample;
		        CameraDepthTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_CameraDepthTexture;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        *(TextureHandle *)&v87.bitDatas.data2 = sceneDepthToSample;
		        v41 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
		                &v92,
		                (TextureHandle *)&v87.bitDatas.data2,
		                0LL);
		        if ( !v38 )
		          sub_1800D8260(v43, v42);
		        v44 = *(_OWORD *)&v41->m_BufferPointer;
		        *(_OWORD *)&v87.bitDatas.data2 = *(_OWORD *)&v41->m_Type;
		        v89 = *(_QWORD *)&v41->m_DepthSlice;
		        v88 = v44;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
		          v38,
		          CameraDepthTexture,
		          (RenderTargetIdentifier *)&v87.bitDatas.data2,
		          0LL);
		      }
		      if ( HG::Rendering::Runtime::HGCamera::ShouldRenderWater(camera, 0LL)
		        && (sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle),
		            HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&data->fields.sceneDepthWithWater, 0LL)) )
		      {
		        v45 = context->fields.cmd;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        sceneDepthWithWater = data->fields.sceneDepthWithWater;
		        DepthTextureWithWater = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DepthTextureWithWater;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        *(TextureHandle *)&v87.bitDatas.data2 = sceneDepthWithWater;
		        v48 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
		                &v92,
		                (TextureHandle *)&v87.bitDatas.data2,
		                0LL);
		        if ( !v45 )
		          sub_1800D8260(v50, v49);
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        IsValid = HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&data->fields.sceneDepthToSample, 0LL);
		        v45 = context->fields.cmd;
		        if ( IsValid )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          v56 = data->fields.sceneDepthToSample;
		          DepthTextureWithWater = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_DepthTextureWithWater;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          *(TextureHandle *)&v87.bitDatas.data2 = v56;
		          v48 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
		                  &v92,
		                  (TextureHandle *)&v87.bitDatas.data2,
		                  0LL);
		          if ( !v45 )
		            sub_1800D8260(v58, v57);
		        }
		        else
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          cmd = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		          defaultResources = context->fields.defaultResources;
		          DepthTextureWithWater = *((_DWORD *)cmd + 127);
		          if ( !defaultResources )
		            goto LABEL_76;
		          blackTexture_k__BackingField = defaultResources->fields._blackTexture_k__BackingField;
		          sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		          *(TextureHandle *)&v87.bitDatas.data2 = blackTexture_k__BackingField;
		          v48 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
		                  &v92,
		                  (TextureHandle *)&v87.bitDatas.data2,
		                  0LL);
		          if ( !v45 )
		            sub_1800D8260(v55, v54);
		        }
		      }
		      v59 = *(_OWORD *)&v48->m_BufferPointer;
		      *(_OWORD *)&v87.bitDatas.data2 = *(_OWORD *)&v48->m_Type;
		      v89 = *(_QWORD *)&v48->m_DepthSlice;
		      v88 = v59;
		      UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
		        v45,
		        DepthTextureWithWater,
		        (RenderTargetIdentifier *)&v87.bitDatas.data2,
		        0LL);
		      if ( !data->fields.lowResRendering )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
		        instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
		        if ( instance )
		          HG::Rendering::Runtime::HGVFXManager::DrawVFXSceneColorAdjustmentMaterial(instance, context->fields.cmd, 0LL);
		      }
		      if ( data->fields.waterRenderingPass )
		        HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::RenderLighting(
		          data->fields.waterRenderingPass,
		          context,
		          data->fields.camera,
		          0LL);
		      if ( !data->fields.lowResRendering )
		      {
		        v61 = data->fields.camera;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
		        HG::Rendering::Runtime::VFXPPScanLinePass::DrawScanLineMaterial(context, v61, 0LL);
		      }
		      v62 = (Vector4)_mm_loadu_si128((const __m128i *)&data->fields.shaderVariablesGlobal);
		      v63 = (Vector4)_mm_loadu_si128((const __m128i *)&data->fields.shaderVariablesGlobal._ScreenParams);
		      if ( data->fields.lowResRendering )
		      {
		        cmd = context->fields.cmd;
		        if ( !cmd )
		          goto LABEL_76;
		        UnityEngine::Rendering::CommandBuffer::HGSetTransparentOffscreenBlend((CommandBuffer *)cmd, 1, 0LL);
		        cmd = data->fields.camera;
		        if ( !cmd )
		          goto LABEL_76;
		        v64 = *((_QWORD *)cmd + 6);
		        *(float *)&v90.size = 1.0 / (float)((int)v64 / 2);
		        *(float *)&v65 = *(float *)&v90.size + 1.0;
		        *(float *)&v66 = (float)(SHIDWORD(v64) / 2);
		        *((float *)&v90.size + 1) = 1.0 / *(float *)&v66;
		        v90.offset = v66;
		        *(float *)&v90.bufferId = (float)((int)v64 / 2);
		        data->fields.shaderVariablesGlobal._ScreenSize = *(Vector4 *)&v90.bufferId;
		        v90.offset = v66;
		        v90.size = v65;
		        *((float *)&v90.size + 1) = (float)(1.0 / *(float *)&v66) + 1.0;
		        data->fields.shaderVariablesGlobal._ScreenParams = *(Vector4 *)&v90.bufferId;
		        data->fields.shaderVariablesGlobal._WindMotorParams0.FixedElementField = (float)((int)v64 / 2) / *(float *)&v66;
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		        ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                           (CBHandle *)&value,
		                           &context->fields.renderContext,
		                           1312,
		                           0LL);
		        ptr = ConstantBuffer->ptr;
		        *(_OWORD *)&v87.bitDatas.data2 = *(_OWORD *)&ConstantBuffer->bufferId;
		        *(_QWORD *)&v88 = ptr;
		        v69 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                &v90,
		                &context->fields.renderContext,
		                3200,
		                0LL);
		        v70 = v69->ptr;
		        *(_OWORD *)&value.m_Type = *(_OWORD *)&v69->bufferId;
		        value.m_BufferPointer = v70;
		        sub_18033B330(v93, &data->fields.basicTransformConstants, 1312LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        sub_18033B330(v94, v93, 1312LL);
		        sub_1808AF3F0(&v87.bitDatas.data2, v94);
		        sub_18033B330(v94, &data->fields.shaderVariablesGlobal, 3200LL);
		        sub_1808AF42C(&value, v94);
		        v71 = context->fields.cmd;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        if ( !v71 )
		          goto LABEL_76;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		          v71,
		          v87.bitDatas.data2,
		          static_fields->_TransformVariables,
		          SHIDWORD(v87.bitDatas.data2),
		          1312,
		          0LL);
		        cmd = context->fields.cmd;
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        if ( !cmd )
		          goto LABEL_76;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		          (CommandBuffer *)cmd,
		          value.m_Type,
		          static_fields->_ShaderVariablesGlobal,
		          value.m_NameID,
		          3200,
		          0LL);
		      }
		      else if ( data->fields.transparentVRS )
		      {
		        cmd = context->fields.cmd;
		        if ( !cmd )
		          goto LABEL_76;
		        UnityEngine::Rendering::CommandBuffer::HGSetFragmentShadingRate(
		          (CommandBuffer *)cmd,
		          data->fields.transparentVRRx,
		          data->fields.transparentVRRy,
		          0LL);
		      }
		      forwardDecalECSList = data->fields.forwardDecalECSList;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      cmd = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardDecal;
		      if ( !cmd )
		        goto LABEL_76;
		      enabled = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled((HGGraphicsFeatureSwitch *)cmd, 0LL);
		      HG::Rendering::Runtime::HGRendererListUtils::DrawDecalECSRendererList(context, forwardDecalECSList, enabled, 0LL);
		      cmd = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->vfxDecal;
		      if ( !cmd )
		        goto LABEL_76;
		      v74 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled((HGGraphicsFeatureSwitch *)cmd, 0LL);
		      *(RendererList *)&v87.bitDatas.data2 = *HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(
		                                                (RendererList *)&v87.bitDatas.data2,
		                                                data->fields.vfxDecalRenderList,
		                                                0LL);
		      HG::Rendering::Runtime::HGRendererListUtils::DrawRendererList(
		        context,
		        (RendererList *)&v87.bitDatas.data2,
		        v74,
		        0LL);
		      HG::Rendering::Runtime::HGRendererListUtils::DrawECSRendererList(context, data->fields.vfxDecalECSList, v74, 0LL);
		      forwardTransparentECSList = data->fields.forwardTransparentECSList;
		      v76 = *HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(
		               (RendererList *)&v87.bitDatas.data2,
		               data->fields.transparentRenderList,
		               0LL);
		      cmd = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->forwardTransparent;
		      if ( !cmd )
		        goto LABEL_76;
		      v77 = HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabled((HGGraphicsFeatureSwitch *)cmd, 0LL);
		      *(RendererList *)&v87.bitDatas.data2 = v76;
		      HG::Rendering::Runtime::HGRendererListUtils::DrawECSMeshRendererListWithSRPRendererList(
		        context,
		        forwardTransparentECSList,
		        (RendererList *)&v87.bitDatas.data2,
		        v77,
		        0LL);
		      cmd = context->fields.cmd;
		      if ( !cmd )
		        goto LABEL_76;
		      UnityEngine::Rendering::CommandBuffer::HGDrawUIRendererListImpl(
		        (CommandBuffer *)cmd,
		        data->fields.hgUIRendererList,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
		      if ( !s_rainRenderer )
		        goto LABEL_76;
		      HG::Rendering::Runtime::HGRainRenderer::RenderSceneRain(s_rainRenderer, context, data->fields.camera, 0LL);
		      s_snowRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(0LL);
		      if ( !s_snowRenderer )
		        goto LABEL_76;
		      HG::Rendering::Runtime::HGSnowRenderer::RenderSnow(s_snowRenderer, context, data->fields.camera, 0LL);
		      if ( data->fields.lowResRendering )
		      {
		        cmd = context->fields.cmd;
		        if ( !cmd )
		          goto LABEL_76;
		        UnityEngine::Rendering::CommandBuffer::HGSetTransparentOffscreenBlend((CommandBuffer *)cmd, 0, 0LL);
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		        v80 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                (CBHandle *)&value,
		                &context->fields.renderContext,
		                1312,
		                0LL);
		        v81 = v80->ptr;
		        *(_OWORD *)&v87.bitDatas.data2 = *(_OWORD *)&v80->bufferId;
		        *(_QWORD *)&v88 = v81;
		        v82 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                &v90,
		                &context->fields.renderContext,
		                3200,
		                0LL);
		        v83 = *(_OWORD *)&v82->bufferId;
		        v84 = v82->ptr;
		        data->fields.shaderVariablesGlobal._ScreenSize = v62;
		        *(_OWORD *)&value.m_Type = v83;
		        value.m_BufferPointer = v84;
		        data->fields.shaderVariablesGlobal._ScreenParams = v63;
		        data->fields.shaderVariablesGlobal._WindMotorParams0.FixedElementField = v62.x
		                                                                               / _mm_shuffle_ps(
		                                                                                   (__m128)v62,
		                                                                                   (__m128)v62,
		                                                                                   85).m128_f32[0];
		        sub_18033B330(v94, &data->fields.basicTransformConstants, 1312LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        sub_18033B330(v93, v94, 1312LL);
		        sub_1808AF3F0(&v87.bitDatas.data2, v93);
		        sub_18033B330(v94, &data->fields.shaderVariablesGlobal, 3200LL);
		        sub_1808AF42C(&value, v94);
		        v85 = context->fields.cmd;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        if ( !v85 )
		          goto LABEL_76;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		          v85,
		          v87.bitDatas.data2,
		          static_fields->_TransformVariables,
		          SHIDWORD(v87.bitDatas.data2),
		          1312,
		          0LL);
		        cmd = context->fields.cmd;
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        if ( !cmd )
		          goto LABEL_76;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
		          (CommandBuffer *)cmd,
		          value.m_Type,
		          static_fields->_ShaderVariablesGlobal,
		          value.m_NameID,
		          3200,
		          0LL);
		      }
		      else if ( data->fields.transparentVRS )
		      {
		        cmd = context->fields.cmd;
		        if ( !cmd )
		          goto LABEL_76;
		        UnityEngine::Rendering::CommandBuffer::HGSetFragmentShadingRate((CommandBuffer *)cmd, 1u, 1u, 0LL);
		      }
		      cmd = context->fields.cmd;
		      if ( !cmd )
		        goto LABEL_76;
		      UnityEngine::Rendering::CommandBuffer::SetProfilingHGPassImpl((CommandBuffer *)cmd, 0, 0LL);
		    }
		  }
		}
		
		internal static void PerformForwardRendering(ForwardPassData data, HGRenderGraphContext context) {} // 0x0000000189BAB1AC-0x0000000189BAB274
		// Void PerformForwardRendering(ForwardPassUtils+ForwardPassData, HGRenderGraphContext)
		void HG::Rendering::Runtime::ForwardPassUtils::PerformForwardRendering(
		        ForwardPassUtils_ForwardPassData *data,
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ForwardPassUtils_ForwardOpaquePassData *opaqueData; // rax
		  HGCamera *camera; // rsi
		  HGSkyRenderer *s_skyRenderer; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3164, 0LL) )
		  {
		    if ( data )
		    {
		      opaqueData = data->fields.opaqueData;
		      if ( opaqueData )
		      {
		        camera = opaqueData->fields.camera;
		        HG::Rendering::Runtime::ForwardPassUtils::RenderForwardOpaque(context, data->fields.opaqueData, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		        s_skyRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_skyRenderer(0LL);
		        if ( context )
		        {
		          if ( s_skyRenderer )
		          {
		            HG::Rendering::Runtime::HGSkyRenderer::Render(
		              s_skyRenderer,
		              context->fields.cmd,
		              camera,
		              context->fields.renderContext,
		              0,
		              0LL);
		            HG::Rendering::Runtime::ForwardPassUtils::RenderForwardTransparent(
		              context,
		              data->fields.transparentData,
		              0LL);
		            return;
		          }
		        }
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3164, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)data,
		    (Object *)context,
		    0LL);
		}
		
	}
}
