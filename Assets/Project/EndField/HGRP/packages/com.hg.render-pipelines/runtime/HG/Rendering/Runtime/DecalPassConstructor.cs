using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class DecalPassConstructor : IPassConstructor
	{
		internal DecalPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::DecalPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         DecalPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2527, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2527, 0LL);
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
			// void HG::Rendering::Runtime::DecalPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         DecalPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2528, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2528, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref DecalPassConstructor.PassInput input, ref DecalPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(DecalPassConstructor+PassInput ByRef, DecalPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::DecalPassConstructor::ConstructPass(
			//         DecalPassConstructor *this,
			//         DecalPassConstructor_PassInput *input,
			//         DecalPassConstructor_PassOutput *output,
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
			//   Object *v16; // rbx
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   TextureHandle v19; // xmm0
			//   Object *v20; // rbx
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   TextureHandle v23; // xmm0
			//   Object__Class *v24; // xmm1_8
			//   Object *v25; // rax
			//   __int64 v26; // rdx
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
			//   HGGraphicsFeatureSwitch *deferredErosion; // rax
			//   bool m_defaultValue; // di
			//   PerObjectData__Enum v30; // r15d
			//   CullingResults cullingResults; // xmm8
			//   Camera *v32; // r12
			//   HGShaderPassNames__StaticFields *v33; // rbx
			//   float screenCullingRatio; // xmm7_4
			//   float screenCullingRatioDistance; // xmm6_4
			//   uint32_t screenCullingLayerMask; // edi
			//   RendererListDesc *v37; // rax
			//   RendererListHandle InvalidHandle; // rax
			//   RendererListHandle *v39; // rbx
			//   RendererListHandle v40; // rax
			//   RendererListHandle v41; // rdx
			//   RendererListHandle v42; // rcx
			//   __int64 deferredDecalECSList; // rcx
			//   __int64 deferredErosionECSList; // rcx
			//   __int64 deferredSludgeECSList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   Object *v49; // [rsp+70h] [rbp-298h] BYREF
			//   TextureHandle si128; // [rsp+80h] [rbp-288h] BYREF
			//   RendererListHandle inputa[2]; // [rsp+90h] [rbp-278h] BYREF
			//   HGRenderGraphBuilder v52; // [rsp+A0h] [rbp-268h] BYREF
			//   _QWORD v53[2]; // [rsp+C0h] [rbp-248h] BYREF
			//   HGRenderGraphBuilder v54; // [rsp+D0h] [rbp-238h] BYREF
			//   Il2CppExceptionWrapper *v55; // [rsp+F0h] [rbp-218h] BYREF
			//   RendererListDesc desc; // [rsp+100h] [rbp-208h] BYREF
			//   RendererListDesc v57; // [rsp+1E0h] [rbp-128h] BYREF
			// 
			//   if ( !byte_18D919514 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DecalPassConstructor::DecalPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DecalPassConstructor::DecalPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D564398);
			//     byte_18D919514 = 1;
			//   }
			//   v49 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2529, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2529, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v48, v47);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_928(
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
			//             (Int32Enum__Enum)0x18u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v54,
			//       renderGraph,
			//       (String *)"Decal",
			//       &v49,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DecalPassConstructor::DecalPassData>);
			//     v52 = v54;
			//     v53[0] = 0LL;
			//     v53[1] = &v52;
			//     try
			//     {
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowRendererListCulling(&v52, 0, 0LL);
			//       v13 = 1;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         &si128,
			//         &v52,
			//         &input.sceneColor,
			//         0,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneMV, 0LL) )
			//       {
			//         v13 = 2;
			//         si128 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)inputa,
			//           &v52,
			//           &input.sceneMV,
			//           1,
			//           RenderBufferLoadAction__Enum_Load,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&si128,
			//           0,
			//           0LL);
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         &si128,
			//         &v52,
			//         &input.sceneDepth,
			//         DepthAccess__Enum_Write,
			//         0,
			//         0LL);
			//       for ( i = 0; i < 4; ++i )
			//       {
			//         si128 = *HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                    (TextureHandle *)inputa,
			//                    &input.gBufferOutput,
			//                    i,
			//                    0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&si128, 0LL) )
			//         {
			//           v15 = v13++;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v54,
			//             &v52,
			//             &si128,
			//             v15,
			//             0,
			//             0LL);
			//         }
			//       }
			//       v16 = v49;
			//       v19 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v54,
			//                &v52,
			//                &input.sceneDepthCopied,
			//                0LL);
			//       if ( !v16 )
			//         sub_1802DC2C8(v18, v17);
			//       *(TextureHandle *)((char *)&v16[3].monitor + 4) = v19;
			//       v20 = v49;
			//       v23 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&v54,
			//                &v52,
			//                &input.sceneNormalCopied,
			//                0LL);
			//       if ( !v20 )
			//         sub_1802DC2C8(v22, v21);
			//       *(TextureHandle *)((char *)&v20[4].monitor + 4) = v23;
			//       if ( !camera )
			//         sub_1802DC2C8(v22, v21);
			//       v24 = *(Object__Class **)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//       v25 = v49;
			//       if ( !v49 )
			//         sub_1802DC2C8(v22, v21);
			//       v49[1] = (Object)camera.fields._frameSettings_k__BackingField.bitDatas;
			//       v25[2].klass = v24;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//       deferredErosion = static_fields.deferredErosion;
			//       if ( !deferredErosion )
			//         sub_1802DC2C8(static_fields, v26);
			//       m_defaultValue = deferredErosion.fields.m_defaultValue;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//       v30 = input.bakedLightConfig | HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(camera, 0LL);
			//       if ( m_defaultValue )
			//       {
			//         cullingResults = input.cullingResults;
			//         v32 = camera.fields.camera;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//         v33 = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields;
			//         screenCullingRatio = input.screenCullingRatio;
			//         screenCullingRatioDistance = input.screenCullingRatioDistance;
			//         screenCullingLayerMask = input.screenCullingLayerMask;
			//         inputa[0] = 0LL;
			//         sub_1802F01E0(&desc, 0LL, 112LL);
			//         si128.handle = (ResourceHandle)inputa[0];
			//         si128.fallBackResource.m_Value = *(_DWORD *)&inputa[0].m_IsValid;
			//         *(CullingResults *)&inputa[0].m_IsValid = cullingResults;
			//         v37 = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//                 &v57,
			//                 (CullingResults *)inputa,
			//                 v32,
			//                 v33.s_ErosionName,
			//                 screenCullingRatio,
			//                 screenCullingRatioDistance,
			//                 screenCullingLayerMask,
			//                 v30,
			//                 (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&si128,
			//                 (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&desc,
			//                 0LL,
			//                 0,
			//                 0LL,
			//                 0LL);
			//         *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v37.sortingCriteria;
			//         desc.stateBlock = v37.stateBlock;
			//         v37 = (RendererListDesc *)((char *)v37 + 128);
			//         *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v37.sortingCriteria;
			//         *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v37.stateBlock.hasValue;
			//         *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v37.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v37.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v37.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v37.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//         InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//       }
			//       else
			//       {
			//         InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//       }
			//       inputa[0] = InvalidHandle;
			//       v39 = (RendererListHandle *)v49;
			//       v40 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v52, inputa, 0LL);
			//       if ( !v39 )
			//         sub_1802DC2C8(v42, v41);
			//       v39[5] = v40;
			//       deferredDecalECSList = input.deferredDecalECSList;
			//       if ( !v49 )
			//         sub_1802DC2C8(deferredDecalECSList, v41);
			//       LODWORD(v49[3].klass) = deferredDecalECSList;
			//       deferredErosionECSList = input.deferredErosionECSList;
			//       if ( !v49 )
			//         sub_1802DC2C8(deferredErosionECSList, v41);
			//       HIDWORD(v49[3].klass) = deferredErosionECSList;
			//       deferredSludgeECSList = input.deferredSludgeECSList;
			//       if ( !v49 )
			//         sub_1802DC2C8(deferredSludgeECSList, v41);
			//       LODWORD(v49[3].monitor) = deferredSludgeECSList;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v52,
			//         (RenderFunc_1_System_Object_ *)this.fields.s_decalRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DecalPassConstructor::DecalPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v55 )
			//     {
			//       v53[0] = v55.ex;
			//     }
			//     sub_180222690(v53);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::DecalPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         DecalPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2530, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2530, 0LL);
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
			// void HG::Rendering::Runtime::DecalPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         DecalPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2531, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2531, 0LL);
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

		private readonly RenderFunc<DecalPassConstructor.DecalPassData> s_decalRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 160)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneMV;

			internal TextureHandle sceneDepthCopied;

			internal TextureHandle sceneNormalCopied;

			internal GBufferOutput gBufferOutput;

			internal CullingResults cullingResults;

			internal PerObjectData bakedLightConfig;

			internal float screenCullingRatio;

			internal float screenCullingRatioDistance;

			internal uint screenCullingLayerMask;

			internal uint deferredDecalECSList;

			internal uint deferredErosionECSList;

			internal uint deferredSludgeECSList;
		}

		internal struct PassOutput
		{
		}

		private class DecalPassData
		{
			public DecalPassData()
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

			public FrameSettings frameSettings;

			public RendererListHandle erosionRendererList;

			public uint deferredDecalECSList;

			public uint deferredErosionECSList;

			public uint deferredSludgeECSList;

			public TextureHandle sceneDepthCopied;

			public TextureHandle sceneNormalCopied;
		}
	}
}
