using System;

namespace HG.Rendering.Runtime
{
	public class HGGrassSettingParameters
	{
		public HGGrassSettingParameters()
		{
			// // HGGrassSettingParameters()
			// void HG::Rendering::Runtime::HGGrassSettingParameters::HGGrassSettingParameters(
			//         HGGrassSettingParameters *this,
			//         MethodInfo *method)
			// {
			//   struct HGGrassSettingParameters__Class *v3; // rax
			//   OneofDescriptorProto *v4; // rdx
			//   FileDescriptor *v5; // r8
			//   MessageDescriptor *v6; // r9
			//   String__Array *v7; // [rsp+50h] [rbp+28h]
			//   String *v8; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v9; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !byte_18D8ED9B6 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGrassSettingParameters);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//     sub_18003C530(&off_18C8E6CC0);
			//     byte_18D8ED9B6 = 1;
			//   }
			//   v3 = TypeInfo::HG::Rendering::Runtime::HGGrassSettingParameters;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGGrassSettingParameters._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGGrassSettingParameters, method);
			//     v3 = TypeInfo::HG::Rendering::Runtime::HGGrassSettingParameters;
			//   }
			//   this.fields.grassGlobalSparsity = HG::Rendering::Runtime::SettingParameter::Create<float>(
			//                                        1.0,
			//                                        v3.static_fields.FEATURE_NAME,
			//                                        (String *)"GrassGlobalSparsity",
			//                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v4, v5, v6, v7, v8, v9);
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly string FEATURE_NAME;

		public SettingParameter<float> grassGlobalSparsity;
	}
}
