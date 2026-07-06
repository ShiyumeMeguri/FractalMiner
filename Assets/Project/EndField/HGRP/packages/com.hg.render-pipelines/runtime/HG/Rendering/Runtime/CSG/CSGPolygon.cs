using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime.CSG
{
	[Serializable]
	public class CSGPolygon
	{
		public CSGPolygon(CSGVertex a, CSGVertex b, CSGVertex c, int objID, int materialID)
		{
			// // CSGPolygon(CSGVertex, CSGVertex, CSGVertex, Int32, Int32)
			// void HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
			//         CSGPolygon *this,
			//         CSGVertex *a,
			//         CSGVertex *b,
			//         CSGVertex *c,
			//         int32_t objID,
			//         int32_t materialID,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // xmm1_8
			//   float z; // eax
			//   float v13; // eax
			//   __int64 v14; // r8
			//   __int64 v15; // r9
			//   __int64 v16; // rax
			//   CSGVertex__Array *v17; // r14
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v18; // rdx
			//   Bounds *v19; // r8
			//   Object__Array *v20; // r9
			//   MethodInfo *v21; // [rsp+20h] [rbp-50h]
			//   MethodInfo *v22; // [rsp+28h] [rbp-48h]
			//   Vector3 v23; // [rsp+30h] [rbp-40h] BYREF
			//   Vector3 v24; // [rsp+40h] [rbp-30h] BYREF
			//   Vector3 v25; // [rsp+50h] [rbp-20h] BYREF
			//   Plane v26; // [rsp+60h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919D0C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex);
			//     byte_18D919D0C = 1;
			//   }
			//   if ( !a )
			//     goto LABEL_8;
			//   if ( !b )
			//     goto LABEL_8;
			//   if ( !c )
			//     goto LABEL_8;
			//   v11 = *(_QWORD *)&c.fields.Position.x;
			//   v23.z = c.fields.Position.z;
			//   z = b.fields.Position.z;
			//   v26 = 0LL;
			//   v24.z = z;
			//   v13 = a.fields.Position.z;
			//   *(_QWORD *)&v24.x = *(_QWORD *)&b.fields.Position.x;
			//   *(_QWORD *)&v25.x = *(_QWORD *)&a.fields.Position.x;
			//   *(_QWORD *)&v23.x = v11;
			//   v25.z = v13;
			//   UnityEngine::Plane::Plane(&v26, &v25, &v24, &v23, 0LL);
			//   this.fields.Plane = v26;
			//   v16 = il2cpp_array_new_specific_0(TypeInfo::HG::Rendering::Runtime::CSG::CSGVertex, 3LL, v14, v15);
			//   v17 = (CSGVertex__Array *)v16;
			//   if ( !v16 )
			// LABEL_8:
			//     sub_180B536AC(this, a);
			//   sub_180036D40(v16, a);
			//   sub_180328478(v17, 0LL, a);
			//   sub_180036D40(v17, b);
			//   sub_180328478(v17, 1LL, b);
			//   sub_180036D40(v17, c);
			//   sub_180328478(v17, 2LL, c);
			//   this.fields.Vertices = v17;
			//   sub_1800054D0((BSP *)&this.fields.Vertices, v18, v19, v20, v21, v22);
			//   this.fields.materialID = materialID;
			//   this.fields.objID = objID;
			// }
			// 
		}

		public CSGPolygon(IEnumerable<CSGVertex> vertices, int objID, int materialID)
		{
			// // CSGPolygon(IEnumerable`1[HG.Rendering.Runtime.CSG.CSGVertex], Int32, Int32)
			// void HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
			//         CSGPolygon *this,
			//         IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *vertices,
			//         int32_t objID,
			//         int32_t materialID,
			//         MethodInfo *method)
			// {
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v9; // rdx
			//   Bounds *v10; // r8
			//   Object__Array *v11; // r9
			//   Object *v12; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   Object__Class *klass; // xmm7_8
			//   float v16; // r14d
			//   IEnumerable_1_System_Object_ *v17; // rax
			//   Object *v18; // rax
			//   Object__Class *v19; // xmm6_8
			//   float v20; // esi
			//   IEnumerable_1_System_Object_ *v21; // rax
			//   Object *v22; // rax
			//   Object__Class *v23; // xmm1_8
			//   float v24; // eax
			//   MethodInfo *v25; // [rsp+28h] [rbp-21h]
			//   MethodInfo *v26; // [rsp+30h] [rbp-19h]
			//   Vector3 v27; // [rsp+38h] [rbp-11h] BYREF
			//   Vector3 v28; // [rsp+48h] [rbp-1h] BYREF
			//   Vector3 v29; // [rsp+58h] [rbp+Fh] BYREF
			//   Plane v30; // [rsp+68h] [rbp+1Fh] BYREF
			// 
			//   if ( !byte_18D919D0D )
			//   {
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::First<HG::Rendering::Runtime::CSG::CSGVertex>);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Skip<HG::Rendering::Runtime::CSG::CSGVertex>);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::ToArray<HG::Rendering::Runtime::CSG::CSGVertex>);
			//     byte_18D919D0D = 1;
			//   }
			//   this.fields.Vertices = (CSGVertex__Array *)System::Linq::Enumerable::ToArray<System::Object>(
			//                                                 (IEnumerable_1_System_Object_ *)vertices,
			//                                                 MethodInfo::System::Linq::Enumerable::ToArray<HG::Rendering::Runtime::CSG::CSGVertex>);
			//   sub_1800054D0((BSP *)&this.fields.Vertices, v9, v10, v11, v25, v26);
			//   this.fields.objID = objID;
			//   this.fields.materialID = materialID;
			//   v12 = System::Linq::Enumerable::First<System::Object>(
			//           (IEnumerable_1_System_Object_ *)vertices,
			//           MethodInfo::System::Linq::Enumerable::First<HG::Rendering::Runtime::CSG::CSGVertex>);
			//   if ( !v12 )
			//     goto LABEL_7;
			//   klass = v12[1].klass;
			//   v16 = *(float *)&v12[1].monitor;
			//   v17 = (IEnumerable_1_System_Object_ *)System::Linq::Enumerable::Skip<UnityEngine::Vector3>(
			//                                           (IEnumerable_1_UnityEngine_Vector3_ *)vertices,
			//                                           1,
			//                                           MethodInfo::System::Linq::Enumerable::Skip<HG::Rendering::Runtime::CSG::CSGVertex>);
			//   v18 = System::Linq::Enumerable::First<System::Object>(
			//           v17,
			//           MethodInfo::System::Linq::Enumerable::First<HG::Rendering::Runtime::CSG::CSGVertex>);
			//   if ( !v18
			//     || (v19 = v18[1].klass,
			//         v20 = *(float *)&v18[1].monitor,
			//         v21 = (IEnumerable_1_System_Object_ *)System::Linq::Enumerable::Skip<UnityEngine::Vector3>(
			//                                                 (IEnumerable_1_UnityEngine_Vector3_ *)vertices,
			//                                                 2,
			//                                                 MethodInfo::System::Linq::Enumerable::Skip<HG::Rendering::Runtime::CSG::CSGVertex>),
			//         (v22 = System::Linq::Enumerable::First<System::Object>(
			//                  v21,
			//                  MethodInfo::System::Linq::Enumerable::First<HG::Rendering::Runtime::CSG::CSGVertex>)) == 0LL) )
			//   {
			// LABEL_7:
			//     sub_180B536AC(v14, v13);
			//   }
			//   v23 = v22[1].klass;
			//   v24 = *(float *)&v22[1].monitor;
			//   *(_QWORD *)&v27.x = v23;
			//   v27.z = v24;
			//   v30 = 0LL;
			//   v28.z = v20;
			//   *(_QWORD *)&v28.x = v19;
			//   *(_QWORD *)&v29.x = klass;
			//   v29.z = v16;
			//   UnityEngine::Plane::Plane(&v30, &v29, &v28, &v27, 0LL);
			//   this.fields.Plane = v30;
			// }
			// 
		}

		public void CalculateVertexNormals()
		{
			// // Void CalculateVertexNormals()
			// void HG::Rendering::Runtime::CSG::CSGPolygon::CalculateVertexNormals(CSGPolygon *this, MethodInfo *method)
			// {
			//   CSGVertex__Array *v3; // rcx
			//   __int64 v4; // rdx
			//   CSGVertex__Array *Vertices; // rax
			//   __m128i v6; // xmm1
			//   CSGVertex *v7; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4738, 0LL) )
			//   {
			//     v4 = 0LL;
			//     while ( 1 )
			//     {
			//       Vertices = this.fields.Vertices;
			//       if ( !Vertices )
			//         break;
			//       if ( (int)v4 >= Vertices.max_length.size )
			//         return;
			//       v3 = this.fields.Vertices;
			//       if ( (unsigned int)v4 >= Vertices.max_length.size )
			//         sub_180070270(v3, v4);
			//       v6 = _mm_loadu_si128((const __m128i *)&this.fields);
			//       v7 = v3.vector[(int)v4];
			//       if ( !v7 )
			//         break;
			//       *(_QWORD *)&v7.fields.Normal.x = v6.m128i_i64[0];
			//       v4 = (unsigned int)(v4 + 1);
			//       LODWORD(v7.fields.Normal.z) = _mm_cvtsi128_si32(_mm_srli_si128(v6, 8));
			//     }
			// LABEL_10:
			//     sub_180B536AC(v3, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4738, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public CSGPolygon Flip()
		{
			// // CSGPolygon Flip()
			// CSGPolygon *HG::Rendering::Runtime::CSG::CSGPolygon::Flip(CSGPolygon *this, MethodInfo *method)
			// {
			//   IEnumerable_1_System_Object_ *Vertices; // rbp
			//   Func_2_HG_Rendering_Runtime_CSG_CSGVertex_HG_Rendering_Runtime_CSG_CSGVertex_ *_9__7_0; // rbx
			//   Object *v5; // rsi
			//   Func_2_Object_Object_ *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   CSGPolygon_c__StaticFields *static_fields; // r8
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v10; // rdx
			//   Object__Array *v11; // r9
			//   IEnumerable_1_System_Object_ *v12; // rax
			//   IEnumerable_1_System_Object_ *v13; // rax
			//   int32_t objID; // ebp
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *v15; // rsi
			//   int32_t materialID; // edi
			//   CSGPolygon *v17; // rax
			//   CSGPolygon *v18; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v21; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v22; // [rsp+28h] [rbp-10h]
			// 
			//   if ( !byte_18D919D0E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Reverse<HG::Rendering::Runtime::CSG::CSGVertex>);
			//     sub_18003C530(&MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::CSG::CSGVertex,HG::Rendering::Runtime::CSG::CSGVertex>);
			//     sub_18003C530(&TypeInfo::System::Func<HG::Rendering::Runtime::CSG::CSGVertex,HG::Rendering::Runtime::CSG::CSGVertex>);
			//     sub_18003C530(MethodInfo::HG::Rendering::Runtime::CSG::CSGPolygon::__c::_Flip_b__7_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon::__c);
			//     byte_18D919D0E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4599, 0LL) )
			//   {
			//     Vertices = (IEnumerable_1_System_Object_ *)this.fields.Vertices;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon::__c);
			//     _9__7_0 = TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon::__c.static_fields.__9__7_0;
			//     if ( !_9__7_0 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon::__c);
			//       v5 = (Object *)TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon::__c.static_fields.__9;
			//       v6 = (Func_2_Object_Object_ *)sub_180004920(TypeInfo::System::Func<HG::Rendering::Runtime::CSG::CSGVertex,HG::Rendering::Runtime::CSG::CSGVertex>);
			//       _9__7_0 = (Func_2_HG_Rendering_Runtime_CSG_CSGVertex_HG_Rendering_Runtime_CSG_CSGVertex_ *)v6;
			//       if ( !v6 )
			//         goto LABEL_10;
			//       System::Func<System::Object,System::Object>::Func(
			//         v6,
			//         v5,
			//         MethodInfo::HG::Rendering::Runtime::CSG::CSGPolygon::__c::_Flip_b__7_0[0],
			//         0LL);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon::__c.static_fields;
			//       static_fields.__9__7_0 = _9__7_0;
			//       sub_1800054D0(
			//         (BSP *)&TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon::__c.static_fields.__9__7_0,
			//         v10,
			//         (Bounds *)static_fields,
			//         v11,
			//         v21,
			//         v22);
			//     }
			//     v12 = System::Linq::Enumerable::Select<System::Object,System::Object>(
			//             Vertices,
			//             (Func_2_Object_Object_ *)_9__7_0,
			//             MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::CSG::CSGVertex,HG::Rendering::Runtime::CSG::CSGVertex>);
			//     v13 = System::Linq::Enumerable::Reverse<System::Object>(
			//             v12,
			//             MethodInfo::System::Linq::Enumerable::Reverse<HG::Rendering::Runtime::CSG::CSGVertex>);
			//     objID = this.fields.objID;
			//     v15 = (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)v13;
			//     materialID = this.fields.materialID;
			//     v17 = (CSGPolygon *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
			//     v18 = v17;
			//     if ( v17 )
			//     {
			//       HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(v17, v15, objID, materialID, 0LL);
			//       return v18;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4599, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1310(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public CSGPolygon Clone()
		{
			// // CSGPolygon Clone()
			// CSGPolygon *HG::Rendering::Runtime::CSG::CSGPolygon::Clone(CSGPolygon *this, MethodInfo *method)
			// {
			//   CSGVertex__Array *Vertices; // rdi
			//   int32_t objID; // esi
			//   int32_t materialID; // ebp
			//   CSGPolygon *v6; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   CSGPolygon *v9; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919D0F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
			//     byte_18D919D0F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4582, 0LL) )
			//   {
			//     Vertices = this.fields.Vertices;
			//     objID = this.fields.objID;
			//     materialID = this.fields.materialID;
			//     v6 = (CSGPolygon *)sub_180004920(TypeInfo::HG::Rendering::Runtime::CSG::CSGPolygon);
			//     v9 = v6;
			//     if ( v6 )
			//     {
			//       HG::Rendering::Runtime::CSG::CSGPolygon::CSGPolygon(
			//         v6,
			//         (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGVertex_ *)Vertices,
			//         objID,
			//         materialID,
			//         0LL);
			//       return v9;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4582, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1310(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public static bool IsDegenerateSet(IEnumerable<CSGVertex> set)
		{
			return default(bool);
		}

		public readonly Plane Plane;

		public CSGVertex[] Vertices;

		public int objID;

		public int materialID;
	}
}
