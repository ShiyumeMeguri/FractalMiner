using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.HgMath
{
	public struct Barycentric // TypeDefIndex: 37477
	{
		// Fields
		public static float TOLERANCE; // 0x00
		public float u; // 0x00
		public float v; // 0x04
		public float w; // 0x08
	
		// Properties
		public bool IsInside { get => default; } // 0x0000000189B347C4-0x0000000189B348F0 
		// Boolean get_IsInside()
		bool HG::Rendering::HgMath::Barycentric::get_IsInside(Barycentric *this, MethodInfo *method)
		{
		  float u; // xmm6_4
		  float v4; // xmm6_4
		  float v; // xmm6_4
		  float v6; // xmm6_4
		  float w; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(353, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(353, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_165(Patch, this, 0LL);
		  }
		  else
		  {
		    u = this->u;
		    sub_1800036A0(TypeInfo::HG::Rendering::HgMath::Barycentric);
		    if ( u < (float)(0.0 - TypeInfo::HG::Rendering::HgMath::Barycentric->static_fields->TOLERANCE) )
		      return 0;
		    v4 = this->u;
		    sub_1800036A0(TypeInfo::HG::Rendering::HgMath::Barycentric);
		    if ( (float)(TypeInfo::HG::Rendering::HgMath::Barycentric->static_fields->TOLERANCE + 1.0) < v4 )
		      return 0;
		    v = this->v;
		    sub_1800036A0(TypeInfo::HG::Rendering::HgMath::Barycentric);
		    if ( v < (float)(0.0 - TypeInfo::HG::Rendering::HgMath::Barycentric->static_fields->TOLERANCE) )
		      return 0;
		    v6 = this->v;
		    sub_1800036A0(TypeInfo::HG::Rendering::HgMath::Barycentric);
		    if ( (float)(TypeInfo::HG::Rendering::HgMath::Barycentric->static_fields->TOLERANCE + 1.0) < v6 )
		    {
		      return 0;
		    }
		    else
		    {
		      w = this->w;
		      sub_1800036A0(TypeInfo::HG::Rendering::HgMath::Barycentric);
		      return w >= (float)(0.0 - TypeInfo::HG::Rendering::HgMath::Barycentric->static_fields->TOLERANCE);
		    }
		  }
		}
		
	
		// Constructors
		public Barycentric(float aU, float aV, float aW) : this() {
			u = default;
			v = default;
			w = default;
		} // 0x0000000184D88F30-0x0000000184D88F40
		// CriAtomEx+NativeVector(Single, Single, Single)
		void CriWare::CriAtomEx::NativeVector::NativeVector(
		        CriAtomEx_NativeVector *this,
		        float x,
		        float y,
		        float z,
		        MethodInfo *method)
		{
		  this->x = x;
		  this->y = y;
		  this->z = z;
		}
		
		public Barycentric(Vector2 aV1, Vector2 aV2, Vector2 aV3, Vector2 aP) : this() {
			u = default;
			v = default;
			w = default;
		} // 0x0000000189B343F0-0x0000000189B34564
		// Barycentric(Vector2, Vector2, Vector2, Vector2)
		void HG::Rendering::HgMath::Barycentric::Barycentric(
		        Barycentric *this,
		        Vector2 aV1,
		        Vector2 aV2,
		        Vector2 aV3,
		        Vector2 aP,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rdx
		  float v9; // xmm9_4
		  float v10; // xmm10_4
		  float v11; // xmm7_4
		  float v12; // xmm6_4
		  float v13; // xmm1_4
		  float *v14; // r10
		  float v15; // xmm8_4
		  __int64 v16; // [rsp+20h] [rbp-68h]
		  __int64 v17; // [rsp+90h] [rbp+8h]
		  Vector2 aPa; // [rsp+B0h] [rbp+28h]
		
		  v17 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(aV2, aV3);
		  v16 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(aV1, v7);
		  aPa = (Vector2)((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(aP, v8);
		  v9 = (float)(*((float *)&v17 + 1) * *((float *)&v17 + 1)) + (float)(*(float *)&v17 * *(float *)&v17);
		  v10 = (float)(*((float *)&v16 + 1) * *((float *)&v16 + 1)) + (float)(*(float *)&v16 * *(float *)&v16);
		  v11 = (float)(*((float *)&v16 + 1) * *((float *)&v17 + 1)) + (float)(*(float *)&v16 * *(float *)&v17);
		  v12 = (float)(aPa.y * *((float *)&v16 + 1)) + (float)(aPa.x * *(float *)&v16);
		  aV1.x = (float)(v10 * v9) - (float)(v11 * v11);
		  v13 = (float)((float)(v12 * v9)
		              - (float)((float)((float)(aPa.y * *((float *)&v17 + 1)) + (float)(aPa.x * *(float *)&v17)) * v11))
		      / aV1.x;
		  *v14 = v13;
		  v15 = (float)((float)((float)((float)(aPa.y * *((float *)&v17 + 1)) + (float)(aPa.x * *(float *)&v17)) * v10)
		              - (float)(v12 * v11))
		      / aV1.x;
		  v14[1] = v15;
		  v14[2] = (float)(1.0 - v13) - v15;
		}
		
		public Barycentric(Vector3 aV1, Vector3 aV2, Vector3 aV3, Vector3 aP) : this() {
			u = default;
			v = default;
			w = default;
		} // 0x0000000189B34564-0x0000000189B347C4
		// Barycentric(Vector3, Vector3, Vector3, Vector3)
		void HG::Rendering::HgMath::Barycentric::Barycentric(
		        Barycentric *this,
		        Vector3 *aV1,
		        Vector3 *aV2,
		        Vector3 *aV3,
		        Vector3 *aP,
		        MethodInfo *method)
		{
		  __int64 v6; // xmm0_8
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // r9
		  float *v11; // r10
		  __int64 v12; // xmm0_8
		  __int64 v13; // xmm3_8
		  float v14; // ebx
		  Vector3 *v15; // rax
		  __int64 v16; // r11
		  __int64 v17; // xmm3_8
		  MethodInfo *z_low; // r9
		  Vector3 *v19; // rax
		  float v20; // xmm13_4
		  float v21; // r9d
		  float v22; // xmm12_4
		  float v23; // xmm11_4
		  float v24; // xmm10_4
		  float v25; // xmm9_4
		  float v26; // xmm1_4
		  float v27; // xmm10_4
		  Vector3 v28; // [rsp+28h] [rbp-69h] BYREF
		  Vector3 v29; // [rsp+38h] [rbp-59h] BYREF
		  Vector3 v30; // [rsp+48h] [rbp-49h] BYREF
		  Vector3 v31; // [rsp+58h] [rbp-39h] BYREF
		  Vector3 v32[9]; // [rsp+68h] [rbp-29h] BYREF
		
		  v6 = *(_QWORD *)&aV3->x;
		  v29.z = aV3->z;
		  z = aV2->z;
		  *(_QWORD *)&v29.x = v6;
		  *(_QWORD *)&v28.x = *(_QWORD *)&aV2->x;
		  v28.z = z;
		  v9 = UnityEngine::Vector3::op_Subtraction(&v31, &v28, &v29, (MethodInfo *)aV3);
		  *(_QWORD *)&v29.x = *(_QWORD *)v10;
		  v12 = *(_QWORD *)v11;
		  v13 = *(_QWORD *)&v9->x;
		  v14 = v9->z;
		  v29.z = *(float *)(v10 + 8);
		  v30.z = v11[2];
		  *(_QWORD *)&v28.x = v13;
		  *(_QWORD *)&v30.x = v12;
		  v15 = UnityEngine::Vector3::op_Subtraction(&v31, &v30, &v29, (MethodInfo *)v10);
		  *(_QWORD *)&v30.x = *(_QWORD *)v16;
		  v17 = *(_QWORD *)&v15->x;
		  z_low = (MethodInfo *)LODWORD(v15->z);
		  v30.z = *(float *)(v16 + 8);
		  *(_QWORD *)&v29.x = v17;
		  *(float *)&v15 = aP->z;
		  *(_QWORD *)&v31.x = *(_QWORD *)&aP->x;
		  LODWORD(v31.z) = (_DWORD)v15;
		  v19 = UnityEngine::Vector3::op_Subtraction(v32, &v31, &v30, z_low);
		  *(_QWORD *)&v31.x = *(_QWORD *)&v19->x;
		  v20 = (float)((float)(v28.y * v28.y) + (float)(v28.x * v28.x)) + (float)(v14 * v14);
		  v22 = (float)((float)(v29.y * v29.y) + (float)(v29.x * v29.x)) + (float)(v21 * v21);
		  v23 = (float)((float)(v29.y * v28.y) + (float)(v29.x * v28.x)) + (float)(v21 * v14);
		  v24 = (float)((float)(v31.y * v28.y) + (float)(v31.x * v28.x)) + (float)(v19->z * v14);
		  v25 = (float)((float)(v31.y * v29.y) + (float)(v31.x * v29.x)) + (float)(v19->z * v21);
		  *(float *)&v17 = (float)(v22 * v20) - (float)(v23 * v23);
		  v26 = (float)((float)(v25 * v20) - (float)(v24 * v23)) / *(float *)&v17;
		  this->u = v26;
		  v27 = (float)((float)(v24 * v22) - (float)(v25 * v23)) / *(float *)&v17;
		  this->v = v27;
		  this->w = (float)(1.0 - v26) - v27;
		}
		
		static Barycentric() {
			TOLERANCE = default;
		} // 0x0000000184DA11A0-0x0000000184DA11C0
		// Barycentric()
		void HG::Rendering::HgMath::Barycentric::cctor(MethodInfo *method)
		{
		  LODWORD(TypeInfo::HG::Rendering::HgMath::Barycentric->static_fields->TOLERANCE) = (Barycentric__StaticFields)961656599;
		}
		
	
		// Methods
		public static bool IsInTriangle(Vector3 T, Vector3 A, Vector3 B, Vector3 C) => default; // 0x0000000189B340C0-0x0000000189B343F0
		// Boolean IsInTriangle(Vector3, Vector3, Vector3, Vector3)
		bool HG::Rendering::HgMath::Barycentric::IsInTriangle(
		        Vector3 *T,
		        Vector3 *A,
		        Vector3 *B,
		        Vector3 *C,
		        MethodInfo *method)
		{
		  MethodInfo *v9; // r9
		  float v10; // eax
		  __int64 v11; // xmm0_8
		  float v12; // eax
		  Vector3 *v13; // rax
		  __int64 v14; // xmm0_8
		  __int64 v15; // xmm3_8
		  MethodInfo *v16; // r9
		  Vector3 *v17; // rax
		  __int64 v18; // xmm0_8
		  __int64 v19; // xmm3_8
		  MethodInfo *z_low; // r9
		  Vector3 *v21; // rax
		  float v22; // xmm5_4
		  float v23; // r10d
		  float v24; // r9d
		  float v25; // xmm7_4
		  float v26; // xmm6_4
		  float v27; // xmm8_4
		  float v28; // xmm5_4
		  float v29; // xmm9_4
		  float v30; // xmm1_4
		  float v31; // xmm9_4
		  float v32; // xmm8_4
		  __int64 v34; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int64 v36; // xmm0_8
		  float z; // eax
		  __int64 v38; // xmm0_8
		  float v39; // eax
		  __int64 v40; // xmm0_8
		  float v41; // eax
		  __int64 v42; // xmm0_8
		  Vector3 v43; // [rsp+38h] [rbp-51h] BYREF
		  Vector3 v44; // [rsp+48h] [rbp-41h] BYREF
		  Vector3 v45; // [rsp+58h] [rbp-31h] BYREF
		  Vector3 v46; // [rsp+68h] [rbp-21h] BYREF
		  Vector3 v47[8]; // [rsp+78h] [rbp-11h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(352, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(352, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v34);
		    v36 = *(_QWORD *)&C->x;
		    v44.z = C->z;
		    z = B->z;
		    *(_QWORD *)&v44.x = v36;
		    v38 = *(_QWORD *)&B->x;
		    v43.z = z;
		    v39 = A->z;
		    *(_QWORD *)&v43.x = v38;
		    v40 = *(_QWORD *)&A->x;
		    v45.z = v39;
		    v41 = T->z;
		    *(_QWORD *)&v45.x = v40;
		    v42 = *(_QWORD *)&T->x;
		    v46.z = v41;
		    *(_QWORD *)&v46.x = v42;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_164(Patch, &v46, &v45, &v43, &v44, 0LL);
		  }
		  else
		  {
		    v10 = C->z;
		    *(_QWORD *)&v43.x = *(_QWORD *)&C->x;
		    v11 = *(_QWORD *)&B->x;
		    v43.z = v10;
		    v12 = B->z;
		    *(_QWORD *)&v44.x = v11;
		    v44.z = v12;
		    v13 = UnityEngine::Vector3::op_Subtraction(&v46, &v44, &v43, v9);
		    *(_QWORD *)&v44.x = *(_QWORD *)&C->x;
		    v14 = *(_QWORD *)&A->x;
		    v15 = *(_QWORD *)&v13->x;
		    v44.z = C->z;
		    v43.z = A->z;
		    *(_QWORD *)&v45.x = v15;
		    *(_QWORD *)&v43.x = v14;
		    v17 = UnityEngine::Vector3::op_Subtraction(v47, &v43, &v44, v16);
		    *(_QWORD *)&v44.x = *(_QWORD *)&C->x;
		    v18 = *(_QWORD *)&T->x;
		    v19 = *(_QWORD *)&v17->x;
		    z_low = (MethodInfo *)LODWORD(v17->z);
		    v44.z = C->z;
		    v43.z = T->z;
		    *(_QWORD *)&v46.x = v19;
		    *(_QWORD *)&v43.x = v18;
		    v21 = UnityEngine::Vector3::op_Subtraction(v47, &v43, &v44, z_low);
		    v22 = v21->z;
		    *(_QWORD *)&v44.x = *(_QWORD *)&v21->x;
		    v25 = (float)(v24 * v24) + (float)(v46.x * v46.x);
		    v26 = (float)(v24 * v23) + (float)(v46.x * v45.x);
		    v27 = (float)(v22 * v23) + (float)(v44.x * v45.x);
		    v28 = (float)(v22 * v24) + (float)(v44.x * v46.x);
		    v29 = (float)(v23 * v23) + (float)(v45.x * v45.x);
		    v30 = (float)(v29 * v25) - (float)(v26 * v26);
		    v31 = (float)((float)(v29 * v28) - (float)(v27 * v26)) / v30;
		    v32 = (float)((float)(v27 * v25) - (float)(v28 * v26)) / v30;
		    sub_1800036A0(TypeInfo::HG::Rendering::HgMath::Barycentric);
		    if ( v31 < (float)(0.0 - TypeInfo::HG::Rendering::HgMath::Barycentric->static_fields->TOLERANCE) )
		      return 0;
		    sub_1800036A0(TypeInfo::HG::Rendering::HgMath::Barycentric);
		    if ( (float)(TypeInfo::HG::Rendering::HgMath::Barycentric->static_fields->TOLERANCE + 1.0) < v31 )
		      return 0;
		    sub_1800036A0(TypeInfo::HG::Rendering::HgMath::Barycentric);
		    if ( v32 < (float)(0.0 - TypeInfo::HG::Rendering::HgMath::Barycentric->static_fields->TOLERANCE) )
		      return 0;
		    sub_1800036A0(TypeInfo::HG::Rendering::HgMath::Barycentric);
		    if ( (float)(TypeInfo::HG::Rendering::HgMath::Barycentric->static_fields->TOLERANCE + 1.0) < v32 )
		    {
		      return 0;
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::HgMath::Barycentric);
		      return (float)((float)(1.0 - v31) - v32) >= (float)(0.0
		                                                        - TypeInfo::HG::Rendering::HgMath::Barycentric->static_fields->TOLERANCE);
		    }
		  }
		}
		
	}
}
