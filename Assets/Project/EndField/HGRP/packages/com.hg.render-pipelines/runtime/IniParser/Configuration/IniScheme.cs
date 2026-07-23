using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IniParser;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IniParser.Configuration
{
	public class IniScheme : IDeepCloneable<IniScheme> // TypeDefIndex: 37390
	{
		// Fields
		private string _commentString; // 0x10
		private string _sectionStartString; // 0x18
		private string _sectionEndString; // 0x20
		private string _propertyAssigmentString; // 0x28
	
		// Properties
		public string CommentString { get => default; set {} } // 0x00000001835A9080-0x00000001835A90B0 0x00000001835A7E80-0x00000001835A7ED0
		// String get_CommentString()
		String *IniParser::Configuration::IniScheme::get_CommentString(IniScheme *this, MethodInfo *method)
		{
		  if ( System::String::IsNullOrWhiteSpace(this->fields._commentString, 0LL) )
		    return (String *)";";
		  else
		    return this->fields._commentString;
		}
		

		// Void set_CommentString(String)
		void IniParser::Configuration::IniScheme::set_CommentString(IniScheme *this, String *value, MethodInfo *method)
		{
		  VolumetricPipelineRT **v3; // r9
		  String *v5; // rax
		  VolumetricPipelineRT **v6; // [rsp+50h] [rbp+28h]
		  MethodInfo *v7; // [rsp+58h] [rbp+30h]
		
		  if ( value )
		    v5 = System::String::TrimWhiteSpaceHelper(value, String_TrimType__Enum_Both, 0LL);
		  else
		    v5 = 0LL;
		  if ( !this )
		    sub_1800D8260(this, value);
		  this->fields._commentString = v5;
		  sub_18002D1B0(
		    (ILFixDynamicMethodWrapper_2 *)&this->fields,
		    (UberPostPassUtils_ColorGradingData **)value,
		    (VolumetricPipelineRT **)method,
		    v3,
		    v6,
		    v7);
		}
		
		public string SectionStartString { get => default; set {} } // 0x00000001835A8DF0-0x00000001835A8E20 0x00000001835A7ED0-0x00000001835A7F20
		// String get_SectionStartString()
		String *IniParser::Configuration::IniScheme::get_SectionStartString(IniScheme *this, MethodInfo *method)
		{
		  if ( System::String::IsNullOrWhiteSpace(this->fields._sectionStartString, 0LL) )
		    return (String *)"[";
		  else
		    return this->fields._sectionStartString;
		}
		

		// Void set_SectionStartString(String)
		void IniParser::Configuration::IniScheme::set_SectionStartString(IniScheme *this, String *value, MethodInfo *method)
		{
		  VolumetricPipelineRT **v3; // r9
		  String *v5; // rax
		  VolumetricPipelineRT **v6; // [rsp+50h] [rbp+28h]
		  MethodInfo *v7; // [rsp+58h] [rbp+30h]
		
		  if ( value )
		    v5 = System::String::TrimWhiteSpaceHelper(value, String_TrimType__Enum_Both, 0LL);
		  else
		    v5 = 0LL;
		  if ( !this )
		    sub_1800D8260(this, value);
		  this->fields._sectionStartString = v5;
		  sub_18002D1B0(
		    (ILFixDynamicMethodWrapper_2 *)&this->fields._sectionStartString,
		    (UberPostPassUtils_ColorGradingData **)value,
		    (VolumetricPipelineRT **)method,
		    v3,
		    v6,
		    v7);
		}
		
		public string SectionEndString { get => default; set {} } // 0x00000001835AA730-0x00000001835AA760 0x00000001835A7F20-0x00000001835A7F70
		// String get_SectionEndString()
		String *IniParser::Configuration::IniScheme::get_SectionEndString(IniScheme *this, MethodInfo *method)
		{
		  if ( System::String::IsNullOrWhiteSpace(this->fields._sectionEndString, 0LL) )
		    return (String *)"]";
		  else
		    return this->fields._sectionEndString;
		}
		

		// Void set_SectionEndString(String)
		void IniParser::Configuration::IniScheme::set_SectionEndString(IniScheme *this, String *value, MethodInfo *method)
		{
		  VolumetricPipelineRT **v3; // r9
		  String *v5; // rax
		  VolumetricPipelineRT **v6; // [rsp+50h] [rbp+28h]
		  MethodInfo *v7; // [rsp+58h] [rbp+30h]
		
		  if ( value )
		    v5 = System::String::TrimWhiteSpaceHelper(value, String_TrimType__Enum_Both, 0LL);
		  else
		    v5 = 0LL;
		  if ( !this )
		    sub_1800D8260(this, value);
		  this->fields._sectionEndString = v5;
		  sub_18002D1B0(
		    (ILFixDynamicMethodWrapper_2 *)&this->fields._sectionEndString,
		    (UberPostPassUtils_ColorGradingData **)value,
		    (VolumetricPipelineRT **)method,
		    v3,
		    v6,
		    v7);
		}
		
		public string PropertyAssigmentString { get => default; set {} } // 0x00000001835A9BF0-0x00000001835A9C20 0x00000001835A7F70-0x00000001835A7FC0
		// String get_PropertyAssigmentString()
		String *IniParser::Configuration::IniScheme::get_PropertyAssigmentString(IniScheme *this, MethodInfo *method)
		{
		  if ( System::String::IsNullOrWhiteSpace(this->fields._propertyAssigmentString, 0LL) )
		    return (String *)"=";
		  else
		    return this->fields._propertyAssigmentString;
		}
		

		// Void set_PropertyAssigmentString(String)
		void IniParser::Configuration::IniScheme::set_PropertyAssigmentString(
		        IniScheme *this,
		        String *value,
		        MethodInfo *method)
		{
		  VolumetricPipelineRT **v3; // r9
		  String *v5; // rax
		  VolumetricPipelineRT **v6; // [rsp+50h] [rbp+28h]
		  MethodInfo *v7; // [rsp+58h] [rbp+30h]
		
		  if ( value )
		    v5 = System::String::TrimWhiteSpaceHelper(value, String_TrimType__Enum_Both, 0LL);
		  else
		    v5 = 0LL;
		  if ( !this )
		    sub_1800D8260(this, value);
		  this->fields._propertyAssigmentString = v5;
		  sub_18002D1B0(
		    (ILFixDynamicMethodWrapper_2 *)&this->fields._propertyAssigmentString,
		    (UberPostPassUtils_ColorGradingData **)value,
		    (VolumetricPipelineRT **)method,
		    v3,
		    v6,
		    v7);
		}
		
	
		// Constructors
		public IniScheme() {} // 0x00000001835A7D60-0x00000001835A7DC0
		private IniScheme(IniScheme ori) {} // 0x00000001835A7FC0-0x00000001835A80A0
	
		// Methods
		public IniScheme DeepClone() => default; // 0x00000001835A7E30-0x00000001835A7E80
		// IniScheme DeepClone()
		IniScheme *IniParser::Configuration::IniScheme::DeepClone(IniScheme *this, MethodInfo *method)
		{
		  IniScheme *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  IniScheme *v6; // rbx
		
		  v3 = (IniScheme *)sub_1800368D0(TypeInfo::IniParser::Configuration::IniScheme);
		  v6 = v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  IniParser::Configuration::IniScheme::IniScheme(v3, this, 0LL);
		  return v6;
		}
		
	}
}
