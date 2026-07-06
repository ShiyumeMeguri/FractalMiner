using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class ForwardOpaquePassConstructor : IPassConstructor
	{
		internal ForwardOpaquePassConstructor()
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

		private void PrepareForwardOpaquePassData(ref ForwardOpaquePassConstructor.PassInput input, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, ForwardPassUtils.ForwardPassData passData)
		{
			// // Void PrepareForwardOpaquePassData(ForwardOpaquePassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, HGRenderGraphBuilder, ForwardPassUtils+ForwardPassData)
			// void HG::Rendering::Runtime::ForwardOpaquePassConstructor::PrepareForwardOpaquePassData(
			//         ForwardOpaquePassConstructor *this,
			//         ForwardOpaquePassConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         HGRenderGraphBuilder *builder,
			//         ForwardPassUtils_ForwardPassData *passData,
			//         MethodInfo *method)
			// {
			//   __int64 bakedLightingConfig; // rdx
			//   uint32_t forwardOpaqueECSRendererList; // r8d
			//   uint32_t forwardOpaqueEqualECSRendererList; // r9d
			//   uint32_t characterOpaqueECSRendererList; // r10d
			//   uint32_t characterOutlineOpaqueECSRendererList; // r11d
			//   uint32_t characterOutlineOpaqueEqualECSRendererList; // ebp
			//   bool characterOutlineEnabled; // r14
			//   float screenCullingRatio; // xmm2_4
			//   float screenCullingRatioDistance; // xmm3_4
			//   uint32_t screenCullingLayerMask; // r15d
			//   __int128 v21; // xmm0
			//   HGRenderPipeline *hgrp; // rcx
			//   __int64 v23; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v25; // xmm1
			//   ForwardPassUtils_ForwardOpaquePassData *opaqueData; // [rsp+78h] [rbp-60h]
			//   CullingResults cullingResults; // [rsp+90h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v28; // [rsp+A0h] [rbp-38h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2641, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2641, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v23);
			//     v25 = *(_OWORD *)&builder.m_RenderGraph;
			//     *(_OWORD *)&v28.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//     *(_OWORD *)&v28.m_RenderGraph = v25;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_970(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       &v28,
			//       (Object *)passData,
			//       0LL);
			//   }
			//   else
			//   {
			//     bakedLightingConfig = (unsigned int)input.bakedLightingConfig;
			//     forwardOpaqueECSRendererList = input.forwardOpaqueECSRendererList;
			//     forwardOpaqueEqualECSRendererList = input.forwardOpaqueEqualECSRendererList;
			//     characterOpaqueECSRendererList = input.characterOpaqueECSRendererList;
			//     characterOutlineOpaqueECSRendererList = input.characterOutlineOpaqueECSRendererList;
			//     characterOutlineOpaqueEqualECSRendererList = input.characterOutlineOpaqueEqualECSRendererList;
			//     characterOutlineEnabled = input.characterOutlineEnabled;
			//     screenCullingRatio = input.screenCullingRatio;
			//     screenCullingRatioDistance = input.screenCullingRatioDistance;
			//     screenCullingLayerMask = input.screenCullingLayerMask;
			//     if ( !passData )
			//       sub_180B536AC(0LL, bakedLightingConfig);
			//     cullingResults = input.cullingResults;
			//     v21 = *(_OWORD *)&builder.m_RenderGraph;
			//     hgrp = input.hgrp;
			//     opaqueData = passData.fields.opaqueData;
			//     *(_OWORD *)&v28.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//     *(_OWORD *)&v28.m_RenderGraph = v21;
			//     HG::Rendering::Runtime::ForwardPassUtils::PrepareOpaquePassData(
			//       hgrp,
			//       renderGraph,
			//       camera,
			//       &v28,
			//       &cullingResults,
			//       (PerObjectData__Enum)bakedLightingConfig,
			//       forwardOpaqueECSRendererList,
			//       forwardOpaqueEqualECSRendererList,
			//       characterOpaqueECSRendererList,
			//       characterOutlineOpaqueECSRendererList,
			//       characterOutlineOpaqueEqualECSRendererList,
			//       characterOutlineEnabled,
			//       screenCullingRatio,
			//       screenCullingRatioDistance,
			//       screenCullingLayerMask,
			//       opaqueData,
			//       0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::ForwardOpaquePassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         ForwardOpaquePassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2642, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2642, 0LL);
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
			// void HG::Rendering::Runtime::ForwardOpaquePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         ForwardOpaquePassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2643, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2643, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref ForwardOpaquePassConstructor.PassInput input, ref ForwardOpaquePassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(ForwardOpaquePassConstructor+PassInput ByRef, ForwardOpaquePassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::ForwardOpaquePassConstructor::ConstructPass(
			//         ForwardOpaquePassConstructor *this,
			//         ForwardOpaquePassConstructor_PassInput *input,
			//         ForwardOpaquePassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   String *s_forwardOpaquePassName; // rsi
			//   ProfilingSampler *v15; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   __int128 v18; // xmm6
			//   __int128 v19; // xmm7
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   HGRenderGraphBuilder v23; // [rsp+50h] [rbp-F8h] BYREF
			//   ForwardPassUtils_ForwardPassData *v24; // [rsp+70h] [rbp-D8h] BYREF
			//   HGRenderGraphBuilder v25; // [rsp+80h] [rbp-C8h] BYREF
			//   _QWORD v26[2]; // [rsp+A0h] [rbp-A8h] BYREF
			//   __m128i si128; // [rsp+B0h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v28; // [rsp+C0h] [rbp-88h] BYREF
			//   ShadowResult v29; // [rsp+C8h] [rbp-80h] BYREF
			// 
			//   if ( !byte_18D91955E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ForwardPassUtils::ForwardPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D91955E = 1;
			//   }
			//   memset(&v23, 0, sizeof(v23));
			//   v24 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2644, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2644, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v22, v21);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_971(
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
			//     if ( !camera )
			//       sub_180B536AC(v11, v10);
			//     *(BitArray128 *)&v25.m_RenderPass = camera.fields._frameSettings_k__BackingField.bitDatas;
			//     v25.m_RenderGraph = *(HGRenderGraph **)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//     if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//            (FrameSettings *)&v25,
			//            FrameSettingsField__Enum_OpaqueObjects,
			//            0LL) )
			//     {
			//       goto LABEL_8;
			//     }
			//     if ( !camera.fields.camera )
			//       sub_180B536AC(v13, v12);
			//     if ( UnityEngine::Camera::get_clearFlags(camera.fields.camera, 0LL) == CameraClearFlags__Enum_Skybox )
			//     {
			// LABEL_8:
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
			//       s_forwardOpaquePassName = TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor.static_fields.s_forwardOpaquePassName;
			//       v15 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x22u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !renderGraph )
			//         sub_180B536AC(v17, v16);
			//       v23 = *(HGRenderGraphBuilder *)sub_1808307B4(
			//                                        (unsigned int)&v25,
			//                                        (_DWORD)renderGraph,
			//                                        (_DWORD)s_forwardOpaquePassName,
			//                                        (unsigned int)&v24,
			//                                        (__int64)v15);
			//       v26[0] = 0LL;
			//       v26[1] = &v23;
			//       try
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.terrainDepthBuffer, 0LL) )
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//             (TextureHandle *)&si128,
			//             &v23,
			//             &input.terrainDepthBuffer,
			//             0LL);
			//         v18 = *(_OWORD *)&v23.m_RenderPass;
			//         v19 = *(_OWORD *)&v23.m_RenderGraph;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         *(_OWORD *)&v25.m_RenderPass = v18;
			//         *(_OWORD *)&v25.m_RenderGraph = v19;
			//         HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(&v29, &input.shadowResult, &v25, 0LL);
			//         v25 = v23;
			//         HG::Rendering::Runtime::ForwardOpaquePassConstructor::PrepareForwardOpaquePassData(
			//           this,
			//           input,
			//           renderGraph,
			//           camera,
			//           &v25,
			//           v24,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&si128,
			//           &v23,
			//           &input.sceneColor,
			//           0,
			//           0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&si128,
			//           &v23,
			//           &input.sceneDepth,
			//           DepthAccess__Enum_ReadWrite,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneMV, 0LL) )
			//         {
			//           si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v25,
			//             &v23,
			//             &input.sceneMV,
			//             1,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&si128,
			//             0,
			//             0LL);
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v23,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ForwardOpaquePassConstructor.static_fields.s_forwardOpaqueRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v28 )
			//       {
			//         v26[0] = v28.ex;
			//       }
			//       sub_180222690(v26);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::ForwardOpaquePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         ForwardOpaquePassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2645, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2645, 0LL);
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
			// void HG::Rendering::Runtime::ForwardOpaquePassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         ForwardOpaquePassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2646, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2646, 0LL);
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
		private static string s_forwardOpaquePassName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<ForwardPassUtils.ForwardPassData> s_forwardOpaqueRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneMV;

			internal TextureHandle terrainDepthBuffer;

			internal HGRenderPipeline hgrp;

			internal uint forwardOpaqueECSRendererList;

			internal uint forwardOpaqueEqualECSRendererList;

			internal uint characterOpaqueECSRendererList;

			internal uint characterOutlineOpaqueECSRendererList;

			internal uint characterOutlineOpaqueEqualECSRendererList;

			internal uint forwardOccludedDisplayECSRendererList;

			internal ShadowResult shadowResult;

			internal CullingResults cullingResults;

			internal PerObjectData bakedLightingConfig;

			internal float screenCullingRatio;

			internal float screenCullingRatioDistance;

			internal uint screenCullingLayerMask;

			internal bool characterOutlineEnabled;
		}

		internal struct PassOutput
		{
		}
	}
}
