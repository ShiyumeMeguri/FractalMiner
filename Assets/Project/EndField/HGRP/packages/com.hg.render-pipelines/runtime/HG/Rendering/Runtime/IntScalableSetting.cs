using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class IntScalableSetting : ScalableSetting<int> // TypeDefIndex: 38555
	{
		// Constructors
		public IntScalableSetting() {} // Dummy constructor
		public IntScalableSetting(int[] values, ScalableSettingSchemaId schemaId) {} // 0x0000000189C1188C-0x0000000189C11898
		// IntScalableSetting(Int32[], ScalableSettingSchemaId)
		void HG::Rendering::Runtime::IntScalableSetting::IntScalableSetting(
		        IntScalableSetting *this,
		        Int32__Array *values,
		        ScalableSettingSchemaId schemaId,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::ScalableSetting<unsigned int>::ScalableSetting(
		    (ScalableSetting_1_System_UInt32_ *)this,
		    (UInt32__Array *)values,
		    schemaId,
		    MethodInfo::HG::Rendering::Runtime::ScalableSetting<int>::ScalableSetting);
		}
		
	}
}
