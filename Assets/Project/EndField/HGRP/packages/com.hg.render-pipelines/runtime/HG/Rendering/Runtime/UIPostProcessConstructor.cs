using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class UIPostProcessConstructor : IPassConstructor
	{
		internal UIPostProcessConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void UIUberPass(ref UIPostProcessConstructor.PassInput input, HGSettingParameters settingParameters, HGRenderGraph renderGraph, HGCamera camera, TextureHandle bloomTexture, Vector4 bloomBicubicParams)
		{
			// // Void UIUberPass(UIPostProcessConstructor+PassInput ByRef, HGSettingParameters, HGRenderGraph, HGCamera, TextureHandle, Vector4)
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// void HG::Rendering::Runtime::UIPostProcessConstructor::UIUberPass(
			//         UIPostProcessConstructor *this,
			//         UIPostProcessConstructor_PassInput *input,
			//         HGSettingParameters *settingParameters,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         TextureHandle *bloomTexture,
			//         Vector4 *bloomBicubicParams,
			//         MethodInfo *method)
			// {
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rbx
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   HGCamera_VolumeComponentsData *v19; // r14
			//   Object *m_bloom; // r14
			//   ProfilingSampler *v21; // rax
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   signed __int64 v24; // rcx
			//   Object *v25; // rdx
			//   unsigned int v26; // edx
			//   unsigned __int64 v27; // r8
			//   signed __int64 v28; // rtt
			//   Object__Class *klass; // rcx
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   MonitorData *monitor; // rbx
			//   Material *ppMaterial; // rsi
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   Object__Class *v36; // rsi
			//   Material *m_uiPPMaterial; // rbx
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   __int64 v42; // rdx
			//   __int64 v43; // rcx
			//   MonitorData *v44; // rbx
			//   __int64 v45; // rdx
			//   int v46; // ecx
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   double v49; // xmm0_8
			//   float v50; // xmm9_4
			//   float v51; // xmm10_4
			//   MonitorData *v52; // rbx
			//   __m128 v53; // xmm6
			//   float v54; // xmm3_4
			//   Vector4 *one; // rax
			//   __int64 v56; // rdx
			//   __int64 v57; // rcx
			//   __m128i v58; // xmm11
			//   MonitorData *v59; // rbx
			//   Object_1 *v60; // rbx
			//   __int64 v61; // rdx
			//   __int64 v62; // rcx
			//   __int64 (*v63)(void); // rax
			//   _QWORD *v64; // rbx
			//   MonitorData *v65; // rbx
			//   __int64 v66; // rdx
			//   __int64 v67; // rcx
			//   bool dirtEnabled; // r13
			//   int v69; // r15d
			//   __int64 v70; // rdx
			//   __int64 v71; // rcx
			//   float v72; // xmm6_4
			//   float v73; // xmm7_4
			//   Object__Class *v74; // rdi
			//   unsigned __int64 v75; // rdx
			//   signed __int64 v76; // rcx
			//   double v77; // xmm0_8
			//   float v78; // xmm8_4
			//   unsigned __int64 v79; // r8
			//   signed __int64 v80; // rtt
			//   Object__Class *v81; // rbx
			//   float v82; // xmm1_4
			//   __int64 v83; // rdx
			//   HGShaderKeyWords__StaticFields *v84; // rcx
			//   String *s_BloomDirt; // rbx
			//   HGVignette *v86; // rdi
			//   void (__fastcall *v87)(HGVignette *, String *); // rax
			//   HGShaderKeyWords__StaticFields *static_fields; // rcx
			//   __int64 v89; // rdx
			//   ILFixDynamicMethodWrapper_2 *v90; // rcx
			//   Object *v91; // rbx
			//   __int64 v92; // rdx
			//   __int64 v93; // rcx
			//   TextureHandle v94; // xmm0
			//   Object__Class *v95; // rbx
			//   __int64 v96; // rdx
			//   __int64 v97; // rcx
			//   TextureHandle v98; // xmm0
			//   __int64 v99; // rdx
			//   __int64 v100; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rbx
			//   Object *v102; // [rsp+50h] [rbp-138h] BYREF
			//   Vector4 v103; // [rsp+60h] [rbp-128h] BYREF
			//   HGVignette *hgVignette; // [rsp+70h] [rbp-118h]
			//   Vignette *vignette[2]; // [rsp+78h] [rbp-110h] BYREF
			//   TextureHandle v106; // [rsp+90h] [rbp-F8h] BYREF
			//   Vector4 si128; // [rsp+A0h] [rbp-E8h] BYREF
			//   HGRenderGraphBuilder v108; // [rsp+B0h] [rbp-D8h] BYREF
			//   HGRenderGraphBuilder v109; // [rsp+D0h] [rbp-B8h] BYREF
			// 
			//   if ( !byte_18D9195E0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIPostProcessConstructor::UIPPPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UIPostProcessConstructor::UIPPPassData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     sub_18003C530(&off_18D5032B8);
			//     byte_18D9195E0 = 1;
			//   }
			//   v102 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2860, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2860, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v100, v99);
			//     si128 = *bloomBicubicParams;
			//     v106 = *bloomTexture;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1039(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       (Object *)settingParameters,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       &v106,
			//       &si128,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !camera )
			//       sub_180B536AC(v13, v12);
			//     *(BitArray128 *)&v108.m_RenderPass = camera.fields._frameSettings_k__BackingField.bitDatas;
			//     v108.m_RenderGraph = *(HGRenderGraph **)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//     if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//            (FrameSettings *)&v108,
			//            FrameSettingsField__Enum_Postprocess,
			//            0LL) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     }
			//     m_volumeComponentsData = camera.fields.m_volumeComponentsData;
			//     if ( !m_volumeComponentsData )
			//       sub_180B536AC(v15, v14);
			//     vignette[0] = m_volumeComponentsData.fields.m_vignette;
			//     hgVignette = m_volumeComponentsData.fields.m_hgVignette;
			//     *(BitArray128 *)&v108.m_RenderPass = camera.fields._frameSettings_k__BackingField.bitDatas;
			//     v108.m_RenderGraph = *(HGRenderGraph **)&camera.fields._frameSettings_k__BackingField.materialQuality;
			//     HG::Rendering::Runtime::FrameSettings::IsEnabled((FrameSettings *)&v108, FrameSettingsField__Enum_Vignette, 0LL);
			//     v19 = camera.fields.m_volumeComponentsData;
			//     if ( !v19 )
			//       sub_180B536AC(v18, v17);
			//     m_bloom = (Object *)v19.fields.m_bloom;
			//     if ( !camera.fields.camera )
			//       sub_180B536AC(v18, v17);
			//     UnityEngine::Camera::get_cameraType(camera.fields.camera, 0LL);
			//     v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x9Cu,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v23, v22);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v108,
			//       renderGraph,
			//       (String *)"UI Uber Post",
			//       &v102,
			//       v21,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UIPostProcessConstructor::UIPPPassData>);
			//     v109 = v108;
			//     v106.handle = 0LL;
			//     v106.fallBackResource = (ResourceHandle)&v109;
			//     v25 = v102;
			//     if ( !v102 )
			//       sub_1802DC2C8(v24, 0LL);
			//     v102[2].klass = (Object__Class *)this.fields.m_uiPPMaterial;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v26 = ((unsigned __int64)&v25[2] >> 12) & 0x1FFFFF;
			//       v27 = (unsigned __int64)v26 >> 6;
			//       v25 = (Object *)(v26 & 0x3F);
			//       _m_prefetchw(&qword_18D6405E0[v27 + 36190]);
			//       do
			//       {
			//         v24 = qword_18D6405E0[v27 + 36190] | (1LL << (char)v25);
			//         v28 = qword_18D6405E0[v27 + 36190];
			//       }
			//       while ( v28 != _InterlockedCompareExchange64(&qword_18D6405E0[v27 + 36190], v24, v28) );
			//     }
			//     if ( !v102 )
			//       sub_1802DC2C8(v24, v25);
			//     klass = v102[2].klass;
			//     if ( !klass )
			//       sub_1802DC2C8(0LL, v25);
			//     UnityEngine::Material::SetEnabledKeywords((Material *)klass, 0LL, 0LL);
			//     if ( !v102 )
			//       sub_1802DC2C8(v31, v30);
			//     monitor = v102[2].monitor;
			//     ppMaterial = this.fields.m_uiPPMaterial;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     HG::Rendering::Runtime::UberPostPassUtils::PrepareVignetteParameters(
			//       settingParameters,
			//       (UberPostPassUtils_PPVignetteData *)monitor,
			//       vignette[0],
			//       hgVignette,
			//       ppMaterial,
			//       0LL);
			//     if ( !v102 )
			//       sub_1802DC2C8(v35, v34);
			//     v36 = v102[3].klass;
			//     m_uiPPMaterial = this.fields.m_uiPPMaterial;
			//     hgVignette = (HGVignette *)m_uiPPMaterial;
			//     if ( !byte_18D9194C2 )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorUtils);
			//       sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//       sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//       byte_18D9194C2 = 1;
			//     }
			//     si128 = 0LL;
			//     if ( IFix::WrappersManagerImpl::IsPatched(2413, 0LL) )
			//     {
			//       v90 = IFix::WrappersManagerImpl::GetPatch(2413, 0LL);
			//       if ( !v90 )
			//         sub_1802DC2C8(0LL, v89);
			//       v103 = *bloomBicubicParams;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_870(
			//         v90,
			//         (Object *)settingParameters,
			//         (Object *)v36,
			//         m_bloom,
			//         &v103,
			//         (Object *)camera,
			//         (Object *)m_uiPPMaterial,
			//         0LL);
			//     }
			//     else
			//     {
			//       if ( !m_bloom )
			//         sub_1802DC2C8(v39, v38);
			//       if ( HG::Rendering::Runtime::Bloom::IsActive((Bloom *)m_bloom, 0LL) )
			//       {
			//         if ( !settingParameters )
			//           sub_1802DC2C8(v41, v40);
			//         if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                settingParameters.fields._bloomEnabled_k__BackingField,
			//                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//         {
			//           v44 = m_bloom[6].monitor;
			//           if ( !v44 )
			//             sub_1802DC2C8(v43, v42);
			//           sub_180003EE0(*(_QWORD *)v44);
			//           (*(void (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v44 + 480LL))(
			//             v44,
			//             *(_QWORD *)(*(_QWORD *)v44 + 488LL));
			//           v49 = sub_1802EB1B0(v46, v45);
			//           v50 = 1.0;
			//           v51 = *(float *)&v49 - 1.0;
			//           v52 = m_bloom[9].monitor;
			//           if ( !v52 )
			//             sub_1802DC2C8(v48, v47);
			//           sub_180003EE0(*(_QWORD *)v52);
			//           si128 = *(Vector4 *)(*(__int64 (__fastcall **)(Vector4 *, MonitorData *, _QWORD))(*(_QWORD *)v52 + 480LL))(
			//                                 &v103,
			//                                 v52,
			//                                 *(_QWORD *)(*(_QWORD *)v52 + 488LL));
			//           v53 = (__m128)_mm_loadu_si128((const __m128i *)sub_182F8C840(&v103, &si128));
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ColorUtils);
			//           v54 = (float)(_mm_shuffle_ps(v53, v53, 170).m128_f32[0] * 0.072175004)
			//               + (float)((float)(_mm_shuffle_ps(v53, v53, 85).m128_f32[0] * 0.7151522)
			//                       + (float)(v53.m128_f32[0] * 0.2126729));
			//           if ( v54 <= 0.0 )
			//           {
			//             one = UnityEngine::Vector4::get_one(&v103, 0LL);
			//           }
			//           else
			//           {
			//             v103 = (Vector4)v53;
			//             one = UnityEngine::Vector4::op_Multiply((Vector4 *)vignette, &v103, 1.0 / v54, 0LL);
			//           }
			//           v58 = _mm_loadu_si128((const __m128i *)one);
			//           v59 = m_bloom[12].monitor;
			//           if ( !v59 )
			//             sub_1802DC2C8(v57, v56);
			//           sub_180003EE0(*(_QWORD *)v59);
			//           v60 = (Object_1 *)(*(__int64 (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v59 + 480LL))(
			//                               v59,
			//                               *(_QWORD *)(*(_QWORD *)v59 + 488LL));
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           if ( UnityEngine::Object::op_Equality(v60, 0LL, 0LL) )
			//           {
			//             v63 = (__int64 (*)(void))qword_18D8F4A10;
			//             if ( !qword_18D8F4A10 )
			//             {
			//               v63 = (__int64 (*)(void))sub_180017470("UnityEngine.Texture2D::get_blackTexture()");
			//               qword_18D8F4A10 = (__int64)v63;
			//             }
			//             v64 = (_QWORD *)v63();
			//           }
			//           else
			//           {
			//             v65 = m_bloom[12].monitor;
			//             if ( !v65 )
			//               sub_1802DC2C8(v62, v61);
			//             sub_180003EE0(*(_QWORD *)v65);
			//             v64 = (_QWORD *)(*(__int64 (__fastcall **)(MonitorData *, _QWORD))(*(_QWORD *)v65 + 480LL))(
			//                               v65,
			//                               *(_QWORD *)(*(_QWORD *)v65 + 488LL));
			//           }
			//           dirtEnabled = HG::Rendering::Runtime::Bloom::get_dirtEnabled((Bloom *)m_bloom, 0LL);
			//           if ( !v64 )
			//             sub_1802DC2C8(v67, v66);
			//           sub_180003EE0(*v64);
			//           v69 = (*(__int64 (__fastcall **)(_QWORD *, _QWORD))(*v64 + 400LL))(v64, *(_QWORD *)(*v64 + 408LL));
			//           sub_180003EE0(*v64);
			//           v72 = (float)v69
			//               / (float)(*(int (__fastcall **)(_QWORD *, _QWORD))(*v64 + 432LL))(v64, *(_QWORD *)(*v64 + 440LL));
			//           v73 = (float)camera.fields._taauRTSize_k__BackingField.m_X
			//               / (float)(int)HIDWORD(*(_QWORD *)&camera.fields._taauRTSize_k__BackingField);
			//           *(__m128i *)vignette = _mm_load_si128((const __m128i *)&xmmword_18A357570);
			//           v74 = m_bloom[13].klass;
			//           if ( !v74 )
			//             sub_1802DC2C8(v71, v70);
			//           sub_180003EE0(v74._0.image);
			//           v77 = ((double (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v74._0.image[6].nameToClassHashTable)(
			//                   v74,
			//                   v74._0.image[6].codeGenModule);
			//           v78 = *(float *)&v77;
			//           if ( v72 > v73 )
			//           {
			//             *(float *)vignette = v73 / v72;
			//             *(float *)&vignette[1] = (float)(1.0 - (float)(v73 / v72)) * 0.5;
			//           }
			//           else if ( v73 > v72 )
			//           {
			//             *((float *)vignette + 1) = v72 / v73;
			//             *((float *)&vignette[1] + 1) = (float)(1.0 - (float)(v72 / v73)) * 0.5;
			//           }
			//           if ( !v36 )
			//             sub_1802DC2C8(v76, v75);
			//           v36._0.byval_arg.data.dummy = v64;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v79 = (((unsigned __int64)&v36._0.byval_arg >> 12) & 0x1FFFFF) >> 6;
			//             v75 = ((unsigned __int64)&v36._0.byval_arg >> 12) & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v79 + 36190]);
			//             do
			//             {
			//               v76 = qword_18D6405E0[v79 + 36190] | (1LL << v75);
			//               v80 = qword_18D6405E0[v79 + 36190];
			//             }
			//             while ( v80 != _InterlockedCompareExchange64(&qword_18D6405E0[v79 + 36190], v76, v80) );
			//           }
			//           v81 = m_bloom[10].klass;
			//           if ( !v81 )
			//             sub_1802DC2C8(v76, v75);
			//           sub_180003EE0(v81._0.image);
			//           if ( ((unsigned int (__fastcall *)(Object__Class *, const Il2CppCodeGenModule *))v81._0.image[6].nameToClassHashTable)(
			//                  v81,
			//                  v81._0.image[6].codeGenModule) )
			//           {
			//             v82 = 1.0;
			//           }
			//           else
			//           {
			//             v82 = 0.0;
			//           }
			//           if ( !dirtEnabled )
			//             v50 = 0.0;
			//           v103.x = v51;
			//           v103.y = v51 * v78;
			//           v103.z = v82;
			//           v103.w = v50;
			//           *(Vector4 *)((char *)&v36._0.byval_arg + 8) = v103;
			//           v103 = (Vector4)v58;
			//           *(__m128i *)((char *)&v36._0.this_arg + 8) = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
			//                                                                                            (Color *)&v108,
			//                                                                                            &v103,
			//                                                                                            0LL));
			//           *(_OWORD *)&v36._0.parent = *(_OWORD *)vignette;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//           *(__m128i *)&v36._0.typeMetadataHandle = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::UberPostPassUtils::GetBloomThresholdParams(
			//                                                                                        (Vector4 *)&v108,
			//                                                                                        (Bloom *)m_bloom,
			//                                                                                        0LL));
			//           *(Vector4 *)&v36._0.castClass = *bloomBicubicParams;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//           if ( dirtEnabled )
			//           {
			//             static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//             s_BloomDirt = static_fields.s_BloomDirt;
			//             v86 = hgVignette;
			//             if ( !hgVignette )
			//               sub_1802DC2C8(static_fields, v83);
			//           }
			//           else
			//           {
			//             v84 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//             s_BloomDirt = v84.s_Bloom;
			//             v86 = hgVignette;
			//             if ( !hgVignette )
			//               sub_1802DC2C8(v84, v83);
			//           }
			//           v87 = (void (__fastcall *)(HGVignette *, String *))qword_18D8F4740;
			//           if ( !qword_18D8F4740 )
			//           {
			//             v87 = (void (__fastcall *)(HGVignette *, String *))sub_180017470("UnityEngine.Material::EnableKeyword(System.String)");
			//             qword_18D8F4740 = (__int64)v87;
			//           }
			//           v87(v86, s_BloomDirt);
			//         }
			//       }
			//     }
			//     v91 = v102;
			//     v94 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//              (TextureHandle *)&v108,
			//              &v109,
			//              &input.source,
			//              0LL);
			//     if ( !v91 )
			//       sub_1802DC2C8(v93, v92);
			//     v91[1] = (Object)v94;
			//     if ( !v102 )
			//       sub_1802DC2C8(v93, v92);
			//     v95 = v102[3].klass;
			//     v98 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//              (TextureHandle *)&v108,
			//              &v109,
			//              bloomTexture,
			//              0LL);
			//     if ( !v95 )
			//       sub_1802DC2C8(v97, v96);
			//     *(TextureHandle *)&v95._0.name = v98;
			//     si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//       (TextureHandle *)&v108,
			//       &v109,
			//       &input.target,
			//       0,
			//       RenderBufferLoadAction__Enum_Load,
			//       RenderBufferStoreAction__Enum_Store,
			//       (Color *)&si128,
			//       0,
			//       0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//       &v109,
			//       (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor.static_fields.s_uiUberRenderFunc,
			//       0LL,
			//       0,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIPostProcessConstructor::UIPPPassData>);
			//     sub_180222690(&v106);
			//   }
			// }
			// 
		}

		private void CopyUIRT(ref UIPostProcessConstructor.PassInput input, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void CopyUIRT(UIPostProcessConstructor+PassInput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::UIPostProcessConstructor::CopyUIRT(
			//         UIPostProcessConstructor *this,
			//         UIPostProcessConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int64 v14; // rsi
			//   unsigned int uiPPFormat; // r15d
			//   Vector2Int sceneRTSize_k__BackingField; // rbx
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   TextureHandle v19; // xmm0
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   __int64 v27; // [rsp+40h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v28; // [rsp+48h] [rbp-60h] BYREF
			//   _QWORD v29[2]; // [rsp+50h] [rbp-58h] BYREF
			//   TextureHandle v30[2]; // [rsp+60h] [rbp-48h] BYREF
			//   HGRenderGraphBuilder v31; // [rsp+80h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9195E1 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIPostProcessConstructor::UIDistortionPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UIPostProcessConstructor::UIDistortionPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
			//     sub_18003C530(&off_18D503288);
			//     byte_18D9195E1 = 1;
			//   }
			//   memset(&v31, 0, sizeof(v31));
			//   v27 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2861, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2861, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v26, v25);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1040(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     v9 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)8u,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v11, v10);
			//     v31 = *(HGRenderGraphBuilder *)sub_180830D40(
			//                                      (unsigned int)v30,
			//                                      (_DWORD)renderGraph,
			//                                      (unsigned int)"UI RT Copy",
			//                                      (unsigned int)&v27,
			//                                      (__int64)v9);
			//     v29[0] = 0LL;
			//     v29[1] = &v31;
			//     try
			//     {
			//       if ( !v27 )
			//         sub_1802DC2C8(v13, v12);
			//       *(TextureHandle *)(v27 + 24) = input.source;
			//       v14 = v27;
			//       uiPPFormat = input.uiPPFormat;
			//       if ( !camera )
			//         sub_1802DC2C8(v13, v12);
			//       sceneRTSize_k__BackingField = camera.fields._sceneRTSize_k__BackingField;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//       v19 = *HG::Rendering::Runtime::HGRenderPipeline::CreateColorBuffer(
			//                v30,
			//                renderGraph,
			//                camera,
			//                0,
			//                (GraphicsFormat__Enum)uiPPFormat,
			//                sceneRTSize_k__BackingField,
			//                0LL);
			//       if ( !v14 )
			//         sub_1802DC2C8(v18, v17);
			//       *(TextureHandle *)(v14 + 40) = v19;
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v31, 0, 0LL);
			//       if ( !v27 )
			//         sub_1802DC2C8(v21, v20);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(v30, &v31, (TextureHandle *)(v27 + 24), 0LL);
			//       if ( !v27 )
			//         sub_1802DC2C8(v23, v22);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(v30, &v31, (TextureHandle *)(v27 + 40), 0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v31,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor.static_fields.s_copyUIRTFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIPostProcessConstructor::UIDistortionPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v28 )
			//     {
			//       v29[0] = v28.ex;
			//     }
			//     sub_180222690(v29);
			//   }
			// }
			// 
		}

		private void RenderUIDistortion(ref UIPostProcessConstructor.PassInput input, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void RenderUIDistortion(UIPostProcessConstructor+PassInput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::UIPostProcessConstructor::RenderUIDistortion(
			//         UIPostProcessConstructor *this,
			//         UIPostProcessConstructor_PassInput *input,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
			//   HGGraphicsFeatureSwitch *UIDistortion; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   int32_t m_Id; // ebx
			//   RendererListHandle InvalidHandle; // rax
			//   RendererListHandle *v19; // rbx
			//   RendererListHandle v20; // rax
			//   RendererListHandle v21; // rdx
			//   RendererListHandle v22; // rcx
			//   __int64 v23; // rdx
			//   unsigned int v24; // edx
			//   unsigned __int64 v25; // r8
			//   char v26; // dl
			//   signed __int64 v27; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   __int64 v31; // [rsp+50h] [rbp-248h] BYREF
			//   RendererListHandle inputa[2]; // [rsp+60h] [rbp-238h] BYREF
			//   _QWORD v33[2]; // [rsp+70h] [rbp-228h] BYREF
			//   HGRenderGraphBuilder v34; // [rsp+80h] [rbp-218h] BYREF
			//   Il2CppExceptionWrapper *v35; // [rsp+A0h] [rbp-1F8h] BYREF
			//   TextureHandle v36[2]; // [rsp+A8h] [rbp-1F0h] BYREF
			//   RendererListDesc desc; // [rsp+D0h] [rbp-1C8h] BYREF
			//   RendererListDesc v38; // [rsp+1B0h] [rbp-E8h] BYREF
			// 
			//   if ( !byte_18D9195E2 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIPostProcessConstructor::UIDistortionPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::UIPostProcessConstructor::UIDistortionPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
			//     sub_18003C530(&off_18D503310);
			//     byte_18D9195E2 = 1;
			//   }
			//   memset(&v34, 0, sizeof(v34));
			//   v31 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2862, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2862, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v30, v29);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1040(
			//       Patch,
			//       (Object *)this,
			//       input,
			//       (Object *)renderGraph,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     v9 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0xAu,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v11, v10);
			//     v34 = *(HGRenderGraphBuilder *)sub_180830D40(
			//                                      (unsigned int)v36,
			//                                      (_DWORD)renderGraph,
			//                                      (unsigned int)"UI Distortion",
			//                                      (unsigned int)&v31,
			//                                      (__int64)v9);
			//     v33[0] = 0LL;
			//     v33[1] = &v34;
			//     try
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//       UIDistortion = static_fields.UIDistortion;
			//       if ( !UIDistortion )
			//         sub_1802DC2C8(static_fields, v12);
			//       if ( UIDistortion.fields.m_defaultValue )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//         m_Id = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields.s_DistortionName.m_Id;
			//         if ( !camera )
			//           sub_1802DC2C8(v16, v15);
			//         sub_1802F01E0(&v38, 0LL, 224LL);
			//         *(CullingResults *)&inputa[0].m_IsValid = input.cullingResults;
			//         UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(
			//           &v38,
			//           (ShaderTagId)m_Id,
			//           (CullingResults *)inputa,
			//           camera.fields.camera,
			//           0LL);
			//         desc = v38;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//         desc.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllOpaque;
			//         desc.sortingCriteria = 59;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         desc.layerMask = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.UI_3D_LAYER.m_Mask;
			//         InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//       }
			//       else
			//       {
			//         InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//       }
			//       inputa[0] = InvalidHandle;
			//       v19 = (RendererListHandle *)v31;
			//       v20 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v34, inputa, 0LL);
			//       if ( !v19 )
			//         sub_1802DC2C8(v22, v21);
			//       v19[7] = v20;
			//       v23 = v31;
			//       if ( !v31 )
			//         sub_1802DC2C8(v22, 0LL);
			//       *(_QWORD *)(v31 + 16) = camera;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v24 = ((unsigned __int64)(v23 + 16) >> 12) & 0x1FFFFF;
			//         v25 = (unsigned __int64)v24 >> 6;
			//         v26 = v24 & 0x3F;
			//         _m_prefetchw(&qword_18D6870D0[v25]);
			//         do
			//           v27 = qword_18D6870D0[v25];
			//         while ( v27 != _InterlockedCompareExchange64(&qword_18D6870D0[v25], v27 | (1LL << v26), v27) );
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v34, 0, 0LL);
			//       *(__m128i *)&inputa[0].m_IsValid = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//         v36,
			//         &v34,
			//         &input.target,
			//         0,
			//         RenderBufferLoadAction__Enum_Load,
			//         RenderBufferStoreAction__Enum_Store,
			//         (Color *)inputa,
			//         0,
			//         0LL);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v34,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor.static_fields.m_uiDistortionRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::UIPostProcessConstructor::UIDistortionPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v35 )
			//     {
			//       v33[0] = v35.ex;
			//     }
			//     sub_180222690(v33);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::UIPostProcessConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         UIPostProcessConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2863, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2863, 0LL);
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
			// void HG::Rendering::Runtime::UIPostProcessConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         UIPostProcessConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2864, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2864, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref UIPostProcessConstructor.PassInput input, ref UIPostProcessConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera, HGSettingParameters settingParameters)
		{
			// // Void ConstructPass(UIPostProcessConstructor+PassInput ByRef, UIPostProcessConstructor+PassOutput ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::UIPostProcessConstructor::ConstructPass(
			//         UIPostProcessConstructor *this,
			//         UIPostProcessConstructor_PassInput *input,
			//         UIPostProcessConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   ProfilingSampler *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   BitArray128 source; // xmm6
			//   TextureHandle v17; // xmm7
			//   unsigned int taauQuality; // r15d
			//   unsigned int renderPath; // r12d
			//   TextureHandle *v20; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   FrameSettings frameSettings_k__BackingField; // [rsp+70h] [rbp-B8h] BYREF
			//   _QWORD v25[2]; // [rsp+90h] [rbp-98h] BYREF
			//   TextureHandle v26; // [rsp+A0h] [rbp-88h] BYREF
			//   TextureHandle v27; // [rsp+B0h] [rbp-78h] BYREF
			//   BitArray128 v28; // [rsp+C0h] [rbp-68h] BYREF
			//   HGRenderGraphProfilingScope v29; // [rsp+D0h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v30; // [rsp+E8h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D9195E3 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     byte_18D9195E3 = 1;
			//   }
			//   memset(&v29, 0, sizeof(v29));
			//   v28 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2865, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2865, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v23, v22);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1041(
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
			//     v11 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x27u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
			//       &v29,
			//       renderGraph,
			//       v11,
			//       0LL);
			//     v25[0] = 0LL;
			//     v25[1] = &v29;
			//     try
			//     {
			//       if ( !camera )
			//         sub_1802DC2C8(v13, v12);
			//       frameSettings_k__BackingField = camera.fields._frameSettings_k__BackingField;
			//       if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//              &frameSettings_k__BackingField,
			//              FrameSettingsField__Enum_Postprocess,
			//              0LL) )
			//       {
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       }
			//       if ( !camera.fields.m_volumeComponentsData )
			//         sub_1802DC2C8(v15, v14);
			//       v27.handle = (ResourceHandle)camera.fields.m_volumeComponentsData.fields.m_bloom;
			//       HG::Rendering::Runtime::UIPostProcessConstructor::CopyUIRT(this, input, renderGraph, camera, 0LL);
			//       HG::Rendering::Runtime::UIPostProcessConstructor::RenderUIDistortion(this, input, renderGraph, camera, 0LL);
			//       source = (BitArray128)input.source;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v17 = *(TextureHandle *)sub_182E7CCD0(&frameSettings_k__BackingField);
			//       taauQuality = input.taauQuality;
			//       renderPath = input.renderPath;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//       v26 = v17;
			//       frameSettings_k__BackingField.bitDatas = source;
			//       v20 = HG::Rendering::Runtime::UberPostPassUtils::BloomPass(
			//               &v27,
			//               renderGraph,
			//               camera,
			//               settingParameters,
			//               *(Bloom **)&v27.handle,
			//               1,
			//               (TextureHandle *)&frameSettings_k__BackingField,
			//               &v26,
			//               (TAAUQuality__Enum)taauQuality,
			//               (HGRenderPathInternal__Enum)renderPath,
			//               &this.fields.m_bloomPSMaterials,
			//               (Vector4 *)&v28,
			//               0LL);
			//       frameSettings_k__BackingField.bitDatas = v28;
			//       v26 = *v20;
			//       HG::Rendering::Runtime::UIPostProcessConstructor::UIUberPass(
			//         this,
			//         input,
			//         settingParameters,
			//         renderGraph,
			//         camera,
			//         &v26,
			//         (Vector4 *)&frameSettings_k__BackingField,
			//         0LL);
			//       camera.fields.didResetPostProcessingHistoryInLastFrame = camera.fields.resetPostProcessingHistory;
			//       camera.fields.resetPostProcessingHistory = 0;
			//     }
			//     catch ( Il2CppExceptionWrapper *v30 )
			//     {
			//       v25[0] = v30.ex;
			//     }
			//     sub_180224750(v25);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::UIPostProcessConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         UIPostProcessConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2866, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2866, 0LL);
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
			// void HG::Rendering::Runtime::UIPostProcessConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         UIPostProcessConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D9195E4 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     byte_18D9195E4 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2867, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2867, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)renderGraph,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     HG::Rendering::Runtime::UberPostPassUtils::DisposeBloomPSMaterials(&this.fields.m_bloomPSMaterials, 0LL);
			//   }
			// }
			// 
		}

		private Material m_uiPPMaterial;

		private UberPostPassUtils.BloomPSMaterials m_bloomPSMaterials;

		private UberPostPassUtils.PPVignetteData m_vignetteData;

		private UberPostPassUtils.PPBloomData m_ppBloomData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<UIPostProcessConstructor.UIPPPassData> s_uiUberRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<UIPostProcessConstructor.UIDistortionPassData> s_copyUIRTFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<UIPostProcessConstructor.UIDistortionPassData> m_uiDistortionRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
		internal struct PassInput
		{
			internal TextureHandle source;

			internal TextureHandle target;

			internal CullingResults cullingResults;

			internal TAAUQuality taauQuality;

			internal HGRenderPathInternal renderPath;

			internal GraphicsFormat uiPPFormat;
		}

		internal struct PassOutput
		{
		}

		private class UIPPPassData
		{
			public UIPPPassData()
			{
			}

			public TextureHandle source;

			public Material uberPostMaterial;

			public UberPostPassUtils.PPVignetteData vignetteData;

			public UberPostPassUtils.PPBloomData bloomData;
		}

		internal class UIDistortionPassData
		{
			public UIDistortionPassData()
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

			internal HGCamera camera;

			internal TextureHandle colorAttachment;

			internal TextureHandle colorAttachmentCopy;

			internal RendererListHandle uiDistortionRendererListHandle;
		}
	}
}
