using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class MotionBlurPassConstructor : IPassConstructor
	{
		internal MotionBlurPassConstructor(HGRenderPathBase.HGRenderPathResources resources)
		{
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::MotionBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         MotionBlurPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2720, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2720, 0LL);
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
			// void HG::Rendering::Runtime::MotionBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         MotionBlurPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2721, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2721, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		private void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::MotionBlurPassConstructor::Reset(MotionBlurPassConstructor *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 v5; // r8
			//   int i; // edi
			//   TextureHandle__Array *m_historyTextures; // rsi
			//   __int128 *v8; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v12; // [rsp+20h] [rbp-28h] BYREF
			//   _BYTE v13[24]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91958D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D91958D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2722, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2722, 0LL);
			//     if ( !Patch )
			// LABEL_9:
			//       sub_180B536AC(v10, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_historyScreenSize = (Vector2Int)sub_182E7BD70(v4, v3, v5);
			//     for ( i = 0; i < 5; ++i )
			//     {
			//       m_historyTextures = this.fields.m_historyTextures;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v8 = (__int128 *)sub_182E7CCD0(v13);
			//       if ( !m_historyTextures )
			//         goto LABEL_9;
			//       v12 = *v8;
			//       sub_1803EF6F4(m_historyTextures, i, &v12);
			//     }
			//     this.fields.frameIndex = 0;
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref MotionBlurPassConstructor.PassInput input, ref MotionBlurPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(MotionBlurPassConstructor+PassInput ByRef, MotionBlurPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::MotionBlurPassConstructor::ConstructPass(
			//         MotionBlurPassConstructor *this,
			//         MotionBlurPassConstructor_PassInput *input,
			//         MotionBlurPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   HGSettingParameters *settingParameters; // rbx
			//   ProfilingSampler *v15; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   Vector2Int sceneRTSize_k__BackingField; // rdi
			//   int32_t v19; // r12d
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   int32_t v22; // r13d
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
			//   HGMotionBlur *m_motionBlur; // rax
			//   Single__Array *m_parameters; // r14
			//   ClampedFloatParameter *shutterAngle; // rdx
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   __int64 v29; // r9
			//   float v30; // xmm0_4
			//   float v31; // xmm0_4
			//   Single__Array *v32; // rcx
			//   __int64 m_X; // rdx
			//   __int64 v34; // rdx
			//   Single__Array *v35; // rcx
			//   Single__Array *v36; // r14
			//   int v37; // eax
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   __int64 v40; // r8
			//   __int64 v41; // r9
			//   Single__Array *v42; // rax
			//   Single__Array *v43; // rax
			//   Single__Array *v44; // rax
			//   Single__Array *v45; // rax
			//   Object *v46; // r14
			//   int v47; // eax
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   Object *v50; // r14
			//   int v51; // eax
			//   __int64 v52; // rdx
			//   __int64 v53; // rcx
			//   __int128 v54; // xmm2
			//   __int128 v55; // xmm3
			//   Color clearColor; // xmm4
			//   unsigned __int64 v57; // r8
			//   signed __int64 v58; // rtt
			//   __int64 v59; // rdx
			//   __int64 v60; // rcx
			//   TextureHandle v61; // xmm0
			//   __int128 v62; // xmm2
			//   __int128 v63; // xmm3
			//   Color v64; // xmm4
			//   unsigned __int64 v65; // r8
			//   signed __int64 v66; // rtt
			//   __int64 v67; // rdx
			//   __int64 v68; // rcx
			//   TextureHandle v69; // xmm0
			//   __int64 v70; // rdx
			//   __int64 v71; // rcx
			//   __int64 v72; // rdx
			//   __int64 v73; // rcx
			//   __int128 v74; // xmm2
			//   __int128 v75; // xmm3
			//   Color v76; // xmm4
			//   unsigned __int64 v77; // r8
			//   signed __int64 v78; // rtt
			//   Object *v79; // r12
			//   __int64 v80; // rdx
			//   __int64 v81; // rcx
			//   TextureHandle v82; // xmm0
			//   Object *v83; // r13
			//   int v84; // eax
			//   __int64 v85; // rdx
			//   __int64 v86; // rcx
			//   Object *v87; // rdi
			//   int v88; // eax
			//   __int64 v89; // rdx
			//   __int64 v90; // rcx
			//   MotionBlurPassConstructor_PassInput *v91; // r13
			//   Object *v92; // rbx
			//   __int64 v93; // rdx
			//   __int64 v94; // rcx
			//   TextureHandle v95; // xmm0
			//   Object *v96; // rbx
			//   MotionBlurPassConstructor_PassOutput v97; // xmm6
			//   __int64 v98; // rdx
			//   __int64 v99; // rdx
			//   __int64 v100; // rcx
			//   float v101; // xmm0_4
			//   __int64 v102; // rdx
			//   Object *v103; // rcx
			//   __int64 v104; // rdx
			//   __int64 v105; // rcx
			//   __int64 v106; // r13
			//   TextureHandle__Array *m_historyTextures; // rbx
			//   TextureHandle *v108; // rax
			//   __int64 v109; // rdx
			//   __int64 v110; // rcx
			//   Single__Array *m_historyTimes; // rbx
			//   __int64 v112; // rdx
			//   Single__Array *v113; // rcx
			//   __int64 v114; // r8
			//   __int64 v115; // r9
			//   float time; // xmm0_4
			//   signed int i; // r12d
			//   unsigned int v118; // ebx
			//   __int64 v119; // rdx
			//   unsigned int v120; // ebx
			//   TextureHandle__Array *v121; // rdi
			//   TextureHandle *v122; // rax
			//   Vector2Int m_historyScreenSize; // rax
			//   Vector2Int v124; // rcx
			//   unsigned __int64 v125; // rcx
			//   __int64 v126; // rdx
			//   float v127; // xmm2_4
			//   Beyond::JobMathf *v128; // rcx
			//   __int64 v129; // rdx
			//   TextureHandle__Array *v130; // rdi
			//   TextureHandle *v131; // rax
			//   __int64 v132; // rdx
			//   __int64 v133; // rcx
			//   __int64 v134; // r8
			//   __int64 v135; // r9
			//   Single__Array *v136; // rdi
			//   Single__Array *v137; // rax
			//   __int64 v138; // r8
			//   float v139; // xmm0_4
			//   __int64 v140; // rax
			//   TextureHandle__Array *v141; // rdi
			//   TextureHandle *v142; // rax
			//   __int64 v143; // rdx
			//   __int64 v144; // rcx
			//   __int64 v145; // r8
			//   __int64 v146; // rax
			//   Object *v147; // rdx
			//   unsigned int v148; // edx
			//   unsigned __int64 v149; // r8
			//   signed __int64 v150; // rtt
			//   TextureHandle *v151; // rbx
			//   TextureHandle__Array *v152; // rcx
			//   __int64 v153; // rcx
			//   __int64 m_tileMaxKernel; // rcx
			//   __int64 m_tileNeighborKernel; // rcx
			//   __int64 m_motionBlurKernel; // rcx
			//   __int64 m_blendMotionBlurKernel; // rcx
			//   Object *v158; // rdx
			//   int v159; // eax
			//   unsigned int v160; // edx
			//   unsigned __int64 v161; // r8
			//   char v162; // dl
			//   signed __int64 v163; // rtt
			//   Object *v164; // rdx
			//   MonitorData *m_motionBlurCS; // rcx
			//   unsigned int v166; // edx
			//   unsigned __int64 v167; // r8
			//   char v168; // dl
			//   signed __int64 v169; // rtt
			//   Object *v170; // rbx
			//   __int64 v171; // rdx
			//   __int64 v172; // rcx
			//   TextureHandle v173; // xmm0
			//   Object *v174; // rbx
			//   __int64 v175; // rdx
			//   __int64 v176; // rcx
			//   TextureHandle v177; // xmm0
			//   Object *v178; // rbx
			//   __int64 v179; // rdx
			//   __int64 v180; // rcx
			//   TextureHandle v181; // xmm0
			//   struct RenderFunc_1_HG_Rendering_Runtime_MotionBlurPassConstructor_MotionBlurPassData___Class *element_class; // rbx
			//   __int64 v183; // rcx
			//   __int64 instance_size; // rcx
			//   __int64 v185; // rdx
			//   struct RenderFunc_1_HG_Rendering_Runtime_MotionBlurPassConstructor_MotionBlurPassData___Class **v186; // rax
			//   __int64 v187; // rdx
			//   RenderFunc_1_System_Object_ *v188; // rdi
			//   char *v189; // rcx
			//   __int64 v190; // r8
			//   char *v191; // rax
			//   unsigned __int64 v192; // r8
			//   __int64 v193; // rdx
			//   __int64 j; // r14
			//   __int64 v195; // rax
			//   __int64 v196; // rdx
			//   __int64 v197; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v199; // rdx
			//   __int64 v200; // rcx
			//   Object *v201; // [rsp+40h] [rbp-458h] BYREF
			//   TextureHandle v202; // [rsp+50h] [rbp-448h] BYREF
			//   _QWORD v203[2]; // [rsp+60h] [rbp-438h] BYREF
			//   __int128 v204; // [rsp+70h] [rbp-428h] BYREF
			//   __int128 v205; // [rsp+80h] [rbp-418h]
			//   __int128 v206; // [rsp+90h] [rbp-408h]
			//   __int128 v207; // [rsp+A0h] [rbp-3F8h] BYREF
			//   __int128 v208; // [rsp+B0h] [rbp-3E8h]
			//   Color v209; // [rsp+C0h] [rbp-3D8h]
			//   TextureHandle v210; // [rsp+D0h] [rbp-3C8h] BYREF
			//   HGRenderGraphBuilder v211; // [rsp+E0h] [rbp-3B8h] BYREF
			//   _QWORD v212[2]; // [rsp+100h] [rbp-398h] BYREF
			//   TextureHandle sceneColor; // [rsp+110h] [rbp-388h]
			//   HGRenderGraphBuilder v214; // [rsp+120h] [rbp-378h] BYREF
			//   Il2CppExceptionWrapper *v215; // [rsp+140h] [rbp-358h] BYREF
			//   TextureDesc v216; // [rsp+150h] [rbp-348h] BYREF
			//   TextureDesc v217; // [rsp+1B0h] [rbp-2E8h] BYREF
			//   TextureDesc v218; // [rsp+210h] [rbp-288h] BYREF
			//   TextureDesc v219; // [rsp+270h] [rbp-228h] BYREF
			//   TextureDesc v220; // [rsp+2D0h] [rbp-1C8h] BYREF
			//   TextureDesc v221; // [rsp+330h] [rbp-168h] BYREF
			//   TextureDesc v222; // [rsp+390h] [rbp-108h] BYREF
			//   TextureDesc v223; // [rsp+3F0h] [rbp-A8h] BYREF
			// 
			//   if ( !byte_18D91958E )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::MotionBlurPassConstructor::_ConstructPass_b__21_0);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D500DE0);
			//     sub_18003C530(&off_18D500DF0);
			//     sub_18003C530(&off_18D500DF8);
			//     sub_18003C530(&off_18D500DC0);
			//     byte_18D91958E = 1;
			//   }
			//   v201 = 0LL;
			//   sub_1802F01E0(&v219, 0LL, 96LL);
			//   sub_1802F01E0(&v204, 0LL, 96LL);
			//   sub_1802F01E0(&v221, 0LL, 96LL);
			//   sub_1802F01E0(&v223, 0LL, 96LL);
			//   sub_1802F01E0(&v216, 0LL, 96LL);
			//   sub_1802F01E0(&v217, 0LL, 96LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(2723, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2723, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v200, v199);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_996(
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
			//     if ( !HG::Rendering::Runtime::HGCamera::get_enableMotionBlur(camera, 0LL) )
			//       goto LABEL_152;
			//     settingParameters = input.settingParameters;
			//     if ( !settingParameters )
			//       sub_180B536AC(v13, v12);
			//     if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            settingParameters.fields._motionBlurEnable_k__BackingField,
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//     {
			//       sceneColor = input.sceneColor;
			//       v15 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0xA3u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !renderGraph )
			//         sub_180B536AC(v17, v16);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v214,
			//         renderGraph,
			//         (String *)"Motion Blur Pass",
			//         &v201,
			//         v15,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassData>);
			//       v211 = v214;
			//       v212[0] = 0LL;
			//       v212[1] = &v211;
			//       try
			//       {
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v211, 0, 0LL);
			//         sceneRTSize_k__BackingField = camera.fields._sceneRTSize_k__BackingField;
			//         v19 = sub_1826E82D0();
			//         if ( v19 < 1 )
			//           v19 = 1;
			//         v22 = sub_1826E82D0();
			//         if ( v22 < 1 )
			//           v22 = 1;
			//         m_volumeComponentsData = camera.fields.m_volumeComponentsData;
			//         if ( !m_volumeComponentsData )
			//           sub_1802DC2C8(v21, v20);
			//         m_motionBlur = m_volumeComponentsData.fields.m_motionBlur;
			//         v203[0] = m_motionBlur;
			//         m_parameters = this.fields.m_parameters;
			//         if ( !m_motionBlur )
			//           sub_1802DC2C8(v21, v20);
			//         shutterAngle = m_motionBlur.fields.shutterAngle;
			//         if ( !shutterAngle )
			//           sub_1802DC2C8(v21, 0LL);
			//         v30 = sub_18003F9B0(10LL, shutterAngle);
			//         if ( !m_parameters )
			//           sub_1802DC2C8(v28, v27);
			//         v31 = v30 / 360.0;
			//         if ( !m_parameters.max_length.size )
			//           sub_180070260(v28, v27, 0LL, v29);
			//         m_parameters.vector[0] = v31;
			//         v32 = this.fields.m_parameters;
			//         m_X = (unsigned int)sceneRTSize_k__BackingField.m_X;
			//         if ( sceneRTSize_k__BackingField.m_X >= sceneRTSize_k__BackingField.m_Y )
			//           m_X = (unsigned int)sceneRTSize_k__BackingField.m_Y;
			//         if ( !v32 )
			//           sub_1802DC2C8(0LL, m_X);
			//         if ( v32.max_length.size <= 1u )
			//           sub_180070260(v32, m_X, 0LL, v29);
			//         v34 = (unsigned int)((int)m_X / 20);
			//         v32.vector[1] = (float)(int)v34;
			//         v35 = this.fields.m_parameters;
			//         if ( !v35 )
			//           sub_1802DC2C8(0LL, v34);
			//         if ( v35.max_length.size <= 1u )
			//           sub_180070260(v35, v34, 0LL, v29);
			//         if ( v35.max_length.size <= 2u )
			//           sub_180070260(v35, v34, 0LL, v29);
			//         v35.vector[2] = 1.0 / v35.vector[1];
			//         v36 = this.fields.m_parameters;
			//         if ( !*(_QWORD *)(v203[0] + 72LL) )
			//           sub_1802DC2C8(v35, 0LL);
			//         v37 = sub_18003ED00(10LL);
			//         if ( !v36 )
			//           sub_1802DC2C8(v39, v38);
			//         if ( v36.max_length.size <= 3u )
			//           sub_180070260(v39, 3LL, v40, v41);
			//         v36.vector[3] = (float)v37;
			//         v42 = this.fields.m_parameters;
			//         if ( !v42 )
			//           sub_1802DC2C8(v39, 3LL);
			//         if ( v42.max_length.size <= 4u )
			//           sub_180070260(v39, 4LL, v40, v41);
			//         v42.vector[4] = (float)v19;
			//         v43 = this.fields.m_parameters;
			//         if ( !v43 )
			//           sub_1802DC2C8(v39, 4LL);
			//         if ( v43.max_length.size <= 5u )
			//           sub_180070260(v39, 4LL, v40, v41);
			//         v43.vector[5] = (float)v22;
			//         v44 = this.fields.m_parameters;
			//         if ( !v44 )
			//           sub_1802DC2C8(v39, 4LL);
			//         if ( v44.max_length.size <= 6u )
			//           sub_180070260(v39, 4LL, v40, v41);
			//         v44.vector[6] = 1.0 / (float)v19;
			//         v45 = this.fields.m_parameters;
			//         if ( !v45 )
			//           sub_1802DC2C8(v39, 4LL);
			//         if ( v45.max_length.size <= 7u )
			//           sub_180070260(v39, 4LL, v40, v41);
			//         v45.vector[7] = 1.0 / (float)v22;
			//         v46 = v201;
			//         v47 = sub_1826E82D0();
			//         if ( !v46 )
			//           sub_1802DC2C8(v49, v48);
			//         HIDWORD(v46[2].klass) = v47;
			//         v50 = v201;
			//         v51 = sub_1826E82D0();
			//         if ( !v50 )
			//           sub_1802DC2C8(v53, v52);
			//         LODWORD(v50[2].monitor) = v51;
			//         sub_1802F01E0(&v218, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//           &v218,
			//           sceneRTSize_k__BackingField.m_X,
			//           sceneRTSize_k__BackingField.m_Y,
			//           0LL);
			//         v54 = *(_OWORD *)&v218.width;
			//         v204 = *(_OWORD *)&v218.width;
			//         v205 = *(_OWORD *)&v218.colorFormat;
			//         v206 = *(_OWORD *)&v218.enableRandomWrite;
			//         *(_QWORD *)&v207 = *(_QWORD *)&v218.bindTextureMS;
			//         v55 = *(_OWORD *)&v218.fastMemoryDesc.inFastMemory;
			//         v208 = *(_OWORD *)&v218.fastMemoryDesc.inFastMemory;
			//         clearColor = v218.clearColor;
			//         v209 = v218.clearColor;
			//         LODWORD(v205) = 75;
			//         LOBYTE(v206) = 1;
			//         *((_QWORD *)&v207 + 1) = "Motion Blur Packing";
			//         if ( dword_18D8E43F8 )
			//         {
			//           v57 = ((((unsigned __int64)&v207 + 8) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v57 + 36190]);
			//           do
			//             v58 = qword_18D6405E0[v57 + 36190];
			//           while ( v58 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v57 + 36190],
			//                            v58 | (1LL << ((((unsigned __int64)&v207 + 8) >> 12) & 0x3F)),
			//                            v58) );
			//           clearColor = v209;
			//           v55 = v208;
			//           v54 = v204;
			//         }
			//         *(_WORD *)((char *)&v206 + 1) = 0;
			//         *(_OWORD *)&v219.width = v54;
			//         *(_OWORD *)&v219.colorFormat = v205;
			//         *(_OWORD *)&v219.enableRandomWrite = v206;
			//         *(_OWORD *)&v219.bindTextureMS = v207;
			//         *(_OWORD *)&v219.fastMemoryDesc.inFastMemory = v55;
			//         v219.clearColor = clearColor;
			//         v202.handle = (ResourceHandle)v201;
			//         v61 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(&v210, &v211, &v219, 0LL);
			//         if ( !*(_QWORD *)&v202.handle )
			//           sub_1802DC2C8(v60, v59);
			//         *(TextureHandle *)(*(_QWORD *)&v202.handle + 144LL) = v61;
			//         if ( !v201 )
			//           sub_1802DC2C8(v60, v59);
			//         HIDWORD(v201[2].monitor) = v19;
			//         if ( !v201 )
			//           sub_1802DC2C8(v60, v59);
			//         LODWORD(v201[3].klass) = v22;
			//         sub_1802F01E0(&v220, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v220, v19, v22, 0LL);
			//         v62 = *(_OWORD *)&v220.width;
			//         v204 = *(_OWORD *)&v220.width;
			//         v205 = *(_OWORD *)&v220.colorFormat;
			//         v206 = *(_OWORD *)&v220.enableRandomWrite;
			//         *(_QWORD *)&v207 = *(_QWORD *)&v220.bindTextureMS;
			//         v63 = *(_OWORD *)&v220.fastMemoryDesc.inFastMemory;
			//         v208 = *(_OWORD *)&v220.fastMemoryDesc.inFastMemory;
			//         v64 = v220.clearColor;
			//         v209 = v220.clearColor;
			//         LODWORD(v205) = 46;
			//         LOBYTE(v206) = 1;
			//         *((_QWORD *)&v207 + 1) = "Motion Blur Tile Max";
			//         if ( dword_18D8E43F8 )
			//         {
			//           v65 = ((((unsigned __int64)&v207 + 8) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v65 + 36190]);
			//           do
			//             v66 = qword_18D6405E0[v65 + 36190];
			//           while ( v66 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v65 + 36190],
			//                            v66 | (1LL << ((((unsigned __int64)&v207 + 8) >> 12) & 0x3F)),
			//                            v66) );
			//           v64 = v209;
			//           v63 = v208;
			//           v62 = v204;
			//         }
			//         *(_WORD *)((char *)&v206 + 1) = 0;
			//         *(_OWORD *)&v221.width = v62;
			//         *(_OWORD *)&v221.colorFormat = v205;
			//         *(_OWORD *)&v221.enableRandomWrite = v206;
			//         *(_OWORD *)&v221.bindTextureMS = v207;
			//         *(_OWORD *)&v221.fastMemoryDesc.inFastMemory = v63;
			//         v221.clearColor = v64;
			//         v202.handle = (ResourceHandle)v201;
			//         v69 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(&v210, &v211, &v221, 0LL);
			//         if ( !*(_QWORD *)&v202.handle )
			//           sub_1802DC2C8(v68, v67);
			//         *(TextureHandle *)(*(_QWORD *)&v202.handle + 160LL) = v69;
			//         v202.handle = (ResourceHandle)v201;
			//         v71 = (unsigned int)sub_1826E82D0();
			//         if ( !*(_QWORD *)&v202.handle )
			//           sub_1802DC2C8(v71, v70);
			//         *(_DWORD *)(*(_QWORD *)&v202.handle + 52LL) = v71;
			//         v202.handle = (ResourceHandle)v201;
			//         v73 = (unsigned int)sub_1826E82D0();
			//         if ( !*(_QWORD *)&v202.handle )
			//           sub_1802DC2C8(v73, v72);
			//         *(_DWORD *)(*(_QWORD *)&v202.handle + 56LL) = v73;
			//         sub_1802F01E0(&v222, 0LL, 96LL);
			//         HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v222, v19, v22, 0LL);
			//         v74 = *(_OWORD *)&v222.width;
			//         v204 = *(_OWORD *)&v222.width;
			//         v205 = *(_OWORD *)&v222.colorFormat;
			//         v206 = *(_OWORD *)&v222.enableRandomWrite;
			//         *(_QWORD *)&v207 = *(_QWORD *)&v222.bindTextureMS;
			//         v75 = *(_OWORD *)&v222.fastMemoryDesc.inFastMemory;
			//         v208 = *(_OWORD *)&v222.fastMemoryDesc.inFastMemory;
			//         v76 = v222.clearColor;
			//         v209 = v222.clearColor;
			//         LODWORD(v205) = 46;
			//         LOBYTE(v206) = 1;
			//         *((_QWORD *)&v207 + 1) = "Motion Blur Target";
			//         if ( dword_18D8E43F8 )
			//         {
			//           v77 = ((((unsigned __int64)&v207 + 8) >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v77 + 36190]);
			//           do
			//             v78 = qword_18D6405E0[v77 + 36190];
			//           while ( v78 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v77 + 36190],
			//                            v78 | (1LL << ((((unsigned __int64)&v207 + 8) >> 12) & 0x3F)),
			//                            v78) );
			//           v76 = v209;
			//           v75 = v208;
			//           v74 = v204;
			//         }
			//         *(_WORD *)((char *)&v206 + 1) = 0;
			//         *(_OWORD *)&v223.width = v74;
			//         *(_OWORD *)&v223.colorFormat = v205;
			//         *(_OWORD *)&v223.enableRandomWrite = v206;
			//         *(_OWORD *)&v223.bindTextureMS = v207;
			//         *(_OWORD *)&v223.fastMemoryDesc.inFastMemory = v75;
			//         v223.clearColor = v76;
			//         v79 = v201;
			//         v82 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(&v210, &v211, &v223, 0LL);
			//         if ( !v79 )
			//           sub_1802DC2C8(v81, v80);
			//         v79[11] = (Object)v82;
			//         v83 = v201;
			//         v84 = sub_1826E82D0();
			//         if ( !v83 )
			//           sub_1802DC2C8(v86, v85);
			//         HIDWORD(v83[3].monitor) = v84;
			//         v87 = v201;
			//         v88 = sub_1826E82D0();
			//         if ( !v87 )
			//           sub_1802DC2C8(v90, v89);
			//         LODWORD(v87[4].klass) = v88;
			//         if ( !renderGraph )
			//           sub_1802DC2C8(v90, v89);
			//         v91 = input;
			//         v216 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(renderGraph, &input.sceneColor, 0LL);
			//         v216.enableRandomWrite = 1;
			//         v92 = v201;
			//         v202 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v210, renderGraph, &v216, 0LL);
			//         v95 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(&v210, &v211, &v202, 0LL);
			//         if ( !v92 )
			//           sub_1802DC2C8(v94, v93);
			//         v92[12] = (Object)v95;
			//         v96 = v201;
			//         if ( !v201 )
			//           sub_1802DC2C8(v94, v93);
			//         v97 = (MotionBlurPassConstructor_PassOutput)v201[12];
			//         sceneColor = v97.result;
			//         v98 = *(_QWORD *)(v203[0] + 64LL);
			//         if ( !v98 )
			//           sub_1802DC2C8(v94, 0LL);
			//         v101 = sub_18003F9B0(10LL, v98);
			//         if ( !v96 )
			//           sub_1802DC2C8(v100, v99);
			//         *(float *)&v96[4].monitor = v101;
			//         if ( !v201 )
			//           sub_1802DC2C8(0LL, v99);
			//         if ( *(float *)&v201[4].monitor > 0.0 )
			//         {
			//           HIDWORD(v201[4].klass) = this.fields.frameIndex;
			//           v217 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(
			//                     renderGraph,
			//                     &input.sceneColor,
			//                     0LL);
			//           v217.enableRandomWrite = 1;
			//           if ( !v201 )
			//             sub_1802DC2C8(v105, v104);
			//           v106 = HIDWORD(v201[4].klass) % 5;
			//           m_historyTextures = this.fields.m_historyTextures;
			//           v202 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v210, renderGraph, &v217, 0LL);
			//           v108 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(&v210, &v211, &v202, 0LL);
			//           if ( !m_historyTextures )
			//             sub_1802DC2C8(v110, v109);
			//           v202 = *v108;
			//           sub_1803EF6F4(m_historyTextures, (unsigned int)v106, &v202);
			//           m_historyTimes = this.fields.m_historyTimes;
			//           time = UnityEngine::Time::get_time(0LL);
			//           if ( !m_historyTimes )
			//             sub_1802DC2C8(v113, v112);
			//           if ( (unsigned int)v106 >= m_historyTimes.max_length.size )
			//             sub_180070260(v113, v112, v114, v115);
			//           m_historyTimes.vector[v106] = time;
			//           for ( i = 1; (unsigned int)i <= 4; ++i )
			//           {
			//             if ( !v201 )
			//               sub_1802DC2C8(v113, v112);
			//             v118 = HIDWORD(v201[4].klass) - i + 5;
			//             v119 = v118 / 5;
			//             v120 = v118 % 5;
			//             v121 = this.fields.m_historyTextures;
			//             if ( !v121 )
			//               sub_1802DC2C8(v113, v119);
			//             sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//             v122 = (TextureHandle *)sub_18037A2E0(v121, v120);
			//             if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(v122, 0LL)
			//               && (m_historyScreenSize = this.fields.m_historyScreenSize,
			//                   v124 = camera.fields._sceneRTSize_k__BackingField,
			//                   m_historyScreenSize.m_X == v124.m_X)
			//               && (v125 = HIDWORD(*(unsigned __int64 *)&v124), m_historyScreenSize.m_Y == (_DWORD)v125) )
			//             {
			//               v126 = *(_QWORD *)(v203[0] + 64LL);
			//               if ( !v126 )
			//                 sub_1802DC2C8(v125, 0LL);
			//               v127 = sub_18003F9B0(10LL, v126);
			//               Beyond::JobMathf::ClampedLerp(v128, 16.0, v127);
			//               v130 = this.fields.m_historyTextures;
			//               if ( !v130 )
			//                 sub_1802DC2C8(0LL, v129);
			//               v131 = (TextureHandle *)sub_18037A2E0(v130, v120);
			//               v202 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v210, &v211, v131, 0LL);
			//               sub_1803EF6F4(v130, v120, &v202);
			//               v136 = this.fields.m_parameters;
			//               v137 = this.fields.m_historyTimes;
			//               if ( !v137 )
			//                 sub_1802DC2C8(v133, v132);
			//               if ( v120 >= v137.max_length.size )
			//                 sub_180070260(v133, v132, v134, v135);
			//               if ( (unsigned int)v106 >= v137.max_length.size )
			//                 sub_180070260(v133, v132, v134, v135);
			//               v139 = sub_1802EA170();
			//               if ( !v136 )
			//                 sub_1802DC2C8(v113, v112);
			//               v140 = i + 7LL;
			//               if ( (unsigned int)v140 >= v136.max_length.size )
			//                 sub_180070260(v113, v112, v138, v115);
			//               v136.vector[v140] = v139;
			//             }
			//             else
			//             {
			//               v141 = this.fields.m_historyTextures;
			//               sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//               v142 = (TextureHandle *)sub_182E7CCD0(&v214);
			//               if ( !v141 )
			//                 sub_1802DC2C8(v144, v143);
			//               v202 = *v142;
			//               sub_1803EF6F4(v141, v120, &v202);
			//               v113 = this.fields.m_parameters;
			//               if ( !v113 )
			//                 sub_1802DC2C8(0LL, v112);
			//               v146 = i + 7LL;
			//               if ( (unsigned int)v146 >= v113.max_length.size )
			//                 sub_180070260(v113, v112, v145, v115);
			//               v113.vector[v146] = 0.0;
			//             }
			//           }
			//           this.fields.m_historyScreenSize = camera.fields._sceneRTSize_k__BackingField;
			//           v147 = v201;
			//           if ( !v201 )
			//             sub_1802DC2C8(v113, 0LL);
			//           v201[14].klass = (Object__Class *)this.fields.m_historyTextures;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v148 = ((unsigned __int64)&v147[14] >> 12) & 0x1FFFFF;
			//             v149 = (unsigned __int64)v148 >> 6;
			//             v147 = (Object *)(v148 & 0x3F);
			//             _m_prefetchw(&qword_18D6405E0[v149 + 36190]);
			//             do
			//               v150 = qword_18D6405E0[v149 + 36190];
			//             while ( v150 != _InterlockedCompareExchange64(
			//                               &qword_18D6405E0[v149 + 36190],
			//                               v150 | (1LL << (char)v147),
			//                               v150) );
			//           }
			//           v151 = (TextureHandle *)v201;
			//           v152 = this.fields.m_historyTextures;
			//           if ( !v152 )
			//             sub_1802DC2C8(0LL, v147);
			//           sub_18037A36C(v152, &v202, (unsigned int)v106, v115);
			//           if ( !v151 )
			//             sub_1802DC2C8(v153, v102);
			//           v151[13] = v202;
			//           v103 = v201;
			//           if ( !v201 )
			//             sub_1802DC2C8(0LL, v102);
			//           v97 = (MotionBlurPassConstructor_PassOutput)v201[13];
			//           sceneColor = v97.result;
			//           ++this.fields.frameIndex;
			//           v91 = input;
			//         }
			//         else
			//         {
			//           HG::Rendering::Runtime::MotionBlurPassConstructor::Reset(this, 0LL);
			//           v103 = v201;
			//         }
			//         if ( !v103 )
			//           sub_1802DC2C8(0LL, v102);
			//         LODWORD(v103[1].klass) = this.fields.m_packingKernel;
			//         m_tileMaxKernel = (unsigned int)this.fields.m_tileMaxKernel;
			//         if ( !v201 )
			//           sub_1802DC2C8(m_tileMaxKernel, v102);
			//         HIDWORD(v201[1].klass) = m_tileMaxKernel;
			//         m_tileNeighborKernel = (unsigned int)this.fields.m_tileNeighborKernel;
			//         if ( !v201 )
			//           sub_1802DC2C8(m_tileNeighborKernel, v102);
			//         LODWORD(v201[1].monitor) = m_tileNeighborKernel;
			//         m_motionBlurKernel = (unsigned int)this.fields.m_motionBlurKernel;
			//         if ( !v201 )
			//           sub_1802DC2C8(m_motionBlurKernel, v102);
			//         HIDWORD(v201[1].monitor) = m_motionBlurKernel;
			//         m_blendMotionBlurKernel = (unsigned int)this.fields.m_blendMotionBlurKernel;
			//         if ( !v201 )
			//           sub_1802DC2C8(m_blendMotionBlurKernel, v102);
			//         LODWORD(v201[2].klass) = m_blendMotionBlurKernel;
			//         v158 = v201;
			//         if ( !v201 )
			//           sub_1802DC2C8(m_blendMotionBlurKernel, 0LL);
			//         v201[5].monitor = (MonitorData *)this.fields.m_parameters;
			//         v159 = dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v160 = ((unsigned __int64)&v158[5].monitor >> 12) & 0x1FFFFF;
			//           v161 = (unsigned __int64)v160 >> 6;
			//           v162 = v160 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v161 + 36190]);
			//           do
			//             v163 = qword_18D6405E0[v161 + 36190];
			//           while ( v163 != _InterlockedCompareExchange64(&qword_18D6405E0[v161 + 36190], v163 | (1LL << v162), v163) );
			//           v159 = dword_18D8E43F8;
			//         }
			//         v164 = v201;
			//         m_motionBlurCS = (MonitorData *)this.fields.m_motionBlurCS;
			//         if ( !v201 )
			//           sub_1802DC2C8(m_motionBlurCS, 0LL);
			//         v201[14].monitor = m_motionBlurCS;
			//         if ( v159 )
			//         {
			//           v166 = ((unsigned __int64)&v164[14].monitor >> 12) & 0x1FFFFF;
			//           v167 = (unsigned __int64)v166 >> 6;
			//           v168 = v166 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v167 + 36190]);
			//           do
			//             v169 = qword_18D6405E0[v167 + 36190];
			//           while ( v169 != _InterlockedCompareExchange64(&qword_18D6405E0[v167 + 36190], v169 | (1LL << v168), v169) );
			//         }
			//         v170 = v201;
			//         v173 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                   (TextureHandle *)&v214,
			//                   &v211,
			//                   &v91.sceneColor,
			//                   0LL);
			//         if ( !v170 )
			//           sub_1802DC2C8(v172, v171);
			//         v170[6] = (Object)v173;
			//         v174 = v201;
			//         v177 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                   (TextureHandle *)&v214,
			//                   &v211,
			//                   &v91.sceneDepth,
			//                   0LL);
			//         if ( !v174 )
			//           sub_1802DC2C8(v176, v175);
			//         v174[7] = (Object)v177;
			//         v178 = v201;
			//         v181 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
			//                   (TextureHandle *)&v214,
			//                   &v211,
			//                   &v91.sceneMV,
			//                   0LL);
			//         if ( !v178 )
			//           sub_1802DC2C8(v180, v179);
			//         v178[8] = (Object)v181;
			//         element_class = TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassData>;
			//         if ( ((__int64)TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassData>.vtable.Equals.methodPtr & 2) == 0 )
			//         {
			//           v203[0] = &qword_18CDB0B30;
			//           sub_1802924D0(&qword_18CDB0B30);
			//           sub_180060090(element_class, v203);
			//           v183 = v203[0];
			//           if ( *(int *)(v203[0] + 80LL) > 0 )
			//           {
			//             if ( *(_DWORD *)(v203[0] + 80LL) == 1 )
			//             {
			//               *(_QWORD *)(v203[0] + 72LL) = 0LL;
			//               *(_DWORD *)(v183 + 80) = 0;
			//               sub_18010B970(v183, 1LL);
			//             }
			//             else
			//             {
			//               --*(_DWORD *)(v203[0] + 80LL);
			//             }
			//           }
			//         }
			//         if ( element_class._0.generic_class && ((__int64)element_class.vtable.Equals.methodPtr & 8) != 0 )
			//           element_class = (struct RenderFunc_1_HG_Rendering_Runtime_MotionBlurPassConstructor_MotionBlurPassData___Class *)element_class._0.element_class;
			//         instance_size = element_class._1.instance_size;
			//         if ( ((__int64)element_class.vtable.Equals.methodPtr & 0x20) != 0 )
			//         {
			//           if ( element_class._0.gc_desc )
			//           {
			//             v188 = (RenderFunc_1_System_Object_ *)sub_180005220(instance_size, element_class);
			//           }
			//           else
			//           {
			//             v193 = 1LL;
			//             if ( dword_18D8E43FC == 1 )
			//               v193 = 4LL;
			//             v188 = (RenderFunc_1_System_Object_ *)sub_18002D3D0(instance_size, v193);
			//             v188.klass = (RenderFunc_1_System_Object___Class *)element_class;
			//           }
			//         }
			//         else
			//         {
			//           v185 = 0LL;
			//           if ( dword_18D8E43FC == 1 )
			//             v185 = 3LL;
			//           v186 = (struct RenderFunc_1_HG_Rendering_Runtime_MotionBlurPassConstructor_MotionBlurPassData___Class **)sub_18002D3D0(instance_size, v185);
			//           v188 = (RenderFunc_1_System_Object_ *)v186;
			//           *v186 = element_class;
			//           v186[1] = 0LL;
			//           v189 = (char *)(v186 + 2);
			//           v190 = element_class._1.instance_size;
			//           if ( element_class._1.instance_size >= 0x80 )
			//           {
			//             sub_1802F01E0(v189, 0LL, v190 - 16);
			//           }
			//           else
			//           {
			//             v191 = (char *)v186 + v190;
			//             v192 = (unsigned __int64)(v191 - v189 + 7) >> 3;
			//             if ( v189 > v191 )
			//               v192 = 0LL;
			//             if ( v192 )
			//               sub_1802F01E0(v189, 0LL, 8 * v192);
			//           }
			//         }
			//         _InterlockedAdd64(&qword_18D8E51F8, 1uLL);
			//         if ( (BYTE1(element_class.vtable.Equals.methodPtr) & 2) != 0 )
			//           sub_18002E8C0((_DWORD)v188, (unsigned int)sub_18007DC30, 0, (unsigned int)v203, (__int64)&v202);
			//         if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//         {
			//           v187 = qword_18D8F6CE0;
			//           for ( j = qword_18D8F6CE0; j != v187 + 8 * qword_18D8F6CE8; j += 8LL )
			//           {
			//             v195 = *(_QWORD *)j;
			//             if ( *(char *)(*(_QWORD *)j + 8LL) < 0 )
			//             {
			//               if ( *(_QWORD *)(v195 + 40) )
			//               {
			//                 (*(void (__fastcall **)(_QWORD, RenderFunc_1_System_Object_ *, struct RenderFunc_1_HG_Rendering_Runtime_MotionBlurPassConstructor_MotionBlurPassData___Class *))(v195 + 40))(
			//                   *(_QWORD *)v195,
			//                   v188,
			//                   element_class);
			//                 v187 = qword_18D8F6CE0;
			//               }
			//             }
			//           }
			//         }
			//         il2cpp_runtime_class_init_0(element_class, v187);
			//         if ( !v188 )
			//           sub_1802DC2C8(v197, v196);
			//         HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
			//           v188,
			//           (Object *)this,
			//           MethodInfo::HG::Rendering::Runtime::MotionBlurPassConstructor::_ConstructPass_b__21_0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v211,
			//           v188,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::MotionBlurPassConstructor::MotionBlurPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v215 )
			//       {
			//         v212[0] = v215.ex;
			//         sub_180222690(v212);
			//         v97 = (MotionBlurPassConstructor_PassOutput)sceneColor;
			//         goto LABEL_151;
			//       }
			//       sub_180222690(v212);
			// LABEL_151:
			//       *output = v97;
			//     }
			//     else
			//     {
			// LABEL_152:
			//       HG::Rendering::Runtime::MotionBlurPassConstructor::Reset(this, 0LL);
			//       *output = (MotionBlurPassConstructor_PassOutput)input.sceneColor;
			//     }
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::MotionBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         MotionBlurPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   TextureHandle__Array *v6; // rcx
			//   int32_t i; // esi
			//   TextureHandle__Array *m_historyTextures; // rax
			//   TextureHandle__Array *v9; // rbx
			//   TextureHandle *v10; // rax
			//   TextureHandle__Array *v11; // r15
			//   HGRenderGraph *renderGraph; // r14
			//   TextureHandle *v13; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   TextureHandle v15; // [rsp+30h] [rbp-38h] BYREF
			//   TextureHandle v16; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91958F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D500CE0);
			//     byte_18D91958F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2726, 0LL) )
			//   {
			//     if ( input.passSkipped )
			//       HG::Rendering::Runtime::MotionBlurPassConstructor::Reset(this, 0LL);
			//     for ( i = 0; ; ++i )
			//     {
			//       m_historyTextures = this.fields.m_historyTextures;
			//       if ( !m_historyTextures )
			//         break;
			//       if ( i >= m_historyTextures.max_length.size )
			//         return;
			//       v9 = this.fields.m_historyTextures;
			//       sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//       v10 = (TextureHandle *)sub_18037A2E0(v9, i);
			//       if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(v10, 0LL) )
			//       {
			//         v11 = this.fields.m_historyTextures;
			//         v6 = v11;
			//         if ( !v11 )
			//           break;
			//         renderGraph = input.renderGraph;
			//         if ( !renderGraph )
			//           break;
			//         v13 = (TextureHandle *)sub_18037A2E0(v11, i);
			//         v15 = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
			//                  &v16,
			//                  renderGraph,
			//                  v13,
			//                  1,
			//                  (String *)"MotionBlurPass",
			//                  0LL);
			//         sub_1803EF6F4(v11, i, &v15);
			//       }
			//     }
			// LABEL_15:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2726, 0LL);
			//   if ( !Patch )
			//     goto LABEL_15;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph renderGraph)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
			// void HG::Rendering::Runtime::MotionBlurPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         MotionBlurPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2727, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2727, 0LL);
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

		public uint frameIndex;

		private const uint FRAME_MOD = 5U;

		private const int PARAMETERS_FLOAT_NUM = 16;

		private int m_packingKernel;

		private int m_tileMaxKernel;

		private int m_tileNeighborKernel;

		private int m_motionBlurKernel;

		private int m_blendMotionBlurKernel;

		private float[] m_parameters;

		private float[] m_historyTimes;

		private Vector2Int m_historyScreenSize;

		private TextureHandle[] m_historyTextures;

		private CBHandle m_cb;

		private ComputeShader m_motionBlurCS;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal TextureHandle sceneColor;

			internal TextureHandle sceneDepth;

			internal TextureHandle sceneMV;

			internal HGSettingParameters settingParameters;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PassOutput
		{
			internal TextureHandle result;
		}

		private class MotionBlurPassData
		{
			public MotionBlurPassData()
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

			public int packKernel;

			public int tileMaxKernel;

			public int tileNeighborKernel;

			public int motionBlurKernel;

			public int blendMotionBlurKernel;

			public int packingThreadX;

			public int packingThreadY;

			public int tileMaxThreadX;

			public int tileMaxThreadY;

			public int tileNeighborThreadX;

			public int tileNeighborThreadY;

			public int motionBlurThreadX;

			public int motionBlurThreadY;

			public uint frameIndex;

			public float blendFrame;

			public float[] historyWeights;

			public float[] parameters;

			public TextureHandle currSceneColorTexture;

			public TextureHandle currSceneDepthTexture;

			public TextureHandle currMVTexture;

			public TextureHandle packingTexture;

			public TextureHandle tileMaxTexture;

			public TextureHandle tileNeighborTexture;

			public TextureHandle motionBlurTexture;

			public TextureHandle blendMotionBlurTexture;

			public TextureHandle[] historyMotionBlurTextures;

			public ComputeShader computeShader;

			public TextureHandle debugTexture0;
		}
	}
}
