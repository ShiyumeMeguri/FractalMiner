using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IniParser;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IniParser.Configuration
{
	public class IniFormattingConfiguration : IDeepCloneable<IniFormattingConfiguration> // TypeDefIndex: 37387
	{
		// Fields
		private uint _numSpacesBetweenKeyAndAssigment; // 0x2C
		private uint _numSpacesBetweenAssigmentAndValue; // 0x30
	
		// Properties
		public string NewLineString { get => default; } // 0x0000000189B31654-0x0000000189B31668 
		// String get_NewLineString()
		String *IniParser::Configuration::IniFormattingConfiguration::get_NewLineString(
		        IniFormattingConfiguration *this,
		        MethodInfo *method)
		{
		  String *result; // rax
		
		  result = (String *)"\n";
		  if ( !this->fields._NewLineType_k__BackingField )
		    return (String *)"\r\n";
		  return result;
		}
		
		public ENewLine NewLineType { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		// MjfRFftkTcBeBOoxrCKsCyjeiVkX get_Current()
		MjfRFftkTcBeBOoxrCKsCyjeiVkX Rewired::Utils::Classes::Data::RingBuffer_1_T_::VFEweixJrFjiYwjUzBFjtcEMiCZW<MjfRFftkTcBeBOoxrCKsCyjeiVkX>::get_Current(
		        RingBuffer_1_T_VFEweixJrFjiYwjUzBFjtcEMiCZW_MjfRFftkTcBeBOoxrCKsCyjeiVkX_ *this,
		        MethodInfo *method)
		{
		  return this->current;
		}
		

		// UpdateLoopDataSet`1[T]+yGyjUqbndvpPzKlyNzUYInPtwsHF[System.Object](UpdateLoopType)
		void Rewired::UpdateLoopDataSet_1_T_::yGyjUqbndvpPzKlyNzUYInPtwsHF<System::Object>::yGyjUqbndvpPzKlyNzUYInPtwsHF(
		        UpdateLoopDataSet_1_T_yGyjUqbndvpPzKlyNzUYInPtwsHF_System_Object_ *this,
		        UpdateLoopType__Enum param_000585ac,
		        MethodInfo *method)
		{
		  this->fields.URsVCNeXtjuGuUuIdAEYavYwEgUe = param_000585ac;
		}
		
		public uint NumSpacesBetweenKeyAndAssigment { set {} } // 0x0000000189B31694-0x0000000189B316C0
		// Void set_NumSpacesBetweenKeyAndAssigment(UInt32)
		void IniParser::Configuration::IniFormattingConfiguration::set_NumSpacesBetweenKeyAndAssigment(
		        IniFormattingConfiguration *this,
		        uint32_t value,
		        MethodInfo *method)
		{
		  UberPostPassUtils_ColorGradingData **v4; // rdx
		  VolumetricPipelineRT **v5; // r8
		  VolumetricPipelineRT **v6; // r9
		  VolumetricPipelineRT **v7; // [rsp+50h] [rbp+28h]
		  MethodInfo *v8; // [rsp+58h] [rbp+30h]
		
		  this->fields._numSpacesBetweenKeyAndAssigment = value;
		  this->fields._SpacesBetweenKeyAndAssigment_k__BackingField = System::String::Ctor(0x20u, value, 0LL);
		  sub_18002D1B0(
		    (ILFixDynamicMethodWrapper_2 *)&this->fields._SpacesBetweenKeyAndAssigment_k__BackingField,
		    v4,
		    v5,
		    v6,
		    v7,
		    v8);
		}
		
		public string SpacesBetweenKeyAndAssigment { get; private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
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
		
		public uint NumSpacesBetweenAssigmentAndValue { set {} } // 0x0000000189B31668-0x0000000189B31694
		// Void set_NumSpacesBetweenAssigmentAndValue(UInt32)
		void IniParser::Configuration::IniFormattingConfiguration::set_NumSpacesBetweenAssigmentAndValue(
		        IniFormattingConfiguration *this,
		        uint32_t value,
		        MethodInfo *method)
		{
		  UberPostPassUtils_ColorGradingData **v4; // rdx
		  VolumetricPipelineRT **v5; // r8
		  VolumetricPipelineRT **v6; // r9
		  VolumetricPipelineRT **v7; // [rsp+50h] [rbp+28h]
		  MethodInfo *v8; // [rsp+58h] [rbp+30h]
		
		  this->fields._numSpacesBetweenAssigmentAndValue = value;
		  this->fields._SpacesBetweenAssigmentAndValue_k__BackingField = System::String::Ctor(0x20u, value, 0LL);
		  sub_18002D1B0(
		    (ILFixDynamicMethodWrapper_2 *)&this->fields._SpacesBetweenAssigmentAndValue_k__BackingField,
		    v4,
		    v5,
		    v6,
		    v7,
		    v8);
		}
		
		public string SpacesBetweenAssigmentAndValue { get; private set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
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
		
		public bool NewLineBeforeSection { get; set; } // 0x00000001811F33C0-0x00000001811F33D0 0x00000001811F33D0-0x00000001811F33E0
		// Boolean get_isRunning()
		bool UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::get_isRunning(
		        ValueAnimation_1_StyleValues_ *this,
		        MethodInfo *method)
		{
		  return this->fields._isRunning_k__BackingField;
		}
		

		// Void set_isRunning(Boolean)
		void UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::set_isRunning(
		        ValueAnimation_1_StyleValues_ *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields._isRunning_k__BackingField = value;
		}
		
		public bool NewLineAfterSection { get; set; } // 0x0000000184D867B0-0x0000000184D867C0 0x0000000184D867C0-0x0000000184D867D0
		// Boolean get_defaultValue()
		bool HG::Rendering::Runtime::SettingParameter<bool>::get_defaultValue(
		        SettingParameter_1_System_Boolean_ *this,
		        MethodInfo *method)
		{
		  return this->fields._defaultValue_k__BackingField;
		}
		

		// Void set_defaultValue(Boolean)
		void HG::Rendering::Runtime::SettingParameter<bool>::set_defaultValue(
		        SettingParameter_1_System_Boolean_ *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields._defaultValue_k__BackingField = value;
		}
		
		public bool NewLineAfterProperty { get; set; } // 0x0000000184D86CA0-0x0000000184D86CB0 0x0000000184D86CD0-0x0000000184D86CE0
		// Boolean get_isMaterialAvailable()
		bool CriWare::CriManaMovieMaterialBase::get_isMaterialAvailable(CriManaMovieMaterialBase *this, MethodInfo *method)
		{
		  return this->fields._isMaterialAvailable_k__BackingField;
		}
		

		// Void set_isMaterialAvailable(Boolean)
		void CriWare::CriManaMovieMaterialBase::set_isMaterialAvailable(
		        CriManaMovieMaterialBase *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields._isMaterialAvailable_k__BackingField = value;
		}
		
		public bool NewLineBeforeProperty { get; set; } // 0x0000000184D86C90-0x0000000184D86CA0 0x0000000184D86CC0-0x0000000184D86CD0
		// Boolean get_NewLineBeforeProperty()
		bool IniParser::Configuration::IniFormattingConfiguration::get_NewLineBeforeProperty(
		        IniFormattingConfiguration *this,
		        MethodInfo *method)
		{
		  return this->fields._NewLineBeforeProperty_k__BackingField;
		}
		

		// Void set_rendererPriority(Boolean)
		void UnityEngine::Rendering::SupportedRenderingFeatures::set_rendererPriority(
		        SupportedRenderingFeatures *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields._rendererPriority_k__BackingField = value;
		}
		
	
		// Nested types
		public enum ENewLine // TypeDefIndex: 37386
		{
			Windows = 0,
			Unix_Mac = 1
		}
	
		// Constructors
		public IniFormattingConfiguration() {} // 0x0000000189B315F8-0x0000000189B31654
		// IniFormattingConfiguration()
		void IniParser::Configuration::IniFormattingConfiguration::IniFormattingConfiguration(
		        IniFormattingConfiguration *this,
		        MethodInfo *method)
		{
		  String *NewLine; // rax
		  bool v4; // al
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  NewLine = System::Environment::get_NewLine(0LL);
		  v4 = System::String::Equals(NewLine, (String *)"\r\n", 0LL);
		  if ( !this )
		    sub_1800D8260(v6, v5);
		  this->fields._NewLineType_k__BackingField = !v4;
		  IniParser::Configuration::IniFormattingConfiguration::set_NumSpacesBetweenAssigmentAndValue(this, 1u, 0LL);
		  IniParser::Configuration::IniFormattingConfiguration::set_NumSpacesBetweenKeyAndAssigment(this, 1u, 0LL);
		}
		
	
		// Methods
		public IniFormattingConfiguration DeepClone() => default; // 0x0000000189B315DC-0x0000000189B315F8
		// IniFormattingConfiguration DeepClone()
		IniFormattingConfiguration *IniParser::Configuration::IniFormattingConfiguration::DeepClone(
		        IniFormattingConfiguration *this,
		        MethodInfo *method)
		{
		  __int64 v2; // rax
		
		  v2 = System::CharEnumerator::Clone((System::CharEnumerator *)this);
		  return (IniFormattingConfiguration *)sub_180005050(v2, TypeInfo::IniParser::Configuration::IniFormattingConfiguration);
		}
		
	}
}
