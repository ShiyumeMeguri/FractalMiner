using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGVerticalOcclusionMapSettingParameters // TypeDefIndex: 38600
	{
		// Fields
		public static readonly string FEATURE_NAME; // 0x00
	
		// Properties
		public SettingParameter<int> DepthOcclusionMapSize { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		// IValueSource get_source()
		IValueSource *Beyond::ValueAdapter<Beyond::GameSetting::ScreenResolution>::get_source(
		        ValueAdapter_1_GameSetting_ScreenResolution_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_source;
		}
		
		public SettingParameter<int> DepthOcclusionMapRange { get; } // 0x000000018385B100-0x000000018385B110 
		// Object System.Collections.IEnumerator.get_Current()
		Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
		        HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
		        MethodInfo *method)
		{
		  return (Object *)this->fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
		}
		
	
		// Constructors
		public HGVerticalOcclusionMapSettingParameters() {} // 0x0000000184B0BC30-0x0000000184B0BCD0
		// HGVerticalOcclusionMapSettingParameters()
		void HG::Rendering::Runtime::HGVerticalOcclusionMapSettingParameters::HGVerticalOcclusionMapSettingParameters(
		        HGVerticalOcclusionMapSettingParameters *this,
		        MethodInfo *method)
		{
		  struct HGVerticalOcclusionMapSettingParameters__Class *v2; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  HGRuntimeGrassQuery_Node *v5; // r8
		  Int32__Array **v6; // r9
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		  MethodInfo *v11; // [rsp+50h] [rbp+28h]
		
		  v2 = TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapSettingParameters;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapSettingParameters->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapSettingParameters);
		    v2 = TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapSettingParameters;
		  }
		  this->fields._DepthOcclusionMapSize_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                          256,
		                                                          v2->static_fields->FEATURE_NAME,
		                                                          (String *)"VerticalOcclusionMapSize",
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v4, v5, v6, v10);
		  this->fields._DepthOcclusionMapRange_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                           100,
		                                                           TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapSettingParameters->static_fields->FEATURE_NAME,
		                                                           (String *)"VerticalOcclusionMapRange",
		                                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._DepthOcclusionMapRange_k__BackingField, v7, v8, v9, v11);
		}
		
		static HGVerticalOcclusionMapSettingParameters() {} // 0x0000000184D801D0-0x0000000184D80200
		// HGVerticalOcclusionMapSettingParameters()
		void HG::Rendering::Runtime::HGVerticalOcclusionMapSettingParameters::cctor(MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v1; // rdx
		  HGRuntimeGrassQuery_Node *v2; // r8
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapSettingParameters->static_fields->FEATURE_NAME = (String *)"VerticalOcclusionMap";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGVerticalOcclusionMapSettingParameters->static_fields,
		    v1,
		    v2,
		    v3,
		    v4);
		}
		
	}
}
