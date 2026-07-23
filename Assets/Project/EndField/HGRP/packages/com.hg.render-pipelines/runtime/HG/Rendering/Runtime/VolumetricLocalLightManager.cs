using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricLocalLightManager // TypeDefIndex: 38725
	{
		// Fields
		private List<VolumetricLocalLight> localLightList; // 0x10
		private FLocalLightData[] localLightDataList; // 0x18
		public ComputeBuffer _localLightBuffer; // 0x20
		public ComputeBuffer _defaultLocalLightBuffer; // 0x28
	
		// Properties
		public int LocalLightNum { get => default; } // 0x0000000189C53910-0x0000000189C53974 
		// Int32 get_LocalLightNum()
		int32_t HG::Rendering::Runtime::VolumetricLocalLightManager::get_LocalLightNum(
		        VolumetricLocalLightManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  List_1_HG_Rendering_Runtime_VolumetricLocalLight_ *localLightList; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5133, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5133, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( this->fields._localLightBuffer )
		    {
		      localLightList = this->fields.localLightList;
		      if ( localLightList )
		        return localLightList->fields._size;
		LABEL_7:
		      sub_1800D8260(v4, v3);
		    }
		    return 0;
		  }
		}
		
		public ComputeBuffer LocalLightBuffer { get => default; } // 0x0000000189C538B8-0x0000000189C53910 
		// ComputeBuffer get_LocalLightBuffer()
		ComputeBuffer *HG::Rendering::Runtime::VolumetricLocalLightManager::get_LocalLightBuffer(
		        VolumetricLocalLightManager *this,
		        MethodInfo *method)
		{
		  ComputeBuffer *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5134, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5134, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_506(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    result = this->fields._localLightBuffer;
		    if ( !result )
		      return this->fields._defaultLocalLightBuffer;
		  }
		  return result;
		}
		
	
		// Constructors
		public VolumetricLocalLightManager() {} // 0x0000000189C537C8-0x0000000189C538B8
		// VolumetricLocalLightManager()
		void HG::Rendering::Runtime::VolumetricLocalLightManager::VolumetricLocalLightManager(
		        VolumetricLocalLightManager *this,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  __int64 v4; // rdx
		  ComputeBuffer *defaultLocalLightBuffer; // rcx
		  List_1_HG_Rendering_Runtime_VolumetricLocalLight_ *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  ComputeBuffer *v13; // rax
		  ComputeBuffer *v14; // rdi
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  Array *v18; // rax
		  MethodInfo *v19; // [rsp+20h] [rbp-18h]
		  MethodInfo *v20; // [rsp+20h] [rbp-18h]
		  MethodInfo *v21; // [rsp+20h] [rbp-18h]
		
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>);
		  v6 = (List_1_HG_Rendering_Runtime_VolumetricLocalLight_ *)v3;
		  if ( !v3 )
		    goto LABEL_6;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::List);
		  this->fields.localLightList = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v19);
		  this->fields.localLightDataList = (FLocalLightData__Array *)il2cpp_array_new_specific_1(
		                                                                TypeInfo::HG::Rendering::Runtime::FLocalLightData,
		                                                                5LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.localLightDataList, v10, v11, v12, v20);
		  v13 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		  v14 = v13;
		  if ( !v13
		    || (UnityEngine::ComputeBuffer::ComputeBuffer(v13, 1, 80, ComputeBufferType__Enum_Default, 0LL),
		        this->fields._defaultLocalLightBuffer = v14,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._defaultLocalLightBuffer, v15, v16, v17, v21),
		        v18 = (Array *)il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::FLocalLightData, 1LL),
		        (defaultLocalLightBuffer = this->fields._defaultLocalLightBuffer) == 0LL)
		    || (UnityEngine::ComputeBuffer::SetData(defaultLocalLightBuffer, v18, 0LL),
		        (defaultLocalLightBuffer = this->fields._defaultLocalLightBuffer) == 0LL) )
		  {
		LABEL_6:
		    sub_1800D8260(defaultLocalLightBuffer, v4);
		  }
		  UnityEngine::ComputeBuffer::SetName(defaultLocalLightBuffer, (String *)"defaultLocalLightBuffer", 0LL);
		  HG::Rendering::Runtime::VolumetricLocalLightManager::UpdateBuffer(this, 0LL);
		}
		
	
		// Methods
		public void Release() {} // 0x0000000189C534C0-0x0000000189C53510
		// Void Release()
		void HG::Rendering::Runtime::VolumetricLocalLightManager::Release(
		        VolumetricLocalLightManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5129, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5129, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VolumetricLocalLightManager::ClearResources(this, 0LL);
		  }
		}
		
		public void Tick() {} // 0x0000000189C535A4-0x0000000189C535F4
		// Void Tick()
		void HG::Rendering::Runtime::VolumetricLocalLightManager::Tick(VolumetricLocalLightManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5131, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5131, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VolumetricLocalLightManager::UpdateBuffer(this, 0LL);
		  }
		}
		
		private void ClearResources() {} // 0x0000000189C53434-0x0000000189C534C0
		// Void ClearResources()
		void HG::Rendering::Runtime::VolumetricLocalLightManager::ClearResources(
		        VolumetricLocalLightManager *this,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		  MethodInfo *v13; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5130, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5130, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( this->fields._localLightBuffer )
		    {
		      UnityEngine::ComputeBuffer::Dispose(this->fields._localLightBuffer, 0LL);
		      this->fields._localLightBuffer = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._localLightBuffer, v3, v4, v5, v12);
		    }
		    if ( this->fields._defaultLocalLightBuffer )
		    {
		      UnityEngine::ComputeBuffer::Dispose(this->fields._defaultLocalLightBuffer, 0LL);
		      this->fields._defaultLocalLightBuffer = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._defaultLocalLightBuffer, v6, v7, v8, v13);
		    }
		  }
		}
		
		public void AddLocalLight(VolumetricLocalLight localLight) {} // 0x0000000189C533A0-0x0000000189C53434
		// Void AddLocalLight(VolumetricLocalLight)
		void HG::Rendering::Runtime::VolumetricLocalLightManager::AddLocalLight(
		        VolumetricLocalLightManager *this,
		        VolumetricLocalLight *localLight,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *localLightList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5135, 0LL) )
		  {
		    localLightList = (List_1_System_Object_ *)this->fields.localLightList;
		    if ( localLightList )
		    {
		      if ( System::Collections::Generic::List<System::Object>::Contains(
		             localLightList,
		             (Object *)localLight,
		             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::Contains) )
		      {
		        return;
		      }
		      localLightList = (List_1_System_Object_ *)this->fields.localLightList;
		      if ( localLightList )
		      {
		        sub_182F01190(localLightList, (Object *)localLight);
		        HG::Rendering::Runtime::VolumetricLocalLightManager::UpdateBuffer(this, 0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(localLightList, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5135, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)localLight,
		    0LL);
		}
		
		public void RemoveLocalLight(VolumetricLocalLight localLight) {} // 0x0000000189C53510-0x0000000189C535A4
		// Void RemoveLocalLight(VolumetricLocalLight)
		void HG::Rendering::Runtime::VolumetricLocalLightManager::RemoveLocalLight(
		        VolumetricLocalLightManager *this,
		        VolumetricLocalLight *localLight,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *localLightList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5136, 0LL) )
		  {
		    localLightList = (List_1_System_Object_ *)this->fields.localLightList;
		    if ( localLightList )
		    {
		      if ( !System::Collections::Generic::List<System::Object>::Contains(
		              localLightList,
		              (Object *)localLight,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::Contains) )
		        return;
		      localLightList = (List_1_System_Object_ *)this->fields.localLightList;
		      if ( localLightList )
		      {
		        System::Collections::Generic::List<System::Object>::Remove(
		          localLightList,
		          (Object *)localLight,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::Remove);
		        HG::Rendering::Runtime::VolumetricLocalLightManager::UpdateBuffer(this, 0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(localLightList, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5136, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)localLight,
		    0LL);
		}
		
		private void UpdateBuffer() {} // 0x0000000189C535F4-0x0000000189C537C8
		// Void UpdateBuffer()
		void HG::Rendering::Runtime::VolumetricLocalLightManager::UpdateBuffer(
		        VolumetricLocalLightManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  ComputeBuffer *v4; // rcx
		  List_1_HG_Rendering_Runtime_VolumetricLocalLight_ *localLightList; // rbx
		  int size; // ebx
		  unsigned int v7; // esi
		  ComputeBuffer *localLightBuffer; // rcx
		  ComputeBuffer *v9; // rax
		  ComputeBuffer *v10; // rbx
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  FLocalLightData__Array *localLightDataList; // rax
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  int32_t v18; // esi
		  List_1_HG_Rendering_Runtime_VolumetricLocalLight_ *v19; // rax
		  FLocalLightData__Array *v20; // rbx
		  Object *Item; // rax
		  FLocalLightData *LocalLightData; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v24; // [rsp+20h] [rbp-68h]
		  MethodInfo *v25; // [rsp+20h] [rbp-68h]
		  FLocalLightData v26; // [rsp+30h] [rbp-58h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5132, 0LL) )
		  {
		    localLightList = this->fields.localLightList;
		    if ( !localLightList )
		      goto LABEL_26;
		    size = localLightList->fields._size;
		    sub_1800036A0(TypeInfo::System::Math);
		    v7 = 1;
		    if ( size >= 1 )
		      v7 = size;
		    if ( !this->fields._localLightBuffer
		      || UnityEngine::ComputeBuffer::get_count(this->fields._localLightBuffer, 0LL) != v7 )
		    {
		      localLightBuffer = this->fields._localLightBuffer;
		      if ( localLightBuffer )
		        UnityEngine::ComputeBuffer::Dispose(localLightBuffer, 0LL);
		      v9 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		      v10 = v9;
		      if ( !v9 )
		        goto LABEL_26;
		      UnityEngine::ComputeBuffer::ComputeBuffer(v9, v7, 80, ComputeBufferType__Enum_Default, 0LL);
		      this->fields._localLightBuffer = v10;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._localLightBuffer, v11, v12, v13, v25);
		      v4 = this->fields._localLightBuffer;
		      if ( !v4 )
		        goto LABEL_26;
		      UnityEngine::ComputeBuffer::SetName(v4, (String *)"localLightBuffer", 0LL);
		    }
		    localLightDataList = this->fields.localLightDataList;
		    if ( localLightDataList )
		    {
		      if ( localLightDataList->max_length.size != v7 )
		      {
		        this->fields.localLightDataList = (FLocalLightData__Array *)il2cpp_array_new_specific_1(
		                                                                      TypeInfo::HG::Rendering::Runtime::FLocalLightData,
		                                                                      v7);
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.localLightDataList, v15, v16, v17, v24);
		      }
		      v18 = 0;
		      while ( 1 )
		      {
		        v19 = this->fields.localLightList;
		        if ( !v19 )
		          goto LABEL_26;
		        v20 = this->fields.localLightDataList;
		        if ( v18 >= v19->fields._size )
		          break;
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 (List_1_System_Object_ *)this->fields.localLightList,
		                 v18,
		                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::get_Item);
		        if ( !Item )
		          goto LABEL_26;
		        LocalLightData = HG::Rendering::Runtime::VolumetricLocalLight::GetLocalLightData(
		                           &v26,
		                           (VolumetricLocalLight *)Item,
		                           0LL);
		        if ( !v20 )
		          goto LABEL_26;
		        if ( (unsigned int)v18 >= v20->max_length.size )
		          sub_1800D2AB0(v4, v3 * 10);
		        v4 = (ComputeBuffer *)v18;
		        v3 = v18++;
		        *(_OWORD *)&v20->vector[v3].Position.x = *(_OWORD *)&LocalLightData->Position.x;
		        *(_OWORD *)&v20->vector[v3].Color.x = *(_OWORD *)&LocalLightData->Color.x;
		        *(_OWORD *)&v20->vector[v3].Direction.x = *(_OWORD *)&LocalLightData->Direction.x;
		        *(_OWORD *)&v20->vector[v3].SpotAngles.x = *(_OWORD *)&LocalLightData->SpotAngles.x;
		        *(_OWORD *)&v20->vector[v3].ShadowIntensity = *(_OWORD *)&LocalLightData->ShadowIntensity;
		      }
		      v4 = this->fields._localLightBuffer;
		      if ( v4 )
		      {
		        UnityEngine::ComputeBuffer::SetData(v4, (Array *)this->fields.localLightDataList, 0LL);
		        return;
		      }
		    }
		LABEL_26:
		    sub_1800D8260(v4, v3 * 10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5132, 0LL);
		  if ( !Patch )
		    goto LABEL_26;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
