using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace IniParser.Model
{
	[DefaultMember("Item")]
	public class SectionCollection : IDeepCloneable<SectionCollection>, IEnumerable<Section>, IEnumerable
	{
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002608 File Offset: 0x00000808
		public int Count
		{
			get
			{
				// // Int32 get_Count()
				// int32_t IniParser::Model::SectionCollection::get_Count(SectionCollection *this, MethodInfo *method)
				// {
				//   Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rax
				// 
				//   if ( !byte_18D8ED932 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::get_Count);
				//     byte_18D8ED932 = 1;
				//   }
				//   sections = this.fields._sections;
				//   if ( !sections )
				//     sub_180B536AC(this, method);
				//   return sections.fields._count - sections.fields._freeCount;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000025D2 File Offset: 0x000007D2
		public PropertyCollection Item
		{
			get
			{
				// // PropertyCollection get_Item(String)
				// PropertyCollection *IniParser::Model::SectionCollection::get_Item(
				//         SectionCollection *this,
				//         String *sectionName,
				//         MethodInfo *method)
				// {
				//   Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rcx
				//   Object *Item; // rax
				// 
				//   if ( !byte_18D9192EE )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::ContainsKey);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::get_Item);
				//     byte_18D9192EE = 1;
				//   }
				//   sections = this.fields._sections;
				//   if ( !sections )
				//     goto LABEL_9;
				//   if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
				//           (Dictionary_2_System_Object_System_Object_ *)sections,
				//           (Object *)sectionName,
				//           MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::ContainsKey) )
				//     return 0LL;
				//   sections = this.fields._sections;
				//   if ( !sections
				//     || (Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
				//                  (Dictionary_2_System_Object_System_Object_ *)sections,
				//                  (Object *)sectionName,
				//                  MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::get_Item)) == 0LL )
				//   {
				// LABEL_9:
				//     sub_180B536AC(sections, sectionName);
				//   }
				//   return (PropertyCollection *)Item[1].klass;
				// }
				// 
				return null;
			}
		}

		public SectionCollection()
		{
			// // SectionCollection()
			// void IniParser::Model::SectionCollection::SectionCollection(SectionCollection *this, MethodInfo *method)
			// {
			//   IEqualityComparer_1_System_String_ *v3; // rax
			// 
			//   if ( !byte_18D8ED930 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::EqualityComparer<System::String>::get_Default);
			//     byte_18D8ED930 = 1;
			//   }
			//   v3 = (IEqualityComparer_1_System_String_ *)sub_182720420(MethodInfo::System::Collections::Generic::EqualityComparer<System::String>::get_Default);
			//   IniParser::Model::SectionCollection::SectionCollection(this, v3, 0LL);
			// }
			// 
		}

		public SectionCollection(IEqualityComparer<string> searchComparer)
		{
		}

		public SectionCollection(SectionCollection ori, IEqualityComparer<string> searchComparer)
		{
		}

		public bool Add(string sectionName)
		{
			// // Boolean Add(String)
			// bool IniParser::Model::SectionCollection::Add(SectionCollection *this, String *sectionName, MethodInfo *method)
			// {
			//   IEqualityComparer_1_System_String_ *searchComparer; // rbp
			//   Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rsi
			//   Section *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Object *v10; // rbx
			// 
			//   if ( !byte_18D8ED933 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Add);
			//     sub_18003C530(&TypeInfo::IniParser::Model::Section);
			//     byte_18D8ED933 = 1;
			//   }
			//   if ( IniParser::Model::SectionCollection::Contains(this, sectionName, 0LL) )
			//     return 0;
			//   searchComparer = this.fields._searchComparer;
			//   sections = this.fields._sections;
			//   v7 = (Section *)sub_180004920(TypeInfo::IniParser::Model::Section);
			//   v10 = (Object *)v7;
			//   if ( !v7 || (IniParser::Model::Section::Section(v7, sectionName, searchComparer, 0LL), !sections) )
			//     sub_180B536AC(v9, v8);
			//   System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
			//     (Dictionary_2_System_Object_System_Object_ *)sections,
			//     (Object *)sectionName,
			//     v10,
			//     MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Add);
			//   return 1;
			// }
			// 
			return default(bool);
		}

		public void Add(Section data)
		{
			// // Void Add(Section)
			// void IniParser::Model::SectionCollection::Add(SectionCollection *this, Section *data, MethodInfo *method)
			// {
			//   bool v5; // al
			//   Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rdi
			//   Object *name; // rbp
			//   IEqualityComparer_1_System_String_ *searchComparer; // r14
			//   Section *v9; // rax
			//   Object *v10; // rsi
			//   Section *v11; // rax
			//   Object *v12; // rsi
			// 
			//   if ( !byte_18D9192EF )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::set_Item);
			//     sub_18003C530(&TypeInfo::IniParser::Model::Section);
			//     byte_18D9192EF = 1;
			//   }
			//   if ( !data )
			//     goto LABEL_11;
			//   v5 = IniParser::Model::SectionCollection::Contains(this, data.fields._name, 0LL);
			//   sections = this.fields._sections;
			//   name = (Object *)data.fields._name;
			//   searchComparer = this.fields._searchComparer;
			//   if ( !v5 )
			//   {
			//     v9 = (Section *)sub_180004920(TypeInfo::IniParser::Model::Section);
			//     v10 = (Object *)v9;
			//     if ( v9 )
			//     {
			//       IniParser::Model::Section::Section(v9, data, searchComparer, 0LL);
			//       if ( sections )
			//       {
			//         System::Collections::Generic::Dictionary<System::Object,System::Object>::Add(
			//           (Dictionary_2_System_Object_System_Object_ *)sections,
			//           name,
			//           v10,
			//           MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Add);
			//         return;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(this, data);
			//   }
			//   v11 = (Section *)sub_180004920(TypeInfo::IniParser::Model::Section);
			//   v12 = (Object *)v11;
			//   if ( !v11 )
			//     goto LABEL_11;
			//   IniParser::Model::Section::Section(v11, data, searchComparer, 0LL);
			//   if ( !sections )
			//     goto LABEL_11;
			//   System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
			//     (Dictionary_2_System_Object_System_Object_ *)sections,
			//     name,
			//     v12,
			//     MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::set_Item);
			// }
			// 
		}

		public void Clear()
		{
			// // Void Clear()
			// void IniParser::Model::SectionCollection::Clear(SectionCollection *this, MethodInfo *method)
			// {
			//   Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rcx
			// 
			//   if ( !byte_18D8ED934 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Clear);
			//     byte_18D8ED934 = 1;
			//   }
			//   sections = this.fields._sections;
			//   if ( !sections )
			//     sub_180B536AC(0LL, method);
			//   System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//     (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)sections,
			//     MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Clear);
			// }
			// 
		}

		public bool Contains(string sectionName)
		{
			// // Boolean Contains(String)
			// bool IniParser::Model::SectionCollection::Contains(SectionCollection *this, String *sectionName, MethodInfo *method)
			// {
			//   Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rcx
			// 
			//   if ( !byte_18D8ED935 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::ContainsKey);
			//     byte_18D8ED935 = 1;
			//   }
			//   sections = this.fields._sections;
			//   if ( !sections )
			//     sub_180B536AC(0LL, sectionName);
			//   return System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			//            (Dictionary_2_System_Object_System_Object_ *)sections,
			//            (Object *)sectionName,
			//            MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::ContainsKey);
			// }
			// 
			return default(bool);
		}

		public Section FindByName(string sectionName)
		{
			// // Section FindByName(String)
			// Section *IniParser::Model::SectionCollection::FindByName(
			//         SectionCollection *this,
			//         String *sectionName,
			//         MethodInfo *method)
			// {
			//   Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rcx
			// 
			//   if ( !byte_18D8ED936 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::get_Item);
			//     byte_18D8ED936 = 1;
			//   }
			//   sections = this.fields._sections;
			//   if ( !sections )
			//     goto LABEL_8;
			//   if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			//          (Dictionary_2_System_Object_System_Object_ *)sections,
			//          (Object *)sectionName,
			//          MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::ContainsKey) )
			//   {
			//     sections = this.fields._sections;
			//     if ( sections )
			//       return (Section *)System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			//                           (Dictionary_2_System_Object_System_Object_ *)sections,
			//                           (Object *)sectionName,
			//                           MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::get_Item);
			// LABEL_8:
			//     sub_180B536AC(sections, sectionName);
			//   }
			//   return 0LL;
			// }
			// 
			return null;
		}

		public void Merge(SectionCollection sectionsToMerge)
		{
			// // Void Merge(SectionCollection)
			// // Hidden C++ exception states: #wind=1
			// void IniParser::Model::SectionCollection::Merge(
			//         SectionCollection *this,
			//         SectionCollection *sectionsToMerge,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rbx
			//   PropertyCollection *Item; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   Il2CppExceptionWrapper *v16; // [rsp+20h] [rbp-28h] BYREF
			//   _QWORD v17[4]; // [rsp+28h] [rbp-20h] BYREF
			//   IEnumerator_1_IniParser_Model_Section_ *Enumerator; // [rsp+58h] [rbp+10h] BYREF
			// 
			//   if ( !byte_18D9192F0 )
			//   {
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Section>);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     byte_18D9192F0 = 1;
			//   }
			//   if ( !sectionsToMerge )
			//     sub_180B536AC(this, sectionsToMerge);
			//   Enumerator = IniParser::Model::SectionCollection::GetEnumerator(sectionsToMerge, 0LL);
			//   v17[0] = 0LL;
			//   v17[1] = &Enumerator;
			//   try
			//   {
			//     while ( 1 )
			//     {
			//       if ( !Enumerator )
			//         sub_1802DC2C8(v6, v5);
			//       if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//         break;
			//       if ( !Enumerator )
			//         sub_1802DC2C8(v8, v7);
			//       v9 = sub_18005E510();
			//       v12 = v9;
			//       if ( !v9 )
			//         sub_1802DC2C8(v11, v10);
			//       if ( !IniParser::Model::SectionCollection::FindByName(this, *(String **)(v9 + 32), 0LL) )
			//         IniParser::Model::SectionCollection::Add(this, *(String **)(v12 + 32), 0LL);
			//       Item = IniParser::Model::SectionCollection::get_Item(this, *(String **)(v12 + 32), 0LL);
			//       if ( !Item )
			//         sub_1802DC2C8(v15, v14);
			//       IniParser::Model::PropertyCollection::Merge(Item, *(PropertyCollection **)(v12 + 16), 0LL);
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v16 )
			//   {
			//     v17[0] = v16.ex;
			//   }
			//   sub_1801E4D90(v17);
			// }
			// 
		}

		public bool Remove(string sectionName)
		{
			// // Boolean Remove(String)
			// bool IniParser::Model::SectionCollection::Remove(SectionCollection *this, String *sectionName, MethodInfo *method)
			// {
			//   Dictionary_2_System_String_IniParser_Model_Section_ *sections; // rcx
			// 
			//   if ( !byte_18D9192F1 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Remove);
			//     byte_18D9192F1 = 1;
			//   }
			//   sections = this.fields._sections;
			//   if ( !sections )
			//     sub_180B536AC(0LL, sectionName);
			//   return System::Collections::Generic::Dictionary<System::Object,System::Object>::Remove(
			//            (Dictionary_2_System_Object_System_Object_ *)sections,
			//            (Object *)sectionName,
			//            MethodInfo::System::Collections::Generic::Dictionary<System::String,IniParser::Model::Section>::Remove);
			// }
			// 
			return default(bool);
		}

		public IEnumerator<Section> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			// // IEnumerator System.Collections.IEnumerable.GetEnumerator()
			// IEnumerator *IniParser::Model::SectionCollection::System_Collections_IEnumerable_GetEnumerator(
			//         SectionCollection *this,
			//         MethodInfo *method)
			// {
			//   return (IEnumerator *)IniParser::Model::SectionCollection::GetEnumerator(this, 0LL);
			// }
			// 
			return null;
		}

		public SectionCollection DeepClone()
		{
			// // SectionCollection DeepClone()
			// SectionCollection *IniParser::Model::SectionCollection::DeepClone(SectionCollection *this, MethodInfo *method)
			// {
			//   IEqualityComparer_1_System_String_ *searchComparer; // rsi
			//   SectionCollection *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   SectionCollection *v7; // rbx
			// 
			//   if ( !byte_18D9192F2 )
			//   {
			//     sub_18003C530(&TypeInfo::IniParser::Model::SectionCollection);
			//     byte_18D9192F2 = 1;
			//   }
			//   searchComparer = this.fields._searchComparer;
			//   v4 = (SectionCollection *)sub_180004920(TypeInfo::IniParser::Model::SectionCollection);
			//   v7 = v4;
			//   if ( !v4 )
			//     sub_180B536AC(v6, v5);
			//   IniParser::Model::SectionCollection::SectionCollection(v4, this, searchComparer, 0LL);
			//   return v7;
			// }
			// 
			return null;
		}

		private readonly Dictionary<string, Section> _sections;

		private readonly IEqualityComparer<string> _searchComparer;
	}
}
