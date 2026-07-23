using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IniParser;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IniParser.Model
{
	public class Section : IDeepCloneable<Section> // TypeDefIndex: 37381
	{
		// Fields
		private List<string> _comments; // 0x18
		private string _name; // 0x20
		private readonly IEqualityComparer<string> _searchComparer; // 0x28
	
		// Properties
		public string Name { get => default; set {} } // 0x0000000184D862C0-0x0000000184D862D0 0x00000001835A8140-0x00000001835A8160
		// Func`1[Single] get_getValueDelegate()
		Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
		        ValueWatcher_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
		}
		

		// Void set_Name(String)
		void IniParser::Model::Section::set_Name(Section *this, String *value, MethodInfo *method)
		{
		  VolumetricPipelineRT **v3; // r9
		  VolumetricPipelineRT **v4; // [rsp+28h] [rbp+28h]
		  MethodInfo *v5; // [rsp+30h] [rbp+30h]
		
		  if ( value )
		  {
		    if ( value->fields._stringLength )
		    {
		      this->fields._name = value;
		      sub_18002D1B0(
		        (ParsingException *)&this->fields._name,
		        (UberPostPassUtils_ColorGradingData **)value,
		        (VolumetricPipelineRT **)method,
		        v3,
		        v4,
		        v5);
		    }
		  }
		}
		
		public List<string> Comments { get => default; set {} } // 0x00000001835AA900-0x00000001835AA960 0x0000000189B32A18-0x0000000189B32AA8
		public PropertyCollection Properties { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		// IValueSource get_source()
		IValueSource *Beyond::ValueAdapter<Beyond::GameSetting::ScreenResolution>::get_source(
		        ValueAdapter_1_GameSetting_ScreenResolution_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_source;
		}
		

		// SortedList`2[TKey,TValue]+ValueList[System.Object,System.Object](SortedList`2[System.Object,System.Object])
		void System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
		        SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *this,
		        SortedList_2_System_Object_System_Object_ *dictionary,
		        MethodInfo *method)
		{
		  VolumetricPipelineRT **v3; // r9
		  VolumetricPipelineRT **v4; // [rsp+28h] [rbp+28h]
		  MethodInfo *v5; // [rsp+30h] [rbp+30h]
		
		  this->fields._dict = dictionary;
		  sub_18002D1B0(
		    (ILFixDynamicMethodWrapper_2 *)&this->fields,
		    (UberPostPassUtils_ColorGradingData **)dictionary,
		    (VolumetricPipelineRT **)method,
		    v3,
		    v4,
		    v5);
		}
		
	
		// Constructors
		public Section() {} // Dummy constructor
		public Section(string sectionName) {} // 0x0000000189B329E0-0x0000000189B32A18
		// Section(String)
		void IniParser::Model::Section::Section(Section *this, String *sectionName, MethodInfo *method)
		{
		  IEqualityComparer_1_System_String_ *v5; // rax
		
		  v5 = (IEqualityComparer_1_System_String_ *)sub_182EEDEE0(MethodInfo::System::Collections::Generic::EqualityComparer<System::String>::get_Default);
		  IniParser::Model::Section::Section(this, sectionName, v5, 0LL);
		}
		
		public Section(string sectionName, IEqualityComparer<string> searchComparer) {} // 0x00000001835A80A0-0x00000001835A8140
		public Section(Section ori, IEqualityComparer<string> searchComparer = null) {} // 0x0000000189B32930-0x0000000189B329E0
	
		// Methods
		public void Clear() {} // 0x0000000189B32784-0x0000000189B327A4
		// Void Clear()
		void IniParser::Model::Section::Clear(Section *this, MethodInfo *method)
		{
		  IniParser::Model::Section::ClearProperties(this, 0LL);
		  IniParser::Model::Section::ClearComments(this, 0LL);
		}
		
		public void ClearComments() {} // 0x0000000189B32724-0x0000000189B32764
		// Void ClearComments()
		void IniParser::Model::Section::ClearComments(Section *this, MethodInfo *method)
		{
		  List_1_System_String_ *Comments; // rax
		  __int64 v4; // rdx
		  PropertyCollection *Properties_k__BackingField; // rcx
		
		  Comments = IniParser::Model::Section::get_Comments(this, 0LL);
		  if ( !Comments
		    || (sub_183127A90(Comments, MethodInfo::System::Collections::Generic::List<System::String>::Clear),
		        (Properties_k__BackingField = this->fields._Properties_k__BackingField) == 0LL) )
		  {
		    sub_1800D8260(Properties_k__BackingField, v4);
		  }
		  IniParser::Model::PropertyCollection::ClearComments(Properties_k__BackingField, 0LL);
		}
		
		public void ClearProperties() {} // 0x0000000189B32764-0x0000000189B32784
		// Void ClearProperties()
		void IniParser::Model::Section::ClearProperties(Section *this, MethodInfo *method)
		{
		  PropertyCollection *Properties_k__BackingField; // rcx
		
		  Properties_k__BackingField = this->fields._Properties_k__BackingField;
		  if ( !Properties_k__BackingField )
		    sub_1800D8260(0LL, method);
		  IniParser::Model::PropertyCollection::Clear(Properties_k__BackingField, 0LL);
		}
		
		public void Merge(Section toMergeSection) {} // 0x0000000189B327EC-0x0000000189B32930
		// Void Merge(Section)
		// Hidden C++ exception states: #wind=1
		void IniParser::Model::Section::Merge(Section *this, Section *toMergeSection, MethodInfo *method)
		{
		  List_1_System_String_ *Comments; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Object *current; // rbx
		  List_1_System_Object_ *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Il2CppExceptionWrapper *v12; // [rsp+20h] [rbp-48h] BYREF
		  List_1_T_Enumerator_System_Object_ v13; // [rsp+28h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v14; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( !toMergeSection )
		    sub_1800D8260(this, 0LL);
		  if ( !this->fields._Properties_k__BackingField )
		    sub_1800D8260(this, toMergeSection);
		  IniParser::Model::PropertyCollection::Merge(
		    this->fields._Properties_k__BackingField,
		    toMergeSection->fields._Properties_k__BackingField,
		    0LL);
		  Comments = IniParser::Model::Section::get_Comments(toMergeSection, 0LL);
		  if ( !Comments )
		    sub_1800D8260(v7, v6);
		  System::Collections::Generic::List<unsigned long>::GetEnumerator(
		    (List_1_T_Enumerator_System_UInt64_ *)&v13,
		    (List_1_System_UInt64_ *)Comments,
		    MethodInfo::System::Collections::Generic::List<System::String>::GetEnumerator);
		  v14 = v13;
		  v13._list = 0LL;
		  *(_QWORD *)&v13._index = &v14;
		  try
		  {
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v14,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::String>::MoveNext) )
		    {
		      current = v14._current;
		      v9 = (List_1_System_Object_ *)IniParser::Model::Section::get_Comments(this, 0LL);
		      if ( !v9 )
		        sub_1800D8250(v11, v10);
		      sub_182F01190(v9, current);
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v12 )
		  {
		    v13._list = (List_1_System_Object_ *)v12->ex;
		    if ( v13._list )
		      sub_18007E1E0(v13._list);
		  }
		}
		
		public Section DeepClone() => default; // 0x0000000189B327A4-0x0000000189B327EC
		// Section DeepClone()
		Section *IniParser::Model::Section::DeepClone(Section *this, MethodInfo *method)
		{
		  Section *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Section *v6; // rbx
		
		  v3 = (Section *)sub_18002C620(TypeInfo::IniParser::Model::Section);
		  v6 = v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  IniParser::Model::Section::Section(v3, this, 0LL, 0LL);
		  return v6;
		}
		
	}
}
