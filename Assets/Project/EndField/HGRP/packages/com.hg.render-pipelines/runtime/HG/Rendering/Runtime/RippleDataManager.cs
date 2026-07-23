using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class RippleDataManager // TypeDefIndex: 38789
	{
		// Fields
		public List<InputRippleData> _list; // 0x10
		private int _minIndex; // 0x18
		private Coroutine m_leaveWaterCoroutine; // 0x20
		private const float LEAVE_WATER_WAIT_TIME = 10f; // Metadata: 0x023044CD
		private float m_emptyStartTime; // 0x28
		private bool m_isWaitingToDisable; // 0x2C
	
		// Properties
		public int Count { get => default; } // 0x0000000189C64944-0x0000000189C6499C 
		// Int32 get_Count()
		int32_t HG::Rendering::Runtime::RippleDataManager::get_Count(RippleDataManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5378, 0LL) )
		  {
		    list = this->fields._list;
		    if ( list )
		      return list->fields._size;
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5378, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public RippleDataManager() {} // Dummy constructor
		public RippleDataManager(int capacity = 8 /* Metadata: 0x023044CC */) {} // 0x0000000182ED74F0-0x0000000182ED7560
		// RippleDataManager(Int32)
		void HG::Rendering::Runtime::RippleDataManager::RippleDataManager(
		        RippleDataManager *this,
		        int32_t capacity,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Factory_ECSVATFSM_VATFSMProcessor_SetAnimatorParamRequest_ *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v8; // rdi
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  this->fields.m_emptyStartTime = -1.0;
		  v5 = (List_1_Beyond_Gameplay_Factory_ECSVATFSM_VATFSMProcessor_SetAnimatorParamRequest_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>);
		  v8 = (List_1_HG_Rendering_Runtime_InputRippleData_ *)v5;
		  if ( !v5 )
		    sub_1800D8260(v7, v6);
		  System::Collections::Generic::List<Beyond::Gameplay::Factory::ECSVATFSM::VATFSMProcessor::SetAnimatorParamRequest>::List(
		    v5,
		    capacity,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::List);
		  this->fields._list = v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v9, v10, v11, v12);
		  this->fields._minIndex = -1;
		}
		
	
		// Methods
		public void Reset() {} // 0x00000001833348E0-0x0000000183334950
		// Void Reset()
		void HG::Rendering::Runtime::RippleDataManager::Reset(RippleDataManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size <= 2304 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_7;
		  if ( LODWORD(v3->_0.namespaze) <= 0x900 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !*((_QWORD *)&v3[49]._0.byval_arg + 1) )
		  {
		LABEL_5:
		    list = this->fields._list;
		    if ( list )
		    {
		      ++list->fields._version;
		      list->fields._size = 0;
		      this->fields._minIndex = -1;
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2304, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void Add(InputRippleData newData) {} // 0x0000000183EFA940-0x0000000183EFAA10
		// Void Add(InputRippleData)
		void HG::Rendering::Runtime::RippleDataManager::Add(
		        RippleDataManager *this,
		        InputRippleData *newData,
		        MethodInfo *method)
		{
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v5; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rdi
		  int32_t size; // edi
		  int32_t Length; // eax
		  float priority; // eax
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v11; // rax
		  float v12; // eax
		  __int128 v13; // xmm0
		  float v14; // eax
		  int32_t minIndex; // edx
		  float v16; // eax
		  __int128 v17; // xmm0
		  ILFixDynamicMethodWrapper_2 *v18; // rax
		  InputRippleData v19; // [rsp+20h] [rbp-40h] BYREF
		  InputRippleData v20; // [rsp+40h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2306, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2306, 0LL);
		    if ( !Patch )
		      goto LABEL_3;
		    v20.priority = newData->priority;
		    goto LABEL_22;
		  }
		  list = this->fields._list;
		  if ( !list )
		    goto LABEL_3;
		  size = list->fields._size;
		  Length = System::Threading::SparselyPopulatedArrayFragment<System::Object>::get_Length(
		             (SparselyPopulatedArrayFragment_1_System_Object_ *)this->fields._list,
		             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Capacity);
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields._list;
		  if ( size < Length )
		  {
		    if ( !Patch )
		      goto LABEL_3;
		    priority = newData->priority;
		    *(_OWORD *)&v20.positionXZ.x = *(_OWORD *)&newData->positionXZ.x;
		    v20.priority = priority;
		    sub_1844C82D0(
		      Patch,
		      &v20,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::Add);
		    if ( !IFix::WrappersManagerImpl::IsPatched(2307, 0LL) )
		    {
		      if ( this->fields._minIndex == -1 )
		        goto LABEL_8;
		      v5 = this->fields._list;
		      if ( !v5 )
		        goto LABEL_3;
		      System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item(
		        &v20,
		        v5,
		        this->fields._minIndex,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
		      v19.priority = v20.priority;
		      v16 = newData->priority;
		      *(_OWORD *)&v19.positionXZ.x = *(_OWORD *)&v20.positionXZ.x;
		      v17 = *(_OWORD *)&newData->positionXZ.x;
		      v20.priority = v16;
		      *(_OWORD *)&v20.positionXZ.x = v17;
		      if ( HG::Rendering::Runtime::RippleDataManager::IsLowerPriority(this, &v20, &v19, 0LL) )
		      {
		LABEL_8:
		        v11 = this->fields._list;
		        if ( v11 )
		        {
		          this->fields._minIndex = v11->fields._size - 1;
		          return;
		        }
		LABEL_3:
		        sub_1800D8260(Patch, v5);
		      }
		      return;
		    }
		    v18 = IFix::WrappersManagerImpl::GetPatch(2307, 0LL);
		    if ( !v18 )
		      goto LABEL_3;
		    v20.priority = newData->priority;
		    Patch = v18;
		LABEL_22:
		    *(_OWORD *)&v20.positionXZ.x = *(_OWORD *)&newData->positionXZ.x;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_917(Patch, (Object *)this, &v20, 0LL);
		    return;
		  }
		  if ( !Patch )
		    goto LABEL_3;
		  System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item(
		    &v19,
		    this->fields._list,
		    this->fields._minIndex,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
		  v20.priority = v19.priority;
		  v12 = newData->priority;
		  *(_OWORD *)&v20.positionXZ.x = *(_OWORD *)&v19.positionXZ.x;
		  v13 = *(_OWORD *)&newData->positionXZ.x;
		  v19.priority = v12;
		  *(_OWORD *)&v19.positionXZ.x = v13;
		  if ( HG::Rendering::Runtime::RippleDataManager::IsHigherPriority(this, &v19, &v20, 0LL) )
		  {
		    Patch = (ILFixDynamicMethodWrapper_2 *)this->fields._list;
		    if ( Patch )
		    {
		      v14 = newData->priority;
		      minIndex = this->fields._minIndex;
		      *(_OWORD *)&v20.positionXZ.x = *(_OWORD *)&newData->positionXZ.x;
		      v20.priority = v14;
		      System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::set_Item(
		        (List_1_HG_Rendering_Runtime_InputRippleData_ *)Patch,
		        minIndex,
		        &v20,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::set_Item);
		      HG::Rendering::Runtime::RippleDataManager::FindMinIndex(this, 0LL);
		      return;
		    }
		    goto LABEL_3;
		  }
		}
		
		private void UpdateMinIndexAfterAdd(InputRippleData newData) {} // 0x0000000183EFAA10-0x0000000183EFAA60
		// Void UpdateMinIndexAfterAdd(InputRippleData)
		void HG::Rendering::Runtime::RippleDataManager::UpdateMinIndexAfterAdd(
		        RippleDataManager *this,
		        InputRippleData *newData,
		        MethodInfo *method)
		{
		  List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v7; // rax
		  float priority; // eax
		  __int128 v9; // xmm0
		  __int128 v10; // xmm0
		  InputRippleData v11; // [rsp+20h] [rbp-48h] BYREF
		  InputRippleData v12[2]; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2307, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2307, 0LL);
		    if ( Patch )
		    {
		      v10 = *(_OWORD *)&newData->positionXZ.x;
		      v12[0].priority = newData->priority;
		      *(_OWORD *)&v12[0].positionXZ.x = v10;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_917(Patch, (Object *)this, v12, 0LL);
		      return;
		    }
		    goto LABEL_6;
		  }
		  if ( this->fields._minIndex == -1 )
		    goto LABEL_3;
		  list = this->fields._list;
		  if ( !list )
		    goto LABEL_6;
		  System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item(
		    &v11,
		    list,
		    this->fields._minIndex,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
		  v12[0].priority = v11.priority;
		  priority = newData->priority;
		  *(_OWORD *)&v12[0].positionXZ.x = *(_OWORD *)&v11.positionXZ.x;
		  v9 = *(_OWORD *)&newData->positionXZ.x;
		  v11.priority = priority;
		  *(_OWORD *)&v11.positionXZ.x = v9;
		  if ( HG::Rendering::Runtime::RippleDataManager::IsLowerPriority(this, &v11, v12, 0LL) )
		  {
		LABEL_3:
		    v7 = this->fields._list;
		    if ( v7 )
		    {
		      this->fields._minIndex = v7->fields._size - 1;
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(Patch, list);
		  }
		}
		
		private void FindMinIndex() {} // 0x0000000189C645F8-0x0000000189C646EC
		// Void FindMinIndex()
		void HG::Rendering::Runtime::RippleDataManager::FindMinIndex(RippleDataManager *this, MethodInfo *method)
		{
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v3; // rdx
		  __int64 v4; // rcx
		  int32_t i; // edi
		  List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  InputRippleData v8; // [rsp+20h] [rbp-60h] BYREF
		  InputRippleData v9; // [rsp+40h] [rbp-40h] BYREF
		  InputRippleData v10; // [rsp+60h] [rbp-20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2310, 0LL) )
		  {
		    this->fields._minIndex = 0;
		    for ( i = 1; ; ++i )
		    {
		      list = this->fields._list;
		      if ( !list )
		        break;
		      if ( i >= list->fields._size )
		        return;
		      System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item(
		        &v9,
		        this->fields._list,
		        i,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
		      v3 = this->fields._list;
		      if ( !v3 )
		        break;
		      System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item(
		        &v8,
		        v3,
		        this->fields._minIndex,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
		      v10 = v8;
		      v8 = v9;
		      if ( HG::Rendering::Runtime::RippleDataManager::IsLowerPriority(this, &v8, &v10, 0LL) )
		        this->fields._minIndex = i;
		    }
		LABEL_10:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2310, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private bool IsHigherPriority(InputRippleData a, InputRippleData b) => default; // 0x0000000189C646EC-0x0000000189C647A8
		// Boolean IsHigherPriority(InputRippleData, InputRippleData)
		bool HG::Rendering::Runtime::RippleDataManager::IsHigherPriority(
		        RippleDataManager *this,
		        InputRippleData *a,
		        InputRippleData *b,
		        MethodInfo *method)
		{
		  float v7; // xmm1_4
		  __int64 v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float priority; // eax
		  __int128 v12; // xmm0
		  float v13; // eax
		  InputRippleData v14; // [rsp+30h] [rbp-40h] BYREF
		  InputRippleData v15; // [rsp+50h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2309, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2309, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v9);
		    priority = b->priority;
		    *(_OWORD *)&v14.positionXZ.x = *(_OWORD *)&b->positionXZ.x;
		    v12 = *(_OWORD *)&a->positionXZ.x;
		    v14.priority = priority;
		    v13 = a->priority;
		    *(_OWORD *)&v15.positionXZ.x = v12;
		    v15.priority = v13;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_916(Patch, (Object *)this, &v15, &v14, 0LL);
		  }
		  else
		  {
		    v7 = a->priority;
		    return v7 > b->priority || v7 == b->priority && b->distanceXZ > a->distanceXZ;
		  }
		}
		
		private bool IsLowerPriority(InputRippleData a, InputRippleData b) => default; // 0x0000000189C647A8-0x0000000189C64868
		// Boolean IsLowerPriority(InputRippleData, InputRippleData)
		bool HG::Rendering::Runtime::RippleDataManager::IsLowerPriority(
		        RippleDataManager *this,
		        InputRippleData *a,
		        InputRippleData *b,
		        MethodInfo *method)
		{
		  __int64 v8; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float priority; // eax
		  __int128 v11; // xmm0
		  float v12; // eax
		  InputRippleData v13; // [rsp+30h] [rbp-40h] BYREF
		  InputRippleData v14; // [rsp+50h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2308, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2308, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v8);
		    priority = b->priority;
		    *(_OWORD *)&v13.positionXZ.x = *(_OWORD *)&b->positionXZ.x;
		    v11 = *(_OWORD *)&a->positionXZ.x;
		    v13.priority = priority;
		    v12 = a->priority;
		    *(_OWORD *)&v14.positionXZ.x = v11;
		    v14.priority = v12;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_916(Patch, (Object *)this, &v14, &v13, 0LL);
		  }
		  else
		  {
		    return b->priority > a->priority || a->priority == b->priority && a->distanceXZ > b->distanceXZ;
		  }
		}
		
		public InputRippleData[] ToArray() => default; // 0x0000000189C64868-0x0000000189C648C8
		// InputRippleData[] ToArray()
		InputRippleData__Array *HG::Rendering::Runtime::RippleDataManager::ToArray(RippleDataManager *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *list; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5376, 0LL) )
		  {
		    list = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields._list;
		    if ( list )
		      return (InputRippleData__Array *)System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::ToArray(
		                                         list,
		                                         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::ToArray);
		LABEL_5:
		    sub_1800D8260(list, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5376, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1556(Patch, (Object *)this, 0LL);
		}
		
		public List<InputRippleData> ToList() => default; // 0x0000000189C648C8-0x0000000189C64944
		// List`1[HG.Rendering.Runtime.InputRippleData] ToList()
		List_1_HG_Rendering_Runtime_InputRippleData_ *HG::Rendering::Runtime::RippleDataManager::ToList(
		        RippleDataManager *this,
		        MethodInfo *method)
		{
		  List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rdi
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v4; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  List_1_HG_Rendering_Runtime_InputRippleData_ *v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5377, 0LL) )
		  {
		    list = this->fields._list;
		    v4 = (List_1_HG_Rendering_Runtime_InputRippleData_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>);
		    v7 = v4;
		    if ( v4 )
		    {
		      System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::List(
		        v4,
		        (IEnumerable_1_HG_Rendering_Runtime_InputRippleData_ *)list,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::List);
		      return v7;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5377, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1557(Patch, (Object *)this, 0LL);
		}
		
		public void UpdateWaterState() {} // 0x0000000183332EE0-0x0000000183333050
		// Void UpdateWaterState()
		void HG::Rendering::Runtime::RippleDataManager::UpdateWaterState(RippleDataManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGManagerContext *currentManagerContext; // rax
		  HGWaterManager *waterManager_k__BackingField; // rbx
		  bool m_isRippleInputEmpty; // cl
		  bool m_isWaitingToDisable; // al
		  HGManagerContext *v9; // rax
		  HGManagerContext *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v12; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray->max_length.size > 2311 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v3->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_20;
		    if ( wrapperArray->max_length.size <= 0x907u )
		      goto LABEL_40;
		    if ( wrapperArray[64].vector[7] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2311, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		LABEL_20:
		      sub_1800D8260(v3, wrapperArray);
		    }
		  }
		  currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		  if ( !currentManagerContext )
		    goto LABEL_20;
		  waterManager_k__BackingField = currentManagerContext->fields._waterManager_k__BackingField;
		  if ( !waterManager_k__BackingField )
		    goto LABEL_20;
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray->max_length.size <= 2312 )
		    goto LABEL_11;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_20;
		  if ( LODWORD(v3->_0.namespaze) <= 0x908 )
		LABEL_40:
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[49]._0.typeMetadataHandle )
		  {
		LABEL_11:
		    m_isRippleInputEmpty = waterManager_k__BackingField->fields.m_isRippleInputEmpty;
		    goto LABEL_12;
		  }
		  v12 = IFix::WrappersManagerImpl::GetPatch(2312, 0LL);
		  if ( !v12 )
		    goto LABEL_20;
		  m_isRippleInputEmpty = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                           (ILFixDynamicMethodWrapper_20 *)v12,
		                           (Object *)waterManager_k__BackingField,
		                           0LL);
		LABEL_12:
		  m_isWaitingToDisable = this->fields.m_isWaitingToDisable;
		  if ( !m_isRippleInputEmpty )
		  {
		    if ( m_isWaitingToDisable )
		    {
		      this->fields.m_isWaitingToDisable = 0;
		      this->fields.m_emptyStartTime = -1.0;
		    }
		    v10 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( v10 )
		    {
		      v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v10->fields._waterManager_k__BackingField;
		      if ( v3 )
		      {
		        HG::Rendering::Runtime::HGWaterManager::SetShouldRenderRippleState((HGWaterManager *)v3, 1, 0LL);
		        return;
		      }
		    }
		    goto LABEL_20;
		  }
		  if ( !m_isWaitingToDisable )
		  {
		    this->fields.m_isWaitingToDisable = 1;
		    this->fields.m_emptyStartTime = UnityEngine::Time::get_time(0LL);
		    return;
		  }
		  if ( (float)(UnityEngine::Time::get_time(0LL) - this->fields.m_emptyStartTime) >= 10.0 )
		  {
		    v9 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( v9 )
		    {
		      v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v9->fields._waterManager_k__BackingField;
		      if ( v3 )
		      {
		        HG::Rendering::Runtime::HGWaterManager::SetShouldRenderRippleState((HGWaterManager *)v3, 0, 0LL);
		        this->fields.m_isWaitingToDisable = 0;
		        return;
		      }
		    }
		    goto LABEL_20;
		  }
		}
		
	}
}
