using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGStreamingVolume : MonoBehaviour // TypeDefIndex: 37548
	{
		// Fields
		public BoolParameter enableShadowCulling; // 0x18
		private Entity m_entity; // 0x20
		private HGStreamingVolumeTypeMask m_volumeTypeMask; // 0x28
	
		// Properties
		public static NativeArray<ComponentType> s_StreamingVolumeDefaultComponentTypes { get => default; } // 0x0000000189C6FBF0-0x0000000189C6FCB8 
		// NativeArray`1[UnityEngine.HyperGryph.ECS.ComponentType] get_s_StreamingVolumeDefaultComponentTypes()
		NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *HG::Rendering::Runtime::HGStreamingVolume::get_s_StreamingVolumeDefaultComponentTypes(
		        NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *__return_ptr retstr,
		        MethodInfo *method)
		{
		  MethodInfo *v3; // rdx
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *v4; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v8; // xmm0
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *result; // rax
		  NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ v10; // [rsp+20h] [rbp-28h] BYREF
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v11; // [rsp+30h] [rbp-18h] BYREF
		  ComponentType allocator; // [rsp+50h] [rbp+8h] BYREF
		
		  v10 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1231, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1231, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v4 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_473(&v11, Patch, 0LL);
		  }
		  else
		  {
		    LODWORD(allocator.value) = 2;
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList(
		      &v10,
		      1,
		      (AllocatorManager_AllocatorHandle)2,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
		    allocator.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGStreamingVolumeComponent>(
		                                  (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGStreamingVolumeComponent>,
		                                  v3);
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		      &v10,
		      &allocator,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		    v4 = (NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)sub_180367D74(&v11, &v10);
		  }
		  v8 = *v4;
		  result = retstr;
		  *retstr = v8;
		  return result;
		}
		
		public static NativeArray<ComponentType> s_CullingVolumeComponentTypes { get => default; } // 0x0000000189C6FB08-0x0000000189C6FBF0 
		// NativeArray`1[UnityEngine.HyperGryph.ECS.ComponentType] get_s_CullingVolumeComponentTypes()
		NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *HG::Rendering::Runtime::HGStreamingVolume::get_s_CullingVolumeComponentTypes(
		        NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *__return_ptr retstr,
		        MethodInfo *method)
		{
		  MethodInfo *v3; // rdx
		  MethodInfo *v4; // rdx
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *v5; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v9; // xmm0
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *result; // rax
		  NativeList_1_UnityEngine_HyperGryph_ECS_ComponentType_ v11; // [rsp+20h] [rbp-20h] BYREF
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v12; // [rsp+30h] [rbp-10h] BYREF
		  ComponentType value; // [rsp+50h] [rbp+10h] BYREF
		
		  v11 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1232, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1232, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_473(&v12, Patch, 0LL);
		  }
		  else
		  {
		    LODWORD(value.value) = 2;
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList(
		      &v11,
		      2,
		      (AllocatorManager_AllocatorHandle)2,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::NativeList);
		    value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGStreamingVolumeComponent>(
		                              (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGStreamingVolumeComponent>,
		                              v3);
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		      &v11,
		      &value,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		    value.value = (uint64_t)UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>(
		                              (ComponentType *)MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::GetComponentType<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>,
		                              v4);
		    Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add(
		      &v11,
		      &value,
		      MethodInfo::Unity::Collections::NativeList<UnityEngine::HyperGryph::ECS::ComponentType>::Add);
		    v5 = (NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *)sub_180367D74(&v12, &v11);
		  }
		  v9 = *v5;
		  result = retstr;
		  *retstr = v9;
		  return result;
		}
		
	
		// Constructors
		public HGStreamingVolume() {} // 0x0000000189C6FAA4-0x0000000189C6FB08
		// HGStreamingVolume()
		void HG::Rendering::Runtime::HGStreamingVolume::HGStreamingVolume(HGStreamingVolume *this, MethodInfo *method)
		{
		  BoolParameter *v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // [rsp+20h] [rbp-8h]
		
		  v3 = (BoolParameter *)sub_18002C620(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  v3->fields._.m_Value = 1;
		  v3->fields._._.overrideState = 1;
		  this->fields.enableShadowCulling = v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.enableShadowCulling, v4, v6, v7, v8);
		  sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		  this->fields.m_entity = 0LL;
		  RootMotion::Singleton<System::Object>::Singleton((Singleton_1_System_Object__1 *)this, 0LL);
		}
		
	
		// Methods
		private void OnEnable() {} // 0x0000000189C6F758-0x0000000189C6F7A8
		// Void OnEnable()
		void HG::Rendering::Runtime::HGStreamingVolume::OnEnable(HGStreamingVolume *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1233, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1233, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGStreamingVolume::AddEntity(this, 0LL);
		  }
		}
		
		private void OnDisable() {} // 0x0000000189C6F708-0x0000000189C6F758
		// Void OnDisable()
		void HG::Rendering::Runtime::HGStreamingVolume::OnDisable(HGStreamingVolume *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1236, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1236, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGStreamingVolume::RemoveEntity(this, 0LL);
		  }
		}
		
		private void Update() {} // 0x0000000189C6FA54-0x0000000189C6FAA4
		// Void Update()
		void HG::Rendering::Runtime::HGStreamingVolume::Update(HGStreamingVolume *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1238, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1238, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGStreamingVolume::TransformChanged(this, 0LL);
		  }
		}
		
		private void TransformChanged() {} // 0x0000000189C6F850-0x0000000189C6F8DC
		// Void TransformChanged()
		void HG::Rendering::Runtime::HGStreamingVolume::TransformChanged(HGStreamingVolume *this, MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Transform *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1239, 0LL) )
		  {
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( transform )
		    {
		      if ( !UnityEngine::Transform::get_hasChanged(transform, 0LL) )
		        return;
		      v6 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( v6 )
		      {
		        UnityEngine::Transform::set_hasChanged(v6, 0, 0LL);
		        HG::Rendering::Runtime::HGStreamingVolume::UpdateEntity(this, 0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1239, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void AddEntity() {} // 0x0000000189C6F618-0x0000000189C6F708
		// Void AddEntity()
		void HG::Rendering::Runtime::HGStreamingVolume::AddEntity(HGStreamingVolume *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  EntityManager v5; // xmm0
		  BoolParameter *enableShadowCulling; // rax
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ *s_CullingVolumeComponentTypes; // rax
		  EntityType v8; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  EntityManager v10; // [rsp+20h] [rbp-20h] BYREF
		  NativeArray_1_UnityEngine_HyperGryph_ECS_ComponentType_ v11; // [rsp+30h] [rbp-10h] BYREF
		
		  v10 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1234, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1234, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_11:
		    sub_1800D8260(v4, v3);
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		  if ( this->fields.m_entity )
		    return;
		  v5 = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager((EntityManager *)&v11, 0LL);
		  enableShadowCulling = this->fields.enableShadowCulling;
		  v10 = v5;
		  if ( !enableShadowCulling )
		    goto LABEL_11;
		  if ( enableShadowCulling->fields._._.overrideState )
		    this->fields.m_volumeTypeMask |= 1u;
		  if ( this->fields.m_volumeTypeMask == 1 )
		    s_CullingVolumeComponentTypes = HG::Rendering::Runtime::HGStreamingVolume::get_s_CullingVolumeComponentTypes(
		                                      &v11,
		                                      0LL);
		  else
		    s_CullingVolumeComponentTypes = HG::Rendering::Runtime::HGStreamingVolume::get_s_StreamingVolumeDefaultComponentTypes(
		                                      &v11,
		                                      0LL);
		  v11 = *s_CullingVolumeComponentTypes;
		  v8.id = UnityEngine::HyperGryph::ECS::EntityManager::GetOrRegisterEntityType(&v10, &v11, 0LL).id;
		  this->fields.m_entity = UnityEngine::HyperGryph::ECS::EntityManager::CreateEntity(&v10, v8, 0LL);
		  HG::Rendering::Runtime::HGStreamingVolume::UpdateEntity(this, 0LL);
		}
		
		private void RemoveEntity() {} // 0x0000000189C6F7A8-0x0000000189C6F850
		// Void RemoveEntity()
		void HG::Rendering::Runtime::HGStreamingVolume::RemoveEntity(HGStreamingVolume *this, MethodInfo *method)
		{
		  EntityManager *RendererEntityManager; // rax
		  Entity_1 m_entity; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  EntityManager v8; // [rsp+20h] [rbp-28h] BYREF
		  EntityManager v9; // [rsp+30h] [rbp-18h] BYREF
		
		  v8 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1237, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1237, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		    if ( this->fields.m_entity )
		    {
		      RendererEntityManager = UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v9, 0LL);
		      m_entity = this->fields.m_entity;
		      v8 = *RendererEntityManager;
		      UnityEngine::HyperGryph::ECS::EntityManager::DestroyEntity(&v8, m_entity, 0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		      this->fields.m_entity.globalIndex = 0;
		      this->fields.m_entity.version = 0;
		      this->fields.m_volumeTypeMask = 0;
		    }
		  }
		}
		
		private void UpdateEntity() {} // 0x0000000189C6F8DC-0x0000000189C6FA54
		// Void UpdateEntity()
		void HG::Rendering::Runtime::HGStreamingVolume::UpdateEntity(HGStreamingVolume *this, MethodInfo *method)
		{
		  EntityManager *RendererEntityManager; // rax
		  Transform *transform; // rax
		  BoolParameter *enableShadowCulling; // rdx
		  __int64 v6; // rcx
		  Vector3 *position; // rax
		  __int64 v8; // xmm0_8
		  Transform *v9; // rax
		  Vector3 *localScale; // rax
		  __int64 v11; // xmm0_8
		  Transform *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Quaternion v14; // [rsp+20h] [rbp-50h] BYREF
		  EntityManager v15; // [rsp+30h] [rbp-40h] BYREF
		  HGStreamingVolumeComponent t; // [rsp+40h] [rbp-30h] BYREF
		  HGCullingParameterComponent v17; // [rsp+90h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1235, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		    if ( !*(_QWORD *)&this->fields.m_entity )
		      return;
		    RendererEntityManager = UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(&v15, 0LL);
		    memset(&t, 0, sizeof(t));
		    t.isEnable = 1;
		    v15 = *RendererEntityManager;
		    transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		    if ( transform )
		    {
		      position = UnityEngine::Transform::get_position((Vector3 *)&v14, transform, 0LL);
		      v8 = *(_QWORD *)&position->x;
		      *(float *)&position = position->z;
		      *(_QWORD *)&t.center.x = v8;
		      LODWORD(t.center.z) = (_DWORD)position;
		      v9 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( v9 )
		      {
		        localScale = UnityEngine::Transform::get_localScale((Vector3 *)&v14, v9, 0LL);
		        v11 = *(_QWORD *)&localScale->x;
		        *(float *)&localScale = localScale->z;
		        *(_QWORD *)&t.size.x = v11;
		        LODWORD(t.size.z) = (_DWORD)localScale;
		        v12 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		        if ( v12 )
		        {
		          t.rotation = *UnityEngine::Transform::get_rotation(&v14, v12, 0LL);
		          UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGStreamingVolumeComponent>(
		            &v15,
		            &this->fields.m_entity,
		            &t,
		            MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGStreamingVolumeComponent>);
		          if ( (this->fields.m_volumeTypeMask & 1) == 0 )
		            return;
		          enableShadowCulling = this->fields.enableShadowCulling;
		          if ( enableShadowCulling )
		          {
		            v17.enableShadowCulling = sub_180006280(10LL, enableShadowCulling);
		            UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>(
		              &v15,
		              &this->fields.m_entity,
		              &v17,
		              MethodInfo::UnityEngine::HyperGryph::ECS::EntityManager::SetComponent<UnityEngine::HyperGryph::ECS::HGCullingParameterComponent>);
		            return;
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v6, enableShadowCulling);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1235, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
