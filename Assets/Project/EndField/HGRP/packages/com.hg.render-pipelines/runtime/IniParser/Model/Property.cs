using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IniParser;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IniParser.Model
{
	public class Property : IDeepCloneable<Property> // TypeDefIndex: 37378
	{
		// Fields
		private List<string> _comments; // 0x20
	
		// Properties
		public List<string> Comments { get => default; set {} } // 0x0000000189B32160-0x0000000189B321BC 0x00000001835A9FB0-0x00000001835AA040
		public string Value { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
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
		
		public string Key { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
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
		
	
		// Constructors
		public Property() {} // Dummy constructor
		public Property(string keyName, string value = "" /* Metadata: 0x02302D3D */) {} // 0x00000001835A9F20-0x00000001835A9F60
		public Property(Property ori) {} // 0x0000000189B32108-0x0000000189B32160
	
		// Methods
		public Property DeepClone() => default; // 0x0000000189B320C4-0x0000000189B32108
		// Property DeepClone()
		Property *IniParser::Model::Property::DeepClone(Property *this, MethodInfo *method)
		{
		  Property *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Property *v6; // rbx
		
		  v3 = (Property *)sub_18002C620(TypeInfo::IniParser::Model::Property);
		  v6 = v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  IniParser::Model::Property::Property(v3, this, 0LL);
		  return v6;
		}
		
	}
}
