using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGRainAndWetnessSettingParameters // TypeDefIndex: 38598
	{
		// Fields
		public static readonly string FEATURE_NAME; // 0x00
	
		// Properties
		public SettingParameter<bool> EnableRainWetnessHighQuality { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		// IValueSource get_source()
		IValueSource *Beyond::ValueAdapter<Beyond::GameSetting::ScreenResolution>::get_source(
		        ValueAdapter_1_GameSetting_ScreenResolution_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_source;
		}
		
		public SettingParameter<int> RainOcclusionMapSize { get; } // 0x000000018385B100-0x000000018385B110 
		// Object System.Collections.IEnumerator.get_Current()
		Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
		        HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
		        MethodInfo *method)
		{
		  return (Object *)this->fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
		}
		
		public SettingParameter<int> RainOcclusionMapOverrideRange { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		// Func`1[Single] get_getValueDelegate()
		Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
		        ValueWatcher_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
		}
		
		public SettingParameter<bool> RainSplashEnabled { get; } // 0x0000000184D86240-0x0000000184D86250 
		// Func`1[Object] get_getValueDelegate()
		Func_1_Object_ *Rewired::Utils::Classes::Utility::ValueWatcher<System::Object>::get_getValueDelegate(
		        ValueWatcher_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
		}
		
		public SettingParameter<int> RainSplashMaxCount { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		// IList`1[System.Object] HkgvubNsiKaMGZpZDhgJNXzxwNEY()
		IList_1_System_Object_ *aDnpaQcaHrbMtqQtSgzqebcYvhXN<System::Object>::HkgvubNsiKaMGZpZDhgJNXzxwNEY(
		        aDnpaQcaHrbMtqQtSgzqebcYvhXN_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.YbVoRkZMMUxLLJcbAdHsvRhntcjw;
		}
		
		public SettingParameter<float> ScreenRainDropPercent { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		// IUnit get_destinationUnit()
		IUnit *Unity::VisualScripting::UnitConnection<System::Object,System::Object>::get_destinationUnit(
		        UnitConnection_2_System_Object_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields._destinationUnit_k__BackingField;
		}
		
		public SettingParameter<bool> EnableMiddleDistRain { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		// ValueHandler`1[UnityEngine.Vector4] get_getter()
		ValueHandler_1_UnityEngine_Vector4_ *FlowCanvas::ValueOutput<UnityEngine::Vector4>::get_getter(
		        ValueOutput_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return this->fields._getter_k__BackingField;
		}
		
		public SettingParameter<bool> EnableRainWave { get; } // 0x0000000184D86200-0x0000000184D86210 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::Vector2>::get_propertyPath(
		        Variable_1_UnityEngine_Vector2_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public SettingParameter<bool> EnableRainLighting { get; } // 0x0000000184D86270-0x0000000184D86280 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::Vector4>::get_propertyPath(
		        Variable_1_UnityEngine_Vector4_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
		public SettingParameter<int> SceneEffectRainLayerCount { get; } // 0x0000000182E56440-0x0000000182E56460 
		// String get_propertyPath()
		String *NodeCanvas::Framework::Variable<UnityEngine::Ray>::get_propertyPath(
		        Variable_1_UnityEngine_Ray_ *this,
		        MethodInfo *method)
		{
		  return this->fields._propertyPath;
		}
		
	
		// Constructors
		public HGRainAndWetnessSettingParameters() {} // 0x000000018474DE40-0x000000018474E080
		// HGRainAndWetnessSettingParameters()
		void HG::Rendering::Runtime::HGRainAndWetnessSettingParameters::HGRainAndWetnessSettingParameters(
		        HGRainAndWetnessSettingParameters *this,
		        MethodInfo *method)
		{
		  struct HGRainAndWetnessSettingParameters__Class *v2; // rax
		  Type *v4; // rdx
		  PropertyInfo_1 *v5; // r8
		  Int32__Array **v6; // r9
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  Type *v28; // rdx
		  PropertyInfo_1 *v29; // r8
		  Int32__Array **v30; // r9
		  Type *v31; // rdx
		  PropertyInfo_1 *v32; // r8
		  Int32__Array **v33; // r9
		  MethodInfo *v34; // [rsp+20h] [rbp-8h]
		  MethodInfo *v35; // [rsp+20h] [rbp-8h]
		  MethodInfo *v36; // [rsp+20h] [rbp-8h]
		  MethodInfo *v37; // [rsp+20h] [rbp-8h]
		  MethodInfo *v38; // [rsp+20h] [rbp-8h]
		  MethodInfo *v39; // [rsp+20h] [rbp-8h]
		  MethodInfo *v40; // [rsp+20h] [rbp-8h]
		  MethodInfo *v41; // [rsp+20h] [rbp-8h]
		  MethodInfo *v42; // [rsp+20h] [rbp-8h]
		  MethodInfo *v43; // [rsp+50h] [rbp+28h]
		
		  v2 = TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters);
		    v2 = TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters;
		  }
		  this->fields._EnableRainWetnessHighQuality_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                                 0,
		                                                                 v2->static_fields->FEATURE_NAME,
		                                                                 (String *)"EnableRainWetnessHighQuality",
		                                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v4, v5, v6, v34);
		  this->fields._RainOcclusionMapSize_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                         256,
		                                                         TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters->static_fields->FEATURE_NAME,
		                                                         (String *)"RainOcclusionMapSize",
		                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._RainOcclusionMapSize_k__BackingField, v7, v8, v9, v35);
		  this->fields._RainOcclusionMapOverrideRange_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                  64,
		                                                                  TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters->static_fields->FEATURE_NAME,
		                                                                  (String *)"RainOcclusionMapOverrideRange",
		                                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._RainOcclusionMapOverrideRange_k__BackingField, v10, v11, v12, v36);
		  this->fields._RainSplashEnabled_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                      0,
		                                                      TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters->static_fields->FEATURE_NAME,
		                                                      (String *)"RainSplashEnabled",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._RainSplashEnabled_k__BackingField, v13, v14, v15, v37);
		  this->fields._RainSplashMaxCount_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                       1000,
		                                                       TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters->static_fields->FEATURE_NAME,
		                                                       (String *)"RainSplashMaxCount",
		                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._RainSplashMaxCount_k__BackingField, v16, v17, v18, v38);
		  this->fields._EnableMiddleDistRain_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                         0,
		                                                         TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters->static_fields->FEATURE_NAME,
		                                                         (String *)"EnableMiddleDistRain",
		                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._EnableMiddleDistRain_k__BackingField, v19, v20, v21, v39);
		  this->fields._EnableRainWave_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                   0,
		                                                   TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters->static_fields->FEATURE_NAME,
		                                                   (String *)"EnableRainWave",
		                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._EnableRainWave_k__BackingField, v22, v23, v24, v40);
		  this->fields._EnableRainLighting_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                       0,
		                                                       TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters->static_fields->FEATURE_NAME,
		                                                       (String *)"EnableRainLighting",
		                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._EnableRainLighting_k__BackingField, v25, v26, v27, v41);
		  this->fields._ScreenRainDropPercent_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                          1.0,
		                                                          TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters->static_fields->FEATURE_NAME,
		                                                          (String *)"ScreenRainDropPercent",
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._ScreenRainDropPercent_k__BackingField, v28, v29, v30, v42);
		  this->fields._SceneEffectRainLayerCount_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                              1,
		                                                              TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters->static_fields->FEATURE_NAME,
		                                                              (String *)"SceneEffectRainLayerCount",
		                                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields._SceneEffectRainLayerCount_k__BackingField, v31, v32, v33, v43);
		}
		
		static HGRainAndWetnessSettingParameters() {} // 0x0000000184D80290-0x0000000184D802C0
		// HGRainAndWetnessSettingParameters()
		void HG::Rendering::Runtime::HGRainAndWetnessSettingParameters::cctor(MethodInfo *method)
		{
		  Type *v1; // rdx
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters->static_fields->FEATURE_NAME = (String *)"RainAndWetness";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGRainAndWetnessSettingParameters->static_fields,
		    v1,
		    v2,
		    v3,
		    v4);
		}
		
	}
}
