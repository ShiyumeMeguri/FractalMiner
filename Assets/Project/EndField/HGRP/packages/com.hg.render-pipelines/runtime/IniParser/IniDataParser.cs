using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using IniParser.Configuration;
using IniParser.Model;
using IniParser.Parser;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IniParser
{
	public class IniDataParser // TypeDefIndex: 37373
	{
		// Fields
		private uint _currentLineNumber; // 0x20
		private readonly List<Exception> _errorExceptions; // 0x28
		private List<string> _currentCommentListTemp; // 0x30
		private string _currentSectionNameTemp; // 0x38
		private readonly StringBuffer _mBuffer; // 0x40
	
		// Properties
		public virtual IniParserConfiguration Configuration { get; protected set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
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
		
		public IniScheme Scheme { get; protected set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		// Object System.Collections.IEnumerator.get_Current()
		Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
		        HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
		        MethodInfo *method)
		{
		  return (Object *)this->fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
		}
		

		// Void set_getValueDelegate(Func`1[Boolean])
		void Rewired::Utils::Classes::Utility::ValueWatcher<bool>::set_getValueDelegate(
		        ValueWatcher_1_System_Boolean_ *this,
		        Func_1_Boolean_ *value,
		        MethodInfo *method)
		{
		  VolumetricPipelineRT **v3; // r9
		  VolumetricPipelineRT **v4; // [rsp+28h] [rbp+28h]
		  MethodInfo *v5; // [rsp+30h] [rbp+30h]
		
		  this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
		  sub_18002D1B0(
		    (ILFixDynamicMethodWrapper_2 *)&this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
		    (UberPostPassUtils_ColorGradingData **)value,
		    (VolumetricPipelineRT **)method,
		    v3,
		    v4,
		    v5);
		}
		
		public bool HasError { get => default; } // 0x00000001835A7AB0-0x00000001835A7AE0 
		// Boolean get_HasError()
		bool IniParser::IniDataParser::get_HasError(IniDataParser *this, MethodInfo *method)
		{
		  List_1_System_Exception_ *errorExceptions; // rax
		
		  errorExceptions = this->fields._errorExceptions;
		  if ( !errorExceptions )
		    sub_1800D8260(this, method);
		  return errorExceptions->fields._size > 0;
		}
		
		public ReadOnlyCollection<Exception> Errors { get => default; } // 0x0000000189B3123C-0x0000000189B31260 
		// ReadOnlyCollection`1[System.Exception] get_Errors()
		ReadOnlyCollection_1_System_Exception_ *IniParser::IniDataParser::get_Errors(IniDataParser *this, MethodInfo *method)
		{
		  List_1_System_Object_ *errorExceptions; // rcx
		
		  errorExceptions = (List_1_System_Object_ *)this->fields._errorExceptions;
		  if ( !errorExceptions )
		    sub_1800D8260(0LL, method);
		  return (ReadOnlyCollection_1_System_Exception_ *)System::Collections::Generic::List<System::Object>::AsReadOnly(
		                                                     errorExceptions,
		                                                     MethodInfo::System::Collections::Generic::List<System::Exception>::AsReadOnly);
		}
		
		public List<string> CurrentCommentListTemp { get => default; internal set {} } // 0x00000001835A9E60-0x00000001835A9EC0 0x0000000185396200-0x0000000185396210
		// Void set_onAnimationCompleted(Action)
		void UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::set_onAnimationCompleted(
		        ValueAnimation_1_StyleValues_ *this,
		        Action *value,
		        MethodInfo *method)
		{
		  VolumetricPipelineRT **v3; // r9
		  VolumetricPipelineRT **v4; // [rsp+28h] [rbp+28h]
		  MethodInfo *v5; // [rsp+30h] [rbp+30h]
		
		  this->fields._onAnimationCompleted_k__BackingField = value;
		  sub_18002D1B0(
		    (ILFixDynamicMethodWrapper_2 *)&this->fields._onAnimationCompleted_k__BackingField,
		    (UberPostPassUtils_ColorGradingData **)value,
		    (VolumetricPipelineRT **)method,
		    v3,
		    v4,
		    v5);
		}
		
	
		// Constructors
		public IniDataParser() {} // 0x00000001836899D0-0x0000000183689AB0
	
		// Methods
		public IniData Parse(string iniString) => default; // 0x00000001835A77C0-0x00000001835A7820
		// IniData Parse(String)
		IniData *IniParser::IniDataParser::Parse(IniDataParser *this, String *iniString, MethodInfo *method)
		{
		  StringReader *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  TextReader *v8; // rbx
		
		  v5 = (StringReader *)sub_1800368D0(TypeInfo::System::IO::StringReader);
		  v8 = (TextReader *)v5;
		  if ( !v5 )
		    sub_1800D8260(v7, v6);
		  System::IO::StringReader::StringReader(v5, iniString, 0LL);
		  return IniParser::IniDataParser::Parse(this, v8, 0LL);
		}
		
		public IniData Parse(TextReader textReader) => default; // 0x00000001835A7820-0x00000001835A78B0
		// IniData Parse(TextReader)
		IniData *IniParser::IniDataParser::Parse(IniDataParser *this, TextReader *textReader, MethodInfo *method)
		{
		  IniParserConfiguration *Configuration_k__BackingField; // rax
		  IniScheme *Scheme_k__BackingField; // rsi
		  IniData *v7; // rax
		  IniData *v8; // rdi
		  IniDataCaseInsensitive *v10; // rax
		  IniData *iniData; // [rsp+30h] [rbp+8h] BYREF
		
		  Configuration_k__BackingField = this->fields._Configuration_k__BackingField;
		  if ( !Configuration_k__BackingField )
		    goto LABEL_6;
		  Scheme_k__BackingField = this->fields._Scheme_k__BackingField;
		  if ( Configuration_k__BackingField->fields._CaseInsensitive_k__BackingField )
		  {
		    v10 = (IniDataCaseInsensitive *)sub_1800368D0(TypeInfo::IniParser::Model::IniDataCaseInsensitive);
		    v8 = (IniData *)v10;
		    if ( v10 )
		    {
		      IniParser::Model::IniDataCaseInsensitive::IniDataCaseInsensitive(v10, Scheme_k__BackingField, 0LL);
		      goto LABEL_5;
		    }
		LABEL_6:
		    sub_1800D8260(this, textReader);
		  }
		  v7 = (IniData *)sub_1800368D0(TypeInfo::IniParser::IniData);
		  v8 = v7;
		  if ( !v7 )
		    goto LABEL_6;
		  IniParser::IniData::IniData(v7, Scheme_k__BackingField, 0LL);
		LABEL_5:
		  iniData = v8;
		  IniParser::IniDataParser::Parse(this, textReader, &iniData, 0LL);
		  return iniData;
		}
		
		public void Parse(TextReader textReader, ref IniData iniData) {} // 0x00000001835A9150-0x00000001835A9390
		// Void Parse(TextReader, IniData ByRef)
		void IniParser::IniDataParser::Parse(
		        IniDataParser *this,
		        TextReader *textReader,
		        IniData **iniData,
		        MethodInfo *method)
		{
		  IniData *Scheme_k__BackingField; // rcx
		  IniData *v8; // rsi
		  IniScheme *v9; // rax
		  VolumetricPipelineRT **v10; // r8
		  VolumetricPipelineRT **v11; // r9
		  IniParserConfiguration *Configuration_k__BackingField; // rax
		  List_1_System_String_ *CurrentCommentListTemp; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  IniParserConfiguration *v16; // rax
		  List_1_System_String_ *v17; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  SectionCollection *Sections_k__BackingField; // rcx
		  int32_t Count; // eax
		  __int64 v22; // rdx
		  SectionCollection *v23; // rcx
		  Section *v24; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  List_1_System_Object_ *Comments; // rsi
		  IEnumerable_1_System_Object_ *v28; // rax
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  List_1_System_String_ *v31; // rax
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  PropertyCollection *v34; // rcx
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  PropertyCollection *Global_k__BackingField; // rcx
		  Property *lastAdded; // rcx
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  VolumetricPipelineRT **v41; // [rsp+20h] [rbp-58h]
		  __int64 *v43; // [rsp+28h] [rbp-50h]
		
		  Scheme_k__BackingField = *iniData;
		  if ( !*iniData )
		    goto LABEL_14;
		  IniParser::IniData::Clear(Scheme_k__BackingField, 0LL);
		  v8 = *iniData;
		  Scheme_k__BackingField = (IniData *)this->fields._Scheme_k__BackingField;
		  if ( !Scheme_k__BackingField )
		    goto LABEL_14;
		  v9 = IniParser::Configuration::IniScheme::DeepClone((IniScheme *)Scheme_k__BackingField, 0LL);
		  if ( !v8 )
		    goto LABEL_14;
		  IniParser::IniData::set_Scheme(v8, v9, 0LL);
		  Scheme_k__BackingField = (IniData *)this->fields._errorExceptions;
		  if ( !Scheme_k__BackingField )
		    goto LABEL_14;
		  sub_183127A90(Scheme_k__BackingField, MethodInfo::System::Collections::Generic::List<System::Exception>::Clear);
		  Configuration_k__BackingField = this->fields._Configuration_k__BackingField;
		  if ( !Configuration_k__BackingField )
		    goto LABEL_14;
		  if ( Configuration_k__BackingField->fields._ParseComments_k__BackingField )
		  {
		    CurrentCommentListTemp = IniParser::IniDataParser::get_CurrentCommentListTemp(this, 0LL);
		    if ( !CurrentCommentListTemp )
		      goto LABEL_14;
		    sub_183127A90(CurrentCommentListTemp, MethodInfo::System::Collections::Generic::List<System::String>::Clear);
		  }
		  this->fields._currentSectionNameTemp = 0LL;
		  sub_18002D1B0(
		    (ILFixDynamicMethodWrapper_2 *)&this->fields._currentSectionNameTemp,
		    (UberPostPassUtils_ColorGradingData **)textReader,
		    v10,
		    v11,
		    v41,
		    (MethodInfo *)iniData);
		  Scheme_k__BackingField = (IniData *)this->fields._mBuffer;
		  if ( !Scheme_k__BackingField )
		LABEL_14:
		    sub_1800D8260(Scheme_k__BackingField, textReader);
		  IniParser::Parser::StringBuffer::Reset((StringBuffer *)Scheme_k__BackingField, textReader, 0LL);
		  this->fields._currentLineNumber = 0;
		  while ( 1 )
		  {
		    Scheme_k__BackingField = (IniData *)this->fields._mBuffer;
		    if ( !Scheme_k__BackingField )
		      goto LABEL_14;
		    if ( !IniParser::Parser::StringBuffer::ReadLine((StringBuffer *)Scheme_k__BackingField, 0LL) )
		      break;
		    ++this->fields._currentLineNumber;
		    IniParser::IniDataParser::ProcessLine(this, this->fields._mBuffer, *iniData, 0LL);
		  }
		  v16 = this->fields._Configuration_k__BackingField;
		  if ( !v16 )
		    sub_1800D8260(v15, v14);
		  if ( v16->fields._ParseComments_k__BackingField )
		  {
		    v17 = IniParser::IniDataParser::get_CurrentCommentListTemp(this, 0LL);
		    if ( !v17 )
		      sub_1800D8260(v19, v18);
		    if ( v17->fields._size > 0 )
		    {
		      if ( !*iniData )
		        sub_1800D8260(v19, v18);
		      Sections_k__BackingField = (*iniData)->fields._Sections_k__BackingField;
		      if ( !Sections_k__BackingField )
		        sub_1800D8260(0LL, v18);
		      Count = IniParser::Model::SectionCollection::get_Count(Sections_k__BackingField, 0LL);
		      v22 = *v43;
		      if ( Count <= 0 )
		      {
		        if ( !v22 )
		          sub_1800D8260(v43, 0LL);
		        v34 = *(PropertyCollection **)(v22 + 24);
		        if ( !v34 )
		          sub_1800D8260(0LL, v22);
		        if ( IniParser::Model::PropertyCollection::get_Count(v34, 0LL) <= 0 )
		          goto LABEL_29;
		        if ( !*iniData )
		          sub_1800D8260(v36, v35);
		        Global_k__BackingField = (*iniData)->fields._Global_k__BackingField;
		        if ( !Global_k__BackingField )
		          sub_1800D8260(0LL, v35);
		        lastAdded = Global_k__BackingField->fields._lastAdded;
		        if ( !lastAdded )
		          sub_1800D8260(0LL, v35);
		        Comments = (List_1_System_Object_ *)IniParser::Model::Property::get_Comments(lastAdded, 0LL);
		        v28 = (IEnumerable_1_System_Object_ *)IniParser::IniDataParser::get_CurrentCommentListTemp(this, 0LL);
		        if ( !Comments )
		          sub_1800D8260(v40, v39);
		      }
		      else
		      {
		        if ( !v22 )
		          sub_1800D8260(v43, 0LL);
		        v23 = *(SectionCollection **)(v22 + 32);
		        if ( !v23 )
		          sub_1800D8260(0LL, v22);
		        v24 = IniParser::Model::SectionCollection::FindByName(v23, this->fields._currentSectionNameTemp, 0LL);
		        if ( !v24 )
		          sub_1800D8260(v26, v25);
		        Comments = (List_1_System_Object_ *)IniParser::Model::Section::get_Comments(v24, 0LL);
		        v28 = (IEnumerable_1_System_Object_ *)IniParser::IniDataParser::get_CurrentCommentListTemp(this, 0LL);
		        if ( !Comments )
		          sub_1800D8260(v30, v29);
		      }
		      System::Collections::Generic::List<System::Object>::AddRange(
		        Comments,
		        v28,
		        MethodInfo::System::Collections::Generic::List<System::String>::AddRange);
		LABEL_29:
		      v31 = IniParser::IniDataParser::get_CurrentCommentListTemp(this, 0LL);
		      if ( !v31 )
		        sub_1800D8260(v33, v32);
		      sub_183127A90(v31, MethodInfo::System::Collections::Generic::List<System::String>::Clear);
		    }
		  }
		  if ( IniParser::IniDataParser::get_HasError(this, 0LL) )
		  {
		    Scheme_k__BackingField = *iniData;
		    if ( *iniData )
		    {
		      IniParser::IniData::Clear(Scheme_k__BackingField, 0LL);
		      return;
		    }
		    goto LABEL_14;
		  }
		}
		
		protected virtual void ProcessLine(StringBuffer currentLine, IniData iniData) {} // 0x00000001835A90B0-0x00000001835A9150
		// Void ProcessLine(StringBuffer, IniData)
		void IniParser::IniDataParser::ProcessLine(
		        IniDataParser *this,
		        StringBuffer *currentLine,
		        IniData *iniData,
		        MethodInfo *method)
		{
		  IniDataParser *v6; // rdi
		  String *v7; // rax
		  String *v8; // rsi
		  uint32_t currentLineNumber; // edi
		  StringBuffer *v10; // rax
		  String *v11; // rbp
		  __int64 v12; // rax
		  ParsingException *v13; // rax
		  ParsingException *v14; // rbx
		  __int64 v15; // rax
		
		  v6 = this;
		  if ( !currentLine )
		    goto LABEL_8;
		  if ( !currentLine->fields._bufferIndexes._size
		    || IniParser::Parser::StringBuffer::get_IsWhitespace(currentLine, 0LL)
		    || IniParser::IniDataParser::ProcessComment(v6, currentLine, 0LL)
		    || IniParser::IniDataParser::ProcessSection(v6, currentLine, iniData, 0LL)
		    || IniParser::IniDataParser::ProcessProperty(v6, currentLine, iniData, 0LL) )
		  {
		    return;
		  }
		  v7 = System::String::Format((String *)"Couldn't parse text: '{0}'.", (Object *)currentLine, 0LL);
		  this = (IniDataParser *)v6->fields._Configuration_k__BackingField;
		  v8 = v7;
		  if ( !this )
		LABEL_8:
		    sub_1800D8260(this, currentLine);
		  if ( !BYTE2(this->fields._currentLineNumber) )
		  {
		    currentLineNumber = v6->fields._currentLineNumber;
		    v10 = IniParser::Parser::StringBuffer::DiscardChanges(currentLine, 0LL);
		    if ( v10 )
		    {
		      v11 = (String *)sub_180032CB0(3LL, v10);
		      v12 = sub_180035ED0(&TypeInfo::IniParser::Exceptions::ParsingException);
		      v13 = (ParsingException *)sub_1800368D0(v12);
		      v14 = v13;
		      if ( v13 )
		      {
		        IniParser::Exceptions::ParsingException::ParsingException(v13, v8, currentLineNumber, v11, 0LL);
		        v15 = sub_180035ED0(&MethodInfo::IniParser::IniDataParser::ProcessLine);
		        sub_18007E190(v14, v15);
		      }
		    }
		    goto LABEL_8;
		  }
		  if ( !TypeInfo::UnityEngine::Debug->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Debug);
		  UnityEngine::Debug::LogCritical((Object *)v8, 0LL);
		}
		
		protected virtual bool ProcessComment(StringBuffer currentLine) => default; // 0x00000001835A8ED0-0x00000001835A9080
		// Boolean ProcessComment(StringBuffer)
		bool IniParser::IniDataParser::ProcessComment(IniDataParser *this, StringBuffer *currentLine, MethodInfo *method)
		{
		  IniDataParser *v3; // rsi
		  StringBuffer *v4; // rax
		  StringBuffer *v5; // rdi
		  IniScheme *Scheme_k__BackingField; // rbx
		  String *commentString; // rdx
		  bool result; // al
		  IniParserConfiguration *Configuration_k__BackingField; // rax
		  String *v10; // rax
		  int32_t start; // eax
		  int32_t v12; // ebx
		  String *v13; // rax
		  int32_t stringLength; // r14d
		  int32_t size; // ebp
		  String *v16; // rax
		  StringBuffer_Range v17; // rax
		  StringBuffer *v18; // rbx
		  IniParserConfiguration *v19; // rax
		  List_1_System_Object_ *CurrentCommentListTemp; // rdi
		  Object *v21; // rax
		
		  v3 = this;
		  if ( !currentLine )
		    goto LABEL_21;
		  v4 = IniParser::Parser::StringBuffer::SwallowCopy(currentLine, 0LL);
		  v5 = v4;
		  if ( !v4 )
		    goto LABEL_21;
		  IniParser::Parser::StringBuffer::TrimStart(v4, 0LL);
		  Scheme_k__BackingField = v3->fields._Scheme_k__BackingField;
		  if ( !Scheme_k__BackingField )
		    goto LABEL_21;
		  if ( System::String::IsNullOrWhiteSpace(Scheme_k__BackingField->fields._commentString, 0LL) )
		    commentString = (String *)";";
		  else
		    commentString = Scheme_k__BackingField->fields._commentString;
		  result = IniParser::Parser::StringBuffer::StartsWith(v5, commentString, 0LL);
		  if ( result )
		  {
		    Configuration_k__BackingField = v3->fields._Configuration_k__BackingField;
		    if ( Configuration_k__BackingField )
		    {
		      if ( !Configuration_k__BackingField->fields._ParseComments_k__BackingField )
		        return 1;
		      IniParser::Parser::StringBuffer::TrimEnd(v5, 0LL);
		      this = (IniDataParser *)v3->fields._Scheme_k__BackingField;
		      if ( this )
		      {
		        v10 = IniParser::Configuration::IniScheme::get_CommentString((IniScheme *)this, 0LL);
		        start = IniParser::Parser::StringBuffer::FindSubstring(v5, v10, 0, 0LL)._start;
		        this = (IniDataParser *)v3->fields._Scheme_k__BackingField;
		        v12 = start;
		        if ( this )
		        {
		          v13 = IniParser::Configuration::IniScheme::get_CommentString((IniScheme *)this, 0LL);
		          if ( v13 )
		          {
		            this = (IniDataParser *)v3->fields._Scheme_k__BackingField;
		            stringLength = v13->fields._stringLength;
		            size = v5->fields._bufferIndexes._size;
		            if ( this )
		            {
		              v16 = IniParser::Configuration::IniScheme::get_CommentString((IniScheme *)this, 0LL);
		              if ( v16 )
		              {
		                v17 = IniParser::Parser::StringBuffer::Range::FromIndexWithSize(
		                        stringLength + v12,
		                        size - v16->fields._stringLength,
		                        0LL);
		                v18 = IniParser::Parser::StringBuffer::Substring(v5, v17, 0LL);
		                v19 = v3->fields._Configuration_k__BackingField;
		                if ( v19 )
		                {
		                  if ( v19->fields._TrimComments_k__BackingField )
		                  {
		                    if ( !v18 )
		                      goto LABEL_21;
		                    IniParser::Parser::StringBuffer::Trim(v18, 0LL);
		                    CurrentCommentListTemp = (List_1_System_Object_ *)IniParser::IniDataParser::get_CurrentCommentListTemp(
		                                                                        v3,
		                                                                        0LL);
		                  }
		                  else
		                  {
		                    CurrentCommentListTemp = (List_1_System_Object_ *)IniParser::IniDataParser::get_CurrentCommentListTemp(
		                                                                        v3,
		                                                                        0LL);
		                    if ( !v18 )
		                      goto LABEL_21;
		                  }
		                  v21 = (Object *)sub_180032CB0(3LL, v18);
		                  if ( CurrentCommentListTemp )
		                  {
		                    sub_182F01190(CurrentCommentListTemp, v21);
		                    return 1;
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_21:
		    sub_1800D8260(this, currentLine);
		  }
		  return result;
		}
		
		protected virtual bool ProcessSection(StringBuffer currentLine, IniData iniData) => default; // 0x00000001835A8BA0-0x00000001835A8DF0
		// Boolean ProcessSection(StringBuffer, IniData)
		bool IniParser::IniDataParser::ProcessSection(
		        IniDataParser *this,
		        StringBuffer *currentLine,
		        IniData *iniData,
		        MethodInfo *method)
		{
		  IniDataParser *v6; // rbp
		  IniScheme *Scheme_k__BackingField; // rbx
		  String *v8; // rdx
		  StringBuffer_Range Substring; // kr00_8
		  String *SectionEndString; // rax
		  StringBuffer_Range v11; // kr08_8
		  String *SectionStartString; // rax
		  int32_t v13; // r15d
		  int v14; // ebx
		  String *v15; // rax
		  IniParserConfiguration *Configuration_k__BackingField; // rax
		  __int64 v17; // rax
		  String *v18; // rbx
		  UberPostPassUtils_ColorGradingData **v19; // rdx
		  VolumetricPipelineRT **v20; // r8
		  VolumetricPipelineRT **v21; // r9
		  IniParserConfiguration *v22; // r9
		  IniParserConfiguration *v23; // rax
		  Section *v24; // rax
		  List_1_System_Object_ *Comments; // rbx
		  IEnumerable_1_System_Object_ *CurrentCommentListTemp; // rax
		  List_1_System_String_ *v27; // rax
		  String *v29; // rax
		  String *v30; // rbx
		  uint32_t currentLineNumber; // ebp
		  StringBuffer *v32; // rax
		  String *v33; // rsi
		  __int64 v34; // rax
		  ParsingException *v35; // rax
		  ParsingException *v36; // rdi
		  __int64 v37; // rax
		  struct Debug_1__Class *v38; // rcx
		  Object__Array *v39; // rax
		  String *v40; // rax
		  uint32_t v41; // ebp
		  StringBuffer *v42; // rax
		  String *v43; // rsi
		  __int64 v44; // rax
		  ParsingException *v45; // rax
		  ParsingException *v46; // rdi
		  __int64 v47; // rax
		  VolumetricPipelineRT **methoda; // [rsp+20h] [rbp-28h]
		  MethodInfo *v49; // [rsp+28h] [rbp-20h]
		
		  v6 = this;
		  if ( !currentLine )
		    goto LABEL_34;
		  if ( currentLine->fields._bufferIndexes._size > 0 )
		  {
		    Scheme_k__BackingField = this->fields._Scheme_k__BackingField;
		    if ( !Scheme_k__BackingField )
		      goto LABEL_34;
		    v8 = System::String::IsNullOrWhiteSpace(Scheme_k__BackingField->fields._sectionStartString, 0LL)
		       ? (String *)"["
		       : Scheme_k__BackingField->fields._sectionStartString;
		    Substring = IniParser::Parser::StringBuffer::FindSubstring(currentLine, v8, 0, 0LL);
		    if ( Substring._size )
		    {
		      this = (IniDataParser *)v6->fields._Scheme_k__BackingField;
		      if ( !this )
		        goto LABEL_34;
		      SectionEndString = IniParser::Configuration::IniScheme::get_SectionEndString((IniScheme *)this, 0LL);
		      v11 = IniParser::Parser::StringBuffer::FindSubstring(currentLine, SectionEndString, Substring._size, 0LL);
		      if ( v11._size )
		      {
		        this = (IniDataParser *)v6->fields._Scheme_k__BackingField;
		        if ( !this )
		          goto LABEL_34;
		        SectionStartString = IniParser::Configuration::IniScheme::get_SectionStartString((IniScheme *)this, 0LL);
		        if ( !SectionStartString )
		          goto LABEL_34;
		        v13 = Substring._start + SectionStartString->fields._stringLength;
		        v14 = Substring._size <= 0 ? 0 : v11._start + v11._size - 1;
		        this = (IniDataParser *)v6->fields._Scheme_k__BackingField;
		        if ( !this )
		          goto LABEL_34;
		        v15 = IniParser::Configuration::IniScheme::get_SectionEndString((IniScheme *)this, 0LL);
		        if ( !v15 )
		          goto LABEL_34;
		        IniParser::Parser::StringBuffer::ResizeBetweenIndexes(currentLine, v13, v14 - v15->fields._stringLength, 0LL);
		        Configuration_k__BackingField = v6->fields._Configuration_k__BackingField;
		        if ( !Configuration_k__BackingField )
		          goto LABEL_34;
		        if ( Configuration_k__BackingField->fields._TrimSections_k__BackingField )
		          IniParser::Parser::StringBuffer::Trim(currentLine, 0LL);
		        v17 = sub_180032CB0(3LL, currentLine);
		        v6->fields._currentSectionNameTemp = (String *)v17;
		        v18 = (String *)v17;
		        sub_18002D1B0((ILFixDynamicMethodWrapper_2 *)&v6->fields._currentSectionNameTemp, v19, v20, v21, methoda, v49);
		        v22 = v6->fields._Configuration_k__BackingField;
		        if ( !v22 )
		          goto LABEL_34;
		        if ( v22->fields._AllowDuplicateSections_k__BackingField )
		          goto LABEL_54;
		        if ( !iniData )
		          goto LABEL_34;
		        this = (IniDataParser *)iniData->fields._Sections_k__BackingField;
		        if ( !this )
		          goto LABEL_34;
		        if ( !IniParser::Model::SectionCollection::Contains((SectionCollection *)this, v18, 0LL) )
		        {
		LABEL_54:
		          if ( iniData )
		          {
		            this = (IniDataParser *)iniData->fields._Sections_k__BackingField;
		            if ( this )
		            {
		              IniParser::Model::SectionCollection::Add((SectionCollection *)this, v18, 0LL);
		              v23 = v6->fields._Configuration_k__BackingField;
		              if ( v23 )
		              {
		                if ( !v23->fields._ParseComments_k__BackingField )
		                  return 1;
		                this = (IniDataParser *)iniData->fields._Sections_k__BackingField;
		                if ( this )
		                {
		                  v24 = IniParser::Model::SectionCollection::FindByName((SectionCollection *)this, v18, 0LL);
		                  if ( v24 )
		                  {
		                    Comments = (List_1_System_Object_ *)IniParser::Model::Section::get_Comments(v24, 0LL);
		                    CurrentCommentListTemp = (IEnumerable_1_System_Object_ *)IniParser::IniDataParser::get_CurrentCommentListTemp(
		                                                                               v6,
		                                                                               0LL);
		                    if ( Comments )
		                    {
		                      System::Collections::Generic::List<System::Object>::AddRange(
		                        Comments,
		                        CurrentCommentListTemp,
		                        MethodInfo::System::Collections::Generic::List<System::String>::AddRange);
		                      v27 = IniParser::IniDataParser::get_CurrentCommentListTemp(v6, 0LL);
		                      if ( v27 )
		                      {
		                        sub_183127A90(v27, MethodInfo::System::Collections::Generic::List<System::String>::Clear);
		                        return 1;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		LABEL_34:
		          sub_1800D8260(this, currentLine);
		        }
		        v29 = System::String::Format((String *)"Duplicate section with name '{0}'.", (Object *)v18, 0LL);
		        this = (IniDataParser *)v6->fields._Configuration_k__BackingField;
		        v30 = v29;
		        if ( !this )
		          goto LABEL_34;
		        if ( !BYTE2(this->fields._currentLineNumber) )
		        {
		          currentLineNumber = v6->fields._currentLineNumber;
		          v32 = IniParser::Parser::StringBuffer::DiscardChanges(currentLine, 0LL);
		          if ( v32 )
		          {
		            v33 = (String *)sub_180032CB0(3LL, v32);
		            v34 = sub_180035ED0(&TypeInfo::IniParser::Exceptions::ParsingException);
		            v35 = (ParsingException *)sub_1800368D0(v34);
		            v36 = v35;
		            if ( v35 )
		            {
		              IniParser::Exceptions::ParsingException::ParsingException(v35, v30, currentLineNumber, v33, 0LL);
		              v37 = sub_180035ED0(&MethodInfo::IniParser::IniDataParser::ProcessSection);
		              sub_18007E190(v36, v37);
		            }
		          }
		          goto LABEL_34;
		        }
		        v38 = TypeInfo::UnityEngine::Debug;
		        if ( TypeInfo::UnityEngine::Debug->_1.cctor_finished_or_no_cctor )
		          goto LABEL_51;
		      }
		      else
		      {
		        v39 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		        v40 = System::String::Format((String *)"No closing section value.", v39, 0LL);
		        this = (IniDataParser *)v6->fields._Configuration_k__BackingField;
		        v30 = v40;
		        if ( !this )
		          goto LABEL_34;
		        if ( !BYTE2(this->fields._currentLineNumber) )
		        {
		          v41 = v6->fields._currentLineNumber;
		          v42 = IniParser::Parser::StringBuffer::DiscardChanges(currentLine, 0LL);
		          if ( v42 )
		          {
		            v43 = (String *)sub_180032CB0(3LL, v42);
		            v44 = sub_180035ED0(&TypeInfo::IniParser::Exceptions::ParsingException);
		            v45 = (ParsingException *)sub_1800368D0(v44);
		            v46 = v45;
		            if ( v45 )
		            {
		              IniParser::Exceptions::ParsingException::ParsingException(v45, v30, v41, v43, 0LL);
		              v47 = sub_180035ED0(&MethodInfo::IniParser::IniDataParser::ProcessSection);
		              sub_18007E190(v46, v47);
		            }
		          }
		          goto LABEL_34;
		        }
		        v38 = TypeInfo::UnityEngine::Debug;
		        if ( TypeInfo::UnityEngine::Debug->_1.cctor_finished_or_no_cctor )
		          goto LABEL_51;
		      }
		      il2cpp_runtime_class_init_1(v38);
		LABEL_51:
		      UnityEngine::Debug::LogCritical((Object *)v30, 0LL);
		    }
		  }
		  return 0;
		}
		
		protected virtual bool ProcessProperty(StringBuffer currentLine, IniData iniData) => default; // 0x00000001835A9470-0x00000001835A9670
		// Boolean ProcessProperty(StringBuffer, IniData)
		bool IniParser::IniDataParser::ProcessProperty(
		        IniDataParser *this,
		        StringBuffer *currentLine,
		        IniData *iniData,
		        MethodInfo *method)
		{
		  IniDataParser *v6; // rsi
		  String *PropertyAssigmentString; // rax
		  StringBuffer_Range Substring; // rax
		  StringBuffer_Range v9; // rdx
		  int v10; // ecx
		  int v11; // eax
		  int v12; // r8d
		  StringBuffer_Range v13; // rbx
		  StringBuffer *v14; // rdi
		  StringBuffer *v15; // rax
		  StringBuffer *v16; // rbx
		  String *currentSectionNameTemp; // rax
		  Section *v18; // rbp
		  String *v19; // rdi
		  String *v20; // rax
		  String *sectionName; // rcx
		  PropertyCollection *Properties_k__BackingField; // r9
		  IniParserConfiguration *Configuration_k__BackingField; // rax
		  Object__Array *v25; // rax
		  String *v26; // rax
		  struct Debug_1__Class *v27; // rcx
		  String *v28; // rbx
		  Object__Array *v29; // rax
		  String *v30; // rax
		  uint32_t currentLineNumber; // esi
		  StringBuffer *v32; // rax
		  String *v33; // rbp
		  __int64 v34; // rax
		  ParsingException *v35; // rax
		  ParsingException *v36; // rdi
		  __int64 v37; // rax
		  StringBuffer_Range range; // [rsp+68h] [rbp+10h]
		
		  v6 = this;
		  if ( !currentLine )
		    goto LABEL_29;
		  if ( currentLine->fields._bufferIndexes._size > 0 )
		  {
		    this = (IniDataParser *)this->fields._Scheme_k__BackingField;
		    if ( !this )
		      goto LABEL_29;
		    PropertyAssigmentString = IniParser::Configuration::IniScheme::get_PropertyAssigmentString((IniScheme *)this, 0LL);
		    Substring = IniParser::Parser::StringBuffer::FindSubstring(currentLine, PropertyAssigmentString, 0, 0LL);
		    if ( Substring._size )
		    {
		      if ( Substring._start - 1 < 0 )
		      {
		        v9 = 0LL;
		      }
		      else
		      {
		        range._start = 0;
		        range._size = Substring._start;
		        v9 = range;
		      }
		      if ( Substring._size <= 0 )
		        v10 = 1;
		      else
		        v10 = Substring._start + Substring._size;
		      if ( Substring._size <= 0 )
		        v11 = 0;
		      else
		        v11 = Substring._size + Substring._start - 1;
		      v12 = currentLine->fields._bufferIndexes._size - v11 - 1;
		      if ( v10 < 0 || v12 <= 0 )
		        v13 = 0LL;
		      else
		        v13 = (StringBuffer_Range)__PAIR64__(v12, v10);
		      v14 = IniParser::Parser::StringBuffer::Substring(currentLine, v9, 0LL);
		      v15 = IniParser::Parser::StringBuffer::Substring(currentLine, v13, 0LL);
		      this = (IniDataParser *)v6->fields._Configuration_k__BackingField;
		      v16 = v15;
		      if ( !this || !v14 )
		        goto LABEL_29;
		      if ( HIBYTE(this->fields._currentLineNumber) )
		      {
		        IniParser::Parser::StringBuffer::TrimEnd(v14, 0LL);
		        IniParser::Parser::StringBuffer::TrimStart(v14, 0LL);
		        if ( !v16 )
		          goto LABEL_29;
		        IniParser::Parser::StringBuffer::TrimEnd(v16, 0LL);
		        IniParser::Parser::StringBuffer::TrimStart(v16, 0LL);
		      }
		      if ( v14->fields._bufferIndexes._size )
		      {
		        currentSectionNameTemp = v6->fields._currentSectionNameTemp;
		        if ( currentSectionNameTemp && currentSectionNameTemp->fields._stringLength )
		        {
		          if ( iniData )
		          {
		            this = (IniDataParser *)iniData->fields._Sections_k__BackingField;
		            if ( this )
		            {
		              v18 = IniParser::Model::SectionCollection::FindByName(
		                      (SectionCollection *)this,
		                      v6->fields._currentSectionNameTemp,
		                      0LL);
		              v19 = (String *)sub_180032CB0(3LL, v14);
		              if ( v16 )
		              {
		                v20 = (String *)sub_180032CB0(3LL, v16);
		                if ( v18 )
		                {
		                  sectionName = v6->fields._currentSectionNameTemp;
		                  Properties_k__BackingField = v18->fields._Properties_k__BackingField;
		LABEL_27:
		                  IniParser::IniDataParser::AddKeyToKeyValueCollection(
		                    v6,
		                    v19,
		                    v20,
		                    Properties_k__BackingField,
		                    sectionName,
		                    0LL);
		                  return 1;
		                }
		              }
		            }
		          }
		          goto LABEL_29;
		        }
		        Configuration_k__BackingField = v6->fields._Configuration_k__BackingField;
		        if ( !Configuration_k__BackingField )
		          goto LABEL_29;
		        if ( Configuration_k__BackingField->fields._AllowKeysWithoutSection_k__BackingField )
		        {
		          v19 = (String *)sub_180032CB0(3LL, v14);
		          if ( v16 )
		          {
		            v20 = (String *)sub_180032CB0(3LL, v16);
		            if ( iniData )
		            {
		              sectionName = (String *)"global";
		              Properties_k__BackingField = iniData->fields._Global_k__BackingField;
		              goto LABEL_27;
		            }
		          }
		LABEL_29:
		          sub_1800D8260(this, currentLine);
		        }
		        v25 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		        v26 = System::String::Format((String *)"Properties must be contained inside a section.", v25, 0LL);
		        v27 = TypeInfo::UnityEngine::Debug;
		        v28 = v26;
		        if ( TypeInfo::UnityEngine::Debug->_1.cctor_finished_or_no_cctor )
		          goto LABEL_48;
		      }
		      else
		      {
		        v29 = (Object__Array *)sub_183AD6530(MethodInfo::System::Array::Empty<System::Object>);
		        v30 = System::String::Format((String *)"Found property without key.", v29, 0LL);
		        this = (IniDataParser *)v6->fields._Configuration_k__BackingField;
		        v28 = v30;
		        if ( !this )
		          goto LABEL_29;
		        if ( !BYTE2(this->fields._currentLineNumber) )
		        {
		          currentLineNumber = v6->fields._currentLineNumber;
		          v32 = IniParser::Parser::StringBuffer::DiscardChanges(currentLine, 0LL);
		          if ( v32 )
		          {
		            v33 = (String *)sub_180032CB0(3LL, v32);
		            v34 = sub_180035ED0(&TypeInfo::IniParser::Exceptions::ParsingException);
		            v35 = (ParsingException *)sub_1800368D0(v34);
		            v36 = v35;
		            if ( v35 )
		            {
		              IniParser::Exceptions::ParsingException::ParsingException(v35, v28, currentLineNumber, v33, 0LL);
		              v37 = sub_180035ED0(&MethodInfo::IniParser::IniDataParser::ProcessProperty);
		              sub_18007E190(v36, v37);
		            }
		          }
		          goto LABEL_29;
		        }
		        v27 = TypeInfo::UnityEngine::Debug;
		        if ( TypeInfo::UnityEngine::Debug->_1.cctor_finished_or_no_cctor )
		          goto LABEL_48;
		      }
		      il2cpp_runtime_class_init_1(v27);
		LABEL_48:
		      UnityEngine::Debug::LogCritical((Object *)v28, 0LL);
		    }
		  }
		  return 0;
		}
		
		private void HandleDuplicatedKeyInCollection(string key, string value, PropertyCollection keyDataCollection, string sectionName) {} // 0x0000000189B3116C-0x0000000189B3123C
		// Void HandleDuplicatedKeyInCollection(String, String, PropertyCollection, String)
		void IniParser::IniDataParser::HandleDuplicatedKeyInCollection(
		        IniDataParser *this,
		        String *key,
		        String *value,
		        PropertyCollection *keyDataCollection,
		        String *sectionName,
		        MethodInfo *method)
		{
		  IniParserConfiguration *Configuration_k__BackingField; // r10
		  String *v8; // rbp
		  String *v9; // rdi
		  int32_t DuplicatePropertiesBehaviour_k__BackingField; // r10d
		  int v12; // r10d
		  int v13; // r10d
		  String *Item; // rax
		  Object *v15; // rbx
		
		  Configuration_k__BackingField = this->fields._Configuration_k__BackingField;
		  v8 = value;
		  v9 = key;
		  if ( !Configuration_k__BackingField )
		    goto LABEL_12;
		  DuplicatePropertiesBehaviour_k__BackingField = Configuration_k__BackingField->fields._DuplicatePropertiesBehaviour_k__BackingField;
		  if ( !DuplicatePropertiesBehaviour_k__BackingField )
		  {
		    v15 = (Object *)System::String::Format(
		                      (String *)"Duplicated key '{0}' found in section '{1}",
		                      (Object *)key,
		                      (Object *)sectionName,
		                      0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Debug);
		    UnityEngine::Debug::LogCritical(v15, 0LL);
		    return;
		  }
		  v12 = DuplicatePropertiesBehaviour_k__BackingField - 1;
		  if ( v12 )
		  {
		    v13 = v12 - 1;
		    if ( v13 )
		    {
		      if ( v13 != 1 )
		        return;
		      if ( keyDataCollection )
		      {
		        Item = IniParser::Model::PropertyCollection::get_Item(keyDataCollection, key, 0LL);
		        key = (String *)this->fields._Configuration_k__BackingField;
		        if ( key )
		        {
		          value = System::String::Concat(Item, (String *)key[1].klass, v8, 0LL);
		          key = v9;
		LABEL_9:
		          IniParser::Model::PropertyCollection::set_Item(keyDataCollection, key, value, 0LL);
		          return;
		        }
		      }
		    }
		    else if ( keyDataCollection )
		    {
		      goto LABEL_9;
		    }
		LABEL_12:
		    sub_1800D8260(this, key);
		  }
		}
		
		private void AddKeyToKeyValueCollection(string key, string value, PropertyCollection keyDataCollection, string sectionName) {} // 0x00000001835A9D80-0x00000001835A9E60
		// Void AddKeyToKeyValueCollection(String, String, PropertyCollection, String)
		void IniParser::IniDataParser::AddKeyToKeyValueCollection(
		        IniDataParser *this,
		        String *key,
		        String *value,
		        PropertyCollection *keyDataCollection,
		        String *sectionName,
		        MethodInfo *method)
		{
		  IniDataParser *v9; // rdi
		  IniParserConfiguration *Configuration_k__BackingField; // rax
		  Property *v11; // rbx
		  List_1_System_String_ *CurrentCommentListTemp; // rax
		  List_1_System_String_ *v13; // rax
		
		  v9 = this;
		  if ( !keyDataCollection )
		    goto LABEL_11;
		  this = (IniDataParser *)keyDataCollection->fields._properties;
		  if ( !this )
		    goto LABEL_11;
		  if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
		         (Dictionary_2_System_Object_System_Object_ *)this,
		         (Object *)key,
		         MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey) )
		  {
		    IniParser::IniDataParser::HandleDuplicatedKeyInCollection(v9, key, value, keyDataCollection, sectionName, 0LL);
		  }
		  else
		  {
		    IniParser::Model::PropertyCollection::Add(keyDataCollection, key, value, 0LL);
		  }
		  Configuration_k__BackingField = v9->fields._Configuration_k__BackingField;
		  if ( !Configuration_k__BackingField )
		    goto LABEL_11;
		  if ( !Configuration_k__BackingField->fields._ParseComments_k__BackingField )
		    return;
		  v11 = IniParser::Model::PropertyCollection::FindByKey(keyDataCollection, key, 0LL);
		  CurrentCommentListTemp = IniParser::IniDataParser::get_CurrentCommentListTemp(v9, 0LL);
		  if ( !v11
		    || (IniParser::Model::Property::set_Comments(v11, CurrentCommentListTemp, 0LL),
		        (v13 = IniParser::IniDataParser::get_CurrentCommentListTemp(v9, 0LL)) == 0LL) )
		  {
		LABEL_11:
		    sub_1800D8260(this, key);
		  }
		  sub_183127A90(v13, MethodInfo::System::Collections::Generic::List<System::String>::Clear);
		}
		
	}
}
