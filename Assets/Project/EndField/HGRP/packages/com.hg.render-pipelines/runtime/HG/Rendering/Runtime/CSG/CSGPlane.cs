using System;
using UnityEngine;

namespace HG.Rendering.Runtime.CSG
{
	[Serializable]
	public class CSGPlane
	{
		public CSGPlane(Vector3 normal, float w)
		{
			// // CSGPlane(Vector3, Single)
			// void HG::Rendering::Runtime::CSG::CSGPlane::CSGPlane(CSGPlane *this, Vector3 *normal, float w, MethodInfo *method)
			// {
			//   float z; // eax
			// 
			//   z = normal.z;
			//   *(_QWORD *)&this.fields.normal.x = *(_QWORD *)&normal.x;
			//   this.fields.normal.z = z;
			//   this.fields.w = w;
			// }
			// 
		}

		public static CSGPlane fromPoints(Vector3 a, Vector3 b, Vector3 c)
		{
			// // CSGPlane fromPoints(Vector3, Vector3, Vector3)
			// CSGPlane *HG::Rendering::Runtime::CSG::CSGPlane::fromPoints(Vector3 *a, Vector3 *b, Vector3 *c, MethodInfo *method)
			// {
			//   MethodInfo *v7; // r9
			//   float z; // eax
			//   __int64 v9; // xmm0_8
			//   float v10; // eax
			//   __int64 v11; // xmm0_8
			//   float v12; // eax
			//   __int64 v13; // xmm0_8
			//   float v14; // eax
			//   Vector3 *v15; // rax
			//   __int64 v16; // xmm3_8
			//   MethodInfo *v17; // r9
			//   Vector3 *v18; // rax
			//   __int64 v19; // xmm3_8
			//   MethodInfo *v20; // r9
			//   Vector3 *v21; // rax
			//   float v22; // ebx
			//   double v23; // xmm0_8
			//   __m128 y_low; // xmm1
			//   __m128 x_low; // xmm6
			//   __m128i v26; // xmm2
			//   float v27; // eax
			//   float v28; // ebx
			//   unsigned __int64 v29; // xmm6_8
			//   MethodInfo *v30; // r8
			//   float v31; // xmm7_4
			//   CSGPlane *result; // rax
			//   __int64 v33; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float v35; // eax
			//   __int64 v36; // xmm0_8
			//   float v37; // eax
			//   __int64 v38; // xmm0_8
			//   float v39; // eax
			//   Vector3 v40; // [rsp+38h] [rbp-19h] BYREF
			//   Vector3 v41; // [rsp+48h] [rbp-9h] BYREF
			//   Vector3 v42; // [rsp+58h] [rbp+7h] BYREF
			//   Vector3 v43; // [rsp+68h] [rbp+17h] BYREF
			//   Vector3 v44[4]; // [rsp+78h] [rbp+27h] BYREF
			// 
			//   if ( !byte_18D919D09 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGPlane);
			//     byte_18D919D09 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4735, 0LL) )
			//   {
			//     z = a.z;
			//     *(_QWORD *)&v42.x = *(_QWORD *)&a.x;
			//     v9 = *(_QWORD *)&b.x;
			//     v42.z = z;
			//     v10 = b.z;
			//     *(_QWORD *)&v43.x = v9;
			//     v11 = *(_QWORD *)&a.x;
			//     v43.z = v10;
			//     v12 = a.z;
			//     *(_QWORD *)&v40.x = v11;
			//     v13 = *(_QWORD *)&c.x;
			//     v40.z = v12;
			//     v14 = c.z;
			//     *(_QWORD *)&v41.x = v13;
			//     v41.z = v14;
			//     v15 = UnityEngine::Vector3::op_Subtraction(v44, &v41, &v40, v7);
			//     v16 = *(_QWORD *)&v15.x;
			//     *(float *)&v15 = v15.z;
			//     *(_QWORD *)&v41.x = v16;
			//     LODWORD(v41.z) = (_DWORD)v15;
			//     v18 = UnityEngine::Vector3::op_Subtraction(v44, &v43, &v42, v17);
			//     v19 = *(_QWORD *)&v18.x;
			//     *(float *)&v18 = v18.z;
			//     *(_QWORD *)&v43.x = v19;
			//     LODWORD(v43.z) = (_DWORD)v18;
			//     v21 = UnityEngine::Vector3::Cross(v44, &v43, &v41, v20);
			//     v22 = v21.z;
			//     *(_QWORD *)&v40.x = *(_QWORD *)&v21.x;
			//     v40.z = v22;
			//     v23 = sub_18238EFA0(&v40);
			//     y_low = (__m128)LODWORD(v40.y);
			//     x_low = (__m128)LODWORD(v40.x);
			//     v26 = _mm_cvtsi32_si128(LODWORD(v22));
			//     y_low.m128_f32[0] = v40.y / *(float *)&v23;
			//     *(float *)v26.m128i_i32 = *(float *)v26.m128i_i32 / *(float *)&v23;
			//     x_low.m128_f32[0] = v40.x / *(float *)&v23;
			//     v27 = a.z;
			//     v28 = COERCE_FLOAT(_mm_cvtsi128_si32(v26));
			//     v29 = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
			//     *(_QWORD *)&v43.x = *(_QWORD *)&a.x;
			//     v42.z = v28;
			//     v43.z = v27;
			//     *(_QWORD *)&v42.x = v29;
			//     v31 = UnityEngine::Vector3::Dot(&v42, &v43, v30);
			//     result = (CSGPlane *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGPlane);
			//     if ( result )
			//     {
			//       *(_QWORD *)&result.fields.normal.x = v29;
			//       result.fields.normal.z = v28;
			//       result.fields.w = v31;
			//       return result;
			//     }
			// LABEL_7:
			//     sub_180B536AC(Patch, v33);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4735, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   v35 = c.z;
			//   *(_QWORD *)&v43.x = *(_QWORD *)&c.x;
			//   v36 = *(_QWORD *)&b.x;
			//   v43.z = v35;
			//   v37 = b.z;
			//   *(_QWORD *)&v42.x = v36;
			//   v38 = *(_QWORD *)&a.x;
			//   v42.z = v37;
			//   v39 = a.z;
			//   *(_QWORD *)&v41.x = v38;
			//   v41.z = v39;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1363(Patch, &v41, &v42, &v43, 0LL);
			// }
			// 
			return null;
		}

		public CSGPlane clone()
		{
			// // CSGPlane clone()
			// CSGPlane *HG::Rendering::Runtime::CSG::CSGPlane::clone(CSGPlane *this, MethodInfo *method)
			// {
			//   __int64 v3; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !byte_18D919D0A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGPlane);
			//     byte_18D919D0A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4736, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4736, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1364(Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     v3 = System::CharEnumerator::Clone((System::CharEnumerator *)this);
			//     return (CSGPlane *)sub_18003F550(v3, TypeInfo::HG::Rendering::Runtime::CSG::CSGPlane);
			//   }
			// }
			// 
			return null;
		}

		public void flip()
		{
			// // Void flip()
			// void HG::Rendering::Runtime::CSG::CSGPlane::flip(CSGPlane *this, MethodInfo *method)
			// {
			//   MethodInfo *v3; // r9
			//   float z; // eax
			//   Vector3 *v5; // rax
			//   float v6; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v11[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4737, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4737, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     z = this.fields.normal.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&this.fields.normal.x;
			//     v10.z = z;
			//     v5 = UnityEngine::Vector3::op_Multiply(v11, -1.0, &v10, v3);
			//     v6 = v5.z;
			//     *(_QWORD *)&this.fields.normal.x = *(_QWORD *)&v5.x;
			//     this.fields.w = -this.fields.w;
			//     this.fields.normal.z = v6;
			//   }
			// }
			// 
		}

		public Vector3 normal;

		public float w;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static float EPSILON;
	}
}
