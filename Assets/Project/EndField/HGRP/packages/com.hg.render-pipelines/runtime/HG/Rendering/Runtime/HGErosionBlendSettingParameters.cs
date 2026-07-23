using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGErosionBlendSettingParameters // TypeDefIndex: 38597
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
		
	
		// Constructors
		public HGErosionBlendSettingParameters() {} // 0x0000000184CC86E0-0x0000000184CC8740
		// HGErosionBlendSettingParameters()
		void HG::Rendering::Runtime::HGErosionBlendSettingParameters::HGErosionBlendSettingParameters(
		        HGErosionBlendSettingParameters *this,
		        MethodInfo *method)
		{
		  struct HGErosionBlendSettingParameters__Class *v2; // rax
		  Type *v4; // rdx
		  PropertyInfo_1 *v5; // r8
		  Int32__Array **v6; // r9
		  MethodInfo *v7; // [rsp+50h] [rbp+28h]
		
		  v2 = TypeInfo::HG::Rendering::Runtime::HGErosionBlendSettingParameters;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGErosionBlendSettingParameters->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGErosionBlendSettingParameters);
		    v2 = TypeInfo::HG::Rendering::Runtime::HGErosionBlendSettingParameters;
		  }
		  this->fields._Enable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                           0,
		                                           v2->static_fields->FEATURE_NAME,
		                                           (String *)"Enable",
		                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v4, v5, v6, v7);
		}
		
		static HGErosionBlendSettingParameters() {} // 0x0000000184D80350-0x0000000184D80380
		// HGErosionBlendSettingParameters()
		void HG::Rendering::Runtime::HGErosionBlendSettingParameters::cctor(MethodInfo *method)
		{
		  Type *v1; // rdx
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::HGErosionBlendSettingParameters->static_fields->FEATURE_NAME = (String *)"ErosionBlend";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGErosionBlendSettingParameters->static_fields,
		    v1,
		    v2,
		    v3,
		    v4);
		}
		
	}
}
