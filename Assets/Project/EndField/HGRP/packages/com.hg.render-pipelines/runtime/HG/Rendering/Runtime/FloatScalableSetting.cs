using System;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class FloatScalableSetting : ScalableSetting<float>
	{
		public FloatScalableSetting(float[] values, ScalableSettingSchemaId schemaId)
		{
			// // FloatScalableSetting(Single[], ScalableSettingSchemaId)
			// void HG::Rendering::Runtime::FloatScalableSetting::FloatScalableSetting(
			//         FloatScalableSetting *this,
			//         Single__Array *values,
			//         ScalableSettingSchemaId schemaId,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D91968F )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::ScalableSetting<float>::ScalableSetting);
			//     byte_18D91968F = 1;
			//   }
			//   HG::Rendering::Runtime::ScalableSetting<unsigned int>::ScalableSetting(
			//     (ScalableSetting_1_System_UInt32_ *)this,
			//     (UInt32__Array *)values,
			//     schemaId,
			//     MethodInfo::HG::Rendering::Runtime::ScalableSetting<float>::ScalableSetting);
			// }
			// 
		}
	}
}
