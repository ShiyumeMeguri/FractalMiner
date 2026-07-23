using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGSnowSettingParameters // TypeDefIndex: 38599
	{
		// Fields
		public static readonly string FEATURE_NAME; // 0x00
	
		// Properties
		public SettingParameter<bool> EnableSnowLighting { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		// IValueSource get_source()
		IValueSource *Beyond::ValueAdapter<Beyond::GameSetting::ScreenResolution>::get_source(
		        ValueAdapter_1_GameSetting_ScreenResolution_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_source;
		}
		
		public SettingParameter<bool> EnableSnowCollision { get; } // 0x000000018385B100-0x000000018385B110 
		// Object System.Collections.IEnumerator.get_Current()
		Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
		        HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
		        MethodInfo *method)
		{
		  return (Object *)this->fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
		}
		
		public SettingParameter<int> SnowLayerCount { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		// Func`1[Single] get_getValueDelegate()
		Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
		        ValueWatcher_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
		}
		
	
		// Constructors
		public HGSnowSettingParameters() {} // 0x00000001849E2740-0x00000001849E2810
		// HGSnowSettingParameters()
		void HG::Rendering::Runtime::HGSnowSettingParameters::HGSnowSettingParameters(
		        HGSnowSettingParameters *this,
		        MethodInfo *method)
		{
		  struct HGSnowSettingParameters__Class *v2; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  HGRuntimeGrassQuery_Node *v5; // r8
		  Int32__Array **v6; // r9
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+50h] [rbp+28h]
		
		  v2 = TypeInfo::HG::Rendering::Runtime::HGSnowSettingParameters;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGSnowSettingParameters->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGSnowSettingParameters);
		    v2 = TypeInfo::HG::Rendering::Runtime::HGSnowSettingParameters;
		  }
		  this->fields._EnableSnowLighting_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                       0,
		                                                       v2->static_fields->FEATURE_NAME,
		                                                       (String *)"EnableSnownLighting",
		                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v4, v5, v6, v13);
		  this->fields._EnableSnowCollision_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                        0,
		                                                        TypeInfo::HG::Rendering::Runtime::HGSnowSettingParameters->static_fields->FEATURE_NAME,
		                                                        (String *)"EnableSnowCollision",
		                                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._EnableSnowCollision_k__BackingField, v7, v8, v9, v14);
		  this->fields._SnowLayerCount_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                   1,
		                                                   TypeInfo::HG::Rendering::Runtime::HGSnowSettingParameters->static_fields->FEATURE_NAME,
		                                                   (String *)"SnowLayerCount",
		                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._SnowLayerCount_k__BackingField, v10, v11, v12, v15);
		}
		
		static HGSnowSettingParameters() {} // 0x0000000184D80230-0x0000000184D80260
		// HGSnowSettingParameters()
		void HG::Rendering::Runtime::HGSnowSettingParameters::cctor(MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v1; // rdx
		  HGRuntimeGrassQuery_Node *v2; // r8
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::HGSnowSettingParameters->static_fields->FEATURE_NAME = (String *)"Snow";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGSnowSettingParameters->static_fields,
		    v1,
		    v2,
		    v3,
		    v4);
		}
		
	}
}
