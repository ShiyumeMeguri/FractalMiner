using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	public struct Frustum
	{
		private static Vector3 IntersectFrustumPlanes(Plane p0, Plane p1, Plane p2)
		{
			// // Vector3 IntersectFrustumPlanes(Plane, Plane, Plane)
			// Vector3 *HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
			//         Vector3 *__return_ptr retstr,
			//         Plane *p0,
			//         Plane *p1,
			//         Plane *p2,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   float z; // eax
			//   __int64 v12; // xmm0_8
			//   float v13; // eax
			//   __int64 v14; // xmm0_8
			//   float v15; // eax
			//   Vector3 *v16; // rax
			//   __int64 v17; // xmm0_8
			//   __int64 v18; // xmm4_8
			//   MethodInfo *v19; // r9
			//   Vector3 *v20; // rax
			//   __int64 v21; // xmm0_8
			//   float m_Distance; // xmm2_4
			//   MethodInfo *v23; // r9
			//   MethodInfo *v24; // rax
			//   __int64 v25; // xmm3_8
			//   __int64 v26; // xmm0_8
			//   Vector3 *v27; // rax
			//   __int64 v28; // xmm0_8
			//   float v29; // xmm2_4
			//   MethodInfo *v30; // r9
			//   Vector3 *v31; // rax
			//   __int64 v32; // r9
			//   __int64 v33; // xmm3_8
			//   MethodInfo *v34; // rax
			//   __int64 v35; // xmm3_8
			//   __int64 v36; // xmm0_8
			//   Vector3 *v37; // rax
			//   __int64 v38; // xmm0_8
			//   float v39; // xmm2_4
			//   MethodInfo *v40; // r9
			//   Vector3 *v41; // rax
			//   __int64 v42; // r9
			//   __int64 v43; // xmm3_8
			//   Vector3 *v44; // rax
			//   __int64 v45; // xmm3_8
			//   MethodInfo *v46; // r8
			//   MethodInfo *v47; // r9
			//   Vector3 *v48; // rax
			//   __int64 v49; // xmm0_8
			//   float v50; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Plane v53; // xmm1
			//   Plane v54; // xmm0
			//   Vector3 v55; // [rsp+30h] [rbp-11h] BYREF
			//   Vector3 v56; // [rsp+40h] [rbp-1h] BYREF
			//   Plane v57; // [rsp+50h] [rbp+Fh] BYREF
			//   Vector3 v58; // [rsp+60h] [rbp+1Fh] BYREF
			//   Plane v59; // [rsp+70h] [rbp+2Fh] BYREF
			//   Plane v60; // [rsp+80h] [rbp+3Fh] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, p0);
			//     v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v9.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 386 )
			//   {
			//     if ( !v9._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v9, wrapperArray);
			//       v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v9 = (struct ILFixDynamicMethodWrapper_2__Class *)v9.static_fields.wrapperArray;
			//     if ( v9 )
			//     {
			//       if ( LODWORD(v9._0.namespaze) <= 0x182 )
			//         sub_180070270(v9, wrapperArray);
			//       if ( !v9[8]._0.interopData )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(386, 0LL);
			//       if ( Patch )
			//       {
			//         v53 = *p1;
			//         v60 = *p2;
			//         v54 = *p0;
			//         v59 = v53;
			//         v57 = v54;
			//         v48 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_180(&v58, Patch, &v57, &v59, &v60, 0LL);
			//         goto LABEL_8;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v9, wrapperArray);
			//   }
			// LABEL_7:
			//   z = p1.m_Normal.z;
			//   *(_QWORD *)&v55.x = *(_QWORD *)&p1.m_Normal.x;
			//   v12 = *(_QWORD *)&p0.m_Normal.x;
			//   v55.z = z;
			//   v13 = p0.m_Normal.z;
			//   *(_QWORD *)&v56.x = v12;
			//   v14 = *(_QWORD *)&p2.m_Normal.x;
			//   v56.z = v13;
			//   v15 = p2.m_Normal.z;
			//   *(_QWORD *)&v57.m_Normal.x = v14;
			//   v57.m_Normal.z = v15;
			//   v16 = UnityEngine::Vector3::Cross(&v59.m_Normal, &v56, &v55, (MethodInfo *)p2);
			//   *(_QWORD *)&v56.x = *(_QWORD *)&p1.m_Normal.x;
			//   v17 = *(_QWORD *)&p2.m_Normal.x;
			//   v18 = *(_QWORD *)&v16.x;
			//   v58.z = v16.z;
			//   v56.z = p1.m_Normal.z;
			//   v55.z = p2.m_Normal.z;
			//   *(_QWORD *)&v58.x = v18;
			//   *(_QWORD *)&v55.x = v17;
			//   v20 = UnityEngine::Vector3::Cross(&v59.m_Normal, &v55, &v56, v19);
			//   v21 = *(_QWORD *)&v20.x;
			//   *(float *)&v20 = v20.z;
			//   m_Distance = p0.m_Distance;
			//   *(_QWORD *)&v56.x = v21;
			//   LODWORD(v56.z) = (_DWORD)v20;
			//   v24 = (MethodInfo *)UnityEngine::Vector3::op_Multiply(&v59.m_Normal, &v56, m_Distance, v23);
			//   v25 = *(_QWORD *)&p2.m_Normal.x;
			//   v26 = *(_QWORD *)&p0.m_Normal.x;
			//   v56.z = p2.m_Normal.z;
			//   v55.z = p0.m_Normal.z;
			//   *(_QWORD *)&v56.x = v25;
			//   *(_QWORD *)&v55.x = v26;
			//   v27 = UnityEngine::Vector3::Cross(&v60.m_Normal, &v55, &v56, v24);
			//   v28 = *(_QWORD *)&v27.x;
			//   *(float *)&v27 = v27.z;
			//   v29 = p1.m_Distance;
			//   *(_QWORD *)&v56.x = v28;
			//   LODWORD(v56.z) = (_DWORD)v27;
			//   v31 = UnityEngine::Vector3::op_Multiply(&v60.m_Normal, &v56, v29, v30);
			//   *(_QWORD *)&v55.x = *(_QWORD *)v32;
			//   v33 = *(_QWORD *)&v31.x;
			//   v56.z = v31.z;
			//   v55.z = *(float *)(v32 + 8);
			//   *(_QWORD *)&v56.x = v33;
			//   v34 = (MethodInfo *)UnityEngine::Vector3::op_Addition(&v60.m_Normal, &v55, &v56, (MethodInfo *)v32);
			//   v35 = *(_QWORD *)&p1.m_Normal.x;
			//   v36 = *(_QWORD *)&p0.m_Normal.x;
			//   v56.z = p1.m_Normal.z;
			//   v55.z = p0.m_Normal.z;
			//   *(_QWORD *)&v56.x = v35;
			//   *(_QWORD *)&v55.x = v36;
			//   v37 = UnityEngine::Vector3::Cross(&v59.m_Normal, &v55, &v56, v34);
			//   v38 = *(_QWORD *)&v37.x;
			//   *(float *)&v37 = v37.z;
			//   v39 = p2.m_Distance;
			//   *(_QWORD *)&v56.x = v38;
			//   LODWORD(v56.z) = (_DWORD)v37;
			//   v41 = UnityEngine::Vector3::op_Multiply(&v59.m_Normal, &v56, v39, v40);
			//   *(_QWORD *)&v55.x = *(_QWORD *)v42;
			//   v43 = *(_QWORD *)&v41.x;
			//   v56.z = v41.z;
			//   v55.z = *(float *)(v42 + 8);
			//   *(_QWORD *)&v56.x = v43;
			//   v44 = UnityEngine::Vector3::op_Subtraction(&v60.m_Normal, &v55, &v56, (MethodInfo *)v42);
			//   v45 = *(_QWORD *)&v44.x;
			//   *(float *)&v44 = v44.z;
			//   *(_QWORD *)&v56.x = v45;
			//   LODWORD(v56.z) = (_DWORD)v44;
			//   *(float *)&v38 = UnityEngine::Vector3::Dot(&v58, &v57.m_Normal, v46);
			//   v48 = UnityEngine::Vector3::op_Multiply(&v60.m_Normal, &v56, 1.0 / *(float *)&v38, v47);
			// LABEL_8:
			//   v49 = *(_QWORD *)&v48.x;
			//   v50 = v48.z;
			//   *(_QWORD *)&retstr.x = v49;
			//   retstr.z = v50;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static void Create(ref Frustum frustum, Matrix4x4 viewProjMatrix, Vector3 viewPos, Vector3 viewDir, float nearClipPlane, float farClipPlane)
		{
			// // Void Create(Frustum ByRef, Matrix4x4, Vector3, Vector3, Single, Single)
			// void HG::Rendering::Runtime::Frustum::Create(
			//         Frustum *frustum,
			//         Matrix4x4 *viewProjMatrix,
			//         Vector3 *viewPos,
			//         Vector3 *viewDir,
			//         float nearClipPlane,
			//         float farClipPlane,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v11; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Plane__Array *planes; // rsi
			//   void (__fastcall *v14)(Plane__Array *, Matrix4x4 *); // rax
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm1
			//   __int64 v17; // rdx
			//   MethodInfo *v18; // r8
			//   char v19; // di
			//   struct Math__Class *v20; // rcx
			//   __m128 y_low; // xmm2
			//   __m128d v22; // xmm3
			//   double v23; // xmm0_8
			//   float v24; // xmm4_4
			//   __m128i z_low; // xmm1
			//   __m128 v26; // xmm2
			//   int v27; // r12d
			//   float z; // eax
			//   __int64 v29; // xmm0_8
			//   float v30; // eax
			//   float v31; // eax
			//   float v32; // xmm8_4
			//   MethodInfo *v33; // r8
			//   Vector3 *v34; // rax
			//   __int64 v35; // rdx
			//   __int64 v36; // r8
			//   __int64 v37; // xmm10_8
			//   float v38; // r14d
			//   struct Math__Class *v39; // rcx
			//   __m128 v40; // xmm2
			//   __m128d v41; // xmm3
			//   double v42; // xmm0_8
			//   float v43; // xmm3_4
			//   __m128 x_low; // xmm0
			//   __m128 v45; // xmm1
			//   __m128i v46; // xmm2
			//   unsigned __int64 v47; // xmm0_8
			//   unsigned __int64 v48; // r8
			//   float v49; // eax
			//   float v50; // r8d
			//   float v51; // xmm0_4
			//   Plane__Array *v52; // rax
			//   float v53; // xmm3_4
			//   Plane v54; // xmm0
			//   float x; // xmm1_4
			//   Plane__Array *v56; // rax
			//   Plane__Array *v57; // rax
			//   Vector3__Array *corners; // rsi
			//   Plane v59; // xmm1
			//   Plane v60; // xmm0
			//   Vector3 *v61; // rax
			//   Plane__Array *v62; // rax
			//   Vector3__Array *v63; // rsi
			//   Plane v64; // xmm1
			//   Plane v65; // xmm0
			//   Vector3 *v66; // rax
			//   Plane__Array *v67; // rax
			//   Vector3__Array *v68; // rsi
			//   Plane v69; // xmm1
			//   Plane v70; // xmm0
			//   Vector3 *v71; // rax
			//   Plane__Array *v72; // rax
			//   Vector3__Array *v73; // rsi
			//   Plane v74; // xmm1
			//   Plane v75; // xmm0
			//   Vector3 *v76; // rax
			//   Plane__Array *v77; // rax
			//   Vector3__Array *v78; // rsi
			//   Plane v79; // xmm1
			//   Plane v80; // xmm0
			//   Vector3 *v81; // rax
			//   Plane__Array *v82; // rax
			//   Vector3__Array *v83; // rsi
			//   Plane v84; // xmm1
			//   Plane v85; // xmm0
			//   Vector3 *v86; // rax
			//   Plane__Array *v87; // rax
			//   Vector3__Array *v88; // rsi
			//   Plane v89; // xmm1
			//   Plane v90; // xmm0
			//   Vector3 *v91; // rax
			//   Plane__Array *v92; // rax
			//   Vector3__Array *v93; // rsi
			//   Plane v94; // xmm1
			//   Plane v95; // xmm0
			//   Vector3 *v96; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v98; // xmm1
			//   float v99; // ecx
			//   __int128 v100; // xmm0
			//   float v101; // ecx
			//   __int128 v102; // xmm0
			//   __int128 v103; // xmm1
			//   __int64 v104; // rax
			//   __int64 v105; // rax
			//   ArgumentException *v106; // rdi
			//   String *v107; // rbx
			//   String *v108; // rax
			//   __int64 v109; // rax
			//   __int64 v110; // rax
			//   ArgumentNullException *v111; // rbx
			//   String *v112; // rax
			//   __int64 v113; // rax
			//   Plane v114; // [rsp+40h] [rbp-C0h] BYREF
			//   Plane v115; // [rsp+50h] [rbp-B0h] BYREF
			//   Plane v116; // [rsp+60h] [rbp-A0h] BYREF
			//   Plane v117; // [rsp+70h] [rbp-90h] BYREF
			//   Matrix4x4 v118; // [rsp+80h] [rbp-80h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, viewProjMatrix);
			//     v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v11.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_65;
			//   if ( wrapperArray.max_length.size <= 387 )
			//     goto LABEL_7;
			//   if ( !v11._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v11, wrapperArray);
			//     v11 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v11.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_65;
			//   if ( wrapperArray.max_length.size <= 0x183u )
			//     goto LABEL_70;
			//   if ( !wrapperArray[10].vector[27] )
			//   {
			// LABEL_7:
			//     planes = frustum.planes;
			//     if ( frustum.planes )
			//     {
			//       if ( planes.max_length.size == 6 )
			//       {
			//         v14 = (void (__fastcall *)(Plane__Array *, Matrix4x4 *))qword_18D8F4368;
			//         v15 = *(_OWORD *)&viewProjMatrix.m01;
			//         *(_OWORD *)&v118.m00 = *(_OWORD *)&viewProjMatrix.m00;
			//         *(_OWORD *)&v118.m01 = v15;
			//         v16 = *(_OWORD *)&viewProjMatrix.m03;
			//         *(_OWORD *)&v118.m02 = *(_OWORD *)&viewProjMatrix.m02;
			//         *(_OWORD *)&v118.m03 = v16;
			//         if ( !qword_18D8F4368 )
			//         {
			//           v14 = (void (__fastcall *)(Plane__Array *, Matrix4x4 *))il2cpp_resolve_icall_0(
			//                                                                     "UnityEngine.GeometryUtility::Internal_ExtractPlanes_"
			//                                                                     "Injected(UnityEngine.Plane[],UnityEngine.Matrix4x4&)");
			//           if ( !v14 )
			//           {
			//             v104 = sub_1802DBBE8(
			//                      "UnityEngine.GeometryUtility::Internal_ExtractPlanes_Injected(UnityEngine.Plane[],UnityEngine.Matrix4x4&)");
			//             sub_18000F750(v104, 0LL);
			//           }
			//           qword_18D8F4368 = (__int64)v14;
			//         }
			//         v14(planes, &v118);
			//         v19 = byte_18D8E3A70;
			//         *(_QWORD *)&v114.m_Normal.x = *(_QWORD *)&viewDir.x;
			//         if ( !byte_18D8E3A70 )
			//         {
			//           sub_18003C530(&TypeInfo::System::Math);
			//           v19 = 1;
			//           byte_18D8E3A70 = 1;
			//         }
			//         v20 = TypeInfo::System::Math;
			//         if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::System::Math, v17);
			//           v19 = byte_18D8E3A70;
			//         }
			//         y_low = (__m128)LODWORD(v114.m_Normal.y);
			//         y_low.m128_f32[0] = (float)((float)(y_low.m128_f32[0] * y_low.m128_f32[0])
			//                                   + (float)(v114.m_Normal.x * v114.m_Normal.x))
			//                           + (float)(viewDir.z * viewDir.z);
			//         v22 = _mm_cvtps_pd(y_low);
			//         if ( v22.m128d_f64[0] < 0.0 )
			//           v23 = sub_1801C22C0(v20, v17, v18);
			//         else
			//           *(_QWORD *)&v23 = *(_OWORD *)&_mm_sqrt_pd(v22);
			//         v24 = v23;
			//         if ( v24 <= 0.0000099999997 )
			//         {
			//           v27 = _mm_cvtsi128_si32((__m128i)0LL);
			//           *(_QWORD *)&v116.m_Normal.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         }
			//         else
			//         {
			//           z_low = (__m128i)LODWORD(viewDir.z);
			//           v26 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&viewDir.x, (__m128)*(unsigned __int64 *)&viewDir.x, 85);
			//           v26.m128_f32[0] = v26.m128_f32[0] / v24;
			//           *(_QWORD *)&v117.m_Normal.x = *(_QWORD *)&viewDir.x;
			//           *(float *)z_low.m128i_i32 = *(float *)z_low.m128i_i32 / v24;
			//           *(_QWORD *)&v116.m_Normal.x = _mm_unpacklo_ps((__m128)*(unsigned __int64 *)&v117.m_Normal.x, v26).m128_u64[0];
			//           v27 = _mm_cvtsi128_si32(z_low);
			//         }
			//         z = viewPos.z;
			//         *(_QWORD *)&v114.m_Normal.x = *(_QWORD *)&viewPos.x;
			//         v29 = *(_QWORD *)&viewDir.x;
			//         v114.m_Normal.z = z;
			//         v30 = viewDir.z;
			//         *(_QWORD *)&v115.m_Normal.x = v29;
			//         v115.m_Normal.z = v30;
			//         *(float *)&v29 = UnityEngine::Vector3::Dot(&v115.m_Normal, &v114.m_Normal, v18);
			//         *(_QWORD *)&v115.m_Normal.x = *(_QWORD *)&viewDir.x;
			//         v115.m_Normal.z = v31;
			//         v32 = (float)-*(float *)&v29 - nearClipPlane;
			//         v34 = UnityEngine::Vector3::op_UnaryNegation(&v117.m_Normal, &v115.m_Normal, v33);
			//         v37 = *(_QWORD *)&v34.x;
			//         v38 = v34.z;
			//         *(_QWORD *)&v114.m_Normal.x = v37;
			//         *(_QWORD *)&v115.m_Normal.x = v37;
			//         if ( !v19 )
			//         {
			//           sub_18003C530(&TypeInfo::System::Math);
			//           byte_18D8E3A70 = 1;
			//         }
			//         v39 = TypeInfo::System::Math;
			//         if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::System::Math, v35);
			//         v40 = (__m128)LODWORD(v115.m_Normal.y);
			//         v40.m128_f32[0] = (float)((float)(v40.m128_f32[0] * v40.m128_f32[0]) + (float)(v115.m_Normal.x * v115.m_Normal.x))
			//                         + (float)(v38 * v38);
			//         v41 = _mm_cvtps_pd(v40);
			//         if ( v41.m128d_f64[0] < 0.0 )
			//           v42 = sub_1801C22C0(v39, v35, v36);
			//         else
			//           *(_QWORD *)&v42 = *(_OWORD *)&_mm_sqrt_pd(v41);
			//         v43 = v42;
			//         if ( v43 <= 0.0000099999997 )
			//         {
			//           v48 = (unsigned int)_mm_cvtsi128_si32((__m128i)0LL);
			//           v47 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//         }
			//         else
			//         {
			//           x_low = (__m128)LODWORD(v114.m_Normal.x);
			//           v45 = (__m128)LODWORD(v114.m_Normal.y);
			//           v46 = _mm_cvtsi32_si128(LODWORD(v38));
			//           x_low.m128_f32[0] = v114.m_Normal.x / v43;
			//           v45.m128_f32[0] = v114.m_Normal.y / v43;
			//           *(float *)v46.m128i_i32 = *(float *)v46.m128i_i32 / v43;
			//           v47 = _mm_unpacklo_ps(x_low, v45).m128_u64[0];
			//           v48 = (unsigned int)_mm_cvtsi128_si32(v46);
			//         }
			//         *(_QWORD *)&v114.m_Normal.x = v47;
			//         v49 = viewPos.z;
			//         *(_QWORD *)&v115.m_Normal.x = *(_QWORD *)&viewPos.x;
			//         v115.m_Normal.z = v49;
			//         *(_QWORD *)&v117.m_Normal.x = v37;
			//         v117.m_Normal.z = v38;
			//         v51 = UnityEngine::Vector3::Dot(&v117.m_Normal, &v115.m_Normal, (MethodInfo *)v48);
			//         v52 = frustum.planes;
			//         *(_QWORD *)&v117.m_Normal.z = __PAIR64__(LODWORD(v32), v27);
			//         *(_QWORD *)&v117.m_Normal.x = *(_QWORD *)&v116.m_Normal.x;
			//         v53 = farClipPlane - v51;
			//         if ( v52 )
			//         {
			//           if ( v52.max_length.size <= 4u )
			//             goto LABEL_70;
			//           v54 = v117;
			//           v117.m_Normal.z = v50;
			//           x = v114.m_Normal.x;
			//           v52.vector[4] = v54;
			//           v56 = frustum.planes;
			//           *(_QWORD *)&v117.m_Normal.x = __PAIR64__(LODWORD(v114.m_Normal.y), LODWORD(x));
			//           v117.m_Distance = v53;
			//           if ( v56 )
			//           {
			//             if ( v56.max_length.size <= 5u )
			//               goto LABEL_70;
			//             v56.vector[5] = v117;
			//             v57 = frustum.planes;
			//             corners = frustum.corners;
			//             if ( frustum.planes )
			//             {
			//               if ( v57.max_length.size <= 4u )
			//                 goto LABEL_70;
			//               v59 = v57.vector[3];
			//               v115 = v57.vector[4];
			//               v60 = v57.vector[0];
			//               v114 = v59;
			//               v116 = v60;
			//               v61 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(&v117.m_Normal, &v116, &v114, &v115, 0LL);
			//               if ( corners )
			//               {
			//                 if ( !corners.max_length.size )
			//                   goto LABEL_70;
			//                 *(_QWORD *)&corners.vector[0].x = *(_QWORD *)&v61.x;
			//                 corners.vector[0].z = v61.z;
			//                 v62 = frustum.planes;
			//                 v63 = frustum.corners;
			//                 if ( frustum.planes )
			//                 {
			//                   if ( v62.max_length.size <= 4u )
			//                     goto LABEL_70;
			//                   v64 = v62.vector[3];
			//                   v115 = v62.vector[4];
			//                   v65 = v62.vector[1];
			//                   v114 = v64;
			//                   v116 = v65;
			//                   v66 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
			//                           &v117.m_Normal,
			//                           &v116,
			//                           &v114,
			//                           &v115,
			//                           0LL);
			//                   if ( v63 )
			//                   {
			//                     if ( v63.max_length.size <= 1u )
			//                       goto LABEL_70;
			//                     *(_QWORD *)&v63.vector[1].x = *(_QWORD *)&v66.x;
			//                     v63.vector[1].z = v66.z;
			//                     v67 = frustum.planes;
			//                     v68 = frustum.corners;
			//                     if ( frustum.planes )
			//                     {
			//                       if ( v67.max_length.size <= 4u )
			//                         goto LABEL_70;
			//                       v69 = v67.vector[2];
			//                       v115 = v67.vector[4];
			//                       v70 = v67.vector[0];
			//                       v114 = v69;
			//                       v116 = v70;
			//                       v71 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
			//                               &v117.m_Normal,
			//                               &v116,
			//                               &v114,
			//                               &v115,
			//                               0LL);
			//                       if ( v68 )
			//                       {
			//                         if ( v68.max_length.size <= 2u )
			//                           goto LABEL_70;
			//                         *(_QWORD *)&v68.vector[2].x = *(_QWORD *)&v71.x;
			//                         v68.vector[2].z = v71.z;
			//                         v72 = frustum.planes;
			//                         v73 = frustum.corners;
			//                         if ( frustum.planes )
			//                         {
			//                           if ( v72.max_length.size <= 4u )
			//                             goto LABEL_70;
			//                           v74 = v72.vector[2];
			//                           v115 = v72.vector[4];
			//                           v75 = v72.vector[1];
			//                           v114 = v74;
			//                           v116 = v75;
			//                           v76 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
			//                                   &v117.m_Normal,
			//                                   &v116,
			//                                   &v114,
			//                                   &v115,
			//                                   0LL);
			//                           if ( v73 )
			//                           {
			//                             if ( v73.max_length.size <= 3u )
			//                               goto LABEL_70;
			//                             *(_QWORD *)&v73.vector[3].x = *(_QWORD *)&v76.x;
			//                             v73.vector[3].z = v76.z;
			//                             v77 = frustum.planes;
			//                             v78 = frustum.corners;
			//                             if ( frustum.planes )
			//                             {
			//                               if ( v77.max_length.size < 6u )
			//                                 goto LABEL_70;
			//                               v79 = v77.vector[3];
			//                               v115 = v77.vector[5];
			//                               v80 = v77.vector[0];
			//                               v114 = v79;
			//                               v116 = v80;
			//                               v81 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
			//                                       &v117.m_Normal,
			//                                       &v116,
			//                                       &v114,
			//                                       &v115,
			//                                       0LL);
			//                               if ( v78 )
			//                               {
			//                                 if ( v78.max_length.size <= 4u )
			//                                   goto LABEL_70;
			//                                 *(_QWORD *)&v78.vector[4].x = *(_QWORD *)&v81.x;
			//                                 v78.vector[4].z = v81.z;
			//                                 v82 = frustum.planes;
			//                                 v83 = frustum.corners;
			//                                 if ( frustum.planes )
			//                                 {
			//                                   if ( v82.max_length.size < 6u )
			//                                     goto LABEL_70;
			//                                   v84 = v82.vector[3];
			//                                   v115 = v82.vector[5];
			//                                   v85 = v82.vector[1];
			//                                   v114 = v84;
			//                                   v116 = v85;
			//                                   v86 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
			//                                           &v117.m_Normal,
			//                                           &v116,
			//                                           &v114,
			//                                           &v115,
			//                                           0LL);
			//                                   if ( v83 )
			//                                   {
			//                                     if ( v83.max_length.size <= 5u )
			//                                       goto LABEL_70;
			//                                     *(_QWORD *)&v83.vector[5].x = *(_QWORD *)&v86.x;
			//                                     v83.vector[5].z = v86.z;
			//                                     v87 = frustum.planes;
			//                                     v88 = frustum.corners;
			//                                     if ( frustum.planes )
			//                                     {
			//                                       if ( v87.max_length.size < 6u )
			//                                         goto LABEL_70;
			//                                       v89 = v87.vector[2];
			//                                       v115 = v87.vector[5];
			//                                       v90 = v87.vector[0];
			//                                       v114 = v89;
			//                                       v116 = v90;
			//                                       v91 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
			//                                               &v117.m_Normal,
			//                                               &v116,
			//                                               &v114,
			//                                               &v115,
			//                                               0LL);
			//                                       if ( v88 )
			//                                       {
			//                                         if ( v88.max_length.size <= 6u )
			//                                           goto LABEL_70;
			//                                         *(_QWORD *)&v88.vector[6].x = *(_QWORD *)&v91.x;
			//                                         v88.vector[6].z = v91.z;
			//                                         v92 = frustum.planes;
			//                                         v93 = frustum.corners;
			//                                         if ( frustum.planes )
			//                                         {
			//                                           if ( v92.max_length.size < 6u )
			//                                             goto LABEL_70;
			//                                           v94 = v92.vector[2];
			//                                           v115 = v92.vector[5];
			//                                           v95 = v92.vector[1];
			//                                           v114 = v94;
			//                                           v116 = v95;
			//                                           v96 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
			//                                                   &v117.m_Normal,
			//                                                   &v116,
			//                                                   &v114,
			//                                                   &v115,
			//                                                   0LL);
			//                                           if ( v93 )
			//                                           {
			//                                             if ( v93.max_length.size > 7u )
			//                                             {
			//                                               *(_QWORD *)&v93.vector[7].x = *(_QWORD *)&v96.x;
			//                                               v93.vector[7].z = v96.z;
			//                                               return;
			//                                             }
			// LABEL_70:
			//                                             sub_180070270(v11, wrapperArray);
			//                                           }
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//       else
			//       {
			//         v105 = sub_18003C530(&TypeInfo::System::ArgumentException);
			//         v106 = (ArgumentException *)sub_180004920(v105);
			//         if ( v106 )
			//         {
			//           v107 = (String *)sub_18003C530(&off_18D5B8960);
			//           v108 = (String *)sub_18003C530(&off_18D5B89B0);
			//           System::ArgumentException::ArgumentException(v106, v108, v107, 0LL);
			//           v109 = sub_18003C530(&MethodInfo::UnityEngine::GeometryUtility::CalculateFrustumPlanes);
			//           sub_18000F7C0(v106, v109);
			//         }
			//       }
			//     }
			//     else
			//     {
			//       v110 = sub_18003C530(&TypeInfo::System::ArgumentNullException);
			//       v111 = (ArgumentNullException *)sub_180004920(v110);
			//       if ( v111 )
			//       {
			//         v112 = (String *)sub_18003C530(&off_18D5B8960);
			//         System::ArgumentNullException::ArgumentNullException(v111, v112, 0LL);
			//         v113 = sub_18003C530(&MethodInfo::UnityEngine::GeometryUtility::CalculateFrustumPlanes);
			//         sub_18000F7C0(v111, v113);
			//       }
			//     }
			// LABEL_65:
			//     sub_180B536AC(v11, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(387, 0LL);
			//   if ( !Patch )
			//     goto LABEL_65;
			//   v98 = *(_OWORD *)&viewProjMatrix.m01;
			//   v99 = viewDir.z;
			//   *(_QWORD *)&v114.m_Normal.x = *(_QWORD *)&viewDir.x;
			//   *(_QWORD *)&v116.m_Normal.x = *(_QWORD *)&viewPos.x;
			//   v100 = *(_OWORD *)&viewProjMatrix.m00;
			//   v114.m_Normal.z = v99;
			//   v101 = viewPos.z;
			//   *(_OWORD *)&v118.m00 = v100;
			//   v102 = *(_OWORD *)&viewProjMatrix.m02;
			//   v116.m_Normal.z = v101;
			//   *(_OWORD *)&v118.m01 = v98;
			//   v103 = *(_OWORD *)&viewProjMatrix.m03;
			//   *(_OWORD *)&v118.m02 = v102;
			//   *(_OWORD *)&v118.m03 = v103;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_181(
			//     Patch,
			//     frustum,
			//     &v118,
			//     &v116.m_Normal,
			//     &v114.m_Normal,
			//     nearClipPlane,
			//     farClipPlane,
			//     0LL);
			// }
			// 
		}

		public Plane[] planes;

		public Vector3[] corners;
	}
}
