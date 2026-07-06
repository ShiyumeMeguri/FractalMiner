using System;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class UintScalableSetting : ScalableSetting<uint>
	{
		public UintScalableSetting(uint[] values, ScalableSettingSchemaId schemaId)
		{
			// // UintScalableSetting(UInt32[], ScalableSettingSchemaId)
			// void HG::Rendering::Runtime::UintScalableSetting::UintScalableSetting(
			//         UintScalableSetting *this,
			//         UInt32__Array *values,
			//         ScalableSettingSchemaId schemaId,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D91968E )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::ScalableSetting<unsigned int>::ScalableSetting);
			//     byte_18D91968E = 1;
			//   }
			//   HG::Rendering::Runtime::ScalableSetting<unsigned int>::ScalableSetting(
			//     (ScalableSetting_1_System_UInt32_ *)this,
			//     values,
			//     schemaId,
			//     MethodInfo::HG::Rendering::Runtime::ScalableSetting<unsigned int>::ScalableSetting);
			// }
			// 
		}
	}
}
