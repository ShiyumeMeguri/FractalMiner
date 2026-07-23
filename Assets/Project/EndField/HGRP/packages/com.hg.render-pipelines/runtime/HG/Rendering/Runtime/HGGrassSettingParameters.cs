using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGGrassSettingParameters // TypeDefIndex: 37996
	{
		// Fields
		public static readonly string FEATURE_NAME; // 0x00
		public SettingParameter<float> grassGlobalSparsity; // 0x10
	
		// Constructors
		public HGGrassSettingParameters() {} // 0x0000000184D14C40-0x0000000184D14CA0
		// HGGrassSettingParameters()
		void HG::Rendering::Runtime::HGGrassSettingParameters::HGGrassSettingParameters(
		        HGGrassSettingParameters *this,
		        MethodInfo *method)
		{
		  struct HGGrassSettingParameters__Class *v2; // rax
		  Type *v4; // rdx
		  PropertyInfo_1 *v5; // r8
		  Int32__Array **v6; // r9
		  MethodInfo *v7; // [rsp+50h] [rbp+28h]
		
		  v2 = TypeInfo::HG::Rendering::Runtime::HGGrassSettingParameters;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGGrassSettingParameters->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGGrassSettingParameters);
		    v2 = TypeInfo::HG::Rendering::Runtime::HGGrassSettingParameters;
		  }
		  this->fields.grassGlobalSparsity = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                       1.0,
		                                       v2->static_fields->FEATURE_NAME,
		                                       (String *)"GrassGlobalSparsity",
		                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v4, v5, v6, v7);
		}
		
		static HGGrassSettingParameters() {} // 0x0000000184D80320-0x0000000184D80350
		// HGGrassSettingParameters()
		void HG::Rendering::Runtime::HGGrassSettingParameters::cctor(MethodInfo *method)
		{
		  Type *v1; // rdx
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::HGGrassSettingParameters->static_fields->FEATURE_NAME = (String *)"Grass";
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGGrassSettingParameters->static_fields,
		    v1,
		    v2,
		    v3,
		    v4);
		}
		
	}
}
