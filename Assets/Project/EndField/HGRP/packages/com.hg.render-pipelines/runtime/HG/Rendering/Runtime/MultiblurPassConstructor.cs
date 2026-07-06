using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class MultiblurPassConstructor : IPassConstructor
	{
		internal MultiblurPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // MultiblurPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::MultiblurPassConstructor::MultiblurPassConstructor(
			//         MultiblurPassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D8EDAA1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     byte_18D8EDAA1 = 1;
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::UberPostPassUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils, materialCollector);
			//   HG::Rendering::Runtime::UberPostPassUtils::PrepareFrostedGlassPSMaterials(
			//     materialCollector,
			//     &this.fields.m_frostedGlassPSMaterials,
			//     resources.defaultResources,
			//     0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::MultiblurPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         MultiblurPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2728, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2728, 0LL);
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
			// void HG::Rendering::Runtime::MultiblurPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         MultiblurPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2729, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2729, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref MultiblurPassConstructor.PassInput input, ref MultiblurPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera, HGSettingParameters settingParameters)
		{
			// // Void ConstructPass(MultiblurPassConstructor+PassInput ByRef, MultiblurPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::MultiblurPassConstructor::ConstructPass(
			//         MultiblurPassConstructor *this,
			//         MultiblurPassConstructor_PassInput *input,
			//         MultiblurPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   Object *v7; // r13
			//   MultiblurPassConstructor_PassInput *v9; // r15
			//   MultiblurPassConstructor *v10; // r12
			//   HGCamera *v11; // rsi
			//   int i; // r14d
			//   TextureHandle target; // xmm6
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // rcx
			//   Object *v17; // rdx
			//   unsigned int v18; // edx
			//   unsigned __int64 v19; // r8
			//   char v20; // dl
			//   signed __int64 v21; // rtt
			//   TextureHandle v22; // xmm6
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   CullingResults cullingResults; // xmm8
			//   HGRenderPipeline *hgrp; // rax
			//   Camera *v27; // rcx
			//   float screenCullingRatio; // xmm6_4
			//   float screenCullingRatioDistance; // xmm7_4
			//   uint32_t screenCullingLayerMask; // r12d
			//   RendererListDesc *v31; // rax
			//   RendererListHandle *v32; // rbx
			//   RendererListHandle v33; // rax
			//   RendererListHandle v34; // rdx
			//   RendererListHandle v35; // rcx
			//   Object *v36; // rbx
			//   Camera *v37; // rcx
			//   __int64 v38; // rdx
			//   Object_1 *v39; // rcx
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   Object__Class *klass; // r12
			//   uint32_t RendererList; // eax
			//   __int64 v44; // rdx
			//   __int64 v45; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   int16_t sortingOrderMax[2]; // [rsp+90h] [rbp-3B8h]
			//   int v50; // [rsp+94h] [rbp-3B4h]
			//   int32_t cullingMask; // [rsp+98h] [rbp-3B0h]
			//   int32_t cameraInstanceID; // [rsp+98h] [rbp-3B0h]
			//   int16_t sortingOrderMin[2]; // [rsp+9Ch] [rbp-3ACh]
			//   Object *v54; // [rsp+A0h] [rbp-3A8h] BYREF
			//   uint32_t cullingLayerMask[4]; // [rsp+B0h] [rbp-398h] BYREF
			//   HGRenderGraphBuilder inputa; // [rsp+C0h] [rbp-388h] BYREF
			//   __int64 v57; // [rsp+E0h] [rbp-368h]
			//   __int128 v58; // [rsp+F0h] [rbp-358h]
			//   _QWORD v59[2]; // [rsp+100h] [rbp-348h] BYREF
			//   HGRenderGraphBuilder v60; // [rsp+110h] [rbp-338h] BYREF
			//   ShaderTagId__Array *uiPassNames; // [rsp+130h] [rbp-318h]
			//   Nullable_1_UnityEngine_Rendering_RenderQueueRange_ v62; // [rsp+140h] [rbp-308h] BYREF
			//   Il2CppExceptionWrapper *v63; // [rsp+150h] [rbp-2F8h] BYREF
			//   TextureHandle v64; // [rsp+158h] [rbp-2F0h] BYREF
			//   TextureHandle v65; // [rsp+168h] [rbp-2E0h] BYREF
			//   TextureHandle v66; // [rsp+178h] [rbp-2D0h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v67; // [rsp+190h] [rbp-2B8h] BYREF
			//   RendererListDesc desc; // [rsp+200h] [rbp-248h] BYREF
			//   RendererListDesc v69; // [rsp+2E0h] [rbp-168h] BYREF
			// 
			//   v7 = (Object *)renderGraph;
			//   v9 = input;
			//   v10 = this;
			//   if ( !byte_18D919591 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::MultiblurPassConstructor::UIPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::MultiblurPassConstructor::UIPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::Nullable);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderQueueRange);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     sub_18003C530(&off_18D500D58);
			//     byte_18D919591 = 1;
			//   }
			//   memset(&v60, 0, sizeof(v60));
			//   v54 = 0LL;
			//   sub_1802F01E0(&v67, 0LL, 112LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2730, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2730, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v48, v47);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_997(
			//       Patch,
			//       (Object *)v10,
			//       v9,
			//       output,
			//       v7,
			//       (Object *)camera,
			//       (Object *)settingParameters,
			//       0LL);
			//   }
			//   else
			//   {
			//     v11 = camera;
			//     if ( camera )
			//     {
			//       for ( i = 1; ; ++i )
			//       {
			//         v50 = i;
			//         if ( i > v11.fields.sortingOrdersToBlurInternal.m_Length )
			//           break;
			//         *(_DWORD *)sortingOrderMin = *(_DWORD *)&v11.fields.sortingOrdersToBlurInternal.m_Buffer[4 * i - 4];
			//         if ( i == v11.fields.sortingOrdersToBlurInternal.m_Length )
			//           sortingOrderMax[0] = 0x7FFF;
			//         else
			//           *(_DWORD *)sortingOrderMax = *(_DWORD *)&v11.fields.sortingOrdersToBlurInternal.m_Buffer[4 * i] - 1;
			//         target = v9.target;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//         *(TextureHandle *)&inputa.m_RenderPass = target;
			//         HG::Rendering::Runtime::UberPostPassUtils::RenderUIFrostedGlass(
			//           (TextureHandle *)&inputa,
			//           (HGRenderGraph *)v7,
			//           v11,
			//           settingParameters,
			//           &v10.fields.m_frostedGlassPSMaterials,
			//           0LL);
			//         if ( !v7 )
			//           sub_180B536AC(v15, v14);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           &inputa,
			//           (HGRenderGraph *)v7,
			//           (String *)"Post Frosted Glass UI",
			//           &v54,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::MultiblurPassConstructor::UIPassData>);
			//         v60 = inputa;
			//         v59[0] = 0LL;
			//         v59[1] = &v60;
			//         try
			//         {
			//           v17 = v54;
			//           if ( !v54 )
			//             sub_1802DC2C8(v16, 0LL);
			//           v54[1].klass = (Object__Class *)v11;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v18 = ((unsigned __int64)&v17[1] >> 12) & 0x1FFFFF;
			//             v19 = (unsigned __int64)v18 >> 6;
			//             v20 = v18 & 0x3F;
			//             _m_prefetchw(&qword_18D6870D0[v19]);
			//             do
			//               v21 = qword_18D6870D0[v19];
			//             while ( v21 != _InterlockedCompareExchange64(&qword_18D6870D0[v19], v21 | (1LL << v20), v21) );
			//             v50 = i;
			//           }
			//           LODWORD(v58) = 0;
			//           DWORD1(v58) = _mm_shuffle_ps((__m128)0LL, (__m128)0LL, 85).m128_u32[0];
			//           *((_QWORD *)&v58 + 1) = _mm_shuffle_ps((__m128)0LL, (__m128)0LL, 170).m128_u32[0];
			//           *(_OWORD *)&inputa.m_RenderPass = v58;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             &v64,
			//             &v60,
			//             &v9.target,
			//             0,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&inputa,
			//             0,
			//             0LL);
			//           v22 = v9.target;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//           *(TextureHandle *)&inputa.m_RenderPass = v22;
			//           *(TextureHandle *)&inputa.m_RenderPass = *HG::Rendering::Runtime::HGUtils::GeneratePairedDepthTarget(
			//                                                       &v65,
			//                                                       (HGRenderGraph *)v7,
			//                                                       v11,
			//                                                       (TextureHandle *)&inputa,
			//                                                       0LL);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//             &v66,
			//             &v60,
			//             (TextureHandle *)&inputa,
			//             DepthAccess__Enum_ReadWrite,
			//             RenderBufferLoadAction__Enum_Clear,
			//             RenderBufferStoreAction__Enum_DontCare,
			//             1.0,
			//             0,
			//             0,
			//             0LL);
			//           cullingResults = v9.cullingResults;
			//           inputa.m_RenderPass = (HGRenderGraphPass *)v11.fields.camera;
			//           hgrp = v9.hgrp;
			//           if ( !hgrp )
			//             sub_1802DC2C8(v24, v23);
			//           uiPassNames = hgrp.fields.uiPassNames;
			//           v27 = v11.fields.camera;
			//           if ( !v27 )
			//             sub_1802DC2C8(0LL, v23);
			//           cullingMask = UnityEngine::Camera::get_cullingMask(v27, 0LL);
			//           screenCullingRatio = v9.screenCullingRatio;
			//           screenCullingRatioDistance = v9.screenCullingRatioDistance;
			//           screenCullingLayerMask = v9.screenCullingLayerMask;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
			//           *(_QWORD *)cullingLayerMask = 0x138800000000LL;
			//           v57 = 1LL;
			//           sub_1802F01E0(&v67, 0LL, 112LL);
			//           *(_QWORD *)&v62.hasValue = v57;
			//           v62.value.m_UpperBound = 5000;
			//           *(CullingResults *)cullingLayerMask = cullingResults;
			//           v31 = HG::Rendering::Runtime::HGRendererListUtils::CreateUIRendererListDesc(
			//                   &v69,
			//                   (CullingResults *)cullingLayerMask,
			//                   (Camera *)inputa.m_RenderPass,
			//                   uiPassNames,
			//                   cullingMask,
			//                   screenCullingRatio,
			//                   screenCullingRatioDistance,
			//                   screenCullingLayerMask,
			//                   PerObjectData__Enum_None,
			//                   &v62,
			//                   &v67,
			//                   0LL,
			//                   0,
			//                   SortingCriteria__Enum_SortingLayer,
			//                   sortingOrderMin[0],
			//                   sortingOrderMax[0],
			//                   0LL);
			//           *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v31.sortingCriteria;
			//           desc.stateBlock = v31.stateBlock;
			//           v31 = (RendererListDesc *)((char *)v31 + 128);
			//           *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v31.sortingCriteria;
			//           *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v31.stateBlock.hasValue;
			//           *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v31.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//           *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v31.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//           *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v31.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//           *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v31.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//           inputa.m_RenderPass = (HGRenderGraphPass *)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(
			//                                                        (HGRenderGraph *)v7,
			//                                                        &desc,
			//                                                        0LL);
			//           v32 = (RendererListHandle *)v54;
			//           v33 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//                   &v60,
			//                   (RendererListHandle *)&inputa,
			//                   0LL);
			//           if ( !v32 )
			//             sub_1802DC2C8(v35, v34);
			//           v32[7] = v33;
			//           if ( !v54 )
			//             sub_1802DC2C8(v35, v34);
			//           LODWORD(v54[4].klass) = -1;
			//           v36 = v54;
			//           v37 = v11.fields.camera;
			//           if ( !v37 )
			//             sub_1802DC2C8(0LL, v34);
			//           cullingLayerMask[0] = UnityEngine::Camera::get_cullingMask(v37, 0LL);
			//           v39 = (Object_1 *)v11.fields.camera;
			//           if ( !v39 )
			//             sub_1802DC2C8(0LL, v38);
			//           cameraInstanceID = UnityEngine::Object::GetInstanceID(v39, 0LL);
			//           klass = v7[6].klass;
			//           if ( !klass )
			//             sub_1802DC2C8(v41, v40);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           RendererList = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
			//                            cullingLayerMask[0],
			//                            0,
			//                            0,
			//                            0x802060u,
			//                            sortingOrderMin[0],
			//                            sortingOrderMax[0],
			//                            cameraInstanceID,
			//                            (void *)klass._0.name,
			//                            0,
			//                            3.4028235e38,
			//                            0LL);
			//           if ( !v36 )
			//             sub_1802DC2C8(v45, v44);
			//           HIDWORD(v36[4].klass) = RendererList;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v60,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor.static_fields.s_UIRenderFunc,
			//             (Object *)v11,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::MultiblurPassConstructor::UIPassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v63 )
			//         {
			//           v59[0] = v63.ex;
			//           sub_180222690(v59);
			//           v11 = camera;
			//           v7 = (Object *)renderGraph;
			//           v9 = input;
			//           i = v50;
			//           goto LABEL_27;
			//         }
			//         sub_180222690(v59);
			// LABEL_27:
			//         v10 = this;
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::MultiblurPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         MultiblurPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2731, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2731, 0LL);
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
			// void HG::Rendering::Runtime::MultiblurPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         MultiblurPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D8EDAA2 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     byte_18D8EDAA2 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2732, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2732, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::UberPostPassUtils._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils, v5);
			//     HG::Rendering::Runtime::UberPostPassUtils::DisposeFrostedGlassPSMaterials(
			//       &this.fields.m_frostedGlassPSMaterials,
			//       0LL);
			//   }
			// }
			// 
		}

		private UberPostPassUtils.FrostedGlassPSMaterials m_frostedGlassPSMaterials;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<MultiblurPassConstructor.UIPassData> s_UIRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			public TextureHandle target;

			public HGRenderPipeline hgrp;

			public CullingResults cullingResults;

			public float screenCullingRatio;

			public float screenCullingRatioDistance;

			public uint screenCullingLayerMask;
		}

		internal struct PassOutput
		{
		}

		private class UIPassData
		{
			public UIPassData()
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

			public HGCamera camera;

			public TextureHandle sceneDepth;

			public CullingResults cullResult;

			public RendererListHandle renderList;

			public uint ecsRenderList;

			public uint hgUIRendererList;
		}
	}
}
