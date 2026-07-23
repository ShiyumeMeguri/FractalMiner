using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricWindFieldManager // TypeDefIndex: 38773
	{
		// Fields
		private List<IVolumetricWindField> windFieldList; // 0x10
		private FWindFieldData[] windFieldDataList; // 0x18
	
		// Constructors
		public VolumetricWindFieldManager() {} // 0x000000018464DA50-0x000000018464DAD0
	
		// Methods
		public void Release() {} // 0x0000000189C65EDC-0x0000000189C65F2C
		// Void Release()
		void HG::Rendering::Runtime::VolumetricWindFieldManager::Release(VolumetricWindFieldManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5054, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5054, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VolumetricWindFieldManager::ClearResources(this, 0LL);
		  }
		}
		
		private void ClearResources() {} // 0x0000000189C65D30-0x0000000189C65D74
		// Void ClearResources()
		void HG::Rendering::Runtime::VolumetricWindFieldManager::ClearResources(
		        VolumetricWindFieldManager *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5055, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5055, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		public void AddWindField(IVolumetricWindField windField) {} // 0x0000000184A78E70-0x0000000184A78EE0
		// Void AddWindField(IVolumetricWindField)
		void HG::Rendering::Runtime::VolumetricWindFieldManager::AddWindField(
		        VolumetricWindFieldManager *this,
		        IVolumetricWindField *windField,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *windFieldList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5007, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5007, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)windField,
		        0LL);
		      return;
		    }
		    goto LABEL_7;
		  }
		  windFieldList = (List_1_System_Object_ *)this->fields.windFieldList;
		  if ( !windFieldList )
		    goto LABEL_7;
		  if ( System::Collections::Generic::List<System::Object>::Contains(
		         windFieldList,
		         (Object *)windField,
		         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::Contains) )
		  {
		    return;
		  }
		  windFieldList = (List_1_System_Object_ *)this->fields.windFieldList;
		  if ( !windFieldList )
		LABEL_7:
		    sub_1800D8260(windFieldList, v5);
		  sub_182F01190(windFieldList, (Object *)windField);
		}
		
		public void RemoveWindField(IVolumetricWindField windField) {} // 0x0000000189C65F2C-0x0000000189C65FB8
		// Void RemoveWindField(IVolumetricWindField)
		void HG::Rendering::Runtime::VolumetricWindFieldManager::RemoveWindField(
		        VolumetricWindFieldManager *this,
		        IVolumetricWindField *windField,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Object_ *windFieldList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5009, 0LL) )
		  {
		    windFieldList = (List_1_System_Object_ *)this->fields.windFieldList;
		    if ( windFieldList )
		    {
		      if ( !System::Collections::Generic::List<System::Object>::Contains(
		              windFieldList,
		              (Object *)windField,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::Contains) )
		        return;
		      windFieldList = (List_1_System_Object_ *)this->fields.windFieldList;
		      if ( windFieldList )
		      {
		        System::Collections::Generic::List<System::Object>::Remove(
		          windFieldList,
		          (Object *)windField,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::Remove);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(windFieldList, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5009, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)windField,
		    0LL);
		}
		
		public void Tick() {} // 0x0000000189C65FB8-0x0000000189C66008
		// Void Tick()
		void HG::Rendering::Runtime::VolumetricWindFieldManager::Tick(VolumetricWindFieldManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5037, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5037, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VolumetricWindFieldManager::UpdateBuffer(this, 0LL);
		  }
		}
		
		private void UpdateBuffer() {} // 0x000000018464DAD0-0x000000018464DB80
		// Void UpdateBuffer()
		void HG::Rendering::Runtime::VolumetricWindFieldManager::UpdateBuffer(
		        VolumetricWindFieldManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  FWindFieldData__Array *windFieldDataList; // rcx
		  List_1_HG_Rendering_Runtime_IVolumetricWindField_ *windFieldList; // rax
		  int size; // edi
		  unsigned int v7; // eax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v8; // rdx
		  VolumetricRenderer_VolumetricBounds *v9; // r8
		  Int32__Array **v10; // r9
		  int32_t v11; // edi
		  List_1_HG_Rendering_Runtime_IVolumetricWindField_ *v12; // rax
		  FWindFieldData__Array *v13; // rsi
		  Object *Item; // rax
		  Vector4 Param1; // xmm1
		  Vector4 Param2; // xmm0
		  Vector4 Param3; // xmm1
		  Vector4 Param4; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  FWindFieldData v20; // [rsp+20h] [rbp-58h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5038, 0LL) )
		  {
		    windFieldList = this->fields.windFieldList;
		    if ( windFieldList )
		    {
		      size = windFieldList->fields._size;
		      if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		      windFieldDataList = this->fields.windFieldDataList;
		      v7 = 1;
		      if ( size >= 1 )
		        v7 = size;
		      if ( windFieldDataList )
		      {
		        if ( windFieldDataList->max_length.size != v7 )
		        {
		          this->fields.windFieldDataList = (FWindFieldData__Array *)il2cpp_array_new_specific_1(
		                                                                      TypeInfo::HG::Rendering::Runtime::FWindFieldData,
		                                                                      v7);
		          sub_18002D1B0(
		            (VolumetricRenderer_VolumetricRenderItem *)&this->fields.windFieldDataList,
		            v8,
		            v9,
		            v10,
		            *(MethodInfo **)&v20.Param0.x,
		            SLOBYTE(v20.Param0.z),
		            SLODWORD(v20.Param1.x),
		            SLODWORD(v20.Param1.z),
		            v20.Param2.x,
		            SLODWORD(v20.Param2.z),
		            SLOBYTE(v20.Param3.x),
		            SLOBYTE(v20.Param3.z),
		            *(MethodInfo **)&v20.Param4.x);
		        }
		        v11 = 0;
		        while ( 1 )
		        {
		          v12 = this->fields.windFieldList;
		          if ( !v12 )
		            break;
		          if ( v11 >= v12->fields._size )
		            return;
		          v13 = this->fields.windFieldDataList;
		          Item = System::Collections::Generic::List<System::Object>::get_Item(
		                   (List_1_System_Object_ *)this->fields.windFieldList,
		                   v11,
		                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::get_Item);
		          if ( !Item )
		            break;
		          if ( *(_DWORD *)&Item->klass->_1.method_count == 3436 )
		          {
		            HG::Rendering::Runtime::VolumetricWindFieldNode::GetWindFieldData(
		              &v20,
		              (VolumetricWindFieldNode *)Item,
		              0LL);
		          }
		          else if ( *(_DWORD *)&Item->klass->_1.method_count == 3437 )
		          {
		            HG::Rendering::Runtime::VolumetricWindField::GetWindFieldData(&v20, (VolumetricWindField *)Item, 0LL);
		          }
		          else
		          {
		            sub_1808B2A60(&v20, Item->klass, (unsigned int)(*(_DWORD *)&Item->klass->_1.method_count - 3436), Item);
		          }
		          if ( !v13 )
		            break;
		          if ( (unsigned int)v11 >= v13->max_length.size )
		            sub_1800D2AB0(windFieldDataList, v3);
		          Param1 = v20.Param1;
		          windFieldDataList = (FWindFieldData__Array *)(10LL * v11++);
		          *(Vector4 *)((char *)&v13->vector[0].Param0 + 8 * (_QWORD)windFieldDataList) = v20.Param0;
		          Param2 = v20.Param2;
		          *(Vector4 *)((char *)&v13->vector[0].Param1 + 8 * (_QWORD)windFieldDataList) = Param1;
		          Param3 = v20.Param3;
		          *(Vector4 *)((char *)&v13->vector[0].Param2 + 8 * (_QWORD)windFieldDataList) = Param2;
		          Param4 = v20.Param4;
		          *(Vector4 *)((char *)&v13->vector[0].Param3 + 8 * (_QWORD)windFieldDataList) = Param3;
		          *(Vector4 *)((char *)&v13->vector[0].Param4 + 8 * (_QWORD)windFieldDataList) = Param4;
		        }
		      }
		    }
		LABEL_14:
		    sub_1800D8260(windFieldDataList, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5038, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void GetWindFieldCB(ScriptableRenderContext renderContext, out CBHandle cbHandle, out int count) {
			cbHandle = default;
			count = default;
		} // 0x0000000189C65D74-0x0000000189C65EDC
		// Void GetWindFieldCB(ScriptableRenderContext, CBHandle ByRef, Int32 ByRef)
		void HG::Rendering::Runtime::VolumetricWindFieldManager::GetWindFieldCB(
		        VolumetricWindFieldManager *this,
		        ScriptableRenderContext renderContext,
		        CBHandle *cbHandle,
		        int32_t *count,
		        MethodInfo *method)
		{
		  FWindFieldData__Array *v8; // rdx
		  __int64 v9; // rcx
		  FWindFieldData__Array *windFieldDataList; // rax
		  FWindFieldData__Array *v11; // rbp
		  int size; // ebx
		  CBHandle *v13; // rax
		  int32_t v14; // r8d
		  void *ptr; // xmm0_8
		  char *v16; // r10
		  int v17; // r9d
		  __int64 v18; // rax
		  __int64 v19; // rcx
		  __int64 v20; // rax
		  __int128 v21; // xmm1
		  __int128 v22; // xmm2
		  __int128 v23; // xmm3
		  __int128 v24; // xmm4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  CBHandle v26; // [rsp+30h] [rbp-38h] BYREF
		  ScriptableRenderContext P1; // [rsp+78h] [rbp+10h] BYREF
		
		  P1.m_Ptr = renderContext.m_Ptr;
		  if ( IFix::WrappersManagerImpl::IsPatched(5118, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5118, 0LL);
		    if ( !Patch )
		      goto LABEL_14;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1491(Patch, (Object *)this, P1, cbHandle, count, 0LL);
		  }
		  else
		  {
		    windFieldDataList = this->fields.windFieldDataList;
		    if ( !windFieldDataList )
		      goto LABEL_14;
		    *count = windFieldDataList->max_length.size;
		    v11 = this->fields.windFieldDataList;
		    if ( !v11 )
		      goto LABEL_14;
		    sub_1800036A0(TypeInfo::System::Math);
		    size = 1;
		    if ( v11->max_length.size >= 1 )
		      size = v11->max_length.size;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    v13 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(&v26, &P1, 80 * size, 0LL);
		    v14 = 0;
		    ptr = v13->ptr;
		    *(_OWORD *)&cbHandle->bufferId = *(_OWORD *)&v13->bufferId;
		    cbHandle->ptr = ptr;
		    v16 = (char *)cbHandle->ptr;
		    if ( *count > 0 )
		    {
		      v17 = 0;
		      while ( 1 )
		      {
		        v8 = this->fields.windFieldDataList;
		        if ( !v8 )
		          break;
		        if ( (unsigned int)v14 >= v8->max_length.size )
		          sub_1800D2AB0(v9, v8);
		        v18 = v14++;
		        v19 = 5 * v18;
		        v20 = v17;
		        v9 = 2 * v19;
		        v17 += 80;
		        v21 = *(__int128 *)((char *)&v8->vector[0].Param1 + 8 * v9);
		        v22 = *(__int128 *)((char *)&v8->vector[0].Param2 + 8 * v9);
		        v23 = *(__int128 *)((char *)&v8->vector[0].Param3 + 8 * v9);
		        v24 = *(__int128 *)((char *)&v8->vector[0].Param4 + 8 * v9);
		        *(Vector4 *)&v16[v20] = *(Vector4 *)((char *)&v8->vector[0].Param0 + 8 * v9);
		        *(_OWORD *)&v16[v20 + 16] = v21;
		        *(_OWORD *)&v16[v20 + 32] = v22;
		        *(_OWORD *)&v16[v20 + 48] = v23;
		        *(_OWORD *)&v16[v20 + 64] = v24;
		        if ( v14 >= *count )
		          return;
		      }
		LABEL_14:
		      sub_1800D8260(v9, v8);
		    }
		  }
		}
		
	}
}
