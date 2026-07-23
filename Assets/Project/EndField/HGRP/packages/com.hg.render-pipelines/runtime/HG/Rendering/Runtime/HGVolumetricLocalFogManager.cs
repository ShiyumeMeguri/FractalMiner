using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGVolumetricLocalFogManager // TypeDefIndex: 37665
	{
		// Fields
		private static readonly Lazy<HGVolumetricLocalFogManager> s_instance; // 0x00
		private readonly BidirectionalDictionary<HGVolumetricLocalFog, int> m_localFogBiDict; // 0x10
		private readonly List<HGVolumetricLocalFog> m_localFogList; // 0x18
		private SPMDCullingNativeInout m_cullingNativeInout; // 0x20
	
		// Properties
		public static HGVolumetricLocalFogManager instance { get => default; } // 0x0000000189CEFD10-0x0000000189CEFD7C 
		// HGVolumetricLocalFogManager get_instance()
		HGVolumetricLocalFogManager *HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_instance(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  Lazy_1_HG_Rendering_Runtime_HGVolumetricLocalFogManager_ *s_instance; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1549, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
		    s_instance = TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager->static_fields->s_instance;
		    if ( s_instance )
		      return (HGVolumetricLocalFogManager *)System::Lazy<System::Object>::get_Value(
		                                              (Lazy_1_Object_ *)s_instance,
		                                              MethodInfo::System::Lazy<HG::Rendering::Runtime::HGVolumetricLocalFogManager>::get_Value);
		LABEL_5:
		    sub_1800D8260(s_instance, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1549, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_638(Patch, 0LL);
		}
		
		public List<HGVolumetricLocalFog> volumetricLocalFogList { get => default; } // 0x0000000189CEFD7C-0x0000000189CEFDCC 
		// List`1[HG.Rendering.Runtime.HGVolumetricLocalFog] get_volumetricLocalFogList()
		List_1_HG_Rendering_Runtime_HGVolumetricLocalFog_ *HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_volumetricLocalFogList(
		        HGVolumetricLocalFogManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1550, 0LL) )
		    return this->fields.m_localFogList;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1550, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_639(Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		public class SPMDCullingNativeInout : IDisposable // TypeDefIndex: 37663
		{
			// Fields
			public NativeList<float> centerXs; // 0x10
			public NativeList<float> centerYs; // 0x20
			public NativeList<float> centerZs; // 0x30
			public NativeList<float> extentXs; // 0x40
			public NativeList<float> extentYs; // 0x50
			public NativeList<float> extentZs; // 0x60
			public NativeList<int> visibility; // 0x70
	
			// Constructors
			public SPMDCullingNativeInout() {} // 0x0000000189CF0CA4-0x0000000189CF0DFC
			// HGVolumetricLocalFogManager+SPMDCullingNativeInout()
			void HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::SPMDCullingNativeInout(
			        HGVolumetricLocalFogManager_SPMDCullingNativeInout *this,
			        MethodInfo *method)
			{
			  NativeList_1_System_Single_ v3; // [rsp+20h] [rbp-10h] BYREF
			
			  v3 = 0LL;
			  Unity::Collections::NativeList<float>::NativeList(
			    &v3,
			    (AllocatorManager_AllocatorHandle)4,
			    MethodInfo::Unity::Collections::NativeList<float>::NativeList);
			  this->fields.centerXs = v3;
			  v3 = 0LL;
			  Unity::Collections::NativeList<float>::NativeList(
			    &v3,
			    (AllocatorManager_AllocatorHandle)4,
			    MethodInfo::Unity::Collections::NativeList<float>::NativeList);
			  this->fields.centerYs = v3;
			  v3 = 0LL;
			  Unity::Collections::NativeList<float>::NativeList(
			    &v3,
			    (AllocatorManager_AllocatorHandle)4,
			    MethodInfo::Unity::Collections::NativeList<float>::NativeList);
			  this->fields.centerZs = v3;
			  v3 = 0LL;
			  Unity::Collections::NativeList<float>::NativeList(
			    &v3,
			    (AllocatorManager_AllocatorHandle)4,
			    MethodInfo::Unity::Collections::NativeList<float>::NativeList);
			  this->fields.extentXs = v3;
			  v3 = 0LL;
			  Unity::Collections::NativeList<float>::NativeList(
			    &v3,
			    (AllocatorManager_AllocatorHandle)4,
			    MethodInfo::Unity::Collections::NativeList<float>::NativeList);
			  this->fields.extentYs = v3;
			  v3 = 0LL;
			  Unity::Collections::NativeList<float>::NativeList(
			    &v3,
			    (AllocatorManager_AllocatorHandle)4,
			    MethodInfo::Unity::Collections::NativeList<float>::NativeList);
			  this->fields.extentZs = v3;
			  v3 = 0LL;
			  Unity::Collections::NativeList<int>::NativeList(
			    (NativeList_1_System_Int32_ *)&v3,
			    (AllocatorManager_AllocatorHandle)4,
			    MethodInfo::Unity::Collections::NativeList<int>::NativeList);
			  this->fields.visibility = (NativeList_1_System_Int32_)v3;
			}
			
	
			// Methods
			public void Dispose() {} // 0x0000000189CF0714-0x0000000189CF07CC
			// Void Dispose()
			void HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::Dispose(
			        HGVolumetricLocalFogManager_SPMDCullingNativeInout *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1569, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1569, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			    Unity::Collections::NativeList<float>::Dispose(
			      &this->fields.centerXs,
			      MethodInfo::Unity::Collections::NativeList<float>::Dispose);
			    Unity::Collections::NativeList<float>::Dispose(
			      &this->fields.centerYs,
			      MethodInfo::Unity::Collections::NativeList<float>::Dispose);
			    Unity::Collections::NativeList<float>::Dispose(
			      &this->fields.centerZs,
			      MethodInfo::Unity::Collections::NativeList<float>::Dispose);
			    Unity::Collections::NativeList<float>::Dispose(
			      &this->fields.extentXs,
			      MethodInfo::Unity::Collections::NativeList<float>::Dispose);
			    Unity::Collections::NativeList<float>::Dispose(
			      &this->fields.extentYs,
			      MethodInfo::Unity::Collections::NativeList<float>::Dispose);
			    Unity::Collections::NativeList<float>::Dispose(
			      &this->fields.extentZs,
			      MethodInfo::Unity::Collections::NativeList<float>::Dispose);
			    Unity::Collections::NativeList<int>::Dispose(
			      &this->fields.visibility,
			      MethodInfo::Unity::Collections::NativeList<int>::Dispose);
			  }
			}
			
			public void Add(Bounds bounds) {} // 0x0000000189CF05AC-0x0000000189CF0714
			// Void Add(Bounds)
			void HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::Add(
			        HGVolumetricLocalFogManager_SPMDCullingNativeInout *this,
			        Bounds *bounds,
			        MethodInfo *method)
			{
			  float z; // eax
			  float v6; // eax
			  float v7; // eax
			  float v8; // eax
			  float v9; // eax
			  float v10; // eax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v12; // rdx
			  __int64 v13; // rcx
			  __int64 v14; // xmm1_8
			  Bounds value; // [rsp+20h] [rbp-20h] BYREF
			  int32_t v16; // [rsp+68h] [rbp+28h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1565, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1565, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v13, v12);
			    v14 = *(_QWORD *)&bounds->m_Extents.y;
			    *(_OWORD *)&value.m_Center.x = *(_OWORD *)&bounds->m_Center.x;
			    *(_QWORD *)&value.m_Extents.y = v14;
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_643(Patch, (Object *)this, &value, 0LL);
			  }
			  else
			  {
			    z = bounds->m_Center.z;
			    *(_QWORD *)&value.m_Center.x = *(_QWORD *)&bounds->m_Center.x;
			    value.m_Center.z = z;
			    Unity::Collections::NativeList<float>::Add(
			      &this->fields.centerXs,
			      &value.m_Center.x,
			      MethodInfo::Unity::Collections::NativeList<float>::Add);
			    v6 = bounds->m_Center.z;
			    *(_QWORD *)&value.m_Center.x = *(_QWORD *)&bounds->m_Center.x;
			    value.m_Center.z = v6;
			    Unity::Collections::NativeList<float>::Add(
			      &this->fields.centerYs,
			      &value.m_Center.y,
			      MethodInfo::Unity::Collections::NativeList<float>::Add);
			    v7 = bounds->m_Center.z;
			    *(_QWORD *)&value.m_Center.x = *(_QWORD *)&bounds->m_Center.x;
			    value.m_Center.z = v7;
			    Unity::Collections::NativeList<float>::Add(
			      &this->fields.centerZs,
			      &value.m_Center.z,
			      MethodInfo::Unity::Collections::NativeList<float>::Add);
			    v8 = bounds->m_Extents.z;
			    *(_QWORD *)&value.m_Center.x = *(_QWORD *)&bounds->m_Extents.x;
			    value.m_Center.z = v8;
			    Unity::Collections::NativeList<float>::Add(
			      &this->fields.extentXs,
			      &value.m_Center.x,
			      MethodInfo::Unity::Collections::NativeList<float>::Add);
			    v9 = bounds->m_Extents.z;
			    *(_QWORD *)&value.m_Center.x = *(_QWORD *)&bounds->m_Extents.x;
			    value.m_Center.z = v9;
			    Unity::Collections::NativeList<float>::Add(
			      &this->fields.extentYs,
			      &value.m_Center.y,
			      MethodInfo::Unity::Collections::NativeList<float>::Add);
			    v10 = bounds->m_Extents.z;
			    *(_QWORD *)&value.m_Center.x = *(_QWORD *)&bounds->m_Extents.x;
			    value.m_Center.z = v10;
			    Unity::Collections::NativeList<float>::Add(
			      &this->fields.extentZs,
			      &value.m_Center.z,
			      MethodInfo::Unity::Collections::NativeList<float>::Add);
			    v16 = 0;
			    Unity::Collections::NativeList<int>::Add(
			      &this->fields.visibility,
			      &v16,
			      MethodInfo::Unity::Collections::NativeList<int>::Add);
			  }
			}
			
			public void RemoveAtSwapBack(int index) {} // 0x0000000189CF07CC-0x0000000189CF08A4
			// Void RemoveAtSwapBack(Int32)
			void HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::RemoveAtSwapBack(
			        HGVolumetricLocalFogManager_SPMDCullingNativeInout *this,
			        int32_t index,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1568, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1568, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, index, 0LL);
			  }
			  else
			  {
			    Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
			      (NativeList_1_System_UInt32_ *)&this->fields,
			      index,
			      MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
			    Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
			      (NativeList_1_System_UInt32_ *)&this->fields.centerYs,
			      index,
			      MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
			    Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
			      (NativeList_1_System_UInt32_ *)&this->fields.centerZs,
			      index,
			      MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
			    Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
			      (NativeList_1_System_UInt32_ *)&this->fields.extentXs,
			      index,
			      MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
			    Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
			      (NativeList_1_System_UInt32_ *)&this->fields.extentYs,
			      index,
			      MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
			    Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
			      (NativeList_1_System_UInt32_ *)&this->fields.extentZs,
			      index,
			      MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
			    Unity::Collections::NativeList<int>::RemoveAtSwapBack(
			      &this->fields.visibility,
			      index,
			      MethodInfo::Unity::Collections::NativeList<int>::RemoveAtSwapBack);
			  }
			}
			
			public void UpdateLocalFogTransform(List<HGVolumetricLocalFog> localFogList) {} // 0x0000000189CF08A4-0x0000000189CF0AB8
			// Void UpdateLocalFogTransform(List`1[HG.Rendering.Runtime.HGVolumetricLocalFog])
			void HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::UpdateLocalFogTransform(
			        HGVolumetricLocalFogManager_SPMDCullingNativeInout *this,
			        List_1_HG_Rendering_Runtime_HGVolumetricLocalFog_ *localFogList,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  int32_t v7; // ebx
			  Object *Item; // rax
			  Component *v9; // rdi
			  Transform *transform; // rax
			  Transform *v11; // rax
			  Transform *v12; // rax
			  Vector3 *position; // rax
			  __int64 v14; // xmm6_8
			  float z; // r15d
			  Transform *v16; // rax
			  Vector3 *lossyScale; // rax
			  __int64 v18; // xmm0_8
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  Vector3 v20; // [rsp+28h] [rbp-29h] BYREF
			  Vector3 v21; // [rsp+38h] [rbp-19h] BYREF
			  Vector3 v22; // [rsp+48h] [rbp-9h] BYREF
			  Vector3 v23; // [rsp+58h] [rbp+7h] BYREF
			  Bounds value[2]; // [rsp+68h] [rbp+17h] BYREF
			
			  memset(value, 0, 24);
			  if ( IFix::WrappersManagerImpl::IsPatched(1552, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1552, 0LL);
			    if ( Patch )
			    {
			      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			        (ILFixDynamicMethodWrapper_39 *)Patch,
			        (Object *)this,
			        (Object *)localFogList,
			        0LL);
			      return;
			    }
			LABEL_13:
			    sub_1800D8260(v6, v5);
			  }
			  v7 = 0;
			  if ( !localFogList )
			    goto LABEL_13;
			  while ( v7 < localFogList->fields._size )
			  {
			    Item = System::Collections::Generic::List<System::Object>::get_Item(
			             (List_1_System_Object_ *)localFogList,
			             v7,
			             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::get_Item);
			    v9 = (Component *)Item;
			    if ( !Item )
			      goto LABEL_13;
			    transform = UnityEngine::Component::get_transform((Component *)Item, 0LL);
			    if ( !transform )
			      goto LABEL_13;
			    if ( UnityEngine::Transform::get_hasChanged(transform, 0LL) )
			    {
			      v11 = UnityEngine::Component::get_transform(v9, 0LL);
			      if ( !v11 )
			        goto LABEL_13;
			      UnityEngine::Transform::set_hasChanged(v11, 0, 0LL);
			      v12 = UnityEngine::Component::get_transform(v9, 0LL);
			      if ( !v12 )
			        goto LABEL_13;
			      position = UnityEngine::Transform::get_position(&v22, v12, 0LL);
			      v14 = *(_QWORD *)&position->x;
			      z = position->z;
			      v16 = UnityEngine::Component::get_transform(v9, 0LL);
			      if ( !v16 )
			        goto LABEL_13;
			      lossyScale = UnityEngine::Transform::get_lossyScale(&v23, v16, 0LL);
			      *(_QWORD *)&v21.x = v14;
			      v21.z = z;
			      v18 = *(_QWORD *)&lossyScale->x;
			      *(float *)&lossyScale = lossyScale->z;
			      *(_QWORD *)&v20.x = v18;
			      LODWORD(v20.z) = (_DWORD)lossyScale;
			      UnityEngine::Bounds::Bounds(value, &v21, &v20, 0LL);
			      Unity::Collections::NativeList<float>::set_Item(
			        &this->fields.centerXs,
			        v7,
			        value[0].m_Center.x,
			        MethodInfo::Unity::Collections::NativeList<float>::set_Item);
			      Unity::Collections::NativeList<float>::set_Item(
			        &this->fields.centerYs,
			        v7,
			        value[0].m_Center.y,
			        MethodInfo::Unity::Collections::NativeList<float>::set_Item);
			      Unity::Collections::NativeList<float>::set_Item(
			        &this->fields.centerZs,
			        v7,
			        value[0].m_Center.z,
			        MethodInfo::Unity::Collections::NativeList<float>::set_Item);
			      Unity::Collections::NativeList<float>::set_Item(
			        &this->fields.extentXs,
			        v7,
			        value[0].m_Extents.x,
			        MethodInfo::Unity::Collections::NativeList<float>::set_Item);
			      Unity::Collections::NativeList<float>::set_Item(
			        &this->fields.extentYs,
			        v7,
			        value[0].m_Extents.y,
			        MethodInfo::Unity::Collections::NativeList<float>::set_Item);
			      Unity::Collections::NativeList<float>::set_Item(
			        &this->fields.extentZs,
			        v7,
			        value[0].m_Extents.z,
			        MethodInfo::Unity::Collections::NativeList<float>::set_Item);
			    }
			    ++v7;
			  }
			}
			
			public NativeList<int> VolumetricLocalFogCulling(Matrix4x4 cullingMatrix, int cameraGuid) => default; // 0x0000000189CF0AB8-0x0000000189CF0CA4
			// NativeList`1[System.Int32] VolumetricLocalFogCulling(Matrix4x4, Int32)
			NativeList_1_System_Int32_ *HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::VolumetricLocalFogCulling(
			        NativeList_1_System_Int32_ *__return_ptr retstr,
			        HGVolumetricLocalFogManager_SPMDCullingNativeInout *this,
			        Matrix4x4 *cullingMatrix,
			        int32_t cameraGuid,
			        MethodInfo *method)
			{
			  __int128 v9; // xmm1
			  __int128 v10; // xmm0
			  __int128 v11; // xmm1
			  NativeList_1_System_Int32_ visibility; // xmm0
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v14; // rdx
			  __int64 v15; // rcx
			  __int128 v16; // xmm1
			  __int128 v17; // xmm0
			  __int128 v18; // xmm1
			  NativeList_1_System_Int32_ *result; // rax
			  NativeArray_1_System_Single_ v20; // [rsp+58h] [rbp-61h] BYREF
			  NativeArray_1_System_Int32_ v21; // [rsp+68h] [rbp-51h] BYREF
			  NativeArray_1_System_Single_ v22; // [rsp+78h] [rbp-41h] BYREF
			  NativeArray_1_System_Single_ v23; // [rsp+88h] [rbp-31h] BYREF
			  NativeArray_1_System_Single_ v24; // [rsp+98h] [rbp-21h] BYREF
			  NativeArray_1_System_Single_ v25; // [rsp+A8h] [rbp-11h] BYREF
			  NativeArray_1_System_Single_ v26; // [rsp+B8h] [rbp-1h] BYREF
			  Matrix4x4 v27; // [rsp+C8h] [rbp+Fh] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1553, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1553, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v15, v14);
			    v16 = *(_OWORD *)&cullingMatrix->m01;
			    *(_OWORD *)&v27.m00 = *(_OWORD *)&cullingMatrix->m00;
			    v17 = *(_OWORD *)&cullingMatrix->m02;
			    *(_OWORD *)&v27.m01 = v16;
			    v18 = *(_OWORD *)&cullingMatrix->m03;
			    *(_OWORD *)&v27.m02 = v17;
			    *(_OWORD *)&v27.m03 = v18;
			    visibility = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_640(
			                    (NativeList_1_System_Int32_ *)&v20,
			                    Patch,
			                    (Object *)this,
			                    &v27,
			                    cameraGuid,
			                    0LL);
			  }
			  else
			  {
			    Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
			      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v20,
			      (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&this->fields,
			      MethodInfo::Unity::Collections::NativeList<float>::AsArray);
			    Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
			      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v26,
			      (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&this->fields.centerYs,
			      MethodInfo::Unity::Collections::NativeList<float>::AsArray);
			    Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
			      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v25,
			      (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&this->fields.centerZs,
			      MethodInfo::Unity::Collections::NativeList<float>::AsArray);
			    Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
			      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v24,
			      (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&this->fields.extentXs,
			      MethodInfo::Unity::Collections::NativeList<float>::AsArray);
			    Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
			      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v23,
			      (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&this->fields.extentYs,
			      MethodInfo::Unity::Collections::NativeList<float>::AsArray);
			    Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
			      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v22,
			      (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&this->fields.extentZs,
			      MethodInfo::Unity::Collections::NativeList<float>::AsArray);
			    Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::AsArray(
			      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v21,
			      (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&this->fields.visibility,
			      MethodInfo::Unity::Collections::NativeList<int>::AsArray);
			    v9 = *(_OWORD *)&cullingMatrix->m00;
			    *(_OWORD *)&v27.m01 = *(_OWORD *)&cullingMatrix->m01;
			    v10 = *(_OWORD *)&cullingMatrix->m03;
			    *(_OWORD *)&v27.m00 = v9;
			    v11 = *(_OWORD *)&cullingMatrix->m02;
			    *(_OWORD *)&v27.m03 = v10;
			    *(_OWORD *)&v27.m02 = v11;
			    UnityEngine::GeometryUtility::SPMDCullAABB(&v27, &v20, &v26, &v25, &v24, &v23, &v22, &v21, 0LL);
			    visibility = this->fields.visibility;
			  }
			  result = retstr;
			  *retstr = visibility;
			  return result;
			}
			
		}
	
		// Constructors
		public HGVolumetricLocalFogManager() {} // 0x0000000189CEFC90-0x0000000189CEFD10
		// HGVolumetricLocalFogManager()
		void HG::Rendering::Runtime::HGVolumetricLocalFogManager::HGVolumetricLocalFogManager(
		        HGVolumetricLocalFogManager *this,
		        MethodInfo *method)
		{
		  BidirectionalDictionary_2_System_Object_System_Int32_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  BidirectionalDictionary_2_HGVolumetricLocalFog_System_Int32_ *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v10; // rax
		  List_1_HG_Rendering_Runtime_HGVolumetricLocalFog_ *v11; // rdi
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+50h] [rbp+28h]
		
		  v3 = (BidirectionalDictionary_2_System_Object_System_Int32_ *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>);
		  v6 = (BidirectionalDictionary_2_HGVolumetricLocalFog_System_Int32_ *)v3;
		  if ( !v3
		    || (HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::BidirectionalDictionary(
		          v3,
		          MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::BidirectionalDictionary),
		        this->fields.m_localFogBiDict = v6,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v15),
		        v10 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>),
		        (v11 = (List_1_HG_Rendering_Runtime_HGVolumetricLocalFog_ *)v10) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::List);
		  this->fields.m_localFogList = v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_localFogList, v12, v13, v14, v16);
		}
		
		static HGVolumetricLocalFogManager() {} // 0x0000000189CEFBE4-0x0000000189CEFC90
		// HGVolumetricLocalFogManager()
		void HG::Rendering::Runtime::HGVolumetricLocalFogManager::cctor(MethodInfo *method)
		{
		  Object *v1; // rdi
		  Func_1_Object_ *v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Func_1_Object_ *v5; // rbx
		  Lazy_1_Object_ *v6; // rax
		  HGRuntimeGrassQuery_Node__Class *v7; // rdi
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  MethodInfo *v11; // [rsp+50h] [rbp+28h]
		
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager::__c);
		  v1 = (Object *)TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager::__c->static_fields->__9;
		  v2 = (Func_1_Object_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::HGVolumetricLocalFogManager>);
		  v5 = v2;
		  if ( !v2
		    || (System::Func<System::Object>::Func(
		          v2,
		          v1,
		          MethodInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager::__c::__cctor_b__13_0,
		          0LL),
		        v6 = (Lazy_1_Object_ *)sub_18002C620(TypeInfo::System::Lazy<HG::Rendering::Runtime::HGVolumetricLocalFogManager>),
		        (v7 = (HGRuntimeGrassQuery_Node__Class *)v6) == 0LL) )
		  {
		    sub_1800D8260(v4, v3);
		  }
		  System::Lazy<System::Object>::Lazy(
		    v6,
		    v5,
		    MethodInfo::System::Lazy<HG::Rendering::Runtime::HGVolumetricLocalFogManager>::Lazy);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager->static_fields;
		  static_fields->klass = v7;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager->static_fields,
		    static_fields,
		    v9,
		    v10,
		    v11);
		}
		
	
		// Methods
		public void AddVolumetricLocalFog(HGVolumetricLocalFog localFog) {} // 0x0000000189CEF724-0x0000000189CEF900
		// Void AddVolumetricLocalFog(HGVolumetricLocalFog)
		void HG::Rendering::Runtime::HGVolumetricLocalFogManager::AddVolumetricLocalFog(
		        HGVolumetricLocalFogManager *this,
		        HGVolumetricLocalFog *localFog,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  BidirectionalDictionary_2_System_Object_System_Int32_ *m_localFogBiDict; // rcx
		  HGVolumetricLocalFogManager_SPMDCullingNativeInout *v7; // rax
		  HGVolumetricLocalFogManager_SPMDCullingNativeInout *v8; // rsi
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  int32_t Count; // esi
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  float z; // r14d
		  Transform *v16; // rax
		  Vector3 *lossyScale; // rax
		  __int64 v18; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v20; // [rsp+20h] [rbp-50h] BYREF
		  Bounds v21; // [rsp+30h] [rbp-40h] BYREF
		  Bounds v22; // [rsp+50h] [rbp-20h] BYREF
		  __int64 value; // [rsp+A8h] [rbp+38h] BYREF
		
		  LODWORD(value) = 0;
		  memset(&v22, 0, sizeof(v22));
		  if ( !IFix::WrappersManagerImpl::IsPatched(1564, 0LL) )
		  {
		    m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_localFogBiDict;
		    if ( !m_localFogBiDict )
		      goto LABEL_16;
		    if ( HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::TryGetValueByKey(
		           m_localFogBiDict,
		           (Object *)localFog,
		           (int32_t *)&value,
		           MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::TryGetValueByKey) )
		    {
		      return;
		    }
		    if ( !this->fields.m_cullingNativeInout )
		    {
		      v7 = (HGVolumetricLocalFogManager_SPMDCullingNativeInout *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout);
		      v8 = v7;
		      if ( !v7 )
		        goto LABEL_16;
		      HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::SPMDCullingNativeInout(v7, 0LL);
		      this->fields.m_cullingNativeInout = v8;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)&this->fields.m_cullingNativeInout,
		        v9,
		        v10,
		        v11,
		        *(MethodInfo **)&v20.x);
		    }
		    m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_localFogBiDict;
		    if ( m_localFogBiDict )
		    {
		      Count = HG::Rendering::Runtime::BidirectionalDictionary<System::Object,System::Object>::get_Count(
		                (BidirectionalDictionary_2_System_Object_System_Object_ *)m_localFogBiDict,
		                MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::get_Count);
		      if ( localFog )
		      {
		        transform = UnityEngine::Component::get_transform((Component *)localFog, 0LL);
		        if ( transform )
		        {
		          position = UnityEngine::Transform::get_position(&v21.m_Center, transform, 0LL);
		          z = position->z;
		          value = *(_QWORD *)&position->x;
		          v16 = UnityEngine::Component::get_transform((Component *)localFog, 0LL);
		          if ( v16 )
		          {
		            lossyScale = UnityEngine::Transform::get_lossyScale(&v21.m_Center, v16, 0LL);
		            v18 = *(_QWORD *)&lossyScale->x;
		            *(float *)&lossyScale = lossyScale->z;
		            *(_QWORD *)&v20.x = v18;
		            *(_QWORD *)&v21.m_Center.x = value;
		            LODWORD(v20.z) = (_DWORD)lossyScale;
		            v21.m_Center.z = z;
		            UnityEngine::Bounds::Bounds(&v22, &v21.m_Center, &v20, 0LL);
		            m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_localFogBiDict;
		            if ( m_localFogBiDict )
		            {
		              HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::Add(
		                m_localFogBiDict,
		                (Object *)localFog,
		                Count,
		                MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Add);
		              m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_localFogList;
		              if ( m_localFogBiDict )
		              {
		                sub_182F01190((List_1_System_Object_ *)m_localFogBiDict, (Object *)localFog);
		                m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_cullingNativeInout;
		                if ( m_localFogBiDict )
		                {
		                  v21 = v22;
		                  HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::Add(
		                    (HGVolumetricLocalFogManager_SPMDCullingNativeInout *)m_localFogBiDict,
		                    &v21,
		                    0LL);
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_16:
		    sub_1800D8260(m_localFogBiDict, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1564, 0LL);
		  if ( !Patch )
		    goto LABEL_16;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)localFog,
		    0LL);
		}
		
		public void RemoveVolumetricLocalFog(HGVolumetricLocalFog localFog) {} // 0x0000000189CEF900-0x0000000189CEFAD8
		// Void RemoveVolumetricLocalFog(HGVolumetricLocalFog)
		void HG::Rendering::Runtime::HGVolumetricLocalFogManager::RemoveVolumetricLocalFog(
		        HGVolumetricLocalFogManager *this,
		        HGVolumetricLocalFog *localFog,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  BidirectionalDictionary_2_System_Object_System_Int32_ *m_localFogBiDict; // rcx
		  int32_t Count; // eax
		  int32_t v8; // edi
		  int32_t v9; // esi
		  Object *KeyByValue; // rax
		  Object *v11; // r14
		  List_1_HG_Rendering_Runtime_HGVolumetricLocalFog_ *m_localFogList; // rax
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v17; // [rsp+20h] [rbp-18h]
		  int32_t value; // [rsp+58h] [rbp+20h] BYREF
		
		  value = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1567, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1567, 0LL);
		    if ( !Patch )
		      goto LABEL_20;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)localFog,
		      0LL);
		  }
		  else
		  {
		    m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_localFogBiDict;
		    if ( !m_localFogBiDict )
		      goto LABEL_20;
		    if ( !HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::TryGetValueByKey(
		            m_localFogBiDict,
		            (Object *)localFog,
		            &value,
		            MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::TryGetValueByKey) )
		      return;
		    m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_localFogBiDict;
		    if ( !m_localFogBiDict )
		      goto LABEL_20;
		    Count = HG::Rendering::Runtime::BidirectionalDictionary<System::Object,System::Object>::get_Count(
		              (BidirectionalDictionary_2_System_Object_System_Object_ *)m_localFogBiDict,
		              MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::get_Count);
		    v8 = value;
		    m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_localFogBiDict;
		    v9 = Count - 1;
		    if ( value != Count - 1 )
		    {
		      if ( m_localFogBiDict )
		      {
		        KeyByValue = HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::GetKeyByValue(
		                       m_localFogBiDict,
		                       v9,
		                       MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::GetKeyByValue);
		        m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_localFogBiDict;
		        v11 = KeyByValue;
		        if ( m_localFogBiDict )
		        {
		          HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::Remove(
		            m_localFogBiDict,
		            (Object *)localFog,
		            v8,
		            MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Remove);
		          m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_localFogBiDict;
		          if ( m_localFogBiDict )
		          {
		            HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::Remove(
		              m_localFogBiDict,
		              v11,
		              v9,
		              MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Remove);
		            m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_localFogBiDict;
		            if ( m_localFogBiDict )
		            {
		              HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::Add(
		                m_localFogBiDict,
		                v11,
		                v8,
		                MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Add);
		              Unity::Collections::ListExtensions::RemoveAtSwapBack<System::Object>(
		                (List_1_System_Object_ *)this->fields.m_localFogList,
		                v8,
		                MethodInfo::Unity::Collections::ListExtensions::RemoveAtSwapBack<HG::Rendering::Runtime::HGVolumetricLocalFog>);
		              m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_cullingNativeInout;
		              if ( m_localFogBiDict )
		              {
		                HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::RemoveAtSwapBack(
		                  (HGVolumetricLocalFogManager_SPMDCullingNativeInout *)m_localFogBiDict,
		                  v8,
		                  0LL);
		                return;
		              }
		            }
		          }
		        }
		      }
		LABEL_20:
		      sub_1800D8260(m_localFogBiDict, v5);
		    }
		    if ( !m_localFogBiDict )
		      goto LABEL_20;
		    HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::Remove(
		      m_localFogBiDict,
		      (Object *)localFog,
		      value,
		      MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Remove);
		    m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_localFogList;
		    if ( !m_localFogBiDict )
		      goto LABEL_20;
		    System::Collections::Generic::List<System::Object>::RemoveAt(
		      (List_1_System_Object_ *)m_localFogBiDict,
		      v8,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::RemoveAt);
		    m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_cullingNativeInout;
		    if ( !m_localFogBiDict )
		      goto LABEL_20;
		    HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::RemoveAtSwapBack(
		      (HGVolumetricLocalFogManager_SPMDCullingNativeInout *)m_localFogBiDict,
		      v8,
		      0LL);
		    m_localFogList = this->fields.m_localFogList;
		    if ( !m_localFogList )
		      goto LABEL_20;
		    if ( !m_localFogList->fields._size )
		    {
		      m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this->fields.m_cullingNativeInout;
		      if ( !m_localFogBiDict )
		        goto LABEL_20;
		      HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::Dispose(
		        (HGVolumetricLocalFogManager_SPMDCullingNativeInout *)m_localFogBiDict,
		        0LL);
		      this->fields.m_cullingNativeInout = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_cullingNativeInout, v13, v14, v15, v17);
		    }
		  }
		}
		
		public NativeList<int> VolumetricLocalFogCulling(Matrix4x4 cullingMatrix, int cameraGuid) => default; // 0x0000000189CEFAD8-0x0000000189CEFBE4
		// NativeList`1[System.Int32] VolumetricLocalFogCulling(Matrix4x4, Int32)
		NativeList_1_System_Int32_ *HG::Rendering::Runtime::HGVolumetricLocalFogManager::VolumetricLocalFogCulling(
		        NativeList_1_System_Int32_ *__return_ptr retstr,
		        HGVolumetricLocalFogManager *this,
		        Matrix4x4 *cullingMatrix,
		        int32_t cameraGuid,
		        MethodInfo *method)
		{
		  HGVolumetricLocalFogManager_SPMDCullingNativeInout *v9; // rdx
		  HGVolumetricLocalFogManager_SPMDCullingNativeInout *m_cullingNativeInout; // rcx
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  NativeList_1_System_Int32_ *v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  NativeList_1_System_Int32_ v19; // xmm0
		  NativeList_1_System_Int32_ *result; // rax
		  NativeList_1_System_Int32_ v21; // [rsp+30h] [rbp-50h] BYREF
		  Matrix4x4 v22; // [rsp+40h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1551, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1551, 0LL);
		    if ( Patch )
		    {
		      v16 = *(_OWORD *)&cullingMatrix->m01;
		      *(_OWORD *)&v22.m00 = *(_OWORD *)&cullingMatrix->m00;
		      v17 = *(_OWORD *)&cullingMatrix->m02;
		      *(_OWORD *)&v22.m01 = v16;
		      v18 = *(_OWORD *)&cullingMatrix->m03;
		      *(_OWORD *)&v22.m02 = v17;
		      *(_OWORD *)&v22.m03 = v18;
		      v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_640(&v21, Patch, (Object *)this, &v22, cameraGuid, 0LL);
		      goto LABEL_8;
		    }
		LABEL_6:
		    sub_1800D8260(m_cullingNativeInout, v9);
		  }
		  m_cullingNativeInout = this->fields.m_cullingNativeInout;
		  if ( !m_cullingNativeInout )
		    goto LABEL_6;
		  HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::UpdateLocalFogTransform(
		    m_cullingNativeInout,
		    this->fields.m_localFogList,
		    0LL);
		  v9 = this->fields.m_cullingNativeInout;
		  if ( !v9 )
		    goto LABEL_6;
		  v11 = *(_OWORD *)&cullingMatrix->m01;
		  *(_OWORD *)&v22.m00 = *(_OWORD *)&cullingMatrix->m00;
		  v12 = *(_OWORD *)&cullingMatrix->m02;
		  *(_OWORD *)&v22.m01 = v11;
		  v13 = *(_OWORD *)&cullingMatrix->m03;
		  *(_OWORD *)&v22.m02 = v12;
		  *(_OWORD *)&v22.m03 = v13;
		  v14 = HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::VolumetricLocalFogCulling(
		          &v21,
		          v9,
		          &v22,
		          cameraGuid,
		          0LL);
		LABEL_8:
		  v19 = *v14;
		  result = retstr;
		  *retstr = v19;
		  return result;
		}
		
	}
}
