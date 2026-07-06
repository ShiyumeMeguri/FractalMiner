using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class TransparentAfterDOFPassConstructor : IPassConstructor
	{
		internal TransparentAfterDOFPassConstructor(HGRenderPathBase.HGRenderPathResources resources)
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

		internal void ConstructPass(ref TransparentAfterDOFPassConstructor.PassInput input, ref TransparentAfterDOFPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void ConstructPass(TransparentAfterDOFPassConstructor+PassInput ByRef, TransparentAfterDOFPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::ConstructPass(
			//         TransparentAfterDOFPassConstructor *this,
			//         TransparentAfterDOFPassConstructor_PassInput *input,
			//         TransparentAfterDOFPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   ProfilingSampler *v12; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   Object *v15; // r14
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   TextureHandle v18; // xmm0
			//   TextureDesc *TextureDescRef; // rax
			//   TransparentAfterDOFPassConstructor_PassOutput *Texture; // rax
			//   Color v21; // xmm0
			//   __int128 v22; // xmm6
			//   __int128 v23; // xmm7
			//   __int64 v24; // rdx
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
			//   HGGraphicsFeatureSwitch *forwardTransparent; // rax
			//   bool m_defaultValue; // r15
			//   Object *v28; // rdx
			//   unsigned int v29; // edx
			//   unsigned __int64 v30; // r8
			//   char v31; // dl
			//   signed __int64 v32; // rtt
			//   RendererListHandle *v33; // r14
			//   RendererListHandle InvalidHandle; // rax
			//   RendererListHandle v35; // rdx
			//   RendererListHandle v36; // rcx
			//   RendererListHandle *v37; // r14
			//   unsigned int bakedLightConfig; // ecx
			//   float screenCullingRatio; // xmm2_4
			//   float screenCullingRatioDistance; // xmm1_4
			//   uint32_t screenCullingLayerMask; // eax
			//   RendererListDesc *v42; // rax
			//   RendererListHandle v43; // rax
			//   RendererListHandle v44; // rdx
			//   RendererListHandle v45; // rcx
			//   __int64 forwardTransparentAfterDOFECSList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   Object *v50; // [rsp+50h] [rbp-2E8h] BYREF
			//   CullingResults si128; // [rsp+60h] [rbp-2D8h] BYREF
			//   FrameSettings frameSettings_k__BackingField; // [rsp+70h] [rbp-2C8h] BYREF
			//   HGRenderGraphBuilder v53; // [rsp+88h] [rbp-2B0h] BYREF
			//   RendererListHandle inputa[2]; // [rsp+B0h] [rbp-288h] BYREF
			//   _QWORD v55[2]; // [rsp+C0h] [rbp-278h] BYREF
			//   HGRenderGraphBuilder v56; // [rsp+D0h] [rbp-268h] BYREF
			//   Il2CppExceptionWrapper *v57; // [rsp+F0h] [rbp-248h] BYREF
			//   ShadowResult v58; // [rsp+F8h] [rbp-240h] BYREF
			//   RendererListDesc desc; // [rsp+140h] [rbp-1F8h] BYREF
			//   RendererListDesc v60; // [rsp+220h] [rbp-118h] BYREF
			// 
			//   if ( !byte_18D919561 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentAfterDOFPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentAfterDOFPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor);
			//     sub_18003C530(&off_18D4FD7A0);
			//     byte_18D919561 = 1;
			//   }
			//   v50 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2652, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2652, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v49, v48);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_973(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !hgCamera )
			//       sub_180B536AC(v11, v10);
			//     frameSettings_k__BackingField = hgCamera.fields._frameSettings_k__BackingField;
			//     if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//            &frameSettings_k__BackingField,
			//            FrameSettingsField__Enum_TransparentObjects,
			//            0LL) )
			//     {
			//       v12 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x8Eu,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !renderGraph )
			//         sub_180B536AC(v14, v13);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v56,
			//         renderGraph,
			//         (String *)"Forward Transparent After DOF",
			//         &v50,
			//         v12,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentAfterDOFPassData>);
			//       v53 = v56;
			//       v55[0] = 0LL;
			//       v55[1] = &v53;
			//       try
			//       {
			//         v15 = v50;
			//         v18 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                  (TextureHandle *)&si128,
			//                  &v53,
			//                  &input.sceneColor,
			//                  0LL);
			//         if ( !v15 )
			//           sub_1802DC2C8(v17, v16);
			//         v15[2] = (Object)v18;
			//         TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                            renderGraph,
			//                            &input.sceneColor,
			//                            0LL);
			//         Texture = (TransparentAfterDOFPassConstructor_PassOutput *)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                                      (TextureHandle *)&si128,
			//                                                                      renderGraph,
			//                                                                      TextureDescRef,
			//                                                                      0LL);
			//         v21 = (Color)*Texture;
			//         *output = *Texture;
			//         si128 = (CullingResults)v21;
			//         *(__m128i *)&inputa[0].m_IsValid = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v56,
			//           &v53,
			//           (TextureHandle *)&si128,
			//           0,
			//           RenderBufferLoadAction__Enum_DontCare,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)inputa,
			//           0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&v56,
			//           &v53,
			//           &input.sceneDepth,
			//           DepthAccess__Enum_Read,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneMV, 0LL) )
			//         {
			//           si128 = (CullingResults)_mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v56,
			//             &v53,
			//             &input.sceneMV,
			//             1,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&si128,
			//             0,
			//             0LL);
			//         }
			//         frameSettings_k__BackingField = hgCamera.fields._frameSettings_k__BackingField;
			//         if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//                &frameSettings_k__BackingField,
			//                FrameSettingsField__Enum_ShadowMaps,
			//                0LL)
			//           || (frameSettings_k__BackingField = hgCamera.fields._frameSettings_k__BackingField,
			//               HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//                 &frameSettings_k__BackingField,
			//                 FrameSettingsField__Enum_CharacterShadowMaps,
			//                 0LL)) )
			//         {
			//           v22 = *(_OWORD *)&v53.m_RenderPass;
			//           v23 = *(_OWORD *)&v53.m_RenderGraph;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//           *(_OWORD *)&v56.m_RenderPass = v22;
			//           *(_OWORD *)&v56.m_RenderGraph = v23;
			//           HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(&v58, &input.shadowResult, &v56, 0LL);
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//         forwardTransparent = static_fields.forwardTransparent;
			//         if ( !forwardTransparent )
			//           sub_1802DC2C8(static_fields, v24);
			//         m_defaultValue = forwardTransparent.fields.m_defaultValue;
			//         v28 = v50;
			//         if ( !v50 )
			//           sub_1802DC2C8(static_fields, 0LL);
			//         v50[1].monitor = (MonitorData *)hgCamera;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v29 = ((unsigned __int64)&v28[1].monitor >> 12) & 0x1FFFFF;
			//           v30 = (unsigned __int64)v29 >> 6;
			//           v31 = v29 & 0x3F;
			//           _m_prefetchw(&qword_18D6870D0[v30]);
			//           do
			//             v32 = qword_18D6870D0[v30];
			//           while ( v32 != _InterlockedCompareExchange64(&qword_18D6870D0[v30], v32 | (1LL << v31), v32) );
			//         }
			//         v33 = (RendererListHandle *)v50;
			//         InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//         if ( !v33 )
			//           sub_1802DC2C8(v36, v35);
			//         v33[6] = InvalidHandle;
			//         if ( !v50 )
			//           sub_1802DC2C8(v36, v35);
			//         LODWORD(v50[1].klass) = -1;
			//         frameSettings_k__BackingField = hgCamera.fields._frameSettings_k__BackingField;
			//         if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//                &frameSettings_k__BackingField,
			//                FrameSettingsField__Enum_TransparentObjects,
			//                0LL)
			//           && m_defaultValue )
			//         {
			//           v37 = (RendererListHandle *)v50;
			//           bakedLightConfig = input.bakedLightConfig;
			//           screenCullingRatio = input.screenCullingRatio;
			//           screenCullingRatioDistance = input.screenCullingRatioDistance;
			//           screenCullingLayerMask = input.screenCullingLayerMask;
			//           si128 = input.cullingResults;
			//           v42 = HG::Rendering::Runtime::ForwardPassUtils::PrepareAfterDOFTranparentRendererList(
			//                   &v60,
			//                   input.hgrp,
			//                   hgCamera,
			//                   input.characterOutlineEnabled,
			//                   &si128,
			//                   (PerObjectData__Enum)bakedLightConfig,
			//                   screenCullingRatio,
			//                   screenCullingRatioDistance,
			//                   screenCullingLayerMask,
			//                   0LL);
			//           *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v42.sortingCriteria;
			//           desc.stateBlock = v42.stateBlock;
			//           v42 = (RendererListDesc *)((char *)v42 + 128);
			//           *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v42.sortingCriteria;
			//           *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v42.stateBlock.hasValue;
			//           *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v42.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//           *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v42.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//           *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v42.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//           *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v42.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//           inputa[0] = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//           v43 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v53, inputa, 0LL);
			//           if ( !v37 )
			//             sub_1802DC2C8(v45, v44);
			//           v37[6] = v43;
			//           forwardTransparentAfterDOFECSList = input.forwardTransparentAfterDOFECSList;
			//           if ( !v50 )
			//             sub_1802DC2C8(forwardTransparentAfterDOFECSList, v44);
			//           LODWORD(v50[1].klass) = forwardTransparentAfterDOFECSList;
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v53,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TransparentAfterDOFPassConstructor.static_fields.s_forwardTransparentAfterDOFRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentAfterDOFPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v57 )
			//       {
			//         v55[0] = v57.ex;
			//       }
			//       sub_180222690(v55);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         TransparentAfterDOFPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2653, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2653, 0LL);
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
			// void HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         TransparentAfterDOFPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2654, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2654, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         TransparentAfterDOFPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2655, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2655, 0LL);
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
			// void HG::Rendering::Runtime::TransparentAfterDOFPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         TransparentAfterDOFPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2656, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2656, 0LL);
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

		public ShadowResult shadowResult;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<ForwardPassUtils.ForwardTransparentAfterDOFPassData> s_forwardTransparentAfterDOFRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal bool characterOutlineEnabled;

			internal uint forwardTransparentAfterDOFECSList;

			internal uint screenCullingLayerMask;

			internal float screenCullingRatio;

			internal float screenCullingRatioDistance;

			internal PerObjectData bakedLightConfig;

			internal ShadowResult shadowResult;

			internal CullingResults cullingResults;

			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneMV;

			internal HGRenderPipeline hgrp;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassOutput
		{
			internal TextureHandle sceneColor;
		}
	}
}
