using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Burst;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[BurstCompile]
	public struct Frustum // TypeDefIndex: 37527
	{
		// Fields
		public Plane[] planes; // 0x00
		public Vector3[] corners; // 0x08
	
		// Methods
		private static Vector3 IntersectFrustumPlanes(Plane p0, Plane p1, Plane p2) => default; // 0x0000000183253440-0x00000001832537A0
		// Vector3 IntersectFrustumPlanes(Plane, Plane, Plane)
		Vector3 *HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
		        Vector3 *__return_ptr retstr,
		        Plane *p0,
		        Plane *p1,
		        Plane *p2,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  float z; // eax
		  __int64 v12; // xmm0_8
		  float v13; // eax
		  __int64 v14; // xmm0_8
		  float v15; // eax
		  Vector3 *v16; // rax
		  __int64 v17; // xmm0_8
		  __int64 v18; // xmm4_8
		  MethodInfo *v19; // r9
		  Vector3 *v20; // rax
		  __int64 v21; // xmm0_8
		  float m_Distance; // xmm2_4
		  MethodInfo *v23; // r9
		  MethodInfo *v24; // rax
		  __int64 v25; // xmm3_8
		  __int64 v26; // xmm0_8
		  Vector3 *v27; // rax
		  __int64 v28; // xmm0_8
		  float v29; // xmm2_4
		  MethodInfo *v30; // r9
		  Vector3 *v31; // rax
		  __int64 v32; // r9
		  __int64 v33; // xmm3_8
		  MethodInfo *v34; // rax
		  __int64 v35; // xmm3_8
		  __int64 v36; // xmm0_8
		  Vector3 *v37; // rax
		  __int64 v38; // xmm0_8
		  float v39; // xmm2_4
		  MethodInfo *v40; // r9
		  Vector3 *v41; // rax
		  __int64 v42; // r9
		  __int64 v43; // xmm3_8
		  Vector3 *v44; // rax
		  __int64 v45; // xmm3_8
		  MethodInfo *v46; // r8
		  MethodInfo *v47; // r9
		  Vector3 *v48; // rax
		  __int64 v49; // xmm0_8
		  float v50; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Plane v53; // xmm1
		  Plane v54; // xmm0
		  Vector3 v55; // [rsp+30h] [rbp-11h] BYREF
		  Vector3 v56; // [rsp+40h] [rbp-1h] BYREF
		  Plane v57; // [rsp+50h] [rbp+Fh] BYREF
		  Vector3 v58; // [rsp+60h] [rbp+1Fh] BYREF
		  Plane v59; // [rsp+70h] [rbp+2Fh] BYREF
		  Plane v60; // [rsp+80h] [rbp+3Fh] BYREF
		
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 395 )
		  {
		    if ( !v7->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v7);
		      v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7->static_fields->wrapperArray;
		    if ( v7 )
		    {
		      if ( LODWORD(v7->_0.namespaze) <= 0x18B )
		        sub_1800D2AB0(v7, wrapperArray);
		      if ( !v7[8].static_fields )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(395, 0LL);
		      if ( Patch )
		      {
		        v53 = *p1;
		        v60 = *p2;
		        v54 = *p0;
		        v59 = v53;
		        v57 = v54;
		        v48 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_186(&v58, Patch, &v57, &v59, &v60, 0LL);
		        goto LABEL_6;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v7, wrapperArray);
		  }
		LABEL_5:
		  z = p1->m_Normal.z;
		  *(_QWORD *)&v55.x = *(_QWORD *)&p1->m_Normal.x;
		  v12 = *(_QWORD *)&p0->m_Normal.x;
		  v55.z = z;
		  v13 = p0->m_Normal.z;
		  *(_QWORD *)&v56.x = v12;
		  v14 = *(_QWORD *)&p2->m_Normal.x;
		  v56.z = v13;
		  v15 = p2->m_Normal.z;
		  *(_QWORD *)&v57.m_Normal.x = v14;
		  v57.m_Normal.z = v15;
		  v16 = UnityEngine::Vector3::Cross(&v59.m_Normal, &v56, &v55, (MethodInfo *)p2);
		  *(_QWORD *)&v56.x = *(_QWORD *)&p1->m_Normal.x;
		  v17 = *(_QWORD *)&p2->m_Normal.x;
		  v18 = *(_QWORD *)&v16->x;
		  v58.z = v16->z;
		  v56.z = p1->m_Normal.z;
		  v55.z = p2->m_Normal.z;
		  *(_QWORD *)&v58.x = v18;
		  *(_QWORD *)&v55.x = v17;
		  v20 = UnityEngine::Vector3::Cross(&v59.m_Normal, &v55, &v56, v19);
		  v21 = *(_QWORD *)&v20->x;
		  *(float *)&v20 = v20->z;
		  m_Distance = p0->m_Distance;
		  *(_QWORD *)&v56.x = v21;
		  LODWORD(v56.z) = (_DWORD)v20;
		  v24 = (MethodInfo *)UnityEngine::Vector3::op_Multiply(&v59.m_Normal, &v56, m_Distance, v23);
		  v25 = *(_QWORD *)&p2->m_Normal.x;
		  v26 = *(_QWORD *)&p0->m_Normal.x;
		  v56.z = p2->m_Normal.z;
		  v55.z = p0->m_Normal.z;
		  *(_QWORD *)&v56.x = v25;
		  *(_QWORD *)&v55.x = v26;
		  v27 = UnityEngine::Vector3::Cross(&v60.m_Normal, &v55, &v56, v24);
		  v28 = *(_QWORD *)&v27->x;
		  *(float *)&v27 = v27->z;
		  v29 = p1->m_Distance;
		  *(_QWORD *)&v56.x = v28;
		  LODWORD(v56.z) = (_DWORD)v27;
		  v31 = UnityEngine::Vector3::op_Multiply(&v60.m_Normal, &v56, v29, v30);
		  *(_QWORD *)&v55.x = *(_QWORD *)v32;
		  v33 = *(_QWORD *)&v31->x;
		  v56.z = v31->z;
		  v55.z = *(float *)(v32 + 8);
		  *(_QWORD *)&v56.x = v33;
		  v34 = (MethodInfo *)UnityEngine::Vector3::op_Addition(&v60.m_Normal, &v55, &v56, (MethodInfo *)v32);
		  v35 = *(_QWORD *)&p1->m_Normal.x;
		  v36 = *(_QWORD *)&p0->m_Normal.x;
		  v56.z = p1->m_Normal.z;
		  v55.z = p0->m_Normal.z;
		  *(_QWORD *)&v56.x = v35;
		  *(_QWORD *)&v55.x = v36;
		  v37 = UnityEngine::Vector3::Cross(&v59.m_Normal, &v55, &v56, v34);
		  v38 = *(_QWORD *)&v37->x;
		  *(float *)&v37 = v37->z;
		  v39 = p2->m_Distance;
		  *(_QWORD *)&v56.x = v38;
		  LODWORD(v56.z) = (_DWORD)v37;
		  v41 = UnityEngine::Vector3::op_Multiply(&v59.m_Normal, &v56, v39, v40);
		  *(_QWORD *)&v55.x = *(_QWORD *)v42;
		  v43 = *(_QWORD *)&v41->x;
		  v56.z = v41->z;
		  v55.z = *(float *)(v42 + 8);
		  *(_QWORD *)&v56.x = v43;
		  v44 = UnityEngine::Vector3::op_Subtraction(&v60.m_Normal, &v55, &v56, (MethodInfo *)v42);
		  v45 = *(_QWORD *)&v44->x;
		  *(float *)&v44 = v44->z;
		  *(_QWORD *)&v56.x = v45;
		  LODWORD(v56.z) = (_DWORD)v44;
		  *(float *)&v38 = UnityEngine::Vector3::Dot(&v58, &v57.m_Normal, v46);
		  v48 = UnityEngine::Vector3::op_Multiply(&v60.m_Normal, &v56, 1.0 / *(float *)&v38, v47);
		LABEL_6:
		  v49 = *(_QWORD *)&v48->x;
		  v50 = v48->z;
		  *(_QWORD *)&retstr->x = v49;
		  retstr->z = v50;
		  return retstr;
		}
		
		public static void Create(ref Frustum frustum, Matrix4x4 viewProjMatrix, Vector3 viewPos, Vector3 viewDir, float nearClipPlane, float farClipPlane) {} // 0x0000000183252BD0-0x0000000183253440
		// Void Create(Frustum ByRef, Matrix4x4, Vector3, Vector3, Single, Single)
		void HG::Rendering::Runtime::Frustum::Create(
		        Frustum *frustum,
		        Matrix4x4 *viewProjMatrix,
		        Vector3 *viewPos,
		        Vector3 *viewDir,
		        float nearClipPlane,
		        float farClipPlane,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v9; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Plane__Array *planes; // rsi
		  void (__fastcall *v14)(Plane__Array *, Matrix4x4 *); // rax
		  __int128 v15; // xmm1
		  __int128 v16; // xmm1
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  MethodInfo *v19; // r8
		  struct Math__Class *v20; // rdi
		  __m128 y_low; // xmm2
		  __m128d v22; // xmm3
		  double v23; // xmm0_8
		  float v24; // xmm4_4
		  __m128i z_low; // xmm1
		  __m128 v26; // xmm2
		  int v27; // r12d
		  float z; // eax
		  __int64 v29; // xmm0_8
		  float v30; // eax
		  float v31; // eax
		  float v32; // xmm8_4
		  MethodInfo *v33; // r8
		  Vector3 *v34; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  __int64 v37; // r8
		  bool v38; // zf
		  __int64 v39; // xmm10_8
		  float v40; // r13d
		  __m128 v41; // xmm2
		  __m128d v42; // xmm3
		  double v43; // xmm0_8
		  float v44; // xmm3_4
		  __m128 x_low; // xmm0
		  __m128 v46; // xmm1
		  __m128i v47; // xmm2
		  unsigned __int64 v48; // xmm0_8
		  unsigned __int64 v49; // r8
		  float v50; // eax
		  float v51; // r8d
		  float v52; // xmm0_4
		  Plane__Array *v53; // rax
		  float v54; // xmm3_4
		  Plane v55; // xmm0
		  float x; // xmm1_4
		  Plane__Array *v57; // rax
		  Plane__Array *v58; // rax
		  Vector3__Array *corners; // rsi
		  Plane v60; // xmm1
		  Plane v61; // xmm0
		  Vector3 *v62; // rax
		  Plane__Array *v63; // rax
		  Vector3__Array *v64; // rsi
		  Plane v65; // xmm1
		  Plane v66; // xmm0
		  Vector3 *v67; // rax
		  Plane__Array *v68; // rax
		  Vector3__Array *v69; // rsi
		  Plane v70; // xmm1
		  Plane v71; // xmm0
		  Vector3 *v72; // rax
		  Plane__Array *v73; // rax
		  Vector3__Array *v74; // rsi
		  Plane v75; // xmm1
		  Plane v76; // xmm0
		  Vector3 *v77; // rax
		  Plane__Array *v78; // rax
		  Vector3__Array *v79; // rsi
		  Plane v80; // xmm1
		  Plane v81; // xmm0
		  Vector3 *v82; // rax
		  Plane__Array *v83; // rax
		  Vector3__Array *v84; // rsi
		  Plane v85; // xmm1
		  Plane v86; // xmm0
		  Vector3 *v87; // rax
		  Plane__Array *v88; // rax
		  Vector3__Array *v89; // rsi
		  Plane v90; // xmm1
		  Plane v91; // xmm0
		  Vector3 *v92; // rax
		  Plane__Array *v93; // rax
		  Vector3__Array *v94; // rsi
		  Plane v95; // xmm1
		  Plane v96; // xmm0
		  Vector3 *v97; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v99; // xmm1
		  float v100; // ecx
		  __int128 v101; // xmm0
		  float v102; // ecx
		  __int128 v103; // xmm0
		  __int128 v104; // xmm1
		  __int64 v105; // rax
		  __int64 v106; // rax
		  ArgumentException *v107; // rdi
		  String *v108; // rbx
		  String *v109; // rax
		  __int64 v110; // rax
		  __int64 v111; // rax
		  ArgumentNullException *v112; // rbx
		  String *v113; // rax
		  __int64 v114; // rax
		  Plane v115; // [rsp+40h] [rbp-C0h] BYREF
		  Plane v116; // [rsp+50h] [rbp-B0h] BYREF
		  Plane v117; // [rsp+60h] [rbp-A0h] BYREF
		  Plane v118; // [rsp+70h] [rbp-90h] BYREF
		  Matrix4x4 v119; // [rsp+80h] [rbp-80h] BYREF
		
		  v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v9->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_59;
		  if ( wrapperArray->max_length.size <= 396 )
		    goto LABEL_5;
		  if ( !v9->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v9);
		    v9 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v9->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_59;
		  if ( wrapperArray->max_length.size <= 0x18Cu )
		    goto LABEL_62;
		  if ( !wrapperArray[11].vector[0] )
		  {
		LABEL_5:
		    planes = frustum->planes;
		    if ( frustum->planes )
		    {
		      if ( planes->max_length.size == 6 )
		      {
		        v14 = (void (__fastcall *)(Plane__Array *, Matrix4x4 *))qword_18F36F290;
		        v15 = *(_OWORD *)&viewProjMatrix->m01;
		        *(_OWORD *)&v119.m00 = *(_OWORD *)&viewProjMatrix->m00;
		        *(_OWORD *)&v119.m01 = v15;
		        v16 = *(_OWORD *)&viewProjMatrix->m03;
		        *(_OWORD *)&v119.m02 = *(_OWORD *)&viewProjMatrix->m02;
		        *(_OWORD *)&v119.m03 = v16;
		        if ( !qword_18F36F290 )
		        {
		          v14 = (void (__fastcall *)(Plane__Array *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.GeometryUtility::Internal_ExtractPlanes_"
		                                                                    "Injected(UnityEngine.Plane[],UnityEngine.Matrix4x4&)");
		          if ( !v14 )
		          {
		            v105 = sub_1802EE1B8(
		                     "UnityEngine.GeometryUtility::Internal_ExtractPlanes_Injected(UnityEngine.Plane[],UnityEngine.Matrix4x4&)");
		            sub_18007E1B0(v105, 0LL);
		          }
		          qword_18F36F290 = (__int64)v14;
		        }
		        v14(planes, &v119);
		        v20 = TypeInfo::System::Math;
		        *(_QWORD *)&v115.m_Normal.x = *(_QWORD *)&viewDir->x;
		        if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		          v20 = TypeInfo::System::Math;
		        }
		        y_low = (__m128)LODWORD(v115.m_Normal.y);
		        y_low.m128_f32[0] = (float)((float)(y_low.m128_f32[0] * y_low.m128_f32[0])
		                                  + (float)(v115.m_Normal.x * v115.m_Normal.x))
		                          + (float)(viewDir->z * viewDir->z);
		        v22 = _mm_cvtps_pd(y_low);
		        if ( v22.m128d_f64[0] < 0.0 )
		          v23 = sub_1801D32D0(v18, v17, v19);
		        else
		          *(_QWORD *)&v23 = *(_OWORD *)&_mm_sqrt_pd(v22);
		        v24 = v23;
		        if ( v24 <= 0.0000099999997 )
		        {
		          v27 = _mm_cvtsi128_si32((__m128i)0LL);
		          *(_QWORD *)&v117.m_Normal.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        }
		        else
		        {
		          z_low = (__m128i)LODWORD(viewDir->z);
		          v26 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&viewDir->x, (__m128)*(unsigned __int64 *)&viewDir->x, 85);
		          v26.m128_f32[0] = v26.m128_f32[0] / v24;
		          *(_QWORD *)&v118.m_Normal.x = *(_QWORD *)&viewDir->x;
		          *(float *)z_low.m128i_i32 = *(float *)z_low.m128i_i32 / v24;
		          *(_QWORD *)&v117.m_Normal.x = _mm_unpacklo_ps((__m128)*(unsigned __int64 *)&v118.m_Normal.x, v26).m128_u64[0];
		          v27 = _mm_cvtsi128_si32(z_low);
		        }
		        z = viewPos->z;
		        *(_QWORD *)&v115.m_Normal.x = *(_QWORD *)&viewPos->x;
		        v29 = *(_QWORD *)&viewDir->x;
		        v115.m_Normal.z = z;
		        v30 = viewDir->z;
		        *(_QWORD *)&v116.m_Normal.x = v29;
		        v116.m_Normal.z = v30;
		        *(float *)&v29 = UnityEngine::Vector3::Dot(&v116.m_Normal, &v115.m_Normal, v19);
		        *(_QWORD *)&v116.m_Normal.x = *(_QWORD *)&viewDir->x;
		        v116.m_Normal.z = v31;
		        v32 = (float)-*(float *)&v29 - nearClipPlane;
		        v34 = UnityEngine::Vector3::op_UnaryNegation(&v118.m_Normal, &v116.m_Normal, v33);
		        v38 = v20->_1.cctor_finished_or_no_cctor == 0;
		        v39 = *(_QWORD *)&v34->x;
		        v40 = v34->z;
		        *(_QWORD *)&v115.m_Normal.x = v39;
		        *(_QWORD *)&v116.m_Normal.x = v39;
		        if ( v38 )
		          il2cpp_runtime_class_init_1(v20);
		        v41 = (__m128)LODWORD(v116.m_Normal.y);
		        v41.m128_f32[0] = (float)((float)(v41.m128_f32[0] * v41.m128_f32[0]) + (float)(v116.m_Normal.x * v116.m_Normal.x))
		                        + (float)(v40 * v40);
		        v42 = _mm_cvtps_pd(v41);
		        if ( v42.m128d_f64[0] < 0.0 )
		          v43 = sub_1801D32D0(v36, v35, v37);
		        else
		          *(_QWORD *)&v43 = *(_OWORD *)&_mm_sqrt_pd(v42);
		        v44 = v43;
		        if ( v44 <= 0.0000099999997 )
		        {
		          v49 = (unsigned int)_mm_cvtsi128_si32((__m128i)0LL);
		          v48 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		        }
		        else
		        {
		          x_low = (__m128)LODWORD(v115.m_Normal.x);
		          v46 = (__m128)LODWORD(v115.m_Normal.y);
		          v47 = _mm_cvtsi32_si128(LODWORD(v40));
		          x_low.m128_f32[0] = v115.m_Normal.x / v44;
		          v46.m128_f32[0] = v115.m_Normal.y / v44;
		          *(float *)v47.m128i_i32 = *(float *)v47.m128i_i32 / v44;
		          v48 = _mm_unpacklo_ps(x_low, v46).m128_u64[0];
		          v49 = (unsigned int)_mm_cvtsi128_si32(v47);
		        }
		        *(_QWORD *)&v115.m_Normal.x = v48;
		        v50 = viewPos->z;
		        *(_QWORD *)&v116.m_Normal.x = *(_QWORD *)&viewPos->x;
		        v116.m_Normal.z = v50;
		        *(_QWORD *)&v118.m_Normal.x = v39;
		        v118.m_Normal.z = v40;
		        v52 = UnityEngine::Vector3::Dot(&v118.m_Normal, &v116.m_Normal, (MethodInfo *)v49);
		        v53 = frustum->planes;
		        *(_QWORD *)&v118.m_Normal.z = __PAIR64__(LODWORD(v32), v27);
		        *(_QWORD *)&v118.m_Normal.x = *(_QWORD *)&v117.m_Normal.x;
		        v54 = farClipPlane - v52;
		        if ( v53 )
		        {
		          if ( v53->max_length.size <= 4u )
		            goto LABEL_62;
		          v55 = v118;
		          v118.m_Normal.z = v51;
		          x = v115.m_Normal.x;
		          v53->vector[4] = v55;
		          v57 = frustum->planes;
		          *(_QWORD *)&v118.m_Normal.x = __PAIR64__(LODWORD(v115.m_Normal.y), LODWORD(x));
		          v118.m_Distance = v54;
		          if ( v57 )
		          {
		            if ( v57->max_length.size <= 5u )
		              goto LABEL_62;
		            v57->vector[5] = v118;
		            v58 = frustum->planes;
		            corners = frustum->corners;
		            if ( frustum->planes )
		            {
		              if ( v58->max_length.size <= 4u )
		                goto LABEL_62;
		              v60 = v58->vector[3];
		              v116 = v58->vector[4];
		              v61 = v58->vector[0];
		              v115 = v60;
		              v117 = v61;
		              v62 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(&v118.m_Normal, &v117, &v115, &v116, 0LL);
		              if ( corners )
		              {
		                if ( !corners->max_length.size )
		                  goto LABEL_62;
		                *(_QWORD *)&corners->vector[0].x = *(_QWORD *)&v62->x;
		                corners->vector[0].z = v62->z;
		                v63 = frustum->planes;
		                v64 = frustum->corners;
		                if ( frustum->planes )
		                {
		                  if ( v63->max_length.size <= 4u )
		                    goto LABEL_62;
		                  v65 = v63->vector[3];
		                  v116 = v63->vector[4];
		                  v66 = v63->vector[1];
		                  v115 = v65;
		                  v117 = v66;
		                  v67 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
		                          &v118.m_Normal,
		                          &v117,
		                          &v115,
		                          &v116,
		                          0LL);
		                  if ( v64 )
		                  {
		                    if ( v64->max_length.size <= 1u )
		                      goto LABEL_62;
		                    *(_QWORD *)&v64->vector[1].x = *(_QWORD *)&v67->x;
		                    v64->vector[1].z = v67->z;
		                    v68 = frustum->planes;
		                    v69 = frustum->corners;
		                    if ( frustum->planes )
		                    {
		                      if ( v68->max_length.size <= 4u )
		                        goto LABEL_62;
		                      v70 = v68->vector[2];
		                      v116 = v68->vector[4];
		                      v71 = v68->vector[0];
		                      v115 = v70;
		                      v117 = v71;
		                      v72 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
		                              &v118.m_Normal,
		                              &v117,
		                              &v115,
		                              &v116,
		                              0LL);
		                      if ( v69 )
		                      {
		                        if ( v69->max_length.size <= 2u )
		                          goto LABEL_62;
		                        *(_QWORD *)&v69->vector[2].x = *(_QWORD *)&v72->x;
		                        v69->vector[2].z = v72->z;
		                        v73 = frustum->planes;
		                        v74 = frustum->corners;
		                        if ( frustum->planes )
		                        {
		                          if ( v73->max_length.size <= 4u )
		                            goto LABEL_62;
		                          v75 = v73->vector[2];
		                          v116 = v73->vector[4];
		                          v76 = v73->vector[1];
		                          v115 = v75;
		                          v117 = v76;
		                          v77 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
		                                  &v118.m_Normal,
		                                  &v117,
		                                  &v115,
		                                  &v116,
		                                  0LL);
		                          if ( v74 )
		                          {
		                            if ( v74->max_length.size <= 3u )
		                              goto LABEL_62;
		                            *(_QWORD *)&v74->vector[3].x = *(_QWORD *)&v77->x;
		                            v74->vector[3].z = v77->z;
		                            v78 = frustum->planes;
		                            v79 = frustum->corners;
		                            if ( frustum->planes )
		                            {
		                              if ( v78->max_length.size < 6u )
		                                goto LABEL_62;
		                              v80 = v78->vector[3];
		                              v116 = v78->vector[5];
		                              v81 = v78->vector[0];
		                              v115 = v80;
		                              v117 = v81;
		                              v82 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
		                                      &v118.m_Normal,
		                                      &v117,
		                                      &v115,
		                                      &v116,
		                                      0LL);
		                              if ( v79 )
		                              {
		                                if ( v79->max_length.size <= 4u )
		                                  goto LABEL_62;
		                                *(_QWORD *)&v79->vector[4].x = *(_QWORD *)&v82->x;
		                                v79->vector[4].z = v82->z;
		                                v83 = frustum->planes;
		                                v84 = frustum->corners;
		                                if ( frustum->planes )
		                                {
		                                  if ( v83->max_length.size < 6u )
		                                    goto LABEL_62;
		                                  v85 = v83->vector[3];
		                                  v116 = v83->vector[5];
		                                  v86 = v83->vector[1];
		                                  v115 = v85;
		                                  v117 = v86;
		                                  v87 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
		                                          &v118.m_Normal,
		                                          &v117,
		                                          &v115,
		                                          &v116,
		                                          0LL);
		                                  if ( v84 )
		                                  {
		                                    if ( v84->max_length.size <= 5u )
		                                      goto LABEL_62;
		                                    *(_QWORD *)&v84->vector[5].x = *(_QWORD *)&v87->x;
		                                    v84->vector[5].z = v87->z;
		                                    v88 = frustum->planes;
		                                    v89 = frustum->corners;
		                                    if ( frustum->planes )
		                                    {
		                                      if ( v88->max_length.size < 6u )
		                                        goto LABEL_62;
		                                      v90 = v88->vector[2];
		                                      v116 = v88->vector[5];
		                                      v91 = v88->vector[0];
		                                      v115 = v90;
		                                      v117 = v91;
		                                      v92 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
		                                              &v118.m_Normal,
		                                              &v117,
		                                              &v115,
		                                              &v116,
		                                              0LL);
		                                      if ( v89 )
		                                      {
		                                        if ( v89->max_length.size <= 6u )
		                                          goto LABEL_62;
		                                        *(_QWORD *)&v89->vector[6].x = *(_QWORD *)&v92->x;
		                                        v89->vector[6].z = v92->z;
		                                        v93 = frustum->planes;
		                                        v94 = frustum->corners;
		                                        if ( frustum->planes )
		                                        {
		                                          if ( v93->max_length.size < 6u )
		                                            goto LABEL_62;
		                                          v95 = v93->vector[2];
		                                          v116 = v93->vector[5];
		                                          v96 = v93->vector[1];
		                                          v115 = v95;
		                                          v117 = v96;
		                                          v97 = HG::Rendering::Runtime::Frustum::IntersectFrustumPlanes(
		                                                  &v118.m_Normal,
		                                                  &v117,
		                                                  &v115,
		                                                  &v116,
		                                                  0LL);
		                                          if ( v94 )
		                                          {
		                                            if ( v94->max_length.size > 7u )
		                                            {
		                                              *(_QWORD *)&v94->vector[7].x = *(_QWORD *)&v97->x;
		                                              v94->vector[7].z = v97->z;
		                                              return;
		                                            }
		LABEL_62:
		                                            sub_1800D2AB0(v9, wrapperArray);
		                                          }
		                                        }
		                                      }
		                                    }
		                                  }
		                                }
		                              }
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		      else
		      {
		        v106 = sub_180035ED0(&TypeInfo::System::ArgumentException);
		        v107 = (ArgumentException *)sub_1800368D0(v106);
		        if ( v107 )
		        {
		          v108 = (String *)sub_180035ED0(&off_18E260848);
		          v109 = (String *)sub_180035ED0(&off_18E260800);
		          System::ArgumentException::ArgumentException(v107, v109, v108, 0LL);
		          v110 = sub_180035ED0(&MethodInfo::UnityEngine::GeometryUtility::CalculateFrustumPlanes);
		          sub_18007E190(v107, v110);
		        }
		      }
		    }
		    else
		    {
		      v111 = sub_180035ED0(&TypeInfo::System::ArgumentNullException);
		      v112 = (ArgumentNullException *)sub_1800368D0(v111);
		      if ( v112 )
		      {
		        v113 = (String *)sub_180035ED0(&off_18E260848);
		        System::ArgumentNullException::ArgumentNullException(v112, v113, 0LL);
		        v114 = sub_180035ED0(&MethodInfo::UnityEngine::GeometryUtility::CalculateFrustumPlanes);
		        sub_18007E190(v112, v114);
		      }
		    }
		LABEL_59:
		    sub_1800D8260(v9, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(396, 0LL);
		  if ( !Patch )
		    goto LABEL_59;
		  v99 = *(_OWORD *)&viewProjMatrix->m01;
		  v100 = viewDir->z;
		  *(_QWORD *)&v115.m_Normal.x = *(_QWORD *)&viewDir->x;
		  *(_QWORD *)&v117.m_Normal.x = *(_QWORD *)&viewPos->x;
		  v101 = *(_OWORD *)&viewProjMatrix->m00;
		  v115.m_Normal.z = v100;
		  v102 = viewPos->z;
		  *(_OWORD *)&v119.m00 = v101;
		  v103 = *(_OWORD *)&viewProjMatrix->m02;
		  v117.m_Normal.z = v102;
		  *(_OWORD *)&v119.m01 = v99;
		  v104 = *(_OWORD *)&viewProjMatrix->m03;
		  *(_OWORD *)&v119.m02 = v103;
		  *(_OWORD *)&v119.m03 = v104;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_187(
		    Patch,
		    frustum,
		    &v119,
		    &v117.m_Normal,
		    &v115.m_Normal,
		    nearClipPlane,
		    farClipPlane,
		    0LL);
		}
		
	}
}
