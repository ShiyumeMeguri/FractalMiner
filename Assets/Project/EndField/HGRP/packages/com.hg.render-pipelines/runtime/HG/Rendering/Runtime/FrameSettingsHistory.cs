using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal struct FrameSettingsHistory // TypeDefIndex: 38548
	{
		// Fields
		internal static readonly string[] foldoutNames; // 0x00
		private static readonly string[] columnNames; // 0x08
		private static readonly string[] columnTooltips; // 0x10
		private static readonly Dictionary<FrameSettingsField, FrameSettingsFieldAttribute> attributes; // 0x18
		private static Dictionary<int, IOrderedEnumerable<KeyValuePair<FrameSettingsField, FrameSettingsFieldAttribute>>> attributesGroup; // 0x20
		internal static HashSet<IFrameSettingsHistoryContainer> containers; // 0x28
		public FrameSettingsRenderType defaultType; // 0x00
		public FrameSettings overridden; // 0x08
		public FrameSettingsOverrideMask customMask; // 0x20
		public FrameSettings sanitazed; // 0x30
		public FrameSettings debug; // 0x48
		private bool hasDebug; // 0x60
		private static bool s_PossiblyInUse; // 0x30
	
		// Properties
		public static bool enabled { get => default; } // 0x0000000183948A30-0x0000000183948C00 
		// Boolean get_enabled()
		bool HG::Rendering::Runtime::FrameSettingsHistory::get_enabled(MethodInfo *method)
		{
		  MethodInfo *v1; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  struct FrameSettingsHistory__Class *v4; // rax
		  DebugManager *instance; // rax
		  DebugManager *v6; // rax
		  DebugManager *v7; // rbx
		  struct Object_1__Class *v8; // rcx
		  GameObject *m_Root; // rdi
		  bool activeInHierarchy; // al
		  int v11; // ebx
		  struct FrameSettingsHistory__Class *v12; // rax
		  FrameSettingsHistory__StaticFields *static_fields; // rax
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  DebugManager *v16; // rax
		  DebugManager *v17; // rax
		  struct FrameSettingsHistory__Class *v18; // rcx
		  FrameSettingsHistory__StaticFields *v19; // rax
		  struct FrameSettingsHistory_c__Class *v20; // rcx
		  IEnumerable_1_System_Object_ *containers; // rdi
		  Func_2_Object_Boolean_ *_9__14_0; // rbx
		  Object *v23; // rsi
		  Func_2_Object_Boolean_ *v24; // rax
		  PropertyInfo_1 *v25; // r8
		  Type *v26; // rdx
		  Int32__Array **v27; // r9
		  bool v28; // al
		  struct FrameSettingsHistory__Class *v29; // rcx
		  bool v30; // bl
		  MethodInfo *v31; // [rsp+20h] [rbp-8h]
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v31 = v1;
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_26;
		  if ( wrapperArray->max_length.size > 586 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v2->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_26;
		    if ( wrapperArray->max_length.size <= 0x24Au )
		      sub_1800D2AB0(wrapperArray, v2);
		    if ( wrapperArray[16].vector[10] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(586, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		      goto LABEL_26;
		    }
		  }
		  v4 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
		  if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		    v4 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
		  }
		  if ( !v4->static_fields->s_PossiblyInUse )
		  {
		    if ( !TypeInfo::UnityEngine::Rendering::DebugManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::DebugManager);
		    instance = UnityEngine::Rendering::DebugManager::get_instance(0LL);
		    if ( instance )
		    {
		      if ( instance->fields.m_EditorOpen )
		      {
		        v11 = 1;
		        goto LABEL_22;
		      }
		      if ( !TypeInfo::UnityEngine::Rendering::DebugManager->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::DebugManager);
		      v6 = UnityEngine::Rendering::DebugManager::get_instance(0LL);
		      v7 = v6;
		      if ( v6 )
		      {
		        v8 = TypeInfo::UnityEngine::Object;
		        m_Root = v6->fields.m_Root;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v8 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v8 = TypeInfo::UnityEngine::Object;
		          }
		        }
		        if ( !m_Root )
		          goto LABEL_20;
		        if ( !v8->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v8);
		        if ( !m_Root->fields._.m_CachedPtr )
		        {
		LABEL_20:
		          activeInHierarchy = 0;
		LABEL_21:
		          v11 = activeInHierarchy;
		LABEL_22:
		          v12 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
		          if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		            v12 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
		          }
		          static_fields = v12->static_fields;
		          if ( !v11 )
		          {
		            static_fields->s_PossiblyInUse = 0;
		            return 0;
		          }
		          static_fields->s_PossiblyInUse = 1;
		          return 1;
		        }
		        wrapperArray = (ILFixDynamicMethodWrapper_2__Array *)v7->fields.m_Root;
		        if ( wrapperArray )
		        {
		          activeInHierarchy = UnityEngine::GameObject::get_activeInHierarchy((GameObject *)wrapperArray, 0LL);
		          goto LABEL_21;
		        }
		      }
		    }
		LABEL_26:
		    sub_1800D8260(wrapperArray, v2);
		  }
		  if ( !TypeInfo::UnityEngine::Rendering::DebugManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::DebugManager);
		  v16 = UnityEngine::Rendering::DebugManager::get_instance(0LL);
		  if ( !v16 )
		    goto LABEL_26;
		  if ( v16->fields.m_EditorOpen )
		    return 1;
		  if ( !TypeInfo::UnityEngine::Rendering::DebugManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::DebugManager);
		  v17 = UnityEngine::Rendering::DebugManager::get_instance(0LL);
		  if ( !v17 )
		    goto LABEL_26;
		  if ( UnityEngine::Rendering::DebugManager::get_displayRuntimeUI(v17, 0LL) )
		    return 1;
		  v18 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
		  if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		    v18 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
		  }
		  if ( !v18->static_fields->s_PossiblyInUse )
		    return 0;
		  if ( !v18->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v18);
		    v18 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
		  }
		  v19 = v18->static_fields;
		  v20 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c;
		  containers = (IEnumerable_1_System_Object_ *)v19->containers;
		  if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c);
		    v20 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c;
		  }
		  _9__14_0 = (Func_2_Object_Boolean_ *)v20->static_fields->__9__14_0;
		  if ( !_9__14_0 )
		  {
		    if ( !v20->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v20);
		      v20 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c;
		    }
		    v23 = (Object *)v20->static_fields->__9;
		    v24 = (Func_2_Object_Boolean_ *)sub_1800368D0(TypeInfo::System::Func<HG::Rendering::Runtime::IFrameSettingsHistoryContainer,bool>);
		    _9__14_0 = v24;
		    if ( !v24 )
		      goto LABEL_26;
		    System::Func<System::Object,bool>::Func(
		      v24,
		      v23,
		      MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c::_get_enabled_b__14_0,
		      0LL);
		    v25 = (PropertyInfo_1 *)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c->static_fields;
		    v25->monitor = (MonitorData *)_9__14_0;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c->static_fields->__9__14_0,
		      v26,
		      v25,
		      v27,
		      v31);
		  }
		  v28 = System::Linq::Enumerable::Any<System::Object>(
		          containers,
		          _9__14_0,
		          MethodInfo::System::Linq::Enumerable::Any<HG::Rendering::Runtime::IFrameSettingsHistoryContainer>);
		  v29 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
		  v30 = v28;
		  if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		    v29 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
		  }
		  result = v30;
		  v29->static_fields->s_PossiblyInUse = v30;
		  return result;
		}
		
	
		// Constructors
		static FrameSettingsHistory() {
			foldoutNames = default;
			columnNames = default;
			columnTooltips = default;
			attributes = default;
			attributesGroup = default;
			containers = default;
			s_PossiblyInUse = default;
		} // 0x00000001836FB1C0-0x00000001836FB750
		// FrameSettingsHistory()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::FrameSettingsHistory::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  String__Array *v4; // rbx
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  String__Array *v11; // rbx
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  __int64 v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  String__Array *v18; // rbx
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  Dictionary_2_System_Int32_System_Object_ *v22; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  Dictionary_2_System_Int32_System_Linq_IOrderedEnumerable_1_System_Collections_Generic_KeyValuePair_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_ *v25; // rbx
		  Type *v26; // rdx
		  PropertyInfo_1 *v27; // r8
		  Int32__Array **v28; // r9
		  HashSet_1_System_Object_ *v29; // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  HashSet_1_HG_Rendering_Runtime_IFrameSettingsHistoryContainer_ *v32; // rbx
		  Type *v33; // rdx
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  Dictionary_2_System_Int32Enum_System_Object_ *v36; // rax
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  Dictionary_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_ *v39; // rbx
		  Type *v40; // rdx
		  PropertyInfo_1 *v41; // r8
		  Int32__Array **v42; // r9
		  Dictionary_2_System_Int32_System_Object_ *v43; // rax
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  Dictionary_2_System_Int32_System_Linq_IOrderedEnumerable_1_System_Collections_Generic_KeyValuePair_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_ *v46; // rbx
		  Type *v47; // rdx
		  PropertyInfo_1 *v48; // r8
		  Int32__Array **v49; // r9
		  Dictionary_2_HG_Rendering_Runtime_FrameSettingsField_System_String_ *EnumNameMap; // r15
		  struct Il2CppType *v51; // rbx
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  Type *TypeFromHandle; // rsi
		  Dictionary_2_TKey_TValue_KeyCollection_System_Object_System_Boolean_ *Keys; // rax
		  Type *v56; // rdx
		  __int64 v57; // rcx
		  PropertyInfo_1 *v58; // r8
		  Int32__Array **v59; // r9
		  Dictionary_2_System_Object_System_Boolean_ *dictionary; // rbx
		  __int64 v61; // rdx
		  __int64 v62; // rcx
		  __int64 v63; // rcx
		  __int64 v64; // rcx
		  String *FullName_k__BackingField; // r8
		  __int64 v66; // rax
		  String *v67; // r9
		  Int32Enum__Enum clearDelegate; // ebx
		  Dictionary_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_ *attributes; // rdi
		  __int64 v70; // rdx
		  __int64 v71; // rcx
		  Object *Item; // r14
		  MemberInfo_1 *v73; // rax
		  Object *v74; // rax
		  __int64 v75; // rdx
		  __int64 v76; // rcx
		  MethodInfo *v77; // [rsp+20h] [rbp-48h] BYREF
		  SingleFieldAccessor v78; // [rsp+28h] [rbp-40h] BYREF
		
		  v1 = il2cpp_array_new_specific_1(TypeInfo::System::String, 4LL);
		  v4 = (String__Array *)v1;
		  if ( !v1 )
		    sub_1800D8260(v3, v2);
		  sub_180005370(v1, 0LL, "Rendering");
		  sub_180005370(v4, 1LL, "Lighting");
		  sub_180005370(v4, 2LL, "Async Compute");
		  sub_180005370(v4, 3LL, "Light Loop");
		  TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->foldoutNames = v4;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields,
		    v5,
		    v6,
		    v7,
		    v77);
		  v8 = il2cpp_array_new_specific_1(TypeInfo::System::String, 4LL);
		  v11 = (String__Array *)v8;
		  if ( !v8 )
		    sub_1800D8260(v10, v9);
		  sub_180005370(v8, 0LL, "Debug");
		  sub_180005370(v11, 1LL, "Sanitized");
		  sub_180005370(v11, 2LL, "Overridden");
		  sub_180005370(v11, 3LL, "Default");
		  TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->columnNames = v11;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->columnNames,
		    v12,
		    v13,
		    v14,
		    v77);
		  v15 = il2cpp_array_new_specific_1(TypeInfo::System::String, 4LL);
		  v18 = (String__Array *)v15;
		  if ( !v15 )
		    sub_1800D8260(v17, v16);
		  sub_180005370(v15, 0LL, "Displays Frame Setting values you can modify for the selected Camera.");
		  sub_180005370(
		    v18,
		    1LL,
		    "Displays the Frame Setting values that the selected Camera uses after Unity checks to see if your HGRP Asset supports them.");
		  sub_180005370(v18, 2LL, "Displays the Frame Setting values that the selected Camera overrides.");
		  sub_180005370(v18, 3LL, "Displays the default Frame Setting values in your current HGRP Asset.");
		  TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->columnTooltips = v18;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->columnTooltips,
		    v19,
		    v20,
		    v21,
		    v77);
		  v22 = (Dictionary_2_System_Int32_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>);
		  v25 = (Dictionary_2_System_Int32_System_Linq_IOrderedEnumerable_1_System_Collections_Generic_KeyValuePair_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_ *)v22;
		  if ( !v22 )
		    sub_1800D8260(v24, v23);
		  System::Collections::Generic::Dictionary<int,System::Object>::Dictionary(
		    v22,
		    MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::Dictionary);
		  TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->attributesGroup = v25;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->attributesGroup,
		    v26,
		    v27,
		    v28,
		    v77);
		  v29 = (HashSet_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::IFrameSettingsHistoryContainer>);
		  v32 = (HashSet_1_HG_Rendering_Runtime_IFrameSettingsHistoryContainer_ *)v29;
		  if ( !v29 )
		    sub_1800D8260(v31, v30);
		  System::Collections::Generic::HashSet<System::Object>::HashSet(
		    v29,
		    MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::IFrameSettingsHistoryContainer>::HashSet);
		  TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->containers = v32;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->containers,
		    v33,
		    v34,
		    v35,
		    v77);
		  v36 = (Dictionary_2_System_Int32Enum_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>);
		  v39 = (Dictionary_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_ *)v36;
		  if ( !v36 )
		    sub_1800D8260(v38, v37);
		  System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::Dictionary(
		    v36,
		    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::Dictionary);
		  TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->attributes = v39;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->attributes,
		    v40,
		    v41,
		    v42,
		    v77);
		  v43 = (Dictionary_2_System_Int32_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>);
		  v46 = (Dictionary_2_System_Int32_System_Linq_IOrderedEnumerable_1_System_Collections_Generic_KeyValuePair_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_ *)v43;
		  if ( !v43 )
		    sub_1800D8260(v45, v44);
		  System::Collections::Generic::Dictionary<int,System::Object>::Dictionary(
		    v43,
		    MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::Dictionary);
		  TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->attributesGroup = v46;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->attributesGroup,
		    v47,
		    v48,
		    v49,
		    v77);
		  if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute);
		  EnumNameMap = HG::Rendering::Runtime::FrameSettingsFieldAttribute::GetEnumNameMap(0LL);
		  v51 = TypeRef::HG::Rendering::Runtime::FrameSettingsField;
		  if ( !TypeInfo::System::Type->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Type);
		  TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v51, 0LL);
		  if ( !EnumNameMap )
		    sub_1800D8260(v53, v52);
		  Keys = System::Collections::Generic::Dictionary<System::Object,bool>::get_Keys(
		           (Dictionary_2_System_Object_System_Boolean_ *)EnumNameMap,
		           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::get_Keys);
		  if ( !Keys )
		    sub_1800D8260(v57, v56);
		  dictionary = Keys->fields._dictionary;
		  *(_OWORD *)&v78.monitor = 0LL;
		  v78.klass = (SingleFieldAccessor__Class *)dictionary;
		  sub_18002D1B0(&v78, v56, v58, v59, v77);
		  if ( !dictionary )
		    sub_1800D8260(v62, v61);
		  HIDWORD(v78.monitor) = dictionary->fields._version;
		  v63 = 0LL;
		  LODWORD(v78.monitor) = 0;
		  LODWORD(v78.fields._.getValueDelegate) = 0;
		  *(_OWORD *)&v78.fields._.descriptor = *(_OWORD *)&v78.klass;
		  v78.fields.clearDelegate = (Action_1_Google_Protobuf_IMessage_ *)v78.fields._.getValueDelegate;
		  v78.klass = 0LL;
		  v78.monitor = (MonitorData *)&v78.fields._.descriptor;
		  try
		  {
		LABEL_16:
		    if ( !v78.fields._.descriptor )
		      sub_1800D8250(v63, 0LL);
		    if ( HIDWORD(v78.fields.setValueDelegate) != HIDWORD(v78.fields._.descriptor->fields.enumType) )
		      System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		    LODWORD(v64) = v78.fields.setValueDelegate;
		    while ( (unsigned int)v64 < LODWORD(v78.fields._.descriptor->fields._._File_k__BackingField) )
		    {
		      FullName_k__BackingField = v78.fields._.descriptor->fields._._FullName_k__BackingField;
		      v66 = (int)v64;
		      v64 = (unsigned int)(v64 + 1);
		      LODWORD(v78.fields.setValueDelegate) = v64;
		      if ( !FullName_k__BackingField )
		        sub_1800D8250(v64, v78.fields._.descriptor);
		      if ( (unsigned int)v66 >= LODWORD(FullName_k__BackingField[1].klass) )
		        sub_1800D2AA0(v64, v78.fields._.descriptor, FullName_k__BackingField);
		      v67 = &FullName_k__BackingField[v66];
		      if ( SLODWORD(v67[1].monitor) >= 0 )
		      {
		        LODWORD(v78.fields.clearDelegate) = v67[1].fields._stringLength;
		        clearDelegate = (Int32Enum__Enum)v78.fields.clearDelegate;
		        attributes = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->attributes;
		        Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
		                 (Dictionary_2_System_Int32Enum_System_Object_ *)EnumNameMap,
		                 (Int32Enum__Enum)v78.fields.clearDelegate,
		                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::get_Item);
		        if ( !TypeFromHandle )
		          sub_1800D8250(v71, v70);
		        sub_1800049A0(TypeFromHandle->klass);
		        v73 = (MemberInfo_1 *)((__int64 (__fastcall *)(Type *, Object *, __int64, Il2CppMethodPointer))TypeFromHandle->klass->vtable.__unknown_22.method)(
		                                TypeFromHandle,
		                                Item,
		                                28LL,
		                                TypeFromHandle->klass->vtable.GetFields.methodPtr);
		        v74 = System::Reflection::CustomAttributeExtensions::GetCustomAttribute<System::Object>(
		                v73,
		                MethodInfo::System::Reflection::CustomAttributeExtensions::GetCustomAttribute<HG::Rendering::Runtime::FrameSettingsFieldAttribute>);
		        if ( !attributes )
		          sub_1800D8250(v76, v75);
		        System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::set_Item(
		          (Dictionary_2_System_Int32Enum_System_Object_ *)attributes,
		          clearDelegate,
		          v74,
		          MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::set_Item);
		        goto LABEL_16;
		      }
		    }
		    LODWORD(v78.fields.setValueDelegate) = LODWORD(v78.fields._.descriptor->fields._._File_k__BackingField) + 1;
		    LODWORD(v78.fields.clearDelegate) = 0;
		  }
		  catch ( Il2CppExceptionWrapper *v77 )
		  {
		    v78.klass = (SingleFieldAccessor__Class *)v77->methodPointer;
		    if ( v78.klass )
		      sub_18007E1E0(v78.klass);
		  }
		}
		
	
		// Methods
		[IDTag(1)]
		public static void AggregateFrameSettings(ref FrameSettings aggregatedFrameSettings, Camera camera, HGAdditionalCameraData additionalData, HGRenderPipelineAsset hgrpAsset, HGRenderPipelineAsset defaultHgrpAsset) {} // 0x0000000189C05610-0x0000000189C05788
		// Void AggregateFrameSettings(FrameSettings ByRef, Camera, HGAdditionalCameraData, HGRenderPipelineAsset, HGRenderPipelineAsset)
		void HG::Rendering::Runtime::FrameSettingsHistory::AggregateFrameSettings(
		        FrameSettings *aggregatedFrameSettings,
		        Camera *camera,
		        HGAdditionalCameraData *additionalData,
		        HGRenderPipelineAsset *hgrpAsset,
		        HGRenderPipelineAsset *defaultHgrpAsset,
		        MethodInfo *method)
		{
		  HGRenderPipelineGlobalSettings *instance; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int64 defaultFrameSettings; // rdx
		  FrameSettings *v13; // r14
		  RenderPipelineSettings supportedFeatures; // [rsp+40h] [rbp-E8h] BYREF
		  RenderPipelineSettings v15; // [rsp+B0h] [rbp-78h] BYREF
		
		  sub_18033B9D0(&supportedFeatures, 0LL, 112LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(683, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
		    instance = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_instance(0LL);
		    if ( additionalData )
		      defaultFrameSettings = (unsigned int)additionalData->fields.defaultFrameSettings;
		    else
		      defaultFrameSettings = 0LL;
		    if ( instance )
		    {
		      v13 = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::GetDefaultFrameSettings(
		              instance,
		              (FrameSettingsRenderType__Enum)defaultFrameSettings,
		              0LL);
		      if ( hgrpAsset )
		      {
		        supportedFeatures = *HG::Rendering::Runtime::HGRenderPipelineAsset::get_currentPlatformRenderPipelineSettings(
		                               &v15,
		                               hgrpAsset,
		                               0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		        HG::Rendering::Runtime::FrameSettingsHistory::AggregateFrameSettings(
		          aggregatedFrameSettings,
		          camera,
		          (IFrameSettingsHistoryContainer *)additionalData,
		          v13,
		          &supportedFeatures,
		          0LL);
		        return;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(Patch, defaultFrameSettings);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(683, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_273(
		    Patch,
		    aggregatedFrameSettings,
		    (Object *)camera,
		    (Object *)additionalData,
		    (Object *)hgrpAsset,
		    (Object *)defaultHgrpAsset,
		    0LL);
		}
		
		[IDTag(0)]
		public static void AggregateFrameSettings(ref FrameSettings aggregatedFrameSettings, Camera camera, IFrameSettingsHistoryContainer historyContainer, ref FrameSettings defaultFrameSettings, [IsReadOnly] in RenderPipelineSettings supportedFeatures) {} // 0x0000000189C05278-0x0000000189C05610
		// Void AggregateFrameSettings(FrameSettings ByRef, Camera, IFrameSettingsHistoryContainer, FrameSettings ByRef, RenderPipelineSettings ByRef)
		void HG::Rendering::Runtime::FrameSettingsHistory::AggregateFrameSettings(
		        FrameSettings *aggregatedFrameSettings,
		        Camera *camera,
		        IFrameSettingsHistoryContainer *historyContainer,
		        FrameSettings *defaultFrameSettings,
		        RenderPipelineSettings *supportedFeatures,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  int v12; // edi
		  __int64 v13; // rax
		  BitArray128 bitDatas; // xmm1
		  __int64 v15; // xmm0_8
		  bool v16; // r14
		  char hasCustomFrameSettings; // al
		  __int64 v18; // rdx
		  __int64 v19; // r8
		  FrameSettingsOverrideMask v20; // xmm0
		  BitArray128 v21; // xmm6
		  FrameSettingsOverrideMask v22; // xmm0
		  BitArray128 v23; // xmm0
		  __int64 v24; // xmm1_8
		  bool v25; // al
		  __int64 v26; // xmm1_8
		  bool v27; // al
		  __int64 v28; // xmm6_8
		  BitArray128 v29; // xmm7
		  __int128 v30; // xmm3
		  __int128 v31; // xmm4
		  BitArray128 v32; // xmm5
		  __int128 v33; // xmm1
		  __int64 v34; // xmm0_8
		  BitArray128 v35; // xmm2
		  __int128 v36; // xmm1
		  FrameSettings v37; // [rsp+48h] [rbp-C0h] BYREF
		  FrameSettings v38; // [rsp+68h] [rbp-A0h] BYREF
		  __m256i v39; // [rsp+88h] [rbp-80h] BYREF
		  BitArray128 v40; // [rsp+A8h] [rbp-60h]
		  BitArray128 v41; // [rsp+B8h] [rbp-50h]
		  _OWORD sanitizedFrameSettings[2]; // [rsp+C8h] [rbp-40h] BYREF
		  __int64 v43; // [rsp+E8h] [rbp-20h]
		  FrameSettingsOverrideMask v44; // [rsp+F8h] [rbp-10h] BYREF
		  __m256i v45; // [rsp+108h] [rbp+0h] BYREF
		  BitArray128 v46; // [rsp+128h] [rbp+20h]
		  BitArray128 v47; // [rsp+138h] [rbp+30h]
		  __int128 v48; // [rsp+148h] [rbp+40h]
		  __int128 v49; // [rsp+158h] [rbp+50h]
		  __int64 v50; // [rsp+168h] [rbp+60h]
		
		  sub_18033B9D0(&v39, 0LL, 104LL);
		  v12 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(685, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(685, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(
		        Patch,
		        aggregatedFrameSettings,
		        (Object *)camera,
		        (Object *)historyContainer,
		        defaultFrameSettings,
		        supportedFeatures,
		        0LL);
		      return;
		    }
		LABEL_16:
		    sub_1800D8260(Patch, v10);
		  }
		  if ( !historyContainer )
		    goto LABEL_16;
		  v13 = sub_189C04454(&v45, historyContainer);
		  v39 = *(__m256i *)v13;
		  v40 = *(BitArray128 *)(v13 + 32);
		  v41 = *(BitArray128 *)(v13 + 48);
		  sanitizedFrameSettings[0] = *(_OWORD *)(v13 + 64);
		  sanitizedFrameSettings[1] = *(_OWORD *)(v13 + 80);
		  bitDatas = defaultFrameSettings->bitDatas;
		  v43 = *(_QWORD *)(v13 + 96);
		  v15 = *(_QWORD *)&defaultFrameSettings->materialQuality;
		  v16 = 0;
		  aggregatedFrameSettings->bitDatas = bitDatas;
		  *(_QWORD *)&aggregatedFrameSettings->materialQuality = v15;
		  if ( *(_DWORD *)&historyContainer->klass->_1.method_count == 3431 )
		    hasCustomFrameSettings = HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IFrameSettingsHistoryContainer_get_hasCustomFrameSettings(
		                               (HGAdditionalCameraData *)historyContainer,
		                               0LL);
		  else
		    hasCustomFrameSettings = sub_180042E60(4LL, TypeInfo::HG::Rendering::Runtime::IFrameSettingsHistoryContainer);
		  if ( hasCustomFrameSettings )
		  {
		    if ( *(_DWORD *)&historyContainer->klass->_1.method_count == 3431 )
		      HG::Rendering::Runtime::HGAdditionalCameraData::HG_Rendering_Runtime_IFrameSettingsHistoryContainer_get_frameSettings(
		        &v38,
		        (HGAdditionalCameraData *)historyContainer,
		        0LL);
		    else
		      sub_1808B04F0(&v38, v18, v19, historyContainer);
		    v20 = *(FrameSettingsOverrideMask *)sub_189C04488(&v37, historyContainer);
		    v37 = v38;
		    v44 = v20;
		    HG::Rendering::Runtime::FrameSettings::Override(aggregatedFrameSettings, &v37, &v44, 0LL);
		    v21 = v40;
		    v22 = *(FrameSettingsOverrideMask *)sub_189C04488(&v37, historyContainer);
		    v37.bitDatas = v21;
		    v44 = v22;
		    v16 = ClipperLib::IntPoint::op_Inequality((IntPoint *)&v37, (IntPoint *)&v44, 0LL);
		    v40 = *(BitArray128 *)sub_189C04488(&v37, historyContainer);
		  }
		  v23 = aggregatedFrameSettings->bitDatas;
		  v39.m256i_i64[3] = *(_QWORD *)&aggregatedFrameSettings->materialQuality;
		  *(BitArray128 *)&v39.m256i_u64[1] = v23;
		  HG::Rendering::Runtime::FrameSettings::Sanitize(aggregatedFrameSettings, camera, supportedFeatures, 0LL);
		  v24 = *(_QWORD *)&aggregatedFrameSettings->materialQuality;
		  v38.bitDatas = aggregatedFrameSettings->bitDatas;
		  *(_QWORD *)&v38.materialQuality = v24;
		  v37 = *(FrameSettings *)((char *)sanitizedFrameSettings + 8);
		  v25 = HG::Rendering::Runtime::FrameSettings::op_Inequality(&v37, &v38, 0LL);
		  v26 = *(_QWORD *)&aggregatedFrameSettings->materialQuality;
		  v38.bitDatas = aggregatedFrameSettings->bitDatas;
		  *(_QWORD *)&v38.materialQuality = v26;
		  v37.bitDatas = v41;
		  LOBYTE(v43) = v25;
		  *(_QWORD *)&v37.materialQuality = *(_QWORD *)&sanitizedFrameSettings[0];
		  v27 = HG::Rendering::Runtime::FrameSettings::op_Inequality(&v37, &v38, 0LL);
		  v28 = v43;
		  v29 = aggregatedFrameSettings->bitDatas;
		  v30 = *(_OWORD *)v39.m256i_i8;
		  v31 = *(_OWORD *)&v39.m256i_u64[2];
		  v32 = v40;
		  v50 = v43;
		  v47 = v41;
		  v23.data1 = *(_QWORD *)&aggregatedFrameSettings->materialQuality;
		  LOBYTE(v12) = (_BYTE)v43 == 0;
		  v48 = sanitizedFrameSettings[0];
		  v33 = sanitizedFrameSettings[1];
		  v45 = v39;
		  v46 = v40;
		  v49 = sanitizedFrameSettings[1];
		  v41 = v29;
		  *(_QWORD *)&sanitizedFrameSettings[0] = v23.data1;
		  if ( v12 | (v16 || v27) )
		  {
		    v34 = *(_QWORD *)&sanitizedFrameSettings[0];
		    v35 = v29;
		    *((_QWORD *)&sanitizedFrameSettings[1] + 1) = *(_QWORD *)&sanitizedFrameSettings[0];
		    v45 = v39;
		    v46 = v40;
		    v49 = v33;
		    v50 = v43;
		    *(BitArray128 *)((char *)sanitizedFrameSettings + 8) = v29;
		  }
		  else
		  {
		    HG::Rendering::Runtime::FrameSettings::Sanitize(
		      (FrameSettings *)((char *)sanitizedFrameSettings + 8),
		      camera,
		      supportedFeatures,
		      0LL);
		    v34 = *((_QWORD *)&sanitizedFrameSettings[1] + 1);
		    v35 = *(BitArray128 *)((char *)sanitizedFrameSettings + 8);
		    v32 = v40;
		    v31 = *(_OWORD *)&v39.m256i_u64[2];
		    v30 = *(_OWORD *)v39.m256i_i8;
		    v28 = v43;
		    v29 = v41;
		  }
		  v36 = sanitizedFrameSettings[1];
		  aggregatedFrameSettings->bitDatas = v35;
		  *(_QWORD *)&aggregatedFrameSettings->materialQuality = v34;
		  v48 = sanitizedFrameSettings[0];
		  *(_OWORD *)v45.m256i_i8 = v30;
		  *(_OWORD *)&v45.m256i_u64[2] = v31;
		  v46 = v32;
		  v47 = v29;
		  v49 = v36;
		  v50 = v28;
		  sub_189C044F8(historyContainer, &v45);
		}
		
		private static DebugUI.HistoryBoolField GenerateHistoryBoolField(IFrameSettingsHistoryContainer frameSettingsContainer, FrameSettingsField field, FrameSettingsFieldAttribute attribute) => default; // 0x0000000189C05F60-0x0000000189C061C8
		// DebugUI+HistoryBoolField GenerateHistoryBoolField(IFrameSettingsHistoryContainer, FrameSettingsField, FrameSettingsFieldAttribute)
		DebugUI_HistoryBoolField *HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryBoolField(
		        IFrameSettingsHistoryContainer *frameSettingsContainer,
		        FrameSettingsField__Enum field,
		        FrameSettingsFieldAttribute *attribute,
		        MethodInfo *method)
		{
		  __int64 v7; // rax
		  Type *v8; // rdx
		  __int64 v9; // rcx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  __int64 v12; // rbx
		  String *v13; // rbp
		  int32_t v14; // edi
		  DebugUI_BoolField *v15; // rax
		  DebugUI_BoolField *v16; // rdi
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  Int32__Array **tooltip; // r9
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Func_1_Boolean_ *v23; // rax
		  Func_1_Boolean_ *v24; // rsi
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  Action_1_Boolean_ *v28; // rax
		  Action_1_Boolean_ *v29; // rsi
		  Type *v30; // rdx
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  __int64 v33; // rsi
		  Func_1_Boolean_ *v34; // rax
		  Func_1_Boolean_ *v35; // rbp
		  Func_1_Boolean_ *v36; // rax
		  Func_1_Boolean_ *v37; // rbp
		  Func_1_Boolean_ *v38; // rax
		  Func_1_Boolean_ *v39; // rbp
		  Type *v40; // rdx
		  PropertyInfo_1 *v41; // r8
		  Int32__Array **v42; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v45; // [rsp+20h] [rbp-18h]
		  MethodInfo *v46; // [rsp+20h] [rbp-18h]
		  MethodInfo *v47; // [rsp+20h] [rbp-18h]
		  MethodInfo *v48; // [rsp+20h] [rbp-18h]
		  MethodInfo *v49; // [rsp+20h] [rbp-18h]
		  MethodInfo *v50; // [rsp+20h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3701, 0LL) )
		  {
		    v7 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0);
		    v12 = v7;
		    if ( v7 )
		    {
		      *(_QWORD *)(v7 + 16) = frameSettingsContainer;
		      sub_18002D1B0((SingleFieldAccessor *)(v7 + 16), v8, v10, v11, v45);
		      *(_DWORD *)(v12 + 24) = field;
		      v13 = (String *)"";
		      v14 = 0;
		      if ( attribute )
		      {
		        while ( v14 < attribute->fields.indentLevel )
		        {
		          v13 = System::String::Concat(v13, (String *)"  ", 0LL);
		          ++v14;
		        }
		        v15 = (DebugUI_BoolField *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DebugUI::HistoryBoolField);
		        v16 = v15;
		        if ( v15 )
		        {
		          UnityEngine::Rendering::DebugUI::BoolField::BoolField(v15, 0LL);
		          v16->fields._._._displayName_k__BackingField = System::String::Concat(
		                                                           v13,
		                                                           attribute->fields.displayedName,
		                                                           0LL);
		          sub_18002D1B0((SingleFieldAccessor *)&v16->fields._._._displayName_k__BackingField, v17, v18, v19, v46);
		          tooltip = (Int32__Array **)attribute->fields.tooltip;
		          v16->fields._._._tooltip_k__BackingField = (String *)tooltip;
		          sub_18002D1B0((SingleFieldAccessor *)&v16->fields._._._tooltip_k__BackingField, v21, v22, tooltip, v47);
		          v23 = (Func_1_Boolean_ *)sub_18002C620(TypeInfo::System::Func<bool>);
		          v24 = v23;
		          if ( v23 )
		          {
		            System::Func<bool>::Func(
		              v23,
		              (Object *)v12,
		              MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__0,
		              0LL);
		            v16->fields._._getter_k__BackingField = v24;
		            sub_18002D1B0((SingleFieldAccessor *)&v16->fields._._getter_k__BackingField, v25, v26, v27, v48);
		            v28 = (Action_1_Boolean_ *)sub_18002C620(TypeInfo::System::Action<bool>);
		            v29 = v28;
		            if ( v28 )
		            {
		              System::Action<bool>::Action(
		                v28,
		                (Object *)v12,
		                MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__1,
		                0LL);
		              v16->fields._._setter_k__BackingField = v29;
		              sub_18002D1B0((SingleFieldAccessor *)&v16->fields._._setter_k__BackingField, v30, v31, v32, v49);
		              v33 = il2cpp_array_new_specific_1(TypeInfo::System::Func<bool>, 3LL);
		              v34 = (Func_1_Boolean_ *)sub_18002C620(TypeInfo::System::Func<bool>);
		              v35 = v34;
		              if ( v34 )
		              {
		                System::Func<bool>::Func(
		                  v34,
		                  (Object *)v12,
		                  MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__2,
		                  0LL);
		                if ( v33 )
		                {
		                  sub_180378FEC(v33, 0LL, v35);
		                  v36 = (Func_1_Boolean_ *)sub_18002C620(TypeInfo::System::Func<bool>);
		                  v37 = v36;
		                  if ( v36 )
		                  {
		                    System::Func<bool>::Func(
		                      v36,
		                      (Object *)v12,
		                      MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__3,
		                      0LL);
		                    sub_180378FEC(v33, 1LL, v37);
		                    v38 = (Func_1_Boolean_ *)sub_18002C620(TypeInfo::System::Func<bool>);
		                    v39 = v38;
		                    if ( v38 )
		                    {
		                      System::Func<bool>::Func(
		                        v38,
		                        (Object *)v12,
		                        MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass18_0::_GenerateHistoryBoolField_b__4,
		                        0LL);
		                      sub_180378FEC(v33, 2LL, v39);
		                      v16[1].klass = (DebugUI_BoolField__Class *)v33;
		                      sub_18002D1B0((SingleFieldAccessor *)&v16[1], v40, v41, v42, v50);
		                      return (DebugUI_HistoryBoolField *)v16;
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_15:
		    sub_1800D8260(v9, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3701, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1294(
		           Patch,
		           (Object *)frameSettingsContainer,
		           field,
		           (Object *)attribute,
		           0LL);
		}
		
		private static DebugUI.HistoryEnumField GenerateHistoryEnumField(IFrameSettingsHistoryContainer frameSettingsContainer, FrameSettingsField field, FrameSettingsFieldAttribute attribute, System.Type autoEnum) => default; // 0x0000000189C061C8-0x0000000189C06540
		// DebugUI+HistoryEnumField GenerateHistoryEnumField(IFrameSettingsHistoryContainer, FrameSettingsField, FrameSettingsFieldAttribute, Type)
		DebugUI_HistoryEnumField *HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryEnumField(
		        IFrameSettingsHistoryContainer *frameSettingsContainer,
		        FrameSettingsField__Enum field,
		        FrameSettingsFieldAttribute *attribute,
		        Type *autoEnum,
		        MethodInfo *method)
		{
		  __int64 v9; // rax
		  Type *v10; // rdx
		  __int64 v11; // rcx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  __int64 v14; // rdi
		  String *v15; // rbp
		  int32_t v16; // ebx
		  DebugUI_EnumField *v17; // rax
		  DebugUI_EnumField *v18; // rbx
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  Int32__Array **tooltip; // r9
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Func_1_Int32_ *v25; // rax
		  Func_1_Int32_ *v26; // rsi
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  Action_1_Int32_ *v30; // rax
		  Action_1_Int32_ *v31; // rsi
		  Type *v32; // rdx
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **v34; // r9
		  Func_1_Int32_ *v35; // rax
		  Func_1_Int32_ *v36; // rsi
		  Type *v37; // rdx
		  PropertyInfo_1 *v38; // r8
		  Int32__Array **v39; // r9
		  Type *v40; // rdx
		  PropertyInfo_1 *v41; // r8
		  Int32__Array **v42; // r9
		  Action_1_Int32_ *_9__19_3; // rsi
		  Object *v44; // rbp
		  Action_1_Int32_ *v45; // rax
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v47; // r8
		  Int32__Array **v48; // r9
		  __int64 v49; // rsi
		  Func_1_Int32_ *v50; // rax
		  Func_1_Int32_ *v51; // rbp
		  Func_1_Int32_ *v52; // rax
		  Func_1_Int32_ *v53; // rbp
		  Func_1_Int32_ *v54; // rax
		  Func_1_Int32_ *v55; // rbp
		  Type *v56; // rdx
		  PropertyInfo_1 *v57; // r8
		  Int32__Array **v58; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-18h]
		  MethodInfo *P3a; // [rsp+20h] [rbp-18h]
		  MethodInfo *P3g; // [rsp+20h] [rbp-18h]
		  MethodInfo *P3b; // [rsp+20h] [rbp-18h]
		  MethodInfo *P3c; // [rsp+20h] [rbp-18h]
		  MethodInfo *P3d; // [rsp+20h] [rbp-18h]
		  MethodInfo *P3e; // [rsp+20h] [rbp-18h]
		  MethodInfo *P3f; // [rsp+20h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3708, 0LL) )
		  {
		    v9 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0);
		    v14 = v9;
		    if ( v9 )
		    {
		      *(_QWORD *)(v9 + 16) = frameSettingsContainer;
		      sub_18002D1B0((SingleFieldAccessor *)(v9 + 16), v10, v12, v13, P3);
		      *(_DWORD *)(v14 + 24) = field;
		      v15 = (String *)"";
		      v16 = 0;
		      if ( attribute )
		      {
		        while ( v16 < attribute->fields.indentLevel )
		        {
		          v15 = System::String::Concat(v15, (String *)"  ", 0LL);
		          ++v16;
		        }
		        v17 = (DebugUI_EnumField *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DebugUI::HistoryEnumField);
		        v18 = v17;
		        if ( v17 )
		        {
		          UnityEngine::Rendering::DebugUI::EnumField::EnumField(v17, 0LL);
		          v18->fields._._._displayName_k__BackingField = System::String::Concat(
		                                                           v15,
		                                                           attribute->fields.displayedName,
		                                                           0LL);
		          sub_18002D1B0((SingleFieldAccessor *)&v18->fields._._._displayName_k__BackingField, v19, v20, v21, P3a);
		          tooltip = (Int32__Array **)attribute->fields.tooltip;
		          v18->fields._._._tooltip_k__BackingField = (String *)tooltip;
		          sub_18002D1B0((SingleFieldAccessor *)&v18->fields._._._tooltip_k__BackingField, v23, v24, tooltip, P3g);
		          v25 = (Func_1_Int32_ *)sub_18002C620(TypeInfo::System::Func<int>);
		          v26 = v25;
		          if ( v25 )
		          {
		            System::Func<int>::Func(
		              v25,
		              (Object *)v14,
		              MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__0,
		              0LL);
		            v18->fields._._getter_k__BackingField = v26;
		            sub_18002D1B0((SingleFieldAccessor *)&v18->fields._._getter_k__BackingField, v27, v28, v29, P3b);
		            v30 = (Action_1_Int32_ *)sub_18002C620(TypeInfo::System::Action<int>);
		            v31 = v30;
		            if ( v30 )
		            {
		              System::Action<int>::Action(
		                v30,
		                (Object *)v14,
		                MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__1,
		                0LL);
		              v18->fields._._setter_k__BackingField = v31;
		              sub_18002D1B0((SingleFieldAccessor *)&v18->fields._._setter_k__BackingField, v32, v33, v34, P3c);
		              UnityEngine::Rendering::DebugUI::EnumField::set_autoEnum(v18, autoEnum, 0LL);
		              v35 = (Func_1_Int32_ *)sub_18002C620(TypeInfo::System::Func<int>);
		              v36 = v35;
		              if ( v35 )
		              {
		                System::Func<int>::Func(
		                  v35,
		                  (Object *)v14,
		                  MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__2,
		                  0LL);
		                v18->fields._getIndex_k__BackingField = v36;
		                sub_18002D1B0((SingleFieldAccessor *)&v18->fields._getIndex_k__BackingField, v37, v38, v39, P3d);
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c);
		                _9__19_3 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c->static_fields->__9__19_3;
		                if ( !_9__19_3 )
		                {
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c);
		                  v44 = (Object *)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c->static_fields->__9;
		                  v45 = (Action_1_Int32_ *)sub_18002C620(TypeInfo::System::Action<int>);
		                  _9__19_3 = v45;
		                  if ( !v45 )
		                    goto LABEL_19;
		                  System::Action<int>::Action(
		                    v45,
		                    v44,
		                    MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c::_GenerateHistoryEnumField_b__19_3,
		                    0LL);
		                  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c->static_fields;
		                  static_fields->fields._impl.value = _9__19_3;
		                  sub_18002D1B0(
		                    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c->static_fields->__9__19_3,
		                    static_fields,
		                    v47,
		                    v48,
		                    P3e);
		                }
		                v18->fields._setIndex_k__BackingField = _9__19_3;
		                sub_18002D1B0((SingleFieldAccessor *)&v18->fields._setIndex_k__BackingField, v40, v41, v42, P3e);
		                v49 = il2cpp_array_new_specific_1(TypeInfo::System::Func<int>, 3LL);
		                v50 = (Func_1_Int32_ *)sub_18002C620(TypeInfo::System::Func<int>);
		                v51 = v50;
		                if ( v50 )
		                {
		                  System::Func<int>::Func(
		                    v50,
		                    (Object *)v14,
		                    MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__4,
		                    0LL);
		                  if ( v49 )
		                  {
		                    sub_180378FEC(v49, 0LL, v51);
		                    v52 = (Func_1_Int32_ *)sub_18002C620(TypeInfo::System::Func<int>);
		                    v53 = v52;
		                    if ( v52 )
		                    {
		                      System::Func<int>::Func(
		                        v52,
		                        (Object *)v14,
		                        MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__5,
		                        0LL);
		                      sub_180378FEC(v49, 1LL, v53);
		                      v54 = (Func_1_Int32_ *)sub_18002C620(TypeInfo::System::Func<int>);
		                      v55 = v54;
		                      if ( v54 )
		                      {
		                        System::Func<int>::Func(
		                          v54,
		                          (Object *)v14,
		                          MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass19_0::_GenerateHistoryEnumField_b__6,
		                          0LL);
		                        sub_180378FEC(v49, 2LL, v55);
		                        v18[1].klass = (DebugUI_EnumField__Class *)v49;
		                        sub_18002D1B0((SingleFieldAccessor *)&v18[1], v56, v57, v58, P3f);
		                        return (DebugUI_HistoryEnumField *)v18;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_19:
		    sub_1800D8260(v11, v10);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3708, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1295(
		           Patch,
		           (Object *)frameSettingsContainer,
		           field,
		           (Object *)attribute,
		           (Object *)autoEnum,
		           0LL);
		}
		
		private static ObservableList<DebugUI.Widget> GenerateHistoryArea(IFrameSettingsHistoryContainer frameSettingsContainer, int groupIndex) => default; // 0x0000000189C05A40-0x0000000189C05F60
		// ObservableList`1[DebugUI+Widget] GenerateHistoryArea(IFrameSettingsHistoryContainer, Int32)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		ObservableList_1_DebugUI_Widget_ *HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryArea(
		        IFrameSettingsHistoryContainer *frameSettingsContainer,
		        int32_t groupIndex,
		        MethodInfo *method)
		{
		  __int64 v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // rdi
		  __int64 v9; // rdx
		  FrameSettingsHistory__StaticFields *static_fields; // rcx
		  __int64 v11; // rdx
		  FrameSettingsHistory__StaticFields *v12; // rcx
		  __int64 v13; // rdx
		  struct FrameSettingsHistory__Class *v14; // rcx
		  FrameSettingsHistory__StaticFields *v15; // rax
		  Dictionary_2_System_Int32_System_Object_ *attributesGroup; // r14
		  int32_t v17; // r12d
		  IEnumerable_1_KeyValuePair_2_System_Object_System_Object_ *attributes; // rsi
		  Predicate_1_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_ *v19; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *v22; // rbx
		  IEnumerable_1_KeyValuePair_2_System_Object_System_Object_ *v23; // rsi
		  Func_2_System_Collections_Generic_KeyValuePair_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Int32_ *_9__20_1; // rbx
		  Object *v25; // r15
		  Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Int32Enum_ *v26; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  Type *v29; // rdx
		  PropertyInfo_1 *v30; // r8
		  Int32__Array **v31; // r9
		  Object *v32; // rbx
		  __int64 v33; // rdx
		  FrameSettingsHistory__StaticFields *v34; // rcx
		  ObservableList_1_System_Object_ *v35; // rax
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  ObservableList_1_DebugUI_Widget_ *v38; // rbx
		  __int64 v39; // rdx
		  FrameSettingsHistory__StaticFields *v40; // rcx
		  int32_t v41; // edi
		  Object *Item; // rax
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  __int64 v45; // rdx
		  __int64 type; // rcx
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  __int64 v49; // rax
		  __int64 v50; // rcx
		  __m128i v51; // xmm6
		  FrameSettingsFieldAttribute *v52; // rdi
		  Type *EnumTypeByField; // rax
		  Object *HistoryBoolField; // rax
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  __int64 v59; // rax
		  __int64 v60; // rdx
		  __int64 v61; // rcx
		  InvalidEnumArgumentException *v62; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v64; // rdx
		  __int64 v65; // rcx
		  String *v67; // rax
		  __int64 v68; // rax
		  MethodInfo *v69; // [rsp+20h] [rbp-78h]
		  _QWORD v70[2]; // [rsp+40h] [rbp-58h] BYREF
		  _BYTE v71[16]; // [rsp+50h] [rbp-48h] BYREF
		  __int64 v72; // [rsp+B8h] [rbp+20h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3716, 0LL) )
		  {
		    v5 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass20_0);
		    v8 = v5;
		    if ( !v5 )
		      sub_1800D8260(v7, v6);
		    *(_DWORD *)(v5 + 16) = groupIndex;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		    static_fields = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields;
		    if ( !static_fields->attributesGroup )
		      sub_1800D8260(static_fields, v9);
		    if ( !System::Collections::Generic::Dictionary<int,System::Object>::ContainsKey(
		            (Dictionary_2_System_Int32_System_Object_ *)static_fields->attributesGroup,
		            *(_DWORD *)(v8 + 16),
		            MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::ContainsKey) )
		      goto LABEL_7;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		    v12 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields;
		    if ( !v12->attributesGroup )
		      sub_1800D8260(v12, v11);
		    if ( !System::Collections::Generic::Dictionary<int,System::Object>::get_Item(
		            (Dictionary_2_System_Int32_System_Object_ *)v12->attributesGroup,
		            *(_DWORD *)(v8 + 16),
		            MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::get_Item) )
		    {
		LABEL_7:
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		      v14 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
		      v15 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields;
		      attributesGroup = (Dictionary_2_System_Int32_System_Object_ *)v15->attributesGroup;
		      v17 = *(_DWORD *)(v8 + 16);
		      attributes = (IEnumerable_1_KeyValuePair_2_System_Object_System_Object_ *)v15->attributes;
		      if ( !attributes )
		        goto LABEL_14;
		      v19 = (Predicate_1_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_ *)sub_18002C620(TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,bool>);
		      v22 = (Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *)v19;
		      if ( !v19 )
		        sub_1800D8260(v21, v20);
		      System::Predicate<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile>::Predicate(
		        v19,
		        (Object *)v8,
		        MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c__DisplayClass20_0::_GenerateHistoryArea_b__0,
		        0LL);
		      v23 = System::Linq::Enumerable::Where<System::Collections::Generic::KeyValuePair<System::Object,System::Object>>(
		              attributes,
		              v22,
		              MethodInfo::System::Linq::Enumerable::Where<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>);
		      if ( v23 )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c);
		        _9__20_1 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c->static_fields->__9__20_1;
		        if ( !_9__20_1 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c);
		          v25 = (Object *)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c->static_fields->__9;
		          v26 = (Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Int32Enum_ *)sub_18002C620(TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,int>);
		          _9__20_1 = (Func_2_System_Collections_Generic_KeyValuePair_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Int32_ *)v26;
		          if ( !v26 )
		            sub_1800D8260(v28, v27);
		          System::Func<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile,System::Int32Enum>::Func(
		            v26,
		            v25,
		            MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c::_GenerateHistoryArea_b__20_1,
		            0LL);
		          TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c->static_fields->__9__20_1 = _9__20_1;
		          sub_18002D1B0(
		            (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory::__c->static_fields->__9__20_1,
		            v29,
		            v30,
		            v31,
		            v69);
		        }
		        v32 = (Object *)System::Linq::Enumerable::OrderBy<System::Collections::Generic::KeyValuePair<System::Int32Enum,System::Object>,int>(
		                          (IEnumerable_1_KeyValuePair_2_System_Int32Enum_System_Object_ *)v23,
		                          (Func_2_System_Collections_Generic_KeyValuePair_2_System_Int32Enum_System_Object_Int32_ *)_9__20_1,
		                          MethodInfo::System::Linq::Enumerable::OrderBy<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,int>);
		      }
		      else
		      {
		LABEL_14:
		        v32 = 0LL;
		      }
		      if ( !attributesGroup )
		        sub_1800D8260(v14, v13);
		      System::Collections::Generic::Dictionary<int,System::Object>::set_Item(
		        attributesGroup,
		        v17,
		        v32,
		        MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::set_Item);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		    v34 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields;
		    if ( !v34->attributesGroup )
		      sub_1800D8260(v34, v33);
		    if ( !System::Collections::Generic::Dictionary<int,System::Object>::ContainsKey(
		            (Dictionary_2_System_Int32_System_Object_ *)v34->attributesGroup,
		            *(_DWORD *)(v8 + 16),
		            MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::ContainsKey) )
		    {
		      v59 = sub_18007E180(&TypeInfo::System::ArgumentException);
		      v62 = (InvalidEnumArgumentException *)sub_18002C620(v59);
		      if ( !v62 )
		        sub_1800D8260(v61, v60);
		      v67 = (String *)sub_18007E180(&off_18E277698);
		      System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v62, v67, 0LL);
		      v68 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryArea);
		      sub_18007E190(v62, v68);
		    }
		    v35 = (ObservableList_1_System_Object_ *)sub_18002C620(TypeInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>);
		    v38 = (ObservableList_1_DebugUI_Widget_ *)v35;
		    if ( !v35 )
		      sub_1800D8260(v37, v36);
		    UnityEngine::Rendering::ObservableList<System::Object>::ObservableList(
		      v35,
		      MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::ObservableList);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		    v40 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields;
		    v41 = *(_DWORD *)(v8 + 16);
		    if ( !v40->attributesGroup )
		      sub_1800D8260(v40, v39);
		    Item = System::Collections::Generic::Dictionary<int,System::Object>::get_Item(
		             (Dictionary_2_System_Int32_System_Object_ *)v40->attributesGroup,
		             v41,
		             MethodInfo::System::Collections::Generic::Dictionary<int,System::Linq::IOrderedEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>>::get_Item);
		    if ( !Item )
		      sub_1800D8260(v44, v43);
		    v72 = sub_1800428A0(
		            0LL,
		            TypeInfo::System::Collections::Generic::IEnumerable<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>,
		            Item);
		    v70[0] = 0LL;
		    v70[1] = &v72;
		    while ( 1 )
		    {
		      while ( 1 )
		      {
		        if ( !v72 )
		          sub_1800D8250(type, v45);
		        if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		        {
		          sub_1801F6A10(v70);
		          return v38;
		        }
		        if ( !v72 )
		          sub_1800D8250(v48, v47);
		        v49 = sub_1808B05B8(v71);
		        v51 = *(__m128i *)v49;
		        v52 = *(FrameSettingsFieldAttribute **)(v49 + 8);
		        if ( !v52 )
		          sub_1800D8250(v50, v45);
		        type = (unsigned int)v52->fields.type;
		        if ( (_DWORD)type )
		          break;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		        HistoryBoolField = (Object *)HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryBoolField(
		                                       frameSettingsContainer,
		                                       (FrameSettingsField__Enum)_mm_cvtsi128_si32(v51),
		                                       v52,
		                                       0LL);
		        if ( !v38 )
		          sub_1800D8250(v58, v57);
		LABEL_32:
		        UnityEngine::Rendering::ObservableList<System::Object>::Add(
		          (ObservableList_1_System_Object_ *)v38,
		          HistoryBoolField,
		          MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
		      }
		      if ( (_DWORD)type == 1 )
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		        EnumTypeByField = HG::Rendering::Runtime::FrameSettingsHistory::RetrieveEnumTypeByField(
		                            (FrameSettingsField__Enum)_mm_cvtsi128_si32(v51),
		                            0LL);
		        HistoryBoolField = (Object *)HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryEnumField(
		                                       frameSettingsContainer,
		                                       (FrameSettingsField__Enum)_mm_cvtsi128_si32(v51),
		                                       v52,
		                                       EnumTypeByField,
		                                       0LL);
		        if ( !v38 )
		          sub_1800D8250(v56, v55);
		        goto LABEL_32;
		      }
		    }
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3716, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v65, v64);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1297(Patch, (Object *)frameSettingsContainer, groupIndex, 0LL);
		}
		
		private static DebugUI.Widget[] GenerateFrameSettingsPanelContent(IFrameSettingsHistoryContainer frameSettingsContainer) => default; // 0x0000000189C05788-0x0000000189C05928
		// DebugUI+Widget[] GenerateFrameSettingsPanelContent(IFrameSettingsHistoryContainer)
		DebugUI_Widget__Array *HG::Rendering::Runtime::FrameSettingsHistory::GenerateFrameSettingsPanelContent(
		        IFrameSettingsHistoryContainer *frameSettingsContainer,
		        MethodInfo *method)
		{
		  Type *v3; // rdx
		  Type **static_fields; // rcx
		  DebugUI_Widget__Array *v5; // rdi
		  int32_t i; // ebx
		  String *v7; // r14
		  ObservableList_1_DebugUI_Widget_ *HistoryArea; // r15
		  FrameSettingsHistory__StaticFields *v9; // rcx
		  String__Array *columnNames; // r12
		  String__Array *v11; // r13
		  DebugUI_Foldout *v12; // rax
		  DebugUI_Widget *v13; // rsi
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *columnTooltips; // [rsp+20h] [rbp-38h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3720, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3720, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1298(Patch, (Object *)frameSettingsContainer, 0LL);
		LABEL_15:
		    sub_1800D8260(static_fields, v3);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		  static_fields = (Type **)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields;
		  if ( !*static_fields )
		    goto LABEL_15;
		  v5 = (DebugUI_Widget__Array *)il2cpp_array_new_specific_1(
		                                  TypeInfo::UnityEngine::Rendering::DebugUI::Widget,
		                                  LODWORD((*static_fields)[1].klass));
		  for ( i = 0; ; ++i )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		    static_fields = (Type **)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory;
		    v3 = (Type *)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields;
		    if ( !v3->klass )
		      goto LABEL_15;
		    if ( i >= SLODWORD(v3->klass->_0.namespaze) )
		      break;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		    static_fields = (Type **)TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields;
		    v3 = *static_fields;
		    if ( !*static_fields )
		      goto LABEL_15;
		    if ( (unsigned int)i >= LODWORD(v3[1].klass) )
		LABEL_12:
		      sub_1800D2AB0(static_fields, v3);
		    v7 = (String *)*((_QWORD *)&v3[1].monitor + i);
		    HistoryArea = HG::Rendering::Runtime::FrameSettingsHistory::GenerateHistoryArea(frameSettingsContainer, i, 0LL);
		    v9 = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields;
		    columnNames = v9->columnNames;
		    v11 = v9->columnTooltips;
		    v12 = (DebugUI_Foldout *)sub_18002C620(TypeInfo::UnityEngine::Rendering::DebugUI::Foldout);
		    v13 = (DebugUI_Widget *)v12;
		    if ( !v12 )
		      goto LABEL_15;
		    UnityEngine::Rendering::DebugUI::Foldout::Foldout(v12, v7, HistoryArea, columnNames, v11, 0LL);
		    if ( !v5 )
		      goto LABEL_15;
		    sub_180031B10(v5, v13);
		    if ( (unsigned int)i >= v5->max_length.size )
		      goto LABEL_12;
		    v5->vector[i] = v13;
		    sub_18002D1B0((SingleFieldAccessor *)&v5->vector[i], v3, v14, v15, columnTooltips);
		  }
		  return v5;
		}
		
		private static void GenerateFrameSettingsPanel(string menuName, IFrameSettingsHistoryContainer frameSettingsContainer) {} // 0x0000000189C05928-0x0000000189C05A40
		// Void GenerateFrameSettingsPanel(String, IFrameSettingsHistoryContainer)
		void HG::Rendering::Runtime::FrameSettingsHistory::GenerateFrameSettingsPanel(
		        String *menuName,
		        IFrameSettingsHistoryContainer *frameSettingsContainer,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  List_1_System_Object_ *v8; // rbx
		  IEnumerable_1_System_Object_ *FrameSettingsPanelContent; // rax
		  DebugManager *instance; // rax
		  DebugUI_Panel *Panel; // rax
		  ObservableList_1_System_Object_ *children_k__BackingField; // rdi
		  Object__Array *v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3721, 0LL) )
		  {
		    v5 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>);
		    v8 = (List_1_System_Object_ *)v5;
		    if ( v5 )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		        v5,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::List);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		      FrameSettingsPanelContent = (IEnumerable_1_System_Object_ *)HG::Rendering::Runtime::FrameSettingsHistory::GenerateFrameSettingsPanelContent(
		                                                                    frameSettingsContainer,
		                                                                    0LL);
		      System::Collections::Generic::List<System::Object>::AddRange(
		        v8,
		        FrameSettingsPanelContent,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::AddRange);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::DebugManager);
		      instance = UnityEngine::Rendering::DebugManager::get_instance(0LL);
		      if ( instance )
		      {
		        Panel = UnityEngine::Rendering::DebugManager::GetPanel(instance, menuName, 1, 2, 1, 0LL);
		        if ( Panel )
		        {
		          children_k__BackingField = (ObservableList_1_System_Object_ *)Panel->fields._children_k__BackingField;
		          v13 = System::Collections::Generic::List<System::Object>::ToArray(
		                  v8,
		                  MethodInfo::System::Collections::Generic::List<UnityEngine::Rendering::DebugUI::Widget>::ToArray);
		          if ( children_k__BackingField )
		          {
		            UnityEngine::Rendering::ObservableList<System::Object>::Add(
		              children_k__BackingField,
		              v13,
		              MethodInfo::UnityEngine::Rendering::ObservableList<UnityEngine::Rendering::DebugUI::Widget>::Add);
		            return;
		          }
		        }
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3721, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)menuName,
		    (Object *)frameSettingsContainer,
		    0LL);
		}
		
		private static System.Type RetrieveEnumTypeByField(FrameSettingsField field) => default; // 0x0000000189C06678-0x0000000189C06730
		// Type RetrieveEnumTypeByField(FrameSettingsField)
		Type *HG::Rendering::Runtime::FrameSettingsHistory::RetrieveEnumTypeByField(
		        FrameSettingsField__Enum field,
		        MethodInfo *method)
		{
		  __int64 v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  InvalidEnumArgumentException *v6; // rbx
		  String *v7; // rax
		  __int64 v8; // rax
		  struct Il2CppType *v9; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3719, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3719, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1296(Patch, field, 0LL);
		  }
		  else
		  {
		    if ( field )
		    {
		      v3 = sub_18007E180(&TypeInfo::System::ArgumentException);
		      v6 = (InvalidEnumArgumentException *)sub_18002C620(v3);
		      if ( v6 )
		      {
		        v7 = (String *)sub_18007E180(&off_18E277570);
		        System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v6, v7, 0LL);
		        v8 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::FrameSettingsHistory::RetrieveEnumTypeByField);
		        sub_18007E190(v6, v8);
		      }
		LABEL_7:
		      sub_1800D8260(v5, v4);
		    }
		    v9 = TypeRef::HG::Rendering::Runtime::LitShaderMode;
		    sub_1800036A0(TypeInfo::System::Type);
		    return System::Type::GetTypeFromHandle((RuntimeTypeHandle)v9, 0LL);
		  }
		}
		
		public static IDebugData RegisterDebug(IFrameSettingsHistoryContainer frameSettingsContainer, bool sceneViewCamera = false /* Metadata: 0x02303E3F */) => default; // 0x0000000189C065D0-0x0000000189C06678
		// IDebugData RegisterDebug(IFrameSettingsHistoryContainer, Boolean)
		IDebugData *HG::Rendering::Runtime::FrameSettingsHistory::RegisterDebug(
		        IFrameSettingsHistoryContainer *frameSettingsContainer,
		        bool sceneViewCamera,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HashSet_1_HG_Rendering_Runtime_IFrameSettingsHistoryContainer_ *containers; // rcx
		  String *v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3722, 0LL) )
		  {
		    if ( frameSettingsContainer )
		    {
		      v7 = (String *)sub_189C044BC(frameSettingsContainer);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		      HG::Rendering::Runtime::FrameSettingsHistory::GenerateFrameSettingsPanel(v7, frameSettingsContainer, 0LL);
		      containers = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->containers;
		      if ( containers )
		      {
		        System::Collections::Generic::HashSet<System::Object>::Add(
		          (HashSet_1_System_Object_ *)containers,
		          (Object *)frameSettingsContainer,
		          MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::IFrameSettingsHistoryContainer>::Add);
		        return (IDebugData *)frameSettingsContainer;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(containers, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3722, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1299(Patch, (Object *)frameSettingsContainer, sceneViewCamera, 0LL);
		}
		
		public static void UnRegisterDebug(IFrameSettingsHistoryContainer container) {} // 0x0000000189C06790-0x0000000189C06848
		// Void UnRegisterDebug(IFrameSettingsHistoryContainer)
		void HG::Rendering::Runtime::FrameSettingsHistory::UnRegisterDebug(
		        IFrameSettingsHistoryContainer *container,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HashSet_1_HG_Rendering_Runtime_IFrameSettingsHistoryContainer_ *containers; // rcx
		  DebugManager *instance; // rdi
		  String *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3723, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::DebugManager);
		    instance = UnityEngine::Rendering::DebugManager::get_instance(0LL);
		    if ( container )
		    {
		      v6 = (String *)sub_189C044BC(container);
		      if ( instance )
		      {
		        UnityEngine::Rendering::DebugManager::RemovePanel(instance, v6, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		        containers = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->containers;
		        if ( containers )
		        {
		          System::Collections::Generic::HashSet<System::Object>::Remove(
		            (HashSet_1_System_Object_ *)containers,
		            (Object *)container,
		            MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::IFrameSettingsHistoryContainer>::Remove);
		          return;
		        }
		      }
		    }
		LABEL_7:
		    sub_1800D8260(containers, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3723, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)container, 0LL);
		}
		
		public static bool IsRegistered(IFrameSettingsHistoryContainer container, bool sceneViewCamera = false /* Metadata: 0x02303E40 */) => default; // 0x0000000189C06540-0x0000000189C065D0
		// Boolean IsRegistered(IFrameSettingsHistoryContainer, Boolean)
		bool HG::Rendering::Runtime::FrameSettingsHistory::IsRegistered(
		        IFrameSettingsHistoryContainer *container,
		        bool sceneViewCamera,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HashSet_1_HG_Rendering_Runtime_IFrameSettingsHistoryContainer_ *containers; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3724, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3724, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1248(Patch, (Object *)container, sceneViewCamera, 0LL);
		  }
		  else
		  {
		    if ( !sceneViewCamera )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
		      containers = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->containers;
		      if ( containers )
		        return System::Collections::Generic::HashSet<System::Object>::Contains(
		                 (HashSet_1_System_Object_ *)containers,
		                 (Object *)container,
		                 MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::IFrameSettingsHistoryContainer>::Contains);
		LABEL_7:
		      sub_1800D8260(containers, v5);
		    }
		    return 1;
		  }
		}
		
		internal void TriggerReset() {} // 0x0000000189C06730-0x0000000189C06790
		// Void TriggerReset()
		void HG::Rendering::Runtime::FrameSettingsHistory::TriggerReset(FrameSettingsHistory *this, MethodInfo *method)
		{
		  BitArray128 bitDatas; // xmm0
		  __int64 v4; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2769, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2769, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1013(Patch, this, 0LL);
		  }
		  else
		  {
		    bitDatas = this->sanitazed.bitDatas;
		    this->hasDebug = 0;
		    v4 = *(_QWORD *)&this->sanitazed.materialQuality;
		    this->debug.bitDatas = bitDatas;
		    *(_QWORD *)&this->debug.materialQuality = v4;
		  }
		}
		
	}
}
