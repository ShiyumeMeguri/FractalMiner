using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGVerticalOcclusionMapManager
	{
		public HGVerticalOcclusionMapManager()
		{
			// // HGVerticalOcclusionMapManager()
			// void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::HGVerticalOcclusionMapManager(
			//         HGVerticalOcclusionMapManager *this,
			//         MethodInfo *method)
			// {
			//   this.fields.m_depthOnlySysCppHandle = -1;
			//   this.fields.m_occlusionRange = 1.0;
			//   this.fields.m_occlusionMapSize = 1;
			// }
			// 
		}

		internal void GetVerticalOcclusionMapShaderVariables(out Vector4 param, out bool enabled)
		{
			// // Void GetVerticalOcclusionMapShaderVariables(Vector4 ByRef, Boolean ByRef)
			// void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::GetVerticalOcclusionMapShaderVariables(
			//         HGVerticalOcclusionMapManager *this,
			//         Vector4 *param,
			//         bool *enabled,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   int32_t m_occlusionMapSize; // ebp
			//   float m_occlusionRange; // xmm6_4
			//   float v11; // xmm6_4
			//   float v12; // xmm7_4
			//   float v13; // xmm8_4
			//   __m128 v14; // xmm0
			//   __m128 v15; // xmm0
			//   __m128 v16; // xmm0
			//   __m128 v17; // xmm0
			//   bool v18; // zf
			//   bool v19; // al
			//   ILFixDynamicMethodWrapper_2 *v20; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v22; // rax
			//   __m128 v23; // [rsp+30h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D8ED96F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D8ED96F = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, param);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_26;
			//   if ( wrapperArray.max_length.size <= 870 )
			//     goto LABEL_9;
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, wrapperArray);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_26;
			//   if ( wrapperArray.max_length.size <= 0x366u )
			//     goto LABEL_48;
			//   if ( !wrapperArray[24].vector[6] )
			//   {
			// LABEL_9:
			//     m_occlusionMapSize = this.fields.m_occlusionMapSize;
			//     m_occlusionRange = this.fields.m_occlusionRange;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGUtils._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGUtils, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v11 = (float)(m_occlusionRange + m_occlusionRange) / (float)m_occlusionMapSize;
			//     v12 = 1.0 / (float)m_occlusionMapSize;
			//     v13 = (float)m_occlusionMapSize;
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       byte_18D8EDC37 = 1;
			//     }
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v7.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_26;
			//     if ( wrapperArray.max_length.size <= 869 )
			//       goto LABEL_17;
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v7.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_26;
			//     if ( wrapperArray.max_length.size <= 0x365u )
			//       goto LABEL_48;
			//     if ( wrapperArray[24].vector[5] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(869, 0LL);
			//       if ( !Patch )
			//         goto LABEL_26;
			//       v17 = *(__m128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_336((Vector4 *)&v23, Patch, v13, v12, v11, 0LL);
			//     }
			//     else
			//     {
			// LABEL_17:
			//       v23.m128_i32[3] = 0;
			//       v14 = v23;
			//       v14.m128_f32[0] = v13;
			//       v15 = _mm_shuffle_ps(v14, v14, 225);
			//       v15.m128_f32[0] = v12;
			//       v16 = _mm_shuffle_ps(v15, v15, 198);
			//       v16.m128_f32[0] = v11;
			//       v17 = _mm_shuffle_ps(v16, v16, 201);
			//     }
			//     v18 = byte_18D8EDC37 == 0;
			//     *param = (Vector4)v17;
			//     if ( v18 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EDC37 = 1;
			//     }
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v7.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_26;
			//     if ( wrapperArray.max_length.size <= 781 )
			//     {
			// LABEL_24:
			//       v19 = this.fields.m_requestType > 0;
			// LABEL_25:
			//       *enabled = v19;
			//       return;
			//     }
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//     if ( !v7 )
			// LABEL_26:
			//       sub_180B536AC(v7, wrapperArray);
			//     if ( LODWORD(v7._0.namespaze) > 0x30D )
			//     {
			//       if ( !*(_QWORD *)&v7[16]._1.static_fields_size )
			//         goto LABEL_24;
			//       v22 = IFix::WrappersManagerImpl::GetPatch(781, 0LL);
			//       if ( v22 )
			//       {
			//         v19 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v22, (Object *)this, 0LL);
			//         goto LABEL_25;
			//       }
			//       goto LABEL_26;
			//     }
			// LABEL_48:
			//     sub_180070270(v7, wrapperArray);
			//   }
			//   v20 = IFix::WrappersManagerImpl::GetPatch(870, 0LL);
			//   if ( !v20 )
			//     goto LABEL_26;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_339(v20, (Object *)this, param, enabled, 0LL);
			// }
			// 
		}

		internal void UpdateOcclusionMapParamsAndRequests(bool enableCppPipelineOrRenderPath, HGCamera hgCamera, HGVerticalOcclusionMapSettingParameters settingParameters, long mgrCPP, CustomDepthOnlyRequestManager mgr)
		{
			// // Void UpdateOcclusionMapParamsAndRequests(Boolean, HGCamera, HGVerticalOcclusionMapSettingParameters, Int64, CustomDepthOnlyRequestManager)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::UpdateOcclusionMapParamsAndRequests(
			//         HGVerticalOcclusionMapManager *this,
			//         bool enableCppPipelineOrRenderPath,
			//         HGCamera *hgCamera,
			//         HGVerticalOcclusionMapSettingParameters *settingParameters,
			//         int64_t mgrCPP,
			//         CustomDepthOnlyRequestManager *mgr,
			//         MethodInfo *method)
			// {
			//   _QWORD **static_fields; // rcx
			//   _DWORD *wrapperArray; // rdx
			//   __int64 v13; // rdx
			//   void (__fastcall *v14)(int64_t, _QWORD, _QWORD); // rax
			//   uint32_t m_depthOnlySysCppHandle; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v17; // rax
			//   ILFixDynamicMethodWrapper_2 *v18; // rax
			//   _QWORD *v19; // rax
			//   ILFixDynamicMethodWrapper_2 *v20; // rax
			//   __int64 v21; // rax
			//   bool needRefresh; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   needRefresh = 0;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   static_fields = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, enableCppPipelineOrRenderPath);
			//     static_fields = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (_DWORD *)*static_fields[23];
			//   if ( !wrapperArray )
			//     goto LABEL_27;
			//   if ( (int)wrapperArray[6] > 771 )
			//   {
			//     if ( !*((_DWORD *)static_fields + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(static_fields, wrapperArray);
			//       static_fields = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = (_DWORD *)*static_fields[23];
			//     if ( !wrapperArray )
			//       goto LABEL_27;
			//     if ( wrapperArray[6] <= 0x303u )
			//       goto LABEL_56;
			//     if ( *((_QWORD *)wrapperArray + 775) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(771, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_299(
			//           Patch,
			//           (Object *)this,
			//           enableCppPipelineOrRenderPath,
			//           (Object *)hgCamera,
			//           (Object *)settingParameters,
			//           mgrCPP,
			//           (Object *)mgr,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_27;
			//     }
			//   }
			//   HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_UpdateQualitySettings(
			//     this,
			//     settingParameters,
			//     &needRefresh,
			//     0LL);
			//   if ( needRefresh )
			//     goto LABEL_26;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v13);
			//   static_fields = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_27;
			//   if ( (int)wrapperArray[6] > 774 )
			//   {
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//     v17 = *(_QWORD *)wrapperArray;
			//     if ( !*(_QWORD *)wrapperArray )
			//       goto LABEL_27;
			//     if ( *(_DWORD *)(v17 + 24) <= 0x306u )
			//       goto LABEL_56;
			//     if ( *(_QWORD *)(v17 + 6224) )
			//     {
			//       v18 = IFix::WrappersManagerImpl::GetPatch(774, 0LL);
			//       if ( !v18 )
			//         goto LABEL_27;
			//       if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_291(
			//               v18,
			//               (Object *)this,
			//               enableCppPipelineOrRenderPath,
			//               mgrCPP,
			//               (Object *)mgr,
			//               0LL) )
			//         goto LABEL_16;
			//       goto LABEL_26;
			//     }
			//   }
			//   if ( enableCppPipelineOrRenderPath )
			//   {
			//     if ( this.fields.m_depthOnlySysCppHandle != -1 )
			//       goto LABEL_16;
			//     goto LABEL_26;
			//   }
			//   if ( !mgr )
			//     goto LABEL_27;
			//   if ( !HG::Rendering::Runtime::CustomDepthOnlyRequestManager::IsValid(mgr, this.fields.m_depthOnlySysHandle, 0LL) )
			// LABEL_26:
			//     HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_RefreshOcclusionMapRequest(
			//       this,
			//       enableCppPipelineOrRenderPath,
			//       mgrCPP,
			//       mgr,
			//       0LL);
			// LABEL_16:
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//   static_fields = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   wrapperArray = TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_27;
			//   if ( (int)wrapperArray[6] <= 781 )
			//   {
			// LABEL_22:
			//     if ( this.fields.m_requestType <= 0 )
			//       goto LABEL_23;
			// LABEL_55:
			//     HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_RequestOcclusionMap(
			//       this,
			//       enableCppPipelineOrRenderPath,
			//       hgCamera,
			//       mgrCPP,
			//       mgr,
			//       0LL);
			//     return;
			//   }
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//   static_fields = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//   v19 = *static_fields;
			//   if ( !*static_fields )
			//     goto LABEL_27;
			//   if ( *((_DWORD *)v19 + 6) <= 0x30Du )
			// LABEL_56:
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v19[785] )
			//     goto LABEL_22;
			//   v20 = IFix::WrappersManagerImpl::GetPatch(781, 0LL);
			//   if ( !v20 )
			//     goto LABEL_27;
			//   if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v20, (Object *)this, 0LL) )
			//     goto LABEL_55;
			// LABEL_23:
			//   if ( !enableCppPipelineOrRenderPath )
			//   {
			//     if ( mgr )
			//     {
			//       HG::Rendering::Runtime::CustomDepthOnlyRequestManager::TogglePass(mgr, this.fields.m_depthOnlySysHandle, 0, 0LL);
			//       return;
			//     }
			// LABEL_27:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			//   v14 = (void (__fastcall *)(int64_t, _QWORD, _QWORD))qword_18D8F5858;
			//   m_depthOnlySysCppHandle = this.fields.m_depthOnlySysCppHandle;
			//   if ( !qword_18D8F5858 )
			//   {
			//     v14 = (void (__fastcall *)(int64_t, _QWORD, _QWORD))il2cpp_resolve_icall_0(
			//                                                           "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::CustomDepth"
			//                                                           "RequestManager_ToggleSystem(System.Int64,System.UInt32,System.Boolean)");
			//     if ( !v14 )
			//     {
			//       v21 = sub_1802DBBE8(
			//               "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::CustomDepthRequestManager_ToggleSystem(System.Int64,Sys"
			//               "tem.UInt32,System.Boolean)");
			//       sub_18000F750(v21, 0LL);
			//     }
			//     qword_18D8F5858 = (__int64)v14;
			//   }
			//   v14(mgrCPP, m_depthOnlySysCppHandle, 0LL);
			// }
			// 
		}

		internal void Dispose(CustomDepthOnlyRequestManager customDepthOnlyRequestMgr, long customDepthOnlyRequestMgrCPP)
		{
			// // Void Dispose(CustomDepthOnlyRequestManager, Int64)
			// void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::Dispose(
			//         HGVerticalOcclusionMapManager *this,
			//         CustomDepthOnlyRequestManager *customDepthOnlyRequestMgr,
			//         int64_t customDepthOnlyRequestMgrCPP,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(507, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(507, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_92(
			//       (ILFixDynamicMethodWrapper_14 *)Patch,
			//       (Object *)this,
			//       (Object *)customDepthOnlyRequestMgr,
			//       customDepthOnlyRequestMgrCPP,
			//       0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_DisposeCustomDepthOnlyRequestMgr(
			//       this,
			//       customDepthOnlyRequestMgr,
			//       0LL);
			//     HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_DisposeCustomDepthOnlyRequestMgrCpp(
			//       this,
			//       customDepthOnlyRequestMgrCPP,
			//       0LL);
			//   }
			// }
			// 
		}

		protected void _DisposeCustomDepthOnlyRequestMgr(CustomDepthOnlyRequestManager customDepthOnlyRequestMgr)
		{
			// // Void _DisposeCustomDepthOnlyRequestMgr(CustomDepthOnlyRequestManager)
			// void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_DisposeCustomDepthOnlyRequestMgr(
			//         HGVerticalOcclusionMapManager *this,
			//         CustomDepthOnlyRequestManager *customDepthOnlyRequestMgr,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(508, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(508, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)customDepthOnlyRequestMgr,
			//       0LL);
			//   }
			//   else if ( customDepthOnlyRequestMgr )
			//   {
			//     HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RemoveSystem(
			//       customDepthOnlyRequestMgr,
			//       this.fields.m_depthOnlySysHandle,
			//       0LL);
			//   }
			// }
			// 
		}

		protected void _DisposeCustomDepthOnlyRequestMgrCpp(long customDepthOnlyRequestMgrCPP)
		{
			// // Void _DisposeCustomDepthOnlyRequestMgrCpp(Int64)
			// void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_DisposeCustomDepthOnlyRequestMgrCpp(
			//         HGVerticalOcclusionMapManager *this,
			//         int64_t customDepthOnlyRequestMgrCPP,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(511, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(511, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_69(
			//       (ILFixDynamicMethodWrapper_14 *)Patch,
			//       (Object *)this,
			//       customDepthOnlyRequestMgrCPP,
			//       0LL);
			//   }
			//   else if ( this.fields.m_depthOnlySysCppHandle != -1 )
			//   {
			//     if ( customDepthOnlyRequestMgrCPP )
			//     {
			//       UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::CustomDepthRequestManager_RemoveSystem(
			//         customDepthOnlyRequestMgrCPP,
			//         this.fields.m_depthOnlySysCppHandle,
			//         0LL);
			//       this.fields.m_depthOnlySysCppHandle = -1;
			//     }
			//   }
			// }
			// 
		}

		internal void RegisterRequestUsage(HGVerticalOcclusionMapManager.RequestUsageType requestType)
		{
			// // Void RegisterRequestUsage(HGVerticalOcclusionMapManager+RequestUsageType)
			// void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::RegisterRequestUsage(
			//         HGVerticalOcclusionMapManager *this,
			//         HGVerticalOcclusionMapManager_RequestUsageType__Enum requestType,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(748, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(748, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       requestType,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_requestType |= requestType;
			//   }
			// }
			// 
		}

		internal void UnregisterRequestUsage(HGVerticalOcclusionMapManager.RequestUsageType requestType)
		{
			// // Void UnregisterRequestUsage(HGVerticalOcclusionMapManager+RequestUsageType)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::UnregisterRequestUsage(
			//         HGVerticalOcclusionMapManager *this,
			//         HGVerticalOcclusionMapManager_RequestUsageType__Enum requestType,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, *(_QWORD *)&requestType);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 749 )
			//   {
			// LABEL_7:
			//     this.fields.m_requestType &= ~requestType;
			//     return;
			//   }
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			//     goto LABEL_8;
			//   if ( LODWORD(v5._0.namespaze) <= 0x2ED )
			//     sub_180070270(v5, wrapperArray);
			//   if ( !v5[16]._0.gc_desc )
			//     goto LABEL_7;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(749, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v5, wrapperArray);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, requestType, 0LL);
			// }
			// 
		}

		private bool _ShouldRequestOcclusionMap()
		{
			// // Boolean _ShouldRequestOcclusionMap()
			// bool HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_ShouldRequestOcclusionMap(
			//         HGVerticalOcclusionMapManager *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 781 )
			//     return this.fields.m_requestType > 0;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v7 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_8;
			//   if ( v7.max_length.size <= 0x30Du )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v7[21].vector[25] )
			//     return this.fields.m_requestType > 0;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(781, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		private bool _HandleInValid(bool enableCppPipelineOrRenderPath, long mgrCPP, CustomDepthOnlyRequestManager mgr)
		{
			// // Boolean _HandleInValid(Boolean, Int64, CustomDepthOnlyRequestManager)
			// // local variable allocation has failed, the output may be wrong!
			// bool HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_HandleInValid(
			//         HGVerticalOcclusionMapManager *this,
			//         bool enableCppPipelineOrRenderPath,
			//         int64_t mgrCPP,
			//         CustomDepthOnlyRequestManager *mgr,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, enableCppPipelineOrRenderPath);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 774 )
			//   {
			//     if ( !v9._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v9, wrapperArray);
			//       v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v9 = (struct ILFixDynamicMethodWrapper_2__Class *)v9.static_fields.wrapperArray;
			//     if ( !v9 )
			//       goto LABEL_9;
			//     if ( LODWORD(v9._0.namespaze) <= 0x306 )
			//       sub_180070270(v9, wrapperArray);
			//     if ( v9[16]._1.unity_user_data )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(774, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_291(
			//                  Patch,
			//                  (Object *)this,
			//                  enableCppPipelineOrRenderPath,
			//                  mgrCPP,
			//                  (Object *)mgr,
			//                  0LL);
			// LABEL_9:
			//       sub_180B536AC(v9, wrapperArray);
			//     }
			//   }
			//   if ( enableCppPipelineOrRenderPath )
			//     return this.fields.m_depthOnlySysCppHandle == -1;
			//   if ( !mgr )
			//     goto LABEL_9;
			//   return !HG::Rendering::Runtime::CustomDepthOnlyRequestManager::IsValid(mgr, this.fields.m_depthOnlySysHandle, 0LL);
			// }
			// 
			return default(bool);
		}

		private void _RequestOcclusionMap(bool enableCppPipelineOrRenderPath, HGCamera hgCamera, long mgrCPP, CustomDepthOnlyRequestManager mgr)
		{
			// // Void _RequestOcclusionMap(Boolean, HGCamera, Int64, CustomDepthOnlyRequestManager)
			// void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_RequestOcclusionMap(
			//         HGVerticalOcclusionMapManager *this,
			//         bool enableCppPipelineOrRenderPath,
			//         HGCamera *hgCamera,
			//         int64_t mgrCPP,
			//         CustomDepthOnlyRequestManager *mgr,
			//         MethodInfo *method)
			// {
			//   Object_1 *camera; // rdi
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Transform *transform; // rax
			//   Vector3 *v14; // rax
			//   System::MathF *v15; // rcx
			//   float z; // r15d
			//   float v17; // xmm1_4
			//   int32_t index; // edx
			//   uint32_t m_depthOnlySysCppHandle; // edx
			//   Vector3 v20; // [rsp+40h] [rbp-20h] BYREF
			//   Vector3 position; // [rsp+50h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D9193EC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9193EC = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(782, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(782, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_298(
			//         Patch,
			//         (Object *)this,
			//         enableCppPipelineOrRenderPath,
			//         (Object *)hgCamera,
			//         mgrCPP,
			//         (Object *)mgr,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_16;
			//   }
			//   if ( !hgCamera )
			//     return;
			//   camera = (Object_1 *)hgCamera.fields.camera;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Inequality(camera, 0LL, 0LL) )
			//     return;
			//   if ( !camera || (transform = UnityEngine::Component::get_transform((Component *)camera, 0LL)) == 0LL )
			// LABEL_16:
			//     sub_180B536AC(Patch, v11);
			//   v14 = UnityEngine::Transform::get_position(&position, transform, 0LL);
			//   z = v14.z;
			//   *(_QWORD *)&v20.x = *(_QWORD *)&v14.x;
			//   v17 = fabs(v20.y - this.fields.m_depthOnlyYCache);
			//   if ( v17 > 1.0 )
			//   {
			//     System::MathF::Floor(v15, v17);
			//     this.fields.m_depthOnlyYCache = v20.y;
			//   }
			//   v20.y = this.fields.m_depthOnlyYCache;
			//   if ( enableCppPipelineOrRenderPath )
			//   {
			//     if ( mgrCPP )
			//     {
			//       UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::CustomDepthRequestManager_ToggleSystem(
			//         mgrCPP,
			//         this.fields.m_depthOnlySysCppHandle,
			//         1,
			//         0LL);
			//       m_depthOnlySysCppHandle = this.fields.m_depthOnlySysCppHandle;
			//       *(_QWORD *)&position.x = *(_QWORD *)&v20.x;
			//       position.z = z;
			//       UnityEngine::HyperGryphEngineCode::HGRenderGraphCPP::CustomDepthRequestManager_UpdateSystem_Injected(
			//         mgrCPP,
			//         m_depthOnlySysCppHandle,
			//         &position,
			//         0LL);
			//     }
			//   }
			//   else if ( mgr )
			//   {
			//     HG::Rendering::Runtime::CustomDepthOnlyRequestManager::TogglePass(mgr, this.fields.m_depthOnlySysHandle, 1, 0LL);
			//     index = this.fields.m_depthOnlySysHandle.index;
			//     v20.z = z;
			//     HG::Rendering::Runtime::CustomDepthOnlyRequestManager::UpdateSystem(
			//       mgr,
			//       (CustomDepthOnlyRequestManager_Handle)index,
			//       &v20,
			//       0LL);
			//   }
			// }
			// 
		}

		private void _RegisterOcclusionMapRequest(bool enableCppPipelineOrRenderPath, long mgrCPP, CustomDepthOnlyRequestManager mgr)
		{
			// // Void _RegisterOcclusionMapRequest(Boolean, Int64, CustomDepthOnlyRequestManager)
			// void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_RegisterOcclusionMapRequest(
			//         HGVerticalOcclusionMapManager *this,
			//         bool enableCppPipelineOrRenderPath,
			//         int64_t mgrCPP,
			//         CustomDepthOnlyRequestManager *mgr,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   struct HGVerticalOcclusionMapManager__Class *v10; // rcx
			//   float m_occlusionRange; // xmm6_4
			//   unsigned int *static_fields; // r8
			//   __m128i v13; // xmm0
			//   bool v14; // zf
			//   int32_t m_occlusionMapSize; // eax
			//   int v16; // eax
			//   int32_t v17; // eax
			//   int32_t v18; // eax
			//   struct HGShaderIDs__Class *v19; // rdx
			//   HGShaderIDs__StaticFields *v20; // rax
			//   int32_t VerticalOcclusionMapTransformCB; // ecx
			//   __int64 (__fastcall *v22)(int64_t, CustomDepthOnlyRequestManager_Request *); // rax
			//   struct HGVerticalOcclusionMapManager__Class *v23; // r8
			//   float v24; // xmm6_4
			//   unsigned int *v25; // rax
			//   unsigned int *v26; // rcx
			//   __m128i v27; // xmm0
			//   int32_t v28; // edx
			//   int32_t v29; // edx
			//   struct HGShaderIDs__Class *v30; // rdx
			//   HGShaderIDs__StaticFields *v31; // rax
			//   __int64 v32; // rax
			//   __int64 v33; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_VSMSupport_ v35; // [rsp+30h] [rbp-D0h] BYREF
			//   CustomDepthOnlyRequestManager_Request v36; // [rsp+38h] [rbp-C8h]
			//   CustomDepthOnlyRequestManager_Request request; // [rsp+78h] [rbp-88h] BYREF
			//   CustomDepthOnlyRequestManager_Request v38; // [rsp+B8h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D8ED970 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::Handle>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::Handle>::get_Value);
			//     byte_18D8ED970 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(776, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(776, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v33);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_295(
			//       Patch,
			//       (Object *)this,
			//       enableCppPipelineOrRenderPath,
			//       mgrCPP,
			//       (Object *)mgr,
			//       0LL);
			//   }
			//   else if ( enableCppPipelineOrRenderPath )
			//   {
			//     if ( mgrCPP )
			//     {
			//       v10 = TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager;
			//       m_occlusionRange = this.fields.m_occlusionRange;
			//       *(_QWORD *)&v36.rootPosition.x = 0LL;
			//       v36.rootPosition.z = 0.0;
			//       *(_WORD *)(&v36.includeDynamicObjects + 1) = 0;
			//       *(&v36.includeDynamicObjects + 3) = 0;
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager, v9);
			//         v10 = TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager;
			//       }
			//       static_fields = (unsigned int *)v10.static_fields;
			//       v13 = _mm_cvtsi32_si128(*static_fields);
			//       v14 = static_fields[1] == 8;
			//       *(_DWORD *)&v35.hasValue = this.fields.m_occlusionMapSize;
			//       v35.value.shaderID = *(_DWORD *)&v35.hasValue;
			//       v36.rtSize = (Vector2Int)v35;
			//       m_occlusionMapSize = this.fields.m_occlusionMapSize;
			//       v36.frustumSize.x = m_occlusionRange + m_occlusionRange;
			//       LODWORD(v36.frustumSize.z) = _mm_cvtepi32_ps(v13).m128_u32[0];
			//       v36.frustumSize.y = m_occlusionRange + m_occlusionRange;
			//       if ( v14 )
			//         v16 = m_occlusionMapSize / 8;
			//       else
			//         v16 = m_occlusionMapSize / (int)static_fields[1];
			//       v14 = static_fields[1] == 8;
			//       *(_DWORD *)&v35.hasValue = v16;
			//       v17 = this.fields.m_occlusionMapSize;
			//       if ( v14 )
			//         v18 = v17 / 8;
			//       else
			//         v18 = v17 / (int)static_fields[1];
			//       v19 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//       v35.value.shaderID = v18;
			//       v36.pageSize = (Vector2Int)v35;
			//       v14 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs._1.cctor_finished_or_no_cctor == 0;
			//       *(_QWORD *)&v36.depthBits = 0x5D00000020LL;
			//       if ( v14 )
			//       {
			//         il2cpp_runtime_class_init_0(
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         v19 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//       }
			//       v20 = v19.static_fields;
			//       v36.includeDynamicObjects = 1;
			//       v36.depthRTShaderID = v20._VerticalOcclusionMap;
			//       VerticalOcclusionMapTransformCB = v20._VerticalOcclusionMapTransformCB;
			//       v38 = v36;
			//       v22 = (__int64 (__fastcall *)(int64_t, CustomDepthOnlyRequestManager_Request *))qword_18D8F5848;
			//       v36.transformCBShaderID = VerticalOcclusionMapTransformCB;
			//       if ( !qword_18D8F5848 )
			//       {
			//         v22 = (__int64 (__fastcall *)(int64_t, CustomDepthOnlyRequestManager_Request *))il2cpp_resolve_icall_0(
			//                                                                                           "UnityEngine.HyperGryphEngineCo"
			//                                                                                           "de.HGRenderGraphCPP::CustomDep"
			//                                                                                           "thRequestManager_RequestSystem"
			//                                                                                           "(System.Int64,UnityEngine.Hype"
			//                                                                                           "rGryphEngineCode.CustomDepthOn"
			//                                                                                           "lySystemRequest*)");
			//         if ( !v22 )
			//         {
			//           v32 = sub_1802DBBE8(
			//                   "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::CustomDepthRequestManager_RequestSystem(System.Int6"
			//                   "4,UnityEngine.HyperGryphEngineCode.CustomDepthOnlySystemRequest*)");
			//           sub_18000F750(v32, 0LL);
			//         }
			//         qword_18D8F5848 = (__int64)v22;
			//       }
			//       this.fields.m_depthOnlySysCppHandle = v22(mgrCPP, &v38);
			//     }
			//   }
			//   else if ( mgr )
			//   {
			//     v23 = TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager;
			//     v24 = this.fields.m_occlusionRange;
			//     *(_QWORD *)&v36.rootPosition.x = 0LL;
			//     v36.rootPosition.z = 0.0;
			//     *(_WORD *)(&v36.includeDynamicObjects + 1) = 0;
			//     *(&v36.includeDynamicObjects + 3) = 0;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager, v9);
			//       v23 = TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapManager;
			//     }
			//     v25 = (unsigned int *)v23.static_fields;
			//     v26 = v25;
			//     *(_QWORD *)&v36.depthBits = 0x5D00000020LL;
			//     v27 = _mm_cvtsi32_si128(*v25);
			//     *(_DWORD *)&v35.hasValue = this.fields.m_occlusionMapSize;
			//     v35.value.shaderID = *(_DWORD *)&v35.hasValue;
			//     v36.rtSize = (Vector2Int)v35;
			//     v28 = this.fields.m_occlusionMapSize >> 31;
			//     LODWORD(v25) = this.fields.m_occlusionMapSize;
			//     v36.frustumSize.x = v24 + v24;
			//     *(_DWORD *)&v35.hasValue = __SPAIR64__(v28, (unsigned int)v25) / (int)v26[1];
			//     v29 = this.fields.m_occlusionMapSize >> 31;
			//     LODWORD(v25) = this.fields.m_occlusionMapSize;
			//     v36.frustumSize.y = v24 + v24;
			//     LODWORD(v25) = __SPAIR64__(v29, (unsigned int)v25) / (int)v26[1];
			//     v30 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//     v35.value.shaderID = (int)v25;
			//     v36.pageSize = (Vector2Int)v35;
			//     v14 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs._1.cctor_finished_or_no_cctor == 0;
			//     LODWORD(v36.frustumSize.z) = _mm_cvtepi32_ps(v27).m128_u32[0];
			//     if ( v14 )
			//     {
			//       il2cpp_runtime_class_init_0(
			//         TypeInfo::HG::Rendering::Runtime::HGShaderIDs,
			//         TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       v30 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs;
			//     }
			//     v31 = v30.static_fields;
			//     v36.includeDynamicObjects = 1;
			//     *(_QWORD *)&v36.depthRTShaderID = *(_QWORD *)&v31._VerticalOcclusionMap;
			//     request = v36;
			//     v35 = (Nullable_1_HG_Rendering_Runtime_CustomDepthOnlyRequestManager_VSMSupport_)HG::Rendering::Runtime::CustomDepthOnlyRequestManager::RequestCustomDepthOnlyPassV1(
			//                                                                                        mgr,
			//                                                                                        &request,
			//                                                                                        0LL);
			//     if ( v35.hasValue )
			//       this.fields.m_depthOnlySysHandle.index = System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::VSMSupport>::get_Value(
			//                                                   &v35,
			//                                                   MethodInfo::System::Nullable<HG::Rendering::Runtime::CustomDepthOnlyRequestManager::Handle>::get_Value).shaderID;
			//   }
			// }
			// 
		}

		private void _UpdateQualitySettings(HGVerticalOcclusionMapSettingParameters settingParameters, out bool needRefresh)
		{
			// // Void _UpdateQualitySettings(HGVerticalOcclusionMapSettingParameters, Boolean ByRef)
			// void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_UpdateQualitySettings(
			//         HGVerticalOcclusionMapManager *this,
			//         HGVerticalOcclusionMapSettingParameters *settingParameters,
			//         bool *needRefresh,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   SettingParameter_1_System_Int32_ *DepthOcclusionMapRange_k__BackingField; // rdi
			//   struct MethodInfo *v10; // rbp
			//   Il2CppClass *klass; // rax
			//   SettingParameter_1_System_Int32_ *DepthOcclusionMapSize_k__BackingField; // rdi
			//   struct MethodInfo *v13; // rbp
			//   Il2CppClass *v14; // rax
			//   bool v15; // al
			//   SettingParameter_1_System_Int32_ *v16; // rbp
			//   struct MethodInfo *v17; // rdi
			//   Il2CppClass *v18; // rax
			//   SettingParameter_1_System_Int32_ *v19; // rbx
			//   struct MethodInfo *v20; // rdi
			//   Il2CppClass *v21; // rax
			//   Il2CppClass *v22; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v24; // rax
			//   __int64 v25; // rax
			//   __int64 v26; // rax
			//   __int64 v27; // rax
			// 
			//   if ( !byte_18D8ED971 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     byte_18D8ED971 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, settingParameters);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_43;
			//   if ( wrapperArray.max_length.size > 772 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//     if ( !v7 )
			//       goto LABEL_43;
			//     if ( LODWORD(v7._0.namespaze) <= 0x304 )
			//       sub_180070270(v7, wrapperArray);
			//     if ( v7[16].rgctx_data )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(772, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_290(
			//           Patch,
			//           (Object *)this,
			//           (Object *)settingParameters,
			//           needRefresh,
			//           0LL);
			//         return;
			//       }
			//       goto LABEL_43;
			//     }
			//   }
			//   if ( !settingParameters )
			//     goto LABEL_43;
			//   DepthOcclusionMapRange_k__BackingField = settingParameters.fields._DepthOcclusionMapRange_k__BackingField;
			//   v10 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !DepthOcclusionMapRange_k__BackingField )
			//     goto LABEL_43;
			//   klass = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)klass.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v24 = sub_18010B520(v10.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v24 + 192) + 48LL))();
			//   }
			//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v10.klass;
			//   if ( ((__int64)v7.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v7);
			//   if ( (float)DepthOcclusionMapRange_k__BackingField.fields._paramValue_k__BackingField != this.fields.m_occlusionRange )
			//     goto LABEL_42;
			//   DepthOcclusionMapSize_k__BackingField = settingParameters.fields._DepthOcclusionMapSize_k__BackingField;
			//   v13 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !DepthOcclusionMapSize_k__BackingField )
			//     goto LABEL_43;
			//   v14 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v14.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v14.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v25 = sub_18010B520(v13.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v25 + 192) + 48LL))();
			//   }
			//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v13.klass;
			//   if ( ((__int64)v7.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v7);
			//   if ( this.fields.m_occlusionMapSize == DepthOcclusionMapSize_k__BackingField.fields._paramValue_k__BackingField )
			//     v15 = 0;
			//   else
			// LABEL_42:
			//     v15 = 1;
			//   *needRefresh = v15;
			//   v16 = settingParameters.fields._DepthOcclusionMapRange_k__BackingField;
			//   v17 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !v16 )
			//     goto LABEL_43;
			//   v18 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v18.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v18.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v26 = sub_18010B520(v17.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v26 + 192) + 48LL))();
			//   }
			//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v17.klass;
			//   if ( ((__int64)v7.vtable.Equals.methodPtr & 1) == 0 )
			//     sub_18003C700(v7);
			//   this.fields.m_occlusionRange = (float)v16.fields._paramValue_k__BackingField;
			//   v19 = settingParameters.fields._DepthOcclusionMapSize_k__BackingField;
			//   v20 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit;
			//   if ( !v19 )
			// LABEL_43:
			//     sub_180B536AC(v7, wrapperArray);
			//   v21 = MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass;
			//   if ( ((__int64)v21.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit.klass);
			//   if ( !*((_QWORD *)v21.rgctx_data[6].rgctxDataDummy + 4) )
			//   {
			//     v27 = sub_18010B520(v20.klass);
			//     (**(void (***)(void))(*(_QWORD *)(v27 + 192) + 48LL))();
			//   }
			//   v22 = v20.klass;
			//   if ( ((__int64)v22.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v22);
			//   this.fields.m_occlusionMapSize = v19.fields._paramValue_k__BackingField;
			// }
			// 
		}

		private void _RefreshOcclusionMapRequest(bool enableCppPipelineOrRenderPath, long mgrCPP, CustomDepthOnlyRequestManager mgr)
		{
			// // Void _RefreshOcclusionMapRequest(Boolean, Int64, CustomDepthOnlyRequestManager)
			// void HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_RefreshOcclusionMapRequest(
			//         HGVerticalOcclusionMapManager *this,
			//         bool enableCppPipelineOrRenderPath,
			//         int64_t mgrCPP,
			//         CustomDepthOnlyRequestManager *mgr,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(775, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(775, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_295(
			//       Patch,
			//       (Object *)this,
			//       enableCppPipelineOrRenderPath,
			//       mgrCPP,
			//       (Object *)mgr,
			//       0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_DisposeCustomDepthOnlyRequestMgrCpp(this, mgrCPP, 0LL);
			//     HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_DisposeCustomDepthOnlyRequestMgr(this, mgr, 0LL);
			//     HG::Rendering::Runtime::HGVerticalOcclusionMapManager::_RegisterOcclusionMapRequest(
			//       this,
			//       enableCppPipelineOrRenderPath,
			//       mgrCPP,
			//       mgr,
			//       0LL);
			//   }
			// }
			// 
		}

		private const float s_snappedYThreshold = 1f;

		private HGVerticalOcclusionMapManager.RequestUsageType m_requestType;

		private CustomDepthOnlyRequestManager.Handle m_depthOnlySysHandle;

		private uint m_depthOnlySysCppHandle;

		private float m_depthOnlyYCache;

		private float m_occlusionRange;

		private int m_occlusionMapSize;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly int OCCLUSION_MAP_HEIGHT;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x04")]
		private static readonly int OCCLUSION_MAP_PAGE_ROWCOLUMN_COUNT;

		[Flags]
		public enum RequestUsageType
		{
			None = 0,
			RainWetnessOcclusion = 1,
			ScanlineHighlight = 2,
			SnowOcclusion = 4
		}
	}
}
