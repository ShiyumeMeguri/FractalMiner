using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.CSG
{
	[Serializable]
	public class CSGPlane // TypeDefIndex: 38802
	{
		// Fields
		public Vector3 normal; // 0x10
		public float w; // 0x1C
		public static float EPSILON; // 0x00
	
		// Constructors
		public CSGPlane() {} // Dummy constructor
		public CSGPlane(Vector3 normal, float w) {} // 0x0000000184DA1FA0-0x0000000184DA1FC0
		// CSGPlane(Vector3, Single)
		void HG::Rendering::Runtime::CSG::CSGPlane::CSGPlane(CSGPlane *this, Vector3 *normal, float w, MethodInfo *method)
		{
		  float z; // eax
		
		  z = normal->z;
		  *(_QWORD *)&this->fields.normal.x = *(_QWORD *)&normal->x;
		  this->fields.normal.z = z;
		  this->fields.w = w;
		}
		
		static CSGPlane() {} // 0x0000000184DA1F80-0x0000000184DA1FA0
		// CSGPlane()
		void HG::Rendering::Runtime::CSG::CSGPlane::cctor(MethodInfo *method)
		{
		  LODWORD(TypeInfo::HG::Rendering::Runtime::CSG::CSGPlane->static_fields->EPSILON) = (CSGPlane__StaticFields)925353388;
		}
		
	
		// Methods
		public static CSGPlane fromPoints(Vector3 a, Vector3 b, Vector3 c) => default; // 0x0000000189C75258-0x0000000189C75428
		// CSGPlane fromPoints(Vector3, Vector3, Vector3)
		CSGPlane *HG::Rendering::Runtime::CSG::CSGPlane::fromPoints(Vector3 *a, Vector3 *b, Vector3 *c, MethodInfo *method)
		{
		  MethodInfo *v7; // r9
		  float z; // eax
		  __int64 v9; // xmm0_8
		  float v10; // eax
		  __int64 v11; // xmm0_8
		  float v12; // eax
		  __int64 v13; // xmm0_8
		  float v14; // eax
		  Vector3 *v15; // rax
		  __int64 v16; // xmm3_8
		  MethodInfo *v17; // r9
		  Vector3 *v18; // rax
		  __int64 v19; // xmm3_8
		  MethodInfo *v20; // r9
		  Vector3 *v21; // rax
		  float v22; // ebx
		  __m128 y_low; // xmm1
		  __m128 x_low; // xmm6
		  __m128i v25; // xmm2
		  float v26; // eax
		  float v27; // ebx
		  unsigned __int64 v28; // xmm6_8
		  MethodInfo *v29; // r8
		  float v30; // xmm7_4
		  CSGPlane *result; // rax
		  __int64 v32; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float v34; // eax
		  __int64 v35; // xmm0_8
		  float v36; // eax
		  __int64 v37; // xmm0_8
		  float v38; // eax
		  Vector3 v39; // [rsp+38h] [rbp-19h] BYREF
		  Vector3 v40; // [rsp+48h] [rbp-9h] BYREF
		  Vector3 v41; // [rsp+58h] [rbp+7h] BYREF
		  Vector3 v42; // [rsp+68h] [rbp+17h] BYREF
		  Vector3 v43[4]; // [rsp+78h] [rbp+27h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5435, 0LL) )
		  {
		    z = a->z;
		    *(_QWORD *)&v41.x = *(_QWORD *)&a->x;
		    v9 = *(_QWORD *)&b->x;
		    v41.z = z;
		    v10 = b->z;
		    *(_QWORD *)&v42.x = v9;
		    v11 = *(_QWORD *)&a->x;
		    v42.z = v10;
		    v12 = a->z;
		    *(_QWORD *)&v39.x = v11;
		    v13 = *(_QWORD *)&c->x;
		    v39.z = v12;
		    v14 = c->z;
		    *(_QWORD *)&v40.x = v13;
		    v40.z = v14;
		    v15 = UnityEngine::Vector3::op_Subtraction(v43, &v40, &v39, v7);
		    v16 = *(_QWORD *)&v15->x;
		    *(float *)&v15 = v15->z;
		    *(_QWORD *)&v40.x = v16;
		    LODWORD(v40.z) = (_DWORD)v15;
		    v18 = UnityEngine::Vector3::op_Subtraction(v43, &v42, &v41, v17);
		    v19 = *(_QWORD *)&v18->x;
		    *(float *)&v18 = v18->z;
		    *(_QWORD *)&v42.x = v19;
		    LODWORD(v42.z) = (_DWORD)v18;
		    v21 = UnityEngine::Vector3::Cross(v43, &v42, &v40, v20);
		    v22 = v21->z;
		    *(_QWORD *)&v39.x = *(_QWORD *)&v21->x;
		    v39.z = v22;
		    *(float *)&v13 = sub_182F9FF00(&v39);
		    y_low = (__m128)LODWORD(v39.y);
		    x_low = (__m128)LODWORD(v39.x);
		    v25 = _mm_cvtsi32_si128(LODWORD(v22));
		    y_low.m128_f32[0] = v39.y / *(float *)&v13;
		    *(float *)v25.m128i_i32 = *(float *)v25.m128i_i32 / *(float *)&v13;
		    x_low.m128_f32[0] = v39.x / *(float *)&v13;
		    v26 = a->z;
		    v27 = COERCE_FLOAT(_mm_cvtsi128_si32(v25));
		    v28 = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
		    *(_QWORD *)&v42.x = *(_QWORD *)&a->x;
		    v41.z = v27;
		    v42.z = v26;
		    *(_QWORD *)&v41.x = v28;
		    v30 = UnityEngine::Vector3::Dot(&v41, &v42, v29);
		    result = (CSGPlane *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::CSG::CSGPlane);
		    if ( result )
		    {
		      *(_QWORD *)&result->fields.normal.x = v28;
		      result->fields.normal.z = v27;
		      result->fields.w = v30;
		      return result;
		    }
		LABEL_5:
		    sub_1800D8260(Patch, v32);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5435, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v34 = c->z;
		  *(_QWORD *)&v42.x = *(_QWORD *)&c->x;
		  v35 = *(_QWORD *)&b->x;
		  v42.z = v34;
		  v36 = b->z;
		  *(_QWORD *)&v41.x = v35;
		  v37 = *(_QWORD *)&a->x;
		  v41.z = v36;
		  v38 = a->z;
		  *(_QWORD *)&v40.x = v37;
		  v40.z = v38;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1572(Patch, &v40, &v41, &v42, 0LL);
		}
		
		public CSGPlane clone() => default; // 0x0000000189C75164-0x0000000189C751C4
		// CSGPlane clone()
		CSGPlane *HG::Rendering::Runtime::CSG::CSGPlane::clone(CSGPlane *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5436, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5436, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1573(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = System::CharEnumerator::Clone((System::CharEnumerator *)this);
		    return (CSGPlane *)sub_180005130(v3, TypeInfo::HG::Rendering::Runtime::CSG::CSGPlane);
		  }
		}
		
		public void flip() {} // 0x0000000189C751C4-0x0000000189C75258
		// Void flip()
		void HG::Rendering::Runtime::CSG::CSGPlane::flip(CSGPlane *this, MethodInfo *method)
		{
		  MethodInfo *v3; // r9
		  float z; // eax
		  Vector3 *v5; // rax
		  float v6; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v11[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5437, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5437, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    z = this->fields.normal.z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&this->fields.normal.x;
		    v10.z = z;
		    v5 = UnityEngine::Vector3::op_Multiply(v11, -1.0, &v10, v3);
		    v6 = v5->z;
		    *(_QWORD *)&this->fields.normal.x = *(_QWORD *)&v5->x;
		    this->fields.w = -this->fields.w;
		    this->fields.normal.z = v6;
		  }
		}
		
	}
}
