using System;
using System.Collections.Generic;

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Field)]
	internal class FrameSettingsFieldAttribute : Attribute
	{
		public FrameSettingsFieldAttribute(int group, [MetadataOffset(Offset = "0x01F90B71")] FrameSettingsField autoName = FrameSettingsField.None, string displayedName = null, string tooltip = null, [MetadataOffset(Offset = "0x01F90B72")] FrameSettingsFieldAttribute.DisplayType type = FrameSettingsFieldAttribute.DisplayType.BoolAsCheckbox, Type targetType = null, FrameSettingsField[] positiveDependencies = null, FrameSettingsField[] negativeDependencies = null, [MetadataOffset(Offset = "0x01F90B73")] int customOrderInGroup = -1)
		{
			// // FrameSettingsFieldAttribute(Int32, FrameSettingsField, String, String, FrameSettingsFieldAttribute+DisplayType, Type, FrameSettingsField[], FrameSettingsField[], Int32)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::FrameSettingsFieldAttribute::FrameSettingsFieldAttribute(
			//         FrameSettingsFieldAttribute *this,
			//         int32_t group,
			//         FrameSettingsField__Enum autoName,
			//         String *displayedName,
			//         String *tooltip,
			//         FrameSettingsFieldAttribute_DisplayType__Enum type,
			//         Type *targetType,
			//         FrameSettingsField__Enum__Array *positiveDependencies,
			//         FrameSettingsField__Enum__Array *negativeDependencies,
			//         int32_t customOrderInGroup,
			//         MethodInfo *method)
			// {
			//   int32_t v14; // edi
			//   struct FrameSettingsFieldAttribute__Class *v15; // rax
			//   FileDescriptor *v16; // r8
			//   IList_1_Google_Protobuf_Reflection_FileDescriptor_ *PublicDependencies_k__BackingField; // rax
			//   OneofDescriptorProto *klass_low; // rdx
			//   MessageDescriptor *v19; // r9
			//   OneofDescriptorProto *v20; // rdx
			//   FileDescriptor *v21; // r8
			//   __int64 v22; // r8
			//   __int64 v23; // r9
			//   Array *v24; // rbp
			//   int32_t v25; // edi
			//   int32_t size; // eax
			//   FrameSettingsField__Enum__Array *v27; // rsi
			//   int32_t v28; // ecx
			//   OneofDescriptorProto *v29; // rdx
			//   FileDescriptor *v30; // r8
			//   MessageDescriptor *v31; // r9
			//   FrameSettingsField__Enum__Array *dependencies; // rax
			//   struct FrameSettingsFieldAttribute__Class *v33; // rax
			//   Dictionary_2_System_Int32Enum_System_Object_ *s_FrameSettingsEnumNameMap; // rcx
			//   Object *v35; // rax
			//   Enum v36; // [rsp+20h] [rbp-28h] BYREF
			//   MethodInfo *v37; // [rsp+30h] [rbp-18h]
			//   Object *value; // [rsp+68h] [rbp+20h] BYREF
			// 
			//   value = (Object *)displayedName;
			//   if ( !byte_18D8ED959 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsField);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsField);
			//     displayedName = (String *)value;
			//     byte_18D8ED959 = 1;
			//   }
			//   if ( !displayedName || !displayedName.fields._stringLength )
			//   {
			//     v33 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//     if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute, *(_QWORD *)&group);
			//       v33 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//     }
			//     s_FrameSettingsEnumNameMap = (Dictionary_2_System_Int32Enum_System_Object_ *)v33.static_fields.s_FrameSettingsEnumNameMap;
			//     if ( !s_FrameSettingsEnumNameMap )
			//       sub_180B536AC(0LL, *(_QWORD *)&group);
			//     if ( System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::TryGetValue(
			//            s_FrameSettingsEnumNameMap,
			//            (Int32Enum__Enum)autoName,
			//            &value,
			//            MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::TryGetValue) )
			//     {
			//       v35 = value;
			//     }
			//     else
			//     {
			//       v36.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::FrameSettingsField;
			//       v36.monitor = (MonitorData *)-1LL;
			//       LODWORD(v37) = autoName;
			//       v35 = (Object *)System::Enum::ToString(&v36, 0LL);
			//       value = v35;
			//     }
			//     value = (Object *)HG::Rendering::Runtime::StringExtention::CamelToPascalCaseWithSpace((String *)v35, 1, 0LL);
			//   }
			//   v14 = customOrderInGroup;
			//   this.fields.group = group;
			//   if ( v14 != -1 )
			//   {
			//     v15 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//     if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute, *(_QWORD *)&group);
			//       v15 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//     }
			//     v15.static_fields.autoOrder = v14;
			//   }
			//   v16 = (FileDescriptor *)TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//   if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute, *(_QWORD *)&group);
			//     v16 = (FileDescriptor *)TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//   }
			//   PublicDependencies_k__BackingField = v16[1].fields._PublicDependencies_k__BackingField;
			//   klass_low = (OneofDescriptorProto *)LODWORD(PublicDependencies_k__BackingField.klass);
			//   LODWORD(PublicDependencies_k__BackingField.klass) = (_DWORD)klass_low + 1;
			//   this.fields.displayedName = (String *)value;
			//   this.fields.orderInGroup = (int)klass_low;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.displayedName,
			//     klass_low,
			//     v16,
			//     (MessageDescriptor *)displayedName,
			//     (String__Array *)v36.klass,
			//     (String *)v36.monitor,
			//     v37);
			//   v19 = (MessageDescriptor *)type;
			//   this.fields.targetType = targetType;
			//   this.fields.type = (int)v19;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.targetType,
			//     v20,
			//     v21,
			//     v19,
			//     (String__Array *)v36.klass,
			//     (String *)v36.monitor,
			//     v37);
			//   v24 = (Array *)positiveDependencies;
			//   v25 = 0;
			//   if ( positiveDependencies )
			//     size = positiveDependencies.max_length.size;
			//   else
			//     size = 0;
			//   v27 = negativeDependencies;
			//   this.fields.dependencySeparator = size;
			//   if ( v27 )
			//     v28 = v27.max_length.size;
			//   else
			//     v28 = 0;
			//   this.fields.dependencies = (FrameSettingsField__Enum__Array *)il2cpp_array_new_specific_0(
			//                                                                    TypeInfo::HG::Rendering::Runtime::FrameSettingsField,
			//                                                                    (unsigned int)(v28 + size),
			//                                                                    v22,
			//                                                                    v23);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.dependencies,
			//     v29,
			//     v30,
			//     v31,
			//     (String__Array *)v36.klass,
			//     (String *)v36.monitor,
			//     v37);
			//   if ( v24 )
			//     System::Array::CopyTo(v24, (Array *)this.fields.dependencies, 0, 0LL);
			//   if ( v27 )
			//     System::Array::CopyTo((Array *)v27, (Array *)this.fields.dependencies, this.fields.dependencySeparator, 0LL);
			//   dependencies = this.fields.dependencies;
			//   if ( dependencies )
			//     v25 = dependencies.max_length.size;
			//   this.fields.indentLevel = v25;
			// }
			// 
		}

		public static Dictionary<FrameSettingsField, string> GetEnumNameMap()
		{
			// // Dictionary`2[HG.Rendering.Runtime.FrameSettingsField,System.String] GetEnumNameMap()
			// Dictionary_2_HG_Rendering_Runtime_FrameSettingsField_System_String_ *HG::Rendering::Runtime::FrameSettingsFieldAttribute::GetEnumNameMap(
			//         MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   MethodInfo *v2; // rdi
			//   String *v3; // r14
			//   String__Array *v4; // r15
			//   struct FrameSettingsFieldAttribute__Class *v5; // rcx
			//   Dictionary_2_System_Int32Enum_System_Object_ *v6; // rax
			//   __int64 v7; // rcx
			//   Dictionary_2_HG_Rendering_Runtime_FrameSettingsField_System_String_ *v8; // rbx
			//   OneofDescriptorProto *v10; // rdx
			//   FileDescriptor *v11; // r8
			//   MessageDescriptor *v12; // r9
			//   struct FrameSettingsFieldAttribute__Class *v13; // rax
			//   __int64 v14; // rdx
			//   struct Il2CppType *v15; // rbx
			//   __int64 v16; // rdx
			//   Type *TypeFromHandle; // rbp
			//   String__Array *Names; // rsi
			//   int32_t v19; // ebx
			//   String *v20; // r15
			//   MemberInfo_1 *v21; // rax
			//   struct FrameSettingsFieldAttribute__Class *v22; // rax
			//   Dictionary_2_System_Int32Enum_System_Object_ *s_FrameSettingsEnumNameMap; // r14
			//   Object *v24; // rax
			//   MethodInfo *v25; // rdi
			//   Int32Enum__Enum *v26; // rax
			// 
			//   if ( !byte_18D8ED958 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Reflection::CustomAttributeExtensions::GetCustomAttribute<System::ObsoleteAttribute>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>);
			//     sub_18003C530(&TypeInfo::System::Enum);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute);
			//     sub_18003C530(&TypeRef::HG::Rendering::Runtime::FrameSettingsField);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsField);
			//     sub_18003C530(&TypeInfo::System::Type);
			//     byte_18D8ED958 = 1;
			//   }
			//   v5 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//   if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute, v1);
			//     v5 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//   }
			//   if ( !v5.static_fields.s_FrameSettingsEnumNameMap )
			//   {
			//     v6 = (Dictionary_2_System_Int32Enum_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>);
			//     v8 = (Dictionary_2_HG_Rendering_Runtime_FrameSettingsField_System_String_ *)v6;
			//     if ( !v6 )
			//       goto LABEL_7;
			//     System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::Dictionary(
			//       v6,
			//       MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::Dictionary);
			//     v13 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//     if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute, v10);
			//       v13 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//     }
			//     v13.static_fields.s_FrameSettingsEnumNameMap = v8;
			//     sub_1800054D0(
			//       (OneofDescriptor *)&TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute.static_fields.s_FrameSettingsEnumNameMap,
			//       v10,
			//       v11,
			//       v12,
			//       v4,
			//       v3,
			//       v2);
			//     v15 = TypeRef::HG::Rendering::Runtime::FrameSettingsField;
			//     if ( !TypeInfo::System::Type._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::System::Type, v14);
			//     TypeFromHandle = System::Type::GetTypeFromHandle((RuntimeTypeHandle)v15, 0LL);
			//     if ( !TypeInfo::System::Enum._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::System::Enum, v16);
			//     Names = System::Enum::GetNames(TypeFromHandle, 0LL);
			//     v19 = 0;
			//     if ( !Names )
			// LABEL_7:
			//       sub_180B536AC(v7, v1);
			//     while ( v19 < Names.max_length.size )
			//     {
			//       if ( (unsigned int)v19 >= Names.max_length.size )
			//         sub_180070270(v7, v1);
			//       if ( !TypeFromHandle )
			//         goto LABEL_7;
			//       v20 = Names.vector[v19];
			//       v21 = (MemberInfo_1 *)sub_180055F60(v7, TypeFromHandle, v20, 28LL);
			//       if ( !System::Reflection::CustomAttributeExtensions::GetCustomAttribute<System::Object>(
			//               v21,
			//               MethodInfo::System::Reflection::CustomAttributeExtensions::GetCustomAttribute<System::ObsoleteAttribute>) )
			//       {
			//         v22 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//         if ( !TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute, v1);
			//           v22 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//         }
			//         s_FrameSettingsEnumNameMap = (Dictionary_2_System_Int32Enum_System_Object_ *)v22.static_fields.s_FrameSettingsEnumNameMap;
			//         if ( !TypeInfo::System::Enum._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::System::Enum, v1);
			//         v24 = System::Enum::Parse(TypeFromHandle, v20, 0LL);
			//         if ( !s_FrameSettingsEnumNameMap )
			//           goto LABEL_7;
			//         v25 = MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::FrameSettingsField,System::String>::Add;
			//         v26 = (Int32Enum__Enum *)sub_18004A160(v24);
			//         System::Collections::Generic::Dictionary<System::Int32Enum,System::Object>::Add(
			//           s_FrameSettingsEnumNameMap,
			//           *v26,
			//           (Object *)v20,
			//           v25);
			//       }
			//       ++v19;
			//     }
			//     v5 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//   }
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, v1);
			//     v5 = TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute;
			//   }
			//   return v5.static_fields.s_FrameSettingsEnumNameMap;
			// }
			// 
			return null;
		}

		public bool IsNegativeDependency(FrameSettingsField frameSettingsField)
		{
			// // Boolean IsNegativeDependency(FrameSettingsField)
			// bool HG::Rendering::Runtime::FrameSettingsFieldAttribute::IsNegativeDependency(
			//         FrameSettingsFieldAttribute *this,
			//         FrameSettingsField__Enum frameSettingsField,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Object *v8; // rbx
			//   FrameSettingsField__Enum__Array *dependencies; // rbp
			//   Predicate_1_UInt32_ *v10; // rax
			//   Predicate_1_Int32Enum_ *v11; // rdi
			// 
			//   if ( !byte_18D9193D6 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::FindIndex<HG::Rendering::Runtime::FrameSettingsField>);
			//     sub_18003C530(&TypeInfo::System::Predicate<HG::Rendering::Runtime::FrameSettingsField>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute::__c__DisplayClass15_0::_IsNegativeDependency_b__0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute::__c__DisplayClass15_0);
			//     byte_18D9193D6 = 1;
			//   }
			//   v5 = sub_180004920(TypeInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute::__c__DisplayClass15_0);
			//   v8 = (Object *)v5;
			//   if ( !v5
			//     || (*(_DWORD *)(v5 + 16) = frameSettingsField,
			//         dependencies = this.fields.dependencies,
			//         v10 = (Predicate_1_UInt32_ *)sub_180004920(TypeInfo::System::Predicate<HG::Rendering::Runtime::FrameSettingsField>),
			//         (v11 = (Predicate_1_Int32Enum_ *)v10) == 0LL) )
			//   {
			//     sub_180B536AC(v7, v6);
			//   }
			//   System::Predicate<unsigned int>::Predicate(
			//     v10,
			//     v8,
			//     MethodInfo::HG::Rendering::Runtime::FrameSettingsFieldAttribute::__c__DisplayClass15_0::_IsNegativeDependency_b__0,
			//     0LL);
			//   return System::Array::FindIndex<System::Int32Enum>(
			//            (Int32Enum__Enum__Array *)dependencies,
			//            v11,
			//            MethodInfo::System::Array::FindIndex<HG::Rendering::Runtime::FrameSettingsField>) >= this.fields.dependencySeparator;
			// }
			// 
			return default(bool);
		}

		public readonly FrameSettingsFieldAttribute.DisplayType type;

		public readonly string displayedName;

		public readonly string tooltip;

		public readonly int group;

		public readonly int orderInGroup;

		public readonly Type targetType;

		public readonly int indentLevel;

		public readonly FrameSettingsField[] dependencies;

		private readonly int dependencySeparator;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static int autoOrder;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static Dictionary<FrameSettingsField, string> s_FrameSettingsEnumNameMap;

		public enum DisplayType
		{
			BoolAsCheckbox,
			BoolAsEnumPopup,
			Others
		}
	}
}
