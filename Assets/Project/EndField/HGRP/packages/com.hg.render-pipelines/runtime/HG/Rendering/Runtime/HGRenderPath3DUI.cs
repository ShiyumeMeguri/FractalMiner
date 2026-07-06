using System;

namespace HG.Rendering.Runtime
{
	internal class HGRenderPath3DUI : HGRenderPathBase
	{
		internal HGRenderPath3DUI(HGRenderPathBase.HGRenderPathResources resources, HGCamera camera)
		{
			// // HGRenderPath3DUI(HGRenderPathBase+HGRenderPathResources, HGCamera)
			// void HG::Rendering::Runtime::HGRenderPath3DUI::HGRenderPath3DUI(
			//         HGRenderPath3DUI *this,
			//         HGRenderPathBase_HGRenderPathResources *resources,
			//         HGCamera *camera,
			//         MethodInfo *method)
			// {
			//   PassConstructorID__Enum__Array *v7; // rax
			//   IPassConstructor *PassConstructor; // rdi
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   IPassConstructor *v12; // rdi
			//   OneofDescriptorProto *v13; // rdx
			//   FileDescriptor *v14; // r8
			//   MessageDescriptor *v15; // r9
			//   IPassConstructor *v16; // rdi
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   IPassConstructor *v20; // rdi
			//   OneofDescriptorProto *v21; // rdx
			//   FileDescriptor *v22; // r8
			//   MessageDescriptor *v23; // r9
			//   IPassConstructor *v24; // rdi
			//   OneofDescriptorProto *v25; // rdx
			//   FileDescriptor *v26; // r8
			//   MessageDescriptor *v27; // r9
			//   String__Array *v28; // [rsp+20h] [rbp-28h]
			//   String__Array *v29; // [rsp+20h] [rbp-28h]
			//   String__Array *v30; // [rsp+20h] [rbp-28h]
			//   String__Array *v31; // [rsp+20h] [rbp-28h]
			//   String *v32; // [rsp+28h] [rbp-20h]
			//   String *v33; // [rsp+28h] [rbp-20h]
			//   String *v34; // [rsp+28h] [rbp-20h]
			//   String *v35; // [rsp+28h] [rbp-20h]
			//   HGRenderPathBase_HGRenderPathResources v36; // [rsp+30h] [rbp-18h] BYREF
			//   String__Array *v37; // [rsp+70h] [rbp+28h]
			//   String *v38; // [rsp+78h] [rbp+30h]
			//   MethodInfo *v39; // [rsp+80h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDB0E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
			//     byte_18D8EDB0E = 1;
			//   }
			//   v7 = HG::Rendering::Runtime::HGRenderPath3DUI::PopulatePassConstructorIds(0LL);
			//   v36 = *resources;
			//   HG::Rendering::Runtime::HGRenderPathBase::HGRenderPathBase(
			//     (HGRenderPathBase *)this,
			//     &v36,
			//     v7,
			//     camera,
			//     HGRenderPathInternal__Enum_UI3D,
			//     0LL);
			//   PassConstructor = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//                       (HGRenderPathBase *)this,
			//                       PassConstructorID__Enum_UIImageBlur,
			//                       0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23 = sub_18003F5A0(
			//                                                                                       PassConstructor,
			//                                                                                       TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//   sub_18003F5A0(PassConstructor, TypeInfo::HG::Rendering::Runtime::UIImageBlurPassConstructor);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23,
			//     v9,
			//     v10,
			//     v11,
			//     v28,
			//     v32,
			//     (MethodInfo *)v36.defaultResources);
			//   v12 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_UI,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00 = sub_18003F5A0(
			//                                                                                                  v12,
			//                                                                                                  TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//   sub_18003F5A0(v12, TypeInfo::HG::Rendering::Runtime::UIPassConstructor);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix,
			//     v13,
			//     v14,
			//     v15,
			//     v29,
			//     v33,
			//     (MethodInfo *)v36.defaultResources);
			//   v16 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_UIPP,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20 = sub_18003F5A0(
			//                                                                                                  v16,
			//                                                                                                  TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
			//   sub_18003F5A0(v16, TypeInfo::HG::Rendering::Runtime::UIPostProcessConstructor);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20,
			//     v17,
			//     v18,
			//     v19,
			//     v30,
			//     v34,
			//     (MethodInfo *)v36.defaultResources);
			//   v20 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_Multiblur,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01 = sub_18003F5A0(
			//                                                                                                  v20,
			//                                                                                                  TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//   sub_18003F5A0(v20, TypeInfo::HG::Rendering::Runtime::MultiblurPassConstructor);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01,
			//     v21,
			//     v22,
			//     v23,
			//     v31,
			//     v35,
			//     (MethodInfo *)v36.defaultResources);
			//   v24 = HG::Rendering::Runtime::HGRenderPathBase::GetPassConstructor(
			//           (HGRenderPathBase *)this,
			//           PassConstructorID__Enum_ScreenSpaceOverlay,
			//           0LL);
			//   *(_QWORD *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21 = sub_18003F5A0(
			//                                                                                                  v24,
			//                                                                                                  TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//   sub_18003F5A0(v24, TypeInfo::HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21,
			//     v25,
			//     v26,
			//     v27,
			//     v37,
			//     v38,
			//     v39);
			// }
			// 
		}

		private static PassConstructorID[] PopulatePassConstructorIds()
		{
			// // PassConstructorID[] PopulatePassConstructorIds()
			// PassConstructorID__Enum__Array *HG::Rendering::Runtime::HGRenderPath3DUI::PopulatePassConstructorIds(
			//         MethodInfo *method)
			// {
			//   __int64 v1; // r8
			//   __int64 v2; // r9
			//   Array *v3; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D8EDB0D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::PassConstructorID);
			//     sub_18003C530(&45394B168F330187244267C78B7D937B94C1E6456EB140F6DA76F3A3478609AD_Field);
			//     byte_18D8EDB0D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2965, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2965, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1065(Patch, 0LL);
			//   }
			//   else
			//   {
			//     v3 = (Array *)il2cpp_array_new_specific_0(TypeInfo::HG::Rendering::Runtime::PassConstructorID, 5LL, v1, v2);
			//     System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//       v3,
			//       45394B168F330187244267C78B7D937B94C1E6456EB140F6DA76F3A3478609AD_Field,
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
			// PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPath3DUI::FindFirstBackbufferPass(
			//         HGRenderPath3DUI *this,
			//         MethodInfo *method)
			// {
			//   _BOOL8 v3; // rdi
			//   HGCamera *v4; // rcx
			//   HGCamera *m_Length; // rdx
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *RTForExtraction; // rax
			//   __m128i v7; // xmm6
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ *v8; // rax
			//   __m128i v9; // xmm7
			//   List_1_System_ValueTuple_2_UnityEngine_Rendering_RTHandle_Single_ *InplaceWaterMarkRTs; // rax
			//   _BOOL8 v11; // rbp
			//   _BOOL8 v12; // rsi
			//   unsigned __int64 v13; // xmm6_8
			//   unsigned __int64 v14; // xmm7_8
			//   PassConstructorID__Enum result; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ValueTuple_2_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_System_Collections_Generic_HashSet_1_UnityEngine_Rendering_RTHandle_ v17; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   LOBYTE(v3) = 1;
			//   if ( !byte_18D91964A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<UnityEngine::Rendering::RTHandle>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::ValueTuple<UnityEngine::Rendering::RTHandle,float>>::get_Count);
			//     byte_18D91964A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2966, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2966, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_65((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			//     goto LABEL_27;
			//   }
			//   m_Length = *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//   if ( !m_Length )
			//     goto LABEL_27;
			//   RTForExtraction = HG::Rendering::Runtime::HGCamera::GetRTForExtraction(
			//                       &v17,
			//                       m_Length,
			//                       RTExtractionType__Enum_SceneColorPS,
			//                       0LL);
			//   m_Length = *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//   v7 = *(__m128i *)RTForExtraction;
			//   if ( !m_Length )
			//     goto LABEL_27;
			//   v8 = HG::Rendering::Runtime::HGCamera::GetRTForExtraction(&v17, m_Length, RTExtractionType__Enum_FinalResult, 0LL);
			//   v4 = *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//   v9 = *(__m128i *)v8;
			//   if ( !v4 )
			//     goto LABEL_27;
			//   InplaceWaterMarkRTs = HG::Rendering::Runtime::HGCamera::GetInplaceWaterMarkRTs(v4, 0LL);
			//   v4 = *(HGCamera **)&this[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//   if ( !v4 )
			//     goto LABEL_27;
			//   m_Length = (HGCamera *)(unsigned int)v4.fields.sortingOrdersToBlurInternal.m_Length;
			//   v4 = (HGCamera *)v7.m128i_i64[0];
			//   if ( !v7.m128i_i64[0] )
			//     goto LABEL_27;
			//   if ( *(int *)(v7.m128i_i64[0] + 32) <= 0 )
			//   {
			//     v13 = _mm_srli_si128(v7, 8).m128i_u64[0];
			//     if ( !v13 )
			//       goto LABEL_27;
			//     v12 = (int)m_Length > 0;
			//     v11 = *(_DWORD *)(v13 + 32) > 0;
			//   }
			//   else
			//   {
			//     LODWORD(v11) = 1;
			//     v12 = (int)m_Length > 0;
			//   }
			//   if ( !v9.m128i_i64[0] )
			// LABEL_27:
			//     sub_180B536AC(v4, m_Length);
			//   if ( *(int *)(v9.m128i_i64[0] + 32) <= 0 )
			//   {
			//     v14 = _mm_srli_si128(v9, 8).m128i_u64[0];
			//     if ( !v14 )
			//       goto LABEL_27;
			//     if ( *(int *)(v14 + 32) <= 0 )
			//     {
			//       if ( InplaceWaterMarkRTs )
			//       {
			//         v3 = InplaceWaterMarkRTs.fields._size > 0;
			//         goto LABEL_19;
			//       }
			//       goto LABEL_27;
			//     }
			//   }
			// LABEL_19:
			//   result = (unsigned int)sub_18003ED00(6LL);
			//   if ( v11 )
			//     result = PassConstructorID__Enum_UI;
			//   if ( v12 )
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
			// // Hidden C++ exception states: #wind=4
			// void HG::Rendering::Runtime::HGRenderPath3DUI::RenderInternal(
			//         HGRenderPath3DUI *this,
			//         HGRenderPathBase_HGRenderPathParams *renderPathParams,
			//         MethodInfo *method)
			// {
			//   HGRenderPath3DUI *v4; // r14
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGRenderPipeline *hgrp; // r13
			//   HGRenderGraph *m_RenderGraph; // r12
			//   HGCamera *v9; // r15
			//   int32_t msaaSamples_k__BackingField; // edi
			//   Vector2Int finalRTSize; // rbx
			//   TextureHandle v12; // xmm9
			//   unsigned __int64 v13; // rdx
			//   UIImageBlurManager *instance; // rax
			//   unsigned __int64 v15; // r8
			//   signed __int64 v16; // rtt
			//   UIImageBlurPassConstructor *v17; // rcx
			//   HGRenderPipelineRuntimeResources *defaultResources; // rax
			//   unsigned __int64 v19; // rdx
			//   MultiblurPassConstructor *handle; // rcx
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rdi
			//   Shader *blitPS; // rdi
			//   void *ptr; // rbx
			//   HGCamera *v24; // rbx
			//   HGRenderPipelineRuntimeResources *v25; // rax
			//   HGRenderPipelineRuntimeResources_ShaderResources *v26; // r8
			//   unsigned __int64 v27; // r8
			//   signed __int64 v28; // rtt
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   HGCamera *v31; // rbx
			//   __int64 v32; // rdx
			//   UIPassConstructor *v33; // rcx
			//   HGSettingParameters *v34; // rdi
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   Rect v37; // xmm8
			//   CullingResults v38; // xmm7
			//   __int64 v39; // rdx
			//   UIPostProcessConstructor *v40; // rcx
			//   __int64 v41; // rdx
			//   UIPassConstructor *v42; // rcx
			//   __int64 v43; // rax
			//   TextureHandle v44; // xmm8
			//   unsigned __int64 v45; // r8
			//   signed __int64 v46; // rtt
			//   CullingResults backBufferColor_k__BackingField; // xmm7
			//   TextureHandle v48; // xmm8
			//   TextureHandle v49; // xmm0
			//   unsigned __int64 v50; // r8
			//   signed __int64 v51; // rtt
			//   HGCamera *v52; // rbx
			//   CullingResults v53; // xmm7
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v55; // rdx
			//   __int64 v56; // rcx
			//   __int64 v57; // [rsp+0h] [rbp-338h] BYREF
			//   UIImageBlurPassConstructor_PassOutput output; // [rsp+50h] [rbp-2E8h] BYREF
			//   UIPassConstructor_PassOutput v59; // [rsp+51h] [rbp-2E7h] BYREF
			//   TextureHandle v60; // [rsp+60h] [rbp-2D8h] BYREF
			//   TextureHandle v61; // [rsp+70h] [rbp-2C8h] BYREF
			//   HGCamera *uiCamera; // [rsp+80h] [rbp-2B8h]
			//   char *v63; // [rsp+88h] [rbp-2B0h]
			//   HGSettingParameters *settingParameters; // [rsp+90h] [rbp-2A8h]
			//   HGCamera *hgCamera; // [rsp+98h] [rbp-2A0h]
			//   HGRenderPipeline *v66; // [rsp+A0h] [rbp-298h]
			//   HGRenderGraph *v67; // [rsp+A8h] [rbp-290h]
			//   _QWORD v68[2]; // [rsp+B0h] [rbp-288h] BYREF
			//   CullingResults cullingResults; // [rsp+C0h] [rbp-278h] BYREF
			//   UIImageBlurPassConstructor_PassInput input; // [rsp+D0h] [rbp-268h] BYREF
			//   MultiblurPassConstructor_PassInput v71; // [rsp+D8h] [rbp-260h] BYREF
			//   TextureHandle v72; // [rsp+110h] [rbp-228h]
			//   HGCamera *v73; // [rsp+120h] [rbp-218h] BYREF
			//   ScreenSpaceOverlayPassConstructor_PassInput v74; // [rsp+128h] [rbp-210h] BYREF
			//   UIPassConstructor_PassInput v75; // [rsp+140h] [rbp-1F8h] BYREF
			//   MultiblurPassConstructor_PassInput v76; // [rsp+190h] [rbp-1A8h] BYREF
			//   Il2CppExceptionWrapper *v77; // [rsp+1C8h] [rbp-170h] BYREF
			//   Il2CppExceptionWrapper *v78; // [rsp+1D0h] [rbp-168h] BYREF
			//   Il2CppExceptionWrapper *v79; // [rsp+1D8h] [rbp-160h] BYREF
			//   Il2CppExceptionWrapper *v80; // [rsp+1E0h] [rbp-158h] BYREF
			//   UIPassConstructor_PassInput v81; // [rsp+1F0h] [rbp-148h] BYREF
			//   __int128 v82; // [rsp+270h] [rbp-C8h]
			//   UIPostProcessConstructor_PassInput v83; // [rsp+280h] [rbp-B8h] BYREF
			//   char v86; // [rsp+358h] [rbp+20h] BYREF
			// 
			//   v4 = this;
			//   if ( !byte_18D91964B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::TAAUQuality>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
			//     byte_18D91964B = 1;
			//   }
			//   sub_1802F01E0(&v81, 0LL, 80LL);
			//   v59 = 0;
			//   v86 = 0;
			//   input.uiImageBlurMgr = 0LL;
			//   sub_1802F01E0(&v75, 0LL, 80LL);
			//   memset(&v76, 0, sizeof(v76));
			//   memset(&v71, 0, sizeof(v71));
			//   memset(&v74, 0, sizeof(v74));
			//   v72 = 0LL;
			//   v73 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2967, 0LL) )
			//   {
			//     hgrp = renderPathParams.hgrp;
			//     v66 = hgrp;
			//     if ( !hgrp )
			//       sub_180B536AC(v6, v5);
			//     m_RenderGraph = hgrp.fields.m_RenderGraph;
			//     v67 = m_RenderGraph;
			//     cullingResults = renderPathParams.renderRequest.cullingResults.cullingResults;
			//     settingParameters = hgrp.fields._settingParameters_k__BackingField;
			//     hgCamera = renderPathParams.renderRequest.hgCamera;
			//     v9 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//     if ( !v9 )
			//       sub_180B536AC(v6, v5);
			//     msaaSamples_k__BackingField = v9.fields._msaaSamples_k__BackingField;
			//     finalRTSize = HG::Rendering::Runtime::HGCamera::get_finalRTSize(
			//                     *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01,
			//                     0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     v12 = *HG::Rendering::Runtime::HGRenderPipeline::CreateColorBuffer(
			//              &v61,
			//              m_RenderGraph,
			//              v9,
			//              msaaSamples_k__BackingField != 1,
			//              GraphicsFormat__Enum_B10G11R11_UFloatPack32,
			//              finalRTSize,
			//              0LL);
			//     v61 = v12;
			//     UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//       (Int32Enum__Enum)0,
			//       MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//     uiCamera = 0LL;
			//     v63 = &v86;
			//     try
			//     {
			//       v68[0] = 0LL;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::UIImageBlurManager);
			//       instance = TypeInfo::HG::Rendering::Runtime::UIImageBlurManager.static_fields.instance;
			//       v68[0] = instance;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v15 = (((unsigned __int64)v68 >> 12) & 0x1FFFFF) >> 6;
			//         v13 = ((unsigned __int64)v68 >> 12) & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v15 + 36190]);
			//         do
			//           v16 = qword_18D6405E0[v15 + 36190];
			//         while ( v16 != _InterlockedCompareExchange64(&qword_18D6405E0[v15 + 36190], v16 | (1LL << v13), v16) );
			//         instance = (UIImageBlurManager *)v68[0];
			//       }
			//       input.uiImageBlurMgr = instance;
			//       output = 0;
			//       v17 = *(UIImageBlurPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m23;
			//       if ( !v17 )
			//         sub_1802DC2C8(0LL, v13);
			//       HG::Rendering::Runtime::UIImageBlurPassConstructor::ConstructPass(
			//         v17,
			//         &input,
			//         &output,
			//         m_RenderGraph,
			//         *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01,
			//         0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v77 )
			//     {
			//       uiCamera = (HGCamera *)v77.ex;
			//       if ( uiCamera )
			//         sub_18000F780(uiCamera);
			//       v4 = this;
			//       hgrp = v66;
			//       m_RenderGraph = v67;
			//       v12 = v61;
			//     }
			//     uiCamera = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//     defaultResources = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
			//     if ( defaultResources )
			//     {
			//       shaders = defaultResources.fields.shaders;
			//       if ( shaders )
			//       {
			//         blitPS = shaders.fields.blitPS;
			//         ptr = renderPathParams.renderRequest.cullingResults.cullingResults.ptr;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         HG::Rendering::Runtime::HGUtils::ProcessWaterMarkRTs(
			//           uiCamera,
			//           uiCamera,
			//           blitPS,
			//           ptr,
			//           m_RenderGraph,
			//           renderPathParams,
			//           0LL);
			//         v24 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//         v25 = HG::Rendering::Runtime::HGRenderPipeline::get_defaultResources(hgrp, 0LL);
			//         if ( v25 )
			//         {
			//           v26 = v25.fields.shaders;
			//           if ( v26 )
			//           {
			//             HG::Rendering::Runtime::HGUtils::ProcessInplaceWaterMarkRTs(
			//               v24,
			//               v24,
			//               v26.fields.blitPS,
			//               renderPathParams.renderRequest.cullingResults.cullingResults.ptr,
			//               m_RenderGraph,
			//               renderPathParams,
			//               0LL);
			//             UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x37u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//             uiCamera = 0LL;
			//             v63 = &v86;
			//             try
			//             {
			//               sub_1802F01E0(&v75, 0LL, 80LL);
			//               v75.target = v12;
			//               v75.hgrp = hgrp;
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v27 = (((unsigned __int64)&v75.hgrp >> 12) & 0x1FFFFF) >> 6;
			//                 _m_prefetchw(&qword_18D6405E0[v27 + 36190]);
			//                 do
			//                   v28 = qword_18D6405E0[v27 + 36190];
			//                 while ( v28 != _InterlockedCompareExchange64(
			//                                  &qword_18D6405E0[v27 + 36190],
			//                                  v28 | (1LL << (((unsigned __int64)&v75.hgrp >> 12) & 0x3F)),
			//                                  v28) );
			//               }
			//               v75.cullingResults = cullingResults;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//               v75.uiLayerMask.m_Mask = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.UI_3D_LAYER.m_Mask;
			//               v75.renderingScale = HG::Rendering::Runtime::HGRenderPipeline::GetRemappedRenderingScale(hgrp, 0LL);
			//               v31 = hgCamera;
			//               if ( !hgCamera )
			//                 sub_1802DC2C8(v30, v29);
			//               *(_QWORD *)&v75.screenCullingRatio = *(_QWORD *)&hgCamera.fields.screenCullingRatio;
			//               v75.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(hgCamera, 0LL);
			//               v81 = v75;
			//               v59 = 0;
			//               v33 = *(UIPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00;
			//               if ( !v33 )
			//                 sub_1802DC2C8(0LL, v32);
			//               v34 = settingParameters;
			//               HG::Rendering::Runtime::UIPassConstructor::ConstructPass(
			//                 v33,
			//                 &v81,
			//                 &v59,
			//                 m_RenderGraph,
			//                 *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01,
			//                 settingParameters,
			//                 0LL);
			//               v60 = v12;
			//               HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
			//                 RTExtractionType__Enum_SceneColorLS,
			//                 &v60,
			//                 *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01,
			//                 m_RenderGraph,
			//                 0LL);
			//             }
			//             catch ( Il2CppExceptionWrapper *v78 )
			//             {
			//               uiCamera = (HGCamera *)v78.ex;
			//               if ( uiCamera )
			//                 sub_18000F780(uiCamera);
			//               v4 = this;
			//               hgrp = v66;
			//               m_RenderGraph = v67;
			//               v34 = settingParameters;
			//               v31 = hgCamera;
			//               v12 = v61;
			//             }
			//             UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x36u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//             uiCamera = 0LL;
			//             v63 = &v86;
			//             try
			//             {
			//               v37 = (Rect)*HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//                              &v61,
			//                              (HGRenderPathBase *)v4,
			//                              PassConstructorID__Enum_UIPP,
			//                              0LL);
			//               HIDWORD(v82) = 0;
			//               v38 = cullingResults;
			//               if ( !v34 )
			//                 sub_1802DC2C8(v36, v35);
			//               LODWORD(v82) = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                (SettingParameter_1_System_Int32Enum_ *)v34.fields._taauQuality_k__BackingField,
			//                                MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::TAAUQuality>::op_Implicit);
			//               DWORD2(v82) = 74;
			//               DWORD1(v82) = v4.fields._._renderPath_k__BackingField;
			//               v83.source = v12;
			//               v83.target = (TextureHandle)v37;
			//               v83.cullingResults = v38;
			//               *(_OWORD *)&v83.taauQuality = v82;
			//               output = 0;
			//               v40 = *(UIPostProcessConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m20;
			//               if ( !v40 )
			//                 sub_1802DC2C8(0LL, v39);
			//               HG::Rendering::Runtime::UIPostProcessConstructor::ConstructPass(
			//                 v40,
			//                 &v83,
			//                 (UIPostProcessConstructor_PassOutput *)&output,
			//                 m_RenderGraph,
			//                 *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01,
			//                 v34,
			//                 0LL);
			//               v60.handle = *(ResourceHandle *)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//               v61 = (TextureHandle)v37;
			//               HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
			//                 RTExtractionType__Enum_SceneColorPS,
			//                 &v61,
			//                 *(HGCamera **)&v60.handle,
			//                 m_RenderGraph,
			//                 0LL);
			//             }
			//             catch ( Il2CppExceptionWrapper *v79 )
			//             {
			//               uiCamera = (HGCamera *)v79.ex;
			//               if ( uiCamera )
			//                 sub_18000F780(uiCamera);
			//               v4 = this;
			//               hgrp = v66;
			//               m_RenderGraph = v67;
			//               v34 = settingParameters;
			//               v31 = hgCamera;
			//             }
			//             UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x37u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::PassConstructorID>);
			//             v60.handle = 0LL;
			//             v60.fallBackResource = (ResourceHandle)&v86;
			//             try
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//               v81.uiLayerMask.m_Mask = TypeInfo::HG::Rendering::Runtime::HGUtils.static_fields.UI_2D_LAYER.m_Mask;
			//               v81.target = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//                               &v61,
			//                               (HGRenderPathBase *)v4,
			//                               PassConstructorID__Enum_UI,
			//                               0LL);
			//               v42 = *(UIPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m00;
			//               if ( !v42 )
			//                 sub_1802DC2C8(0LL, v41);
			//               HG::Rendering::Runtime::UIPassConstructor::ConstructPass(
			//                 v42,
			//                 &v81,
			//                 &v59,
			//                 m_RenderGraph,
			//                 *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01,
			//                 v34,
			//                 0LL);
			//             }
			//             catch ( Il2CppExceptionWrapper *v80 )
			//             {
			//               v19 = (unsigned __int64)&v57;
			//               v60.handle = (ResourceHandle)v80.ex;
			//               handle = (MultiblurPassConstructor *)v60.handle;
			//               if ( v60.handle )
			//                 sub_18000F780(*(_QWORD *)&v60.handle);
			//               v4 = this;
			//               hgrp = v66;
			//               m_RenderGraph = v67;
			//               v34 = settingParameters;
			//               v31 = hgCamera;
			//             }
			//             v43 = *(_QWORD *)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//             if ( v43 )
			//             {
			//               if ( *(int *)(v43 + 2424) > 0 )
			//               {
			//                 v44 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//                          &v61,
			//                          (HGRenderPathBase *)v4,
			//                          PassConstructorID__Enum_Multiblur,
			//                          0LL);
			//                 memset(&v71.cullingResults, 0, 32);
			//                 v71.target = v44;
			//                 v71.hgrp = hgrp;
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   v45 = (((unsigned __int64)&v71.hgrp >> 12) & 0x1FFFFF) >> 6;
			//                   v19 = ((unsigned __int64)&v71.hgrp >> 12) & 0x3F;
			//                   _m_prefetchw(&qword_18D6405E0[v45 + 36190]);
			//                   do
			//                   {
			//                     handle = (MultiblurPassConstructor *)(qword_18D6405E0[v45 + 36190] | (1LL << v19));
			//                     v46 = qword_18D6405E0[v45 + 36190];
			//                   }
			//                   while ( v46 != _InterlockedCompareExchange64(
			//                                    &qword_18D6405E0[v45 + 36190],
			//                                    (signed __int64)handle,
			//                                    v46) );
			//                 }
			//                 v71.cullingResults = cullingResults;
			//                 if ( !v31 )
			//                   goto LABEL_70;
			//                 *(_QWORD *)&v71.screenCullingRatio = *(_QWORD *)&v31.fields.screenCullingRatio;
			//                 v71.screenCullingLayerMask = HG::Rendering::Runtime::HGCamera::get_screenCullingLayerMask(v31, 0LL);
			//                 v76 = v71;
			//                 output = 0;
			//                 handle = *(MultiblurPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m01;
			//                 if ( !handle )
			//                   goto LABEL_70;
			//                 HG::Rendering::Runtime::MultiblurPassConstructor::ConstructPass(
			//                   handle,
			//                   &v76,
			//                   (MultiblurPassConstructor_PassOutput *)&output,
			//                   m_RenderGraph,
			//                   *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01,
			//                   v34,
			//                   0LL);
			//                 if ( v4.fields._._firstBackbufferPass_k__BackingField == 57 )
			//                 {
			//                   backBufferColor_k__BackingField = (CullingResults)v4.fields._._backBufferColor_k__BackingField;
			//                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//                   v61 = 0LL;
			//                   cullingResults = backBufferColor_k__BackingField;
			//                   v60 = v44;
			//                   HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//                     m_RenderGraph,
			//                     &v60,
			//                     (TextureHandle *)&cullingResults,
			//                     0,
			//                     -1,
			//                     1,
			//                     (Rect *)&v61,
			//                     0,
			//                     0LL);
			//                 }
			//               }
			//               v48 = *HG::Rendering::Runtime::HGRenderPathBase::GetBackbufferOrIntermediate(
			//                        &v61,
			//                        (HGRenderPathBase *)v4,
			//                        PassConstructorID__Enum_ScreenSpaceOverlay,
			//                        0LL);
			//               v49 = v48;
			//               v72 = v48;
			//               v73 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//               if ( dword_18D8E43F8 )
			//               {
			//                 v50 = (((unsigned __int64)&v73 >> 12) & 0x1FFFFF) >> 6;
			//                 v19 = ((unsigned __int64)&v73 >> 12) & 0x3F;
			//                 _m_prefetchw(&qword_18D6405E0[v50 + 36190]);
			//                 do
			//                   v51 = qword_18D6405E0[v50 + 36190];
			//                 while ( v51 != _InterlockedCompareExchange64(&qword_18D6405E0[v50 + 36190], v51 | (1LL << v19), v51) );
			//                 v49 = v72;
			//               }
			//               v74.target = v49;
			//               v74.camera = v73;
			//               output = 0;
			//               handle = *(MultiblurPassConstructor **)&v4[1].fields._.m_shaderVariablesGlobal._PrevNonJitteredInvViewProjMatrix.m21;
			//               if ( handle )
			//               {
			//                 HG::Rendering::Runtime::ScreenSpaceOverlayPassConstructor::ConstructPass(
			//                   (ScreenSpaceOverlayPassConstructor *)handle,
			//                   &v74,
			//                   (ScreenSpaceOverlayPassConstructor_PassOutput *)&output,
			//                   m_RenderGraph,
			//                   *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01,
			//                   v34,
			//                   0LL);
			//                 v52 = *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//                 v61 = v48;
			//                 HG::Rendering::Runtime::HGUtils::ProcessRTExtraction(
			//                   RTExtractionType__Enum_FinalResult,
			//                   &v61,
			//                   v52,
			//                   m_RenderGraph,
			//                   0LL);
			//                 v61 = v48;
			//                 HG::Rendering::Runtime::HGUtils::ExtractFinalResultForInplaceWaterMarkRTs(
			//                   &v61,
			//                   *(HGCamera **)&v4[1].fields._.m_shaderVariablesGlobal._PrevInvViewProjMatrix.m01,
			//                   m_RenderGraph,
			//                   0LL);
			//                 if ( v4.fields._._firstBackbufferPass_k__BackingField > 57 )
			//                 {
			//                   v53 = (CullingResults)v4.fields._._backBufferColor_k__BackingField;
			//                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::CopyTexturePass);
			//                   v61 = 0LL;
			//                   cullingResults = v53;
			//                   v60 = v48;
			//                   HG::Rendering::Runtime::CopyTexturePass::BlitTexture(
			//                     m_RenderGraph,
			//                     &v60,
			//                     (TextureHandle *)&cullingResults,
			//                     0,
			//                     -1,
			//                     1,
			//                     (Rect *)&v61,
			//                     0,
			//                     0LL);
			//                 }
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_70:
			//     sub_1802DC2C8(handle, v19);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2967, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v56, v55);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_389(Patch, (Object *)v4, renderPathParams, 0LL);
			// }
			// 
		}

		protected override PassConstructorID GetDefaultFirstBackbufferPass()
		{
			// // PassConstructorID GetDefaultFirstBackbufferPass()
			// PassConstructorID__Enum HG::Rendering::Runtime::HGRenderPath3DUI::GetDefaultFirstBackbufferPass(
			//         HGRenderPath3DUI *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2974, 0LL) )
			//     return 54;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2974, 0LL);
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

		private UIPostProcessConstructor m_uiPostProcessConstructor;

		private MultiblurPassConstructor m_multiblurPassConstructor;

		private ScreenSpaceOverlayPassConstructor m_screenSpaceOverlayPassConstructor;
	}
}
