using System;
using System.Runtime.CompilerServices;

namespace IniParser.Configuration
{
	public class IniParserConfiguration : IDeepCloneable<IniParserConfiguration>
	{
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool CaseInsensitive
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

		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool AllowKeysWithoutSection
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_value()
				// bool Rewired::Utils::Classes::Utility::ValueWatcher<bool>::get_value(
				//         ValueWatcher_1_System_Boolean_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.lbeYGGLqExuAmnvpTifZPpiwyZrH;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_useOverride(Boolean)
				// void HG::Rendering::Runtime::ScalableSettingValue<bool>::set_useOverride(
				//         ScalableSettingValue_1_System_Boolean_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_UseOverride = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002680 File Offset: 0x00000880
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000025D0 File Offset: 0x000007D0
		public IniParserConfiguration.EDuplicatePropertiesBehaviour DuplicatePropertiesBehaviour
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_value()
				// int32_t Rewired::Utils::Classes::Utility::ValueWatcher<int>::get_value(
				//         ValueWatcher_1_System_Int32_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.lbeYGGLqExuAmnvpTifZPpiwyZrH;
				// }
				// 
				return IniParserConfiguration.EDuplicatePropertiesBehaviour.DisallowAndStopWithError;
			}
			[CompilerGenerated]
			set
			{
				// // Void set_rolloverSize(Int32)
				// void TMPro::TMP_TextProcessingStack<float>::set_rolloverSize(
				//         TMP_TextProcessingStack_1_System_Single_ *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   this.m_RolloverSize = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060000DA RID: 218 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000025D0 File Offset: 0x000007D0
		public string ConcatenateDuplicatePropertiesString
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

		// (get) Token: 0x060000DC RID: 220 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool ThrowExceptionsOnError
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_autoTriggerEvent()
				// bool Rewired::Utils::Classes::Utility::ValueWatcher<System::Object>::get_autoTriggerEvent(
				//         ValueWatcher_1_System_Object_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.jfwTQnAbUjPonSNJeDchTULdikzO;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_autoTriggerEvent(Boolean)
				// void Rewired::Utils::Classes::Utility::ValueWatcher<System::Object>::set_autoTriggerEvent(
				//         ValueWatcher_1_System_Object_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.jfwTQnAbUjPonSNJeDchTULdikzO = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060000DE RID: 222 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool AllowDuplicateSections
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_IsExpanded()
				// bool SRDebugger::Services::Implementation::DockConsoleServiceImpl::get_IsExpanded(
				//         DockConsoleServiceImpl *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._isExpanded;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_isManualUpdate(Boolean)
				// void UnityEngine::Timeline::TimeNotificationBehaviour::set_isManualUpdate(
				//         TimeNotificationBehaviour *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.m_IsManualUpdate = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool SkipInvalidLines
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_IsVisible()
				// bool SRDebugger::Services::Implementation::DockConsoleServiceImpl::get_IsVisible(
				//         DockConsoleServiceImpl *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._isVisible;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void <RegisterDebug>b__10_3(Boolean)
				// void UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphDebugParams::_RegisterDebug_b__10_3(
				//         RenderGraphDebugParams *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.disablePassCulling = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool TrimProperties
		{
			[CompilerGenerated]
			get
			{
				// // Boolean <RegisterDebug>b__10_4()
				// bool UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphDebugParams::_RegisterDebug_b__10_4(
				//         RenderGraphDebugParams *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.immediateMode;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void <RegisterDebug>b__10_5(Boolean)
				// void UnityEngine::Experimental::Rendering::RenderGraphModule::RenderGraphDebugParams::_RegisterDebug_b__10_5(
				//         RenderGraphDebugParams *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields.immediateMode = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool TrimSections
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_maintainPositionOffsets()
				// bool UnityEngine::Animations::Rigging::BlendConstraintData::get_maintainPositionOffsets(
				//         BlendConstraintData *this,
				//         MethodInfo *method)
				// {
				//   return this.m_MaintainPositionOffsets;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_maintainPositionOffsets(Boolean)
				// void UnityEngine::Animations::Rigging::BlendConstraintData::set_maintainPositionOffsets(
				//         BlendConstraintData *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.m_MaintainPositionOffsets = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool TrimComments
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_maintainRotationOffsets()
				// bool UnityEngine::Animations::Rigging::BlendConstraintData::get_maintainRotationOffsets(
				//         BlendConstraintData *this,
				//         MethodInfo *method)
				// {
				//   return this.m_MaintainRotationOffsets;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_maintainRotationOffsets(Boolean)
				// void UnityEngine::Animations::Rigging::BlendConstraintData::set_maintainRotationOffsets(
				//         BlendConstraintData *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.m_MaintainRotationOffsets = value;
				// }
				// 
			}
		}

		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool ParseComments
		{
			[CompilerGenerated]
			get
			{
				// // Boolean get_IgnoreSerializableAttribute()
				// bool Newtonsoft::Json::Serialization::DefaultContractResolver::get_IgnoreSerializableAttribute(
				//         DefaultContractResolver *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._IgnoreSerializableAttribute_k__BackingField;
				// }
				// 
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
				// // Void set_IgnoreSerializableAttribute(Boolean)
				// void Newtonsoft::Json::Serialization::DefaultContractResolver::set_IgnoreSerializableAttribute(
				//         DefaultContractResolver *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._IgnoreSerializableAttribute_k__BackingField = value;
				// }
				// 
			}
		}

		public IniParserConfiguration()
		{
		}

		private IniParserConfiguration(IniParserConfiguration ori)
		{
		}

		public IniParserConfiguration DeepClone()
		{
			// // IniParserConfiguration DeepClone()
			// IniParserConfiguration *IniParser::Configuration::IniParserConfiguration::DeepClone(
			//         IniParserConfiguration *this,
			//         MethodInfo *method)
			// {
			//   IniParserConfiguration *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   IniParserConfiguration *v6; // rbx
			// 
			//   if ( !byte_18D9192FB )
			//   {
			//     sub_18003C530(&TypeInfo::IniParser::Configuration::IniParserConfiguration);
			//     byte_18D9192FB = 1;
			//   }
			//   v3 = (IniParserConfiguration *)sub_180004920(TypeInfo::IniParser::Configuration::IniParserConfiguration);
			//   v6 = v3;
			//   if ( !v3 )
			//     sub_180B536AC(v5, v4);
			//   IniParser::Configuration::IniParserConfiguration::IniParserConfiguration(v3, this, 0LL);
			//   return v6;
			// }
			// 
			return null;
		}

		public enum EDuplicatePropertiesBehaviour
		{
			DisallowAndStopWithError,
			AllowAndKeepFirstValue,
			AllowAndKeepLastValue,
			AllowAndConcatenateValues
		}
	}
}
