using System;
using System.Runtime.CompilerServices;

namespace IniParser.Configuration
{
	public class IniFormattingConfiguration : IDeepCloneable<IniFormattingConfiguration>
	{
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000025D2 File Offset: 0x000007D2
		public string NewLineString
		{
			get
			{
				// // String get_NewLineString()
				// String *IniParser::Configuration::IniFormattingConfiguration::get_NewLineString(
				//         IniFormattingConfiguration *this,
				//         MethodInfo *method)
				// {
				//   String *result; // rax
				// 
				//   if ( !byte_18D9192F8 )
				//   {
				//     sub_18003C530(&off_18C907FF0);
				//     sub_18003C530(&off_18C95A0C8);
				//     byte_18D9192F8 = 1;
				//   }
				//   result = (String *)"\n";
				//   if ( !this.fields._NewLineType_k__BackingField )
				//     return (String *)"\r\n";
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002668 File Offset: 0x00000868
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000025D0 File Offset: 0x000007D0
		public IniFormattingConfiguration.ENewLine NewLineType
		{
			[CompilerGenerated]
			get
			{
				// // MjfRFftkTcBeBOoxrCKsCyjeiVkX get_Current()
				// MjfRFftkTcBeBOoxrCKsCyjeiVkX Rewired::Utils::Classes::Data::RingBuffer_1_T_::VFEweixJrFjiYwjUzBFjtcEMiCZW<MjfRFftkTcBeBOoxrCKsCyjeiVkX>::get_Current(
				//         RingBuffer_1_T_VFEweixJrFjiYwjUzBFjtcEMiCZW_MjfRFftkTcBeBOoxrCKsCyjeiVkX_ *this,
				//         MethodInfo *method)
				// {
				//   return this.current;
				// }
				// 
				return IniFormattingConfiguration.ENewLine.Windows;
			}
			[CompilerGenerated]
			set
			{
				// // UpdateLoopDataSet`1[T]+yGyjUqbndvpPzKlyNzUYInPtwsHF[System.Object](UpdateLoopType)
				// void Rewired::UpdateLoopDataSet_1_T_::yGyjUqbndvpPzKlyNzUYInPtwsHF<System::Object>::yGyjUqbndvpPzKlyNzUYInPtwsHF(
				//         UpdateLoopDataSet_1_T_yGyjUqbndvpPzKlyNzUYInPtwsHF_System_Object_ *this,
				//         UpdateLoopType__Enum param_0004ff5a,
				//         MethodInfo *method)
				// {
				//   this.fields.URsVCNeXtjuGuUuIdAEYavYwEgUe = param_0004ff5a;
				// }
				// 
			}
		}

		// (set) Token: 0x060000C4 RID: 196 RVA: 0x000025D0 File Offset: 0x000007D0
		public uint NumSpacesBetweenKeyAndAssigment
		{
			set
			{
				// // Void set_NumSpacesBetweenKeyAndAssigment(UInt32)
				// void IniParser::Configuration::IniFormattingConfiguration::set_NumSpacesBetweenKeyAndAssigment(
				//         IniFormattingConfiguration *this,
				//         uint32_t value,
				//         MethodInfo *method)
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
				//   this.fields._numSpacesBetweenKeyAndAssigment = value;
				//   this.fields._SpacesBetweenKeyAndAssigment_k__BackingField = System::String::Ctor(0x20u, value, 0LL);
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper_2 *)&this.fields._SpacesBetweenKeyAndAssigment_k__BackingField,
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

		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x000025D0 File Offset: 0x000007D0
		public string SpacesBetweenKeyAndAssigment
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
			private set
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

		// (set) Token: 0x060000C7 RID: 199 RVA: 0x000025D0 File Offset: 0x000007D0
		public uint NumSpacesBetweenAssigmentAndValue
		{
			set
			{
				// // Void set_NumSpacesBetweenAssigmentAndValue(UInt32)
				// void IniParser::Configuration::IniFormattingConfiguration::set_NumSpacesBetweenAssigmentAndValue(
				//         IniFormattingConfiguration *this,
				//         uint32_t value,
				//         MethodInfo *method)
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
				//   this.fields._numSpacesBetweenAssigmentAndValue = value;
				//   this.fields._SpacesBetweenAssigmentAndValue_k__BackingField = System::String::Ctor(0x20u, value, 0LL);
				//   sub_1800054D0(
				//     (ILFixDynamicMethodWrapper_2 *)&this.fields._SpacesBetweenAssigmentAndValue_k__BackingField,
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

		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000025D0 File Offset: 0x000007D0
		public string SpacesBetweenAssigmentAndValue
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
			private set
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

		// (get) Token: 0x060000CA RID: 202 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool NewLineBeforeSection
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_isRunning()
				// bool UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::get_isRunning(
				//         ValueAnimation_1_StyleValues_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._isRunning_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_isRunning(Boolean)
				// void UnityEngine::UIElements::Experimental::ValueAnimation<UnityEngine::UIElements::Experimental::StyleValues>::set_isRunning(
				//         ValueAnimation_1_StyleValues_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._isRunning_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060000CC RID: 204 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool NewLineAfterSection
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_defaultValue()
				// bool HG::Rendering::Runtime::SettingParameter<bool>::get_defaultValue(
				//         SettingParameter_1_System_Boolean_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._defaultValue_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_defaultValue(Boolean)
				// void HG::Rendering::Runtime::SettingParameter<bool>::set_defaultValue(
				//         SettingParameter_1_System_Boolean_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._defaultValue_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060000CE RID: 206 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool NewLineAfterProperty
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_isKeyword()
				// bool Beyond::Rendering::EntityVFXControllerBase::get_isKeyword(EntityVFXControllerBase *this, MethodInfo *method)
				// {
				//   return this.fields.m_isKeyword;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_isMaterialAvailable(Boolean)
				// void CriWare::CriManaMovieMaterialBase::set_isMaterialAvailable(
				//         CriManaMovieMaterialBase *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._isMaterialAvailable_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool NewLineBeforeProperty
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_NewLineBeforeProperty()
				// bool IniParser::Configuration::IniFormattingConfiguration::get_NewLineBeforeProperty(
				//         IniFormattingConfiguration *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._NewLineBeforeProperty_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_rendererPriority(Boolean)
				// void UnityEngine::Rendering::SupportedRenderingFeatures::set_rendererPriority(
				//         SupportedRenderingFeatures *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._rendererPriority_k__BackingField = value;
				// }
				// 
			}
		}

		public IniFormattingConfiguration()
		{
			// // IniFormattingConfiguration()
			// void IniParser::Configuration::IniFormattingConfiguration::IniFormattingConfiguration(
			//         IniFormattingConfiguration *this,
			//         MethodInfo *method)
			// {
			//   String *NewLine; // rax
			//   bool v4; // al
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D9192F7 )
			//   {
			//     sub_18003C530(&off_18C95A0C8);
			//     byte_18D9192F7 = 1;
			//   }
			//   NewLine = System::Environment::get_NewLine(0LL);
			//   v4 = System::String::Equals(NewLine, (String *)"\r\n", 0LL);
			//   if ( !this )
			//     sub_180B536AC(v6, v5);
			//   this.fields._NewLineType_k__BackingField = !v4;
			//   IniParser::Configuration::IniFormattingConfiguration::set_NumSpacesBetweenAssigmentAndValue(this, 1u, 0LL);
			//   IniParser::Configuration::IniFormattingConfiguration::set_NumSpacesBetweenKeyAndAssigment(this, 1u, 0LL);
			// }
			// 
		}

		public IniFormattingConfiguration DeepClone()
		{
			// // IniFormattingConfiguration DeepClone()
			// IniFormattingConfiguration *IniParser::Configuration::IniFormattingConfiguration::DeepClone(
			//         IniFormattingConfiguration *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rax
			// 
			//   if ( !byte_18D9192F9 )
			//   {
			//     sub_18003C530(&TypeInfo::IniParser::Configuration::IniFormattingConfiguration);
			//     byte_18D9192F9 = 1;
			//   }
			//   v3 = System::CharEnumerator::Clone((System::CharEnumerator *)this);
			//   return (IniFormattingConfiguration *)sub_18003F5A0(v3, TypeInfo::IniParser::Configuration::IniFormattingConfiguration);
			// }
			// 
			return null;
		}

		private uint _numSpacesBetweenKeyAndAssigment;

		private uint _numSpacesBetweenAssigmentAndValue;

		public enum ENewLine
		{
			Windows,
			Unix_Mac
		}
	}
}
