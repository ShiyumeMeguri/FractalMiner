using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("Rendering/HG Grass")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class HGGrass : MonoBehaviour // TypeDefIndex: 37992
	{
		// Fields
		[SerializeField]
		private HGGrassData _grassData; // 0x18
		private int m_previousGrassDataInstanceID; // 0x20
		private int m_previousGrassDataVersion; // 0x24
		private NativeArray<Entity> m_entities; // 0x28
		public HashSet<int> sceneStateIds; // 0x38
	
		// Properties
		public HGGrassData grassData { get => default; set {} } // 0x0000000189B6C668-0x0000000189B6C6B8 0x0000000189B6C7F4-0x0000000189B6C858
		// HGGrassData get_grassData()
		HGGrassData *HG::Rendering::Runtime::HGGrass::get_grassData(HGGrass *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2637, 0LL) )
		    return this->fields._grassData;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2637, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_977(Patch, (Object *)this, 0LL);
		}
		

		// Void set_grassData(HGGrassData)
		void HG::Rendering::Runtime::HGGrass::set_grassData(HGGrass *this, HGGrassData *value, MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2638, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2638, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)value,
		      0LL);
		  }
		  else
		  {
		    this->fields._grassData = value;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields._grassData, v5, v6, v7, v11);
		  }
		}
		
		public uint sceneStateMask { get => default; set {} } // 0x0000000189B6C6B8-0x0000000189B6C7F4 0x0000000189B6C858-0x0000000189B6C950
		// UInt32 get_sceneStateMask()
		// Hidden C++ exception states: #wind=1
		uint32_t HG::Rendering::Runtime::HGGrass::get_sceneStateMask(HGGrass *this, MethodInfo *method)
		{
		  uint32_t v3; // ebx
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HashSet_1_System_Int32_ *sceneStateIds; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Il2CppExceptionWrapper *v11; // [rsp+20h] [rbp-48h] BYREF
		  HashSet_1_T_Enumerator_System_Int32_ v12; // [rsp+28h] [rbp-40h] BYREF
		  HashSet_1_T_Enumerator_System_Int32_ v13; // [rsp+40h] [rbp-28h] BYREF
		  uint32_t v14; // [rsp+80h] [rbp+18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2639, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2639, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_81((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = 0;
		    v14 = 0;
		    if ( Beyond::SparkBuffer::Serialize::Extensions::IsNullOrEmpty<System::Object>(
		           (IList_1_System_Object_ *)this->fields.sceneStateIds,
		           MethodInfo::Beyond::CollectionExtensions::IsNullOrEmpty<int>) )
		    {
		      return 0;
		    }
		    else
		    {
		      sceneStateIds = this->fields.sceneStateIds;
		      if ( !sceneStateIds )
		        sub_1800D8260(v5, v4);
		      System::Collections::Generic::HashSet<Beyond::Gameplay::FunctionAreaManager::FunctionAreaIdentifier>::GetEnumerator(
		        (HashSet_1_T_Enumerator_Beyond_Gameplay_FunctionAreaManager_FunctionAreaIdentifier_ *)&v12,
		        (HashSet_1_Beyond_Gameplay_FunctionAreaManager_FunctionAreaIdentifier_ *)sceneStateIds,
		        MethodInfo::System::Collections::Generic::HashSet<int>::GetEnumerator);
		      v13 = v12;
		      v12._set = 0LL;
		      *(_QWORD *)&v12._index = &v13;
		      try
		      {
		        while ( System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext(
		                  &v13,
		                  MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext) )
		        {
		          v3 |= 1 << (v13._current & 0x1F);
		          v14 = v3;
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v11 )
		      {
		        v12._set = (HashSet_1_System_Int32_ *)v11->ex;
		        if ( v12._set )
		          sub_18007E1E0(v12._set);
		        return v14;
		      }
		      return v3;
		    }
		  }
		}
		

		// Void set_sceneStateMask(UInt32)
		void HG::Rendering::Runtime::HGGrass::set_sceneStateMask(HGGrass *this, uint32_t value, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HashSet_1_System_Int32_ *sceneStateIds; // rcx
		  HashSet_1_System_Int32_ *v7; // rax
		  HashSet_1_System_Int32_ *v8; // rcx
		  HashSet_1_System_Int32_ *v9; // rdi
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  HashSet_1_System_Int32_ *v13; // rdi
		  int32_t i; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2640, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2640, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_157(
		        (ILFixDynamicMethodWrapper_9 *)Patch,
		        (Object *)this,
		        (LoginSceneAnimCtrl_EState__Enum)value,
		        0LL);
		      return;
		    }
		    goto LABEL_16;
		  }
		  sceneStateIds = this->fields.sceneStateIds;
		  if ( !value )
		  {
		    if ( sceneStateIds )
		      System::Collections::Generic::HashSet<unsigned long>::Clear(
		        (HashSet_1_System_UInt64_ *)sceneStateIds,
		        MethodInfo::System::Collections::Generic::HashSet<int>::Clear);
		    return;
		  }
		  if ( !sceneStateIds )
		  {
		    v7 = (HashSet_1_System_Int32_ *)sub_18002C620(TypeInfo::System::Collections::Generic::HashSet<int>);
		    v9 = v7;
		    if ( !v7 )
		      goto LABEL_16;
		    System::Collections::Generic::HashSet<int>::HashSet(
		      v7,
		      MethodInfo::System::Collections::Generic::HashSet<int>::HashSet);
		    this->fields.sceneStateIds = v9;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.sceneStateIds, v10, v11, v12, v16);
		  }
		  v8 = this->fields.sceneStateIds;
		  if ( !v8 )
		LABEL_16:
		    sub_1800D8260(v8, v5);
		  System::Collections::Generic::HashSet<unsigned long>::Clear(
		    (HashSet_1_System_UInt64_ *)v8,
		    MethodInfo::System::Collections::Generic::HashSet<int>::Clear);
		  v13 = this->fields.sceneStateIds;
		  for ( i = 0; i < 32; ++i )
		  {
		    if ( _bittest((const int *)&value, i & 0x1F) )
		    {
		      if ( !v13 )
		        goto LABEL_16;
		      System::Collections::Generic::HashSet<int>::Add(
		        v13,
		        i,
		        MethodInfo::System::Collections::Generic::HashSet<int>::Add);
		    }
		  }
		}
		
		public int areaId { get; set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
		// Int32Enum get_defaultValue()
		Int32Enum__Enum UnityEngine::UIElements::TypedUxmlAttributeDescription<System::Int32Enum>::get_defaultValue(
		        TypedUxmlAttributeDescription_1_System_Int32Enum_ *this,
		        MethodInfo *method)
		{
		  return this->fields._defaultValue_k__BackingField;
		}
		

		// Void set_defaultValue(Int32Enum)
		void UnityEngine::UIElements::TypedUxmlAttributeDescription<System::Int32Enum>::set_defaultValue(
		        TypedUxmlAttributeDescription_1_System_Int32Enum_ *this,
		        Int32Enum__Enum value,
		        MethodInfo *method)
		{
		  this->fields._defaultValue_k__BackingField = value;
		}
		
	
		// Constructors
		public HGGrass() {} // 0x0000000189B6C64C-0x0000000189B6C668
		// ComponentControl()
		void Rewired::ComponentControls::ComponentControl::ComponentControl(ComponentControl *this, MethodInfo *method)
		{
		  this->fields._lastUpdateFrame = -1;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		protected void OnDisable() {} // 0x0000000189B6BA7C-0x0000000189B6BAD8
		// Void OnDisable()
		void HG::Rendering::Runtime::HGGrass::OnDisable(HGGrass *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2641, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2641, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGGrass::_DestroyGrassEntities(this, 0LL);
		    this->fields.m_previousGrassDataInstanceID = 0;
		    this->fields.m_previousGrassDataVersion = -1;
		  }
		}
		
		protected void OnDestroy() {} // 0x0000000189B6BA20-0x0000000189B6BA7C
		// Void OnDestroy()
		void HG::Rendering::Runtime::HGGrass::OnDestroy(HGGrass *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2643, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2643, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGGrass::_DestroyGrassEntities(this, 0LL);
		    this->fields.m_previousGrassDataInstanceID = 0;
		    this->fields.m_previousGrassDataVersion = -1;
		  }
		}
		
		protected void Update() {} // 0x0000000189B6BAD8-0x0000000189B6BB78
		// Void Update()
		void HG::Rendering::Runtime::HGGrass::Update(HGGrass *this, MethodInfo *method)
		{
		  int32_t GrassDataInstanceID; // esi
		  HGGrassData *grassData; // rax
		  int32_t GrassDataVersion; // eax
		  int32_t v6; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2644, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2644, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    GrassDataInstanceID = HG::Rendering::Runtime::HGGrass::_GetGrassDataInstanceID(this->fields._grassData, 0LL);
		    grassData = HG::Rendering::Runtime::HGGrass::get_grassData(this, 0LL);
		    GrassDataVersion = HG::Rendering::Runtime::HGGrass::_GetGrassDataVersion(grassData, 0LL);
		    v6 = GrassDataVersion;
		    if ( this->fields.m_previousGrassDataInstanceID != GrassDataInstanceID
		      || GrassDataVersion != this->fields.m_previousGrassDataVersion )
		    {
		      HG::Rendering::Runtime::HGGrass::_DestroyGrassEntities(this, 0LL);
		      HG::Rendering::Runtime::HGGrass::_CreateGrassEntities(this, 0LL);
		      this->fields.m_previousGrassDataInstanceID = GrassDataInstanceID;
		      this->fields.m_previousGrassDataVersion = v6;
		    }
		  }
		}
		
		private void _CreateGrassEntities() {} // 0x0000000189B6BB78-0x0000000189B6C370
		// Void _CreateGrassEntities()
		void HG::Rendering::Runtime::HGGrass::_CreateGrassEntities(HGGrass *this, MethodInfo *method)
		{
		  Object_1 *grassData; // rbx
		  HGGrassData *v4; // rax
		  uint64_t clusters; // rdx
		  unsigned __int64 v6; // rcx
		  int32_t v7; // edx
		  int32_t v8; // r15d
		  __int64 v9; // r12
		  HGGrassData *v10; // rax
		  List_1_HG_Rendering_Runtime_GrassCluster_ *v11; // rax
		  HGGrassData *v12; // rax
		  Object *Item; // rdi
		  MethodInfo *v14; // rdx
		  MethodInfo *v15; // rdx
		  MethodInfo *v16; // rdx
		  MethodInfo *v17; // rdx
		  MethodInfo *v18; // rdx
		  MethodInfo *v19; // rdx
		  MethodInfo *v20; // rdx
		  MethodInfo *v21; // rdx
		  ComponentType v22; // xmm6
		  Object__Class *klass; // rax
		  int namespaze; // eax
		  ComponentType *v25; // rax
		  MonitorData *monitor; // rax
		  ComponentType *v27; // rax
		  uint32_t id; // ebx
		  uint64_t v29; // rax
		  float v30; // eax
		  float v31; // xmm0_4
		  int monitor_high; // ebx
		  char v33; // al
		  uint64_t v34; // rbx
		  uint8_t *ComponentPtrLowBits; // r13
		  int32_t v36; // ebx
		  Object__Class *v37; // rax
		  __int64 v38; // r14
		  __int16 v39; // ax
		  int idleNode_high; // xmm0_4
		  int32_t v41; // eax
		  _QWORD *v42; // rdx
		  __m128 fightNode_high; // xmm2
		  __int64 v44; // xmm1_8
		  __int64 v45; // rax
		  unsigned __int64 v46; // xmm0_8
		  uint64_t ComponentMaskLow; // rax
		  uint8_t *v48; // r14
		  int v49; // ebx
		  MonitorData *v50; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ComponentType value; // [rsp+30h] [rbp-D0h] BYREF
		  ComponentType v53; // [rsp+40h] [rbp-C0h] BYREF
		  EntityManager v54; // [rsp+50h] [rbp-B0h] BYREF
		  NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ v55; // [rsp+60h] [rbp-A0h] BYREF
		  __int128 v56; // [rsp+70h] [rbp-90h]
		  __int64 v57; // [rsp+80h] [rbp-80h]
		  NativeArray_1_UnityEngine_HyperGryph_ECS_Entity_ v58; // [rsp+88h] [rbp-78h] BYREF
		  RenderObjectLODInfoComponent t; // [rsp+98h] [rbp-68h] BYREF
		  Object__Class *v60; // [rsp+B0h] [rbp-50h]
		  Object__Class *v61; // [rsp+C0h] [rbp-40h]
		  __int64 v62; // [rsp+D0h] [rbp-30h]
		  RenderObjectInfoComponent v63; // [rsp+E0h] [rbp-20h] BYREF
		  WeaponComponent_WeaponMountPointModifier batchGroupKey; // [rsp+F8h] [rbp-8h] BYREF
		  EntityManager source; // [rsp+120h] [rbp+20h] BYREF
		  _BYTE v66[32]; // [rsp+130h] [rbp+30h] BYREF
		
		  v57 = 0LL;
		  v54 = 0LL;
		  v55 = 0LL;
		  v56 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2647, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2647, 0LL);
		    if ( !Patch )
		      goto LABEL_41;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    grassData = (Object_1 *)HG::Rendering::Runtime::HGGrass::get_grassData(this, 0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality(grassData, 0LL, 0LL) )
		    {
		      v54 = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&source, 0LL);
		      v4 = HG::Rendering::Runtime::HGGrass::get_grassData(this, 0LL);
		      if ( v4 )
		      {
		        clusters = (uint64_t)v4->fields.clusters;
		        if ( clusters )
		        {
		          v7 = *(_DWORD *)(clusters + 24);
		          v58 = 0LL;
		          Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray(
		            &v58,
		            v7,
		            Allocator__Enum_Persistent,
		            NativeArrayOptions__Enum_ClearMemory,
		            MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::NativeArray);
		          v8 = 0;
		          v9 = 0LL;
		          this->fields.m_entities = v58;
		          while ( 1 )
		          {
		            v10 = HG::Rendering::Runtime::HGGrass::get_grassData(this, 0LL);
		            if ( !v10 )
		              break;
		            v11 = v10->fields.clusters;
		            if ( !v11 )
		              break;
		            if ( v8 >= v11->fields._size )
		              return;
		            v12 = HG::Rendering::Runtime::HGGrass::get_grassData(this, 0LL);
		            if ( !v12 )
		              break;
		            v6 = (unsigned __int64)v12->fields.clusters;
		            if ( !v6 )
		              break;
		            Item = System::Collections::Generic::List<System::Object>::get_Item(
		                     (List_1_System_Object_ *)v6,
		                     v8,
		                     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GrassCluster>::get_Item);
		            Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList(
		              &v55,
		              11,
		              (AllocatorManager_AllocatorHandle)2,
		              MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
		            value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>(
		                                      (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>,
		                                      v14);
		            Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		              &v55,
		              &value,
		              MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		            v53.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>(
		                                    (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>,
		                                    v15);
		            Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		              &v55,
		              &v53,
		              MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		            v53.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>(
		                                    (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>,
		                                    v16);
		            Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		              &v55,
		              &v53,
		              MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		            v53.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>(
		                                    (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>,
		                                    v17);
		            Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		              &v55,
		              &v53,
		              MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		            v53.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>(
		                                    (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>,
		                                    v18);
		            Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		              &v55,
		              &v53,
		              MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		            v53.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>(
		                                    (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>,
		                                    v19);
		            Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		              &v55,
		              &v53,
		              MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		            v53.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>(
		                                    (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>,
		                                    v20);
		            Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		              &v55,
		              &v53,
		              MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		            v53.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectLODInfoComponent>(
		                                    (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectLODInfoComponent>,
		                                    v21);
		            Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		              &v55,
		              &v53,
		              MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		            v22 = (ComponentType)v55;
		            v53 = (ComponentType)v55;
		            if ( !Item )
		              break;
		            klass = Item[3].klass;
		            if ( !klass )
		              break;
		            namespaze = (int)klass->_0.namespaze;
		            if ( namespaze <= 4 )
		            {
		              if ( namespaze > 1 )
		                v25 = namespaze > 2
		                    ? UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK4Component>(
		                        (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK4Component>,
		                        (MethodInfo *)clusters)
		                    : UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK2Component>(
		                        (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK2Component>,
		                        (MethodInfo *)clusters);
		              else
		                v25 = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK1Component>(
		                        (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK1Component>,
		                        (MethodInfo *)clusters);
		            }
		            else
		            {
		              v25 = namespaze > 8
		                  ? UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK16Component>(
		                      (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK16Component>,
		                      (MethodInfo *)clusters)
		                  : UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK8Component>(
		                      (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectK8Component>,
		                      (MethodInfo *)clusters);
		            }
		            value.value = (uint64_t)v25;
		            Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		              (NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)&v53,
		              &value,
		              MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		            monitor = Item[3].monitor;
		            if ( !monitor )
		              break;
		            if ( *((int *)monitor + 6) <= 8 )
		              v27 = *((int *)monitor + 6) > 4
		                  ? UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK8Component>(
		                      (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK8Component>,
		                      (MethodInfo *)clusters)
		                  : UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK4Component>(
		                      (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK4Component>,
		                      (MethodInfo *)clusters);
		            else
		              v27 = *((int *)monitor + 6) > 16
		                  ? UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK32Component>(
		                      (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK32Component>,
		                      (MethodInfo *)clusters)
		                  : UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK16Component>(
		                      (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::GrassClusterK16Component>,
		                      (MethodInfo *)clusters);
		            value.value = (uint64_t)v27;
		            Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		              (NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)&v53,
		              &value,
		              MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		            value = v22;
		            value = *(ComponentType *)sub_180367D74(v66, &value);
		            id = UnityEngine::HyperGryph::ECS::EntityManager::GetOrRegisterEntityType(
		                   &v54,
		                   (NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)&value,
		                   0LL).id;
		            Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Dispose(
		              (NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)&v53,
		              MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Dispose);
		            v29 = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::CreateEntity(&v54, (EntityType)id, 0LL);
		            v60 = Item[1].klass;
		            v53.value = v29;
		            LODWORD(value.value) = (_DWORD)v60;
		            UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>(
		              &v54,
		              (Entity_1 *)&v53,
		              (BoundingCenterXComponent *)&value,
		              MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>);
		            v61 = Item[1].klass;
		            LODWORD(value.value) = HIDWORD(v61);
		            UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>(
		              &v54,
		              (Entity_1 *)&v53,
		              (BoundingCenterYComponent *)&value,
		              MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>);
		            value.value = (uint64_t)Item[1].klass;
		            LODWORD(value.value) = Item[1].monitor;
		            UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>(
		              &v54,
		              (Entity_1 *)&v53,
		              (BoundingCenterZComponent *)&value,
		              MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>);
		            v62 = *(__int64 *)((char *)&Item[1].monitor + 4);
		            LODWORD(value.value) = v62;
		            UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>(
		              &v54,
		              (Entity_1 *)&v53,
		              (BoundingExtentXComponent *)&value,
		              MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>);
		            v58.m_Buffer = *(Void **)((char *)&Item[1].monitor + 4);
		            LODWORD(value.value) = HIDWORD(v58.m_Buffer);
		            UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>(
		              &v54,
		              (Entity_1 *)&v53,
		              (BoundingExtentYComponent *)&value,
		              MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>);
		            value.value = *(uint64_t *)((char *)&Item[1].monitor + 4);
		            LODWORD(value.value) = HIDWORD(Item[2].klass);
		            UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>(
		              &v54,
		              (Entity_1 *)&v53,
		              (BoundingExtentZComponent *)&value,
		              MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>);
		            memset(&t, 0, sizeof(t));
		            v30 = *(float *)&Item[1].monitor;
		            *(_QWORD *)&t.lodCenter.x = Item[1].klass;
		            v31 = *(float *)&Item[2].monitor * *(float *)&Item[2].monitor;
		            t.lodCenter.z = v30;
		            t.enableDither = 1;
		            t.lodObjectHalfSizeSquared = v31;
		            UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectLODInfoComponent>(
		              &v54,
		              (Entity_1 *)&v53,
		              &t,
		              MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectLODInfoComponent>);
		            monitor_high = HIDWORD(Item[2].monitor);
		            v33 = UnityEngine::LayerMask::NameToLayer((String *)"Default", 0LL);
		            v63.sceneMask = -1LL;
		            v63.artTag = 8;
		            v63.sortingFudgeSqr = 256.0;
		            v63.roLayerMask = 1 << (v33 & 0x1F);
		            v63.objectFlags = monitor_high | 0x701;
		            UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>(
		              &v54,
		              (Entity_1 *)&v53,
		              &v63,
		              MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>);
		            v34 = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentMaskLow(&v54, (Entity_1 *)&v53, 0LL) & 0x7F00;
		            ComponentPtrLowBits = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentPtrLowBits(
		                                    &v54,
		                                    (Entity_1 *)&v53,
		                                    v34,
		                                    0LL);
		            v6 = (unsigned __int64)Item[3].klass;
		            value.value = (uint64_t)&ComponentPtrLowBits[24 * (v34 >> 8) + 4];
		            if ( !v6 )
		              break;
		            v6 = *(unsigned int *)(v6 + 24);
		            v36 = 0;
		            *(_DWORD *)ComponentPtrLowBits = v6;
		            while ( 1 )
		            {
		              v37 = Item[3].klass;
		              if ( !v37 )
		                goto LABEL_41;
		              if ( v36 >= SLODWORD(v37->_0.namespaze) )
		                break;
		              System::Collections::Generic::List<Beyond::Gameplay::View::WeaponComponent::WeaponMountPointModifier>::get_Item(
		                &batchGroupKey,
		                (List_1_Beyond_Gameplay_View_WeaponComponent_WeaponMountPointModifier_ *)Item[3].klass,
		                v36,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::GrassRenderer>::get_Item);
		              v57 = 0LL;
		              LOWORD(v56) = 0;
		              v38 = *(_QWORD *)&batchGroupKey.instId;
		              v39 = UnityEngine::HyperGryph::HGGrassRender::RegisterGrassBatchGroup(
		                      batchGroupKey.instId,
		                      *(Material **)&batchGroupKey.fightMp.value,
		                      *(Mesh **)&batchGroupKey.idleMp.value,
		                      (uint16_t)batchGroupKey.idleNode,
		                      0LL);
		              idleNode_high = HIDWORD(batchGroupKey.idleNode);
		              WORD1(v56) = v39;
		              DWORD1(v56) = v38;
		              v6 = 24LL;
		              v41 = v36;
		              if ( *((float *)&batchGroupKey.idleNode + 1) <= 0.0 )
		                idleNode_high = 1065353216;
		              v42 = (_QWORD *)value.value;
		              ++v36;
		              fightNode_high = (__m128)HIDWORD(batchGroupKey.fightNode);
		              v44 = v57;
		              *((_QWORD *)&v56 + 1) = __PAIR64__(HIDWORD(v38), idleNode_high);
		              v45 = 24LL * v41;
		              *(_OWORD *)&ComponentPtrLowBits[v45 + 4] = v56;
		              v46 = _mm_unpacklo_ps((__m128)LODWORD(batchGroupKey.fightNode), fightNode_high).m128_u64[0];
		              *(_QWORD *)&ComponentPtrLowBits[v45 + 20] = v44;
		              *v42 = v46;
		              clusters = (uint64_t)(v42 + 1);
		              value.value = clusters;
		            }
		            ComponentMaskLow = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentMaskLow(
		                                 &v54,
		                                 (Entity_1 *)&v53,
		                                 0LL);
		            v48 = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentPtrLowBits(
		                    &v54,
		                    (Entity_1 *)&v53,
		                    ComponentMaskLow & 0x1E000000000LL,
		                    0LL);
		            v6 = (unsigned __int64)Item[3].monitor;
		            if ( !v6 )
		              break;
		            v49 = 96 * *(_DWORD *)(v6 + 24);
		            Unity::Collections::ListExtensions::ToNativeArray<UnityEngine::HyperGryph::ECS::GrassPerInstanceData>(
		              (NativeArray_1_UnityEngine_HyperGryph_ECS_GrassPerInstanceData_ *)&source,
		              (List_1_UnityEngine_HyperGryph_ECS_GrassPerInstanceData_ *)Item[3].monitor,
		              (AllocatorManager_AllocatorHandle)2,
		              MethodInfo::Unity::Collections::ListExtensions::ToNativeArray<UnityEngine::HyperGryph::ECS::GrassPerInstanceData>);
		            System::Buffer::MemoryCopy((Void *)source.m_entitiesPPtr, (Void *)v48 + 4, v49, v49, 0LL);
		            v50 = Item[3].monitor;
		            if ( !v50 )
		              break;
		            ++v8;
		            *(_DWORD *)v48 = *((_DWORD *)v50 + 6);
		            *(_QWORD *)&this->fields.m_entities.m_Buffer[v9] = v53.value;
		            v9 += 8LL;
		          }
		        }
		      }
		LABEL_41:
		      sub_1800D8260(v6, clusters);
		    }
		  }
		}
		
		private void _DestroyGrassEntities() {} // 0x0000000189B6C370-0x0000000189B6C558
		// Void _DestroyGrassEntities()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGGrass::_DestroyGrassEntities(HGGrass *this, MethodInfo *method)
		{
		  HGGrass *v2; // rbx
		  _QWORD *m_entityTypesPPtr; // r15
		  _QWORD *m_entitiesPPtr; // r12
		  uint8_t *ComponentPtrLowBits; // rsi
		  int v6; // r14d
		  int i; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Il2CppExceptionWrapper *v11; // [rsp+20h] [rbp-98h] BYREF
		  EntityManager v12; // [rsp+28h] [rbp-90h] BYREF
		  EntityManager v13; // [rsp+38h] [rbp-80h] BYREF
		  NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v14; // [rsp+48h] [rbp-70h] BYREF
		  NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v15[2]; // [rsp+68h] [rbp-50h] BYREF
		  Entity_1 entity; // [rsp+D0h] [rbp+18h] BYREF
		
		  v2 = this;
		  if ( IFix::WrappersManagerImpl::IsPatched(2642, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2642, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else if ( v2->fields.m_entities.m_Buffer )
		  {
		    v12 = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v13, 0LL);
		    Unity::Collections::NativeArray_1_T_::ReadOnly<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::GetEnumerator(
		      &v14,
		      (NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&v2->fields.m_entities,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::GetEnumerator);
		    v15[0] = v14;
		    v13.m_entitiesPPtr = 0LL;
		    v13.m_entityTypesPPtr = v15;
		    try
		    {
		      m_entityTypesPPtr = v12.m_entityTypesPPtr;
		      m_entitiesPPtr = v12.m_entitiesPPtr;
		      while ( (unsigned __int8)sub_183FE6BB0(
		                                 v15,
		                                 MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::HyperGryph::ECS::Entity>::MoveNext) )
		      {
		        entity = (Entity_1)v15[0].value;
		        ComponentPtrLowBits = UnityEngine::HyperGryph::ECS::EntityManager::GetComponentPtrLowBits(
		                                &v12,
		                                &entity,
		                                *(_QWORD *)(*m_entityTypesPPtr
		                                          + 576LL
		                                          * *(unsigned int *)(*m_entitiesPPtr + 16LL * LODWORD(v15[0].value.startTime))
		                                          + 16) & 0x7F00LL,
		                                0LL);
		        v6 = *(_DWORD *)ComponentPtrLowBits;
		        for ( i = 0; i < v6; ++i )
		          UnityEngine::HyperGryph::HGGrassRender::UnregisterGrassBatchGroupWithHandle(
		            HIDWORD(*(_QWORD *)&ComponentPtrLowBits[24 * i + 4]),
		            WORD1(*(_QWORD *)&ComponentPtrLowBits[24 * i + 4]),
		            0LL);
		        UnityEngine::HyperGryph::ECS::HGEntityDelayedOperationSystem::RemoveEntity_Injected(&entity, 0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v11 )
		    {
		      v13.m_entitiesPPtr = v11->ex;
		      if ( v13.m_entitiesPPtr )
		        sub_18007E1E0(v13.m_entitiesPPtr);
		      v2 = this;
		    }
		    Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::Dispose(
		      &v2->fields.m_entities,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::Entity>::Dispose);
		  }
		}
		
		private static int _GetGrassDataInstanceID(HGGrassData grassData) => default; // 0x0000000189B6C558-0x0000000189B6C5D4
		// Int32 _GetGrassDataInstanceID(HGGrassData)
		int32_t HG::Rendering::Runtime::HGGrass::_GetGrassDataInstanceID(HGGrassData *grassData, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2645, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2645, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		             (ILFixDynamicMethodWrapper_31 *)Patch,
		             (Object *)grassData,
		             0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality((Object_1 *)grassData, 0LL, 0LL) )
		    {
		      if ( grassData )
		        return UnityEngine::Object::GetInstanceID((Object_1 *)grassData, 0LL);
		LABEL_7:
		      sub_1800D8260(v4, v3);
		    }
		    return 0;
		  }
		}
		
		private static int _GetGrassDataVersion(HGGrassData grassData) => default; // 0x0000000189B6C5D4-0x0000000189B6C64C
		// Int32 _GetGrassDataVersion(HGGrassData)
		int32_t HG::Rendering::Runtime::HGGrass::_GetGrassDataVersion(HGGrassData *grassData, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2646, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2646, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		             (ILFixDynamicMethodWrapper_31 *)Patch,
		             (Object *)grassData,
		             0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality((Object_1 *)grassData, 0LL, 0LL) )
		    {
		      if ( grassData )
		        return grassData->fields.version;
		LABEL_7:
		      sub_1800D8260(v4, v3);
		    }
		    return -1;
		  }
		}
		
	}
}
