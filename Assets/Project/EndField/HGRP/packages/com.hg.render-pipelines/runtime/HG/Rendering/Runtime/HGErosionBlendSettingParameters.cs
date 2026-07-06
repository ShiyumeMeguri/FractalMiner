using System;
using System.Runtime.CompilerServices;

namespace HG.Rendering.Runtime
{
	public class HGErosionBlendSettingParameters
	{
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x000025D2 File Offset: 0x000007D2
		public SettingParameter<bool> Enable
		{
			[CompilerGenerated]
			get
			{
				// // Object get_Current()
				// Object *Rewired::Utils::Classes::Data::RingBuffer_1_T_::VFEweixJrFjiYwjUzBFjtcEMiCZW<System::Object>::get_Current(
				//         RingBuffer_1_T_VFEweixJrFjiYwjUzBFjtcEMiCZW_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.current;
				// }
				// 
				return null;
			}
		}

		public HGErosionBlendSettingParameters()
		{
			// // HGErosionBlendSettingParameters()
			// void HG::Rendering::Runtime::HGErosionBlendSettingParameters::HGErosionBlendSettingParameters(
			//         HGErosionBlendSettingParameters *this,
			//         MethodInfo *method)
			// {
			//   struct HGErosionBlendSettingParameters__Class *v3; // rax
			//   OneofDescriptorProto *v4; // rdx
			//   FileDescriptor *v5; // r8
			//   MessageDescriptor *v6; // r9
			//   String__Array *v7; // [rsp+50h] [rbp+28h]
			//   String *v8; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v9; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDB5A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGErosionBlendSettingParameters);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//     sub_18003C530(&off_18C9B3DD8);
			//     byte_18D8EDB5A = 1;
			//   }
			//   v3 = TypeInfo::HG::Rendering::Runtime::HGErosionBlendSettingParameters;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGErosionBlendSettingParameters._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGErosionBlendSettingParameters, method);
			//     v3 = TypeInfo::HG::Rendering::Runtime::HGErosionBlendSettingParameters;
			//   }
			//   this.fields._Enable_k__BackingField = HG::Rendering::Runtime::SettingParameter::Create<bool>(
			//                                            0,
			//                                            v3.static_fields.FEATURE_NAME,
			//                                            (String *)"Enable",
			//                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v4, v5, v6, v7, v8, v9);
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly string FEATURE_NAME;
	}
}
