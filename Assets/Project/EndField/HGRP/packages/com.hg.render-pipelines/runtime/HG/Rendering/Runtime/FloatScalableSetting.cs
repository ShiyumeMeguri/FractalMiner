using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class FloatScalableSetting : ScalableSetting<float> // TypeDefIndex: 38557
	{
		// Constructors
		public FloatScalableSetting() {} // Dummy constructor
		public FloatScalableSetting(float[] values, ScalableSettingSchemaId schemaId) {} // 0x0000000189C04580-0x0000000189C0458C
		// FloatScalableSetting(Single[], ScalableSettingSchemaId)
		void HG::Rendering::Runtime::FloatScalableSetting::FloatScalableSetting(
		        FloatScalableSetting *this,
		        Single__Array *values,
		        ScalableSettingSchemaId schemaId,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::ScalableSetting<unsigned int>::ScalableSetting(
		    (ScalableSetting_1_System_UInt32_ *)this,
		    (UInt32__Array *)values,
		    schemaId,
		    MethodInfo::HG::Rendering::Runtime::ScalableSetting<float>::ScalableSetting);
		}
		
	}
}
