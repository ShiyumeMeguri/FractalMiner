using System;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public static class HGEnvironmentUtils
	{
		[IDTag(1)]
		public static float MinComponent(this Vector2 v)
		{
			// // Single MinComponent(Vector2)
			// float HG::Rendering::Runtime::HGEnvironmentUtils::MinComponent(Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1219, 0LL) )
			//     return fminf(v.x, v.y);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1219, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_460(Patch, v, 0LL);
			// }
			// 
			return 0f;
		}

		[IDTag(0)]
		public static float MaxComponent(this Vector2 v)
		{
			// // Single MaxComponent(Vector2)
			// float HG::Rendering::Runtime::HGEnvironmentUtils::MaxComponent(Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1220, 0LL) )
			//     return fmaxf(v.x, v.y);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1220, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_460(Patch, v, 0LL);
			// }
			// 
			return 0f;
		}

		[IDTag(0)]
		public static float MinComponent(this Vector3 v)
		{
			// // Single MinComponent(Vector3)
			// float HG::Rendering::Runtime::HGEnvironmentUtils::MinComponent(Vector3 *v, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // xmm0_8
			//   Vector3 v8; // [rsp+20h] [rbp-18h] BYREF
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 597 )
			//     return fminf(v.x, fminf(v.y, v.z));
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_8;
			//   if ( LODWORD(v3._0.namespaze) <= 0x255 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !*(_QWORD *)&v3[12]._1.interfaces_count )
			//     return fminf(v.x, fminf(v.y, v.z));
			//   Patch = IFix::WrappersManagerImpl::GetPatch(597, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v3, wrapperArray);
			//   v7 = *(_QWORD *)&v.x;
			//   v8.z = v.z;
			//   *(_QWORD *)&v8.x = v7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_228(Patch, &v8, 0LL);
			// }
			// 
			return 0f;
		}

		[IDTag(1)]
		public static float MaxComponent(this Vector3 v)
		{
			// // Single MaxComponent(Vector3)
			// float HG::Rendering::Runtime::HGEnvironmentUtils::MaxComponent(Vector3 *v, MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1221, 0LL) )
			//     return fmaxf(v.x, fmaxf(v.y, v.z));
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1221, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(0LL, v4);
			//   z = v.z;
			//   *(_QWORD *)&v7.x = *(_QWORD *)&v.x;
			//   v7.z = z;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_228(Patch, &v7, 0LL);
			// }
			// 
			return 0f;
		}

		[IDTag(2)]
		public static float MinComponent(this Vector4 v)
		{
			// // Single MinComponent(Vector4)
			// float HG::Rendering::Runtime::HGEnvironmentUtils::MinComponent(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1222, 0LL) )
			//     return fminf(v.x, fminf(v.y, fminf(v.z, v.w)));
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1222, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_461(Patch, &v7, 0LL);
			// }
			// 
			return 0f;
		}

		[IDTag(2)]
		public static float MaxComponent(this Vector4 v)
		{
			// // Single MaxComponent(Vector4)
			// float HG::Rendering::Runtime::HGEnvironmentUtils::MaxComponent(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1223, 0LL) )
			//     return fmaxf(v.x, fmaxf(v.y, fmaxf(v.z, v.w)));
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1223, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_461(Patch, &v7, 0LL);
			// }
			// 
			return 0f;
		}

		public static Vector3 Transform3x3(Vector3 val, Vector3 up, Vector3 forward, Vector3 right)
		{
			// // Vector3 Transform3x3(Vector3, Vector3, Vector3, Vector3)
			// Vector3 *HG::Rendering::Runtime::HGEnvironmentUtils::Transform3x3(
			//         Vector3 *__return_ptr retstr,
			//         Vector3 *val,
			//         Vector3 *up,
			//         Vector3 *forward,
			//         Vector3 *right,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v10; // r8
			//   float v11; // eax
			//   __int64 v12; // xmm0_8
			//   float v13; // eax
			//   __int64 v14; // xmm1_8
			//   __int64 v15; // xmm3_8
			//   float v16; // eax
			//   MethodInfo *v17; // r8
			//   __int64 v18; // xmm1_8
			//   __int64 v19; // xmm3_8
			//   float v20; // eax
			//   MethodInfo *v21; // r8
			//   float v22; // xmm5_4
			//   float v23; // xmm4_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v25; // rcx
			//   __int64 v26; // xmm0_8
			//   float z; // eax
			//   __int64 v28; // xmm0_8
			//   Vector3 *v29; // rax
			//   __int64 v30; // xmm0_8
			//   Vector3 v32; // [rsp+48h] [rbp-9h] BYREF
			//   Vector3 v33; // [rsp+58h] [rbp+7h] BYREF
			//   Vector3 v34; // [rsp+68h] [rbp+17h] BYREF
			//   Vector3 v35; // [rsp+78h] [rbp+27h] BYREF
			//   Vector3 v36; // [rsp+88h] [rbp+37h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1224, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1224, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v25, 0LL);
			//     v26 = *(_QWORD *)&right.x;
			//     v33.z = right.z;
			//     v32.z = forward.z;
			//     z = up.z;
			//     *(_QWORD *)&v33.x = v26;
			//     v28 = *(_QWORD *)&forward.x;
			//     v34.z = z;
			//     v35.z = val.z;
			//     *(_QWORD *)&v32.x = v28;
			//     *(_QWORD *)&v34.x = *(_QWORD *)&up.x;
			//     *(_QWORD *)&v35.x = *(_QWORD *)&val.x;
			//     v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_462(&v36, Patch, &v35, &v34, &v32, &v33, 0LL);
			//     v30 = *(_QWORD *)&v29.x;
			//     *(float *)&v29 = v29.z;
			//     *(_QWORD *)&retstr.x = v30;
			//     LODWORD(retstr.z) = (_DWORD)v29;
			//   }
			//   else
			//   {
			//     v11 = right.z;
			//     *(_QWORD *)&v32.x = *(_QWORD *)&right.x;
			//     v12 = *(_QWORD *)&val.x;
			//     v32.z = v11;
			//     v13 = val.z;
			//     *(_QWORD *)&v33.x = v12;
			//     v33.z = v13;
			//     UnityEngine::Vector3::Dot(&v33, &v32, v10);
			//     v14 = *(_QWORD *)&val.x;
			//     v15 = *(_QWORD *)&up.x;
			//     v33.z = up.z;
			//     v16 = val.z;
			//     *(_QWORD *)&v32.x = v14;
			//     v32.z = v16;
			//     *(_QWORD *)&v33.x = v15;
			//     UnityEngine::Vector3::Dot(&v32, &v33, v17);
			//     v18 = *(_QWORD *)&val.x;
			//     v19 = *(_QWORD *)&forward.x;
			//     v33.z = forward.z;
			//     v20 = val.z;
			//     *(_QWORD *)&v32.x = v18;
			//     v32.z = v20;
			//     *(_QWORD *)&v33.x = v19;
			//     retstr.z = UnityEngine::Vector3::Dot(&v32, &v33, v21);
			//     retstr.x = v22;
			//     retstr.y = v23;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static float LerpExponential(float a, float b, float t, float e)
		{
			// // Single LerpExponential(Single, Single, Single, Single)
			// float HG::Rendering::Runtime::HGEnvironmentUtils::LerpExponential(
			//         float a,
			//         float b,
			//         float t,
			//         float e,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   int v6; // ecx
			//   Beyond::JobMathf *v7; // rcx
			//   double v8; // xmm0_8
			//   float v9; // xmm6_4
			//   double v10; // xmm0_8
			//   double v11; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1225, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1225, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     *(float *)&v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_405(
			//                        (ILFixDynamicMethodWrapper_3 *)Patch,
			//                        a,
			//                        b,
			//                        t,
			//                        e,
			//                        0LL);
			//   }
			//   else
			//   {
			//     if ( b <= a )
			//     {
			//       v10 = sub_1802EB1B0(v6, v5);
			//       v9 = 1.0 - *(float *)&v10;
			//     }
			//     else
			//     {
			//       v8 = sub_1802EB1B0(v6, v5);
			//       v9 = *(float *)&v8;
			//     }
			//     v11 = Beyond::JobMathf::ClampedLerp(v7, b, v9);
			//   }
			//   return *(float *)&v11;
			// }
			// 
			return 0f;
		}

		public static Color GetColorFromTemperature(float t)
		{
			// // Color GetColorFromTemperature(Single)
			// Color *HG::Rendering::Runtime::HGEnvironmentUtils::GetColorFromTemperature(
			//         Color *__return_ptr retstr,
			//         float t,
			//         MethodInfo *method)
			// {
			//   float v4; // xmm8_4
			//   MethodInfo *v5; // r8
			//   int v6; // xmm0_4
			//   float v7; // xmm7_4
			//   float v8; // xmm4_4
			//   float v9; // xmm7_4
			//   float v10; // xmm5_4
			//   float v11; // xmm4_4
			//   float v12; // xmm0_4
			//   float v13; // xmm2_4
			//   float v14; // xmm1_4
			//   float v15; // xmm4_4
			//   float v16; // xmm3_4
			//   float v17; // xmm2_4
			//   float v18; // xmm0_4
			//   Color *gamma; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   Color v23; // xmm0
			//   Color *result; // rax
			//   Color v25; // [rsp+20h] [rbp-58h] BYREF
			//   Color v26; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   v4 = t;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1226, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1226, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v22, v21);
			//     gamma = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_464(&v26, Patch, t, 0LL);
			//   }
			//   else
			//   {
			//     v6 = 1148846080;
			//     if ( t < 1000.0 || (v6 = 1181376512, t > 15000.0) )
			//       v4 = *(float *)&v6;
			//     v7 = (float)((float)((float)(v4 * 0.00015411826) + 0.86011773) + (float)((float)(v4 * v4) * 0.00000012864122))
			//        / (float)((float)((float)(v4 * 0.00084242021) + 1.0) + (float)((float)(v4 * v4) * 0.00000070814514));
			//     v8 = v7 * 3.0;
			//     v9 = v7 + v7;
			//     v10 = (float)((float)((float)(v4 * 0.000042280626) + 0.31739873) + (float)((float)(v4 * v4) * 0.000000042048168))
			//         / (float)((float)(1.0 - (float)(v4 * 0.000028974182)) + (float)((float)(v4 * v4) * 0.00000016145606));
			//     v11 = v8 / (float)((float)(v9 - (float)(v10 * 8.0)) + 4.0);
			//     v12 = (float)(v10 + v10) / (float)((float)(v9 - (float)(v10 * 8.0)) + 4.0);
			//     v13 = (float)(1.0 / v12) * v11;
			//     v14 = (float)((float)(1.0 - v11) - v12) * (float)(1.0 / v12);
			//     v15 = (float)((float)(v13 * -0.969266) + 1.8760108) + (float)(v14 * 0.041556001);
			//     v16 = (float)((float)(v13 * 3.2404542) - 1.5371385) + (float)(v14 * -0.4985314);
			//     v17 = (float)((float)(v13 * 0.055643398) - 0.20402589) + (float)(v14 * 1.0572252);
			//     if ( v16 <= v15 )
			//       v18 = v15;
			//     else
			//       v18 = v16;
			//     if ( v18 <= v17 )
			//       v18 = v17;
			//     v25.a = 1.0;
			//     v25.r = v16 / v18;
			//     v25.g = v15 / v18;
			//     v25.b = v17 / v18;
			//     gamma = UnityEngine::Color::get_gamma(&v26, &v25, v5);
			//   }
			//   v23 = *gamma;
			//   result = retstr;
			//   *retstr = v23;
			//   return result;
			// }
			// 
			return null;
		}

		public static SHCoefficientsL1 GetCoefficientsL1(this SphericalHarmonicsL2 sh)
		{
			// // SHCoefficientsL1 GetCoefficientsL1(SphericalHarmonicsL2)
			// SHCoefficientsL1 *HG::Rendering::Runtime::HGEnvironmentUtils::GetCoefficientsL1(
			//         SHCoefficientsL1 *__return_ptr retstr,
			//         SphericalHarmonicsL2 *sh,
			//         MethodInfo *method)
			// {
			//   __m128 v3; // xmm0
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *wrapperArray; // rdx
			//   __m128 v8; // xmm13
			//   float Item; // xmm12_4
			//   float v10; // xmm11_4
			//   float v11; // xmm9_4
			//   __m128 v12; // xmm10
			//   __m128 v13; // xmm10
			//   __m128 v14; // xmm10
			//   __m128 v15; // xmm8
			//   float v16; // xmm7_4
			//   float v17; // xmm6_4
			//   float v18; // xmm0_4
			//   __m128 v19; // xmm13
			//   __m128 v20; // xmm13
			//   SHCoefficientsL1 *result; // rax
			//   __m128 v22; // xmm8
			//   __m128 v23; // xmm13
			//   __m128 v24; // xmm8
			//   __m128 v25; // xmm8
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   SHCoefficientsL1 *v32; // rax
			//   Vector4 shAg; // xmm1
			//   Vector4 shAb; // xmm0
			//   SHCoefficientsL1 v35; // [rsp+30h] [rbp-128h] BYREF
			//   SphericalHarmonicsL2 v36; // [rsp+60h] [rbp-F8h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     *(double *)v3.m128_u64 = il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, sh);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (ILFixDynamicMethodWrapper_2 *)v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.fields.methodId <= 836 )
			//   {
			// LABEL_7:
			//     v3.m128_f32[0] = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 3, 0LL);
			//     v8 = v3;
			//     Item = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 1, 0LL);
			//     v10 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 2, 0LL);
			//     v11 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 0, 0LL);
			//     v3.m128_f32[0] = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 3, 0LL);
			//     v12 = _mm_shuffle_ps(v3, v3, 225);
			//     v12.m128_f32[0] = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 1, 0LL);
			//     v13 = _mm_shuffle_ps(v12, v12, 198);
			//     v13.m128_f32[0] = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 2, 0LL);
			//     v14 = _mm_shuffle_ps(v13, v13, 39);
			//     v14.m128_f32[0] = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 0, 0LL);
			//     v3.m128_f32[0] = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 3, 0LL);
			//     v15 = v3;
			//     v16 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 1, 0LL);
			//     v17 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 2, 0LL);
			//     v18 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 0, 0LL);
			//     v19 = _mm_shuffle_ps(v8, v8, 225);
			//     v19.m128_f32[0] = Item;
			//     v20 = _mm_shuffle_ps(v19, v19, 198);
			//     v20.m128_f32[0] = v10;
			//     result = retstr;
			//     v22 = _mm_shuffle_ps(v15, v15, 225);
			//     v22.m128_f32[0] = v16;
			//     v23 = _mm_shuffle_ps(v20, v20, 39);
			//     v23.m128_f32[0] = v11;
			//     v24 = _mm_shuffle_ps(v22, v22, 198);
			//     v24.m128_f32[0] = v17;
			//     v25 = _mm_shuffle_ps(v24, v24, 39);
			//     retstr.shAr = (Vector4)_mm_shuffle_ps(v23, v23, 57);
			//     v25.m128_f32[0] = v18;
			//     retstr.shAg = (Vector4)_mm_shuffle_ps(v14, v14, 57);
			//     retstr.shAb = (Vector4)_mm_shuffle_ps(v25, v25, 57);
			//     return result;
			//   }
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     *(double *)v3.m128_u64 = il2cpp_runtime_class_init_0(v6, wrapperArray);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6.static_fields.wrapperArray;
			//   if ( !v6 )
			//     goto LABEL_8;
			//   if ( LODWORD(v6._0.namespaze) <= 0x344 )
			//     sub_180070270(v6, wrapperArray);
			//   if ( !v6[17].vtable.Finalize.methodPtr )
			//     goto LABEL_7;
			//   wrapperArray = IFix::WrappersManagerImpl::GetPatch(836, 0LL);
			//   if ( !wrapperArray )
			// LABEL_8:
			//     sub_180B536AC(v6, wrapperArray);
			//   v26 = *(_OWORD *)&sh.shr0;
			//   v27 = *(_OWORD *)&sh.shr4;
			//   v36.shb8 = sh.shb8;
			//   *(_OWORD *)&v36.shr0 = v26;
			//   v28 = *(_OWORD *)&sh.shr8;
			//   *(_OWORD *)&v36.shr4 = v27;
			//   v29 = *(_OWORD *)&sh.shg3;
			//   *(_OWORD *)&v36.shr8 = v28;
			//   v30 = *(_OWORD *)&sh.shg7;
			//   *(_OWORD *)&v36.shg3 = v29;
			//   v31 = *(_OWORD *)&sh.shb2;
			//   *(_OWORD *)&v36.shg7 = v30;
			//   *(_QWORD *)&v36.shb6 = *(_QWORD *)&sh.shb6;
			//   *(_OWORD *)&v36.shb2 = v31;
			//   v32 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_325(&v35, wrapperArray, &v36, 0LL);
			//   shAg = v32.shAg;
			//   retstr.shAr = v32.shAr;
			//   shAb = v32.shAb;
			//   result = retstr;
			//   retstr.shAg = shAg;
			//   retstr.shAb = shAb;
			//   return result;
			// }
			// 
			return null;
		}

		public static SHCoefficientsL2 GetCoefficientsL2(this SphericalHarmonicsL2 sh)
		{
			// // SHCoefficientsL2 GetCoefficientsL2(SphericalHarmonicsL2)
			// SHCoefficientsL2 *HG::Rendering::Runtime::HGEnvironmentUtils::GetCoefficientsL2(
			//         SHCoefficientsL2 *__return_ptr retstr,
			//         SphericalHarmonicsL2 *sh,
			//         MethodInfo *method)
			// {
			//   float Item; // xmm7_4
			//   float v6; // xmm9_4
			//   float v7; // xmm8_4
			//   float v8; // xmm7_4
			//   float v9; // xmm6_4
			//   float v10; // xmm9_4
			//   float v11; // xmm8_4
			//   float v12; // xmm7_4
			//   float v13; // xmm6_4
			//   float v14; // xmm7_4
			//   float v15; // xmm6_4
			//   float v16; // xmm0_4
			//   Vector4 v17; // xmm1
			//   Vector4 v18; // xmm0
			//   Vector4 v19; // xmm1
			//   Vector4 v20; // xmm0
			//   Vector4 v21; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v23; // rcx
			//   __int128 v24; // xmm0
			//   Vector4 v25; // xmm1
			//   Vector4 v26; // xmm0
			//   Vector4 v27; // xmm1
			//   Vector4 v28; // xmm0
			//   Vector4 v29; // xmm1
			//   SHCoefficientsL2 *v30; // rax
			//   Vector4 shAg; // xmm1
			//   Vector4 shAb; // xmm0
			//   Vector4 shBr; // xmm1
			//   Vector4 shBg; // xmm0
			//   Vector4 shBb; // xmm1
			//   Vector4 shC; // xmm0
			//   __int128 v38; // [rsp+28h] [rbp-E0h] BYREF
			//   Vector4 v39; // [rsp+38h] [rbp-D0h]
			//   Vector4 v40; // [rsp+48h] [rbp-C0h]
			//   Vector4 v41; // [rsp+58h] [rbp-B0h]
			//   Vector4 v42; // [rsp+68h] [rbp-A0h]
			//   Vector4 v43; // [rsp+78h] [rbp-90h]
			//   Vector4 v44; // [rsp+88h] [rbp-80h]
			//   Vector4 v45; // [rsp+98h] [rbp-70h]
			//   SHCoefficientsL2 v46; // [rsp+A8h] [rbp-60h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1227, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1227, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v23, 0LL);
			//     v24 = *(_OWORD *)&sh.shr0;
			//     v25 = *(Vector4 *)&sh.shr4;
			//     v44.z = sh.shb8;
			//     v38 = v24;
			//     v26 = *(Vector4 *)&sh.shr8;
			//     v39 = v25;
			//     v27 = *(Vector4 *)&sh.shg3;
			//     v40 = v26;
			//     v28 = *(Vector4 *)&sh.shg7;
			//     v41 = v27;
			//     v29 = *(Vector4 *)&sh.shb2;
			//     v42 = v28;
			//     *(_QWORD *)&v44.x = *(_QWORD *)&sh.shb6;
			//     v43 = v29;
			//     v30 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_465(&v46, Patch, (SphericalHarmonicsL2 *)&v38, 0LL);
			//     shAg = v30.shAg;
			//     retstr.shAr = v30.shAr;
			//     shAb = v30.shAb;
			//     retstr.shAg = shAg;
			//     shBr = v30.shBr;
			//     retstr.shAb = shAb;
			//     shBg = v30.shBg;
			//     retstr.shBr = shBr;
			//     shBb = v30.shBb;
			//     retstr.shBg = shBg;
			//     shC = v30.shC;
			//     retstr.shBb = shBb;
			//     retstr.shC = shC;
			//   }
			//   else
			//   {
			//     v45.x = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 3, 0LL);
			//     v45.y = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 1, 0LL);
			//     v45.z = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 2, 0LL);
			//     Item = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 0, 0LL);
			//     v45.w = Item - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 6, 0LL);
			//     v6 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 3, 0LL);
			//     v7 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 1, 0LL);
			//     v8 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 2, 0LL);
			//     v9 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 0, 0LL);
			//     *(_QWORD *)&v39.x = __PAIR64__(LODWORD(v7), LODWORD(v6));
			//     v39.z = v8;
			//     v39.w = v9 - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 6, 0LL);
			//     v10 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 3, 0LL);
			//     v11 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 1, 0LL);
			//     v12 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 2, 0LL);
			//     v13 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 0, 0LL);
			//     *(_QWORD *)&v40.x = __PAIR64__(LODWORD(v11), LODWORD(v10));
			//     v40.z = v12;
			//     v40.w = v13 - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 6, 0LL);
			//     v41.x = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 4, 0LL);
			//     v41.y = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 5, 0LL);
			//     v41.z = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 6, 0LL) * 3.0;
			//     v41.w = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 7, 0LL);
			//     v42.x = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 4, 0LL);
			//     v42.y = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 5, 0LL);
			//     v42.z = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 6, 0LL) * 3.0;
			//     v42.w = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 7, 0LL);
			//     v43.x = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 4, 0LL);
			//     v43.y = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 5, 0LL);
			//     v43.z = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 6, 0LL) * 3.0;
			//     v43.w = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 7, 0LL);
			//     v14 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 8, 0LL);
			//     v15 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 8, 0LL);
			//     v16 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 8, 0LL);
			//     v17 = v40;
			//     retstr.shAr = v45;
			//     *(_QWORD *)&v44.z = LODWORD(v16) | 0x3F80000000000000LL;
			//     retstr.shAg = v39;
			//     v18 = v41;
			//     retstr.shAb = v17;
			//     v19 = v42;
			//     retstr.shBr = v18;
			//     v20 = v43;
			//     retstr.shBg = v19;
			//     *(_QWORD *)&v44.x = __PAIR64__(LODWORD(v15), LODWORD(v14));
			//     v21 = v44;
			//     retstr.shBb = v20;
			//     retstr.shC = v21;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static float GetExposureFromEV100(float ev100)
		{
			// // Single GetExposureFromEV100(Single)
			// float HG::Rendering::Runtime::HGEnvironmentUtils::GetExposureFromEV100(float ev100, MethodInfo *method)
			// {
			//   __int64 v2; // rdx
			//   int v3; // ecx
			//   double v4; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1228, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1228, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, ev100, 0LL);
			//   }
			//   else
			//   {
			//     v4 = sub_1802EB1B0(v3, v2);
			//     return 1.0 / (float)(*(float *)&v4 * 1.2);
			//   }
			// }
			// 
			return 0f;
		}

		public static void TentToCoefficients(float tentTipAltitude, float tentTipValue, float tentWidth, out float layerWidth, out float linTerm0, out float linTerm1, out float constTerm0, out float constTerm1)
		{
			// // Void TentToCoefficients(Single, Single, Single, Single ByRef, Single ByRef, Single ByRef, Single ByRef, Single ByRef)
			// void HG::Rendering::Runtime::HGEnvironmentUtils::TentToCoefficients(
			//         float tentTipAltitude,
			//         float tentTipValue,
			//         float tentWidth,
			//         float *layerWidth,
			//         float *linTerm0,
			//         float *linTerm1,
			//         float *constTerm0,
			//         float *constTerm1,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1205, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1205, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_453(
			//       Patch,
			//       tentTipAltitude,
			//       tentTipValue,
			//       tentWidth,
			//       layerWidth,
			//       linTerm0,
			//       linTerm1,
			//       constTerm0,
			//       constTerm1,
			//       0LL);
			//   }
			//   else if ( tentWidth <= 0.0 || tentTipValue <= 0.0 )
			//   {
			//     *layerWidth = 0.0;
			//     *linTerm0 = 0.0;
			//     *linTerm1 = 0.0;
			//     *constTerm0 = 0.0;
			//     *constTerm1 = 0.0;
			//   }
			//   else
			//   {
			//     *layerWidth = tentTipAltitude;
			//     *linTerm0 = tentTipValue / tentWidth;
			//     *linTerm1 = -(float)(tentTipValue / tentWidth);
			//     *constTerm0 = tentTipValue - (float)(tentTipAltitude * *linTerm0);
			//     *constTerm1 = tentTipValue - (float)(tentTipAltitude * *linTerm1);
			//   }
			// }
			// 
		}

		public static Mesh GenerateStarMesh([MetadataOffset(Offset = "0x01F90C6E")] bool forceRegenerate = false)
		{
			return null;
		}

		public static Mesh CreateGoldbergPolyhedron(int subdivisions)
		{
			// // Mesh CreateGoldbergPolyhedron(Int32)
			// Mesh *HG::Rendering::Runtime::HGEnvironmentUtils::CreateGoldbergPolyhedron(int32_t subdivisions, MethodInfo *method)
			// {
			//   __int64 v2; // rbx
			//   __int64 v3; // rdx
			//   __int64 z_low; // rcx
			//   Mesh *Icosahedron; // rbp
			//   Vector3__Array *vertices; // rax
			//   __int64 v7; // r8
			//   __int64 v8; // r9
			//   Vector3__Array *v9; // rdi
			//   Vector2__Array *v10; // rsi
			//   int32_t i; // ebx
			//   __int64 v12; // rax
			//   __int64 v13; // rax
			//   __int64 v14; // xmm0_8
			//   MethodInfo *v15; // r9
			//   Vector3 *v16; // rax
			//   float v17; // xmm7_4
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   float v20; // xmm0_4
			//   __int64 v21; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v24; // [rsp+20h] [rbp-A8h] BYREF
			//   _BYTE v25[16]; // [rsp+30h] [rbp-98h] BYREF
			//   Vector3 v26[2]; // [rsp+40h] [rbp-88h] BYREF
			// 
			//   v2 = (unsigned int)subdivisions;
			//   if ( !byte_18D8EDC4A )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector2);
			//     sub_18003C530(&off_18C9B5520);
			//     byte_18D8EDC4A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1230, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1230, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_467(Patch, v2, 0LL);
			// LABEL_7:
			//     sub_180B536AC(z_low, v3);
			//   }
			//   Icosahedron = HG::Rendering::Runtime::HGEnvironmentUtils::CreateIcosahedron(0LL);
			//   if ( (int)v2 > 0 )
			//   {
			//     do
			//     {
			//       Icosahedron = HG::Rendering::Runtime::HGEnvironmentUtils::Subdivide(Icosahedron, 0LL);
			//       --v2;
			//     }
			//     while ( v2 );
			//   }
			//   if ( !Icosahedron )
			//     goto LABEL_7;
			//   vertices = UnityEngine::Mesh::get_vertices(Icosahedron, 0LL);
			//   v9 = vertices;
			//   if ( !vertices )
			//     goto LABEL_7;
			//   v10 = (Vector2__Array *)il2cpp_array_new_specific_0(
			//                             TypeInfo::UnityEngine::Vector2,
			//                             (unsigned int)vertices.max_length.size,
			//                             v7,
			//                             v8);
			//   for ( i = 0; i < v9.max_length.size; ++i )
			//   {
			//     v12 = sub_18003EB60(v9, i);
			//     v13 = sub_182413270(v25, v12);
			//     v14 = *(_QWORD *)v13;
			//     LODWORD(v13) = *(_DWORD *)(v13 + 8);
			//     *(_QWORD *)&v24.x = v14;
			//     LODWORD(v24.z) = v13;
			//     v16 = UnityEngine::Vector3::op_Multiply(v26, &v24, 1.0, v15);
			//     if ( (unsigned int)i >= v9.max_length.size )
			//       goto LABEL_17;
			//     v3 = 3LL * i;
			//     *(_QWORD *)&v9.vector[(unsigned __int64)v3 / 3].x = *(_QWORD *)&v16.x;
			//     z_low = LODWORD(v16.z);
			//     LODWORD(v9.vector[(unsigned __int64)v3 / 3].z) = z_low;
			//     if ( (unsigned int)i >= v9.max_length.size )
			//       goto LABEL_17;
			//     v17 = (float)(sub_1802E8DF0(z_low, v3) / 6.2831855) + 0.5;
			//     v20 = (float)(sub_1802E8980(v19, v18) / 3.1415927) + 0.5;
			//     if ( !v10 )
			//       goto LABEL_7;
			//     if ( (unsigned int)i >= v10.max_length.size )
			// LABEL_17:
			//       sub_180070270(z_low, v3);
			//     v21 = i;
			//     v10.vector[v21].x = v17;
			//     v10.vector[v21].y = v20;
			//   }
			//   UnityEngine::Mesh::set_vertices(Icosahedron, v9, 0LL);
			//   UnityEngine::Mesh::set_uv(Icosahedron, v10, 0LL);
			//   UnityEngine::Mesh::RecalculateNormals(Icosahedron, MeshUpdateFlags__Enum_Default, 0LL);
			//   UnityEngine::Object::set_hideFlags((Object_1 *)Icosahedron, HideFlags__Enum_HideAndDontSave, 0LL);
			//   UnityEngine::Mesh::UploadMeshData(Icosahedron, 1, 0LL);
			//   UnityEngine::Object::set_name((Object_1 *)Icosahedron, (String *)"GoldbergPolyhedron", 0LL);
			//   return Icosahedron;
			// }
			// 
			return null;
		}

		public static Mesh CreateIcosahedron()
		{
			// // Mesh CreateIcosahedron()
			// Mesh *HG::Rendering::Runtime::HGEnvironmentUtils::CreateIcosahedron(MethodInfo *method)
			// {
			//   Mesh *v1; // rax
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			//   Mesh *v4; // rsi
			//   float3 *v5; // rdx
			//   float3 *v6; // rcx
			//   float3 *v7; // r8
			//   float3 *v8; // r9
			//   __m128 v9; // xmm6
			//   __int64 v10; // rdi
			//   __int64 v11; // rax
			//   int v12; // eax
			//   __int64 v13; // rax
			//   int v14; // eax
			//   __int64 v15; // rax
			//   int v16; // eax
			//   __int64 v17; // rax
			//   int v18; // eax
			//   __int64 v19; // rax
			//   int v20; // eax
			//   __int64 v21; // rax
			//   int v22; // eax
			//   __int64 v23; // rax
			//   int v24; // eax
			//   __int64 v25; // rax
			//   int v26; // eax
			//   __int64 v27; // rax
			//   int v28; // eax
			//   __int64 v29; // rax
			//   int v30; // eax
			//   __int64 v31; // rax
			//   __int64 v32; // rax
			//   __int64 v33; // r8
			//   __int64 v34; // r9
			//   Array *v35; // rbx
			//   __m128 v37; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   unsigned __int64 v39; // [rsp+20h] [rbp-19h] BYREF
			//   float v40; // [rsp+28h] [rbp-11h]
			//   _BYTE v41[16]; // [rsp+30h] [rbp-9h] BYREF
			// 
			//   if ( !byte_18D8EDC4B )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
			//     sub_18003C530(&DCBEA4AF8FCA3574A40E0078B6F6F21226FA3AA4D9B1062ACDF0409F822D7375_Field);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     byte_18D8EDC4B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1231, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1231, 0LL);
			//     if ( !Patch )
			//       goto LABEL_8;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_366(Patch, 0LL);
			//   }
			//   else
			//   {
			//     v1 = (Mesh *)sub_180004920(TypeInfo::UnityEngine::Mesh);
			//     v4 = v1;
			//     if ( !v1 )
			//       goto LABEL_8;
			//     UnityEngine::Mesh::Mesh(v1, 0LL);
			//     if ( 5.0 < 0.0 )
			//     {
			//       v37 = (__m128)0x40A00000u;
			//       v37.m128_f32[0] = sub_1802ECED0(v6, v5, v7, v8);
			//       v9 = v37;
			//     }
			//     else
			//     {
			//       v9 = 0LL;
			//       v9.m128_f32[0] = fsqrt(5.0);
			//     }
			//     v9.m128_f32[0] = (float)(v9.m128_f32[0] + 1.0) * 0.5;
			//     v39 = _mm_unpacklo_ps((__m128)0xBF800000, v9).m128_u64[0];
			//     v10 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector3, 12LL, v7, v8);
			//     v40 = 0.0;
			//     v11 = sub_182413270(v41, &v39);
			//     if ( !v10 )
			// LABEL_8:
			//       sub_180B536AC(v3, v2);
			//     if ( !*(_DWORD *)(v10 + 24) )
			//       goto LABEL_23;
			//     *(_QWORD *)(v10 + 32) = *(_QWORD *)v11;
			//     v12 = *(_DWORD *)(v11 + 8);
			//     v39 = _mm_unpacklo_ps((__m128)0x3F800000u, v9).m128_u64[0];
			//     v40 = 0.0;
			//     *(_DWORD *)(v10 + 40) = v12;
			//     v13 = sub_182413270(v41, &v39);
			//     if ( *(_DWORD *)(v10 + 24) <= 1u )
			//       goto LABEL_23;
			//     *(_QWORD *)(v10 + 44) = *(_QWORD *)v13;
			//     v14 = *(_DWORD *)(v13 + 8);
			//     v40 = 0.0;
			//     v39 = _mm_unpacklo_ps((__m128)0xBF800000, _mm_xor_ps(v9, (__m128)0x80000000)).m128_u64[0];
			//     *(_DWORD *)(v10 + 52) = v14;
			//     v15 = sub_182413270(v41, &v39);
			//     if ( *(_DWORD *)(v10 + 24) <= 2u )
			//       goto LABEL_23;
			//     *(_QWORD *)(v10 + 56) = *(_QWORD *)v15;
			//     v16 = *(_DWORD *)(v15 + 8);
			//     v40 = 0.0;
			//     *(_DWORD *)(v10 + 64) = v16;
			//     v39 = _mm_unpacklo_ps((__m128)0x3F800000u, _mm_xor_ps(v9, (__m128)0x80000000)).m128_u64[0];
			//     v17 = sub_182413270(v41, &v39);
			//     if ( *(_DWORD *)(v10 + 24) <= 3u )
			//       goto LABEL_23;
			//     *(_QWORD *)(v10 + 68) = *(_QWORD *)v17;
			//     v18 = *(_DWORD *)(v17 + 8);
			//     v39 = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
			//     v40 = v9.m128_f32[0];
			//     *(_DWORD *)(v10 + 76) = v18;
			//     v19 = sub_182413270(v41, &v39);
			//     if ( *(_DWORD *)(v10 + 24) <= 4u )
			//       goto LABEL_23;
			//     *(_QWORD *)(v10 + 80) = *(_QWORD *)v19;
			//     v20 = *(_DWORD *)(v19 + 8);
			//     v39 = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//     v40 = v9.m128_f32[0];
			//     *(_DWORD *)(v10 + 88) = v20;
			//     v21 = sub_182413270(v41, &v39);
			//     if ( *(_DWORD *)(v10 + 24) <= 5u )
			//       goto LABEL_23;
			//     *(_QWORD *)(v10 + 92) = *(_QWORD *)v21;
			//     v22 = *(_DWORD *)(v21 + 8);
			//     v39 = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
			//     v40 = -v9.m128_f32[0];
			//     *(_DWORD *)(v10 + 100) = v22;
			//     v23 = sub_182413270(v41, &v39);
			//     if ( *(_DWORD *)(v10 + 24) <= 6u )
			//       goto LABEL_23;
			//     *(_QWORD *)(v10 + 104) = *(_QWORD *)v23;
			//     v24 = *(_DWORD *)(v23 + 8);
			//     v39 = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//     v40 = -v9.m128_f32[0];
			//     *(_DWORD *)(v10 + 112) = v24;
			//     v25 = sub_182413270(v41, &v39);
			//     if ( *(_DWORD *)(v10 + 24) <= 7u )
			//       goto LABEL_23;
			//     *(_QWORD *)(v10 + 116) = *(_QWORD *)v25;
			//     v26 = *(_DWORD *)(v25 + 8);
			//     v39 = _mm_unpacklo_ps(v9, (__m128)0LL).m128_u64[0];
			//     v40 = -1.0;
			//     *(_DWORD *)(v10 + 124) = v26;
			//     v27 = sub_182413270(v41, &v39);
			//     if ( *(_DWORD *)(v10 + 24) <= 8u )
			//       goto LABEL_23;
			//     *(_QWORD *)(v10 + 128) = *(_QWORD *)v27;
			//     v28 = *(_DWORD *)(v27 + 8);
			//     v39 = _mm_unpacklo_ps(v9, (__m128)0LL).m128_u64[0];
			//     v40 = 1.0;
			//     *(_DWORD *)(v10 + 136) = v28;
			//     v29 = sub_182413270(v41, &v39);
			//     if ( *(_DWORD *)(v10 + 24) <= 9u )
			//       goto LABEL_23;
			//     *(_QWORD *)(v10 + 140) = *(_QWORD *)v29;
			//     v30 = *(_DWORD *)(v29 + 8);
			//     v40 = -1.0;
			//     v39 = _mm_unpacklo_ps(_mm_xor_ps(v9, (__m128)0x80000000), (__m128)0LL).m128_u64[0];
			//     *(_DWORD *)(v10 + 148) = v30;
			//     v31 = sub_182413270(v41, &v39);
			//     if ( *(_DWORD *)(v10 + 24) <= 0xAu
			//       || (*(_QWORD *)(v10 + 152) = *(_QWORD *)v31,
			//           *(_DWORD *)(v10 + 160) = *(_DWORD *)(v31 + 8),
			//           v39 = _mm_unpacklo_ps(_mm_xor_ps(v9, (__m128)0x80000000), (__m128)0LL).m128_u64[0],
			//           v40 = 1.0,
			//           v32 = sub_182413270(v41, &v39),
			//           *(_DWORD *)(v10 + 24) <= 0xBu) )
			//     {
			// LABEL_23:
			//       sub_180070270(v3, v2);
			//     }
			//     *(_QWORD *)(v10 + 164) = *(_QWORD *)v32;
			//     *(_DWORD *)(v10 + 172) = *(_DWORD *)(v32 + 8);
			//     v35 = (Array *)il2cpp_array_new_specific_0(TypeInfo::System::Int32, 60LL, v33, v34);
			//     System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//       v35,
			//       DCBEA4AF8FCA3574A40E0078B6F6F21226FA3AA4D9B1062ACDF0409F822D7375_Field,
			//       0LL);
			//     UnityEngine::Mesh::set_vertices(v4, (Vector3__Array *)v10, 0LL);
			//     UnityEngine::Mesh::set_triangles(v4, (Int32__Array *)v35, 0LL);
			//     UnityEngine::Mesh::RecalculateNormals(v4, MeshUpdateFlags__Enum_Default, 0LL);
			//     return v4;
			//   }
			// }
			// 
			return null;
		}

		public static Mesh Subdivide(Mesh mesh)
		{
			// // Mesh Subdivide(Mesh)
			// Mesh *HG::Rendering::Runtime::HGEnvironmentUtils::Subdivide(Mesh *mesh, MethodInfo *method)
			// {
			//   int32_t v3; // r13d
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   OneofDescriptorProto *v6; // rdx
			//   FileDescriptor *v7; // r8
			//   MessageDescriptor *v8; // r9
			//   Int32__Array *triangles; // rbx
			//   List_1_UnityEngine_Vector3_ *v10; // rax
			//   List_1_UnityEngine_Vector3_ *v11; // rdi
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v15; // rax
			//   Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v16; // rax
			//   OneofDescriptor__Class *v17; // rdi
			//   OneofDescriptorProto *v18; // rdx
			//   FileDescriptor *v19; // r8
			//   MessageDescriptor *v20; // r9
			//   __int64 v21; // rsi
			//   __int64 v22; // r14
			//   int32_t v23; // esi
			//   int32_t v24; // r14d
			//   int32_t v25; // edi
			//   int32_t MiddleVertex_17_0; // r12d
			//   int32_t v27; // r15d
			//   int32_t v28; // ebp
			//   Vector3__Array *v29; // rax
			//   Int32__Array *v30; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v33; // [rsp+20h] [rbp-78h]
			//   __m128i v34; // [rsp+20h] [rbp-78h]
			//   String__Array *v35; // [rsp+20h] [rbp-78h]
			//   String *v36; // [rsp+28h] [rbp-70h]
			//   String *v37; // [rsp+28h] [rbp-70h]
			//   OneofDescriptor param_00045f29; // [rsp+30h] [rbp-68h] BYREF
			//   List_1_System_Int32_ *v40; // [rsp+B0h] [rbp+18h]
			// 
			//   if ( !byte_18D8EDC4C )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<System::String,int>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::ToArray);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::ToArray);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
			//     byte_18D8EDC4C = 1;
			//   }
			//   v3 = 0;
			//   param_00045f29.klass = 0LL;
			//   *(_QWORD *)&param_00045f29.fields._._Index_k__BackingField = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1232, 0LL) )
			//   {
			//     if ( mesh )
			//     {
			//       param_00045f29.monitor = (MonitorData *)UnityEngine::Mesh::get_vertices(mesh, 0LL);
			//       sub_1800054D0(
			//         (OneofDescriptor *)&param_00045f29.monitor,
			//         v6,
			//         v7,
			//         v8,
			//         v33,
			//         v36,
			//         (MethodInfo *)param_00045f29.klass);
			//       triangles = UnityEngine::Mesh::get_triangles(mesh, 0LL);
			//       v34 = *(__m128i *)&param_00045f29.klass;
			//       v10 = (List_1_UnityEngine_Vector3_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
			//       v11 = v10;
			//       if ( v10 )
			//       {
			//         System::Collections::Generic::List<UnityEngine::Vector3>::List(
			//           v10,
			//           (IEnumerable_1_UnityEngine_Vector3_ *)_mm_srli_si128(v34, 8).m128i_i64[0],
			//           MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
			//         *(_QWORD *)&param_00045f29.fields._._Index_k__BackingField = v11;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&param_00045f29.fields,
			//           v12,
			//           v13,
			//           v14,
			//           (String__Array *)v34.m128i_i64[0],
			//           (String *)v34.m128i_i64[1],
			//           (MethodInfo *)param_00045f29.klass);
			//         v15 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//         v40 = (List_1_System_Int32_ *)v15;
			//         if ( v15 )
			//         {
			//           System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//             v15,
			//             MethodInfo::System::Collections::Generic::List<int>::List);
			//           v16 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::String,int>);
			//           v17 = (OneofDescriptor__Class *)v16;
			//           if ( v16 )
			//           {
			//             System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Dictionary(
			//               v16,
			//               MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::Dictionary);
			//             param_00045f29.klass = v17;
			//             ((void (__stdcall *)(OneofDescriptor *, OneofDescriptorProto *, FileDescriptor *, MessageDescriptor *, String__Array *, String *))sub_1800054D0)(
			//               &param_00045f29,
			//               v18,
			//               v19,
			//               v20,
			//               v35,
			//               v37);
			//             if ( triangles )
			//             {
			//               while ( v3 < triangles.max_length.size )
			//               {
			//                 if ( (unsigned int)v3 >= triangles.max_length.size
			//                   || (v21 = v3 + 1LL, (unsigned int)v21 >= triangles.max_length.size)
			//                   || (v22 = v3 + 2LL, (unsigned int)v22 >= triangles.max_length.size) )
			//                 {
			//                   sub_180070270(v5, v4);
			//                 }
			//                 v23 = triangles.vector[v21];
			//                 v24 = triangles.vector[v22];
			//                 v25 = triangles.vector[v3];
			//                 MiddleVertex_17_0 = HG::Rendering::Runtime::HGEnvironmentUtils::_Subdivide_g__GetMiddleVertex_17_0(
			//                                       v25,
			//                                       v23,
			//                                       (HGEnvironmentUtils_c_DisplayClass17_0 *)&param_00045f29,
			//                                       0LL);
			//                 v27 = HG::Rendering::Runtime::HGEnvironmentUtils::_Subdivide_g__GetMiddleVertex_17_0(
			//                         v23,
			//                         v24,
			//                         (HGEnvironmentUtils_c_DisplayClass17_0 *)&param_00045f29,
			//                         0LL);
			//                 v28 = HG::Rendering::Runtime::HGEnvironmentUtils::_Subdivide_g__GetMiddleVertex_17_0(
			//                         v24,
			//                         v25,
			//                         (HGEnvironmentUtils_c_DisplayClass17_0 *)&param_00045f29,
			//                         0LL);
			//                 sub_18231EF50(v40, v25);
			//                 sub_18231EF50(v40, MiddleVertex_17_0);
			//                 sub_18231EF50(v40, v28);
			//                 sub_18231EF50(v40, v23);
			//                 sub_18231EF50(v40, v27);
			//                 sub_18231EF50(v40, MiddleVertex_17_0);
			//                 sub_18231EF50(v40, v24);
			//                 sub_18231EF50(v40, v28);
			//                 sub_18231EF50(v40, v27);
			//                 sub_18231EF50(v40, MiddleVertex_17_0);
			//                 sub_18231EF50(v40, v27);
			//                 sub_18231EF50(v40, v28);
			//                 v3 += 3;
			//               }
			//               v5 = *(_QWORD *)&param_00045f29.fields._._Index_k__BackingField;
			//               if ( *(_QWORD *)&param_00045f29.fields._._Index_k__BackingField )
			//               {
			//                 v29 = (Vector3__Array *)System::Collections::Generic::List<UnityEngine::InputSystem::HID::HID::HIDElementDescriptor>::ToArray(
			//                                           *(List_1_UnityEngine_InputSystem_HID_HID_HIDElementDescriptor_ **)&param_00045f29.fields._._Index_k__BackingField,
			//                                           MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::ToArray);
			//                 UnityEngine::Mesh::set_vertices(mesh, v29, 0LL);
			//                 v30 = System::Collections::Generic::List<int>::ToArray(
			//                         v40,
			//                         MethodInfo::System::Collections::Generic::List<int>::ToArray);
			//                 UnityEngine::Mesh::set_triangles(mesh, v30, 0LL);
			//                 UnityEngine::Mesh::RecalculateNormals(mesh, MeshUpdateFlags__Enum_Default, 0LL);
			//                 return mesh;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_5:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1232, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_355(Patch, (Object *)mesh, 0LL);
			// }
			// 
			return null;
		}

		public static float SkydomeStarHalfFovCos(float starRadius, float distanceToStar)
		{
			// // Single SkydomeStarHalfFovCos(Single, Single)
			// float HG::Rendering::Runtime::HGEnvironmentUtils::SkydomeStarHalfFovCos(
			//         float starRadius,
			//         float distanceToStar,
			//         MethodInfo *method)
			// {
			//   float3 *v3; // rdx
			//   float3 *v4; // rcx
			//   float3 *v5; // r8
			//   float3 *v6; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1233, 0LL) )
			//     return sub_1802ECED0(v4, v3, v5, v6);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1233, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v10, v9);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(
			//            (ILFixDynamicMethodWrapper_3 *)Patch,
			//            starRadius,
			//            distanceToStar,
			//            0LL);
			// }
			// 
			return 0f;
		}

		[IDTag(0)]
		public static void SetTextureIfNotNull(this MaterialPropertyBlock materialPropertyBlock, int nameId, Texture texture)
		{
			// // Void SetTextureIfNotNull(MaterialPropertyBlock, Int32, Texture)
			// void HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
			//         MaterialPropertyBlock *materialPropertyBlock,
			//         int32_t nameId,
			//         Texture *texture,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919D6F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919D6F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1234, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)texture, 0LL, 0LL) )
			//       return;
			//     if ( materialPropertyBlock )
			//     {
			//       UnityEngine::MaterialPropertyBlock::SetTextureImpl(materialPropertyBlock, nameId, texture, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1234, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_19(
			//     (ILFixDynamicMethodWrapper_14 *)Patch,
			//     (Object *)materialPropertyBlock,
			//     (SCMessageID__Enum)nameId,
			//     (Object *)texture,
			//     0LL);
			// }
			// 
		}

		[IDTag(1)]
		public static void SetTextureIfNotNull(this MaterialPropertyBlock materialPropertyBlock, string name, Texture texture)
		{
			// // Void SetTextureIfNotNull(MaterialPropertyBlock, String, Texture)
			// void HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
			//         MaterialPropertyBlock *materialPropertyBlock,
			//         String *name,
			//         Texture *texture,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919D70 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919D70 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1235, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality((Object_1 *)texture, 0LL, 0LL) )
			//       return;
			//     if ( materialPropertyBlock )
			//     {
			//       UnityEngine::MaterialPropertyBlock::SetTexture(materialPropertyBlock, name, texture, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1235, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)materialPropertyBlock,
			//     (Object *)name,
			//     (Object *)texture,
			//     0LL);
			// }
			// 
		}

		public static void SetColorIfNecessary(this Light light, Color value)
		{
			// // Void SetColorIfNecessary(Light, Color)
			// void HG::Rendering::Runtime::HGEnvironmentUtils::SetColorIfNecessary(Light *light, Color *value, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   void (__fastcall *v7)(Light *, Color *, MethodInfo *); // rax
			//   Color v8; // xmm1
			//   MethodInfo *v9; // r8
			//   Color v10; // xmm3
			//   MethodInfo *v11; // r8
			//   __m128 *v12; // rax
			//   __m128 v13; // xmm5
			//   float v14; // xmm4_4
			//   float v15; // xmm2_4
			//   void (__fastcall *v16)(Light *, Color *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v18; // rax
			//   Color v19; // [rsp+20h] [rbp-38h] BYREF
			//   Color v20; // [rsp+30h] [rbp-28h] BYREF
			//   Color v21; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, value);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_16;
			//   if ( wrapperArray.max_length.size <= 605 )
			//     goto LABEL_7;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			// LABEL_16:
			//     sub_180B536AC(v5, wrapperArray);
			//   if ( LODWORD(v5._0.namespaze) <= 0x25D )
			//     sub_180070270(v5, wrapperArray);
			//   if ( v5[12].vtable.ToString.methodPtr )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(605, 0LL);
			//     if ( Patch )
			//     {
			//       v19 = *value;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_234(Patch, (Object *)light, &v19, 0LL);
			//       return;
			//     }
			//     goto LABEL_16;
			//   }
			// LABEL_7:
			//   if ( !light )
			//     goto LABEL_16;
			//   v7 = (void (__fastcall *)(Light *, Color *, MethodInfo *))qword_18D8F47E8;
			//   v19 = 0LL;
			//   if ( !qword_18D8F47E8 )
			//   {
			//     v7 = (void (__fastcall *)(Light *, Color *, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                 "UnityEngine.Light::get_color_Injected(UnityEngine.Color&)");
			//     if ( !v7 )
			//     {
			//       v18 = sub_1802DBBE8("UnityEngine.Light::get_color_Injected(UnityEngine.Color&)");
			//       sub_18000F750(v18, 0LL);
			//     }
			//     qword_18D8F47E8 = (__int64)v7;
			//   }
			//   v7(light, &v19, method);
			//   v8 = *value;
			//   v20 = v19;
			//   v19 = v8;
			//   v10 = *UnityEngine::Color::op_Implicit(&v21, (Vector4 *)&v19, v9);
			//   v12 = (__m128 *)UnityEngine::Color::op_Implicit(&v19, (Vector4 *)&v20, v11);
			//   v13 = *v12;
			//   v14 = _mm_shuffle_ps(v13, v13, 85).m128_f32[0] - _mm_shuffle_ps((__m128)v10, (__m128)v10, 85).m128_f32[0];
			//   v8.r = _mm_shuffle_ps(*v12, *v12, 170).m128_f32[0] - _mm_shuffle_ps((__m128)v10, (__m128)v10, 170).m128_f32[0];
			//   v13.m128_f32[0] = _mm_shuffle_ps(v13, v13, 255).m128_f32[0];
			//   v15 = (float)(COERCE_FLOAT(*v12) - v10.r) * (float)(COERCE_FLOAT(*v12) - v10.r);
			//   v10.r = _mm_shuffle_ps((__m128)v10, (__m128)v10, 255).m128_f32[0];
			//   if ( (float)((float)((float)((float)(v14 * v14) + v15) + (float)(v8.r * v8.r))
			//              + (float)((float)(v13.m128_f32[0] - v10.r) * (float)(v13.m128_f32[0] - v10.r))) >= 9.9999994e-11 )
			//   {
			//     v16 = (void (__fastcall *)(Light *, Color *))qword_18D8F47F0;
			//     v20 = *value;
			//     if ( !qword_18D8F47F0 )
			//     {
			//       v16 = (void (__fastcall *)(Light *, Color *))sub_180017470("UnityEngine.Light::set_color_Injected(UnityEngine.Color&)");
			//       qword_18D8F47F0 = (__int64)v16;
			//     }
			//     v16(light, &v20);
			//   }
			// }
			// 
		}

		public static void SetIntensityIfNecessary(this Light light, float value)
		{
			// // Void SetIntensityIfNecessary(Light, Single)
			// void HG::Rendering::Runtime::HGEnvironmentUtils::SetIntensityIfNecessary(Light *light, float value, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   double (__fastcall *v8)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
			//   double v9; // xmm0_8
			//   __int32 v10; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v3);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_16;
			//   if ( wrapperArray.max_length.size <= 606 )
			//     goto LABEL_7;
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v6, wrapperArray);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6.static_fields.wrapperArray;
			//   if ( !v6 )
			// LABEL_16:
			//     sub_180B536AC(v6, wrapperArray);
			//   if ( LODWORD(v6._0.namespaze) <= 0x25E )
			//     sub_180070270(v6, wrapperArray);
			//   if ( v6[12].vtable.ToString.method )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(606, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)light, value, 0LL);
			//       return;
			//     }
			//     goto LABEL_16;
			//   }
			// LABEL_7:
			//   if ( !light )
			//     goto LABEL_16;
			//   v8 = (double (__fastcall *)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18D8F47B8;
			//   if ( !qword_18D8F47B8 )
			//   {
			//     v8 = (double (__fastcall *)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                                                "UnityEngine.Light::get_intensity()");
			//     if ( !v8 )
			//     {
			//       v12 = sub_1802DBBE8("UnityEngine.Light::get_intensity()");
			//       sub_18000F750(v12, 0LL);
			//     }
			//     qword_18D8F47B8 = (__int64)v8;
			//   }
			//   v9 = v8(light, wrapperArray, method);
			//   if ( !byte_18D8E3A94 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     byte_18D8E3A94 = 1;
			//   }
			//   COERCE_FLOAT(v10 = _mm_load_si128((const __m128i *)&xmmword_18A357260).m128i_i32[0]);
			//   if ( fmaxf(
			//          fmaxf(COERCE_FLOAT(LODWORD(v9) & v10), COERCE_FLOAT(LODWORD(value) & v10)) * 0.000001,
			//          TypeInfo::UnityEngine::Mathf.static_fields.Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(value - *(float *)&v9) & v10) )
			//     UnityEngine::Light::set_intensity(light, value, 0LL);
			// }
			// 
		}

		public static void SetSpecularIntensityIfNecessary(this Light light, float value)
		{
			// // Void SetSpecularIntensityIfNecessary(Light, Single)
			// void HG::Rendering::Runtime::HGEnvironmentUtils::SetSpecularIntensityIfNecessary(
			//         Light *light,
			//         float value,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   double (__fastcall *v8)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
			//   double v9; // xmm0_8
			//   __int32 v10; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v3);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_16;
			//   if ( wrapperArray.max_length.size <= 607 )
			//     goto LABEL_7;
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v6, wrapperArray);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6.static_fields.wrapperArray;
			//   if ( !v6 )
			// LABEL_16:
			//     sub_180B536AC(v6, wrapperArray);
			//   if ( LODWORD(v6._0.namespaze) <= 0x25F )
			//     sub_180070270(v6, wrapperArray);
			//   if ( v6[13]._0.image )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(607, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)light, value, 0LL);
			//       return;
			//     }
			//     goto LABEL_16;
			//   }
			// LABEL_7:
			//   if ( !light )
			//     goto LABEL_16;
			//   v8 = (double (__fastcall *)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18D8F47C8;
			//   if ( !qword_18D8F47C8 )
			//   {
			//     v8 = (double (__fastcall *)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                                                "UnityEngine.Light::get_sp"
			//                                                                                                "ecularIntensity()");
			//     if ( !v8 )
			//     {
			//       v12 = sub_1802DBBE8("UnityEngine.Light::get_specularIntensity()");
			//       sub_18000F750(v12, 0LL);
			//     }
			//     qword_18D8F47C8 = (__int64)v8;
			//   }
			//   v9 = v8(light, wrapperArray, method);
			//   if ( !byte_18D8E3A94 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     byte_18D8E3A94 = 1;
			//   }
			//   COERCE_FLOAT(v10 = _mm_load_si128((const __m128i *)&xmmword_18A357260).m128i_i32[0]);
			//   if ( fmaxf(
			//          fmaxf(COERCE_FLOAT(LODWORD(v9) & v10), COERCE_FLOAT(LODWORD(value) & v10)) * 0.000001,
			//          TypeInfo::UnityEngine::Mathf.static_fields.Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(value - *(float *)&v9) & v10) )
			//     UnityEngine::Light::set_specularIntensity(light, value, 0LL);
			// }
			// 
		}

		public static void SetSoftSourceRaidiusIfNecessary(this Light light, float value)
		{
			// // Void SetSoftSourceRaidiusIfNecessary(Light, Single)
			// void HG::Rendering::Runtime::HGEnvironmentUtils::SetSoftSourceRaidiusIfNecessary(
			//         Light *light,
			//         float value,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   double (__fastcall *v8)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
			//   double v9; // xmm0_8
			//   __int32 v10; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v3);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v6.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_16;
			//   if ( wrapperArray.max_length.size <= 608 )
			//     goto LABEL_7;
			//   if ( !v6._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v6, wrapperArray);
			//     v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6.static_fields.wrapperArray;
			//   if ( !v6 )
			// LABEL_16:
			//     sub_180B536AC(v6, wrapperArray);
			//   if ( LODWORD(v6._0.namespaze) <= 0x260 )
			//     sub_180070270(v6, wrapperArray);
			//   if ( v6[13]._0.gc_desc )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(608, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_27((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)light, value, 0LL);
			//       return;
			//     }
			//     goto LABEL_16;
			//   }
			// LABEL_7:
			//   if ( !light )
			//     goto LABEL_16;
			//   v8 = (double (__fastcall *)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18D8F47D8;
			//   if ( !qword_18D8F47D8 )
			//   {
			//     v8 = (double (__fastcall *)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_0(
			//                                                                                                "UnityEngine.Light::get_so"
			//                                                                                                "ftSourceRadius()");
			//     if ( !v8 )
			//     {
			//       v12 = sub_1802DBBE8("UnityEngine.Light::get_softSourceRadius()");
			//       sub_18000F750(v12, 0LL);
			//     }
			//     qword_18D8F47D8 = (__int64)v8;
			//   }
			//   v9 = v8(light, wrapperArray, method);
			//   if ( !byte_18D8E3A94 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     byte_18D8E3A94 = 1;
			//   }
			//   COERCE_FLOAT(v10 = _mm_load_si128((const __m128i *)&xmmword_18A357260).m128i_i32[0]);
			//   if ( fmaxf(
			//          fmaxf(COERCE_FLOAT(LODWORD(v9) & v10), COERCE_FLOAT(LODWORD(value) & v10)) * 0.000001,
			//          TypeInfo::UnityEngine::Mathf.static_fields.Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(value - *(float *)&v9) & v10) )
			//     UnityEngine::Light::set_softSourceRadius(light, value, 0LL);
			// }
			// 
		}

		public static void SetLensFlareComponentEnableIfNecessary(this LensFlareComponentSRP lensFlareComponent, bool value)
		{
			// // Void SetLensFlareComponentEnableIfNecessary(LensFlareComponentSRP, Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGEnvironmentUtils::SetLensFlareComponentEnableIfNecessary(
			//         LensFlareComponentSRP *lensFlareComponent,
			//         bool value,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   unsigned __int8 (__fastcall *v7)(LensFlareComponentSRP *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, value);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size <= 609 )
			//     goto LABEL_7;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			// LABEL_11:
			//     sub_180B536AC(v5, wrapperArray);
			//   if ( LODWORD(v5._0.namespaze) <= 0x261 )
			//     sub_180070270(v5, wrapperArray);
			//   if ( v5[13]._0.name )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(609, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(
			//         (ILFixDynamicMethodWrapper_28 *)Patch,
			//         (Object *)lensFlareComponent,
			//         value,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_11;
			//   }
			// LABEL_7:
			//   if ( !lensFlareComponent )
			//     goto LABEL_11;
			//   v7 = (unsigned __int8 (__fastcall *)(LensFlareComponentSRP *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18D8F4D28;
			//   if ( !qword_18D8F4D28 )
			//   {
			//     v7 = (unsigned __int8 (__fastcall *)(LensFlareComponentSRP *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Behaviour::get_enabled()");
			//     if ( !v7 )
			//     {
			//       v9 = sub_1802DBBE8("UnityEngine.Behaviour::get_enabled()");
			//       sub_18000F750(v9, 0LL);
			//     }
			//     qword_18D8F4D28 = (__int64)v7;
			//   }
			//   if ( v7(lensFlareComponent, wrapperArray, method) != value )
			//     UnityEngine::Behaviour::set_enabled((Behaviour *)lensFlareComponent, value, 0LL);
			// }
			// 
		}

		public static void SetLensFlareDataIfNecessary(this LensFlareComponentSRP lensFlareComponent, LensFlareDataSRP value)
		{
			// // Void SetLensFlareDataIfNecessary(LensFlareComponentSRP, LensFlareDataSRP)
			// void HG::Rendering::Runtime::HGEnvironmentUtils::SetLensFlareDataIfNecessary(
			//         LensFlareComponentSRP *lensFlareComponent,
			//         LensFlareDataSRP *value,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Object_1 *m_LensFlareData; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919D71 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919D71 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(610, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(610, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)lensFlareComponent,
			//         (Object *)value,
			//         0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !lensFlareComponent )
			//     goto LABEL_8;
			//   m_LensFlareData = (Object_1 *)lensFlareComponent.fields.m_LensFlareData;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Equality(m_LensFlareData, (Object_1 *)value, 0LL) )
			//     UnityEngine::Rendering::LensFlareComponentSRP::set_lensFlareData(lensFlareComponent, value, 0LL);
			// }
			// 
		}

		[CompilerGenerated]
		internal static int <Subdivide>g__GetMiddleVertex|17_0(int index1, int index2, ref HGEnvironmentUtils.<>c__DisplayClass17_0 param_00045f29)
		{
			// // Int32 <Subdivide>g__GetMiddleVertex|17_0(Int32, Int32, HGEnvironmentUtils+<>c__DisplayClass17_0 ByRef)
			// int32_t HG::Rendering::Runtime::HGEnvironmentUtils::_Subdivide_g__GetMiddleVertex_17_0(
			//         int32_t index1,
			//         int32_t index2,
			//         HGEnvironmentUtils_c_DisplayClass17_0 *param_00045f29,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rsi
			//   __int64 v6; // rdi
			//   int v7; // eax
			//   __int64 v8; // rax
			//   __int64 v9; // r8
			//   int v10; // ecx
			//   Object *v11; // rbx
			//   Object *v12; // rax
			//   Object *v13; // rax
			//   __int64 v14; // rdx
			//   Object *v15; // rbx
			//   __int64 v16; // rdx
			//   MethodInfo *v17; // r9
			//   Dictionary_2_System_Object_System_Int32_ *oldVerts; // rcx
			//   float v19; // eax
			//   __int64 v20; // xmm0_8
			//   float v21; // eax
			//   Vector3 *v22; // rax
			//   __m128 v23; // xmm2
			//   __m128 v24; // xmm1
			//   float v25; // xmm3_4
			//   List_1_UnityEngine_Vector3_ *newVerts; // rdi
			//   int32_t size; // edi
			//   Vector3 v29; // [rsp+20h] [rbp-48h] BYREF
			//   Vector3 v30; // [rsp+30h] [rbp-38h] BYREF
			//   Vector3 v31[3]; // [rsp+40h] [rbp-28h] BYREF
			//   __int64 v32; // [rsp+70h] [rbp+8h] BYREF
			//   __int64 v33; // [rsp+78h] [rbp+10h] BYREF
			// 
			//   v5 = index2;
			//   v6 = index1;
			//   if ( !byte_18D8EDC4D )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::set_Item);
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Count);
			//     sub_18003C530(&off_18C95E8F8);
			//     byte_18D8EDC4D = 1;
			//   }
			//   v7 = v6;
			//   if ( (int)v6 >= (int)v5 )
			//     v7 = v5;
			//   LODWORD(v32) = v7;
			//   v8 = il2cpp_value_box(TypeInfo::System::Int32, &v32, param_00045f29);
			//   v10 = v6;
			//   v11 = (Object *)v8;
			//   if ( (int)v6 <= (int)v5 )
			//     v10 = v5;
			//   LODWORD(v33) = v10;
			//   v12 = (Object *)il2cpp_value_box(TypeInfo::System::Int32, &v33, v9);
			//   v13 = (Object *)System::String::Format((String *)"{0}_{1}", v11, v12, 0LL);
			//   v15 = v13;
			//   if ( !param_00045f29.newVertIndices )
			//     sub_180B536AC(0LL, v14);
			//   if ( !System::Collections::Generic::Dictionary<System::Object,int>::ContainsKey(
			//           (Dictionary_2_System_Object_System_Int32_ *)param_00045f29.newVertIndices,
			//           v13,
			//           MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::ContainsKey) )
			//   {
			//     oldVerts = (Dictionary_2_System_Object_System_Int32_ *)param_00045f29.oldVerts;
			//     if ( oldVerts )
			//     {
			//       if ( (unsigned int)v6 >= LODWORD(oldVerts.fields._entries)
			//         || (unsigned int)v5 >= LODWORD(oldVerts.fields._entries) )
			//       {
			//         sub_180070270(oldVerts, v16);
			//       }
			//       v19 = *((float *)&oldVerts.fields._freeCount + 3 * v5);
			//       *(_QWORD *)&v29.x = *(_QWORD *)(&oldVerts.fields._count + 3 * v5);
			//       v20 = *(_QWORD *)(&oldVerts.fields._count + 3 * v6);
			//       v29.z = v19;
			//       v21 = *((float *)&oldVerts.fields._freeCount + 3 * v6);
			//       *(_QWORD *)&v30.x = v20;
			//       v30.z = v21;
			//       v22 = UnityEngine::Vector3::op_Addition(v31, &v30, &v29, v17);
			//       *(_QWORD *)&v30.x = *(_QWORD *)&v22.x;
			//       v23 = (__m128)*(unsigned __int64 *)&v30.x;
			//       v24 = _mm_shuffle_ps(v23, v23, 85);
			//       v24.m128_f32[0] = v24.m128_f32[0] * 0.5;
			//       v25 = v22.z * 0.5;
			//       oldVerts = (Dictionary_2_System_Object_System_Int32_ *)param_00045f29.newVerts;
			//       if ( oldVerts )
			//       {
			//         v23.m128_f32[0] = v30.x * 0.5;
			//         *(_QWORD *)&v30.x = _mm_unpacklo_ps(v23, v24).m128_u64[0];
			//         v30.z = v25;
			//         sub_18234A170(oldVerts, &v30, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
			//         newVerts = param_00045f29.newVerts;
			//         if ( newVerts )
			//         {
			//           oldVerts = (Dictionary_2_System_Object_System_Int32_ *)param_00045f29.newVertIndices;
			//           size = newVerts.fields._size;
			//           if ( param_00045f29.newVertIndices )
			//           {
			//             System::Collections::Generic::Dictionary<System::Object,int>::set_Item(
			//               oldVerts,
			//               v15,
			//               size - 1,
			//               MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::set_Item);
			//             return size - 1;
			//           }
			//         }
			//       }
			//     }
			// LABEL_18:
			//     sub_180B536AC(oldVerts, v16);
			//   }
			//   oldVerts = (Dictionary_2_System_Object_System_Int32_ *)param_00045f29.newVertIndices;
			//   if ( !param_00045f29.newVertIndices )
			//     goto LABEL_18;
			//   return System::Collections::Generic::Dictionary<System::Object,int>::get_Item(
			//            oldVerts,
			//            v15,
			//            MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::get_Item);
			// }
			// 
			return 0;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static Mesh s_skydomeStarMesh;
	}
}
