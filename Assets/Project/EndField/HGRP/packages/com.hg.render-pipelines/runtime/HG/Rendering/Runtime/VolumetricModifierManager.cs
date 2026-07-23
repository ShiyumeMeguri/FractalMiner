using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricModifierManager // TypeDefIndex: 38760
	{
		// Fields
		private List<VolumetricSDFModifier> modifierList; // 0x10
		private FModifierData[] modifierDataList; // 0x18
		public ComputeBuffer _modifierBuffer; // 0x20
		public ComputeBuffer _defaultModifierBuffer; // 0x28
	
		// Properties
		public int ModifierNum { get => default; } // 0x0000000189C5471C-0x0000000189C54780 
		// Int32 get_ModifierNum()
		int32_t HG::Rendering::Runtime::VolumetricModifierManager::get_ModifierNum(
		        VolumetricModifierManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  List_1_HG_Rendering_Runtime_VolumetricSDFModifier_ *modifierList; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5242, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5242, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( this->fields._modifierBuffer )
		    {
		      modifierList = this->fields.modifierList;
		      if ( modifierList )
		        return modifierList->fields._size;
		LABEL_7:
		      sub_1800D8260(v4, v3);
		    }
		    return 0;
		  }
		}
		
		public ComputeBuffer ModifierBuffer { get => default; } // 0x0000000189C546C4-0x0000000189C5471C 
		// ComputeBuffer get_ModifierBuffer()
		ComputeBuffer *HG::Rendering::Runtime::VolumetricModifierManager::get_ModifierBuffer(
		        VolumetricModifierManager *this,
		        MethodInfo *method)
		{
		  ComputeBuffer *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5243, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5243, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_506(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    result = this->fields._modifierBuffer;
		    if ( !result )
		      return this->fields._defaultModifierBuffer;
		  }
		  return result;
		}
		
	
		// Constructors
		public VolumetricModifierManager() {} // 0x0000000189C545D4-0x0000000189C546C4
		// VolumetricModifierManager()
		void HG::Rendering::Runtime::VolumetricModifierManager::VolumetricModifierManager(
		        VolumetricModifierManager *this,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  __int64 v4; // rdx
		  ComputeBuffer *defaultModifierBuffer; // rcx
		  List_1_HG_Rendering_Runtime_VolumetricSDFModifier_ *v6; // rdi
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
		
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>);
		  v6 = (List_1_HG_Rendering_Runtime_VolumetricSDFModifier_ *)v3;
		  if ( !v3 )
		    goto LABEL_6;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::List);
		  this->fields.modifierList = v6;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v19);
		  this->fields.modifierDataList = (FModifierData__Array *)il2cpp_array_new_specific_1(
		                                                            TypeInfo::HG::Rendering::Runtime::FModifierData,
		                                                            5LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.modifierDataList, v10, v11, v12, v20);
		  v13 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		  v14 = v13;
		  if ( !v13
		    || (UnityEngine::ComputeBuffer::ComputeBuffer(v13, 1, 48, ComputeBufferType__Enum_Default, 0LL),
		        this->fields._defaultModifierBuffer = v14,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._defaultModifierBuffer, v15, v16, v17, v21),
		        v18 = (Array *)il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::FModifierData, 1LL),
		        (defaultModifierBuffer = this->fields._defaultModifierBuffer) == 0LL)
		    || (UnityEngine::ComputeBuffer::SetData(defaultModifierBuffer, v18, 0LL),
		        (defaultModifierBuffer = this->fields._defaultModifierBuffer) == 0LL) )
		  {
		LABEL_6:
		    sub_1800D8260(defaultModifierBuffer, v4);
		  }
		  UnityEngine::ComputeBuffer::SetName(defaultModifierBuffer, (String *)"defaultModifierBuffer", 0LL);
		  HG::Rendering::Runtime::VolumetricModifierManager::UpdateBuffer(this, 0LL);
		}
		
	
		// Methods
		public void Release() {} // 0x0000000189C542E8-0x0000000189C54338
		// Void Release()
		void HG::Rendering::Runtime::VolumetricModifierManager::Release(VolumetricModifierManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5238, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5238, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VolumetricModifierManager::ClearResources(this, 0LL);
		  }
		}
		
		public void Tick() {} // 0x0000000189C543CC-0x0000000189C5441C
		// Void Tick()
		void HG::Rendering::Runtime::VolumetricModifierManager::Tick(VolumetricModifierManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5240, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5240, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VolumetricModifierManager::UpdateBuffer(this, 0LL);
		  }
		}
		
		private void ClearResources() {} // 0x0000000189C5425C-0x0000000189C542E8
		// Void ClearResources()
		void HG::Rendering::Runtime::VolumetricModifierManager::ClearResources(
		        VolumetricModifierManager *this,
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
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5239, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5239, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( this->fields._modifierBuffer )
		    {
		      UnityEngine::ComputeBuffer::Dispose(this->fields._modifierBuffer, 0LL);
		      this->fields._modifierBuffer = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._modifierBuffer, v3, v4, v5, v12);
		    }
		    if ( this->fields._defaultModifierBuffer )
		    {
		      UnityEngine::ComputeBuffer::Dispose(this->fields._defaultModifierBuffer, 0LL);
		      this->fields._defaultModifierBuffer = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._defaultModifierBuffer, v6, v7, v8, v13);
		    }
		  }
		}
		
		public void AddModifier(VolumetricSDFModifier modifier) {} // 0x0000000189C541C8-0x0000000189C5425C
		// Void AddModifier(VolumetricSDFModifier)
		void HG::Rendering::Runtime::VolumetricModifierManager::AddModifier(
		        VolumetricModifierManager *this,
		        VolumetricSDFModifier *modifier,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *modifierList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5244, 0LL) )
		  {
		    modifierList = (List_1_System_Object_ *)this->fields.modifierList;
		    if ( modifierList )
		    {
		      if ( System::Collections::Generic::List<System::Object>::Contains(
		             modifierList,
		             (Object *)modifier,
		             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::Contains) )
		      {
		        return;
		      }
		      modifierList = (List_1_System_Object_ *)this->fields.modifierList;
		      if ( modifierList )
		      {
		        sub_182F01190(modifierList, (Object *)modifier);
		        HG::Rendering::Runtime::VolumetricModifierManager::UpdateBuffer(this, 0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(modifierList, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5244, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)modifier,
		    0LL);
		}
		
		public void RemoveModifier(VolumetricSDFModifier modifier) {} // 0x0000000189C54338-0x0000000189C543CC
		// Void RemoveModifier(VolumetricSDFModifier)
		void HG::Rendering::Runtime::VolumetricModifierManager::RemoveModifier(
		        VolumetricModifierManager *this,
		        VolumetricSDFModifier *modifier,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *modifierList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5245, 0LL) )
		  {
		    modifierList = (List_1_System_Object_ *)this->fields.modifierList;
		    if ( modifierList )
		    {
		      if ( !System::Collections::Generic::List<System::Object>::Contains(
		              modifierList,
		              (Object *)modifier,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::Contains) )
		        return;
		      modifierList = (List_1_System_Object_ *)this->fields.modifierList;
		      if ( modifierList )
		      {
		        System::Collections::Generic::List<System::Object>::Remove(
		          modifierList,
		          (Object *)modifier,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::Remove);
		        HG::Rendering::Runtime::VolumetricModifierManager::UpdateBuffer(this, 0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(modifierList, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5245, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)modifier,
		    0LL);
		}
		
		private void UpdateBuffer() {} // 0x0000000189C5441C-0x0000000189C545D4
		// Void UpdateBuffer()
		void HG::Rendering::Runtime::VolumetricModifierManager::UpdateBuffer(
		        VolumetricModifierManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  ComputeBuffer *v4; // rcx
		  List_1_HG_Rendering_Runtime_VolumetricSDFModifier_ *modifierList; // rbx
		  int size; // ebx
		  unsigned int v7; // esi
		  ComputeBuffer *modifierBuffer; // rcx
		  ComputeBuffer *v9; // rax
		  ComputeBuffer *v10; // rbx
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  FModifierData__Array *modifierDataList; // rax
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  int32_t v18; // esi
		  List_1_HG_Rendering_Runtime_VolumetricSDFModifier_ *v19; // rax
		  FModifierData__Array *v20; // rbx
		  Object *Item; // rax
		  FModifierData *ModifierData; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v24; // [rsp+20h] [rbp-48h]
		  MethodInfo *v25; // [rsp+20h] [rbp-48h]
		  FModifierData v26; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5241, 0LL) )
		  {
		    modifierList = this->fields.modifierList;
		    if ( !modifierList )
		      goto LABEL_26;
		    size = modifierList->fields._size;
		    sub_1800036A0(TypeInfo::System::Math);
		    v7 = 1;
		    if ( size >= 1 )
		      v7 = size;
		    if ( !this->fields._modifierBuffer || UnityEngine::ComputeBuffer::get_count(this->fields._modifierBuffer, 0LL) != v7 )
		    {
		      modifierBuffer = this->fields._modifierBuffer;
		      if ( modifierBuffer )
		        UnityEngine::ComputeBuffer::Dispose(modifierBuffer, 0LL);
		      v9 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		      v10 = v9;
		      if ( !v9 )
		        goto LABEL_26;
		      UnityEngine::ComputeBuffer::ComputeBuffer(v9, v7, 48, ComputeBufferType__Enum_Default, 0LL);
		      this->fields._modifierBuffer = v10;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._modifierBuffer, v11, v12, v13, v25);
		      v4 = this->fields._modifierBuffer;
		      if ( !v4 )
		        goto LABEL_26;
		      UnityEngine::ComputeBuffer::SetName(v4, (String *)"modifierBuffer", 0LL);
		    }
		    modifierDataList = this->fields.modifierDataList;
		    if ( modifierDataList )
		    {
		      if ( modifierDataList->max_length.size != v7 )
		      {
		        this->fields.modifierDataList = (FModifierData__Array *)il2cpp_array_new_specific_1(
		                                                                  TypeInfo::HG::Rendering::Runtime::FModifierData,
		                                                                  v7);
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.modifierDataList, v15, v16, v17, v24);
		      }
		      v18 = 0;
		      while ( 1 )
		      {
		        v19 = this->fields.modifierList;
		        if ( !v19 )
		          goto LABEL_26;
		        v20 = this->fields.modifierDataList;
		        if ( v18 >= v19->fields._size )
		          break;
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 (List_1_System_Object_ *)this->fields.modifierList,
		                 v18,
		                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::get_Item);
		        if ( !Item )
		          goto LABEL_26;
		        ModifierData = HG::Rendering::Runtime::VolumetricSDFModifier::GetModifierData(
		                         &v26,
		                         (VolumetricSDFModifier *)Item,
		                         0LL);
		        if ( !v20 )
		          goto LABEL_26;
		        if ( (unsigned int)v18 >= v20->max_length.size )
		          sub_1800D2AB0(v4, v3 * 6);
		        v4 = (ComputeBuffer *)v18;
		        v3 = v18++;
		        *(_OWORD *)&v20->vector[v3].Position.x = *(_OWORD *)&ModifierData->Position.x;
		        *(_OWORD *)&v20->vector[v3].Payload.x = *(_OWORD *)&ModifierData->Payload.x;
		        *(_OWORD *)&v20->vector[v3].Operation = *(_OWORD *)&ModifierData->Operation;
		      }
		      v4 = this->fields._modifierBuffer;
		      if ( v4 )
		      {
		        UnityEngine::ComputeBuffer::SetData(v4, (Array *)this->fields.modifierDataList, 0LL);
		        return;
		      }
		    }
		LABEL_26:
		    sub_1800D8260(v4, v3 * 6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5241, 0LL);
		  if ( !Patch )
		    goto LABEL_26;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
