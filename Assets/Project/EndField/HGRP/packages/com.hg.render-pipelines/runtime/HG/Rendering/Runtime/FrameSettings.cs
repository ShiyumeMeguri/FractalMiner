using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[DebuggerDisplay("{bitDatas.humanizedData}")]
	[DebuggerTypeProxy(typeof(FrameSettingsDebugView))]
	public struct FrameSettings // TypeDefIndex: 38538
	{
		// Fields
		[SerializeField]
		private BitArray128 bitDatas; // 0x00
		public MaterialQuality materialQuality; // 0x10
	
		// Properties
		public ulong Data1 { get => default; } // 0x0000000183EC9600-0x0000000183EC9660 
		// UInt64 get_Data1()
		uint64_t HG::Rendering::Runtime::FrameSettings::get_Data1(FrameSettings *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1061 )
		    return this->bitDatas.data1;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x425 )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[22]._1.instance_size )
		    return this->bitDatas.data1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1061, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_408(Patch, this, 0LL);
		}
		
		public ulong Data2 { get => default; } // 0x0000000183EC95A0-0x0000000183EC9600 
		// UInt64 get_Data2()
		uint64_t HG::Rendering::Runtime::FrameSettings::get_Data2(FrameSettings *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1062 )
		    return this->bitDatas.data2;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x426 )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[22]._1.element_size )
		    return this->bitDatas.data2;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1062, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_408(Patch, this, 0LL);
		}
		
		public LitShaderMode litShaderMode { get => default; set {} } // 0x0000000189C075B0-0x0000000189C0761C 0x000000018344FA70-0x000000018344FAF0
		// LitShaderMode get_litShaderMode()
		LitShaderMode__Enum HG::Rendering::Runtime::FrameSettings::get_litShaderMode(FrameSettings *this, MethodInfo *method)
		{
		  LitShaderMode__Enum v3; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  v3 = LitShaderMode__Enum_Forward;
		  if ( IFix::WrappersManagerImpl::IsPatched(3125, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3125, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1282(Patch, this, 0LL);
		  }
		  else
		  {
		    LOBYTE(v3) = UnityEngine::Rendering::BitArrayUtilities::Get128(0, this->bitDatas.data1, this->bitDatas.data2, 0LL);
		    return v3;
		  }
		}
		

		// Void set_litShaderMode(LitShaderMode)
		void HG::Rendering::Runtime::FrameSettings::set_litShaderMode(
		        FrameSettings *this,
		        LitShaderMode__Enum value,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  uint64_t data1; // rax
		  uint64_t v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 690 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x2B2 )
		        sub_1800D2AB0(v5, wrapperArray);
		      if ( !*(_QWORD *)&v5[14]._1.field_count )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(690, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_269(Patch, this, value, 0LL);
		        return;
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v5, wrapperArray);
		  }
		LABEL_5:
		  data1 = this->bitDatas.data1;
		  if ( value == LitShaderMode__Enum_Deferred )
		    v8 = data1 | 1;
		  else
		    v8 = data1 & 0xFFFFFFFFFFFFFFFEuLL;
		  this->bitDatas.data1 = v8;
		}
		
	
		// Nested types
		[DebuggerDisplay("{m_Value}", Name = "{m_Label,nq}")]
		internal class DebuggerEntry // TypeDefIndex: 38533
		{
			// Fields
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string m_Label; // 0x10
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private object m_Value; // 0x18
	
			// Constructors
			public DebuggerEntry() {} // Dummy constructor
			public DebuggerEntry(string label, object value) {} // 0x00000001832AF420-0x00000001832AF450
			// WhereObservable`1[System.Object](IObservable`1[Object], Func`2[Object,Boolean])
			void UnityEngine::InputSystem::Utilities::WhereObservable<System::Object>::WhereObservable(
			        WhereObservable_1_System_Object_ *this,
			        IObservable_1_Object_ *source,
			        Func_2_Object_Boolean_ *predicate,
			        MethodInfo *method)
			{
			  __int64 v4; // r9
			  __int64 v5; // r10
			  Type *v6; // rdx
			  PropertyInfo_1 *v7; // r8
			  MethodInfo *v8; // [rsp+20h] [rbp-8h]
			  MethodInfo *v9; // [rsp+50h] [rbp+28h]
			
			  this->fields.m_Source = source;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&this->fields,
			    (Type *)source,
			    (PropertyInfo_1 *)predicate,
			    (Int32__Array **)this,
			    v8);
			  *(_QWORD *)(v4 + 24) = v5;
			  sub_18002D1B0((SingleFieldAccessor *)(v4 + 24), v6, v7, (Int32__Array **)v4, v9);
			}
			
		}
	
		[DebuggerDisplay("", Name = "{m_GroupName,nq}")]
		internal class DebuggerGroup // TypeDefIndex: 38534
		{
			// Fields
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string m_GroupName; // 0x10
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public DebuggerEntry[] m_Entries; // 0x18
	
			// Constructors
			public DebuggerGroup() {} // Dummy constructor
			public DebuggerGroup(string groupName, DebuggerEntry[] entries) {} // 0x00000001832AF420-0x00000001832AF450
			// WhereObservable`1[System.Object](IObservable`1[Object], Func`2[Object,Boolean])
			void UnityEngine::InputSystem::Utilities::WhereObservable<System::Object>::WhereObservable(
			        WhereObservable_1_System_Object_ *this,
			        IObservable_1_Object_ *source,
			        Func_2_Object_Boolean_ *predicate,
			        MethodInfo *method)
			{
			  __int64 v4; // r9
			  __int64 v5; // r10
			  Type *v6; // rdx
			  PropertyInfo_1 *v7; // r8
			  MethodInfo *v8; // [rsp+20h] [rbp-8h]
			  MethodInfo *v9; // [rsp+50h] [rbp+28h]
			
			  this->fields.m_Source = source;
			  sub_18002D1B0(
			    (SingleFieldAccessor *)&this->fields,
			    (Type *)source,
			    (PropertyInfo_1 *)predicate,
			    (Int32__Array **)this,
			    v8);
			  *(_QWORD *)(v4 + 24) = v5;
			  sub_18002D1B0((SingleFieldAccessor *)(v4 + 24), v6, v7, (Int32__Array **)v4, v9);
			}
			
		}
	
		internal class FrameSettingsDebugView // TypeDefIndex: 38537
		{
			// Fields
			private const int numberOfNonBitValues = 2; // Metadata: 0x02303DDD
			private FrameSettings m_FrameSettings; // 0x10
	
			// Properties
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public DebuggerGroup[] Keys { get => default; } // 0x0000000189C0474C-0x0000000189C05278 
			// FrameSettings+DebuggerGroup[] get_Keys()
			// Hidden C++ exception states: #wind=2
			FrameSettings_DebuggerGroup__Array *HG::Rendering::Runtime::FrameSettings::FrameSettingsDebugView::get_Keys(
			        FrameSettings_FrameSettingsDebugView *this,
			        MethodInfo *method)
			{
			  struct Il2CppType *v3; // rbx
			  Type *TypeFromHandle; // rbx
			  Array *Values; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			  Dictionary_2_System_Int32Enum_System_Object_ *v8; // rax
			  __int64 v9; // rdx
			  __int64 v10; // rcx
			  IObservable_1_Object_ *v11; // r14
			  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v12; // rax
			  __int64 v13; // rdx
			  __int64 v14; // rcx
			  List_1_System_Object_ *v15; // r13
			  Dictionary_2_HG_Rendering_Runtime_FrameSettingsField_System_String_ *EnumNameMap; // rsi
			  Type *v17; // r15
			  IEnumerable_1_System_Int32Enum_ *v18; // rax
			  __int64 v19; // rdx
			  __int64 v20; // rcx
			  IEnumerable_1_System_Int32Enum_ *v21; // r12
			  __int64 v22; // rdx
			  __int64 v23; // rcx
			  Dictionary_2_TKey_TValue_KeyCollection_System_Object_System_Boolean_ *Keys; // rax
			  __int64 v25; // rdx
			  __int64 v26; // rcx
			  __int64 *v27; // rdx
			  Dictionary_2_System_UInt32_System_Int32Enum_ *dictionary; // rcx
			  unsigned int currentKey; // ebx
			  Object *Item; // rax
			  __int64 v31; // rdx
			  __int64 v32; // rcx
			  MemberInfo_1 *v33; // rax
			  Object *v34; // rax
			  __int64 v35; // rdx
			  __int64 v36; // rcx
			  __int64 v37; // rdx
			  __int64 v38; // rcx
			  IEnumerable_1_System_Object_ *v39; // r15
			  Func_2_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Boolean_ *_9__4_0; // rsi
			  Object *v41; // rbx
			  Func_2_Object_Boolean_ *v42; // rax
			  unsigned __int64 v43; // r8
			  unsigned __int64 v44; // rdx
			  signed __int64 v45; // rtt
			  IEnumerable_1_System_Object_ *v46; // r12
			  Func_2_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Int32_ *_9__4_1; // rsi
			  Object *v48; // r15
			  Func_2_Object_Int32_ *v49; // rax
			  unsigned __int64 v50; // r9
			  unsigned __int64 v51; // r8
			  signed __int64 v52; // rtt
			  IEnumerable_1_System_Int32_ *v53; // rax
			  IEnumerable_1_System_Int32_ *v54; // rax
			  __int64 v55; // rdx
			  __int64 v56; // rcx
			  __int64 v57; // rdx
			  __int64 v58; // rcx
			  __int64 v59; // rsi
			  __int64 v60; // rdx
			  __int64 v61; // r8
			  String__Array *foldoutNames; // rax
			  __int64 v63; // rcx
			  Predicate_1_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_ *v64; // rax
			  __int64 v65; // rdx
			  __int64 v66; // rcx
			  Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *v67; // r15
			  IEnumerable_1_KeyValuePair_2_System_Object_System_Object_ *v68; // r12
			  Func_2_System_Collections_Generic_KeyValuePair_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Int32_ *_9__4_5; // rsi
			  Object *v70; // r15
			  Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Int32Enum_ *v71; // rax
			  __int64 v72; // rdx
			  __int64 v73; // rcx
			  unsigned __int64 v74; // rdx
			  char v75; // r9
			  signed __int64 v76; // rtt
			  IEnumerable_1_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_ *v77; // r15
			  Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Object_ *v78; // rax
			  __int64 v79; // rdx
			  __int64 v80; // rcx
			  Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Object_ *v81; // rsi
			  IEnumerable_1_System_Object_ *v82; // rax
			  Object__Array *v83; // r15
			  WhereObservable_1_System_Object_ *v84; // rax
			  __int64 v85; // rdx
			  __int64 v86; // rcx
			  Object *v87; // rsi
			  __int64 v88; // rdx
			  __int64 v89; // rcx
			  IEnumerable_1_System_Int32Enum_ *v90; // r12
			  Func_2_HG_Rendering_Runtime_FrameSettingsField_Boolean_ *_9__4_2; // rsi
			  Object *v92; // r14
			  Func_2_Int32Enum_Boolean_ *v93; // rax
			  unsigned __int64 v94; // rdx
			  unsigned __int64 v95; // r9
			  signed __int64 v96; // rtt
			  IEnumerable_1_UnityEngine_InputSystem_Utilities_JsonParser_JsonValue_ *v97; // r14
			  GenericDelegateCallerGen_int_FStructSize8Delegate_2_System_Int32_Beyond_Reflection_StructSizeGen_FStructSize8_ *v98; // rax
			  Func_2_UnityEngine_InputSystem_Utilities_JsonParser_JsonValue_Object_ *v99; // rsi
			  FrameSettings_FrameSettingsDebugView *v100; // r12
			  IEnumerable_1_System_Object_ *v101; // rax
			  Object__Array *v102; // r14
			  WhereObservable_1_System_Object_ *v103; // rax
			  Object *v104; // rsi
			  __int64 v105; // rsi
			  Func_2_Object_Boolean_ *v106; // r15
			  WhereObservable_1_System_Object_ *v107; // rax
			  WhereObservable_1_System_Object_ *v108; // r14
			  __int64 v109; // rdx
			  __int64 v110; // rcx
			  __int64 v111; // r8
			  unsigned __int64 v112; // r8
			  signed __int64 v113; // rtt
			  WhereObservable_1_System_Object_ *v114; // rax
			  Object *v115; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v118; // rdx
			  __int64 v119; // rcx
			  __int64 v120; // [rsp+0h] [rbp-A8h] BYREF
			  IObservable_1_Object_ *source; // [rsp+20h] [rbp-88h]
			  Dictionary_2_TKey_TValue_KeyCollection_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v122; // [rsp+28h] [rbp-80h] BYREF
			  List_1_System_Object_ *v123; // [rsp+40h] [rbp-68h]
			  IEnumerable_1_System_Int32Enum_ *v124; // [rsp+48h] [rbp-60h]
			  Dictionary_2_TKey_TValue_KeyCollection_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v125; // [rsp+50h] [rbp-58h] BYREF
			  Il2CppExceptionWrapper *v126; // [rsp+68h] [rbp-40h] BYREF
			  Il2CppExceptionWrapper *v127; // [rsp+78h] [rbp-30h] BYREF
			  IEnumerable_1_System_Int32Enum_ *v129; // [rsp+C0h] [rbp+18h] BYREF
			  __int64 v130; // [rsp+C8h] [rbp+20h] BYREF
			
			  v130 = 0LL;
			  if ( !IFix::WrappersManagerImpl::IsPatched(3690, 0LL) )
			  {
			    v3 = TypeRef::HG::Rendering::Runtime::FrameSettingsField;
			    sub_1800036A0(TypeInfo::System::Type);
			    TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v3, 0LL);
			    sub_1800036A0(TypeInfo::System::Enum);
			    Values = System::Enum::GetValues(TypeFromHandle, 0LL);
			    if ( !Values )
			      sub_1800D8260(v7, v6);
			    System::Array::get_Length(Values, 0LL);
			    v8 = (Dictionary_2_System_Int32Enum_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>);
			    v11 = (IObservable_1_Object_ *)v8;
			    if ( !v8 )
			      sub_1800D8260(v10, v9);
			    System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::Dictionary(
			      v8,
			      MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::Dictionary);
			    source = v11;
			    v12 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettings::DebuggerGroup>);
			    v15 = (List_1_System_Object_ *)v12;
			    if ( !v12 )
			      sub_1800D8260(v14, v13);
			    System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
			      v12,
			      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettings::DebuggerGroup>::List);
			    v123 = v15;
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute);
			    EnumNameMap = HG::Rendering::Runtime::FrameSettingsFieldAttribute::GetEnumNameMap(0LL);
			    v17 = System::Type::GetTypeFromHandle((RuntimeTypeHandle)TypeRef::HG::Rendering::Runtime::FrameSettingsField, 0LL);
			    v18 = (IEnumerable_1_System_Int32Enum_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettingsField>);
			    v21 = v18;
			    v129 = v18;
			    if ( !v18 )
			      sub_1800D8260(v20, v19);
			    System::Collections::Generic::List<Beyond::Blackboard::DataPair>::List(
			      (List_1_Beyond_Blackboard_DataPair_ *)v18,
			      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettingsField>::List);
			    v124 = v21;
			    if ( !EnumNameMap )
			      sub_1800D8260(v23, v22);
			    Keys = System::Collections::Generic::Dictionary<System::Object,bool>::get_Keys(
			             (Dictionary_2_System_Object_System_Boolean_ *)EnumNameMap,
			             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::get_Keys);
			    if ( !Keys )
			      sub_1800D8260(v26, v25);
			    System::Collections::Generic::Dictionary_2_TKey_TValue_::ValueCollection<unsigned int,System::Int32Enum>::GetEnumerator(
			      (Dictionary_2_TKey_TValue_ValueCollection_TKey_TValue_Enumerator_System_UInt32_System_Int32Enum_ *)&v122,
			      (Dictionary_2_TKey_TValue_ValueCollection_System_UInt32_System_Int32Enum_ *)Keys,
			      MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::KeyCollection<HG::Rendering::Runtime::FrameSettingsField,System::String>::GetEnumerator);
			    v125 = v122;
			    v122._dictionary = 0LL;
			    *(_QWORD *)&v122._index = &v125;
			    try
			    {
			      while ( System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			                &v125,
			                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue__KeyCollection_TKey_TValue_::Enumerator<HG::Rendering::Runtime::FrameSettingsField,System::String>::MoveNext) )
			      {
			        currentKey = v125._currentKey;
			        Item = System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			                 (Dictionary_2_System_Int32Enum_System_Object_ *)EnumNameMap,
			                 (Int32Enum__Enum)v125._currentKey,
			                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::get_Item);
			        if ( !v17 )
			          sub_1800D8250(v32, v31);
			        v33 = (MemberInfo_1 *)sub_180048D30(v32, v17, Item, 28LL);
			        v34 = System::Reflection::CustomAttributeExtensions::GetCustomAttribute<System::Object>(
			                v33,
			                MethodInfo::System::Reflection::CustomAttributeExtensions::GetCustomAttribute<HG::Rendering::Runtime::FrameSettingsFieldAttribute>);
			        if ( !v11 )
			          sub_1800D8250(v36, v35);
			        System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::set_Item(
			          (Dictionary_2_System_Int32Enum_System_Object_ *)v11,
			          (Int32Enum__Enum)currentKey,
			          v34,
			          MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::set_Item);
			        if ( !System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::get_Item(
			                (Dictionary_2_System_Int32Enum_System_Object_ *)v11,
			                (Int32Enum__Enum)currentKey,
			                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::get_Item) )
			        {
			          if ( !v21 )
			            sub_1800D8250(v38, v37);
			          sub_1836FCDC0(
			            v21,
			            currentKey,
			            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettingsField>::Add);
			        }
			      }
			    }
			    catch ( Il2CppExceptionWrapper *v126 )
			    {
			      v27 = &v120;
			      v122._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v126->ex;
			      dictionary = (Dictionary_2_System_UInt32_System_Int32Enum_ *)v122._dictionary;
			      if ( v122._dictionary )
			        sub_18007E1E0(v122._dictionary);
			      v11 = source;
			      v15 = v123;
			      v129 = v124;
			    }
			    if ( v11 )
			    {
			      v39 = (IEnumerable_1_System_Object_ *)System::Collections::Generic::Dictionary<unsigned long,System::Object>::get_Values(
			                                              (Dictionary_2_System_UInt64_System_Object_ *)v11,
			                                              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>::get_Values);
			      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
			      _9__4_0 = TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_0;
			      if ( !_9__4_0 )
			      {
			        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
			        v41 = (Object *)TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9;
			        v42 = (Func_2_Object_Boolean_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsFieldAttribute,bool>);
			        _9__4_0 = (Func_2_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Boolean_ *)v42;
			        if ( !v42 )
			          goto LABEL_92;
			        System::Func<System::Object,bool>::Func(
			          v42,
			          v41,
			          MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c::_get_Keys_b__4_0,
			          0LL);
			        TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_0 = _9__4_0;
			        if ( dword_18F35FD08 )
			        {
			          v43 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_0 >> 12) & 0x1FFFFF) >> 6;
			          v44 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_0 >> 12) & 0x3F;
			          _m_prefetchw(&qword_18F0BCBA0[v43 + 36190]);
			          do
			            v45 = qword_18F0BCBA0[v43 + 36190];
			          while ( v45 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v43 + 36190], v45 | (1LL << v44), v45) );
			        }
			      }
			      v46 = System::Linq::Enumerable::Where<System::Object>(
			              v39,
			              (Func_2_Object_Boolean_ *)_9__4_0,
			              MethodInfo::System::Linq::Enumerable::Where<HG::Rendering::Runtime::FrameSettingsFieldAttribute>);
			      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
			      _9__4_1 = TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_1;
			      if ( !_9__4_1 )
			      {
			        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
			        v48 = (Object *)TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9;
			        v49 = (Func_2_Object_Int32_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsFieldAttribute,int>);
			        _9__4_1 = (Func_2_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Int32_ *)v49;
			        if ( !v49 )
			          goto LABEL_92;
			        System::Func<System::Object,int>::Func(
			          v49,
			          v48,
			          MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c::_get_Keys_b__4_1,
			          0LL);
			        TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_1 = _9__4_1;
			        if ( dword_18F35FD08 )
			        {
			          v50 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_1 >> 12) & 0x1FFFFF) >> 6;
			          v51 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_1 >> 12) & 0x3F;
			          _m_prefetchw(&qword_18F0BCBA0[v50 + 36190]);
			          do
			            v52 = qword_18F0BCBA0[v50 + 36190];
			          while ( v52 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v50 + 36190], v52 | (1LL << v51), v52) );
			        }
			      }
			      v53 = (IEnumerable_1_System_Int32_ *)System::Linq::Enumerable::Select<UnityEngine::RaycastHit2D,float>(
			                                             (IEnumerable_1_UnityEngine_RaycastHit2D_ *)v46,
			                                             (Func_2_UnityEngine_RaycastHit2D_Single_ *)_9__4_1,
			                                             MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::FrameSettingsFieldAttribute,int>);
			      v54 = System::Linq::Enumerable::Distinct<int>(v53, MethodInfo::System::Linq::Enumerable::Distinct<int>);
			      if ( v54 )
			      {
			        v130 = sub_1800428A0(0LL, TypeInfo::System::Collections::Generic::IEnumerable<int>, v54);
			        v122._dictionary = 0LL;
			        *(_QWORD *)&v122._index = &v130;
			        try
			        {
			          while ( 1 )
			          {
			            if ( !v130 )
			              sub_1800D8250(v56, v55);
			            if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
			              break;
			            v59 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c__DisplayClass4_0);
			            if ( !v59 )
			              sub_1800D8250(v58, v57);
			            if ( !v130 )
			              sub_1800D8250(v58, v57);
			            *(_DWORD *)(v59 + 16) = sub_1800320D0(0LL, TypeInfo::System::Collections::Generic::IEnumerator<int>, v130);
			            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory);
			            foldoutNames = TypeInfo::HG::Rendering::Runtime::FrameSettingsHistory->static_fields->foldoutNames;
			            v63 = *(int *)(v59 + 16);
			            if ( !foldoutNames )
			              sub_1800D8250(v63, v60);
			            if ( (unsigned int)v63 >= foldoutNames->max_length.size )
			              sub_1800D2AA0(v63, v60, v61);
			            source = (IObservable_1_Object_ *)foldoutNames->vector[v63];
			            v64 = (Predicate_1_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_ *)sub_18002C620(TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,bool>);
			            v67 = (Func_2_System_Collections_Generic_KeyValuePair_2_System_Object_System_Object_Boolean_ *)v64;
			            if ( !v64 )
			              sub_1800D8250(v66, v65);
			            System::Predicate<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile>::Predicate(
			              v64,
			              (Object *)v59,
			              MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c__DisplayClass4_0::_get_Keys_b__4,
			              0LL);
			            v68 = System::Linq::Enumerable::Where<System::Collections::Generic::KeyValuePair<System::Object,System::Object>>(
			                    (IEnumerable_1_KeyValuePair_2_System_Object_System_Object_ *)v11,
			                    v67,
			                    MethodInfo::System::Linq::Enumerable::Where<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>>);
			            if ( v68 )
			            {
			              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
			              _9__4_5 = TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_5;
			              if ( !_9__4_5 )
			              {
			                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
			                v70 = (Object *)TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9;
			                v71 = (Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Int32Enum_ *)sub_18002C620(TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,int>);
			                _9__4_5 = (Func_2_System_Collections_Generic_KeyValuePair_2_HG_Rendering_Runtime_FrameSettingsField_HG_Rendering_Runtime_FrameSettingsFieldAttribute_Int32_ *)v71;
			                if ( !v71 )
			                  sub_1800D8250(v73, v72);
			                System::Func<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile,System::Int32Enum>::Func(
			                  v71,
			                  v70,
			                  MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c::_get_Keys_b__4_5,
			                  0LL);
			                TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_5 = _9__4_5;
			                if ( dword_18F35FD08 )
			                {
			                  v74 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_5 >> 12) & 0x1FFFFF) >> 6;
			                  v75 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_5 >> 12) & 0x3F;
			                  _m_prefetchw(&qword_18F0BCBA0[v74 + 36190]);
			                  do
			                    v76 = qword_18F0BCBA0[v74 + 36190];
			                  while ( v76 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v74 + 36190], v76 | (1LL << v75), v76) );
			                }
			              }
			              v77 = (IEnumerable_1_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_ *)System::Linq::Enumerable::OrderBy<System::Collections::Generic::KeyValuePair<System::Int32Enum,System::Object>,int>((IEnumerable_1_KeyValuePair_2_System_Int32Enum_System_Object_ *)v68, (Func_2_System_Collections_Generic_KeyValuePair_2_System_Int32Enum_System_Object_Int32_ *)_9__4_5, MethodInfo::System::Linq::Enumerable::OrderBy<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,int>);
			              v78 = (Func_2_UnityEngine_Experimental_Rendering_ProbeVolumeSceneData_SerializablePVProfile_Object_ *)sub_18002C620(TypeInfo::System::Func<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
			              v81 = v78;
			              if ( !v78 )
			                sub_1800D8250(v80, v79);
			              System::Func<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile,System::Object>::Func(
			                v78,
			                (Object *)this,
			                MethodInfo::HG::Rendering::Runtime::FrameSettings::FrameSettingsDebugView::_get_Keys_b__4_6,
			                0LL);
			              v82 = System::Linq::Enumerable::Select<UnityEngine::Experimental::Rendering::ProbeVolumeSceneData::SerializablePVProfile,System::Object>(
			                      v77,
			                      v81,
			                      MethodInfo::System::Linq::Enumerable::Select<System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettingsFieldAttribute>,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
			              v83 = System::Linq::Enumerable::ToArray<System::Object>(
			                      v82,
			                      MethodInfo::System::Linq::Enumerable::ToArray<HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
			            }
			            else
			            {
			              v83 = 0LL;
			            }
			            v84 = (WhereObservable_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerGroup);
			            v87 = (Object *)v84;
			            if ( !v84 )
			              sub_1800D8250(v86, v85);
			            UnityEngine::InputSystem::Utilities::WhereObservable<System::Object>::WhereObservable(
			              v84,
			              source,
			              (Func_2_Object_Boolean_ *)v83,
			              0LL);
			            if ( !v15 )
			              sub_1800D8250(v89, v88);
			            sub_182F01190(v15, v87);
			          }
			        }
			        catch ( Il2CppExceptionWrapper *v127 )
			        {
			          v122._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v127->ex;
			          sub_1801F6A10(&v122);
			          v15 = v123;
			          v90 = v124;
			          goto LABEL_50;
			        }
			        sub_1801F6A10(&v122);
			        v90 = v129;
			LABEL_50:
			        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
			        _9__4_2 = TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_2;
			        if ( !_9__4_2 )
			        {
			          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c);
			          v92 = (Object *)TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9;
			          v93 = (Func_2_Int32Enum_Boolean_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsField,bool>);
			          _9__4_2 = (Func_2_HG_Rendering_Runtime_FrameSettingsField_Boolean_ *)v93;
			          if ( !v93 )
			            goto LABEL_92;
			          System::Func<System::Int32Enum,bool>::Func(
			            v93,
			            v92,
			            MethodInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c::_get_Keys_b__4_2,
			            0LL);
			          TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_2 = _9__4_2;
			          if ( dword_18F35FD08 )
			          {
			            v94 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_2 >> 12) & 0x1FFFFF) >> 6;
			            v95 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::FrameSettings_FrameSettingsDebugView::__c->static_fields->__9__4_2 >> 12) & 0x3F;
			            _m_prefetchw(&qword_18F0BCBA0[v94 + 36190]);
			            do
			              v96 = qword_18F0BCBA0[v94 + 36190];
			            while ( v96 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v94 + 36190], v96 | (1LL << v95), v96) );
			          }
			        }
			        v97 = (IEnumerable_1_UnityEngine_InputSystem_Utilities_JsonParser_JsonValue_ *)System::Linq::Enumerable::Where<System::Int32Enum>(
			                                                                                         v90,
			                                                                                         (Func_2_Int32Enum_Boolean_ *)_9__4_2,
			                                                                                         MethodInfo::System::Linq::Enumerable::Where<HG::Rendering::Runtime::FrameSettingsField>);
			        if ( v97 )
			        {
			          v98 = (GenericDelegateCallerGen_int_FStructSize8Delegate_2_System_Int32_Beyond_Reflection_StructSizeGen_FStructSize8_ *)sub_18002C620(TypeInfo::System::Func<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
			          v99 = (Func_2_UnityEngine_InputSystem_Utilities_JsonParser_JsonValue_Object_ *)v98;
			          if ( !v98 )
			            goto LABEL_92;
			          v100 = this;
			          Beyond::Reflection::GenericDelegateCallerGen::int_FStructSize8Delegate<int,Beyond::Reflection::StructSizeGen::FStructSize8>::int_FStructSize8Delegate(
			            v98,
			            (Object *)this,
			            MethodInfo::HG::Rendering::Runtime::FrameSettings::FrameSettingsDebugView::_get_Keys_b__4_3,
			            0LL);
			          v101 = System::Linq::Enumerable::Select<UnityEngine::InputSystem::Utilities::JsonParser::JsonValue,System::Object>(
			                   v97,
			                   v99,
			                   MethodInfo::System::Linq::Enumerable::Select<HG::Rendering::Runtime::FrameSettingsField,HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
			          v102 = System::Linq::Enumerable::ToArray<System::Object>(
			                   v101,
			                   MethodInfo::System::Linq::Enumerable::ToArray<HG::Rendering::Runtime::FrameSettings::DebuggerEntry>);
			        }
			        else
			        {
			          v102 = 0LL;
			          v100 = this;
			        }
			        v103 = (WhereObservable_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerGroup);
			        v104 = (Object *)v103;
			        if ( v103 )
			        {
			          UnityEngine::InputSystem::Utilities::WhereObservable<System::Object>::WhereObservable(
			            v103,
			            (IObservable_1_Object_ *)"Bits without attribute",
			            (Func_2_Object_Boolean_ *)v102,
			            0LL);
			          if ( v15 )
			          {
			            sub_182F01190(v15, v104);
			            v105 = il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerEntry, 1LL);
			            LODWORD(v129) = v100->fields.m_FrameSettings.materialQuality;
			            v106 = (Func_2_Object_Boolean_ *)il2cpp_value_box_0(
			                                               TypeInfo::UnityEngine::Rendering::MaterialQuality,
			                                               &v129);
			            v107 = (WhereObservable_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerEntry);
			            v108 = v107;
			            if ( v107 )
			            {
			              UnityEngine::InputSystem::Utilities::WhereObservable<System::Object>::WhereObservable(
			                v107,
			                (IObservable_1_Object_ *)"materialQuality",
			                v106,
			                0LL);
			              if ( v105 )
			              {
			                sub_180031B10(v105, v108);
			                if ( !*(_DWORD *)(v105 + 24) )
			                  sub_1800D2AA0(v110, v109, v111);
			                *(_QWORD *)(v105 + 32) = v108;
			                if ( dword_18F35FD08 )
			                {
			                  v112 = (((unsigned __int64)(v105 + 32) >> 12) & 0x1FFFFF) >> 6;
			                  _m_prefetchw(&qword_18F0BCBA0[v112 + 36190]);
			                  do
			                    v113 = qword_18F0BCBA0[v112 + 36190];
			                  while ( v113 != _InterlockedCompareExchange64(
			                                    &qword_18F0BCBA0[v112 + 36190],
			                                    v113 | (1LL << (((unsigned __int64)(v105 + 32) >> 12) & 0x3F)),
			                                    v113) );
			                }
			                v114 = (WhereObservable_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::FrameSettings::DebuggerGroup);
			                v115 = (Object *)v114;
			                if ( v114 )
			                {
			                  UnityEngine::InputSystem::Utilities::WhereObservable<System::Object>::WhereObservable(
			                    v114,
			                    (IObservable_1_Object_ *)"Non Bit data",
			                    (Func_2_Object_Boolean_ *)v105,
			                    0LL);
			                  sub_182F01190(v15, v115);
			                  return (FrameSettings_DebuggerGroup__Array *)System::Collections::Generic::List<System::Object>::ToArray(
			                                                                 v15,
			                                                                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::FrameSettings::DebuggerGroup>::ToArray);
			                }
			              }
			            }
			          }
			        }
			      }
			    }
			LABEL_92:
			    sub_1800D8250(dictionary, v27);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3690, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v119, v118);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1293(Patch, (Object *)this, 0LL);
			}
			
	
			// Constructors
			public FrameSettingsDebugView() {} // Dummy constructor
			public FrameSettingsDebugView(FrameSettings frameSettings) {} // 0x0000000184D99830-0x0000000184D99850
			// Void set_value(Ray)
			void ParadoxNotion::EventData<UnityEngine::Ray>::set_value(
			        EventData_1_UnityEngine_Ray_ *this,
			        Ray *value,
			        MethodInfo *method)
			{
			  __int64 v3; // xmm1_8
			
			  v3 = *(_QWORD *)&value->m_Direction.y;
			  *(_OWORD *)&this->_value_k__BackingField.m_Origin.x = *(_OWORD *)&value->m_Origin.x;
			  *(_QWORD *)&this->_value_k__BackingField.m_Direction.y = v3;
			}
			
		}
	
		// Methods
		internal static FrameSettings NewDefaultCamera() => default; // 0x00000001837DAB40-0x00000001837DABD0
		// FrameSettings NewDefaultCamera()
		FrameSettings *HG::Rendering::Runtime::FrameSettings::NewDefaultCamera(
		        FrameSettings *__return_ptr retstr,
		        MethodInfo *method)
		{
		  Array *v3; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  BitArray128 *v8; // rax
		  uint64_t data1; // xmm1_8
		  BitArray128 v10; // [rsp+20h] [rbp-38h] BYREF
		  FrameSettings v11; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3670, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3670, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = (BitArray128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1279(&v11, Patch, 0LL);
		    data1 = v8[1].data1;
		    retstr->bitDatas = *v8;
		    *(_QWORD *)&retstr->materialQuality = data1;
		  }
		  else
		  {
		    *(_QWORD *)&v11.materialQuality = 0LL;
		    v3 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::UInt32, 18LL);
		    System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		      v3,
		      77A2EB460A3818E210E2F840DDA09B2C807220E7A60104E92E0DDEFEC1B387EC_Field,
		      0LL);
		    v10 = 0LL;
		    UnityEngine::Rendering::BitArray128::BitArray128(&v10, (IEnumerable_1_System_UInt32_ *)v3, 0LL);
		    retstr->bitDatas = v10;
		    *(_QWORD *)&retstr->materialQuality = *(_QWORD *)&v11.materialQuality;
		  }
		  return retstr;
		}
		
		internal static FrameSettings NewDefaultRealtimeReflectionProbe() => default; // 0x00000001837D8EE0-0x00000001837D8F70
		// FrameSettings NewDefaultRealtimeReflectionProbe()
		FrameSettings *HG::Rendering::Runtime::FrameSettings::NewDefaultRealtimeReflectionProbe(
		        FrameSettings *__return_ptr retstr,
		        MethodInfo *method)
		{
		  Array *v3; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  BitArray128 *v8; // rax
		  uint64_t data1; // xmm1_8
		  BitArray128 v10; // [rsp+20h] [rbp-38h] BYREF
		  FrameSettings v11; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3671, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3671, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = (BitArray128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1279(&v11, Patch, 0LL);
		    data1 = v8[1].data1;
		    retstr->bitDatas = *v8;
		    *(_QWORD *)&retstr->materialQuality = data1;
		  }
		  else
		  {
		    *(_QWORD *)&v11.materialQuality = 0LL;
		    v3 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::UInt32, 10LL);
		    System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		      v3,
		      DD57B6A9816D1DE2228F42CF6225F4F4C257A77DA881CBB6958B859986C6AF92_Field,
		      0LL);
		    v10 = 0LL;
		    UnityEngine::Rendering::BitArray128::BitArray128(&v10, (IEnumerable_1_System_UInt32_ *)v3, 0LL);
		    retstr->bitDatas = v10;
		    *(_QWORD *)&retstr->materialQuality = *(_QWORD *)&v11.materialQuality;
		  }
		  return retstr;
		}
		
		internal static FrameSettings NewDefaultCustomOrBakeReflectionProbe() => default; // 0x00000001837D8E50-0x00000001837D8EE0
		// FrameSettings NewDefaultCustomOrBakeReflectionProbe()
		FrameSettings *HG::Rendering::Runtime::FrameSettings::NewDefaultCustomOrBakeReflectionProbe(
		        FrameSettings *__return_ptr retstr,
		        MethodInfo *method)
		{
		  Array *v3; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  BitArray128 *v8; // rax
		  uint64_t data1; // xmm1_8
		  BitArray128 v10; // [rsp+20h] [rbp-38h] BYREF
		  FrameSettings v11; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3672, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3672, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = (BitArray128 *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1279(&v11, Patch, 0LL);
		    data1 = v8[1].data1;
		    retstr->bitDatas = *v8;
		    *(_QWORD *)&retstr->materialQuality = data1;
		  }
		  else
		  {
		    *(_QWORD *)&v11.materialQuality = 0LL;
		    v3 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::UInt32, 12LL);
		    System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		      v3,
		      E4124068B388CAE09971E522698B949597FCE871A01FA3D95EEAEC672859F2A2_Field,
		      0LL);
		    v10 = 0LL;
		    UnityEngine::Rendering::BitArray128::BitArray128(&v10, (IEnumerable_1_System_UInt32_ *)v3, 0LL);
		    retstr->bitDatas = v10;
		    *(_QWORD *)&retstr->materialQuality = *(_QWORD *)&v11.materialQuality;
		  }
		  return retstr;
		}
		
		public bool IsEnabled(FrameSettingsField field) => default; // 0x000000018344FDD0-0x000000018344FE60
		// Boolean IsEnabled(FrameSettingsField)
		bool HG::Rendering::Runtime::FrameSettings::IsEnabled(
		        FrameSettings *this,
		        FrameSettingsField__Enum field,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int64 v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 734 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x2DE )
		        sub_1800D2AB0(v5, wrapperArray);
		      if ( !*(_QWORD *)&v5[15]._1.static_fields_size )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(734, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_292(Patch, this, field, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v5, wrapperArray);
		  }
		LABEL_5:
		  v7 = 1LL << (field & 0x3F);
		  if ( (unsigned int)field >= 0x40 )
		    return (v7 & this->bitDatas.data2) != 0;
		  else
		    return (v7 & this->bitDatas.data1) != 0;
		}
		
		public void SetEnabled(FrameSettingsField field, bool value) {} // 0x0000000189C074C0-0x0000000189C07538
		// Void SetEnabled(FrameSettingsField, Boolean)
		void HG::Rendering::Runtime::FrameSettings::SetEnabled(
		        FrameSettings *this,
		        FrameSettingsField__Enum field,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3673, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3673, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1280(Patch, this, field, value, 0LL);
		  }
		  else
		  {
		    UnityEngine::Rendering::BitArray128::set_Item(&this->bitDatas, field, value, 0LL);
		  }
		}
		
		internal static void Override(ref FrameSettings overriddenFrameSettings, FrameSettings overridingFrameSettings, FrameSettingsOverrideMask frameSettingsOverideMask) {} // 0x0000000189C07378-0x0000000189C074C0
		// Void Override(FrameSettings ByRef, FrameSettings, FrameSettingsOverrideMask)
		void HG::Rendering::Runtime::FrameSettings::Override(
		        FrameSettings *overriddenFrameSettings,
		        FrameSettings *overridingFrameSettings,
		        FrameSettingsOverrideMask *frameSettingsOverideMask,
		        MethodInfo *method)
		{
		  FrameSettingsOverrideMask v7; // xmm1
		  BitArray128 v8; // xmm2
		  uint64_t data2; // rax
		  uint64_t v10; // rcx
		  BitArray128 v11; // xmm0
		  BitArray128 *v12; // rax
		  bool v13; // zf
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  BitArray128 bitDatas; // xmm1
		  BitArray128 v18; // [rsp+38h] [rbp-9h] BYREF
		  BitArray128 v19; // [rsp+48h] [rbp+7h] BYREF
		  BitArray128 v20; // [rsp+58h] [rbp+17h] BYREF
		  BitArray128 mask; // [rsp+68h] [rbp+27h] BYREF
		  FrameSettings v22; // [rsp+78h] [rbp+37h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(686, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(686, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    bitDatas = overridingFrameSettings->bitDatas;
		    mask = frameSettingsOverideMask->mask;
		    *(_QWORD *)&v22.materialQuality = *(_QWORD *)&overridingFrameSettings->materialQuality;
		    v22.bitDatas = bitDatas;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_268(
		      Patch,
		      overriddenFrameSettings,
		      &v22,
		      (FrameSettingsOverrideMask *)&mask,
		      0LL);
		  }
		  else
		  {
		    v7 = *frameSettingsOverideMask;
		    v8 = overridingFrameSettings->bitDatas;
		    data2 = frameSettingsOverideMask->mask.data2;
		    v10 = ~frameSettingsOverideMask->mask.data1;
		    *(_QWORD *)&v22.materialQuality = *(_QWORD *)&overridingFrameSettings->materialQuality;
		    v11 = overriddenFrameSettings->bitDatas;
		    v18.data1 = v10;
		    v18.data2 = ~data2;
		    v20 = v7.mask;
		    v19 = v11;
		    mask = v8;
		    v19 = *UnityEngine::Rendering::BitArray128::op_BitwiseAnd(&v22.bitDatas, &v18, &v19, 0LL);
		    mask = *UnityEngine::Rendering::BitArray128::op_BitwiseAnd(&v22.bitDatas, &mask, &v20, 0LL);
		    v12 = UnityEngine::Rendering::BitArray128::op_BitwiseOr(&v22.bitDatas, &mask, &v19, 0LL);
		    v13 = (frameSettingsOverideMask->mask.data2 & 4) == 0;
		    overriddenFrameSettings->bitDatas = *v12;
		    if ( !v13 )
		    {
		      *(_QWORD *)&v22.materialQuality = *(_QWORD *)&overridingFrameSettings->materialQuality;
		      overriddenFrameSettings->materialQuality = v22.materialQuality;
		    }
		  }
		}
		
		internal static void Sanitize(ref FrameSettings sanitizedFrameSettings, Camera camera, [IsReadOnly] in RenderPipelineSettings renderPipelineSettings) {} // 0x000000018344FE60-0x00000001834502D0
		// Void Sanitize(FrameSettings ByRef, Camera, RenderPipelineSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::Sanitize(
		        FrameSettings *sanitizedFrameSettings,
		        Camera *camera,
		        RenderPipelineSettings *renderPipelineSettings,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  unsigned int (__fastcall *v9)(Camera *, ILFixDynamicMethodWrapper_2__Array *, RenderPipelineSettings *, MethodInfo *); // rax
		  bool v10; // r15
		  void (__fastcall *v11)(Camera *, Matrix4x4 *); // rax
		  __int128 v12; // xmm6
		  __int128 v13; // xmm7
		  bool v14; // zf
		  __int128 v15; // xmm8
		  __int128 v16; // xmm9
		  struct ILFixDynamicMethodWrapper_2__Class *v17; // rcx
		  char v18; // r14
		  ILFixDynamicMethodWrapper_2__Array *v19; // rdx
		  unsigned int (__fastcall *v20)(Camera *); // rax
		  bool v21; // bl
		  char v22; // si
		  uint64_t data1; // rax
		  unsigned __int64 v24; // rax
		  unsigned __int64 v25; // rax
		  unsigned __int64 v26; // rax
		  unsigned __int64 v27; // rax
		  unsigned __int64 v28; // rax
		  bool v29; // dl
		  unsigned __int64 v30; // rax
		  bool v31; // dl
		  unsigned __int64 v32; // rax
		  unsigned __int64 v33; // rax
		  unsigned __int64 v34; // rax
		  uint64_t v35; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v37; // rax
		  __int64 v38; // rax
		  ILFixDynamicMethodWrapper_2 *v39; // rax
		  ILFixDynamicMethodWrapper_2 *v40; // rax
		  __int64 v41; // rax
		  Object *v42; // rbx
		  ILFixDynamicMethodWrapper_2 *v43; // rax
		  Object *component; // [rsp+38h] [rbp-81h] BYREF
		  Matrix4x4 v45; // [rsp+40h] [rbp-79h] BYREF
		  Matrix4x4 v46; // [rsp+80h] [rbp-39h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_59;
		  if ( wrapperArray->max_length.size > 687 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v6->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_59;
		    if ( wrapperArray->max_length.size <= 0x2AFu )
		      goto LABEL_105;
		    if ( wrapperArray[19].vector[3] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(687, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_270(
		          Patch,
		          sanitizedFrameSettings,
		          (Object *)camera,
		          renderPipelineSettings,
		          0LL);
		        return;
		      }
		      goto LABEL_59;
		    }
		  }
		  if ( !camera )
		    goto LABEL_59;
		  v9 = (unsigned int (__fastcall *)(Camera *, ILFixDynamicMethodWrapper_2__Array *, RenderPipelineSettings *, MethodInfo *))qword_18F36F138;
		  if ( !qword_18F36F138 )
		  {
		    v9 = (unsigned int (__fastcall *)(Camera *, ILFixDynamicMethodWrapper_2__Array *, RenderPipelineSettings *, MethodInfo *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cameraType()");
		    if ( !v9 )
		    {
		      v37 = sub_1802EE1B8("UnityEngine.Camera::get_cameraType()");
		      sub_18007E1B0(v37, 0LL);
		    }
		    qword_18F36F138 = (__int64)v9;
		  }
		  v10 = v9(camera, wrapperArray, renderPipelineSettings, method) == 16;
		  v11 = (void (__fastcall *)(Camera *, Matrix4x4 *))qword_18F36F228;
		  memset(&v46, 0, sizeof(v46));
		  if ( !qword_18F36F228 )
		  {
		    v11 = (void (__fastcall *)(Camera *, Matrix4x4 *))il2cpp_resolve_icall_1(
		                                                        "UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
		    if ( !v11 )
		    {
		      v38 = sub_1802EE1B8("UnityEngine.Camera::get_projectionMatrix_Injected(UnityEngine.Matrix4x4&)");
		      sub_18007E1B0(v38, 0LL);
		    }
		    qword_18F36F228 = (__int64)v11;
		  }
		  v11(camera, &v46);
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v12 = *(_OWORD *)&v46.m00;
		  v13 = *(_OWORD *)&v46.m01;
		  v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor == 0;
		  v15 = *(_OWORD *)&v46.m02;
		  v16 = *(_OWORD *)&v46.m03;
		  v45 = v46;
		  if ( v14 )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_59;
		  if ( wrapperArray->max_length.size <= 406 )
		    goto LABEL_12;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_59;
		  if ( wrapperArray->max_length.size <= 0x196u )
		    goto LABEL_105;
		  if ( wrapperArray[11].vector[10] )
		  {
		    v39 = IFix::WrappersManagerImpl::GetPatch(406, 0LL);
		    if ( !v39 )
		      goto LABEL_59;
		    *(_OWORD *)&v45.m00 = v12;
		    *(_OWORD *)&v45.m01 = v13;
		    *(_OWORD *)&v45.m02 = v15;
		    *(_OWORD *)&v45.m03 = v16;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_197(v39, &v45, 0LL);
		  }
		  else
		  {
		LABEL_12:
		    if ( UnityEngine::Matrix4x4::get_Item(&v45, 2, 0LL) == 0.0 )
		      UnityEngine::Matrix4x4::get_Item(&v45, 6, 0LL);
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v18 = 0;
		  component = 0LL;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v19 = v17->static_fields->wrapperArray;
		  if ( !v19 )
		    goto LABEL_60;
		  if ( v19->max_length.size > 688 )
		  {
		    if ( !v17->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v17);
		      v17 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v17 = (struct ILFixDynamicMethodWrapper_2__Class *)v17->static_fields->wrapperArray;
		    if ( !v17 )
		      goto LABEL_60;
		    if ( LODWORD(v17->_0.namespaze) <= 0x2B0 )
		      sub_1800D2AB0(v17, v19);
		    if ( *(_QWORD *)&v17[14]._1.thread_static_fields_offset )
		    {
		      v40 = IFix::WrappersManagerImpl::GetPatch(688, 0LL);
		      if ( v40 )
		      {
		        v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v40, (Object *)camera, 0LL);
		        goto LABEL_23;
		      }
		      goto LABEL_60;
		    }
		  }
		  v20 = (unsigned int (__fastcall *)(Camera *))qword_18F36F138;
		  if ( !qword_18F36F138 )
		  {
		    v20 = (unsigned int (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_cameraType()");
		    if ( !v20 )
		    {
		      v41 = sub_1802EE1B8("UnityEngine.Camera::get_cameraType()");
		      sub_18007E1B0(v41, 0LL);
		    }
		    qword_18F36F138 = (__int64)v20;
		  }
		  if ( v20(camera) != 4 )
		  {
		    v21 = 0;
		    goto LABEL_23;
		  }
		  UnityEngine::Component::TryGetComponent<System::Object>(
		    (Component *)camera,
		    &component,
		    MethodInfo::UnityEngine::Component::TryGetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
		  v42 = component;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality((Object_1 *)v42, 0LL, 0LL) )
		  {
		    v21 = 1;
		    goto LABEL_23;
		  }
		  if ( !component )
		LABEL_60:
		    sub_1800D8260(v17, v19);
		  v21 = LOBYTE(component[22].klass) == 0;
		LABEL_23:
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_59;
		  v22 = 1;
		  if ( wrapperArray->max_length.size > 690 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( !v6 )
		      goto LABEL_59;
		    if ( LODWORD(v6->_0.namespaze) > 0x2B2 )
		    {
		      if ( !*(_QWORD *)&v6[14]._1.field_count )
		        goto LABEL_27;
		      v43 = IFix::WrappersManagerImpl::GetPatch(690, 0LL);
		      if ( v43 )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_269(v43, sanitizedFrameSettings, LitShaderMode__Enum_Deferred, 0LL);
		        goto LABEL_28;
		      }
		LABEL_59:
		      sub_1800D8260(v6, wrapperArray);
		    }
		LABEL_105:
		    sub_1800D2AB0(v6, wrapperArray);
		  }
		LABEL_27:
		  sanitizedFrameSettings->bitDatas.data1 |= 1uLL;
		LABEL_28:
		  data1 = sanitizedFrameSettings->bitDatas.data1;
		  if ( (sanitizedFrameSettings->bitDatas.data1 & 0x100000) != 0 && !v21 )
		    v24 = data1 | 0x100000;
		  else
		    v24 = data1 & 0xFFFFFFFFFFEFFFFFuLL;
		  if ( (v24 & 0x200000) != 0 && !v21 )
		    v25 = v24 | 0x200000;
		  else
		    v25 = v24 & 0xFFFFFFFFFFDFFFFFuLL;
		  if ( (v25 & 0x800000) != 0 && !v21 )
		    v26 = v25 | 0x800000;
		  else
		    v26 = v25 & 0xFFFFFFFFFF7FFFFFuLL;
		  if ( (v26 & 0x400000) != 0 && !v21 )
		    v27 = v26 | 0x400000;
		  else
		    v27 = v26 & 0xFFFFFFFFFFBFFFFFuLL;
		  if ( (v27 & 0x40000000) != 0 && !v21 )
		    v28 = v27 | 0x40000000;
		  else
		    v28 = v27 & 0xFFFFFFFFBFFFFFFFuLL;
		  v29 = !v10 && !v21;
		  if ( (v28 & 0x8000) != 0 && v29 )
		    v30 = v28 | 0x8000;
		  else
		    v30 = v28 & 0xFFFFFFFFFFFF7FFFuLL;
		  v31 = !v21 && (v30 & 8) != 0;
		  if ( (v30 & 0x100) != 0 && v31 )
		    v32 = v30 | 0x100;
		  else
		    v32 = v30 & 0xFFFFFFFFFFFFFEFFuLL;
		  if ( (v32 & 0x1000) != 0 && !v21 )
		    v33 = v32 | 0x1000;
		  else
		    v33 = v32 & 0xFFFFFFFFFFFFEFFFuLL;
		  if ( !v21 )
		  {
		    if ( (v33 & 8) == 0 )
		      v22 = 0;
		    v18 = v22;
		  }
		  if ( (((v33 & 0x200) != 0) & (unsigned __int8)v18) != 0 )
		    v34 = v33 | 0x200;
		  else
		    v34 = v33 & 0xFFFFFFFFFFFFFDFFuLL;
		  if ( (v34 & 8) != 0 && (v34 & 0x40000) != 0 )
		    v35 = v34 | 0x40000;
		  else
		    v35 = v34 & 0xFFFFFFFFFFFBFFFFuLL;
		  sanitizedFrameSettings->bitDatas.data1 = v35;
		}
		
		[IDTag(1)]
		internal static void AggregateFrameSettings(ref FrameSettings aggregatedFrameSettings, Camera camera, HGAdditionalCameraData additionalData, HGRenderPipelineAsset hgrpAsset) {} // 0x000000018344D760-0x000000018344DA40
		// Void AggregateFrameSettings(FrameSettings ByRef, Camera, HGAdditionalCameraData, HGRenderPipelineAsset)
		void HG::Rendering::Runtime::FrameSettings::AggregateFrameSettings(
		        FrameSettings *aggregatedFrameSettings,
		        Camera *camera,
		        HGAdditionalCameraData *additionalData,
		        HGRenderPipelineAsset *hgrpAsset,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *static_fields; // rcx
		  _DWORD *wrapperArray; // rdx
		  HGRenderPipelineGlobalSettings *instance; // rax
		  Object *v12; // rsi
		  unsigned int defaultFrameSettings; // r14d
		  struct ILFixDynamicMethodWrapper_2__Class *v14; // rax
		  FrameSettings *p_monitor; // rsi
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm2
		  __int128 v19; // xmm3
		  __int128 v20; // xmm4
		  __int128 v21; // xmm5
		  __int128 v22; // xmm6
		  __int64 v23; // xmm0_8
		  struct Object_1__Class *v24; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v26; // r8
		  ILFixDynamicMethodWrapper_2 *v27; // rax
		  unsigned int v28; // r14d
		  __int64 v29; // rax
		  SystemException *v30; // rbx
		  String *v31; // rax
		  __int64 v32; // rax
		  __int64 v33; // r8
		  ILFixDynamicMethodWrapper_2 *v34; // rax
		  RenderPipelineSettings *v35; // rax
		  const Il2CppImage *image; // rax
		  ILFixDynamicMethodWrapper_2 *v37; // rax
		  FrameSettings *renderingPathCustomFrameSettings; // rax
		  BitArray128 bitDatas; // xmm1
		  __int64 v40; // xmm0_8
		  RenderPipelineSettings renderPipelineSettings; // [rsp+40h] [rbp-138h] BYREF
		  FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask; // [rsp+B0h] [rbp-C8h] BYREF
		  FrameSettings v43; // [rsp+C0h] [rbp-B8h] BYREF
		  RenderPipelineSettings v44; // [rsp+E0h] [rbp-98h] BYREF
		
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  memset(&renderPipelineSettings, 0, sizeof(renderPipelineSettings));
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = static_fields->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_34;
		  if ( (int)wrapperArray[6] > 693 )
		  {
		    if ( !static_fields->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(static_fields);
		      static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = static_fields->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_34;
		    if ( wrapperArray[6] <= 0x2B5u )
		      goto LABEL_72;
		    if ( *((_QWORD *)wrapperArray + 697) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(693, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_275(
		          Patch,
		          aggregatedFrameSettings,
		          (Object *)camera,
		          (Object *)additionalData,
		          (Object *)hgrpAsset,
		          0LL);
		        return;
		      }
		      goto LABEL_34;
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings);
		  instance = HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::get_instance(0LL);
		  v12 = (Object *)instance;
		  if ( additionalData )
		    defaultFrameSettings = additionalData->fields.defaultFrameSettings;
		  else
		    defaultFrameSettings = 0;
		  if ( !instance )
		    goto LABEL_34;
		  v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields;
		  wrapperArray = static_fields->_0.image;
		  if ( !static_fields->_0.image )
		    goto LABEL_34;
		  if ( (int)wrapperArray[6] <= 684 )
		    goto LABEL_14;
		  if ( !v14->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v14);
		    v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v14->static_fields;
		  v26 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_34;
		  if ( *(_DWORD *)(v26 + 24) <= 0x2ACu )
		    goto LABEL_72;
		  if ( *(_QWORD *)(v26 + 5504) )
		  {
		    v27 = IFix::WrappersManagerImpl::GetPatch(684, 0LL);
		    if ( !v27 )
		      goto LABEL_34;
		    p_monitor = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_267(
		                  v27,
		                  v12,
		                  (FrameSettingsRenderType__Enum)defaultFrameSettings,
		                  0LL);
		    v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_14:
		    if ( defaultFrameSettings )
		    {
		      v28 = defaultFrameSettings - 1;
		      if ( v28 )
		      {
		        if ( v28 != 1 )
		        {
		          v29 = sub_180035ED0(&TypeInfo::System::ArgumentException);
		          v30 = (SystemException *)sub_1800368D0(v29);
		          if ( v30 )
		          {
		            v31 = (String *)sub_180035ED0(&off_18E2667C0);
		            System::SystemException::SystemException(v30, v31, 0LL);
		            v30->fields._._HResult = -2147024809;
		            v32 = sub_180035ED0(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineGlobalSettings::GetDefaultFrameSettings);
		            sub_18007E190(v30, v32);
		          }
		          goto LABEL_34;
		        }
		        p_monitor = (FrameSettings *)&v12[5].monitor;
		      }
		      else
		      {
		        p_monitor = (FrameSettings *)&v12[4];
		      }
		    }
		    else
		    {
		      p_monitor = (FrameSettings *)&v12[2].monitor;
		    }
		  }
		  if ( !hgrpAsset )
		    goto LABEL_34;
		  if ( !v14->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v14);
		    v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields;
		  wrapperArray = static_fields->_0.image;
		  if ( !static_fields->_0.image )
		    goto LABEL_34;
		  if ( (int)wrapperArray[6] <= 459 )
		    goto LABEL_21;
		  if ( !v14->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v14);
		    v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v14->static_fields;
		  v33 = *(_QWORD *)wrapperArray;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_34;
		  if ( *(_DWORD *)(v33 + 24) <= 0x1CBu )
		    goto LABEL_72;
		  if ( *(_QWORD *)(v33 + 3704) )
		  {
		    v34 = IFix::WrappersManagerImpl::GetPatch(459, 0LL);
		    if ( !v34 )
		      goto LABEL_34;
		    v35 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_216(&v44, v34, (Object *)hgrpAsset, 0LL);
		    v16 = *(_OWORD *)&v35->colorBufferFormat;
		    v17 = *(_OWORD *)&v35->dynamicResolutionSettings.DLSSSharpness;
		    v18 = *(_OWORD *)&v35->dynamicResolutionSettings.forcedPercentage;
		    v19 = *(_OWORD *)&v35->m_ObsoleteLightLayerName0;
		    v20 = *(_OWORD *)&v35->m_ObsoleteLightLayerName2;
		    v21 = *(_OWORD *)&v35->m_ObsoleteLightLayerName4;
		    v22 = *(_OWORD *)&v35->m_ObsoleteLightLayerName6;
		    v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_21:
		    v16 = *(_OWORD *)&hgrpAsset->fields.m_RenderPipelineSettings.colorBufferFormat;
		    v17 = *(_OWORD *)&hgrpAsset->fields.m_RenderPipelineSettings.dynamicResolutionSettings.DLSSSharpness;
		    v18 = *(_OWORD *)&hgrpAsset->fields.m_RenderPipelineSettings.dynamicResolutionSettings.forcedPercentage;
		    v19 = *(_OWORD *)&hgrpAsset->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName0;
		    v20 = *(_OWORD *)&hgrpAsset->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName2;
		    v21 = *(_OWORD *)&hgrpAsset->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName4;
		    v22 = *(_OWORD *)&hgrpAsset->fields.m_RenderPipelineSettings.m_ObsoleteLightLayerName6;
		  }
		  *(_OWORD *)&renderPipelineSettings.colorBufferFormat = v16;
		  *(_OWORD *)&renderPipelineSettings.dynamicResolutionSettings.DLSSSharpness = v17;
		  *(_OWORD *)&renderPipelineSettings.dynamicResolutionSettings.forcedPercentage = v18;
		  *(_OWORD *)&renderPipelineSettings.m_ObsoleteLightLayerName0 = v19;
		  *(_OWORD *)&renderPipelineSettings.m_ObsoleteLightLayerName2 = v20;
		  *(_OWORD *)&renderPipelineSettings.m_ObsoleteLightLayerName4 = v21;
		  *(_OWORD *)&renderPipelineSettings.m_ObsoleteLightLayerName6 = v22;
		  if ( !v14->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v14);
		    v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields;
		  wrapperArray = static_fields->_0.image;
		  if ( !static_fields->_0.image )
		    goto LABEL_34;
		  if ( (int)wrapperArray[6] <= 694 )
		    goto LABEL_26;
		  if ( !v14->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v14);
		    v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v14->static_fields;
		  image = static_fields->_0.image;
		  if ( !static_fields->_0.image )
		LABEL_34:
		    sub_1800D8260(static_fields, wrapperArray);
		  if ( image->typeCount <= 0x2B6 )
		LABEL_72:
		    sub_1800D2AB0(static_fields, wrapperArray);
		  if ( image[77].metadataHandle )
		  {
		    v37 = IFix::WrappersManagerImpl::GetPatch(694, 0LL);
		    if ( v37 )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(
		        v37,
		        aggregatedFrameSettings,
		        (Object *)camera,
		        (Object *)additionalData,
		        p_monitor,
		        &renderPipelineSettings,
		        0LL);
		      return;
		    }
		    goto LABEL_34;
		  }
		LABEL_26:
		  v23 = *(_QWORD *)&p_monitor->materialQuality;
		  aggregatedFrameSettings->bitDatas = p_monitor->bitDatas;
		  *(_QWORD *)&aggregatedFrameSettings->materialQuality = v23;
		  v24 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v24 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v24 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( additionalData )
		  {
		    if ( !v24->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v24);
		    if ( additionalData->fields._._._._.m_CachedPtr )
		    {
		      if ( additionalData->fields.customRenderingSettings != (additionalData->fields._._._._.m_CachedPtr == 0LL) )
		      {
		        renderingPathCustomFrameSettings = HG::Rendering::Runtime::HGAdditionalCameraData::get_renderingPathCustomFrameSettings(
		                                             additionalData,
		                                             0LL);
		        bitDatas = renderingPathCustomFrameSettings->bitDatas;
		        renderingPathCustomFrameSettingsOverrideMask = additionalData->fields.renderingPathCustomFrameSettingsOverrideMask;
		        v40 = *(_QWORD *)&renderingPathCustomFrameSettings->materialQuality;
		        v43.bitDatas = bitDatas;
		        *(_QWORD *)&v43.materialQuality = v40;
		        HG::Rendering::Runtime::FrameSettings::Override(
		          aggregatedFrameSettings,
		          &v43,
		          &renderingPathCustomFrameSettingsOverrideMask,
		          0LL);
		      }
		    }
		  }
		  HG::Rendering::Runtime::FrameSettings::Sanitize(aggregatedFrameSettings, camera, &renderPipelineSettings, 0LL);
		}
		
		[IDTag(0)]
		internal static void AggregateFrameSettings(ref FrameSettings aggregatedFrameSettings, Camera camera, HGAdditionalCameraData additionalData, ref FrameSettings defaultFrameSettings, [IsReadOnly] in RenderPipelineSettings supportedFeatures) {} // 0x000000018344E0B0-0x000000018344E1C0
		// Void AggregateFrameSettings(FrameSettings ByRef, Camera, HGAdditionalCameraData, FrameSettings ByRef, RenderPipelineSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::AggregateFrameSettings(
		        FrameSettings *aggregatedFrameSettings,
		        Camera *camera,
		        HGAdditionalCameraData *additionalData,
		        FrameSettings *defaultFrameSettings,
		        RenderPipelineSettings *supportedFeatures,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v8; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  __int64 v12; // xmm0_8
		  struct Object_1__Class *v13; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  FrameSettings *renderingPathCustomFrameSettings; // rax
		  BitArray128 bitDatas; // xmm1
		  __int64 v17; // xmm0_8
		  FrameSettingsOverrideMask renderingPathCustomFrameSettingsOverrideMask; // [rsp+40h] [rbp-38h] BYREF
		  FrameSettings v19; // [rsp+50h] [rbp-28h] BYREF
		
		  v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v8->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_15;
		  if ( wrapperArray->max_length.size > 694 )
		  {
		    if ( !v8->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v8);
		      v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v8 = (struct ILFixDynamicMethodWrapper_2__Class *)v8->static_fields->wrapperArray;
		    if ( v8 )
		    {
		      if ( LODWORD(v8->_0.namespaze) <= 0x2B6 )
		        sub_1800D2AB0(v8, camera);
		      if ( !v8[14].vtable.Equals.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(694, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(
		          Patch,
		          aggregatedFrameSettings,
		          (Object *)camera,
		          (Object *)additionalData,
		          defaultFrameSettings,
		          supportedFeatures,
		          0LL);
		        return;
		      }
		    }
		LABEL_15:
		    sub_1800D8260(v8, camera);
		  }
		LABEL_5:
		  v12 = *(_QWORD *)&defaultFrameSettings->materialQuality;
		  aggregatedFrameSettings->bitDatas = defaultFrameSettings->bitDatas;
		  *(_QWORD *)&aggregatedFrameSettings->materialQuality = v12;
		  v13 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v13 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v13 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( additionalData )
		  {
		    if ( !v13->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v13);
		    if ( additionalData->fields._._._._.m_CachedPtr )
		    {
		      if ( additionalData->fields.customRenderingSettings != (additionalData->fields._._._._.m_CachedPtr == 0LL) )
		      {
		        renderingPathCustomFrameSettings = HG::Rendering::Runtime::HGAdditionalCameraData::get_renderingPathCustomFrameSettings(
		                                             additionalData,
		                                             0LL);
		        bitDatas = renderingPathCustomFrameSettings->bitDatas;
		        renderingPathCustomFrameSettingsOverrideMask = additionalData->fields.renderingPathCustomFrameSettingsOverrideMask;
		        v17 = *(_QWORD *)&renderingPathCustomFrameSettings->materialQuality;
		        v19.bitDatas = bitDatas;
		        *(_QWORD *)&v19.materialQuality = v17;
		        HG::Rendering::Runtime::FrameSettings::Override(
		          aggregatedFrameSettings,
		          &v19,
		          &renderingPathCustomFrameSettingsOverrideMask,
		          0LL);
		      }
		    }
		  }
		  HG::Rendering::Runtime::FrameSettings::Sanitize(aggregatedFrameSettings, camera, supportedFeatures, 0LL);
		}
		
		public static bool operator ==(FrameSettings a, FrameSettings b) => default; // 0x0000000189C0761C-0x0000000189C076FC
		// Boolean op_Equality(FrameSettings, FrameSettings)
		bool HG::Rendering::Runtime::FrameSettings::op_Equality(FrameSettings *a, FrameSettings *b, MethodInfo *method)
		{
		  BitArray128 v5; // xmm2
		  BitArray128 v6; // xmm1
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // xmm1_8
		  BitArray128 bitDatas; // xmm0
		  __int64 v13; // xmm1_8
		  FrameSettings v14; // [rsp+20h] [rbp-40h] BYREF
		  FrameSettings v15; // [rsp+40h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(692, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(692, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    v11 = *(_QWORD *)&b->materialQuality;
		    v15.bitDatas = b->bitDatas;
		    bitDatas = a->bitDatas;
		    *(_QWORD *)&v15.materialQuality = v11;
		    v13 = *(_QWORD *)&a->materialQuality;
		    v14.bitDatas = bitDatas;
		    *(_QWORD *)&v14.materialQuality = v13;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_271(Patch, &v14, &v15, 0LL);
		  }
		  else
		  {
		    v5 = a->bitDatas;
		    v6 = b->bitDatas;
		    *(_QWORD *)&v15.materialQuality = *(_QWORD *)&a->materialQuality;
		    *(_QWORD *)&v15.materialQuality = *(_QWORD *)&b->materialQuality;
		    v14.bitDatas = v6;
		    v15.bitDatas = v5;
		    result = UnityEngine::XR::MeshId::Equals((MeshId *)&v15, (MeshId *)&v14, 0LL);
		    if ( result )
		    {
		      *(_QWORD *)&v14.materialQuality = *(_QWORD *)&a->materialQuality;
		      return v14.materialQuality == (unsigned int)*(_QWORD *)&b->materialQuality;
		    }
		  }
		  return result;
		}
		
		public static bool operator !=(FrameSettings a, FrameSettings b) => default; // 0x0000000189C076FC-0x0000000189C077B8
		// Boolean op_Inequality(FrameSettings, FrameSettings)
		bool HG::Rendering::Runtime::FrameSettings::op_Inequality(FrameSettings *a, FrameSettings *b, MethodInfo *method)
		{
		  __int64 v5; // xmm1_8
		  BitArray128 v6; // xmm0
		  __int64 v7; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // xmm1_8
		  BitArray128 bitDatas; // xmm0
		  __int64 v14; // xmm1_8
		  FrameSettings v15; // [rsp+20h] [rbp-40h] BYREF
		  FrameSettings v16; // [rsp+40h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(691, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(691, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    v12 = *(_QWORD *)&b->materialQuality;
		    v16.bitDatas = b->bitDatas;
		    bitDatas = a->bitDatas;
		    *(_QWORD *)&v16.materialQuality = v12;
		    v14 = *(_QWORD *)&a->materialQuality;
		    v15.bitDatas = bitDatas;
		    *(_QWORD *)&v15.materialQuality = v14;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_271(Patch, &v15, &v16, 0LL);
		  }
		  else
		  {
		    v5 = *(_QWORD *)&b->materialQuality;
		    v15.bitDatas = b->bitDatas;
		    v6 = a->bitDatas;
		    *(_QWORD *)&v15.materialQuality = v5;
		    v7 = *(_QWORD *)&a->materialQuality;
		    v16.bitDatas = v6;
		    *(_QWORD *)&v16.materialQuality = v7;
		    return !HG::Rendering::Runtime::FrameSettings::op_Equality(&v16, &v15, 0LL);
		  }
		}
		
		public override bool Equals(object obj) => default; // 0x0000000189C06848-0x0000000189C06944
		// Boolean Equals(Object)
		bool HG::Rendering::Runtime::FrameSettings::Equals(FrameSettings *this, Object *obj, MethodInfo *method)
		{
		  Object *v5; // rax
		  Object *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Object o1; // [rsp+20h] [rbp-28h] BYREF
		  int32_t materialQuality; // [rsp+30h] [rbp-18h]
		  int v13; // [rsp+68h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3674, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3674, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1281(Patch, this, obj, 0LL);
		  }
		  else if ( obj
		         && (struct FrameSettings__Class *)obj->klass == TypeInfo::HG::Rendering::Runtime::FrameSettings
		         && (o1 = *(Object *)sub_1800422D0(obj),
		             v5 = (Object *)il2cpp_value_box_0(TypeInfo::UnityEngine::Rendering::BitArray128, &o1),
		             UnityEngine::Rendering::BitArray128::Equals(&this->bitDatas, v5, 0LL)) )
		  {
		    v13 = *(_DWORD *)(sub_1800422D0(obj) + 16);
		    v6 = (Object *)il2cpp_value_box_0(TypeInfo::UnityEngine::Rendering::MaterialQuality, &v13);
		    o1.monitor = (MonitorData *)-1LL;
		    o1.klass = (Object__Class *)TypeInfo::UnityEngine::Rendering::MaterialQuality;
		    materialQuality = this->materialQuality;
		    return System::ValueType::DefaultEquals(&o1, v6, 0LL);
		  }
		  else
		  {
		    return 0;
		  }
		}
		
		public override int GetHashCode() => default; // 0x0000000189C06944-0x0000000189C069BC
		// Int32 GetHashCode()
		int32_t HG::Rendering::Runtime::FrameSettings::GetHashCode(FrameSettings *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3675, 0LL) )
		    return -1521134295 * (LODWORD(this->bitDatas.data2) ^ HIDWORD(this->bitDatas.data2))
		         - 2087829359 * (LODWORD(this->bitDatas.data1) ^ HIDWORD(this->bitDatas.data1))
		         + this->materialQuality
		         + 197728996;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3675, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1282(Patch, this, 0LL);
		}
		
		internal static void MigrateFromClassVersion(ref ObsoleteFrameSettings oldFrameSettingsFormat, ref FrameSettings newFrameSettingsFormat, ref FrameSettingsOverrideMask newFrameSettingsOverrideMask) {} // 0x0000000189C069BC-0x0000000189C06FA0
		// Void MigrateFromClassVersion(ObsoleteFrameSettings ByRef, FrameSettings ByRef, FrameSettingsOverrideMask ByRef)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		void HG::Rendering::Runtime::FrameSettings::MigrateFromClassVersion(
		        ObsoleteFrameSettings **oldFrameSettingsFormat,
		        FrameSettings *newFrameSettingsFormat,
		        FrameSettingsOverrideMask *newFrameSettingsOverrideMask,
		        MethodInfo *method)
		{
		  LitShaderMode__Enum v7; // edx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  struct Il2CppType *v30; // rbx
		  Type *TypeFromHandle; // rbx
		  Array *Values; // rax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  __int64 v39; // rax
		  int v40; // ebx
		  uint64_t v41; // rax
		  String *v42; // rbx
		  String *v43; // rax
		  String *v44; // rsi
		  __int64 v45; // rax
		  InvalidEnumArgumentException *v46; // rax
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  InvalidEnumArgumentException *v49; // rbx
		  unsigned int v50; // esi
		  unsigned __int64 v51; // rdx
		  char v52; // si
		  signed __int64 v53; // rtt
		  __int64 v54; // rax
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  InvalidEnumArgumentException *v57; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v59; // rdx
		  __int64 v60; // rcx
		  __int64 v61; // rax
		  String *v62; // rax
		  __int64 v63; // rax
		  IEnumerator *Enumerator; // [rsp+30h] [rbp-68h] BYREF
		  __int64 v65; // [rsp+38h] [rbp-60h] BYREF
		  Enum v66; // [rsp+48h] [rbp-50h] BYREF
		  int v67; // [rsp+58h] [rbp-40h]
		  __int64 v68; // [rsp+60h] [rbp-38h]
		  Enum v69; // [rsp+68h] [rbp-30h] BYREF
		
		  v65 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3676, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3676, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v60, v59);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1283(
		      Patch,
		      oldFrameSettingsFormat,
		      newFrameSettingsFormat,
		      newFrameSettingsOverrideMask,
		      0LL);
		  }
		  else if ( *oldFrameSettingsFormat )
		  {
		    if ( (*oldFrameSettingsFormat)->fields.shaderLitMode )
		    {
		      if ( (*oldFrameSettingsFormat)->fields.shaderLitMode != 1 )
		      {
		        v54 = sub_18007E180(&TypeInfo::System::ArgumentException);
		        v57 = (InvalidEnumArgumentException *)sub_18002C620(v54);
		        if ( !v57 )
		          sub_1800D8260(v56, v55);
		        v62 = (String *)sub_18007E180(&off_18E277820);
		        System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v57, v62, 0LL);
		        v63 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::FrameSettings::MigrateFromClassVersion);
		        sub_18007E190(v57, v63);
		      }
		      v7 = LitShaderMode__Enum_Deferred;
		    }
		    else
		    {
		      v7 = LitShaderMode__Enum_Forward;
		    }
		    HG::Rendering::Runtime::FrameSettings::set_litShaderMode(newFrameSettingsFormat, v7, 0LL);
		    if ( !*oldFrameSettingsFormat )
		      sub_1800D8260(v9, v8);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(
		      newFrameSettingsFormat,
		      FrameSettingsField__Enum_ShadowMaps,
		      (*oldFrameSettingsFormat)->fields.enableShadow,
		      0LL);
		    if ( !*oldFrameSettingsFormat )
		      sub_1800D8260(v11, v10);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(
		      newFrameSettingsFormat,
		      FrameSettingsField__Enum_Shadowmask,
		      (*oldFrameSettingsFormat)->fields.enableShadowMask,
		      0LL);
		    if ( !*oldFrameSettingsFormat )
		      sub_1800D8260(v13, v12);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(
		      newFrameSettingsFormat,
		      FrameSettingsField__Enum_LightLayers,
		      (*oldFrameSettingsFormat)->fields.enableLightLayers,
		      0LL);
		    if ( !*oldFrameSettingsFormat )
		      sub_1800D8260(v15, v14);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(
		      newFrameSettingsFormat,
		      FrameSettingsField__Enum_DepthPrepassWithDeferredRendering,
		      (*oldFrameSettingsFormat)->fields.enableDepthPrepassWithDeferredRendering,
		      0LL);
		    if ( !*oldFrameSettingsFormat )
		      sub_1800D8260(v17, v16);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(
		      newFrameSettingsFormat,
		      FrameSettingsField__Enum_TransparentPrepass,
		      (*oldFrameSettingsFormat)->fields.enableTransparentPrepass,
		      0LL);
		    if ( !*oldFrameSettingsFormat )
		      sub_1800D8260(v19, v18);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(
		      newFrameSettingsFormat,
		      FrameSettingsField__Enum_Decals,
		      (*oldFrameSettingsFormat)->fields.enableDecals,
		      0LL);
		    if ( !*oldFrameSettingsFormat )
		      sub_1800D8260(v21, v20);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(
		      newFrameSettingsFormat,
		      FrameSettingsField__Enum_Refraction,
		      (*oldFrameSettingsFormat)->fields.enableRoughRefraction,
		      0LL);
		    if ( !*oldFrameSettingsFormat )
		      sub_1800D8260(v23, v22);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(
		      newFrameSettingsFormat,
		      FrameSettingsField__Enum_TransparentPostpass,
		      (*oldFrameSettingsFormat)->fields.enableTransparentPostpass,
		      0LL);
		    if ( !*oldFrameSettingsFormat )
		      sub_1800D8260(v25, v24);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(
		      newFrameSettingsFormat,
		      FrameSettingsField__Enum_Postprocess,
		      (*oldFrameSettingsFormat)->fields.enablePostprocess,
		      0LL);
		    if ( !*oldFrameSettingsFormat )
		      sub_1800D8260(v27, v26);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(
		      newFrameSettingsFormat,
		      FrameSettingsField__Enum_OpaqueObjects,
		      (*oldFrameSettingsFormat)->fields.enableOpaqueObjects,
		      0LL);
		    if ( !*oldFrameSettingsFormat )
		      sub_1800D8260(v29, v28);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(
		      newFrameSettingsFormat,
		      FrameSettingsField__Enum_TransparentObjects,
		      (*oldFrameSettingsFormat)->fields.enableTransparentObjects,
		      0LL);
		    *newFrameSettingsOverrideMask = 0LL;
		    v30 = TypeRef::HG::Rendering::Runtime::ObsoleteFrameSettingsOverrides;
		    sub_1800036A0(TypeInfo::System::Type);
		    TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v30, 0LL);
		    sub_1800036A0(TypeInfo::System::Enum);
		    Values = System::Enum::GetValues(TypeFromHandle, 0LL);
		    if ( !Values )
		      sub_1800D8260(v34, v33);
		    Enumerator = System::Array::GetEnumerator(Values, 0LL);
		    v66.klass = (Enum__Class *)&Enumerator;
		    v66.monitor = (MonitorData *)&v65;
		    v68 = 0LL;
		    v69 = v66;
		    while ( 1 )
		    {
		      if ( !Enumerator )
		        sub_1800D8250(v36, v35);
		      if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		        break;
		      if ( !Enumerator )
		        sub_1800D8250(v38, v37);
		      v39 = sub_1800428A0(1LL, TypeInfo::System::Collections::IEnumerator, Enumerator);
		      v40 = *(_DWORD *)sub_1800422D0(v39);
		      if ( !*oldFrameSettingsFormat )
		        sub_1800D8250(v36, v35);
		      if ( (v40 & (*oldFrameSettingsFormat)->fields.overrides) > 0 )
		      {
		        if ( v40 <= 0x20000 )
		        {
		          if ( v40 <= 1024 )
		          {
		            switch ( v40 )
		            {
		              case 1:
		                v41 = newFrameSettingsOverrideMask->mask.data1 | 0x100000;
		                break;
		              case 4:
		                v41 = newFrameSettingsOverrideMask->mask.data1 | 0x400000;
		                break;
		              case 1024:
		                v41 = newFrameSettingsOverrideMask->mask.data1 | 0x40000000;
		                break;
		              default:
		LABEL_53:
		                v66.klass = (Enum__Class *)sub_180035ED0(&TypeInfo::HG::Rendering::Runtime::ObsoleteFrameSettingsOverrides);
		                v66.monitor = (MonitorData *)-1LL;
		                v67 = v40;
		                v42 = System::Enum::ToString(&v66, 0LL);
		                v43 = (String *)sub_180035ED0(&off_18E277148);
		                v44 = System::String::Concat(v43, v42, 0LL);
		                v45 = sub_180035ED0(&TypeInfo::System::ArgumentException);
		                v46 = (InvalidEnumArgumentException *)sub_18002C620(v45);
		                v49 = v46;
		                if ( v46 )
		                {
		                  System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v46, v44, 0LL);
		                  v61 = sub_180035ED0(&MethodInfo::HG::Rendering::Runtime::FrameSettings::MigrateFromClassVersion);
		                  sub_18007E190(v49, v61);
		                }
		                sub_1800D8250(v48, v47);
		            }
		          }
		          else
		          {
		            switch ( v40 )
		            {
		              case 0x2000:
		                v41 = newFrameSettingsOverrideMask->mask.data1 | 0x100;
		                break;
		              case 0x4000:
		                v41 = newFrameSettingsOverrideMask->mask.data1 | 0x200;
		                break;
		              case 0x20000:
		                v41 = newFrameSettingsOverrideMask->mask.data1 | 0x1000;
		                break;
		              default:
		                goto LABEL_53;
		            }
		          }
		        }
		        else if ( v40 <= 0x200000 )
		        {
		          switch ( v40 )
		          {
		            case 0x40000:
		              v41 = newFrameSettingsOverrideMask->mask.data1 | 0x2000;
		              break;
		            case 0x100000:
		              v41 = newFrameSettingsOverrideMask->mask.data1 | 0x8000;
		              break;
		            case 0x200000:
		              v41 = newFrameSettingsOverrideMask->mask.data1 | 1;
		              break;
		            default:
		              goto LABEL_53;
		          }
		        }
		        else
		        {
		          switch ( v40 )
		          {
		            case 0x400000:
		              v41 = newFrameSettingsOverrideMask->mask.data1 | 2;
		              break;
		            case 0x1000000:
		              v41 = newFrameSettingsOverrideMask->mask.data1 | 4;
		              break;
		            case 0x2000000:
		              v41 = newFrameSettingsOverrideMask->mask.data1 | 8;
		              break;
		            default:
		              goto LABEL_53;
		          }
		        }
		        newFrameSettingsOverrideMask->mask.data1 = v41;
		      }
		    }
		    sub_180BFE040(&v69);
		    *oldFrameSettingsFormat = 0LL;
		    if ( dword_18F35FD08 )
		    {
		      v50 = ((unsigned __int64)oldFrameSettingsFormat >> 12) & 0x1FFFFF;
		      v51 = (unsigned __int64)v50 >> 6;
		      v52 = v50 & 0x3F;
		      _m_prefetchw(&qword_18F103690[v51]);
		      do
		        v53 = qword_18F103690[v51];
		      while ( v53 != _InterlockedCompareExchange64(&qword_18F103690[v51], v53 | (1LL << v52), v53) );
		    }
		  }
		}
		
		internal static void MigrateToCustomPostprocessAndCustomPass(ref FrameSettings cameraFrameSettings) {} // 0x0000000189C0707C-0x0000000189C070C0
		// Void MigrateToCustomPostprocessAndCustomPass(FrameSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::MigrateToCustomPostprocessAndCustomPass(
		        FrameSettings *cameraFrameSettings,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3677, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3677, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, cameraFrameSettings, 0LL);
		  }
		}
		
		internal static void MigrateToAfterPostprocess(ref FrameSettings cameraFrameSettings) {} // 0x0000000189C07038-0x0000000189C0707C
		// Void MigrateToAfterPostprocess(FrameSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::MigrateToAfterPostprocess(
		        FrameSettings *cameraFrameSettings,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3678, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3678, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, cameraFrameSettings, 0LL);
		  }
		}
		
		internal static void MigrateToDefaultReflectionSettings(ref FrameSettings cameraFrameSettings) {} // 0x0000000189C070C0-0x0000000189C07104
		// Void MigrateToDefaultReflectionSettings(FrameSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::MigrateToDefaultReflectionSettings(
		        FrameSettings *cameraFrameSettings,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3679, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3679, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, cameraFrameSettings, 0LL);
		  }
		}
		
		internal static void MigrateToNoReflectionRealtimeSettings(ref FrameSettings cameraFrameSettings) {} // 0x0000000189C071D0-0x0000000189C07214
		// Void MigrateToNoReflectionRealtimeSettings(FrameSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::MigrateToNoReflectionRealtimeSettings(
		        FrameSettings *cameraFrameSettings,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3680, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3680, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, cameraFrameSettings, 0LL);
		  }
		}
		
		internal static void MigrateToNoReflectionSettings(ref FrameSettings cameraFrameSettings) {} // 0x0000000189C07214-0x0000000189C07258
		// Void MigrateToNoReflectionSettings(FrameSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::MigrateToNoReflectionSettings(
		        FrameSettings *cameraFrameSettings,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3681, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3681, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, cameraFrameSettings, 0LL);
		  }
		}
		
		internal static void MigrateToPostProcess(ref FrameSettings cameraFrameSettings) {} // 0x0000000189C07258-0x0000000189C072D8
		// Void MigrateToPostProcess(FrameSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::MigrateToPostProcess(
		        FrameSettings *cameraFrameSettings,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3682, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3682, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, cameraFrameSettings, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(cameraFrameSettings, FrameSettingsField__Enum_Bloom, 1, 0LL);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(cameraFrameSettings, FrameSettingsField__Enum_Vignette, 1, 0LL);
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(
		      cameraFrameSettings,
		      FrameSettingsField__Enum_ColorGrading,
		      1,
		      0LL);
		  }
		}
		
		internal static void MigrateToLensFlare(ref FrameSettings cameraFrameSettings) {} // 0x0000000189C07148-0x0000000189C0718C
		// Void MigrateToLensFlare(FrameSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::MigrateToLensFlare(FrameSettings *cameraFrameSettings, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3683, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3683, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, cameraFrameSettings, 0LL);
		  }
		}
		
		internal static void MigrateToDirectSpecularLighting(ref FrameSettings cameraFrameSettings) {} // 0x0000000189C07104-0x0000000189C07148
		// Void MigrateToDirectSpecularLighting(FrameSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::MigrateToDirectSpecularLighting(
		        FrameSettings *cameraFrameSettings,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3684, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3684, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, cameraFrameSettings, 0LL);
		  }
		}
		
		internal static void MigrateToNoDirectSpecularLighting(ref FrameSettings cameraFrameSettings) {} // 0x0000000189C0718C-0x0000000189C071D0
		// Void MigrateToNoDirectSpecularLighting(FrameSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::MigrateToNoDirectSpecularLighting(
		        FrameSettings *cameraFrameSettings,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3685, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3685, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, cameraFrameSettings, 0LL);
		  }
		}
		
		internal static void MigrateToSeparateColorGradingAndTonemapping(ref FrameSettings cameraFrameSettings) {} // 0x0000000189C072D8-0x0000000189C07334
		// Void MigrateToSeparateColorGradingAndTonemapping(FrameSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::MigrateToSeparateColorGradingAndTonemapping(
		        FrameSettings *cameraFrameSettings,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3686, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3686, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, cameraFrameSettings, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::FrameSettings::SetEnabled(cameraFrameSettings, FrameSettingsField__Enum_Tonemapping, 1, 0LL);
		  }
		}
		
		internal static void MigrateSubsurfaceParams(ref FrameSettings fs, bool previouslyHighQuality) {} // 0x0000000189C06FE4-0x0000000189C07038
		// Void MigrateSubsurfaceParams(FrameSettings ByRef, Boolean)
		void HG::Rendering::Runtime::FrameSettings::MigrateSubsurfaceParams(
		        FrameSettings *fs,
		        bool previouslyHighQuality,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3687, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3687, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1285(Patch, fs, previouslyHighQuality, 0LL);
		  }
		}
		
		internal static void MigrateRoughDistortion(ref FrameSettings cameraFrameSettings) {} // 0x0000000189C06FA0-0x0000000189C06FE4
		// Void MigrateRoughDistortion(FrameSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::MigrateRoughDistortion(
		        FrameSettings *cameraFrameSettings,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3688, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3688, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, cameraFrameSettings, 0LL);
		  }
		}
		
		internal static void MigrateVirtualTexturing(ref FrameSettings cameraFrameSettings) {} // 0x0000000189C07334-0x0000000189C07378
		// Void MigrateVirtualTexturing(FrameSettings ByRef)
		void HG::Rendering::Runtime::FrameSettings::MigrateVirtualTexturing(
		        FrameSettings *cameraFrameSettings,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3689, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3689, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1284(Patch, cameraFrameSettings, 0LL);
		  }
		}
		
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x0000000189C07538-0x0000000189C07578
		// Boolean <>iFixBaseProxy_Equals(Object)
		bool HG::Rendering::Runtime::FrameSettings::__iFixBaseProxy_Equals(FrameSettings *this, Object *P0, MethodInfo *method)
		{
		  __int64 v4; // xmm1_8
		  Object *v5; // rax
		  BitArray128 bitDatas; // [rsp+20h] [rbp-28h] BYREF
		  __int64 v8; // [rsp+30h] [rbp-18h]
		
		  v4 = *(_QWORD *)&this->materialQuality;
		  bitDatas = this->bitDatas;
		  v8 = v4;
		  v5 = (Object *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::FrameSettings, &bitDatas);
		  return System::ValueType::DefaultEquals(v5, P0, 0LL);
		}
		
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000189C07578-0x0000000189C075B0
		// Int32 <>iFixBaseProxy_GetHashCode()
		int32_t HG::Rendering::Runtime::FrameSettings::__iFixBaseProxy_GetHashCode(FrameSettings *this, MethodInfo *method)
		{
		  __int64 v2; // xmm1_8
		  ValueType *v3; // rax
		  BitArray128 bitDatas; // [rsp+20h] [rbp-28h] BYREF
		  __int64 v6; // [rsp+30h] [rbp-18h]
		
		  v2 = *(_QWORD *)&this->materialQuality;
		  bitDatas = this->bitDatas;
		  v6 = v2;
		  v3 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::FrameSettings, &bitDatas);
		  return System::ValueType::GetHashCode(v3, 0LL);
		}
		
	}
}
