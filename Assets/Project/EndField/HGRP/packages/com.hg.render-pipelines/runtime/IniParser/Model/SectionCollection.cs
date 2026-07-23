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
	public class SectionCollection : IDeepCloneable<SectionCollection>, IEnumerable<Section> // TypeDefIndex: 37383
	{
		// Fields
		private readonly Dictionary<string, Section> _sections; // 0x10
		private readonly IEqualityComparer<string> _searchComparer; // 0x18
	
		// Properties
		public int Count { get => default; } // 0x0000000184D77890-0x0000000184D778B0 
		// Int32 get_Count()
		int32_t IniParser::Model::SectionCollection::get_Count(SectionCollection *this, MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rax
		
		  sections = this->fields._sections;
		  if ( !sections )
		    sub_1800D8260(this, method);
		  return sections->fields._count - sections->fields._freeCount;
		}
		
		public PropertyCollection this[string sectionName] { get => default; } // 0x0000000189B326C4-0x0000000189B32724 
		// PropertyCollection get_Item(String)
		PropertyCollection *IniParser::Model::SectionCollection::get_Item(
		        SectionCollection *this,
		        String *sectionName,
		        MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rcx
		  Object *Item; // rax
		
		  sections = this->fields._sections;
		  if ( !sections )
		    goto LABEL_7;
		  if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		          (Dictionary_2_System_Object_System_Object_ *)sections,
		          (Object *)sectionName,
		          MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::ContainsKey) )
		    return 0LL;
		  sections = this->fields._sections;
		  if ( !sections
		    || (Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                 (Dictionary_2_System_Object_System_Object_ *)sections,
		                 (Object *)sectionName,
		                 MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::get_Item)) == 0LL )
		  {
		LABEL_7:
		    sub_1800D8260(sections, sectionName);
		  }
		  return (PropertyCollection *)Item[1].klass;
		}
		
	
		// Constructors
		public SectionCollection() {} // 0x00000001835A7D30-0x00000001835A7D60
		// SectionCollection()
		void IniParser::Model::SectionCollection::SectionCollection(SectionCollection *this, MethodInfo *method)
		{
		  IEqualityComparer_1_System_String_ *v3; // rax
		
		  v3 = (IEqualityComparer_1_System_String_ *)sub_182EEDEE0(MethodInfo::System::Collections::Generic::EqualityComparer<System::String>::get_Default);
		  IniParser::Model::SectionCollection::SectionCollection(this, v3, 0LL);
		}
		
		public SectionCollection(IEqualityComparer<string> searchComparer) {} // 0x00000001835A7DC0-0x00000001835A7E30
		public SectionCollection(SectionCollection ori, IEqualityComparer<string> searchComparer) {} // 0x0000000189B32528-0x0000000189B326C4
		// SectionCollection(SectionCollection, IEqualityComparer`1[System.String])
		// Hidden C++ exception states: #wind=1
		void IniParser::Model::SectionCollection::SectionCollection(
		        SectionCollection *this,
		        SectionCollection *ori,
		        IEqualityComparer_1_System_String_ *searchComparer,
		        MethodInfo *method)
		{
		  IEqualityComparer_1_System_String_ *v4; // rdi
		  IEqualityComparer_1_System_String_ *v7; // r14
		  Dictionary_2_System_Object_System_Object_ *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Dictionary_2_System_String_IniParser_Model_Section_ *v11; // rdi
		  UberPostPassUtils_ColorGradingData **v12; // rdx
		  VolumetricPipelineRT **v13; // r8
		  VolumetricPipelineRT **v14; // r9
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  Section *v21; // rax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rdi
		  Object *name; // rsi
		  Object *v26; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  VolumetricPipelineRT **v29; // [rsp+20h] [rbp-28h]
		  VolumetricPipelineRT **v30; // [rsp+20h] [rbp-28h]
		  MethodInfo *v31[4]; // [rsp+28h] [rbp-20h] BYREF
		  IEnumerator_1_IniParser_Model_Section_ *Enumerator; // [rsp+50h] [rbp+8h] BYREF
		
		  v4 = searchComparer;
		  if ( !searchComparer )
		    v4 = (IEqualityComparer_1_System_String_ *)sub_182EEDEE0(MethodInfo::System::Collections::Generic::EqualityComparer<System::String>::get_Default);
		  if ( !this )
		    sub_1800D8260(this, ori);
		  this->fields._searchComparer = v4;
		  sub_18002D1B0(
		    (ParsingException *)&this->fields._searchComparer,
		    (UberPostPassUtils_ColorGradingData **)ori,
		    (VolumetricPipelineRT **)searchComparer,
		    (VolumetricPipelineRT **)method,
		    v29,
		    v31[0]);
		  v7 = this->fields._searchComparer;
		  v8 = (Dictionary_2_System_Object_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>);
		  v11 = (Dictionary_2_System_String_IniParser_Model_Section_ *)v8;
		  if ( !v8 )
		    sub_1800D8260(v10, v9);
		  System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
		    v8,
		    (IEqualityComparer_1_System_Object_ *)v7,
		    MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Dictionary);
		  this->fields._sections = v11;
		  sub_18002D1B0((ParsingException *)&this->fields, v12, v13, v14, v30, v31[0]);
		  if ( !ori )
		    sub_1800D8260(v16, v15);
		  Enumerator = IniParser::Model::SectionCollection::GetEnumerator(ori, 0LL);
		  v31[0] = 0LL;
		  v31[1] = (MethodInfo *)&Enumerator;
		  while ( 1 )
		  {
		    if ( !Enumerator )
		      sub_1800D8250(v18, v17);
		    if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		      break;
		    if ( !Enumerator )
		      sub_1800D8250(v20, v19);
		    v21 = (Section *)sub_18006E140();
		    sections = this->fields._sections;
		    if ( !v21 )
		      sub_1800D8250(v23, v22);
		    name = (Object *)v21->fields._name;
		    v26 = (Object *)IniParser::Model::Section::DeepClone(v21, 0LL);
		    if ( !sections )
		      sub_1800D8250(v28, v27);
		    System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
		      (Dictionary_2_System_Object_System_Object_ *)sections,
		      name,
		      v26,
		      MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Add);
		  }
		  sub_1801F6A10(v31);
		}
		
	
		// Methods
		public bool Add(string sectionName) => default; // 0x00000001835A8220-0x00000001835A82B0
		// Boolean Add(String)
		bool IniParser::Model::SectionCollection::Add(SectionCollection *this, String *sectionName, MethodInfo *method)
		{
		  IEqualityComparer_1_System_String_ *searchComparer; // rbp
		  Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rsi
		  Section *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Object *v10; // rbx
		
		  if ( IniParser::Model::SectionCollection::Contains(this, sectionName, 0LL) )
		    return 0;
		  searchComparer = this->fields._searchComparer;
		  sections = this->fields._sections;
		  v7 = (Section *)sub_1800368D0(TypeInfo::IniParser::Model::Section);
		  v10 = (Object *)v7;
		  if ( !v7 || (IniParser::Model::Section::Section(v7, sectionName, searchComparer, 0LL), !sections) )
		    sub_1800D8260(v9, v8);
		  System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
		    (Dictionary_2_System_Object_System_Object_ *)sections,
		    (Object *)sectionName,
		    v10,
		    MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Add);
		  return 1;
		}
		
		public void Add(Section data) {} // 0x0000000189B32290-0x0000000189B32374
		// Void Add(Section)
		void IniParser::Model::SectionCollection::Add(SectionCollection *this, Section *data, MethodInfo *method)
		{
		  bool v5; // al
		  Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rdi
		  Object *name; // rbp
		  IEqualityComparer_1_System_String_ *searchComparer; // r14
		  Section *v9; // rax
		  Object *v10; // rsi
		  Section *v11; // rax
		  Object *v12; // rsi
		
		  if ( !data )
		    goto LABEL_9;
		  v5 = IniParser::Model::SectionCollection::Contains(this, data->fields._name, 0LL);
		  sections = this->fields._sections;
		  name = (Object *)data->fields._name;
		  searchComparer = this->fields._searchComparer;
		  if ( !v5 )
		  {
		    v9 = (Section *)sub_18002C620(TypeInfo::IniParser::Model::Section);
		    v10 = (Object *)v9;
		    if ( v9 )
		    {
		      IniParser::Model::Section::Section(v9, data, searchComparer, 0LL);
		      if ( sections )
		      {
		        System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
		          (Dictionary_2_System_Object_System_Object_ *)sections,
		          name,
		          v10,
		          MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Add);
		        return;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(this, data);
		  }
		  v11 = (Section *)sub_18002C620(TypeInfo::IniParser::Model::Section);
		  v12 = (Object *)v11;
		  if ( !v11 )
		    goto LABEL_9;
		  IniParser::Model::Section::Section(v11, data, searchComparer, 0LL);
		  if ( !sections )
		    goto LABEL_9;
		  System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
		    (Dictionary_2_System_Object_System_Object_ *)sections,
		    name,
		    v12,
		    MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::set_Item);
		}
		
		public void Clear() {} // 0x00000001835A7A00-0x00000001835A7A30
		// Void Clear()
		void IniParser::Model::SectionCollection::Clear(SectionCollection *this, MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rcx
		
		  sections = this->fields._sections;
		  if ( !sections )
		    sub_1800D8260(0LL, method);
		  System::Collections::Generic::Dictionary<System::Object,System::Object>::Clear(
		    (Dictionary_2_System_Object_System_Object_ *)sections,
		    MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Clear);
		}
		
		public bool Contains(string sectionName) => default; // 0x00000001835A8430-0x00000001835A8460
		// Boolean Contains(String)
		bool IniParser::Model::SectionCollection::Contains(SectionCollection *this, String *sectionName, MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rcx
		
		  sections = this->fields._sections;
		  if ( !sections )
		    sub_1800D8260(0LL, sectionName);
		  return System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		           (Dictionary_2_System_Object_System_Object_ *)sections,
		           (Object *)sectionName,
		           MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::ContainsKey);
		}
		
		public Section FindByName(string sectionName) => default; // 0x00000001835A9C20-0x00000001835A9C80
		// Section FindByName(String)
		Section *IniParser::Model::SectionCollection::FindByName(
		        SectionCollection *this,
		        String *sectionName,
		        MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rcx
		
		  sections = this->fields._sections;
		  if ( !sections )
		    goto LABEL_6;
		  if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		         (Dictionary_2_System_Object_System_Object_ *)sections,
		         (Object *)sectionName,
		         MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::ContainsKey) )
		  {
		    sections = this->fields._sections;
		    if ( sections )
		      return (Section *)System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
		                          (Dictionary_2_System_Object_System_Object_ *)sections,
		                          (Object *)sectionName,
		                          MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::get_Item);
		LABEL_6:
		    sub_1800D8260(sections, sectionName);
		  }
		  return 0LL;
		}
		
		public void Merge(SectionCollection sectionsToMerge) {} // 0x0000000189B323C8-0x0000000189B324FC
		// Void Merge(SectionCollection)
		// Hidden C++ exception states: #wind=1
		void IniParser::Model::SectionCollection::Merge(
		        SectionCollection *this,
		        SectionCollection *sectionsToMerge,
		        MethodInfo *method)
		{
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // rbx
		  PropertyCollection *Item; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Il2CppExceptionWrapper *v15; // [rsp+20h] [rbp-28h] BYREF
		  _QWORD v16[4]; // [rsp+28h] [rbp-20h] BYREF
		  IEnumerator_1_IniParser_Model_Section_ *Enumerator; // [rsp+58h] [rbp+10h] BYREF
		
		  if ( !sectionsToMerge )
		    sub_1800D8260(this, 0LL);
		  Enumerator = IniParser::Model::SectionCollection::GetEnumerator(sectionsToMerge, 0LL);
		  v16[0] = 0LL;
		  v16[1] = &Enumerator;
		  try
		  {
		    while ( 1 )
		    {
		      if ( !Enumerator )
		        sub_1800D8250(v5, v4);
		      if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		        break;
		      if ( !Enumerator )
		        sub_1800D8250(v7, v6);
		      v8 = sub_18006E140();
		      v11 = v8;
		      if ( !v8 )
		        sub_1800D8250(v10, v9);
		      if ( !IniParser::Model::SectionCollection::FindByName(this, *(String **)(v8 + 32), 0LL) )
		        IniParser::Model::SectionCollection::Add(this, *(String **)(v11 + 32), 0LL);
		      Item = IniParser::Model::SectionCollection::get_Item(this, *(String **)(v11 + 32), 0LL);
		      if ( !Item )
		        sub_1800D8250(v14, v13);
		      IniParser::Model::PropertyCollection::Merge(Item, *(PropertyCollection **)(v11 + 16), 0LL);
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v15 )
		  {
		    v16[0] = v15->ex;
		  }
		  sub_1801F6A10(v16);
		}
		
		public bool Remove(string sectionName) => default; // 0x0000000189B324FC-0x0000000189B32520
		// Boolean Remove(String)
		bool IniParser::Model::SectionCollection::Remove(SectionCollection *this, String *sectionName, MethodInfo *method)
		{
		  Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rcx
		
		  sections = this->fields._sections;
		  if ( !sections )
		    sub_1800D8260(0LL, sectionName);
		  return System::Collections::Generic::Dictionary<System::Object,System::Object>::Remove(
		           (Dictionary_2_System_Object_System_Object_ *)sections,
		           (Object *)sectionName,
		           MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Remove);
		}
		
		[IteratorStateMachine(typeof(_GetEnumerator_d__14))]
		public IEnumerator<Section> GetEnumerator() => default; // 0x000000018368B420-0x000000018368B460
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189B32520-0x0000000189B32528
		// IEnumerator System.Collections.IEnumerable.GetEnumerator()
		IEnumerator *IniParser::Model::SectionCollection::System_Collections_IEnumerable_GetEnumerator(
		        SectionCollection *this,
		        MethodInfo *method)
		{
		  return (IEnumerator *)IniParser::Model::SectionCollection::GetEnumerator(this, 0LL);
		}
		
		public SectionCollection DeepClone() => default; // 0x0000000189B32374-0x0000000189B323C8
		// SectionCollection DeepClone()
		SectionCollection *IniParser::Model::SectionCollection::DeepClone(SectionCollection *this, MethodInfo *method)
		{
		  IEqualityComparer_1_System_String_ *searchComparer; // rsi
		  SectionCollection *v4; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  SectionCollection *v7; // rbx
		
		  searchComparer = this->fields._searchComparer;
		  v4 = (SectionCollection *)sub_18002C620(TypeInfo::IniParser::Model::SectionCollection);
		  v7 = v4;
		  if ( !v4 )
		    sub_1800D8260(v6, v5);
		  IniParser::Model::SectionCollection::SectionCollection(v4, this, searchComparer, 0LL);
		  return v7;
		}
		
	}
}
