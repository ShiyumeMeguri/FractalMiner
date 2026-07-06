using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class ClothInfo : MonoBehaviour, ISerializationCallbackReceiver
	{
		public ClothInfo()
		{
		}

		public void RecomputeBounds()
		{
			// // Void RecomputeBounds()
			// void HG::Rendering::Runtime::ClothInfo::RecomputeBounds(ClothInfo *this, MethodInfo *method)
			// {
			//   Object_1 *clothMesh; // rbx
			//   __int64 v4; // rdx
			//   Mesh *v5; // rcx
			//   Vector3__Array *vertices; // rsi
			//   int32_t v7; // ebx
			//   Transform *transform; // r14
			//   Vector3 *v9; // rax
			//   int32_t v10; // r8d
			//   MethodInfo *v11; // r9
			//   __int64 v12; // xmm0_8
			//   float z; // eax
			//   Vector3 *Vector; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // xmm1_8
			//   __int64 v17; // xmm1_8
			//   Object_1 *gameObject; // rax
			//   String *name; // rax
			//   String *v20; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v22; // [rsp+28h] [rbp-39h] BYREF
			//   Vector3 v23; // [rsp+38h] [rbp-29h] BYREF
			//   Vector3 v24; // [rsp+48h] [rbp-19h] BYREF
			//   Vector3 v25; // [rsp+58h] [rbp-9h] BYREF
			//   Vector3 v26; // [rsp+68h] [rbp+7h] BYREF
			//   Bounds v27; // [rsp+78h] [rbp+17h] BYREF
			//   Vector3 v28; // [rsp+90h] [rbp+2Fh] BYREF
			//   Vector3 v29[2]; // [rsp+A0h] [rbp+3Fh] BYREF
			// 
			//   if ( !byte_18D919CDB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18D532430);
			//     byte_18D919CDB = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1106, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1106, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			// LABEL_16:
			//     sub_180B536AC(v5, v4);
			//   }
			//   clothMesh = (Object_1 *)this.fields.clothMesh;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Equality(0LL, clothMesh, 0LL) )
			//   {
			//     gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)this, 0LL);
			//     if ( gameObject )
			//     {
			//       name = UnityEngine::Object::get_name(gameObject, 0LL);
			//       v20 = System::String::Concat((String *)"RecomputeBounds failed: Cloth mesh is null! Game object: ", name, 0LL);
			//       HG::Rendering::HGRPLogger::LogError(v20, 0LL);
			//       return;
			//     }
			//     goto LABEL_16;
			//   }
			//   v5 = this.fields.clothMesh;
			//   if ( !v5 )
			//     goto LABEL_16;
			//   vertices = UnityEngine::Mesh::get_vertices(v5, 0LL);
			//   v7 = 0;
			//   if ( !vertices )
			//     goto LABEL_16;
			//   while ( v7 < vertices.max_length.size )
			//   {
			//     transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
			//     sub_180040F70(vertices, &v22, v7);
			//     if ( !transform )
			//       goto LABEL_16;
			//     v23 = v22;
			//     v9 = UnityEngine::Transform::TransformPoint(&v28, transform, &v23, 0LL);
			//     if ( v7 )
			//     {
			//       v12 = *(_QWORD *)&v9.x;
			//       z = v9.z;
			//       *(_QWORD *)&v24.x = v12;
			//       v24.z = z;
			//       UnityEngine::Bounds::Encapsulate(&this.fields.clothBounds, &v24, 0LL);
			//     }
			//     else
			//     {
			//       memset(&v27, 0, sizeof(v27));
			//       Vector = UnityEngine::Animator::GetVector(v29, (Animator *)v9, v10, v11);
			//       *(_QWORD *)&v26.x = *(_QWORD *)v15;
			//       v16 = *(_QWORD *)&Vector.x;
			//       v25.z = Vector.z;
			//       LODWORD(Vector) = *(_DWORD *)(v15 + 8);
			//       *(_QWORD *)&v25.x = v16;
			//       LODWORD(v26.z) = (_DWORD)Vector;
			//       UnityEngine::Bounds::Bounds(&v27, &v26, &v25, 0LL);
			//       v17 = *(_QWORD *)&v27.m_Extents.y;
			//       *(_OWORD *)&this.fields.clothBounds.m_Center.x = *(_OWORD *)&v27.m_Center.x;
			//       *(_QWORD *)&this.fields.clothBounds.m_Extents.y = v17;
			//     }
			//     ++v7;
			//   }
			// }
			// 
		}

		public void OnBeforeSerialize()
		{
			// // Void OnBeforeSerialize()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::ClothInfo::OnBeforeSerialize(ClothInfo *this, MethodInfo *method)
			// {
			//   ClothInfo *v2; // rbx
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   List_1_System_Int32_ *clothAnchorSerializeItems; // rdi
			//   HashSet_1_System_Int32_ *clothAnchorConstraintVertexIndices; // rdx
			//   List_1_System_Int32_ *v7; // rcx
			//   List_1_System_Int32_ *clothAnchorConstraintSerializeItems; // rcx
			//   __int64 v9; // rdx
			//   List_1_System_Int32_ *v10; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int64 v14; // [rsp+0h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v15; // [rsp+20h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v16; // [rsp+28h] [rbp-40h] BYREF
			//   HashSet_1_T_Enumerator_System_UInt32_ v17; // [rsp+30h] [rbp-38h] BYREF
			//   HashSet_1_T_Enumerator_System_UInt32_ v18; // [rsp+48h] [rbp-20h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D919CDC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
			//     byte_18D919CDC = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1108, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1108, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     clothAnchorSerializeItems = v2.fields._clothAnchorSerializeItems;
			//     if ( !clothAnchorSerializeItems )
			//       sub_180B536AC(v4, v3);
			//     ++clothAnchorSerializeItems.fields._version;
			//     clothAnchorSerializeItems.fields._size = 0;
			//     if ( !v2.fields.clothAnchorVertexIndices )
			//       sub_180B536AC(v4, v3);
			//     System::Collections::Generic::HashSet<int>::GetEnumerator(
			//       (HashSet_1_T_Enumerator_System_Int32_ *)&v17,
			//       v2.fields.clothAnchorVertexIndices,
			//       MethodInfo::System::Collections::Generic::HashSet<int>::GetEnumerator);
			//     v18 = v17;
			//     v17._set = 0LL;
			//     *(_QWORD *)&v17._index = &v18;
			//     try
			//     {
			//       while ( System::Collections::Generic::HashSet_1_T_::Enumerator<unsigned int>::MoveNext(
			//                 &v18,
			//                 MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext) )
			//       {
			//         v7 = v2.fields._clothAnchorSerializeItems;
			//         if ( !v7 )
			//           sub_1802DC2C8(0LL, clothAnchorConstraintVertexIndices);
			//         sub_18231EF50(v7, v18._current);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v15 )
			//     {
			//       clothAnchorConstraintVertexIndices = (HashSet_1_System_Int32_ *)&v14;
			//       v17._set = (HashSet_1_System_UInt32_ *)v15.ex;
			//       if ( v17._set )
			//         sub_18000F780(v17._set);
			//       v2 = this;
			//     }
			//     clothAnchorConstraintSerializeItems = v2.fields._clothAnchorConstraintSerializeItems;
			//     if ( !clothAnchorConstraintSerializeItems
			//       || (++clothAnchorConstraintSerializeItems.fields._version,
			//           clothAnchorConstraintSerializeItems.fields._size = 0,
			//           (clothAnchorConstraintVertexIndices = v2.fields.clothAnchorConstraintVertexIndices) == 0LL) )
			//     {
			//       sub_1802DC2C8(clothAnchorConstraintSerializeItems, clothAnchorConstraintVertexIndices);
			//     }
			//     System::Collections::Generic::HashSet<int>::GetEnumerator(
			//       (HashSet_1_T_Enumerator_System_Int32_ *)&v17,
			//       clothAnchorConstraintVertexIndices,
			//       MethodInfo::System::Collections::Generic::HashSet<int>::GetEnumerator);
			//     v18 = v17;
			//     v17._set = 0LL;
			//     *(_QWORD *)&v17._index = &v18;
			//     try
			//     {
			//       while ( System::Collections::Generic::HashSet_1_T_::Enumerator<unsigned int>::MoveNext(
			//                 &v18,
			//                 MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext) )
			//       {
			//         v10 = v2.fields._clothAnchorConstraintSerializeItems;
			//         if ( !v10 )
			//           sub_1802DC2C8(0LL, v9);
			//         sub_18231EF50(v10, v18._current);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v16 )
			//     {
			//       v17._set = (HashSet_1_System_UInt32_ *)v16.ex;
			//       if ( v17._set )
			//         sub_18000F780(v17._set);
			//     }
			//   }
			// }
			// 
		}

		public void OnAfterDeserialize()
		{
			// // Void OnAfterDeserialize()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::ClothInfo::OnAfterDeserialize(ClothInfo *this, MethodInfo *method)
			// {
			//   ClothInfo *v2; // rbx
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   List_1_System_Int32_ *clothAnchorConstraintSerializeItems; // rdx
			//   HashSet_1_System_Int32_ *clothAnchorVertexIndices; // rcx
			//   HashSet_1_UnityEngine_Vector3Int_ *clothAnchorConstraintVertexIndices; // rcx
			//   __int64 v10; // rdx
			//   HashSet_1_System_Int32_ *v11; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   __int64 v15; // [rsp+0h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v16; // [rsp+20h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v17; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v18; // [rsp+30h] [rbp-38h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v19; // [rsp+48h] [rbp-20h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D919CDD )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     byte_18D919CDD = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1109, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1109, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v2.fields.clothAnchorVertexIndices )
			//       sub_180B536AC(v4, v3);
			//     System::Collections::Generic::HashSet<UnityEngine::Vector3Int>::Clear(
			//       (HashSet_1_UnityEngine_Vector3Int_ *)v2.fields.clothAnchorVertexIndices,
			//       MethodInfo::System::Collections::Generic::HashSet<int>::Clear);
			//     if ( !v2.fields._clothAnchorSerializeItems )
			//       sub_180B536AC(v6, v5);
			//     System::Collections::Generic::List<int>::GetEnumerator(
			//       (List_1_T_Enumerator_System_Int32_ *)&v18,
			//       v2.fields._clothAnchorSerializeItems,
			//       MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     v19 = v18;
			//     v18._list = 0LL;
			//     *(_QWORD *)&v18._index = &v19;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                 &v19,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//       {
			//         clothAnchorVertexIndices = v2.fields.clothAnchorVertexIndices;
			//         if ( !clothAnchorVertexIndices )
			//           sub_1802DC2C8(0LL, clothAnchorConstraintSerializeItems);
			//         System::Collections::Generic::HashSet<int>::Add(
			//           clothAnchorVertexIndices,
			//           v19._current,
			//           MethodInfo::System::Collections::Generic::HashSet<int>::Add);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v16 )
			//     {
			//       clothAnchorConstraintSerializeItems = (List_1_System_Int32_ *)&v15;
			//       v18._list = (List_1_System_UInt32_ *)v16.ex;
			//       if ( v18._list )
			//         sub_18000F780(v18._list);
			//       v2 = this;
			//     }
			//     clothAnchorConstraintVertexIndices = (HashSet_1_UnityEngine_Vector3Int_ *)v2.fields.clothAnchorConstraintVertexIndices;
			//     if ( !clothAnchorConstraintVertexIndices
			//       || (System::Collections::Generic::HashSet<UnityEngine::Vector3Int>::Clear(
			//             clothAnchorConstraintVertexIndices,
			//             MethodInfo::System::Collections::Generic::HashSet<int>::Clear),
			//           (clothAnchorConstraintSerializeItems = v2.fields._clothAnchorConstraintSerializeItems) == 0LL) )
			//     {
			//       sub_1802DC2C8(clothAnchorConstraintVertexIndices, clothAnchorConstraintSerializeItems);
			//     }
			//     System::Collections::Generic::List<int>::GetEnumerator(
			//       (List_1_T_Enumerator_System_Int32_ *)&v18,
			//       clothAnchorConstraintSerializeItems,
			//       MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     v19 = v18;
			//     v18._list = 0LL;
			//     *(_QWORD *)&v18._index = &v19;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                 &v19,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//       {
			//         v11 = v2.fields.clothAnchorConstraintVertexIndices;
			//         if ( !v11 )
			//           sub_1802DC2C8(0LL, v10);
			//         System::Collections::Generic::HashSet<int>::Add(
			//           v11,
			//           v19._current,
			//           MethodInfo::System::Collections::Generic::HashSet<int>::Add);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v17 )
			//     {
			//       v18._list = (List_1_System_UInt32_ *)v17.ex;
			//       if ( v18._list )
			//         sub_18000F780(v18._list);
			//     }
			//   }
			// }
			// 
		}

		[Header("Cloth Sim Settings")]
		public Mesh clothMesh;

		[HideInInspector]
		public int submeshIdx;

		[HideInInspector]
		public int uvIdx;

		public readonly uint iterNum;

		public readonly float damping;

		public bool enableSoftRange;

		[Range(0f, 5f)]
		public float softRange;

		[Range(0f, 6f)]
		[Header("Wind Settings")]
		public float windIntensityScale;

		[Range(0f, 1f)]
		public float windSoftFactor;

		[Range(0.1f, 2f)]
		public float windFreqFactor;

		[Range(-1f, 1f)]
		public float windBalancFactor;

		public readonly float windDragFactor;

		public readonly float windLiftFactor;

		[Header("Addition Settings(绝大多数情况不用点)")]
		public readonly bool searchAdditionNeighbor;

		[HideInInspector]
		[Header("Auto Gen Rect Cloth")]
		public uint clothWidth;

		[HideInInspector]
		public uint clothHeight;

		[HideInInspector]
		public float gridSize;

		[HideInInspector]
		[Header("Cloth Gen From Mesh")]
		public Mesh previousClothMesh;

		[HideInInspector]
		public GameObject[] rodShapedFixedAnchors;

		[HideInInspector]
		public float rodAnchorRadius;

		[Header("Cloth Fixed Anchor Settings")]
		public readonly float anchorRelaxScale;

		public readonly float anchorSecRelaxScale;

		[Header("Cloth Anchor Set")]
		public HashSet<int> clothAnchorVertexIndices;

		public HashSet<int> clothAnchorConstraintVertexIndices;

		public Dictionary<int, List<int>> clothVerAnchorMap;

		[HideInInspector]
		[SerializeField]
		private List<int> _clothAnchorSerializeItems;

		[HideInInspector]
		[SerializeField]
		private List<int> _clothAnchorConstraintSerializeItems;

		[NonSerialized]
		public uint clothHash;

		[NonSerialized]
		public Bounds clothBounds;
	}
}
