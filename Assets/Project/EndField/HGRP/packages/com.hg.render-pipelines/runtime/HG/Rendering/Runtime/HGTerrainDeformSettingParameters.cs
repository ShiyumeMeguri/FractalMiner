using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGTerrainDeformSettingParameters // TypeDefIndex: 38596
	{
		// Fields
		public static readonly string FEATURE_NAME; // 0x00
	
		// Properties
		public SettingParameter<bool> Enable { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		// IValueSource get_source()
		IValueSource *Beyond::ValueAdapter<Beyond::GameSetting::ScreenResolution>::get_source(
		        ValueAdapter_1_GameSetting_ScreenResolution_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_source;
		}
		
		public SettingParameter<int> SubdMode { get; } // 0x000000018385B100-0x000000018385B110 
		// Object System.Collections.IEnumerator.get_Current()
		Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
		        HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
		        MethodInfo *method)
		{
		  return (Object *)this->fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
		}
		
		public SettingParameter<int> SubdModeV2 { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		// Func`1[Single] get_getValueDelegate()
		Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
		        ValueWatcher_1_System_Single_ *this,
		        MethodInfo *method)
		{
		  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
		}
		
		public SettingParameter<int> GpuSubd { get; } // 0x0000000184D86240-0x0000000184D86250 
		// Func`1[Object] get_getValueDelegate()
		Func_1_Object_ *Rewired::Utils::Classes::Utility::ValueWatcher<System::Object>::get_getValueDelegate(
		        ValueWatcher_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
		}
		
		public SettingParameter<int> PrimitivePixelLengthTargetLog2 { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		// IList`1[System.Object] HkgvubNsiKaMGZpZDhgJNXzxwNEY()
		IList_1_System_Object_ *aDnpaQcaHrbMtqQtSgzqebcYvhXN<System::Object>::HkgvubNsiKaMGZpZDhgJNXzxwNEY(
		        aDnpaQcaHrbMtqQtSgzqebcYvhXN_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  return this->fields.YbVoRkZMMUxLLJcbAdHsvRhntcjw;
		}
		
	
		// Constructors
		public HGTerrainDeformSettingParameters() {} // 0x00000001848AD230-0x00000001848AD370
		// HGTerrainDeformSettingParameters()
		void HG::Rendering::Runtime::HGTerrainDeformSettingParameters::HGTerrainDeformSettingParameters(
		        HGTerrainDeformSettingParameters *this,
		        MethodInfo *method)
		{
		  struct HGTerrainDeformSettingParameters__Class *v2; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  HGRuntimeGrassQuery_Node *v5; // r8
		  Int32__Array **v6; // r9
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+50h] [rbp+28h]
		
		  v2 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformSettingParameters;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGTerrainDeformSettingParameters->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGTerrainDeformSettingParameters);
		    v2 = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformSettingParameters;
		  }
		  this->fields._Enable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                           0,
		                                           v2->static_fields->FEATURE_NAME,
		                                           (String *)"Enable",
		                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v4, v5, v6, v19);
		  this->fields._SubdMode_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                             2,
		                                             TypeInfo::HG::Rendering::Runtime::HGTerrainDeformSettingParameters->static_fields->FEATURE_NAME,
		                                             (String *)"SubdMode",
		                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._SubdMode_k__BackingField, v7, v8, v9, v20);
		  this->fields._SubdModeV2_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                               2,
		                                               TypeInfo::HG::Rendering::Runtime::HGTerrainDeformSettingParameters->static_fields->FEATURE_NAME,
		                                               (String *)"SubdModeV2",
		                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._SubdModeV2_k__BackingField, v10, v11, v12, v21);
		  this->fields._GpuSubd_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                            3,
		                                            TypeInfo::HG::Rendering::Runtime::HGTerrainDeformSettingParameters->static_fields->FEATURE_NAME,
		                                            (String *)"GpuSubd",
		                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._GpuSubd_k__BackingField, v13, v14, v15, v22);
		  this->fields._PrimitivePixelLengthTargetLog2_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                                   3,
		                                                                   TypeInfo::HG::Rendering::Runtime::HGTerrainDeformSettingParameters->static_fields->FEATURE_NAME,
		                                                                   (String *)"PrimitivePixelLengthTargetLog2",
		                                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields._PrimitivePixelLengthTargetLog2_k__BackingField,
		    v16,
		    v17,
		    v18,
		    v23);
		}
		
		static HGTerrainDeformSettingParameters() {} // 0x0000000184D80200-0x0000000184D80230
		// HGTerrainDeformSettingParameters()
		void HG::Rendering::Runtime::HGTerrainDeformSettingParameters::cctor(MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v1; // rdx
		  HGRuntimeGrassQuery_Node *v2; // r8
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::HGTerrainDeformSettingParameters->static_fields->FEATURE_NAME = (String *)"TerrainDeform";
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGTerrainDeformSettingParameters->static_fields,
		    v1,
		    v2,
		    v3,
		    v4);
		}
		
	}
}
