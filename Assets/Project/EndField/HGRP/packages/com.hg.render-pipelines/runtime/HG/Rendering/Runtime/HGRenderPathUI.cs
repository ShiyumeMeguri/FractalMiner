using System;

namespace HG.Rendering.Runtime
{
	internal class HGRenderPathUI : HGRenderPathBase
	{
		internal HGRenderPathUI(HGRenderPathBase.HGRenderPathResources resources, HGCamera camera)
		{
			// // HGRenderPathUI(HGRenderPathBase+HGRenderPathResources, HGCamera)
			// void HG::Rendering::Runtime::HGRenderPathUI::HGRenderPathUI(
			//         HGRenderPathUI *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   PassConstructorID__Enum__Array *v7; // rax
			//   IPassConstructor *PassConstructor; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   IPassConstructor *v12; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   IPassConstructor *v16; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   IPassConstructor *v20; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v21; // rdx
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   MethodInfo *v24; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v25; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v26; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v27; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v28; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v29; // [rsp+28h] [rbp-20h]
			//   HGRenderPathBase_HGRenderPathResources v30; // [rsp+30h] [rbp-18h] BYREF
			//   MethodInfo *v31; // [rsp+70h] [rbp+28h]
			//   MethodInfo *v32; // [rsp+78h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDB1F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//     byte_18D8EDB1F = 1;
			//   }
			//   v7 = HG::Rendering::Runtime::HGRenderPathUI::PopulatePassConstructorIds(0LL);
			//   v30 = *resources;
			//   HG::Rendering::Runtime::HGRenderPathBase::HGRenderPathBase(
			//     (HGRenderPathBase *)this,
			//     &v30,
			//     v7,
			//     camera,
			//     HGRenderPathInternal__Enum_UI,
			//     0LL);
			//   PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//                       (HGRenderPathBase *)this,
			//                       PassConstructorID__Enum_UIImageBlur,
			//                       0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00 = sub_18003F5A0(
			//                                                                                                  PassConstructor,
			//                                                                                                  TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//   sub_18003F5A0(PassConstructor, TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix,
			//     v9,
			//     v10,
			//     v11,
			//     v24,
			//     v27);
			//   v12 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_UI,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 = sub_18003F5A0(
			//                                                                                                  v12,
			//                                                                                                  TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//   sub_18003F5A0(v12, TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20,
			//     v13,
			//     v14,
			//     v15,
			//     v25,
			//     v28);
			//   v16 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Multiblur,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01 = sub_18003F5A0(
			//                                                                                                  v16,
			//                                                                                                  TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//   sub_18003F5A0(v16, TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01,
			//     v17,
			//     v18,
			//     v19,
			//     v26,
			//     v29);
			//   v20 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_ScreenSpaceOverlay,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21 = sub_18003F5A0(
			//                                                                                                  v20,
			//                                                                                                  TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//   sub_18003F5A0(v20, TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21,
			//     v21,
			//     v22,
			//     v23,
			//     v31,
			//     v32);
			// }
			// 
		}

		private static PassConstructorID[] PopulatePassConstructorIds()
		{
			// // PassConstructorID[] PopulatePassConstructorIds()
			// PassConstructorID__Enum__Array *HG::Rendering::Runtime::HGRenderPathUI::PopulatePassConstructorIds(MethodInfo *method)
			// {
			//   __int64 v1; // r8
			//   __int64 v2; // r9
			//   Array *v3; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D8EDB1E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::PassConstructorID);
			//     sub_18003C530(&F74BEF5ED2311F0F4C64600C019B15F7FF319703043A2EA35063E8E5134F2F73_Field);
			//     byte_18D8EDB1E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3063, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3063, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1065(Patch, 0LL);
			//   }
			//   else
			//   {
			//     v3 = (Array *)il2cpp_array_new_specific_0(TypeInfo::HG::Rendering::Runtime::PassConstructorID, 4LL, v1, v2);
			//     System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//       v3,
			//       F74BEF5ED2311F0F4C64600C019B15F7FF319703043A2EA35063E8E5134F2F73_Field,
			//       0LL);
			//     return (PassConstructorID__Enum__Array *)v3;
			//   }
			// }
			// 
			return null;
		}

		protected override PassConstructorID FindFirstBackbufferPass()
		{
			// // PassConstructorID FindFirstBackbufferPass()
			// PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathUI::FindFirstBackbufferPass(
			//         HGRenderPathUI *this,
			//         MethodInfo *method)
			// {
			//   _BOOL8 v3; // rbx
			//   __int64 v4; // rdx
			//   HGCamera *v5; // rcx
			//   __int64 v6; // rax
			//   int v7; // esi
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *RTForExtraction; // rax
			//   __m128i v9; // xmm6
			//   List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *InplaceWaterMarkRTs; // rax
			//   unsigned __int64 v11; // xmm6_8
			//   PassConstructorID__Enum result; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v14; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   LODWORD(v3) = 1;
			//   if ( !byte_18D91966D )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::get_Count);
			//     byte_18D91966D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3064, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3064, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			//     goto LABEL_18;
			//   }
			//   v6 = *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//   if ( !v6 )
			//     goto LABEL_18;
			//   v7 = *(_DWORD *)(v6 + 2424);
			//   RTForExtraction = HG::Rendering::Runtime::HGCamera::GetRTForExtraction(
			//                       &v14,
			//                       *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21,
			//                       RTExtractionType__Enum_FinalResult,
			//                       0LL);
			//   v5 = *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//   v9 = *(__m128i *)RTForExtraction;
			//   if ( !v5 )
			//     goto LABEL_18;
			//   InplaceWaterMarkRTs = HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs(v5, 0LL);
			//   v5 = (HGCamera *)v9.m128i_i64[0];
			//   if ( !v9.m128i_i64[0] )
			//     goto LABEL_18;
			//   if ( *(int *)(v9.m128i_i64[0] + 32) <= 0 )
			//   {
			//     v11 = _mm_srli_si128(v9, 8).m128i_u64[0];
			//     v5 = (HGCamera *)v11;
			//     if ( !v11 )
			//       goto LABEL_18;
			//     if ( *(int *)(v11 + 32) <= 0 )
			//     {
			//       if ( InplaceWaterMarkRTs )
			//       {
			//         v3 = InplaceWaterMarkRTs.fields._size > 0;
			//         goto LABEL_12;
			//       }
			// LABEL_18:
			//       sub_180B536AC(v5, v4);
			//     }
			//   }
			// LABEL_12:
			//   result = (unsigned int)sub_18003ED00(6LL);
			//   if ( v7 > 0 )
			//     result = PassConstructorID__Enum_ScreenSpaceOverlay;
			//   if ( v3 )
			//     return 60;
			//   return result;
			// }
			// 
			return (PassConstructorID)PassConstructorID.UIImageBlur;
		}

		protected override void RenderInternal(ref HGRenderPathBase.HGRenderPathParams renderPathParams)
		{
			// // Void RenderInternal(HGRenderPathBase+HGRenderPathParams ByRef)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGRenderPathUI::RenderInternal(
			//         HGRenderPathUI *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathParams *v3; // r13
			//   HGRenderPathUI *v4; // r14
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGRenderPipeline *hgrp; // rbx
			//   HGCamera *m_RenderGraph; // r12
			//   CullingResults cullingResults; // xmm9
			//   unsigned __int64 v10; // rdx
			//   UIImageBlurManager *instance; // rax
			//   unsigned __int64 v12; // r8
			//   signed __int64 v13; // rtt
			//   UIImageBlurPassConstructor *v14; // rcx
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rdi
			//   Shader *blitPS; // rdi
			//   void *ptr; // rbx
			//   HGCamera *v21; // rdi
			//   HGRenderPipeline *v22; // rbx
			//   HGRenderPipelineRuntimeResources *v23; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *v24; // r8
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   TextureHandle v27; // xmm8
			//   HGCamera *v28; // rdi
			//   __m128i v29; // xmm6
			//   RTHandle *UICameraClearRT; // rax
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   TextureHandle v33; // xmm6
			//   unsigned __int64 v34; // r8
			//   signed __int64 v35; // rtt
			//   __int64 v36; // rdx
			//   UIPassConstructor *v37; // rcx
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   __int64 v40; // rax
			//   TextureHandle v41; // xmm8
			//   unsigned __int64 v42; // rcx
			//   signed __int64 v43; // rtt
			//   __int64 v44; // rdx
			//   MultiblurPassConstructor *v45; // rcx
			//   HGSettingParameters *v46; // rbx
			//   TextureHandle backBufferColor_k__BackingField; // xmm6
			//   unsigned __int64 v48; // rdx
			//   TextureHandle v49; // xmm6
			//   TextureHandle v50; // xmm0
			//   unsigned __int64 v51; // r8
			//   signed __int64 v52; // rtt
			//   ScreenSpaceOverlayPassConstructor *v53; // rcx
			//   IPassConstructor *PassConstructor; // rbx
			//   ComposablePass *v55; // rdi
			//   __int64 v56; // rdx
			//   __int64 v57; // rcx
			//   ComposablePass *v58; // rax
			//   HGCamera *v59; // rbx
			//   TextureHandle v60; // xmm7
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v62; // rdx
			//   __int64 v63; // rcx
			//   UIImageBlurPassConstructor_PassOutput output; // [rsp+50h] [rbp-258h] BYREF
			//   CullingResults v65; // [rsp+60h] [rbp-248h] BYREF
			//   TextureHandle v66; // [rsp+70h] [rbp-238h] BYREF
			//   HGSettingParameters *settingParameters; // [rsp+80h] [rbp-228h]
			//   HGCamera *uiCamera[2]; // [rsp+90h] [rbp-218h] BYREF
			//   UIImageBlurManager *v69; // [rsp+A0h] [rbp-208h] BYREF
			//   Il2CppException *ex; // [rsp+A8h] [rbp-200h]
			//   char *v71; // [rsp+B0h] [rbp-1F8h]
			//   UIImageBlurPassConstructor_PassInput input; // [rsp+B8h] [rbp-1F0h] BYREF
			//   HGRenderPipeline *v73; // [rsp+C0h] [rbp-1E8h]
			//   HGCamera *hgCamera; // [rsp+C8h] [rbp-1E0h]
			//   MultiblurPassConstructor_PassInput v75; // [rsp+D0h] [rbp-1D8h] BYREF
			//   TextureHandle v76; // [rsp+108h] [rbp-1A0h]
			//   HGCamera *v77; // [rsp+118h] [rbp-190h] BYREF
			//   ScreenSpaceOverlayPassConstructor_PassInput v78; // [rsp+120h] [rbp-188h] BYREF
			//   UIPassConstructor_PassInput v79; // [rsp+140h] [rbp-168h] BYREF
			//   MultiblurPassConstructor_PassInput v80; // [rsp+190h] [rbp-118h] BYREF
			//   Il2CppExceptionWrapper *v81; // [rsp+1C8h] [rbp-E0h] BYREF
			//   Il2CppExceptionWrapper *v82; // [rsp+1D0h] [rbp-D8h] BYREF
			//   UIPassConstructor_PassInput v83; // [rsp+1E0h] [rbp-C8h] BYREF
			//   char v86; // [rsp+2C8h] [rbp+20h] BYREF
			// 
			//   v3 = renderPathParams;
			//   v4 = this;
			//   if ( !byte_18D91966E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ComposablePass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
			//     byte_18D91966E = 1;
			//   }
			//   v86 = 0;
			//   input.uiImageBlurMgr = 0LL;
			//   sub_1802F01E0(&v83, 0LL, 80LL);
			//   sub_1802F01E0(&v79, 0LL, 80LL);
			//   memset(&v80, 0, sizeof(v80));
			//   memset(&v75, 0, sizeof(v75));
			//   memset(&v78, 0, sizeof(v78));
			//   v76 = 0LL;
			//   v77 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3065, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3065, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v63, v62);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)v4, v3, 0LL);
			//   }
			//   else
			//   {
			//     hgrp = v3.hgrp;
			//     v73 = hgrp;
			//     if ( !hgrp )
			//       sub_180B536AC(v6, v5);
			//     m_RenderGraph = (HGCamera *)hgrp.fields.m_RenderGraph;
			//     uiCamera[0] = m_RenderGraph;
			//     cullingResults = v3.renderRequest.cullingResults.cullingResults;
			//     v65 = cullingResults;
			//     settingParameters = hgrp.fields._settingParameters_k__BackingField;
			//     hgCamera = v3.renderRequest.hgCamera;
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v71 = &v86;
			//     try
			//     {
			//       v69 = 0LL;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
			//       instance = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields.instance;
			//       v69 = instance;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v12 = (((unsigned __int64)&v69 >> 12) & 0x1FFFFF) >> 6;
			//         v10 = ((unsigned __int64)&v69 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v12 + 36190]);
			//         do
			//           v13 = qword_18D6405E0[v12 + 36190];
			//         while ( v13 != _InterlockedCompareExchange64(&qword_18D6405E0[v12 + 36190], v13 | (1LL << v10), v13) );
			//         instance = v69;
			//       }
			//       input.uiImageBlurMgr = instance;
			//       output = 0;
			//       v14 = *(UIImageBlurPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00;
			//       if ( !v14 )
			//         sub_1802DC2C8(0LL, v10);
			//       HG::Rendering::Runtime::UIImageBlurPassConstructor::ConstructPass(
			//         v14,
			//         &input,
			//         &output,
			//         (HGRenderGraph *)m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v81 )
			//     {
			//       ex = v81.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v3 = renderPathParams;
			//       v4 = this;
			//       hgrp = v73;
			//       m_RenderGraph = uiCamera[0];
			//       cullingResults = v65;
			//     }
			//     uiCamera[0] = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//     defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
			//     if ( !defaultResources )
			//       goto LABEL_61;
			//     shaders = defaultResources.fields.shaders;
			//     if ( !shaders )
			//       goto LABEL_61;
			//     blitPS = shaders.fields.blitPS;
			//     ptr = v3.renderRequest.cullingResults.cullingResults.ptr;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     HG::Rendering::Runtime::HGUtils::ProcessWaterMarkRTs(
			//       uiCamera[0],
			//       uiCamera[0],
			//       blitPS,
			//       ptr,
			//       (HGRenderGraph *)m_RenderGraph,
			//       v3,
			//       0LL);
			//     v21 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//     v22 = v73;
			//     v23 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(v73, 0LL);
			//     if ( !v23 || (v24 = v23.fields.shaders) == 0LL )
			// LABEL_61:
			//       sub_1802DC2C8(v17, v16);
			//     HG::Rendering::Runtime::HGUtils::ProcessInplaceWaterMarkRTs(
			//       v21,
			//       v21,
			//       v24.fields.blitPS,
			//       v3.renderRequest.cullingResults.cullingResults.ptr,
			//       (HGRenderGraph *)m_RenderGraph,
			//       v3,
			//       0LL);
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0x37u,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     ex = 0LL;
			//     v71 = &v86;
			//     try
			//     {
			//       v27 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//                (TextureHandle *)&v65,
			//                (HGRenderPathBase *)v4,
			//                PassConstructorID__Enum_UI,
			//                0LL);
			//       v28 = hgCamera;
			//       if ( !hgCamera )
			//         sub_1802DC2C8(v26, v25);
			//       if ( HG::Rendering::Runtime::HGCamera::get_clearColorMode(hgCamera, 0LL) == HGAdditionalCameraData_ClearColorMode__Enum_Color )
			//       {
			//         v29 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGCamera::get_backgroundColorHDR(
			//                                                  (Color *)&v65,
			//                                                  v28,
			//                                                  0LL));
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         v65 = (CullingResults)v29;
			//         UICameraClearRT = HG::Rendering::Runtime::HGUtils::GetOrCreateUICameraClearRT((Color *)&v65, 0LL);
			//         if ( !m_RenderGraph )
			//           sub_1802DC2C8(v32, v31);
			//         v33 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                  (TextureHandle *)&v65,
			//                  (HGRenderGraph *)m_RenderGraph,
			//                  UICameraClearRT,
			//                  0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//         v65 = 0LL;
			//         v66 = v27;
			//         *(TextureHandle *)uiCamera = v33;
			//         HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//           (HGRenderGraph *)m_RenderGraph,
			//           (TextureHandle *)uiCamera,
			//           &v66,
			//           0,
			//           -1,
			//           0,
			//           (Rect *)&v65,
			//           0,
			//           0LL);
			//       }
			//       sub_1802F01E0(&v79, 0LL, 80LL);
			//       v79.target = v27;
			//       v79.hgrp = v22;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v34 = (((unsigned __int64)&v79.hgrp >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v34 + 36190]);
			//         do
			//           v35 = qword_18D6405E0[v34 + 36190];
			//         while ( v35 != _InterlockedCompareExchange64(
			//                          &qword_18D6405E0[v34 + 36190],
			//                          v35 | (1LL << (((unsigned __int64)&v79.hgrp >> 12) & 0x3F)),
			//                          v35) );
			//       }
			//       v79.cullingResults = cullingResults;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v79.uiLayerMask.m_Mask = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.UI_2D_LAYER.m_Mask;
			//       v79.renderingScale = HG::Rendering::Runtime::HGRenderPipeline::GetRemappedRenderingScale(v22, 0LL);
			//       *(_QWORD *)&v79.screenCullingRatio = *(_QWORD *)&v28.fields.screenCullingRatio;
			//       v79.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(v28, 0LL);
			//       v83 = v79;
			//       output = 0;
			//       v37 = *(UIPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20;
			//       if ( !v37 )
			//         sub_1802DC2C8(0LL, v36);
			//       HG::Rendering::Runtime::UIPassConstructor::ConstructPass(
			//         v37,
			//         &v83,
			//         (UIPassConstructor_PassOutput *)&output,
			//         (HGRenderGraph *)m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21,
			//         settingParameters,
			//         0LL);
			//       v40 = *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//       if ( !v40 )
			//         sub_1802DC2C8(v39, v38);
			//       if ( *(int *)(v40 + 2424) <= 0 )
			//       {
			//         v46 = settingParameters;
			//       }
			//       else
			//       {
			//         v41 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//                  (TextureHandle *)&v65,
			//                  (HGRenderPathBase *)v4,
			//                  PassConstructorID__Enum_Multiblur,
			//                  0LL);
			//         memset(&v75.cullingResults, 0, 32);
			//         v75.target = v41;
			//         v75.hgrp = v22;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v42 = (((unsigned __int64)&v75.hgrp >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v42 + 36190]);
			//           do
			//             v43 = qword_18D6405E0[v42 + 36190];
			//           while ( v43 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v42 + 36190],
			//                            v43 | (1LL << (((unsigned __int64)&v75.hgrp >> 12) & 0x3F)),
			//                            v43) );
			//         }
			//         v75.cullingResults = cullingResults;
			//         *(_QWORD *)&v75.screenCullingRatio = *(_QWORD *)&v28.fields.screenCullingRatio;
			//         v75.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(v28, 0LL);
			//         v80 = v75;
			//         output = 0;
			//         v45 = *(MultiblurPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01;
			//         if ( !v45 )
			//           sub_1802DC2C8(0LL, v44);
			//         v46 = settingParameters;
			//         HG::Rendering::Runtime::MultiblurPassConstructor::ConstructPass(
			//           v45,
			//           &v80,
			//           (MultiblurPassConstructor_PassOutput *)&output,
			//           (HGRenderGraph *)m_RenderGraph,
			//           *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21,
			//           settingParameters,
			//           0LL);
			//         if ( v4.fields._._firstBackbufferPass_k__BackingField == 57 )
			//         {
			//           backBufferColor_k__BackingField = v4.fields._._backBufferColor_k__BackingField;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//           v65 = 0LL;
			//           v66 = backBufferColor_k__BackingField;
			//           *(TextureHandle *)uiCamera = v41;
			//           HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//             (HGRenderGraph *)m_RenderGraph,
			//             (TextureHandle *)uiCamera,
			//             &v66,
			//             0,
			//             -1,
			//             1,
			//             (Rect *)&v65,
			//             0,
			//             0LL);
			//         }
			//       }
			//       v49 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//                (TextureHandle *)&v65,
			//                (HGRenderPathBase *)v4,
			//                PassConstructorID__Enum_ScreenSpaceOverlay,
			//                0LL);
			//       v50 = v49;
			//       v76 = v49;
			//       v77 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v51 = (((unsigned __int64)&v77 >> 12) & 0x1FFFFF) >> 6;
			//         v48 = ((unsigned __int64)&v77 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v51 + 36190]);
			//         do
			//           v52 = qword_18D6405E0[v51 + 36190];
			//         while ( v52 != _InterlockedCompareExchange64(&qword_18D6405E0[v51 + 36190], v52 | (1LL << v48), v52) );
			//         v50 = v76;
			//       }
			//       v78.target = v50;
			//       v78.camera = v77;
			//       output = 0;
			//       v53 = *(ScreenSpaceOverlayPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21;
			//       if ( !v53 )
			//         sub_1802DC2C8(0LL, v48);
			//       HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::ConstructPass(
			//         v53,
			//         &v78,
			//         (ScreenSpaceOverlayPassConstructor_PassOutput *)&output,
			//         (HGRenderGraph *)m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21,
			//         v46,
			//         0LL);
			//       if ( v4.fields._._firstBackbufferPass_k__BackingField < 57 )
			//       {
			//         PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//                             (HGRenderPathBase *)v4,
			//                             (PassConstructorID__Enum)v4.fields._._firstBackbufferPass_k__BackingField,
			//                             0LL);
			//         v55 = *(ComposablePass **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21;
			//         if ( !sub_18003F5A0(PassConstructor, TypeInfo::HG::Rendering::Runtime::ComposablePass) )
			//           sub_1802DC2C8(v57, v56);
			//         v58 = (ComposablePass *)sub_18003F5A0(PassConstructor, TypeInfo::HG::Rendering::Runtime::ComposablePass);
			//         HG::Rendering::Runtime::ComposablePass::SetChildPass(v58, (HGRenderGraph *)m_RenderGraph, v55, 0LL);
			//       }
			//       v59 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v65 = (CullingResults)v49;
			//       HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
			//         RTExtractionType__Enum_FinalResult,
			//         (TextureHandle *)&v65,
			//         v59,
			//         (HGRenderGraph *)m_RenderGraph,
			//         0LL);
			//       v65 = (CullingResults)v49;
			//       HG::Rendering::Runtime::HGUtils::ExtractFinalResultForInplaceWaterMarkRTs(
			//         (TextureHandle *)&v65,
			//         *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m21,
			//         (HGRenderGraph *)m_RenderGraph,
			//         0LL);
			//       if ( v4.fields._._firstBackbufferPass_k__BackingField > 57 )
			//       {
			//         v60 = v4.fields._._backBufferColor_k__BackingField;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//         v65 = 0LL;
			//         v66 = v60;
			//         *(TextureHandle *)uiCamera = v49;
			//         HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//           (HGRenderGraph *)m_RenderGraph,
			//           (TextureHandle *)uiCamera,
			//           &v66,
			//           0,
			//           -1,
			//           1,
			//           (Rect *)&v65,
			//           0,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v82 )
			//     {
			//       ex = v82.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}

		protected override PassConstructorID GetDefaultFirstBackbufferPass()
		{
			// // PassConstructorID GetDefaultFirstBackbufferPass()
			// PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathUI::GetDefaultFirstBackbufferPass(
			//         HGRenderPathUI *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3068, 0LL) )
			//     return 55;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3068, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return (PassConstructorID)PassConstructorID.UIImageBlur;
		}

		public PassConstructorID <>iFixBaseProxy_FindFirstBackbufferPass()
		{
			// // PassConstructorID <>iFixBaseProxy_FindFirstBackbufferPass()
			// PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathUI::__iFixBaseProxy_FindFirstBackbufferPass(
			//         HGRenderPathUI *this,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::HGRenderPathBase::FindFirstBackbufferPass((HGRenderPathBase *)this, 0LL);
			// }
			// 
			return (PassConstructorID)PassConstructorID.UIImageBlur;
		}

		public PassConstructorID <>iFixBaseProxy_GetDefaultFirstBackbufferPass()
		{
			// // PassConstructorID <>iFixBaseProxy_GetDefaultFirstBackbufferPass()
			// PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPathUI::__iFixBaseProxy_GetDefaultFirstBackbufferPass(
			//         HGRenderPathUI *this,
			//         MethodInfo *method)
			// {
			//   return HG::Rendering::Runtime::HGRenderPathBase::GetDefaultFirstBackbufferPass((HGRenderPathBase *)this, 0LL);
			// }
			// 
			return (PassConstructorID)PassConstructorID.UIImageBlur;
		}

		private UIImageBlurPassConstructor m_uiImageBlurPassConstructor;

		private UIPassConstructor m_uiPassConstructor;

		private MultiblurPassConstructor m_multiblurPassConstructor;

		private ScreenSpaceOverlayPassConstructor m_screenSpaceOverlayPassConstructor;
	}
}
