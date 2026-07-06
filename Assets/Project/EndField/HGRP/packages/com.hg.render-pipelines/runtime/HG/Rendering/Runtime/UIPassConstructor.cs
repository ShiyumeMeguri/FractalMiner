using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class UIPassConstructor : ComposablePass, IPassConstructor
	{
		public UIPassConstructor()
		{
			// // UIPassConstructor()
			// void HG::Rendering::Runtime::UIPassConstructor::UIPassConstructor(UIPassConstructor *this, MethodInfo *method)
			// {
			//   ProfilingSampler *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ProfilingSampler *v6; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   MethodInfo *v10; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v11; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDA58 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ProfilingSampler);
			//     sub_18003C530(&off_18C8F0338);
			//     byte_18D8EDA58 = 1;
			//   }
			//   v3 = (ProfilingSampler *)sub_180004920(TypeInfo::UnityEngine::Rendering::ProfilingSampler);
			//   v6 = v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   UnityEngine::Rendering::ProfilingSampler::ProfilingSampler(v3, (String *)"UI Culling", 0LL);
			//   this.fields.m_cullingSampler = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields, v7, v8, v9, v10, v11);
			// }
			// 
		}

		internal static void PrepareUIPassData(ref UIPassConstructor.PassInput input, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, UIPassConstructor.UIPassData passData)
		{
			// // Void PrepareUIPassData(UIPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, HGRenderGraphBuilder, UIPassConstructor+UIPassData)
			// void HG::Rendering::Runtime::UIPassConstructor::PrepareUIPassData(
			//         UIPassConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         HGRenderGraphBuilder *builder,
			//         UIPassConstructor_UIPassData *passData,
			//         MethodInfo *method)
			// {
			//   Object *v8; // rsi
			//   __int64 v10; // rdx
			//   Camera *static_fields; // rcx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   UIPassConstructor_UIPassData__Fields *p_fields; // rcx
			//   int32_t m_Mask; // edi
			//   MethodInfo *v16; // r8
			//   TextureHandle target; // xmm6
			//   int v18; // ebx
			//   _BYTE *m_CachedPtr; // rax
			//   HGRenderPipeline *hgrp; // r14
			//   CullingResults cullingResults; // xmm8
			//   ShaderTagId__Array *uiPassNames; // r14
			//   int32_t v23; // esi
			//   float screenCullingRatio; // xmm7_4
			//   float screenCullingRatioDistance; // xmm6_4
			//   uint32_t screenCullingLayerMask; // edi
			//   RendererListDesc *v27; // rax
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm1
			//   __int128 v31; // xmm0
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm0
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm0
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm0
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   RendererListHandle InvalidHandle; // rax
			//   char v41; // r14
			//   RendererListHandle v42; // rax
			//   uint32_t v43; // edi
			//   uint32_t RendererList; // eax
			//   Object__Class *klass; // rbx
			//   uint32_t v46; // eax
			//   uint32_t cullingViewHandle; // edi
			//   Object__Class *v48; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v50; // xmm1
			//   MethodInfo *sortingOrderMin; // [rsp+28h] [rbp-F0h]
			//   HGRenderKeyword__Enum sortingOrderMina; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *sortingOrderMax; // [rsp+30h] [rbp-E8h]
			//   int32_t cameraInstanceID; // [rsp+9Ch] [rbp-7Ch]
			//   uint32_t cullingLayerMask[4]; // [rsp+A8h] [rbp-70h] BYREF
			//   Color inputa; // [rsp+B8h] [rbp-60h] BYREF
			//   HGRenderGraphBuilder v57; // [rsp+C8h] [rbp-50h] BYREF
			//   RendererListDesc desc; // [rsp+E8h] [rbp-30h] BYREF
			//   RendererListDesc v59; // [rsp+1C8h] [rbp+B0h] BYREF
			// 
			//   v8 = (Object *)renderGraph;
			//   if ( !byte_18D919502 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::Nullable);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RenderQueueRange);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D919502 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2507, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2507, 0LL);
			//     if ( Patch )
			//     {
			//       v50 = *(_OWORD *)&builder.m_RenderGraph;
			//       *(_OWORD *)&v57.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//       *(_OWORD *)&v57.m_RenderGraph = v50;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_920(Patch, input, v8, (Object *)camera, &v57, (Object *)passData, 0LL);
			//       return;
			//     }
			//     goto LABEL_36;
			//   }
			//   if ( !passData )
			//     goto LABEL_36;
			//   p_fields = &passData.fields;
			//   if ( !camera )
			//   {
			//     passData.fields.camera = 0LL;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)p_fields,
			//       (HGRenderPathBase_HGRenderPathResources *)v10,
			//       v12,
			//       v13,
			//       sortingOrderMin,
			//       sortingOrderMax);
			//     return;
			//   }
			//   passData.fields.camera = camera;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)p_fields,
			//     (HGRenderPathBase_HGRenderPathResources *)v10,
			//     v12,
			//     v13,
			//     sortingOrderMin,
			//     sortingOrderMax);
			//   m_Mask = input.uiLayerMask.m_Mask;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//   *(_OWORD *)&v57.m_RenderPass = 0LL;
			//   *(Color *)&v57.m_RenderPass = *UnityEngine::Color::op_Implicit(&inputa, (Vector4 *)&v57, v16);
			//   HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//     (TextureHandle *)&inputa,
			//     builder,
			//     &input.target,
			//     0,
			//     (RenderBufferLoadAction__Enum)(m_Mask == TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.UI_3D_LAYER.m_Mask),
			//     RenderBufferStoreAction__Enum_Store,
			//     (Color *)&v57,
			//     0,
			//     0LL);
			//   target = input.target;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//   *(TextureHandle *)&v57.m_RenderPass = target;
			//   *(TextureHandle *)&v57.m_RenderPass = *HG::Rendering::Runtime::HGUtils::GeneratePairedDepthTarget(
			//                                            (TextureHandle *)&inputa,
			//                                            (HGRenderGraph *)v8,
			//                                            camera,
			//                                            (TextureHandle *)&v57,
			//                                            0LL);
			//   HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//     (TextureHandle *)&inputa,
			//     builder,
			//     (TextureHandle *)&v57,
			//     DepthAccess__Enum_ReadWrite,
			//     RenderBufferLoadAction__Enum_Clear,
			//     RenderBufferStoreAction__Enum_DontCare,
			//     1.0,
			//     0,
			//     0,
			//     0LL);
			//   if ( camera.fields.sortingOrdersToBlurInternal.m_Length <= 0 )
			//     LOWORD(v18) = 0x7FFF;
			//   else
			//     v18 = *(_DWORD *)camera.fields.sortingOrdersToBlurInternal.m_Buffer - 1;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//   static_fields = (Camera *)TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//   m_CachedPtr = static_fields[10].fields._._._.m_CachedPtr;
			//   if ( !m_CachedPtr )
			//     goto LABEL_36;
			//   if ( !m_CachedPtr[16] )
			//     goto LABEL_16;
			//   static_fields = camera.fields.camera;
			//   if ( !static_fields )
			//     goto LABEL_36;
			//   if ( (UnityEngine::Camera::get_cullingMask(static_fields, 0LL) & input.uiLayerMask.m_Mask) != 0 )
			//   {
			//     hgrp = input.hgrp;
			//     *(_QWORD *)&inputa.r = camera.fields.camera;
			//     cullingResults = input.cullingResults;
			//     if ( !hgrp )
			//       goto LABEL_36;
			//     uiPassNames = hgrp.fields.uiPassNames;
			//     v23 = input.uiLayerMask.m_Mask;
			//     screenCullingRatio = input.screenCullingRatio;
			//     screenCullingRatioDistance = input.screenCullingRatioDistance;
			//     screenCullingLayerMask = input.screenCullingLayerMask;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::RenderQueueRange);
			//     v57.m_RenderPass = (HGRenderGraphPass *)1;
			//     LODWORD(v57.m_Resources) = 0;
			//     sub_1802F01E0(&desc, 0LL, 112LL);
			//     LODWORD(v57.m_Resources) = 5000;
			//     *(CullingResults *)cullingLayerMask = cullingResults;
			//     v27 = HG::Rendering::Runtime::HGRendererListUtils::CreateUIRendererListDesc(
			//             &v59,
			//             (CullingResults *)cullingLayerMask,
			//             *(Camera **)&inputa.r,
			//             uiPassNames,
			//             v23,
			//             screenCullingRatio,
			//             screenCullingRatioDistance,
			//             screenCullingLayerMask,
			//             PerObjectData__Enum_None,
			//             (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v57,
			//             (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&desc,
			//             0LL,
			//             0,
			//             SortingCriteria__Enum_SortingLayer,
			//             0x8000,
			//             v18,
			//             0LL);
			//     v8 = (Object *)renderGraph;
			//     v10 = 128LL;
			//     v28 = *(_OWORD *)&v27.stateBlock.hasValue;
			//     *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v27.sortingCriteria;
			//     v29 = *(_OWORD *)&v27.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.stateBlock.hasValue = v28;
			//     v30 = *(_OWORD *)&v27.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v29;
			//     v31 = *(_OWORD *)&v27.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v30;
			//     v32 = *(_OWORD *)&v27.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v31;
			//     v33 = *(_OWORD *)&v27.stateBlock.value.m_RasterState.m_OffsetFactor;
			//     *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v32;
			//     *(_OWORD *)&desc.stateBlock.value.m_RasterState.m_OffsetFactor = v33;
			//     static_fields = (Camera *)&desc.overrideMaterial;
			//     v34 = *(_OWORD *)&v27.stateBlock.value.m_StencilState.m_FailOperationFront;
			//     v27 = (RendererListDesc *)((char *)v27 + 128);
			//     *(_OWORD *)&desc.stateBlock.value.m_StencilState.m_FailOperationFront = v34;
			//     v35 = *(_OWORD *)&v27.stateBlock.hasValue;
			//     *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v27.sortingCriteria;
			//     v36 = *(_OWORD *)&v27.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.overrideMaterialPassIndex = v35;
			//     v37 = *(_OWORD *)&v27.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.sortingLayerMin = v36;
			//     v38 = *(_OWORD *)&v27.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc.drawableFeedbackPtr = v37;
			//     v39 = *(_OWORD *)&v27.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//     *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = v38;
			//     *(_OWORD *)&desc._passName_k__BackingField.m_Id = v39;
			//     if ( !renderGraph )
			//       goto LABEL_36;
			//     InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//     v41 = 1;
			//   }
			//   else
			//   {
			// LABEL_16:
			//     v41 = 0;
			//     InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//   }
			//   *(RendererListHandle *)&inputa.r = InvalidHandle;
			//   v42 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//           builder,
			//           (RendererListHandle *)&inputa,
			//           0LL);
			//   v10 = 0LL;
			//   passData.fields.renderList = v42;
			//   v43 = -1;
			//   if ( v41 )
			//   {
			//     static_fields = camera.fields.camera;
			//     cullingLayerMask[0] = input.uiLayerMask.m_Mask;
			//     if ( !static_fields )
			//       goto LABEL_36;
			//     cameraInstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)static_fields, 0LL);
			//     if ( !v8 )
			//       goto LABEL_36;
			//     *(_QWORD *)&inputa.r = v8[6].klass;
			//     if ( !*(_QWORD *)&inputa.r )
			//       goto LABEL_36;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     RendererList = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
			//                      cullingLayerMask[0],
			//                      0,
			//                      0,
			//                      0x802060u,
			//                      0x8000,
			//                      v18,
			//                      cameraInstanceID,
			//                      *(void **)(*(_QWORD *)&inputa.r + 16LL),
			//                      0,
			//                      3.4028235e38,
			//                      0LL);
			//   }
			//   else
			//   {
			//     RendererList = -1;
			//   }
			//   passData.fields.hgUiHandle = RendererList;
			//   if ( v41 )
			//   {
			//     cullingLayerMask[0] = camera.fields.cullingViewHandle;
			//     if ( !v8 )
			//       goto LABEL_36;
			//     klass = v8[6].klass;
			//     if ( !klass )
			//       goto LABEL_36;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     LOWORD(sortingOrderMina) = 0;
			//     v46 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//             cullingLayerMask[0],
			//             HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
			//             HGRenderFlags__Enum_Transparent,
			//             HGShaderLightMode__Enum_SRPDefaultUnlit|HGShaderLightMode__Enum_Forward|HGShaderLightMode__Enum_ForwardOnly,
			//             sortingOrderMina,
			//             (void *)klass._0.name,
			//             0,
			//             1,
			//             input.uiLayerMask.m_Mask,
			//             0,
			//             0,
			//             0LL);
			//   }
			//   else
			//   {
			//     v46 = -1;
			//   }
			//   passData.fields.ecsRenderList = v46;
			//   if ( !v41 )
			//     goto LABEL_32;
			//   cullingViewHandle = camera.fields.cullingViewHandle;
			//   if ( !v8 || (v48 = v8[6].klass) == 0LL )
			// LABEL_36:
			//     sub_180B536AC(static_fields, v10);
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//   LOWORD(sortingOrderMina) = 0;
			//   v43 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//           cullingViewHandle,
			//           HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
			//           HGRenderFlags__Enum_Transparent,
			//           HGShaderLightMode__Enum_ForwardAfterUI,
			//           sortingOrderMina,
			//           (void *)v48._0.name,
			//           0,
			//           1,
			//           input.uiLayerMask.m_Mask,
			//           0,
			//           0,
			//           0LL);
			// LABEL_32:
			//   passData.fields.afterUIEcsRenderList = v43;
			//   passData.fields.sceneDepth = input.sceneDepth;
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneDepth, 0LL) )
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//       (TextureHandle *)&v57,
			//       builder,
			//       &input.sceneDepth,
			//       0LL);
			// }
			// 
		}

		private bool CullUI(CommandBuffer cmd, ScriptableRenderContext ctx, Camera camera, LayerMask uiLayerMask, out CullingResults cullResults)
		{
			// // Boolean CullUI(CommandBuffer, ScriptableRenderContext, Camera, LayerMask, CullingResults ByRef)
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// bool HG::Rendering::Runtime::UIPassConstructor::CullUI(
			//         UIPassConstructor *this,
			//         CommandBuffer *cmd,
			//         ScriptableRenderContext ctx,
			//         Camera *camera,
			//         LayerMask uiLayerMask,
			//         CullingResults *cullResults,
			//         MethodInfo *method)
			// {
			//   bool v11; // di
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   CullingResults *v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   char v19; // [rsp+40h] [rbp-688h]
			//   char v20; // [rsp+41h] [rbp-687h] BYREF
			//   __int64 v21; // [rsp+48h] [rbp-680h]
			//   char *v22; // [rsp+50h] [rbp-678h]
			//   CullingResults v23; // [rsp+60h] [rbp-668h] BYREF
			//   ScriptableCullingParameters cullingParameters; // [rsp+70h] [rbp-658h] BYREF
			//   ScriptableRenderContext v25; // [rsp+6E0h] [rbp+18h] BYREF
			// 
			//   v25.m_Ptr = ctx.m_Ptr;
			//   v11 = 0;
			//   if ( !byte_18D919503 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919503 = 1;
			//   }
			//   v20 = 0;
			//   sub_1802F01E0(&cullingParameters, 0LL, 1592LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2508, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2508, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v18, v17);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_921(
			//              Patch,
			//              (Object *)this,
			//              (Object *)cmd,
			//              ctx,
			//              (Object *)camera,
			//              uiLayerMask,
			//              cullResults,
			//              0LL);
			//   }
			//   else
			//   {
			//     v19 = 0;
			//     v21 = 0LL;
			//     v22 = &v20;
			//     if ( !camera )
			//       sub_1802DC2C8(v13, v12);
			//     if ( UnityEngine::Camera::GetCullingParameters_Internal(camera, 0, &cullingParameters, 1592, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//       cullingParameters.m_CameraProperties.cameraWorldToClip.m31 = 0.0;
			//       LODWORD(cullingParameters.m_CameraProperties.cameraFar) = (LayerMask)uiLayerMask.m_Mask;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       v14 = UnityEngine::Rendering::ScriptableRenderContext::Cull(&v23, &v25, &cullingParameters, 0LL);
			//       *cullResults = *v14;
			//       v11 = 1;
			//       v19 = 1;
			//     }
			//     else
			//     {
			//       *cullResults = 0LL;
			//     }
			//     return v11;
			//   }
			// }
			// 
			return default(bool);
		}

		protected override Nullable<HGRenderGraphBuilder> GetRenderGraphBuilder(HGRenderGraph renderGraph)
		{
			// // Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] GetRenderGraphBuilder(HGRenderGraph)
			// Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::UIPassConstructor::GetRenderGraphBuilder(
			//         Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
			//         UIPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   __int128 v7; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v12; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919504 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::RenderGraphModule::HGRenderGraphBuilder>::Nullable);
			//     byte_18D919504 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2509, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2509, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_900(&v12, Patch, (Object *)this, (Object *)renderGraph, 0LL);
			//   }
			//   else
			//   {
			//     v7 = *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderGraph;
			//     *(_OWORD *)&v12.hasValue = *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderPass;
			//     *(_OWORD *)&retstr.hasValue = 0LL;
			//     *(_OWORD *)&retstr.value.m_Resources = 0LL;
			//     *(_QWORD *)&retstr.value.m_Disposed = 0LL;
			//     *(_OWORD *)&v12.value.m_Resources = v7;
			//     sub_18040CC8C(retstr, &v12);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::UIPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         UIPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2510, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2510, 0LL);
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
			// void HG::Rendering::Runtime::UIPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         UIPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2511, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2511, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			//   else
			//   {
			//     *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderPass = 0LL;
			//     *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderGraph = 0LL;
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref UIPassConstructor.PassInput input, ref UIPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera, HGSettingParameters settingParameters)
		{
			// // Void ConstructPass(UIPassConstructor+PassInput ByRef, UIPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::UIPassConstructor::ConstructPass(
			//         UIPassConstructor *this,
			//         UIPassConstructor_PassInput *input,
			//         UIPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   int32_t m_Mask; // ebx
			//   __int64 v12; // rdx
			//   HGUtils__StaticFields *static_fields; // rcx
			//   char *v14; // rsi
			//   unsigned __int64 v15; // r8
			//   signed __int64 v16; // rtt
			//   UIPassConstructor_UIPassData *v17; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   UIPassConstructor_UIPassData *v21; // [rsp+40h] [rbp-98h] BYREF
			//   _QWORD v22[2]; // [rsp+48h] [rbp-90h] BYREF
			//   HGRenderGraphBuilder v23; // [rsp+58h] [rbp-80h] BYREF
			//   HGRenderGraphBuilder v24; // [rsp+80h] [rbp-58h] BYREF
			//   HGRenderGraphBuilder v25; // [rsp+A0h] [rbp-38h] BYREF
			//   Il2CppExceptionWrapper *v26; // [rsp+C0h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919505 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIPassConstructor::UIPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UIPassConstructor::UIPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//     sub_18003C530(&off_18D4F5CD0);
			//     sub_18003C530(&off_18D4F5C80);
			//     byte_18D919505 = 1;
			//   }
			//   v21 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2512, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2512, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v20, v19);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_922(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       output,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       (Object *)settingParameters,
			//       0LL);
			//   }
			//   else
			//   {
			//     m_Mask = input.uiLayerMask.m_Mask;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields;
			//     v14 = "3D UI Pass";
			//     if ( m_Mask == static_fields.UI_2D_LAYER.m_Mask )
			//       v14 = "2D UI Pass";
			//     if ( !renderGraph )
			//       sub_180B536AC(static_fields, v12);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v25,
			//       renderGraph,
			//       (String *)v14,
			//       (Object **)&v21,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UIPassConstructor::UIPassData>);
			//     v23 = v25;
			//     v22[0] = 0LL;
			//     v22[1] = &v23;
			//     try
			//     {
			//       *(_OWORD *)&v24.m_RenderPass = *(_OWORD *)&v23.m_RenderPass;
			//       *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderPass = *(_OWORD *)&v23.m_RenderPass;
			//       *(_OWORD *)&v25.m_RenderPass = *(_OWORD *)&v23.m_RenderGraph;
			//       *(_OWORD *)&this.fields.m_renderGraphBuilder.m_RenderGraph = *(_OWORD *)&v23.m_RenderGraph;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v15 = (((unsigned __int64)&this.fields.m_renderGraphBuilder >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6870D0[v15]);
			//         do
			//           v16 = qword_18D6870D0[v15];
			//         while ( v16 != _InterlockedCompareExchange64(
			//                          &qword_18D6870D0[v15],
			//                          v16 | (1LL << (((unsigned __int64)&this.fields.m_renderGraphBuilder >> 12) & 0x3F)),
			//                          v16) );
			//         *(_OWORD *)&v25.m_RenderPass = *(_OWORD *)&v23.m_RenderGraph;
			//         *(_OWORD *)&v24.m_RenderPass = *(_OWORD *)&v23.m_RenderPass;
			//       }
			//       v17 = v21;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//       *(_OWORD *)&v24.m_RenderGraph = *(_OWORD *)&v25.m_RenderPass;
			//       HG::Rendering::Runtime::UIPassConstructor::PrepareUIPassData(input, renderGraph, camera, &v24, v17, 0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v23,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UIPassConstructor.static_fields.s_UIRenderFunc,
			//         (Object *)camera,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIPassConstructor::UIPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v26 )
			//     {
			//       v22[0] = v26.ex;
			//     }
			//     sub_180222690(v22);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::UIPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         UIPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2513, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2513, 0LL);
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
			// void HG::Rendering::Runtime::UIPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         UIPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2514, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2514, 0LL);
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

		public Nullable<HGRenderGraphBuilder> <>iFixBaseProxy_GetRenderGraphBuilder(HGRenderGraph P0)
		{
			// // Nullable`1[HG.Rendering.RenderGraphModule.HGRenderGraphBuilder] <>iFixBaseProxy_GetRenderGraphBuilder(HGRenderGraph)
			// Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::__iFixBaseProxy_GetRenderGraphBuilder(
			//         Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *__return_ptr retstr,
			//         ScreenSpaceOverlayPassConstructor *this,
			//         HGRenderGraph *P0,
			//         MethodInfo *method)
			// {
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *RenderGraphBuilder; // rax
			//   __int128 v6; // xmm1
			//   __int64 v7; // xmm0_8
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ *result; // rax
			//   Nullable_1_HG_Rendering_RenderGraphModule_HGRenderGraphBuilder_ v9; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   RenderGraphBuilder = HG::Rendering::Runtime::ComposablePass::GetRenderGraphBuilder(
			//                          &v9,
			//                          (ComposablePass *)this,
			//                          P0,
			//                          0LL);
			//   v6 = *(_OWORD *)&RenderGraphBuilder.value.m_Resources;
			//   *(_OWORD *)&retstr.hasValue = *(_OWORD *)&RenderGraphBuilder.hasValue;
			//   v7 = *(_QWORD *)&RenderGraphBuilder.value.m_Disposed;
			//   result = retstr;
			//   *(_OWORD *)&retstr.value.m_Resources = v6;
			//   *(_QWORD *)&retstr.value.m_Disposed = v7;
			//   return result;
			// }
			// 
			return null;
		}

		private const string UI_2D_PASS_NAME = "2D UI Pass";

		private const string UI_3D_PASS_NAME = "3D UI Pass";

		private ProfilingSampler m_cullingSampler;

		private HGRenderGraphBuilder m_renderGraphBuilder;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		internal static readonly RenderFunc<UIPassConstructor.UIPassData> s_UIRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal CullingResults cullingResults;

			internal LayerMask uiLayerMask;

			internal float renderingScale;

			internal TextureHandle target;

			internal TextureHandle sceneDepth;

			internal HGRenderPipeline hgrp;

			internal float screenCullingRatio;

			internal float screenCullingRatioDistance;

			internal uint screenCullingLayerMask;
		}

		internal struct PassOutput
		{
		}

		internal class UIPassData
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

			public uint ecsRenderList;

			public uint afterUIEcsRenderList;

			public uint hgUiHandle;

			public CullingResults cullResult;

			public RendererListHandle renderList;
		}

		private class BlitBackBufferData
		{
			public BlitBackBufferData()
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

			public TextureHandle inputBuffer;

			public TextureHandle outputBuffer;

			public Material blitMaterial;

			public HGCamera camera;
		}
	}
}
