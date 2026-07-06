using System;

namespace IniParser.Configuration
{
	public class IniScheme : IDeepCloneable<IniScheme>
	{
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000025D0 File Offset: 0x000007D0
		public string CommentString
		{
			get
			{
				// // String get_CommentString()
				// String *IniParser::Configuration::IniScheme::get_CommentString(IniScheme *this, MethodInfo *method)
				// {
				//   if ( !byte_18D8ED93D )
				//   {
				//     sub_18003C530(&off_18C95A178);
				//     byte_18D8ED93D = 1;
				//   }
				//   if ( System::String::IsNullOrWhiteSpace(this.fields._commentString, 0LL) )
				//     return (String *)";";
				//   else
				//     return this.fields._commentString;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_CommentString(String)
				// void IniParser::Configuration::IniScheme::set_CommentString(IniScheme *this, String *value, MethodInfo *method)
				// {
				//   Transform **v3; // r9
				//   String *v5; // rax
				//   MeshRenderer **v6; // [rsp+50h] [rbp+28h]
				//   Vector3 *v7; // [rsp+58h] [rbp+30h]
				//   Quaternion *v8; // [rsp+60h] [rbp+38h]
				//   Vector3 *v9; // [rsp+68h] [rbp+40h]
				//   Object *v10; // [rsp+70h] [rbp+48h]
				//   Object *v11; // [rsp+78h] [rbp+50h]
				//   Object *v12; // [rsp+80h] [rbp+58h]
				//   Object *v13; // [rsp+88h] [rbp+60h]
				//   MethodInfo *v14; // [rsp+90h] [rbp+68h]
				// 
				//   if ( value )
				//     v5 = System::String::TrimWhiteSpaceHelper(value, String_TrimType__Enum_Both, 0LL);
				//   else
				//     v5 = 0LL;
				//   if ( !this )
				//     sub_180B536AC(this, value);
				//   this.fields._commentString = v5;
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper_2 *)&this.fields,
				//     (UberPostPassUtils_ColorGradingData **)value,
				//     (VolumetricPipelineRT **)method,
				//     v3,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12,
				//     v13,
				//     v14);
				// }
				// 
			}
		}

		// (get) Token: 0x060000EF RID: 239 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000025D0 File Offset: 0x000007D0
		public string SectionStartString
		{
			get
			{
				// // String get_SectionStartString()
				// String *IniParser::Configuration::IniScheme::get_SectionStartString(IniScheme *this, MethodInfo *method)
				// {
				//   if ( !byte_18D8ED93E )
				//   {
				//     sub_18003C530(&off_18C9134B0);
				//     byte_18D8ED93E = 1;
				//   }
				//   if ( System::String::IsNullOrWhiteSpace(this.fields._sectionStartString, 0LL) )
				//     return (String *)"[";
				//   else
				//     return this.fields._sectionStartString;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_SectionStartString(String)
				// void IniParser::Configuration::IniScheme::set_SectionStartString(IniScheme *this, String *value, MethodInfo *method)
				// {
				//   Transform **v3; // r9
				//   String *v5; // rax
				//   MeshRenderer **v6; // [rsp+50h] [rbp+28h]
				//   Vector3 *v7; // [rsp+58h] [rbp+30h]
				//   Quaternion *v8; // [rsp+60h] [rbp+38h]
				//   Vector3 *v9; // [rsp+68h] [rbp+40h]
				//   Object *v10; // [rsp+70h] [rbp+48h]
				//   Object *v11; // [rsp+78h] [rbp+50h]
				//   Object *v12; // [rsp+80h] [rbp+58h]
				//   Object *v13; // [rsp+88h] [rbp+60h]
				//   MethodInfo *v14; // [rsp+90h] [rbp+68h]
				// 
				//   if ( value )
				//     v5 = System::String::TrimWhiteSpaceHelper(value, String_TrimType__Enum_Both, 0LL);
				//   else
				//     v5 = 0LL;
				//   if ( !this )
				//     sub_180B536AC(this, value);
				//   this.fields._sectionStartString = v5;
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper_2 *)&this.fields._sectionStartString,
				//     (UberPostPassUtils_ColorGradingData **)value,
				//     (VolumetricPipelineRT **)method,
				//     v3,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12,
				//     v13,
				//     v14);
				// }
				// 
			}
		}

		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000025D0 File Offset: 0x000007D0
		public string SectionEndString
		{
			get
			{
				// // String get_SectionEndString()
				// String *IniParser::Configuration::IniScheme::get_SectionEndString(IniScheme *this, MethodInfo *method)
				// {
				//   if ( !byte_18D8ED93F )
				//   {
				//     sub_18003C530(&off_18C916BA0);
				//     byte_18D8ED93F = 1;
				//   }
				//   if ( System::String::IsNullOrWhiteSpace(this.fields._sectionEndString, 0LL) )
				//     return (String *)"]";
				//   else
				//     return this.fields._sectionEndString;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_SectionEndString(String)
				// void IniParser::Configuration::IniScheme::set_SectionEndString(IniScheme *this, String *value, MethodInfo *method)
				// {
				//   Transform **v3; // r9
				//   String *v5; // rax
				//   MeshRenderer **v6; // [rsp+50h] [rbp+28h]
				//   Vector3 *v7; // [rsp+58h] [rbp+30h]
				//   Quaternion *v8; // [rsp+60h] [rbp+38h]
				//   Vector3 *v9; // [rsp+68h] [rbp+40h]
				//   Object *v10; // [rsp+70h] [rbp+48h]
				//   Object *v11; // [rsp+78h] [rbp+50h]
				//   Object *v12; // [rsp+80h] [rbp+58h]
				//   Object *v13; // [rsp+88h] [rbp+60h]
				//   MethodInfo *v14; // [rsp+90h] [rbp+68h]
				// 
				//   if ( value )
				//     v5 = System::String::TrimWhiteSpaceHelper(value, String_TrimType__Enum_Both, 0LL);
				//   else
				//     v5 = 0LL;
				//   if ( !this )
				//     sub_180B536AC(this, value);
				//   this.fields._sectionEndString = v5;
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper_2 *)&this.fields._sectionEndString,
				//     (UberPostPassUtils_ColorGradingData **)value,
				//     (VolumetricPipelineRT **)method,
				//     v3,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12,
				//     v13,
				//     v14);
				// }
				// 
			}
		}

		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000025D0 File Offset: 0x000007D0
		public string PropertyAssigmentString
		{
			get
			{
				// // String get_PropertyAssigmentString()
				// String *IniParser::Configuration::IniScheme::get_PropertyAssigmentString(IniScheme *this, MethodInfo *method)
				// {
				//   if ( !byte_18D8ED940 )
				//   {
				//     sub_18003C530(&off_18C955058);
				//     byte_18D8ED940 = 1;
				//   }
				//   if ( System::String::IsNullOrWhiteSpace(this.fields._propertyAssigmentString, 0LL) )
				//     return (String *)"=";
				//   else
				//     return this.fields._propertyAssigmentString;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_PropertyAssigmentString(String)
				// void IniParser::Configuration::IniScheme::set_PropertyAssigmentString(
				//         IniScheme *this,
				//         String *value,
				//         MethodInfo *method)
				// {
				//   Transform **v3; // r9
				//   String *v5; // rax
				//   MeshRenderer **v6; // [rsp+50h] [rbp+28h]
				//   Vector3 *v7; // [rsp+58h] [rbp+30h]
				//   Quaternion *v8; // [rsp+60h] [rbp+38h]
				//   Vector3 *v9; // [rsp+68h] [rbp+40h]
				//   Object *v10; // [rsp+70h] [rbp+48h]
				//   Object *v11; // [rsp+78h] [rbp+50h]
				//   Object *v12; // [rsp+80h] [rbp+58h]
				//   Object *v13; // [rsp+88h] [rbp+60h]
				//   MethodInfo *v14; // [rsp+90h] [rbp+68h]
				// 
				//   if ( value )
				//     v5 = System::String::TrimWhiteSpaceHelper(value, String_TrimType__Enum_Both, 0LL);
				//   else
				//     v5 = 0LL;
				//   if ( !this )
				//     sub_180B536AC(this, value);
				//   this.fields._propertyAssigmentString = v5;
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper_2 *)&this.fields._propertyAssigmentString,
				//     (UberPostPassUtils_ColorGradingData **)value,
				//     (VolumetricPipelineRT **)method,
				//     v3,
				//     v6,
				//     v7,
				//     v8,
				//     v9,
				//     v10,
				//     v11,
				//     v12,
				//     v13,
				//     v14);
				// }
				// 
			}
		}

		public IniScheme()
		{
		}

		private IniScheme(IniScheme ori)
		{
		}

		public IniScheme DeepClone()
		{
			// // IniScheme DeepClone()
			// IniScheme *IniParser::Configuration::IniScheme::DeepClone(IniScheme *this, MethodInfo *method)
			// {
			//   IniScheme *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   IniScheme *v6; // rbx
			// 
			//   if ( !byte_18D8ED941 )
			//   {
			//     sub_18003C530(&TypeInfo::IniParser::Configuration::IniScheme);
			//     byte_18D8ED941 = 1;
			//   }
			//   v3 = (IniScheme *)sub_180004920(TypeInfo::IniParser::Configuration::IniScheme);
			//   v6 = v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   IniParser::Configuration::IniScheme::IniScheme(v3, this, 0LL);
			//   return v6;
			// }
			// 
			return null;
		}

		private string _commentString;

		private string _sectionStartString;

		private string _sectionEndString;

		private string _propertyAssigmentString;
	}
}
