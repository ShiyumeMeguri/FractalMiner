using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace IniParser.Model
{
	public class Property : IDeepCloneable<Property>
	{
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000025D0 File Offset: 0x000007D0
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

		// (get) Token: 0x06000072 RID: 114 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000025D0 File Offset: 0x000007D0
		public string Value
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

		// (get) Token: 0x06000074 RID: 116 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000025D0 File Offset: 0x000007D0
		public string Key
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
			set
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

		public Property(string keyName, [MetadataOffset(Offset = "0x01F909CA")] string value = "")
		{
		}

		public Property(Property ori)
		{
		}

		public Property DeepClone()
		{
			// // Property DeepClone()
			// Property *IniParser::Model::Property::DeepClone(Property *this, MethodInfo *method)
			// {
			//   Property *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Property *v6; // rbx
			// 
			//   if ( !byte_18D9192DB )
			//   {
			//     sub_18003C530(&TypeInfo::IniParser::Model::Property);
			//     byte_18D9192DB = 1;
			//   }
			//   v3 = (Property *)sub_180004920(TypeInfo::IniParser::Model::Property);
			//   v6 = v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   IniParser::Model::Property::Property(v3, this, 0LL);
			//   return v6;
			// }
			// 
			return null;
		}

		private List<string> _comments;
	}
}
