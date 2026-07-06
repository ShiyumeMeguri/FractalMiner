using System;
using IFix.Core;

namespace HG.Rendering.Runtime
{
	public static class HGGrassSettings
	{
		[IDTag(0)]
		public static void OnGrassGlobalSparsityChanged(bool enabled)
		{
			// // Void OnGrassGlobalSparsityChanged(Boolean)
			// void HG::Rendering::Runtime::HGGrassSettings::OnGrassGlobalSparsityChanged(bool enabled, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct HGGrassSettings__Class *v4; // rax
			//   HGGrassSettingParameters *s_parameters; // rcx
			//   float v6; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED9B8 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGrassSettings);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     byte_18D8ED9B8 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(460, 0LL) )
			//   {
			//     v4 = TypeInfo::HG::Rendering::Runtime::HGGrassSettings;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGGrassSettings._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGGrassSettings, v3);
			//       v4 = TypeInfo::HG::Rendering::Runtime::HGGrassSettings;
			//     }
			//     s_parameters = v4.static_fields.s_parameters;
			//     if ( s_parameters )
			//     {
			//       v6 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//              s_parameters.fields.grassGlobalSparsity,
			//              MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//       UnityEngine::HyperGryph::HGGrassRender::set_grassGlobalSparsity(v6, 0LL);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(s_parameters, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(460, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_28 *)Patch, enabled, 0LL);
			// }
			// 
		}

		[IDTag(1)]
		public static void OnGrassGlobalSparsityChanged(float oldValue, float newValue)
		{
			// // Void OnGrassGlobalSparsityChanged(Single, Single)
			// void HG::Rendering::Runtime::HGGrassSettings::OnGrassGlobalSparsityChanged(
			//         float oldValue,
			//         float newValue,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D91944E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGrassSettings);
			//     byte_18D91944E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2194, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2194, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_801(Patch, oldValue, newValue, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGrassSettings);
			//     HG::Rendering::Runtime::HGGrassSettings::OnGrassGlobalSparsityChanged(1, 0LL);
			//   }
			// }
			// 
		}

		public static void OnGrassSettingsChanged(HGDeviceType deviceType, int tier)
		{
			// // Void OnGrassSettingsChanged(HGDeviceType, Int32)
			// void HG::Rendering::Runtime::HGGrassSettings::OnGrassSettingsChanged(
			//         HGDeviceType__Enum deviceType,
			//         int32_t tier,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D8ED9B9 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGrassSettings);
			//     byte_18D8ED9B9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(459, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(459, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_396(Patch, deviceType, tier, 0LL);
			//   }
			//   else
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGGrassSettings._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGGrassSettings, v5);
			//     HG::Rendering::Runtime::HGGrassSettings::OnGrassGlobalSparsityChanged(1, 0LL);
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly HGGrassSettingParameters s_parameters;
	}
}
