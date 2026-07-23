using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using Unity.Mathematics;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class GeometryUtils // TypeDefIndex: 37529
	{
		// Methods
		public static bool Overlap(OrientedBBox obb, Frustum frustum, int numPlanes, int numCorners) => default; // 0x0000000189C6A6E4-0x0000000189C6AB94
		// Boolean Overlap(OrientedBBox, Frustum, Int32, Int32)
		bool HG::Rendering::Runtime::GeometryUtils::Overlap(
		        OrientedBBox *obb,
		        Frustum *frustum,
		        int32_t numPlanes,
		        int32_t numCorners,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  int32_t i; // esi
		  bool v11; // di
		  Plane__Array *planes; // rcx
		  __int64 v13; // rax
		  __int64 v14; // xmm12_8
		  float v15; // edi
		  __int64 v16; // rax
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __m128i v19; // xmm2
		  __m128 v20; // xmm10
		  float v21; // xmm11_4
		  MethodInfo *v22; // r8
		  __int128 v23; // xmm1
		  __m128 v24; // xmm8
		  float v25; // xmm9_4
		  MethodInfo *v26; // r8
		  __m128 v27; // xmm6
		  float v28; // xmm7_4
		  Vector3 *forward; // rax
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm0
		  MethodInfo *v33; // r8
		  float v34; // xmm3_4
		  MethodInfo *v35; // r8
		  const __m128i *v36; // rsi
		  float extentY; // xmm1_4
		  Vector3 *v38; // rax
		  __int64 v39; // rax
		  __m128 v40; // xmm7
		  int32_t v41; // r15d
		  bool v42; // r14
		  bool v43; // di
		  float v44; // xmm6_4
		  __int128 v45; // xmm0
		  MethodInfo *v46; // r9
		  Vector3 *v47; // rax
		  __int64 v48; // xmm3_8
		  MethodInfo *v49; // r8
		  float v50; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Frustum v53; // xmm0
		  __int128 v54; // xmm1
		  __int128 v55; // xmm0
		  __int128 v56; // xmm1
		  __int64 v57; // [rsp+0h] [rbp-30h] BYREF
		  int v58; // [rsp+8h] [rbp-28h]
		  float extentX; // [rsp+Ch] [rbp-24h]
		  __int64 v60; // [rsp+10h] [rbp-20h]
		  int v61; // [rsp+18h] [rbp-18h]
		  float v62; // [rsp+1Ch] [rbp-14h]
		  __int64 v63; // [rsp+20h] [rbp-10h]
		  unsigned __int64 v64; // [rsp+28h] [rbp-8h]
		  Vector3 v65; // [rsp+30h] [rbp+0h] BYREF
		  OrientedBBox v66; // [rsp+40h] [rbp+10h] BYREF
		  float v67; // [rsp+70h] [rbp+40h]
		  Vector3 v68; // [rsp+80h] [rbp+50h] BYREF
		  Vector3 v69; // [rsp+90h] [rbp+60h] BYREF
		  Vector3 v70; // [rsp+A0h] [rbp+70h] BYREF
		  Vector3 v71; // [rsp+B0h] [rbp+80h] BYREF
		  Vector3 v72; // [rsp+C0h] [rbp+90h] BYREF
		  Frustum v73; // [rsp+D0h] [rbp+A0h] BYREF
		  Vector3 v74; // [rsp+E0h] [rbp+B0h] BYREF
		  Vector3 v75; // [rsp+F0h] [rbp+C0h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(398, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(398, 0LL);
		    if ( !Patch )
		LABEL_27:
		      sub_1800D8260(planes, v9);
		    v53 = *frustum;
		    v64 = 0LL;
		    v54 = *(_OWORD *)&obb->right.x;
		    v73 = v53;
		    LODWORD(v63) = numCorners;
		    v55 = *(_OWORD *)&obb->up.x;
		    *(_OWORD *)&v66.right.x = v54;
		    v56 = *(_OWORD *)&obb->center.x;
		    *(_OWORD *)&v66.up.x = v55;
		    *(_OWORD *)&v66.center.x = v56;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_189(Patch, &v66, &v73, numPlanes, numCorners, 0LL);
		  }
		  else
		  {
		    for ( i = 0; ; ++i )
		    {
		      v11 = 1;
		      if ( i >= numPlanes )
		        break;
		      planes = frustum->planes;
		      if ( !frustum->planes )
		        goto LABEL_27;
		      v13 = sub_180002100(planes, i);
		      planes = frustum->planes;
		      v14 = *(_QWORD *)v13;
		      v15 = *(float *)(v13 + 8);
		      if ( !frustum->planes )
		        goto LABEL_27;
		      v16 = sub_180002100(planes, i);
		      v17 = *(_OWORD *)&obb->up.x;
		      v74.z = v15;
		      v18 = *(_OWORD *)&obb->center.x;
		      v19 = _mm_loadl_epi64((const __m128i *)&obb->right.z);
		      v20 = *(__m128 *)&obb->right.x;
		      v21 = *(float *)(v16 + 12);
		      *(_OWORD *)&v66.up.x = v17;
		      *(_OWORD *)&v66.center.x = v18;
		      *(_QWORD *)&v65.x = v20.m128_u64[0];
		      LODWORD(v65.z) = _mm_cvtsi128_si32(v19);
		      *(_QWORD *)&v74.x = v14;
		      *(float *)&v17 = UnityEngine::Vector3::Dot(&v74, &v65, v22);
		      v23 = *(_OWORD *)&obb->center.x;
		      v68.z = v15;
		      v24 = *(__m128 *)&obb->up.x;
		      *(_OWORD *)&v66.center.x = v23;
		      v25 = fabs(*(float *)&v17);
		      LODWORD(v75.z) = _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&obb->up.z));
		      *(__m128 *)&v66.right.x = v20;
		      *(_QWORD *)&v75.x = v24.m128_u64[0];
		      *(_QWORD *)&v68.x = v14;
		      *(float *)&v17 = UnityEngine::Vector3::Dot(&v68, &v75, v26);
		      v27 = *(__m128 *)&obb->center.x;
		      v28 = fabs(*(float *)&v17);
		      *(__m128 *)&v66.right.x = v20;
		      *(__m128 *)&v66.up.x = v24;
		      forward = HG::Rendering::Runtime::OrientedBBox::get_forward((Vector3 *)&v73, obb, 0LL);
		      v30 = *(_OWORD *)&obb->up.x;
		      v70.z = v15;
		      *(_QWORD *)&v70.x = v14;
		      *(_QWORD *)&v17 = *(_QWORD *)&forward->x;
		      *(float *)&forward = forward->z;
		      *(_QWORD *)&v69.x = v17;
		      v31 = *(_OWORD *)&obb->right.x;
		      LODWORD(v69.z) = (_DWORD)forward;
		      *(_OWORD *)&v66.up.x = v30;
		      v72.z = v15;
		      *(_OWORD *)&v66.right.x = v31;
		      v32 = *(_OWORD *)&obb->center.x;
		      *(_QWORD *)&v72.x = v14;
		      *(_QWORD *)&v71.x = v32;
		      LODWORD(v71.z) = _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&obb->center.z));
		      v34 = (float)(fabs(UnityEngine::Vector3::Dot(&v70, &v69, v33)) * _mm_shuffle_ps(v27, v27, 255).m128_f32[0])
		          + (float)((float)(v28 * _mm_shuffle_ps(v24, v24, 255).m128_f32[0])
		                  + (float)(v25 * _mm_shuffle_ps(v20, v20, 255).m128_f32[0]));
		      if ( (float)(v34 + (float)(UnityEngine::Vector3::Dot(&v72, &v71, v35) + v21)) < 0.0 )
		      {
		        v11 = 0;
		        break;
		      }
		    }
		    if ( numCorners )
		    {
		      v36 = (const __m128i *)&v57;
		      v63 = 0LL;
		      v64 = 0LL;
		      extentY = obb->extentY;
		      v57 = *(_QWORD *)&obb->right.x;
		      v58 = _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&obb->right.z));
		      extentX = obb->extentX;
		      v60 = *(_QWORD *)&obb->up.x;
		      v61 = _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&obb->up.z));
		      v62 = extentY;
		      v38 = HG::Rendering::Runtime::OrientedBBox::get_forward((Vector3 *)&v73, obb, 0LL);
		      planes = (Plane__Array *)LODWORD(v38->z);
		      v63 = *(_QWORD *)&v38->x;
		      v64 = __PAIR64__(LODWORD(obb->extentZ), (unsigned int)planes);
		      if ( v11 )
		      {
		        v39 = 0LL;
		        *(_QWORD *)&v65.x = 0LL;
		        do
		        {
		          if ( v39 >= 3 )
		            break;
		          v40 = (__m128)_mm_loadu_si128(v36);
		          v41 = 0;
		          v42 = 1;
		          v43 = 1;
		          if ( numCorners <= 0 )
		            goto LABEL_23;
		          v67 = COERCE_FLOAT(_mm_cvtsi128_si32(_mm_srli_si128((__m128i)v40, 8)));
		          LODWORD(v44) = _mm_shuffle_ps(v40, v40, 255).m128_u32[0];
		          do
		          {
		            if ( !frustum->corners )
		              goto LABEL_27;
		            sub_180049C60(frustum->corners, &v72, v41);
		            v45 = *(_OWORD *)&obb->center.x;
		            v70.z = v72.z;
		            *(_QWORD *)&v71.x = v45;
		            LODWORD(v71.z) = _mm_cvtsi128_si32(_mm_loadl_epi64((const __m128i *)&obb->center.z));
		            *(_QWORD *)&v70.x = *(_QWORD *)&v72.x;
		            v47 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v73, &v70, &v71, v46);
		            *(_QWORD *)&v68.x = v40.m128_u64[0];
		            v48 = *(_QWORD *)&v47->x;
		            v69.z = v47->z;
		            v68.z = v67;
		            *(_QWORD *)&v69.x = v48;
		            v50 = UnityEngine::Vector3::Dot(&v68, &v69, v49);
		            if ( v42 )
		              v42 = v50 > v44;
		            if ( v43 )
		              v43 = (float)-v50 > v44;
		            ++v41;
		          }
		          while ( v41 < numCorners );
		          v39 = *(_QWORD *)&v65.x;
		          if ( v42 || v43 )
		LABEL_23:
		            v11 = 0;
		          else
		            v11 = 1;
		          ++v39;
		          ++v36;
		          *(_QWORD *)&v65.x = v39;
		        }
		        while ( v11 );
		      }
		    }
		    return v11;
		  }
		}
		
		public static Vector4 Plane(Vector3 position, Vector3 normal) => default; // 0x0000000189C6AB94-0x0000000189C6AC94
		// Vector4 Plane(Vector3, Vector3)
		Vector4 *HG::Rendering::Runtime::GeometryUtils::Plane(
		        Vector4 *__return_ptr retstr,
		        Vector3 *position,
		        Vector3 *normal,
		        MethodInfo *method)
		{
		  MethodInfo *v7; // r8
		  float v8; // eax
		  __int64 v9; // xmm0_8
		  float v10; // eax
		  float y; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v13; // rcx
		  float z; // eax
		  __int64 v15; // xmm0_8
		  float v16; // eax
		  Vector4 v18; // [rsp+30h] [rbp-30h] BYREF
		  Vector3 v19; // [rsp+40h] [rbp-20h] BYREF
		  Vector3 v20; // [rsp+50h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(399, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(399, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, 0LL);
		    z = normal->z;
		    *(_QWORD *)&v20.x = *(_QWORD *)&normal->x;
		    v15 = *(_QWORD *)&position->x;
		    v20.z = z;
		    v16 = position->z;
		    *(_QWORD *)&v19.x = v15;
		    v19.z = v16;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_190(&v18, Patch, &v19, &v20, 0LL);
		  }
		  else
		  {
		    v8 = position->z;
		    *(_QWORD *)&v20.x = *(_QWORD *)&normal->x;
		    *(_QWORD *)&v18.x = *(_QWORD *)&position->x;
		    v9 = *(_QWORD *)&normal->x;
		    v18.z = v8;
		    v10 = normal->z;
		    *(_QWORD *)&v19.x = v9;
		    v19.z = v10;
		    *(float *)&v9 = UnityEngine::Vector3::Dot(&v19, (Vector3 *)&v18, v7);
		    y = v20.y;
		    retstr->x = v20.x;
		    retstr->z = normal->z;
		    retstr->y = y;
		    retstr->w = -*(float *)&v9;
		  }
		  return retstr;
		}
		
		public static Vector4 CameraSpacePlane(Matrix4x4 worldToCamera, Vector3 positionWS, Vector3 normalWS, float sideSign = 1f /* Metadata: 0x02302EF6 */, float clipPlaneOffset = 0f /* Metadata: 0x02302EFA */) => default; // 0x0000000189C6979C-0x0000000189C699CC
		// Vector4 CameraSpacePlane(Matrix4x4, Vector3, Vector3, Single, Single)
		Vector4 *HG::Rendering::Runtime::GeometryUtils::CameraSpacePlane(
		        Vector4 *__return_ptr retstr,
		        Matrix4x4 *worldToCamera,
		        Vector3 *positionWS,
		        Vector3 *normalWS,
		        float sideSign,
		        float clipPlaneOffset,
		        MethodInfo *method)
		{
		  MethodInfo *v11; // r9
		  float v12; // eax
		  Vector3 *v13; // rax
		  __int64 v14; // xmm3_8
		  MethodInfo *v15; // r9
		  Vector3 *v16; // rax
		  __int64 v17; // xmm3_8
		  Vector3 *v18; // rax
		  __int64 v19; // xmm6_8
		  float v20; // ebx
		  Vector3 *v21; // rax
		  __int64 v22; // xmm0_8
		  __int64 v23; // rax
		  __int64 v24; // xmm0_8
		  MethodInfo *v25; // r9
		  Vector3 *v26; // rax
		  MethodInfo *z_low; // r8
		  float v28; // r8d
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v30; // rcx
		  __int128 v31; // xmm1
		  float z; // eax
		  __int128 v33; // xmm0
		  float v34; // eax
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  Vector4 v38; // [rsp+48h] [rbp-41h] BYREF
		  Vector3 v39; // [rsp+58h] [rbp-31h] BYREF
		  Vector3 v40; // [rsp+68h] [rbp-21h] BYREF
		  Matrix4x4 v41; // [rsp+78h] [rbp-11h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(400, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(400, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v30, 0LL);
		    v31 = *(_OWORD *)&worldToCamera->m01;
		    z = normalWS->z;
		    *(_QWORD *)&v40.x = *(_QWORD *)&normalWS->x;
		    *(_QWORD *)&v39.x = *(_QWORD *)&positionWS->x;
		    v33 = *(_OWORD *)&worldToCamera->m00;
		    v40.z = z;
		    v34 = positionWS->z;
		    *(_OWORD *)&v41.m00 = v33;
		    v35 = *(_OWORD *)&worldToCamera->m02;
		    v39.z = v34;
		    *(_OWORD *)&v41.m01 = v31;
		    v36 = *(_OWORD *)&worldToCamera->m03;
		    *(_OWORD *)&v41.m02 = v35;
		    *(_OWORD *)&v41.m03 = v36;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_191(
		                 &v38,
		                 Patch,
		                 &v41,
		                 &v39,
		                 &v40,
		                 sideSign,
		                 clipPlaneOffset,
		                 0LL);
		  }
		  else
		  {
		    v12 = normalWS->z;
		    *(_QWORD *)&v38.x = *(_QWORD *)&normalWS->x;
		    v38.z = v12;
		    v13 = UnityEngine::Vector3::op_Multiply(&v40, (Vector3 *)&v38, clipPlaneOffset, v11);
		    *(_QWORD *)&v39.x = *(_QWORD *)&positionWS->x;
		    v14 = *(_QWORD *)&v13->x;
		    v38.z = v13->z;
		    v39.z = positionWS->z;
		    *(_QWORD *)&v38.x = v14;
		    v16 = UnityEngine::Vector3::op_Addition(&v40, &v39, (Vector3 *)&v38, v15);
		    v17 = *(_QWORD *)&v16->x;
		    *(float *)&v16 = v16->z;
		    *(_QWORD *)&v39.x = v17;
		    LODWORD(v39.z) = (_DWORD)v16;
		    v18 = UnityEngine::Matrix4x4::MultiplyPoint(&v40, worldToCamera, &v39, 0LL);
		    *(_QWORD *)&v39.x = *(_QWORD *)&normalWS->x;
		    v19 = *(_QWORD *)&v18->x;
		    v20 = v18->z;
		    v39.z = normalWS->z;
		    v21 = UnityEngine::Matrix4x4::MultiplyVector(&v40, worldToCamera, &v39, 0LL);
		    v22 = *(_QWORD *)&v21->x;
		    *(float *)&v21 = v21->z;
		    *(_QWORD *)&v39.x = v22;
		    LODWORD(v39.z) = (_DWORD)v21;
		    v23 = sub_182FAE2B0(&v40, &v39);
		    v24 = *(_QWORD *)v23;
		    LODWORD(v23) = *(_DWORD *)(v23 + 8);
		    *(_QWORD *)&v39.x = v24;
		    LODWORD(v39.z) = v23;
		    v26 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v38, &v39, sideSign, v25);
		    z_low = (MethodInfo *)LODWORD(v26->z);
		    *(_QWORD *)&v40.x = *(_QWORD *)&v26->x;
		    *(_QWORD *)&v39.x = *(_QWORD *)&v40.x;
		    LODWORD(v39.z) = (_DWORD)z_low;
		    *(_QWORD *)&v38.x = v19;
		    v38.z = v20;
		    *(float *)&v24 = UnityEngine::Vector3::Dot((Vector3 *)&v38, &v39, z_low);
		    *(float *)&v17 = v40.x;
		    retstr->y = v40.y;
		    retstr->w = -*(float *)&v24;
		    LODWORD(retstr->x) = v17;
		    retstr->z = v28;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Matrix4x4 CalculateWorldToCameraMatrixRHS(Vector3 position, Quaternion rotation) => default; // 0x00000001833A3660-0x00000001833A38D0
		// Matrix4x4 CalculateWorldToCameraMatrixRHS(Vector3, Quaternion)
		Matrix4x4 *HG::Rendering::Runtime::GeometryUtils::CalculateWorldToCameraMatrixRHS(
		        Matrix4x4 *__return_ptr retstr,
		        Vector3 *position,
		        Quaternion *rotation,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Matrix4x4 *v9; // rax
		  __int128 v10; // xmm7
		  __int128 v11; // xmm8
		  __int128 v12; // xmm9
		  __int128 v13; // xmm10
		  __int64 v14; // xmm1_8
		  Quaternion v15; // xmm0
		  void (__fastcall *v16)(Quaternion *, Quaternion *, Vector3 *, __int128 *); // rax
		  void (__fastcall *v17)(_OWORD *, __int128 *); // rax
		  void (__fastcall *v18)(Matrix4x4 *, _OWORD *, __int128 *); // rax
		  Matrix4x4 *result; // rax
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Quaternion v24; // xmm0
		  __int64 v25; // xmm1_8
		  Matrix4x4 *v26; // rax
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int64 v30; // rax
		  __int64 v31; // rax
		  __int64 v32; // rax
		  Vector3 v33; // [rsp+30h] [rbp-D0h] BYREF
		  Quaternion v34; // [rsp+40h] [rbp-C0h] BYREF
		  __int128 v35; // [rsp+50h] [rbp-B0h] BYREF
		  __int128 v36; // [rsp+60h] [rbp-A0h]
		  __int128 v37; // [rsp+70h] [rbp-90h]
		  __int128 v38; // [rsp+80h] [rbp-80h]
		  __int128 v39; // [rsp+90h] [rbp-70h] BYREF
		  __int128 v40; // [rsp+A0h] [rbp-60h]
		  __int128 v41; // [rsp+B0h] [rbp-50h]
		  __int128 v42; // [rsp+C0h] [rbp-40h]
		  Quaternion v43; // [rsp+D0h] [rbp-30h] BYREF
		  Matrix4x4 v44; // [rsp+E0h] [rbp-20h] BYREF
		  _OWORD v45[4]; // [rsp+120h] [rbp+20h] BYREF
		  _OWORD v46[4]; // [rsp+160h] [rbp+60h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 401 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( v6 )
		    {
		      if ( LODWORD(v6->_0.namespaze) <= 0x191 )
		        sub_1800D2AB0(v6, wrapperArray);
		      if ( !v6[8]._1.cctor_thread )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(401, 0LL);
		      if ( Patch )
		      {
		        v24 = *rotation;
		        v25 = *(_QWORD *)&position->x;
		        v33.z = position->z;
		        v34 = v24;
		        *(_QWORD *)&v33.x = v25;
		        v26 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_192(&v44, Patch, &v33, &v34, 0LL);
		        v27 = *(_OWORD *)&v26->m01;
		        *(_OWORD *)&retstr->m00 = *(_OWORD *)&v26->m00;
		        v28 = *(_OWORD *)&v26->m02;
		        *(_OWORD *)&retstr->m01 = v27;
		        v29 = *(_OWORD *)&v26->m03;
		        result = retstr;
		        *(_OWORD *)&retstr->m02 = v28;
		        *(_OWORD *)&retstr->m03 = v29;
		        return result;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v6, wrapperArray);
		  }
		LABEL_5:
		  v33.z = -1.0;
		  *(_QWORD *)&v33.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  v9 = UnityEngine::Matrix4x4::Scale(&v44, &v33, 0LL);
		  v10 = *(_OWORD *)&v9->m00;
		  v11 = *(_OWORD *)&v9->m01;
		  v12 = *(_OWORD *)&v9->m02;
		  v13 = *(_OWORD *)&v9->m03;
		  *(float *)&v9 = position->z;
		  v14 = *(_QWORD *)&position->x;
		  *(_QWORD *)&v33.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  v15 = *rotation;
		  LODWORD(v34.z) = (_DWORD)v9;
		  v16 = (void (__fastcall *)(Quaternion *, Quaternion *, Vector3 *, __int128 *))qword_18F36FA58;
		  v43 = v15;
		  v33.z = 1.0;
		  *(_QWORD *)&v34.x = v14;
		  v35 = 0LL;
		  v36 = 0LL;
		  v37 = 0LL;
		  v38 = 0LL;
		  if ( !qword_18F36FA58 )
		  {
		    v16 = (void (__fastcall *)(Quaternion *, Quaternion *, Vector3 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                                    "UnityEngine.Matrix4x4::TRS_Injected("
		                                                                                    "UnityEngine.Vector3&,UnityEngine.Qua"
		                                                                                    "ternion&,UnityEngine.Vector3&,UnityE"
		                                                                                    "ngine.Matrix4x4&)");
		    if ( !v16 )
		    {
		      v30 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v30, 0LL);
		    }
		    qword_18F36FA58 = (__int64)v16;
		  }
		  v16(&v34, &v43, &v33, &v35);
		  v17 = (void (__fastcall *)(_OWORD *, __int128 *))qword_18F36FA60;
		  v45[0] = v35;
		  v45[1] = v36;
		  v45[2] = v37;
		  v45[3] = v38;
		  v39 = 0LL;
		  v40 = 0LL;
		  v41 = 0LL;
		  v42 = 0LL;
		  if ( !qword_18F36FA60 )
		  {
		    v17 = (void (__fastcall *)(_OWORD *, __int128 *))il2cpp_resolve_icall_1(
		                                                       "UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,Un"
		                                                       "ityEngine.Matrix4x4&)");
		    if ( !v17 )
		    {
		      v31 = sub_1802EE1B8("UnityEngine.Matrix4x4::Inverse_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v31, 0LL);
		    }
		    qword_18F36FA60 = (__int64)v17;
		  }
		  v17(v45, &v39);
		  v18 = (void (__fastcall *)(Matrix4x4 *, _OWORD *, __int128 *))qword_18F36FA50;
		  *(_OWORD *)&v44.m00 = v10;
		  v46[0] = v39;
		  *(_OWORD *)&v44.m01 = v11;
		  *(_OWORD *)&v44.m02 = v12;
		  *(_OWORD *)&v44.m03 = v13;
		  v46[1] = v40;
		  v46[2] = v41;
		  v35 = 0LL;
		  v46[3] = v42;
		  v36 = 0LL;
		  v37 = 0LL;
		  v38 = 0LL;
		  if ( !qword_18F36FA50 )
		  {
		    v18 = (void (__fastcall *)(Matrix4x4 *, _OWORD *, __int128 *))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injec"
		                                                                    "ted(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Un"
		                                                                    "ityEngine.Matrix4x4&)");
		    if ( !v18 )
		    {
		      v32 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::HGMultiplyMatrix4x4Fast_Injected(UnityEngine.Matrix4x4&,UnityEngine.Matrix4x4&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v32, 0LL);
		    }
		    qword_18F36FA50 = (__int64)v18;
		  }
		  v18(&v44, v46, &v35);
		  result = retstr;
		  v20 = v36;
		  *(_OWORD *)&retstr->m00 = v35;
		  v21 = v37;
		  *(_OWORD *)&retstr->m01 = v20;
		  v22 = v38;
		  *(_OWORD *)&retstr->m02 = v21;
		  *(_OWORD *)&retstr->m03 = v22;
		  return result;
		}
		
		[IDTag(1)]
		public static Matrix4x4 CalculateWorldToCameraMatrixRHS(Transform transform) => default; // 0x0000000189C69604-0x0000000189C6979C
		// Matrix4x4 CalculateWorldToCameraMatrixRHS(Transform)
		Matrix4x4 *HG::Rendering::Runtime::GeometryUtils::CalculateWorldToCameraMatrixRHS(
		        Matrix4x4 *__return_ptr retstr,
		        Transform *transform,
		        MethodInfo *method)
		{
		  Matrix4x4 *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int128 v8; // xmm6
		  __int128 v9; // xmm7
		  __int128 v10; // xmm8
		  __int128 v11; // xmm9
		  Matrix4x4 *localToWorldMatrix; // rax
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  Matrix4x4 *inverse; // rax
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  Matrix4x4 *v20; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  Matrix4x4 *result; // rax
		  Vector3 v26; // [rsp+28h] [rbp-E0h] BYREF
		  Matrix4x4 v27; // [rsp+38h] [rbp-D0h] BYREF
		  Matrix4x4 v28; // [rsp+78h] [rbp-90h] BYREF
		  Matrix4x4 v29[2]; // [rsp+B8h] [rbp-50h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(402, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(402, 0LL);
		    if ( Patch )
		    {
		      v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_193(v29, Patch, (Object *)transform, 0LL);
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v7, v6);
		  }
		  v26.z = -1.0;
		  *(_QWORD *)&v26.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  v5 = UnityEngine::Matrix4x4::Scale(&v28, &v26, 0LL);
		  v8 = *(_OWORD *)&v5->m00;
		  v9 = *(_OWORD *)&v5->m01;
		  v10 = *(_OWORD *)&v5->m02;
		  v11 = *(_OWORD *)&v5->m03;
		  if ( !transform )
		    goto LABEL_5;
		  localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v28, transform, 0LL);
		  v13 = *(_OWORD *)&localToWorldMatrix->m01;
		  *(_OWORD *)&v27.m00 = *(_OWORD *)&localToWorldMatrix->m00;
		  v14 = *(_OWORD *)&localToWorldMatrix->m02;
		  *(_OWORD *)&v27.m01 = v13;
		  v15 = *(_OWORD *)&localToWorldMatrix->m03;
		  *(_OWORD *)&v27.m02 = v14;
		  *(_OWORD *)&v27.m03 = v15;
		  inverse = UnityEngine::Matrix4x4::get_inverse(&v28, &v27, 0LL);
		  v17 = *(_OWORD *)&inverse->m01;
		  *(_OWORD *)&v27.m00 = *(_OWORD *)&inverse->m00;
		  v18 = *(_OWORD *)&inverse->m02;
		  *(_OWORD *)&v27.m01 = v17;
		  v19 = *(_OWORD *)&inverse->m03;
		  *(_OWORD *)&v27.m02 = v18;
		  *(_OWORD *)&v27.m03 = v19;
		  *(_OWORD *)&v28.m00 = v8;
		  *(_OWORD *)&v28.m01 = v9;
		  *(_OWORD *)&v28.m02 = v10;
		  *(_OWORD *)&v28.m03 = v11;
		  v20 = UnityEngine::Matrix4x4::op_Multiply(v29, &v28, &v27, 0LL);
		LABEL_7:
		  v22 = *(_OWORD *)&v20->m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v20->m00;
		  v23 = *(_OWORD *)&v20->m02;
		  *(_OWORD *)&retstr->m01 = v22;
		  v24 = *(_OWORD *)&v20->m03;
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v23;
		  *(_OWORD *)&retstr->m03 = v24;
		  return result;
		}
		
		public static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 sourceProjection, Vector4 clipPlane) => default; // 0x0000000189C68EA4-0x0000000189C691A4
		// Matrix4x4 CalculateObliqueMatrix(Matrix4x4, Vector4)
		Matrix4x4 *HG::Rendering::Runtime::GeometryUtils::CalculateObliqueMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        Matrix4x4 *sourceProjection,
		        Vector4 *clipPlane,
		        MethodInfo *method)
		{
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  MethodInfo *v10; // rdx
		  MethodInfo *v11; // rdx
		  __int128 *v12; // rax
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __m128i v15; // xmm6
		  float Item; // xmm7_4
		  float v17; // xmm8_4
		  float v18; // xmm9_4
		  Vector4 v19; // xmm2
		  float v20; // xmm10_4
		  MethodInfo *v21; // r8
		  float v22; // xmm3_4
		  MethodInfo *v23; // r8
		  MethodInfo *v24; // r9
		  __m128 v25; // xmm6
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  Matrix4x4 *v36; // rax
		  __int128 v37; // xmm1
		  Matrix4x4 *result; // rax
		  __m128i v39; // [rsp+38h] [rbp-D0h] BYREF
		  Vector4 v40; // [rsp+48h] [rbp-C0h] BYREF
		  Vector4 v41; // [rsp+58h] [rbp-B0h] BYREF
		  Matrix4x4 v42; // [rsp+68h] [rbp-A0h] BYREF
		  Vector4 v43; // [rsp+A8h] [rbp-60h] BYREF
		  Matrix4x4 v44; // [rsp+B8h] [rbp-50h] BYREF
		  __m128i v45; // [rsp+F8h] [rbp-10h] BYREF
		  Matrix4x4 v46[2]; // [rsp+108h] [rbp+0h] BYREF
		
		  *(_QWORD *)&v40.z = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(403, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(403, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v31, v30);
		    v32 = *(_OWORD *)&sourceProjection->m00;
		    v41 = *clipPlane;
		    v33 = *(_OWORD *)&sourceProjection->m01;
		    *(_OWORD *)&v44.m00 = v32;
		    v34 = *(_OWORD *)&sourceProjection->m02;
		    *(_OWORD *)&v44.m01 = v33;
		    v35 = *(_OWORD *)&sourceProjection->m03;
		    *(_OWORD *)&v44.m02 = v34;
		    *(_OWORD *)&v44.m03 = v35;
		    v36 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_194(v46, Patch, &v44, &v41, 0LL);
		    v37 = *(_OWORD *)&v36->m01;
		    *(_OWORD *)&retstr->m00 = *(_OWORD *)&v36->m00;
		    v27 = *(_OWORD *)&v36->m02;
		    *(_OWORD *)&retstr->m01 = v37;
		    v28 = *(_OWORD *)&v36->m03;
		  }
		  else
		  {
		    v7 = *(_OWORD *)&sourceProjection->m01;
		    *(_OWORD *)&v42.m00 = *(_OWORD *)&sourceProjection->m00;
		    v8 = *(_OWORD *)&sourceProjection->m02;
		    *(_OWORD *)&v42.m01 = v7;
		    v9 = *(_OWORD *)&sourceProjection->m03;
		    *(_OWORD *)&v42.m02 = v8;
		    *(_OWORD *)&v42.m03 = v9;
		    UnityEngine::Matrix4x4::get_inverse(v46, sourceProjection, 0LL);
		    v39.m128i_i32[0] = UnityEngine::Mathf::Sign(clipPlane->x, v10);
		    *(float *)&v8 = UnityEngine::Mathf::Sign(clipPlane->y, v11);
		    v13 = *v12;
		    v39.m128i_i64[1] = 0x3F8000003F800000LL;
		    v39.m128i_i32[1] = v8;
		    *(_OWORD *)&v44.m00 = v13;
		    v14 = v12[1];
		    *(_OWORD *)&v44.m02 = v12[2];
		    *(_OWORD *)&v44.m01 = v14;
		    *(_OWORD *)&v44.m03 = v12[3];
		    v15 = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::op_Multiply(&v41, &v44, (Vector4 *)&v39, 0LL));
		    Item = UnityEngine::Matrix4x4::get_Item(&v42, 3, 0LL);
		    *(float *)&v14 = UnityEngine::Matrix4x4::get_Item(&v42, 7, 0LL);
		    v40.x = Item;
		    v17 = *(float *)&v14;
		    LODWORD(v40.y) = v14;
		    v18 = UnityEngine::Matrix4x4::get_Item(&v42, 11, 0LL);
		    v40.z = v18;
		    *(float *)&v14 = UnityEngine::Matrix4x4::get_Item(&v42, 15, 0LL);
		    v19 = *clipPlane;
		    v20 = *(float *)&v14;
		    v39 = v15;
		    LODWORD(v40.w) = v14;
		    v45 = v15;
		    v43 = v19;
		    v41 = v19;
		    *(float *)&v14 = UnityEngine::Vector4::Dot(&v40, (Vector4 *)&v39, v21);
		    v22 = *(float *)&v14 + *(float *)&v14;
		    *(float *)&v14 = UnityEngine::Vector4::Dot(&v43, (Vector4 *)&v45, v23);
		    v25 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Multiply(
		                                                     &v43,
		                                                     &v41,
		                                                     v22 / *(float *)&v14,
		                                                     v24));
		    UnityEngine::Matrix4x4::set_Item(&v42, 2, v25.m128_f32[0] - Item, 0LL);
		    UnityEngine::Matrix4x4::set_Item(&v42, 6, _mm_shuffle_ps(v25, v25, 85).m128_f32[0] - v17, 0LL);
		    UnityEngine::Matrix4x4::set_Item(&v42, 10, _mm_shuffle_ps(v25, v25, 170).m128_f32[0] - v18, 0LL);
		    UnityEngine::Matrix4x4::set_Item(&v42, 14, _mm_shuffle_ps(v25, v25, 255).m128_f32[0] - v20, 0LL);
		    v26 = *(_OWORD *)&v42.m01;
		    *(_OWORD *)&retstr->m00 = *(_OWORD *)&v42.m00;
		    v27 = *(_OWORD *)&v42.m02;
		    *(_OWORD *)&retstr->m01 = v26;
		    v28 = *(_OWORD *)&v42.m03;
		  }
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v27;
		  *(_OWORD *)&retstr->m03 = v28;
		  return result;
		}
		
		[IDTag(1)]
		public static Matrix4x4 CalculateReflectionMatrix(Vector3 position, Vector3 normal) => default; // 0x0000000189C69330-0x0000000189C69448
		// Matrix4x4 CalculateReflectionMatrix(Vector3, Vector3)
		Matrix4x4 *HG::Rendering::Runtime::GeometryUtils::CalculateReflectionMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        Vector3 *position,
		        Vector3 *normal,
		        MethodInfo *method)
		{
		  __int64 v7; // rax
		  __int64 v8; // xmm0_8
		  __int64 v9; // xmm0_8
		  Matrix4x4 *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v12; // rcx
		  float z; // eax
		  __int64 v14; // xmm0_8
		  float v15; // eax
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  Matrix4x4 *result; // rax
		  Vector3 v20; // [rsp+38h] [rbp-19h] BYREF
		  Vector4 v21; // [rsp+48h] [rbp-9h] BYREF
		  Vector4 v22; // [rsp+58h] [rbp+7h] BYREF
		  Matrix4x4 v23; // [rsp+68h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(404, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(404, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, 0LL);
		    z = normal->z;
		    *(_QWORD *)&v21.x = *(_QWORD *)&normal->x;
		    v14 = *(_QWORD *)&position->x;
		    v21.z = z;
		    v15 = position->z;
		    *(_QWORD *)&v20.x = v14;
		    v20.z = v15;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_196(&v23, Patch, &v20, (Vector3 *)&v21, 0LL);
		  }
		  else
		  {
		    v7 = sub_182FAE2B0(&v21, normal);
		    v8 = *(_QWORD *)v7;
		    LODWORD(v7) = *(_DWORD *)(v7 + 8);
		    *(_QWORD *)&v20.x = v8;
		    v9 = *(_QWORD *)&position->x;
		    LODWORD(v20.z) = v7;
		    *(float *)&v7 = position->z;
		    *(_QWORD *)&v21.x = v9;
		    LODWORD(v21.z) = v7;
		    v21 = *HG::Rendering::Runtime::GeometryUtils::Plane(&v22, (Vector3 *)&v21, &v20, 0LL);
		    v10 = HG::Rendering::Runtime::GeometryUtils::CalculateReflectionMatrix(&v23, &v21, 0LL);
		  }
		  v16 = *(_OWORD *)&v10->m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v10->m00;
		  v17 = *(_OWORD *)&v10->m02;
		  *(_OWORD *)&retstr->m01 = v16;
		  v18 = *(_OWORD *)&v10->m03;
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v17;
		  *(_OWORD *)&retstr->m03 = v18;
		  return result;
		}
		
		[IDTag(0)]
		public static Matrix4x4 CalculateReflectionMatrix(Vector4 plane) => default; // 0x0000000189C69448-0x0000000189C69604
		// Matrix4x4 CalculateReflectionMatrix(Vector4)
		Matrix4x4 *HG::Rendering::Runtime::GeometryUtils::CalculateReflectionMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        Vector4 *plane,
		        MethodInfo *method)
		{
		  float w; // xmm0_4
		  __int128 v6; // xmm1
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Matrix4x4 *v12; // rax
		  __int128 v13; // xmm1
		  Matrix4x4 *result; // rax
		  Vector4 v15; // [rsp+20h] [rbp-50h] BYREF
		  Matrix4x4 v16; // [rsp+30h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(405, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(405, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    v15 = *plane;
		    v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_195(&v16, Patch, &v15, 0LL);
		    v13 = *(_OWORD *)&v12->m01;
		    *(_OWORD *)&retstr->m00 = *(_OWORD *)&v12->m00;
		    v7 = *(_OWORD *)&v12->m02;
		    *(_OWORD *)&retstr->m01 = v13;
		    v8 = *(_OWORD *)&v12->m03;
		  }
		  else
		  {
		    v16.m00 = 1.0 - (float)((float)(plane->x + plane->x) * plane->x);
		    v16.m01 = (float)(plane->x * -2.0) * plane->y;
		    v16.m02 = (float)(plane->x * -2.0) * plane->z;
		    v16.m03 = (float)(plane->w * -2.0) * plane->x;
		    v16.m10 = (float)(plane->y * -2.0) * plane->x;
		    v16.m11 = 1.0 - (float)((float)(plane->y + plane->y) * plane->y);
		    v16.m12 = (float)(plane->y * -2.0) * plane->z;
		    v16.m13 = (float)(plane->w * -2.0) * plane->y;
		    v16.m20 = (float)(plane->z * -2.0) * plane->x;
		    v16.m21 = (float)(plane->z * -2.0) * plane->y;
		    v16.m22 = 1.0 - (float)((float)(plane->z + plane->z) * plane->z);
		    w = plane->w;
		    v16.m30 = 0.0;
		    v16.m31 = 0.0;
		    v6 = *(_OWORD *)&v16.m01;
		    v16.m32 = 0.0;
		    v16.m33 = 1.0;
		    v16.m23 = (float)(w * -2.0) * plane->z;
		    *(_OWORD *)&retstr->m00 = *(_OWORD *)&v16.m00;
		    v7 = *(_OWORD *)&v16.m02;
		    *(_OWORD *)&retstr->m01 = v6;
		    v8 = *(_OWORD *)&v16.m03;
		  }
		  *(_OWORD *)&retstr->m02 = v7;
		  result = retstr;
		  *(_OWORD *)&retstr->m03 = v8;
		  return result;
		}
		
		public static bool IsProjectionMatrixOblique(Matrix4x4 projectionMatrix) => default; // 0x0000000183251C10-0x0000000183251CA0
		// Boolean IsProjectionMatrixOblique(Matrix4x4)
		bool HG::Rendering::Runtime::GeometryUtils::IsProjectionMatrixOblique(Matrix4x4 *projectionMatrix, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  Matrix4x4 v10; // [rsp+20h] [rbp-58h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 406 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x196 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*(_QWORD *)&v3[8]._1.thread_static_fields_offset )
		        return UnityEngine::Matrix4x4::get_Item(projectionMatrix, 2, 0LL) != 0.0
		            || UnityEngine::Matrix4x4::get_Item(projectionMatrix, 6, 0LL) != 0.0;
		      Patch = IFix::WrappersManagerImpl::GetPatch(406, 0LL);
		      if ( Patch )
		      {
		        v7 = *(_OWORD *)&projectionMatrix->m01;
		        *(_OWORD *)&v10.m00 = *(_OWORD *)&projectionMatrix->m00;
		        v8 = *(_OWORD *)&projectionMatrix->m02;
		        *(_OWORD *)&v10.m01 = v7;
		        v9 = *(_OWORD *)&projectionMatrix->m03;
		        *(_OWORD *)&v10.m02 = v8;
		        *(_OWORD *)&v10.m03 = v9;
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_197(Patch, &v10, 0LL);
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  return UnityEngine::Matrix4x4::get_Item(projectionMatrix, 2, 0LL) != 0.0
		      || UnityEngine::Matrix4x4::get_Item(projectionMatrix, 6, 0LL) != 0.0;
		}
		
		public static Matrix4x4 CalculateProjectionMatrix(Camera camera) => default; // 0x0000000189C691A4-0x0000000189C69330
		// Matrix4x4 CalculateProjectionMatrix(Camera)
		Matrix4x4 *HG::Rendering::Runtime::GeometryUtils::CalculateProjectionMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        Camera *camera,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  float GateFittedFieldOfView; // xmm8_4
		  float aspect; // xmm7_4
		  float v9; // xmm6_4
		  float v10; // xmm0_4
		  Matrix4x4 *v11; // rax
		  float orthographicSize; // xmm8_4
		  float v13; // xmm6_4
		  float v14; // xmm7_4
		  float v15; // xmm6_4
		  float farClipPlane; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  Matrix4x4 *result; // rax
		  Matrix4x4 v22; // [rsp+40h] [rbp-78h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(407, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(407, 0LL);
		    if ( Patch )
		    {
		      v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_193(&v22, Patch, (Object *)camera, 0LL);
		      goto LABEL_9;
		    }
		LABEL_7:
		    sub_1800D8260(v6, v5);
		  }
		  if ( !camera )
		    goto LABEL_7;
		  if ( UnityEngine::Camera::get_orthographic(camera, 0LL) )
		  {
		    orthographicSize = UnityEngine::Camera::get_orthographicSize(camera, 0LL);
		    v13 = UnityEngine::Camera::get_orthographicSize(camera, 0LL);
		    v14 = UnityEngine::Camera::get_aspect(camera, 0LL) * v13;
		    v15 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		    farClipPlane = UnityEngine::Camera::get_farClipPlane(camera, 0LL);
		    v11 = UnityEngine::Matrix4x4::Ortho(&v22, -v14, v14, -orthographicSize, orthographicSize, v15, farClipPlane, 0LL);
		  }
		  else
		  {
		    GateFittedFieldOfView = UnityEngine::Camera::GetGateFittedFieldOfView(camera, 0LL);
		    aspect = UnityEngine::Camera::get_aspect(camera, 0LL);
		    v9 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
		    v10 = UnityEngine::Camera::get_farClipPlane(camera, 0LL);
		    v11 = UnityEngine::Matrix4x4::Perspective(&v22, GateFittedFieldOfView, aspect, v9, v10, 0LL);
		  }
		LABEL_9:
		  v18 = *(_OWORD *)&v11->m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v11->m00;
		  v19 = *(_OWORD *)&v11->m02;
		  *(_OWORD *)&retstr->m01 = v18;
		  v20 = *(_OWORD *)&v11->m03;
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v19;
		  *(_OWORD *)&retstr->m03 = v20;
		  return result;
		}
		
		public static void IntersectPlanePlane(float4 plane1, float4 plane2, out float3 rayOrigin, out float3 rayDirection) {
			rayOrigin = default;
			rayDirection = default;
		} // 0x0000000189C699CC-0x0000000189C69CF0
		// Void IntersectPlanePlane(float4, float4, float3 ByRef, float3 ByRef)
		void HG::Rendering::Runtime::GeometryUtils::IntersectPlanePlane(
		        float4 *plane1,
		        float4 *plane2,
		        float3 *rayOrigin,
		        float3 *rayDirection,
		        MethodInfo *method)
		{
		  __int64 v9; // r9
		  __m128 y_low; // xmm1
		  __m128 v11; // xmm3
		  float3__StaticFields *static_fields; // rdx
		  float z; // xmm4_4
		  float v14; // eax
		  float3__StaticFields *v15; // rcx
		  float v16; // eax
		  __int64 v17; // rax
		  __int64 v18; // rax
		  __m128 v19; // xmm1
		  __m128 x_low; // xmm0
		  float v21; // xmm2_4
		  float v22; // ecx
		  __int64 v23; // r9
		  __int64 v24; // rax
		  __m128 v25; // xmm3
		  float v26; // ecx
		  __m128i v27; // xmm0
		  MethodInfo *v28; // r8
		  MethodInfo *v29; // r9
		  float v30; // xmm2_4
		  __m128 v31; // xmm1
		  __m128 v32; // xmm0
		  float w; // xmm2_4
		  float3 *v34; // rax
		  float v35; // xmm2_4
		  __int64 v36; // xmm3_8
		  MethodInfo *v37; // r9
		  float3 *v38; // rax
		  __int64 v39; // xmm3_8
		  MethodInfo *v40; // r9
		  float3 *v41; // rax
		  __m128 v42; // xmm2
		  __m128 v43; // xmm1
		  __int64 v44; // r10
		  MethodInfo *v45; // r8
		  float v46; // xmm4_4
		  MethodInfo *v47; // r9
		  float3 *v48; // rax
		  __int64 v49; // xmm3_8
		  MethodInfo *v50; // r9
		  float3 *v51; // rax
		  __int64 v52; // xmm3_8
		  MethodInfo *v53; // r9
		  float3 *v54; // rax
		  float v55; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  float4 v59; // xmm1
		  Vector3 vector; // [rsp+30h] [rbp-50h] BYREF
		  Vector3 value; // [rsp+40h] [rbp-40h] BYREF
		  float3 v62; // [rsp+50h] [rbp-30h] BYREF
		  float4 v63; // [rsp+60h] [rbp-20h] BYREF
		  float4 v64; // [rsp+70h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(408, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(408, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v58, v57);
		    v59 = *plane1;
		    v64 = *plane2;
		    v63 = v59;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_198(Patch, &v63, &v64, rayOrigin, rayDirection, 0LL);
		  }
		  else
		  {
		    y_low = (__m128)LODWORD(plane2->y);
		    v11 = (__m128)LODWORD(plane1->y);
		    static_fields = TypeInfo::Unity::Mathematics::float3->static_fields;
		    z = plane1->z;
		    vector.z = plane2->z;
		    value.z = z;
		    v14 = static_fields->zero.z;
		    *(_QWORD *)&rayOrigin->x = *(_QWORD *)&static_fields->zero.x;
		    rayOrigin->z = v14;
		    v15 = TypeInfo::Unity::Mathematics::float3->static_fields;
		    v16 = v15->zero.z;
		    *(_QWORD *)&rayDirection->x = *(_QWORD *)&v15->zero.x;
		    *(_QWORD *)&vector.x = _mm_unpacklo_ps((__m128)LODWORD(plane2->x), y_low).m128_u64[0];
		    *(_QWORD *)&value.x = _mm_unpacklo_ps((__m128)LODWORD(plane1->x), v11).m128_u64[0];
		    rayDirection->z = v16;
		    v17 = sub_182FAD1A0(&v63, &value, &vector, v9);
		    v11.m128_u64[0] = *(_QWORD *)v17;
		    LODWORD(v17) = *(_DWORD *)(v17 + 8);
		    *(_QWORD *)&value.x = v11.m128_u64[0];
		    LODWORD(value.z) = v17;
		    v18 = sub_1834C8E00(&v63, &value);
		    v19 = (__m128)LODWORD(plane2->y);
		    x_low = (__m128)LODWORD(plane2->x);
		    v21 = plane2->z;
		    v22 = *(float *)(v18 + 8);
		    v11.m128_u64[0] = *(_QWORD *)v18;
		    *(_QWORD *)&rayDirection->x = *(_QWORD *)v18;
		    rayDirection->z = v22;
		    value.z = v22;
		    vector.z = v21;
		    *(_QWORD *)&value.x = v11.m128_u64[0];
		    *(_QWORD *)&vector.x = _mm_unpacklo_ps(x_low, v19).m128_u64[0];
		    v24 = sub_182FAD1A0(&v64, &vector, &value, v23);
		    v25 = (__m128)LODWORD(plane1->y);
		    vector.z = plane1->z;
		    v26 = *(float *)(v24 + 8);
		    *(_QWORD *)&value.x = *(_QWORD *)v24;
		    v27 = (__m128i)_mm_unpacklo_ps((__m128)LODWORD(plane1->x), v25);
		    value.z = v26;
		    *(_QWORD *)&vector.x = v27.m128i_i64[0];
		    *(float *)v27.m128i_i32 = Dest::Math::Vector3ex::Dot(&vector, &value, v28);
		    if ( COERCE_FLOAT(_mm_cvtsi128_si32(v27) & 0x7FFFFFFF) > 0.000001 )
		    {
		      v30 = plane1->z;
		      v31 = (__m128)LODWORD(plane2->y);
		      *(_QWORD *)&vector.x = _mm_unpacklo_ps((__m128)LODWORD(plane1->x), v25).m128_u64[0];
		      v32 = (__m128)LODWORD(plane2->x);
		      vector.z = v30;
		      value.z = plane2->z;
		      w = plane2->w;
		      *(_QWORD *)&value.x = _mm_unpacklo_ps(v32, v31).m128_u64[0];
		      v34 = Unity::Mathematics::float3::op_Multiply((float3 *)&v63, (float3 *)&value, w, v29);
		      v35 = plane1->w;
		      v36 = *(_QWORD *)&v34->x;
		      *(float *)&v34 = v34->z;
		      *(_QWORD *)&value.x = v36;
		      LODWORD(value.z) = (_DWORD)v34;
		      v38 = Unity::Mathematics::float3::op_Multiply((float3 *)&v63, (float3 *)&vector, v35, v37);
		      v39 = *(_QWORD *)&v38->x;
		      *(float *)&v38 = v38->z;
		      *(_QWORD *)&vector.x = v39;
		      LODWORD(vector.z) = (_DWORD)v38;
		      v41 = Unity::Mathematics::float3::op_Subtraction((float3 *)&v63, (float3 *)&vector, (float3 *)&value, v40);
		      v42 = (__m128)LODWORD(plane1->y);
		      vector.z = plane1->z;
		      v32.m128_u64[0] = *(_QWORD *)&v41->x;
		      *(float *)&v41 = v41->z;
		      v43 = (__m128)LODWORD(plane2->y);
		      *(_QWORD *)&value.x = v32.m128_u64[0];
		      v32.m128_u64[0] = _mm_unpacklo_ps((__m128)LODWORD(plane1->x), v42).m128_u64[0];
		      v42.m128_i32[0] = LODWORD(plane2->z);
		      *(_QWORD *)&vector.x = v32.m128_u64[0];
		      *(_QWORD *)&v63.x = _mm_unpacklo_ps((__m128)LODWORD(plane2->x), v43).m128_u64[0];
		      v32.m128_u64[0] = *(_QWORD *)v44;
		      LODWORD(value.z) = (_DWORD)v41;
		      LODWORD(v41) = *(_DWORD *)(v44 + 8);
		      *(_QWORD *)&v62.x = v32.m128_u64[0];
		      LODWORD(v63.z) = v42.m128_i32[0];
		      LODWORD(v62.z) = (_DWORD)v41;
		      v32.m128_f32[0] = Dest::Math::Vector3ex::Dot(&vector, &value, v45);
		      v48 = Unity::Mathematics::float3::op_Multiply((float3 *)&v64, v32.m128_f32[0] / v46, &v62, v47);
		      v42.m128_i32[0] = LODWORD(plane2->w);
		      v49 = *(_QWORD *)&v48->x;
		      *(float *)&v48 = v48->z;
		      *(_QWORD *)&v62.x = v49;
		      LODWORD(v62.z) = (_DWORD)v48;
		      v51 = Unity::Mathematics::float3::op_Multiply((float3 *)&v64, (float3 *)&v63, v42.m128_f32[0], v50);
		      v52 = *(_QWORD *)&v51->x;
		      *(float *)&v51 = v51->z;
		      *(_QWORD *)&v63.x = v52;
		      LODWORD(v63.z) = (_DWORD)v51;
		      v54 = Unity::Mathematics::float3::op_Addition((float3 *)&v64, (float3 *)&v63, &v62, v53);
		      v55 = v54->z;
		      *(_QWORD *)&rayOrigin->x = *(_QWORD *)&v54->x;
		      rayOrigin->z = v55;
		    }
		  }
		}
		
		public static bool IntersectSpherePlaneBounds(float3 sphereCenter, float radius, float3 frustumApex, float3 frustumOrientation, float4 left, float4 right, float4 bottom, float4 top, float3 leftBottom, float3 leftTop, float3 rightBottom, float3 rightTop) => default; // 0x0000000189C69FA8-0x0000000189C6A6E4
		// Boolean IntersectSpherePlaneBounds(float3, Single, float3, float3, float4, float4, float4, float4, float3, float3, float3, float3)
		bool HG::Rendering::Runtime::GeometryUtils::IntersectSpherePlaneBounds(
		        float3 *sphereCenter,
		        float radius,
		        float3 *frustumApex,
		        float3 *frustumOrientation,
		        float4 *left,
		        float4 *right,
		        float4 *bottom,
		        float4 *top,
		        float3 *leftBottom,
		        float3 *leftTop,
		        float3 *rightBottom,
		        float3 *rightTop,
		        MethodInfo *method)
		{
		  float v16; // xmm7_4
		  MethodInfo *v17; // r8
		  float z; // eax
		  __m128 y_low; // xmm1
		  float v20; // xmm2_4
		  __int128 w_low; // xmm8
		  __int128 v22; // xmm11
		  __int128 v23; // xmm13
		  float w; // xmm5_4
		  unsigned __int64 v25; // xmm0_8
		  __m128 v26; // xmm1
		  unsigned __int64 v27; // xmm0_8
		  __m128 v28; // xmm1
		  unsigned __int64 v29; // xmm0_8
		  __m128 v30; // xmm1
		  float v31; // xmm2_4
		  __int64 v32; // xmm0_8
		  float v33; // xmm2_4
		  __m128 x_low; // xmm0
		  float v35; // xmm2_4
		  float v36; // xmm9_4
		  MethodInfo *v37; // r8
		  float v38; // xmm12_4
		  MethodInfo *v39; // r8
		  float v40; // xmm14_4
		  MethodInfo *v41; // r8
		  float *v42; // r10
		  float *v43; // r11
		  __m128i v44; // xmm5
		  float v45; // xmm6_4
		  int v46; // edx
		  int v47; // ecx
		  unsigned int v48; // r8d
		  unsigned int v49; // ecx
		  __m128 v51; // xmm0
		  __m128 v52; // xmm1
		  float v53; // xmm2_4
		  float3 *v54; // rax
		  __int64 v55; // xmm0_8
		  __int64 v56; // xmm3_8
		  MethodInfo *v57; // r9
		  float3 *v58; // rax
		  __int64 v59; // xmm2_8
		  MethodInfo *v60; // r9
		  float3 *v61; // rax
		  MethodInfo *v62; // r8
		  MethodInfo *v63; // r9
		  float v64; // xmm4_4
		  __int64 v65; // xmm0_8
		  float v66; // ecx
		  __int64 v67; // xmm0_8
		  float v68; // eax
		  __int64 v69; // xmm0_8
		  float v70; // eax
		  __int64 v71; // xmm0_8
		  float v72; // eax
		  __int64 v73; // xmm0_8
		  float v74; // eax
		  float3 *v75; // rax
		  __int64 v76; // xmm2_8
		  MethodInfo *v77; // r9
		  float3 *v78; // rax
		  __int64 v79; // xmm2_8
		  MethodInfo *v80; // r8
		  float v81; // xmm0_4
		  float v82; // edx
		  unsigned __int64 v83; // xmm3_8
		  float3 *v84; // rax
		  float v85; // eax
		  __int64 v86; // xmm0_8
		  float v87; // eax
		  __int64 v88; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int64 v91; // xmm0_8
		  __int64 v92; // xmm0_8
		  __int64 v93; // xmm0_8
		  __int64 v94; // xmm0_8
		  float4 v95; // xmm1
		  __int64 v96; // xmm0_8
		  unsigned __int64 v97; // xmm0_8
		  Vector3 v98; // [rsp+78h] [rbp-90h] BYREF
		  Vector3 v99; // [rsp+88h] [rbp-80h] BYREF
		  unsigned int v100; // [rsp+98h] [rbp-70h]
		  Vector3 v101; // [rsp+A8h] [rbp-60h] BYREF
		  Vector3 v102; // [rsp+B8h] [rbp-50h] BYREF
		  __m128 vector; // [rsp+C8h] [rbp-40h] BYREF
		  Vector3 v104; // [rsp+D8h] [rbp-30h] BYREF
		  Vector3 v105; // [rsp+E8h] [rbp-20h] BYREF
		  float4 v106; // [rsp+F8h] [rbp-10h] BYREF
		  float4 value; // [rsp+108h] [rbp+0h] BYREF
		  float4 v108; // [rsp+118h] [rbp+10h] BYREF
		  float4 v109; // [rsp+128h] [rbp+20h] BYREF
		
		  v16 = radius;
		  if ( !IFix::WrappersManagerImpl::IsPatched(409, 0LL) )
		  {
		    z = sphereCenter->z;
		    y_low = (__m128)LODWORD(left->y);
		    v20 = left->z;
		    w_low = LODWORD(left->w);
		    v22 = LODWORD(right->w);
		    v23 = LODWORD(bottom->w);
		    w = top->w;
		    *(_QWORD *)&value.x = *(_QWORD *)&sphereCenter->x;
		    v25 = _mm_unpacklo_ps((__m128)LODWORD(left->x), y_low).m128_u64[0];
		    v26 = (__m128)LODWORD(right->y);
		    vector.m128_u64[0] = v25;
		    *(_QWORD *)&v105.x = *(_QWORD *)&sphereCenter->x;
		    v27 = _mm_unpacklo_ps((__m128)LODWORD(right->x), v26).m128_u64[0];
		    v28 = (__m128)LODWORD(bottom->y);
		    *(_QWORD *)&v104.x = v27;
		    *(_QWORD *)&v102.x = *(_QWORD *)&sphereCenter->x;
		    v29 = _mm_unpacklo_ps((__m128)LODWORD(bottom->x), v28).m128_u64[0];
		    v30 = (__m128)LODWORD(top->y);
		    vector.m128_f32[2] = v20;
		    v31 = right->z;
		    *(_QWORD *)&v101.x = v29;
		    v32 = *(_QWORD *)&sphereCenter->x;
		    v104.z = v31;
		    v33 = bottom->z;
		    *(_QWORD *)&v99.x = v32;
		    x_low = (__m128)LODWORD(top->x);
		    v101.z = v33;
		    v35 = top->z;
		    *(_QWORD *)&v98.x = _mm_unpacklo_ps(x_low, v30).m128_u64[0];
		    LODWORD(v106.x) = w_low;
		    LODWORD(v106.y) = v22;
		    LODWORD(v106.z) = v23;
		    v106.w = w;
		    v98.z = v35;
		    value.z = z;
		    v105.z = z;
		    v102.z = z;
		    v99.z = z;
		    v36 = Dest::Math::Vector3ex::Dot((Vector3 *)&vector, (Vector3 *)&value, v17);
		    vector.m128_f32[0] = v36;
		    v38 = Dest::Math::Vector3ex::Dot(&v104, &v105, v37);
		    vector.m128_f32[1] = v38;
		    v40 = Dest::Math::Vector3ex::Dot(&v101, &v102, v39);
		    vector.m128_f32[2] = v40;
		    vector.m128_i32[3] = Dest::Math::Vector3ex::Dot(&v98, &v99, v41);
		    v45 = vector.m128_f32[3];
		    LOBYTE(v100) = v106.x > vector.m128_f32[0];
		    HIBYTE(v100) = _mm_shuffle_ps((__m128)v106, (__m128)v106, 255).m128_f32[0] > _mm_shuffle_ps(vector, vector, 255).m128_f32[0];
		    v30.m128_f32[0] = _mm_shuffle_ps((__m128)v106, (__m128)v106, 85).m128_f32[0];
		    x_low.m128_f32[0] = _mm_shuffle_ps(vector, vector, 85).m128_f32[0];
		    *(_WORD *)((char *)&v100 + 1) = v30.m128_f32[0] > x_low.m128_f32[0];
		    BYTE2(v100) = _mm_shuffle_ps((__m128)v106, (__m128)v106, 170).m128_f32[0] > _mm_shuffle_ps(vector, vector, 170).m128_f32[0];
		    v46 = (v106.x > vector.m128_f32[0]) | 2;
		    if ( v30.m128_f32[0] <= x_low.m128_f32[0] )
		      v46 = v106.x > vector.m128_f32[0];
		    v47 = v46 | 4;
		    if ( !BYTE2(v100) )
		      v47 = v46;
		    v48 = v47 | 8;
		    if ( !HIBYTE(v100) )
		      v48 = v47;
		    v49 = (16843009
		         * ((((v48 - ((v48 >> 1) & 0x55555555)) & 0x33333333)
		           + (((v48 - ((v48 >> 1) & 0x55555555)) >> 2) & 0x33333333)
		           + ((((v48 - ((v48 >> 1) & 0x55555555)) & 0x33333333) + (((v48 - ((v48 >> 1) & 0x55555555)) >> 2) & 0x33333333)) >> 4)) & 0xF0F0F0F)) >> 24;
		    if ( v49 == 4 )
		      return 1;
		    if ( v49 == 3 )
		    {
		      if ( v48 != 7 )
		      {
		        if ( v48 == 11 )
		        {
		          v44 = (__m128i)v23;
		          v45 = v40;
		        }
		        else if ( v48 == 13 )
		        {
		          v44 = (__m128i)v22;
		          v45 = v38;
		        }
		        else
		        {
		          v44 = (__m128i)w_low;
		          v45 = v36;
		        }
		      }
		      *(float *)v44.m128i_i32 = *(float *)v44.m128i_i32 - v45;
		      LODWORD(v81) = _mm_cvtsi128_si32(v44) & 0x7FFFFFFF;
		      return v16 > v81;
		    }
		    if ( v49 != 2 )
		    {
		      if ( v49 != 1 )
		        return !v49;
		      v51 = 0LL;
		      v52 = 0LL;
		      v53 = 0.0;
		      if ( v48 == 1 )
		      {
		        v51 = (__m128)*(unsigned int *)v42;
		        v52 = (__m128)*((unsigned int *)v42 + 1);
		        v53 = v42[2];
		      }
		      else
		      {
		        if ( v48 == 2 )
		        {
		          v51 = (__m128)*(unsigned int *)v43;
		          v44 = (__m128i)v22;
		          v52 = (__m128)*((unsigned int *)v43 + 1);
		          v45 = v38;
		          v53 = v43[2];
		          goto LABEL_24;
		        }
		        if ( v48 != 3 )
		        {
		          if ( v48 == 4 )
		          {
		            v51 = (__m128)LODWORD(bottom->x);
		            v44 = (__m128i)v23;
		            v52 = (__m128)LODWORD(bottom->y);
		            v45 = v40;
		            v53 = bottom->z;
		            goto LABEL_24;
		          }
		          if ( v48 == 8 )
		          {
		            v51 = (__m128)LODWORD(top->x);
		            v52 = (__m128)LODWORD(top->y);
		            v53 = top->z;
		LABEL_24:
		            v98.z = v53;
		            *(float *)v44.m128i_i32 = *(float *)v44.m128i_i32 - v45;
		            *(_QWORD *)&v98.x = _mm_unpacklo_ps(v51, v52).m128_u64[0];
		            v54 = Unity::Mathematics::float3::op_Multiply(
		                    (float3 *)&v99,
		                    (float3 *)&v98,
		                    COERCE_FLOAT(_mm_cvtsi128_si32(v44) & 0x7FFFFFFF),
		                    (MethodInfo *)HIWORD(v100));
		            v55 = *(_QWORD *)&sphereCenter->x;
		            v56 = *(_QWORD *)&v54->x;
		            v98.z = v54->z;
		            v99.z = sphereCenter->z;
		            *(_QWORD *)&v98.x = v56;
		            *(_QWORD *)&v99.x = v55;
		            v58 = Unity::Mathematics::float3::op_Addition((float3 *)&v101, (float3 *)&v99, (float3 *)&v98, v57);
		            *(_QWORD *)&v99.x = *(_QWORD *)&frustumApex->x;
		            v59 = *(_QWORD *)&v58->x;
		            v98.z = v58->z;
		            v99.z = frustumApex->z;
		            *(_QWORD *)&v98.x = v59;
		            v61 = Unity::Mathematics::float3::op_Subtraction((float3 *)&v101, (float3 *)&v99, (float3 *)&v98, v60);
		            if ( v16 <= v64
		              || (v65 = *(_QWORD *)&frustumOrientation->x,
		                  v98.z = frustumOrientation->z,
		                  v66 = v61->z,
		                  *(_QWORD *)&v98.x = v65,
		                  v67 = *(_QWORD *)&v61->x,
		                  v99.z = v66,
		                  *(_QWORD *)&v99.x = v67,
		                  Dest::Math::Vector3ex::Dot(&v99, &v98, v62) >= 0.0) )
		            {
		              v68 = frustumApex->z;
		              *(_QWORD *)&v101.x = *(_QWORD *)&frustumApex->x;
		              v69 = *(_QWORD *)&sphereCenter->x;
		              v101.z = v68;
		              v70 = sphereCenter->z;
		              *(_QWORD *)&v102.x = v69;
		              v71 = *(_QWORD *)&frustumApex->x;
		              v102.z = v70;
		              v72 = frustumApex->z;
		              *(_QWORD *)&v98.x = v71;
		              v73 = *(_QWORD *)&sphereCenter->x;
		              v98.z = v72;
		              v74 = sphereCenter->z;
		              *(_QWORD *)&v99.x = v73;
		              v99.z = v74;
		              v75 = Unity::Mathematics::float3::op_Subtraction((float3 *)&v104, (float3 *)&v99, (float3 *)&v98, v63);
		              v76 = *(_QWORD *)&v75->x;
		              *(float *)&v75 = v75->z;
		              *(_QWORD *)&v98.x = v76;
		              LODWORD(v98.z) = (_DWORD)v75;
		              v78 = Unity::Mathematics::float3::op_Subtraction((float3 *)&v104, (float3 *)&v102, (float3 *)&v101, v77);
		              v79 = *(_QWORD *)&v78->x;
		              *(float *)&v78 = v78->z;
		              *(_QWORD *)&v99.x = v79;
		              LODWORD(v99.z) = (_DWORD)v78;
		              v81 = Dest::Math::Vector3ex::Dot(&v99, &v98, v80);
		              v16 = v16 * v16;
		              return v16 > v81;
		            }
		            return 1;
		          }
		        }
		      }
		      v44 = (__m128i)w_low;
		      v45 = v36;
		      goto LABEL_24;
		    }
		    v82 = COERCE_FLOAT(_mm_cvtsi128_si32((__m128i)0LL));
		    v83 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		    switch ( v48 )
		    {
		      case 5u:
		        v84 = rightTop;
		        break;
		      case 6u:
		        v84 = leftTop;
		        break;
		      case 7u:
		      case 8u:
		        goto LABEL_38;
		      case 9u:
		        v84 = rightBottom;
		        break;
		      case 0xAu:
		        v84 = leftBottom;
		        break;
		      default:
		LABEL_38:
		        v85 = sphereCenter->z;
		        *(_QWORD *)&v98.x = *(_QWORD *)&sphereCenter->x;
		        v86 = *(_QWORD *)&frustumApex->x;
		        v98.z = v85;
		        v87 = frustumApex->z;
		        *(_QWORD *)&v99.x = v83;
		        v99.z = v82;
		        *(_QWORD *)&v101.x = v86;
		        v101.z = v87;
		        return HG::Rendering::Runtime::GeometryUtils::IntersectRaySphere(
		                 (float3 *)&v101,
		                 (float3 *)&v99,
		                 (float3 *)&v98,
		                 v16,
		                 0,
		                 0LL);
		    }
		    v82 = v84->z;
		    v83 = *(_QWORD *)&v84->x;
		    goto LABEL_38;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(409, 0LL);
		  if ( !Patch )
		    sub_1800D8260(0LL, v88);
		  v91 = *(_QWORD *)&rightTop->x;
		  v98.z = rightTop->z;
		  *(_QWORD *)&v98.x = v91;
		  v92 = *(_QWORD *)&rightBottom->x;
		  v99.z = rightBottom->z;
		  *(_QWORD *)&v99.x = v92;
		  v93 = *(_QWORD *)&leftTop->x;
		  v101.z = leftTop->z;
		  *(_QWORD *)&v101.x = v93;
		  v94 = *(_QWORD *)&leftBottom->x;
		  v102.z = leftBottom->z;
		  *(_QWORD *)&v102.x = v94;
		  v106 = *top;
		  value = *bottom;
		  v108 = *right;
		  v95 = *left;
		  v96 = *(_QWORD *)&frustumOrientation->x;
		  v104.z = frustumOrientation->z;
		  v105.z = frustumApex->z;
		  vector.m128_i32[2] = LODWORD(sphereCenter->z);
		  *(_QWORD *)&v104.x = v96;
		  *(_QWORD *)&v105.x = *(_QWORD *)&frustumApex->x;
		  v97 = *(_QWORD *)&sphereCenter->x;
		  v109 = v95;
		  vector.m128_u64[0] = v97;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_200(
		           Patch,
		           (float3 *)&vector,
		           radius,
		           (float3 *)&v105,
		           (float3 *)&v104,
		           &v109,
		           &v108,
		           &value,
		           &v106,
		           (float3 *)&v102,
		           (float3 *)&v101,
		           (float3 *)&v99,
		           (float3 *)&v98,
		           0LL);
		}
		
		public static bool IntersectSphereParallelPlanes(float3 sphereCenter, float radius, float3 normal, float frontPlaneDistance, float backPlaneDistance) => default; // 0x0000000189C69E90-0x0000000189C69FA8
		// Boolean IntersectSphereParallelPlanes(float3, Single, float3, Single, Single)
		bool HG::Rendering::Runtime::GeometryUtils::IntersectSphereParallelPlanes(
		        float3 *sphereCenter,
		        float radius,
		        float3 *normal,
		        float frontPlaneDistance,
		        float backPlaneDistance,
		        MethodInfo *method)
		{
		  MethodInfo *v8; // r8
		  float v9; // eax
		  __int64 v10; // xmm0_8
		  float v11; // eax
		  float v12; // xmm0_4
		  __int64 v14; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 value; // [rsp+40h] [rbp-40h] BYREF
		  Vector3 vector; // [rsp+50h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(411, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(411, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v14);
		    z = normal->z;
		    *(_QWORD *)&vector.x = *(_QWORD *)&normal->x;
		    *(_QWORD *)&value.x = *(_QWORD *)&sphereCenter->x;
		    vector.z = z;
		    value.z = sphereCenter->z;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_201(
		             Patch,
		             (float3 *)&value,
		             radius,
		             (float3 *)&vector,
		             frontPlaneDistance,
		             backPlaneDistance,
		             0LL);
		  }
		  else
		  {
		    v9 = sphereCenter->z;
		    *(_QWORD *)&value.x = *(_QWORD *)&sphereCenter->x;
		    v10 = *(_QWORD *)&normal->x;
		    value.z = v9;
		    v11 = normal->z;
		    *(_QWORD *)&vector.x = v10;
		    vector.z = v11;
		    v12 = Dest::Math::Vector3ex::Dot(&vector, &value, v8);
		    return v12 > frontPlaneDistance && backPlaneDistance > v12
		        || frontPlaneDistance >= v12 && radius >= (float)(frontPlaneDistance - v12)
		        || v12 >= backPlaneDistance && radius >= (float)(v12 - backPlaneDistance);
		  }
		}
		
		public static bool IntersectRaySphere(float3 rayOrigin, float3 rayDirection, float3 sphereCenter, float radius, bool normalize = false /* Metadata: 0x02302EFE */) => default; // 0x0000000189C69CF0-0x0000000189C69E90
		// Boolean IntersectRaySphere(float3, float3, float3, Single, Boolean)
		bool HG::Rendering::Runtime::GeometryUtils::IntersectRaySphere(
		        float3 *rayOrigin,
		        float3 *rayDirection,
		        float3 *sphereCenter,
		        float radius,
		        bool normalize,
		        MethodInfo *method)
		{
		  MethodInfo *v10; // r9
		  float v11; // eax
		  __int64 v12; // rax
		  __int64 v13; // xmm0_8
		  float v14; // eax
		  __int64 v15; // xmm0_8
		  float v16; // eax
		  float3 *v17; // rax
		  __int64 v18; // xmm2_8
		  __int64 v19; // xmm0_8
		  MethodInfo *v20; // r8
		  __int64 *v21; // rax
		  __int64 v22; // xmm3_8
		  MethodInfo *v23; // r8
		  float v24; // xmm0_4
		  float v25; // xmm4_4
		  float v26; // xmm6_4
		  __int64 v28; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int64 v30; // xmm0_8
		  float z; // eax
		  __int64 v32; // xmm0_8
		  Vector3 vector; // [rsp+40h] [rbp-40h] BYREF
		  Vector3 value; // [rsp+50h] [rbp-30h] BYREF
		  float3 v35; // [rsp+60h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(410, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(410, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v28);
		    v30 = *(_QWORD *)&sphereCenter->x;
		    value.z = sphereCenter->z;
		    vector.z = rayDirection->z;
		    z = rayOrigin->z;
		    *(_QWORD *)&value.x = v30;
		    v32 = *(_QWORD *)&rayDirection->x;
		    v35.z = z;
		    *(_QWORD *)&vector.x = v32;
		    *(_QWORD *)&v35.x = *(_QWORD *)&rayOrigin->x;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_199(
		             Patch,
		             &v35,
		             (float3 *)&vector,
		             (float3 *)&value,
		             radius,
		             normalize,
		             0LL);
		  }
		  else
		  {
		    if ( normalize )
		    {
		      v11 = rayDirection->z;
		      *(_QWORD *)&vector.x = *(_QWORD *)&rayDirection->x;
		      vector.z = v11;
		      v12 = sub_1834C8E00(&v35, &vector);
		      v13 = *(_QWORD *)v12;
		      LODWORD(v12) = *(_DWORD *)(v12 + 8);
		      *(_QWORD *)&rayDirection->x = v13;
		      LODWORD(rayDirection->z) = v12;
		    }
		    v14 = rayOrigin->z;
		    *(_QWORD *)&vector.x = *(_QWORD *)&rayOrigin->x;
		    v15 = *(_QWORD *)&sphereCenter->x;
		    vector.z = v14;
		    v16 = sphereCenter->z;
		    *(_QWORD *)&value.x = v15;
		    value.z = v16;
		    v17 = Unity::Mathematics::float3::op_Subtraction(&v35, (float3 *)&value, (float3 *)&vector, v10);
		    v18 = *(_QWORD *)&rayDirection->x;
		    value.z = rayDirection->z;
		    v19 = *(_QWORD *)&v17->x;
		    vector.z = v17->z;
		    *(_QWORD *)&value.x = v18;
		    *(_QWORD *)&vector.x = v19;
		    Dest::Math::Vector3ex::Dot(&vector, &value, v20);
		    v22 = *v21;
		    LODWORD(v21) = *((_DWORD *)v21 + 2);
		    *(_QWORD *)&value.x = v22;
		    LODWORD(value.z) = (_DWORD)v21;
		    *(_QWORD *)&vector.x = v22;
		    LODWORD(vector.z) = (_DWORD)v21;
		    v24 = Dest::Math::Vector3ex::Dot(&vector, &value, v23);
		    v26 = radius * radius;
		    return (v25 >= 0.0 || v24 <= v26) && (float)(v24 - (float)(v25 * v25)) <= v26;
		  }
		}
		
	}
}
