using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class DepthOfFieldPassConstructor : IPassConstructor
	{
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool enable
		{
			get
			{
				// // Boolean get_changed()
				// bool Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_changed(
				//         ValueWatcher_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.NiVDAueHECEJqGCNLxcjNXRtPmUC;
				// }
				// 
				return default(bool);
			}
		}

		public DepthOfFieldPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // DepthOfFieldPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::DepthOfFieldPassConstructor::DepthOfFieldPassConstructor(
			//         DepthOfFieldPassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v7; // rdx
			//   __int64 v8; // rcx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   TextureHandle v11; // xmm0
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *v14; // rax
			//   OneofDescriptorProto *v15; // rdx
			//   FileDescriptor *v16; // r8
			//   MessageDescriptor *v17; // r9
			//   MaterialPropertyBlock *v18; // rdi
			//   OneofDescriptorProto *v19; // rdx
			//   FileDescriptor *v20; // r8
			//   MessageDescriptor *v21; // r9
			//   String__Array *v22; // [rsp+20h] [rbp-18h] BYREF
			//   String *v23; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v24; // [rsp+30h] [rbp-8h]
			//   String__Array *v25; // [rsp+60h] [rbp+28h]
			//   String *v26; // [rsp+68h] [rbp+30h]
			//   MethodInfo *v27; // [rsp+70h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDA63 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D8EDA63 = 1;
			//   }
			//   if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle, materialCollector);
			//   this.fields.m_currentSceneColorTexture = *(TextureHandle *)sub_182E7CCD0(&v22);
			//   v11 = *(TextureHandle *)sub_182E7CCD0(&v22);
			//   defaultResources = resources.defaultResources;
			//   this.fields.m_previousSceneColorTexture = v11;
			//   if ( !defaultResources
			//     || (shaders = defaultResources.fields.shaders) == 0LL
			//     || (this.fields.m_shader = shaders.fields.circleDepthOfFieldCS,
			//         sub_1800054D0((OneofDescriptor *)&this.fields.m_shader, v7, v9, v10, v22, v23, v24),
			//         !resources.defaultResources)
			//     || (v14 = resources.defaultResources.fields.shaders) == 0LL
			//     || !materialCollector
			//     || (this.fields.m_mobileMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                           materialCollector,
			//                                           v14.fields.depthOfFieldMobilePS,
			//                                           0,
			//                                           0LL),
			//         sub_1800054D0((OneofDescriptor *)&this.fields.m_mobileMaterial, v15, v16, v17, v22, v23, v24),
			//         (v18 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock)) == 0LL) )
			//   {
			//     sub_180B536AC(v8, v7);
			//   }
			//   v18.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//   this.fields.m_mbp = v18;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_mbp, v19, v20, v21, v25, v26, v27);
			// }
			// 
		}

		private void Prepare(ref DepthOfFieldPassConstructor.PassInput input, HGRenderGraph renderGraph, HGCamera camera, HGRenderGraphBuilder builder, DepthOfFieldPassConstructor.CircleDepthOfFieldPassData passData)
		{
			// // Void Prepare(DepthOfFieldPassConstructor+PassInput ByRef, HGRenderGraph, HGCamera, HGRenderGraphBuilder, DepthOfFieldPassConstructor+CircleDepthOfFieldPassData)
			// void HG::Rendering::Runtime::DepthOfFieldPassConstructor::Prepare(
			//         DepthOfFieldPassConstructor *this,
			//         DepthOfFieldPassConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         HGRenderGraphBuilder *builder,
			//         DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *passData,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rbx
			//   HGDepthOfField *m_depthOfField; // rbx
			//   float v15; // xmm12_4
			//   bool usePhysicalProperties; // al
			//   Camera_GateFitMode__Enum gateFit; // eax
			//   float v18; // xmm7_4
			//   float focalLength; // xmm0_4
			//   float v20; // xmm6_4
			//   float m_Aperture; // xmm10_4
			//   float v22; // xmm0_4
			//   __int128 v23; // xmm1
			//   float m_FocusDistance; // xmm8_4
			//   float v25; // xmm6_4
			//   float farClipPlane; // xmm0_4
			//   float v27; // xmm11_4
			//   float v28; // xmm0_4
			//   float v29; // xmm7_4
			//   float v30; // xmm0_4
			//   float v31; // xmm13_4
			//   float v32; // xmm0_4
			//   float v33; // xmm10_4
			//   float v34; // xmm7_4
			//   __int64 v35; // rdx
			//   int v36; // ecx
			//   float v37; // xmm0_4
			//   float nearFocusStart; // xmm15_4
			//   int v39; // xmm8_4
			//   float v40; // xmm0_4
			//   float nearRadius; // xmm10_4
			//   float v42; // xmm7_4
			//   float farRadius; // xmm6_4
			//   float farFocusStart; // xmm13_4
			//   float farFocusEnd; // xmm14_4
			//   __int64 v46; // rbx
			//   char v47; // dl
			//   __int64 v48; // rcx
			//   int v49; // r8d
			//   double v50; // xmm0_8
			//   float x; // xmm1_4
			//   Vector4 v52; // xmm0
			//   Vector4 v53; // xmm0
			//   __int64 v54; // rax
			//   float v55; // xmm1_4
			//   float v56; // xmm2_4
			//   char v57; // dl
			//   __int64 v58; // rcx
			//   int v59; // r8d
			//   __int64 v60; // rax
			//   float m_X; // xmm1_4
			//   __m128i v62; // xmm0
			//   __int64 v63; // rax
			//   char v64; // dl
			//   __int64 v65; // rcx
			//   int v66; // r8d
			//   char v67; // dl
			//   __int64 v68; // rcx
			//   int v69; // r8d
			//   OneofDescriptorProto *v70; // rdx
			//   FileDescriptor *v71; // r8
			//   int32_t v72; // r9d
			//   OneofDescriptorProto *v73; // rdx
			//   FileDescriptor *v74; // r8
			//   MessageDescriptor *v75; // r9
			//   OneofDescriptorProto *v76; // rdx
			//   FileDescriptor *v77; // r8
			//   MessageDescriptor *v78; // r9
			//   OneofDescriptorProto *v79; // rdx
			//   FileDescriptor *v80; // r8
			//   MessageDescriptor *v81; // r9
			//   bool IsValid; // al
			//   TextureHandle *p_sceneColor; // r8
			//   OneofDescriptorProto *v84; // rdx
			//   FileDescriptor *v85; // r8
			//   MessageDescriptor *v86; // r9
			//   OneofDescriptorProto *v87; // rdx
			//   FileDescriptor *v88; // r8
			//   MessageDescriptor *v89; // r9
			//   OneofDescriptorProto *v90; // rdx
			//   FileDescriptor *v91; // r8
			//   MessageDescriptor *v92; // r9
			//   TextureDesc *TextureDescRef; // rax
			//   Color clearColor; // xmm1
			//   OneofDescriptorProto *v95; // rdx
			//   FileDescriptor *v96; // r8
			//   MessageDescriptor *v97; // r9
			//   __int128 v98; // xmm1
			//   String__Array *v99; // [rsp+28h] [rbp-E0h]
			//   String__Array *v100; // [rsp+28h] [rbp-E0h]
			//   String__Array *v101; // [rsp+28h] [rbp-E0h]
			//   String__Array *v102; // [rsp+28h] [rbp-E0h]
			//   String__Array *v103; // [rsp+28h] [rbp-E0h]
			//   String__Array *v104; // [rsp+28h] [rbp-E0h]
			//   String__Array *v105; // [rsp+28h] [rbp-E0h]
			//   String__Array *v106; // [rsp+28h] [rbp-E0h]
			//   String *v107; // [rsp+30h] [rbp-D8h]
			//   String *v108; // [rsp+30h] [rbp-D8h]
			//   String *v109; // [rsp+30h] [rbp-D8h]
			//   String *v110; // [rsp+30h] [rbp-D8h]
			//   String *v111; // [rsp+30h] [rbp-D8h]
			//   String *v112; // [rsp+30h] [rbp-D8h]
			//   String *v113; // [rsp+30h] [rbp-D8h]
			//   String *v114; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v115; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v116; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v117; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v118; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v119; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v120; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v121; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v122; // [rsp+38h] [rbp-D0h]
			//   HGRenderGraphBuilder v123; // [rsp+48h] [rbp-C0h] BYREF
			//   float m_Anamorphism; // [rsp+68h] [rbp-A0h]
			//   Vector2 sensorSize; // [rsp+78h] [rbp-90h]
			//   TextureDesc v126; // [rsp+88h] [rbp-80h] BYREF
			//   TextureHandle v127; // [rsp+E8h] [rbp-20h] BYREF
			//   TextureDesc v128; // [rsp+F8h] [rbp-10h] BYREF
			//   TextureDesc v129; // [rsp+158h] [rbp+50h] BYREF
			//   TextureDesc v130; // [rsp+1B8h] [rbp+B0h] BYREF
			//   TextureDesc v131; // [rsp+218h] [rbp+110h] BYREF
			//   TextureDesc v132; // [rsp+278h] [rbp+170h] BYREF
			//   TextureDesc v133; // [rsp+2D8h] [rbp+1D0h] BYREF
			//   TextureDesc v134; // [rsp+338h] [rbp+230h] BYREF
			//   TextureDesc v135; // [rsp+398h] [rbp+290h] BYREF
			// 
			//   if ( !byte_18D91951F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FADC0);
			//     sub_18003C530(&off_18D4FADD0);
			//     sub_18003C530(&off_18D4FADE0);
			//     sub_18003C530(&off_18D4FADF8);
			//     sub_18003C530(&off_18D4FAD98);
			//     sub_18003C530(&off_18D4FADA0);
			//     sub_18003C530(&off_18D4FADB0);
			//     byte_18D91951F = 1;
			//   }
			//   sub_1802F01E0(&v130, 0LL, 96LL);
			//   sub_1802F01E0(&v126, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2542, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2542, 0LL);
			//     if ( Patch )
			//     {
			//       v98 = *(_OWORD *)&builder.m_RenderGraph;
			//       *(_OWORD *)&v123.m_RenderPass = *(_OWORD *)&builder.m_RenderPass;
			//       *(_OWORD *)&v123.m_RenderGraph = v98;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_935(
			//         Patch,
			//         (Object *)this,
			//         input,
			//         (Object *)renderGraph,
			//         (Object *)camera,
			//         &v123,
			//         (Object *)passData,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_42;
			//   }
			//   if ( !camera )
			//     goto LABEL_42;
			//   m_volumeComponentsData = camera.fields.m_volumeComponentsData;
			//   if ( !m_volumeComponentsData )
			//     goto LABEL_42;
			//   m_depthOfField = m_volumeComponentsData.fields.m_depthOfField;
			//   v15 = 0.5;
			//   if ( !m_depthOfField )
			//     goto LABEL_42;
			//   if ( !m_depthOfField.fields.scale )
			//     v15 = 1.0;
			//   if ( m_depthOfField.fields.focusMode )
			//   {
			//     usePhysicalProperties = 0;
			//   }
			//   else
			//   {
			//     Patch = (ILFixDynamicMethodWrapper_2 *)camera.fields.camera;
			//     if ( !Patch )
			//       goto LABEL_42;
			//     usePhysicalProperties = UnityEngine::Camera::get_usePhysicalProperties((Camera *)Patch, 0LL);
			//   }
			//   if ( !passData )
			//     goto LABEL_42;
			//   passData.fields.usePhysicalCamera = usePhysicalProperties;
			//   passData.fields.quality = input.quality;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)camera.fields.camera;
			//   if ( !Patch )
			//     goto LABEL_42;
			//   gateFit = UnityEngine::Camera::get_gateFit((Camera *)Patch, 0LL);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)camera.fields.camera;
			//   if ( gateFit == Camera_GateFitMode__Enum_Horizontal )
			//   {
			//     if ( !Patch )
			//       goto LABEL_42;
			//     sensorSize = UnityEngine::Camera::get_sensorSize((Camera *)Patch, 0LL);
			//     v18 = (float)(0.5 / sensorSize.x) * (float)camera.fields._taauRTSize_k__BackingField.m_X;
			//   }
			//   else
			//   {
			//     if ( !Patch )
			//       goto LABEL_42;
			//     sensorSize = UnityEngine::Camera::get_sensorSize((Camera *)Patch, 0LL);
			//     v18 = (float)(int)HIDWORD(*(_QWORD *)&camera.fields._taauRTSize_k__BackingField) * (float)(0.5 / sensorSize.x);
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)camera.fields.camera;
			//   if ( !Patch )
			//     goto LABEL_42;
			//   focalLength = UnityEngine::Camera::get_focalLength((Camera *)Patch, 0LL);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)camera.fields.camera;
			//   v20 = focalLength;
			//   m_Aperture = camera.fields._physicalParameters_k__BackingField.m_Aperture;
			//   m_Anamorphism = camera.fields._physicalParameters_k__BackingField.m_Anamorphism;
			//   *(_OWORD *)&v123.m_RenderGraph = *(_OWORD *)&camera.fields._physicalParameters_k__BackingField.m_BladeCount;
			//   if ( !Patch )
			//     goto LABEL_42;
			//   v22 = UnityEngine::Camera::get_focalLength((Camera *)Patch, 0LL);
			//   v23 = *(_OWORD *)&camera.fields._physicalParameters_k__BackingField.m_BladeCount;
			//   m_Anamorphism = camera.fields._physicalParameters_k__BackingField.m_Anamorphism;
			//   *(_OWORD *)&v123.m_RenderGraph = v23;
			//   m_FocusDistance = camera.fields._physicalParameters_k__BackingField.m_FocusDistance;
			//   Patch = (ILFixDynamicMethodWrapper_2 *)camera.fields.camera;
			//   v25 = (float)((float)((float)(v20 / m_Aperture) * (float)(v22 / 1000.0)) * v18)
			//       / fmaxf(m_FocusDistance - (float)(v22 / 1000.0), 0.000001);
			//   if ( !Patch )
			//     goto LABEL_42;
			//   farClipPlane = UnityEngine::Camera::get_farClipPlane((Camera *)Patch, 0LL);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)camera.fields.camera;
			//   v27 = (float)(1.0 - (float)(m_FocusDistance / farClipPlane)) * v25;
			//   if ( !Patch )
			//     goto LABEL_42;
			//   v28 = UnityEngine::Camera::get_farClipPlane((Camera *)Patch, 0LL);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)camera.fields.camera;
			//   v29 = v28;
			//   if ( !Patch )
			//     goto LABEL_42;
			//   v30 = UnityEngine::Camera::get_nearClipPlane((Camera *)Patch, 0LL);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)camera.fields.camera;
			//   v31 = v30;
			//   if ( !Patch )
			//     goto LABEL_42;
			//   v32 = UnityEngine::Camera::get_farClipPlane((Camera *)Patch, 0LL);
			//   Patch = (ILFixDynamicMethodWrapper_2 *)camera.fields.camera;
			//   v33 = v32;
			//   if ( !Patch )
			//     goto LABEL_42;
			//   v34 = (float)(v29 - v31) * (float)(m_FocusDistance * v25);
			//   v37 = UnityEngine::Camera::get_nearClipPlane((Camera *)Patch, 0LL);
			//   nearFocusStart = m_depthOfField.fields.nearFocusStart;
			//   v39 = 0;
			//   v40 = v37 * v33;
			//   nearRadius = m_depthOfField.fields.nearRadius;
			//   v42 = v34 / v40;
			//   sensorSize.x = m_depthOfField.fields.nearFocusEnd;
			//   if ( nearRadius < 0.0 )
			//   {
			//     nearRadius = 0.0;
			//   }
			//   else if ( nearRadius > input.depthOfFieldMaxRadius )
			//   {
			//     nearRadius = input.depthOfFieldMaxRadius;
			//   }
			//   farRadius = m_depthOfField.fields.farRadius;
			//   farFocusStart = m_depthOfField.fields.farFocusStart;
			//   farFocusEnd = m_depthOfField.fields.farFocusEnd;
			//   if ( farRadius < 0.0 )
			//   {
			//     farRadius = 0.0;
			//   }
			//   else if ( farRadius > input.depthOfFieldMaxRadius )
			//   {
			//     farRadius = input.depthOfFieldMaxRadius;
			//   }
			//   v46 = HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField);
			//   v127.handle = (ResourceHandle)camera.fields._sceneRTSize_k__BackingField;
			//   v123.m_RenderPass = (HGRenderGraphPass *)__PAIR64__(LODWORD(v42), LODWORD(v27));
			//   *(float *)&v123.m_Resources = v15;
			//   v50 = sub_1802EB1B0(v36, v35);
			//   x = sensorSize.x;
			//   HIDWORD(v123.m_Resources) = LODWORD(v50);
			//   v52 = *(Vector4 *)&v123.m_RenderPass;
			//   HIDWORD(v123.m_Resources) = 0;
			//   *(float *)&v123.m_RenderPass = nearFocusStart;
			//   passData.fields.param0 = v52;
			//   *((float *)&v123.m_RenderPass + 1) = x;
			//   *(float *)&v123.m_Resources = (float)((float)(int)v46 * nearRadius) / 1440.0;
			//   v53 = *(Vector4 *)&v123.m_RenderPass;
			//   HIDWORD(v123.m_Resources) = 0;
			//   *(float *)&v123.m_RenderPass = farFocusStart;
			//   passData.fields.param1 = v53;
			//   *((float *)&v123.m_RenderPass + 1) = farFocusEnd;
			//   *(float *)&v123.m_Resources = (float)((float)v127.handle._type_k__BackingField * farRadius) / 1440.0;
			//   passData.fields.param2 = *(Vector4 *)&v123.m_RenderPass;
			//   if ( camera.fields.prevTransformReset )
			//     v39 = 1065353216;
			//   LODWORD(v123.m_RenderPass) = 0;
			//   v123.m_Resources = 0LL;
			//   HIDWORD(v123.m_RenderPass) = v39;
			//   passData.fields.param3 = (Vector4)(unsigned __int64)v123.m_RenderPass;
			//   passData.fields.screenSize = (Vector4)_mm_loadu_si128((const __m128i *)&camera.fields._sceneRTSizeParam_k__BackingField);
			//   passData.fields.screenSizeInt = camera.fields._sceneRTSize_k__BackingField;
			//   v54 = HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField);
			//   v55 = (float)(int)HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField);
			//   *(float *)&v123.m_RenderPass = (float)camera.fields._sceneRTSize_k__BackingField.m_X * v15;
			//   v56 = 1.0 / (float)camera.fields._sceneRTSize_k__BackingField.m_X;
			//   *((float *)&v123.m_RenderPass + 1) = v55 * v15;
			//   *(float *)&v123.m_Resources = v56 / v15;
			//   *((float *)&v123.m_Resources + 1) = (float)(1.0 / (float)(int)v54) / v15;
			//   passData.fields.downsampleScreenSize = *(Vector4 *)&v123.m_RenderPass;
			//   LODWORD(sensorSize.x) = sub_182592070(v48, v47, v49);
			//   LODWORD(sensorSize.y) = sub_182592070(v58, v57, v59);
			//   passData.fields.downsampleScreenSizeInt = (Vector2Int)sensorSize;
			//   v60 = HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField);
			//   m_X = (float)camera.fields._sceneRTSize_k__BackingField.m_X;
			//   *(float *)&v123.m_RenderPass = m_X * 0.125;
			//   v62 = _mm_cvtsi32_si128(v60);
			//   v63 = HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField);
			//   *(float *)&v123.m_Resources = (float)(1.0 / m_X) * 8.0;
			//   *((float *)&v123.m_RenderPass + 1) = _mm_cvtepi32_ps(v62).m128_f32[0] * 0.125;
			//   *((float *)&v123.m_Resources + 1) = (float)(1.0 / (float)(int)v63) * 8.0;
			//   passData.fields.tileCoCScreenSize = *(Vector4 *)&v123.m_RenderPass;
			//   LODWORD(sensorSize.x) = sub_182592070(v65, v64, v66);
			//   LODWORD(sensorSize.y) = sub_182592070(v68, v67, v69);
			//   passData.fields.tileCoCScreenSizeInt = (Vector2Int)sensorSize;
			//   passData.fields.sceneColorTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                           (TextureHandle *)&v123,
			//                                           builder,
			//                                           &input.sceneColor,
			//                                           0LL);
			//   passData.fields.sceneDepthTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                           (TextureHandle *)&v123,
			//                                           builder,
			//                                           &input.sceneDepth,
			//                                           0LL);
			//   passData.fields.motionVectorTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                             (TextureHandle *)&v123,
			//                                             builder,
			//                                             &input.motionVectorTexture,
			//                                             0LL);
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//     &v126,
			//     passData.fields.screenSizeInt.m_X,
			//     passData.fields.screenSizeInt.m_Y,
			//     0LL);
			//   v126.name = (String *)"Depth Of Field CoC";
			//   v126.colorFormat = 46;
			//   v126.enableRandomWrite = 1;
			//   sub_1800054D0((OneofDescriptor *)&v126.name, v70, v71, (MessageDescriptor *)1, v99, v107, v115);
			//   v126.wrapMode = v72;
			//   v126.filterMode = v72;
			//   v133 = v126;
			//   passData.fields.cocTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                    (TextureHandle *)&v123,
			//                                    builder,
			//                                    &v133,
			//                                    0LL);
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//     &v126,
			//     passData.fields.downsampleScreenSizeInt.m_X,
			//     passData.fields.downsampleScreenSizeInt.m_Y,
			//     0LL);
			//   v126.colorFormat = 46;
			//   v126.enableRandomWrite = 1;
			//   v126.name = (String *)"Depth Of Field CoC Downsample";
			//   sub_1800054D0((OneofDescriptor *)&v126.name, v73, v74, v75, v100, v108, v116);
			//   v126.wrapMode = 1;
			//   v126.filterMode = 1;
			//   v134 = v126;
			//   passData.fields.downsampleCoCTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                              (TextureHandle *)&v123,
			//                                              builder,
			//                                              &v134,
			//                                              0LL);
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//     &v126,
			//     passData.fields.tileCoCScreenSizeInt.m_X,
			//     passData.fields.tileCoCScreenSizeInt.m_Y,
			//     0LL);
			//   v126.name = (String *)"Depth Of Field Tile CoC";
			//   v126.colorFormat = 49;
			//   v126.enableRandomWrite = 1;
			//   sub_1800054D0((OneofDescriptor *)&v126.name, v76, v77, v78, v101, v109, v117);
			//   v126.wrapMode = 1;
			//   v126.filterMode = 1;
			//   v131 = v126;
			//   passData.fields.tileCoCTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                        (TextureHandle *)&v123,
			//                                        builder,
			//                                        &v131,
			//                                        0LL);
			//   passData.fields.blurTileCoCTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                            (TextureHandle *)&v123,
			//                                            builder,
			//                                            &v131,
			//                                            0LL);
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//     &v126,
			//     passData.fields.downsampleScreenSizeInt.m_X,
			//     passData.fields.downsampleScreenSizeInt.m_Y,
			//     0LL);
			//   v126.name = (String *)"Depth Of Field Color Downsample";
			//   v126.colorFormat = 48;
			//   v126.enableRandomWrite = 1;
			//   sub_1800054D0((OneofDescriptor *)&v126.name, v79, v80, v81, v102, v110, v118);
			//   v126.wrapMode = 1;
			//   v126.filterMode = 1;
			//   v135 = v126;
			//   if ( !renderGraph )
			// LABEL_42:
			//     sub_180B536AC(Patch, v11);
			//   this.fields.m_currentSceneColorTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                (TextureHandle *)&v123,
			//                                                renderGraph,
			//                                                &v135,
			//                                                0LL);
			//   passData.fields.currentDownSampleSceneColorTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                                                            (TextureHandle *)&v123,
			//                                                            builder,
			//                                                            &this.fields.m_currentSceneColorTexture,
			//                                                            0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//   IsValid = HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_previousSceneColorTexture, 0LL);
			//   p_sceneColor = &input.sceneColor;
			//   if ( IsValid )
			//     p_sceneColor = &this.fields.m_previousSceneColorTexture;
			//   passData.fields.previousDownSampleSceneColorTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                                                             (TextureHandle *)&v123,
			//                                                             builder,
			//                                                             p_sceneColor,
			//                                                             0LL);
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//     &v126,
			//     passData.fields.downsampleScreenSizeInt.m_X,
			//     passData.fields.downsampleScreenSizeInt.m_Y,
			//     0LL);
			//   v126.name = (String *)"Depth Of Field Color One Component";
			//   v126.colorFormat = 48;
			//   v126.enableRandomWrite = 1;
			//   sub_1800054D0((OneofDescriptor *)&v126.name, v84, v85, v86, v103, v111, v119);
			//   v126.wrapMode = 1;
			//   v126.filterMode = 1;
			//   v129 = v126;
			//   passData.fields.oneComponentVeritcalTexture0 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                                      (TextureHandle *)&v123,
			//                                                      builder,
			//                                                      &v129,
			//                                                      0LL);
			//   passData.fields.oneComponentVeritcalTexture1 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                                      (TextureHandle *)&v123,
			//                                                      builder,
			//                                                      &v129,
			//                                                      0LL);
			//   passData.fields.oneComponentHorizontalTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                                       (TextureHandle *)&v123,
			//                                                       builder,
			//                                                       &v129,
			//                                                       0LL);
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//     &v126,
			//     passData.fields.downsampleScreenSizeInt.m_X,
			//     passData.fields.downsampleScreenSizeInt.m_Y,
			//     0LL);
			//   v126.name = (String *)"Depth Of Field Color One Component Alpha";
			//   v126.colorFormat = 49;
			//   v126.enableRandomWrite = 1;
			//   sub_1800054D0((OneofDescriptor *)&v126.name, v87, v88, v89, v104, v112, v120);
			//   v126.wrapMode = 1;
			//   v126.filterMode = 1;
			//   v132 = v126;
			//   passData.fields.oneComponentAlphaTexture0 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                                   (TextureHandle *)&v123,
			//                                                   builder,
			//                                                   &v132,
			//                                                   0LL);
			//   passData.fields.oneComponentAlphaTexture1 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                                   (TextureHandle *)&v123,
			//                                                   builder,
			//                                                   &v132,
			//                                                   0LL);
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//     &v126,
			//     passData.fields.downsampleScreenSizeInt.m_X,
			//     passData.fields.downsampleScreenSizeInt.m_Y,
			//     0LL);
			//   v126.name = (String *)"Depth Of Field Color Two Components";
			//   v126.colorFormat = 48;
			//   v126.enableRandomWrite = 1;
			//   sub_1800054D0((OneofDescriptor *)&v126.name, v90, v91, v92, v105, v113, v121);
			//   v126.wrapMode = 1;
			//   v126.filterMode = 1;
			//   v128 = v126;
			//   passData.fields.twoComponentsVerticalTexture0 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                                       (TextureHandle *)&v123,
			//                                                       builder,
			//                                                       &v128,
			//                                                       0LL);
			//   passData.fields.twoComponentsVerticalTexture1 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                                       (TextureHandle *)&v123,
			//                                                       builder,
			//                                                       &v128,
			//                                                       0LL);
			//   passData.fields.twoComponentsVerticalTexture2 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                                       (TextureHandle *)&v123,
			//                                                       builder,
			//                                                       &v128,
			//                                                       0LL);
			//   passData.fields.farHorizontalTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                                              (TextureHandle *)&v123,
			//                                              builder,
			//                                              &v128,
			//                                              0LL);
			//   TextureDescRef = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                      renderGraph,
			//                      &input.sceneColor,
			//                      0LL);
			//   *(_OWORD *)&v130.width = *(_OWORD *)&TextureDescRef.width;
			//   *(_OWORD *)&v130.colorFormat = *(_OWORD *)&TextureDescRef.colorFormat;
			//   *(_OWORD *)&v130.enableRandomWrite = *(_OWORD *)&TextureDescRef.enableRandomWrite;
			//   *(_OWORD *)&v130.bindTextureMS = *(_OWORD *)&TextureDescRef.bindTextureMS;
			//   *(_OWORD *)&v130.fastMemoryDesc.inFastMemory = *(_OWORD *)&TextureDescRef.fastMemoryDesc.inFastMemory;
			//   clearColor = TextureDescRef.clearColor;
			//   v130.enableRandomWrite = 1;
			//   v130.clearColor = clearColor;
			//   *(TextureHandle *)&v123.m_RenderPass = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                             (TextureHandle *)&v123,
			//                                             renderGraph,
			//                                             &v130,
			//                                             0LL);
			//   passData.fields.outputTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                                       &v127,
			//                                       builder,
			//                                       (TextureHandle *)&v123,
			//                                       0LL);
			//   passData.fields.computeShader = this.fields.m_shader;
			//   sub_1800054D0((OneofDescriptor *)&passData.fields.computeShader, v95, v96, v97, v106, v114, v122);
			// }
			// 
		}

		private void PrepareGaussion(ref DepthOfFieldPassConstructor.PassInput input, ref DepthOfFieldPassConstructor.DepthOfFieldData cbData, HGCamera camera)
		{
			// // Void PrepareGaussion(DepthOfFieldPassConstructor+PassInput ByRef, DepthOfFieldPassConstructor+DepthOfFieldData ByRef, HGCamera)
			// void HG::Rendering::Runtime::DepthOfFieldPassConstructor::PrepareGaussion(
			//         DepthOfFieldPassConstructor *this,
			//         DepthOfFieldPassConstructor_PassInput *input,
			//         DepthOfFieldPassConstructor_DepthOfFieldData *cbData,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   Camera *v10; // rcx
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rdi
			//   HGDepthOfField *m_depthOfField; // rdi
			//   float v13; // xmm11_4
			//   Camera_GateFitMode__Enum gateFit; // eax
			//   float v15; // xmm6_4
			//   float focalLength; // xmm0_4
			//   float v17; // xmm8_4
			//   float m_Aperture; // xmm9_4
			//   float v19; // xmm0_4
			//   float m_FocusDistance; // xmm7_4
			//   float v21; // xmm8_4
			//   float farClipPlane; // xmm0_4
			//   float v23; // xmm6_4
			//   float v24; // xmm0_4
			//   float v25; // xmm9_4
			//   float v26; // xmm0_4
			//   float v27; // xmm13_4
			//   float v28; // xmm0_4
			//   float v29; // xmm12_4
			//   float v30; // xmm7_4
			//   float v31; // xmm0_4
			//   float nearRadius; // xmm1_4
			//   float nearFocusEnd; // xmm8_4
			//   float v34; // xmm7_4
			//   float farRadius; // xmm2_4
			//   float farFocusStart; // xmm3_4
			//   float farFocusEnd; // xmm4_4
			//   Vector2Int sceneRTSize_k__BackingField; // rax
			//   Vector4 v39; // xmm0
			//   Vector4 v40; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v42; // [rsp+30h] [rbp-C8h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2543, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2543, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_936(Patch, (Object *)this, input, cbData, (Object *)camera, 0LL);
			//       return;
			//     }
			//     goto LABEL_34;
			//   }
			//   if ( !camera )
			//     goto LABEL_34;
			//   m_volumeComponentsData = camera.fields.m_volumeComponentsData;
			//   if ( !m_volumeComponentsData )
			//     goto LABEL_34;
			//   m_depthOfField = m_volumeComponentsData.fields.m_depthOfField;
			//   if ( !m_depthOfField )
			//     goto LABEL_34;
			//   if ( m_depthOfField.fields.scale )
			//     v13 = 0.5;
			//   else
			//     v13 = 1.0;
			//   if ( !m_depthOfField.fields.focusMode )
			//   {
			//     v10 = camera.fields.camera;
			//     if ( !v10 )
			//       goto LABEL_34;
			//     UnityEngine::Camera::get_usePhysicalProperties(v10, 0LL);
			//   }
			//   v10 = camera.fields.camera;
			//   if ( !v10 )
			//     goto LABEL_34;
			//   gateFit = UnityEngine::Camera::get_gateFit(v10, 0LL);
			//   v10 = camera.fields.camera;
			//   if ( gateFit == Camera_GateFitMode__Enum_Horizontal )
			//   {
			//     if ( !v10 )
			//       goto LABEL_34;
			//     v15 = (float)(0.5 / UnityEngine::Camera::get_sensorSize(v10, 0LL).x)
			//         * (float)camera.fields._taauRTSize_k__BackingField.m_X;
			//   }
			//   else
			//   {
			//     if ( !v10 )
			//       goto LABEL_34;
			//     v15 = (float)(int)HIDWORD(*(_QWORD *)&camera.fields._taauRTSize_k__BackingField)
			//         * (float)(0.5 / UnityEngine::Camera::get_sensorSize(v10, 0LL).x);
			//   }
			//   v10 = camera.fields.camera;
			//   if ( !v10 )
			//     goto LABEL_34;
			//   focalLength = UnityEngine::Camera::get_focalLength(v10, 0LL);
			//   v10 = camera.fields.camera;
			//   v17 = focalLength;
			//   m_Aperture = camera.fields._physicalParameters_k__BackingField.m_Aperture;
			//   if ( !v10 )
			//     goto LABEL_34;
			//   v19 = UnityEngine::Camera::get_focalLength(v10, 0LL);
			//   m_FocusDistance = camera.fields._physicalParameters_k__BackingField.m_FocusDistance;
			//   v10 = camera.fields.camera;
			//   v21 = (float)((float)((float)(v17 / m_Aperture) * (float)(v19 / 1000.0)) * v15)
			//       / fmaxf(m_FocusDistance - (float)(v19 / 1000.0), 0.000001);
			//   if ( !v10 )
			//     goto LABEL_34;
			//   farClipPlane = UnityEngine::Camera::get_farClipPlane(v10, 0LL);
			//   v10 = camera.fields.camera;
			//   v23 = (float)(1.0 - (float)(m_FocusDistance / farClipPlane)) * v21;
			//   if ( !v10 )
			//     goto LABEL_34;
			//   v24 = UnityEngine::Camera::get_farClipPlane(v10, 0LL);
			//   v10 = camera.fields.camera;
			//   v25 = v24;
			//   if ( !v10
			//     || (v26 = UnityEngine::Camera::get_nearClipPlane(v10, 0LL), v10 = camera.fields.camera, v27 = v26, !v10)
			//     || (v28 = UnityEngine::Camera::get_farClipPlane(v10, 0LL), v10 = camera.fields.camera, v29 = v28, !v10) )
			//   {
			// LABEL_34:
			//     sub_180B536AC(v10, v9);
			//   }
			//   v30 = (float)(m_FocusDistance * v21) * (float)(v25 - v27);
			//   v31 = UnityEngine::Camera::get_nearClipPlane(v10, 0LL);
			//   nearRadius = m_depthOfField.fields.nearRadius;
			//   nearFocusEnd = m_depthOfField.fields.nearFocusEnd;
			//   v34 = v30 / (float)(v31 * v29);
			//   if ( nearRadius < 0.0 )
			//   {
			//     nearRadius = 0.0;
			//   }
			//   else if ( nearRadius > input.depthOfFieldMaxRadius )
			//   {
			//     nearRadius = input.depthOfFieldMaxRadius;
			//   }
			//   farRadius = m_depthOfField.fields.farRadius;
			//   farFocusStart = m_depthOfField.fields.farFocusStart;
			//   farFocusEnd = m_depthOfField.fields.farFocusEnd;
			//   if ( farRadius < 0.0 )
			//   {
			//     farRadius = 0.0;
			//   }
			//   else if ( farRadius > input.depthOfFieldMaxRadius )
			//   {
			//     farRadius = input.depthOfFieldMaxRadius;
			//   }
			//   sceneRTSize_k__BackingField = camera.fields._sceneRTSize_k__BackingField;
			//   *(_QWORD *)&v42.x = __PAIR64__(LODWORD(v34), LODWORD(v23));
			//   *(_QWORD *)&v42.z = LODWORD(v13);
			//   v39 = v42;
			//   v42.w = 0.0;
			//   v42.x = m_depthOfField.fields.nearFocusStart;
			//   cbData.param0 = v39;
			//   v42.y = nearFocusEnd;
			//   cbData.param3 = 0LL;
			//   v42.z = (float)((float)sceneRTSize_k__BackingField.m_Y * nearRadius) / 1440.0;
			//   v40 = v42;
			//   v42.w = 0.0;
			//   *(_QWORD *)&v42.x = __PAIR64__(LODWORD(farFocusEnd), LODWORD(farFocusStart));
			//   cbData.param1 = v40;
			//   v42.z = (float)((float)sceneRTSize_k__BackingField.m_Y * farRadius) / 1440.0;
			//   cbData.param2 = v42;
			//   v42.x = (float)camera.fields._sceneRTSize_k__BackingField.m_X * v13;
			//   v42.y = (float)(int)HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField) * v13;
			//   v42.z = (float)(1.0 / (float)camera.fields._sceneRTSize_k__BackingField.m_X) / v13;
			//   v42.w = (float)(1.0 / (float)(int)HIDWORD(*(_QWORD *)&camera.fields._sceneRTSize_k__BackingField)) / v13;
			//   cbData.downsampleScreenSize = v42;
			// }
			// 
		}

		internal void ConstructPass(ref DepthOfFieldPassConstructor.PassInput input, ref DepthOfFieldPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera)
		{
			// // Void ConstructPass(DepthOfFieldPassConstructor+PassInput ByRef, DepthOfFieldPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=9
			// void HG::Rendering::Runtime::DepthOfFieldPassConstructor::ConstructPass(
			//         DepthOfFieldPassConstructor *this,
			//         DepthOfFieldPassConstructor_PassInput *input,
			//         DepthOfFieldPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   Object *v6; // rsi
			//   DepthOfFieldPassConstructor_PassInput *v7; // r15
			//   DepthOfFieldPassConstructor *v8; // r13
			//   HGCamera *P3; // r14
			//   bool v10; // al
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   int32_t quality; // eax
			//   ProfilingSampler *v14; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rsi
			//   HGDepthOfField *m_depthOfField; // rsi
			//   float v19; // xmm14_4
			//   Camera *camera; // rcx
			//   Camera *v21; // rbx
			//   __int64 (__fastcall *v22)(Camera *); // rax
			//   int v23; // eax
			//   __int64 v24; // rdx
			//   __int64 v25; // rbx
			//   void (__fastcall *v26)(__int64, int32_t *); // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   __m128i v29; // xmm7
			//   void (__fastcall *v30)(__int64, int32_t *); // rax
			//   float v31; // xmm7_4
			//   Camera *v32; // rbx
			//   double (__fastcall *v33)(Camera *); // rax
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   double v36; // xmm0_8
			//   float v37; // xmm8_4
			//   Camera *v38; // rbx
			//   double (__fastcall *v39)(Camera *); // rax
			//   double v40; // xmm0_8
			//   float m_FocusDistance; // xmm9_4
			//   __int64 v42; // rdx
			//   __int64 v43; // rcx
			//   float v44; // xmm6_4
			//   Camera *v45; // rbx
			//   float (__fastcall *v46)(Camera *); // rax
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   float v49; // xmm7_4
			//   Camera *v50; // rbx
			//   double (__fastcall *v51)(Camera *); // rax
			//   __int64 v52; // rdx
			//   __int64 v53; // rcx
			//   double v54; // xmm0_8
			//   float v55; // xmm8_4
			//   Camera *v56; // rbx
			//   double (__fastcall *v57)(Camera *); // rax
			//   __int64 v58; // rdx
			//   __int64 v59; // rcx
			//   double v60; // xmm0_8
			//   float v61; // xmm12_4
			//   Camera *v62; // rbx
			//   double (__fastcall *v63)(Camera *); // rax
			//   __int64 v64; // rdx
			//   __int64 v65; // rcx
			//   double v66; // xmm0_8
			//   Camera *v67; // rbx
			//   float (__fastcall *v68)(Camera *); // rax
			//   unsigned int v69; // xmm8_4
			//   float nearFocusStart; // xmm10_4
			//   float nearFocusEnd; // xmm12_4
			//   float v72; // xmm13_4
			//   float farFocusStart; // xmm6_4
			//   float farFocusEnd; // xmm9_4
			//   float v75; // xmm0_4
			//   float v76; // xmm3_4
			//   float v77; // xmm3_4
			//   __int64 v78; // rcx
			//   float v79; // xmm11_4
			//   ILFixDynamicMethodWrapper_2 *v80; // rax
			//   __int64 v81; // rdx
			//   __int64 v82; // rcx
			//   CBHandle *ConstantBuffer; // rax
			//   __int128 v84; // xmm6
			//   HGRenderGraph *ptr; // xmm7_8
			//   int v86; // esi
			//   Vector2Int sceneRTSize_k__BackingField; // rbx
			//   unsigned __int64 v88; // rdx
			//   signed __int64 v89; // rcx
			//   __int128 v90; // xmm1
			//   __int128 v91; // xmm2
			//   __int128 v92; // xmm3
			//   Color clearColor; // xmm4
			//   unsigned __int64 v94; // r8
			//   signed __int64 v95; // rtt
			//   __int128 v96; // xmm1
			//   __int128 v97; // xmm2
			//   __int128 v98; // xmm3
			//   Color v99; // xmm4
			//   unsigned __int64 v100; // r8
			//   signed __int64 v101; // rtt
			//   DepthOfFieldPassConstructor_PassInput *v102; // r12
			//   ProfilingSampler *v103; // rax
			//   __int64 v104; // rdx
			//   __int64 v105; // rcx
			//   Object *v106; // rax
			//   Object *v107; // rbx
			//   __int64 v108; // rdx
			//   __int64 v109; // rcx
			//   TextureHandle v110; // xmm0
			//   Object *v111; // rdx
			//   int v112; // eax
			//   unsigned __int64 v113; // rdx
			//   unsigned __int64 v114; // r8
			//   char v115; // dl
			//   signed __int64 v116; // rtt
			//   Object *v117; // rdx
			//   Object__Class *m_mbp; // rcx
			//   unsigned __int64 v119; // rdx
			//   unsigned __int64 v120; // r8
			//   signed __int64 v121; // rtt
			//   Object *v122; // rbx
			//   HGCamera_VolumeComponentsData *v123; // rax
			//   HGDepthOfField *v124; // rcx
			//   bool usePhysicalProperties; // al
			//   Camera *v126; // rcx
			//   RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *_9__20_0; // rbx
			//   Object *v128; // r14
			//   RenderFunc_1_System_Object_ *v129; // rax
			//   __int64 v130; // rdx
			//   __int64 v131; // rcx
			//   unsigned __int64 v132; // rdx
			//   char v133; // r8
			//   signed __int64 v134; // rtt
			//   ProfilingSampler *v135; // rax
			//   __int64 v136; // rdx
			//   __int64 v137; // rcx
			//   Object *v138; // rax
			//   Object *v139; // rbx
			//   __int64 v140; // rdx
			//   __int64 v141; // rcx
			//   TextureHandle v142; // xmm0
			//   Object *v143; // rbx
			//   __int64 v144; // rdx
			//   __int64 v145; // rcx
			//   TextureHandle v146; // xmm0
			//   Object *v147; // rdx
			//   int v148; // eax
			//   unsigned __int64 v149; // rdx
			//   unsigned __int64 v150; // r8
			//   char v151; // dl
			//   signed __int64 v152; // rtt
			//   Object *v153; // rdx
			//   Object__Class *v154; // rcx
			//   unsigned __int64 v155; // rdx
			//   unsigned __int64 v156; // r8
			//   char v157; // dl
			//   signed __int64 v158; // rtt
			//   RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *_9__20_1; // rbx
			//   Object *v160; // r14
			//   RenderFunc_1_System_Object_ *v161; // rax
			//   __int64 v162; // rdx
			//   __int64 v163; // rcx
			//   unsigned __int64 v164; // rdx
			//   char v165; // r8
			//   signed __int64 v166; // rtt
			//   ProfilingSampler *v167; // rax
			//   __int64 v168; // rdx
			//   __int64 v169; // rcx
			//   Object *v170; // rax
			//   Object *v171; // rbx
			//   __int64 v172; // rdx
			//   __int64 v173; // rcx
			//   TextureHandle v174; // xmm0
			//   Object *v175; // rdx
			//   int v176; // eax
			//   unsigned __int64 v177; // rdx
			//   unsigned __int64 v178; // r8
			//   char v179; // dl
			//   signed __int64 v180; // rtt
			//   Object *v181; // rdx
			//   Object__Class *v182; // rcx
			//   unsigned __int64 v183; // rdx
			//   unsigned __int64 v184; // r8
			//   char v185; // dl
			//   signed __int64 v186; // rtt
			//   RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *_9__20_2; // rbx
			//   Object *v188; // r14
			//   RenderFunc_1_System_Object_ *v189; // rax
			//   __int64 v190; // rdx
			//   __int64 v191; // rcx
			//   unsigned __int64 v192; // rdx
			//   char v193; // r8
			//   signed __int64 v194; // rtt
			//   ProfilingSampler *v195; // rax
			//   __int64 v196; // rdx
			//   __int64 v197; // rcx
			//   Object *v198; // rax
			//   Object *v199; // rbx
			//   __int64 v200; // rdx
			//   __int64 v201; // rcx
			//   TextureHandle v202; // xmm0
			//   Object *v203; // rdx
			//   int v204; // eax
			//   unsigned __int64 v205; // rdx
			//   unsigned __int64 v206; // r8
			//   char v207; // dl
			//   signed __int64 v208; // rtt
			//   Object *v209; // rdx
			//   Object__Class *v210; // rcx
			//   unsigned __int64 v211; // rdx
			//   unsigned __int64 v212; // r8
			//   char v213; // dl
			//   signed __int64 v214; // rtt
			//   RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *_9__20_3; // rbx
			//   Object *v216; // r14
			//   RenderFunc_1_System_Object_ *v217; // rax
			//   __int64 v218; // rdx
			//   __int64 v219; // rcx
			//   unsigned __int64 v220; // rdx
			//   char v221; // r8
			//   signed __int64 v222; // rtt
			//   ProfilingSampler *v223; // rax
			//   __int64 v224; // rdx
			//   __int64 v225; // rcx
			//   Object *v226; // rax
			//   Object *v227; // rbx
			//   __int64 v228; // rdx
			//   __int64 v229; // rcx
			//   TextureHandle v230; // xmm0
			//   Object *v231; // rbx
			//   __int64 v232; // rdx
			//   __int64 v233; // rcx
			//   TextureHandle v234; // xmm0
			//   Object *v235; // rbx
			//   __int64 v236; // rdx
			//   __int64 v237; // rcx
			//   TextureHandle v238; // xmm0
			//   Object *v239; // rdx
			//   int v240; // eax
			//   unsigned __int64 v241; // rdx
			//   unsigned __int64 v242; // r8
			//   char v243; // dl
			//   signed __int64 v244; // rtt
			//   Object *v245; // rdx
			//   Object__Class *v246; // rcx
			//   unsigned __int64 v247; // rdx
			//   unsigned __int64 v248; // r8
			//   char v249; // dl
			//   signed __int64 v250; // rtt
			//   RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *_9__20_4; // r14
			//   Object *v252; // r12
			//   struct RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData___Class *element_class; // rbx
			//   __int64 v254; // rdx
			//   __int64 instance_size; // rcx
			//   __int64 v256; // rdx
			//   __int64 v257; // rcx
			//   unsigned __int64 v258; // r8
			//   char v259; // dl
			//   signed __int64 v260; // rtt
			//   ProfilingSampler *v261; // rax
			//   __int64 v262; // rdx
			//   __int64 v263; // rcx
			//   Object *v264; // rbx
			//   __int64 v265; // rdx
			//   __int64 v266; // rcx
			//   HGCamera_VolumeComponentsData *v267; // rsi
			//   HGDepthOfField *v268; // rsi
			//   bool v269; // al
			//   Camera *v270; // rcx
			//   Camera *v271; // r15
			//   __int64 (__fastcall *v272)(Camera *); // rax
			//   int v273; // eax
			//   __int64 v274; // rdx
			//   __int64 v275; // r15
			//   void (__fastcall *v276)(__int64, float *); // rax
			//   __int64 v277; // rdx
			//   __int64 v278; // rcx
			//   __m128i v279; // xmm8
			//   void (__fastcall *v280)(__int64, float *); // rax
			//   float v281; // xmm8_4
			//   Camera *v282; // r15
			//   double (__fastcall *v283)(Camera *); // rax
			//   __int64 v284; // rdx
			//   __int64 v285; // rcx
			//   double v286; // xmm0_8
			//   float v287; // xmm10_4
			//   Camera *v288; // r15
			//   double (__fastcall *v289)(Camera *); // rax
			//   __int64 v290; // rdx
			//   __int64 v291; // rcx
			//   double v292; // xmm0_8
			//   float v293; // xmm6_4
			//   float v294; // xmm9_4
			//   float v295; // xmm0_4
			//   float v296; // xmm6_4
			//   Camera *v297; // r15
			//   float (__fastcall *v298)(Camera *); // rax
			//   __int64 v299; // rdx
			//   __int64 v300; // rcx
			//   float v301; // xmm8_4
			//   Camera *v302; // r15
			//   double (__fastcall *v303)(Camera *); // rax
			//   __int64 v304; // rdx
			//   __int64 v305; // rcx
			//   double v306; // xmm0_8
			//   float v307; // xmm10_4
			//   Camera *v308; // r15
			//   double (__fastcall *v309)(Camera *); // rax
			//   __int64 v310; // rdx
			//   __int64 v311; // rcx
			//   double v312; // xmm0_8
			//   float v313; // xmm12_4
			//   Camera *v314; // r15
			//   double (__fastcall *v315)(Camera *); // rax
			//   __int64 v316; // rdx
			//   __int64 v317; // rcx
			//   double v318; // xmm0_8
			//   Camera *v319; // r15
			//   float (__fastcall *v320)(Camera *); // rax
			//   unsigned int v321; // xmm10_4
			//   float v322; // xmm13_4
			//   float v323; // xmm14_4
			//   unsigned int v324; // xmm6_4
			//   float v325; // xmm15_4
			//   float v326; // xmm9_4
			//   float v327; // xmm11_4
			//   float v328; // xmm12_4
			//   __int64 v329; // rdx
			//   int v330; // ecx
			//   int v331; // r8d
			//   double v332; // xmm0_8
			//   float v333; // xmm3_4
			//   float v334; // xmm5_4
			//   float v335; // xmm4_4
			//   __int64 v336; // rcx
			//   float v337; // xmm2_4
			//   float v338; // xmm1_4
			//   unsigned int v339; // esi
			//   __int64 v340; // rcx
			//   int v341; // r8d
			//   unsigned int v342; // eax
			//   unsigned int v343; // xmm4_4
			//   float v344; // xmm2_4
			//   unsigned int v345; // xmm7_4
			//   __int64 v346; // rcx
			//   int v347; // r8d
			//   unsigned int v348; // esi
			//   __int64 v349; // rcx
			//   int v350; // r8d
			//   TextureHandle v351; // xmm6
			//   TextureHandle v352; // xmm6
			//   TextureHandle v353; // xmm6
			//   int32_t monitor; // esi
			//   unsigned __int64 v355; // r8
			//   signed __int64 v356; // rtt
			//   TextureHandle v357; // xmm6
			//   int32_t klass; // r12d
			//   unsigned __int64 v359; // r8
			//   signed __int64 v360; // rtt
			//   TextureHandle v361; // xmm6
			//   int32_t v362; // r12d
			//   unsigned __int64 v363; // r8
			//   signed __int64 v364; // rtt
			//   TextureHandle v365; // xmm6
			//   TextureHandle v366; // xmm6
			//   int32_t v367; // r12d
			//   unsigned __int64 v368; // r8
			//   signed __int64 v369; // rtt
			//   TextureHandle v370; // xmm6
			//   TextureHandle v371; // xmm6
			//   unsigned __int64 v372; // r8
			//   signed __int64 v373; // rtt
			//   TextureHandle v374; // xmm6
			//   TextureHandle v375; // xmm6
			//   TextureHandle v376; // xmm6
			//   unsigned __int64 v377; // r8
			//   signed __int64 v378; // rtt
			//   TextureHandle v379; // xmm6
			//   TextureHandle v380; // xmm6
			//   unsigned __int64 v381; // r8
			//   signed __int64 v382; // rtt
			//   TextureHandle v383; // xmm6
			//   TextureHandle v384; // xmm6
			//   TextureHandle v385; // xmm6
			//   TextureHandle v386; // xmm6
			//   TextureHandle v387; // xmm6
			//   Object__Class *m_shader; // r14
			//   unsigned __int64 v389; // rbx
			//   unsigned __int64 v390; // rdx
			//   char v391; // bl
			//   signed __int64 v392; // rtt
			//   ILFixDynamicMethodWrapper_2 *v393; // rax
			//   __int64 v394; // rdx
			//   __int64 v395; // rcx
			//   DepthOfFieldPassConstructor_PassOutput *v396; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v398; // rdx
			//   __int64 v399; // rcx
			//   int32_t width[4]; // [rsp+50h] [rbp-7E8h] BYREF
			//   __int128 v401; // [rsp+60h] [rbp-7D8h] BYREF
			//   Vector4 v402; // [rsp+70h] [rbp-7C8h] BYREF
			//   float v403[4]; // [rsp+80h] [rbp-7B8h] BYREF
			//   HGRenderGraphBuilder v404; // [rsp+90h] [rbp-7A8h] BYREF
			//   float v405; // [rsp+B0h] [rbp-788h]
			//   HGRenderGraphBuilder v406; // [rsp+C0h] [rbp-778h] BYREF
			//   float m_Anamorphism; // [rsp+E0h] [rbp-758h]
			//   Object *v408; // [rsp+F0h] [rbp-748h] BYREF
			//   TextureDesc v409; // [rsp+100h] [rbp-738h] BYREF
			//   TextureHandle v410; // [rsp+160h] [rbp-6D8h] BYREF
			//   Object *v411; // [rsp+170h] [rbp-6C8h] BYREF
			//   Object *v412; // [rsp+178h] [rbp-6C0h] BYREF
			//   Object *v413; // [rsp+180h] [rbp-6B8h] BYREF
			//   Object *v414; // [rsp+188h] [rbp-6B0h] BYREF
			//   TextureHandle v415; // [rsp+190h] [rbp-6A8h] BYREF
			//   Object *v416; // [rsp+1A0h] [rbp-698h] BYREF
			//   TextureHandle v417; // [rsp+1B0h] [rbp-688h] BYREF
			//   HGRenderGraphBuilder v418; // [rsp+1C0h] [rbp-678h] BYREF
			//   __int128 v419; // [rsp+1E0h] [rbp-658h] BYREF
			//   __int128 v420; // [rsp+1F0h] [rbp-648h]
			//   __int128 v421; // [rsp+200h] [rbp-638h]
			//   __int128 v422; // [rsp+210h] [rbp-628h] BYREF
			//   __int128 v423; // [rsp+220h] [rbp-618h]
			//   Color v424; // [rsp+230h] [rbp-608h]
			//   HGRenderGraphBuilder v425; // [rsp+240h] [rbp-5F8h] BYREF
			//   TextureHandle v426; // [rsp+260h] [rbp-5D8h] BYREF
			//   HGRenderGraphBuilder v427; // [rsp+270h] [rbp-5C8h] BYREF
			//   HGRenderGraphBuilder v428; // [rsp+290h] [rbp-5A8h] BYREF
			//   HGRenderGraphBuilder v429; // [rsp+2B0h] [rbp-588h] BYREF
			//   HGRenderGraphBuilder v430; // [rsp+2D0h] [rbp-568h] BYREF
			//   DepthOfFieldPassConstructor_DepthOfFieldData P2; // [rsp+2F0h] [rbp-548h] BYREF
			//   TextureDesc v432; // [rsp+350h] [rbp-4E8h] BYREF
			//   TextureDesc v433; // [rsp+3B0h] [rbp-488h] BYREF
			//   HGRenderGraphProfilingScope v434; // [rsp+410h] [rbp-428h] BYREF
			//   Il2CppExceptionWrapper *v435; // [rsp+428h] [rbp-410h] BYREF
			//   Il2CppExceptionWrapper *v436; // [rsp+430h] [rbp-408h] BYREF
			//   Il2CppExceptionWrapper *v437; // [rsp+438h] [rbp-400h] BYREF
			//   Il2CppExceptionWrapper *v438; // [rsp+440h] [rbp-3F8h] BYREF
			//   Il2CppExceptionWrapper *v439; // [rsp+448h] [rbp-3F0h] BYREF
			//   Il2CppExceptionWrapper *v440; // [rsp+450h] [rbp-3E8h] BYREF
			//   Il2CppExceptionWrapper *v441; // [rsp+458h] [rbp-3E0h] BYREF
			//   TextureDesc v442; // [rsp+460h] [rbp-3D8h] BYREF
			//   TextureDesc v443; // [rsp+4C0h] [rbp-378h] BYREF
			//   TextureDesc v444; // [rsp+520h] [rbp-318h] BYREF
			//   TextureDesc v445; // [rsp+580h] [rbp-2B8h] BYREF
			//   TextureDesc v446; // [rsp+5E0h] [rbp-258h] BYREF
			//   TextureDesc v447; // [rsp+640h] [rbp-1F8h] BYREF
			//   TextureDesc v448; // [rsp+6A0h] [rbp-198h] BYREF
			//   TextureDesc v449[2]; // [rsp+700h] [rbp-138h] BYREF
			// 
			//   v6 = (Object *)renderGraph;
			//   v7 = input;
			//   v8 = this;
			//   P3 = hgCamera;
			//   *(_QWORD *)v403 = hgCamera;
			//   if ( !byte_18D919520 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructPass_b__20_0);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructPass_b__20_1);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructPass_b__20_2);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructPass_b__20_3);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructPass_b__20_4);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
			//     sub_18003C530(&off_18D4FAE70);
			//     sub_18003C530(&off_18D4FAE88);
			//     sub_18003C530(&off_18D4FAEA0);
			//     sub_18003C530(&off_18D4FA708);
			//     sub_18003C530(&off_18D4FADB0);
			//     sub_18003C530(&off_18D4FA718);
			//     sub_18003C530(&off_18D4FA728);
			//     sub_18003C530(&off_18D4FA738);
			//     byte_18D919520 = 1;
			//   }
			//   memset(&v434, 0, sizeof(v434));
			//   sub_1802F01E0(&P2, 0LL, 96LL);
			//   sub_1802F01E0(&v446, 0LL, 96LL);
			//   sub_1802F01E0(&v444, 0LL, 96LL);
			//   sub_1802F01E0(&v419, 0LL, 96LL);
			//   memset(&v427, 0, sizeof(v427));
			//   v411 = 0LL;
			//   memset(&v425, 0, sizeof(v425));
			//   v412 = 0LL;
			//   memset(&v428, 0, sizeof(v428));
			//   v413 = 0LL;
			//   memset(&v429, 0, sizeof(v429));
			//   v414 = 0LL;
			//   memset(&v418, 0, sizeof(v418));
			//   v408 = 0LL;
			//   memset(&v430, 0, sizeof(v430));
			//   v416 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2544, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2544, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v399, v398);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_939(Patch, (Object *)v8, v7, output, v6, (Object *)hgCamera, 0LL);
			//   }
			//   else
			//   {
			//     v10 = HG::Rendering::Runtime::DepthOfFieldPassConstructor::IfEnable(v8, hgCamera, v7, 0LL);
			//     v8.fields.m_enable = v10;
			//     if ( v10 )
			//     {
			//       if ( !hgCamera )
			//         sub_180B536AC(v12, v11);
			//       if ( hgCamera.fields.prevTransformReset )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         v8.fields.m_previousSceneColorTexture = *(TextureHandle *)sub_182E7CCD0(&v415);
			//         v8.fields.m_fallbackPreviousFrame = 1;
			//       }
			//       *output = (DepthOfFieldPassConstructor_PassOutput)v7.sceneColor;
			//       quality = v7.quality;
			//       v7.quality = v7.quality;
			//       if ( quality != 3 )
			//         goto LABEL_185;
			//       v14 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0xA5u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
			//         &v434,
			//         (HGRenderGraph *)v6,
			//         v14,
			//         0LL);
			//       *(_QWORD *)&v401 = 0LL;
			//       *((_QWORD *)&v401 + 1) = &v434;
			//       try
			//       {
			//         if ( IFix::WrappersManagerImpl::IsPatched(2543, 0LL) )
			//         {
			//           v80 = IFix::WrappersManagerImpl::GetPatch(2543, 0LL);
			//           if ( !v80 )
			//             sub_1802DC2C8(v82, v81);
			//           IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_936(v80, (Object *)v8, v7, &P2, (Object *)hgCamera, 0LL);
			//         }
			//         else
			//         {
			//           m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//           if ( !m_volumeComponentsData )
			//             sub_1802DC2C8(v16, v15);
			//           m_depthOfField = m_volumeComponentsData.fields.m_depthOfField;
			//           if ( !m_depthOfField )
			//             sub_1802DC2C8(v16, v15);
			//           if ( m_depthOfField.fields.scale )
			//             v19 = 0.5;
			//           else
			//             v19 = 1.0;
			//           if ( !m_depthOfField.fields.focusMode )
			//           {
			//             camera = hgCamera.fields.camera;
			//             if ( !camera )
			//               sub_1802DC2C8(0LL, v15);
			//             UnityEngine::Camera::get_usePhysicalProperties(camera, 0LL);
			//           }
			//           v21 = hgCamera.fields.camera;
			//           if ( !v21 )
			//             sub_1802DC2C8(v16, v15);
			//           v22 = (__int64 (__fastcall *)(Camera *))qword_18D8F4238;
			//           if ( !qword_18D8F4238 )
			//           {
			//             v22 = (__int64 (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_gateFit()");
			//             qword_18D8F4238 = (__int64)v22;
			//           }
			//           v23 = v22(v21);
			//           v25 = *(_QWORD *)(*(_QWORD *)v403 + 96LL);
			//           if ( v23 == 2 )
			//           {
			//             if ( !v25 )
			//               sub_1802DC2C8(*(_QWORD *)v403, v24);
			//             *(_QWORD *)width = 0LL;
			//             v30 = (void (__fastcall *)(__int64, int32_t *))qword_18D8F42C0;
			//             if ( !qword_18D8F42C0 )
			//             {
			//               v30 = (void (__fastcall *)(__int64, int32_t *))sub_180017470(
			//                                                                "UnityEngine.Camera::get_sensorSize_Injected(UnityEngine.Vector2&)");
			//               qword_18D8F42C0 = (__int64)v30;
			//             }
			//             v30(v25, width);
			//             v29 = _mm_cvtsi32_si128(hgCamera.fields._taauRTSize_k__BackingField.m_X);
			//           }
			//           else
			//           {
			//             if ( !v25 )
			//               sub_1802DC2C8(*(_QWORD *)v403, v24);
			//             *(_QWORD *)width = 0LL;
			//             v26 = (void (__fastcall *)(__int64, int32_t *))qword_18D8F42C0;
			//             if ( !qword_18D8F42C0 )
			//             {
			//               v26 = (void (__fastcall *)(__int64, int32_t *))sub_180017470(
			//                                                                "UnityEngine.Camera::get_sensorSize_Injected(UnityEngine.Vector2&)");
			//               qword_18D8F42C0 = (__int64)v26;
			//             }
			//             v26(v25, width);
			//             v29 = _mm_cvtsi32_si128(HIDWORD(*(_QWORD *)&hgCamera.fields._taauRTSize_k__BackingField));
			//           }
			//           v31 = _mm_cvtepi32_ps(v29).m128_f32[0] * (float)(0.5 / *(float *)width);
			//           v32 = hgCamera.fields.camera;
			//           if ( !v32 )
			//             sub_1802DC2C8(v28, v27);
			//           v33 = (double (__fastcall *)(Camera *))qword_18D92CF08;
			//           if ( !qword_18D92CF08 )
			//           {
			//             v33 = (double (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_focalLength()");
			//             qword_18D92CF08 = (__int64)v33;
			//           }
			//           v36 = v33(v32);
			//           *(_OWORD *)&v406.m_RenderGraph = *(_OWORD *)&hgCamera.fields._physicalParameters_k__BackingField.m_BladeCount;
			//           m_Anamorphism = hgCamera.fields._physicalParameters_k__BackingField.m_Anamorphism;
			//           v37 = *(float *)&v36 / hgCamera.fields._physicalParameters_k__BackingField.m_Aperture;
			//           v38 = hgCamera.fields.camera;
			//           if ( !v38 )
			//             sub_1802DC2C8(v35, v34);
			//           v39 = (double (__fastcall *)(Camera *))qword_18D92CF08;
			//           if ( !qword_18D92CF08 )
			//           {
			//             v39 = (double (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_focalLength()");
			//             qword_18D92CF08 = (__int64)v39;
			//           }
			//           v40 = v39(v38);
			//           *(_OWORD *)&v406.m_RenderGraph = *(_OWORD *)&hgCamera.fields._physicalParameters_k__BackingField.m_BladeCount;
			//           m_Anamorphism = hgCamera.fields._physicalParameters_k__BackingField.m_Anamorphism;
			//           m_FocusDistance = hgCamera.fields._physicalParameters_k__BackingField.m_FocusDistance;
			//           v44 = (float)((float)((float)(*(float *)&v40 / 1000.0) * v37) * v31)
			//               / UnityEngine::Mathf::Max(m_FocusDistance - (float)(*(float *)&v40 / 1000.0), 0.000001, 0LL);
			//           v45 = hgCamera.fields.camera;
			//           if ( !v45 )
			//             sub_1802DC2C8(v43, v42);
			//           v46 = (float (__fastcall *)(Camera *))qword_18D8F4188;
			//           if ( !qword_18D8F4188 )
			//           {
			//             v46 = (float (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_farClipPlane()");
			//             qword_18D8F4188 = (__int64)v46;
			//           }
			//           v49 = (float)(1.0 - (float)(m_FocusDistance / v46(v45))) * v44;
			//           v50 = hgCamera.fields.camera;
			//           if ( !v50 )
			//             sub_1802DC2C8(v48, v47);
			//           v51 = (double (__fastcall *)(Camera *))qword_18D8F4188;
			//           if ( !qword_18D8F4188 )
			//           {
			//             v51 = (double (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_farClipPlane()");
			//             qword_18D8F4188 = (__int64)v51;
			//           }
			//           v54 = v51(v50);
			//           v55 = *(float *)&v54;
			//           v56 = hgCamera.fields.camera;
			//           if ( !v56 )
			//             sub_1802DC2C8(v53, v52);
			//           v57 = (double (__fastcall *)(Camera *))qword_18D8F4178;
			//           if ( !qword_18D8F4178 )
			//           {
			//             v57 = (double (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_nearClipPlane()");
			//             qword_18D8F4178 = (__int64)v57;
			//           }
			//           v60 = v57(v56);
			//           v61 = *(float *)&v60;
			//           v62 = hgCamera.fields.camera;
			//           if ( !v62 )
			//             sub_1802DC2C8(v59, v58);
			//           v63 = (double (__fastcall *)(Camera *))qword_18D8F4188;
			//           if ( !qword_18D8F4188 )
			//           {
			//             v63 = (double (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_farClipPlane()");
			//             qword_18D8F4188 = (__int64)v63;
			//           }
			//           v66 = v63(v62);
			//           v67 = hgCamera.fields.camera;
			//           if ( !v67 )
			//             sub_1802DC2C8(v65, v64);
			//           v68 = (float (__fastcall *)(Camera *))qword_18D8F4178;
			//           if ( !qword_18D8F4178 )
			//           {
			//             v68 = (float (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_nearClipPlane()");
			//             qword_18D8F4178 = (__int64)v68;
			//           }
			//           *(float *)&v69 = (float)((float)(v55 - v61) * (float)(v44 * m_FocusDistance))
			//                          / (float)(*(float *)&v66 * v68(v67));
			//           nearFocusStart = m_depthOfField.fields.nearFocusStart;
			//           nearFocusEnd = m_depthOfField.fields.nearFocusEnd;
			//           v72 = Rewired::Utils::MathTools::Clamp(m_depthOfField.fields.nearRadius, 0.0, v7.depthOfFieldMaxRadius, 0LL);
			//           farFocusStart = m_depthOfField.fields.farFocusStart;
			//           farFocusEnd = m_depthOfField.fields.farFocusEnd;
			//           v75 = Rewired::Utils::MathTools::Clamp(m_depthOfField.fields.farRadius, 0.0, v7.depthOfFieldMaxRadius, 0LL);
			//           v76 = (float)(int)HIDWORD(*(_QWORD *)&hgCamera.fields._sceneRTSize_k__BackingField);
			//           *(_QWORD *)&v402.x = __PAIR64__(v69, LODWORD(v49));
			//           *(_QWORD *)&v402.z = LODWORD(v19);
			//           P2.param0 = v402;
			//           P2.param1.x = nearFocusStart;
			//           P2.param1.y = nearFocusEnd;
			//           P2.param1.z = (float)(v76 * v72) / 1440.0;
			//           P2.param1.w = 0.0;
			//           P2.param2.x = farFocusStart;
			//           P2.param2.y = farFocusEnd;
			//           P2.param2.z = (float)(v76 * v75) / 1440.0;
			//           memset(&P2.param2.w, 0, 20);
			//           v77 = (float)(int)HIDWORD(*(_QWORD *)&hgCamera.fields._sceneRTSize_k__BackingField) * v19;
			//           v78 = HIDWORD(*(_QWORD *)&hgCamera.fields._sceneRTSize_k__BackingField);
			//           v79 = (float)(1.0 / (float)hgCamera.fields._sceneRTSize_k__BackingField.m_X) / v19;
			//           P2.downsampleScreenSize.x = (float)hgCamera.fields._sceneRTSize_k__BackingField.m_X * v19;
			//           P2.downsampleScreenSize.y = v77;
			//           P2.downsampleScreenSize.z = v79;
			//           P2.downsampleScreenSize.w = (float)(1.0 / (float)(int)v78) / v19;
			//         }
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                            (CBHandle *)&v404,
			//                            &v7.renderContext,
			//                            96,
			//                            0LL);
			//         v84 = *(_OWORD *)&ConstantBuffer.bufferId;
			//         *(_OWORD *)&v406.m_RenderPass = *(_OWORD *)&ConstantBuffer.bufferId;
			//         ptr = (HGRenderGraph *)ConstantBuffer.ptr;
			//         v406.m_RenderGraph = ptr;
			//         Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)ptr, (Void *)&P2, 96LL, 0LL);
			//         v86 = 4
			//             * !UnityEngine::SystemInfo::IsFormatSupported(
			//                  GraphicsFormat__Enum_R16_SFloat,
			//                  FormatUsage__Enum_Render,
			//                  0LL)
			//             + 45;
			//         sceneRTSize_k__BackingField = hgCamera.fields._sceneRTSize_k__BackingField;
			//         sub_1802F01E0(&v433, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//           &v433,
			//           hgCamera.fields._sceneRTSize_k__BackingField.m_X,
			//           sceneRTSize_k__BackingField.m_Y,
			//           0LL);
			//         v90 = *(_OWORD *)&v433.width;
			//         v419 = *(_OWORD *)&v433.width;
			//         v420 = *(_OWORD *)&v433.colorFormat;
			//         v91 = *(_OWORD *)&v433.enableRandomWrite;
			//         v421 = *(_OWORD *)&v433.enableRandomWrite;
			//         *(_QWORD *)&v422 = *(_QWORD *)&v433.bindTextureMS;
			//         v92 = *(_OWORD *)&v433.fastMemoryDesc.inFastMemory;
			//         v423 = *(_OWORD *)&v433.fastMemoryDesc.inFastMemory;
			//         clearColor = v433.clearColor;
			//         v424 = v433.clearColor;
			//         LODWORD(v420) = v86;
			//         *((_QWORD *)&v422 + 1) = "Depth Of Field CoC";
			//         if ( dword_18D8E43F8 )
			//         {
			//           v94 = ((((unsigned __int64)&v422 + 8) >> 12) & 0x1FFFFF) >> 6;
			//           v88 = (((unsigned __int64)&v422 + 8) >> 12) & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v94 + 36190]);
			//           do
			//           {
			//             v89 = qword_18D6405E0[v94 + 36190] | (1LL << v88);
			//             v95 = qword_18D6405E0[v94 + 36190];
			//           }
			//           while ( v95 != _InterlockedCompareExchange64(&qword_18D6405E0[v94 + 36190], v89, v95) );
			//           clearColor = v424;
			//           v92 = v423;
			//           v91 = v421;
			//           v90 = v419;
			//         }
			//         *(_OWORD *)&v446.width = v90;
			//         *(_OWORD *)&v446.colorFormat = v420;
			//         *(_OWORD *)&v446.enableRandomWrite = v91;
			//         *(_OWORD *)&v446.bindTextureMS = v422;
			//         *(_OWORD *)&v446.fastMemoryDesc.inFastMemory = v92;
			//         v446.clearColor = clearColor;
			//         if ( !renderGraph )
			//           sub_1802DC2C8(v89, v88);
			//         v417 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v415, renderGraph, &v446, 0LL);
			//         sub_1802F01E0(&v432, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//           &v432,
			//           (int)P2.downsampleScreenSize.x,
			//           (int)P2.downsampleScreenSize.y,
			//           0LL);
			//         v96 = *(_OWORD *)&v432.width;
			//         v419 = *(_OWORD *)&v432.width;
			//         v420 = *(_OWORD *)&v432.colorFormat;
			//         v97 = *(_OWORD *)&v432.enableRandomWrite;
			//         v421 = *(_OWORD *)&v432.enableRandomWrite;
			//         *(_QWORD *)&v422 = *(_QWORD *)&v432.bindTextureMS;
			//         v98 = *(_OWORD *)&v432.fastMemoryDesc.inFastMemory;
			//         v423 = *(_OWORD *)&v432.fastMemoryDesc.inFastMemory;
			//         v99 = v432.clearColor;
			//         v424 = v432.clearColor;
			//         LODWORD(v420) = 48;
			//         *((_QWORD *)&v422 + 1) = "Depth Of Field Blur 0";
			//         if ( dword_18D8E43F8 )
			//         {
			//           v100 = ((((unsigned __int64)&v422 + 8) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v100 + 36190]);
			//           do
			//             v101 = qword_18D6405E0[v100 + 36190];
			//           while ( v101 != _InterlockedCompareExchange64(
			//                             &qword_18D6405E0[v100 + 36190],
			//                             v101 | (1LL << ((((unsigned __int64)&v422 + 8) >> 12) & 0x3F)),
			//                             v101) );
			//           v99 = v424;
			//           v98 = v423;
			//           v97 = v421;
			//           v96 = v419;
			//         }
			//         *(_OWORD *)&v444.width = v96;
			//         *(_OWORD *)&v444.colorFormat = v420;
			//         *(_OWORD *)&v444.enableRandomWrite = v97;
			//         *(_OWORD *)&v444.bindTextureMS = v422;
			//         *(_OWORD *)&v444.fastMemoryDesc.inFastMemory = v98;
			//         v444.clearColor = v99;
			//         v410 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v415, renderGraph, &v444, 0LL);
			//         v426 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v415, renderGraph, &v444, 0LL);
			//         v102 = input;
			//         v415 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                   &v415,
			//                   renderGraph,
			//                   &input.sceneColor,
			//                   0LL);
			//         v103 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                  (Int32Enum__Enum)0xA5u,
			//                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           &v404,
			//           renderGraph,
			//           (String *)"Depth of Field 0",
			//           &v411,
			//           v103,
			//           1,
			//           ProfilingHGPass__Enum_None,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//         v427 = v404;
			//         *(_QWORD *)&v402.x = 0LL;
			//         *(_QWORD *)&v402.z = &v427;
			//         try
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v427, 0, 0LL);
			//           v106 = v411;
			//           if ( !v411 )
			//             sub_1802DC2C8(v105, v104);
			//           *(_OWORD *)&v411[33].monitor = v84;
			//           v106[34].monitor = (MonitorData *)ptr;
			//           v107 = v411;
			//           v110 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)width,
			//                     &v427,
			//                     &input.sceneDepth,
			//                     0LL);
			//           if ( !v107 )
			//             sub_1802DC2C8(v109, v108);
			//           v107[15] = (Object)v110;
			//           v111 = v411;
			//           if ( !v411 )
			//             sub_1802DC2C8(v109, 0LL);
			//           v411[37].monitor = (MonitorData *)v8.fields.m_mobileMaterial;
			//           v112 = dword_18D8E43F8;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v113 = ((unsigned __int64)&v111[37].monitor >> 12) & 0x1FFFFF;
			//             v114 = v113 >> 6;
			//             v115 = v113 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v114 + 36190]);
			//             do
			//               v116 = qword_18D6405E0[v114 + 36190];
			//             while ( v116 != _InterlockedCompareExchange64(&qword_18D6405E0[v114 + 36190], v116 | (1LL << v115), v116) );
			//             v112 = dword_18D8E43F8;
			//           }
			//           v117 = v411;
			//           m_mbp = (Object__Class *)v8.fields.m_mbp;
			//           if ( !v411 )
			//             sub_1802DC2C8(m_mbp, 0LL);
			//           v411[37].klass = m_mbp;
			//           if ( v112 )
			//           {
			//             v119 = ((unsigned __int64)&v117[37] >> 12) & 0x1FFFFF;
			//             v120 = v119 >> 6;
			//             v117 = (Object *)(v119 & 0x3F);
			//             _m_prefetchw(&qword_18D6405E0[v120 + 36190]);
			//             do
			//             {
			//               m_mbp = (Object__Class *)(qword_18D6405E0[v120 + 36190] | (1LL << (char)v117));
			//               v121 = qword_18D6405E0[v120 + 36190];
			//             }
			//             while ( v121 != _InterlockedCompareExchange64(&qword_18D6405E0[v120 + 36190], (signed __int64)m_mbp, v121) );
			//           }
			//           v122 = v411;
			//           v123 = hgCamera.fields.m_volumeComponentsData;
			//           if ( !v123 )
			//             sub_1802DC2C8(m_mbp, v117);
			//           v124 = v123.fields.m_depthOfField;
			//           if ( !v124 )
			//             sub_1802DC2C8(0LL, v117);
			//           if ( v124.fields.focusMode )
			//           {
			//             usePhysicalProperties = 0;
			//           }
			//           else
			//           {
			//             v126 = hgCamera.fields.camera;
			//             if ( !v126 )
			//               sub_1802DC2C8(0LL, v117);
			//             usePhysicalProperties = UnityEngine::Camera::get_usePhysicalProperties(v126, 0LL);
			//           }
			//           if ( !v122 )
			//             sub_1802DC2C8(v124, v117);
			//           LOBYTE(v122[1].klass) = usePhysicalProperties;
			//           *(_OWORD *)width = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v404,
			//             &v427,
			//             &v417,
			//             0,
			//             RenderBufferLoadAction__Enum_DontCare,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)width,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
			//           _9__20_0 = TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_0;
			//           if ( !_9__20_0 )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
			//             v128 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9;
			//             v129 = (RenderFunc_1_System_Object_ *)sub_180004920(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>[0]);
			//             _9__20_0 = (RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *)v129;
			//             if ( !v129 )
			//               sub_1802DC2C8(v131, v130);
			//             HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
			//               v129,
			//               v128,
			//               MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructPass_b__20_0,
			//               0LL);
			//             TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_0 = _9__20_0;
			//             if ( dword_18D8E43F8 )
			//             {
			//               v132 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_0 >> 12) & 0x1FFFFF) >> 6;
			//               v133 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_0 >> 12) & 0x3F;
			//               _m_prefetchw(&qword_18D6405E0[v132 + 36190]);
			//               do
			//                 v134 = qword_18D6405E0[v132 + 36190];
			//               while ( v134 != _InterlockedCompareExchange64(&qword_18D6405E0[v132 + 36190], v134 | (1LL << v133), v134) );
			//             }
			//           }
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v427,
			//             (RenderFunc_1_System_Object_ *)_9__20_0,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v435 )
			//         {
			//           *(Il2CppExceptionWrapper *)&v402.x = (Il2CppExceptionWrapper)v435.ex;
			//           sub_180222690(&v402);
			//           v8 = this;
			//           ptr = v406.m_RenderGraph;
			//           v84 = *(_OWORD *)&v406.m_RenderPass;
			//           v102 = input;
			//           goto LABEL_90;
			//         }
			//         sub_180222690(&v402);
			// LABEL_90:
			//         v135 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                  (Int32Enum__Enum)0xA5u,
			//                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           &v404,
			//           renderGraph,
			//           (String *)"Depth of Field 1",
			//           &v412,
			//           v135,
			//           1,
			//           ProfilingHGPass__Enum_None,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//         v425 = v404;
			//         *(_QWORD *)&v402.x = 0LL;
			//         *(_QWORD *)&v402.z = &v425;
			//         try
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v425, 0, 0LL);
			//           v138 = v412;
			//           if ( !v412 )
			//             sub_1802DC2C8(v137, v136);
			//           *(_OWORD *)&v412[33].monitor = v84;
			//           v138[34].monitor = (MonitorData *)ptr;
			//           v139 = v412;
			//           v142 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&v404,
			//                     &v425,
			//                     &v102.sceneColor,
			//                     0LL);
			//           if ( !v139 )
			//             sub_1802DC2C8(v141, v140);
			//           v139[14] = (Object)v142;
			//           v143 = v412;
			//           v146 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&v404,
			//                     &v425,
			//                     &v417,
			//                     0LL);
			//           if ( !v143 )
			//             sub_1802DC2C8(v145, v144);
			//           v143[17] = (Object)v146;
			//           v147 = v412;
			//           if ( !v412 )
			//             sub_1802DC2C8(v145, 0LL);
			//           v412[37].monitor = (MonitorData *)v8.fields.m_mobileMaterial;
			//           v148 = dword_18D8E43F8;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v149 = ((unsigned __int64)&v147[37].monitor >> 12) & 0x1FFFFF;
			//             v150 = v149 >> 6;
			//             v151 = v149 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v150 + 36190]);
			//             do
			//               v152 = qword_18D6405E0[v150 + 36190];
			//             while ( v152 != _InterlockedCompareExchange64(&qword_18D6405E0[v150 + 36190], v152 | (1LL << v151), v152) );
			//             v148 = dword_18D8E43F8;
			//           }
			//           v153 = v412;
			//           v154 = (Object__Class *)v8.fields.m_mbp;
			//           if ( !v412 )
			//             sub_1802DC2C8(v154, 0LL);
			//           v412[37].klass = v154;
			//           if ( v148 )
			//           {
			//             v155 = ((unsigned __int64)&v153[37] >> 12) & 0x1FFFFF;
			//             v156 = v155 >> 6;
			//             v157 = v155 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v156 + 36190]);
			//             do
			//               v158 = qword_18D6405E0[v156 + 36190];
			//             while ( v158 != _InterlockedCompareExchange64(&qword_18D6405E0[v156 + 36190], v158 | (1LL << v157), v158) );
			//           }
			//           *(_OWORD *)width = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v404,
			//             &v425,
			//             &v426,
			//             0,
			//             RenderBufferLoadAction__Enum_DontCare,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)width,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
			//           _9__20_1 = TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_1;
			//           if ( !_9__20_1 )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
			//             v160 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9;
			//             v161 = (RenderFunc_1_System_Object_ *)sub_180004920(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>[0]);
			//             _9__20_1 = (RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *)v161;
			//             if ( !v161 )
			//               sub_1802DC2C8(v163, v162);
			//             HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
			//               v161,
			//               v160,
			//               MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructPass_b__20_1,
			//               0LL);
			//             TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_1 = _9__20_1;
			//             if ( dword_18D8E43F8 )
			//             {
			//               v164 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_1 >> 12) & 0x1FFFFF) >> 6;
			//               v165 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_1 >> 12) & 0x3F;
			//               _m_prefetchw(&qword_18D6405E0[v164 + 36190]);
			//               do
			//                 v166 = qword_18D6405E0[v164 + 36190];
			//               while ( v166 != _InterlockedCompareExchange64(&qword_18D6405E0[v164 + 36190], v166 | (1LL << v165), v166) );
			//             }
			//           }
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v425,
			//             (RenderFunc_1_System_Object_ *)_9__20_1,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v436 )
			//         {
			//           *(Il2CppExceptionWrapper *)&v402.x = (Il2CppExceptionWrapper)v436.ex;
			//           sub_180222690(&v402);
			//           v8 = this;
			//           ptr = v406.m_RenderGraph;
			//           v84 = *(_OWORD *)&v406.m_RenderPass;
			//           v102 = input;
			//           goto LABEL_110;
			//         }
			//         sub_180222690(&v402);
			// LABEL_110:
			//         v167 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                  (Int32Enum__Enum)0xA5u,
			//                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           &v404,
			//           renderGraph,
			//           (String *)"Depth of Field 2",
			//           &v413,
			//           v167,
			//           1,
			//           ProfilingHGPass__Enum_None,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//         v428 = v404;
			//         *(_QWORD *)&v402.x = 0LL;
			//         *(_QWORD *)&v402.z = &v428;
			//         try
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v428, 0, 0LL);
			//           v170 = v413;
			//           if ( !v413 )
			//             sub_1802DC2C8(v169, v168);
			//           *(_OWORD *)&v413[33].monitor = v84;
			//           v170[34].monitor = (MonitorData *)ptr;
			//           v171 = v413;
			//           v174 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&v404,
			//                     &v428,
			//                     &v426,
			//                     0LL);
			//           if ( !v171 )
			//             sub_1802DC2C8(v173, v172);
			//           v171[36] = (Object)v174;
			//           v175 = v413;
			//           if ( !v413 )
			//             sub_1802DC2C8(v173, 0LL);
			//           v413[37].monitor = (MonitorData *)v8.fields.m_mobileMaterial;
			//           v176 = dword_18D8E43F8;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v177 = ((unsigned __int64)&v175[37].monitor >> 12) & 0x1FFFFF;
			//             v178 = v177 >> 6;
			//             v179 = v177 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v178 + 36190]);
			//             do
			//               v180 = qword_18D6405E0[v178 + 36190];
			//             while ( v180 != _InterlockedCompareExchange64(&qword_18D6405E0[v178 + 36190], v180 | (1LL << v179), v180) );
			//             v176 = dword_18D8E43F8;
			//           }
			//           v181 = v413;
			//           v182 = (Object__Class *)v8.fields.m_mbp;
			//           if ( !v413 )
			//             sub_1802DC2C8(v182, 0LL);
			//           v413[37].klass = v182;
			//           if ( v176 )
			//           {
			//             v183 = ((unsigned __int64)&v181[37] >> 12) & 0x1FFFFF;
			//             v184 = v183 >> 6;
			//             v185 = v183 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v184 + 36190]);
			//             do
			//               v186 = qword_18D6405E0[v184 + 36190];
			//             while ( v186 != _InterlockedCompareExchange64(&qword_18D6405E0[v184 + 36190], v186 | (1LL << v185), v186) );
			//           }
			//           *(_OWORD *)width = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v404,
			//             &v428,
			//             &v410,
			//             0,
			//             RenderBufferLoadAction__Enum_DontCare,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)width,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
			//           _9__20_2 = TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_2;
			//           if ( !_9__20_2 )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
			//             v188 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9;
			//             v189 = (RenderFunc_1_System_Object_ *)sub_180004920(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>[0]);
			//             _9__20_2 = (RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *)v189;
			//             if ( !v189 )
			//               sub_1802DC2C8(v191, v190);
			//             HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
			//               v189,
			//               v188,
			//               MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructPass_b__20_2,
			//               0LL);
			//             TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_2 = _9__20_2;
			//             if ( dword_18D8E43F8 )
			//             {
			//               v192 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_2 >> 12) & 0x1FFFFF) >> 6;
			//               v193 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_2 >> 12) & 0x3F;
			//               _m_prefetchw(&qword_18D6405E0[v192 + 36190]);
			//               do
			//                 v194 = qword_18D6405E0[v192 + 36190];
			//               while ( v194 != _InterlockedCompareExchange64(&qword_18D6405E0[v192 + 36190], v194 | (1LL << v193), v194) );
			//             }
			//           }
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v428,
			//             (RenderFunc_1_System_Object_ *)_9__20_2,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v437 )
			//         {
			//           *(Il2CppExceptionWrapper *)&v402.x = (Il2CppExceptionWrapper)v437.ex;
			//           sub_180222690(&v402);
			//           v8 = this;
			//           ptr = v406.m_RenderGraph;
			//           v84 = *(_OWORD *)&v406.m_RenderPass;
			//           v102 = input;
			//           goto LABEL_129;
			//         }
			//         sub_180222690(&v402);
			// LABEL_129:
			//         v195 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                  (Int32Enum__Enum)0xA5u,
			//                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           &v404,
			//           renderGraph,
			//           (String *)"Depth of Field 3",
			//           &v414,
			//           v195,
			//           1,
			//           ProfilingHGPass__Enum_None,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//         v429 = v404;
			//         *(_QWORD *)&v402.x = 0LL;
			//         *(_QWORD *)&v402.z = &v429;
			//         try
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v429, 0, 0LL);
			//           v198 = v414;
			//           if ( !v414 )
			//             sub_1802DC2C8(v197, v196);
			//           *(_OWORD *)&v414[33].monitor = v84;
			//           v198[34].monitor = (MonitorData *)ptr;
			//           v199 = v414;
			//           v202 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&v404,
			//                     &v429,
			//                     &v410,
			//                     0LL);
			//           if ( !v199 )
			//             sub_1802DC2C8(v201, v200);
			//           v199[35] = (Object)v202;
			//           v203 = v414;
			//           if ( !v414 )
			//             sub_1802DC2C8(v201, 0LL);
			//           v414[37].monitor = (MonitorData *)v8.fields.m_mobileMaterial;
			//           v204 = dword_18D8E43F8;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v205 = ((unsigned __int64)&v203[37].monitor >> 12) & 0x1FFFFF;
			//             v206 = v205 >> 6;
			//             v207 = v205 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v206 + 36190]);
			//             do
			//               v208 = qword_18D6405E0[v206 + 36190];
			//             while ( v208 != _InterlockedCompareExchange64(&qword_18D6405E0[v206 + 36190], v208 | (1LL << v207), v208) );
			//             v204 = dword_18D8E43F8;
			//           }
			//           v209 = v414;
			//           v210 = (Object__Class *)v8.fields.m_mbp;
			//           if ( !v414 )
			//             sub_1802DC2C8(v210, 0LL);
			//           v414[37].klass = v210;
			//           if ( v204 )
			//           {
			//             v211 = ((unsigned __int64)&v209[37] >> 12) & 0x1FFFFF;
			//             v212 = v211 >> 6;
			//             v213 = v211 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v212 + 36190]);
			//             do
			//               v214 = qword_18D6405E0[v212 + 36190];
			//             while ( v214 != _InterlockedCompareExchange64(&qword_18D6405E0[v212 + 36190], v214 | (1LL << v213), v214) );
			//           }
			//           v410 = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v404,
			//             &v429,
			//             &v426,
			//             0,
			//             RenderBufferLoadAction__Enum_DontCare,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&v410,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
			//           _9__20_3 = TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_3;
			//           if ( !_9__20_3 )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
			//             v216 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9;
			//             v217 = (RenderFunc_1_System_Object_ *)sub_180004920(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>[0]);
			//             _9__20_3 = (RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *)v217;
			//             if ( !v217 )
			//               sub_1802DC2C8(v219, v218);
			//             HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
			//               v217,
			//               v216,
			//               MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructPass_b__20_3,
			//               0LL);
			//             TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_3 = _9__20_3;
			//             if ( dword_18D8E43F8 )
			//             {
			//               v220 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_3 >> 12) & 0x1FFFFF) >> 6;
			//               v221 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_3 >> 12) & 0x3F;
			//               _m_prefetchw(&qword_18D6405E0[v220 + 36190]);
			//               do
			//                 v222 = qword_18D6405E0[v220 + 36190];
			//               while ( v222 != _InterlockedCompareExchange64(&qword_18D6405E0[v220 + 36190], v222 | (1LL << v221), v222) );
			//             }
			//           }
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v429,
			//             (RenderFunc_1_System_Object_ *)_9__20_3,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v441 )
			//         {
			//           *(Il2CppExceptionWrapper *)&v402.x = (Il2CppExceptionWrapper)v441.ex;
			//           sub_180222690(&v402);
			//           v8 = this;
			//           ptr = v406.m_RenderGraph;
			//           v84 = *(_OWORD *)&v406.m_RenderPass;
			//           v102 = input;
			//           goto LABEL_148;
			//         }
			//         sub_180222690(&v402);
			// LABEL_148:
			//         v223 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                  (Int32Enum__Enum)0xA5u,
			//                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           &v406,
			//           renderGraph,
			//           (String *)"Depth of Field 4",
			//           &v408,
			//           v223,
			//           1,
			//           ProfilingHGPass__Enum_None,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//         v418 = v406;
			//         v410.handle = 0LL;
			//         v410.fallBackResource = (ResourceHandle)&v418;
			//         try
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v418, 0, 0LL);
			//           v226 = v408;
			//           if ( !v408 )
			//             sub_1802DC2C8(v225, v224);
			//           *(_OWORD *)&v408[33].monitor = v84;
			//           v226[34].monitor = (MonitorData *)ptr;
			//           v227 = v408;
			//           v230 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&v404,
			//                     &v418,
			//                     &v102.sceneColor,
			//                     0LL);
			//           if ( !v227 )
			//             sub_1802DC2C8(v229, v228);
			//           v227[14] = (Object)v230;
			//           v231 = v408;
			//           v234 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&v404,
			//                     &v418,
			//                     &v417,
			//                     0LL);
			//           if ( !v231 )
			//             sub_1802DC2C8(v233, v232);
			//           v231[17] = (Object)v234;
			//           v235 = v408;
			//           v238 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                     (TextureHandle *)&v404,
			//                     &v418,
			//                     &v426,
			//                     0LL);
			//           if ( !v235 )
			//             sub_1802DC2C8(v237, v236);
			//           v235[36] = (Object)v238;
			//           v239 = v408;
			//           if ( !v408 )
			//             sub_1802DC2C8(v237, 0LL);
			//           v408[37].monitor = (MonitorData *)v8.fields.m_mobileMaterial;
			//           v240 = dword_18D8E43F8;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v241 = ((unsigned __int64)&v239[37].monitor >> 12) & 0x1FFFFF;
			//             v242 = v241 >> 6;
			//             v243 = v241 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v242 + 36190]);
			//             do
			//               v244 = qword_18D6405E0[v242 + 36190];
			//             while ( v244 != _InterlockedCompareExchange64(&qword_18D6405E0[v242 + 36190], v244 | (1LL << v243), v244) );
			//             v240 = dword_18D8E43F8;
			//           }
			//           v245 = v408;
			//           v246 = (Object__Class *)v8.fields.m_mbp;
			//           if ( !v408 )
			//             sub_1802DC2C8(v246, 0LL);
			//           v408[37].klass = v246;
			//           if ( v240 )
			//           {
			//             v247 = ((unsigned __int64)&v245[37] >> 12) & 0x1FFFFF;
			//             v248 = v247 >> 6;
			//             v249 = v247 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v248 + 36190]);
			//             do
			//               v250 = qword_18D6405E0[v248 + 36190];
			//             while ( v250 != _InterlockedCompareExchange64(&qword_18D6405E0[v248 + 36190], v250 | (1LL << v249), v250) );
			//           }
			//           v417 = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v404,
			//             &v418,
			//             &v415,
			//             0,
			//             RenderBufferLoadAction__Enum_DontCare,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&v417,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
			//           _9__20_4 = TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_4;
			//           if ( !_9__20_4 )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
			//             v252 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9;
			//             element_class = TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>[0];
			//             if ( ((__int64)TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>[0].vtable.Equals.methodPtr & 2) == 0 )
			//             {
			//               *(_QWORD *)width = &qword_18CDB0B30;
			//               sub_1802924D0(&qword_18CDB0B30);
			//               sub_180060090(element_class, width);
			//               sub_180292530(*(_QWORD *)width);
			//             }
			//             if ( element_class._0.generic_class && ((__int64)element_class.vtable.Equals.methodPtr & 8) != 0 )
			//               element_class = (struct RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData___Class *)element_class._0.element_class;
			//             if ( ((__int64)element_class.vtable.Equals.methodPtr & 0x20) != 0 )
			//             {
			//               instance_size = element_class._1.instance_size;
			//               if ( element_class._0.gc_desc )
			//               {
			//                 _9__20_4 = (RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *)sub_180005220(instance_size, element_class);
			//                 _InterlockedIncrement64(&qword_18D8E51F8);
			//               }
			//               else
			//               {
			//                 _9__20_4 = (RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *)sub_180005D40(instance_size, element_class);
			//               }
			//             }
			//             else
			//             {
			//               _9__20_4 = (RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *)sub_180005FB0(element_class);
			//             }
			//             if ( (BYTE1(element_class.vtable.Equals.methodPtr) & 2) != 0 )
			//               sub_18002E8C0((_DWORD)_9__20_4, (unsigned int)sub_18007DC30, 0, (unsigned int)&v402, (__int64)width);
			//             if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//               sub_1802DAEC4(_9__20_4, element_class);
			//             il2cpp_runtime_class_init_0(element_class, v254);
			//             if ( !_9__20_4 )
			//               sub_1802DC2C8(v257, v256);
			//             HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
			//               (RenderFunc_1_System_Object_ *)_9__20_4,
			//               v252,
			//               MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructPass_b__20_4,
			//               0LL);
			//             TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_4 = _9__20_4;
			//             if ( dword_18D8E43F8 )
			//             {
			//               v258 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_4 >> 12) & 0x1FFFFF) >> 6;
			//               v259 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c.static_fields.__9__20_4 >> 12) & 0x3F;
			//               _m_prefetchw(&qword_18D6405E0[v258 + 36190]);
			//               do
			//                 v260 = qword_18D6405E0[v258 + 36190];
			//               while ( v260 != _InterlockedCompareExchange64(&qword_18D6405E0[v258 + 36190], v260 | (1LL << v259), v260) );
			//             }
			//           }
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v418,
			//             (RenderFunc_1_System_Object_ *)_9__20_4,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v440 )
			//         {
			//           v410.handle = (ResourceHandle)v440.ex;
			//           sub_180222690(&v410);
			//           v8 = this;
			//           goto LABEL_183;
			//         }
			//         sub_180222690(&v410);
			// LABEL_183:
			//         output.result = v415;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         v8.fields.m_previousSceneColorTexture = *(TextureHandle *)sub_182E7CCD0(&v404);
			//         v8.fields.m_currentSceneColorTexture = *(TextureHandle *)sub_182E7CCD0(&v404);
			//       }
			//       catch ( Il2CppExceptionWrapper *v438 )
			//       {
			//         *(Il2CppExceptionWrapper *)&v401 = (Il2CppExceptionWrapper)v438.ex;
			//         sub_180224750(&v401);
			//         P3 = hgCamera;
			//         v8 = this;
			//         v7 = input;
			//         v6 = (Object *)renderGraph;
			// LABEL_185:
			//         v261 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                  (Int32Enum__Enum)0xA5u,
			//                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         if ( v6 )
			//         {
			//           HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//             &v406,
			//             (HGRenderGraph *)v6,
			//             (String *)"Circle Depth of Field",
			//             &v416,
			//             v261,
			//             1,
			//             ProfilingHGPass__Enum_None,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//           v430 = v406;
			//           v410.handle = 0LL;
			//           v410.fallBackResource = (ResourceHandle)&v430;
			//           try
			//           {
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v430, 0, 0LL);
			//             v264 = v416;
			//             v406 = v430;
			//             if ( !byte_18D91951F )
			//             {
			//               sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//               sub_18003C530(&off_18D4FADC0);
			//               sub_18003C530(&off_18D4FADD0);
			//               sub_18003C530(&off_18D4FADE0);
			//               sub_18003C530(&off_18D4FADF8);
			//               sub_18003C530(&off_18D4FAD98);
			//               sub_18003C530(&off_18D4FADA0);
			//               sub_18003C530(&off_18D4FADB0);
			//               byte_18D91951F = 1;
			//             }
			//             sub_1802F01E0(&v433, 0LL, 96LL);
			//             sub_1802F01E0(&v447, 0LL, 96LL);
			//             sub_1802F01E0(&v448, 0LL, 96LL);
			//             sub_1802F01E0(&v445, 0LL, 96LL);
			//             sub_1802F01E0(&v409, 0LL, 96LL);
			//             sub_1802F01E0(v449, 0LL, 96LL);
			//             sub_1802F01E0(&v443, 0LL, 96LL);
			//             sub_1802F01E0(&v432, 0LL, 96LL);
			//             sub_1802F01E0(&v442, 0LL, 96LL);
			//             if ( IFix::WrappersManagerImpl::IsPatched(2542, 0LL) )
			//             {
			//               v393 = IFix::WrappersManagerImpl::GetPatch(2542, 0LL);
			//               if ( !v393 )
			//                 sub_1802DC2C8(v395, v394);
			//               v404 = v406;
			//               IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_935(
			//                 v393,
			//                 (Object *)v8,
			//                 v7,
			//                 v6,
			//                 (Object *)P3,
			//                 &v404,
			//                 v264,
			//                 0LL);
			//             }
			//             else
			//             {
			//               v267 = P3.fields.m_volumeComponentsData;
			//               if ( !v267 )
			//                 sub_1802DC2C8(v266, v265);
			//               v268 = v267.fields.m_depthOfField;
			//               width[0] = 1056964608;
			//               if ( !v268 )
			//                 sub_1802DC2C8(v266, v265);
			//               if ( !v268.fields.scale )
			//                 width[0] = 1065353216;
			//               if ( v268.fields.focusMode )
			//               {
			//                 v269 = 0;
			//               }
			//               else
			//               {
			//                 v270 = P3.fields.camera;
			//                 if ( !v270 )
			//                   sub_1802DC2C8(0LL, v265);
			//                 v269 = UnityEngine::Camera::get_usePhysicalProperties(v270, 0LL);
			//               }
			//               if ( !v264 )
			//                 sub_1802DC2C8(v266, v265);
			//               LOBYTE(v264[1].klass) = v269;
			//               HIDWORD(v264[1].klass) = v7.quality;
			//               v271 = P3.fields.camera;
			//               if ( !v271 )
			//                 sub_1802DC2C8(v266, v265);
			//               v272 = (__int64 (__fastcall *)(Camera *))qword_18D8F4238;
			//               if ( !qword_18D8F4238 )
			//               {
			//                 v272 = (__int64 (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_gateFit()");
			//                 qword_18D8F4238 = (__int64)v272;
			//               }
			//               v273 = v272(v271);
			//               v275 = *(_QWORD *)(*(_QWORD *)v403 + 96LL);
			//               if ( v273 == 2 )
			//               {
			//                 if ( !v275 )
			//                   sub_1802DC2C8(*(_QWORD *)v403, v274);
			//                 *(_QWORD *)v403 = 0LL;
			//                 v280 = (void (__fastcall *)(__int64, float *))qword_18D8F42C0;
			//                 if ( !qword_18D8F42C0 )
			//                 {
			//                   v280 = (void (__fastcall *)(__int64, float *))sub_180017470(
			//                                                                   "UnityEngine.Camera::get_sensorSize_Injected(UnityEngine.Vector2&)");
			//                   qword_18D8F42C0 = (__int64)v280;
			//                 }
			//                 v280(v275, v403);
			//                 v279 = _mm_cvtsi32_si128(P3.fields._taauRTSize_k__BackingField.m_X);
			//               }
			//               else
			//               {
			//                 if ( !v275 )
			//                   sub_1802DC2C8(*(_QWORD *)v403, v274);
			//                 *(_QWORD *)v403 = 0LL;
			//                 v276 = (void (__fastcall *)(__int64, float *))qword_18D8F42C0;
			//                 if ( !qword_18D8F42C0 )
			//                 {
			//                   v276 = (void (__fastcall *)(__int64, float *))sub_180017470(
			//                                                                   "UnityEngine.Camera::get_sensorSize_Injected(UnityEngine.Vector2&)");
			//                   qword_18D8F42C0 = (__int64)v276;
			//                 }
			//                 v276(v275, v403);
			//                 v279 = _mm_cvtsi32_si128(HIDWORD(*(_QWORD *)&P3.fields._taauRTSize_k__BackingField));
			//               }
			//               v281 = _mm_cvtepi32_ps(v279).m128_f32[0] * (float)(0.5 / v403[0]);
			//               v282 = P3.fields.camera;
			//               if ( !v282 )
			//                 sub_1802DC2C8(v278, v277);
			//               v283 = (double (__fastcall *)(Camera *))qword_18D92CF08;
			//               if ( !qword_18D92CF08 )
			//               {
			//                 v283 = (double (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_focalLength()");
			//                 qword_18D92CF08 = (__int64)v283;
			//               }
			//               v286 = v283(v282);
			//               *(_OWORD *)&v404.m_RenderGraph = *(_OWORD *)&P3.fields._physicalParameters_k__BackingField.m_BladeCount;
			//               v405 = P3.fields._physicalParameters_k__BackingField.m_Anamorphism;
			//               v287 = *(float *)&v286 / P3.fields._physicalParameters_k__BackingField.m_Aperture;
			//               v288 = P3.fields.camera;
			//               if ( !v288 )
			//                 sub_1802DC2C8(v285, v284);
			//               v289 = (double (__fastcall *)(Camera *))qword_18D92CF08;
			//               if ( !qword_18D92CF08 )
			//               {
			//                 v289 = (double (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_focalLength()");
			//                 qword_18D92CF08 = (__int64)v289;
			//               }
			//               v292 = v289(v288);
			//               v293 = *(float *)&v292 / 1000.0;
			//               *(_OWORD *)&v404.m_RenderGraph = *(_OWORD *)&P3.fields._physicalParameters_k__BackingField.m_BladeCount;
			//               v405 = P3.fields._physicalParameters_k__BackingField.m_Anamorphism;
			//               v294 = P3.fields._physicalParameters_k__BackingField.m_FocusDistance;
			//               v295 = v294 - (float)(*(float *)&v292 / 1000.0);
			//               if ( v295 <= 0.000001 )
			//                 v295 = 0.000001;
			//               v296 = (float)((float)(v293 * v287) * v281) / v295;
			//               v297 = P3.fields.camera;
			//               if ( !v297 )
			//                 sub_1802DC2C8(v291, v290);
			//               v298 = (float (__fastcall *)(Camera *))qword_18D8F4188;
			//               if ( !qword_18D8F4188 )
			//               {
			//                 v298 = (float (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_farClipPlane()");
			//                 qword_18D8F4188 = (__int64)v298;
			//               }
			//               v301 = (float)(1.0 - (float)(v294 / v298(v297))) * v296;
			//               v302 = P3.fields.camera;
			//               if ( !v302 )
			//                 sub_1802DC2C8(v300, v299);
			//               v303 = (double (__fastcall *)(Camera *))qword_18D8F4188;
			//               if ( !qword_18D8F4188 )
			//               {
			//                 v303 = (double (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_farClipPlane()");
			//                 qword_18D8F4188 = (__int64)v303;
			//               }
			//               v306 = v303(v302);
			//               v307 = *(float *)&v306;
			//               v308 = P3.fields.camera;
			//               if ( !v308 )
			//                 sub_1802DC2C8(v305, v304);
			//               v309 = (double (__fastcall *)(Camera *))qword_18D8F4178;
			//               if ( !qword_18D8F4178 )
			//               {
			//                 v309 = (double (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_nearClipPlane()");
			//                 qword_18D8F4178 = (__int64)v309;
			//               }
			//               v312 = v309(v308);
			//               v313 = *(float *)&v312;
			//               v314 = P3.fields.camera;
			//               if ( !v314 )
			//                 sub_1802DC2C8(v311, v310);
			//               v315 = (double (__fastcall *)(Camera *))qword_18D8F4188;
			//               if ( !qword_18D8F4188 )
			//               {
			//                 v315 = (double (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_farClipPlane()");
			//                 qword_18D8F4188 = (__int64)v315;
			//               }
			//               v318 = v315(v314);
			//               v319 = P3.fields.camera;
			//               if ( !v319 )
			//                 sub_1802DC2C8(v317, v316);
			//               v320 = (float (__fastcall *)(Camera *))qword_18D8F4178;
			//               if ( !qword_18D8F4178 )
			//               {
			//                 v320 = (float (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_nearClipPlane()");
			//                 qword_18D8F4178 = (__int64)v320;
			//               }
			//               *(float *)&v321 = (float)((float)(v307 - v313) * (float)(v296 * v294))
			//                               / (float)(*(float *)&v318 * v320(v319));
			//               v322 = v268.fields.nearFocusStart;
			//               v323 = v268.fields.nearFocusEnd;
			//               v324 = 0;
			//               v325 = Rewired::Utils::MathTools::Clamp(v268.fields.nearRadius, 0.0, input.depthOfFieldMaxRadius, 0LL);
			//               v326 = v268.fields.farFocusStart;
			//               v327 = v268.fields.farFocusEnd;
			//               v328 = Rewired::Utils::MathTools::Clamp(v268.fields.farRadius, 0.0, input.depthOfFieldMaxRadius, 0LL);
			//               Rewired::Utils::MathTools::Clamp(v268.fields.temporalFactor, 0.1, 1.0, 0LL);
			//               v332 = sub_1802EB1B0(v330, v329);
			//               v333 = (float)(int)HIDWORD(*(_QWORD *)&P3.fields._sceneRTSize_k__BackingField);
			//               *(_QWORD *)&v401 = __PAIR64__(v321, LODWORD(v301));
			//               v334 = *(float *)width;
			//               *((_QWORD *)&v401 + 1) = __PAIR64__(LODWORD(v332), width[0]);
			//               *(_OWORD *)&v264[1].monitor = v401;
			//               *(_QWORD *)&v401 = __PAIR64__(LODWORD(v323), LODWORD(v322));
			//               *((_QWORD *)&v401 + 1) = COERCE_UNSIGNED_INT((float)(v333 * v325) / 1440.0);
			//               *(_OWORD *)&v264[2].monitor = v401;
			//               *(_QWORD *)&v401 = __PAIR64__(LODWORD(v327), LODWORD(v326));
			//               *((_QWORD *)&v401 + 1) = COERCE_UNSIGNED_INT((float)(v333 * v328) / 1440.0);
			//               *(_OWORD *)&v264[3].monitor = v401;
			//               if ( P3.fields.prevTransformReset )
			//                 v324 = 1065353216;
			//               LODWORD(v401) = 0;
			//               *(_QWORD *)((char *)&v401 + 4) = v324;
			//               HIDWORD(v401) = 0;
			//               *(_OWORD *)&v264[4].monitor = v401;
			//               *(__m128i *)&v264[9].monitor = _mm_loadu_si128((const __m128i *)&P3.fields._sceneRTSizeParam_k__BackingField);
			//               v264[12].monitor = (MonitorData *)P3.fields._sceneRTSize_k__BackingField;
			//               v335 = (float)(int)HIDWORD(*(_QWORD *)&P3.fields._sceneRTSize_k__BackingField) * v334;
			//               v336 = HIDWORD(*(_QWORD *)&P3.fields._sceneRTSize_k__BackingField);
			//               v337 = (float)(1.0 / (float)(int)HIDWORD(*(_QWORD *)&P3.fields._sceneRTSize_k__BackingField)) / v334;
			//               v338 = (float)(1.0 / (float)P3.fields._sceneRTSize_k__BackingField.m_X) / v334;
			//               *(float *)&v401 = (float)P3.fields._sceneRTSize_k__BackingField.m_X * v334;
			//               *((float *)&v401 + 1) = v335;
			//               *((float *)&v401 + 2) = v338;
			//               *((float *)&v401 + 3) = v337;
			//               *(_OWORD *)&v264[10].monitor = v401;
			//               v339 = sub_182592070(v336, 0, v331);
			//               v342 = sub_182592070(v340, 0, v341);
			//               *(_QWORD *)v403 = __PAIR64__(v342, v339);
			//               v264[13].klass = (Object__Class *)__PAIR64__(v342, v339);
			//               *(float *)&v343 = (float)(int)HIDWORD(*(_QWORD *)&P3.fields._sceneRTSize_k__BackingField) * 0.125;
			//               v344 = (float)(1.0 / (float)(int)HIDWORD(*(_QWORD *)&P3.fields._sceneRTSize_k__BackingField)) * 8.0;
			//               *(float *)&v345 = (float)(1.0 / (float)P3.fields._sceneRTSize_k__BackingField.m_X) * 8.0;
			//               *(float *)&v401 = (float)P3.fields._sceneRTSize_k__BackingField.m_X * 0.125;
			//               *(_QWORD *)((char *)&v401 + 4) = __PAIR64__(v345, v343);
			//               *((float *)&v401 + 3) = v344;
			//               sub_180002BF0(v264);
			//               *(_OWORD *)&v264[11].monitor = v401;
			//               sub_180002BF0(v264);
			//               v348 = sub_182592070(v346, 0, v347);
			//               sub_180002BF0(v264);
			//               *(_QWORD *)v403 = __PAIR64__(sub_182592070(v349, 0, v350), v348);
			//               sub_180002BF0(v264);
			//               v264[13].monitor = *(MonitorData **)v403;
			//               v351 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &input.sceneColor,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[14] = (Object)v351;
			//               v352 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &input.sceneDepth,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[15] = (Object)v352;
			//               v353 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &input.motionVectorTexture,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[16] = (Object)v353;
			//               sub_180002BF0(v264);
			//               monitor = (int32_t)v264[12].monitor;
			//               sub_180002BF0(v264);
			//               HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v409, monitor, HIDWORD(v264[12].monitor), 0LL);
			//               v409.colorFormat = 46;
			//               v409.enableRandomWrite = 1;
			//               v409.name = (String *)"Depth Of Field CoC";
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v355 = (((unsigned __int64)&v409.name >> 12) & 0x1FFFFF) >> 6;
			//                 _m_prefetchw(&qword_18D6405E0[v355 + 36190]);
			//                 do
			//                   v356 = qword_18D6405E0[v355 + 36190];
			//                 while ( v356 != _InterlockedCompareExchange64(
			//                                   &qword_18D6405E0[v355 + 36190],
			//                                   v356 | (1LL << (((unsigned __int64)&v409.name >> 12) & 0x3F)),
			//                                   v356) );
			//               }
			//               v409.wrapMode = 1;
			//               v409.filterMode = 1;
			//               v447 = v409;
			//               v357 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v447,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[17] = (Object)v357;
			//               sub_180002BF0(v264);
			//               klass = (int32_t)v264[13].klass;
			//               sub_180002BF0(v264);
			//               HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v409, klass, HIDWORD(v264[13].klass), 0LL);
			//               v409.colorFormat = 46;
			//               v409.enableRandomWrite = 1;
			//               v409.name = (String *)"Depth Of Field CoC Downsample";
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v359 = (((unsigned __int64)&v409.name >> 12) & 0x1FFFFF) >> 6;
			//                 _m_prefetchw(&qword_18D6405E0[v359 + 36190]);
			//                 do
			//                   v360 = qword_18D6405E0[v359 + 36190];
			//                 while ( v360 != _InterlockedCompareExchange64(
			//                                   &qword_18D6405E0[v359 + 36190],
			//                                   v360 | (1LL << (((unsigned __int64)&v409.name >> 12) & 0x3F)),
			//                                   v360) );
			//               }
			//               v409.wrapMode = 1;
			//               v409.filterMode = 1;
			//               v448 = v409;
			//               v361 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v448,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[18] = (Object)v361;
			//               sub_180002BF0(v264);
			//               v362 = (int32_t)v264[13].monitor;
			//               sub_180002BF0(v264);
			//               HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v409, v362, HIDWORD(v264[13].monitor), 0LL);
			//               v409.colorFormat = 49;
			//               v409.enableRandomWrite = 1;
			//               v409.name = (String *)"Depth Of Field Tile CoC";
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v363 = (((unsigned __int64)&v409.name >> 12) & 0x1FFFFF) >> 6;
			//                 _m_prefetchw(&qword_18D6405E0[v363 + 36190]);
			//                 do
			//                   v364 = qword_18D6405E0[v363 + 36190];
			//                 while ( v364 != _InterlockedCompareExchange64(
			//                                   &qword_18D6405E0[v363 + 36190],
			//                                   v364 | (1LL << (((unsigned __int64)&v409.name >> 12) & 0x3F)),
			//                                   v364) );
			//               }
			//               v409.wrapMode = 1;
			//               v409.filterMode = 1;
			//               v445 = v409;
			//               v365 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v445,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[19] = (Object)v365;
			//               v366 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v445,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[20] = (Object)v366;
			//               sub_180002BF0(v264);
			//               v367 = (int32_t)v264[13].klass;
			//               sub_180002BF0(v264);
			//               HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v409, v367, HIDWORD(v264[13].klass), 0LL);
			//               v409.colorFormat = 48;
			//               v409.enableRandomWrite = 1;
			//               v409.name = (String *)"Depth Of Field Color Downsample";
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v368 = (((unsigned __int64)&v409.name >> 12) & 0x1FFFFF) >> 6;
			//                 _m_prefetchw(&qword_18D6405E0[v368 + 36190]);
			//                 do
			//                   v369 = qword_18D6405E0[v368 + 36190];
			//                 while ( v369 != _InterlockedCompareExchange64(
			//                                   &qword_18D6405E0[v368 + 36190],
			//                                   v369 | (1LL << (((unsigned __int64)&v409.name >> 12) & 0x3F)),
			//                                   v369) );
			//               }
			//               v409.wrapMode = 1;
			//               v409.filterMode = 1;
			//               v449[0] = v409;
			//               v8.fields.m_currentSceneColorTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                          (TextureHandle *)&v404,
			//                                                          renderGraph,
			//                                                          v449,
			//                                                          0LL);
			//               v370 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v8.fields.m_currentSceneColorTexture,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[31] = (Object)v370;
			//               sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//               if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(
			//                      &v8.fields.m_previousSceneColorTexture,
			//                      0LL) )
			//               {
			//                 v371 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                           (TextureHandle *)&v404,
			//                           &v406,
			//                           &v8.fields.m_previousSceneColorTexture,
			//                           0LL);
			//               }
			//               else
			//               {
			//                 v371 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                           (TextureHandle *)&v404,
			//                           &v406,
			//                           &input.sceneColor,
			//                           0LL);
			//               }
			//               sub_180002BF0(v264);
			//               v264[30] = (Object)v371;
			//               sub_180002BF0(v264);
			//               width[0] = (int32_t)v264[13].klass;
			//               sub_180002BF0(v264);
			//               HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v409, width[0], HIDWORD(v264[13].klass), 0LL);
			//               v409.colorFormat = 48;
			//               v409.enableRandomWrite = 1;
			//               v409.name = (String *)"Depth Of Field Color One Component";
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v372 = (((unsigned __int64)&v409.name >> 12) & 0x1FFFFF) >> 6;
			//                 _m_prefetchw(&qword_18D6405E0[v372 + 36190]);
			//                 do
			//                   v373 = qword_18D6405E0[v372 + 36190];
			//                 while ( v373 != _InterlockedCompareExchange64(
			//                                   &qword_18D6405E0[v372 + 36190],
			//                                   v373 | (1LL << (((unsigned __int64)&v409.name >> 12) & 0x3F)),
			//                                   v373) );
			//               }
			//               v409.wrapMode = 1;
			//               v409.filterMode = 1;
			//               v443 = v409;
			//               v374 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v443,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[21] = (Object)v374;
			//               v375 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v443,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[22] = (Object)v375;
			//               v376 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v443,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[23] = (Object)v376;
			//               sub_180002BF0(v264);
			//               width[0] = (int32_t)v264[13].klass;
			//               sub_180002BF0(v264);
			//               HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v409, width[0], HIDWORD(v264[13].klass), 0LL);
			//               v409.colorFormat = 49;
			//               v409.enableRandomWrite = 1;
			//               v409.name = (String *)"Depth Of Field Color One Component Alpha";
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v377 = (((unsigned __int64)&v409.name >> 12) & 0x1FFFFF) >> 6;
			//                 _m_prefetchw(&qword_18D6405E0[v377 + 36190]);
			//                 do
			//                   v378 = qword_18D6405E0[v377 + 36190];
			//                 while ( v378 != _InterlockedCompareExchange64(
			//                                   &qword_18D6405E0[v377 + 36190],
			//                                   v378 | (1LL << (((unsigned __int64)&v409.name >> 12) & 0x3F)),
			//                                   v378) );
			//               }
			//               v409.wrapMode = 1;
			//               v409.filterMode = 1;
			//               v432 = v409;
			//               v379 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v432,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[24] = (Object)v379;
			//               v380 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v432,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[25] = (Object)v380;
			//               sub_180002BF0(v264);
			//               width[0] = (int32_t)v264[13].klass;
			//               sub_180002BF0(v264);
			//               HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v409, width[0], HIDWORD(v264[13].klass), 0LL);
			//               v409.colorFormat = 48;
			//               v409.enableRandomWrite = 1;
			//               v409.name = (String *)"Depth Of Field Color Two Components";
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v381 = (((unsigned __int64)&v409.name >> 12) & 0x1FFFFF) >> 6;
			//                 _m_prefetchw(&qword_18D6405E0[v381 + 36190]);
			//                 do
			//                   v382 = qword_18D6405E0[v381 + 36190];
			//                 while ( v382 != _InterlockedCompareExchange64(
			//                                   &qword_18D6405E0[v381 + 36190],
			//                                   v382 | (1LL << (((unsigned __int64)&v409.name >> 12) & 0x3F)),
			//                                   v382) );
			//               }
			//               v409.wrapMode = 1;
			//               v409.filterMode = 1;
			//               v442 = v409;
			//               v383 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v442,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[26] = (Object)v383;
			//               v384 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v442,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[27] = (Object)v384;
			//               v385 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v442,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[28] = (Object)v385;
			//               v386 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v442,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[29] = (Object)v386;
			//               v433 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                         renderGraph,
			//                         &input.sceneColor,
			//                         0LL);
			//               v433.enableRandomWrite = 1;
			//               v415 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                         (TextureHandle *)&v404,
			//                         renderGraph,
			//                         &v433,
			//                         0LL);
			//               v387 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                         (TextureHandle *)&v404,
			//                         &v406,
			//                         &v415,
			//                         0LL);
			//               sub_180002BF0(v264);
			//               v264[32] = (Object)v387;
			//               m_shader = (Object__Class *)v8.fields.m_shader;
			//               sub_180002BF0(v264);
			//               v264[33].klass = m_shader;
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v389 = ((unsigned __int64)&v264[33] >> 12) & 0x1FFFFF;
			//                 v390 = v389 >> 6;
			//                 v391 = v389 & 0x3F;
			//                 _m_prefetchw(&qword_18D6405E0[v390 + 36190]);
			//                 do
			//                   v392 = qword_18D6405E0[v390 + 36190];
			//                 while ( v392 != _InterlockedCompareExchange64(
			//                                   &qword_18D6405E0[v390 + 36190],
			//                                   v392 | (1LL << v391),
			//                                   v392) );
			//               }
			//             }
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//               &v430,
			//               (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor.static_fields.s_circleDepthOfDieldRenderFunc,
			//               0LL,
			//               0,
			//               MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
			//             v396 = (DepthOfFieldPassConstructor_PassOutput *)v416;
			//             sub_180002BF0(v416);
			//             *output = v396[32];
			//           }
			//           catch ( Il2CppExceptionWrapper *v439 )
			//           {
			//             v410.handle = (ResourceHandle)v439.ex;
			//           }
			//           sub_180222690(&v410);
			//           return;
			//         }
			//         sub_1802DC2C8(v263, v262);
			//       }
			//       sub_180224750(&v401);
			//     }
			//     else
			//     {
			//       *output = (DepthOfFieldPassConstructor_PassOutput)v7.sceneColor;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v8.fields.m_previousSceneColorTexture = *(TextureHandle *)sub_182E7CCD0(&v404);
			//       v8.fields.m_currentSceneColorTexture = *(TextureHandle *)sub_182E7CCD0(&v404);
			//       v8.fields.m_fallbackPreviousFrame = 1;
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::DepthOfFieldPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         DepthOfFieldPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2556, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2556, 0LL);
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
			// void HG::Rendering::Runtime::DepthOfFieldPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         DepthOfFieldPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2557, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2557, 0LL);
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
			// void HG::Rendering::Runtime::DepthOfFieldPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         DepthOfFieldPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rcx
			//   TextureHandle *v6; // rax
			//   HGRenderGraph *renderGraph; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v9; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919521 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4FA760);
			//     byte_18D919521 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2558, 0LL) )
			//   {
			//     if ( input.passSkipped )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       this.fields.m_currentSceneColorTexture = *(TextureHandle *)sub_182E7CCD0(&v9);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this.fields.m_currentSceneColorTexture, 0LL) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v6 = (TextureHandle *)sub_182E7CCD0(&v9);
			// LABEL_10:
			//       this.fields.m_previousSceneColorTexture = *v6;
			//       return;
			//     }
			//     renderGraph = input.renderGraph;
			//     if ( renderGraph )
			//     {
			//       v6 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//              &v9,
			//              renderGraph,
			//              &this.fields.m_currentSceneColorTexture,
			//              1,
			//              (String *)"Depth Of Field",
			//              0LL);
			//       goto LABEL_10;
			//     }
			// LABEL_12:
			//     sub_180B536AC(v5, renderGraph);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2558, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::DepthOfFieldPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         DepthOfFieldPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2559, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2559, 0LL);
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

		public bool IfEnable(HGCamera hgCamera, ref DepthOfFieldPassConstructor.PassInput input)
		{
			// // Boolean IfEnable(HGCamera, DepthOfFieldPassConstructor+PassInput ByRef)
			// bool HG::Rendering::Runtime::DepthOfFieldPassConstructor::IfEnable(
			//         DepthOfFieldPassConstructor *this,
			//         HGCamera *hgCamera,
			//         DepthOfFieldPassConstructor_PassInput *input,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   Camera *camera; // rcx
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
			//   HGDepthOfField *m_depthOfField; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919522 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919522 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2545, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2545, 0LL);
			//     if ( !Patch )
			//       goto LABEL_13;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_937(Patch, (Object *)this, (Object *)hgCamera, input, 0LL);
			//   }
			//   else
			//   {
			//     if ( !hgCamera )
			//       goto LABEL_13;
			//     m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//     if ( !m_volumeComponentsData )
			//       goto LABEL_13;
			//     m_depthOfField = m_volumeComponentsData.fields.m_depthOfField;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Equality((Object_1 *)m_depthOfField, 0LL, 0LL) )
			//     {
			//       if ( !m_depthOfField )
			//         goto LABEL_13;
			//       if ( HG::Rendering::Runtime::HGDepthOfField::IsActive(m_depthOfField, 0LL) )
			//       {
			//         camera = hgCamera.fields.camera;
			//         if ( camera )
			//           return UnityEngine::Camera::get_cameraType(camera, 0LL) == CameraType__Enum_Game;
			// LABEL_13:
			//         sub_180B536AC(camera, v7);
			//       }
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		private bool m_enable;

		private TextureHandle m_currentSceneColorTexture;

		private TextureHandle m_previousSceneColorTexture;

		private bool m_fallbackPreviousFrame;

		private ComputeShader m_shader;

		private Material m_mobileMaterial;

		private MaterialPropertyBlock m_mbp;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<DepthOfFieldPassConstructor.CircleDepthOfFieldPassData> s_circleDepthOfDieldHighQualityRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<DepthOfFieldPassConstructor.CircleDepthOfFieldPassData> s_circleDepthOfDieldLowQualityRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<DepthOfFieldPassConstructor.CircleDepthOfFieldPassData> s_circleDepthOfDieldRenderFunc;

		private enum GaussianPassID
		{
			CoC,
			Temporal,
			Downsample,
			Horizonal,
			Vertical,
			Apply
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		internal struct PassInput
		{
			internal HGDepthOfFieldQuality quality;

			internal float depthOfFieldMaxRadius;

			internal TextureHandle motionVectorTexture;

			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			public ScriptableRenderContext renderContext;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassOutput
		{
			internal TextureHandle result;
		}

		private class CircleDepthOfFieldPassData
		{
			public CircleDepthOfFieldPassData()
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

			public bool usePhysicalCamera;

			public HGDepthOfFieldQuality quality;

			public Vector4 param0;

			public Vector4 param1;

			public Vector4 param2;

			public Vector4 param3;

			public Vector4 nearStartColor;

			public Vector4 nearEndColor;

			public Vector4 farStartColor;

			public Vector4 farEndColor;

			public Vector4 screenSize;

			public Vector4 downsampleScreenSize;

			public Vector4 tileCoCScreenSize;

			public Vector2Int screenSizeInt;

			public Vector2Int downsampleScreenSizeInt;

			public Vector2Int tileCoCScreenSizeInt;

			public TextureHandle sceneColorTexture;

			public TextureHandle sceneDepthTexture;

			public TextureHandle motionVectorTexture;

			public TextureHandle cocTexture;

			public TextureHandle downsampleCoCTexture;

			public TextureHandle tileCoCTexture;

			public TextureHandle blurTileCoCTexture;

			public TextureHandle oneComponentVeritcalTexture0;

			public TextureHandle oneComponentVeritcalTexture1;

			public TextureHandle oneComponentHorizontalTexture;

			public TextureHandle oneComponentAlphaTexture0;

			public TextureHandle oneComponentAlphaTexture1;

			public TextureHandle twoComponentsVerticalTexture0;

			public TextureHandle twoComponentsVerticalTexture1;

			public TextureHandle twoComponentsVerticalTexture2;

			public TextureHandle farHorizontalTexture;

			public TextureHandle previousDownSampleSceneColorTexture;

			public TextureHandle currentDownSampleSceneColorTexture;

			public TextureHandle outputTexture;

			public ComputeShader computeShader;

			public CBHandle cbHandle;

			public TextureHandle blurTexture0;

			public TextureHandle blurTexture1;

			public MaterialPropertyBlock mpb;

			public Material material;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 96)]
		public struct DepthOfFieldData
		{
			public Vector4 param0;

			public Vector4 param1;

			public Vector4 param2;

			public Vector4 param3;

			public Vector4 downsampleScreenSize;

			public Vector4 tileCoCScreenSize;
		}
	}
}
