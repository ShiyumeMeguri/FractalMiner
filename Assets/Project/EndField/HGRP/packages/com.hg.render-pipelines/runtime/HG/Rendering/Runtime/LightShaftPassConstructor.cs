using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	internal class LightShaftPassConstructor : IPassConstructor
	{
		internal LightShaftPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
			// // LightShaftApplyPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
			// void HG::Rendering::Runtime::LightShaftApplyPassConstructor::LightShaftApplyPassConstructor(
			//         LightShaftApplyPassConstructor *this,
			//         HGRenderPipelineMaterialCollector *materialCollector,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         MethodInfo *method)
			// {
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   HGRenderPathBase_HGRenderPathResources *v6; // rdx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   MethodInfo *v9; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v10; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !resources.defaultResources
			//     || (shaders = resources.defaultResources.fields.shaders) == 0LL
			//     || !materialCollector )
			//   {
			//     sub_180B536AC(this, materialCollector);
			//   }
			//   this.fields.m_lightShaftMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
			//                                         materialCollector,
			//                                         shaders.fields.lightShaftPS,
			//                                         0,
			//                                         0LL);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields, v6, v7, v8, v9, v10);
			// }
			// 
		}

		public static bool ShouldRenderLightShaft(ref HGLightShaftConfig config, bool enableLightShaft, HGCamera hgCamera)
		{
			// // Boolean ShouldRenderLightShaft(HGLightShaftConfig ByRef, Boolean, HGCamera)
			// bool HG::Rendering::Runtime::LightShaftPassConstructor::ShouldRenderLightShaft(
			//         HGLightShaftConfig *config,
			//         bool enableLightShaft,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9195A6 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//     byte_18D9195A6 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2755, 0LL) )
			//     return config.enable
			//         && enableLightShaft
			//         && (sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor),
			//             HG::Rendering::Runtime::LightShaftPassConstructor::GetDirectionalLightScreenPos(&v11, config, hgCamera, 0LL).w > 0.0);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2755, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v10, v9);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1009(Patch, config, enableLightShaft, (Object *)hgCamera, 0LL);
			// }
			// 
			return default(bool);
		}

		public static Vector4 GetDirectionalLightScreenPos(ref HGLightShaftConfig config, HGCamera hgCamera)
		{
			// // Vector4 GetDirectionalLightScreenPos(HGLightShaftConfig ByRef, HGCamera)
			// Vector4 *HG::Rendering::Runtime::LightShaftPassConstructor::GetDirectionalLightScreenPos(
			//         Vector4 *__return_ptr retstr,
			//         HGLightShaftConfig *config,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   MethodInfo *InterpolatedPhase; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *fwd; // rax
			//   __int64 v10; // rdx
			//   Quaternion v11; // xmm0
			//   __int64 v12; // xmm3_8
			//   Vector3 *v13; // rax
			//   MethodInfo *v14; // r8
			//   __int64 v15; // xmm0_8
			//   __int128 v16; // xmm7
			//   __int128 v17; // xmm8
			//   __int128 v18; // xmm9
			//   __int128 v19; // xmm10
			//   Vector3 *v20; // rax
			//   __int64 v21; // xmm6_8
			//   float z; // ebx
			//   Vector4 *v23; // rax
			//   Quaternion v24; // xmm0
			//   Vector4 *v25; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v27; // xmm0
			//   Vector4 *result; // rax
			//   Vector3 v29; // [rsp+38h] [rbp-69h] BYREF
			//   Vector4 v30; // [rsp+48h] [rbp-59h] BYREF
			//   Quaternion v31; // [rsp+58h] [rbp-49h] BYREF
			//   Matrix4x4 v32; // [rsp+68h] [rbp-39h] BYREF
			// 
			//   if ( !byte_18D9195A7 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D9195A7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2756, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2756, 0LL);
			//     if ( Patch )
			//     {
			//       v25 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1008((Vector4 *)&v31, Patch, config, (Object *)hgCamera, 0LL);
			//       goto LABEL_10;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v8, InterpolatedPhase);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//   InterpolatedPhase = (MethodInfo *)HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//   if ( !InterpolatedPhase )
			//     goto LABEL_8;
			//   fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&v30, InterpolatedPhase);
			//   v11 = *(Quaternion *)(v10 + 292);
			//   v12 = *(_QWORD *)&fwd.x;
			//   v29.z = fwd.z;
			//   *(_QWORD *)&v29.x = v12;
			//   v31 = v11;
			//   v13 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v30, &v31, &v29, 0LL);
			//   if ( !hgCamera )
			//     goto LABEL_8;
			//   v15 = *(_QWORD *)&v13.x;
			//   v16 = *(_OWORD *)&hgCamera.fields.mainViewConstants.nonJitteredViewProjMatrix.m00;
			//   v29.z = v13.z;
			//   v17 = *(_OWORD *)&hgCamera.fields.mainViewConstants.nonJitteredViewProjMatrix.m01;
			//   v18 = *(_OWORD *)&hgCamera.fields.mainViewConstants.nonJitteredViewProjMatrix.m02;
			//   v19 = *(_OWORD *)&hgCamera.fields.mainViewConstants.nonJitteredViewProjMatrix.m03;
			//   *(_QWORD *)&v29.x = v15;
			//   v20 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v30, &v29, v14);
			//   v21 = *(_QWORD *)&v20.x;
			//   z = v20.z;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//   *(_QWORD *)&v29.x = v21;
			//   v29.z = z;
			//   v23 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&v31, &v29, 0.0, 0LL);
			//   *(_OWORD *)&v32.m00 = v16;
			//   *(_OWORD *)&v32.m01 = v17;
			//   *(_OWORD *)&v32.m02 = v18;
			//   v24 = (Quaternion)*v23;
			//   *(_OWORD *)&v32.m03 = v19;
			//   v31 = v24;
			//   v25 = UnityEngine::Matrix4x4::op_Multiply(&v30, &v32, (Vector4 *)&v31, 0LL);
			// LABEL_10:
			//   v27 = *v25;
			//   result = retstr;
			//   *retstr = v27;
			//   return result;
			// }
			// 
			return null;
		}

		private void LightShaftPass(ref LightShaftPassConstructor.PassInput input, ref LightShaftPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void LightShaftPass(LightShaftPassConstructor+PassInput ByRef, LightShaftPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftPass(
			//         LightShaftPassConstructor *this,
			//         LightShaftPassConstructor_PassInput *input,
			//         LightShaftPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   Object *v6; // r13
			//   Object *v9; // r14
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   HGEnvironmentPhase *v13; // r15
			//   HGLightShaftConfig *p_lightShaftConfig; // r12
			//   bool enableLightShaft; // bl
			//   bool ShouldRenderLightShaft; // al
			//   float v17; // xmm1_4
			//   __m128 v18; // xmm13
			//   __m128 v19; // xmm11
			//   float downSampleFactor; // xmm12_4
			//   float occlusionDepthRange; // xmm7_4
			//   float bloomScale; // xmm9_4
			//   float occlusionMaskDarkness; // xmm8_4
			//   float bloomMaxBrightness; // xmm6_4
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   __m128i v27; // xmm6
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   __m128i v30; // xmm6
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   __m128i v33; // xmm6
			//   Material *v34; // rbx
			//   int32_t LightShaftParams3; // r12d
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   __m128i v38; // xmm6
			//   Object_1 *lightShaftCloudMaskTexture; // rbx
			//   Material *v40; // rbx
			//   __int64 v41; // rcx
			//   HGShaderKeyWords__StaticFields *static_fields; // rdx
			//   Material *v43; // rbx
			//   __int64 v44; // rdx
			//   HGShaderIDs__StaticFields *v45; // rcx
			//   Material *v46; // r12
			//   int rotation; // ebx
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   __m128i v50; // xmm6
			//   Material *v51; // rbx
			//   __int64 v52; // rcx
			//   HGShaderKeyWords__StaticFields *v53; // rdx
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   int32_t v56; // r12d
			//   Void *m_Buffer; // r15
			//   unsigned int v58; // ebx
			//   __int64 v59; // rdx
			//   unsigned int v60; // eax
			//   HGRenderPathBase_HGRenderPathResources *v61; // rdx
			//   PassConstructorID__Enum__Array *v62; // r8
			//   HGCamera *v63; // r9
			//   LightShaftPassConstructor__StaticFields *v64; // rcx
			//   String__Array *s_lightShaftPingPongRTName; // rbx
			//   __int64 v66; // rdx
			//   __int64 v67; // rcx
			//   ProfilingSampler *v68; // rax
			//   ProfilingSampler *v69; // rax
			//   __int64 v70; // rdx
			//   __int64 v71; // rcx
			//   __int64 v72; // rcx
			//   Object *v73; // rdx
			//   unsigned int v74; // edx
			//   unsigned __int64 v75; // r8
			//   char v76; // dl
			//   signed __int64 v77; // rtt
			//   __int64 v78; // rdx
			//   __int64 v79; // rcx
			//   TextureHandle v80; // xmm0
			//   __int64 v81; // rdx
			//   __int64 v82; // rcx
			//   TextureHandle v83; // xmm0
			//   Object *v84; // r12
			//   __int64 v85; // rdx
			//   __int64 v86; // rcx
			//   TextureHandle v87; // xmm0
			//   int v88; // r15d
			//   int32_t i; // r12d
			//   ProfilingSampler *v90; // rax
			//   __int64 v91; // rcx
			//   Object *v92; // rdx
			//   unsigned int v93; // edx
			//   unsigned __int64 v94; // r8
			//   char v95; // dl
			//   signed __int64 v96; // rtt
			//   __int64 v97; // rdx
			//   __int64 v98; // rcx
			//   TextureHandle v99; // xmm0
			//   __int64 v100; // rdx
			//   __int64 v101; // rcx
			//   TextureHandle v102; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v104; // rdx
			//   __int64 v105; // rcx
			//   MethodInfo *v106; // [rsp+20h] [rbp-2E8h]
			//   MethodInfo *P4; // [rsp+28h] [rbp-2E0h]
			//   Material *klass; // [rsp+50h] [rbp-2B8h]
			//   Void *v109; // [rsp+50h] [rbp-2B8h]
			//   Object *v110; // [rsp+50h] [rbp-2B8h]
			//   Object *v111; // [rsp+50h] [rbp-2B8h]
			//   Object *v112; // [rsp+50h] [rbp-2B8h]
			//   Object *v113; // [rsp+50h] [rbp-2B8h]
			//   Material *size; // [rsp+58h] [rbp-2B0h]
			//   Material *sizea; // [rsp+58h] [rbp-2B0h]
			//   int sizeb; // [rsp+58h] [rbp-2B0h]
			//   __m128i bloomTint; // [rsp+60h] [rbp-2A8h] BYREF
			//   _QWORD v118[2]; // [rsp+70h] [rbp-298h] BYREF
			//   Object *v119; // [rsp+80h] [rbp-288h] BYREF
			//   Object *v120; // [rsp+88h] [rbp-280h] BYREF
			//   Vector4 v121; // [rsp+90h] [rbp-278h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v122; // [rsp+A0h] [rbp-268h] BYREF
			//   HGRenderGraphBuilder v123; // [rsp+B0h] [rbp-258h] BYREF
			//   HGRenderGraphBuilder v124; // [rsp+D0h] [rbp-238h] BYREF
			//   HGRenderGraphBuilder v125; // [rsp+F0h] [rbp-218h] BYREF
			//   HGRenderGraphProfilingScope v126; // [rsp+110h] [rbp-1F8h] BYREF
			//   TextureDesc v127; // [rsp+130h] [rbp-1D8h] BYREF
			//   Il2CppExceptionWrapper *v128; // [rsp+190h] [rbp-178h] BYREF
			//   Il2CppExceptionWrapper *v129; // [rsp+198h] [rbp-170h] BYREF
			//   Il2CppExceptionWrapper *v130; // [rsp+1A0h] [rbp-168h] BYREF
			//   HGRenderGraphBuilder v131; // [rsp+1A8h] [rbp-160h] BYREF
			//   TextureDesc v132; // [rsp+1D0h] [rbp-138h] BYREF
			//   TextureHandle v133; // [rsp+230h] [rbp-D8h] BYREF
			//   TextureHandle v134; // [rsp+240h] [rbp-C8h] BYREF
			// 
			//   v6 = (Object *)renderGraph;
			//   v9 = (Object *)this;
			//   if ( !byte_18D9195A8 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftDownSamplePassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftRadialBlurPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftDownSamplePassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftRadialBlurPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::RenderGraphModule::TextureHandle>::NativeArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D500C88);
			//     sub_18003C530(&off_18D500C90);
			//     byte_18D9195A8 = 1;
			//   }
			//   v122 = 0LL;
			//   sub_1802F01E0(&v132, 0LL, 96LL);
			//   sub_1802F01E0(&v127, 0LL, 96LL);
			//   memset(&v126, 0, sizeof(v126));
			//   memset(&v124, 0, sizeof(v124));
			//   v119 = 0LL;
			//   memset(&v125, 0, sizeof(v125));
			//   v120 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2757, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2757, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v105, v104);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1011(Patch, v9, input, output, v6, (Object *)camera, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(camera, 0LL);
			//     v13 = InterpolatedPhase;
			//     if ( !InterpolatedPhase )
			//       sub_180B536AC(v12, v11);
			//     p_lightShaftConfig = &InterpolatedPhase.fields.lightShaftConfig;
			//     enableLightShaft = input.enableLightShaft;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//     ShouldRenderLightShaft = HG::Rendering::Runtime::LightShaftPassConstructor::ShouldRenderLightShaft(
			//                                p_lightShaftConfig,
			//                                enableLightShaft,
			//                                camera,
			//                                0LL);
			//     output.enableLightShaft = ShouldRenderLightShaft;
			//     if ( ShouldRenderLightShaft )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//       v19 = (__m128)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::LightShaftPassConstructor::GetDirectionalLightScreenPos(
			//                                                        (Vector4 *)&bloomTint,
			//                                                        p_lightShaftConfig,
			//                                                        camera,
			//                                                        0LL));
			//       v17 = _mm_shuffle_ps(v19, v19, 255).m128_f32[0];
			//       v18 = (__m128)0x3F000000u;
			//       v18.m128_f32[0] = 0.5 - (float)((float)(_mm_shuffle_ps(v19, v19, 85).m128_f32[0] * 0.5) / v17);
			//       v19.m128_f32[0] = (float)((float)(v19.m128_f32[0] * 0.5) / v17) + 0.5;
			//       downSampleFactor = input.downSampleFactor;
			//       size = (Material *)v9[1].klass;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       LODWORD(v118[0]) = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LightShaftParams0;
			//       occlusionDepthRange = p_lightShaftConfig.occlusionDepthRange;
			//       bloomScale = p_lightShaftConfig.bloomScale;
			//       occlusionMaskDarkness = p_lightShaftConfig.occlusionMaskDarkness;
			//       bloomMaxBrightness = p_lightShaftConfig.bloomMaxBrightness;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v27 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                (Vector4 *)&bloomTint,
			//                                                1.0 / occlusionDepthRange,
			//                                                bloomScale,
			//                                                occlusionMaskDarkness,
			//                                                bloomMaxBrightness,
			//                                                0LL));
			//       if ( !size )
			//         sub_180B536AC(v26, v25);
			//       bloomTint = v27;
			//       UnityEngine::Material::SetVector(size, v118[0], (Vector4 *)&bloomTint, 0LL);
			//       sizea = (Material *)v9[1].klass;
			//       LODWORD(v118[0]) = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LightShaftParams1;
			//       bloomTint = (__m128i)p_lightShaftConfig.bloomTint;
			//       v30 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                &v121,
			//                                                (Color *)&bloomTint,
			//                                                p_lightShaftConfig.bloomThreshold,
			//                                                0LL));
			//       if ( !sizea )
			//         sub_180B536AC(v29, v28);
			//       bloomTint = v30;
			//       UnityEngine::Material::SetVector(sizea, v118[0], (Vector4 *)&bloomTint, 0LL);
			//       klass = (Material *)v9[1].klass;
			//       LODWORD(v118[0]) = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LightShaftParams2;
			//       v33 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                (Vector4 *)&bloomTint,
			//                                                (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v19, v18),
			//                                                (float)input.lightShaftSampleNum,
			//                                                p_lightShaftConfig.blurIntensity,
			//                                                0LL));
			//       if ( !klass )
			//         sub_180B536AC(v32, v31);
			//       bloomTint = v33;
			//       UnityEngine::Material::SetVector(klass, v118[0], (Vector4 *)&bloomTint, 0LL);
			//       v34 = (Material *)v9[1].klass;
			//       LightShaftParams3 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LightShaftParams3;
			//       v38 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                (Vector4 *)&bloomTint,
			//                                                downSampleFactor,
			//                                                1.0 / downSampleFactor,
			//                                                0.0,
			//                                                0.0,
			//                                                0LL));
			//       if ( !v34 )
			//         sub_180B536AC(v37, v36);
			//       bloomTint = v38;
			//       UnityEngine::Material::SetVector(v34, LightShaftParams3, (Vector4 *)&bloomTint, 0LL);
			//       if ( v13.fields.cloudConfig.enableLightShaftCloudMask
			//         && (lightShaftCloudMaskTexture = (Object_1 *)v13.fields.cloudConfig.lightShaftCloudMaskTexture,
			//             sub_180002C70(TypeInfo::UnityEngine::Object),
			//             UnityEngine::Object::op_Inequality(lightShaftCloudMaskTexture, 0LL, 0LL)) )
			//       {
			//         v40 = (Material *)v9[1].klass;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//         if ( !v40 )
			//           sub_180B536AC(v41, static_fields);
			//         UnityEngine::Material::EnableKeyword(v40, static_fields.s_LightShaftCloudMask, 0LL);
			//         v43 = (Material *)v9[1].klass;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         v45 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         if ( !v43 )
			//           sub_180B536AC(v45, v44);
			//         UnityEngine::Material::SetTextureImpl(
			//           v43,
			//           v45._LightShaftCloudMask,
			//           v13.fields.cloudConfig.lightShaftCloudMaskTexture,
			//           0LL);
			//         v46 = (Material *)v9[1].klass;
			//         LODWORD(v118[0]) = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LightShaftCloudMaskParams;
			//         rotation = v13.fields.cloudConfig.rotation;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         v50 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                  (Vector4 *)&bloomTint,
			//                                                  (float)rotation,
			//                                                  0LL));
			//         if ( !v46 )
			//           sub_180B536AC(v49, v48);
			//         bloomTint = v50;
			//         UnityEngine::Material::SetVector(v46, v118[0], (Vector4 *)&bloomTint, 0LL);
			//       }
			//       else
			//       {
			//         v51 = (Material *)v9[1].klass;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//         v53 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//         if ( !v51 )
			//           sub_180B536AC(v52, v53);
			//         UnityEngine::Material::DisableKeyword(v51, v53.s_LightShaftCloudMask, 0LL);
			//       }
			//       Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//         &v122,
			//         2,
			//         Allocator__Enum_Temp,
			//         NativeArrayOptions__Enum_ClearMemory,
			//         MethodInfo::Unity::Collections::NativeArray<HG::Rendering::RenderGraphModule::TextureHandle>::NativeArray);
			//       v56 = 0;
			//       m_Buffer = v122.m_Buffer;
			//       if ( v122.m_Length > 0 )
			//       {
			//         v109 = v122.m_Buffer;
			//         v118[0] = 32LL;
			//         do
			//         {
			//           if ( !camera )
			//             sub_180B536AC(v55, v54);
			//           v58 = sub_1825C6750(v55, v54);
			//           v60 = sub_1825C6750(HIDWORD(*(_QWORD *)&camera.fields._taauRTSize_k__BackingField), v59);
			//           HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v127, (Vector2Int)__PAIR64__(v60, v58), 0LL);
			//           v127.colorFormat = 74;
			//           v127.enableRandomWrite = 0;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//           v64 = TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor.static_fields;
			//           s_lightShaftPingPongRTName = v64.s_lightShaftPingPongRTName;
			//           if ( !s_lightShaftPingPongRTName )
			//             sub_180B536AC(v64, v61);
			//           if ( (unsigned int)v56 >= s_lightShaftPingPongRTName.max_length.size )
			//             sub_180070270(v64, v61);
			//           v127.name = *(String **)((char *)&s_lightShaftPingPongRTName.klass + v118[0]);
			//           sub_1800054D0((HGRenderPathScene *)&v127.name, v61, v62, v63, v106, P4);
			//           v127.wrapMode = 1;
			//           v127.filterMode = 1;
			//           v132 = v127;
			//           if ( !v6 )
			//             sub_180B536AC(v67, v66);
			//           *(TextureHandle *)v109 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                       (TextureHandle *)&bloomTint,
			//                                       (HGRenderGraph *)v6,
			//                                       &v132,
			//                                       0LL);
			//           ++v56;
			//           v118[0] += 8LL;
			//           v109 += 16;
			//         }
			//         while ( v56 < v122.m_Length );
			//         v9 = (Object *)this;
			//         m_Buffer = v122.m_Buffer;
			//       }
			//       v68 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x9Fu,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
			//         &v126,
			//         (HGRenderGraph *)v6,
			//         v68,
			//         0LL);
			//       bloomTint.m128i_i64[0] = 0LL;
			//       bloomTint.m128i_i64[1] = (__int64)&v126;
			//       try
			//       {
			//         v69 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                 (Int32Enum__Enum)0xA0u,
			//                 MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//         if ( !v6 )
			//           sub_1802DC2C8(v71, v70);
			//         HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//           &v131,
			//           (HGRenderGraph *)v6,
			//           (String *)"Light Shaft Down Sample",
			//           &v119,
			//           v69,
			//           1,
			//           ProfilingHGPass__Enum_None,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftDownSamplePassData>);
			//         v124 = v131;
			//         v118[0] = 0LL;
			//         v118[1] = &v124;
			//         try
			//         {
			//           v73 = v119;
			//           if ( !v119 )
			//             sub_1802DC2C8(v72, 0LL);
			//           v119[1].klass = v9[1].klass;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v74 = ((unsigned __int64)&v73[1] >> 12) & 0x1FFFFF;
			//             v75 = (unsigned __int64)v74 >> 6;
			//             v76 = v74 & 0x3F;
			//             _m_prefetchw(&qword_18D6405E0[v75 + 36190]);
			//             do
			//               v77 = qword_18D6405E0[v75 + 36190];
			//             while ( v77 != _InterlockedCompareExchange64(&qword_18D6405E0[v75 + 36190], v77 | (1LL << v76), v77) );
			//           }
			//           v110 = v119;
			//           v80 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                    (TextureHandle *)&v121,
			//                    &v124,
			//                    &input.sceneColor,
			//                    0LL);
			//           if ( !v110 )
			//             sub_1802DC2C8(v79, v78);
			//           *(TextureHandle *)&v110[1].monitor = v80;
			//           v111 = v119;
			//           v83 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                    (TextureHandle *)&v121,
			//                    &v124,
			//                    &input.sceneDepth,
			//                    0LL);
			//           if ( !v111 )
			//             sub_1802DC2C8(v82, v81);
			//           *(TextureHandle *)&v111[2].monitor = v83;
			//           v84 = v119;
			//           *(_OWORD *)&v123.m_RenderPass = *(_OWORD *)m_Buffer;
			//           v87 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                    (TextureHandle *)&v121,
			//                    &v124,
			//                    (TextureHandle *)&v123,
			//                    0LL);
			//           if ( !v84 )
			//             sub_1802DC2C8(v86, v85);
			//           *(TextureHandle *)&v84[3].monitor = v87;
			//           if ( !v119 )
			//             sub_1802DC2C8(v86, v85);
			//           v121 = 0LL;
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//             (TextureHandle *)&v123,
			//             &v124,
			//             (TextureHandle *)&v119[3].monitor,
			//             0,
			//             RenderBufferLoadAction__Enum_DontCare,
			//             RenderBufferStoreAction__Enum_Store,
			//             (Color *)&v121,
			//             0,
			//             0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//           HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//             &v124,
			//             (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor.static_fields.s_lightShaftDownSampleRenderFunc,
			//             0LL,
			//             0,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftDownSamplePassData>);
			//         }
			//         catch ( Il2CppExceptionWrapper *v128 )
			//         {
			//           v118[0] = v128.ex;
			//           sub_180222690(v118);
			//           v6 = (Object *)renderGraph;
			//           v9 = (Object *)this;
			//           goto LABEL_39;
			//         }
			//         sub_180222690(v118);
			// LABEL_39:
			//         v88 = 1;
			//         sizeb = 1;
			//         for ( i = 0; ; ++i )
			//         {
			//           LODWORD(v118[0]) = i;
			//           if ( i >= input.lightShaftBlurPassCount )
			//             break;
			//           v90 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                   (Int32Enum__Enum)0xA1u,
			//                   MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//           HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//             &v123,
			//             (HGRenderGraph *)v6,
			//             (String *)"Light Shaft Radial Blur",
			//             &v120,
			//             v90,
			//             1,
			//             ProfilingHGPass__Enum_None,
			//             MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftRadialBlurPassData>);
			//           v125 = v123;
			//           *(_QWORD *)&v121.x = 0LL;
			//           *(_QWORD *)&v121.z = &v125;
			//           try
			//           {
			//             v92 = v120;
			//             if ( !v120 )
			//               sub_1802DC2C8(v91, 0LL);
			//             v120[1].klass = v9[1].klass;
			//             if ( dword_18D8E43F8 )
			//             {
			//               v93 = ((unsigned __int64)&v92[1] >> 12) & 0x1FFFFF;
			//               v94 = (unsigned __int64)v93 >> 6;
			//               v95 = v93 & 0x3F;
			//               _m_prefetchw(&qword_18D6405E0[v94 + 36190]);
			//               do
			//                 v96 = qword_18D6405E0[v94 + 36190];
			//               while ( v96 != _InterlockedCompareExchange64(&qword_18D6405E0[v94 + 36190], v96 | (1LL << v95), v96) );
			//             }
			//             v112 = v120;
			//             *(_OWORD *)&v123.m_RenderPass = *(_OWORD *)&v122.m_Buffer[16 * (1 - v88)];
			//             v99 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                      &v133,
			//                      &v125,
			//                      (TextureHandle *)&v123,
			//                      0LL);
			//             if ( !v112 )
			//               sub_1802DC2C8(v98, v97);
			//             *(TextureHandle *)&v112[1].monitor = v99;
			//             v113 = v120;
			//             *(_OWORD *)&v123.m_RenderPass = *(_OWORD *)&v122.m_Buffer[16 * v88];
			//             v102 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
			//                       &v134,
			//                       &v125,
			//                       (TextureHandle *)&v123,
			//                       0LL);
			//             if ( !v113 )
			//               sub_1802DC2C8(v101, v100);
			//             *(TextureHandle *)&v113[2].monitor = v102;
			//             if ( !v120 )
			//               sub_1802DC2C8(v101, v100);
			//             LODWORD(v120[3].monitor) = i;
			//             if ( !v120 )
			//               sub_1802DC2C8(v101, v100);
			//             *(_OWORD *)&v123.m_RenderPass = 0LL;
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//               (TextureHandle *)&v131,
			//               &v125,
			//               (TextureHandle *)&v120[2].monitor,
			//               0,
			//               RenderBufferLoadAction__Enum_DontCare,
			//               RenderBufferStoreAction__Enum_Store,
			//               (Color *)&v123,
			//               0,
			//               0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor);
			//             HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//               &v125,
			//               (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::LightShaftPassConstructor.static_fields.s_lightShaftRadialBlurRenderFunc,
			//               0LL,
			//               0,
			//               MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftRadialBlurPassData>);
			//           }
			//           catch ( Il2CppExceptionWrapper *v129 )
			//           {
			//             *(Il2CppExceptionWrapper *)&v121.x = (Il2CppExceptionWrapper)v129.ex;
			//             sub_180222690(&v121);
			//             v6 = (Object *)renderGraph;
			//             v9 = (Object *)this;
			//             v88 = sizeb;
			//             i = v118[0];
			//             goto LABEL_52;
			//           }
			//           sub_180222690(&v121);
			// LABEL_52:
			//           v88 = 1 - v88;
			//           sizeb = v88;
			//         }
			//         output.lightShaftBlurResult = *(TextureHandle *)&v122.m_Buffer[16 * (1 - v88)];
			//       }
			//       catch ( Il2CppExceptionWrapper *v130 )
			//       {
			//         *(Il2CppExceptionWrapper *)bloomTint.m128i_i8 = (Il2CppExceptionWrapper)v130.ex;
			//         sub_180224750(&bloomTint);
			//         return;
			//       }
			//       sub_180224750(&bloomTint);
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::LightShaftPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         LightShaftPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2759, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2759, 0LL);
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
			// void HG::Rendering::Runtime::LightShaftPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         LightShaftPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2760, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2760, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref LightShaftPassConstructor.PassInput input, ref LightShaftPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(LightShaftPassConstructor+PassInput ByRef, LightShaftPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// void HG::Rendering::Runtime::LightShaftPassConstructor::ConstructPass(
			//         LightShaftPassConstructor *this,
			//         LightShaftPassConstructor_PassInput *input,
			//         LightShaftPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( !byte_18D9195A9 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     byte_18D9195A9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2761, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2761, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1011(
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
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::UberPostPassUtils);
			//     if ( HG::Rendering::Runtime::UberPostPassUtils::ShouldRenderPostProcess(camera, 0LL) )
			//       HG::Rendering::Runtime::LightShaftPassConstructor::LightShaftPass(this, input, output, renderGraph, camera, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::LightShaftPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         LightShaftPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2762, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2762, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
		}

		private Material m_lightShaftMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly MaterialPropertyBlock s_lightShaftMaterialPropertyBlock;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<LightShaftPassConstructor.LightShaftDownSamplePassData> s_lightShaftDownSampleRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<LightShaftPassConstructor.LightShaftRadialBlurPassData> s_lightShaftRadialBlurRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly string[] s_lightShaftPingPongRTName;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 48)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal bool enableLightShaft;

			internal float downSampleFactor;

			internal int lightShaftSampleNum;

			internal int lightShaftBlurPassCount;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 20)]
		internal struct PassOutput
		{
			internal TextureHandle lightShaftBlurResult;

			internal bool enableLightShaft;
		}

		private class LightShaftDownSamplePassData
		{
			public LightShaftDownSamplePassData()
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

			public Material lightShaftMaterial;

			public TextureHandle sceneColorRT;

			public TextureHandle sceneDepthRT;

			public TextureHandle targetRT;
		}

		private class LightShaftRadialBlurPassData
		{
			public LightShaftRadialBlurPassData()
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

			public Material lightShaftMaterial;

			public TextureHandle sourceRT;

			public TextureHandle targetRT;

			public int lightShaftBlurPassIndex;
		}
	}
}
