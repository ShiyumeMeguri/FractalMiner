using System;
using System.Collections.Generic;
using IFix.Core;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class ScalableSettingSchema
	{
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x00002608 File Offset: 0x00000808
		public int levelCount
		{
			get
			{
				// // Int32 get_Length()
				// int32_t System::Threading::SparselyPopulatedArrayFragment<System::Object>::get_Length(
				//         SparselyPopulatedArrayFragment_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   Object__Array *elements; // rax
				// 
				//   elements = this.fields._elements;
				//   if ( !elements )
				//     sub_180B536AC(this, method);
				//   return elements.max_length.size;
				// }
				// 
				return 0;
			}
		}

		public ScalableSettingSchema(GUIContent[] levelNames)
		{
			// // SortedList`2[TKey,TValue]+ValueList[System.Object,System.Object](SortedList`2[System.Object,System.Object])
			// void System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
			//         SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *this,
			//         SortedList_2_System_Object_System_Object_ *dictionary,
			//         MethodInfo *method)
			// {
			//   HGCamera *v3; // r9
			//   MethodInfo *v4; // [rsp+28h] [rbp+28h]
			//   MethodInfo *v5; // [rsp+30h] [rbp+30h]
			// 
			//   this.fields._dict = dictionary;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields,
			//     (HGRenderPathBase_HGRenderPathResources *)dictionary,
			//     (PassConstructorID__Enum__Array *)method,
			//     v3,
			//     v4,
			//     v5);
			// }
			// 
		}

		[IDTag(0)]
		internal static ScalableSettingSchema GetSchemaOrNull(ScalableSettingSchemaId id)
		{
			// // ScalableSettingSchema GetSchemaOrNull(ScalableSettingSchemaId)
			// ScalableSettingSchema *HG::Rendering::Runtime::ScalableSettingSchema::GetSchemaOrNull(
			//         ScalableSettingSchemaId id,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Dictionary_2_HG_Rendering_Runtime_ScalableSettingSchemaId_HG_Rendering_Runtime_ScalableSettingSchema_ *Schemas; // rcx
			//   bool v5; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Object *value; // [rsp+40h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D919691 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,HG::Rendering::Runtime::ScalableSettingSchema>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema);
			//     byte_18D919691 = 1;
			//   }
			//   value = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3127, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema);
			//     Schemas = TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema.static_fields.Schemas;
			//     if ( Schemas )
			//     {
			//       v5 = System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,System::Object>::TryGetValue(
			//              (Dictionary_2_HG_Rendering_Runtime_ScalableSettingSchemaId_System_Object_ *)Schemas,
			//              id,
			//              &value,
			//              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,HG::Rendering::Runtime::ScalableSettingSchema>::TryGetValue);
			//       return (ScalableSettingSchema *)((unsigned __int64)value & -(__int64)v5);
			//     }
			// LABEL_7:
			//     sub_180B536AC(Schemas, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3127, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1098(Patch, id, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		internal static ScalableSettingSchema GetSchemaOrNull(Nullable<ScalableSettingSchemaId> id)
		{
			// // ScalableSettingSchema GetSchemaOrNull(Nullable`1[HG.Rendering.Runtime.ScalableSettingSchemaId])
			// ScalableSettingSchema *HG::Rendering::Runtime::ScalableSettingSchema::GetSchemaOrNull(
			//         Nullable_1_HG_Rendering_Runtime_ScalableSettingSchemaId_ *id,
			//         MethodInfo *method)
			// {
			//   Dictionary_2_HG_Rendering_Runtime_ScalableSettingSchemaId_HG_Rendering_Runtime_ScalableSettingSchema_ *Schemas; // rdi
			//   AIBarkManager_AIBarkExtraData v4; // rax
			//   AIBarkManager_AIBarkExtraData v5; // rdx
			//   AIBarkManager_AIBarkExtraData v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Nullable_1_HG_Rendering_Runtime_ScalableSettingSchemaId_ v9; // [rsp+20h] [rbp-18h] BYREF
			//   Object *value; // [rsp+50h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D919692 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,HG::Rendering::Runtime::ScalableSettingSchema>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::ScalableSettingSchemaId>::get_HasValue);
			//     sub_18003C530(&MethodInfo::System::Nullable<HG::Rendering::Runtime::ScalableSettingSchemaId>::get_Value);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema);
			//     byte_18D919692 = 1;
			//   }
			//   value = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3128, 0LL) )
			//   {
			//     if ( !id.hasValue )
			//       return 0LL;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema);
			//     Schemas = TypeInfo::HG::Rendering::Runtime::ScalableSettingSchema.static_fields.Schemas;
			//     v4.charId = System::Nullable<Beyond::Gameplay::AIBarkManager::AIBarkExtraData>::get_Value(
			//                   (Nullable_1_Beyond_Gameplay_AIBarkManager_AIBarkExtraData_ *)id,
			//                   MethodInfo::System::Nullable<HG::Rendering::Runtime::ScalableSettingSchemaId>::get_Value).charId;
			//     if ( Schemas )
			//     {
			//       if ( System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,System::Object>::TryGetValue(
			//              (Dictionary_2_HG_Rendering_Runtime_ScalableSettingSchemaId_System_Object_ *)Schemas,
			//              (ScalableSettingSchemaId)v4.charId,
			//              &value,
			//              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::ScalableSettingSchemaId,HG::Rendering::Runtime::ScalableSettingSchema>::TryGetValue) )
			//       {
			//         return (ScalableSettingSchema *)value;
			//       }
			//       return 0LL;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v6.charId, v5.charId);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3128, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   v9 = *id;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1099(Patch, &v9, 0LL);
			// }
			// 
			return null;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		internal static readonly Dictionary<ScalableSettingSchemaId, ScalableSettingSchema> Schemas;

		public readonly GUIContent[] levelNames;
	}
}
