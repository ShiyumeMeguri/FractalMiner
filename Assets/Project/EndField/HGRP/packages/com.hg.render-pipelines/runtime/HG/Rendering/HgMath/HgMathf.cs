using System;
using UnityEngine;

namespace HG.Rendering.HgMath
{
	public static class HgMathf
	{
		internal static float TriangleSign2D(Vector2 p1, Vector2 p2, Vector2 p3)
		{
			// // Single TriangleSign2D(Vector2, Vector2, Vector2)
			// float HG::Rendering::HgMath::HgMathf::TriangleSign2D(Vector2 p1, Vector2 p2, Vector2 p3, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(335, 0LL) )
			//     return (float)((float)(p2.y - p3.y) * (float)(p1.x - p3.x)) - (float)((float)(p1.y - p3.y) * (float)(p2.x - p3.x));
			//   Patch = IFix::WrappersManagerImpl::GetPatch(335, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v10, v9);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_151(Patch, p1, p2, p3, 0LL);
			// }
			// 
			return 0f;
		}

		public static bool PointTriangleContainTest2D(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 point)
		{
			// // Boolean PointTriangleContainTest2D(Vector2, Vector2, Vector2, Vector2)
			// bool HG::Rendering::HgMath::HgMathf::PointTriangleContainTest2D(
			//         Vector2 p0,
			//         Vector2 p1,
			//         Vector2 p2,
			//         Vector2 point,
			//         MethodInfo *method)
			// {
			//   bool v9; // bl
			//   float v10; // xmm10_4
			//   float v11; // xmm6_4
			//   float v12; // xmm0_4
			//   bool v13; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			// 
			//   v9 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(336, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(336, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_152(Patch, p0, p1, p2, point, 0LL);
			//   }
			//   else
			//   {
			//     v10 = HG::Rendering::HgMath::HgMathf::TriangleSign2D(point, p0, p1, 0LL);
			//     v11 = HG::Rendering::HgMath::HgMathf::TriangleSign2D(point, p1, p2, 0LL);
			//     v12 = HG::Rendering::HgMath::HgMathf::TriangleSign2D(point, p2, p0, 0LL);
			//     v13 = v10 >= 0.0 && v11 >= 0.0 && v12 >= 0.0;
			//     if ( v10 <= 0.0 && v11 <= 0.0 )
			//       v9 = v12 <= 0.0;
			//     return v9 || v13;
			//   }
			// }
			// 
			return default(bool);
		}

		public static Vector2 LineLineIntersectPoint2D(Vector2 l00, Vector2 l01, Vector2 l10, Vector2 l11)
		{
			// // Vector2 LineLineIntersectPoint2D(Vector2, Vector2, Vector2, Vector2)
			// Vector2 HG::Rendering::HgMath::HgMathf::LineLineIntersectPoint2D(
			//         Vector2 l00,
			//         Vector2 l01,
			//         Vector2 l10,
			//         Vector2 l11,
			//         MethodInfo *method)
			// {
			//   __m128 x_low; // xmm6
			//   __m128 v10; // xmm2
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(337, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(337, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_153(Patch, l00, l01, l10, l11, 0LL);
			//   }
			//   else
			//   {
			//     x_low = (__m128)LODWORD(l00.x);
			//     x_low.m128_f32[0] = l00.x - l10.x;
			//     v10 = x_low;
			//     v10.m128_f32[0] = (float)((float)((float)(l00.x - l10.x) * (float)(l10.y - l11.y))
			//                             - (float)((float)(l10.x - l11.x) * (float)(l00.y - l10.y)))
			//                     / (float)((float)((float)(l00.x - l01.x) * (float)(l10.y - l11.y))
			//                             - (float)((float)(l00.y - l01.y) * (float)(l10.x - l11.x)));
			//     x_low.m128_f32[0] = (float)((float)((float)(l00.x - l10.x) * (float)(l00.y - l01.y))
			//                               - (float)((float)(l00.x - l01.x) * (float)(l00.y - l10.y)))
			//                       / (float)((float)((float)(l00.x - l01.x) * (float)(l10.y - l11.y))
			//                               - (float)((float)(l00.y - l01.y) * (float)(l10.x - l11.x)));
			//     return (Vector2)_mm_unpacklo_ps(v10, x_low).m128_u64[0];
			//   }
			// }
			// 
			return null;
		}

		public static bool LineLineIntersect2D(Vector2 l00, Vector2 l01, Vector2 l10, Vector2 l11)
		{
			// // Boolean LineLineIntersect2D(Vector2, Vector2, Vector2, Vector2)
			// bool HG::Rendering::HgMath::HgMathf::LineLineIntersect2D(
			//         Vector2 l00,
			//         Vector2 l01,
			//         Vector2 l10,
			//         Vector2 l11,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   Vector2 v13; // [rsp+30h] [rbp-58h]
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(338, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(338, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_152(Patch, l00, l01, l10, l11, 0LL);
			//   }
			//   else
			//   {
			//     v13 = HG::Rendering::HgMath::HgMathf::LineLineIntersectPoint2D(l00, l01, l10, l11, 0LL);
			//     return v13.x >= 0.0 && v13.x <= 1.0 && v13.y >= 0.0 && v13.y <= 1.0;
			//   }
			// }
			// 
			return default(bool);
		}

		public static bool LineSegmentTriangleIntersect2D(Vector2 lp0, Vector2 lp1, Vector2 tp0, Vector2 tp1, Vector2 tp2)
		{
			// // Boolean LineSegmentTriangleIntersect2D(Vector2, Vector2, Vector2, Vector2, Vector2)
			// bool HG::Rendering::HgMath::HgMathf::LineSegmentTriangleIntersect2D(
			//         Vector2 lp0,
			//         Vector2 lp1,
			//         Vector2 tp0,
			//         Vector2 tp1,
			//         Vector2 tp2,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(339, 0LL) )
			//     return HG::Rendering::HgMath::HgMathf::LineLineIntersect2D(lp0, lp1, tp0, tp1, 0LL)
			//         || HG::Rendering::HgMath::HgMathf::LineLineIntersect2D(lp0, lp1, tp1, tp2, 0LL)
			//         || HG::Rendering::HgMath::HgMathf::LineLineIntersect2D(lp0, lp1, tp2, tp0, 0LL);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(339, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v13, v12);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_154(Patch, lp0, lp1, tp0, tp1, tp2, 0LL);
			// }
			// 
			return default(bool);
		}

		public static bool LineSegmentAABBIntersect(Vector3 lp0, Vector3 lp1, Vector3 center, float halfSize)
		{
			// // Boolean LineSegmentAABBIntersect(Vector3, Vector3, Vector3, Single)
			// bool HG::Rendering::HgMath::HgMathf::LineSegmentAABBIntersect(
			//         Vector3 *lp0,
			//         Vector3 *lp1,
			//         Vector3 *center,
			//         float halfSize,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v9; // rdx
			//   Vector3 *one; // rax
			//   __int64 v11; // xmm1_8
			//   MethodInfo *v12; // r9
			//   Vector3 *v13; // rax
			//   __int64 v14; // xmm1_8
			//   MethodInfo *v15; // r9
			//   MethodInfo *v16; // rdx
			//   Vector3 *v17; // rax
			//   float v18; // ecx
			//   MethodInfo *v19; // r9
			//   Vector3 *v20; // rax
			//   __int64 v21; // xmm0_8
			//   __int64 v22; // xmm1_8
			//   __int64 v23; // xmm0_8
			//   MethodInfo *v24; // r9
			//   Vector3 *v25; // rbx
			//   __m128 v26; // xmm6
			//   MethodInfo *v27; // r9
			//   Vector3 *v28; // rax
			//   __int64 v29; // xmm3_8
			//   float *v30; // r9
			//   __int64 v31; // xmm0_8
			//   __m128 v32; // xmm4
			//   float v33; // xmm5_4
			//   MethodInfo *v34; // r9
			//   Vector3 *v35; // rax
			//   __int64 v36; // xmm3_8
			//   MethodInfo *v37; // r9
			//   Vector3 *v38; // rax
			//   __int64 *v39; // r11
			//   __int64 v40; // xmm0_8
			//   float v41; // xmm5_4
			//   __int64 v42; // xmm3_8
			//   MethodInfo *v43; // r9
			//   Vector3 *v44; // rax
			//   __int64 v45; // xmm3_8
			//   MethodInfo *z_low; // r9
			//   float *v47; // r11
			//   __int64 v48; // xmm0_8
			//   Vector3 *v49; // rax
			//   __int64 v50; // xmm1_8
			//   MethodInfo *v51; // r9
			//   Vector3 *v52; // rax
			//   __int64 v53; // xmm3_8
			//   float v54; // edi
			//   float *v55; // r11
			//   __int64 v56; // xmm0_8
			//   MethodInfo *v57; // r9
			//   Vector3 *v58; // rax
			//   __int64 v59; // xmm1_8
			//   MethodInfo *v60; // r9
			//   Vector3 *v61; // rax
			//   __int64 v62; // xmm3_8
			//   float v63; // esi
			//   __int64 *v64; // r11
			//   __int64 v65; // xmm0_8
			//   MethodInfo *v66; // r9
			//   Vector3 *v67; // rax
			//   __int64 v68; // xmm1_8
			//   MethodInfo *v69; // r9
			//   Vector3 *v70; // rax
			//   __int64 v71; // xmm3_8
			//   float v72; // r14d
			//   float *v73; // r11
			//   __int64 v74; // xmm0_8
			//   MethodInfo *v75; // r9
			//   Vector3 *v76; // rax
			//   __int64 v77; // xmm1_8
			//   MethodInfo *v78; // r9
			//   Vector3 *v79; // rax
			//   float *v80; // r11
			//   __int64 v81; // xmm0_8
			//   __int64 v82; // xmm3_8
			//   float v83; // r15d
			//   float v84; // r10d
			//   float v85; // xmm6_4
			//   MethodInfo *v86; // r9
			//   Vector3 *v87; // rax
			//   __int64 v88; // xmm1_8
			//   MethodInfo *v89; // r9
			//   Vector3 *v90; // rax
			//   float *v91; // r11
			//   __int64 v92; // xmm0_8
			//   __int64 v93; // xmm3_8
			//   MethodInfo *v94; // r9
			//   float v95; // xmm9_4
			//   Vector3 *v96; // rax
			//   __int64 v97; // xmm1_8
			//   MethodInfo *v98; // r9
			//   float v99; // xmm7_4
			//   __int64 v101; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   __int64 v104; // xmm0_8
			//   float v105; // eax
			//   __int64 v106; // xmm0_8
			//   float v107; // eax
			//   Vector3 v108; // [rsp+38h] [rbp-D0h] BYREF
			//   Vector3 v109; // [rsp+48h] [rbp-C0h] BYREF
			//   Vector3 v110; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector3 v111; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector3 v112; // [rsp+78h] [rbp-90h] BYREF
			//   Vector3 v113; // [rsp+88h] [rbp-80h] BYREF
			//   Vector3 v114; // [rsp+98h] [rbp-70h] BYREF
			//   Vector3 v115; // [rsp+A8h] [rbp-60h] BYREF
			//   _QWORD val[2]; // [rsp+B8h] [rbp-50h]
			//   _QWORD v117[2]; // [rsp+C8h] [rbp-40h]
			//   Vector3 v118; // [rsp+D8h] [rbp-30h] BYREF
			//   Vector3 v119[6]; // [rsp+E8h] [rbp-20h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(340, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(340, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v101);
			//     z = center.z;
			//     *(_QWORD *)&v109.x = *(_QWORD *)&center.x;
			//     v104 = *(_QWORD *)&lp1.x;
			//     v109.z = z;
			//     v105 = lp1.z;
			//     *(_QWORD *)&v108.x = v104;
			//     v106 = *(_QWORD *)&lp0.x;
			//     v108.z = v105;
			//     v107 = lp0.z;
			//     *(_QWORD *)&v110.x = v106;
			//     v110.z = v107;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_156(Patch, &v110, &v108, &v109, halfSize, 0LL);
			//   }
			//   else
			//   {
			//     one = UnityEngine::Vector3::get_one(&v111, v9);
			//     v11 = *(_QWORD *)&one.x;
			//     *(float *)&one = one.z;
			//     *(_QWORD *)&v108.x = v11;
			//     LODWORD(v108.z) = (_DWORD)one;
			//     v13 = UnityEngine::Vector3::op_Multiply(&v111, halfSize, &v108, v12);
			//     *(_QWORD *)&v110.x = *(_QWORD *)&center.x;
			//     v14 = *(_QWORD *)&v13.x;
			//     v108.z = v13.z;
			//     v110.z = center.z;
			//     *(_QWORD *)&v108.x = v14;
			//     UnityEngine::Vector3::op_Subtraction(&v111, &v110, &v108, v15);
			//     v17 = UnityEngine::Vector3::get_one(&v114, v16);
			//     v18 = v17.z;
			//     *(_QWORD *)&v108.x = *(_QWORD *)&v17.x;
			//     v108.z = v18;
			//     v20 = UnityEngine::Vector3::op_Multiply(&v114, halfSize, &v108, v19);
			//     *(_QWORD *)&v113.x = *(_QWORD *)&center.x;
			//     v21 = *(_QWORD *)&lp0.x;
			//     v22 = *(_QWORD *)&v20.x;
			//     v112.z = v20.z;
			//     v113.z = center.z;
			//     *(float *)&v20 = lp0.z;
			//     *(_QWORD *)&v108.x = v21;
			//     v23 = *(_QWORD *)&lp1.x;
			//     LODWORD(v108.z) = (_DWORD)v20;
			//     v110.z = lp1.z;
			//     *(_QWORD *)&v112.x = v22;
			//     *(_QWORD *)&v110.x = v23;
			//     v25 = UnityEngine::Vector3::op_Subtraction(&v118, &v110, &v108, v24);
			//     *(_QWORD *)&v109.x = *(_QWORD *)&lp0.x;
			//     *(_QWORD *)&v108.x = *(_QWORD *)&v25.x;
			//     v109.z = lp0.z;
			//     v26 = (__m128)0x3F800000u;
			//     v26.m128_f32[0] = 1.0 / v108.x;
			//     v28 = UnityEngine::Vector3::op_Addition(&v114, &v113, &v112, v27);
			//     v29 = *(_QWORD *)&v28.x;
			//     *(float *)&v28 = v28.z;
			//     *(_QWORD *)&v108.x = *(_QWORD *)&lp0.x;
			//     v31 = *(_QWORD *)v30;
			//     LODWORD(v112.z) = (_DWORD)v28;
			//     v108.z = lp0.z;
			//     *(_QWORD *)&v112.x = v29;
			//     *(_QWORD *)&v110.x = v31;
			//     v110.z = v30[2];
			//     UnityEngine::Vector3::op_Subtraction(v119, &v110, &v108, (MethodInfo *)v30);
			//     v26.m128_u64[0] = _mm_unpacklo_ps(v26, v32).m128_u64[0];
			//     *(_QWORD *)&v108.x = v26.m128_u64[0];
			//     v108.z = v33;
			//     v35 = UnityEngine::Vector3::op_Subtraction(&v111, &v112, &v109, v34);
			//     v36 = *(_QWORD *)&v35.x;
			//     *(float *)&v35 = v35.z;
			//     *(_QWORD *)&v109.x = v36;
			//     LODWORD(v109.z) = (_DWORD)v35;
			//     v38 = UnityEngine::Vector3::Scale(&v111, &v109, &v108, v37);
			//     v40 = *v39;
			//     v109.z = v41;
			//     *(_QWORD *)&v109.x = v26.m128_u64[0];
			//     v42 = *(_QWORD *)&v38.x;
			//     LODWORD(v38) = *((_DWORD *)v39 + 2);
			//     *(_QWORD *)&v113.x = v42;
			//     LODWORD(v108.z) = (_DWORD)v38;
			//     *(_QWORD *)&v108.x = v40;
			//     v44 = UnityEngine::Vector3::Scale(&v111, &v108, &v109, v43);
			//     *(_QWORD *)&v109.x = *(_QWORD *)&v25.x;
			//     v45 = *(_QWORD *)&v44.x;
			//     z_low = (MethodInfo *)LODWORD(v44.z);
			//     v48 = *(_QWORD *)v47;
			//     v109.z = v25.z;
			//     v108.z = v47[2];
			//     *(_QWORD *)&v112.x = v45;
			//     *(_QWORD *)&v108.x = v48;
			//     v49 = UnityEngine::Vector3::op_Multiply(&v111, v113.x, &v109, z_low);
			//     v50 = *(_QWORD *)&v49.x;
			//     *(float *)&v49 = v49.z;
			//     *(_QWORD *)&v109.x = v50;
			//     LODWORD(v109.z) = (_DWORD)v49;
			//     v52 = UnityEngine::Vector3::op_Subtraction(&v111, &v109, &v108, v51);
			//     *(_QWORD *)&v109.x = *(_QWORD *)&v25.x;
			//     v53 = *(_QWORD *)&v52.x;
			//     v54 = v52.z;
			//     v56 = *(_QWORD *)v55;
			//     v109.z = v25.z;
			//     v108.z = v55[2];
			//     val[0] = v53;
			//     *(_QWORD *)&v108.x = v56;
			//     v58 = UnityEngine::Vector3::op_Multiply(&v111, v112.x, &v109, v57);
			//     v59 = *(_QWORD *)&v58.x;
			//     *(float *)&v58 = v58.z;
			//     *(_QWORD *)&v109.x = v59;
			//     LODWORD(v109.z) = (_DWORD)v58;
			//     v61 = UnityEngine::Vector3::op_Subtraction(&v111, &v109, &v108, v60);
			//     v62 = *(_QWORD *)&v61.x;
			//     v63 = v61.z;
			//     *(float *)&v61 = v25.z;
			//     *(_QWORD *)&v109.x = *(_QWORD *)&v25.x;
			//     v65 = *v64;
			//     LODWORD(v109.z) = (_DWORD)v61;
			//     LODWORD(v61) = *((_DWORD *)v64 + 2);
			//     *(_QWORD *)&v108.x = v65;
			//     v117[0] = v62;
			//     LODWORD(v108.z) = (_DWORD)v61;
			//     v67 = UnityEngine::Vector3::op_Multiply(&v111, v113.y, &v109, v66);
			//     v68 = *(_QWORD *)&v67.x;
			//     *(float *)&v67 = v67.z;
			//     *(_QWORD *)&v109.x = v68;
			//     LODWORD(v109.z) = (_DWORD)v67;
			//     v70 = UnityEngine::Vector3::op_Subtraction(&v111, &v109, &v108, v69);
			//     *(_QWORD *)&v109.x = *(_QWORD *)&v25.x;
			//     v71 = *(_QWORD *)&v70.x;
			//     v72 = v70.z;
			//     v74 = *(_QWORD *)v73;
			//     v109.z = v25.z;
			//     v108.z = v73[2];
			//     *(_QWORD *)&v114.x = v71;
			//     *(_QWORD *)&v108.x = v74;
			//     v76 = UnityEngine::Vector3::op_Multiply(&v111, v112.y, &v109, v75);
			//     v77 = *(_QWORD *)&v76.x;
			//     *(float *)&v76 = v76.z;
			//     *(_QWORD *)&v109.x = v77;
			//     LODWORD(v109.z) = (_DWORD)v76;
			//     v79 = UnityEngine::Vector3::op_Subtraction(&v110, &v109, &v108, v78);
			//     *(_QWORD *)&v109.x = *(_QWORD *)&v25.x;
			//     v81 = *(_QWORD *)v80;
			//     v82 = *(_QWORD *)&v79.x;
			//     v83 = v79.z;
			//     v109.z = v25.z;
			//     v85 = v84;
			//     v108.z = v80[2];
			//     *(_QWORD *)&v111.x = v82;
			//     *(_QWORD *)&v108.x = v81;
			//     v87 = UnityEngine::Vector3::op_Multiply(&v110, v84, &v109, v86);
			//     v88 = *(_QWORD *)&v87.x;
			//     *(float *)&v87 = v87.z;
			//     *(_QWORD *)&v109.x = v88;
			//     LODWORD(v109.z) = (_DWORD)v87;
			//     v90 = UnityEngine::Vector3::op_Subtraction(&v115, &v109, &v108, v89);
			//     *(_QWORD *)&v109.x = *(_QWORD *)&v25.x;
			//     v92 = *(_QWORD *)v91;
			//     v93 = *(_QWORD *)&v90.x;
			//     v109.z = v25.z;
			//     v108.z = v91[2];
			//     *(_QWORD *)&v110.x = v93;
			//     *(_QWORD *)&v108.x = v92;
			//     v95 = *(float *)&v94;
			//     v96 = UnityEngine::Vector3::op_Multiply(&v115, *(float *)&v94, &v109, v94);
			//     v97 = *(_QWORD *)&v96.x;
			//     *(float *)&v96 = v96.z;
			//     *(_QWORD *)&v109.x = v97;
			//     LODWORD(v109.z) = (_DWORD)v96;
			//     v99 = halfSize + halfSize;
			//     *(_QWORD *)&v108.x = *(_QWORD *)&UnityEngine::Vector3::op_Subtraction(&v115, &v109, &v108, v98).x;
			//     return HG::Rendering::HgMath::HgMathf::InRange(*((float *)val + 1), 0.0, v99, 0LL)
			//         && HG::Rendering::HgMath::HgMathf::InRange(v54, 0.0, v99, 0LL)
			//         && HG::Rendering::HgMath::HgMathf::InRange(v113.x, 0.0, 1.0, 0LL)
			//         || HG::Rendering::HgMath::HgMathf::InRange(*((float *)v117 + 1), 0.0, v99, 0LL)
			//         && HG::Rendering::HgMath::HgMathf::InRange(v63, 0.0, v99, 0LL)
			//         && HG::Rendering::HgMath::HgMathf::InRange(v112.x, 0.0, 1.0, 0LL)
			//         || HG::Rendering::HgMath::HgMathf::InRange(v114.x, 0.0, v99, 0LL)
			//         && HG::Rendering::HgMath::HgMathf::InRange(v72, 0.0, v99, 0LL)
			//         && HG::Rendering::HgMath::HgMathf::InRange(v113.y, 0.0, 1.0, 0LL)
			//         || HG::Rendering::HgMath::HgMathf::InRange(v111.x, 0.0, v99, 0LL)
			//         && HG::Rendering::HgMath::HgMathf::InRange(v83, 0.0, v99, 0LL)
			//         && HG::Rendering::HgMath::HgMathf::InRange(v112.y, 0.0, 1.0, 0LL)
			//         || HG::Rendering::HgMath::HgMathf::InRange(v110.x, 0.0, v99, 0LL)
			//         && HG::Rendering::HgMath::HgMathf::InRange(v110.y, 0.0, v99, 0LL)
			//         && HG::Rendering::HgMath::HgMathf::InRange(v85, 0.0, 1.0, 0LL)
			//         || HG::Rendering::HgMath::HgMathf::InRange(v108.x, 0.0, v99, 0LL)
			//         && HG::Rendering::HgMath::HgMathf::InRange(v108.y, 0.0, v99, 0LL)
			//         && HG::Rendering::HgMath::HgMathf::InRange(v95, 0.0, 1.0, 0LL);
			//   }
			// }
			// 
			return default(bool);
		}

		public static bool TriangleAABBIntersect(Vector3 tp0, Vector3 tp1, Vector3 tp2, Vector3 center, Vector3 extent)
		{
			// // Boolean TriangleAABBIntersect(Vector3, Vector3, Vector3, Vector3, Vector3)
			// bool HG::Rendering::HgMath::HgMathf::TriangleAABBIntersect(
			//         Vector3 *tp0,
			//         Vector3 *tp1,
			//         Vector3 *tp2,
			//         Vector3 *center,
			//         Vector3 *extent,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v10; // r9
			//   float v11; // eax
			//   __int64 v12; // xmm0_8
			//   float v13; // eax
			//   Vector3 *v14; // r12
			//   float v15; // ecx
			//   float v16; // eax
			//   __int64 v17; // xmm0_8
			//   float v18; // ecx
			//   __int64 v19; // xmm0_8
			//   MethodInfo *v20; // r9
			//   Vector3 *v21; // r13
			//   float v22; // ecx
			//   float v23; // eax
			//   __int64 v24; // xmm0_8
			//   float v25; // ecx
			//   __int64 v26; // xmm0_8
			//   MethodInfo *v27; // r9
			//   Vector3 *v28; // r15
			//   float v29; // ecx
			//   float v30; // eax
			//   __int64 v31; // xmm0_8
			//   float v32; // ecx
			//   __int64 v33; // xmm0_8
			//   MethodInfo *v34; // r9
			//   Vector3 *v35; // rax
			//   float v36; // ecx
			//   Vector3 *v37; // rbx
			//   __int64 v38; // xmm0_8
			//   __int64 v39; // xmm0_8
			//   MethodInfo *v40; // r9
			//   Vector3 *v41; // rdi
			//   float v42; // ecx
			//   float v43; // eax
			//   __int64 v44; // xmm0_8
			//   float v45; // ecx
			//   __int64 v46; // xmm0_8
			//   MethodInfo *v47; // r9
			//   Vector3 *v48; // rsi
			//   MethodInfo *v49; // rdx
			//   Vector3 *right; // rax
			//   __int64 v51; // xmm0_8
			//   MethodInfo *v52; // rdx
			//   Vector3 *up; // rax
			//   __int64 v54; // xmm0_8
			//   MethodInfo *v55; // rdx
			//   Vector3 *fwd; // rax
			//   float *v57; // r9
			//   float v58; // ecx
			//   __int64 v59; // xmm0_8
			//   __int64 v60; // xmm0_8
			//   Vector3 *v61; // rax
			//   float *v62; // r9
			//   __int64 v63; // xmm0_8
			//   __int64 v64; // xmm4_8
			//   Vector3 *v65; // r14
			//   Vector3 *v66; // rax
			//   __int64 v67; // xmm0_8
			//   __int64 v68; // xmm0_8
			//   __int64 *v69; // r9
			//   __int64 v70; // xmm0_8
			//   Vector3 *v71; // rax
			//   __int64 v72; // xmm0_8
			//   __int64 *v73; // r10
			//   __int64 v74; // xmm0_8
			//   MethodInfo *v75; // r9
			//   Vector3 *v76; // rax
			//   __int64 v77; // xmm4_8
			//   __int64 v78; // xmm0_8
			//   float *v79; // r10
			//   __int64 v80; // xmm0_8
			//   MethodInfo *v81; // r9
			//   Vector3 *v82; // rax
			//   __int64 v83; // xmm0_8
			//   __int64 v84; // xmm0_8
			//   __int64 *v85; // r11
			//   __int64 v86; // xmm0_8
			//   MethodInfo *v87; // r9
			//   Vector3 *v88; // rax
			//   __int64 v89; // xmm0_8
			//   __int64 v90; // xmm0_8
			//   __int64 *v91; // r11
			//   __int64 v92; // xmm0_8
			//   MethodInfo *v93; // r9
			//   Vector3 *v94; // rax
			//   __int64 v95; // xmm4_8
			//   __int64 v96; // xmm0_8
			//   float *v97; // r11
			//   __int64 v98; // xmm0_8
			//   MethodInfo *v99; // r9
			//   Vector3 *v100; // rax
			//   __int64 v101; // xmm0_8
			//   __int64 v102; // xmm0_8
			//   __int64 *v103; // r11
			//   __int64 v104; // xmm0_8
			//   MethodInfo *v105; // r9
			//   Vector3 *v106; // rax
			//   __int64 v107; // xmm0_8
			//   __int64 v108; // xmm0_8
			//   __int64 v109; // xmm0_8
			//   __int64 v110; // xmm0_8
			//   __int64 v111; // xmm0_8
			//   __int64 v112; // xmm0_8
			//   __int64 v113; // xmm0_8
			//   float v114; // eax
			//   __int64 v115; // xmm0_8
			//   float v116; // eax
			//   __int64 v117; // xmm0_8
			//   float v118; // eax
			//   __int64 v119; // xmm0_8
			//   __int64 v120; // xmm0_8
			//   float v121; // eax
			//   __int64 v122; // xmm0_8
			//   float v123; // eax
			//   __int64 v124; // xmm0_8
			//   float v125; // eax
			//   __int64 v126; // xmm0_8
			//   __int64 v127; // xmm0_8
			//   float v128; // eax
			//   __int64 v129; // xmm0_8
			//   float v130; // eax
			//   __int64 v131; // xmm0_8
			//   float v132; // eax
			//   __int64 v133; // xmm0_8
			//   __int64 v134; // xmm0_8
			//   float v135; // eax
			//   __int64 v136; // xmm0_8
			//   float v137; // eax
			//   __int64 v138; // xmm0_8
			//   float v139; // eax
			//   __int64 v140; // xmm0_8
			//   __int64 v141; // xmm0_8
			//   float v142; // eax
			//   __int64 v143; // xmm0_8
			//   float v144; // eax
			//   __int64 v145; // xmm0_8
			//   float v146; // eax
			//   __int64 v147; // xmm0_8
			//   __int64 v148; // xmm0_8
			//   float v149; // eax
			//   __int64 v150; // xmm0_8
			//   float v151; // eax
			//   __int64 v152; // xmm0_8
			//   float v153; // eax
			//   __int64 v154; // xmm0_8
			//   __int64 v155; // xmm0_8
			//   float v156; // eax
			//   __int64 v157; // xmm0_8
			//   float v158; // eax
			//   __int64 v159; // xmm0_8
			//   float v160; // eax
			//   __int64 v161; // xmm0_8
			//   __int64 v162; // xmm0_8
			//   float v163; // eax
			//   __int64 v164; // xmm0_8
			//   float v165; // eax
			//   __int64 v166; // xmm0_8
			//   float v167; // eax
			//   __int64 v168; // xmm0_8
			//   __int64 v169; // xmm0_8
			//   float v170; // eax
			//   __int64 v171; // xmm0_8
			//   float v172; // eax
			//   __int64 v173; // xmm0_8
			//   float v174; // eax
			//   __int64 v175; // xmm0_8
			//   __int64 v176; // xmm0_8
			//   float v177; // eax
			//   __int64 v178; // xmm0_8
			//   float v179; // eax
			//   __int64 v180; // xmm0_8
			//   float v181; // eax
			//   __int64 v182; // xmm0_8
			//   __int64 v183; // xmm0_8
			//   float v184; // eax
			//   __int64 v185; // xmm0_8
			//   float v186; // eax
			//   __int64 v187; // xmm0_8
			//   float v188; // eax
			//   __int64 v189; // xmm0_8
			//   MethodInfo *v190; // r9
			//   Vector3 *v191; // rax
			//   __int64 v192; // xmm0_8
			//   __int64 v193; // xmm4_8
			//   __int64 v194; // xmm0_8
			//   __int64 v195; // xmm0_8
			//   __int64 v196; // rax
			//   __int64 v197; // xmm0_8
			//   __int64 v199; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int64 v201; // xmm0_8
			//   float z; // eax
			//   __int64 v203; // xmm0_8
			//   float v204; // eax
			//   __int64 v205; // xmm0_8
			//   Vector3 v206; // [rsp+48h] [rbp-C0h] BYREF
			//   Vector3 v207; // [rsp+58h] [rbp-B0h] BYREF
			//   Vector3 v208; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector3 v209; // [rsp+78h] [rbp-90h] BYREF
			//   Vector3 v210; // [rsp+88h] [rbp-80h] BYREF
			//   Vector3 v211; // [rsp+98h] [rbp-70h] BYREF
			//   Vector3 v212; // [rsp+A8h] [rbp-60h] BYREF
			//   Vector3 v213; // [rsp+B8h] [rbp-50h] BYREF
			//   Vector3 v214; // [rsp+C8h] [rbp-40h] BYREF
			//   Vector3 v215; // [rsp+D8h] [rbp-30h] BYREF
			//   Vector3 v216; // [rsp+E8h] [rbp-20h] BYREF
			//   float v217; // [rsp+F8h] [rbp-10h]
			//   float v218; // [rsp+FCh] [rbp-Ch]
			//   float v219; // [rsp+100h] [rbp-8h]
			//   float v220; // [rsp+104h] [rbp-4h]
			//   float v221; // [rsp+108h] [rbp+0h]
			//   float v222; // [rsp+10Ch] [rbp+4h]
			//   float v223; // [rsp+110h] [rbp+8h]
			//   float v224; // [rsp+114h] [rbp+Ch]
			//   float v225; // [rsp+118h] [rbp+10h]
			//   float v226; // [rsp+11Ch] [rbp+14h]
			//   float v227; // [rsp+120h] [rbp+18h]
			//   float v228; // [rsp+124h] [rbp+1Ch]
			//   float v229; // [rsp+128h] [rbp+20h]
			//   Vector3 v230; // [rsp+138h] [rbp+30h] BYREF
			//   __int64 v231; // [rsp+148h] [rbp+40h]
			//   __int64 v232; // [rsp+150h] [rbp+48h]
			//   __int64 v233; // [rsp+158h] [rbp+50h]
			//   Vector3 v234; // [rsp+160h] [rbp+58h] BYREF
			//   Vector3 v235; // [rsp+170h] [rbp+68h] BYREF
			//   __int64 v236; // [rsp+180h] [rbp+78h]
			//   Vector3 v237; // [rsp+188h] [rbp+80h] BYREF
			//   Vector3 v238; // [rsp+198h] [rbp+90h] BYREF
			//   Vector3 v239[5]; // [rsp+1A8h] [rbp+A0h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(342, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(342, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v199);
			//     v201 = *(_QWORD *)&extent.x;
			//     v206.z = extent.z;
			//     v208.z = center.z;
			//     z = tp2.z;
			//     *(_QWORD *)&v206.x = v201;
			//     v203 = *(_QWORD *)&center.x;
			//     v210.z = z;
			//     v204 = tp1.z;
			//     *(_QWORD *)&v208.x = v203;
			//     v205 = *(_QWORD *)&tp2.x;
			//     v209.z = v204;
			//     v207.z = tp0.z;
			//     *(_QWORD *)&v210.x = v205;
			//     *(_QWORD *)&v209.x = *(_QWORD *)&tp1.x;
			//     *(_QWORD *)&v207.x = *(_QWORD *)&tp0.x;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_157(Patch, &v207, &v209, &v210, &v208, &v206, 0LL);
			//   }
			//   else
			//   {
			//     v11 = center.z;
			//     *(_QWORD *)&v214.x = *(_QWORD *)&center.x;
			//     v12 = *(_QWORD *)&tp0.x;
			//     v214.z = v11;
			//     v13 = tp0.z;
			//     *(_QWORD *)&v213.x = v12;
			//     v213.z = v13;
			//     v14 = UnityEngine::Vector3::op_Subtraction(&v206, &v213, &v214, v10);
			//     v15 = v14.z;
			//     v16 = tp1.z;
			//     *(_QWORD *)&tp0.x = *(_QWORD *)&v14.x;
			//     v17 = *(_QWORD *)&center.x;
			//     tp0.z = v15;
			//     v18 = center.z;
			//     *(_QWORD *)&v214.x = v17;
			//     v19 = *(_QWORD *)&tp1.x;
			//     v214.z = v18;
			//     *(_QWORD *)&v213.x = v19;
			//     v213.z = v16;
			//     v21 = UnityEngine::Vector3::op_Subtraction(&v208, &v213, &v214, v20);
			//     v22 = v21.z;
			//     v23 = tp2.z;
			//     *(_QWORD *)&tp1.x = *(_QWORD *)&v21.x;
			//     v24 = *(_QWORD *)&center.x;
			//     tp1.z = v22;
			//     v25 = center.z;
			//     *(_QWORD *)&v214.x = v24;
			//     v26 = *(_QWORD *)&tp2.x;
			//     v214.z = v25;
			//     *(_QWORD *)&v213.x = v26;
			//     v213.z = v23;
			//     v28 = UnityEngine::Vector3::op_Subtraction(&v210, &v213, &v214, v27);
			//     v29 = v28.z;
			//     v30 = v21.z;
			//     *(_QWORD *)&tp2.x = *(_QWORD *)&v28.x;
			//     v31 = *(_QWORD *)&v14.x;
			//     tp2.z = v29;
			//     v32 = v14.z;
			//     *(_QWORD *)&v214.x = v31;
			//     v33 = *(_QWORD *)&v21.x;
			//     v214.z = v32;
			//     *(_QWORD *)&v213.x = v33;
			//     v213.z = v30;
			//     v35 = UnityEngine::Vector3::op_Subtraction(&v209, &v213, &v214, v34);
			//     v213.z = v21.z;
			//     v36 = v28.z;
			//     v37 = v35;
			//     v38 = *(_QWORD *)&v35.x;
			//     *(float *)&v35 = v35.z;
			//     *(_QWORD *)&v214.x = v38;
			//     *(_QWORD *)&v213.x = *(_QWORD *)&v21.x;
			//     v39 = *(_QWORD *)&v28.x;
			//     v215.z = v36;
			//     *(_QWORD *)&v215.x = v39;
			//     v229 = *(float *)&v35;
			//     v41 = UnityEngine::Vector3::op_Subtraction(&v207, &v215, &v213, v40);
			//     v42 = v28.z;
			//     v43 = v41.z;
			//     *(_QWORD *)&v213.x = *(_QWORD *)&v41.x;
			//     v44 = *(_QWORD *)&v28.x;
			//     v215.z = v42;
			//     v45 = v14.z;
			//     *(_QWORD *)&v215.x = v44;
			//     v46 = *(_QWORD *)&v14.x;
			//     v230.z = v45;
			//     *(_QWORD *)&v230.x = v46;
			//     v228 = v43;
			//     v48 = UnityEngine::Vector3::op_Subtraction(v239, &v230, &v215, v47);
			//     right = UnityEngine::Vector3::get_right(&v216, v49);
			//     v51 = *(_QWORD *)&right.x;
			//     *(float *)&right = right.z;
			//     v233 = v51;
			//     v225 = *(float *)&right;
			//     up = UnityEngine::Vector3::get_up(&v235, v52);
			//     v54 = *(_QWORD *)&up.x;
			//     *(float *)&up = up.z;
			//     *(_QWORD *)&v230.x = v54;
			//     v226 = *(float *)&up;
			//     fwd = UnityEngine::Vector3::get_fwd(&v238, v55);
			//     v211.z = v37.z;
			//     v58 = v57[2];
			//     v59 = *(_QWORD *)&fwd.x;
			//     *(float *)&fwd = fwd.z;
			//     *(_QWORD *)&v215.x = v59;
			//     *(_QWORD *)&v211.x = *(_QWORD *)&v37.x;
			//     v60 = *(_QWORD *)v57;
			//     v212.z = v58;
			//     *(_QWORD *)&v212.x = v60;
			//     v227 = *(float *)&fwd;
			//     v61 = UnityEngine::Vector3::Cross(&v237, &v212, &v211, (MethodInfo *)v57);
			//     v63 = *(_QWORD *)v62;
			//     v64 = *(_QWORD *)&v41.x;
			//     v65 = v61;
			//     v211.z = v41.z;
			//     v212.z = v62[2];
			//     *(_QWORD *)&v211.x = v64;
			//     *(_QWORD *)&v212.x = v63;
			//     v66 = UnityEngine::Vector3::Cross(&v234, &v212, &v211, (MethodInfo *)v62);
			//     v67 = *(_QWORD *)&v66.x;
			//     *(float *)&v66 = v66.z;
			//     v236 = v67;
			//     v68 = *(_QWORD *)&v48.x;
			//     v217 = *(float *)&v66;
			//     *(float *)&v66 = v48.z;
			//     *(_QWORD *)&v211.x = v68;
			//     v70 = *v69;
			//     LODWORD(v211.z) = (_DWORD)v66;
			//     LODWORD(v66) = *((_DWORD *)v69 + 2);
			//     *(_QWORD *)&v212.x = v70;
			//     LODWORD(v212.z) = (_DWORD)v66;
			//     v71 = UnityEngine::Vector3::Cross(&v216, &v212, &v211, (MethodInfo *)v69);
			//     v231 = *(_QWORD *)&v71.x;
			//     v72 = *(_QWORD *)&v37.x;
			//     v218 = v71.z;
			//     *(float *)&v71 = v37.z;
			//     *(_QWORD *)&v211.x = v72;
			//     v74 = *v73;
			//     LODWORD(v211.z) = (_DWORD)v71;
			//     LODWORD(v71) = *((_DWORD *)v73 + 2);
			//     *(_QWORD *)&v212.x = v74;
			//     LODWORD(v212.z) = (_DWORD)v71;
			//     v76 = UnityEngine::Vector3::Cross(&v216, &v212, &v211, v75);
			//     *(_QWORD *)&v211.x = v77;
			//     v78 = *(_QWORD *)&v76.x;
			//     v219 = v76.z;
			//     *(float *)&v76 = v41.z;
			//     v232 = v78;
			//     v80 = *(_QWORD *)v79;
			//     LODWORD(v211.z) = (_DWORD)v76;
			//     v212.z = v79[2];
			//     *(_QWORD *)&v212.x = v80;
			//     v82 = UnityEngine::Vector3::Cross(&v216, &v212, &v211, v81);
			//     v83 = *(_QWORD *)&v82.x;
			//     *(float *)&v82 = v82.z;
			//     *(_QWORD *)&v234.x = v83;
			//     v84 = *(_QWORD *)&v48.x;
			//     v220 = *(float *)&v82;
			//     *(float *)&v82 = v48.z;
			//     *(_QWORD *)&v211.x = v84;
			//     v86 = *v85;
			//     LODWORD(v211.z) = (_DWORD)v82;
			//     LODWORD(v82) = *((_DWORD *)v85 + 2);
			//     *(_QWORD *)&v212.x = v86;
			//     LODWORD(v212.z) = (_DWORD)v82;
			//     v88 = UnityEngine::Vector3::Cross(&v216, &v212, &v211, v87);
			//     v89 = *(_QWORD *)&v88.x;
			//     *(float *)&v88 = v88.z;
			//     *(_QWORD *)&v235.x = v89;
			//     v90 = *(_QWORD *)&v37.x;
			//     v221 = *(float *)&v88;
			//     *(float *)&v88 = v37.z;
			//     *(_QWORD *)&v211.x = v90;
			//     v92 = *v91;
			//     LODWORD(v211.z) = (_DWORD)v88;
			//     LODWORD(v88) = *((_DWORD *)v91 + 2);
			//     *(_QWORD *)&v212.x = v92;
			//     LODWORD(v212.z) = (_DWORD)v88;
			//     v94 = UnityEngine::Vector3::Cross(&v209, &v212, &v211, v93);
			//     *(_QWORD *)&v211.x = v95;
			//     v96 = *(_QWORD *)&v94.x;
			//     v222 = v94.z;
			//     *(float *)&v94 = v41.z;
			//     *(_QWORD *)&v216.x = v96;
			//     v98 = *(_QWORD *)v97;
			//     LODWORD(v211.z) = (_DWORD)v94;
			//     v212.z = v97[2];
			//     *(_QWORD *)&v212.x = v98;
			//     v100 = UnityEngine::Vector3::Cross(&v209, &v212, &v211, v99);
			//     v101 = *(_QWORD *)&v100.x;
			//     *(float *)&v100 = v100.z;
			//     *(_QWORD *)&v212.x = v101;
			//     v102 = *(_QWORD *)&v48.x;
			//     v223 = *(float *)&v100;
			//     *(float *)&v100 = v48.z;
			//     *(_QWORD *)&v211.x = v102;
			//     v104 = *v103;
			//     LODWORD(v211.z) = (_DWORD)v100;
			//     LODWORD(v100) = *((_DWORD *)v103 + 2);
			//     *(_QWORD *)&v207.x = v104;
			//     LODWORD(v207.z) = (_DWORD)v100;
			//     v106 = UnityEngine::Vector3::Cross(&v238, &v207, &v211, v105);
			//     v107 = *(_QWORD *)&v106.x;
			//     v224 = v106.z;
			//     *(_QWORD *)&v211.x = v107;
			//     v108 = *(_QWORD *)&extent.x;
			//     v207.z = extent.z;
			//     *(float *)&v106 = v28.z;
			//     *(_QWORD *)&v207.x = v108;
			//     v109 = *(_QWORD *)&v28.x;
			//     LODWORD(v209.z) = (_DWORD)v106;
			//     *(float *)&v106 = v21.z;
			//     *(_QWORD *)&v209.x = v109;
			//     v110 = *(_QWORD *)&v21.x;
			//     LODWORD(v210.z) = (_DWORD)v106;
			//     *(float *)&v106 = v14.z;
			//     *(_QWORD *)&v210.x = v110;
			//     v111 = *(_QWORD *)&v14.x;
			//     LODWORD(v208.z) = (_DWORD)v106;
			//     *(float *)&v106 = v65.z;
			//     *(_QWORD *)&v208.x = v111;
			//     v112 = *(_QWORD *)&v65.x;
			//     LODWORD(v206.z) = (_DWORD)v106;
			//     *(_QWORD *)&v206.x = v112;
			//     if ( HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v206, &v208, &v210, &v209, &v207, 0LL) )
			//       return 0;
			//     v113 = *(_QWORD *)&extent.x;
			//     v206.z = extent.z;
			//     v114 = tp2.z;
			//     *(_QWORD *)&v206.x = v113;
			//     v115 = *(_QWORD *)&tp2.x;
			//     v208.z = v114;
			//     v116 = tp1.z;
			//     *(_QWORD *)&v208.x = v115;
			//     v117 = *(_QWORD *)&tp1.x;
			//     v210.z = v116;
			//     v118 = tp0.z;
			//     *(_QWORD *)&v210.x = v117;
			//     v119 = *(_QWORD *)&tp0.x;
			//     v209.z = v118;
			//     *(_QWORD *)&v209.x = v119;
			//     v207.z = v217;
			//     *(_QWORD *)&v207.x = v236;
			//     if ( HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v207, &v209, &v210, &v208, &v206, 0LL) )
			//       return 0;
			//     v120 = *(_QWORD *)&extent.x;
			//     v206.z = extent.z;
			//     v121 = tp2.z;
			//     *(_QWORD *)&v206.x = v120;
			//     v122 = *(_QWORD *)&tp2.x;
			//     v208.z = v121;
			//     v123 = tp1.z;
			//     *(_QWORD *)&v208.x = v122;
			//     v124 = *(_QWORD *)&tp1.x;
			//     v210.z = v123;
			//     v125 = tp0.z;
			//     *(_QWORD *)&v210.x = v124;
			//     v126 = *(_QWORD *)&tp0.x;
			//     v209.z = v125;
			//     *(_QWORD *)&v209.x = v126;
			//     v207.z = v218;
			//     *(_QWORD *)&v207.x = v231;
			//     if ( HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v207, &v209, &v210, &v208, &v206, 0LL) )
			//       return 0;
			//     v127 = *(_QWORD *)&extent.x;
			//     v206.z = extent.z;
			//     v128 = tp2.z;
			//     *(_QWORD *)&v206.x = v127;
			//     v129 = *(_QWORD *)&tp2.x;
			//     v208.z = v128;
			//     v130 = tp1.z;
			//     *(_QWORD *)&v208.x = v129;
			//     v131 = *(_QWORD *)&tp1.x;
			//     v210.z = v130;
			//     v132 = tp0.z;
			//     *(_QWORD *)&v210.x = v131;
			//     v133 = *(_QWORD *)&tp0.x;
			//     v209.z = v132;
			//     *(_QWORD *)&v209.x = v133;
			//     v207.z = v219;
			//     *(_QWORD *)&v207.x = v232;
			//     if ( HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v207, &v209, &v210, &v208, &v206, 0LL) )
			//       return 0;
			//     v134 = *(_QWORD *)&extent.x;
			//     v206.z = extent.z;
			//     v135 = tp2.z;
			//     *(_QWORD *)&v206.x = v134;
			//     v136 = *(_QWORD *)&tp2.x;
			//     v208.z = v135;
			//     v137 = tp1.z;
			//     *(_QWORD *)&v208.x = v136;
			//     v138 = *(_QWORD *)&tp1.x;
			//     v210.z = v137;
			//     v139 = tp0.z;
			//     *(_QWORD *)&v210.x = v138;
			//     v140 = *(_QWORD *)&tp0.x;
			//     v209.z = v139;
			//     *(_QWORD *)&v209.x = v140;
			//     v207.z = v220;
			//     *(_QWORD *)&v207.x = *(_QWORD *)&v234.x;
			//     if ( HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v207, &v209, &v210, &v208, &v206, 0LL) )
			//       return 0;
			//     v141 = *(_QWORD *)&extent.x;
			//     v206.z = extent.z;
			//     v142 = tp2.z;
			//     *(_QWORD *)&v206.x = v141;
			//     v143 = *(_QWORD *)&tp2.x;
			//     v208.z = v142;
			//     v144 = tp1.z;
			//     *(_QWORD *)&v208.x = v143;
			//     v145 = *(_QWORD *)&tp1.x;
			//     v210.z = v144;
			//     v146 = tp0.z;
			//     *(_QWORD *)&v210.x = v145;
			//     v147 = *(_QWORD *)&tp0.x;
			//     v209.z = v146;
			//     *(_QWORD *)&v209.x = v147;
			//     v207.z = v221;
			//     *(_QWORD *)&v207.x = *(_QWORD *)&v235.x;
			//     if ( HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v207, &v209, &v210, &v208, &v206, 0LL) )
			//       return 0;
			//     v148 = *(_QWORD *)&extent.x;
			//     v206.z = extent.z;
			//     v149 = tp2.z;
			//     *(_QWORD *)&v206.x = v148;
			//     v150 = *(_QWORD *)&tp2.x;
			//     v208.z = v149;
			//     v151 = tp1.z;
			//     *(_QWORD *)&v208.x = v150;
			//     v152 = *(_QWORD *)&tp1.x;
			//     v210.z = v151;
			//     v153 = tp0.z;
			//     *(_QWORD *)&v210.x = v152;
			//     v154 = *(_QWORD *)&tp0.x;
			//     v209.z = v153;
			//     *(_QWORD *)&v209.x = v154;
			//     v207.z = v222;
			//     *(_QWORD *)&v207.x = *(_QWORD *)&v216.x;
			//     if ( HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v207, &v209, &v210, &v208, &v206, 0LL) )
			//       return 0;
			//     v155 = *(_QWORD *)&extent.x;
			//     v206.z = extent.z;
			//     v156 = tp2.z;
			//     *(_QWORD *)&v206.x = v155;
			//     v157 = *(_QWORD *)&tp2.x;
			//     v208.z = v156;
			//     v158 = tp1.z;
			//     *(_QWORD *)&v208.x = v157;
			//     v159 = *(_QWORD *)&tp1.x;
			//     v210.z = v158;
			//     v160 = tp0.z;
			//     *(_QWORD *)&v210.x = v159;
			//     v161 = *(_QWORD *)&tp0.x;
			//     v209.z = v160;
			//     *(_QWORD *)&v209.x = v161;
			//     v207.z = v223;
			//     *(_QWORD *)&v207.x = *(_QWORD *)&v212.x;
			//     if ( HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v207, &v209, &v210, &v208, &v206, 0LL) )
			//       return 0;
			//     v162 = *(_QWORD *)&extent.x;
			//     v206.z = extent.z;
			//     v163 = tp2.z;
			//     *(_QWORD *)&v206.x = v162;
			//     v164 = *(_QWORD *)&tp2.x;
			//     v208.z = v163;
			//     v165 = tp1.z;
			//     *(_QWORD *)&v208.x = v164;
			//     v166 = *(_QWORD *)&tp1.x;
			//     v210.z = v165;
			//     v167 = tp0.z;
			//     *(_QWORD *)&v210.x = v166;
			//     v168 = *(_QWORD *)&tp0.x;
			//     v209.z = v167;
			//     *(_QWORD *)&v209.x = v168;
			//     v207.z = v224;
			//     *(_QWORD *)&v207.x = *(_QWORD *)&v211.x;
			//     if ( HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v207, &v209, &v210, &v208, &v206, 0LL) )
			//       return 0;
			//     v169 = *(_QWORD *)&extent.x;
			//     v206.z = extent.z;
			//     v170 = tp2.z;
			//     *(_QWORD *)&v206.x = v169;
			//     v171 = *(_QWORD *)&tp2.x;
			//     v208.z = v170;
			//     v172 = tp1.z;
			//     *(_QWORD *)&v208.x = v171;
			//     v173 = *(_QWORD *)&tp1.x;
			//     v210.z = v172;
			//     v174 = tp0.z;
			//     *(_QWORD *)&v210.x = v173;
			//     v175 = *(_QWORD *)&tp0.x;
			//     v209.z = v174;
			//     *(_QWORD *)&v209.x = v175;
			//     v207.z = v225;
			//     *(_QWORD *)&v207.x = v233;
			//     if ( HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v207, &v209, &v210, &v208, &v206, 0LL) )
			//       return 0;
			//     v176 = *(_QWORD *)&extent.x;
			//     v206.z = extent.z;
			//     v177 = tp2.z;
			//     *(_QWORD *)&v206.x = v176;
			//     v178 = *(_QWORD *)&tp2.x;
			//     v208.z = v177;
			//     v179 = tp1.z;
			//     *(_QWORD *)&v208.x = v178;
			//     v180 = *(_QWORD *)&tp1.x;
			//     v210.z = v179;
			//     v181 = tp0.z;
			//     *(_QWORD *)&v210.x = v180;
			//     v182 = *(_QWORD *)&tp0.x;
			//     v209.z = v181;
			//     *(_QWORD *)&v209.x = v182;
			//     v207.z = v226;
			//     *(_QWORD *)&v207.x = *(_QWORD *)&v230.x;
			//     if ( HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v207, &v209, &v210, &v208, &v206, 0LL) )
			//       return 0;
			//     v183 = *(_QWORD *)&extent.x;
			//     v206.z = extent.z;
			//     v184 = tp2.z;
			//     *(_QWORD *)&v206.x = v183;
			//     v185 = *(_QWORD *)&tp2.x;
			//     v208.z = v184;
			//     v186 = tp1.z;
			//     *(_QWORD *)&v208.x = v185;
			//     v187 = *(_QWORD *)&tp1.x;
			//     v210.z = v186;
			//     v188 = tp0.z;
			//     *(_QWORD *)&v210.x = v187;
			//     v189 = *(_QWORD *)&tp0.x;
			//     v209.z = v188;
			//     *(_QWORD *)&v209.x = v189;
			//     v207.z = v227;
			//     *(_QWORD *)&v207.x = *(_QWORD *)&v215.x;
			//     if ( HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v207, &v209, &v210, &v208, &v206, 0LL) )
			//       return 0;
			//     *(_QWORD *)&v206.x = *(_QWORD *)&v213.x;
			//     v206.z = v228;
			//     *(_QWORD *)&v208.x = *(_QWORD *)&v214.x;
			//     v208.z = v229;
			//     v191 = UnityEngine::Vector3::Cross(&v237, &v208, &v206, v190);
			//     *(_QWORD *)&v208.x = *(_QWORD *)&extent.x;
			//     v192 = *(_QWORD *)&tp2.x;
			//     v193 = *(_QWORD *)&v191.x;
			//     v206.z = v191.z;
			//     v208.z = extent.z;
			//     *(float *)&v191 = tp2.z;
			//     *(_QWORD *)&v210.x = v192;
			//     v194 = *(_QWORD *)&tp1.x;
			//     LODWORD(v210.z) = (_DWORD)v191;
			//     *(float *)&v191 = tp1.z;
			//     *(_QWORD *)&v209.x = v194;
			//     v195 = *(_QWORD *)&tp0.x;
			//     LODWORD(v209.z) = (_DWORD)v191;
			//     v207.z = tp0.z;
			//     *(_QWORD *)&v206.x = v193;
			//     *(_QWORD *)&v207.x = v195;
			//     v196 = sub_182413270(&v237, &v206);
			//     v197 = *(_QWORD *)v196;
			//     v206.z = *(float *)(v196 + 8);
			//     *(_QWORD *)&v206.x = v197;
			//     return !HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(&v206, &v207, &v209, &v210, &v208, 0LL);
			//   }
			// }
			// 
			return default(bool);
		}

		internal static bool CanAxisSeparateProjection(Vector3 axis, Vector3 v0, Vector3 v1, Vector3 v2, Vector3 aabbExtent)
		{
			// // Boolean CanAxisSeparateProjection(Vector3, Vector3, Vector3, Vector3, Vector3)
			// bool HG::Rendering::HgMath::HgMathf::CanAxisSeparateProjection(
			//         Vector3 *axis,
			//         Vector3 *v0,
			//         Vector3 *v1,
			//         Vector3 *v2,
			//         Vector3 *aabbExtent,
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
			//   float v19; // eax
			//   MethodInfo *v20; // r8
			//   MethodInfo *v21; // rdx
			//   MethodInfo *right; // rax
			//   MethodInfo *v23; // rdx
			//   Vector3 *fwd; // r9
			//   float *v25; // r8
			//   float v26; // eax
			//   float v27; // ecx
			//   __int64 v28; // rdx
			//   __int64 v29; // xmm0_8
			//   float v30; // ecx
			//   __int64 v31; // xmm0_8
			//   float v32; // ecx
			//   float v33; // eax
			//   MethodInfo *v34; // r8
			//   float *v35; // rax
			//   MethodInfo *v36; // r8
			//   __int64 v37; // rax
			//   float v38; // xmm4_4
			//   __int64 v40; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int64 v42; // xmm0_8
			//   float z; // eax
			//   __int64 v44; // xmm0_8
			//   float v45; // eax
			//   __int64 v46; // xmm0_8
			//   Vector3 v47; // [rsp+48h] [rbp-49h] BYREF
			//   Vector3 v48; // [rsp+58h] [rbp-39h] BYREF
			//   Vector3 v49; // [rsp+68h] [rbp-29h] BYREF
			//   Vector3 v50; // [rsp+78h] [rbp-19h] BYREF
			//   Vector3 v51; // [rsp+88h] [rbp-9h] BYREF
			//   Vector3 v52; // [rsp+98h] [rbp+7h] BYREF
			//   Vector3 v53[4]; // [rsp+A8h] [rbp+17h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(343, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(343, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v40);
			//     v42 = *(_QWORD *)&aabbExtent.x;
			//     v52.z = aabbExtent.z;
			//     v51.z = v2.z;
			//     z = v1.z;
			//     *(_QWORD *)&v52.x = v42;
			//     v44 = *(_QWORD *)&v2.x;
			//     v50.z = z;
			//     v45 = v0.z;
			//     *(_QWORD *)&v51.x = v44;
			//     v46 = *(_QWORD *)&v1.x;
			//     v49.z = v45;
			//     v48.z = axis.z;
			//     *(_QWORD *)&v50.x = v46;
			//     *(_QWORD *)&v49.x = *(_QWORD *)&v0.x;
			//     *(_QWORD *)&v48.x = *(_QWORD *)&axis.x;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_157(Patch, &v48, &v49, &v50, &v51, &v52, 0LL);
			//   }
			//   else
			//   {
			//     v11 = axis.z;
			//     *(_QWORD *)&v47.x = *(_QWORD *)&axis.x;
			//     v12 = *(_QWORD *)&v0.x;
			//     v47.z = v11;
			//     v13 = v0.z;
			//     *(_QWORD *)&v48.x = v12;
			//     v48.z = v13;
			//     UnityEngine::Vector3::Dot(&v48, &v47, v10);
			//     v14 = *(_QWORD *)&v1.x;
			//     v15 = *(_QWORD *)&axis.x;
			//     v48.z = axis.z;
			//     v16 = v1.z;
			//     *(_QWORD *)&v47.x = v14;
			//     v47.z = v16;
			//     *(_QWORD *)&v48.x = v15;
			//     UnityEngine::Vector3::Dot(&v47, &v48, v17);
			//     v18 = *(_QWORD *)&v2.x;
			//     v48.z = axis.z;
			//     v19 = v2.z;
			//     *(_QWORD *)&v47.x = v18;
			//     v47.z = v19;
			//     *(_QWORD *)&v48.x = v15;
			//     UnityEngine::Vector3::Dot(&v47, &v48, v20);
			//     right = (MethodInfo *)UnityEngine::Vector3::get_right(&v52, v21);
			//     UnityEngine::Vector3::get_up(&v51, right);
			//     fwd = UnityEngine::Vector3::get_fwd(v53, v23);
			//     v26 = v25[2];
			//     v27 = axis.z;
			//     *(_QWORD *)&v50.x = *(_QWORD *)v28;
			//     v29 = *(_QWORD *)v25;
			//     v49.z = v27;
			//     v30 = *(float *)(v28 + 8);
			//     *(_QWORD *)&v47.x = v29;
			//     v31 = *(_QWORD *)&fwd.x;
			//     v50.z = v30;
			//     v32 = axis.z;
			//     v47.z = v26;
			//     v33 = fwd.z;
			//     *(_QWORD *)&v52.x = v31;
			//     *(_QWORD *)&v49.x = v15;
			//     *(_QWORD *)&v48.x = v15;
			//     v48.z = v32;
			//     *(_QWORD *)&v51.x = v15;
			//     v51.z = v32;
			//     v52.z = v33;
			//     *(float *)&v15 = fabs(UnityEngine::Vector3::Dot(&v47, &v48, (MethodInfo *)v25)) * aabbExtent.y;
			//     *(float *)&v31 = UnityEngine::Vector3::Dot(&v50, &v49, v34);
			//     *(float *)&v15 = *(float *)&v15 + (float)(fabs(*(float *)&v31) * *v35);
			//     *(float *)&v31 = UnityEngine::Vector3::Dot(&v52, &v51, v36);
			//     return v38 > (float)(*(float *)&v15 + (float)(fabs(*(float *)&v31) * *(float *)(v37 + 8)));
			//   }
			// }
			// 
			return default(bool);
		}

		public static bool InRange(float val, float min, float max)
		{
			// // Boolean InRange(Single, Single, Single)
			// bool HG::Rendering::HgMath::HgMathf::InRange(float val, float min, float max, MethodInfo *method)
			// {
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   result = IFix::WrappersManagerImpl::IsPatched(341, 0LL);
			//   if ( result )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(341, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_155(Patch, val, min, max, 0LL);
			//   }
			//   else if ( val >= min )
			//   {
			//     return max >= val;
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public static bool MeshConvexTest(Mesh.MeshData meshData, [MetadataOffset(Offset = "0x01F90A2B")] float sizeTolerance = 0f, [MetadataOffset(Offset = "0x01F90A2F")] float planeTolerance = 0.1f)
		{
			// // Boolean MeshConvexTest(Mesh+MeshData, Single, Single)
			// // Hidden C++ exception states: #wind=2
			// bool HG::Rendering::HgMath::HgMathf::MeshConvexTest(
			//         Mesh_MeshData meshData,
			//         float sizeTolerance,
			//         float planeTolerance,
			//         MethodInfo *method)
			// {
			//   float v4; // xmm13_4
			//   float v5; // xmm12_4
			//   int v7; // ebx
			//   int32_t v8; // edi
			//   int32_t v9; // r15d
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   List_1_System_Int32_ *v13; // r14
			//   Animator *v14; // rdx
			//   int32_t v15; // r8d
			//   MethodInfo *v16; // r9
			//   __m128 x; // xmm0
			//   __m128 y; // xmm1
			//   __m128 y_low; // xmm2
			//   __m128 x_low; // xmm0
			//   float v21; // xmm8_4
			//   __int64 *v22; // rdx
			//   Void *m_Buffer; // rcx
			//   __m128 v24; // xmm1
			//   __m128 v25; // xmm0
			//   double v26; // xmm0_8
			//   int32_t v27; // ebx
			//   SubMeshDescriptor *SubMesh; // rax
			//   IEnumerable_1_System_Int32_ *v29; // rax
			//   int v30; // r12d
			//   int v31; // r13d
			//   RegexCharClass_SingleRange Item; // eax
			//   __int64 v33; // rbx
			//   RegexCharClass_SingleRange v34; // eax
			//   __int64 v35; // rdi
			//   float v36; // esi
			//   __int64 v37; // r8
			//   float v38; // xmm3_4
			//   float v39; // xmm0_4
			//   float v40; // xmm9_4
			//   float v41; // xmm11_4
			//   __m128 v42; // xmm3
			//   __m128 v43; // xmm1
			//   float v44; // xmm2_4
			//   __int64 v45; // rax
			//   __m128 v46; // xmm3
			//   __m128 v47; // xmm1
			//   __int64 v48; // rax
			//   __m128 v49; // xmm5
			//   __m128 v50; // xmm4
			//   __int64 v51; // rax
			//   LowLevelList_1_System_Object_ *v52; // rax
			//   int32_t v53; // esi
			//   __int64 v54; // rbx
			//   __int64 v55; // rax
			//   __int64 v56; // rcx
			//   __int64 v57; // rdx
			//   Void *v58; // rdi
			//   __m128 v59; // xmm7
			//   __m128 v60; // xmm10
			//   float v61; // xmm11_4
			//   __int64 v62; // rax
			//   MethodInfo *v63; // rdx
			//   float v64; // xmm0_4
			//   float v65; // xmm9_4
			//   float v66; // xmm6_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v69; // rdx
			//   __int64 v70; // rcx
			//   __int64 v71; // [rsp+0h] [rbp-2D8h] BYREF
			//   float v72; // [rsp+30h] [rbp-2A8h]
			//   float v73; // [rsp+34h] [rbp-2A4h]
			//   Vector3 v74; // [rsp+38h] [rbp-2A0h]
			//   unsigned __int64 v75; // [rsp+48h] [rbp-290h] BYREF
			//   float v76; // [rsp+50h] [rbp-288h]
			//   __int64 v77; // [rsp+58h] [rbp-280h]
			//   __int64 v78; // [rsp+60h] [rbp-278h]
			//   __int64 v79; // [rsp+68h] [rbp-270h]
			//   NativeArray_1_UnityEngine_Vector3_ v80; // [rsp+70h] [rbp-268h] BYREF
			//   __int64 v81; // [rsp+80h] [rbp-258h]
			//   float v82; // [rsp+88h] [rbp-250h]
			//   List_1_System_Int32_ *v83; // [rsp+90h] [rbp-248h]
			//   NativeArray_1_T_ReadOnly_T_Enumerator_BeyondDynamicBone_StepReductionBase_JoinEdge_ v84; // [rsp+A0h] [rbp-238h] BYREF
			//   NativeArray_1_T_ReadOnly_T_Enumerator_BeyondDynamicBone_StepReductionBase_JoinEdge_ v85; // [rsp+D0h] [rbp-208h] BYREF
			//   float v86[4]; // [rsp+F0h] [rbp-1E8h]
			//   NativeArray_1_System_Int32_ v87; // [rsp+100h] [rbp-1D8h] BYREF
			//   Vector3 v88; // [rsp+110h] [rbp-1C8h] BYREF
			//   float v89[4]; // [rsp+120h] [rbp-1B8h]
			//   float v90[4]; // [rsp+130h] [rbp-1A8h]
			//   float v91[4]; // [rsp+140h] [rbp-198h]
			//   float v92[4]; // [rsp+150h] [rbp-188h]
			//   float v93[4]; // [rsp+160h] [rbp-178h]
			//   float v94[4]; // [rsp+170h] [rbp-168h]
			//   float v95[4]; // [rsp+180h] [rbp-158h]
			//   float v96[4]; // [rsp+190h] [rbp-148h]
			//   float v97[4]; // [rsp+1A0h] [rbp-138h]
			//   unsigned __int64 v98; // [rsp+1B0h] [rbp-128h] BYREF
			//   float v99; // [rsp+1B8h] [rbp-120h]
			//   Il2CppExceptionWrapper *v100; // [rsp+1C0h] [rbp-118h] BYREF
			//   Il2CppExceptionWrapper *v101; // [rsp+1C8h] [rbp-110h] BYREF
			//   _BYTE v102[16]; // [rsp+1D0h] [rbp-108h] BYREF
			//   _BYTE v103[16]; // [rsp+1E0h] [rbp-F8h] BYREF
			//   SubMeshDescriptor v104[3]; // [rsp+1F0h] [rbp-E8h] BYREF
			//   Mesh_MeshData v105; // [rsp+2E0h] [rbp+8h] BYREF
			//   float v106; // [rsp+2E8h] [rbp+10h]
			//   float v107; // [rsp+2F0h] [rbp+18h]
			// 
			//   v107 = planeTolerance;
			//   v106 = sizeTolerance;
			//   v105.m_Ptr = meshData.m_Ptr;
			//   v4 = planeTolerance;
			//   v5 = sizeTolerance;
			//   if ( !byte_18D9193C1 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::Vector3>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::Vector3>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::AddRange);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<float>);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector3>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector3>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::ToArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector3>::NativeArray);
			//     byte_18D9193C1 = 1;
			//   }
			//   v80 = 0LL;
			//   v87 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(344, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(344, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v70, v69);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_158(Patch, meshData, sizeTolerance, planeTolerance, 0LL);
			//   }
			//   *(float *)&v7 = COERCE_FLOAT(UnityEngine::Mesh::MeshData::get_vertexCount(&v105, 0LL));
			//   v72 = *(float *)&v7;
			//   if ( v7 <= 3 )
			//     return 0;
			//   *(float *)&v8 = COERCE_FLOAT(UnityEngine::Mesh::MeshData::get_subMeshCount(&v105, 0LL));
			//   v73 = *(float *)&v8;
			//   v9 = 2;
			//   Unity::Collections::NativeArray<UnityEngine::Vector3>::NativeArray(
			//     &v80,
			//     v7,
			//     Allocator__Enum_Temp,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector3>::NativeArray);
			//   v84.m_Array = (NativeArray_1_T_ReadOnly_BeyondDynamicBone_StepReductionBase_JoinEdge_)v80;
			//   UnityEngine::Mesh::MeshData::GetVertices(&v105, (NativeArray_1_UnityEngine_Vector3_ *)&v84, 0LL);
			//   v10 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
			//   v13 = (List_1_System_Int32_ *)v10;
			//   if ( !v10 )
			//     sub_180B536AC(v12, v11);
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v10,
			//     MethodInfo::System::Collections::Generic::List<int>::List);
			//   v83 = v13;
			//   v74 = *UnityEngine::Animator::GetVector(&v88, v14, v15, v16);
			//   Unity::Collections::NativeArray_1_T_::ReadOnly<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::GetEnumerator(
			//     (NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v84,
			//     (NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v80,
			//     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector3>::GetEnumerator);
			//   v85 = v84;
			//   v84.m_Array.m_Buffer = 0LL;
			//   *(_QWORD *)&v84.m_Array.m_Length = &v85;
			//   try
			//   {
			//     while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<BeyondDynamicBone::StepReductionBase::JoinEdge>::MoveNext(
			//               &v85,
			//               MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext) )
			//     {
			//       x = (__m128)(unsigned int)v85.value.vertexPair.x;
			//       x.m128_f32[0] = *(float *)&v85.value.vertexPair.x + v74.x;
			//       y = (__m128)(unsigned int)v85.value.vertexPair.y;
			//       y.m128_f32[0] = *(float *)&v85.value.vertexPair.y + v74.y;
			//       *(_QWORD *)&v74.x = _mm_unpacklo_ps(x, y).m128_u64[0];
			//       v74.z = v85.value.cost + v74.z;
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v100 )
			//   {
			//     v84.m_Array.m_Buffer = (Void *)v100.ex;
			//     if ( v84.m_Array.m_Buffer )
			//       sub_18000F780(v84.m_Array.m_Buffer);
			//     v9 = 2;
			//     v4 = v107;
			//     v5 = v106;
			//     *(float *)&v7 = v72;
			//     *(float *)&v8 = v73;
			//     v13 = v83;
			//   }
			//   y_low = (__m128)LODWORD(v74.y);
			//   y_low.m128_f32[0] = v74.y / (float)v7;
			//   x_low = (__m128)LODWORD(v74.x);
			//   x_low.m128_f32[0] = v74.x / (float)v7;
			//   *(_QWORD *)&v74.x = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
			//   v74.z = v74.z / (float)v7;
			//   v21 = 0.0;
			//   v72 = 0.0;
			//   Unity::Collections::NativeArray_1_T_::ReadOnly<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::GetEnumerator(
			//     (NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v84,
			//     (NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v80,
			//     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector3>::GetEnumerator);
			//   v85 = v84;
			//   v84.m_Array.m_Buffer = 0LL;
			//   *(_QWORD *)&v84.m_Array.m_Length = &v85;
			//   try
			//   {
			//     while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<BeyondDynamicBone::StepReductionBase::JoinEdge>::MoveNext(
			//               &v85,
			//               MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext) )
			//     {
			//       v24 = (__m128)(unsigned int)v85.value.vertexPair.y;
			//       v24.m128_f32[0] = *(float *)&v85.value.vertexPair.y - v74.y;
			//       v25 = (__m128)(unsigned int)v85.value.vertexPair.x;
			//       v25.m128_f32[0] = *(float *)&v85.value.vertexPair.x - v74.x;
			//       v75 = _mm_unpacklo_ps(v25, v24).m128_u64[0];
			//       v76 = v85.value.cost - v74.z;
			//       v26 = sub_18238EFA0(&v75);
			//       if ( *(float *)&v26 > v21 )
			//       {
			//         v21 = *(float *)&v26;
			//         v72 = *(float *)&v26;
			//       }
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v101 )
			//   {
			//     v22 = &v71;
			//     v84.m_Array.m_Buffer = (Void *)v101.ex;
			//     m_Buffer = v84.m_Array.m_Buffer;
			//     if ( v84.m_Array.m_Buffer )
			//       sub_18000F780(v84.m_Array.m_Buffer);
			//     v9 = 2;
			//     v4 = v107;
			//     v5 = v106;
			//     *(float *)&v8 = v73;
			//     v13 = v83;
			//     v21 = v72;
			//   }
			//   v27 = 0;
			//   if ( v8 > 0 )
			//   {
			//     while ( 1 )
			//     {
			//       SubMesh = UnityEngine::Mesh::MeshData::GetSubMesh(v104, &v105, v27, 0LL);
			//       v84.m_Array = *(NativeArray_1_T_ReadOnly_BeyondDynamicBone_StepReductionBase_JoinEdge_ *)&SubMesh._bounds_k__BackingField.m_Center.x;
			//       *(_OWORD *)&v84.m_Index = *(_OWORD *)&SubMesh._bounds_k__BackingField.m_Extents.y;
			//       Unity::Collections::NativeArray<int>::NativeArray(
			//         &v87,
			//         _mm_cvtsi128_si32(*(__m128i *)&SubMesh._indexCount_k__BackingField),
			//         Allocator__Enum_Temp,
			//         NativeArrayOptions__Enum_ClearMemory,
			//         MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//       v84.m_Array = (NativeArray_1_T_ReadOnly_BeyondDynamicBone_StepReductionBase_JoinEdge_)v87;
			//       UnityEngine::Mesh::MeshData::GetIndices(&v105, (NativeArray_1_System_Int32_ *)&v84, v27, 1, 0LL);
			//       v29 = (IEnumerable_1_System_Int32_ *)Unity::Collections::NativeArray<MagicaCloth::TwistConstraint::TwistData>::ToArray(
			//                                              (NativeArray_1_MagicaCloth_TwistConstraint_TwistData_ *)&v87,
			//                                              MethodInfo::Unity::Collections::NativeArray<int>::ToArray);
			//       if ( !v13 )
			//         break;
			//       System::Collections::Generic::List<int>::AddRange(
			//         v13,
			//         v29,
			//         MethodInfo::System::Collections::Generic::List<int>::AddRange);
			//       Unity::Collections::NativeArray<int>::Dispose(&v87, MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//       if ( ++v27 >= v8 )
			//         goto LABEL_22;
			//     }
			// LABEL_46:
			//     sub_1802DC2C8(m_Buffer, v22);
			//   }
			//   if ( !v13 )
			//     goto LABEL_46;
			// LABEL_22:
			//   v30 = v13.fields._size / 3;
			//   v31 = 0;
			//   if ( v30 <= 0 )
			//   {
			// LABEL_40:
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&v80,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector3>::Dispose);
			//     return 1;
			//   }
			//   while ( 1 )
			//   {
			//     Item = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//              (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)v13,
			//              v9 - 2,
			//              MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     v33 = (int)Item;
			//     LODWORD(v77) = Item;
			//     v34 = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//             (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)v13,
			//             v9 - 1,
			//             MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     v35 = (int)v34;
			//     LODWORD(v78) = v34;
			//     LODWORD(v79) = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                      (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)v13,
			//                      v9,
			//                      MethodInfo::System::Collections::Generic::List<int>::get_Item);
			//     *(_QWORD *)v94 = *(_QWORD *)&v80.m_Buffer[12 * v33];
			//     v36 = *(float *)&v80.m_Buffer[12 * v33 + 8];
			//     v37 = 3 * v35;
			//     *(_QWORD *)v95 = *(_QWORD *)&v80.m_Buffer[12 * (int)v79];
			//     LODWORD(v35) = *(_DWORD *)&v80.m_Buffer[12 * (int)v79 + 8];
			//     *(_QWORD *)v89 = *(_QWORD *)&v80.m_Buffer[4 * v37];
			//     *(_QWORD *)v90 = *(_QWORD *)&v80.m_Buffer[12 * v33];
			//     v38 = *(float *)&v80.m_Buffer[4 * v37 + 8] + *(float *)&v80.m_Buffer[12 * v33 + 8];
			//     *(_QWORD *)v91 = *(_QWORD *)&v80.m_Buffer[12 * (int)v79];
			//     v39 = *(float *)&v80.m_Buffer[12 * (int)v79 + 8] + v38;
			//     v40 = (float)(v91[0] + (float)(v89[0] + v90[0])) / 3.0;
			//     v73 = v40;
			//     v41 = (float)(v91[1] + (float)(v89[1] + v90[1])) / 3.0;
			//     v72 = v41;
			//     *(float *)&v83 = v39 / 3.0;
			//     *(_QWORD *)v93 = *(_QWORD *)&v80.m_Buffer[4 * v37];
			//     *(_QWORD *)v92 = *(_QWORD *)&v80.m_Buffer[12 * v33];
			//     v42 = (__m128)LODWORD(v92[0]);
			//     v42.m128_f32[0] = v92[0] - v93[0];
			//     v43 = (__m128)LODWORD(v92[1]);
			//     v43.m128_f32[0] = v92[1] - v93[1];
			//     v44 = *(float *)&v80.m_Buffer[12 * v33 + 8] - *(float *)&v80.m_Buffer[4 * v37 + 8];
			//     v75 = _mm_unpacklo_ps(v42, v43).m128_u64[0];
			//     v76 = v44;
			//     v45 = sub_182413270(v102, &v75);
			//     *(_QWORD *)v86 = *(_QWORD *)v45;
			//     LODWORD(v33) = *(_DWORD *)(v45 + 8);
			//     v46 = (__m128)LODWORD(v94[0]);
			//     v46.m128_f32[0] = v94[0] - v95[0];
			//     v47 = (__m128)LODWORD(v94[1]);
			//     v47.m128_f32[0] = v94[1] - v95[1];
			//     v75 = _mm_unpacklo_ps(v46, v47).m128_u64[0];
			//     v76 = v36 - *(float *)&v35;
			//     v48 = sub_182413270(v103, &v75);
			//     *(_QWORD *)v96 = *(_QWORD *)v48;
			//     v49 = (__m128)*(unsigned int *)(v48 + 8);
			//     v49.m128_f32[0] = (float)(v49.m128_f32[0] * v86[1]) - (float)(v96[1] * *(float *)&v33);
			//     v50 = (__m128)LODWORD(v96[0]);
			//     v50.m128_f32[0] = (float)(v96[0] * *(float *)&v33) - (float)(*(float *)(v48 + 8) * v86[0]);
			//     v75 = _mm_unpacklo_ps(v49, v50).m128_u64[0];
			//     v76 = (float)(v96[1] * v86[0]) - (float)(v96[0] * v86[1]);
			//     v51 = sub_182413270(&v84, &v75);
			//     v81 = *(_QWORD *)v51;
			//     v82 = *(float *)(v51 + 8);
			//     v52 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<float>);
			//     *(_QWORD *)&v74.x = v52;
			//     if ( !v52 )
			//       goto LABEL_46;
			//     System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//       v52,
			//       MethodInfo::System::Collections::Generic::List<float>::List);
			//     v53 = 0;
			//     v54 = 0LL;
			//     if ( v80.m_Length > 0 )
			//       break;
			// LABEL_39:
			//     ++v31;
			//     v9 += 3;
			//     if ( v31 >= v30 )
			//       goto LABEL_40;
			//   }
			//   v55 = (int)v77;
			//   v77 = (int)v77;
			//   v56 = (int)v78;
			//   v78 = (int)v78;
			//   v57 = (int)v79;
			//   v79 = (int)v79;
			//   v58 = v80.m_Buffer;
			//   while ( 1 )
			//   {
			//     if ( v54 == v55 || v54 == v56 || v54 == v57 )
			//       goto LABEL_38;
			//     *(_QWORD *)v97 = *(_QWORD *)v58;
			//     v59 = (__m128)LODWORD(v97[0]);
			//     v59.m128_f32[0] = v97[0] - v40;
			//     v60 = (__m128)LODWORD(v97[1]);
			//     v60.m128_f32[0] = v97[1] - v41;
			//     v61 = *(float *)&v58[8] - *(float *)&v83;
			//     v98 = _mm_unpacklo_ps(v59, v60).m128_u64[0];
			//     v99 = v61;
			//     v62 = sub_182413270(&v87, &v98);
			//     *(_QWORD *)&v88.x = *(_QWORD *)v62;
			//     v64 = (float)((float)(v88.y * *((float *)&v81 + 1)) + (float)(v88.x * *(float *)&v81))
			//         + (float)(*(float *)(v62 + 8) * v82);
			//     if ( v4 < fabs(v64) )
			//       break;
			// LABEL_37:
			//     v57 = v79;
			//     v56 = v78;
			//     v55 = v77;
			//     v41 = v72;
			// LABEL_38:
			//     ++v53;
			//     ++v54;
			//     v58 += 12;
			//     if ( v53 >= v80.m_Length )
			//       goto LABEL_39;
			//   }
			//   v65 = UnityEngine::Mathf::Sign(v64, v63);
			//   if ( !*(_DWORD *)(*(_QWORD *)&v74.x + 24LL) )
			//   {
			//     sub_1824B31B0(*(List_1_System_Single_ **)&v74.x);
			// LABEL_36:
			//     v40 = v73;
			//     goto LABEL_37;
			//   }
			//   v66 = System::Collections::Generic::List<float>::get_Item(
			//           *(List_1_System_Single_ **)&v74.x,
			//           0,
			//           MethodInfo::System::Collections::Generic::List<float>::get_Item);
			//   sub_180002C70(TypeInfo::System::Math);
			//   if ( fabs(v65 - v66) <= 0.0099999998
			//     || (float)(fabs(
			//                  (float)((float)(v59.m128_f32[0] * *(float *)&v81) + (float)(v60.m128_f32[0] * *((float *)&v81 + 1)))
			//                + (float)(v61 * v82))
			//              / v21) <= v5 )
			//   {
			//     goto LABEL_36;
			//   }
			//   Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//     (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&v80,
			//     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector3>::Dispose);
			//   return 0;
			// }
			// 
			return default(bool);
		}
	}
}
