using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

public class StreamingSettingParameters // TypeDefIndex: 37363
{
	// Fields
	public static StreamingSettingParameters s_parameters; // 0x00
	public const string FEATURE_NAME = "Streaming"; // Metadata: 0x02302D25
	public readonly SettingParameter<float> chunkLoadRadius; // 0x10
	public readonly SettingParameter<float> defaultLayerLoadRadius; // 0x18
	public readonly SettingParameter<float> hlod0LayerLoadRadius; // 0x20
	public readonly SettingParameter<float> hlod1LayerLoadRadius; // 0x28
	public readonly SettingParameter<float> hlod2LayerLoadRadius; // 0x30
	public readonly SettingParameter<float> colliderLayerLoadRadius; // 0x38
	public readonly SettingParameter<float> tinyLayerLoadRadius; // 0x40
	public readonly SettingParameter<float> waterLayerLoadRadius; // 0x48
	public readonly SettingParameter<float> lightingLayerLoadRadius; // 0x50
	public readonly SettingParameter<float> audioLayerLoadRadius; // 0x58
	public readonly SettingParameter<float> loadDirtyDistance; // 0x60
	public readonly SettingParameter<float> unloadDirtyDistance; // 0x68
	public readonly SettingParameter<float> loadElapsedMsPerFrame; // 0x70
	public readonly SettingParameter<float> unloadElapsedMsPerFrame; // 0x78
	public readonly SettingParameter<float> hlod0LayerLoadRadiusLowMemory; // 0x80
	public readonly SettingParameter<float> hlod1LayerLoadRadiusLowMemory; // 0x88
	public readonly SettingParameter<float> hlod2LayerLoadRadiusLowMemory; // 0x90

	// Constructors
	public StreamingSettingParameters() {} // 0x00000001841610A0-0x0000000184161400
	// StreamingSettingParameters()
	void StreamingSettingParameters::StreamingSettingParameters(StreamingSettingParameters *this, MethodInfo *method)
	{
	  Type *v3; // rdx
	  PropertyInfo_1 *v4; // r8
	  Int32__Array **v5; // r9
	  Type *v6; // rdx
	  PropertyInfo_1 *v7; // r8
	  Int32__Array **v8; // r9
	  Type *v9; // rdx
	  PropertyInfo_1 *v10; // r8
	  Int32__Array **v11; // r9
	  Type *v12; // rdx
	  PropertyInfo_1 *v13; // r8
	  Int32__Array **v14; // r9
	  Type *v15; // rdx
	  PropertyInfo_1 *v16; // r8
	  Int32__Array **v17; // r9
	  Type *v18; // rdx
	  PropertyInfo_1 *v19; // r8
	  Int32__Array **v20; // r9
	  Type *v21; // rdx
	  PropertyInfo_1 *v22; // r8
	  Int32__Array **v23; // r9
	  Type *v24; // rdx
	  PropertyInfo_1 *v25; // r8
	  Int32__Array **v26; // r9
	  Type *v27; // rdx
	  PropertyInfo_1 *v28; // r8
	  Int32__Array **v29; // r9
	  Type *v30; // rdx
	  PropertyInfo_1 *v31; // r8
	  Int32__Array **v32; // r9
	  Type *v33; // rdx
	  PropertyInfo_1 *v34; // r8
	  Int32__Array **v35; // r9
	  Type *v36; // rdx
	  PropertyInfo_1 *v37; // r8
	  Int32__Array **v38; // r9
	  Type *v39; // rdx
	  PropertyInfo_1 *v40; // r8
	  Int32__Array **v41; // r9
	  Type *v42; // rdx
	  PropertyInfo_1 *v43; // r8
	  Int32__Array **v44; // r9
	  Type *v45; // rdx
	  PropertyInfo_1 *v46; // r8
	  Int32__Array **v47; // r9
	  Type *v48; // rdx
	  PropertyInfo_1 *v49; // r8
	  Int32__Array **v50; // r9
	  Type *v51; // rdx
	  PropertyInfo_1 *v52; // r8
	  Int32__Array **v53; // r9
	  MethodInfo *v54; // [rsp+20h] [rbp-48h]
	  MethodInfo *v55; // [rsp+20h] [rbp-48h]
	  MethodInfo *v56; // [rsp+20h] [rbp-48h]
	  MethodInfo *v57; // [rsp+20h] [rbp-48h]
	  MethodInfo *v58; // [rsp+20h] [rbp-48h]
	  MethodInfo *v59; // [rsp+20h] [rbp-48h]
	  MethodInfo *v60; // [rsp+20h] [rbp-48h]
	  MethodInfo *v61; // [rsp+20h] [rbp-48h]
	  MethodInfo *v62; // [rsp+20h] [rbp-48h]
	  MethodInfo *v63; // [rsp+20h] [rbp-48h]
	  MethodInfo *v64; // [rsp+20h] [rbp-48h]
	  MethodInfo *v65; // [rsp+20h] [rbp-48h]
	  MethodInfo *v66; // [rsp+20h] [rbp-48h]
	  MethodInfo *v67; // [rsp+20h] [rbp-48h]
	  MethodInfo *v68; // [rsp+20h] [rbp-48h]
	  MethodInfo *v69; // [rsp+20h] [rbp-48h]
	  MethodInfo *v70; // [rsp+90h] [rbp+28h]
	
	  this->fields.chunkLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                   256.0,
	                                   (String *)"Streaming",
	                                   (String *)"chunkLoadRadius",
	                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v3, v4, v5, v54);
	  this->fields.defaultLayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                          128.0,
	                                          (String *)"Streaming",
	                                          (String *)"defaultLayerLoadRadius",
	                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.defaultLayerLoadRadius, v6, v7, v8, v55);
	  this->fields.hlod0LayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                        256.0,
	                                        (String *)"Streaming",
	                                        (String *)"hlod0LayerLoadRadius",
	                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.hlod0LayerLoadRadius, v9, v10, v11, v56);
	  this->fields.hlod1LayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                        512.0,
	                                        (String *)"Streaming",
	                                        (String *)"hlod1LayerLoadRadius",
	                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.hlod1LayerLoadRadius, v12, v13, v14, v57);
	  this->fields.hlod2LayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                        1024.0,
	                                        (String *)"Streaming",
	                                        (String *)"hlod2LayerLoadRadius",
	                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.hlod2LayerLoadRadius, v15, v16, v17, v58);
	  this->fields.colliderLayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                           128.0,
	                                           (String *)"Streaming",
	                                           (String *)"colliderLayerLoadRadius",
	                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.colliderLayerLoadRadius, v18, v19, v20, v59);
	  this->fields.tinyLayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                       32.0,
	                                       (String *)"Streaming",
	                                       (String *)"tinyLayerLoadRadius",
	                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.tinyLayerLoadRadius, v21, v22, v23, v60);
	  this->fields.waterLayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                        128.0,
	                                        (String *)"Streaming",
	                                        (String *)"waterLayerLoadRadius",
	                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.waterLayerLoadRadius, v24, v25, v26, v61);
	  this->fields.lightingLayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                           128.0,
	                                           (String *)"Streaming",
	                                           (String *)"lightingLayerLoadRadius",
	                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.lightingLayerLoadRadius, v27, v28, v29, v62);
	  this->fields.audioLayerLoadRadius = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                        16.0,
	                                        (String *)"Streaming",
	                                        (String *)"audioLayerLoadRadius",
	                                        MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.audioLayerLoadRadius, v30, v31, v32, v63);
	  this->fields.loadDirtyDistance = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                     4.0,
	                                     (String *)"Streaming",
	                                     (String *)"loadDirtyDistance",
	                                     MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.loadDirtyDistance, v33, v34, v35, v64);
	  this->fields.unloadDirtyDistance = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                       12.0,
	                                       (String *)"Streaming",
	                                       (String *)"unloadDirtyDistance",
	                                       MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.unloadDirtyDistance, v36, v37, v38, v65);
	  this->fields.loadElapsedMsPerFrame = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                         3.5,
	                                         (String *)"Streaming",
	                                         (String *)"loadElapsedMsPerFrame",
	                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.loadElapsedMsPerFrame, v39, v40, v41, v66);
	  this->fields.unloadElapsedMsPerFrame = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                           0.5,
	                                           (String *)"Streaming",
	                                           (String *)"unloadElapsedMsPerFrame",
	                                           MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.unloadElapsedMsPerFrame, v42, v43, v44, v67);
	  this->fields.hlod0LayerLoadRadiusLowMemory = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                                 256.0,
	                                                 (String *)"Streaming",
	                                                 (String *)"hlod0LayerLoadRadiusLowMemory",
	                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.hlod0LayerLoadRadiusLowMemory, v45, v46, v47, v68);
	  this->fields.hlod1LayerLoadRadiusLowMemory = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                                 512.0,
	                                                 (String *)"Streaming",
	                                                 (String *)"hlod1LayerLoadRadiusLowMemory",
	                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.hlod1LayerLoadRadiusLowMemory, v48, v49, v50, v69);
	  this->fields.hlod2LayerLoadRadiusLowMemory = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                                 1024.0,
	                                                 (String *)"Streaming",
	                                                 (String *)"hlod2LayerLoadRadiusLowMemory",
	                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.hlod2LayerLoadRadiusLowMemory, v51, v52, v53, v70);
	}
	
	static StreamingSettingParameters() {} // 0x0000000184161040-0x00000001841610A0
	// StreamingSettingParameters()
	void StreamingSettingParameters::cctor(MethodInfo *method)
	{
	  StreamingSettingParameters *v1; // rax
	  __int64 v2; // rdx
	  __int64 v3; // rcx
	  StreamingSettingParameters *v4; // rbx
	  Type *v5; // rdx
	  PropertyInfo_1 *v6; // r8
	  Int32__Array **v7; // r9
	  MethodInfo *v8; // [rsp+50h] [rbp+28h]
	
	  v1 = (StreamingSettingParameters *)sub_1800368D0(TypeInfo::StreamingSettingParameters);
	  v4 = v1;
	  if ( !v1 )
	    sub_1800D8260(v3, v2);
	  StreamingSettingParameters::StreamingSettingParameters(v1, 0LL);
	  TypeInfo::StreamingSettingParameters->static_fields->s_parameters = v4;
	  sub_18002D1B0((SingleFieldAccessor *)TypeInfo::StreamingSettingParameters->static_fields, v5, v6, v7, v8);
	}
	
}

