using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class ClothInfo : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 37552
	{
		// Fields
		[Header("Cloth Sim Settings")]
		public Mesh clothMesh; // 0x18
		[HideInInspector]
		public int submeshIdx; // 0x20
		[HideInInspector]
		public int uvIdx; // 0x24
		public readonly uint iterNum; // 0x28
		public readonly float damping; // 0x2C
		public bool enableSoftRange; // 0x30
		[Range(0f, 5f)]
		public float softRange; // 0x34
		[Header("Wind Settings")]
		[Range(0f, 6f)]
		public float windIntensityScale; // 0x38
		[Range(0f, 1f)]
		public float windSoftFactor; // 0x3C
		[Range(0.1f, 2f)]
		public float windFreqFactor; // 0x40
		[Range(-1f, 1f)]
		public float windBalancFactor; // 0x44
		public readonly float windDragFactor; // 0x48
		public readonly float windLiftFactor; // 0x4C
		[Header("Addition Settings(\u7EDD\u5927\u591A\u6570\u60C5\u51B5\u4E0D\u7528\u70B9)")]
		public readonly bool searchAdditionNeighbor; // 0x50
		[Header("Auto Gen Rect Cloth")]
		[HideInInspector]
		public uint clothWidth; // 0x54
		[HideInInspector]
		public uint clothHeight; // 0x58
		[HideInInspector]
		public float gridSize; // 0x5C
		[Header("Cloth Gen From Mesh")]
		[HideInInspector]
		public Mesh previousClothMesh; // 0x60
		[HideInInspector]
		public GameObject[] rodShapedFixedAnchors; // 0x68
		[HideInInspector]
		public float rodAnchorRadius; // 0x70
		[Header("Cloth Fixed Anchor Settings")]
		public readonly float anchorRelaxScale; // 0x74
		public readonly float anchorSecRelaxScale; // 0x78
		[Header("Cloth Anchor Set")]
		public HashSet<int> clothAnchorVertexIndices; // 0x80
		public HashSet<int> clothAnchorConstraintVertexIndices; // 0x88
		public Dictionary<int, List<int>> clothVerAnchorMap; // 0x90
		[HideInInspector]
		[SerializeField]
		private List<int> _clothAnchorSerializeItems; // 0x98
		[HideInInspector]
		[SerializeField]
		private List<int> _clothAnchorConstraintSerializeItems; // 0xA0
		[NonSerialized]
		public uint clothHash; // 0xA8
		[NonSerialized]
		public Bounds clothBounds; // 0xAC
	
		// Constructors
		public ClothInfo() {} // 0x0000000189C6878C-0x0000000189C68920
		// ClothInfo()
		void HG::Rendering::Runtime::ClothInfo::ClothInfo(ClothInfo *this, MethodInfo *method)
		{
		  HashSet_1_System_Int32_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HashSet_1_System_Int32_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  HashSet_1_System_Int32_ *v10; // rax
		  HashSet_1_System_Int32_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  Dictionary_2_System_Int32_System_Object_ *v15; // rax
		  Dictionary_2_System_Int32_List_1_System_Int32_ *v16; // rdi
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v20; // rax
		  List_1_System_Int32_ *v21; // rdi
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v25; // rax
		  List_1_System_Int32_ *v26; // rdi
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  MethodInfo *v30; // [rsp+20h] [rbp-8h]
		  MethodInfo *v31; // [rsp+20h] [rbp-8h]
		  MethodInfo *v32; // [rsp+20h] [rbp-8h]
		  MethodInfo *v33; // [rsp+20h] [rbp-8h]
		  MethodInfo *v34; // [rsp+20h] [rbp-8h]
		
		  this->fields.iterNum = 3;
		  this->fields.damping = 1.0;
		  this->fields.softRange = 0.2;
		  this->fields.windFreqFactor = 1.0;
		  this->fields.clothWidth = 30;
		  this->fields.clothHeight = 30;
		  this->fields.anchorRelaxScale = 1.005;
		  this->fields.anchorSecRelaxScale = 1.005;
		  this->fields.windIntensityScale = 5.0;
		  this->fields.windSoftFactor = 0.5;
		  this->fields.windDragFactor = 0.69999999;
		  this->fields.windLiftFactor = 0.40000001;
		  this->fields.gridSize = 0.2;
		  this->fields.rodAnchorRadius = 5.0;
		  v3 = (HashSet_1_System_Int32_ *)sub_18002C620(TypeInfo::System::Collections::Generic::HashSet<int>);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_7;
		  System::Collections::Generic::HashSet<int>::HashSet(
		    v3,
		    MethodInfo::System::Collections::Generic::HashSet<int>::HashSet);
		  this->fields.clothAnchorVertexIndices = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.clothAnchorVertexIndices, v7, v8, v9, v30);
		  v10 = (HashSet_1_System_Int32_ *)sub_18002C620(TypeInfo::System::Collections::Generic::HashSet<int>);
		  v11 = v10;
		  if ( !v10 )
		    goto LABEL_7;
		  System::Collections::Generic::HashSet<int>::HashSet(
		    v10,
		    MethodInfo::System::Collections::Generic::HashSet<int>::HashSet);
		  this->fields.clothAnchorConstraintVertexIndices = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.clothAnchorConstraintVertexIndices, v12, v13, v14, v31);
		  v15 = (Dictionary_2_System_Int32_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<int,System::Collections::Generic::List<int>>);
		  v16 = (Dictionary_2_System_Int32_List_1_System_Int32_ *)v15;
		  if ( !v15 )
		    goto LABEL_7;
		  System::Collections::Generic::Dictionary<int,System::Object>::Dictionary(
		    v15,
		    MethodInfo::System::Collections::Generic::Dictionary<int,System::Collections::Generic::List<int>>::Dictionary);
		  this->fields.clothVerAnchorMap = v16;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.clothVerAnchorMap, v17, v18, v19, v32);
		  v20 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
		  v21 = (List_1_System_Int32_ *)v20;
		  if ( !v20
		    || (System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		          v20,
		          MethodInfo::System::Collections::Generic::List<int>::List),
		        this->fields._clothAnchorSerializeItems = v21,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields._clothAnchorSerializeItems, v22, v23, v24, v33),
		        v25 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>),
		        (v26 = (List_1_System_Int32_ *)v25) == 0LL) )
		  {
		LABEL_7:
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v25,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields._clothAnchorConstraintSerializeItems = v26;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._clothAnchorConstraintSerializeItems, v27, v28, v29, v34);
		  RootMotion::Singleton<System::Object>::Singleton((Singleton_1_System_Object__1 *)this, 0LL);
		}
		
	
		// Methods
		public void RecomputeBounds() {} // 0x0000000189C685B4-0x0000000189C6878C
		// Void RecomputeBounds()
		void HG::Rendering::Runtime::ClothInfo::RecomputeBounds(ClothInfo *this, MethodInfo *method)
		{
		  Object_1 *clothMesh; // rbx
		  __int64 v4; // rdx
		  Mesh *v5; // rcx
		  Vector3__Array *vertices; // rsi
		  int32_t v7; // ebx
		  Transform *transform; // r14
		  Vector3 *v9; // rax
		  int32_t v10; // r8d
		  MethodInfo *v11; // r9
		  __int64 v12; // xmm0_8
		  float z; // eax
		  Vector3 *Vector; // rax
		  __int64 v15; // rdx
		  __int64 v16; // xmm1_8
		  __int64 v17; // xmm1_8
		  Object_1 *gameObject; // rax
		  String *name; // rax
		  String *v20; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v22; // [rsp+28h] [rbp-39h] BYREF
		  Vector3 v23; // [rsp+38h] [rbp-29h] BYREF
		  Vector3 v24; // [rsp+48h] [rbp-19h] BYREF
		  Vector3 v25; // [rsp+58h] [rbp-9h] BYREF
		  Vector3 v26; // [rsp+68h] [rbp+7h] BYREF
		  Bounds v27; // [rsp+78h] [rbp+17h] BYREF
		  Vector3 v28; // [rsp+90h] [rbp+2Fh] BYREF
		  Vector3 v29[2]; // [rsp+A0h] [rbp+3Fh] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1242, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1242, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_14:
		    sub_1800D8260(v5, v4);
		  }
		  clothMesh = (Object_1 *)this->fields.clothMesh;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality(0LL, clothMesh, 0LL) )
		  {
		    gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		    if ( gameObject )
		    {
		      name = UnityEngine::Object::get_name(gameObject, 0LL);
		      v20 = System::String::Concat((String *)"RecomputeBounds failed: Cloth mesh is null! Game object: ", name, 0LL);
		      HG::Rendering::HGRPLogger::LogError(v20, 0LL);
		      return;
		    }
		    goto LABEL_14;
		  }
		  v5 = this->fields.clothMesh;
		  if ( !v5 )
		    goto LABEL_14;
		  vertices = UnityEngine::Mesh::get_vertices(v5, 0LL);
		  v7 = 0;
		  if ( !vertices )
		    goto LABEL_14;
		  while ( v7 < vertices->max_length.size )
		  {
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    sub_180049C60(vertices, &v22, v7);
		    if ( !transform )
		      goto LABEL_14;
		    v23 = v22;
		    v9 = UnityEngine::Transform::TransformPoint(&v28, transform, &v23, 0LL);
		    if ( v7 )
		    {
		      v12 = *(_QWORD *)&v9->x;
		      z = v9->z;
		      *(_QWORD *)&v24.x = v12;
		      v24.z = z;
		      UnityEngine::Bounds::Encapsulate(&this->fields.clothBounds, &v24, 0LL);
		    }
		    else
		    {
		      memset(&v27, 0, sizeof(v27));
		      Vector = UnityEngine::Animator::GetVector(v29, (Animator *)v9, v10, v11);
		      *(_QWORD *)&v26.x = *(_QWORD *)v15;
		      v16 = *(_QWORD *)&Vector->x;
		      v25.z = Vector->z;
		      LODWORD(Vector) = *(_DWORD *)(v15 + 8);
		      *(_QWORD *)&v25.x = v16;
		      LODWORD(v26.z) = (_DWORD)Vector;
		      UnityEngine::Bounds::Bounds(&v27, &v26, &v25, 0LL);
		      v17 = *(_QWORD *)&v27.m_Extents.y;
		      *(_OWORD *)&this->fields.clothBounds.m_Center.x = *(_OWORD *)&v27.m_Center.x;
		      *(_QWORD *)&this->fields.clothBounds.m_Extents.y = v17;
		    }
		    ++v7;
		  }
		}
		
		public void OnBeforeSerialize() {} // 0x0000000189C6837C-0x0000000189C685B4
		// Void OnBeforeSerialize()
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::ClothInfo::OnBeforeSerialize(ClothInfo *this, MethodInfo *method)
		{
		  ClothInfo *v2; // rbx
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  List_1_System_Int32_ *clothAnchorSerializeItems; // rdi
		  HashSet_1_Beyond_Gameplay_FunctionAreaManager_FunctionAreaIdentifier_ *clothAnchorConstraintVertexIndices; // rdx
		  List_1_System_Int32_ *v7; // rcx
		  List_1_System_Int32_ *clothAnchorConstraintSerializeItems; // rcx
		  __int64 v9; // rdx
		  List_1_System_Int32_ *v10; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int64 v14; // [rsp+0h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v15; // [rsp+20h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v16; // [rsp+28h] [rbp-40h] BYREF
		  HashSet_1_T_Enumerator_System_Int32_ v17; // [rsp+30h] [rbp-38h] BYREF
		  HashSet_1_T_Enumerator_System_Int32_ v18; // [rsp+48h] [rbp-20h] BYREF
		
		  v2 = this;
		  if ( IFix::WrappersManagerImpl::IsPatched(1244, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1244, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    clothAnchorSerializeItems = v2->fields._clothAnchorSerializeItems;
		    if ( !clothAnchorSerializeItems )
		      sub_1800D8260(v4, v3);
		    ++clothAnchorSerializeItems->fields._version;
		    clothAnchorSerializeItems->fields._size = 0;
		    if ( !v2->fields.clothAnchorVertexIndices )
		      sub_1800D8260(v4, v3);
		    System::Collections::Generic::HashSet<Beyond::Gameplay::FunctionAreaManager::FunctionAreaIdentifier>::GetEnumerator(
		      (HashSet_1_T_Enumerator_Beyond_Gameplay_FunctionAreaManager_FunctionAreaIdentifier_ *)&v17,
		      (HashSet_1_Beyond_Gameplay_FunctionAreaManager_FunctionAreaIdentifier_ *)v2->fields.clothAnchorVertexIndices,
		      MethodInfo::System::Collections::Generic::HashSet<int>::GetEnumerator);
		    v18 = v17;
		    v17._set = 0LL;
		    *(_QWORD *)&v17._index = &v18;
		    try
		    {
		      while ( System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext(
		                &v18,
		                MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext) )
		      {
		        v7 = v2->fields._clothAnchorSerializeItems;
		        if ( !v7 )
		          sub_1800D8250(0LL, clothAnchorConstraintVertexIndices);
		        sub_183081250(v7, (unsigned int)v18._current, MethodInfo::System::Collections::Generic::List<int>::Add);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v15 )
		    {
		      clothAnchorConstraintVertexIndices = (HashSet_1_Beyond_Gameplay_FunctionAreaManager_FunctionAreaIdentifier_ *)&v14;
		      v17._set = (HashSet_1_System_Int32_ *)v15->ex;
		      if ( v17._set )
		        sub_18007E1E0(v17._set);
		      v2 = this;
		    }
		    clothAnchorConstraintSerializeItems = v2->fields._clothAnchorConstraintSerializeItems;
		    if ( !clothAnchorConstraintSerializeItems
		      || (++clothAnchorConstraintSerializeItems->fields._version,
		          clothAnchorConstraintSerializeItems->fields._size = 0,
		          (clothAnchorConstraintVertexIndices = (HashSet_1_Beyond_Gameplay_FunctionAreaManager_FunctionAreaIdentifier_ *)v2->fields.clothAnchorConstraintVertexIndices) == 0LL) )
		    {
		      sub_1800D8250(clothAnchorConstraintSerializeItems, clothAnchorConstraintVertexIndices);
		    }
		    System::Collections::Generic::HashSet<Beyond::Gameplay::FunctionAreaManager::FunctionAreaIdentifier>::GetEnumerator(
		      (HashSet_1_T_Enumerator_Beyond_Gameplay_FunctionAreaManager_FunctionAreaIdentifier_ *)&v17,
		      clothAnchorConstraintVertexIndices,
		      MethodInfo::System::Collections::Generic::HashSet<int>::GetEnumerator);
		    v18 = v17;
		    v17._set = 0LL;
		    *(_QWORD *)&v17._index = &v18;
		    try
		    {
		      while ( System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext(
		                &v18,
		                MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext) )
		      {
		        v10 = v2->fields._clothAnchorConstraintSerializeItems;
		        if ( !v10 )
		          sub_1800D8250(0LL, v9);
		        sub_183081250(v10, (unsigned int)v18._current, MethodInfo::System::Collections::Generic::List<int>::Add);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v16 )
		    {
		      v17._set = (HashSet_1_System_Int32_ *)v16->ex;
		      if ( v17._set )
		        sub_18007E1E0(v17._set);
		    }
		  }
		}
		
		public void OnAfterDeserialize() {} // 0x0000000189C68138-0x0000000189C6837C
		// Void OnAfterDeserialize()
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::ClothInfo::OnAfterDeserialize(ClothInfo *this, MethodInfo *method)
		{
		  ClothInfo *v2; // rbx
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  List_1_System_Int32_ *clothAnchorConstraintSerializeItems; // rdx
		  HashSet_1_System_Int32_ *clothAnchorVertexIndices; // rcx
		  HashSet_1_System_UInt64_ *clothAnchorConstraintVertexIndices; // rcx
		  __int64 v10; // rdx
		  HashSet_1_System_Int32_ *v11; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  __int64 v15; // [rsp+0h] [rbp-68h] BYREF
		  Il2CppExceptionWrapper *v16; // [rsp+20h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v17; // [rsp+28h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Int32_ v18; // [rsp+30h] [rbp-38h] BYREF
		  List_1_T_Enumerator_System_Int32_ v19; // [rsp+48h] [rbp-20h] BYREF
		
		  v2 = this;
		  if ( IFix::WrappersManagerImpl::IsPatched(1245, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1245, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    if ( !v2->fields.clothAnchorVertexIndices )
		      sub_1800D8260(v4, v3);
		    System::Collections::Generic::HashSet<unsigned long>::Clear(
		      (HashSet_1_System_UInt64_ *)v2->fields.clothAnchorVertexIndices,
		      MethodInfo::System::Collections::Generic::HashSet<int>::Clear);
		    if ( !v2->fields._clothAnchorSerializeItems )
		      sub_1800D8260(v6, v5);
		    System::Collections::Generic::List<int>::GetEnumerator(
		      &v18,
		      v2->fields._clothAnchorSerializeItems,
		      MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		    v19 = v18;
		    v18._list = 0LL;
		    *(_QWORD *)&v18._index = &v19;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                &v19,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		      {
		        clothAnchorVertexIndices = v2->fields.clothAnchorVertexIndices;
		        if ( !clothAnchorVertexIndices )
		          sub_1800D8250(0LL, clothAnchorConstraintSerializeItems);
		        System::Collections::Generic::HashSet<int>::Add(
		          clothAnchorVertexIndices,
		          v19._current,
		          MethodInfo::System::Collections::Generic::HashSet<int>::Add);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v16 )
		    {
		      clothAnchorConstraintSerializeItems = (List_1_System_Int32_ *)&v15;
		      v18._list = (List_1_System_Int32_ *)v16->ex;
		      if ( v18._list )
		        sub_18007E1E0(v18._list);
		      v2 = this;
		    }
		    clothAnchorConstraintVertexIndices = (HashSet_1_System_UInt64_ *)v2->fields.clothAnchorConstraintVertexIndices;
		    if ( !clothAnchorConstraintVertexIndices
		      || (System::Collections::Generic::HashSet<unsigned long>::Clear(
		            clothAnchorConstraintVertexIndices,
		            MethodInfo::System::Collections::Generic::HashSet<int>::Clear),
		          (clothAnchorConstraintSerializeItems = v2->fields._clothAnchorConstraintSerializeItems) == 0LL) )
		    {
		      sub_1800D8250(clothAnchorConstraintVertexIndices, clothAnchorConstraintSerializeItems);
		    }
		    System::Collections::Generic::List<int>::GetEnumerator(
		      &v18,
		      clothAnchorConstraintSerializeItems,
		      MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		    v19 = v18;
		    v18._list = 0LL;
		    *(_QWORD *)&v18._index = &v19;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                &v19,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		      {
		        v11 = v2->fields.clothAnchorConstraintVertexIndices;
		        if ( !v11 )
		          sub_1800D8250(0LL, v10);
		        System::Collections::Generic::HashSet<int>::Add(
		          v11,
		          v19._current,
		          MethodInfo::System::Collections::Generic::HashSet<int>::Add);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v17 )
		    {
		      v18._list = (List_1_System_Int32_ *)v17->ex;
		      if ( v18._list )
		        sub_18007E1E0(v18._list);
		    }
		  }
		}
		
	}
}
