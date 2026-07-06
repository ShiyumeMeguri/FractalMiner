using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace IniParser.Model
{
	public class Section : IDeepCloneable<Section>
	{
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000025D0 File Offset: 0x000007D0
		public string Name
		{
			get
			{
				// // Func`1[Single] get_getValueDelegate()
				// Func_1_Single_ *Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_getValueDelegate(
				//         ValueWatcher_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_Name(String)
				// void IniParser::Model::Section::set_Name(Section *this, String *value, MethodInfo *method)
				// {
				//   Transform **v3; // r9
				//   MeshRenderer **v4; // [rsp+28h] [rbp+28h]
				//   Vector3 *v5; // [rsp+30h] [rbp+30h]
				//   Quaternion *v6; // [rsp+38h] [rbp+38h]
				//   Vector3 *v7; // [rsp+40h] [rbp+40h]
				//   Object *v8; // [rsp+48h] [rbp+48h]
				//   Object *v9; // [rsp+50h] [rbp+50h]
				//   Object *v10; // [rsp+58h] [rbp+58h]
				//   Object *v11; // [rsp+60h] [rbp+60h]
				//   MethodInfo *v12; // [rsp+68h] [rbp+68h]
				// 
				//   if ( value )
				//   {
				//     if ( value.fields._stringLength )
				//     {
				//       this.fields._name = value;
				//       sub_1800054D0(
				//         (ILFixDynamicMethodWrapper_2 *)&this.fields._name,
				//         (UberPostPassUtils_ColorGradingData **)value,
				//         (VolumetricPipelineRT **)method,
				//         v3,
				//         v4,
				//         v5,
				//         v6,
				//         v7,
				//         v8,
				//         v9,
				//         v10,
				//         v11,
				//         v12);
				//     }
				//   }
				// }
				// 
			}
		}

		// (get) Token: 0x06000096 RID: 150 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000025D0 File Offset: 0x000007D0
		public List<string> Comments
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// (get) Token: 0x06000098 RID: 152 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000025D0 File Offset: 0x000007D0
		public PropertyCollection Properties
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
			[CompilerGenerated]
			set
			{
				// // SortedList`2[TKey,TValue]+ValueList[System.Object,System.Object](SortedList`2[System.Object,System.Object])
				// void System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
				//         SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *this,
				//         SortedList_2_System_Object_System_Object_ *dictionary,
				//         MethodInfo *method)
				// {
				//   Transform **v3; // r9
				//   MeshRenderer **v4; // [rsp+28h] [rbp+28h]
				//   Vector3 *v5; // [rsp+30h] [rbp+30h]
				//   Quaternion *v6; // [rsp+38h] [rbp+38h]
				//   Vector3 *v7; // [rsp+40h] [rbp+40h]
				//   Object *v8; // [rsp+48h] [rbp+48h]
				//   Object *v9; // [rsp+50h] [rbp+50h]
				//   Object *v10; // [rsp+58h] [rbp+58h]
				//   Object *v11; // [rsp+60h] [rbp+60h]
				//   MethodInfo *v12; // [rsp+68h] [rbp+68h]
				// 
				//   this.fields._dict = dictionary;
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper_2 *)&this.fields,
				//     (UberPostPassUtils_ColorGradingData **)dictionary,
				//     (VolumetricPipelineRT **)method,
				//     v3,
				//     v4,
				//     v5,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12);
				// }
				// 
			}
		}

		public Section(string sectionName)
		{
			// // Section(String)
			// void IniParser::Model::Section::Section(Section *this, String *sectionName, MethodInfo *method)
			// {
			//   IEqualityComparer_1_System_String_ *v5; // rax
			// 
			//   if ( !byte_18D9192E7 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::EqualityComparer<System::String>::get_Default);
			//     byte_18D9192E7 = 1;
			//   }
			//   v5 = (IEqualityComparer_1_System_String_ *)sub_182720420(MethodInfo::System::Collections::Generic::EqualityComparer<System::String>::get_Default);
			//   IniParser::Model::Section::Section(this, sectionName, v5, 0LL);
			// }
			// 
		}

		public Section(string sectionName, IEqualityComparer<string> searchComparer)
		{
		}

		public Section(Section ori, IEqualityComparer<string> searchComparer = null)
		{
		}

		public void Clear()
		{
			// // Void Clear()
			// void IniParser::Model::Section::Clear(Section *this, MethodInfo *method)
			// {
			//   IniParser::Model::Section::ClearProperties(this, 0LL);
			//   IniParser::Model::Section::ClearComments(this, 0LL);
			// }
			// 
		}

		public void ClearComments()
		{
			// // Void ClearComments()
			// void IniParser::Model::Section::ClearComments(Section *this, MethodInfo *method)
			// {
			//   List_1_System_String_ *Comments; // rax
			//   __int64 v4; // rdx
			//   PropertyCollection *Properties_k__BackingField; // rcx
			// 
			//   if ( !byte_18D9192EA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::Clear);
			//     byte_18D9192EA = 1;
			//   }
			//   Comments = IniParser::Model::Section::get_Comments(this, 0LL);
			//   if ( !Comments
			//     || (sub_1823B99D0(Comments, MethodInfo::System::Collections::Generic::List<System::String>::Clear),
			//         (Properties_k__BackingField = this.fields._Properties_k__BackingField) == 0LL) )
			//   {
			//     sub_180B536AC(Properties_k__BackingField, v4);
			//   }
			//   IniParser::Model::PropertyCollection::ClearComments(Properties_k__BackingField, 0LL);
			// }
			// 
		}

		public void ClearProperties()
		{
			// // Void ClearProperties()
			// void IniParser::Model::Section::ClearProperties(Section *this, MethodInfo *method)
			// {
			//   PropertyCollection *Properties_k__BackingField; // rcx
			// 
			//   Properties_k__BackingField = this.fields._Properties_k__BackingField;
			//   if ( !Properties_k__BackingField )
			//     sub_180B536AC(0LL, method);
			//   IniParser::Model::PropertyCollection::Clear(Properties_k__BackingField, 0LL);
			// }
			// 
		}

		public void Merge(Section toMergeSection)
		{
			// // Void Merge(Section)
			// // Hidden C++ exception states: #wind=1
			// void IniParser::Model::Section::Merge(Section *this, Section *toMergeSection, MethodInfo *method)
			// {
			//   List_1_System_Object_ *Comments; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Object *current; // rbx
			//   List_1_System_Object_ *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Il2CppExceptionWrapper *v12; // [rsp+20h] [rbp-48h] BYREF
			//   List_1_T_Enumerator_System_Object_ v13; // [rsp+28h] [rbp-40h] BYREF
			//   List_1_T_Enumerator_System_Object_ v14; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D9192EB )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::String>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::String>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::String>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<System::String>::GetEnumerator);
			//     byte_18D9192EB = 1;
			//   }
			//   if ( !toMergeSection )
			//     sub_180B536AC(this, toMergeSection);
			//   if ( !this.fields._Properties_k__BackingField )
			//     sub_180B536AC(this, toMergeSection);
			//   IniParser::Model::PropertyCollection::Merge(
			//     this.fields._Properties_k__BackingField,
			//     toMergeSection.fields._Properties_k__BackingField,
			//     0LL);
			//   Comments = (List_1_System_Object_ *)IniParser::Model::Section::get_Comments(toMergeSection, 0LL);
			//   if ( !Comments )
			//     sub_180B536AC(v7, v6);
			//   System::Collections::Generic::List<System::Object>::GetEnumerator(
			//     &v13,
			//     Comments,
			//     MethodInfo::System::Collections::Generic::List<System::String>::GetEnumerator);
			//   v14 = v13;
			//   v13._list = 0LL;
			//   *(_QWORD *)&v13._index = &v14;
			//   try
			//   {
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v14,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::String>::MoveNext) )
			//     {
			//       current = v14._current;
			//       v9 = (List_1_System_Object_ *)IniParser::Model::Section::get_Comments(this, 0LL);
			//       if ( !v9 )
			//         sub_1802DC2C8(v11, v10);
			//       sub_1822AD140(v9, current);
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v12 )
			//   {
			//     v13._list = (List_1_System_Object_ *)v12.ex;
			//     if ( v13._list )
			//       sub_18000F780(v13._list);
			//   }
			// }
			// 
		}

		public Section DeepClone()
		{
			// // Section DeepClone()
			// Section *IniParser::Model::Section::DeepClone(Section *this, MethodInfo *method)
			// {
			//   Section *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Section *v6; // rbx
			// 
			//   if ( !byte_18D9192EC )
			//   {
			//     sub_18003C530(&TypeInfo::IniParser::Model::Section);
			//     byte_18D9192EC = 1;
			//   }
			//   v3 = (Section *)sub_180004920(TypeInfo::IniParser::Model::Section);
			//   v6 = v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   IniParser::Model::Section::Section(v3, this, 0LL, 0LL);
			//   return v6;
			// }
			// 
			return null;
		}

		private List<string> _comments;

		private string _name;

		private readonly IEqualityComparer<string> _searchComparer;
	}
}
