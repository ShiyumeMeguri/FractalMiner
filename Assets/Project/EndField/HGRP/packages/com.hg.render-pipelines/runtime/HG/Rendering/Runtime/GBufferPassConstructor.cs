using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class GBufferPassConstructor : IPassConstructor
	{
		public GBufferPassConstructor()
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

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::GBufferPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         GBufferPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2657, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2657, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_340(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::GBufferPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         GBufferPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2658, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2658, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref GBufferPassConstructor.PassInput input, ref GBufferPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(GBufferPassConstructor+PassInput ByRef, GBufferPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::GBufferPassConstructor::ConstructPass(
			//         GBufferPassConstructor *this,
			//         GBufferPassConstructor_PassInput *input,
			//         GBufferPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   int v13; // edi
			//   int32_t i; // ebx
			//   int32_t v15; // r9d
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rax
			//   HGGraphicsFeatureSwitch *characterPrePass; // rdx
			//   bool m_defaultValue; // di
			//   HGGraphicsFeatureSwitch *deferredOpaque; // rcx
			//   bool v20; // bl
			//   Object__Class *v21; // xmm1_8
			//   Object *v22; // rax
			//   PerObjectData__Enum v23; // r13d
			//   TextureHandle cullingResults; // xmm8
			//   Camera *v25; // r12
			//   HGShaderPassNames__StaticFields *v26; // rbx
			//   float screenCullingRatio; // xmm7_4
			//   float screenCullingRatioDistance; // xmm6_4
			//   uint32_t screenCullingLayerMask; // edi
			//   RendererListDesc *v30; // rax
			//   ResourceHandle InvalidHandle; // rax
			//   RendererListHandle *v32; // rbx
			//   RendererListHandle v33; // rax
			//   RendererListHandle v34; // rdx
			//   RendererListHandle v35; // rcx
			//   CullingResults v36; // xmm8
			//   HGShaderPassNames__StaticFields *v37; // rbx
			//   float v38; // xmm7_4
			//   float v39; // xmm6_4
			//   uint32_t v40; // edi
			//   RendererListDesc *v41; // rax
			//   ResourceHandle v42; // rax
			//   RendererListHandle *v43; // rbx
			//   RendererListHandle v44; // rax
			//   RendererListHandle v45; // rdx
			//   RendererListHandle v46; // rcx
			//   __int64 vtFeedbackViewId; // rcx
			//   __int64 terrainCullViewHandle; // rcx
			//   __int64 editorTerrainCullViewHandle; // rcx
			//   __int64 subdivisionHandle; // rcx
			//   __int64 deferredOpaqueECSList; // rcx
			//   __int64 deferredOpaqueEqualECSList; // rcx
			//   __int64 deferredGrassECSList; // rcx
			//   __int64 deferredSludgeECSList; // rcx
			//   __int64 characterPrePassECSList; // rcx
			//   __int64 characterOutlinePrePassECSList; // rcx
			//   __int64 deferredOpaqueGPUDrivenList; // rcx
			//   __int64 deferredOpaqueEqualGPUDrivenList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v60; // rdx
			//   __int64 v61; // rcx
			//   Object *v62; // [rsp+70h] [rbp-308h] BYREF
			//   bool v63; // [rsp+78h] [rbp-300h]
			//   TextureHandle si128; // [rsp+80h] [rbp-2F8h] BYREF
			//   TextureHandle inputa; // [rsp+90h] [rbp-2E8h] BYREF
			//   CullingResults v66; // [rsp+A0h] [rbp-2D8h] BYREF
			//   HGRenderGraphBuilder v67; // [rsp+B0h] [rbp-2C8h] BYREF
			//   HGRenderGraphBuilder v68; // [rsp+D0h] [rbp-2A8h] BYREF
			//   Il2CppExceptionWrapper *v69; // [rsp+F0h] [rbp-288h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v70; // [rsp+100h] [rbp-278h] BYREF
			//   RendererListDesc desc; // [rsp+170h] [rbp-208h] BYREF
			//   RendererListDesc v72; // [rsp+250h] [rbp-128h] BYREF
			// 
			//   if ( !byte_18D919563 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GBufferPassConstructor::GBufferPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GBufferPassConstructor::GBufferPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18C959DD0);
			//     byte_18D919563 = 1;
			//   }
			//   v62 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2659, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2659, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v61, v60);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_974(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x16u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v68,
			//       renderGraph,
			//       (String *)"GBuffer",
			//       &v62,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_GBuffer,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GBufferPassConstructor::GBufferPassData>);
			//     v67 = v68;
			//     v68.m_RenderPass = 0LL;
			//     v68.m_Resources = (HGRenderGraphResourceRegistry *)&v67;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowRendererListCulling(&v67, 0, 0LL);
			//       v13 = 1;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         &si128,
			//         &v67,
			//         &input.sceneColor,
			//         0,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneMV, 0LL) )
			//       {
			//         v13 = 2;
			//         si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18C1755F0);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v66,
			//           &v67,
			//           &input.sceneMV,
			//           1,
			//           (Color *)&si128,
			//           0,
			//           0LL);
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         &si128,
			//         &v67,
			//         &input.sceneDepth,
			//         DepthAccess__Enum_Write,
			//         0,
			//         0LL);
			//       for ( i = 0; i < 4; ++i )
			//       {
			//         si128 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                    (TextureHandle *)&v66,
			//                    &input.gBufferOutput,
			//                    i,
			//                    0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&si128, 0LL) )
			//         {
			//           v15 = v13++;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(&inputa, &v67, &si128, v15, 0, 0LL);
			//         }
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//       characterPrePass = static_fields.characterPrePass;
			//       if ( !characterPrePass )
			//         sub_1802DC2C8(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager, 0LL);
			//       m_defaultValue = characterPrePass.fields.m_defaultValue;
			//       v63 = m_defaultValue;
			//       deferredOpaque = static_fields.deferredOpaque;
			//       if ( !deferredOpaque )
			//         sub_1802DC2C8(0LL, characterPrePass);
			//       v20 = deferredOpaque.fields.m_defaultValue;
			//       if ( !camera )
			//         sub_1802DC2C8(deferredOpaque, characterPrePass);
			//       v21 = *(Object__Class **)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//       v22 = v62;
			//       if ( !v62 )
			//         sub_1802DC2C8(deferredOpaque, characterPrePass);
			//       v62[2] = (Object)camera.fields._frameSettings_k__BackingField.bitDatas;
			//       v22[3].klass = v21;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//       v23 = input.bakedLightConfig | HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
			//       if ( v20 )
			//       {
			//         cullingResults = (TextureHandle)input.cullingResults;
			//         v25 = camera.fields.camera;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//         v26 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields;
			//         screenCullingRatio = input.screenCullingRatio;
			//         screenCullingRatioDistance = input.screenCullingRatioDistance;
			//         screenCullingLayerMask = input.screenCullingLayerMask;
			//         v66.ptr = 0LL;
			//         sub_1802F01E0(&v70, 0LL, 112LL);
			//         inputa.handle = (ResourceHandle)v66.ptr;
			//         inputa.fallBackResource.m_Value = (uint32_t)v66.ptr;
			//         si128 = cullingResults;
			//         v30 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//                 &v72,
			//                 (CullingResults *)&si128,
			//                 v25,
			//                 v26.s_GBufferName,
			//                 screenCullingRatio,
			//                 screenCullingRatioDistance,
			//                 screenCullingLayerMask,
			//                 v23,
			//                 (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&inputa,
			//                 &v70,
			//                 0LL,
			//                 0,
			//                 0LL,
			//                 0LL);
			//         *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v30.sortingCriteria;
			//         desc.stateBlock = v30.stateBlock;
			//         v30 = (RendererListDesc *)((char *)v30 + 128);
			//         *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v30.sortingCriteria;
			//         *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v30.stateBlock.hasValue;
			//         *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v30.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v30.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v30.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v30.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//         InvalidHandle = (ResourceHandle)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
			//                                           renderGraph,
			//                                           &desc,
			//                                           0LL);
			//         m_defaultValue = v63;
			//       }
			//       else
			//       {
			//         InvalidHandle = (ResourceHandle)HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//       }
			//       inputa.handle = InvalidHandle;
			//       v32 = (RendererListHandle *)v62;
			//       v33 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//               &v67,
			//               (RendererListHandle *)&inputa,
			//               0LL);
			//       if ( !v32 )
			//         sub_1802DC2C8(v35, v34);
			//       v32[7] = v33;
			//       if ( m_defaultValue )
			//       {
			//         v36 = input.cullingResults;
			//         inputa.handle = (ResourceHandle)camera.fields.camera;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//         v37 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields;
			//         v38 = input.screenCullingRatio;
			//         v39 = input.screenCullingRatioDistance;
			//         v40 = input.screenCullingLayerMask;
			//         v66.ptr = 0LL;
			//         sub_1802F01E0(&v70, 0LL, 112LL);
			//         si128.handle = (ResourceHandle)v66.ptr;
			//         si128.fallBackResource.m_Value = (uint32_t)v66.ptr;
			//         v66 = v36;
			//         v41 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//                 &v72,
			//                 &v66,
			//                 *(Camera **)&inputa.handle,
			//                 v37.s_DepthCharacterOnlyName,
			//                 v38,
			//                 v39,
			//                 v40,
			//                 v23,
			//                 (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&si128,
			//                 &v70,
			//                 0LL,
			//                 0,
			//                 0LL,
			//                 0LL);
			//         *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v41.sortingCriteria;
			//         desc.stateBlock = v41.stateBlock;
			//         v41 = (RendererListDesc *)((char *)v41 + 128);
			//         *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v41.sortingCriteria;
			//         *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v41.stateBlock.hasValue;
			//         *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v41.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v41.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v41.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v41.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//         v42 = (ResourceHandle)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
			//                                 renderGraph,
			//                                 &desc,
			//                                 0LL);
			//       }
			//       else
			//       {
			//         v42 = (ResourceHandle)HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//       }
			//       inputa.handle = v42;
			//       v43 = (RendererListHandle *)v62;
			//       v44 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//               &v67,
			//               (RendererListHandle *)&inputa,
			//               0LL);
			//       if ( !v43 )
			//         sub_1802DC2C8(v46, v45);
			//       v43[8] = v44;
			//       vtFeedbackViewId = (unsigned int)camera.fields.vtFeedbackViewId;
			//       if ( !v62 )
			//         sub_1802DC2C8(vtFeedbackViewId, v45);
			//       LODWORD(v62[1].klass) = vtFeedbackViewId;
			//       terrainCullViewHandle = camera.fields.terrainCullViewHandle;
			//       if ( !v62 )
			//         sub_1802DC2C8(terrainCullViewHandle, v45);
			//       HIDWORD(v62[1].klass) = terrainCullViewHandle;
			//       editorTerrainCullViewHandle = camera.fields.editorTerrainCullViewHandle;
			//       if ( !v62 )
			//         sub_1802DC2C8(editorTerrainCullViewHandle, v45);
			//       LODWORD(v62[1].monitor) = editorTerrainCullViewHandle;
			//       subdivisionHandle = (unsigned int)camera.fields.subdivisionHandle;
			//       if ( !v62 )
			//         sub_1802DC2C8(subdivisionHandle, v45);
			//       HIDWORD(v62[1].monitor) = subdivisionHandle;
			//       deferredOpaqueECSList = input.deferredOpaqueECSList;
			//       if ( !v62 )
			//         sub_1802DC2C8(deferredOpaqueECSList, v45);
			//       LODWORD(v62[4].monitor) = deferredOpaqueECSList;
			//       deferredOpaqueEqualECSList = input.deferredOpaqueEqualECSList;
			//       if ( !v62 )
			//         sub_1802DC2C8(deferredOpaqueEqualECSList, v45);
			//       HIDWORD(v62[4].monitor) = deferredOpaqueEqualECSList;
			//       deferredGrassECSList = input.deferredGrassECSList;
			//       if ( !v62 )
			//         sub_1802DC2C8(deferredGrassECSList, v45);
			//       LODWORD(v62[5].klass) = deferredGrassECSList;
			//       deferredSludgeECSList = input.deferredSludgeECSList;
			//       if ( !v62 )
			//         sub_1802DC2C8(deferredSludgeECSList, v45);
			//       HIDWORD(v62[5].klass) = deferredSludgeECSList;
			//       characterPrePassECSList = input.characterPrePassECSList;
			//       if ( !v62 )
			//         sub_1802DC2C8(characterPrePassECSList, v45);
			//       LODWORD(v62[5].monitor) = characterPrePassECSList;
			//       characterOutlinePrePassECSList = input.characterOutlinePrePassECSList;
			//       if ( !v62 )
			//         sub_1802DC2C8(characterOutlinePrePassECSList, v45);
			//       HIDWORD(v62[5].monitor) = characterOutlinePrePassECSList;
			//       LOBYTE(characterOutlinePrePassECSList) = input.enableTerrainTessellation;
			//       if ( !v62 )
			//         sub_1802DC2C8(characterOutlinePrePassECSList, v45);
			//       LOBYTE(v62[6].monitor) = characterOutlinePrePassECSList;
			//       LOBYTE(characterOutlinePrePassECSList) = input.enableTerrainWetRipple;
			//       if ( !v62 )
			//         sub_1802DC2C8(characterOutlinePrePassECSList, v45);
			//       BYTE1(v62[6].monitor) = characterOutlinePrePassECSList;
			//       deferredOpaqueGPUDrivenList = input.deferredOpaqueGPUDrivenList;
			//       if ( !v62 )
			//         sub_1802DC2C8(deferredOpaqueGPUDrivenList, v45);
			//       LODWORD(v62[6].klass) = deferredOpaqueGPUDrivenList;
			//       deferredOpaqueEqualGPUDrivenList = input.deferredOpaqueEqualGPUDrivenList;
			//       if ( !v62 )
			//         sub_1802DC2C8(deferredOpaqueEqualGPUDrivenList, v45);
			//       HIDWORD(v62[6].klass) = deferredOpaqueEqualGPUDrivenList;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v67,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GBufferPassConstructor.static_fields.s_gBufferRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GBufferPassConstructor::GBufferPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v69 )
			//     {
			//       v68.m_RenderPass = (HGRenderGraphPass *)v69.ex;
			//     }
			//     sub_180222690(&v68);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::GBufferPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         GBufferPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2660, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2660, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::GBufferPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         GBufferPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2661, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2661, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<GBufferPassConstructor.GBufferPassData> s_gBufferRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 184)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneMV;

			internal TextureHandle sceneColorCopied;

			internal TextureHandle sceneDepthCopied;

			internal GBufferOutput gBufferOutput;

			internal CullingResults cullingResults;

			internal PerObjectData bakedLightConfig;

			internal bool enableTerrainTessellation;

			internal bool enableTerrainWetRipple;

			internal float screenCullingRatio;

			internal float screenCullingRatioDistance;

			internal uint screenCullingLayerMask;

			internal uint deferredOpaqueECSList;

			internal uint deferredOpaqueEqualECSList;

			internal uint deferredGrassECSList;

			internal uint deferredSludgeECSList;

			internal uint characterPrePassECSList;

			internal uint characterOutlinePrePassECSList;

			internal uint deferredOpaqueGPUDrivenList;

			internal uint deferredOpaqueEqualGPUDrivenList;
		}

		internal struct PassOutput
		{
		}

		private class GBufferPassData
		{
			public GBufferPassData()
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

			public int vtFeedbackId;

			public uint terrainCullViewHandle;

			public uint editorTerrainCullViewHandle;

			public int subdivisionHandle;

			public FrameSettings frameSettings;

			public RendererListHandle rendererList;

			public RendererListHandle characterPrePassRendererList;

			public uint deferredOpaqueECSList;

			public uint deferredOpaqueEqualECSList;

			public uint deferredGrassECSList;

			public uint deferredSludgeECSList;

			public uint characterPrePassECSList;

			public uint characterOutlinePrePassECSList;

			public uint deferredOpaqueGPUDrivenList;

			public uint deferredOpaqueEqualGPUDrivenList;

			public bool enableTerrainTessellation;

			public bool enableTerrainWetRipple;
		}
	}
}
