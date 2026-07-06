using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class HGCapsuleShadowHelper : MonoBehaviour, IHGInteractionObject
	{
		public HGCapsuleShadowHelper()
		{
		}

		private Matrix4x4 GetLocalMatrix(HGCapsuleShadowContainer container)
		{
			// // Matrix4x4 GetLocalMatrix(HGCapsuleShadowContainer)
			// Matrix4x4 *HG::Rendering::Runtime::HGCapsuleShadowHelper::GetLocalMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         HGCapsuleShadowHelper *this,
			//         HGCapsuleShadowContainer *container,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __m128i v9; // xmm6
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm3_8
			//   void (__fastcall *v12)(Vector3 *, __int128 *); // rax
			//   void (__fastcall *v13)(Vector3 *, __int128 *, unsigned __int64 *, HGCapsuleShadowContainer *); // rax
			//   Matrix4x4 *result; // rax
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   Matrix4x4 *v21; // rax
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int64 v25; // rax
			//   __int64 v26; // rax
			//   Vector3 v27; // [rsp+30h] [rbp-D0h] BYREF
			//   Vector3 v28; // [rsp+40h] [rbp-C0h] BYREF
			//   HGCapsuleShadowContainer v29; // [rsp+50h] [rbp-B0h] BYREF
			//   __int128 v30; // [rsp+80h] [rbp-80h]
			//   unsigned __int64 v31; // [rsp+90h] [rbp-70h] BYREF
			//   int v32; // [rsp+98h] [rbp-68h]
			//   __int128 v33; // [rsp+A0h] [rbp-60h] BYREF
			//   __int128 v34; // [rsp+B0h] [rbp-50h] BYREF
			//   Matrix4x4 v35; // [rsp+C0h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_10;
			//   if ( wrapperArray.max_length.size > 1767 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//     if ( v7 )
			//     {
			//       if ( LODWORD(v7._0.namespaze) <= 0x6E7 )
			//         sub_180070270(v7, wrapperArray);
			//       if ( !*(_QWORD *)&v7[37]._1.element_size )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1767, 0LL);
			//       if ( Patch )
			//       {
			//         v19 = *(_OWORD *)&container.localOffset.x;
			//         *(_OWORD *)&v29.rootTransform = *(_OWORD *)&container.rootTransform;
			//         v20 = *(_OWORD *)&container.localRotation.y;
			//         *(_OWORD *)&v29.localOffset.x = v19;
			//         *(_OWORD *)&v29.localRotation.y = v20;
			//         v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_682(&v35, Patch, (Object *)this, &v29, 0LL);
			//         v22 = *(_OWORD *)&v21.m01;
			//         *(_OWORD *)&retstr.m00 = *(_OWORD *)&v21.m00;
			//         v23 = *(_OWORD *)&v21.m02;
			//         *(_OWORD *)&retstr.m01 = v22;
			//         v24 = *(_OWORD *)&v21.m03;
			//         result = retstr;
			//         *(_OWORD *)&retstr.m02 = v23;
			//         *(_OWORD *)&retstr.m03 = v24;
			//         return result;
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(v7, wrapperArray);
			//   }
			// LABEL_7:
			//   v9 = *(__m128i *)&container.localOffset.x;
			//   *(_OWORD *)&v29.rootTransform = *(_OWORD *)&container.rootTransform;
			//   *(_OWORD *)&v29.localRotation.y = *(_OWORD *)&container.localRotation.y;
			//   *(__m128i *)&v29.localOffset.x = v9;
			//   *(_QWORD *)&v27.x = *(_QWORD *)&v29.localRotation.x;
			//   LODWORD(v27.z) = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v29.localRotation.y, 4));
			//   v10 = UnityEngine::Vector3::op_Multiply(&v28, &v27, 0.017453292, method);
			//   v33 = 0LL;
			//   v11 = *(_QWORD *)&v10.x;
			//   v27.z = v10.z;
			//   v12 = (void (__fastcall *)(Vector3 *, __int128 *))qword_18D8F4C40;
			//   *(_QWORD *)&v27.x = v11;
			//   if ( !qword_18D8F4C40 )
			//   {
			//     v12 = (void (__fastcall *)(Vector3 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                         "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngi"
			//                                                         "ne.Vector3&,UnityEngine.Quaternion&)");
			//     if ( !v12 )
			//     {
			//       v25 = sub_1802DBBE8("UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
			//       sub_18000F750(v25, 0LL);
			//     }
			//     qword_18D8F4C40 = (__int64)v12;
			//   }
			//   v12(&v27, &v33);
			//   v13 = (void (__fastcall *)(Vector3 *, __int128 *, unsigned __int64 *, HGCapsuleShadowContainer *))qword_18D8F4BC8;
			//   v31 = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//   *(_QWORD *)&v28.x = v9.m128i_i64[0];
			//   v32 = 1065353216;
			//   LODWORD(v28.z) = _mm_cvtsi128_si32(_mm_srli_si128(v9, 8));
			//   v34 = v33;
			//   memset(&v29, 0, sizeof(v29));
			//   v30 = 0LL;
			//   if ( !qword_18D8F4BC8 )
			//   {
			//     v13 = (void (__fastcall *)(Vector3 *, __int128 *, unsigned __int64 *, HGCapsuleShadowContainer *))il2cpp_resolve_icall_0("UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,UnityEngine.Matrix4x4&)");
			//     if ( !v13 )
			//     {
			//       v26 = sub_1802DBBE8(
			//               "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Unit"
			//               "yEngine.Matrix4x4&)");
			//       sub_18000F750(v26, 0LL);
			//     }
			//     qword_18D8F4BC8 = (__int64)v13;
			//   }
			//   v13(&v28, &v34, &v31, &v29);
			//   result = retstr;
			//   v15 = *(_OWORD *)&v29.localOffset.x;
			//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&v29.rootTransform;
			//   v16 = *(_OWORD *)&v29.localRotation.y;
			//   *(_OWORD *)&retstr.m01 = v15;
			//   v17 = v30;
			//   *(_OWORD *)&retstr.m02 = v16;
			//   *(_OWORD *)&retstr.m03 = v17;
			//   return result;
			// }
			// 
			return null;
		}

		public Transform GetCapsuleTransform(HGCapsuleShadowContainer container)
		{
			// // Transform GetCapsuleTransform(HGCapsuleShadowContainer)
			// Transform *HG::Rendering::Runtime::HGCapsuleShadowHelper::GetCapsuleTransform(
			//         HGCapsuleShadowHelper *this,
			//         HGCapsuleShadowContainer *container,
			//         MethodInfo *method)
			// {
			//   Transform *transform; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   HGCapsuleShadowContainer v12; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919759 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919759 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3474, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3474, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v10 = *(_OWORD *)&container.localOffset.x;
			//     *(_OWORD *)&v12.rootTransform = *(_OWORD *)&container.rootTransform;
			//     v11 = *(_OWORD *)&container.localRotation.y;
			//     *(_OWORD *)&v12.localOffset.x = v10;
			//     *(_OWORD *)&v12.localRotation.y = v11;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1242(Patch, (Object *)this, &v12, 0LL);
			//   }
			//   else
			//   {
			//     transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Inequality((Object_1 *)container.rootTransform, 0LL, 0LL) )
			//       return container.rootTransform;
			//     return transform;
			//   }
			// }
			// 
			return null;
		}

		public Matrix4x4 GetCapsuleLocalToWorldMatrix(HGCapsuleShadowContainer container)
		{
			// // Matrix4x4 GetCapsuleLocalToWorldMatrix(HGCapsuleShadowContainer)
			// Matrix4x4 *HG::Rendering::Runtime::HGCapsuleShadowHelper::GetCapsuleLocalToWorldMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         HGCapsuleShadowHelper *this,
			//         HGCapsuleShadowContainer *container,
			//         MethodInfo *method)
			// {
			//   _QWORD **v7; // rcx
			//   __int64 v8; // rdx
			//   __int64 (__fastcall *v9)(HGCapsuleShadowHelper *, __int64, HGCapsuleShadowContainer *, MethodInfo *); // rax
			//   Transform *rootTransform; // rsi
			//   __int128 v11; // xmm1
			//   bool v12; // zf
			//   __int128 v13; // xmm6
			//   __int128 v14; // xmm1
			//   void (__fastcall *v15)(Transform *, Matrix4x4 *); // rax
			//   __int64 v16; // rdx
			//   MethodInfo *v17; // r9
			//   __int128 v18; // xmm1
			//   __m128i v19; // xmm6
			//   Vector3 *v20; // rax
			//   __int64 v21; // xmm3_8
			//   void (__fastcall *v22)(Vector3 *, __int128 *); // rax
			//   void (__fastcall *v23)(Vector3 *, __int128 *, unsigned __int64 *, HGCapsuleShadowContainer *); // rax
			//   __int128 v24; // xmm2
			//   __int128 v25; // xmm3
			//   __int128 v26; // xmm4
			//   __int128 v27; // xmm5
			//   void (__fastcall *v28)(Matrix4x4 *, _OWORD *, Matrix4x4 *); // rax
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   Matrix4x4 *result; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm0
			//   Matrix4x4 *v36; // rax
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   __int64 v39; // rax
			//   __int64 v40; // rax
			//   ILFixDynamicMethodWrapper_2 *v41; // rax
			//   __int128 v42; // xmm0
			//   Matrix4x4 *v43; // rax
			//   __int64 v44; // rax
			//   __int64 v45; // rax
			//   __int64 v46; // rax
			//   Vector3 v47; // [rsp+30h] [rbp-D0h] BYREF
			//   HGCapsuleShadowContainer v48; // [rsp+40h] [rbp-C0h] BYREF
			//   __int128 v49; // [rsp+70h] [rbp-90h]
			//   Vector3 v50; // [rsp+80h] [rbp-80h] BYREF
			//   Matrix4x4 v51; // [rsp+90h] [rbp-70h] BYREF
			//   unsigned __int64 v52; // [rsp+D0h] [rbp-30h] BYREF
			//   int v53; // [rsp+D8h] [rbp-28h]
			//   __int128 v54; // [rsp+E0h] [rbp-20h] BYREF
			//   __int128 v55; // [rsp+F0h] [rbp-10h] BYREF
			//   Matrix4x4 v56; // [rsp+100h] [rbp+0h] BYREF
			//   _OWORD v57[4]; // [rsp+140h] [rbp+40h] BYREF
			//   Matrix4x4 v58; // [rsp+180h] [rbp+80h] BYREF
			// 
			//   if ( !byte_18D8EDB7D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB7D = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v7 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = *v7[23];
			//   if ( !v8 )
			//     goto LABEL_37;
			//   if ( *(int *)(v8 + 24) > 1766 )
			//   {
			//     if ( !*((_DWORD *)v7 + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(v7, v8);
			//       v7 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v8 = *v7[23];
			//     if ( !v8 )
			//       goto LABEL_37;
			//     if ( *(_DWORD *)(v8 + 24) <= 0x6E6u )
			//       goto LABEL_58;
			//     if ( *(_QWORD *)(v8 + 14160) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1766, 0LL);
			//       if ( Patch )
			//       {
			//         v34 = *(_OWORD *)&container.localOffset.x;
			//         *(_OWORD *)&v48.rootTransform = *(_OWORD *)&container.rootTransform;
			//         v35 = *(_OWORD *)&container.localRotation.y;
			//         *(_OWORD *)&v48.localOffset.x = v34;
			//         *(_OWORD *)&v48.localRotation.y = v35;
			//         v36 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_682(&v56, Patch, (Object *)this, &v48, 0LL);
			//         v37 = *(_OWORD *)&v36.m01;
			//         *(_OWORD *)&retstr.m00 = *(_OWORD *)&v36.m00;
			//         v38 = *(_OWORD *)&v36.m02;
			//         *(_OWORD *)&retstr.m01 = v37;
			//         v31 = *(_OWORD *)&v36.m03;
			//         *(_OWORD *)&retstr.m02 = v38;
			//         goto LABEL_36;
			//       }
			//       goto LABEL_37;
			//     }
			//   }
			//   v9 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *, __int64, HGCapsuleShadowContainer *, MethodInfo *))qword_18D8F4D40;
			//   if ( !qword_18D8F4D40 )
			//   {
			//     v9 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *, __int64, HGCapsuleShadowContainer *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//     if ( !v9 )
			//     {
			//       v39 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//       sub_18000F750(v39, 0LL);
			//     }
			//     qword_18D8F4D40 = (__int64)v9;
			//   }
			//   rootTransform = (Transform *)v9(this, v8, container, method);
			//   v11 = *(_OWORD *)&container.localRotation.y;
			//   v12 = TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor == 0;
			//   v13 = *(_OWORD *)&container.rootTransform;
			//   *(_OWORD *)&v48.localOffset.x = *(_OWORD *)&container.localOffset.x;
			//   *(_OWORD *)&v48.localRotation.y = v11;
			//   if ( v12 )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   v7 = (_QWORD **)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( (_QWORD)v13 )
			//   {
			//     v7 = (_QWORD **)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//     if ( *(_QWORD *)(v13 + 16) )
			//     {
			//       rootTransform = container.rootTransform;
			//       v14 = *(_OWORD *)&container.localRotation.y;
			//       *(_OWORD *)&v48.localOffset.x = *(_OWORD *)&container.localOffset.x;
			//       *(_OWORD *)&v48.localRotation.y = v14;
			//     }
			//   }
			//   if ( !rootTransform )
			//     goto LABEL_37;
			//   v15 = (void (__fastcall *)(Transform *, Matrix4x4 *))qword_18D8F5338;
			//   memset(&v51, 0, sizeof(v51));
			//   if ( !qword_18D8F5338 )
			//   {
			//     v15 = (void (__fastcall *)(Transform *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                            "UnityEngine.Transform::get_localToWorldMatrix_Injected(UnityE"
			//                                                            "ngine.Matrix4x4&)");
			//     if ( !v15 )
			//     {
			//       v40 = sub_1802DBBE8("UnityEngine.Transform::get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4&)");
			//       sub_18000F750(v40, 0LL);
			//     }
			//     qword_18D8F5338 = (__int64)v15;
			//   }
			//   v15(rootTransform, &v51);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v16);
			//     v7 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = *v7[23];
			//   if ( !v8 )
			//     goto LABEL_37;
			//   if ( *(int *)(v8 + 24) <= 1767 )
			//   {
			// LABEL_31:
			//     v18 = *(_OWORD *)&container.rootTransform;
			//     *(_OWORD *)&v48.localRotation.y = *(_OWORD *)&container.localRotation.y;
			//     *(_OWORD *)&v48.rootTransform = v13;
			//     v19 = *(__m128i *)&container.localOffset.x;
			//     *(_OWORD *)&v48.rootTransform = v18;
			//     *(__m128i *)&v48.localOffset.x = v19;
			//     LODWORD(v47.z) = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v48.localRotation.y, 4));
			//     *(_QWORD *)&v47.x = *(_QWORD *)&v48.localRotation.x;
			//     v20 = UnityEngine::Vector3::op_Multiply(&v50, &v47, 0.017453292, v17);
			//     v54 = 0LL;
			//     v21 = *(_QWORD *)&v20.x;
			//     v47.z = v20.z;
			//     v22 = (void (__fastcall *)(Vector3 *, __int128 *))qword_18D8F4C40;
			//     *(_QWORD *)&v47.x = v21;
			//     if ( !qword_18D8F4C40 )
			//     {
			//       v22 = (void (__fastcall *)(Vector3 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                           "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEn"
			//                                                           "gine.Vector3&,UnityEngine.Quaternion&)");
			//       if ( !v22 )
			//       {
			//         v44 = sub_1802DBBE8("UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
			//         sub_18000F750(v44, 0LL);
			//       }
			//       qword_18D8F4C40 = (__int64)v22;
			//     }
			//     v22(&v47, &v54);
			//     v23 = (void (__fastcall *)(Vector3 *, __int128 *, unsigned __int64 *, HGCapsuleShadowContainer *))qword_18D8F4BC8;
			//     v52 = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//     *(_QWORD *)&v50.x = v19.m128i_i64[0];
			//     v53 = 1065353216;
			//     LODWORD(v50.z) = _mm_cvtsi128_si32(_mm_srli_si128(v19, 8));
			//     v55 = v54;
			//     memset(&v48, 0, sizeof(v48));
			//     v49 = 0LL;
			//     if ( !qword_18D8F4BC8 )
			//     {
			//       v23 = (void (__fastcall *)(Vector3 *, __int128 *, unsigned __int64 *, HGCapsuleShadowContainer *))il2cpp_resolve_icall_0("UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,UnityEngine.Matrix4x4&)");
			//       if ( !v23 )
			//       {
			//         v45 = sub_1802DBBE8(
			//                 "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Un"
			//                 "ityEngine.Matrix4x4&)");
			//         sub_18000F750(v45, 0LL);
			//       }
			//       qword_18D8F4BC8 = (__int64)v23;
			//     }
			//     v23(&v50, &v55, &v52, &v48);
			//     v24 = *(_OWORD *)&v48.rootTransform;
			//     v25 = *(_OWORD *)&v48.localOffset.x;
			//     v26 = *(_OWORD *)&v48.localRotation.y;
			//     v27 = v49;
			//     goto LABEL_34;
			//   }
			//   if ( !*((_DWORD *)v7 + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(v7, v8);
			//     v7 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = (_QWORD **)*v7[23];
			//   if ( !v7 )
			// LABEL_37:
			//     sub_180B536AC(v7, v8);
			//   if ( *((_DWORD *)v7 + 6) <= 0x6E7u )
			// LABEL_58:
			//     sub_180070270(v7, v8);
			//   if ( !v7[1771] )
			//     goto LABEL_31;
			//   v41 = IFix::WrappersManagerImpl::GetPatch(1767, 0LL);
			//   if ( !v41 )
			//     goto LABEL_37;
			//   v42 = *(_OWORD *)&container.localRotation.y;
			//   *(_OWORD *)&v48.localOffset.x = *(_OWORD *)&container.localOffset.x;
			//   *(_OWORD *)&v48.localRotation.y = v42;
			//   *(_OWORD *)&v48.rootTransform = v13;
			//   v43 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_682(&v58, v41, (Object *)this, &v48, 0LL);
			//   v24 = *(_OWORD *)&v43.m00;
			//   v25 = *(_OWORD *)&v43.m01;
			//   v26 = *(_OWORD *)&v43.m02;
			//   v27 = *(_OWORD *)&v43.m03;
			// LABEL_34:
			//   v28 = (void (__fastcall *)(Matrix4x4 *, _OWORD *, Matrix4x4 *))qword_18D8F4BC0;
			//   v57[0] = v24;
			//   v56 = v51;
			//   v57[1] = v25;
			//   v57[2] = v26;
			//   v57[3] = v27;
			//   memset(&v51, 0, sizeof(v51));
			//   if ( !qword_18D8F4BC0 )
			//   {
			//     v28 = (void (__fastcall *)(Matrix4x4 *, _OWORD *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                      "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Inje"
			//                                                                      "cted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,"
			//                                                                      "UnityEngine.Matrix4x4&)");
			//     if ( !v28 )
			//     {
			//       v46 = sub_1802DBBE8(
			//               "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
			//               "yEngine.Matrix4x4&)");
			//       sub_18000F750(v46, 0LL);
			//     }
			//     qword_18D8F4BC0 = (__int64)v28;
			//   }
			//   v28(&v56, v57, &v51);
			//   v29 = *(_OWORD *)&v51.m01;
			//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&v51.m00;
			//   v30 = *(_OWORD *)&v51.m02;
			//   *(_OWORD *)&retstr.m01 = v29;
			//   v31 = *(_OWORD *)&v51.m03;
			//   *(_OWORD *)&retstr.m02 = v30;
			// LABEL_36:
			//   result = retstr;
			//   *(_OWORD *)&retstr.m03 = v31;
			//   return result;
			// }
			// 
			return null;
		}

		private Transform FindRecursive(Transform root, string name)
		{
			// // Transform FindRecursive(Transform, String)
			// Transform *HG::Rendering::Runtime::HGCapsuleShadowHelper::FindRecursive(
			//         HGCapsuleShadowHelper *this,
			//         Transform *root,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Object_1 *gameObject; // rax
			//   String *v10; // rax
			//   int32_t i; // edi
			//   Transform *Child; // rax
			//   Transform *Recursive; // rbp
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91975A )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91975A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3475, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)root, 0LL, 0LL) )
			//       return 0LL;
			//     if ( root )
			//     {
			//       gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)root, 0LL);
			//       if ( gameObject )
			//       {
			//         v10 = UnityEngine::Object::get_name(gameObject, 0LL);
			//         if ( v10 )
			//         {
			//           if ( System::String::Equals(v10, name, 0LL) )
			//             return root;
			//           for ( i = 0; i < UnityEngine::Transform::get_childCount(root, 0LL); ++i )
			//           {
			//             Child = UnityEngine::Transform::GetChild(root, i, 0LL);
			//             Recursive = HG::Rendering::Runtime::HGCapsuleShadowHelper::FindRecursive(this, Child, name, 0LL);
			//             sub_180002C70(TypeInfo::UnityEngine::Object);
			//             if ( UnityEngine::Object::op_Implicit((Object_1 *)Recursive, 0LL) )
			//               return Recursive;
			//           }
			//           return 0LL;
			//         }
			//       }
			//     }
			// LABEL_17:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3475, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1243(Patch, (Object *)this, (Object *)root, (Object *)name, 0LL);
			// }
			// 
			return null;
		}

		private bool GetSkeletonTransformByName(out Transform t, Transform rootTransform, string name)
		{
			// // Boolean GetSkeletonTransformByName(Transform ByRef, Transform, String)
			// bool HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//         HGCapsuleShadowHelper *this,
			//         Transform **t,
			//         Transform *rootTransform,
			//         String *name,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v9; // rdx
			//   FileDescriptor *v10; // r8
			//   MessageDescriptor *v11; // r9
			//   Object_1 *v12; // rbx
			//   String *v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   Object *P3; // [rsp+20h] [rbp-18h]
			//   String *v19; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v20; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D91975B )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18D517F58);
			//     sub_18003C530(&off_18D517F18);
			//     byte_18D91975B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3476, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3476, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1244(
			//              Patch,
			//              (Object *)this,
			//              t,
			//              (Object *)rootTransform,
			//              (Object *)name,
			//              0LL);
			//   }
			//   else
			//   {
			//     *t = HG::Rendering::Runtime::HGCapsuleShadowHelper::FindRecursive(this, rootTransform, name, 0LL);
			//     sub_1800054D0((OneofDescriptor *)t, v9, v10, v11, (String__Array *)P3, v19, v20);
			//     v12 = (Object_1 *)*t;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(v12, 0LL, 0LL) )
			//     {
			//       v14 = System::String::Concat(
			//               (String *)"Capsule骨骼生成失败！该角色没有绑定名为",
			//               name,
			//               (String *)"的骨骼节点",
			//               0LL);
			//       HG::Rendering::HGRPLogger::LogWarning(v14, 0LL);
			//       return 0;
			//     }
			//     else
			//     {
			//       return 1;
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		private HGCapsuleShadowContainer GenerateCapsuleShadowContainer(Transform baseTransform, Transform targetTransform, float radius, [MetadataOffset(Offset = "0x01F91D32")] float baseTransformOffset = 0f, [MetadataOffset(Offset = "0x01F91D36")] float targetTransformOffset = 0f, [MetadataOffset(Offset = "0x01F91D3A")] bool isToes = false)
		{
			// // HGCapsuleShadowContainer GenerateCapsuleShadowContainer(Transform, Transform, Single, Single, Single, Boolean)
			// HGCapsuleShadowContainer *HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
			//         HGCapsuleShadowContainer *__return_ptr retstr,
			//         HGCapsuleShadowHelper *this,
			//         Transform *baseTransform,
			//         Transform *targetTransform,
			//         float radius,
			//         float baseTransformOffset,
			//         float targetTransformOffset,
			//         bool isToes,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   OneofDescriptor__Class *klass; // rcx
			//   Vector3 *position; // rax
			//   __int64 v16; // xmm6_8
			//   float z; // edi
			//   Vector3 *v18; // rax
			//   __int64 v19; // xmm7_8
			//   float v20; // ebx
			//   MethodInfo *v21; // r9
			//   Vector3 *v22; // rax
			//   __int64 v23; // xmm3_8
			//   __int64 v24; // rax
			//   MethodInfo *v25; // r9
			//   __int64 v26; // xmm4_8
			//   float v27; // r10d
			//   Vector3 *v28; // rax
			//   __int64 v29; // xmm3_8
			//   __int64 v30; // rax
			//   Vector3 *v31; // rax
			//   __int64 v32; // xmm1_8
			//   MethodInfo *v33; // r9
			//   Vector3 *v34; // rax
			//   __int64 v35; // xmm4_8
			//   float v36; // r10d
			//   __int64 v37; // xmm9_8
			//   float v38; // esi
			//   MethodInfo *v39; // r9
			//   Vector3 *v40; // rax
			//   __int64 v41; // xmm1_8
			//   MethodInfo *v42; // r9
			//   Vector3 *v43; // rax
			//   __int64 v44; // xmm6_8
			//   float v45; // ebx
			//   MethodInfo *v46; // r9
			//   Vector3 *v47; // rax
			//   __int64 v48; // xmm3_8
			//   MethodInfo *v49; // r9
			//   Vector3 *v50; // rax
			//   __int64 v51; // xmm4_8
			//   float v52; // r10d
			//   __int64 v53; // xmm8_8
			//   float v54; // edi
			//   Vector3 *AnyPerpendicular_32_0; // rax
			//   __int64 v56; // xmm0_8
			//   bool v57; // r12
			//   __m128i v58; // xmm7
			//   MethodInfo *v59; // r9
			//   Vector3 *v60; // rax
			//   __int64 v61; // xmm3_8
			//   double v62; // xmm0_8
			//   OneofDescriptorProto *v63; // rdx
			//   FileDescriptor *v64; // r8
			//   MessageDescriptor *v65; // r9
			//   Matrix4x4 *worldToLocalMatrix; // rax
			//   __int128 v67; // xmm1
			//   __int128 v68; // xmm0
			//   __int128 v69; // xmm1
			//   Vector3 *v70; // rax
			//   Quaternion *rotation; // rax
			//   MethodInfo *v72; // r9
			//   __int64 v73; // rax
			//   __int128 v74; // xmm1
			//   __int128 v75; // xmm0
			//   HGCapsuleShadowContainer *v76; // rax
			//   HGCapsuleShadowContainer *result; // rax
			//   String__Array *v78; // [rsp+28h] [rbp-E0h]
			//   String *v79; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v80; // [rsp+38h] [rbp-D0h]
			//   Quaternion v81; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector3 v82; // [rsp+68h] [rbp-A0h] BYREF
			//   Quaternion v83; // [rsp+78h] [rbp-90h] BYREF
			//   Vector3 v84; // [rsp+88h] [rbp-80h] BYREF
			//   __m128i v85; // [rsp+98h] [rbp-70h] BYREF
			//   OneofDescriptor v86; // [rsp+A8h] [rbp-60h] BYREF
			//   __int128 v87; // [rsp+F8h] [rbp-10h]
			//   __int128 v88; // [rsp+108h] [rbp+0h]
			//   Matrix4x4 v89[2]; // [rsp+118h] [rbp+10h] BYREF
			// 
			//   memset(&v86, 0, 48);
			//   if ( IFix::WrappersManagerImpl::IsPatched(3477, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3477, 0LL);
			//     if ( Patch )
			//     {
			//       v76 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1245(
			//               (HGCapsuleShadowContainer *)&v86.fields.fields,
			//               Patch,
			//               (Object *)this,
			//               (Object *)baseTransform,
			//               (Object *)targetTransform,
			//               radius,
			//               baseTransformOffset,
			//               targetTransformOffset,
			//               isToes,
			//               0LL);
			//       v74 = *(_OWORD *)&v76.localOffset.x;
			//       *(_OWORD *)&retstr.rootTransform = *(_OWORD *)&v76.rootTransform;
			//       v75 = *(_OWORD *)&v76.localRotation.y;
			//       goto LABEL_14;
			//     }
			//     goto LABEL_12;
			//   }
			//   if ( !baseTransform )
			//     goto LABEL_12;
			//   position = UnityEngine::Transform::get_position((Vector3 *)&v85, baseTransform, 0LL);
			//   v16 = *(_QWORD *)&position.x;
			//   z = position.z;
			//   *(_QWORD *)&v81.x = *(_QWORD *)&position.x;
			//   if ( !targetTransform )
			//     goto LABEL_12;
			//   v18 = UnityEngine::Transform::get_position((Vector3 *)&v83, targetTransform, 0LL);
			//   *(_QWORD *)&v84.x = v16;
			//   v84.z = z;
			//   v19 = *(_QWORD *)&v18.x;
			//   v20 = v18.z;
			//   v85.m128i_i64[0] = v19;
			//   *(_QWORD *)&v82.x = v19;
			//   v82.z = v20;
			//   v22 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v83, &v82, &v84, v21);
			//   v23 = *(_QWORD *)&v22.x;
			//   *(float *)&v22 = v22.z;
			//   *(_QWORD *)&v84.x = v23;
			//   LODWORD(v84.z) = (_DWORD)v22;
			//   v24 = sub_182413270(&v83, &v84);
			//   v26 = *(_QWORD *)v24;
			//   v27 = *(float *)(v24 + 8);
			//   if ( isToes )
			//   {
			//     LODWORD(v81.y) = v85.m128i_i32[1];
			//     v16 = *(_QWORD *)&v81.x;
			//     v81.z = z;
			//     *(_QWORD *)&v82.x = v19;
			//     v82.z = v20;
			//     v28 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v83, &v82, (Vector3 *)&v81, v25);
			//     v29 = *(_QWORD *)&v28.x;
			//     *(float *)&v28 = v28.z;
			//     *(_QWORD *)&v84.x = v29;
			//     LODWORD(v84.z) = (_DWORD)v28;
			//     v30 = sub_182413270(&v83, &v84);
			//     v26 = *(_QWORD *)v30;
			//     v27 = *(float *)(v30 + 8);
			//   }
			//   *(_QWORD *)&v81.x = v26;
			//   v81.z = v27;
			//   v31 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v83, baseTransformOffset, (Vector3 *)&v81, v25);
			//   *(_QWORD *)&v82.x = v16;
			//   v82.z = z;
			//   v32 = *(_QWORD *)&v31.x;
			//   *(float *)&v31 = v31.z;
			//   *(_QWORD *)&v81.x = v32;
			//   LODWORD(v81.z) = (_DWORD)v31;
			//   v34 = UnityEngine::Vector3::op_Addition((Vector3 *)&v83, &v82, (Vector3 *)&v81, v33);
			//   *(_QWORD *)&v81.x = v35;
			//   v81.z = v36;
			//   v37 = *(_QWORD *)&v34.x;
			//   v38 = v34.z;
			//   v40 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v85, targetTransformOffset, (Vector3 *)&v81, v39);
			//   *(_QWORD *)&v82.x = v19;
			//   v82.z = v20;
			//   v41 = *(_QWORD *)&v40.x;
			//   *(float *)&v40 = v40.z;
			//   *(_QWORD *)&v81.x = v41;
			//   LODWORD(v81.z) = (_DWORD)v40;
			//   v43 = UnityEngine::Vector3::op_Addition((Vector3 *)&v85, &v82, (Vector3 *)&v81, v42);
			//   *(_QWORD *)&v82.x = v37;
			//   v82.z = v38;
			//   v45 = v43.z;
			//   *(_QWORD *)&v81.x = *(_QWORD *)&v43.x;
			//   v44 = *(_QWORD *)&v81.x;
			//   v81.z = v45;
			//   v47 = UnityEngine::Vector3::op_Addition((Vector3 *)&v83, &v82, (Vector3 *)&v81, v46);
			//   v48 = *(_QWORD *)&v47.x;
			//   *(float *)&v47 = v47.z;
			//   *(_QWORD *)&v81.x = v48;
			//   LODWORD(v81.z) = (_DWORD)v47;
			//   v50 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v83, 0.5, (Vector3 *)&v81, v49);
			//   *(_QWORD *)&v81.x = v51;
			//   v81.z = v52;
			//   *(_QWORD *)&v82.x = v51;
			//   v53 = *(_QWORD *)&v50.x;
			//   v54 = v50.z;
			//   v82.z = v52;
			//   AnyPerpendicular_32_0 = HG::Rendering::Runtime::HGCapsuleShadowHelper::_GenerateCapsuleShadowContainer_g__GetAnyPerpendicular_32_0(
			//                             (Vector3 *)&v83,
			//                             (Vector3 *)&v81,
			//                             0LL);
			//   v56 = *(_QWORD *)&AnyPerpendicular_32_0.x;
			//   *(float *)&AnyPerpendicular_32_0 = AnyPerpendicular_32_0.z;
			//   *(_QWORD *)&v81.x = v56;
			//   LODWORD(v81.z) = (_DWORD)AnyPerpendicular_32_0;
			//   v57 = 1;
			//   v58 = _mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::LookRotation(&v83, (Vector3 *)&v81, &v82, 0LL));
			//   BYTE4(v86.fields.containingType) = 1;
			//   *(_QWORD *)&v81.x = v37;
			//   v81.z = v38;
			//   *(_QWORD *)&v82.x = v44;
			//   v82.z = v45;
			//   v60 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v83, &v82, (Vector3 *)&v81, v59);
			//   v61 = *(_QWORD *)&v60.x;
			//   *(float *)&v60 = v60.z;
			//   *(_QWORD *)&v84.x = v61;
			//   LODWORD(v84.z) = (_DWORD)v60;
			//   v62 = sub_18238EFA0(&v84);
			//   v86.monitor = (MonitorData *)__PAIR64__(LODWORD(v62), LODWORD(radius));
			//   v86.klass = (OneofDescriptor__Class *)baseTransform;
			//   sub_1800054D0(&v86, v63, v64, v65, v78, v79, v80);
			//   worldToLocalMatrix = UnityEngine::Transform::get_worldToLocalMatrix(v89, baseTransform, 0LL);
			//   *(_QWORD *)&v81.x = v53;
			//   v81.z = v54;
			//   v67 = *(_OWORD *)&worldToLocalMatrix.m01;
			//   *(_OWORD *)&v86.fields.fields = *(_OWORD *)&worldToLocalMatrix.m00;
			//   v68 = *(_OWORD *)&worldToLocalMatrix.m02;
			//   *(_OWORD *)&v86.fields._Proto_k__BackingField = v67;
			//   v69 = *(_OWORD *)&worldToLocalMatrix.m03;
			//   v87 = v68;
			//   v88 = v69;
			//   v70 = UnityEngine::Matrix4x4::MultiplyPoint((Vector3 *)&v83, (Matrix4x4 *)&v86.fields.fields, (Vector3 *)&v81, 0LL);
			//   *(_QWORD *)&v86.fields._._Index_k__BackingField = *(_QWORD *)&v70.x;
			//   *(float *)&v86.fields._._FullName_k__BackingField = v70.z;
			//   rotation = UnityEngine::Transform::get_rotation(&v83, baseTransform, 0LL);
			//   v85 = v58;
			//   v83 = *rotation;
			//   v83 = *UnityEngine::Quaternion::Inverse(&v81, &v83, 0LL);
			//   v85 = *(__m128i *)UnityEngine::Quaternion::op_Multiply(&v81, &v83, (Quaternion *)&v85, v72);
			//   v73 = sub_182504AA0(&v83, &v85);
			//   klass = v86.klass;
			//   *(String **)((char *)&v86.fields._._FullName_k__BackingField + 4) = *(String **)v73;
			//   HIDWORD(v86.fields._._File_k__BackingField) = *(_DWORD *)(v73 + 8);
			//   LODWORD(v86.fields.containingType) = 1065353216;
			//   if ( !v86.klass )
			//     goto LABEL_12;
			//   if ( !UnityEngine::Object::CompareName((Object_1 *)v86.klass, this.fields.m_skeletonName_Ankle_L, 0LL) )
			//   {
			//     klass = v86.klass;
			//     if ( v86.klass )
			//     {
			//       v57 = UnityEngine::Object::CompareName((Object_1 *)v86.klass, this.fields.m_skeletonName_Ankle_R, 0LL);
			//       goto LABEL_10;
			//     }
			// LABEL_12:
			//     sub_180B536AC(klass, Patch);
			//   }
			// LABEL_10:
			//   BYTE5(v86.fields.containingType) = v57;
			//   v74 = *(_OWORD *)&v86.fields._._Index_k__BackingField;
			//   *(_OWORD *)&retstr.rootTransform = *(_OWORD *)&v86.klass;
			//   v75 = *(_OWORD *)&v86.fields._._File_k__BackingField;
			// LABEL_14:
			//   result = retstr;
			//   *(_OWORD *)&retstr.localOffset.x = v74;
			//   *(_OWORD *)&retstr.localRotation.y = v75;
			//   return result;
			// }
			// 
			return null;
		}

		public bool AutomateGenerateCapsuleSkeletons()
		{
			// // Boolean AutomateGenerateCapsuleSkeletons()
			// bool HG::Rendering::Runtime::HGCapsuleShadowHelper::AutomateGenerateCapsuleSkeletons(
			//         HGCapsuleShadowHelper *this,
			//         MethodInfo *method)
			// {
			//   Transform *transform; // rax
			//   Transform *v4; // rax
			//   Transform *v5; // rax
			//   Transform *v6; // rax
			//   Transform *v7; // rax
			//   Transform *v8; // rax
			//   Transform *v9; // rax
			//   bool v10; // r13
			//   Transform *v11; // rax
			//   bool v12; // r12
			//   Transform *v13; // rax
			//   bool v14; // r15
			//   Transform *v15; // rax
			//   bool v16; // r14
			//   Transform *v17; // rax
			//   bool v18; // si
			//   Transform *v19; // rax
			//   bool v20; // di
			//   Transform *v21; // rax
			//   bool v22; // bl
			//   Transform *v23; // rax
			//   HGCapsuleShadowContainer *CapsuleShadowContainer; // rax
			//   __int128 v25; // xmm10
			//   __int128 v26; // xmm11
			//   __int128 v27; // xmm12
			//   HGCapsuleShadowContainer *v28; // rax
			//   __int128 v29; // xmm13
			//   __int128 v30; // xmm14
			//   __int128 v31; // xmm15
			//   HGCapsuleShadowContainer *v32; // rax
			//   HGCapsuleShadowContainer *v33; // rax
			//   HGCapsuleShadowContainer *v34; // rax
			//   float m_feetSize; // xmm2_4
			//   HGCapsuleShadowContainer *v36; // rax
			//   float v37; // xmm2_4
			//   __int128 v38; // xmm7
			//   __int128 v39; // xmm8
			//   HGCapsuleShadowContainer *v40; // rax
			//   __int128 v41; // xmm6
			//   __int128 v42; // xmm9
			//   OneofDescriptorProto *v43; // rdx
			//   FileDescriptor *v44; // r8
			//   MessageDescriptor *v45; // r9
			//   Animator *v46; // rdx
			//   int32_t v47; // r8d
			//   MethodInfo *v48; // r9
			//   Vector3 *Vector; // rax
			//   OneofDescriptorProto *v50; // rdx
			//   FileDescriptor *v51; // r8
			//   MessageDescriptor *v52; // r9
			//   Animator *v53; // rdx
			//   int32_t v54; // r8d
			//   MethodInfo *v55; // r9
			//   Animator *v56; // rdx
			//   int32_t v57; // r8d
			//   MethodInfo *v58; // r9
			//   Vector3 *v59; // rax
			//   __int64 v60; // rdx
			//   __int64 v61; // xmm0_8
			//   List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *m_capsuleShadowContainers; // rcx
			//   int32_t i; // edi
			//   List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *v64; // rax
			//   float v65; // xmm1_4
			//   float v66; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *methoda; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-E0h]
			//   String *v71; // [rsp+30h] [rbp-D8h]
			//   String *v72; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *v73; // [rsp+38h] [rbp-D0h]
			//   MethodInfo *v74; // [rsp+38h] [rbp-D0h]
			//   bool v75; // [rsp+58h] [rbp-B0h]
			//   bool v76; // [rsp+59h] [rbp-AFh]
			//   bool v77; // [rsp+5Ah] [rbp-AEh]
			//   bool SkeletonTransformByName; // [rsp+5Bh] [rbp-ADh]
			//   HGCapsuleShadowContainer v79; // [rsp+68h] [rbp-A0h] BYREF
			//   Transform *v80; // [rsp+98h] [rbp-70h] BYREF
			//   Transform *v81; // [rsp+A0h] [rbp-68h] BYREF
			//   Transform *v82; // [rsp+A8h] [rbp-60h] BYREF
			//   Transform *v83; // [rsp+B0h] [rbp-58h] BYREF
			//   Transform *t; // [rsp+B8h] [rbp-50h] BYREF
			//   Transform *v85; // [rsp+C0h] [rbp-48h] BYREF
			//   Transform *v86; // [rsp+C8h] [rbp-40h] BYREF
			//   Transform *v87; // [rsp+D0h] [rbp-38h] BYREF
			//   Transform *v88; // [rsp+D8h] [rbp-30h] BYREF
			//   Transform *v89; // [rsp+E0h] [rbp-28h] BYREF
			//   Transform *v90; // [rsp+E8h] [rbp-20h] BYREF
			//   Transform *v91; // [rsp+F0h] [rbp-18h] BYREF
			//   Transform *v92; // [rsp+F8h] [rbp-10h] BYREF
			//   Transform *v93; // [rsp+100h] [rbp-8h] BYREF
			//   HGCapsuleShadowContainer v94; // [rsp+108h] [rbp+0h] BYREF
			//   OneofDescriptor v95; // [rsp+138h] [rbp+30h] BYREF
			//   __int128 v96; // [rsp+188h] [rbp+80h]
			//   Vector3 v97; // [rsp+198h] [rbp+90h] BYREF
			//   __int128 v98; // [rsp+1A8h] [rbp+A0h]
			//   HGCapsuleShadowContainer v99; // [rsp+1B8h] [rbp+B0h]
			//   HGCapsuleShadowContainer v100; // [rsp+1E8h] [rbp+E0h]
			//   __int128 v101; // [rsp+218h] [rbp+110h]
			//   __int128 v102; // [rsp+228h] [rbp+120h]
			//   __int128 v103; // [rsp+238h] [rbp+130h]
			//   __int128 v104; // [rsp+268h] [rbp+160h]
			//   __int128 v105; // [rsp+298h] [rbp+190h]
			//   __int128 v106; // [rsp+2C8h] [rbp+1C0h]
			//   bool v108; // [rsp+3C8h] [rbp+2C0h]
			//   bool v109; // [rsp+3D0h] [rbp+2C8h]
			// 
			//   if ( !byte_18D91975C )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::set_Item);
			//     byte_18D91975C = 1;
			//   }
			//   t = 0LL;
			//   v85 = 0LL;
			//   v80 = 0LL;
			//   v81 = 0LL;
			//   v82 = 0LL;
			//   v83 = 0LL;
			//   v87 = 0LL;
			//   v89 = 0LL;
			//   v86 = 0LL;
			//   v88 = 0LL;
			//   v92 = 0LL;
			//   v93 = 0LL;
			//   v91 = 0LL;
			//   v90 = 0LL;
			//   memset(&v95, 0, 48);
			//   memset(&v94, 0, sizeof(v94));
			//   if ( IFix::WrappersManagerImpl::IsPatched(3479, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3479, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// LABEL_30:
			//     sub_180B536AC(m_capsuleShadowContainers, v60);
			//   }
			//   transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   SkeletonTransformByName = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//                               this,
			//                               &t,
			//                               transform,
			//                               this.fields.m_skeletonName_Hip_R,
			//                               0LL);
			//   v4 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   v77 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//           this,
			//           &v85,
			//           v4,
			//           this.fields.m_skeletonName_Hip_L,
			//           0LL);
			//   v5 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   v76 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//           this,
			//           &v80,
			//           v5,
			//           this.fields.m_skeletonName_Knee_R,
			//           0LL);
			//   v6 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   v75 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//           this,
			//           &v81,
			//           v6,
			//           this.fields.m_skeletonName_Knee_L,
			//           0LL);
			//   v7 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   v109 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//            this,
			//            &v82,
			//            v7,
			//            this.fields.m_skeletonName_Ankle_R,
			//            0LL);
			//   v8 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   v108 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//            this,
			//            &v83,
			//            v8,
			//            this.fields.m_skeletonName_Ankle_L,
			//            0LL);
			//   v9 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   v10 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//           this,
			//           &v92,
			//           v9,
			//           this.fields.m_skeletonName_Trunk,
			//           0LL);
			//   v11 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   v12 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//           this,
			//           &v87,
			//           v11,
			//           this.fields.m_skeletonName_Shoulder_R,
			//           0LL);
			//   v13 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   v14 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//           this,
			//           &v89,
			//           v13,
			//           this.fields.m_skeletonName_Shoulder_L,
			//           0LL);
			//   v15 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   v16 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//           this,
			//           &v86,
			//           v15,
			//           this.fields.m_skeletonName_Wrist_R,
			//           0LL);
			//   v17 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   v18 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//           this,
			//           &v88,
			//           v17,
			//           this.fields.m_skeletonName_Wrist_L,
			//           0LL);
			//   v19 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   v20 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//           this,
			//           &v91,
			//           v19,
			//           this.fields.m_skeletonName_ToesEnd_L,
			//           0LL);
			//   v21 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   v22 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//           this,
			//           &v90,
			//           v21,
			//           this.fields.m_skeletonName_ToesEnd_R,
			//           0LL);
			//   v23 = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//   if ( (v77 & v76 & v75 & v109 & v108 & v10 & v12 & v14 & v16 & v18 & v20 & v22 & HG::Rendering::Runtime::HGCapsuleShadowHelper::GetSkeletonTransformByName(
			//                                                                                     this,
			//                                                                                     &v93,
			//                                                                                     v23,
			//                                                                                     this.fields.m_skeletonName_Head,
			//                                                                                     0LL) & SkeletonTransformByName) == 0 )
			//     return 0;
			//   CapsuleShadowContainer = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
			//                              (HGCapsuleShadowContainer *)&v95.fields.fields,
			//                              this,
			//                              t,
			//                              v80,
			//                              0.07,
			//                              0.0,
			//                              0.0,
			//                              0,
			//                              0LL);
			//   v25 = *(_OWORD *)&CapsuleShadowContainer.rootTransform;
			//   v26 = *(_OWORD *)&CapsuleShadowContainer.localOffset.x;
			//   v27 = *(_OWORD *)&CapsuleShadowContainer.localRotation.y;
			//   v28 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
			//           (HGCapsuleShadowContainer *)&v95.fields.fields,
			//           this,
			//           v85,
			//           v81,
			//           0.07,
			//           0.0,
			//           0.0,
			//           0,
			//           0LL);
			//   v29 = *(_OWORD *)&v28.rootTransform;
			//   v30 = *(_OWORD *)&v28.localOffset.x;
			//   v31 = *(_OWORD *)&v28.localRotation.y;
			//   v32 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
			//           (HGCapsuleShadowContainer *)&v95.fields.fields,
			//           this,
			//           v80,
			//           v82,
			//           0.07,
			//           0.0,
			//           0.07,
			//           0,
			//           0LL);
			//   v101 = *(_OWORD *)&v32.rootTransform;
			//   v102 = *(_OWORD *)&v32.localOffset.x;
			//   v104 = *(_OWORD *)&v32.localRotation.y;
			//   v33 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
			//           (HGCapsuleShadowContainer *)&v95.fields.fields,
			//           this,
			//           v81,
			//           v83,
			//           0.07,
			//           0.0,
			//           0.07,
			//           0,
			//           0LL);
			//   v103 = *(_OWORD *)&v33.rootTransform;
			//   v98 = *(_OWORD *)&v33.localOffset.x;
			//   v105 = *(_OWORD *)&v33.localRotation.y;
			//   v99 = *HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
			//            (HGCapsuleShadowContainer *)&v95.fields.fields,
			//            this,
			//            v87,
			//            v86,
			//            0.07,
			//            0.0,
			//            0.0,
			//            0,
			//            0LL);
			//   v34 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
			//           (HGCapsuleShadowContainer *)&v95.fields.fields,
			//           this,
			//           v89,
			//           v88,
			//           0.07,
			//           0.0,
			//           0.0,
			//           0,
			//           0LL);
			//   m_feetSize = this.fields.m_feetSize;
			//   v100 = *v34;
			//   if ( m_feetSize <= 0.050000001 )
			//     m_feetSize = 0.050000001;
			//   v36 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
			//           (HGCapsuleShadowContainer *)&v95.fields.fields,
			//           this,
			//           v82,
			//           v90,
			//           m_feetSize,
			//           this.fields.m_feetBaseTransformOffset,
			//           this.fields.m_feetTargetTransformOffset,
			//           1,
			//           0LL);
			//   v37 = this.fields.m_feetSize;
			//   v38 = *(_OWORD *)&v36.rootTransform;
			//   v39 = *(_OWORD *)&v36.localOffset.x;
			//   v106 = *(_OWORD *)&v36.localRotation.y;
			//   if ( v37 <= 0.050000001 )
			//     v37 = 0.050000001;
			//   v40 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GenerateCapsuleShadowContainer(
			//           (HGCapsuleShadowContainer *)&v95.fields.fields,
			//           this,
			//           v83,
			//           v91,
			//           v37,
			//           this.fields.m_feetBaseTransformOffset,
			//           this.fields.m_feetTargetTransformOffset,
			//           1,
			//           0LL);
			//   v41 = *(_OWORD *)&v40.rootTransform;
			//   v42 = *(_OWORD *)&v40.localOffset.x;
			//   v96 = *(_OWORD *)&v40.localRotation.y;
			//   BYTE4(v95.fields.containingType) = 1;
			//   v95.monitor = (MonitorData *)0x3F0CCCCD3E19999ALL;
			//   v95.klass = (OneofDescriptor__Class *)v92;
			//   sub_1800054D0(&v95, v43, v44, v45, (String__Array *)methoda, v71, v73);
			//   Vector = UnityEngine::Animator::GetVector(&v97, v46, v47, v48);
			//   *(_QWORD *)&v95.fields._._Index_k__BackingField = *(_QWORD *)&Vector.x;
			//   *(float *)&v95.fields._._FullName_k__BackingField = Vector.z;
			//   v94.rootTransform = v93;
			//   *(__m128i *)((char *)&v95.fields._._FullName_k__BackingField + 4) = _mm_load_si128((const __m128i *)&xmmword_18C371190);
			//   BYTE5(v95.fields.containingType) = 0;
			//   v94.enabled = 1;
			//   *(_QWORD *)&v94.capsuleRadius = 0x3E99999A3E19999ALL;
			//   sub_1800054D0((OneofDescriptor *)&v94, v50, v51, v52, (String__Array *)methodb, v72, v74);
			//   v94.localOffset = *UnityEngine::Animator::GetVector(&v97, v53, v54, v55);
			//   v59 = UnityEngine::Animator::GetVector(&v97, v56, v57, v58);
			//   DWORD2(v105) = 1061158912;
			//   DWORD2(v104) = 1061158912;
			//   DWORD2(v96) = 1061158912;
			//   v61 = *(_QWORD *)&v59.x;
			//   v94.localRotation.z = v59.z;
			//   m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//   *(_QWORD *)&v94.localRotation.x = v61;
			//   v94.intensityScale = 1.0;
			//   v94.isFoot = 0;
			//   DWORD2(v106) = 1061158912;
			//   if ( !m_capsuleShadowContainers )
			//     goto LABEL_30;
			//   System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
			//     (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)m_capsuleShadowContainers,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Clear);
			//   m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//   if ( !m_capsuleShadowContainers )
			//     goto LABEL_30;
			//   *(_OWORD *)&v79.rootTransform = v25;
			//   *(_OWORD *)&v79.localOffset.x = v26;
			//   *(_OWORD *)&v79.localRotation.y = v27;
			//   sub_1804263E0(
			//     m_capsuleShadowContainers,
			//     &v79,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//   m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//   if ( !m_capsuleShadowContainers )
			//     goto LABEL_30;
			//   *(_OWORD *)&v79.rootTransform = v29;
			//   *(_OWORD *)&v79.localOffset.x = v30;
			//   *(_OWORD *)&v79.localRotation.y = v31;
			//   sub_1804263E0(
			//     m_capsuleShadowContainers,
			//     &v79,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//   m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//   if ( !m_capsuleShadowContainers )
			//     goto LABEL_30;
			//   *(_OWORD *)&v79.rootTransform = v101;
			//   *(_OWORD *)&v79.localOffset.x = v102;
			//   *(_OWORD *)&v79.localRotation.y = v104;
			//   sub_1804263E0(
			//     m_capsuleShadowContainers,
			//     &v79,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//   m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//   if ( !m_capsuleShadowContainers )
			//     goto LABEL_30;
			//   *(_OWORD *)&v79.rootTransform = v103;
			//   *(_OWORD *)&v79.localOffset.x = v98;
			//   *(_OWORD *)&v79.localRotation.y = v105;
			//   sub_1804263E0(
			//     m_capsuleShadowContainers,
			//     &v79,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//   m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//   if ( !m_capsuleShadowContainers )
			//     goto LABEL_30;
			//   v79 = v99;
			//   sub_1804263E0(
			//     m_capsuleShadowContainers,
			//     &v79,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//   m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//   if ( !m_capsuleShadowContainers )
			//     goto LABEL_30;
			//   v79 = v100;
			//   sub_1804263E0(
			//     m_capsuleShadowContainers,
			//     &v79,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//   m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//   if ( !m_capsuleShadowContainers )
			//     goto LABEL_30;
			//   *(_OWORD *)&v79.rootTransform = v38;
			//   *(_OWORD *)&v79.localRotation.y = v106;
			//   *(_OWORD *)&v79.localOffset.x = v39;
			//   sub_1804263E0(
			//     m_capsuleShadowContainers,
			//     &v79,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//   m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//   if ( !m_capsuleShadowContainers )
			//     goto LABEL_30;
			//   *(_OWORD *)&v79.rootTransform = v41;
			//   *(_OWORD *)&v79.localRotation.y = v96;
			//   *(_OWORD *)&v79.localOffset.x = v42;
			//   sub_1804263E0(
			//     m_capsuleShadowContainers,
			//     &v79,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//   m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//   if ( !m_capsuleShadowContainers )
			//     goto LABEL_30;
			//   *(_OWORD *)&v79.rootTransform = *(_OWORD *)&v95.klass;
			//   *(_OWORD *)&v79.localOffset.x = *(_OWORD *)&v95.fields._._Index_k__BackingField;
			//   *(_OWORD *)&v79.localRotation.y = *(_OWORD *)&v95.fields._._File_k__BackingField;
			//   sub_1804263E0(
			//     m_capsuleShadowContainers,
			//     &v79,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//   m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//   if ( !m_capsuleShadowContainers )
			//     goto LABEL_30;
			//   v79 = v94;
			//   sub_1804263E0(
			//     m_capsuleShadowContainers,
			//     &v79,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//   for ( i = 0; ; ++i )
			//   {
			//     v64 = this.fields.m_capsuleShadowContainers;
			//     if ( !v64 )
			//       goto LABEL_30;
			//     if ( i >= v64.fields._size )
			//       break;
			//     System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::get_Item(
			//       &v79,
			//       this.fields.m_capsuleShadowContainers,
			//       i,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::get_Item);
			//     *(_OWORD *)&v95.fields.fields = *(_OWORD *)&v79.rootTransform;
			//     v65 = (float)(_mm_shuffle_ps(*(__m128 *)&v79.rootTransform, *(__m128 *)&v79.rootTransform, 255).m128_f32[0] * 0.5)
			//         * 0.25;
			//     v66 = _mm_shuffle_ps(*(__m128 *)&v95.fields.fields, *(__m128 *)&v95.fields.fields, 170).m128_f32[0];
			//     if ( v66 <= v65 )
			//       v66 = v65;
			//     m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//     *(float *)&v95.fields.accessor = v66;
			//     if ( !m_capsuleShadowContainers )
			//       goto LABEL_30;
			//     *(_OWORD *)&v79.rootTransform = *(_OWORD *)&v95.fields.fields;
			//     sub_180606534(
			//       m_capsuleShadowContainers,
			//       (unsigned int)i,
			//       &v79,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::set_Item);
			//   }
			//   HG::Rendering::Runtime::HGCapsuleShadowHelper::AddCapsuleListBinding(this, 0LL);
			//   return 1;
			// }
			// 
			return default(bool);
		}

		public void AutomateGenerateCapsuleSkeletonsNonHuman()
		{
			// // Void AutomateGenerateCapsuleSkeletonsNonHuman()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGCapsuleShadowHelper::AutomateGenerateCapsuleSkeletonsNonHuman(
			//         HGCapsuleShadowHelper *this,
			//         MethodInfo *method)
			// {
			//   HGCapsuleShadowHelper *v2; // rbx
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   GameObject *gameObject; // rax
			//   List_1_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *CapsuleSkeletonsNonHuman; // rax
			//   unsigned __int64 v7; // rdx
			//   signed __int64 v8; // rcx
			//   __m128 v9; // xmm1
			//   __m128i v10; // xmm2
			//   List_1_Beyond_Gameplay_Audio_AudioMapData_AudioLevelGlobalEvents_FEvents_ *m_capsuleShadowContainers; // r9
			//   unsigned __int64 v12; // r8
			//   signed __int64 v13; // rtt
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   __int128 key; // [rsp+20h] [rbp-F8h] BYREF
			//   _OWORD v18[2]; // [rsp+30h] [rbp-E8h] BYREF
			//   Il2CppException *ex; // [rsp+50h] [rbp-C8h]
			//   List_1_T_Enumerator_Beyond_StyledBlackboard_StyledDataPair_ *v20; // [rsp+58h] [rbp-C0h]
			//   List_1_T_Enumerator_Beyond_StyledBlackboard_StyledDataPair_ v21; // [rsp+60h] [rbp-B8h] BYREF
			//   List_1_T_Enumerator_Beyond_StyledBlackboard_StyledDataPair_ v22; // [rsp+A0h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v23; // [rsp+E0h] [rbp-38h] BYREF
			//   _BYTE v24[24]; // [rsp+F8h] [rbp-20h]
			// 
			//   v2 = this;
			//   if ( !byte_18D91975D )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGBoneCapsuleData>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGBoneCapsuleData>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGBoneCapsuleData>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGBoneCapsuleData>::GetEnumerator);
			//     byte_18D91975D = 1;
			//   }
			//   memset(&v21, 0, sizeof(v21));
			//   key = 0LL;
			//   memset(v18, 0, sizeof(v18));
			//   if ( IFix::WrappersManagerImpl::IsPatched(3482, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3482, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v2.fields.m_capsuleShadowContainers )
			//       sub_180B536AC(v4, v3);
			//     System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
			//       (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v2.fields.m_capsuleShadowContainers,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Clear);
			//     gameObject = UnityEngine::Component::get_gameObject((Component *)v2, 0LL);
			//     CapsuleSkeletonsNonHuman = (List_1_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *)HG::Rendering::Runtime::HGBoneCapsuleUtilities::AutomateGenerateCapsuleSkeletonsNonHuman(gameObject, 0LL);
			//     if ( CapsuleSkeletonsNonHuman )
			//     {
			//       System::Collections::Generic::List<Beyond::Gameplay::View::WeaponComponent::WeaponMountPointModifier>::GetEnumerator(
			//         (List_1_T_Enumerator_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *)&v22,
			//         CapsuleSkeletonsNonHuman,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGBoneCapsuleData>::GetEnumerator);
			//       v21 = v22;
			//       ex = 0LL;
			//       v20 = &v21;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::StyledBlackboard::StyledDataPair>::MoveNext(
			//                   &v21,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGBoneCapsuleData>::MoveNext) )
			//         {
			//           v9 = *(__m128 *)&v21._current.dataPair.key;
			//           v10 = *(__m128i *)&v21._current.dataPair.valueStr;
			//           *(_OWORD *)v24 = *(_OWORD *)&v21._current.dataPair.valueStr;
			//           *(_QWORD *)&v24[16] = v21._current.styleStr;
			//           m_capsuleShadowContainers = (List_1_Beyond_Gameplay_Audio_AudioMapData_AudioLevelGlobalEvents_FEvents_ *)v2.fields.m_capsuleShadowContainers;
			//           memset(v18, 0, sizeof(v18));
			//           key = (unsigned __int64)v21._current.dataPair.key;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v12 = (((unsigned __int64)&key >> 12) & 0x1FFFFF) >> 6;
			//             v7 = ((unsigned __int64)&key >> 12) & 0x3F;
			//             _m_prefetchw(&qword_18D6870D0[v12]);
			//             do
			//             {
			//               v8 = qword_18D6870D0[v12] | (1LL << v7);
			//               v13 = qword_18D6870D0[v12];
			//             }
			//             while ( v13 != _InterlockedCompareExchange64(&qword_18D6870D0[v12], v8, v13) );
			//           }
			//           DWORD2(key) = _mm_shuffle_ps(v9, v9, 170).m128_u32[0];
			//           HIDWORD(key) = _mm_shuffle_ps(v9, v9, 255).m128_u32[0];
			//           *(_QWORD *)&v18[0] = v10.m128i_i64[0];
			//           DWORD2(v18[0]) = _mm_cvtsi128_si32(_mm_srli_si128(v10, 8));
			//           *(_QWORD *)((char *)v18 + 12) = *(_QWORD *)&v24[12];
			//           *(_QWORD *)((char *)&v18[1] + 4) = *(unsigned int *)&v24[20] | 0x3F80000000000000LL;
			//           BYTE12(v18[1]) = 1;
			//           if ( !m_capsuleShadowContainers )
			//             sub_1802DC2C8(v8, v7);
			//           *(_OWORD *)&v22._list = key;
			//           *(_OWORD *)&v22._current.dataPair.key = v18[0];
			//           *(_OWORD *)&v22._current.dataPair.valueStr = v18[1];
			//           System::Collections::Generic::List<Beyond::Gameplay::Audio::AudioMapData_AudioLevelGlobalEvents::FEvents>::Add(
			//             m_capsuleShadowContainers,
			//             (AudioMapData_AudioLevelGlobalEvents_FEvents *)&v22,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Add);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v23 )
			//       {
			//         ex = v23.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v2 = this;
			//       }
			//     }
			//     HG::Rendering::Runtime::HGCapsuleShadowHelper::AddCapsuleListBinding(v2, 0LL);
			//   }
			// }
			// 
		}

		private void OnEnable()
		{
			// // Void OnEnable()
			// void HG::Rendering::Runtime::HGCapsuleShadowHelper::OnEnable(HGCapsuleShadowHelper *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v5; // rdx
			//   HGInterationManager *interactionManager_k__BackingField; // rcx
			//   List_1_UnityEngine_Matrix4x4_ *m_cachedCapsuleTransforms; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB7E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Matrix4x4>::Clear);
			//     byte_18D8EDB7E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3483, 0LL) )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows, v3);
			//     HG::Rendering::Runtime::HGCapsuleShadows::EnqueueCapsuleShadowHelper(this, 0LL);
			//     if ( HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//     {
			//       currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//       if ( !currentManagerContext )
			//         goto LABEL_12;
			//       interactionManager_k__BackingField = currentManagerContext.fields._interactionManager_k__BackingField;
			//       if ( !interactionManager_k__BackingField )
			//         goto LABEL_12;
			//       HG::Rendering::Runtime::HGInterationManager::Register(
			//         interactionManager_k__BackingField,
			//         (IHGInteractionObject *)this,
			//         0LL);
			//     }
			//     HG::Rendering::Runtime::HGCapsuleShadowHelper::AddCapsuleListBinding(this, 0LL);
			//     m_cachedCapsuleTransforms = this.fields.m_cachedCapsuleTransforms;
			//     if ( m_cachedCapsuleTransforms )
			//     {
			//       ++m_cachedCapsuleTransforms.fields._version;
			//       m_cachedCapsuleTransforms.fields._size = 0;
			//       return;
			//     }
			// LABEL_12:
			//     sub_180B536AC(interactionManager_k__BackingField, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3483, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private void OnDisable()
		{
			// // Void OnDisable()
			// void HG::Rendering::Runtime::HGCapsuleShadowHelper::OnDisable(HGCapsuleShadowHelper *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGManagerContext *currentManagerContext; // rax
			//   __int64 v5; // rdx
			//   HGInterationManager *interactionManager_k__BackingField; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB7F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
			//     byte_18D8EDB7F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3485, 0LL) )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows, v3);
			//     HG::Rendering::Runtime::HGCapsuleShadows::DequeueCapsuleShadowHelper(this, 0LL);
			//     if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
			//       goto LABEL_10;
			//     currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( currentManagerContext )
			//     {
			//       interactionManager_k__BackingField = currentManagerContext.fields._interactionManager_k__BackingField;
			//       if ( interactionManager_k__BackingField )
			//       {
			//         HG::Rendering::Runtime::HGInterationManager::Unregister(
			//           interactionManager_k__BackingField,
			//           (IHGInteractionObject *)this,
			//           0LL);
			// LABEL_10:
			//         HG::Rendering::Runtime::HGCapsuleShadowHelper::DisableCapsuleListBinding(this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(interactionManager_k__BackingField, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3485, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void CollectInteractionNodes(List<HGInteractionNode> nodes)
		{
			// // Void CollectInteractionNodes(List`1[HG.Rendering.Runtime.HGInteractionNode])
			// void HG::Rendering::Runtime::HGCapsuleShadowHelper::CollectInteractionNodes(
			//         HGCapsuleShadowHelper *this,
			//         List_1_HG_Rendering_Runtime_HGInteractionNode_ *nodes,
			//         MethodInfo *method)
			// {
			//   Object_1 *size; // rcx
			//   __int64 v6; // rdx
			//   __int64 (__fastcall *v7)(HGCapsuleShadowHelper *, __int64, MethodInfo *); // rax
			//   float v8; // xmm9_4
			//   __int64 v9; // rbx
			//   void (__fastcall *v10)(__int64, unsigned __int64 *); // rax
			//   MethodInfo *v11; // r9
			//   Vector3 *v12; // rax
			//   __int64 v13; // xmm3_8
			//   MethodInfo *v14; // r9
			//   Vector3 *v15; // rax
			//   unsigned __int64 v16; // xmm12_8
			//   float z; // esi
			//   PhysicsScene v18; // eax
			//   __int64 v19; // rdx
			//   __int64 v20; // r8
			//   int32_t m_Handle; // ebx
			//   struct Math__Class *v22; // rcx
			//   double v23; // xmm0_8
			//   float v24; // xmm0_4
			//   float v25; // xmm6_4
			//   __m128 v26; // xmm7
			//   __m128 v27; // xmm8
			//   struct Math__Class *v28; // rcx
			//   __m128 v29; // xmm2
			//   __m128d v30; // xmm3
			//   double v31; // xmm0_8
			//   float v32; // xmm0_4
			//   float v33; // xmm6_4
			//   unsigned __int8 (__fastcall *v34)(int32_t *, __m128 *, __int64, __int128 *, int, _DWORD); // rax
			//   __m128 v35; // xmm0
			//   __int64 (__fastcall *v36)(HGCapsuleShadowHelper *); // rax
			//   __int64 v37; // rbx
			//   void (__fastcall *v38)(__int64, unsigned __int64 *); // rax
			//   List_1_UnityEngine_Matrix4x4_ *m_cachedCapsuleTransforms; // rax
			//   float _groundHeight; // xmm11_4
			//   List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *m_capsuleShadowContainers; // rax
			//   HGRenderPipelineSettingHub *instance; // rax
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
			//   bool v44; // r12
			//   unsigned int i; // ebx
			//   List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *v46; // rax
			//   __m128i v47; // xmm8
			//   __m128i v48; // xmm6
			//   __m128 v49; // xmm7
			//   unsigned __int64 v50; // rsi
			//   __int64 (__fastcall *v51)(HGCapsuleShadowHelper *); // rax
			//   __int64 v52; // r14
			//   void (__fastcall *v53)(__int64, Matrix4x4 *); // rax
			//   __int64 v54; // rdx
			//   MethodInfo *v55; // r9
			//   Vector3 *v56; // rax
			//   __int64 v57; // xmm3_8
			//   void (__fastcall *v58)(Vector3 *, __int128 *); // rax
			//   void (__fastcall *v59)(__int64 *, __int128 *, unsigned __int64 *, __int128 *); // rax
			//   __int128 v60; // xmm2
			//   __int128 v61; // xmm3
			//   __int128 v62; // xmm4
			//   __int128 v63; // xmm5
			//   void (__fastcall *v64)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
			//   __int128 v65; // xmm6
			//   __int128 v66; // xmm8
			//   __int128 v67; // xmm9
			//   __int128 v68; // xmm10
			//   float v69; // eax
			//   Matrix4x4 *v70; // rax
			//   __int128 v71; // xmm1
			//   __int128 v72; // xmm0
			//   __int128 v73; // xmm1
			//   void (__fastcall *v74)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *); // rax
			//   __int64 v75; // rax
			//   __int128 v76; // xmm6
			//   __int128 v77; // xmm8
			//   __int128 v78; // xmm9
			//   __int128 v79; // xmm10
			//   Matrix4x4__StaticFields *static_fields; // rcx
			//   __int128 v81; // xmm1
			//   __int128 v82; // xmm0
			//   __int128 v83; // xmm1
			//   Vector4 v84; // xmm6
			//   __m128 *Column; // rax
			//   float x; // xmm3_4
			//   float v87; // xmm4_4
			//   __m128 v88; // xmm2
			//   float v89; // xmm4_4
			//   Vector4 v90; // xmm6
			//   __m128 *v91; // rax
			//   float v92; // xmm3_4
			//   float v93; // xmm4_4
			//   float v94; // xmm1_4
			//   __m128 v95; // xmm2
			//   float v96; // xmm4_4
			//   float v97; // xmm0_4
			//   Vector4 v98; // xmm6
			//   __m128 *v99; // rax
			//   float v100; // xmm3_4
			//   float v101; // xmm4_4
			//   float v102; // xmm1_4
			//   __m128 v103; // xmm2
			//   float v104; // xmm4_4
			//   float v105; // xmm0_4
			//   Vector4 v106; // xmm6
			//   __m128 *v107; // rax
			//   float v108; // xmm3_4
			//   float v109; // xmm4_4
			//   float v110; // xmm1_4
			//   __m128 v111; // xmm2
			//   float v112; // xmm4_4
			//   float v113; // xmm0_4
			//   __int128 v114; // xmm2
			//   __int64 v115; // rax
			//   float v116; // xmm6_4
			//   float v117; // xmm7_4
			//   struct Object_1__Class *v118; // rcx
			//   __int64 v119; // rsi
			//   int32_t v120; // r14d
			//   bool _ccd; // si
			//   __int64 v122; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v123; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGInteractionNode *v125; // rax
			//   __int128 v126; // xmm1
			//   __int128 v127; // xmm0
			//   __int128 v128; // xmm1
			//   __int128 v129; // xmm0
			//   __int128 v130; // xmm1
			//   __int128 v131; // xmm0
			//   __int128 v132; // xmm1
			//   __int128 v133; // xmm0
			//   __int128 v134; // xmm1
			//   __int128 v135; // xmm0
			//   __int128 v136; // xmm1
			//   int32_t j; // ebx
			//   List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *v138; // rax
			//   List_1_UnityEngine_Matrix4x4_ *v139; // rsi
			//   _OWORD *v140; // rax
			//   __int128 v141; // xmm1
			//   __int128 v142; // xmm0
			//   __int128 v143; // xmm1
			//   ILFixDynamicMethodWrapper_2 *v144; // rax
			//   __int64 v145; // rax
			//   __int64 v146; // rax
			//   __int64 v147; // rax
			//   __int64 v148; // rax
			//   __int64 v149; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Matrix4x4 *v151; // rax
			//   ILFixDynamicMethodWrapper_2 *v152; // rax
			//   Matrix4x4 *v153; // rax
			//   int32_t OffsetOfInstanceIDInCPlusPlusObject; // eax
			//   ILFixDynamicMethodWrapper_2 *v155; // rax
			//   List_1_UnityEngine_Matrix4x4_ *v156; // rsi
			//   _OWORD *v157; // rax
			//   __int128 v158; // xmm1
			//   __int128 v159; // xmm0
			//   __int128 v160; // xmm1
			//   __int64 v161; // rax
			//   __int64 v162; // rax
			//   __int64 v163; // rax
			//   __int64 v164; // rax
			//   __int64 v165; // rax
			//   __int64 v166; // rax
			//   unsigned __int64 v167; // [rsp+50h] [rbp-B0h] BYREF
			//   float v168; // [rsp+58h] [rbp-A8h]
			//   Vector3 v169; // [rsp+60h] [rbp-A0h] BYREF
			//   Matrix4x4 v170; // [rsp+70h] [rbp-90h] BYREF
			//   Vector3 v171; // [rsp+B0h] [rbp-50h] BYREF
			//   Matrix4x4 v172; // [rsp+C0h] [rbp-40h] BYREF
			//   Vector3 v173; // [rsp+100h] [rbp+0h] BYREF
			//   Matrix4x4 _transform; // [rsp+110h] [rbp+10h] BYREF
			//   Matrix4x4 v175; // [rsp+150h] [rbp+50h] BYREF
			//   __int64 v176; // [rsp+190h] [rbp+90h] BYREF
			//   int v177; // [rsp+198h] [rbp+98h]
			//   Matrix4x4 _prevTransform; // [rsp+1A0h] [rbp+A0h] BYREF
			//   __m128 v179; // [rsp+1E0h] [rbp+E0h] BYREF
			//   __int128 v180; // [rsp+1F8h] [rbp+F8h] BYREF
			//   __m128 v181; // [rsp+210h] [rbp+110h] BYREF
			//   unsigned __int64 v182; // [rsp+220h] [rbp+120h]
			//   __int128 v183; // [rsp+230h] [rbp+130h] BYREF
			//   __int128 v184; // [rsp+240h] [rbp+140h]
			//   __int128 v185; // [rsp+250h] [rbp+150h]
			//   __int128 v186; // [rsp+260h] [rbp+160h]
			//   __int128 v187; // [rsp+270h] [rbp+170h] BYREF
			//   __int128 v188; // [rsp+280h] [rbp+180h] BYREF
			//   __int128 v189; // [rsp+290h] [rbp+190h]
			//   __int128 v190; // [rsp+2A0h] [rbp+1A0h]
			//   __int128 v191; // [rsp+2B0h] [rbp+1B0h]
			//   Vector3 v192; // [rsp+2C0h] [rbp+1C0h] BYREF
			//   Vector4 v193; // [rsp+2D0h] [rbp+1D0h] BYREF
			//   Vector4 v194; // [rsp+2E0h] [rbp+1E0h] BYREF
			//   Vector4 v195; // [rsp+2F0h] [rbp+1F0h] BYREF
			//   Vector4 v196; // [rsp+300h] [rbp+200h] BYREF
			//   Vector4 v197; // [rsp+310h] [rbp+210h] BYREF
			//   Vector4 v198; // [rsp+320h] [rbp+220h] BYREF
			//   __m256i v199; // [rsp+340h] [rbp+240h]
			//   Matrix4x4 v200; // [rsp+360h] [rbp+260h] BYREF
			//   HGInteractionNode v201; // [rsp+3A0h] [rbp+2A0h] BYREF
			//   Matrix4x4 v202; // [rsp+460h] [rbp+360h] BYREF
			//   HGInteractionNode v203; // [rsp+4A0h] [rbp+3A0h] BYREF
			//   HGInteractionNode v204; // [rsp+560h] [rbp+460h] BYREF
			//   int32_t v205; // [rsp+6F8h] [rbp+5F8h] BYREF
			// 
			//   if ( !byte_18D8EDB80 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Matrix4x4>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Matrix4x4>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Matrix4x4>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Matrix4x4>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Matrix4x4>::set_Item);
			//     byte_18D8EDB80 = 1;
			//   }
			//   memset(&_transform, 0, sizeof(_transform));
			//   memset(&_prevTransform, 0, sizeof(_prevTransform));
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, nodes);
			//     size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = *(_QWORD *)size[7].fields.m_CachedPtr;
			//   if ( !v6 )
			//     goto LABEL_120;
			//   if ( *(int *)(v6 + 24) <= 3490 )
			//     goto LABEL_9;
			//   if ( !LODWORD(size[9].monitor) )
			//   {
			//     il2cpp_runtime_class_init_0(size, v6);
			//     size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = *(_QWORD *)size[7].fields.m_CachedPtr;
			//   if ( !v6 )
			//     goto LABEL_120;
			//   if ( *(_DWORD *)(v6 + 24) <= 0xDA2u )
			// LABEL_131:
			//     sub_180070270(size, v6);
			//   if ( !*(_QWORD *)(v6 + 27952) )
			//   {
			// LABEL_9:
			//     v7 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *, __int64, MethodInfo *))qword_18D8F4D40;
			//     v8 = 32.5;
			//     if ( !qword_18D8F4D40 )
			//     {
			//       v7 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *, __int64, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                                      "UnityEngine.Component::get_transform()");
			//       if ( !v7 )
			//       {
			//         v145 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//         sub_18000F750(v145, 0LL);
			//       }
			//       qword_18D8F4D40 = (__int64)v7;
			//     }
			//     v9 = v7(this, v6, method);
			//     if ( v9 )
			//     {
			//       v167 = 0LL;
			//       v168 = 0.0;
			//       v10 = (void (__fastcall *)(__int64, unsigned __int64 *))qword_18D8F52E0;
			//       if ( !qword_18D8F52E0 )
			//       {
			//         v10 = (void (__fastcall *)(__int64, unsigned __int64 *))il2cpp_resolve_icall_0(
			//                                                                   "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//         if ( !v10 )
			//         {
			//           v146 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//           sub_18000F750(v146, 0LL);
			//         }
			//         qword_18D8F52E0 = (__int64)v10;
			//       }
			//       v10(v9, &v167);
			//       v169.z = 0.0;
			//       *(_QWORD *)&v169.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//       v12 = UnityEngine::Vector3::op_Multiply(&v173, &v169, 0.5, v11);
			//       *(_QWORD *)&v171.x = v167;
			//       v13 = *(_QWORD *)&v12.x;
			//       v169.z = v12.z;
			//       v171.z = v168;
			//       *(_QWORD *)&v169.x = v13;
			//       v15 = UnityEngine::Vector3::op_Addition(&v173, &v171, &v169, v14);
			//       v16 = *(_QWORD *)&v15.x;
			//       z = v15.z;
			//       v18.m_Handle = UnityEngine::Physics::get_defaultPhysicsScene(0LL).m_Handle;
			//       v188 = 0LL;
			//       m_Handle = v18.m_Handle;
			//       v189 = 0LL;
			//       v190 = 0LL;
			//       v191 = 0LL;
			//       if ( !byte_18D8E3AA7 )
			//       {
			//         sub_18003C530(&TypeInfo::System::Math);
			//         byte_18D8E3AA7 = 1;
			//       }
			//       v22 = TypeInfo::System::Math;
			//       if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::System::Math, v19);
			//       if ( 1.0 < 0.0 )
			//         v23 = sub_1801C22C0(v22, v19, v20);
			//       else
			//         *(_QWORD *)&v23 = *(_OWORD *)&_mm_sqrt_pd((__m128d)0x3FF0000000000000uLL);
			//       v24 = v23;
			//       if ( v24 > COERCE_FLOAT(1) )
			//       {
			//         v26 = (__m128)0xBF800000;
			//         v27 = 0LL;
			//         v25 = 0.0 / v24;
			//         v26.m128_f32[0] = -1.0 / v24;
			//         v27.m128_f32[0] = 0.0 / v24;
			//         v179.m128_u64[0] = v16;
			//         v179.m128_f32[2] = z;
			//         if ( !byte_18D8E3A70 )
			//         {
			//           sub_18003C530(&TypeInfo::System::Math);
			//           byte_18D8E3A70 = 1;
			//         }
			//         v28 = TypeInfo::System::Math;
			//         if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::System::Math, v19);
			//         v29 = v26;
			//         v29.m128_f32[0] = (float)((float)(v26.m128_f32[0] * v26.m128_f32[0]) + (float)(v25 * v25))
			//                         + (float)(v27.m128_f32[0] * v27.m128_f32[0]);
			//         v30 = _mm_cvtps_pd(v29);
			//         if ( v30.m128d_f64[0] < 0.0 )
			//           v31 = sub_1801C22C0(v28, v19, v20);
			//         else
			//           *(_QWORD *)&v31 = *(_OWORD *)&_mm_sqrt_pd(v30);
			//         v32 = v31;
			//         if ( v32 <= 0.0000099999997 )
			//         {
			//           v33 = 0.0;
			//           v26 = 0LL;
			//           v27 = 0LL;
			//         }
			//         else
			//         {
			//           v33 = v25 / v32;
			//           v26.m128_f32[0] = v26.m128_f32[0] / v32;
			//           v27.m128_f32[0] = v27.m128_f32[0] / v32;
			//         }
			//         v34 = (unsigned __int8 (__fastcall *)(int32_t *, __m128 *, __int64, __int128 *, int, _DWORD))qword_18D8F6298;
			//         v35 = _mm_shuffle_ps(v179, v179, 147);
			//         v182 = _mm_unpacklo_ps(v26, v27).m128_u64[0];
			//         v35.m128_f32[0] = v33;
			//         v181 = _mm_shuffle_ps(v35, v35, 57);
			//         v205 = m_Handle;
			//         v179 = v181;
			//         if ( !qword_18D8F6298 )
			//         {
			//           v34 = (unsigned __int8 (__fastcall *)(int32_t *, __m128 *, __int64, __int128 *, int, _DWORD))il2cpp_resolve_icall_0("UnityEngine.PhysicsScene::Internal_Raycast_Injected(UnityEngine.PhysicsScene&,UnityEngine.Ray&,System.Single,UnityEngine.RaycastHit&,System.Int32,UnityEngine.QueryTriggerInteraction)");
			//           if ( !v34 )
			//           {
			//             v147 = sub_1802DBBE8(
			//                      "UnityEngine.PhysicsScene::Internal_Raycast_Injected(UnityEngine.PhysicsScene&,UnityEngine.Ray&,Syst"
			//                      "em.Single,UnityEngine.RaycastHit&,System.Int32,UnityEngine.QueryTriggerInteraction)");
			//             sub_18000F750(v147, 0LL);
			//           }
			//           qword_18D8F6298 = (__int64)v34;
			//         }
			//         if ( v34(&v205, &v181, v20, &v188, -5, 0) )
			//           v8 = *((float *)&v189 + 3) - 0.5;
			//       }
			//       v36 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *))qword_18D8F4D40;
			//       if ( !qword_18D8F4D40 )
			//       {
			//         v36 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//         if ( !v36 )
			//         {
			//           v148 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//           sub_18000F750(v148, 0LL);
			//         }
			//         qword_18D8F4D40 = (__int64)v36;
			//       }
			//       v37 = v36(this);
			//       if ( v37 )
			//       {
			//         v167 = 0LL;
			//         v168 = 0.0;
			//         v38 = (void (__fastcall *)(__int64, unsigned __int64 *))qword_18D8F52E0;
			//         if ( !qword_18D8F52E0 )
			//         {
			//           v38 = (void (__fastcall *)(__int64, unsigned __int64 *))il2cpp_resolve_icall_0(
			//                                                                     "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//           if ( !v38 )
			//           {
			//             v149 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//             sub_18000F750(v149, 0LL);
			//           }
			//           qword_18D8F52E0 = (__int64)v38;
			//         }
			//         v38(v37, &v167);
			//         m_cachedCapsuleTransforms = this.fields.m_cachedCapsuleTransforms;
			//         _groundHeight = *((float *)&v167 + 1) - v8;
			//         if ( m_cachedCapsuleTransforms )
			//         {
			//           size = (Object_1 *)(unsigned int)m_cachedCapsuleTransforms.fields._size;
			//           m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//           if ( m_capsuleShadowContainers )
			//           {
			//             if ( (_DWORD)size == m_capsuleShadowContainers.fields._size )
			//             {
			// LABEL_36:
			//               instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
			//               if ( instance )
			//               {
			//                 m_impl = instance.fields.m_impl;
			//                 if ( m_impl )
			//                 {
			//                   v44 = m_impl.fields._currentDeviceType_k__BackingField == 1;
			//                   for ( i = 0; ; ++i )
			//                   {
			//                     v46 = this.fields.m_capsuleShadowContainers;
			//                     if ( !v46 )
			//                       break;
			//                     if ( (signed int)i >= v46.fields._size )
			//                       return;
			//                     if ( i >= v46.fields._size )
			// LABEL_203:
			//                       System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//                     size = (Object_1 *)v46.fields._items;
			//                     if ( !size )
			//                       break;
			//                     if ( i >= LODWORD(size[1].klass) )
			//                       goto LABEL_131;
			//                     v6 = 6LL * (int)i;
			//                     v47 = *(__m128i *)&size[2 * (int)i + 2].fields.m_CachedPtr;
			//                     v48 = *(__m128i *)&size[2 * (int)i + 2].klass;
			//                     v49 = *(__m128 *)&size[2 * (int)i + 1].monitor;
			//                     *(__m128i *)v199.m256i_i8 = v48;
			//                     *(__m128i *)&v199.m256i_u64[2] = v47;
			//                     *(__m128 *)&v172.m00 = v49;
			//                     *(__m128i *)&v172.m01 = v48;
			//                     if ( (unsigned __int8)_mm_cvtsi128_si32(_mm_srli_si128(v47, 12)) )
			//                     {
			//                       v50 = v49.m128_u64[0];
			//                       if ( !v44 )
			//                         goto LABEL_46;
			//                       size = (Object_1 *)size[2 * (int)i + 1].monitor;
			//                       *(__m128i *)&v172.m01 = v48;
			//                       *(__m128i *)&v172.m02 = v47;
			//                       if ( !size )
			//                         break;
			//                       if ( UnityEngine::Object::CompareName(size, this.fields.m_skeletonName_Ankle_L, 0LL) )
			//                         goto LABEL_46;
			//                       if ( !v49.m128_u64[0] )
			//                         break;
			//                       if ( UnityEngine::Object::CompareName(
			//                              (Object_1 *)v49.m128_u64[0],
			//                              this.fields.m_skeletonName_Ankle_R,
			//                              0LL) )
			//                       {
			// LABEL_46:
			//                         if ( !byte_18D8EDB7D )
			//                         {
			//                           sub_18003C530(&TypeInfo::UnityEngine::Object);
			//                           byte_18D8EDB7D = 1;
			//                         }
			//                         if ( !byte_18D8EDC37 )
			//                         {
			//                           sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//                           byte_18D8EDC37 = 1;
			//                         }
			//                         size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//                         if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//                         {
			//                           il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v6);
			//                           size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//                         }
			//                         v6 = *(_QWORD *)size[7].fields.m_CachedPtr;
			//                         if ( !v6 )
			//                           break;
			//                         if ( *(int *)(v6 + 24) <= 1766 )
			//                           goto LABEL_54;
			//                         if ( !LODWORD(size[9].monitor) )
			//                         {
			//                           il2cpp_runtime_class_init_0(size, v6);
			//                           size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//                         }
			//                         size = *(Object_1 **)size[7].fields.m_CachedPtr;
			//                         if ( !size )
			//                           break;
			//                         if ( LODWORD(size[1].klass) <= 0x6E6 )
			//                           goto LABEL_131;
			//                         if ( size[590].klass )
			//                         {
			//                           Patch = IFix::WrappersManagerImpl::GetPatch(1766, 0LL);
			//                           if ( !Patch )
			//                             break;
			//                           *(__m128 *)&v172.m00 = v49;
			//                           *(__m128i *)&v172.m01 = v48;
			//                           *(__m128i *)&v172.m02 = v47;
			//                           v151 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_682(
			//                                    &v175,
			//                                    Patch,
			//                                    (Object *)this,
			//                                    (HGCapsuleShadowContainer *)&v172,
			//                                    0LL);
			//                           v65 = *(_OWORD *)&v151.m00;
			//                           v66 = *(_OWORD *)&v151.m01;
			//                           v67 = *(_OWORD *)&v151.m02;
			//                           v68 = *(_OWORD *)&v151.m03;
			//                         }
			//                         else
			//                         {
			// LABEL_54:
			//                           v51 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *))qword_18D8F4D40;
			//                           if ( !qword_18D8F4D40 )
			//                           {
			//                             v51 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *))il2cpp_resolve_icall_0(
			//                                                                                      "UnityEngine.Component::get_transform()");
			//                             if ( !v51 )
			//                             {
			//                               v161 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//                               sub_18000F750(v161, 0LL);
			//                             }
			//                             qword_18D8F4D40 = (__int64)v51;
			//                           }
			//                           v52 = v51(this);
			//                           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//                           if ( !byte_18D8F4EFB )
			//                           {
			//                             sub_18003C530(&TypeInfo::UnityEngine::Object);
			//                             byte_18D8F4EFB = 1;
			//                           }
			//                           size = (Object_1 *)TypeInfo::UnityEngine::Object;
			//                           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//                           if ( !byte_18D8F4EAF )
			//                           {
			//                             sub_18003C530(&TypeInfo::UnityEngine::Object);
			//                             byte_18D8F4EAF = 1;
			//                           }
			//                           if ( v49.m128_u64[0] )
			//                           {
			//                             size = (Object_1 *)TypeInfo::UnityEngine::Object;
			//                             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//                             if ( *(_QWORD *)(v49.m128_u64[0] + 16) )
			//                               v52 = v49.m128_u64[0];
			//                           }
			//                           if ( !v52 )
			//                             break;
			//                           v53 = (void (__fastcall *)(__int64, Matrix4x4 *))qword_18D8F5338;
			//                           memset(&v170, 0, sizeof(v170));
			//                           if ( !qword_18D8F5338 )
			//                           {
			//                             v53 = (void (__fastcall *)(__int64, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                                "UnityEngine.Transform::get_localToWorldMa"
			//                                                                                "trix_Injected(UnityEngine.Matrix4x4&)");
			//                             if ( !v53 )
			//                             {
			//                               v162 = sub_1802DBBE8("UnityEngine.Transform::get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4&)");
			//                               sub_18000F750(v162, 0LL);
			//                             }
			//                             qword_18D8F5338 = (__int64)v53;
			//                           }
			//                           v53(v52, &v170);
			//                           if ( !byte_18D8EDC37 )
			//                           {
			//                             sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//                             byte_18D8EDC37 = 1;
			//                           }
			//                           size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//                           if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//                           {
			//                             il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v54);
			//                             size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//                           }
			//                           v6 = *(_QWORD *)size[7].fields.m_CachedPtr;
			//                           if ( !v6 )
			//                             break;
			//                           if ( *(int *)(v6 + 24) <= 1767 )
			//                             goto LABEL_76;
			//                           if ( !LODWORD(size[9].monitor) )
			//                           {
			//                             il2cpp_runtime_class_init_0(size, v6);
			//                             size = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//                           }
			//                           size = *(Object_1 **)size[7].fields.m_CachedPtr;
			//                           if ( !size )
			//                             break;
			//                           if ( LODWORD(size[1].klass) <= 0x6E7 )
			//                             goto LABEL_131;
			//                           if ( size[590].monitor )
			//                           {
			//                             v152 = IFix::WrappersManagerImpl::GetPatch(1767, 0LL);
			//                             if ( !v152 )
			//                               break;
			//                             *(__m128 *)&v172.m00 = v49;
			//                             *(__m128i *)&v172.m01 = v48;
			//                             *(__m128i *)&v172.m02 = v47;
			//                             v153 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_682(
			//                                      &v202,
			//                                      v152,
			//                                      (Object *)this,
			//                                      (HGCapsuleShadowContainer *)&v172,
			//                                      0LL);
			//                             v60 = *(_OWORD *)&v153.m00;
			//                             v61 = *(_OWORD *)&v153.m01;
			//                             v62 = *(_OWORD *)&v153.m02;
			//                             v63 = *(_OWORD *)&v153.m03;
			//                           }
			//                           else
			//                           {
			// LABEL_76:
			//                             *(_QWORD *)&v171.x = *(__int64 *)((char *)&v199.m256i_i64[1] + 4);
			//                             LODWORD(v171.z) = _mm_cvtsi128_si32(_mm_srli_si128(v47, 4));
			//                             v56 = UnityEngine::Vector3::op_Multiply(&v192, &v171, 0.017453292, v55);
			//                             v180 = 0LL;
			//                             v57 = *(_QWORD *)&v56.x;
			//                             v169.z = v56.z;
			//                             v58 = (void (__fastcall *)(Vector3 *, __int128 *))qword_18D8F4C40;
			//                             *(_QWORD *)&v169.x = v57;
			//                             if ( !qword_18D8F4C40 )
			//                             {
			//                               v58 = (void (__fastcall *)(Vector3 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                                                   "UnityEngine.Quaternion::Internal_FromE"
			//                                                                                   "ulerRad_Injected(UnityEngine.Vector3&,"
			//                                                                                   "UnityEngine.Quaternion&)");
			//                               if ( !v58 )
			//                               {
			//                                 v163 = sub_1802DBBE8(
			//                                          "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,Uni"
			//                                          "tyEngine.Quaternion&)");
			//                                 sub_18000F750(v163, 0LL);
			//                               }
			//                               qword_18D8F4C40 = (__int64)v58;
			//                             }
			//                             v58(&v169, &v180);
			//                             v59 = (void (__fastcall *)(__int64 *, __int128 *, unsigned __int64 *, __int128 *))qword_18D8F4BC8;
			//                             v167 = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//                             v176 = v48.m128i_i64[0];
			//                             v168 = 1.0;
			//                             v177 = _mm_cvtsi128_si32(_mm_srli_si128(v48, 8));
			//                             v187 = v180;
			//                             v183 = 0LL;
			//                             v184 = 0LL;
			//                             v185 = 0LL;
			//                             v186 = 0LL;
			//                             if ( !qword_18D8F4BC8 )
			//                             {
			//                               v59 = (void (__fastcall *)(__int64 *, __int128 *, unsigned __int64 *, __int128 *))il2cpp_resolve_icall_0("UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,UnityEngine.Matrix4x4&)");
			//                               if ( !v59 )
			//                               {
			//                                 v164 = sub_1802DBBE8(
			//                                          "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion"
			//                                          "&,UnityEngine.Vector3&,UnityEngine.Matrix4x4&)");
			//                                 sub_18000F750(v164, 0LL);
			//                               }
			//                               qword_18D8F4BC8 = (__int64)v59;
			//                             }
			//                             v59(&v176, &v187, &v167, &v183);
			//                             v60 = v183;
			//                             v61 = v184;
			//                             v62 = v185;
			//                             v63 = v186;
			//                           }
			//                           v64 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18D8F4BC0;
			//                           *(_OWORD *)&v172.m00 = v60;
			//                           v175 = v170;
			//                           *(_OWORD *)&v172.m01 = v61;
			//                           *(_OWORD *)&v172.m02 = v62;
			//                           *(_OWORD *)&v172.m03 = v63;
			//                           memset(&v170, 0, sizeof(v170));
			//                           if ( !qword_18D8F4BC0 )
			//                           {
			//                             v64 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                                                 "UnityEngine.Matrix4x4::H"
			//                                                                                                 "GMultiplyMatrix4x4Fast_I"
			//                                                                                                 "njected(UnityEngine.Matr"
			//                                                                                                 "ix4x4&,UnityEngine.Matri"
			//                                                                                                 "x4x4&,UnityEngine.Matrix4x4&)");
			//                             if ( !v64 )
			//                             {
			//                               v165 = sub_1802DBBE8(
			//                                        "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,Un"
			//                                        "ityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//                               sub_18000F750(v165, 0LL);
			//                             }
			//                             qword_18D8F4BC0 = (__int64)v64;
			//                           }
			//                           v64(&v175, &v172, &v170);
			//                           v65 = *(_OWORD *)&v170.m00;
			//                           v66 = *(_OWORD *)&v170.m01;
			//                           v67 = *(_OWORD *)&v170.m02;
			//                           v68 = *(_OWORD *)&v170.m03;
			//                         }
			//                         v69 = this.fields.m_centerOffset.z;
			//                         *(_QWORD *)&v173.x = *(_QWORD *)&this.fields.m_centerOffset.x;
			//                         *(_OWORD *)&_transform.m00 = v65;
			//                         *(_OWORD *)&_transform.m01 = v66;
			//                         *(_OWORD *)&_transform.m02 = v67;
			//                         *(_OWORD *)&_transform.m03 = v68;
			//                         v173.z = v69;
			//                         v70 = UnityEngine::Matrix4x4::Translate(&v200, &v173, 0LL);
			//                         *(_OWORD *)&v175.m00 = v65;
			//                         *(_OWORD *)&v175.m01 = v66;
			//                         *(_OWORD *)&v175.m02 = v67;
			//                         v71 = *(_OWORD *)&v70.m01;
			//                         *(_OWORD *)&v172.m00 = *(_OWORD *)&v70.m00;
			//                         v72 = *(_OWORD *)&v70.m02;
			//                         *(_OWORD *)&v172.m01 = v71;
			//                         v73 = *(_OWORD *)&v70.m03;
			//                         v74 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))qword_18D8F4BC0;
			//                         *(_OWORD *)&v172.m02 = v72;
			//                         *(_OWORD *)&v172.m03 = v73;
			//                         *(_OWORD *)&v175.m03 = v68;
			//                         memset(&v170, 0, sizeof(v170));
			//                         if ( !qword_18D8F4BC0 )
			//                         {
			//                           v74 = (void (__fastcall *)(Matrix4x4 *, Matrix4x4 *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                                               "UnityEngine.Matrix4x4::HGM"
			//                                                                                               "ultiplyMatrix4x4Fast_Injec"
			//                                                                                               "ted(UnityEngine.Matrix4x4&"
			//                                                                                               ",UnityEngine.Matrix4x4&,Un"
			//                                                                                               "ityEngine.Matrix4x4&)");
			//                           if ( !v74 )
			//                           {
			//                             v166 = sub_1802DBBE8(
			//                                      "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,Unit"
			//                                      "yEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
			//                             sub_18000F750(v166, 0LL);
			//                           }
			//                           qword_18D8F4BC0 = (__int64)v74;
			//                         }
			//                         v74(&v172, &v175, &v170);
			//                         size = (Object_1 *)this.fields.m_cachedCapsuleTransforms;
			//                         _transform = v170;
			//                         if ( !size )
			//                           break;
			//                         if ( i >= LODWORD(size[1].klass) )
			//                           goto LABEL_203;
			//                         size = (Object_1 *)size.fields.m_CachedPtr;
			//                         if ( !size )
			//                           break;
			//                         if ( i >= LODWORD(size[1].klass) )
			//                           goto LABEL_131;
			//                         v75 = (__int64)(int)i << 6;
			//                         _prevTransform = *(Matrix4x4 *)((char *)&size[1].monitor + v75);
			//                         v76 = *(_OWORD *)((char *)&size[1].monitor + v75);
			//                         v77 = *(_OWORD *)((char *)&size[2].klass + v75);
			//                         v78 = *(_OWORD *)((char *)&size[2].fields.m_CachedPtr + v75);
			//                         v79 = *(_OWORD *)((char *)&size[3].monitor + v75);
			//                         if ( !byte_18D8E3B20 )
			//                         {
			//                           sub_18003C530(&TypeInfo::UnityEngine::Matrix4x4);
			//                           byte_18D8E3B20 = 1;
			//                         }
			//                         *(_OWORD *)&v170.m00 = v76;
			//                         *(_OWORD *)&v170.m01 = v77;
			//                         *(_OWORD *)&v170.m02 = v78;
			//                         static_fields = TypeInfo::UnityEngine::Matrix4x4.static_fields;
			//                         *(_OWORD *)&v170.m03 = v79;
			//                         v81 = *(_OWORD *)&static_fields.identityMatrix.m01;
			//                         *(_OWORD *)&v172.m00 = *(_OWORD *)&static_fields.identityMatrix.m00;
			//                         v82 = *(_OWORD *)&static_fields.identityMatrix.m02;
			//                         *(_OWORD *)&v172.m01 = v81;
			//                         v83 = *(_OWORD *)&static_fields.identityMatrix.m03;
			//                         *(_OWORD *)&v172.m02 = v82;
			//                         *(_OWORD *)&v172.m03 = v83;
			//                         v84 = *UnityEngine::Matrix4x4::GetColumn(&v193, &v170, 0, 0LL);
			//                         Column = (__m128 *)UnityEngine::Matrix4x4::GetColumn(&v194, &v172, 0, 0LL);
			//                         x = v84.x;
			//                         v87 = _mm_shuffle_ps((__m128)v84, (__m128)v84, 85).m128_f32[0];
			//                         *(float *)&v83 = _mm_shuffle_ps((__m128)v84, (__m128)v84, 170).m128_f32[0];
			//                         v88 = *Column;
			//                         v84.x = _mm_shuffle_ps((__m128)v84, (__m128)v84, 255).m128_f32[0];
			//                         v89 = v87 - _mm_shuffle_ps(v88, v88, 85).m128_f32[0];
			//                         *(float *)&v82 = _mm_shuffle_ps(*Column, *Column, 170).m128_f32[0];
			//                         v88.m128_f32[0] = _mm_shuffle_ps(v88, v88, 255).m128_f32[0];
			//                         if ( (float)((float)((float)((float)(v89 * v89)
			//                                                    + (float)((float)(x - COERCE_FLOAT(*Column))
			//                                                            * (float)(x - COERCE_FLOAT(*Column))))
			//                                            + (float)((float)(*(float *)&v83 - *(float *)&v82)
			//                                                    * (float)(*(float *)&v83 - *(float *)&v82)))
			//                                    + (float)((float)(v84.x - v88.m128_f32[0]) * (float)(v84.x - v88.m128_f32[0]))) >= 9.9999994e-11 )
			//                           goto LABEL_92;
			//                         v90 = *UnityEngine::Matrix4x4::GetColumn(&v195, &v170, 1, 0LL);
			//                         v91 = (__m128 *)UnityEngine::Matrix4x4::GetColumn(&v196, &v172, 1, 0LL);
			//                         v92 = v90.x;
			//                         v93 = _mm_shuffle_ps((__m128)v90, (__m128)v90, 85).m128_f32[0];
			//                         v94 = _mm_shuffle_ps((__m128)v90, (__m128)v90, 170).m128_f32[0];
			//                         v95 = *v91;
			//                         v90.x = _mm_shuffle_ps((__m128)v90, (__m128)v90, 255).m128_f32[0];
			//                         v96 = v93 - _mm_shuffle_ps(v95, v95, 85).m128_f32[0];
			//                         v97 = _mm_shuffle_ps(*v91, *v91, 170).m128_f32[0];
			//                         v95.m128_f32[0] = _mm_shuffle_ps(v95, v95, 255).m128_f32[0];
			//                         if ( (float)((float)((float)((float)(v96 * v96)
			//                                                    + (float)((float)(v92 - COERCE_FLOAT(*v91))
			//                                                            * (float)(v92 - COERCE_FLOAT(*v91))))
			//                                            + (float)((float)(v94 - v97) * (float)(v94 - v97)))
			//                                    + (float)((float)(v90.x - v95.m128_f32[0]) * (float)(v90.x - v95.m128_f32[0]))) >= 9.9999994e-11 )
			//                           goto LABEL_92;
			//                         v98 = *UnityEngine::Matrix4x4::GetColumn(&v197, &v170, 2, 0LL);
			//                         v99 = (__m128 *)UnityEngine::Matrix4x4::GetColumn(&v198, &v172, 2, 0LL);
			//                         v100 = v98.x;
			//                         v101 = _mm_shuffle_ps((__m128)v98, (__m128)v98, 85).m128_f32[0];
			//                         v102 = _mm_shuffle_ps((__m128)v98, (__m128)v98, 170).m128_f32[0];
			//                         v103 = *v99;
			//                         v98.x = _mm_shuffle_ps((__m128)v98, (__m128)v98, 255).m128_f32[0];
			//                         v104 = v101 - _mm_shuffle_ps(v103, v103, 85).m128_f32[0];
			//                         v105 = _mm_shuffle_ps(*v99, *v99, 170).m128_f32[0];
			//                         v103.m128_f32[0] = _mm_shuffle_ps(v103, v103, 255).m128_f32[0];
			//                         if ( (float)((float)((float)((float)(v104 * v104)
			//                                                    + (float)((float)(v100 - COERCE_FLOAT(*v99))
			//                                                            * (float)(v100 - COERCE_FLOAT(*v99))))
			//                                            + (float)((float)(v102 - v105) * (float)(v102 - v105)))
			//                                    + (float)((float)(v98.x - v103.m128_f32[0]) * (float)(v98.x - v103.m128_f32[0]))) >= 9.9999994e-11 )
			//                           goto LABEL_92;
			//                         v106 = *UnityEngine::Matrix4x4::GetColumn((Vector4 *)&v181, &v170, 3, 0LL);
			//                         v107 = (__m128 *)UnityEngine::Matrix4x4::GetColumn((Vector4 *)&v179, &v172, 3, 0LL);
			//                         v108 = v106.x;
			//                         v109 = _mm_shuffle_ps((__m128)v106, (__m128)v106, 85).m128_f32[0];
			//                         v110 = _mm_shuffle_ps((__m128)v106, (__m128)v106, 170).m128_f32[0];
			//                         v111 = *v107;
			//                         v106.x = _mm_shuffle_ps((__m128)v106, (__m128)v106, 255).m128_f32[0];
			//                         v112 = v109 - _mm_shuffle_ps(v111, v111, 85).m128_f32[0];
			//                         v113 = _mm_shuffle_ps(*v107, *v107, 170).m128_f32[0];
			//                         v111.m128_f32[0] = _mm_shuffle_ps(v111, v111, 255).m128_f32[0];
			//                         if ( (float)((float)((float)((float)(v112 * v112)
			//                                                    + (float)((float)(v108 - COERCE_FLOAT(*v107))
			//                                                            * (float)(v108 - COERCE_FLOAT(*v107))))
			//                                            + (float)((float)(v110 - v113) * (float)(v110 - v113)))
			//                                    + (float)((float)(v106.x - v111.m128_f32[0]) * (float)(v106.x - v111.m128_f32[0]))) < 9.9999994e-11 )
			//                         {
			//                           v114 = *(_OWORD *)&_transform.m00;
			//                           _prevTransform = _transform;
			//                         }
			//                         else
			//                         {
			// LABEL_92:
			//                           v114 = *(_OWORD *)&_transform.m00;
			//                         }
			//                         v6 = (__int64)this.fields.m_cachedCapsuleTransforms;
			//                         if ( !v6 )
			//                           break;
			//                         if ( i >= *(_DWORD *)(v6 + 24) )
			//                           goto LABEL_203;
			//                         size = *(Object_1 **)(v6 + 16);
			//                         if ( !size )
			//                           break;
			//                         if ( i >= LODWORD(size[1].klass) )
			//                           goto LABEL_131;
			//                         v115 = (__int64)(int)i << 6;
			//                         *(_OWORD *)((char *)&size[1].monitor + v115) = v114;
			//                         *(_OWORD *)((char *)&size[2].klass + v115) = *(_OWORD *)&_transform.m01;
			//                         *(_OWORD *)((char *)&size[2].fields.m_CachedPtr + v115) = *(_OWORD *)&_transform.m02;
			//                         *(_OWORD *)((char *)&size[3].monitor + v115) = *(_OWORD *)&_transform.m03;
			//                         ++*(_DWORD *)(v6 + 28);
			//                         v116 = _mm_shuffle_ps(v49, v49, 170).m128_f32[0] * this.fields.m_radiusScale;
			//                         v117 = _mm_shuffle_ps(v49, v49, 255).m128_f32[0] * this.fields.m_heightScale;
			//                         if ( !v50 )
			//                           break;
			//                         if ( !byte_18D8F4EAC )
			//                         {
			//                           sub_18003C530(&TypeInfo::UnityEngine::Object);
			//                           byte_18D8F4EAC = 1;
			//                         }
			//                         if ( *(_QWORD *)(v50 + 16) )
			//                         {
			//                           v118 = TypeInfo::UnityEngine::Object;
			//                           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                           {
			//                             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//                             v118 = TypeInfo::UnityEngine::Object;
			//                           }
			//                           if ( v118.static_fields.OffsetOfInstanceIDInCPlusPlusObject == -1 )
			//                           {
			//                             if ( !v118._1.cctor_finished_or_no_cctor )
			//                               il2cpp_runtime_class_init_0(v118, v6);
			//                             OffsetOfInstanceIDInCPlusPlusObject = UnityEngine::Object::GetOffsetOfInstanceIDInCPlusPlusObject(0LL);
			//                             v6 = (__int64)TypeInfo::UnityEngine::Object.static_fields;
			//                             *(_DWORD *)v6 = OffsetOfInstanceIDInCPlusPlusObject;
			//                             v118 = TypeInfo::UnityEngine::Object;
			//                           }
			//                           v119 = *(_QWORD *)(v50 + 16);
			//                           if ( !v118._1.cctor_finished_or_no_cctor )
			//                           {
			//                             il2cpp_runtime_class_init_0(v118, v6);
			//                             v118 = TypeInfo::UnityEngine::Object;
			//                           }
			//                           v120 = *(_DWORD *)(v118.static_fields.OffsetOfInstanceIDInCPlusPlusObject + v119);
			//                         }
			//                         else
			//                         {
			//                           v120 = 0;
			//                         }
			//                         _ccd = this.fields.m_enableCCD;
			//                         sub_1802F01E0(&v201, 0LL, 192LL);
			//                         if ( !byte_18D8EDC37 )
			//                         {
			//                           sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//                           byte_18D8EDC37 = 1;
			//                         }
			//                         v123 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//                         if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//                         {
			//                           il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v122);
			//                           v123 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//                         }
			//                         wrapperArray = v123.static_fields.wrapperArray;
			//                         if ( !wrapperArray )
			// LABEL_130:
			//                           sub_180B536AC(v123, wrapperArray);
			//                         if ( wrapperArray.max_length.size <= 1515 )
			//                           goto LABEL_113;
			//                         if ( !v123._1.cctor_finished_or_no_cctor )
			//                         {
			//                           il2cpp_runtime_class_init_0(v123, wrapperArray);
			//                           v123 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//                         }
			//                         v123 = (struct ILFixDynamicMethodWrapper_2__Class *)v123.static_fields.wrapperArray;
			//                         if ( !v123 )
			//                           goto LABEL_130;
			//                         if ( LODWORD(v123._0.namespaze) <= 0x5EB )
			//                           sub_180070270(v123, wrapperArray);
			//                         if ( v123[32]._0.klass )
			//                         {
			//                           v155 = IFix::WrappersManagerImpl::GetPatch(1515, 0LL);
			//                           if ( !v155 )
			//                             goto LABEL_130;
			//                           v125 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_577(
			//                                    &v204,
			//                                    v155,
			//                                    v120,
			//                                    v117,
			//                                    v116,
			//                                    &_transform,
			//                                    &_prevTransform,
			//                                    _groundHeight,
			//                                    _ccd,
			//                                    0LL);
			//                         }
			//                         else
			//                         {
			// LABEL_113:
			//                           sub_1802F01E0(&v201, 0LL, 192LL);
			//                           HG::Rendering::Runtime::HGInteractionNode::ConstructCapsuleNode(
			//                             &v201,
			//                             v120,
			//                             v117,
			//                             v116,
			//                             &_transform,
			//                             &_prevTransform,
			//                             _groundHeight,
			//                             _ccd,
			//                             0LL);
			//                           v125 = &v201;
			//                         }
			//                         size = (Object_1 *)&v203;
			//                         v126 = *(_OWORD *)&v125.localToWorldMatrix.m20;
			//                         *(_OWORD *)&v203.NodeKey = *(_OWORD *)&v125.NodeKey;
			//                         v127 = *(_OWORD *)&v125.localToWorldMatrix.m21;
			//                         *(_OWORD *)&v203.localToWorldMatrix.m20 = v126;
			//                         v128 = *(_OWORD *)&v125.localToWorldMatrix.m22;
			//                         *(_OWORD *)&v203.localToWorldMatrix.m21 = v127;
			//                         v129 = *(_OWORD *)&v125.localToWorldMatrix.m23;
			//                         *(_OWORD *)&v203.localToWorldMatrix.m22 = v128;
			//                         v130 = *(_OWORD *)&v125.prevLocalToWorldMatrix.m20;
			//                         *(_OWORD *)&v203.localToWorldMatrix.m23 = v129;
			//                         v131 = *(_OWORD *)&v125.prevLocalToWorldMatrix.m21;
			//                         *(_OWORD *)&v203.prevLocalToWorldMatrix.m20 = v130;
			//                         v132 = *(_OWORD *)&v125.prevLocalToWorldMatrix.m22;
			//                         *(_OWORD *)&v203.prevLocalToWorldMatrix.m21 = v131;
			//                         v133 = *(_OWORD *)&v125.prevLocalToWorldMatrix.m23;
			//                         *(_OWORD *)&v203.prevLocalToWorldMatrix.m22 = v132;
			//                         v134 = *(_OWORD *)&v125.length;
			//                         *(_OWORD *)&v203.prevLocalToWorldMatrix.m23 = v133;
			//                         v135 = *(_OWORD *)&v125.texture;
			//                         *(_OWORD *)&v203.length = v134;
			//                         v136 = *(_OWORD *)&v125.heightScale;
			//                         *(_OWORD *)&v203.texture = v135;
			//                         *(_OWORD *)&v203.heightScale = v136;
			//                         if ( !nodes )
			//                           break;
			//                         v201 = v203;
			//                         sub_182BAE300(
			//                           nodes,
			//                           &v201,
			//                           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::Add);
			//                       }
			//                     }
			//                     else
			//                     {
			//                       v156 = this.fields.m_cachedCapsuleTransforms;
			//                       v157 = (_OWORD *)sub_182805160(&v200);
			//                       if ( !v156 )
			//                         break;
			//                       v158 = v157[1];
			//                       *(_OWORD *)&v175.m00 = *v157;
			//                       v159 = v157[2];
			//                       *(_OWORD *)&v175.m01 = v158;
			//                       v160 = v157[3];
			//                       *(_OWORD *)&v175.m02 = v159;
			//                       *(_OWORD *)&v175.m03 = v160;
			//                       sub_180609178(
			//                         v156,
			//                         i,
			//                         &v175,
			//                         MethodInfo::System::Collections::Generic::List<UnityEngine::Matrix4x4>::set_Item);
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//             else
			//             {
			//               size = (Object_1 *)this.fields.m_cachedCapsuleTransforms;
			//               ++HIDWORD(size[1].klass);
			//               LODWORD(size[1].klass) = 0;
			//               for ( j = 0; ; ++j )
			//               {
			//                 v138 = this.fields.m_capsuleShadowContainers;
			//                 if ( !v138 )
			//                   break;
			//                 if ( j >= v138.fields._size )
			//                   goto LABEL_36;
			//                 v139 = this.fields.m_cachedCapsuleTransforms;
			//                 v140 = (_OWORD *)sub_182805160(&v175);
			//                 if ( !v139 )
			//                   break;
			//                 v141 = v140[1];
			//                 *(_OWORD *)&v170.m00 = *v140;
			//                 v142 = v140[2];
			//                 *(_OWORD *)&v170.m01 = v141;
			//                 v143 = v140[3];
			//                 *(_OWORD *)&v170.m02 = v142;
			//                 *(_OWORD *)&v170.m03 = v143;
			//                 sub_182CCF520(v139, &v170, MethodInfo::System::Collections::Generic::List<UnityEngine::Matrix4x4>::Add);
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_120:
			//     sub_180B536AC(size, v6);
			//   }
			//   v144 = IFix::WrappersManagerImpl::GetPatch(3490, 0LL);
			//   if ( !v144 )
			//     goto LABEL_120;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)v144,
			//     (Object *)this,
			//     (Object *)nodes,
			//     0LL);
			// }
			// 
		}

		private void AddCapsuleBinding(HGCapsuleShadowContainer container)
		{
			// // Void AddCapsuleBinding(HGCapsuleShadowContainer)
			// void HG::Rendering::Runtime::HGCapsuleShadowHelper::AddCapsuleBinding(
			//         HGCapsuleShadowHelper *this,
			//         HGCapsuleShadowContainer *container,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   bool v6; // r14
			//   __int128 v7; // xmm1
			//   bool v8; // zf
			//   __int128 v9; // xmm6
			//   __int64 v10; // rdx
			//   Component *rootTransform; // rcx
			//   __int128 v12; // xmm1
			//   GameObject *v13; // rax
			//   Object *v14; // rax
			//   Object *v15; // rdi
			//   __int128 v16; // xmm1
			//   __int64 v17; // rcx
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm2
			//   float capsuleRadius; // xmm1_4
			//   __int128 v21; // xmm2
			//   float capsuleHeight; // xmm1_4
			//   void (__fastcall *v23)(Object *, __int64 *); // rax
			//   __int128 v24; // xmm0
			//   void (__fastcall *v25)(Object *, __int64 *); // rax
			//   __int128 v26; // xmm1
			//   GameObject *gameObject; // rax
			//   __int64 v28; // rax
			//   __int64 v29; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int64 v33; // [rsp+20h] [rbp-60h] BYREF
			//   int v34; // [rsp+28h] [rbp-58h]
			//   __int64 v35; // [rsp+30h] [rbp-50h] BYREF
			//   int v36; // [rsp+38h] [rbp-48h]
			//   HGCapsuleShadowContainer v37; // [rsp+40h] [rbp-40h] BYREF
			// 
			//   if ( !byte_18D8EDB81 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGCapsuleShadowHelper::GetOrAddComponent<UnityEngine::HGCapsuleBindingComponent>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB81 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3481, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3481, 0LL);
			//     if ( Patch )
			//     {
			//       v31 = *(_OWORD *)&container.localOffset.x;
			//       *(_OWORD *)&v37.rootTransform = *(_OWORD *)&container.rootTransform;
			//       v32 = *(_OWORD *)&container.localRotation.y;
			//       *(_OWORD *)&v37.localOffset.x = v31;
			//       *(_OWORD *)&v37.localRotation.y = v32;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1246(Patch, (Object *)this, &v37, 0LL);
			//       return;
			//     }
			//     goto LABEL_17;
			//   }
			//   v6 = 0;
			//   v7 = *(_OWORD *)&container.localRotation.y;
			//   v8 = TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor == 0;
			//   v9 = *(_OWORD *)&container.rootTransform;
			//   *(_OWORD *)&v37.localOffset.x = *(_OWORD *)&container.localOffset.x;
			//   *(_OWORD *)&v37.localRotation.y = v7;
			//   if ( v8 )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//   if ( UnityEngine::Object::op_Equality((Object_1 *)v9, 0LL, 0LL) )
			//   {
			//     gameObject = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
			//     v15 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetOrAddComponent<System::Object>(
			//             gameObject,
			//             MethodInfo::HG::Rendering::Runtime::HGCapsuleShadowHelper::GetOrAddComponent<UnityEngine::HGCapsuleBindingComponent>);
			//     goto LABEL_12;
			//   }
			//   rootTransform = (Component *)container.rootTransform;
			//   v12 = *(_OWORD *)&container.localRotation.y;
			//   *(_OWORD *)&v37.localOffset.x = *(_OWORD *)&container.localOffset.x;
			//   *(_OWORD *)&v37.localRotation.y = v12;
			//   if ( !rootTransform )
			//     goto LABEL_17;
			//   v13 = UnityEngine::Component::get_gameObject(rootTransform, 0LL);
			//   v14 = HG::Rendering::Runtime::HGCapsuleShadowHelper::GetOrAddComponent<System::Object>(
			//           v13,
			//           MethodInfo::HG::Rendering::Runtime::HGCapsuleShadowHelper::GetOrAddComponent<UnityEngine::HGCapsuleBindingComponent>);
			//   rootTransform = (Component *)container.rootTransform;
			//   v15 = v14;
			//   v16 = *(_OWORD *)&container.localRotation.y;
			//   *(_OWORD *)&v37.localOffset.x = *(_OWORD *)&container.localOffset.x;
			//   *(_OWORD *)&v37.localRotation.y = v16;
			//   if ( !rootTransform )
			//     goto LABEL_17;
			//   if ( UnityEngine::Object::CompareName((Object_1 *)rootTransform, this.fields.m_skeletonName_Ankle_L, 0LL) )
			//   {
			//     v6 = 1;
			//     goto LABEL_12;
			//   }
			//   rootTransform = (Component *)container.rootTransform;
			//   v18 = *(_OWORD *)&container.localRotation.y;
			//   *(_OWORD *)&v37.localOffset.x = *(_OWORD *)&container.localOffset.x;
			//   *(_OWORD *)&v37.localRotation.y = v18;
			//   if ( !rootTransform )
			// LABEL_17:
			//     sub_180B536AC(rootTransform, v10);
			//   v6 = UnityEngine::Object::CompareName((Object_1 *)rootTransform, this.fields.m_skeletonName_Ankle_R, 0LL);
			// LABEL_12:
			//   if ( !v15 )
			//     sub_180B536AC(v17, v10);
			//   UnityEngine::Object::set_hideFlags((Object_1 *)v15, HideFlags__Enum_DontSave, 0LL);
			//   UnityEngine::HGCapsuleBindingComponent::set_enabled((HGCapsuleBindingComponent *)v15, 1, 0LL);
			//   v19 = *(_OWORD *)&container.localRotation.y;
			//   capsuleRadius = container.capsuleRadius;
			//   *(_OWORD *)&v37.localOffset.x = *(_OWORD *)&container.localOffset.x;
			//   *(_OWORD *)&v37.localRotation.y = v19;
			//   UnityEngine::HGCapsuleBindingComponent::set_capsuleRadius((HGCapsuleBindingComponent *)v15, capsuleRadius, 0LL);
			//   v21 = *(_OWORD *)&container.localRotation.y;
			//   capsuleHeight = container.capsuleHeight;
			//   *(_OWORD *)&v37.localOffset.x = *(_OWORD *)&container.localOffset.x;
			//   *(_OWORD *)&v37.localRotation.y = v21;
			//   UnityEngine::HGCapsuleBindingComponent::set_capsuleHeight((HGCapsuleBindingComponent *)v15, capsuleHeight, 0LL);
			//   v23 = (void (__fastcall *)(Object *, __int64 *))qword_18D8F58C0;
			//   v24 = *(_OWORD *)&container.localRotation.y;
			//   v33 = *(_QWORD *)&container.localOffset.x;
			//   v34 = _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&container.localOffset.z));
			//   *(_OWORD *)&v37.localRotation.y = v24;
			//   if ( !qword_18D8F58C0 )
			//   {
			//     v23 = (void (__fastcall *)(Object *, __int64 *))il2cpp_resolve_icall_0(
			//                                                       "UnityEngine.HGCapsuleBindingComponent::set_localOffset_Injected(Un"
			//                                                       "ityEngine.Vector3&)");
			//     if ( !v23 )
			//     {
			//       v28 = sub_1802DBBE8("UnityEngine.HGCapsuleBindingComponent::set_localOffset_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v28, 0LL);
			//     }
			//     qword_18D8F58C0 = (__int64)v23;
			//   }
			//   v23(v15, &v33);
			//   v25 = (void (__fastcall *)(Object *, __int64 *))qword_18D8F58C8;
			//   v26 = *(_OWORD *)&container.localOffset.x;
			//   *(_OWORD *)&v37.localRotation.y = *(_OWORD *)&container.localRotation.y;
			//   v36 = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v37.localRotation.y, 4));
			//   *(_OWORD *)&v37.localOffset.x = v26;
			//   v35 = *(_QWORD *)&v37.localRotation.x;
			//   if ( !qword_18D8F58C8 )
			//   {
			//     v25 = (void (__fastcall *)(Object *, __int64 *))il2cpp_resolve_icall_0(
			//                                                       "UnityEngine.HGCapsuleBindingComponent::set_localRotation_Injected("
			//                                                       "UnityEngine.Vector3&)");
			//     if ( !v25 )
			//     {
			//       v29 = sub_1802DBBE8("UnityEngine.HGCapsuleBindingComponent::set_localRotation_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v29, 0LL);
			//     }
			//     qword_18D8F58C8 = (__int64)v25;
			//   }
			//   v25(v15, &v35);
			//   UnityEngine::HGCapsuleBindingComponent::set_intensityScale(
			//     (HGCapsuleBindingComponent *)v15,
			//     container.intensityScale,
			//     0LL);
			//   UnityEngine::HGCapsuleBindingComponent::set_forceRender((HGCapsuleBindingComponent *)v15, v6, 0LL);
			// }
			// 
		}

		private void RemoveCapsuleBinding(HGCapsuleShadowContainer container)
		{
			// // Void RemoveCapsuleBinding(HGCapsuleShadowContainer)
			// void HG::Rendering::Runtime::HGCapsuleShadowHelper::RemoveCapsuleBinding(
			//         HGCapsuleShadowHelper *this,
			//         HGCapsuleShadowContainer *container,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Component *rootTransform; // rcx
			//   GameObject *gameObject; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm0
			//   HGCapsuleShadowContainer v11; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D91975E )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGCapsuleShadowHelper::RemoveComponent<UnityEngine::HGCapsuleBindingComponent>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D91975E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3491, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)container.rootTransform, 0LL, 0LL) )
			//     {
			//       rootTransform = (Component *)this;
			// LABEL_8:
			//       gameObject = UnityEngine::Component::get_gameObject(rootTransform, 0LL);
			//       HG::Rendering::Runtime::HGCapsuleShadowHelper::RemoveComponent<System::Object>(
			//         gameObject,
			//         MethodInfo::HG::Rendering::Runtime::HGCapsuleShadowHelper::RemoveComponent<UnityEngine::HGCapsuleBindingComponent>);
			//       return;
			//     }
			//     rootTransform = (Component *)container.rootTransform;
			//     if ( container.rootTransform )
			//       goto LABEL_8;
			// LABEL_10:
			//     sub_180B536AC(rootTransform, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3491, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   v9 = *(_OWORD *)&container.localOffset.x;
			//   *(_OWORD *)&v11.rootTransform = *(_OWORD *)&container.rootTransform;
			//   v10 = *(_OWORD *)&container.localRotation.y;
			//   *(_OWORD *)&v11.localOffset.x = v9;
			//   *(_OWORD *)&v11.localRotation.y = v10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1246(Patch, (Object *)this, &v11, 0LL);
			// }
			// 
		}

		private void DisableCapsuleBinding(HGCapsuleShadowContainer container)
		{
			// // Void DisableCapsuleBinding(HGCapsuleShadowContainer)
			// void HG::Rendering::Runtime::HGCapsuleShadowHelper::DisableCapsuleBinding(
			//         HGCapsuleShadowHelper *this,
			//         HGCapsuleShadowContainer *container,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rdx
			//   Component *rootTransform; // rcx
			//   GameObject *gameObject; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   HGCapsuleShadowContainer v12; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8EDB82 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDB82 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3488, 0LL) )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)container.rootTransform, 0LL, 0LL) )
			//     {
			//       rootTransform = (Component *)this;
			//       goto LABEL_8;
			//     }
			//     rootTransform = (Component *)container.rootTransform;
			//     if ( container.rootTransform )
			//     {
			// LABEL_8:
			//       gameObject = UnityEngine::Component::get_gameObject(rootTransform, 0LL);
			//       HG::Rendering::Runtime::HGCapsuleShadowHelper::_DisableCapsuleBinding_g__DisableComponent_40_0(gameObject, 0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(rootTransform, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3488, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   v10 = *(_OWORD *)&container.localOffset.x;
			//   *(_OWORD *)&v12.rootTransform = *(_OWORD *)&container.rootTransform;
			//   v11 = *(_OWORD *)&container.localRotation.y;
			//   *(_OWORD *)&v12.localOffset.x = v10;
			//   *(_OWORD *)&v12.localRotation.y = v11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1246(Patch, (Object *)this, &v12, 0LL);
			// }
			// 
		}

		private void AddCapsuleListBinding()
		{
			// // Void AddCapsuleListBinding()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGCapsuleShadowHelper::AddCapsuleListBinding(
			//         HGCapsuleShadowHelper *this,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v3; // rdx
			//   __int64 v4; // rcx
			//   FileDescriptor *v5; // r8
			//   MessageDescriptor *v6; // r9
			//   List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *m_capsuleShadowContainers; // rbx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // r9
			//   __int64 v11; // rax
			//   __int64 v12; // rdx
			//   int v13; // ecx
			//   __int64 v14; // rdx
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm2
			//   __int64 *v18; // rdx
			//   __int64 v19; // rtt
			//   Il2CppClass *klass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   __int128 v24; // [rsp+20h] [rbp-A8h] BYREF
			//   __int128 v25; // [rsp+30h] [rbp-98h] BYREF
			//   __int128 v26; // [rsp+40h] [rbp-88h]
			//   __int128 v27; // [rsp+50h] [rbp-78h]
			//   OneofDescriptorProto__Class *v28; // [rsp+60h] [rbp-68h]
			//   __int128 *v29; // [rsp+68h] [rbp-60h]
			//   OneofDescriptor v30; // [rsp+70h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D8EDB83 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::GetEnumerator);
			//     byte_18D8EDB83 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3480, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3480, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v23, v22);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( !this.fields.m_interactionOnly )
			//   {
			//     m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//     if ( !m_capsuleShadowContainers )
			//       sub_180B536AC(v4, v3);
			//     memset(&v30.monitor, 0, 56);
			//     v30.klass = (OneofDescriptor__Class *)m_capsuleShadowContainers;
			//     sub_1800054D0(&v30, v3, v5, v6, (String__Array *)v24, *((String **)&v24 + 1), (MethodInfo *)v25);
			//     LODWORD(v30.monitor) = 0;
			//     HIDWORD(v30.monitor) = m_capsuleShadowContainers.fields._version;
			//     memset(&v30.fields, 0, 48);
			//     v24 = *(_OWORD *)&v30.klass;
			//     v25 = 0LL;
			//     v26 = 0LL;
			//     v27 = 0LL;
			//     v28 = 0LL;
			//     v29 = &v24;
			//     try
			//     {
			//       while ( 1 )
			//       {
			//         v11 = v24;
			//         if ( !(_QWORD)v24 )
			//           sub_1802DC2C8(v9, v8);
			//         v12 = HIDWORD(v24);
			//         if ( HIDWORD(v24) != *(_DWORD *)(v24 + 28) )
			//           break;
			//         v13 = DWORD2(v24);
			//         if ( DWORD2(v24) >= *(_DWORD *)(v24 + 24) )
			//           break;
			//         v14 = *(_QWORD *)(v24 + 16);
			//         if ( !v14 )
			//           sub_1802DC2C8(SDWORD2(v24), 0LL);
			//         if ( DWORD2(v24) >= *(_DWORD *)(v14 + 24) )
			//           sub_180070260(
			//             SDWORD2(v24),
			//             v14,
			//             MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext,
			//             v10);
			//         v15 = *(_OWORD *)(v14 + 48LL * SDWORD2(v24) + 32);
			//         v25 = v15;
			//         v16 = *(_OWORD *)(v14 + 48LL * SDWORD2(v24) + 48);
			//         v26 = v16;
			//         v17 = *(_OWORD *)(v14 + 48LL * SDWORD2(v24) + 64);
			//         v27 = v17;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v18 = &qword_18D6870D0[(((unsigned __int64)&v25 >> 12) & 0x1FFFFF) >> 6];
			//           _m_prefetchw(v18);
			//           do
			//             v19 = *v18;
			//           while ( v19 != _InterlockedCompareExchange64(
			//                            v18,
			//                            *v18 | (1LL << (((unsigned __int64)&v25 >> 12) & 0x3F)),
			//                            *v18) );
			//           v17 = v27;
			//           v16 = v26;
			//           v15 = v25;
			//           v13 = DWORD2(v24);
			//         }
			//         DWORD2(v24) = v13 + 1;
			//         *(_OWORD *)&v30.klass = v15;
			//         *(_OWORD *)&v30.fields._._Index_k__BackingField = v16;
			//         *(_OWORD *)&v30.fields._._File_k__BackingField = v17;
			//         HG::Rendering::Runtime::HGCapsuleShadowHelper::AddCapsuleBinding(this, (HGCapsuleShadowContainer *)&v30, 0LL);
			//       }
			//       klass = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext.klass;
			//       if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//       {
			//         sub_18003C700(klass);
			//         v12 = HIDWORD(v24);
			//         v11 = v24;
			//       }
			//       if ( !v11 )
			//         sub_1802DC2C8(klass, v12);
			//       if ( (_DWORD)v12 != *(_DWORD *)(v11 + 28) )
			//         System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			//       DWORD2(v24) = *(_DWORD *)(v11 + 24) + 1;
			//       v25 = 0LL;
			//       v26 = 0LL;
			//       v27 = 0LL;
			//     }
			//     catch ( Il2CppExceptionWrapper *&v30.fields._Proto_k__BackingField )
			//     {
			//       v28 = v30.fields._Proto_k__BackingField.klass;
			//       if ( v28 )
			//         sub_18000F780(v28);
			//     }
			//   }
			// }
			// 
		}

		private void RemoveCapsuleListBinding()
		{
			// // Void RemoveCapsuleListBinding()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGCapsuleShadowHelper::RemoveCapsuleListBinding(
			//         HGCapsuleShadowHelper *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Il2CppException *ex; // [rsp+20h] [rbp-A8h]
			//   List_1_T_Enumerator_HG_Rendering_Runtime_HGCapsuleShadowContainer_ v9; // [rsp+30h] [rbp-98h] BYREF
			//   Il2CppExceptionWrapper *v10; // [rsp+70h] [rbp-58h] BYREF
			//   HGCapsuleShadowContainer current; // [rsp+80h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D91975F )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::GetEnumerator);
			//     byte_18D91975F = 1;
			//   }
			//   sub_1802F01E0(&v9, 0LL, 64LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(3492, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3492, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( !this.fields.m_interactionOnly )
			//   {
			//     if ( !this.fields.m_capsuleShadowContainers )
			//       sub_180B536AC(v4, v3);
			//     v9 = *(List_1_T_Enumerator_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *)sub_18031E490(
			//                                                                                   &current,
			//                                                                                   this.fields.m_capsuleShadowContainers);
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext(
			//                 &v9,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext) )
			//       {
			//         current = v9._current;
			//         HG::Rendering::Runtime::HGCapsuleShadowHelper::RemoveCapsuleBinding(this, &current, 0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v10 )
			//     {
			//       ex = v10.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}

		private void DisableCapsuleListBinding()
		{
			// // Void DisableCapsuleListBinding()
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// void HG::Rendering::Runtime::HGCapsuleShadowHelper::DisableCapsuleListBinding(
			//         HGCapsuleShadowHelper *this,
			//         MethodInfo *method)
			// {
			//   OneofDescriptorProto *v3; // rdx
			//   __int64 v4; // rcx
			//   FileDescriptor *v5; // r8
			//   MessageDescriptor *v6; // r9
			//   List_1_HG_Rendering_Runtime_HGCapsuleShadowContainer_ *m_capsuleShadowContainers; // rbx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   MessageDescriptor *v10; // r9
			//   unsigned __int64 v11; // r8
			//   __int64 v12; // rax
			//   __int64 v13; // rdx
			//   int v14; // ecx
			//   __int64 *v15; // rdx
			//   __int128 v16; // xmm8
			//   __int128 v17; // xmm6
			//   __int128 v18; // xmm7
			//   __int64 v19; // rtt
			//   signed __int64 v20; // rcx
			//   __int64 v21; // rbx
			//   __int64 v22; // rax
			//   unsigned int *v23; // rdx
			//   __int64 v24; // rbx
			//   __int64 v25; // rax
			//   __int64 v26; // rbx
			//   _QWORD *v27; // rcx
			//   __int64 v28; // rax
			//   signed __int64 v29; // rcx
			//   __int64 v30; // rbx
			//   __int64 v31; // rax
			//   unsigned int *v32; // rdx
			//   __int64 v33; // rbx
			//   __int64 v34; // rax
			//   __int64 v35; // rbx
			//   _QWORD *v36; // rcx
			//   __int64 v37; // rax
			//   struct ILFixDynamicMethodWrapper_2__Class *v38; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   signed __int64 v40; // rcx
			//   __int64 v41; // rax
			//   __int64 v42; // rax
			//   __int64 v43; // rax
			//   ILFixDynamicMethodWrapper_2__Array *v44; // rcx
			//   ILFixDynamicMethodWrapper_2 *v45; // rcx
			//   signed __int64 v46; // rcx
			//   __int64 v47; // rax
			//   __int64 v48; // rax
			//   __int64 v49; // rax
			//   signed __int64 v50; // rcx
			//   __int64 v51; // rax
			//   __int64 v52; // rax
			//   __int64 v53; // rax
			//   __int64 (__fastcall *v54)(_QWORD, ILFixDynamicMethodWrapper_2__Array *, unsigned __int64); // rax
			//   __int64 v55; // rdx
			//   signed __int64 v56; // rcx
			//   GameObject *v57; // rbx
			//   unsigned int v58; // r8d
			//   __int64 v59; // rax
			//   __int64 v60; // rax
			//   __int64 v61; // rax
			//   Object *v62; // rbx
			//   void (__fastcall *v63)(Object *, _QWORD); // rax
			//   __int64 (__fastcall *v64)(HGCapsuleShadowHelper *, ILFixDynamicMethodWrapper_2__Array *, unsigned __int64); // rax
			//   __int64 v65; // rdx
			//   signed __int64 v66; // rcx
			//   GameObject *v67; // rbx
			//   unsigned int v68; // r8d
			//   __int64 v69; // rax
			//   __int64 v70; // rax
			//   __int64 v71; // rax
			//   Il2CppClass *klass; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v74; // rdx
			//   __int64 v75; // rcx
			//   __int64 v76; // rax
			//   __int64 v77; // rax
			//   __int64 v78; // rax
			//   __int64 v79; // rax
			//   String__Array *v80; // [rsp+20h] [rbp-158h]
			//   String__Array *v81; // [rsp+20h] [rbp-158h]
			//   String *v82; // [rsp+28h] [rbp-150h]
			//   String *v83; // [rsp+28h] [rbp-150h]
			//   __int128 v84; // [rsp+30h] [rbp-148h] BYREF
			//   __int128 v85; // [rsp+40h] [rbp-138h] BYREF
			//   __int128 v86; // [rsp+50h] [rbp-128h]
			//   __int128 v87; // [rsp+60h] [rbp-118h]
			//   __int64 v88; // [rsp+70h] [rbp-108h]
			//   __int128 *v89; // [rsp+78h] [rbp-100h]
			//   OneofDescriptor v90; // [rsp+80h] [rbp-F8h] BYREF
			//   int v91; // [rsp+D0h] [rbp-A8h] BYREF
			//   HGCapsuleShadowContainer v92; // [rsp+F0h] [rbp-88h] BYREF
			//   Object *component; // [rsp+190h] [rbp+18h] BYREF
			//   Object *v94; // [rsp+198h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8EDB84 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowContainer>::GetEnumerator);
			//     byte_18D8EDB84 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3487, 0LL) )
			//   {
			//     if ( this.fields.m_interactionOnly )
			//       return;
			//     m_capsuleShadowContainers = this.fields.m_capsuleShadowContainers;
			//     if ( !m_capsuleShadowContainers )
			//       sub_180B536AC(v4, v3);
			//     memset(&v90.monitor, 0, 56);
			//     v90.klass = (OneofDescriptor__Class *)m_capsuleShadowContainers;
			//     sub_1800054D0(&v90, v3, v5, v6, v80, v82, (MethodInfo *)v84);
			//     LODWORD(v90.monitor) = 0;
			//     HIDWORD(v90.monitor) = m_capsuleShadowContainers.fields._version;
			//     memset(&v90.fields, 0, 48);
			//     v84 = *(_OWORD *)&v90.klass;
			//     v85 = 0LL;
			//     v86 = 0LL;
			//     v87 = 0LL;
			//     v88 = 0LL;
			//     v89 = &v84;
			//     while ( 1 )
			//     {
			//       while ( 1 )
			//       {
			//         while ( 1 )
			//         {
			//           v11 = (unsigned __int64)MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext;
			//           v12 = v84;
			//           if ( !(_QWORD)v84 )
			//             sub_1802DC2C8(v9, v8);
			//           v13 = HIDWORD(v84);
			//           if ( HIDWORD(v84) != *(_DWORD *)(v84 + 28) || (v14 = DWORD2(v84), DWORD2(v84) >= *(_DWORD *)(v84 + 24)) )
			//           {
			//             klass = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext.klass;
			//             if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//             {
			//               sub_18003C700(klass);
			//               v13 = HIDWORD(v84);
			//               v12 = v84;
			//             }
			//             if ( !v12 )
			//               sub_1802DC2C8(klass, v13);
			//             if ( (_DWORD)v13 != *(_DWORD *)(v12 + 28) )
			//               System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			//             DWORD2(v84) = *(_DWORD *)(v12 + 24) + 1;
			//             v85 = 0LL;
			//             v86 = 0LL;
			//             v87 = 0LL;
			//             return;
			//           }
			//           v15 = *(__int64 **)(v84 + 16);
			//           if ( !v15 )
			//             sub_1802DC2C8(SDWORD2(v84), 0LL);
			//           if ( DWORD2(v84) >= *((_DWORD *)v15 + 6) )
			//             sub_180070260(
			//               SDWORD2(v84),
			//               v15,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGCapsuleShadowContainer>::MoveNext,
			//               v10);
			//           v16 = *(_OWORD *)&v15[6 * SDWORD2(v84) + 4];
			//           v85 = v16;
			//           v17 = *(_OWORD *)&v15[6 * SDWORD2(v84) + 6];
			//           v86 = v17;
			//           v18 = *(_OWORD *)&v15[6 * SDWORD2(v84) + 8];
			//           v87 = v18;
			//           if ( dword_18D8E43F8 )
			//           {
			//             v15 = &qword_18D6870D0[(((unsigned __int64)&v85 >> 12) & 0x1FFFFF) >> 6];
			//             v11 = ((unsigned __int64)&v85 >> 12) & 0x3F;
			//             _m_prefetchw(v15);
			//             do
			//               v19 = *v15;
			//             while ( v19 != _InterlockedCompareExchange64(v15, *v15 | (1LL << v11), *v15) );
			//             v18 = v87;
			//             v17 = v86;
			//             v16 = v85;
			//             v14 = DWORD2(v84);
			//           }
			//           DWORD2(v84) = v14 + 1;
			//           if ( !byte_18D8EDB82 )
			//           {
			//             v20 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//             if ( (v20 & 1) != 0 )
			//             {
			//               v21 = ((unsigned int)v20 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v20 >> 29 )
			//               {
			//                 case 1u:
			//                   v22 = sub_18003C670((unsigned int)v21);
			//                   goto LABEL_35;
			//                 case 2u:
			//                   v22 = sub_18003C380((unsigned int)v21);
			//                   goto LABEL_35;
			//                 case 3u:
			//                 case 6u:
			//                   v22 = sub_1802DFAE0(v20);
			//                   goto LABEL_35;
			//                 case 4u:
			//                   v22 = sub_1802DF920((unsigned int)v21);
			//                   goto LABEL_35;
			//                 case 5u:
			//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v21) )
			//                   {
			//                     v22 = *(_QWORD *)(qword_18D8F6F98 + 8 * v21);
			//                   }
			//                   else
			//                   {
			//                     v23 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v21);
			//                     v10 = (MessageDescriptor *)il2cpp_string_new_len(
			//                                                  qword_18D8E5198 + (int)v23[1] + *(int *)(qword_18D8E51A0 + 16),
			//                                                  *v23);
			//                     v22 = _InterlockedCompareExchange64(
			//                             (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v21),
			//                             (signed __int64)v10,
			//                             0LL);
			//                     if ( !v22 )
			//                     {
			//                       sub_1800054D0(
			//                         (OneofDescriptor *)(qword_18D8F6F98 + 8 * v21),
			//                         (OneofDescriptorProto *)v15,
			//                         (FileDescriptor *)v11,
			//                         v10,
			//                         v81,
			//                         v83,
			//                         (MethodInfo *)v84);
			//                       v22 = (__int64)v10;
			//                     }
			//                   }
			//                   goto LABEL_35;
			//                 case 7u:
			//                   v24 = sub_1802DF920((unsigned int)v21);
			//                   v25 = *(_QWORD *)(v24 + 16);
			//                   v26 = (v24 - *(_QWORD *)(v25 + 128)) >> 5;
			//                   if ( *(_BYTE *)(v25 + 42) == 21 )
			//                   {
			//                     v27 = **(_QWORD ***)(v25 + 96);
			//                     if ( v27 )
			//                       v25 = sub_180039510(*v27);
			//                     else
			//                       v25 = 0LL;
			//                   }
			//                   LODWORD(v90.fields._Proto_k__BackingField) = v26 + *(_DWORD *)(*(_QWORD *)(v25 + 104) + 32LL);
			//                   v28 = sub_1801B8ECC(
			//                           (unsigned int)&v90.fields._Proto_k__BackingField,
			//                           (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                           *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                           12,
			//                           (__int64)sub_1802C7760);
			//                   if ( !v28 || (v15 = (__int64 *)*(unsigned int *)(v28 + 8), (_DWORD)v15 == -1) )
			//                     v22 = 0LL;
			//                   else
			//                     v22 = (__int64)v15 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72);
			// LABEL_35:
			//                   if ( v22 )
			//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, v22);
			//                   break;
			//                 default:
			//                   break;
			//               }
			//             }
			//             byte_18D8EDB82 = 1;
			//           }
			//           if ( !byte_18D8EDC37 )
			//           {
			//             v29 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
			//             if ( (v29 & 1) != 0 )
			//             {
			//               v30 = ((unsigned int)v29 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v29 >> 29 )
			//               {
			//                 case 1u:
			//                   v31 = sub_18003C670((unsigned int)v30);
			//                   goto LABEL_57;
			//                 case 2u:
			//                   v31 = sub_18003C380((unsigned int)v30);
			//                   goto LABEL_57;
			//                 case 3u:
			//                 case 6u:
			//                   v31 = sub_1802DFAE0(v29);
			//                   goto LABEL_57;
			//                 case 4u:
			//                   v31 = sub_1802DF920((unsigned int)v30);
			//                   goto LABEL_57;
			//                 case 5u:
			//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v30) )
			//                   {
			//                     v31 = *(_QWORD *)(qword_18D8F6F98 + 8 * v30);
			//                   }
			//                   else
			//                   {
			//                     v32 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v30);
			//                     v10 = (MessageDescriptor *)il2cpp_string_new_len(
			//                                                  qword_18D8E5198 + (int)v32[1] + *(int *)(qword_18D8E51A0 + 16),
			//                                                  *v32);
			//                     v31 = _InterlockedCompareExchange64(
			//                             (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v30),
			//                             (signed __int64)v10,
			//                             0LL);
			//                     if ( !v31 )
			//                     {
			//                       sub_1800054D0(
			//                         (OneofDescriptor *)(qword_18D8F6F98 + 8 * v30),
			//                         (OneofDescriptorProto *)v15,
			//                         (FileDescriptor *)v11,
			//                         v10,
			//                         v81,
			//                         v83,
			//                         (MethodInfo *)v84);
			//                       v31 = (__int64)v10;
			//                     }
			//                   }
			//                   goto LABEL_57;
			//                 case 7u:
			//                   v33 = sub_1802DF920((unsigned int)v30);
			//                   v34 = *(_QWORD *)(v33 + 16);
			//                   v35 = (v33 - *(_QWORD *)(v34 + 128)) >> 5;
			//                   if ( *(_BYTE *)(v34 + 42) == 21 )
			//                   {
			//                     v36 = **(_QWORD ***)(v34 + 96);
			//                     if ( v36 )
			//                       v34 = sub_180039510(*v36);
			//                     else
			//                       v34 = 0LL;
			//                   }
			//                   v91 = v35 + *(_DWORD *)(*(_QWORD *)(v34 + 104) + 32LL);
			//                   v37 = sub_1801B8ECC(
			//                           (unsigned int)&v91,
			//                           (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                           *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                           12,
			//                           (__int64)sub_1802C7760);
			//                   if ( !v37 || (v15 = (__int64 *)*(unsigned int *)(v37 + 8), (_DWORD)v15 == -1) )
			//                     v31 = 0LL;
			//                   else
			//                     v31 = (__int64)v15 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72);
			// LABEL_57:
			//                   if ( v31 )
			//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, v31);
			//                   break;
			//                 default:
			//                   break;
			//               }
			//             }
			//             byte_18D8EDC37 = 1;
			//           }
			//           v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v15);
			//             v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           wrapperArray = v38.static_fields.wrapperArray;
			//           if ( !wrapperArray )
			//             sub_1802DC2C8(v38, 0LL);
			//           if ( wrapperArray.max_length.size <= 3488 )
			//             break;
			//           if ( !v38._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(v38, wrapperArray);
			//             v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           wrapperArray = v38.static_fields.wrapperArray;
			//           if ( !wrapperArray )
			//             sub_1802DC2C8(v38, 0LL);
			//           if ( wrapperArray.max_length.size <= 0xDA0u )
			//             sub_180070260(v38, wrapperArray, v11, v10);
			//           if ( !wrapperArray[97].klass )
			//             break;
			//           if ( !byte_18D919D50 )
			//           {
			//             v40 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
			//             if ( (v40 & 1) != 0 )
			//             {
			//               v11 = ((unsigned int)v40 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v40 >> 29 )
			//               {
			//                 case 1u:
			//                   v41 = sub_18003C670((unsigned int)v11);
			//                   goto LABEL_80;
			//                 case 2u:
			//                   v41 = sub_18003C380((unsigned int)v11);
			//                   goto LABEL_80;
			//                 case 3u:
			//                 case 6u:
			//                   v41 = sub_1802DFAE0(v40);
			//                   goto LABEL_80;
			//                 case 4u:
			//                   v41 = sub_1802DF920((unsigned int)v11);
			//                   goto LABEL_80;
			//                 case 5u:
			//                   v41 = sub_1802DFBB0((unsigned int)v11);
			//                   goto LABEL_80;
			//                 case 7u:
			//                   v42 = sub_1802DF920((unsigned int)v11);
			//                   v43 = sub_1802DF850(v42);
			//                   if ( v43 )
			//                     v41 = sub_1802DF970(*(unsigned int *)(v43 + 8));
			//                   else
			//                     v41 = 0LL;
			// LABEL_80:
			//                   if ( v41 )
			//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, v41);
			//                   break;
			//                 default:
			//                   break;
			//               }
			//             }
			//             byte_18D919D50 = 1;
			//             v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           if ( !v38._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(v38, wrapperArray);
			//             v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           v44 = v38.static_fields.wrapperArray;
			//           if ( !v44 )
			//             sub_1802DC2C8(0LL, wrapperArray);
			//           if ( v44.max_length.size <= 0xDA0u )
			//             sub_180070260(v44, wrapperArray, v11, v10);
			//           v45 = (ILFixDynamicMethodWrapper_2 *)v44[97].klass;
			//           if ( !v45 )
			//             sub_1802DC2C8(0LL, wrapperArray);
			//           *(_OWORD *)&v92.rootTransform = v16;
			//           *(_OWORD *)&v92.localOffset.x = v17;
			//           *(_OWORD *)&v92.localRotation.y = v18;
			//           IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1246(v45, (Object *)this, &v92, 0LL);
			//         }
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//         if ( !byte_18D8F4EFA )
			//         {
			//           v46 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//           if ( (v46 & 1) != 0 )
			//           {
			//             v11 = ((unsigned int)v46 >> 1) & 0xFFFFFFF;
			//             switch ( (unsigned int)v46 >> 29 )
			//             {
			//               case 1u:
			//                 v47 = sub_18003C670((unsigned int)v11);
			//                 goto LABEL_102;
			//               case 2u:
			//                 v47 = sub_18003C380((unsigned int)v11);
			//                 goto LABEL_102;
			//               case 3u:
			//               case 6u:
			//                 v47 = sub_1802DFAE0(v46);
			//                 goto LABEL_102;
			//               case 4u:
			//                 v47 = sub_1802DF920((unsigned int)v11);
			//                 goto LABEL_102;
			//               case 5u:
			//                 v47 = sub_1802DFBB0((unsigned int)v11);
			//                 goto LABEL_102;
			//               case 7u:
			//                 v48 = sub_1802DF920((unsigned int)v11);
			//                 v49 = sub_1802DF850(v48);
			//                 if ( v49 )
			//                   v47 = sub_1802DF970(*(unsigned int *)(v49 + 8));
			//                 else
			//                   v47 = 0LL;
			// LABEL_102:
			//                 if ( v47 )
			//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, v47);
			//                 break;
			//               default:
			//                 break;
			//             }
			//           }
			//           byte_18D8F4EFA = 1;
			//         }
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//         if ( !byte_18D8F4EAF )
			//         {
			//           v50 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//           if ( (v50 & 1) != 0 )
			//           {
			//             v11 = ((unsigned int)v50 >> 1) & 0xFFFFFFF;
			//             switch ( (unsigned int)v50 >> 29 )
			//             {
			//               case 1u:
			//                 v51 = sub_18003C670((unsigned int)v11);
			//                 goto LABEL_118;
			//               case 2u:
			//                 v51 = sub_18003C380((unsigned int)v11);
			//                 goto LABEL_118;
			//               case 3u:
			//               case 6u:
			//                 v51 = sub_1802DFAE0(v50);
			//                 goto LABEL_118;
			//               case 4u:
			//                 v51 = sub_1802DF920((unsigned int)v11);
			//                 goto LABEL_118;
			//               case 5u:
			//                 v51 = sub_1802DFBB0((unsigned int)v11);
			//                 goto LABEL_118;
			//               case 7u:
			//                 v52 = sub_1802DF920((unsigned int)v11);
			//                 v53 = sub_1802DF850(v52);
			//                 if ( v53 )
			//                   v51 = sub_1802DF970(*(unsigned int *)(v53 + 8));
			//                 else
			//                   v51 = 0LL;
			// LABEL_118:
			//                 if ( v51 )
			//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, v51);
			//                 break;
			//               default:
			//                 break;
			//             }
			//           }
			//           byte_18D8F4EAF = 1;
			//         }
			//         if ( !(_QWORD)v16 )
			//           break;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//         if ( !*(_QWORD *)(v16 + 16) )
			//           break;
			//         v54 = (__int64 (__fastcall *)(_QWORD, ILFixDynamicMethodWrapper_2__Array *, unsigned __int64))qword_18D8F4D48;
			//         if ( !qword_18D8F4D48 )
			//         {
			//           v54 = (__int64 (__fastcall *)(_QWORD, ILFixDynamicMethodWrapper_2__Array *, unsigned __int64))il2cpp_resolve_icall_0("UnityEngine.Component::get_gameObject()");
			//           if ( !v54 )
			//           {
			//             v76 = sub_1802DBBE8("UnityEngine.Component::get_gameObject()");
			//             sub_18000F750(v76, 0LL);
			//           }
			//           qword_18D8F4D48 = (__int64)v54;
			//         }
			//         v57 = (GameObject *)v54(v16, wrapperArray, v11);
			//         if ( !byte_18D8EDB86 )
			//         {
			//           v56 = _InterlockedExchangeAdd64(
			//                   (volatile signed __int64 *)&MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::HGCapsuleBindingComponent>,
			//                   0LL);
			//           if ( (v56 & 1) != 0 )
			//           {
			//             v58 = ((unsigned int)v56 >> 1) & 0xFFFFFFF;
			//             switch ( (unsigned int)v56 >> 29 )
			//             {
			//               case 1u:
			//                 v59 = sub_18003C670(v58);
			//                 goto LABEL_139;
			//               case 2u:
			//                 v59 = sub_18003C380(v58);
			//                 goto LABEL_139;
			//               case 3u:
			//               case 6u:
			//                 v59 = sub_1802DFAE0(v56);
			//                 goto LABEL_139;
			//               case 4u:
			//                 v59 = sub_1802DF920(v58);
			//                 goto LABEL_139;
			//               case 5u:
			//                 v59 = sub_1802DFBB0(v58);
			//                 goto LABEL_139;
			//               case 7u:
			//                 v60 = sub_1802DF920(v58);
			//                 v61 = sub_1802DF850(v60);
			//                 if ( v61 )
			//                   v59 = sub_1802DF970(*(unsigned int *)(v61 + 8));
			//                 else
			//                   v59 = 0LL;
			// LABEL_139:
			//                 if ( v59 )
			//                   _InterlockedExchange64(
			//                     (volatile __int64 *)&MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::HGCapsuleBindingComponent>,
			//                     v59);
			//                 break;
			//               default:
			//                 break;
			//             }
			//           }
			//           byte_18D8EDB86 = 1;
			//         }
			//         component = 0LL;
			//         if ( !v57 )
			//           sub_1802DC2C8(v56, v55);
			//         if ( UnityEngine::GameObject::TryGetComponent<System::Object>(
			//                v57,
			//                &component,
			//                MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::HGCapsuleBindingComponent>) )
			//         {
			//           v62 = component;
			//           if ( !component )
			//             sub_1802DC2C8(v9, v8);
			//           v63 = (void (__fastcall *)(Object *, _QWORD))qword_18D8F5898;
			//           if ( !qword_18D8F5898 )
			//           {
			//             v63 = (void (__fastcall *)(Object *, _QWORD))il2cpp_resolve_icall_0(
			//                                                            "UnityEngine.HGCapsuleBindingComponent::set_enabled(System.Boolean)");
			//             if ( !v63 )
			//             {
			//               v77 = sub_1802DBBE8("UnityEngine.HGCapsuleBindingComponent::set_enabled(System.Boolean)");
			//               sub_18000F750(v77, 0LL);
			//             }
			// LABEL_147:
			//             qword_18D8F5898 = (__int64)v63;
			//             goto LABEL_148;
			//           }
			//           goto LABEL_148;
			//         }
			//       }
			//       v64 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *, ILFixDynamicMethodWrapper_2__Array *, unsigned __int64))qword_18D8F4D48;
			//       if ( !qword_18D8F4D48 )
			//       {
			//         v64 = (__int64 (__fastcall *)(HGCapsuleShadowHelper *, ILFixDynamicMethodWrapper_2__Array *, unsigned __int64))il2cpp_resolve_icall_0("UnityEngine.Component::get_gameObject()");
			//         if ( !v64 )
			//         {
			//           v78 = sub_1802DBBE8("UnityEngine.Component::get_gameObject()");
			//           sub_18000F750(v78, 0LL);
			//         }
			//         qword_18D8F4D48 = (__int64)v64;
			//       }
			//       v67 = (GameObject *)v64(this, wrapperArray, v11);
			//       if ( !byte_18D8EDB86 )
			//       {
			//         v66 = _InterlockedExchangeAdd64(
			//                 (volatile signed __int64 *)&MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::HGCapsuleBindingComponent>,
			//                 0LL);
			//         if ( (v66 & 1) != 0 )
			//         {
			//           v68 = ((unsigned int)v66 >> 1) & 0xFFFFFFF;
			//           switch ( (unsigned int)v66 >> 29 )
			//           {
			//             case 1u:
			//               v69 = sub_18003C670(v68);
			//               goto LABEL_163;
			//             case 2u:
			//               v69 = sub_18003C380(v68);
			//               goto LABEL_163;
			//             case 3u:
			//             case 6u:
			//               v69 = sub_1802DFAE0(v66);
			//               goto LABEL_163;
			//             case 4u:
			//               v69 = sub_1802DF920(v68);
			//               goto LABEL_163;
			//             case 5u:
			//               v69 = sub_1802DFBB0(v68);
			//               goto LABEL_163;
			//             case 7u:
			//               v70 = sub_1802DF920(v68);
			//               v71 = sub_1802DF850(v70);
			//               if ( v71 )
			//                 v69 = sub_1802DF970(*(unsigned int *)(v71 + 8));
			//               else
			//                 v69 = 0LL;
			// LABEL_163:
			//               if ( v69 )
			//                 _InterlockedExchange64(
			//                   (volatile __int64 *)&MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::HGCapsuleBindingComponent>,
			//                   v69);
			//               break;
			//             default:
			//               break;
			//           }
			//         }
			//         byte_18D8EDB86 = 1;
			//       }
			//       v94 = 0LL;
			//       if ( !v67 )
			//         sub_1802DC2C8(v66, v65);
			//       if ( UnityEngine::GameObject::TryGetComponent<System::Object>(
			//              v67,
			//              &v94,
			//              MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::HGCapsuleBindingComponent>) )
			//       {
			//         v62 = v94;
			//         if ( !v94 )
			//           sub_1802DC2C8(v9, v8);
			//         v63 = (void (__fastcall *)(Object *, _QWORD))qword_18D8F5898;
			//         if ( !qword_18D8F5898 )
			//         {
			//           v63 = (void (__fastcall *)(Object *, _QWORD))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.HGCapsuleBindingComponent::set_enabled(System.Boolean)");
			//           if ( !v63 )
			//           {
			//             v79 = sub_1802DBBE8("UnityEngine.HGCapsuleBindingComponent::set_enabled(System.Boolean)");
			//             sub_18000F750(v79, 0LL);
			//           }
			//           goto LABEL_147;
			//         }
			// LABEL_148:
			//         v63(v62, 0LL);
			//       }
			//     }
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3487, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v75, v74);
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			return null;
		}

		public static void RemoveComponent<T>(GameObject go) where T : Component
		{
		}

		[CompilerGenerated]
		internal static Vector3 <GenerateCapsuleShadowContainer>g__GetAnyPerpendicular|32_0(Vector3 v)
		{
			// // Vector3 <GenerateCapsuleShadowContainer>g__GetAnyPerpendicular|32_0(Vector3)
			// Vector3 *HG::Rendering::Runtime::HGCapsuleShadowHelper::_GenerateCapsuleShadowContainer_g__GetAnyPerpendicular_32_0(
			//         Vector3 *__return_ptr retstr,
			//         Vector3 *v,
			//         MethodInfo *method)
			// {
			//   __m128 v4; // xmm0
			//   __m128 x_low; // xmm1
			//   float y; // xmm2_4
			//   __int64 v7; // rax
			//   __int64 v8; // xmm0_8
			//   unsigned __int64 v10; // [rsp+20h] [rbp-28h] BYREF
			//   float v11; // [rsp+28h] [rbp-20h]
			//   _BYTE v12[24]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( fabs(v.x) > fabs(v.z) )
			//   {
			//     y = 0.0;
			//     v4 = _mm_xor_ps((__m128)LODWORD(v.y), (__m128)xmmword_18A3571B0);
			//     x_low = (__m128)LODWORD(v.x);
			//   }
			//   else
			//   {
			//     v4 = 0LL;
			//     x_low = _mm_xor_ps((__m128)LODWORD(v.z), (__m128)xmmword_18A3571B0);
			//     y = v.y;
			//   }
			//   v10 = _mm_unpacklo_ps(v4, x_low).m128_u64[0];
			//   v11 = y;
			//   v7 = sub_182413270(v12, &v10);
			//   v8 = *(_QWORD *)v7;
			//   LODWORD(v7) = *(_DWORD *)(v7 + 8);
			//   *(_QWORD *)&retstr.x = v8;
			//   LODWORD(retstr.z) = v7;
			//   return retstr;
			// }
			// 
			return null;
		}

		[CompilerGenerated]
		internal static void <DisableCapsuleBinding>g__DisableComponent|40_0(GameObject go)
		{
			// // Void <DisableCapsuleBinding>g__DisableComponent|40_0(GameObject)
			// void HG::Rendering::Runtime::HGCapsuleShadowHelper::_DisableCapsuleBinding_g__DisableComponent_40_0(
			//         GameObject *go,
			//         MethodInfo *method)
			// {
			//   GameObject *v2; // rbx
			//   Object *component; // [rsp+30h] [rbp+8h] BYREF
			// 
			//   v2 = go;
			//   if ( !byte_18D8EDB86 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::HGCapsuleBindingComponent>);
			//     byte_18D8EDB86 = 1;
			//   }
			//   component = 0LL;
			//   if ( !v2 )
			//     goto LABEL_8;
			//   if ( !UnityEngine::GameObject::TryGetComponent<System::Object>(
			//           v2,
			//           &component,
			//           MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::HGCapsuleBindingComponent>) )
			//     return;
			//   go = (GameObject *)component;
			//   if ( !component )
			// LABEL_8:
			//     sub_180B536AC(go, method);
			//   UnityEngine::HGCapsuleBindingComponent::set_enabled((HGCapsuleBindingComponent *)component, 0, 0LL);
			// }
			// 
		}

		public List<HGCapsuleShadowContainer> m_capsuleShadowContainers;

		[Range(0f, 5f)]
		public float m_intensity;

		[HideInInspector]
		public int m_editCapsuleIndex;

		public float m_ditherAlpha;

		[Min(0.05f)]
		public float m_feetSize;

		[Range(-0.1f, 0.1f)]
		public float m_feetBaseTransformOffset;

		[Range(-0.1f, 0.1f)]
		public float m_feetTargetTransformOffset;

		public bool m_interactionOnly;

		public bool m_enableCCD;

		public float m_radiusScale;

		public float m_heightScale;

		public Vector3 m_centerOffset;

		private List<Matrix4x4> m_cachedCapsuleTransforms;

		public string m_skeletonName_Hip_R;

		public string m_skeletonName_Hip_L;

		public string m_skeletonName_Knee_R;

		public string m_skeletonName_Knee_L;

		public string m_skeletonName_Ankle_R;

		public string m_skeletonName_Ankle_L;

		public string m_skeletonName_ToesEnd_R;

		public string m_skeletonName_ToesEnd_L;

		public string m_skeletonName_Shoulder_R;

		public string m_skeletonName_Shoulder_L;

		public string m_skeletonName_Wrist_R;

		public string m_skeletonName_Wrist_L;

		public string m_skeletonName_Trunk;

		public string m_skeletonName_Head;
	}
}
