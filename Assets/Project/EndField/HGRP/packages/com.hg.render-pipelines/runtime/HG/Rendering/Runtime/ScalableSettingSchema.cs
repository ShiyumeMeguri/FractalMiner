using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class ScalableSettingSchema // TypeDefIndex: 38559
	{
		// Fields
		internal static readonly Dictionary<ScalableSettingSchemaId, ScalableSettingSchema> Schemas; // 0x00
		public readonly GUIContent[] levelNames; // 0x10
	
		// Properties
		public int levelCount { get => default; } // 0x0000000189C12094-0x0000000189C120EC 
		// Int32 get_levelCount()
		int32_t HG::Rendering::Runtime::ScalableSettingSchema::get_levelCount(ScalableSettingSchema *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  GUIContent__Array *levelNames; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3730, 0LL) )
		  {
		    levelNames = this->fields.levelNames;
		    if ( levelNames )
		      return levelNames->max_length.size;
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3730, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public ScalableSettingSchema() {} // Dummy constructor
		public ScalableSettingSchema(GUIContent[] levelNames) {} // 0x00000001853908C0-0x00000001853908D0
		// SortedList`2[TKey,TValue]+ValueList[System.Object,System.Object](SortedList`2[System.Object,System.Object])
		void System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
		        SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *this,
		        SortedList_2_System_Object_System_Object_ *dictionary,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v4; // [rsp+28h] [rbp+28h]
		
		  this->fields._dict = dictionary;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields,
		    (HGRuntimeGrassQuery_Node *)dictionary,
		    (HGRuntimeGrassQuery_Node *)method,
		    v3,
		    v4);
		}
		
		static ScalableSettingSchema() {} // 0x0000000189C11D60-0x0000000189C12094
		// ScalableSettingSchema()
		void HG::Rendering::Runtime::ScalableSettingSchema::cctor(MethodInfo *method)
		{
		  Dictionary_2_HG_Rendering_Runtime_ScalableSettingSchemaId_System_Object_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Dictionary_2_HG_Rendering_Runtime_ScalableSettingSchemaId_System_Object_ *v4; // rsi
		  String *m_Id; // rbx
		  SortedList_2_System_Object_System_Object_ *v6; // rdi
		  GUIContent *v7; // rax
		  GUIContent *v8; // rbp
		  GUIContent *v9; // rax
		  GUIContent *v10; // rbp
		  GUIContent *v11; // rax
		  GUIContent *v12; // rbp
		  SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *v13; // rax
		  Object *v14; // rbp
		  String *v15; // rbx
		  SortedList_2_System_Object_System_Object_ *v16; // rdi
		  GUIContent *v17; // rax
		  GUIContent *v18; // rbp
		  GUIContent *v19; // rax
		  GUIContent *v20; // rbp
		  GUIContent *v21; // rax
		  GUIContent *v22; // rbp
		  GUIContent *v23; // rax
		  GUIContent *v24; // rbp
		  SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *v25; // rax
		  Object *v26; // rbp
		  HGRuntimeGrassQuery_Node *v27; // rdx
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  MethodInfo *v30; // [rsp+50h] [rbp+28h]
		
		  v1 = (Dictionary_2_HG_Rendering_Runtime_ScalableSettingSchemaId_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,HG::Rendering::Runtime::ScalableSettingSchema>);
		  v4 = v1;
		  if ( !v1 )
		    goto LABEL_14;
		  System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,System::Object>::Dictionary(
		    v1,
		    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,HG::Rendering::Runtime::ScalableSettingSchema>::Dictionary);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId);
		  m_Id = TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId->static_fields->With3Levels.m_Id;
		  v6 = (SortedList_2_System_Object_System_Object_ *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::GUIContent, 3LL);
		  v7 = (GUIContent *)sub_18002C620(TypeInfo::UnityEngine::GUIContent);
		  v8 = v7;
		  if ( !v7 )
		    goto LABEL_14;
		  UnityEngine::GUIContent::GUIContent(v7, (String *)"Low", 0LL);
		  if ( !v6 )
		    goto LABEL_14;
		  sub_180031B10(v6, v8);
		  sub_180378FEC(v6, 0LL, v8);
		  v9 = (GUIContent *)sub_18002C620(TypeInfo::UnityEngine::GUIContent);
		  v10 = v9;
		  if ( !v9 )
		    goto LABEL_14;
		  UnityEngine::GUIContent::GUIContent(v9, (String *)"Medium", 0LL);
		  sub_180031B10(v6, v10);
		  sub_180378FEC(v6, 1LL, v10);
		  v11 = (GUIContent *)sub_18002C620(TypeInfo::UnityEngine::GUIContent);
		  v12 = v11;
		  if ( !v11 )
		    goto LABEL_14;
		  UnityEngine::GUIContent::GUIContent(v11, (String *)"High", 0LL);
		  sub_180031B10(v6, v12);
		  sub_180378FEC(v6, 2LL, v12);
		  v13 = (SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema);
		  v14 = (Object *)v13;
		  if ( !v13 )
		    goto LABEL_14;
		  System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
		    v13,
		    v6,
		    0LL);
		  System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,System::Object>::Add(
		    v4,
		    (ScalableSettingSchemaId)m_Id,
		    v14,
		    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,HG::Rendering::Runtime::ScalableSettingSchema>::Add);
		  v15 = TypeInfo::HG::Rendering::Runtime::ScalableSettingSchemaId->static_fields->With4Levels.m_Id;
		  v16 = (SortedList_2_System_Object_System_Object_ *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::GUIContent, 4LL);
		  v17 = (GUIContent *)sub_18002C620(TypeInfo::UnityEngine::GUIContent);
		  v18 = v17;
		  if ( !v17 )
		    goto LABEL_14;
		  UnityEngine::GUIContent::GUIContent(v17, (String *)"Low", 0LL);
		  if ( !v16 )
		    goto LABEL_14;
		  sub_180031B10(v16, v18);
		  sub_180378FEC(v16, 0LL, v18);
		  v19 = (GUIContent *)sub_18002C620(TypeInfo::UnityEngine::GUIContent);
		  v20 = v19;
		  if ( !v19 )
		    goto LABEL_14;
		  UnityEngine::GUIContent::GUIContent(v19, (String *)"Medium", 0LL);
		  sub_180031B10(v16, v20);
		  sub_180378FEC(v16, 1LL, v20);
		  v21 = (GUIContent *)sub_18002C620(TypeInfo::UnityEngine::GUIContent);
		  v22 = v21;
		  if ( !v21 )
		    goto LABEL_14;
		  UnityEngine::GUIContent::GUIContent(v21, (String *)"High", 0LL);
		  sub_180031B10(v16, v22);
		  sub_180378FEC(v16, 2LL, v22);
		  v23 = (GUIContent *)sub_18002C620(TypeInfo::UnityEngine::GUIContent);
		  v24 = v23;
		  if ( !v23
		    || (UnityEngine::GUIContent::GUIContent(v23, (String *)"Ultra", 0LL),
		        sub_180031B10(v16, v24),
		        sub_180378FEC(v16, 3LL, v24),
		        v25 = (SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema),
		        (v26 = (Object *)v25) == 0LL) )
		  {
		LABEL_14:
		    sub_1800D8260(v3, v2);
		  }
		  System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
		    v25,
		    v16,
		    0LL);
		  System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,System::Object>::Add(
		    v4,
		    (ScalableSettingSchemaId)v15,
		    v26,
		    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,HG::Rendering::Runtime::ScalableSettingSchema>::Add);
		  TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema->static_fields->Schemas = (Dictionary_2_HG_Rendering_Runtime_ScalableSettingSchemaId_HG_Rendering_Runtime_ScalableSettingSchema_ *)v4;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema->static_fields,
		    v27,
		    v28,
		    v29,
		    v30);
		}
		
	
		// Methods
		[IDTag(0)]
		internal static ScalableSettingSchema GetSchemaOrNull(ScalableSettingSchemaId id) => default; // 0x0000000189C11C1C-0x0000000189C11CA8
		// ScalableSettingSchema GetSchemaOrNull(ScalableSettingSchemaId)
		ScalableSettingSchema *HG::Rendering::Runtime::ScalableSettingSchema::GetSchemaOrNull(
		        ScalableSettingSchemaId id,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Dictionary_2_HG_Rendering_Runtime_ScalableSettingSchemaId_HG_Rendering_Runtime_ScalableSettingSchema_ *Schemas; // rcx
		  bool v5; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *value; // [rsp+40h] [rbp+18h] BYREF
		
		  value = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3728, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema);
		    Schemas = TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema->static_fields->Schemas;
		    if ( Schemas )
		    {
		      v5 = System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,System::Object>::TryGetValue(
		             (Dictionary_2_HG_Rendering_Runtime_ScalableSettingSchemaId_System_Object_ *)Schemas,
		             id,
		             &value,
		             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,HG::Rendering::Runtime::ScalableSettingSchema>::TryGetValue);
		      return (ScalableSettingSchema *)((unsigned __int64)value & -(__int64)v5);
		    }
		LABEL_5:
		    sub_1800D8260(Schemas, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3728, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1303(Patch, id, 0LL);
		}
		
		[IDTag(1)]
		internal static ScalableSettingSchema GetSchemaOrNull(ScalableSettingSchemaId? id) => default; // 0x0000000189C11CA8-0x0000000189C11D60
		// ScalableSettingSchema GetSchemaOrNull(Nullable`1[HG.Rendering.Runtime.ScalableSettingSchemaId])
		ScalableSettingSchema *HG::Rendering::Runtime::ScalableSettingSchema::GetSchemaOrNull(
		        Nullable_1_HG_Rendering_Runtime_ScalableSettingSchemaId_ *id,
		        MethodInfo *method)
		{
		  Dictionary_2_HG_Rendering_Runtime_ScalableSettingSchemaId_HG_Rendering_Runtime_ScalableSettingSchema_ *Schemas; // rdi
		  AIBarkManager_AIBarkExtraData v4; // rax
		  AIBarkManager_AIBarkExtraData v5; // rdx
		  AIBarkManager_AIBarkExtraData v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Nullable_1_HG_Rendering_Runtime_ScalableSettingSchemaId_ v9; // [rsp+20h] [rbp-18h] BYREF
		  Object *value; // [rsp+50h] [rbp+18h] BYREF
		
		  value = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3729, 0LL) )
		  {
		    if ( !id->hasValue )
		      return 0LL;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema);
		    Schemas = TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema->static_fields->Schemas;
		    v4.charId = System::Nullable<Beyond::Gameplay::AIBarkManager::AIBarkExtraData>::get_Value(
		                  (Nullable_1_Beyond_Gameplay_AIBarkManager_AIBarkExtraData_ *)id,
		                  MethodInfo::System::Nullable<HG::Rendering::Runtime::ScalableSettingSchemaId>::get_Value).charId;
		    if ( Schemas )
		    {
		      if ( System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,System::Object>::TryGetValue(
		             (Dictionary_2_HG_Rendering_Runtime_ScalableSettingSchemaId_System_Object_ *)Schemas,
		             (ScalableSettingSchemaId)v4.charId,
		             &value,
		             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,HG::Rendering::Runtime::ScalableSettingSchema>::TryGetValue) )
		      {
		        return (ScalableSettingSchema *)value;
		      }
		      return 0LL;
		    }
		LABEL_8:
		    sub_1800D8260(v6.charId, v5.charId);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3729, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  v9 = *id;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1304(Patch, &v9, 0LL);
		}
		
	}
}
