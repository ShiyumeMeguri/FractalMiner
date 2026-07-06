using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace HG.Rendering.Runtime
{
	internal class HGShadowManager
	{
		public HGShadowManager()
		{
		}

		internal void RenderCharacterShadows(HGRenderGraph renderGraph, HGCamera hgCamera, CullingResults cullingResults, LightCullResult lightCullResult, int directionalLightIndex, ref ShadowResult shadowResult)
		{
			// // Void RenderCharacterShadows(HGRenderGraph, HGCamera, CullingResults, LightCullResult, Int32, ShadowResult ByRef)
			// // Hidden C++ exception states: #wind=4 #try_helpers=1
			// void HG::Rendering::Runtime::HGShadowManager::RenderCharacterShadows(
			//         HGShadowManager *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         CullingResults *cullingResults,
			//         LightCullResult *lightCullResult,
			//         int32_t directionalLightIndex,
			//         ShadowResult *shadowResult,
			//         MethodInfo *method)
			// {
			//   HGCamera *v9; // r13
			//   HGRenderGraph *v10; // r14
			//   HGShadowManager *v11; // r15
			//   __int64 v12; // rdx
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
			//   HGGraphicsFeatureSwitch *characterShadow; // rdi
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   Object v17; // xmm6
			//   int32_t m_CharacterShadowCount; // eax
			//   Void *v19; // rax
			//   ProfilingSampler *v20; // rax
			//   unsigned __int16 v21; // di
			//   ProfilingSampler *v22; // rax
			//   Void *v23; // rax
			//   __int64 v24; // rdx
			//   _OWORD *v25; // rax
			//   __int64 v26; // rcx
			//   Object *v27; // r12
			//   __int64 v28; // rdx
			//   HGShadowManager__StaticFields *v29; // rcx
			//   __int64 m_CharacterShadowSampleMode; // rcx
			//   HGShadowManager__StaticFields *v31; // rcx
			//   __int64 v32; // rdx
			//   HGShadowManager__StaticFields *v33; // rcx
			//   HGShadowManager__StaticFields *v34; // rcx
			//   Object *v35; // r12
			//   int32_t v36; // r8d
			//   __int64 m_CharacterShadowmapResolution; // rdx
			//   struct HGShadowManager__Class *v38; // rcx
			//   Object v39; // xmm0
			//   Object__Class *klass; // r12
			//   RendererListHandle InvalidHandle; // rax
			//   RendererListHandle v42; // rdx
			//   RendererListHandle v43; // rcx
			//   RendererListHandle v44; // r8
			//   RendererListHandle v45; // r9
			//   RendererListDesc *v46; // rax
			//   MonitorData *monitor; // r12
			//   uint32_t RendererListWithCharacterIndex; // eax
			//   __int64 v49; // rdx
			//   __int64 v50; // rcx
			//   __int64 v51; // r8
			//   __int64 v52; // r9
			//   ProfilingSampler *v53; // rax
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   ProfilingSampler *v56; // rax
			//   __int64 v57; // rdx
			//   __int64 v58; // rcx
			//   __int64 v59; // rdx
			//   __int64 v60; // rcx
			//   HGRenderGraphDefaultResources *m_DefaultResources; // rax
			//   __int64 v62; // rdx
			//   __int64 v63; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdi
			//   Object *v65; // [rsp+50h] [rbp-398h] BYREF
			//   unsigned __int16 i; // [rsp+58h] [rbp-390h]
			//   LightCullResult v67; // [rsp+60h] [rbp-388h] BYREF
			//   RendererListHandle input; // [rsp+70h] [rbp-378h] BYREF
			//   CullingResults v69; // [rsp+80h] [rbp-368h] BYREF
			//   Object *v70; // [rsp+90h] [rbp-358h] BYREF
			//   TextureHandle *v71; // [rsp+98h] [rbp-350h] BYREF
			//   LightCullResult v72; // [rsp+A0h] [rbp-348h] BYREF
			//   Object v73; // [rsp+B0h] [rbp-338h]
			//   Object v74; // [rsp+C0h] [rbp-328h]
			//   HGRenderGraphBuilder v75; // [rsp+D0h] [rbp-318h] BYREF
			//   HGRenderGraphBuilder v76; // [rsp+F0h] [rbp-2F8h] BYREF
			//   HGRenderGraphBuilder v77; // [rsp+110h] [rbp-2D8h] BYREF
			//   HGRenderGraphBuilder v78; // [rsp+130h] [rbp-2B8h] BYREF
			//   HGRenderGraphProfilingScope v79; // [rsp+150h] [rbp-298h] BYREF
			//   HGRenderGraphBuilder v80; // [rsp+168h] [rbp-280h] BYREF
			//   Il2CppExceptionWrapper *v81; // [rsp+188h] [rbp-260h] BYREF
			//   Il2CppExceptionWrapper *v82; // [rsp+190h] [rbp-258h] BYREF
			//   Il2CppExceptionWrapper *v83; // [rsp+1A0h] [rbp-248h] BYREF
			//   Bounds bounds; // [rsp+1A8h] [rbp-240h] BYREF
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v85; // [rsp+1C0h] [rbp-228h] BYREF
			//   RendererListDesc shadowLight; // [rsp+1D0h] [rbp-218h] BYREF
			//   RendererListDesc desc; // [rsp+2B0h] [rbp-138h] BYREF
			// 
			//   v9 = hgCamera;
			//   v10 = renderGraph;
			//   v11 = this;
			//   if ( !byte_18D919E74 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&off_18D5EFC08);
			//     sub_18003C530(&off_18D5EFC00);
			//     byte_18D919E74 = 1;
			//   }
			//   memset(&bounds, 0, sizeof(bounds));
			//   memset(&v78, 0, sizeof(v78));
			//   v71 = 0LL;
			//   memset(&v79, 0, sizeof(v79));
			//   memset(&v75, 0, sizeof(v75));
			//   v65 = 0LL;
			//   memset(&v77, 0, sizeof(v77));
			//   v70 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1780, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1780, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v63, v62);
			//     v72 = *lightCullResult;
			//     v67 = (LightCullResult)*cullingResults;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_700(
			//       Patch,
			//       (Object *)v11,
			//       (Object *)v10,
			//       (Object *)v9,
			//       (CullingResults *)&v67,
			//       &v72,
			//       directionalLightIndex,
			//       shadowResult,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters.static_fields.instance )
			//       goto LABEL_50;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     if ( HG::Rendering::Runtime::HGCharacters::get_count(0LL) < 1
			//       || directionalLightIndex == -1
			//       || !v11.fields.enableCharacterShadowmap
			//       || !v11.fields.m_hasDirectionLight )
			//     {
			//       goto LABEL_50;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//     characterShadow = static_fields.characterShadow;
			//     if ( !characterShadow )
			//       sub_180B536AC(static_fields, v12);
			//     if ( characterShadow.fields.m_defaultValue
			//       && (UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL)
			//        || UnityEngine::Rendering::CullingResults::GetShadowCasterBounds(
			//             cullingResults.ptr,
			//             directionalLightIndex,
			//             &bounds,
			//             0LL)) )
			//     {
			//       if ( !v10 )
			//         sub_1802DC2C8(v16, v15);
			//       v17 = (Object)*HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                        (TextureHandle *)&v72,
			//                        v10,
			//                        &v11.fields.m_characterShadowmapsDesc,
			//                        0LL);
			//       v72 = (LightCullResult)v17;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//       m_CharacterShadowCount = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowCount;
			//       v67 = *lightCullResult;
			//       v69 = *cullingResults;
			//       HG::Rendering::Runtime::HGShadowManager::SetupCharacterShadowCasterConstants(
			//         v11,
			//         &v69,
			//         &v67,
			//         v9,
			//         directionalLightIndex,
			//         m_CharacterShadowCount,
			//         0LL);
			//       v19 = &UnityEngine::HyperGryph::LightCullResult::get_visibleLights(
			//                (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v67,
			//                lightCullResult,
			//                0LL).m_Buffer[148 * directionalLightIndex];
			//       *(_OWORD *)&shadowLight.sortingCriteria = *(_OWORD *)v19;
			//       shadowLight.stateBlock = *(Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&v19[16];
			//       *(_OWORD *)&shadowLight.overrideMaterial = *(_OWORD *)&v19[128];
			//       shadowLight.overrideMaterialPassIndex = *(_DWORD *)&v19[144];
			//       HG::Rendering::Runtime::HGShadowManager::SetupCharacterShadowReceiverConstants(
			//         v11,
			//         (VisibleLight *)&shadowLight,
			//         TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowCount,
			//         0LL);
			//       v20 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x7Au,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(&v79, v10, v20, 0LL);
			//       v67.visibleLightsPtr = 0LL;
			//       *(_QWORD *)&v67.visibleLightCount = &v79;
			//       v21 = 0;
			//       for ( i = 0; ; i = v21 )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         if ( v21 >= TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowCount )
			//           break;
			//         v22 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                 (Int32Enum__Enum)0x7Bu,
			//                 MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           &v76,
			//           v10,
			//           (String *)"Render Character ShadowMaps",
			//           &v65,
			//           v22,
			//           1,
			//           ProfilingHGPass__Enum_Shadow,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
			//         v75 = v76;
			//         v69.ptr = 0LL;
			//         v69.m_AllocationInfo = (CullingAllocationInfo *)&v75;
			//         try
			//         {
			//           input = (RendererListHandle)v65;
			//           v23 = &UnityEngine::HyperGryph::LightCullResult::get_visibleLights(&v85, lightCullResult, 0LL).m_Buffer[148 * directionalLightIndex];
			//           *(_OWORD *)&shadowLight.sortingCriteria = *(_OWORD *)v23;
			//           shadowLight.stateBlock = *(Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&v23[16];
			//           *(_OWORD *)&shadowLight.overrideMaterial = *(_OWORD *)&v23[128];
			//           shadowLight.overrideMaterialPassIndex = *(_DWORD *)&v23[144];
			//           v25 = (_OWORD *)input;
			//           if ( !*(_QWORD *)&input )
			//             sub_1802DC2C8(&shadowLight, v24);
			//           v26 = *(_QWORD *)&input + 16LL;
			//           *(_OWORD *)(*(_QWORD *)&input + 16LL) = *(_OWORD *)&shadowLight.sortingCriteria;
			//           v25[2] = *(_OWORD *)&shadowLight.stateBlock.hasValue;
			//           v25[3] = *(_OWORD *)&shadowLight.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//           v25[4] = *(_OWORD *)&shadowLight.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//           v25[5] = *(_OWORD *)&shadowLight.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//           v25[6] = *(_OWORD *)&shadowLight.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//           v25[7] = *(_OWORD *)&shadowLight.stateBlock.value.m_RasterState.m_OffsetFactor;
			//           *(_OWORD *)(v26 + 112) = *(_OWORD *)&shadowLight.stateBlock.value.m_StencilState.m_FailOperationFront;
			//           *(_OWORD *)(v26 + 128) = *(_OWORD *)&shadowLight.overrideMaterial;
			//           *(_DWORD *)(v26 + 144) = shadowLight.overrideMaterialPassIndex;
			//           if ( !v65 )
			//             sub_1802DC2C8(v26, v24);
			//           v65[14] = v17;
			//           v27 = v65;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//           v29 = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//           if ( !v27 )
			//             sub_1802DC2C8(v29, v28);
			//           HIDWORD(v27[10].klass) = v29.m_CharacterShadowCount;
			//           m_CharacterShadowSampleMode = (unsigned int)v11.fields.m_CharacterShadowSampleMode;
			//           if ( !v65 )
			//             sub_1802DC2C8(m_CharacterShadowSampleMode, v28);
			//           LODWORD(v65[11].klass) = m_CharacterShadowSampleMode;
			//           if ( !v65 )
			//             sub_1802DC2C8(0LL, v28);
			//           LODWORD(v65[10].monitor) = v21;
			//           v31 = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//           v32 = (unsigned int)v31.m_CharacterShadowCount;
			//           if ( !v65 )
			//             sub_1802DC2C8(v31, v32);
			//           HIDWORD(v65[10].monitor) = v32;
			//           v33 = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//           if ( !v65 )
			//             sub_1802DC2C8(v33, v32);
			//           HIDWORD(v65[12].klass) = LODWORD(v33.m_CharacterHardwareDepthBias);
			//           v34 = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//           if ( !v65 )
			//             sub_1802DC2C8(v34, v32);
			//           *(float *)&v65[12].monitor = v34.m_CharacterHardwareNormalBias;
			//           v35 = v65;
			//           if ( TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowCount <= 4 )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//             v38 = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
			//             m_CharacterShadowmapResolution = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowmapResolution;
			//             v74.klass = (Object__Class *)COERCE_UNSIGNED_INT((float)(TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowmapResolution
			//                                                                    * v21));
			//             *(float *)&v74.monitor = (float)(int)m_CharacterShadowmapResolution;
			//             *((float *)&v74.monitor + 1) = (float)(int)m_CharacterShadowmapResolution;
			//             if ( !v35 )
			//               sub_1802DC2C8(TypeInfo::HG::Rendering::Runtime::HGShadowManager, m_CharacterShadowmapResolution);
			//             v39 = v74;
			//           }
			//           else
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//             v36 = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowmapResolution;
			//             m_CharacterShadowmapResolution = (unsigned int)v36;
			//             v38 = (struct HGShadowManager__Class *)(v36 * (v21 & 3u));
			//             *(float *)&v73.klass = (float)(int)v38;
			//             *((float *)&v73.klass + 1) = (float)(v36 * (v21 >> 2));
			//             *(float *)&v73.monitor = (float)v36;
			//             *((float *)&v73.monitor + 1) = (float)v36;
			//             if ( !v35 )
			//               sub_1802DC2C8(v38, (unsigned int)v36);
			//             v39 = v73;
			//           }
			//           *(Object *)((char *)v35 + 180) = v39;
			//           if ( !v65 )
			//             sub_1802DC2C8(v38, m_CharacterShadowmapResolution);
			//           klass = v65[13].klass;
			//           if ( UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL) )
			//           {
			//             InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//           }
			//           else
			//           {
			//             *(CullingResults *)&v76.m_RenderPass = *cullingResults;
			//             v46 = HG::Rendering::Runtime::HGShadowManager::PrepareCharacterShadowRendererList(
			//                     &shadowLight,
			//                     v11,
			//                     (CullingResults *)&v76,
			//                     v9,
			//                     v21 + 1,
			//                     0LL);
			//             *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v46.sortingCriteria;
			//             desc.stateBlock = v46.stateBlock;
			//             v46 = (RendererListDesc *)((char *)v46 + 128);
			//             *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v46.sortingCriteria;
			//             *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v46.stateBlock.hasValue;
			//             *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v46.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v46.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v46.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v46.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//             input = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(v10, &desc, 0LL);
			//             InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v75, &input, 0LL);
			//           }
			//           if ( !klass )
			//             sub_1802DC2C8(v43, v42);
			//           if ( (unsigned int)v21 >= LODWORD(klass._0.namespaze) )
			//             ((void (__fastcall __noreturn *)(_QWORD, _QWORD, _QWORD, _QWORD))sub_180070260)(v21, v42, v44, v45);
			//           *((RendererListHandle *)&klass._0.byval_arg.data.dummy + v21) = InvalidHandle;
			//           if ( !v65 )
			//             sub_1802DC2C8(v21, v42);
			//           monitor = v65[13].monitor;
			//           if ( !v9 )
			//             sub_1802DC2C8(v21, v42);
			//           *(_DWORD *)&input.m_IsValid = v9.fields.cullingViewHandle;
			//           v76.m_RenderPass = (HGRenderGraphPass *)v10.fields.m_RenderGraphContext;
			//           if ( !v76.m_RenderPass )
			//             sub_1802DC2C8(v21, v42);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           RendererListWithCharacterIndex = UnityEngine::HyperGryph::HGMeshRender::CreateRendererListWithCharacterIndex(
			//                                              *(uint32_t *)&input.m_IsValid,
			//                                              v21 + 1,
			//                                              0x400u,
			//                                              0,
			//                                              0x400u,
			//                                              0,
			//                                              v76.m_RenderPass.fields._name_k__BackingField,
			//                                              0LL);
			//           if ( !monitor )
			//             sub_1802DC2C8(v50, v49);
			//           if ( (unsigned int)v21 >= *((_DWORD *)monitor + 6) )
			//             sub_180070260(v21, v49, v51, v52);
			//           *((_DWORD *)monitor + v21 + 8) = RendererListWithCharacterIndex;
			//           if ( !v65 )
			//             sub_1802DC2C8(v21, v49);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//             (TextureHandle *)&v80,
			//             &v75,
			//             (TextureHandle *)&v65[14],
			//             DepthAccess__Enum_Write,
			//             (RenderBufferLoadAction__Enum)(v21 == 0),
			//             RenderBufferStoreAction__Enum_Store,
			//             1.0,
			//             0,
			//             0,
			//             0LL);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v75, 0, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v75,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.s_renderCharacterShadowmapRenderFunc,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v81 )
			//         {
			//           v69.ptr = v81.ex;
			//           sub_180222690(&v69);
			//           v9 = hgCamera;
			//           v10 = renderGraph;
			//           v11 = this;
			//           v17 = (Object)v72;
			//           v21 = i;
			//           goto LABEL_44;
			//         }
			//         sub_180222690(&v69);
			// LABEL_44:
			//         ++v21;
			//       }
			//       v53 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x7Bu,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v80,
			//         v10,
			//         (String *)"Render Character ShadowMaps SetData",
			//         &v70,
			//         v53,
			//         1,
			//         ProfilingHGPass__Enum_Shadow,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
			//       v77 = v80;
			//       v69.ptr = 0LL;
			//       v69.m_AllocationInfo = (CullingAllocationInfo *)&v77;
			//       try
			//       {
			//         if ( !v70 )
			//           sub_1802DC2C8(v55, v54);
			//         v70[14] = v17;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v77,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.s_renderCharacterShadowmapSetDataFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v82 )
			//       {
			//         v69.ptr = v82.ex;
			//         sub_180222690(&v69);
			//         sub_180224750(&v67);
			//         v17 = (Object)v72;
			//         goto LABEL_49;
			//       }
			//       sub_180222690(&v69);
			//       sub_180224750(&v67);
			// LABEL_49:
			//       shadowResult.characterShadowActive = 1;
			//       shadowResult.characterShadowResult = (TextureHandle)v17;
			//     }
			//     else
			//     {
			// LABEL_50:
			//       v56 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x7Au,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v10 )
			//         sub_180B536AC(v58, v57);
			//       v78 = *(HGRenderGraphBuilder *)sub_180836A28(
			//                                        (unsigned int)&v80,
			//                                        (_DWORD)v10,
			//                                        (unsigned int)"Render Character ShadowMaps",
			//                                        (unsigned int)&v71,
			//                                        (__int64)v56);
			//       v67.visibleLightsPtr = 0LL;
			//       *(_QWORD *)&v67.visibleLightCount = &v78;
			//       try
			//       {
			//         m_DefaultResources = v10.fields.m_DefaultResources;
			//         if ( !m_DefaultResources )
			//           sub_1802DC2C8(v60, v59);
			//         if ( !v71 )
			//           sub_1802DC2C8(v60, v59);
			//         v71[14] = m_DefaultResources.fields._defaultShadowTexture_k__BackingField;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v78,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.s_disableCharacterShadowRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGShadowManager::CharacterShadowPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v83 )
			//       {
			//         v67.visibleLightsPtr = v83.ex;
			//         sub_180222690(&v67);
			//         return;
			//       }
			//       sub_180222690(&v67);
			//     }
			//   }
			// }
			// 
		}

		public void CharacterShadowFrameSetup(HGSettingParameters settingParams)
		{
			// // Void CharacterShadowFrameSetup(HGSettingParameters)
			// void HG::Rendering::Runtime::HGShadowManager::CharacterShadowFrameSetup(
			//         HGShadowManager *this,
			//         HGSettingParameters *settingParams,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Int32Enum__Enum v7; // r15d
			//   Int32Enum__Enum v8; // r14d
			//   int32_t v9; // esi
			//   Vector2Int v10; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   int32_t m_CharacterShadowmapResolution; // ebx
			//   int count; // edx
			//   HGShadowManager__StaticFields *static_fields; // rcx
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   Color clearColor; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureDesc v26; // [rsp+20h] [rbp-60h] BYREF
			//   Vector2Int v27; // [rsp+C8h] [rbp+48h]
			// 
			//   if ( !byte_18D919E75 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&off_18D5EFC78);
			//     byte_18D919E75 = 1;
			//   }
			//   sub_1802F01E0(&v26, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1792, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1792, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)settingParams,
			//         0LL);
			//       return;
			//     }
			// LABEL_17:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !settingParams )
			//     goto LABEL_17;
			//   v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//          (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._characterShadowMapResolution_k__BackingField,
			//          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   v8 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//          (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._shadowDepthBits_k__BackingField,
			//          MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit);
			//   v9 = 90;
			//   if ( v8 != 16 )
			//     v9 = 93;
			//   if ( this.fields.m_hasDirectionLight )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowmapResolution = v7;
			//     this.fields.m_CharacterShadowSampleMode = 2;
			//     TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterDepthBias = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                                                                                settingParams.fields._characterShadowShaderBias_k__BackingField,
			//                                                                                                MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterNormalBias = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                                                                                 settingParams.fields._characterShadowShaderNormalBias_k__BackingField,
			//                                                                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterHardwareDepthBias = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(settingParams.fields._characterShadowHardwareBias_k__BackingField, MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterHardwareNormalBias = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(settingParams.fields._characterShadowHardwareNormalBias_k__BackingField, MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     m_CharacterShadowmapResolution = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowmapResolution;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     count = HG::Rendering::Runtime::HGCharacters::get_count(0LL);
			//     if ( count >= 15 )
			//       count = 15;
			//     TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowCount = count;
			//     if ( TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowCount <= 4 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//       v27.m_Y = 1;
			//       v27.m_X = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowCount;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//       v27.m_X = 4;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//       v27.m_Y = (static_fields.m_CharacterShadowCount - 1) / 4 + 1;
			//     }
			//     static_fields.m_AtlasTileCount = v27;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowmapSize = (Vector2Int)__PAIR64__(TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_AtlasTileCount.m_Y * m_CharacterShadowmapResolution, TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_AtlasTileCount.m_X * m_CharacterShadowmapResolution);
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//       &v26,
			//       TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowmapSize.m_X,
			//       TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowmapSize.m_Y,
			//       0LL);
			//     v26.name = (String *)"CharacterShadowMap";
			//     v26.depthBufferBits = v8;
			//     v26.colorFormat = v9;
			//     v26.filterMode = 1;
			//     v26.wrapMode = 1;
			//     v26.isShadowMap = 1;
			//     v26.dimension = 2;
			//     v26.clearBuffer = 1;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)&v26.name,
			//       v17,
			//       v18,
			//       v19,
			//       *(MethodInfo **)&v26.width,
			//       *(MethodInfo **)&v26.slices);
			//   }
			//   else
			//   {
			//     v10 = (Vector2Int)sub_182E7DDC0();
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_AtlasTileCount = v10;
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v26, 1, 1, 0LL);
			//     v26.depthBufferBits = v8;
			//     v26.colorFormat = v9;
			//     v26.filterMode = 1;
			//     v26.wrapMode = 1;
			//     v26.dimension = 2;
			//     v26.isShadowMap = 1;
			//     v26.clearBuffer = 1;
			//   }
			//   v20 = *(_OWORD *)&v26.colorFormat;
			//   *(_OWORD *)&this.fields.m_characterShadowmapsDesc.width = *(_OWORD *)&v26.width;
			//   v21 = *(_OWORD *)&v26.enableRandomWrite;
			//   *(_OWORD *)&this.fields.m_characterShadowmapsDesc.colorFormat = v20;
			//   v22 = *(_OWORD *)&v26.bindTextureMS;
			//   *(_OWORD *)&this.fields.m_characterShadowmapsDesc.enableRandomWrite = v21;
			//   v23 = *(_OWORD *)&v26.fastMemoryDesc.inFastMemory;
			//   *(_OWORD *)&this.fields.m_characterShadowmapsDesc.bindTextureMS = v22;
			//   clearColor = v26.clearColor;
			//   *(_OWORD *)&this.fields.m_characterShadowmapsDesc.fastMemoryDesc.inFastMemory = v23;
			//   this.fields.m_characterShadowmapsDesc.clearColor = clearColor;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_characterShadowmapsDesc.name,
			//     v11,
			//     v12,
			//     v13,
			//     *(MethodInfo **)&v26.width,
			//     *(MethodInfo **)&v26.slices);
			// }
			// 
		}

		private void SetupCharacterShadowCasterConstants(CullingResults cullingResults, LightCullResult lightCullResult, HGCamera hgCamera, int directionalLightIndex, int characterCount)
		{
			// // Void SetupCharacterShadowCasterConstants(CullingResults, LightCullResult, HGCamera, Int32, Int32)
			// void HG::Rendering::Runtime::HGShadowManager::SetupCharacterShadowCasterConstants(
			//         HGShadowManager *this,
			//         CullingResults *cullingResults,
			//         LightCullResult *lightCullResult,
			//         HGCamera *hgCamera,
			//         int32_t directionalLightIndex,
			//         int32_t characterCount,
			//         MethodInfo *method)
			// {
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights; // rax
			//   __int64 v12; // rdx
			//   void *Patch; // rcx
			//   int v14; // esi
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rbx
			//   Light *light; // rax
			//   HGEnvironmentVolumeCameraComponent *v17; // rax
			//   HGEnvironmentPhase *m_interpolatedPhase; // rax
			//   __int128 v19; // xmm6
			//   __int128 v20; // xmm7
			//   __int128 v21; // xmm9
			//   __int128 v22; // xmm10
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   List_1_System_Object_ *characterHelpers; // rax
			//   Object *Item; // r12
			//   __int64 v26; // rdi
			//   Matrix4x4 *v27; // rbx
			//   Matrix4x4 *v28; // rax
			//   Vector4__Array *m_CharacterShadowBiases; // r12
			//   unsigned int m_CharacterShadowSampleMode; // ebx
			//   HGShadowManager__StaticFields *static_fields; // rax
			//   int m_CharacterShadowmapResolution; // edi
			//   float m_CharacterDepthBias; // xmm7_4
			//   float m_CharacterNormalBias; // xmm6_4
			//   Vector4 *ShadowBias; // rax
			//   Vector4__Array *v36; // rdi
			//   List_1_System_Object_ *v37; // rax
			//   Object *v38; // rax
			//   int16_t id; // ax
			//   uint32_t ShadowLayer; // ebx
			//   MethodInfo *v41; // r8
			//   Vector4 *v42; // rax
			//   __int64 v43; // r9
			//   Vector4__Array *m_CharacterShadowAtlasParams; // r9
			//   __m128i v45; // xmm0
			//   float v46; // xmm2_4
			//   __m128i v47; // xmm0
			//   float v48; // xmm1_4
			//   __m128i v49; // xmm0
			//   CullingResults v50; // xmm0
			//   HGShadowManager__StaticFields *v51; // rax
			//   __m128i v52; // xmm0
			//   float v53; // xmm1_4
			//   __m128i v54; // xmm0
			//   CullingResults v55; // xmm1
			//   _QWORD v56[3]; // [rsp+40h] [rbp-C8h] BYREF
			//   Vector3 v57; // [rsp+58h] [rbp-B0h] BYREF
			//   CullingResults v58; // [rsp+68h] [rbp-A0h] BYREF
			//   CullingResults v59; // [rsp+78h] [rbp-90h]
			//   Vector3 v60; // [rsp+88h] [rbp-80h] BYREF
			//   Matrix4x4 v61; // [rsp+98h] [rbp-70h] BYREF
			//   Matrix4x4 v62; // [rsp+D8h] [rbp-30h] BYREF
			//   Vector3 v63; // [rsp+118h] [rbp+10h] BYREF
			//   Vector4 v64; // [rsp+128h] [rbp+20h] BYREF
			//   Vector4 v65; // [rsp+138h] [rbp+30h] BYREF
			//   VisibleLight v66; // [rsp+148h] [rbp+40h] BYREF
			// 
			//   if ( !byte_18D919E76 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::get_Item);
			//     byte_18D919E76 = 1;
			//   }
			//   sub_1802F01E0(&v66, 0LL, 148LL);
			//   *(_QWORD *)&v57.x = 0LL;
			//   v57.z = 0.0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1782, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1782, 0LL);
			//     if ( !Patch )
			//       goto LABEL_29;
			//     v55 = *cullingResults;
			//     *(LightCullResult *)&v56[1] = *lightCullResult;
			//     v58 = v55;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_695(
			//       (ILFixDynamicMethodWrapper_2 *)Patch,
			//       (Object *)this,
			//       &v58,
			//       (LightCullResult *)&v56[1],
			//       (Object *)hgCamera,
			//       directionalLightIndex,
			//       characterCount,
			//       0LL);
			//   }
			//   else
			//   {
			//     visibleLights = UnityEngine::HyperGryph::LightCullResult::get_visibleLights(
			//                       (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v56[1],
			//                       lightCullResult,
			//                       0LL);
			//     v12 = 128LL;
			//     Patch = &v66;
			//     v66 = *(VisibleLight *)&visibleLights.m_Buffer[148 * directionalLightIndex];
			//     if ( characterCount > 0 )
			//     {
			//       v14 = 0;
			//       if ( hgCamera )
			//       {
			//         while ( 1 )
			//         {
			//           m_envVolumeCameraComponent = hgCamera.fields.m_envVolumeCameraComponent;
			//           light = UnityEngine::Rendering::VisibleLight::get_light(&v66, 0LL);
			//           if ( !m_envVolumeCameraComponent )
			//             break;
			//           if ( HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
			//                  m_envVolumeCameraComponent,
			//                  light,
			//                  0LL) )
			//           {
			//             v17 = hgCamera.fields.m_envVolumeCameraComponent;
			//             if ( !v17 )
			//               break;
			//             m_interpolatedPhase = v17.fields.m_interpolatedPhase;
			//             if ( !m_interpolatedPhase )
			//               break;
			//             v19 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m00;
			//             v20 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m01;
			//             v21 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m02;
			//             v22 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m03;
			//           }
			//           else
			//           {
			//             localToWorldMatrix = UnityEngine::HGSharedLightData::get_localToWorldMatrix(
			//                                    &v62,
			//                                    &v66.hgSharedLightData,
			//                                    0LL);
			//             v19 = *(_OWORD *)&localToWorldMatrix.m00;
			//             v20 = *(_OWORD *)&localToWorldMatrix.m01;
			//             v21 = *(_OWORD *)&localToWorldMatrix.m02;
			//             v22 = *(_OWORD *)&localToWorldMatrix.m03;
			//           }
			//           v57 = *UnityEngine::Vector3::get_fwd(&v63, (MethodInfo *)v12);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCharacters);
			//           characterHelpers = (List_1_System_Object_ *)HG::Rendering::Runtime::HGCharacters::get_characterHelpers(0LL);
			//           if ( !characterHelpers )
			//             break;
			//           Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                    characterHelpers,
			//                    v14,
			//                    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::get_Item);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//           v12 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShadowManager;
			//           Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//           v26 = *((_QWORD *)Patch + 1);
			//           if ( !v26 )
			//             break;
			//           Patch = (void *)*((_QWORD *)Patch + 2);
			//           if ( !Patch )
			//             break;
			//           v27 = (Matrix4x4 *)sub_1804440E4(Patch, v14);
			//           v28 = (Matrix4x4 *)sub_1804440E4(v26, v14);
			//           *(_OWORD *)&v61.m00 = v19;
			//           *(_OWORD *)&v61.m01 = v20;
			//           *(_OWORD *)&v61.m02 = v21;
			//           *(_OWORD *)&v61.m03 = v22;
			//           HG::Rendering::Runtime::HGShadowManager::GetMatrices(
			//             &v61,
			//             hgCamera,
			//             (HGCharacterHelper *)Item,
			//             v28,
			//             v27,
			//             &v57,
			//             0LL);
			//           m_CharacterShadowBiases = this.fields.m_CharacterShadowBiases;
			//           Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterProjectionMatrices;
			//           if ( !Patch )
			//             break;
			//           sub_18005A9F0(Patch, &v62, v14);
			//           m_CharacterShadowSampleMode = this.fields.m_CharacterShadowSampleMode;
			//           static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//           m_CharacterShadowmapResolution = static_fields.m_CharacterShadowmapResolution;
			//           m_CharacterDepthBias = static_fields.m_CharacterDepthBias;
			//           m_CharacterNormalBias = static_fields.m_CharacterNormalBias;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//           v61 = v62;
			//           ShadowBias = HG::Rendering::Runtime::HGShadowUtils::GetShadowBias(
			//                          &v64,
			//                          &v61,
			//                          (float)m_CharacterShadowmapResolution,
			//                          m_CharacterDepthBias,
			//                          m_CharacterNormalBias,
			//                          (HGShadowSampleMode__Enum)m_CharacterShadowSampleMode,
			//                          0LL);
			//           if ( !m_CharacterShadowBiases )
			//             break;
			//           *(Vector4 *)&v56[1] = *ShadowBias;
			//           sub_18004D910(m_CharacterShadowBiases, v14, &v56[1]);
			//           v36 = this.fields.m_CharacterShadowBiases;
			//           if ( !v36 )
			//             break;
			//           v37 = (List_1_System_Object_ *)HG::Rendering::Runtime::HGCharacters::get_characterHelpers(0LL);
			//           if ( !v37 )
			//             break;
			//           v38 = System::Collections::Generic::List<System::Object>::get_Item(
			//                   v37,
			//                   v14,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::get_Item);
			//           if ( !v38 )
			//             break;
			//           id = HG::Rendering::Runtime::HGCharacterHelper::get_id((HGCharacterHelper *)v38, 0LL);
			//           ShadowLayer = HG::Rendering::Runtime::HGCharacters::GetShadowLayer(id, 0LL);
			//           *(_DWORD *)(sub_18003EB40(v36, v14) + 12) = ShadowLayer;
			//           v60 = v57;
			//           v42 = UnityEngine::Vector4::op_Implicit(&v65, &v60, v41);
			//           if ( !v43 )
			//             break;
			//           *(Vector4 *)&v56[1] = *v42;
			//           sub_18004D910(v43, v14, &v56[1]);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//           if ( characterCount <= 4 )
			//           {
			//             v12 = (__int64)TypeInfo::HG::Rendering::Runtime::HGShadowManager;
			//             v51 = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//             Patch = v51.m_CharacterShadowAtlasParams;
			//             v52 = _mm_cvtsi32_si128(v51.m_AtlasTileCount.m_X);
			//             v58.ptr = (void *)COERCE_UNSIGNED_INT((float)v14 / (float)characterCount);
			//             v53 = 1.0 / _mm_cvtepi32_ps(v52).m128_f32[0];
			//             v54 = _mm_cvtsi32_si128(v51.m_AtlasTileCount.m_Y);
			//             *(float *)&v58.m_AllocationInfo = v53;
			//             *((float *)&v58.m_AllocationInfo + 1) = 1.0 / _mm_cvtepi32_ps(v54).m128_f32[0];
			//             if ( !Patch )
			//               break;
			//             v50 = v58;
			//           }
			//           else
			//           {
			//             m_CharacterShadowAtlasParams = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowAtlasParams;
			//             Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//             v12 = (unsigned int)(v14 >> 31);
			//             LODWORD(v12) = v14 % 4;
			//             v45 = _mm_cvtsi32_si128(*((_DWORD *)Patch + 18));
			//             *(float *)&v59.ptr = (float)(v14 % 4) / (float)*((int *)Patch + 17);
			//             v46 = (float)(v14 / 4) / _mm_cvtepi32_ps(v45).m128_f32[0];
			//             v47 = _mm_cvtsi32_si128(*((_DWORD *)Patch + 17));
			//             *((float *)&v59.ptr + 1) = v46;
			//             v48 = 1.0 / _mm_cvtepi32_ps(v47).m128_f32[0];
			//             v49 = _mm_cvtsi32_si128(*((_DWORD *)Patch + 18));
			//             *(float *)&v59.m_AllocationInfo = v48;
			//             *((float *)&v59.m_AllocationInfo + 1) = 1.0 / _mm_cvtepi32_ps(v49).m128_f32[0];
			//             if ( !m_CharacterShadowAtlasParams )
			//               break;
			//             v50 = v59;
			//             Patch = m_CharacterShadowAtlasParams;
			//           }
			//           *(CullingResults *)&v56[1] = v50;
			//           sub_18004D910(Patch, v14++, &v56[1]);
			//           if ( v14 >= characterCount )
			//             return;
			//         }
			//       }
			// LABEL_29:
			//       sub_180B536AC(Patch, v12);
			//     }
			//   }
			// }
			// 
		}

		private static RendererListDesc CreateCharacterShadowCasterRendererListDesc(CullingResults cull, Camera camera, ShaderTagId passName, [MetadataOffset(Offset = "0x01F90E2E")] ushort characterIndex = 0)
		{
			// // RendererListDesc CreateCharacterShadowCasterRendererListDesc(CullingResults, Camera, ShaderTagId, UInt16)
			// RendererListDesc *HG::Rendering::Runtime::HGShadowManager::CreateCharacterShadowCasterRendererListDesc(
			//         RendererListDesc *__return_ptr retstr,
			//         CullingResults *cull,
			//         Camera *camera,
			//         ShaderTagId passName,
			//         uint16_t characterIndex,
			//         MethodInfo *method)
			// {
			//   RendererListDesc *v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v12; // rcx
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   RendererListDesc *result; // rax
			//   CullingResults v27; // [rsp+40h] [rbp-1D8h] BYREF
			//   RendererListDesc v28; // [rsp+50h] [rbp-1C8h] BYREF
			//   RendererListDesc v29; // [rsp+130h] [rbp-E8h] BYREF
			// 
			//   if ( !byte_18D919E77 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     byte_18D919E77 = 1;
			//   }
			//   sub_1802F01E0(&v28, 0LL, 224LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1791, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1791, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, 0LL);
			//     v27 = *cull;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_698(
			//             &v29,
			//             Patch,
			//             &v27,
			//             (Object *)camera,
			//             passName,
			//             characterIndex,
			//             0LL);
			//   }
			//   else
			//   {
			//     v27 = *cull;
			//     UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(&v28, passName, &v27, camera, 0LL);
			//     v28.characterIndex = characterIndex;
			//     v28.sortingCriteria = 59;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     v28.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_All;
			//     v10 = &v28;
			//   }
			//   v13 = *(_OWORD *)&v10.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v10.sortingCriteria;
			//   v14 = *(_OWORD *)&v10.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v13;
			//   v15 = *(_OWORD *)&v10.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v14;
			//   v16 = *(_OWORD *)&v10.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v15;
			//   v17 = *(_OWORD *)&v10.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v16;
			//   v18 = *(_OWORD *)&v10.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v17;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v18;
			//   v19 = *(_OWORD *)&v10.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v10.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v19;
			//   v21 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v22 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v21;
			//   v23 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v22;
			//   v24 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v23;
			//   v25 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v24;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v25;
			//   return result;
			// }
			// 
			return null;
		}

		private RendererListDesc PrepareCharacterShadowRendererList(CullingResults cullResults, HGCamera hgCamera, ushort characterIndex)
		{
			// // RendererListDesc PrepareCharacterShadowRendererList(CullingResults, HGCamera, UInt16)
			// RendererListDesc *HG::Rendering::Runtime::HGShadowManager::PrepareCharacterShadowRendererList(
			//         RendererListDesc *__return_ptr retstr,
			//         HGShadowManager *this,
			//         CullingResults *cullResults,
			//         HGCamera *hgCamera,
			//         uint16_t characterIndex,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v11; // rcx
			//   Camera *camera; // rbx
			//   RendererListDesc *v13; // rax
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm0
			//   Material **p_overrideMaterial; // rax
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   RendererListDesc *result; // rax
			//   CullingResults v28; // [rsp+40h] [rbp-F8h] BYREF
			//   RendererListDesc v29; // [rsp+50h] [rbp-E8h] BYREF
			//   ShaderTagId v30; // [rsp+140h] [rbp+8h] BYREF
			// 
			//   if ( !byte_18D919E78 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     byte_18D919E78 = 1;
			//   }
			//   v30.m_Id = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1790, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1790, 0LL);
			//     if ( Patch )
			//     {
			//       v28 = *cullResults;
			//       v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_699(
			//               &v29,
			//               Patch,
			//               (Object *)this,
			//               &v28,
			//               (Object *)hgCamera,
			//               characterIndex,
			//               0LL);
			//       goto LABEL_9;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v11, Patch);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//   UnityEngine::Rendering::ShaderTagId::ShaderTagId(
			//     &v30,
			//     TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields.s_ShadowCasterStr,
			//     0LL);
			//   if ( !hgCamera )
			//     goto LABEL_7;
			//   camera = hgCamera.fields.camera;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//   v28 = *cullResults;
			//   v13 = HG::Rendering::Runtime::HGShadowManager::CreateCharacterShadowCasterRendererListDesc(
			//           &v29,
			//           &v28,
			//           camera,
			//           v30,
			//           characterIndex,
			//           0LL);
			// LABEL_9:
			//   v14 = *(_OWORD *)&v13.stateBlock.hasValue;
			//   *(_OWORD *)&retstr.sortingCriteria = *(_OWORD *)&v13.sortingCriteria;
			//   v15 = *(_OWORD *)&v13.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.hasValue = v14;
			//   v16 = *(_OWORD *)&v13.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v15;
			//   v17 = *(_OWORD *)&v13.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v16;
			//   v18 = *(_OWORD *)&v13.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v17;
			//   v19 = *(_OWORD *)&v13.stateBlock.value.m_RasterState.m_OffsetFactor;
			//   *(_OWORD *)&retstr.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v18;
			//   *(_OWORD *)&retstr.stateBlock.value.m_RasterState.m_OffsetFactor = v19;
			//   v20 = *(_OWORD *)&v13.stateBlock.value.m_StencilState.m_FailOperationFront;
			//   p_overrideMaterial = &v13.overrideMaterial;
			//   *(_OWORD *)&retstr.stateBlock.value.m_StencilState.m_FailOperationFront = v20;
			//   v22 = *((_OWORD *)p_overrideMaterial + 1);
			//   *(_OWORD *)&retstr.overrideMaterial = *(_OWORD *)p_overrideMaterial;
			//   v23 = *((_OWORD *)p_overrideMaterial + 2);
			//   *(_OWORD *)&retstr.overrideMaterialPassIndex = v22;
			//   v24 = *((_OWORD *)p_overrideMaterial + 3);
			//   *(_OWORD *)&retstr.sortingLayerMin = v23;
			//   v25 = *((_OWORD *)p_overrideMaterial + 4);
			//   *(_OWORD *)&retstr.drawableFeedbackPtr = v24;
			//   v26 = *((_OWORD *)p_overrideMaterial + 5);
			//   result = retstr;
			//   *(_OWORD *)&retstr._cullingResult_k__BackingField.m_AllocationInfo = v25;
			//   *(_OWORD *)&retstr._passName_k__BackingField.m_Id = v26;
			//   return result;
			// }
			// 
			return null;
		}

		private static void GetMatrices(Matrix4x4 lightTransform, HGCamera hgCamera, HGCharacterHelper characterHelper, out Matrix4x4 worldToLightMatrices, out Matrix4x4 projectionMatrix, out Vector3 lightDirection)
		{
			// // Void GetMatrices(Matrix4x4, HGCamera, HGCharacterHelper, Matrix4x4 ByRef, Matrix4x4 ByRef, Vector3 ByRef)
			// void HG::Rendering::Runtime::HGShadowManager::GetMatrices(
			//         Matrix4x4 *lightTransform,
			//         HGCamera *hgCamera,
			//         HGCharacterHelper *characterHelper,
			//         Matrix4x4 *worldToLightMatrices,
			//         Matrix4x4 *projectionMatrix,
			//         Vector3 *lightDirection,
			//         MethodInfo *method)
			// {
			//   void *klass; // rdx
			//   void *Patch; // rcx
			//   __int64 v13; // xmm0_8
			//   float3 *xyz; // rbx
			//   float z; // eax
			//   float3 *v16; // rax
			//   __int64 v17; // xmm9_8
			//   __int64 v18; // xmm10_8
			//   float v19; // r12d
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   __int64 v22; // xmm0_8
			//   float3 *v23; // rax
			//   __int64 v24; // xmm6_8
			//   float v25; // r13d
			//   Vector4 *AsVector4; // rax
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rbx
			//   __m128i v28; // xmm14
			//   Object_1 *m_hgCharacterVolume; // rbx
			//   HGCharacterVolume_CharacterShadowMode__Enum CharacterSelfShadowMode; // eax
			//   float3__StaticFields *static_fields; // rdx
			//   __int64 v32; // xmm0_8
			//   float v33; // edi
			//   float3 *v34; // rax
			//   __int64 v35; // xmm0_8
			//   float v36; // esi
			//   __int64 v37; // rax
			//   float v38; // xmm6_4
			//   float y; // xmm7_4
			//   __int64 v40; // xmm0_8
			//   MethodInfo *v41; // r8
			//   float3 *v42; // rdx
			//   float3 *v43; // rcx
			//   float3 *v44; // r8
			//   float3 *v45; // r9
			//   MethodInfo *v46; // r9
			//   float3 *v47; // rax
			//   __int64 v48; // xmm3_8
			//   MethodInfo *v49; // r9
			//   float3 *v50; // rbx
			//   float v51; // edi
			//   float4x4 *v52; // rax
			//   float v53; // xmm4_4
			//   __int128 *v54; // rbx
			//   float4 c1; // xmm0
			//   float4 c2; // xmm1
			//   float4 c3; // xmm0
			//   __m128i v58; // xmm12
			//   __int128 v59; // xmm1
			//   __int128 v60; // xmm0
			//   __int128 v61; // xmm1
			//   __int128 v62; // xmm0
			//   __int128 v63; // xmm1
			//   __int128 v64; // xmm0
			//   __int128 v65; // xmm1
			//   __int128 v66; // xmm0
			//   const __m128i *v67; // rax
			//   __int128 v68; // xmm1
			//   __m128i v69; // xmm11
			//   __int128 v70; // xmm0
			//   __int128 v71; // xmm1
			//   __int128 v72; // xmm0
			//   const __m128i *v73; // rax
			//   __int128 v74; // xmm1
			//   __m128i v75; // xmm10
			//   __int128 v76; // xmm0
			//   __int128 v77; // xmm1
			//   __int128 v78; // xmm0
			//   const __m128i *v79; // rax
			//   __int128 v80; // xmm1
			//   __m128i v81; // xmm9
			//   __int128 v82; // xmm0
			//   __int128 v83; // xmm1
			//   __int128 v84; // xmm0
			//   __m128i v85; // xmm8
			//   __int128 v86; // xmm0
			//   __int128 v87; // xmm0
			//   __m128i v88; // xmm7
			//   __int128 v89; // xmm0
			//   __int128 v90; // xmm1
			//   __int128 v91; // xmm0
			//   __m128i v92; // xmm6
			//   Quaternion v93; // xmm5
			//   MethodInfo *v94; // r9
			//   __m128i v95; // xmm4
			//   MethodInfo *v96; // r9
			//   __m128i v97; // xmm4
			//   MethodInfo *v98; // r9
			//   __m128i v99; // xmm4
			//   MethodInfo *v100; // r9
			//   __m128i v101; // xmm4
			//   MethodInfo *v102; // r9
			//   __m128i v103; // xmm4
			//   MethodInfo *v104; // r9
			//   __m128i v105; // xmm4
			//   MethodInfo *v106; // r9
			//   __m128 v107; // xmm15
			//   Quaternion v108; // xmm5
			//   MethodInfo *v109; // r9
			//   float4 *v110; // rax
			//   MethodInfo *v111; // r9
			//   __m128i v112; // xmm5
			//   MethodInfo *v113; // r9
			//   __m128i v114; // xmm5
			//   MethodInfo *v115; // r9
			//   __m128i v116; // xmm5
			//   MethodInfo *v117; // r9
			//   __m128i v118; // xmm5
			//   MethodInfo *v119; // r9
			//   __m128i v120; // xmm5
			//   MethodInfo *v121; // r9
			//   float v122; // xmm0_4
			//   __m128 v123; // xmm11
			//   float v124; // xmm9_4
			//   float v125; // r12d
			//   MethodInfo *v126; // r9
			//   float3 *v127; // rax
			//   __int64 v128; // xmm6_8
			//   float v129; // ebx
			//   Transform *v130; // rax
			//   Vector3 *v131; // rax
			//   __int64 v132; // xmm0_8
			//   float3 *v133; // rax
			//   __int64 v134; // xmm0_8
			//   float3 *v135; // rax
			//   __int64 v136; // xmm0_8
			//   __int64 v137; // rax
			//   __int64 v138; // xmm0_8
			//   float3 *v139; // rax
			//   float v140; // xmm0_4
			//   float v141; // xmm6_4
			//   __int64 v142; // rax
			//   __int64 v143; // xmm0_8
			//   float3 *v144; // rax
			//   __int64 v145; // xmm0_8
			//   Transform *v146; // rax
			//   Vector3 *v147; // rax
			//   __int64 v148; // xmm0_8
			//   __int64 v149; // rax
			//   __int64 v150; // xmm0_8
			//   float3 *v151; // rax
			//   __int64 v152; // xmm0_8
			//   float v153; // xmm6_4
			//   float v154; // xmm0_4
			//   float x; // xmm6_4
			//   __int64 v156; // rax
			//   Transform *v157; // rax
			//   Vector3 *forward; // rax
			//   __int64 v159; // xmm0_8
			//   __int64 v160; // rax
			//   __int64 v161; // rax
			//   float3 *v162; // rax
			//   __int64 v163; // xmm0_8
			//   Vector4 *v164; // rax
			//   __int64 v165; // rax
			//   __int64 v166; // xmm0_8
			//   MethodInfo *v167; // r9
			//   float3 *v168; // rax
			//   __int64 v169; // xmm3_8
			//   MethodInfo *v170; // r9
			//   float3 *v171; // rax
			//   float3 *v172; // rbx
			//   __int64 v173; // rax
			//   __int64 v174; // xmm0_8
			//   MethodInfo *v175; // r9
			//   float3 *v176; // rax
			//   __int64 v177; // xmm0_8
			//   __int64 v178; // xmm3_8
			//   MethodInfo *v179; // r9
			//   float3 *v180; // rax
			//   __int64 v181; // xmm6_8
			//   float v182; // edi
			//   __int64 v183; // rax
			//   __int64 v184; // xmm0_8
			//   float3 *v185; // rax
			//   float v186; // edx
			//   __int64 v187; // xmm0_8
			//   __int64 v188; // rax
			//   __int64 v189; // xmm0_8
			//   __int64 v190; // rax
			//   __int64 v191; // xmm0_8
			//   MethodInfo *v192; // r8
			//   float3 *v193; // rax
			//   __int64 v194; // xmm3_8
			//   quaternion *v195; // rbx
			//   Quaternion v196; // xmm0
			//   float4x4 *v197; // rax
			//   float4 v198; // xmm1
			//   float4 v199; // xmm0
			//   float4 v200; // xmm1
			//   Matrix4x4 *v201; // rax
			//   __int128 v202; // xmm4
			//   __int128 v203; // xmm5
			//   __int128 v204; // xmm6
			//   int v205; // edx
			//   int v206; // r8d
			//   int v207; // r9d
			//   _OWORD *v208; // rax
			//   __int128 v209; // xmm1
			//   __int128 v210; // xmm0
			//   __int128 v211; // xmm1
			//   Matrix4x4 *v212; // rax
			//   __int128 v213; // xmm1
			//   __int128 v214; // xmm2
			//   __int128 v215; // xmm3
			//   __int128 v216; // xmm1
			//   __int128 v217; // xmm0
			//   __int128 v218; // xmm1
			//   Quaternion vector_8; // [rsp+48h] [rbp-C0h] BYREF
			//   __m128i v220; // [rsp+58h] [rbp-B0h] BYREF
			//   float4 v221; // [rsp+68h] [rbp-A0h] BYREF
			//   float4 v222; // [rsp+78h] [rbp-90h] BYREF
			//   __m128i v223; // [rsp+88h] [rbp-80h] BYREF
			//   float4 value; // [rsp+98h] [rbp-70h] BYREF
			//   float v225; // [rsp+A8h] [rbp-60h]
			//   float4 v226; // [rsp+B8h] [rbp-50h] BYREF
			//   _BYTE v227[24]; // [rsp+C8h] [rbp-40h] BYREF
			//   Matrix4x4 v228; // [rsp+E8h] [rbp-20h] BYREF
			//   float3 v229; // [rsp+128h] [rbp+20h] BYREF
			//   float4 v230; // [rsp+138h] [rbp+30h]
			//   float v231; // [rsp+148h] [rbp+40h]
			//   Matrix4x4 v232[3]; // [rsp+158h] [rbp+50h] BYREF
			// 
			//   if ( !byte_18D919E79 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::Unity::Mathematics::float3);
			//     byte_18D919E79 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1784, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1784, 0LL);
			//     if ( Patch )
			//     {
			//       v216 = *(_OWORD *)&lightTransform.m01;
			//       *(_OWORD *)&v228.m00 = *(_OWORD *)&lightTransform.m00;
			//       v217 = *(_OWORD *)&lightTransform.m02;
			//       *(_OWORD *)&v228.m01 = v216;
			//       v218 = *(_OWORD *)&lightTransform.m03;
			//       *(_OWORD *)&v228.m02 = v217;
			//       *(_OWORD *)&v228.m03 = v218;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_692(
			//         (ILFixDynamicMethodWrapper_2 *)Patch,
			//         &v228,
			//         (Object *)hgCamera,
			//         (Object *)characterHelper,
			//         worldToLightMatrices,
			//         projectionMatrix,
			//         lightDirection,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_55;
			//   }
			//   if ( !characterHelper )
			//     goto LABEL_55;
			//   v13 = *(_QWORD *)&characterHelper.fields.bounds.m_Extents.y;
			//   *(_OWORD *)v227 = *(_OWORD *)&characterHelper.fields.bounds.m_Center.x;
			//   *(_QWORD *)&v227[16] = v13;
			//   *(_QWORD *)&vector_8.x = *(_QWORD *)v227;
			//   LODWORD(vector_8.z) = _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&characterHelper.fields.bounds.m_Center.z));
			//   xyz = Unity::Mathematics::float4::get_xyz((float3 *)&v226, (float4 *)&vector_8, 0LL);
			//   z = xyz.z;
			//   *(_QWORD *)&v222.x = *(_QWORD *)&xyz.x;
			//   v231 = z;
			//   vector_8.z = *(float *)&v227[20];
			//   *(_QWORD *)&vector_8.x = *(_QWORD *)&v227[12];
			//   v16 = Unity::Mathematics::float4::get_xyz(&v229, (float4 *)&vector_8, 0LL);
			//   v17 = *(_QWORD *)&xyz.x;
			//   v18 = *(_QWORD *)&v16.x;
			//   v19 = v16.z;
			//   *(float *)&v16 = xyz.z;
			//   *(_QWORD *)&value.x = v18;
			//   v225 = *(float *)&v16;
			//   v230.x = v19;
			//   if ( !hgCamera )
			//     goto LABEL_55;
			//   Patch = hgCamera.fields.camera;
			//   if ( !Patch )
			//     goto LABEL_55;
			//   transform = UnityEngine::Component::get_transform((Component *)Patch, 0LL);
			//   if ( !transform )
			//     goto LABEL_55;
			//   position = UnityEngine::Transform::get_position((Vector3 *)&v226, transform, 0LL);
			//   v22 = *(_QWORD *)&position.x;
			//   *(float *)&position = position.z;
			//   *(_QWORD *)&vector_8.x = v22;
			//   LODWORD(vector_8.z) = (_DWORD)position;
			//   v23 = Unity::Mathematics::float4::get_xyz((float3 *)&v226, (float4 *)&vector_8, 0LL);
			//   v24 = *(_QWORD *)&v23.x;
			//   v25 = v23.z;
			//   v220 = *(__m128i *)UnityEngine::Matrix4x4::get_rotation((Quaternion *)&v220, lightTransform, 0LL);
			//   AsVector4 = Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                 (Vector4 *)&v223,
			//                 (CinemachineSmoothPath_Waypoint *)&v220,
			//                 0LL);
			//   m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//   v28 = _mm_loadu_si128((const __m128i *)AsVector4);
			//   if ( !m_volumeComponentsData )
			//     goto LABEL_55;
			//   m_hgCharacterVolume = (Object_1 *)m_volumeComponentsData.fields.m_hgCharacterVolume;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Inequality(m_hgCharacterVolume, 0LL, 0LL) )
			//   {
			// LABEL_16:
			//     v36 = v225;
			//     goto LABEL_17;
			//   }
			//   if ( !m_hgCharacterVolume )
			//     goto LABEL_55;
			//   CharacterSelfShadowMode = HG::Rendering::Runtime::HGCharacterVolume::GetCharacterSelfShadowMode(
			//                               (HGCharacterVolume *)m_hgCharacterVolume,
			//                               0LL);
			//   klass = m_hgCharacterVolume[8].klass;
			//   if ( CharacterSelfShadowMode != HGCharacterVolume_CharacterShadowMode__Enum_CameraVirtualLight )
			//   {
			//     if ( !klass )
			//       goto LABEL_55;
			//     if ( (unsigned int)sub_18003ED00(10LL) == 2 )
			//     {
			//       static_fields = TypeInfo::Unity::Mathematics::float3.static_fields;
			//       v32 = *(_QWORD *)&static_fields.zero.x;
			//       v33 = static_fields.zero.z;
			//       klass = m_hgCharacterVolume[8].monitor;
			//       *(_QWORD *)&vector_8.x = v32;
			//       if ( klass )
			//       {
			//         *(_QWORD *)&v230.x = sub_18004A780(10LL);
			//         *(_QWORD *)&vector_8.x = _mm_unpacklo_ps((__m128)LODWORD(v230.x), (__m128)LODWORD(v230.y)).m128_u64[0];
			//         vector_8.z = v33;
			//         v34 = Unity::Mathematics::float4::get_xyz((float3 *)&v226, (float4 *)&vector_8, 0LL);
			//         v35 = *(_QWORD *)&v34.x;
			//         *(float *)&v34 = v34.z;
			//         *(_QWORD *)&vector_8.x = v35;
			//         LODWORD(vector_8.z) = (_DWORD)v34;
			//         v220 = *(__m128i *)sub_182504CA0(&v220, &vector_8);
			//         v28 = _mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                                                  (Vector4 *)&v223,
			//                                                  (CinemachineSmoothPath_Waypoint *)&v220,
			//                                                  0LL));
			//         goto LABEL_16;
			//       }
			// LABEL_55:
			//       sub_180B536AC(Patch, klass);
			//     }
			//     goto LABEL_16;
			//   }
			//   Patch = TypeInfo::Unity::Mathematics::float3.static_fields;
			//   v125 = *((float *)Patch + 2);
			//   *(_QWORD *)&v226.x = *(_QWORD *)Patch;
			//   if ( !klass )
			//     goto LABEL_55;
			//   if ( (unsigned int)sub_18003ED00(10LL) == 2 )
			//   {
			//     Patch = hgCamera.fields.camera;
			//     if ( !Patch )
			//       goto LABEL_55;
			//     v157 = UnityEngine::Component::get_transform((Component *)Patch, 0LL);
			//     if ( !v157 )
			//       goto LABEL_55;
			//     forward = UnityEngine::Transform::get_forward((Vector3 *)&v221, v157, 0LL);
			//     v159 = *(_QWORD *)&forward.x;
			//     *(float *)&forward = forward.z;
			//     *(_QWORD *)&vector_8.x = v159;
			//     LODWORD(vector_8.z) = (_DWORD)forward;
			//     vector_8 = *UnityEngine::Quaternion::LookRotation((Quaternion *)&v220, (Vector3 *)&vector_8, 0LL);
			//     v160 = sub_182504AA0(&v221, &vector_8);
			//     klass = m_hgCharacterVolume[8].monitor;
			//     v226.y = *(float *)(v160 + 4);
			//     if ( !klass )
			//       goto LABEL_55;
			//     v161 = sub_18004A780(10LL);
			//     v36 = v225;
			//     *(_QWORD *)&v229.x = v161;
			//     LODWORD(v145) = v161;
			//     goto LABEL_49;
			//   }
			//   klass = m_hgCharacterVolume[8].klass;
			//   if ( !klass )
			//     goto LABEL_55;
			//   if ( (unsigned int)sub_18003ED00(10LL) != 1 )
			//   {
			//     v36 = v225;
			//     v229.z = v225;
			//     *(_QWORD *)&vector_8.x = v24;
			//     vector_8.z = v25;
			//     *(_QWORD *)&v229.x = v17;
			//     v127 = Unity::Mathematics::float3::op_Subtraction((float3 *)&v221, &v229, (float3 *)&vector_8, v126);
			//     Patch = hgCamera.fields.camera;
			//     v128 = *(_QWORD *)&v127.x;
			//     v129 = v127.z;
			//     if ( !Patch )
			//       goto LABEL_55;
			//     if ( UnityEngine::Camera::get_orthographic((Camera *)Patch, 0LL) )
			//     {
			//       Patch = hgCamera.fields.camera;
			//       if ( !Patch )
			//         goto LABEL_55;
			//       v130 = UnityEngine::Component::get_transform((Component *)Patch, 0LL);
			//       if ( !v130 )
			//         goto LABEL_55;
			//       v131 = UnityEngine::Transform::get_forward((Vector3 *)&v221, v130, 0LL);
			//       v132 = *(_QWORD *)&v131.x;
			//       *(float *)&v131 = v131.z;
			//       *(_QWORD *)&vector_8.x = v132;
			//       LODWORD(vector_8.z) = (_DWORD)v131;
			//       v133 = Unity::Mathematics::float4::get_xyz((float3 *)&v221, (float4 *)&vector_8, 0LL);
			//       v134 = *(_QWORD *)&v133.x;
			//       v129 = v133.z;
			//     }
			//     else
			//     {
			//       v134 = v128;
			//     }
			//     *(_QWORD *)&vector_8.x = v134;
			//     vector_8.z = v129;
			//     v135 = Unity::Mathematics::float4::get_xyz((float3 *)&v221, (float4 *)&vector_8, 0LL);
			//     v136 = *(_QWORD *)&v135.x;
			//     *(float *)&v135 = v135.z;
			//     *(_QWORD *)&vector_8.x = v136;
			//     LODWORD(vector_8.z) = (_DWORD)v135;
			//     vector_8 = *UnityEngine::Quaternion::LookRotation((Quaternion *)&v220, (Vector3 *)&vector_8, 0LL);
			//     v137 = sub_182504AA0(&v221, &vector_8);
			//     v138 = *(_QWORD *)v137;
			//     LODWORD(v137) = *(_DWORD *)(v137 + 8);
			//     *(_QWORD *)&vector_8.x = v138;
			//     LODWORD(vector_8.z) = v137;
			//     v139 = Unity::Mathematics::float4::get_xyz((float3 *)&v221, (float4 *)&vector_8, 0LL);
			//     v125 = v139.z;
			//     *(_QWORD *)&v226.x = *(_QWORD *)&v139.x;
			//     if ( v226.x <= 180.0 )
			//       v140 = 0.0;
			//     else
			//       v140 = 360.0;
			//     v141 = v226.x - v140;
			//     vector_8 = *UnityEngine::Matrix4x4::get_rotation((Quaternion *)&v220, lightTransform, 0LL);
			//     v142 = sub_182504AA0(&v221, &vector_8);
			//     v143 = *(_QWORD *)v142;
			//     LODWORD(v142) = *(_DWORD *)(v142 + 8);
			//     *(_QWORD *)&vector_8.x = v143;
			//     LODWORD(vector_8.z) = v142;
			//     v144 = Unity::Mathematics::float4::get_xyz((float3 *)&v221, (float4 *)&vector_8, 0LL);
			//     v145 = *(_QWORD *)&v144.x;
			//     *(float *)&v144 = v144.z;
			//     *(_QWORD *)&vector_8.x = v145;
			//     LODWORD(vector_8.z) = (_DWORD)v144;
			//     if ( *(float *)&v145 >= 45.0 )
			//       LODWORD(v145) = 1110704128;
			//     if ( v141 > *(float *)&v145 )
			//       *(float *)&v145 = v141;
			// LABEL_49:
			//     LODWORD(v226.x) = v145;
			//     goto LABEL_50;
			//   }
			//   Patch = hgCamera.fields.camera;
			//   if ( !Patch )
			//     goto LABEL_55;
			//   v146 = UnityEngine::Component::get_transform((Component *)Patch, 0LL);
			//   if ( !v146 )
			//     goto LABEL_55;
			//   v147 = UnityEngine::Transform::get_forward((Vector3 *)&v221, v146, 0LL);
			//   v148 = *(_QWORD *)&v147.x;
			//   *(float *)&v147 = v147.z;
			//   *(_QWORD *)&vector_8.x = v148;
			//   LODWORD(vector_8.z) = (_DWORD)v147;
			//   vector_8 = *UnityEngine::Quaternion::LookRotation((Quaternion *)&v220, (Vector3 *)&vector_8, 0LL);
			//   v149 = sub_182504AA0(&v221, &vector_8);
			//   v150 = *(_QWORD *)v149;
			//   LODWORD(v149) = *(_DWORD *)(v149 + 8);
			//   *(_QWORD *)&vector_8.x = v150;
			//   LODWORD(vector_8.z) = v149;
			//   v151 = Unity::Mathematics::float4::get_xyz((float3 *)&v221, (float4 *)&vector_8, 0LL);
			//   v152 = *(_QWORD *)&v151.x;
			//   *(float *)&v151 = v151.z;
			//   *(_QWORD *)&vector_8.x = v152;
			//   v153 = *(float *)&v152;
			//   LODWORD(vector_8.z) = (_DWORD)v151;
			//   v154 = *(float *)&v152 <= 180.0 ? 0.0 : 360.0;
			//   klass = m_hgCharacterVolume[8].fields.m_CachedPtr;
			//   x = v153 - v154;
			//   if ( !klass )
			//     goto LABEL_55;
			//   v156 = sub_18004A780(10LL);
			//   klass = m_hgCharacterVolume[8].fields.m_CachedPtr;
			//   *(_QWORD *)&v229.x = v156;
			//   v226.y = *((float *)&v156 + 1) + vector_8.y;
			//   if ( !klass )
			//     goto LABEL_55;
			//   *(_QWORD *)&v229.x = sub_18004A780(10LL);
			//   if ( v229.x > x )
			//     x = v229.x;
			//   v36 = v225;
			//   v226.x = x;
			// LABEL_50:
			//   *(_QWORD *)&vector_8.x = *(_QWORD *)&v226.x;
			//   vector_8.z = v125;
			//   v162 = Unity::Mathematics::float4::get_xyz((float3 *)&v221, (float4 *)&vector_8, 0LL);
			//   v163 = *(_QWORD *)&v162.x;
			//   *(float *)&v162 = v162.z;
			//   *(_QWORD *)&vector_8.x = v163;
			//   LODWORD(vector_8.z) = (_DWORD)v162;
			//   v220 = *(__m128i *)sub_182504CA0(&v220, &vector_8);
			//   v164 = Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//            (Vector4 *)&v223,
			//            (CinemachineSmoothPath_Waypoint *)&v220,
			//            0LL);
			//   v19 = v230.x;
			//   v28 = _mm_loadu_si128((const __m128i *)v164);
			// LABEL_17:
			//   v220 = v28;
			//   v37 = sub_184D32D74(&v221, &v220);
			//   v38 = value.x;
			//   y = value.y;
			//   *(_QWORD *)&vector_8.x = _mm_unpacklo_ps((__m128)LODWORD(value.x), (__m128)LODWORD(value.y)).m128_u64[0];
			//   v40 = *(_QWORD *)v37;
			//   LODWORD(v37) = *(_DWORD *)(v37 + 8);
			//   *(_QWORD *)&v226.x = v40;
			//   LODWORD(v226.z) = v37;
			//   vector_8.z = v19;
			//   *(_QWORD *)&value.x = v18;
			//   value.z = v19;
			//   Dest::Math::Vector3ex::Dot((Vector3 *)&vector_8, (Vector3 *)&value, v41);
			//   *(float *)&v40 = sub_1802ECED0(v43, v42, v44, v45);
			//   v47 = Unity::Mathematics::float3::op_Multiply((float3 *)&v221, (float3 *)&v226, -*(float *)&v40, v46);
			//   *(_QWORD *)&vector_8.x = v17;
			//   vector_8.z = v36;
			//   v48 = *(_QWORD *)&v47.x;
			//   *(float *)&v47 = v47.z;
			//   *(_QWORD *)&value.x = v48;
			//   LODWORD(value.z) = (_DWORD)v47;
			//   v50 = Unity::Mathematics::float3::op_Addition((float3 *)&v221, (float3 *)&vector_8, (float3 *)&value, v49);
			//   v51 = v50.z;
			//   *(_QWORD *)&v229.x = *(_QWORD *)&v50.x;
			//   sub_1802F01E0(v232, 0LL, 64LL);
			//   *(_QWORD *)&value.x = *(_QWORD *)&v50.x;
			//   value.z = v51;
			//   v220 = v28;
			//   Unity::Mathematics::float4x4::float4x4((float4x4 *)v232, (quaternion *)&v220, (float3 *)&value, 0LL);
			//   v228 = v232[0];
			//   v52 = Unity::Mathematics::math::inverse((float4x4 *)v232, (float4x4 *)&v228, 0LL);
			//   v53 = v222.x;
			//   *(float *)&v48 = v222.y;
			//   v221.w = 1.0;
			//   v54 = (__int128 *)v52;
			//   v221.x = v222.x - v38;
			//   v221.z = v231 - v19;
			//   v222.w = 1.0;
			//   value.w = 1.0;
			//   vector_8.w = 1.0;
			//   v226.w = 1.0;
			//   v230.w = 1.0;
			//   v222.x = v38 + v222.x;
			//   v223.m128i_i32[3] = 1065353216;
			//   v222.y = y + v222.y;
			//   v221.y = v222.y;
			//   v220.m128i_i32[3] = 1065353216;
			//   v222.z = v231 - v19;
			//   value.x = v53 - v38;
			//   value.y = *(float *)&v48 - y;
			//   value.z = v231 - v19;
			//   vector_8.x = v38 + v53;
			//   vector_8.y = *(float *)&v48 - y;
			//   vector_8.z = v231 - v19;
			//   v226.x = v53 - v38;
			//   v226.y = y + *(float *)&v48;
			//   v226.z = v19 + v231;
			//   v230.x = v38 + v53;
			//   v230.y = y + *(float *)&v48;
			//   v230.z = v19 + v231;
			//   *(float *)v223.m128i_i32 = v53 - v38;
			//   *(float *)v220.m128i_i32 = v38 + v53;
			//   *(float *)&v223.m128i_i32[1] = *(float *)&v48 - y;
			//   *(float *)&v223.m128i_i32[2] = v19 + v231;
			//   c1 = v52.c1;
			//   *(float4 *)&v228.m00 = v52.c0;
			//   c2 = v52.c2;
			//   *(float4 *)&v228.m01 = c1;
			//   c3 = v52.c3;
			//   *(float *)&v220.m128i_i32[1] = *(float *)&v48 - y;
			//   *(float4 *)&v228.m03 = c3;
			//   *(float *)&v220.m128i_i32[2] = v19 + v231;
			//   *(float4 *)&v228.m02 = c2;
			//   v58 = _mm_loadu_si128((const __m128i *)sub_18238B530(v227, &v228, &v221));
			//   v59 = *v54;
			//   v221 = v222;
			//   v60 = v54[1];
			//   *(_OWORD *)&v228.m00 = v59;
			//   v61 = v54[2];
			//   *(_OWORD *)&v228.m01 = v60;
			//   v62 = v54[3];
			//   *(_OWORD *)&v228.m02 = v61;
			//   *(_OWORD *)&v228.m03 = v62;
			//   sub_18238B530(v227, &v228, &v221);
			//   v63 = *v54;
			//   v221 = value;
			//   v64 = v54[1];
			//   *(_OWORD *)&v228.m00 = v63;
			//   v65 = v54[2];
			//   *(_OWORD *)&v228.m01 = v64;
			//   v66 = v54[3];
			//   *(_OWORD *)&v228.m02 = v65;
			//   *(_OWORD *)&v228.m03 = v66;
			//   v67 = (const __m128i *)sub_18238B530(v227, &v228, &v221);
			//   v68 = *v54;
			//   v69 = _mm_loadu_si128(v67);
			//   v221 = (float4)vector_8;
			//   v70 = v54[1];
			//   *(_OWORD *)&v228.m00 = v68;
			//   v71 = v54[2];
			//   *(_OWORD *)&v228.m01 = v70;
			//   v72 = v54[3];
			//   *(_OWORD *)&v228.m02 = v71;
			//   *(_OWORD *)&v228.m03 = v72;
			//   v73 = (const __m128i *)sub_18238B530(v227, &v228, &v221);
			//   v74 = *v54;
			//   v75 = _mm_loadu_si128(v73);
			//   v221 = v226;
			//   v76 = v54[1];
			//   *(_OWORD *)&v228.m00 = v74;
			//   v77 = v54[2];
			//   *(_OWORD *)&v228.m01 = v76;
			//   v78 = v54[3];
			//   *(_OWORD *)&v228.m02 = v77;
			//   *(_OWORD *)&v228.m03 = v78;
			//   v79 = (const __m128i *)sub_18238B530(v227, &v228, &v221);
			//   v80 = *v54;
			//   v81 = _mm_loadu_si128(v79);
			//   v221 = v230;
			//   v82 = v54[1];
			//   *(_OWORD *)&v228.m00 = v80;
			//   v83 = v54[2];
			//   *(_OWORD *)&v228.m01 = v82;
			//   v84 = v54[3];
			//   *(_OWORD *)&v228.m02 = v83;
			//   *(_OWORD *)&v228.m03 = v84;
			//   v85 = _mm_loadu_si128((const __m128i *)sub_18238B530(v227, &v228, &v221));
			//   v86 = v54[1];
			//   *(_OWORD *)&v228.m00 = *v54;
			//   *(_OWORD *)&v228.m01 = v86;
			//   v87 = v54[3];
			//   *(_OWORD *)&v228.m02 = v54[2];
			//   *(_OWORD *)&v228.m03 = v87;
			//   v88 = _mm_loadu_si128((const __m128i *)sub_18238B530(v227, &v228, &v223));
			//   v89 = v54[1];
			//   *(_OWORD *)&v228.m00 = *v54;
			//   v90 = v54[2];
			//   *(_OWORD *)&v228.m01 = v89;
			//   v91 = v54[3];
			//   *(_OWORD *)&v228.m02 = v90;
			//   *(_OWORD *)&v228.m03 = v91;
			//   v92 = _mm_loadu_si128((const __m128i *)sub_18238B530(v227, &v228, &v220));
			//   v220 = (__m128i)v93;
			//   v223 = v58;
			//   v95 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
			//                                            (float4 *)v227,
			//                                            (float4 *)&v223,
			//                                            (float4 *)&v220,
			//                                            v94));
			//   v220 = v69;
			//   v223 = v95;
			//   v97 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
			//                                            (float4 *)v227,
			//                                            (float4 *)&v223,
			//                                            (float4 *)&v220,
			//                                            v96));
			//   v220 = v75;
			//   v223 = v97;
			//   v99 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
			//                                            (float4 *)v227,
			//                                            (float4 *)&v223,
			//                                            (float4 *)&v220,
			//                                            v98));
			//   v220 = v81;
			//   v223 = v99;
			//   v101 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
			//                                             (float4 *)v227,
			//                                             (float4 *)&v223,
			//                                             (float4 *)&v220,
			//                                             v100));
			//   v220 = v85;
			//   v223 = v101;
			//   v103 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
			//                                             (float4 *)v227,
			//                                             (float4 *)&v223,
			//                                             (float4 *)&v220,
			//                                             v102));
			//   v220 = v88;
			//   v223 = v103;
			//   v105 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
			//                                             (float4 *)v227,
			//                                             (float4 *)&v223,
			//                                             (float4 *)&v220,
			//                                             v104));
			//   v220 = v92;
			//   v223 = v105;
			//   v107 = (__m128)_mm_loadu_si128((const __m128i *)Unity::Mathematics::math::min(
			//                                                     (float4 *)v227,
			//                                                     (float4 *)&v223,
			//                                                     (float4 *)&v220,
			//                                                     v106));
			//   v220 = (__m128i)v108;
			//   v223 = v58;
			//   v110 = Unity::Mathematics::math::max((float4 *)v227, (float4 *)&v223, (float4 *)&v220, v109);
			//   v220 = v69;
			//   v223 = _mm_loadu_si128((const __m128i *)v110);
			//   v112 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::max(
			//                                             (float4 *)v227,
			//                                             (float4 *)&v223,
			//                                             (float4 *)&v220,
			//                                             v111));
			//   v220 = v75;
			//   v223 = v112;
			//   v114 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::max(
			//                                             (float4 *)v227,
			//                                             (float4 *)&v223,
			//                                             (float4 *)&v220,
			//                                             v113));
			//   v220 = v81;
			//   v223 = v114;
			//   v116 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::max(
			//                                             (float4 *)v227,
			//                                             (float4 *)&v223,
			//                                             (float4 *)&v220,
			//                                             v115));
			//   v220 = v85;
			//   v223 = v116;
			//   v118 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::max(
			//                                             (float4 *)v227,
			//                                             (float4 *)&v223,
			//                                             (float4 *)&v220,
			//                                             v117));
			//   v220 = v88;
			//   v223 = v118;
			//   v120 = _mm_loadu_si128((const __m128i *)Unity::Mathematics::math::max(
			//                                             (float4 *)v227,
			//                                             (float4 *)&v223,
			//                                             (float4 *)&v220,
			//                                             v119));
			//   v220 = v92;
			//   v223 = v120;
			//   LODWORD(v122) = _mm_shuffle_ps(v107, v107, 170).m128_u32[0];
			//   v123 = (__m128)_mm_loadu_si128((const __m128i *)Unity::Mathematics::math::max(
			//                                                     (float4 *)v227,
			//                                                     (float4 *)&v223,
			//                                                     (float4 *)&v220,
			//                                                     v121));
			//   LODWORD(v124) = _mm_shuffle_ps(v123, v123, 170).m128_u32[0];
			//   if ( v122 > v124 )
			//     v124 = v122;
			//   v222.z = 0.0;
			//   *(_QWORD *)&v222.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0LL).m128_u64[0];
			//   v220 = v28;
			//   v165 = sub_182344DC0(&v221, &v220, &v222);
			//   v166 = *(_QWORD *)v165;
			//   LODWORD(v165) = *(_DWORD *)(v165 + 8);
			//   *(_QWORD *)&v222.x = v166;
			//   LODWORD(v222.z) = v165;
			//   v168 = Unity::Mathematics::float3::op_Multiply(
			//            (float3 *)&v221,
			//            (float3 *)&v222,
			//            (float)(v107.m128_f32[0] + v123.m128_f32[0]) * 0.5,
			//            v167);
			//   *(_QWORD *)&value.x = *(_QWORD *)&v229.x;
			//   value.z = v51;
			//   v169 = *(_QWORD *)&v168.x;
			//   *(float *)&v168 = v168.z;
			//   *(_QWORD *)&v222.x = v169;
			//   LODWORD(v222.z) = (_DWORD)v168;
			//   v171 = Unity::Mathematics::float3::op_Addition((float3 *)&v221, (float3 *)&value, (float3 *)&v222, v170);
			//   v222.z = 0.0;
			//   *(_QWORD *)&v222.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//   v220 = v28;
			//   v172 = v171;
			//   v173 = sub_182344DC0(&value, &v220, &v222);
			//   v174 = *(_QWORD *)v173;
			//   LODWORD(v173) = *(_DWORD *)(v173 + 8);
			//   *(_QWORD *)&v222.x = v174;
			//   LODWORD(v222.z) = v173;
			//   v176 = Unity::Mathematics::float3::op_Multiply(
			//            (float3 *)&value,
			//            (float3 *)&v222,
			//            (float)(_mm_shuffle_ps(v107, v107, 85).m128_f32[0] + _mm_shuffle_ps(v123, v123, 85).m128_f32[0]) * 0.5,
			//            v175);
			//   v177 = *(_QWORD *)&v172.x;
			//   v178 = *(_QWORD *)&v176.x;
			//   v222.z = v176.z;
			//   value.z = v172.z;
			//   *(_QWORD *)&v222.x = v178;
			//   *(_QWORD *)&value.x = v177;
			//   v180 = Unity::Mathematics::float3::op_Addition((float3 *)&v221, (float3 *)&value, (float3 *)&v222, v179);
			//   v220 = v28;
			//   v181 = *(_QWORD *)&v180.x;
			//   v182 = v180.z;
			//   v183 = sub_184D32D74(&v221, &v220);
			//   v184 = *(_QWORD *)v183;
			//   LODWORD(v183) = *(_DWORD *)(v183 + 8);
			//   *(_QWORD *)&v222.x = v184;
			//   LODWORD(v222.z) = v183;
			//   v185 = Unity::Mathematics::float4::get_xyz((float3 *)&v221, &v222, 0LL);
			//   v186 = v185.z;
			//   v187 = *(_QWORD *)&v185.x;
			//   v220 = v28;
			//   *(_QWORD *)&lightDirection.x = v187;
			//   lightDirection.z = v186;
			//   v188 = sub_184D32D74(&v221, &v220);
			//   v222.z = 0.0;
			//   v220 = v28;
			//   v189 = *(_QWORD *)v188;
			//   LODWORD(v188) = *(_DWORD *)(v188 + 8);
			//   *(_QWORD *)&value.x = v189;
			//   *(_QWORD *)&v222.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//   LODWORD(value.z) = v188;
			//   v190 = sub_182344DC0(&v221, &v220, &v222);
			//   v191 = *(_QWORD *)v190;
			//   LODWORD(v190) = *(_DWORD *)(v190 + 8);
			//   *(_QWORD *)&v222.x = v191;
			//   LODWORD(v222.z) = v190;
			//   v193 = Unity::Mathematics::float3::op_UnaryNegation((float3 *)&v221, (float3 *)&value, v192);
			//   v194 = *(_QWORD *)&v193.x;
			//   *(float *)&v193 = v193.z;
			//   *(_QWORD *)&value.x = v194;
			//   LODWORD(value.z) = (_DWORD)v193;
			//   v195 = Unity::Mathematics::quaternion::LookRotationSafe((quaternion *)v227, (float3 *)&value, (float3 *)&v222, 0LL);
			//   sub_1802F01E0(v232, 0LL, 64LL);
			//   v196 = (Quaternion)*v195;
			//   *(_QWORD *)&v222.x = v181;
			//   v222.z = v182;
			//   v220 = (__m128i)v196;
			//   Unity::Mathematics::float4x4::float4x4((float4x4 *)v232, (quaternion *)&v220, (float3 *)&v222, 0LL);
			//   v228 = v232[0];
			//   v197 = Unity::Mathematics::math::inverse((float4x4 *)v232, (float4x4 *)&v228, 0LL);
			//   v198 = v197.c1;
			//   *(float4 *)&v228.m00 = v197.c0;
			//   v199 = v197.c2;
			//   *(float4 *)&v228.m01 = v198;
			//   v200 = v197.c3;
			//   *(float4 *)&v228.m02 = v199;
			//   *(float4 *)&v228.m03 = v200;
			//   v201 = Unity::Mathematics::float4x4::op_Implicit(v232, (float4x4 *)&v228, 0LL);
			//   v202 = *(_OWORD *)&v201.m01;
			//   v203 = *(_OWORD *)&v201.m02;
			//   v204 = *(_OWORD *)&v201.m03;
			//   *(_OWORD *)&worldToLightMatrices.m00 = *(_OWORD *)&v201.m00;
			//   *(_OWORD *)&worldToLightMatrices.m01 = v202;
			//   *(_OWORD *)&worldToLightMatrices.m02 = v203;
			//   *(_OWORD *)&worldToLightMatrices.m03 = v204;
			//   v208 = (_OWORD *)sub_182A59E70((unsigned int)v232, v205, v206, v207, LODWORD(v124));
			//   v209 = v208[1];
			//   *(_OWORD *)&v228.m00 = *v208;
			//   v210 = v208[2];
			//   *(_OWORD *)&v228.m01 = v209;
			//   v211 = v208[3];
			//   *(_OWORD *)&v228.m02 = v210;
			//   *(_OWORD *)&v228.m03 = v211;
			//   v212 = Unity::Mathematics::float4x4::op_Implicit(v232, (float4x4 *)&v228, 0LL);
			//   v213 = *(_OWORD *)&v212.m01;
			//   v214 = *(_OWORD *)&v212.m02;
			//   v215 = *(_OWORD *)&v212.m03;
			//   *(_OWORD *)&projectionMatrix.m00 = *(_OWORD *)&v212.m00;
			//   *(_OWORD *)&projectionMatrix.m01 = v213;
			//   *(_OWORD *)&projectionMatrix.m02 = v214;
			//   *(_OWORD *)&projectionMatrix.m03 = v215;
			// }
			// 
		}

		private void SetupCharacterShadowReceiverConstants(in VisibleLight shadowLight, int characterShadowCount)
		{
			// // Void SetupCharacterShadowReceiverConstants(VisibleLight ByRef, Int32)
			// void HG::Rendering::Runtime::HGShadowManager::SetupCharacterShadowReceiverConstants(
			//         HGShadowManager *this,
			//         VisibleLight *shadowLight,
			//         int32_t characterShadowCount,
			//         MethodInfo *method)
			// {
			//   LightShadows__Enum shadows_Injected; // ebx
			//   int v8; // xmm6_4
			//   float v9; // xmm7_4
			//   float v10; // xmm8_4
			//   int v11; // esi
			//   __int64 v12; // r14
			//   int32_t v13; // ebp
			//   __int64 v14; // r15
			//   __int64 v15; // rdx
			//   void *m_CharacterShadowMatrices; // rcx
			//   HGShadowConstantBufferUtils__StaticFields *static_fields; // rbx
			//   Matrix4x4 *v18; // rax
			//   float Item; // xmm0_4
			//   int v20; // esi
			//   __int64 v21; // r14
			//   unsigned int v22; // ebp
			//   __int64 v23; // r15
			//   HGShadowConstantBufferUtils__StaticFields *v24; // rbx
			//   __int64 v25; // rax
			//   HGShadowConstantBufferUtils__StaticFields *v26; // rbx
			//   __int64 v27; // rax
			//   HGShadowConstantBufferUtils__StaticFields *v28; // rbx
			//   __int64 v29; // rax
			//   float v30; // xmm0_4
			//   __int64 v31; // rax
			//   HGShadowConstantBufferUtils__StaticFields *v32; // rcx
			//   __m128i v33; // xmm1
			//   HGShadowConstantBufferUtils__StaticFields *v34; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGSharedLightData _unity_self; // [rsp+30h] [rbp-78h] BYREF
			//   __int128 v37; // [rsp+38h] [rbp-70h]
			// 
			//   if ( !byte_18D919E7A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     byte_18D919E7A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1788, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1788, 0LL);
			//     if ( !Patch )
			// LABEL_20:
			//       sub_180B536AC(m_CharacterShadowMatrices, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_697(Patch, (Object *)this, shadowLight, characterShadowCount, 0LL);
			//   }
			//   else
			//   {
			//     _unity_self = shadowLight.hgSharedLightData;
			//     shadows_Injected = UnityEngine::HGSharedLightData::get_shadows_Injected(&_unity_self, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     HG::Rendering::Runtime::HGShadowManager::GetShadowTransform(
			//       TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterProjectionMatrices,
			//       TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterWorldToLightMatrices,
			//       &this.fields.m_CharacterShadowMatrices,
			//       0LL);
			//     v8 = 1065353216;
			//     v9 = 1.0 / (float)TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowmapSize.m_X;
			//     v10 = 1.0 / (float)TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowmapSize.m_Y;
			//     if ( shadows_Injected != LightShadows__Enum_Soft )
			//       v8 = 0;
			//     v11 = 0;
			//     v12 = 0LL;
			//     do
			//     {
			//       v13 = 0;
			//       v14 = 0LL;
			//       do
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//         m_CharacterShadowMatrices = this.fields.m_CharacterShadowMatrices;
			//         if ( !m_CharacterShadowMatrices )
			//           goto LABEL_20;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//         v18 = (Matrix4x4 *)sub_1804440E4(m_CharacterShadowMatrices, v11);
			//         Item = UnityEngine::Matrix4x4::get_Item(v18, v13++, 0LL);
			//         *(&static_fields[18].shadowData._Paddings1.FixedElementField + v12 + v14++) = Item;
			//       }
			//       while ( v13 < 16 );
			//       ++v11;
			//       v12 += 16LL;
			//     }
			//     while ( v11 < 15 );
			//     v20 = 0;
			//     v21 = 0LL;
			//     do
			//     {
			//       v22 = 0;
			//       v23 = 0LL;
			//       do
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//         m_CharacterShadowMatrices = this.fields.m_CharacterShadowBiases;
			//         if ( !m_CharacterShadowMatrices )
			//           goto LABEL_20;
			//         v24 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//         v25 = sub_18003EB40(m_CharacterShadowMatrices, v20);
			//         *(&v24[20].shadowData._ASMIndirectWorldToShadow.m23 + v21 + v23) = sub_182637EE0(v25, v22);
			//         v26 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         m_CharacterShadowMatrices = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowLightDirs;
			//         if ( !m_CharacterShadowMatrices )
			//           goto LABEL_20;
			//         v27 = sub_18003EB40(m_CharacterShadowMatrices, v20);
			//         *(&v26[21].shadowData._CharacterShadowTexelSize.y + v21 + v23) = sub_182637EE0(v27, v22);
			//         v28 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//         m_CharacterShadowMatrices = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowAtlasParams;
			//         if ( !m_CharacterShadowMatrices )
			//           goto LABEL_20;
			//         v29 = sub_18003EB40(m_CharacterShadowMatrices, v20);
			//         v30 = sub_182637EE0(v29, v22);
			//         v31 = v21 + v23;
			//         ++v22;
			//         ++v23;
			//         *((float *)&v28[21]._CSMSectionOffset + v31) = v30;
			//       }
			//       while ( (int)v22 < 4 );
			//       ++v20;
			//       v21 += 4LL;
			//     }
			//     while ( v20 < 15 );
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     *(_QWORD *)&v37 = __PAIR64__(
			//                         v8,
			//                         COERCE_UNSIGNED_INT(UnityEngine::HGSharedLightData::get_shadowStrength_Injected(&_unity_self, 0LL)));
			//     v32 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//     *((_QWORD *)&v37 + 1) = COERCE_UNSIGNED_INT((float)characterShadowCount);
			//     *(_OWORD *)&v32[22].shadowData._ASMIndirectWorldToShadow.m20 = v37;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     *(_QWORD *)&v37 = __PAIR64__(LODWORD(v10), LODWORD(v9));
			//     v33 = _mm_cvtsi32_si128(TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowmapSize.m_Y);
			//     v34 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//     *((float *)&v37 + 2) = (float)TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_CharacterShadowmapSize.m_X;
			//     HIDWORD(v37) = _mm_cvtepi32_ps(v33).m128_u32[0];
			//     *(_OWORD *)&v34[22].shadowData._ASMWorldToShadowBaseMatrix.m23 = v37;
			//   }
			// }
			// 
		}

		private void CharacterShadowCleanup()
		{
			// // Void CharacterShadowCleanup()
			// void HG::Rendering::Runtime::HGShadowManager::CharacterShadowCleanup(HGShadowManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(523, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(523, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			// }
			// 
		}

		private static void GetShadowTransform(Matrix4x4[] projs, Matrix4x4[] views, ref Matrix4x4[] shadows)
		{
			// // Void GetShadowTransform(Matrix4x4[], Matrix4x4[], Matrix4x4[] ByRef)
			// void HG::Rendering::Runtime::HGShadowManager::GetShadowTransform(
			//         Matrix4x4__Array *projs,
			//         Matrix4x4__Array *views,
			//         Matrix4x4__Array **shadows,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   int32_t v9; // ebx
			//   __m128 v10; // xmm6
			//   __int128 v11; // xmm7
			//   __int128 v12; // xmm8
			//   __int128 v13; // xmm9
			//   Matrix4x4 *v14; // rax
			//   __int128 v15; // xmm6
			//   __int128 v16; // xmm7
			//   __int128 v17; // xmm8
			//   __int128 v18; // xmm9
			//   _OWORD *v19; // rax
			//   Matrix4x4__Array *v20; // r15
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   Matrix4x4 *v24; // rax
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Matrix4x4 v29; // [rsp+38h] [rbp-D0h] BYREF
			//   Matrix4x4 v30; // [rsp+78h] [rbp-90h]
			//   Matrix4x4 v31; // [rsp+B8h] [rbp-50h] BYREF
			//   Matrix4x4 v32; // [rsp+F8h] [rbp-10h]
			//   Matrix4x4 v33[2]; // [rsp+138h] [rbp+30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1789, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1789, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_696(Patch, (Object *)projs, (Object *)views, shadows, 0LL);
			//       return;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v8, v7);
			//   }
			//   v9 = 0;
			//   if ( !projs )
			//     goto LABEL_11;
			//   while ( v9 < projs.max_length.size && v9 < 15 )
			//   {
			//     sub_18005A9F0(projs, &v31, v9);
			//     v10 = *(__m128 *)&v31.m00;
			//     v11 = *(_OWORD *)&v31.m01;
			//     v12 = *(_OWORD *)&v31.m02;
			//     v13 = *(_OWORD *)&v31.m03;
			//     v30 = v31;
			//     if ( !views )
			//       goto LABEL_11;
			//     sub_18005A9F0(views, &v29, v9);
			//     if ( UnityEngine::SystemInfo::UsesReversedZBuffer(0LL) )
			//     {
			//       v30.m21 = -v30.m21;
			//       v11 = *(_OWORD *)&v30.m01;
			//       v30.m23 = -v30.m23;
			//       v13 = *(_OWORD *)&v30.m03;
			//       v30.m20 = -_mm_shuffle_ps(v10, v10, 170).m128_f32[0];
			//       v10 = *(__m128 *)&v30.m00;
			//       v30.m22 = -v30.m22;
			//       v12 = *(_OWORD *)&v30.m02;
			//     }
			//     v31 = v29;
			//     *(__m128 *)&v29.m00 = v10;
			//     *(_OWORD *)&v29.m01 = v11;
			//     *(_OWORD *)&v29.m02 = v12;
			//     *(_OWORD *)&v29.m03 = v13;
			//     v14 = UnityEngine::Matrix4x4::op_Multiply(v33, &v29, &v31, 0LL);
			//     v15 = *(_OWORD *)&v14.m00;
			//     v16 = *(_OWORD *)&v14.m01;
			//     v17 = *(_OWORD *)&v14.m02;
			//     v18 = *(_OWORD *)&v14.m03;
			//     v19 = (_OWORD *)sub_182805160(v33);
			//     v20 = *shadows;
			//     *(_OWORD *)&v29.m00 = v15;
			//     *(_OWORD *)&v29.m01 = v16;
			//     v21 = v19[1];
			//     *(_OWORD *)&v32.m00 = *v19;
			//     v22 = v19[2];
			//     v32.m00 = 0.5;
			//     *(_OWORD *)&v32.m01 = v21;
			//     v23 = v19[3];
			//     v32.m11 = 0.5;
			//     *(_OWORD *)&v32.m02 = v22;
			//     v32.m33 = *((float *)&v23 + 3);
			//     v32.m22 = 0.5;
			//     v32.m03 = 0.5;
			//     *(_QWORD *)&v32.m13 = 0x3F0000003F000000LL;
			//     v31 = v32;
			//     *(_OWORD *)&v29.m02 = v17;
			//     *(_OWORD *)&v29.m03 = v18;
			//     v24 = UnityEngine::Matrix4x4::op_Multiply(v33, &v31, &v29, 0LL);
			//     if ( !v20 )
			//       goto LABEL_11;
			//     v25 = *(_OWORD *)&v24.m01;
			//     *(_OWORD *)&v29.m00 = *(_OWORD *)&v24.m00;
			//     v26 = *(_OWORD *)&v24.m02;
			//     *(_OWORD *)&v29.m01 = v25;
			//     v27 = *(_OWORD *)&v24.m03;
			//     *(_OWORD *)&v29.m02 = v26;
			//     *(_OWORD *)&v29.m03 = v27;
			//     sub_180077420(v20, v9++, &v29);
			//   }
			// }
			// 
		}

		public static void InitShadowManager(HGRenderPipelineRuntimeResources renderPipelineResources)
		{
		}

		public void CalculateFrameParameters(ref ScriptableCullingParameters cullingParameters, HGSettingParameters settingParameters, HGCamera hgCamera)
		{
			// // Void CalculateFrameParameters(ScriptableCullingParameters ByRef, HGSettingParameters, HGCamera)
			// void HG::Rendering::Runtime::HGShadowManager::CalculateFrameParameters(
			//         HGShadowManager *this,
			//         ScriptableCullingParameters *cullingParameters,
			//         HGSettingParameters *settingParameters,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
			//   _DWORD *wrapperArray; // rdx
			//   BitArray128 bitDatas; // xmm6
			//   __int64 v12; // xmm0_8
			//   bool v13; // al
			//   SettingParameter_1_System_Boolean_ *characterShadowEnabled_k__BackingField; // rsi
			//   struct MethodInfo *v15; // rbp
			//   Il2CppClass *klass; // rax
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
			//   Object *m_hgCharacterVolume; // rdi
			//   int32_t v19; // eax
			//   struct HGCharacterQualitySettings__Class *v20; // rcx
			//   int32_t v21; // edi
			//   bool v22; // al
			//   bool v23; // al
			//   float m_csmMaxDistance; // xmm6_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v26; // rax
			//   __int64 v27; // rax
			//   ILFixDynamicMethodWrapper_2 *v28; // rax
			//   FrameSettings P0; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8EDD01 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D8EDD01 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cullingParameters);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_46;
			//   if ( (int)wrapperArray[6] > 717 )
			//   {
			//     if ( !v9._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v9, wrapperArray);
			//       v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v9.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_46;
			//     if ( wrapperArray[6] <= 0x2CDu )
			//       goto LABEL_68;
			//     if ( *((_QWORD *)wrapperArray + 721) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(717, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_273(
			//           Patch,
			//           (Object *)this,
			//           cullingParameters,
			//           (Object *)settingParameters,
			//           (Object *)hgCamera,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_46;
			//     }
			//   }
			//   if ( !hgCamera )
			//     goto LABEL_46;
			//   bitDatas = hgCamera.fields._frameSettings_k__BackingField.bitDatas;
			//   v12 = *(_QWORD *)&hgCamera.fields._frameSettings_k__BackingField.materialQuality;
			//   P0.bitDatas = bitDatas;
			//   *(_QWORD *)&P0.materialQuality = v12;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !v9._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v9, wrapperArray);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_46;
			//   if ( (int)wrapperArray[6] <= 679 )
			//     goto LABEL_16;
			//   if ( !v9._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v9, wrapperArray);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_46;
			//   if ( wrapperArray[6] <= 0x2A7u )
			//     goto LABEL_68;
			//   if ( *((_QWORD *)wrapperArray + 683) )
			//   {
			//     v26 = IFix::WrappersManagerImpl::GetPatch(679, 0LL);
			//     if ( !v26 )
			//       goto LABEL_46;
			//     v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_256(v26, &P0, FrameSettingsField__Enum_ShadowMaps, 0LL);
			//   }
			//   else
			//   {
			// LABEL_16:
			//     v13 = (bitDatas.data1 & 0x100000) != 0;
			//   }
			//   this.fields.enableShadowmap = v13;
			//   if ( !settingParameters )
			//     goto LABEL_46;
			//   characterShadowEnabled_k__BackingField = settingParameters.fields._characterShadowEnabled_k__BackingField;
			//   v15 = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit;
			//   if ( !characterShadowEnabled_k__BackingField )
			//     goto LABEL_46;
			//   klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass;
			//   if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit.klass);
			//   if ( !*((_QWORD *)klass.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v27 = sub_18010B520(v15.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v27 + 192) + 48LL))();
			//   }
			//   v9 = (struct ILFixDynamicMethodWrapper_2__Class *)v15.klass;
			//   if ( ((__int64)v9.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v9);
			//   if ( !characterShadowEnabled_k__BackingField.fields._paramValue_k__BackingField )
			//     goto LABEL_69;
			//   m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//   if ( !m_volumeComponentsData )
			//     goto LABEL_46;
			//   m_hgCharacterVolume = (Object *)m_volumeComponentsData.fields.m_hgCharacterVolume;
			//   if ( !m_hgCharacterVolume )
			//     goto LABEL_46;
			//   if ( !byte_18D8ED9CF )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings);
			//     byte_18D8ED9CF = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_46;
			//   if ( (int)wrapperArray[6] <= 719 )
			//     goto LABEL_36;
			//   if ( !v9._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v9, wrapperArray);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v9 = (struct ILFixDynamicMethodWrapper_2__Class *)v9.static_fields.wrapperArray;
			//   if ( !v9 )
			// LABEL_46:
			//     sub_180B536AC(v9, wrapperArray);
			//   if ( LODWORD(v9._0.namespaze) <= 0x2CF )
			// LABEL_68:
			//     sub_180070270(v9, wrapperArray);
			//   if ( v9[15]._0.properties )
			//   {
			//     v28 = IFix::WrappersManagerImpl::GetPatch(719, 0LL);
			//     if ( v28 )
			//     {
			//       v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v28, m_hgCharacterVolume, 0LL);
			//       goto LABEL_40;
			//     }
			//     goto LABEL_46;
			//   }
			// LABEL_36:
			//   wrapperArray = m_hgCharacterVolume[27].klass;
			//   if ( !wrapperArray )
			//     goto LABEL_46;
			//   v19 = sub_18003ED00(10LL);
			//   v20 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
			//   v21 = v19;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings, wrapperArray);
			//     v20 = TypeInfo::HG::Rendering::Runtime::HGCharacterQualitySettings;
			//   }
			//   v22 = v20.static_fields.characterShadowTierLevel >= v21;
			// LABEL_40:
			//   if ( v22 )
			//   {
			//     v23 = 1;
			//     goto LABEL_42;
			//   }
			// LABEL_69:
			//   v23 = 0;
			// LABEL_42:
			//   this.fields.enableCharacterShadowmap = v23;
			//   if ( this.fields.enableShadowmap )
			//   {
			//     m_csmMaxDistance = this.fields.m_csmMaxDistance;
			//     if ( !TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters, wrapperArray);
			//     cullingParameters.m_CameraProperties.cameraWorldToClip.m11 = m_csmMaxDistance;
			//     LODWORD(cullingParameters.m_CameraProperties.cameraWorldToClip.m31) |= 0x40u;
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters, wrapperArray);
			//     cullingParameters.m_CameraProperties.cameraWorldToClip.m11 = 0.0;
			//     LODWORD(cullingParameters.m_CameraProperties.cameraWorldToClip.m31) &= ~0x40u;
			//   }
			// }
			// 
		}

		internal void FrameSetup(ref ShadowMapPassConstructor.PassInput input, out bool shouldRenderCSMShadowMap, HGCamera camera)
		{
			// // Void FrameSetup(ShadowMapPassConstructor+PassInput ByRef, Boolean ByRef, HGCamera)
			// void HG::Rendering::Runtime::HGShadowManager::FrameSetup(
			//         HGShadowManager *this,
			//         ShadowMapPassConstructor_PassInput *input,
			//         bool *shouldRenderCSMShadowMap,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   HGSettingParameters *settingParams; // rdi
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int64 v11; // rdx
			//   Single__Array *v12; // rcx
			//   __m128 v13; // xmm13
			//   __m128i v14; // xmm12
			//   __m128i v15; // xmm6
			//   __m128 v16; // xmm8
			//   __m128 v17; // xmm9
			//   int v18; // xmm11_4
			//   float overrideCsmMaxDistanceValue; // xmm0_4
			//   AttributeCollection *instance; // rax
			//   HGEnvironmentPhase *v21; // rax
			//   float heightFogCullingFarClipPlane; // xmm0_4
			//   float m_csmMaxDistance; // xmm6_4
			//   Single__Array *m_csmShadowSplits; // r14
			//   float v25; // xmm6_4
			//   float v26; // xmm0_4
			//   Single__Array *v27; // r14
			//   float v28; // xmm0_4
			//   Single__Array *v29; // r14
			//   float v30; // xmm0_4
			//   Single__Array *v31; // r14
			//   float v32; // xmm0_4
			//   Single__Array *m_csmShadowSplitPercentage; // r14
			//   float v34; // xmm0_4
			//   Single__Array *v35; // r14
			//   float v36; // xmm0_4
			//   Single__Array *v37; // r14
			//   float v38; // xmm0_4
			//   Single__Array *v39; // r14
			//   float v40; // xmm0_4
			//   Int32__Array *m_csmCachedFrames; // r14
			//   Int32Enum__Enum v42; // eax
			//   Int32__Array *v43; // r14
			//   Int32Enum__Enum v44; // eax
			//   Int32__Array *v45; // r14
			//   Int32Enum__Enum v46; // eax
			//   Int32__Array *v47; // r14
			//   Int32Enum__Enum v48; // eax
			//   Single__Array *m_csmScreenSizeMinSquareds; // r14
			//   float v50; // xmm7_4
			//   float v51; // xmm0_4
			//   Single__Array *v52; // r14
			//   float v53; // xmm7_4
			//   float v54; // xmm0_4
			//   Single__Array *v55; // r14
			//   float v56; // xmm7_4
			//   float v57; // xmm0_4
			//   Single__Array *v58; // r14
			//   float v59; // xmm7_4
			//   float v60; // xmm0_4
			//   Boolean__Array *m_csmEnableOcclusionCulling; // r14
			//   bool v62; // zf
			//   BOOL enableShadowCulling; // eax
			//   Boolean__Array *v64; // r14
			//   BOOL v65; // eax
			//   Boolean__Array *v66; // r14
			//   BOOL v67; // eax
			//   Boolean__Array *v68; // r14
			//   BOOL v69; // eax
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v70; // xmm0
			//   Void *v71; // rax
			//   __int128 v72; // xmm1
			//   __int128 v73; // xmm0
			//   __int128 v74; // xmm1
			//   __int128 v75; // xmm0
			//   __int128 v76; // xmm1
			//   __int128 v77; // xmm0
			//   __int128 v78; // xmm1
			//   __int128 v79; // xmm0
			//   int32_t directionalLightIndex; // r9d
			//   bool v81; // al
			//   Int32Enum__Enum v82; // eax
			//   float v83; // xmm0_4
			//   String *v84; // rax
			//   String *v85; // rax
			//   int32_t m_csmShadowMapTileSize; // eax
			//   int32_t v87; // eax
			//   bool v88; // al
			//   Object_1 *blackTexture; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v90; // rdx
			//   PassConstructorID__Enum__Array *v91; // r8
			//   HGCamera *v92; // r9
			//   float w; // xmm7_4
			//   float v94; // xmm8_4
			//   unsigned int i; // edi
			//   __m128i v96; // xmm1
			//   HGShadowConstantBufferUtils__StaticFields *static_fields; // rcx
			//   HGShadowConstantBufferUtils__StaticFields *v98; // rcx
			//   float m_simulatedShadowAttenuationInVolume; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *P3; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v102; // [rsp+30h] [rbp-D8h]
			//   CullingResults v103[6]; // [rsp+38h] [rbp-D0h] BYREF
			//   __m128 v104; // [rsp+98h] [rbp-70h] BYREF
			//   __int64 v105; // [rsp+A8h] [rbp-60h]
			//   __int128 v106; // [rsp+B8h] [rbp-50h]
			//   __int128 v107; // [rsp+C8h] [rbp-40h]
			//   __int128 v108; // [rsp+D8h] [rbp-30h]
			//   __int128 v109; // [rsp+E8h] [rbp-20h]
			//   __int128 v110; // [rsp+F8h] [rbp-10h]
			//   __int128 v111; // [rsp+108h] [rbp+0h]
			//   __int128 v112; // [rsp+118h] [rbp+10h]
			//   __int128 v113; // [rsp+128h] [rbp+20h]
			//   __int128 v114; // [rsp+138h] [rbp+30h]
			//   int v115; // [rsp+148h] [rbp+40h]
			// 
			//   if ( !byte_18D919E7B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&off_18D5EFA98);
			//     byte_18D919E7B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1801, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1801, 0LL);
			//     if ( !Patch )
			//       goto LABEL_116;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_702(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       shouldRenderCSMShadowMap,
			//       (Object *)camera,
			//       0LL);
			//     return;
			//   }
			//   settingParams = input.settingParams;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//   InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
			//   if ( !InterpolatedPhase )
			//     goto LABEL_116;
			//   v13 = *(__m128 *)&InterpolatedPhase.fields.shadowConfig.csmDepthBias;
			//   v14 = *(__m128i *)&InterpolatedPhase.fields.shadowConfig.csmIntensity;
			//   v15 = *(__m128i *)&InterpolatedPhase.fields.shadowConfig.contactShadowSurfaceThickness;
			//   v16 = *(__m128 *)&InterpolatedPhase.fields.shadowConfig.overrideCsmFarDistance;
			//   v17 = *(__m128 *)&InterpolatedPhase.fields.shadowConfig.overrideCsmSpherePosition.z;
			//   v18 = 1065353216;
			//   v103[3] = *(CullingResults *)&InterpolatedPhase.fields.shadowConfig.csmShadowSoftness;
			//   v105 = *(_QWORD *)&InterpolatedPhase.fields.shadowConfig.csmSimulatedAttenuation;
			//   v103[1] = (CullingResults)v13;
			//   v103[2] = (CullingResults)v14;
			//   v103[4] = (CullingResults)v15;
			//   v103[5] = (CullingResults)v16;
			//   v104 = v17;
			//   this.fields.m_enableCSMInVolume = !System::Single::Equals((Single *)&v104.m128_u32[3], 1.0, 0LL);
			//   LODWORD(this.fields.m_simulatedShadowBlendValue) = _mm_shuffle_ps(v17, v17, 255).m128_u32[0];
			//   LODWORD(this.fields.m_simulatedShadowAttenuationInVolume) = v105;
			//   v12 = (Single__Array *)((unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128((__m128i)v16, 4)) != 0);
			//   this.fields.m_csmRenderMode = (int)v12;
			//   if ( !settingParams )
			//     goto LABEL_116;
			//   this.fields.m_csmNearPlaneOffset = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                         settingParams.fields._csmNearPlaneOffset_k__BackingField,
			//                                         MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   this.fields.m_csmMaxDistance = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                     settingParams.fields._csmMaxDistance_k__BackingField,
			//                                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( (unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(v15, 13)) )
			//     LODWORD(this.fields.m_csmMaxDistance) = v16.m128_i32[0];
			//   if ( !camera )
			//     goto LABEL_116;
			//   if ( camera.fields.overrideCsmShadowDistance )
			//   {
			//     overrideCsmMaxDistanceValue = camera.fields.overrideCsmMaxDistanceValue;
			//     if ( overrideCsmMaxDistanceValue <= 0.0099999998 )
			//       overrideCsmMaxDistanceValue = 0.0099999998;
			//     this.fields.m_csmMaxDistance = overrideCsmMaxDistanceValue;
			//   }
			//   instance = (AttributeCollection *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
			//   if ( !instance )
			//     goto LABEL_116;
			//   if ( System::ComponentModel::AttributeCollection::get_Count(instance, 0LL) == 1 )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     v21 = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
			//     if ( !v21 )
			//       goto LABEL_116;
			//     heightFogCullingFarClipPlane = v21.fields.heightFogConfig.heightFogCullingFarClipPlane;
			//   }
			//   else
			//   {
			//     heightFogCullingFarClipPlane = 3.4028235e38;
			//   }
			//   m_csmMaxDistance = this.fields.m_csmMaxDistance;
			//   if ( heightFogCullingFarClipPlane <= m_csmMaxDistance )
			//     m_csmMaxDistance = heightFogCullingFarClipPlane;
			//   m_csmShadowSplits = this.fields.m_csmShadowSplits;
			//   this.fields.m_csmMaxDistance = m_csmMaxDistance;
			//   v25 = m_csmMaxDistance * 0.80000001;
			//   v26 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmSplit0_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !m_csmShadowSplits )
			// LABEL_116:
			//     sub_180B536AC(v12, v11);
			//   if ( !m_csmShadowSplits.max_length.size )
			//     goto LABEL_114;
			//   m_csmShadowSplits.vector[0] = this.fields.m_csmMaxDistance * v26;
			//   v27 = this.fields.m_csmShadowSplits;
			//   v28 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmSplit1_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !v27 )
			//     goto LABEL_116;
			//   if ( v27.max_length.size <= 1u )
			//     goto LABEL_114;
			//   v27.vector[1] = this.fields.m_csmMaxDistance * v28;
			//   v29 = this.fields.m_csmShadowSplits;
			//   v30 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmSplit2_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !v29 )
			//     goto LABEL_116;
			//   if ( v29.max_length.size <= 2u )
			//     goto LABEL_114;
			//   v29.vector[2] = this.fields.m_csmMaxDistance * v30;
			//   v31 = this.fields.m_csmShadowSplits;
			//   v32 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmSplit3_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !v31 )
			//     goto LABEL_116;
			//   if ( v31.max_length.size <= 3u )
			//     goto LABEL_114;
			//   v31.vector[3] = this.fields.m_csmMaxDistance * v32;
			//   m_csmShadowSplitPercentage = this.fields.m_csmShadowSplitPercentage;
			//   v34 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmSplit0_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !m_csmShadowSplitPercentage )
			//     goto LABEL_116;
			//   if ( !m_csmShadowSplitPercentage.max_length.size )
			//     goto LABEL_114;
			//   m_csmShadowSplitPercentage.vector[0] = v34;
			//   v35 = this.fields.m_csmShadowSplitPercentage;
			//   v36 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmSplit1_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !v35 )
			//     goto LABEL_116;
			//   if ( v35.max_length.size <= 1u )
			//     goto LABEL_114;
			//   v35.vector[1] = v36;
			//   v37 = this.fields.m_csmShadowSplitPercentage;
			//   v38 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmSplit2_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !v37 )
			//     goto LABEL_116;
			//   if ( v37.max_length.size <= 2u )
			//     goto LABEL_114;
			//   v37.vector[2] = v38;
			//   v39 = this.fields.m_csmShadowSplitPercentage;
			//   v40 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmSplit3_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !v39 )
			//     goto LABEL_116;
			//   if ( v39.max_length.size <= 3u )
			//     goto LABEL_114;
			//   v39.vector[3] = v40;
			//   m_csmCachedFrames = this.fields.m_csmCachedFrames;
			//   v42 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//           (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._csmCachedFrame0_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   if ( !m_csmCachedFrames )
			//     goto LABEL_116;
			//   if ( !m_csmCachedFrames.max_length.size )
			//     goto LABEL_114;
			//   m_csmCachedFrames.vector[0] = v42;
			//   v43 = this.fields.m_csmCachedFrames;
			//   v44 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//           (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._csmCachedFrame1_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   if ( !v43 )
			//     goto LABEL_116;
			//   if ( v43.max_length.size <= 1u )
			//     goto LABEL_114;
			//   v43.vector[1] = v44;
			//   v45 = this.fields.m_csmCachedFrames;
			//   v46 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//           (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._csmCachedFrame2_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   if ( !v45 )
			//     goto LABEL_116;
			//   if ( v45.max_length.size <= 2u )
			//     goto LABEL_114;
			//   v45.vector[2] = v46;
			//   v47 = this.fields.m_csmCachedFrames;
			//   v48 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//           (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._csmCachedFrame3_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   if ( !v47 )
			//     goto LABEL_116;
			//   if ( v47.max_length.size <= 3u )
			//     goto LABEL_114;
			//   v47.vector[3] = v48;
			//   m_csmScreenSizeMinSquareds = this.fields.m_csmScreenSizeMinSquareds;
			//   v50 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmScreenSizeMin0_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v51 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmScreenSizeMin0_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !m_csmScreenSizeMinSquareds )
			//     goto LABEL_116;
			//   if ( !m_csmScreenSizeMinSquareds.max_length.size )
			//     goto LABEL_114;
			//   m_csmScreenSizeMinSquareds.vector[0] = v51 * v50;
			//   v52 = this.fields.m_csmScreenSizeMinSquareds;
			//   v53 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmScreenSizeMin1_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v54 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmScreenSizeMin1_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !v52 )
			//     goto LABEL_116;
			//   if ( v52.max_length.size <= 1u )
			//     goto LABEL_114;
			//   v52.vector[1] = v54 * v53;
			//   v55 = this.fields.m_csmScreenSizeMinSquareds;
			//   v56 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmScreenSizeMin2_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v57 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmScreenSizeMin2_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !v55 )
			//     goto LABEL_116;
			//   if ( v55.max_length.size <= 2u )
			//     goto LABEL_114;
			//   v55.vector[2] = v57 * v56;
			//   v58 = this.fields.m_csmScreenSizeMinSquareds;
			//   v59 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmScreenSizeMin3_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   v60 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//           settingParams.fields._csmScreenSizeMin3_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//   if ( !v58 )
			//     goto LABEL_116;
			//   if ( v58.max_length.size <= 3u )
			//     goto LABEL_114;
			//   v58.vector[3] = v60 * v59;
			//   m_csmEnableOcclusionCulling = this.fields.m_csmEnableOcclusionCulling;
			//   v62 = !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            settingParams.fields._csmEnableOcclusionCulling0_k__BackingField,
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   enableShadowCulling = 1;
			//   if ( v62 )
			//     enableShadowCulling = camera.fields.enableShadowCulling;
			//   if ( !m_csmEnableOcclusionCulling )
			//     goto LABEL_116;
			//   if ( !m_csmEnableOcclusionCulling.max_length.size )
			//     goto LABEL_114;
			//   m_csmEnableOcclusionCulling.vector[0] = enableShadowCulling;
			//   v64 = this.fields.m_csmEnableOcclusionCulling;
			//   v62 = !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            settingParams.fields._csmEnableOcclusionCulling1_k__BackingField,
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   v65 = 1;
			//   if ( v62 )
			//     v65 = camera.fields.enableShadowCulling;
			//   if ( !v64 )
			//     goto LABEL_116;
			//   if ( v64.max_length.size <= 1u )
			//     goto LABEL_114;
			//   v64.vector[1] = v65;
			//   v66 = this.fields.m_csmEnableOcclusionCulling;
			//   v62 = !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            settingParams.fields._csmEnableOcclusionCulling2_k__BackingField,
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   v67 = 1;
			//   if ( v62 )
			//     v67 = camera.fields.enableShadowCulling;
			//   if ( !v66 )
			//     goto LABEL_116;
			//   if ( v66.max_length.size <= 2u )
			//     goto LABEL_114;
			//   v66.vector[2] = v67;
			//   v68 = this.fields.m_csmEnableOcclusionCulling;
			//   v62 = !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            settingParams.fields._csmEnableOcclusionCulling3_k__BackingField,
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//   v69 = 1;
			//   if ( v62 )
			//     v69 = camera.fields.enableShadowCulling;
			//   if ( !v68 )
			//     goto LABEL_116;
			//   if ( v68.max_length.size <= 3u )
			//     goto LABEL_114;
			//   v68.vector[3] = v69;
			//   this.fields.m_csmOcclusionDepthSize = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                            (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._csmOcclusionDepthSize_k__BackingField,
			//                                            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   this.fields.m_stopRenderCharacterCascade = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                                 (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._csmStopRenderCharacterCascade_k__BackingField,
			//                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   v70 = *UnityEngine::HyperGryph::LightCullResult::get_visibleLights(
			//            (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)v103,
			//            &input.lightCullResult,
			//            0LL);
			//   LODWORD(this.fields.m_shadowIntensity) = v14.m128i_i32[0];
			//   if ( input.directionalLightIndex == -1 )
			//   {
			//     this.fields.m_hasDirectionLight = 0;
			//   }
			//   else
			//   {
			//     this.fields.m_hasDirectionLight = 1;
			//     v71 = &v70.m_Buffer[148 * input.directionalLightIndex];
			//     v72 = *(_OWORD *)&v71[16];
			//     v106 = *(_OWORD *)v71;
			//     v73 = *(_OWORD *)&v71[32];
			//     v107 = v72;
			//     v74 = *(_OWORD *)&v71[48];
			//     v108 = v73;
			//     v75 = *(_OWORD *)&v71[64];
			//     v109 = v74;
			//     v76 = *(_OWORD *)&v71[80];
			//     v110 = v75;
			//     v77 = *(_OWORD *)&v71[96];
			//     v111 = v76;
			//     v78 = *(_OWORD *)&v71[128];
			//     v112 = v77;
			//     v79 = *(_OWORD *)&v71[112];
			//     LODWORD(v71) = *(_DWORD *)&v71[144];
			//     v113 = v79;
			//     v114 = v78;
			//     v115 = (int)v71;
			//     this.fields.m_directionalLight = (HGSharedLightData)*((_QWORD *)&v78 + 1);
			//   }
			//   directionalLightIndex = input.directionalLightIndex;
			//   v103[0] = input.cullingResults;
			//   v81 = HG::Rendering::Runtime::HGShadowManager::ShouldRenderCSMShadowMap(
			//           this,
			//           camera,
			//           v103,
			//           directionalLightIndex,
			//           settingParams,
			//           0LL);
			//   *shouldRenderCSMShadowMap = v81;
			//   if ( v81 )
			//   {
			//     this.fields.m_csmCascadeCount = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                        (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._csmSplitCount_k__BackingField,
			//                                        MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     LODWORD(this.fields.m_csmDepthBias) = _mm_shuffle_ps(v13, v13, 170).m128_u32[0];
			//     LODWORD(this.fields.m_csmNormalBias) = _mm_shuffle_ps(v13, v13, 255).m128_u32[0];
			//     this.fields.m_csmHardwareDepthBias = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                             settingParams.fields._csmHardwareBias_k__BackingField,
			//                                             MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     this.fields.m_csmHardwareNormalBias = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                              settingParams.fields._csmHardwareNormalBias_k__BackingField,
			//                                              MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     this.fields.m_csmShadowSampleMode = 4;
			//     v82 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//             (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._csmShadowMapTileResolution_k__BackingField,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     v62 = this.fields.m_csmRenderMode == 1;
			//     this.fields.m_csmShadowMapTileSize = v82;
			//     if ( !v62 )
			//       goto LABEL_83;
			//     v12 = this.fields.m_csmShadowSplits;
			//     LODWORD(v103[0].ptr) = _mm_shuffle_ps(v16, v16, 170).m128_u32[0];
			//     LODWORD(v103[0].m_AllocationInfo) = v17.m128_i32[0];
			//     HIDWORD(v103[0].ptr) = _mm_shuffle_ps(v16, v16, 255).m128_u32[0];
			//     HIDWORD(v103[0].m_AllocationInfo) = _mm_shuffle_ps(v17, v17, 85).m128_u32[0];
			//     this.fields.m_csmCascadeCount = 2;
			//     this.fields.m_enableCSMInVolume = 1;
			//     *(_QWORD *)&this.fields.m_simulatedShadowAttenuationInVolume = 0LL;
			//     this.fields.m_csmManualOverrideSphere = (Vector4)v103[0];
			//     v83 = this.fields.m_csmManualOverrideSphere.w + this.fields.m_csmManualOverrideSphere.w;
			//     if ( !v12 )
			//       goto LABEL_116;
			//     if ( v12.max_length.size > 1u )
			//     {
			//       v12.vector[1] = v83;
			//       if ( v12.max_length.size )
			//       {
			//         v12.vector[0] = v83;
			//         v12 = this.fields.m_csmShadowSplitPercentage;
			//         if ( !v12 )
			//           goto LABEL_116;
			//         if ( v12.max_length.size > 1u )
			//         {
			//           v11 = 1065353216LL;
			//           v12.vector[1] = 1.0;
			//           if ( v12.max_length.size )
			//           {
			//             v12.vector[0] = 1.0;
			//             v12 = this.fields.m_csmScreenSizeMinSquareds;
			//             if ( !v12 )
			//               goto LABEL_116;
			//             if ( v12.max_length.size >= 2u )
			//             {
			//               v25 = 990.0;
			//               v12.vector[1] = v12.vector[0];
			//               this.fields.m_stopRenderCharacterCascade = 1;
			//               this.fields.m_csmMaxDistance = 1000.0;
			// LABEL_83:
			//               if ( this.fields.m_csmCascadeCount != 1 )
			//               {
			//                 if ( this.fields.m_csmCascadeCount == 2 )
			//                 {
			//                   m_csmShadowMapTileSize = 2 * this.fields.m_csmShadowMapTileSize;
			//                   goto LABEL_88;
			//                 }
			//                 if ( (unsigned int)(this.fields.m_csmCascadeCount - 3) < 2 )
			//                 {
			//                   LODWORD(v103[0].ptr) = 2 * this.fields.m_csmShadowMapTileSize;
			//                   v87 = 2 * this.fields.m_csmShadowMapTileSize;
			//                   goto LABEL_89;
			//                 }
			//                 v84 = System::Int32::ToString((Int32 *)&this.fields.m_csmCascadeCount, 0LL);
			//                 v85 = System::String::Concat((String *)"Unsupported CSM cascade count: ", v84, 0LL);
			//                 HG::Rendering::HGRPLogger::LogError(v85, 0LL);
			//               }
			//               m_csmShadowMapTileSize = this.fields.m_csmShadowMapTileSize;
			// LABEL_88:
			//               LODWORD(v103[0].ptr) = m_csmShadowMapTileSize;
			//               v87 = this.fields.m_csmShadowMapTileSize;
			// LABEL_89:
			//               HIDWORD(v103[0].ptr) = v87;
			//               this.fields.m_csmShadowMapSize = (Vector2Int)v103[0].ptr;
			//               v88 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                       settingParams.fields._csmUseShadowmapCache_k__BackingField,
			//                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
			//                  && this.fields.m_csmRenderMode == 0;
			//               this.fields.m_useShadowMapCache = v88;
			//               goto LABEL_95;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_114:
			//     sub_180070270(v12, v11);
			//   }
			//   this.fields.m_csmCascadeCount = 0;
			// LABEL_95:
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   blackTexture = (Object_1 *)_mm_srli_si128(v14, 8).m128i_u64[0];
			//   if ( UnityEngine::Object::op_Equality(blackTexture, 0LL, 0LL) )
			//     blackTexture = (Object_1 *)UnityEngine::Texture2D::get_blackTexture(0LL);
			//   this.fields.m_csmShadowRamp = (Texture2D *)blackTexture;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_csmShadowRamp, v90, v91, v92, P3, v102);
			//   w = this.fields.m_csmMaxDistance;
			//   if ( v25 >= 0.1 )
			//   {
			//     if ( v25 > w )
			//       v25 = this.fields.m_csmMaxDistance;
			//   }
			//   else
			//   {
			//     v25 = 0.1;
			//   }
			//   if ( this.fields.m_csmRenderMode == 1 )
			//   {
			//     w = this.fields.m_csmManualOverrideSphere.w;
			//     v25 = w * 0.89999998;
			//   }
			//   v94 = (float)(w * w) - (float)(v25 * v25);
			//   if ( v94 <= 0.0099999998 )
			//     v94 = 0.0099999998;
			//   for ( i = 0;
			//         (signed int)i < this.fields.m_csmCascadeCount;
			//         sub_182718290(
			//           &TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[1].shadowData._CharacterShadowTexelSize.y,
			//           i++) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     v12 = this.fields.m_csmShadowSplits;
			//     if ( !v12 )
			//       goto LABEL_116;
			//     if ( i >= v12.max_length.size )
			//       goto LABEL_114;
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//   v96 = _mm_cvtsi32_si128(this.fields.m_stopRenderCharacterCascade);
			//   *(float *)&v103[0].ptr = this.fields.m_shadowIntensity;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//   *(float *)&v103[0].m_AllocationInfo = 1.0 / v94;
			//   HIDWORD(v103[0].ptr) = _mm_cvtepi32_ps(v96).m128_u32[0];
			//   *((float *)&v103[0].m_AllocationInfo + 1) = w * w;
			//   *(CullingResults *)&static_fields[1].shadowData._CharacterShadowParams.y = v103[0];
			//   v98 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//   if ( *shouldRenderCSMShadowMap )
			//   {
			//     if ( this.fields.m_csmRenderMode )
			//       v18 = 0x40000000;
			//   }
			//   else
			//   {
			//     v18 = 0;
			//   }
			//   m_simulatedShadowAttenuationInVolume = this.fields.m_simulatedShadowAttenuationInVolume;
			//   v103[0].ptr = (void *)__PAIR64__((float)this.fields.m_csmCascadeCount, v18);
			//   HIDWORD(v103[0].m_AllocationInfo) = LODWORD(this.fields.m_simulatedShadowBlendValue);
			//   *(float *)&v103[0].m_AllocationInfo = m_simulatedShadowAttenuationInVolume;
			//   *(CullingResults *)&v98[1].shadowData._ASMWorldToShadowBaseMatrix.m00 = v103[0];
			//   UnityEngine::HyperGryph::HGRendererSystem::set_CSMStopRenderCharacterCascadeLevel(
			//     this.fields.m_stopRenderCharacterCascade,
			//     0LL);
			// }
			// 
		}

		internal void ConfigureDirectionalShadowMapTextures(HGSettingParameters settingParams, HGCamera hgCamera, bool shouldRenderCSMShadowMap)
		{
			// // Void ConfigureDirectionalShadowMapTextures(HGSettingParameters, HGCamera, Boolean)
			// void HG::Rendering::Runtime::HGShadowManager::ConfigureDirectionalShadowMapTextures(
			//         HGShadowManager *this,
			//         HGSettingParameters *settingParams,
			//         HGCamera *hgCamera,
			//         bool shouldRenderCSMShadowMap,
			//         MethodInfo *method)
			// {
			//   RenderTexture *m_RT; // rdx
			//   Boolean__Array *m_updateCSMShadowMap; // rcx
			//   Int32Enum__Enum v11; // ebx
			//   bool v12; // zf
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   Color clearColor; // xmm1
			//   HGRenderPathBase_HGRenderPathResources *v16; // rdx
			//   PassConstructorID__Enum__Array *v17; // r8
			//   HGCamera *v18; // r9
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   Color v21; // xmm1
			//   HGRenderPathBase_HGRenderPathResources *v22; // rdx
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   int32_t width; // ebx
			//   RTHandle *m_csmShadowMapAtlas; // rax
			//   int32_t height; // ebx
			//   int32_t v28; // ebx
			//   int32_t renderedFrameCount; // eax
			//   Int32__Array *m_csmCachedFrames; // r8
			//   Boolean__Array *v31; // r8
			//   __int64 v32; // rax
			//   int32_t v33; // r15d
			//   int32_t v34; // r14d
			//   unsigned int depthBufferBits; // esi
			//   unsigned int v36; // edi
			//   unsigned int wrapMode; // ebx
			//   HGRenderPathBase_HGRenderPathResources *v38; // rdx
			//   PassConstructorID__Enum__Array *v39; // r8
			//   HGCamera *v40; // r9
			//   HGRenderPathBase_HGRenderPathResources *v41; // rdx
			//   PassConstructorID__Enum__Array *v42; // r8
			//   HGCamera *v43; // r9
			//   int v44; // r9d
			//   __int64 v45; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *colorFormat; // [rsp+28h] [rbp-B1h]
			//   MethodInfo *colorFormata; // [rsp+28h] [rbp-B1h]
			//   MethodInfo *colorFormatb; // [rsp+28h] [rbp-B1h]
			//   MethodInfo *filterMode; // [rsp+30h] [rbp-A9h]
			//   MethodInfo *filterModea; // [rsp+30h] [rbp-A9h]
			//   MethodInfo *filterModeb; // [rsp+30h] [rbp-A9h]
			//   TextureDesc v53; // [rsp+A8h] [rbp-31h] BYREF
			// 
			//   if ( !byte_18D919E7C )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit);
			//     sub_18003C530(&off_18D5EFAD0);
			//     byte_18D919E7C = 1;
			//   }
			//   sub_1802F01E0(&v53, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1829, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1829, 0LL);
			//     if ( !Patch )
			//       goto LABEL_31;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_102(
			//       (ILFixDynamicMethodWrapper_13 *)Patch,
			//       (Object *)this,
			//       (Object *)settingParams,
			//       (Object *)hgCamera,
			//       shouldRenderCSMShadowMap,
			//       0LL);
			//     return;
			//   }
			//   if ( !settingParams )
			//     goto LABEL_31;
			//   v11 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//           (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._shadowDepthBits_k__BackingField,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<UnityEngine::Rendering::DepthBits>::op_Implicit);
			//   if ( !shouldRenderCSMShadowMap )
			//   {
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v53, 1, 1, 0LL);
			//     v12 = !this.fields.m_useShadowMapCache;
			//     v53.depthBufferBits = v11;
			//     v53.clearBuffer = v12;
			//     *(_OWORD *)&this.fields.m_csmShadowMapTextureDesc.width = *(_OWORD *)&v53.width;
			//     v53.filterMode = 1;
			//     v53.wrapMode = 1;
			//     *(_OWORD *)&this.fields.m_csmShadowMapTextureDesc.colorFormat = *(_OWORD *)&v53.colorFormat;
			//     v53.isShadowMap = 1;
			//     v13 = *(_OWORD *)&v53.bindTextureMS;
			//     *(_OWORD *)&this.fields.m_csmShadowMapTextureDesc.enableRandomWrite = *(_OWORD *)&v53.enableRandomWrite;
			//     v14 = *(_OWORD *)&v53.fastMemoryDesc.inFastMemory;
			//     *(_OWORD *)&this.fields.m_csmShadowMapTextureDesc.bindTextureMS = v13;
			//     clearColor = v53.clearColor;
			//     *(_OWORD *)&this.fields.m_csmShadowMapTextureDesc.fastMemoryDesc.inFastMemory = v14;
			//     this.fields.m_csmShadowMapTextureDesc.clearColor = clearColor;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)&this.fields.m_csmShadowMapTextureDesc.name,
			//       v16,
			//       v17,
			//       v18,
			//       colorFormat,
			//       filterMode);
			//     return;
			//   }
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//     &v53,
			//     this.fields.m_csmShadowMapSize.m_X,
			//     this.fields.m_csmShadowMapSize.m_Y,
			//     0LL);
			//   v12 = !this.fields.m_useShadowMapCache;
			//   v53.depthBufferBits = v11;
			//   v53.clearBuffer = v12;
			//   *(_OWORD *)&this.fields.m_csmShadowMapTextureDesc.width = *(_OWORD *)&v53.width;
			//   v53.filterMode = 1;
			//   v53.wrapMode = 1;
			//   *(_OWORD *)&this.fields.m_csmShadowMapTextureDesc.colorFormat = *(_OWORD *)&v53.colorFormat;
			//   v53.isShadowMap = 1;
			//   v19 = *(_OWORD *)&v53.bindTextureMS;
			//   *(_OWORD *)&this.fields.m_csmShadowMapTextureDesc.enableRandomWrite = *(_OWORD *)&v53.enableRandomWrite;
			//   v20 = *(_OWORD *)&v53.fastMemoryDesc.inFastMemory;
			//   *(_OWORD *)&this.fields.m_csmShadowMapTextureDesc.bindTextureMS = v19;
			//   v21 = v53.clearColor;
			//   *(_OWORD *)&this.fields.m_csmShadowMapTextureDesc.fastMemoryDesc.inFastMemory = v20;
			//   this.fields.m_csmShadowMapTextureDesc.clearColor = v21;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_csmShadowMapTextureDesc.name,
			//     v22,
			//     v23,
			//     v24,
			//     colorFormat,
			//     filterMode);
			//   if ( !this.fields.m_csmShadowMapAtlas )
			//     goto LABEL_23;
			//   m_RT = this.fields.m_csmShadowMapAtlas.fields.m_RT;
			//   if ( !m_RT )
			//     goto LABEL_31;
			//   width = this.fields.m_csmShadowMapTextureDesc.width;
			//   if ( width != (unsigned int)sub_18003ED00(5LL) )
			//     goto LABEL_35;
			//   m_csmShadowMapAtlas = this.fields.m_csmShadowMapAtlas;
			//   if ( !m_csmShadowMapAtlas )
			//     goto LABEL_31;
			//   m_RT = m_csmShadowMapAtlas.fields.m_RT;
			//   if ( !m_RT )
			//     goto LABEL_31;
			//   height = this.fields.m_csmShadowMapTextureDesc.height;
			//   if ( height != (unsigned int)sub_18003ED00(7LL) )
			//   {
			// LABEL_35:
			//     if ( this.fields.m_csmShadowMapAtlas )
			//       UnityEngine::Rendering::RTHandle::Release(this.fields.m_csmShadowMapAtlas, 0LL);
			// LABEL_23:
			//     v33 = this.fields.m_csmShadowMapTextureDesc.width;
			//     v34 = this.fields.m_csmShadowMapTextureDesc.height;
			//     depthBufferBits = this.fields.m_csmShadowMapTextureDesc.depthBufferBits;
			//     v36 = this.fields.m_csmShadowMapTextureDesc.filterMode;
			//     wrapMode = this.fields.m_csmShadowMapTextureDesc.wrapMode;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//     this.fields.m_csmShadowMapAtlas = UnityEngine::Rendering::RTHandles::Alloc(
			//                                          v33,
			//                                          v34,
			//                                          1,
			//                                          (DepthBits__Enum)depthBufferBits,
			//                                          GraphicsFormat__Enum_R8G8B8A8_SRGB,
			//                                          (FilterMode__Enum)v36,
			//                                          (TextureWrapMode__Enum)wrapMode,
			//                                          TextureDimension__Enum_Tex2D,
			//                                          0,
			//                                          0,
			//                                          1,
			//                                          1,
			//                                          1,
			//                                          0.0,
			//                                          MSAASamples__Enum_None,
			//                                          0,
			//                                          RenderTextureMemoryless__Enum_None,
			//                                          (String *)"Cached Cascaded Shadowmap",
			//                                          0LL);
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_csmShadowMapAtlas, v38, v39, v40, colorFormatb, filterModeb);
			// LABEL_24:
			//     UnityEngine::HyperGryph::HGRendererSystem::set_CSMStopRenderCharacterCascadeLevel(
			//       this.fields.m_stopRenderCharacterCascade,
			//       0LL);
			//     this.fields.m_cachedRenderedCamera = hgCamera;
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_cachedRenderedCamera, v41, v42, v43, colorFormata, filterModea);
			//     v44 = 0;
			//     while ( 1 )
			//     {
			//       m_updateCSMShadowMap = this.fields.m_updateCSMShadowMap;
			//       if ( !m_updateCSMShadowMap )
			//         break;
			//       if ( (unsigned int)v44 >= m_updateCSMShadowMap.max_length.size )
			// LABEL_29:
			//         sub_180070270(m_updateCSMShadowMap, m_RT);
			//       v45 = v44++;
			//       m_updateCSMShadowMap.vector[v45] = 1;
			//       if ( v44 >= 4 )
			//         return;
			//     }
			// LABEL_31:
			//     sub_180B536AC(m_updateCSMShadowMap, m_RT);
			//   }
			//   if ( this.fields.m_cachedRenderedCamera != hgCamera )
			//     goto LABEL_24;
			//   v28 = 0;
			//   if ( this.fields.m_csmCascadeCount > 0 )
			//   {
			//     while ( 1 )
			//     {
			//       renderedFrameCount = UnityEngine::Time::get_renderedFrameCount(0LL);
			//       m_csmCachedFrames = this.fields.m_csmCachedFrames;
			//       if ( !m_csmCachedFrames )
			//         goto LABEL_31;
			//       if ( (unsigned int)v28 >= m_csmCachedFrames.max_length.size )
			//         goto LABEL_29;
			//       m_updateCSMShadowMap = (Boolean__Array *)v28;
			//       m_RT = (RenderTexture *)(unsigned int)(renderedFrameCount >> 31);
			//       LODWORD(m_RT) = renderedFrameCount % m_csmCachedFrames.vector[v28];
			//       v31 = this.fields.m_updateCSMShadowMap;
			//       if ( !v31 )
			//         goto LABEL_31;
			//       if ( (unsigned int)v28 >= v31.max_length.size )
			//         goto LABEL_29;
			//       v32 = v28++;
			//       v31.vector[v32] = (_DWORD)m_RT == 0;
			//       if ( v28 >= this.fields.m_csmCascadeCount )
			//         return;
			//     }
			//   }
			// }
			// 
		}

		public void Cleanup()
		{
			// // Void Cleanup()
			// void HG::Rendering::Runtime::HGShadowManager::Cleanup(HGShadowManager *this, MethodInfo *method)
			// {
			//   RTHandle *m_csmShadowMapAtlas; // rcx
			//   HGPunctualLightShadowManagerV2 *m_punctualLightShadowManagerV2; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(522, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(522, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     m_csmShadowMapAtlas = this.fields.m_csmShadowMapAtlas;
			//     if ( m_csmShadowMapAtlas )
			//       UnityEngine::Rendering::RTHandle::Release(m_csmShadowMapAtlas, 0LL);
			//     HG::Rendering::Runtime::HGShadowManager::CharacterShadowCleanup(this, 0LL);
			//     m_punctualLightShadowManagerV2 = this.fields.m_punctualLightShadowManagerV2;
			//     if ( m_punctualLightShadowManagerV2 )
			//       HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::Release(m_punctualLightShadowManagerV2, 0LL);
			//   }
			// }
			// 
		}

		internal static ShadowResult ReadShadowResult(in ShadowResult shadowResult, HGRenderGraphBuilder builder)
		{
			// // ShadowResult ReadShadowResult(ShadowResult ByRef, HGRenderGraphBuilder)
			// ShadowResult *HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(
			//         ShadowResult *__return_ptr retstr,
			//         ShadowResult *shadowResult,
			//         HGRenderGraphBuilder *builder,
			//         MethodInfo *method)
			// {
			//   __int128 v7; // xmm6
			//   int32_t v8; // r14d
			//   __int128 v9; // xmm0
			//   __int128 v10; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int128 v14; // xmm1
			//   ShadowResult *v15; // rax
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   HGRenderGraphBuilder v19; // [rsp+38h] [rbp-19h] BYREF
			//   ShadowResult v20; // [rsp+58h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D919E7D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D919E7D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1830, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1830, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     v14 = *(_OWORD *)&builder.m_RenderGraph;
			//     *(_OWORD *)&v19.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//     *(_OWORD *)&v19.m_RenderGraph = v14;
			//     v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_703(&v20, Patch, shadowResult, &v19, 0LL);
			//     v16 = *(_OWORD *)&v15.directionalShadowResult.fallBackResource._type_k__BackingField;
			//     *(_OWORD *)&retstr.directionalShadowActive = *(_OWORD *)&v15.directionalShadowActive;
			//     v17 = *(_OWORD *)&v15.characterShadowResult.fallBackResource.m_Value;
			//     *(_OWORD *)&retstr.directionalShadowResult.fallBackResource._type_k__BackingField = v16;
			//     *(_QWORD *)&v16 = *(_QWORD *)&v15.punctualLightShadowResult.handle._type_k__BackingField;
			//     LODWORD(v15) = v15.punctualLightShadowResult.fallBackResource._type_k__BackingField;
			//     *(_OWORD *)&retstr.characterShadowResult.fallBackResource.m_Value = v17;
			//     *(_QWORD *)&retstr.punctualLightShadowResult.handle._type_k__BackingField = v16;
			//     retstr.punctualLightShadowResult.fallBackResource._type_k__BackingField = (int)v15;
			//   }
			//   else
			//   {
			//     v7 = 0LL;
			//     v8 = 0;
			//     memset(&v20, 0, 56);
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&shadowResult.directionalShadowResult, 0LL) )
			//     {
			//       v20.directionalShadowActive = shadowResult.directionalShadowActive;
			//       v20.directionalShadowResult = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                        (TextureHandle *)&v19,
			//                                        builder,
			//                                        &shadowResult.directionalShadowResult,
			//                                        0LL);
			//       v7 = *(_OWORD *)&v20.directionalShadowActive;
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&shadowResult.characterShadowResult, 0LL) )
			//     {
			//       v20.characterShadowActive = shadowResult.characterShadowActive;
			//       v20.characterShadowResult = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                      (TextureHandle *)&v19,
			//                                      builder,
			//                                      &shadowResult.characterShadowResult,
			//                                      0LL);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&shadowResult.punctualLightShadowResult, 0LL) )
			//     {
			//       v20.punctualLightShadowActive = shadowResult.punctualLightShadowActive;
			//       v20.punctualLightShadowResult = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                          (TextureHandle *)&v19,
			//                                          builder,
			//                                          &shadowResult.punctualLightShadowResult,
			//                                          0LL);
			//       v8 = _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v20.punctualLightShadowResult, 12));
			//     }
			//     v9 = *(_OWORD *)&v20.directionalShadowResult.fallBackResource._type_k__BackingField;
			//     v10 = *(_OWORD *)&v20.characterShadowResult.fallBackResource.m_Value;
			//     *(_OWORD *)&retstr.directionalShadowActive = v7;
			//     *(_OWORD *)&retstr.directionalShadowResult.fallBackResource._type_k__BackingField = v9;
			//     *(_QWORD *)&v9 = *(_QWORD *)&v20.punctualLightShadowResult.handle._type_k__BackingField;
			//     *(_OWORD *)&retstr.characterShadowResult.fallBackResource.m_Value = v10;
			//     *(_QWORD *)&retstr.punctualLightShadowResult.handle._type_k__BackingField = v9;
			//     retstr.punctualLightShadowResult.fallBackResource._type_k__BackingField = v8;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private void CalculateDirectionalShadowParameters(HGCamera hgCamera, CullingResults cullingResults, LightCullResult lightCullResult, int directionalLightIndex, int tileSize, Vector2Int atlasSize, int cascadeCount, float shadowIntensity, RendererList[] unityRendererLists, uint[] shadowRendererLists, uint[] shadowGrassLists, ref HGShadowManager.CascadedShadowRequest shadowRequest, ScriptableRenderContext context)
		{
			// // Void CalculateDirectionalShadowParameters(HGCamera, CullingResults, LightCullResult, Int32, Int32, Vector2Int, Int32, Single, RendererList[], UInt32[], UInt32[], HGShadowManager+CascadedShadowRequest ByRef, ScriptableRenderContext)
			// void HG::Rendering::Runtime::HGShadowManager::CalculateDirectionalShadowParameters(
			//         HGShadowManager *this,
			//         HGCamera *hgCamera,
			//         CullingResults *cullingResults,
			//         LightCullResult *lightCullResult,
			//         int32_t directionalLightIndex,
			//         int32_t tileSize,
			//         Vector2Int atlasSize,
			//         int32_t cascadeCount,
			//         float shadowIntensity,
			//         RendererList__Array *unityRendererLists,
			//         UInt32__Array *shadowRendererLists,
			//         UInt32__Array *shadowGrassLists,
			//         HGShadowManager_CascadedShadowRequest **shadowRequest,
			//         ScriptableRenderContext context,
			//         MethodInfo *method)
			// {
			//   int32_t v15; // r15d
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights; // rax
			//   __int64 m_csmScreenSizeMinSquareds; // rdx
			//   void *Patch; // rcx
			//   int32_t v23; // r12d
			//   Vector4 *AsVector4; // rax
			//   uint32_t m_csmNearPlaneOffset_low; // xmm8_4
			//   Vector4 v26; // xmm0
			//   HGShadowManager_CascadedShadowRequest *v27; // rax
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rbx
			//   Light *light; // rax
			//   bool v30; // al
			//   int32_t v31; // ebx
			//   HGEnvironmentVolumeCameraComponent *v32; // rax
			//   HGEnvironmentPhase *m_interpolatedPhase; // rax
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm2
			//   __int128 v37; // xmm3
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   Camera *camera; // rcx
			//   float m_csmMaxDistance; // xmm2_4
			//   Void *m_Buffer; // rax
			//   int32_t v42; // edi
			//   float v43; // xmm14_4
			//   HGShadowManager_CascadedShadowRequest *v44; // rax
			//   __m128 v45; // xmm6
			//   Matrix4x4__Array *v46; // r12
			//   ShadowSplitData__Array *v47; // rbx
			//   ShadowSplitData *v48; // rbx
			//   Matrix4x4 *v49; // rax
			//   HGShadowManager_CascadedShadowRequest *v50; // rax
			//   __m128 v51; // xmm6
			//   Matrix4x4__Array *deviceProjectionYFlipMatrices; // r12
			//   ShadowSplitData__Array *shadowSplitData; // rbx
			//   __int64 v54; // rbx
			//   Matrix4x4 *v55; // rax
			//   Single__Array *v56; // rbx
			//   float v57; // xmm7_4
			//   __int64 v58; // rax
			//   float v59; // xmm6_4
			//   HGShadowManager_CascadedShadowRequest *v60; // rax
			//   Matrix4x4__Array *v61; // r12
			//   ShadowSplitData *outSplitData; // rbx
			//   Matrix4x4 *outProjFlipYMatrix; // rax
			//   int32_t m_csmOcclusionDepthSize; // r12d
			//   __int64 v65; // rax
			//   HGShadowManager_CascadedShadowRequest *v66; // rbx
			//   ShadowSplitData__Array *v67; // rbx
			//   _DWORD *v68; // rax
			//   Camera *v69; // rbx
			//   uint64_t SceneCullingMaskFromCamera; // rax
			//   int v71; // r10d
			//   int v72; // r11d
			//   int32_t v73; // ebx
			//   int v74; // xmm6_4
			//   void *v75; // rax
			//   Matrix4x4 *v76; // rax
			//   __int128 v77; // xmm1
			//   __int64 (__fastcall *v78)(void *, _QWORD, _QWORD, uint64_t, int32_t, _DWORD, int, LODCrossFadeConfig *, int, int, _DWORD, int32_t, int32_t, _OWORD *, __int64 *, __int128 *, _DWORD, int); // rax
			//   int v79; // eax
			//   __int128 v80; // xmm10
			//   __int128 v81; // xmm11
			//   __int128 v82; // xmm12
			//   __int128 v83; // xmm13
			//   __int128 v84; // xmm6
			//   __int128 v85; // xmm7
			//   __int128 v86; // xmm8
			//   __int128 v87; // xmm9
			//   Matrix4x4 *ShadowTransform; // rax
			//   __int128 v89; // xmm1
			//   __int128 v90; // xmm0
			//   __int128 v91; // xmm1
			//   ShadowSplitData__Array *v92; // rbx
			//   __m128 v93; // xmm2
			//   float v94; // xmm0_4
			//   float v95; // xmm1_4
			//   Vector4__Array *cascadeShadowBiases; // rbx
			//   float m_csmNormalBias; // xmm4_4
			//   unsigned int m_csmShadowSampleMode; // eax
			//   float m_csmDepthBias; // xmm3_4
			//   Vector4 *ShadowBias; // rax
			//   __m128 v101; // xmm6
			//   __m128 v102; // xmm7
			//   __int64 v103; // rax
			//   int v104; // edi
			//   Matrix4x4 *v105; // rax
			//   __int128 v106; // xmm10
			//   __int128 v107; // xmm11
			//   __int128 v108; // xmm12
			//   __int128 v109; // xmm13
			//   HGShadowManager__StaticFields *static_fields; // rdx
			//   CullingResults v111; // xmm6
			//   Camera *v112; // r9
			//   unsigned int v113; // esi
			//   __int64 v114; // r13
			//   HGRenderFlags__Enum__Array *m_cascadeRenderFlags; // rdi
			//   HGRenderFlags__Enum v116; // edi
			//   HGRenderFlags__Enum v117; // ebx
			//   uint32_t RendererList; // eax
			//   uint32_t v119; // eax
			//   __int64 v120; // rax
			//   Matrix4x4 *zero; // rax
			//   __int128 v122; // xmm7
			//   __int128 v123; // xmm8
			//   __int128 v124; // xmm9
			//   __int128 v125; // xmm6
			//   CullingResults v126; // xmm1
			//   CullingResults v127; // xmm1
			//   HGRenderKeyword__Enum methoda; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *v129; // [rsp+60h] [rbp-B8h]
			//   Vector4 v130; // [rsp+98h] [rbp-80h] BYREF
			//   uint32_t viewHandle; // [rsp+A8h] [rbp-70h]
			//   ShaderTagId v132; // [rsp+ACh] [rbp-6Ch] BYREF
			//   CullingResults v133; // [rsp+B8h] [rbp-60h] BYREF
			//   Matrix4x4 v134; // [rsp+C8h] [rbp-50h] BYREF
			//   __int64 v135; // [rsp+108h] [rbp-10h]
			//   __int64 v136; // [rsp+110h] [rbp-8h]
			//   Void *v137; // [rsp+118h] [rbp+0h]
			//   CullingResults v138; // [rsp+120h] [rbp+8h] BYREF
			//   int v139; // [rsp+130h] [rbp+18h]
			//   int32_t cullingMask; // [rsp+134h] [rbp+1Ch]
			//   Void *v141; // [rsp+138h] [rbp+20h]
			//   NativeArray_1_System_UInt32_ v142; // [rsp+148h] [rbp+30h] BYREF
			//   __int64 v143; // [rsp+158h] [rbp+40h] BYREF
			//   int v144; // [rsp+160h] [rbp+48h]
			//   Single__Array *m_csmShadowSplitPercentage; // [rsp+168h] [rbp+50h]
			//   _DWORD v146[2]; // [rsp+170h] [rbp+58h] BYREF
			//   Matrix4x4 outViewMatrix; // [rsp+178h] [rbp+60h] BYREF
			//   Matrix4x4 outProjMatrix; // [rsp+1B8h] [rbp+A0h] BYREF
			//   Matrix4x4 v149; // [rsp+1F8h] [rbp+E0h] BYREF
			//   uint64_t v150; // [rsp+238h] [rbp+120h]
			//   Matrix4x4 v151; // [rsp+248h] [rbp+130h] BYREF
			//   RendererList v152; // [rsp+288h] [rbp+170h] BYREF
			//   __int128 v153; // [rsp+298h] [rbp+180h] BYREF
			//   Vector4 v154; // [rsp+2A8h] [rbp+190h] BYREF
			//   _OWORD v155[4]; // [rsp+2B8h] [rbp+1A0h] BYREF
			//   Matrix4x4 v156; // [rsp+2F8h] [rbp+1E0h] BYREF
			//   VisibleLight v157; // [rsp+338h] [rbp+220h] BYREF
			//   RendererListDesc v158; // [rsp+3D8h] [rbp+2C0h] BYREF
			//   RendererListDesc v159; // [rsp+4B8h] [rbp+3A0h] BYREF
			//   HGShadowCullData shadowCullData; // [rsp+598h] [rbp+480h] BYREF
			//   ScriptableCullingParameters cullingParameters; // [rsp+738h] [rbp+620h] BYREF
			// 
			//   v15 = cascadeCount;
			//   if ( !byte_18D919E7E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<unsigned int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ShadowSplitData);
			//     sub_18003C530(&TypeInfo::Unity::Mathematics::float4);
			//     byte_18D919E7E = 1;
			//   }
			//   sub_1802F01E0(&v157, 0LL, 148LL);
			//   sub_1802F01E0(&outViewMatrix, 0LL, 64LL);
			//   sub_1802F01E0(&outProjMatrix, 0LL, 64LL);
			//   v142 = 0LL;
			//   sub_1802F01E0(&shadowCullData, 0LL, 412LL);
			//   v137 = 0LL;
			//   sub_1802F01E0(v155, 0LL, 64LL);
			//   v143 = 0LL;
			//   v144 = 0;
			//   v153 = 0LL;
			//   sub_1802F01E0(&cullingParameters, 0LL, 1592LL);
			//   v132.m_Id = 0;
			//   sub_1802F01E0(&v158, 0LL, 224LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1831, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1831, 0LL);
			//     if ( !Patch )
			//       goto LABEL_120;
			//     v127 = *cullingResults;
			//     v142 = (NativeArray_1_System_UInt32_)*lightCullResult;
			//     v130 = (Vector4)v127;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_705(
			//       (ILFixDynamicMethodWrapper_2 *)Patch,
			//       (Object *)this,
			//       (Object *)hgCamera,
			//       (CullingResults *)&v130,
			//       (LightCullResult *)&v142,
			//       directionalLightIndex,
			//       tileSize,
			//       atlasSize,
			//       cascadeCount,
			//       shadowIntensity,
			//       (Object *)unityRendererLists,
			//       (Object *)shadowRendererLists,
			//       (Object *)shadowGrassLists,
			//       shadowRequest,
			//       context,
			//       0LL);
			//   }
			//   else if ( this.fields.m_csmRenderMode == 1 )
			//   {
			//     v126 = *cullingResults;
			//     v142 = (NativeArray_1_System_UInt32_)*lightCullResult;
			//     v130 = (Vector4)v126;
			//     HG::Rendering::Runtime::HGShadowManager::CalculateDirectionalShadowParametersManualOverride(
			//       this,
			//       hgCamera,
			//       (CullingResults *)&v130,
			//       (LightCullResult *)&v142,
			//       directionalLightIndex,
			//       tileSize,
			//       atlasSize,
			//       cascadeCount,
			//       shadowIntensity,
			//       unityRendererLists,
			//       shadowRendererLists,
			//       shadowGrassLists,
			//       shadowRequest,
			//       context,
			//       0LL);
			//   }
			//   else
			//   {
			//     visibleLights = UnityEngine::HyperGryph::LightCullResult::get_visibleLights(
			//                       (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v130,
			//                       lightCullResult,
			//                       0LL);
			//     m_csmScreenSizeMinSquareds = directionalLightIndex;
			//     Patch = &v157;
			//     v157 = *(VisibleLight *)&visibleLights.m_Buffer[148 * directionalLightIndex];
			//     m_csmShadowSplitPercentage = this.fields.m_csmShadowSplitPercentage;
			//     if ( !*shadowRequest )
			//       goto LABEL_120;
			//     (*shadowRequest).fields.directionalLightIndex = directionalLightIndex;
			//     if ( !*shadowRequest )
			//       goto LABEL_120;
			//     v23 = tileSize;
			//     (*shadowRequest).fields.directionalShadowMapTileSize = tileSize;
			//     Patch = *shadowRequest;
			//     if ( !*shadowRequest )
			//       goto LABEL_120;
			//     *((Vector2Int *)Patch + 5) = atlasSize;
			//     if ( !*shadowRequest )
			//       goto LABEL_120;
			//     (*shadowRequest).fields.cascadeCount = cascadeCount;
			//     outViewMatrix = *(Matrix4x4 *)sub_182805160(&v134);
			//     outProjMatrix = *(Matrix4x4 *)sub_182805160(&v134);
			//     sub_182805160(&v134);
			//     v130 = (Vector4)*TypeInfo::Unity::Mathematics::float4.static_fields;
			//     AsVector4 = Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                   (Vector4 *)&v138,
			//                   (CinemachineSmoothPath_Waypoint *)&v130,
			//                   0LL);
			//     m_csmNearPlaneOffset_low = LODWORD(this.fields.m_csmNearPlaneOffset);
			//     LOBYTE(Patch) = this.fields.m_useShadowMapCache;
			//     viewHandle = m_csmNearPlaneOffset_low;
			//     v26 = *AsVector4;
			//     v27 = *shadowRequest;
			//     v138 = (CullingResults)v26;
			//     if ( !v27 )
			//       goto LABEL_120;
			//     v27.fields.useCache = (char)Patch;
			//     if ( !*shadowRequest )
			//       goto LABEL_120;
			//     (*shadowRequest).fields.directionalShadowStrength = shadowIntensity;
			//     Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//       &v142,
			//       cascadeCount,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
			//     if ( !hgCamera )
			//       goto LABEL_120;
			//     m_envVolumeCameraComponent = hgCamera.fields.m_envVolumeCameraComponent;
			//     light = UnityEngine::Rendering::VisibleLight::get_light(&v157, 0LL);
			//     if ( !m_envVolumeCameraComponent )
			//       goto LABEL_120;
			//     v30 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
			//             m_envVolumeCameraComponent,
			//             light,
			//             0LL);
			//     v31 = 0;
			//     if ( v30 )
			//     {
			//       v32 = hgCamera.fields.m_envVolumeCameraComponent;
			//       if ( !v32 )
			//         goto LABEL_120;
			//       m_interpolatedPhase = v32.fields.m_interpolatedPhase;
			//       if ( !m_interpolatedPhase )
			//         goto LABEL_120;
			//       v34 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m00;
			//       v35 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m01;
			//       v36 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m02;
			//       v37 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m03;
			//     }
			//     else
			//     {
			//       localToWorldMatrix = UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v134, &v157.hgSharedLightData, 0LL);
			//       v34 = *(_OWORD *)&localToWorldMatrix.m00;
			//       v35 = *(_OWORD *)&localToWorldMatrix.m01;
			//       v36 = *(_OWORD *)&localToWorldMatrix.m02;
			//       v37 = *(_OWORD *)&localToWorldMatrix.m03;
			//     }
			//     camera = hgCamera.fields.camera;
			//     *(_OWORD *)&v149.m02 = v36;
			//     m_csmMaxDistance = this.fields.m_csmMaxDistance;
			//     *(_OWORD *)&v149.m03 = v37;
			//     *(_OWORD *)&v149.m00 = v34;
			//     *(_OWORD *)&v149.m01 = v35;
			//     UnityEngine::HyperGryph::HGCullingSystem::ExtractShadowCullDataForDirLight(
			//       camera,
			//       &v149,
			//       m_csmMaxDistance,
			//       *(float *)&m_csmNearPlaneOffset_low,
			//       &shadowCullData,
			//       0LL);
			//     m_Buffer = v142.m_Buffer;
			//     v42 = 0;
			//     v43 = 1.0;
			//     v137 = v142.m_Buffer;
			//     if ( cascadeCount > 0 )
			//     {
			//       v141 = v142.m_Buffer;
			//       do
			//       {
			//         *(_DWORD *)m_Buffer = -1;
			//         if ( !this.fields.m_useShadowMapCache )
			//           goto LABEL_32;
			//         Patch = this.fields.m_updateCSMShadowMap;
			//         if ( !Patch )
			//           goto LABEL_120;
			//         if ( (unsigned int)v42 >= *((_DWORD *)Patch + 6) )
			//           goto LABEL_117;
			//         if ( *((_BYTE *)Patch + v42 + 32) )
			//         {
			// LABEL_32:
			//           v50 = *shadowRequest;
			//           v51 = (__m128)COERCE_UNSIGNED_INT((float)v23);
			//           if ( !*shadowRequest )
			//             goto LABEL_120;
			//           deviceProjectionYFlipMatrices = v50.fields.deviceProjectionYFlipMatrices;
			//           if ( !deviceProjectionYFlipMatrices )
			//             goto LABEL_120;
			//           shadowSplitData = v50.fields.shadowSplitData;
			//           if ( !shadowSplitData )
			//             goto LABEL_120;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//           v54 = sub_180836928(shadowSplitData, v42);
			//           v55 = (Matrix4x4 *)sub_1804440E4(deviceProjectionYFlipMatrices, v42);
			//           v129 = (MethodInfo *)v54;
			//           v56 = m_csmShadowSplitPercentage;
			//           v133 = *cullingResults;
			//           HG::Rendering::Runtime::HGShadowUtils::ExtractDirectionalLightData(
			//             &v157,
			//             (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v51, v51),
			//             v42,
			//             cascadeCount,
			//             m_csmShadowSplitPercentage,
			//             *(float *)&m_csmNearPlaneOffset_low,
			//             &v133,
			//             directionalLightIndex,
			//             &outViewMatrix,
			//             &outProjMatrix,
			//             v55,
			//             (ShadowSplitData *)v129,
			//             0LL);
			//           if ( v42 )
			//           {
			//             if ( !v56 )
			//               goto LABEL_120;
			//             v58 = v42 - 1LL;
			//             if ( (unsigned int)v58 >= v56.max_length.size )
			//               goto LABEL_117;
			//             v57 = v56.vector[v58];
			//           }
			//           else
			//           {
			//             v57 = 0.0;
			//           }
			//           if ( v42 + 1 == cascadeCount )
			//           {
			//             v59 = 1.0;
			//           }
			//           else
			//           {
			//             if ( !v56 )
			//               goto LABEL_120;
			//             if ( (unsigned int)v42 >= v56.max_length.size )
			//               goto LABEL_117;
			//             v59 = v56.vector[v42];
			//           }
			//           v60 = *shadowRequest;
			//           if ( !*shadowRequest )
			//             goto LABEL_120;
			//           v61 = v60.fields.deviceProjectionYFlipMatrices;
			//           if ( !v61 )
			//             goto LABEL_120;
			//           Patch = v60.fields.shadowSplitData;
			//           if ( !Patch )
			//             goto LABEL_120;
			//           outSplitData = (ShadowSplitData *)sub_180836928(Patch, v42);
			//           outProjFlipYMatrix = (Matrix4x4 *)sub_1804440E4(v61, v42);
			//           m_csmOcclusionDepthSize = 0;
			//           UnityEngine::HyperGryph::HGCullingSystem::GetPSSMSplitMatrices(
			//             &shadowCullData,
			//             v57,
			//             v59,
			//             tileSize,
			//             &outViewMatrix,
			//             &outProjMatrix,
			//             outProjFlipYMatrix,
			//             outSplitData,
			//             0LL);
			//           Patch = *shadowRequest;
			//           if ( !*shadowRequest )
			//             goto LABEL_120;
			//           Patch = (void *)*((_QWORD *)Patch + 9);
			//           if ( !Patch )
			//             goto LABEL_120;
			//           v65 = sub_180836928(Patch, v42);
			//           v66 = *shadowRequest;
			//           v149 = outProjMatrix;
			//           v149.m20 = -_mm_shuffle_ps(*(__m128 *)&v149.m00, *(__m128 *)&v149.m00, 170).m128_f32[0];
			//           v149.m21 = -_mm_shuffle_ps(*(__m128 *)&v149.m01, *(__m128 *)&v149.m01, 170).m128_f32[0];
			//           v149.m22 = -_mm_shuffle_ps(*(__m128 *)&v149.m02, *(__m128 *)&v149.m02, 170).m128_f32[0];
			//           v149.m23 = 1.0 - _mm_shuffle_ps(*(__m128 *)&outProjMatrix.m03, *(__m128 *)&outProjMatrix.m03, 170).m128_f32[0];
			//           v135 = v65;
			//           if ( !v66 )
			//             goto LABEL_120;
			//           v67 = v66.fields.shadowSplitData;
			//           if ( !v67 )
			//             goto LABEL_120;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ShadowSplitData);
			//           v68 = (_DWORD *)sub_180836928(v67, v42);
			//           v69 = hgCamera.fields.camera;
			//           LODWORD(v136) = *v68;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//           SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v69, 0LL);
			//           Patch = hgCamera.fields.camera;
			//           v150 = SceneCullingMaskFromCamera;
			//           if ( !Patch )
			//             goto LABEL_120;
			//           cullingMask = UnityEngine::Camera::get_cullingMask((Camera *)Patch, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//           Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//           m_csmScreenSizeMinSquareds = *((_QWORD *)Patch + 16);
			//           if ( !m_csmScreenSizeMinSquareds )
			//             goto LABEL_120;
			//           if ( (unsigned int)v42 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
			//             goto LABEL_117;
			//           v71 = *(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * v42 + 32);
			//           Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//           v72 = *(_DWORD *)(*((_QWORD *)Patch + 16) + 4LL * v42 + 32);
			//           m_csmScreenSizeMinSquareds = (__int64)this.fields.m_csmScreenSizeMinSquareds;
			//           if ( !m_csmScreenSizeMinSquareds )
			//             goto LABEL_120;
			//           if ( (unsigned int)v42 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
			//             goto LABEL_117;
			//           Patch = this.fields.m_csmEnableOcclusionCulling;
			//           if ( !Patch )
			//             goto LABEL_120;
			//           if ( (unsigned int)v42 >= *((_DWORD *)Patch + 6) )
			//             goto LABEL_117;
			//           if ( *((_BYTE *)Patch + v42 + 32) )
			//           {
			//             m_csmOcclusionDepthSize = this.fields.m_csmOcclusionDepthSize;
			//             v73 = m_csmOcclusionDepthSize;
			//           }
			//           else
			//           {
			//             v73 = 0;
			//           }
			//           v74 = *(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * v42 + 32);
			//           v151 = outViewMatrix;
			//           v75 = (void *)(v135 + 4);
			//           v134 = v149;
			//           LODWORD(v135) = v71 | 0x8000002;
			//           v139 = v72 | 0x8000002;
			//           v133.ptr = v75;
			//           v76 = UnityEngine::Matrix4x4::op_Multiply(&v156, &v134, &v151, 0LL);
			//           v155[0] = *(_OWORD *)&v76.m00;
			//           v155[1] = *(_OWORD *)&v76.m01;
			//           v155[2] = *(_OWORD *)&v76.m02;
			//           v77 = *(_OWORD *)&v76.m03;
			//           v143 = 0LL;
			//           v144 = 0;
			//           v78 = (__int64 (__fastcall *)(void *, _QWORD, _QWORD, uint64_t, int32_t, _DWORD, int, LODCrossFadeConfig *, int, int, _DWORD, int32_t, int32_t, _OWORD *, __int64 *, __int128 *, _DWORD, int))qword_18D92FA58;
			//           v155[3] = v77;
			//           v153 = 0LL;
			//           if ( !qword_18D92FA58 )
			//           {
			//             v78 = (__int64 (__fastcall *)(void *, _QWORD, _QWORD, uint64_t, int32_t, _DWORD, int, LODCrossFadeConfig *, int, int, _DWORD, int32_t, int32_t, _OWORD *, __int64 *, __int128 *, _DWORD, int))sub_180017470("UnityEngine.HyperGryph.HGCullingSystem::AddCullViewByPlanes(System.IntPtr,System.Int32,System.Int32,System.UInt64,System.UInt32,System.UInt32,System.UInt32,UnityEngine.HyperGryph.LODCrossFadeConfig&,System.Single,UnityEngine.CameraType,System.UInt32,System.Int32,System.Int32,UnityEngine.Matrix4x4&,UnityEngine.Vector3&,UnityEngine.Vector4&,System.Single,System.Single)");
			//             qword_18D92FA58 = (__int64)v78;
			//           }
			//           v79 = v78(
			//                   v133.ptr,
			//                   (unsigned int)v136,
			//                   0LL,
			//                   v150,
			//                   cullingMask,
			//                   v135,
			//                   v139,
			//                   &hgCamera.fields.lodCrossFadeConfig,
			//                   v74,
			//                   32,
			//                   0,
			//                   m_csmOcclusionDepthSize,
			//                   v73,
			//                   v155,
			//                   &v143,
			//                   &v153,
			//                   0,
			//                   1028443341);
			//           *(_DWORD *)v141 = v79;
			//           Patch = *shadowRequest;
			//           if ( !*shadowRequest )
			//             goto LABEL_120;
			//           Patch = (void *)*((_QWORD *)Patch + 7);
			//           if ( !Patch )
			//             goto LABEL_120;
			//           v134 = outViewMatrix;
			//           sub_180077420(Patch, v42, &v134);
			//           v80 = *(_OWORD *)&outProjMatrix.m00;
			//           v81 = *(_OWORD *)&outProjMatrix.m01;
			//           v82 = *(_OWORD *)&outProjMatrix.m02;
			//           v83 = *(_OWORD *)&outProjMatrix.m03;
			//           v84 = *(_OWORD *)&outViewMatrix.m00;
			//           v85 = *(_OWORD *)&outViewMatrix.m01;
			//           v86 = *(_OWORD *)&outViewMatrix.m02;
			//           v87 = *(_OWORD *)&outViewMatrix.m03;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//           *(_OWORD *)&v134.m00 = v84;
			//           *(_OWORD *)&v134.m01 = v85;
			//           *(_OWORD *)&v134.m02 = v86;
			//           *(_OWORD *)&v134.m03 = v87;
			//           *(_OWORD *)&v151.m00 = v80;
			//           *(_OWORD *)&v151.m01 = v81;
			//           *(_OWORD *)&v151.m02 = v82;
			//           *(_OWORD *)&v151.m03 = v83;
			//           ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v156, &v151, &v134, 0LL);
			//           Patch = *shadowRequest;
			//           if ( !*shadowRequest )
			//             goto LABEL_120;
			//           Patch = (void *)*((_QWORD *)Patch + 10);
			//           if ( !Patch )
			//             goto LABEL_120;
			//           v89 = *(_OWORD *)&ShadowTransform.m01;
			//           *(_OWORD *)&v134.m00 = *(_OWORD *)&ShadowTransform.m00;
			//           v90 = *(_OWORD *)&ShadowTransform.m02;
			//           *(_OWORD *)&v134.m01 = v89;
			//           v91 = *(_OWORD *)&ShadowTransform.m03;
			//           *(_OWORD *)&v134.m02 = v90;
			//           *(_OWORD *)&v134.m03 = v91;
			//           sub_180077420(Patch, v42, &v134);
			//           if ( !*shadowRequest )
			//             goto LABEL_120;
			//           v92 = (*shadowRequest).fields.shadowSplitData;
			//           if ( !v92 )
			//             goto LABEL_120;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ShadowSplitData);
			//           v93 = (__m128)_mm_loadu_si128((const __m128i *)(sub_180836928(v92, v42) + 164));
			//           Patch = *shadowRequest;
			//           LODWORD(v94) = _mm_shuffle_ps(v93, v93, 85).m128_u32[0];
			//           LODWORD(v95) = _mm_shuffle_ps(v93, v93, 170).m128_u32[0];
			//           LODWORD(v138.ptr) = v93.m128_i32[0];
			//           v93.m128_f32[0] = _mm_shuffle_ps(v93, v93, 255).m128_f32[0];
			//           *((float *)&v138.ptr + 1) = v94;
			//           *(float *)&v138.m_AllocationInfo = v95;
			//           *((float *)&v138.m_AllocationInfo + 1) = v93.m128_f32[0] * v93.m128_f32[0];
			//           if ( !Patch )
			//             goto LABEL_120;
			//           Patch = (void *)*((_QWORD *)Patch + 11);
			//           if ( !Patch )
			//             goto LABEL_120;
			//           v133 = v138;
			//           sub_18004D910(Patch, v42, &v133);
			//           if ( !*shadowRequest )
			//             goto LABEL_120;
			//           cascadeShadowBiases = (*shadowRequest).fields.cascadeShadowBiases;
			//           m_csmNormalBias = this.fields.m_csmNormalBias;
			//           m_csmShadowSampleMode = this.fields.m_csmShadowSampleMode;
			//           v23 = tileSize;
			//           m_csmDepthBias = this.fields.m_csmDepthBias;
			//           v134 = outProjMatrix;
			//           ShadowBias = HG::Rendering::Runtime::HGShadowUtils::GetShadowBias(
			//                          &v154,
			//                          &v134,
			//                          (float)tileSize,
			//                          m_csmDepthBias,
			//                          m_csmNormalBias,
			//                          (HGShadowSampleMode__Enum)m_csmShadowSampleMode,
			//                          0LL);
			//           if ( !cascadeShadowBiases )
			//             goto LABEL_120;
			//           v133 = (CullingResults)*ShadowBias;
			//           sub_18004D910(cascadeShadowBiases, v42, &v133);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//           v31 = 0;
			//           Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_atlasScales;
			//           if ( !Patch )
			//             goto LABEL_120;
			//           sub_18004E290(Patch, v146, cascadeCount - 1LL);
			//           v101 = (__m128)v146[0];
			//           v102 = (__m128)v146[1];
			//           Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_atlasOffsets;
			//           if ( !Patch )
			//             goto LABEL_120;
			//           sub_18004E290(Patch, &v152, v42);
			//           v103 = sub_184D038DC(v152.context, _mm_unpacklo_ps(v101, v102).m128_u64[0]);
			//           Patch = *shadowRequest;
			//           v136 = v103;
			//           if ( !Patch )
			//             goto LABEL_120;
			//           Patch = (void *)*((_QWORD *)Patch + 13);
			//           *(_QWORD *)&v130.x = v136;
			//           LODWORD(v130.z) = v101.m128_i32[0];
			//           LODWORD(v130.w) = v102.m128_i32[0];
			//           if ( !Patch )
			//             goto LABEL_120;
			//           v133 = (CullingResults)v130;
			//           sub_18004D910(Patch, v42, &v133);
			//           Patch = *shadowRequest;
			//           if ( !*shadowRequest )
			//             goto LABEL_120;
			//           HG::Rendering::Runtime::HGShadowManager::CascadedShadowRequest::CopyTo(
			//             (HGShadowManager_CascadedShadowRequest *)Patch,
			//             this.fields.m_cachedCascadedShadowRequest,
			//             v42,
			//             0LL);
			//           Patch = *shadowRequest;
			//           if ( !*shadowRequest )
			//             goto LABEL_120;
			//           Patch = (void *)*((_QWORD *)Patch + 3);
			//           if ( !Patch )
			//             goto LABEL_120;
			//           if ( (unsigned int)v42 >= *((_DWORD *)Patch + 6) )
			//             goto LABEL_117;
			//           m_csmNearPlaneOffset_low = viewHandle;
			//           *((_BYTE *)Patch + v42 + 32) = 1;
			//         }
			//         else
			//         {
			//           Patch = this.fields.m_cachedCascadedShadowRequest;
			//           if ( !Patch )
			//             goto LABEL_120;
			//           HG::Rendering::Runtime::HGShadowManager::CascadedShadowRequest::CopyTo(
			//             (HGShadowManager_CascadedShadowRequest *)Patch,
			//             *shadowRequest,
			//             v42,
			//             0LL);
			//           v44 = *shadowRequest;
			//           v45 = (__m128)COERCE_UNSIGNED_INT((float)v23);
			//           if ( !*shadowRequest )
			//             goto LABEL_120;
			//           v46 = v44.fields.deviceProjectionYFlipMatrices;
			//           if ( !v46 )
			//             goto LABEL_120;
			//           v47 = v44.fields.shadowSplitData;
			//           if ( !v47 )
			//             goto LABEL_120;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//           v48 = (ShadowSplitData *)sub_180836928(v47, v42);
			//           v49 = (Matrix4x4 *)sub_1804440E4(v46, v42);
			//           v133 = *cullingResults;
			//           HG::Rendering::Runtime::HGShadowUtils::ExtractDirectionalLightData(
			//             &v157,
			//             (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v45, v45),
			//             v42,
			//             cascadeCount,
			//             m_csmShadowSplitPercentage,
			//             *(float *)&m_csmNearPlaneOffset_low,
			//             &v133,
			//             directionalLightIndex,
			//             &outViewMatrix,
			//             &outProjMatrix,
			//             v49,
			//             v48,
			//             0LL);
			//           Patch = *shadowRequest;
			//           v31 = 0;
			//           if ( !*shadowRequest )
			//             goto LABEL_120;
			//           Patch = (void *)*((_QWORD *)Patch + 3);
			//           if ( !Patch )
			//             goto LABEL_120;
			//           if ( (unsigned int)v42 >= *((_DWORD *)Patch + 6) )
			//             goto LABEL_117;
			//           v23 = tileSize;
			//           *((_BYTE *)Patch + v42 + 32) = 0;
			//         }
			//         ++v42;
			//         m_Buffer = v141 + 4;
			//         v141 += 4;
			//       }
			//       while ( v42 < cascadeCount );
			//     }
			//     UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
			//     v104 = 0;
			//     if ( cascadeCount > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//         Patch = TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList.static_fields;
			//         if ( !unityRendererLists )
			//           break;
			//         v130 = *(Vector4 *)Patch;
			//         sub_1803EF6F4(unityRendererLists, v104, &v130);
			//         v134 = outViewMatrix;
			//         v151 = outProjMatrix;
			//         v105 = UnityEngine::Matrix4x4::op_Multiply(&v156, &v151, &v134, 0LL);
			//         v106 = *(_OWORD *)&v105.m00;
			//         v107 = *(_OWORD *)&v105.m01;
			//         v108 = *(_OWORD *)&v105.m02;
			//         v109 = *(_OWORD *)&v105.m03;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         *(_OWORD *)&v134.m00 = v106;
			//         *(_OWORD *)&v134.m01 = v107;
			//         *(_OWORD *)&v134.m02 = v108;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//         *(_OWORD *)&v134.m03 = v109;
			//         UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v134, static_fields.s_tempPlanes, 0LL);
			//         if ( !UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL) )
			//         {
			//           Patch = hgCamera.fields.camera;
			//           if ( !Patch )
			//             break;
			//           UnityEngine::Camera::TryGetCullingParameters((Camera *)Patch, &cullingParameters, 0LL);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//           *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m20 = v106;
			//           *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m21 = v107;
			//           *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m22 = v108;
			//           *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m23 = v109;
			//           UnityEngine::Rendering::ScriptableCullingParameters::set_isOrthographic(&cullingParameters, 1, 0LL);
			//           cullingParameters.m_CameraProperties.cameraWorldToClip.m31 = 0.0;
			//           do
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//             Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.s_tempPlanes;
			//             if ( !Patch )
			//               goto LABEL_120;
			//             sub_180037190(Patch, &v138, v31);
			//             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//             v130 = (Vector4)v138;
			//             UnityEngine::Rendering::ScriptableCullingParameters::SetCullingPlane(
			//               &cullingParameters,
			//               v31++,
			//               (Plane *)&v130,
			//               0LL);
			//           }
			//           while ( v31 < 6 );
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           v111 = *UnityEngine::Rendering::ScriptableRenderContext::Cull(
			//                     (CullingResults *)&v154,
			//                     &context,
			//                     &cullingParameters,
			//                     0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//           UnityEngine::Rendering::ShaderTagId::ShaderTagId(
			//             &v132,
			//             TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields.s_ShadowCasterStr,
			//             0LL);
			//           v112 = hgCamera.fields.camera;
			//           v31 = 0;
			//           v130 = (Vector4)v111;
			//           UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(
			//             &v158,
			//             v132,
			//             (CullingResults *)&v130,
			//             v112,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//           v158.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllOpaque;
			//           v158.sortingCriteria = 59;
			//           v158.rendererConfiguration = 30720;
			//           v159 = v158;
			//           v130 = (Vector4)*UnityEngine::Rendering::ScriptableRenderContext::CreateRendererList(
			//                              &v152,
			//                              &context,
			//                              &v159,
			//                              0LL);
			//           sub_1803EF6F4(unityRendererLists, v104, &v130);
			//         }
			//         if ( ++v104 >= cascadeCount )
			//           goto LABEL_93;
			//       }
			// LABEL_120:
			//       sub_180B536AC(Patch, m_csmScreenSizeMinSquareds);
			//     }
			// LABEL_93:
			//     v113 = 0;
			//     if ( cascadeCount > 0 )
			//     {
			//       v114 = 0LL;
			//       Patch = shadowGrassLists;
			//       while ( 1 )
			//       {
			//         m_csmScreenSizeMinSquareds = 0xFFFFFFFFLL;
			//         if ( *(_DWORD *)&v137[v114] == -1 )
			//         {
			//           if ( !shadowRendererLists )
			//             goto LABEL_120;
			//           if ( v113 >= shadowRendererLists.max_length.size )
			//             break;
			//           shadowRendererLists.vector[v113] = -1;
			//         }
			//         else
			//         {
			//           viewHandle = *(_DWORD *)&v137[v114];
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//           Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
			//           m_cascadeRenderFlags = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_cascadeRenderFlags;
			//           if ( !m_cascadeRenderFlags )
			//             goto LABEL_120;
			//           if ( v113 >= m_cascadeRenderFlags.max_length.size )
			//             break;
			//           v116 = m_cascadeRenderFlags.vector[v113];
			//           v117 = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_cascadeRenderFlags.vector[v113];
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           LOWORD(methoda) = 0;
			//           RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                            viewHandle,
			//                            (HGRenderFlags__Enum)(v116 | 0x2080100),
			//                            (HGRenderFlags__Enum)(v117 | 0x2080100),
			//                            HGShaderLightMode__Enum_ShadowCaster,
			//                            methoda,
			//                            context.m_Ptr,
			//                            0,
			//                            0,
			//                            0xFFFFFFFF,
			//                            0,
			//                            0,
			//                            0LL);
			//           if ( !shadowRendererLists )
			//             goto LABEL_120;
			//           if ( v113 >= shadowRendererLists.max_length.size )
			//             break;
			//           shadowRendererLists.vector[v113] = RendererList;
			//           Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
			//           m_csmScreenSizeMinSquareds = (__int64)TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_cascadeRenderFlags;
			//           if ( !m_csmScreenSizeMinSquareds )
			//             goto LABEL_120;
			//           if ( v113 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
			//             break;
			//           v119 = UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
			//                    *(_DWORD *)&v137[v114],
			//                    (HGRenderFlags__Enum)(*(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * (int)v113 + 32) | 0x2080100),
			//                    (HGRenderFlags__Enum)(TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_cascadeRenderFlags.vector[v113] | 0x2080100),
			//                    HGShaderLightMode__Enum_ShadowCaster,
			//                    context.m_Ptr,
			//                    0,
			//                    0LL);
			//           Patch = shadowGrassLists;
			//           m_csmScreenSizeMinSquareds = v119;
			//         }
			//         if ( !Patch )
			//           goto LABEL_120;
			//         if ( v113 >= *((_DWORD *)Patch + 6) )
			//           break;
			//         v120 = (int)v113;
			//         v114 += 4LL;
			//         ++v113;
			//         *((_DWORD *)Patch + v120 + 8) = m_csmScreenSizeMinSquareds;
			//         if ( (int)v113 >= cascadeCount )
			//           goto LABEL_109;
			//       }
			// LABEL_117:
			//       sub_180070270(Patch, m_csmScreenSizeMinSquareds);
			//     }
			// LABEL_109:
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&v142,
			//       MethodInfo::Unity::Collections::NativeArray<unsigned int>::Dispose);
			//     zero = UnityEngine::Matrix4x4::get_zero(&v156, 0LL);
			//     v122 = *(_OWORD *)&zero.m00;
			//     v123 = *(_OWORD *)&zero.m01;
			//     v124 = *(_OWORD *)&zero.m03;
			//     *(_OWORD *)&v134.m02 = *(_OWORD *)&zero.m02;
			//     if ( !UnityEngine::SystemInfo::UsesReversedZBuffer(0LL) )
			//       v43 = 0.0;
			//     v134.m22 = v43;
			//     if ( cascadeCount <= 4 )
			//     {
			//       v125 = *(_OWORD *)&v134.m02;
			//       while ( *shadowRequest )
			//       {
			//         Patch = (*shadowRequest).fields.worldToShadowMatrices;
			//         if ( !Patch )
			//           break;
			//         *(_OWORD *)&v134.m00 = v122;
			//         *(_OWORD *)&v134.m01 = v123;
			//         *(_OWORD *)&v134.m02 = v125;
			//         *(_OWORD *)&v134.m03 = v124;
			//         sub_180077420(Patch, v15++, &v134);
			//         if ( v15 > 4 )
			//           return;
			//       }
			//       goto LABEL_120;
			//     }
			//   }
			// }
			// 
		}

		private void GetManualCsmSphereMatrices(Matrix4x4 lightToWorld, Vector4 targetSphere, out Matrix4x4 projection, out Matrix4x4 view)
		{
			// // Void GetManualCsmSphereMatrices(Matrix4x4, Vector4, Matrix4x4 ByRef, Matrix4x4 ByRef)
			// void HG::Rendering::Runtime::HGShadowManager::GetManualCsmSphereMatrices(
			//         HGShadowManager *this,
			//         Matrix4x4 *lightToWorld,
			//         Vector4 *targetSphere,
			//         Matrix4x4 *projection,
			//         Matrix4x4 *view,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v10; // r8
			//   Vector3 *v11; // rax
			//   __int64 v12; // xmm6_8
			//   float z; // ebx
			//   float w; // xmm2_4
			//   MethodInfo *v15; // r9
			//   Vector3 *v16; // rax
			//   __int64 v17; // xmm3_8
			//   MethodInfo *v18; // r9
			//   Vector3 *v19; // rax
			//   __int64 *v20; // r8
			//   __int64 v21; // xmm0_8
			//   __int64 v22; // xmm3_8
			//   MethodInfo *v23; // r9
			//   Vector3 *v24; // rax
			//   float v25; // xmm4_4
			//   float v26; // ebx
			//   Matrix4x4 *v27; // rax
			//   __m128 v28; // xmm4
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm2
			//   __int128 v31; // xmm3
			//   __int128 v32; // xmm0
			//   __m128 v33; // xmm1
			//   __m128 v34; // xmm2
			//   Matrix4x4 *inverse; // rax
			//   __int128 v36; // xmm1
			//   __int128 v37; // xmm2
			//   __int128 v38; // xmm3
			//   __int64 v39; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   __int128 v44; // xmm0
			//   Vector3 v45; // [rsp+48h] [rbp-79h] BYREF
			//   Vector4 v46; // [rsp+58h] [rbp-69h] BYREF
			//   Vector4 v47; // [rsp+68h] [rbp-59h] BYREF
			//   Matrix4x4 v48; // [rsp+78h] [rbp-49h] BYREF
			//   Matrix4x4 v49; // [rsp+B8h] [rbp-9h] BYREF
			// 
			//   *(_QWORD *)&v48.m02 = 0LL;
			//   v48.m22 = 0.0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1833, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1833, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v39);
			//     v41 = *(_OWORD *)&lightToWorld.m00;
			//     v47 = *targetSphere;
			//     v42 = *(_OWORD *)&lightToWorld.m01;
			//     *(_OWORD *)&v48.m00 = v41;
			//     v43 = *(_OWORD *)&lightToWorld.m02;
			//     *(_OWORD *)&v48.m01 = v42;
			//     v44 = *(_OWORD *)&lightToWorld.m03;
			//     *(_OWORD *)&v48.m02 = v43;
			//     *(_OWORD *)&v48.m03 = v44;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_704(Patch, (Object *)this, &v48, &v47, projection, view, 0LL);
			//   }
			//   else
			//   {
			//     v47 = *UnityEngine::Matrix4x4::GetColumn(&v47, lightToWorld, 2, 0LL);
			//     v11 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v46, &v47, v10);
			//     v12 = *(_QWORD *)&v11.x;
			//     z = v11.z;
			//     v46 = *targetSphere;
			//     HG::Rendering::Runtime::VectorSwizzleUtils::xyz((Vector3 *)&v47, &v46, 0LL);
			//     w = targetSphere.w;
			//     *(_QWORD *)&v45.x = v12;
			//     v45.z = z;
			//     v16 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v46, &v45, w, v15);
			//     v17 = *(_QWORD *)&v16.x;
			//     *(float *)&v16 = v16.z;
			//     *(_QWORD *)&v45.x = v17;
			//     LODWORD(v45.z) = (_DWORD)v16;
			//     v19 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v46, &v45, 1.05, v18);
			//     v21 = *v20;
			//     v22 = *(_QWORD *)&v19.x;
			//     v45.z = v19.z;
			//     LODWORD(v19) = *((_DWORD *)v20 + 2);
			//     *(_QWORD *)&v45.x = v22;
			//     *(_QWORD *)&v46.x = v21;
			//     LODWORD(v46.z) = (_DWORD)v19;
			//     v24 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v47, (Vector3 *)&v46, &v45, v23);
			//     v26 = v24.z;
			//     *(_QWORD *)&v46.x = *(_QWORD *)&v24.x;
			//     v27 = UnityEngine::Matrix4x4::Ortho(&v49, -v25, v25, -v25, v25, -50.0, (float)(v25 + v25) * 1.2, 0LL);
			//     v28 = *(__m128 *)&lightToWorld.m02;
			//     v29 = *(_OWORD *)&v27.m01;
			//     v30 = *(_OWORD *)&v27.m02;
			//     v31 = *(_OWORD *)&v27.m03;
			//     *(_OWORD *)&projection.m00 = *(_OWORD *)&v27.m00;
			//     v32 = *(_OWORD *)&lightToWorld.m03;
			//     *(_OWORD *)&projection.m01 = v29;
			//     v33 = *(__m128 *)&lightToWorld.m00;
			//     *(_OWORD *)&v49.m03 = v32;
			//     *(_OWORD *)&projection.m02 = v30;
			//     v34 = *(__m128 *)&lightToWorld.m01;
			//     LODWORD(v48.m00) = v33.m128_i32[0];
			//     *(_OWORD *)&projection.m03 = v31;
			//     LODWORD(v48.m01) = v34.m128_i32[0];
			//     LODWORD(v48.m10) = _mm_shuffle_ps(v33, v33, 85).m128_u32[0];
			//     *(_QWORD *)&v48.m21 = _mm_shuffle_ps(v34, v34, 170).m128_u32[0];
			//     *(_QWORD *)&v48.m20 = _mm_shuffle_ps(v33, v33, 170).m128_u32[0];
			//     LODWORD(v48.m11) = _mm_shuffle_ps(v34, v34, 85).m128_u32[0];
			//     *(_QWORD *)&v48.m22 = COERCE_UNSIGNED_INT(-_mm_shuffle_ps(v28, v28, 170).m128_f32[0]);
			//     *(_QWORD *)&v48.m03 = *(_QWORD *)&v46.x;
			//     v48.m02 = -v28.m128_f32[0];
			//     v48.m12 = -_mm_shuffle_ps(v28, v28, 85).m128_f32[0];
			//     v48.m23 = v26;
			//     v48.m33 = 1.0;
			//     inverse = UnityEngine::Matrix4x4::get_inverse(&v49, &v48, 0LL);
			//     v36 = *(_OWORD *)&inverse.m01;
			//     v37 = *(_OWORD *)&inverse.m02;
			//     v38 = *(_OWORD *)&inverse.m03;
			//     *(_OWORD *)&view.m00 = *(_OWORD *)&inverse.m00;
			//     *(_OWORD *)&view.m01 = v36;
			//     *(_OWORD *)&view.m02 = v37;
			//     *(_OWORD *)&view.m03 = v38;
			//   }
			// }
			// 
		}

		private void CalculateDirectionalShadowParametersManualOverride(HGCamera hgCamera, CullingResults cullingResults, LightCullResult lightCullResult, int directionalLightIndex, int tileSize, Vector2Int atlasSize, int cascadeCount, float shadowIntensity, RendererList[] unityRendererLists, uint[] shadowRendererLists, uint[] shadowGrassLists, ref HGShadowManager.CascadedShadowRequest shadowRequest, ScriptableRenderContext context)
		{
			// // Void CalculateDirectionalShadowParametersManualOverride(HGCamera, CullingResults, LightCullResult, Int32, Int32, Vector2Int, Int32, Single, RendererList[], UInt32[], UInt32[], HGShadowManager+CascadedShadowRequest ByRef, ScriptableRenderContext)
			// void HG::Rendering::Runtime::HGShadowManager::CalculateDirectionalShadowParametersManualOverride(
			//         HGShadowManager *this,
			//         HGCamera *hgCamera,
			//         CullingResults *cullingResults,
			//         LightCullResult *lightCullResult,
			//         int32_t directionalLightIndex,
			//         int32_t tileSize,
			//         Vector2Int atlasSize,
			//         int32_t cascadeCount,
			//         float shadowIntensity,
			//         RendererList__Array *unityRendererLists,
			//         UInt32__Array *shadowRendererLists,
			//         UInt32__Array *shadowGrassLists,
			//         HGShadowManager_CascadedShadowRequest **shadowRequest,
			//         ScriptableRenderContext context,
			//         MethodInfo *method)
			// {
			//   int32_t v15; // r14d
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights; // rax
			//   __int64 m_csmScreenSizeMinSquareds; // rdx
			//   void *Patch; // rcx
			//   _OWORD *v23; // rax
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   _OWORD *v27; // rax
			//   __int128 v28; // xmm1
			//   __int128 v29; // xmm0
			//   __int128 v30; // xmm1
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rbx
			//   Light *light; // rax
			//   HGEnvironmentVolumeCameraComponent *v33; // rax
			//   HGEnvironmentPhase *m_interpolatedPhase; // rax
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm2
			//   __int128 v37; // xmm3
			//   __int128 v38; // xmm4
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   Vector4 m_csmManualOverrideSphere; // xmm0
			//   __int128 v41; // xmm13
			//   __int128 v42; // xmm14
			//   __int128 v43; // xmm15
			//   __int128 v44; // xmm10
			//   __int128 v45; // xmm11
			//   Matrix4x4 *v46; // rax
			//   __int128 v47; // xmm6
			//   __int128 v48; // xmm7
			//   __int128 v49; // xmm8
			//   __int128 v50; // xmm9
			//   HGShadowManager__StaticFields *static_fields; // rdx
			//   int32_t v52; // edi
			//   __int128 v53; // xmm9
			//   float v54; // xmm12_4
			//   Void *v55; // r12
			//   int32_t m_csmOcclusionDepthSize; // r12d
			//   Matrix4x4__Array *deviceProjectionYFlipMatrices; // rbx
			//   Matrix4x4 *GPUProjectionMatrix; // rax
			//   __int128 v59; // xmm1
			//   __int128 v60; // xmm0
			//   __int128 v61; // xmm1
			//   struct HGShadowManager__Class *v62; // rdx
			//   Plane__Array *s_tempPlanes; // rcx
			//   __int64 v64; // rax
			//   Camera *camera; // rbx
			//   uint64_t SceneCullingMaskFromCamera; // rax
			//   int v67; // r9d
			//   HGObjectFlags__Enum v68; // r10d
			//   int32_t v69; // ebx
			//   int v70; // xmm6_4
			//   __int64 (__fastcall *v71)(__int64, _QWORD, _QWORD, unsigned __int64, int32_t, int, int, LODCrossFadeConfig *, int, int, _DWORD, int32_t, int32_t, _BYTE *, __int64 *, __int128 *, _DWORD, int); // rax
			//   int v72; // eax
			//   Void *v73; // r12
			//   __int128 v74; // xmm6
			//   __int128 v75; // xmm7
			//   Matrix4x4 *ShadowTransform; // rax
			//   __int128 v77; // xmm1
			//   __int128 v78; // xmm0
			//   __int128 v79; // xmm1
			//   Vector4__Array *cascadeShadowBiases; // rbx
			//   float m_csmDepthBias; // xmm3_4
			//   Vector4 *ShadowBias; // rax
			//   __m128 v83; // xmm6
			//   __m128 v84; // xmm7
			//   __int64 v85; // rax
			//   __int64 v86; // rax
			//   int32_t v87; // edi
			//   Matrix4x4 *v88; // rax
			//   __int128 v89; // xmm10
			//   __int128 v90; // xmm11
			//   __int128 v91; // xmm12
			//   __int128 v92; // xmm13
			//   HGShadowManager__StaticFields *v93; // rdx
			//   int32_t i; // ebx
			//   CullingResults v95; // xmm6
			//   Camera *v96; // r9
			//   unsigned int v97; // esi
			//   __int64 v98; // r13
			//   HGRenderFlags__Enum__Array *m_cascadeRenderFlags; // rdi
			//   HGRenderFlags__Enum v100; // edi
			//   HGRenderFlags__Enum v101; // ebx
			//   uint32_t RendererList; // eax
			//   uint32_t v103; // eax
			//   __int64 v104; // rax
			//   Matrix4x4 *zero; // rax
			//   __int128 v106; // xmm7
			//   __int128 v107; // xmm8
			//   __int128 v108; // xmm9
			//   __int128 v109; // xmm6
			//   CullingResults v110; // xmm1
			//   HGRenderKeyword__Enum methoda; // [rsp+28h] [rbp-F0h]
			//   float methodb; // [rsp+28h] [rbp-F0h]
			//   unsigned int contexta; // [rsp+30h] [rbp-E8h]
			//   __m128 v114; // [rsp+98h] [rbp-80h] BYREF
			//   Matrix4x4 v115; // [rsp+A8h] [rbp-70h] BYREF
			//   ShaderTagId v116; // [rsp+E8h] [rbp-30h] BYREF
			//   uint32_t viewHandle[2]; // [rsp+F0h] [rbp-28h]
			//   __int64 v118; // [rsp+F8h] [rbp-20h]
			//   __m128 v119; // [rsp+108h] [rbp-10h] BYREF
			//   int v120; // [rsp+118h] [rbp+0h]
			//   int v121; // [rsp+11Ch] [rbp+4h]
			//   int32_t cullingMask; // [rsp+120h] [rbp+8h]
			//   __int64 v123; // [rsp+128h] [rbp+10h] BYREF
			//   int v124; // [rsp+130h] [rbp+18h]
			//   Matrix4x4 v125; // [rsp+138h] [rbp+20h] BYREF
			//   _DWORD v126[2]; // [rsp+178h] [rbp+60h] BYREF
			//   Void *v127; // [rsp+180h] [rbp+68h]
			//   Void *m_Buffer; // [rsp+188h] [rbp+70h]
			//   NativeArray_1_System_UInt32_ v129; // [rsp+198h] [rbp+80h] BYREF
			//   Matrix4x4 v130; // [rsp+1A8h] [rbp+90h] BYREF
			//   Vector4 v131; // [rsp+1E8h] [rbp+D0h] BYREF
			//   __int128 v132; // [rsp+1F8h] [rbp+E0h] BYREF
			//   Matrix4x4 v133; // [rsp+208h] [rbp+F0h] BYREF
			//   Vector4 v134; // [rsp+248h] [rbp+130h] BYREF
			//   Matrix4x4 v135; // [rsp+258h] [rbp+140h] BYREF
			//   _BYTE v136[64]; // [rsp+298h] [rbp+180h] BYREF
			//   VisibleLight v137; // [rsp+2D8h] [rbp+1C0h] BYREF
			//   RendererListDesc v138; // [rsp+378h] [rbp+260h] BYREF
			//   RendererListDesc v139; // [rsp+458h] [rbp+340h] BYREF
			//   ScriptableCullingParameters cullingParameters; // [rsp+538h] [rbp+420h] BYREF
			// 
			//   v15 = cascadeCount;
			//   if ( !byte_18D919E7F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<unsigned int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::Unity::Mathematics::float4);
			//     byte_18D919E7F = 1;
			//   }
			//   sub_1802F01E0(&v137, 0LL, 148LL);
			//   v129 = 0LL;
			//   sub_1802F01E0(v136, 0LL, 64LL);
			//   v123 = 0LL;
			//   v124 = 0;
			//   v132 = 0LL;
			//   sub_1802F01E0(&cullingParameters, 0LL, 1592LL);
			//   v116.m_Id = 0;
			//   sub_1802F01E0(&v138, 0LL, 224LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1832, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1832, 0LL);
			//     if ( !Patch )
			//       goto LABEL_90;
			//     v110 = *cullingResults;
			//     v129 = (NativeArray_1_System_UInt32_)*lightCullResult;
			//     v114 = (__m128)v110;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_705(
			//       (ILFixDynamicMethodWrapper_2 *)Patch,
			//       (Object *)this,
			//       (Object *)hgCamera,
			//       (CullingResults *)&v114,
			//       (LightCullResult *)&v129,
			//       directionalLightIndex,
			//       tileSize,
			//       atlasSize,
			//       cascadeCount,
			//       shadowIntensity,
			//       (Object *)unityRendererLists,
			//       (Object *)shadowRendererLists,
			//       (Object *)shadowGrassLists,
			//       shadowRequest,
			//       context,
			//       0LL);
			//   }
			//   else
			//   {
			//     visibleLights = UnityEngine::HyperGryph::LightCullResult::get_visibleLights(
			//                       (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v114,
			//                       lightCullResult,
			//                       0LL);
			//     m_csmScreenSizeMinSquareds = directionalLightIndex;
			//     Patch = &v137;
			//     v137 = *(VisibleLight *)&visibleLights.m_Buffer[148 * directionalLightIndex];
			//     if ( !*shadowRequest )
			//       goto LABEL_90;
			//     (*shadowRequest).fields.directionalLightIndex = directionalLightIndex;
			//     if ( !*shadowRequest )
			//       goto LABEL_90;
			//     (*shadowRequest).fields.directionalShadowMapTileSize = tileSize;
			//     Patch = *shadowRequest;
			//     if ( !*shadowRequest )
			//       goto LABEL_90;
			//     *((Vector2Int *)Patch + 5) = atlasSize;
			//     if ( !*shadowRequest )
			//       goto LABEL_90;
			//     (*shadowRequest).fields.cascadeCount = cascadeCount;
			//     v23 = (_OWORD *)sub_182805160(&v115);
			//     v24 = v23[1];
			//     *(_OWORD *)&v130.m00 = *v23;
			//     v25 = v23[2];
			//     *(_OWORD *)&v130.m01 = v24;
			//     v26 = v23[3];
			//     *(_OWORD *)&v130.m02 = v25;
			//     *(_OWORD *)&v130.m03 = v26;
			//     v27 = (_OWORD *)sub_182805160(&v115);
			//     v28 = v27[1];
			//     *(_OWORD *)&v133.m00 = *v27;
			//     v29 = v27[2];
			//     *(_OWORD *)&v133.m01 = v28;
			//     v30 = v27[3];
			//     *(_OWORD *)&v133.m02 = v29;
			//     *(_OWORD *)&v133.m03 = v30;
			//     sub_182805160(&v115);
			//     LOBYTE(Patch) = this.fields.m_useShadowMapCache;
			//     if ( !*shadowRequest )
			//       goto LABEL_90;
			//     (*shadowRequest).fields.useCache = (char)Patch;
			//     if ( !*shadowRequest )
			//       goto LABEL_90;
			//     (*shadowRequest).fields.directionalShadowStrength = shadowIntensity;
			//     Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//       &v129,
			//       cascadeCount,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
			//     if ( !hgCamera )
			//       goto LABEL_90;
			//     m_envVolumeCameraComponent = hgCamera.fields.m_envVolumeCameraComponent;
			//     light = UnityEngine::Rendering::VisibleLight::get_light(&v137, 0LL);
			//     if ( !m_envVolumeCameraComponent )
			//       goto LABEL_90;
			//     if ( HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
			//            m_envVolumeCameraComponent,
			//            light,
			//            0LL) )
			//     {
			//       v33 = hgCamera.fields.m_envVolumeCameraComponent;
			//       if ( !v33 )
			//         goto LABEL_90;
			//       m_interpolatedPhase = v33.fields.m_interpolatedPhase;
			//       if ( !m_interpolatedPhase )
			//         goto LABEL_90;
			//       v35 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m00;
			//       v36 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m01;
			//       v37 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m02;
			//       v38 = *(_OWORD *)&m_interpolatedPhase.fields.lightConfig.localToWorld.m03;
			//     }
			//     else
			//     {
			//       localToWorldMatrix = UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v115, &v137.hgSharedLightData, 0LL);
			//       v35 = *(_OWORD *)&localToWorldMatrix.m00;
			//       v36 = *(_OWORD *)&localToWorldMatrix.m01;
			//       v37 = *(_OWORD *)&localToWorldMatrix.m02;
			//       v38 = *(_OWORD *)&localToWorldMatrix.m03;
			//     }
			//     m_csmManualOverrideSphere = this.fields.m_csmManualOverrideSphere;
			//     *(_OWORD *)&v125.m00 = v35;
			//     *(_OWORD *)&v125.m01 = v36;
			//     *(_OWORD *)&v125.m02 = v37;
			//     *(_OWORD *)&v125.m03 = v38;
			//     v114 = (__m128)m_csmManualOverrideSphere;
			//     HG::Rendering::Runtime::HGShadowManager::GetManualCsmSphereMatrices(
			//       this,
			//       &v125,
			//       (Vector4 *)&v114,
			//       &v133,
			//       &v130,
			//       0LL);
			//     v41 = *(_OWORD *)&v130.m00;
			//     v42 = *(_OWORD *)&v133.m00;
			//     v43 = *(_OWORD *)&v133.m01;
			//     v44 = *(_OWORD *)&v133.m02;
			//     v45 = *(_OWORD *)&v133.m03;
			//     v125 = v130;
			//     v115 = v133;
			//     v46 = UnityEngine::Matrix4x4::op_Multiply(&v135, &v115, &v125, 0LL);
			//     v47 = *(_OWORD *)&v46.m00;
			//     v48 = *(_OWORD *)&v46.m01;
			//     v49 = *(_OWORD *)&v46.m02;
			//     v50 = *(_OWORD *)&v46.m03;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     *(_OWORD *)&v115.m00 = v47;
			//     *(_OWORD *)&v115.m01 = v48;
			//     *(_OWORD *)&v115.m02 = v49;
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//     *(_OWORD *)&v115.m03 = v50;
			//     UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v115, static_fields.s_tempPlanes, 0LL);
			//     v52 = 0;
			//     v53 = *(_OWORD *)&v130.m01;
			//     v54 = 0.0;
			//     m_Buffer = v129.m_Buffer;
			//     if ( cascadeCount > 0 )
			//     {
			//       v55 = v129.m_Buffer;
			//       v127 = v129.m_Buffer;
			//       while ( 1 )
			//       {
			//         *(_DWORD *)v55 = -1;
			//         m_csmOcclusionDepthSize = 0;
			//         if ( !*shadowRequest )
			//           break;
			//         deviceProjectionYFlipMatrices = (*shadowRequest).fields.deviceProjectionYFlipMatrices;
			//         *(_OWORD *)&v115.m00 = v42;
			//         *(_OWORD *)&v115.m01 = v43;
			//         *(_OWORD *)&v115.m02 = v44;
			//         *(_OWORD *)&v115.m03 = v45;
			//         GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&v135, &v115, 1, 0LL);
			//         if ( !deviceProjectionYFlipMatrices )
			//           break;
			//         v59 = *(_OWORD *)&GPUProjectionMatrix.m01;
			//         *(_OWORD *)&v125.m00 = *(_OWORD *)&GPUProjectionMatrix.m00;
			//         v60 = *(_OWORD *)&GPUProjectionMatrix.m02;
			//         *(_OWORD *)&v125.m01 = v59;
			//         v61 = *(_OWORD *)&GPUProjectionMatrix.m03;
			//         *(_OWORD *)&v125.m02 = v60;
			//         *(_OWORD *)&v125.m03 = v61;
			//         sub_180077420(deviceProjectionYFlipMatrices, v52, &v125);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         v62 = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
			//         s_tempPlanes = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.s_tempPlanes;
			//         if ( !s_tempPlanes )
			//           goto LABEL_24;
			//         if ( s_tempPlanes.max_length.size )
			//         {
			//           v64 = sub_18003EB40(s_tempPlanes, 0LL);
			//           v62 = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
			//           v118 = v64;
			//         }
			//         else
			//         {
			// LABEL_24:
			//           v118 = 0LL;
			//         }
			//         sub_180002C70(v62);
			//         Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//         *(_QWORD *)viewHandle = *((_QWORD *)Patch + 15);
			//         if ( !*(_QWORD *)viewHandle )
			//           break;
			//         camera = hgCamera.fields.camera;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(camera, 0LL);
			//         Patch = hgCamera.fields.camera;
			//         v119.m128_u64[0] = SceneCullingMaskFromCamera;
			//         if ( !Patch )
			//           break;
			//         cullingMask = UnityEngine::Camera::get_cullingMask((Camera *)Patch, 0LL);
			//         Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//         m_csmScreenSizeMinSquareds = *((_QWORD *)Patch + 16);
			//         if ( !m_csmScreenSizeMinSquareds )
			//           break;
			//         if ( (unsigned int)v52 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
			//           goto LABEL_88;
			//         v67 = *(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * v52 + 32);
			//         Patch = (void *)v52;
			//         v68 = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_cascadeObjectFlags.vector[v52];
			//         m_csmScreenSizeMinSquareds = (__int64)this.fields.m_csmScreenSizeMinSquareds;
			//         if ( !m_csmScreenSizeMinSquareds )
			//           break;
			//         if ( (unsigned int)v52 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
			//           goto LABEL_88;
			//         Patch = this.fields.m_csmEnableOcclusionCulling;
			//         if ( !Patch )
			//           break;
			//         if ( (unsigned int)v52 >= *((_DWORD *)Patch + 6) )
			//           goto LABEL_88;
			//         if ( *((_BYTE *)Patch + v52 + 32) )
			//         {
			//           m_csmOcclusionDepthSize = this.fields.m_csmOcclusionDepthSize;
			//           v69 = m_csmOcclusionDepthSize;
			//         }
			//         else
			//         {
			//           v69 = 0;
			//         }
			//         v70 = *(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * v52 + 32);
			//         viewHandle[0] = *(_DWORD *)(*(_QWORD *)viewHandle + 24LL);
			//         v121 = v67 | 0x8000002;
			//         v120 = v68 | 0x8000002;
			//         sub_1802F01E0(v136, 0LL, 64LL);
			//         v123 = 0LL;
			//         v124 = 0;
			//         v71 = (__int64 (__fastcall *)(__int64, _QWORD, _QWORD, unsigned __int64, int32_t, int, int, LODCrossFadeConfig *, int, int, _DWORD, int32_t, int32_t, _BYTE *, __int64 *, __int128 *, _DWORD, int))qword_18D92FA58;
			//         v132 = 0LL;
			//         if ( !qword_18D92FA58 )
			//         {
			//           v71 = (__int64 (__fastcall *)(__int64, _QWORD, _QWORD, unsigned __int64, int32_t, int, int, LODCrossFadeConfig *, int, int, _DWORD, int32_t, int32_t, _BYTE *, __int64 *, __int128 *, _DWORD, int))sub_180017470("UnityEngine.HyperGryph.HGCullingSystem::AddCullViewByPlanes(System.IntPtr,System.Int32,System.Int32,System.UInt64,System.UInt32,System.UInt32,System.UInt32,UnityEngine.HyperGryph.LODCrossFadeConfig&,System.Single,UnityEngine.CameraType,System.UInt32,System.Int32,System.Int32,UnityEngine.Matrix4x4&,UnityEngine.Vector3&,UnityEngine.Vector4&,System.Single,System.Single)");
			//           qword_18D92FA58 = (__int64)v71;
			//         }
			//         v72 = v71(
			//                 v118,
			//                 viewHandle[0],
			//                 0LL,
			//                 v119.m128_u64[0],
			//                 cullingMask,
			//                 v121,
			//                 v120,
			//                 &hgCamera.fields.lodCrossFadeConfig,
			//                 v70,
			//                 32,
			//                 0,
			//                 m_csmOcclusionDepthSize,
			//                 v69,
			//                 v136,
			//                 &v123,
			//                 &v132,
			//                 0,
			//                 1028443341);
			//         v73 = v127;
			//         *(_DWORD *)v127 = v72;
			//         Patch = *shadowRequest;
			//         if ( !*shadowRequest )
			//           break;
			//         Patch = (void *)*((_QWORD *)Patch + 7);
			//         if ( !Patch )
			//           break;
			//         v74 = *(_OWORD *)&v130.m02;
			//         v75 = *(_OWORD *)&v130.m03;
			//         *(_OWORD *)&v115.m02 = *(_OWORD *)&v130.m02;
			//         *(_OWORD *)&v115.m03 = *(_OWORD *)&v130.m03;
			//         *(_OWORD *)&v115.m00 = v41;
			//         *(_OWORD *)&v115.m01 = v53;
			//         sub_180077420(Patch, v52, &v115);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//         *(_OWORD *)&v115.m00 = v41;
			//         *(_OWORD *)&v115.m01 = v53;
			//         *(_OWORD *)&v115.m02 = v74;
			//         *(_OWORD *)&v115.m03 = v75;
			//         *(_OWORD *)&v125.m00 = v42;
			//         *(_OWORD *)&v125.m01 = v43;
			//         *(_OWORD *)&v125.m02 = v44;
			//         *(_OWORD *)&v125.m03 = v45;
			//         ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v135, &v125, &v115, 0LL);
			//         Patch = *shadowRequest;
			//         if ( !*shadowRequest )
			//           break;
			//         Patch = (void *)*((_QWORD *)Patch + 10);
			//         if ( !Patch )
			//           break;
			//         v77 = *(_OWORD *)&ShadowTransform.m01;
			//         *(_OWORD *)&v115.m00 = *(_OWORD *)&ShadowTransform.m00;
			//         v78 = *(_OWORD *)&ShadowTransform.m02;
			//         *(_OWORD *)&v115.m01 = v77;
			//         v79 = *(_OWORD *)&ShadowTransform.m03;
			//         *(_OWORD *)&v115.m02 = v78;
			//         *(_OWORD *)&v115.m03 = v79;
			//         sub_180077420(Patch, v52, &v115);
			//         Patch = *shadowRequest;
			//         v119 = (__m128)_mm_loadu_si128((const __m128i *)&this.fields.m_csmManualOverrideSphere);
			//         *(float *)&v78 = _mm_shuffle_ps(v119, v119, 255).m128_f32[0];
			//         v119.m128_f32[3] = *(float *)&v78 * *(float *)&v78;
			//         if ( !Patch )
			//           break;
			//         Patch = (void *)*((_QWORD *)Patch + 11);
			//         if ( !Patch )
			//           break;
			//         sub_18004D910(Patch, v52, &v119);
			//         if ( !*shadowRequest )
			//           break;
			//         cascadeShadowBiases = (*shadowRequest).fields.cascadeShadowBiases;
			//         m_csmDepthBias = this.fields.m_csmDepthBias;
			//         contexta = this.fields.m_csmShadowSampleMode;
			//         methodb = this.fields.m_csmNormalBias;
			//         *(_OWORD *)&v115.m00 = v42;
			//         *(_OWORD *)&v115.m01 = v43;
			//         *(_OWORD *)&v115.m02 = v44;
			//         *(_OWORD *)&v115.m03 = v45;
			//         ShadowBias = HG::Rendering::Runtime::HGShadowUtils::GetShadowBias(
			//                        &v134,
			//                        &v115,
			//                        (float)tileSize,
			//                        m_csmDepthBias,
			//                        methodb,
			//                        (HGShadowSampleMode__Enum)contexta,
			//                        0LL);
			//         if ( !cascadeShadowBiases )
			//           break;
			//         v119 = *(__m128 *)ShadowBias;
			//         sub_18004D910(cascadeShadowBiases, v52, &v119);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_atlasScales;
			//         if ( !Patch )
			//           break;
			//         sub_18004E290(Patch, v126, cascadeCount - 1LL);
			//         v83 = (__m128)v126[0];
			//         v84 = (__m128)v126[1];
			//         Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_atlasOffsets;
			//         if ( !Patch )
			//           break;
			//         sub_18004E290(Patch, &v131, v52);
			//         v85 = sub_184D038DC(*(_QWORD *)&v131.x, _mm_unpacklo_ps(v83, v84).m128_u64[0]);
			//         Patch = *shadowRequest;
			//         v118 = v85;
			//         if ( !Patch )
			//           break;
			//         Patch = (void *)*((_QWORD *)Patch + 13);
			//         v114.m128_u64[0] = v118;
			//         v114.m128_i32[2] = v83.m128_i32[0];
			//         v114.m128_i32[3] = v84.m128_i32[0];
			//         if ( !Patch )
			//           break;
			//         v119 = v114;
			//         sub_18004D910(Patch, v52, &v119);
			//         Patch = *shadowRequest;
			//         if ( !*shadowRequest )
			//           break;
			//         Patch = (void *)*((_QWORD *)Patch + 3);
			//         if ( !Patch )
			//           break;
			//         if ( (unsigned int)v52 >= *((_DWORD *)Patch + 6) )
			//           goto LABEL_88;
			//         v86 = v52;
			//         v55 = v73 + 4;
			//         ++v52;
			//         v127 = v55;
			//         *((_BYTE *)Patch + v86 + 32) = 1;
			//         if ( v52 >= cascadeCount )
			//           goto LABEL_54;
			//       }
			// LABEL_90:
			//       sub_180B536AC(Patch, m_csmScreenSizeMinSquareds);
			//     }
			// LABEL_54:
			//     UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
			//     v87 = 0;
			//     if ( cascadeCount > 0 )
			//     {
			//       do
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//         Patch = TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList.static_fields;
			//         if ( !unityRendererLists )
			//           goto LABEL_90;
			//         v114 = *(__m128 *)Patch;
			//         sub_1803EF6F4(unityRendererLists, v87, &v114);
			//         *(_OWORD *)&v115.m02 = *(_OWORD *)&v130.m02;
			//         *(_OWORD *)&v115.m03 = *(_OWORD *)&v130.m03;
			//         *(_OWORD *)&v115.m00 = v41;
			//         *(_OWORD *)&v115.m01 = v53;
			//         *(_OWORD *)&v125.m00 = v42;
			//         *(_OWORD *)&v125.m01 = v43;
			//         *(_OWORD *)&v125.m02 = v44;
			//         *(_OWORD *)&v125.m03 = v45;
			//         v88 = UnityEngine::Matrix4x4::op_Multiply(&v135, &v125, &v115, 0LL);
			//         v89 = *(_OWORD *)&v88.m00;
			//         v90 = *(_OWORD *)&v88.m01;
			//         v91 = *(_OWORD *)&v88.m02;
			//         v92 = *(_OWORD *)&v88.m03;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         *(_OWORD *)&v115.m00 = v89;
			//         *(_OWORD *)&v115.m01 = v90;
			//         *(_OWORD *)&v115.m02 = v91;
			//         v93 = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//         *(_OWORD *)&v115.m03 = v92;
			//         UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v115, v93.s_tempPlanes, 0LL);
			//         if ( !UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL) )
			//         {
			//           Patch = hgCamera.fields.camera;
			//           if ( !Patch )
			//             goto LABEL_90;
			//           UnityEngine::Camera::TryGetCullingParameters((Camera *)Patch, &cullingParameters, 0LL);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//           *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m20 = v89;
			//           *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m21 = v90;
			//           *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m22 = v91;
			//           *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m23 = v92;
			//           UnityEngine::Rendering::ScriptableCullingParameters::set_isOrthographic(&cullingParameters, 1, 0LL);
			//           cullingParameters.m_CameraProperties.cameraWorldToClip.m31 = 0.0;
			//           for ( i = 0; i < 6; ++i )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//             Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.s_tempPlanes;
			//             if ( !Patch )
			//               goto LABEL_90;
			//             sub_180037190(Patch, &v131, i);
			//             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//             v114 = (__m128)v131;
			//             UnityEngine::Rendering::ScriptableCullingParameters::SetCullingPlane(
			//               &cullingParameters,
			//               i,
			//               (Plane *)&v114,
			//               0LL);
			//           }
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           v95 = *UnityEngine::Rendering::ScriptableRenderContext::Cull(
			//                    (CullingResults *)&v134,
			//                    &context,
			//                    &cullingParameters,
			//                    0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//           UnityEngine::Rendering::ShaderTagId::ShaderTagId(
			//             &v116,
			//             TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields.s_ShadowCasterStr,
			//             0LL);
			//           v96 = hgCamera.fields.camera;
			//           v114 = (__m128)v95;
			//           UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(
			//             &v138,
			//             v116,
			//             (CullingResults *)&v114,
			//             v96,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//           v138.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllOpaque;
			//           v138.sortingCriteria = 59;
			//           v138.rendererConfiguration = 30720;
			//           v139 = v138;
			//           v114 = *(__m128 *)UnityEngine::Rendering::ScriptableRenderContext::CreateRendererList(
			//                               (RendererList *)&v119,
			//                               &context,
			//                               &v139,
			//                               0LL);
			//           sub_1803EF6F4(unityRendererLists, v87, &v114);
			//         }
			//         v44 = *(_OWORD *)&v133.m02;
			//         ++v87;
			//         v45 = *(_OWORD *)&v133.m03;
			//         v41 = *(_OWORD *)&v130.m00;
			//         v53 = *(_OWORD *)&v130.m01;
			//       }
			//       while ( v87 < cascadeCount );
			//       v54 = 0.0;
			//     }
			//     v97 = 0;
			//     if ( cascadeCount > 0 )
			//     {
			//       Patch = shadowGrassLists;
			//       v98 = 0LL;
			//       while ( 1 )
			//       {
			//         m_csmScreenSizeMinSquareds = 0xFFFFFFFFLL;
			//         if ( *(_DWORD *)&m_Buffer[v98] == -1 )
			//         {
			//           if ( !shadowRendererLists )
			//             goto LABEL_90;
			//           if ( v97 >= shadowRendererLists.max_length.size )
			//             break;
			//           shadowRendererLists.vector[v97] = -1;
			//         }
			//         else
			//         {
			//           viewHandle[0] = *(_DWORD *)&m_Buffer[v98];
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//           Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
			//           m_cascadeRenderFlags = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_cascadeRenderFlags;
			//           if ( !m_cascadeRenderFlags )
			//             goto LABEL_90;
			//           if ( v97 >= m_cascadeRenderFlags.max_length.size )
			//             break;
			//           v100 = m_cascadeRenderFlags.vector[v97];
			//           v101 = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_cascadeRenderFlags.vector[v97];
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           LOWORD(methoda) = 0;
			//           RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                            viewHandle[0],
			//                            (HGRenderFlags__Enum)(v100 | 0x2080100),
			//                            (HGRenderFlags__Enum)(v101 | 0x2080100),
			//                            HGShaderLightMode__Enum_ShadowCaster,
			//                            methoda,
			//                            context.m_Ptr,
			//                            0,
			//                            0,
			//                            0xFFFFFFFF,
			//                            0,
			//                            0,
			//                            0LL);
			//           if ( !shadowRendererLists )
			//             goto LABEL_90;
			//           if ( v97 >= shadowRendererLists.max_length.size )
			//             break;
			//           shadowRendererLists.vector[v97] = RendererList;
			//           Patch = TypeInfo::HG::Rendering::Runtime::HGShadowManager;
			//           m_csmScreenSizeMinSquareds = (__int64)TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_cascadeRenderFlags;
			//           if ( !m_csmScreenSizeMinSquareds )
			//             goto LABEL_90;
			//           if ( v97 >= *(_DWORD *)(m_csmScreenSizeMinSquareds + 24) )
			//             break;
			//           v103 = UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
			//                    *(_DWORD *)&m_Buffer[v98],
			//                    (HGRenderFlags__Enum)(*(_DWORD *)(m_csmScreenSizeMinSquareds + 4LL * (int)v97 + 32) | 0x2080100),
			//                    (HGRenderFlags__Enum)(TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.m_cascadeRenderFlags.vector[v97] | 0x2080100),
			//                    HGShaderLightMode__Enum_ShadowCaster,
			//                    context.m_Ptr,
			//                    0,
			//                    0LL);
			//           Patch = shadowGrassLists;
			//           m_csmScreenSizeMinSquareds = v103;
			//         }
			//         if ( !Patch )
			//           goto LABEL_90;
			//         if ( v97 >= *((_DWORD *)Patch + 6) )
			//           break;
			//         v104 = (int)v97;
			//         v98 += 4LL;
			//         ++v97;
			//         *((_DWORD *)Patch + v104 + 8) = m_csmScreenSizeMinSquareds;
			//         if ( (int)v97 >= cascadeCount )
			//           goto LABEL_80;
			//       }
			// LABEL_88:
			//       sub_180070270(Patch, m_csmScreenSizeMinSquareds);
			//     }
			// LABEL_80:
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&v129,
			//       MethodInfo::Unity::Collections::NativeArray<unsigned int>::Dispose);
			//     zero = UnityEngine::Matrix4x4::get_zero(&v135, 0LL);
			//     v106 = *(_OWORD *)&zero.m00;
			//     v107 = *(_OWORD *)&zero.m01;
			//     v108 = *(_OWORD *)&zero.m03;
			//     *(_OWORD *)&v115.m02 = *(_OWORD *)&zero.m02;
			//     if ( UnityEngine::SystemInfo::UsesReversedZBuffer(0LL) )
			//       v54 = 1.0;
			//     v115.m22 = v54;
			//     if ( cascadeCount <= 4 )
			//     {
			//       v109 = *(_OWORD *)&v115.m02;
			//       while ( *shadowRequest )
			//       {
			//         Patch = (*shadowRequest).fields.worldToShadowMatrices;
			//         if ( !Patch )
			//           break;
			//         *(_OWORD *)&v115.m00 = v106;
			//         *(_OWORD *)&v115.m01 = v107;
			//         *(_OWORD *)&v115.m02 = v109;
			//         *(_OWORD *)&v115.m03 = v108;
			//         sub_180077420(Patch, v15++, &v115);
			//         if ( v15 > 4 )
			//           return;
			//       }
			//       goto LABEL_90;
			//     }
			//   }
			// }
			// 
		}

		private static void SetDirectionalLightShadowData(HGShadowManager.CascadedShadowRequest shadowRequest, int stopRenderCharacterShadowCascade)
		{
			// // Void SetDirectionalLightShadowData(HGShadowManager+CascadedShadowRequest, Int32)
			// void HG::Rendering::Runtime::HGShadowManager::SetDirectionalLightShadowData(
			//         HGShadowManager_CascadedShadowRequest *shadowRequest,
			//         int32_t stopRenderCharacterShadowCascade,
			//         MethodInfo *method)
			// {
			//   int v5; // ebx
			//   __int64 v6; // rdi
			//   int32_t v7; // ebp
			//   __int64 v8; // r14
			//   __int64 v9; // rdx
			//   void *worldToShadowMatrices; // rcx
			//   HGShadowConstantBufferUtils__StaticFields *static_fields; // r15
			//   Matrix4x4 *v12; // rax
			//   float Item; // xmm0_4
			//   __int64 v14; // rax
			//   int v15; // ebp
			//   __int64 v16; // r14
			//   int v17; // r15d
			//   __int64 v18; // r12
			//   HGShadowConstantBufferUtils__StaticFields *v19; // rbx
			//   __int64 v20; // rax
			//   float v21; // xmm0_4
			//   int v22; // ebp
			//   __int64 v23; // r14
			//   int v24; // r15d
			//   __int64 v25; // r12
			//   HGShadowConstantBufferUtils__StaticFields *v26; // rbx
			//   __int64 v27; // rax
			//   HGShadowConstantBufferUtils__StaticFields *v28; // rbx
			//   __int64 v29; // rax
			//   float v30; // xmm0_4
			//   __int64 v31; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   float v33[10]; // [rsp+20h] [rbp-28h]
			// 
			//   if ( !byte_18D919E80 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     byte_18D919E80 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1836, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1836, 0LL);
			//     if ( !Patch )
			// LABEL_23:
			//       sub_180B536AC(worldToShadowMatrices, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			//       (ILFixDynamicMethodWrapper_26 *)Patch,
			//       (Object *)shadowRequest,
			//       stopRenderCharacterShadowCascade,
			//       0LL);
			//   }
			//   else
			//   {
			//     v5 = 0;
			//     v6 = 0LL;
			//     do
			//     {
			//       v7 = 0;
			//       v8 = 0LL;
			//       do
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//         if ( !shadowRequest )
			//           goto LABEL_23;
			//         worldToShadowMatrices = shadowRequest.fields.worldToShadowMatrices;
			//         if ( !worldToShadowMatrices )
			//           goto LABEL_23;
			//         v12 = (Matrix4x4 *)sub_1804440E4(worldToShadowMatrices, v5);
			//         Item = UnityEngine::Matrix4x4::get_Item(v12, v7, 0LL);
			//         v14 = v6 + v8;
			//         ++v7;
			//         ++v8;
			//         *(&static_fields.shadowData._CSMWorldToShadow.FixedElementField + v14) = Item;
			//       }
			//       while ( v7 < 16 );
			//       ++v5;
			//       v6 += 16LL;
			//     }
			//     while ( v5 <= 4 );
			//     v15 = 0;
			//     v16 = 0LL;
			//     do
			//     {
			//       v17 = 0;
			//       v18 = 0LL;
			//       do
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//         worldToShadowMatrices = shadowRequest.fields.cascadeShadowSplitSpheres;
			//         if ( !worldToShadowMatrices )
			//           goto LABEL_23;
			//         v19 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//         v20 = sub_18003EB40(worldToShadowMatrices, v15);
			//         v21 = sub_182637EE0(v20, (unsigned int)v17++);
			//         *(&v19.shadowData._ASMParams2.z + v16 + v18++) = v21;
			//       }
			//       while ( v17 < 4 );
			//       ++v15;
			//       v16 += 4LL;
			//     }
			//     while ( v15 < 4 );
			//     v22 = 0;
			//     v23 = 0LL;
			//     do
			//     {
			//       v24 = 0;
			//       v25 = 0LL;
			//       do
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//         worldToShadowMatrices = shadowRequest.fields.cascadeShadowBiases;
			//         if ( !worldToShadowMatrices )
			//           goto LABEL_23;
			//         v26 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//         v27 = sub_18003EB40(worldToShadowMatrices, v22);
			//         *((float *)&v26._CharacterShadowSectionOffset + v23 + v25) = sub_182637EE0(v27, (unsigned int)v24);
			//         worldToShadowMatrices = shadowRequest.fields.cascadeAtlasParams;
			//         v28 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//         if ( !worldToShadowMatrices )
			//           goto LABEL_23;
			//         v29 = sub_18003EB40(worldToShadowMatrices, v22);
			//         v30 = sub_182637EE0(v29, (unsigned int)v24);
			//         v31 = v23 + v25;
			//         ++v24;
			//         ++v25;
			//         *(&v28[1].shadowData._DirectionalShadowParams.z + v31) = v30;
			//       }
			//       while ( v24 < 4 );
			//       ++v22;
			//       v23 += 4LL;
			//     }
			//     while ( v22 < 4 );
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     v33[0] = 1.0 / (float)shadowRequest.fields.directionalShadowMapSize.m_X;
			//     v33[1] = 1.0 / (float)shadowRequest.fields.directionalShadowMapSize.m_Y;
			//     v33[2] = (float)shadowRequest.fields.directionalShadowMapSize.m_X;
			//     v33[3] = (float)shadowRequest.fields.directionalShadowMapSize.m_Y;
			//     *(_OWORD *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[1].shadowData._CharacterShadowBiases.FixedElementField = *(_OWORD *)v33;
			//   }
			// }
			// 
		}

		internal bool ShouldRenderCSMShadowMap(HGCamera hgCamera, CullingResults cullingResults, int directionalLightIndex, HGSettingParameters settingParams)
		{
			// // Boolean ShouldRenderCSMShadowMap(HGCamera, CullingResults, Int32, HGSettingParameters)
			// bool HG::Rendering::Runtime::HGShadowManager::ShouldRenderCSMShadowMap(
			//         HGShadowManager *this,
			//         HGCamera *hgCamera,
			//         CullingResults *cullingResults,
			//         int32_t directionalLightIndex,
			//         HGSettingParameters *settingParams,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   Camera *camera; // rcx
			//   CullingResults v13; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919E81 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D919E81 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1822, 0LL) )
			//   {
			//     if ( directionalLightIndex == -1 || !this.fields.enableShadowmap )
			//       return 0;
			//     camera = (Camera *)settingParams;
			//     if ( !settingParams )
			//       goto LABEL_18;
			//     if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//             settingParams.fields._csmEnabled_k__BackingField,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
			//       || !this.fields.m_hasDirectionLight
			//       || UnityEngine::HGSharedLightData::get_shadows_Injected(&this.fields.m_directionalLight, 0LL) == LightShadows__Enum_None
			//       || this.fields.m_shadowIntensity < 0.001
			//       || !this.fields.m_enableCSMInVolume )
			//     {
			//       return 0;
			//     }
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       if ( camera )
			//         return UnityEngine::Camera::get_cameraType(camera, 0LL) != CameraType__Enum_Preview;
			//     }
			// LABEL_18:
			//     sub_180B536AC(camera, v10);
			//   }
			//   camera = (Camera *)IFix::WrappersManagerImpl::GetPatch(1822, 0LL);
			//   if ( !camera )
			//     goto LABEL_18;
			//   v13 = *cullingResults;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_701(
			//            (ILFixDynamicMethodWrapper_2 *)camera,
			//            (Object *)this,
			//            (Object *)hgCamera,
			//            &v13,
			//            directionalLightIndex,
			//            (Object *)settingParams,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		private bool CanCleanFullAtlas(HGShadowManager.CascadedShadowRequest shadowRequest)
		{
			// // Boolean CanCleanFullAtlas(HGShadowManager+CascadedShadowRequest)
			// bool HG::Rendering::Runtime::HGShadowManager::CanCleanFullAtlas(
			//         HGShadowManager *this,
			//         HGShadowManager_CascadedShadowRequest *shadowRequest,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1837, 0LL) )
			//   {
			//     if ( shadowRequest )
			//       return !shadowRequest.fields.useCache;
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1837, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//            (ILFixDynamicMethodWrapper_36 *)Patch,
			//            (Object *)this,
			//            (Object *)shadowRequest,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		internal void RenderShadows(HGRenderGraph renderGraph, HGCamera hgCamera, CullingResults cullingResults, LightCullResult lightCullResult, int directionalLightIndex, bool shouldRenderCSMShadowMap, ref ShadowResult shadowResult)
		{
			// // Void RenderShadows(HGRenderGraph, HGCamera, CullingResults, LightCullResult, Int32, Boolean, ShadowResult ByRef)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGShadowManager::RenderShadows(
			//         HGShadowManager *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         CullingResults *cullingResults,
			//         LightCullResult *lightCullResult,
			//         int32_t directionalLightIndex,
			//         bool shouldRenderCSMShadowMap,
			//         ShadowResult *shadowResult,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   __int64 v16; // rdx
			//   int32_t m_csmShadowMapTileSize; // r8d
			//   Vector2Int m_csmShadowMapSize; // rcx
			//   int32_t m_csmCascadeCount; // r9d
			//   float m_shadowIntensity; // xmm2_4
			//   Object__Class *klass; // r10
			//   MonitorData *monitor; // r11
			//   Object__Class *v23; // rbx
			//   HGRenderGraphContext *m_RenderGraphContext; // rax
			//   ScriptableRenderContext v25; // rax
			//   HGShadowManager_CascadedShadowRequest *m_csmShadowRequest; // rbx
			//   int32_t m_stopRenderCharacterCascade; // r14d
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   int32_t i; // ebx
			//   MonitorData *v31; // r14
			//   HGShadowManager_CascadedShadowRequest *v32; // rcx
			//   ShadowSplitData__Array *shadowSplitData; // rcx
			//   Object *v34; // rdx
			//   int v35; // eax
			//   unsigned __int64 v36; // rdx
			//   unsigned __int64 v37; // r8
			//   signed __int64 v38; // rtt
			//   Object *v39; // rdx
			//   MonitorData *m_DefaultResources; // rcx
			//   unsigned __int64 v41; // rdx
			//   unsigned __int64 v42; // r8
			//   char v43; // dl
			//   signed __int64 v44; // rtt
			//   Object *v45; // r15
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   TextureHandle v48; // xmm0
			//   Object *v49; // rsi
			//   bool CanCleanFullAtlas; // al
			//   __int64 v51; // rdx
			//   __int64 v52; // rcx
			//   __int64 v53; // rdx
			//   __int64 m_csmShadowSampleMode; // rcx
			//   Object *v55; // rdx
			//   int v56; // eax
			//   unsigned __int64 v57; // rdx
			//   unsigned __int64 v58; // r8
			//   char v59; // dl
			//   signed __int64 v60; // rtt
			//   Object *v61; // rdx
			//   MonitorData *v62; // rcx
			//   unsigned __int64 v63; // rdx
			//   unsigned __int64 v64; // r8
			//   signed __int64 v65; // rtt
			//   Object *v66; // rsi
			//   __int64 v67; // rdx
			//   HGShadowManager__StaticFields *static_fields; // rcx
			//   unsigned __int64 v69; // rdx
			//   unsigned __int64 v70; // r8
			//   signed __int64 v71; // rtt
			//   Object *v72; // r8
			//   HGShadowManager__StaticFields *v73; // rcx
			//   unsigned __int64 v74; // rdx
			//   unsigned __int64 v75; // r8
			//   signed __int64 v76; // rtt
			//   __int64 v77; // rcx
			//   __int64 v78; // rdx
			//   Object *v79; // rbx
			//   __int64 v80; // rdx
			//   signed __int64 v81; // rcx
			//   TextureHandle v82; // xmm0
			//   Object *v83; // rdx
			//   unsigned __int64 v84; // rdx
			//   unsigned __int64 v85; // r8
			//   signed __int64 v86; // rtt
			//   __int64 v87; // rdx
			//   __int64 v88; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rbx
			//   Object *v90; // [rsp+80h] [rbp-318h] BYREF
			//   LightCullResult v91; // [rsp+90h] [rbp-308h] BYREF
			//   CullingResults v92; // [rsp+A0h] [rbp-2F8h] BYREF
			//   HGRenderGraphBuilder v93; // [rsp+B0h] [rbp-2E8h] BYREF
			//   HGRenderGraphBuilder v94; // [rsp+D0h] [rbp-2C8h] BYREF
			//   Il2CppExceptionWrapper *v95; // [rsp+F0h] [rbp-2A8h] BYREF
			//   CullingResults m_CullingResults; // [rsp+100h] [rbp-298h]
			//   _BYTE v97[192]; // [rsp+110h] [rbp-288h] BYREF
			//   __int128 v98; // [rsp+1D0h] [rbp-1C8h]
			//   ShadowDrawingSettings v99; // [rsp+1E0h] [rbp-1B8h] BYREF
			//   __int128 v100; // [rsp+220h] [rbp-178h]
			//   __int128 v101; // [rsp+230h] [rbp-168h]
			//   __int128 v102; // [rsp+240h] [rbp-158h]
			//   __int128 v103; // [rsp+250h] [rbp-148h]
			//   __int128 v104; // [rsp+260h] [rbp-138h]
			//   __int128 v105; // [rsp+270h] [rbp-128h]
			//   __int128 v106; // [rsp+280h] [rbp-118h]
			//   __int128 v107; // [rsp+290h] [rbp-108h]
			//   __int128 v108; // [rsp+2A0h] [rbp-F8h]
			//   __int128 v109; // [rsp+2B0h] [rbp-E8h]
			//   _OWORD v110[8]; // [rsp+2C0h] [rbp-D8h] BYREF
			//   _OWORD v111[3]; // [rsp+340h] [rbp-58h] BYREF
			//   __int64 v112; // [rsp+370h] [rbp-28h]
			//   unsigned int v113; // [rsp+378h] [rbp-20h]
			// 
			//   if ( !byte_18D919E82 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGShadowManager::ShadowPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGShadowManager::ShadowPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D5EF460);
			//     byte_18D919E82 = 1;
			//   }
			//   v90 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1838, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1838, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v88, v87);
			//     *(LightCullResult *)&v93.m_RenderPass = *lightCullResult;
			//     v92 = *cullingResults;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_707(
			//       Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       &v92,
			//       (LightCullResult *)&v93,
			//       directionalLightIndex,
			//       shouldRenderCSMShadowMap,
			//       shadowResult,
			//       0LL);
			//   }
			//   else
			//   {
			//     v13 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x79u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v15, v14);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v93,
			//       renderGraph,
			//       (String *)"Render Cascaded ShadowMaps",
			//       &v90,
			//       v13,
			//       1,
			//       ProfilingHGPass__Enum_Shadow,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGShadowManager::ShadowPassData>);
			//     v94 = v93;
			//     v92.ptr = 0LL;
			//     v92.m_AllocationInfo = (CullingAllocationInfo *)&v94;
			//     try
			//     {
			//       if ( shouldRenderCSMShadowMap )
			//       {
			//         m_csmShadowMapTileSize = this.fields.m_csmShadowMapTileSize;
			//         m_csmShadowMapSize = this.fields.m_csmShadowMapSize;
			//         m_csmCascadeCount = this.fields.m_csmCascadeCount;
			//         m_shadowIntensity = this.fields.m_shadowIntensity;
			//         if ( !v90 )
			//           sub_1802DC2C8(m_csmShadowMapSize, v16);
			//         klass = v90[7].klass;
			//         monitor = v90[7].monitor;
			//         v23 = v90[8].klass;
			//         m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//         if ( !m_RenderGraphContext )
			//           sub_1802DC2C8(m_csmShadowMapSize, v16);
			//         v25.m_Ptr = m_RenderGraphContext.fields.renderContext.m_Ptr;
			//         v91 = *lightCullResult;
			//         *(CullingResults *)&v93.m_RenderPass = *cullingResults;
			//         HG::Rendering::Runtime::HGShadowManager::CalculateDirectionalShadowParameters(
			//           this,
			//           hgCamera,
			//           (CullingResults *)&v93,
			//           &v91,
			//           directionalLightIndex,
			//           m_csmShadowMapTileSize,
			//           m_csmShadowMapSize,
			//           m_csmCascadeCount,
			//           m_shadowIntensity,
			//           (RendererList__Array *)klass,
			//           (UInt32__Array *)monitor,
			//           (UInt32__Array *)v23,
			//           &this.fields.m_csmShadowRequest,
			//           v25,
			//           0LL);
			//         m_csmShadowRequest = this.fields.m_csmShadowRequest;
			//         m_stopRenderCharacterCascade = this.fields.m_stopRenderCharacterCascade;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         HG::Rendering::Runtime::HGShadowManager::SetDirectionalLightShadowData(
			//           m_csmShadowRequest,
			//           m_stopRenderCharacterCascade,
			//           0LL);
			//         for ( i = 0; i < this.fields.m_csmCascadeCount; ++i )
			//         {
			//           if ( !v90 )
			//             sub_1802DC2C8(v29, v28);
			//           v31 = v90[8].monitor;
			//           sub_1802F01E0(&v99, 0LL, 224LL);
			//           *(CullingResults *)&v93.m_RenderPass = *cullingResults;
			//           UnityEngine::Rendering::ShadowDrawingSettings::ShadowDrawingSettings(
			//             &v99,
			//             (CullingResults *)&v93,
			//             directionalLightIndex,
			//             0LL);
			//           m_CullingResults = v99.m_CullingResults;
			//           *(_OWORD *)v97 = *(_OWORD *)&v99.m_LightIndex;
			//           *(Vector4 *)&v97[16] = v99.m_SplitData.m_CullingSphere;
			//           *(_OWORD *)&v97[32] = *(_OWORD *)&v99.m_SplitData.m_ShadowCascadeBlendCullingFactor;
			//           *(_OWORD *)&v97[48] = v100;
			//           *(_OWORD *)&v97[64] = v101;
			//           *(_OWORD *)&v97[80] = v102;
			//           *(_OWORD *)&v97[96] = v103;
			//           *(_OWORD *)&v97[112] = v104;
			//           *(_OWORD *)&v97[128] = v105;
			//           *(_OWORD *)&v97[144] = v106;
			//           *(_OWORD *)&v97[160] = v107;
			//           *(_OWORD *)&v97[176] = v108;
			//           v98 = v109;
			//           v32 = this.fields.m_csmShadowRequest;
			//           if ( !v32 )
			//             sub_1802DC2C8(0LL, 128LL);
			//           shadowSplitData = v32.fields.shadowSplitData;
			//           if ( !shadowSplitData )
			//             sub_1802DC2C8(0LL, 128LL);
			//           sub_18083694C(shadowSplitData, v110, i);
			//           *(_OWORD *)&v97[8] = v110[0];
			//           *(_OWORD *)&v97[24] = v110[1];
			//           *(_OWORD *)&v97[40] = v110[2];
			//           *(_OWORD *)&v97[56] = v110[3];
			//           *(_OWORD *)&v97[72] = v110[4];
			//           *(_OWORD *)&v97[88] = v110[5];
			//           *(_OWORD *)&v97[104] = v110[6];
			//           *(_OWORD *)&v97[120] = v110[7];
			//           *(_OWORD *)&v97[136] = v111[0];
			//           *(_OWORD *)&v97[152] = v111[1];
			//           *(_OWORD *)&v97[168] = v111[2];
			//           *(_QWORD *)&v97[184] = v112;
			//           *(_QWORD *)&v98 = v113;
			//           BYTE8(v98) = 1;
			//           *(_DWORD *)&v97[4] = i >= this.fields.m_stopRenderCharacterCascade;
			//           if ( !v31 )
			//             sub_1802DC2C8(v111, &v97[136]);
			//           v99.m_CullingResults = m_CullingResults;
			//           *(_OWORD *)&v99.m_LightIndex = *(_OWORD *)v97;
			//           v99.m_SplitData.m_CullingSphere = *(Vector4 *)&v97[16];
			//           *(_OWORD *)&v99.m_SplitData.m_ShadowCascadeBlendCullingFactor = *(_OWORD *)&v97[32];
			//           v100 = *(_OWORD *)&v97[48];
			//           v101 = *(_OWORD *)&v97[64];
			//           v102 = *(_OWORD *)&v97[80];
			//           v103 = *(_OWORD *)&v97[96];
			//           v104 = *(_OWORD *)&v97[112];
			//           v105 = *(_OWORD *)&v97[128];
			//           v106 = *(_OWORD *)&v97[144];
			//           v107 = *(_OWORD *)&v97[160];
			//           v108 = *(_OWORD *)&v97[176];
			//           v109 = v98;
			//           sub_180836A64(v31, i, &v99);
			//         }
			//         v34 = v90;
			//         if ( !v90 )
			//           sub_1802DC2C8(v29, 0LL);
			//         v90[1].klass = (Object__Class *)hgCamera;
			//         v35 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v36 = ((unsigned __int64)&v34[1] >> 12) & 0x1FFFFF;
			//           v37 = v36 >> 6;
			//           v34 = (Object *)(v36 & 0x3F);
			//           _m_prefetchw(&qword_18D6405E0[v37 + 36190]);
			//           do
			//             v38 = qword_18D6405E0[v37 + 36190];
			//           while ( v38 != _InterlockedCompareExchange64(&qword_18D6405E0[v37 + 36190], v38 | (1LL << (char)v34), v38) );
			//           v35 = dword_18D8E43F8;
			//         }
			//         if ( !v90 )
			//           sub_1802DC2C8(0LL, v34);
			//         *(Object *)((char *)v90 + 24) = *(Object *)cullingResults;
			//         v39 = v90;
			//         m_DefaultResources = (MonitorData *)renderGraph.fields.m_DefaultResources;
			//         if ( !v90 )
			//           sub_1802DC2C8(m_DefaultResources, 0LL);
			//         v90[2].monitor = m_DefaultResources;
			//         if ( v35 )
			//         {
			//           v41 = ((unsigned __int64)&v39[2].monitor >> 12) & 0x1FFFFF;
			//           v42 = v41 >> 6;
			//           v43 = v41 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v42 + 36190]);
			//           do
			//             v44 = qword_18D6405E0[v42 + 36190];
			//           while ( v44 != _InterlockedCompareExchange64(&qword_18D6405E0[v42 + 36190], v44 | (1LL << v43), v44) );
			//         }
			//         v45 = v90;
			//         v48 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                  (TextureHandle *)&v93,
			//                  renderGraph,
			//                  this.fields.m_csmShadowMapAtlas,
			//                  0LL);
			//         if ( !v45 )
			//           sub_1802DC2C8(v47, v46);
			//         *(TextureHandle *)&v45[4].monitor = v48;
			//         v49 = v90;
			//         CanCleanFullAtlas = HG::Rendering::Runtime::HGShadowManager::CanCleanFullAtlas(
			//                               this,
			//                               this.fields.m_csmShadowRequest,
			//                               0LL);
			//         if ( !v49 )
			//           sub_1802DC2C8(v52, v51);
			//         BYTE5(v49[9].monitor) = CanCleanFullAtlas;
			//         if ( !v90 )
			//           sub_1802DC2C8(0LL, v51);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&v93,
			//           &v94,
			//           (TextureHandle *)&v90[4].monitor,
			//           DepthAccess__Enum_Write,
			//           (RenderBufferLoadAction__Enum)(BYTE5(v90[9].monitor) != 0),
			//           RenderBufferStoreAction__Enum_Store,
			//           1.0,
			//           0,
			//           0,
			//           0LL);
			//         m_csmShadowSampleMode = (unsigned int)this.fields.m_csmShadowSampleMode;
			//         if ( !v90 )
			//           sub_1802DC2C8(m_csmShadowSampleMode, v53);
			//         LODWORD(v90[3].klass) = m_csmShadowSampleMode;
			//         v55 = v90;
			//         if ( !v90 )
			//           sub_1802DC2C8(m_csmShadowSampleMode, 0LL);
			//         v90[4].klass = (Object__Class *)this.fields.m_csmShadowRamp;
			//         v56 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v57 = ((unsigned __int64)&v55[4] >> 12) & 0x1FFFFF;
			//           v58 = v57 >> 6;
			//           v59 = v57 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v58 + 36190]);
			//           do
			//             v60 = qword_18D6405E0[v58 + 36190];
			//           while ( v60 != _InterlockedCompareExchange64(&qword_18D6405E0[v58 + 36190], v60 | (1LL << v59), v60) );
			//           v56 = dword_18D8E43F8;
			//         }
			//         v61 = v90;
			//         v62 = (MonitorData *)this.fields.m_csmShadowRequest;
			//         if ( !v90 )
			//           sub_1802DC2C8(v62, 0LL);
			//         v90[3].monitor = v62;
			//         if ( v56 )
			//         {
			//           v63 = ((unsigned __int64)&v61[3].monitor >> 12) & 0x1FFFFF;
			//           v64 = v63 >> 6;
			//           v61 = (Object *)(v63 & 0x3F);
			//           _m_prefetchw(&qword_18D6405E0[v64 + 36190]);
			//           do
			//           {
			//             v62 = (MonitorData *)(qword_18D6405E0[v64 + 36190] | (1LL << (char)v61));
			//             v65 = qword_18D6405E0[v64 + 36190];
			//           }
			//           while ( v65 != _InterlockedCompareExchange64(&qword_18D6405E0[v64 + 36190], (signed __int64)v62, v65) );
			//         }
			//         if ( !v90 )
			//           sub_1802DC2C8(v62, v61);
			//         LOBYTE(v90[5].monitor) = 1;
			//         v66 = v90;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//         if ( !v66 )
			//           sub_1802DC2C8(static_fields, v67);
			//         v66[6].klass = (Object__Class *)static_fields.s_blitShadowMaterial;
			//         v69 = (unsigned int)dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v70 = (((unsigned __int64)&v66[6] >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v70 + 36190]);
			//           do
			//             v71 = qword_18D6405E0[v70 + 36190];
			//           while ( v71 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v70 + 36190],
			//                            v71 | (1LL << (((unsigned __int64)&v66[6] >> 12) & 0x3F)),
			//                            v71) );
			//           v69 = (unsigned int)dword_18D8E43F8;
			//         }
			//         v72 = v90;
			//         v73 = TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields;
			//         if ( !v90 )
			//           sub_1802DC2C8(v73, v69);
			//         v90[6].monitor = (MonitorData *)v73.s_clearShadowMaterial;
			//         if ( (_DWORD)v69 )
			//         {
			//           v74 = ((unsigned __int64)&v72[6].monitor >> 12) & 0x1FFFFF;
			//           v75 = v74 >> 6;
			//           v69 = v74 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v75 + 36190]);
			//           do
			//             v76 = qword_18D6405E0[v75 + 36190];
			//           while ( v76 != _InterlockedCompareExchange64(&qword_18D6405E0[v75 + 36190], v76 | (1LL << v69), v76) );
			//         }
			//         v77 = (unsigned int)this.fields.m_stopRenderCharacterCascade;
			//         if ( !v90 )
			//           sub_1802DC2C8(v77, v69);
			//         LODWORD(v90[9].monitor) = v77;
			//         if ( !v90 )
			//           sub_1802DC2C8(v77, v69);
			//         *(float *)&v90[9].klass = this.fields.m_csmHardwareDepthBias;
			//         if ( !v90 )
			//           sub_1802DC2C8(v77, v69);
			//         HIDWORD(v90[9].klass) = LODWORD(this.fields.m_csmHardwareNormalBias);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v94,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.s_csmShadowMapRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGShadowManager::ShadowPassData>);
			//       }
			//       else
			//       {
			//         v79 = v90;
			//         v82 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                  (TextureHandle *)&v93,
			//                  renderGraph,
			//                  &this.fields.m_csmShadowMapTextureDesc,
			//                  0LL);
			//         if ( !v79 )
			//           sub_1802DC2C8(v81, v80);
			//         *(TextureHandle *)&v79[4].monitor = v82;
			//         LOBYTE(v81) = this.fields.m_enableCSMInVolume;
			//         if ( !v90 )
			//           sub_1802DC2C8(v81, v80);
			//         BYTE4(v90[9].monitor) = v81;
			//         v83 = v90;
			//         if ( !v90 )
			//           sub_1802DC2C8(v81, 0LL);
			//         v90[2].monitor = (MonitorData *)renderGraph.fields.m_DefaultResources;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v84 = ((unsigned __int64)&v83[2].monitor >> 12) & 0x1FFFFF;
			//           v85 = v84 >> 6;
			//           v83 = (Object *)(v84 & 0x3F);
			//           _m_prefetchw(&qword_18D6405E0[v85 + 36190]);
			//           do
			//           {
			//             v81 = qword_18D6405E0[v85 + 36190] | (1LL << (char)v83);
			//             v86 = qword_18D6405E0[v85 + 36190];
			//           }
			//           while ( v86 != _InterlockedCompareExchange64(&qword_18D6405E0[v85 + 36190], v81, v86) );
			//         }
			//         if ( !v90 )
			//           sub_1802DC2C8(v81, v83);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//           (TextureHandle *)&v93,
			//           &v94,
			//           (TextureHandle *)&v90[4].monitor,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v94, 0, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v94,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGShadowManager.static_fields.s_disableDirectionalShadowRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGShadowManager::ShadowPassData>);
			//       }
			//       shadowResult.directionalShadowActive = 1;
			//       if ( !v90 )
			//         sub_1802DC2C8(0LL, v78);
			//       shadowResult.directionalShadowResult = *(TextureHandle *)((char *)v90 + 72);
			//     }
			//     catch ( Il2CppExceptionWrapper *v95 )
			//     {
			//       v92.ptr = v95.ex;
			//     }
			//     sub_180222690(&v92);
			//   }
			// }
			// 
		}

		private const int k_MaxCharacterShadowmapCapacity = 15;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static int m_CharacterShadowmapResolution;

		private Vector4[] m_CharacterShadowBiases;

		private Matrix4x4[] m_CharacterShadowMatrices;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static Matrix4x4[] m_CharacterWorldToLightMatrices;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static Matrix4x4[] m_CharacterProjectionMatrices;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static Vector4[] m_CharacterShadowLightDirs;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static Vector4[] m_CharacterShadowAtlasParams;

		private HGShadowSampleMode m_CharacterShadowSampleMode;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		private static float m_CharacterDepthBias;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x2C")]
		private static float m_CharacterNormalBias;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		private static float m_CharacterHardwareDepthBias;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x34")]
		private static float m_CharacterHardwareNormalBias;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		private static Vector2Int m_CharacterShadowmapSize;

		private TextureDesc m_characterShadowmapsDesc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		private static int m_CharacterShadowCount;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x44")]
		private static Vector2Int m_AtlasTileCount;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
		private static readonly RenderFunc<HGShadowManager.CharacterShadowPassData> s_disableCharacterShadowRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
		private static readonly RenderFunc<HGShadowManager.CharacterShadowPassData> s_renderCharacterShadowmapRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
		private static readonly RenderFunc<HGShadowManager.CharacterShadowPassData> s_renderCharacterShadowmapSetDataFunc;

		public const int k_cascadedShadowCascadeCount = 4;

		public const int k_maxShadowMapCacheHistoryFrame = 32;

		public const int k_maxPunctualLightShadowmapCount = 24;

		public const int k_cascadedShadowViewBaseIndex = 0;

		public const int k_punctualShadowViewBaseIndex = 100;

		private bool m_hasDirectionLight;

		private HGSharedLightData m_directionalLight;

		public bool enableShadowmap;

		public bool enableCharacterShadowmap;

		private int m_csmCascadeCount;

		private Vector2Int m_csmShadowMapSize;

		private int m_csmShadowMapTileSize;

		private float m_csmShadowSoftness;

		private HGShadowManager.CSMRenderMode m_csmRenderMode;

		private Vector4 m_csmManualOverrideSphere;

		private float m_csmMaxDistance;

		private float m_csmNearPlaneOffset;

		private float[] m_csmShadowSplits;

		private float[] m_csmShadowSplitPercentage;

		private int[] m_csmCachedFrames;

		private float[] m_csmScreenSizeMinSquareds;

		private bool[] m_csmEnableOcclusionCulling;

		private int m_csmOcclusionDepthSize;

		private TextureDesc m_csmShadowMapTextureDesc;

		private RTHandle m_csmShadowMapAtlas;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x68")]
		private static Material s_clearShadowMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
		private static Material s_blitShadowMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x78")]
		private static Plane[] s_tempPlanes;

		private HGShadowManager.CascadedShadowRequest m_csmShadowRequest;

		internal HGPunctualLightShadowManagerV2 m_punctualLightShadowManagerV2;

		private bool m_useShadowMapCache;

		private float m_csmDepthBias;

		private float m_csmNormalBias;

		private float m_csmHardwareDepthBias;

		private float m_csmHardwareNormalBias;

		private float m_shadowIntensity;

		private float m_simulatedShadowAttenuationInVolume;

		private float m_simulatedShadowBlendValue;

		private bool m_enableCSMInVolume;

		private int m_stopRenderCharacterCascade;

		private HGShadowSampleMode m_csmShadowSampleMode;

		private Texture2D m_csmShadowRamp;

		private HGShadowManager.CascadedShadowRequest m_cachedCascadedShadowRequest;

		private bool[] m_updateCSMShadowMap;

		private HGCamera m_cachedRenderedCamera;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x80")]
		private static readonly HGObjectFlags[] m_cascadeObjectFlags;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x88")]
		private static readonly HGRenderFlags[] m_cascadeRenderFlags;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x90")]
		private static readonly Vector2[] m_atlasScales;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x98")]
		private static readonly Vector2[] m_atlasOffsets;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA0")]
		private static readonly RenderFunc<HGShadowManager.ShadowPassData> s_csmShadowMapRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xA8")]
		private static readonly RenderFunc<HGShadowManager.ShadowPassData> s_disableDirectionalShadowRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB0")]
		private static RendererList[] s_unityRendererLists;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xB8")]
		private static uint[] s_shadowRendererLists;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC0")]
		private static uint[] s_shadowGrassLists;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0xC8")]
		private static IntPtr[] s_shadowDrawingSettings;

		private class CharacterShadowPassData
		{
			public CharacterShadowPassData()
			{
			}

			public VisibleLight shadowLight;

			public int characterShadowCount;

			public int characterIndex;

			public int characterCount;

			public HGShadowSampleMode characterShadowSampleMode;

			public Rect renderRegion;

			public float hardwareDepthBias;

			public float hardwareNormalBias;

			public RendererListHandle[] characterShadowRendererLists;

			public uint[] characterShadowECSRendererLists;

			public TextureHandle characterShadowmap;
		}

		private class CascadedShadowRequest
		{
			public CascadedShadowRequest()
			{
			}

			public void CopyTo(HGShadowManager.CascadedShadowRequest target, int cascadeIndex)
			{
				// // Void CopyTo(HGShadowManager+CascadedShadowRequest, Int32)
				// void HG::Rendering::Runtime::HGShadowManager::CascadedShadowRequest::CopyTo(
				//         HGShadowManager_CascadedShadowRequest *this,
				//         HGShadowManager_CascadedShadowRequest *target,
				//         int32_t cascadeIndex,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rbx
				//   __int64 v7; // rdx
				//   void *viewMatrices; // rcx
				//   Matrix4x4__Array *v9; // r14
				//   Matrix4x4__Array *deviceProjectionYFlipMatrices; // r14
				//   ShadowSplitData__Array *shadowSplitData; // r14
				//   Matrix4x4__Array *worldToShadowMatrices; // r14
				//   Vector4__Array *cascadeShadowSplitSpheres; // r14
				//   Vector4__Array *cascadeShadowBiases; // r14
				//   Vector4__Array *cascadeAtlasParams; // rdi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int128 v17; // [rsp+30h] [rbp-D8h] BYREF
				//   __int128 v18; // [rsp+48h] [rbp-C0h] BYREF
				//   __int128 v19; // [rsp+58h] [rbp-B0h]
				//   __int128 v20; // [rsp+68h] [rbp-A0h]
				//   __int128 v21; // [rsp+78h] [rbp-90h]
				//   __int128 v22; // [rsp+88h] [rbp-80h] BYREF
				//   __int128 v23; // [rsp+98h] [rbp-70h]
				//   __int128 v24; // [rsp+A8h] [rbp-60h]
				//   __int128 v25; // [rsp+B8h] [rbp-50h]
				//   _OWORD v26[11]; // [rsp+C8h] [rbp-40h] BYREF
				//   __int64 v27; // [rsp+178h] [rbp+70h]
				//   int v28; // [rsp+180h] [rbp+78h]
				//   _OWORD v29[11]; // [rsp+188h] [rbp+80h] BYREF
				//   __int64 v30; // [rsp+238h] [rbp+130h]
				//   int v31; // [rsp+240h] [rbp+138h]
				// 
				//   v5 = cascadeIndex;
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1835, 0LL) )
				//   {
				//     if ( target )
				//     {
				//       viewMatrices = this.fields.viewMatrices;
				//       v9 = target.fields.viewMatrices;
				//       if ( viewMatrices )
				//       {
				//         sub_18005A9F0(viewMatrices, &v18, v5);
				//         if ( v9 )
				//         {
				//           v22 = v18;
				//           v23 = v19;
				//           v24 = v20;
				//           v25 = v21;
				//           sub_180077420(v9, v5, &v22);
				//           viewMatrices = this.fields.deviceProjectionYFlipMatrices;
				//           deviceProjectionYFlipMatrices = target.fields.deviceProjectionYFlipMatrices;
				//           if ( viewMatrices )
				//           {
				//             sub_18005A9F0(viewMatrices, &v22, v5);
				//             if ( deviceProjectionYFlipMatrices )
				//             {
				//               v18 = v22;
				//               v19 = v23;
				//               v20 = v24;
				//               v21 = v25;
				//               sub_180077420(deviceProjectionYFlipMatrices, v5, &v18);
				//               viewMatrices = this.fields.shadowSplitData;
				//               shadowSplitData = target.fields.shadowSplitData;
				//               if ( viewMatrices )
				//               {
				//                 sub_18083694C(viewMatrices, v26, v5);
				//                 if ( shadowSplitData )
				//                 {
				//                   v29[0] = v26[0];
				//                   v29[1] = v26[1];
				//                   v29[2] = v26[2];
				//                   v29[3] = v26[3];
				//                   v29[4] = v26[4];
				//                   v29[5] = v26[5];
				//                   v29[6] = v26[6];
				//                   v29[7] = v26[7];
				//                   v29[8] = v26[8];
				//                   v29[9] = v26[9];
				//                   v29[10] = v26[10];
				//                   v30 = v27;
				//                   v31 = v28;
				//                   sub_180836C8C(shadowSplitData, v5, v29);
				//                   viewMatrices = this.fields.worldToShadowMatrices;
				//                   worldToShadowMatrices = target.fields.worldToShadowMatrices;
				//                   if ( viewMatrices )
				//                   {
				//                     sub_18005A9F0(viewMatrices, &v22, v5);
				//                     if ( worldToShadowMatrices )
				//                     {
				//                       v18 = v22;
				//                       v19 = v23;
				//                       v20 = v24;
				//                       v21 = v25;
				//                       sub_180077420(worldToShadowMatrices, v5, &v18);
				//                       viewMatrices = this.fields.cascadeShadowSplitSpheres;
				//                       cascadeShadowSplitSpheres = target.fields.cascadeShadowSplitSpheres;
				//                       if ( viewMatrices )
				//                       {
				//                         sub_180037190(viewMatrices, (char *)&v17 + 8, v5);
				//                         if ( cascadeShadowSplitSpheres )
				//                         {
				//                           sub_18004D910(cascadeShadowSplitSpheres, v5, (char *)&v17 + 8);
				//                           viewMatrices = this.fields.cascadeShadowBiases;
				//                           cascadeShadowBiases = target.fields.cascadeShadowBiases;
				//                           if ( viewMatrices )
				//                           {
				//                             sub_180037190(viewMatrices, (char *)&v17 + 8, v5);
				//                             if ( cascadeShadowBiases )
				//                             {
				//                               sub_18004D910(cascadeShadowBiases, v5, (char *)&v17 + 8);
				//                               viewMatrices = this.fields.cascadeAtlasParams;
				//                               cascadeAtlasParams = target.fields.cascadeAtlasParams;
				//                               if ( viewMatrices )
				//                               {
				//                                 sub_180037190(viewMatrices, (char *)&v17 + 8, v5);
				//                                 if ( cascadeAtlasParams )
				//                                 {
				//                                   sub_18004D910(cascadeAtlasParams, v5, (char *)&v17 + 8);
				//                                   return;
				//                                 }
				//                               }
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
				// LABEL_19:
				//     sub_180B536AC(viewMatrices, v7);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1835, 0LL);
				//   if ( !Patch )
				//     goto LABEL_19;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_34(
				//     (ILFixDynamicMethodWrapper_16 *)Patch,
				//     (Object *)this,
				//     (Object *)target,
				//     v5,
				//     0LL);
				// }
				// 
			}

			public bool useCache;

			public bool[] updateCache;

			public int cascadeCount;

			public int directionalLightIndex;

			public Vector2Int directionalShadowMapSize;

			public int directionalShadowMapTileSize;

			public float directionalShadowStrength;

			public Matrix4x4[] viewMatrices;

			public Matrix4x4[] deviceProjectionYFlipMatrices;

			public ShadowSplitData[] shadowSplitData;

			public Matrix4x4[] worldToShadowMatrices;

			public Vector4[] cascadeShadowSplitSpheres;

			public Vector4[] cascadeShadowBiases;

			public Vector4[] cascadeAtlasParams;
		}

		private class ShadowPassData
		{
			public ShadowPassData()
			{
			}

			public HGCamera hgCamera;

			public CullingResults cullingResults;

			public HGRenderGraphDefaultResources defaultResources;

			public HGShadowSampleMode directionalShadowSampleMode;

			public HGShadowManager.CascadedShadowRequest cascadedShadowRequest;

			public Texture2D csmShadowRamp;

			public TextureHandle directionalShadowAtlas;

			public bool cullNonRealtimeCastersValue;

			public Material blitShadowMaterial;

			public Material clearShadowMaterial;

			public readonly RendererList[] unityRendererLists;

			public readonly uint[] shadowRendererLists;

			public readonly uint[] shadowGrassLists;

			public readonly ShadowDrawingSettings[] shadowDrawingSettings;

			public float hardwareDepthBias;

			public float hardwareNormalBias;

			public int stopRenderCharacterShadowCascade;

			public bool enableLocalShadow;

			public bool canCleanFullAtlas;
		}

		public enum CSMRenderMode
		{
			Default,
			ManualOverride
		}
	}
}
