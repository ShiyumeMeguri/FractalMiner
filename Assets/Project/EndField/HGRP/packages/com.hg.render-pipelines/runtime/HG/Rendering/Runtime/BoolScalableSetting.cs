using System;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class BoolScalableSetting : ScalableSetting<bool>
	{
		public BoolScalableSetting(bool[] values, ScalableSettingSchemaId schemaId)
		{
			// // BoolScalableSetting(Boolean[], ScalableSettingSchemaId)
			// void HG::Rendering::Runtime::BoolScalableSetting::BoolScalableSetting(
			//         BoolScalableSetting *this,
			//         Boolean__Array *values,
			//         ScalableSettingSchemaId schemaId,
			//         MethodInfo *method)
			// {
			//   if ( !byte_18D919690 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::ScalableSetting<bool>::ScalableSetting);
			//     byte_18D919690 = 1;
			//   }
			//   HG::Rendering::Runtime::ScalableSetting<unsigned int>::ScalableSetting(
			//     (ScalableSetting_1_System_UInt32_ *)this,
			//     (UInt32__Array *)values,
			//     schemaId,
			//     MethodInfo::HG::Rendering::Runtime::ScalableSetting<bool>::ScalableSetting);
			// }
			// 
		}
	}
}
