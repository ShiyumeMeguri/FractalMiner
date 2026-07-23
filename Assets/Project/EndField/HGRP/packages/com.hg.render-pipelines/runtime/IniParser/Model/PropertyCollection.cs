using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IniParser;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IniParser.Model
{
	public class PropertyCollection : IDeepCloneable<PropertyCollection>, IEnumerable<Property> // TypeDefIndex: 37380
	{
		// Fields
		private Property _lastAdded; // 0x10
		private readonly Dictionary<string, Property> _properties; // 0x18
		private readonly IEqualityComparer<string> _searchComparer; // 0x20
	
		// Properties
		public string this[string keyName] { get => default; set {} } // 0x0000000189B31FE4-0x0000000189B32044 0x0000000189B32044-0x0000000189B320C4
		// String get_Item(String)
		String *IniParser::Model::PropertyCollection::get_Item(PropertyCollection *this, String *keyName, MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
		  Object *Item; // rax
		
		  properties = this->fields._properties;
		  if ( !properties )
		    goto LABEL_7;
		  if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		          (Dictionary_2_System_Object_System_Object_ *)properties,
		          (Object *)keyName,
		          MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey) )
		    return 0LL;
		  properties = this->fields._properties;
		  if ( !properties
		    || (Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                 (Dictionary_2_System_Object_System_Object_ *)properties,
		                 (Object *)keyName,
		                 MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::get_Item)) == 0LL )
		  {
		LABEL_7:
		    sub_1800D8260(properties, keyName);
		  }
		  return (String *)Item[1].klass;
		}
		

		// Void set_Item(String, String)
		void IniParser::Model::PropertyCollection::set_Item(
		        PropertyCollection *this,
		        String *keyName,
		        String *value,
		        MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
		  Object *Item; // rax
		  VolumetricPipelineRT **v9; // r8
		  VolumetricPipelineRT **v10; // r9
		  VolumetricPipelineRT **v11; // [rsp+50h] [rbp+28h]
		  MethodInfo *v12; // [rsp+58h] [rbp+30h]
		
		  properties = this->fields._properties;
		  if ( !properties )
		    goto LABEL_7;
		  if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		          (Dictionary_2_System_Object_System_Object_ *)properties,
		          (Object *)keyName,
		          MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey) )
		    IniParser::Model::PropertyCollection::Add(this, keyName, 0LL);
		  properties = this->fields._properties;
		  if ( !properties
		    || (Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                 (Dictionary_2_System_Object_System_Object_ *)properties,
		                 (Object *)keyName,
		                 MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::get_Item)) == 0LL )
		  {
		LABEL_7:
		    sub_1800D8260(properties, keyName);
		  }
		  Item[1].klass = (Object__Class *)value;
		  sub_18002D1B0((ParsingException *)&Item[1], (UberPostPassUtils_ColorGradingData **)keyName, v9, v10, v11, v12);
		}
		
		public int Count { get => default; } // 0x0000000189B31FC4-0x0000000189B31FE4 
		// Int32 get_Count()
		int32_t IniParser::Model::PropertyCollection::get_Count(PropertyCollection *this, MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rdx
		
		  properties = this->fields._properties;
		  if ( !properties )
		    sub_1800D8260(this, 0LL);
		  return properties->fields._count - properties->fields._freeCount;
		}
		
	
		// Constructors
		public PropertyCollection() {} // 0x00000001835A7D00-0x00000001835A7D30
		// PropertyCollection()
		void IniParser::Model::PropertyCollection::PropertyCollection(PropertyCollection *this, MethodInfo *method)
		{
		  IEqualityComparer_1_System_String_ *v3; // rax
		
		  v3 = (IEqualityComparer_1_System_String_ *)sub_182EEDEE0(MethodInfo::System::Collections::Generic::EqualityComparer<System::String>::get_Default);
		  IniParser::Model::PropertyCollection::PropertyCollection(this, v3, 0LL);
		}
		
		public PropertyCollection(IEqualityComparer<string> searchComparer) {} // 0x00000001835A8160-0x00000001835A81D0
		public PropertyCollection(PropertyCollection ori, IEqualityComparer<string> searchComparer) {} // 0x0000000189B31E34-0x0000000189B31FC4
		// PropertyCollection(PropertyCollection, IEqualityComparer`1[System.String])
		// Hidden C++ exception states: #wind=1
		void IniParser::Model::PropertyCollection::PropertyCollection(
		        PropertyCollection *this,
		        PropertyCollection *ori,
		        IEqualityComparer_1_System_String_ *searchComparer,
		        MethodInfo *method)
		{
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rax
		  __int64 v13; // rdx
		  Property *v14; // rbx
		  Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
		  bool v16; // al
		  Dictionary_2_System_String_IniParser_Model_Property_ *v17; // rdi
		  Object *Key_k__BackingField; // rsi
		  Object *v19; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  Object *v22; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  _QWORD v25[4]; // [rsp+28h] [rbp-20h] BYREF
		  IEnumerator_1_IniParser_Model_Property_ *Enumerator; // [rsp+58h] [rbp+10h] BYREF
		
		  IniParser::Model::PropertyCollection::PropertyCollection(this, searchComparer, 0LL);
		  if ( !ori )
		    sub_1800D8260(v7, v6);
		  Enumerator = IniParser::Model::PropertyCollection::GetEnumerator(ori, 0LL);
		  v25[0] = 0LL;
		  v25[1] = &Enumerator;
		  while ( 1 )
		  {
		    if ( !Enumerator )
		      sub_1800D8250(v9, v8);
		    if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		      break;
		    if ( !Enumerator )
		      sub_1800D8250(v11, v10);
		    v12 = sub_18006E0A0();
		    v14 = (Property *)v12;
		    properties = this->fields._properties;
		    if ( !v12 )
		      sub_1800D8250(properties, v13);
		    if ( !properties )
		      sub_1800D8250(0LL, v13);
		    v16 = System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		            (Dictionary_2_System_Object_System_Object_ *)properties,
		            *(Object **)(v12 + 24),
		            MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey);
		    v17 = this->fields._properties;
		    Key_k__BackingField = (Object *)v14->fields._Key_k__BackingField;
		    if ( v16 )
		    {
		      v22 = (Object *)IniParser::Model::Property::DeepClone(v14, 0LL);
		      if ( !v17 )
		        sub_1800D8250(v24, v23);
		      System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
		        (Dictionary_2_System_Object_System_Object_ *)v17,
		        Key_k__BackingField,
		        v22,
		        MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::set_Item);
		    }
		    else
		    {
		      v19 = (Object *)IniParser::Model::Property::DeepClone(v14, 0LL);
		      if ( !v17 )
		        sub_1800D8250(v21, v20);
		      System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
		        (Dictionary_2_System_Object_System_Object_ *)v17,
		        Key_k__BackingField,
		        v19,
		        MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::Add);
		    }
		  }
		  sub_1801F6A10(v25);
		}
		
	
		// Methods
		public bool Add(string key) => default; // 0x0000000189B31A30-0x0000000189B31AC8
		// Boolean Add(String)
		bool IniParser::Model::PropertyCollection::Add(PropertyCollection *this, String *key, MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
		  String *Empty; // rbp
		  Property *v8; // rax
		  Property *v9; // rbx
		
		  properties = this->fields._properties;
		  if ( !properties )
		    goto LABEL_6;
		  if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		         (Dictionary_2_System_Object_System_Object_ *)properties,
		         (Object *)key,
		         MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey) )
		  {
		    return 0;
		  }
		  Empty = TypeInfo::System::String->static_fields->Empty;
		  v8 = (Property *)sub_1800368D0(TypeInfo::IniParser::Model::Property);
		  v9 = v8;
		  if ( !v8 )
		LABEL_6:
		    sub_1800D8260(properties, key);
		  IniParser::Model::Property::Property(v8, key, Empty, 0LL);
		  IniParser::Model::PropertyCollection::AddPropertyInternal(this, v9, 0LL);
		  return 1;
		}
		
		public bool Add(Property property) => default; // 0x0000000189B31AC8-0x0000000189B31B20
		// Boolean Add(Property)
		bool IniParser::Model::PropertyCollection::Add(PropertyCollection *this, Property *property, MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
		
		  properties = this->fields._properties;
		  if ( !property || !properties )
		    sub_1800D8260(properties, property);
		  if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		         (Dictionary_2_System_Object_System_Object_ *)properties,
		         (Object *)property->fields._Key_k__BackingField,
		         MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey) )
		  {
		    return 0;
		  }
		  IniParser::Model::PropertyCollection::AddPropertyInternal(this, property, 0LL);
		  return 1;
		}
		
		public bool Add(string key, string value) => default; // 0x00000001835A9CB0-0x00000001835A9D50
		public void ClearComments() {} // 0x0000000189B31B20-0x0000000189B31BF8
		// Void ClearComments()
		// Hidden C++ exception states: #wind=1
		void IniParser::Model::PropertyCollection::ClearComments(PropertyCollection *this, MethodInfo *method)
		{
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Property *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  List_1_System_String_ *Comments; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  _QWORD v12[4]; // [rsp+28h] [rbp-20h] BYREF
		  IEnumerator_1_IniParser_Model_Property_ *Enumerator; // [rsp+60h] [rbp+18h] BYREF
		
		  Enumerator = IniParser::Model::PropertyCollection::GetEnumerator(this, 0LL);
		  v12[0] = 0LL;
		  v12[1] = &Enumerator;
		  while ( 1 )
		  {
		    if ( !Enumerator )
		      sub_1800D8250(v3, v2);
		    if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		      break;
		    if ( !Enumerator )
		      sub_1800D8250(v5, v4);
		    v6 = (Property *)sub_18006E0A0();
		    if ( !v6 )
		      sub_1800D8250(v8, v7);
		    Comments = IniParser::Model::Property::get_Comments(v6, 0LL);
		    if ( !Comments )
		      sub_1800D8250(v11, v10);
		    sub_183127A90(Comments, MethodInfo::System::Collections::Generic::List<System::String>::Clear);
		  }
		  sub_1801F6A10(v12);
		}
		
		public bool Contains(string keyName) => default; // 0x00000001835A9D50-0x00000001835A9D80
		// Boolean Contains(String)
		bool IniParser::Model::PropertyCollection::Contains(PropertyCollection *this, String *keyName, MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
		
		  properties = this->fields._properties;
		  if ( !properties )
		    sub_1800D8260(0LL, keyName);
		  return System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		           (Dictionary_2_System_Object_System_Object_ *)properties,
		           (Object *)keyName,
		           MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey);
		}
		
		public Property FindByKey(string keyName) => default; // 0x00000001835A9EC0-0x00000001835A9F20
		// Property FindByKey(String)
		Property *IniParser::Model::PropertyCollection::FindByKey(
		        PropertyCollection *this,
		        String *keyName,
		        MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
		
		  properties = this->fields._properties;
		  if ( !properties )
		    goto LABEL_5;
		  if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		         (Dictionary_2_System_Object_System_Object_ *)properties,
		         (Object *)keyName,
		         MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey) )
		  {
		    properties = this->fields._properties;
		    if ( properties )
		      return (Property *)System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                           (Dictionary_2_System_Object_System_Object_ *)properties,
		                           (Object *)keyName,
		                           MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::get_Item);
		LABEL_5:
		    sub_1800D8260(properties, keyName);
		  }
		  return 0LL;
		}
		
		public void Merge(PropertyCollection propertyToMerge) {} // 0x0000000189B31C4C-0x0000000189B31DB4
		// Void Merge(PropertyCollection)
		// Hidden C++ exception states: #wind=1
		void IniParser::Model::PropertyCollection::Merge(
		        PropertyCollection *this,
		        PropertyCollection *propertyToMerge,
		        MethodInfo *method)
		{
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Property *v11; // rbx
		  Property *v12; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  List_1_System_Object_ *Comments; // rdi
		  IEnumerable_1_System_Object_ *v16; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  _QWORD v19[4]; // [rsp+28h] [rbp-20h] BYREF
		  IEnumerator_1_IniParser_Model_Property_ *Enumerator; // [rsp+58h] [rbp+10h] BYREF
		
		  if ( !propertyToMerge )
		    sub_1800D8260(this, 0LL);
		  Enumerator = IniParser::Model::PropertyCollection::GetEnumerator(propertyToMerge, 0LL);
		  v19[0] = 0LL;
		  v19[1] = &Enumerator;
		  while ( 1 )
		  {
		    if ( !Enumerator )
		      sub_1800D8250(v5, v4);
		    if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		      break;
		    if ( !Enumerator )
		      sub_1800D8250(v7, v6);
		    v8 = sub_18006E0A0();
		    v11 = (Property *)v8;
		    if ( !v8 )
		      sub_1800D8250(v10, v9);
		    IniParser::Model::PropertyCollection::Add(this, *(String **)(v8 + 24), 0LL);
		    IniParser::Model::PropertyCollection::set_Item(
		      this,
		      v11->fields._Key_k__BackingField,
		      v11->fields._Value_k__BackingField,
		      0LL);
		    v12 = IniParser::Model::PropertyCollection::FindByKey(this, v11->fields._Key_k__BackingField, 0LL);
		    if ( !v12 )
		      sub_1800D8250(v14, v13);
		    Comments = (List_1_System_Object_ *)IniParser::Model::Property::get_Comments(v12, 0LL);
		    v16 = (IEnumerable_1_System_Object_ *)IniParser::Model::Property::get_Comments(v11, 0LL);
		    if ( !Comments )
		      sub_1800D8250(v18, v17);
		    System::Collections::Generic::List<System::Object>::AddRange(
		      Comments,
		      v16,
		      MethodInfo::System::Collections::Generic::List<System::String>::AddRange);
		  }
		  sub_1801F6A10(v19);
		}
		
		public void Clear() {} // 0x00000001835A7A30-0x00000001835A7A60
		// Void Clear()
		void IniParser::Model::PropertyCollection::Clear(PropertyCollection *this, MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
		
		  properties = this->fields._properties;
		  if ( !properties )
		    sub_1800D8260(0LL, method);
		  System::Collections::Generic::Dictionary<System::Object,System::Object>::Clear(
		    (Dictionary_2_System_Object_System_Object_ *)properties,
		    MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::Clear);
		}
		
		public bool Remove(string keyName) => default; // 0x0000000189B31DB4-0x0000000189B31DD8
		// Boolean Remove(String)
		bool IniParser::Model::PropertyCollection::Remove(PropertyCollection *this, String *keyName, MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
		
		  properties = this->fields._properties;
		  if ( !properties )
		    sub_1800D8260(0LL, keyName);
		  return System::Collections::Generic::Dictionary<System::Object,System::Object>::Remove(
		           (Dictionary_2_System_Object_System_Object_ *)properties,
		           (Object *)keyName,
		           MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::Remove);
		}
		
		[IteratorStateMachine(typeof(_GetEnumerator_d__17))]
		public IEnumerator<Property> GetEnumerator() => default; // 0x000000018368AE90-0x000000018368AED0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189B31DD8-0x0000000189B31E34
		// IEnumerator System.Collections.IEnumerable.GetEnumerator()
		IEnumerator *IniParser::Model::PropertyCollection::System_Collections_IEnumerable_GetEnumerator(
		        PropertyCollection *this,
		        MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rdx
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ v4; // [rsp+20h] [rbp-58h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ v5; // [rsp+48h] [rbp-30h] BYREF
		
		  properties = this->fields._properties;
		  if ( !properties )
		    sub_1800D8260(this, 0LL);
		  System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
		    &v4,
		    (Dictionary_2_System_UInt64_System_Object_ *)properties,
		    MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::GetEnumerator);
		  v5 = v4;
		  return (IEnumerator *)il2cpp_value_box_0(
		                          TypeInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,IniParser::Model::Property>,
		                          &v5);
		}
		
		public PropertyCollection DeepClone() => default; // 0x0000000189B31BF8-0x0000000189B31C4C
		// PropertyCollection DeepClone()
		PropertyCollection *IniParser::Model::PropertyCollection::DeepClone(PropertyCollection *this, MethodInfo *method)
		{
		  IEqualityComparer_1_System_String_ *searchComparer; // rsi
		  PropertyCollection *v4; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  PropertyCollection *v7; // rbx
		
		  searchComparer = this->fields._searchComparer;
		  v4 = (PropertyCollection *)sub_18002C620(TypeInfo::IniParser::Model::PropertyCollection);
		  v7 = v4;
		  if ( !v4 )
		    sub_1800D8260(v6, v5);
		  IniParser::Model::PropertyCollection::PropertyCollection(v4, this, searchComparer, 0LL);
		  return v7;
		}
		
		internal void AddPropertyInternal(Property property) {} // 0x00000001835A9F60-0x00000001835A9FB0
		internal Property GetLast() => default; // 0x0000000182B2ECC0-0x0000000182B2ECD0
		// IValueSource get_source()
		IValueSource *Beyond::ValueAdapter<Beyond::GameSetting::ScreenResolution>::get_source(
		        ValueAdapter_1_GameSetting_ScreenResolution_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_source;
		}
		
	}
}
