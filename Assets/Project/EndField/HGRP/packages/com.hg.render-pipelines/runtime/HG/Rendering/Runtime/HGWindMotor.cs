using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[ExecuteAlways]
	public class HGWindMotor : VFXPlayableMonoBase
	{
		public HGWindMotor()
		{
			// // HGWindMotor()
			// void HG::Rendering::Runtime::HGWindMotor::HGWindMotor(HGWindMotor *this, MethodInfo *method)
			// {
			//   __int128 v2; // [rsp+20h] [rbp-48h]
			//   __int128 v3; // [rsp+30h] [rbp-38h]
			// 
			//   *(_QWORD *)((char *)&v2 + 4) = 0LL;
			//   LODWORD(v2) = 0;
			//   *(_WORD *)((char *)&v3 + 9) = 0;
			//   BYTE11(v3) = 0;
			//   BYTE8(v3) = 0;
			//   HIDWORD(v2) = 1065353216;
			//   HIDWORD(v3) = 1065353216;
			//   *(_OWORD *)&this.fields.data.windPriority = v2;
			//   *(_QWORD *)&v3 = 0x3F8000003F800000LL;
			//   this.fields._.m_isPlaying = 1;
			//   *(_OWORD *)&this.fields.data.width = v3;
			//   *(_OWORD *)&this.fields.data.angle = 0x41A0000043B40000uLL;
			//   this.fields.data.distanceToCamera = INFINITY;
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		protected override void OnPlay()
		{
			// // Void OnPlay()
			// void HG::Rendering::Runtime::HGWindMotor::OnPlay(HGWindMotor *this, MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v4; // rdx
			//   HGWindManager *windManager_k__BackingField; // rcx
			//   HGManagerContext *v6; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1440, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1440, 0LL);
			//     if ( !Patch )
			//       goto LABEL_3;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( !currentManagerContext )
			//       goto LABEL_3;
			//     if ( currentManagerContext.fields._windManager_k__BackingField )
			//     {
			//       v6 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//       if ( v6 )
			//       {
			//         windManager_k__BackingField = v6.fields._windManager_k__BackingField;
			//         if ( windManager_k__BackingField )
			//         {
			//           HG::Rendering::Runtime::HGWindManager::RegisterWindMotor(windManager_k__BackingField, this, 0LL);
			//           return;
			//         }
			//       }
			// LABEL_3:
			//       sub_180B536AC(windManager_k__BackingField, v4);
			//     }
			//   }
			// }
			// 
		}

		protected override void OnStop()
		{
			// // Void OnStop()
			// void HG::Rendering::Runtime::HGWindMotor::OnStop(HGWindMotor *this, MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v4; // rdx
			//   HGWindManager *windManager_k__BackingField; // rcx
			//   HGManagerContext *v6; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1441, 0LL) )
			//   {
			//     if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//       return;
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       if ( !currentManagerContext.fields._windManager_k__BackingField )
			//         return;
			//       this.fields.data.motorInfo = -1;
			//       v6 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//       if ( v6 )
			//       {
			//         windManager_k__BackingField = v6.fields._windManager_k__BackingField;
			//         if ( windManager_k__BackingField )
			//         {
			//           HG::Rendering::Runtime::HGWindManager::UnRegisterWindMotor(windManager_k__BackingField, this, 0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(windManager_k__BackingField, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1441, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void OnDestroy()
		{
			// // Void OnDestroy()
			// void HG::Rendering::Runtime::HGWindMotor::OnDestroy(HGWindMotor *this, MethodInfo *method)
			// {
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v4; // rdx
			//   HGWindManager *windManager_k__BackingField; // rcx
			//   HGManagerContext *v6; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1442, 0LL) )
			//   {
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       if ( !currentManagerContext.fields._windManager_k__BackingField )
			//         return;
			//       v6 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//       if ( v6 )
			//       {
			//         windManager_k__BackingField = v6.fields._windManager_k__BackingField;
			//         if ( windManager_k__BackingField )
			//         {
			//           HG::Rendering::Runtime::HGWindManager::UnRegisterWindMotor(windManager_k__BackingField, this, 0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(windManager_k__BackingField, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1442, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public Vector3 GetDirection()
		{
			// // Vector3 GetDirection()
			// Vector3 *HG::Rendering::Runtime::HGWindMotor::GetDirection(
			//         Vector3 *__return_ptr retstr,
			//         HGWindMotor *this,
			//         MethodInfo *method)
			// {
			//   __m128 v5; // xmm6
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 (__fastcall *v8)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
			//   __int64 v9; // rdi
			//   void (__fastcall *v10)(__int64, Quaternion *); // rax
			//   Vector3 *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // r8
			//   __m128 v14; // xmm8
			//   float z; // xmm7_4
			//   struct Math__Class *v16; // rcx
			//   __m128d v17; // xmm2
			//   double v18; // xmm0_8
			//   float v19; // xmm0_4
			//   __m128 v20; // xmm1
			//   Vector3 *result; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 *v23; // rax
			//   __int64 v24; // xmm0_8
			//   __int64 v25; // rax
			//   __int64 v26; // rax
			//   Vector3 v27; // [rsp+20h] [rbp-68h] BYREF
			//   Quaternion v28; // [rsp+30h] [rbp-58h] BYREF
			//   Quaternion v29; // [rsp+40h] [rbp-48h] BYREF
			// 
			//   v5 = 0LL;
			//   *(_QWORD *)&v27.x = 0LL;
			//   v27.z = 0.0;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_23;
			//   if ( wrapperArray.max_length.size <= 851 )
			//     goto LABEL_7;
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v6, wrapperArray);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6.static_fields.wrapperArray;
			//   if ( !v6 )
			// LABEL_23:
			//     sub_180B536AC(v6, wrapperArray);
			//   if ( LODWORD(v6._0.namespaze) <= 0x353 )
			//     sub_180070270(v6, wrapperArray);
			//   if ( v6[18]._0.castClass )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(851, 0LL);
			//     if ( Patch )
			//     {
			//       v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_328(&v27, Patch, (Object *)this, 0LL);
			//       v24 = *(_QWORD *)&v23.x;
			//       *(float *)&v23 = v23.z;
			//       *(_QWORD *)&retstr.x = v24;
			//       LODWORD(retstr.z) = (_DWORD)v23;
			//       return retstr;
			//     }
			//     goto LABEL_23;
			//   }
			// LABEL_7:
			//   v8 = (__int64 (__fastcall *)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18D8F4D40;
			//   if ( !qword_18D8F4D40 )
			//   {
			//     v8 = (__int64 (__fastcall *)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//     if ( !v8 )
			//     {
			//       v25 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//       sub_18000F750(v25, 0LL);
			//     }
			//     qword_18D8F4D40 = (__int64)v8;
			//   }
			//   v9 = v8(this, wrapperArray, method);
			//   if ( !v9 )
			//     goto LABEL_23;
			//   v10 = (void (__fastcall *)(__int64, Quaternion *))qword_18D8F5300;
			//   v28 = 0LL;
			//   if ( !qword_18D8F5300 )
			//   {
			//     v10 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_0(
			//                                                         "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//     if ( !v10 )
			//     {
			//       v26 = sub_1802DBBE8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
			//       sub_18000F750(v26, 0LL);
			//     }
			//     qword_18D8F5300 = (__int64)v10;
			//   }
			//   v10(v9, &v28);
			//   v27.z = 1.0;
			//   *(_QWORD *)&v27.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   v29 = v28;
			//   v11 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v28, &v29, &v27, 0LL);
			//   v14 = (__m128)*(unsigned __int64 *)&v11.x;
			//   z = v11.z;
			//   if ( v14.m128_f32[0] != 0.0 || z != 0.0 )
			//   {
			//     if ( !byte_18D8E3A70 )
			//     {
			//       sub_18003C530(&TypeInfo::System::Math);
			//       byte_18D8E3A70 = 1;
			//     }
			//     v16 = TypeInfo::System::Math;
			//     if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::System::Math, v12);
			//     v17 = 0LL;
			//     v17.m128d_f64[0] = (float)((float)((float)(v14.m128_f32[0] * v14.m128_f32[0]) + 0.0) + (float)(z * z));
			//     if ( v17.m128d_f64[0] < 0.0 )
			//       v18 = sub_1801C22C0(v16, v12, v13);
			//     else
			//       *(_QWORD *)&v18 = *(_OWORD *)&_mm_sqrt_pd(v17);
			//     v19 = v18;
			//     v20 = 0LL;
			//     if ( v19 <= 0.0000099999997 )
			//     {
			//       z = 0.0;
			//     }
			//     else
			//     {
			//       v14.m128_f32[0] = v14.m128_f32[0] / v19;
			//       v20.m128_f32[0] = 0.0 / v19;
			//       z = z / v19;
			//       v5 = v14;
			//     }
			//     v14 = v5;
			//     v5 = v20;
			//   }
			//   result = retstr;
			//   *(_QWORD *)&retstr.x = _mm_unpacklo_ps(v14, v5).m128_u64[0];
			//   retstr.z = z;
			//   return result;
			// }
			// 
			return null;
		}

		public Vector3 GetPosition()
		{
			// // Vector3 GetPosition()
			// Vector3 *HG::Rendering::Runtime::HGWindMotor::GetPosition(
			//         Vector3 *__return_ptr retstr,
			//         HGWindMotor *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 (__fastcall *v7)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
			//   __int64 v8; // rdi
			//   void (__fastcall *v9)(__int64, Vector3 *); // rax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 *v13; // rax
			//   __int64 v14; // xmm0_8
			//   __int64 v15; // rax
			//   __int64 v16; // rax
			//   Vector3 v17[2]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_12;
			//   if ( wrapperArray.max_length.size <= 845 )
			//     goto LABEL_7;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			// LABEL_12:
			//     sub_180B536AC(v5, wrapperArray);
			//   if ( LODWORD(v5._0.namespaze) <= 0x34D )
			//     sub_180070270(v5, wrapperArray);
			//   if ( v5[18]._0.namespaze )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(845, 0LL);
			//     if ( Patch )
			//     {
			//       v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_328(v17, Patch, (Object *)this, 0LL);
			//       v14 = *(_QWORD *)&v13.x;
			//       z = v13.z;
			//       *(_QWORD *)&retstr.x = v14;
			//       goto LABEL_11;
			//     }
			//     goto LABEL_12;
			//   }
			// LABEL_7:
			//   v7 = (__int64 (__fastcall *)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18D8F4D40;
			//   if ( !qword_18D8F4D40 )
			//   {
			//     v7 = (__int64 (__fastcall *)(HGWindMotor *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//     if ( !v7 )
			//     {
			//       v15 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//       sub_18000F750(v15, 0LL);
			//     }
			//     qword_18D8F4D40 = (__int64)v7;
			//   }
			//   v8 = v7(this, wrapperArray, method);
			//   if ( !v8 )
			//     goto LABEL_12;
			//   *(_QWORD *)&v17[0].x = 0LL;
			//   v17[0].z = 0.0;
			//   v9 = (void (__fastcall *)(__int64, Vector3 *))qword_18D8F52E0;
			//   if ( !qword_18D8F52E0 )
			//   {
			//     v9 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_0("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//     if ( !v9 )
			//     {
			//       v16 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v16, 0LL);
			//     }
			//     qword_18D8F52E0 = (__int64)v9;
			//   }
			//   v9(v8, v17);
			//   z = v17[0].z;
			//   *(_QWORD *)&retstr.x = *(_QWORD *)&v17[0].x;
			// LABEL_11:
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public Bounds GetBounds()
		{
			// // Bounds GetBounds()
			// Bounds *HG::Rendering::Runtime::HGWindMotor::GetBounds(
			//         Bounds *__return_ptr retstr,
			//         HGWindMotor *this,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v5; // rdx
			//   Vector3 *v6; // rax
			//   __int64 v7; // xmm1_8
			//   MethodInfo *v8; // r9
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm1_8
			//   Animator *v11; // rdx
			//   int32_t v12; // r8d
			//   MethodInfo *v13; // r9
			//   Vector3 *v14; // rax
			//   __int64 v15; // xmm1_8
			//   Transform *v16; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int128 v20; // xmm6
			//   __int128 v21; // xmm7
			//   __int128 v22; // xmm8
			//   __int128 v23; // xmm9
			//   Bounds *v24; // rax
			//   Transform *transform; // rax
			//   Vector3 *localScale; // rax
			//   __int64 v27; // xmm6_8
			//   float z; // ebx
			//   Vector3 *v29; // rax
			//   __int64 v30; // xmm0_8
			//   Vector3 *v31; // rax
			//   __int64 v32; // xmm7_8
			//   float v33; // r14d
			//   Transform *v34; // rax
			//   Vector3 *position; // rax
			//   __int64 v36; // xmm6_8
			//   float v37; // ebx
			//   Transform *v38; // rax
			//   Quaternion *rotation; // rax
			//   Matrix4x4 *v40; // rbx
			//   MethodInfo *v41; // rdx
			//   Vector3 *one; // rax
			//   float v43; // ecx
			//   MethodInfo *v44; // r9
			//   Vector3 *v45; // rax
			//   __int64 v46; // xmm1_8
			//   Animator *v47; // rdx
			//   int32_t v48; // r8d
			//   MethodInfo *v49; // r9
			//   Vector3 *Vector; // rax
			//   __int64 v51; // xmm1_8
			//   __int128 v52; // xmm0
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   __int128 v55; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v57; // xmm0
			//   __int64 v58; // xmm1_8
			//   Bounds *result; // rax
			//   Vector3 v60; // [rsp+30h] [rbp-D0h] BYREF
			//   Vector3 v61; // [rsp+40h] [rbp-C0h] BYREF
			//   Vector3 v62; // [rsp+50h] [rbp-B0h] BYREF
			//   Vector3 v63; // [rsp+60h] [rbp-A0h] BYREF
			//   Bounds v64; // [rsp+70h] [rbp-90h] BYREF
			//   Bounds v65; // [rsp+90h] [rbp-70h] BYREF
			//   Bounds v66; // [rsp+A8h] [rbp-58h] BYREF
			//   Matrix4x4 v67; // [rsp+C0h] [rbp-40h] BYREF
			//   Matrix4x4 v68[2]; // [rsp+100h] [rbp+0h] BYREF
			// 
			//   if ( !byte_18D919DD3 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919DD3 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1443, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1443, 0LL);
			//     if ( Patch )
			//     {
			//       v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_543(&v65, Patch, (Object *)this, 0LL);
			//       goto LABEL_15;
			//     }
			//     goto LABEL_13;
			//   }
			//   if ( !this.fields.data.shape )
			//   {
			//     transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     if ( transform )
			//     {
			//       localScale = UnityEngine::Transform::get_localScale(&v61, transform, 0LL);
			//       v27 = *(_QWORD *)&localScale.x;
			//       z = localScale.z;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       *(_QWORD *)&v60.x = v27;
			//       v60.z = z;
			//       v29 = HG::Rendering::Runtime::HGUtils::Abs(&v61, &v60, 0LL);
			//       v30 = *(_QWORD *)&v29.x;
			//       *(float *)&v29 = v29.z;
			//       *(_QWORD *)&v60.x = v30;
			//       LODWORD(v60.z) = (_DWORD)v29;
			//       *(float *)&v30 = HG::Rendering::Runtime::HGEnvironmentUtils::MaxComponent(&v60, 0LL);
			//       v31 = HG::Rendering::Runtime::VectorSwizzleUtils::xxx(&v61, *(float *)&v30, 0LL);
			//       v32 = *(_QWORD *)&v31.x;
			//       v33 = v31.z;
			//       v34 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( v34 )
			//       {
			//         position = UnityEngine::Transform::get_position(&v61, v34, 0LL);
			//         v36 = *(_QWORD *)&position.x;
			//         v37 = position.z;
			//         v38 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//         if ( v38 )
			//         {
			//           *(_QWORD *)&v60.x = v32;
			//           v60.z = v33;
			//           rotation = UnityEngine::Transform::get_rotation((Quaternion *)&v64, v38, 0LL);
			//           *(_QWORD *)&v62.x = v36;
			//           v62.z = v37;
			//           *(Quaternion *)&v64.m_Center.x = *rotation;
			//           v40 = UnityEngine::Matrix4x4::TRS(v68, &v62, (Quaternion *)&v64, &v60, 0LL);
			//           one = UnityEngine::Vector3::get_one(&v61, v41);
			//           memset(&v65, 0, sizeof(v65));
			//           v43 = one.z;
			//           *(_QWORD *)&v63.x = *(_QWORD *)&one.x;
			//           v63.z = v43;
			//           v45 = UnityEngine::Vector3::op_Multiply(&v61, 2.0, &v63, v44);
			//           v46 = *(_QWORD *)&v45.x;
			//           *(float *)&v45 = v45.z;
			//           *(_QWORD *)&v63.x = v46;
			//           LODWORD(v63.z) = (_DWORD)v45;
			//           Vector = UnityEngine::Animator::GetVector(&v66.m_Center, v47, v48, v49);
			//           v51 = *(_QWORD *)&Vector.x;
			//           *(float *)&Vector = Vector.z;
			//           *(_QWORD *)&v61.x = v51;
			//           LODWORD(v61.z) = (_DWORD)Vector;
			//           UnityEngine::Bounds::Bounds(&v65, &v61, &v63, 0LL);
			//           *(_OWORD *)&v66.m_Center.x = *(_OWORD *)&v65.m_Center.x;
			//           v52 = *(_OWORD *)&v40.m00;
			//           *(_QWORD *)&v66.m_Extents.y = *(_QWORD *)&v65.m_Extents.y;
			//           v53 = *(_OWORD *)&v40.m01;
			//           *(_OWORD *)&v67.m00 = v52;
			//           v54 = *(_OWORD *)&v40.m02;
			//           *(_OWORD *)&v67.m01 = v53;
			//           v55 = *(_OWORD *)&v40.m03;
			//           *(_OWORD *)&v67.m02 = v54;
			//           *(_OWORD *)&v67.m03 = v55;
			//           goto LABEL_7;
			//         }
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v18, v17);
			//   }
			//   v6 = UnityEngine::Vector3::get_one(&v61, v5);
			//   memset(&v64, 0, sizeof(v64));
			//   v7 = *(_QWORD *)&v6.x;
			//   v62.z = v6.z;
			//   *(_QWORD *)&v62.x = v7;
			//   v9 = UnityEngine::Vector3::op_Multiply(&v61, 2.0, &v62, v8);
			//   v10 = *(_QWORD *)&v9.x;
			//   *(float *)&v9 = v9.z;
			//   *(_QWORD *)&v62.x = v10;
			//   LODWORD(v62.z) = (_DWORD)v9;
			//   v14 = UnityEngine::Animator::GetVector(&v61, v11, v12, v13);
			//   v15 = *(_QWORD *)&v14.x;
			//   *(float *)&v14 = v14.z;
			//   *(_QWORD *)&v60.x = v15;
			//   LODWORD(v60.z) = (_DWORD)v14;
			//   UnityEngine::Bounds::Bounds(&v64, &v60, &v62, 0LL);
			//   v66 = v64;
			//   v16 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   if ( !v16 )
			//     goto LABEL_13;
			//   localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v67, v16, 0LL);
			//   v20 = *(_OWORD *)&localToWorldMatrix.m00;
			//   v21 = *(_OWORD *)&localToWorldMatrix.m01;
			//   v22 = *(_OWORD *)&localToWorldMatrix.m02;
			//   v23 = *(_OWORD *)&localToWorldMatrix.m03;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//   *(_OWORD *)&v67.m00 = v20;
			//   *(_OWORD *)&v67.m01 = v21;
			//   *(_OWORD *)&v67.m02 = v22;
			//   *(_OWORD *)&v67.m03 = v23;
			// LABEL_7:
			//   v24 = HG::Rendering::Runtime::HGUtils::TransformBounds(&v65, &v66, &v67, 0LL);
			// LABEL_15:
			//   v57 = *(_OWORD *)&v24.m_Center.x;
			//   v58 = *(_QWORD *)&v24.m_Extents.y;
			//   result = retstr;
			//   *(_OWORD *)&retstr.m_Center.x = v57;
			//   *(_QWORD *)&retstr.m_Extents.y = v58;
			//   return result;
			// }
			// 
			return null;
		}

		private void OnDrawGizmos()
		{
			// // Void OnDrawGizmos()
			// void HG::Rendering::Runtime::HGWindMotor::OnDrawGizmos(HGWindMotor *this, MethodInfo *method)
			// {
			//   Transform *transform; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Vector3 *position; // rax
			//   float radius; // xmm1_4
			//   __int64 v8; // xmm0_8
			//   Transform *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Vector3 *v12; // rax
			//   float rangeIn; // xmm1_4
			//   __int64 v14; // xmm0_8
			//   MethodInfo *v15; // rdx
			//   Transform *v16; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   Vector3 *v19; // rax
			//   float v20; // xmm1_4
			//   __int64 v21; // xmm0_8
			//   Transform *v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   Vector3 *v25; // rax
			//   float v26; // xmm1_4
			//   __int64 v27; // xmm0_8
			//   Transform *v28; // rax
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   Vector3 *v31; // rax
			//   float z; // r14d
			//   __int64 v33; // xmm10_8
			//   float v34; // xmm7_4
			//   float v35; // xmm8_4
			//   int v36; // esi
			//   Transform *v37; // rax
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   Vector3 *forward; // rax
			//   float v41; // ebx
			//   __int64 v42; // xmm6_8
			//   Matrix4x4 *v43; // rax
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   Vector3 *v47; // rax
			//   MethodInfo *v48; // r9
			//   __int64 v49; // xmm0_8
			//   Vector3 *v50; // rax
			//   float *v51; // r8
			//   __int64 v52; // xmm0_8
			//   __int64 v53; // xmm3_8
			//   MethodInfo *v54; // r9
			//   Vector3 *v55; // rax
			//   __int64 v56; // xmm3_8
			//   MethodInfo *v57; // r9
			//   Vector3 *v58; // rax
			//   __int64 v59; // xmm3_8
			//   MethodInfo *v60; // r9
			//   Vector3 *v61; // rax
			//   Vector3 *v62; // r8
			//   Vector3 *v63; // rdx
			//   __int64 v64; // xmm3_8
			//   Vector3 *v65; // rax
			//   float *v66; // r8
			//   __int64 v67; // xmm0_8
			//   __int64 v68; // xmm3_8
			//   MethodInfo *v69; // r9
			//   Vector3 *v70; // rax
			//   __int64 v71; // xmm3_8
			//   MethodInfo *v72; // r9
			//   Vector3 *v73; // rax
			//   __int64 v74; // xmm3_8
			//   MethodInfo *v75; // r9
			//   Vector3 *v76; // rax
			//   __int64 v77; // xmm3_8
			//   Transform *v78; // rax
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int128 v80; // xmm1
			//   __int128 v81; // xmm0
			//   __int128 v82; // xmm1
			//   MethodInfo *v83; // rdx
			//   Vector3 *v84; // rdx
			//   Vector3 *v85; // rcx
			//   Animator *v86; // rdx
			//   int32_t v87; // r8d
			//   MethodInfo *v88; // r9
			//   Vector3 *Vector; // rax
			//   __int64 v90; // xmm1_8
			//   MethodInfo *v91; // rdx
			//   Animator *v92; // rdx
			//   int32_t v93; // r8d
			//   MethodInfo *v94; // r9
			//   Vector3 *v95; // rax
			//   __int64 v96; // xmm1_8
			//   Animator *v97; // rdx
			//   int32_t v98; // r8d
			//   MethodInfo *v99; // r9
			//   Vector3 *v100; // rax
			//   __int64 v101; // xmm1_8
			//   _OWORD *v102; // rax
			//   __int128 v103; // xmm1
			//   __int128 v104; // xmm0
			//   __int128 v105; // xmm1
			//   Transform *v106; // rax
			//   __int64 v107; // rdx
			//   __int64 v108; // rcx
			//   Vector3 *v109; // rax
			//   __int64 v110; // xmm11_8
			//   float v111; // r12d
			//   Vector3 *Direction; // rax
			//   __int64 v113; // xmm6_8
			//   float v114; // ebx
			//   Transform *v115; // rax
			//   float v116; // xmm8_4
			//   float v117; // xmm13_4
			//   Transform *v118; // rax
			//   float v119; // xmm7_4
			//   Transform *v120; // rax
			//   Vector3 *localScale; // rax
			//   MethodInfo *v122; // r9
			//   int v123; // esi
			//   int v124; // r14d
			//   unsigned __int64 v125; // xmm10_8
			//   float v126; // xmm9_4
			//   Vector3 *v127; // rax
			//   __int64 v128; // xmm3_8
			//   MethodInfo *v129; // r9
			//   Vector3 *v130; // rax
			//   __int64 v131; // xmm3_8
			//   MethodInfo *v132; // r9
			//   Vector3 *v133; // rax
			//   __int64 v134; // xmm3_8
			//   MethodInfo *v135; // r9
			//   Vector3 *v136; // rax
			//   __int64 v137; // xmm3_8
			//   MethodInfo *v138; // r9
			//   MethodInfo *v139; // r9
			//   Vector3 *v140; // rax
			//   __int64 v141; // r9
			//   __int64 v142; // xmm3_8
			//   Vector3 *v143; // rax
			//   Vector3 *v144; // r8
			//   Vector3 *v145; // rdx
			//   __int64 v146; // xmm3_8
			//   Vector3 *v147; // rax
			//   __int64 v148; // r9
			//   __int64 v149; // xmm3_8
			//   Vector3 *v150; // rax
			//   __int64 v151; // r9
			//   __int64 v152; // xmm3_8
			//   Vector3 *v153; // rax
			//   __int64 v154; // xmm3_8
			//   MethodInfo *v155; // r9
			//   Vector3 *v156; // rax
			//   __int64 v157; // xmm3_8
			//   MethodInfo *v158; // r9
			//   Vector3 *v159; // rax
			//   __int64 v160; // xmm3_8
			//   MethodInfo *v161; // r9
			//   Vector3 *v162; // rax
			//   __int64 v163; // xmm3_8
			//   MethodInfo *v164; // r9
			//   MethodInfo *v165; // r9
			//   Vector3 *v166; // rax
			//   __int64 v167; // r9
			//   __int64 v168; // xmm3_8
			//   Vector3 *v169; // rax
			//   Vector3 *v170; // r8
			//   Vector3 *v171; // rdx
			//   __int64 v172; // xmm3_8
			//   Vector3 *v173; // rax
			//   __int64 v174; // r9
			//   __int64 v175; // xmm3_8
			//   Vector3 *v176; // rax
			//   __int64 v177; // r9
			//   __int64 v178; // xmm3_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v180; // [rsp+38h] [rbp-D0h] BYREF
			//   Vector3 v181; // [rsp+48h] [rbp-C0h] BYREF
			//   Vector3 v182; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector3 v183; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector3 v184; // [rsp+78h] [rbp-90h] BYREF
			//   Color value; // [rsp+88h] [rbp-80h] BYREF
			//   Vector3 v186; // [rsp+98h] [rbp-70h] BYREF
			//   Vector3 v187; // [rsp+A8h] [rbp-60h] BYREF
			//   Vector3 v188; // [rsp+B8h] [rbp-50h] BYREF
			//   Vector3 v189; // [rsp+C8h] [rbp-40h] BYREF
			//   Vector3 v190; // [rsp+D8h] [rbp-30h] BYREF
			//   Vector3 v191; // [rsp+E8h] [rbp-20h] BYREF
			//   Vector3 v192; // [rsp+F8h] [rbp-10h] BYREF
			//   Vector3 v193; // [rsp+108h] [rbp+0h] BYREF
			//   Vector3 v194; // [rsp+118h] [rbp+10h] BYREF
			//   Vector3 v195; // [rsp+128h] [rbp+20h] BYREF
			//   Vector3 v196; // [rsp+138h] [rbp+30h] BYREF
			//   Vector3 v197; // [rsp+148h] [rbp+40h] BYREF
			//   Color si128; // [rsp+158h] [rbp+50h] BYREF
			//   Vector3 v199; // [rsp+168h] [rbp+60h] BYREF
			//   Vector3 v200; // [rsp+178h] [rbp+70h] BYREF
			//   Vector3 v201; // [rsp+188h] [rbp+80h] BYREF
			//   Vector3 v202; // [rsp+198h] [rbp+90h] BYREF
			//   Vector3 v203; // [rsp+1A8h] [rbp+A0h] BYREF
			//   Vector3 v204; // [rsp+1B8h] [rbp+B0h] BYREF
			//   Vector3 v205; // [rsp+1C8h] [rbp+C0h] BYREF
			//   Vector3 v206; // [rsp+1D8h] [rbp+D0h] BYREF
			//   Matrix4x4 v207; // [rsp+1E8h] [rbp+E0h] BYREF
			//   Color v208; // [rsp+228h] [rbp+120h] BYREF
			//   Vector3 v209; // [rsp+238h] [rbp+130h] BYREF
			//   Matrix4x4 v210[3]; // [rsp+248h] [rbp+140h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1446, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1446, 0LL);
			//     if ( !Patch )
			//       goto LABEL_43;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( !this.fields.data.shape )
			//     {
			//       value = (Color)_mm_load_si128((const __m128i *)&xmmword_18C370F50);
			//       UnityEngine::Gizmos::set_color_Injected(&value, 0LL);
			//       transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( !transform )
			//         sub_180B536AC(v5, v4);
			//       position = UnityEngine::Transform::get_position(&v180, transform, 0LL);
			//       radius = this.fields.data.radius;
			//       v8 = *(_QWORD *)&position.x;
			//       *(float *)&position = position.z;
			//       *(_QWORD *)&v182.x = v8;
			//       LODWORD(v182.z) = (_DWORD)position;
			//       UnityEngine::Gizmos::DrawSphere(&v182, radius, 0LL);
			//       v9 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( !v9 )
			//         sub_180B536AC(v11, v10);
			//       v12 = UnityEngine::Transform::get_position(&v180, v9, 0LL);
			//       rangeIn = this.fields.data.rangeIn;
			//       v14 = *(_QWORD *)&v12.x;
			//       *(float *)&v12 = v12.z;
			//       *(_QWORD *)&v182.x = v14;
			//       LODWORD(v182.z) = (_DWORD)v12;
			//       UnityEngine::Gizmos::DrawSphere(&v182, rangeIn, 0LL);
			//       value = *UnityEngine::Color::get_cyan(&si128, v15);
			//       UnityEngine::Gizmos::set_color_Injected(&value, 0LL);
			//       v16 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( !v16 )
			//         sub_180B536AC(v18, v17);
			//       v19 = UnityEngine::Transform::get_position(&v180, v16, 0LL);
			//       v20 = this.fields.data.radius;
			//       v21 = *(_QWORD *)&v19.x;
			//       *(float *)&v19 = v19.z;
			//       *(_QWORD *)&v182.x = v21;
			//       LODWORD(v182.z) = (_DWORD)v19;
			//       UnityEngine::Gizmos::DrawWireSphere(&v182, v20, 0LL);
			//       v22 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( !v22 )
			//         sub_180B536AC(v24, v23);
			//       v25 = UnityEngine::Transform::get_position(&v180, v22, 0LL);
			//       v26 = this.fields.data.rangeIn;
			//       v27 = *(_QWORD *)&v25.x;
			//       *(float *)&v25 = v25.z;
			//       *(_QWORD *)&v182.x = v27;
			//       LODWORD(v182.z) = (_DWORD)v25;
			//       UnityEngine::Gizmos::DrawWireSphere(&v182, v26, 0LL);
			//       v28 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( !v28 )
			//         sub_180B536AC(v30, v29);
			//       v31 = UnityEngine::Transform::get_position(&v180, v28, 0LL);
			//       z = v31.z;
			//       v33 = *(_QWORD *)&v31.x;
			//       v34 = this.fields.data.radius * 0.80000001;
			//       v35 = this.fields.data.radius * 0.2;
			//       v36 = 0;
			//       while ( 1 )
			//       {
			//         v37 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//         if ( !v37 )
			//           break;
			//         forward = UnityEngine::Transform::get_forward(&v209, v37, 0LL);
			//         v41 = forward.z;
			//         v42 = *(_QWORD *)&forward.x;
			//         si128 = *(Color *)sub_182504D40(&v208);
			//         v43 = UnityEngine::Matrix4x4::Rotate(v210, (Quaternion *)&si128, 0LL);
			//         *(_QWORD *)&v182.x = v42;
			//         v182.z = v41;
			//         v44 = *(_OWORD *)&v43.m01;
			//         *(_OWORD *)&v207.m00 = *(_OWORD *)&v43.m00;
			//         v45 = *(_OWORD *)&v43.m02;
			//         *(_OWORD *)&v207.m01 = v44;
			//         v46 = *(_OWORD *)&v43.m03;
			//         *(_OWORD *)&v207.m02 = v45;
			//         *(_OWORD *)&v207.m03 = v46;
			//         v47 = UnityEngine::Matrix4x4::MultiplyVector(&v199, &v207, &v182, 0LL);
			//         v49 = *(_QWORD *)&v47.x;
			//         if ( this.fields.data.focus )
			//         {
			//           v186.z = v47.z;
			//           *(_QWORD *)&v186.x = v49;
			//           v50 = UnityEngine::Vector3::op_Multiply(&v200, &v186, v34, v48);
			//           v52 = *(_QWORD *)v51;
			//           *(_QWORD *)&v191.x = v33;
			//           v191.z = z;
			//           v53 = *(_QWORD *)&v50.x;
			//           v190.z = v50.z;
			//           v187.z = v51[2];
			//           *(_QWORD *)&v190.x = v53;
			//           *(_QWORD *)&v187.x = v52;
			//           v55 = UnityEngine::Vector3::op_Multiply(&v201, &v187, v35, v54);
			//           *(_QWORD *)&v189.x = v33;
			//           v189.z = z;
			//           v56 = *(_QWORD *)&v55.x;
			//           *(float *)&v55 = v55.z;
			//           *(_QWORD *)&v188.x = v56;
			//           LODWORD(v188.z) = (_DWORD)v55;
			//           v58 = UnityEngine::Vector3::op_Addition(&v202, &v189, &v188, v57);
			//           v59 = *(_QWORD *)&v58.x;
			//           *(float *)&v58 = v58.z;
			//           *(_QWORD *)&v192.x = v59;
			//           LODWORD(v192.z) = (_DWORD)v58;
			//           v61 = UnityEngine::Vector3::op_Addition(&v203, &v191, &v190, v60);
			//           v62 = &v192;
			//           v63 = &v193;
			//           v64 = *(_QWORD *)&v61.x;
			//           *(float *)&v61 = v61.z;
			//           *(_QWORD *)&v193.x = v64;
			//           LODWORD(v193.z) = (_DWORD)v61;
			//         }
			//         else
			//         {
			//           v194.z = v47.z;
			//           *(_QWORD *)&v194.x = v49;
			//           v65 = UnityEngine::Vector3::op_Multiply(&v204, &v194, v35, v48);
			//           v67 = *(_QWORD *)v66;
			//           *(_QWORD *)&v184.x = v33;
			//           v184.z = z;
			//           v68 = *(_QWORD *)&v65.x;
			//           v183.z = v65.z;
			//           v195.z = v66[2];
			//           *(_QWORD *)&v183.x = v68;
			//           *(_QWORD *)&v195.x = v67;
			//           v70 = UnityEngine::Vector3::op_Multiply(&v205, &v195, v34, v69);
			//           *(_QWORD *)&v197.x = v33;
			//           v197.z = z;
			//           v71 = *(_QWORD *)&v70.x;
			//           *(float *)&v70 = v70.z;
			//           *(_QWORD *)&v196.x = v71;
			//           LODWORD(v196.z) = (_DWORD)v70;
			//           v73 = UnityEngine::Vector3::op_Addition(&v206, &v197, &v196, v72);
			//           v74 = *(_QWORD *)&v73.x;
			//           *(float *)&v73 = v73.z;
			//           *(_QWORD *)&v181.x = v74;
			//           LODWORD(v181.z) = (_DWORD)v73;
			//           v76 = UnityEngine::Vector3::op_Addition((Vector3 *)&value, &v184, &v183, v75);
			//           v62 = &v181;
			//           v63 = &v180;
			//           v77 = *(_QWORD *)&v76.x;
			//           *(float *)&v76 = v76.z;
			//           *(_QWORD *)&v180.x = v77;
			//           LODWORD(v180.z) = (_DWORD)v76;
			//         }
			//         HG::Rendering::Runtime::HGWindMotor::_DrawArrow(this, v63, v62, 0LL);
			//         if ( ++v36 >= 6 )
			//           return;
			//       }
			// LABEL_43:
			//       sub_180B536AC(v39, v38);
			//     }
			//     if ( this.fields.data.shape == 1 )
			//     {
			//       v78 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( !v78 )
			//         goto LABEL_43;
			//       localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(v210, v78, 0LL);
			//       v80 = *(_OWORD *)&localToWorldMatrix.m01;
			//       *(_OWORD *)&v207.m00 = *(_OWORD *)&localToWorldMatrix.m00;
			//       v81 = *(_OWORD *)&localToWorldMatrix.m02;
			//       *(_OWORD *)&v207.m01 = v80;
			//       v82 = *(_OWORD *)&localToWorldMatrix.m03;
			//       *(_OWORD *)&v207.m02 = v81;
			//       *(_OWORD *)&v207.m03 = v82;
			//       UnityEngine::Gizmos::set_matrix_Injected(&v207, 0LL);
			//       si128 = (Color)_mm_load_si128((const __m128i *)&xmmword_18C370F50);
			//       if ( this.fields.data.rectBackward )
			//       {
			//         UnityEngine::Gizmos::set_color_Injected(&si128, 0LL);
			//         v180.z = 2.0;
			//         *(_QWORD *)&v180.x = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x40000000u).m128_u64[0];
			//         Vector = UnityEngine::Animator::GetVector((Vector3 *)&value, v86, v87, v88);
			//         v90 = *(_QWORD *)&Vector.x;
			//         *(float *)&Vector = Vector.z;
			//         *(_QWORD *)&v181.x = v90;
			//         LODWORD(v181.z) = (_DWORD)Vector;
			//         UnityEngine::Gizmos::DrawCube(&v181, &v180, 0LL);
			//         si128 = *UnityEngine::Color::get_cyan(&v208, v91);
			//         UnityEngine::Gizmos::set_color_Injected(&si128, 0LL);
			//         v180.z = 2.0;
			//         *(_QWORD *)&v180.x = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x40000000u).m128_u64[0];
			//         v95 = UnityEngine::Animator::GetVector((Vector3 *)&value, v92, v93, v94);
			//         v96 = *(_QWORD *)&v95.x;
			//         *(float *)&v95 = v95.z;
			//         *(_QWORD *)&v181.x = v96;
			//         LODWORD(v181.z) = (_DWORD)v95;
			//         UnityEngine::Gizmos::DrawWireCube(&v181, &v180, 0LL);
			//         *(float *)&v96 = this.fields.data.rangeIn + this.fields.data.rangeIn;
			//         *(_QWORD *)&v180.x = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x40000000u).m128_u64[0];
			//         LODWORD(v180.z) = v96;
			//         v100 = UnityEngine::Animator::GetVector((Vector3 *)&value, v97, v98, v99);
			//         v84 = &v180;
			//         v85 = &v181;
			//         v101 = *(_QWORD *)&v100.x;
			//         *(float *)&v100 = v100.z;
			//         *(_QWORD *)&v181.x = v101;
			//         LODWORD(v181.z) = (_DWORD)v100;
			//       }
			//       else
			//       {
			//         UnityEngine::Gizmos::set_color_Injected(&si128, 0LL);
			//         *(_QWORD *)&v180.x = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x40000000u).m128_u64[0];
			//         *(_QWORD *)&v181.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         v180.z = 1.0;
			//         v181.z = 0.5;
			//         UnityEngine::Gizmos::DrawCube(&v181, &v180, 0LL);
			//         si128 = *UnityEngine::Color::get_cyan(&v208, v83);
			//         UnityEngine::Gizmos::set_color_Injected(&si128, 0LL);
			//         v180.z = 1.0;
			//         *(_QWORD *)&v180.x = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x40000000u).m128_u64[0];
			//         v181.z = 0.5;
			//         *(_QWORD *)&v181.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         UnityEngine::Gizmos::DrawWireCube(&v181, &v180, 0LL);
			//         v84 = &v184;
			//         v184.z = this.fields.data.rangeIn;
			//         v85 = &v183;
			//         *(_QWORD *)&v184.x = _mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x40000000u).m128_u64[0];
			//         *(_QWORD *)&v183.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         v183.z = v184.z * 0.5;
			//       }
			//       UnityEngine::Gizmos::DrawWireCube(v85, v84, 0LL);
			//       v102 = (_OWORD *)sub_182805160(v210);
			//       v103 = v102[1];
			//       *(_OWORD *)&v207.m00 = *v102;
			//       v104 = v102[2];
			//       *(_OWORD *)&v207.m01 = v103;
			//       v105 = v102[3];
			//       *(_OWORD *)&v207.m02 = v104;
			//       *(_OWORD *)&v207.m03 = v105;
			//       UnityEngine::Gizmos::set_matrix_Injected(&v207, 0LL);
			//       v106 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( !v106 )
			//         sub_180B536AC(v108, v107);
			//       v109 = UnityEngine::Transform::get_position((Vector3 *)&value, v106, 0LL);
			//       v110 = *(_QWORD *)&v109.x;
			//       v111 = v109.z;
			//       Direction = HG::Rendering::Runtime::HGWindMotor::GetDirection((Vector3 *)&value, this, 0LL);
			//       v113 = *(_QWORD *)&Direction.x;
			//       v114 = Direction.z;
			//       *(_QWORD *)&v180.x = *(_QWORD *)&Direction.x;
			//       v115 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( !v115 )
			//         goto LABEL_43;
			//       UnityEngine::Transform::get_forward((Vector3 *)&value, v115, 0LL);
			//       v116 = -v180.x;
			//       v117 = this.fields.data.rangeIn;
			//       v118 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( !v118 )
			//         goto LABEL_43;
			//       v119 = UnityEngine::Transform::get_localScale((Vector3 *)&value, v118, 0LL).z - this.fields.data.rangeIn;
			//       v120 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//       if ( !v120 )
			//         goto LABEL_43;
			//       localScale = UnityEngine::Transform::get_localScale((Vector3 *)&value, v120, 0LL);
			//       v123 = -1;
			//       v124 = -1;
			//       v180.z = v116;
			//       v125 = _mm_unpacklo_ps((__m128)_mm_cvtsi32_si128(LODWORD(v114)), (__m128)0LL).m128_u64[0];
			//       v126 = localScale.x * 0.40000001;
			//       v197.z = v111;
			//       *(_QWORD *)&v180.x = v125;
			//       *(_QWORD *)&v197.x = v110;
			//       *(_QWORD *)&v184.x = v113;
			//       v184.z = v114;
			//       do
			//       {
			//         v127 = UnityEngine::Vector3::op_Multiply((Vector3 *)&value, &v180, (float)v124, v122);
			//         v128 = *(_QWORD *)&v127.x;
			//         *(float *)&v127 = v127.z;
			//         *(_QWORD *)&v181.x = v128;
			//         LODWORD(v181.z) = (_DWORD)v127;
			//         v130 = UnityEngine::Vector3::op_Multiply(&v206, &v181, v126, v129);
			//         v131 = *(_QWORD *)&v130.x;
			//         *(float *)&v130 = v130.z;
			//         *(_QWORD *)&v183.x = v131;
			//         LODWORD(v183.z) = (_DWORD)v130;
			//         v133 = UnityEngine::Vector3::op_Multiply(&v205, &v184, v117, v132);
			//         v134 = *(_QWORD *)&v133.x;
			//         *(float *)&v133 = v133.z;
			//         *(_QWORD *)&v196.x = v134;
			//         LODWORD(v196.z) = (_DWORD)v133;
			//         v136 = UnityEngine::Vector3::op_Addition(&v204, &v197, &v183, v135);
			//         v137 = *(_QWORD *)&v136.x;
			//         *(float *)&v136 = v136.z;
			//         *(_QWORD *)&v195.x = v137;
			//         LODWORD(v195.z) = (_DWORD)v136;
			//         v139 = (MethodInfo *)UnityEngine::Vector3::op_Addition(&v203, &v195, &v196, v138);
			//         if ( this.fields.data.focus )
			//         {
			//           *(_QWORD *)&v194.x = v113;
			//           v194.z = v114;
			//           v140 = UnityEngine::Vector3::op_Multiply(&v202, &v194, v119, v139);
			//           *(_QWORD *)&v192.x = *(_QWORD *)v141;
			//           *(_QWORD *)&v191.x = *(_QWORD *)&v192.x;
			//           v142 = *(_QWORD *)&v140.x;
			//           v193.z = v140.z;
			//           v192.z = *(float *)(v141 + 8);
			//           v191.z = v192.z;
			//           *(_QWORD *)&v193.x = v142;
			//           v143 = UnityEngine::Vector3::op_Addition(&v201, &v192, &v193, (MethodInfo *)v141);
			//           v144 = &v191;
			//           v145 = &v190;
			//           v146 = *(_QWORD *)&v143.x;
			//           *(float *)&v143 = v143.z;
			//           *(_QWORD *)&v190.x = v146;
			//           LODWORD(v190.z) = (_DWORD)v143;
			//         }
			//         else
			//         {
			//           *(_QWORD *)&v189.x = v113;
			//           v189.z = v114;
			//           v147 = UnityEngine::Vector3::op_Multiply(&v200, &v189, v119, v139);
			//           *(_QWORD *)&v187.x = *(_QWORD *)v148;
			//           v149 = *(_QWORD *)&v147.x;
			//           v188.z = v147.z;
			//           v187.z = *(float *)(v148 + 8);
			//           *(_QWORD *)&v188.x = v149;
			//           v150 = UnityEngine::Vector3::op_Addition(&v199, &v187, &v188, (MethodInfo *)v148);
			//           v144 = &v186;
			//           *(_QWORD *)&v182.x = *(_QWORD *)v151;
			//           v145 = &v182;
			//           v152 = *(_QWORD *)&v150.x;
			//           v186.z = v150.z;
			//           v182.z = *(float *)(v151 + 8);
			//           *(_QWORD *)&v186.x = v152;
			//         }
			//         HG::Rendering::Runtime::HGWindMotor::_DrawArrow(this, v145, v144, 0LL);
			//         ++v124;
			//       }
			//       while ( v124 <= 1 );
			//       if ( this.fields.data.rectBackward )
			//       {
			//         v180.z = v116;
			//         *(_QWORD *)&v180.x = v125;
			//         *(_QWORD *)&v197.x = v110;
			//         v197.z = v111;
			//         *(_QWORD *)&v184.x = v113;
			//         v184.z = v114;
			//         do
			//         {
			//           v153 = UnityEngine::Vector3::op_Multiply((Vector3 *)&value, &v180, (float)v123, v122);
			//           v154 = *(_QWORD *)&v153.x;
			//           *(float *)&v153 = v153.z;
			//           *(_QWORD *)&v181.x = v154;
			//           LODWORD(v181.z) = (_DWORD)v153;
			//           v156 = UnityEngine::Vector3::op_Multiply(&v206, &v181, v126, v155);
			//           v157 = *(_QWORD *)&v156.x;
			//           *(float *)&v156 = v156.z;
			//           *(_QWORD *)&v183.x = v157;
			//           LODWORD(v183.z) = (_DWORD)v156;
			//           v159 = UnityEngine::Vector3::op_Multiply(&v205, &v184, v117, v158);
			//           v160 = *(_QWORD *)&v159.x;
			//           *(float *)&v159 = v159.z;
			//           *(_QWORD *)&v196.x = v160;
			//           LODWORD(v196.z) = (_DWORD)v159;
			//           v162 = UnityEngine::Vector3::op_Addition(&v204, &v197, &v183, v161);
			//           v163 = *(_QWORD *)&v162.x;
			//           *(float *)&v162 = v162.z;
			//           *(_QWORD *)&v195.x = v163;
			//           LODWORD(v195.z) = (_DWORD)v162;
			//           v165 = (MethodInfo *)UnityEngine::Vector3::op_Subtraction(&v203, &v195, &v196, v164);
			//           if ( this.fields.data.focus )
			//           {
			//             *(_QWORD *)&v194.x = v113;
			//             v194.z = v114;
			//             v166 = UnityEngine::Vector3::op_Multiply(&v202, &v194, v119, v165);
			//             *(_QWORD *)&v192.x = *(_QWORD *)v167;
			//             *(_QWORD *)&v191.x = *(_QWORD *)&v192.x;
			//             v168 = *(_QWORD *)&v166.x;
			//             v193.z = v166.z;
			//             v192.z = *(float *)(v167 + 8);
			//             v191.z = v192.z;
			//             *(_QWORD *)&v193.x = v168;
			//             v169 = UnityEngine::Vector3::op_Subtraction(&v201, &v192, &v193, (MethodInfo *)v167);
			//             v170 = &v191;
			//             v171 = &v190;
			//             v172 = *(_QWORD *)&v169.x;
			//             *(float *)&v169 = v169.z;
			//             *(_QWORD *)&v190.x = v172;
			//             LODWORD(v190.z) = (_DWORD)v169;
			//           }
			//           else
			//           {
			//             *(_QWORD *)&v189.x = v113;
			//             v189.z = v114;
			//             v173 = UnityEngine::Vector3::op_Multiply(&v200, &v189, v119, v165);
			//             *(_QWORD *)&v187.x = *(_QWORD *)v174;
			//             v175 = *(_QWORD *)&v173.x;
			//             v188.z = v173.z;
			//             v187.z = *(float *)(v174 + 8);
			//             *(_QWORD *)&v188.x = v175;
			//             v176 = UnityEngine::Vector3::op_Subtraction(&v199, &v187, &v188, (MethodInfo *)v174);
			//             v170 = &v186;
			//             *(_QWORD *)&v182.x = *(_QWORD *)v177;
			//             v171 = &v182;
			//             v178 = *(_QWORD *)&v176.x;
			//             v186.z = v176.z;
			//             v182.z = *(float *)(v177 + 8);
			//             *(_QWORD *)&v186.x = v178;
			//           }
			//           HG::Rendering::Runtime::HGWindMotor::_DrawArrow(this, v171, v170, 0LL);
			//           ++v123;
			//         }
			//         while ( v123 <= 1 );
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void _DrawArrow(Vector3 from, Vector3 to)
		{
			// // Void _DrawArrow(Vector3, Vector3)
			// void HG::Rendering::Runtime::HGWindMotor::_DrawArrow(HGWindMotor *this, Vector3 *from, Vector3 *to, MethodInfo *method)
			// {
			//   float v7; // eax
			//   __int64 v8; // xmm0_8
			//   float v9; // eax
			//   float v10; // eax
			//   __int64 v11; // xmm0_8
			//   float v12; // eax
			//   MethodInfo *v13; // r9
			//   Vector3 *v14; // rax
			//   __int64 v15; // xmm9_8
			//   float v16; // edi
			//   MethodInfo *v17; // r9
			//   Vector3 *v18; // rax
			//   __int64 v19; // xmm8_8
			//   float v20; // ebx
			//   MethodInfo *v21; // r9
			//   Vector3 *v22; // rax
			//   __int64 v23; // xmm0_8
			//   __int64 v24; // xmm3_8
			//   MethodInfo *v25; // r9
			//   Vector3 *v26; // rax
			//   __int64 v27; // xmm3_8
			//   MethodInfo *v28; // r9
			//   Vector3 *v29; // rax
			//   __int64 v30; // xmm3_8
			//   MethodInfo *v31; // r9
			//   Vector3 *v32; // rax
			//   __int64 v33; // xmm0_8
			//   __int64 v34; // xmm3_8
			//   MethodInfo *v35; // r9
			//   Vector3 *v36; // rax
			//   __int64 v37; // xmm3_8
			//   MethodInfo *v38; // r9
			//   Vector3 *v39; // rax
			//   __int64 v40; // xmm3_8
			//   MethodInfo *v41; // r9
			//   Vector3 *v42; // rax
			//   __int64 v43; // xmm3_8
			//   MethodInfo *v44; // r9
			//   Vector3 *v45; // rax
			//   __int64 v46; // xmm3_8
			//   __int64 v47; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   __int64 v50; // xmm0_8
			//   float v51; // eax
			//   Vector3 v52; // [rsp+38h] [rbp-9h] BYREF
			//   Vector3 v53; // [rsp+48h] [rbp+7h] BYREF
			//   Vector3 v54; // [rsp+58h] [rbp+17h] BYREF
			//   Vector3 v55[4]; // [rsp+68h] [rbp+27h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1447, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1447, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v47);
			//     z = to.z;
			//     *(_QWORD *)&v54.x = *(_QWORD *)&to.x;
			//     v50 = *(_QWORD *)&from.x;
			//     v54.z = z;
			//     v51 = from.z;
			//     *(_QWORD *)&v53.x = v50;
			//     v53.z = v51;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_544(Patch, (Object *)this, &v53, &v54, 0LL);
			//   }
			//   else
			//   {
			//     v7 = to.z;
			//     *(_QWORD *)&v52.x = *(_QWORD *)&to.x;
			//     v8 = *(_QWORD *)&from.x;
			//     v52.z = v7;
			//     v9 = from.z;
			//     *(_QWORD *)&v53.x = v8;
			//     v53.z = v9;
			//     UnityEngine::Gizmos::DrawLine(&v53, &v52, 0LL);
			//     v10 = from.z;
			//     *(_QWORD *)&v53.x = *(_QWORD *)&from.x;
			//     v11 = *(_QWORD *)&to.x;
			//     v53.z = v10;
			//     v12 = to.z;
			//     *(_QWORD *)&v52.x = v11;
			//     v52.z = v12;
			//     v14 = UnityEngine::Vector3::op_Subtraction(&v54, &v52, &v53, v13);
			//     v16 = v14.z;
			//     *(_QWORD *)&v52.x = *(_QWORD *)&v14.x;
			//     v15 = *(_QWORD *)&v52.x;
			//     v53.z = 0.0;
			//     *(_QWORD *)&v53.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//     v52.z = v16;
			//     v18 = UnityEngine::Vector3::Cross(v55, &v52, &v53, v17);
			//     *(_QWORD *)&v53.x = v15;
			//     v53.z = v16;
			//     v19 = *(_QWORD *)&v18.x;
			//     v20 = v18.z;
			//     v22 = UnityEngine::Vector3::op_Multiply(&v54, &v53, 0.2, v21);
			//     v23 = *(_QWORD *)&to.x;
			//     *(_QWORD *)&v53.x = v19;
			//     v24 = *(_QWORD *)&v22.x;
			//     v52.z = v22.z;
			//     v54.z = to.z;
			//     *(_QWORD *)&v52.x = v24;
			//     *(_QWORD *)&v54.x = v23;
			//     v53.z = v20;
			//     v26 = UnityEngine::Vector3::op_Multiply(v55, &v53, 0.15000001, v25);
			//     v27 = *(_QWORD *)&v26.x;
			//     *(float *)&v26 = v26.z;
			//     *(_QWORD *)&v53.x = v27;
			//     LODWORD(v53.z) = (_DWORD)v26;
			//     v29 = UnityEngine::Vector3::op_Subtraction(v55, &v54, &v52, v28);
			//     v30 = *(_QWORD *)&v29.x;
			//     *(float *)&v29 = v29.z;
			//     *(_QWORD *)&v54.x = v30;
			//     LODWORD(v54.z) = (_DWORD)v29;
			//     v32 = UnityEngine::Vector3::op_Addition(v55, &v54, &v53, v31);
			//     v33 = *(_QWORD *)&to.x;
			//     v34 = *(_QWORD *)&v32.x;
			//     *(float *)&v32 = v32.z;
			//     *(_QWORD *)&v54.x = v34;
			//     LODWORD(v54.z) = (_DWORD)v32;
			//     v53.z = to.z;
			//     *(_QWORD *)&v53.x = v33;
			//     UnityEngine::Gizmos::DrawLine(&v53, &v54, 0LL);
			//     *(_QWORD *)&v54.x = v15;
			//     v54.z = v16;
			//     v36 = UnityEngine::Vector3::op_Multiply(v55, &v54, 0.2, v35);
			//     *(_QWORD *)&v52.x = *(_QWORD *)&to.x;
			//     v37 = *(_QWORD *)&v36.x;
			//     v53.z = v36.z;
			//     v52.z = to.z;
			//     *(_QWORD *)&v53.x = v37;
			//     *(_QWORD *)&v54.x = v19;
			//     v54.z = v20;
			//     v39 = UnityEngine::Vector3::op_Multiply(v55, &v54, 0.15000001, v38);
			//     v40 = *(_QWORD *)&v39.x;
			//     *(float *)&v39 = v39.z;
			//     *(_QWORD *)&v54.x = v40;
			//     LODWORD(v54.z) = (_DWORD)v39;
			//     v42 = UnityEngine::Vector3::op_Subtraction(v55, &v52, &v53, v41);
			//     v43 = *(_QWORD *)&v42.x;
			//     *(float *)&v42 = v42.z;
			//     *(_QWORD *)&v53.x = v43;
			//     LODWORD(v53.z) = (_DWORD)v42;
			//     v45 = UnityEngine::Vector3::op_Subtraction(v55, &v53, &v54, v44);
			//     *(_QWORD *)&v53.x = *(_QWORD *)&to.x;
			//     v46 = *(_QWORD *)&v45.x;
			//     v54.z = v45.z;
			//     v53.z = to.z;
			//     *(_QWORD *)&v54.x = v46;
			//     UnityEngine::Gizmos::DrawLine(&v53, &v54, 0LL);
			//   }
			// }
			// 
		}

		public void <>iFixBaseProxy_OnPlay()
		{
			// // Void <>iFixBaseProxy_OnPlay()
			// void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnPlay(VFXSceneDark *this, MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay((VFXPlayableMonoBase *)this, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_OnStop()
		{
			// // Void <>iFixBaseProxy_OnStop()
			// void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnStop(VFXSceneDark *this, MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::VFXPlayableMonoBase::OnStop((VFXPlayableMonoBase *)this, 0LL);
			// }
			// 
		}

		public HGWindMotorData data;
	}
}
