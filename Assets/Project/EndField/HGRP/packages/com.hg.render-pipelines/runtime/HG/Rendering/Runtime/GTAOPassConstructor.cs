using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class GTAOPassConstructor : IPassConstructor
	{
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x000025D2 File Offset: 0x000007D2
		private static string m_GTAmbientOcclusioFeatureName
		{
			get
			{
				// // String get_m_GTAmbientOcclusioFeatureName()
				// String *HG::Rendering::Runtime::GTAOPassConstructor::get_m_GTAmbientOcclusioFeatureName(MethodInfo *method)
				// {
				//   if ( !byte_18D919573 )
				//   {
				//     sub_18003C530(&off_18C8F7800);
				//     byte_18D919573 = 1;
				//   }
				//   return (String *)"GTAO";
				// }
				// 
				return null;
			}
		}

		internal GTAOPassConstructor(HGRenderPathBase.HGRenderPathResources resources)
		{
			// // GTAOPassConstructor(HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::GTAOPassConstructor::GTAOPassConstructor(
			//         GTAOPassConstructor *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Texture2D *whiteTexture; // rsi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   OneofDescriptorProto *v10; // rdx
			//   __int64 v11; // rcx
			//   FileDescriptor *v12; // r8
			//   MessageDescriptor *v13; // r9
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   String__Array *v15[3]; // [rsp+20h] [rbp-18h] BYREF
			//   String__Array *v16; // [rsp+60h] [rbp+28h]
			//   String *v17; // [rsp+68h] [rbp+30h]
			//   MethodInfo *v18; // [rsp+70h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDA90 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D8EDA90 = 1;
			//   }
			//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, resources);
			//   this.fields.m_prevTemporalTexture = *(TextureHandle *)sub_182E7CCD0(v15);
			//   whiteTexture = UnityEngine::Texture2D::get_whiteTexture(0LL);
			//   if ( !TypeInfo::UnityEngine::Rendering::RTHandles._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::RTHandles, v5);
			//   this.fields.m_defaultTexture = UnityEngine::Rendering::RTHandleSystem::Alloc((Texture *)whiteTexture, 0LL);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_defaultTexture,
			//     v7,
			//     v8,
			//     v9,
			//     v15[0],
			//     (String *)v15[1],
			//     (MethodInfo *)v15[2]);
			//   if ( !resources.defaultResources || (shaders = resources.defaultResources.fields.shaders) == 0LL )
			//     sub_180B536AC(v11, v10);
			//   this.fields.m_shader = shaders.fields.GTAmbientOcclusionCS;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_shader, v10, v12, v13, v16, v17, v18);
			// }
			// 
		}

		private void Prepare(ref GTAOPassConstructor.PassInput input, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, GTAOPassConstructor.GTAmbientOcclusionPassData passData)
		{
			// // Void Prepare(GTAOPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, HGRenderGraphBuilder, GTAOPassConstructor+GTAmbientOcclusionPassData)
			// void HG::Rendering::Runtime::GTAOPassConstructor::Prepare(
			//         GTAOPassConstructor *this,
			//         GTAOPassConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         HGRenderGraphBuilder *builder,
			//         GTAOPassConstructor_GTAmbientOcclusionPassData *passData,
			//         MethodInfo *method)
			// {
			//   void *enableFP32Depths; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rsi
			//   GTAmbientOcclusion *m_GTAmbientOcclusion; // rsi
			//   int32_t qualityLevel; // eax
			//   Vector4 si128; // xmm0
			//   float v17; // xmm6_4
			//   char CameraFrameCount; // al
			//   unsigned int v19; // xmm0_4
			//   __int64 v20; // rcx
			//   float m_X; // xmm1_4
			//   unsigned int v22; // eax
			//   int v23; // edx
			//   __m128i v24; // xmm0
			//   __int64 v25; // rax
			//   char v26; // dl
			//   __int64 v27; // rcx
			//   int v28; // r8d
			//   bool v29; // cf
			//   OneofDescriptorProto *v30; // rdx
			//   FileDescriptor *v31; // r8
			//   MessageDescriptor *v32; // r9
			//   __int64 v33; // xmm6_8
			//   OneofDescriptorProto *v34; // rdx
			//   FileDescriptor *v35; // r8
			//   MessageDescriptor *v36; // r9
			//   TextureHandle mainAOTermRT; // xmm0
			//   OneofDescriptorProto *v38; // rdx
			//   FileDescriptor *v39; // r8
			//   MessageDescriptor *v40; // r9
			//   OneofDescriptorProto *v41; // rdx
			//   FileDescriptor *v42; // r8
			//   MessageDescriptor *v43; // r9
			//   __int128 v44; // xmm1
			//   String__Array *v45; // [rsp+28h] [rbp-E0h]
			//   String__Array *v46; // [rsp+28h] [rbp-E0h]
			//   String__Array *v47; // [rsp+28h] [rbp-E0h]
			//   String__Array *v48; // [rsp+28h] [rbp-E0h]
			//   String *v49; // [rsp+30h] [rbp-D8h]
			//   String *v50; // [rsp+30h] [rbp-D8h]
			//   String *v51; // [rsp+30h] [rbp-D8h]
			//   String *v52; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v53; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v54; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v55; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v56; // [rsp+38h] [rbp-D0h]
			//   Vector4 v57; // [rsp+48h] [rbp-C0h] BYREF
			//   TextureDesc v58; // [rsp+58h] [rbp-B0h] BYREF
			//   HGRenderGraphBuilder v59; // [rsp+B8h] [rbp-50h] BYREF
			//   __int64 v60; // [rsp+D8h] [rbp-30h]
			//   TextureDesc v61; // [rsp+E8h] [rbp-20h] BYREF
			//   TextureDesc v62; // [rsp+148h] [rbp+40h] BYREF
			//   TextureDesc v63; // [rsp+1A8h] [rbp+A0h] BYREF
			//   TextureDesc v64; // [rsp+208h] [rbp+100h] BYREF
			// 
			//   if ( !byte_18D919574 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FD3F0);
			//     sub_18003C530(&off_18D4FD3E0);
			//     sub_18003C530(&off_18D4FD3E8);
			//     byte_18D919574 = 1;
			//   }
			//   v60 = 0LL;
			//   sub_1802F01E0(&v58, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2682, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2682, 0LL);
			//     if ( Patch )
			//     {
			//       v44 = *(_OWORD *)&builder.m_RenderGraph;
			//       *(_OWORD *)&v59.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//       *(_OWORD *)&v59.m_RenderGraph = v44;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_982(
			//         Patch,
			//         (Object *)this,
			//         input,
			//         (Object *)renderGraph,
			//         (Object *)camera,
			//         &v59,
			//         (Object *)passData,
			//         0LL);
			//       return;
			//     }
			// LABEL_23:
			//     sub_180B536AC(Patch, enableFP32Depths);
			//   }
			//   if ( !camera )
			//     goto LABEL_23;
			//   m_volumeComponentsData = camera.fields.m_volumeComponentsData;
			//   if ( !m_volumeComponentsData )
			//     goto LABEL_23;
			//   m_GTAmbientOcclusion = m_volumeComponentsData.fields.m_GTAmbientOcclusion;
			//   qualityLevel = input.qualityLevel;
			//   LOBYTE(v60) = 1;
			//   HIDWORD(v60) = 1;
			//   if ( !passData )
			//     goto LABEL_23;
			//   passData.fields.qualityLevel = qualityLevel;
			//   if ( !m_GTAmbientOcclusion )
			//     goto LABEL_23;
			//   enableFP32Depths = m_GTAmbientOcclusion.fields.enableFP32Depths;
			//   if ( !enableFP32Depths )
			//     goto LABEL_23;
			//   passData.fields.enableFP32Depths = sub_1800023D0(10LL, enableFP32Depths);
			//   passData.fields.enableBentNormals = 0;
			//   si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18C371170);
			//   passData.fields.enableUpsample = passData.fields.qualityLevel > 0;
			//   passData.fields.param0 = si128;
			//   enableFP32Depths = m_GTAmbientOcclusion.fields.finalValuePower;
			//   if ( !enableFP32Depths )
			//     goto LABEL_23;
			//   v17 = sub_18003F9B0(10LL, enableFP32Depths);
			//   CameraFrameCount = HG::Rendering::Runtime::HGCamera::GetCameraFrameCount(camera, 0LL);
			//   enableFP32Depths = m_GTAmbientOcclusion.fields.depthMIPSamplingOffset;
			//   if ( !enableFP32Depths )
			//     goto LABEL_23;
			//   v57.y = v17;
			//   v57.x = 2.0;
			//   v57.z = (float)(CameraFrameCount & 0x3F);
			//   v57.w = sub_18003F9B0(10LL, enableFP32Depths);
			//   passData.fields.param1 = v57;
			//   enableFP32Depths = m_GTAmbientOcclusion.fields.denoisePasses;
			//   if ( !enableFP32Depths )
			//     goto LABEL_23;
			//   v19 = (unsigned int)sub_18003ED00(10LL) ? 1067030938 : 1176256512;
			//   *(_QWORD *)&v57.x = v19;
			//   v57.z = 0.050000001;
			//   v57.w = 1.5;
			//   passData.fields.param2 = v57;
			//   v20 = HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField);
			//   m_X = (float)camera.fields._sceneRTSize_k__BackingField.m_X;
			//   v22 = (int)HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField) / 2;
			//   v23 = (int)HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField) % 2;
			//   v57.x = (float)(camera.fields._sceneRTSize_k__BackingField.m_X / 2);
			//   v24 = _mm_cvtsi32_si128(v22);
			//   v25 = HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField);
			//   v57.z = (float)(1.0 / m_X) + (float)(1.0 / m_X);
			//   LODWORD(v57.y) = _mm_cvtepi32_ps(v24).m128_u32[0];
			//   v57.w = (float)(1.0 / (float)(int)v25) + (float)(1.0 / (float)(int)v25);
			//   passData.fields.halfScreenSize = v57;
			//   passData.fields.screenSizeInt = camera.fields._sceneRTSize_k__BackingField;
			//   LODWORD(v57.x) = sub_182592070(v20, v23, 2);
			//   LODWORD(v57.y) = sub_182592070(v27, v26, v28);
			//   passData.fields.halfScreenSizeInt = *(Vector2Int *)&v57.x;
			//   passData.fields.sceneDepthRT = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                      (TextureHandle *)&v57,
			//                                      builder,
			//                                      &input.sceneDepth,
			//                                      0LL);
			//   v57 = (Vector4)*HG::Rendering::Runtime::GBufferOutput::GetGBufferAttachment(
			//                     (TextureHandle *)&v57,
			//                     &input.gBufferOutput,
			//                     GBufferID__Enum_GBufferB,
			//                     0LL);
			//   passData.fields.gBuffer1 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                  (TextureHandle *)&v59,
			//                                  builder,
			//                                  (TextureHandle *)&v57,
			//                                  0LL);
			//   passData.fields.gBufferMV = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                   (TextureHandle *)&v59,
			//                                   builder,
			//                                   &input.sceneMV,
			//                                   0LL);
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//     &v58,
			//     passData.fields.halfScreenSizeInt.m_X,
			//     passData.fields.halfScreenSizeInt.m_Y,
			//     0LL);
			//   v29 = passData.fields.enableFP32Depths;
			//   *(_WORD *)&v58.enableRandomWrite = 257;
			//   v58.autoGenerateMips = 0;
			//   v58.name = (String *)"DepthBufferMipChain";
			//   v58.colorFormat = v29 ? 49 : 45;
			//   sub_1800054D0((OneofDescriptor *)&v58.name, v30, v31, v32, v45, v49, v53);
			//   v33 = v60;
			//   v58.fastMemoryDesc.residencyFraction = 1.0;
			//   *(_QWORD *)&v58.fastMemoryDesc.inFastMemory = v60;
			//   v62 = v58;
			//   if ( !renderGraph )
			//     goto LABEL_23;
			//   v57 = (Vector4)*HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                     (TextureHandle *)&v59,
			//                     renderGraph,
			//                     &v62,
			//                     0LL);
			//   passData.fields.depthsMIP = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                                   (TextureHandle *)&v59,
			//                                   builder,
			//                                   (TextureHandle *)&v57,
			//                                   0LL);
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//     &v58,
			//     passData.fields.halfScreenSizeInt.m_X,
			//     passData.fields.halfScreenSizeInt.m_Y,
			//     0LL);
			//   v58.name = (String *)"OutAOTerm";
			//   v58.colorFormat = 5;
			//   *(_WORD *)&v58.enableRandomWrite = 1;
			//   v58.autoGenerateMips = 0;
			//   sub_1800054D0((OneofDescriptor *)&v58.name, v34, v35, v36, v46, v50, v54);
			//   v58.fastMemoryDesc.residencyFraction = 1.0;
			//   *(_QWORD *)&v58.fastMemoryDesc.inFastMemory = v33;
			//   v61 = v58;
			//   passData.fields.mainAOTermRT = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                      (TextureHandle *)&v59,
			//                                      builder,
			//                                      &v61,
			//                                      0LL);
			//   passData.fields.blurAOTermRT = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                      (TextureHandle *)&v59,
			//                                      builder,
			//                                      &v61,
			//                                      0LL);
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//     &v58,
			//     passData.fields.halfScreenSizeInt.m_X,
			//     passData.fields.halfScreenSizeInt.m_Y,
			//     0LL);
			//   v58.colorFormat = 48;
			//   v58.wrapMode = 1;
			//   v58.filterMode = 1;
			//   *(_WORD *)&v58.enableRandomWrite = 1;
			//   v58.autoGenerateMips = 0;
			//   v63 = v58;
			//   this.fields.m_currTemporalTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                           (TextureHandle *)&v59,
			//                                           renderGraph,
			//                                           &v63,
			//                                           0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_prevTemporalTexture, 0LL)
			//     && this.fields.m_temporalTextureWidth == passData.fields.halfScreenSizeInt.m_X
			//     && this.fields.m_temporalTextureHeight == passData.fields.halfScreenSizeInt.m_Y )
			//   {
			//     passData.fields.param2.y = 1.0;
			//     mainAOTermRT = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                       (TextureHandle *)&v59,
			//                       builder,
			//                       &this.fields.m_prevTemporalTexture,
			//                       0LL);
			//   }
			//   else
			//   {
			//     passData.fields.param2.y = 0.0;
			//     *(Vector2Int *)&this.fields.m_temporalTextureWidth = passData.fields.halfScreenSizeInt;
			//     mainAOTermRT = passData.fields.mainAOTermRT;
			//   }
			//   passData.fields.previousAOTermRT = mainAOTermRT;
			//   passData.fields.currentAOTermRT = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                                         (TextureHandle *)&v59,
			//                                         builder,
			//                                         &this.fields.m_currTemporalTexture,
			//                                         0LL);
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//     &v58,
			//     passData.fields.screenSizeInt.m_X,
			//     passData.fields.screenSizeInt.m_Y,
			//     0LL);
			//   v58.name = (String *)"UpsampleAOTerm";
			//   v58.colorFormat = 5;
			//   *(_WORD *)&v58.enableRandomWrite = 1;
			//   v58.autoGenerateMips = 0;
			//   sub_1800054D0((OneofDescriptor *)&v58.name, v38, v39, v40, v47, v51, v55);
			//   v58.fastMemoryDesc.residencyFraction = 1.0;
			//   *(_QWORD *)&v58.fastMemoryDesc.inFastMemory = v33;
			//   v64 = v58;
			//   v57 = (Vector4)*HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                     (TextureHandle *)&v59,
			//                     renderGraph,
			//                     &v64,
			//                     0LL);
			//   passData.fields.upsampleAOTermRT = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                                          (TextureHandle *)&v59,
			//                                          builder,
			//                                          (TextureHandle *)&v57,
			//                                          0LL);
			//   passData.fields.GTAmbientOcclusionCS = this.fields.m_shader;
			//   sub_1800054D0((OneofDescriptor *)&passData.fields.GTAmbientOcclusionCS, v41, v42, v43, v48, v52, v56);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::GTAOPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         GTAOPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2683, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2683, 0LL);
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
			// void HG::Rendering::Runtime::GTAOPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         GTAOPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2684, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2684, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref GTAOPassConstructor.PassInput input, ref GTAOPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(GTAOPassConstructor+PassInput ByRef, GTAOPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::GTAOPassConstructor::ConstructPass(
			//         GTAOPassConstructor *this,
			//         GTAOPassConstructor_PassInput *input,
			//         GTAOPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   ProfilingSampler *v14; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   GTAOPassConstructor_GTAmbientOcclusionPassData *v22; // [rsp+40h] [rbp-88h] BYREF
			//   Il2CppExceptionWrapper *v23; // [rsp+48h] [rbp-80h] BYREF
			//   HGRenderGraphBuilder v24; // [rsp+50h] [rbp-78h] BYREF
			//   HGRenderGraphBuilder v25; // [rsp+70h] [rbp-58h] BYREF
			//   HGRenderGraphBuilder v26; // [rsp+90h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919575 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GTAOPassConstructor::GTAmbientOcclusionPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GTAOPassConstructor::GTAmbientOcclusionPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FD388);
			//     byte_18D919575 = 1;
			//   }
			//   v22 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2685, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2685, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v21, v20);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_983(
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
			//     if ( !HG::Rendering::Runtime::HGCamera::get_aoEnable(camera, 0LL) )
			//       goto LABEL_12;
			//     if ( !camera.fields.camera )
			//       sub_180B536AC(v13, v12);
			//     if ( UnityEngine::Camera::get_orthographic(camera.fields.camera, 0LL) )
			//     {
			// LABEL_12:
			//       if ( !renderGraph )
			//         sub_180B536AC(v13, v12);
			//       *output = *(GTAOPassConstructor_PassOutput *)HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                                                      (TextureHandle *)&v24,
			//                                                      renderGraph,
			//                                                      this.fields.m_defaultTexture,
			//                                                      0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       this.fields.m_currTemporalTexture = *(TextureHandle *)sub_182E7CCD0(&v24);
			//     }
			//     else
			//     {
			//       v14 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x48u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !renderGraph )
			//         sub_180B536AC(v16, v15);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v24,
			//         renderGraph,
			//         (String *)"GT Ambient Occlusion",
			//         (Object **)&v22,
			//         v14,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GTAOPassConstructor::GTAmbientOcclusionPassData>);
			//       v25 = v24;
			//       v24.m_RenderPass = 0LL;
			//       v24.m_Resources = (HGRenderGraphResourceRegistry *)&v25;
			//       try
			//       {
			//         v26 = v25;
			//         HG::Rendering::Runtime::GTAOPassConstructor::Prepare(this, input, renderGraph, camera, &v26, v22, 0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v25, 0, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v25,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GTAOPassConstructor.static_fields.s_GTAmbientOcclusionRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GTAOPassConstructor::GTAmbientOcclusionPassData>);
			//         if ( !v22 )
			//           sub_1802DC2C8(v18, v17);
			//         *output = (GTAOPassConstructor_PassOutput)v22.fields.upsampleAOTermRT;
			//       }
			//       catch ( Il2CppExceptionWrapper *v23 )
			//       {
			//         v24.m_RenderPass = (HGRenderGraphPass *)v23.ex;
			//       }
			//       sub_180222690(&v24);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::GTAOPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         GTAOPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rcx
			//   TextureHandle *v6; // rax
			//   HGRenderGraph *renderGraph; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v9; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919576 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FD3A0);
			//     byte_18D919576 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2686, 0LL) )
			//   {
			//     if ( input.passSkipped )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       this.fields.m_currTemporalTexture = *(TextureHandle *)sub_182E7CCD0(&v9);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_currTemporalTexture, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v6 = (TextureHandle *)sub_182E7CCD0(&v9);
			// LABEL_10:
			//       this.fields.m_prevTemporalTexture = *v6;
			//       return;
			//     }
			//     renderGraph = input.renderGraph;
			//     if ( renderGraph )
			//     {
			//       v6 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//              &v9,
			//              renderGraph,
			//              &this.fields.m_currTemporalTexture,
			//              1,
			//              (String *)"GTAOPass",
			//              0LL);
			//       goto LABEL_10;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v5, renderGraph);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2686, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::GTAOPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         GTAOPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2687, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2687, 0LL);
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

		private const int GTAO_DEPTH_MIP_LEVELS = 5;

		private const int GTAO_NUMTHREADS_X = 8;

		private const int GTAO_NUMTHREADS_Y = 8;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static string[] m_GTAmbientOcclusionMainPassKernel;

		private int m_temporalTextureWidth;

		private int m_temporalTextureHeight;

		private TextureHandle m_prevTemporalTexture;

		private TextureHandle m_currTemporalTexture;

		private RTHandle m_defaultTexture;

		private ComputeShader m_shader;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<GTAOPassConstructor.GTAmbientOcclusionPassData> s_GTAmbientOcclusionRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 72)]
		internal struct PassInput
		{
			internal TextureHandle sceneDepth;

			internal TextureHandle sceneMV;

			internal GBufferOutput gBufferOutput;

			internal int qualityLevel;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassOutput
		{
			internal TextureHandle indirectAmbientOcclusionTexture;
		}

		private class GTAmbientOcclusionPassData
		{
			public GTAmbientOcclusionPassData()
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

			public bool enableFP32Depths;

			public bool enableBentNormals;

			public bool enableUpsample;

			public int denoisePassCount;

			public int qualityLevel;

			public Vector4 param0;

			public Vector4 param1;

			public Vector4 param2;

			public Vector4 halfScreenSize;

			public Vector2Int screenSizeInt;

			public Vector2Int halfScreenSizeInt;

			public TextureHandle sceneDepthRT;

			public TextureHandle gBuffer1;

			public TextureHandle gBufferMV;

			public TextureHandle depthsMIP;

			public TextureHandle mainAOTermRT;

			public TextureHandle previousAOTermRT;

			public TextureHandle currentAOTermRT;

			public TextureHandle blurAOTermRT;

			public TextureHandle upsampleAOTermRT;

			public TextureHandle debugRT;

			public ComputeShader GTAmbientOcclusionCS;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 80)]
		public struct GTAOData
		{
			public Vector4 param0;

			public Vector4 param1;

			public Vector4 param2;

			public Vector4 param3;

			public Vector4 halfScreenSize;
		}
	}
}
