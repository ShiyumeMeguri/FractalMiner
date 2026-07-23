using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGDecalInteration // TypeDefIndex: 37746
	{
		// Fields
		private List<HGInteractionChain> freeChains; // 0x10
		private Dictionary<int, HGInteractionChain> busyChains; // 0x18
		private List<int> pendingFreeChains; // 0x20
		private const int KEEP_BUSY_FRAMES = 3; // Metadata: 0x0230308B
		private HGInteractionSettingAsset settingAsset; // 0x28
	
		// Properties
		public static bool enableMobileInteraction { get => default; } // 0x0000000183AB5310-0x0000000183AB53C0 
		// Boolean get_enableMobileInteraction()
		bool HG::Rendering::Runtime::HGDecalInteration::get_enableMobileInteraction(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 679 )
		    return 0;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v2 = (struct ILFixDynamicMethodWrapper_2__Class *)v2->static_fields->wrapperArray;
		  if ( !v2 )
		    goto LABEL_6;
		  if ( LODWORD(v2->_0.namespaze) <= 0x2A7 )
		    sub_1800D2AB0(v2, v1);
		  if ( !v2[14]._1.typeHierarchy )
		    return 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(679, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v2, v1);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		}
		
	
		// Constructors
		public HGDecalInteration() {} // 0x0000000182ED83D0-0x0000000182ED8480
		// HGDecalInteration()
		void HG::Rendering::Runtime::HGDecalInteration::HGDecalInteration(HGDecalInteration *this, MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_HG_Rendering_Runtime_HGInteractionChain_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Dictionary_2_System_Int32_System_Object_ *v10; // rax
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_HGInteractionChain_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v15; // rax
		  List_1_System_Int32_ *v16; // rdi
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+50h] [rbp+28h]
		
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>);
		  v6 = (List_1_HG_Rendering_Runtime_HGInteractionChain_ *)v3;
		  if ( !v3 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v3,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::List);
		  this->fields.freeChains = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v20);
		  v10 = (Dictionary_2_System_Int32_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>);
		  v11 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGInteractionChain_ *)v10;
		  if ( !v10
		    || (System::Collections::Generic::Dictionary<int,System::Object>::Dictionary(
		          v10,
		          MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::Dictionary),
		        this->fields.busyChains = v11,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.busyChains, v12, v13, v14, v21),
		        v15 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>),
		        (v16 = (List_1_System_Int32_ *)v15) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v15,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields.pendingFreeChains = v16;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.pendingFreeChains, v17, v18, v19, v22);
		}
		
	
		// Methods
		public void UpdateSettingAsset(HGInteractionSettingAsset _settingAsset) {} // 0x0000000184A79110-0x0000000184A79150
		// Void UpdateSettingAsset(HGInteractionSettingAsset)
		void HG::Rendering::Runtime::HGDecalInteration::UpdateSettingAsset(
		        HGDecalInteration *this,
		        HGInteractionSettingAsset *_settingAsset,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1786, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1786, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)_settingAsset,
		      0LL);
		  }
		  else
		  {
		    this->fields.settingAsset = _settingAsset;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.settingAsset, v5, v6, v7, v11);
		  }
		}
		
		public void Release() {} // 0x0000000189CFB620-0x0000000189CFB874
		// Void Release()
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGDecalInteration::Release(HGDecalInteration *this, MethodInfo *method)
		{
		  HGDecalInteration *v2; // rbx
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Dictionary_2_System_UInt64_System_Object_ *busyChains; // rdx
		  Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *freeChains; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  _BYTE v10[32]; // [rsp+0h] [rbp-A8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v11; // [rsp+20h] [rbp-88h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v12; // [rsp+48h] [rbp-60h] BYREF
		  List_1_T_Enumerator_System_Object_ v13; // [rsp+70h] [rbp-38h] BYREF
		  Il2CppExceptionWrapper *v14; // [rsp+88h] [rbp-20h] BYREF
		  Il2CppExceptionWrapper *v15; // [rsp+90h] [rbp-18h] BYREF
		
		  v2 = this;
		  memset(&v12, 0, sizeof(v12));
		  if ( IFix::WrappersManagerImpl::IsPatched(1787, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1787, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    if ( !v2->fields.freeChains )
		      sub_1800D8260(v4, v3);
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v11,
		      (List_1_System_UInt64_ *)v2->fields.freeChains,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
		    *(_OWORD *)&v13._list = *(_OWORD *)&v11._dictionary;
		    v13._current = *(Object **)&v11._current.key;
		    v11._dictionary = 0LL;
		    *(_QWORD *)&v11._version = &v13;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v13,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionChain>::MoveNext) )
		      {
		        if ( !v13._current )
		          sub_1800D8250(0LL, busyChains);
		        HG::Rendering::Runtime::HGInteractionChain::Reset((HGInteractionChain *)v13._current, 0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v14 )
		    {
		      busyChains = (Dictionary_2_System_UInt64_System_Object_ *)v10;
		      v11._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v14->ex;
		      if ( v11._dictionary )
		        sub_18007E1E0(v11._dictionary);
		      v2 = this;
		    }
		    freeChains = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)v2->fields.freeChains;
		    if ( !freeChains )
		      goto LABEL_26;
		    sub_183127A90(
		      freeChains,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::Clear);
		    busyChains = (Dictionary_2_System_UInt64_System_Object_ *)v2->fields.busyChains;
		    if ( !busyChains )
		      goto LABEL_26;
		    System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ *)&v11,
		      busyChains,
		      MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
		    v12 = v11;
		    v11._dictionary = 0LL;
		    *(_QWORD *)&v11._version = &v12;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v12,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::MoveNext) )
		      {
		        if ( !v12._current.value )
		          sub_1800D8250(0LL, busyChains);
		        HG::Rendering::Runtime::HGInteractionChain::Reset((HGInteractionChain *)v12._current.value, 0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v15 )
		    {
		      busyChains = (Dictionary_2_System_UInt64_System_Object_ *)v10;
		      v11._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v15->ex;
		      if ( v11._dictionary )
		        sub_18007E1E0(v11._dictionary);
		      v2 = this;
		    }
		    freeChains = (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)v2->fields.busyChains;
		    if ( !freeChains )
		LABEL_26:
		      sub_1800D8250(freeChains, busyChains);
		    System::Collections::Generic::Dictionary<Beyond::Gameplay::Core::WaterVolumePtr,System::ValueTuple<float,System::Int32Enum,System::Object>>::Clear(
		      freeChains,
		      MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::Clear);
		  }
		}
		
		private HGInteractionChain GetFreeChain() => default; // 0x0000000189CFB4B0-0x0000000189CFB620
		// HGInteractionChain GetFreeChain()
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		HGInteractionChain *HG::Rendering::Runtime::HGDecalInteration::GetFreeChain(
		        HGDecalInteration *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Object *current; // rbx
		  List_1_System_Object_ *freeChains; // rcx
		  HGInteractionSettingAsset *settingAsset; // rdi
		  HGInteractionChain *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  List_1_T_Enumerator_System_Object_ v17; // [rsp+28h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v18; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1788, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1788, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_718(Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !this->fields.freeChains )
		      sub_1800D8260(v4, v3);
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v17,
		      (List_1_System_UInt64_ *)this->fields.freeChains,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
		    v18 = v17;
		    v17._list = 0LL;
		    *(_QWORD *)&v17._index = &v18;
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v18,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionChain>::MoveNext) )
		    {
		      current = v18._current;
		      if ( !v18._current )
		        sub_1800D8250(v6, v5);
		      if ( LOBYTE(v18._current[1].klass) )
		      {
		        freeChains = (List_1_System_Object_ *)this->fields.freeChains;
		        if ( !freeChains )
		          sub_1800D8250(0LL, v5);
		        System::Collections::Generic::List<System::Object>::Remove(
		          freeChains,
		          v18._current,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::Remove);
		        return (HGInteractionChain *)current;
		      }
		    }
		    settingAsset = this->fields.settingAsset;
		    v10 = (HGInteractionChain *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGInteractionChain);
		    current = (Object *)v10;
		    if ( !v10 )
		      sub_1800D8250(v12, v11);
		    HG::Rendering::Runtime::HGInteractionChain::HGInteractionChain(v10, settingAsset, 0LL);
		    return (HGInteractionChain *)current;
		  }
		}
		
		public void UpdateFromNodes(List<HGInteractionNode> nodes) {} // 0x0000000189CFBB24-0x0000000189CFBF7C
		// Void UpdateFromNodes(List`1[HG.Rendering.Runtime.HGInteractionNode])
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGDecalInteration::UpdateFromNodes(
		        HGDecalInteration *this,
		        List_1_HG_Rendering_Runtime_HGInteractionNode_ *nodes,
		        MethodInfo *method)
		{
		  Object *v4; // rbx
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Il2CppException *v7; // rcx
		  Dictionary_2_System_Int32_System_Object_ *monitor; // rcx
		  __int64 v9; // rdx
		  Object *FreeChain; // rax
		  __int64 v11; // rdx
		  Dictionary_2_System_Int32_System_Object_ *v12; // rcx
		  Dictionary_2_System_UInt64_System_Object_ *v13; // rdx
		  __int64 v14; // rdx
		  KeyValuePair_2_System_Int32Enum_System_Object_ v15; // xmm6
		  HGInteractionChain *v16; // rcx
		  __int64 v17; // rdx
		  HGInteractionChain *v18; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  Il2CppException *ex; // [rsp+20h] [rbp-2E8h]
		  Il2CppException *v23; // [rsp+20h] [rbp-2E8h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v24; // [rsp+30h] [rbp-2D8h] BYREF
		  Il2CppExceptionWrapper *v25; // [rsp+58h] [rbp-2B0h] BYREF
		  Il2CppExceptionWrapper *v26; // [rsp+60h] [rbp-2A8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v27; // [rsp+68h] [rbp-2A0h] BYREF
		  List_1_T_Enumerator_HG_Rendering_Runtime_HGInteractionNode_ v28; // [rsp+90h] [rbp-278h] BYREF
		  HGInteractionNode current; // [rsp+160h] [rbp-1A8h] BYREF
		  List_1_T_Enumerator_HG_Rendering_Runtime_HGInteractionNode_ key; // [rsp+220h] [rbp-E8h] BYREF
		  Object *value; // [rsp+328h] [rbp+20h] BYREF
		
		  v4 = (Object *)this;
		  sub_18033B9D0(&current, 0LL, 192LL);
		  value = 0LL;
		  memset(&v24, 0, sizeof(v24));
		  if ( IFix::WrappersManagerImpl::IsPatched(1789, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1789, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v21, v20);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_39 *)Patch, v4, (Object *)nodes, 0LL);
		  }
		  else
		  {
		    if ( !nodes )
		      sub_1800D8260(v6, v5);
		    System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::GetEnumerator(
		      &key,
		      nodes,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::GetEnumerator);
		    v28 = key;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::MoveNext(
		                &v28,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::MoveNext) )
		      {
		        current = v28._current;
		        monitor = (Dictionary_2_System_Int32_System_Object_ *)v4[1].monitor;
		        *(_OWORD *)&key._list = *(_OWORD *)&v28._current.NodeKey;
		        *(_OWORD *)&key._current.NodeKey = *(_OWORD *)&v28._current.localToWorldMatrix.m20;
		        *(_OWORD *)&key._current.localToWorldMatrix.m20 = *(_OWORD *)&v28._current.localToWorldMatrix.m21;
		        *(_OWORD *)&key._current.localToWorldMatrix.m21 = *(_OWORD *)&v28._current.localToWorldMatrix.m22;
		        *(_OWORD *)&key._current.localToWorldMatrix.m22 = *(_OWORD *)&v28._current.localToWorldMatrix.m23;
		        *(_OWORD *)&key._current.localToWorldMatrix.m23 = *(_OWORD *)&v28._current.prevLocalToWorldMatrix.m20;
		        *(_OWORD *)&key._current.prevLocalToWorldMatrix.m20 = *(_OWORD *)&v28._current.prevLocalToWorldMatrix.m21;
		        *(_OWORD *)&key._current.prevLocalToWorldMatrix.m21 = *(_OWORD *)&v28._current.prevLocalToWorldMatrix.m22;
		        *(_OWORD *)&key._current.prevLocalToWorldMatrix.m22 = *(_OWORD *)&v28._current.prevLocalToWorldMatrix.m23;
		        *(_OWORD *)&key._current.prevLocalToWorldMatrix.m23 = *(_OWORD *)&v28._current.length;
		        *(_OWORD *)&key._current.length = *(_OWORD *)&v28._current.texture;
		        *(_OWORD *)&key._current.texture = *(_OWORD *)&v28._current.heightScale;
		        if ( !monitor )
		          sub_1800D8250(0LL, &key._current.prevLocalToWorldMatrix.m22);
		        if ( !System::Collections::Generic::Dictionary<int,System::Object>::TryGetValue(
		                monitor,
		                (int32_t)key._list,
		                &value,
		                MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::TryGetValue) )
		        {
		          FreeChain = (Object *)HG::Rendering::Runtime::HGDecalInteration::GetFreeChain((HGDecalInteration *)v4, 0LL);
		          value = FreeChain;
		          v12 = (Dictionary_2_System_Int32_System_Object_ *)v4[1].monitor;
		          if ( !v12 )
		            sub_1800D8250(0LL, v11);
		          System::Collections::Generic::Dictionary<int,System::Object>::Add(
		            v12,
		            current.NodeKey,
		            FreeChain,
		            MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::Add);
		        }
		        if ( !value )
		          sub_1800D8250(0LL, v9);
		        HG::Rendering::Runtime::HGInteractionChain::PushNewNode((HGInteractionChain *)value, &current, 0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v25 )
		    {
		      ex = v25->ex;
		      v7 = v25->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v4 = (Object *)this;
		    }
		    v13 = (Dictionary_2_System_UInt64_System_Object_ *)v4[1].monitor;
		    if ( !v13 )
		      sub_1800D8250(v7, 0LL);
		    System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
		      (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ *)&v27,
		      v13,
		      MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
		    v24 = v27;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v24,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::MoveNext) )
		      {
		        v15 = v24._current;
		        v16 = (HGInteractionChain *)_mm_srli_si128((__m128i)v24._current, 8).m128i_u64[0];
		        if ( !v16 )
		          sub_1800D8250(0LL, v14);
		        HG::Rendering::Runtime::HGInteractionChain::UpdateChainFade(v16, 0LL);
		        v18 = (HGInteractionChain *)_mm_srli_si128((__m128i)v15, 8).m128i_u64[0];
		        if ( !v18 )
		          sub_1800D8250(0LL, v17);
		        HG::Rendering::Runtime::HGInteractionChain::UpdateRenderData(v18, 0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v26 )
		    {
		      v23 = v26->ex;
		      if ( v23 )
		        sub_18007E1E0(v23);
		      v4 = (Object *)this;
		    }
		    HG::Rendering::Runtime::HGDecalInteration::UpdateChainState((HGDecalInteration *)v4, 0LL);
		  }
		}
		
		private void UpdateChainState() {} // 0x0000000189CFB874-0x0000000189CFBB24
		// Void UpdateChainState()
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGDecalInteration::UpdateChainState(HGDecalInteration *this, MethodInfo *method)
		{
		  Object *v2; // rbx
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  List_1_System_Int32_ *list; // rcx
		  KeyValuePair_2_System_Int32Enum_System_Object_ current; // xmm6
		  int32_t frameCount; // eax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  HGInteractionChain *v10; // xmm0_8
		  __int64 v11; // rdx
		  List_1_System_Object_ *klass; // rcx
		  __int64 v13; // rdx
		  Object__Class *v14; // rcx
		  List_1_System_Int32_ *v15; // rdx
		  Dictionary_2_System_Int32_System_Object_ *monitor; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  __int64 v20; // [rsp+0h] [rbp-B8h] BYREF
		  List_1_T_Enumerator_System_Int32_ v21; // [rsp+20h] [rbp-98h] BYREF
		  List_1_T_Enumerator_System_Int32_ v22; // [rsp+48h] [rbp-70h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v23; // [rsp+60h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v24; // [rsp+88h] [rbp-30h] BYREF
		  Il2CppExceptionWrapper *v25; // [rsp+90h] [rbp-28h] BYREF
		
		  v2 = (Object *)this;
		  memset(&v23, 0, sizeof(v23));
		  memset(&v22, 0, sizeof(v22));
		  if ( IFix::WrappersManagerImpl::IsPatched(1790, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1790, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v19, v18);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, v2, 0LL);
		  }
		  else
		  {
		    if ( !v2[1].monitor )
		      sub_1800D8260(v4, v3);
		    v23 = *(Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *)sub_1808B4DF0(&v21, v2[1].monitor);
		    v21._list = 0LL;
		    *(_QWORD *)&v21._index = &v23;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v23,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::MoveNext) )
		      {
		        current = v23._current;
		        frameCount = UnityEngine::Time::get_frameCount(0LL);
		        v10 = (HGInteractionChain *)_mm_srli_si128((__m128i)current, 8).m128i_u64[0];
		        if ( !v10 )
		          sub_1800D8250(v9, v8);
		        if ( frameCount > v10->fields.LastAccessFrame + 3 )
		        {
		          HG::Rendering::Runtime::HGInteractionChain::Reset(v10, 0LL);
		          klass = (List_1_System_Object_ *)v2[1].klass;
		          if ( !klass )
		            sub_1800D8250(0LL, v11);
		          sub_182F01190(klass, (Object *)v10);
		          v14 = v2[2].klass;
		          if ( !v14 )
		            sub_1800D8250(0LL, v13);
		          sub_183081250(
		            v14,
		            (unsigned int)_mm_cvtsi128_si32((__m128i)current),
		            MethodInfo::System::Collections::Generic::List<int>::Add);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v24 )
		    {
		      v21._list = (List_1_System_Int32_ *)v24->ex;
		      list = v21._list;
		      if ( v21._list )
		        sub_18007E1E0(v21._list);
		      v2 = (Object *)this;
		    }
		    v15 = (List_1_System_Int32_ *)v2[2].klass;
		    if ( !v15 )
		      goto LABEL_30;
		    System::Collections::Generic::List<int>::GetEnumerator(
		      &v21,
		      v15,
		      MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
		    v22 = v21;
		    v21._list = 0LL;
		    *(_QWORD *)&v21._index = &v22;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext(
		                &v22,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
		      {
		        monitor = (Dictionary_2_System_Int32_System_Object_ *)v2[1].monitor;
		        if ( !monitor )
		          sub_1800D8250(0LL, v15);
		        System::Collections::Generic::Dictionary<int,System::Object>::Remove(
		          monitor,
		          v22._current,
		          MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::Remove);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v25 )
		    {
		      v15 = (List_1_System_Int32_ *)&v20;
		      v21._list = (List_1_System_Int32_ *)v25->ex;
		      if ( v21._list )
		        sub_18007E1E0(v21._list);
		      v2 = (Object *)this;
		    }
		    list = (List_1_System_Int32_ *)v2[2].klass;
		    if ( !list )
		LABEL_30:
		      sub_1800D8250(list, v15);
		    ++list->fields._version;
		    list->fields._size = 0;
		  }
		}
		
		public void DrawAllChains(CommandBuffer cmd, Material material) {} // 0x0000000189CFB338-0x0000000189CFB4B0
		// Void DrawAllChains(CommandBuffer, Material)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGDecalInteration::DrawAllChains(
		        HGDecalInteration *this,
		        CommandBuffer *cmd,
		        Material *material,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Il2CppExceptionWrapper *v15; // [rsp+30h] [rbp-78h] BYREF
		  Il2CppException *ex; // [rsp+38h] [rbp-70h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v17; // [rsp+40h] [rbp-68h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v18; // [rsp+48h] [rbp-60h] BYREF
		  _BYTE v19[48]; // [rsp+70h] [rbp-38h] BYREF
		
		  memset(&v18, 0, sizeof(v18));
		  if ( IFix::WrappersManagerImpl::IsPatched(1791, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1791, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		      (ILFixDynamicMethodWrapper_30 *)Patch,
		      (Object *)this,
		      (Object *)cmd,
		      (Object *)material,
		      0LL);
		  }
		  else
		  {
		    if ( !material )
		      sub_1800D8260(v8, v7);
		    UnityEngine::Material::set_enableInstancing(material, 1, 0LL);
		    if ( !this->fields.busyChains )
		      sub_1800D8260(v10, v9);
		    v18 = *(Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *)sub_1808B4DF0(
		                                                                                    v19,
		                                                                                    this->fields.busyChains);
		    ex = 0LL;
		    v17 = &v18;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
		                &v18,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::MoveNext) )
		      {
		        if ( !v18._current.value )
		          sub_1800D8250(0LL, v11);
		        HG::Rendering::Runtime::HGInteractionChain::DrawChainNodes(
		          (HGInteractionChain *)v18._current.value,
		          cmd,
		          material,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v15 )
		    {
		      ex = v15->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		    }
		  }
		}
		
		public HGDecalInteractionParametersV2 BuildNativeSettingParameters() => default; // 0x0000000183AB50A0-0x0000000183AB5310
		// HGDecalInteractionParametersV2 BuildNativeSettingParameters()
		HGDecalInteractionParametersV2 *HG::Rendering::Runtime::HGDecalInteration::BuildNativeSettingParameters(
		        HGDecalInteractionParametersV2 *__return_ptr retstr,
		        HGDecalInteration *this,
		        MethodInfo *method)
		{
		  _QWORD **v5; // rcx
		  __int64 v6; // rdx
		  struct Object_1__Class *v7; // rcx
		  HGInteractionSettingAsset *settingAsset; // rdi
		  void *m_CachedPtr; // rdi
		  HGInteractionSettingAsset *v10; // rax
		  Material *decalInteractionMaterial; // rbp
		  HGInteractionSettingAsset *v12; // rax
		  Material *v13; // rdi
		  HGInteractionSettingAsset *v14; // rax
		  float timeFadeSpeed; // xmm2_4
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __m128 v18; // xmm1
		  __m128 v19; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGDecalInteractionParametersV2 *v22; // rax
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  HGDecalInteractionParametersV2 v25; // [rsp+20h] [rbp-48h] BYREF
		
		  v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = *v5[23];
		  if ( !v6 )
		    goto LABEL_24;
		  if ( *(int *)(v6 + 24) > 1792 )
		  {
		    if ( !*((_DWORD *)v5 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (_QWORD **)*v5[23];
		    if ( !v5 )
		      goto LABEL_24;
		    if ( *((_DWORD *)v5 + 6) <= 0x700u )
		      sub_1800D2AB0(v5, v6);
		    if ( v5[1796] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1792, 0LL);
		      if ( Patch )
		      {
		        v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_719(&v25, Patch, (Object *)this, 0LL);
		        v23 = *(_OWORD *)&v22->m_decalNodeWidth;
		        *(_OWORD *)&retstr->m_enableDecalInteraction = *(_OWORD *)&v22->m_enableDecalInteraction;
		        v24 = *(_OWORD *)&v22->m_nodeDistanceThreshold;
		        *(_OWORD *)&retstr->m_decalNodeWidth = v23;
		        v19 = *(__m128 *)&v22->m_rotationThreshold;
		        *(_OWORD *)&retstr->m_nodeDistanceThreshold = v24;
		        goto LABEL_21;
		      }
		      goto LABEL_24;
		    }
		  }
		  v7 = TypeInfo::UnityEngine::Object;
		  settingAsset = this->fields.settingAsset;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v7 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v7 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !settingAsset )
		    goto LABEL_23;
		  if ( !v7->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v7);
		  if ( !settingAsset->fields._._.m_CachedPtr )
		  {
		LABEL_23:
		    *(_OWORD *)&retstr->m_enableDecalInteraction = 0LL;
		    *(_OWORD *)&retstr->m_decalNodeWidth = 0LL;
		    *(_OWORD *)&retstr->m_nodeDistanceThreshold = 0LL;
		    *(_OWORD *)&retstr->m_rotationThreshold = 0LL;
		    return retstr;
		  }
		  m_CachedPtr = 0LL;
		  *(_DWORD *)(&v25.m_enableDecalInteraction + 1) = 0;
		  *(_WORD *)(&v25.m_enableDecalInteraction + 5) = 0;
		  *(&v25.m_enableDecalInteraction + 7) = 0;
		  *((_DWORD *)&v25.m_timeFadeSpeed + 1) = 0;
		  v25.m_enableDecalInteraction = HG::Rendering::Runtime::HGDecalInteration::get_enableMobileInteraction(0LL);
		  v10 = this->fields.settingAsset;
		  if ( !v10 )
		    goto LABEL_24;
		  v5 = (_QWORD **)TypeInfo::UnityEngine::Object;
		  decalInteractionMaterial = v10->fields.decalInteractionMaterial;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v5 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( decalInteractionMaterial )
		  {
		    if ( !*((_DWORD *)v5 + 56) )
		      il2cpp_runtime_class_init_1(v5);
		    if ( decalInteractionMaterial->fields._.m_CachedPtr )
		    {
		      v12 = this->fields.settingAsset;
		      if ( v12 )
		      {
		        v13 = v12->fields.decalInteractionMaterial;
		        if ( v13 )
		        {
		          m_CachedPtr = v13->fields._.m_CachedPtr;
		          goto LABEL_19;
		        }
		      }
		LABEL_24:
		      sub_1800D8260(v5, v6);
		    }
		  }
		LABEL_19:
		  v14 = this->fields.settingAsset;
		  v25.m_decalInteractionMaterial = m_CachedPtr;
		  if ( !v14 )
		    goto LABEL_24;
		  timeFadeSpeed = v14->fields.timeFadeSpeed;
		  *(_OWORD *)&v25.m_decalNodeWidth = *(_OWORD *)&v14->fields.decalNodeWidth;
		  v16 = *(_OWORD *)&v25.m_decalNodeWidth;
		  *(_OWORD *)&v25.m_nodeDistanceThreshold = *(_OWORD *)&v14->fields.nodeDistanceThreshold;
		  *(_QWORD *)&v25.m_rotationThreshold = *(_QWORD *)&v14->fields.rotationThreshold;
		  *(_OWORD *)&retstr->m_enableDecalInteraction = *(_OWORD *)&v25.m_enableDecalInteraction;
		  v17 = *(_OWORD *)&v25.m_nodeDistanceThreshold;
		  *(_OWORD *)&retstr->m_decalNodeWidth = v16;
		  v18 = _mm_shuffle_ps(*(__m128 *)&v25.m_rotationThreshold, *(__m128 *)&v25.m_rotationThreshold, 210);
		  v18.m128_f32[0] = timeFadeSpeed;
		  v19 = _mm_shuffle_ps(v18, v18, 201);
		  *(_OWORD *)&retstr->m_nodeDistanceThreshold = v17;
		LABEL_21:
		  *(__m128 *)&retstr->m_rotationThreshold = v19;
		  return retstr;
		}
		
	}
}
