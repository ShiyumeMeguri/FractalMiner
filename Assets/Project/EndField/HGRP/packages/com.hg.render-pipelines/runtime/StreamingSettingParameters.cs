using System;
using HG.Rendering.Runtime;

public class StreamingSettingParameters
{
	public StreamingSettingParameters()
	{
		// // StreamingSettingParameters()
		// void StreamingSettingParameters::StreamingSettingParameters(StreamingSettingParameters *this, MethodInfo *method)
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
		//   OneofDescriptorProto *v15; // rdx
		//   FileDescriptor *v16; // r8
		//   MessageDescriptor *v17; // r9
		//   OneofDescriptorProto *v18; // rdx
		//   FileDescriptor *v19; // r8
		//   MessageDescriptor *v20; // r9
		//   OneofDescriptorProto *v21; // rdx
		//   FileDescriptor *v22; // r8
		//   MessageDescriptor *v23; // r9
		//   OneofDescriptorProto *v24; // rdx
		//   FileDescriptor *v25; // r8
		//   MessageDescriptor *v26; // r9
		//   OneofDescriptorProto *v27; // rdx
		//   FileDescriptor *v28; // r8
		//   MessageDescriptor *v29; // r9
		//   OneofDescriptorProto *v30; // rdx
		//   FileDescriptor *v31; // r8
		//   MessageDescriptor *v32; // r9
		//   OneofDescriptorProto *v33; // rdx
		//   FileDescriptor *v34; // r8
		//   MessageDescriptor *v35; // r9
		//   OneofDescriptorProto *v36; // rdx
		//   FileDescriptor *v37; // r8
		//   MessageDescriptor *v38; // r9
		//   OneofDescriptorProto *v39; // rdx
		//   FileDescriptor *v40; // r8
		//   MessageDescriptor *v41; // r9
		//   OneofDescriptorProto *v42; // rdx
		//   FileDescriptor *v43; // r8
		//   MessageDescriptor *v44; // r9
		//   OneofDescriptorProto *v45; // rdx
		//   FileDescriptor *v46; // r8
		//   MessageDescriptor *v47; // r9
		//   OneofDescriptorProto *v48; // rdx
		//   FileDescriptor *v49; // r8
		//   MessageDescriptor *v50; // r9
		//   OneofDescriptorProto *v51; // rdx
		//   FileDescriptor *v52; // r8
		//   MessageDescriptor *v53; // r9
		//   String__Array *v54; // [rsp+20h] [rbp-48h]
		//   String__Array *v55; // [rsp+20h] [rbp-48h]
		//   String__Array *v56; // [rsp+20h] [rbp-48h]
		//   String__Array *v57; // [rsp+20h] [rbp-48h]
		//   String__Array *v58; // [rsp+20h] [rbp-48h]
		//   String__Array *v59; // [rsp+20h] [rbp-48h]
		//   String__Array *v60; // [rsp+20h] [rbp-48h]
		//   String__Array *v61; // [rsp+20h] [rbp-48h]
		//   String__Array *v62; // [rsp+20h] [rbp-48h]
		//   String__Array *v63; // [rsp+20h] [rbp-48h]
		//   String__Array *v64; // [rsp+20h] [rbp-48h]
		//   String__Array *v65; // [rsp+20h] [rbp-48h]
		//   String__Array *v66; // [rsp+20h] [rbp-48h]
		//   String__Array *v67; // [rsp+20h] [rbp-48h]
		//   String__Array *v68; // [rsp+20h] [rbp-48h]
		//   String__Array *v69; // [rsp+20h] [rbp-48h]
		//   String *v70; // [rsp+28h] [rbp-40h]
		//   String *v71; // [rsp+28h] [rbp-40h]
		//   String *v72; // [rsp+28h] [rbp-40h]
		//   String *v73; // [rsp+28h] [rbp-40h]
		//   String *v74; // [rsp+28h] [rbp-40h]
		//   String *v75; // [rsp+28h] [rbp-40h]
		//   String *v76; // [rsp+28h] [rbp-40h]
		//   String *v77; // [rsp+28h] [rbp-40h]
		//   String *v78; // [rsp+28h] [rbp-40h]
		//   String *v79; // [rsp+28h] [rbp-40h]
		//   String *v80; // [rsp+28h] [rbp-40h]
		//   String *v81; // [rsp+28h] [rbp-40h]
		//   String *v82; // [rsp+28h] [rbp-40h]
		//   String *v83; // [rsp+28h] [rbp-40h]
		//   String *v84; // [rsp+28h] [rbp-40h]
		//   String *v85; // [rsp+28h] [rbp-40h]
		//   MethodInfo *v86; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v87; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v88; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v89; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v90; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v91; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v92; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v93; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v94; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v95; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v96; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v97; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v98; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v99; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v100; // [rsp+30h] [rbp-38h]
		//   MethodInfo *v101; // [rsp+30h] [rbp-38h]
		//   String__Array *v102; // [rsp+90h] [rbp+28h]
		//   String *v103; // [rsp+98h] [rbp+30h]
		//   MethodInfo *v104; // [rsp+A0h] [rbp+38h]
		// 
		//   if ( !byte_18D8ED908 )
		//   {
		//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//     sub_18003C530(&off_18C95A660);
		//     sub_18003C530(&off_18C95A650);
		//     sub_18003C530(&off_18C95A600);
		//     sub_18003C530(&off_18C95A5F0);
		//     sub_18003C530(&off_18C95A620);
		//     sub_18003C530(&off_18C95A610);
		//     sub_18003C530(&off_18C95A6C8);
		//     sub_18003C530(&off_18C95A6B0);
		//     sub_18003C530(&off_18C95A6F0);
		//     sub_18003C530(&off_18C95A6E0);
		//     sub_18003C530(&off_18C95A680);
		//     sub_18003C530(&off_18C95A670);
		//     sub_18003C530(&off_18C9264A8);
		//     sub_18003C530(&off_18C95A6A0);
		//     sub_18003C530(&off_18C95A690);
		//     sub_18003C530(&off_18C95A780);
		//     sub_18003C530(&off_18C95A760);
		//     sub_18003C530(&off_18C95A7B0);
		//     byte_18D8ED908 = 1;
		//   }
		//   this.fields.chunkLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                    256.0,
		//                                    (String *)"Streaming",
		//                                    (String *)"chunkLoadRadius",
		//                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields, v3, v4, v5, v54, v70, v86);
		//   this.fields.defaultLayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                           128.0,
		//                                           (String *)"Streaming",
		//                                           (String *)"defaultLayerLoadRadius",
		//                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.defaultLayerLoadRadius, v6, v7, v8, v55, v71, v87);
		//   this.fields.hlod0LayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                         256.0,
		//                                         (String *)"Streaming",
		//                                         (String *)"hlod0LayerLoadRadius",
		//                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.hlod0LayerLoadRadius, v9, v10, v11, v56, v72, v88);
		//   this.fields.hlod1LayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                         512.0,
		//                                         (String *)"Streaming",
		//                                         (String *)"hlod1LayerLoadRadius",
		//                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.hlod1LayerLoadRadius, v12, v13, v14, v57, v73, v89);
		//   this.fields.hlod2LayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                         1024.0,
		//                                         (String *)"Streaming",
		//                                         (String *)"hlod2LayerLoadRadius",
		//                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.hlod2LayerLoadRadius, v15, v16, v17, v58, v74, v90);
		//   this.fields.colliderLayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                            128.0,
		//                                            (String *)"Streaming",
		//                                            (String *)"colliderLayerLoadRadius",
		//                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.colliderLayerLoadRadius, v18, v19, v20, v59, v75, v91);
		//   this.fields.tinyLayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                        32.0,
		//                                        (String *)"Streaming",
		//                                        (String *)"tinyLayerLoadRadius",
		//                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.tinyLayerLoadRadius, v21, v22, v23, v60, v76, v92);
		//   this.fields.waterLayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                         128.0,
		//                                         (String *)"Streaming",
		//                                         (String *)"waterLayerLoadRadius",
		//                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.waterLayerLoadRadius, v24, v25, v26, v61, v77, v93);
		//   this.fields.lightingLayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                            128.0,
		//                                            (String *)"Streaming",
		//                                            (String *)"lightingLayerLoadRadius",
		//                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.lightingLayerLoadRadius, v27, v28, v29, v62, v78, v94);
		//   this.fields.audioLayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                         16.0,
		//                                         (String *)"Streaming",
		//                                         (String *)"audioLayerLoadRadius",
		//                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.audioLayerLoadRadius, v30, v31, v32, v63, v79, v95);
		//   this.fields.loadDirtyDistance = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                      4.0,
		//                                      (String *)"Streaming",
		//                                      (String *)"loadDirtyDistance",
		//                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.loadDirtyDistance, v33, v34, v35, v64, v80, v96);
		//   this.fields.unloadDirtyDistance = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                        12.0,
		//                                        (String *)"Streaming",
		//                                        (String *)"unloadDirtyDistance",
		//                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.unloadDirtyDistance, v36, v37, v38, v65, v81, v97);
		//   this.fields.loadElapsedMsPerFrame = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                          3.5,
		//                                          (String *)"Streaming",
		//                                          (String *)"loadElapsedMsPerFrame",
		//                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.loadElapsedMsPerFrame, v39, v40, v41, v66, v82, v98);
		//   this.fields.unloadElapsedMsPerFrame = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                            0.5,
		//                                            (String *)"Streaming",
		//                                            (String *)"unloadElapsedMsPerFrame",
		//                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.unloadElapsedMsPerFrame, v42, v43, v44, v67, v83, v99);
		//   this.fields.hlod0LayerLoadRadiusLowMemory = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                                  256.0,
		//                                                  (String *)"Streaming",
		//                                                  (String *)"hlod0LayerLoadRadiusLowMemory",
		//                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.hlod0LayerLoadRadiusLowMemory, v45, v46, v47, v68, v84, v100);
		//   this.fields.hlod1LayerLoadRadiusLowMemory = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                                  512.0,
		//                                                  (String *)"Streaming",
		//                                                  (String *)"hlod1LayerLoadRadiusLowMemory",
		//                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.hlod1LayerLoadRadiusLowMemory, v48, v49, v50, v69, v85, v101);
		//   this.fields.hlod2LayerLoadRadiusLowMemory = HG::Rendering::Runtime::SettingParameter::Create<float>(
		//                                                  1024.0,
		//                                                  (String *)"Streaming",
		//                                                  (String *)"hlod2LayerLoadRadiusLowMemory",
		//                                                  MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		//   sub_1800054D0((OneofDescriptor *)&this.fields.hlod2LayerLoadRadiusLowMemory, v51, v52, v53, v102, v103, v104);
		// }
		// 
	}

	[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
	public static StreamingSettingParameters s_parameters;

	public const string FEATURE_NAME = "Streaming";

	public readonly SettingParameter<float> chunkLoadRadius;

	public readonly SettingParameter<float> defaultLayerLoadRadius;

	public readonly SettingParameter<float> hlod0LayerLoadRadius;

	public readonly SettingParameter<float> hlod1LayerLoadRadius;

	public readonly SettingParameter<float> hlod2LayerLoadRadius;

	public readonly SettingParameter<float> colliderLayerLoadRadius;

	public readonly SettingParameter<float> tinyLayerLoadRadius;

	public readonly SettingParameter<float> waterLayerLoadRadius;

	public readonly SettingParameter<float> lightingLayerLoadRadius;

	public readonly SettingParameter<float> audioLayerLoadRadius;

	public readonly SettingParameter<float> loadDirtyDistance;

	public readonly SettingParameter<float> unloadDirtyDistance;

	public readonly SettingParameter<float> loadElapsedMsPerFrame;

	public readonly SettingParameter<float> unloadElapsedMsPerFrame;

	public readonly SettingParameter<float> hlod0LayerLoadRadiusLowMemory;

	public readonly SettingParameter<float> hlod1LayerLoadRadiusLowMemory;

	public readonly SettingParameter<float> hlod2LayerLoadRadiusLowMemory;
}
