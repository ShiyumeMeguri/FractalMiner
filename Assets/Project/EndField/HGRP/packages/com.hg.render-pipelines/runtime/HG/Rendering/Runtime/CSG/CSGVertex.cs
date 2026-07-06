using System;
using UnityEngine;

namespace HG.Rendering.Runtime.CSG
{
	[Serializable]
	public class CSGVertex
	{
		public CSGVertex(Vector3 position, Vector3 normal, Vector2 UV1, int id)
		{
			// // CSGVertex(Vector3, Vector3, Vector2, Int32)
			// void HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(
			//         CSGVertex *this,
			//         Vector3 *position,
			//         Vector3 *normal,
			//         Vector2 UV1,
			//         int32_t id,
			//         MethodInfo *method)
			// {
			//   float z; // eax
			//   __int64 v8; // xmm0_8
			//   float v9; // eax
			//   __int64 v11; // rax
			//   float v12; // ecx
			//   __int64 v13; // [rsp+20h] [rbp-38h] BYREF
			//   float v14; // [rsp+28h] [rbp-30h]
			//   _BYTE v15[16]; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   z = position.z;
			//   *(_QWORD *)&this.fields.Position.x = *(_QWORD *)&position.x;
			//   v8 = *(_QWORD *)&normal.x;
			//   this.fields.Position.z = z;
			//   v9 = normal.z;
			//   v13 = v8;
			//   v14 = v9;
			//   v11 = sub_182413460(v15, &v13);
			//   v12 = *(float *)(v11 + 8);
			//   *(_QWORD *)&this.fields.Normal.x = *(_QWORD *)v11;
			//   this.fields.UV = UV1;
			//   this.fields.Normal.z = v12;
			//   this.fields.id = id;
			// }
			// 
		}

		public CSGVertex Flip()
		{
			// // CSGVertex Flip()
			// CSGVertex *HG::Rendering::Runtime::CSG::CSGVertex::Flip(CSGVertex *this, MethodInfo *method)
			// {
			//   MethodInfo *v3; // r8
			//   float z; // eax
			//   __int64 v5; // xmm6_8
			//   float v6; // edi
			//   Vector3 *v7; // rax
			//   __m128 x_low; // xmm8
			//   __m128 y_low; // xmm9
			//   __int64 v10; // xmm7_8
			//   float v11; // esi
			//   int32_t id; // ebp
			//   CSGVertex *v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   CSGVertex *v16; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v19; // [rsp+30h] [rbp-68h] BYREF
			//   Vector3 v20[4]; // [rsp+40h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D919D13 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//     byte_18D919D13 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4595, 0LL) )
			//   {
			//     z = this.fields.Normal.z;
			//     v5 = *(_QWORD *)&this.fields.Position.x;
			//     v6 = this.fields.Position.z;
			//     *(_QWORD *)&v19.x = *(_QWORD *)&this.fields.Normal.x;
			//     v19.z = z;
			//     v7 = UnityEngine::Vector3::op_UnaryNegation(v20, &v19, v3);
			//     x_low = (__m128)LODWORD(this.fields.UV.x);
			//     y_low = (__m128)LODWORD(this.fields.UV.y);
			//     v10 = *(_QWORD *)&v7.x;
			//     v11 = v7.z;
			//     id = this.fields.id;
			//     v13 = (CSGVertex *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//     v16 = v13;
			//     if ( v13 )
			//     {
			//       *(_QWORD *)&v19.x = v10;
			//       v19.z = v11;
			//       *(_QWORD *)&v20[0].x = v5;
			//       v20[0].z = v6;
			//       HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(
			//         v13,
			//         v20,
			//         &v19,
			//         (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
			//         id,
			//         0LL);
			//       return v16;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v15, v14);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4595, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1315(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public CSGVertex Interpolate(CSGVertex other, float t)
		{
			// // CSGVertex Interpolate(CSGVertex, Single)
			// CSGVertex *HG::Rendering::Runtime::CSG::CSGVertex::Interpolate(
			//         CSGVertex *this,
			//         CSGVertex *other,
			//         float t,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   __int64 v9; // xmm0_8
			//   float v10; // eax
			//   __int64 v11; // rax
			//   __int64 v12; // xmm0_8
			//   __int64 v13; // xmm9_8
			//   float v14; // esi
			//   __int64 v15; // rax
			//   __int64 v16; // xmm10_8
			//   float v17; // r14d
			//   Beyond::JobMathf *v18; // rcx
			//   __m128 x_low; // xmm7
			//   __m128 y_low; // xmm8
			//   int32_t id; // edi
			//   CSGVertex *v22; // rax
			//   CSGVertex *v23; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v26; // [rsp+38h] [rbp-29h] BYREF
			//   Vector3 v27; // [rsp+48h] [rbp-19h] BYREF
			//   _BYTE v28[96]; // [rsp+58h] [rbp-9h] BYREF
			// 
			//   if ( !byte_18D919D14 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//     byte_18D919D14 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4590, 0LL) )
			//   {
			//     if ( other )
			//     {
			//       z = other.fields.Position.z;
			//       *(_QWORD *)&v26.x = *(_QWORD *)&other.fields.Position.x;
			//       v9 = *(_QWORD *)&this.fields.Position.x;
			//       v26.z = z;
			//       v10 = this.fields.Position.z;
			//       *(_QWORD *)&v27.x = v9;
			//       v27.z = v10;
			//       v11 = sub_18238EF30(v28, &v27, &v26);
			//       *(_QWORD *)&v27.x = *(_QWORD *)&other.fields.Normal.x;
			//       v12 = *(_QWORD *)&this.fields.Normal.x;
			//       v13 = *(_QWORD *)v11;
			//       v14 = *(float *)(v11 + 8);
			//       v27.z = other.fields.Normal.z;
			//       v26.z = this.fields.Normal.z;
			//       *(_QWORD *)&v26.x = v12;
			//       v15 = sub_18238EF30(v28, &v26, &v27);
			//       x_low = (__m128)LODWORD(other.fields.UV.x);
			//       y_low = (__m128)LODWORD(other.fields.UV.y);
			//       v16 = *(_QWORD *)v15;
			//       v17 = *(float *)(v15 + 8);
			//       Beyond::JobMathf::Clamp01(v18);
			//       x_low.m128_f32[0] = (float)((float)(x_low.m128_f32[0] - this.fields.UV.x) * t) + this.fields.UV.x;
			//       y_low.m128_f32[0] = (float)((float)(y_low.m128_f32[0] - this.fields.UV.y) * t) + this.fields.UV.y;
			//       id = this.fields.id;
			//       v22 = (CSGVertex *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//       v23 = v22;
			//       if ( v22 )
			//       {
			//         *(_QWORD *)&v27.x = v16;
			//         v27.z = v17;
			//         *(_QWORD *)&v26.x = v13;
			//         v26.z = v14;
			//         HG::Rendering::Runtime::CSG::CSGVertex::CSGVertex(
			//           v22,
			//           &v26,
			//           &v27,
			//           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, y_low),
			//           id,
			//           0LL);
			//         return v23;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4590, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1314(Patch, (Object *)this, (Object *)other, t, 0LL);
			// }
			// 
			return null;
		}

		public override string ToString()
		{
			// // String ToString()
			// String *HG::Rendering::Runtime::CSG::CSGVertex::ToString(CSGVertex *this, MethodInfo *method)
			// {
			//   float z; // eax
			//   String *v4; // rax
			//   __int64 v5; // xmm0_8
			//   String *v6; // rbx
			//   String *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Vector3 v12; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919D15 )
			//   {
			//     sub_18003C530(&off_18D5DFA40);
			//     byte_18D919D15 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4739, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4739, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     z = this.fields.Position.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&this.fields.Position.x;
			//     v12.z = z;
			//     v4 = UnityEngine::Vector3::ToString(&v12, 0LL);
			//     v5 = *(_QWORD *)&this.fields.Normal.x;
			//     v6 = v4;
			//     v12.z = this.fields.Normal.z;
			//     *(_QWORD *)&v12.x = v5;
			//     v7 = UnityEngine::Vector3::ToString(&v12, 0LL);
			//     return System::String::Concat(v6, (String *)", N=", v7, 0LL);
			//   }
			// }
			// 
			return null;
		}

		public string <>iFixBaseProxy_ToString()
		{
			// // String ObjectToString()
			// String *IFix::Core::AnonymousStorey::ObjectToString(AnonymousStorey *this, MethodInfo *method)
			// {
			//   return System::Object::ToString((Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public Vector3 Position;

		public Vector3 Normal;

		public Vector2 UV;

		public int id;
	}
}
