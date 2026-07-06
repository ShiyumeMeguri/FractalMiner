using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public static class HGCircularTreeUtils
	{
		public static Circle MakeCircle(IList<Vector2> points)
		{
			// // Circle MakeCircle(IList`1[UnityEngine.Vector2])
			// Circle_1 *HG::Rendering::Runtime::HGCircularTreeUtils::MakeCircle(
			//         Circle_1 *__return_ptr retstr,
			//         IList_1_UnityEngine_Vector2_ *points,
			//         MethodInfo *method)
			// {
			//   List_1_UnityEngine_Vector2_ *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   List_1_UnityEngine_Vector2_ *v8; // rsi
			//   int32_t size; // ebp
			//   Random *v10; // rax
			//   Random *v11; // r15
			//   int32_t i; // r14d
			//   int32_t v13; // ebx
			//   Vector2 Item; // xmm6_8
			//   Vector2 v15; // xmm7_8
			//   int32_t v16; // ebx
			//   Circle_1__StaticFields *static_fields; // rcx
			//   Vector2 center; // xmm0_8
			//   float radius; // eax
			//   Vector2 v20; // xmm6_8
			//   List_1_UnityEngine_Vector2_ *Range; // rax
			//   Circle_1 *CircleOnePoint; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Circle_1 *v24; // rax
			//   Circle_1 v26; // [rsp+20h] [rbp-58h] BYREF
			//   Circle_1 v27; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D919444 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Circle);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::GetRange);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::set_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector2>);
			//     sub_18003C530(&TypeInfo::System::Random);
			//     byte_18D919444 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2181, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2181, 0LL);
			//     if ( Patch )
			//     {
			//       v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_800(&v27, Patch, (Object *)points, 0LL);
			//       center = v24.center;
			//       radius = v24.radius;
			//       goto LABEL_19;
			//     }
			// LABEL_17:
			//     sub_180B536AC(v7, v6);
			//   }
			//   v5 = (List_1_UnityEngine_Vector2_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector2>);
			//   v8 = v5;
			//   if ( !v5 )
			//     goto LABEL_17;
			//   System::Collections::Generic::List<UnityEngine::Vector2>::List(
			//     v5,
			//     (IEnumerable_1_UnityEngine_Vector2_ *)points,
			//     MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::List);
			//   size = v8.fields._size;
			//   v10 = (Random *)sub_180004920(TypeInfo::System::Random);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_17;
			//   System::Random::Random(v10, 0, 0LL);
			//   for ( i = size - 1; i > 0; --i )
			//   {
			//     v13 = System::Random::Next(v11, i + 1, 0LL);
			//     Item = System::Collections::Generic::List<UnityEngine::Vector2>::get_Item(
			//              v8,
			//              v13,
			//              MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::get_Item);
			//     v15 = System::Collections::Generic::List<UnityEngine::Vector2>::get_Item(
			//             v8,
			//             i,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::get_Item);
			//     System::Collections::Generic::List<Beyond::Gameplay::View::Animation::EnemyAnimExtraData::EnemyHurtShakeIntensityConfig>::set_Item(
			//       (List_1_Beyond_Gameplay_View_Animation_EnemyAnimExtraData_EnemyHurtShakeIntensityConfig_ *)v8,
			//       i,
			//       (EnemyAnimExtraData_EnemyHurtShakeIntensityConfig)Item,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::set_Item);
			//     System::Collections::Generic::List<Beyond::Gameplay::View::Animation::EnemyAnimExtraData::EnemyHurtShakeIntensityConfig>::set_Item(
			//       (List_1_Beyond_Gameplay_View_Animation_EnemyAnimExtraData_EnemyHurtShakeIntensityConfig_ *)v8,
			//       v13,
			//       (EnemyAnimExtraData_EnemyHurtShakeIntensityConfig)v15,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::set_Item);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::Circle);
			//   v16 = 0;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::Circle.static_fields;
			//   center = static_fields.INVALID.center;
			//   radius = static_fields.INVALID.radius;
			//   v26.center = static_fields.INVALID.center;
			//   for ( v26.radius = radius; v16 < size; ++v16 )
			//   {
			//     v20 = System::Collections::Generic::List<UnityEngine::Vector2>::get_Item(
			//             v8,
			//             v16,
			//             MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::get_Item);
			//     if ( v26.radius >= 0.0
			//       && (sub_180002C70(TypeInfo::HG::Rendering::Runtime::Circle),
			//           HG::Rendering::Runtime::Circle::Contains(&v26, v20, 0LL)) )
			//     {
			//       radius = v26.radius;
			//       center = v26.center;
			//     }
			//     else
			//     {
			//       Range = (List_1_UnityEngine_Vector2_ *)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::GetRange(
			//                                                (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)v8,
			//                                                0,
			//                                                v16 + 1,
			//                                                MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::GetRange);
			//       CircleOnePoint = HG::Rendering::Runtime::HGCircularTreeUtils::MakeCircleOnePoint(&v27, Range, v20, 0LL);
			//       center = CircleOnePoint.center;
			//       radius = CircleOnePoint.radius;
			//       v26.center = center;
			//       v26.radius = radius;
			//     }
			//   }
			// LABEL_19:
			//   retstr.center = center;
			//   retstr.radius = radius;
			//   return retstr;
			// }
			// 
			return null;
		}

		private static Circle MakeCircleOnePoint(List<Vector2> points, Vector2 p)
		{
			// // Circle MakeCircleOnePoint(List`1[UnityEngine.Vector2], Vector2)
			// Circle_1 *HG::Rendering::Runtime::HGCircularTreeUtils::MakeCircleOnePoint(
			//         Circle_1 *__return_ptr retstr,
			//         List_1_UnityEngine_Vector2_ *points,
			//         Vector2 p,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector2 center; // xmm0_8
			//   int32_t size; // r14d
			//   int32_t i; // edi
			//   Vector2 Item; // xmm7_8
			//   Circle_1 *Diameter; // rax
			//   List_1_UnityEngine_Vector2_ *Range; // rax
			//   float v15; // eax
			//   float radius; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Circle_1 *v18; // rax
			//   Circle_1 v20; // [rsp+30h] [rbp-50h] BYREF
			//   Circle_1 v21; // [rsp+40h] [rbp-40h] BYREF
			//   Circle_1 v22; // [rsp+50h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D919445 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Circle);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::GetRange);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::get_Item);
			//     byte_18D919445 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2182, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2182, 0LL);
			//     if ( Patch )
			//     {
			//       v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_799(&v22, Patch, (Object *)points, p, 0LL);
			//       center = v18.center;
			//       radius = v18.radius;
			//       goto LABEL_17;
			//     }
			// LABEL_15:
			//     sub_180B536AC(v8, v7);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::Circle);
			//   v20.radius = 0.0;
			//   center = p;
			//   v20.center = p;
			//   if ( !points )
			//     goto LABEL_15;
			//   size = points.fields._size;
			//   for ( i = 0; i < size; ++i )
			//   {
			//     Item = System::Collections::Generic::List<UnityEngine::Vector2>::get_Item(
			//              points,
			//              i,
			//              MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::get_Item);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::Circle);
			//     if ( HG::Rendering::Runtime::Circle::Contains(&v20, Item, 0LL) )
			//     {
			//       center = v20.center;
			//     }
			//     else
			//     {
			//       if ( v20.radius == 0.0 )
			//       {
			//         Diameter = HG::Rendering::Runtime::HGCircularTreeUtils::MakeDiameter(&v21, p, Item, 0LL);
			//       }
			//       else
			//       {
			//         Range = (List_1_UnityEngine_Vector2_ *)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::GetRange(
			//                                                  (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)points,
			//                                                  0,
			//                                                  i + 1,
			//                                                  MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::GetRange);
			//         Diameter = HG::Rendering::Runtime::HGCircularTreeUtils::MakeCircleTwoPoints(&v22, Range, p, Item, 0LL);
			//       }
			//       center = Diameter.center;
			//       v15 = Diameter.radius;
			//       v20.center = center;
			//       v20.radius = v15;
			//     }
			//   }
			//   radius = v20.radius;
			// LABEL_17:
			//   retstr.center = center;
			//   retstr.radius = radius;
			//   return retstr;
			// }
			// 
			return null;
		}

		private static Circle MakeCircleTwoPoints(List<Vector2> points, Vector2 p, Vector2 q)
		{
			// // Circle MakeCircleTwoPoints(List`1[UnityEngine.Vector2], Vector2, Vector2)
			// Circle_1 *HG::Rendering::Runtime::HGCircularTreeUtils::MakeCircleTwoPoints(
			//         Circle_1 *__return_ptr retstr,
			//         List_1_UnityEngine_Vector2_ *points,
			//         Vector2 p,
			//         Vector2 q,
			//         MethodInfo *method)
			// {
			//   Circle_1 *Diameter; // rax
			//   Vector2 v10; // xmm6_8
			//   float radius; // esi
			//   Circle_1__StaticFields *static_fields; // rax
			//   Vector2 v13; // xmm2_8
			//   float v14; // r8d
			//   Vector2 v15; // xmm3_8
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   float v18; // r8d
			//   float v19; // r9d
			//   Vector2 v20; // xmm11_8
			//   int32_t size; // r15d
			//   int32_t v22; // edi
			//   __m128i v23; // xmm9
			//   __m128i v24; // xmm7
			//   __m128 v25; // xmm15
			//   __m128 v26; // xmm14
			//   Vector2 Item; // xmm6_8
			//   Circle_1 *Circumcircle; // rax
			//   __m128i radius_low; // xmm0
			//   __m128 y_low; // xmm12
			//   __m128 x_low; // xmm11
			//   float v32; // xmm6_4
			//   float v33; // xmm6_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Circle_1 *v35; // rax
			//   Vector2 center; // xmm0_8
			//   float v38; // [rsp+38h] [rbp-D0h]
			//   Vector2 a; // [rsp+40h] [rbp-C8h]
			//   Vector2 b; // [rsp+48h] [rbp-C0h] BYREF
			//   unsigned __int64 v41; // [rsp+50h] [rbp-B8h]
			//   __int64 v42; // [rsp+58h] [rbp-B0h]
			//   unsigned __int64 v43; // [rsp+60h] [rbp-A8h]
			//   __int64 v44; // [rsp+68h] [rbp-A0h]
			//   Circle_1 v45; // [rsp+70h] [rbp-98h] BYREF
			//   Circle_1 v46; // [rsp+80h] [rbp-88h] BYREF
			//   Circle_1 v47[15]; // [rsp+90h] [rbp-78h] BYREF
			//   float v48; // [rsp+168h] [rbp+60h]
			// 
			//   if ( !byte_18D919446 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Circle);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::get_Item);
			//     byte_18D919446 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2184, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2184, 0LL);
			//     if ( Patch )
			//     {
			//       v35 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_798(v47, Patch, (Object *)points, p, q, 0LL);
			//       center = v35.center;
			//       *(float *)&v35 = v35.radius;
			//       retstr.center = center;
			//       LODWORD(retstr.radius) = (_DWORD)v35;
			//       return retstr;
			//     }
			// LABEL_30:
			//     sub_180B536AC(v17, v16);
			//   }
			//   Diameter = HG::Rendering::Runtime::HGCircularTreeUtils::MakeDiameter(&v46, p, q, 0LL);
			//   v10 = Diameter.center;
			//   radius = Diameter.radius;
			//   v45.center = Diameter.center;
			//   v45.radius = radius;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::Circle);
			//   static_fields = TypeInfo::HG::Rendering::Runtime::Circle.static_fields;
			//   v13 = static_fields.INVALID.center;
			//   v14 = static_fields.INVALID.radius;
			//   v15 = v13;
			//   v41 = (unsigned __int64)static_fields.INVALID.center;
			//   v43 = (unsigned __int64)v13;
			//   *(float *)&v42 = v14;
			//   *(float *)&v44 = v14;
			//   v20 = (Vector2)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_18473B264)(q, p);
			//   a = v20;
			//   if ( !points )
			//     goto LABEL_30;
			//   size = points.fields._size;
			//   v22 = 0;
			//   if ( size > 0 )
			//   {
			//     v23 = (__m128i)(unsigned int)v42;
			//     v24 = (__m128i)(unsigned int)v44;
			//     v25 = (__m128)HIDWORD(v43);
			//     v26 = (__m128)(unsigned int)v43;
			//     while ( 1 )
			//     {
			//       Item = System::Collections::Generic::List<UnityEngine::Vector2>::get_Item(
			//                points,
			//                v22,
			//                MethodInfo::System::Collections::Generic::List<UnityEngine::Vector2>::get_Item);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::Circle);
			//       if ( HG::Rendering::Runtime::Circle::Contains(&v45, Item, 0LL) )
			//         goto LABEL_19;
			//       b = (Vector2)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_18473B264)(Item, p);
			//       v48 = HG::Rendering::Runtime::HGCircularTreeUtils::Cross(v20, &b, 0LL);
			//       Circumcircle = HG::Rendering::Runtime::HGCircularTreeUtils::MakeCircumcircle(v47, p, q, Item, 0LL);
			//       radius_low = (__m128i)LODWORD(Circumcircle.radius);
			//       v38 = Circumcircle.radius;
			//       v46.center = Circumcircle.center;
			//       if ( *(float *)radius_low.m128i_i32 < 0.0 )
			//         goto LABEL_19;
			//       y_low = (__m128)LODWORD(v46.center.y);
			//       x_low = (__m128)LODWORD(v46.center.x);
			//       if ( v48 <= 0.0 )
			//         break;
			//       if ( *(float *)v23.m128i_i32 >= 0.0 )
			//       {
			//         b = (Vector2)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_18473B264)(
			//                        _mm_unpacklo_ps((__m128)LODWORD(v46.center.x), (__m128)LODWORD(v46.center.y)).m128_u64[0],
			//                        p);
			//         v32 = HG::Rendering::Runtime::HGCircularTreeUtils::Cross(a, &b, 0LL);
			//         b = (Vector2)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_18473B264)(
			//                        _mm_unpacklo_ps((__m128)(unsigned int)v41, (__m128)HIDWORD(v41)).m128_u64[0],
			//                        p);
			//         if ( v32 <= HG::Rendering::Runtime::HGCircularTreeUtils::Cross(a, &b, 0LL) )
			//           break;
			//         radius_low = (__m128i)LODWORD(v38);
			//       }
			//       v41 = __PAIR64__(y_low.m128_u32[0], x_low.m128_u32[0]);
			//       v23 = radius_low;
			// LABEL_18:
			//       v20 = a;
			// LABEL_19:
			//       if ( ++v22 >= size )
			//       {
			//         radius = v45.radius;
			//         v10 = v45.center;
			//         v13 = (Vector2)v41;
			//         v43 = __PAIR64__(v25.m128_u32[0], v26.m128_u32[0]);
			//         v15 = (Vector2)__PAIR64__(v25.m128_u32[0], v26.m128_u32[0]);
			//         v18 = COERCE_FLOAT(_mm_cvtsi128_si32(v23));
			//         v19 = COERCE_FLOAT(_mm_cvtsi128_si32(v24));
			//         goto LABEL_22;
			//       }
			//     }
			//     if ( v48 < 0.0 )
			//     {
			//       if ( *(float *)v24.m128i_i32 < 0.0
			//         || (b = (Vector2)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_18473B264)(
			//                            _mm_unpacklo_ps(x_low, y_low).m128_u64[0],
			//                            p),
			//             v33 = HG::Rendering::Runtime::HGCircularTreeUtils::Cross(a, &b, 0LL),
			//             b = (Vector2)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_18473B264)(
			//                            _mm_unpacklo_ps(v26, v25).m128_u64[0],
			//                            p),
			//             HG::Rendering::Runtime::HGCircularTreeUtils::Cross(a, &b, 0LL) > v33) )
			//       {
			//         v24 = (__m128i)LODWORD(v38);
			//         v26 = x_low;
			//         v25 = y_low;
			//       }
			//     }
			//     goto LABEL_18;
			//   }
			//   *(float *)v23.m128i_i32 = v18;
			//   *(float *)v24.m128i_i32 = v18;
			// LABEL_22:
			//   if ( *(float *)v23.m128i_i32 >= 0.0 )
			//   {
			//     if ( *(float *)v24.m128i_i32 < 0.0 || *(float *)v24.m128i_i32 >= *(float *)v23.m128i_i32 )
			//     {
			//       retstr.center = v13;
			//       retstr.radius = v18;
			//       return retstr;
			//     }
			// LABEL_28:
			//     retstr.center = v15;
			//     retstr.radius = v19;
			//     return retstr;
			//   }
			//   if ( *(float *)v24.m128i_i32 >= 0.0 )
			//     goto LABEL_28;
			//   retstr.center = v10;
			//   retstr.radius = radius;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Circle MakeDiameter(Vector2 a, Vector2 b)
		{
			// // Circle MakeDiameter(Vector2, Vector2)
			// Circle_1 *HG::Rendering::Runtime::HGCircularTreeUtils::MakeDiameter(
			//         Circle_1 *__return_ptr retstr,
			//         Vector2 a,
			//         Vector2 b,
			//         MethodInfo *method)
			// {
			//   __m128 x_low; // xmm8
			//   __m128 y_low; // xmm7
			//   double v9; // xmm0_8
			//   float v10; // xmm6_4
			//   double v11; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   Circle_1 *v15; // rax
			//   Vector2 center; // xmm0_8
			//   Circle_1 v20[4]; // [rsp+40h] [rbp-58h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2183, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2183, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     v15 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_795(v20, Patch, a, b, 0LL);
			//     center = v15.center;
			//     *(float *)&v15 = v15.radius;
			//     retstr.center = center;
			//     LODWORD(retstr.radius) = (_DWORD)v15;
			//   }
			//   else
			//   {
			//     x_low = (__m128)LODWORD(b.x);
			//     y_low = (__m128)LODWORD(b.y);
			//     x_low.m128_f32[0] = (float)(b.x + a.x) * 0.5;
			//     y_low.m128_f32[0] = (float)(b.y + a.y) * 0.5;
			//     v9 = sub_1829FB920(_mm_unpacklo_ps(x_low, y_low).m128_u64[0], a);
			//     v10 = *(float *)&v9;
			//     v11 = sub_1829FB920(_mm_unpacklo_ps(x_low, y_low).m128_u64[0], b);
			//     LODWORD(retstr.center.x) = x_low.m128_i32[0];
			//     LODWORD(retstr.center.y) = y_low.m128_i32[0];
			//     retstr.radius = fmaxf(v10, *(float *)&v11);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Circle MakeCircumcircle(Vector2 a, Vector2 b, Vector2 c)
		{
			// // Circle MakeCircumcircle(Vector2, Vector2, Vector2)
			// Circle_1 *HG::Rendering::Runtime::HGCircularTreeUtils::MakeCircumcircle(
			//         Circle_1 *__return_ptr retstr,
			//         Vector2 a,
			//         Vector2 b,
			//         Vector2 c,
			//         MethodInfo *method)
			// {
			//   float v9; // xmm5_4
			//   float v10; // xmm13_4
			//   float v11; // xmm11_4
			//   float v12; // xmm12_4
			//   float v13; // xmm6_4
			//   __m128 y_low; // xmm8
			//   float v15; // xmm10_4
			//   float v16; // xmm9_4
			//   float v17; // xmm4_4
			//   float v18; // xmm4_4
			//   Circle_1__StaticFields *static_fields; // rax
			//   __m128 v20; // xmm7
			//   float v21; // xmm1_4
			//   float v22; // xmm10_4
			//   double v23; // xmm0_8
			//   float v24; // xmm6_4
			//   double v25; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   Vector2 center; // xmm0_8
			//   float radius; // eax
			//   Circle_1 v35[2]; // [rsp+48h] [rbp-C0h] BYREF
			// 
			//   if ( !byte_18D919447 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Circle);
			//     byte_18D919447 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2186, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2186, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v28, v27);
			//     static_fields = (Circle_1__StaticFields *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_797(v35, Patch, a, b, c, 0LL);
			//     goto LABEL_10;
			//   }
			//   v9 = (float)(fminf(fminf(a.x, b.x), c.x) + fmaxf(fmaxf(a.x, b.x), c.x)) * 0.5;
			//   v10 = a.x - v9;
			//   y_low = (__m128)LODWORD(b.y);
			//   v11 = b.x - v9;
			//   v12 = c.x - v9;
			//   v13 = (float)(fminf(fminf(a.y, b.y), c.y) + fmaxf(fmaxf(a.y, b.y), c.y)) * 0.5;
			//   y_low.m128_f32[0] = b.y - v13;
			//   v15 = c.y - v13;
			//   v16 = a.y - v13;
			//   v17 = (float)((float)((float)((float)(b.y - v13) - (float)(c.y - v13)) * (float)(a.x - v9))
			//               + (float)((float)((float)(c.y - v13) - (float)(a.y - v13)) * (float)(b.x - v9)))
			//       + (float)((float)((float)(a.y - v13) - (float)(b.y - v13)) * (float)(c.x - v9));
			//   v18 = v17 + v17;
			//   if ( v18 == 0.0 )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::Circle);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::Circle.static_fields;
			// LABEL_10:
			//     center = static_fields.INVALID.center;
			//     radius = static_fields.INVALID.radius;
			//     retstr.center = center;
			//     retstr.radius = radius;
			//     return retstr;
			//   }
			//   v20 = y_low;
			//   v20.m128_f32[0] = (float)((float)(y_low.m128_f32[0] * y_low.m128_f32[0]) + (float)(v11 * v11)) * (float)(v15 - v16);
			//   v21 = y_low.m128_f32[0] - v15;
			//   v22 = v15 * v15;
			//   v20.m128_f32[0] = (float)((float)((float)(v20.m128_f32[0]
			//                                           + (float)((float)((float)(v16 * v16) + (float)(v10 * v10)) * v21))
			//                                   + (float)((float)(v22 + (float)(v12 * v12)) * (float)(v16 - y_low.m128_f32[0])))
			//                           / v18)
			//                   + v9;
			//   y_low.m128_f32[0] = (float)((float)((float)((float)((float)((float)(y_low.m128_f32[0] * y_low.m128_f32[0])
			//                                                             + (float)(v11 * v11))
			//                                                     * (float)(v10 - v12))
			//                                             + (float)((float)((float)(v16 * v16) + (float)(v10 * v10))
			//                                                     * (float)(v12 - v11)))
			//                                     + (float)((float)(v22 + (float)(v12 * v12)) * (float)(v11 - v10)))
			//                             / v18)
			//                     + v13;
			//   v23 = sub_1829FB920(_mm_unpacklo_ps(v20, y_low).m128_u64[0], a);
			//   v24 = fmaxf(
			//           *(float *)&v23,
			//           COERCE_FLOAT(COERCE_UNSIGNED_INT64(sub_1829FB920(_mm_unpacklo_ps(v20, y_low).m128_u64[0], b))));
			//   v25 = sub_1829FB920(_mm_unpacklo_ps(v20, y_low).m128_u64[0], c);
			//   LODWORD(retstr.center.x) = v20.m128_i32[0];
			//   LODWORD(retstr.center.y) = y_low.m128_i32[0];
			//   retstr.radius = fmaxf(v24, *(float *)&v25);
			//   return retstr;
			// }
			// 
			return null;
		}

		public static float Cross(this Vector2 a, in Vector2 b)
		{
			// // Single Cross(Vector2, Vector2 ByRef)
			// float HG::Rendering::Runtime::HGCircularTreeUtils::Cross(Vector2 a, Vector2 *b, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2185, 0LL) )
			//     return (float)(a.x * b.y) - (float)(a.y * b.x);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2185, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_796(Patch, a, b, 0LL);
			// }
			// 
			return 0f;
		}
	}
}
