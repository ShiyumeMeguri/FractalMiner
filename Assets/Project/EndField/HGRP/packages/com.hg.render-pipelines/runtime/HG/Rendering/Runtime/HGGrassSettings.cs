using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGGrassSettings // TypeDefIndex: 37997
	{
		// Fields
		public static readonly HGGrassSettingParameters s_parameters; // 0x00
	
		// Constructors
		static HGGrassSettings() {} // 0x0000000184D14BE0-0x0000000184D14C40
		// HGGrassSettings()
		void HG::Rendering::Runtime::HGGrassSettings::cctor(MethodInfo *method)
		{
		  HGGrassSettingParameters *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  HGGrassSettingParameters *v4; // rbx
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // [rsp+50h] [rbp+28h]
		
		  v1 = (HGGrassSettingParameters *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGGrassSettingParameters);
		  v4 = v1;
		  if ( !v1 )
		    sub_1800D8260(v3, v2);
		  HG::Rendering::Runtime::HGGrassSettingParameters::HGGrassSettingParameters(v1, 0LL);
		  TypeInfo::HG::Rendering::Runtime::HGGrassSettings->static_fields->s_parameters = v4;
		  sub_18002D1B0((SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGGrassSettings->static_fields, v5, v6, v7, v8);
		}
		
	
		// Methods
		[IDTag(0)]
		public static void OnGrassGlobalSparsityChanged(bool enabled) {} // 0x00000001848E0DB0-0x00000001848E0E30
		// Void OnGrassGlobalSparsityChanged(Boolean)
		void HG::Rendering::Runtime::HGGrassSettings::OnGrassGlobalSparsityChanged(bool enabled, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct HGGrassSettings__Class *v4; // rax
		  HGGrassSettingParameters *s_parameters; // rcx
		  float v6; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(485, 0LL) )
		  {
		    v4 = TypeInfo::HG::Rendering::Runtime::HGGrassSettings;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGGrassSettings->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGGrassSettings);
		      v4 = TypeInfo::HG::Rendering::Runtime::HGGrassSettings;
		    }
		    s_parameters = v4->static_fields->s_parameters;
		    if ( s_parameters )
		    {
		      v6 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		             s_parameters->fields.grassGlobalSparsity,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		      UnityEngine::HyperGryph::HGGrassRender::set_grassGlobalSparsity(v6, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(s_parameters, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(485, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_30 *)Patch, enabled, 0LL);
		}
		
		[IDTag(1)]
		public static void OnGrassGlobalSparsityChanged(float oldValue, float newValue) {} // 0x0000000189B6B9AC-0x0000000189B6BA20
		// Void OnGrassGlobalSparsityChanged(Single, Single)
		void HG::Rendering::Runtime::HGGrassSettings::OnGrassGlobalSparsityChanged(
		        float oldValue,
		        float newValue,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2648, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2648, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_942(Patch, oldValue, newValue, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGrassSettings);
		    HG::Rendering::Runtime::HGGrassSettings::OnGrassGlobalSparsityChanged(1, 0LL);
		  }
		}
		
		public static void OnGrassSettingsChanged(HGDeviceType deviceType, int tier) {} // 0x00000001848E0D60-0x00000001848E0DB0
		// Void OnGrassSettingsChanged(HGDeviceType, Int32)
		void HG::Rendering::Runtime::HGGrassSettings::OnGrassSettingsChanged(
		        HGDeviceType__Enum deviceType,
		        int32_t tier,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(484, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(484, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_152(
		      (ILFixDynamicMethodWrapper_18 *)Patch,
		      (Skill_FinishType__Enum)deviceType,
		      tier,
		      0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGGrassSettings->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGGrassSettings);
		    HG::Rendering::Runtime::HGGrassSettings::OnGrassGlobalSparsityChanged(1, 0LL);
		  }
		}
		
	}
}
