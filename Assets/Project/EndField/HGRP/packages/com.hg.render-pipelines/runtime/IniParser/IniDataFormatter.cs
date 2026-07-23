using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using IniParser.Configuration;
using IniParser.Format;
using IniParser.Model;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IniParser
{
	public class IniDataFormatter : IIniDataFormatter // TypeDefIndex: 37372
	{
		// Constructors
		public IniDataFormatter() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		public string Format(IniData iniData, IniFormattingConfiguration format) => default; // 0x0000000189B30A64-0x0000000189B30C54
		// String Format(IniData, IniFormattingConfiguration)
		// Hidden C++ exception states: #wind=1
		String *IniParser::IniDataFormatter::Format(
		        IniDataFormatter *this,
		        IniData *iniData,
		        IniFormattingConfiguration *format,
		        MethodInfo *method)
		{
		  IniFormattingConfiguration *v4; // rsi
		  StringBuilder *v7; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  StringBuilder *v10; // rdi
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  PropertyCollection *Global_k__BackingField; // rbx
		  IniScheme *Scheme; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  Section *v21; // rbx
		  IniScheme *v22; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  const char *v25; // rax
		  Il2CppExceptionWrapper *v27; // [rsp+38h] [rbp-30h] BYREF
		  _QWORD v28[2]; // [rsp+40h] [rbp-28h] BYREF
		  IEnumerator_1_IniParser_Model_Section_ *Enumerator; // [rsp+78h] [rbp+10h] BYREF
		  IniFormattingConfiguration *v30; // [rsp+80h] [rbp+18h]
		
		  v30 = format;
		  v4 = format;
		  v7 = (StringBuilder *)sub_18002C620(TypeInfo::System::Text::StringBuilder);
		  v10 = v7;
		  if ( !v7 )
		    sub_1800D8260(v9, v8);
		  System::Text::StringBuilder::StringBuilder(v7, 0LL);
		  if ( !iniData )
		    sub_1800D8260(v12, v11);
		  Global_k__BackingField = iniData->fields._Global_k__BackingField;
		  Scheme = IniParser::IniData::get_Scheme(iniData, 0LL);
		  IniParser::IniDataFormatter::WriteProperties(this, Global_k__BackingField, v10, Scheme, v4, 0LL);
		  if ( !iniData->fields._Sections_k__BackingField )
		    sub_1800D8260(v16, v15);
		  Enumerator = IniParser::Model::SectionCollection::GetEnumerator(iniData->fields._Sections_k__BackingField, 0LL);
		  v28[0] = 0LL;
		  v28[1] = &Enumerator;
		  try
		  {
		    while ( 1 )
		    {
		      if ( !Enumerator )
		        sub_1800D8250(v18, v17);
		      if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		        break;
		      if ( !Enumerator )
		        sub_1800D8250(v20, v19);
		      v21 = (Section *)sub_18006E140();
		      v22 = IniParser::IniData::get_Scheme(iniData, 0LL);
		      IniParser::IniDataFormatter::WriteSection(this, v21, v10, v22, v4, 0LL);
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v27 )
		  {
		    v28[0] = v27->ex;
		    sub_1801F6A10(v28);
		    v4 = v30;
		    goto LABEL_10;
		  }
		  sub_1801F6A10(v28);
		LABEL_10:
		  if ( !v4 )
		    goto LABEL_16;
		  v25 = "\n";
		  if ( !v4->fields._NewLineType_k__BackingField )
		    v25 = "\r\n";
		  if ( !v25 || !v10 )
		LABEL_16:
		    sub_1800D8250(v24, v23);
		  System::Text::StringBuilder::Remove(
		    v10,
		    v10->fields.m_ChunkLength + v10->fields.m_ChunkOffset - *((_DWORD *)v25 + 4),
		    *((_DWORD *)v25 + 4),
		    0LL);
		  return (String *)sub_180032CB0(3LL, v10);
		}
		
		protected virtual void WriteSection(Section section, StringBuilder sb, IniScheme scheme, IniFormattingConfiguration format) {} // 0x0000000189B31008-0x0000000189B3116C
		// Void WriteSection(Section, StringBuilder, IniScheme, IniFormattingConfiguration)
		void IniParser::IniDataFormatter::WriteSection(
		        IniDataFormatter *this,
		        Section *section,
		        StringBuilder *sb,
		        IniScheme *scheme,
		        IniFormattingConfiguration *format,
		        MethodInfo *method)
		{
		  List_1_System_String_ *Comments; // rax
		  char *v11; // rdx
		  String *SectionStartString; // rax
		  String *name; // rbx
		  String *v14; // rdi
		  String *SectionEndString; // r8
		  char *v16; // r9
		  String *v17; // rax
		  char *v18; // rdx
		
		  if ( !section )
		    goto LABEL_18;
		  Comments = IniParser::Model::Section::get_Comments(section, 0LL);
		  IniParser::IniDataFormatter::WriteComments(this, Comments, sb, scheme, format, 0LL);
		  if ( !format )
		    goto LABEL_18;
		  if ( format->fields._NewLineBeforeSection_k__BackingField )
		  {
		    if ( !sb )
		      goto LABEL_18;
		    if ( sb->fields.m_ChunkLength + sb->fields.m_ChunkOffset > 0 )
		    {
		      v11 = "\n";
		      if ( !format->fields._NewLineType_k__BackingField )
		        v11 = "\r\n";
		      System::Text::StringBuilder::Append(sb, (String *)v11, 0LL);
		    }
		  }
		  if ( !scheme )
		    goto LABEL_18;
		  SectionStartString = IniParser::Configuration::IniScheme::get_SectionStartString(scheme, 0LL);
		  name = section->fields._name;
		  v14 = SectionStartString;
		  SectionEndString = IniParser::Configuration::IniScheme::get_SectionEndString(scheme, 0LL);
		  v16 = "\n";
		  if ( !format->fields._NewLineType_k__BackingField )
		    v16 = "\r\n";
		  v17 = System::String::Concat(v14, name, SectionEndString, (String *)v16, 0LL);
		  if ( !sb )
		LABEL_18:
		    sub_1800D8260(this, section);
		  System::Text::StringBuilder::Append(sb, v17, 0LL);
		  if ( format->fields._NewLineAfterSection_k__BackingField )
		  {
		    v18 = "\n";
		    if ( !format->fields._NewLineType_k__BackingField )
		      v18 = "\r\n";
		    System::Text::StringBuilder::Append(sb, (String *)v18, 0LL);
		  }
		  IniParser::IniDataFormatter::WriteProperties(
		    this,
		    section->fields._Properties_k__BackingField,
		    sb,
		    scheme,
		    format,
		    0LL);
		}
		
		protected virtual void WriteProperties(PropertyCollection properties, StringBuilder sb, IniScheme scheme, IniFormattingConfiguration format) {} // 0x0000000189B30D90-0x0000000189B31008
		// Void WriteProperties(PropertyCollection, StringBuilder, IniScheme, IniFormattingConfiguration)
		// Hidden C++ exception states: #wind=1
		void IniParser::IniDataFormatter::WriteProperties(
		        IniDataFormatter *this,
		        PropertyCollection *properties,
		        StringBuilder *sb,
		        IniScheme *scheme,
		        IniFormattingConfiguration *format,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  IniFormattingConfiguration *v11; // rbx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  Property *v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  Property *v17; // r14
		  List_1_System_String_ *Comments; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  char *v21; // rdx
		  __int64 v22; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  String__Array *v25; // rdi
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  String *PropertyAssigmentString; // rax
		  const char *v29; // r8
		  String *v30; // rax
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  char *v33; // rdx
		  _QWORD v34[3]; // [rsp+38h] [rbp-30h] BYREF
		  IEnumerator_1_IniParser_Model_Property_ *Enumerator; // [rsp+78h] [rbp+10h] BYREF
		
		  if ( !properties )
		    sub_1800D8260(this, 0LL);
		  Enumerator = IniParser::Model::PropertyCollection::GetEnumerator(properties, 0LL);
		  v34[0] = 0LL;
		  v34[1] = &Enumerator;
		  v11 = format;
		  while ( 1 )
		  {
		    if ( !Enumerator )
		      sub_1800D8250(v10, v9);
		    if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		      break;
		    if ( !Enumerator )
		      sub_1800D8250(v13, v12);
		    v14 = (Property *)sub_18006E0A0();
		    v17 = v14;
		    if ( !v14 )
		      sub_1800D8250(v16, v15);
		    Comments = IniParser::Model::Property::get_Comments(v14, 0LL);
		    IniParser::IniDataFormatter::WriteComments(this, Comments, sb, scheme, v11, 0LL);
		    if ( !v11 )
		      sub_1800D8250(v20, v19);
		    if ( v11->fields._NewLineBeforeProperty_k__BackingField )
		    {
		      v21 = "\n";
		      if ( !v11->fields._NewLineType_k__BackingField )
		        v21 = "\r\n";
		      if ( !sb )
		        sub_1800D8250(v20, v21);
		      System::Text::StringBuilder::Append(sb, (String *)v21, 0LL);
		    }
		    v22 = il2cpp_array_new_specific_1(TypeInfo::System::String, 6LL);
		    v25 = (String__Array *)v22;
		    if ( !v22 )
		      sub_1800D8250(v24, v23);
		    sub_180005370(v22, 0LL, v17->fields._Key_k__BackingField);
		    sub_180005370(v25, 1LL, v11->fields._SpacesBetweenKeyAndAssigment_k__BackingField);
		    if ( !scheme )
		      sub_1800D8250(v27, v26);
		    PropertyAssigmentString = IniParser::Configuration::IniScheme::get_PropertyAssigmentString(scheme, 0LL);
		    sub_180005370(v25, 2LL, PropertyAssigmentString);
		    sub_180005370(v25, 3LL, v11->fields._SpacesBetweenAssigmentAndValue_k__BackingField);
		    sub_180005370(v25, 4LL, v17->fields._Value_k__BackingField);
		    v29 = "\n";
		    if ( !v11->fields._NewLineType_k__BackingField )
		      v29 = "\r\n";
		    sub_180005370(v25, 5LL, v29);
		    v30 = System::String::Concat(v25, 0LL);
		    if ( !sb )
		      sub_1800D8250(v32, v31);
		    System::Text::StringBuilder::Append(sb, v30, 0LL);
		    if ( v11->fields._NewLineAfterProperty_k__BackingField )
		    {
		      v33 = "\n";
		      if ( !v11->fields._NewLineType_k__BackingField )
		        v33 = "\r\n";
		      System::Text::StringBuilder::Append(sb, (String *)v33, 0LL);
		    }
		  }
		  sub_1801F6A10(v34);
		}
		
		protected virtual void WriteComments(List<string> comments, StringBuilder sb, IniScheme scheme, IniFormattingConfiguration format) {} // 0x0000000189B30C54-0x0000000189B30D90
		// Void WriteComments(List`1[System.String], StringBuilder, IniScheme, IniFormattingConfiguration)
		// Hidden C++ exception states: #wind=1
		void IniParser::IniDataFormatter::WriteComments(
		        IniDataFormatter *this,
		        List_1_System_String_ *comments,
		        StringBuilder *sb,
		        IniScheme *scheme,
		        IniFormattingConfiguration *format,
		        MethodInfo *method)
		{
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Object *current; // r14
		  String *CommentString; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  char *v14; // r8
		  String *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  Il2CppExceptionWrapper *v18; // [rsp+20h] [rbp-48h] BYREF
		  List_1_T_Enumerator_System_Object_ v19; // [rsp+28h] [rbp-40h] BYREF
		  List_1_T_Enumerator_System_Object_ v20; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( !comments )
		    sub_1800D8260(this, 0LL);
		  System::Collections::Generic::List<unsigned long>::GetEnumerator(
		    (List_1_T_Enumerator_System_UInt64_ *)&v19,
		    (List_1_System_UInt64_ *)comments,
		    MethodInfo::System::Collections::Generic::List<System::String>::GetEnumerator);
		  v20 = v19;
		  v19._list = 0LL;
		  *(_QWORD *)&v19._index = &v20;
		  try
		  {
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v20,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::String>::MoveNext) )
		    {
		      current = v20._current;
		      if ( !scheme )
		        sub_1800D8250(v9, v8);
		      CommentString = IniParser::Configuration::IniScheme::get_CommentString(scheme, 0LL);
		      if ( !format )
		        sub_1800D8250(v13, v12);
		      v14 = "\n";
		      if ( !format->fields._NewLineType_k__BackingField )
		        v14 = "\r\n";
		      v15 = System::String::Concat(CommentString, (String *)current, (String *)v14, 0LL);
		      if ( !sb )
		        sub_1800D8250(v17, v16);
		      System::Text::StringBuilder::Append(sb, v15, 0LL);
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v18 )
		  {
		    v19._list = (List_1_System_Object_ *)v18->ex;
		    if ( v19._list )
		      sub_18007E1E0(v19._list);
		  }
		}
		
	}
}
