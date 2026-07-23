using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Field)]
	internal class FrameSettingsFieldAttribute : Attribute // TypeDefIndex: 37515
	{
		// Fields
		public readonly DisplayType type; // 0x10
		public readonly string displayedName; // 0x18
		public readonly string tooltip; // 0x20
		public readonly int group; // 0x28
		public readonly int orderInGroup; // 0x2C
		public readonly System.Type targetType; // 0x30
		public readonly int indentLevel; // 0x38
		public readonly FrameSettingsField[] dependencies; // 0x40
		private readonly int dependencySeparator; // 0x48
		private static int autoOrder; // 0x00
		private static Dictionary<FrameSettingsField, string> s_FrameSettingsEnumNameMap; // 0x08
	
		// Nested types
		public enum DisplayType // TypeDefIndex: 37513
		{
			BoolAsCheckbox = 0,
			BoolAsEnumPopup = 1,
			Others = 2
		}
	
		// Constructors
		public FrameSettingsFieldAttribute() {} // Dummy constructor
		static FrameSettingsFieldAttribute() {} // 0x00000001836FB1B0-0x00000001836FB1C0
		// FrameSettingsFieldAttribute()
		void HG::Rendering::Runtime::FrameSettingsFieldAttribute::cctor(MethodInfo *method)
		{
		  HG::Rendering::Runtime::FrameSettingsFieldAttribute::GetEnumNameMap(0LL);
		}
		
		public FrameSettingsFieldAttribute(int group, FrameSettingsField autoName = FrameSettingsField.None /* Metadata: 0x02302EE2 */, string displayedName = null, string tooltip = null, DisplayType type = DisplayType.BoolAsCheckbox /* Metadata: 0x02302EE3 */, System.Type targetType = null, FrameSettingsField[] positiveDependencies = null, FrameSettingsField[] negativeDependencies = null, int customOrderInGroup = -1 /* Metadata: 0x02302EE4 */) {} // 0x000000018374B3F0-0x000000018374B5F0
		// FrameSettingsFieldAttribute(Int32, FrameSettingsField, String, String, FrameSettingsFieldAttribute+DisplayType, Type, FrameSettingsField[], FrameSettingsField[], Int32)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::FrameSettingsFieldAttribute::FrameSettingsFieldAttribute(
		        FrameSettingsFieldAttribute *this,
		        int32_t group,
		        FrameSettingsField__Enum autoName,
		        String *displayedName,
		        String *tooltip,
		        FrameSettingsFieldAttribute_DisplayType__Enum type,
		        Type *targetType,
		        FrameSettingsField__Enum__Array *positiveDependencies,
		        FrameSettingsField__Enum__Array *negativeDependencies,
		        int32_t customOrderInGroup,
		        MethodInfo *method)
		{
		  int32_t v14; // edi
		  struct FrameSettingsFieldAttribute__Class *v15; // rax
		  PropertyInfo_1 *v16; // r8
		  MonitorData *monitor; // rax
		  Type *v18; // rdx
		  Int32__Array **v19; // r9
		  Type *v20; // rdx
		  PropertyInfo_1 *v21; // r8
		  Array *v22; // rbp
		  int32_t v23; // edi
		  int32_t size; // eax
		  FrameSettingsField__Enum__Array *v25; // rsi
		  int32_t v26; // ecx
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  FrameSettingsField__Enum__Array *dependencies; // rax
		  struct FrameSettingsFieldAttribute__Class *v31; // rax
		  Dictionary_2_System_Int32Enum_System_Object_ *s_FrameSettingsEnumNameMap; // rcx
		  Object *v33; // rax
		  Enum v34; // [rsp+20h] [rbp-28h] BYREF
		  FrameSettingsField__Enum v35; // [rsp+30h] [rbp-18h]
		  Object *value; // [rsp+68h] [rbp+20h] BYREF
		
		  value = (Object *)displayedName;
		  if ( !displayedName || !displayedName->fields._stringLength )
		  {
		    v31 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		    if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute);
		      v31 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		    }
		    s_FrameSettingsEnumNameMap = (Dictionary_2_System_Int32Enum_System_Object_ *)v31->static_fields->s_FrameSettingsEnumNameMap;
		    if ( !s_FrameSettingsEnumNameMap )
		      sub_1800D8260(0LL, *(_QWORD *)&group);
		    if ( System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::TryGetValue(
		           s_FrameSettingsEnumNameMap,
		           (Int32Enum__Enum)autoName,
		           &value,
		           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::TryGetValue) )
		    {
		      v33 = value;
		    }
		    else
		    {
		      v34.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::FrameSettingsField;
		      v34.monitor = (MonitorData *)-1LL;
		      v35 = autoName;
		      v33 = (Object *)System::Enum::ToString(&v34, 0LL);
		      value = v33;
		    }
		    value = (Object *)HG::Rendering::Runtime::StringExtention::CamelToPascalCaseWithSpace((String *)v33, 1, 0LL);
		  }
		  this->fields.group = group;
		  v14 = customOrderInGroup;
		  if ( customOrderInGroup != -1 )
		  {
		    v15 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		    if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute);
		      v15 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		    }
		    v15->static_fields->autoOrder = v14;
		  }
		  v16 = (PropertyInfo_1 *)TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		  if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute);
		    v16 = (PropertyInfo_1 *)TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		  }
		  monitor = v16[11].monitor;
		  v18 = (Type *)*(unsigned int *)monitor;
		  *(_DWORD *)monitor = (_DWORD)v18 + 1;
		  this->fields.displayedName = (String *)value;
		  this->fields.orderInGroup = (int)v18;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.displayedName,
		    v18,
		    v16,
		    (Int32__Array **)displayedName,
		    (MethodInfo *)v34.klass);
		  v19 = (Int32__Array **)type;
		  this->fields.targetType = targetType;
		  this->fields.type = (int)v19;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.targetType, v20, v21, v19, (MethodInfo *)v34.klass);
		  v22 = (Array *)positiveDependencies;
		  v23 = 0;
		  if ( positiveDependencies )
		    size = positiveDependencies->max_length.size;
		  else
		    size = 0;
		  v25 = negativeDependencies;
		  this->fields.dependencySeparator = size;
		  if ( v25 )
		    v26 = v25->max_length.size;
		  else
		    v26 = 0;
		  this->fields.dependencies = (FrameSettingsField__Enum__Array *)il2cpp_array_new_specific_1(
		                                                                   TypeInfo::HG::Rendering::Runtime::FrameSettingsField,
		                                                                   (unsigned int)(v26 + size));
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.dependencies, v27, v28, v29, (MethodInfo *)v34.klass);
		  if ( v22 )
		    System::Array::CopyTo(v22, (Array *)this->fields.dependencies, 0, 0LL);
		  if ( v25 )
		    System::Array::CopyTo((Array *)v25, (Array *)this->fields.dependencies, this->fields.dependencySeparator, 0LL);
		  dependencies = this->fields.dependencies;
		  if ( dependencies )
		    v23 = dependencies->max_length.size;
		  this->fields.indentLevel = v23;
		}
		
	
		// Methods
		public static Dictionary<FrameSettingsField, string> GetEnumNameMap() => default; // 0x00000001836FCEC0-0x00000001836FD110
		// Dictionary`2[HG.Rendering.Runtime.FrameSettingsField,System.String] GetEnumNameMap()
		Dictionary_2_HG_Rendering_Runtime_FrameSettingsField_System_String_ *HG::Rendering::Runtime::FrameSettingsFieldAttribute::GetEnumNameMap(
		        MethodInfo *method)
		{
		  struct FrameSettingsFieldAttribute__Class *v1; // rcx
		  Dictionary_2_System_Int32Enum_System_Object_ *v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Dictionary_2_HG_Rendering_Runtime_FrameSettingsField_System_String_ *v5; // rbx
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  struct FrameSettingsFieldAttribute__Class *v9; // rax
		  struct Il2CppType *v10; // rbx
		  Type *TypeFromHandle; // rbp
		  String__Array *Names; // rsi
		  int32_t v13; // ebx
		  String *v14; // r15
		  MemberInfo_1 *v15; // rax
		  struct FrameSettingsFieldAttribute__Class *v16; // rax
		  Dictionary_2_System_Int32Enum_System_Object_ *s_FrameSettingsEnumNameMap; // r14
		  Object *v18; // rax
		  MethodInfo *v19; // rdi
		  Int32Enum__Enum *v20; // rax
		  MethodInfo *v22; // [rsp+20h] [rbp-18h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		  if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute);
		    v1 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		  }
		  if ( !v1->static_fields->s_FrameSettingsEnumNameMap )
		  {
		    v2 = (Dictionary_2_System_Int32Enum_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>);
		    v5 = (Dictionary_2_HG_Rendering_Runtime_FrameSettingsField_System_String_ *)v2;
		    if ( !v2 )
		      goto LABEL_5;
		    System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::Dictionary(
		      v2,
		      MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::Dictionary);
		    v9 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		    if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute);
		      v9 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		    }
		    v9->static_fields->s_FrameSettingsEnumNameMap = v5;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute->static_fields->s_FrameSettingsEnumNameMap,
		      v6,
		      v7,
		      v8,
		      v22);
		    v10 = TypeRef::HG::Rendering::Runtime::FrameSettingsField;
		    if ( !TypeInfo::System::Type->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::System::Type);
		    TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v10, 0LL);
		    if ( !TypeInfo::System::Enum->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::System::Enum);
		    Names = System::Enum::GetNames(TypeFromHandle, 0LL);
		    v13 = 0;
		    if ( !Names )
		LABEL_5:
		      sub_1800D8260(v4, v3);
		    while ( v13 < Names->max_length.size )
		    {
		      if ( (unsigned int)v13 >= Names->max_length.size )
		        sub_1800D2AB0(v4, v3);
		      if ( !TypeFromHandle )
		        goto LABEL_5;
		      v14 = Names->vector[v13];
		      v15 = (MemberInfo_1 *)sub_180048D30(v4, TypeFromHandle, v14, 28LL);
		      if ( !System::Reflection::CustomAttributeExtensions::GetCustomAttribute<System::Object>(
		              v15,
		              MethodInfo::System::Reflection::CustomAttributeExtensions::GetCustomAttribute<System::ObsoleteAttribute>) )
		      {
		        v16 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		        if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute);
		          v16 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		        }
		        s_FrameSettingsEnumNameMap = (Dictionary_2_System_Int32Enum_System_Object_ *)v16->static_fields->s_FrameSettingsEnumNameMap;
		        if ( !TypeInfo::System::Enum->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::System::Enum);
		        v18 = System::Enum::Parse(TypeFromHandle, v14, 0LL);
		        if ( !s_FrameSettingsEnumNameMap )
		          goto LABEL_5;
		        v19 = MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::Add;
		        v20 = (Int32Enum__Enum *)sub_1800422D0(v18);
		        System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::Add(
		          s_FrameSettingsEnumNameMap,
		          *v20,
		          (Object *)v14,
		          v19);
		      }
		      ++v13;
		    }
		    v1 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		  }
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
		  }
		  return v1->static_fields->s_FrameSettingsEnumNameMap;
		}
		
		public bool IsNegativeDependency(FrameSettingsField frameSettingsField) => default; // 0x0000000189B356C8-0x0000000189B35758
		// Boolean IsNegativeDependency(FrameSettingsField)
		bool HG::Rendering::Runtime::FrameSettingsFieldAttribute::IsNegativeDependency(
		        FrameSettingsFieldAttribute *this,
		        FrameSettingsField__Enum frameSettingsField,
		        MethodInfo *method)
		{
		  __int64 v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Object *v8; // rbx
		  FrameSettingsField__Enum__Array *dependencies; // rbp
		  Predicate_1_Int32Enum_ *v10; // rax
		  Predicate_1_Int32Enum_ *v11; // rdi
		
		  v5 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute::__c__DisplayClass15_0);
		  v8 = (Object *)v5;
		  if ( !v5
		    || (*(_DWORD *)(v5 + 16) = frameSettingsField,
		        dependencies = this->fields.dependencies,
		        v10 = (Predicate_1_Int32Enum_ *)sub_18002C620(TypeInfo::System::Predicate<HG::Rendering::Runtime::FrameSettingsField>),
		        (v11 = v10) == 0LL) )
		  {
		    sub_1800D8260(v7, v6);
		  }
		  System::Predicate<System::Int32Enum>::Predicate(
		    v10,
		    v8,
		    MethodInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute::__c__DisplayClass15_0::_IsNegativeDependency_b__0,
		    0LL);
		  return System::Array::FindIndex<System::Int32Enum>(
		           (Int32Enum__Enum__Array *)dependencies,
		           v11,
		           MethodInfo::System::Array::FindIndex<HG::Rendering::Runtime::FrameSettingsField>) >= this->fields.dependencySeparator;
		}
		
	}
}
