using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using IniParser.Configuration;
using IniParser.Model;
using IniParser.Parser;

namespace IniParser
{
	public class IniDataParser
	{
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000025D0 File Offset: 0x000007D0
		public virtual IniParserConfiguration Configuration
		{
			[CompilerGenerated]
			get
			{
				// // Object get_Current()
				// Object *Rewired::Utils::Classes::Data::RingBuffer_1_T_::VFEweixJrFjiYwjUzBFjtcEMiCZW<System::Object>::get_Current(
				//         RingBuffer_1_T_VFEweixJrFjiYwjUzBFjtcEMiCZW_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.current;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			protected set
			{
				// // SortedList`2[TKey,TValue]+ValueList[System.Object,System.Object](SortedList`2[System.Object,System.Object])
				// void System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
				//         SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *this,
				//         SortedList_2_System_Object_System_Object_ *dictionary,
				//         MethodInfo *method)
				// {
				//   Transform **v3; // r9
				//   MeshRenderer **v4; // [rsp+28h] [rbp+28h]
				//   Vector3 *v5; // [rsp+30h] [rbp+30h]
				//   Quaternion *v6; // [rsp+38h] [rbp+38h]
				//   Vector3 *v7; // [rsp+40h] [rbp+40h]
				//   Object *v8; // [rsp+48h] [rbp+48h]
				//   Object *v9; // [rsp+50h] [rbp+50h]
				//   Object *v10; // [rsp+58h] [rbp+58h]
				//   Object *v11; // [rsp+60h] [rbp+60h]
				//   MethodInfo *v12; // [rsp+68h] [rbp+68h]
				// 
				//   this.fields._dict = dictionary;
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper_2 *)&this.fields,
				//     (UberPostPassUtils_ColorGradingData **)dictionary,
				//     (VolumetricPipelineRT **)method,
				//     v3,
				//     v4,
				//     v5,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12);
				// }
				// 
			}
		}

		// (get) Token: 0x0600003A RID: 58 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000025D0 File Offset: 0x000007D0
		public IniScheme Scheme
		{
			[CompilerGenerated]
			get
			{
				// // Object System.Collections.IEnumerator.get_Current()
				// Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
				//         HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return (Object *)this.fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			protected set
			{
				// // Void set_getValueDelegate(Func`1[Boolean])
				// void Rewired::Utils::Classes::Utility::ValueWatcher<bool>::set_getValueDelegate(
				//         ValueWatcher_1_System_Boolean_ *this,
				//         Func_1_Boolean_ *value,
				//         MethodInfo *method)
				// {
				//   Object__Array *v3; // r9
				//   MethodInfo *v4; // [rsp+28h] [rbp+28h]
				//   MethodInfo *v5; // [rsp+30h] [rbp+30h]
				// 
				//   this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
				//   sub_1800054D0(
				//     (BSP *)&this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
				//     (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)value,
				//     (Bounds *)method,
				//     v3,
				//     v4,
				//     v5);
				// }
				// 
			}
		}

		// (get) Token: 0x0600003C RID: 60 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool HasError
		{
			get
			{
				// // Boolean get_HasError()
				// bool IniParser::IniDataParser::get_HasError(IniDataParser *this, MethodInfo *method)
				// {
				//   List_1_System_Exception_ *errorExceptions; // rax
				// 
				//   if ( !byte_18D8ED90E )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Exception>::get_Count);
				//     byte_18D8ED90E = 1;
				//   }
				//   errorExceptions = this.fields._errorExceptions;
				//   if ( !errorExceptions )
				//     sub_180B536AC(this, method);
				//   return errorExceptions.fields._size > 0;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x0600003D RID: 61 RVA: 0x000025D2 File Offset: 0x000007D2
		public ReadOnlyCollection<Exception> Errors
		{
			get
			{
				// // ReadOnlyCollection`1[System.Exception] get_Errors()
				// ReadOnlyCollection_1_System_Exception_ *IniParser::IniDataParser::get_Errors(IniDataParser *this, MethodInfo *method)
				// {
				//   List_1_System_Object_ *errorExceptions; // rcx
				// 
				//   if ( !byte_18D9192D0 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Exception>::AsReadOnly);
				//     byte_18D9192D0 = 1;
				//   }
				//   errorExceptions = (List_1_System_Object_ *)this.fields._errorExceptions;
				//   if ( !errorExceptions )
				//     sub_180B536AC(0LL, method);
				//   return (ReadOnlyCollection_1_System_Exception_ *)System::Collections::Generic::List<System::Object>::AsReadOnly(
				//                                                      errorExceptions,
				//                                                      MethodInfo::System::Collections::Generic::List<System::Exception>::AsReadOnly);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600003E RID: 62 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000025D0 File Offset: 0x000007D0
		public List<string> CurrentCommentListTemp
		{
			get
			{
				return null;
			}
			internal set
			{
				// // Void set_onAnimationCompleted(Action)
				// void UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::set_onAnimationCompleted(
				//         ValueAnimation_1_StyleValues_ *this,
				//         Action *value,
				//         MethodInfo *method)
				// {
				//   Transform **v3; // r9
				//   MeshRenderer **v4; // [rsp+28h] [rbp+28h]
				//   Vector3 *v5; // [rsp+30h] [rbp+30h]
				//   Quaternion *v6; // [rsp+38h] [rbp+38h]
				//   Vector3 *v7; // [rsp+40h] [rbp+40h]
				//   Object *v8; // [rsp+48h] [rbp+48h]
				//   Object *v9; // [rsp+50h] [rbp+50h]
				//   Object *v10; // [rsp+58h] [rbp+58h]
				//   Object *v11; // [rsp+60h] [rbp+60h]
				//   MethodInfo *v12; // [rsp+68h] [rbp+68h]
				// 
				//   this.fields._onAnimationCompleted_k__BackingField = value;
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper_2 *)&this.fields._onAnimationCompleted_k__BackingField,
				//     (UberPostPassUtils_ColorGradingData **)value,
				//     (VolumetricPipelineRT **)method,
				//     v3,
				//     v4,
				//     v5,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12);
				// }
				// 
			}
		}

		public IniDataParser()
		{
		}

		public IniData Parse(string iniString)
		{
			// // IniData Parse(String)
			// IniData *IniParser::IniDataParser::Parse(IniDataParser *this, String *iniString, MethodInfo *method)
			// {
			//   StringReader *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   TextReader *v8; // rbx
			// 
			//   if ( !byte_18D8ED90F )
			//   {
			//     sub_18003C530(&TypeInfo::System::IO::StringReader);
			//     byte_18D8ED90F = 1;
			//   }
			//   v5 = (StringReader *)sub_180004920(TypeInfo::System::IO::StringReader);
			//   v8 = (TextReader *)v5;
			//   if ( !v5 )
			//     sub_180B536AC(v7, v6);
			//   System::IO::StringReader::StringReader(v5, iniString, 0LL);
			//   return IniParser::IniDataParser::Parse(this, v8, 0LL);
			// }
			// 
			return null;
		}

		public IniData Parse(TextReader textReader)
		{
			// // IniData Parse(TextReader)
			// IniData *IniParser::IniDataParser::Parse(IniDataParser *this, TextReader *textReader, MethodInfo *method)
			// {
			//   IniParserConfiguration *Configuration_k__BackingField; // rax
			//   IniScheme *Scheme_k__BackingField; // rsi
			//   IniData *v7; // rax
			//   IniData *v8; // rdi
			//   IniDataCaseInsensitive *v10; // rax
			//   IniData *iniData; // [rsp+30h] [rbp+8h] BYREF
			// 
			//   if ( !byte_18D8ED910 )
			//   {
			//     sub_18003C530(&TypeInfo::IniParser::Model::IniDataCaseInsensitive);
			//     sub_18003C530(&TypeInfo::IniParser::IniData);
			//     byte_18D8ED910 = 1;
			//   }
			//   Configuration_k__BackingField = this.fields._Configuration_k__BackingField;
			//   if ( !Configuration_k__BackingField )
			//     goto LABEL_8;
			//   Scheme_k__BackingField = this.fields._Scheme_k__BackingField;
			//   if ( Configuration_k__BackingField.fields._CaseInsensitive_k__BackingField )
			//   {
			//     v10 = (IniDataCaseInsensitive *)sub_180004920(TypeInfo::IniParser::Model::IniDataCaseInsensitive);
			//     v8 = (IniData *)v10;
			//     if ( v10 )
			//     {
			//       IniParser::Model::IniDataCaseInsensitive::IniDataCaseInsensitive(v10, Scheme_k__BackingField, 0LL);
			//       goto LABEL_7;
			//     }
			// LABEL_8:
			//     sub_180B536AC(this, textReader);
			//   }
			//   v7 = (IniData *)sub_180004920(TypeInfo::IniParser::IniData);
			//   v8 = v7;
			//   if ( !v7 )
			//     goto LABEL_8;
			//   IniParser::IniData::IniData(v7, Scheme_k__BackingField, 0LL);
			// LABEL_7:
			//   iniData = v8;
			//   IniParser::IniDataParser::Parse(this, textReader, &iniData, 0LL);
			//   return iniData;
			// }
			// 
			return null;
		}

		public void Parse(TextReader textReader, ref IniData iniData)
		{
			// // Void Parse(TextReader, IniData ByRef)
			// void IniParser::IniDataParser::Parse(
			//         IniDataParser *this,
			//         TextReader *textReader,
			//         IniData **iniData,
			//         MethodInfo *method)
			// {
			//   IniData *Scheme_k__BackingField; // rcx
			//   IniData *v8; // rsi
			//   IniScheme *v9; // rax
			//   VolumetricPipelineRT **v10; // r8
			//   Transform **v11; // r9
			//   IniParserConfiguration *Configuration_k__BackingField; // rax
			//   List_1_System_String_ *CurrentCommentListTemp; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   IniParserConfiguration *v16; // rax
			//   List_1_System_String_ *v17; // rax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   SectionCollection *Sections_k__BackingField; // rcx
			//   int32_t Count; // eax
			//   __int64 v22; // rdx
			//   SectionCollection *v23; // rcx
			//   Section *v24; // rax
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   List_1_System_Object_ *Comments; // rsi
			//   IEnumerable_1_System_Object_ *v28; // rax
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   List_1_System_String_ *v31; // rax
			//   __int64 v32; // rdx
			//   __int64 v33; // rcx
			//   PropertyCollection *v34; // rcx
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   PropertyCollection *Global_k__BackingField; // rcx
			//   Property *lastAdded; // rcx
			//   __int64 v39; // rdx
			//   __int64 v40; // rcx
			//   MeshRenderer **v41; // [rsp+20h] [rbp-58h]
			//   __int64 *v43; // [rsp+28h] [rbp-50h]
			//   Quaternion *v44; // [rsp+30h] [rbp-48h]
			//   Vector3 *v45; // [rsp+38h] [rbp-40h]
			//   Object *v46; // [rsp+40h] [rbp-38h]
			//   Object *item; // [rsp+48h] [rbp-30h]
			//   Object *v48; // [rsp+50h] [rbp-28h]
			//   Object *v49; // [rsp+58h] [rbp-20h]
			//   MethodInfo *v50; // [rsp+60h] [rbp-18h]
			// 
			//   if ( !byte_18D8ED911 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::AddRange);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::Exception>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::get_Count);
			//     byte_18D8ED911 = 1;
			//   }
			//   LODWORD(v48) = 0;
			//   Scheme_k__BackingField = *iniData;
			//   if ( !*iniData )
			//     goto LABEL_22;
			//   IniParser::IniData::Clear(Scheme_k__BackingField, 0LL);
			//   v8 = *iniData;
			//   Scheme_k__BackingField = (IniData *)this.fields._Scheme_k__BackingField;
			//   if ( !Scheme_k__BackingField )
			//     goto LABEL_22;
			//   v9 = IniParser::Configuration::IniScheme::DeepClone((IniScheme *)Scheme_k__BackingField, 0LL);
			//   if ( !v8 )
			//     goto LABEL_22;
			//   IniParser::IniData::set_Scheme(v8, v9, 0LL);
			//   Scheme_k__BackingField = (IniData *)this.fields._errorExceptions;
			//   if ( !Scheme_k__BackingField )
			//     goto LABEL_22;
			//   sub_1823B99D0(Scheme_k__BackingField, MethodInfo::System::Collections::Generic::List<System::Exception>::Clear);
			//   Configuration_k__BackingField = this.fields._Configuration_k__BackingField;
			//   if ( !Configuration_k__BackingField )
			//     goto LABEL_22;
			//   if ( Configuration_k__BackingField.fields._ParseComments_k__BackingField )
			//   {
			//     CurrentCommentListTemp = IniParser::IniDataParser::get_CurrentCommentListTemp(this, 0LL);
			//     if ( !CurrentCommentListTemp )
			//       goto LABEL_22;
			//     sub_1823B99D0(CurrentCommentListTemp, MethodInfo::System::Collections::Generic::List<System::String>::Clear);
			//   }
			//   this.fields._currentSectionNameTemp = 0LL;
			//   sub_1800054D0(
			//     (ILFixDynamicMethodWrapper_2 *)&this.fields._currentSectionNameTemp,
			//     (UberPostPassUtils_ColorGradingData **)textReader,
			//     v10,
			//     v11,
			//     v41,
			//     (Vector3 *)iniData,
			//     v44,
			//     v45,
			//     v46,
			//     item,
			//     v48,
			//     v49,
			//     v50);
			//   Scheme_k__BackingField = (IniData *)this.fields._mBuffer;
			//   if ( !Scheme_k__BackingField )
			// LABEL_22:
			//     sub_180B536AC(Scheme_k__BackingField, textReader);
			//   IniParser::Parser::StringBuffer::Reset((StringBuffer *)Scheme_k__BackingField, textReader, 0LL);
			//   this.fields._currentLineNumber = 0;
			//   while ( 1 )
			//   {
			//     Scheme_k__BackingField = (IniData *)this.fields._mBuffer;
			//     if ( !Scheme_k__BackingField )
			//       goto LABEL_22;
			//     if ( !IniParser::Parser::StringBuffer::ReadLine((StringBuffer *)Scheme_k__BackingField, 0LL) )
			//       break;
			//     ++this.fields._currentLineNumber;
			//     IniParser::IniDataParser::ProcessLine(this, this.fields._mBuffer, *iniData, 0LL);
			//   }
			//   v16 = this.fields._Configuration_k__BackingField;
			//   if ( !v16 )
			//     sub_180B536AC(v15, v14);
			//   if ( v16.fields._ParseComments_k__BackingField )
			//   {
			//     v17 = IniParser::IniDataParser::get_CurrentCommentListTemp(this, 0LL);
			//     if ( !v17 )
			//       sub_180B536AC(v19, v18);
			//     if ( v17.fields._size > 0 )
			//     {
			//       if ( !*iniData )
			//         sub_180B536AC(v19, v18);
			//       Sections_k__BackingField = (*iniData).fields._Sections_k__BackingField;
			//       if ( !Sections_k__BackingField )
			//         sub_180B536AC(0LL, v18);
			//       Count = IniParser::Model::SectionCollection::get_Count(Sections_k__BackingField, 0LL);
			//       v22 = *v43;
			//       if ( Count <= 0 )
			//       {
			//         if ( !v22 )
			//           sub_180B536AC(v43, 0LL);
			//         v34 = *(PropertyCollection **)(v22 + 24);
			//         if ( !v34 )
			//           sub_180B536AC(0LL, v22);
			//         if ( IniParser::Model::PropertyCollection::get_Count(v34, 0LL) <= 0 )
			//           goto LABEL_31;
			//         if ( !*iniData )
			//           sub_180B536AC(v36, v35);
			//         Global_k__BackingField = (*iniData).fields._Global_k__BackingField;
			//         if ( !Global_k__BackingField )
			//           sub_180B536AC(0LL, v35);
			//         lastAdded = Global_k__BackingField.fields._lastAdded;
			//         if ( !lastAdded )
			//           sub_180B536AC(0LL, v35);
			//         Comments = (List_1_System_Object_ *)IniParser::Model::Property::get_Comments(lastAdded, 0LL);
			//         v28 = (IEnumerable_1_System_Object_ *)IniParser::IniDataParser::get_CurrentCommentListTemp(this, 0LL);
			//         if ( !Comments )
			//           sub_180B536AC(v40, v39);
			//       }
			//       else
			//       {
			//         if ( !v22 )
			//           sub_180B536AC(v43, 0LL);
			//         v23 = *(SectionCollection **)(v22 + 32);
			//         if ( !v23 )
			//           sub_180B536AC(0LL, v22);
			//         v24 = IniParser::Model::SectionCollection::FindByName(v23, this.fields._currentSectionNameTemp, 0LL);
			//         if ( !v24 )
			//           sub_180B536AC(v26, v25);
			//         Comments = (List_1_System_Object_ *)IniParser::Model::Section::get_Comments(v24, 0LL);
			//         v28 = (IEnumerable_1_System_Object_ *)IniParser::IniDataParser::get_CurrentCommentListTemp(this, 0LL);
			//         if ( !Comments )
			//           sub_180B536AC(v30, v29);
			//       }
			//       System::Collections::Generic::List<System::Object>::AddRange(
			//         Comments,
			//         v28,
			//         MethodInfo::System::Collections::Generic::List<System::String>::AddRange);
			// LABEL_31:
			//       v31 = IniParser::IniDataParser::get_CurrentCommentListTemp(this, 0LL);
			//       if ( !v31 )
			//         sub_180B536AC(v33, v32);
			//       sub_1823B99D0(v31, MethodInfo::System::Collections::Generic::List<System::String>::Clear);
			//     }
			//   }
			//   if ( IniParser::IniDataParser::get_HasError(this, 0LL) )
			//   {
			//     Scheme_k__BackingField = *iniData;
			//     if ( *iniData )
			//     {
			//       IniParser::IniData::Clear(Scheme_k__BackingField, 0LL);
			//       return;
			//     }
			//     goto LABEL_22;
			//   }
			// }
			// 
		}

		protected virtual void ProcessLine(StringBuffer currentLine, IniData iniData)
		{
			// // Void ProcessLine(StringBuffer, IniData)
			// void IniParser::IniDataParser::ProcessLine(
			//         IniDataParser *this,
			//         StringBuffer *currentLine,
			//         IniData *iniData,
			//         MethodInfo *method)
			// {
			//   IniDataParser *v6; // rdi
			//   String *v7; // rax
			//   String *v8; // rsi
			//   uint32_t currentLineNumber; // edi
			//   StringBuffer *v10; // rax
			//   String *v11; // rbp
			//   __int64 v12; // rax
			//   ParsingException *v13; // rax
			//   ParsingException *v14; // rbx
			//   __int64 v15; // rax
			// 
			//   v6 = this;
			//   if ( !byte_18D8ED912 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Debug);
			//     sub_18003C530(&off_18C95AA28);
			//     byte_18D8ED912 = 1;
			//   }
			//   if ( !currentLine )
			//     goto LABEL_10;
			//   if ( !currentLine.fields._bufferIndexes._size
			//     || IniParser::Parser::StringBuffer::get_IsWhitespace(currentLine, 0LL)
			//     || IniParser::IniDataParser::ProcessComment(v6, currentLine, 0LL)
			//     || IniParser::IniDataParser::ProcessSection(v6, currentLine, iniData, 0LL)
			//     || IniParser::IniDataParser::ProcessProperty(v6, currentLine, iniData, 0LL) )
			//   {
			//     return;
			//   }
			//   v7 = System::String::Format((String *)"Couldn't parse text: '{0}'.", (Object *)currentLine, 0LL);
			//   this = (IniDataParser *)v6.fields._Configuration_k__BackingField;
			//   v8 = v7;
			//   if ( !this )
			// LABEL_10:
			//     sub_180B536AC(this, currentLine);
			//   if ( !BYTE2(this.fields._currentLineNumber) )
			//   {
			//     currentLineNumber = v6.fields._currentLineNumber;
			//     v10 = IniParser::Parser::StringBuffer::DiscardChanges(currentLine, 0LL);
			//     if ( v10 )
			//     {
			//       v11 = (String *)sub_18003F3E0(3LL, v10);
			//       v12 = sub_18003C530(&TypeInfo::IniParser::Exceptions::ParsingException);
			//       v13 = (ParsingException *)sub_180004920(v12);
			//       v14 = v13;
			//       if ( v13 )
			//       {
			//         IniParser::Exceptions::ParsingException::ParsingException(v13, v8, currentLineNumber, v11, 0LL);
			//         v15 = sub_18003C530(&MethodInfo::IniParser::IniDataParser::ProcessLine);
			//         sub_18000F7C0(v14, v15);
			//       }
			//     }
			//     goto LABEL_10;
			//   }
			//   if ( !TypeInfo::UnityEngine::Debug._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Debug, currentLine);
			//   UnityEngine::Debug::LogCritical((Object *)v8, 0LL);
			// }
			// 
		}

		protected virtual bool ProcessComment(StringBuffer currentLine)
		{
			// // Boolean ProcessComment(StringBuffer)
			// bool IniParser::IniDataParser::ProcessComment(IniDataParser *this, StringBuffer *currentLine, MethodInfo *method)
			// {
			//   IniDataParser *v4; // rsi
			//   StringBuffer *v5; // rax
			//   StringBuffer *v6; // rdi
			//   String *CommentString; // rax
			//   bool result; // al
			//   IniParserConfiguration *Configuration_k__BackingField; // rax
			//   String *v10; // rax
			//   int32_t start; // eax
			//   int32_t v12; // ebx
			//   String *v13; // rax
			//   int32_t stringLength; // r14d
			//   int32_t size; // ebp
			//   String *v16; // rax
			//   StringBuffer_Range v17; // rax
			//   StringBuffer *v18; // rbx
			//   IniParserConfiguration *v19; // rax
			//   List_1_System_Object_ *CurrentCommentListTemp; // rdi
			//   Object *v21; // rax
			// 
			//   v4 = this;
			//   if ( !byte_18D8ED913 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::Add);
			//     byte_18D8ED913 = 1;
			//   }
			//   if ( !currentLine )
			//     goto LABEL_21;
			//   v5 = IniParser::Parser::StringBuffer::SwallowCopy(currentLine, 0LL);
			//   v6 = v5;
			//   if ( !v5 )
			//     goto LABEL_21;
			//   IniParser::Parser::StringBuffer::TrimStart(v5, 0LL);
			//   this = (IniDataParser *)v4.fields._Scheme_k__BackingField;
			//   if ( !this )
			//     goto LABEL_21;
			//   CommentString = IniParser::Configuration::IniScheme::get_CommentString((IniScheme *)this, 0LL);
			//   result = IniParser::Parser::StringBuffer::StartsWith(v6, CommentString, 0LL);
			//   if ( !result )
			//     return result;
			//   Configuration_k__BackingField = v4.fields._Configuration_k__BackingField;
			//   if ( !Configuration_k__BackingField )
			//     goto LABEL_21;
			//   if ( Configuration_k__BackingField.fields._ParseComments_k__BackingField )
			//   {
			//     IniParser::Parser::StringBuffer::TrimEnd(v6, 0LL);
			//     this = (IniDataParser *)v4.fields._Scheme_k__BackingField;
			//     if ( this )
			//     {
			//       v10 = IniParser::Configuration::IniScheme::get_CommentString((IniScheme *)this, 0LL);
			//       start = IniParser::Parser::StringBuffer::FindSubstring(v6, v10, 0, 0LL)._start;
			//       this = (IniDataParser *)v4.fields._Scheme_k__BackingField;
			//       v12 = start;
			//       if ( this )
			//       {
			//         v13 = IniParser::Configuration::IniScheme::get_CommentString((IniScheme *)this, 0LL);
			//         if ( v13 )
			//         {
			//           this = (IniDataParser *)v4.fields._Scheme_k__BackingField;
			//           stringLength = v13.fields._stringLength;
			//           size = v6.fields._bufferIndexes._size;
			//           if ( this )
			//           {
			//             v16 = IniParser::Configuration::IniScheme::get_CommentString((IniScheme *)this, 0LL);
			//             if ( v16 )
			//             {
			//               v17 = IniParser::Parser::StringBuffer::Range::FromIndexWithSize(
			//                       stringLength + v12,
			//                       size - v16.fields._stringLength,
			//                       0LL);
			//               v18 = IniParser::Parser::StringBuffer::Substring(v6, v17, 0LL);
			//               v19 = v4.fields._Configuration_k__BackingField;
			//               if ( v19 )
			//               {
			//                 if ( v19.fields._TrimComments_k__BackingField )
			//                 {
			//                   if ( !v18 )
			//                     goto LABEL_21;
			//                   IniParser::Parser::StringBuffer::Trim(v18, 0LL);
			//                   CurrentCommentListTemp = (List_1_System_Object_ *)IniParser::IniDataParser::get_CurrentCommentListTemp(
			//                                                                       v4,
			//                                                                       0LL);
			//                 }
			//                 else
			//                 {
			//                   CurrentCommentListTemp = (List_1_System_Object_ *)IniParser::IniDataParser::get_CurrentCommentListTemp(
			//                                                                       v4,
			//                                                                       0LL);
			//                   if ( !v18 )
			//                     goto LABEL_21;
			//                 }
			//                 v21 = (Object *)sub_18003F3E0(3LL, v18);
			//                 if ( CurrentCommentListTemp )
			//                 {
			//                   sub_1822AD140(CurrentCommentListTemp, v21);
			//                   return 1;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_21:
			//     sub_180B536AC(this, currentLine);
			//   }
			//   return 1;
			// }
			// 
			return default(bool);
		}

		protected virtual bool ProcessSection(StringBuffer currentLine, IniData iniData)
		{
			return default(bool);
		}

		protected virtual bool ProcessProperty(StringBuffer currentLine, IniData iniData)
		{
			// // Boolean ProcessProperty(StringBuffer, IniData)
			// bool IniParser::IniDataParser::ProcessProperty(
			//         IniDataParser *this,
			//         StringBuffer *currentLine,
			//         IniData *iniData,
			//         MethodInfo *method)
			// {
			//   IniDataParser *v6; // rsi
			//   String *PropertyAssigmentString; // rax
			//   StringBuffer_Range Substring; // rax
			//   StringBuffer_Range v9; // rdx
			//   int v10; // ecx
			//   int v11; // eax
			//   int v12; // r8d
			//   StringBuffer_Range v13; // rbx
			//   StringBuffer *v14; // rdi
			//   StringBuffer *v15; // rax
			//   StringBuffer *v16; // rbx
			//   String *currentSectionNameTemp; // rax
			//   Section *v18; // rbp
			//   String *v19; // rdi
			//   String *v20; // rax
			//   String *sectionName; // rcx
			//   PropertyCollection *Properties_k__BackingField; // r9
			//   IniParserConfiguration *Configuration_k__BackingField; // rax
			//   Object__Array *v25; // rax
			//   String *v26; // rax
			//   struct Debug_1__Class *v27; // rcx
			//   String *v28; // rbx
			//   Object__Array *v29; // rax
			//   String *v30; // rax
			//   uint32_t currentLineNumber; // esi
			//   StringBuffer *v32; // rax
			//   String *v33; // rbp
			//   __int64 v34; // rax
			//   ParsingException *v35; // rax
			//   ParsingException *v36; // rdi
			//   __int64 v37; // rax
			//   StringBuffer_Range range; // [rsp+68h] [rbp+10h]
			// 
			//   v6 = this;
			//   if ( !byte_18D8ED915 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::Empty<System::Object>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Debug);
			//     sub_18003C530(&off_18C95A208);
			//     sub_18003C530(&off_18C95A230);
			//     sub_18003C530(&off_18C95A220);
			//     byte_18D8ED915 = 1;
			//   }
			//   if ( !currentLine )
			//     goto LABEL_31;
			//   if ( currentLine.fields._bufferIndexes._size > 0 )
			//   {
			//     this = (IniDataParser *)v6.fields._Scheme_k__BackingField;
			//     if ( !this )
			//       goto LABEL_31;
			//     PropertyAssigmentString = IniParser::Configuration::IniScheme::get_PropertyAssigmentString((IniScheme *)this, 0LL);
			//     Substring = IniParser::Parser::StringBuffer::FindSubstring(currentLine, PropertyAssigmentString, 0, 0LL);
			//     if ( Substring._size )
			//     {
			//       if ( Substring._start - 1 < 0 )
			//       {
			//         v9 = 0LL;
			//       }
			//       else
			//       {
			//         range._start = 0;
			//         range._size = Substring._start;
			//         v9 = range;
			//       }
			//       if ( Substring._size <= 0 )
			//         v10 = 1;
			//       else
			//         v10 = Substring._start + Substring._size;
			//       if ( Substring._size <= 0 )
			//         v11 = 0;
			//       else
			//         v11 = Substring._size + Substring._start - 1;
			//       v12 = currentLine.fields._bufferIndexes._size - v11 - 1;
			//       if ( v10 < 0 || v12 <= 0 )
			//         v13 = 0LL;
			//       else
			//         v13 = (StringBuffer_Range)__PAIR64__(v12, v10);
			//       v14 = IniParser::Parser::StringBuffer::Substring(currentLine, v9, 0LL);
			//       v15 = IniParser::Parser::StringBuffer::Substring(currentLine, v13, 0LL);
			//       this = (IniDataParser *)v6.fields._Configuration_k__BackingField;
			//       v16 = v15;
			//       if ( !this || !v14 )
			//         goto LABEL_31;
			//       if ( HIBYTE(this.fields._currentLineNumber) )
			//       {
			//         IniParser::Parser::StringBuffer::TrimEnd(v14, 0LL);
			//         IniParser::Parser::StringBuffer::TrimStart(v14, 0LL);
			//         if ( !v16 )
			//           goto LABEL_31;
			//         IniParser::Parser::StringBuffer::TrimEnd(v16, 0LL);
			//         IniParser::Parser::StringBuffer::TrimStart(v16, 0LL);
			//       }
			//       if ( v14.fields._bufferIndexes._size )
			//       {
			//         currentSectionNameTemp = v6.fields._currentSectionNameTemp;
			//         if ( currentSectionNameTemp && currentSectionNameTemp.fields._stringLength )
			//         {
			//           if ( iniData )
			//           {
			//             this = (IniDataParser *)iniData.fields._Sections_k__BackingField;
			//             if ( this )
			//             {
			//               v18 = IniParser::Model::SectionCollection::FindByName(
			//                       (SectionCollection *)this,
			//                       v6.fields._currentSectionNameTemp,
			//                       0LL);
			//               v19 = (String *)sub_18003F3E0(3LL, v14);
			//               if ( v16 )
			//               {
			//                 v20 = (String *)sub_18003F3E0(3LL, v16);
			//                 if ( v18 )
			//                 {
			//                   sectionName = v6.fields._currentSectionNameTemp;
			//                   Properties_k__BackingField = v18.fields._Properties_k__BackingField;
			// LABEL_29:
			//                   IniParser::IniDataParser::AddKeyToKeyValueCollection(
			//                     v6,
			//                     v19,
			//                     v20,
			//                     Properties_k__BackingField,
			//                     sectionName,
			//                     0LL);
			//                   return 1;
			//                 }
			//               }
			//             }
			//           }
			//           goto LABEL_31;
			//         }
			//         Configuration_k__BackingField = v6.fields._Configuration_k__BackingField;
			//         if ( !Configuration_k__BackingField )
			//           goto LABEL_31;
			//         if ( Configuration_k__BackingField.fields._AllowKeysWithoutSection_k__BackingField )
			//         {
			//           v19 = (String *)sub_18003F3E0(3LL, v14);
			//           if ( v16 )
			//           {
			//             v20 = (String *)sub_18003F3E0(3LL, v16);
			//             if ( iniData )
			//             {
			//               sectionName = (String *)"global";
			//               Properties_k__BackingField = iniData.fields._Global_k__BackingField;
			//               goto LABEL_29;
			//             }
			//           }
			// LABEL_31:
			//           sub_180B536AC(this, currentLine);
			//         }
			//         v25 = (Object__Array *)sub_182D4A060(MethodInfo::System::Array::Empty<System::Object>);
			//         v26 = System::String::Format((String *)"Properties must be contained inside a section.", v25, 0LL);
			//         v27 = TypeInfo::UnityEngine::Debug;
			//         v28 = v26;
			//         if ( TypeInfo::UnityEngine::Debug._1.cctor_finished_or_no_cctor )
			//           goto LABEL_50;
			//       }
			//       else
			//       {
			//         v29 = (Object__Array *)sub_182D4A060(MethodInfo::System::Array::Empty<System::Object>);
			//         v30 = System::String::Format((String *)"Found property without key.", v29, 0LL);
			//         this = (IniDataParser *)v6.fields._Configuration_k__BackingField;
			//         v28 = v30;
			//         if ( !this )
			//           goto LABEL_31;
			//         if ( !BYTE2(this.fields._currentLineNumber) )
			//         {
			//           currentLineNumber = v6.fields._currentLineNumber;
			//           v32 = IniParser::Parser::StringBuffer::DiscardChanges(currentLine, 0LL);
			//           if ( v32 )
			//           {
			//             v33 = (String *)sub_18003F3E0(3LL, v32);
			//             v34 = sub_18003C530(&TypeInfo::IniParser::Exceptions::ParsingException);
			//             v35 = (ParsingException *)sub_180004920(v34);
			//             v36 = v35;
			//             if ( v35 )
			//             {
			//               IniParser::Exceptions::ParsingException::ParsingException(v35, v28, currentLineNumber, v33, 0LL);
			//               v37 = sub_18003C530(&MethodInfo::IniParser::IniDataParser::ProcessProperty);
			//               sub_18000F7C0(v36, v37);
			//             }
			//           }
			//           goto LABEL_31;
			//         }
			//         v27 = TypeInfo::UnityEngine::Debug;
			//         if ( TypeInfo::UnityEngine::Debug._1.cctor_finished_or_no_cctor )
			//           goto LABEL_50;
			//       }
			//       il2cpp_runtime_class_init_0(v27, currentLine);
			// LABEL_50:
			//       UnityEngine::Debug::LogCritical((Object *)v28, 0LL);
			//     }
			//   }
			//   return 0;
			// }
			// 
			return default(bool);
		}

		private void HandleDuplicatedKeyInCollection(string key, string value, PropertyCollection keyDataCollection, string sectionName)
		{
			// // Void HandleDuplicatedKeyInCollection(String, String, PropertyCollection, String)
			// void IniParser::IniDataParser::HandleDuplicatedKeyInCollection(
			//         IniDataParser *this,
			//         String *key,
			//         String *value,
			//         PropertyCollection *keyDataCollection,
			//         String *sectionName,
			//         MethodInfo *method)
			// {
			//   Object *v8; // rdi
			//   IniParserConfiguration *Configuration_k__BackingField; // rcx
			//   int32_t DuplicatePropertiesBehaviour_k__BackingField; // ecx
			//   int v12; // ecx
			//   String *Item; // rax
			//   String *v14; // r8
			//   Object *v15; // rbx
			// 
			//   v8 = (Object *)key;
			//   if ( !byte_18D9192D1 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Debug);
			//     sub_18003C530(&off_18D584E30);
			//     byte_18D9192D1 = 1;
			//   }
			//   Configuration_k__BackingField = this.fields._Configuration_k__BackingField;
			//   if ( !Configuration_k__BackingField )
			//     goto LABEL_16;
			//   DuplicatePropertiesBehaviour_k__BackingField = Configuration_k__BackingField.fields._DuplicatePropertiesBehaviour_k__BackingField;
			//   if ( !DuplicatePropertiesBehaviour_k__BackingField )
			//   {
			//     v15 = (Object *)System::String::Format(
			//                       (String *)"Duplicated key '{0}' found in section '{1}",
			//                       v8,
			//                       (Object *)sectionName,
			//                       0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Debug);
			//     UnityEngine::Debug::LogCritical(v15, 0LL);
			//     return;
			//   }
			//   v12 = DuplicatePropertiesBehaviour_k__BackingField - 1;
			//   if ( v12 )
			//   {
			//     Configuration_k__BackingField = (IniParserConfiguration *)(unsigned int)(v12 - 1);
			//     if ( (_DWORD)Configuration_k__BackingField )
			//     {
			//       if ( (_DWORD)Configuration_k__BackingField != 1 )
			//         return;
			//       if ( keyDataCollection )
			//       {
			//         Item = IniParser::Model::PropertyCollection::get_Item(keyDataCollection, (String *)v8, 0LL);
			//         key = (String *)this.fields._Configuration_k__BackingField;
			//         if ( key )
			//         {
			//           v14 = System::String::Concat(Item, (String *)key[1].klass, value, 0LL);
			// LABEL_11:
			//           IniParser::Model::PropertyCollection::set_Item(keyDataCollection, (String *)v8, v14, 0LL);
			//           return;
			//         }
			//       }
			//     }
			//     else if ( keyDataCollection )
			//     {
			//       v14 = value;
			//       goto LABEL_11;
			//     }
			// LABEL_16:
			//     sub_180B536AC(Configuration_k__BackingField, key);
			//   }
			// }
			// 
		}

		private void AddKeyToKeyValueCollection(string key, string value, PropertyCollection keyDataCollection, string sectionName)
		{
			// // Void AddKeyToKeyValueCollection(String, String, PropertyCollection, String)
			// void IniParser::IniDataParser::AddKeyToKeyValueCollection(
			//         IniDataParser *this,
			//         String *key,
			//         String *value,
			//         PropertyCollection *keyDataCollection,
			//         String *sectionName,
			//         MethodInfo *method)
			// {
			//   IniParserConfiguration *Configuration_k__BackingField; // rax
			//   Property *v11; // rbx
			//   List_1_System_String_ *CurrentCommentListTemp; // rax
			//   List_1_System_String_ *v13; // rax
			// 
			//   if ( !byte_18D8ED916 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::Clear);
			//     byte_18D8ED916 = 1;
			//   }
			//   if ( !keyDataCollection )
			//     goto LABEL_12;
			//   if ( IniParser::Model::PropertyCollection::Contains(keyDataCollection, key, 0LL) )
			//     IniParser::IniDataParser::HandleDuplicatedKeyInCollection(this, key, value, keyDataCollection, sectionName, 0LL);
			//   else
			//     IniParser::Model::PropertyCollection::Add(keyDataCollection, key, value, 0LL);
			//   Configuration_k__BackingField = this.fields._Configuration_k__BackingField;
			//   if ( !Configuration_k__BackingField )
			//     goto LABEL_12;
			//   if ( !Configuration_k__BackingField.fields._ParseComments_k__BackingField )
			//     return;
			//   v11 = IniParser::Model::PropertyCollection::FindByKey(keyDataCollection, key, 0LL);
			//   CurrentCommentListTemp = IniParser::IniDataParser::get_CurrentCommentListTemp(this, 0LL);
			//   if ( !v11
			//     || (IniParser::Model::Property::set_Comments(v11, CurrentCommentListTemp, 0LL),
			//         (v13 = IniParser::IniDataParser::get_CurrentCommentListTemp(this, 0LL)) == 0LL) )
			//   {
			// LABEL_12:
			//     sub_180B536AC(this, key);
			//   }
			//   sub_1823B99D0(v13, MethodInfo::System::Collections::Generic::List<System::String>::Clear);
			// }
			// 
		}

		private uint _currentLineNumber;

		private readonly List<Exception> _errorExceptions;

		private List<string> _currentCommentListTemp;

		private string _currentSectionNameTemp;

		private readonly StringBuffer _mBuffer;
	}
}
