using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IniParser;
using IniParser.Model;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGRenderPipelineSettingHub // TypeDefIndex: 38593
	{
		// Fields
		private const int MAX_DEVICE_TIER = 6000; // Metadata: 0x02303F18
		private static HGRenderPipelineSettingHub s_instance; // 0x00
		private HGRenderPipelineSettings m_impl; // 0x10
		private ISettingDataProcessLayer m_layer; // 0x18
	
		// Properties
		private static HGRenderPipelineSettings settingImpl { get => default; } // 0x000000018383D600-0x000000018383D660 
		// HGRenderPipelineSettingHub+HGRenderPipelineSettings get_settingImpl()
		HGRenderPipelineSettingHub_HGRenderPipelineSettings *HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  HGRenderPipelineSettingHub *instance; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size <= 600 )
		    goto LABEL_5;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size <= 0x258u )
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !wrapperArray[16].vector[24] )
		  {
		LABEL_5:
		    instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		    if ( instance )
		      return instance->fields.m_impl;
		LABEL_7:
		    sub_1800D8260(wrapperArray, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(600, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_240(Patch, 0LL);
		}
		
		internal bool isMobileShader { get => default; } // 0x0000000189C13DF4-0x0000000189C13E4C 
		// Boolean get_isMobileShader()
		bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_isMobileShader(
		        HGRenderPipelineSettingHub *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3824, 0LL) )
		    return HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceType(this, 0LL) == HGDeviceType__Enum_Handheld;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3824, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		internal bool isMobileHighShader { get => default; } // 0x0000000189C13CF4-0x0000000189C13D74 
		// Boolean get_isMobileHighShader()
		bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_isMobileHighShader(
		        HGRenderPipelineSettingHub *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3825, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3825, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceType(this, 0LL) == HGDeviceType__Enum_Handheld )
		  {
		    sub_1800036A0(TypeInfo::Beyond::Rendering::HGShaderQualitySettings);
		    return TypeInfo::Beyond::Rendering::HGShaderQualitySettings->static_fields->HgShaderLod == 1;
		  }
		  else
		  {
		    return 0;
		  }
		}
		
		internal bool isMobileLowShader { get => default; } // 0x0000000189C13D74-0x0000000189C13DF4 
		// Boolean get_isMobileLowShader()
		bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_isMobileLowShader(
		        HGRenderPipelineSettingHub *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3826, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3826, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceType(this, 0LL) == HGDeviceType__Enum_Handheld )
		  {
		    sub_1800036A0(TypeInfo::Beyond::Rendering::HGShaderQualitySettings);
		    return TypeInfo::Beyond::Rendering::HGShaderQualitySettings->static_fields->HgShaderLod == 0;
		  }
		  else
		  {
		    return 0;
		  }
		}
		
		public static HGRenderPipelineSettingHub instance { get => default; } // 0x0000000183106340-0x0000000183106410 
		public HGDeviceType currentDeviceType { get => default; } // 0x00000001831060D0-0x0000000183106130 
		// HGDeviceType get_currentDeviceType()
		HGDeviceType__Enum HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceType(
		        HGRenderPipelineSettingHub *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size <= 672 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_7;
		  if ( LODWORD(v3->_0.namespaze) <= 0x2A0 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[14]._0.properties )
		  {
		LABEL_5:
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		      return m_impl->fields._currentDeviceType_k__BackingField;
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(672, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int currentDeviceTier { get => default; } // 0x0000000183A63890-0x0000000183A638F0 
		// Int32 get_currentDeviceTier()
		int32_t HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceTier(
		        HGRenderPipelineSettingHub *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size <= 856 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_7;
		  if ( LODWORD(v3->_0.namespaze) <= 0x358 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[18]._0.interopData )
		  {
		LABEL_5:
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		      return m_impl->fields._currentDeviceTier_k__BackingField;
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(856, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		public int maxDeviceTier { get => default; set {} } // 0x0000000189C13E4C-0x0000000189C13EA4 0x0000000189C13EFC-0x0000000189C13F5C
		// Int32 get_maxDeviceTier()
		int32_t HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_maxDeviceTier(
		        HGRenderPipelineSettingHub *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3858, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		      return m_impl->fields.maximumDeviceTier;
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3858, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_maxDeviceTier(Int32)
		void HG::Rendering::Runtime::HGRenderPipelineSettingHub::set_maxDeviceTier(
		        HGRenderPipelineSettingHub *this,
		        int32_t value,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3859, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		    {
		      m_impl->fields.maximumDeviceTier = value;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3859, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, value, 0LL);
		}
		
		public string platformVariant { get => default; } // 0x0000000189C13EA4-0x0000000189C13EFC 
		// String get_platformVariant()
		String *HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_platformVariant(
		        HGRenderPipelineSettingHub *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3871, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		      return m_impl->fields.platformVariant;
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3871, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		public delegate void OnSettingChanged(HGDeviceType deviceType, int tier); // TypeDefIndex: 38581; 0x00000001838E1420-0x00000001838E1430
	
		internal static class ConstantStrings // TypeDefIndex: 38582
		{
			// Fields
			public static readonly string SETTING_PATH; // 0x00
			public static readonly string SETTING_ENTRY_FILE; // 0x08
			public static readonly string SETTING_FILE_LIST; // 0x10
			public static readonly string SETTING_EXT; // 0x18
			public static readonly string ARRAY_CONCATENATE_STR; // 0x20
			public static readonly string MULTI_PATTERN_STR; // 0x28
			public static readonly string SUBLEVEL_STR; // 0x30
			public static readonly string INVALID_STR; // 0x38
			public static readonly string DRIVER_VERSION_START_STR; // 0x40
			public static readonly string DRIVER_VERSION_END_STR; // 0x48
			public static readonly string DRIVER_VERSION_INTERVAL_STR; // 0x50
			public static readonly string INCLUDE_STR; // 0x58
			public static readonly string DEVICE_TIER_SETTING_STR; // 0x60
			public static readonly string SHADER_STRIP_SECTION; // 0x68
			public static readonly string SHADER_STRIP_PARAM; // 0x70
	
			// Constructors
			static ConstantStrings() {} // 0x00000001849B1A40-0x00000001849B1D20
		}
	
		private class HGRenderPipelineSettings // TypeDefIndex: 38588
		{
			// Fields
			public HashSet<string> forceSRPShaders; // 0x10
			private BaseSettingTable m_settingTable; // 0x20
			private Dictionary<string, OnSettingChanged> m_settingChangeCallbacks; // 0x28
			private Dictionary<string, int> m_overrideFeatureSettingTiers; // 0x30
			private Dictionary<string, List<SettingParameterBase>> m_registeredParameters; // 0x38
			private Dictionary<string, ParamInfo> m_paramLookupTable; // 0x40
			private HashSet<string> m_dirtyFeatureSettings; // 0x48
			private Dictionary<string, string> m_settingData; // 0x50
			public Dictionary<string, string> parameterTablePath; // 0x58
			private bool m_useDefaultSettings; // 0x60
			internal int maximumDeviceTier; // 0x64
			internal int minimumDeviceTier; // 0x68
			internal string platformVariant; // 0x70
			private static string s_cachedGraphicsDeviceType; // 0x00
	
			// Properties
			public HGDeviceType currentDeviceType { get; private set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
			// LayerMask get_value()
			LayerMask UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::get_value(
			        VolumeParameter_1_UnityEngine_LayerMask_ *this,
			        MethodInfo *method)
			{
			  return (LayerMask)this->fields.m_Value.m_Mask;
			}
			

			// Void set_value(LayerMask)
			void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::set_value(
			        VolumeParameter_1_UnityEngine_LayerMask_ *this,
			        LayerMask value,
			        MethodInfo *method)
			{
			  this->fields.m_Value = value;
			}
			
			public int currentDeviceTier { get; private set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
			// Int32 get_rolloverSize()
			int32_t TMPro::TMP_TextProcessingStack<System::Object>::get_rolloverSize(
			        TMP_TextProcessingStack_1_System_Object_ *this,
			        MethodInfo *method)
			{
			  return this->m_RolloverSize;
			}
			

			// Void set_rolloverSize(Int32)
			void TMPro::TMP_TextProcessingStack<System::Object>::set_rolloverSize(
			        TMP_TextProcessingStack_1_System_Object_ *this,
			        int32_t value,
			        MethodInfo *method)
			{
			  this->m_RolloverSize = value;
			}
			
			private bool useDefaultSettings { get => default; set {} } // 0x000000018383CFF0-0x000000018383D020 0x0000000189C1563C-0x0000000189C156A8
			// Boolean get_useDefaultSettings()
			bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_useDefaultSettings(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(595, 0LL) )
			    return this->fields.m_useDefaultSettings;
			  Patch = IFix::WrappersManagerImpl::GetPatch(595, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			}
			

			// Void set_useDefaultSettings(Boolean)
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::set_useDefaultSettings(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        bool value,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3881, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3881, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
			  }
			  else if ( this->fields.m_useDefaultSettings != value )
			  {
			    this->fields.m_useDefaultSettings = value;
			    HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshAllSettings(this, 0LL);
			  }
			}
			
			public Dictionary<string, int> overrideFeatureSettingTiers { get => default; } // 0x000000018383D660-0x000000018383D6C0 
			// Dictionary`2[System.String,System.Int32] get_overrideFeatureSettingTiers()
			Dictionary_2_System_String_System_Int32_ *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_overrideFeatureSettingTiers(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        MethodInfo *method)
			{
			  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v3->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    goto LABEL_6;
			  if ( wrapperArray->max_length.size <= 602 )
			    return this->fields.m_overrideFeatureSettingTiers;
			  if ( !v3->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v3);
			    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
			  if ( !v3 )
			    goto LABEL_6;
			  if ( LODWORD(v3->_0.namespaze) <= 0x25A )
			    sub_1800D2AB0(v3, method);
			  if ( !v3[12].vtable.Finalize.method )
			    return this->fields.m_overrideFeatureSettingTiers;
			  Patch = IFix::WrappersManagerImpl::GetPatch(602, 0LL);
			  if ( !Patch )
			LABEL_6:
			    sub_1800D8260(v3, method);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_241(Patch, (Object *)this, 0LL);
			}
			
			public Dictionary<string, ParamInfo> paramLookupTable { get => default; } // 0x000000018383D280-0x000000018383D2E0 
			// Dictionary`2[System.String,HG.Rendering.Runtime.HGRenderPipelineSettingHub+HGRenderPipelineSettings+ParamInfo] get_paramLookupTable()
			Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo_ *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_paramLookupTable(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        MethodInfo *method)
			{
			  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v3->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    goto LABEL_6;
			  if ( wrapperArray->max_length.size <= 607 )
			    return this->fields.m_paramLookupTable;
			  if ( !v3->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v3);
			    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
			  if ( !v3 )
			    goto LABEL_6;
			  if ( LODWORD(v3->_0.namespaze) <= 0x25F )
			    sub_1800D2AB0(v3, method);
			  if ( !v3[13]._0.image )
			    return this->fields.m_paramLookupTable;
			  Patch = IFix::WrappersManagerImpl::GetPatch(607, 0LL);
			  if ( !Patch )
			LABEL_6:
			    sub_1800D8260(v3, method);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_242(Patch, (Object *)this, 0LL);
			}
			
			internal Dictionary<string, string> settingData { get => default; } // 0x0000000189C155EC-0x0000000189C1563C 
			// Dictionary`2[System.String,System.String] get_settingData()
			Dictionary_2_System_String_System_String_ *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_settingData(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3874, 0LL) )
			    return this->fields.m_settingData;
			  Patch = IFix::WrappersManagerImpl::GetPatch(3874, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1366(Patch, (Object *)this, 0LL);
			}
			
			public Dictionary<string, List<SettingParameterBase>> registeredParameters { get => default; } // 0x0000000189C1559C-0x0000000189C155EC 
			// Dictionary`2[System.String,List`1[HG.Rendering.Runtime.HGRenderPipelineSettingHub+SettingParameterBase]] get_registeredParameters()
			Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_registeredParameters(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3877, 0LL) )
			    return this->fields.m_registeredParameters;
			  Patch = IFix::WrappersManagerImpl::GetPatch(3877, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1367(Patch, (Object *)this, 0LL);
			}
			
	
			// Nested types
			internal struct TierValue // TypeDefIndex: 38583
			{
				// Fields
				internal BaseSettingTable from; // 0x00
				internal string value; // 0x08
			}
	
			internal class ParamInfo // TypeDefIndex: 38584
			{
				// Fields
				internal string constrain; // 0x10
				internal Dictionary<int, TierValue> tierValues; // 0x18
				internal List<int> tiers; // 0x20
				internal ParamInfo next; // 0x28
	
				// Constructors
				internal ParamInfo() {} // 0x000000018383DDE0-0x000000018383DE80
			}
	
			public class BaseSettingTable // TypeDefIndex: 38585
			{
				// Fields
				internal BaseSettingTable includeFrom; // 0x10
				internal List<BaseSettingTable> includeList; // 0x18
				internal string filePath; // 0x20
				internal bool isOverrideTable; // 0x28
				internal List<string> includeSettings; // 0x30
				internal IniData iniData; // 0x38
	
				// Constructors
				public BaseSettingTable() {} // 0x00000001835A7B70-0x00000001835A7C60
	
				// Methods
				private static string ReadSettingData(ref string relativePath, ref string settingPath, Dictionary<string, string> settingData) => default; // 0x00000001835A78B0-0x00000001835A79C0
				// String ReadSettingData(String ByRef, String ByRef, Dictionary`2[System.String,System.String])
				String *HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ReadSettingData(
				        String **relativePath,
				        String **settingPath,
				        Dictionary_2_System_String_System_String_ *settingData,
				        MethodInfo *method)
				{
				  __int64 v7; // rdx
				  String *v8; // rcx
				  String *v9; // rbp
				  HGRenderPathBase_HGRenderPathResources *v10; // rdx
				  PassConstructorID__Enum__Array *v11; // r8
				  Int32__Array **v12; // r9
				  struct HGRenderPipelineSettingHub_ConstantStrings__Class *v13; // rax
				  Object *v14; // rax
				  HGRenderPathBase_HGRenderPathResources *v16; // rdx
				  PassConstructorID__Enum__Array *v17; // r8
				  Int32__Array **v18; // r9
				  String *v19; // rdi
				  String *v20; // rbx
				  String *v21; // rax
				  String *v22; // rdi
				  __int64 v23; // rax
				  Exception *v24; // rax
				  Exception *v25; // rbx
				  __int64 v26; // rax
				  ILFixDynamicMethodWrapper_2 *Patch; // rax
				  MethodInfo *methoda; // [rsp+20h] [rbp-28h]
				  MethodInfo *v29; // [rsp+28h] [rbp-20h]
				  Object *value; // [rsp+30h] [rbp-18h] BYREF
				
				  value = 0LL;
				  if ( !IFix::WrappersManagerImpl::IsPatched(3840, 0LL) )
				  {
				    v8 = *relativePath;
				    if ( *relativePath )
				    {
				      if ( !System::String::Equals(v8, (String *)"", 0LL) )
				      {
				        *settingPath = System::String::Concat(*relativePath, (String *)"/", *settingPath, 0LL);
				        sub_18002D1B0((HGRenderPathScene *)settingPath, v16, v17, v18, methoda, v29);
				      }
				      v9 = *settingPath;
				      if ( !TypeInfo::System::IO::Path->_1.cctor_finished_or_no_cctor )
				        il2cpp_runtime_class_init_1(TypeInfo::System::IO::Path);
				      *relativePath = System::IO::Path::GetDirectoryName(v9, 0LL);
				      sub_18002D1B0((HGRenderPathScene *)relativePath, v10, v11, v12, methoda, v29);
				      v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				      if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->_1.cctor_finished_or_no_cctor )
				      {
				        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				        v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				      }
				      v14 = (Object *)System::String::Concat(v13->static_fields->SETTING_PATH, *settingPath, 0LL);
				      if ( settingData )
				      {
				        if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
				               (Dictionary_2_System_Object_System_Object_ *)settingData,
				               v14,
				               &value,
				               MethodInfo::System::Collections::Generic::Dictionary<System::String,System::String>::TryGetValue) )
				        {
				          return (String *)value;
				        }
				        v19 = *settingPath;
				        v20 = (String *)sub_180035ED0(&off_18E27BB88);
				        v21 = (String *)sub_180035ED0(&off_18E27BB90);
				        v22 = System::String::Concat(v21, v19, v20, 0LL);
				        v23 = sub_180035ED0(&TypeInfo::System::Exception);
				        v24 = (Exception *)sub_1800368D0(v23);
				        v25 = v24;
				        if ( v24 )
				        {
				          System::Exception::Exception(v24, v22, 0LL);
				          v26 = sub_180035ED0(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ReadSettingData);
				          sub_18007E190(v25, v26);
				        }
				      }
				    }
				LABEL_12:
				    sub_1800D8260(v8, v7);
				  }
				  Patch = IFix::WrappersManagerImpl::GetPatch(3840, 0LL);
				  if ( !Patch )
				    goto LABEL_12;
				  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1358(Patch, relativePath, settingPath, (Object *)settingData, 0LL);
				}
				
				private void ParseInclude(string constrain, HGDeviceType deviceType, string relativePath, IniDataParser parser, Dictionary<string, string> settingData, HGRenderPipelineSettings impl, bool isOverride = false /* Metadata: 0x02303F1C */) {} // 0x00000001835A7370-0x00000001835A77C0
				// Void ParseInclude(String, HGDeviceType, String, IniDataParser, Dictionary`2[System.String,System.String], HGRenderPipelineSettingHub+HGRenderPipelineSettings, Boolean)
				// Hidden C++ exception states: #wind=1 #try_helpers=1
				void HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ParseInclude(
				        HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *this,
				        String *constrain,
				        HGDeviceType__Enum deviceType,
				        String *relativePath,
				        IniDataParser *parser,
				        Dictionary_2_System_String_System_String_ *settingData,
				        HGRenderPipelineSettingHub_HGRenderPipelineSettings *impl,
				        bool isOverride,
				        MethodInfo *method)
				{
				  struct HGRenderPipelineSettingHub_ConstantStrings__Class *v13; // rax
				  String *INCLUDE_STR; // rdi
				  __int64 v15; // rdx
				  __int64 v16; // rcx
				  struct HGRenderPipelineSettingHub_ConstantStrings__Class *v17; // rax
				  IniData *iniData; // rbx
				  SectionCollection *Sections_k__BackingField; // rbx
				  Section *v20; // rax
				  __int64 v21; // rdx
				  __int64 v22; // rcx
				  __int64 *v23; // rdx
				  signed __int64 v24; // rcx
				  __int64 v25; // rsi
				  struct IEnumerator__Class *v26; // rdi
				  __int64 v27; // r14
				  unsigned __int16 v28; // cx
				  unsigned __int16 v29; // dx
				  __int64 v30; // r8
				  __int64 v31; // rdx
				  __int64 v32; // rdx
				  __int64 v33; // rcx
				  __int64 v34; // rax
				  __int64 v35; // rdx
				  __int64 v36; // rcx
				  String *v37; // rdi
				  struct HGRenderPipelineSettingHub_ConstantStrings__Class *v38; // rax
				  String *ARRAY_CONCATENATE_STR; // rdx
				  __int64 v40; // r8
				  String__Array *v41; // r15
				  int32_t v42; // esi
				  String *v43; // r14
				  HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *v44; // rax
				  __int64 v45; // rdx
				  __int64 v46; // rcx
				  HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *v47; // rdi
				  __int64 v48; // rdx
				  List_1_System_Object_ *includeList; // rcx
				  unsigned int v50; // edi
				  char v51; // di
				  __int64 v52; // rtt
				  __int64 v53; // rdx
				  __int64 v54; // rcx
				  ILFixDynamicMethodWrapper_2 *Patch; // rdi
				  _QWORD v56[6]; // [rsp+50h] [rbp-58h] BYREF
				
				  if ( IFix::WrappersManagerImpl::IsPatched(3842, 0LL) )
				  {
				    Patch = IFix::WrappersManagerImpl::GetPatch(3842, 0LL);
				    if ( !Patch )
				      sub_1800D8260(v54, v53);
				    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1359(
				      Patch,
				      (Object *)this,
				      (Object *)constrain,
				      deviceType,
				      (Object *)relativePath,
				      (Object *)parser,
				      (Object *)settingData,
				      (Object *)impl,
				      isOverride,
				      0LL);
				  }
				  else
				  {
				    v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->_1.cctor_finished_or_no_cctor )
				    {
				      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				      v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				    }
				    INCLUDE_STR = v13->static_fields->INCLUDE_STR;
				    if ( System::String::op_Inequality(constrain, (String *)"", 0LL) )
				    {
				      v17 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				      if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->_1.cctor_finished_or_no_cctor )
				      {
				        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				        v17 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				      }
				      INCLUDE_STR = System::String::Concat(INCLUDE_STR, v17->static_fields->SUBLEVEL_STR, constrain, 0LL);
				    }
				    iniData = this->fields.iniData;
				    if ( !iniData )
				      sub_1800D8260(v16, v15);
				    Sections_k__BackingField = iniData->fields._Sections_k__BackingField;
				    if ( !Sections_k__BackingField )
				      sub_1800D8260(v16, v15);
				    v20 = IniParser::Model::SectionCollection::FindByName(Sections_k__BackingField, INCLUDE_STR, 0LL);
				    if ( v20 )
				    {
				      if ( !v20->fields._Properties_k__BackingField )
				        sub_1800D8260(v22, v21);
				      v56[0] = IniParser::Model::PropertyCollection::GetEnumerator(v20->fields._Properties_k__BackingField, 0LL);
				      v56[3] = 0LL;
				      v56[4] = v56;
				      while ( 1 )
				      {
				        v25 = v56[0];
				        if ( !v56[0] )
				          sub_1800D8250(v24, v23);
				        v26 = TypeInfo::System::Collections::IEnumerator;
				        v27 = *(_QWORD *)v56[0];
				        sub_1800049A0(*(_QWORD *)v56[0]);
				        v28 = 0;
				        v29 = *(_WORD *)(v27 + 304);
				        if ( v29 )
				        {
				          v30 = *(_QWORD *)(v27 + 176);
				          while ( *(struct IEnumerator__Class **)(v30 + 16LL * v28) != v26 )
				          {
				            if ( ++v28 >= v29 )
				              goto LABEL_18;
				          }
				          v31 = v27 + 16 * (*(int *)(v30 + 16LL * v28 + 8) + 20LL);
				        }
				        else
				        {
				LABEL_18:
				          v31 = sub_1800219C0(v25, v26, 0LL);
				        }
				        if ( !(*(unsigned __int8 (__fastcall **)(__int64, _QWORD))v31)(v25, *(_QWORD *)(v31 + 8)) )
				          break;
				        if ( !v56[0] )
				          sub_1800D8250(v33, v32);
				        v34 = sub_18006E0A0();
				        if ( !v34 )
				          sub_1800D8250(v36, v35);
				        v37 = *(String **)(v34 + 16);
				        v38 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				        if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->_1.cctor_finished_or_no_cctor )
				        {
				          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				          v38 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				        }
				        ARRAY_CONCATENATE_STR = v38->static_fields->ARRAY_CONCATENATE_STR;
				        if ( !v37 )
				          sub_1800D8250(v36, ARRAY_CONCATENATE_STR);
				        if ( !ARRAY_CONCATENATE_STR )
				          ARRAY_CONCATENATE_STR = TypeInfo::System::String->static_fields->Empty;
				        v41 = System::String::SplitInternal(
				                v37,
				                ARRAY_CONCATENATE_STR,
				                0LL,
				                0x7FFFFFFF,
				                StringSplitOptions__Enum_None,
				                0LL);
				        v42 = 0;
				        if ( !v41 )
				          sub_1800D8250(v24, v23);
				        while ( v42 < v41->max_length.size )
				        {
				          if ( (unsigned int)v42 >= v41->max_length.size )
				            sub_1800D2AA0(v42, v23, v40);
				          v43 = v41->vector[v42];
				          v44 = (HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable);
				          v47 = v44;
				          if ( !v44 )
				            sub_1800D8250(v46, v45);
				          HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::BaseSettingTable(
				            v44,
				            0LL);
				          v47->fields.isOverrideTable = isOverride;
				          HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::PopulateSettingTable(
				            v47,
				            parser,
				            this,
				            deviceType,
				            relativePath,
				            v43,
				            settingData,
				            impl,
				            0LL);
				          includeList = (List_1_System_Object_ *)this->fields.includeList;
				          if ( !includeList )
				            sub_1800D8250(0LL, v48);
				          sub_182F01190(includeList, (Object *)v47);
				          v47->fields.includeFrom = this;
				          if ( dword_18F35FD08 )
				          {
				            v50 = ((unsigned __int64)&v47->fields >> 12) & 0x1FFFFF;
				            v23 = &qword_18F103690[(unsigned __int64)v50 >> 6];
				            v51 = v50 & 0x3F;
				            _m_prefetchw(v23);
				            do
				            {
				              v24 = *v23 | (1LL << v51);
				              v52 = *v23;
				            }
				            while ( v52 != _InterlockedCompareExchange64(v23, v24, *v23) );
				          }
				          ++v42;
				        }
				      }
				      if ( v56[0] )
				        sub_180053A90(0LL, TypeInfo::System::IDisposable);
				    }
				  }
				}
				
				internal virtual void PopulateSettingTable(IniDataParser parser, BaseSettingTable includeFrom, HGDeviceType deviceType, string relativePath, string settingPath, Dictionary<string, string> settingData, HGRenderPipelineSettings impl) {} // 0x00000001835A7140-0x00000001835A7370
				// Void PopulateSettingTable(IniDataParser, HGRenderPipelineSettingHub+HGRenderPipelineSettings+BaseSettingTable, HGDeviceType, String, String, Dictionary`2[System.String,System.String], HGRenderPipelineSettingHub+HGRenderPipelineSettings)
				void HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::PopulateSettingTable(
				        HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *this,
				        IniDataParser *parser,
				        HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *includeFrom,
				        HGDeviceType__Enum deviceType,
				        String *relativePath,
				        String *settingPath,
				        Dictionary_2_System_String_System_String_ *settingData,
				        HGRenderPipelineSettingHub_HGRenderPipelineSettings *impl,
				        MethodInfo *method)
				{
				  Dictionary_2_System_String_System_String_ *v13; // rbp
				  String *v14; // rax
				  __int64 v15; // rdx
				  ILFixDynamicMethodWrapper_2 *Patch; // rcx
				  String *v17; // rdi
				  HGRenderPathBase_HGRenderPathResources *v18; // rdx
				  PassConstructorID__Enum__Array *v19; // r8
				  Int32__Array **v20; // r9
				  Int32__Array **v21; // r9
				  HGRenderPathBase_HGRenderPathResources *v22; // rdx
				  PassConstructorID__Enum__Array *v23; // r8
				  HGRenderPathBase_HGRenderPathResources *v24; // rdx
				  PassConstructorID__Enum__Array *v25; // r8
				  Int32__Array **v26; // r9
				  IniData *iniData; // r9
				  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v28; // rdi
				  String *v29; // rax
				  String *platformVariant; // rax
				  String *v31; // rax
				  String *v32; // rax
				  MethodInfo *parsera; // [rsp+20h] [rbp-68h]
				  MethodInfo *parserb; // [rsp+20h] [rbp-68h]
				  MethodInfo *parserc; // [rsp+20h] [rbp-68h]
				  MethodInfo *v36; // [rsp+28h] [rbp-60h]
				  MethodInfo *v37; // [rsp+28h] [rbp-60h]
				  MethodInfo *v38; // [rsp+28h] [rbp-60h]
				  Enum v39; // [rsp+50h] [rbp-38h] BYREF
				  HGDeviceType__Enum v40; // [rsp+60h] [rbp-28h]
				
				  if ( IFix::WrappersManagerImpl::IsPatched(3839, 0LL) )
				  {
				    Patch = IFix::WrappersManagerImpl::GetPatch(3839, 0LL);
				    if ( Patch )
				    {
				      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1360(
				        Patch,
				        (Object *)this,
				        (Object *)parser,
				        (Object *)includeFrom,
				        deviceType,
				        (Object *)relativePath,
				        (Object *)settingPath,
				        (Object *)settingData,
				        (Object *)impl,
				        0LL);
				      return;
				    }
				    goto LABEL_9;
				  }
				  v13 = settingData;
				  v14 = HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ReadSettingData(
				          &relativePath,
				          &settingPath,
				          settingData,
				          0LL);
				  v17 = v14;
				  if ( !v14 )
				    goto LABEL_9;
				  if ( System::String::Equals(v14, (String *)"", 0LL) )
				    return;
				  if ( !parser )
				    goto LABEL_9;
				  this->fields.iniData = IniParser::IniDataParser::Parse(parser, v17, 0LL);
				  sub_18002D1B0((HGRenderPathScene *)&this->fields.iniData, v18, v19, v20, parsera, v36);
				  v21 = (Int32__Array **)settingPath;
				  this->fields.filePath = settingPath;
				  sub_18002D1B0((HGRenderPathScene *)&this->fields.filePath, v22, v23, v21, parserb, v37);
				  this->fields.includeFrom = includeFrom;
				  sub_18002D1B0((HGRenderPathScene *)&this->fields, v24, v25, v26, parserc, v38);
				  iniData = this->fields.iniData;
				  if ( !iniData )
				    goto LABEL_9;
				  if ( !iniData->fields._Sections_k__BackingField )
				    return;
				  v28 = impl;
				  HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ParseInclude(
				    this,
				    (String *)"",
				    deviceType,
				    relativePath,
				    parser,
				    v13,
				    impl,
				    this->fields.isOverrideTable,
				    0LL);
				  v39.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::HGDeviceType;
				  v39.monitor = (MonitorData *)-1LL;
				  v40 = deviceType;
				  v29 = System::Enum::ToString(&v39, 0LL);
				  HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ParseInclude(
				    this,
				    v29,
				    deviceType,
				    relativePath,
				    parser,
				    v13,
				    v28,
				    this->fields.isOverrideTable,
				    0LL);
				  if ( includeFrom )
				    return;
				  if ( !v28 )
				LABEL_9:
				    sub_1800D8260(Patch, v15);
				  platformVariant = v28->fields.platformVariant;
				  if ( platformVariant )
				  {
				    if ( platformVariant->fields._stringLength )
				    {
				      v39.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::HGDeviceType;
				      v39.monitor = (MonitorData *)-1LL;
				      v40 = deviceType;
				      v31 = System::Enum::ToString(&v39, 0LL);
				      v32 = (String *)sub_1841315B0(
				                        v31,
				                        ".",
				                        v28->fields.platformVariant,
				                        MethodInfo::Beyond::StringUtils::ZConcat<System::String,System::String,System::String>);
				      HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ParseInclude(
				        this,
				        v32,
				        deviceType,
				        relativePath,
				        parser,
				        v13,
				        v28,
				        1,
				        0LL);
				    }
				  }
				}
				
			}
	
			// Constructors
			public HGRenderPipelineSettings() {} // Dummy constructor
			public HGRenderPipelineSettings(int maximumDeviceTier) {} // 0x0000000184640B70-0x0000000184640FF0
			// HGRenderPipelineSettingHub+HGRenderPipelineSettings(Int32)
			// Hidden C++ exception states: #wind=1
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::HGRenderPipelineSettings(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        int32_t maximumDeviceTier,
			        MethodInfo *method)
			{
			  int32_t v3; // esi
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v4; // rbx
			  HashSet_1_System_Object_ *v5; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			  HashSet_1_System_Object_ *v8; // rdi
			  HGRenderPathBase_HGRenderPathResources *v9; // rdx
			  PassConstructorID__Enum__Array *v10; // r8
			  Int32__Array **v11; // r9
			  Dictionary_2_System_Object_System_Object_ *v12; // rax
			  __int64 v13; // rdx
			  __int64 v14; // rcx
			  Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_OnSettingChanged_ *v15; // rdi
			  HGRenderPathBase_HGRenderPathResources *v16; // rdx
			  PassConstructorID__Enum__Array *v17; // r8
			  Int32__Array **v18; // r9
			  Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v19; // rax
			  __int64 v20; // rdx
			  __int64 v21; // rcx
			  Dictionary_2_System_String_System_Int32_ *v22; // rdi
			  HGRenderPathBase_HGRenderPathResources *v23; // rdx
			  PassConstructorID__Enum__Array *v24; // r8
			  Int32__Array **v25; // r9
			  Dictionary_2_System_Object_System_Object_ *v26; // rax
			  __int64 v27; // rdx
			  __int64 v28; // rcx
			  Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *v29; // rdi
			  HGRenderPathBase_HGRenderPathResources *v30; // rdx
			  PassConstructorID__Enum__Array *v31; // r8
			  Int32__Array **v32; // r9
			  Dictionary_2_System_Object_System_Object_ *v33; // rax
			  __int64 v34; // rdx
			  __int64 v35; // rcx
			  Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo_ *v36; // rdi
			  HGRenderPathBase_HGRenderPathResources *v37; // rdx
			  PassConstructorID__Enum__Array *v38; // r8
			  Int32__Array **v39; // r9
			  HashSet_1_System_Object_ *v40; // rax
			  __int64 v41; // rdx
			  __int64 v42; // rcx
			  HashSet_1_System_String_ *v43; // rdi
			  HGRenderPathBase_HGRenderPathResources *v44; // rdx
			  PassConstructorID__Enum__Array *v45; // r8
			  Int32__Array **v46; // r9
			  Dictionary_2_System_Object_System_Object_ *v47; // rax
			  __int64 v48; // rdx
			  __int64 v49; // rcx
			  Dictionary_2_System_String_System_String_ *v50; // rdi
			  HGRenderPathBase_HGRenderPathResources *v51; // rdx
			  PassConstructorID__Enum__Array *v52; // r8
			  Int32__Array **v53; // r9
			  Dictionary_2_System_Object_System_Object_ *v54; // rax
			  __int64 v55; // rdx
			  __int64 v56; // rcx
			  Dictionary_2_System_String_System_String_ *v57; // rdi
			  HGRenderPathBase_HGRenderPathResources *v58; // rdx
			  PassConstructorID__Enum__Array *v59; // r8
			  Int32__Array **v60; // r9
			  HGRenderPathBase_HGRenderPathResources *v61; // rdx
			  PassConstructorID__Enum__Array *v62; // r8
			  __int64 v63; // rdx
			  __int64 v64; // rcx
			  Object *current; // rdi
			  void (__fastcall *v66)(Object *); // rax
			  __int64 v67; // rax
			  MethodInfo *v68; // [rsp+20h] [rbp-48h] BYREF
			  HashSet_1_T_Enumerator_System_Object_ v69; // [rsp+28h] [rbp-40h] BYREF
			  HashSet_1_T_Enumerator_System_Object_ v70; // [rsp+40h] [rbp-28h] BYREF
			
			  v3 = maximumDeviceTier;
			  v4 = this;
			  v5 = (HashSet_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::HashSet<System::String>);
			  v8 = v5;
			  if ( !v5 )
			    sub_1800D8260(v7, v6);
			  System::Collections::Generic::HashSet<System::Object>::HashSet(
			    v5,
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::HashSet);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/CloudCard",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/Blockout/LitPoly",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/Effect/VFXSmoke",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/Foliage/Leaf",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/Lit",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/LitBuilding",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/LitForward",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/LitHLOD",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/LitRock",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/LitTransparent",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/LitWater",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/Unlit",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/CharacterNPR",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/CharacterNPR_Hair",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/CharacterNPR_Skin",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/CharacterNPR_Eye",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/CharacterNPR_LiquidAg",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  System::Collections::Generic::HashSet<System::Object>::Add(
			    v8,
			    (Object *)"HGRP/CharacterNPR_OverlayShadow",
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			  v4->fields.forceSRPShaders = (HashSet_1_System_String_ *)v8;
			  sub_18002D1B0((HGRenderPathScene *)&v4->fields, v9, v10, v11, v68, (MethodInfo *)v69._set);
			  v4->fields._currentDeviceTier_k__BackingField = -1;
			  v12 = (Dictionary_2_System_Object_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>);
			  v15 = (Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_OnSettingChanged_ *)v12;
			  if ( !v12 )
			    sub_1800D8260(v14, v13);
			  System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
			    v12,
			    MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>::Dictionary);
			  v4->fields.m_settingChangeCallbacks = v15;
			  sub_18002D1B0((HGRenderPathScene *)&v4->fields.m_settingChangeCallbacks, v16, v17, v18, v68, (MethodInfo *)v69._set);
			  v19 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::String,int>);
			  v22 = (Dictionary_2_System_String_System_Int32_ *)v19;
			  if ( !v19 )
			    sub_1800D8260(v21, v20);
			  System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Dictionary(
			    v19,
			    MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::Dictionary);
			  v4->fields.m_overrideFeatureSettingTiers = v22;
			  sub_18002D1B0(
			    (HGRenderPathScene *)&v4->fields.m_overrideFeatureSettingTiers,
			    v23,
			    v24,
			    v25,
			    v68,
			    (MethodInfo *)v69._set);
			  v26 = (Dictionary_2_System_Object_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>);
			  v29 = (Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *)v26;
			  if ( !v26 )
			    sub_1800D8260(v28, v27);
			  System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
			    v26,
			    MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::Dictionary);
			  v4->fields.m_registeredParameters = v29;
			  sub_18002D1B0((HGRenderPathScene *)&v4->fields.m_registeredParameters, v30, v31, v32, v68, (MethodInfo *)v69._set);
			  v33 = (Dictionary_2_System_Object_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>);
			  v36 = (Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo_ *)v33;
			  if ( !v33 )
			    sub_1800D8260(v35, v34);
			  System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
			    v33,
			    MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::Dictionary);
			  v4->fields.m_paramLookupTable = v36;
			  sub_18002D1B0((HGRenderPathScene *)&v4->fields.m_paramLookupTable, v37, v38, v39, v68, (MethodInfo *)v69._set);
			  v40 = (HashSet_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::HashSet<System::String>);
			  v43 = (HashSet_1_System_String_ *)v40;
			  if ( !v40 )
			    sub_1800D8260(v42, v41);
			  System::Collections::Generic::HashSet<System::Object>::HashSet(
			    v40,
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::HashSet);
			  v4->fields.m_dirtyFeatureSettings = v43;
			  sub_18002D1B0((HGRenderPathScene *)&v4->fields.m_dirtyFeatureSettings, v44, v45, v46, v68, (MethodInfo *)v69._set);
			  v47 = (Dictionary_2_System_Object_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::String,System::String>);
			  v50 = (Dictionary_2_System_String_System_String_ *)v47;
			  if ( !v47 )
			    sub_1800D8260(v49, v48);
			  System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
			    v47,
			    MethodInfo::System::Collections::Generic::Dictionary<System::String,System::String>::Dictionary);
			  v4->fields.m_settingData = v50;
			  sub_18002D1B0((HGRenderPathScene *)&v4->fields.m_settingData, v51, v52, v53, v68, (MethodInfo *)v69._set);
			  v54 = (Dictionary_2_System_Object_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::String,System::String>);
			  v57 = (Dictionary_2_System_String_System_String_ *)v54;
			  if ( !v54 )
			    sub_1800D8260(v56, v55);
			  System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
			    v54,
			    MethodInfo::System::Collections::Generic::Dictionary<System::String,System::String>::Dictionary);
			  v4->fields.parameterTablePath = v57;
			  sub_18002D1B0((HGRenderPathScene *)&v4->fields.parameterTablePath, v58, v59, v60, v68, (MethodInfo *)v69._set);
			  v4->fields.platformVariant = (String *)"";
			  sub_18002D1B0(
			    (HGRenderPathScene *)&v4->fields.platformVariant,
			    v61,
			    v62,
			    (Int32__Array **)"",
			    v68,
			    (MethodInfo *)v69._set);
			  if ( !v4->fields.forceSRPShaders )
			    sub_1800D8260(v64, v63);
			  System::Collections::Generic::HashSet<unsigned long>::GetEnumerator(
			    (HashSet_1_T_Enumerator_System_UInt64_ *)&v69,
			    (HashSet_1_System_UInt64_ *)v4->fields.forceSRPShaders,
			    MethodInfo::System::Collections::Generic::HashSet<System::String>::GetEnumerator);
			  v70 = v69;
			  v69._set = 0LL;
			  *(_QWORD *)&v69._index = &v70;
			  try
			  {
			    while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
			              &v70,
			              MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::String>::MoveNext) )
			    {
			      current = v70._current;
			      v66 = (void (__fastcall *)(Object *))qword_18F370338;
			      if ( !qword_18F370338 )
			      {
			        v66 = (void (__fastcall *)(Object *))il2cpp_resolve_icall_1(
			                                               "UnityEngine.Rendering.GraphicsSettings::INTERNAL_AddShaderToSRPInstancing"
			                                               "WhiteList(System.String)");
			        if ( !v66 )
			        {
			          v67 = sub_1802EE1B8("UnityEngine.Rendering.GraphicsSettings::INTERNAL_AddShaderToSRPInstancingWhiteList(System.String)");
			          sub_18007E1B0(v67, 0LL);
			        }
			        qword_18F370338 = (__int64)v66;
			      }
			      v66(current);
			    }
			  }
			  catch ( Il2CppExceptionWrapper *v68 )
			  {
			    v69._set = (HashSet_1_System_Object_ *)v68->methodPointer;
			    if ( v69._set )
			      sub_18007E1E0(v69._set);
			    v3 = maximumDeviceTier;
			    v4 = this;
			  }
			  v4->fields._currentDeviceTier_k__BackingField = v3;
			  v4->fields.maximumDeviceTier = v3;
			  v4->fields.minimumDeviceTier = 1000;
			}
			
	
			// Methods
			[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
			private static void EnsureCachedGraphicsDeviceType() {} // 0x0000000184D2F720-0x0000000184D2F7A0
			// Void EnsureCachedGraphicsDeviceType()
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::EnsureCachedGraphicsDeviceType(
			        MethodInfo *method)
			{
			  GraphicsDeviceType__Enum GraphicsDeviceType; // eax
			  String *v2; // rax
			  HGRenderPathBase_HGRenderPathResources *static_fields; // rdx
			  PassConstructorID__Enum__Array *v4; // r8
			  Int32__Array **v5; // r9
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			  Enum v9; // [rsp+20h] [rbp-28h] BYREF
			  GraphicsDeviceType__Enum v10; // [rsp+30h] [rbp-18h]
			  MethodInfo *v11; // [rsp+70h] [rbp+28h]
			  MethodInfo *v12; // [rsp+78h] [rbp+30h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(609, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(609, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v8, v7);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
			  }
			  else
			  {
			    GraphicsDeviceType = UnityEngine::SystemInfo::GetGraphicsDeviceType(0LL);
			    v9.klass = (Enum__Class *)TypeInfo::UnityEngine::Rendering::GraphicsDeviceType;
			    v9.monitor = (MonitorData *)-1LL;
			    v10 = GraphicsDeviceType;
			    v2 = System::Enum::ToString(&v9, 0LL);
			    static_fields = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings->static_fields;
			    static_fields->defaultResources = (HGRenderPipelineRuntimeResources *)v2;
			    sub_18002D1B0(
			      (HGRenderPathScene *)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings->static_fields,
			      static_fields,
			      v4,
			      v5,
			      v11,
			      v12);
			  }
			}
			
			internal int CheckConstrains(string constrainString) => default; // 0x000000018383D780-0x000000018383DA50
			// Int32 CheckConstrains(String)
			int32_t HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::CheckConstrains(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        String *constrainString,
			        MethodInfo *method)
			{
			  String **p_s_cachedGraphicsDeviceType; // rcx
			  struct HGRenderPipelineSettingHub_ConstantStrings__Class *v6; // rax
			  String *MULTI_PATTERN_STR; // rdx
			  int32_t v8; // ebx
			  String__Array *v9; // rdi
			  int32_t v10; // esi
			  String *v11; // rbp
			  String *DeviceModel; // r15
			  String *DeviceName; // r12
			  String *OperatingSystem; // r13
			  struct HGRenderPipelineSettingHub_HGRenderPipelineSettings__Class *v16; // rax
			  String *v17; // r14
			  String *cpuName; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  String *GraphicsDeviceName; // [rsp+30h] [rbp-38h]
			  String *GraphicsDeviceVersion; // [rsp+38h] [rbp-30h]
			  String *GraphicsDeviceVendor; // [rsp+88h] [rbp+20h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(608, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(608, 0LL);
			    if ( Patch )
			      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
			               (ILFixDynamicMethodWrapper_17 *)Patch,
			               (Object *)this,
			               (Object *)constrainString,
			               0LL);
			LABEL_35:
			    sub_1800D8260(p_s_cachedGraphicsDeviceType, MULTI_PATTERN_STR);
			  }
			  v6 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
			  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			    v6 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
			  }
			  MULTI_PATTERN_STR = v6->static_fields->MULTI_PATTERN_STR;
			  if ( !constrainString )
			    goto LABEL_35;
			  if ( !MULTI_PATTERN_STR )
			    MULTI_PATTERN_STR = TypeInfo::System::String->static_fields->Empty;
			  v8 = 0;
			  v9 = System::String::SplitInternal(
			         constrainString,
			         MULTI_PATTERN_STR,
			         0LL,
			         0x7FFFFFFF,
			         StringSplitOptions__Enum_None,
			         0LL);
			  v10 = 0;
			  if ( !v9 )
			    goto LABEL_35;
			  while ( v10 < v9->max_length.size )
			  {
			    if ( (unsigned int)v10 >= v9->max_length.size )
			      sub_1800D2AB0(p_s_cachedGraphicsDeviceType, MULTI_PATTERN_STR);
			    v11 = v9->vector[v10];
			    if ( !v11 )
			      goto LABEL_35;
			    if ( !System::String::Equals(v9->vector[v10], (String *)"", 0LL) )
			    {
			      DeviceModel = UnityEngine::SystemInfo::GetDeviceModel(0LL);
			      DeviceName = UnityEngine::SystemInfo::GetDeviceName(0LL);
			      OperatingSystem = UnityEngine::SystemInfo::GetOperatingSystem(0LL);
			      GraphicsDeviceVendor = UnityEngine::SystemInfo::GetGraphicsDeviceVendor(0LL);
			      GraphicsDeviceName = UnityEngine::SystemInfo::GetGraphicsDeviceName(0LL);
			      GraphicsDeviceVersion = UnityEngine::SystemInfo::GetGraphicsDeviceVersion(0LL);
			      v16 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings;
			      if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings->static_fields->s_cachedGraphicsDeviceType )
			      {
			        HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::EnsureCachedGraphicsDeviceType(0LL);
			        v16 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings;
			      }
			      p_s_cachedGraphicsDeviceType = &v16->static_fields->s_cachedGraphicsDeviceType;
			      v17 = *p_s_cachedGraphicsDeviceType;
			      if ( !DeviceModel )
			        goto LABEL_35;
			      if ( System::String::Contains(DeviceModel, v11, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) )
			        goto LABEL_34;
			      if ( !DeviceName )
			        goto LABEL_35;
			      if ( System::String::Contains(DeviceName, v11, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) )
			        goto LABEL_34;
			      if ( !OperatingSystem )
			        goto LABEL_35;
			      if ( System::String::Contains(OperatingSystem, v11, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) )
			        goto LABEL_34;
			      if ( !GraphicsDeviceVendor )
			        goto LABEL_35;
			      if ( System::String::Contains(GraphicsDeviceVendor, v11, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) )
			        goto LABEL_34;
			      if ( !GraphicsDeviceName )
			        goto LABEL_35;
			      if ( System::String::Contains(GraphicsDeviceName, v11, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) )
			        goto LABEL_34;
			      if ( !GraphicsDeviceVersion )
			        goto LABEL_35;
			      if ( System::String::Contains(GraphicsDeviceVersion, v11, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) )
			        goto LABEL_34;
			      if ( !v17 )
			        goto LABEL_35;
			      if ( System::String::Contains(v17, v11, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) )
			        goto LABEL_34;
			      if ( !TypeInfo::Beyond::DeviceInfo->_1.cctor_finished_or_no_cctor )
			        il2cpp_runtime_class_init_1(TypeInfo::Beyond::DeviceInfo);
			      cpuName = Beyond::DeviceInfo::get_cpuName(0LL);
			      if ( !cpuName )
			        goto LABEL_35;
			      if ( System::String::Contains(cpuName, v11, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) )
			LABEL_34:
			        ++v8;
			    }
			    ++v10;
			  }
			  return v8;
			}
			
			public void Initialize(HGDeviceType overrideDeviceType = HGDeviceType.Unknown /* Metadata: 0x02303F1A */) {} // 0x0000000184640A90-0x0000000184640B20
			public void FeedSettingData(Dictionary<string, string> newSettingData) {} // 0x0000000183689B50-0x0000000183689BF0
			// Void FeedSettingData(Dictionary`2[System.String,System.String])
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FeedSettingData(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        Dictionary_2_System_String_System_String_ *newSettingData,
			        MethodInfo *method)
			{
			  HGRenderPathBase_HGRenderPathResources *v5; // rdx
			  PassConstructorID__Enum__Array *v6; // r8
			  Int32__Array **v7; // r9
			  HGRenderPathBase_HGRenderPathResources *v8; // rdx
			  PassConstructorID__Enum__Array *v9; // r8
			  Int32__Array **v10; // r9
			  __int64 v11; // rax
			  __int64 v12; // rdx
			  __int64 v13; // rcx
			  Exception *v14; // rbx
			  String *v15; // rax
			  __int64 v16; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v18; // rdx
			  __int64 v19; // rcx
			  MethodInfo *v20; // [rsp+20h] [rbp-18h]
			  MethodInfo *v21; // [rsp+20h] [rbp-18h]
			  MethodInfo *v22; // [rsp+28h] [rbp-10h]
			  MethodInfo *v23; // [rsp+28h] [rbp-10h]
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3833, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3833, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v19, v18);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			      (ILFixDynamicMethodWrapper_39 *)Patch,
			      (Object *)this,
			      (Object *)newSettingData,
			      0LL);
			  }
			  else
			  {
			    if ( !newSettingData )
			    {
			      v11 = sub_180035ED0(&TypeInfo::System::Exception);
			      v14 = (Exception *)sub_1800368D0(v11);
			      if ( !v14 )
			        sub_1800D8260(v13, v12);
			      v15 = (String *)sub_180035ED0(&off_18E27B980);
			      System::Exception::Exception(v14, v15, 0LL);
			      v16 = sub_180035ED0(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FeedSettingData);
			      sub_18007E190(v14, v16);
			    }
			    if ( newSettingData->fields._count != newSettingData->fields._freeCount )
			    {
			      this->fields.m_settingData = newSettingData;
			      sub_18002D1B0((HGRenderPathScene *)&this->fields.m_settingData, v5, v6, v7, v20, v22);
			      this->fields.m_settingTable = HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PopulateSettingTable(
			                                      this,
			                                      newSettingData,
			                                      (String *)"",
			                                      0LL);
			      sub_18002D1B0((HGRenderPathScene *)&this->fields.m_settingTable, v8, v9, v10, v21, v23);
			      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FlattenParameters(
			        this,
			        this->fields.m_settingTable,
			        0LL);
			      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshAllSettings(this, 0LL);
			    }
			  }
			}
			
			private BaseSettingTable PopulateSettingTable(Dictionary<string, string> settingData, string relativePath) => default; // 0x0000000183689BF0-0x0000000183689D40
			// HGRenderPipelineSettingHub+HGRenderPipelineSettings+BaseSettingTable PopulateSettingTable(Dictionary`2[System.String,System.String], String)
			HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PopulateSettingTable(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        Dictionary_2_System_String_System_String_ *settingData,
			        String *relativePath,
			        MethodInfo *method)
			{
			  IniDataParser *v7; // rax
			  HGRenderPathBase_HGRenderPathResources *v8; // rdx
			  IniScheme *ARRAY_CONCATENATE_STR; // rcx
			  IniDataParser *v10; // rbx
			  PassConstructorID__Enum__Array *v11; // r8
			  Int32__Array **v12; // r9
			  struct HGRenderPipelineSettingHub_ConstantStrings__Class *v13; // rax
			  IniParserConfiguration *Configuration_k__BackingField; // rdi
			  IniParserConfiguration *v15; // r9
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *v16; // rax
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *v17; // rdi
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  MethodInfo *relativePatha; // [rsp+20h] [rbp-38h]
			  MethodInfo *settingPath; // [rsp+28h] [rbp-30h]
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3834, 0LL) )
			  {
			    v7 = (IniDataParser *)sub_1800368D0(TypeInfo::IniParser::IniDataParser);
			    v10 = v7;
			    if ( v7 )
			    {
			      IniParser::IniDataParser::IniDataParser(v7, 0LL);
			      v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
			      Configuration_k__BackingField = v10->fields._Configuration_k__BackingField;
			      if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->_1.cctor_finished_or_no_cctor )
			      {
			        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			        v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
			      }
			      ARRAY_CONCATENATE_STR = (IniScheme *)v13->static_fields->ARRAY_CONCATENATE_STR;
			      if ( Configuration_k__BackingField )
			      {
			        Configuration_k__BackingField->fields._ConcatenateDuplicatePropertiesString_k__BackingField = (String *)ARRAY_CONCATENATE_STR;
			        sub_18002D1B0(
			          (HGRenderPathScene *)&Configuration_k__BackingField->fields._ConcatenateDuplicatePropertiesString_k__BackingField,
			          v8,
			          v11,
			          v12,
			          relativePatha,
			          settingPath);
			        v15 = v10->fields._Configuration_k__BackingField;
			        if ( v15 )
			        {
			          v15->fields._DuplicatePropertiesBehaviour_k__BackingField = 3;
			          ARRAY_CONCATENATE_STR = v10->fields._Scheme_k__BackingField;
			          if ( ARRAY_CONCATENATE_STR )
			          {
			            IniParser::Configuration::IniScheme::set_CommentString(ARRAY_CONCATENATE_STR, (String *)"#", 0LL);
			            v16 = (HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable);
			            v17 = v16;
			            if ( v16 )
			            {
			              HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::BaseSettingTable(
			                v16,
			                0LL);
			              HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::PopulateSettingTable(
			                v17,
			                v10,
			                0LL,
			                (HGDeviceType__Enum)this->fields._currentDeviceType_k__BackingField,
			                relativePath,
			                TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->static_fields->SETTING_ENTRY_FILE,
			                settingData,
			                this,
			                0LL);
			              return v17;
			            }
			          }
			        }
			      }
			    }
			LABEL_3:
			    sub_1800D8260(ARRAY_CONCATENATE_STR, v8);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3834, 0LL);
			  if ( !Patch )
			    goto LABEL_3;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1361(
			           Patch,
			           (Object *)this,
			           (Object *)settingData,
			           (Object *)relativePath,
			           0LL);
			}
			
			private void PopulateDeviceInfo(HGDeviceType overrideDeviceType = HGDeviceType.Unknown /* Metadata: 0x02303F1B */) {} // 0x0000000184640B20-0x0000000184640B70
			// Void PopulateDeviceInfo(HGDeviceType)
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PopulateDeviceInfo(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        HGDeviceType__Enum overrideDeviceType,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3831, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3831, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
			      (ILFixDynamicMethodWrapper_29 *)Patch,
			      (Object *)this,
			      overrideDeviceType,
			      0LL);
			  }
			  else if ( overrideDeviceType )
			  {
			    this->fields._currentDeviceType_k__BackingField = overrideDeviceType;
			  }
			  else
			  {
			    this->fields._currentDeviceType_k__BackingField = UnityEngine::SystemInfo::GetDeviceType(0LL);
			  }
			}
			
			[Obsolete]
			private void PopulateDeviceTier(BaseSettingTable settingTable) {} // 0x0000000189C141D8-0x0000000189C145E0
			// Void PopulateDeviceTier(HGRenderPipelineSettingHub+HGRenderPipelineSettings+BaseSettingTable)
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PopulateDeviceTier(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *settingTable,
			        MethodInfo *method)
			{
			  Func_2_Object_Object_ *v5; // rax
			  HGRenderPipelineSettingHub_ConstantStrings__StaticFields *static_fields; // rdx
			  IniData *iniData; // rcx
			  Func_2_Object_Object_ *v8; // r14
			  Func_2_Object_Object_ *v9; // rax
			  Func_2_Object_Object_ *v10; // rsi
			  SectionCollection *Sections_k__BackingField; // rdi
			  Section *v12; // rax
			  Section *v13; // r15
			  __int64 v14; // rax
			  __int64 v15; // rdx
			  __int64 v16; // rcx
			  IList_1_System_Int32_ *v17; // rdi
			  int32_t currentDeviceType_k__BackingField; // ecx
			  String *v19; // rax
			  String *v20; // rax
			  String *v21; // rax
			  String *v22; // rax
			  String *v23; // rax
			  String *v24; // rax
			  String *v25; // rdi
			  HGRenderPipelineSettingHub_ConstantStrings__StaticFields *v26; // rcx
			  String *INVALID_STR; // rdx
			  String__Array *v28; // rax
			  __int64 v29; // rdx
			  __int64 v30; // rcx
			  String *v31; // rdi
			  String *v32; // rax
			  String *v33; // rax
			  String *GraphicsDeviceName; // rdi
			  String *v35; // rax
			  String *v36; // rax
			  Il2CppException *v37; // rdi
			  String *v38; // rbx
			  String *v39; // rax
			  String *v40; // rax
			  __int64 v41; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  Il2CppExceptionWrapper *v43; // rdi
			  Il2CppClass *klass; // rbx
			  __int64 v45; // rax
			  Il2CppExceptionWrapper v46; // [rsp+30h] [rbp-48h] BYREF
			  Il2CppExceptionWrapper *v47; // [rsp+38h] [rbp-40h] BYREF
			  Enum v48; // [rsp+40h] [rbp-38h] BYREF
			  int32_t v49; // [rsp+50h] [rbp-28h]
			  Il2CppException *ex; // [rsp+98h] [rbp+20h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3882, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3882, 0LL);
			    if ( !Patch )
			      goto LABEL_27;
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			      (ILFixDynamicMethodWrapper_39 *)Patch,
			      (Object *)this,
			      (Object *)settingTable,
			      0LL);
			  }
			  else
			  {
			    v5 = (Func_2_Object_Object_ *)sub_18002C620(TypeInfo::System::Func<IniParser::Model::Section,System::String>);
			    v8 = v5;
			    if ( !v5 )
			      goto LABEL_27;
			    System::Func<System::Object,System::Object>::Func(
			      v5,
			      (Object *)this,
			      MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::_PopulateDeviceTier_b__42_0,
			      0LL);
			    v9 = (Func_2_Object_Object_ *)sub_18002C620(TypeInfo::System::Func<IniParser::Model::Section,System::Collections::Generic::List<int>>);
			    v10 = v9;
			    if ( !v9 )
			      goto LABEL_27;
			    System::Func<System::Object,System::Object>::Func(
			      v9,
			      (Object *)this,
			      MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::_PopulateDeviceTier_b__42_1,
			      0LL);
			    if ( !settingTable )
			      goto LABEL_27;
			    iniData = settingTable->fields.iniData;
			    if ( !iniData )
			      goto LABEL_27;
			    Sections_k__BackingField = iniData->fields._Sections_k__BackingField;
			    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			    static_fields = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->static_fields;
			    if ( !Sections_k__BackingField )
			      goto LABEL_27;
			    v12 = IniParser::Model::SectionCollection::FindByName(
			            Sections_k__BackingField,
			            static_fields->DEVICE_TIER_SETTING_STR,
			            0LL);
			    v13 = v12;
			    if ( v12 )
			    {
			      try
			      {
			        v14 = sub_1835D0260(v10, v12, 0LL);
			        v17 = (IList_1_System_Int32_ *)v14;
			        if ( !v14 )
			          sub_1800D8260(v16, v15);
			        if ( *(int *)(v14 + 24) > 0 )
			        {
			          this->fields.maximumDeviceTier = Beyond::LinqExtensions::First<int>(
			                                             (IList_1_System_Int32_ *)v14,
			                                             MethodInfo::Beyond::LinqExtensions::First<int>);
			          this->fields.minimumDeviceTier = Beyond::LinqExtensions::Last<int>(
			                                             v17,
			                                             MethodInfo::Beyond::LinqExtensions::Last<int>);
			          currentDeviceType_k__BackingField = this->fields._currentDeviceType_k__BackingField;
			          v48.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::HGDeviceType;
			          v48.monitor = (MonitorData *)-1LL;
			          v49 = currentDeviceType_k__BackingField;
			          v19 = System::Enum::ToString(&v48, 0LL);
			          v20 = System::String::Concat((String *)"Device Type:", v19, 0LL);
			          HG::Rendering::HGRPLogger::LogImportant(v20, 0LL);
			          v21 = System::Int32::ToString((Int32 *)&this->fields.maximumDeviceTier, 0LL);
			          v22 = System::String::Concat((String *)"Maximum Device Tier:", v21, 0LL);
			          HG::Rendering::HGRPLogger::LogImportant(v22, 0LL);
			          v23 = System::Int32::ToString((Int32 *)&this->fields.minimumDeviceTier, 0LL);
			          v24 = System::String::Concat((String *)"Minimum Device Tier:", v23, 0LL);
			          HG::Rendering::HGRPLogger::LogImportant(v24, 0LL);
			        }
			      }
			      catch ( Il2CppExceptionWrapper *v47 )
			      {
			        v43 = v47;
			        klass = v47->ex->object.klass;
			        v45 = sub_18007E180(&TypeInfo::System::Exception);
			        if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v45, klass) )
			        {
			          v46.ex = v43->ex;
			          throw &v46;
			        }
			        ex = v43->ex;
			        v37 = ex;
			        if ( ex )
			        {
			          v38 = (String *)sub_180032CB0(5LL, ex);
			          v39 = (String *)sub_18007E180(&off_18E27B868);
			          v40 = System::String::Concat(v39, v38, 0LL);
			          HG::Rendering::HGRPLogger::LogCritical(v40, 0LL);
			          this->fields._currentDeviceTier_k__BackingField = this->fields.minimumDeviceTier;
			          v41 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PopulateDeviceTier);
			          sub_18007E190(v37, v41);
			        }
			LABEL_27:
			        sub_1800D8260(iniData, static_fields);
			      }
			      if ( this->fields._currentDeviceTier_k__BackingField == -1 )
			      {
			        v25 = (String *)sub_1835D0260(v8, v13, 0LL);
			        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			        v26 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->static_fields;
			        INVALID_STR = v26->INVALID_STR;
			        if ( !v25 )
			          sub_1800D8260(v26, INVALID_STR);
			        if ( System::String::Equals(v25, INVALID_STR, 0LL) )
			        {
			          GraphicsDeviceName = UnityEngine::SystemInfo::GetGraphicsDeviceName(0LL);
			          v35 = System::Int32::ToString((Int32 *)&this->fields.minimumDeviceTier, 0LL);
			          v36 = System::String::Concat(
			                  GraphicsDeviceName,
			                  (String *)" doesn't exit in our table, use lowest tier setting:",
			                  v35,
			                  (String *)" instead",
			                  0LL);
			          HG::Rendering::HGRPLogger::LogCritical(v36, 0LL);
			          this->fields._currentDeviceTier_k__BackingField = this->fields.minimumDeviceTier;
			        }
			        else
			        {
			          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			          v28 = System::String::Split(
			                  v25,
			                  TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->static_fields->SUBLEVEL_STR,
			                  StringSplitOptions__Enum_None,
			                  0LL);
			          if ( !v28 )
			            sub_1800D8260(v30, v29);
			          if ( v28->max_length.size <= 1u )
			            sub_1800D2AB0(v30, v29);
			          this->fields._currentDeviceTier_k__BackingField = System::Int32::Parse(v28->vector[1], 0LL);
			          v31 = UnityEngine::SystemInfo::GetGraphicsDeviceName(0LL);
			          LODWORD(ex) = this->fields._currentDeviceTier_k__BackingField;
			          v32 = System::Int32::ToString((Int32 *)&ex, 0LL);
			          v33 = System::String::Concat(v31, (String *)" matches tier setting:", v32, 0LL);
			          HG::Rendering::HGRPLogger::LogImportant(v33, 0LL);
			        }
			      }
			    }
			    else
			    {
			      this->fields._currentDeviceTier_k__BackingField = 0;
			    }
			  }
			}
			
			public string PrintTierInfo() => default; // 0x0000000189C145E0-0x0000000189C14950
			// String PrintTierInfo()
			// Hidden C++ exception states: #wind=3 #try_helpers=2
			String *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PrintTierInfo(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rcx
			  Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *m_registeredParameters; // rdx
			  KeyValuePair_2_System_Object_System_Object_ current; // xmm6
			  __int64 v6; // rcx
			  List_1_System_UInt64_ *v7; // rdx
			  Object *v8; // rbx
			  __int64 v9; // rdx
			  __int64 v10; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v12; // rdx
			  __int64 v13; // rcx
			  Utf16ValueStringBuilder v15; // [rsp+20h] [rbp-D8h] BYREF
			  _QWORD v16[2]; // [rsp+30h] [rbp-C8h] BYREF
			  Utf16ValueStringBuilder v17; // [rsp+40h] [rbp-B8h] BYREF
			  List_1_T_Enumerator_System_Object_ v18; // [rsp+50h] [rbp-A8h] BYREF
			  Il2CppException *ex; // [rsp+68h] [rbp-90h]
			  List_1_T_Enumerator_System_Object_ *v20; // [rsp+70h] [rbp-88h]
			  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v21; // [rsp+78h] [rbp-80h] BYREF
			  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v22; // [rsp+A0h] [rbp-58h] BYREF
			  Il2CppExceptionWrapper *v23; // [rsp+C8h] [rbp-30h] BYREF
			  String *v24; // [rsp+110h] [rbp+18h]
			
			  v15 = 0LL;
			  memset(&v21, 0, sizeof(v21));
			  memset(&v18, 0, sizeof(v18));
			  if ( IFix::WrappersManagerImpl::IsPatched(3870, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3870, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v13, v12);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			    v15 = *Beyond::StringUtils::CreateZStringBuilder(&v17, 0LL);
			    v16[0] = 0LL;
			    v16[1] = &v15;
			    m_registeredParameters = this->fields.m_registeredParameters;
			    if ( !m_registeredParameters )
			      sub_1800D8250(v3, 0LL);
			    System::Collections::Generic::Dictionary<unsigned long,System::Object>::GetEnumerator(
			      (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_System_Object_ *)&v22,
			      (Dictionary_2_System_UInt64_System_Object_ *)m_registeredParameters,
			      MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::GetEnumerator);
			    v21 = v22;
			    v17.buffer = 0LL;
			    *(_QWORD *)&v17.index = &v21;
			    while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
			              &v21,
			              MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::MoveNext) )
			    {
			      current = v21._current;
			      sub_1800036A0(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
			      Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<System::Object>(
			        &v15,
			        (String *)"{0}===================\n",
			        current.key,
			        MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<System::String>);
			      v7 = (List_1_System_UInt64_ *)_mm_srli_si128((__m128i)current, 8).m128i_u64[0];
			      if ( !v7 )
			        sub_1800D8250(v6, 0LL);
			      System::Collections::Generic::List<unsigned long>::GetEnumerator(
			        (List_1_T_Enumerator_System_UInt64_ *)&v22,
			        v7,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
			      *(_OWORD *)&v18._list = *(_OWORD *)&v22._dictionary;
			      v18._current = v22._current.key;
			      ex = 0LL;
			      v20 = &v18;
			      try
			      {
			        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                  &v18,
			                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext) )
			        {
			          v8 = v18._current;
			          sub_1800036A0(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
			          sub_182F278A0(&v15);
			          sub_182F278A0(&v15);
			          if ( !v8 )
			            sub_1800D8250(v10, v9);
			          sub_180032CB0(3LL, v8);
			          sub_182FFAD20(&v15);
			          sub_182F278A0(&v15);
			        }
			      }
			      catch ( Il2CppExceptionWrapper *v23 )
			      {
			        ex = v23->ex;
			        if ( ex )
			          sub_18007E1E0(ex);
			      }
			      sub_1800036A0(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
			      sub_182F278A0(&v15);
			    }
			    sub_1800036A0(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
			    v24 = Cysharp::Text::Utf16ValueStringBuilder::ToString(&v15, 0LL);
			    sub_1801F6A60(v16);
			    return v24;
			  }
			}
			
			private void RefreshFeatureParameters(string feature) {} // 0x000000018383CDA0-0x000000018383CFF0
			// Void RefreshFeatureParameters(String)
			// Hidden C++ exception states: #wind=1
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshFeatureParameters(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        String *feature,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			  Object *Item; // rax
			  __int64 v10; // rdx
			  __int64 v11; // rcx
			  __int64 v12; // r8
			  Object *current; // rbx
			  struct ILFixDynamicMethodWrapper_2__Class *v14; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			  ILFixDynamicMethodWrapper_2__Array *v16; // rcx
			  ILFixDynamicMethodWrapper_20 *v17; // rcx
			  bool m_useDefaultSettings; // al
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v20; // rdx
			  __int64 v21; // rcx
			  Il2CppExceptionWrapper *v22; // [rsp+20h] [rbp-48h] BYREF
			  List_1_T_Enumerator_System_Object_ v23; // [rsp+28h] [rbp-40h] BYREF
			  List_1_T_Enumerator_System_Object_ v24; // [rsp+40h] [rbp-28h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(594, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(594, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v21, v20);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			      (ILFixDynamicMethodWrapper_39 *)Patch,
			      (Object *)this,
			      (Object *)feature,
			      0LL);
			  }
			  else
			  {
			    if ( !this->fields.m_registeredParameters )
			      sub_1800D8260(v6, v5);
			    if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			           (Dictionary_2_System_Object_System_Object_ *)this->fields.m_registeredParameters,
			           (Object *)feature,
			           MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::ContainsKey) )
			    {
			      if ( !this->fields.m_registeredParameters )
			        sub_1800D8260(v8, v7);
			      Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			               (Dictionary_2_System_Object_System_Object_ *)this->fields.m_registeredParameters,
			               (Object *)feature,
			               MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Item);
			      if ( !Item )
			        sub_1800D8260(v11, v10);
			      System::Collections::Generic::List<unsigned long>::GetEnumerator(
			        (List_1_T_Enumerator_System_UInt64_ *)&v23,
			        (List_1_System_UInt64_ *)Item,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
			      v24 = v23;
			      v23._list = 0LL;
			      *(_QWORD *)&v23._index = &v24;
			      try
			      {
			        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                  &v24,
			                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext) )
			        {
			          current = v24._current;
			          v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			          if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			          {
			            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			            v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			          }
			          wrapperArray = v14->static_fields->wrapperArray;
			          if ( !wrapperArray )
			            sub_1800D8250(v14, 0LL);
			          if ( wrapperArray->max_length.size <= 595 )
			            goto LABEL_23;
			          if ( !v14->_1.cctor_finished_or_no_cctor )
			          {
			            il2cpp_runtime_class_init_1(v14);
			            v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			          }
			          wrapperArray = v14->static_fields->wrapperArray;
			          if ( !wrapperArray )
			            sub_1800D8250(v14, 0LL);
			          if ( wrapperArray->max_length.size <= 0x253u )
			            sub_1800D2AA0(v14, wrapperArray, v12);
			          if ( wrapperArray[16].vector[19] )
			          {
			            if ( !v14->_1.cctor_finished_or_no_cctor )
			            {
			              il2cpp_runtime_class_init_1(v14);
			              v14 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			            }
			            v16 = v14->static_fields->wrapperArray;
			            if ( !v16 )
			              sub_1800D8250(0LL, wrapperArray);
			            if ( v16->max_length.size <= 0x253u )
			              sub_1800D2AA0(v16, wrapperArray, v12);
			            v17 = (ILFixDynamicMethodWrapper_20 *)v16[16].vector[19];
			            if ( !v17 )
			              sub_1800D8250(0LL, wrapperArray);
			            m_useDefaultSettings = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(v17, (Object *)this, 0LL);
			          }
			          else
			          {
			LABEL_23:
			            m_useDefaultSettings = this->fields.m_useDefaultSettings;
			          }
			          if ( !current )
			            sub_1800D8250(v14, wrapperArray);
			          HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::Refresh(
			            (HGRenderPipelineSettingHub_SettingParameterBase *)current,
			            m_useDefaultSettings,
			            0LL);
			        }
			      }
			      catch ( Il2CppExceptionWrapper *v22 )
			      {
			        v23._list = (List_1_System_Object_ *)v22->ex;
			        if ( v23._list )
			          sub_18007E1E0(v23._list);
			      }
			    }
			  }
			}
			
			private void RefreshSettingsInTable(BaseSettingTable settingTable) {} // 0x000000018368AED0-0x000000018368B300
			// Void RefreshSettingsInTable(HGRenderPipelineSettingHub+HGRenderPipelineSettings+BaseSettingTable)
			// Hidden C++ exception states: #wind=2 #try_helpers=1
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshSettingsInTable(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *settingTable,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  IniData *iniData; // rbx
			  SectionCollection *Sections_k__BackingField; // rbx
			  __int64 v9; // rdx
			  __int64 v10; // rcx
			  struct IEnumerator__Class *v11; // rsi
			  IEnumerator_1_IniParser_Model_Section___Class *klass; // r14
			  unsigned __int16 v13; // cx
			  unsigned __int16 v14; // dx
			  Il2CppRuntimeInterfaceOffsetPair *interfaceOffsets; // r8
			  __int64 v16; // rdx
			  struct IEnumerator_1_IniParser_Model_Section___Class *v17; // rsi
			  IEnumerator_1_IniParser_Model_Section___Class *v18; // r14
			  unsigned __int16 v19; // cx
			  unsigned __int16 v20; // dx
			  Il2CppRuntimeInterfaceOffsetPair *v21; // r8
			  __int64 v22; // rdx
			  __int64 v23; // rax
			  __int64 v24; // rdx
			  __int64 v25; // rcx
			  String *v26; // rdi
			  struct HGRenderPipelineSettingHub_ConstantStrings__Class *v27; // rax
			  String *SUBLEVEL_STR; // rdx
			  String__Array *v29; // rax
			  __int64 v30; // rdx
			  __int64 v31; // r8
			  HashSet_1_System_String_ *m_dirtyFeatureSettings; // rcx
			  List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable_ *includeList; // r9
			  __int64 *v34; // rdx
			  __int64 v35; // rtt
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v37; // rdx
			  __int64 v38; // rcx
			  Il2CppException *ex; // [rsp+38h] [rbp-80h]
			  Il2CppExceptionWrapper *v40; // [rsp+48h] [rbp-70h] BYREF
			  _BYTE v41[24]; // [rsp+50h] [rbp-68h] BYREF
			  List_1_T_Enumerator_System_Object_ v42; // [rsp+68h] [rbp-50h] BYREF
			  IEnumerator_1_IniParser_Model_Section_ *Enumerator; // [rsp+D8h] [rbp+20h]
			
			  memset(&v42, 0, sizeof(v42));
			  if ( IFix::WrappersManagerImpl::IsPatched(3854, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3854, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v38, v37);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			      (ILFixDynamicMethodWrapper_39 *)Patch,
			      (Object *)this,
			      (Object *)settingTable,
			      0LL);
			  }
			  else
			  {
			    if ( !settingTable )
			      sub_1800D8260(v6, v5);
			    iniData = settingTable->fields.iniData;
			    if ( !iniData )
			      sub_1800D8260(v6, v5);
			    if ( iniData->fields._Sections_k__BackingField )
			    {
			      Sections_k__BackingField = iniData->fields._Sections_k__BackingField;
			      if ( !Sections_k__BackingField )
			        sub_1800D8260(v6, v5);
			      Enumerator = IniParser::Model::SectionCollection::GetEnumerator(Sections_k__BackingField, 0LL);
			      while ( 1 )
			      {
			        if ( !Enumerator )
			          sub_1800D8250(v10, v9);
			        v11 = TypeInfo::System::Collections::IEnumerator;
			        klass = Enumerator->klass;
			        sub_1800049A0(Enumerator->klass);
			        v13 = 0;
			        v14 = *(_WORD *)&klass->_1.naturalAligment;
			        if ( v14 )
			        {
			          interfaceOffsets = klass->interfaceOffsets;
			          while ( (struct IEnumerator__Class *)interfaceOffsets[v13].interfaceType != v11 )
			          {
			            if ( ++v13 >= v14 )
			              goto LABEL_12;
			          }
			          v16 = (__int64)(&klass->vtable.get_Current.method + 2 * interfaceOffsets[v13].offset);
			        }
			        else
			        {
			LABEL_12:
			          v16 = sub_1800219C0(Enumerator, v11, 0LL);
			        }
			        if ( !(*(unsigned __int8 (__fastcall **)(IEnumerator_1_IniParser_Model_Section_ *, _QWORD))v16)(
			                Enumerator,
			                *(_QWORD *)(v16 + 8)) )
			          break;
			        if ( !Enumerator )
			          sub_1800D8250(v6, v5);
			        v17 = TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Section>;
			        v18 = Enumerator->klass;
			        sub_1800049A0(Enumerator->klass);
			        v19 = 0;
			        v20 = *(_WORD *)&v18->_1.naturalAligment;
			        if ( v20 )
			        {
			          v21 = v18->interfaceOffsets;
			          while ( (struct IEnumerator_1_IniParser_Model_Section___Class *)v21[v19].interfaceType != v17 )
			          {
			            if ( ++v19 >= v20 )
			              goto LABEL_19;
			          }
			          v22 = (__int64)(&v18->vtable.get_Current.method + 2 * v21[v19].offset);
			        }
			        else
			        {
			LABEL_19:
			          v22 = sub_1800219C0(Enumerator, v17, 0LL);
			        }
			        v23 = (*(__int64 (__fastcall **)(IEnumerator_1_IniParser_Model_Section_ *, _QWORD))v22)(
			                Enumerator,
			                *(_QWORD *)(v22 + 8));
			        if ( !v23 )
			          sub_1800D8250(v25, v24);
			        v26 = *(String **)(v23 + 32);
			        v27 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
			        if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->_1.cctor_finished_or_no_cctor )
			        {
			          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			          v27 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
			        }
			        SUBLEVEL_STR = v27->static_fields->SUBLEVEL_STR;
			        if ( !v26 )
			          sub_1800D8250(v25, SUBLEVEL_STR);
			        if ( !SUBLEVEL_STR )
			          SUBLEVEL_STR = TypeInfo::System::String->static_fields->Empty;
			        v29 = System::String::SplitInternal(v26, SUBLEVEL_STR, 0LL, 0x7FFFFFFF, StringSplitOptions__Enum_None, 0LL);
			        m_dirtyFeatureSettings = this->fields.m_dirtyFeatureSettings;
			        if ( !v29 )
			          sub_1800D8250(m_dirtyFeatureSettings, v30);
			        if ( !v29->max_length.size )
			          sub_1800D2AA0(m_dirtyFeatureSettings, v30, v31);
			        if ( !m_dirtyFeatureSettings )
			          sub_1800D8250(0LL, v30);
			        System::Collections::Generic::HashSet<System::Object>::Add(
			          (HashSet_1_System_Object_ *)m_dirtyFeatureSettings,
			          (Object *)v29->vector[0],
			          MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			      }
			      if ( Enumerator )
			        sub_180053A90(0LL, TypeInfo::System::IDisposable);
			    }
			    includeList = settingTable->fields.includeList;
			    if ( !includeList )
			      sub_1800D8250(v6, v5);
			    *(_OWORD *)&v41[8] = 0LL;
			    *(_QWORD *)v41 = includeList;
			    if ( dword_18F35FD08 )
			    {
			      v34 = &qword_18F103690[(((unsigned __int64)v41 >> 12) & 0x1FFFFF) >> 6];
			      _m_prefetchw(v34);
			      do
			        v35 = *v34;
			      while ( v35 != _InterlockedCompareExchange64(v34, *v34 | (1LL << (((unsigned __int64)v41 >> 12) & 0x3F)), *v34) );
			    }
			    *(_DWORD *)&v41[8] = 0;
			    *(_DWORD *)&v41[12] = includeList->fields._version;
			    *(_QWORD *)&v41[16] = 0LL;
			    *(_OWORD *)&v42._list = *(_OWORD *)v41;
			    v42._current = 0LL;
			    try
			    {
			      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                &v42,
			                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::MoveNext) )
			        HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshSettingsInTable(
			          this,
			          (HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *)v42._current,
			          0LL);
			    }
			    catch ( Il2CppExceptionWrapper *v40 )
			    {
			      ex = v40->ex;
			      if ( ex )
			        sub_18007E1E0(ex);
			    }
			  }
			}
			
			public void RefreshAllSettings() {} // 0x0000000183689D40-0x0000000183689D80
			// Void RefreshAllSettings()
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshAllSettings(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3853, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3853, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			    HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshSettingsInTable(
			      this,
			      this->fields.m_settingTable,
			      0LL);
			  }
			}
			
			public void RefreshDirtySettings() {} // 0x0000000183063830-0x0000000183063B90
			// Void RefreshDirtySettings()
			// Hidden C++ exception states: #wind=2
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshDirtySettings(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        MethodInfo *method)
			{
			  PassConstructorID__Enum__Array *v2; // r8
			  Int32__Array **v3; // r9
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v4; // rbx
			  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
			  ILFixDynamicMethodWrapper_2__Array *v7; // rdi
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v9; // rdx
			  __int64 v10; // rcx
			  HashSet_1_System_String_ *m_dirtyFeatureSettings; // rdi
			  _BYTE *v12; // rdx
			  HashSet_1_System_UInt64_ *v13; // rcx
			  HashSet_1_System_String_ *v14; // r9
			  __int64 *v15; // rdx
			  __int64 v16; // rtt
			  Object *current; // rdi
			  Dictionary_2_System_Object_System_Object_ *m_settingChangeCallbacks; // rcx
			  __int64 v19; // rdx
			  unsigned int currentDeviceTier_k__BackingField; // esi
			  Dictionary_2_System_Object_System_Int32_ *m_overrideFeatureSettingTiers; // rcx
			  __int64 v22; // rdx
			  Dictionary_2_System_Object_System_Int32_ *v23; // rcx
			  Dictionary_2_System_Object_System_Object_ *v24; // rcx
			  Object *Item; // rax
			  __int64 v26; // rdx
			  __int64 v27; // rcx
			  _BYTE v28[32]; // [rsp+0h] [rbp-68h] BYREF
			  MethodInfo *v29; // [rsp+20h] [rbp-48h] BYREF
			  MethodInfo *v30; // [rsp+28h] [rbp-40h] BYREF
			  _BYTE v31[24]; // [rsp+30h] [rbp-38h] BYREF
			  HashSet_1_T_Enumerator_System_Object_ v32; // [rsp+48h] [rbp-20h] BYREF
			
			  v4 = this;
			  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v5->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    sub_1800D8260(v5, method);
			  if ( wrapperArray->max_length.size <= 593 )
			    goto LABEL_12;
			  if ( !v5->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v5);
			    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v7 = v5->static_fields->wrapperArray;
			  if ( !v7 )
			    sub_1800D8260(v5, method);
			  if ( v7->max_length.size <= 0x251u )
			    sub_1800D2AB0(v5, method);
			  if ( v7[16].vector[17] )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(593, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v10, v9);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v4, 0LL);
			  }
			  else
			  {
			LABEL_12:
			    m_dirtyFeatureSettings = v4->fields.m_dirtyFeatureSettings;
			    if ( !m_dirtyFeatureSettings )
			      sub_1800D8260(v5, method);
			    *(_OWORD *)&v31[8] = 0LL;
			    *(_QWORD *)v31 = m_dirtyFeatureSettings;
			    sub_18002D1B0((HGRenderPathScene *)v31, (HGRenderPathBase_HGRenderPathResources *)method, v2, v3, v29, v30);
			    *(_DWORD *)&v31[8] = 0;
			    *(_DWORD *)&v31[12] = m_dirtyFeatureSettings->fields._version;
			    *(_QWORD *)&v31[16] = 0LL;
			    *(_OWORD *)&v32._set = *(_OWORD *)v31;
			    v32._current = 0LL;
			    *(_QWORD *)v31 = 0LL;
			    *(_QWORD *)&v31[8] = &v32;
			    try
			    {
			      while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
			                &v32,
			                MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::String>::MoveNext) )
			        HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshFeatureParameters(
			          v4,
			          (String *)v32._current,
			          0LL);
			    }
			    catch ( Il2CppExceptionWrapper *v29 )
			    {
			      v12 = v28;
			      *(_QWORD *)v31 = v29->methodPointer;
			      v13 = *(HashSet_1_System_UInt64_ **)v31;
			      if ( *(_QWORD *)v31 )
			        sub_18007E1E0(*(_QWORD *)v31);
			      v4 = this;
			    }
			    v14 = v4->fields.m_dirtyFeatureSettings;
			    if ( !v14 )
			      goto LABEL_37;
			    *(_OWORD *)&v31[8] = 0LL;
			    *(_QWORD *)v31 = v14;
			    if ( dword_18F35FD08 )
			    {
			      v15 = &qword_18F103690[(((unsigned __int64)v31 >> 12) & 0x1FFFFF) >> 6];
			      _m_prefetchw(v15);
			      do
			        v16 = *v15;
			      while ( v16 != _InterlockedCompareExchange64(v15, *v15 | (1LL << (((unsigned __int64)v31 >> 12) & 0x3F)), *v15) );
			    }
			    *(_DWORD *)&v31[8] = 0;
			    *(_DWORD *)&v31[12] = v14->fields._version;
			    *(_QWORD *)&v31[16] = 0LL;
			    *(_OWORD *)&v32._set = *(_OWORD *)v31;
			    v32._current = 0LL;
			    *(_QWORD *)v31 = 0LL;
			    *(_QWORD *)&v31[8] = &v32;
			    try
			    {
			      while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
			                &v32,
			                MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::String>::MoveNext) )
			      {
			        current = v32._current;
			        m_settingChangeCallbacks = (Dictionary_2_System_Object_System_Object_ *)v4->fields.m_settingChangeCallbacks;
			        if ( !m_settingChangeCallbacks )
			          sub_1800D8250(0LL, v12);
			        if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			               m_settingChangeCallbacks,
			               v32._current,
			               MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>::ContainsKey) )
			        {
			          currentDeviceTier_k__BackingField = v4->fields._currentDeviceTier_k__BackingField;
			          m_overrideFeatureSettingTiers = (Dictionary_2_System_Object_System_Int32_ *)v4->fields.m_overrideFeatureSettingTiers;
			          if ( !m_overrideFeatureSettingTiers )
			            sub_1800D8250(0LL, v19);
			          if ( System::Collections::Generic::Dictionary<System::Object,int>::ContainsKey(
			                 m_overrideFeatureSettingTiers,
			                 current,
			                 MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::ContainsKey) )
			          {
			            v23 = (Dictionary_2_System_Object_System_Int32_ *)v4->fields.m_overrideFeatureSettingTiers;
			            if ( !v23 )
			              sub_1800D8250(0LL, v22);
			            currentDeviceTier_k__BackingField = System::Collections::Generic::Dictionary<System::Object,int>::get_Item(
			                                                  v23,
			                                                  current,
			                                                  MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::get_Item);
			          }
			          v24 = (Dictionary_2_System_Object_System_Object_ *)v4->fields.m_settingChangeCallbacks;
			          if ( !v24 )
			            sub_1800D8250(0LL, v22);
			          Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			                   v24,
			                   current,
			                   MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>::get_Item);
			          if ( !Item )
			            sub_1800D8250(v27, v26);
			          sub_1838B2790(
			            Item,
			            (unsigned int)v4->fields._currentDeviceType_k__BackingField,
			            currentDeviceTier_k__BackingField);
			        }
			      }
			    }
			    catch ( Il2CppExceptionWrapper *v30 )
			    {
			      v12 = v28;
			      *(_QWORD *)v31 = v30->methodPointer;
			      if ( *(_QWORD *)v31 )
			        sub_18007E1E0(*(_QWORD *)v31);
			      v4 = this;
			    }
			    v13 = (HashSet_1_System_UInt64_ *)v4->fields.m_dirtyFeatureSettings;
			    if ( !v13 )
			LABEL_37:
			      sub_1800D8250(v13, v12);
			    System::Collections::Generic::HashSet<unsigned long>::Clear(
			      v13,
			      MethodInfo::System::Collections::Generic::HashSet<System::String>::Clear);
			  }
			}
			
			internal SettingParameterBase RegisterParameter(SettingParameterBase param, string feature) => default; // 0x000000018383AE60-0x000000018383B0E0
			// HGRenderPipelineSettingHub+SettingParameterBase RegisterParameter(HGRenderPipelineSettingHub+SettingParameterBase, String)
			HGRenderPipelineSettingHub_SettingParameterBase *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RegisterParameter(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        HGRenderPipelineSettingHub_SettingParameterBase *param,
			        String *feature,
			        MethodInfo *method)
			{
			  __int64 v7; // rax
			  HGRenderPathBase_HGRenderPathResources *v8; // rdx
			  Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *m_registeredParameters; // rcx
			  PassConstructorID__Enum__Array *v10; // r8
			  Int32__Array **v11; // r9
			  __int64 v12; // rbx
			  Object *Item; // r14
			  Predicate_1_Object_ *v14; // rax
			  Predicate_1_Object_ *v15; // rsi
			  int32_t Index; // esi
			  Object *v17; // rax
			  __int64 v18; // rax
			  String__Array *v19; // rdi
			  __int64 v20; // r8
			  Object *v21; // rdi
			  Object *v23; // rax
			  Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *v24; // r14
			  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v25; // rax
			  Object *v26; // rsi
			  ILFixDynamicMethodWrapper_39 *Patch; // rax
			  ILFixDynamicMethodWrapper_2 *v28; // rax
			  MethodInfo *methoda; // [rsp+20h] [rbp-18h]
			  MethodInfo *v30; // [rsp+28h] [rbp-10h]
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3885, 0LL) )
			  {
			    v7 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c__DisplayClass48_0);
			    v12 = v7;
			    if ( v7 )
			    {
			      *(_QWORD *)(v7 + 16) = param;
			      sub_18002D1B0((HGRenderPathScene *)(v7 + 16), v8, v10, v11, methoda, v30);
			      m_registeredParameters = this->fields.m_registeredParameters;
			      if ( m_registeredParameters )
			      {
			        if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
			                (Dictionary_2_System_Object_System_Object_ *)m_registeredParameters,
			                (Object *)feature,
			                MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::ContainsKey) )
			        {
			          v24 = this->fields.m_registeredParameters;
			          v25 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>);
			          v26 = (Object *)v25;
			          if ( !v25 )
			            goto LABEL_21;
			          System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
			            v25,
			            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::List);
			          if ( !v24 )
			            goto LABEL_21;
			          System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
			            (Dictionary_2_System_Object_System_Object_ *)v24,
			            (Object *)feature,
			            v26,
			            MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::set_Item);
			        }
			        m_registeredParameters = this->fields.m_registeredParameters;
			        if ( m_registeredParameters )
			        {
			          Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			                   (Dictionary_2_System_Object_System_Object_ *)m_registeredParameters,
			                   (Object *)feature,
			                   MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Item);
			          v14 = (Predicate_1_Object_ *)sub_1800368D0(TypeInfo::System::Predicate<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>);
			          v15 = v14;
			          if ( v14 )
			          {
			            System::Predicate<System::Object>::Predicate(
			              v14,
			              (Object *)v12,
			              MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c__DisplayClass48_0::_RegisterParameter_b__0,
			              0LL);
			            if ( Item )
			            {
			              Index = System::Collections::Generic::List<System::Object>::FindIndex(
			                        (List_1_System_Object_ *)Item,
			                        v15,
			                        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::FindIndex);
			              if ( Index == -1 )
			              {
			                if ( this->fields.m_registeredParameters )
			                {
			                  v23 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			                          (Dictionary_2_System_Object_System_Object_ *)this->fields.m_registeredParameters,
			                          (Object *)feature,
			                          MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Item);
			                  if ( v23 )
			                  {
			                    sub_182F01190((List_1_System_Object_ *)v23, *(Object **)(v12 + 16));
			                    return *(HGRenderPipelineSettingHub_SettingParameterBase **)(v12 + 16);
			                  }
			                }
			              }
			              else if ( this->fields.m_registeredParameters )
			              {
			                v17 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
			                        (Dictionary_2_System_Object_System_Object_ *)this->fields.m_registeredParameters,
			                        (Object *)feature,
			                        MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Item);
			                if ( v17 )
			                {
			                  System::Collections::Generic::List<System::Object>::set_Item(
			                    (List_1_System_Object_ *)v17,
			                    Index,
			                    *(Object **)(v12 + 16),
			                    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::set_Item);
			                  v18 = il2cpp_array_new_specific_1(TypeInfo::System::String, 5LL);
			                  v19 = (String__Array *)v18;
			                  if ( v18 )
			                  {
			                    sub_180005370(v18, 0LL, "Feature:");
			                    sub_180005370(v19, 1LL, feature);
			                    sub_180005370(v19, 2LL, " param:");
			                    v20 = *(_QWORD *)(v12 + 16);
			                    if ( v20 )
			                    {
			                      sub_180005370(v19, 3LL, *(_QWORD *)(v20 + 24));
			                      sub_180005370(v19, 4LL, " has been registered already, is this intended?");
			                      v21 = (Object *)System::String::Concat(v19, 0LL);
			                      if ( !IFix::WrappersManagerImpl::IsPatched(2, 0LL) )
			                        return *(HGRenderPipelineSettingHub_SettingParameterBase **)(v12 + 16);
			                      Patch = IFix::WrappersManagerImpl::GetPatch(2, 0LL);
			                      if ( Patch )
			                      {
			                        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(Patch, v21, 0LL);
			                        return *(HGRenderPipelineSettingHub_SettingParameterBase **)(v12 + 16);
			                      }
			                    }
			                  }
			                }
			              }
			            }
			          }
			        }
			      }
			    }
			LABEL_21:
			    sub_1800D8260(m_registeredParameters, v8);
			  }
			  v28 = IFix::WrappersManagerImpl::GetPatch(3885, 0LL);
			  if ( !v28 )
			    goto LABEL_21;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1371(v28, (Object *)this, (Object *)param, (Object *)feature, 0LL);
			}
			
			public void RegisterSettingChangeCallback(string featureName, OnSettingChanged callback) {} // 0x0000000183949270-0x00000001839492F0
			// Void RegisterSettingChangeCallback(String, HGRenderPipelineSettingHub+OnSettingChanged)
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RegisterSettingChangeCallback(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        String *featureName,
			        HGRenderPipelineSettingHub_OnSettingChanged *callback,
			        MethodInfo *method)
			{
			  __int64 v7; // rdx
			  Dictionary_2_System_Object_System_Object_ *m_settingChangeCallbacks; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(476, 0LL) )
			  {
			    m_settingChangeCallbacks = (Dictionary_2_System_Object_System_Object_ *)this->fields.m_settingChangeCallbacks;
			    if ( m_settingChangeCallbacks )
			    {
			      System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
			        m_settingChangeCallbacks,
			        (Object *)featureName,
			        (Object *)callback,
			        MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>::set_Item);
			      m_settingChangeCallbacks = (Dictionary_2_System_Object_System_Object_ *)this->fields.m_dirtyFeatureSettings;
			      if ( m_settingChangeCallbacks )
			      {
			        System::Collections::Generic::HashSet<System::Object>::Add(
			          (HashSet_1_System_Object_ *)m_settingChangeCallbacks,
			          (Object *)featureName,
			          MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			        return;
			      }
			    }
			LABEL_5:
			    sub_1800D8260(m_settingChangeCallbacks, v7);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(476, 0LL);
			  if ( !Patch )
			    goto LABEL_5;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			    (ILFixDynamicMethodWrapper_30 *)Patch,
			    (Object *)this,
			    (Object *)featureName,
			    (Object *)callback,
			    0LL);
			}
			
			public bool ResetRegisteredParameter(string paramName) => default; // 0x0000000189C149D8-0x0000000189C14C30
			// Boolean ResetRegisteredParameter(String)
			// Hidden C++ exception states: #wind=2 #try_helpers=2
			bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetRegisteredParameter(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        String *paramName,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  __int64 v7; // rcx
			  __int64 v8; // rdx
			  __int64 v9; // rcx
			  Object *current; // rbx
			  MonitorData *monitor; // rcx
			  __int64 v12; // rdx
			  __int64 v13; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v16; // rdx
			  __int64 v17; // rcx
			  List_1_T_Enumerator_System_Object_ v18; // [rsp+20h] [rbp-A8h] BYREF
			  __int64 v19; // [rsp+38h] [rbp-90h]
			  List_1_T_Enumerator_System_Object_ *v20; // [rsp+40h] [rbp-88h]
			  __int64 v21; // [rsp+48h] [rbp-80h]
			  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *v22; // [rsp+50h] [rbp-78h]
			  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v23; // [rsp+58h] [rbp-70h] BYREF
			  List_1_T_Enumerator_System_UInt64_ v24[2]; // [rsp+90h] [rbp-38h] BYREF
			
			  memset(&v23, 0, sizeof(v23));
			  memset(&v18, 0, sizeof(v18));
			  if ( IFix::WrappersManagerImpl::IsPatched(3879, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3879, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v17, v16);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
			             (ILFixDynamicMethodWrapper_33 *)Patch,
			             (Object *)this,
			             (Object *)paramName,
			             0LL);
			  }
			  else
			  {
			    if ( !this->fields.m_registeredParameters )
			      sub_1800D8260(v6, v5);
			    v23 = *(Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)sub_1808B0CB4(
			                                                                                 v24,
			                                                                                 this->fields.m_registeredParameters);
			    v21 = 0LL;
			    v22 = &v23;
			    while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
			              &v23,
			              MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::MoveNext) )
			    {
			      if ( !v23._current.value )
			        sub_1800D8250(v7, 0LL);
			      System::Collections::Generic::List<unsigned long>::GetEnumerator(
			        v24,
			        (List_1_System_UInt64_ *)v23._current.value,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
			      v18 = (List_1_T_Enumerator_System_Object_)v24[0];
			      v19 = 0LL;
			      v20 = &v18;
			      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                &v18,
			                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext) )
			      {
			        current = v18._current;
			        if ( !v18._current )
			          sub_1800D8250(v9, v8);
			        monitor = v18._current[1].monitor;
			        if ( !monitor )
			          sub_1800D8250(0LL, v8);
			        if ( System::String::Equals((String *)monitor, paramName, StringComparison__Enum_OrdinalIgnoreCase, 0LL) )
			        {
			          if ( !current )
			            sub_1800D8250(v13, v12);
			          HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::Reset(
			            (HGRenderPipelineSettingHub_SettingParameterBase *)current,
			            0LL);
			          return 1;
			        }
			      }
			    }
			    return 0;
			  }
			}
			
			public void ResetRegisteredParameters() {} // 0x0000000189C14C30-0x0000000189C14E30
			// Void ResetRegisteredParameters()
			// Hidden C++ exception states: #wind=2
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetRegisteredParameters(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  __int64 v4; // rcx
			  __int64 v5; // rcx
			  __int64 v6; // rdx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v8; // rdx
			  __int64 v9; // rcx
			  List_1_T_Enumerator_System_Object_ v10; // [rsp+20h] [rbp-A8h] BYREF
			  Il2CppException *ex; // [rsp+38h] [rbp-90h]
			  List_1_T_Enumerator_System_Object_ *v12; // [rsp+40h] [rbp-88h]
			  Il2CppException *v13; // [rsp+48h] [rbp-80h]
			  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *v14; // [rsp+50h] [rbp-78h]
			  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v15; // [rsp+58h] [rbp-70h] BYREF
			  Il2CppExceptionWrapper *v16; // [rsp+80h] [rbp-48h] BYREF
			  Il2CppExceptionWrapper *v17; // [rsp+88h] [rbp-40h] BYREF
			  List_1_T_Enumerator_System_UInt64_ v18[2]; // [rsp+90h] [rbp-38h] BYREF
			
			  memset(&v15, 0, sizeof(v15));
			  memset(&v10, 0, sizeof(v10));
			  if ( IFix::WrappersManagerImpl::IsPatched(3856, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3856, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v9, v8);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			    if ( !this->fields.m_registeredParameters )
			      sub_1800D8260(v4, v3);
			    v15 = *(Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)sub_1808B0CB4(
			                                                                                 v18,
			                                                                                 this->fields.m_registeredParameters);
			    v13 = 0LL;
			    v14 = &v15;
			    try
			    {
			      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
			                &v15,
			                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::MoveNext) )
			      {
			        if ( !v15._current.value )
			          sub_1800D8250(v5, 0LL);
			        System::Collections::Generic::List<unsigned long>::GetEnumerator(
			          v18,
			          (List_1_System_UInt64_ *)v15._current.value,
			          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
			        v10 = (List_1_T_Enumerator_System_Object_)v18[0];
			        ex = 0LL;
			        v12 = &v10;
			        try
			        {
			          while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                    &v10,
			                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext) )
			          {
			            if ( !v10._current )
			              sub_1800D8250(0LL, v6);
			            HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::Reset(
			              (HGRenderPipelineSettingHub_SettingParameterBase *)v10._current,
			              0LL);
			          }
			        }
			        catch ( Il2CppExceptionWrapper *v16 )
			        {
			          ex = v16->ex;
			          if ( ex )
			            sub_18007E1E0(ex);
			        }
			      }
			    }
			    catch ( Il2CppExceptionWrapper *v17 )
			    {
			      v13 = v17->ex;
			      if ( v13 )
			        sub_18007E1E0(v13);
			    }
			  }
			}
			
			public bool OverrideSettingParameter(string paramName, string paramValue) => default; // 0x0000000189C13F5C-0x0000000189C141D8
			// Boolean OverrideSettingParameter(String, String)
			// Hidden C++ exception states: #wind=2 #try_helpers=2
			bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::OverrideSettingParameter(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        String *paramName,
			        String *paramValue,
			        MethodInfo *method)
			{
			  Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *registeredParameters; // rax
			  __int64 v8; // rdx
			  __int64 v9; // rcx
			  __int64 v10; // rcx
			  __int64 v11; // rdx
			  __int64 v12; // rcx
			  Object *current; // rbx
			  MonitorData *monitor; // rcx
			  __int64 v15; // rdx
			  __int64 v16; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v19; // rdx
			  __int64 v20; // rcx
			  List_1_T_Enumerator_System_Object_ v21; // [rsp+30h] [rbp-B8h] BYREF
			  __int64 v22; // [rsp+48h] [rbp-A0h]
			  List_1_T_Enumerator_System_Object_ *v23; // [rsp+50h] [rbp-98h]
			  __int64 v24; // [rsp+58h] [rbp-90h]
			  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *v25; // [rsp+60h] [rbp-88h]
			  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v26; // [rsp+68h] [rbp-80h] BYREF
			  List_1_T_Enumerator_System_UInt64_ v27[3]; // [rsp+A0h] [rbp-48h] BYREF
			
			  memset(&v26, 0, sizeof(v26));
			  memset(&v21, 0, sizeof(v21));
			  if ( IFix::WrappersManagerImpl::IsPatched(3876, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3876, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v20, v19);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(
			             (ILFixDynamicMethodWrapper_20 *)Patch,
			             (Object *)this,
			             (Object *)paramName,
			             (Object *)paramValue,
			             0LL);
			  }
			  else
			  {
			    registeredParameters = HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_registeredParameters(
			                             this,
			                             0LL);
			    if ( !registeredParameters )
			      sub_1800D8260(v9, v8);
			    v26 = *(Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)sub_1808B0CB4(v27, registeredParameters);
			    v24 = 0LL;
			    v25 = &v26;
			    while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
			              &v26,
			              MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::MoveNext) )
			    {
			      if ( !v26._current.value )
			        sub_1800D8250(v10, 0LL);
			      System::Collections::Generic::List<unsigned long>::GetEnumerator(
			        v27,
			        (List_1_System_UInt64_ *)v26._current.value,
			        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
			      v21 = (List_1_T_Enumerator_System_Object_)v27[0];
			      v22 = 0LL;
			      v23 = &v21;
			      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                &v21,
			                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext) )
			      {
			        current = v21._current;
			        if ( !v21._current )
			          sub_1800D8250(v12, v11);
			        monitor = v21._current[1].monitor;
			        if ( !monitor )
			          sub_1800D8250(0LL, v11);
			        if ( System::String::Equals((String *)monitor, paramName, StringComparison__Enum_OrdinalIgnoreCase, 0LL) )
			        {
			          if ( !current )
			            sub_1800D8250(v16, v15);
			          return sub_1800BE8D0(5LL, current, paramValue);
			        }
			      }
			    }
			    return 0;
			  }
			}
			
			private static bool SupportDeviceType(HGDeviceType deviceType) => default; // 0x0000000189C14E94-0x0000000189C14EF4
			// Boolean SupportDeviceType(HGDeviceType)
			bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::SupportDeviceType(
			        HGDeviceType__Enum deviceType,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3888, 0LL) )
			    return ((deviceType - 1) & 0xFFFFFFFD) == 0 || deviceType == HGDeviceType__Enum_Cinematic;
			  Patch = IFix::WrappersManagerImpl::GetPatch(3888, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_95(
			           (ILFixDynamicMethodWrapper_17 *)Patch,
			           (AudioLogChannel__Enum)deviceType,
			           0LL);
			}
			
			public void ChangeSettingTier(int tier) {} // 0x0000000183C90D00-0x0000000183C90D50
			// Void ChangeSettingTier(Int32)
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ChangeSettingTier(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        int32_t tier,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3862, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3862, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, tier, 0LL);
			  }
			  else if ( tier <= this->fields.maximumDeviceTier && this->fields._currentDeviceTier_k__BackingField != tier )
			  {
			    this->fields._currentDeviceTier_k__BackingField = tier;
			    HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshAllSettings(this, 0LL);
			  }
			}
			
			private void Reset() {} // 0x0000000189C14E30-0x0000000189C14E94
			// Void Reset()
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::Reset(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3889, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3889, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v5, v4);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			  }
			  else
			  {
			    HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::Initialize(
			      this,
			      HGDeviceType__Enum_Unknown,
			      0LL);
			    HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FeedSettingData(
			      this,
			      this->fields.m_settingData,
			      0LL);
			  }
			}
			
			public void MarkFeatureDirty(string featureName) {} // 0x00000001844852F0-0x0000000184485340
			// Void MarkFeatureDirty(String)
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::MarkFeatureDirty(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        String *featureName,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  HashSet_1_System_String_ *m_dirtyFeatureSettings; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(753, 0LL) )
			  {
			    m_dirtyFeatureSettings = this->fields.m_dirtyFeatureSettings;
			    if ( m_dirtyFeatureSettings )
			    {
			      System::Collections::Generic::HashSet<System::Object>::Add(
			        (HashSet_1_System_Object_ *)m_dirtyFeatureSettings,
			        (Object *)featureName,
			        MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			      return;
			    }
			LABEL_4:
			    sub_1800D8260(m_dirtyFeatureSettings, v5);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(753, 0LL);
			  if ( !Patch )
			    goto LABEL_4;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			    (ILFixDynamicMethodWrapper_39 *)Patch,
			    (Object *)this,
			    (Object *)featureName,
			    0LL);
			}
			
			public void OverrideFeatureTier(string featureName, int tier) {} // 0x0000000183C90C40-0x0000000183C90CC0
			// Void OverrideFeatureTier(String, Int32)
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::OverrideFeatureTier(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        String *featureName,
			        int32_t tier,
			        MethodInfo *method)
			{
			  __int64 v7; // rdx
			  Dictionary_2_System_Object_System_Int32_ *m_overrideFeatureSettingTiers; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3865, 0LL) )
			  {
			    m_overrideFeatureSettingTiers = (Dictionary_2_System_Object_System_Int32_ *)this->fields.m_overrideFeatureSettingTiers;
			    if ( m_overrideFeatureSettingTiers )
			    {
			      System::Collections::Generic::Dictionary<System::Object,int>::set_Item(
			        m_overrideFeatureSettingTiers,
			        (Object *)featureName,
			        tier,
			        MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::set_Item);
			      m_overrideFeatureSettingTiers = (Dictionary_2_System_Object_System_Int32_ *)this->fields.m_dirtyFeatureSettings;
			      if ( m_overrideFeatureSettingTiers )
			      {
			        System::Collections::Generic::HashSet<System::Object>::Add(
			          (HashSet_1_System_Object_ *)m_overrideFeatureSettingTiers,
			          (Object *)featureName,
			          MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			        return;
			      }
			    }
			LABEL_5:
			    sub_1800D8260(m_overrideFeatureSettingTiers, v7);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3865, 0LL);
			  if ( !Patch )
			    goto LABEL_5;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_37(
			    (ILFixDynamicMethodWrapper_15 *)Patch,
			    (Object *)this,
			    (Object *)featureName,
			    tier,
			    0LL);
			}
			
			public void ResetFeatureTier(string featureName) {} // 0x0000000189C14950-0x0000000189C149D8
			// Void ResetFeatureTier(String)
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetFeatureTier(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        String *featureName,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  Dictionary_2_System_Object_System_Int32_ *m_overrideFeatureSettingTiers; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3867, 0LL) )
			  {
			    m_overrideFeatureSettingTiers = (Dictionary_2_System_Object_System_Int32_ *)this->fields.m_overrideFeatureSettingTiers;
			    if ( m_overrideFeatureSettingTiers )
			    {
			      System::Collections::Generic::Dictionary<System::Object,int>::Remove(
			        m_overrideFeatureSettingTiers,
			        (Object *)featureName,
			        MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::Remove);
			      m_overrideFeatureSettingTiers = (Dictionary_2_System_Object_System_Int32_ *)this->fields.m_dirtyFeatureSettings;
			      if ( m_overrideFeatureSettingTiers )
			      {
			        System::Collections::Generic::HashSet<System::Object>::Add(
			          (HashSet_1_System_Object_ *)m_overrideFeatureSettingTiers,
			          (Object *)featureName,
			          MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
			        return;
			      }
			    }
			LABEL_6:
			    sub_1800D8260(m_overrideFeatureSettingTiers, v5);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3867, 0LL);
			  if ( !Patch )
			    goto LABEL_6;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			    (ILFixDynamicMethodWrapper_39 *)Patch,
			    (Object *)this,
			    (Object *)featureName,
			    0LL);
			}
			
			private void FlattenParameters(BaseSettingTable entryTable) {} // 0x000000018368B460-0x000000018368BC80
			// Void FlattenParameters(HGRenderPipelineSettingHub+HGRenderPipelineSettings+BaseSettingTable)
			// Hidden C++ exception states: #wind=3
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FlattenParameters(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *entryTable,
			        MethodInfo *method)
			{
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v4; // rbx
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			  List_1_System_UInt64_ *includeList; // rdi
			  _BYTE *v10; // rdx
			  Il2CppException *v11; // rcx
			  Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo_ *m_paramLookupTable; // r9
			  __int64 *v13; // rdx
			  signed __int64 v14; // rtt
			  __int64 v15; // rdx
			  signed __int64 items; // rcx
			  Object *i; // r13
			  MonitorData *monitor; // r9
			  __int64 *v19; // rdx
			  signed __int64 v20; // rtt
			  __int64 v21; // rcx
			  PassConstructorID__Enum__Array *v22; // r8
			  __int64 v23; // rax
			  __int64 v24; // rax
			  int v25; // ebx
			  __int128 v26; // xmm6
			  Il2CppClass *klass; // rcx
			  HGRenderPathBase_HGRenderPathResources *v28; // rdx
			  PassConstructorID__Enum__Array *v29; // r8
			  Int32__Array **v30; // r9
			  __int64 v31; // rdx
			  __int64 v32; // rcx
			  __int64 v33; // r8
			  List_1_System_Int32_ *v34; // rbx
			  int32_t v35; // esi
			  struct MethodInfo *v36; // rdi
			  __int64 size; // rdx
			  Object__Class *v38; // r15
			  Comparison_1_Int32_ *v39; // rbx
			  Object *v40; // rdi
			  __int64 v41; // rdx
			  __int64 v42; // rcx
			  Il2CppMethodPointer methodPointer; // rax
			  __int64 *v44; // r8
			  signed __int64 v45; // rtt
			  char v46; // cl
			  __int64 (__fastcall *method_ptr)(); // rax
			  void **p_invoke_impl; // rcx
			  char v49; // r8
			  signed __int64 v50; // rtt
			  struct MethodInfo *v51; // rdi
			  Int32__Array *name; // rsi
			  int32_t namespaze; // r14d
			  const Il2CppRGCTXData *rgctx_data; // rcx
			  Il2CppRGCTXData v55; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v57; // rdx
			  __int64 v58; // rcx
			  __int64 v59; // rax
			  _BYTE v60[32]; // [rsp+0h] [rbp-148h] BYREF
			  MethodInfo *methoda; // [rsp+20h] [rbp-128h]
			  MethodInfo *v62; // [rsp+28h] [rbp-120h]
			  _BYTE v63[48]; // [rsp+30h] [rbp-118h] BYREF
			  Il2CppException *ex; // [rsp+60h] [rbp-E8h]
			  void *v65; // [rsp+68h] [rbp-E0h]
			  __int128 v66; // [rsp+70h] [rbp-D8h] BYREF
			  int32_t item[4]; // [rsp+80h] [rbp-C8h] BYREF
			  __int128 v68; // [rsp+90h] [rbp-B8h]
			  Il2CppException *v69; // [rsp+A0h] [rbp-A8h]
			  __int128 *v70; // [rsp+A8h] [rbp-A0h]
			  Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v71; // [rsp+B0h] [rbp-98h] BYREF
			  List_1_T_Enumerator_System_Object_ v72; // [rsp+D8h] [rbp-70h] BYREF
			  Il2CppExceptionWrapper *v73; // [rsp+F0h] [rbp-58h] BYREF
			  Il2CppExceptionWrapper *v74; // [rsp+100h] [rbp-48h] BYREF
			  Il2CppExceptionWrapper *v75; // [rsp+108h] [rbp-40h] BYREF
			
			  v4 = this;
			  memset(&v71, 0, sizeof(v71));
			  v66 = 0LL;
			  *(_OWORD *)item = 0LL;
			  v68 = 0LL;
			  if ( IFix::WrappersManagerImpl::IsPatched(3845, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3845, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v58, v57);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			      (ILFixDynamicMethodWrapper_39 *)Patch,
			      (Object *)v4,
			      (Object *)entryTable,
			      0LL);
			  }
			  else
			  {
			    if ( !v4->fields.m_paramLookupTable )
			      sub_1800D8260(v6, v5);
			    System::Collections::Generic::Dictionary<System::Object,System::Object>::Clear(
			      (Dictionary_2_System_Object_System_Object_ *)v4->fields.m_paramLookupTable,
			      MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::Clear);
			    if ( !entryTable )
			      sub_1800D8260(v8, v7);
			    includeList = (List_1_System_UInt64_ *)entryTable->fields.includeList;
			    if ( !includeList )
			      sub_1800D8260(v8, v7);
			    System::Collections::Generic::List<unsigned long>::GetEnumerator(
			      (List_1_T_Enumerator_System_UInt64_ *)v63,
			      includeList,
			      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::GetEnumerator);
			    v72 = *(List_1_T_Enumerator_System_Object_ *)v63;
			    ex = 0LL;
			    v65 = &v72;
			    try
			    {
			      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                &v72,
			                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::MoveNext) )
			        HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::DoFlattenParameters(
			          v4,
			          (HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *)v72._current,
			          0LL);
			    }
			    catch ( Il2CppExceptionWrapper *v73 )
			    {
			      v10 = v60;
			      ex = v73->ex;
			      v11 = ex;
			      if ( ex )
			        sub_18007E1E0(ex);
			      v4 = this;
			    }
			    m_paramLookupTable = v4->fields.m_paramLookupTable;
			    if ( !m_paramLookupTable )
			      sub_1800D8250(v11, v10);
			    memset(&v63[8], 0, 32);
			    *(_QWORD *)v63 = m_paramLookupTable;
			    if ( dword_18F35FD08 )
			    {
			      v13 = &qword_18F0BCBA0[(((unsigned __int64)v63 >> 12) & 0x1FFFFF) >> 6];
			      _m_prefetchw(v13 + 36190);
			      do
			        v14 = v13[36190];
			      while ( v14 != _InterlockedCompareExchange64(
			                       v13 + 36190,
			                       v14 | (1LL << (((unsigned __int64)v63 >> 12) & 0x3F)),
			                       v14) );
			    }
			    *(_QWORD *)&v63[8] = (unsigned int)m_paramLookupTable->fields._version;
			    *(_DWORD *)&v63[32] = 2;
			    *(_OWORD *)&v63[16] = 0LL;
			    *(_OWORD *)&v71._dictionary = *(_OWORD *)v63;
			    v71._current = 0LL;
			    *(_QWORD *)&v71._getEnumeratorRetType = *(_QWORD *)&v63[32];
			    ex = 0LL;
			    v65 = &v71;
			    try
			    {
			      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
			                &v71,
			                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::MoveNext) )
			      {
			        for ( i = v71._current.value; i; i = (Object *)i[2].monitor )
			        {
			          monitor = i[1].monitor;
			          if ( !monitor )
			            sub_1800D8250(items, v15);
			          memset(&v63[8], 0, 40);
			          *(_QWORD *)v63 = monitor;
			          if ( dword_18F35FD08 )
			          {
			            v19 = &qword_18F0BCBA0[(((unsigned __int64)v63 >> 12) & 0x1FFFFF) >> 6];
			            _m_prefetchw(v19 + 36190);
			            do
			            {
			              items = v19[36190] | (1LL << (((unsigned __int64)v63 >> 12) & 0x3F));
			              v20 = v19[36190];
			            }
			            while ( v20 != _InterlockedCompareExchange64(v19 + 36190, items, v20) );
			          }
			          *(_QWORD *)&v63[8] = *((unsigned int *)monitor + 11);
			          *(_DWORD *)&v63[40] = 2;
			          memset(&v63[16], 0, 24);
			          v66 = *(_OWORD *)v63;
			          *(_OWORD *)item = 0LL;
			          v68 = *(_OWORD *)&v63[32];
			          v69 = 0LL;
			          v70 = &v66;
			          try
			          {
			LABEL_23:
			            v15 = v66;
			            if ( !(_QWORD)v66 )
			              sub_1800D8250(items, 0LL);
			            if ( DWORD2(v66) != *(_DWORD *)(v66 + 44) )
			              System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			            LODWORD(v21) = HIDWORD(v66);
			            while ( (unsigned int)v21 < *(_DWORD *)(v66 + 32) )
			            {
			              v22 = *(PassConstructorID__Enum__Array **)(v66 + 24);
			              v23 = (int)v21;
			              v21 = (unsigned int)(v21 + 1);
			              HIDWORD(v66) = v21;
			              if ( !v22 )
			                sub_1800D8250(v21, v66);
			              if ( (unsigned int)v23 >= v22->max_length.size )
			                sub_1800D2AA0(v21, v66, v22);
			              v24 = 32 * (v23 + 1);
			              if ( *(int *)((char *)&v22->klass + v24) >= 0 )
			              {
			                v25 = *(_DWORD *)((char *)&v22->monitor + v24);
			                memset(v63, 0, 24);
			                v26 = *(_OWORD *)&(&v22->bounds)[(unsigned __int64)v24 / 8];
			                klass = MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::MoveNext->klass;
			                if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
			                  sub_1800360B0(klass, v66);
			                *(_DWORD *)v63 = v25;
			                *(_OWORD *)&v63[8] = v26;
			                sub_18002D1B0(
			                  (HGRenderPathScene *)&v63[8],
			                  (HGRenderPathBase_HGRenderPathResources *)v15,
			                  v22,
			                  (Int32__Array **)monitor,
			                  methoda,
			                  v62);
			                *(_OWORD *)item = *(_OWORD *)v63;
			                *(_QWORD *)&v68 = *(_QWORD *)&v63[16];
			                sub_18002D1B0((HGRenderPathScene *)&item[2], v28, v29, v30, methoda, v62);
			                v34 = (List_1_System_Int32_ *)i[2].klass;
			                v35 = item[0];
			                if ( !v34 )
			                  sub_1800D8250(v32, v31);
			                v36 = MethodInfo::System::Collections::Generic::List<int>::Add;
			                ++v34->fields._version;
			                items = (signed __int64)v34->fields._items;
			                size = v34->fields._size;
			                if ( !items )
			                  sub_1800D8250(0LL, size);
			                if ( (unsigned int)size < *(_DWORD *)(items + 24) )
			                {
			                  v34->fields._size = size + 1;
			                  if ( (unsigned int)size >= *(_DWORD *)(items + 24) )
			                    sub_1800D2AA0(items, size, v33);
			                  *(_DWORD *)(items + 4 * size + 32) = v35;
			                }
			                else
			                {
			                  if ( !*((_QWORD *)v36->klass->rgctx_data[11].rgctxDataDummy + 4) )
			                    (*(void (**)(void))v36->klass->rgctx_data[11].rgctxDataDummy)();
			                  System::Collections::Generic::List<int>::AddWithResize(
			                    v34,
			                    v35,
			                    (MethodInfo *)v36->klass->rgctx_data[11].rgctxDataDummy);
			                }
			                goto LABEL_23;
			              }
			            }
			            HIDWORD(v66) = *(_DWORD *)(v66 + 32) + 1;
			            *(_OWORD *)item = 0LL;
			            *(_QWORD *)&v68 = 0LL;
			          }
			          catch ( Il2CppExceptionWrapper *v74 )
			          {
			            v15 = (__int64)v60;
			            v69 = v74->ex;
			            if ( v69 )
			              sub_18007E1E0(v69);
			          }
			          v38 = i[2].klass;
			          items = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c;
			          if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c->_1.cctor_finished_or_no_cctor )
			          {
			            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c);
			            items = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c;
			          }
			          v39 = *(Comparison_1_Int32_ **)(*(_QWORD *)(items + 184) + 16LL);
			          if ( !v39 )
			          {
			            if ( !*(_DWORD *)(items + 224) )
			            {
			              il2cpp_runtime_class_init_1(items);
			              items = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c;
			            }
			            v40 = **(Object ***)(items + 184);
			            v39 = (Comparison_1_Int32_ *)sub_18002C620(TypeInfo::System::Comparison<int>);
			            if ( !v39 )
			              sub_1800D8250(v42, v41);
			            v15 = (__int64)MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c::_FlattenParameters_b__59_0;
			            if ( (*((_BYTE *)MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c::_FlattenParameters_b__59_0
			                  + 84) & 2) != 0
			              && qword_18F360250 )
			            {
			              methodPointer = MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c::_FlattenParameters_b__59_0[1].methodPointer;
			            }
			            else
			            {
			              methodPointer = MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c::_FlattenParameters_b__59_0->virtualMethodPointer;
			            }
			            v39->fields._._.method_ptr = methodPointer;
			            v39->fields._._.method = (void *)v15;
			            v39->fields._._.m_target = v40;
			            if ( dword_18F35FD08 )
			            {
			              v44 = &qword_18F0BCBA0[(((unsigned __int64)&v39->fields._._.m_target >> 12) & 0x1FFFFF) >> 6];
			              _m_prefetchw(v44 + 36190);
			              do
			                v45 = v44[36190];
			              while ( v45 != _InterlockedCompareExchange64(
			                               v44 + 36190,
			                               v45 | (1LL << (((unsigned __int64)&v39->fields._._.m_target >> 12) & 0x3F)),
			                               v45) );
			            }
			            v46 = *(_BYTE *)(v15 + 83);
			            v39->fields._._.method_code = v39;
			            if ( (*(_BYTE *)(v15 + 76) & 0x10) != 0 )
			            {
			              if ( (*(_BYTE *)(v15 + 84) & 0x10) != 0 )
			              {
			                method_ptr = sub_1805F0584;
			                if ( v46 != 2 )
			                  method_ptr = sub_1805F055C;
			              }
			              else if ( v46 == 2 )
			              {
			                method_ptr = sub_1805AD1D8;
			              }
			              else
			              {
			                v39->fields._._.method_code = v39->fields._._.m_target;
			                method_ptr = (__int64 (__fastcall *)())v39->fields._._.method_ptr;
			              }
			              v15 = 24LL;
			              p_invoke_impl = &v39->fields._._.invoke_impl;
			            }
			            else
			            {
			              if ( !v40 )
			              {
			                v59 = sub_180BF4954(0LL, "Delegate to an instance method cannot have null 'this'.");
			                sub_18007E190(v59, 0LL);
			              }
			              v39->fields._._.method_code = v39->fields._._.m_target;
			              method_ptr = (__int64 (__fastcall *)())v39->fields._._.method_ptr;
			              p_invoke_impl = &v39->fields._._.invoke_impl;
			            }
			            *p_invoke_impl = method_ptr;
			            v39->fields._._.extra_arg = sub_1805AD168;
			            items = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c->static_fields;
			            *(_QWORD *)(items + 16) = v39;
			            if ( dword_18F35FD08 )
			            {
			              v15 = (__int64)&qword_18F0BCBA0[(((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c->static_fields->__9__59_0 >> 12) & 0x1FFFFF) >> 6];
			              v49 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c->static_fields->__9__59_0 >> 12) & 0x3F;
			              _m_prefetchw((const void *)(v15 + 289520));
			              do
			              {
			                items = *(_QWORD *)(v15 + 289520) | (1LL << v49);
			                v50 = *(_QWORD *)(v15 + 289520);
			              }
			              while ( v50 != _InterlockedCompareExchange64((volatile signed __int64 *)(v15 + 289520), items, v50) );
			            }
			          }
			          if ( !v38 )
			            sub_1800D8250(items, v15);
			          v51 = MethodInfo::System::Collections::Generic::List<int>::Sort;
			          if ( SLODWORD(v38->_0.namespaze) > 1 )
			          {
			            name = (Int32__Array *)v38->_0.name;
			            namespaze = (int32_t)v38->_0.namespaze;
			            rgctx_data = MethodInfo::System::Collections::Generic::List<int>::Sort->klass->rgctx_data;
			            v55.rgctxDataDummy = rgctx_data[52].rgctxDataDummy;
			            if ( (*((_BYTE *)v55.rgctxDataDummy + 312) & 1) == 0 )
			              sub_1800360B0((const Il2CppRGCTXData)rgctx_data[52].rgctxDataDummy, v15);
			            if ( !*((_DWORD *)v55.rgctxDataDummy + 56) )
			              ((void (__fastcall *)(_QWORD))il2cpp_runtime_class_init_1)((Il2CppRGCTXData)v55.rgctxDataDummy);
			            System::Collections::Generic::ArraySortHelper<int>::Sort(
			              name,
			              0,
			              namespaze,
			              v39,
			              (MethodInfo *)v51->klass->rgctx_data[51].rgctxDataDummy);
			          }
			          ++HIDWORD(v38->_0.namespaze);
			        }
			      }
			    }
			    catch ( Il2CppExceptionWrapper *v75 )
			    {
			      ex = v75->ex;
			      if ( ex )
			        sub_18007E1E0(ex);
			      return;
			    }
			    if ( ex )
			      sub_18007E1E0(ex);
			  }
			}
			
			private void DoFlattenParameters(BaseSettingTable settingTable) {} // 0x000000018368A660-0x000000018368AE90
			// Void DoFlattenParameters(HGRenderPipelineSettingHub+HGRenderPipelineSettings+BaseSettingTable)
			// Hidden C++ exception states: #wind=3 #try_helpers=1
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::DoFlattenParameters(
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
			        HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *settingTable,
			        MethodInfo *method)
			{
			  Object *v3; // rsi
			  Action_6_Object_Object_Object_Int32_Object_Object_ *v5; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			  Action_6_Object_Object_Object_Int32_Object_Object_ *v8; // r12
			  __int64 v9; // rdx
			  __int64 v10; // rcx
			  MonitorData *monitor; // rbx
			  SectionCollection *v12; // rbx
			  __int64 v13; // rdx
			  List_1_System_UInt64_ *list; // rcx
			  IEnumerator_1_IniParser_Model_Section_ **p_Enumerator; // rdi
			  List_1_System_UInt64_ *v16; // rdx
			  __int64 v17; // rcx
			  IEnumerator_1_IniParser_Model_Section_ *v18; // rbx
			  struct IEnumerator_1_IniParser_Model_Section___Class *v19; // rsi
			  IEnumerator_1_IniParser_Model_Section___Class *klass; // r14
			  unsigned __int16 v21; // cx
			  unsigned __int16 v22; // dx
			  Il2CppRuntimeInterfaceOffsetPair *interfaceOffsets; // r8
			  __int64 v24; // rdx
			  __int64 v25; // rax
			  __int64 v26; // rdx
			  __int64 v27; // rcx
			  __int64 v28; // r14
			  String *v29; // rbx
			  struct HGRenderPipelineSettingHub_ConstantStrings__Class *v30; // rax
			  String *INCLUDE_STR; // rsi
			  int32_t stringLength; // r15d
			  struct CompareInfo__Class *v33; // rax
			  CompareInfo *Invariant; // rcx
			  int32_t v35; // eax
			  String *v36; // rbx
			  struct HGRenderPipelineSettingHub_ConstantStrings__Class *v37; // rax
			  String *ARRAY_CONCATENATE_STR; // rdx
			  String__Array *v39; // rax
			  __int64 v40; // rdx
			  __int64 v41; // rcx
			  __int64 v42; // r8
			  String__Array *v43; // r15
			  String *v44; // r10
			  HGRenderPipelineSettingHub_ConstantStrings__StaticFields *static_fields; // rcx
			  String *SUBLEVEL_STR; // rdx
			  String__Array *v47; // rax
			  __int64 v48; // rcx
			  __int64 v49; // r8
			  __int64 v50; // rbx
			  __int64 v51; // rax
			  HGRenderPathBase_HGRenderPathResources *v52; // rdx
			  __int64 v53; // rcx
			  PassConstructorID__Enum__Array *v54; // r8
			  __int64 v55; // rdx
			  __int64 v56; // rcx
			  _QWORD *v57; // r9
			  _QWORD *v58; // r14
			  struct IEnumerator_1_IniParser_Model_Property___Class *v59; // rsi
			  __int64 v60; // r13
			  unsigned __int16 v61; // cx
			  unsigned __int16 v62; // dx
			  __int64 v63; // r8
			  __int64 v64; // rdx
			  __int64 v65; // rax
			  __int64 v66; // r8
			  __int64 v67; // r14
			  int i; // esi
			  String *v69; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v71; // rdx
			  __int64 v72; // rcx
			  __int64 v73; // rax
			  ArgumentOutOfRangeException *v74; // rbx
			  String *v75; // rdi
			  String *v76; // rax
			  __int64 v77; // rax
			  __int64 v78; // rax
			  ArgumentNullException *v79; // rbx
			  String *v80; // rax
			  __int64 v81; // rax
			  MethodInfo *count; // [rsp+20h] [rbp-D8h]
			  MethodInfo *ignoreCase; // [rsp+28h] [rbp-D0h]
			  _QWORD *v84; // [rsp+40h] [rbp-B8h] BYREF
			  List_1_T_Enumerator_System_Object_ v85; // [rsp+48h] [rbp-B0h] BYREF
			  IEnumerator_1_IniParser_Model_Section_ *Enumerator; // [rsp+60h] [rbp-98h] BYREF
			  List_1_System_UInt64_ *v87; // [rsp+68h] [rbp-90h]
			  __int64 v88; // [rsp+70h] [rbp-88h]
			  IEnumerator_1_IniParser_Model_Section_ **v89; // [rsp+78h] [rbp-80h]
			  List_1_T_Enumerator_System_Object_ v90; // [rsp+80h] [rbp-78h] BYREF
			  Action_6_Object_Object_Object_Int32_Object_Object_ *v91; // [rsp+98h] [rbp-60h]
			  Il2CppExceptionWrapper *v92; // [rsp+A0h] [rbp-58h] BYREF
			  Il2CppExceptionWrapper *v93; // [rsp+B0h] [rbp-48h] BYREF
			  int32_t v96; // [rsp+118h] [rbp+20h]
			
			  v3 = (Object *)settingTable;
			  v84 = 0LL;
			  memset(&v90, 0, sizeof(v90));
			  if ( !IFix::WrappersManagerImpl::IsPatched(3846, 0LL) )
			  {
			    v5 = (Action_6_Object_Object_Object_Int32_Object_Object_ *)sub_1800368D0(TypeInfo::System::Action<System::String,System::String,System::String,int,System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>);
			    v8 = v5;
			    if ( !v5 )
			      sub_1800D8260(v7, v6);
			    System::Action<System::Object,System::Object,System::Object,int,System::Object,System::Object>::Action(
			      v5,
			      (Object *)this,
			      MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::_DoFlattenParameters_b__60_0,
			      0LL);
			    v91 = v8;
			    if ( !v3 )
			      sub_1800D8260(v10, v9);
			    monitor = v3[3].monitor;
			    if ( !monitor )
			      sub_1800D8260(v10, v9);
			    v12 = (SectionCollection *)*((_QWORD *)monitor + 4);
			    if ( !v12 )
			      sub_1800D8260(v10, v9);
			    Enumerator = IniParser::Model::SectionCollection::GetEnumerator(v12, 0LL);
			    v88 = 0LL;
			    p_Enumerator = &Enumerator;
			    v89 = &Enumerator;
			    while ( 1 )
			    {
			      do
			      {
			        do
			        {
			LABEL_7:
			          if ( !Enumerator )
			            sub_1800D8250(list, v13);
			          if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
			          {
			            if ( *p_Enumerator )
			              sub_180053A90(0LL, TypeInfo::System::IDisposable);
			            if ( !v3 || (v16 = (List_1_System_UInt64_ *)v3[1].monitor) == 0LL )
			              sub_1800D8250(v17, v16);
			            System::Collections::Generic::List<unsigned long>::GetEnumerator(
			              (List_1_T_Enumerator_System_UInt64_ *)&v85,
			              v16,
			              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::GetEnumerator);
			            v90 = v85;
			            v85._list = 0LL;
			            *(_QWORD *)&v85._index = &v90;
			            try
			            {
			              while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			                        &v90,
			                        MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::MoveNext) )
			                HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::DoFlattenParameters(
			                  this,
			                  (HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *)v90._current,
			                  0LL);
			            }
			            catch ( Il2CppExceptionWrapper *v93 )
			            {
			              v85._list = (List_1_System_Object_ *)v93->ex;
			              mono_thread_suspend_all_other_threads(
			                *(_QWORD *)&v85._index,
			                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::Dispose);
			              if ( v85._list )
			                sub_18007E1E0(v85._list);
			              return;
			            }
			            mono_thread_suspend_all_other_threads(
			              &v90,
			              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::Dispose);
			            return;
			          }
			          v18 = Enumerator;
			          if ( !Enumerator )
			            sub_1800D8250(v17, v16);
			          v19 = TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Section>;
			          klass = Enumerator->klass;
			          sub_1800049A0(Enumerator->klass);
			          v21 = 0;
			          v22 = *(_WORD *)&klass->_1.naturalAligment;
			          if ( v22 )
			          {
			            interfaceOffsets = klass->interfaceOffsets;
			            while ( (struct IEnumerator_1_IniParser_Model_Section___Class *)interfaceOffsets[v21].interfaceType != v19 )
			            {
			              if ( ++v21 >= v22 )
			                goto LABEL_14;
			            }
			            v24 = (__int64)(&klass->vtable.get_Current.method + 2 * interfaceOffsets[v21].offset);
			          }
			          else
			          {
			LABEL_14:
			            v24 = sub_1800219C0(v18, v19, 0LL);
			          }
			          v25 = (*(__int64 (__fastcall **)(IEnumerator_1_IniParser_Model_Section_ *, _QWORD))v24)(
			                  v18,
			                  *(_QWORD *)(v24 + 8));
			          v28 = v25;
			          if ( !v25 )
			            sub_1800D8250(v27, v26);
			          v29 = *(String **)(v25 + 32);
			          v30 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
			          if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->_1.cctor_finished_or_no_cctor )
			          {
			            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			            v30 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
			          }
			          INCLUDE_STR = v30->static_fields->INCLUDE_STR;
			          if ( !v29 )
			            sub_1800D8250(v27, v26);
			          stringLength = v29->fields._stringLength;
			          if ( !INCLUDE_STR )
			          {
			            v78 = sub_18007E180(&TypeInfo::System::ArgumentNullException);
			            v79 = (ArgumentNullException *)sub_1800368D0(v78);
			            sub_180003640(v79);
			            v80 = (String *)sub_18007E180(&off_18E363330);
			            System::ArgumentNullException::ArgumentNullException(v79, v80, 0LL);
			            v81 = sub_18007E180(&MethodInfo::System::String::IndexOf);
			            sub_18007E190(v79, v81);
			          }
			          if ( stringLength < 0 )
			          {
			            v73 = sub_18007E180(&TypeInfo::System::ArgumentOutOfRangeException);
			            v74 = (ArgumentOutOfRangeException *)sub_1800368D0(v73);
			            sub_180003640(v74);
			            v75 = (String *)sub_18007E180(&off_18E356D38);
			            v76 = (String *)sub_18007E180(&off_18E356D28);
			            System::ArgumentOutOfRangeException::ArgumentOutOfRangeException(v74, v76, v75, 0LL);
			            v77 = sub_18007E180(&MethodInfo::System::String::IndexOf);
			            sub_18007E190(v74, v77);
			          }
			          v33 = TypeInfo::System::Globalization::CompareInfo;
			          if ( !TypeInfo::System::Globalization::CompareInfo->_1.cctor_finished_or_no_cctor )
			          {
			            il2cpp_runtime_class_init_1(TypeInfo::System::Globalization::CompareInfo);
			            v33 = TypeInfo::System::Globalization::CompareInfo;
			          }
			          Invariant = v33->static_fields->Invariant;
			          if ( !Invariant )
			            sub_1800D8250(0LL, v26);
			          v35 = System::Globalization::CompareInfo::IndexOfOrdinal(Invariant, v29, INCLUDE_STR, 0, stringLength, 0, 0LL);
			          v3 = (Object *)settingTable;
			        }
			        while ( v35 >= 0 );
			        v36 = *(String **)(v28 + 32);
			        v37 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
			        if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->_1.cctor_finished_or_no_cctor )
			        {
			          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			          v37 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
			        }
			        ARRAY_CONCATENATE_STR = v37->static_fields->ARRAY_CONCATENATE_STR;
			        if ( !v36 )
			          sub_1800D8250(list, ARRAY_CONCATENATE_STR);
			        if ( !ARRAY_CONCATENATE_STR )
			          ARRAY_CONCATENATE_STR = TypeInfo::System::String->static_fields->Empty;
			        v39 = System::String::SplitInternal(
			                v36,
			                ARRAY_CONCATENATE_STR,
			                0LL,
			                0x7FFFFFFF,
			                StringSplitOptions__Enum_None,
			                0LL);
			        v43 = v39;
			        if ( !v39 )
			          sub_1800D8250(v41, v40);
			        if ( !v39->max_length.size )
			          sub_1800D2AA0(v41, v40, v42);
			        v44 = v39->vector[0];
			        static_fields = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->static_fields;
			        SUBLEVEL_STR = static_fields->SUBLEVEL_STR;
			        if ( !v44 )
			          sub_1800D8250(static_fields, SUBLEVEL_STR);
			        if ( !SUBLEVEL_STR )
			          SUBLEVEL_STR = TypeInfo::System::String->static_fields->Empty;
			        v47 = System::String::SplitInternal(v44, SUBLEVEL_STR, 0LL, 0x7FFFFFFF, StringSplitOptions__Enum_None, 0LL);
			        if ( !v47 )
			          sub_1800D8250(v48, v13);
			        if ( !v47->max_length.size )
			          sub_1800D2AA0(v48, v13, v49);
			        list = (List_1_System_UInt64_ *)v47->vector[0];
			        v87 = list;
			        if ( v47->max_length.size <= 1 )
			        {
			          v96 = 0;
			          break;
			        }
			        if ( v47->max_length.size <= 1u )
			          sub_1800D2AA0(list, v13, v49);
			        v96 = System::Int32::Parse(v47->vector[1], 0LL);
			        v3 = (Object *)settingTable;
			      }
			      while ( v96 < 0 );
			      v50 = *(_QWORD *)(v28 + 16);
			      if ( !v50 )
			        sub_1800D8250(list, v13);
			      v51 = sub_1800368D0(TypeInfo::IniParser::Model::PropertyCollection::_GetEnumerator_d__17);
			      if ( !v51 )
			        sub_1800D8250(v53, v52);
			      *(_DWORD *)(v51 + 16) = 0;
			      *(_QWORD *)(v51 + 32) = v50;
			      sub_18002D1B0((HGRenderPathScene *)(v51 + 32), v52, v54, (Int32__Array **)v51, count, ignoreCase);
			      v84 = v57;
			      v85._list = 0LL;
			      *(_QWORD *)&v85._index = &v84;
			      try
			      {
			LABEL_47:
			        v3 = (Object *)settingTable;
			        while ( 1 )
			        {
			          if ( !v84 )
			            sub_1800D8250(v56, v55);
			          if ( !(unsigned __int8)sub_180042E60(0LL, TypeInfo::System::Collections::IEnumerator) )
			            break;
			          v58 = v84;
			          if ( !v84 )
			            sub_1800D8250(list, v13);
			          v59 = TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Property>;
			          v60 = *v84;
			          sub_1800049A0(*v84);
			          v61 = 0;
			          v62 = *(_WORD *)(v60 + 304);
			          if ( v62 )
			          {
			            v63 = *(_QWORD *)(v60 + 176);
			            while ( *(struct IEnumerator_1_IniParser_Model_Property___Class **)(v63 + 16LL * v61) != v59 )
			            {
			              if ( ++v61 >= v62 )
			                goto LABEL_55;
			            }
			            v64 = v60 + 16 * (*(int *)(v63 + 16LL * v61 + 8) + 20LL);
			          }
			          else
			          {
			LABEL_55:
			            v64 = sub_1800219C0(v58, v59, 0LL);
			          }
			          v65 = (*(__int64 (__fastcall **)(_QWORD *, _QWORD))v64)(v58, *(_QWORD *)(v64 + 8));
			          v67 = v65;
			          if ( v43->max_length.size > 1 )
			          {
			            for ( i = 1; i < v43->max_length.size; ++i )
			            {
			              if ( !v67 )
			                sub_1800D8250(v56, v55);
			              if ( (unsigned int)i >= v43->max_length.size )
			                sub_1800D2AA0(v56, v55, v66);
			              v69 = v43->vector[i];
			              if ( !v8 )
			                sub_1800D8250(v69, v55);
			              ((void (__fastcall *)(void *, _QWORD, _QWORD, List_1_System_UInt64_ *, int32_t, String *, HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *, void *))v8->fields._._.invoke_impl)(
			                v8->fields._._.method_code,
			                *(_QWORD *)(v67 + 16),
			                *(_QWORD *)(v67 + 24),
			                v87,
			                v96,
			                v69,
			                settingTable,
			                v8->fields._._.method);
			            }
			            goto LABEL_47;
			          }
			          if ( !v65 )
			            sub_1800D8250(v56, v55);
			          if ( !v8 )
			            sub_1800D8250(v56, v55);
			          v3 = (Object *)settingTable;
			          ((void (__fastcall *)(void *, _QWORD, _QWORD, List_1_System_UInt64_ *, int32_t, const char *, HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *, void *))v8->fields._._.invoke_impl)(
			            v8->fields._._.method_code,
			            *(_QWORD *)(v65 + 16),
			            *(_QWORD *)(v65 + 24),
			            v87,
			            v96,
			            "",
			            settingTable,
			            v8->fields._._.method);
			        }
			      }
			      catch ( Il2CppExceptionWrapper *v92 )
			      {
			        v85._list = (List_1_System_Object_ *)v92->ex;
			        sub_18317CB50(&v85._index);
			        list = (List_1_System_UInt64_ *)v85._list;
			        if ( v85._list )
			          sub_18007E1E0(v85._list);
			        v8 = v91;
			        p_Enumerator = v89;
			        v3 = (Object *)settingTable;
			        goto LABEL_7;
			      }
			      if ( v84 )
			        sub_180053A90(0LL, TypeInfo::System::IDisposable);
			    }
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3846, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v72, v71);
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, v3, 0LL);
			}
			
		}
	
		public abstract class SettingParameterBase // TypeDefIndex: 38592
		{
			// Fields
			private ParamLookupResult m_paramLookupResult; // 0x20
	
			// Properties
			internal string featureName { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
			// IValueSource get_source()
			IValueSource *Beyond::ValueAdapter<Beyond::GameSetting::ScreenResolution>::get_source(
			        ValueAdapter_1_GameSetting_ScreenResolution_ *this,
			        MethodInfo *method)
			{
			  return this->fields.m_source;
			}
			
			internal string paramName { get; } // 0x000000018385B100-0x000000018385B110 
			// Object System.Collections.IEnumerator.get_Current()
			Object *Rewired::Platforms::Custom::HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_::vFJqwhcHvHdpsRAHqwODiJDbwkcr<System::Object>::System_Collections_IEnumerator_get_Current(
			        HardwareJoystickMapCustomPlatformMap_1_TMatchingCriteria_vFJqwhcHvHdpsRAHqwODiJDbwkcr_System_Object_ *this,
			        MethodInfo *method)
			{
			  return (Object *)this->fields.YcoKziTgrGqKCwJTNRuXadHqwkUP;
			}
			
			protected bool overrided { get; set; } // 0x00000001847C8330-0x00000001847C8370 0x0000000183E6D3D0-0x0000000183E6D430
			// Boolean get_overrided()
			bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::get_overrided(
			        HGRenderPipelineSettingHub_SettingParameterBase *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  __int64 v4; // rcx
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3891, 0LL) )
			  {
			    m_paramLookupResult = this->fields.m_paramLookupResult;
			    if ( m_paramLookupResult )
			      return m_paramLookupResult->fields.paramSource == 4;
			LABEL_4:
			    sub_1800D8260(v4, v3);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3891, 0LL);
			  if ( !Patch )
			    goto LABEL_4;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			}
			

			// Void set_overrided(Boolean)
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::set_overrided(
			        HGRenderPipelineSettingHub_SettingParameterBase *this,
			        bool value,
			        MethodInfo *method)
			{
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3892, 0LL) )
			  {
			    if ( !value )
			      return;
			    m_paramLookupResult = this->fields.m_paramLookupResult;
			    if ( m_paramLookupResult )
			    {
			      m_paramLookupResult->fields.paramSource = 4;
			      return;
			    }
			LABEL_5:
			    sub_1800D8260(v6, v5);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3892, 0LL);
			  if ( !Patch )
			    goto LABEL_5;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
			}
			
			protected bool shouldRefresh { get; } // 0x0000000183E66890-0x0000000183E66910 
			// Boolean get_shouldRefresh()
			bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::get_shouldRefresh(
			        HGRenderPipelineSettingHub_SettingParameterBase *this,
			        MethodInfo *method)
			{
			  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v3->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    goto LABEL_10;
			  if ( wrapperArray->max_length.size <= 3893 )
			    goto LABEL_5;
			  if ( !v3->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(v3);
			    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
			  if ( !v3 )
			LABEL_10:
			    sub_1800D8260(v3, wrapperArray);
			  if ( LODWORD(v3->_0.namespaze) <= 0xF35 )
			    sub_1800D2AB0(v3, wrapperArray);
			  if ( v3[82].vtable.GetHashCode.methodPtr )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3893, 0LL);
			    if ( Patch )
			      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			    goto LABEL_10;
			  }
			LABEL_5:
			  m_paramLookupResult = this->fields.m_paramLookupResult;
			  if ( !m_paramLookupResult )
			    goto LABEL_10;
			  return m_paramLookupResult->fields.paramSource == 3
			      || m_paramLookupResult->fields.paramSource == 2
			      || m_paramLookupResult->fields.paramSource == 1;
			}
			
			protected string valueString { get; } // 0x0000000183E66910-0x0000000183E66950 
			// String get_valueString()
			String *HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::get_valueString(
			        HGRenderPipelineSettingHub_SettingParameterBase *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  __int64 v4; // rcx
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3894, 0LL) )
			  {
			    m_paramLookupResult = this->fields.m_paramLookupResult;
			    if ( m_paramLookupResult )
			      return m_paramLookupResult->fields.value;
			LABEL_4:
			    sub_1800D8260(v4, v3);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3894, 0LL);
			  if ( !Patch )
			    goto LABEL_4;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
			}
			
			protected bool isFromCode { get; } // 0x000000018430BC80-0x000000018430BD60 
			// Boolean get_isFromCode()
			bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::get_isFromCode(
			        HGRenderPipelineSettingHub_SettingParameterBase *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  __int64 v4; // rcx
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3895, 0LL) )
			  {
			    m_paramLookupResult = this->fields.m_paramLookupResult;
			    if ( m_paramLookupResult )
			      return m_paramLookupResult->fields.paramSource == 0;
			LABEL_4:
			    sub_1800D8260(v4, v3);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3895, 0LL);
			  if ( !Patch )
			    goto LABEL_4;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
			}
			
	
			// Nested types
			private class ParamLookupResult // TypeDefIndex: 38590
			{
				// Fields
				internal string value; // 0x10
				internal string constrainString; // 0x18
				internal int tier; // 0x20
				internal HGDeviceType deviceType; // 0x24
				internal HGRenderPipelineSettings.BaseSettingTable fromTable; // 0x28
				internal ParamSource paramSource; // 0x30
	
				// Nested types
				internal enum ParamSource // TypeDefIndex: 38589
				{
					FromCode = 0,
					FromDefault = 1,
					FromClosest = 2,
					FromMatched = 3,
					FromOverride = 4,
					Error = 5
				}
	
				// Constructors
				public ParamLookupResult() {} // 0x000000018383D110-0x000000018383D150
			}
	
			// Constructors
			protected SettingParameterBase() {} // Dummy constructor
			protected SettingParameterBase(string featureName, string paramName) {} // 0x000000018383AE00-0x000000018383AE60
	
			// Methods
			public void Reset() {} // 0x0000000189C1AFDC-0x0000000189C1B048
			// Void Reset()
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::Reset(
			        HGRenderPipelineSettingHub_SettingParameterBase *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  __int64 v4; // rcx
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3857, 0LL) )
			  {
			    m_paramLookupResult = this->fields.m_paramLookupResult;
			    if ( m_paramLookupResult )
			    {
			      m_paramLookupResult->fields.paramSource = 0;
			      HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::MarkFeatureDirty(this, 0LL);
			      HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::Refresh(this, 0, 0LL);
			      return;
			    }
			LABEL_5:
			    sub_1800D8260(v4, v3);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3857, 0LL);
			  if ( !Patch )
			    goto LABEL_5;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			}
			
			internal void Refresh(bool useDefaultSettings = false /* Metadata: 0x02303F1D */) {} // 0x000000018383D020-0x000000018383D110
			// Void Refresh(Boolean)
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::Refresh(
			        HGRenderPipelineSettingHub_SettingParameterBase *this,
			        bool useDefaultSettings,
			        MethodInfo *method)
			{
			  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			  __int64 v7; // rax
			  PassConstructorID__Enum__Array *v8; // r8
			  Int32__Array **v9; // r9
			  __int64 v10; // r10
			  HGRenderPathBase_HGRenderPathResources *v11; // rdx
			  PassConstructorID__Enum__Array *v12; // r8
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v13; // r10
			  HGRenderPathBase_HGRenderPathResources *v14; // rdx
			  PassConstructorID__Enum__Array *v15; // r8
			  Int32__Array **v16; // r9
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  MethodInfo *v18; // [rsp+20h] [rbp-18h]
			  MethodInfo *v19; // [rsp+20h] [rbp-18h]
			  MethodInfo *v20; // [rsp+20h] [rbp-18h]
			  MethodInfo *v21; // [rsp+28h] [rbp-10h]
			  MethodInfo *v22; // [rsp+28h] [rbp-10h]
			  MethodInfo *v23; // [rsp+28h] [rbp-10h]
			
			  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = v5->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    goto LABEL_12;
			  if ( wrapperArray->max_length.size > 596 )
			  {
			    if ( !v5->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(v5);
			      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
			    if ( !v5 )
			      goto LABEL_12;
			    if ( LODWORD(v5->_0.namespaze) <= 0x254 )
			      sub_1800D2AB0(v5, wrapperArray);
			    if ( *(_QWORD *)&v5[12]._1.field_count )
			    {
			      Patch = IFix::WrappersManagerImpl::GetPatch(596, 0LL);
			      if ( Patch )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			          (ILFixDynamicMethodWrapper_18 *)Patch,
			          (Object *)this,
			          useDefaultSettings,
			          0LL);
			        return;
			      }
			      goto LABEL_12;
			    }
			  }
			  if ( this->fields.m_paramLookupResult && this->fields.m_paramLookupResult->fields.paramSource == 4 )
			    return;
			  v7 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_SettingParameterBase::ParamLookupResult);
			  if ( !v7 )
			LABEL_12:
			    sub_1800D8260(v5, wrapperArray);
			  *(_QWORD *)(v7 + 16) = "";
			  sub_18002D1B0(
			    (HGRenderPathScene *)(v7 + 16),
			    (HGRenderPathBase_HGRenderPathResources *)wrapperArray,
			    v8,
			    v9,
			    v18,
			    v21);
			  *(_QWORD *)(v10 + 24) = "";
			  sub_18002D1B0((HGRenderPathScene *)(v10 + 24), v11, v12, (Int32__Array **)"", v19, v22);
			  this->fields.m_paramLookupResult = v13;
			  sub_18002D1B0((HGRenderPathScene *)&this->fields.m_paramLookupResult, v14, v15, v16, v20, v23);
			  if ( !useDefaultSettings )
			    HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::AcquireParamValueInSettingTable(
			      this,
			      &this->fields.m_paramLookupResult,
			      0LL);
			  sub_180003290(4LL, this);
			}
			
			protected abstract void RefreshInternal();
			internal abstract bool OverrideWithString(string valueString);
			public void MarkFeatureDirty() {} // 0x00000001844852A0-0x00000001844852F0
			// Void MarkFeatureDirty()
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::MarkFeatureDirty(
			        HGRenderPipelineSettingHub_SettingParameterBase *this,
			        MethodInfo *method)
			{
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings *settingImpl; // rax
			  __int64 v4; // rdx
			  __int64 v5; // rcx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(752, 0LL) )
			  {
			    settingImpl = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(0LL);
			    if ( settingImpl )
			    {
			      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::MarkFeatureDirty(
			        settingImpl,
			        this->fields._featureName_k__BackingField,
			        0LL);
			      return;
			    }
			LABEL_4:
			    sub_1800D8260(v5, v4);
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(752, 0LL);
			  if ( !Patch )
			    goto LABEL_4;
			  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
			}
			
			internal string DumpParameterInfo() => default; // 0x0000000189C1A8C0-0x0000000189C1AFDC
			// String DumpParameterInfo()
			String *HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::DumpParameterInfo(
			        HGRenderPipelineSettingHub_SettingParameterBase *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rcx
			  String *v5; // rdi
			  int32_t paramSource; // ecx
			  int v7; // ecx
			  int v8; // ecx
			  int v9; // ecx
			  __int64 v10; // rax
			  String__Array *v11; // rsi
			  String *featureName_k__BackingField; // r8
			  __int64 v13; // rdx
			  String *v14; // rax
			  char *v15; // rdx
			  __int64 v16; // rax
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v17; // rax
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *fromTable; // r8
			  String *v19; // rax
			  String *v20; // rax
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v21; // r8
			  __int64 v22; // rax
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v23; // rax
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *v24; // r8
			  String *v25; // rax
			  String *v26; // rax
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings *settingImpl; // rax
			  String *v28; // rax
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v29; // r8
			  __int64 v30; // rax
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v31; // rax
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *v32; // r8
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v33; // r8
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v34; // rax
			  String *v35; // rax
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v36; // rsi
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *includeFrom; // rsi
			  __int64 v38; // rax
			  String__Array *v39; // rbx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  Enum v42; // [rsp+20h] [rbp-48h] BYREF
			  int32_t deviceType; // [rsp+30h] [rbp-38h]
			  Int32 v44; // [rsp+80h] [rbp+18h] BYREF
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3890, 0LL) )
			  {
			    m_paramLookupResult = this->fields.m_paramLookupResult;
			    v5 = (String *)"";
			    if ( !m_paramLookupResult )
			      goto LABEL_48;
			    paramSource = m_paramLookupResult->fields.paramSource;
			    if ( paramSource )
			    {
			      v7 = paramSource - 1;
			      if ( v7 )
			      {
			        v8 = v7 - 1;
			        if ( v8 )
			        {
			          v9 = v8 - 1;
			          if ( v9 )
			          {
			            m_paramLookupResult = (HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *)(unsigned int)(v9 - 1);
			            if ( (_DWORD)m_paramLookupResult )
			            {
			              if ( (_DWORD)m_paramLookupResult != 1 )
			                goto LABEL_36;
			              v10 = il2cpp_array_new_specific_1(TypeInfo::System::String, 5LL);
			              v11 = (String__Array *)v10;
			              if ( !v10 )
			                goto LABEL_48;
			              sub_180005370(v10, 0LL, "");
			              sub_180005370(v11, 1LL, "Something wrong with parameter:");
			              sub_180005370(v11, 2LL, this->fields._paramName_k__BackingField);
			              sub_180005370(v11, 3LL, " of feature:");
			              featureName_k__BackingField = this->fields._featureName_k__BackingField;
			              v13 = 4LL;
			              goto LABEL_11;
			            }
			            v15 = "Parameter override by code";
			LABEL_34:
			            v14 = System::String::Concat((String *)"", (String *)v15, 0LL);
			            goto LABEL_35;
			          }
			          v16 = il2cpp_array_new_specific_1(TypeInfo::System::String, 15LL);
			          v11 = (String__Array *)v16;
			          if ( !v16 )
			            goto LABEL_48;
			          sub_180005370(v16, 0LL, "");
			          sub_180005370(v11, 1LL, "Parameter exactly matched in table:");
			          v17 = this->fields.m_paramLookupResult;
			          if ( !v17 )
			            goto LABEL_48;
			          fromTable = v17->fields.fromTable;
			          if ( !fromTable )
			            goto LABEL_48;
			          sub_180005370(v11, 2LL, fromTable->fields.filePath);
			          sub_180005370(v11, 3LL, ".");
			          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			          sub_180005370(
			            v11,
			            4LL,
			            TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->static_fields->SETTING_EXT);
			          sub_180005370(v11, 5LL, "\n FeatureName:");
			          sub_180005370(v11, 6LL, this->fields._featureName_k__BackingField);
			          sub_180005370(v11, 7LL, "\n DeviceType:");
			          m_paramLookupResult = this->fields.m_paramLookupResult;
			          if ( !m_paramLookupResult )
			            goto LABEL_48;
			          v42.monitor = (MonitorData *)-1LL;
			          v42.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::HGDeviceType;
			          deviceType = m_paramLookupResult->fields.deviceType;
			          v19 = System::Enum::ToString(&v42, 0LL);
			          sub_180005370(v11, 8LL, v19);
			          sub_180005370(v11, 9LL, "\n Tier:");
			          m_paramLookupResult = this->fields.m_paramLookupResult;
			          if ( !m_paramLookupResult )
			            goto LABEL_48;
			          v20 = System::Int32::ToString((Int32 *)&m_paramLookupResult->fields.tier, 0LL);
			          sub_180005370(v11, 10LL, v20);
			          sub_180005370(v11, 11LL, "\n ParamName:");
			          sub_180005370(v11, 12LL, this->fields._paramName_k__BackingField);
			          sub_180005370(v11, 13LL, "\n Constrain:");
			          v21 = this->fields.m_paramLookupResult;
			          if ( !v21 )
			            goto LABEL_48;
			          featureName_k__BackingField = v21->fields.constrainString;
			          v13 = 14LL;
			        }
			        else
			        {
			          v22 = il2cpp_array_new_specific_1(TypeInfo::System::String, 17LL);
			          v11 = (String__Array *)v22;
			          if ( !v22 )
			            goto LABEL_48;
			          sub_180005370(v22, 0LL, "");
			          sub_180005370(v11, 1LL, "Closest parameter found in table:");
			          v23 = this->fields.m_paramLookupResult;
			          if ( !v23 )
			            goto LABEL_48;
			          v24 = v23->fields.fromTable;
			          if ( !v24 )
			            goto LABEL_48;
			          sub_180005370(v11, 2LL, v24->fields.filePath);
			          sub_180005370(v11, 3LL, ".");
			          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			          sub_180005370(
			            v11,
			            4LL,
			            TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->static_fields->SETTING_EXT);
			          sub_180005370(v11, 5LL, "\n FeatureName:");
			          sub_180005370(v11, 6LL, this->fields._featureName_k__BackingField);
			          sub_180005370(v11, 7LL, "\n DeviceType:");
			          m_paramLookupResult = this->fields.m_paramLookupResult;
			          if ( !m_paramLookupResult )
			            goto LABEL_48;
			          v42.monitor = (MonitorData *)-1LL;
			          v42.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::HGDeviceType;
			          deviceType = m_paramLookupResult->fields.deviceType;
			          v25 = System::Enum::ToString(&v42, 0LL);
			          sub_180005370(v11, 8LL, v25);
			          sub_180005370(v11, 9LL, "\n Tier:");
			          m_paramLookupResult = this->fields.m_paramLookupResult;
			          if ( !m_paramLookupResult )
			            goto LABEL_48;
			          v26 = System::Int32::ToString((Int32 *)&m_paramLookupResult->fields.tier, 0LL);
			          sub_180005370(v11, 10LL, v26);
			          sub_180005370(v11, 11LL, "\n Expected Tier:");
			          settingImpl = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(0LL);
			          if ( !settingImpl )
			            goto LABEL_48;
			          v44.m_value = settingImpl->fields._currentDeviceTier_k__BackingField;
			          v28 = System::Int32::ToString(&v44, 0LL);
			          sub_180005370(v11, 12LL, v28);
			          sub_180005370(v11, 13LL, "\n ParamName:");
			          sub_180005370(v11, 14LL, this->fields._paramName_k__BackingField);
			          sub_180005370(v11, 15LL, "\n Constrain:");
			          v29 = this->fields.m_paramLookupResult;
			          if ( !v29 )
			            goto LABEL_48;
			          featureName_k__BackingField = v29->fields.constrainString;
			          v13 = 16LL;
			        }
			      }
			      else
			      {
			        v30 = il2cpp_array_new_specific_1(TypeInfo::System::String, 11LL);
			        v11 = (String__Array *)v30;
			        if ( !v30 )
			          goto LABEL_48;
			        sub_180005370(v30, 0LL, "");
			        sub_180005370(v11, 1LL, "Only default parameter found in table:");
			        v31 = this->fields.m_paramLookupResult;
			        if ( !v31 )
			          goto LABEL_48;
			        v32 = v31->fields.fromTable;
			        if ( !v32 )
			          goto LABEL_48;
			        sub_180005370(v11, 2LL, v32->fields.filePath);
			        sub_180005370(v11, 3LL, ".");
			        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			        sub_180005370(
			          v11,
			          4LL,
			          TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->static_fields->SETTING_EXT);
			        sub_180005370(v11, 5LL, "\n FeatureName:");
			        sub_180005370(v11, 6LL, this->fields._featureName_k__BackingField);
			        sub_180005370(v11, 7LL, "\n ParamName:");
			        sub_180005370(v11, 8LL, this->fields._paramName_k__BackingField);
			        sub_180005370(v11, 9LL, "\n Constrain:");
			        v33 = this->fields.m_paramLookupResult;
			        if ( !v33 )
			          goto LABEL_48;
			        featureName_k__BackingField = v33->fields.constrainString;
			        v13 = 10LL;
			      }
			LABEL_11:
			      sub_180005370(v11, v13, featureName_k__BackingField);
			      v14 = System::String::Concat(v11, 0LL);
			LABEL_35:
			      v5 = v14;
			LABEL_36:
			      v34 = this->fields.m_paramLookupResult;
			      if ( v34 )
			      {
			        if ( v34->fields.paramSource != 1 && v34->fields.paramSource != 2 && v34->fields.paramSource != 3 )
			          return v5;
			        v35 = System::String::Concat(v5, (String *)"\nInclude Chain:", 0LL);
			        v36 = this->fields.m_paramLookupResult;
			        v5 = v35;
			        if ( v36 )
			        {
			          includeFrom = v36->fields.fromTable;
			          if ( includeFrom )
			          {
			            while ( 1 )
			            {
			              includeFrom = includeFrom->fields.includeFrom;
			              if ( !includeFrom )
			                return v5;
			              v38 = il2cpp_array_new_specific_1(TypeInfo::System::String, 5LL);
			              v39 = (String__Array *)v38;
			              if ( !v38 )
			                break;
			              sub_180005370(v38, 0LL, v5);
			              sub_180005370(v39, 1LL, "\n Include from:");
			              sub_180005370(v39, 2LL, includeFrom->fields.filePath);
			              sub_180005370(v39, 3LL, ".");
			              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			              sub_180005370(
			                v39,
			                4LL,
			                TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->static_fields->SETTING_EXT);
			              v5 = System::String::Concat(v39, 0LL);
			            }
			          }
			        }
			      }
			LABEL_48:
			      sub_1800D8260(m_paramLookupResult, v3);
			    }
			    v15 = "No such parameter in table, use value in code instead";
			    goto LABEL_34;
			  }
			  Patch = IFix::WrappersManagerImpl::GetPatch(3890, 0LL);
			  if ( !Patch )
			    goto LABEL_48;
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
			}
			
			private void AcquireParamValueInSettingTable(ref ParamLookupResult paramLookupResult) {} // 0x000000018383D2E0-0x000000018383D600
			// Void AcquireParamValueInSettingTable(HGRenderPipelineSettingHub+SettingParameterBase+ParamLookupResult ByRef)
			void HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::AcquireParamValueInSettingTable(
			        HGRenderPipelineSettingHub_SettingParameterBase *this,
			        HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult **paramLookupResult,
			        MethodInfo *method)
			{
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult **v4; // r14
			  struct ILFixDynamicMethodWrapper_2__Class *entries; // rcx
			  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
			  __int64 v7; // rbx
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings *settingImpl; // rax
			  int32_t currentDeviceType_k__BackingField; // r12d
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v10; // rax
			  Dictionary_2_System_String_System_Int32_ *overrideFeatureSettingTiers; // rax
			  Object *featureName_k__BackingField; // r15
			  Dictionary_2_System_Object_System_Int32_ *v13; // rdi
			  struct MethodInfo *v14; // rbp
			  int32_t Entry; // eax
			  int32_t currentDeviceTier_k__BackingField; // edx
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v17; // rax
			  struct HGRenderPipelineSettingHub_ConstantStrings__Class *v18; // rax
			  String *paramName_k__BackingField; // rdi
			  String *v20; // rax
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo *Param_24_0; // rax
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo *v22; // rsi
			  List_1_System_Int32_ *tiers; // rbp
			  Predicate_1_Int32Enum_ *v24; // rax
			  Predicate_1_Int32_ *v25; // rdi
			  int32_t v26; // edi
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v27; // rax
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v28; // rbx
			  PassConstructorID__Enum__Array *v29; // r8
			  Int32__Array **v30; // r9
			  HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v31; // rbx
			  PassConstructorID__Enum__Array *v32; // r8
			  Int32__Array **v33; // r9
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue v35; // [rsp+20h] [rbp-28h] BYREF
			
			  v4 = paramLookupResult;
			  entries = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
			    entries = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			  }
			  wrapperArray = entries->static_fields->wrapperArray;
			  if ( !wrapperArray )
			    goto LABEL_40;
			  if ( wrapperArray->max_length.size > 597 )
			  {
			    if ( !entries->_1.cctor_finished_or_no_cctor )
			    {
			      il2cpp_runtime_class_init_1(entries);
			      entries = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			    }
			    paramLookupResult = (HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult **)entries->static_fields->wrapperArray;
			    if ( !paramLookupResult )
			      goto LABEL_40;
			    if ( *((_DWORD *)paramLookupResult + 6) <= 0x255u )
			      goto LABEL_41;
			    if ( paramLookupResult[601] )
			    {
			      Patch = IFix::WrappersManagerImpl::GetPatch(597, 0LL);
			      if ( Patch )
			      {
			        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_244(Patch, (Object *)this, v4, 0LL);
			        return;
			      }
			      goto LABEL_40;
			    }
			  }
			  v7 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_SettingParameterBase::__c__DisplayClass24_0);
			  if ( !v7 )
			    goto LABEL_40;
			  settingImpl = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(0LL);
			  if ( !settingImpl )
			    goto LABEL_40;
			  currentDeviceType_k__BackingField = settingImpl->fields._currentDeviceType_k__BackingField;
			  v10 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(0LL);
			  if ( !v10 )
			    goto LABEL_40;
			  overrideFeatureSettingTiers = HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_overrideFeatureSettingTiers(
			                                  v10,
			                                  0LL);
			  featureName_k__BackingField = (Object *)this->fields._featureName_k__BackingField;
			  v13 = (Dictionary_2_System_Object_System_Int32_ *)overrideFeatureSettingTiers;
			  if ( !overrideFeatureSettingTiers )
			    goto LABEL_40;
			  v14 = MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue;
			  if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy
			        + 4) )
			    (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue->klass->rgctx_data[22].rgctxDataDummy)();
			  Entry = System::Collections::Generic::Dictionary<System::Object,int>::FindEntry(
			            v13,
			            featureName_k__BackingField,
			            (MethodInfo *)v14->klass->rgctx_data[22].rgctxDataDummy);
			  if ( Entry >= 0 )
			  {
			    entries = (struct ILFixDynamicMethodWrapper_2__Class *)v13->fields._entries;
			    if ( !entries )
			      goto LABEL_40;
			    if ( (unsigned int)Entry < LODWORD(entries->_0.namespaze) )
			    {
			      currentDeviceTier_k__BackingField = *(&entries->_0.this_arg.data.__klassIndex + 6 * Entry);
			      goto LABEL_17;
			    }
			LABEL_41:
			    sub_1800D2AB0(entries, paramLookupResult);
			  }
			  v17 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(0LL);
			  if ( !v17 )
			    goto LABEL_40;
			  currentDeviceTier_k__BackingField = v17->fields._currentDeviceTier_k__BackingField;
			LABEL_17:
			  *(_DWORD *)(v7 + 16) = currentDeviceTier_k__BackingField;
			  v18 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
			  paramName_k__BackingField = this->fields._paramName_k__BackingField;
			  if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings->_1.cctor_finished_or_no_cctor )
			  {
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
			    v18 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
			  }
			  v20 = System::String::Concat(
			          paramName_k__BackingField,
			          v18->static_fields->ARRAY_CONCATENATE_STR,
			          this->fields._featureName_k__BackingField,
			          0LL);
			  Param_24_0 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::_AcquireParamValueInSettingTable_g___FindParam_24_0(
			                 v20,
			                 *(_DWORD *)(v7 + 16),
			                 0LL);
			  v22 = Param_24_0;
			  if ( Param_24_0 )
			  {
			    tiers = Param_24_0->fields.tiers;
			    v24 = (Predicate_1_Int32Enum_ *)sub_1800368D0(TypeInfo::System::Predicate<int>);
			    v25 = (Predicate_1_Int32_ *)v24;
			    if ( !v24 )
			      goto LABEL_40;
			    System::Predicate<System::Int32Enum>::Predicate(
			      v24,
			      (Object *)v7,
			      MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_SettingParameterBase::__c__DisplayClass24_0::_AcquireParamValueInSettingTable_b__1,
			      0LL);
			    if ( !tiers )
			      goto LABEL_40;
			    v26 = System::Collections::Generic::List<int>::Find(
			            tiers,
			            v25,
			            MethodInfo::System::Collections::Generic::List<int>::Find);
			    if ( v26 )
			    {
			      v27 = *v4;
			      if ( v26 == *(_DWORD *)(v7 + 16) )
			      {
			        if ( !v27 )
			          goto LABEL_40;
			        v27->fields.paramSource = 3;
			      }
			      else
			      {
			        if ( !v27 )
			          goto LABEL_40;
			        v27->fields.paramSource = 2;
			      }
			      goto LABEL_27;
			    }
			    entries = (struct ILFixDynamicMethodWrapper_2__Class *)v22->fields.tierValues;
			    if ( entries )
			    {
			      if ( !System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::ContainsKey(
			              (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *)entries,
			              0,
			              MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::ContainsKey) )
			        return;
			      if ( *v4 )
			      {
			        (*v4)->fields.paramSource = 1;
			LABEL_27:
			        paramLookupResult = (HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult **)v22->fields.tierValues;
			        v28 = *v4;
			        if ( paramLookupResult )
			        {
			          System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::get_Item(
			            &v35,
			            (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *)paramLookupResult,
			            v26,
			            MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::get_Item);
			          if ( v28 )
			          {
			            v28->fields.fromTable = v35.from;
			            sub_18002D1B0(
			              (HGRenderPathScene *)&v28->fields.fromTable,
			              (HGRenderPathBase_HGRenderPathResources *)paramLookupResult,
			              v29,
			              v30,
			              (MethodInfo *)v35.from,
			              (MethodInfo *)v35.value);
			            if ( *v4 )
			            {
			              (*v4)->fields.tier = v26;
			              if ( *v4 )
			              {
			                (*v4)->fields.deviceType = currentDeviceType_k__BackingField;
			                paramLookupResult = (HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult **)v22->fields.tierValues;
			                v31 = *v4;
			                if ( paramLookupResult )
			                {
			                  System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::get_Item(
			                    &v35,
			                    (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *)paramLookupResult,
			                    v26,
			                    MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::get_Item);
			                  if ( v31 )
			                  {
			                    v31->fields.value = v35.value;
			                    sub_18002D1B0(
			                      (HGRenderPathScene *)&v31->fields,
			                      (HGRenderPathBase_HGRenderPathResources *)paramLookupResult,
			                      v32,
			                      v33,
			                      (MethodInfo *)v35.from,
			                      (MethodInfo *)v35.value);
			                    return;
			                  }
			                }
			              }
			            }
			          }
			        }
			      }
			    }
			LABEL_40:
			    sub_1800D8260(entries, paramLookupResult);
			  }
			}
			
		}
	
		// Constructors
		private HGRenderPipelineSettingHub() {} // 0x0000000184640A20-0x0000000184640A90
	
		// Methods
		private SettingDataProcessResult LayerProcess(SettingConfigChange change, SettingConfigChangeData newSettingData) => default; // 0x0000000183C90BF0-0x0000000183C90C40
		// SettingDataProcessResult LayerProcess(SettingConfigChange, SettingConfigChangeData)
		SettingDataProcessResult__Enum HG::Rendering::Runtime::HGRenderPipelineSettingHub::LayerProcess(
		        HGRenderPipelineSettingHub *this,
		        SettingConfigChange__Enum change,
		        SettingConfigChangeData *newSettingData,
		        MethodInfo *method)
		{
		  HGRenderPathBase_HGRenderPathResources *v7; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v9; // rcx
		  Dictionary_2_System_String_System_Int32_ *overrideFeatureSettingTiers; // rax
		  PassConstructorID__Enum__Array *v11; // r8
		  Int32__Array **v12; // r9
		  int32_t currentDeviceTier_k__BackingField; // eax
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v14; // rax
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v16; // rax
		  ISettingDataProcessLayer *m_layer; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v19; // [rsp+20h] [rbp-48h]
		  MethodInfo *v20; // [rsp+28h] [rbp-40h]
		  int32_t value; // [rsp+30h] [rbp-38h] BYREF
		  __int128 v22; // [rsp+38h] [rbp-30h] BYREF
		  SettingConfigChangeData v23; // [rsp+50h] [rbp-18h] BYREF
		
		  value = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3823, 0LL) )
		  {
		    if ( !this->fields.m_layer )
		      return 0;
		    v9 = (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)change;
		    v22 = 0LL;
		    if ( change )
		    {
		      v9 = (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)(change - 1);
		      if ( change == SettingConfigChange__Enum_SettingTierChange )
		      {
		        m_impl = this->fields.m_impl;
		        if ( !m_impl )
		          goto LABEL_22;
		        DWORD1(v22) = m_impl->fields._currentDeviceTier_k__BackingField;
		      }
		      else if ( change == SettingConfigChange__Enum_FeatureTierChange )
		      {
		        v9 = this->fields.m_impl;
		        if ( !v9 )
		          goto LABEL_22;
		        overrideFeatureSettingTiers = HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_overrideFeatureSettingTiers(
		                                        v9,
		                                        0LL);
		        if ( !overrideFeatureSettingTiers )
		          goto LABEL_22;
		        if ( System::Collections::Generic::Dictionary<System::Object,int>::TryGetValue(
		               (Dictionary_2_System_Object_System_Int32_ *)overrideFeatureSettingTiers,
		               (Object *)newSettingData->featureName,
		               &value,
		               MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue) )
		        {
		          currentDeviceTier_k__BackingField = value;
		        }
		        else
		        {
		          v14 = this->fields.m_impl;
		          if ( !v14 )
		            goto LABEL_22;
		          currentDeviceTier_k__BackingField = v14->fields._currentDeviceTier_k__BackingField;
		        }
		        DWORD1(v22) = currentDeviceTier_k__BackingField;
		        *((_QWORD *)&v22 + 1) = newSettingData->featureName;
		        sub_18002D1B0((HGRenderPathScene *)((char *)&v22 + 8), v7, v11, v12, v19, v20);
		      }
		    }
		    else
		    {
		      v16 = this->fields.m_impl;
		      if ( !v16 )
		        goto LABEL_22;
		      LODWORD(v22) = v16->fields._currentDeviceType_k__BackingField;
		    }
		    m_layer = this->fields.m_layer;
		    if ( m_layer )
		      return (unsigned int)sub_18026B610(
		                             (_DWORD)v9,
		                             (_DWORD)v7,
		                             (_DWORD)m_layer,
		                             change,
		                             (__int64)newSettingData,
		                             (__int64)&v22);
		LABEL_22:
		    sub_1800D8260(v9, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3823, 0LL);
		  if ( !Patch )
		    goto LABEL_22;
		  v23 = *newSettingData;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1356(Patch, (Object *)this, change, &v23, 0LL);
		}
		
		internal bool RegisterSettingDataProcessLayer(ISettingDataProcessLayer layer) => default; // 0x0000000189C13978-0x0000000189C139E8
		internal bool UnRegisterSettingDataProcessLayer(ISettingDataProcessLayer layer) => default; // 0x0000000189C13C84-0x0000000189C13CF4
		internal void Reset() {} // 0x0000000189C13C28-0x0000000189C13C84
		// Void Reset()
		void HG::Rendering::Runtime::HGRenderPipelineSettingHub::Reset(HGRenderPipelineSettingHub *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3829, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		    {
		      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::Initialize(
		        m_impl,
		        HGDeviceType__Enum_Unknown,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_impl, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3829, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal void RefreshDirtySettings() {} // 0x00000001830637C0-0x0000000183063830
		// Void RefreshDirtySettings()
		void HG::Rendering::Runtime::HGRenderPipelineSettingHub::RefreshDirtySettings(
		        HGRenderPipelineSettingHub *this,
		        MethodInfo *method)
		{
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
		  Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo___Class *klass; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  m_impl = (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_impl = (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  klass = m_impl[1].fields.m_paramLookupTable->klass;
		  if ( !klass )
		    goto LABEL_7;
		  if ( SLODWORD(klass->_0.namespaze) <= 592 )
		    goto LABEL_5;
		  if ( !m_impl[1].fields.minimumDeviceTier )
		  {
		    il2cpp_runtime_class_init_1(m_impl);
		    m_impl = (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_impl = (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)m_impl[1].fields.m_paramLookupTable->klass;
		  if ( !m_impl )
		    goto LABEL_7;
		  if ( m_impl->fields._currentDeviceType_k__BackingField <= 0x250u )
		    sub_1800D2AB0(m_impl, klass);
		  if ( !m_impl[39].fields.parameterTablePath )
		  {
		LABEL_5:
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		    {
		      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshDirtySettings(m_impl, 0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(m_impl, klass);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(592, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal void ResetRegisteredParameters() {} // 0x0000000189C13B64-0x0000000189C13BBC
		// Void ResetRegisteredParameters()
		void HG::Rendering::Runtime::HGRenderPipelineSettingHub::ResetRegisteredParameters(
		        HGRenderPipelineSettingHub *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3855, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		    {
		      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetRegisteredParameters(
		        m_impl,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_impl, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3855, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void FeedSettingData(Dictionary<string, string> settingData) {} // 0x00000001835825F0-0x0000000183582640
		// Void FeedSettingData(Dictionary`2[System.String,System.String])
		void HG::Rendering::Runtime::HGRenderPipelineSettingHub::FeedSettingData(
		        HGRenderPipelineSettingHub *this,
		        Dictionary_2_System_String_System_String_ *settingData,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3860, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		    {
		      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FeedSettingData(
		        m_impl,
		        settingData,
		        0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(m_impl, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3860, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)settingData,
		    0LL);
		}
		
		public SettingDataProcessResult ChangeSettingTier(int tier) => default; // 0x0000000183C908B0-0x0000000183C90950
		// SettingDataProcessResult ChangeSettingTier(Int32)
		SettingDataProcessResult__Enum HG::Rendering::Runtime::HGRenderPipelineSettingHub::ChangeSettingTier(
		        HGRenderPipelineSettingHub *this,
		        int32_t tier,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  SettingDataProcessResult__Enum v7; // edi
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v8; // rcx
		  SettingDataProcessResult__Enum result; // eax
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
		  ISettingDataProcessLayer *m_layer; // r8
		  ILFixDynamicMethodWrapper_2 *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  SettingConfigChangeData v14; // [rsp+30h] [rbp-38h] BYREF
		  SettingConfigChangeData v15; // [rsp+40h] [rbp-28h] BYREF
		  SettingConfigChangeData v16; // [rsp+50h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3861, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3861, 0LL);
		    if ( !Patch )
		      goto LABEL_7;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
		             (ILFixDynamicMethodWrapper_29 *)Patch,
		             (Object *)this,
		             tier,
		             0LL);
		  }
		  v14 = 0LL;
		  v14.settingTier = tier;
		  v15 = v14;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3823, 0LL) )
		  {
		    if ( !this->fields.m_layer )
		    {
		      v7 = SettingDataProcessResult__Enum_Succeed;
		      goto LABEL_5;
		    }
		    v14 = 0LL;
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		    {
		      v14.settingTier = m_impl->fields._currentDeviceTier_k__BackingField;
		      m_layer = this->fields.m_layer;
		      if ( m_layer )
		      {
		        result = (unsigned int)sub_18026B610(v6, v5, (_DWORD)m_layer, 1, (__int64)&v15, (__int64)&v14);
		        goto LABEL_8;
		      }
		    }
		LABEL_15:
		    sub_1800D8260(v6, v5);
		  }
		  v12 = IFix::WrappersManagerImpl::GetPatch(3823, 0LL);
		  if ( !v12 )
		    goto LABEL_15;
		  v16 = v15;
		  result = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1356(
		             v12,
		             (Object *)this,
		             SettingConfigChange__Enum_SettingTierChange,
		             &v16,
		             0LL);
		LABEL_8:
		  v7 = result;
		  if ( result != SettingDataProcessResult__Enum_DataBlocked )
		  {
		LABEL_5:
		    v8 = this->fields.m_impl;
		    if ( v8 )
		    {
		      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ChangeSettingTier(v8, tier, 0LL);
		      return v7;
		    }
		LABEL_7:
		    sub_1800D8260(v8, v5);
		  }
		  return result;
		}
		
		public SettingDataProcessResult OverrideFeatureTier(string featureName, int tier) => default; // 0x0000000183C90B30-0x0000000183C90BF0
		// SettingDataProcessResult OverrideFeatureTier(String, Int32)
		SettingDataProcessResult__Enum HG::Rendering::Runtime::HGRenderPipelineSettingHub::OverrideFeatureTier(
		        HGRenderPipelineSettingHub *this,
		        String *featureName,
		        int32_t tier,
		        MethodInfo *method)
		{
		  HGRenderPathBase_HGRenderPathResources *v7; // rdx
		  PassConstructorID__Enum__Array *v8; // r8
		  Int32__Array **v9; // r9
		  SettingDataProcessResult__Enum v10; // ebx
		  HGRenderPathBase_HGRenderPathResources *v11; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v12; // rcx
		  SettingDataProcessResult__Enum result; // eax
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
		  Dictionary_2_System_String_System_Int32_ *overrideFeatureSettingTiers; // rax
		  PassConstructorID__Enum__Array *v16; // r8
		  Int32__Array **v17; // r9
		  int32_t currentDeviceTier_k__BackingField; // eax
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v19; // rax
		  ISettingDataProcessLayer *m_layer; // r8
		  ILFixDynamicMethodWrapper_2 *v21; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-68h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-68h]
		  MethodInfo *v25; // [rsp+28h] [rbp-60h]
		  MethodInfo *v26; // [rsp+28h] [rbp-60h]
		  int32_t value[4]; // [rsp+30h] [rbp-58h] BYREF
		  __m128i v28; // [rsp+40h] [rbp-48h] BYREF
		  _DWORD v29[2]; // [rsp+50h] [rbp-38h] BYREF
		  __int64 v30; // [rsp+58h] [rbp-30h] BYREF
		  __m128i v31; // [rsp+60h] [rbp-28h] BYREF
		  __m128i v32; // [rsp+70h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3864, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3864, 0LL);
		    if ( !Patch )
		      goto LABEL_6;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1364(Patch, (Object *)this, (Object *)featureName, tier, 0LL);
		  }
		  v10 = SettingDataProcessResult__Enum_Succeed;
		  v28.m128i_i32[1] = tier;
		  v28.m128i_i32[0] = 0;
		  v28.m128i_i64[1] = (__int64)featureName;
		  sub_18002D1B0((HGRenderPathScene *)&v28.m128i_u64[1], v7, v8, v9, methoda, v25);
		  v31 = v28;
		  value[0] = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3823, 0LL) )
		  {
		    if ( !this->fields.m_layer )
		      goto LABEL_4;
		    v29[0] = 0;
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		    {
		      overrideFeatureSettingTiers = HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_overrideFeatureSettingTiers(
		                                      m_impl,
		                                      0LL);
		      if ( overrideFeatureSettingTiers )
		      {
		        if ( System::Collections::Generic::Dictionary<System::Object,int>::TryGetValue(
		               (Dictionary_2_System_Object_System_Int32_ *)overrideFeatureSettingTiers,
		               (Object *)_mm_srli_si128(v31, 8).m128i_i64[0],
		               value,
		               MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue) )
		        {
		          currentDeviceTier_k__BackingField = value[0];
		        }
		        else
		        {
		          v19 = this->fields.m_impl;
		          if ( !v19 )
		            goto LABEL_19;
		          currentDeviceTier_k__BackingField = v19->fields._currentDeviceTier_k__BackingField;
		        }
		        v29[1] = currentDeviceTier_k__BackingField;
		        v30 = v31.m128i_i64[1];
		        sub_18002D1B0((HGRenderPathScene *)&v30, v11, v16, v17, methodb, v26);
		        m_layer = this->fields.m_layer;
		        if ( m_layer )
		        {
		          result = (unsigned int)sub_18026B610(
		                                   (_DWORD)m_impl,
		                                   (_DWORD)v11,
		                                   (_DWORD)m_layer,
		                                   2,
		                                   (__int64)&v31,
		                                   (__int64)v29);
		          goto LABEL_7;
		        }
		      }
		    }
		LABEL_19:
		    sub_1800D8260(m_impl, v11);
		  }
		  v21 = IFix::WrappersManagerImpl::GetPatch(3823, 0LL);
		  if ( !v21 )
		    goto LABEL_19;
		  v32 = v31;
		  result = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1356(
		             v21,
		             (Object *)this,
		             SettingConfigChange__Enum_FeatureTierChange,
		             (SettingConfigChangeData *)&v32,
		             0LL);
		LABEL_7:
		  v10 = result;
		  if ( result != SettingDataProcessResult__Enum_DataBlocked )
		  {
		LABEL_4:
		    v12 = this->fields.m_impl;
		    if ( v12 )
		    {
		      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::OverrideFeatureTier(
		        v12,
		        featureName,
		        tier,
		        0LL);
		      return v10;
		    }
		LABEL_6:
		    sub_1800D8260(v12, v11);
		  }
		  return result;
		}
		
		public SettingDataProcessResult ResetFeatureTier(string featureName) => default; // 0x0000000189C13AB0-0x0000000189C13B64
		// SettingDataProcessResult ResetFeatureTier(String)
		SettingDataProcessResult__Enum HG::Rendering::Runtime::HGRenderPipelineSettingHub::ResetFeatureTier(
		        HGRenderPipelineSettingHub *this,
		        String *featureName,
		        MethodInfo *method)
		{
		  HGRenderPathBase_HGRenderPathResources *v5; // rdx
		  PassConstructorID__Enum__Array *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rdx
		  SettingDataProcessResult__Enum v9; // esi
		  SettingDataProcessResult__Enum result; // eax
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  SettingConfigChangeData v13; // [rsp+20h] [rbp-28h] BYREF
		  SettingConfigChangeData v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3866, 0LL) )
		  {
		    v13.featureName = featureName;
		    ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, Int32__Array **, MethodInfo *))sub_18002D1B0)(
		      (HGRenderPathScene *)&v13.featureName,
		      v5,
		      v6,
		      v7,
		      0LL);
		    v14 = v13;
		    v9 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::LayerProcess(
		           this,
		           SettingConfigChange__Enum_FeatureTierReset,
		           &v14,
		           0LL);
		    result = SettingDataProcessResult__Enum_DataBlocked;
		    if ( v9 == SettingDataProcessResult__Enum_DataBlocked )
		      return result;
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		    {
		      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetFeatureTier(
		        m_impl,
		        featureName,
		        0LL);
		      return v9;
		    }
		LABEL_6:
		    sub_1800D8260(m_impl, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3866, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_120(
		           (ILFixDynamicMethodWrapper_18 *)Patch,
		           (ClientSingleMapMarkData *)this,
		           (ClientSingleMapMarkData *)featureName,
		           0LL);
		}
		
		public void RegisterSettingChangeCallback(string featureName, OnSettingChanged callback) {} // 0x0000000183949210-0x0000000183949270
		// Void RegisterSettingChangeCallback(String, HGRenderPipelineSettingHub+OnSettingChanged)
		void HG::Rendering::Runtime::HGRenderPipelineSettingHub::RegisterSettingChangeCallback(
		        HGRenderPipelineSettingHub *this,
		        String *featureName,
		        HGRenderPipelineSettingHub_OnSettingChanged *callback,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(475, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		    {
		      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RegisterSettingChangeCallback(
		        m_impl,
		        featureName,
		        callback,
		        0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(m_impl, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(475, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)this,
		    (Object *)featureName,
		    (Object *)callback,
		    0LL);
		}
		
		public bool IsForceSRPShader(string shader) => default; // 0x0000000189C13828-0x0000000189C138A0
		// Boolean IsForceSRPShader(String)
		bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::IsForceSRPShader(
		        HGRenderPipelineSettingHub *this,
		        String *shader,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HashSet_1_System_Object_ *forceSRPShaders; // rcx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3868, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		    {
		      forceSRPShaders = (HashSet_1_System_Object_ *)m_impl->fields.forceSRPShaders;
		      if ( forceSRPShaders )
		        return System::Collections::Generic::HashSet<System::Object>::Contains(
		                 forceSRPShaders,
		                 (Object *)shader,
		                 MethodInfo::System::Collections::Generic::HashSet<System::String>::Contains);
		    }
		LABEL_6:
		    sub_1800D8260(forceSRPShaders, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3868, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)Patch,
		           (Object *)this,
		           (Object *)shader,
		           0LL);
		}
		
		public string PrintTierInfo() => default; // 0x0000000189C13920-0x0000000189C13978
		// String PrintTierInfo()
		String *HG::Rendering::Runtime::HGRenderPipelineSettingHub::PrintTierInfo(
		        HGRenderPipelineSettingHub *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3869, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		      return HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PrintTierInfo(m_impl, 0LL);
		LABEL_5:
		    sub_1800D8260(m_impl, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3869, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public void SetPlatformVariant(string variant) {} // 0x0000000183582590-0x00000001835825F0
		public void ReloadSettingData() {} // 0x0000000189C139E8-0x0000000189C13A58
		// Void ReloadSettingData()
		void HG::Rendering::Runtime::HGRenderPipelineSettingHub::ReloadSettingData(
		        HGRenderPipelineSettingHub *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rdi
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *v5; // rcx
		  Dictionary_2_System_String_System_String_ *settingData; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3873, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    v5 = m_impl;
		    if ( m_impl )
		    {
		      settingData = HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_settingData(
		                      m_impl,
		                      0LL);
		      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FeedSettingData(
		        m_impl,
		        settingData,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3873, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public bool OverrideSettingParameter(string paramName, string paramValue) => default; // 0x0000000189C138A0-0x0000000189C13920
		// Boolean OverrideSettingParameter(String, String)
		bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::OverrideSettingParameter(
		        HGRenderPipelineSettingHub *this,
		        String *paramName,
		        String *paramValue,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3875, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		      return HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::OverrideSettingParameter(
		               m_impl,
		               paramName,
		               paramValue,
		               0LL);
		LABEL_5:
		    sub_1800D8260(m_impl, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3875, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(
		           (ILFixDynamicMethodWrapper_20 *)Patch,
		           (Object *)this,
		           (Object *)paramName,
		           (Object *)paramValue,
		           0LL);
		}
		
		public bool ResetSettingParameter(string paramName) => default; // 0x0000000189C13BBC-0x0000000189C13C28
		// Boolean ResetSettingParameter(String)
		bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::ResetSettingParameter(
		        HGRenderPipelineSettingHub *this,
		        String *paramName,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3878, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		      return HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetRegisteredParameter(
		               m_impl,
		               paramName,
		               0LL);
		LABEL_5:
		    sub_1800D8260(m_impl, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3878, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)Patch,
		           (Object *)this,
		           (Object *)paramName,
		           0LL);
		}
		
		public void ResetAllSettingParameters() {} // 0x0000000189C13A58-0x0000000189C13AB0
		// Void ResetAllSettingParameters()
		void HG::Rendering::Runtime::HGRenderPipelineSettingHub::ResetAllSettingParameters(
		        HGRenderPipelineSettingHub *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3880, 0LL) )
		  {
		    m_impl = this->fields.m_impl;
		    if ( m_impl )
		    {
		      HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetRegisteredParameters(
		        m_impl,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_impl, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3880, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
