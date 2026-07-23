using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class BoolScalableSetting : ScalableSetting<bool> // TypeDefIndex: 38558
	{
		// Constructors
		public BoolScalableSetting() {} // Dummy constructor
		public BoolScalableSetting(bool[] values, ScalableSettingSchemaId schemaId) {} // 0x0000000189C04574-0x0000000189C04580
		// BoolScalableSetting(Boolean[], ScalableSettingSchemaId)
		void HG::Rendering::Runtime::BoolScalableSetting::BoolScalableSetting(
		        BoolScalableSetting *this,
		        Boolean__Array *values,
		        ScalableSettingSchemaId schemaId,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::ScalableSetting<unsigned int>::ScalableSetting(
		    (ScalableSetting_1_System_UInt32_ *)this,
		    (UInt32__Array *)values,
		    schemaId,
		    MethodInfo::HG::Rendering::Runtime::ScalableSetting<bool>::ScalableSetting);
		}
		
	}
}
