using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class TransparentPassConstructor : IPassConstructor
	{
		internal TransparentPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // TransparentPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::TransparentPassConstructor::TransparentPassConstructor(
			//         TransparentPassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   Shader *klass; // rbx
			// 
			//   if ( !byte_18D8EDA81 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     byte_18D8EDA81 = 1;
			//   }
			//   if ( !resources.defaultResources
			//     || (this = (TransparentPassConstructor *)resources.defaultResources.fields.shaders) == 0LL )
			//   {
			//     sub_180B536AC(this, materialCollector);
			//   }
			//   klass = (Shader *)this[48].klass;
			//   if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, materialCollector);
			//   HG::Rendering::Runtime::VFXPPScanLinePass::PrepareScanLineMaterial(klass, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::TransparentPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         TransparentPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2647, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2647, 0LL);
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
			// void HG::Rendering::Runtime::TransparentPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         TransparentPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2648, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2648, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref TransparentPassConstructor.PassInput input, ref TransparentPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(TransparentPassConstructor+PassInput ByRef, TransparentPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::TransparentPassConstructor::ConstructPass(
			//         TransparentPassConstructor *this,
			//         TransparentPassConstructor_PassInput *input,
			//         TransparentPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   TextureHandle v13; // xmm8
			//   TextureDesc *TextureDescRef; // rax
			//   TransparentPassConstructor_PassOutput *Texture; // rax
			//   HGCamera *v16; // r15
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   TextureHandle sceneColor; // xmm0
			//   __int64 v20; // rdx
			//   __int64 gBufferProfileConfig; // rcx
			//   int32_t i; // edi
			//   Object__Class *klass; // r14
			//   BitArray128 *GBufferAttachment; // rax
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   Object__Class *v29; // r14
			//   TextureHandle *v30; // rax
			//   Object__Class *v31; // rcx
			//   TextureHandle *v32; // rax
			//   TextureHandle *p_sceneMV; // r8
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   __int128 v36; // xmm6
			//   __int128 v37; // xmm7
			//   Object *waterRenderingPass; // r12
			//   float screenCullingRatio; // xmm9_4
			//   float screenCullingRatioDistance; // xmm10_4
			//   Object *v41; // rdi
			//   BasicTransformConstants *p_basicTransformConstants; // r14
			//   BitArray128 cullingResults; // xmm11
			//   TextureHandle sceneDepthWithWater; // xmm7
			//   TextureHandle sceneDepthCopied; // xmm6
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   unsigned __int64 v48; // r8
			//   signed __int64 v49; // rtt
			//   unsigned __int64 v50; // r8
			//   signed __int64 v51; // rtt
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rax
			//   HGGraphicsFeatureSwitch *forwardTransparent; // rdx
			//   bool m_defaultValue; // bl
			//   HGGraphicsFeatureSwitch *forwardDecal; // rdx
			//   HGGraphicsFeatureSwitch *vfxDecal; // rcx
			//   Object *v57; // rbx
			//   RendererListDesc *v58; // rax
			//   RendererListHandle v59; // rax
			//   ILFixDynamicMethodWrapper_2 *v60; // rax
			//   __int64 v61; // rdx
			//   __int64 v62; // rcx
			//   RendererListHandle v63; // rdx
			//   RendererListHandle v64; // rcx
			//   ShaderTagId__Array *monitor; // rbx
			//   RendererListDesc *v66; // rax
			//   RendererListHandle InvalidHandle; // rax
			//   RendererListHandle v68; // rdx
			//   RendererListHandle v69; // rcx
			//   uint32_t cullingViewHandle; // r13d
			//   HGRenderGraphContext *m_RenderGraphContext; // rbx
			//   void *m_Ptr; // rbx
			//   __int64 (__fastcall *v73)(_QWORD, __int64, void *, _QWORD); // rax
			//   int v74; // eax
			//   uint32_t v75; // r13d
			//   HGRenderGraphContext *v76; // rbx
			//   uint32_t RendererList; // eax
			//   __int64 v78; // rcx
			//   Camera *v79; // rbx
			//   __int64 (__fastcall *v80)(Camera *); // rax
			//   LayerMask v81; // ebx
			//   __int64 v82; // rdx
			//   LayerMask v83; // ebx
			//   Object_1 *v84; // rcx
			//   __int64 v85; // rdx
			//   __int64 v86; // rcx
			//   int32_t InstanceID; // r15d
			//   HGRenderGraphContext *v88; // rsi
			//   RendererListDesc *v89; // rax
			//   __int64 v90; // r8
			//   __int64 v91; // rcx
			//   MonitorData **p_monitor; // rax
			//   RendererListDesc *v93; // rcx
			//   ILFixDynamicMethodWrapper_2 *v94; // rax
			//   __int64 v95; // rdx
			//   __int64 v96; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v98; // rdx
			//   __int64 v99; // rcx
			//   __int64 v100; // rax
			//   __int64 v101; // rax
			//   HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-1308h]
			//   bool v103; // [rsp+C0h] [rbp-1268h]
			//   bool lowResRendering; // [rsp+C1h] [rbp-1267h]
			//   bool transparentVRS; // [rsp+C2h] [rbp-1266h]
			//   bool characterOutlineEnabled; // [rsp+C3h] [rbp-1265h]
			//   bool v107; // [rsp+C4h] [rbp-1264h]
			//   FrameSettings frameSettings_k__BackingField; // [rsp+D0h] [rbp-1258h] BYREF
			//   uint32_t screenCullingLayerMask; // [rsp+F0h] [rbp-1238h]
			//   unsigned int bakedLightConfig; // [rsp+F4h] [rbp-1234h]
			//   Object *v111; // [rsp+F8h] [rbp-1230h] BYREF
			//   TextureHandle v112; // [rsp+100h] [rbp-1228h] BYREF
			//   int32_t transparentVRRy; // [rsp+110h] [rbp-1218h]
			//   int32_t transparentVRRx; // [rsp+114h] [rbp-1214h]
			//   uint32_t forwardTransparentECSRendererList; // [rsp+118h] [rbp-1210h]
			//   Object *hgrp; // [rsp+120h] [rbp-1208h]
			//   TextureHandle v117; // [rsp+130h] [rbp-11F8h] BYREF
			//   RendererListHandle inputa; // [rsp+140h] [rbp-11E8h] BYREF
			//   HGRenderGraphBuilder v119; // [rsp+148h] [rbp-11E0h] BYREF
			//   HGRenderGraphBuilder v120; // [rsp+170h] [rbp-11B8h] BYREF
			//   HGRenderGraphBuilder v121; // [rsp+190h] [rbp-1198h] BYREF
			//   ShaderVariablesGlobal *p_shaderVariablesGlobal; // [rsp+1B0h] [rbp-1178h]
			//   _QWORD v123[2]; // [rsp+1B8h] [rbp-1170h] BYREF
			//   Il2CppExceptionWrapper *v124; // [rsp+1C8h] [rbp-1160h] BYREF
			//   TextureDesc v125; // [rsp+1D0h] [rbp-1158h] BYREF
			//   TextureDesc v126; // [rsp+230h] [rbp-10F8h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v127; // [rsp+290h] [rbp-1098h] BYREF
			//   RendererListDesc desc; // [rsp+300h] [rbp-1028h] BYREF
			//   RendererListDesc v129[16]; // [rsp+3E0h] [rbp-F48h] BYREF
			// 
			//   if ( !byte_18D91955F )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
			//     sub_18003C530(&off_18D4FD860);
			//     byte_18D91955F = 1;
			//   }
			//   v111 = 0LL;
			//   sub_1802F01E0(&v125, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2649, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2649, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v99, v98);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_972(
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
			//             (Int32Enum__Enum)0x8Du,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v120,
			//       renderGraph,
			//       (String *)"Forward Transparent",
			//       &v111,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentPassData>);
			//     v119 = v120;
			//     v123[0] = 0LL;
			//     v123[1] = &v119;
			//     try
			//     {
			//       v13 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                (TextureHandle *)&frameSettings_k__BackingField,
			//                &v119,
			//                &input.sceneColor,
			//                0LL);
			//       if ( input.lowResRendering )
			//       {
			//         v125 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDesc(
			//                   &v126,
			//                   renderGraph,
			//                   &input.sceneColor,
			//                   0LL);
			//         v16 = camera;
			//         if ( !camera )
			//           sub_1802DC2C8(v18, v17);
			//         v125.width = camera.fields._sceneRTSize_k__BackingField.m_X / 2;
			//         v125.height = (int)HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField) / 2;
			//         v125.colorFormat = 48;
			//         Texture = (TransparentPassConstructor_PassOutput *)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                              (TextureHandle *)&frameSettings_k__BackingField,
			//                                                              renderGraph,
			//                                                              &v125,
			//                                                              0LL);
			//       }
			//       else
			//       {
			//         TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                            renderGraph,
			//                            &input.sceneColor,
			//                            0LL);
			//         Texture = (TransparentPassConstructor_PassOutput *)HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                              (TextureHandle *)&frameSettings_k__BackingField,
			//                                                              renderGraph,
			//                                                              TextureDescRef,
			//                                                              0LL);
			//         v16 = camera;
			//       }
			//       sceneColor = Texture.sceneColor;
			//       *output = *Texture;
			//       v112 = sceneColor;
			//       frameSettings_k__BackingField.bitDatas = (BitArray128)_mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//       if ( input.lowResRendering )
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           &v117,
			//           &v119,
			//           &v112,
			//           0,
			//           RenderBufferLoadAction__Enum_Clear,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&frameSettings_k__BackingField,
			//           0,
			//           0LL);
			//       else
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           &v117,
			//           &v119,
			//           &v112,
			//           0,
			//           RenderBufferLoadAction__Enum_DontCare,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&frameSettings_k__BackingField,
			//           0,
			//           0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//         (TextureHandle *)&frameSettings_k__BackingField,
			//         &v119,
			//         &input.sceneDepth,
			//         DepthAccess__Enum_Read,
			//         0,
			//         0LL);
			//       gBufferProfileConfig = (unsigned int)input.gBufferProfileConfig;
			//       if ( !v111 )
			//         sub_1802DC2C8(gBufferProfileConfig, v20);
			//       LODWORD(v111[4].monitor) = gBufferProfileConfig;
			//       if ( !input.gBufferProfileConfig )
			//       {
			//         for ( i = 0; i < 4; ++i )
			//         {
			//           if ( !v111 )
			//             sub_1802DC2C8(gBufferProfileConfig, v20);
			//           klass = v111[5].klass;
			//           GBufferAttachment = (BitArray128 *)HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                                                &v117,
			//                                                &input.gBufferOutput,
			//                                                i,
			//                                                0LL);
			//           if ( !klass )
			//             sub_1802DC2C8(v26, v25);
			//           frameSettings_k__BackingField.bitDatas = *GBufferAttachment;
			//           sub_1803EF6F4(klass, i, &frameSettings_k__BackingField);
			//           if ( !v111 )
			//             sub_1802DC2C8(v28, v27);
			//           v29 = v111[5].klass;
			//           if ( !v29 )
			//             sub_1802DC2C8(v28, v27);
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           v30 = (TextureHandle *)sub_18037A2E0(v29, i);
			//           if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(v30, 0LL) )
			//           {
			//             if ( !v111 )
			//               sub_1802DC2C8(gBufferProfileConfig, v20);
			//             v31 = v111[5].klass;
			//             if ( !v31 )
			//               sub_1802DC2C8(0LL, v20);
			//             v32 = (TextureHandle *)sub_18037A2E0(v31, i);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v112, &v119, v32, 0LL);
			//           }
			//         }
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneMV, 0LL) )
			//       {
			//         p_sceneMV = &input.sceneMV;
			//         if ( input.lowResRendering )
			//         {
			//           frameSettings_k__BackingField.bitDatas = (BitArray128)_mm_load_si128((const __m128i *)&xmmword_18C1755F0);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             &v117,
			//             &v119,
			//             p_sceneMV,
			//             1,
			//             RenderBufferLoadAction__Enum_Clear,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&frameSettings_k__BackingField,
			//             0,
			//             0LL);
			//         }
			//         else
			//         {
			//           frameSettings_k__BackingField.bitDatas = (BitArray128)_mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             &v117,
			//             &v119,
			//             p_sceneMV,
			//             1,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&frameSettings_k__BackingField,
			//             0,
			//             0LL);
			//         }
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//         (TextureHandle *)&frameSettings_k__BackingField,
			//         &v119,
			//         &input.sceneDepthCopied,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.sceneDepthWithWater, 0LL) )
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//           (TextureHandle *)&frameSettings_k__BackingField,
			//           &v119,
			//           &input.sceneDepthWithWater,
			//           0LL);
			//       if ( !v16 )
			//         sub_1802DC2C8(v35, v34);
			//       frameSettings_k__BackingField = v16.fields._frameSettings_k__BackingField;
			//       if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//              &frameSettings_k__BackingField,
			//              FrameSettingsField__Enum_ShadowMaps,
			//              0LL)
			//         || (frameSettings_k__BackingField = v16.fields._frameSettings_k__BackingField,
			//             HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//               &frameSettings_k__BackingField,
			//               FrameSettingsField__Enum_CharacterShadowMaps,
			//               0LL)) )
			//       {
			//         v36 = *(_OWORD *)&v119.m_RenderPass;
			//         v37 = *(_OWORD *)&v119.m_RenderGraph;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//         *(_OWORD *)&v120.m_RenderPass = v36;
			//         *(_OWORD *)&v120.m_RenderGraph = v37;
			//         HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(
			//           (ShadowResult *)&v126,
			//           &input.shadowResult,
			//           &v120,
			//           0LL);
			//       }
			//       hgrp = (Object *)input.hgrp;
			//       waterRenderingPass = (Object *)input.waterRenderingPass;
			//       bakedLightConfig = input.bakedLightConfig;
			//       forwardTransparentECSRendererList = input.forwardTransparentECSRendererList;
			//       characterOutlineEnabled = input.characterOutlineEnabled;
			//       screenCullingRatio = input.screenCullingRatio;
			//       screenCullingRatioDistance = input.screenCullingRatioDistance;
			//       screenCullingLayerMask = input.screenCullingLayerMask;
			//       v41 = v111;
			//       transparentVRS = input.transparentVRS;
			//       transparentVRRx = input.transparentVRRx;
			//       transparentVRRy = input.transparentVRRy;
			//       lowResRendering = input.lowResRendering;
			//       p_basicTransformConstants = &input.basicTransformConstants;
			//       p_shaderVariablesGlobal = &input.shaderVariablesGlobal;
			//       cullingResults = (BitArray128)input.cullingResults;
			//       v120 = v119;
			//       sceneDepthWithWater = input.sceneDepthWithWater;
			//       frameSettings_k__BackingField.bitDatas = (BitArray128)sceneDepthWithWater;
			//       sceneDepthCopied = input.sceneDepthCopied;
			//       v117 = sceneDepthCopied;
			//       v112 = v13;
			//       if ( !byte_18D91954F )
			//       {
			//         sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//         sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//         sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//         sub_18003C530(&MethodInfo::System::Nullable<UnityEngine::Rendering::RenderQueueRange>::Nullable);
			//         sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         byte_18D91954F = 1;
			//       }
			//       inputa = 0LL;
			//       sub_1802F01E0(&desc, 0LL, 224LL);
			//       sub_1802F01E0(&v127, 0LL, 112LL);
			//       if ( IFix::WrappersManagerImpl::IsPatched(2618, 0LL) )
			//       {
			//         v94 = IFix::WrappersManagerImpl::GetPatch(2618, 0LL);
			//         if ( !v94 )
			//           sub_1802DC2C8(v96, v95);
			//         frameSettings_k__BackingField.bitDatas = cullingResults;
			//         *(_OWORD *)&v126.width = *(_OWORD *)&v120.m_RenderPass;
			//         *(_OWORD *)&v126.colorFormat = *(_OWORD *)&v120.m_RenderGraph;
			//         v117 = sceneDepthWithWater;
			//         v112 = sceneDepthCopied;
			//         *(TextureHandle *)&v121.m_RenderPass = v13;
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_960(
			//           v94,
			//           hgrp,
			//           (Object *)renderGraph,
			//           (TextureHandle *)&v121,
			//           &v112,
			//           &v117,
			//           (Object *)v16,
			//           waterRenderingPass,
			//           (HGRenderGraphBuilder *)&v126,
			//           (CullingResults *)&frameSettings_k__BackingField,
			//           (PerObjectData__Enum)bakedLightConfig,
			//           forwardTransparentECSRendererList,
			//           characterOutlineEnabled,
			//           screenCullingRatio,
			//           screenCullingRatioDistance,
			//           screenCullingLayerMask,
			//           v41,
			//           transparentVRS,
			//           transparentVRRx,
			//           transparentVRRy,
			//           lowResRendering,
			//           p_basicTransformConstants,
			//           p_shaderVariablesGlobal,
			//           0LL);
			//       }
			//       else
			//       {
			//         if ( !v41 )
			//           sub_1802DC2C8(v47, v46);
			//         v41[9].klass = (Object__Class *)waterRenderingPass;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v48 = (((unsigned __int64)&v41[9] >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v48 + 36190]);
			//           do
			//             v49 = qword_18D6405E0[v48 + 36190];
			//           while ( v49 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v48 + 36190],
			//                            v49 | (1LL << (((unsigned __int64)&v41[9] >> 12) & 0x3F)),
			//                            v49) );
			//         }
			//         if ( waterRenderingPass )
			//         {
			//           v121 = v120;
			//           HG::Rendering::Runtime::WaterOnePassDeferredRenderingPass::PrepareInTransparentPass(
			//             (WaterOnePassDeferredRenderingPass *)waterRenderingPass,
			//             &v121,
			//             0LL);
			//         }
			//         *(TextureHandle *)&v41[1].monitor = v13;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v112, 0LL) )
			//           *(Object *)((char *)v41 + 24) = *(Object *)HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                                        (TextureHandle *)&v121,
			//                                                        &v120,
			//                                                        &v112,
			//                                                        0LL);
			//         *(TextureHandle *)&v41[2].monitor = sceneDepthCopied;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v117, 0LL) )
			//           *(Object *)((char *)v41 + 40) = *(Object *)HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                                        &v112,
			//                                                        &v120,
			//                                                        &v117,
			//                                                        0LL);
			//         *(TextureHandle *)&v41[3].monitor = sceneDepthWithWater;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(
			//                (TextureHandle *)&frameSettings_k__BackingField,
			//                0LL) )
			//         {
			//           *(Object *)((char *)v41 + 56) = *(Object *)HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                                        &v117,
			//                                                        &v120,
			//                                                        (TextureHandle *)&frameSettings_k__BackingField,
			//                                                        0LL);
			//         }
			//         v41[1].klass = (Object__Class *)v16;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v50 = (((unsigned __int64)&v41[1] >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v50 + 36190]);
			//           do
			//             v51 = qword_18D6405E0[v50 + 36190];
			//           while ( v51 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v50 + 36190],
			//                            v51 | (1LL << (((unsigned __int64)&v41[1] >> 12) & 0x3F)),
			//                            v51) );
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//         forwardTransparent = static_fields.forwardTransparent;
			//         if ( !forwardTransparent )
			//           sub_1802DC2C8(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager, 0LL);
			//         m_defaultValue = forwardTransparent.fields.m_defaultValue;
			//         forwardDecal = static_fields.forwardDecal;
			//         if ( !forwardDecal )
			//           sub_1802DC2C8(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager, 0LL);
			//         v107 = forwardDecal.fields.m_defaultValue;
			//         vfxDecal = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields.vfxDecal;
			//         if ( !vfxDecal )
			//           sub_1802DC2C8(0LL, forwardDecal);
			//         v103 = vfxDecal.fields.m_defaultValue;
			//         LODWORD(v41[7].monitor) = -1;
			//         HIDWORD(v41[7].monitor) = -1;
			//         LODWORD(v41[8].klass) = -1;
			//         frameSettings_k__BackingField = v16.fields._frameSettings_k__BackingField;
			//         if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//                &frameSettings_k__BackingField,
			//                FrameSettingsField__Enum_TransparentObjects,
			//                0LL) )
			//         {
			//           if ( m_defaultValue )
			//           {
			//             frameSettings_k__BackingField.bitDatas = cullingResults;
			//             v57 = hgrp;
			//             v58 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardTransparentRendererList(
			//                     v129,
			//                     (HGRenderPipeline *)hgrp,
			//                     v16,
			//                     0,
			//                     characterOutlineEnabled,
			//                     (CullingResults *)&frameSettings_k__BackingField,
			//                     (PerObjectData__Enum)bakedLightConfig,
			//                     screenCullingRatio,
			//                     screenCullingRatioDistance,
			//                     screenCullingLayerMask,
			//                     0LL);
			//             *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v58.sortingCriteria;
			//             desc.stateBlock = v58.stateBlock;
			//             v58 = (RendererListDesc *)((char *)v58 + 128);
			//             *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v58.sortingCriteria;
			//             *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v58.stateBlock.hasValue;
			//             *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v58.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v58.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v58.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v58.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//             v59 = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//           }
			//           else
			//           {
			//             if ( IFix::WrappersManagerImpl::IsPatched(306, 0LL) )
			//             {
			//               v60 = IFix::WrappersManagerImpl::GetPatch(306, 0LL);
			//               if ( !v60 )
			//                 sub_1802DC2C8(v62, v61);
			//               v59 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_142(v60, 0LL);
			//             }
			//             else
			//             {
			//               v59 = 0LL;
			//             }
			//             v57 = hgrp;
			//           }
			//           inputa = v59;
			//           v41[6].monitor = (MonitorData *)HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//                                             &v120,
			//                                             &inputa,
			//                                             0LL);
			//           if ( v103 )
			//           {
			//             hgrp = (Object *)v16.fields.camera;
			//             if ( !v57 )
			//               sub_1802DC2C8(v64, v63);
			//             monitor = (ShaderTagId__Array *)v57[11].monitor;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//             *(HGRenderGraphPass **)((char *)&v121.m_RenderPass + 4) = (HGRenderGraphPass *)TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_All;
			//             LODWORD(v121.m_RenderPass) = 1;
			//             sub_1802F01E0(&v127, 0LL, 112LL);
			//             v112.handle = (ResourceHandle)v121.m_RenderPass;
			//             v112.fallBackResource.m_Value = (uint32_t)v121.m_Resources;
			//             frameSettings_k__BackingField.bitDatas = cullingResults;
			//             v66 = HG::Rendering::Runtime::HGRendererListUtils::CreateTransparentRendererListDesc(
			//                     v129,
			//                     (CullingResults *)&frameSettings_k__BackingField,
			//                     (Camera *)hgrp,
			//                     monitor,
			//                     screenCullingRatio,
			//                     screenCullingRatioDistance,
			//                     screenCullingLayerMask,
			//                     (PerObjectData__Enum)bakedLightConfig,
			//                     (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v112,
			//                     &v127,
			//                     0LL,
			//                     0,
			//                     0LL);
			//             *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v66.sortingCriteria;
			//             desc.stateBlock = v66.stateBlock;
			//             v66 = (RendererListDesc *)((char *)v66 + 128);
			//             *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v66.sortingCriteria;
			//             *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v66.stateBlock.hasValue;
			//             *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v66.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v66.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v66.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//             *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v66.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//             InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//           }
			//           else
			//           {
			//             InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//           }
			//           inputa = InvalidHandle;
			//           v41[7].klass = (Object__Class *)HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(
			//                                             &v120,
			//                                             &inputa,
			//                                             0LL);
			//           if ( v107 )
			//           {
			//             cullingViewHandle = v16.fields.cullingViewHandle;
			//             m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//             if ( !m_RenderGraphContext )
			//               sub_1802DC2C8(v69, v68);
			//             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//             m_Ptr = m_RenderGraphContext.fields.renderContext.m_Ptr;
			//             v73 = (__int64 (__fastcall *)(_QWORD, __int64, void *, _QWORD))qword_18D930450;
			//             if ( !qword_18D930450 )
			//             {
			//               v73 = (__int64 (__fastcall *)(_QWORD, __int64, void *, _QWORD))il2cpp_resolve_icall_0(
			//                                                                                "UnityEngine.HyperGryph.HGDecalRender::Cre"
			//                                                                                "ateRendererList(System.UInt32,System.UInt"
			//                                                                                "32,System.IntPtr,System.UInt32*)");
			//               if ( !v73 )
			//               {
			//                 v100 = sub_1802DBBE8(
			//                          "UnityEngine.HyperGryph.HGDecalRender::CreateRendererList(System.UInt32,System.UInt32,System.Int"
			//                          "Ptr,System.UInt32*)");
			//                 sub_18000F750(v100, 0LL);
			//               }
			//               qword_18D930450 = (__int64)v73;
			//             }
			//             v74 = v73(cullingViewHandle, 0x4000LL, m_Ptr, 0LL);
			//           }
			//           else
			//           {
			//             v74 = -1;
			//           }
			//           HIDWORD(v41[7].monitor) = v74;
			//           if ( v103 )
			//           {
			//             v75 = v16.fields.cullingViewHandle;
			//             v76 = renderGraph.fields.m_RenderGraphContext;
			//             if ( !v76 )
			//               sub_1802DC2C8(v69, v68);
			//             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//             LOWORD(globalKeywords) = 0;
			//             RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                              v75,
			//                              HGRenderFlags__Enum_ShadowOnly|HGRenderFlags__Enum_Transparent,
			//                              HGRenderFlags__Enum_Transparent,
			//                              HGShaderLightMode__Enum_VFXDecal,
			//                              globalKeywords,
			//                              v76.fields.renderContext.m_Ptr,
			//                              0,
			//                              1,
			//                              0xFFFFFFFF,
			//                              0,
			//                              0,
			//                              0LL);
			//           }
			//           else
			//           {
			//             RendererList = -1;
			//           }
			//           LODWORD(v41[8].klass) = RendererList;
			//           v78 = forwardTransparentECSRendererList;
			//           LODWORD(v41[7].monitor) = forwardTransparentECSRendererList;
			//           v79 = v16.fields.camera;
			//           if ( !v79 )
			//             sub_1802DC2C8(v78, v68);
			//           v80 = (__int64 (__fastcall *)(Camera *))qword_18D8F41E8;
			//           if ( !qword_18D8F41E8 )
			//           {
			//             v80 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Camera::get_cullingMask()");
			//             if ( !v80 )
			//             {
			//               v101 = sub_1802DBBE8("UnityEngine.Camera::get_cullingMask()");
			//               sub_18000F750(v101, 0LL);
			//             }
			//             qword_18D8F41E8 = (__int64)v80;
			//           }
			//           v81.m_Mask = v80(v79);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//           v83.m_Mask = HG::Rendering::Runtime::HGCamera::RemoveWorldUILayer(v81, 0LL).m_Mask;
			//           v84 = (Object_1 *)v16.fields.camera;
			//           if ( !v84 )
			//             sub_1802DC2C8(0LL, v82);
			//           InstanceID = UnityEngine::Object::GetInstanceID(v84, 0LL);
			//           v88 = renderGraph.fields.m_RenderGraphContext;
			//           if ( !v88 )
			//             sub_1802DC2C8(v86, v85);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           HIDWORD(v41[8].klass) = UnityEngine::HyperGryph::HGUIRender::CreateRendererList(
			//                                     v83.m_Mask,
			//                                     HGRenderFlags__Enum_None,
			//                                     HGRenderFlags__Enum_None,
			//                                     HGShaderLightMode__Enum_StencilAlphaBlend|HGShaderLightMode__Enum_SRPDefaultUnlit|HGShaderLightMode__Enum_Forward|HGShaderLightMode__Enum_ForwardOnly,
			//                                     0x8000,
			//                                     0x7FFF,
			//                                     InstanceID,
			//                                     v88.fields.renderContext.m_Ptr,
			//                                     0,
			//                                     3.4028235e38,
			//                                     0LL);
			//           LODWORD(v41[8].monitor) = -1;
			//           LOBYTE(v41[9].monitor) = transparentVRS;
			//           HIDWORD(v41[9].monitor) = transparentVRRx;
			//           LODWORD(v41[10].klass) = transparentVRRy;
			//           BYTE4(v41[10].klass) = lowResRendering;
			//           v89 = v129;
			//           v90 = 5LL;
			//           v91 = 5LL;
			//           do
			//           {
			//             *(_OWORD *)&v89.sortingCriteria = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m00;
			//             *(_OWORD *)&v89.stateBlock.hasValue = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m01;
			//             *(_OWORD *)&v89.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m02;
			//             *(_OWORD *)&v89.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m03;
			//             *(_OWORD *)&v89.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m00;
			//             *(_OWORD *)&v89.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m01;
			//             *(_OWORD *)&v89.stateBlock.value.m_RasterState.m_OffsetFactor = *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m02;
			//             v89 = (RendererListDesc *)((char *)v89 + 128);
			//             *(_OWORD *)&v89[-1]._passName_k__BackingField.m_Id = *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m03;
			//             p_basicTransformConstants = (BasicTransformConstants *)((char *)p_basicTransformConstants + 128);
			//             --v91;
			//           }
			//           while ( v91 );
			//           *(_OWORD *)&v89.sortingCriteria = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m00;
			//           *(_OWORD *)&v89.stateBlock.hasValue = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m01;
			//           *(_OWORD *)&v89.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m02;
			//           *(_OWORD *)&v89.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&p_basicTransformConstants._ViewMatrix.m03;
			//           *(_OWORD *)&v89.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = *(_OWORD *)&p_basicTransformConstants._InvViewMatrix.m00;
			//           p_monitor = &v41[10].monitor;
			//           v93 = v129;
			//           do
			//           {
			//             *(_OWORD *)p_monitor = *(_OWORD *)&v93.sortingCriteria;
			//             *((_OWORD *)p_monitor + 1) = *(_OWORD *)&v93.stateBlock.hasValue;
			//             *((_OWORD *)p_monitor + 2) = *(_OWORD *)&v93.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//             *((_OWORD *)p_monitor + 3) = *(_OWORD *)&v93.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//             *((_OWORD *)p_monitor + 4) = *(_OWORD *)&v93.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//             *((_OWORD *)p_monitor + 5) = *(_OWORD *)&v93.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//             *((_OWORD *)p_monitor + 6) = *(_OWORD *)&v93.stateBlock.value.m_RasterState.m_OffsetFactor;
			//             p_monitor += 16;
			//             *((_OWORD *)p_monitor - 1) = *(_OWORD *)&v93.stateBlock.value.m_StencilState.m_FailOperationFront;
			//             v93 = (RendererListDesc *)((char *)v93 + 128);
			//             --v90;
			//           }
			//           while ( v90 );
			//           *(_OWORD *)p_monitor = *(_OWORD *)&v93.sortingCriteria;
			//           *((_OWORD *)p_monitor + 1) = *(_OWORD *)&v93.stateBlock.hasValue;
			//           *((_OWORD *)p_monitor + 2) = *(_OWORD *)&v93.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//           *((_OWORD *)p_monitor + 3) = *(_OWORD *)&v93.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//           *((_OWORD *)p_monitor + 4) = *(_OWORD *)&v93.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//           sub_1802EFB40(v129, p_shaderVariablesGlobal, 3792LL);
			//           sub_1802EFB40(&v41[55].monitor, v129, 3792LL);
			//         }
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v119,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TransparentPassConstructor.static_fields.s_fromDeferredLightingToForwardTransparentRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::ForwardPassUtils::ForwardTransparentPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v124 )
			//     {
			//       v123[0] = v124.ex;
			//     }
			//     sub_180222690(v123);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::TransparentPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         TransparentPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2650, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2650, 0LL);
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
			// void HG::Rendering::Runtime::TransparentPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         TransparentPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2651, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2651, 0LL);
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
		private static readonly RenderFunc<ForwardPassUtils.ForwardTransparentPassData> s_fromDeferredLightingToForwardTransparentRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneMV;

			internal TextureHandle sceneDepthCopied;

			internal TextureHandle sceneDepthWithWater;

			internal HGRenderPipeline hgrp;

			internal GBufferProfileManager.GBufferProfileConfig gBufferProfileConfig;

			internal GBufferOutput gBufferOutput;

			internal WaterOnePassDeferredRenderingPass waterRenderingPass;

			internal ShadowResult shadowResult;

			internal CullingResults cullingResults;

			internal PerObjectData bakedLightConfig;

			internal uint forwardTransparentECSRendererList;

			internal bool characterOutlineEnabled;

			internal float screenCullingRatio;

			internal float screenCullingRatioDistance;

			internal uint screenCullingLayerMask;

			internal bool transparentVRS;

			internal int transparentVRRx;

			internal int transparentVRRy;

			internal bool lowResRendering;

			internal BasicTransformConstants basicTransformConstants;

			internal ShaderVariablesGlobal shaderVariablesGlobal;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassOutput
		{
			internal TextureHandle sceneColor;
		}
	}
}
