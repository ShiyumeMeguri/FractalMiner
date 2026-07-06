using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using Unity.Profiling;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class ShadowMapPassConstructor : IPassConstructor
	{
		public ShadowMapPassConstructor()
		{
			// // ShadowMapPassConstructor()
			// void HG::Rendering::Runtime::ShadowMapPassConstructor::ShadowMapPassConstructor(
			//         ShadowMapPassConstructor *this,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D8EDD13 )
			//   {
			//     sub_18003C530(&off_18C9BC680);
			//     sub_18003C530(&off_18C9BC6A8);
			//     sub_18003C530(&off_18C9BC6A0);
			//     sub_18003C530(&off_18C9BC698);
			//     byte_18D8EDD13 = 1;
			//   }
			//   this.fields.m_samplerCSM.m_Ptr = Unity::Profiling::LowLevel::Unsafe::ProfilerUnsafeUtility::CreateMarker(
			//                                       (String *)"ShadowMap.CSM",
			//                                       1u,
			//                                       MarkerFlags__Enum_Default,
			//                                       0,
			//                                       0LL);
			//   this.fields.m_samplerCharacter.m_Ptr = Unity::Profiling::LowLevel::Unsafe::ProfilerUnsafeUtility::CreateMarker(
			//                                             (String *)"ShadowMap.Character",
			//                                             1u,
			//                                             MarkerFlags__Enum_Default,
			//                                             0,
			//                                             0LL);
			//   this.fields.m_samplerASM.m_Ptr = Unity::Profiling::LowLevel::Unsafe::ProfilerUnsafeUtility::CreateMarker(
			//                                       (String *)"ShadowMap.ASM",
			//                                       1u,
			//                                       MarkerFlags__Enum_Default,
			//                                       0,
			//                                       0LL);
			//   this.fields.m_samplerPunctual.m_Ptr = Unity::Profiling::LowLevel::Unsafe::ProfilerUnsafeUtility::CreateMarker(
			//                                            (String *)"ShadowMap.Punctual",
			//                                            1u,
			//                                            MarkerFlags__Enum_Default,
			//                                            0,
			//                                            0LL);
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::ShadowMapPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
			//         ShadowMapPassConstructor *this,
			//         ShaderVariablesGlobal *shaderVariablesGlobal,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1870, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1870, 0LL);
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
			// void HG::Rendering::Runtime::ShadowMapPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
			//         ShadowMapPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1871, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1871, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_634(Patch, (Object *)this, input, 0LL);
			//   }
			// }
			// 
		}

		internal void ConstructPass(ref ShadowMapPassConstructor.PassInput input, ref ShadowMapPassConstructor.PassOutput output, HGRenderGraph renderGraph, HGCamera camera)
		{
			// // Void ConstructPass(ShadowMapPassConstructor+PassInput ByRef, ShadowMapPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
			// // Hidden C++ exception states: #wind=4 #try_helpers=1
			// void HG::Rendering::Runtime::ShadowMapPassConstructor::ConstructPass(
			//         ShadowMapPassConstructor *this,
			//         ShadowMapPassConstructor_PassInput *input,
			//         ShadowMapPassConstructor_PassOutput *output,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   Object *v6; // r12
			//   ShadowMapPassConstructor_PassInput *v7; // rsi
			//   ShadowMapPassConstructor *v8; // r13
			//   HGShadowManager *shadowManager; // r14
			//   HGSettingParameters *settingParams; // r15
			//   ScriptableRenderContext v11; // rbx
			//   MethodInfo *v12; // rdx
			//   ProfilerMarker_AutoScope v13; // rdx
			//   ProfilerMarker_AutoScope v14; // rcx
			//   HGCamera *v15; // rbx
			//   int32_t directionalLightIndex; // ecx
			//   MethodInfo *v17; // rdx
			//   ProfilerMarker_AutoScope v18; // rdx
			//   ProfilerMarker_AutoScope v19; // rcx
			//   int32_t v20; // eax
			//   MethodInfo *v21; // rdx
			//   ProfilerMarker_AutoScope v22; // rdx
			//   ProfilerMarker_AutoScope v23; // rcx
			//   HGPunctualLightShadowManagerV2 *m_punctualLightShadowManagerV2; // rcx
			//   MethodInfo *v25; // rdx
			//   ProfilerMarker_AutoScope v26; // rdx
			//   ProfilerMarker_AutoScope v27; // rcx
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   HGEnvironmentPhase *InterpolatedPhase; // rax
			//   Camera *v31; // r14
			//   HGASMManager *v32; // rax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   HGASMManager *v35; // r14
			//   Camera *v36; // rsi
			//   Camera *v37; // rsi
			//   HGASMManager *CachedASMManager; // rax
			//   HGASMManager *v39; // rsi
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   Component *v42; // r14
			//   Transform *transform; // rax
			//   __int64 v44; // rdx
			//   __int64 v45; // rcx
			//   Vector3 *position; // rax
			//   __int64 v47; // rdx
			//   __int64 v48; // rcx
			//   __int64 v49; // xmm10_8
			//   float z; // r15d
			//   void (__fastcall *v51)(Matrix4x4 *, __int128 *); // rax
			//   __int128 v52; // xmm11
			//   __int128 v53; // xmm12
			//   __int128 v54; // xmm13
			//   __int128 v55; // xmm14
			//   void (__fastcall *v56)(Component *); // rax
			//   double v57; // xmm0_8
			//   float v58; // xmm9_4
			//   void (__fastcall *v59)(Component *); // rax
			//   __int64 v60; // rdx
			//   __int64 v61; // rcx
			//   __int64 v62; // r8
			//   __int64 v63; // r9
			//   void (__fastcall *v64)(Component *); // rax
			//   __int64 (__fastcall *v65)(Component *); // rax
			//   int v66; // eax
			//   Beyond::DampingMath *v67; // rcx
			//   double v68; // xmm0_8
			//   float v69; // xmm7_4
			//   __m128i si128; // xmm8
			//   float s_asmCacheRadius; // xmm6_4
			//   float v72; // xmm0_4
			//   Vector3__Array *m_frustumCorners; // rax
			//   double (__fastcall *v74)(Component *); // rax
			//   double v75; // xmm0_8
			//   Vector3__Array *m_frustumCornersForIndirect; // rax
			//   Vector3 *v77; // rcx
			//   float v78; // eax
			//   __int64 v79; // rdx
			//   __int64 v80; // rcx
			//   Transform *v81; // rbx
			//   void (__fastcall *v82)(Transform *, Vector4 *); // rax
			//   void (__fastcall *v83)(Vector3 *, Vector4 *, Vector3 *, __int128 *); // rax
			//   Vector3__Array *v84; // rdx
			//   Vector2__Array *v85; // rcx
			//   __int64 v86; // r8
			//   __int64 v87; // r9
			//   __int128 v88; // xmm6
			//   __int128 v89; // xmm7
			//   __int128 v90; // xmm8
			//   __int128 v91; // xmm9
			//   Vector2__Array *m_frustumVerts; // rax
			//   float y; // xmm1_4
			//   Vector2__Array *m_frustumVertsForIndirect; // rax
			//   float v95; // xmm1_4
			//   int i; // ebx
			//   Vector3__Array *v97; // r14
			//   float v98; // xmm1_4
			//   float v99; // xmm0_4
			//   Vector3 *v100; // rax
			//   __int64 v101; // rdx
			//   __int64 v102; // r8
			//   __int64 v103; // r9
			//   __int64 v104; // rcx
			//   Vector3__Array *m_frustumCornersLightSpace; // r14
			//   Vector3__Array *v106; // rcx
			//   float v107; // xmm1_4
			//   float v108; // xmm0_4
			//   Vector3 *v109; // rax
			//   __int64 v110; // rdx
			//   __int64 v111; // rcx
			//   __int64 v112; // r8
			//   __int64 v113; // r9
			//   __int64 v114; // rcx
			//   Vector2__Array *v115; // rcx
			//   Vector3__Array *v116; // rdx
			//   float v117; // xmm0_4
			//   __int64 v118; // rax
			//   Vector3__Array *v119; // r14
			//   float v120; // xmm1_4
			//   float v121; // xmm0_4
			//   Vector3 *v122; // rax
			//   __int64 v123; // rdx
			//   __int64 v124; // r8
			//   __int64 v125; // r9
			//   __int64 v126; // rcx
			//   Vector3__Array *m_frustumCornersLightSpaceForIndirect; // r14
			//   Vector3__Array *v128; // rcx
			//   float v129; // xmm1_4
			//   float v130; // xmm0_4
			//   Vector3 *v131; // rax
			//   __int64 v132; // rdx
			//   __int64 v133; // rcx
			//   __int64 v134; // rcx
			//   float v135; // xmm0_4
			//   __int64 v136; // rax
			//   ASMTileManager *m_asmTileManager; // rcx
			//   ILFixDynamicMethodWrapper_2 *v138; // rax
			//   __int64 v139; // rdx
			//   __int64 v140; // rcx
			//   Camera *v141; // rbx
			//   HGASMManager *ASMManager; // rax
			//   __int64 v143; // rdx
			//   __int64 v144; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v146; // rdx
			//   __int64 v147; // rcx
			//   bool shouldRenderCSMShadowMap; // [rsp+50h] [rbp-2A8h] BYREF
			//   Vector4 lightCullResult; // [rsp+60h] [rbp-298h] BYREF
			//   Il2CppException *ex; // [rsp+70h] [rbp-288h] BYREF
			//   _QWORD *v151; // [rsp+78h] [rbp-280h]
			//   Vector3 v152; // [rsp+80h] [rbp-278h] BYREF
			//   Vector4 v153; // [rsp+90h] [rbp-268h] BYREF
			//   _QWORD v154[2]; // [rsp+A0h] [rbp-258h] BYREF
			//   Vector3 v155; // [rsp+B0h] [rbp-248h] BYREF
			//   Vector4 cullingResults; // [rsp+C0h] [rbp-238h] BYREF
			//   Matrix4x4 m_lightToWorld; // [rsp+D0h] [rbp-228h] BYREF
			//   Vector4 v158; // [rsp+110h] [rbp-1E8h] BYREF
			//   Vector4 v159; // [rsp+120h] [rbp-1D8h]
			//   Vector4 v160; // [rsp+130h] [rbp-1C8h]
			//   ShadowResult shadowResult; // [rsp+140h] [rbp-1B8h] BYREF
			//   __int128 v162; // [rsp+180h] [rbp-178h] BYREF
			//   __int128 v163; // [rsp+190h] [rbp-168h]
			//   __int128 v164; // [rsp+1A0h] [rbp-158h]
			//   __int128 v165; // [rsp+1B0h] [rbp-148h]
			//   Vector3 v166; // [rsp+1C0h] [rbp-138h] BYREF
			//   Il2CppExceptionWrapper *v167; // [rsp+1D0h] [rbp-128h] BYREF
			//   Il2CppExceptionWrapper *v168; // [rsp+1D8h] [rbp-120h] BYREF
			//   Il2CppExceptionWrapper *v169; // [rsp+1E0h] [rbp-118h] BYREF
			//   Vector4 v170; // [rsp+1F0h] [rbp-108h] BYREF
			//   Vector4 v171; // [rsp+200h] [rbp-F8h] BYREF
			//   Vector4 v172; // [rsp+210h] [rbp-E8h] BYREF
			//   Vector4 v173; // [rsp+220h] [rbp-D8h] BYREF
			// 
			//   v6 = (Object *)renderGraph;
			//   v7 = input;
			//   v8 = this;
			//   if ( !byte_18D919EBB )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D919EBB = 1;
			//   }
			//   shouldRenderCSMShadowMap = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1872, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1872, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v147, v146);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_726(Patch, (Object *)v8, v7, output, v6, (Object *)camera, 0LL);
			//   }
			//   else
			//   {
			//     shadowManager = v7.shadowManager;
			//     *(_QWORD *)&v152.x = v7.shadowManager;
			//     settingParams = v7.settingParams;
			//     *(_QWORD *)&v155.x = settingParams;
			//     v11.m_Ptr = v7.srpContext.m_Ptr;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     HG::Rendering::Runtime::HGShadowConstantBufferUtils::AllocateShadowBuffer(v11, 0LL);
			//     memset(&shadowResult, 0, sizeof(shadowResult));
			//     v154[0] = Unity::Profiling::ProfilerMarker::Auto(&v8.fields.m_samplerCSM, v12).m_Ptr;
			//     ex = 0LL;
			//     v151 = v154;
			//     try
			//     {
			//       if ( !shadowManager )
			//         sub_1802DC2C8(v14.m_Ptr, v13.m_Ptr);
			//       v15 = camera;
			//       HG::Rendering::Runtime::HGShadowManager::FrameSetup(shadowManager, v7, &shouldRenderCSMShadowMap, camera, 0LL);
			//       HG::Rendering::Runtime::HGShadowManager::ConfigureDirectionalShadowMapTextures(
			//         shadowManager,
			//         settingParams,
			//         camera,
			//         shouldRenderCSMShadowMap,
			//         0LL);
			//       directionalLightIndex = v7.directionalLightIndex;
			//       lightCullResult = (Vector4)v7.lightCullResult;
			//       cullingResults = (Vector4)v7.cullingResults;
			//       HG::Rendering::Runtime::HGShadowManager::RenderShadows(
			//         shadowManager,
			//         (HGRenderGraph *)v6,
			//         camera,
			//         (CullingResults *)&cullingResults,
			//         (LightCullResult *)&lightCullResult,
			//         directionalLightIndex,
			//         shouldRenderCSMShadowMap,
			//         &shadowResult,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v167 )
			//     {
			//       ex = v167.ex;
			//       sub_1801F7AA0(&ex);
			//       v15 = camera;
			//       v6 = (Object *)renderGraph;
			//       v7 = input;
			//       v8 = this;
			//       shadowManager = *(HGShadowManager **)&v152.x;
			//       settingParams = *(HGSettingParameters **)&v155.x;
			//       goto LABEL_8;
			//     }
			//     sub_1801F7AA0(&ex);
			// LABEL_8:
			//     v154[0] = Unity::Profiling::ProfilerMarker::Auto(&v8.fields.m_samplerCharacter, v17).m_Ptr;
			//     ex = 0LL;
			//     v151 = v154;
			//     try
			//     {
			//       if ( !shadowManager )
			//         sub_1802DC2C8(v19.m_Ptr, v18.m_Ptr);
			//       HG::Rendering::Runtime::HGShadowManager::CharacterShadowFrameSetup(shadowManager, settingParams, 0LL);
			//       v20 = v7.directionalLightIndex;
			//       lightCullResult = (Vector4)v7.lightCullResult;
			//       cullingResults = (Vector4)v7.cullingResults;
			//       HG::Rendering::Runtime::HGShadowManager::RenderCharacterShadows(
			//         shadowManager,
			//         (HGRenderGraph *)v6,
			//         v15,
			//         (CullingResults *)&cullingResults,
			//         (LightCullResult *)&lightCullResult,
			//         v20,
			//         &shadowResult,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v168 )
			//     {
			//       ex = v168.ex;
			//       sub_1801F7AA0(&ex);
			//       v15 = camera;
			//       v6 = (Object *)renderGraph;
			//       v7 = input;
			//       v8 = this;
			//       settingParams = *(HGSettingParameters **)&v155.x;
			//       goto LABEL_12;
			//     }
			//     sub_1801F7AA0(&ex);
			// LABEL_12:
			//     v154[0] = Unity::Profiling::ProfilerMarker::Auto(&v8.fields.m_samplerPunctual, v21).m_Ptr;
			//     ex = 0LL;
			//     v151 = v154;
			//     try
			//     {
			//       if ( !v7.shadowManager )
			//         sub_1802DC2C8(v23.m_Ptr, v22.m_Ptr);
			//       m_punctualLightShadowManagerV2 = v7.shadowManager.fields.m_punctualLightShadowManagerV2;
			//       if ( !m_punctualLightShadowManagerV2 )
			//         sub_1802DC2C8(0LL, v22.m_Ptr);
			//       HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::RenderPunctualLightShadows(
			//         m_punctualLightShadowManagerV2,
			//         (HGRenderGraph *)v6,
			//         v15,
			//         settingParams,
			//         &shadowResult,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v169 )
			//     {
			//       ex = v169.ex;
			//       sub_1801F7AA0(&ex);
			//       v15 = camera;
			//       v6 = (Object *)renderGraph;
			//       v7 = input;
			//       v8 = this;
			//       settingParams = *(HGSettingParameters **)&v155.x;
			//       goto LABEL_17;
			//     }
			//     sub_1801F7AA0(&ex);
			// LABEL_17:
			//     v154[0] = Unity::Profiling::ProfilerMarker::Auto(&v8.fields.m_samplerASM, v25).m_Ptr;
			//     ex = 0LL;
			//     v151 = v154;
			//     if ( !settingParams )
			//       sub_1802DC2C8(v27.m_Ptr, v26.m_Ptr);
			//     if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//             settingParams.fields._asmEnabled_k__BackingField,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//       goto LABEL_89;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(v15, 0LL);
			//     if ( !InterpolatedPhase )
			//       sub_1802DC2C8(v29, v28);
			//     if ( InterpolatedPhase.fields.shadowConfig.disableAsm )
			//     {
			// LABEL_89:
			//       if ( !v15 )
			//         sub_1802DC2C8(v29, v28);
			//       v141 = v15.fields.camera;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//       ASMManager = HG::Rendering::Runtime::HGASMManager::GetASMManager(v141, 0LL);
			//       if ( !ASMManager )
			//         sub_1802DC2C8(v144, v143);
			//       HG::Rendering::Runtime::HGASMManager::SkipRenderASM(ASMManager, (HGRenderGraph *)v6, 0LL);
			//       sub_1801F7AA0(&ex);
			//     }
			//     else
			//     {
			//       if ( !v15 )
			//         sub_1802DC2C8(v29, v28);
			//       v31 = v15.fields.camera;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//       v32 = HG::Rendering::Runtime::HGASMManager::GetASMManager(v31, 0LL);
			//       v35 = v32;
			//       if ( !v32 )
			//         sub_1802DC2C8(v34, v33);
			//       HG::Rendering::Runtime::HGASMManager::BeginFrame(v32, v15, settingParams, 0LL);
			//       HG::Rendering::Runtime::HGASMManager::Render(v35, (HGRenderGraph *)v6, v7.srpContext, v15, 0LL);
			//       if ( v35.fields.shouldSwapManagers )
			//       {
			//         v36 = v15.fields.camera;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//         HG::Rendering::Runtime::HGASMManager::SwapASMManager(v36, 0LL);
			//       }
			//       v37 = v15.fields.camera;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//       CachedASMManager = HG::Rendering::Runtime::HGASMManager::GetCachedASMManager(v37, 0LL);
			//       v39 = v35;
			//       if ( CachedASMManager )
			//         v39 = CachedASMManager;
			//       if ( HG::Rendering::Runtime::HGASMManager::GetASMUpdateMode(v35, 0LL) == HGASMManager_ASMUpdateMode__Enum_Slow
			//         || HG::Rendering::Runtime::HGASMManager::GetASMUpdateMode(v35, 0LL) == HGASMManager_ASMUpdateMode__Enum_Stop )
			//       {
			//         if ( v39 == v35 )
			//         {
			//           if ( !v39 )
			//             sub_1802DC2C8(v41, v40);
			//         }
			//         else
			//         {
			//           v42 = (Component *)v15.fields.camera;
			//           if ( !v42 )
			//             sub_1802DC2C8(0LL, v40);
			//           transform = UnityEngine::Component::get_transform(v42, 0LL);
			//           if ( !transform )
			//             sub_1802DC2C8(v45, v44);
			//           position = UnityEngine::Transform::get_position(&v155, transform, 0LL);
			//           if ( !v39 )
			//             sub_1802DC2C8(v48, v47);
			//           v49 = *(_QWORD *)&position.x;
			//           *(_QWORD *)&v152.x = *(_QWORD *)&position.x;
			//           z = position.z;
			//           if ( !byte_18D919E5F )
			//           {
			//             sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//             byte_18D919E5F = 1;
			//           }
			//           if ( IFix::WrappersManagerImpl::IsPatched(1754, 0LL) )
			//           {
			//             v138 = IFix::WrappersManagerImpl::GetPatch(1754, 0LL);
			//             if ( !v138 )
			//               sub_1802DC2C8(v140, v139);
			//             *(_QWORD *)&v152.x = v49;
			//             v152.z = z;
			//             IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_679(v138, (Object *)v39, (Object *)v42, &v152, 0LL);
			//           }
			//           else
			//           {
			//             m_lightToWorld = v39.fields.m_lightToWorld;
			//             sub_1802F01E0(&v162, 0LL, 64LL);
			//             v51 = (void (__fastcall *)(Matrix4x4 *, __int128 *))qword_18D8F4BD0;
			//             if ( !qword_18D8F4BD0 )
			//             {
			//               v51 = (void (__fastcall *)(Matrix4x4 *, __int128 *))sub_180017470(
			//                                                                     "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine."
			//                                                                     "Matrix4x4&,UnityEngine.Matrix4x4&)");
			//               qword_18D8F4BD0 = (__int64)v51;
			//             }
			//             v51(&m_lightToWorld, &v162);
			//             v52 = v162;
			//             v53 = v163;
			//             v54 = v164;
			//             v55 = v165;
			//             v56 = (void (__fastcall *)(Component *))qword_18D8F4198;
			//             if ( !qword_18D8F4198 )
			//             {
			//               v56 = (void (__fastcall *)(Component *))sub_180017470("UnityEngine.Camera::get_fieldOfView()");
			//               qword_18D8F4198 = (__int64)v56;
			//             }
			//             v56(v42);
			//             v57 = Beyond::DampingMath::cosf();
			//             v58 = *(float *)&v57;
			//             v59 = (void (__fastcall *)(Component *))qword_18D8F4198;
			//             if ( !qword_18D8F4198 )
			//             {
			//               v59 = (void (__fastcall *)(Component *))sub_180017470("UnityEngine.Camera::get_fieldOfView()");
			//               qword_18D8F4198 = (__int64)v59;
			//             }
			//             v59(v42);
			//             sub_1802ED290(v61, v60, v62, v63);
			//             v64 = (void (__fastcall *)(Component *))qword_18D8F4248;
			//             if ( !qword_18D8F4248 )
			//             {
			//               v64 = (void (__fastcall *)(Component *))sub_180017470("UnityEngine.Camera::get_pixelWidth()");
			//               qword_18D8F4248 = (__int64)v64;
			//             }
			//             v64(v42);
			//             v65 = (__int64 (__fastcall *)(Component *))qword_18D8F4250;
			//             if ( !qword_18D8F4250 )
			//             {
			//               v65 = (__int64 (__fastcall *)(Component *))sub_180017470("UnityEngine.Camera::get_pixelHeight()");
			//               qword_18D8F4250 = (__int64)v65;
			//             }
			//             v66 = v65(v42);
			//             Beyond::DampingMath::fast_atan(v67, (float)v66);
			//             v68 = Beyond::DampingMath::cosf();
			//             v69 = *(float *)&v68;
			//             si128 = _mm_load_si128((const __m128i *)&xmmword_18A357450);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGASMManager);
			//             s_asmCacheRadius = TypeInfo::HG::Rendering::Runtime::HGASMManager.static_fields.s_asmCacheRadius;
			//             v72 = UnityEngine::Mathf::Min(v58, v69, 0LL);
			//             m_frustumCorners = v39.fields.m_frustumCorners;
			//             lightCullResult = (Vector4)si128;
			//             UnityEngine::Camera::CalculateFrustumCorners(
			//               (Camera *)v42,
			//               (Rect *)&lightCullResult,
			//               v72 * s_asmCacheRadius,
			//               Camera_MonoOrStereoscopicEye__Enum_Mono,
			//               m_frustumCorners,
			//               0LL);
			//             v74 = (double (__fastcall *)(Component *))qword_18D8F4188;
			//             if ( !qword_18D8F4188 )
			//             {
			//               v74 = (double (__fastcall *)(Component *))sub_180017470("UnityEngine.Camera::get_farClipPlane()");
			//               qword_18D8F4188 = (__int64)v74;
			//             }
			//             v75 = v74(v42);
			//             m_frustumCornersForIndirect = v39.fields.m_frustumCornersForIndirect;
			//             lightCullResult = (Vector4)si128;
			//             UnityEngine::Camera::CalculateFrustumCorners(
			//               (Camera *)v42,
			//               (Rect *)&lightCullResult,
			//               *(float *)&v75,
			//               Camera_MonoOrStereoscopicEye__Enum_Mono,
			//               m_frustumCornersForIndirect,
			//               0LL);
			//             *(_QWORD *)&v158.x = *(_QWORD *)&v152.x;
			//             *(_QWORD *)&v158.z = LODWORD(z) | 0x3F80000000000000LL;
			//             lightCullResult = v158;
			//             *(_OWORD *)&m_lightToWorld.m00 = v52;
			//             *(_OWORD *)&m_lightToWorld.m01 = v53;
			//             *(_OWORD *)&m_lightToWorld.m02 = v54;
			//             *(_OWORD *)&m_lightToWorld.m03 = v55;
			//             lightCullResult = *UnityEngine::Matrix4x4::op_Multiply(&v153, &m_lightToWorld, &lightCullResult, 0LL);
			//             v77 = UnityEngine::Vector4::op_Implicit(&v152, &lightCullResult, 0LL);
			//             v78 = v77.z;
			//             *(_QWORD *)&v39.fields.m_cameraPosLightSpace.x = *(_QWORD *)&v77.x;
			//             v39.fields.m_cameraPosLightSpace.z = v78;
			//             v81 = UnityEngine::Component::get_transform(v42, 0LL);
			//             if ( !v81 )
			//               sub_1802DC2C8(v80, v79);
			//             lightCullResult = 0LL;
			//             v82 = (void (__fastcall *)(Transform *, Vector4 *))qword_18D8F5310;
			//             if ( !qword_18D8F5310 )
			//             {
			//               v82 = (void (__fastcall *)(Transform *, Vector4 *))sub_180017470(
			//                                                                    "UnityEngine.Transform::get_localRotation_Injected(Uni"
			//                                                                    "tyEngine.Quaternion&)");
			//               qword_18D8F5310 = (__int64)v82;
			//             }
			//             v82(v81, &lightCullResult);
			//             v152 = *UnityEngine::Vector3::get_one(&v166, 0LL);
			//             *(_QWORD *)&v155.x = v49;
			//             v155.z = z;
			//             sub_1802F01E0(&v162, 0LL, 64LL);
			//             v83 = (void (__fastcall *)(Vector3 *, Vector4 *, Vector3 *, __int128 *))qword_18D8F4BC8;
			//             if ( !qword_18D8F4BC8 )
			//             {
			//               v83 = (void (__fastcall *)(Vector3 *, Vector4 *, Vector3 *, __int128 *))sub_180017470(
			//                                                                                         "UnityEngine.Matrix4x4::TRS_Injec"
			//                                                                                         "ted(UnityEngine.Vector3&,UnityEn"
			//                                                                                         "gine.Quaternion&,UnityEngine.Vec"
			//                                                                                         "tor3&,UnityEngine.Matrix4x4&)");
			//               qword_18D8F4BC8 = (__int64)v83;
			//             }
			//             v83(&v155, &lightCullResult, &v152, &v162);
			//             v88 = v162;
			//             v89 = v163;
			//             v90 = v164;
			//             v91 = v165;
			//             m_frustumVerts = v39.fields.m_frustumVerts;
			//             y = v39.fields.m_cameraPosLightSpace.y;
			//             if ( !m_frustumVerts )
			//               sub_1802DC2C8(v85, v84);
			//             if ( !m_frustumVerts.max_length.size )
			//               sub_180070260(v85, v84, v86, v87);
			//             m_frustumVerts.vector[0].x = v39.fields.m_cameraPosLightSpace.x;
			//             m_frustumVerts.vector[0].y = y;
			//             m_frustumVertsForIndirect = v39.fields.m_frustumVertsForIndirect;
			//             v95 = v39.fields.m_cameraPosLightSpace.y;
			//             if ( !m_frustumVertsForIndirect )
			//               sub_1802DC2C8(v85, v84);
			//             if ( !m_frustumVertsForIndirect.max_length.size )
			//               sub_180070260(v85, v84, v86, v87);
			//             m_frustumVertsForIndirect.vector[0].x = v39.fields.m_cameraPosLightSpace.x;
			//             m_frustumVertsForIndirect.vector[0].y = v95;
			//             for ( i = 0; i < 4; ++i )
			//             {
			//               v97 = v39.fields.m_frustumCorners;
			//               if ( !v97 )
			//                 sub_1802DC2C8(v85, v84);
			//               if ( (unsigned int)i >= v97.max_length.size )
			//                 sub_180070260(v85, v84, v86, v87);
			//               v98 = v97.vector[i].y;
			//               v99 = v97.vector[i].z;
			//               v159.x = v97.vector[i].x;
			//               *(_QWORD *)&v159.y = __PAIR64__(LODWORD(v99), LODWORD(v98));
			//               v159.w = 1.0;
			//               v153 = v159;
			//               *(_OWORD *)&m_lightToWorld.m00 = v88;
			//               *(_OWORD *)&m_lightToWorld.m01 = v89;
			//               *(_OWORD *)&m_lightToWorld.m02 = v90;
			//               *(_OWORD *)&m_lightToWorld.m03 = v91;
			//               v153 = *UnityEngine::Matrix4x4::op_Multiply(&v170, &m_lightToWorld, &v153, 0LL);
			//               v100 = UnityEngine::Vector4::op_Implicit(&v166, &v153, 0LL);
			//               if ( (unsigned int)i >= v97.max_length.size )
			//                 sub_180070260(i, v101, v102, v103);
			//               v104 = i;
			//               *(_QWORD *)&v97.vector[v104].x = *(_QWORD *)&v100.x;
			//               v97.vector[v104].z = v100.z;
			//               m_frustumCornersLightSpace = v39.fields.m_frustumCornersLightSpace;
			//               v106 = v39.fields.m_frustumCorners;
			//               if ( !v106 )
			//                 sub_1802DC2C8(0LL, v101);
			//               if ( (unsigned int)i >= v106.max_length.size )
			//                 sub_180070260(v106, v101, v102, v103);
			//               v107 = v106.vector[i].y;
			//               v108 = v106.vector[i].z;
			//               v160.x = v106.vector[i].x;
			//               *(_QWORD *)&v160.y = __PAIR64__(LODWORD(v108), LODWORD(v107));
			//               v160.w = 1.0;
			//               v153 = v160;
			//               *(_OWORD *)&m_lightToWorld.m00 = v52;
			//               *(_OWORD *)&m_lightToWorld.m01 = v53;
			//               *(_OWORD *)&m_lightToWorld.m02 = v54;
			//               *(_OWORD *)&m_lightToWorld.m03 = v55;
			//               v153 = *UnityEngine::Matrix4x4::op_Multiply(&v171, &m_lightToWorld, &v153, 0LL);
			//               v109 = UnityEngine::Vector4::op_Implicit(&v152, &v153, 0LL);
			//               if ( !m_frustumCornersLightSpace )
			//                 sub_1802DC2C8(v111, v110);
			//               if ( (unsigned int)i >= m_frustumCornersLightSpace.max_length.size )
			//                 sub_180070260(i, v110, v112, v113);
			//               v114 = i;
			//               *(_QWORD *)&m_frustumCornersLightSpace.vector[v114].x = *(_QWORD *)&v109.x;
			//               m_frustumCornersLightSpace.vector[v114].z = v109.z;
			//               v115 = v39.fields.m_frustumVerts;
			//               v116 = v39.fields.m_frustumCornersLightSpace;
			//               if ( !v116 )
			//                 sub_1802DC2C8(v115, 0LL);
			//               if ( (unsigned int)i >= v116.max_length.size )
			//                 sub_180070260(v115, v116, v112, v113);
			//               v117 = v116.vector[i].y;
			//               if ( !v115 )
			//                 sub_1802DC2C8(0LL, v116);
			//               v118 = i + 1LL;
			//               if ( (unsigned int)v118 >= v115.max_length.size )
			//                 sub_180070260(v115, v116, v112, v113);
			//               v115.vector[v118].x = v116.vector[i].x;
			//               v115.vector[v118].y = v117;
			//               v119 = v39.fields.m_frustumCornersForIndirect;
			//               if ( !v119 )
			//                 sub_1802DC2C8(v115, v116);
			//               if ( (unsigned int)i >= v119.max_length.size )
			//                 sub_180070260(v115, v116, v112, v113);
			//               v120 = v119.vector[i].y;
			//               v121 = v119.vector[i].z;
			//               cullingResults.x = v119.vector[i].x;
			//               cullingResults.y = v120;
			//               *(_QWORD *)&cullingResults.z = LODWORD(v121) | 0x3F80000000000000LL;
			//               v153 = cullingResults;
			//               *(_OWORD *)&m_lightToWorld.m00 = v88;
			//               *(_OWORD *)&m_lightToWorld.m01 = v89;
			//               *(_OWORD *)&m_lightToWorld.m02 = v90;
			//               *(_OWORD *)&m_lightToWorld.m03 = v91;
			//               v153 = *UnityEngine::Matrix4x4::op_Multiply(&v172, &m_lightToWorld, &v153, 0LL);
			//               v122 = UnityEngine::Vector4::op_Implicit(&v155, &v153, 0LL);
			//               if ( (unsigned int)i >= v119.max_length.size )
			//                 sub_180070260(i, v123, v124, v125);
			//               v126 = i;
			//               *(_QWORD *)&v119.vector[v126].x = *(_QWORD *)&v122.x;
			//               v119.vector[v126].z = v122.z;
			//               m_frustumCornersLightSpaceForIndirect = v39.fields.m_frustumCornersLightSpaceForIndirect;
			//               v128 = v39.fields.m_frustumCornersForIndirect;
			//               if ( !v128 )
			//                 sub_1802DC2C8(0LL, v123);
			//               if ( (unsigned int)i >= v128.max_length.size )
			//                 sub_180070260(v128, v123, v124, v125);
			//               v129 = v128.vector[i].y;
			//               v130 = v128.vector[i].z;
			//               lightCullResult.x = v128.vector[i].x;
			//               lightCullResult.y = v129;
			//               lightCullResult.z = v130;
			//               lightCullResult.w = 1.0;
			//               v153 = lightCullResult;
			//               *(_OWORD *)&m_lightToWorld.m00 = v52;
			//               *(_OWORD *)&m_lightToWorld.m01 = v53;
			//               *(_OWORD *)&m_lightToWorld.m02 = v54;
			//               *(_OWORD *)&m_lightToWorld.m03 = v55;
			//               v153 = *UnityEngine::Matrix4x4::op_Multiply(&v173, &m_lightToWorld, &v153, 0LL);
			//               v131 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v158, &v153, 0LL);
			//               if ( !m_frustumCornersLightSpaceForIndirect )
			//                 sub_1802DC2C8(v133, v132);
			//               if ( (unsigned int)i >= m_frustumCornersLightSpaceForIndirect.max_length.size )
			//                 sub_180070260(i, v132, v86, v87);
			//               v134 = i;
			//               *(_QWORD *)&m_frustumCornersLightSpaceForIndirect.vector[v134].x = *(_QWORD *)&v131.x;
			//               m_frustumCornersLightSpaceForIndirect.vector[v134].z = v131.z;
			//               v85 = v39.fields.m_frustumVertsForIndirect;
			//               v84 = v39.fields.m_frustumCornersLightSpaceForIndirect;
			//               if ( !v84 )
			//                 sub_1802DC2C8(v85, 0LL);
			//               if ( (unsigned int)i >= v84.max_length.size )
			//                 sub_180070260(v85, v84, v86, v87);
			//               v135 = v84.vector[i].y;
			//               if ( !v85 )
			//                 sub_1802DC2C8(0LL, v84);
			//               v136 = i + 1LL;
			//               if ( (unsigned int)v136 >= v85.max_length.size )
			//                 sub_180070260(v85, v84, v86, v87);
			//               v85.vector[v136].x = v84.vector[i].x;
			//               v85.vector[v136].y = v135;
			//             }
			//             m_asmTileManager = v39.fields.m_asmTileManager;
			//             if ( !m_asmTileManager )
			//               sub_1802DC2C8(0LL, v84);
			//             HG::Rendering::Runtime::ASMTileManager::SetFrustumVerts(
			//               m_asmTileManager,
			//               v39.fields.m_frustumVerts,
			//               v39.fields.m_frustumVertsForIndirect,
			//               0LL);
			//           }
			//         }
			//       }
			//       else
			//       {
			//         v39 = v35;
			//       }
			//       HG::Rendering::Runtime::HGASMManager::SetCachedData(v39, (HGRenderGraph *)v6, 0LL);
			//       sub_1801F7AA0(&ex);
			//     }
			//     output.shadowResult = shadowResult;
			//   }
			// }
			// 
		}

		private void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(ref PassEventInput input)
		{
			// // Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
			// void HG::Rendering::Runtime::ShadowMapPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
			//         ShadowMapPassConstructor *this,
			//         PassEventInput *input,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1874, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1874, 0LL);
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
			// void HG::Rendering::Runtime::ShadowMapPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
			//         ShadowMapPassConstructor *this,
			//         HGRenderGraph *renderGraph,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1875, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1875, 0LL);
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

		private ProfilerMarker m_samplerCSM;

		private ProfilerMarker m_samplerCharacter;

		private ProfilerMarker m_samplerASM;

		private ProfilerMarker m_samplerPunctual;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct PassInput
		{
			internal HGShadowManager shadowManager;

			internal ScriptableRenderContext srpContext;

			internal CullingResults cullingResults;

			internal LightCullResult lightCullResult;

			internal int directionalLightIndex;

			internal int punctualLightCount;

			internal unsafe int* punctualLightIndices;

			internal HGSettingParameters settingParams;

			internal unsafe HGSettingParametersCpp* settingParamsCpp;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 60)]
		internal struct PassOutput
		{
			internal ShadowResult shadowResult;
		}
	}
}
