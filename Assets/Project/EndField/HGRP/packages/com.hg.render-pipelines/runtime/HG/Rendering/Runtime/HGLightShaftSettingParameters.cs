using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGLightShaftSettingParameters // TypeDefIndex: 38382
	{
		// Fields
		public const string FEATURE_NAME = "LightShaft"; // Metadata: 0x02303CC3
		public readonly SettingParameter<bool> enableLightShaft; // 0x10
		public readonly SettingParameter<int> lightShaftSampleNum; // 0x18
		public readonly SettingParameter<float> lightShaftDownSampleFactor; // 0x20
		public readonly SettingParameter<int> lightShaftBlurPassCount; // 0x28
	
		// Constructors
		public HGLightShaftSettingParameters() {} // 0x00000001849E2810-0x00000001849E28D0
		// HGLightShaftSettingParameters()
		void HG::Rendering::Runtime::HGLightShaftSettingParameters::HGLightShaftSettingParameters(
		        HGLightShaftSettingParameters *this,
		        MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		  MethodInfo *v18; // [rsp+50h] [rbp+28h]
		
		  this->fields.enableLightShaft = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                    1,
		                                    (String *)"LightShaft",
		                                    (String *)"enableLightShaft",
		                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v3, v4, v5, v15);
		  this->fields.lightShaftSampleNum = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                       12,
		                                       (String *)"LightShaft",
		                                       (String *)"lightShaftSampleNum",
		                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.lightShaftSampleNum, v6, v7, v8, v16);
		  this->fields.lightShaftDownSampleFactor = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                              2.0,
		                                              (String *)"LightShaft",
		                                              (String *)"lightShaftDownSampleFactor",
		                                              MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.lightShaftDownSampleFactor, v9, v10, v11, v17);
		  this->fields.lightShaftBlurPassCount = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                           3,
		                                           (String *)"LightShaft",
		                                           (String *)"lightShaftBlurPassCount",
		                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.lightShaftBlurPassCount, v12, v13, v14, v18);
		}
		
	}
}
