using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using IFix.Core;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class FakePlanarReflectionPass : IPassConstructor
	{
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x000025D2 File Offset: 0x000007D2
		public TextureHandle planarReflectionTexture
		{
			get
			{
				// // TextureHandle get_planarReflectionTexture()
				// TextureHandle *HG::Rendering::Runtime::FakePlanarReflectionPass::get_planarReflectionTexture(
				//         TextureHandle *__return_ptr retstr,
				//         FakePlanarReflectionPass *this,
				//         MethodInfo *method)
				// {
				//   TextureHandle *result; // rax
				// 
				//   result = retstr;
				//   *retstr = *(TextureHandle *)&this[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m03;
				//   return result;
				// }
				// 
				return null;
			}
		}

		internal FakePlanarReflectionPass(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		internal void ConstructPass(ref FakePlanarReflectionPass.PassInput input, ref FakePlanarReflectionPass.PassOutput output, ref BasicTransformConstants basicTransformConstants, ref ShaderVariablesGlobal shaderVariablesGlobal, HGRenderGraph renderGraph, HGCamera hgCamera, HGSettingParameters settingParameters)
		{
			// // Void ConstructPass(FakePlanarReflectionPass+PassInput ByRef, FakePlanarReflectionPass+PassOutput ByRef, BasicTransformConstants ByRef, ShaderVariablesGlobal ByRef, HGRenderGraph, HGCamera, HGSettingParameters)
			// // Hidden C++ exception states: #wind=5 #try_helpers=1
			// void HG::Rendering::Runtime::FakePlanarReflectionPass::ConstructPass(
			//         FakePlanarReflectionPass *this,
			//         FakePlanarReflectionPass_PassInput *input,
			//         FakePlanarReflectionPass_PassOutput *output,
			//         BasicTransformConstants *basicTransformConstants,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   FakePlanarReflectionPass_PassInput *v11; // r13
			//   FakePlanarReflectionPass *v12; // r12
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   ProfilingSampler *v17; // rax
			//   Component *camera; // rbx
			//   __int64 v19; // rax
			//   __int64 v20; // xmm9_8
			//   float v21; // r15d
			//   Vector3 *fakeReflectionPlanePos; // rax
			//   __int64 v23; // xmm13_8
			//   float y; // xmm7_4
			//   float x; // xmm8_4
			//   float v26; // xmm10_4
			//   float v27; // xmm11_4
			//   float v28; // xmm12_4
			//   Vector3 *v29; // rax
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   float v32; // xmm6_4
			//   Transform *transform; // rax
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   Vector3 *position; // rax
			//   __int64 v37; // xmm6_8
			//   float z; // r15d
			//   Transform *v39; // rax
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   Vector3 *v42; // rax
			//   __int64 v43; // xmm8_8
			//   float v44; // r15d
			//   Transform *v45; // rax
			//   __int64 v46; // rdx
			//   __int64 v47; // rcx
			//   Vector3 *forward; // rax
			//   float v49; // xmm15_4
			//   float v50; // xmm2_4
			//   __m128 y_low; // xmm14
			//   __m128 v52; // xmm1
			//   __m128 x_low; // xmm13
			//   __m128 v54; // xmm0
			//   Vector3 *v55; // rax
			//   float v56; // xmm11_4
			//   __m128 v57; // xmm10
			//   __m128 v58; // xmm7
			//   Transform *v59; // rax
			//   __int64 v60; // rdx
			//   __int64 v61; // rcx
			//   Vector3 *up; // rax
			//   float v63; // xmm15_4
			//   Vector3 *v64; // rax
			//   float v65; // xmm2_4
			//   __m128 v66; // xmm1
			//   __m128 v67; // xmm0
			//   Quaternion v68; // xmm7
			//   Transform *v69; // rax
			//   __int64 v70; // rdx
			//   __int64 v71; // rcx
			//   Transform *v72; // rax
			//   __int64 v73; // rdx
			//   __int64 v74; // rcx
			//   Matrix4x4 *v75; // rax
			//   Transform *v76; // rax
			//   __int64 v77; // rdx
			//   __int64 v78; // rcx
			//   Transform *v79; // rax
			//   __int64 v80; // rdx
			//   __int64 v81; // rcx
			//   MonitorData *sceneRTSize_k__BackingField; // rbx
			//   ProfilingSampler *v83; // rax
			//   __int64 v84; // rcx
			//   RendererListDesc *v85; // rcx
			//   _OWORD *p_m00; // rax
			//   __int64 v87; // r8
			//   Object *v88; // rax
			//   RendererListDesc *v89; // rcx
			//   __int64 v90; // r8
			//   __int64 v91; // rdx
			//   __int64 v92; // rcx
			//   Object *v93; // rdx
			//   unsigned int v94; // edx
			//   unsigned __int64 v95; // r8
			//   char v96; // dl
			//   signed __int64 v97; // rtt
			//   CullingResults cullingResults; // xmm8
			//   HGShaderPassNames__StaticFields *static_fields; // rdi
			//   float screenCullingRatio; // xmm7_4
			//   float screenCullingRatioDistance; // xmm6_4
			//   uint32_t screenCullingLayerMask; // esi
			//   RendererListDesc *OpaqueRendererListDesc; // rax
			//   RendererListHandle v104; // rax
			//   RendererListHandle v105; // rdx
			//   __int64 characterPrePassECSList; // rcx
			//   __int64 forwardOpaquePreZECSList; // rcx
			//   unsigned __int64 v108; // r8
			//   signed __int64 v109; // rtt
			//   ProfilingSampler *v110; // rax
			//   RendererListDesc *v111; // rcx
			//   BasicTransformConstants *v112; // rax
			//   __int64 v113; // rdx
			//   Object *v114; // rax
			//   RendererListDesc *v115; // rcx
			//   __int64 v116; // rdx
			//   __int64 v117; // rdx
			//   __int64 v118; // rcx
			//   Object *v119; // rdx
			//   HGCamera *v120; // rdi
			//   unsigned int v121; // edx
			//   unsigned __int64 v122; // r8
			//   char v123; // dl
			//   signed __int64 v124; // rtt
			//   PerObjectData__Enum bakedLightingConfig; // ecx
			//   float v126; // xmm2_4
			//   float v127; // xmm1_4
			//   uint32_t v128; // eax
			//   RendererListDesc *v129; // rax
			//   RendererListHandle v130; // rax
			//   RendererListHandle v131; // rdx
			//   RendererListDesc *v132; // rax
			//   RendererListHandle InvalidHandle; // rax
			//   RendererListHandle v134; // rdx
			//   __int64 forwardOpaqueECSList; // rcx
			//   __int64 forwardOpaqueEqualECSList; // rcx
			//   __int64 characterOpaqueECSList; // rcx
			//   __int64 characterOutlineOpaqueECSList; // rcx
			//   __int64 characterOutlineOpaqueEqualECSList; // rcx
			//   HGRenderPipeline *hgrp; // rax
			//   HGSettingParameters *settingParameters_k__BackingField; // rcx
			//   __int64 v142; // rdx
			//   __int64 v143; // rcx
			//   __int128 v144; // xmm1
			//   __int128 v145; // xmm2
			//   __int128 v146; // xmm3
			//   Color clearColor; // xmm4
			//   unsigned __int64 v148; // r8
			//   signed __int64 v149; // rtt
			//   __int128 v150; // xmm6
			//   __int128 v151; // xmm7
			//   BasicTransformConstants *v152; // r13
			//   __int128 v153; // xmm1
			//   __int128 v154; // xmm2
			//   __int128 v155; // xmm3
			//   Color v156; // xmm4
			//   unsigned __int64 v157; // r8
			//   signed __int64 v158; // rtt
			//   ProfilingSampler *v159; // rax
			//   __int64 v160; // rdx
			//   __int64 v161; // rcx
			//   __int64 v162; // rdx
			//   __int64 v163; // rcx
			//   float fakePlanarReflectionBlur; // xmm0_4
			//   BasicTransformConstants *v165; // rax
			//   RendererListDesc *v166; // rcx
			//   __int64 v167; // rdx
			//   Object *v168; // rax
			//   RendererListDesc *v169; // rcx
			//   __int64 v170; // rdx
			//   __int64 v171; // rdx
			//   __int64 v172; // rcx
			//   Object *v173; // rdx
			//   int v174; // eax
			//   unsigned int v175; // edx
			//   unsigned __int64 v176; // r8
			//   char v177; // dl
			//   signed __int64 v178; // rtt
			//   Object *v179; // rdx
			//   MonitorData *v180; // rcx
			//   unsigned int v181; // edx
			//   unsigned __int64 v182; // r8
			//   char v183; // dl
			//   signed __int64 v184; // rtt
			//   __int64 v185; // rdx
			//   __int64 v186; // rcx
			//   __int128 v187; // xmm0
			//   __int64 v188; // rdx
			//   __int64 v189; // rcx
			//   TextureHandle v190; // xmm0
			//   ProfilingSampler *v191; // rax
			//   __int64 v192; // rdx
			//   __int64 v193; // rcx
			//   __int64 v194; // rdx
			//   __int64 v195; // rcx
			//   float v196; // xmm0_4
			//   RendererListDesc *v197; // rax
			//   __int64 v198; // rdx
			//   __int64 v199; // rcx
			//   Object *v200; // rax
			//   RendererListDesc *v201; // rcx
			//   __int64 v202; // rdx
			//   __int64 v203; // rcx
			//   Object *v204; // rdx
			//   int v205; // eax
			//   unsigned int v206; // edx
			//   unsigned __int64 v207; // r8
			//   char v208; // dl
			//   signed __int64 v209; // rtt
			//   Object *v210; // rdx
			//   MonitorData *v211; // rcx
			//   unsigned int v212; // edx
			//   unsigned __int64 v213; // r8
			//   signed __int64 v214; // rtt
			//   Object *v215; // rbx
			//   __int64 v216; // rdx
			//   __int64 v217; // rcx
			//   TextureHandle v218; // xmm0
			//   __int64 v219; // rdx
			//   __int64 v220; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rbx
			//   __int64 v222; // [rsp+70h] [rbp-1468h]
			//   Camera *v223; // [rsp+70h] [rbp-1468h]
			//   RendererListHandle *v224; // [rsp+70h] [rbp-1468h]
			//   RendererListHandle *v225; // [rsp+70h] [rbp-1468h]
			//   Object *v226; // [rsp+70h] [rbp-1468h]
			//   Object *v227; // [rsp+70h] [rbp-1468h]
			//   Object *v228; // [rsp+70h] [rbp-1468h]
			//   Object *v229; // [rsp+70h] [rbp-1468h]
			//   Object *v230; // [rsp+70h] [rbp-1468h]
			//   Vector3 value; // [rsp+80h] [rbp-1458h] BYREF
			//   bool screenSpaceShadowMaskEnabled; // [rsp+90h] [rbp-1448h]
			//   Vector4 v233; // [rsp+A0h] [rbp-1438h] BYREF
			//   Object *v234; // [rsp+B0h] [rbp-1428h] BYREF
			//   Vector3 v235; // [rsp+C0h] [rbp-1418h] BYREF
			//   Vector3 v236; // [rsp+D0h] [rbp-1408h] BYREF
			//   HGRenderGraphBuilder v237; // [rsp+E0h] [rbp-13F8h] BYREF
			//   int32_t height[2]; // [rsp+100h] [rbp-13D8h]
			//   RendererListHandle inputa; // [rsp+108h] [rbp-13D0h] BYREF
			//   Object *v240; // [rsp+110h] [rbp-13C8h] BYREF
			//   Object *v241; // [rsp+118h] [rbp-13C0h] BYREF
			//   Object *v242; // [rsp+120h] [rbp-13B8h] BYREF
			//   Quaternion v243; // [rsp+130h] [rbp-13A8h] BYREF
			//   RendererListHandle *v244; // [rsp+140h] [rbp-1398h]
			//   Vector3 v245; // [rsp+150h] [rbp-1388h] BYREF
			//   TextureDesc v246; // [rsp+160h] [rbp-1378h] BYREF
			//   HGRenderGraphBuilder v247; // [rsp+1C0h] [rbp-1318h] BYREF
			//   _QWORD v248[2]; // [rsp+1E0h] [rbp-12F8h] BYREF
			//   HGRenderGraphBuilder v249; // [rsp+1F0h] [rbp-12E8h] BYREF
			//   HGRenderGraphBuilder v250; // [rsp+210h] [rbp-12C8h] BYREF
			//   HGRenderGraphBuilder v251; // [rsp+230h] [rbp-12A8h] BYREF
			//   TextureDesc v252; // [rsp+250h] [rbp-1288h] BYREF
			//   HGRenderGraphProfilingScope v253; // [rsp+2B0h] [rbp-1228h] BYREF
			//   Il2CppExceptionWrapper *v254; // [rsp+2C8h] [rbp-1210h] BYREF
			//   Il2CppExceptionWrapper *v255; // [rsp+2D0h] [rbp-1208h] BYREF
			//   Il2CppExceptionWrapper *v256; // [rsp+2D8h] [rbp-1200h] BYREF
			//   Il2CppExceptionWrapper *v257; // [rsp+2E0h] [rbp-11F8h] BYREF
			//   Matrix4x4 v258; // [rsp+2F0h] [rbp-11E8h] BYREF
			//   TextureDesc v259; // [rsp+330h] [rbp-11A8h] BYREF
			//   TextureDesc v260; // [rsp+390h] [rbp-1148h] BYREF
			//   TextureDesc v261; // [rsp+3F0h] [rbp-10E8h] BYREF
			//   RendererListDesc desc; // [rsp+450h] [rbp-1088h] BYREF
			//   RendererListDesc v263[16]; // [rsp+530h] [rbp-FA8h] BYREF
			// 
			//   v11 = input;
			//   v12 = this;
			//   if ( !byte_18D919540 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D4F9F88);
			//     sub_18003C530(&off_18D4F9F60);
			//     sub_18003C530(&off_18D4F9F68);
			//     sub_18003C530(&off_18D4F9F70);
			//     byte_18D919540 = 1;
			//   }
			//   memset(&v253, 0, sizeof(v253));
			//   memset(&v251, 0, sizeof(v251));
			//   v242 = 0LL;
			//   sub_1802F01E0(&v259, 0LL, 96LL);
			//   sub_1802F01E0(&v246, 0LL, 96LL);
			//   memset(&v247, 0, sizeof(v247));
			//   v234 = 0LL;
			//   sub_1802F01E0(&v260, 0LL, 96LL);
			//   sub_1802F01E0(&v261, 0LL, 96LL);
			//   memset(&v249, 0, sizeof(v249));
			//   v240 = 0LL;
			//   memset(&v250, 0, sizeof(v250));
			//   v241 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2592, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2592, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v220, v219);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_951(
			//       Patch,
			//       (Object *)v12,
			//       v11,
			//       output,
			//       basicTransformConstants,
			//       shaderVariablesGlobal,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       (Object *)settingParameters,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !hgCamera )
			//       sub_180B536AC(v14, v13);
			//     if ( !HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionEnable(hgCamera, 0LL) )
			//       goto LABEL_120;
			//     if ( !settingParameters )
			//       sub_180B536AC(v16, v15);
			//     if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            settingParameters.fields._fakePlanarReflectionEnable_k__BackingField,
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//     {
			//       v17 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x87u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
			//         &v253,
			//         renderGraph,
			//         v17,
			//         0LL);
			//       v248[0] = 0LL;
			//       v248[1] = &v253;
			//       camera = (Component *)hgCamera.fields.camera;
			//       v236 = *HG::Rendering::Runtime::HGCamera::get_fakeReflectionProbeNormal(&value, hgCamera, 0LL);
			//       v19 = sub_182413270(&value, &v236);
			//       v20 = *(_QWORD *)v19;
			//       *(_QWORD *)&v236.x = *(_QWORD *)v19;
			//       height[0] = *(_DWORD *)(v19 + 8);
			//       v21 = *(float *)height;
			//       fakeReflectionPlanePos = HG::Rendering::Runtime::HGCamera::get_fakeReflectionPlanePos(&value, hgCamera, 0LL);
			//       v23 = *(_QWORD *)&fakeReflectionPlanePos.x;
			//       v222 = *(_QWORD *)&fakeReflectionPlanePos.x;
			//       *(float *)&v244 = fakeReflectionPlanePos.z;
			//       y = v236.y;
			//       x = v236.x;
			//       v26 = (float)(v21 * 0.0) + (float)((float)(v236.y * 0.0) + v236.x);
			//       v27 = (float)(v21 * 0.0) + (float)(v236.y + (float)(v236.x * 0.0));
			//       v28 = v21 + (float)((float)(v236.y * 0.0) + (float)(v236.x * 0.0));
			//       v29 = HG::Rendering::Runtime::HGCamera::get_fakeReflectionPlanePos(&value, hgCamera, 0LL);
			//       *(_QWORD *)&v236.x = *(_QWORD *)&v29.x;
			//       v32 = (float)(v21 * v29.z) + (float)((float)(y * v236.y) + (float)(x * v236.x));
			//       v233.x = v26;
			//       v233.y = v27;
			//       v233.z = v28;
			//       v233.w = -v32;
			//       if ( !camera )
			//         sub_1802DC2C8(v31, v30);
			//       transform = UnityEngine::Component::get_transform(camera, 0LL);
			//       if ( !transform )
			//         sub_1802DC2C8(v35, v34);
			//       position = UnityEngine::Transform::get_position(&v235, transform, 0LL);
			//       v37 = *(_QWORD *)&position.x;
			//       *(_QWORD *)&value.x = *(_QWORD *)&position.x;
			//       z = position.z;
			//       *(float *)&inputa.m_IsValid = z;
			//       v39 = UnityEngine::Component::get_transform(camera, 0LL);
			//       if ( !v39 )
			//         sub_1802DC2C8(v41, v40);
			//       *(__m128i *)&v237.m_RenderPass = _mm_loadu_si128((const __m128i *)UnityEngine::Transform::get_rotation(
			//                                                                           (Quaternion *)&v237,
			//                                                                           v39,
			//                                                                           0LL));
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//       *(_QWORD *)&v236.x = v23;
			//       LODWORD(v236.z) = (_DWORD)v244;
			//       *(_QWORD *)&v245.x = v20;
			//       LODWORD(v245.z) = height[0];
			//       *(_QWORD *)&v235.x = v37;
			//       v235.z = z;
			//       v42 = HG::Rendering::Runtime::FakePlanarReflectionPass::Flip((Vector3 *)&v243, &v235, &v245, &v236, 0LL);
			//       v43 = *(_QWORD *)&v42.x;
			//       *(_QWORD *)&v236.x = *(_QWORD *)&v42.x;
			//       v44 = v42.z;
			//       v45 = UnityEngine::Component::get_transform(camera, 0LL);
			//       if ( !v45 )
			//         sub_1802DC2C8(v47, v46);
			//       forward = UnityEngine::Transform::get_forward((Vector3 *)&v243, v45, 0LL);
			//       *(_QWORD *)&v235.x = *(_QWORD *)&forward.x;
			//       v49 = *(float *)&inputa.m_IsValid;
			//       v50 = *(float *)&inputa.m_IsValid + forward.z;
			//       y_low = (__m128)LODWORD(value.y);
			//       v52 = (__m128)LODWORD(value.y);
			//       v52.m128_f32[0] = value.y + v235.y;
			//       x_low = (__m128)LODWORD(value.x);
			//       v54 = (__m128)LODWORD(value.x);
			//       v54.m128_f32[0] = value.x + v235.x;
			//       *(_QWORD *)&value.x = v222;
			//       LODWORD(value.z) = (_DWORD)v244;
			//       *(_QWORD *)&v235.x = v20;
			//       LODWORD(v235.z) = height[0];
			//       *(_QWORD *)&v245.x = _mm_unpacklo_ps(v54, v52).m128_u64[0];
			//       v245.z = v50;
			//       v55 = HG::Rendering::Runtime::FakePlanarReflectionPass::Flip((Vector3 *)&v243, &v245, &v235, &value, 0LL);
			//       *(_QWORD *)&value.x = *(_QWORD *)&v55.x;
			//       v56 = v55.z - v44;
			//       v57 = (__m128)LODWORD(value.y);
			//       v57.m128_f32[0] = value.y - v236.y;
			//       v58 = (__m128)LODWORD(value.x);
			//       v58.m128_f32[0] = value.x - v236.x;
			//       v59 = UnityEngine::Component::get_transform(camera, 0LL);
			//       if ( !v59 )
			//         sub_1802DC2C8(v61, v60);
			//       up = UnityEngine::Transform::get_up((Vector3 *)&v243, v59, 0LL);
			//       *(_QWORD *)&value.x = *(_QWORD *)&up.x;
			//       v63 = v49 + up.z;
			//       y_low.m128_f32[0] = y_low.m128_f32[0] + value.y;
			//       x_low.m128_f32[0] = x_low.m128_f32[0] + value.x;
			//       *(_QWORD *)&value.x = v222;
			//       LODWORD(value.z) = (_DWORD)v244;
			//       *(_QWORD *)&v235.x = v20;
			//       LODWORD(v235.z) = height[0];
			//       *(_QWORD *)&v245.x = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
			//       v245.z = v63;
			//       v64 = HG::Rendering::Runtime::FakePlanarReflectionPass::Flip((Vector3 *)&v243, &v245, &v235, &value, 0LL);
			//       *(_QWORD *)&value.x = *(_QWORD *)&v64.x;
			//       v65 = v64.z - v44;
			//       v66 = (__m128)LODWORD(value.y);
			//       v66.m128_f32[0] = value.y - v236.y;
			//       v67 = (__m128)LODWORD(value.x);
			//       v67.m128_f32[0] = value.x - v236.x;
			//       *(_QWORD *)&value.x = _mm_unpacklo_ps(v67, v66).m128_u64[0];
			//       value.z = v65;
			//       *(_QWORD *)&v235.x = _mm_unpacklo_ps(v58, v57).m128_u64[0];
			//       v235.z = v56;
			//       v68 = (Quaternion)_mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::LookRotation(
			//                                                            &v243,
			//                                                            &v235,
			//                                                            &value,
			//                                                            0LL));
			//       v69 = UnityEngine::Component::get_transform(camera, 0LL);
			//       if ( !v69 )
			//         sub_1802DC2C8(v71, v70);
			//       *(_QWORD *)&value.x = v43;
			//       value.z = v44;
			//       UnityEngine::Transform::set_position_Injected(v69, &value, 0LL);
			//       v72 = UnityEngine::Component::get_transform(camera, 0LL);
			//       if ( !v72 )
			//         sub_1802DC2C8(v74, v73);
			//       v243 = v68;
			//       UnityEngine::Transform::set_rotation_Injected(v72, &v243, 0LL);
			//       v258 = *UnityEngine::Camera::get_cameraToWorldMatrix((Matrix4x4 *)&desc, (Camera *)camera, 0LL);
			//       v75 = UnityEngine::Matrix4x4::Transpose((Matrix4x4 *)&v252, &v258, 0LL);
			//       *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v75.m00;
			//       *(_OWORD *)&desc.stateBlock.hasValue = *(_OWORD *)&v75.m01;
			//       *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&v75.m02;
			//       *(_OWORD *)&desc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&v75.m03;
			//       v233 = *UnityEngine::Matrix4x4::op_Multiply((Vector4 *)&v243, (Matrix4x4 *)&desc, &v233, 0LL);
			//       HG::Rendering::Runtime::FakePlanarReflectionPass::UpdateBasicTransformConstants(
			//         v12,
			//         basicTransformConstants,
			//         shaderVariablesGlobal,
			//         (Camera *)camera,
			//         &v233,
			//         0LL);
			//       v76 = UnityEngine::Component::get_transform(camera, 0LL);
			//       if ( !v76 )
			//         sub_1802DC2C8(v78, v77);
			//       *(_QWORD *)&value.x = v37;
			//       value.z = *(float *)&inputa.m_IsValid;
			//       UnityEngine::Transform::set_position_Injected(v76, &value, 0LL);
			//       v79 = UnityEngine::Component::get_transform(camera, 0LL);
			//       if ( !v79 )
			//         sub_1802DC2C8(v81, v80);
			//       v243 = *(Quaternion *)&v237.m_RenderPass;
			//       UnityEngine::Transform::set_rotation_Injected(v79, &v243, 0LL);
			//       sceneRTSize_k__BackingField = (MonitorData *)hgCamera.fields._sceneRTSize_k__BackingField;
			//       *(_QWORD *)height = sceneRTSize_k__BackingField;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//       *(_DWORD *)&inputa.m_IsValid = v11.bakedLightingConfig | HG::Rendering::Runtime::HGRenderPipeline::GetPerObjectDataConfig(
			//                                                                   hgCamera,
			//                                                                   0LL);
			//       v83 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x88u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !renderGraph )
			//         sub_1802DC2C8(v84, 0LL);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v237,
			//         renderGraph,
			//         (String *)"Fake Planar Reflection",
			//         &v242,
			//         v83,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
			//       v251 = v237;
			//       *(_QWORD *)&v233.x = 0LL;
			//       *(_QWORD *)&v233.z = &v251;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v251, 0, 0LL);
			//         p_m00 = (_OWORD *)&v12.fields.m_basicTransformConstants._ViewMatrix.m00;
			//         v85 = v263;
			//         v87 = 5LL;
			//         do
			//         {
			//           *(_OWORD *)&v85.sortingCriteria = *p_m00;
			//           *(_OWORD *)&v85.stateBlock.hasValue = p_m00[1];
			//           *(_OWORD *)&v85.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = p_m00[2];
			//           *(_OWORD *)&v85.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = p_m00[3];
			//           *(_OWORD *)&v85.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = p_m00[4];
			//           *(_OWORD *)&v85.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = p_m00[5];
			//           *(_OWORD *)&v85.stateBlock.value.m_RasterState.m_OffsetFactor = p_m00[6];
			//           v85 = (RendererListDesc *)((char *)v85 + 128);
			//           *(_OWORD *)&v85[-1]._passName_k__BackingField.m_Id = p_m00[7];
			//           p_m00 += 8;
			//           --v87;
			//         }
			//         while ( v87 );
			//         *(_OWORD *)&v85.sortingCriteria = *p_m00;
			//         *(_OWORD *)&v85.stateBlock.hasValue = p_m00[1];
			//         *(_OWORD *)&v85.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = p_m00[2];
			//         *(_OWORD *)&v85.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = p_m00[3];
			//         *(_OWORD *)&v85.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = p_m00[4];
			//         if ( !v242 )
			//           sub_1802DC2C8(v85, 128LL);
			//         v88 = v242 + 2;
			//         v89 = v263;
			//         v90 = 5LL;
			//         do
			//         {
			//           *v88 = *(Object *)&v89.sortingCriteria;
			//           v88[1] = *(Object *)&v89.stateBlock.hasValue;
			//           v88[2] = *(Object *)&v89.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//           v88[3] = *(Object *)&v89.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//           v88[4] = *(Object *)&v89.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//           v88[5] = *(Object *)&v89.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//           v88[6] = *(Object *)&v89.stateBlock.value.m_RasterState.m_OffsetFactor;
			//           v88 += 8;
			//           v88[-1] = *(Object *)&v89.stateBlock.value.m_StencilState.m_FailOperationFront;
			//           v89 = (RendererListDesc *)((char *)v89 + 128);
			//           --v90;
			//         }
			//         while ( v90 );
			//         *v88 = *(Object *)&v89.sortingCriteria;
			//         v88[1] = *(Object *)&v89.stateBlock.hasValue;
			//         v88[2] = *(Object *)&v89.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//         v88[3] = *(Object *)&v89.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//         v88[4] = *(Object *)&v89.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//         sub_1802EFB40(v263, &v12.fields.m_shaderVariablesGlobal, 3792LL);
			//         if ( !v242 )
			//           sub_1802DC2C8(0LL, v91);
			//         sub_1802EFB40(&v242[47], v263, 3792LL);
			//         v93 = v242;
			//         if ( !v242 )
			//           sub_1802DC2C8(v92, 0LL);
			//         v242[289].monitor = (MonitorData *)hgCamera;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v94 = ((unsigned __int64)&v93[289].monitor >> 12) & 0x1FFFFF;
			//           v95 = (unsigned __int64)v94 >> 6;
			//           v96 = v94 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v95 + 36190]);
			//           do
			//             v97 = qword_18D6405E0[v95 + 36190];
			//           while ( v97 != _InterlockedCompareExchange64(&qword_18D6405E0[v95 + 36190], v97 | (1LL << v96), v97) );
			//         }
			//         v244 = (RendererListHandle *)v242;
			//         cullingResults = v11.cullingResults;
			//         v223 = hgCamera.fields.camera;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields;
			//         screenCullingRatio = v11.screenCullingRatio;
			//         screenCullingRatioDistance = v11.screenCullingRatioDistance;
			//         screenCullingLayerMask = v11.screenCullingLayerMask;
			//         *(_QWORD *)&value.x = 0LL;
			//         sub_1802F01E0(&desc, 0LL, 112LL);
			//         *(_QWORD *)&v235.x = *(_QWORD *)&value.x;
			//         v235.z = value.x;
			//         *(CullingResults *)&v237.m_RenderPass = cullingResults;
			//         OpaqueRendererListDesc = HG::Rendering::Runtime::HGRendererListUtils::CreateOpaqueRendererListDesc(
			//                                    v263,
			//                                    (CullingResults *)&v237,
			//                                    v223,
			//                                    static_fields.s_DepthCharacterOnlyName,
			//                                    screenCullingRatio,
			//                                    screenCullingRatioDistance,
			//                                    screenCullingLayerMask,
			//                                    *(PerObjectData__Enum *)&inputa.m_IsValid,
			//                                    (Nullable_1_UnityEngine_Rendering_RenderQueueRange_ *)&v235,
			//                                    (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)&desc,
			//                                    0LL,
			//                                    0,
			//                                    0LL,
			//                                    0LL);
			//         *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&OpaqueRendererListDesc.sortingCriteria;
			//         desc.stateBlock = OpaqueRendererListDesc.stateBlock;
			//         OpaqueRendererListDesc = (RendererListDesc *)((char *)OpaqueRendererListDesc + 128);
			//         *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&OpaqueRendererListDesc.sortingCriteria;
			//         *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&OpaqueRendererListDesc.stateBlock.hasValue;
			//         *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&OpaqueRendererListDesc.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&OpaqueRendererListDesc.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&OpaqueRendererListDesc.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&OpaqueRendererListDesc.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//         inputa = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//         v104 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v251, &inputa, 0LL);
			//         if ( !v244 )
			//           sub_1802DC2C8(0LL, v105);
			//         v244[568] = v104;
			//         characterPrePassECSList = v11.characterPrePassECSList;
			//         if ( !v242 )
			//           sub_1802DC2C8(characterPrePassECSList, v105);
			//         HIDWORD(v242[287].monitor) = characterPrePassECSList;
			//         forwardOpaquePreZECSList = v11.forwardOpaquePreZECSList;
			//         if ( !v242 )
			//           sub_1802DC2C8(forwardOpaquePreZECSList, v105);
			//         LODWORD(v242[288].klass) = forwardOpaquePreZECSList;
			//         sub_1802F01E0(&v252, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//           &v252,
			//           (int32_t)sceneRTSize_k__BackingField,
			//           height[1],
			//           0LL);
			//         v246 = v252;
			//         v246.colorFormat = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                              renderGraph,
			//                              &v11.sceneDepthTexture,
			//                              0LL).colorFormat;
			//         v246.depthBufferBits = HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                                  renderGraph,
			//                                  &v11.sceneDepthTexture,
			//                                  0LL).depthBufferBits;
			//         v246.name = (String *)"Fake Planar Reflection Depth texture";
			//         if ( dword_18D8E43F8 )
			//         {
			//           v108 = (((unsigned __int64)&v246.name >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v108 + 36190]);
			//           do
			//             v109 = qword_18D6405E0[v108 + 36190];
			//           while ( v109 != _InterlockedCompareExchange64(
			//                             &qword_18D6405E0[v108 + 36190],
			//                             v109 | (1LL << (((unsigned __int64)&v246.name >> 12) & 0x3F)),
			//                             v109) );
			//         }
			//         v259 = v246;
			//         *(TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._ReprojectionMatrix.m00 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                                                               (TextureHandle *)&v237,
			//                                                                                               renderGraph,
			//                                                                                               &v259,
			//                                                                                               0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&v237,
			//           &v251,
			//           (TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._ReprojectionMatrix,
			//           DepthAccess__Enum_ReadWrite,
			//           RenderBufferLoadAction__Enum_Clear,
			//           RenderBufferStoreAction__Enum_DontCare,
			//           1.0,
			//           0,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v251,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass.static_fields.s_DepthPrepassRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v254 )
			//       {
			//         *(Il2CppExceptionWrapper *)&v233.x = (Il2CppExceptionWrapper)v254.ex;
			//         sub_180222690(&v233);
			//         v11 = input;
			//         v12 = this;
			//         sceneRTSize_k__BackingField = *(MonitorData **)height;
			//         goto LABEL_36;
			//       }
			//       sub_180222690(&v233);
			// LABEL_36:
			//       v110 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                (Int32Enum__Enum)0x89u,
			//                MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v237,
			//         renderGraph,
			//         (String *)"Fake Planar Reflection",
			//         &v234,
			//         v110,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
			//       v247 = v237;
			//       *(_QWORD *)&v233.x = 0LL;
			//       *(_QWORD *)&v233.z = &v247;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v247, 0, 0LL);
			//         v112 = basicTransformConstants;
			//         v111 = v263;
			//         v113 = 5LL;
			//         do
			//         {
			//           *(_OWORD *)&v111.sortingCriteria = *(_OWORD *)&v112._ViewMatrix.m00;
			//           *(_OWORD *)&v111.stateBlock.hasValue = *(_OWORD *)&v112._ViewMatrix.m01;
			//           *(_OWORD *)&v111.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&v112._ViewMatrix.m02;
			//           *(_OWORD *)&v111.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&v112._ViewMatrix.m03;
			//           *(_OWORD *)&v111.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = *(_OWORD *)&v112._InvViewMatrix.m00;
			//           *(_OWORD *)&v111.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = *(_OWORD *)&v112._InvViewMatrix.m01;
			//           *(_OWORD *)&v111.stateBlock.value.m_RasterState.m_OffsetFactor = *(_OWORD *)&v112._InvViewMatrix.m02;
			//           v111 = (RendererListDesc *)((char *)v111 + 128);
			//           *(_OWORD *)&v111[-1]._passName_k__BackingField.m_Id = *(_OWORD *)&v112._InvViewMatrix.m03;
			//           v112 = (BasicTransformConstants *)((char *)v112 + 128);
			//           --v113;
			//         }
			//         while ( v113 );
			//         *(_OWORD *)&v111.sortingCriteria = *(_OWORD *)&v112._ViewMatrix.m00;
			//         *(_OWORD *)&v111.stateBlock.hasValue = *(_OWORD *)&v112._ViewMatrix.m01;
			//         *(_OWORD *)&v111.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&v112._ViewMatrix.m02;
			//         *(_OWORD *)&v111.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&v112._ViewMatrix.m03;
			//         *(_OWORD *)&v111.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = *(_OWORD *)&v112._InvViewMatrix.m00;
			//         if ( !v234 )
			//           sub_1802DC2C8(v111, 0LL);
			//         v114 = v234 + 2;
			//         v115 = v263;
			//         v116 = 5LL;
			//         do
			//         {
			//           *v114 = *(Object *)&v115.sortingCriteria;
			//           v114[1] = *(Object *)&v115.stateBlock.hasValue;
			//           v114[2] = *(Object *)&v115.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//           v114[3] = *(Object *)&v115.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//           v114[4] = *(Object *)&v115.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//           v114[5] = *(Object *)&v115.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//           v114[6] = *(Object *)&v115.stateBlock.value.m_RasterState.m_OffsetFactor;
			//           v114 += 8;
			//           v114[-1] = *(Object *)&v115.stateBlock.value.m_StencilState.m_FailOperationFront;
			//           v115 = (RendererListDesc *)((char *)v115 + 128);
			//           --v116;
			//         }
			//         while ( v116 );
			//         *v114 = *(Object *)&v115.sortingCriteria;
			//         v114[1] = *(Object *)&v115.stateBlock.hasValue;
			//         v114[2] = *(Object *)&v115.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//         v114[3] = *(Object *)&v115.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//         v114[4] = *(Object *)&v115.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//         sub_1802EFB40(v263, shaderVariablesGlobal, 3792LL);
			//         if ( !v234 )
			//           sub_1802DC2C8(0LL, v117);
			//         sub_1802EFB40(&v234[47], v263, 3792LL);
			//         v119 = v234;
			//         if ( !v234 )
			//           sub_1802DC2C8(v118, 0LL);
			//         v120 = hgCamera;
			//         v234[289].monitor = (MonitorData *)hgCamera;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v121 = ((unsigned __int64)&v119[289].monitor >> 12) & 0x1FFFFF;
			//           v122 = (unsigned __int64)v121 >> 6;
			//           v123 = v121 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v122 + 36190]);
			//           do
			//             v124 = qword_18D6405E0[v122 + 36190];
			//           while ( v124 != _InterlockedCompareExchange64(&qword_18D6405E0[v122 + 36190], v124 | (1LL << v123), v124) );
			//         }
			//         v224 = (RendererListHandle *)v234;
			//         bakedLightingConfig = v11.bakedLightingConfig;
			//         v126 = v11.screenCullingRatio;
			//         v127 = v11.screenCullingRatioDistance;
			//         v128 = v11.screenCullingLayerMask;
			//         *(CullingResults *)&v237.m_RenderPass = v11.cullingResults;
			//         v129 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardOpaqueRendererList(
			//                  v263,
			//                  v11.hgrp,
			//                  hgCamera,
			//                  (CullingResults *)&v237,
			//                  bakedLightingConfig,
			//                  v126,
			//                  v127,
			//                  v128,
			//                  0LL);
			//         *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v129.sortingCriteria;
			//         desc.stateBlock = v129.stateBlock;
			//         v129 = (RendererListDesc *)((char *)v129 + 128);
			//         *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v129.sortingCriteria;
			//         *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v129.stateBlock.hasValue;
			//         *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v129.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v129.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v129.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//         *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v129.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//         inputa = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//         v130 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v247, &inputa, 0LL);
			//         if ( !v224 )
			//           sub_1802DC2C8(0LL, v131);
			//         v224[569] = v130;
			//         v225 = (RendererListHandle *)v234;
			//         if ( v11.characterOutlineEnable )
			//         {
			//           v132 = HG::Rendering::Runtime::ForwardPassUtils::PrepareForwardOpaqueCharacterOutlineRendererList(
			//                    v263,
			//                    v11.hgrp,
			//                    hgCamera,
			//                    &v11.cullingResults,
			//                    (PerObjectData__Enum)v11.bakedLightingConfig,
			//                    v11.screenCullingRatio,
			//                    v11.screenCullingRatioDistance,
			//                    v11.screenCullingLayerMask,
			//                    0LL);
			//           *(_OWORD *)&desc.sortingCriteria = *(_OWORD *)&v132.sortingCriteria;
			//           desc.stateBlock = v132.stateBlock;
			//           v132 = (RendererListDesc *)((char *)v132 + 128);
			//           *(_OWORD *)&desc.overrideMaterial = *(_OWORD *)&v132.sortingCriteria;
			//           *(_OWORD *)&desc.overrideMaterialPassIndex = *(_OWORD *)&v132.stateBlock.hasValue;
			//           *(_OWORD *)&desc.sortingLayerMin = *(_OWORD *)&v132.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//           *(_OWORD *)&desc.drawableFeedbackPtr = *(_OWORD *)&v132.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//           *(_OWORD *)&desc._cullingResult_k__BackingField.m_AllocationInfo = *(_OWORD *)&v132.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//           *(_OWORD *)&desc._passName_k__BackingField.m_Id = *(_OWORD *)&v132.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//           inputa = HG::Rendering::RenderGraphModule::HGRenderGraph::CreateRendererList(renderGraph, &desc, 0LL);
			//           InvalidHandle = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::UseRendererList(&v247, &inputa, 0LL);
			//         }
			//         else
			//         {
			//           InvalidHandle = HG::Rendering::RenderGraphModule::RendererListHandle::get_InvalidHandle(0LL);
			//         }
			//         if ( !v225 )
			//           sub_1802DC2C8(0LL, v134);
			//         v225[570] = InvalidHandle;
			//         forwardOpaqueECSList = v11.forwardOpaqueECSList;
			//         if ( !v234 )
			//           sub_1802DC2C8(forwardOpaqueECSList, v134);
			//         HIDWORD(v234[288].klass) = forwardOpaqueECSList;
			//         forwardOpaqueEqualECSList = v11.forwardOpaqueEqualECSList;
			//         if ( !v234 )
			//           sub_1802DC2C8(forwardOpaqueEqualECSList, v134);
			//         LODWORD(v234[288].monitor) = forwardOpaqueEqualECSList;
			//         characterOpaqueECSList = v11.characterOpaqueECSList;
			//         if ( !v234 )
			//           sub_1802DC2C8(characterOpaqueECSList, v134);
			//         HIDWORD(v234[288].monitor) = characterOpaqueECSList;
			//         characterOutlineOpaqueECSList = v11.characterOutlineOpaqueECSList;
			//         if ( !v234 )
			//           sub_1802DC2C8(characterOutlineOpaqueECSList, v134);
			//         LODWORD(v234[289].klass) = characterOutlineOpaqueECSList;
			//         characterOutlineOpaqueEqualECSList = v11.characterOutlineOpaqueEqualECSList;
			//         if ( !v234 )
			//           sub_1802DC2C8(characterOutlineOpaqueEqualECSList, v134);
			//         HIDWORD(v234[289].klass) = characterOutlineOpaqueEqualECSList;
			//         v226 = v234;
			//         hgrp = v11.hgrp;
			//         if ( !hgrp )
			//           sub_1802DC2C8(characterOutlineOpaqueEqualECSList, v134);
			//         settingParameters_k__BackingField = hgrp.fields._settingParameters_k__BackingField;
			//         if ( !settingParameters_k__BackingField )
			//           sub_1802DC2C8(0LL, v134);
			//         screenSpaceShadowMaskEnabled = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                                          settingParameters_k__BackingField.fields._enableScreenSpaceShadowMask_k__BackingField,
			//                                          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor);
			//         LOBYTE(v143) = HG::Rendering::Runtime::ScreenSpaceShadowMaskPassConstructor::IsScreenSpaceShadowMaskEnabled(
			//                          screenSpaceShadowMaskEnabled,
			//                          0LL);
			//         if ( !v226 )
			//           sub_1802DC2C8(v143, v142);
			//         LOBYTE(v226[287].monitor) = v143;
			//         sub_1802F01E0(&v252, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//           &v252,
			//           (int32_t)sceneRTSize_k__BackingField,
			//           height[1],
			//           0LL);
			//         v144 = *(_OWORD *)&v252.width;
			//         *(_OWORD *)&v246.width = *(_OWORD *)&v252.width;
			//         *(_OWORD *)&v246.colorFormat = *(_OWORD *)&v252.colorFormat;
			//         v145 = *(_OWORD *)&v252.enableRandomWrite;
			//         *(_OWORD *)&v246.enableRandomWrite = *(_OWORD *)&v252.enableRandomWrite;
			//         *(_QWORD *)&v246.bindTextureMS = *(_QWORD *)&v252.bindTextureMS;
			//         v146 = *(_OWORD *)&v252.fastMemoryDesc.inFastMemory;
			//         *(_OWORD *)&v246.fastMemoryDesc.inFastMemory = *(_OWORD *)&v252.fastMemoryDesc.inFastMemory;
			//         clearColor = v252.clearColor;
			//         v246.clearColor = v252.clearColor;
			//         v246.colorFormat = 48;
			//         v246.name = (String *)"Fake Planar Reflection Color texture";
			//         if ( dword_18D8E43F8 )
			//         {
			//           v148 = (((unsigned __int64)&v246.name >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v148 + 36190]);
			//           do
			//             v149 = qword_18D6405E0[v148 + 36190];
			//           while ( v149 != _InterlockedCompareExchange64(
			//                             &qword_18D6405E0[v148 + 36190],
			//                             v149 | (1LL << (((unsigned __int64)&v246.name >> 12) & 0x3F)),
			//                             v149) );
			//           clearColor = v246.clearColor;
			//           v146 = *(_OWORD *)&v246.fastMemoryDesc.inFastMemory;
			//           v145 = *(_OWORD *)&v246.enableRandomWrite;
			//           v144 = *(_OWORD *)&v246.width;
			//         }
			//         *(_OWORD *)&v260.width = v144;
			//         *(_OWORD *)&v260.colorFormat = *(_OWORD *)&v246.colorFormat;
			//         *(_OWORD *)&v260.enableRandomWrite = v145;
			//         *(_OWORD *)&v260.bindTextureMS = *(_OWORD *)&v246.bindTextureMS;
			//         *(_OWORD *)&v260.fastMemoryDesc.inFastMemory = v146;
			//         v260.clearColor = clearColor;
			//         *(TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m03 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture((TextureHandle *)&v237, renderGraph, &v260, 0LL);
			//         *(BitArray128 *)&v237.m_RenderPass = hgCamera.fields._frameSettings_k__BackingField.bitDatas;
			//         v237.m_RenderGraph = *(HGRenderGraph **)&hgCamera.fields._frameSettings_k__BackingField.materialQuality;
			//         if ( HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//                (FrameSettings *)&v237,
			//                FrameSettingsField__Enum_ShadowMaps,
			//                0LL)
			//           || (*(BitArray128 *)&v237.m_RenderPass = hgCamera.fields._frameSettings_k__BackingField.bitDatas,
			//               v237.m_RenderGraph = *(HGRenderGraph **)&hgCamera.fields._frameSettings_k__BackingField.materialQuality,
			//               HG::Rendering::Runtime::FrameSettings::IsEnabled(
			//                 (FrameSettings *)&v237,
			//                 FrameSettingsField__Enum_CharacterShadowMaps,
			//                 0LL)) )
			//         {
			//           v150 = *(_OWORD *)&v247.m_RenderPass;
			//           v151 = *(_OWORD *)&v247.m_RenderGraph;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowManager);
			//           *(_OWORD *)&v237.m_RenderPass = v150;
			//           *(_OWORD *)&v237.m_RenderGraph = v151;
			//           HG::Rendering::Runtime::HGShadowManager::ReadShadowResult(
			//             (ShadowResult *)&v258,
			//             &v11.shadowResult,
			//             &v237,
			//             0LL);
			//         }
			//         *(_OWORD *)&v237.m_RenderPass = 0LL;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v243,
			//           &v247,
			//           (TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m03,
			//           0,
			//           RenderBufferLoadAction__Enum_Clear,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&v237,
			//           0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&v237,
			//           &v247,
			//           (TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._ReprojectionMatrix,
			//           DepthAccess__Enum_ReadWrite,
			//           RenderBufferLoadAction__Enum_Load,
			//           RenderBufferStoreAction__Enum_DontCare,
			//           1.0,
			//           0,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v247,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass.static_fields.s_RenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v255 )
			//       {
			//         *(Il2CppExceptionWrapper *)&v233.x = (Il2CppExceptionWrapper)v255.ex;
			//         sub_180222690(&v233);
			//         v12 = this;
			//         sceneRTSize_k__BackingField = *(MonitorData **)height;
			//         v120 = hgCamera;
			//         goto LABEL_68;
			//       }
			//       sub_180222690(&v233);
			// LABEL_68:
			//       v152 = basicTransformConstants;
			//       if ( HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionBlur(v120, 0LL) <= 0.001 )
			//       {
			// LABEL_119:
			//         sub_180224750(v248);
			//         return;
			//       }
			//       sub_1802F01E0(&v252, 0LL, 96LL);
			//       HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//         &v252,
			//         (int32_t)sceneRTSize_k__BackingField,
			//         height[1],
			//         0LL);
			//       v153 = *(_OWORD *)&v252.width;
			//       *(_OWORD *)&v246.width = *(_OWORD *)&v252.width;
			//       *(_OWORD *)&v246.colorFormat = *(_OWORD *)&v252.colorFormat;
			//       v154 = *(_OWORD *)&v252.enableRandomWrite;
			//       *(_OWORD *)&v246.enableRandomWrite = *(_OWORD *)&v252.enableRandomWrite;
			//       *(_QWORD *)&v246.bindTextureMS = *(_QWORD *)&v252.bindTextureMS;
			//       v155 = *(_OWORD *)&v252.fastMemoryDesc.inFastMemory;
			//       *(_OWORD *)&v246.fastMemoryDesc.inFastMemory = *(_OWORD *)&v252.fastMemoryDesc.inFastMemory;
			//       v156 = v252.clearColor;
			//       v246.clearColor = v252.clearColor;
			//       v246.colorFormat = 48;
			//       v246.name = (String *)"Fake Planar Reflection Color Blur texture";
			//       if ( dword_18D8E43F8 )
			//       {
			//         v157 = (((unsigned __int64)&v246.name >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v157 + 36190]);
			//         do
			//           v158 = qword_18D6405E0[v157 + 36190];
			//         while ( v158 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v157 + 36190],
			//                           v158 | (1LL << (((unsigned __int64)&v246.name >> 12) & 0x3F)),
			//                           v158) );
			//         v156 = v246.clearColor;
			//         v155 = *(_OWORD *)&v246.fastMemoryDesc.inFastMemory;
			//         v154 = *(_OWORD *)&v246.enableRandomWrite;
			//         v153 = *(_OWORD *)&v246.width;
			//       }
			//       *(_OWORD *)&v261.width = v153;
			//       *(_OWORD *)&v261.colorFormat = *(_OWORD *)&v246.colorFormat;
			//       *(_OWORD *)&v261.enableRandomWrite = v154;
			//       *(_OWORD *)&v261.bindTextureMS = *(_OWORD *)&v246.bindTextureMS;
			//       *(_OWORD *)&v261.fastMemoryDesc.inFastMemory = v155;
			//       v261.clearColor = v156;
			//       *(TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._ReprojectionMatrix.m01 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
			//                                                                                             (TextureHandle *)&v237,
			//                                                                                             renderGraph,
			//                                                                                             &v261,
			//                                                                                             0LL);
			//       v159 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                (Int32Enum__Enum)0x8Au,
			//                MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v237,
			//         renderGraph,
			//         (String *)"Fake Planar Reflection",
			//         &v240,
			//         v159,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
			//       v249 = v237;
			//       *(_QWORD *)&v233.x = 0LL;
			//       *(_QWORD *)&v233.z = &v249;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v249, 0, 0LL);
			//         if ( !v240 )
			//           sub_1802DC2C8(v161, v160);
			//         LODWORD(v240[1].klass) = 0;
			//         v227 = v240;
			//         fakePlanarReflectionBlur = HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionBlur(v120, 0LL);
			//         if ( !v227 )
			//           sub_1802DC2C8(v163, v162);
			//         *((float *)&v227[1].klass + 1) = fakePlanarReflectionBlur;
			//         if ( !v240 )
			//           sub_1802DC2C8(v163, v162);
			//         v240[1].monitor = sceneRTSize_k__BackingField;
			//         v165 = basicTransformConstants;
			//         v166 = v263;
			//         v167 = 5LL;
			//         do
			//         {
			//           *(_OWORD *)&v166.sortingCriteria = *(_OWORD *)&v165._ViewMatrix.m00;
			//           *(_OWORD *)&v166.stateBlock.hasValue = *(_OWORD *)&v165._ViewMatrix.m01;
			//           *(_OWORD *)&v166.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&v165._ViewMatrix.m02;
			//           *(_OWORD *)&v166.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&v165._ViewMatrix.m03;
			//           *(_OWORD *)&v166.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = *(_OWORD *)&v165._InvViewMatrix.m00;
			//           *(_OWORD *)&v166.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = *(_OWORD *)&v165._InvViewMatrix.m01;
			//           *(_OWORD *)&v166.stateBlock.value.m_RasterState.m_OffsetFactor = *(_OWORD *)&v165._InvViewMatrix.m02;
			//           v166 = (RendererListDesc *)((char *)v166 + 128);
			//           *(_OWORD *)&v166[-1]._passName_k__BackingField.m_Id = *(_OWORD *)&v165._InvViewMatrix.m03;
			//           v165 = (BasicTransformConstants *)((char *)v165 + 128);
			//           --v167;
			//         }
			//         while ( v167 );
			//         *(_OWORD *)&v166.sortingCriteria = *(_OWORD *)&v165._ViewMatrix.m00;
			//         *(_OWORD *)&v166.stateBlock.hasValue = *(_OWORD *)&v165._ViewMatrix.m01;
			//         *(_OWORD *)&v166.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&v165._ViewMatrix.m02;
			//         *(_OWORD *)&v166.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&v165._ViewMatrix.m03;
			//         *(_OWORD *)&v166.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = *(_OWORD *)&v165._InvViewMatrix.m00;
			//         if ( !v240 )
			//           sub_1802DC2C8(v166, 0LL);
			//         v168 = v240 + 2;
			//         v169 = v263;
			//         v170 = 5LL;
			//         do
			//         {
			//           *v168 = *(Object *)&v169.sortingCriteria;
			//           v168[1] = *(Object *)&v169.stateBlock.hasValue;
			//           v168[2] = *(Object *)&v169.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//           v168[3] = *(Object *)&v169.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//           v168[4] = *(Object *)&v169.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//           v168[5] = *(Object *)&v169.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//           v168[6] = *(Object *)&v169.stateBlock.value.m_RasterState.m_OffsetFactor;
			//           v168 += 8;
			//           v168[-1] = *(Object *)&v169.stateBlock.value.m_StencilState.m_FailOperationFront;
			//           v169 = (RendererListDesc *)((char *)v169 + 128);
			//           --v170;
			//         }
			//         while ( v170 );
			//         *v168 = *(Object *)&v169.sortingCriteria;
			//         v168[1] = *(Object *)&v169.stateBlock.hasValue;
			//         v168[2] = *(Object *)&v169.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//         v168[3] = *(Object *)&v169.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//         v168[4] = *(Object *)&v169.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//         sub_1802EFB40(v263, shaderVariablesGlobal, 3792LL);
			//         if ( !v240 )
			//           sub_1802DC2C8(0LL, v171);
			//         sub_1802EFB40(&v240[47], v263, 3792LL);
			//         v173 = v240;
			//         if ( !v240 )
			//           sub_1802DC2C8(v172, 0LL);
			//         v240[290].klass = *(Object__Class **)&v12[1].fields.m_shaderVariablesGlobal._ReprojectionMatrix.m02;
			//         v174 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v175 = ((unsigned __int64)&v173[290] >> 12) & 0x1FFFFF;
			//           v176 = (unsigned __int64)v175 >> 6;
			//           v177 = v175 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v176 + 36190]);
			//           do
			//             v178 = qword_18D6405E0[v176 + 36190];
			//           while ( v178 != _InterlockedCompareExchange64(&qword_18D6405E0[v176 + 36190], v178 | (1LL << v177), v178) );
			//           v174 = dword_18D8E43F8;
			//         }
			//         v179 = v240;
			//         v180 = *(MonitorData **)&v12[1].fields.m_shaderVariablesGlobal._ReprojectionMatrix.m22;
			//         if ( !v240 )
			//           sub_1802DC2C8(v180, 0LL);
			//         v240[290].monitor = v180;
			//         if ( v174 )
			//         {
			//           v181 = ((unsigned __int64)&v179[290].monitor >> 12) & 0x1FFFFF;
			//           v182 = (unsigned __int64)v181 >> 6;
			//           v183 = v181 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v182 + 36190]);
			//           do
			//             v184 = qword_18D6405E0[v182 + 36190];
			//           while ( v184 != _InterlockedCompareExchange64(&qword_18D6405E0[v182 + 36190], v184 | (1LL << v183), v184) );
			//         }
			//         v228 = v240;
			//         sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//         v187 = *(_OWORD *)sub_182E7CCD0(&v237);
			//         if ( !v228 )
			//           sub_1802DC2C8(v186, v185);
			//         *(_OWORD *)&v228[286].monitor = v187;
			//         v229 = v240;
			//         v190 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                   (TextureHandle *)&v237,
			//                   &v249,
			//                   (TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m03,
			//                   0LL);
			//         if ( !v229 )
			//           sub_1802DC2C8(v189, v188);
			//         *(TextureHandle *)&v229[285].monitor = v190;
			//         *(__m128i *)&v237.m_RenderPass = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v243,
			//           &v249,
			//           (TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._ReprojectionMatrix.m01,
			//           0,
			//           RenderBufferLoadAction__Enum_DontCare,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&v237,
			//           0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&v237,
			//           &v249,
			//           (TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._ReprojectionMatrix,
			//           DepthAccess__Enum_ReadWrite,
			//           RenderBufferLoadAction__Enum_Clear,
			//           RenderBufferStoreAction__Enum_DontCare,
			//           1.0,
			//           0,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v249,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass.static_fields.s_BlurRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v256 )
			//       {
			//         *(Il2CppExceptionWrapper *)&v233.x = (Il2CppExceptionWrapper)v256.ex;
			//         sub_180222690(&v233);
			//         v152 = basicTransformConstants;
			//         v12 = this;
			//         sceneRTSize_k__BackingField = *(MonitorData **)height;
			//         v120 = hgCamera;
			//         goto LABEL_96;
			//       }
			//       sub_180222690(&v233);
			// LABEL_96:
			//       v191 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                (Int32Enum__Enum)0x8Au,
			//                MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v237,
			//         renderGraph,
			//         (String *)"Fake Planar Reflection",
			//         &v241,
			//         v191,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
			//       v250 = v237;
			//       *(_QWORD *)&v233.x = 0LL;
			//       *(_QWORD *)&v233.z = &v250;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v250, 0, 0LL);
			//         if ( !v241 )
			//           sub_1802DC2C8(v193, v192);
			//         LODWORD(v241[1].klass) = 1;
			//         v230 = v241;
			//         v196 = HG::Rendering::Runtime::HGCamera::get_fakePlanarReflectionBlur(v120, 0LL);
			//         if ( !v230 )
			//           sub_1802DC2C8(v195, v194);
			//         *((float *)&v230[1].klass + 1) = v196;
			//         if ( !v241 )
			//           sub_1802DC2C8(v195, v194);
			//         v241[1].monitor = sceneRTSize_k__BackingField;
			//         v197 = v263;
			//         v198 = 5LL;
			//         v199 = 5LL;
			//         do
			//         {
			//           *(_OWORD *)&v197.sortingCriteria = *(_OWORD *)&v152._ViewMatrix.m00;
			//           *(_OWORD *)&v197.stateBlock.hasValue = *(_OWORD *)&v152._ViewMatrix.m01;
			//           *(_OWORD *)&v197.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&v152._ViewMatrix.m02;
			//           *(_OWORD *)&v197.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&v152._ViewMatrix.m03;
			//           *(_OWORD *)&v197.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = *(_OWORD *)&v152._InvViewMatrix.m00;
			//           *(_OWORD *)&v197.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = *(_OWORD *)&v152._InvViewMatrix.m01;
			//           *(_OWORD *)&v197.stateBlock.value.m_RasterState.m_OffsetFactor = *(_OWORD *)&v152._InvViewMatrix.m02;
			//           v197 = (RendererListDesc *)((char *)v197 + 128);
			//           *(_OWORD *)&v197[-1]._passName_k__BackingField.m_Id = *(_OWORD *)&v152._InvViewMatrix.m03;
			//           v152 = (BasicTransformConstants *)((char *)v152 + 128);
			//           --v199;
			//         }
			//         while ( v199 );
			//         *(_OWORD *)&v197.sortingCriteria = *(_OWORD *)&v152._ViewMatrix.m00;
			//         *(_OWORD *)&v197.stateBlock.hasValue = *(_OWORD *)&v152._ViewMatrix.m01;
			//         *(_OWORD *)&v197.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&v152._ViewMatrix.m02;
			//         *(_OWORD *)&v197.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&v152._ViewMatrix.m03;
			//         *(_OWORD *)&v197.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = *(_OWORD *)&v152._InvViewMatrix.m00;
			//         if ( !v241 )
			//           sub_1802DC2C8(0LL, 5LL);
			//         v200 = v241 + 2;
			//         v201 = v263;
			//         do
			//         {
			//           *v200 = *(Object *)&v201.sortingCriteria;
			//           v200[1] = *(Object *)&v201.stateBlock.hasValue;
			//           v200[2] = *(Object *)&v201.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//           v200[3] = *(Object *)&v201.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//           v200[4] = *(Object *)&v201.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//           v200[5] = *(Object *)&v201.stateBlock.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode;
			//           v200[6] = *(Object *)&v201.stateBlock.value.m_RasterState.m_OffsetFactor;
			//           v200 += 8;
			//           v200[-1] = *(Object *)&v201.stateBlock.value.m_StencilState.m_FailOperationFront;
			//           v201 = (RendererListDesc *)((char *)v201 + 128);
			//           --v198;
			//         }
			//         while ( v198 );
			//         *v200 = *(Object *)&v201.sortingCriteria;
			//         v200[1] = *(Object *)&v201.stateBlock.hasValue;
			//         v200[2] = *(Object *)&v201.stateBlock.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode;
			//         v200[3] = *(Object *)&v201.stateBlock.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode;
			//         v200[4] = *(Object *)&v201.stateBlock.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode;
			//         sub_1802EFB40(v263, shaderVariablesGlobal, 3792LL);
			//         if ( !v241 )
			//           sub_1802DC2C8(0LL, v202);
			//         sub_1802EFB40(&v241[47], v263, 3792LL);
			//         v204 = v241;
			//         if ( !v241 )
			//           sub_1802DC2C8(v203, 0LL);
			//         v241[290].klass = *(Object__Class **)&v12[1].fields.m_shaderVariablesGlobal._ReprojectionMatrix.m02;
			//         v205 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v206 = ((unsigned __int64)&v204[290] >> 12) & 0x1FFFFF;
			//           v207 = (unsigned __int64)v206 >> 6;
			//           v208 = v206 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v207 + 36190]);
			//           do
			//             v209 = qword_18D6405E0[v207 + 36190];
			//           while ( v209 != _InterlockedCompareExchange64(&qword_18D6405E0[v207 + 36190], v209 | (1LL << v208), v209) );
			//           v205 = dword_18D8E43F8;
			//         }
			//         v210 = v241;
			//         v211 = *(MonitorData **)&v12[1].fields.m_shaderVariablesGlobal._ReprojectionMatrix.m22;
			//         if ( !v241 )
			//           sub_1802DC2C8(v211, 0LL);
			//         v241[290].monitor = v211;
			//         if ( v205 )
			//         {
			//           v212 = ((unsigned __int64)&v210[290].monitor >> 12) & 0x1FFFFF;
			//           v213 = (unsigned __int64)v212 >> 6;
			//           v210 = (Object *)(v212 & 0x3F);
			//           _m_prefetchw(&qword_18D6405E0[v213 + 36190]);
			//           do
			//           {
			//             v211 = (MonitorData *)(qword_18D6405E0[v213 + 36190] | (1LL << (char)v210));
			//             v214 = qword_18D6405E0[v213 + 36190];
			//           }
			//           while ( v214 != _InterlockedCompareExchange64(&qword_18D6405E0[v213 + 36190], (signed __int64)v211, v214) );
			//         }
			//         if ( !v241 )
			//           sub_1802DC2C8(v211, v210);
			//         *(Object *)((char *)v241 + 4584) = *(Object *)&v12[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m03;
			//         v215 = v241;
			//         v218 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                   (TextureHandle *)&v237,
			//                   &v250,
			//                   (TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._ReprojectionMatrix.m01,
			//                   0LL);
			//         if ( !v215 )
			//           sub_1802DC2C8(v217, v216);
			//         *(TextureHandle *)&v215[285].monitor = v218;
			//         *(__m128i *)&v237.m_RenderPass = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
			//           (TextureHandle *)&v243,
			//           &v250,
			//           (TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m03,
			//           0,
			//           RenderBufferLoadAction__Enum_DontCare,
			//           RenderBufferStoreAction__Enum_Store,
			//           (Color *)&v237,
			//           0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&v237,
			//           &v250,
			//           (TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._ReprojectionMatrix,
			//           DepthAccess__Enum_ReadWrite,
			//           RenderBufferLoadAction__Enum_Clear,
			//           RenderBufferStoreAction__Enum_DontCare,
			//           1.0,
			//           0,
			//           0,
			//           0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v250,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FakePlanarReflectionPass.static_fields.s_BlurRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FakePlanarReflectionPass::PassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v257 )
			//       {
			//         *(Il2CppExceptionWrapper *)&v233.x = (Il2CppExceptionWrapper)v257.ex;
			//         sub_180222690(&v233);
			//         goto LABEL_119;
			//       }
			//       sub_180222690(&v233);
			//       sub_180224750(v248);
			//     }
			//     else
			//     {
			// LABEL_120:
			//       if ( !renderGraph )
			//         sub_180B536AC(v16, v15);
			//       *(TextureHandle *)&v12[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m03 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture((TextureHandle *)&v237, renderGraph, *(RTHandle **)&v12[1].fields.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m22, 0LL);
			//     }
			//   }
			// }
			// 
		}

		private void UpdateBasicTransformConstants(ref BasicTransformConstants basicTransformConstants, ref ShaderVariablesGlobal shaderVariablesGlobal, Camera camera, Vector4 nearPlane)
		{
			// // Void UpdateBasicTransformConstants(BasicTransformConstants ByRef, ShaderVariablesGlobal ByRef, Camera, Vector4)
			// void HG::Rendering::Runtime::FakePlanarReflectionPass::UpdateBasicTransformConstants(
			//         FakePlanarReflectionPass *this,
			//         BasicTransformConstants *basicTransformConstants,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         Camera *camera,
			//         Vector4 *nearPlane,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   float z; // ebx
			//   Matrix4x4 *v15; // rax
			//   __int128 v16; // xmm6
			//   __int128 v17; // xmm7
			//   __int128 v18; // xmm8
			//   __int128 v19; // xmm9
			//   Matrix4x4 *worldToCameraMatrix; // rax
			//   __int128 v21; // xmm10
			//   Vector4 v22; // xmm11
			//   __int128 v23; // xmm0
			//   Matrix4x4 *cameraToWorldMatrix; // rax
			//   __int128 v25; // xmm14
			//   __int128 v26; // xmm15
			//   Vector4 v27; // xmm0
			//   Matrix4x4 *GPUProjectionMatrix; // rax
			//   __int128 v29; // xmm7
			//   __int128 v30; // xmm6
			//   __int128 v31; // xmm13
			//   __int128 v32; // xmm12
			//   Matrix4x4 *v33; // rax
			//   __int128 v34; // xmm8
			//   __int128 v35; // xmm9
			//   __int128 v36; // xmm10
			//   __int128 v37; // xmm11
			//   Vector4 v38; // xmm1
			//   __int128 v39; // xmm0
			//   Matrix4x4 *v40; // rax
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm2
			//   __int128 v43; // xmm3
			//   __int128 v44; // xmm0
			//   __int128 v45; // xmm1
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   __int128 v48; // xmm1
			//   __int128 v49; // xmm0
			//   __int128 v50; // xmm1
			//   __int128 v51; // xmm0
			//   Matrix4x4 *v52; // rax
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm2
			//   __int128 v55; // xmm3
			//   __int128 v56; // xmm1
			//   __int128 v57; // xmm0
			//   __int128 v58; // xmm1
			//   __int128 v59; // xmm0
			//   __int128 v60; // xmm1
			//   __int128 v61; // xmm0
			//   __int128 v62; // xmm1
			//   Matrix4x4 *v63; // rax
			//   __int128 v64; // xmm1
			//   __int128 v65; // xmm2
			//   __int128 v66; // xmm3
			//   __int128 v67; // xmm1
			//   __int128 v68; // xmm2
			//   __int128 v69; // xmm3
			//   __int128 v70; // xmm1
			//   __int128 v71; // xmm2
			//   __int128 v72; // xmm3
			//   __int128 v73; // xmm1
			//   __int128 v74; // xmm2
			//   __int128 v75; // xmm3
			//   MethodInfo *v76; // r8
			//   __int128 v77; // xmm1
			//   __int128 v78; // xmm2
			//   __int128 v79; // xmm3
			//   Vector3 v80; // [rsp+40h] [rbp-C0h] BYREF
			//   __int128 v81; // [rsp+50h] [rbp-B0h] BYREF
			//   Vector4 v82; // [rsp+60h] [rbp-A0h] BYREF
			//   Vector4 v83; // [rsp+70h] [rbp-90h] BYREF
			//   Matrix4x4 v84; // [rsp+80h] [rbp-80h] BYREF
			//   __int128 v85; // [rsp+C0h] [rbp-40h]
			//   Matrix4x4 v86; // [rsp+D0h] [rbp-30h] BYREF
			//   Matrix4x4 v87; // [rsp+110h] [rbp+10h] BYREF
			//   __int128 v88; // [rsp+150h] [rbp+50h]
			//   Matrix4x4 v89; // [rsp+160h] [rbp+60h] BYREF
			//   __m128i si128; // [rsp+1A0h] [rbp+A0h] BYREF
			//   __int128 v91; // [rsp+1B0h] [rbp+B0h]
			//   Matrix4x4 v92; // [rsp+1C0h] [rbp+C0h] BYREF
			//   _BYTE v93[3784]; // [rsp+200h] [rbp+100h] BYREF
			// 
			//   if ( !byte_18D919541 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     byte_18D919541 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2594, 0LL) )
			//   {
			//     if ( camera )
			//     {
			//       transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//       if ( transform )
			//       {
			//         position = UnityEngine::Transform::get_position((Vector3 *)&v81, transform, 0LL);
			//         z = position.z;
			//         *(_QWORD *)&v80.x = *(_QWORD *)&position.x;
			//         v82 = *nearPlane;
			//         v15 = UnityEngine::Camera::CalculateObliqueMatrix(&v84, camera, &v82, 0LL);
			//         v16 = *(_OWORD *)&v15.m00;
			//         v17 = *(_OWORD *)&v15.m01;
			//         v18 = *(_OWORD *)&v15.m02;
			//         v19 = *(_OWORD *)&v15.m03;
			//         worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix(&v84, camera, 0LL);
			//         v21 = *(_OWORD *)&worldToCameraMatrix.m00;
			//         v22 = *(Vector4 *)&worldToCameraMatrix.m01;
			//         v81 = *(_OWORD *)&worldToCameraMatrix.m02;
			//         v23 = *(_OWORD *)&worldToCameraMatrix.m03;
			//         v88 = v21;
			//         v85 = v23;
			//         v82 = v22;
			//         cameraToWorldMatrix = UnityEngine::Camera::get_cameraToWorldMatrix(&v84, camera, 0LL);
			//         *(_OWORD *)&v87.m00 = v16;
			//         *(_OWORD *)&v87.m01 = v17;
			//         *(_OWORD *)&v87.m02 = v18;
			//         v25 = *(_OWORD *)&cameraToWorldMatrix.m00;
			//         v26 = *(_OWORD *)&cameraToWorldMatrix.m01;
			//         v91 = *(_OWORD *)&cameraToWorldMatrix.m02;
			//         v27 = *(Vector4 *)&cameraToWorldMatrix.m03;
			//         *(_OWORD *)&v87.m03 = v19;
			//         v83 = v27;
			//         GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&v92, &v87, 1, 0LL);
			//         v29 = *(_OWORD *)&GPUProjectionMatrix.m02;
			//         v30 = *(_OWORD *)&GPUProjectionMatrix.m03;
			//         v31 = *(_OWORD *)&GPUProjectionMatrix.m00;
			//         v32 = *(_OWORD *)&GPUProjectionMatrix.m01;
			//         *(_OWORD *)&v86.m02 = v81;
			//         *(_OWORD *)&v86.m03 = v85;
			//         *(_OWORD *)&v84.m00 = v31;
			//         *(_OWORD *)&v84.m01 = v32;
			//         *(_OWORD *)&v89.m00 = v31;
			//         *(_OWORD *)&v89.m01 = v32;
			//         *(_OWORD *)&v89.m02 = v29;
			//         *(_OWORD *)&v89.m03 = v30;
			//         *(_OWORD *)&v86.m00 = v21;
			//         *(Vector4 *)&v86.m01 = v22;
			//         *(_OWORD *)&v84.m02 = v29;
			//         *(_OWORD *)&v84.m03 = v30;
			//         v33 = UnityEngine::Matrix4x4::op_Multiply(&v92, &v84, &v86, 0LL);
			//         v34 = *(_OWORD *)&v33.m00;
			//         v35 = *(_OWORD *)&v33.m01;
			//         v36 = *(_OWORD *)&v33.m02;
			//         v37 = *(_OWORD *)&v33.m03;
			//         *(_OWORD *)&v87.m00 = v88;
			//         *(Vector4 *)&v87.m01 = v82;
			//         *(_OWORD *)&v87.m02 = v81;
			//         *(_OWORD *)&v87.m03 = v85;
			//         si128 = _mm_load_si128((const __m128i *)&xmmword_18A3576D0);
			//         UnityEngine::Matrix4x4::SetColumn(&v87, 3, (Vector4 *)&si128, 0LL);
			//         v38 = v83;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ViewMatrix.m00 = v88;
			//         *(Vector4 *)&this.fields.m_basicTransformConstants._ViewMatrix.m01 = v82;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ViewMatrix.m02 = v81;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ViewMatrix.m03 = v85;
			//         v39 = v91;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewMatrix.m00 = v25;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewMatrix.m01 = v26;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewMatrix.m02 = v39;
			//         *(Vector4 *)&this.fields.m_basicTransformConstants._InvViewMatrix.m03 = v38;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ProjMatrix.m00 = v31;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ProjMatrix.m01 = v32;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ProjMatrix.m02 = v29;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ProjMatrix.m03 = v30;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//         v40 = HG::Rendering::Runtime::HGCamera::CalculateInvProjectionMatrix(&v92, &v89, 0LL);
			//         v41 = *(_OWORD *)&v40.m01;
			//         v42 = *(_OWORD *)&v40.m02;
			//         v43 = *(_OWORD *)&v40.m03;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvProjMatrix.m00 = *(_OWORD *)&v40.m00;
			//         v44 = *(_OWORD *)&v87.m00;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvProjMatrix.m01 = v41;
			//         v45 = *(_OWORD *)&v87.m01;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvProjMatrix.m02 = v42;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvProjMatrix.m03 = v43;
			//         *(_OWORD *)&v84.m01 = v45;
			//         v46 = *(_OWORD *)&v87.m03;
			//         *(_OWORD *)&v84.m00 = v44;
			//         v47 = *(_OWORD *)&v87.m02;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ViewProjMatrix.m00 = v34;
			//         *(_OWORD *)&v84.m03 = v46;
			//         v48 = *(_OWORD *)&v89.m01;
			//         *(_OWORD *)&v84.m02 = v47;
			//         v49 = *(_OWORD *)&v89.m00;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ViewProjMatrix.m01 = v35;
			//         *(_OWORD *)&v86.m01 = v48;
			//         v50 = *(_OWORD *)&v89.m03;
			//         *(_OWORD *)&v86.m00 = v49;
			//         v51 = *(_OWORD *)&v89.m02;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ViewProjMatrix.m02 = v36;
			//         *(_OWORD *)&v86.m03 = v50;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ViewProjMatrix.m03 = v37;
			//         *(_OWORD *)&v86.m02 = v51;
			//         v52 = UnityEngine::Matrix4x4::op_Multiply(&v92, &v86, &v84, 0LL);
			//         v53 = *(_OWORD *)&v52.m01;
			//         v54 = *(_OWORD *)&v52.m02;
			//         v55 = *(_OWORD *)&v52.m03;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ViewNoTransProjMatrix.m00 = *(_OWORD *)&v52.m00;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ViewNoTransProjMatrix.m01 = v53;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ViewNoTransProjMatrix.m02 = v54;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._ViewNoTransProjMatrix.m03 = v55;
			//         v56 = *(_OWORD *)&this.fields.m_basicTransformConstants._InvProjMatrix.m01;
			//         *(_OWORD *)&v84.m00 = *(_OWORD *)&this.fields.m_basicTransformConstants._InvProjMatrix.m00;
			//         v57 = *(_OWORD *)&this.fields.m_basicTransformConstants._InvProjMatrix.m02;
			//         *(_OWORD *)&v84.m01 = v56;
			//         v58 = *(_OWORD *)&this.fields.m_basicTransformConstants._InvProjMatrix.m03;
			//         *(_OWORD *)&v84.m02 = v57;
			//         v59 = *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewMatrix.m00;
			//         *(_OWORD *)&v84.m03 = v58;
			//         v60 = *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewMatrix.m01;
			//         *(_OWORD *)&v86.m00 = v59;
			//         v61 = *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewMatrix.m02;
			//         *(_OWORD *)&v86.m01 = v60;
			//         v62 = *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewMatrix.m03;
			//         *(_OWORD *)&v86.m02 = v61;
			//         *(_OWORD *)&v86.m03 = v62;
			//         v63 = UnityEngine::Matrix4x4::op_Multiply(&v92, &v86, &v84, 0LL);
			//         v80.z = z;
			//         v64 = *(_OWORD *)&v63.m01;
			//         v65 = *(_OWORD *)&v63.m02;
			//         v66 = *(_OWORD *)&v63.m03;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewProjMatrix.m00 = *(_OWORD *)&v63.m00;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewProjMatrix.m01 = v64;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewProjMatrix.m02 = v65;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewProjMatrix.m03 = v66;
			//         v67 = *(_OWORD *)&this.fields.m_basicTransformConstants._ViewProjMatrix.m01;
			//         v68 = *(_OWORD *)&this.fields.m_basicTransformConstants._ViewProjMatrix.m02;
			//         v69 = *(_OWORD *)&this.fields.m_basicTransformConstants._ViewProjMatrix.m03;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._NonJitteredViewProjMatrix.m00 = *(_OWORD *)&this.fields.m_basicTransformConstants._ViewProjMatrix.m00;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._NonJitteredViewProjMatrix.m01 = v67;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._NonJitteredViewProjMatrix.m02 = v68;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._NonJitteredViewProjMatrix.m03 = v69;
			//         v70 = *(_OWORD *)&this.fields.m_basicTransformConstants._ViewNoTransProjMatrix.m01;
			//         v71 = *(_OWORD *)&this.fields.m_basicTransformConstants._ViewNoTransProjMatrix.m02;
			//         v72 = *(_OWORD *)&this.fields.m_basicTransformConstants._ViewNoTransProjMatrix.m03;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m00 = *(_OWORD *)&this.fields.m_basicTransformConstants._ViewNoTransProjMatrix.m00;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m01 = v70;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m02 = v71;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m03 = v72;
			//         v73 = *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewProjMatrix.m01;
			//         v74 = *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewProjMatrix.m02;
			//         v75 = *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewProjMatrix.m03;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m00 = *(_OWORD *)&this.fields.m_basicTransformConstants._InvViewProjMatrix.m00;
			//         *(_QWORD *)&v61 = *(_QWORD *)&v80.x;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m01 = v73;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m02 = v74;
			//         *(_OWORD *)&this.fields.m_basicTransformConstants._InvNonJitteredViewProjMatrix.m03 = v75;
			//         *(_QWORD *)&v80.x = v61;
			//         this.fields.m_basicTransformConstants._WorldSpaceCameraPos_Internal = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(&v83, &v80, v76));
			//         sub_1802EFB40(v93, shaderVariablesGlobal, 3792LL);
			//         sub_1802EFB40(&this.fields.m_shaderVariablesGlobal, v93, 3792LL);
			//         this.fields.m_shaderVariablesGlobal._FoliageInteractiveParams0.x = 1.0;
			//         v77 = *(_OWORD *)&basicTransformConstants._ViewProjMatrix.m01;
			//         v78 = *(_OWORD *)&basicTransformConstants._ViewProjMatrix.m02;
			//         v79 = *(_OWORD *)&basicTransformConstants._ViewProjMatrix.m03;
			//         *(_OWORD *)&this[1].fields.m_basicTransformConstants._NonJitteredViewProjMatrix.m21 = *(_OWORD *)&basicTransformConstants._ViewProjMatrix.m00;
			//         *(_OWORD *)&this[1].fields.m_basicTransformConstants._NonJitteredViewProjMatrix.m22 = v77;
			//         *(_OWORD *)&this[1].fields.m_basicTransformConstants._NonJitteredViewProjMatrix.m23 = v78;
			//         *(_OWORD *)&this[1].fields.m_basicTransformConstants._NonJitteredViewNoTransProjMatrix.m20 = v79;
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(Patch, v10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2594, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   v83 = *nearPlane;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_948(
			//     Patch,
			//     (Object *)this,
			//     basicTransformConstants,
			//     shaderVariablesGlobal,
			//     (Object *)camera,
			//     &v83,
			//     0LL);
			// }
			// 
		}

		[IDTag(1)]
		private static Vector3 Flip(Vector3 point, float height)
		{
			// // Vector3 Flip(Vector3, Single)
			// Vector3 *HG::Rendering::Runtime::FakePlanarReflectionPass::Flip(
			//         Vector3 *__return_ptr retstr,
			//         Vector3 *point,
			//         float height,
			//         MethodInfo *method)
			// {
			//   float v6; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+30h] [rbp-38h] BYREF
			//   Vector3 v14; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2597, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2597, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = point.z;
			//     *(_QWORD *)&v13.x = *(_QWORD *)&point.x;
			//     v13.z = z;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_952(&v14, Patch, &v13, height, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     v6 = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     retstr.x = point.x;
			//     v6 = point.z;
			//     retstr.y = (float)(height + height) - point.y;
			//   }
			//   retstr.z = v6;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		private static Vector3 Flip(Vector3 point, Vector3 planeNormal, Vector3 planePivot)
		{
			// // Vector3 Flip(Vector3, Vector3, Vector3)
			// Vector3 *HG::Rendering::Runtime::FakePlanarReflectionPass::Flip(
			//         Vector3 *__return_ptr retstr,
			//         Vector3 *point,
			//         Vector3 *planeNormal,
			//         Vector3 *planePivot,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v9; // r9
			//   float v10; // eax
			//   __int64 v11; // xmm0_8
			//   float v12; // eax
			//   Vector3 *v13; // rax
			//   __int64 v14; // xmm3_8
			//   __int64 v15; // xmm0_8
			//   MethodInfo *v16; // r8
			//   Vector3 *v17; // rax
			//   __int64 v18; // xmm0_8
			//   __int64 v19; // xmm4_8
			//   MethodInfo *v20; // r8
			//   MethodInfo *v21; // r9
			//   Vector3 *v22; // rax
			//   __int64 v23; // xmm3_8
			//   MethodInfo *v24; // r9
			//   Vector3 *v25; // rax
			//   __int64 v26; // xmm0_8
			//   __int64 v27; // xmm3_8
			//   MethodInfo *v28; // r9
			//   Vector3 *v29; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v31; // rcx
			//   __int64 v32; // xmm0_8
			//   float z; // eax
			//   __int64 v34; // xmm0_8
			//   float v35; // eax
			//   __int64 v36; // xmm0_8
			//   __int64 v37; // xmm0_8
			//   float v38; // eax
			//   Vector3 v40; // [rsp+30h] [rbp-40h] BYREF
			//   Vector3 v41; // [rsp+40h] [rbp-30h] BYREF
			//   Vector3 v42; // [rsp+50h] [rbp-20h] BYREF
			//   Vector3 v43; // [rsp+60h] [rbp-10h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2593, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2593, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v31, 0LL);
			//     v32 = *(_QWORD *)&planePivot.x;
			//     v42.z = planePivot.z;
			//     z = planeNormal.z;
			//     *(_QWORD *)&v42.x = v32;
			//     v34 = *(_QWORD *)&planeNormal.x;
			//     v41.z = z;
			//     v35 = point.z;
			//     *(_QWORD *)&v41.x = v34;
			//     v36 = *(_QWORD *)&point.x;
			//     v40.z = v35;
			//     *(_QWORD *)&v40.x = v36;
			//     v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_947(&v43, Patch, &v40, &v41, &v42, 0LL);
			//   }
			//   else
			//   {
			//     v10 = point.z;
			//     *(_QWORD *)&v40.x = *(_QWORD *)&point.x;
			//     v11 = *(_QWORD *)&planePivot.x;
			//     v40.z = v10;
			//     v12 = planePivot.z;
			//     *(_QWORD *)&v41.x = v11;
			//     v41.z = v12;
			//     v13 = UnityEngine::Vector3::op_Subtraction(&v42, &v41, &v40, v9);
			//     v14 = *(_QWORD *)&planeNormal.x;
			//     v41.z = planeNormal.z;
			//     v15 = *(_QWORD *)&v13.x;
			//     *(float *)&v13 = v13.z;
			//     *(_QWORD *)&v40.x = v15;
			//     LODWORD(v40.z) = (_DWORD)v13;
			//     *(_QWORD *)&v41.x = v14;
			//     v17 = UnityEngine::Vector3::op_UnaryNegation(&v42, &v41, v16);
			//     v18 = *(_QWORD *)&planeNormal.x;
			//     v19 = *(_QWORD *)&v17.x;
			//     v41.z = v17.z;
			//     v42.z = planeNormal.z;
			//     *(_QWORD *)&v41.x = v19;
			//     *(_QWORD *)&v42.x = v18;
			//     *(float *)&v18 = UnityEngine::Vector3::Dot(&v41, &v40, v20);
			//     v22 = UnityEngine::Vector3::op_Multiply(&v41, &v42, *(float *)&v18, v21);
			//     v23 = *(_QWORD *)&v22.x;
			//     *(float *)&v22 = v22.z;
			//     *(_QWORD *)&v42.x = v23;
			//     LODWORD(v42.z) = (_DWORD)v22;
			//     v25 = UnityEngine::Vector3::op_Multiply(&v41, &v42, 2.0, v24);
			//     v26 = *(_QWORD *)&point.x;
			//     v27 = *(_QWORD *)&v25.x;
			//     v42.z = v25.z;
			//     v41.z = point.z;
			//     *(_QWORD *)&v42.x = v27;
			//     *(_QWORD *)&v41.x = v26;
			//     v29 = UnityEngine::Vector3::op_Subtraction(&v40, &v41, &v42, v28);
			//   }
			//   v37 = *(_QWORD *)&v29.x;
			//   v38 = v29.z;
			//   *(_QWORD *)&retstr.x = v37;
			//   retstr.z = v38;
			//   return retstr;
			// }
			// 
			return null;
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::FakePlanarReflectionPass::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         FakePlanarReflectionPass *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2598, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2598, 0LL);
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
			// void HG::Rendering::Runtime::FakePlanarReflectionPass::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         FakePlanarReflectionPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2599, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2599, 0LL);
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
			// void HG::Rendering::Runtime::FakePlanarReflectionPass::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         FakePlanarReflectionPass *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2600, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2600, 0LL);
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
			// void HG::Rendering::Runtime::FakePlanarReflectionPass::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         FakePlanarReflectionPass *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2601, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2601, 0LL);
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

		private const string COLOR_TEXTURE_NAME = "Fake Planar Reflection Color texture";

		private const string COLOR_BLUR_TEXTURE_NAME = "Fake Planar Reflection Color Blur texture";

		private const string DEPTH_TEXTURE_NAME = "Fake Planar Reflection Depth texture";

		private BasicTransformConstants m_basicTransformConstants;

		private ShaderVariablesGlobal m_shaderVariablesGlobal;

		private RTHandle m_defaultRTHandle;

		private TextureHandle m_planarReflectionTexture;

		private TextureHandle m_planarReflectionDepthTexture;

		private TextureHandle m_planarReflectionBlurTexture;

		private MaterialPropertyBlock m_mpb;

		private Material m_blurMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<FakePlanarReflectionPass.PassData> s_DepthPrepassRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<FakePlanarReflectionPass.PassData> s_RenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<FakePlanarReflectionPass.PassData> s_BlurRenderFunc;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			public bool characterOutlineEnable;

			public uint screenCullingLayerMask;

			public float screenCullingRatio;

			public float screenCullingRatioDistance;

			public PerObjectData bakedLightingConfig;

			public CullingResults cullingResults;

			public ShadowResult shadowResult;

			public HGRenderPipeline hgrp;

			public ScriptableRenderContext renderContext;

			public uint characterPrePassECSList;

			public uint forwardOpaquePreZECSList;

			public uint forwardOpaqueECSList;

			public uint forwardOpaqueEqualECSList;

			public uint characterOpaqueECSList;

			public uint characterOutlineOpaqueECSList;

			public uint characterOutlineOpaqueEqualECSList;

			public TextureHandle sceneColorTexture;

			public TextureHandle sceneDepthTexture;
		}

		internal struct PassOutput
		{
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		public struct BlurData
		{
			public Vector4 blurSize;

			public Vector4 param0;
		}

		private class PassData
		{
			public PassData()
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

			public int blurPass;

			public float blurRadius;

			public Vector2Int renderSize;

			public BasicTransformConstants basicTransformConstants;

			public ShaderVariablesGlobal shaderVariablesGlobal;

			public RendererListHandle characterPrePassRendererList;

			public RendererListHandle forwardOpaqueRenderList;

			public RendererListHandle characterOutlineOpaqueRenderList;

			public TextureHandle planarReflectionTexture;

			public TextureHandle fakePlanarReflectionTexture;

			public bool enableScreenSpaceShadowMask;

			public uint characterPrePassECSList;

			public uint forwardOpaquePreZECSList;

			public uint forwardOpaqueECSList;

			public uint forwardOpaqueEqualECSList;

			public uint characterOpaqueECSList;

			public uint characterOutlineOpaqueECSList;

			public uint characterOutlineOpaqueEqualECSList;

			public HGCamera hgCamera;

			public MaterialPropertyBlock mpb;

			public Material blurMaterial;
		}
	}
}
