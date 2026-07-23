using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryph.ECS;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshFilter))]
	public class HGWaterRendererV2 : MonoBehaviour // TypeDefIndex: 38790
	{
		// Fields
		private Mesh m_mesh; // 0x18
		private MeshFilter m_meshFilter; // 0x20
		private Entity m_entity; // 0x28
		public HGWaterConfig waterConfig; // 0x30
		public bool enableStreaming; // 0x38
		public bool enableOrderByDistance; // 0x39
		public bool enableWetnessMask; // 0x3A
		public HGWaterStreamingType waterStreamingType; // 0x3C
		public HGWaterRender.HGWaterRenderType renderType; // 0x40
		public HGWaterRender.HGWaterHeightLayer heightLayer; // 0x44
		[Header("\u6C34\u5411\u4E0A\u6253\u6E7F\u9AD8\u5EA6\u7684\u8DDD\u79BB")]
		public float wetnessOffset; // 0x48
		private bool m_useFeatureWetnessOffset; // 0x4C
		private float m_initWetnessOffset; // 0x50
		private bool m_ecsDirty; // 0x54
		[Header("\u52A8\u6001\u8D4B\u503CIndex")]
		[SerializeField]
		private int m_dynamicMaterialIndex; // 0x58
	
		// Properties
		public static NativeArray<ComponentType> s_waterType { get => default; } // 0x0000000184162050-0x00000001841621F0 
		// NativeArray`1[UnityEngine.HyperGryph.ECS.ComponentType] get_s_waterType()
		NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *HG::Rendering::Runtime::HGWaterRendererV2::get_s_waterType(
		        NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *__return_ptr retstr,
		        MethodInfo *method)
		{
		  MethodInfo *v3; // rdx
		  MethodInfo *v4; // rdx
		  MethodInfo *v5; // rdx
		  MethodInfo *v6; // rdx
		  MethodInfo *v7; // rdx
		  MethodInfo *v8; // rdx
		  MethodInfo *v9; // rdx
		  MethodInfo *v10; // rdx
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v11; // xmm0
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ v16; // [rsp+20h] [rbp-20h] BYREF
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v17; // [rsp+30h] [rbp-10h] BYREF
		  ComponentType allocator; // [rsp+50h] [rbp+10h] BYREF
		
		  v16 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(5379, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5379, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v15, v14);
		    v11 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_473(&v17, Patch, 0LL);
		  }
		  else
		  {
		    LODWORD(allocator.value) = 2;
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList(
		      &v16,
		      8,
		      (AllocatorManager_AllocatorHandle)2,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
		    allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>(
		                                  (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>,
		                                  v3);
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		      &v16,
		      &allocator,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		    allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>(
		                                  (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>,
		                                  v4);
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		      &v16,
		      &allocator,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		    allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>(
		                                  (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>,
		                                  v5);
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		      &v16,
		      &allocator,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		    allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>(
		                                  (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>,
		                                  v6);
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		      &v16,
		      &allocator,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		    allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>(
		                                  (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>,
		                                  v7);
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		      &v16,
		      &allocator,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		    allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>(
		                                  (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>,
		                                  v8);
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		      &v16,
		      &allocator,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		    allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGWaterComponent>(
		                                  (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGWaterComponent>,
		                                  v9);
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		      &v16,
		      &allocator,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		    allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>(
		                                  (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>,
		                                  v10);
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		      &v16,
		      &allocator,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::op_Implicit(
		      &v17,
		      &v16,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::op_Implicit);
		    v11 = v17;
		  }
		  result = retstr;
		  *retstr = v11;
		  return result;
		}
		
		public int dynamicMaterialIndex { get => default; } // 0x0000000189C7A19C-0x0000000189C7A1E8 
		// Int32 get_dynamicMaterialIndex()
		int32_t HG::Rendering::Runtime::HGWaterRendererV2::get_dynamicMaterialIndex(
		        HGWaterRendererV2 *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5381, 0LL) )
		    return this->fields.m_dynamicMaterialIndex;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5381, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public HGWaterRendererV2() {} // 0x000000018477D0F0-0x000000018477D180
		// HGWaterRendererV2()
		void HG::Rendering::Runtime::HGWaterRendererV2::HGWaterRendererV2(HGWaterRendererV2 *this, MethodInfo *method)
		{
		  if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		  this->fields.enableWetnessMask = 1;
		  this->fields.m_entity = 0LL;
		  this->fields.renderType = 2;
		  this->fields.wetnessOffset = 0.25;
		  this->fields.m_dynamicMaterialIndex = -1;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		private void SetDirty() {} // 0x0000000183C52F60-0x0000000183C52F90
		// Void SetDirty()
		void HG::Rendering::Runtime::HGWaterRendererV2::SetDirty(HGWaterRendererV2 *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5380, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5380, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_ecsDirty = 1;
		  }
		}
		
		public void EnableDynamic(int materialIndex) {} // 0x0000000183C52F20-0x0000000183C52F60
		// Void EnableDynamic(Int32)
		void HG::Rendering::Runtime::HGWaterRendererV2::EnableDynamic(
		        HGWaterRendererV2 *this,
		        int32_t materialIndex,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5382, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5382, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
		      (ILFixDynamicMethodWrapper_29 *)Patch,
		      (Object *)this,
		      materialIndex,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_dynamicMaterialIndex = materialIndex;
		    HG::Rendering::Runtime::HGWaterRendererV2::SetDirty(this, 0LL);
		  }
		}
		
		public void DisableDynamic() {} // 0x0000000189C79FF4-0x0000000189C7A048
		// Void DisableDynamic()
		void HG::Rendering::Runtime::HGWaterRendererV2::DisableDynamic(HGWaterRendererV2 *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5383, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5383, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_dynamicMaterialIndex = -1;
		    HG::Rendering::Runtime::HGWaterRendererV2::SetDirty(this, 0LL);
		  }
		}
		
		private void OnEnable() {} // 0x000000018484C080-0x000000018484C0D0
		// Void OnEnable()
		void HG::Rendering::Runtime::HGWaterRendererV2::OnEnable(HGWaterRendererV2 *this, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5384, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5384, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_meshFilter = (MeshFilter *)UnityEngine::Component::GetComponent<System::Object>(
		                                                (Component *)this,
		                                                MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::MeshFilter>);
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_meshFilter, v3, v4, v5, v9);
		  }
		}
		
		private void OnDisable() {} // 0x0000000184B2D170-0x0000000184B2D1C0
		// Void OnDisable()
		void HG::Rendering::Runtime::HGWaterRendererV2::OnDisable(HGWaterRendererV2 *this, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  MeshFilter *v5; // r9
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		  MethodInfo *v12; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5385, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5385, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGWaterRendererV2::RemoveEntity(this, 0LL);
		    this->fields.m_mesh = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_mesh, v3, v4, 0LL, v11);
		    this->fields.m_meshFilter = v5;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_meshFilter, v6, v7, (Int32__Array **)v5, v12);
		  }
		}
		
		private void Update() {} // 0x00000001831C4A40-0x00000001831C4B90
		// Void Update()
		void HG::Rendering::Runtime::HGWaterRendererV2::Update(HGWaterRendererV2 *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int64 (__fastcall *v5)(HGWaterRendererV2 *); // rax
		  __int64 v6; // rdi
		  unsigned __int8 (__fastcall *v7)(__int64); // rax
		  Transform *transform; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v10; // rax
		  __int64 v11; // rax
		  __int64 v12; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_18;
		  if ( wrapperArray->max_length.size > 5387 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_18;
		    if ( wrapperArray->max_length.size <= 0x150Bu )
		      goto LABEL_35;
		    if ( wrapperArray[149].vector[23] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5387, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		      goto LABEL_18;
		    }
		  }
		  HG::Rendering::Runtime::HGWaterRendererV2::MeshChanged(this, 0LL);
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_18;
		  if ( wrapperArray->max_length.size <= 5393 )
		    goto LABEL_9;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_18;
		  if ( LODWORD(v3->_0.namespaze) <= 0x1511 )
		LABEL_35:
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[114].vtable.Equals.methodPtr )
		  {
		LABEL_9:
		    v5 = (__int64 (__fastcall *)(HGWaterRendererV2 *))qword_18F36FBC0;
		    if ( !qword_18F36FBC0 )
		    {
		      v5 = (__int64 (__fastcall *)(HGWaterRendererV2 *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		      if ( !v5 )
		      {
		        v11 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		        sub_18007E1B0(v11, 0LL);
		      }
		      qword_18F36FBC0 = (__int64)v5;
		    }
		    v6 = v5(this);
		    if ( v6 )
		    {
		      v7 = (unsigned __int8 (__fastcall *)(__int64))qword_18F3700D8;
		      if ( !qword_18F3700D8 )
		      {
		        v7 = (unsigned __int8 (__fastcall *)(__int64))il2cpp_resolve_icall_1("UnityEngine.Transform::get_hasChanged()");
		        if ( !v7 )
		        {
		          v12 = sub_1802EE1B8("UnityEngine.Transform::get_hasChanged()");
		          sub_18007E1B0(v12, 0LL);
		        }
		        qword_18F3700D8 = (__int64)v7;
		      }
		      if ( !v7(v6) )
		        goto LABEL_13;
		      transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( transform )
		      {
		        UnityEngine::Transform::set_hasChanged(transform, 0, 0LL);
		        HG::Rendering::Runtime::HGWaterRendererV2::SetDirty(this, 0LL);
		        goto LABEL_13;
		      }
		    }
		LABEL_18:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  v10 = IFix::WrappersManagerImpl::GetPatch(5393, 0LL);
		  if ( !v10 )
		    goto LABEL_18;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v10, (Object *)this, 0LL);
		LABEL_13:
		  if ( this->fields.m_ecsDirty )
		  {
		    this->fields.m_ecsDirty = 0;
		    HG::Rendering::Runtime::HGWaterRendererV2::UpdateEntity(this, 0LL);
		  }
		}
		
		private void MeshChanged() {} // 0x00000001831C4CB0-0x00000001831C4F70
		// Void MeshChanged()
		void HG::Rendering::Runtime::HGWaterRendererV2::MeshChanged(HGWaterRendererV2 *this, MethodInfo *method)
		{
		  MeshFilter *v3; // rcx
		  __int64 v4; // rax
		  MeshFilter *m_meshFilter; // rdi
		  Mesh *m_mesh; // rsi
		  __int64 (__fastcall *v7)(MeshFilter *, MethodInfo *); // rax
		  __int64 v8; // rdi
		  bool v9; // zf
		  Mesh *v10; // rdi
		  Mesh *sharedMesh; // rdi
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rax
		  Object_1 *v17; // rdi
		  Object_1 *v18; // rdi
		  Object_1 *v19; // rdi
		  Object_1 *v20; // rdi
		  Object_1 *v21; // rdi
		  Object_1 *v22; // rsi
		  MethodInfo *v23; // [rsp+50h] [rbp+28h]
		
		  v3 = (MeshFilter *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = (MeshFilter *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = *(_QWORD *)v3[7].fields._._.m_CachedPtr;
		  if ( !v4 )
		    goto LABEL_44;
		  if ( *(int *)(v4 + 24) > 5388 )
		  {
		    if ( !LODWORD(v3[9].monitor) )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = (MeshFilter *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = *(MeshFilter **)v3[7].fields._._.m_CachedPtr;
		    if ( !v3 )
		      goto LABEL_44;
		    if ( LODWORD(v3[1].klass) <= 0x150C )
		      sub_1800D2AB0(v3, method);
		    if ( v3[1797].monitor )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5388, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		LABEL_44:
		      sub_1800D8260(v3, method);
		    }
		  }
		  m_meshFilter = this->fields.m_meshFilter;
		  m_mesh = this->fields.m_mesh;
		  if ( !m_meshFilter )
		    goto LABEL_44;
		  v7 = (__int64 (__fastcall *)(MeshFilter *, MethodInfo *))qword_18F36F710;
		  if ( !qword_18F36F710 )
		  {
		    v7 = (__int64 (__fastcall *)(MeshFilter *, MethodInfo *))il2cpp_resolve_icall_1("UnityEngine.MeshFilter::get_sharedMesh()");
		    if ( !v7 )
		    {
		      v16 = sub_1802EE1B8("UnityEngine.MeshFilter::get_sharedMesh()");
		      sub_18007E1B0(v16, 0LL);
		    }
		    qword_18F36F710 = (__int64)v7;
		  }
		  v8 = v7(m_meshFilter, method);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( v8 != 0 || m_mesh != 0LL )
		  {
		    if ( v8 )
		    {
		      if ( m_mesh )
		      {
		        v9 = m_mesh == (Mesh *)v8;
		      }
		      else
		      {
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v9 = *(_QWORD *)(v8 + 16) == 0LL;
		      }
		    }
		    else
		    {
		      v3 = (MeshFilter *)TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( !m_mesh )
		        goto LABEL_44;
		      v9 = m_mesh->fields._.m_CachedPtr == 0LL;
		    }
		    if ( v9 )
		      return;
		    v10 = this->fields.m_mesh;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( v10 )
		    {
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( v10->fields._.m_CachedPtr )
		        goto LABEL_56;
		    }
		    v3 = this->fields.m_meshFilter;
		    if ( !v3 )
		      goto LABEL_44;
		    sharedMesh = UnityEngine::MeshFilter::get_sharedMesh(v3, 0LL);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !sharedMesh )
		      goto LABEL_56;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !sharedMesh->fields._.m_CachedPtr )
		    {
		LABEL_56:
		      v17 = (Object_1 *)this->fields.m_mesh;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(v17, 0LL, 0LL) )
		      {
		        v3 = this->fields.m_meshFilter;
		        if ( !v3 )
		          goto LABEL_44;
		        v18 = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh(v3, 0LL);
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Equality(v18, 0LL, 0LL) )
		        {
		          HG::Rendering::Runtime::HGWaterRendererV2::RemoveEntity(this, 0LL);
		LABEL_42:
		          v3 = this->fields.m_meshFilter;
		          if ( v3 )
		          {
		            this->fields.m_mesh = UnityEngine::MeshFilter::get_sharedMesh(v3, 0LL);
		            sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_mesh, v12, v13, v14, v23);
		            return;
		          }
		          goto LABEL_44;
		        }
		      }
		      v19 = (Object_1 *)this->fields.m_mesh;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Inequality(v19, 0LL, 0LL) )
		        goto LABEL_42;
		      v3 = this->fields.m_meshFilter;
		      if ( !v3 )
		        goto LABEL_44;
		      v20 = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh(v3, 0LL);
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Inequality(v20, 0LL, 0LL) )
		        goto LABEL_42;
		      v3 = this->fields.m_meshFilter;
		      v21 = (Object_1 *)this->fields.m_mesh;
		      if ( !v3 )
		        goto LABEL_44;
		      v22 = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh(v3, 0LL);
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Inequality(v21, v22, 0LL) )
		        goto LABEL_42;
		      HG::Rendering::Runtime::HGWaterRendererV2::RemoveEntity(this, 0LL);
		    }
		    HG::Rendering::Runtime::HGWaterRendererV2::AddEntity(this, 0LL);
		    goto LABEL_42;
		  }
		}
		
		private void TransformChanged() {} // 0x00000001831C4B90-0x00000001831C4C70
		// Void TransformChanged()
		void HG::Rendering::Runtime::HGWaterRendererV2::TransformChanged(HGWaterRendererV2 *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int64 (__fastcall *v5)(HGWaterRendererV2 *); // rax
		  __int64 v6; // rbx
		  unsigned __int8 (__fastcall *v7)(__int64); // rax
		  Transform *transform; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rax
		  __int64 v11; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_11;
		  if ( wrapperArray->max_length.size > 5393 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_11;
		    if ( LODWORD(v3->_0.namespaze) <= 0x1511 )
		      sub_1800D2AB0(v3, wrapperArray);
		    if ( v3[114].vtable.Equals.methodPtr )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5393, 0LL);
		      if ( !Patch )
		        goto LABEL_11;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		  }
		  v5 = (__int64 (__fastcall *)(HGWaterRendererV2 *))qword_18F36FBC0;
		  if ( !qword_18F36FBC0 )
		  {
		    v5 = (__int64 (__fastcall *)(HGWaterRendererV2 *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		    if ( !v5 )
		    {
		      v10 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		      sub_18007E1B0(v10, 0LL);
		    }
		    qword_18F36FBC0 = (__int64)v5;
		  }
		  v6 = v5(this);
		  if ( !v6 )
		    goto LABEL_11;
		  v7 = (unsigned __int8 (__fastcall *)(__int64))qword_18F3700D8;
		  if ( !qword_18F3700D8 )
		  {
		    v7 = (unsigned __int8 (__fastcall *)(__int64))il2cpp_resolve_icall_1("UnityEngine.Transform::get_hasChanged()");
		    if ( !v7 )
		    {
		      v11 = sub_1802EE1B8("UnityEngine.Transform::get_hasChanged()");
		      sub_18007E1B0(v11, 0LL);
		    }
		    qword_18F3700D8 = (__int64)v7;
		  }
		  if ( v7(v6) )
		  {
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( transform )
		    {
		      UnityEngine::Transform::set_hasChanged(transform, 0, 0LL);
		      HG::Rendering::Runtime::HGWaterRendererV2::SetDirty(this, 0LL);
		      return;
		    }
		LABEL_11:
		    sub_1800D8260(v3, wrapperArray);
		  }
		}
		
		private void AddEntity() {} // 0x0000000184161750-0x0000000184161850
		// Void AddEntity()
		void HG::Rendering::Runtime::HGWaterRendererV2::AddEntity(HGWaterRendererV2 *this, MethodInfo *method)
		{
		  void (__fastcall *v3)(EntityManager *); // rax
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v4; // xmm6
		  void (__fastcall *v5)(EntityManager *, _QWORD, Void *, EntityType *); // rax
		  __int64 v6; // rax
		  __int64 v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  EntityManager v11; // [rsp+20h] [rbp-48h] BYREF
		  EntityManager v12; // [rsp+30h] [rbp-38h] BYREF
		  EntityType entityType; // [rsp+80h] [rbp+18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5389, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5389, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		    if ( !*(_QWORD *)&this->fields.m_entity )
		    {
		      v3 = (void (__fastcall *)(EntityManager *))qword_18F370C08;
		      v11 = 0LL;
		      if ( !qword_18F370C08 )
		      {
		        v3 = (void (__fastcall *)(EntityManager *))il2cpp_resolve_icall_1(
		                                                     "UnityEngine.HyperGryph.ECS.EntityManager::GetRendererEntityManager_"
		                                                     "Injected(UnityEngine.HyperGryph.ECS.EntityManager&)");
		        if ( !v3 )
		        {
		          v6 = sub_1802EE1B8(
		                 "UnityEngine.HyperGryph.ECS.EntityManager::GetRendererEntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager&)");
		          sub_18007E1B0(v6, 0LL);
		        }
		        qword_18F370C08 = (__int64)v3;
		      }
		      v3(&v11);
		      v12 = v11;
		      v4 = *HG::Rendering::Runtime::HGWaterRendererV2::get_s_waterType(
		              (NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)&v11,
		              0LL);
		      v5 = (void (__fastcall *)(EntityManager *, _QWORD, Void *, EntityType *))qword_18F370C30;
		      entityType.id = 0;
		      if ( !qword_18F370C30 )
		      {
		        v5 = (void (__fastcall *)(EntityManager *, _QWORD, Void *, EntityType *))il2cpp_resolve_icall_1(
		                                                                                   "UnityEngine.HyperGryph.ECS.EntityMana"
		                                                                                   "ger::GetOrRegisterEntityTypeImpl_Inje"
		                                                                                   "cted(UnityEngine.HyperGryph.ECS.Entit"
		                                                                                   "yManager&,System.Int32,System.IntPtr,"
		                                                                                   "UnityEngine.HyperGryph.ECS.EntityType&)");
		        if ( !v5 )
		        {
		          v7 = sub_1802EE1B8(
		                 "UnityEngine.HyperGryph.ECS.EntityManager::GetOrRegisterEntityTypeImpl_Injected(UnityEngine.HyperGryph.E"
		                 "CS.EntityManager&,System.Int32,System.IntPtr,UnityEngine.HyperGryph.ECS.EntityType&)");
		          sub_18007E1B0(v7, 0LL);
		        }
		        qword_18F370C30 = (__int64)v5;
		      }
		      v5(&v12, (unsigned int)_mm_cvtsi128_si32(_mm_srli_si128((__m128i)v4, 8)), v4.m_Buffer, &entityType);
		      this->fields.m_entity = UnityEngine::HyperGryph::ECS::EntityManager::CreateEntity(&v12, entityType, 0LL);
		      HG::Rendering::Runtime::HGWaterRendererV2::UpdateEntity(this, 0LL);
		    }
		  }
		}
		
		private void RemoveEntity() {} // 0x0000000184B2D1C0-0x0000000184B2D220
		// Void RemoveEntity()
		void HG::Rendering::Runtime::HGWaterRendererV2::RemoveEntity(HGWaterRendererV2 *this, MethodInfo *method)
		{
		  EntityManager v3; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  EntityManager _unity_self; // [rsp+20h] [rbp-28h] BYREF
		  EntityManager v8; // [rsp+30h] [rbp-18h] BYREF
		  Entity_1 entity; // [rsp+60h] [rbp+18h] BYREF
		
		  _unity_self = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(5386, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5386, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		    if ( this->fields.m_entity )
		    {
		      v3 = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v8, 0LL);
		      entity = this->fields.m_entity;
		      _unity_self = v3;
		      UnityEngine::HyperGryph::ECS::EntityManager::DestroyEntity_Injected(&_unity_self, &entity, 0LL);
		      if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		      this->fields.m_entity = 0LL;
		    }
		  }
		}
		
		public void UpdateEntity() {} // 0x00000001841621F0-0x0000000184162770
		// Void UpdateEntity()
		void HG::Rendering::Runtime::HGWaterRendererV2::UpdateEntity(HGWaterRendererV2 *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  MeshFilter *m_meshFilter; // rcx
		  Mesh *sharedMesh; // rax
		  struct Object_1__Class *v6; // rcx
		  Mesh *v7; // rbx
		  void (__fastcall *v8)(RenderObjectInfoComponent *); // rax
		  __m128i v9; // xmm7
		  Mesh *v10; // rbx
		  Transform *transform; // rax
		  Bounds *Bounds; // rax
		  __m128 v13; // xmm6
		  Object_1 *v14; // rax
		  int32_t InstanceID; // eax
		  int32_t v16; // r12d
		  HGWaterConfig *waterConfig; // rbx
		  HGWaterConfig *v18; // rax
		  int32_t materialIndex; // r14d
		  struct MethodInfo *v20; // rsi
		  _QWORD *v21; // rbx
		  _QWORD *v22; // xmm7_8
		  EntityInstanceData *v23; // rcx
		  struct MethodInfo *v24; // r15
		  EntityInstanceData *v25; // rcx
		  struct MethodInfo *v26; // r15
		  EntityInstanceData *v27; // rcx
		  struct MethodInfo *v28; // r15
		  EntityInstanceData *v29; // rcx
		  struct MethodInfo *v30; // r15
		  EntityInstanceData *v31; // rcx
		  HGWaterComponent *HGWaterComponent; // rax
		  struct MethodInfo *v33; // r14
		  bool v34; // zf
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  __int128 v37; // xmm1
		  __int128 v38; // xmm0
		  __int128 v39; // xmm1
		  EntityInstanceData *v40; // rcx
		  GameObject *gameObject; // rax
		  char layer; // al
		  GameObject *v43; // rax
		  int32_t artTag; // eax
		  struct MethodInfo *v45; // r14
		  EntityInstanceData *v46; // rcx
		  __int64 v47; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RenderObjectInfoComponent v49; // [rsp+30h] [rbp-D0h] BYREF
		  Bounds v50; // [rsp+50h] [rbp-B0h] BYREF
		  HGWaterComponent v51; // [rsp+70h] [rbp-90h] BYREF
		  HGWaterComponent v52; // [rsp+E0h] [rbp-20h] BYREF
		  BoundingCenterXComponent t; // [rsp+1B0h] [rbp+B0h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5390, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5390, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_43;
		  }
		  if ( !TypeInfo::UnityEngine::HyperGryph::ECS::Entity->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		  if ( this->fields.m_entity )
		  {
		    m_meshFilter = this->fields.m_meshFilter;
		    if ( !m_meshFilter )
		      goto LABEL_43;
		    sharedMesh = UnityEngine::MeshFilter::get_sharedMesh(m_meshFilter, 0LL);
		    v6 = TypeInfo::UnityEngine::Object;
		    v7 = sharedMesh;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v6 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( v7 )
		    {
		      if ( !v6->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v6);
		      if ( v7->fields._.m_CachedPtr )
		      {
		        v8 = (void (__fastcall *)(RenderObjectInfoComponent *))qword_18F370C08;
		        *(_OWORD *)&v49.roLayerMask = 0LL;
		        if ( !qword_18F370C08 )
		        {
		          v8 = (void (__fastcall *)(RenderObjectInfoComponent *))il2cpp_resolve_icall_1(
		                                                                   "UnityEngine.HyperGryph.ECS.EntityManager::GetRenderer"
		                                                                   "EntityManager_Injected(UnityEngine.HyperGryph.ECS.EntityManager&)");
		          if ( !v8 )
		          {
		            v47 = sub_1802EE1B8(
		                    "UnityEngine.HyperGryph.ECS.EntityManager::GetRendererEntityManager_Injected(UnityEngine.HyperGryph.E"
		                    "CS.EntityManager&)");
		            sub_18007E1B0(v47, 0LL);
		          }
		          qword_18F370C08 = (__int64)v8;
		        }
		        v8(&v49);
		        m_meshFilter = this->fields.m_meshFilter;
		        v9 = *(__m128i *)&v49.roLayerMask;
		        if ( m_meshFilter )
		        {
		          v10 = UnityEngine::MeshFilter::get_sharedMesh(m_meshFilter, 0LL);
		          transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		          Bounds = HG::Rendering::Runtime::HGWaterRendererV2::GetBounds(&v50, v10, transform, 0LL);
		          m_meshFilter = this->fields.m_meshFilter;
		          v13 = *(__m128 *)&Bounds->m_Center.x;
		          *(_QWORD *)&v50.m_Extents.y = *(_QWORD *)&Bounds->m_Extents.y;
		          if ( m_meshFilter )
		          {
		            v14 = (Object_1 *)UnityEngine::MeshFilter::get_sharedMesh(m_meshFilter, 0LL);
		            if ( v14 )
		            {
		              InstanceID = UnityEngine::Object::GetInstanceID(v14, 0LL);
		              m_meshFilter = (MeshFilter *)TypeInfo::UnityEngine::Object;
		              v16 = InstanceID;
		              waterConfig = this->fields.waterConfig;
		              if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                m_meshFilter = (MeshFilter *)TypeInfo::UnityEngine::Object;
		                if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                  m_meshFilter = (MeshFilter *)TypeInfo::UnityEngine::Object;
		                }
		              }
		              if ( !waterConfig )
		                goto LABEL_42;
		              if ( !LODWORD(m_meshFilter[9].monitor) )
		                il2cpp_runtime_class_init_1(m_meshFilter);
		              if ( waterConfig->fields._._.m_CachedPtr )
		              {
		                v18 = this->fields.waterConfig;
		                if ( !v18 )
		                  goto LABEL_43;
		                materialIndex = v18->fields.materialIndex;
		              }
		              else
		              {
		LABEL_42:
		                materialIndex = 0;
		              }
		              if ( this->fields.m_dynamicMaterialIndex != -1 )
		                materialIndex = this->fields.m_dynamicMaterialIndex;
		              LODWORD(t.x) = (BoundingCenterXComponent)v13.m128_i32[0];
		              UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>(
		                (EntityManager *)&v49,
		                &this->fields.m_entity,
		                &t,
		                MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterXComponent>);
		              v20 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>;
		              LODWORD(t.x) = (BoundingCenterXComponent)_mm_shuffle_ps(v13, v13, 85).m128_u32[0];
		              if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>->rgctx_data )
		                sub_1800430B0(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>);
		              v21 = (_QWORD *)v9.m128i_i64[0];
		              v22 = (_QWORD *)_mm_srli_si128(v9, 8).m128i_u64[0];
		              v23 = (EntityInstanceData *)(*v21 + 16LL * this->fields.m_entity.globalIndex);
		              UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingCenterYComponent>(
		                v23,
		                (EntityTypeInstanceData *)(*v22 + 576LL * v23->entityType),
		                (BoundingCenterYComponent *)&t,
		                (MethodInfo *)v20->rgctx_data->rgctxDataDummy);
		              v24 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>;
		              LODWORD(t.x) = (BoundingCenterXComponent)_mm_shuffle_ps(v13, v13, 170).m128_u32[0];
		              if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>->rgctx_data )
		                sub_1800430B0(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>);
		              v25 = (EntityInstanceData *)(*v21 + 16LL * this->fields.m_entity.globalIndex);
		              UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingCenterZComponent>(
		                v25,
		                (EntityTypeInstanceData *)(*v22 + 576LL * v25->entityType),
		                (BoundingCenterZComponent *)&t,
		                (MethodInfo *)v24->rgctx_data->rgctxDataDummy);
		              v26 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>;
		              LODWORD(t.x) = (BoundingCenterXComponent)_mm_shuffle_ps(v13, v13, 255).m128_u32[0];
		              if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>->rgctx_data )
		                sub_1800430B0(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>);
		              v27 = (EntityInstanceData *)(*v21 + 16LL * this->fields.m_entity.globalIndex);
		              UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingExtentXComponent>(
		                v27,
		                (EntityTypeInstanceData *)(*v22 + 576LL * v27->entityType),
		                (BoundingExtentXComponent *)&t,
		                (MethodInfo *)v26->rgctx_data->rgctxDataDummy);
		              v28 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>;
		              t.x = v50.m_Extents.y;
		              if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>->rgctx_data )
		                sub_1800430B0(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>);
		              v29 = (EntityInstanceData *)(*v21 + 16LL * this->fields.m_entity.globalIndex);
		              UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingExtentYComponent>(
		                v29,
		                (EntityTypeInstanceData *)(*v22 + 576LL * v29->entityType),
		                (BoundingExtentYComponent *)&t,
		                (MethodInfo *)v28->rgctx_data->rgctxDataDummy);
		              v30 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>;
		              t.x = v50.m_Extents.z;
		              if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>->rgctx_data )
		                sub_1800430B0(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>);
		              v31 = (EntityInstanceData *)(*v21 + 16LL * this->fields.m_entity.globalIndex);
		              UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::BoundingExtentZComponent>(
		                v31,
		                (EntityTypeInstanceData *)(*v22 + 576LL * v31->entityType),
		                (BoundingExtentZComponent *)&t,
		                (MethodInfo *)v30->rgctx_data->rgctxDataDummy);
		              HGWaterComponent = HG::Rendering::Runtime::HGWaterRendererV2::GetHGWaterComponent(
		                                   &v52,
		                                   this,
		                                   v16,
		                                   materialIndex,
		                                   0LL);
		              v33 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGWaterComponent>;
		              v34 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGWaterComponent>->rgctx_data == 0LL;
		              v35 = *(_OWORD *)&HGWaterComponent->objectToWorld.m20;
		              *(_OWORD *)&v51.renderTypeMask = *(_OWORD *)&HGWaterComponent->renderTypeMask;
		              v36 = *(_OWORD *)&HGWaterComponent->objectToWorld.m21;
		              *(_OWORD *)&v51.objectToWorld.m20 = v35;
		              v37 = *(_OWORD *)&HGWaterComponent->objectToWorld.m22;
		              *(_OWORD *)&v51.objectToWorld.m21 = v36;
		              v38 = *(_OWORD *)&HGWaterComponent->objectToWorld.m23;
		              *(_OWORD *)&v51.objectToWorld.m22 = v37;
		              v39 = *(_OWORD *)&HGWaterComponent->param0.z;
		              *(_OWORD *)&v51.objectToWorld.m23 = v38;
		              *(_QWORD *)&v51.param1.z = *(_QWORD *)&HGWaterComponent->param1.z;
		              *(_OWORD *)&v51.param0.z = v39;
		              if ( v34 )
		                sub_1800430B0(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGWaterComponent>);
		              v40 = (EntityInstanceData *)(*v21 + 16LL * this->fields.m_entity.globalIndex);
		              UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::HGWaterComponent>(
		                v40,
		                (EntityTypeInstanceData *)(*v22 + 576LL * v40->entityType),
		                &v51,
		                (MethodInfo *)v33->rgctx_data->rgctxDataDummy);
		              gameObject = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		              if ( gameObject )
		              {
		                layer = UnityEngine::GameObject::get_layer(gameObject, 0LL);
		                v49.objectFlags = 1793;
		                v49.sceneMask = -1LL;
		                v49.roLayerMask = 1 << (layer & 0x1F);
		                v43 = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		                if ( v43 )
		                {
		                  artTag = UnityEngine::GameObject::get_artTag(v43, 0LL);
		                  v45 = MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>;
		                  v49.artTag = artTag;
		                  v49.sortingFudgeSqr = 256.0;
		                  if ( !MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>->rgctx_data )
		                    sub_1800430B0(MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>);
		                  v46 = (EntityInstanceData *)(*v21 + 16LL * this->fields.m_entity.globalIndex);
		                  UnityEngine::HyperGryph::ECS::EntityManager::SetComponentImplWithRef<UnityEngine::HyperGryph::ECS::RenderObjectInfoComponent>(
		                    v46,
		                    (EntityTypeInstanceData *)(*v22 + 576LL * v46->entityType),
		                    &v49,
		                    (MethodInfo *)v45->rgctx_data->rgctxDataDummy);
		                  return;
		                }
		              }
		            }
		          }
		        }
		LABEL_43:
		        sub_1800D8260(m_meshFilter, v3);
		      }
		    }
		  }
		}
		
		public void RestWetnessOffset() {} // 0x0000000183C52F90-0x0000000183C52FC0
		// Void RestWetnessOffset()
		void HG::Rendering::Runtime::HGWaterRendererV2::RestWetnessOffset(HGWaterRendererV2 *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5394, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5394, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.m_useFeatureWetnessOffset )
		  {
		    this->fields.wetnessOffset = this->fields.m_initWetnessOffset;
		    this->fields.m_useFeatureWetnessOffset = 0;
		  }
		}
		
		public void FeatureWetnessOffset(float offset) {} // 0x0000000189C7A048-0x0000000189C7A0B4
		// Void FeatureWetnessOffset(Single)
		void HG::Rendering::Runtime::HGWaterRendererV2::FeatureWetnessOffset(
		        HGWaterRendererV2 *this,
		        float offset,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5395, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5395, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, offset, 0LL);
		  }
		  else
		  {
		    if ( !this->fields.m_useFeatureWetnessOffset )
		      this->fields.m_initWetnessOffset = this->fields.wetnessOffset;
		    this->fields.wetnessOffset = offset;
		    this->fields.m_useFeatureWetnessOffset = 1;
		  }
		}
		
		public HGWaterComponent GetHGWaterComponent(int meshInstanceID, int materialIndex) => default; // 0x00000001841627B0-0x0000000184162940
		// HGWaterComponent GetHGWaterComponent(Int32, Int32)
		HGWaterComponent *HG::Rendering::Runtime::HGWaterRendererV2::GetHGWaterComponent(
		        HGWaterComponent *__return_ptr retstr,
		        HGWaterRendererV2 *this,
		        int32_t meshInstanceID,
		        int32_t materialIndex,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Matrix4x4 *localToWorldMatrix; // rax
		  bool v13; // zf
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  float v17; // xmm1_4
		  float v18; // xmm3_4
		  __m128 v19; // xmm2
		  __int128 v20; // xmm0
		  __m128 v21; // xmm2
		  __m128 v22; // xmm2
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  Vector4 v25; // xmm2
		  __int128 v26; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGWaterComponent *v29; // rax
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  HGWaterComponent v35; // [rsp+40h] [rbp-B8h] BYREF
		  Matrix4x4 v36; // [rsp+B0h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5392, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5392, 0LL);
		    if ( Patch )
		    {
		      v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1558(
		              &v35,
		              Patch,
		              (Object *)this,
		              meshInstanceID,
		              materialIndex,
		              0LL);
		      v30 = *(_OWORD *)&v29->objectToWorld.m20;
		      *(_OWORD *)&retstr->renderTypeMask = *(_OWORD *)&v29->renderTypeMask;
		      v31 = *(_OWORD *)&v29->objectToWorld.m21;
		      *(_OWORD *)&retstr->objectToWorld.m20 = v30;
		      v32 = *(_OWORD *)&v29->objectToWorld.m22;
		      *(_OWORD *)&retstr->objectToWorld.m21 = v31;
		      v33 = *(_OWORD *)&v29->objectToWorld.m23;
		      *(_OWORD *)&retstr->objectToWorld.m22 = v32;
		      v34 = *(_OWORD *)&v29->param0.z;
		      *(_OWORD *)&retstr->objectToWorld.m23 = v33;
		      *(_QWORD *)&v33 = *(_QWORD *)&v29->param1.z;
		      *(_OWORD *)&retstr->param0.z = v34;
		      *(_QWORD *)&retstr->param1.z = v33;
		      return retstr;
		    }
		LABEL_9:
		    sub_1800D8260(v11, v10);
		  }
		  v35.renderTypeMask = this->fields.renderType;
		  memset(&v35.objectToWorld, 0, sizeof(v35.objectToWorld));
		  v35.meshID = meshInstanceID;
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  if ( !transform )
		    goto LABEL_9;
		  localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(&v36, transform, 0LL);
		  v13 = !this->fields.enableOrderByDistance;
		  *(_QWORD *)&v35.param0.y = 0LL;
		  v35.param0.w = 0.0;
		  v14 = *(_OWORD *)&localToWorldMatrix->m01;
		  *(_OWORD *)&v35.objectToWorld.m00 = *(_OWORD *)&localToWorldMatrix->m00;
		  v15 = *(_OWORD *)&localToWorldMatrix->m02;
		  *(_OWORD *)&v35.objectToWorld.m01 = v14;
		  v16 = *(_OWORD *)&localToWorldMatrix->m03;
		  *(_OWORD *)&v35.objectToWorld.m02 = v15;
		  *(_OWORD *)&v35.objectToWorld.m03 = v16;
		  v17 = 1.0;
		  v35.param0.x = (float)materialIndex;
		  if ( v13 )
		    v18 = 0.0;
		  else
		    v18 = 1.0;
		  if ( !this->fields.enableWetnessMask )
		    v17 = 0.0;
		  v19 = _mm_shuffle_ps((__m128)LODWORD(this->fields.wetnessOffset), (__m128)LODWORD(this->fields.wetnessOffset), 225);
		  v19.m128_f32[0] = (float)this->fields.heightLayer;
		  *(_OWORD *)&retstr->renderTypeMask = *(_OWORD *)&v35.renderTypeMask;
		  v20 = *(_OWORD *)&v35.objectToWorld.m21;
		  v21 = _mm_shuffle_ps(v19, v19, 198);
		  v21.m128_f32[0] = v18;
		  v22 = _mm_shuffle_ps(v21, v21, 39);
		  v22.m128_f32[0] = v17;
		  *(_OWORD *)&retstr->objectToWorld.m20 = *(_OWORD *)&v35.objectToWorld.m20;
		  v23 = *(_OWORD *)&v35.objectToWorld.m22;
		  *(_OWORD *)&retstr->objectToWorld.m21 = v20;
		  v24 = *(_OWORD *)&v35.objectToWorld.m23;
		  *(_OWORD *)&retstr->objectToWorld.m22 = v23;
		  v25 = (Vector4)_mm_shuffle_ps(v22, v22, 57);
		  v35.param1 = v25;
		  v26 = *(_OWORD *)&v35.param0.z;
		  *(_OWORD *)&retstr->objectToWorld.m23 = v24;
		  *(_OWORD *)&retstr->param0.z = v26;
		  *(_QWORD *)&retstr->param1.z = *(_OWORD *)&_mm_unpackhi_pd((__m128d)v25, (__m128d)v25);
		  return retstr;
		}
		
		public static Bounds GetBounds(Mesh mesh, Transform transform) => default; // 0x000000018323EAC0-0x000000018323F3B0
		// Bounds GetBounds(Mesh, Transform)
		Bounds *HG::Rendering::Runtime::HGWaterRendererV2::GetBounds(
		        Bounds *__return_ptr retstr,
		        Mesh *mesh,
		        Transform *transform,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  void (__fastcall *v9)(Transform *, Matrix4x4 *, Transform *, MethodInfo *); // rax
		  void (__fastcall *v10)(Mesh *, Vector4 *); // rax
		  float v11; // xmm4_4
		  void (__fastcall *v12)(Transform *, Vector4 *); // rax
		  void (__fastcall *v13)(Transform *, unsigned __int64 *); // rax
		  void (__fastcall *v14)(unsigned __int64 *, Vector4 *, unsigned __int64 *, Matrix4x4 *); // rax
		  Vector4 *Column; // rax
		  __m128 v16; // xmm6
		  float z; // xmm13_4
		  Vector4 *v18; // rax
		  __m128 v19; // xmm9
		  float v20; // xmm14_4
		  Vector4 *v21; // rax
		  __m128 v22; // xmm10
		  float v23; // xmm15_4
		  void (__fastcall *v24)(Mesh *, Bounds *); // rax
		  MethodInfo *v25; // r9
		  Vector3 *v26; // rax
		  __int64 v27; // xmm11_8
		  __m128 si128; // xmm8
		  void (__fastcall *v29)(Mesh *, Bounds *); // rax
		  float v30; // xmm11_4
		  MethodInfo *v31; // r9
		  Vector3 *v32; // rax
		  __m128 v33; // xmm3
		  void (__fastcall *v34)(Mesh *, Bounds *); // rax
		  float v35; // xmm6_4
		  MethodInfo *v36; // r9
		  Vector3 *v37; // rax
		  __m128 z_low; // xmm12
		  void (__fastcall *v39)(Mesh *, Bounds *); // rax
		  __m128 v40; // xmm12
		  MethodInfo *v41; // r9
		  Vector3 *v42; // rax
		  __int64 v43; // xmm9_8
		  void (__fastcall *v44)(Mesh *, Bounds *); // rax
		  float v45; // xmm9_4
		  MethodInfo *v46; // r9
		  Vector3 *v47; // rax
		  __m128 v48; // xmm3
		  void (__fastcall *v49)(Mesh *, Bounds *); // rax
		  float v50; // xmm6_4
		  MethodInfo *v51; // r9
		  Vector3 *v52; // rax
		  __m128 v53; // xmm10
		  void (__fastcall *v54)(Mesh *, Bounds *); // rax
		  __m128 v55; // xmm10
		  MethodInfo *v56; // r9
		  Vector3 *v57; // rax
		  __int64 v58; // xmm9_8
		  void (__fastcall *v59)(Mesh *, Bounds *); // rax
		  float v60; // xmm9_4
		  MethodInfo *v61; // r9
		  Vector3 *v62; // rax
		  __m128 v63; // xmm3
		  void (__fastcall *v64)(Mesh *, Bounds *); // rax
		  float v65; // xmm6_4
		  MethodInfo *v66; // r9
		  Vector3 *v67; // rax
		  float v68; // xmm2_4
		  float v69; // xmm3_4
		  MethodInfo *v70; // r9
		  Vector3 *v71; // rax
		  __int64 v72; // xmm0_8
		  Bounds *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Bounds *v75; // rax
		  __int128 v76; // xmm0
		  __int64 v77; // xmm1_8
		  __int64 v78; // rax
		  __int64 v79; // rax
		  __int64 v80; // rax
		  __int64 v81; // rax
		  __int64 v82; // rax
		  ILFixDynamicMethodWrapper_2 *v83; // rax
		  Vector3 *v84; // rax
		  unsigned __int64 v85; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *v86; // rax
		  Vector3 *v87; // rax
		  unsigned __int64 v88; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *v89; // rax
		  Vector3 *v90; // rax
		  unsigned __int64 v91; // xmm1_8
		  __int64 v92; // rax
		  __int64 v93; // rax
		  __int64 v94; // rax
		  __int64 v95; // rax
		  __int64 v96; // rax
		  __int64 v97; // rax
		  __int64 v98; // rax
		  __int64 v99; // rax
		  __int64 v100; // rax
		  Vector4 v101; // [rsp+30h] [rbp-D0h] BYREF
		  Vector4 v102; // [rsp+40h] [rbp-C0h] BYREF
		  Bounds v103; // [rsp+50h] [rbp-B0h] BYREF
		  unsigned __int64 v104; // [rsp+68h] [rbp-98h] BYREF
		  int v105; // [rsp+70h] [rbp-90h]
		  float v106; // [rsp+78h] [rbp-88h]
		  float v107; // [rsp+7Ch] [rbp-84h]
		  unsigned __int64 v108; // [rsp+80h] [rbp-80h] BYREF
		  int v109; // [rsp+88h] [rbp-78h]
		  unsigned __int64 v110; // [rsp+90h] [rbp-70h] BYREF
		  int v111; // [rsp+98h] [rbp-68h]
		  Matrix4x4 v112; // [rsp+A0h] [rbp-60h] BYREF
		  Vector4 v113; // [rsp+E0h] [rbp-20h] BYREF
		  __int64 v114; // [rsp+F0h] [rbp-10h]
		  Matrix4x4 v115; // [rsp+100h] [rbp+0h] BYREF
		  float v116; // [rsp+1F0h] [rbp+F0h]
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_37;
		  if ( wrapperArray->max_length.size > 5391 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_37;
		    if ( wrapperArray->max_length.size <= 0x150Fu )
		      goto LABEL_81;
		    if ( wrapperArray[149].vector[27] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5391, 0LL);
		      if ( Patch )
		      {
		        v75 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_847(&v103, Patch, (Object *)mesh, (Object *)transform, 0LL);
		        v76 = *(_OWORD *)&v75->m_Center.x;
		        v77 = *(_QWORD *)&v75->m_Extents.y;
		        result = retstr;
		        *(_OWORD *)&retstr->m_Center.x = v76;
		        *(_QWORD *)&retstr->m_Extents.y = v77;
		        return result;
		      }
		      goto LABEL_37;
		    }
		  }
		  if ( !transform )
		    goto LABEL_37;
		  v9 = (void (__fastcall *)(Transform *, Matrix4x4 *, Transform *, MethodInfo *))qword_18F370148;
		  memset(&v112, 0, sizeof(v112));
		  if ( !qword_18F370148 )
		  {
		    v9 = (void (__fastcall *)(Transform *, Matrix4x4 *, Transform *, MethodInfo *))il2cpp_resolve_icall_1(
		                                                                                     "UnityEngine.Transform::get_localToW"
		                                                                                     "orldMatrix_Injected(UnityEngine.Matrix4x4&)");
		    if ( !v9 )
		    {
		      v78 = sub_1802EE1B8("UnityEngine.Transform::get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v78, 0LL);
		    }
		    qword_18F370148 = (__int64)v9;
		  }
		  v9(transform, &v112, transform, method);
		  if ( !mesh )
		    goto LABEL_37;
		  v114 = 0LL;
		  v10 = (void (__fastcall *)(Mesh *, Vector4 *))qword_18F36F840;
		  v113 = 0LL;
		  if ( !qword_18F36F840 )
		  {
		    v10 = (void (__fastcall *)(Mesh *, Vector4 *))il2cpp_resolve_icall_1("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		    if ( !v10 )
		    {
		      v79 = sub_1802EE1B8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		      sub_18007E1B0(v79, 0LL);
		    }
		    qword_18F36F840 = (__int64)v10;
		  }
		  v10(mesh, &v113);
		  v11 = (float)((float)((float)(v113.y * v112.m31) + (float)(v113.x * v112.m30)) + (float)(v113.z * v112.m32))
		      + v112.m33;
		  v116 = (float)((float)((float)((float)(v113.y * v112.m01) + (float)(v113.x * v112.m00)) + (float)(v113.z * v112.m02))
		               + v112.m03)
		       * (float)(1.0 / v11);
		  v106 = (float)((float)((float)((float)(v113.y * v112.m11) + (float)(v113.x * v112.m10)) + (float)(v113.z * v112.m12))
		               + v112.m13)
		       * (float)(1.0 / v11);
		  v107 = (float)((float)((float)((float)(v113.y * v112.m21) + (float)(v113.x * v112.m20)) + (float)(v113.z * v112.m22))
		               + v112.m23)
		       * (float)(1.0 / v11);
		  v12 = (void (__fastcall *)(Transform *, Vector4 *))qword_18F370110;
		  v102 = 0LL;
		  if ( !qword_18F370110 )
		  {
		    v12 = (void (__fastcall *)(Transform *, Vector4 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		    if ( !v12 )
		    {
		      v80 = sub_1802EE1B8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		      sub_18007E1B0(v80, 0LL);
		    }
		    qword_18F370110 = (__int64)v12;
		  }
		  v12(transform, &v102);
		  v104 = 0LL;
		  v105 = 0;
		  v13 = (void (__fastcall *)(Transform *, unsigned __int64 *))qword_18F370198;
		  if ( !qword_18F370198 )
		  {
		    v13 = (void (__fastcall *)(Transform *, unsigned __int64 *))il2cpp_resolve_icall_1(
		                                                                  "UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)");
		    if ( !v13 )
		    {
		      v81 = sub_1802EE1B8("UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v81, 0LL);
		    }
		    qword_18F370198 = (__int64)v13;
		  }
		  v13(transform, &v104);
		  v110 = v104;
		  v111 = v105;
		  v14 = (void (__fastcall *)(unsigned __int64 *, Vector4 *, unsigned __int64 *, Matrix4x4 *))qword_18F36FA58;
		  v109 = 0;
		  v108 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  memset(&v112, 0, sizeof(v112));
		  if ( !qword_18F36FA58 )
		  {
		    v14 = (void (__fastcall *)(unsigned __int64 *, Vector4 *, unsigned __int64 *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                                                                 "UnityEngine.Matrix4x4::"
		                                                                                                 "TRS_Injected(UnityEngin"
		                                                                                                 "e.Vector3&,UnityEngine."
		                                                                                                 "Quaternion&,UnityEngine"
		                                                                                                 ".Vector3&,UnityEngine.Matrix4x4&)");
		    if ( !v14 )
		    {
		      v82 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v82, 0LL);
		    }
		    qword_18F36FA58 = (__int64)v14;
		  }
		  v14(&v108, &v102, &v110, &v112);
		  v115 = v112;
		  Column = UnityEngine::Matrix4x4::GetColumn(&v102, &v115, 0, 0LL);
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v16 = *(__m128 *)Column;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_37;
		  if ( wrapperArray->max_length.size <= 1306 )
		    goto LABEL_16;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		    goto LABEL_37;
		  if ( LODWORD(v6->_0.namespaze) <= 0x51A )
		    goto LABEL_81;
		  if ( v6[27].vtable.Finalize.methodPtr )
		  {
		    v83 = IFix::WrappersManagerImpl::GetPatch(1306, 0LL);
		    LODWORD(v102.x) = v16.m128_i32[0];
		    LODWORD(v102.w) = _mm_shuffle_ps(v16, v16, 255).m128_u32[0];
		    LODWORD(v102.y) = _mm_shuffle_ps(v16, v16, 85).m128_u32[0];
		    LODWORD(v102.z) = _mm_shuffle_ps(v16, v16, 170).m128_u32[0];
		    if ( !v83 )
		      goto LABEL_37;
		    v84 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502((Vector3 *)&v101, v83, &v102, 0LL);
		    z = v84->z;
		    v85 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v84->x, (__m128)*(unsigned __int64 *)&v84->x, 85).m128_u64[0];
		    *(_QWORD *)&v101.x = *(_QWORD *)&v84->x;
		    v16.m128_i32[0] = LODWORD(v101.x);
		    v108 = v85;
		  }
		  else
		  {
		LABEL_16:
		    LODWORD(v108) = _mm_shuffle_ps(v16, v16, 85).m128_u32[0];
		    LODWORD(z) = _mm_shuffle_ps(v16, v16, 170).m128_u32[0];
		  }
		  v18 = UnityEngine::Matrix4x4::GetColumn(&v102, &v115, 1, 0LL);
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v19 = *(__m128 *)v18;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_37;
		  if ( wrapperArray->max_length.size <= 1306 )
		    goto LABEL_21;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		    goto LABEL_37;
		  if ( LODWORD(v6->_0.namespaze) <= 0x51A )
		    goto LABEL_81;
		  if ( v6[27].vtable.Finalize.methodPtr )
		  {
		    v86 = IFix::WrappersManagerImpl::GetPatch(1306, 0LL);
		    LODWORD(v102.x) = v19.m128_i32[0];
		    LODWORD(v102.w) = _mm_shuffle_ps(v19, v19, 255).m128_u32[0];
		    LODWORD(v102.y) = _mm_shuffle_ps(v19, v19, 85).m128_u32[0];
		    LODWORD(v102.z) = _mm_shuffle_ps(v19, v19, 170).m128_u32[0];
		    if ( !v86 )
		      goto LABEL_37;
		    v87 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502((Vector3 *)&v101, v86, &v102, 0LL);
		    v20 = v87->z;
		    v88 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v87->x, (__m128)*(unsigned __int64 *)&v87->x, 85).m128_u64[0];
		    *(_QWORD *)&v101.x = *(_QWORD *)&v87->x;
		    v19.m128_i32[0] = LODWORD(v101.x);
		    v110 = v88;
		  }
		  else
		  {
		LABEL_21:
		    LODWORD(v110) = _mm_shuffle_ps(v19, v19, 85).m128_u32[0];
		    LODWORD(v20) = _mm_shuffle_ps(v19, v19, 170).m128_u32[0];
		  }
		  v21 = UnityEngine::Matrix4x4::GetColumn(&v113, &v115, 2, 0LL);
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v22 = *(__m128 *)v21;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_37;
		  if ( wrapperArray->max_length.size > 1306 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( !v6 )
		      goto LABEL_37;
		    if ( LODWORD(v6->_0.namespaze) > 0x51A )
		    {
		      if ( !v6[27].vtable.Finalize.methodPtr )
		        goto LABEL_26;
		      v89 = IFix::WrappersManagerImpl::GetPatch(1306, 0LL);
		      LODWORD(v102.x) = v22.m128_i32[0];
		      LODWORD(v102.w) = _mm_shuffle_ps(v22, v22, 255).m128_u32[0];
		      LODWORD(v102.y) = _mm_shuffle_ps(v22, v22, 85).m128_u32[0];
		      LODWORD(v102.z) = _mm_shuffle_ps(v22, v22, 170).m128_u32[0];
		      if ( v89 )
		      {
		        v101 = v102;
		        v90 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502((Vector3 *)&v102, v89, &v101, 0LL);
		        v23 = v90->z;
		        v91 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v90->x, (__m128)*(unsigned __int64 *)&v90->x, 85).m128_u64[0];
		        *(_QWORD *)&v101.x = *(_QWORD *)&v90->x;
		        v22.m128_i32[0] = LODWORD(v101.x);
		        v104 = v91;
		        goto LABEL_27;
		      }
		LABEL_37:
		      sub_1800D8260(v6, wrapperArray);
		    }
		LABEL_81:
		    sub_1800D2AB0(v6, wrapperArray);
		  }
		LABEL_26:
		  LODWORD(v104) = _mm_shuffle_ps(v22, v22, 85).m128_u32[0];
		  LODWORD(v23) = _mm_shuffle_ps(v22, v22, 170).m128_u32[0];
		LABEL_27:
		  v24 = (void (__fastcall *)(Mesh *, Bounds *))qword_18F36F840;
		  memset(&v103, 0, sizeof(v103));
		  if ( !qword_18F36F840 )
		  {
		    v24 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_1("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		    if ( !v24 )
		    {
		      v92 = sub_1802EE1B8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		      sub_18007E1B0(v92, 0LL);
		    }
		    qword_18F36F840 = (__int64)v24;
		  }
		  v24(mesh, &v103);
		  *(_QWORD *)&v101.x = *(_QWORD *)&v103.m_Extents.x;
		  v101.z = v103.m_Extents.z;
		  v26 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v102, (Vector3 *)&v101, 2.0, v25);
		  v27 = *(_QWORD *)&v26->x;
		  v101.z = v26->z;
		  si128 = (__m128)_mm_load_si128((const __m128i *)&xmmword_18B9592D0);
		  *(_QWORD *)&v101.x = v27;
		  v29 = (void (__fastcall *)(Mesh *, Bounds *))qword_18F36F840;
		  memset(&v103, 0, sizeof(v103));
		  LODWORD(v30) = COERCE_UNSIGNED_INT(*(float *)&v27 * v16.m128_f32[0]) & si128.m128_i32[0];
		  if ( !qword_18F36F840 )
		  {
		    v29 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_1("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		    if ( !v29 )
		    {
		      v93 = sub_1802EE1B8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		      sub_18007E1B0(v93, 0LL);
		    }
		    qword_18F36F840 = (__int64)v29;
		  }
		  v29(mesh, &v103);
		  *(_QWORD *)&v101.x = *(_QWORD *)&v103.m_Extents.x;
		  v101.z = v103.m_Extents.z;
		  v32 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v102, (Vector3 *)&v101, 2.0, v31);
		  v33 = (__m128)*(unsigned __int64 *)&v32->x;
		  v101.z = v32->z;
		  *(_QWORD *)&v101.x = v33.m128_u64[0];
		  v34 = (void (__fastcall *)(Mesh *, Bounds *))qword_18F36F840;
		  memset(&v103, 0, sizeof(v103));
		  LODWORD(v35) = COERCE_UNSIGNED_INT(_mm_shuffle_ps(v33, v33, 85).m128_f32[0] * v19.m128_f32[0]) & si128.m128_i32[0];
		  if ( !qword_18F36F840 )
		  {
		    v34 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_1("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		    if ( !v34 )
		    {
		      v94 = sub_1802EE1B8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		      sub_18007E1B0(v94, 0LL);
		    }
		    qword_18F36F840 = (__int64)v34;
		  }
		  v34(mesh, &v103);
		  *(_QWORD *)&v101.x = *(_QWORD *)&v103.m_Extents.x;
		  v101.z = v103.m_Extents.z;
		  v37 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v102, (Vector3 *)&v101, 2.0, v36);
		  *(_QWORD *)&v101.x = *(_QWORD *)&v37->x;
		  z_low = (__m128)LODWORD(v37->z);
		  z_low.m128_f32[0] = z_low.m128_f32[0] * v22.m128_f32[0];
		  v39 = (void (__fastcall *)(Mesh *, Bounds *))qword_18F36F840;
		  memset(&v103, 0, sizeof(v103));
		  v40 = _mm_and_ps(z_low, si128);
		  v40.m128_f32[0] = v40.m128_f32[0] + (float)(v35 + v30);
		  if ( !qword_18F36F840 )
		  {
		    v39 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_1("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		    if ( !v39 )
		    {
		      v95 = sub_1802EE1B8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		      sub_18007E1B0(v95, 0LL);
		    }
		    qword_18F36F840 = (__int64)v39;
		  }
		  v39(mesh, &v103);
		  *(_QWORD *)&v101.x = *(_QWORD *)&v103.m_Extents.x;
		  v101.z = v103.m_Extents.z;
		  v42 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v102, (Vector3 *)&v101, 2.0, v41);
		  v43 = *(_QWORD *)&v42->x;
		  v101.z = v42->z;
		  *(_QWORD *)&v101.x = v43;
		  v44 = (void (__fastcall *)(Mesh *, Bounds *))qword_18F36F840;
		  memset(&v103, 0, sizeof(v103));
		  LODWORD(v45) = COERCE_UNSIGNED_INT(*(float *)&v43 * *(float *)&v108) & si128.m128_i32[0];
		  if ( !qword_18F36F840 )
		  {
		    v44 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_1("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		    if ( !v44 )
		    {
		      v96 = sub_1802EE1B8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		      sub_18007E1B0(v96, 0LL);
		    }
		    qword_18F36F840 = (__int64)v44;
		  }
		  v44(mesh, &v103);
		  *(_QWORD *)&v101.x = *(_QWORD *)&v103.m_Extents.x;
		  v101.z = v103.m_Extents.z;
		  v47 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v102, (Vector3 *)&v101, 2.0, v46);
		  v48 = (__m128)*(unsigned __int64 *)&v47->x;
		  v101.z = v47->z;
		  *(_QWORD *)&v101.x = v48.m128_u64[0];
		  v49 = (void (__fastcall *)(Mesh *, Bounds *))qword_18F36F840;
		  memset(&v103, 0, sizeof(v103));
		  LODWORD(v50) = COERCE_UNSIGNED_INT(_mm_shuffle_ps(v48, v48, 85).m128_f32[0] * *(float *)&v110) & si128.m128_i32[0];
		  if ( !qword_18F36F840 )
		  {
		    v49 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_1("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		    if ( !v49 )
		    {
		      v97 = sub_1802EE1B8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		      sub_18007E1B0(v97, 0LL);
		    }
		    qword_18F36F840 = (__int64)v49;
		  }
		  v49(mesh, &v103);
		  *(_QWORD *)&v101.x = *(_QWORD *)&v103.m_Extents.x;
		  v101.z = v103.m_Extents.z;
		  v52 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v102, (Vector3 *)&v101, 2.0, v51);
		  *(_QWORD *)&v101.x = *(_QWORD *)&v52->x;
		  v53 = (__m128)LODWORD(v52->z);
		  v53.m128_f32[0] = v53.m128_f32[0] * *(float *)&v104;
		  v54 = (void (__fastcall *)(Mesh *, Bounds *))qword_18F36F840;
		  memset(&v103, 0, sizeof(v103));
		  v55 = _mm_and_ps(v53, si128);
		  v55.m128_f32[0] = v55.m128_f32[0] + (float)(v50 + v45);
		  if ( !qword_18F36F840 )
		  {
		    v54 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_1("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		    if ( !v54 )
		    {
		      v98 = sub_1802EE1B8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		      sub_18007E1B0(v98, 0LL);
		    }
		    qword_18F36F840 = (__int64)v54;
		  }
		  v54(mesh, &v103);
		  *(_QWORD *)&v101.x = *(_QWORD *)&v103.m_Extents.x;
		  v101.z = v103.m_Extents.z;
		  v57 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v102, (Vector3 *)&v101, 2.0, v56);
		  v58 = *(_QWORD *)&v57->x;
		  v101.z = v57->z;
		  *(_QWORD *)&v101.x = v58;
		  v59 = (void (__fastcall *)(Mesh *, Bounds *))qword_18F36F840;
		  memset(&v103, 0, sizeof(v103));
		  LODWORD(v60) = COERCE_UNSIGNED_INT(*(float *)&v58 * z) & si128.m128_i32[0];
		  if ( !qword_18F36F840 )
		  {
		    v59 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_1("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		    if ( !v59 )
		    {
		      v99 = sub_1802EE1B8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		      sub_18007E1B0(v99, 0LL);
		    }
		    qword_18F36F840 = (__int64)v59;
		  }
		  v59(mesh, &v103);
		  *(_QWORD *)&v101.x = *(_QWORD *)&v103.m_Extents.x;
		  v101.z = v103.m_Extents.z;
		  v62 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v102, (Vector3 *)&v101, 2.0, v61);
		  v63 = (__m128)*(unsigned __int64 *)&v62->x;
		  v101.z = v62->z;
		  *(_QWORD *)&v101.x = v63.m128_u64[0];
		  v64 = (void (__fastcall *)(Mesh *, Bounds *))qword_18F36F840;
		  memset(&v103, 0, sizeof(v103));
		  LODWORD(v65) = COERCE_UNSIGNED_INT(_mm_shuffle_ps(v63, v63, 85).m128_f32[0] * v20) & si128.m128_i32[0];
		  if ( !qword_18F36F840 )
		  {
		    v64 = (void (__fastcall *)(Mesh *, Bounds *))il2cpp_resolve_icall_1("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		    if ( !v64 )
		    {
		      v100 = sub_1802EE1B8("UnityEngine.Mesh::get_bounds_Injected(UnityEngine.Bounds&)");
		      sub_18007E1B0(v100, 0LL);
		    }
		    qword_18F36F840 = (__int64)v64;
		  }
		  v64(mesh, &v103);
		  *(_QWORD *)&v101.x = *(_QWORD *)&v103.m_Extents.x;
		  v101.z = v103.m_Extents.z;
		  v67 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v102, (Vector3 *)&v101, 2.0, v66);
		  *(_QWORD *)&v101.x = *(_QWORD *)&v67->x;
		  v68 = v67->z * v23;
		  *(_QWORD *)&retstr->m_Extents.x = 0LL;
		  retstr->m_Extents.z = 0.0;
		  v69 = v107;
		  *(_QWORD *)&retstr->m_Center.x = _mm_unpacklo_ps((__m128)LODWORD(v116), (__m128)LODWORD(v106)).m128_u64[0];
		  v101.z = COERCE_FLOAT(LODWORD(v68) & si128.m128_i32[0]) + (float)(v65 + v60);
		  retstr->m_Center.z = v69;
		  *(_QWORD *)&v101.x = _mm_unpacklo_ps(v40, v55).m128_u64[0];
		  v71 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v102, (Vector3 *)&v101, 0.5, v70);
		  v72 = *(_QWORD *)&v71->x;
		  *(float *)&v71 = v71->z;
		  *(_QWORD *)&retstr->m_Extents.x = v72;
		  LODWORD(retstr->m_Extents.z) = (_DWORD)v71;
		  return retstr;
		}
		
		public void SetMeshFilterAndRendererVisibleInInspector(bool value) {} // 0x0000000189C7A0B4-0x0000000189C7A19C
		// Void SetMeshFilterAndRendererVisibleInInspector(Boolean)
		void HG::Rendering::Runtime::HGWaterRendererV2::SetMeshFilterAndRendererVisibleInInspector(
		        HGWaterRendererV2 *this,
		        bool value,
		        MethodInfo *method)
		{
		  BOOL v4; // edi
		  GameObject *gameObject; // rax
		  __int64 v6; // rdx
		  Object *v7; // rcx
		  GameObject *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *v10; // [rsp+20h] [rbp-18h] BYREF
		  Object *component; // [rsp+58h] [rbp+20h] BYREF
		
		  component = 0LL;
		  v10 = 0LL;
		  v4 = value;
		  if ( !IFix::WrappersManagerImpl::IsPatched(5396, 0LL) )
		  {
		    gameObject = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		    if ( !gameObject )
		      goto LABEL_11;
		    if ( UnityEngine::GameObject::TryGetComponent<System::Object>(
		           gameObject,
		           &component,
		           MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::MeshFilter>) )
		    {
		      v7 = component;
		      if ( !component )
		        goto LABEL_11;
		      UnityEngine::Object::set_hideFlags((Object_1 *)component, (HideFlags__Enum)(2 * !v4), 0LL);
		    }
		    v8 = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		    if ( v8 )
		    {
		      if ( !UnityEngine::GameObject::TryGetComponent<System::Object>(
		              v8,
		              &v10,
		              MethodInfo::UnityEngine::GameObject::TryGetComponent<UnityEngine::MeshRenderer>) )
		        return;
		      v7 = v10;
		      if ( v10 )
		      {
		        UnityEngine::Object::set_hideFlags((Object_1 *)v10, (HideFlags__Enum)(2 * !v4), 0LL);
		        return;
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5396, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, v4, 0LL);
		}
		
	}
}
