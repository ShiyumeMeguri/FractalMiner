using System;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class IntScalableSetting : ScalableSetting<int>
	{
		public IntScalableSetting(int[] values, ScalableSettingSchemaId schemaId)
		{
			// // IntScalableSetting(Int32[], ScalableSettingSchemaId)
			// void HG::Rendering::Runtime::IntScalableSetting::IntScalableSetting(
			//         IntScalableSetting *this,
			//         Int32__Array *values,
			//         ScalableSettingSchemaId schemaId,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D91968D )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::ScalableSetting<int>::ScalableSetting);
			//     byte_18D91968D = 1;
			//   }
			//   HG::Rendering::Runtime::ScalableSetting<unsigned int>::ScalableSetting(
			//     (ScalableSetting_1_System_UInt32_ *)this,
			//     (UInt32__Array *)values,
			//     schemaId,
			//     MethodInfo::HG::Rendering::Runtime::ScalableSetting<int>::ScalableSetting);
			// }
			// 
		}
	}
}
