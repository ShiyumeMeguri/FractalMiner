using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IniParser.Configuration;
using IniParser.Model;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IniParser
{
	public class IniData : IDeepCloneable<IniParser.IniData> // TypeDefIndex: 37371
	{
		// Fields
		private IniParserConfiguration _configuration; // 0x28
		protected IniScheme _scheme; // 0x30
	
		// Properties
		public bool CreateSectionsIfTheyDontExist { get; set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
		// Boolean get_changed()
		bool Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_changed(
		        ValueWatcher_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields.NiVDAueHECEJqGCNLxcjNXRtPmUC;
		}
		

		// Void set_override(Boolean)
		void HG::Rendering::Runtime::ScalableSettingValue<bool>::set_override(
		        ScalableSettingValue_1_System_Boolean_ *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields.m_Override = value;
		}
		
		public IniParserConfiguration Configuration { get => default; set {} } // 0x0000000189B31498-0x0000000189B314EC 0x0000000189B315A8-0x0000000189B315DC
		// Void set_Configuration(IniParserConfiguration)
		void IniParser::IniData::set_Configuration(IniData *this, IniParserConfiguration *value, MethodInfo *method)
		{
		  UberPostPassUtils_ColorGradingData **v4; // rdx
		  VolumetricPipelineRT **v5; // r8
		  VolumetricPipelineRT **v6; // r9
		  VolumetricPipelineRT **v7; // [rsp+50h] [rbp+28h]
		  MethodInfo *v8; // [rsp+58h] [rbp+30h]
		
		  if ( !value )
		    sub_1800D8260(this, 0LL);
		  this->fields._configuration = IniParser::Configuration::IniParserConfiguration::DeepClone(value, 0LL);
		  sub_18002D1B0((ILFixDynamicMethodWrapper_2 *)&this->fields._configuration, v4, v5, v6, v7, v8);
		}
		
		public IniScheme Scheme { get => default; set {} } // 0x0000000189B31554-0x0000000189B315A8 0x00000001835A7B30-0x00000001835A7B70
		// Void set_Scheme(IniScheme)
		void IniParser::IniData::set_Scheme(IniData *this, IniScheme *value, MethodInfo *method)
		{
		  UberPostPassUtils_ColorGradingData **v4; // rdx
		  VolumetricPipelineRT **v5; // r8
		  VolumetricPipelineRT **v6; // r9
		  VolumetricPipelineRT **v7; // [rsp+50h] [rbp+28h]
		  MethodInfo *v8; // [rsp+58h] [rbp+30h]
		
		  if ( !value )
		    sub_1800D8260(this, 0LL);
		  this->fields._scheme = IniParser::Configuration::IniScheme::DeepClone(value, 0LL);
		  sub_18002D1B0((ILFixDynamicMethodWrapper_2 *)&this->fields._scheme, v4, v5, v6, v7, v8);
		}
		
		public PropertyCollection Global { get; protected set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
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
		
		public PropertyCollection this[string sectionName] { get => default; } // 0x0000000189B314EC-0x0000000189B31554 
		// PropertyCollection get_Item(String)
		PropertyCollection *IniParser::IniData::get_Item(IniData *this, String *sectionName, MethodInfo *method)
		{
		  SectionCollection *Sections_k__BackingField; // rcx
		
		  Sections_k__BackingField = this->fields._Sections_k__BackingField;
		  if ( !Sections_k__BackingField )
		    goto LABEL_9;
		  if ( IniParser::Model::SectionCollection::Contains(Sections_k__BackingField, sectionName, 0LL) )
		    goto LABEL_7;
		  if ( !this->fields._CreateSectionsIfTheyDontExist_k__BackingField )
		    return 0LL;
		  Sections_k__BackingField = this->fields._Sections_k__BackingField;
		  if ( !Sections_k__BackingField )
		LABEL_9:
		    sub_1800D8260(Sections_k__BackingField, sectionName);
		  IniParser::Model::SectionCollection::Add(Sections_k__BackingField, sectionName, 0LL);
		LABEL_7:
		  Sections_k__BackingField = this->fields._Sections_k__BackingField;
		  if ( !Sections_k__BackingField )
		    goto LABEL_9;
		  return IniParser::Model::SectionCollection::get_Item(Sections_k__BackingField, sectionName, 0LL);
		}
		
		public SectionCollection Sections { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		// Func`1[Single] get_getValueDelegate()
		Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
		        ValueWatcher_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
		}
		

		// Void set_getValueDelegate(Func`1[Single])
		void Rewired::Utils::Classes::Utility::ValueWatcher<float>::set_getValueDelegate(
		        ValueWatcher_1_System_Single_ *this,
		        Func_1_Single_ *value,
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
		
	
		// Constructors
		public IniData() {} // 0x00000001835A7C60-0x00000001835A7D00
		public IniData(IniScheme scheme) {} // 0x00000001835A7AE0-0x00000001835A7B30
		// IniData(IniScheme)
		void IniParser::IniData::IniData(IniData *this, IniScheme *scheme, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  UberPostPassUtils_ColorGradingData **v7; // rdx
		  VolumetricPipelineRT **v8; // r8
		  VolumetricPipelineRT **v9; // r9
		  VolumetricPipelineRT **v10; // [rsp+50h] [rbp+28h]
		  MethodInfo *v11; // [rsp+58h] [rbp+30h]
		
		  IniParser::IniData::IniData(this, 0LL);
		  if ( !scheme )
		    sub_1800D8260(v6, v5);
		  this->fields._scheme = IniParser::Configuration::IniScheme::DeepClone(scheme, 0LL);
		  sub_18002D1B0((ILFixDynamicMethodWrapper_2 *)&this->fields._scheme, v7, v8, v9, v10, v11);
		}
		
		public IniData(IniData ori) {} // 0x0000000189B31410-0x0000000189B31498
	
		// Methods
		public void Clear() {} // 0x00000001835A79C0-0x00000001835A7A00
		// Void Clear()
		void IniParser::IniData::Clear(IniData *this, MethodInfo *method)
		{
		  PropertyCollection *Global_k__BackingField; // rcx
		
		  Global_k__BackingField = this->fields._Global_k__BackingField;
		  if ( !Global_k__BackingField
		    || (IniParser::Model::PropertyCollection::Clear(Global_k__BackingField, 0LL),
		        (Global_k__BackingField = (PropertyCollection *)this->fields._Sections_k__BackingField) == 0LL) )
		  {
		    sub_1800D8260(Global_k__BackingField, method);
		  }
		  IniParser::Model::SectionCollection::Clear((SectionCollection *)Global_k__BackingField, 0LL);
		}
		
		public void ClearAllComments() {} // 0x0000000189B31260-0x0000000189B3137C
		// Void ClearAllComments()
		// Hidden C++ exception states: #wind=1
		void IniParser::IniData::ClearAllComments(IniData *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  SectionCollection *Sections_k__BackingField; // rbx
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Section *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Section *v13; // rbx
		  __int64 v14; // rdx
		  PropertyCollection *Properties_k__BackingField; // rcx
		  _QWORD v16[4]; // [rsp+28h] [rbp-20h] BYREF
		  IEnumerator_1_IniParser_Model_Section_ *Enumerator; // [rsp+50h] [rbp+8h] BYREF
		
		  if ( !this->fields._Global_k__BackingField )
		    sub_1800D8260(this, method);
		  IniParser::Model::PropertyCollection::ClearComments(this->fields._Global_k__BackingField, 0LL);
		  Sections_k__BackingField = this->fields._Sections_k__BackingField;
		  if ( !Sections_k__BackingField )
		    sub_1800D8260(v4, v3);
		  Enumerator = IniParser::Model::SectionCollection::GetEnumerator(Sections_k__BackingField, 0LL);
		  v16[0] = 0LL;
		  v16[1] = &Enumerator;
		  while ( 1 )
		  {
		    if ( !Enumerator )
		      sub_1800D8250(v7, v6);
		    if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
		      break;
		    if ( !Enumerator )
		      sub_1800D8250(v9, v8);
		    v10 = (Section *)sub_18006E140();
		    v13 = v10;
		    if ( !v10 )
		      sub_1800D8250(v12, v11);
		    IniParser::Model::Section::ClearComments(v10, 0LL);
		    Properties_k__BackingField = v13->fields._Properties_k__BackingField;
		    if ( !Properties_k__BackingField )
		      sub_1800D8250(0LL, v14);
		    IniParser::Model::PropertyCollection::ClearComments(Properties_k__BackingField, 0LL);
		  }
		  sub_1801F6A10(v16);
		}
		
		public void Merge(IniData toMergeIniData) {} // 0x0000000189B313C0-0x0000000189B31410
		// Void Merge(IniData)
		void IniParser::IniData::Merge(IniData *this, IniData *toMergeIniData, MethodInfo *method)
		{
		  PropertyCollection *Global_k__BackingField; // rcx
		
		  if ( toMergeIniData )
		  {
		    Global_k__BackingField = this->fields._Global_k__BackingField;
		    if ( !Global_k__BackingField
		      || (IniParser::Model::PropertyCollection::Merge(
		            Global_k__BackingField,
		            toMergeIniData->fields._Global_k__BackingField,
		            0LL),
		          (Global_k__BackingField = (PropertyCollection *)this->fields._Sections_k__BackingField) == 0LL) )
		    {
		      sub_1800D8260(Global_k__BackingField, toMergeIniData);
		    }
		    IniParser::Model::SectionCollection::Merge(
		      (SectionCollection *)Global_k__BackingField,
		      toMergeIniData->fields._Sections_k__BackingField,
		      0LL);
		  }
		}
		
		public IniData DeepClone() => default; // 0x0000000189B3137C-0x0000000189B313C0
		// IniData DeepClone()
		IniData *IniParser::IniData::DeepClone(IniData *this, MethodInfo *method)
		{
		  IniData *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  IniData *v6; // rbx
		
		  v3 = (IniData *)sub_18002C620(TypeInfo::IniParser::IniData);
		  v6 = v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  IniParser::IniData::IniData(v3, this, 0LL);
		  return v6;
		}
		
	}
}
