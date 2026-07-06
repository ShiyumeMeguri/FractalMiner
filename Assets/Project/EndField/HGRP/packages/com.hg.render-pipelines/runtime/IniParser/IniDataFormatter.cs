using System;
using System.Collections.Generic;
using System.Text;
using IniParser.Configuration;
using IniParser.Format;
using IniParser.Model;

namespace IniParser
{
	public class IniDataFormatter : IIniDataFormatter
	{
		public IniDataFormatter()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public string Format(IniData iniData, IniFormattingConfiguration format)
		{
			// // String Format(IniData, IniFormattingConfiguration)
			// // Hidden C++ exception states: #wind=1
			// String *IniParser::IniDataFormatter::Format(
			//         IniDataFormatter *this,
			//         IniData *iniData,
			//         IniFormattingConfiguration *format,
			//         MethodInfo *method)
			// {
			//   StringBuilder *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   StringBuilder *v10; // rdi
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   PropertyCollection *Global_k__BackingField; // rbx
			//   IniScheme *Scheme; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   Section *v21; // rbx
			//   IniScheme *v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   String *NewLineString; // rax
			//   _QWORD v27[2]; // [rsp+40h] [rbp-28h] BYREF
			//   IEnumerator_1_IniParser_Model_Section_ *Enumerator; // [rsp+78h] [rbp+10h] BYREF
			//   IniFormattingConfiguration *v29; // [rsp+80h] [rbp+18h]
			// 
			//   v29 = format;
			//   if ( !byte_18D9192CD )
			//   {
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Section>);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     sub_18003C530(&TypeInfo::System::Text::StringBuilder);
			//     byte_18D9192CD = 1;
			//   }
			//   v7 = (StringBuilder *)sub_180004920(TypeInfo::System::Text::StringBuilder);
			//   v10 = v7;
			//   if ( !v7 )
			//     sub_180B536AC(v9, v8);
			//   System::Text::StringBuilder::StringBuilder(v7, 0LL);
			//   if ( !iniData )
			//     sub_180B536AC(v12, v11);
			//   Global_k__BackingField = iniData.fields._Global_k__BackingField;
			//   Scheme = IniParser::IniData::get_Scheme(iniData, 0LL);
			//   IniParser::IniDataFormatter::WriteProperties(this, Global_k__BackingField, v10, Scheme, format, 0LL);
			//   if ( !iniData.fields._Sections_k__BackingField )
			//     sub_180B536AC(v16, v15);
			//   Enumerator = IniParser::Model::SectionCollection::GetEnumerator(iniData.fields._Sections_k__BackingField, 0LL);
			//   v27[0] = 0LL;
			//   v27[1] = &Enumerator;
			//   while ( 1 )
			//   {
			//     if ( !Enumerator )
			//       sub_1802DC2C8(v18, v17);
			//     if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//       break;
			//     if ( !Enumerator )
			//       sub_1802DC2C8(v20, v19);
			//     v21 = (Section *)sub_18005E510();
			//     v22 = IniParser::IniData::get_Scheme(iniData, 0LL);
			//     IniParser::IniDataFormatter::WriteSection(this, v21, v10, v22, format, 0LL);
			//   }
			//   sub_1801E4D90(v27);
			//   if ( !format
			//     || (NewLineString = IniParser::Configuration::IniFormattingConfiguration::get_NewLineString(format, 0LL)) == 0LL
			//     || !v10 )
			//   {
			//     sub_1802DC2C8(v24, v23);
			//   }
			//   System::Text::StringBuilder::Remove(
			//     v10,
			//     v10.fields.m_ChunkLength + v10.fields.m_ChunkOffset - NewLineString.fields._stringLength,
			//     NewLineString.fields._stringLength,
			//     0LL);
			//   return (String *)sub_18003F3E0(3LL, v10);
			// }
			// 
			return null;
		}

		protected virtual void WriteSection(Section section, StringBuilder sb, IniScheme scheme, IniFormattingConfiguration format)
		{
			// // Void WriteSection(Section, StringBuilder, IniScheme, IniFormattingConfiguration)
			// void IniParser::IniDataFormatter::WriteSection(
			//         IniDataFormatter *this,
			//         Section *section,
			//         StringBuilder *sb,
			//         IniScheme *scheme,
			//         IniFormattingConfiguration *format,
			//         MethodInfo *method)
			// {
			//   List_1_System_String_ *Comments; // rax
			//   String *NewLineString; // rax
			//   String *SectionStartString; // rax
			//   String *name; // rdi
			//   String *v14; // rsi
			//   String *SectionEndString; // rbx
			//   String *v16; // rax
			//   String *v17; // rax
			//   String *v18; // rax
			// 
			//   if ( !section )
			//     goto LABEL_12;
			//   Comments = IniParser::Model::Section::get_Comments(section, 0LL);
			//   IniParser::IniDataFormatter::WriteComments(this, Comments, sb, scheme, format, 0LL);
			//   if ( !format )
			//     goto LABEL_12;
			//   if ( format.fields._NewLineBeforeSection_k__BackingField )
			//   {
			//     if ( !sb )
			//       goto LABEL_12;
			//     if ( sb.fields.m_ChunkLength + sb.fields.m_ChunkOffset > 0 )
			//     {
			//       NewLineString = IniParser::Configuration::IniFormattingConfiguration::get_NewLineString(format, 0LL);
			//       System::Text::StringBuilder::Append(sb, NewLineString, 0LL);
			//     }
			//   }
			//   if ( !scheme
			//     || (SectionStartString = IniParser::Configuration::IniScheme::get_SectionStartString(scheme, 0LL),
			//         name = section.fields._name,
			//         v14 = SectionStartString,
			//         SectionEndString = IniParser::Configuration::IniScheme::get_SectionEndString(scheme, 0LL),
			//         v16 = IniParser::Configuration::IniFormattingConfiguration::get_NewLineString(format, 0LL),
			//         v17 = System::String::Concat(v14, name, SectionEndString, v16, 0LL),
			//         !sb) )
			//   {
			// LABEL_12:
			//     sub_180B536AC(this, section);
			//   }
			//   System::Text::StringBuilder::Append(sb, v17, 0LL);
			//   if ( format.fields._NewLineAfterSection_k__BackingField )
			//   {
			//     v18 = IniParser::Configuration::IniFormattingConfiguration::get_NewLineString(format, 0LL);
			//     System::Text::StringBuilder::Append(sb, v18, 0LL);
			//   }
			//   IniParser::IniDataFormatter::WriteProperties(
			//     this,
			//     section.fields._Properties_k__BackingField,
			//     sb,
			//     scheme,
			//     format,
			//     0LL);
			// }
			// 
		}

		protected virtual void WriteProperties(PropertyCollection properties, StringBuilder sb, IniScheme scheme, IniFormattingConfiguration format)
		{
			// // Void WriteProperties(PropertyCollection, StringBuilder, IniScheme, IniFormattingConfiguration)
			// // Hidden C++ exception states: #wind=1
			// void IniParser::IniDataFormatter::WriteProperties(
			//         IniDataFormatter *this,
			//         PropertyCollection *properties,
			//         StringBuilder *sb,
			//         IniScheme *scheme,
			//         IniFormattingConfiguration *format,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   IniFormattingConfiguration *v12; // rbx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   Property *v15; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   Property *v18; // rsi
			//   List_1_System_String_ *Comments; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   __int64 v22; // r8
			//   __int64 v23; // r9
			//   String *NewLineString; // rax
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   __int64 v27; // rax
			//   __int64 v28; // rdx
			//   __int64 v29; // rcx
			//   String__Array *v30; // rdi
			//   __int64 v31; // rdx
			//   __int64 v32; // rcx
			//   String *PropertyAssigmentString; // rax
			//   String *v34; // rax
			//   String *v35; // rax
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   String *v38; // rax
			//   _QWORD v39[3]; // [rsp+38h] [rbp-30h] BYREF
			//   IEnumerator_1_IniParser_Model_Property_ *Enumerator; // [rsp+78h] [rbp+10h] BYREF
			// 
			//   if ( !byte_18D9192CE )
			//   {
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Property>);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     sub_18003C530(&TypeInfo::System::String);
			//     byte_18D9192CE = 1;
			//   }
			//   if ( !properties )
			//     sub_180B536AC(this, properties);
			//   Enumerator = IniParser::Model::PropertyCollection::GetEnumerator(properties, 0LL);
			//   v39[0] = 0LL;
			//   v39[1] = &Enumerator;
			//   v12 = format;
			//   while ( 1 )
			//   {
			//     if ( !Enumerator )
			//       sub_1802DC2C8(v11, v10);
			//     if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//       break;
			//     if ( !Enumerator )
			//       sub_1802DC2C8(v14, v13);
			//     v15 = (Property *)sub_18005E5B0();
			//     v18 = v15;
			//     if ( !v15 )
			//       sub_1802DC2C8(v17, v16);
			//     Comments = IniParser::Model::Property::get_Comments(v15, 0LL);
			//     IniParser::IniDataFormatter::WriteComments(this, Comments, sb, scheme, v12, 0LL);
			//     if ( !v12 )
			//       sub_1802DC2C8(v21, v20);
			//     if ( v12.fields._NewLineBeforeProperty_k__BackingField )
			//     {
			//       NewLineString = IniParser::Configuration::IniFormattingConfiguration::get_NewLineString(v12, 0LL);
			//       if ( !sb )
			//         sub_1802DC2C8(v26, v25);
			//       System::Text::StringBuilder::Append(sb, NewLineString, 0LL);
			//     }
			//     v27 = il2cpp_array_new_specific_0(TypeInfo::System::String, 6LL, v22, v23);
			//     v30 = (String__Array *)v27;
			//     if ( !v27 )
			//       sub_1802DC2C8(v29, v28);
			//     sub_1800046C0(v27, 0LL, v18.fields._Key_k__BackingField);
			//     sub_1800046C0(v30, 1LL, v12.fields._SpacesBetweenKeyAndAssigment_k__BackingField);
			//     if ( !scheme )
			//       sub_1802DC2C8(v32, v31);
			//     PropertyAssigmentString = IniParser::Configuration::IniScheme::get_PropertyAssigmentString(scheme, 0LL);
			//     sub_1800046C0(v30, 2LL, PropertyAssigmentString);
			//     sub_1800046C0(v30, 3LL, v12.fields._SpacesBetweenAssigmentAndValue_k__BackingField);
			//     sub_1800046C0(v30, 4LL, v18.fields._Value_k__BackingField);
			//     v34 = IniParser::Configuration::IniFormattingConfiguration::get_NewLineString(v12, 0LL);
			//     sub_1800046C0(v30, 5LL, v34);
			//     v35 = System::String::Concat(v30, 0LL);
			//     if ( !sb )
			//       sub_1802DC2C8(v37, v36);
			//     System::Text::StringBuilder::Append(sb, v35, 0LL);
			//     if ( v12.fields._NewLineAfterProperty_k__BackingField )
			//     {
			//       v38 = IniParser::Configuration::IniFormattingConfiguration::get_NewLineString(v12, 0LL);
			//       System::Text::StringBuilder::Append(sb, v38, 0LL);
			//     }
			//   }
			//   sub_1801E4D90(v39);
			// }
			// 
		}

		protected virtual void WriteComments(List<string> comments, StringBuilder sb, IniScheme scheme, IniFormattingConfiguration format)
		{
			// // Void WriteComments(List`1[System.String], StringBuilder, IniScheme, IniFormattingConfiguration)
			// // Hidden C++ exception states: #wind=1
			// void IniParser::IniDataFormatter::WriteComments(
			//         IniDataFormatter *this,
			//         List_1_System_String_ *comments,
			//         StringBuilder *sb,
			//         IniScheme *scheme,
			//         IniFormattingConfiguration *format,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Object *current; // r14
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   String *CommentString; // r15
			//   String *NewLineString; // rax
			//   String *v16; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   Il2CppExceptionWrapper *v19; // [rsp+20h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_System_Object_ v20; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v21; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9192CF )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::String>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::String>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::String>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::GetEnumerator);
			//     byte_18D9192CF = 1;
			//   }
			//   if ( !comments )
			//     sub_180B536AC(this, comments);
			//   System::Collections::Generic::List<System::Object>::GetEnumerator(
			//     &v20,
			//     (List_1_System_Object_ *)comments,
			//     MethodInfo::System::Collections::Generic::List<System::String>::GetEnumerator);
			//   v21 = v20;
			//   v20._list = 0LL;
			//   *(_QWORD *)&v20._index = &v21;
			//   try
			//   {
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v21,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::String>::MoveNext) )
			//     {
			//       current = v21._current;
			//       if ( !scheme )
			//         sub_1802DC2C8(v10, v9);
			//       CommentString = IniParser::Configuration::IniScheme::get_CommentString(scheme, 0LL);
			//       if ( !format )
			//         sub_1802DC2C8(v13, v12);
			//       NewLineString = IniParser::Configuration::IniFormattingConfiguration::get_NewLineString(format, 0LL);
			//       v16 = System::String::Concat(CommentString, (String *)current, NewLineString, 0LL);
			//       if ( !sb )
			//         sub_1802DC2C8(v18, v17);
			//       System::Text::StringBuilder::Append(sb, v16, 0LL);
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v19 )
			//   {
			//     v20._list = (List_1_System_Object_ *)v19.ex;
			//     if ( v20._list )
			//       sub_18000F780(v20._list);
			//   }
			// }
			// 
		}
	}
}
