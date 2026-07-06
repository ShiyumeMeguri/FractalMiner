using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IniParser;

namespace HG.Rendering.Runtime
{
	public class HGRenderPipelineSettingHub
	{
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x000025D2 File Offset: 0x000007D2
		private static HGRenderPipelineSettingHub.HGRenderPipelineSettings settingImpl
		{
			get
			{
				// // HGRenderPipelineSettingHub+HGRenderPipelineSettings get_settingImpl()
				// HGRenderPipelineSettingHub_HGRenderPipelineSettings *HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineSettingHub *instance; // rax
				//   __int64 v2; // rdx
				//   __int64 v3; // rcx
				// 
				//   instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
				//   if ( !instance )
				//     sub_180B536AC(v3, v2);
				//   return instance.fields.m_impl;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600141B RID: 5147 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool isMobileShader
		{
			get
			{
				// // Boolean get_isMobileShader()
				// bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_isMobileShader(
				//         HGRenderPipelineSettingHub *this,
				//         MethodInfo *method)
				// {
				//   return System::ComponentModel::AttributeCollection::get_Count((AttributeCollection *)this, 0LL) == 1;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x0600141C RID: 5148 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool isMobileHighShader
		{
			get
			{
				// // Boolean get_isMobileHighShader()
				// bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_isMobileHighShader(
				//         HGRenderPipelineSettingHub *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( !byte_18D9196E1 )
				//   {
				//     sub_18003C530(&TypeInfo::Beyond::Rendering::HGShaderQualitySettings);
				//     byte_18D9196E1 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(3220, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3220, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v6, v5);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				//   }
				//   else if ( System::ComponentModel::AttributeCollection::get_Count((AttributeCollection *)this, 0LL) == 1 )
				//   {
				//     sub_180002C70(TypeInfo::Beyond::Rendering::HGShaderQualitySettings);
				//     return TypeInfo::Beyond::Rendering::HGShaderQualitySettings.static_fields.HgShaderLod == 1;
				//   }
				//   else
				//   {
				//     return 0;
				//   }
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x0600141D RID: 5149 RVA: 0x000025D8 File Offset: 0x000007D8
		internal bool isMobileLowShader
		{
			get
			{
				// // Boolean get_isMobileLowShader()
				// bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_isMobileLowShader(
				//         HGRenderPipelineSettingHub *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( !byte_18D9196E2 )
				//   {
				//     sub_18003C530(&TypeInfo::Beyond::Rendering::HGShaderQualitySettings);
				//     byte_18D9196E2 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(3221, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3221, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v6, v5);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
				//   }
				//   else if ( System::ComponentModel::AttributeCollection::get_Count((AttributeCollection *)this, 0LL) == 1 )
				//   {
				//     sub_180002C70(TypeInfo::Beyond::Rendering::HGShaderQualitySettings);
				//     return TypeInfo::Beyond::Rendering::HGShaderQualitySettings.static_fields.HgShaderLod == 0;
				//   }
				//   else
				//   {
				//     return 0;
				//   }
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x0600141E RID: 5150 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGRenderPipelineSettingHub instance
		{
			get
			{
				return null;
			}
		}

		// (get) Token: 0x0600141F RID: 5151 RVA: 0x00002C20 File Offset: 0x00000E20
		public HGDeviceType currentDeviceType
		{
			get
			{
				// // Int32 get_Count()
				// int32_t System::ComponentModel::AttributeCollection::get_Count(AttributeCollection *this, MethodInfo *method)
				// {
				//   Attribute__Array *attributes; // rax
				// 
				//   attributes = this.fields._attributes;
				//   if ( !attributes )
				//     sub_180B536AC(this, method);
				//   return attributes.max_length.size;
				// }
				// 
				return (HGDeviceType)HGDeviceType.Unknown;
			}
		}

		// (get) Token: 0x06001420 RID: 5152 RVA: 0x00002608 File Offset: 0x00000808
		public int currentDeviceTier
		{
			get
			{
				// // Int32 get_currentDeviceTier()
				// int32_t HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceTier(
				//         HGRenderPipelineSettingHub *this,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
				// 
				//   m_impl = this.fields.m_impl;
				//   if ( !m_impl )
				//     sub_180B536AC(this, method);
				//   return m_impl.fields._currentDeviceTier_k__BackingField;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001421 RID: 5153 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x000025D0 File Offset: 0x000007D0
		public int maxDeviceTier
		{
			get
			{
				// // Int32 get_maxDeviceTier()
				// int32_t HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_maxDeviceTier(
				//         HGRenderPipelineSettingHub *this,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
				// 
				//   m_impl = this.fields.m_impl;
				//   if ( !m_impl )
				//     sub_180B536AC(this, method);
				//   return m_impl.fields.maximumDeviceTier;
				// }
				// 
				return 0;
			}
			set
			{
				// // Void set_maxDeviceTier(Int32)
				// // local variable allocation has failed, the output may be wrong!
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::set_maxDeviceTier(
				//         HGRenderPipelineSettingHub *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
				// 
				//   m_impl = this.fields.m_impl;
				//   if ( !m_impl )
				//     sub_180B536AC(this, *(_QWORD *)&value);
				//   m_impl.fields.maximumDeviceTier = value;
				// }
				// 
			}
		}

		private HGRenderPipelineSettingHub()
		{
		}

		private SettingDataProcessResult LayerProcess(SettingConfigChange change, SettingConfigChangeData newSettingData)
		{
			// // SettingDataProcessResult LayerProcess(SettingConfigChange, SettingConfigChangeData)
			// SettingDataProcessResult__Enum HG::Rendering::Runtime::HGRenderPipelineSettingHub::LayerProcess(
			//         HGRenderPipelineSettingHub *this,
			//         SettingConfigChange__Enum change,
			//         SettingConfigChangeData *newSettingData,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *v9; // rcx
			//   Dictionary_2_System_String_System_Int32_ *overrideFeatureSettingTiers; // rax
			//   PassConstructorID__Enum__Array *v11; // r8
			//   HGCamera *v12; // r9
			//   int32_t currentDeviceTier_k__BackingField; // eax
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *v14; // rax
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *v16; // rax
			//   ISettingDataProcessLayer *m_layer; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v19; // [rsp+20h] [rbp-48h]
			//   MethodInfo *v20; // [rsp+28h] [rbp-40h]
			//   int32_t value; // [rsp+30h] [rbp-38h] BYREF
			//   __int128 v22; // [rsp+38h] [rbp-30h] BYREF
			//   SettingConfigChangeData v23; // [rsp+50h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDB3B )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ISettingDataProcessLayer);
			//     byte_18D8EDB3B = 1;
			//   }
			//   value = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3219, 0LL) )
			//   {
			//     if ( !this.fields.m_layer )
			//       return 0;
			//     v9 = (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)change;
			//     v22 = 0LL;
			//     if ( change )
			//     {
			//       v9 = (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)(change - 1);
			//       if ( change == SettingConfigChange__Enum_SettingTierChange )
			//       {
			//         m_impl = this.fields.m_impl;
			//         if ( !m_impl )
			//           goto LABEL_24;
			//         DWORD1(v22) = m_impl.fields._currentDeviceTier_k__BackingField;
			//       }
			//       else if ( change == SettingConfigChange__Enum_FeatureTierChange )
			//       {
			//         v9 = this.fields.m_impl;
			//         if ( !v9 )
			//           goto LABEL_24;
			//         overrideFeatureSettingTiers = HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_overrideFeatureSettingTiers(
			//                                         v9,
			//                                         0LL);
			//         if ( !overrideFeatureSettingTiers )
			//           goto LABEL_24;
			//         if ( System::Collections::Generic::Dictionary<System::Object,int>::TryGetValue(
			//                (Dictionary_2_System_Object_System_Int32_ *)overrideFeatureSettingTiers,
			//                (Object *)newSettingData.featureName,
			//                &value,
			//                MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue) )
			//         {
			//           currentDeviceTier_k__BackingField = value;
			//         }
			//         else
			//         {
			//           v14 = this.fields.m_impl;
			//           if ( !v14 )
			//             goto LABEL_24;
			//           currentDeviceTier_k__BackingField = v14.fields._currentDeviceTier_k__BackingField;
			//         }
			//         DWORD1(v22) = currentDeviceTier_k__BackingField;
			//         *((_QWORD *)&v22 + 1) = newSettingData.featureName;
			//         sub_1800054D0((HGRenderPathScene *)((char *)&v22 + 8), v7, v11, v12, v19, v20);
			//       }
			//     }
			//     else
			//     {
			//       v16 = this.fields.m_impl;
			//       if ( !v16 )
			//         goto LABEL_24;
			//       LODWORD(v22) = v16.fields._currentDeviceType_k__BackingField;
			//     }
			//     m_layer = this.fields.m_layer;
			//     if ( m_layer )
			//       return (unsigned int)sub_1802265D0(
			//                              (_DWORD)v9,
			//                              (_DWORD)v7,
			//                              (_DWORD)m_layer,
			//                              change,
			//                              (__int64)newSettingData,
			//                              (__int64)&v22);
			// LABEL_24:
			//     sub_180B536AC(v9, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3219, 0LL);
			//   if ( !Patch )
			//     goto LABEL_24;
			//   v23 = *newSettingData;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1151(Patch, (Object *)this, change, &v23, 0LL);
			// }
			// 
			return (SettingDataProcessResult)SettingDataProcessResult.Succeed;
		}

		internal bool RegisterSettingDataProcessLayer(ISettingDataProcessLayer layer)
		{
			return default(bool);
		}

		internal bool UnRegisterSettingDataProcessLayer(ISettingDataProcessLayer layer)
		{
			return default(bool);
		}

		internal void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::Reset(HGRenderPipelineSettingHub *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3224, 0LL) )
			//   {
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//     {
			//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::Initialize(
			//         m_impl,
			//         HGDeviceType__Enum_Unknown,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_impl, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3224, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal void RefreshDirtySettings()
		{
			// // Void RefreshDirtySettings()
			// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::RefreshDirtySettings(
			//         HGRenderPipelineSettingHub *this,
			//         MethodInfo *method)
			// {
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
			//   HashSet_1_System_String___Class *klass; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_impl = (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     m_impl = (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = m_impl[1].fields.m_dirtyFeatureSettings.klass;
			//   if ( !klass )
			//     goto LABEL_9;
			//   if ( SLODWORD(klass._0.namespaze) <= 567 )
			//     goto LABEL_7;
			//   if ( !LODWORD(m_impl[2].klass) )
			//   {
			//     il2cpp_runtime_class_init_0(m_impl, klass);
			//     m_impl = (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   m_impl = (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)m_impl[1].fields.m_dirtyFeatureSettings.klass;
			//   if ( !m_impl )
			//     goto LABEL_9;
			//   if ( m_impl.fields._currentDeviceType_k__BackingField <= 0x237u )
			//     sub_180070270(m_impl, klass);
			//   if ( !m_impl[40].fields.parameterTablePath )
			//   {
			// LABEL_7:
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//     {
			//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshDirtySettings(m_impl, 0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(m_impl, klass);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(567, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal void ResetRegisteredParameters()
		{
			// // Void ResetRegisteredParameters()
			// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::ResetRegisteredParameters(
			//         HGRenderPipelineSettingHub *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3250, 0LL) )
			//   {
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//     {
			//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetRegisteredParameters(
			//         m_impl,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_impl, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3250, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void FeedSettingData(Dictionary<string, string> settingData)
		{
			// // Void FeedSettingData(Dictionary`2[System.String,System.String])
			// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::FeedSettingData(
			//         HGRenderPipelineSettingHub *this,
			//         Dictionary_2_System_String_System_String_ *settingData,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3253, 0LL) )
			//   {
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//     {
			//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FeedSettingData(
			//         m_impl,
			//         settingData,
			//         0LL);
			//       return;
			//     }
			// LABEL_4:
			//     sub_180B536AC(m_impl, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3253, 0LL);
			//   if ( !Patch )
			//     goto LABEL_4;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)settingData,
			//     0LL);
			// }
			// 
		}

		public SettingDataProcessResult ChangeSettingTier(int tier)
		{
			// // SettingDataProcessResult ChangeSettingTier(Int32)
			// SettingDataProcessResult__Enum HG::Rendering::Runtime::HGRenderPipelineSettingHub::ChangeSettingTier(
			//         HGRenderPipelineSettingHub *this,
			//         int32_t tier,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   SettingDataProcessResult__Enum v7; // edi
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *v8; // rcx
			//   SettingDataProcessResult__Enum result; // eax
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
			//   ISettingDataProcessLayer *m_layer; // r8
			//   ILFixDynamicMethodWrapper_2 *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   SettingConfigChangeData v14; // [rsp+30h] [rbp-38h] BYREF
			//   SettingConfigChangeData v15; // [rsp+40h] [rbp-28h] BYREF
			//   SettingConfigChangeData v16; // [rsp+50h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3254, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3254, 0LL);
			//     if ( !Patch )
			//       goto LABEL_9;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
			//              (ILFixDynamicMethodWrapper_26 *)Patch,
			//              (Object *)this,
			//              tier,
			//              0LL);
			//   }
			//   v14 = 0LL;
			//   v14.settingTier = tier;
			//   v15 = v14;
			//   if ( !byte_18D8EDB3B )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ISettingDataProcessLayer);
			//     byte_18D8EDB3B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3219, 0LL) )
			//   {
			//     if ( !this.fields.m_layer )
			//     {
			//       v7 = SettingDataProcessResult__Enum_Succeed;
			//       goto LABEL_7;
			//     }
			//     v14 = 0LL;
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//     {
			//       v14.settingTier = m_impl.fields._currentDeviceTier_k__BackingField;
			//       m_layer = this.fields.m_layer;
			//       if ( m_layer )
			//       {
			//         result = (unsigned int)sub_1802265D0(v6, v5, (_DWORD)m_layer, 1, (__int64)&v15, (__int64)&v14);
			//         goto LABEL_10;
			//       }
			//     }
			// LABEL_17:
			//     sub_180B536AC(v6, v5);
			//   }
			//   v12 = IFix::WrappersManagerImpl::GetPatch(3219, 0LL);
			//   if ( !v12 )
			//     goto LABEL_17;
			//   v16 = v15;
			//   result = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1151(
			//              v12,
			//              (Object *)this,
			//              SettingConfigChange__Enum_SettingTierChange,
			//              &v16,
			//              0LL);
			// LABEL_10:
			//   v7 = result;
			//   if ( result != SettingDataProcessResult__Enum_DataBlocked )
			//   {
			// LABEL_7:
			//     v8 = this.fields.m_impl;
			//     if ( v8 )
			//     {
			//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ChangeSettingTier(v8, tier, 0LL);
			//       return v7;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v8, v5);
			//   }
			//   return result;
			// }
			// 
			return (SettingDataProcessResult)SettingDataProcessResult.Succeed;
		}

		public SettingDataProcessResult OverrideFeatureTier(string featureName, int tier)
		{
			// // SettingDataProcessResult OverrideFeatureTier(String, Int32)
			// SettingDataProcessResult__Enum HG::Rendering::Runtime::HGRenderPipelineSettingHub::OverrideFeatureTier(
			//         HGRenderPipelineSettingHub *this,
			//         String *featureName,
			//         int32_t tier,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   SettingDataProcessResult__Enum v10; // ebx
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *v12; // rcx
			//   SettingDataProcessResult__Enum result; // eax
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
			//   Dictionary_2_System_String_System_Int32_ *overrideFeatureSettingTiers; // rax
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   int32_t currentDeviceTier_k__BackingField; // eax
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *v19; // rax
			//   ISettingDataProcessLayer *m_layer; // r8
			//   ILFixDynamicMethodWrapper_2 *v21; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-68h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-68h]
			//   MethodInfo *v25; // [rsp+28h] [rbp-60h]
			//   MethodInfo *v26; // [rsp+28h] [rbp-60h]
			//   int32_t value[4]; // [rsp+30h] [rbp-58h] BYREF
			//   __m128i v28; // [rsp+40h] [rbp-48h] BYREF
			//   _DWORD v29[2]; // [rsp+50h] [rbp-38h] BYREF
			//   __int64 v30; // [rsp+58h] [rbp-30h] BYREF
			//   __m128i v31; // [rsp+60h] [rbp-28h] BYREF
			//   __m128i v32; // [rsp+70h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3257, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3257, 0LL);
			//     if ( !Patch )
			//       goto LABEL_8;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1159(Patch, (Object *)this, (Object *)featureName, tier, 0LL);
			//   }
			//   v10 = SettingDataProcessResult__Enum_Succeed;
			//   v28.m128i_i32[1] = tier;
			//   v28.m128i_i32[0] = 0;
			//   v28.m128i_i64[1] = (__int64)featureName;
			//   sub_1800054D0((HGRenderPathScene *)&v28.m128i_u64[1], v7, v8, v9, methoda, v25);
			//   v31 = v28;
			//   if ( !byte_18D8EDB3B )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::ISettingDataProcessLayer);
			//     byte_18D8EDB3B = 1;
			//   }
			//   value[0] = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3219, 0LL) )
			//   {
			//     if ( !this.fields.m_layer )
			//       goto LABEL_6;
			//     v29[0] = 0;
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//     {
			//       overrideFeatureSettingTiers = HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_overrideFeatureSettingTiers(
			//                                       m_impl,
			//                                       0LL);
			//       if ( overrideFeatureSettingTiers )
			//       {
			//         if ( System::Collections::Generic::Dictionary<System::Object,int>::TryGetValue(
			//                (Dictionary_2_System_Object_System_Int32_ *)overrideFeatureSettingTiers,
			//                (Object *)_mm_srli_si128(v31, 8).m128i_i64[0],
			//                value,
			//                MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue) )
			//         {
			//           currentDeviceTier_k__BackingField = value[0];
			//         }
			//         else
			//         {
			//           v19 = this.fields.m_impl;
			//           if ( !v19 )
			//             goto LABEL_21;
			//           currentDeviceTier_k__BackingField = v19.fields._currentDeviceTier_k__BackingField;
			//         }
			//         v29[1] = currentDeviceTier_k__BackingField;
			//         v30 = v31.m128i_i64[1];
			//         sub_1800054D0((HGRenderPathScene *)&v30, v11, v16, v17, methodb, v26);
			//         m_layer = this.fields.m_layer;
			//         if ( m_layer )
			//         {
			//           result = (unsigned int)sub_1802265D0(
			//                                    (_DWORD)m_impl,
			//                                    (_DWORD)v11,
			//                                    (_DWORD)m_layer,
			//                                    2,
			//                                    (__int64)&v31,
			//                                    (__int64)v29);
			//           goto LABEL_9;
			//         }
			//       }
			//     }
			// LABEL_21:
			//     sub_180B536AC(m_impl, v11);
			//   }
			//   v21 = IFix::WrappersManagerImpl::GetPatch(3219, 0LL);
			//   if ( !v21 )
			//     goto LABEL_21;
			//   v32 = v31;
			//   result = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1151(
			//              v21,
			//              (Object *)this,
			//              SettingConfigChange__Enum_FeatureTierChange,
			//              (SettingConfigChangeData *)&v32,
			//              0LL);
			// LABEL_9:
			//   v10 = result;
			//   if ( result != SettingDataProcessResult__Enum_DataBlocked )
			//   {
			// LABEL_6:
			//     v12 = this.fields.m_impl;
			//     if ( v12 )
			//     {
			//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::OverrideFeatureTier(
			//         v12,
			//         featureName,
			//         tier,
			//         0LL);
			//       return v10;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v12, v11);
			//   }
			//   return result;
			// }
			// 
			return (SettingDataProcessResult)SettingDataProcessResult.Succeed;
		}

		public SettingDataProcessResult ResetFeatureTier(string featureName)
		{
			// // SettingDataProcessResult ResetFeatureTier(String)
			// SettingDataProcessResult__Enum HG::Rendering::Runtime::HGRenderPipelineSettingHub::ResetFeatureTier(
			//         HGRenderPipelineSettingHub *this,
			//         String *featureName,
			//         MethodInfo *method)
			// {
			//   HGRenderPathBase_HGRenderPathResources *v5; // rdx
			//   PassConstructorID__Enum__Array *v6; // r8
			//   HGCamera *v7; // r9
			//   __int64 v8; // rdx
			//   SettingDataProcessResult__Enum v9; // esi
			//   SettingDataProcessResult__Enum result; // eax
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   SettingConfigChangeData v13; // [rsp+20h] [rbp-28h] BYREF
			//   SettingConfigChangeData v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3259, 0LL) )
			//   {
			//     v13.featureName = featureName;
			//     ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, HGCamera *, MethodInfo *))sub_1800054D0)(
			//       (HGRenderPathScene *)&v13.featureName,
			//       v5,
			//       v6,
			//       v7,
			//       0LL);
			//     v14 = v13;
			//     v9 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::LayerProcess(
			//            this,
			//            SettingConfigChange__Enum_FeatureTierReset,
			//            &v14,
			//            0LL);
			//     result = SettingDataProcessResult__Enum_DataBlocked;
			//     if ( v9 == SettingDataProcessResult__Enum_DataBlocked )
			//       return result;
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//     {
			//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetFeatureTier(
			//         m_impl,
			//         featureName,
			//         0LL);
			//       return v9;
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_impl, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3259, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_104(
			//            (ILFixDynamicMethodWrapper_13 *)Patch,
			//            (Object *)this,
			//            (Object *)featureName,
			//            0LL);
			// }
			// 
			return (SettingDataProcessResult)SettingDataProcessResult.Succeed;
		}

		public void RegisterSettingChangeCallback(string featureName, HGRenderPipelineSettingHub.OnSettingChanged callback)
		{
			// // Void RegisterSettingChangeCallback(String, HGRenderPipelineSettingHub+OnSettingChanged)
			// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::RegisterSettingChangeCallback(
			//         HGRenderPipelineSettingHub *this,
			//         String *featureName,
			//         HGRenderPipelineSettingHub_OnSettingChanged *callback,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(451, 0LL) )
			//   {
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//     {
			//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RegisterSettingChangeCallback(
			//         m_impl,
			//         featureName,
			//         callback,
			//         0LL);
			//       return;
			//     }
			// LABEL_4:
			//     sub_180B536AC(m_impl, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(451, 0LL);
			//   if ( !Patch )
			//     goto LABEL_4;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)featureName,
			//     (Object *)callback,
			//     0LL);
			// }
			// 
		}

		public bool IsForceSRPShader(string shader)
		{
			// // Boolean IsForceSRPShader(String)
			// bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::IsForceSRPShader(
			//         HGRenderPipelineSettingHub *this,
			//         String *shader,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HashSet_1_System_Object_ *forceSRPShaders; // rcx
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9196E3 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<System::String>::Contains);
			//     byte_18D9196E3 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3261, 0LL) )
			//   {
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//     {
			//       forceSRPShaders = (HashSet_1_System_Object_ *)m_impl.fields.forceSRPShaders;
			//       if ( forceSRPShaders )
			//         return System::Collections::Generic::HashSet<System::Object>::Contains(
			//                  forceSRPShaders,
			//                  (Object *)shader,
			//                  MethodInfo::System::Collections::Generic::HashSet<System::String>::Contains);
			//     }
			// LABEL_8:
			//     sub_180B536AC(forceSRPShaders, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3261, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//            (ILFixDynamicMethodWrapper_36 *)Patch,
			//            (Object *)this,
			//            (Object *)shader,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public string PrintTierInfo()
		{
			// // String PrintTierInfo()
			// String *HG::Rendering::Runtime::HGRenderPipelineSettingHub::PrintTierInfo(
			//         HGRenderPipelineSettingHub *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3262, 0LL) )
			//   {
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//       return HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PrintTierInfo(m_impl, 0LL);
			// LABEL_5:
			//     sub_180B536AC(m_impl, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3262, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public bool OverrideSettingParameter(string paramName, string paramValue)
		{
			// // Boolean OverrideSettingParameter(String, String)
			// bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::OverrideSettingParameter(
			//         HGRenderPipelineSettingHub *this,
			//         String *paramName,
			//         String *paramValue,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3264, 0LL) )
			//   {
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//       return HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::OverrideSettingParameter(
			//                m_impl,
			//                paramName,
			//                paramValue,
			//                0LL);
			// LABEL_5:
			//     sub_180B536AC(m_impl, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3264, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(
			//            (ILFixDynamicMethodWrapper_20 *)Patch,
			//            (Object *)this,
			//            (Object *)paramName,
			//            (Object *)paramValue,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public bool ResetSettingParameter(string paramName)
		{
			// // Boolean ResetSettingParameter(String)
			// bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::ResetSettingParameter(
			//         HGRenderPipelineSettingHub *this,
			//         String *paramName,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3267, 0LL) )
			//   {
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//       return HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetRegisteredParameter(
			//                m_impl,
			//                paramName,
			//                0LL);
			// LABEL_5:
			//     sub_180B536AC(m_impl, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3267, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//            (ILFixDynamicMethodWrapper_36 *)Patch,
			//            (Object *)this,
			//            (Object *)paramName,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public void ResetAllSettingParameters()
		{
			// // Void ResetAllSettingParameters()
			// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::ResetAllSettingParameters(
			//         HGRenderPipelineSettingHub *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3269, 0LL) )
			//   {
			//     m_impl = this.fields.m_impl;
			//     if ( m_impl )
			//     {
			//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetRegisteredParameters(
			//         m_impl,
			//         0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_impl, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3269, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private const int MAX_DEVICE_TIER = 6000;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static HGRenderPipelineSettingHub s_instance;

		private HGRenderPipelineSettingHub.HGRenderPipelineSettings m_impl;

		private ISettingDataProcessLayer m_layer;

		// (Invoke) Token: 0x06001435 RID: 5173
		public delegate void OnSettingChanged(HGDeviceType deviceType, int tier);

		internal static class ConstantStrings
		{
			[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
			public static readonly string SETTING_PATH;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
			public static readonly string SETTING_ENTRY_FILE;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
			public static readonly string SETTING_FILE_LIST;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
			public static readonly string SETTING_EXT;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
			public static readonly string ARRAY_CONCATENATE_STR;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
			public static readonly string MULTI_PATTERN_STR;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
			public static readonly string SUBLEVEL_STR;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
			public static readonly string INVALID_STR;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
			public static readonly string DRIVER_VERSION_START_STR;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x48")]
			public static readonly string DRIVER_VERSION_END_STR;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x50")]
			public static readonly string DRIVER_VERSION_INTERVAL_STR;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x58")]
			public static readonly string INCLUDE_STR;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x60")]
			public static readonly string DEVICE_TIER_SETTING_STR;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x68")]
			public static readonly string SHADER_STRIP_SECTION;

			[StaticFieldOffset(ThreadStatic = false, Offset = "0x70")]
			public static readonly string SHADER_STRIP_PARAM;
		}

		private class HGRenderPipelineSettings
		{
			// (get) Token: 0x06001439 RID: 5177 RVA: 0x00002C20 File Offset: 0x00000E20
			// (set) Token: 0x0600143A RID: 5178 RVA: 0x000025D0 File Offset: 0x000007D0
			public HGDeviceType currentDeviceType
			{
				[CompilerGenerated]
				get
				{
					// // LayerMask get_value()
					// LayerMask UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::get_value(
					//         VolumeParameter_1_UnityEngine_LayerMask_ *this,
					//         MethodInfo *method)
					// {
					//   return (LayerMask)this.fields.m_Value.m_Mask;
					// }
					// 
					return (HGDeviceType)HGDeviceType.Unknown;
				}
				[CompilerGenerated]
				private set
				{
					// // Void set_value(LayerMask)
					// void UnityEngine::Rendering::VolumeParameter<UnityEngine::LayerMask>::set_value(
					//         VolumeParameter_1_UnityEngine_LayerMask_ *this,
					//         LayerMask value,
					//         MethodInfo *method)
					// {
					//   this.fields.m_Value = value;
					// }
					// 
				}
			}

			// (get) Token: 0x0600143B RID: 5179 RVA: 0x00002608 File Offset: 0x00000808
			// (set) Token: 0x0600143C RID: 5180 RVA: 0x000025D0 File Offset: 0x000007D0
			public int currentDeviceTier
			{
				[CompilerGenerated]
				get
				{
					// // Int32 get_rolloverSize()
					// int32_t TMPro::TMP_TextProcessingStack<System::Object>::get_rolloverSize(
					//         TMP_TextProcessingStack_1_System_Object_ *this,
					//         MethodInfo *method)
					// {
					//   return this.m_RolloverSize;
					// }
					// 
					return 0;
				}
				[CompilerGenerated]
				private set
				{
					// // Void set_rolloverSize(Int32)
					// void TMPro::TMP_TextProcessingStack<System::Object>::set_rolloverSize(
					//         TMP_TextProcessingStack_1_System_Object_ *this,
					//         int32_t value,
					//         MethodInfo *method)
					// {
					//   this.m_RolloverSize = value;
					// }
					// 
				}
			}

			// (get) Token: 0x0600143D RID: 5181 RVA: 0x000025D8 File Offset: 0x000007D8
			// (set) Token: 0x0600143E RID: 5182 RVA: 0x000025D0 File Offset: 0x000007D0
			private bool useDefaultSettings
			{
				get
				{
					// // Boolean get_isPrediction()
					// bool Unity::VisualScripting::Flow::get_isPrediction(Flow_1 *this, MethodInfo *method)
					// {
					//   return this.fields._isPrediction_k__BackingField;
					// }
					// 
					return default(bool);
				}
				set
				{
					// // Void set_useDefaultSettings(Boolean)
					// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::set_useDefaultSettings(
					//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
					//         bool value,
					//         MethodInfo *method)
					// {
					//   if ( this.fields.m_useDefaultSettings != value )
					//   {
					//     this.fields.m_useDefaultSettings = value;
					//     HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshAllSettings(this, 0LL);
					//   }
					// }
					// 
				}
			}

			// (get) Token: 0x0600143F RID: 5183 RVA: 0x000025D2 File Offset: 0x000007D2
			public Dictionary<string, int> overrideFeatureSettingTiers
			{
				get
				{
					// // Dictionary`2[System.String,System.Int32] get_overrideFeatureSettingTiers()
					// Dictionary_2_System_String_System_Int32_ *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_overrideFeatureSettingTiers(
					//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					// 
					//   if ( !IFix::WrappersManagerImpl::IsPatched(575, 0LL) )
					//     return this.fields.m_overrideFeatureSettingTiers;
					//   Patch = IFix::WrappersManagerImpl::GetPatch(575, 0LL);
					//   if ( !Patch )
					//     sub_180B536AC(v6, v5);
					//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_221(Patch, (Object *)this, 0LL);
					// }
					// 
					return null;
				}
			}

			// (get) Token: 0x06001440 RID: 5184 RVA: 0x000025D2 File Offset: 0x000007D2
			public Dictionary<string, HGRenderPipelineSettingHub.HGRenderPipelineSettings.ParamInfo> paramLookupTable
			{
				get
				{
					// // Dictionary`2[System.String,HG.Rendering.Runtime.HGRenderPipelineSettingHub+HGRenderPipelineSettings+ParamInfo] get_paramLookupTable()
					// Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo_ *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_paramLookupTable(
					//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					// 
					//   if ( !IFix::WrappersManagerImpl::IsPatched(580, 0LL) )
					//     return this.fields.m_paramLookupTable;
					//   Patch = IFix::WrappersManagerImpl::GetPatch(580, 0LL);
					//   if ( !Patch )
					//     sub_180B536AC(v6, v5);
					//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_222(Patch, (Object *)this, 0LL);
					// }
					// 
					return null;
				}
			}

			// (get) Token: 0x06001441 RID: 5185 RVA: 0x000025D2 File Offset: 0x000007D2
			public Dictionary<string, List<HGRenderPipelineSettingHub.SettingParameterBase>> registeredParameters
			{
				get
				{
					// // Dictionary`2[System.String,List`1[HG.Rendering.Runtime.HGRenderPipelineSettingHub+SettingParameterBase]] get_registeredParameters()
					// Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_registeredParameters(
					//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					// 
					//   if ( !IFix::WrappersManagerImpl::IsPatched(3266, 0LL) )
					//     return this.fields.m_registeredParameters;
					//   Patch = IFix::WrappersManagerImpl::GetPatch(3266, 0LL);
					//   if ( !Patch )
					//     sub_180B536AC(v6, v5);
					//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1161(Patch, (Object *)this, 0LL);
					// }
					// 
					return null;
				}
			}

			public HGRenderPipelineSettings(int maximumDeviceTier)
			{
				// // HGRenderPipelineSettingHub+HGRenderPipelineSettings(Int32)
				// // Hidden C++ exception states: #wind=1
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::HGRenderPipelineSettings(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         int32_t maximumDeviceTier,
				//         MethodInfo *method)
				// {
				//   int32_t v3; // esi
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *v4; // rdi
				//   HashSet_1_System_Object_ *v5; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				//   HashSet_1_System_Object_ *v8; // rbx
				//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
				//   PassConstructorID__Enum__Array *v10; // r8
				//   HGCamera *v11; // r9
				//   Dictionary_2_System_Object_System_Object_ *v12; // rax
				//   __int64 v13; // rdx
				//   __int64 v14; // rcx
				//   Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_OnSettingChanged_ *v15; // rbx
				//   HGRenderPathBase_HGRenderPathResources *v16; // rdx
				//   PassConstructorID__Enum__Array *v17; // r8
				//   HGCamera *v18; // r9
				//   Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v19; // rax
				//   __int64 v20; // rdx
				//   __int64 v21; // rcx
				//   Dictionary_2_System_String_System_Int32_ *v22; // rbx
				//   HGRenderPathBase_HGRenderPathResources *v23; // rdx
				//   PassConstructorID__Enum__Array *v24; // r8
				//   HGCamera *v25; // r9
				//   Dictionary_2_System_Object_System_Object_ *v26; // rax
				//   __int64 v27; // rdx
				//   __int64 v28; // rcx
				//   Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *v29; // rbx
				//   HGRenderPathBase_HGRenderPathResources *v30; // rdx
				//   PassConstructorID__Enum__Array *v31; // r8
				//   HGCamera *v32; // r9
				//   Dictionary_2_System_Object_System_Object_ *v33; // rax
				//   __int64 v34; // rdx
				//   __int64 v35; // rcx
				//   Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo_ *v36; // rbx
				//   HGRenderPathBase_HGRenderPathResources *v37; // rdx
				//   PassConstructorID__Enum__Array *v38; // r8
				//   HGCamera *v39; // r9
				//   HashSet_1_System_Object_ *v40; // rax
				//   __int64 v41; // rdx
				//   __int64 v42; // rcx
				//   HashSet_1_System_String_ *v43; // rbx
				//   HGRenderPathBase_HGRenderPathResources *v44; // rdx
				//   PassConstructorID__Enum__Array *v45; // r8
				//   HGCamera *v46; // r9
				//   Dictionary_2_System_Object_System_Object_ *v47; // rax
				//   __int64 v48; // rdx
				//   __int64 v49; // rcx
				//   Dictionary_2_System_String_System_String_ *v50; // rbx
				//   HGRenderPathBase_HGRenderPathResources *v51; // rdx
				//   PassConstructorID__Enum__Array *v52; // r8
				//   HGCamera *v53; // r9
				//   Dictionary_2_System_Object_System_Object_ *v54; // rax
				//   __int64 v55; // rdx
				//   __int64 v56; // rcx
				//   Dictionary_2_System_String_System_String_ *v57; // rbx
				//   HGRenderPathBase_HGRenderPathResources *v58; // rdx
				//   PassConstructorID__Enum__Array *v59; // r8
				//   HGCamera *v60; // r9
				//   __int64 v61; // rdx
				//   __int64 v62; // rcx
				//   Object *current; // rbx
				//   void (__fastcall *v64)(Object *); // rax
				//   __int64 v65; // rax
				//   MethodInfo *v66; // [rsp+20h] [rbp-48h] BYREF
				//   HashSet_1_T_Enumerator_System_Object_ v67; // [rsp+28h] [rbp-40h] BYREF
				//   HashSet_1_T_Enumerator_System_Object_ v68; // [rsp+40h] [rbp-28h] BYREF
				// 
				//   v3 = maximumDeviceTier;
				//   v4 = this;
				//   if ( !byte_18D8EDB3F )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>::Dictionary);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::String>::Dictionary);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::Dictionary);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::Dictionary);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::Dictionary);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<System::String,System::String>);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<System::String,int>);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::String>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::String>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::String>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<System::String>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<System::String>::HashSet);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::HashSet<System::String>);
				//     sub_18003C530(&off_18C905340);
				//     sub_18003C530(&off_18C905348);
				//     sub_18003C530(&off_18C91AD38);
				//     sub_18003C530(&off_18C905310);
				//     sub_18003C530(&off_18C905318);
				//     sub_18003C530(&off_18C905320);
				//     sub_18003C530(&off_18C905328);
				//     sub_18003C530(&off_18C905370);
				//     sub_18003C530(&off_18C905378);
				//     sub_18003C530(&off_18C905380);
				//     sub_18003C530(&off_18C905388);
				//     sub_18003C530(&off_18C905350);
				//     sub_18003C530(&off_18C905358);
				//     sub_18003C530(&off_18C905360);
				//     sub_18003C530(&off_18C9F77B8);
				//     sub_18003C530(&off_18C905368);
				//     sub_18003C530(&off_18C905398);
				//     sub_18003C530(&off_18C9053A0);
				//     byte_18D8EDB3F = 1;
				//   }
				//   v5 = (HashSet_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::HashSet<System::String>);
				//   v8 = v5;
				//   if ( !v5 )
				//     sub_180B536AC(v7, v6);
				//   System::Collections::Generic::HashSet<System::Object>::HashSet(
				//     v5,
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::HashSet);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/CloudCard",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/Blockout/LitPoly",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/Effect/VFXSmoke",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/Foliage/Leaf",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/Lit",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/LitBuilding",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/LitForward",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/LitHLOD",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/LitRock",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/LitTransparent",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/LitWater",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/Unlit",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/CharacterNPR",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/CharacterNPR_Hair",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/CharacterNPR_Skin",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/CharacterNPR_Eye",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/CharacterNPR_LiquidAg",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   System::Collections::Generic::HashSet<System::Object>::Add(
				//     v8,
				//     (Object *)"HGRP/CharacterNPR_OverlayShadow",
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//   v4.fields.forceSRPShaders = (HashSet_1_System_String_ *)v8;
				//   sub_1800054D0((HGRenderPathScene *)&v4.fields, v9, v10, v11, v66, (MethodInfo *)v67._set);
				//   v4.fields._currentDeviceTier_k__BackingField = -1;
				//   v12 = (Dictionary_2_System_Object_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>);
				//   v15 = (Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_OnSettingChanged_ *)v12;
				//   if ( !v12 )
				//     sub_180B536AC(v14, v13);
				//   System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
				//     v12,
				//     MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>::Dictionary);
				//   v4.fields.m_settingChangeCallbacks = v15;
				//   sub_1800054D0((HGRenderPathScene *)&v4.fields.m_settingChangeCallbacks, v16, v17, v18, v66, (MethodInfo *)v67._set);
				//   v19 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::String,int>);
				//   v22 = (Dictionary_2_System_String_System_Int32_ *)v19;
				//   if ( !v19 )
				//     sub_180B536AC(v21, v20);
				//   System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Dictionary(
				//     v19,
				//     MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::Dictionary);
				//   v4.fields.m_overrideFeatureSettingTiers = v22;
				//   sub_1800054D0(
				//     (HGRenderPathScene *)&v4.fields.m_overrideFeatureSettingTiers,
				//     v23,
				//     v24,
				//     v25,
				//     v66,
				//     (MethodInfo *)v67._set);
				//   v26 = (Dictionary_2_System_Object_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>);
				//   v29 = (Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *)v26;
				//   if ( !v26 )
				//     sub_180B536AC(v28, v27);
				//   System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
				//     v26,
				//     MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::Dictionary);
				//   v4.fields.m_registeredParameters = v29;
				//   sub_1800054D0((HGRenderPathScene *)&v4.fields.m_registeredParameters, v30, v31, v32, v66, (MethodInfo *)v67._set);
				//   v33 = (Dictionary_2_System_Object_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>);
				//   v36 = (Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo_ *)v33;
				//   if ( !v33 )
				//     sub_180B536AC(v35, v34);
				//   System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
				//     v33,
				//     MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::Dictionary);
				//   v4.fields.m_paramLookupTable = v36;
				//   sub_1800054D0((HGRenderPathScene *)&v4.fields.m_paramLookupTable, v37, v38, v39, v66, (MethodInfo *)v67._set);
				//   v40 = (HashSet_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::HashSet<System::String>);
				//   v43 = (HashSet_1_System_String_ *)v40;
				//   if ( !v40 )
				//     sub_180B536AC(v42, v41);
				//   System::Collections::Generic::HashSet<System::Object>::HashSet(
				//     v40,
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::HashSet);
				//   v4.fields.m_dirtyFeatureSettings = v43;
				//   sub_1800054D0((HGRenderPathScene *)&v4.fields.m_dirtyFeatureSettings, v44, v45, v46, v66, (MethodInfo *)v67._set);
				//   v47 = (Dictionary_2_System_Object_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::String,System::String>);
				//   v50 = (Dictionary_2_System_String_System_String_ *)v47;
				//   if ( !v47 )
				//     sub_180B536AC(v49, v48);
				//   System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
				//     v47,
				//     MethodInfo::System::Collections::Generic::Dictionary<System::String,System::String>::Dictionary);
				//   v4.fields.m_settingData = v50;
				//   sub_1800054D0((HGRenderPathScene *)&v4.fields.m_settingData, v51, v52, v53, v66, (MethodInfo *)v67._set);
				//   v54 = (Dictionary_2_System_Object_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<System::String,System::String>);
				//   v57 = (Dictionary_2_System_String_System_String_ *)v54;
				//   if ( !v54 )
				//     sub_180B536AC(v56, v55);
				//   System::Collections::Generic::Dictionary<System::Object,System::Object>::Dictionary(
				//     v54,
				//     MethodInfo::System::Collections::Generic::Dictionary<System::String,System::String>::Dictionary);
				//   v4.fields.parameterTablePath = v57;
				//   sub_1800054D0((HGRenderPathScene *)&v4.fields.parameterTablePath, v58, v59, v60, v66, (MethodInfo *)v67._set);
				//   if ( !v4.fields.forceSRPShaders )
				//     sub_180B536AC(v62, v61);
				//   System::Collections::Generic::HashSet<unsigned long>::GetEnumerator(
				//     (HashSet_1_T_Enumerator_System_UInt64_ *)&v67,
				//     (HashSet_1_System_UInt64_ *)v4.fields.forceSRPShaders,
				//     MethodInfo::System::Collections::Generic::HashSet<System::String>::GetEnumerator);
				//   v68 = v67;
				//   v67._set = 0LL;
				//   *(_QWORD *)&v67._index = &v68;
				//   try
				//   {
				//     while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
				//               &v68,
				//               MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::String>::MoveNext) )
				//     {
				//       current = v68._current;
				//       v64 = (void (__fastcall *)(Object *))qword_18D8F5590;
				//       if ( !qword_18D8F5590 )
				//       {
				//         v64 = (void (__fastcall *)(Object *))il2cpp_resolve_icall_0(
				//                                                "UnityEngine.Rendering.GraphicsSettings::INTERNAL_AddShaderToSRPInstancing"
				//                                                "WhiteList(System.String)");
				//         if ( !v64 )
				//         {
				//           v65 = sub_1802DBBE8("UnityEngine.Rendering.GraphicsSettings::INTERNAL_AddShaderToSRPInstancingWhiteList(System.String)");
				//           sub_18000F750(v65, 0LL);
				//         }
				//         qword_18D8F5590 = (__int64)v64;
				//       }
				//       v64(current);
				//     }
				//   }
				//   catch ( Il2CppExceptionWrapper *v66 )
				//   {
				//     v67._set = (HashSet_1_System_Object_ *)v66.methodPointer;
				//     if ( v67._set )
				//       sub_18000F780(v67._set);
				//     v3 = maximumDeviceTier;
				//     v4 = this;
				//   }
				//   v4.fields._currentDeviceTier_k__BackingField = v3;
				//   v4.fields.maximumDeviceTier = v3;
				//   v4.fields.minimumDeviceTier = 1000;
				// }
				// 
			}

			internal int CheckConstrains(string constrainString)
			{
				// // Int32 CheckConstrains(String)
				// int32_t HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::CheckConstrains(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         String *constrainString,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   String *v6; // rcx
				//   struct HGRenderPipelineSettingHub_ConstantStrings__Class *v7; // rax
				//   String *MULTI_PATTERN_STR; // rdx
				//   String__Array *v9; // rbx
				//   int32_t v10; // esi
				//   int32_t v11; // edi
				//   String *v12; // rbp
				//   String *DeviceName; // r14
				//   String *OperatingSystem; // r15
				//   String *GraphicsDeviceVendor; // r12
				//   String *GraphicsDeviceName; // r13
				//   String *cpuName; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   String *GraphicsDeviceVersion; // [rsp+28h] [rbp-30h]
				//   String *DeviceModel; // [rsp+78h] [rbp+20h]
				// 
				//   if ( !byte_18D8EDB3E )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//     sub_18003C530(&TypeInfo::Beyond::DeviceInfo);
				//     sub_18003C530(&off_18C9B4D38);
				//     byte_18D8EDB3E = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(581, 0LL) )
				//   {
				//     v7 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings._1.cctor_finished_or_no_cctor )
				//     {
				//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings, v5);
				//       v7 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				//     }
				//     MULTI_PATTERN_STR = v7.static_fields.MULTI_PATTERN_STR;
				//     if ( constrainString )
				//     {
				//       v9 = System::String::Split(constrainString, MULTI_PATTERN_STR, StringSplitOptions__Enum_None, 0LL);
				//       v10 = 0;
				//       v11 = 0;
				//       if ( v9 )
				//       {
				//         while ( 1 )
				//         {
				//           if ( v11 >= v9.max_length.size )
				//             return v10;
				//           if ( (unsigned int)v11 >= v9.max_length.size )
				//             sub_180070270(v6, MULTI_PATTERN_STR);
				//           v12 = v9.vector[v11];
				//           if ( !v12 )
				//             break;
				//           MULTI_PATTERN_STR = (String *)"";
				//           if ( v12 == (String *)""
				//             || ""
				//             && v12.fields._stringLength == *(_DWORD *)&asc_18F253034[16]
				//             && System::SpanHelpers::SequenceEqual(
				//                  (uint8_t *)&v12.fields._firstChar,
				//                  (uint8_t *)&asc_18F253034[20],
				//                  2LL * v12.fields._stringLength,
				//                  0LL) )
				//           {
				//             goto LABEL_15;
				//           }
				//           DeviceModel = UnityEngine::SystemInfo::GetDeviceModel(0LL);
				//           DeviceName = UnityEngine::SystemInfo::GetDeviceName(0LL);
				//           OperatingSystem = UnityEngine::SystemInfo::GetOperatingSystem(0LL);
				//           GraphicsDeviceVendor = UnityEngine::SystemInfo::GetGraphicsDeviceVendor(0LL);
				//           GraphicsDeviceName = UnityEngine::SystemInfo::GetGraphicsDeviceName(0LL);
				//           GraphicsDeviceVersion = UnityEngine::SystemInfo::GetGraphicsDeviceVersion(0LL);
				//           if ( !DeviceModel )
				//             break;
				//           if ( System::String::IndexOf(DeviceModel, v12, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) >= 0 )
				//             goto LABEL_33;
				//           if ( !DeviceName )
				//             break;
				//           if ( System::String::IndexOf(DeviceName, v12, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) >= 0 )
				//           {
				//             ++v10;
				//             ++v11;
				//           }
				//           else
				//           {
				//             if ( !OperatingSystem )
				//               break;
				//             if ( System::String::IndexOf(OperatingSystem, v12, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) >= 0 )
				//               goto LABEL_33;
				//             if ( !GraphicsDeviceVendor )
				//               break;
				//             if ( System::String::IndexOf(
				//                    GraphicsDeviceVendor,
				//                    v12,
				//                    StringComparison__Enum_CurrentCultureIgnoreCase,
				//                    0LL) >= 0 )
				//               goto LABEL_33;
				//             if ( !GraphicsDeviceName )
				//               break;
				//             if ( System::String::IndexOf(GraphicsDeviceName, v12, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) >= 0 )
				//               goto LABEL_33;
				//             v6 = GraphicsDeviceVersion;
				//             if ( !GraphicsDeviceVersion )
				//               break;
				//             if ( System::String::IndexOf(
				//                    GraphicsDeviceVersion,
				//                    v12,
				//                    StringComparison__Enum_CurrentCultureIgnoreCase,
				//                    0LL) >= 0 )
				//               goto LABEL_33;
				//             if ( !TypeInfo::Beyond::DeviceInfo._1.cctor_finished_or_no_cctor )
				//               il2cpp_runtime_class_init_0(TypeInfo::Beyond::DeviceInfo, MULTI_PATTERN_STR);
				//             cpuName = Beyond::DeviceInfo::get_cpuName(0LL);
				//             if ( !cpuName )
				//               break;
				//             if ( System::String::IndexOf(cpuName, v12, StringComparison__Enum_CurrentCultureIgnoreCase, 0LL) >= 0 )
				// LABEL_33:
				//               ++v10;
				// LABEL_15:
				//             ++v11;
				//           }
				//         }
				//       }
				//     }
				// LABEL_34:
				//     sub_180B536AC(v6, MULTI_PATTERN_STR);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(581, 0LL);
				//   if ( !Patch )
				//     goto LABEL_34;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_99(
				//            (ILFixDynamicMethodWrapper_17 *)Patch,
				//            (Object *)this,
				//            (Object *)constrainString,
				//            0LL);
				// }
				// 
				return 0;
			}

			public void Initialize([MetadataOffset(Offset = "0x01F91AE5")] HGDeviceType overrideDeviceType = HGDeviceType.Unknown)
			{
			}

			public void FeedSettingData(Dictionary<string, string> settingData)
			{
				// // Void FeedSettingData(Dictionary`2[System.String,System.String])
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FeedSettingData(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         Dictionary_2_System_String_System_String_ *settingData,
				//         MethodInfo *method)
				// {
				//   HGRenderPathBase_HGRenderPathResources *v5; // rdx
				//   PassConstructorID__Enum__Array *v6; // r8
				//   HGCamera *v7; // r9
				//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
				//   PassConstructorID__Enum__Array *v9; // r8
				//   HGCamera *v10; // r9
				//   __int64 v11; // rax
				//   __int64 v12; // rdx
				//   __int64 v13; // rcx
				//   Exception *v14; // rbx
				//   String *v15; // rax
				//   __int64 v16; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v18; // rdx
				//   __int64 v19; // rcx
				//   MethodInfo *v20; // [rsp+20h] [rbp-18h]
				//   MethodInfo *v21; // [rsp+20h] [rbp-18h]
				//   MethodInfo *v22; // [rsp+28h] [rbp-10h]
				//   MethodInfo *v23; // [rsp+28h] [rbp-10h]
				// 
				//   if ( !byte_18D8EDB41 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::String>::get_Count);
				//     sub_18003C530(&off_18C9B4D38);
				//     byte_18D8EDB41 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(3228, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3228, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v19, v18);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
				//       (ILFixDynamicMethodWrapper_37 *)Patch,
				//       (Object *)this,
				//       (Object *)settingData,
				//       0LL);
				//   }
				//   else
				//   {
				//     if ( !settingData )
				//     {
				//       v11 = sub_18003C530(&TypeInfo::System::Exception);
				//       v14 = (Exception *)sub_180004920(v11);
				//       if ( !v14 )
				//         sub_180B536AC(v13, v12);
				//       v15 = (String *)sub_18003C530(&off_18D510D38);
				//       System::Exception::Exception(v14, v15, 0LL);
				//       v16 = sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FeedSettingData);
				//       sub_18000F7C0(v14, v16);
				//     }
				//     if ( settingData.fields._count != settingData.fields._freeCount )
				//     {
				//       this.fields.m_settingData = settingData;
				//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_settingData, v5, v6, v7, v20, v22);
				//       this.fields.m_settingTable = HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PopulateSettingTable(
				//                                       this,
				//                                       settingData,
				//                                       (String *)"",
				//                                       0LL);
				//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_settingTable, v8, v9, v10, v21, v23);
				//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FlattenParameters(
				//         this,
				//         this.fields.m_settingTable,
				//         0LL);
				//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshAllSettings(this, 0LL);
				//     }
				//   }
				// }
				// 
			}

			private HGRenderPipelineSettingHub.HGRenderPipelineSettings.BaseSettingTable PopulateSettingTable(Dictionary<string, string> settingData, string relativePath)
			{
				// // HGRenderPipelineSettingHub+HGRenderPipelineSettings+BaseSettingTable PopulateSettingTable(Dictionary`2[System.String,System.String], String)
				// HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PopulateSettingTable(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         Dictionary_2_System_String_System_String_ *settingData,
				//         String *relativePath,
				//         MethodInfo *method)
				// {
				//   IniDataParser *v7; // rax
				//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
				//   IniScheme *ARRAY_CONCATENATE_STR; // rcx
				//   IniDataParser *v10; // rbx
				//   PassConstructorID__Enum__Array *v11; // r8
				//   HGCamera *v12; // r9
				//   struct HGRenderPipelineSettingHub_ConstantStrings__Class *v13; // rax
				//   IniParserConfiguration *Configuration_k__BackingField; // rdi
				//   IniParserConfiguration *v15; // r9
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *v16; // rax
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *v17; // rdi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   MethodInfo *relativePatha; // [rsp+20h] [rbp-38h]
				//   MethodInfo *settingPath; // [rsp+28h] [rbp-30h]
				// 
				//   if ( !byte_18D8EDB42 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//     sub_18003C530(&TypeInfo::IniParser::IniDataParser);
				//     sub_18003C530(&off_18C992080);
				//     byte_18D8EDB42 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3229, 0LL) )
				//   {
				//     v7 = (IniDataParser *)sub_180004920(TypeInfo::IniParser::IniDataParser);
				//     v10 = v7;
				//     if ( v7 )
				//     {
				//       IniParser::IniDataParser::IniDataParser(v7, 0LL);
				//       v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				//       Configuration_k__BackingField = v10.fields._Configuration_k__BackingField;
				//       if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings._1.cctor_finished_or_no_cctor )
				//       {
				//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings, v8);
				//         v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				//       }
				//       ARRAY_CONCATENATE_STR = (IniScheme *)v13.static_fields.ARRAY_CONCATENATE_STR;
				//       if ( Configuration_k__BackingField )
				//       {
				//         Configuration_k__BackingField.fields._ConcatenateDuplicatePropertiesString_k__BackingField = (String *)ARRAY_CONCATENATE_STR;
				//         sub_1800054D0(
				//           (HGRenderPathScene *)&Configuration_k__BackingField.fields._ConcatenateDuplicatePropertiesString_k__BackingField,
				//           v8,
				//           v11,
				//           v12,
				//           relativePatha,
				//           settingPath);
				//         v15 = v10.fields._Configuration_k__BackingField;
				//         if ( v15 )
				//         {
				//           v15.fields._DuplicatePropertiesBehaviour_k__BackingField = 3;
				//           ARRAY_CONCATENATE_STR = v10.fields._Scheme_k__BackingField;
				//           if ( ARRAY_CONCATENATE_STR )
				//           {
				//             IniParser::Configuration::IniScheme::set_CommentString(ARRAY_CONCATENATE_STR, (String *)"#", 0LL);
				//             v16 = (HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable);
				//             v17 = v16;
				//             if ( v16 )
				//             {
				//               HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::BaseSettingTable(
				//                 v16,
				//                 0LL);
				//               HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::PopulateSettingTable(
				//                 v17,
				//                 v10,
				//                 0LL,
				//                 (HGDeviceType__Enum)this.fields._currentDeviceType_k__BackingField,
				//                 relativePath,
				//                 TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings.static_fields.SETTING_ENTRY_FILE,
				//                 settingData,
				//                 this,
				//                 0LL);
				//               return v17;
				//             }
				//           }
				//         }
				//       }
				//     }
				// LABEL_12:
				//     sub_180B536AC(ARRAY_CONCATENATE_STR, v8);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(3229, 0LL);
				//   if ( !Patch )
				//     goto LABEL_12;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1156(
				//            Patch,
				//            (Object *)this,
				//            (Object *)settingData,
				//            (Object *)relativePath,
				//            0LL);
				// }
				// 
				return null;
			}

			private void PopulateDeviceInfo([MetadataOffset(Offset = "0x01F91AE6")] HGDeviceType overrideDeviceType = HGDeviceType.Unknown)
			{
				// // Void PopulateDeviceInfo(HGDeviceType)
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PopulateDeviceInfo(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         HGDeviceType__Enum overrideDeviceType,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3226, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3226, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3(
				//       (ILFixDynamicMethodWrapper_26 *)Patch,
				//       (Object *)this,
				//       overrideDeviceType,
				//       0LL);
				//   }
				//   else if ( overrideDeviceType )
				//   {
				//     this.fields._currentDeviceType_k__BackingField = overrideDeviceType;
				//   }
				//   else
				//   {
				//     this.fields._currentDeviceType_k__BackingField = UnityEngine::SystemInfo::GetDeviceType(0LL);
				//   }
				// }
				// 
			}

			[Obsolete]
			private void PopulateDeviceTier(HGRenderPipelineSettingHub.HGRenderPipelineSettings.BaseSettingTable settingTable)
			{
				// // Void PopulateDeviceTier(HGRenderPipelineSettingHub+HGRenderPipelineSettings+BaseSettingTable)
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PopulateDeviceTier(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *settingTable,
				//         MethodInfo *method)
				// {
				//   Func_2_Object_Object_ *v5; // rax
				//   HGRenderPipelineSettingHub_ConstantStrings__StaticFields *static_fields; // rdx
				//   IniData *iniData; // rcx
				//   Func_2_Object_Object_ *v8; // r15
				//   Func_2_Object_Object_ *v9; // rax
				//   Func_2_Object_Object_ *v10; // rsi
				//   SectionCollection *Sections_k__BackingField; // rdi
				//   Section *v12; // rax
				//   Section *v13; // r14
				//   __int64 v14; // rax
				//   __int64 v15; // rdx
				//   __int64 v16; // rcx
				//   IList_1_System_Int32_ *v17; // rdi
				//   int32_t currentDeviceType_k__BackingField; // ecx
				//   String *v19; // rax
				//   String *v20; // rax
				//   String *v21; // rax
				//   String *v22; // rax
				//   String *v23; // rax
				//   String *v24; // rax
				//   String *v25; // rdi
				//   HGRenderPipelineSettingHub_ConstantStrings__StaticFields *v26; // rcx
				//   String *INVALID_STR; // rdx
				//   String__Array *v28; // rax
				//   __int64 v29; // rdx
				//   __int64 v30; // rcx
				//   String *v31; // rdi
				//   String *v32; // rax
				//   String *v33; // rax
				//   String *GraphicsDeviceName; // rdi
				//   String *v35; // rax
				//   String *v36; // rax
				//   Il2CppException *v37; // rdi
				//   String *v38; // rbx
				//   String *v39; // rax
				//   String *v40; // rax
				//   __int64 v41; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   Il2CppExceptionWrapper *v43; // rdi
				//   Il2CppClass *klass; // rbx
				//   __int64 v45; // rax
				//   Il2CppExceptionWrapper v46; // [rsp+30h] [rbp-48h] BYREF
				//   Il2CppExceptionWrapper *v47; // [rsp+38h] [rbp-40h] BYREF
				//   Enum v48; // [rsp+40h] [rbp-38h] BYREF
				//   int32_t v49; // [rsp+50h] [rbp-28h]
				//   Il2CppException *ex; // [rsp+98h] [rbp+20h] BYREF
				// 
				//   if ( !byte_18D9196E5 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//     sub_18003C530(&TypeInfo::System::Func<IniParser::Model::Section,System::String>);
				//     sub_18003C530(&TypeInfo::System::Func<IniParser::Model::Section,System::Collections::Generic::List<int>>);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGDeviceType);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::_PopulateDeviceTier_b__37_0);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::_PopulateDeviceTier_b__37_1);
				//     sub_18003C530(&MethodInfo::Beyond::LinqExtensions::First<int>);
				//     sub_18003C530(&MethodInfo::Beyond::LinqExtensions::Last<int>);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
				//     sub_18003C530(&off_18D510B80);
				//     sub_18003C530(&off_18D5BF138);
				//     sub_18003C530(&off_18D510B10);
				//     sub_18003C530(&off_18D510B18);
				//     sub_18003C530(&off_18D510B30);
				//     sub_18003C530(&off_18D510B40);
				//     byte_18D9196E5 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(3270, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3270, 0LL);
				//     if ( !Patch )
				//       goto LABEL_29;
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
				//       (ILFixDynamicMethodWrapper_37 *)Patch,
				//       (Object *)this,
				//       (Object *)settingTable,
				//       0LL);
				//   }
				//   else
				//   {
				//     v5 = (Func_2_Object_Object_ *)sub_180004920(TypeInfo::System::Func<IniParser::Model::Section,System::String>);
				//     v8 = v5;
				//     if ( !v5 )
				//       goto LABEL_29;
				//     System::Func<System::Object,System::Object>::Func(
				//       v5,
				//       (Object *)this,
				//       MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::_PopulateDeviceTier_b__37_0,
				//       0LL);
				//     v9 = (Func_2_Object_Object_ *)sub_180004920(TypeInfo::System::Func<IniParser::Model::Section,System::Collections::Generic::List<int>>);
				//     v10 = v9;
				//     if ( !v9 )
				//       goto LABEL_29;
				//     System::Func<System::Object,System::Object>::Func(
				//       v9,
				//       (Object *)this,
				//       MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::_PopulateDeviceTier_b__37_1,
				//       0LL);
				//     if ( !settingTable )
				//       goto LABEL_29;
				//     iniData = settingTable.fields.iniData;
				//     if ( !iniData )
				//       goto LABEL_29;
				//     Sections_k__BackingField = iniData.fields._Sections_k__BackingField;
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//     static_fields = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings.static_fields;
				//     if ( !Sections_k__BackingField )
				//       goto LABEL_29;
				//     v12 = IniParser::Model::SectionCollection::FindByName(
				//             Sections_k__BackingField,
				//             static_fields.DEVICE_TIER_SETTING_STR,
				//             0LL);
				//     v13 = v12;
				//     if ( v12 )
				//     {
				//       try
				//       {
				//         v14 = sub_1824778D0(v10, v12, 0LL);
				//         v17 = (IList_1_System_Int32_ *)v14;
				//         if ( !v14 )
				//           sub_180B536AC(v16, v15);
				//         if ( *(int *)(v14 + 24) > 0 )
				//         {
				//           this.fields.maximumDeviceTier = Beyond::LinqExtensions::First<int>(
				//                                              (IList_1_System_Int32_ *)v14,
				//                                              MethodInfo::Beyond::LinqExtensions::First<int>);
				//           this.fields.minimumDeviceTier = Beyond::LinqExtensions::Last<int>(
				//                                              v17,
				//                                              MethodInfo::Beyond::LinqExtensions::Last<int>);
				//           currentDeviceType_k__BackingField = this.fields._currentDeviceType_k__BackingField;
				//           v48.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::HGDeviceType;
				//           v48.monitor = (MonitorData *)-1LL;
				//           v49 = currentDeviceType_k__BackingField;
				//           v19 = System::Enum::ToString(&v48, 0LL);
				//           v20 = System::String::Concat((String *)"Device Type:", v19, 0LL);
				//           HG::Rendering::HGRPLogger::LogImportant(v20, 0LL);
				//           v21 = System::Int32::ToString((Int32 *)&this.fields.maximumDeviceTier, 0LL);
				//           v22 = System::String::Concat((String *)"Maximum Device Tier:", v21, 0LL);
				//           HG::Rendering::HGRPLogger::LogImportant(v22, 0LL);
				//           v23 = System::Int32::ToString((Int32 *)&this.fields.minimumDeviceTier, 0LL);
				//           v24 = System::String::Concat((String *)"Minimum Device Tier:", v23, 0LL);
				//           HG::Rendering::HGRPLogger::LogImportant(v24, 0LL);
				//         }
				//       }
				//       catch ( Il2CppExceptionWrapper *v47 )
				//       {
				//         v43 = v47;
				//         klass = v47.ex.object.klass;
				//         v45 = sub_18000F7E0(&TypeInfo::System::Exception);
				//         if ( !(unsigned __int8)il2cpp_class_is_assignable_from_0(v45, klass) )
				//         {
				//           v46.ex = v43.ex;
				//           throw &v46;
				//         }
				//         ex = v43.ex;
				//         v37 = ex;
				//         if ( ex )
				//         {
				//           v38 = (String *)sub_18003F3E0(5LL, ex);
				//           v39 = (String *)sub_18000F7E0(&off_18D510BC8);
				//           v40 = System::String::Concat(v39, v38, 0LL);
				//           HG::Rendering::HGRPLogger::LogCritical(v40, 0LL);
				//           this.fields._currentDeviceTier_k__BackingField = this.fields.minimumDeviceTier;
				//           v41 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PopulateDeviceTier);
				//           sub_18000F7C0(v37, v41);
				//         }
				// LABEL_29:
				//         sub_180B536AC(iniData, static_fields);
				//       }
				//       if ( this.fields._currentDeviceTier_k__BackingField == -1 )
				//       {
				//         v25 = (String *)sub_1824778D0(v8, v13, 0LL);
				//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//         v26 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings.static_fields;
				//         INVALID_STR = v26.INVALID_STR;
				//         if ( !v25 )
				//           sub_180B536AC(v26, INVALID_STR);
				//         if ( System::String::Equals(v25, INVALID_STR, 0LL) )
				//         {
				//           GraphicsDeviceName = UnityEngine::SystemInfo::GetGraphicsDeviceName(0LL);
				//           v35 = System::Int32::ToString((Int32 *)&this.fields.minimumDeviceTier, 0LL);
				//           v36 = System::String::Concat(
				//                   GraphicsDeviceName,
				//                   (String *)" doesn't exit in our table, use lowest tier setting:",
				//                   v35,
				//                   (String *)" instead",
				//                   0LL);
				//           HG::Rendering::HGRPLogger::LogCritical(v36, 0LL);
				//           this.fields._currentDeviceTier_k__BackingField = this.fields.minimumDeviceTier;
				//         }
				//         else
				//         {
				//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//           v28 = System::String::Split(
				//                   v25,
				//                   TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings.static_fields.SUBLEVEL_STR,
				//                   StringSplitOptions__Enum_None,
				//                   0LL);
				//           if ( !v28 )
				//             sub_180B536AC(v30, v29);
				//           if ( v28.max_length.size <= 1u )
				//             sub_180070270(v30, v29);
				//           this.fields._currentDeviceTier_k__BackingField = System::Int32::Parse(v28.vector[1], 0LL);
				//           v31 = UnityEngine::SystemInfo::GetGraphicsDeviceName(0LL);
				//           LODWORD(ex) = this.fields._currentDeviceTier_k__BackingField;
				//           v32 = System::Int32::ToString((Int32 *)&ex, 0LL);
				//           v33 = System::String::Concat(v31, (String *)" matches tier setting:", v32, 0LL);
				//           HG::Rendering::HGRPLogger::LogImportant(v33, 0LL);
				//         }
				//       }
				//     }
				//     else
				//     {
				//       this.fields._currentDeviceTier_k__BackingField = 0;
				//     }
				//   }
				// }
				// 
			}

			public string PrintTierInfo()
			{
				// // String PrintTierInfo()
				// // Hidden C++ exception states: #wind=3 #try_helpers=2
				// String *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::PrintTierInfo(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rcx
				//   Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *m_registeredParameters; // rdx
				//   KeyValuePair_2_System_Object_System_Object_ current; // xmm6
				//   __int64 v6; // rcx
				//   List_1_System_Object_ *v7; // rdx
				//   Object *v8; // rbx
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v12; // rdx
				//   __int64 v13; // rcx
				//   Utf16ValueStringBuilder v15; // [rsp+20h] [rbp-D8h] BYREF
				//   _QWORD v16[2]; // [rsp+30h] [rbp-C8h] BYREF
				//   Utf16ValueStringBuilder v17; // [rsp+40h] [rbp-B8h] BYREF
				//   List_1_T_Enumerator_System_Object_ v18; // [rsp+50h] [rbp-A8h] BYREF
				//   Il2CppException *ex; // [rsp+68h] [rbp-90h]
				//   List_1_T_Enumerator_System_Object_ *v20; // [rsp+70h] [rbp-88h]
				//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v21; // [rsp+78h] [rbp-80h] BYREF
				//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v22; // [rsp+A0h] [rbp-58h] BYREF
				//   Il2CppExceptionWrapper *v23; // [rsp+C8h] [rbp-30h] BYREF
				//   String *v24; // [rsp+110h] [rbp+18h]
				// 
				//   if ( !byte_18D9196E6 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Key);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Value);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<System::String>);
				//     sub_18003C530(&TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
				//     sub_18003C530(&off_18D510C10);
				//     byte_18D9196E6 = 1;
				//   }
				//   v15 = 0LL;
				//   memset(&v21, 0, sizeof(v21));
				//   memset(&v18, 0, sizeof(v18));
				//   if ( IFix::WrappersManagerImpl::IsPatched(3263, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3263, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v13, v12);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     v15 = *Beyond::StringUtils::CreateZStringBuilder(&v17, 0LL);
				//     v16[0] = 0LL;
				//     v16[1] = &v15;
				//     m_registeredParameters = this.fields.m_registeredParameters;
				//     if ( !m_registeredParameters )
				//       sub_1802DC2C8(v3, 0LL);
				//     System::Collections::Generic::Dictionary<System::Object,System::Object>::GetEnumerator(
				//       &v22,
				//       (Dictionary_2_System_Object_System_Object_ *)m_registeredParameters,
				//       MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::GetEnumerator);
				//     v21 = v22;
				//     v17.buffer = 0LL;
				//     *(_QWORD *)&v17.index = &v21;
				//     while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
				//               &v21,
				//               MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::MoveNext) )
				//     {
				//       current = v21._current;
				//       sub_180002C70(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
				//       Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<System::Object>(
				//         &v15,
				//         (String *)"{0}===================\n",
				//         current.key,
				//         MethodInfo::Cysharp::Text::Utf16ValueStringBuilder::AppendFormat<System::String>);
				//       v7 = (List_1_System_Object_ *)_mm_srli_si128((__m128i)current, 8).m128i_u64[0];
				//       if ( !v7 )
				//         sub_1802DC2C8(v6, 0LL);
				//       System::Collections::Generic::List<System::Object>::GetEnumerator(
				//         (List_1_T_Enumerator_System_Object_ *)&v22,
				//         v7,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
				//       *(_OWORD *)&v18._list = *(_OWORD *)&v22._dictionary;
				//       v18._current = v22._current.key;
				//       ex = 0LL;
				//       v20 = &v18;
				//       try
				//       {
				//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                   &v18,
				//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext) )
				//         {
				//           v8 = v18._current;
				//           sub_180002C70(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
				//           sub_1825E07D0(&v15);
				//           sub_1825E07D0(&v15);
				//           if ( !v8 )
				//             sub_1802DC2C8(v10, v9);
				//           sub_18003F3E0(3LL, v8);
				//           sub_1823653D0(&v15);
				//           sub_1825E07D0(&v15);
				//         }
				//       }
				//       catch ( Il2CppExceptionWrapper *v23 )
				//       {
				//         ex = v23.ex;
				//         if ( ex )
				//           sub_18000F780(ex);
				//       }
				//       sub_180002C70(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
				//       sub_1825E07D0(&v15);
				//     }
				//     sub_180002C70(TypeInfo::Cysharp::Text::Utf16ValueStringBuilder);
				//     v24 = Cysharp::Text::Utf16ValueStringBuilder::ToString(&v15, 0LL);
				//     sub_1801E4E00(v16);
				//     return v24;
				//   }
				// }
				// 
				return null;
			}

			private void RefreshFeatureParameters(string feature)
			{
				// // Void RefreshFeatureParameters(String)
				// // Hidden C++ exception states: #wind=1
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshFeatureParameters(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         String *feature,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				//   Object *Item; // rax
				//   __int64 v10; // rdx
				//   __int64 v11; // rcx
				//   __int64 v12; // rdx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v14; // rdx
				//   __int64 v15; // rcx
				//   Il2CppExceptionWrapper *v16; // [rsp+20h] [rbp-48h] BYREF
				//   List_1_T_Enumerator_System_Object_ v17; // [rsp+28h] [rbp-40h] BYREF
				//   List_1_T_Enumerator_System_Object_ v18; // [rsp+40h] [rbp-28h] BYREF
				// 
				//   if ( !byte_18D8EDB43 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::ContainsKey);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Item);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
				//     byte_18D8EDB43 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(569, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(569, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v15, v14);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
				//       (ILFixDynamicMethodWrapper_37 *)Patch,
				//       (Object *)this,
				//       (Object *)feature,
				//       0LL);
				//   }
				//   else
				//   {
				//     if ( !this.fields.m_registeredParameters )
				//       sub_180B536AC(v6, v5);
				//     if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
				//            (Dictionary_2_System_Object_System_Object_ *)this.fields.m_registeredParameters,
				//            (Object *)feature,
				//            MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::ContainsKey) )
				//     {
				//       if ( !this.fields.m_registeredParameters )
				//         sub_180B536AC(v8, v7);
				//       Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
				//                (Dictionary_2_System_Object_System_Object_ *)this.fields.m_registeredParameters,
				//                (Object *)feature,
				//                MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Item);
				//       if ( !Item )
				//         sub_180B536AC(v11, v10);
				//       System::Collections::Generic::List<System::Object>::GetEnumerator(
				//         &v17,
				//         (List_1_System_Object_ *)Item,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
				//       v18 = v17;
				//       v17._list = 0LL;
				//       *(_QWORD *)&v17._index = &v18;
				//       try
				//       {
				//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                   &v18,
				//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext) )
				//         {
				//           if ( !v18._current )
				//             sub_1802DC2C8(0LL, v12);
				//           HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::Refresh(
				//             (HGRenderPipelineSettingHub_SettingParameterBase *)v18._current,
				//             this.fields.m_useDefaultSettings,
				//             0LL);
				//         }
				//       }
				//       catch ( Il2CppExceptionWrapper *v16 )
				//       {
				//         v17._list = (List_1_System_Object_ *)v16.ex;
				//         if ( v17._list )
				//           sub_18000F780(v17._list);
				//       }
				//     }
				//   }
				// }
				// 
			}

			private void RefreshSettingsInTable(HGRenderPipelineSettingHub.HGRenderPipelineSettings.BaseSettingTable settingTable)
			{
				// // Void RefreshSettingsInTable(HGRenderPipelineSettingHub+HGRenderPipelineSettings+BaseSettingTable)
				// // Hidden C++ exception states: #wind=2
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshSettingsInTable(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *settingTable,
				//         MethodInfo *method)
				// {
				//   Object *v3; // r12
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *v4; // r13
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   Object__Class *klass; // rbx
				//   SectionCollection *dummy; // rbx
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   IEnumerator_1_IniParser_Model_Section_ *v11; // rsi
				//   struct IEnumerator__Class *v12; // rdi
				//   IEnumerator_1_IniParser_Model_Section___Class *v13; // r14
				//   unsigned __int16 v14; // cx
				//   unsigned __int16 v15; // dx
				//   Il2CppRuntimeInterfaceOffsetPair *interfaceOffsets; // r8
				//   __int64 v17; // rdx
				//   __int64 v18; // rcx
				//   IEnumerator_1_IniParser_Model_Section_ *v19; // rsi
				//   struct IEnumerator_1_IniParser_Model_Section___Class *v20; // rdi
				//   IEnumerator_1_IniParser_Model_Section___Class *v21; // r14
				//   unsigned __int16 v22; // cx
				//   unsigned __int16 v23; // dx
				//   Il2CppRuntimeInterfaceOffsetPair *v24; // r8
				//   __int64 v25; // rdx
				//   __int64 v26; // rax
				//   __int64 v27; // rdx
				//   __int64 v28; // rcx
				//   String *v29; // r14
				//   struct HGRenderPipelineSettingHub_ConstantStrings__Class *v30; // rax
				//   String *SUBLEVEL_STR; // rsi
				//   unsigned int v32; // r8d
				//   __int64 v33; // rdi
				//   void (__fastcall __noreturn **v34)(); // rax
				//   unsigned int v35; // eax
				//   unsigned int v36; // r8d
				//   __int64 v37; // rax
				//   unsigned int *v38; // rdx
				//   signed __int64 v39; // r9
				//   __int64 *v40; // rdx
				//   unsigned __int64 v41; // r8
				//   __int64 v42; // rtt
				//   __int64 v43; // rdi
				//   __int64 v44; // rax
				//   __int64 v45; // rdi
				//   _QWORD **v46; // rcx
				//   __int64 v47; // r8
				//   __int64 v48; // rax
				//   __int64 v49; // rdx
				//   String__Array *v50; // rax
				//   __int64 v51; // rdx
				//   __int64 v52; // r8
				//   __int64 v53; // r9
				//   HashSet_1_System_Object_ *m_dirtyFeatureSettings; // rcx
				//   MonitorData *monitor; // r9
				//   __int64 *v56; // rdx
				//   __int64 v57; // rtt
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v59; // rdx
				//   __int64 v60; // rcx
				//   Il2CppExceptionWrapper *v61; // [rsp+38h] [rbp-90h] BYREF
				//   Il2CppExceptionWrapper *v62; // [rsp+40h] [rbp-88h] BYREF
				//   int v63; // [rsp+48h] [rbp-80h] BYREF
				//   _BYTE v64[24]; // [rsp+58h] [rbp-70h] BYREF
				//   List_1_T_Enumerator_System_Object_ v65; // [rsp+70h] [rbp-58h] BYREF
				//   IEnumerator_1_IniParser_Model_Section_ *Enumerator; // [rsp+E8h] [rbp+20h] BYREF
				// 
				//   v3 = (Object *)settingTable;
				//   v4 = this;
				//   if ( !byte_18D8EDB44 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//     sub_18003C530(&TypeInfo::System::IDisposable);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Section>);
				//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::GetEnumerator);
				//     byte_18D8EDB44 = 1;
				//   }
				//   Enumerator = 0LL;
				//   memset(&v65, 0, sizeof(v65));
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3249, 0LL) )
				//   {
				//     if ( !v3 )
				//       sub_180B536AC(v6, v5);
				//     klass = v3[3].klass;
				//     if ( !klass )
				//       sub_180B536AC(v6, v5);
				//     if ( !klass._0.byval_arg.data.dummy )
				//       goto LABEL_69;
				//     dummy = (SectionCollection *)klass._0.byval_arg.data.dummy;
				//     if ( !dummy )
				//       sub_180B536AC(v6, v5);
				//     Enumerator = IniParser::Model::SectionCollection::GetEnumerator(dummy, 0LL);
				//     *(_QWORD *)v64 = 0LL;
				//     *(_QWORD *)&v64[8] = &Enumerator;
				//     try
				//     {
				//       while ( 1 )
				//       {
				//         v11 = Enumerator;
				//         if ( !Enumerator )
				//           sub_1802DC2C8(v10, v9);
				//         v12 = TypeInfo::System::Collections::IEnumerator;
				//         v13 = Enumerator.klass;
				//         sub_180003EE0(Enumerator.klass);
				//         v14 = 0;
				//         v15 = *(_WORD *)&v13._1.naturalAligment;
				//         if ( v15 )
				//         {
				//           interfaceOffsets = v13.interfaceOffsets;
				//           while ( (struct IEnumerator__Class *)interfaceOffsets[v14].interfaceType != v12 )
				//           {
				//             if ( ++v14 >= v15 )
				//               goto LABEL_14;
				//           }
				//           v17 = (__int64)(&v13.vtable.get_Current.method + 2 * interfaceOffsets[v14].offset);
				//         }
				//         else
				//         {
				// LABEL_14:
				//           v17 = sub_18003CDA0(v11, v12, 0LL);
				//         }
				//         if ( !(*(unsigned __int8 (__fastcall **)(IEnumerator_1_IniParser_Model_Section_ *, _QWORD))v17)(
				//                 v11,
				//                 *(_QWORD *)(v17 + 8)) )
				//           break;
				//         v19 = Enumerator;
				//         if ( !Enumerator )
				//           sub_1802DC2C8(v18, v5);
				//         v20 = TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Section>;
				//         v21 = Enumerator.klass;
				//         sub_180003EE0(Enumerator.klass);
				//         v22 = 0;
				//         v23 = *(_WORD *)&v21._1.naturalAligment;
				//         if ( v23 )
				//         {
				//           v24 = v21.interfaceOffsets;
				//           while ( (struct IEnumerator_1_IniParser_Model_Section___Class *)v24[v22].interfaceType != v20 )
				//           {
				//             if ( ++v22 >= v23 )
				//               goto LABEL_21;
				//           }
				//           v25 = (__int64)(&v21.vtable.get_Current.method + 2 * v24[v22].offset);
				//         }
				//         else
				//         {
				// LABEL_21:
				//           v25 = sub_18003CDA0(v19, v20, 0LL);
				//         }
				//         v26 = (*(__int64 (__fastcall **)(IEnumerator_1_IniParser_Model_Section_ *, _QWORD))v25)(
				//                 v19,
				//                 *(_QWORD *)(v25 + 8));
				//         if ( !v26 )
				//           sub_1802DC2C8(v28, v27);
				//         v29 = *(String **)(v26 + 32);
				//         v30 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				//         if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings._1.cctor_finished_or_no_cctor )
				//         {
				//           il2cpp_runtime_class_init_0(
				//             TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings,
				//             v27);
				//           v30 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				//         }
				//         SUBLEVEL_STR = v30.static_fields.SUBLEVEL_STR;
				//         if ( !v29 )
				//           sub_1802DC2C8(v28, v27);
				//         if ( !byte_18D8F1F80 )
				//         {
				//           v32 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::System::String, 0LL);
				//           if ( (v32 & 1) != 0 )
				//           {
				//             v33 = (v32 >> 1) & 0xFFFFFFF;
				//             switch ( v32 >> 29 )
				//             {
				//               case 1u:
				//                 v34 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v33);
				//                 goto LABEL_56;
				//               case 2u:
				//                 v34 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v33);
				//                 goto LABEL_56;
				//               case 3u:
				//               case 6u:
				//                 v35 = (v32 >> 1) & 0xFFFFFFF;
				//                 v36 = v32 >> 29;
				//                 if ( v36 )
				//                 {
				//                   if ( v36 == 3 )
				//                   {
				//                     v34 = (void (__fastcall __noreturn **)())sub_180039480(v35);
				//                     goto LABEL_56;
				//                   }
				//                   if ( v36 == 6 )
				//                   {
				//                     v37 = sub_1802DF9C0(v35);
				//                     v34 = (void (__fastcall __noreturn **)())sub_18005F4B0(v37, 0LL);
				//                     goto LABEL_56;
				//                   }
				//                 }
				//                 else if ( v35 == 1 )
				//                 {
				//                   v34 = off_18A2C5600;
				//                   goto LABEL_56;
				//                 }
				// LABEL_55:
				//                 v34 = 0LL;
				// LABEL_56:
				//                 if ( v34 )
				//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::System::String, (__int64)v34);
				//                 break;
				//               case 4u:
				//                 v34 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v33);
				//                 goto LABEL_56;
				//               case 5u:
				//                 if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v33) )
				//                 {
				//                   v34 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v33);
				//                 }
				//                 else
				//                 {
				//                   v38 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v33);
				//                   v39 = il2cpp_string_new_len(qword_18D8E5198 + (int)v38[1] + *(int *)(qword_18D8E51A0 + 16), *v38);
				//                   v34 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
				//                                                              (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v33),
				//                                                              v39,
				//                                                              0LL);
				//                   if ( !v34 )
				//                   {
				//                     if ( dword_18D8E43F8 )
				//                     {
				//                       v40 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v33) >> 12) & 0x1FFFFF) >> 6];
				//                       v41 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v33) >> 12) & 0x3F;
				//                       _m_prefetchw(v40);
				//                       do
				//                         v42 = *v40;
				//                       while ( v42 != _InterlockedCompareExchange64(v40, *v40 | (1LL << v41), *v40) );
				//                     }
				//                     v34 = (void (__fastcall __noreturn **)())v39;
				//                   }
				//                 }
				//                 goto LABEL_56;
				//               case 7u:
				//                 v43 = sub_1802DF920((unsigned int)v33);
				//                 v44 = *(_QWORD *)(v43 + 16);
				//                 v45 = (v43 - *(_QWORD *)(v44 + 128)) >> 5;
				//                 if ( *(_BYTE *)(v44 + 42) == 21 )
				//                 {
				//                   v46 = *(_QWORD ***)(v44 + 96);
				//                   if ( *v46 )
				//                   {
				//                     v47 = **v46 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
				//                     v44 = sub_180039550(v47 / 92 + v47);
				//                   }
				//                   else
				//                   {
				//                     v44 = 0LL;
				//                   }
				//                 }
				//                 v63 = v45 + *(_DWORD *)(*(_QWORD *)(v44 + 104) + 32LL);
				//                 v48 = sub_1801B8ECC(
				//                         (unsigned int)&v63,
				//                         (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
				//                         *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
				//                         12,
				//                         (__int64)sub_1802C7760);
				//                 if ( !v48 )
				//                   goto LABEL_55;
				//                 v49 = *(unsigned int *)(v48 + 8);
				//                 if ( (_DWORD)v49 == -1 )
				//                   goto LABEL_55;
				//                 v34 = (void (__fastcall __noreturn **)())(v49 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
				//                 goto LABEL_56;
				//               default:
				//                 break;
				//             }
				//           }
				//           byte_18D8F1F80 = 1;
				//         }
				//         if ( !SUBLEVEL_STR )
				//           SUBLEVEL_STR = TypeInfo::System::String.static_fields.Empty;
				//         v50 = System::String::SplitInternal(v29, SUBLEVEL_STR, 0LL, 0x7FFFFFFF, StringSplitOptions__Enum_None, 0LL);
				//         m_dirtyFeatureSettings = (HashSet_1_System_Object_ *)v4.fields.m_dirtyFeatureSettings;
				//         if ( !v50 )
				//           sub_1802DC2C8(m_dirtyFeatureSettings, v51);
				//         if ( !v50.max_length.size )
				//           sub_180070260(m_dirtyFeatureSettings, v51, v52, v53);
				//         if ( !m_dirtyFeatureSettings )
				//           sub_1802DC2C8(0LL, v51);
				//         System::Collections::Generic::HashSet<System::Object>::Add(
				//           m_dirtyFeatureSettings,
				//           (Object *)v50.vector[0],
				//           MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//       }
				//     }
				//     catch ( Il2CppExceptionWrapper *v61 )
				//     {
				//       *(Il2CppExceptionWrapper *)v64 = (Il2CppExceptionWrapper)v61.ex;
				//       sub_18289B040(&v64[8]);
				//       if ( *(_QWORD *)v64 )
				//         sub_18000F780(*(_QWORD *)v64);
				//       v3 = (Object *)settingTable;
				//       v4 = this;
				// LABEL_69:
				//       if ( !v3 || (monitor = v3[1].monitor) == 0LL )
				//         sub_1802DC2C8(0x180000000uLL, v5);
				//       *(_OWORD *)&v64[8] = 0LL;
				//       *(_QWORD *)v64 = monitor;
				//       if ( dword_18D8E43F8 )
				//       {
				//         v56 = (__int64 *)(0x180000000LL + 8 * ((((unsigned __int64)v64 >> 12) & 0x1FFFFF) >> 6) + 224948432);
				//         _m_prefetchw(v56);
				//         do
				//           v57 = *v56;
				//         while ( v57 != _InterlockedCompareExchange64(v56, *v56 | (1LL << (((unsigned __int64)v64 >> 12) & 0x3F)), *v56) );
				//       }
				//       *(_DWORD *)&v64[8] = 0;
				//       *(_DWORD *)&v64[12] = *((_DWORD *)monitor + 7);
				//       *(_QWORD *)&v64[16] = 0LL;
				//       *(_OWORD *)&v65._list = *(_OWORD *)v64;
				//       v65._current = 0LL;
				//       *(_QWORD *)v64 = 0LL;
				//       *(_QWORD *)&v64[8] = &v65;
				//       try
				//       {
				//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                   &v65,
				//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::MoveNext) )
				//           HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshSettingsInTable(
				//             v4,
				//             (HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *)v65._current,
				//             0LL);
				//       }
				//       catch ( Il2CppExceptionWrapper *v62 )
				//       {
				//         *(Il2CppExceptionWrapper *)v64 = (Il2CppExceptionWrapper)v62.ex;
				//         if ( *(_QWORD *)v64 )
				//           sub_18000F780(*(_QWORD *)v64);
				//       }
				//       return;
				//     }
				//     if ( Enumerator )
				//       sub_18005CC40(0LL, TypeInfo::System::IDisposable, Enumerator);
				//     goto LABEL_69;
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(3249, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v60, v59);
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v4, v3, 0LL);
				// }
				// 
			}

			public void RefreshAllSettings()
			{
				// // Void RefreshAllSettings()
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshAllSettings(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3248, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3248, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshSettingsInTable(
				//       this,
				//       this.fields.m_settingTable,
				//       0LL);
				//   }
				// }
				// 
			}

			public void RefreshDirtySettings()
			{
				// // Void RefreshDirtySettings()
				// // Hidden C++ exception states: #wind=2
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshDirtySettings(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         MethodInfo *method)
				// {
				//   PassConstructorID__Enum__Array *v2; // r8
				//   HGCamera *v3; // r9
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *v4; // rbx
				//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
				//   ILFixDynamicMethodWrapper_2__Array *v7; // rdi
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   HashSet_1_System_String_ *m_dirtyFeatureSettings; // rdi
				//   _BYTE *v12; // rdx
				//   __int64 v13; // rcx
				//   HashSet_1_System_String_ *v14; // r9
				//   __int64 *v15; // rdx
				//   signed __int64 v16; // rcx
				//   __int64 v17; // rtt
				//   Object *current; // rdi
				//   Dictionary_2_System_Object_System_Object_ *m_settingChangeCallbacks; // rcx
				//   __int64 v20; // rdx
				//   unsigned int currentDeviceTier_k__BackingField; // esi
				//   Dictionary_2_System_Object_System_Int32_ *m_overrideFeatureSettingTiers; // rcx
				//   __int64 v23; // rdx
				//   Dictionary_2_System_Object_System_Int32_ *v24; // rcx
				//   Dictionary_2_System_Object_System_Object_ *v25; // rcx
				//   Object *Item; // rax
				//   __int64 v27; // rdx
				//   __int64 v28; // rcx
				//   HashSet_1_System_String_ *v29; // rbx
				//   Int32__Array *buckets; // r8
				//   _BYTE v31[32]; // [rsp+0h] [rbp-78h] BYREF
				//   MethodInfo *v32; // [rsp+20h] [rbp-58h] BYREF
				//   MethodInfo *v33; // [rsp+28h] [rbp-50h] BYREF
				//   _BYTE v34[24]; // [rsp+30h] [rbp-48h] BYREF
				//   HashSet_1_T_Enumerator_System_Object_ v35; // [rsp+48h] [rbp-30h] BYREF
				// 
				//   v4 = this;
				//   if ( !byte_18D8EDB45 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::ContainsKey);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>::ContainsKey);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>::get_Item);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::get_Item);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::String>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::String>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::String>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<System::String>::Clear);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<System::String>::GetEnumerator);
				//     byte_18D8EDB45 = 1;
				//   }
				//   if ( !byte_18D8EDC37 )
				//   {
				//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
				//     byte_18D8EDC37 = 1;
				//   }
				//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   wrapperArray = v5.static_fields.wrapperArray;
				//   if ( !wrapperArray )
				//     sub_180B536AC(v5, method);
				//   if ( wrapperArray.max_length.size <= 568 )
				//     goto LABEL_16;
				//   if ( !v5._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v5, method);
				//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   v7 = v5.static_fields.wrapperArray;
				//   if ( !v7 )
				//     sub_180B536AC(v5, method);
				//   if ( v7.max_length.size <= 0x238u )
				//     sub_180070270(v5, method);
				//   if ( !v7[15].vector[28] )
				//   {
				// LABEL_16:
				//     m_dirtyFeatureSettings = v4.fields.m_dirtyFeatureSettings;
				//     if ( !m_dirtyFeatureSettings )
				//       sub_180B536AC(v5, method);
				//     *(_OWORD *)&v34[8] = 0LL;
				//     *(_QWORD *)v34 = m_dirtyFeatureSettings;
				//     sub_1800054D0((HGRenderPathScene *)v34, (HGRenderPathBase_HGRenderPathResources *)method, v2, v3, v32, v33);
				//     *(_DWORD *)&v34[8] = 0;
				//     *(_DWORD *)&v34[12] = m_dirtyFeatureSettings.fields._version;
				//     *(_QWORD *)&v34[16] = 0LL;
				//     *(_OWORD *)&v35._set = *(_OWORD *)v34;
				//     v35._current = 0LL;
				//     *(_QWORD *)v34 = 0LL;
				//     *(_QWORD *)&v34[8] = &v35;
				//     try
				//     {
				//       while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
				//                 &v35,
				//                 MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::String>::MoveNext) )
				//         HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshFeatureParameters(
				//           v4,
				//           (String *)v35._current,
				//           0LL);
				//     }
				//     catch ( Il2CppExceptionWrapper *v32 )
				//     {
				//       v12 = v31;
				//       *(_QWORD *)v34 = v32.methodPointer;
				//       v13 = *(_QWORD *)v34;
				//       if ( *(_QWORD *)v34 )
				//         sub_18000F780(*(_QWORD *)v34);
				//       v4 = this;
				//     }
				//     v14 = v4.fields.m_dirtyFeatureSettings;
				//     if ( v14 )
				//     {
				//       *(_OWORD *)&v34[8] = 0LL;
				//       *(_QWORD *)v34 = v14;
				//       if ( dword_18D8E43F8 )
				//       {
				//         v15 = &qword_18D6870D0[(((unsigned __int64)v34 >> 12) & 0x1FFFFF) >> 6];
				//         _m_prefetchw(v15);
				//         do
				//         {
				//           v16 = *v15 | (1LL << (((unsigned __int64)v34 >> 12) & 0x3F));
				//           v17 = *v15;
				//         }
				//         while ( v17 != _InterlockedCompareExchange64(v15, v16, *v15) );
				//       }
				//       *(_DWORD *)&v34[8] = 0;
				//       *(_DWORD *)&v34[12] = v14.fields._version;
				//       *(_QWORD *)&v34[16] = 0LL;
				//       *(_OWORD *)&v35._set = *(_OWORD *)v34;
				//       v35._current = 0LL;
				//       *(_QWORD *)v34 = 0LL;
				//       *(_QWORD *)&v34[8] = &v35;
				//       try
				//       {
				//         while ( System::Collections::Generic::HashSet_1_T_::Enumerator<System::Object>::MoveNext(
				//                   &v35,
				//                   MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<System::String>::MoveNext) )
				//         {
				//           current = v35._current;
				//           m_settingChangeCallbacks = (Dictionary_2_System_Object_System_Object_ *)v4.fields.m_settingChangeCallbacks;
				//           if ( !m_settingChangeCallbacks )
				//             sub_1802DC2C8(0LL, v12);
				//           if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
				//                  m_settingChangeCallbacks,
				//                  v35._current,
				//                  MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>::ContainsKey) )
				//           {
				//             currentDeviceTier_k__BackingField = v4.fields._currentDeviceTier_k__BackingField;
				//             m_overrideFeatureSettingTiers = (Dictionary_2_System_Object_System_Int32_ *)v4.fields.m_overrideFeatureSettingTiers;
				//             if ( !m_overrideFeatureSettingTiers )
				//               sub_1802DC2C8(0LL, v20);
				//             if ( System::Collections::Generic::Dictionary<System::Object,int>::ContainsKey(
				//                    m_overrideFeatureSettingTiers,
				//                    current,
				//                    MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::ContainsKey) )
				//             {
				//               v24 = (Dictionary_2_System_Object_System_Int32_ *)v4.fields.m_overrideFeatureSettingTiers;
				//               if ( !v24 )
				//                 sub_1802DC2C8(0LL, v23);
				//               currentDeviceTier_k__BackingField = System::Collections::Generic::Dictionary<System::Object,int>::get_Item(
				//                                                     v24,
				//                                                     current,
				//                                                     MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::get_Item);
				//             }
				//             v25 = (Dictionary_2_System_Object_System_Object_ *)v4.fields.m_settingChangeCallbacks;
				//             if ( !v25 )
				//               sub_1802DC2C8(0LL, v23);
				//             Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
				//                      v25,
				//                      current,
				//                      MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>::get_Item);
				//             if ( !Item )
				//               sub_1802DC2C8(v28, v27);
				//             sub_182ACD9D0(
				//               Item,
				//               (unsigned int)v4.fields._currentDeviceType_k__BackingField,
				//               currentDeviceTier_k__BackingField);
				//           }
				//         }
				//       }
				//       catch ( Il2CppExceptionWrapper *v33 )
				//       {
				//         v12 = v31;
				//         *(_QWORD *)v34 = v33.methodPointer;
				//         v13 = *(_QWORD *)v34;
				//         if ( *(_QWORD *)v34 )
				//           sub_18000F780(*(_QWORD *)v34);
				//         v4 = this;
				//       }
				//       v29 = v4.fields.m_dirtyFeatureSettings;
				//       if ( v29 )
				//       {
				//         if ( v29.fields._lastIndex <= 0 )
				//         {
				// LABEL_43:
				//           ++v29.fields._version;
				//           return;
				//         }
				//         System::Array::Clear((Array *)v29.fields._slots, 0, v29.fields._lastIndex, 0LL);
				//         buckets = v29.fields._buckets;
				//         if ( buckets )
				//         {
				//           System::Array::Clear((Array *)v29.fields._buckets, 0, buckets.max_length.size, 0LL);
				//           *(_QWORD *)&v29.fields._count = 0LL;
				//           v29.fields._freeList = -1;
				//           goto LABEL_43;
				//         }
				//       }
				//     }
				//     sub_1802DC2C8(v13, v12);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(568, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v10, v9);
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v4, 0LL);
				// }
				// 
			}

			internal HGRenderPipelineSettingHub.SettingParameterBase RegisterParameter(HGRenderPipelineSettingHub.SettingParameterBase param, string feature)
			{
				// // HGRenderPipelineSettingHub+SettingParameterBase RegisterParameter(HGRenderPipelineSettingHub+SettingParameterBase, String)
				// HGRenderPipelineSettingHub_SettingParameterBase *HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RegisterParameter(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         HGRenderPipelineSettingHub_SettingParameterBase *param,
				//         String *feature,
				//         MethodInfo *method)
				// {
				//   __int64 v7; // rax
				//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
				//   Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *m_registeredParameters; // rcx
				//   PassConstructorID__Enum__Array *v10; // r8
				//   HGCamera *v11; // r9
				//   __int64 v12; // rbx
				//   Object *Item; // r14
				//   Predicate_1_Object_ *v14; // rax
				//   Predicate_1_Object_ *v15; // rsi
				//   int32_t Index; // esi
				//   Object *v17; // rax
				//   __int64 v18; // r8
				//   __int64 v19; // r9
				//   __int64 v20; // rax
				//   String__Array *v21; // rdi
				//   __int64 v22; // r8
				//   Object *v23; // rdi
				//   Object *v25; // rax
				//   Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *v26; // r14
				//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v27; // rax
				//   Object *v28; // rsi
				//   ILFixDynamicMethodWrapper_37 *Patch; // rax
				//   ILFixDynamicMethodWrapper_2 *v30; // rax
				//   MethodInfo *methoda; // [rsp+20h] [rbp-18h]
				//   MethodInfo *v32; // [rsp+28h] [rbp-10h]
				// 
				//   if ( !byte_18D8EDB46 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::ContainsKey);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Item);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::set_Item);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::FindIndex);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::List);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::set_Item);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>);
				//     sub_18003C530(&TypeInfo::System::Predicate<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>);
				//     sub_18003C530(&TypeInfo::System::String);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c__DisplayClass43_0::_RegisterParameter_b__0);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c__DisplayClass43_0);
				//     sub_18003C530(&off_18C9054B8);
				//     sub_18003C530(&off_18C9054C0);
				//     sub_18003C530(&off_18C9054C8);
				//     byte_18D8EDB46 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3273, 0LL) )
				//   {
				//     v7 = sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c__DisplayClass43_0);
				//     v12 = v7;
				//     if ( v7 )
				//     {
				//       *(_QWORD *)(v7 + 16) = param;
				//       sub_1800054D0((HGRenderPathScene *)(v7 + 16), v8, v10, v11, methoda, v32);
				//       m_registeredParameters = this.fields.m_registeredParameters;
				//       if ( m_registeredParameters )
				//       {
				//         if ( !System::Collections::Generic::Dictionary<System::Object,System::Object>::ContainsKey(
				//                 (Dictionary_2_System_Object_System_Object_ *)m_registeredParameters,
				//                 (Object *)feature,
				//                 MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::ContainsKey) )
				//         {
				//           v26 = this.fields.m_registeredParameters;
				//           v27 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>);
				//           v28 = (Object *)v27;
				//           if ( !v27 )
				//             goto LABEL_23;
				//           System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
				//             v27,
				//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::List);
				//           if ( !v26 )
				//             goto LABEL_23;
				//           System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
				//             (Dictionary_2_System_Object_System_Object_ *)v26,
				//             (Object *)feature,
				//             v28,
				//             MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::set_Item);
				//         }
				//         m_registeredParameters = this.fields.m_registeredParameters;
				//         if ( m_registeredParameters )
				//         {
				//           Item = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
				//                    (Dictionary_2_System_Object_System_Object_ *)m_registeredParameters,
				//                    (Object *)feature,
				//                    MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Item);
				//           v14 = (Predicate_1_Object_ *)sub_180004920(TypeInfo::System::Predicate<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>);
				//           v15 = v14;
				//           if ( v14 )
				//           {
				//             System::Predicate<System::Object>::Predicate(
				//               v14,
				//               (Object *)v12,
				//               MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c__DisplayClass43_0::_RegisterParameter_b__0,
				//               0LL);
				//             if ( Item )
				//             {
				//               Index = System::Collections::Generic::List<System::Object>::FindIndex(
				//                         (List_1_System_Object_ *)Item,
				//                         v15,
				//                         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::FindIndex);
				//               if ( Index == -1 )
				//               {
				//                 if ( this.fields.m_registeredParameters )
				//                 {
				//                   v25 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
				//                           (Dictionary_2_System_Object_System_Object_ *)this.fields.m_registeredParameters,
				//                           (Object *)feature,
				//                           MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Item);
				//                   if ( v25 )
				//                   {
				//                     sub_1822AD140((List_1_System_Object_ *)v25, *(Object **)(v12 + 16));
				//                     return *(HGRenderPipelineSettingHub_SettingParameterBase **)(v12 + 16);
				//                   }
				//                 }
				//               }
				//               else if ( this.fields.m_registeredParameters )
				//               {
				//                 v17 = System::Collections::Generic::Dictionary<System::Object,System::Object>::get_Item(
				//                         (Dictionary_2_System_Object_System_Object_ *)this.fields.m_registeredParameters,
				//                         (Object *)feature,
				//                         MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Item);
				//                 if ( v17 )
				//                 {
				//                   System::Collections::Generic::List<System::Object>::set_Item(
				//                     (List_1_System_Object_ *)v17,
				//                     Index,
				//                     *(Object **)(v12 + 16),
				//                     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::set_Item);
				//                   v20 = il2cpp_array_new_specific_0(TypeInfo::System::String, 5LL, v18, v19);
				//                   v21 = (String__Array *)v20;
				//                   if ( v20 )
				//                   {
				//                     sub_1800046C0(v20, 0LL, "Feature:");
				//                     sub_1800046C0(v21, 1LL, feature);
				//                     sub_1800046C0(v21, 2LL, " param:");
				//                     v22 = *(_QWORD *)(v12 + 16);
				//                     if ( v22 )
				//                     {
				//                       sub_1800046C0(v21, 3LL, *(_QWORD *)(v22 + 24));
				//                       sub_1800046C0(v21, 4LL, " has been registered already, is this intended?");
				//                       v23 = (Object *)System::String::Concat(v21, 0LL);
				//                       if ( !IFix::WrappersManagerImpl::IsPatched(2, 0LL) )
				//                         return *(HGRenderPipelineSettingHub_SettingParameterBase **)(v12 + 16);
				//                       Patch = IFix::WrappersManagerImpl::GetPatch(2, 0LL);
				//                       if ( Patch )
				//                       {
				//                         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(Patch, v23, 0LL);
				//                         return *(HGRenderPipelineSettingHub_SettingParameterBase **)(v12 + 16);
				//                       }
				//                     }
				//                   }
				//                 }
				//               }
				//             }
				//           }
				//         }
				//       }
				//     }
				// LABEL_23:
				//     sub_180B536AC(m_registeredParameters, v8);
				//   }
				//   v30 = IFix::WrappersManagerImpl::GetPatch(3273, 0LL);
				//   if ( !v30 )
				//     goto LABEL_23;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1165(v30, (Object *)this, (Object *)param, (Object *)feature, 0LL);
				// }
				// 
				return null;
			}

			public void RegisterSettingChangeCallback(string featureName, HGRenderPipelineSettingHub.OnSettingChanged callback)
			{
				// // Void RegisterSettingChangeCallback(String, HGRenderPipelineSettingHub+OnSettingChanged)
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RegisterSettingChangeCallback(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         String *featureName,
				//         HGRenderPipelineSettingHub_OnSettingChanged *callback,
				//         MethodInfo *method)
				// {
				//   __int64 v7; // rdx
				//   Dictionary_2_System_Object_System_Object_ *m_settingChangeCallbacks; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDB47 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>::set_Item);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//     byte_18D8EDB47 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(452, 0LL) )
				//   {
				//     m_settingChangeCallbacks = (Dictionary_2_System_Object_System_Object_ *)this.fields.m_settingChangeCallbacks;
				//     if ( m_settingChangeCallbacks )
				//     {
				//       System::Collections::Generic::Dictionary<System::Object,System::Object>::set_Item(
				//         m_settingChangeCallbacks,
				//         (Object *)featureName,
				//         (Object *)callback,
				//         MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub::OnSettingChanged>::set_Item);
				//       m_settingChangeCallbacks = (Dictionary_2_System_Object_System_Object_ *)this.fields.m_dirtyFeatureSettings;
				//       if ( m_settingChangeCallbacks )
				//       {
				//         System::Collections::Generic::HashSet<System::Object>::Add(
				//           (HashSet_1_System_Object_ *)m_settingChangeCallbacks,
				//           (Object *)featureName,
				//           MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//         return;
				//       }
				//     }
				// LABEL_7:
				//     sub_180B536AC(m_settingChangeCallbacks, v7);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(452, 0LL);
				//   if ( !Patch )
				//     goto LABEL_7;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
				//     (ILFixDynamicMethodWrapper_28 *)Patch,
				//     (Object *)this,
				//     (Object *)featureName,
				//     (Object *)callback,
				//     0LL);
				// }
				// 
			}

			public bool ResetRegisteredParameter(string paramName)
			{
				// // Boolean ResetRegisteredParameter(String)
				// // Hidden C++ exception states: #wind=2 #try_helpers=2
				// bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetRegisteredParameter(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         String *paramName,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *m_registeredParameters; // rbx
				//   __int64 v8; // rcx
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   Object *current; // rbx
				//   MonitorData *monitor; // rcx
				//   __int64 v13; // rdx
				//   __int64 v14; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v17; // rdx
				//   __int64 v18; // rcx
				//   List_1_T_Enumerator_System_Object_ v19; // [rsp+20h] [rbp-A8h] BYREF
				//   __int64 v20; // [rsp+38h] [rbp-90h]
				//   List_1_T_Enumerator_System_Object_ *v21; // [rsp+40h] [rbp-88h]
				//   __int64 v22; // [rsp+48h] [rbp-80h]
				//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *v23; // [rsp+50h] [rbp-78h]
				//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v24; // [rsp+58h] [rbp-70h] BYREF
				//   List_1_T_Enumerator_System_Object_ v25[2]; // [rsp+90h] [rbp-38h] BYREF
				// 
				//   if ( !byte_18D9196E7 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Value);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
				//     byte_18D9196E7 = 1;
				//   }
				//   memset(&v24, 0, sizeof(v24));
				//   memset(&v19, 0, sizeof(v19));
				//   if ( IFix::WrappersManagerImpl::IsPatched(3268, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3268, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v18, v17);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
				//              (ILFixDynamicMethodWrapper_36 *)Patch,
				//              (Object *)this,
				//              (Object *)paramName,
				//              0LL);
				//   }
				//   else
				//   {
				//     m_registeredParameters = this.fields.m_registeredParameters;
				//     if ( !m_registeredParameters )
				//       sub_180B536AC(v6, v5);
				//     v24 = *(Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)sub_180831998(
				//                                                                                  v25,
				//                                                                                  m_registeredParameters);
				//     v22 = 0LL;
				//     v23 = &v24;
				//     while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
				//               &v24,
				//               MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::MoveNext) )
				//     {
				//       if ( !v24._current.value )
				//         sub_1802DC2C8(v8, 0LL);
				//       System::Collections::Generic::List<System::Object>::GetEnumerator(
				//         v25,
				//         (List_1_System_Object_ *)v24._current.value,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
				//       v19 = v25[0];
				//       v20 = 0LL;
				//       v21 = &v19;
				//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                 &v19,
				//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext) )
				//       {
				//         current = v19._current;
				//         if ( !v19._current )
				//           sub_1802DC2C8(v10, v9);
				//         monitor = v19._current[1].monitor;
				//         if ( !monitor )
				//           sub_1802DC2C8(0LL, v9);
				//         if ( System::String::Equals((String *)monitor, paramName, StringComparison__Enum_OrdinalIgnoreCase, 0LL) )
				//         {
				//           if ( !current )
				//             sub_1802DC2C8(v14, v13);
				//           HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::Reset(
				//             (HGRenderPipelineSettingHub_SettingParameterBase *)current,
				//             0LL);
				//           return 1;
				//         }
				//       }
				//     }
				//     return 0;
				//   }
				// }
				// 
				return default(bool);
			}

			public void ResetRegisteredParameters()
			{
				// // Void ResetRegisteredParameters()
				// // Hidden C++ exception states: #wind=2
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetRegisteredParameters(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				//   Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *m_registeredParameters; // rbx
				//   __int64 v6; // rcx
				//   __int64 v7; // rdx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   List_1_T_Enumerator_System_Object_ v11; // [rsp+20h] [rbp-A8h] BYREF
				//   Il2CppException *ex; // [rsp+38h] [rbp-90h]
				//   List_1_T_Enumerator_System_Object_ *v13; // [rsp+40h] [rbp-88h]
				//   Il2CppException *v14; // [rsp+48h] [rbp-80h]
				//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *v15; // [rsp+50h] [rbp-78h]
				//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v16; // [rsp+58h] [rbp-70h] BYREF
				//   Il2CppExceptionWrapper *v17; // [rsp+80h] [rbp-48h] BYREF
				//   Il2CppExceptionWrapper *v18; // [rsp+88h] [rbp-40h] BYREF
				//   List_1_T_Enumerator_System_Object_ v19[2]; // [rsp+90h] [rbp-38h] BYREF
				// 
				//   if ( !byte_18D9196E8 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Value);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
				//     byte_18D9196E8 = 1;
				//   }
				//   memset(&v16, 0, sizeof(v16));
				//   memset(&v11, 0, sizeof(v11));
				//   if ( IFix::WrappersManagerImpl::IsPatched(3251, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3251, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v10, v9);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     m_registeredParameters = this.fields.m_registeredParameters;
				//     if ( !m_registeredParameters )
				//       sub_180B536AC(v4, v3);
				//     v16 = *(Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)sub_180831998(
				//                                                                                  v19,
				//                                                                                  m_registeredParameters);
				//     v14 = 0LL;
				//     v15 = &v16;
				//     try
				//     {
				//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
				//                 &v16,
				//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::MoveNext) )
				//       {
				//         if ( !v16._current.value )
				//           sub_1802DC2C8(v6, 0LL);
				//         System::Collections::Generic::List<System::Object>::GetEnumerator(
				//           v19,
				//           (List_1_System_Object_ *)v16._current.value,
				//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
				//         v11 = v19[0];
				//         ex = 0LL;
				//         v13 = &v11;
				//         try
				//         {
				//           while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                     &v11,
				//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext) )
				//           {
				//             if ( !v11._current )
				//               sub_1802DC2C8(0LL, v7);
				//             HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::Reset(
				//               (HGRenderPipelineSettingHub_SettingParameterBase *)v11._current,
				//               0LL);
				//           }
				//         }
				//         catch ( Il2CppExceptionWrapper *v17 )
				//         {
				//           ex = v17.ex;
				//           if ( ex )
				//             sub_18000F780(ex);
				//         }
				//       }
				//     }
				//     catch ( Il2CppExceptionWrapper *v18 )
				//     {
				//       v14 = v18.ex;
				//       if ( v14 )
				//         sub_18000F780(v14);
				//     }
				//   }
				// }
				// 
			}

			public bool OverrideSettingParameter(string paramName, string paramValue)
			{
				// // Boolean OverrideSettingParameter(String, String)
				// // Hidden C++ exception states: #wind=2 #try_helpers=2
				// bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::OverrideSettingParameter(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         String *paramName,
				//         String *paramValue,
				//         MethodInfo *method)
				// {
				//   Dictionary_2_System_String_List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_SettingParameterBase_ *registeredParameters; // rax
				//   __int64 v8; // rdx
				//   __int64 v9; // rcx
				//   __int64 v10; // rcx
				//   __int64 v11; // rdx
				//   __int64 v12; // rcx
				//   Object *current; // rbx
				//   MonitorData *monitor; // rcx
				//   __int64 v15; // rdx
				//   __int64 v16; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v19; // rdx
				//   __int64 v20; // rcx
				//   List_1_T_Enumerator_System_Object_ v21; // [rsp+30h] [rbp-B8h] BYREF
				//   __int64 v22; // [rsp+48h] [rbp-A0h]
				//   List_1_T_Enumerator_System_Object_ *v23; // [rsp+50h] [rbp-98h]
				//   __int64 v24; // [rsp+58h] [rbp-90h]
				//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *v25; // [rsp+60h] [rbp-88h]
				//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v26; // [rsp+68h] [rbp-80h] BYREF
				//   List_1_T_Enumerator_System_Object_ v27[3]; // [rsp+A0h] [rbp-48h] BYREF
				// 
				//   if ( !byte_18D9196E9 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::get_Value);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
				//     byte_18D9196E9 = 1;
				//   }
				//   memset(&v26, 0, sizeof(v26));
				//   memset(&v21, 0, sizeof(v21));
				//   if ( IFix::WrappersManagerImpl::IsPatched(3265, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3265, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v20, v19);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_10(
				//              (ILFixDynamicMethodWrapper_20 *)Patch,
				//              (Object *)this,
				//              (Object *)paramName,
				//              (Object *)paramValue,
				//              0LL);
				//   }
				//   else
				//   {
				//     registeredParameters = HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::get_registeredParameters(
				//                              this,
				//                              0LL);
				//     if ( !registeredParameters )
				//       sub_180B536AC(v9, v8);
				//     v26 = *(Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)sub_180831998(v27, registeredParameters);
				//     v24 = 0LL;
				//     v25 = &v26;
				//     while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
				//               &v26,
				//               MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>>::MoveNext) )
				//     {
				//       if ( !v26._current.value )
				//         sub_1802DC2C8(v10, 0LL);
				//       System::Collections::Generic::List<System::Object>::GetEnumerator(
				//         v27,
				//         (List_1_System_Object_ *)v26._current.value,
				//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::GetEnumerator);
				//       v21 = v27[0];
				//       v22 = 0LL;
				//       v23 = &v21;
				//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                 &v21,
				//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase>::MoveNext) )
				//       {
				//         current = v21._current;
				//         if ( !v21._current )
				//           sub_1802DC2C8(v12, v11);
				//         monitor = v21._current[1].monitor;
				//         if ( !monitor )
				//           sub_1802DC2C8(0LL, v11);
				//         if ( System::String::Equals((String *)monitor, paramName, StringComparison__Enum_OrdinalIgnoreCase, 0LL) )
				//         {
				//           if ( !current )
				//             sub_1802DC2C8(v16, v15);
				//           return sub_180047DA0(5LL, current, paramValue);
				//         }
				//       }
				//     }
				//     return 0;
				//   }
				// }
				// 
				return default(bool);
			}

			private static bool SupportDeviceType(HGDeviceType deviceType)
			{
				// // Boolean SupportDeviceType(HGDeviceType)
				// bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::SupportDeviceType(
				//         HGDeviceType__Enum deviceType,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3276, 0LL) )
				//     return ((deviceType - 1) & 0xFFFFFFFD) == 0 || deviceType == HGDeviceType__Enum_Cinematic;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(3276, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v6, v5);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(
				//            (ILFixDynamicMethodWrapper_17 *)Patch,
				//            (AudioLogChannel__Enum)deviceType,
				//            0LL);
				// }
				// 
				return default(bool);
			}

			public void ChangeSettingTier(int tier)
			{
				// // Void ChangeSettingTier(Int32)
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ChangeSettingTier(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         int32_t tier,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3255, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3255, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, tier, 0LL);
				//   }
				//   else if ( tier <= this.fields.maximumDeviceTier && this.fields._currentDeviceTier_k__BackingField != tier )
				//   {
				//     this.fields._currentDeviceTier_k__BackingField = tier;
				//     HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::RefreshAllSettings(this, 0LL);
				//   }
				// }
				// 
			}

			private void Reset()
			{
				// // Void Reset()
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::Reset(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3277, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3277, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::Initialize(
				//       this,
				//       HGDeviceType__Enum_Unknown,
				//       0LL);
				//     HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FeedSettingData(
				//       this,
				//       this.fields.m_settingData,
				//       0LL);
				//   }
				// }
				// 
			}

			public void MarkFeatureDirty(string featureName)
			{
				// // Void MarkFeatureDirty(String)
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::MarkFeatureDirty(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         String *featureName,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   HashSet_1_System_String_ *m_dirtyFeatureSettings; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDB48 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//     byte_18D8EDB48 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(692, 0LL) )
				//   {
				//     m_dirtyFeatureSettings = this.fields.m_dirtyFeatureSettings;
				//     if ( m_dirtyFeatureSettings )
				//     {
				//       System::Collections::Generic::HashSet<System::Object>::Add(
				//         (HashSet_1_System_Object_ *)m_dirtyFeatureSettings,
				//         (Object *)featureName,
				//         MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//       return;
				//     }
				// LABEL_6:
				//     sub_180B536AC(m_dirtyFeatureSettings, v5);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(692, 0LL);
				//   if ( !Patch )
				//     goto LABEL_6;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
				//     (ILFixDynamicMethodWrapper_37 *)Patch,
				//     (Object *)this,
				//     (Object *)featureName,
				//     0LL);
				// }
				// 
			}

			public void OverrideFeatureTier(string featureName, int tier)
			{
				// // Void OverrideFeatureTier(String, Int32)
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::OverrideFeatureTier(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         String *featureName,
				//         int32_t tier,
				//         MethodInfo *method)
				// {
				//   __int64 v7; // rdx
				//   Dictionary_2_System_Object_System_Int32_ *m_overrideFeatureSettingTiers; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D8EDB49 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::set_Item);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//     byte_18D8EDB49 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3258, 0LL) )
				//   {
				//     m_overrideFeatureSettingTiers = (Dictionary_2_System_Object_System_Int32_ *)this.fields.m_overrideFeatureSettingTiers;
				//     if ( m_overrideFeatureSettingTiers )
				//     {
				//       System::Collections::Generic::Dictionary<System::Object,int>::set_Item(
				//         m_overrideFeatureSettingTiers,
				//         (Object *)featureName,
				//         tier,
				//         MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::set_Item);
				//       m_overrideFeatureSettingTiers = (Dictionary_2_System_Object_System_Int32_ *)this.fields.m_dirtyFeatureSettings;
				//       if ( m_overrideFeatureSettingTiers )
				//       {
				//         System::Collections::Generic::HashSet<System::Object>::Add(
				//           (HashSet_1_System_Object_ *)m_overrideFeatureSettingTiers,
				//           (Object *)featureName,
				//           MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//         return;
				//       }
				//     }
				// LABEL_7:
				//     sub_180B536AC(m_overrideFeatureSettingTiers, v7);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(3258, 0LL);
				//   if ( !Patch )
				//     goto LABEL_7;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_34(
				//     (ILFixDynamicMethodWrapper_16 *)Patch,
				//     (Object *)this,
				//     (Object *)featureName,
				//     tier,
				//     0LL);
				// }
				// 
			}

			public void ResetFeatureTier(string featureName)
			{
				// // Void ResetFeatureTier(String)
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::ResetFeatureTier(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         String *featureName,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   Dictionary_2_System_Object_System_Int32_ *m_overrideFeatureSettingTiers; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D9196EA )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::Remove);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//     byte_18D9196EA = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3260, 0LL) )
				//   {
				//     m_overrideFeatureSettingTiers = (Dictionary_2_System_Object_System_Int32_ *)this.fields.m_overrideFeatureSettingTiers;
				//     if ( m_overrideFeatureSettingTiers )
				//     {
				//       System::Collections::Generic::Dictionary<System::Object,int>::Remove(
				//         m_overrideFeatureSettingTiers,
				//         (Object *)featureName,
				//         MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::Remove);
				//       m_overrideFeatureSettingTiers = (Dictionary_2_System_Object_System_Int32_ *)this.fields.m_dirtyFeatureSettings;
				//       if ( m_overrideFeatureSettingTiers )
				//       {
				//         System::Collections::Generic::HashSet<System::Object>::Add(
				//           (HashSet_1_System_Object_ *)m_overrideFeatureSettingTiers,
				//           (Object *)featureName,
				//           MethodInfo::System::Collections::Generic::HashSet<System::String>::Add);
				//         return;
				//       }
				//     }
				// LABEL_8:
				//     sub_180B536AC(m_overrideFeatureSettingTiers, v5);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(3260, 0LL);
				//   if ( !Patch )
				//     goto LABEL_8;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
				//     (ILFixDynamicMethodWrapper_37 *)Patch,
				//     (Object *)this,
				//     (Object *)featureName,
				//     0LL);
				// }
				// 
			}

			private void FlattenParameters(HGRenderPipelineSettingHub.HGRenderPipelineSettings.BaseSettingTable entryTable)
			{
				// // Void FlattenParameters(HGRenderPipelineSettingHub+HGRenderPipelineSettings+BaseSettingTable)
				// // Hidden C++ exception states: #wind=3
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::FlattenParameters(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *entryTable,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *v4; // rbx
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				//   List_1_System_Object_ *includeList; // rdi
				//   _BYTE *v10; // rdx
				//   Il2CppException *v11; // rcx
				//   Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo_ *m_paramLookupTable; // r9
				//   __int64 *v13; // rdx
				//   signed __int64 v14; // rtt
				//   __int64 v15; // rdx
				//   signed __int64 items; // rcx
				//   Object *i; // r13
				//   MonitorData *monitor; // r9
				//   __int64 *v19; // rdx
				//   signed __int64 v20; // rtt
				//   __int64 v21; // rcx
				//   PassConstructorID__Enum__Array *v22; // r8
				//   __int64 v23; // rax
				//   __int64 v24; // rax
				//   int v25; // ebx
				//   __int128 v26; // xmm6
				//   Il2CppClass *klass; // rcx
				//   HGRenderPathBase_HGRenderPathResources *v28; // rdx
				//   PassConstructorID__Enum__Array *v29; // r8
				//   HGCamera *v30; // r9
				//   __int64 v31; // rdx
				//   __int64 v32; // rcx
				//   __int64 v33; // r8
				//   List_1_System_Int32_ *v34; // rbx
				//   int32_t v35; // esi
				//   struct MethodInfo *v36; // rdi
				//   __int64 size; // rdx
				//   Object__Class *v38; // r15
				//   Comparison_1_Int32_ *v39; // rbx
				//   Object *v40; // rdi
				//   __int64 v41; // rdx
				//   __int64 v42; // rcx
				//   Il2CppMethodPointer methodPointer; // rax
				//   __int64 *v44; // r8
				//   signed __int64 v45; // rtt
				//   char v46; // cl
				//   __int64 (__fastcall *method_ptr)(); // rax
				//   void **p_invoke_impl; // rcx
				//   char v49; // r8
				//   signed __int64 v50; // rtt
				//   struct MethodInfo *v51; // rdi
				//   Int32__Array *name; // rsi
				//   int32_t namespaze; // r14d
				//   const Il2CppRGCTXData *rgctx_data; // rcx
				//   Il2CppRGCTXData v55; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v57; // rdx
				//   __int64 v58; // rcx
				//   __int64 v59; // rax
				//   _BYTE v60[32]; // [rsp+0h] [rbp-148h] BYREF
				//   MethodInfo *methoda; // [rsp+20h] [rbp-128h]
				//   MethodInfo *v62; // [rsp+28h] [rbp-120h]
				//   _BYTE v63[48]; // [rsp+30h] [rbp-118h] BYREF
				//   Il2CppException *ex; // [rsp+60h] [rbp-E8h]
				//   void *v65; // [rsp+68h] [rbp-E0h]
				//   __int128 v66; // [rsp+70h] [rbp-D8h] BYREF
				//   int32_t item[4]; // [rsp+80h] [rbp-C8h] BYREF
				//   __int128 v68; // [rsp+90h] [rbp-B8h]
				//   Il2CppException *v69; // [rsp+A0h] [rbp-A8h]
				//   __int128 *v70; // [rsp+A8h] [rbp-A0h]
				//   Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ v71; // [rsp+B0h] [rbp-98h] BYREF
				//   List_1_T_Enumerator_System_Object_ v72; // [rsp+D8h] [rbp-70h] BYREF
				//   Il2CppExceptionWrapper *v73; // [rsp+F0h] [rbp-58h] BYREF
				//   Il2CppExceptionWrapper *v74; // [rsp+100h] [rbp-48h] BYREF
				//   Il2CppExceptionWrapper *v75; // [rsp+108h] [rbp-40h] BYREF
				// 
				//   v4 = this;
				//   if ( !byte_18D8EDB4A )
				//   {
				//     sub_18003C530(&TypeInfo::System::Comparison<int>);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::Clear);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::get_Current);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::get_Key);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::get_Value);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::GetEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Sort);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c::_FlattenParameters_b__54_0);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c);
				//     byte_18D8EDB4A = 1;
				//   }
				//   memset(&v71, 0, sizeof(v71));
				//   v66 = 0LL;
				//   *(_OWORD *)item = 0LL;
				//   v68 = 0LL;
				//   if ( IFix::WrappersManagerImpl::IsPatched(3240, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3240, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v58, v57);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
				//       (ILFixDynamicMethodWrapper_37 *)Patch,
				//       (Object *)v4,
				//       (Object *)entryTable,
				//       0LL);
				//   }
				//   else
				//   {
				//     if ( !v4.fields.m_paramLookupTable )
				//       sub_180B536AC(v6, v5);
				//     System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
				//       (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)v4.fields.m_paramLookupTable,
				//       MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::Clear);
				//     if ( !entryTable )
				//       sub_180B536AC(v8, v7);
				//     includeList = (List_1_System_Object_ *)entryTable.fields.includeList;
				//     if ( !includeList )
				//       sub_180B536AC(v8, v7);
				//     System::Collections::Generic::List<System::Object>::GetEnumerator(
				//       (List_1_T_Enumerator_System_Object_ *)v63,
				//       includeList,
				//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::GetEnumerator);
				//     v72 = *(List_1_T_Enumerator_System_Object_ *)v63;
				//     ex = 0LL;
				//     v65 = &v72;
				//     try
				//     {
				//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                 &v72,
				//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::MoveNext) )
				//         HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::DoFlattenParameters(
				//           v4,
				//           (HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *)v72._current,
				//           0LL);
				//     }
				//     catch ( Il2CppExceptionWrapper *v73 )
				//     {
				//       v10 = v60;
				//       ex = v73.ex;
				//       v11 = ex;
				//       if ( ex )
				//         sub_18000F780(ex);
				//       v4 = this;
				//     }
				//     m_paramLookupTable = v4.fields.m_paramLookupTable;
				//     if ( !m_paramLookupTable )
				//       sub_1802DC2C8(v11, v10);
				//     memset(&v63[8], 0, 32);
				//     *(_QWORD *)v63 = m_paramLookupTable;
				//     if ( dword_18D8E43F8 )
				//     {
				//       v13 = &qword_18D6405E0[(((unsigned __int64)v63 >> 12) & 0x1FFFFF) >> 6];
				//       _m_prefetchw(v13 + 36190);
				//       do
				//         v14 = v13[36190];
				//       while ( v14 != _InterlockedCompareExchange64(
				//                        v13 + 36190,
				//                        v14 | (1LL << (((unsigned __int64)v63 >> 12) & 0x3F)),
				//                        v14) );
				//     }
				//     *(_QWORD *)&v63[8] = (unsigned int)m_paramLookupTable.fields._version;
				//     *(_DWORD *)&v63[32] = 2;
				//     *(_OWORD *)&v63[16] = 0LL;
				//     *(_OWORD *)&v71._dictionary = *(_OWORD *)v63;
				//     v71._current = 0LL;
				//     *(_QWORD *)&v71._getEnumeratorRetType = *(_QWORD *)&v63[32];
				//     ex = 0LL;
				//     v65 = &v71;
				//     try
				//     {
				//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,System::Object>::MoveNext(
				//                 &v71,
				//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::MoveNext) )
				//       {
				//         for ( i = v71._current.value; i; i = (Object *)i[2].monitor )
				//         {
				//           monitor = i[1].monitor;
				//           if ( !monitor )
				//             sub_1802DC2C8(items, v15);
				//           memset(&v63[8], 0, 40);
				//           *(_QWORD *)v63 = monitor;
				//           if ( dword_18D8E43F8 )
				//           {
				//             v19 = &qword_18D6405E0[(((unsigned __int64)v63 >> 12) & 0x1FFFFF) >> 6];
				//             _m_prefetchw(v19 + 36190);
				//             do
				//             {
				//               items = v19[36190] | (1LL << (((unsigned __int64)v63 >> 12) & 0x3F));
				//               v20 = v19[36190];
				//             }
				//             while ( v20 != _InterlockedCompareExchange64(v19 + 36190, items, v20) );
				//           }
				//           *(_QWORD *)&v63[8] = *((unsigned int *)monitor + 11);
				//           *(_DWORD *)&v63[40] = 2;
				//           memset(&v63[16], 0, 24);
				//           v66 = *(_OWORD *)v63;
				//           *(_OWORD *)item = 0LL;
				//           v68 = *(_OWORD *)&v63[32];
				//           v69 = 0LL;
				//           v70 = &v66;
				//           try
				//           {
				// LABEL_25:
				//             v15 = v66;
				//             if ( !(_QWORD)v66 )
				//               sub_1802DC2C8(items, 0LL);
				//             if ( DWORD2(v66) != *(_DWORD *)(v66 + 44) )
				//               System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
				//             LODWORD(v21) = HIDWORD(v66);
				//             while ( (unsigned int)v21 < *(_DWORD *)(v66 + 32) )
				//             {
				//               v22 = *(PassConstructorID__Enum__Array **)(v66 + 24);
				//               v23 = (int)v21;
				//               v21 = (unsigned int)(v21 + 1);
				//               HIDWORD(v66) = v21;
				//               if ( !v22 )
				//                 sub_1802DC2C8(v21, v66);
				//               if ( (unsigned int)v23 >= v22.max_length.size )
				//                 sub_180070260(v21, v66, v22, monitor);
				//               v24 = 32 * (v23 + 1);
				//               if ( *(int *)((char *)&v22.klass + v24) >= 0 )
				//               {
				//                 v25 = *(_DWORD *)((char *)&v22.monitor + v24);
				//                 memset(v63, 0, 24);
				//                 v26 = *(_OWORD *)&(&v22.bounds)[(unsigned __int64)v24 / 8];
				//                 klass = MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::MoveNext.klass;
				//                 if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
				//                   sub_18003C700(klass);
				//                 *(_DWORD *)v63 = v25;
				//                 *(_OWORD *)&v63[8] = v26;
				//                 sub_1800054D0(
				//                   (HGRenderPathScene *)&v63[8],
				//                   (HGRenderPathBase_HGRenderPathResources *)v15,
				//                   v22,
				//                   (HGCamera *)monitor,
				//                   methoda,
				//                   v62);
				//                 *(_OWORD *)item = *(_OWORD *)v63;
				//                 *(_QWORD *)&v68 = *(_QWORD *)&v63[16];
				//                 sub_1800054D0((HGRenderPathScene *)&item[2], v28, v29, v30, methoda, v62);
				//                 v34 = (List_1_System_Int32_ *)i[2].klass;
				//                 v35 = item[0];
				//                 if ( !v34 )
				//                   sub_1802DC2C8(v32, v31);
				//                 v36 = MethodInfo::System::Collections::Generic::List<int>::Add;
				//                 ++v34.fields._version;
				//                 items = (signed __int64)v34.fields._items;
				//                 size = v34.fields._size;
				//                 if ( !items )
				//                   sub_1802DC2C8(0LL, size);
				//                 if ( (unsigned int)size < *(_DWORD *)(items + 24) )
				//                 {
				//                   v34.fields._size = size + 1;
				//                   if ( (unsigned int)size >= *(_DWORD *)(items + 24) )
				//                     sub_180070260(items, size, v33, monitor);
				//                   *(_DWORD *)(items + 4 * size + 32) = v35;
				//                 }
				//                 else
				//                 {
				//                   if ( !*((_QWORD *)v36.klass.rgctx_data[11].rgctxDataDummy + 4) )
				//                     (*(void (**)(void))v36.klass.rgctx_data[11].rgctxDataDummy)();
				//                   System::Collections::Generic::List<int>::AddWithResize(
				//                     v34,
				//                     v35,
				//                     (MethodInfo *)v36.klass.rgctx_data[11].rgctxDataDummy);
				//                 }
				//                 goto LABEL_25;
				//               }
				//             }
				//             HIDWORD(v66) = *(_DWORD *)(v66 + 32) + 1;
				//             *(_OWORD *)item = 0LL;
				//             *(_QWORD *)&v68 = 0LL;
				//           }
				//           catch ( Il2CppExceptionWrapper *v74 )
				//           {
				//             v15 = (__int64)v60;
				//             v69 = v74.ex;
				//             if ( v69 )
				//               sub_18000F780(v69);
				//           }
				//           v38 = i[2].klass;
				//           items = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c;
				//           if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c._1.cctor_finished_or_no_cctor )
				//           {
				//             il2cpp_runtime_class_init_0(
				//               TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c,
				//               v15);
				//             items = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c;
				//           }
				//           v39 = *(Comparison_1_Int32_ **)(*(_QWORD *)(items + 184) + 16LL);
				//           if ( !v39 )
				//           {
				//             if ( !*(_DWORD *)(items + 224) )
				//             {
				//               il2cpp_runtime_class_init_0(items, v15);
				//               items = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c;
				//             }
				//             v40 = **(Object ***)(items + 184);
				//             v39 = (Comparison_1_Int32_ *)sub_180004920(TypeInfo::System::Comparison<int>);
				//             if ( !v39 )
				//               sub_1802DC2C8(v42, v41);
				//             v15 = (__int64)MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c::_FlattenParameters_b__54_0;
				//             if ( (*((_BYTE *)MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c::_FlattenParameters_b__54_0
				//                   + 84) & 2) != 0
				//               && qword_18D8E4800 )
				//             {
				//               methodPointer = MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c::_FlattenParameters_b__54_0[1].methodPointer;
				//             }
				//             else
				//             {
				//               methodPointer = MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c::_FlattenParameters_b__54_0.virtualMethodPointer;
				//             }
				//             v39.fields._._.method_ptr = methodPointer;
				//             v39.fields._._.method = (void *)v15;
				//             v39.fields._._.m_target = v40;
				//             if ( dword_18D8E43F8 )
				//             {
				//               v44 = &qword_18D6405E0[(((unsigned __int64)&v39.fields._._.m_target >> 12) & 0x1FFFFF) >> 6];
				//               _m_prefetchw(v44 + 36190);
				//               do
				//                 v45 = v44[36190];
				//               while ( v45 != _InterlockedCompareExchange64(
				//                                v44 + 36190,
				//                                v45 | (1LL << (((unsigned __int64)&v39.fields._._.m_target >> 12) & 0x3F)),
				//                                v45) );
				//             }
				//             v46 = *(_BYTE *)(v15 + 83);
				//             v39.fields._._.method_code = v39;
				//             if ( (*(_BYTE *)(v15 + 76) & 0x10) != 0 )
				//             {
				//               if ( (*(_BYTE *)(v15 + 84) & 0x10) != 0 )
				//               {
				//                 method_ptr = sub_180581384;
				//                 if ( v46 != 2 )
				//                   method_ptr = sub_18058135C;
				//               }
				//               else if ( v46 == 2 )
				//               {
				//                 method_ptr = sub_18053A7AC;
				//               }
				//               else
				//               {
				//                 v39.fields._._.method_code = v39.fields._._.m_target;
				//                 method_ptr = (__int64 (__fastcall *)())v39.fields._._.method_ptr;
				//               }
				//               v15 = 24LL;
				//               p_invoke_impl = &v39.fields._._.invoke_impl;
				//             }
				//             else
				//             {
				//               if ( !v40 )
				//               {
				//                 v59 = sub_180B547A4(0LL, "Delegate to an instance method cannot have null 'this'.");
				//                 sub_18000F7C0(v59, 0LL);
				//               }
				//               v39.fields._._.method_code = v39.fields._._.m_target;
				//               method_ptr = (__int64 (__fastcall *)())v39.fields._._.method_ptr;
				//               p_invoke_impl = &v39.fields._._.invoke_impl;
				//             }
				//             *p_invoke_impl = method_ptr;
				//             v39.fields._._.extra_arg = sub_18053A73C;
				//             items = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c.static_fields;
				//             *(_QWORD *)(items + 16) = v39;
				//             if ( dword_18D8E43F8 )
				//             {
				//               v15 = (__int64)&qword_18D6405E0[(((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c.static_fields.__9__54_0 >> 12) & 0x1FFFFF) >> 6];
				//               v49 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::__c.static_fields.__9__54_0 >> 12) & 0x3F;
				//               _m_prefetchw((const void *)(v15 + 289520));
				//               do
				//               {
				//                 items = *(_QWORD *)(v15 + 289520) | (1LL << v49);
				//                 v50 = *(_QWORD *)(v15 + 289520);
				//               }
				//               while ( v50 != _InterlockedCompareExchange64((volatile signed __int64 *)(v15 + 289520), items, v50) );
				//             }
				//           }
				//           if ( !v38 )
				//             sub_1802DC2C8(items, v15);
				//           v51 = MethodInfo::System::Collections::Generic::List<int>::Sort;
				//           if ( SLODWORD(v38._0.namespaze) > 1 )
				//           {
				//             name = (Int32__Array *)v38._0.name;
				//             namespaze = (int32_t)v38._0.namespaze;
				//             rgctx_data = MethodInfo::System::Collections::Generic::List<int>::Sort.klass.rgctx_data;
				//             v55.rgctxDataDummy = rgctx_data[52].rgctxDataDummy;
				//             if ( (*((_BYTE *)v55.rgctxDataDummy + 312) & 1) == 0 )
				//               ((void (__fastcall *)(_QWORD))sub_18003C700)((const Il2CppRGCTXData)rgctx_data[52].rgctxDataDummy);
				//             if ( !*((_DWORD *)v55.rgctxDataDummy + 56) )
				//               ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(
				//                 (Il2CppRGCTXData)v55.rgctxDataDummy,
				//                 v15);
				//             System::Collections::Generic::ArraySortHelper<int>::Sort(
				//               name,
				//               0,
				//               namespaze,
				//               v39,
				//               (MethodInfo *)v51.klass.rgctx_data[51].rgctxDataDummy);
				//           }
				//           ++HIDWORD(v38._0.namespaze);
				//         }
				//       }
				//     }
				//     catch ( Il2CppExceptionWrapper *v75 )
				//     {
				//       ex = v75.ex;
				//       if ( ex )
				//         sub_18000F780(ex);
				//       return;
				//     }
				//     if ( ex )
				//       sub_18000F780(ex);
				//   }
				// }
				// 
			}

			private void DoFlattenParameters(HGRenderPipelineSettingHub.HGRenderPipelineSettings.BaseSettingTable settingTable)
			{
				// // Void DoFlattenParameters(HGRenderPipelineSettingHub+HGRenderPipelineSettings+BaseSettingTable)
				// // Hidden C++ exception states: #wind=3
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::DoFlattenParameters(
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *this,
				//         HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *settingTable,
				//         MethodInfo *method)
				// {
				//   Action_6_Object_Object_Object_Int32_Object_Object_ *v5; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				//   Action_6_Object_Object_Object_Int32_Object_Object_ *v8; // r12
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				//   IniData *iniData; // rbx
				//   SectionCollection *Sections_k__BackingField; // rbx
				//   __int64 v13; // rdx
				//   String *v14; // rcx
				//   IEnumerator_1_IniParser_Model_Section_ **p_Enumerator; // rdi
				//   IEnumerator_1_IniParser_Model_Section_ *v16; // rsi
				//   struct IEnumerator__Class *v17; // rbx
				//   IEnumerator_1_IniParser_Model_Section___Class *klass; // r14
				//   unsigned __int16 v19; // cx
				//   unsigned __int16 v20; // dx
				//   Il2CppRuntimeInterfaceOffsetPair *interfaceOffsets; // r8
				//   __int64 v22; // rdx
				//   __int64 v23; // rdx
				//   Il2CppException *v24; // rcx
				//   IEnumerator_1_IniParser_Model_Section_ *v25; // rsi
				//   struct IEnumerator_1_IniParser_Model_Section___Class *v26; // rbx
				//   IEnumerator_1_IniParser_Model_Section___Class *v27; // r14
				//   unsigned __int16 v28; // cx
				//   unsigned __int16 v29; // dx
				//   Il2CppRuntimeInterfaceOffsetPair *v30; // r8
				//   __int64 v31; // rdx
				//   __int64 v32; // rax
				//   __int64 v33; // rdx
				//   __int64 v34; // rcx
				//   __int64 v35; // r15
				//   String *v36; // rbx
				//   struct HGRenderPipelineSettingHub_ConstantStrings__Class *v37; // rax
				//   HGRenderPipelineSettingHub_ConstantStrings__StaticFields *static_fields; // rax
				//   String *v39; // r14
				//   struct HGRenderPipelineSettingHub_ConstantStrings__Class *v40; // rax
				//   String *ARRAY_CONCATENATE_STR; // rsi
				//   unsigned int v42; // r8d
				//   __int64 v43; // rbx
				//   void (__fastcall __noreturn **v44)(); // rax
				//   unsigned int v45; // eax
				//   unsigned int v46; // r8d
				//   __int64 v47; // rax
				//   unsigned int *v48; // rdx
				//   signed __int64 v49; // r9
				//   __int64 *v50; // rdx
				//   unsigned __int64 v51; // r8
				//   __int64 v52; // rtt
				//   __int64 v53; // rbx
				//   __int64 v54; // rax
				//   __int64 v55; // rbx
				//   _QWORD **v56; // rcx
				//   __int64 v57; // r8
				//   __int64 v58; // rax
				//   __int64 v59; // rdx
				//   String__Array *v60; // rax
				//   __int64 v61; // rdx
				//   __int64 v62; // rcx
				//   __int64 v63; // r8
				//   __int64 v64; // r9
				//   String__Array *v65; // r13
				//   String *v66; // r14
				//   HGRenderPipelineSettingHub_ConstantStrings__StaticFields *v67; // rcx
				//   String *SUBLEVEL_STR; // rsi
				//   unsigned int v69; // r8d
				//   __int64 v70; // rbx
				//   void (__fastcall __noreturn **v71)(); // rax
				//   unsigned int v72; // eax
				//   unsigned int v73; // r8d
				//   __int64 v74; // rax
				//   unsigned int *v75; // rdx
				//   signed __int64 v76; // r9
				//   __int64 *v77; // rdx
				//   unsigned __int64 v78; // r8
				//   __int64 v79; // rtt
				//   __int64 v80; // rbx
				//   __int64 v81; // rax
				//   __int64 v82; // rbx
				//   _QWORD **v83; // rcx
				//   __int64 v84; // r8
				//   __int64 v85; // rax
				//   __int64 v86; // rdx
				//   int32_t v87; // ebx
				//   String__Array *v88; // rax
				//   __int64 v89; // rcx
				//   __int64 v90; // r8
				//   __int64 v91; // r9
				//   int32_t v92; // esi
				//   __int64 v93; // r14
				//   unsigned int v94; // r8d
				//   __int64 v95; // rbx
				//   void (__fastcall __noreturn **v96)(); // rax
				//   unsigned int v97; // eax
				//   unsigned int v98; // r8d
				//   __int64 v99; // rax
				//   unsigned int *v100; // rdx
				//   signed __int64 v101; // r9
				//   __int64 *v102; // rdx
				//   char v103; // r8
				//   __int64 v104; // rtt
				//   __int64 v105; // rbx
				//   __int64 v106; // rax
				//   __int64 v107; // rbx
				//   _QWORD **v108; // rcx
				//   __int64 v109; // r8
				//   __int64 v110; // rax
				//   __int64 v111; // rdx
				//   __int64 v112; // rax
				//   __int64 *v113; // rdx
				//   signed __int64 v114; // rcx
				//   __int64 v115; // rtt
				//   _QWORD *v116; // r14
				//   struct IEnumerator__Class *v117; // rsi
				//   __int64 v118; // r15
				//   unsigned __int16 v119; // cx
				//   unsigned __int16 v120; // dx
				//   __int64 v121; // r8
				//   __int64 v122; // rdx
				//   _QWORD *v123; // r14
				//   struct IEnumerator_1_IniParser_Model_Property___Class *v124; // rsi
				//   __int64 v125; // r15
				//   unsigned __int16 v126; // cx
				//   unsigned __int16 v127; // dx
				//   __int64 v128; // r8
				//   __int64 v129; // rdx
				//   __int64 v130; // rax
				//   __int64 v131; // r8
				//   __int64 v132; // r9
				//   __int64 v133; // r14
				//   int i; // esi
				//   String *v135; // rcx
				//   List_1_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable_ *includeList; // r9
				//   __int64 *v137; // rdx
				//   __int64 v138; // rtt
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v140; // rdx
				//   __int64 v141; // rcx
				//   _BYTE v142[24]; // [rsp+40h] [rbp-E8h] BYREF
				//   _QWORD *v143; // [rsp+58h] [rbp-D0h] BYREF
				//   IEnumerator_1_IniParser_Model_Section_ *Enumerator; // [rsp+60h] [rbp-C8h] BYREF
				//   String *v145; // [rsp+68h] [rbp-C0h]
				//   Il2CppException *ex; // [rsp+70h] [rbp-B8h]
				//   IEnumerator_1_IniParser_Model_Section_ **v147; // [rsp+78h] [rbp-B0h] BYREF
				//   List_1_T_Enumerator_System_Object_ v148; // [rsp+80h] [rbp-A8h] BYREF
				//   Action_6_Object_Object_Object_Int32_Object_Object_ *v149; // [rsp+98h] [rbp-90h]
				//   int v150; // [rsp+A0h] [rbp-88h] BYREF
				//   int v151; // [rsp+B0h] [rbp-78h] BYREF
				//   int v152; // [rsp+C0h] [rbp-68h] BYREF
				//   Il2CppExceptionWrapper *v153; // [rsp+D8h] [rbp-50h] BYREF
				//   Il2CppExceptionWrapper *v154; // [rsp+E0h] [rbp-48h] BYREF
				//   Il2CppExceptionWrapper *v155; // [rsp+E8h] [rbp-40h] BYREF
				//   int32_t v158; // [rsp+148h] [rbp+20h]
				// 
				//   if ( !byte_18D8EDB4B )
				//   {
				//     sub_18003C530(&TypeInfo::System::Action<System::String,System::String,System::String,int,System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::Dispose);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::MoveNext);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::get_Current);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::_DoFlattenParameters_b__55_0);
				//     sub_18003C530(&TypeInfo::System::IDisposable);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Property>);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Section>);
				//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::GetEnumerator);
				//     sub_18003C530(&off_18C9B4D38);
				//     byte_18D8EDB4B = 1;
				//   }
				//   v143 = 0LL;
				//   memset(&v148, 0, sizeof(v148));
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3241, 0LL) )
				//   {
				//     v5 = (Action_6_Object_Object_Object_Int32_Object_Object_ *)sub_180004920(TypeInfo::System::Action<System::String,System::String,System::String,int,System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>);
				//     v8 = v5;
				//     if ( !v5 )
				//       sub_180B536AC(v7, v6);
				//     System::Action<System::Object,System::Object,System::Object,int,System::Object,System::Object>::Action(
				//       v5,
				//       (Object *)this,
				//       MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::_DoFlattenParameters_b__55_0,
				//       0LL);
				//     v149 = v8;
				//     if ( !settingTable )
				//       sub_180B536AC(v10, v9);
				//     iniData = settingTable.fields.iniData;
				//     if ( !iniData )
				//       sub_180B536AC(v10, v9);
				//     Sections_k__BackingField = iniData.fields._Sections_k__BackingField;
				//     if ( !Sections_k__BackingField )
				//       sub_180B536AC(v10, v9);
				//     Enumerator = IniParser::Model::SectionCollection::GetEnumerator(Sections_k__BackingField, 0LL);
				//     ex = 0LL;
				//     p_Enumerator = &Enumerator;
				//     v147 = &Enumerator;
				//     try
				//     {
				//       while ( 1 )
				//       {
				//         do
				//         {
				//           do
				//           {
				// LABEL_9:
				//             v16 = Enumerator;
				//             if ( !Enumerator )
				//               sub_1802DC2C8(v14, v13);
				//             v17 = TypeInfo::System::Collections::IEnumerator;
				//             klass = Enumerator.klass;
				//             sub_180003EE0(Enumerator.klass);
				//             v19 = 0;
				//             v20 = *(_WORD *)&klass._1.naturalAligment;
				//             if ( v20 )
				//             {
				//               interfaceOffsets = klass.interfaceOffsets;
				//               while ( (struct IEnumerator__Class *)interfaceOffsets[v19].interfaceType != v17 )
				//               {
				//                 if ( ++v19 >= v20 )
				//                   goto LABEL_14;
				//               }
				//               v22 = (__int64)(&klass.vtable.get_Current.method + 2 * interfaceOffsets[v19].offset);
				//             }
				//             else
				//             {
				// LABEL_14:
				//               v22 = sub_18003CDA0(v16, v17, 0LL);
				//             }
				//             if ( !(*(unsigned __int8 (__fastcall **)(IEnumerator_1_IniParser_Model_Section_ *, _QWORD))v22)(
				//                     v16,
				//                     *(_QWORD *)(v22 + 8)) )
				//               goto LABEL_222;
				//             v25 = Enumerator;
				//             if ( !Enumerator )
				//               sub_1802DC2C8(v24, v23);
				//             v26 = TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Section>;
				//             v27 = Enumerator.klass;
				//             sub_180003EE0(Enumerator.klass);
				//             v28 = 0;
				//             v29 = *(_WORD *)&v27._1.naturalAligment;
				//             if ( v29 )
				//             {
				//               v30 = v27.interfaceOffsets;
				//               while ( (struct IEnumerator_1_IniParser_Model_Section___Class *)v30[v28].interfaceType != v26 )
				//               {
				//                 if ( ++v28 >= v29 )
				//                   goto LABEL_21;
				//               }
				//               v31 = (__int64)(&v27.vtable.get_Current.method + 2 * v30[v28].offset);
				//             }
				//             else
				//             {
				// LABEL_21:
				//               v31 = sub_18003CDA0(v25, v26, 0LL);
				//             }
				//             v32 = (*(__int64 (__fastcall **)(IEnumerator_1_IniParser_Model_Section_ *, _QWORD))v31)(
				//                     v25,
				//                     *(_QWORD *)(v31 + 8));
				//             v35 = v32;
				//             if ( !v32 )
				//               sub_1802DC2C8(v34, v33);
				//             v36 = *(String **)(v32 + 32);
				//             v37 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				//             if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings._1.cctor_finished_or_no_cctor )
				//             {
				//               il2cpp_runtime_class_init_0(
				//                 TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings,
				//                 v33);
				//               v37 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				//             }
				//             static_fields = v37.static_fields;
				//             if ( !v36 )
				//               sub_1802DC2C8(v34, v33);
				//           }
				//           while ( System::String::IndexOf(v36, static_fields.INCLUDE_STR, StringComparison__Enum_Ordinal, 0LL) >= 0 );
				//           v39 = *(String **)(v35 + 32);
				//           v40 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				//           if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings._1.cctor_finished_or_no_cctor )
				//           {
				//             il2cpp_runtime_class_init_0(
				//               TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings,
				//               v13);
				//             v40 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				//           }
				//           ARRAY_CONCATENATE_STR = v40.static_fields.ARRAY_CONCATENATE_STR;
				//           if ( !v39 )
				//             sub_1802DC2C8(v14, v13);
				//           if ( !byte_18D8F1F80 )
				//           {
				//             v42 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::System::String, 0LL);
				//             if ( (v42 & 1) != 0 )
				//             {
				//               v43 = (v42 >> 1) & 0xFFFFFFF;
				//               switch ( v42 >> 29 )
				//               {
				//                 case 1u:
				//                   v44 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v43);
				//                   goto LABEL_60;
				//                 case 2u:
				//                   v44 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v43);
				//                   goto LABEL_60;
				//                 case 3u:
				//                 case 6u:
				//                   v45 = (v42 >> 1) & 0xFFFFFFF;
				//                   v46 = v42 >> 29;
				//                   if ( v46 )
				//                   {
				//                     if ( v46 == 3 )
				//                     {
				//                       v44 = (void (__fastcall __noreturn **)())sub_180039480(v45);
				//                       goto LABEL_60;
				//                     }
				//                     if ( v46 == 6 )
				//                     {
				//                       v47 = sub_1802DF9C0(v45);
				//                       v44 = (void (__fastcall __noreturn **)())sub_18005F4B0(v47, 0LL);
				//                       goto LABEL_60;
				//                     }
				//                   }
				//                   else if ( v45 == 1 )
				//                   {
				//                     v44 = off_18A2C5600;
				//                     goto LABEL_60;
				//                   }
				// LABEL_59:
				//                   v44 = 0LL;
				// LABEL_60:
				//                   if ( v44 )
				//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::System::String, (__int64)v44);
				//                   break;
				//                 case 4u:
				//                   v44 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v43);
				//                   goto LABEL_60;
				//                 case 5u:
				//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v43) )
				//                   {
				//                     v44 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v43);
				//                   }
				//                   else
				//                   {
				//                     v48 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v43);
				//                     v49 = il2cpp_string_new_len(qword_18D8E5198 + (int)v48[1] + *(int *)(qword_18D8E51A0 + 16), *v48);
				//                     v44 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
				//                                                                (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v43),
				//                                                                v49,
				//                                                                0LL);
				//                     if ( !v44 )
				//                     {
				//                       if ( dword_18D8E43F8 )
				//                       {
				//                         v50 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v43) >> 12) & 0x1FFFFF) >> 6];
				//                         v51 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v43) >> 12) & 0x3F;
				//                         _m_prefetchw(v50);
				//                         do
				//                           v52 = *v50;
				//                         while ( v52 != _InterlockedCompareExchange64(v50, *v50 | (1LL << v51), *v50) );
				//                       }
				//                       v44 = (void (__fastcall __noreturn **)())v49;
				//                     }
				//                   }
				//                   goto LABEL_60;
				//                 case 7u:
				//                   v53 = sub_1802DF920((unsigned int)v43);
				//                   v54 = *(_QWORD *)(v53 + 16);
				//                   v55 = (v53 - *(_QWORD *)(v54 + 128)) >> 5;
				//                   if ( *(_BYTE *)(v54 + 42) == 21 )
				//                   {
				//                     v56 = *(_QWORD ***)(v54 + 96);
				//                     if ( *v56 )
				//                     {
				//                       v57 = **v56 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
				//                       v54 = sub_180039550(v57 / 92 + v57);
				//                     }
				//                     else
				//                     {
				//                       v54 = 0LL;
				//                     }
				//                   }
				//                   v150 = v55 + *(_DWORD *)(*(_QWORD *)(v54 + 104) + 32LL);
				//                   v58 = sub_1801B8ECC(
				//                           (unsigned int)&v150,
				//                           (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
				//                           *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
				//                           12,
				//                           (__int64)sub_1802C7760);
				//                   if ( !v58 )
				//                     goto LABEL_59;
				//                   v59 = *(unsigned int *)(v58 + 8);
				//                   if ( (_DWORD)v59 == -1 )
				//                     goto LABEL_59;
				//                   v44 = (void (__fastcall __noreturn **)())(v59 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
				//                   goto LABEL_60;
				//                 default:
				//                   break;
				//               }
				//             }
				//             byte_18D8F1F80 = 1;
				//           }
				//           if ( !ARRAY_CONCATENATE_STR )
				//             ARRAY_CONCATENATE_STR = TypeInfo::System::String.static_fields.Empty;
				//           v60 = System::String::SplitInternal(
				//                   v39,
				//                   ARRAY_CONCATENATE_STR,
				//                   0LL,
				//                   0x7FFFFFFF,
				//                   StringSplitOptions__Enum_None,
				//                   0LL);
				//           v65 = v60;
				//           if ( !v60 )
				//             sub_1802DC2C8(v62, v61);
				//           if ( !v60.max_length.size )
				//             sub_180070260(v62, v61, v63, v64);
				//           v66 = v60.vector[0];
				//           v67 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings.static_fields;
				//           SUBLEVEL_STR = v67.SUBLEVEL_STR;
				//           if ( !v66 )
				//             sub_1802DC2C8(v67, v61);
				//           if ( !byte_18D8F1F80 )
				//           {
				//             v69 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::System::String, 0LL);
				//             if ( (v69 & 1) != 0 )
				//             {
				//               v70 = (v69 >> 1) & 0xFFFFFFF;
				//               switch ( v69 >> 29 )
				//               {
				//                 case 1u:
				//                   v71 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v70);
				//                   goto LABEL_96;
				//                 case 2u:
				//                   v71 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v70);
				//                   goto LABEL_96;
				//                 case 3u:
				//                 case 6u:
				//                   v72 = (v69 >> 1) & 0xFFFFFFF;
				//                   v73 = v69 >> 29;
				//                   if ( v73 )
				//                   {
				//                     if ( v73 == 3 )
				//                     {
				//                       v71 = (void (__fastcall __noreturn **)())sub_180039480(v72);
				//                       goto LABEL_96;
				//                     }
				//                     if ( v73 == 6 )
				//                     {
				//                       v74 = sub_1802DF9C0(v72);
				//                       v71 = (void (__fastcall __noreturn **)())sub_18005F4B0(v74, 0LL);
				//                       goto LABEL_96;
				//                     }
				//                   }
				//                   else if ( v72 == 1 )
				//                   {
				//                     v71 = off_18A2C5600;
				//                     goto LABEL_96;
				//                   }
				// LABEL_95:
				//                   v71 = 0LL;
				// LABEL_96:
				//                   if ( v71 )
				//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::System::String, (__int64)v71);
				//                   break;
				//                 case 4u:
				//                   v71 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v70);
				//                   goto LABEL_96;
				//                 case 5u:
				//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v70) )
				//                   {
				//                     v71 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v70);
				//                   }
				//                   else
				//                   {
				//                     v75 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v70);
				//                     v76 = il2cpp_string_new_len(qword_18D8E5198 + (int)v75[1] + *(int *)(qword_18D8E51A0 + 16), *v75);
				//                     v71 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
				//                                                                (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v70),
				//                                                                v76,
				//                                                                0LL);
				//                     if ( !v71 )
				//                     {
				//                       if ( dword_18D8E43F8 )
				//                       {
				//                         v77 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v70) >> 12) & 0x1FFFFF) >> 6];
				//                         v78 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v70) >> 12) & 0x3F;
				//                         _m_prefetchw(v77);
				//                         do
				//                           v79 = *v77;
				//                         while ( v79 != _InterlockedCompareExchange64(v77, *v77 | (1LL << v78), *v77) );
				//                       }
				//                       v71 = (void (__fastcall __noreturn **)())v76;
				//                     }
				//                   }
				//                   goto LABEL_96;
				//                 case 7u:
				//                   v80 = sub_1802DF920((unsigned int)v70);
				//                   v81 = *(_QWORD *)(v80 + 16);
				//                   v82 = (v80 - *(_QWORD *)(v81 + 128)) >> 5;
				//                   if ( *(_BYTE *)(v81 + 42) == 21 )
				//                   {
				//                     v83 = *(_QWORD ***)(v81 + 96);
				//                     if ( *v83 )
				//                     {
				//                       v84 = **v83 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
				//                       v81 = sub_180039550(v84 / 92 + v84);
				//                     }
				//                     else
				//                     {
				//                       v81 = 0LL;
				//                     }
				//                   }
				//                   v151 = v82 + *(_DWORD *)(*(_QWORD *)(v81 + 104) + 32LL);
				//                   v85 = sub_1801B8ECC(
				//                           (unsigned int)&v151,
				//                           (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
				//                           *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
				//                           12,
				//                           (__int64)sub_1802C7760);
				//                   if ( !v85 )
				//                     goto LABEL_95;
				//                   v86 = *(unsigned int *)(v85 + 8);
				//                   if ( (_DWORD)v86 == -1 )
				//                     goto LABEL_95;
				//                   v71 = (void (__fastcall __noreturn **)())(v86 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
				//                   goto LABEL_96;
				//                 default:
				//                   break;
				//               }
				//             }
				//             byte_18D8F1F80 = 1;
				//           }
				//           if ( !SUBLEVEL_STR )
				//             SUBLEVEL_STR = TypeInfo::System::String.static_fields.Empty;
				//           v87 = 0;
				//           v88 = System::String::SplitInternal(v66, SUBLEVEL_STR, 0LL, 0x7FFFFFFF, StringSplitOptions__Enum_None, 0LL);
				//           if ( !v88 )
				//             sub_1802DC2C8(v89, v13);
				//           if ( !v88.max_length.size )
				//             sub_180070260(v89, v13, v90, v91);
				//           v14 = v88.vector[0];
				//           v145 = v14;
				//           if ( v88.max_length.size <= 1 )
				//           {
				//             v158 = 0;
				//             break;
				//           }
				//           if ( v88.max_length.size <= 1u )
				//             sub_180070260(v14, v13, v90, v91);
				//           v87 = System::Int32::Parse(v88.vector[1], 0LL);
				//           v158 = v87;
				//         }
				//         while ( v87 < 0 );
				//         v92 = v87;
				//         v93 = *(_QWORD *)(v35 + 16);
				//         if ( !v93 )
				//           sub_1802DC2C8(v14, v13);
				//         if ( !byte_18D8ED92A )
				//         {
				//           v94 = _InterlockedExchangeAdd64(
				//                   (volatile signed __int64 *)&TypeInfo::IniParser::Model::PropertyCollection::_GetEnumerator_d__17,
				//                   0LL);
				//           if ( (v94 & 1) != 0 )
				//           {
				//             v95 = (v94 >> 1) & 0xFFFFFFF;
				//             switch ( v94 >> 29 )
				//             {
				//               case 1u:
				//                 v96 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v95);
				//                 goto LABEL_137;
				//               case 2u:
				//                 v96 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v95);
				//                 goto LABEL_137;
				//               case 3u:
				//               case 6u:
				//                 v97 = (v94 >> 1) & 0xFFFFFFF;
				//                 v98 = v94 >> 29;
				//                 if ( v98 )
				//                 {
				//                   if ( v98 == 3 )
				//                   {
				//                     v96 = (void (__fastcall __noreturn **)())sub_180039480(v97);
				//                     goto LABEL_137;
				//                   }
				//                   if ( v98 == 6 )
				//                   {
				//                     v99 = sub_1802DF9C0(v97);
				//                     v96 = (void (__fastcall __noreturn **)())sub_18005F4B0(v99, 0LL);
				//                     goto LABEL_137;
				//                   }
				//                 }
				//                 else if ( v97 == 1 )
				//                 {
				//                   v96 = off_18A2C5600;
				//                   goto LABEL_137;
				//                 }
				// LABEL_136:
				//                 v96 = 0LL;
				// LABEL_137:
				//                 v87 = v158;
				//                 if ( v96 )
				//                   _InterlockedExchange64(
				//                     (volatile __int64 *)&TypeInfo::IniParser::Model::PropertyCollection::_GetEnumerator_d__17,
				//                     (__int64)v96);
				//                 break;
				//               case 4u:
				//                 v96 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v95);
				//                 goto LABEL_137;
				//               case 5u:
				//                 if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v95) )
				//                 {
				//                   v96 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v95);
				//                 }
				//                 else
				//                 {
				//                   v100 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v95);
				//                   v101 = il2cpp_string_new_len(qword_18D8E5198 + (int)v100[1] + *(int *)(qword_18D8E51A0 + 16), *v100);
				//                   v96 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
				//                                                              (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v95),
				//                                                              v101,
				//                                                              0LL);
				//                   v158 = v92;
				//                   if ( !v96 )
				//                   {
				//                     if ( dword_18D8E43F8 )
				//                     {
				//                       v102 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v95) >> 12) & 0x1FFFFF) >> 6];
				//                       v103 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v95) >> 12) & 0x3F;
				//                       v158 = v92;
				//                       _m_prefetchw(v102);
				//                       do
				//                         v104 = *v102;
				//                       while ( v104 != _InterlockedCompareExchange64(v102, *v102 | (1LL << v103), *v102) );
				//                     }
				//                     v96 = (void (__fastcall __noreturn **)())v101;
				//                   }
				//                 }
				//                 goto LABEL_137;
				//               case 7u:
				//                 v105 = sub_1802DF920((unsigned int)v95);
				//                 v106 = *(_QWORD *)(v105 + 16);
				//                 v107 = (v105 - *(_QWORD *)(v106 + 128)) >> 5;
				//                 if ( *(_BYTE *)(v106 + 42) == 21 )
				//                 {
				//                   v108 = *(_QWORD ***)(v106 + 96);
				//                   if ( *v108 )
				//                   {
				//                     v109 = **v108 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
				//                     v106 = sub_180039550(v109 / 92 + v109);
				//                   }
				//                   else
				//                   {
				//                     v106 = 0LL;
				//                   }
				//                 }
				//                 v152 = v107 + *(_DWORD *)(*(_QWORD *)(v106 + 104) + 32LL);
				//                 v110 = sub_1801B8ECC(
				//                          (unsigned int)&v152,
				//                          (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
				//                          *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
				//                          12,
				//                          (__int64)sub_1802C7760);
				//                 if ( !v110 )
				//                   goto LABEL_136;
				//                 v111 = *(unsigned int *)(v110 + 8);
				//                 if ( (_DWORD)v111 == -1 )
				//                   goto LABEL_136;
				//                 v96 = (void (__fastcall __noreturn **)())(v111 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
				//                 goto LABEL_137;
				//               default:
				//                 v87 = v158;
				//                 break;
				//             }
				//           }
				//           byte_18D8ED92A = 1;
				//         }
				//         v112 = sub_180004920(TypeInfo::IniParser::Model::PropertyCollection::_GetEnumerator_d__17);
				//         if ( !v112 )
				//           sub_1802DC2C8(v114, v113);
				//         *(_DWORD *)(v112 + 16) = 0;
				//         *(_QWORD *)(v112 + 32) = v93;
				//         if ( dword_18D8E43F8 )
				//         {
				//           v113 = &qword_18D6870D0[(((unsigned __int64)(v112 + 32) >> 12) & 0x1FFFFF) >> 6];
				//           _m_prefetchw(v113);
				//           do
				//           {
				//             v114 = *v113 | (1LL << (((unsigned __int64)(v112 + 32) >> 12) & 0x3F));
				//             v115 = *v113;
				//           }
				//           while ( v115 != _InterlockedCompareExchange64(v113, v114, *v113) );
				//           v158 = v87;
				//         }
				//         v143 = (_QWORD *)v112;
				//         *(_QWORD *)v142 = 0LL;
				//         *(_QWORD *)&v142[8] = &v143;
				//         try
				//         {
				//           while ( 1 )
				//           {
				//             v116 = v143;
				//             if ( !v143 )
				//               sub_1802DC2C8(v114, v113);
				//             v117 = TypeInfo::System::Collections::IEnumerator;
				//             v118 = *v143;
				//             sub_180003EE0(*v143);
				//             v119 = 0;
				//             v120 = *(_WORD *)(v118 + 304);
				//             if ( v120 )
				//             {
				//               v121 = *(_QWORD *)(v118 + 176);
				//               while ( *(struct IEnumerator__Class **)(v121 + 16LL * v119) != v117 )
				//               {
				//                 if ( ++v119 >= v120 )
				//                   goto LABEL_152;
				//               }
				//               v122 = v118 + 16 * (*(int *)(v121 + 16LL * v119 + 8) + 20LL);
				//             }
				//             else
				//             {
				// LABEL_152:
				//               v122 = sub_18003CDA0(v116, v117, 0LL);
				//             }
				//             if ( !(*(unsigned __int8 (__fastcall **)(_QWORD *, _QWORD))v122)(v116, *(_QWORD *)(v122 + 8)) )
				//               break;
				//             v123 = v143;
				//             if ( !v143 )
				//               sub_1802DC2C8(v14, v13);
				//             v124 = TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Property>;
				//             v125 = *v143;
				//             sub_180003EE0(*v143);
				//             v126 = 0;
				//             v127 = *(_WORD *)(v125 + 304);
				//             if ( v127 )
				//             {
				//               v128 = *(_QWORD *)(v125 + 176);
				//               while ( *(struct IEnumerator_1_IniParser_Model_Property___Class **)(v128 + 16LL * v126) != v124 )
				//               {
				//                 if ( ++v126 >= v127 )
				//                   goto LABEL_159;
				//               }
				//               v129 = v125 + 16 * (*(int *)(v128 + 16LL * v126 + 8) + 20LL);
				//             }
				//             else
				//             {
				// LABEL_159:
				//               v129 = sub_18003CDA0(v123, v124, 0LL);
				//             }
				//             v130 = (*(__int64 (__fastcall **)(_QWORD *, _QWORD))v129)(v123, *(_QWORD *)(v129 + 8));
				//             v133 = v130;
				//             if ( v65.max_length.size > 1 )
				//             {
				//               for ( i = 1; i < v65.max_length.size; ++i )
				//               {
				//                 if ( !v133 )
				//                   sub_1802DC2C8(v114, v113);
				//                 if ( (unsigned int)i >= v65.max_length.size )
				//                   sub_180070260(v114, v113, v131, v132);
				//                 v135 = v65.vector[i];
				//                 if ( !v8 )
				//                   sub_1802DC2C8(v135, v113);
				//                 ((void (__fastcall *)(void *, _QWORD, _QWORD, String *, int32_t, String *, HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *, void *, _QWORD, _QWORD))v8.fields._._.invoke_impl)(
				//                   v8.fields._._.method_code,
				//                   *(_QWORD *)(v133 + 16),
				//                   *(_QWORD *)(v133 + 24),
				//                   v145,
				//                   v158,
				//                   v135,
				//                   settingTable,
				//                   v8.fields._._.method,
				//                   *(_QWORD *)v142,
				//                   *(_QWORD *)&v142[8]);
				//               }
				//             }
				//             else
				//             {
				//               if ( !v130 )
				//                 sub_1802DC2C8(v114, v113);
				//               if ( !v8 )
				//                 sub_1802DC2C8(v114, v113);
				//               ((void (__fastcall *)(void *, _QWORD, _QWORD, String *, int32_t, const char *, HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *, void *))v8.fields._._.invoke_impl)(
				//                 v8.fields._._.method_code,
				//                 *(_QWORD *)(v130 + 16),
				//                 *(_QWORD *)(v130 + 24),
				//                 v145,
				//                 v158,
				//                 "",
				//                 settingTable,
				//                 v8.fields._._.method);
				//             }
				//           }
				//         }
				//         catch ( Il2CppExceptionWrapper *v153 )
				//         {
				//           *(Il2CppExceptionWrapper *)v142 = (Il2CppExceptionWrapper)v153.ex;
				//           sub_18289B040(&v142[8]);
				//           v14 = *(String **)v142;
				//           if ( *(_QWORD *)v142 )
				//             sub_18000F780(*(_QWORD *)v142);
				//           v8 = v149;
				//           p_Enumerator = v147;
				//           goto LABEL_9;
				//         }
				//         if ( v143 )
				//           sub_18005CC40(0LL, TypeInfo::System::IDisposable, v143);
				//       }
				//     }
				//     catch ( Il2CppExceptionWrapper *v154 )
				//     {
				//       ex = v154.ex;
				//       sub_18289B040(&v147);
				//       v24 = ex;
				//       if ( ex )
				//         sub_18000F780(ex);
				// LABEL_179:
				//       if ( !settingTable || (includeList = settingTable.fields.includeList) == 0LL )
				//         sub_1802DC2C8(v24, v23);
				//       *(_OWORD *)&v142[8] = 0LL;
				//       *(_QWORD *)v142 = includeList;
				//       if ( dword_18D8E43F8 )
				//       {
				//         v137 = (__int64 *)(0x180000000LL + 8 * ((((unsigned __int64)v142 >> 12) & 0x1FFFFF) >> 6) + 224948432);
				//         _m_prefetchw(v137);
				//         do
				//           v138 = *v137;
				//         while ( v138 != _InterlockedCompareExchange64(
				//                           v137,
				//                           *v137 | (1LL << (((unsigned __int64)v142 >> 12) & 0x3F)),
				//                           *v137) );
				//       }
				//       *(_DWORD *)&v142[8] = 0;
				//       *(_DWORD *)&v142[12] = includeList.fields._version;
				//       *(_QWORD *)&v142[16] = 0LL;
				//       *(_OWORD *)&v148._list = *(_OWORD *)v142;
				//       v148._current = 0LL;
				//       *(_QWORD *)v142 = 0LL;
				//       *(_QWORD *)&v142[8] = &v148;
				//       try
				//       {
				//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
				//                   &v148,
				//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::MoveNext) )
				//           HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::DoFlattenParameters(
				//             this,
				//             (HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *)v148._current,
				//             0LL);
				//       }
				//       catch ( Il2CppExceptionWrapper *v155 )
				//       {
				//         *(Il2CppExceptionWrapper *)v142 = (Il2CppExceptionWrapper)v155.ex;
				//         if ( *(_QWORD *)v142 )
				//           sub_18000F780(*(_QWORD *)v142);
				//       }
				//       return;
				//     }
				// LABEL_222:
				//     if ( *p_Enumerator )
				//       sub_18005CC40(0LL, TypeInfo::System::IDisposable, *p_Enumerator);
				//     goto LABEL_179;
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(3241, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v141, v140);
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
				//     (ILFixDynamicMethodWrapper_37 *)Patch,
				//     (Object *)this,
				//     (Object *)settingTable,
				//     0LL);
				// }
				// 
			}

			public HashSet<string> forceSRPShaders;

			private HGRenderPipelineSettingHub.HGRenderPipelineSettings.BaseSettingTable m_settingTable;

			private Dictionary<string, HGRenderPipelineSettingHub.OnSettingChanged> m_settingChangeCallbacks;

			private Dictionary<string, int> m_overrideFeatureSettingTiers;

			private Dictionary<string, List<HGRenderPipelineSettingHub.SettingParameterBase>> m_registeredParameters;

			private Dictionary<string, HGRenderPipelineSettingHub.HGRenderPipelineSettings.ParamInfo> m_paramLookupTable;

			private HashSet<string> m_dirtyFeatureSettings;

			private Dictionary<string, string> m_settingData;

			public Dictionary<string, string> parameterTablePath;

			private bool m_useDefaultSettings;

			internal int maximumDeviceTier;

			internal int minimumDeviceTier;

			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			internal struct TierValue
			{
				internal HGRenderPipelineSettingHub.HGRenderPipelineSettings.BaseSettingTable from;

				internal string value;
			}

			internal class ParamInfo
			{
				internal ParamInfo()
				{
				}

				internal string constrain;

				internal Dictionary<int, HGRenderPipelineSettingHub.HGRenderPipelineSettings.TierValue> tierValues;

				internal List<int> tiers;

				internal HGRenderPipelineSettingHub.HGRenderPipelineSettings.ParamInfo next;
			}

			public class BaseSettingTable
			{
				public BaseSettingTable()
				{
				}

				private static string ReadSettingData(ref string relativePath, ref string settingPath, Dictionary<string, string> settingData)
				{
					// // String ReadSettingData(String ByRef, String ByRef, Dictionary`2[System.String,System.String])
					// String *HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ReadSettingData(
					//         String **relativePath,
					//         String **settingPath,
					//         Dictionary_2_System_String_System_String_ *settingData,
					//         MethodInfo *method)
					// {
					//   __int64 v7; // rdx
					//   String *v8; // rcx
					//   __int64 v9; // rdx
					//   String *v10; // rbp
					//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
					//   PassConstructorID__Enum__Array *v12; // r8
					//   HGCamera *v13; // r9
					//   __int64 v14; // rdx
					//   struct HGRenderPipelineSettingHub_ConstantStrings__Class *v15; // rax
					//   Object *v16; // rax
					//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
					//   PassConstructorID__Enum__Array *v19; // r8
					//   HGCamera *v20; // r9
					//   String *v21; // rdi
					//   String *v22; // rbx
					//   String *v23; // rax
					//   String *v24; // rdi
					//   __int64 v25; // rax
					//   Exception *v26; // rax
					//   Exception *v27; // rbx
					//   __int64 v28; // rax
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   MethodInfo *methoda; // [rsp+20h] [rbp-28h]
					//   MethodInfo *v31; // [rsp+28h] [rbp-20h]
					//   Object *value; // [rsp+30h] [rbp-18h] BYREF
					// 
					//   if ( !byte_18D8EDB4F )
					//   {
					//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,System::String>::TryGetValue);
					//     sub_18003C530(&TypeInfo::System::IO::Path);
					//     sub_18003C530(&off_18C9F2528);
					//     sub_18003C530(&off_18C9B4D38);
					//     byte_18D8EDB4F = 1;
					//   }
					//   value = 0LL;
					//   if ( !IFix::WrappersManagerImpl::IsPatched(3235, 0LL) )
					//   {
					//     v8 = *relativePath;
					//     if ( *relativePath )
					//     {
					//       if ( !System::String::Equals(v8, (String *)"", 0LL) )
					//       {
					//         *settingPath = System::String::Concat(*relativePath, (String *)"/", *settingPath, 0LL);
					//         sub_1800054D0((HGRenderPathScene *)settingPath, v18, v19, v20, methoda, v31);
					//       }
					//       v10 = *settingPath;
					//       if ( !TypeInfo::System::IO::Path._1.cctor_finished_or_no_cctor )
					//         il2cpp_runtime_class_init_0(TypeInfo::System::IO::Path, v9);
					//       *relativePath = System::IO::Path::GetDirectoryName(v10, 0LL);
					//       sub_1800054D0((HGRenderPathScene *)relativePath, v11, v12, v13, methoda, v31);
					//       v15 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
					//       if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings._1.cctor_finished_or_no_cctor )
					//       {
					//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings, v14);
					//         v15 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
					//       }
					//       v16 = (Object *)System::String::Concat(v15.static_fields.SETTING_PATH, *settingPath, 0LL);
					//       if ( settingData )
					//       {
					//         if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
					//                (Dictionary_2_System_Object_System_Object_ *)settingData,
					//                v16,
					//                &value,
					//                MethodInfo::System::Collections::Generic::Dictionary<System::String,System::String>::TryGetValue) )
					//         {
					//           return (String *)value;
					//         }
					//         v21 = *settingPath;
					//         v22 = (String *)sub_18003C530(&off_18D516278);
					//         v23 = (String *)sub_18003C530(&off_18D516288);
					//         v24 = System::String::Concat(v23, v21, v22, 0LL);
					//         v25 = sub_18003C530(&TypeInfo::System::Exception);
					//         v26 = (Exception *)sub_180004920(v25);
					//         v27 = v26;
					//         if ( v26 )
					//         {
					//           System::Exception::Exception(v26, v24, 0LL);
					//           v28 = sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ReadSettingData);
					//           sub_18000F7C0(v27, v28);
					//         }
					//       }
					//     }
					// LABEL_14:
					//     sub_180B536AC(v8, v7);
					//   }
					//   Patch = IFix::WrappersManagerImpl::GetPatch(3235, 0LL);
					//   if ( !Patch )
					//     goto LABEL_14;
					//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1153(Patch, relativePath, settingPath, (Object *)settingData, 0LL);
					// }
					// 
					return null;
				}

				private void ParseInclude(string constrain, HGDeviceType deviceType, string relativePath, IniDataParser parser, Dictionary<string, string> settingData, HGRenderPipelineSettingHub.HGRenderPipelineSettings impl)
				{
					// // Void ParseInclude(String, HGDeviceType, String, IniDataParser, Dictionary`2[System.String,System.String], HGRenderPipelineSettingHub+HGRenderPipelineSettings)
					// // Hidden C++ exception states: #wind=1
					// void HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ParseInclude(
					//         HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *this,
					//         String *constrain,
					//         HGDeviceType__Enum deviceType,
					//         String *relativePath,
					//         IniDataParser *parser,
					//         Dictionary_2_System_String_System_String_ *settingData,
					//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *impl,
					//         MethodInfo *method)
					// {
					//   __int64 v12; // rdx
					//   struct HGRenderPipelineSettingHub_ConstantStrings__Class *v13; // rax
					//   String *INCLUDE_STR; // rdi
					//   __int64 v15; // rdx
					//   __int64 v16; // rcx
					//   struct HGRenderPipelineSettingHub_ConstantStrings__Class *v17; // rax
					//   IniData *iniData; // rbx
					//   SectionCollection *Sections_k__BackingField; // rbx
					//   Section *v20; // rax
					//   __int64 v21; // rdx
					//   __int64 v22; // rcx
					//   __int64 *v23; // rdx
					//   signed __int64 v24; // rcx
					//   IEnumerator_1_IniParser_Model_Property_ *v25; // rsi
					//   struct IEnumerator__Class *v26; // rdi
					//   IEnumerator_1_IniParser_Model_Property___Class *klass; // r14
					//   unsigned __int16 v28; // cx
					//   unsigned __int16 v29; // dx
					//   Il2CppRuntimeInterfaceOffsetPair *interfaceOffsets; // r8
					//   __int64 v31; // rdx
					//   __int64 v32; // rdx
					//   __int64 v33; // rcx
					//   __int64 v34; // rax
					//   __int64 v35; // rdx
					//   __int64 v36; // rcx
					//   String *v37; // rsi
					//   struct HGRenderPipelineSettingHub_ConstantStrings__Class *v38; // rax
					//   String *ARRAY_CONCATENATE_STR; // rdi
					//   signed __int64 v40; // rcx
					//   unsigned int v41; // r8d
					//   __int64 v42; // rax
					//   __int64 v43; // rax
					//   __int64 v44; // rax
					//   __int64 v45; // r8
					//   __int64 v46; // r9
					//   String__Array *v47; // r15
					//   int32_t v48; // edi
					//   String *v49; // r14
					//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *v50; // rax
					//   __int64 v51; // rdx
					//   __int64 v52; // rcx
					//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *v53; // rsi
					//   __int64 v54; // rdx
					//   List_1_System_Object_ *includeList; // rcx
					//   unsigned int v56; // esi
					//   char v57; // si
					//   __int64 v58; // rtt
					//   __int64 v59; // rdx
					//   __int64 v60; // rcx
					//   ILFixDynamicMethodWrapper_2 *Patch; // rdi
					//   IEnumerator_1_IniParser_Model_Property_ *Enumerator; // [rsp+50h] [rbp-58h] BYREF
					//   Il2CppExceptionWrapper *v63; // [rsp+60h] [rbp-48h] BYREF
					//   Il2CppException *ex; // [rsp+68h] [rbp-40h]
					//   IEnumerator_1_IniParser_Model_Property_ **p_Enumerator; // [rsp+70h] [rbp-38h] BYREF
					// 
					//   if ( !byte_18D8EDB50 )
					//   {
					//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable);
					//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
					//     sub_18003C530(&TypeInfo::System::IDisposable);
					//     sub_18003C530(&TypeInfo::System::Collections::Generic::IEnumerator<IniParser::Model::Property>);
					//     sub_18003C530(&TypeInfo::System::Collections::IEnumerator);
					//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable>::Add);
					//     sub_18003C530(&off_18C9B4D38);
					//     byte_18D8EDB50 = 1;
					//   }
					//   if ( IFix::WrappersManagerImpl::IsPatched(3237, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(3237, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v60, v59);
					//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1154(
					//       Patch,
					//       (Object *)this,
					//       (Object *)constrain,
					//       deviceType,
					//       (Object *)relativePath,
					//       (Object *)parser,
					//       (Object *)settingData,
					//       (Object *)impl,
					//       0LL);
					//   }
					//   else
					//   {
					//     v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
					//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings._1.cctor_finished_or_no_cctor )
					//     {
					//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings, v12);
					//       v13 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
					//     }
					//     INCLUDE_STR = v13.static_fields.INCLUDE_STR;
					//     if ( System::String::op_Inequality(constrain, (String *)"", 0LL) )
					//     {
					//       v17 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
					//       if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings._1.cctor_finished_or_no_cctor )
					//       {
					//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings, v15);
					//         v17 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
					//       }
					//       INCLUDE_STR = System::String::Concat(INCLUDE_STR, v17.static_fields.SUBLEVEL_STR, constrain, 0LL);
					//     }
					//     iniData = this.fields.iniData;
					//     if ( !iniData )
					//       sub_180B536AC(v16, v15);
					//     Sections_k__BackingField = iniData.fields._Sections_k__BackingField;
					//     if ( !Sections_k__BackingField )
					//       sub_180B536AC(v16, v15);
					//     v20 = IniParser::Model::SectionCollection::FindByName(Sections_k__BackingField, INCLUDE_STR, 0LL);
					//     if ( v20 )
					//     {
					//       if ( !v20.fields._Properties_k__BackingField )
					//         sub_180B536AC(v22, v21);
					//       Enumerator = IniParser::Model::PropertyCollection::GetEnumerator(v20.fields._Properties_k__BackingField, 0LL);
					//       ex = 0LL;
					//       p_Enumerator = &Enumerator;
					//       try
					//       {
					//         while ( 1 )
					//         {
					//           v25 = Enumerator;
					//           if ( !Enumerator )
					//             sub_1802DC2C8(v24, v23);
					//           v26 = TypeInfo::System::Collections::IEnumerator;
					//           klass = Enumerator.klass;
					//           sub_180003EE0(Enumerator.klass);
					//           v28 = 0;
					//           v29 = *(_WORD *)&klass._1.naturalAligment;
					//           if ( v29 )
					//           {
					//             interfaceOffsets = klass.interfaceOffsets;
					//             while ( (struct IEnumerator__Class *)interfaceOffsets[v28].interfaceType != v26 )
					//             {
					//               if ( ++v28 >= v29 )
					//                 goto LABEL_20;
					//             }
					//             v31 = (__int64)(&klass.vtable.get_Current.method + 2 * interfaceOffsets[v28].offset);
					//           }
					//           else
					//           {
					// LABEL_20:
					//             v31 = sub_18003CDA0(v25, v26, 0LL);
					//           }
					//           if ( !(*(unsigned __int8 (__fastcall **)(IEnumerator_1_IniParser_Model_Property_ *, _QWORD))v31)(
					//                   v25,
					//                   *(_QWORD *)(v31 + 8)) )
					//             break;
					//           if ( !Enumerator )
					//             sub_1802DC2C8(v33, v32);
					//           v34 = sub_18005E5B0();
					//           if ( !v34 )
					//             sub_1802DC2C8(v36, v35);
					//           v37 = *(String **)(v34 + 16);
					//           v38 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
					//           if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings._1.cctor_finished_or_no_cctor )
					//           {
					//             il2cpp_runtime_class_init_0(
					//               TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings,
					//               v35);
					//             v38 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
					//           }
					//           ARRAY_CONCATENATE_STR = v38.static_fields.ARRAY_CONCATENATE_STR;
					//           if ( !v37 )
					//             sub_1802DC2C8(v36, v35);
					//           if ( !byte_18D8F1F80 )
					//           {
					//             v40 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::System::String, 0LL);
					//             if ( (v40 & 1) != 0 )
					//             {
					//               v41 = ((unsigned int)v40 >> 1) & 0xFFFFFFF;
					//               switch ( (unsigned int)v40 >> 29 )
					//               {
					//                 case 1u:
					//                   v42 = sub_18003C670(v41);
					//                   goto LABEL_39;
					//                 case 2u:
					//                   v42 = sub_18003C380(v41);
					//                   goto LABEL_39;
					//                 case 3u:
					//                 case 6u:
					//                   v42 = sub_1802DFAE0(v40);
					//                   goto LABEL_39;
					//                 case 4u:
					//                   v42 = sub_1802DF920(v41);
					//                   goto LABEL_39;
					//                 case 5u:
					//                   v42 = sub_1802DFBB0(v41);
					//                   goto LABEL_39;
					//                 case 7u:
					//                   v43 = sub_1802DF920(v41);
					//                   v44 = sub_1802DF850(v43);
					//                   if ( v44 )
					//                     v42 = sub_1802DF970(*(unsigned int *)(v44 + 8));
					//                   else
					//                     v42 = 0LL;
					// LABEL_39:
					//                   if ( v42 )
					//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::System::String, v42);
					//                   break;
					//                 default:
					//                   break;
					//               }
					//             }
					//             byte_18D8F1F80 = 1;
					//           }
					//           if ( !ARRAY_CONCATENATE_STR )
					//             ARRAY_CONCATENATE_STR = TypeInfo::System::String.static_fields.Empty;
					//           v47 = System::String::SplitInternal(
					//                   v37,
					//                   ARRAY_CONCATENATE_STR,
					//                   0LL,
					//                   0x7FFFFFFF,
					//                   StringSplitOptions__Enum_None,
					//                   0LL);
					//           v48 = 0;
					//           if ( !v47 )
					//             sub_1802DC2C8(v24, v23);
					//           while ( v48 < v47.max_length.size )
					//           {
					//             if ( (unsigned int)v48 >= v47.max_length.size )
					//               sub_180070260(v48, v23, v45, v46);
					//             v49 = v47.vector[v48];
					//             v50 = (HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable);
					//             v53 = v50;
					//             if ( !v50 )
					//               sub_1802DC2C8(v52, v51);
					//             HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::BaseSettingTable(
					//               v50,
					//               0LL);
					//             HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::PopulateSettingTable(
					//               v53,
					//               parser,
					//               this,
					//               deviceType,
					//               relativePath,
					//               v49,
					//               settingData,
					//               impl,
					//               0LL);
					//             includeList = (List_1_System_Object_ *)this.fields.includeList;
					//             if ( !includeList )
					//               sub_1802DC2C8(0LL, v54);
					//             sub_1822AD140(includeList, (Object *)v53);
					//             v53.fields.includeFrom = this;
					//             if ( dword_18D8E43F8 )
					//             {
					//               v56 = ((unsigned __int64)&v53.fields >> 12) & 0x1FFFFF;
					//               v23 = &qword_18D6870D0[(unsigned __int64)v56 >> 6];
					//               v57 = v56 & 0x3F;
					//               _m_prefetchw(v23);
					//               do
					//               {
					//                 v24 = *v23 | (1LL << v57);
					//                 v58 = *v23;
					//               }
					//               while ( v58 != _InterlockedCompareExchange64(v23, v24, *v23) );
					//             }
					//             ++v48;
					//           }
					//         }
					//       }
					//       catch ( Il2CppExceptionWrapper *v63 )
					//       {
					//         ex = v63.ex;
					//         sub_18289B040(&p_Enumerator);
					//         if ( ex )
					//           sub_18000F780(ex);
					//         return;
					//       }
					//       if ( Enumerator )
					//         sub_18005CC40(0LL, TypeInfo::System::IDisposable, Enumerator);
					//     }
					//   }
					// }
					// 
				}

				internal virtual void PopulateSettingTable(IniDataParser parser, HGRenderPipelineSettingHub.HGRenderPipelineSettings.BaseSettingTable includeFrom, HGDeviceType deviceType, string relativePath, string settingPath, Dictionary<string, string> settingData, HGRenderPipelineSettingHub.HGRenderPipelineSettings impl)
				{
					// // Void PopulateSettingTable(IniDataParser, HGRenderPipelineSettingHub+HGRenderPipelineSettings+BaseSettingTable, HGDeviceType, String, String, Dictionary`2[System.String,System.String], HGRenderPipelineSettingHub+HGRenderPipelineSettings)
					// void HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::PopulateSettingTable(
					//         HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *this,
					//         IniDataParser *parser,
					//         HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *includeFrom,
					//         HGDeviceType__Enum deviceType,
					//         String *relativePath,
					//         String *settingPath,
					//         Dictionary_2_System_String_System_String_ *settingData,
					//         HGRenderPipelineSettingHub_HGRenderPipelineSettings *impl,
					//         MethodInfo *method)
					// {
					//   Dictionary_2_System_String_System_String_ *v13; // rbp
					//   String *v14; // rax
					//   __int64 v15; // rdx
					//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
					//   String *v17; // rdi
					//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
					//   PassConstructorID__Enum__Array *v19; // r8
					//   HGCamera *v20; // r9
					//   String *v21; // r9
					//   HGRenderPathBase_HGRenderPathResources *v22; // rdx
					//   PassConstructorID__Enum__Array *v23; // r8
					//   HGRenderPathBase_HGRenderPathResources *v24; // rdx
					//   PassConstructorID__Enum__Array *v25; // r8
					//   HGCamera *v26; // r9
					//   IniData *iniData; // r9
					//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *v28; // rdi
					//   String *v29; // rax
					//   MethodInfo *parsera; // [rsp+20h] [rbp-68h]
					//   MethodInfo *parserb; // [rsp+20h] [rbp-68h]
					//   MethodInfo *parserc; // [rsp+20h] [rbp-68h]
					//   MethodInfo *v33; // [rsp+28h] [rbp-60h]
					//   MethodInfo *v34; // [rsp+28h] [rbp-60h]
					//   MethodInfo *v35; // [rsp+28h] [rbp-60h]
					//   Enum v36; // [rsp+50h] [rbp-38h] BYREF
					//   HGDeviceType__Enum v37; // [rsp+60h] [rbp-28h]
					// 
					//   if ( !byte_18D8EDB51 )
					//   {
					//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGDeviceType);
					//     sub_18003C530(&off_18C9B4D38);
					//     byte_18D8EDB51 = 1;
					//   }
					//   if ( IFix::WrappersManagerImpl::IsPatched(3234, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(3234, 0LL);
					//     if ( Patch )
					//     {
					//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1155(
					//         Patch,
					//         (Object *)this,
					//         (Object *)parser,
					//         (Object *)includeFrom,
					//         deviceType,
					//         (Object *)relativePath,
					//         (Object *)settingPath,
					//         (Object *)settingData,
					//         (Object *)impl,
					//         0LL);
					//       return;
					//     }
					//     goto LABEL_11;
					//   }
					//   v13 = settingData;
					//   v14 = HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ReadSettingData(
					//           &relativePath,
					//           &settingPath,
					//           settingData,
					//           0LL);
					//   v17 = v14;
					//   if ( !v14 )
					//     goto LABEL_11;
					//   if ( System::String::Equals(v14, (String *)"", 0LL) )
					//     return;
					//   if ( !parser )
					//     goto LABEL_11;
					//   this.fields.iniData = IniParser::IniDataParser::Parse(parser, v17, 0LL);
					//   sub_1800054D0((HGRenderPathScene *)&this.fields.iniData, v18, v19, v20, parsera, v33);
					//   v21 = settingPath;
					//   this.fields.filePath = settingPath;
					//   sub_1800054D0((HGRenderPathScene *)&this.fields.filePath, v22, v23, (HGCamera *)v21, parserb, v34);
					//   this.fields.includeFrom = includeFrom;
					//   sub_1800054D0((HGRenderPathScene *)&this.fields, v24, v25, v26, parserc, v35);
					//   iniData = this.fields.iniData;
					//   if ( !iniData )
					// LABEL_11:
					//     sub_180B536AC(Patch, v15);
					//   if ( iniData.fields._Sections_k__BackingField )
					//   {
					//     v28 = impl;
					//     HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ParseInclude(
					//       this,
					//       (String *)"",
					//       deviceType,
					//       relativePath,
					//       parser,
					//       v13,
					//       impl,
					//       0LL);
					//     v36.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::HGDeviceType;
					//     v36.monitor = (MonitorData *)-1LL;
					//     v37 = deviceType;
					//     v29 = System::Enum::ToString(&v36, 0LL);
					//     HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::BaseSettingTable::ParseInclude(
					//       this,
					//       v29,
					//       deviceType,
					//       relativePath,
					//       parser,
					//       v13,
					//       v28,
					//       0LL);
					//   }
					// }
					// 
				}

				internal HGRenderPipelineSettingHub.HGRenderPipelineSettings.BaseSettingTable includeFrom;

				internal List<HGRenderPipelineSettingHub.HGRenderPipelineSettings.BaseSettingTable> includeList;

				internal string filePath;

				internal List<string> includeSettings;

				internal IniData iniData;
			}
		}

		public abstract class SettingParameterBase
		{
			// (get) Token: 0x06001469 RID: 5225 RVA: 0x000025D2 File Offset: 0x000007D2
			internal string featureName
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
			}

			// (get) Token: 0x0600146A RID: 5226 RVA: 0x000025D2 File Offset: 0x000007D2
			internal string paramName
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
			}

			// (get) Token: 0x0600146B RID: 5227 RVA: 0x000025D8 File Offset: 0x000007D8
			// (set) Token: 0x0600146C RID: 5228 RVA: 0x000025D0 File Offset: 0x000007D0
			protected bool overrided
			{
				get
				{
					// // Boolean get_overrided()
					// bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::get_overrided(
					//         HGRenderPipelineSettingHub_SettingParameterBase *this,
					//         MethodInfo *method)
					// {
					//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rax
					// 
					//   m_paramLookupResult = this.fields.m_paramLookupResult;
					//   if ( !m_paramLookupResult )
					//     sub_180B536AC(this, method);
					//   return m_paramLookupResult.fields.paramSource == 4;
					// }
					// 
					return default(bool);
				}
				set
				{
					// // Void set_overrided(Boolean)
					// // local variable allocation has failed, the output may be wrong!
					// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::set_overrided(
					//         HGRenderPipelineSettingHub_SettingParameterBase *this,
					//         bool value,
					//         MethodInfo *method)
					// {
					//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rax
					// 
					//   if ( value )
					//   {
					//     m_paramLookupResult = this.fields.m_paramLookupResult;
					//     if ( !m_paramLookupResult )
					//       sub_180B536AC(this, value);
					//     m_paramLookupResult.fields.paramSource = 4;
					//   }
					// }
					// 
				}
			}

			// (get) Token: 0x0600146D RID: 5229 RVA: 0x000025D8 File Offset: 0x000007D8
			protected bool shouldRefresh
			{
				get
				{
					// // Boolean get_shouldRefresh()
					// bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::get_shouldRefresh(
					//         HGRenderPipelineSettingHub_SettingParameterBase *this,
					//         MethodInfo *method)
					// {
					//   __int64 v3; // rdx
					//   __int64 v4; // rcx
					//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rax
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					// 
					//   if ( IFix::WrappersManagerImpl::IsPatched(3279, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(3279, 0LL);
					//     if ( Patch )
					//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
					// LABEL_7:
					//     sub_180B536AC(v4, v3);
					//   }
					//   m_paramLookupResult = this.fields.m_paramLookupResult;
					//   if ( !m_paramLookupResult )
					//     goto LABEL_7;
					//   return m_paramLookupResult.fields.paramSource == 3
					//       || m_paramLookupResult.fields.paramSource == 2
					//       || m_paramLookupResult.fields.paramSource == 1;
					// }
					// 
					return default(bool);
				}
			}

			// (get) Token: 0x0600146E RID: 5230 RVA: 0x000025D2 File Offset: 0x000007D2
			protected string valueString
			{
				get
				{
					// // String get_Prefix()
					// String *System::Xml::XmlElement::get_Prefix(XmlElement *this, MethodInfo *method)
					// {
					//   XmlName *name; // rax
					// 
					//   name = this.fields.name;
					//   if ( !name )
					//     sub_180B536AC(this, method);
					//   return name.fields.prefix;
					// }
					// 
					return null;
				}
			}

			// (get) Token: 0x0600146F RID: 5231 RVA: 0x000025D8 File Offset: 0x000007D8
			protected bool isFromCode
			{
				get
				{
					// // Boolean get_isFromCode()
					// bool HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::get_isFromCode(
					//         HGRenderPipelineSettingHub_SettingParameterBase *this,
					//         MethodInfo *method)
					// {
					//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rax
					// 
					//   m_paramLookupResult = this.fields.m_paramLookupResult;
					//   if ( !m_paramLookupResult )
					//     sub_180B536AC(this, method);
					//   return m_paramLookupResult.fields.paramSource == 0;
					// }
					// 
					return default(bool);
				}
			}

			protected SettingParameterBase(string featureName, string paramName)
			{
			}

			public void Reset()
			{
				// // Void Reset()
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::Reset(
				//         HGRenderPipelineSettingHub_SettingParameterBase *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3252, 0LL) )
				//   {
				//     m_paramLookupResult = this.fields.m_paramLookupResult;
				//     if ( m_paramLookupResult )
				//     {
				//       m_paramLookupResult.fields.paramSource = 0;
				//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::MarkFeatureDirty(this, 0LL);
				//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::Refresh(this, 0, 0LL);
				//       return;
				//     }
				// LABEL_5:
				//     sub_180B536AC(v4, v3);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(3252, 0LL);
				//   if ( !Patch )
				//     goto LABEL_5;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				// }
				// 
			}

			internal void Refresh([MetadataOffset(Offset = "0x01F91AE7")] bool useDefaultSettings = false)
			{
				// // Void Refresh(Boolean)
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::Refresh(
				//         HGRenderPipelineSettingHub_SettingParameterBase *this,
				//         bool useDefaultSettings,
				//         MethodInfo *method)
				// {
				//   HGRenderPathBase_HGRenderPathResources *v5; // rdx
				//   __int64 v6; // rcx
				//   __int64 v7; // rdi
				//   PassConstructorID__Enum__Array *v8; // r8
				//   HGCamera *v9; // r9
				//   HGRenderPathBase_HGRenderPathResources *v10; // rdx
				//   PassConstructorID__Enum__Array *v11; // r8
				//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
				//   PassConstructorID__Enum__Array *v13; // r8
				//   HGCamera *v14; // r9
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   MethodInfo *v16; // [rsp+20h] [rbp-18h]
				//   MethodInfo *v17; // [rsp+20h] [rbp-18h]
				//   MethodInfo *v18; // [rsp+20h] [rbp-18h]
				//   MethodInfo *v19; // [rsp+28h] [rbp-10h]
				//   MethodInfo *v20; // [rsp+28h] [rbp-10h]
				//   MethodInfo *v21; // [rsp+28h] [rbp-10h]
				// 
				//   if ( !byte_18D8EDB54 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_SettingParameterBase::ParamLookupResult);
				//     byte_18D8EDB54 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(570, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(570, 0LL);
				//     if ( Patch )
				//     {
				//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(
				//         (ILFixDynamicMethodWrapper_28 *)Patch,
				//         (Object *)this,
				//         useDefaultSettings,
				//         0LL);
				//       return;
				//     }
				//     goto LABEL_13;
				//   }
				//   if ( this.fields.m_paramLookupResult && this.fields.m_paramLookupResult.fields.paramSource == 4 )
				//     return;
				//   v7 = sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_SettingParameterBase::ParamLookupResult);
				//   if ( !v7 )
				// LABEL_13:
				//     sub_180B536AC(v6, v5);
				//   if ( !byte_18D8EDB57 )
				//   {
				//     sub_18003C530(&off_18C9B4D38);
				//     byte_18D8EDB57 = 1;
				//   }
				//   *(_QWORD *)(v7 + 16) = "";
				//   sub_1800054D0((HGRenderPathScene *)(v7 + 16), v5, v8, v9, v16, v19);
				//   *(_QWORD *)(v7 + 24) = "";
				//   sub_1800054D0((HGRenderPathScene *)(v7 + 24), v10, v11, (HGCamera *)"", v17, v20);
				//   this.fields.m_paramLookupResult = (HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *)v7;
				//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_paramLookupResult, v12, v13, v14, v18, v21);
				//   if ( !useDefaultSettings )
				//     HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::AcquireParamValueInSettingTable(
				//       this,
				//       &this.fields.m_paramLookupResult,
				//       0LL);
				//   sub_180040B30(4LL, this);
				// }
				// 
			}

			protected abstract void RefreshInternal();

			internal abstract bool OverrideWithString(string valueString);

			public void MarkFeatureDirty()
			{
				// // Void MarkFeatureDirty()
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::MarkFeatureDirty(
				//         HGRenderPipelineSettingHub_SettingParameterBase *this,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *settingImpl; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(691, 0LL) )
				//   {
				//     settingImpl = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(0LL);
				//     if ( settingImpl )
				//     {
				//       HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::MarkFeatureDirty(
				//         settingImpl,
				//         this.fields._featureName_k__BackingField,
				//         0LL);
				//       return;
				//     }
				// LABEL_4:
				//     sub_180B536AC(v5, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(691, 0LL);
				//   if ( !Patch )
				//     goto LABEL_4;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				// }
				// 
			}

			internal string DumpParameterInfo()
			{
				// // String DumpParameterInfo()
				// String *HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::DumpParameterInfo(
				//         HGRenderPipelineSettingHub_SettingParameterBase *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   __int64 v4; // r8
				//   __int64 v5; // r9
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *m_paramLookupResult; // rcx
				//   String *v7; // rdi
				//   int32_t paramSource; // ecx
				//   int v9; // ecx
				//   int v10; // ecx
				//   int v11; // ecx
				//   __int64 v12; // rax
				//   String__Array *v13; // rsi
				//   String *featureName_k__BackingField; // r8
				//   __int64 v15; // rdx
				//   String *v16; // rax
				//   char *v17; // rdx
				//   __int64 v18; // rax
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v19; // rax
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *fromTable; // r8
				//   String *v21; // rax
				//   String *v22; // rax
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v23; // r8
				//   __int64 v24; // rax
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v25; // rax
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *v26; // r8
				//   String *v27; // rax
				//   String *v28; // rax
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *settingImpl; // rax
				//   String *v30; // rax
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v31; // r8
				//   __int64 v32; // rax
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v33; // rax
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *v34; // r8
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v35; // r8
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v36; // rax
				//   String *v37; // rax
				//   __int64 v38; // r8
				//   __int64 v39; // r9
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v40; // rsi
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_BaseSettingTable *includeFrom; // rsi
				//   __int64 v42; // rax
				//   String__Array *v43; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   Enum v46; // [rsp+20h] [rbp-48h] BYREF
				//   int32_t deviceType; // [rsp+30h] [rbp-38h]
				//   Int32 v48; // [rsp+80h] [rbp+18h] BYREF
				// 
				//   if ( !byte_18D9196ED )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGDeviceType);
				//     sub_18003C530(&TypeInfo::System::String);
				//     sub_18003C530(&off_18D5161D8);
				//     sub_18003C530(&off_18D5161B0);
				//     sub_18003C530(&off_18D5161D0);
				//     sub_18003C530(&off_18D5161B8);
				//     sub_18003C530(&off_18D5161C0);
				//     sub_18003C530(&off_18D5161C8);
				//     sub_18003C530(&off_18D5161A0);
				//     sub_18003C530(&off_18D516208);
				//     sub_18003C530(&off_18D516210);
				//     sub_18003C530(&off_18D516218);
				//     sub_18003C530(&off_18D516228);
				//     sub_18003C530(&off_18D5161E0);
				//     sub_18003C530(&off_18D5161E8);
				//     sub_18003C530(&off_18C9B4D38);
				//     sub_18003C530(&off_18D5161F8);
				//     sub_18003C530(&off_18C9E4B38);
				//     sub_18003C530(&off_18D516200);
				//     byte_18D9196ED = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3278, 0LL) )
				//   {
				//     m_paramLookupResult = this.fields.m_paramLookupResult;
				//     v7 = (String *)"";
				//     if ( !m_paramLookupResult )
				//       goto LABEL_50;
				//     paramSource = m_paramLookupResult.fields.paramSource;
				//     if ( paramSource )
				//     {
				//       v9 = paramSource - 1;
				//       if ( v9 )
				//       {
				//         v10 = v9 - 1;
				//         if ( v10 )
				//         {
				//           v11 = v10 - 1;
				//           if ( v11 )
				//           {
				//             m_paramLookupResult = (HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *)(unsigned int)(v11 - 1);
				//             if ( (_DWORD)m_paramLookupResult )
				//             {
				//               if ( (_DWORD)m_paramLookupResult != 1 )
				//                 goto LABEL_38;
				//               v12 = il2cpp_array_new_specific_0(TypeInfo::System::String, 5LL, v4, v5);
				//               v13 = (String__Array *)v12;
				//               if ( !v12 )
				//                 goto LABEL_50;
				//               sub_1800046C0(v12, 0LL, "");
				//               sub_1800046C0(v13, 1LL, "Something wrong with parameter:");
				//               sub_1800046C0(v13, 2LL, this.fields._paramName_k__BackingField);
				//               sub_1800046C0(v13, 3LL, " of feature:");
				//               featureName_k__BackingField = this.fields._featureName_k__BackingField;
				//               v15 = 4LL;
				//               goto LABEL_13;
				//             }
				//             v17 = "Parameter override by code";
				// LABEL_36:
				//             v16 = System::String::Concat((String *)"", (String *)v17, 0LL);
				//             goto LABEL_37;
				//           }
				//           v18 = il2cpp_array_new_specific_0(TypeInfo::System::String, 15LL, v4, v5);
				//           v13 = (String__Array *)v18;
				//           if ( !v18 )
				//             goto LABEL_50;
				//           sub_1800046C0(v18, 0LL, "");
				//           sub_1800046C0(v13, 1LL, "Parameter exactly matched in table:");
				//           v19 = this.fields.m_paramLookupResult;
				//           if ( !v19 )
				//             goto LABEL_50;
				//           fromTable = v19.fields.fromTable;
				//           if ( !fromTable )
				//             goto LABEL_50;
				//           sub_1800046C0(v13, 2LL, fromTable.fields.filePath);
				//           sub_1800046C0(v13, 3LL, ".");
				//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//           sub_1800046C0(
				//             v13,
				//             4LL,
				//             TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings.static_fields.SETTING_EXT);
				//           sub_1800046C0(v13, 5LL, "\n FeatureName:");
				//           sub_1800046C0(v13, 6LL, this.fields._featureName_k__BackingField);
				//           sub_1800046C0(v13, 7LL, "\n DeviceType:");
				//           m_paramLookupResult = this.fields.m_paramLookupResult;
				//           if ( !m_paramLookupResult )
				//             goto LABEL_50;
				//           v46.monitor = (MonitorData *)-1LL;
				//           v46.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::HGDeviceType;
				//           deviceType = m_paramLookupResult.fields.deviceType;
				//           v21 = System::Enum::ToString(&v46, 0LL);
				//           sub_1800046C0(v13, 8LL, v21);
				//           sub_1800046C0(v13, 9LL, "\n Tier:");
				//           m_paramLookupResult = this.fields.m_paramLookupResult;
				//           if ( !m_paramLookupResult )
				//             goto LABEL_50;
				//           v22 = System::Int32::ToString((Int32 *)&m_paramLookupResult.fields.tier, 0LL);
				//           sub_1800046C0(v13, 10LL, v22);
				//           sub_1800046C0(v13, 11LL, "\n ParamName:");
				//           sub_1800046C0(v13, 12LL, this.fields._paramName_k__BackingField);
				//           sub_1800046C0(v13, 13LL, "\n Constrain:");
				//           v23 = this.fields.m_paramLookupResult;
				//           if ( !v23 )
				//             goto LABEL_50;
				//           featureName_k__BackingField = v23.fields.constrainString;
				//           v15 = 14LL;
				//         }
				//         else
				//         {
				//           v24 = il2cpp_array_new_specific_0(TypeInfo::System::String, 17LL, v4, v5);
				//           v13 = (String__Array *)v24;
				//           if ( !v24 )
				//             goto LABEL_50;
				//           sub_1800046C0(v24, 0LL, "");
				//           sub_1800046C0(v13, 1LL, "Closest parameter found in table:");
				//           v25 = this.fields.m_paramLookupResult;
				//           if ( !v25 )
				//             goto LABEL_50;
				//           v26 = v25.fields.fromTable;
				//           if ( !v26 )
				//             goto LABEL_50;
				//           sub_1800046C0(v13, 2LL, v26.fields.filePath);
				//           sub_1800046C0(v13, 3LL, ".");
				//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//           sub_1800046C0(
				//             v13,
				//             4LL,
				//             TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings.static_fields.SETTING_EXT);
				//           sub_1800046C0(v13, 5LL, "\n FeatureName:");
				//           sub_1800046C0(v13, 6LL, this.fields._featureName_k__BackingField);
				//           sub_1800046C0(v13, 7LL, "\n DeviceType:");
				//           m_paramLookupResult = this.fields.m_paramLookupResult;
				//           if ( !m_paramLookupResult )
				//             goto LABEL_50;
				//           v46.monitor = (MonitorData *)-1LL;
				//           v46.klass = (Enum__Class *)TypeInfo::HG::Rendering::Runtime::HGDeviceType;
				//           deviceType = m_paramLookupResult.fields.deviceType;
				//           v27 = System::Enum::ToString(&v46, 0LL);
				//           sub_1800046C0(v13, 8LL, v27);
				//           sub_1800046C0(v13, 9LL, "\n Tier:");
				//           m_paramLookupResult = this.fields.m_paramLookupResult;
				//           if ( !m_paramLookupResult )
				//             goto LABEL_50;
				//           v28 = System::Int32::ToString((Int32 *)&m_paramLookupResult.fields.tier, 0LL);
				//           sub_1800046C0(v13, 10LL, v28);
				//           sub_1800046C0(v13, 11LL, "\n Expected Tier:");
				//           settingImpl = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(0LL);
				//           if ( !settingImpl )
				//             goto LABEL_50;
				//           v48.m_value = settingImpl.fields._currentDeviceTier_k__BackingField;
				//           v30 = System::Int32::ToString(&v48, 0LL);
				//           sub_1800046C0(v13, 12LL, v30);
				//           sub_1800046C0(v13, 13LL, "\n ParamName:");
				//           sub_1800046C0(v13, 14LL, this.fields._paramName_k__BackingField);
				//           sub_1800046C0(v13, 15LL, "\n Constrain:");
				//           v31 = this.fields.m_paramLookupResult;
				//           if ( !v31 )
				//             goto LABEL_50;
				//           featureName_k__BackingField = v31.fields.constrainString;
				//           v15 = 16LL;
				//         }
				//       }
				//       else
				//       {
				//         v32 = il2cpp_array_new_specific_0(TypeInfo::System::String, 11LL, v4, v5);
				//         v13 = (String__Array *)v32;
				//         if ( !v32 )
				//           goto LABEL_50;
				//         sub_1800046C0(v32, 0LL, "");
				//         sub_1800046C0(v13, 1LL, "Only default parameter found in table:");
				//         v33 = this.fields.m_paramLookupResult;
				//         if ( !v33 )
				//           goto LABEL_50;
				//         v34 = v33.fields.fromTable;
				//         if ( !v34 )
				//           goto LABEL_50;
				//         sub_1800046C0(v13, 2LL, v34.fields.filePath);
				//         sub_1800046C0(v13, 3LL, ".");
				//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//         sub_1800046C0(
				//           v13,
				//           4LL,
				//           TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings.static_fields.SETTING_EXT);
				//         sub_1800046C0(v13, 5LL, "\n FeatureName:");
				//         sub_1800046C0(v13, 6LL, this.fields._featureName_k__BackingField);
				//         sub_1800046C0(v13, 7LL, "\n ParamName:");
				//         sub_1800046C0(v13, 8LL, this.fields._paramName_k__BackingField);
				//         sub_1800046C0(v13, 9LL, "\n Constrain:");
				//         v35 = this.fields.m_paramLookupResult;
				//         if ( !v35 )
				//           goto LABEL_50;
				//         featureName_k__BackingField = v35.fields.constrainString;
				//         v15 = 10LL;
				//       }
				// LABEL_13:
				//       sub_1800046C0(v13, v15, featureName_k__BackingField);
				//       v16 = System::String::Concat(v13, 0LL);
				// LABEL_37:
				//       v7 = v16;
				// LABEL_38:
				//       v36 = this.fields.m_paramLookupResult;
				//       if ( v36 )
				//       {
				//         if ( v36.fields.paramSource != 1 && v36.fields.paramSource != 2 && v36.fields.paramSource != 3 )
				//           return v7;
				//         v37 = System::String::Concat(v7, (String *)"\nInclude Chain:", 0LL);
				//         v40 = this.fields.m_paramLookupResult;
				//         v7 = v37;
				//         if ( v40 )
				//         {
				//           includeFrom = v40.fields.fromTable;
				//           if ( includeFrom )
				//           {
				//             while ( 1 )
				//             {
				//               includeFrom = includeFrom.fields.includeFrom;
				//               if ( !includeFrom )
				//                 return v7;
				//               v42 = il2cpp_array_new_specific_0(TypeInfo::System::String, 5LL, v38, v39);
				//               v43 = (String__Array *)v42;
				//               if ( !v42 )
				//                 break;
				//               sub_1800046C0(v42, 0LL, v7);
				//               sub_1800046C0(v43, 1LL, "\n Include from:");
				//               sub_1800046C0(v43, 2LL, includeFrom.fields.filePath);
				//               sub_1800046C0(v43, 3LL, ".");
				//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//               sub_1800046C0(
				//                 v43,
				//                 4LL,
				//                 TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings.static_fields.SETTING_EXT);
				//               v7 = System::String::Concat(v43, 0LL);
				//             }
				//           }
				//         }
				//       }
				// LABEL_50:
				//       sub_180B536AC(m_paramLookupResult, v3);
				//     }
				//     v17 = "No such parameter in table, use value in code instead";
				//     goto LABEL_36;
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(3278, 0LL);
				//   if ( !Patch )
				//     goto LABEL_50;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}

			private void AcquireParamValueInSettingTable(ref HGRenderPipelineSettingHub.SettingParameterBase.ParamLookupResult paramLookupResult)
			{
				// // Void AcquireParamValueInSettingTable(HGRenderPipelineSettingHub+SettingParameterBase+ParamLookupResult ByRef)
				// void HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::AcquireParamValueInSettingTable(
				//         HGRenderPipelineSettingHub_SettingParameterBase *this,
				//         HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult **paramLookupResult,
				//         MethodInfo *method)
				// {
				//   Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *tierValues; // rdx
				//   Dictionary_2_TKey_TValue_Entry_System_Object_System_Int32___Array *entries; // rcx
				//   __int64 v7; // rdi
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *settingImpl; // rax
				//   int32_t currentDeviceType_k__BackingField; // r12d
				//   Object *v10; // rbx
				//   Dictionary_2_System_Object_System_Int32_ *klass; // rbx
				//   Object *featureName_k__BackingField; // r14
				//   struct MethodInfo *v13; // rbp
				//   int32_t Entry; // eax
				//   __int64 currentDeviceTier_k__BackingField; // rdx
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *v16; // rax
				//   struct HGRenderPipelineSettingHub_ConstantStrings__Class *v17; // rax
				//   String *paramName_k__BackingField; // rbx
				//   String *v19; // rax
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo *Param_24_0; // rax
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo *v21; // rsi
				//   List_1_System_Int32_ *tiers; // rbp
				//   Predicate_1_Int32_ *v23; // rax
				//   Predicate_1_Int32_ *v24; // rbx
				//   int32_t v25; // ebx
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v26; // rax
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v27; // rdi
				//   PassConstructorID__Enum__Array *v28; // r8
				//   HGCamera *v29; // r9
				//   HGRenderPipelineSettingHub_SettingParameterBase_ParamLookupResult *v30; // rdi
				//   PassConstructorID__Enum__Array *v31; // r8
				//   HGCamera *v32; // r9
				//   ILFixDynamicMethodWrapper_2 *v33; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue v35; // [rsp+20h] [rbp-28h] BYREF
				// 
				//   if ( !byte_18D8EDB55 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::ContainsKey);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::get_Item);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Find);
				//     sub_18003C530(&TypeInfo::System::Predicate<int>);
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_SettingParameterBase::__c__DisplayClass24_0::_AcquireParamValueInSettingTable_b__1);
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_SettingParameterBase::__c__DisplayClass24_0);
				//     byte_18D8EDB55 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(571, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(571, 0LL);
				//     if ( Patch )
				//     {
				//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_224(Patch, (Object *)this, paramLookupResult, 0LL);
				//       return;
				//     }
				//     goto LABEL_41;
				//   }
				//   v7 = sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_SettingParameterBase::__c__DisplayClass24_0);
				//   if ( !v7 )
				//     goto LABEL_41;
				//   settingImpl = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(0LL);
				//   if ( !settingImpl )
				//     goto LABEL_41;
				//   currentDeviceType_k__BackingField = settingImpl.fields._currentDeviceType_k__BackingField;
				//   v10 = (Object *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(0LL);
				//   if ( !v10 )
				//     goto LABEL_41;
				//   if ( IFix::WrappersManagerImpl::IsPatched(575, 0LL) )
				//   {
				//     v33 = IFix::WrappersManagerImpl::GetPatch(575, 0LL);
				//     if ( !v33 )
				//       goto LABEL_41;
				//     klass = (Dictionary_2_System_Object_System_Int32_ *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_221(v33, v10, 0LL);
				//   }
				//   else
				//   {
				//     klass = (Dictionary_2_System_Object_System_Int32_ *)v10[3].klass;
				//   }
				//   featureName_k__BackingField = (Object *)this.fields._featureName_k__BackingField;
				//   if ( !klass )
				//     goto LABEL_41;
				//   v13 = MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue;
				//   if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue.klass.rgctx_data[22].rgctxDataDummy
				//         + 4) )
				//     (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::TryGetValue.klass.rgctx_data[22].rgctxDataDummy)();
				//   Entry = System::Collections::Generic::Dictionary<System::Object,int>::FindEntry(
				//             klass,
				//             featureName_k__BackingField,
				//             (MethodInfo *)v13.klass.rgctx_data[22].rgctxDataDummy);
				//   if ( Entry < 0 )
				//   {
				//     v16 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(0LL);
				//     if ( !v16 )
				//       goto LABEL_41;
				//     currentDeviceTier_k__BackingField = (unsigned int)v16.fields._currentDeviceTier_k__BackingField;
				//   }
				//   else
				//   {
				//     entries = klass.fields._entries;
				//     if ( !entries )
				//       goto LABEL_41;
				//     if ( (unsigned int)Entry >= entries.max_length.size )
				//       sub_180070270(entries, tierValues);
				//     currentDeviceTier_k__BackingField = (unsigned int)entries.vector[Entry].value;
				//   }
				//   *(_DWORD *)(v7 + 16) = currentDeviceTier_k__BackingField;
				//   v17 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				//   paramName_k__BackingField = this.fields._paramName_k__BackingField;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(
				//       TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings,
				//       currentDeviceTier_k__BackingField);
				//     v17 = TypeInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub::ConstantStrings;
				//   }
				//   v19 = System::String::Concat(
				//           paramName_k__BackingField,
				//           v17.static_fields.ARRAY_CONCATENATE_STR,
				//           this.fields._featureName_k__BackingField,
				//           0LL);
				//   Param_24_0 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::_AcquireParamValueInSettingTable_g___FindParam_24_0(
				//                  v19,
				//                  *(_DWORD *)(v7 + 16),
				//                  0LL);
				//   v21 = Param_24_0;
				//   if ( Param_24_0 )
				//   {
				//     tiers = Param_24_0.fields.tiers;
				//     v23 = (Predicate_1_Int32_ *)sub_180004920(TypeInfo::System::Predicate<int>);
				//     v24 = v23;
				//     if ( !v23 )
				//       goto LABEL_41;
				//     System::Predicate<int>::Predicate(
				//       v23,
				//       (Object *)v7,
				//       MethodInfo::HG::Rendering::Runtime::HGRenderPipelineSettingHub_SettingParameterBase::__c__DisplayClass24_0::_AcquireParamValueInSettingTable_b__1,
				//       0LL);
				//     if ( !tiers )
				//       goto LABEL_41;
				//     v25 = System::Collections::Generic::List<int>::Find(
				//             tiers,
				//             v24,
				//             MethodInfo::System::Collections::Generic::List<int>::Find);
				//     if ( v25 )
				//     {
				//       v26 = *paramLookupResult;
				//       if ( v25 == *(_DWORD *)(v7 + 16) )
				//       {
				//         if ( !v26 )
				//           goto LABEL_41;
				//         v26.fields.paramSource = 3;
				//       }
				//       else
				//       {
				//         if ( !v26 )
				//           goto LABEL_41;
				//         v26.fields.paramSource = 2;
				//       }
				//       goto LABEL_28;
				//     }
				//     entries = (Dictionary_2_TKey_TValue_Entry_System_Object_System_Int32___Array *)v21.fields.tierValues;
				//     if ( entries )
				//     {
				//       if ( !System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::ContainsKey(
				//               (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *)entries,
				//               0,
				//               MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::ContainsKey) )
				//         return;
				//       if ( *paramLookupResult )
				//       {
				//         (*paramLookupResult).fields.paramSource = 1;
				// LABEL_28:
				//         tierValues = v21.fields.tierValues;
				//         v27 = *paramLookupResult;
				//         if ( tierValues )
				//         {
				//           System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::get_Item(
				//             &v35,
				//             tierValues,
				//             v25,
				//             MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::get_Item);
				//           if ( v27 )
				//           {
				//             v27.fields.fromTable = v35.from;
				//             sub_1800054D0(
				//               (HGRenderPathScene *)&v27.fields.fromTable,
				//               (HGRenderPathBase_HGRenderPathResources *)tierValues,
				//               v28,
				//               v29,
				//               (MethodInfo *)v35.from,
				//               (MethodInfo *)v35.value);
				//             if ( *paramLookupResult )
				//             {
				//               (*paramLookupResult).fields.tier = v25;
				//               if ( *paramLookupResult )
				//               {
				//                 (*paramLookupResult).fields.deviceType = currentDeviceType_k__BackingField;
				//                 tierValues = v21.fields.tierValues;
				//                 v30 = *paramLookupResult;
				//                 if ( tierValues )
				//                 {
				//                   System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::get_Item(
				//                     &v35,
				//                     tierValues,
				//                     v25,
				//                     MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::get_Item);
				//                   if ( v30 )
				//                   {
				//                     v30.fields.value = v35.value;
				//                     sub_1800054D0(
				//                       (HGRenderPathScene *)&v30.fields,
				//                       (HGRenderPathBase_HGRenderPathResources *)tierValues,
				//                       v31,
				//                       v32,
				//                       (MethodInfo *)v35.from,
				//                       (MethodInfo *)v35.value);
				//                     return;
				//                   }
				//                 }
				//               }
				//             }
				//           }
				//         }
				//       }
				//     }
				// LABEL_41:
				//     sub_180B536AC(entries, tierValues);
				//   }
				// }
				// 
			}

			[CompilerGenerated]
			internal static HGRenderPipelineSettingHub.HGRenderPipelineSettings.ParamInfo <AcquireParamValueInSettingTable>g___FindParam|24_0(string key, int tier)
			{
				// // HGRenderPipelineSettingHub+HGRenderPipelineSettings+ParamInfo <AcquireParamValueInSettingTable>g___FindParam|24_0(String, Int32)
				// HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo *HG::Rendering::Runtime::HGRenderPipelineSettingHub::SettingParameterBase::_AcquireParamValueInSettingTable_g___FindParam_24_0(
				//         String *key,
				//         int32_t tier,
				//         MethodInfo *method)
				// {
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo *v5; // rbx
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo *v6; // rbp
				//   __int64 v7; // rdx
				//   char *m_impl; // rcx
				//   Object *settingImpl; // rdi
				//   Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo_ *klass; // rax
				//   Object *monitor; // rdi
				//   int32_t v13; // esi
				//   HGRenderPipelineSettingHub *instance; // rax
				//   int32_t v15; // r15d
				//   bool v16; // cl
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo *v17; // rax
				//   bool v18; // al
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   Object *value; // [rsp+68h] [rbp+20h] BYREF
				// 
				//   if ( !byte_18D8EDB56 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::ContainsKey);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::TryGetValue);
				//     sub_18003C530(&off_18C9B4D38);
				//     byte_18D8EDB56 = 1;
				//   }
				//   v5 = 0LL;
				//   value = 0LL;
				//   v6 = 0LL;
				//   settingImpl = (Object *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_settingImpl(0LL);
				//   if ( !settingImpl )
				//     goto LABEL_28;
				//   if ( !IFix::WrappersManagerImpl::IsPatched(580, 0LL) )
				//   {
				//     klass = (Dictionary_2_System_String_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo_ *)settingImpl[4].klass;
				//     goto LABEL_6;
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(580, 0LL);
				//   if ( !Patch )
				// LABEL_28:
				//     sub_180B536AC(m_impl, v7);
				//   klass = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_222(Patch, settingImpl, 0LL);
				// LABEL_6:
				//   if ( !klass )
				//     goto LABEL_28;
				//   if ( System::Collections::Generic::Dictionary<System::Object,System::Object>::TryGetValue(
				//          (Dictionary_2_System_Object_System_Object_ *)klass,
				//          (Object *)key,
				//          &value,
				//          MethodInfo::System::Collections::Generic::Dictionary<System::String,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::ParamInfo>::TryGetValue) )
				//   {
				//     monitor = value;
				//     v13 = 0;
				//     if ( !value )
				//       return v6;
				//     do
				//     {
				//       instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
				//       if ( !instance )
				//         goto LABEL_28;
				//       m_impl = (char *)instance.fields.m_impl;
				//       if ( !m_impl )
				//         goto LABEL_28;
				//       v15 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::HGRenderPipelineSettings::CheckConstrains(
				//               (HGRenderPipelineSettingHub_HGRenderPipelineSettings *)m_impl,
				//               (String *)monitor[1].klass,
				//               0LL);
				//       if ( v15 > v13 )
				//       {
				//         m_impl = (char *)monitor[1].monitor;
				//         if ( !m_impl )
				//           goto LABEL_28;
				//         v18 = System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::ContainsKey(
				//                 (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *)m_impl,
				//                 tier,
				//                 MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::ContainsKey);
				//         m_impl = (char *)monitor[1].monitor;
				//         if ( !m_impl )
				//           goto LABEL_28;
				//         if ( v18 | System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::ContainsKey(
				//                      (Dictionary_2_System_Int32_HG_Rendering_Runtime_HGRenderPipelineSettingHub_HGRenderPipelineSettings_TierValue_ *)m_impl,
				//                      0,
				//                      MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGRenderPipelineSettingHub_HGRenderPipelineSettings::TierValue>::ContainsKey) )
				//         {
				//           v13 = v15;
				//           v5 = (HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo *)monitor;
				//         }
				//       }
				//       m_impl = (char *)monitor[1].klass;
				//       if ( !m_impl )
				//         goto LABEL_28;
				//       v16 = m_impl == ""
				//          || ""
				//          && *((_DWORD *)m_impl + 4) == *(_DWORD *)&asc_18F253034[16]
				//          && System::SpanHelpers::SequenceEqual(
				//               (uint8_t *)m_impl + 20,
				//               (uint8_t *)&asc_18F253034[20],
				//               2LL * *((int *)m_impl + 4),
				//               0LL);
				//       v17 = (HGRenderPipelineSettingHub_HGRenderPipelineSettings_ParamInfo *)monitor;
				//       monitor = (Object *)monitor[2].monitor;
				//       if ( !v16 )
				//         v17 = v6;
				//       v6 = v17;
				//     }
				//     while ( monitor );
				//     if ( !v13 )
				//       return v6;
				//   }
				//   return v5;
				// }
				// 
				return null;
			}

			private HGRenderPipelineSettingHub.SettingParameterBase.ParamLookupResult m_paramLookupResult;

			private class ParamLookupResult
			{
				public ParamLookupResult()
				{
				}

				internal string value;

				internal string constrainString;

				internal int tier;

				internal HGDeviceType deviceType;

				internal HGRenderPipelineSettingHub.HGRenderPipelineSettings.BaseSettingTable fromTable;

				internal HGRenderPipelineSettingHub.SettingParameterBase.ParamLookupResult.ParamSource paramSource;

				internal enum ParamSource
				{
					FromCode,
					FromDefault,
					FromClosest,
					FromMatched,
					FromOverride,
					Error
				}
			}
		}
	}
}
