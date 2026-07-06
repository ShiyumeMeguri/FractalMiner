using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal static class DeferredLightingPass
	{
		internal static DeferredLightingPass.DeferredLightingRenderParams InitDeferredLightingRenderParams(bool isOnePassDeferred)
		{
			// // DeferredLightingPass+DeferredLightingRenderParams InitDeferredLightingRenderParams(Boolean)
			// DeferredLightingPass_DeferredLightingRenderParams *HG::Rendering::Runtime::DeferredLightingPass::InitDeferredLightingRenderParams(
			//         DeferredLightingPass_DeferredLightingRenderParams *__return_ptr retstr,
			//         bool isOnePassDeferred,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   struct HGGraphicsFeatureManager__Class *v6; // rcx
			//   HGGraphicsFeatureSwitch *deferredShadingDefaultLit; // rax
			//   HGGraphicsFeatureSwitch *deferredShadingTwoSidedFoliage; // rax
			//   HGGraphicsFeatureSwitch *deferredShadingSubsurface; // rax
			//   HGGraphicsFeatureSwitch *splitDeferredShadingStage; // rax
			//   HGGraphicsFeatureSwitch *usePerLightDynamicLighting; // rax
			//   HGGraphicsFeatureSwitch *deferredShadingDirectionalLightStage; // rax
			//   HGGraphicsFeatureSwitch *deferredShadingDynamicLightStage; // rax
			//   HGGraphicsFeatureSwitch *deferredShadingIndirectStage; // rax
			//   HGGraphicsFeatureSwitch *usePerTileDeferredLighting; // rax
			//   __int128 v16; // xmm1
			//   GraphicsBuffer *quadIndexBuffer; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   DeferredLightingPass_DeferredLightingRenderParams *v19; // rax
			//   DeferredLightingPass_DeferredLightingRenderParams *result; // rax
			//   DeferredLightingPass_DeferredLightingRenderParams v21; // [rsp+20h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919516 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     byte_18D919516 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2532, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2532, 0LL);
			//     if ( Patch )
			//     {
			//       v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_929(&v21, Patch, isOnePassDeferred, 0LL);
			//       v16 = *(_OWORD *)&v19.drawTileArgs.handle._type_k__BackingField;
			//       *(_OWORD *)&retstr.enableDeferredShadingDefaultLit = *(_OWORD *)&v19.enableDeferredShadingDefaultLit;
			//       quadIndexBuffer = v19.quadIndexBuffer;
			//       goto LABEL_19;
			//     }
			// LABEL_17:
			//     sub_180B536AC(v6, v5);
			//   }
			//   *(_OWORD *)&v21.enableDeferredShadingDefaultLit = 0LL;
			//   v21.quadIndexBuffer = 0LL;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//   v6 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
			//   deferredShadingDefaultLit = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.deferredShadingDefaultLit;
			//   if ( !deferredShadingDefaultLit )
			//     goto LABEL_17;
			//   v21.enableDeferredShadingDefaultLit = deferredShadingDefaultLit.fields.m_defaultValue;
			//   deferredShadingTwoSidedFoliage = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.deferredShadingTwoSidedFoliage;
			//   if ( !deferredShadingTwoSidedFoliage )
			//     goto LABEL_17;
			//   v21.enableDeferredShadingTwoSidedFoliage = deferredShadingTwoSidedFoliage.fields.m_defaultValue;
			//   deferredShadingSubsurface = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.deferredShadingSubsurface;
			//   if ( !deferredShadingSubsurface )
			//     goto LABEL_17;
			//   v21.enableDeferredShadingSubsurface = deferredShadingSubsurface.fields.m_defaultValue;
			//   splitDeferredShadingStage = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.splitDeferredShadingStage;
			//   if ( !splitDeferredShadingStage )
			//     goto LABEL_17;
			//   v21.splitDeferredShadingStage = splitDeferredShadingStage.fields.m_defaultValue;
			//   usePerLightDynamicLighting = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.usePerLightDynamicLighting;
			//   if ( !usePerLightDynamicLighting )
			//     goto LABEL_17;
			//   v21.usePerLightDynamicLighting = usePerLightDynamicLighting.fields.m_defaultValue;
			//   deferredShadingDirectionalLightStage = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.deferredShadingDirectionalLightStage;
			//   if ( !deferredShadingDirectionalLightStage )
			//     goto LABEL_17;
			//   v21.enableDeferredShadingDirectionalLightStage = deferredShadingDirectionalLightStage.fields.m_defaultValue;
			//   deferredShadingDynamicLightStage = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.deferredShadingDynamicLightStage;
			//   if ( !deferredShadingDynamicLightStage )
			//     goto LABEL_17;
			//   v21.enableDeferredShadingDynamicLightStage = deferredShadingDynamicLightStage.fields.m_defaultValue;
			//   deferredShadingIndirectStage = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.deferredShadingIndirectStage;
			//   if ( !deferredShadingIndirectStage )
			//     goto LABEL_17;
			//   v21.enableDeferredShadingIndirectStage = deferredShadingIndirectStage.fields.m_defaultValue;
			//   usePerTileDeferredLighting = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.usePerTileDeferredLighting;
			//   if ( !usePerTileDeferredLighting )
			//     goto LABEL_17;
			//   v21.enableDeferredShadingTileDraw = usePerTileDeferredLighting.fields.m_defaultValue;
			//   if ( !isOnePassDeferred )
			//   {
			//     v21.splitDeferredShadingStage = 0;
			//     v21.enableDeferredShadingTileDraw = 0;
			//   }
			//   v16 = 0LL;
			//   *(_OWORD *)&retstr.enableDeferredShadingDefaultLit = *(_OWORD *)&v21.enableDeferredShadingDefaultLit;
			//   quadIndexBuffer = v21.quadIndexBuffer;
			// LABEL_19:
			//   result = retstr;
			//   *(_OWORD *)&retstr.drawTileArgs.handle._type_k__BackingField = v16;
			//   retstr.quadIndexBuffer = quadIndexBuffer;
			//   return result;
			// }
			// 
			return default(DeferredLightingPass.DeferredLightingRenderParams);
		}

		internal static void DrawDeferredLighting(HGRenderGraphContext context, CommandBuffer cmd, Material deferredLightingMaterial, DeferredLightingPass.DeferredLightingRenderParams renderParams)
		{
			// // Void DrawDeferredLighting(HGRenderGraphContext, CommandBuffer, Material, DeferredLightingPass+DeferredLightingRenderParams)
			// void HG::Rendering::Runtime::DeferredLightingPass::DrawDeferredLighting(
			//         HGRenderGraphContext *context,
			//         CommandBuffer *cmd,
			//         Material *deferredLightingMaterial,
			//         DeferredLightingPass_DeferredLightingRenderParams *renderParams,
			//         MethodInfo *method)
			// {
			//   __int128 v9; // xmm0
			//   __int64 v10; // rax
			//   GraphicsBuffer *quadIndexBuffer; // xmm1_8
			//   unsigned __int128 v12; // xmm1
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   GraphicsBuffer *v14; // xmm0_8
			//   int32_t TileInstanceIndicesBuffer; // r14d
			//   ComputeBuffer *v16; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   __int128 v19; // xmm1
			//   _OWORD *v20; // rax
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   ComputeBuffer *v23; // rax
			//   _OWORD *v24; // rax
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   ComputeBuffer *v27; // rax
			//   int32_t v28; // r9d
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v30; // xmm1
			//   Matrix4x4 v31; // [rsp+58h] [rbp-B0h] BYREF
			//   Matrix4x4 v32; // [rsp+98h] [rbp-70h] BYREF
			//   Matrix4x4 v33; // [rsp+D8h] [rbp-30h]
			// 
			//   if ( !byte_18D919517 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D919517 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2533, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2533, 0LL);
			//     if ( Patch )
			//     {
			//       v30 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//       *(_OWORD *)&v31.m00 = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//       *(_QWORD *)&v31.m02 = renderParams.quadIndexBuffer;
			//       *(_OWORD *)&v31.m01 = v30;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_930(
			//         Patch,
			//         (Object *)context,
			//         (Object *)cmd,
			//         (Object *)deferredLightingMaterial,
			//         (DeferredLightingPass_DeferredLightingRenderParams *)&v31,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_30;
			//   }
			//   v9 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//   v10 = *(_QWORD *)&renderParams.enableDeferredShadingDefaultLit >> 24;
			//   quadIndexBuffer = renderParams.quadIndexBuffer;
			//   *(_QWORD *)&v31.m02 = quadIndexBuffer;
			//   *(_OWORD *)&v31.m01 = v9;
			//   if ( !(_BYTE)v10 )
			//   {
			//     *(_OWORD *)&v31.m01 = v9;
			//     *(_QWORD *)&v31.m02 = quadIndexBuffer;
			//     if ( !renderParams.enableDeferredShadingDefaultLit )
			//       goto LABEL_10;
			//     *(_OWORD *)&v31.m01 = v9;
			//     *(_QWORD *)&v31.m02 = quadIndexBuffer;
			//     if ( !renderParams.enableDeferredShadingTileDraw )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 0, 0LL);
			//       goto LABEL_10;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     v12 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//     *(_OWORD *)&v32.m00 = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//     v14 = renderParams.quadIndexBuffer;
			//     *(_OWORD *)&v32.m01 = v12;
			//     TileInstanceIndicesBuffer = static_fields._TileInstanceIndicesBuffer;
			//     *(_QWORD *)&v32.m02 = v14;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::ComputeBufferHandle);
			//     v16 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit((ComputeBufferHandle)(v12 >> 32), 0LL);
			//     if ( cmd )
			//     {
			//       UnityEngine::Rendering::CommandBuffer::SetGlobalBufferInternal(cmd, TileInstanceIndicesBuffer, v16, 0LL);
			//       v19 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//       *(_OWORD *)&v31.m00 = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//       *(_QWORD *)&v31.m02 = renderParams.quadIndexBuffer;
			//       *(_OWORD *)&v31.m01 = v19;
			//       v20 = (_OWORD *)sub_182805160(&v32);
			//       v21 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//       *(_OWORD *)&v33.m00 = *v20;
			//       *(_OWORD *)&v33.m01 = v20[1];
			//       *(_OWORD *)&v33.m02 = v20[2];
			//       v22 = v20[3];
			//       *(_OWORD *)&v32.m01 = v21;
			//       *(_OWORD *)&v33.m03 = v22;
			//       *(_OWORD *)&v32.m00 = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//       *(_QWORD *)&v32.m02 = renderParams.quadIndexBuffer;
			//       v23 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(*(ComputeBufferHandle *)&v32.m30, 0LL);
			//       v32 = v33;
			//       UnityEngine::Rendering::CommandBuffer::DrawProceduralIndirect(
			//         cmd,
			//         *(GraphicsBuffer **)&v31.m02,
			//         &v32,
			//         deferredLightingMaterial,
			//         12,
			//         MeshTopology__Enum_Triangles,
			//         v23,
			//         0LL);
			//       *(_QWORD *)&v32.m02 = renderParams.quadIndexBuffer;
			//       v24 = (_OWORD *)sub_182805160(&v31);
			//       v25 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//       *(_OWORD *)&v33.m03 = *v24;
			//       *(_OWORD *)&v33.m02 = v24[1];
			//       *(_OWORD *)&v33.m01 = v24[2];
			//       v26 = v24[3];
			//       *(_OWORD *)&v31.m01 = v25;
			//       *(_OWORD *)&v33.m00 = v26;
			//       *(_OWORD *)&v31.m00 = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//       *(_QWORD *)&v31.m02 = renderParams.quadIndexBuffer;
			//       v27 = HG::Rendering::RenderGraphModule::ComputeBufferHandle::op_Implicit(*(ComputeBufferHandle *)&v31.m30, 0LL);
			//       *(_OWORD *)&v31.m00 = *(_OWORD *)&v33.m03;
			//       *(_OWORD *)&v31.m01 = *(_OWORD *)&v33.m02;
			//       *(_OWORD *)&v31.m02 = *(_OWORD *)&v33.m01;
			//       *(_OWORD *)&v31.m03 = *(_OWORD *)&v33.m00;
			//       UnityEngine::Rendering::CommandBuffer::DrawProceduralIndirect(
			//         cmd,
			//         *(GraphicsBuffer **)&v32.m02,
			//         &v31,
			//         deferredLightingMaterial,
			//         13,
			//         MeshTopology__Enum_Triangles,
			//         v27,
			//         20,
			//         0LL);
			// LABEL_10:
			//       if ( BYTE1(*(_QWORD *)&renderParams.enableDeferredShadingDefaultLit) )
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//         UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 1, 0LL);
			//       }
			//       if ( (unsigned __int8)BYTE2(*(_QWORD *)&renderParams.enableDeferredShadingDefaultLit) )
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//         v28 = 2;
			// LABEL_14:
			//         UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, v28, 0LL);
			//         return;
			//       }
			//       return;
			//     }
			// LABEL_30:
			//     sub_180B536AC(v18, v17);
			//   }
			//   if ( (unsigned __int16)WORD2(*(_QWORD *)&renderParams.enableDeferredShadingDefaultLit) >> 8 )
			//   {
			//     if ( renderParams.enableDeferredShadingDefaultLit )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 3, 0LL);
			//     }
			//     if ( BYTE1(*(_QWORD *)&renderParams.enableDeferredShadingDefaultLit) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 4, 0LL);
			//     }
			//     if ( (unsigned __int8)BYTE2(*(_QWORD *)&renderParams.enableDeferredShadingDefaultLit) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 5, 0LL);
			//     }
			//   }
			//   if ( HIBYTE(*(_QWORD *)&renderParams.enableDeferredShadingDefaultLit) )
			//   {
			//     if ( renderParams.enableDeferredShadingDefaultLit )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 9, 0LL);
			//     }
			//     if ( BYTE1(*(_QWORD *)&renderParams.enableDeferredShadingDefaultLit) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingMaterial, 0LL, 10, 0LL);
			//     }
			//     if ( (unsigned __int8)BYTE2(*(_QWORD *)&renderParams.enableDeferredShadingDefaultLit) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       v28 = 11;
			//       goto LABEL_14;
			//     }
			//   }
			// }
			// 
		}

		internal static void DrawPerLightDeferredLighting(HGRenderGraphContext context, CommandBuffer cmd, DeferredLightingPass.DeferredLightingRenderParams renderParams, int punctualLightCount, DeferredLightingPass.LightMeshDrawRequest[] drawRequests, Material deferredLightingPerLightMaterial, Mesh sphereMesh, Mesh coneMesh)
		{
			// // Void DrawPerLightDeferredLighting(HGRenderGraphContext, CommandBuffer, DeferredLightingPass+DeferredLightingRenderParams, Int32, DeferredLightingPass+LightMeshDrawRequest[], Material, Mesh, Mesh)
			// void HG::Rendering::Runtime::DeferredLightingPass::DrawPerLightDeferredLighting(
			//         HGRenderGraphContext *context,
			//         CommandBuffer *cmd,
			//         DeferredLightingPass_DeferredLightingRenderParams *renderParams,
			//         int32_t punctualLightCount,
			//         DeferredLightingPass_LightMeshDrawRequest__Array *drawRequests,
			//         Material *deferredLightingPerLightMaterial,
			//         Mesh *sphereMesh,
			//         Mesh *coneMesh,
			//         MethodInfo *method)
			// {
			//   HGShaderIDs__StaticFields *static_fields; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Void *m_Buffer; // r14
			//   Void *v16; // rsi
			//   int32_t v17; // r15d
			//   int32_t v18; // ebx
			//   int32_t v19; // r12d
			//   __int64 v20; // rax
			//   Void *v21; // r15
			//   __int64 v22; // rax
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm2
			//   __int128 v25; // xmm3
			//   __int64 v26; // rax
			//   Void *v27; // r15
			//   __int64 v28; // rax
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm2
			//   __int128 v31; // xmm3
			//   MaterialPropertyBlock *s_coneMpb; // rbx
			//   MaterialPropertyBlock *v33; // rbx
			//   NativeArray_1_UnityEngine_Matrix4x4_ v34; // xmm6
			//   __int128 v35; // xmm13
			//   __int128 v36; // xmm12
			//   __int128 v37; // xmm11
			//   __int128 v38; // xmm10
			//   __int128 v39; // xmm9
			//   __int128 v40; // xmm8
			//   __int128 v41; // xmm7
			//   DeferredLightingPass__StaticFields *v42; // rcx
			//   MaterialPropertyBlock *v43; // rax
			//   DeferredLightingPass__StaticFields *v44; // rcx
			//   MaterialPropertyBlock *v45; // rax
			//   MaterialPropertyBlock *s_sphereMpb; // rbx
			//   MaterialPropertyBlock *v47; // rbx
			//   NativeArray_1_UnityEngine_Matrix4x4_ v48; // xmm6
			//   __int128 v49; // xmm13
			//   __int128 v50; // xmm12
			//   __int128 v51; // xmm11
			//   __int128 v52; // xmm10
			//   __int128 v53; // xmm9
			//   __int128 v54; // xmm8
			//   __int128 v55; // xmm7
			//   DeferredLightingPass__StaticFields *v56; // rcx
			//   MaterialPropertyBlock *v57; // rax
			//   DeferredLightingPass__StaticFields *v58; // rcx
			//   MaterialPropertyBlock *v59; // rax
			//   __int128 v60; // xmm1
			//   GraphicsBuffer *quadIndexBuffer; // xmm0_8
			//   int32_t v62; // [rsp+58h] [rbp-B0h]
			//   __int64 v63; // [rsp+60h] [rbp-A8h]
			//   NativeArray_1_UnityEngine_Matrix4x4_ v64; // [rsp+68h] [rbp-A0h] BYREF
			//   NativeArray_1_UnityEngine_Matrix4x4_ v65; // [rsp+78h] [rbp-90h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v66; // [rsp+88h] [rbp-80h] BYREF
			//   Void *v67; // [rsp+F8h] [rbp-10h]
			//   Void *v68; // [rsp+100h] [rbp-8h]
			//   NativeArray_1_System_UInt32_ v69; // [rsp+108h] [rbp+0h] BYREF
			//   NativeArray_1_System_UInt32_ v70; // [rsp+118h] [rbp+10h] BYREF
			//   DeferredLightingPass_DeferredLightingRenderParams v71; // [rsp+128h] [rbp+20h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v72[2]; // [rsp+158h] [rbp+50h] BYREF
			// 
			//   if ( !byte_18D919518 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray);
			//     byte_18D919518 = 1;
			//   }
			//   v69 = 0LL;
			//   v70 = 0LL;
			//   v64 = 0LL;
			//   v65 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2534, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2534, 0LL);
			//     if ( !Patch )
			//       goto LABEL_23;
			//     v60 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//     *(_OWORD *)&v71.enableDeferredShadingDefaultLit = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//     quadIndexBuffer = renderParams.quadIndexBuffer;
			//     *(_OWORD *)&v71.drawTileArgs.handle._type_k__BackingField = v60;
			//     v71.quadIndexBuffer = quadIndexBuffer;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_931(
			//       Patch,
			//       (Object *)context,
			//       (Object *)cmd,
			//       &v71,
			//       punctualLightCount,
			//       (Object *)drawRequests,
			//       (Object *)deferredLightingPerLightMaterial,
			//       (Object *)sphereMesh,
			//       (Object *)coneMesh,
			//       0LL);
			//   }
			//   else if ( BYTE3(*(_QWORD *)&renderParams.enableDeferredShadingDefaultLit) )
			//   {
			//     Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//       &v69,
			//       32,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
			//     Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//       &v70,
			//       32,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
			//     Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray(
			//       &v64,
			//       32,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray);
			//     Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray(
			//       &v65,
			//       32,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray);
			//     if ( punctualLightCount > 0 )
			//     {
			//       m_Buffer = v64.m_Buffer;
			//       v16 = v65.m_Buffer;
			//       v68 = v69.m_Buffer;
			//       v67 = v70.m_Buffer;
			//       v17 = 0;
			//       v18 = 0;
			//       v62 = 0;
			//       if ( !drawRequests )
			//         goto LABEL_23;
			//       v19 = 0;
			//       do
			//       {
			//         v63 = v17;
			//         if ( *(_DWORD *)sub_18046F890(drawRequests, v18) )
			//         {
			//           v20 = sub_18046F890(drawRequests, v17);
			//           v21 = v67;
			//           *(float *)v67 = (float)*(int *)(v20 + 68);
			//           v22 = sub_18046F890(drawRequests, v63);
			//           ++v62;
			//           v67 = v21 + 4;
			//           v23 = *(_OWORD *)(v22 + 20);
			//           v24 = *(_OWORD *)(v22 + 36);
			//           v25 = *(_OWORD *)(v22 + 52);
			//           *(_OWORD *)v16 = *(_OWORD *)(v22 + 4);
			//           *(_OWORD *)&v16[16] = v23;
			//           *(_OWORD *)&v16[32] = v24;
			//           *(_OWORD *)&v16[48] = v25;
			//           v16 += 64;
			//         }
			//         else
			//         {
			//           v26 = sub_18046F890(drawRequests, v17);
			//           v27 = v68;
			//           *(float *)v68 = (float)*(int *)(v26 + 68);
			//           v28 = sub_18046F890(drawRequests, v63);
			//           ++v19;
			//           v68 = v27 + 4;
			//           v29 = *(_OWORD *)(v28 + 20);
			//           v30 = *(_OWORD *)(v28 + 36);
			//           v31 = *(_OWORD *)(v28 + 52);
			//           *(_OWORD *)m_Buffer = *(_OWORD *)(v28 + 4);
			//           *(_OWORD *)&m_Buffer[16] = v29;
			//           *(_OWORD *)&m_Buffer[32] = v30;
			//           *(_OWORD *)&m_Buffer[48] = v31;
			//           m_Buffer += 64;
			//         }
			//         v17 = ++v18;
			//       }
			//       while ( v18 < punctualLightCount );
			//       if ( v19 )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
			//         Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::DeferredLightingPass.static_fields.s_coneMpb;
			//         if ( !Patch )
			//           goto LABEL_23;
			//         UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)Patch, 1, 0LL);
			//         s_coneMpb = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass.static_fields.s_coneMpb;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         if ( !s_coneMpb )
			//           goto LABEL_23;
			//         UnityEngine::MaterialPropertyBlock::SetFloatArray(
			//           s_coneMpb,
			//           static_fields._PerLightIndex,
			//           (NativeArray_1_System_Single_ *)&v69,
			//           0LL);
			//         v33 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass.static_fields.s_coneMpb;
			//         sub_1802F01E0(v72, 0LL, 112LL);
			//         if ( !cmd )
			//           goto LABEL_23;
			//         v34 = v64;
			//         v35 = *(_OWORD *)&v72[0].hasValue;
			//         v36 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//         v37 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//         v38 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//         v39 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//         v40 = *(_OWORD *)&v72[0].value.m_RasterState.m_OffsetFactor;
			//         v41 = *(_OWORD *)&v72[0].value.m_StencilState.m_FailOperationFront;
			//         v66 = v72[0];
			//         UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
			//           cmd,
			//           coneMesh,
			//           0,
			//           deferredLightingPerLightMaterial,
			//           0,
			//           &v64,
			//           v19,
			//           v33,
			//           &v66,
			//           0LL);
			//         *(_OWORD *)&v66.hasValue = v35;
			//         *(_OWORD *)&v66.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v36;
			//         v42 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass.static_fields;
			//         *(_OWORD *)&v66.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v37;
			//         *(_OWORD *)&v66.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v38;
			//         *(_OWORD *)&v66.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v39;
			//         v43 = v42.s_coneMpb;
			//         *(_OWORD *)&v66.value.m_RasterState.m_OffsetFactor = v40;
			//         *(_OWORD *)&v66.value.m_StencilState.m_FailOperationFront = v41;
			//         v64 = v34;
			//         UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
			//           cmd,
			//           coneMesh,
			//           0,
			//           deferredLightingPerLightMaterial,
			//           1,
			//           &v64,
			//           v19,
			//           v43,
			//           &v66,
			//           0LL);
			//         *(_OWORD *)&v66.hasValue = v35;
			//         *(_OWORD *)&v66.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v36;
			//         v44 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass.static_fields;
			//         *(_OWORD *)&v66.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v37;
			//         *(_OWORD *)&v66.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v38;
			//         *(_OWORD *)&v66.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v39;
			//         v45 = v44.s_coneMpb;
			//         *(_OWORD *)&v66.value.m_RasterState.m_OffsetFactor = v40;
			//         *(_OWORD *)&v66.value.m_StencilState.m_FailOperationFront = v41;
			//         v64 = v34;
			//         UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
			//           cmd,
			//           coneMesh,
			//           0,
			//           deferredLightingPerLightMaterial,
			//           2,
			//           &v64,
			//           v19,
			//           v45,
			//           &v66,
			//           0LL);
			//       }
			//       if ( !v62 )
			//         return;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::DeferredLightingPass);
			//       Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::DeferredLightingPass.static_fields.s_sphereMpb;
			//       if ( Patch )
			//       {
			//         UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)Patch, 1, 0LL);
			//         s_sphereMpb = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass.static_fields.s_sphereMpb;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         if ( s_sphereMpb )
			//         {
			//           UnityEngine::MaterialPropertyBlock::SetFloatArray(
			//             s_sphereMpb,
			//             static_fields._PerLightIndex,
			//             (NativeArray_1_System_Single_ *)&v70,
			//             0LL);
			//           v47 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass.static_fields.s_sphereMpb;
			//           sub_1802F01E0(v72, 0LL, 112LL);
			//           if ( cmd )
			//           {
			//             v48 = v65;
			//             v49 = *(_OWORD *)&v72[0].hasValue;
			//             v50 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//             v51 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//             v52 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//             v53 = *(_OWORD *)&v72[0].value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//             v54 = *(_OWORD *)&v72[0].value.m_RasterState.m_OffsetFactor;
			//             v55 = *(_OWORD *)&v72[0].value.m_StencilState.m_FailOperationFront;
			//             v66 = v72[0];
			//             UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
			//               cmd,
			//               sphereMesh,
			//               0,
			//               deferredLightingPerLightMaterial,
			//               0,
			//               &v65,
			//               v62,
			//               v47,
			//               &v66,
			//               0LL);
			//             *(_OWORD *)&v66.hasValue = v49;
			//             *(_OWORD *)&v66.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v50;
			//             v56 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass.static_fields;
			//             *(_OWORD *)&v66.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v51;
			//             *(_OWORD *)&v66.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v52;
			//             *(_OWORD *)&v66.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v53;
			//             v57 = v56.s_sphereMpb;
			//             *(_OWORD *)&v66.value.m_RasterState.m_OffsetFactor = v54;
			//             *(_OWORD *)&v66.value.m_StencilState.m_FailOperationFront = v55;
			//             v65 = v48;
			//             UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
			//               cmd,
			//               sphereMesh,
			//               0,
			//               deferredLightingPerLightMaterial,
			//               1,
			//               &v65,
			//               v62,
			//               v57,
			//               &v66,
			//               0LL);
			//             *(_OWORD *)&v66.hasValue = v49;
			//             *(_OWORD *)&v66.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v50;
			//             v58 = TypeInfo::HG::Rendering::Runtime::DeferredLightingPass.static_fields;
			//             *(_OWORD *)&v66.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v51;
			//             *(_OWORD *)&v66.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v52;
			//             *(_OWORD *)&v66.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v53;
			//             v59 = v58.s_sphereMpb;
			//             *(_OWORD *)&v66.value.m_RasterState.m_OffsetFactor = v54;
			//             *(_OWORD *)&v66.value.m_StencilState.m_FailOperationFront = v55;
			//             v65 = v48;
			//             UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
			//               cmd,
			//               sphereMesh,
			//               0,
			//               deferredLightingPerLightMaterial,
			//               2,
			//               &v65,
			//               v62,
			//               v59,
			//               &v66,
			//               0LL);
			//             return;
			//           }
			//         }
			//       }
			// LABEL_23:
			//       sub_180B536AC(Patch, static_fields);
			//     }
			//   }
			// }
			// 
		}

		internal static void DrawDeferredLightingWriteAlpha(HGRenderGraphContext context, CommandBuffer cmd, HGCamera hgCamera, Material deferredLightingWriteAlphaMaterial, DeferredLightingPass.DeferredLightingRenderParams renderParams)
		{
			// // Void DrawDeferredLightingWriteAlpha(HGRenderGraphContext, CommandBuffer, HGCamera, Material, DeferredLightingPass+DeferredLightingRenderParams)
			// void HG::Rendering::Runtime::DeferredLightingPass::DrawDeferredLightingWriteAlpha(
			//         HGRenderGraphContext *context,
			//         CommandBuffer *cmd,
			//         HGCamera *hgCamera,
			//         Material *deferredLightingWriteAlphaMaterial,
			//         DeferredLightingPass_DeferredLightingRenderParams *renderParams,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v12; // xmm1
			//   GraphicsBuffer *quadIndexBuffer; // xmm0_8
			//   DeferredLightingPass_DeferredLightingRenderParams v14; // [rsp+40h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919519 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919519 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2535, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2535, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v10);
			//     v12 = *(_OWORD *)&renderParams.drawTileArgs.handle._type_k__BackingField;
			//     *(_OWORD *)&v14.enableDeferredShadingDefaultLit = *(_OWORD *)&renderParams.enableDeferredShadingDefaultLit;
			//     quadIndexBuffer = renderParams.quadIndexBuffer;
			//     *(_OWORD *)&v14.drawTileArgs.handle._type_k__BackingField = v12;
			//     v14.quadIndexBuffer = quadIndexBuffer;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_932(
			//       Patch,
			//       (Object *)context,
			//       (Object *)cmd,
			//       (Object *)hgCamera,
			//       (Object *)deferredLightingWriteAlphaMaterial,
			//       &v14,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     if ( HG::Rendering::Runtime::HGUtils::RenderWithAlpha(hgCamera, 0LL) )
			//     {
			//       if ( renderParams.enableDeferredShadingDefaultLit )
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//         UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingWriteAlphaMaterial, 0LL, 0, 0LL);
			//       }
			//       if ( BYTE1(*(_QWORD *)&renderParams.enableDeferredShadingDefaultLit) )
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//         UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingWriteAlphaMaterial, 0LL, 1, 0LL);
			//       }
			//       if ( (unsigned __int8)BYTE2(*(_QWORD *)&renderParams.enableDeferredShadingDefaultLit) )
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//         UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, deferredLightingWriteAlphaMaterial, 0LL, 2, 0LL);
			//       }
			//     }
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static MaterialPropertyBlock s_coneMpb;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static MaterialPropertyBlock s_sphereMpb;

		internal enum LightMeshType
		{
			Cone,
			Sphere
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 72)]
		internal struct LightMeshDrawRequest
		{
			public DeferredLightingPass.LightMeshType lightMeshType;

			public Matrix4x4 lightMeshMatrix;

			public uint lightIndex;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct DeferredLightingRenderParams
		{
			public bool enableDeferredShadingDefaultLit;

			public bool enableDeferredShadingTwoSidedFoliage;

			public bool enableDeferredShadingSubsurface;

			public bool splitDeferredShadingStage;

			public bool usePerLightDynamicLighting;

			public bool enableDeferredShadingDirectionalLightStage;

			public bool enableDeferredShadingDynamicLightStage;

			public bool enableDeferredShadingIndirectStage;

			public bool enableDeferredShadingTileDraw;

			public ComputeBufferHandle drawTileArgs;

			public ComputeBufferHandle tileInstanceIndices;

			public GraphicsBuffer quadIndexBuffer;
		}
	}
}
