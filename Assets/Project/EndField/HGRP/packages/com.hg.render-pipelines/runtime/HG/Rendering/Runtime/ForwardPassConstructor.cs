using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class ForwardPassConstructor : IPassConstructor
	{
		internal ForwardPassConstructor(HGRenderPathBase.HGRenderPathResources resources)
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

		private void PrepareForwardPassData(ref ForwardPassConstructor.PassInput input, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, ForwardPassUtils.ForwardPassData passData)
		{
			// // Void PrepareForwardPassData(ForwardPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, HGRenderGraphBuilder, ForwardPassUtils+ForwardPassData)
			// void HG::Rendering::Runtime::ForwardPassConstructor::PrepareForwardPassData(
			//         ForwardPassConstructor *this,
			//         ForwardPassConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         HGRenderGraphBuilder *builder,
			//         ForwardPassUtils_ForwardPassData *passData,
			//         MethodInfo *method)
			// {
			//   __int64 forwardOpaqueECSRendererList; // rdx
			//   uint32_t forwardOpaqueEqualECSRendererList; // r8d
			//   uint32_t characterOpaqueECSRendererList; // r9d
			//   uint32_t characterOutlineOpaqueECSRendererList; // r10d
			//   uint32_t characterOutlineOpaqueEqualECSRendererList; // r11d
			//   bool characterOutlineEnabled; // si
			//   float screenCullingRatio; // xmm2_4
			//   float screenCullingRatioDistance; // xmm3_4
			//   uint32_t screenCullingLayerMask; // r14d
			//   __int128 v20; // xmm1
			//   HGRenderPipeline *hgrp; // rcx
			//   __int128 v22; // xmm0
			//   HGRenderPipeline *v23; // r12
			//   TextureHandle v24; // xmm10
			//   TextureHandle v25; // xmm7
			//   TextureHandle *v26; // rax
			//   unsigned int v27; // r14d
			//   uint32_t forwardTransparentECSRendererList; // esi
			//   bool v29; // di
			//   TextureHandle v30; // xmm6
			//   uint32_t v31; // ebx
			//   float v32; // xmm9_4
			//   float v33; // xmm8_4
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   __int64 v36; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v38; // xmm1
			//   unsigned int bakedLightingConfig; // [rsp+28h] [rbp-118h]
			//   ForwardPassUtils_ForwardOpaquePassData *opaqueData; // [rsp+78h] [rbp-C8h]
			//   ForwardPassUtils_ForwardTransparentPassData *transparentData; // [rsp+78h] [rbp-C8h]
			//   TextureHandle v42; // [rsp+C0h] [rbp-80h] BYREF
			//   CullingResults cullingResults; // [rsp+D0h] [rbp-70h] BYREF
			//   HGRenderGraphBuilder v44; // [rsp+E0h] [rbp-60h] BYREF
			//   TextureHandle v45; // [rsp+100h] [rbp-40h] BYREF
			//   TextureHandle v46; // [rsp+110h] [rbp-30h] BYREF
			//   HGRenderGraphBuilder v47; // [rsp+120h] [rbp-20h] BYREF
			//   BasicTransformConstants v48; // [rsp+140h] [rbp+0h] BYREF
			//   ShaderVariablesGlobal v49; // [rsp+410h] [rbp+2D0h] BYREF
			// 
			//   if ( !byte_18D91955A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D91955A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2635, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2635, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v36);
			//     v38 = *(_OWORD *)&builder.m_RenderGraph;
			//     *(_OWORD *)&v44.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//     *(_OWORD *)&v44.m_RenderGraph = v38;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_968(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       &v44,
			//       (Object *)passData,
			//       0LL);
			//   }
			//   else
			//   {
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
			//       sub_180B536AC((unsigned int)input.bakedLightingConfig, forwardOpaqueECSRendererList);
			//     opaqueData = passData.fields.opaqueData;
			//     v20 = *(_OWORD *)&builder.m_RenderGraph;
			//     bakedLightingConfig = input.bakedLightingConfig;
			//     hgrp = input.hgrp;
			//     cullingResults = input.cullingResults;
			//     v22 = *(_OWORD *)&builder.m_RenderPass;
			//     *(_OWORD *)&v47.m_RenderGraph = v20;
			//     *(_OWORD *)&v47.m_RenderPass = v22;
			//     HG::Rendering::Runtime::ForwardPassUtils::PrepareOpaquePassData(
			//       hgrp,
			//       renderGraph,
			//       camera,
			//       &v47,
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
			//     v23 = input.hgrp;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v24 = *(TextureHandle *)sub_182E7CCD0(&v42);
			//     v25 = *(TextureHandle *)sub_182E7CCD0(&v42);
			//     v26 = (TextureHandle *)sub_182E7CCD0(&v42);
			//     v27 = input.bakedLightingConfig;
			//     forwardTransparentECSRendererList = input.forwardTransparentECSRendererList;
			//     v29 = input.characterOutlineEnabled;
			//     v30 = *v26;
			//     v31 = input.screenCullingLayerMask;
			//     v32 = input.screenCullingRatio;
			//     v33 = input.screenCullingRatioDistance;
			//     sub_1802F01E0(&v48, 0LL, 720LL);
			//     sub_1802F01E0(&v49, 0LL, 3792LL);
			//     v34 = *(_OWORD *)&builder.m_RenderPass;
			//     cullingResults = input.cullingResults;
			//     v35 = *(_OWORD *)&builder.m_RenderGraph;
			//     transparentData = passData.fields.transparentData;
			//     *(_OWORD *)&v44.m_RenderPass = v34;
			//     *(_OWORD *)&v44.m_RenderGraph = v35;
			//     v45 = v30;
			//     v46 = v25;
			//     v42 = v24;
			//     HG::Rendering::Runtime::ForwardPassUtils::PrepareTransparentPassData(
			//       v23,
			//       renderGraph,
			//       &v42,
			//       &v46,
			//       &v45,
			//       camera,
			//       0LL,
			//       &v44,
			//       &cullingResults,
			//       (PerObjectData__Enum)v27,
			//       forwardTransparentECSRendererList,
			//       v29,
			//       v32,
			//       v33,
			//       v31,
			//       transparentData,
			//       0,
			//       1,
			//       1,
			//       0,
			//       &v48,
			//       &v49,
			//       0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::ForwardPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         ForwardPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2636, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2636, 0LL);
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
			// void HG::Rendering::Runtime::ForwardPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         ForwardPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2637, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2637, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref ForwardPassConstructor.PassInput input, ref ForwardPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(ForwardPassConstructor+PassInput ByRef, ForwardPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::ForwardPassConstructor::ConstructPass(
			//         ForwardPassConstructor *this,
			//         ForwardPassConstructor_PassInput *input,
			//         ForwardPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   String *s_forwardPassName; // rsi
			//   ProfilingSampler *v15; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   ForwardPassUtils_ForwardPassData *v21; // [rsp+40h] [rbp-C8h] BYREF
			//   HGRenderGraphBuilder v22; // [rsp+48h] [rbp-C0h] BYREF
			//   _QWORD v23[3]; // [rsp+68h] [rbp-A0h] BYREF
			//   ShadowResult v24; // [rsp+80h] [rbp-88h] BYREF
			//   HGRenderGraphBuilder v25; // [rsp+C0h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v26; // [rsp+E0h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91955B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ForwardPassUtils::ForwardPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     byte_18D91955B = 1;
			//   }
			//   memset(&v22, 0, sizeof(v22));
			//   v21 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2638, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2638, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v20, v19);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_969(
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
			//     *(BitArray128 *)&v24.directionalShadowActive = camera.fields._frameSettings_k__BackingField.bitDatas;
			//     *(_QWORD *)&v24.directionalShadowResult.fallBackResource._type_k__BackingField = *(_QWORD *)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//     if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//            (FrameSettings *)&v24,
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
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
			//       s_forwardPassName = TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor.static_fields.s_forwardPassName;
			//       v15 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x21u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !renderGraph )
			//         sub_180B536AC(v17, v16);
			//       v22 = *(HGRenderGraphBuilder *)sub_1808307B4(
			//                                        (unsigned int)&v24,
			//                                        (_DWORD)renderGraph,
			//                                        (_DWORD)s_forwardPassName,
			//                                        (unsigned int)&v21,
			//                                        (__int64)v15);
			//       v23[0] = 0LL;
			//       v23[1] = &v22;
			//       try
			//       {
			//         *(_OWORD *)&v25.m_RenderPass = *(_OWORD *)&v22.m_RenderPass;
			//         *(_OWORD *)&v24.directionalShadowActive = *(_OWORD *)&v22.m_RenderGraph;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         *(_OWORD *)&v25.m_RenderGraph = *(_OWORD *)&v24.directionalShadowActive;
			//         HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(&v24, &input.shadowResult, &v25, 0LL);
			//         *(_OWORD *)&v24.directionalShadowActive = *(_OWORD *)&v22.m_RenderPass;
			//         *(_OWORD *)&v24.directionalShadowResult.fallBackResource._type_k__BackingField = *(_OWORD *)&v22.m_RenderGraph;
			//         HG::Rendering::Runtime::ForwardPassConstructor::PrepareForwardPassData(
			//           this,
			//           input,
			//           renderGraph,
			//           camera,
			//           (HGRenderGraphBuilder *)&v24,
			//           v21,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v24,
			//           &v22,
			//           &input.sceneColor,
			//           0,
			//           0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&v24,
			//           &v22,
			//           &input.sceneDepth,
			//           DepthAccess__Enum_ReadWrite,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v22,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::ForwardPassConstructor.static_fields.s_forwardRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v26 )
			//       {
			//         v23[0] = v26.ex;
			//       }
			//       sub_180222690(v23);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::ForwardPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         ForwardPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2639, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2639, 0LL);
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
			// void HG::Rendering::Runtime::ForwardPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         ForwardPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2640, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2640, 0LL);
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
		private static string s_forwardPassName;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<ForwardPassUtils.ForwardPassData> s_forwardRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal HGRenderPipeline hgrp;

			internal uint forwardOpaqueECSRendererList;

			internal uint forwardOpaqueEqualECSRendererList;

			internal uint characterOpaqueECSRendererList;

			internal uint characterOutlineOpaqueECSRendererList;

			internal uint characterOutlineOpaqueEqualECSRendererList;

			internal uint forwardTransparentECSRendererList;

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
