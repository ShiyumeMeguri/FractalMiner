using System;
using System.Collections.Generic;
using HG.Rendering.Runtime;

public class LODStreamingSettingParameters
{
	public LODStreamingSettingParameters()
	{
		// // LODStreamingSettingParameters()
		// void LODStreamingSettingParameters::LODStreamingSettingParameters(
		//         LODStreamingSettingParameters *this,
		//         MethodInfo *method)
		// {
		//   OneofDescriptorProto *v3; // rdx
		//   FileDescriptor *v4; // r8
		//   MessageDescriptor *v5; // r9
		//   OneofDescriptorProto *v6; // rdx
		//   FileDescriptor *v7; // r8
		//   MessageDescriptor *v8; // r9
		//   OneofDescriptorProto *v9; // rdx
		//   FileDescriptor *v10; // r8
		//   MessageDescriptor *v11; // r9
		//   OneofDescriptorProto *v12; // rdx
		//   FileDescriptor *v13; // r8
		//   MessageDescriptor *v14; // r9
		//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v15; // rax
		//   __int64 v16; // rdx
		//   __int64 v17; // rcx
		//   List_1_HG_Rendering_Runtime_SettingParameter_1_System_Int32_ *v18; // rbx
		//   OneofDescriptorProto *v19; // rdx
		//   FileDescriptor *v20; // r8
		//   MessageDescriptor *v21; // r9
		//   int i; // ebx
		//   List_1_System_Object_ *artTagLODStreamingOffset; // rdi
		//   __int64 v24; // rdx
		//   Object *v25; // rsi
		//   String *v26; // rax
		//   Object *v27; // rax
		//   Enum v28; // [rsp+20h] [rbp-28h] BYREF
		//   MethodInfo *v29; // [rsp+30h] [rbp-18h]
		// 
		//   if ( !byte_18D8ED90A )
		//   {
		//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ArtTags);
		//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SettingParameter<int>>::Add);
		//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SettingParameter<int>>::List);
		//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SettingParameter<int>>);
		//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//     sub_18003C530(&MethodInfo::Cysharp::Text::ZString::Format<System::String>);
		//     sub_18003C530(&TypeInfo::Cysharp::Text::ZString);
		//     sub_18003C530(&off_18C95AA78);
		//     sub_18003C530(&off_18C95AAA8);
		//     sub_18003C530(&off_18C9264B0);
		//     sub_18003C530(&off_18C95AA98);
		//     sub_18003C530(&off_18C95AB98);
		//     sub_18003C530(&off_18C95AB88);
		//     byte_18D8ED90A = 1;
		//   }
		//   this.fields.lodStreamingKeepLastLODResource = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		//                                                    1,
		//                                                    (String *)"LODStreaming",
		//                                                    (String *)"lodStreamingKeepLastLODResource",
		//                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields, v3, v4, v5, (String__Array *)v28.klass, (String *)v28.monitor, v29);
		//   this.fields.lodStreamingLoadDirtyDistance = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                                  4.0,
		//                                                  (String *)"LODStreaming",
		//                                                  (String *)"lodStreamingLoadDirtyDistance",
		//                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0(
		//     (OneofDescriptor *)&this.fields.lodStreamingLoadDirtyDistance,
		//     v6,
		//     v7,
		//     v8,
		//     (String__Array *)v28.klass,
		//     (String *)v28.monitor,
		//     v29);
		//   this.fields.lodStreamingUnloadDirtyDistance = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                                    12.0,
		//                                                    (String *)"LODStreaming",
		//                                                    (String *)"lodStreamingUnloadDirtyDistance",
		//                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0(
		//     (OneofDescriptor *)&this.fields.lodStreamingUnloadDirtyDistance,
		//     v9,
		//     v10,
		//     v11,
		//     (String__Array *)v28.klass,
		//     (String *)v28.monitor,
		//     v29);
		//   this.fields.artTagLODStreamingOffsetAll = HG::Rendering::Runtime::SettingParameter::Create<int>(
		//                                                0,
		//                                                (String *)"LODStreaming",
		//                                                (String *)"LODStreamingOffset.All",
		//                                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		//   sub_1800054D0(
		//     (OneofDescriptor *)&this.fields.artTagLODStreamingOffsetAll,
		//     v12,
		//     v13,
		//     v14,
		//     (String__Array *)v28.klass,
		//     (String *)v28.monitor,
		//     v29);
		//   v15 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SettingParameter<int>>);
		//   v18 = (List_1_HG_Rendering_Runtime_SettingParameter_1_System_Int32_ *)v15;
		//   if ( !v15 )
		// LABEL_10:
		//     sub_180B536AC(v17, v16);
		//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
		//     v15,
		//     35,
		//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SettingParameter<int>>::List);
		//   this.fields.artTagLODStreamingOffset = v18;
		//   sub_1800054D0(
		//     (OneofDescriptor *)&this.fields.artTagLODStreamingOffset,
		//     v19,
		//     v20,
		//     v21,
		//     (String__Array *)v28.klass,
		//     (String *)v28.monitor,
		//     v29);
		//   for ( i = 0; i < 35; ++i )
		//   {
		//     artTagLODStreamingOffset = (List_1_System_Object_ *)this.fields.artTagLODStreamingOffset;
		//     v28.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::ArtTags;
		//     v28.monitor = (MonitorData *)-1LL;
		//     LODWORD(v29) = i;
		//     v25 = (Object *)System::Enum::ToString(&v28, 0LL);
		//     if ( !TypeInfo::Cysharp::Text::ZString._1.cctor_finished_or_no_cctor )
		//       il2cpp_runtime_class_init_0(TypeInfo::Cysharp::Text::ZString, v24);
		//     v26 = (String *)sub_1823AE2E0((String *)"LODStreamingOffset.{0}", v25);
		//     v27 = (Object *)HG::Rendering::Runtime::SettingParameter::Create<int>(
		//                       0,
		//                       (String *)"LODStreaming",
		//                       v26,
		//                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		//     if ( !artTagLODStreamingOffset )
		//       goto LABEL_10;
		//     sub_1822AD140(artTagLODStreamingOffset, v27);
		//   }
		// }
		// 
	}

	[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
	public static LODStreamingSettingParameters s_parameters;

	public const string FEATURE_NAME = "LODStreaming";

	public readonly SettingParameter<bool> lodStreamingKeepLastLODResource;

	public readonly SettingParameter<float> lodStreamingLoadDirtyDistance;

	public readonly SettingParameter<float> lodStreamingUnloadDirtyDistance;

	public readonly SettingParameter<int> artTagLODStreamingOffsetAll;

	public List<SettingParameter<int>> artTagLODStreamingOffset;
}
