using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class DeferredLightingPassConstructor : IPassConstructor
	{
		internal DeferredLightingPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void PrepareDeferredLightingPass(ref DeferredLightingPassConstructor.PassInput input, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, DeferredLightingPassConstructor.DeferredLightingPassData passData, bool changeColorRT)
		{
			// // Void PrepareDeferredLightingPass(DeferredLightingPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, HGRenderGraphBuilder, DeferredLightingPassConstructor+DeferredLightingPassData, Boolean)
			// void HG::Rendering::Runtime::DeferredLightingPassConstructor::PrepareDeferredLightingPass(
			//         DeferredLightingPassConstructor *this,
			//         DeferredLightingPassConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         HGRenderGraphBuilder *builder,
			//         DeferredLightingPassConstructor_DeferredLightingPassData *passData,
			//         bool changeColorRT,
			//         MethodInfo *method)
			// {
			//   TextureHandle *v12; // rax
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   TextureHandle *v15; // rax
			//   MethodInfo *v16; // rdx
			//   TextureHandle *v17; // rax
			//   Color v18; // xmm0
			//   OneofDescriptorProto *v19; // rdx
			//   FileDescriptor *v20; // r8
			//   MessageDescriptor *v21; // r9
			//   __int64 v22; // r10
			//   int32_t v23; // ebx
			//   TextureHandle v24; // xmm0
			//   GBufferOutput *p_gBufferOutput; // rax
			//   TextureHandle__Array *gbuffer; // r12
			//   TextureHandle *GBufferAttachment; // rax
			//   TextureHandle__Array *v28; // r12
			//   TextureHandle *v29; // rax
			//   TextureHandle *v30; // rax
			//   TextureHandle v31; // xmm0
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   Shader *shader; // rbx
			//   Material *m_deferredLightingMaterial; // rbx
			//   bool HasTerrainSimpleSubsurface; // al
			//   OneofDescriptorProto *v38; // rdx
			//   FileDescriptor *v39; // r8
			//   MessageDescriptor *v40; // r9
			//   Material *m_deferredLightingWriteAlphaMaterial; // r9
			//   OneofDescriptorProto *v42; // rdx
			//   FileDescriptor *v43; // r8
			//   HGRenderGraph *v44; // xmm1_8
			//   HGRenderGraph *v45; // xmm1_8
			//   __int128 v46; // xmm6
			//   __int128 v47; // xmm7
			//   __int128 v48; // xmm1
			//   String__Array *v49; // [rsp+28h] [rbp-E0h]
			//   String__Array *v50; // [rsp+28h] [rbp-E0h]
			//   String__Array *v51; // [rsp+28h] [rbp-E0h]
			//   String__Array *v52; // [rsp+28h] [rbp-E0h]
			//   String *v53; // [rsp+30h] [rbp-D8h]
			//   String *v54; // [rsp+30h] [rbp-D8h]
			//   String *v55; // [rsp+30h] [rbp-D8h]
			//   String *v56; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v57; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v58; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v59; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v60; // [rsp+38h] [rbp-D0h]
			//   TextureHandle v61; // [rsp+58h] [rbp-B0h] BYREF
			//   HGRenderGraphBuilder v62; // [rsp+68h] [rbp-A0h] BYREF
			//   Color v63; // [rsp+88h] [rbp-80h] BYREF
			//   TextureDesc v64; // [rsp+98h] [rbp-70h] BYREF
			//   LocalKeyword keyword; // [rsp+F8h] [rbp-10h] BYREF
			//   TextureDesc v66; // [rsp+118h] [rbp+10h] BYREF
			//   ShadowResult v67; // [rsp+178h] [rbp+70h] BYREF
			// 
			//   if ( !byte_18D91951B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FAF00);
			//     byte_18D91951B = 1;
			//   }
			//   memset(&keyword, 0, sizeof(keyword));
			//   sub_1802F01E0(&v66, 0LL, 96LL);
			//   sub_1802F01E0(&v64, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2536, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2536, 0LL);
			//     if ( Patch )
			//     {
			//       v48 = *(_OWORD *)&builder.m_RenderGraph;
			//       *(_OWORD *)&v62.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//       *(_OWORD *)&v62.m_RenderGraph = v48;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_933(
			//         Patch,
			//         (Object *)this,
			//         input,
			//         (Object *)renderGraph,
			//         (Object *)camera,
			//         &v62,
			//         (Object *)passData,
			//         changeColorRT,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_35;
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.historySceneColor, 0LL) )
			//   {
			//     v12 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//             &v61,
			//             builder,
			//             &input.historySceneColor,
			//             0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v12 = (TextureHandle *)sub_182E7CCD0(&v61);
			//   }
			//   if ( !passData )
			//     goto LABEL_35;
			//   passData.fields.previousSceneColorTexture = *v12;
			//   if ( !camera )
			//     goto LABEL_35;
			//   if ( HG::Rendering::Runtime::HGCamera::get_ssrEnable(camera, 0LL) )
			//   {
			//     passData.fields.ssrLightingTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                              &v61,
			//                                              builder,
			//                                              &input.ssrLightingTexture,
			//                                              0LL);
			//     passData.fields.ssrFadenessTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                              &v61,
			//                                              builder,
			//                                              &input.ssrFadenessTexture,
			//                                              0LL);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.indirectAmbientOcclusionTexture, 0LL) )
			//     passData.fields.indirectAmbientOcclusionTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                                           &v61,
			//                                                           builder,
			//                                                           &input.indirectAmbientOcclusionTexture,
			//                                                           0LL);
			//   passData.fields.planarReflectionTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                                 &v61,
			//                                                 builder,
			//                                                 &input.planarReflectionTexture,
			//                                                 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.fogBakeLutTexture, 0LL) )
			//     passData.fields.fogBakeLutTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                             &v61,
			//                                             builder,
			//                                             &input.fogBakeLutTexture,
			//                                             0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&input.waterWetnessMaskTexture, 0LL) )
			//   {
			//     v15 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//             &v61,
			//             builder,
			//             &input.waterWetnessMaskTexture,
			//             0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v15 = (TextureHandle *)sub_182E7CCD0(&v61);
			//   }
			//   passData.fields.waterWetnessMaskTexture = *v15;
			//   if ( changeColorRT )
			//   {
			//     HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v64, camera.fields._sceneRTSize_k__BackingField, 0LL);
			//     v64.colorFormat = input.sceneColorFormat;
			//     v64.enableRandomWrite = 0;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     v64.clearBuffer = HG::Rendering::Runtime::HGRenderPipeline::NeedClearColorBuffer(camera, 0LL);
			//     v18 = *HG::Rendering::Runtime::HGRenderPipeline::GetColorBufferClearColor(&v63, camera, 0LL);
			//     v64.filterMode = 1;
			//     v64.clearColor = v18;
			//     v64.wrapMode = 1;
			//     v64.name = (String *)"SceneColorCreatedByDeferredLightingPass";
			//     sub_1800054D0((OneofDescriptor *)&v64.name, v19, v20, v21, v49, v53, v57);
			//     v64.fastMemoryDesc.residencyFraction = 1.0;
			//     v66 = v64;
			//     *(_QWORD *)&v61.handle._type_k__BackingField = v22;
			//     v61.handle.m_Value = (unsigned __int8)v22;
			//     *(ResourceHandle *)&v64.fastMemoryDesc.inFastMemory = v61.handle;
			//     if ( !renderGraph )
			//       goto LABEL_35;
			//     v61 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture((TextureHandle *)&v63, renderGraph, &v66, 0LL);
			//     v17 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v63,
			//             builder,
			//             &v61,
			//             0,
			//             0,
			//             0LL);
			//   }
			//   else
			//   {
			//     v61 = (TextureHandle)*UnityEngine::Quaternion::get_identity((Quaternion *)&v61, v16);
			//     v17 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v63,
			//             builder,
			//             &input.sceneColor,
			//             0,
			//             RenderBufferLoadAction__Enum_Load,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&v61,
			//             0,
			//             0LL);
			//   }
			//   passData.fields.colorBuffer = *v17;
			//   v23 = 0;
			//   v24 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//            (TextureHandle *)&v63,
			//            builder,
			//            &input.sceneDepth,
			//            DepthAccess__Enum_Read,
			//            0,
			//            0LL);
			//   p_gBufferOutput = &input.gBufferOutput;
			//   passData.fields.depthBuffer = v24;
			//   do
			//   {
			//     gbuffer = passData.fields.gbuffer;
			//     GBufferAttachment = HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                           (TextureHandle *)&v63,
			//                           p_gBufferOutput,
			//                           v23,
			//                           0LL);
			//     if ( !gbuffer )
			//       goto LABEL_35;
			//     v61 = *GBufferAttachment;
			//     sub_1803EF6F4(gbuffer, v23, &v61);
			//     v28 = passData.fields.gbuffer;
			//     if ( !v28 )
			//       goto LABEL_35;
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v29 = (TextureHandle *)sub_18037A2E0(v28, v23);
			//     if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(v29, 0LL) )
			//     {
			//       Patch = (ILFixDynamicMethodWrapper_2 *)passData.fields.gbuffer;
			//       if ( !Patch )
			//         goto LABEL_35;
			//       v30 = (TextureHandle *)sub_18037A2E0(Patch, v23);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture((TextureHandle *)&v62, builder, v30, 0LL);
			//     }
			//     ++v23;
			//     p_gBufferOutput = &input.gBufferOutput;
			//   }
			//   while ( v23 < 4 );
			//   v31 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//            (TextureHandle *)&v62,
			//            builder,
			//            &input.sceneDepthCopied,
			//            0LL);
			//   passData.fields.hgCamera = camera;
			//   passData.fields.depthTexture = v31;
			//   sub_1800054D0((OneofDescriptor *)&passData.fields.hgCamera, v32, v33, v34, v50, v54, v58);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_deferredLightingMaterial;
			//   if ( !Patch
			//     || (shader = UnityEngine::Material::get_shader((Material *)Patch, 0LL),
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords),
			//         UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//           &keyword,
			//           shader,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_SubsurfaceProfileSimple,
			//           0LL),
			//         m_deferredLightingMaterial = this.fields.m_deferredLightingMaterial,
			//         HasTerrainSimpleSubsurface = HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeUtils::HasTerrainSimpleSubsurface(0LL),
			//         !m_deferredLightingMaterial) )
			//   {
			// LABEL_35:
			//     sub_180B536AC(Patch, v13);
			//   }
			//   UnityEngine::Material::SetKeyword(m_deferredLightingMaterial, &keyword, HasTerrainSimpleSubsurface, 0LL);
			//   passData.fields.deferredLightingMaterial = this.fields.m_deferredLightingMaterial;
			//   sub_1800054D0((OneofDescriptor *)&passData.fields.deferredLightingMaterial, v38, v39, v40, v51, v55, v59);
			//   m_deferredLightingWriteAlphaMaterial = this.fields.m_deferredLightingWriteAlphaMaterial;
			//   passData.fields.deferredLightingWriteAlphaMaterial = m_deferredLightingWriteAlphaMaterial;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&passData.fields.deferredLightingWriteAlphaMaterial,
			//     v42,
			//     v43,
			//     (MessageDescriptor *)m_deferredLightingWriteAlphaMaterial,
			//     v52,
			//     v56,
			//     v60);
			//   v44 = *(HGRenderGraph **)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//   *(BitArray128 *)&v62.m_RenderPass = camera.fields._frameSettings_k__BackingField.bitDatas;
			//   v62.m_RenderGraph = v44;
			//   if ( HG::Rendering::Runtime::FrameSettings::IsEnabled((FrameSettings *)&v62, FrameSettingsField__Enum_ShadowMaps, 0LL)
			//     || (v45 = *(HGRenderGraph **)&camera.fields._frameSettings_k__BackingField.materialQuality,
			//         *(BitArray128 *)&v62.m_RenderPass = camera.fields._frameSettings_k__BackingField.bitDatas,
			//         v62.m_RenderGraph = v45,
			//         HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//           (FrameSettings *)&v62,
			//           FrameSettingsField__Enum_CharacterShadowMaps,
			//           0LL)) )
			//   {
			//     v46 = *(_OWORD *)&builder.m_RenderPass;
			//     v47 = *(_OWORD *)&builder.m_RenderGraph;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     *(_OWORD *)&v62.m_RenderPass = v46;
			//     *(_OWORD *)&v62.m_RenderGraph = v47;
			//     HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(&v67, &input.shadowResult, &v62, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::DeferredLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         DeferredLightingPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2537, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2537, 0LL);
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
			// void HG::Rendering::Runtime::DeferredLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         DeferredLightingPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2538, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2538, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref DeferredLightingPassConstructor.PassInput input, ref DeferredLightingPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(DeferredLightingPassConstructor+PassInput ByRef, DeferredLightingPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::DeferredLightingPassConstructor::ConstructPass(
			//         DeferredLightingPassConstructor *this,
			//         DeferredLightingPassConstructor_PassInput *input,
			//         DeferredLightingPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   DeferredLightingPassConstructor_DeferredLightingPassData *v18; // [rsp+40h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v19; // [rsp+48h] [rbp-70h] BYREF
			//   HGRenderGraphBuilder v20; // [rsp+50h] [rbp-68h] BYREF
			//   HGRenderGraphBuilder v21; // [rsp+70h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v22; // [rsp+90h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91951C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DeferredLightingPassConstructor::DeferredLightingPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DeferredLightingPassConstructor::DeferredLightingPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D4FAFB0);
			//     byte_18D91951C = 1;
			//   }
			//   v18 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2539, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2539, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_934(
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
			//             (Int32Enum__Enum)0x8Cu,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v12, v11);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v20,
			//       renderGraph,
			//       (String *)"Deferred Lighting",
			//       (Object **)&v18,
			//       v10,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DeferredLightingPassConstructor::DeferredLightingPassData>);
			//     v21 = v20;
			//     v20.m_RenderPass = 0LL;
			//     v20.m_Resources = (HGRenderGraphResourceRegistry *)&v21;
			//     try
			//     {
			//       v22 = v21;
			//       HG::Rendering::Runtime::DeferredLightingPassConstructor::PrepareDeferredLightingPass(
			//         this,
			//         input,
			//         renderGraph,
			//         camera,
			//         &v22,
			//         v18,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v21,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DeferredLightingPassConstructor.static_fields.s_fromDeferredLightingToForwardOpaqueRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DeferredLightingPassConstructor::DeferredLightingPassData>);
			//       if ( !v18 )
			//         sub_1802DC2C8(v14, v13);
			//       *output = (DeferredLightingPassConstructor_PassOutput)v18.fields.colorBuffer;
			//     }
			//     catch ( Il2CppExceptionWrapper *v19 )
			//     {
			//       v20.m_RenderPass = (HGRenderGraphPass *)v19.ex;
			//     }
			//     sub_180222690(&v20);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::DeferredLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         DeferredLightingPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2540, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2540, 0LL);
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
			// void HG::Rendering::Runtime::DeferredLightingPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         DeferredLightingPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2541, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2541, 0LL);
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

		private Material m_deferredLightingMaterial;

		private Material m_deferredLightingWriteAlphaMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<DeferredLightingPassConstructor.DeferredLightingPassData> s_fromDeferredLightingToForwardOpaqueRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneDepthCopied;

			internal TextureHandle historySceneColor;

			internal TextureHandle indirectAmbientOcclusionTexture;

			internal TextureHandle ssrLightingTexture;

			internal TextureHandle ssrFadenessTexture;

			internal TextureHandle planarReflectionTexture;

			internal TextureHandle fogBakeLutTexture;

			internal TextureHandle waterWetnessMaskTexture;

			internal HGRenderPipeline hgrp;

			internal GBufferOutput gBufferOutput;

			internal ShadowResult shadowResult;

			internal GraphicsFormat sceneColorFormat;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassOutput
		{
			internal TextureHandle sceneColor;
		}

		private class DeferredLightingPassData
		{
			public DeferredLightingPassData()
			{
				// // DeferredLightingPassConstructor+DeferredLightingPassData()
				// void HG::Rendering::Runtime::DeferredLightingPassConstructor::DeferredLightingPassData::DeferredLightingPassData(
				//         DeferredLightingPassConstructor_DeferredLightingPassData *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // r8
				//   __int64 v4; // r9
				//   OneofDescriptorProto *v5; // rdx
				//   FileDescriptor *v6; // r8
				//   MessageDescriptor *v7; // r9
				//   String__Array *v8; // [rsp+50h] [rbp+28h]
				//   String *v9; // [rsp+58h] [rbp+30h]
				//   MethodInfo *v10; // [rsp+60h] [rbp+38h]
				// 
				//   if ( !byte_18D91951D )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
				//     byte_18D91951D = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph);
				//   this.fields.gbuffer = (TextureHandle__Array *)il2cpp_array_new_specific_0(
				//                                                    TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle,
				//                                                    TypeInfo::HG::Rendering::RenderGraphModule::HGRenderGraph.static_fields.kMaxMRTCount,
				//                                                    v3,
				//                                                    v4);
				//   sub_1800054D0((OneofDescriptor *)&this.fields.gbuffer, v5, v6, v7, v8, v9, v10);
				// }
				// 
			}

			public TextureHandle colorBuffer;

			public TextureHandle depthBuffer;

			public TextureHandle depthTexture;

			public TextureHandle previousSceneColorTexture;

			public TextureHandle indirectAmbientOcclusionTexture;

			public TextureHandle ssrLightingTexture;

			public TextureHandle ssrFadenessTexture;

			public TextureHandle planarReflectionTexture;

			public TextureHandle fogBakeLutTexture;

			public TextureHandle waterWetnessMaskTexture;

			public TextureHandle[] gbuffer;

			public HGCamera hgCamera;

			public Material deferredLightingMaterial;

			public Material deferredLightingWriteAlphaMaterial;
		}
	}
}
