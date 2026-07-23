using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

public class LODStreamingSettingParameters // TypeDefIndex: 37364
{
	// Fields
	public static LODStreamingSettingParameters s_parameters; // 0x00
	public const string FEATURE_NAME = "LODStreaming"; // Metadata: 0x02302D2F
	public readonly SettingParameter<bool> lodStreamingKeepLastLODResource; // 0x10
	public readonly SettingParameter<float> lodStreamingLoadDirtyDistance; // 0x18
	public readonly SettingParameter<float> lodStreamingUnloadDirtyDistance; // 0x20
	public readonly SettingParameter<int> artTagLODStreamingOffsetAll; // 0x28
	public List<SettingParameter<int>> artTagLODStreamingOffset; // 0x30

	// Constructors
	public LODStreamingSettingParameters() {} // 0x0000000183658710-0x00000001836588D0
	// LODStreamingSettingParameters()
	void LODStreamingSettingParameters::LODStreamingSettingParameters(
	        LODStreamingSettingParameters *this,
	        MethodInfo *method)
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
	  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v15; // rax
	  __int64 v16; // rdx
	  __int64 v17; // rcx
	  List_1_HG_Rendering_Runtime_SettingParameter_1_System_Int32_ *v18; // rbx
	  Type *v19; // rdx
	  PropertyInfo_1 *v20; // r8
	  Int32__Array **v21; // r9
	  int i; // ebx
	  List_1_System_Object_ *artTagLODStreamingOffset; // rdi
	  Object *v24; // rsi
	  String *v25; // rax
	  Object *v26; // rax
	  Enum v27; // [rsp+20h] [rbp-28h] BYREF
	  int v28; // [rsp+30h] [rbp-18h]
	
	  this->fields.lodStreamingKeepLastLODResource = HG::Rendering::Runtime::SettingParameter::Create<bool>(
	                                                   1,
	                                                   (String *)"LODStreaming",
	                                                   (String *)"lodStreamingKeepLastLODResource",
	                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v3, v4, v5, (MethodInfo *)v27.klass);
	  this->fields.lodStreamingLoadDirtyDistance = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                                 4.0,
	                                                 (String *)"LODStreaming",
	                                                 (String *)"lodStreamingLoadDirtyDistance",
	                                                 MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.lodStreamingLoadDirtyDistance, v6, v7, v8, (MethodInfo *)v27.klass);
	  this->fields.lodStreamingUnloadDirtyDistance = HG::Rendering::Runtime::SettingParameter::Create<float>(
	                                                   12.0,
	                                                   (String *)"LODStreaming",
	                                                   (String *)"lodStreamingUnloadDirtyDistance",
	                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
	  sub_18002D1B0(
	    (SingleFieldAccessor *)&this->fields.lodStreamingUnloadDirtyDistance,
	    v9,
	    v10,
	    v11,
	    (MethodInfo *)v27.klass);
	  this->fields.artTagLODStreamingOffsetAll = HG::Rendering::Runtime::SettingParameter::Create<int>(
	                                               0,
	                                               (String *)"LODStreaming",
	                                               (String *)"LODStreamingOffset.All",
	                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
	  sub_18002D1B0(
	    (SingleFieldAccessor *)&this->fields.artTagLODStreamingOffsetAll,
	    v12,
	    v13,
	    v14,
	    (MethodInfo *)v27.klass);
	  v15 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SettingParameter<int>>);
	  v18 = (List_1_HG_Rendering_Runtime_SettingParameter_1_System_Int32_ *)v15;
	  if ( !v15 )
	LABEL_8:
	    sub_1800D8260(v17, v16);
	  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
	    v15,
	    35,
	    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SettingParameter<int>>::List);
	  this->fields.artTagLODStreamingOffset = v18;
	  sub_18002D1B0((SingleFieldAccessor *)&this->fields.artTagLODStreamingOffset, v19, v20, v21, (MethodInfo *)v27.klass);
	  for ( i = 0; i < 35; ++i )
	  {
	    artTagLODStreamingOffset = (List_1_System_Object_ *)this->fields.artTagLODStreamingOffset;
	    v27.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::ArtTags;
	    v27.monitor = (MonitorData *)-1LL;
	    v28 = i;
	    v24 = (Object *)System::Enum::ToString(&v27, 0LL);
	    if ( !TypeInfo::Cysharp::Text::ZString->_1.cctor_finished_or_no_cctor )
	      il2cpp_runtime_class_init_1(TypeInfo::Cysharp::Text::ZString);
	    v25 = (String *)sub_182F27000((String *)"LODStreamingOffset.{0}", v24);
	    v26 = (Object *)HG::Rendering::Runtime::SettingParameter::Create<int>(
	                      0,
	                      (String *)"LODStreaming",
	                      v25,
	                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
	    if ( !artTagLODStreamingOffset )
	      goto LABEL_8;
	    sub_182F01190(artTagLODStreamingOffset, v26);
	  }
	}
	
	static LODStreamingSettingParameters() {} // 0x0000000184D56650-0x0000000184D566B0
	// LODStreamingSettingParameters()
	void LODStreamingSettingParameters::cctor(MethodInfo *method)
	{
	  LODStreamingSettingParameters *v1; // rax
	  __int64 v2; // rdx
	  __int64 v3; // rcx
	  LODStreamingSettingParameters *v4; // rbx
	  Type *v5; // rdx
	  PropertyInfo_1 *v6; // r8
	  Int32__Array **v7; // r9
	  MethodInfo *v8; // [rsp+50h] [rbp+28h]
	
	  v1 = (LODStreamingSettingParameters *)sub_1800368D0(TypeInfo::LODStreamingSettingParameters);
	  v4 = v1;
	  if ( !v1 )
	    sub_1800D8260(v3, v2);
	  LODStreamingSettingParameters::LODStreamingSettingParameters(v1, 0LL);
	  TypeInfo::LODStreamingSettingParameters->static_fields->s_parameters = v4;
	  sub_18002D1B0((SingleFieldAccessor *)TypeInfo::LODStreamingSettingParameters->static_fields, v5, v6, v7, v8);
	}
	
}

