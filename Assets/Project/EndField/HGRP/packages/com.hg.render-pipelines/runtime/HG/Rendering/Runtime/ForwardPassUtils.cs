using System;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace HG.Rendering.Runtime
{
	internal class ForwardPassUtils
	{
		public ForwardPassUtils()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		internal static void PrepareOpaquePassData(HGRenderPipeline hgrp, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, CullingResults cullingResults, PerObjectData bakedLightingConfig, uint forwardOpaqueECSRendererList, uint forwardOpaqueEqualECSRendererList, uint characterOpaqueECSRendererList, uint characterOutlineOpaqueECSRendererList, uint characterOutlineOpaqueEqualECSRendererList, bool characterOutlineEnabled, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask, ForwardPassUtils.ForwardOpaquePassData opaqueData)
		{
			// // Void PrepareOpaquePassData(HGRenderPipeline, HGRenderGraph, HGCamera, HGRenderGraphBuilder, CullingResults, PerObjectData, UInt32, UInt32, UInt32, UInt32, UInt32, Boolean, Single, Single, UInt32, ForwardPassUtils+ForwardOpaquePassData)
			// void HG::Rendering::Runtime::ForwardPassUtils::PrepareOpaquePassData(
			//         HGRenderPipeline *hgrp,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         HGRenderGraphBuilder *builder,
			//         CullingResults *cullingResults,
			//         PerObjectData__Enum bakedLightingConfig,
			//         uint32_t forwardOpaqueECSRendererList,
			//         uint32_t forwardOpaqueEqualECSRendererList,
			//         uint32_t characterOpaqueECSRendererList,
			//         uint32_t characterOutlineOpaqueECSRendererList,
			//         uint32_t characterOutlineOpaqueEqualECSRendererList,
			//         bool characterOutlineEnabled,
			//         float screenCullingRatio,
			//         float screenCullingRatioDistance,
			//         uint32_t screenCullingLayerMask,
			//         ForwardPassUtils_ForwardOpaquePassData *opaqueData,
			//         MethodInfo *method)
			// {
			//   HGGraphicsFeatureSwitch *forwardOpaque; // rdx
			//   ILFixDynamicMethodWrapper_2 *characterOutlineOpaque; // rcx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rax
			//   bool m_defaultValue; // r15
			//   char virtualMachine; // r12
			//   __int64 v28; // xmm1_8
			//   RendererListDesc *v29; // rax
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm1
			//   uint64_t InvalidHandle; // rax
			//   RendererListDesc *v44; // rax
			//   __int128 v45; // xmm1
			//   __int128 v46; // xmm0
			//   __int128 v47; // xmm1
			//   __int128 v48; // xmm0
			//   __int128 v49; // xmm1
			//   __int128 v50; // xmm0
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm0
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   __int128 v55; // xmm1
			//   __int128 v56; // xmm0
			//   __int128 v57; // xmm1
			//   uint64_t v58; // rax
			//   RendererListHandle v59; // rax
			//   String__Array *v60; // [rsp+28h] [rbp-F0h]
			//   String *v61; // [rsp+30h] [rbp-E8h]
			//   MethodInfo *v62; // [rsp+38h] [rbp-E0h]
			//   FrameSettings v63; // [rsp+98h] [rbp-80h] BYREF
			//   HGRenderGraphBuilder v64; // [rsp+B8h] [rbp-60h] BYREF
			//   RendererListDesc desc; // [rsp+D8h] [rbp-40h] BYREF
			//   RendererListDesc v66; // [rsp+1B8h] [rbp+A0h] BYREF
			// 
			//   if ( !byte_18D91954E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     byte_18D91954E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2617, 0LL) )
			//   {
			//     if ( opaqueData )
			//     {
			//       opaqueData.fields.camera = camera;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&opaqueData.fields,
			//         (OneofDescriptorProto *)forwardOpaque,
			//         v23,
			//         v24,
			//         v60,
			//         v61,
			//         v62);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//       characterOutlineOpaque = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//       forwardOpaque = static_fields.forwardOpaque;
			//       if ( forwardOpaque )
			//       {
			//         characterOutlineOpaque = (ILFixDynamicMethodWrapper_2 *)static_fields.characterOutlineOpaque;
			//         m_defaultValue = forwardOpaque.fields.m_defaultValue;
			//         if ( characterOutlineOpaque )
			//         {
			//           virtualMachine = (char)characterOutlineOpaque.fields.virtualMachine;
			//           if ( camera )
			//           {
			//             v28 = *(_QWORD *)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//             v63.bitDatas = camera.fields._frameSettings_k__BackingField.bitDatas;
			//             *(_QWORD *)&v63.materialQuality = v28;
			//             if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(&v63, FrameSettingsField__Enum_OpaqueObjects, 0LL) )
			//             {
			//               if ( m_defaultValue )
			//               {
			//                 v63.bitDatas = (BitArray128)*cullingResults;
			//                 v29 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardOpaqueRendererList(
			//                         &v66,
			//                         hgrp,
			//                         camera,
			//                         (CullingResults *)&v63,
			//                         bakedLightingConfig,
			//                         screenCullingRatio,
			//                         screenCullingRatioDistance,
			//                         screenCullingLayerMask,
			//                         0LL);
			//                 v30 = *(_OWORD *)&v29.stateBlock.hasValue;
			//                 *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v29.sortingCriteria;
			//                 v31 = *(_OWORD *)&v29.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//                 *(_OWORD *)&desc.stateBlock.hasValue = v30;
			//                 v32 = *(_OWORD *)&v29.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//                 *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v31;
			//                 v33 = *(_OWORD *)&v29.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//                 *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v32;
			//                 v34 = *(_OWORD *)&v29.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//                 *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v33;
			//                 v35 = *(_OWORD *)&v29.stateBlock.value.m_RasterState.m_OffsetFactor;
			//                 *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v34;
			//                 v36 = *(_OWORD *)&v29.stateBlock.value.m_StencilState.m_FailOperationFront;
			//                 v29 = (RendererListDesc *)((char *)v29 + 128);
			//                 *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v35;
			//                 characterOutlineOpaque = (ILFixDynamicMethodWrapper_2 *)&desc.overrideMaterial;
			//                 v37 = *(_OWORD *)&v29.sortingCriteria;
			//                 *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v36;
			//                 v38 = *(_OWORD *)&v29.stateBlock.hasValue;
			//                 *(_OWORD *)&desc.overrideMaterial = v37;
			//                 v39 = *(_OWORD *)&v29.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//                 *(_OWORD *)&desc.overrideMaterialPassIndex = v38;
			//                 v40 = *(_OWORD *)&v29.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//                 *(_OWORD *)&desc.sortingLayerMin = v39;
			//                 v41 = *(_OWORD *)&v29.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//                 *(_OWORD *)&desc.drawableFeedbackPtr = v40;
			//                 v42 = *(_OWORD *)&v29.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//                 *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v41;
			//                 *(_OWORD *)&desc._passName_k__BackingField.m_Id = v42;
			//                 if ( !renderGraph )
			//                   goto LABEL_23;
			//                 InvalidHandle = (uint64_t)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
			//                                             renderGraph,
			//                                             &desc,
			//                                             0LL);
			//               }
			//               else
			//               {
			//                 InvalidHandle = (uint64_t)HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//               }
			//               v63.bitDatas.data1 = InvalidHandle;
			//               opaqueData.fields.opaqueRenderList = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//                                                       builder,
			//                                                       (RendererListHandle *)&v63,
			//                                                       0LL);
			//               opaqueData.fields.forwardOpaqueECSRendererList = forwardOpaqueECSRendererList;
			//               opaqueData.fields.forwardOpaqueEqualECSRendererList = forwardOpaqueEqualECSRendererList;
			//               opaqueData.fields.characterOpaqueECSRendererList = characterOpaqueECSRendererList;
			//               opaqueData.fields.characterOutlineOpaqueECSRendererList = characterOutlineOpaqueECSRendererList;
			//               opaqueData.fields.characterOutlineOpaqueEqualECSRendererList = characterOutlineOpaqueEqualECSRendererList;
			//             }
			//             if ( !characterOutlineEnabled )
			//             {
			//               v59 = 0LL;
			//               goto LABEL_21;
			//             }
			//             if ( !virtualMachine )
			//             {
			//               v58 = (uint64_t)HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//               goto LABEL_19;
			//             }
			//             v44 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardOpaqueCharacterOutlineRendererList(
			//                     &v66,
			//                     hgrp,
			//                     camera,
			//                     cullingResults,
			//                     bakedLightingConfig,
			//                     screenCullingRatio,
			//                     screenCullingRatioDistance,
			//                     screenCullingLayerMask,
			//                     0LL);
			//             v45 = *(_OWORD *)&v44.stateBlock.hasValue;
			//             *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v44.sortingCriteria;
			//             v46 = *(_OWORD *)&v44.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc.stateBlock.hasValue = v45;
			//             v47 = *(_OWORD *)&v44.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v46;
			//             v48 = *(_OWORD *)&v44.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v47;
			//             v49 = *(_OWORD *)&v44.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v48;
			//             v50 = *(_OWORD *)&v44.stateBlock.value.m_RasterState.m_OffsetFactor;
			//             *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v49;
			//             v51 = *(_OWORD *)&v44.stateBlock.value.m_StencilState.m_FailOperationFront;
			//             v44 = (RendererListDesc *)((char *)v44 + 128);
			//             *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v50;
			//             characterOutlineOpaque = (ILFixDynamicMethodWrapper_2 *)&desc.overrideMaterial;
			//             v52 = *(_OWORD *)&v44.sortingCriteria;
			//             *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v51;
			//             v53 = *(_OWORD *)&v44.stateBlock.hasValue;
			//             *(_OWORD *)&desc.overrideMaterial = v52;
			//             v54 = *(_OWORD *)&v44.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc.overrideMaterialPassIndex = v53;
			//             v55 = *(_OWORD *)&v44.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc.sortingLayerMin = v54;
			//             v56 = *(_OWORD *)&v44.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc.drawableFeedbackPtr = v55;
			//             v57 = *(_OWORD *)&v44.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v56;
			//             *(_OWORD *)&desc._passName_k__BackingField.m_Id = v57;
			//             if ( renderGraph )
			//             {
			//               v58 = (uint64_t)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
			//                                 renderGraph,
			//                                 &desc,
			//                                 0LL);
			// LABEL_19:
			//               v63.bitDatas.data1 = v58;
			//               v59 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//                       builder,
			//                       (RendererListHandle *)&v63,
			//                       0LL);
			// LABEL_21:
			//               opaqueData.fields.characterOutlineOpaqueRenderList = v59;
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_23:
			//     sub_180B536AC(characterOutlineOpaque, forwardOpaque);
			//   }
			//   characterOutlineOpaque = IFix::WrappersManagerImpl::GetPatch(2617, 0LL);
			//   if ( !characterOutlineOpaque )
			//     goto LABEL_23;
			//   *(_OWORD *)&v64.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//   v63.bitDatas = (BitArray128)*cullingResults;
			//   *(_OWORD *)&v64.m_RenderGraph = *(_OWORD *)&builder.m_RenderGraph;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_956(
			//     characterOutlineOpaque,
			//     (Object *)hgrp,
			//     (Object *)renderGraph,
			//     (Object *)camera,
			//     &v64,
			//     (CullingResults *)&v63,
			//     bakedLightingConfig,
			//     forwardOpaqueECSRendererList,
			//     forwardOpaqueEqualECSRendererList,
			//     characterOpaqueECSRendererList,
			//     characterOutlineOpaqueECSRendererList,
			//     characterOutlineOpaqueEqualECSRendererList,
			//     characterOutlineEnabled,
			//     screenCullingRatio,
			//     screenCullingRatioDistance,
			//     screenCullingLayerMask,
			//     (Object *)opaqueData,
			//     0LL);
			// }
			// 
		}

		internal static void PrepareTransparentPassData(HGRenderPipeline hgrp, HGRenderGraph renderGraph, TextureHandle sceneColorToSample, TextureHandle sceneDepthToSample, TextureHandle sceneDepthWithWater, HGCamera camera, WaterOnePassDeferredRenderingPass waterRenderingPass, HGRenderGraphBuilder builder, CullingResults cullingResults, PerObjectData bakedLightingConfig, uint forwardTransparentECSList, bool characterOutlineEnabled, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask, ForwardPassUtils.ForwardTransparentPassData transparentData, [MetadataOffset(Offset = "0x01F9183F")] bool transparentVRS = false, [MetadataOffset(Offset = "0x01F91840")] int transparentVRRx = 1, [MetadataOffset(Offset = "0x01F91841")] int transparentVRRy = 1, [MetadataOffset(Offset = "0x01F91842")] bool lowResRendering = false, in BasicTransformConstants basicTransformConstants = null, in ShaderVariablesGlobal shaderVariablesGlobal = null)
		{
			// // Void PrepareTransparentPassData(HGRenderPipeline, HGRenderGraph, TextureHandle, TextureHandle, TextureHandle, HGCamera, WaterOnePassDeferredRenderingPass, HGRenderGraphBuilder, CullingResults, PerObjectData, UInt32, Boolean, Single, Single, UInt32, ForwardPassUtils+ForwardTransparentPassData, Boolean, Int32, Int32, Boolean, BasicTransformConstants ByRef, ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::ForwardPassUtils::PrepareTransparentPassData(
			//         HGRenderPipeline *hgrp,
			//         HGRenderGraph *renderGraph,
			//         TextureHandle *sceneColorToSample,
			//         TextureHandle *sceneDepthToSample,
			//         TextureHandle *sceneDepthWithWater,
			//         HGCamera *camera,
			//         WaterOnePassDeferredRenderingPass *waterRenderingPass,
			//         HGRenderGraphBuilder *builder,
			//         CullingResults *cullingResults,
			//         PerObjectData__Enum bakedLightingConfig,
			//         uint32_t forwardTransparentECSList,
			//         bool characterOutlineEnabled,
			//         float screenCullingRatio,
			//         float screenCullingRatioDistance,
			//         uint32_t screenCullingLayerMask,
			//         ForwardPassUtils_ForwardTransparentPassData *transparentData,
			//         bool transparentVRS,
			//         int32_t transparentVRRx,
			//         int32_t transparentVRRy,
			//         bool lowResRendering,
			//         BasicTransformConstants *basicTransformConstants,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   __int64 forwardTransparent; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   FileDescriptor *v29; // r8
			//   WaterOnePassDeferredRenderingPass *v30; // r9
			//   __int128 v31; // xmm1
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rax
			//   char v36; // bl
			//   char virtualMachine; // r12
			//   HGRenderGraph *v38; // xmm1_8
			//   RendererListDesc *v39; // rax
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   __int128 v48; // xmm1
			//   __int128 v49; // xmm0
			//   __int128 v50; // xmm1
			//   __int128 v51; // xmm0
			//   __int128 v52; // xmm1
			//   RendererListHandle InvalidHandle; // rax
			//   ShaderTagId__Array *vfxDecalPassNames; // rbx
			//   RendererListDesc *v55; // rax
			//   __int128 v56; // xmm1
			//   __int128 v57; // xmm0
			//   __int128 v58; // xmm1
			//   __int128 v59; // xmm0
			//   __int128 v60; // xmm1
			//   __int128 v61; // xmm0
			//   __int128 v62; // xmm1
			//   __int128 v63; // xmm0
			//   __int128 v64; // xmm1
			//   __int128 v65; // xmm0
			//   __int128 v66; // xmm1
			//   __int128 v67; // xmm0
			//   __int128 v68; // xmm1
			//   RendererListHandle v69; // rax
			//   uint32_t cullingViewHandle; // r15d
			//   HGRenderGraphContext *m_RenderGraphContext; // rbx
			//   uint32_t RendererList; // eax
			//   uint32_t v73; // r15d
			//   HGRenderGraphContext *v74; // rbx
			//   uint32_t v75; // eax
			//   int32_t cullingMask; // ebx
			//   LayerMask v77; // eax
			//   int32_t m_Mask; // r15d
			//   int32_t InstanceID; // esi
			//   HGRenderGraphContext *v80; // rbx
			//   uint32_t v81; // eax
			//   RendererListDesc *v82; // rcx
			//   __int64 v83; // rdx
			//   __int64 v84; // r8
			//   BasicTransformConstants *v85; // rax
			//   __int128 v86; // xmm1
			//   __int128 v87; // xmm0
			//   __int128 v88; // xmm1
			//   __int128 v89; // xmm0
			//   __int128 v90; // xmm1
			//   __int128 v91; // xmm0
			//   __int128 v92; // xmm1
			//   __int128 v93; // xmm1
			//   __int128 v94; // xmm0
			//   __int128 v95; // xmm1
			//   __int128 v96; // xmm0
			//   BasicTransformConstants *p_basicTransformConstants; // rax
			//   RendererListDesc *v98; // rcx
			//   __int128 v99; // xmm1
			//   __int128 v100; // xmm0
			//   __int128 v101; // xmm1
			//   __int128 v102; // xmm0
			//   __int128 v103; // xmm1
			//   __int128 v104; // xmm0
			//   Vector4 v105; // xmm1
			//   __int128 v106; // xmm1
			//   __int128 v107; // xmm0
			//   __int128 v108; // xmm1
			//   __int128 v109; // xmm0
			//   __int128 v110; // xmm0
			//   TextureHandle v111; // xmm0
			//   TextureHandle v112; // xmm1
			//   String__Array *globalKeywords; // [rsp+20h] [rbp-120h]
			//   String__Array *globalKeywordsa; // [rsp+20h] [rbp-120h]
			//   HGRenderKeyword__Enum globalKeywordsb; // [rsp+20h] [rbp-120h]
			//   String *context; // [rsp+28h] [rbp-118h]
			//   String *contexta; // [rsp+28h] [rbp-118h]
			//   MethodInfo *multiDraw; // [rsp+30h] [rbp-110h]
			//   MethodInfo *multiDrawa; // [rsp+30h] [rbp-110h]
			//   char v120; // [rsp+C0h] [rbp-80h]
			//   CullingResults v121; // [rsp+D0h] [rbp-70h] BYREF
			//   RendererListHandle input[2]; // [rsp+E0h] [rbp-60h] BYREF
			//   CullingResults v123; // [rsp+F0h] [rbp-50h] BYREF
			//   HGRenderGraphBuilder v124; // [rsp+100h] [rbp-40h] BYREF
			//   HGRenderGraphBuilder v125; // [rsp+120h] [rbp-20h] BYREF
			//   RendererListDesc desc; // [rsp+140h] [rbp+0h] BYREF
			//   RendererListDesc v127; // [rsp+220h] [rbp+E0h] BYREF
			//   RendererListDesc v128[16]; // [rsp+300h] [rbp+1C0h] BYREF
			// 
			//   if ( !byte_18D91954F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::Nullable);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D91954F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2618, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2618, 0LL);
			//     if ( Patch )
			//     {
			//       v123 = *cullingResults;
			//       v110 = *(_OWORD *)&builder.m_RenderGraph;
			//       *(_OWORD *)&v125.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//       *(_OWORD *)&v125.m_RenderGraph = v110;
			//       v111 = *sceneDepthToSample;
			//       v121 = (CullingResults)*sceneDepthWithWater;
			//       v112 = *sceneColorToSample;
			//       *(TextureHandle *)&input[0].m_IsValid = v111;
			//       *(TextureHandle *)&v124.m_RenderPass = v112;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_960(
			//         Patch,
			//         (Object *)hgrp,
			//         (Object *)renderGraph,
			//         (TextureHandle *)&v124,
			//         (TextureHandle *)input,
			//         (TextureHandle *)&v121,
			//         (Object *)camera,
			//         (Object *)waterRenderingPass,
			//         &v125,
			//         &v123,
			//         bakedLightingConfig,
			//         forwardTransparentECSList,
			//         characterOutlineEnabled,
			//         screenCullingRatio,
			//         screenCullingRatioDistance,
			//         screenCullingLayerMask,
			//         (Object *)transparentData,
			//         transparentVRS,
			//         transparentVRRx,
			//         transparentVRRy,
			//         lowResRendering,
			//         basicTransformConstants,
			//         shaderVariablesGlobal,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_47;
			//   }
			//   if ( !transparentData )
			//     goto LABEL_47;
			//   transparentData.fields.waterRenderingPass = waterRenderingPass;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&transparentData.fields.waterRenderingPass,
			//     (OneofDescriptorProto *)forwardTransparent,
			//     v29,
			//     (MessageDescriptor *)waterRenderingPass,
			//     globalKeywords,
			//     context,
			//     multiDraw);
			//   if ( v30 )
			//   {
			//     v31 = *(_OWORD *)&builder.m_RenderGraph;
			//     *(_OWORD *)&v124.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//     *(_OWORD *)&v124.m_RenderGraph = v31;
			//     HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PrepareInTransparentPass(v30, &v124, 0LL);
			//   }
			//   transparentData.fields.sceneColorToSample = *sceneColorToSample;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(sceneColorToSample, 0LL) )
			//     transparentData.fields.sceneColorToSample = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                                     (TextureHandle *)&v124,
			//                                                     builder,
			//                                                     sceneColorToSample,
			//                                                     0LL);
			//   transparentData.fields.sceneDepthToSample = *sceneDepthToSample;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(sceneDepthToSample, 0LL) )
			//     transparentData.fields.sceneDepthToSample = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                                     (TextureHandle *)&v124,
			//                                                     builder,
			//                                                     sceneDepthToSample,
			//                                                     0LL);
			//   transparentData.fields.sceneDepthWithWater = *sceneDepthWithWater;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(sceneDepthWithWater, 0LL) )
			//     transparentData.fields.sceneDepthWithWater = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                                      (TextureHandle *)&v124,
			//                                                      builder,
			//                                                      sceneDepthWithWater,
			//                                                      0LL);
			//   transparentData.fields.camera = camera;
			//   sub_1800054D0((OneofDescriptor *)&transparentData.fields, v32, v33, v34, globalKeywordsa, contexta, multiDrawa);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//   forwardTransparent = (__int64)static_fields.forwardTransparent;
			//   if ( !forwardTransparent )
			//     goto LABEL_47;
			//   v36 = *(_BYTE *)(forwardTransparent + 16);
			//   forwardTransparent = (__int64)static_fields.forwardDecal;
			//   if ( !forwardTransparent )
			//     goto LABEL_47;
			//   v120 = *(_BYTE *)(forwardTransparent + 16);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.vfxDecal;
			//   if ( !Patch )
			//     goto LABEL_47;
			//   virtualMachine = (char)Patch.fields.virtualMachine;
			//   transparentData.fields.forwardTransparentECSList = -1;
			//   transparentData.fields.forwardDecalECSList = -1;
			//   transparentData.fields.vfxDecalECSList = -1;
			//   if ( !camera )
			//     goto LABEL_47;
			//   v38 = *(HGRenderGraph **)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//   *(BitArray128 *)&v124.m_RenderPass = camera.fields._frameSettings_k__BackingField.bitDatas;
			//   v124.m_RenderGraph = v38;
			//   if ( !HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//           (FrameSettings *)&v124,
			//           FrameSettingsField__Enum_TransparentObjects,
			//           0LL) )
			//     return;
			//   if ( v36 )
			//   {
			//     v123 = *cullingResults;
			//     v39 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardTransparentRendererList(
			//             &v127,
			//             hgrp,
			//             camera,
			//             0,
			//             characterOutlineEnabled,
			//             &v123,
			//             bakedLightingConfig,
			//             screenCullingRatio,
			//             screenCullingRatioDistance,
			//             screenCullingLayerMask,
			//             0LL);
			//     forwardTransparent = 128LL;
			//     v40 = *(_OWORD *)&v39.stateBlock.hasValue;
			//     *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v39.sortingCriteria;
			//     v41 = *(_OWORD *)&v39.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.stateBlock.hasValue = v40;
			//     v42 = *(_OWORD *)&v39.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v41;
			//     v43 = *(_OWORD *)&v39.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v42;
			//     v44 = *(_OWORD *)&v39.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v43;
			//     v45 = *(_OWORD *)&v39.stateBlock.value.m_RasterState.m_OffsetFactor;
			//     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v44;
			//     v46 = *(_OWORD *)&v39.stateBlock.value.m_StencilState.m_FailOperationFront;
			//     v39 = (RendererListDesc *)((char *)v39 + 128);
			//     *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v45;
			//     Patch = (ILFixDynamicMethodWrapper_2 *)&desc.overrideMaterial;
			//     v47 = *(_OWORD *)&v39.sortingCriteria;
			//     *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v46;
			//     v48 = *(_OWORD *)&v39.stateBlock.hasValue;
			//     *(_OWORD *)&desc.overrideMaterial = v47;
			//     v49 = *(_OWORD *)&v39.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.overrideMaterialPassIndex = v48;
			//     v50 = *(_OWORD *)&v39.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.sortingLayerMin = v49;
			//     v51 = *(_OWORD *)&v39.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.drawableFeedbackPtr = v50;
			//     v52 = *(_OWORD *)&v39.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v51;
			//     *(_OWORD *)&desc._passName_k__BackingField.m_Id = v52;
			//     if ( !renderGraph )
			//       goto LABEL_47;
			//     InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//   }
			//   else
			//   {
			//     InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//   }
			//   input[0] = InvalidHandle;
			//   transparentData.fields.transparentRenderList = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//                                                     builder,
			//                                                     input,
			//                                                     0LL);
			//   if ( virtualMachine )
			//   {
			//     input[0] = (RendererListHandle)camera.fields.camera;
			//     if ( !hgrp )
			//       goto LABEL_47;
			//     vfxDecalPassNames = hgrp.fields.vfxDecalPassNames;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     v121.ptr = (void *)1;
			//     *(void **)((char *)&v121.ptr + 4) = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_All;
			//     sub_1802F01E0(&v127, 0LL, 112LL);
			//     LODWORD(v123.m_AllocationInfo) = v121.m_AllocationInfo;
			//     v123.ptr = v121.ptr;
			//     v121 = *cullingResults;
			//     v55 = HG::Rendering::Runtime::HGRendererListUtils::CreateTransparentRendererListDesc(
			//             v128,
			//             &v121,
			//             *(Camera **)input,
			//             vfxDecalPassNames,
			//             screenCullingRatio,
			//             screenCullingRatioDistance,
			//             screenCullingLayerMask,
			//             bakedLightingConfig,
			//             (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v123,
			//             (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&v127,
			//             0LL,
			//             0,
			//             0LL);
			//     forwardTransparent = 128LL;
			//     v56 = *(_OWORD *)&v55.stateBlock.hasValue;
			//     *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v55.sortingCriteria;
			//     v57 = *(_OWORD *)&v55.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.stateBlock.hasValue = v56;
			//     v58 = *(_OWORD *)&v55.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v57;
			//     v59 = *(_OWORD *)&v55.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v58;
			//     v60 = *(_OWORD *)&v55.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v59;
			//     v61 = *(_OWORD *)&v55.stateBlock.value.m_RasterState.m_OffsetFactor;
			//     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v60;
			//     v62 = *(_OWORD *)&v55.stateBlock.value.m_StencilState.m_FailOperationFront;
			//     v55 = (RendererListDesc *)((char *)v55 + 128);
			//     *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v61;
			//     Patch = (ILFixDynamicMethodWrapper_2 *)&desc.overrideMaterial;
			//     v63 = *(_OWORD *)&v55.sortingCriteria;
			//     *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v62;
			//     v64 = *(_OWORD *)&v55.stateBlock.hasValue;
			//     *(_OWORD *)&desc.overrideMaterial = v63;
			//     v65 = *(_OWORD *)&v55.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.overrideMaterialPassIndex = v64;
			//     v66 = *(_OWORD *)&v55.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.sortingLayerMin = v65;
			//     v67 = *(_OWORD *)&v55.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.drawableFeedbackPtr = v66;
			//     v68 = *(_OWORD *)&v55.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v67;
			//     *(_OWORD *)&desc._passName_k__BackingField.m_Id = v68;
			//     if ( !renderGraph )
			//       goto LABEL_47;
			//     v69 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//   }
			//   else
			//   {
			//     v69 = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//   }
			//   input[0] = v69;
			//   transparentData.fields.vfxDecalRenderList = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//                                                  builder,
			//                                                  input,
			//                                                  0LL);
			//   if ( v120 )
			//   {
			//     cullingViewHandle = camera.fields.cullingViewHandle;
			//     if ( !renderGraph )
			//       goto LABEL_47;
			//     m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//     if ( !m_RenderGraphContext )
			//       goto LABEL_47;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     RendererList = UnityEngine::HyperGryph::HGDecalRender::CreateRendererList(
			//                      cullingViewHandle,
			//                      HGShaderLightMode__Enum_ForwardDecal,
			//                      m_RenderGraphContext.fields.renderContext.m_Ptr,
			//                      0LL);
			//   }
			//   else
			//   {
			//     RendererList = -1;
			//   }
			//   transparentData.fields.forwardDecalECSList = RendererList;
			//   if ( !virtualMachine )
			//   {
			//     v75 = -1;
			//     goto LABEL_37;
			//   }
			//   v73 = camera.fields.cullingViewHandle;
			//   if ( !renderGraph || (v74 = renderGraph.fields.m_RenderGraphContext) == 0LL )
			// LABEL_47:
			//     sub_180B536AC(Patch, forwardTransparent);
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//   LOWORD(globalKeywordsb) = 0;
			//   v75 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//           v73,
			//           HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
			//           HGRenderFlags__Enum_Transparent,
			//           HGShaderLightMode__Enum_VFXDecal,
			//           globalKeywordsb,
			//           v74.fields.renderContext.m_Ptr,
			//           0,
			//           1,
			//           0xFFFFFFFF,
			//           0,
			//           0,
			//           0LL);
			// LABEL_37:
			//   transparentData.fields.vfxDecalECSList = v75;
			//   transparentData.fields.forwardTransparentECSList = forwardTransparentECSList;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)camera.fields.camera;
			//   if ( !Patch )
			//     goto LABEL_47;
			//   cullingMask = UnityEngine::Camera::get_cullingMask((Camera *)Patch, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//   v77.m_Mask = HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer((LayerMask)cullingMask, 0LL).m_Mask;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)camera.fields.camera;
			//   m_Mask = v77.m_Mask;
			//   if ( !Patch )
			//     goto LABEL_47;
			//   InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)Patch, 0LL);
			//   if ( !renderGraph )
			//     goto LABEL_47;
			//   v80 = renderGraph.fields.m_RenderGraphContext;
			//   if ( !v80 )
			//     goto LABEL_47;
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//   v81 = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
			//           m_Mask,
			//           0,
			//           0,
			//           0x802060u,
			//           0x8000,
			//           0x7FFF,
			//           InstanceID,
			//           v80.fields.renderContext.m_Ptr,
			//           0,
			//           3.4028235e38,
			//           0LL);
			//   transparentData.fields.forwardTransparentAfterUIECSList = -1;
			//   v82 = v128;
			//   transparentData.fields.hgUIRendererList = v81;
			//   v83 = 5LL;
			//   v84 = 5LL;
			//   transparentData.fields.transparentVRS = transparentVRS;
			//   transparentData.fields.transparentVRRx = transparentVRRx;
			//   transparentData.fields.transparentVRRy = transparentVRRy;
			//   transparentData.fields.lowResRendering = lowResRendering;
			//   v85 = basicTransformConstants;
			//   do
			//   {
			//     v86 = *(_OWORD *)&v85._ViewMatrix.m01;
			//     *(_OWORD *)&v82.sortingCriteria = *(_OWORD *)&v85._ViewMatrix.m00;
			//     v87 = *(_OWORD *)&v85._ViewMatrix.m02;
			//     *(_OWORD *)&v82.stateBlock.hasValue = v86;
			//     v88 = *(_OWORD *)&v85._ViewMatrix.m03;
			//     *(_OWORD *)&v82.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v87;
			//     v89 = *(_OWORD *)&v85._InvViewMatrix.m00;
			//     *(_OWORD *)&v82.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v88;
			//     v90 = *(_OWORD *)&v85._InvViewMatrix.m01;
			//     *(_OWORD *)&v82.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v89;
			//     v91 = *(_OWORD *)&v85._InvViewMatrix.m02;
			//     *(_OWORD *)&v82.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v90;
			//     v92 = *(_OWORD *)&v85._InvViewMatrix.m03;
			//     v85 = (BasicTransformConstants *)((char *)v85 + 128);
			//     *(_OWORD *)&v82.stateBlock.value.m_RasterState.m_OffsetFactor = v91;
			//     v82 = (RendererListDesc *)((char *)v82 + 128);
			//     *(_OWORD *)&v82[-1]._passName_k__BackingField.m_Id = v92;
			//     --v84;
			//   }
			//   while ( v84 );
			//   v93 = *(_OWORD *)&v85._ViewMatrix.m01;
			//   *(_OWORD *)&v82.sortingCriteria = *(_OWORD *)&v85._ViewMatrix.m00;
			//   v94 = *(_OWORD *)&v85._ViewMatrix.m02;
			//   *(_OWORD *)&v82.stateBlock.hasValue = v93;
			//   v95 = *(_OWORD *)&v85._ViewMatrix.m03;
			//   *(_OWORD *)&v82.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v94;
			//   v96 = *(_OWORD *)&v85._InvViewMatrix.m00;
			//   p_basicTransformConstants = &transparentData.fields.basicTransformConstants;
			//   *(_OWORD *)&v82.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v95;
			//   *(_OWORD *)&v82.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v96;
			//   v98 = v128;
			//   do
			//   {
			//     v99 = *(_OWORD *)&v98.stateBlock.hasValue;
			//     *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m00 = *(_OWORD *)&v98.sortingCriteria;
			//     v100 = *(_OWORD *)&v98.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m01 = v99;
			//     v101 = *(_OWORD *)&v98.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m02 = v100;
			//     v102 = *(_OWORD *)&v98.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m03 = v101;
			//     v103 = *(_OWORD *)&v98.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m00 = v102;
			//     v104 = *(_OWORD *)&v98.stateBlock.value.m_RasterState.m_OffsetFactor;
			//     *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m01 = v103;
			//     v105 = *(Vector4 *)&v98.stateBlock.value.m_StencilState.m_FailOperationFront;
			//     v98 = (RendererListDesc *)((char *)v98 + 128);
			//     *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m02 = v104;
			//     p_basicTransformConstants = (BasicTransformConstants *)((char *)p_basicTransformConstants + 128);
			//     p_basicTransformConstants[-1]._WorldSpaceCameraPos_Internal = v105;
			//     --v83;
			//   }
			//   while ( v83 );
			//   v106 = *(_OWORD *)&v98.stateBlock.hasValue;
			//   *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m00 = *(_OWORD *)&v98.sortingCriteria;
			//   v107 = *(_OWORD *)&v98.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m01 = v106;
			//   v108 = *(_OWORD *)&v98.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m02 = v107;
			//   v109 = *(_OWORD *)&v98.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m03 = v108;
			//   *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m00 = v109;
			//   sub_1802EFB40(v128, shaderVariablesGlobal, 3792LL);
			//   sub_1802EFB40(&transparentData.fields.shaderVariablesGlobal, v128, 3792LL);
			// }
			// 
		}

		public static RendererListDesc PrepareForwardOpaqueRendererList(HGRenderPipeline hgrp, HGCamera camera, CullingResults cullingResults, PerObjectData backedLightingConfig, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask)
		{
			// // RendererListDesc PrepareForwardOpaqueRendererList(HGRenderPipeline, HGCamera, CullingResults, PerObjectData, Single, Single, UInt32)
			// RendererListDesc *HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardOpaqueRendererList(
			//         RendererListDesc *__return_ptr retstr,
			//         HGRenderPipeline *hgrp,
			//         HGCamera *camera,
			//         CullingResults *cullingResults,
			//         PerObjectData__Enum backedLightingConfig,
			//         float screenCullingRatio,
			//         float screenCullingRatioDistance,
			//         uint32_t screenCullingLayerMask,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v14; // rcx
			//   uint64_t data2; // r8
			//   uint64_t data1; // rdx
			//   ShaderTagId__Array *forwardOnlyPassNames; // rsi
			//   PerObjectData__Enum PerObjectDataConfig; // ebx
			//   Camera *v19; // r8
			//   RendererListDesc *v20; // rax
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   RendererListDesc *result; // rax
			//   Nullable_1_UnityEngine_Rendering_RenderQueueRange_ v35; // [rsp+78h] [rbp-90h] BYREF
			//   CullingResults v36; // [rsp+88h] [rbp-80h] BYREF
			//   __int64 v37; // [rsp+98h] [rbp-70h]
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v38; // [rsp+A8h] [rbp-60h] BYREF
			//   RendererListDesc v39; // [rsp+118h] [rbp+10h] BYREF
			// 
			//   if ( !byte_18D919550 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     byte_18D919550 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2595, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2595, 0LL);
			//     if ( Patch )
			//     {
			//       v36 = *cullingResults;
			//       v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_949(
			//               &v39,
			//               Patch,
			//               (Object *)hgrp,
			//               (Object *)camera,
			//               &v36,
			//               backedLightingConfig,
			//               screenCullingRatio,
			//               screenCullingRatioDistance,
			//               screenCullingLayerMask,
			//               0LL);
			//       goto LABEL_14;
			//     }
			//     goto LABEL_12;
			//   }
			//   if ( !camera )
			//     goto LABEL_12;
			//   data2 = camera.fields._frameSettings_k__BackingField.bitDatas.data2;
			//   data1 = camera.fields._frameSettings_k__BackingField.bitDatas.data1;
			//   v37 = *(_QWORD *)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//   if ( UnityEngine::Rendering::BitArrayUtilities::Get128(0, data1, data2, 0LL) )
			//   {
			//     if ( hgrp )
			//     {
			//       forwardOnlyPassNames = hgrp.fields.forwardOnlyPassNames;
			//       goto LABEL_10;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v14, Patch);
			//   }
			//   if ( !hgrp )
			//     goto LABEL_12;
			//   forwardOnlyPassNames = hgrp.fields.forwardAndForwardOnlyPassNames;
			// LABEL_10:
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//   *(_QWORD *)&v35.hasValue = 0LL;
			//   PerObjectDataConfig = HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
			//   sub_1802F01E0(&v38, 0LL, 112LL);
			//   v19 = camera.fields.camera;
			//   v36 = *cullingResults;
			//   v35.value.m_UpperBound = 0;
			//   v20 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//           &v39,
			//           &v36,
			//           v19,
			//           forwardOnlyPassNames,
			//           screenCullingRatio,
			//           screenCullingRatioDistance,
			//           screenCullingLayerMask,
			//           (PerObjectData__Enum)(backedLightingConfig | PerObjectDataConfig),
			//           &v35,
			//           &v38,
			//           0LL,
			//           0,
			//           0LL);
			// LABEL_14:
			//   v21 = *(_OWORD *)&v20.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v20.sortingCriteria;
			//   v22 = *(_OWORD *)&v20.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v21;
			//   v23 = *(_OWORD *)&v20.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v22;
			//   v24 = *(_OWORD *)&v20.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v23;
			//   v25 = *(_OWORD *)&v20.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v24;
			//   v26 = *(_OWORD *)&v20.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v25;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v26;
			//   v27 = *(_OWORD *)&v20.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v20.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v27;
			//   v29 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v30 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v29;
			//   v31 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v30;
			//   v32 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v31;
			//   v33 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v32;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v33;
			//   return result;
			// }
			// 
			return null;
		}

		public static RendererListDesc PrepareForwardOpaqueCharacterOutlineRendererList(HGRenderPipeline hgrp, HGCamera camera, ref CullingResults cullingResults, PerObjectData bakedLightingConfig, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask)
		{
			// // RendererListDesc PrepareForwardOpaqueCharacterOutlineRendererList(HGRenderPipeline, HGCamera, CullingResults ByRef, PerObjectData, Single, Single, UInt32)
			// RendererListDesc *HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardOpaqueCharacterOutlineRendererList(
			//         RendererListDesc *__return_ptr retstr,
			//         HGRenderPipeline *hgrp,
			//         HGCamera *camera,
			//         CullingResults *cullingResults,
			//         PerObjectData__Enum bakedLightingConfig,
			//         float screenCullingRatio,
			//         float screenCullingRatioDistance,
			//         uint32_t screenCullingLayerMask,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v14; // rcx
			//   ShaderTagId__Array *characterOutlinePassNames; // r15
			//   PerObjectData__Enum PerObjectDataConfig; // ebx
			//   Camera *v17; // r8
			//   RendererListDesc *v18; // rax
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v27; // xmm0
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   RendererListDesc *result; // rax
			//   Nullable_1_UnityEngine_Rendering_RenderQueueRange_ v33; // [rsp+78h] [rbp-90h] BYREF
			//   CullingResults v34; // [rsp+88h] [rbp-80h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v35; // [rsp+98h] [rbp-70h] BYREF
			//   RendererListDesc v36; // [rsp+108h] [rbp+0h] BYREF
			// 
			//   if ( !byte_18D919551 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     byte_18D919551 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2596, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2596, 0LL);
			//     if ( Patch )
			//     {
			//       v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_950(
			//               &v36,
			//               Patch,
			//               (Object *)hgrp,
			//               (Object *)camera,
			//               cullingResults,
			//               bakedLightingConfig,
			//               screenCullingRatio,
			//               screenCullingRatioDistance,
			//               screenCullingLayerMask,
			//               0LL);
			//       goto LABEL_10;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v14, Patch);
			//   }
			//   if ( !hgrp )
			//     goto LABEL_8;
			//   characterOutlinePassNames = hgrp.fields.characterOutlinePassNames;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//   PerObjectDataConfig = HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
			//   if ( !camera )
			//     goto LABEL_8;
			//   *(_QWORD *)&v33.hasValue = 0LL;
			//   sub_1802F01E0(&v35, 0LL, 112LL);
			//   v17 = camera.fields.camera;
			//   v34 = *cullingResults;
			//   v33.value.m_UpperBound = 0;
			//   v18 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//           &v36,
			//           &v34,
			//           v17,
			//           characterOutlinePassNames,
			//           screenCullingRatio,
			//           screenCullingRatioDistance,
			//           screenCullingLayerMask,
			//           (PerObjectData__Enum)(bakedLightingConfig | PerObjectDataConfig),
			//           &v33,
			//           &v35,
			//           0LL,
			//           0,
			//           0LL);
			// LABEL_10:
			//   v19 = *(_OWORD *)&v18.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v18.sortingCriteria;
			//   v20 = *(_OWORD *)&v18.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v19;
			//   v21 = *(_OWORD *)&v18.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v20;
			//   v22 = *(_OWORD *)&v18.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v21;
			//   v23 = *(_OWORD *)&v18.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v22;
			//   v24 = *(_OWORD *)&v18.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v23;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v24;
			//   v25 = *(_OWORD *)&v18.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v18.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v25;
			//   v27 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v28 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v27;
			//   v29 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v28;
			//   v30 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v29;
			//   v31 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v30;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v31;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		private static RendererListDesc PrepareForwardTransparentRendererList(CullingResults cullResults, HGCamera hgCamera, ShaderTagId[] passNames, bool preRefraction, PerObjectData backedLightingConfig, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask, [MetadataOffset(Offset = "0x01F91843")] PerObjectData additionalConfig = PerObjectData.None)
		{
			// // RendererListDesc PrepareForwardTransparentRendererList(CullingResults, HGCamera, ShaderTagId[], Boolean, PerObjectData, Single, Single, UInt32, PerObjectData)
			// RendererListDesc *HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardTransparentRendererList(
			//         RendererListDesc *__return_ptr retstr,
			//         CullingResults *cullResults,
			//         HGCamera *hgCamera,
			//         ShaderTagId__Array *passNames,
			//         bool preRefraction,
			//         PerObjectData__Enum backedLightingConfig,
			//         float screenCullingRatio,
			//         float screenCullingRatioDistance,
			//         uint32_t screenCullingLayerMask,
			//         PerObjectData__Enum additionalConfig,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v16; // rcx
			//   __int64 v17; // xmm1_8
			//   void *k_RenderQueue_Transparent; // rbx
			//   __int64 v19; // xmm1_8
			//   __int64 v20; // xmm1_8
			//   Camera *camera; // r8
			//   RendererListDesc *v22; // rax
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   RendererListDesc *result; // rax
			//   FrameSettings v37; // [rsp+70h] [rbp-98h] BYREF
			//   __int64 v38; // [rsp+88h] [rbp-80h]
			//   CullingResults v39; // [rsp+98h] [rbp-70h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v40; // [rsp+A8h] [rbp-60h] BYREF
			//   RendererListDesc v41; // [rsp+118h] [rbp+10h] BYREF
			// 
			//   if ( !byte_18D919552 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::Nullable);
			//     byte_18D919552 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2621, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2621, 0LL);
			//     if ( Patch )
			//     {
			//       *(CullingResults *)&v37.bitDatas.data2 = *cullResults;
			//       v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_958(
			//               &v41,
			//               Patch,
			//               (CullingResults *)&v37.bitDatas.data2,
			//               (Object *)hgCamera,
			//               (Object *)passNames,
			//               preRefraction,
			//               backedLightingConfig,
			//               screenCullingRatio,
			//               screenCullingRatioDistance,
			//               screenCullingLayerMask,
			//               additionalConfig,
			//               0LL);
			//       goto LABEL_18;
			//     }
			//     goto LABEL_16;
			//   }
			//   if ( !preRefraction )
			//   {
			//     if ( hgCamera )
			//     {
			//       v17 = *(_QWORD *)&hgCamera.fields._frameSettings_k__BackingField.materialQuality;
			//       *(BitArray128 *)&v37.bitDatas.data2 = hgCamera.fields._frameSettings_k__BackingField.bitDatas;
			//       v38 = v17;
			//       if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//              (FrameSettings *)&v37.bitDatas.data2,
			//              FrameSettingsField__Enum_LowResTransparent,
			//              0LL) )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//         k_RenderQueue_Transparent = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_Transparent;
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//         k_RenderQueue_Transparent = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_TransparentWithLowRes;
			//       }
			//       goto LABEL_10;
			//     }
			// LABEL_16:
			//     sub_180B536AC(v16, Patch);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//   k_RenderQueue_Transparent = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_PreRefraction;
			//   if ( !hgCamera )
			//     goto LABEL_16;
			// LABEL_10:
			//   v19 = *(_QWORD *)&hgCamera.fields._frameSettings_k__BackingField.materialQuality;
			//   *(BitArray128 *)&v37.bitDatas.data2 = hgCamera.fields._frameSettings_k__BackingField.bitDatas;
			//   v38 = v19;
			//   if ( !HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//           (FrameSettings *)&v37.bitDatas.data2,
			//           FrameSettingsField__Enum_Refraction,
			//           0LL) )
			//   {
			//     v20 = *(_QWORD *)&hgCamera.fields._frameSettings_k__BackingField.materialQuality;
			//     *(BitArray128 *)&v37.bitDatas.data2 = hgCamera.fields._frameSettings_k__BackingField.bitDatas;
			//     v38 = v20;
			//     if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//            (FrameSettings *)&v37.bitDatas.data2,
			//            FrameSettingsField__Enum_LowResTransparent,
			//            0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//       k_RenderQueue_Transparent = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllTransparent;
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//       k_RenderQueue_Transparent = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllTransparentWithLowRes;
			//     }
			//   }
			//   LODWORD(v39.ptr) = 1;
			//   *(void **)((char *)&v39.ptr + 4) = k_RenderQueue_Transparent;
			//   sub_1802F01E0(&v40, 0LL, 112LL);
			//   camera = hgCamera.fields.camera;
			//   v37.materialQuality = (int32_t)v39.m_AllocationInfo;
			//   v37.bitDatas.data2 = (uint64_t)v39.ptr;
			//   v39 = *cullResults;
			//   v22 = HG::Rendering::Runtime::HGRendererListUtils::CreateTransparentRendererListDesc(
			//           &v41,
			//           &v39,
			//           camera,
			//           passNames,
			//           screenCullingRatio,
			//           screenCullingRatioDistance,
			//           screenCullingLayerMask,
			//           (PerObjectData__Enum)(additionalConfig | backedLightingConfig),
			//           (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v37.bitDatas.data2,
			//           &v40,
			//           0LL,
			//           0,
			//           0LL);
			// LABEL_18:
			//   v23 = *(_OWORD *)&v22.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v22.sortingCriteria;
			//   v24 = *(_OWORD *)&v22.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v23;
			//   v25 = *(_OWORD *)&v22.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v24;
			//   v26 = *(_OWORD *)&v22.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v25;
			//   v27 = *(_OWORD *)&v22.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v26;
			//   v28 = *(_OWORD *)&v22.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v27;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v28;
			//   v29 = *(_OWORD *)&v22.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v22.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v29;
			//   v31 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v32 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v31;
			//   v33 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v32;
			//   v34 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v33;
			//   v35 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v34;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v35;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		private static RendererListDesc PrepareForwardTransparentRendererList(HGRenderPipeline hgrp, HGCamera camera, bool preRefraction, bool enableOutline, CullingResults cullingResults, PerObjectData backedLightingConfig, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask)
		{
			// // RendererListDesc PrepareForwardTransparentRendererList(HGRenderPipeline, HGCamera, Boolean, Boolean, CullingResults, PerObjectData, Single, Single, UInt32)
			// RendererListDesc *HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardTransparentRendererList(
			//         RendererListDesc *__return_ptr retstr,
			//         HGRenderPipeline *hgrp,
			//         HGCamera *camera,
			//         bool preRefraction,
			//         bool enableOutline,
			//         CullingResults *cullingResults,
			//         PerObjectData__Enum backedLightingConfig,
			//         float screenCullingRatio,
			//         float screenCullingRatioDistance,
			//         uint32_t screenCullingLayerMask,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v16; // rcx
			//   ShaderTagId__Array *allTransparentWithOutlinePassNames; // rbx
			//   PerObjectData__Enum PerObjectMotionVectorConfig; // eax
			//   RendererListDesc *v19; // rax
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   RendererListDesc *result; // rax
			//   CullingResults v34; // [rsp+60h] [rbp-F8h] BYREF
			//   RendererListDesc v35; // [rsp+70h] [rbp-E8h] BYREF
			// 
			//   if ( !byte_18D919553 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     byte_18D919553 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2620, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2620, 0LL);
			//     if ( Patch )
			//     {
			//       v34 = *cullingResults;
			//       v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_959(
			//               &v35,
			//               Patch,
			//               (Object *)hgrp,
			//               (Object *)camera,
			//               preRefraction,
			//               enableOutline,
			//               &v34,
			//               backedLightingConfig,
			//               screenCullingRatio,
			//               screenCullingRatioDistance,
			//               screenCullingLayerMask,
			//               0LL);
			//       goto LABEL_12;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v16, Patch);
			//   }
			//   if ( !hgrp )
			//     goto LABEL_10;
			//   if ( enableOutline )
			//     allTransparentWithOutlinePassNames = hgrp.fields.allTransparentWithOutlinePassNames;
			//   else
			//     allTransparentWithOutlinePassNames = hgrp.fields.allTransparentPassNames;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//   PerObjectMotionVectorConfig = HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectMotionVectorConfig(camera, 0LL);
			//   v34 = *cullingResults;
			//   v19 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardTransparentRendererList(
			//           &v35,
			//           &v34,
			//           camera,
			//           allTransparentWithOutlinePassNames,
			//           preRefraction,
			//           backedLightingConfig,
			//           screenCullingRatio,
			//           screenCullingRatioDistance,
			//           screenCullingLayerMask,
			//           (PerObjectData__Enum)(PerObjectMotionVectorConfig | 0x8000),
			//           0LL);
			// LABEL_12:
			//   v20 = *(_OWORD *)&v19.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v19.sortingCriteria;
			//   v21 = *(_OWORD *)&v19.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v20;
			//   v22 = *(_OWORD *)&v19.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v21;
			//   v23 = *(_OWORD *)&v19.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v22;
			//   v24 = *(_OWORD *)&v19.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v23;
			//   v25 = *(_OWORD *)&v19.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v24;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v25;
			//   v26 = *(_OWORD *)&v19.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v19.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v26;
			//   v28 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v29 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v28;
			//   v30 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v29;
			//   v31 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v30;
			//   v32 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v31;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v32;
			//   return result;
			// }
			// 
			return null;
		}

		public static RendererListDesc PrepareAfterDOFTranparentRendererList(HGRenderPipeline hgrp, HGCamera hgCamera, bool enableOutline, CullingResults cullingResults, PerObjectData backedLightingConfig, float screenCullingRatio, float screenCullingRatioDistance, uint screenCullingLayerMask)
		{
			// // RendererListDesc PrepareAfterDOFTranparentRendererList(HGRenderPipeline, HGCamera, Boolean, CullingResults, PerObjectData, Single, Single, UInt32)
			// RendererListDesc *HG::Rendering::Runtime::ForwardPassUtils::PrepareAfterDOFTranparentRendererList(
			//         RendererListDesc *__return_ptr retstr,
			//         HGRenderPipeline *hgrp,
			//         HGCamera *hgCamera,
			//         bool enableOutline,
			//         CullingResults *cullingResults,
			//         PerObjectData__Enum backedLightingConfig,
			//         float screenCullingRatio,
			//         float screenCullingRatioDistance,
			//         uint32_t screenCullingLayerMask,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v15; // rcx
			//   ShaderTagId__Array *v16; // rsi
			//   PerObjectData__Enum PerObjectMotionVectorConfig; // r15d
			//   Camera *camera; // rbx
			//   RendererListDesc *v19; // rax
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   RendererListDesc *result; // rax
			//   CullingResults v34; // [rsp+78h] [rbp-90h] BYREF
			//   CullingResults v35; // [rsp+88h] [rbp-80h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v36; // [rsp+98h] [rbp-70h] BYREF
			//   RendererListDesc v37; // [rsp+108h] [rbp+0h] BYREF
			// 
			//   if ( !byte_18D919554 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::Nullable);
			//     byte_18D919554 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2622, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2622, 0LL);
			//     if ( Patch )
			//     {
			//       v35 = *cullingResults;
			//       v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_961(
			//               &v37,
			//               Patch,
			//               (Object *)hgrp,
			//               (Object *)hgCamera,
			//               enableOutline,
			//               &v35,
			//               backedLightingConfig,
			//               screenCullingRatio,
			//               screenCullingRatioDistance,
			//               screenCullingLayerMask,
			//               0LL);
			//       goto LABEL_13;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v15, Patch);
			//   }
			//   if ( !hgrp )
			//     goto LABEL_11;
			//   v16 = enableOutline
			//       ? hgrp.fields.allTransparentPassWithOutlineAfterDOFPassNames
			//       : hgrp.fields.allTransparentPassAfterDOFNames;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//   PerObjectMotionVectorConfig = HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectMotionVectorConfig(hgCamera, 0LL);
			//   if ( !hgCamera )
			//     goto LABEL_11;
			//   camera = hgCamera.fields.camera;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//   v34.ptr = (void *)1;
			//   *(void **)((char *)&v34.ptr + 4) = (void *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AfterPostProcessTransparent;
			//   sub_1802F01E0(&v36, 0LL, 112LL);
			//   LODWORD(v35.m_AllocationInfo) = v34.m_AllocationInfo;
			//   v35.ptr = v34.ptr;
			//   v34 = *cullingResults;
			//   v19 = HG::Rendering::Runtime::HGRendererListUtils::CreateTransparentRendererListDesc(
			//           &v37,
			//           &v34,
			//           camera,
			//           v16,
			//           screenCullingRatio,
			//           screenCullingRatioDistance,
			//           screenCullingLayerMask,
			//           (PerObjectData__Enum)(backedLightingConfig | PerObjectMotionVectorConfig),
			//           (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v35,
			//           &v36,
			//           0LL,
			//           0,
			//           0LL);
			// LABEL_13:
			//   v20 = *(_OWORD *)&v19.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v19.sortingCriteria;
			//   v21 = *(_OWORD *)&v19.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v20;
			//   v22 = *(_OWORD *)&v19.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v21;
			//   v23 = *(_OWORD *)&v19.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v22;
			//   v24 = *(_OWORD *)&v19.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v23;
			//   v25 = *(_OWORD *)&v19.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v24;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v25;
			//   v26 = *(_OWORD *)&v19.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v19.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v26;
			//   v28 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v29 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v28;
			//   v30 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v29;
			//   v31 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v30;
			//   v32 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v31;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v32;
			//   return result;
			// }
			// 
			return null;
		}

		internal static void RenderForwardOpaque(HGRenderGraphContext context, ForwardPassUtils.ForwardOpaquePassData data)
		{
			// // Void RenderForwardOpaque(HGRenderGraphContext, ForwardPassUtils+ForwardOpaquePassData)
			// void HG::Rendering::Runtime::ForwardPassUtils::RenderForwardOpaque(
			//         HGRenderGraphContext *context,
			//         ForwardPassUtils_ForwardOpaquePassData *data,
			//         MethodInfo *method)
			// {
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rdx
			//   CommandBuffer *cmd; // rcx
			//   BitArray128 *camera; // rbx
			//   uint64_t data1; // xmm7_8
			//   BitArray128 v9; // xmm6
			//   uint64_t v10; // xmm1_8
			//   uint32_t characterOpaqueECSRendererList; // ebx
			//   CommandBuffer *v12; // r14
			//   CommandBuffer__Class *klass; // rax
			//   RendererList *v14; // rax
			//   BitArray128 *v15; // r8
			//   HGGraphicsFeatureSwitch *forwardOpaque; // rax
			//   void *m_Ptr; // r9
			//   _BYTE *v18; // rax
			//   CommandBuffer *v19; // r9
			//   uint32_t forwardOpaqueECSRendererList; // edx
			//   MonitorData *monitor; // rax
			//   CommandBuffer *v22; // r9
			//   uint32_t forwardOpaqueEqualECSRendererList; // edx
			//   MonitorData *v24; // rax
			//   CommandBuffer *v25; // r9
			//   uint32_t characterOutlineOpaqueECSRendererList; // edx
			//   CommandBuffer__Class *v27; // rax
			//   CommandBuffer *v28; // r9
			//   uint32_t characterOutlineOpaqueEqualECSRendererList; // edx
			//   RendererList *v30; // rax
			//   void *v31; // rbx
			//   CommandBuffer *v32; // r14
			//   BitArray128 v33; // xmm8
			//   CommandBuffer__Class *v34; // rax
			//   HGCamera *v35; // rax
			//   HGSkyRenderer *s_skyRenderer; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   char useFullScreenDebug; // [rsp+28h] [rbp-39h]
			//   CommandBuffer *useFullScreenDebuga; // [rsp+28h] [rbp-39h]
			//   char useFullScreenDebugb; // [rsp+28h] [rbp-39h]
			//   char useFullScreenDebugc; // [rsp+28h] [rbp-39h]
			//   char useFullScreenDebugd; // [rsp+28h] [rbp-39h]
			//   char useFullScreenDebuge; // [rsp+28h] [rbp-39h]
			//   bool methoda; // [rsp+30h] [rbp-31h]
			//   char methodb; // [rsp+30h] [rbp-31h]
			//   FrameSettings v46; // [rsp+48h] [rbp-19h] BYREF
			//   FrameSettings v47[3]; // [rsp+68h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D919555 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     byte_18D919555 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2623, 0LL) )
			//   {
			//     if ( data )
			//     {
			//       camera = (BitArray128 *)data.fields.camera;
			//       if ( camera )
			//       {
			//         data1 = camera[106].data1;
			//         v9 = camera[105];
			//         if ( context )
			//         {
			//           cmd = context.fields.cmd;
			//           if ( cmd )
			//           {
			//             UnityEngine::Rendering::CommandBuffer::SetProfilingHGPassImpl(cmd, 4, 0LL);
			//             v10 = camera[106].data1;
			//             v46.bitDatas = camera[105];
			//             *(_QWORD *)&v46.materialQuality = v10;
			//             if ( !HG::Rendering::Runtime::FrameSettings::IsEnabled(&v46, FrameSettingsField__Enum_OpaqueObjects, 0LL) )
			//               return;
			//             characterOpaqueECSRendererList = data.fields.characterOpaqueECSRendererList;
			//             v12 = context.fields.cmd;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//             cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//             klass = cmd[8].klass;
			//             if ( klass )
			//             {
			//               useFullScreenDebug = (char)klass._0.name;
			//               v46.bitDatas = v9;
			//               *(_QWORD *)&v46.materialQuality = data1;
			//               HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(
			//                 &v46,
			//                 characterOpaqueECSRendererList,
			//                 1,
			//                 v12,
			//                 useFullScreenDebug,
			//                 0LL);
			//               v14 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(
			//                       (RendererList *)&v46,
			//                       data.fields.opaqueRenderList,
			//                       0LL);
			//               cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//               v15 = (BitArray128 *)v14;
			//               static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//               forwardOpaque = static_fields.forwardOpaque;
			//               if ( forwardOpaque )
			//               {
			//                 methoda = forwardOpaque.fields.m_defaultValue;
			//                 useFullScreenDebuga = context.fields.cmd;
			//                 m_Ptr = context.fields.renderContext.m_Ptr;
			//                 v46.bitDatas = *v15;
			//                 v47[0].bitDatas = v9;
			//                 *(_QWORD *)&v47[0].materialQuality = data1;
			//                 HG::Rendering::Runtime::HGRendererListUtils::RenderForwardRendererList(
			//                   v47,
			//                   (RendererList *)&v46,
			//                   1,
			//                   (ScriptableRenderContext)m_Ptr,
			//                   useFullScreenDebuga,
			//                   methoda,
			//                   0LL);
			//                 cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//                 v18 = cmd[6].fields.m_Ptr;
			//                 if ( v18 )
			//                 {
			//                   v19 = context.fields.cmd;
			//                   forwardOpaqueECSRendererList = data.fields.forwardOpaqueECSRendererList;
			//                   useFullScreenDebugb = v18[16];
			//                   v47[0].bitDatas = v9;
			//                   *(_QWORD *)&v47[0].materialQuality = data1;
			//                   HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(
			//                     v47,
			//                     forwardOpaqueECSRendererList,
			//                     1,
			//                     v19,
			//                     useFullScreenDebugb,
			//                     0LL);
			//                   cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//                   monitor = cmd[7].monitor;
			//                   if ( monitor )
			//                   {
			//                     v22 = context.fields.cmd;
			//                     forwardOpaqueEqualECSRendererList = data.fields.forwardOpaqueEqualECSRendererList;
			//                     useFullScreenDebugc = *((_BYTE *)monitor + 16);
			//                     v47[0].bitDatas = v9;
			//                     *(_QWORD *)&v47[0].materialQuality = data1;
			//                     HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(
			//                       v47,
			//                       forwardOpaqueEqualECSRendererList,
			//                       1,
			//                       v22,
			//                       useFullScreenDebugc,
			//                       0LL);
			//                     cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//                     v24 = cmd[8].monitor;
			//                     if ( v24 )
			//                     {
			//                       v25 = context.fields.cmd;
			//                       characterOutlineOpaqueECSRendererList = data.fields.characterOutlineOpaqueECSRendererList;
			//                       useFullScreenDebugd = *((_BYTE *)v24 + 16);
			//                       v47[0].bitDatas = v9;
			//                       *(_QWORD *)&v47[0].materialQuality = data1;
			//                       HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(
			//                         v47,
			//                         characterOutlineOpaqueECSRendererList,
			//                         1,
			//                         v25,
			//                         useFullScreenDebugd,
			//                         0LL);
			//                       cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//                       v27 = cmd[9].klass;
			//                       if ( v27 )
			//                       {
			//                         v28 = context.fields.cmd;
			//                         characterOutlineOpaqueEqualECSRendererList = data.fields.characterOutlineOpaqueEqualECSRendererList;
			//                         useFullScreenDebuge = (char)v27._0.name;
			//                         v47[0].bitDatas = v9;
			//                         *(_QWORD *)&v47[0].materialQuality = data1;
			//                         HG::Rendering::Runtime::HGRendererListUtils::RenderForwardECSRendererList(
			//                           v47,
			//                           characterOutlineOpaqueEqualECSRendererList,
			//                           1,
			//                           v28,
			//                           useFullScreenDebuge,
			//                           0LL);
			//                         if ( HG::Rendering::RenderGraphModule::RendererListHandle::IsValid(
			//                                &data.fields.characterOutlineOpaqueRenderList,
			//                                0LL) )
			//                         {
			//                           v30 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(
			//                                   (RendererList *)&v46,
			//                                   data.fields.characterOutlineOpaqueRenderList,
			//                                   0LL);
			//                           v31 = context.fields.renderContext.m_Ptr;
			//                           v32 = context.fields.cmd;
			//                           v33 = (BitArray128)*v30;
			//                           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//                           cmd = (CommandBuffer *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//                           v34 = cmd[9].klass;
			//                           if ( !v34 )
			//                             goto LABEL_26;
			//                           methodb = (char)v34._0.name;
			//                           v46.bitDatas = v33;
			//                           v47[0].bitDatas = v9;
			//                           *(_QWORD *)&v47[0].materialQuality = data1;
			//                           HG::Rendering::Runtime::HGRendererListUtils::RenderForwardRendererList(
			//                             v47,
			//                             (RendererList *)&v46,
			//                             1,
			//                             (ScriptableRenderContext)v31,
			//                             v32,
			//                             methodb,
			//                             0LL);
			//                         }
			//                         v35 = data.fields.camera;
			//                         if ( v35 )
			//                         {
			//                           cmd = (CommandBuffer *)v35.fields.camera;
			//                           if ( cmd )
			//                           {
			//                             if ( UnityEngine::Camera::get_clearFlags((Camera *)cmd, 0LL) == CameraClearFlags__Enum_Skybox )
			//                             {
			//                               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//                               s_skyRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_skyRenderer(0LL);
			//                               if ( !s_skyRenderer )
			//                                 goto LABEL_26;
			//                               HG::Rendering::Runtime::HGSkyRenderer::Render(
			//                                 s_skyRenderer,
			//                                 context.fields.cmd,
			//                                 data.fields.camera,
			//                                 context.fields.renderContext,
			//                                 0,
			//                                 0LL);
			//                             }
			//                             cmd = context.fields.cmd;
			//                             if ( cmd )
			//                             {
			//                               UnityEngine::Rendering::CommandBuffer::SetProfilingHGPassImpl(cmd, 0, 0LL);
			//                               return;
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_26:
			//     sub_180B536AC(cmd, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2623, 0LL);
			//   if ( !Patch )
			//     goto LABEL_26;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)context,
			//     (Object *)data,
			//     0LL);
			// }
			// 
		}

		internal static void RenderForwardTransparent(HGRenderGraphContext context, ForwardPassUtils.ForwardTransparentPassData data)
		{
			// // Void RenderForwardTransparent(HGRenderGraphContext, ForwardPassUtils+ForwardTransparentPassData)
			// void HG::Rendering::Runtime::ForwardPassUtils::RenderForwardTransparent(
			//         HGRenderGraphContext *context,
			//         ForwardPassUtils_ForwardTransparentPassData *data,
			//         MethodInfo *method)
			// {
			//   HGShaderIDs__StaticFields *static_fields; // rdx
			//   void *cmd; // rcx
			//   HGCamera *camera; // r14
			//   __int64 v8; // r13
			//   BitArray128 bitDatas; // xmm0
			//   Material *BlitMaterial; // r15
			//   CommandBuffer *v11; // rbx
			//   __m128i si128; // xmm0
			//   __int64 BlitScaleBias; // rdx
			//   CommandBuffer *v14; // rbx
			//   TextureHandle sceneColorToSample; // xmm6
			//   int32_t BlitTexture; // r12d
			//   RenderTargetIdentifier *v17; // rax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   __int128 v20; // xmm1
			//   CommandBuffer *v21; // rbx
			//   CommandBuffer *v22; // rbx
			//   TextureHandle v23; // xmm6
			//   int32_t SceneColorTexture; // r15d
			//   RenderTargetIdentifier *v25; // rax
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   __int128 v28; // xmm1
			//   int32_t v29; // ebx
			//   TextureHandle__Array *gbuffer; // r15
			//   TextureHandle *v31; // rax
			//   CommandBuffer *v32; // r15
			//   __int64 v33; // r9
			//   int32_t v34; // r12d
			//   RenderTargetIdentifier *v35; // rax
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   __int128 v38; // xmm1
			//   CommandBuffer *v39; // rbx
			//   TextureHandle sceneDepthToSample; // xmm6
			//   int32_t CameraDepthTexture; // r15d
			//   RenderTargetIdentifier *v42; // rax
			//   __int64 v43; // rdx
			//   __int64 v44; // rcx
			//   __int128 v45; // xmm1
			//   CommandBuffer *v46; // rbx
			//   TextureHandle sceneDepthWithWater; // xmm6
			//   int32_t DepthTextureWithWater; // r14d
			//   RenderTargetIdentifier *v49; // rax
			//   __int64 v50; // rdx
			//   __int64 v51; // rcx
			//   bool IsValid; // al
			//   HGRenderGraphDefaultResources *defaultResources; // rax
			//   TextureHandle blackTexture_k__BackingField; // xmm6
			//   __int64 v55; // rdx
			//   __int64 v56; // rcx
			//   TextureHandle v57; // xmm6
			//   __int64 v58; // rdx
			//   __int64 v59; // rcx
			//   __int128 v60; // xmm1
			//   HGVFXManager *instance; // rax
			//   HGCamera *v62; // rbx
			//   Vector4 v63; // xmm6
			//   Vector4 v64; // xmm7
			//   CBHandle *ConstantBuffer; // rax
			//   __int64 v66; // rcx
			//   BasicTransformConstants *p_basicTransformConstants; // rax
			//   __int64 v68; // rdx
			//   __m128i v69; // xmm3
			//   unsigned int v70; // xmm2_4
			//   _OWORD *v71; // rcx
			//   float v72; // xmm0_4
			//   float v73; // xmm1_4
			//   Vector4 v74; // xmm0
			//   __int128 v75; // xmm1
			//   __int128 v76; // xmm0
			//   __int128 v77; // xmm1
			//   __int128 v78; // xmm0
			//   __int128 v79; // xmm1
			//   __int128 v80; // xmm0
			//   __int128 v81; // xmm1
			//   __int128 v82; // xmm1
			//   __int128 v83; // xmm0
			//   __int128 v84; // xmm1
			//   __int128 v85; // xmm0
			//   _OWORD *v86; // rax
			//   __int64 v87; // rdx
			//   _OWORD *v88; // rcx
			//   __int128 v89; // xmm1
			//   __int128 v90; // xmm0
			//   __int128 v91; // xmm1
			//   __int128 v92; // xmm0
			//   __int128 v93; // xmm1
			//   __int128 v94; // xmm0
			//   __int128 v95; // xmm1
			//   __int128 v96; // xmm1
			//   __int128 v97; // xmm0
			//   __int128 v98; // xmm1
			//   __int128 v99; // xmm0
			//   CommandBuffer *v100; // rbx
			//   uint32_t forwardDecalECSList; // ebx
			//   __int64 v102; // r8
			//   __int64 v103; // rbx
			//   char v104; // bl
			//   uint32_t forwardTransparentECSList; // ebx
			//   RendererList *v106; // rax
			//   HGGraphicsFeatureSwitch *forwardTransparent; // r9
			//   bool m_defaultValue; // r9
			//   CBHandle *v109; // rax
			//   _OWORD *v110; // rcx
			//   __int64 v111; // rdx
			//   __int128 v112; // xmm0
			//   void *ptr; // xmm1_8
			//   BasicTransformConstants *v114; // rax
			//   __int128 v115; // xmm1
			//   __int128 v116; // xmm0
			//   __int128 v117; // xmm1
			//   __int128 v118; // xmm0
			//   __int128 v119; // xmm1
			//   __int128 v120; // xmm0
			//   __int128 v121; // xmm1
			//   __int128 v122; // xmm1
			//   __int128 v123; // xmm0
			//   __int128 v124; // xmm1
			//   __int128 v125; // xmm0
			//   _OWORD *v126; // rax
			//   _OWORD *v127; // rcx
			//   __int128 v128; // xmm1
			//   __int128 v129; // xmm0
			//   __int128 v130; // xmm1
			//   __int128 v131; // xmm0
			//   __int128 v132; // xmm1
			//   __int128 v133; // xmm0
			//   __int128 v134; // xmm1
			//   __int128 v135; // xmm1
			//   __int128 v136; // xmm0
			//   __int128 v137; // xmm1
			//   __int128 v138; // xmm0
			//   CommandBuffer *v139; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   FrameSettings v141; // [rsp+28h] [rbp-D8h] BYREF
			//   __int128 v142; // [rsp+40h] [rbp-C0h]
			//   __int64 v143; // [rsp+50h] [rbp-B0h]
			//   Vector4 v144; // [rsp+60h] [rbp-A0h]
			//   RenderTargetIdentifier value_8; // [rsp+70h] [rbp-90h] BYREF
			//   RenderTargetIdentifier v146; // [rsp+A0h] [rbp-60h] BYREF
			//   _BYTE v147[720]; // [rsp+D0h] [rbp-30h] BYREF
			//   _BYTE v148[3784]; // [rsp+3A0h] [rbp+2A0h] BYREF
			//   int v149; // [rsp+12D8h] [rbp+11D8h]
			// 
			//   if ( !byte_18D919556 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::BasicTransformConstants>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGUtils::SetCBData<UnityEngine::HyperGryphEngineCode::ShaderVariablesGlobal>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     byte_18D919556 = 1;
			//   }
			//   v144 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2628, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2628, 0LL);
			//     if ( !Patch )
			//       goto LABEL_82;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)context,
			//       (Object *)data,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !data )
			//       goto LABEL_82;
			//     camera = data.fields.camera;
			//     if ( !camera )
			//       goto LABEL_82;
			//     if ( !context )
			//       goto LABEL_82;
			//     cmd = context.fields.cmd;
			//     if ( !cmd )
			//       goto LABEL_82;
			//     v8 = 5LL;
			//     UnityEngine::Rendering::CommandBuffer::SetProfilingHGPassImpl((CommandBuffer *)cmd, 5, 0LL);
			//     bitDatas = camera.fields._frameSettings_k__BackingField.bitDatas;
			//     *(_QWORD *)&v142 = *(_QWORD *)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//     *(BitArray128 *)&v141.bitDatas.data2 = bitDatas;
			//     if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//            (FrameSettings *)&v141.bitDatas.data2,
			//            FrameSettingsField__Enum_OpaqueObjects,
			//            0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&data.fields.sceneColorToSample, 0LL) )
			//       {
			//         if ( !data.fields.lowResRendering )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//           BlitMaterial = HG::Rendering::Runtime::HGUtils::GetBlitMaterial(0, TextureDimension__Enum_Tex2D, 0, 0LL);
			//           v11 = context.fields.cmd;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           si128 = _mm_load_si128((const __m128i *)&xmmword_18A357570);
			//           BlitScaleBias = (unsigned int)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._BlitScaleBias;
			//           if ( !v11 )
			//             sub_180B536AC(TypeInfo::HG::Rendering::Runtime::HGShaderIDs, BlitScaleBias);
			//           *(__m128i *)&value_8.m_Type = si128;
			//           UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(v11, BlitScaleBias, (Vector4 *)&value_8, 0LL);
			//           v14 = context.fields.cmd;
			//           sceneColorToSample = data.fields.sceneColorToSample;
			//           BlitTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._BlitTexture;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           *(TextureHandle *)&v141.bitDatas.data2 = sceneColorToSample;
			//           v17 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
			//                   &v146,
			//                   (TextureHandle *)&v141.bitDatas.data2,
			//                   0LL);
			//           if ( !v14 )
			//             sub_180B536AC(v19, v18);
			//           v20 = *(_OWORD *)&v17.m_BufferPointer;
			//           *(_OWORD *)&v141.bitDatas.data2 = *(_OWORD *)&v17.m_Type;
			//           v143 = *(_QWORD *)&v17.m_DepthSlice;
			//           v142 = v20;
			//           UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
			//             v14,
			//             BlitTexture,
			//             (RenderTargetIdentifier *)&v141.bitDatas.data2,
			//             0LL);
			//           v21 = context.fields.cmd;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//           UnityEngine::Rendering::CoreUtils::DrawFullScreen(v21, BlitMaterial, 0LL, 0, 0LL);
			//         }
			//         v22 = context.fields.cmd;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         v23 = data.fields.sceneColorToSample;
			//         SceneColorTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._SceneColorTexture;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         *(TextureHandle *)&v141.bitDatas.data2 = v23;
			//         v25 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
			//                 &v146,
			//                 (TextureHandle *)&v141.bitDatas.data2,
			//                 0LL);
			//         if ( !v22 )
			//           sub_180B536AC(v27, v26);
			//         v28 = *(_OWORD *)&v25.m_BufferPointer;
			//         *(_OWORD *)&v141.bitDatas.data2 = *(_OWORD *)&v25.m_Type;
			//         v143 = *(_QWORD *)&v25.m_DepthSlice;
			//         v142 = v28;
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
			//           v22,
			//           SceneColorTexture,
			//           (RenderTargetIdentifier *)&v141.bitDatas.data2,
			//           0LL);
			//       }
			//       if ( !data.fields.gBufferProfileConfig )
			//       {
			//         v29 = 0;
			//         while ( 1 )
			//         {
			//           gbuffer = data.fields.gbuffer;
			//           if ( !gbuffer )
			//             break;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           v31 = (TextureHandle *)sub_18037A2E0(gbuffer, v29);
			//           if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(v31, 0LL) )
			//           {
			//             v32 = context.fields.cmd;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             cmd = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             static_fields = (HGShaderIDs__StaticFields *)*((_QWORD *)cmd + 68);
			//             if ( !static_fields )
			//               break;
			//             if ( (unsigned int)v29 >= static_fields._Input0 )
			//               sub_180070270(cmd, static_fields);
			//             cmd = data.fields.gbuffer;
			//             v34 = *(&static_fields._Input2 + v29);
			//             if ( !cmd )
			//               break;
			//             sub_18037A36C(cmd, &v141.bitDatas.data2, v29, v33);
			//             sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//             *(_OWORD *)&value_8.m_Type = *(_OWORD *)&v141.bitDatas.data2;
			//             v35 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v146, (TextureHandle *)&value_8, 0LL);
			//             if ( !v32 )
			//               sub_180B536AC(v37, v36);
			//             v38 = *(_OWORD *)&v35.m_BufferPointer;
			//             *(_OWORD *)&value_8.m_Type = *(_OWORD *)&v35.m_Type;
			//             *(_QWORD *)&value_8.m_DepthSlice = *(_QWORD *)&v35.m_DepthSlice;
			//             *(_OWORD *)&value_8.m_BufferPointer = v38;
			//             UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(v32, v34, &value_8, 0LL);
			//           }
			//           if ( ++v29 >= 4 )
			//             goto LABEL_29;
			//         }
			// LABEL_82:
			//         sub_180B536AC(cmd, static_fields);
			//       }
			// LABEL_29:
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&data.fields.sceneDepthToSample, 0LL) )
			//       {
			//         v39 = context.fields.cmd;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         sceneDepthToSample = data.fields.sceneDepthToSample;
			//         CameraDepthTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CameraDepthTexture;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         *(TextureHandle *)&v141.bitDatas.data2 = sceneDepthToSample;
			//         v42 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
			//                 &v146,
			//                 (TextureHandle *)&v141.bitDatas.data2,
			//                 0LL);
			//         if ( !v39 )
			//           sub_180B536AC(v44, v43);
			//         v45 = *(_OWORD *)&v42.m_BufferPointer;
			//         *(_OWORD *)&v141.bitDatas.data2 = *(_OWORD *)&v42.m_Type;
			//         v143 = *(_QWORD *)&v42.m_DepthSlice;
			//         v142 = v45;
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
			//           v39,
			//           CameraDepthTexture,
			//           (RenderTargetIdentifier *)&v141.bitDatas.data2,
			//           0LL);
			//       }
			//       if ( HG::Rendering::Runtime::HGCamera::ShouldRenderWater(camera, 0LL)
			//         && (sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle),
			//             HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&data.fields.sceneDepthWithWater, 0LL)) )
			//       {
			//         v46 = context.fields.cmd;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         sceneDepthWithWater = data.fields.sceneDepthWithWater;
			//         DepthTextureWithWater = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DepthTextureWithWater;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         *(TextureHandle *)&v141.bitDatas.data2 = sceneDepthWithWater;
			//         v49 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
			//                 &v146,
			//                 (TextureHandle *)&v141.bitDatas.data2,
			//                 0LL);
			//         if ( !v46 )
			//           sub_180B536AC(v51, v50);
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         IsValid = HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&data.fields.sceneDepthToSample, 0LL);
			//         v46 = context.fields.cmd;
			//         if ( IsValid )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           v57 = data.fields.sceneDepthToSample;
			//           DepthTextureWithWater = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._DepthTextureWithWater;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           *(TextureHandle *)&v141.bitDatas.data2 = v57;
			//           v49 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
			//                   &v146,
			//                   (TextureHandle *)&v141.bitDatas.data2,
			//                   0LL);
			//           if ( !v46 )
			//             sub_180B536AC(v59, v58);
			//         }
			//         else
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           cmd = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//           defaultResources = context.fields.defaultResources;
			//           DepthTextureWithWater = *((_DWORD *)cmd + 123);
			//           if ( !defaultResources )
			//             goto LABEL_82;
			//           blackTexture_k__BackingField = defaultResources.fields._blackTexture_k__BackingField;
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           *(TextureHandle *)&v141.bitDatas.data2 = blackTexture_k__BackingField;
			//           v49 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
			//                   &v146,
			//                   (TextureHandle *)&v141.bitDatas.data2,
			//                   0LL);
			//           if ( !v46 )
			//             sub_180B536AC(v56, v55);
			//         }
			//       }
			//       v60 = *(_OWORD *)&v49.m_BufferPointer;
			//       *(_OWORD *)&v141.bitDatas.data2 = *(_OWORD *)&v49.m_Type;
			//       v143 = *(_QWORD *)&v49.m_DepthSlice;
			//       v142 = v60;
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(
			//         v46,
			//         DepthTextureWithWater,
			//         (RenderTargetIdentifier *)&v141.bitDatas.data2,
			//         0LL);
			//       if ( !data.fields.lowResRendering )
			//       {
			//         instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
			//         if ( instance )
			//           HG::Rendering::Runtime::HGVFXManager::DrawVFXSceneColorAdjustmentMaterial(instance, context.fields.cmd, 0LL);
			//       }
			//       if ( data.fields.waterRenderingPass )
			//         HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::RenderLighting(
			//           data.fields.waterRenderingPass,
			//           context,
			//           data.fields.camera,
			//           0LL);
			//       if ( !data.fields.lowResRendering )
			//       {
			//         v62 = data.fields.camera;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//         HG::Rendering::Runtime::VFXPPScanLinePass::DrawScanLineMaterial(context, v62, 0LL);
			//       }
			//       v63 = (Vector4)_mm_loadu_si128((const __m128i *)&data.fields.shaderVariablesGlobal._ScreenSize);
			//       v64 = (Vector4)_mm_loadu_si128((const __m128i *)&data.fields.shaderVariablesGlobal._ScreenParams);
			//       if ( data.fields.lowResRendering )
			//       {
			//         cmd = context.fields.cmd;
			//         if ( !cmd )
			//           goto LABEL_82;
			//         UnityEngine::Rendering::CommandBuffer::HGSetTransparentOffscreenBlend((CommandBuffer *)cmd, 1, 0LL);
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                            (CBHandle *)&value_8,
			//                            &context.fields.renderContext,
			//                            4512,
			//                            0LL);
			//         cmd = data.fields.camera;
			//         *(_QWORD *)&v142 = ConstantBuffer.ptr;
			//         *(_OWORD *)&v141.bitDatas.data2 = *(_OWORD *)&ConstantBuffer.bufferId;
			//         if ( !cmd )
			//           goto LABEL_82;
			//         v66 = *((_QWORD *)cmd + 6);
			//         v149 = (int)v66 / 2;
			//         p_basicTransformConstants = &data.fields.basicTransformConstants;
			//         v68 = 5LL;
			//         v69 = _mm_cvtsi32_si128(SHIDWORD(v66) / 2);
			//         *(float *)&v70 = 1.0 / (float)((int)v66 / 2);
			//         v71 = v147;
			//         v72 = _mm_cvtepi32_ps(v69).m128_f32[0];
			//         *(float *)v69.m128i_i32 = v72;
			//         v144.w = 1.0 / v72;
			//         v73 = (float)(1.0 / v72) + 1.0;
			//         *(_QWORD *)&v144.y = __PAIR64__(v70, LODWORD(v72));
			//         v144.x = (float)v149;
			//         v74 = v144;
			//         v144.w = v73;
			//         data.fields.shaderVariablesGlobal._ScreenSize = v74;
			//         v144.x = (float)v149;
			//         LODWORD(v144.y) = v69.m128i_i32[0];
			//         v144.z = *(float *)&v70 + 1.0;
			//         data.fields.shaderVariablesGlobal._ScreenParams = v144;
			//         do
			//         {
			//           v75 = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m01;
			//           *v71 = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m00;
			//           v76 = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m02;
			//           v71[1] = v75;
			//           v77 = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m03;
			//           v71[2] = v76;
			//           v78 = *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m00;
			//           v71[3] = v77;
			//           v79 = *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m01;
			//           v71[4] = v78;
			//           v80 = *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m02;
			//           v71[5] = v79;
			//           v81 = *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m03;
			//           p_basicTransformConstants = (BasicTransformConstants *)((char *)p_basicTransformConstants + 128);
			//           v71[6] = v80;
			//           v71 += 8;
			//           *(v71 - 1) = v81;
			//           --v68;
			//         }
			//         while ( v68 );
			//         v82 = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m01;
			//         *v71 = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m00;
			//         v83 = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m02;
			//         v71[1] = v82;
			//         v84 = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m03;
			//         v71[2] = v83;
			//         v85 = *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m00;
			//         v71[3] = v84;
			//         v71[4] = v85;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         v86 = v148;
			//         v87 = 5LL;
			//         v88 = v147;
			//         do
			//         {
			//           v89 = v88[1];
			//           *v86 = *v88;
			//           v90 = v88[2];
			//           v86[1] = v89;
			//           v91 = v88[3];
			//           v86[2] = v90;
			//           v92 = v88[4];
			//           v86[3] = v91;
			//           v93 = v88[5];
			//           v86[4] = v92;
			//           v94 = v88[6];
			//           v86[5] = v93;
			//           v95 = v88[7];
			//           v88 += 8;
			//           v86[6] = v94;
			//           v86 += 8;
			//           *(v86 - 1) = v95;
			//           --v87;
			//         }
			//         while ( v87 );
			//         v96 = v88[1];
			//         *v86 = *v88;
			//         v97 = v88[2];
			//         v86[1] = v96;
			//         v98 = v88[3];
			//         v86[2] = v97;
			//         v99 = v88[4];
			//         v86[3] = v98;
			//         v86[4] = v99;
			//         sub_1808307F0(&v141.bitDatas.data2, v148);
			//         sub_1802EFB40(v148, &data.fields.shaderVariablesGlobal, 3792LL);
			//         sub_180830890(&v141.bitDatas.data2, v148);
			//         v100 = context.fields.cmd;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         if ( !v100 )
			//           goto LABEL_82;
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//           v100,
			//           v141.bitDatas.data2,
			//           static_fields._ShaderVariablesGlobal,
			//           SHIDWORD(v141.bitDatas.data2),
			//           4512,
			//           0LL);
			//       }
			//       else if ( data.fields.transparentVRS )
			//       {
			//         cmd = context.fields.cmd;
			//         if ( !cmd )
			//           goto LABEL_82;
			//         UnityEngine::Rendering::CommandBuffer::HGSetFragmentShadingRate(
			//           (CommandBuffer *)cmd,
			//           data.fields.transparentVRRx,
			//           data.fields.transparentVRRy,
			//           0LL);
			//       }
			//       forwardDecalECSList = data.fields.forwardDecalECSList;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//       cmd = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//       v102 = *((_QWORD *)cmd + 23);
			//       if ( !v102 )
			//         goto LABEL_82;
			//       HG::Rendering::Runtime::HGRendererListUtils::DrawDecalECSRendererList(
			//         context,
			//         forwardDecalECSList,
			//         *(_BYTE *)(v102 + 16),
			//         0LL);
			//       cmd = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//       v103 = *((_QWORD *)cmd + 28);
			//       if ( !v103 )
			//         goto LABEL_82;
			//       v104 = *(_BYTE *)(v103 + 16);
			//       *(RendererList *)&v141.bitDatas.data2 = *HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(
			//                                                  (RendererList *)&v141.bitDatas.data2,
			//                                                  data.fields.vfxDecalRenderList,
			//                                                  0LL);
			//       HG::Rendering::Runtime::HGRendererListUtils::DrawRendererList(
			//         context,
			//         (RendererList *)&v141.bitDatas.data2,
			//         v104,
			//         0LL);
			//       HG::Rendering::Runtime::HGRendererListUtils::DrawECSRendererList(context, data.fields.vfxDecalECSList, v104, 0LL);
			//       forwardTransparentECSList = data.fields.forwardTransparentECSList;
			//       v106 = HG::Rendering::RenderGraphModule::RendererListHandle::op_Implicit(
			//                (RendererList *)&v141.bitDatas.data2,
			//                data.fields.transparentRenderList,
			//                0LL);
			//       cmd = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//       forwardTransparent = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.forwardTransparent;
			//       if ( !forwardTransparent )
			//         goto LABEL_82;
			//       m_defaultValue = forwardTransparent.fields.m_defaultValue;
			//       *(RendererList *)&v141.bitDatas.data2 = *v106;
			//       HG::Rendering::Runtime::HGRendererListUtils::DrawECSMeshRendererListWithSRPRendererList(
			//         context,
			//         forwardTransparentECSList,
			//         (RendererList *)&v141.bitDatas.data2,
			//         m_defaultValue,
			//         0LL);
			//       cmd = context.fields.cmd;
			//       if ( !cmd )
			//         goto LABEL_82;
			//       UnityEngine::Rendering::CommandBuffer::HGDrawUIRendererListImpl(
			//         (CommandBuffer *)cmd,
			//         data.fields.hgUIRendererList,
			//         0LL);
			//       if ( data.fields.lowResRendering )
			//       {
			//         cmd = context.fields.cmd;
			//         if ( !cmd )
			//           goto LABEL_82;
			//         UnityEngine::Rendering::CommandBuffer::HGSetTransparentOffscreenBlend((CommandBuffer *)cmd, 0, 0LL);
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         v109 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                  (CBHandle *)&value_8,
			//                  &context.fields.renderContext,
			//                  4512,
			//                  0LL);
			//         v110 = v148;
			//         v111 = 5LL;
			//         v112 = *(_OWORD *)&v109.bufferId;
			//         ptr = v109.ptr;
			//         v114 = &data.fields.basicTransformConstants;
			//         data.fields.shaderVariablesGlobal._ScreenSize = v63;
			//         *(_OWORD *)&v141.bitDatas.data2 = v112;
			//         *(_QWORD *)&v142 = ptr;
			//         data.fields.shaderVariablesGlobal._ScreenParams = v64;
			//         do
			//         {
			//           v115 = *(_OWORD *)&v114._ViewMatrix.m01;
			//           *v110 = *(_OWORD *)&v114._ViewMatrix.m00;
			//           v116 = *(_OWORD *)&v114._ViewMatrix.m02;
			//           v110[1] = v115;
			//           v117 = *(_OWORD *)&v114._ViewMatrix.m03;
			//           v110[2] = v116;
			//           v118 = *(_OWORD *)&v114._InvViewMatrix.m00;
			//           v110[3] = v117;
			//           v119 = *(_OWORD *)&v114._InvViewMatrix.m01;
			//           v110[4] = v118;
			//           v120 = *(_OWORD *)&v114._InvViewMatrix.m02;
			//           v110[5] = v119;
			//           v121 = *(_OWORD *)&v114._InvViewMatrix.m03;
			//           v114 = (BasicTransformConstants *)((char *)v114 + 128);
			//           v110[6] = v120;
			//           v110 += 8;
			//           *(v110 - 1) = v121;
			//           --v111;
			//         }
			//         while ( v111 );
			//         v122 = *(_OWORD *)&v114._ViewMatrix.m01;
			//         *v110 = *(_OWORD *)&v114._ViewMatrix.m00;
			//         v123 = *(_OWORD *)&v114._ViewMatrix.m02;
			//         v110[1] = v122;
			//         v124 = *(_OWORD *)&v114._ViewMatrix.m03;
			//         v110[2] = v123;
			//         v125 = *(_OWORD *)&v114._InvViewMatrix.m00;
			//         v110[3] = v124;
			//         v110[4] = v125;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         v126 = v147;
			//         v127 = v148;
			//         do
			//         {
			//           v128 = v127[1];
			//           *v126 = *v127;
			//           v129 = v127[2];
			//           v126[1] = v128;
			//           v130 = v127[3];
			//           v126[2] = v129;
			//           v131 = v127[4];
			//           v126[3] = v130;
			//           v132 = v127[5];
			//           v126[4] = v131;
			//           v133 = v127[6];
			//           v126[5] = v132;
			//           v134 = v127[7];
			//           v127 += 8;
			//           v126[6] = v133;
			//           v126 += 8;
			//           *(v126 - 1) = v134;
			//           --v8;
			//         }
			//         while ( v8 );
			//         v135 = v127[1];
			//         *v126 = *v127;
			//         v136 = v127[2];
			//         v126[1] = v135;
			//         v137 = v127[3];
			//         v126[2] = v136;
			//         v138 = v127[4];
			//         v126[3] = v137;
			//         v126[4] = v138;
			//         sub_1808307F0(&v141.bitDatas.data2, v147);
			//         sub_1802EFB40(v148, &data.fields.shaderVariablesGlobal, 3792LL);
			//         sub_180830890(&v141.bitDatas.data2, v148);
			//         v139 = context.fields.cmd;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         if ( !v139 )
			//           goto LABEL_82;
			//         UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//           v139,
			//           v141.bitDatas.data2,
			//           static_fields._ShaderVariablesGlobal,
			//           SHIDWORD(v141.bitDatas.data2),
			//           4512,
			//           0LL);
			//       }
			//       else if ( data.fields.transparentVRS )
			//       {
			//         cmd = context.fields.cmd;
			//         if ( !cmd )
			//           goto LABEL_82;
			//         UnityEngine::Rendering::CommandBuffer::HGSetFragmentShadingRate((CommandBuffer *)cmd, 1u, 1u, 0LL);
			//       }
			//       cmd = context.fields.cmd;
			//       if ( !cmd )
			//         goto LABEL_82;
			//       UnityEngine::Rendering::CommandBuffer::SetProfilingHGPassImpl((CommandBuffer *)cmd, 0, 0LL);
			//     }
			//   }
			// }
			// 
		}

		internal static void PerformForwardRendering(ForwardPassUtils.ForwardPassData data, HGRenderGraphContext context)
		{
			// // Void PerformForwardRendering(ForwardPassUtils+ForwardPassData, HGRenderGraphContext)
			// void HG::Rendering::Runtime::ForwardPassUtils::PerformForwardRendering(
			//         ForwardPassUtils_ForwardPassData *data,
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ForwardPassUtils_ForwardOpaquePassData *opaqueData; // rax
			//   HGCamera *camera; // rsi
			//   HGSkyRenderer *s_skyRenderer; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919557 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D919557 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2634, 0LL) )
			//   {
			//     if ( data )
			//     {
			//       opaqueData = data.fields.opaqueData;
			//       if ( opaqueData )
			//       {
			//         camera = opaqueData.fields.camera;
			//         HG::Rendering::Runtime::ForwardPassUtils::RenderForwardOpaque(context, data.fields.opaqueData, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//         s_skyRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_skyRenderer(0LL);
			//         if ( context )
			//         {
			//           if ( s_skyRenderer )
			//           {
			//             HG::Rendering::Runtime::HGSkyRenderer::Render(
			//               s_skyRenderer,
			//               context.fields.cmd,
			//               camera,
			//               context.fields.renderContext,
			//               0,
			//               0LL);
			//             HG::Rendering::Runtime::ForwardPassUtils::RenderForwardTransparent(
			//               context,
			//               data.fields.transparentData,
			//               0LL);
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2634, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)data,
			//     (Object *)context,
			//     0LL);
			// }
			// 
		}

		internal class ForwardOpaquePassData
		{
			public ForwardOpaquePassData()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			internal HGCamera camera;

			internal RendererListHandle opaqueRenderList;

			internal RendererListHandle characterOutlineOpaqueRenderList;

			internal uint forwardOpaqueECSRendererList;

			internal uint forwardOpaqueEqualECSRendererList;

			internal uint characterOpaqueECSRendererList;

			internal uint characterOutlineOpaqueECSRendererList;

			internal uint characterOutlineOpaqueEqualECSRendererList;
		}

		internal class ForwardTransparentPassData
		{
			public ForwardTransparentPassData()
			{
				// // ForwardPassUtils+ForwardTransparentPassData()
				// void HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentPassData::ForwardTransparentPassData(
				//         ForwardPassUtils_ForwardTransparentPassData *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // r8
				//   __int64 v4; // r9
				//   OneofDescriptorProto *v5; // rdx
				//   FileDescriptor *v6; // r8
				//   MessageDescriptor *v7; // r9
				//   String__Array *v8; // [rsp+50h] [rbp+28h]
				//   String *v9; // [rsp+58h] [rbp+30h]
				//   MethodInfo *v10; // [rsp+60h] [rbp+38h]
				// 
				//   if ( !byte_18D919558 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//     byte_18D919558 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//   this.fields.gbuffer = (TextureHandle__Array *)il2cpp_array_new_specific_0(
				//                                                    TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle,
				//                                                    TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.kMaxMRTCount,
				//                                                    v3,
				//                                                    v4);
				//   sub_1800054D0((OneofDescriptor *)&this.fields.gbuffer, v5, v6, v7, v8, v9, v10);
				// }
				// 
			}

			internal HGCamera camera;

			internal TextureHandle sceneColorToSample;

			internal TextureHandle sceneDepthToSample;

			internal TextureHandle sceneDepthWithWater;

			internal GBufferProfileManager.GBufferProfileConfig gBufferProfileConfig;

			internal TextureHandle[] gbuffer;

			internal TextureHandle depthPyramidTexture;

			internal RendererListHandle transparentRenderList;

			internal RendererListHandle vfxDecalRenderList;

			internal uint forwardTransparentECSList;

			internal uint forwardDecalECSList;

			internal uint vfxDecalECSList;

			internal uint hgUIRendererList;

			internal uint forwardTransparentAfterUIECSList;

			internal WaterOnePassDeferredRenderingPass waterRenderingPass;

			internal bool transparentVRS;

			internal int transparentVRRx;

			internal int transparentVRRy;

			internal bool lowResRendering;

			internal BasicTransformConstants basicTransformConstants;

			internal ShaderVariablesGlobal shaderVariablesGlobal;
		}

		internal class ForwardTransparentAfterDOFPassData
		{
			public ForwardTransparentAfterDOFPassData()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			internal uint forwardTransparentAfterDOFECSList;

			internal HGCamera camera;

			internal TextureHandle sceneColorToSample;

			internal RendererListHandle transparentRenderList;
		}

		internal class ForwardPassData
		{
			public ForwardPassData()
			{
			}

			internal ForwardPassUtils.ForwardOpaquePassData opaqueData;

			internal ForwardPassUtils.ForwardTransparentPassData transparentData;
		}
	}
}
