using System;
using System.Collections.Generic;
using HG.Rendering.Runtime.CSG;
using IFix.Core;
using UnityEngine;

namespace HG.Rendering.Runtime.SDF
{
	public class MeshCombine
	{
		public MeshCombine()
		{
		}

		public Vector3[] GetVertices()
		{
			// // Vector3[] GetVertices()
			// Vector3__Array *HG::Rendering::Runtime::SDF::MeshCombine::GetVertices(MeshCombine *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   List_1_UnityEngine_Vector3_ *vertices; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919845 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::ToArray);
			//     byte_18D919845 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4705, 0LL) )
			//   {
			//     vertices = this.fields.vertices;
			//     if ( vertices )
			//       return (Vector3__Array *)System::Collections::Generic::List<UnityEngine::InputSystem::HID::HID::HIDElementDescriptor>::ToArray(
			//                                  (List_1_UnityEngine_InputSystem_HID_HID_HIDElementDescriptor_ *)vertices,
			//                                  MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::ToArray);
			// LABEL_7:
			//     sub_180B536AC(vertices, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4705, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1348(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public int[] GetTriangles()
		{
			// // Int32[] GetTriangles()
			// Int32__Array *HG::Rendering::Runtime::SDF::MeshCombine::GetTriangles(MeshCombine *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   List_1_System_Int32_ *triangles; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919846 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::ToArray);
			//     byte_18D919846 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4706, 0LL) )
			//   {
			//     triangles = this.fields.triangles;
			//     if ( triangles )
			//       return System::Collections::Generic::List<int>::ToArray(
			//                triangles,
			//                MethodInfo::System::Collections::Generic::List<int>::ToArray);
			// LABEL_7:
			//     sub_180B536AC(triangles, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4706, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1349(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public Bounds GetBounds()
		{
			// // Bounds GetBounds()
			// Bounds *HG::Rendering::Runtime::SDF::MeshCombine::GetBounds(
			//         Bounds *__return_ptr retstr,
			//         MeshCombine *this,
			//         MethodInfo *method)
			// {
			//   __int128 v5; // xmm0
			//   __int64 v6; // xmm1_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Bounds *v10; // rax
			//   Bounds *result; // rax
			//   Bounds v12; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4628, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4628, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_543(&v12, Patch, (Object *)this, 0LL);
			//     v5 = *(_OWORD *)&v10.m_Center.x;
			//     v6 = *(_QWORD *)&v10.m_Extents.y;
			//   }
			//   else
			//   {
			//     v5 = *(_OWORD *)&this.fields.bounds.m_Center.x;
			//     v6 = *(_QWORD *)&this.fields.bounds.m_Extents.y;
			//   }
			//   *(_OWORD *)&retstr.m_Center.x = v5;
			//   result = retstr;
			//   *(_QWORD *)&retstr.m_Extents.y = v6;
			//   return result;
			// }
			// 
			return null;
		}

		public void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::SDF::MeshCombine::Reset(MeshCombine *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   _DWORD *vertices; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919847 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
			//     byte_18D919847 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4707, 0LL) )
			//   {
			//     vertices = this.fields.vertices;
			//     if ( vertices )
			//     {
			//       ++vertices[7];
			//       vertices[6] = 0;
			//       vertices = this.fields.triangles;
			//       if ( vertices )
			//       {
			//         ++vertices[7];
			//         vertices[6] = 0;
			//         HG::Rendering::Runtime::SDF::MeshCombine::RecalculateBounds(this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(vertices, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4707, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		[IDTag(0)]
		public void AddMesh(Mesh mesh, Matrix4x4 transform)
		{
			// // Void AddMesh(Mesh, Matrix4x4)
			// void HG::Rendering::Runtime::SDF::MeshCombine::AddMesh(
			//         MeshCombine *this,
			//         Mesh *mesh,
			//         Matrix4x4 *transform,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   List_1_System_Int32_ *v8; // rcx
			//   List_1_UnityEngine_Vector3_ *vertices; // rax
			//   int32_t size; // r12d
			//   int32_t v11; // esi
			//   Int32__Array *Triangles; // r14
			//   int32_t v13; // edi
			//   Vector3__Array *v14; // rdi
			//   int32_t v15; // ebx
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   MethodInfo *v19; // r8
			//   Vector3 *v20; // rax
			//   __int64 v21; // xmm0_8
			//   float z; // eax
			//   List_1_UnityEngine_Vector3_ *v23; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   float v28; // [rsp+38h] [rbp-69h] BYREF
			//   __int64 v29; // [rsp+3Ch] [rbp-65h]
			//   Vector4 v30; // [rsp+48h] [rbp-59h]
			//   __int64 v31; // [rsp+58h] [rbp-49h] BYREF
			//   float v32; // [rsp+60h] [rbp-41h]
			//   Vector4 v33; // [rsp+68h] [rbp-39h] BYREF
			//   Matrix4x4 v34; // [rsp+78h] [rbp-29h] BYREF
			//   Vector3 v35; // [rsp+B8h] [rbp+17h] BYREF
			//   Vector4 v36; // [rsp+C8h] [rbp+27h] BYREF
			// 
			//   if ( !byte_18D919848 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Count);
			//     byte_18D919848 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4573, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4573, 0LL);
			//     if ( Patch )
			//     {
			//       v25 = *(_OWORD *)&transform.m01;
			//       *(_OWORD *)&v34.m00 = *(_OWORD *)&transform.m00;
			//       v26 = *(_OWORD *)&transform.m02;
			//       *(_OWORD *)&v34.m01 = v25;
			//       v27 = *(_OWORD *)&transform.m03;
			//       *(_OWORD *)&v34.m02 = v26;
			//       *(_OWORD *)&v34.m03 = v27;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1307(Patch, (Object *)this, (Object *)mesh, &v34, 0LL);
			//       return;
			//     }
			// LABEL_19:
			//     sub_180B536AC(v8, v7);
			//   }
			//   vertices = this.fields.vertices;
			//   if ( !vertices )
			//     goto LABEL_19;
			//   size = vertices.fields._size;
			//   v11 = 0;
			//   if ( !mesh )
			//     goto LABEL_19;
			//   while ( v11 < UnityEngine::Mesh::get_subMeshCount(mesh, 0LL) )
			//   {
			//     Triangles = UnityEngine::Mesh::GetTriangles(mesh, v11, 0LL);
			//     v13 = 0;
			//     if ( !Triangles )
			//       goto LABEL_19;
			//     while ( v13 < Triangles.max_length.size )
			//     {
			//       if ( (unsigned int)v13 >= Triangles.max_length.size )
			//         sub_180070270(v8, v7);
			//       v8 = this.fields.triangles;
			//       if ( !v8 )
			//         goto LABEL_19;
			//       sub_18231EF50(v8, size + Triangles.vector[v13++]);
			//     }
			//     ++v11;
			//   }
			//   v14 = UnityEngine::Mesh::get_vertices(mesh, 0LL);
			//   v15 = 0;
			//   if ( !v14 )
			//     goto LABEL_19;
			//   while ( v15 < v14.max_length.size )
			//   {
			//     sub_180040F70(v14, &v28, v15);
			//     v30.x = v28;
			//     *(_QWORD *)&v30.y = v29;
			//     v16 = *(_OWORD *)&transform.m00;
			//     v30.w = 1.0;
			//     *(_OWORD *)&v34.m00 = v16;
			//     v17 = *(_OWORD *)&transform.m02;
			//     v33 = v30;
			//     v18 = *(_OWORD *)&transform.m01;
			//     *(_OWORD *)&v34.m02 = v17;
			//     *(_OWORD *)&v34.m01 = v18;
			//     *(_OWORD *)&v34.m03 = *(_OWORD *)&transform.m03;
			//     v33 = *UnityEngine::Matrix4x4::op_Multiply(&v36, &v34, &v33, 0LL);
			//     v20 = UnityEngine::Vector4::op_Implicit(&v35, &v33, v19);
			//     if ( !this.fields.vertices )
			//       goto LABEL_19;
			//     v21 = *(_QWORD *)&v20.x;
			//     z = v20.z;
			//     v23 = this.fields.vertices;
			//     v31 = v21;
			//     v32 = z;
			//     sub_180315038(v23, &v31, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
			//     ++v15;
			//   }
			// }
			// 
		}

		[IDTag(1)]
		public void AddMesh(BSP csg, Matrix4x4 transform)
		{
			// // Void AddMesh(BSP, Matrix4x4)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::SDF::MeshCombine::AddMesh(
			//         MeshCombine *this,
			//         BSP *csg,
			//         Matrix4x4 *transform,
			//         MethodInfo *method)
			// {
			//   Matrix4x4 *v4; // r15
			//   Object *v6; // r13
			//   __int64 v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // rbx
			//   LowLevelList_1_System_Object_ *v11; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   LowLevelList_1_System_Object_ *v14; // rdi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v15; // rdx
			//   __int64 v16; // rcx
			//   Bounds *v17; // r8
			//   Object__Array *v18; // r9
			//   __int64 v19; // r8
			//   __int64 v20; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v21; // rdx
			//   Bounds *v22; // r8
			//   Object__Array *v23; // r9
			//   Func_5_UnityEngine_Vector3_UnityEngine_Vector2_Int32_Int32_HG_Rendering_Runtime_CSG_PostionUVPair_ *_9__8_0; // rdi
			//   Object *v25; // rsi
			//   Func_5_UnityEngine_Vector3_UnityEngine_Vector2_Int32_Int32_HG_Rendering_Runtime_CSG_PostionUVPair_ *v26; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v29; // rdx
			//   Bounds *v30; // r8
			//   Object__Array *v31; // r9
			//   Func_2_HG_Rendering_Runtime_CSG_PostionUVPair_Int32_ *v32; // rax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   Func_2_HG_Rendering_Runtime_CSG_PostionUVPair_Int32_ *v35; // rsi
			//   Action_4_Int32_Int32_Int32_HG_Rendering_Runtime_CSG_PostionUVPair_ *v36; // rax
			//   __int64 v37; // rdx
			//   __int64 v38; // rcx
			//   Action_4_Int32_Int32_Int32_HG_Rendering_Runtime_CSG_PostionUVPair_ *v39; // r14
			//   List_1_UnityEngine_Vector3_ *v40; // rdx
			//   Il2CppException *v41; // rcx
			//   Object__Class *klass; // r12
			//   int namespaze; // r12d
			//   unsigned __int64 v44; // rsi
			//   unsigned int v45; // edi
			//   __int64 v46; // r14
			//   List_1_System_Int32_ *monitor; // rcx
			//   __int64 v48; // rdx
			//   __int64 v49; // rcx
			//   __m128 v50; // xmm0
			//   __m128 v51; // xmm1
			//   unsigned __int32 v52; // xmm2_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v54; // rdx
			//   __int64 v55; // rcx
			//   __int64 v56; // [rsp+0h] [rbp-158h] BYREF
			//   MethodInfo *methoda; // [rsp+20h] [rbp-138h]
			//   MethodInfo *v58; // [rsp+28h] [rbp-130h]
			//   int v59; // [rsp+30h] [rbp-128h]
			//   int v60; // [rsp+34h] [rbp-124h]
			//   Il2CppException *ex; // [rsp+38h] [rbp-120h]
			//   void *v62; // [rsp+40h] [rbp-118h]
			//   Vector4 v63; // [rsp+48h] [rbp-110h]
			//   unsigned __int64 v64; // [rsp+60h] [rbp-F8h] BYREF
			//   unsigned __int32 v65; // [rsp+68h] [rbp-F0h]
			//   Vector4 v66; // [rsp+70h] [rbp-E8h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v67; // [rsp+80h] [rbp-D8h] BYREF
			//   List_1_T_Enumerator_UnityEngine_Vector3_ v68; // [rsp+98h] [rbp-C0h] BYREF
			//   List_1_T_Enumerator_UnityEngine_Vector3_ v69; // [rsp+B8h] [rbp-A0h] BYREF
			//   Matrix4x4 v70; // [rsp+E0h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v71; // [rsp+120h] [rbp-38h] BYREF
			//   Il2CppExceptionWrapper *v72; // [rsp+128h] [rbp-30h] BYREF
			// 
			//   v4 = transform;
			//   v6 = (Object *)this;
			//   if ( !byte_18D919849 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Action<int,int,int,HG::Rendering::Runtime::CSG::PostionUVPair>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::CSG::Extensions::ToTriangleList<HG::Rendering::Runtime::CSG::PostionUVPair,int>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     sub_18003C530(&TypeInfo::System::Func<HG::Rendering::Runtime::CSG::PostionUVPair,int>);
			//     sub_18003C530(&TypeInfo::System::Func<UnityEngine::Vector3,UnityEngine::Vector2,int,int,HG::Rendering::Runtime::CSG::PostionUVPair>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c::_AddMesh_b__8_0);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c__DisplayClass8_0::_AddMesh_b__1);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c__DisplayClass8_0::_AddMesh_b__2);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c__DisplayClass8_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c);
			//     byte_18D919849 = 1;
			//   }
			//   memset(&v67, 0, sizeof(v67));
			//   memset(&v68, 0, sizeof(v68));
			//   if ( IFix::WrappersManagerImpl::IsPatched(4619, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4619, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v55, v54);
			//     v70 = *v4;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1307(Patch, v6, (Object *)csg, &v70, 0LL);
			//   }
			//   else
			//   {
			//     v7 = sub_180004920(TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c__DisplayClass8_0);
			//     v10 = v7;
			//     if ( !v7 )
			//       sub_180B536AC(v9, v8);
			//     *(_QWORD *)&v63.x = v7;
			//     v11 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
			//     v14 = v11;
			//     if ( !v11 )
			//       sub_180B536AC(v13, v12);
			//     System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//       v11,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
			//     if ( !v10 )
			//       sub_180B536AC(v16, v15);
			//     *(_QWORD *)(v10 + 16) = v14;
			//     sub_1800054D0((BSP *)(v10 + 16), v15, v17, v18, methoda, v58);
			//     *(_QWORD *)(v10 + 24) = il2cpp_array_new_specific_0(
			//                               TypeInfo::System::Collections::Generic::List<int>,
			//                               10LL,
			//                               v19,
			//                               v20);
			//     sub_1800054D0((BSP *)(v10 + 24), v21, v22, v23, methoda, v58);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c);
			//     _9__8_0 = TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c.static_fields.__9__8_0;
			//     if ( !_9__8_0 )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c);
			//       v25 = (Object *)TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c.static_fields.__9;
			//       v26 = (Func_5_UnityEngine_Vector3_UnityEngine_Vector2_Int32_Int32_HG_Rendering_Runtime_CSG_PostionUVPair_ *)sub_180004920(TypeInfo::System::Func<UnityEngine::Vector3,UnityEngine::Vector2,int,int,HG::Rendering::Runtime::CSG::PostionUVPair>);
			//       _9__8_0 = v26;
			//       if ( !v26 )
			//         sub_180B536AC(v28, v27);
			//       System::Func<UnityEngine::Vector3,UnityEngine::Vector2,int,int,HG::Rendering::Runtime::CSG::PostionUVPair>::Func(
			//         v26,
			//         v25,
			//         MethodInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c::_AddMesh_b__8_0,
			//         0LL);
			//       TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c.static_fields.__9__8_0 = _9__8_0;
			//       sub_1800054D0(
			//         (BSP *)&TypeInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c.static_fields.__9__8_0,
			//         v29,
			//         v30,
			//         v31,
			//         methoda,
			//         v58);
			//     }
			//     v32 = (Func_2_HG_Rendering_Runtime_CSG_PostionUVPair_Int32_ *)sub_180004920(TypeInfo::System::Func<HG::Rendering::Runtime::CSG::PostionUVPair,int>);
			//     v35 = v32;
			//     if ( !v32 )
			//       sub_180B536AC(v34, v33);
			//     System::Func<HG::Rendering::Runtime::CSG::PostionUVPair,int>::Func(
			//       v32,
			//       (Object *)v10,
			//       MethodInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c__DisplayClass8_0::_AddMesh_b__1,
			//       0LL);
			//     v36 = (Action_4_Int32_Int32_Int32_HG_Rendering_Runtime_CSG_PostionUVPair_ *)sub_180004920(TypeInfo::System::Action<int,int,int,HG::Rendering::Runtime::CSG::PostionUVPair>);
			//     v39 = v36;
			//     if ( !v36 )
			//       sub_180B536AC(v38, v37);
			//     System::Action<int,int,int,HG::Rendering::Runtime::CSG::PostionUVPair>::Action(
			//       v36,
			//       (Object *)v10,
			//       MethodInfo::HG::Rendering::Runtime::SDF::MeshCombine::__c__DisplayClass8_0::_AddMesh_b__2,
			//       0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CSG::Extensions);
			//     HG::Rendering::Runtime::CSG::Extensions::ToTriangleList<HG::Rendering::Runtime::CSG::PostionUVPair,int>(
			//       (ICsgProvider *)csg,
			//       _9__8_0,
			//       v35,
			//       v39,
			//       MethodInfo::HG::Rendering::Runtime::CSG::Extensions::ToTriangleList<HG::Rendering::Runtime::CSG::PostionUVPair,int>);
			//     klass = v6[1].klass;
			//     if ( !klass )
			//       sub_180B536AC(v41, v40);
			//     namespaze = (int)klass._0.namespaze;
			//     v60 = namespaze;
			//     v44 = *(_QWORD *)(v10 + 24);
			//     v64 = v44;
			//     v45 = 0;
			//     v59 = 0;
			//     if ( !v44 )
			//       goto LABEL_47;
			//     while ( (signed int)v45 < *(_DWORD *)(v44 + 24) )
			//     {
			//       if ( v45 >= *(_DWORD *)(v44 + 24) )
			//         sub_180070270(v41, v40);
			//       v46 = *(_QWORD *)(v44 + 8LL * (int)v45 + 32);
			//       if ( v46 && *(int *)(v46 + 24) > 0 )
			//       {
			//         System::Collections::Generic::List<int>::GetEnumerator(
			//           (List_1_T_Enumerator_System_Int32_ *)&v69,
			//           *(List_1_System_Int32_ **)(v44 + 8LL * (int)v45 + 32),
			//           MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//         *(_OWORD *)&v67._list = *(_OWORD *)&v69._list;
			//         *(_QWORD *)&v67._current = *(_QWORD *)&v69._current.x;
			//         ex = 0LL;
			//         v62 = &v67;
			//         try
			//         {
			//           while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                     &v67,
			//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//           {
			//             monitor = (List_1_System_Int32_ *)v6[1].monitor;
			//             if ( !monitor )
			//               sub_1802DC2C8(0LL, v40);
			//             sub_18231EF50(monitor, namespaze + v67._current);
			//           }
			//         }
			//         catch ( Il2CppExceptionWrapper *v71 )
			//         {
			//           v40 = (List_1_UnityEngine_Vector3_ *)&v56;
			//           ex = v71.ex;
			//           v41 = ex;
			//           if ( ex )
			//             sub_18000F780(ex);
			//           v4 = transform;
			//           v6 = (Object *)this;
			//           v10 = *(_QWORD *)&v63.x;
			//           namespaze = v60;
			//           v44 = v64;
			//           v45 = v59;
			//         }
			//       }
			//       v59 = ++v45;
			//     }
			//     if ( !v10 || (v40 = *(List_1_UnityEngine_Vector3_ **)(v10 + 16)) == 0LL )
			// LABEL_47:
			//       sub_1802DC2C8(v41, v40);
			//     System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator(
			//       &v69,
			//       v40,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator);
			//     v68 = v69;
			//     ex = 0LL;
			//     v62 = &v68;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext(
			//                 &v68,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext) )
			//       {
			//         *(_QWORD *)&v63.x = *(_QWORD *)&v68._current.x;
			//         *(_QWORD *)&v63.z = LODWORD(v68._current.z) | 0x3F80000000000000LL;
			//         v66 = v63;
			//         v70 = *v4;
			//         v50 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::op_Multiply(
			//                                                          (Vector4 *)&v69,
			//                                                          &v70,
			//                                                          &v66,
			//                                                          0LL));
			//         v51 = _mm_shuffle_ps(v50, v50, 85);
			//         v52 = _mm_shuffle_ps(v50, v50, 170).m128_u32[0];
			//         if ( !v6[1].klass )
			//           sub_1802DC2C8(v49, v48);
			//         v64 = _mm_unpacklo_ps(v50, v51).m128_u64[0];
			//         v65 = v52;
			//         sub_18234A170(v6[1].klass, &v64, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::Add);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v72 )
			//     {
			//       ex = v72.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}

		public void RecalculateBounds()
		{
			// // Void RecalculateBounds()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::SDF::MeshCombine::RecalculateBounds(MeshCombine *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   List_1_UnityEngine_Vector3_ *vertices; // rdi
			//   Animator *v6; // rdx
			//   int32_t v7; // r8d
			//   MethodInfo *v8; // r9
			//   Vector3 *Vector; // rax
			//   __int64 v10; // rdx
			//   __int64 z_low; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   Il2CppExceptionWrapper *v15; // [rsp+20h] [rbp-68h] BYREF
			//   Vector3 v16; // [rsp+30h] [rbp-58h] BYREF
			//   List_1_T_Enumerator_UnityEngine_Vector3_ v17; // [rsp+40h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_UnityEngine_Vector3_ v18; // [rsp+60h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91984A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
			//     byte_18D91984A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4627, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4627, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     *(_OWORD *)&this.fields.bounds.m_Center.x = 0LL;
			//     *(_QWORD *)&this.fields.bounds.m_Extents.y = 0LL;
			//     vertices = this.fields.vertices;
			//     if ( !vertices )
			//       sub_180B536AC(v4, v3);
			//     if ( vertices.fields._size > 0 )
			//     {
			//       System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::BuildingTypeEntry>::get_Item(
			//         (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingTypeEntry *)&v16,
			//         (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_BuildingTypeEntry_ *)this.fields.vertices,
			//         0,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::get_Item);
			//       this.fields.bounds.m_Center = v16;
			//       Vector = UnityEngine::Animator::GetVector(&v16, v6, v7, v8);
			//       z_low = LODWORD(Vector.z);
			//       *(_QWORD *)&this.fields.bounds.m_Extents.x = *(_QWORD *)&Vector.x;
			//       LODWORD(this.fields.bounds.m_Extents.z) = z_low;
			//       if ( !this.fields.vertices )
			//         sub_180B536AC(z_low, v10);
			//       System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator(
			//         &v17,
			//         this.fields.vertices,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::GetEnumerator);
			//       v18 = v17;
			//       v17._list = 0LL;
			//       *(_QWORD *)&v17._index = &v18;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext(
			//                   &v18,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Vector3>::MoveNext) )
			//         {
			//           *(_QWORD *)&v16.x = *(_QWORD *)&v18._current.x;
			//           LODWORD(v16.z) = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v18._current.x, 8));
			//           UnityEngine::Bounds::Encapsulate(&this.fields.bounds, &v16, 0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v15 )
			//       {
			//         v17._list = (List_1_UnityEngine_Vector3_ *)v15.ex;
			//         if ( v17._list )
			//           sub_18000F780(v17._list);
			//       }
			//     }
			//   }
			// }
			// 
		}

		private List<Vector3> vertices;

		private List<int> triangles;

		private Bounds bounds;
	}
}
