using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace IniParser.Model
{
	[DefaultMember("Item")]
	public class PropertyCollection : IDeepCloneable<PropertyCollection>, IEnumerable<Property>, IEnumerable
	{
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000025D0 File Offset: 0x000007D0
		public string Item
		{
			get
			{
				// // String get_Item(String)
				// String *IniParser::Model::PropertyCollection::get_Item(PropertyCollection *this, String *keyName, MethodInfo *method)
				// {
				//   Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
				//   Object *Item; // rax
				// 
				//   if ( !byte_18D9192DD )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::get_Item);
				//     byte_18D9192DD = 1;
				//   }
				//   properties = this.fields._properties;
				//   if ( !properties )
				//     goto LABEL_9;
				//   if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
				//           (Dictionary_2_System_Object_System_Object_ *)properties,
				//           (Object *)keyName,
				//           MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey) )
				//     return 0LL;
				//   properties = this.fields._properties;
				//   if ( !properties
				//     || (Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
				//                  (Dictionary_2_System_Object_System_Object_ *)properties,
				//                  (Object *)keyName,
				//                  MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::get_Item)) == 0LL )
				//   {
				// LABEL_9:
				//     sub_180B536AC(properties, keyName);
				//   }
				//   return (String *)Item[1].klass;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_Item(String, String)
				// void IniParser::Model::PropertyCollection::set_Item(
				//         PropertyCollection *this,
				//         String *keyName,
				//         String *value,
				//         MethodInfo *method)
				// {
				//   Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
				//   Object *Item; // rax
				//   VolumetricPipelineRT **v9; // r8
				//   Transform **v10; // r9
				//   MeshRenderer **v11; // [rsp+50h] [rbp+28h]
				//   Vector3 *v12; // [rsp+58h] [rbp+30h]
				//   Quaternion *v13; // [rsp+60h] [rbp+38h]
				//   Vector3 *v14; // [rsp+68h] [rbp+40h]
				//   Object *v15; // [rsp+70h] [rbp+48h]
				//   Object *v16; // [rsp+78h] [rbp+50h]
				//   Object *v17; // [rsp+80h] [rbp+58h]
				//   Object *v18; // [rsp+88h] [rbp+60h]
				//   MethodInfo *v19; // [rsp+90h] [rbp+68h]
				// 
				//   if ( !byte_18D9192DE )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::get_Item);
				//     byte_18D9192DE = 1;
				//   }
				//   properties = this.fields._properties;
				//   if ( !properties )
				//     goto LABEL_9;
				//   if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
				//           (Dictionary_2_System_Object_System_Object_ *)properties,
				//           (Object *)keyName,
				//           MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey) )
				//     IniParser::Model::PropertyCollection::Add(this, keyName, 0LL);
				//   properties = this.fields._properties;
				//   if ( !properties
				//     || (Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
				//                  (Dictionary_2_System_Object_System_Object_ *)properties,
				//                  (Object *)keyName,
				//                  MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::get_Item)) == 0LL )
				//   {
				// LABEL_9:
				//     sub_180B536AC(properties, keyName);
				//   }
				//   Item[1].klass = (Object__Class *)value;
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper_2 *)&Item[1],
				//     (UberPostPassUtils_ColorGradingData **)keyName,
				//     v9,
				//     v10,
				//     v11,
				//     v12,
				//     v13,
				//     v14,
				//     v15,
				//     v16,
				//     v17,
				//     v18,
				//     v19);
				// }
				// 
			}
		}

		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002608 File Offset: 0x00000808
		public int Count
		{
			get
			{
				// // Int32 get_Count()
				// int32_t IniParser::Model::PropertyCollection::get_Count(PropertyCollection *this, MethodInfo *method)
				// {
				//   Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
				// 
				//   if ( !byte_18D9192DF )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::get_Count);
				//     byte_18D9192DF = 1;
				//   }
				//   properties = this.fields._properties;
				//   if ( !properties )
				//     sub_180B536AC(0LL, method);
				//   return properties.fields._count - properties.fields._freeCount;
				// }
				// 
				return 0;
			}
		}

		public PropertyCollection()
		{
			// // PropertyCollection()
			// void IniParser::Model::PropertyCollection::PropertyCollection(PropertyCollection *this, MethodInfo *method)
			// {
			//   IEqualityComparer_1_System_String_ *v3; // rax
			// 
			//   if ( !byte_18D8ED924 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::EqualityComparer<System::String>::get_Default);
			//     byte_18D8ED924 = 1;
			//   }
			//   v3 = (IEqualityComparer_1_System_String_ *)sub_182720420(MethodInfo::System::Collections::Generic::EqualityComparer<System::String>::get_Default);
			//   IniParser::Model::PropertyCollection::PropertyCollection(this, v3, 0LL);
			// }
			// 
		}

		public PropertyCollection(IEqualityComparer<string> searchComparer)
		{
		}

		public PropertyCollection(PropertyCollection ori, IEqualityComparer<string> searchComparer)
		{
			// // PropertyCollection(PropertyCollection, IEqualityComparer`1[System.String])
			// // Hidden C++ exception states: #wind=1
			// void IniParser::Model::PropertyCollection::PropertyCollection(
			//         PropertyCollection *this,
			//         PropertyCollection *ori,
			//         IEqualityComparer_1_System_String_ *searchComparer,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rax
			//   __int64 v14; // rdx
			//   Property *v15; // rbx
			//   Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
			//   bool v17; // al
			//   Dictionary_2_System_String_IniParser_Model_Property_ *v18; // rdi
			//   Object *Key_k__BackingField; // rsi
			//   Object *v20; // rax
			//   __int64 v21; // rdx
			//   __int64 v22; // rcx
			//   Object *v23; // rax
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   _QWORD v26[4]; // [rsp+28h] [rbp-20h] BYREF
			//   IEnumerator_1_IniParser_Model_Property_ *Enumerator; // [rsp+58h] [rbp+10h] BYREF
			// 
			//   if ( !byte_18D9192DC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::set_Item);
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Property>);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     byte_18D9192DC = 1;
			//   }
			//   IniParser::Model::PropertyCollection::PropertyCollection(this, searchComparer, 0LL);
			//   if ( !ori )
			//     sub_180B536AC(v8, v7);
			//   Enumerator = IniParser::Model::PropertyCollection::GetEnumerator(ori, 0LL);
			//   v26[0] = 0LL;
			//   v26[1] = &Enumerator;
			//   while ( 1 )
			//   {
			//     if ( !Enumerator )
			//       sub_1802DC2C8(v10, v9);
			//     if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//       break;
			//     if ( !Enumerator )
			//       sub_1802DC2C8(v12, v11);
			//     v13 = sub_18005E5B0();
			//     v15 = (Property *)v13;
			//     properties = this.fields._properties;
			//     if ( !v13 )
			//       sub_1802DC2C8(properties, v14);
			//     if ( !properties )
			//       sub_1802DC2C8(0LL, v14);
			//     v17 = System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			//             (Dictionary_2_System_Object_System_Object_ *)properties,
			//             *(Object **)(v13 + 24),
			//             MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey);
			//     v18 = this.fields._properties;
			//     Key_k__BackingField = (Object *)v15.fields._Key_k__BackingField;
			//     if ( v17 )
			//     {
			//       v23 = (Object *)IniParser::Model::Property::DeepClone(v15, 0LL);
			//       if ( !v18 )
			//         sub_1802DC2C8(v25, v24);
			//       System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
			//         (Dictionary_2_System_Object_System_Object_ *)v18,
			//         Key_k__BackingField,
			//         v23,
			//         MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::set_Item);
			//     }
			//     else
			//     {
			//       v20 = (Object *)IniParser::Model::Property::DeepClone(v15, 0LL);
			//       if ( !v18 )
			//         sub_1802DC2C8(v22, v21);
			//       System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
			//         (Dictionary_2_System_Object_System_Object_ *)v18,
			//         Key_k__BackingField,
			//         v20,
			//         MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::Add);
			//     }
			//   }
			//   sub_1801E4D90(v26);
			// }
			// 
		}

		public bool Add(string key)
		{
			// // Boolean Add(String)
			// bool IniParser::Model::PropertyCollection::Add(PropertyCollection *this, String *key, MethodInfo *method)
			// {
			//   Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
			//   String *Empty; // rbp
			//   Property *v8; // rax
			//   Property *v9; // rdi
			// 
			//   if ( !byte_18D9192E0 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey);
			//     sub_18003C530(&TypeInfo::IniParser::Model::Property);
			//     sub_18003C530(&TypeInfo::System::String);
			//     byte_18D9192E0 = 1;
			//   }
			//   properties = this.fields._properties;
			//   if ( !properties )
			//     goto LABEL_8;
			//   if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			//          (Dictionary_2_System_Object_System_Object_ *)properties,
			//          (Object *)key,
			//          MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey) )
			//   {
			//     return 0;
			//   }
			//   Empty = TypeInfo::System::String.static_fields.Empty;
			//   v8 = (Property *)sub_180004920(TypeInfo::IniParser::Model::Property);
			//   v9 = v8;
			//   if ( !v8 )
			// LABEL_8:
			//     sub_180B536AC(properties, key);
			//   IniParser::Model::Property::Property(v8, key, Empty, 0LL);
			//   IniParser::Model::PropertyCollection::AddPropertyInternal(this, v9, 0LL);
			//   return 1;
			// }
			// 
			return default(bool);
		}

		public bool Add(Property property)
		{
			// // Boolean Add(Property)
			// bool IniParser::Model::PropertyCollection::Add(PropertyCollection *this, Property *property, MethodInfo *method)
			// {
			//   Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
			// 
			//   if ( !byte_18D9192E1 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey);
			//     byte_18D9192E1 = 1;
			//   }
			//   properties = this.fields._properties;
			//   if ( !property || !properties )
			//     sub_180B536AC(properties, property);
			//   if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			//          (Dictionary_2_System_Object_System_Object_ *)properties,
			//          (Object *)property.fields._Key_k__BackingField,
			//          MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey) )
			//   {
			//     return 0;
			//   }
			//   IniParser::Model::PropertyCollection::AddPropertyInternal(this, property, 0LL);
			//   return 1;
			// }
			// 
			return default(bool);
		}

		public bool Add(string key, string value)
		{
			return default(bool);
		}

		public void ClearComments()
		{
			// // Void ClearComments()
			// // Hidden C++ exception states: #wind=1
			// void IniParser::Model::PropertyCollection::ClearComments(PropertyCollection *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Property *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   List_1_System_String_ *Comments; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   _QWORD v13[4]; // [rsp+28h] [rbp-20h] BYREF
			//   IEnumerator_1_IniParser_Model_Property_ *Enumerator; // [rsp+60h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D9192E2 )
			//   {
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Property>);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::Clear);
			//     byte_18D9192E2 = 1;
			//   }
			//   Enumerator = IniParser::Model::PropertyCollection::GetEnumerator(this, 0LL);
			//   v13[0] = 0LL;
			//   v13[1] = &Enumerator;
			//   while ( 1 )
			//   {
			//     if ( !Enumerator )
			//       sub_1802DC2C8(v4, v3);
			//     if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//       break;
			//     if ( !Enumerator )
			//       sub_1802DC2C8(v6, v5);
			//     v7 = (Property *)sub_18005E5B0();
			//     if ( !v7 )
			//       sub_1802DC2C8(v9, v8);
			//     Comments = IniParser::Model::Property::get_Comments(v7, 0LL);
			//     if ( !Comments )
			//       sub_1802DC2C8(v12, v11);
			//     sub_1823B99D0(Comments, MethodInfo::System::Collections::Generic::List<System::String>::Clear);
			//   }
			//   sub_1801E4D90(v13);
			// }
			// 
		}

		public bool Contains(string keyName)
		{
			// // Boolean Contains(String)
			// bool IniParser::Model::PropertyCollection::Contains(PropertyCollection *this, String *keyName, MethodInfo *method)
			// {
			//   Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
			// 
			//   if ( !byte_18D8ED927 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey);
			//     byte_18D8ED927 = 1;
			//   }
			//   properties = this.fields._properties;
			//   if ( !properties )
			//     sub_180B536AC(0LL, keyName);
			//   return System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			//            (Dictionary_2_System_Object_System_Object_ *)properties,
			//            (Object *)keyName,
			//            MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey);
			// }
			// 
			return default(bool);
		}

		public Property FindByKey(string keyName)
		{
			// // Property FindByKey(String)
			// Property *IniParser::Model::PropertyCollection::FindByKey(
			//         PropertyCollection *this,
			//         String *keyName,
			//         MethodInfo *method)
			// {
			//   Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
			// 
			//   if ( !byte_18D8ED928 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::get_Item);
			//     byte_18D8ED928 = 1;
			//   }
			//   properties = this.fields._properties;
			//   if ( !properties )
			//     goto LABEL_7;
			//   if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			//          (Dictionary_2_System_Object_System_Object_ *)properties,
			//          (Object *)keyName,
			//          MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::ContainsKey) )
			//   {
			//     properties = this.fields._properties;
			//     if ( properties )
			//       return (Property *)System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			//                            (Dictionary_2_System_Object_System_Object_ *)properties,
			//                            (Object *)keyName,
			//                            MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::get_Item);
			// LABEL_7:
			//     sub_180B536AC(properties, keyName);
			//   }
			//   return 0LL;
			// }
			// 
			return null;
		}

		public void Merge(PropertyCollection propertyToMerge)
		{
			// // Void Merge(PropertyCollection)
			// // Hidden C++ exception states: #wind=1
			// void IniParser::Model::PropertyCollection::Merge(
			//         PropertyCollection *this,
			//         PropertyCollection *propertyToMerge,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Property *v12; // rbx
			//   Property *v13; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   List_1_System_Object_ *Comments; // rdi
			//   IEnumerable_1_System_Object_ *v17; // rax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   _QWORD v20[4]; // [rsp+28h] [rbp-20h] BYREF
			//   IEnumerator_1_IniParser_Model_Property_ *Enumerator; // [rsp+58h] [rbp+10h] BYREF
			// 
			//   if ( !byte_18D9192E3 )
			//   {
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Property>);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::AddRange);
			//     byte_18D9192E3 = 1;
			//   }
			//   if ( !propertyToMerge )
			//     sub_180B536AC(this, propertyToMerge);
			//   Enumerator = IniParser::Model::PropertyCollection::GetEnumerator(propertyToMerge, 0LL);
			//   v20[0] = 0LL;
			//   v20[1] = &Enumerator;
			//   while ( 1 )
			//   {
			//     if ( !Enumerator )
			//       sub_1802DC2C8(v6, v5);
			//     if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//       break;
			//     if ( !Enumerator )
			//       sub_1802DC2C8(v8, v7);
			//     v9 = sub_18005E5B0();
			//     v12 = (Property *)v9;
			//     if ( !v9 )
			//       sub_1802DC2C8(v11, v10);
			//     IniParser::Model::PropertyCollection::Add(this, *(String **)(v9 + 24), 0LL);
			//     IniParser::Model::PropertyCollection::set_Item(
			//       this,
			//       v12.fields._Key_k__BackingField,
			//       v12.fields._Value_k__BackingField,
			//       0LL);
			//     v13 = IniParser::Model::PropertyCollection::FindByKey(this, v12.fields._Key_k__BackingField, 0LL);
			//     if ( !v13 )
			//       sub_1802DC2C8(v15, v14);
			//     Comments = (List_1_System_Object_ *)IniParser::Model::Property::get_Comments(v13, 0LL);
			//     v17 = (IEnumerable_1_System_Object_ *)IniParser::Model::Property::get_Comments(v12, 0LL);
			//     if ( !Comments )
			//       sub_1802DC2C8(v19, v18);
			//     System::Collections::Generic::List<System::Object>::AddRange(
			//       Comments,
			//       v17,
			//       MethodInfo::System::Collections::Generic::List<System::String>::AddRange);
			//   }
			//   sub_1801E4D90(v20);
			// }
			// 
		}

		public void Clear()
		{
			// // Void Clear()
			// void IniParser::Model::PropertyCollection::Clear(PropertyCollection *this, MethodInfo *method)
			// {
			//   Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
			// 
			//   if ( !byte_18D8ED929 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::Clear);
			//     byte_18D8ED929 = 1;
			//   }
			//   properties = this.fields._properties;
			//   if ( !properties )
			//     sub_180B536AC(0LL, method);
			//   System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//     (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)properties,
			//     MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::Clear);
			// }
			// 
		}

		public bool Remove(string keyName)
		{
			// // Boolean Remove(String)
			// bool IniParser::Model::PropertyCollection::Remove(PropertyCollection *this, String *keyName, MethodInfo *method)
			// {
			//   Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rcx
			// 
			//   if ( !byte_18D9192E4 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::Remove);
			//     byte_18D9192E4 = 1;
			//   }
			//   properties = this.fields._properties;
			//   if ( !properties )
			//     sub_180B536AC(0LL, keyName);
			//   return System::Collections::Generic::Dictionary<System::Object,System::Object>::Remove(
			//            (Dictionary_2_System_Object_System_Object_ *)properties,
			//            (Object *)keyName,
			//            MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::Remove);
			// }
			// 
			return default(bool);
		}

		public IEnumerator<Property> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			// // IEnumerator System.Collections.IEnumerable.GetEnumerator()
			// IEnumerator *IniParser::Model::PropertyCollection::System_Collections_IEnumerable_GetEnumerator(
			//         PropertyCollection *this,
			//         MethodInfo *method)
			// {
			//   Dictionary_2_System_String_IniParser_Model_Property_ *properties; // rdx
			//   __int64 v4; // r8
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v6; // [rsp+20h] [rbp-58h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v7; // [rsp+48h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D9192E5 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,IniParser::Model::Property>);
			//     byte_18D9192E5 = 1;
			//   }
			//   properties = this.fields._properties;
			//   if ( !properties )
			//     sub_180B536AC(this, 0LL);
			//   System::Collections::Generic::Dictionary<System::Object,System::Object>::GetEnumerator(
			//     &v6,
			//     (Dictionary_2_System_Object_System_Object_ *)properties,
			//     MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Property>::GetEnumerator);
			//   v7 = v6;
			//   return (IEnumerator *)il2cpp_value_box_0(
			//                           TypeInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,IniParser::Model::Property>,
			//                           &v7,
			//                           v4);
			// }
			// 
			return null;
		}

		public PropertyCollection DeepClone()
		{
			// // PropertyCollection DeepClone()
			// PropertyCollection *IniParser::Model::PropertyCollection::DeepClone(PropertyCollection *this, MethodInfo *method)
			// {
			//   IEqualityComparer_1_System_String_ *searchComparer; // rsi
			//   PropertyCollection *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   PropertyCollection *v7; // rbx
			// 
			//   if ( !byte_18D9192E6 )
			//   {
			//     sub_18003C530(&TypeInfo::IniParser::Model::PropertyCollection);
			//     byte_18D9192E6 = 1;
			//   }
			//   searchComparer = this.fields._searchComparer;
			//   v4 = (PropertyCollection *)sub_180004920(TypeInfo::IniParser::Model::PropertyCollection);
			//   v7 = v4;
			//   if ( !v4 )
			//     sub_180B536AC(v6, v5);
			//   IniParser::Model::PropertyCollection::PropertyCollection(v4, this, searchComparer, 0LL);
			//   return v7;
			// }
			// 
			return null;
		}

		internal void AddPropertyInternal(Property property)
		{
		}

		internal Property GetLast()
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

		private Property _lastAdded;

		private readonly Dictionary<string, Property> _properties;

		private readonly IEqualityComparer<string> _searchComparer;
	}
}
