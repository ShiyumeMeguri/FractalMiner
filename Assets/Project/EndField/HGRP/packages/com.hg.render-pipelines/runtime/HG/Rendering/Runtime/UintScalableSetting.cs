using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class UintScalableSetting : ScalableSetting<uint> // TypeDefIndex: 38556
	{
		// Constructors
		public UintScalableSetting() {} // Dummy constructor
		public UintScalableSetting(uint[] values, ScalableSettingSchemaId schemaId) {} // 0x0000000189C12DF4-0x0000000189C12E00
		// UintScalableSetting(UInt32[], ScalableSettingSchemaId)
		void HG::Rendering::Runtime::UintScalableSetting::UintScalableSetting(
		        UintScalableSetting *this,
		        UInt32__Array *values,
		        ScalableSettingSchemaId schemaId,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::ScalableSetting<unsigned int>::ScalableSetting(
		    (ScalableSetting_1_System_UInt32_ *)this,
		    values,
		    schemaId,
		    MethodInfo::HG::Rendering::Runtime::ScalableSetting<unsigned int>::ScalableSetting);
		}
		
	}
}
