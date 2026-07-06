using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using IniParser.Configuration;
using IniParser.Model;

namespace IniParser
{
	[DefaultMember("Item")]
	public class IniData : IDeepCloneable<IniData>
	{
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool CreateSectionsIfTheyDontExist
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_changed()
				// bool Rewired::Utils::Classes::Utility::ValueWatcher<float>::get_changed(
				//         ValueWatcher_1_System_Single_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.NiVDAueHECEJqGCNLxcjNXRtPmUC;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_override(Boolean)
				// void HG::Rendering::Runtime::ScalableSettingValue<bool>::set_override(
				//         ScalableSettingValue_1_System_Boolean_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_Override = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000023 RID: 35 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000025D0 File Offset: 0x000007D0
		public IniParserConfiguration Configuration
		{
			get
			{
				return null;
			}
			set
			{
				// // Void set_Configuration(IniParserConfiguration)
				// void IniParser::IniData::set_Configuration(IniData *this, IniParserConfiguration *value, MethodInfo *method)
				// {
				//   UberPostPassUtils_ColorGradingData **v4; // rdx
				//   VolumetricPipelineRT **v5; // r8
				//   Transform **v6; // r9
				//   MeshRenderer **v7; // [rsp+50h] [rbp+28h]
				//   Vector3 *v8; // [rsp+58h] [rbp+30h]
				//   Quaternion *v9; // [rsp+60h] [rbp+38h]
				//   Vector3 *v10; // [rsp+68h] [rbp+40h]
				//   Object *v11; // [rsp+70h] [rbp+48h]
				//   Object *v12; // [rsp+78h] [rbp+50h]
				//   Object *v13; // [rsp+80h] [rbp+58h]
				//   Object *v14; // [rsp+88h] [rbp+60h]
				//   MethodInfo *v15; // [rsp+90h] [rbp+68h]
				// 
				//   if ( !value )
				//     sub_180B536AC(this, 0LL);
				//   this.fields._configuration = IniParser::Configuration::IniParserConfiguration::DeepClone(value, 0LL);
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper_2 *)&this.fields._configuration,
				//     v4,
				//     v5,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12,
				//     v13,
				//     v14,
				//     v15);
				// }
				// 
			}
		}

		// (get) Token: 0x06000025 RID: 37 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000025D0 File Offset: 0x000007D0
		public IniScheme Scheme
		{
			get
			{
				return null;
			}
			set
			{
				// // Void set_Scheme(IniScheme)
				// void IniParser::IniData::set_Scheme(IniData *this, IniScheme *value, MethodInfo *method)
				// {
				//   UberPostPassUtils_ColorGradingData **v4; // rdx
				//   VolumetricPipelineRT **v5; // r8
				//   Transform **v6; // r9
				//   MeshRenderer **v7; // [rsp+50h] [rbp+28h]
				//   Vector3 *v8; // [rsp+58h] [rbp+30h]
				//   Quaternion *v9; // [rsp+60h] [rbp+38h]
				//   Vector3 *v10; // [rsp+68h] [rbp+40h]
				//   Object *v11; // [rsp+70h] [rbp+48h]
				//   Object *v12; // [rsp+78h] [rbp+50h]
				//   Object *v13; // [rsp+80h] [rbp+58h]
				//   Object *v14; // [rsp+88h] [rbp+60h]
				//   MethodInfo *v15; // [rsp+90h] [rbp+68h]
				// 
				//   if ( !value )
				//     sub_180B536AC(this, 0LL);
				//   this.fields._scheme = IniParser::Configuration::IniScheme::DeepClone(value, 0LL);
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper_2 *)&this.fields._scheme,
				//     v4,
				//     v5,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12,
				//     v13,
				//     v14,
				//     v15);
				// }
				// 
			}
		}

		// (get) Token: 0x06000027 RID: 39 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000025D0 File Offset: 0x000007D0
		public PropertyCollection Global
		{
			[CompilerGenerated]
			get
			{
				// // Object System.Collections.IEnumerator.get_Current()
				// Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
				//         HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return (Object *)this.fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			protected set
			{
				// // Void set_getValueDelegate(Func`1[Boolean])
				// void Rewired::Utils::Classes::Utility::ValueWatcher<bool>::set_getValueDelegate(
				//         ValueWatcher_1_System_Boolean_ *this,
				//         Func_1_Boolean_ *value,
				//         MethodInfo *method)
				// {
				//   Object__Array *v3; // r9
				//   MethodInfo *v4; // [rsp+28h] [rbp+28h]
				//   MethodInfo *v5; // [rsp+30h] [rbp+30h]
				// 
				//   this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
				//   sub_1800054D0(
				//     (BSP *)&this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
				//     (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)value,
				//     (Bounds *)method,
				//     v3,
				//     v4,
				//     v5);
				// }
				// 
			}
		}

		// (get) Token: 0x06000029 RID: 41 RVA: 0x000025D2 File Offset: 0x000007D2
		public PropertyCollection Item
		{
			get
			{
				// // PropertyCollection get_Item(String)
				// PropertyCollection *IniParser::IniData::get_Item(IniData *this, String *sectionName, MethodInfo *method)
				// {
				//   SectionCollection *Sections_k__BackingField; // rcx
				// 
				//   Sections_k__BackingField = this.fields._Sections_k__BackingField;
				//   if ( !Sections_k__BackingField )
				//     goto LABEL_9;
				//   if ( IniParser::Model::SectionCollection::Contains(Sections_k__BackingField, sectionName, 0LL) )
				//     goto LABEL_7;
				//   if ( !this.fields._CreateSectionsIfTheyDontExist_k__BackingField )
				//     return 0LL;
				//   Sections_k__BackingField = this.fields._Sections_k__BackingField;
				//   if ( !Sections_k__BackingField )
				// LABEL_9:
				//     sub_180B536AC(Sections_k__BackingField, sectionName);
				//   IniParser::Model::SectionCollection::Add(Sections_k__BackingField, sectionName, 0LL);
				// LABEL_7:
				//   Sections_k__BackingField = this.fields._Sections_k__BackingField;
				//   if ( !Sections_k__BackingField )
				//     goto LABEL_9;
				//   return IniParser::Model::SectionCollection::get_Item(Sections_k__BackingField, sectionName, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600002A RID: 42 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000025D0 File Offset: 0x000007D0
		public SectionCollection Sections
		{
			[CompilerGenerated]
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
			[CompilerGenerated]
			set
			{
				// // Void set_getValueDelegate(Func`1[Single])
				// void Rewired::Utils::Classes::Utility::ValueWatcher<float>::set_getValueDelegate(
				//         ValueWatcher_1_System_Single_ *this,
				//         Func_1_Single_ *value,
				//         MethodInfo *method)
				// {
				//   Object__Array *v3; // r9
				//   MethodInfo *v4; // [rsp+28h] [rbp+28h]
				//   MethodInfo *v5; // [rsp+30h] [rbp+30h]
				// 
				//   this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA = value;
				//   sub_1800054D0(
				//     (BSP *)&this.fields.MHRAQZbVaKflzQthDWnBRvhnUSmRA,
				//     (IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *)value,
				//     (Bounds *)method,
				//     v3,
				//     v4,
				//     v5);
				// }
				// 
			}
		}

		public IniData()
		{
		}

		public IniData(IniScheme scheme)
		{
			// // IniData(IniScheme)
			// void IniParser::IniData::IniData(IniData *this, IniScheme *scheme, MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   UberPostPassUtils_ColorGradingData **v7; // rdx
			//   VolumetricPipelineRT **v8; // r8
			//   Transform **v9; // r9
			//   MeshRenderer **v10; // [rsp+50h] [rbp+28h]
			//   Vector3 *v11; // [rsp+58h] [rbp+30h]
			//   Quaternion *v12; // [rsp+60h] [rbp+38h]
			//   Vector3 *v13; // [rsp+68h] [rbp+40h]
			//   Object *v14; // [rsp+70h] [rbp+48h]
			//   Object *v15; // [rsp+78h] [rbp+50h]
			//   Object *v16; // [rsp+80h] [rbp+58h]
			//   Object *v17; // [rsp+88h] [rbp+60h]
			//   MethodInfo *v18; // [rsp+90h] [rbp+68h]
			// 
			//   IniParser::IniData::IniData(this, 0LL);
			//   if ( !scheme )
			//     sub_180B536AC(v6, v5);
			//   this.fields._scheme = IniParser::Configuration::IniScheme::DeepClone(scheme, 0LL);
			//   sub_1800054D0(
			//     (ILFixDynamicMethodWrapper_2 *)&this.fields._scheme,
			//     v7,
			//     v8,
			//     v9,
			//     v10,
			//     v11,
			//     v12,
			//     v13,
			//     v14,
			//     v15,
			//     v16,
			//     v17,
			//     v18);
			// }
			// 
		}

		public IniData(IniData ori)
		{
		}

		public void Clear()
		{
			// // Void Clear()
			// void IniParser::IniData::Clear(IniData *this, MethodInfo *method)
			// {
			//   PropertyCollection *Global_k__BackingField; // rcx
			// 
			//   Global_k__BackingField = this.fields._Global_k__BackingField;
			//   if ( !Global_k__BackingField
			//     || (IniParser::Model::PropertyCollection::Clear(Global_k__BackingField, 0LL),
			//         (Global_k__BackingField = (PropertyCollection *)this.fields._Sections_k__BackingField) == 0LL) )
			//   {
			//     sub_180B536AC(Global_k__BackingField, method);
			//   }
			//   IniParser::Model::SectionCollection::Clear((SectionCollection *)Global_k__BackingField, 0LL);
			// }
			// 
		}

		public void ClearAllComments()
		{
			// // Void ClearAllComments()
			// // Hidden C++ exception states: #wind=1
			// void IniParser::IniData::ClearAllComments(IniData *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Section *v9; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   Section *v12; // rbx
			//   __int64 v13; // rdx
			//   PropertyCollection *Properties_k__BackingField; // rcx
			//   _QWORD v15[4]; // [rsp+28h] [rbp-20h] BYREF
			//   IEnumerator_1_IniParser_Model_Section_ *Enumerator; // [rsp+50h] [rbp+8h] BYREF
			// 
			//   if ( !byte_18D9192CB )
			//   {
			//     sub_18003C530(&TypeInfo::System::IDisposable);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Section>);
			//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
			//     byte_18D9192CB = 1;
			//   }
			//   if ( !this.fields._Global_k__BackingField )
			//     sub_180B536AC(this, method);
			//   IniParser::Model::PropertyCollection::ClearComments(this.fields._Global_k__BackingField, 0LL);
			//   if ( !this.fields._Sections_k__BackingField )
			//     sub_180B536AC(v4, v3);
			//   Enumerator = IniParser::Model::SectionCollection::GetEnumerator(this.fields._Sections_k__BackingField, 0LL);
			//   v15[0] = 0LL;
			//   v15[1] = &Enumerator;
			//   while ( 1 )
			//   {
			//     if ( !Enumerator )
			//       sub_1802DC2C8(v6, v5);
			//     if ( !(unsigned __int8)sub_1800518F0(0LL, TypeInfo::System::Collections::IEnumerator) )
			//       break;
			//     if ( !Enumerator )
			//       sub_1802DC2C8(v8, v7);
			//     v9 = (Section *)sub_18005E510();
			//     v12 = v9;
			//     if ( !v9 )
			//       sub_1802DC2C8(v11, v10);
			//     IniParser::Model::Section::ClearComments(v9, 0LL);
			//     Properties_k__BackingField = v12.fields._Properties_k__BackingField;
			//     if ( !Properties_k__BackingField )
			//       sub_1802DC2C8(0LL, v13);
			//     IniParser::Model::PropertyCollection::ClearComments(Properties_k__BackingField, 0LL);
			//   }
			//   sub_1801E4D90(v15);
			// }
			// 
		}

		public void Merge(IniData toMergeIniData)
		{
			// // Void Merge(IniData)
			// void IniParser::IniData::Merge(IniData *this, IniData *toMergeIniData, MethodInfo *method)
			// {
			//   PropertyCollection *Global_k__BackingField; // rcx
			// 
			//   if ( toMergeIniData )
			//   {
			//     Global_k__BackingField = this.fields._Global_k__BackingField;
			//     if ( !Global_k__BackingField
			//       || (IniParser::Model::PropertyCollection::Merge(
			//             Global_k__BackingField,
			//             toMergeIniData.fields._Global_k__BackingField,
			//             0LL),
			//           (Global_k__BackingField = (PropertyCollection *)this.fields._Sections_k__BackingField) == 0LL) )
			//     {
			//       sub_180B536AC(Global_k__BackingField, toMergeIniData);
			//     }
			//     IniParser::Model::SectionCollection::Merge(
			//       (SectionCollection *)Global_k__BackingField,
			//       toMergeIniData.fields._Sections_k__BackingField,
			//       0LL);
			//   }
			// }
			// 
		}

		public IniData DeepClone()
		{
			// // IniData DeepClone()
			// IniData *IniParser::IniData::DeepClone(IniData *this, MethodInfo *method)
			// {
			//   IniData *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   IniData *v6; // rbx
			// 
			//   if ( !byte_18D9192CC )
			//   {
			//     sub_18003C530(&TypeInfo::IniParser::IniData);
			//     byte_18D9192CC = 1;
			//   }
			//   v3 = (IniData *)sub_180004920(TypeInfo::IniParser::IniData);
			//   v6 = v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   IniParser::IniData::IniData(v3, this, 0LL);
			//   return v6;
			// }
			// 
			return null;
		}

		private IniParserConfiguration _configuration;

		protected IniScheme _scheme;
	}
}
