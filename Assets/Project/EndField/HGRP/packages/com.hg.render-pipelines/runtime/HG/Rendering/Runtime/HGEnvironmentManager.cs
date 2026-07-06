using System;
using System.Collections.Generic;
using Beyond;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGEnvironmentManager
	{
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGEnvironmentManager instance
		{
			get
			{
				// // HGEnvironmentManager get_instance()
				// HGEnvironmentManager *HG::Rendering::Runtime::HGEnvironmentManager::get_instance(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   struct HGEnvironmentManager__Class *v2; // rax
				//   Lazy_1_Object_ *s_instance; // rcx
				// 
				//   if ( !byte_18D8EDC57 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     sub_18003C530(&MethodInfo::System::Lazy<HG::Rendering::Runtime::HGEnvironmentManager>::get_Value);
				//     byte_18D8EDC57 = 1;
				//   }
				//   v2 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//     v2 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager;
				//   }
				//   s_instance = (Lazy_1_Object_ *)v2.static_fields.s_instance;
				//   if ( !s_instance )
				//     sub_180B536AC(0LL, v1);
				//   return (HGEnvironmentManager *)System::Lazy<System::Object>::get_Value(
				//                                    s_instance,
				//                                    MethodInfo::System::Lazy<HG::Rendering::Runtime::HGEnvironmentManager>::get_Value);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000623 RID: 1571 RVA: 0x000025D8 File Offset: 0x000007D8
		public static bool initialized
		{
			get
			{
				// // Boolean get_initialized()
				// bool HG::Rendering::Runtime::HGEnvironmentManager::get_initialized(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   HGEnvironmentManager__StaticFields *static_fields; // rcx
				//   LazyHelper *state; // rax
				//   signed __int32 v5[10]; // [rsp+0h] [rbp-28h] BYREF
				// 
				//   if ( !byte_18D919D73 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     sub_18003C530(&MethodInfo::System::Lazy<HG::Rendering::Runtime::HGEnvironmentManager>::get_IsValueCreated);
				//     byte_18D919D73 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//   static_fields = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager.static_fields;
				//   if ( !static_fields.s_instance )
				//     sub_180B536AC(static_fields, v1);
				//   state = static_fields.s_instance.fields._state;
				//   _InterlockedOr(v5, 0);
				//   return state == 0LL;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000624 RID: 1572 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGAtmosphereRenderer s_atmosphereRenderer
		{
			get
			{
				// // HGAtmosphereRenderer get_s_atmosphereRenderer()
				// HGAtmosphereRenderer *HG::Rendering::Runtime::HGEnvironmentManager::get_s_atmosphereRenderer(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   HGEnvironmentManager *instance; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   if ( !byte_18D919D74 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D919D74 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//   instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//   if ( !instance )
				//     sub_180B536AC(v4, v3);
				//   return instance.fields.m_atmosphereRenderer;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000625 RID: 1573 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGVolumetricFogRenderer s_volumetricFogRenderer
		{
			get
			{
				// // HGVolumetricFogRenderer get_s_volumetricFogRenderer()
				// HGVolumetricFogRenderer *HG::Rendering::Runtime::HGEnvironmentManager::get_s_volumetricFogRenderer(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   HGEnvironmentManager *instance; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   if ( !byte_18D919D75 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D919D75 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//   instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//   if ( !instance )
				//     sub_180B536AC(v4, v3);
				//   return instance.fields.m_volumetricFogRenderer;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000626 RID: 1574 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGSkyRenderer s_skyRenderer
		{
			get
			{
				// // HGSkyRenderer get_s_skyRenderer()
				// HGSkyRenderer *HG::Rendering::Runtime::HGEnvironmentManager::get_s_skyRenderer(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   HGEnvironmentManager *instance; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   if ( !byte_18D8EDC59 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D8EDC59 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//   instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//   if ( !instance )
				//     sub_180B536AC(v4, v3);
				//   return instance.fields.m_skyRenderer;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000627 RID: 1575 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGSkydomeStarRenderer s_talosRenderer
		{
			get
			{
				// // HGSkydomeStarRenderer get_s_talosRenderer()
				// HGSkydomeStarRenderer *HG::Rendering::Runtime::HGEnvironmentManager::get_s_talosRenderer(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   HGEnvironmentManager *instance; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   if ( !byte_18D919D76 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D919D76 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//   instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//   if ( !instance )
				//     sub_180B536AC(v4, v3);
				//   return instance.fields.m_talosStarRenderer;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000628 RID: 1576 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGRainRenderer s_rainRenderer
		{
			get
			{
				// // HGRainRenderer get_s_rainRenderer()
				// HGRainRenderer *HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   Lazy_1_HG_Rendering_Runtime_HGEnvironmentManager_ *s_instance; // rcx
				//   Object *Value; // rax
				// 
				//   if ( !byte_18D8EDC5A )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D8EDC5A = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//   if ( !byte_18D8EDC57 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     sub_18003C530(&MethodInfo::System::Lazy<HG::Rendering::Runtime::HGEnvironmentManager>::get_Value);
				//     byte_18D8EDC57 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//   s_instance = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager.static_fields.s_instance;
				//   if ( !s_instance
				//     || (Value = System::Lazy<System::Object>::get_Value(
				//                   (Lazy_1_Object_ *)s_instance,
				//                   MethodInfo::System::Lazy<HG::Rendering::Runtime::HGEnvironmentManager>::get_Value)) == 0LL )
				//   {
				//     sub_180B536AC(s_instance, v1);
				//   }
				//   return (HGRainRenderer *)Value[5].klass;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000629 RID: 1577 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGSnowRenderer s_snowRenderer
		{
			get
			{
				// // HGSnowRenderer get_s_snowRenderer()
				// HGSnowRenderer *HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   HGEnvironmentManager *instance; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   if ( !byte_18D8EDC5B )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D8EDC5B = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//   instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//   if ( !instance )
				//     sub_180B536AC(v4, v3);
				//   return instance.fields.m_snowRenderer;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600062A RID: 1578 RVA: 0x000025D2 File Offset: 0x000007D2
		public static IndexedHashSet<HGEnvironmentVolume> s_interpolatedVolumes
		{
			get
			{
				// // IndexedHashSet`1[HG.Rendering.Runtime.HGEnvironmentVolume] get_s_interpolatedVolumes()
				// IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedVolumes(
				//         MethodInfo *method)
				// {
				//   HGEnvironmentManager *instance; // rax
				//   __int64 v2; // rdx
				//   __int64 v3; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D919D77 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D919D77 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(983, 0LL) )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//     if ( instance )
				//       return instance.fields.m_interpolatedVolumes;
				// LABEL_7:
				//     sub_180B536AC(v3, v2);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(983, 0LL);
				//   if ( !Patch )
				//     goto LABEL_7;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_361(Patch, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600062B RID: 1579 RVA: 0x000025D2 File Offset: 0x000007D2
		public static List<float> s_interpolatedVolumesFactor
		{
			get
			{
				// // List`1[System.Single] get_s_interpolatedVolumesFactor()
				// List_1_System_Single_ *HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedVolumesFactor(
				//         MethodInfo *method)
				// {
				//   HGEnvironmentManager *instance; // rax
				//   __int64 v2; // rdx
				//   __int64 v3; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D919D78 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D919D78 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(985, 0LL) )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//     if ( instance )
				//       return instance.fields.m_interpolatedVolumesFactor;
				// LABEL_7:
				//     sub_180B536AC(v3, v2);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(985, 0LL);
				//   if ( !Patch )
				//     goto LABEL_7;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_362(Patch, 0LL);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600062C RID: 1580 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGEnvironmentPhase s_interpolatedPhase
		{
			get
			{
				// // HGEnvironmentPhase get_s_interpolatedPhase()
				// HGEnvironmentPhase *HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedPhase(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   Lazy_1_HG_Rendering_Runtime_HGEnvironmentManager_ *s_instance; // rcx
				//   Object *Value; // rax
				// 
				//   if ( !byte_18D8EDC5C )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D8EDC5C = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//   if ( !byte_18D8EDC57 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     sub_18003C530(&MethodInfo::System::Lazy<HG::Rendering::Runtime::HGEnvironmentManager>::get_Value);
				//     byte_18D8EDC57 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//   s_instance = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager.static_fields.s_instance;
				//   if ( !s_instance
				//     || (Value = System::Lazy<System::Object>::get_Value(
				//                   (Lazy_1_Object_ *)s_instance,
				//                   MethodInfo::System::Lazy<HG::Rendering::Runtime::HGEnvironmentManager>::get_Value)) == 0LL )
				//   {
				//     sub_180B536AC(s_instance, v1);
				//   }
				//   return (HGEnvironmentPhase *)Value[6].monitor;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600062D RID: 1581 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x000025D0 File Offset: 0x000007D0
		public static Transform interpolateTriggerOverride
		{
			get
			{
				// // Transform get_interpolateTriggerOverride()
				// Transform *HG::Rendering::Runtime::HGEnvironmentManager::get_interpolateTriggerOverride(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   HGEnvironmentManager *instance; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   if ( !byte_18D8EDC60 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D8EDC60 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//   instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//   if ( !instance )
				//     sub_180B536AC(v4, v3);
				//   return instance.fields.m_interpolateTriggerOverride;
				// }
				// 
				return null;
			}
			set
			{
				// // Void set_interpolateTriggerOverride(Transform)
				// void HG::Rendering::Runtime::HGEnvironmentManager::set_interpolateTriggerOverride(Transform *value, MethodInfo *method)
				// {
				//   HGEnvironmentManager *instance; // rax
				//   OneofDescriptorProto *v4; // rdx
				//   __int64 v5; // rcx
				//   FileDescriptor *v6; // r8
				//   MessageDescriptor *v7; // r9
				//   String__Array *v8; // [rsp+50h] [rbp+28h]
				//   String *v9; // [rsp+58h] [rbp+30h]
				//   MethodInfo *v10; // [rsp+60h] [rbp+38h]
				// 
				//   if ( !byte_18D919D79 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D919D79 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//   instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//   if ( !instance )
				//     sub_180B536AC(v5, v4);
				//   instance.fields.m_interpolateTriggerOverride = value;
				//   sub_1800054D0((OneofDescriptor *)&instance.fields.m_interpolateTriggerOverride, v4, v6, v7, v8, v9, v10);
				// }
				// 
			}
		}

		// (get) Token: 0x0600062F RID: 1583 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x000025D0 File Offset: 0x000007D0
		public static bool sortNeeded
		{
			get
			{
				// // Boolean get_sortNeeded()
				// bool HG::Rendering::Runtime::HGEnvironmentManager::get_sortNeeded(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   HGEnvironmentManager *instance; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   if ( !byte_18D919D7A )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D919D7A = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//   instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//   if ( !instance )
				//     sub_180B536AC(v4, v3);
				//   return instance.fields.m_sortNeeded;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_sortNeeded(Boolean)
				// void HG::Rendering::Runtime::HGEnvironmentManager::set_sortNeeded(bool value, MethodInfo *method)
				// {
				//   HGEnvironmentManager *instance; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( !byte_18D8EDC61 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D8EDC61 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, method);
				//   instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//   if ( !instance )
				//     sub_180B536AC(v5, v4);
				//   instance.fields.m_sortNeeded = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06000631 RID: 1585 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x000025D0 File Offset: 0x000007D0
		public static float interpolateTimeFactor
		{
			get
			{
				// // Single get_interpolateTimeFactor()
				// float HG::Rendering::Runtime::HGEnvironmentManager::get_interpolateTimeFactor(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   HGEnvironmentManager *instance; // rax
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				// 
				//   if ( !byte_18D919D7B )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D919D7B = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v1);
				//   instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//   if ( !instance )
				//     sub_180B536AC(v4, v3);
				//   return instance.fields.m_interpolateTimeFactor;
				// }
				// 
				return 0f;
			}
			set
			{
				// // Void set_interpolateTimeFactor(Single)
				// void HG::Rendering::Runtime::HGEnvironmentManager::set_interpolateTimeFactor(float value, MethodInfo *method)
				// {
				//   HGEnvironmentManager *instance; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( !byte_18D8EDC62 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
				//     byte_18D8EDC62 = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, method);
				//   instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
				//   if ( !instance )
				//     sub_180B536AC(v5, v4);
				//   instance.fields.m_interpolateTimeFactor = value;
				// }
				// 
			}
		}

		public HGEnvironmentManager()
		{
			// // HGEnvironmentManager()
			// void HG::Rendering::Runtime::HGEnvironmentManager::HGEnvironmentManager(HGEnvironmentManager *this, MethodInfo *method)
			// {
			//   HGAtmosphereRenderer *v3; // rax
			//   OneofDescriptorProto *v4; // rdx
			//   HGEnvironmentPhase *m_defaultPhase; // rcx
			//   FileDescriptor *v6; // r8
			//   MessageDescriptor *v7; // r9
			//   HGVolumetricFogRenderer *v8; // rax
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   HGSkyRenderer *v11; // rax
			//   HGSkyRenderer *v12; // rdi
			//   OneofDescriptorProto *v13; // rdx
			//   FileDescriptor *v14; // r8
			//   MessageDescriptor *v15; // r9
			//   HGSkydomeStarRenderer *v16; // rax
			//   HGSkydomeStarRenderer *v17; // rdi
			//   OneofDescriptorProto *v18; // rdx
			//   FileDescriptor *v19; // r8
			//   MessageDescriptor *v20; // r9
			//   HGRainRenderer *v21; // rax
			//   HGRainRenderer *v22; // rdi
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   MessageDescriptor *v25; // r9
			//   HGSnowRenderer *v26; // rax
			//   HGSnowRenderer *v27; // rdi
			//   OneofDescriptorProto *v28; // rdx
			//   FileDescriptor *v29; // r8
			//   MessageDescriptor *v30; // r9
			//   HashSet_1_System_Object_ *v31; // rax
			//   HashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *v32; // rdi
			//   OneofDescriptorProto *v33; // rdx
			//   FileDescriptor *v34; // r8
			//   MessageDescriptor *v35; // r9
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v36; // rax
			//   List_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *v37; // rdi
			//   OneofDescriptorProto *v38; // rdx
			//   FileDescriptor *v39; // r8
			//   MessageDescriptor *v40; // r9
			//   IndexedHashSet_1_System_Object_ *v41; // rax
			//   IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *v42; // rdi
			//   OneofDescriptorProto *v43; // rdx
			//   FileDescriptor *v44; // r8
			//   MessageDescriptor *v45; // r9
			//   LowLevelList_1_System_Object_ *v46; // rax
			//   List_1_System_Single_ *v47; // rdi
			//   OneofDescriptorProto *v48; // rdx
			//   FileDescriptor *v49; // r8
			//   MessageDescriptor *v50; // r9
			//   OneofDescriptorProto *v51; // rdx
			//   FileDescriptor *v52; // r8
			//   MessageDescriptor *v53; // r9
			//   OneofDescriptorProto *v54; // rdx
			//   FileDescriptor *v55; // r8
			//   MessageDescriptor *v56; // r9
			//   __int64 v57; // rax
			//   float v58; // ecx
			//   String__Array *v59; // [rsp+20h] [rbp-18h] BYREF
			//   String *v60; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v61; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8EDC58 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::HashSet);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolume>);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::IndexedHashSet);
			//     sub_18003C530(&TypeInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<float>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>);
			//     sub_18003C530(&MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>);
			//     byte_18D8EDC58 = 1;
			//   }
			//   v3 = (HGAtmosphereRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
			//   if ( !v3 )
			//     goto LABEL_4;
			//   this.fields.m_atmosphereRenderer = v3;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_atmosphereRenderer, v4, v6, v7, v59, v60, v61);
			//   v8 = (HGVolumetricFogRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//   if ( !v8 )
			//     goto LABEL_4;
			//   this.fields.m_volumetricFogRenderer = v8;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_volumetricFogRenderer, v4, v9, v10, v59, v60, v61);
			//   v11 = (HGSkyRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
			//   v12 = v11;
			//   if ( !v11 )
			//     goto LABEL_4;
			//   HG::Rendering::Runtime::HGSkyRenderer::HGSkyRenderer(v11, 0LL);
			//   this.fields.m_skyRenderer = v12;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_skyRenderer, v13, v14, v15, v59, v60, v61);
			//   v16 = (HGSkydomeStarRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer);
			//   v17 = v16;
			//   if ( !v16 )
			//     goto LABEL_4;
			//   HG::Rendering::Runtime::HGSkydomeStarRenderer::HGSkydomeStarRenderer(v16, 0LL);
			//   this.fields.m_talosStarRenderer = v17;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_talosStarRenderer, v18, v19, v20, v59, v60, v61);
			//   v21 = (HGRainRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//   v22 = v21;
			//   if ( !v21 )
			//     goto LABEL_4;
			//   HG::Rendering::Runtime::HGRainRenderer::HGRainRenderer(v21, 0LL);
			//   this.fields.m_rainRenderer = v22;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_rainRenderer, v23, v24, v25, v59, v60, v61);
			//   v26 = (HGSnowRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
			//   v27 = v26;
			//   if ( !v26 )
			//     goto LABEL_4;
			//   HG::Rendering::Runtime::HGSnowRenderer::HGSnowRenderer(v26, 0LL);
			//   this.fields.m_snowRenderer = v27;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_snowRenderer, v28, v29, v30, v59, v60, v61);
			//   v31 = (HashSet_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolume>);
			//   v32 = (HashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *)v31;
			//   if ( !v31 )
			//     goto LABEL_4;
			//   System::Collections::Generic::HashSet<System::Object>::HashSet(
			//     v31,
			//     MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::HashSet);
			//   this.fields.m_activeVolumes = v32;
			//   sub_1800054D0((OneofDescriptor *)&this.fields, v33, v34, v35, v59, v60, v61);
			//   v36 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>);
			//   v37 = (List_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *)v36;
			//   if ( !v36 )
			//     goto LABEL_4;
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v36,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::List);
			//   this.fields.m_sortedVolumes = v37;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_sortedVolumes, v38, v39, v40, v59, v60, v61);
			//   v41 = (IndexedHashSet_1_System_Object_ *)sub_180004920(TypeInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>);
			//   v42 = (IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *)v41;
			//   if ( !v41 )
			//     goto LABEL_4;
			//   Beyond::IndexedHashSet<System::Object>::IndexedHashSet(
			//     v41,
			//     MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::IndexedHashSet);
			//   this.fields.m_interpolatedVolumes = v42;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_interpolatedVolumes, v43, v44, v45, v59, v60, v61);
			//   v46 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<float>);
			//   v47 = (List_1_System_Single_ *)v46;
			//   if ( !v46
			//     || (System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//           v46,
			//           MethodInfo::System::Collections::Generic::List<float>::List),
			//         this.fields.m_interpolatedVolumesFactor = v47,
			//         sub_1800054D0((OneofDescriptor *)&this.fields.m_interpolatedVolumesFactor, v48, v49, v50, v59, v60, v61),
			//         this.fields.m_defaultPhase = (HGEnvironmentPhase *)UnityEngine::ScriptableObject::CreateInstance<System::Object>(MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>),
			//         sub_1800054D0((OneofDescriptor *)&this.fields.m_defaultPhase, v51, v52, v53, v59, v60, v61),
			//         (m_defaultPhase = this.fields.m_defaultPhase) == 0LL) )
			//   {
			// LABEL_4:
			//     sub_180B536AC(m_defaultPhase, v4);
			//   }
			//   HG::Rendering::Runtime::HGEnvironmentPhase::ActivateAllEnvConfig(m_defaultPhase, 1, 0LL);
			//   this.fields.m_interpolatedPhase = (HGEnvironmentPhase *)UnityEngine::ScriptableObject::CreateInstance<System::Object>(MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>);
			//   sub_1800054D0((OneofDescriptor *)&this.fields.m_interpolatedPhase, v54, v55, v56, v59, v60, v61);
			//   this.fields.m_sortNeeded = 0;
			//   this.fields.m_interpolateTimeFactor = 1.0;
			//   v57 = sub_18281C140(&v59);
			//   v58 = *(float *)(v57 + 8);
			//   *(_QWORD *)&this.fields.m_lastInterpolateTriggerPosition.x = *(_QWORD *)v57;
			//   this.fields.m_lastInterpolateTriggerPosition.z = v58;
			// }
			// 
		}

		public static HGEnvironmentPhase GetInterpolatedPhase(HGCamera hgCamera)
		{
			// // HGEnvironmentPhase GetInterpolatedPhase(HGCamera)
			// HGEnvironmentPhase *HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC5D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC5D = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_13;
			//   if ( wrapperArray.max_length.size <= 439 )
			//     goto LABEL_9;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			// LABEL_13:
			//     sub_180B536AC(v3, wrapperArray);
			//   if ( LODWORD(v3._0.namespaze) <= 0x1B7 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( v3[9]._0.nestedTypes )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(439, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_199(Patch, (Object *)hgCamera, 0LL);
			//     goto LABEL_13;
			//   }
			// LABEL_9:
			//   if ( !hgCamera )
			//     goto LABEL_13;
			//   m_envVolumeCameraComponent = hgCamera.fields.m_envVolumeCameraComponent;
			//   if ( !m_envVolumeCameraComponent )
			//     goto LABEL_13;
			//   if ( m_envVolumeCameraComponent.fields.m_useEnvVolumeInterpolatedPhase )
			//     return m_envVolumeCameraComponent.fields.m_interpolatedPhase;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, wrapperArray);
			//   return HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedPhase(0LL);
			// }
			// 
			return null;
		}

		public static List<float> GetInterpolatedVolumesFactor(HGCamera hgCamera)
		{
			// // List`1[System.Single] GetInterpolatedVolumesFactor(HGCamera)
			// List_1_System_Single_ *HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedVolumesFactor(
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   HGEnvironmentVolumeCameraComponent **static_fields; // rcx
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rdx
			//   HGEnvironmentVolumeCameraComponent__Class *klass; // r8
			//   int32_t v8; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGEnvironmentVolumeCameraComponent *v10; // rax
			// 
			//   if ( !byte_18D8EDC5E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC5E = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = (HGEnvironmentVolumeCameraComponent **)v3.static_fields;
			//   m_envVolumeCameraComponent = *static_fields;
			//   if ( !*static_fields )
			//     goto LABEL_19;
			//   if ( SLODWORD(m_envVolumeCameraComponent.fields.m_lastInterpolateTriggerPosition.x) > 984 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, m_envVolumeCameraComponent);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     m_envVolumeCameraComponent = (HGEnvironmentVolumeCameraComponent *)v3.static_fields;
			//     klass = m_envVolumeCameraComponent.klass;
			//     if ( !m_envVolumeCameraComponent.klass )
			//       goto LABEL_19;
			//     if ( LODWORD(klass._0.namespaze) <= 0x3D8 )
			//       goto LABEL_34;
			//     if ( klass[21]._0.gc_desc )
			//     {
			//       v8 = 984;
			//       goto LABEL_26;
			//     }
			//   }
			//   if ( !hgCamera )
			//     goto LABEL_19;
			//   m_envVolumeCameraComponent = hgCamera.fields.m_envVolumeCameraComponent;
			//   if ( !m_envVolumeCameraComponent )
			//     goto LABEL_19;
			//   if ( m_envVolumeCameraComponent.fields.m_useEnvVolumeInterpolatedPhase )
			//   {
			//     hgCamera = (HGCamera *)hgCamera.fields.m_envVolumeCameraComponent;
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       byte_18D8EDC37 = 1;
			//     }
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, m_envVolumeCameraComponent);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = (HGEnvironmentVolumeCameraComponent **)v3.static_fields;
			//     m_envVolumeCameraComponent = *static_fields;
			//     if ( !*static_fields )
			//       goto LABEL_19;
			//     if ( SLODWORD(m_envVolumeCameraComponent.fields.m_lastInterpolateTriggerPosition.x) <= 724 )
			//       return (List_1_System_Single_ *)hgCamera.fields._sceneRTSize_k__BackingField;
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, m_envVolumeCameraComponent);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = (HGEnvironmentVolumeCameraComponent **)v3.static_fields;
			//     v10 = *static_fields;
			//     if ( !*static_fields )
			//       goto LABEL_19;
			//     if ( LODWORD(v10.fields.m_lastInterpolateTriggerPosition.x) > 0x2D4 )
			//     {
			//       if ( !v10[104].klass )
			//         return (List_1_System_Single_ *)hgCamera.fields._sceneRTSize_k__BackingField;
			//       v8 = 724;
			// LABEL_26:
			//       Patch = IFix::WrappersManagerImpl::GetPatch(v8, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_277(Patch, (Object *)hgCamera, 0LL);
			// LABEL_19:
			//       sub_180B536AC(static_fields, m_envVolumeCameraComponent);
			//     }
			// LABEL_34:
			//     sub_180070270(static_fields, m_envVolumeCameraComponent);
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, m_envVolumeCameraComponent);
			//   return HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedVolumesFactor(0LL);
			// }
			// 
			return null;
		}

		public static IndexedHashSet<HGEnvironmentVolume> GetInterpolatedVolumes(HGCamera hgCamera)
		{
			// // IndexedHashSet`1[HG.Rendering.Runtime.HGEnvironmentVolume] GetInterpolatedVolumes(HGCamera)
			// IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedVolumes(
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   HGEnvironmentVolumeCameraComponent **static_fields; // rcx
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rdx
			//   HGEnvironmentVolumeCameraComponent__Class *klass; // r8
			//   int32_t v8; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGEnvironmentVolumeCameraComponent *v10; // rax
			// 
			//   if ( !byte_18D8EDC5F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC5F = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = (HGEnvironmentVolumeCameraComponent **)v3.static_fields;
			//   m_envVolumeCameraComponent = *static_fields;
			//   if ( !*static_fields )
			//     goto LABEL_19;
			//   if ( SLODWORD(m_envVolumeCameraComponent.fields.m_lastInterpolateTriggerPosition.x) > 982 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, m_envVolumeCameraComponent);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     m_envVolumeCameraComponent = (HGEnvironmentVolumeCameraComponent *)v3.static_fields;
			//     klass = m_envVolumeCameraComponent.klass;
			//     if ( !m_envVolumeCameraComponent.klass )
			//       goto LABEL_19;
			//     if ( LODWORD(klass._0.namespaze) <= 0x3D6 )
			//       goto LABEL_34;
			//     if ( klass[20].vtable.ToString.method )
			//     {
			//       v8 = 982;
			//       goto LABEL_26;
			//     }
			//   }
			//   if ( !hgCamera )
			//     goto LABEL_19;
			//   m_envVolumeCameraComponent = hgCamera.fields.m_envVolumeCameraComponent;
			//   if ( !m_envVolumeCameraComponent )
			//     goto LABEL_19;
			//   if ( m_envVolumeCameraComponent.fields.m_useEnvVolumeInterpolatedPhase )
			//   {
			//     hgCamera = (HGCamera *)hgCamera.fields.m_envVolumeCameraComponent;
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       byte_18D8EDC37 = 1;
			//     }
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, m_envVolumeCameraComponent);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = (HGEnvironmentVolumeCameraComponent **)v3.static_fields;
			//     m_envVolumeCameraComponent = *static_fields;
			//     if ( !*static_fields )
			//       goto LABEL_19;
			//     if ( SLODWORD(m_envVolumeCameraComponent.fields.m_lastInterpolateTriggerPosition.x) <= 723 )
			//       return *(IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ **)&hgCamera.fields._taauRTSizeParam_k__BackingField.z;
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, m_envVolumeCameraComponent);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = (HGEnvironmentVolumeCameraComponent **)v3.static_fields;
			//     v10 = *static_fields;
			//     if ( !*static_fields )
			//       goto LABEL_19;
			//     if ( LODWORD(v10.fields.m_lastInterpolateTriggerPosition.x) > 0x2D3 )
			//     {
			//       if ( !v10[103].fields.m_interpolatedVolumesFactor )
			//         return *(IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ **)&hgCamera.fields._taauRTSizeParam_k__BackingField.z;
			//       v8 = 723;
			// LABEL_26:
			//       Patch = IFix::WrappersManagerImpl::GetPatch(v8, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_276(Patch, (Object *)hgCamera, 0LL);
			// LABEL_19:
			//       sub_180B536AC(static_fields, m_envVolumeCameraComponent);
			//     }
			// LABEL_34:
			//     sub_180070270(static_fields, m_envVolumeCameraComponent);
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, m_envVolumeCameraComponent);
			//   return HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedVolumes(0LL);
			// }
			// 
			return null;
		}

		public static bool Register(HGEnvironmentVolume volume)
		{
			// // Boolean Register(HGEnvironmentVolume)
			// bool HG::Rendering::Runtime::HGEnvironmentManager::Register(HGEnvironmentVolume *volume, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGEnvironmentManager *instance; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC63 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC63 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1239, 0LL) )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v3);
			//     instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
			//     if ( instance )
			//       return HG::Rendering::Runtime::HGEnvironmentManager::_Register(instance, volume, 0LL);
			// LABEL_8:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1239, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)volume, 0LL);
			// }
			// 
			return default(bool);
		}

		public static bool Unregister(HGEnvironmentVolume volume)
		{
			// // Boolean Unregister(HGEnvironmentVolume)
			// bool HG::Rendering::Runtime::HGEnvironmentManager::Unregister(HGEnvironmentVolume *volume, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGEnvironmentManager *instance; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC64 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC64 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1242, 0LL) )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v3);
			//     instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
			//     if ( instance )
			//       return HG::Rendering::Runtime::HGEnvironmentManager::_Unregister(instance, volume, 0LL);
			// LABEL_8:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1242, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)volume, 0LL);
			// }
			// 
			return default(bool);
		}

		public static void PipelineUpdate(List<Camera> cameras, HGSettingParameters settingParameters)
		{
			// // Void PipelineUpdate(List`1[UnityEngine.Camera], HGSettingParameters)
			// void HG::Rendering::Runtime::HGEnvironmentManager::PipelineUpdate(
			//         List_1_UnityEngine_Camera_ *cameras,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGEnvironmentManager *instance; // rax
			//   ILFixDynamicMethodWrapper_2__Array *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC65 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC65 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, settingParameters);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_13;
			//   if ( wrapperArray.max_length.size <= 582 )
			//     goto LABEL_24;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   v9 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_13;
			//   if ( v9.max_length.size <= 0x246u )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v9[16].vector[6] )
			//   {
			// LABEL_24:
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, wrapperArray);
			//     instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
			//     if ( instance )
			//     {
			//       HG::Rendering::Runtime::HGEnvironmentManager::_PipelineUpdate(instance, cameras, settingParameters, 0LL);
			//       return;
			//     }
			// LABEL_13:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(582, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)cameras,
			//     (Object *)settingParameters,
			//     0LL);
			// }
			// 
		}

		public static Transform GetFinalTrigger(Camera camera, Transform interpolateTrigger)
		{
			// // Transform GetFinalTrigger(Camera, Transform)
			// Transform *HG::Rendering::Runtime::HGEnvironmentManager::GetFinalTrigger(
			//         Camera *camera,
			//         Transform *interpolateTrigger,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 v7; // rdx
			//   Transform *interpolateTriggerOverride; // rbx
			//   HGRenderPipeline *currentPipeline; // rax
			//   Transform *currentPlayerCenter; // rbx
			//   HGRenderPipeline *v11; // rax
			//   __int64 v13; // rdx
			//   Camera *main; // rbx
			//   __int64 (__fastcall *v15)(Camera *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC66 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC66 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, interpolateTrigger);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_58;
			//   if ( wrapperArray.max_length.size <= 721 )
			//     goto LABEL_72;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//   if ( !v5 )
			//     goto LABEL_58;
			//   if ( LODWORD(v5._0.namespaze) <= 0x2D1 )
			//     sub_180070270(v5, wrapperArray);
			//   if ( !v5[15]._0.nestedTypes )
			//   {
			// LABEL_72:
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, wrapperArray);
			//     interpolateTriggerOverride = HG::Rendering::Runtime::HGEnvironmentManager::get_interpolateTriggerOverride(0LL);
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v7);
			//     if ( !byte_18D8F4EFB )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFB = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v7);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     if ( interpolateTriggerOverride )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v7);
			//       if ( interpolateTriggerOverride.fields._._.m_CachedPtr )
			//       {
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v7);
			//         return HG::Rendering::Runtime::HGEnvironmentManager::get_interpolateTriggerOverride(0LL);
			//       }
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, v7);
			//     currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//     if ( !currentPipeline )
			//       goto LABEL_58;
			//     currentPlayerCenter = currentPipeline.fields.currentPlayerCenter;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( !byte_18D8F4EFB )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFB = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     if ( !currentPlayerCenter )
			//       goto LABEL_42;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( !currentPlayerCenter.fields._._.m_CachedPtr )
			//     {
			// LABEL_42:
			//       main = UnityEngine::Camera::get_main(0LL);
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v13);
			//       if ( !byte_18D8F4EFB )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EFB = 1;
			//       }
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v13);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( !main )
			//         return 0LL;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v13);
			//       if ( !main.fields._._._.m_CachedPtr )
			//         return 0LL;
			//       v15 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//       if ( !qword_18D8F4D40 )
			//       {
			//         v15 = (__int64 (__fastcall *)(Camera *))sub_180017470("UnityEngine.Component::get_transform()");
			//         qword_18D8F4D40 = (__int64)v15;
			//       }
			//       return (Transform *)v15(main);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, wrapperArray);
			//     v11 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//     if ( v11 )
			//       return v11.fields.currentPlayerCenter;
			// LABEL_58:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(721, 0LL);
			//   if ( !Patch )
			//     goto LABEL_58;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_275(Patch, (Object *)camera, (Object *)interpolateTrigger, 0LL);
			// }
			// 
			return null;
		}

		public static void UpdateCameraComponent(HGCamera camera)
		{
			// // Void UpdateCameraComponent(HGCamera)
			// void HG::Rendering::Runtime::HGEnvironmentManager::UpdateCameraComponent(HGCamera *camera, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Camera *v5; // rsi
			//   __int64 (__fastcall *v6)(Camera *); // rax
			//   __int64 v7; // rdx
			//   Transform *v8; // rdi
			//   Transform *FinalTrigger; // rdi
			//   HGEnvironmentManager *instance; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rax
			// 
			//   if ( !byte_18D8EDC67 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC67 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_16;
			//   if ( wrapperArray.max_length.size <= 720 )
			//     goto LABEL_30;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_16;
			//   if ( LODWORD(v3._0.namespaze) <= 0x2D0 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !v3[15]._0.methods )
			//   {
			// LABEL_30:
			//     if ( camera )
			//     {
			//       v5 = camera.fields.camera;
			//       if ( v5 )
			//       {
			//         v6 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//         if ( !qword_18D8F4D40 )
			//         {
			//           v6 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_0("UnityEngine.Component::get_transform()");
			//           if ( !v6 )
			//           {
			//             v12 = sub_1802DBBE8("UnityEngine.Component::get_transform()");
			//             sub_18000F750(v12, 0LL);
			//           }
			//           qword_18D8F4D40 = (__int64)v6;
			//         }
			//         v8 = (Transform *)v6(v5);
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v7);
			//         FinalTrigger = HG::Rendering::Runtime::HGEnvironmentManager::GetFinalTrigger(v5, v8, 0LL);
			//         instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
			//         if ( instance )
			//         {
			//           HG::Rendering::Runtime::HGEnvironmentManager::_UpdateCameraComponent(instance, camera, FinalTrigger, 0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(720, 0LL);
			//   if ( !Patch )
			//     goto LABEL_16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)camera, 0LL);
			// }
			// 
		}

		public static void PerCameraUpdate(HGCamera camera, ref ScriptableRenderContext renderContext)
		{
			// // Void PerCameraUpdate(HGCamera, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::HGEnvironmentManager::PerCameraUpdate(
			//         HGCamera *camera,
			//         ScriptableRenderContext *renderContext,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *static_fields; // rcx
			//   _DWORD *wrapperArray; // rdx
			//   Object *instance; // rdi
			//   struct ILFixDynamicMethodWrapper_2__Class *v8; // rax
			//   HGAdditionalCameraData *m_AdditionalCameraData; // rax
			//   HGRainRenderer *s_rainRenderer; // rax
			//   HGSnowRenderer *s_snowRenderer; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // r8
			//   ILFixDynamicMethodWrapper_2 *v14; // rax
			//   const Il2CppImage *image; // rax
			//   ILFixDynamicMethodWrapper_2 *v16; // rax
			// 
			//   if ( !byte_18D8EDC68 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC68 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, renderContext);
			//     static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = static_fields.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_36;
			//   if ( (int)wrapperArray[6] > 725 )
			//   {
			//     if ( !static_fields._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(static_fields, wrapperArray);
			//       static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = static_fields.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_36;
			//     if ( wrapperArray[6] <= 0x2D5u )
			//       goto LABEL_59;
			//     if ( *((_QWORD *)wrapperArray + 729) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(725, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_288(Patch, (Object *)camera, renderContext, 0LL);
			//         return;
			//       }
			//       goto LABEL_36;
			//     }
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, wrapperArray);
			//   instance = (Object *)HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
			//   if ( !instance )
			//     goto LABEL_36;
			//   if ( !byte_18D8EDC6D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC6D = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v8.static_fields;
			//   wrapperArray = static_fields._0.image;
			//   if ( !static_fields._0.image )
			//     goto LABEL_36;
			//   if ( (int)wrapperArray[6] > 726 )
			//   {
			//     if ( !v8._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v8, wrapperArray);
			//       v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v8.static_fields;
			//     v13 = *(_QWORD *)wrapperArray;
			//     if ( !*(_QWORD *)wrapperArray )
			//       goto LABEL_36;
			//     if ( *(_DWORD *)(v13 + 24) <= 0x2D6u )
			//       goto LABEL_59;
			//     if ( *(_QWORD *)(v13 + 5840) )
			//     {
			//       v14 = IFix::WrappersManagerImpl::GetPatch(726, 0LL);
			//       if ( v14 )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_285(v14, instance, (Object *)camera, renderContext, 0LL);
			//         return;
			//       }
			//       goto LABEL_36;
			//     }
			//   }
			//   if ( !camera )
			//     goto LABEL_36;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !v8._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v8, wrapperArray);
			//     v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v8.static_fields;
			//   wrapperArray = static_fields._0.image;
			//   if ( !static_fields._0.image )
			//     goto LABEL_36;
			//   if ( (int)wrapperArray[6] <= 727 )
			//     goto LABEL_27;
			//   if ( !v8._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v8, wrapperArray);
			//     v8 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = (struct ILFixDynamicMethodWrapper_2__Class *)v8.static_fields;
			//   image = static_fields._0.image;
			//   if ( !static_fields._0.image )
			//     goto LABEL_36;
			//   if ( image.typeCount <= 0x2D7 )
			// LABEL_59:
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( image[81].assembly )
			//   {
			//     v16 = IFix::WrappersManagerImpl::GetPatch(727, 0LL);
			//     if ( !v16 )
			//       goto LABEL_36;
			//     if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v16, (Object *)camera, 0LL) )
			//       goto LABEL_30;
			//     return;
			//   }
			// LABEL_27:
			//   m_AdditionalCameraData = camera.fields.m_AdditionalCameraData;
			//   if ( !m_AdditionalCameraData )
			//     goto LABEL_36;
			//   if ( m_AdditionalCameraData.fields.hgRenderPath != 1 && m_AdditionalCameraData.fields.hgRenderPath != 2 )
			//   {
			// LABEL_30:
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, wrapperArray);
			//     s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
			//     if ( s_rainRenderer )
			//     {
			//       HG::Rendering::Runtime::HGRainRenderer::UpdateRainAndWetnessData(s_rainRenderer, camera, renderContext, 0LL);
			//       s_snowRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(0LL);
			//       if ( s_snowRenderer )
			//       {
			//         HG::Rendering::Runtime::HGSnowRenderer::UpdateSnowData(s_snowRenderer, camera, renderContext, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_36:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			// }
			// 
		}

		private bool _Register(HGEnvironmentVolume volume)
		{
			// // Boolean _Register(HGEnvironmentVolume)
			// bool HG::Rendering::Runtime::HGEnvironmentManager::_Register(
			//         HGEnvironmentManager *this,
			//         HGEnvironmentVolume *volume,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HashSet_1_System_Object_ *m_activeVolumes; // rcx
			//   int32_t i; // edi
			//   List_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *m_sortedVolumes; // rax
			//   List_1_System_Object_ *v9; // rcx
			//   Object *Item; // rax
			//   Object_1 *gameObject; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC69 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::Insert);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::get_Item);
			//     sub_18003C530(&off_18C9B5590);
			//     byte_18D8EDC69 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1240, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1240, 0LL);
			//     if ( !Patch )
			//       goto LABEL_15;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//              (ILFixDynamicMethodWrapper_36 *)Patch,
			//              (Object *)this,
			//              (Object *)volume,
			//              0LL);
			//   }
			//   else
			//   {
			//     m_activeVolumes = (HashSet_1_System_Object_ *)this.fields.m_activeVolumes;
			//     if ( !m_activeVolumes )
			//       goto LABEL_15;
			//     if ( System::Collections::Generic::HashSet<System::Object>::Contains(
			//            m_activeVolumes,
			//            (Object *)volume,
			//            MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Contains) )
			//     {
			//       if ( !volume )
			//         goto LABEL_15;
			//       gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)volume, 0LL);
			//       HG::Rendering::HGRPLogger::LogWarning(
			//         gameObject,
			//         (String *)"Env Volume already exist in activeVolumes, register failed",
			//         0LL);
			//       return 0;
			//     }
			//     else
			//     {
			//       m_activeVolumes = (HashSet_1_System_Object_ *)this.fields.m_activeVolumes;
			//       if ( !m_activeVolumes )
			//         goto LABEL_15;
			//       System::Collections::Generic::HashSet<System::Object>::Add(
			//         m_activeVolumes,
			//         (Object *)volume,
			//         MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Add);
			//       for ( i = 0; ; ++i )
			//       {
			//         m_sortedVolumes = this.fields.m_sortedVolumes;
			//         if ( !m_sortedVolumes )
			//           goto LABEL_15;
			//         v9 = (List_1_System_Object_ *)this.fields.m_sortedVolumes;
			//         if ( i >= m_sortedVolumes.fields._size )
			//           break;
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  v9,
			//                  i,
			//                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::get_Item);
			//         if ( !volume )
			//           goto LABEL_15;
			//         if ( HG::Rendering::Runtime::HGEnvironmentVolume::CompareTo(volume, (HGEnvironmentVolume *)Item, 0LL) == -1 )
			//         {
			//           m_activeVolumes = (HashSet_1_System_Object_ *)this.fields.m_sortedVolumes;
			//           if ( m_activeVolumes )
			//           {
			//             System::Collections::Generic::List<System::Object>::Insert(
			//               (List_1_System_Object_ *)m_activeVolumes,
			//               i,
			//               (Object *)volume,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::Insert);
			//             return 1;
			//           }
			// LABEL_15:
			//           sub_180B536AC(m_activeVolumes, v5);
			//         }
			//       }
			//       System::Collections::Generic::List<System::Object>::Insert(
			//         v9,
			//         m_sortedVolumes.fields._size,
			//         (Object *)volume,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::Insert);
			//       return 1;
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		private bool _Unregister(HGEnvironmentVolume volume)
		{
			// // Boolean _Unregister(HGEnvironmentVolume)
			// bool HG::Rendering::Runtime::HGEnvironmentManager::_Unregister(
			//         HGEnvironmentManager *this,
			//         HGEnvironmentVolume *volume,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HashSet_1_System_Object_ *m_activeVolumes; // rcx
			//   bool v7; // al
			//   Object_1 *gameObject; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC6A )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::Remove);
			//     sub_18003C530(&off_18C9B55A8);
			//     byte_18D8EDC6A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1243, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1243, 0LL);
			//     if ( !Patch )
			//       goto LABEL_11;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//              (ILFixDynamicMethodWrapper_36 *)Patch,
			//              (Object *)this,
			//              (Object *)volume,
			//              0LL);
			//   }
			//   else
			//   {
			//     m_activeVolumes = (HashSet_1_System_Object_ *)this.fields.m_activeVolumes;
			//     if ( !m_activeVolumes )
			//       goto LABEL_11;
			//     v7 = System::Collections::Generic::HashSet<System::Object>::Contains(
			//            m_activeVolumes,
			//            (Object *)volume,
			//            MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Contains);
			//     if ( !volume )
			//       goto LABEL_11;
			//     if ( v7 )
			//     {
			//       m_activeVolumes = (HashSet_1_System_Object_ *)volume.fields.dataPerCameras;
			//       volume.fields._timeFadingFactor_k__BackingField = 0.0;
			//       if ( m_activeVolumes )
			//       {
			//         System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Clear(
			//           (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)m_activeVolumes,
			//           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Clear);
			//         m_activeVolumes = (HashSet_1_System_Object_ *)this.fields.m_activeVolumes;
			//         if ( m_activeVolumes )
			//         {
			//           System::Collections::Generic::HashSet<System::Object>::Remove(
			//             m_activeVolumes,
			//             (Object *)volume,
			//             MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Remove);
			//           m_activeVolumes = (HashSet_1_System_Object_ *)this.fields.m_sortedVolumes;
			//           if ( m_activeVolumes )
			//           {
			//             System::Collections::Generic::List<System::Object>::Remove(
			//               (List_1_System_Object_ *)m_activeVolumes,
			//               (Object *)volume,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::Remove);
			//             return 1;
			//           }
			//         }
			//       }
			// LABEL_11:
			//       sub_180B536AC(m_activeVolumes, v5);
			//     }
			//     gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)volume, 0LL);
			//     HG::Rendering::HGRPLogger::LogWarning(
			//       gameObject,
			//       (String *)"Env Volume not exist in activeVolumes, unregister failed",
			//       0LL);
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		private void _PipelineUpdate(List<Camera> cameras, HGSettingParameters settingParameters)
		{
			// // Void _PipelineUpdate(List`1[UnityEngine.Camera], HGSettingParameters)
			// // Hidden C++ exception states: #wind=1 #try_helpers=1
			// void HG::Rendering::Runtime::HGEnvironmentManager::_PipelineUpdate(
			//         HGEnvironmentManager *this,
			//         List_1_UnityEngine_Camera_ *cameras,
			//         HGSettingParameters *settingParameters,
			//         MethodInfo *method)
			// {
			//   Object *v4; // r12
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v9; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   List_1_System_Object_ *m_sortedVolumes; // rdi
			//   struct HGEnvironmentManager_c__Class *v14; // rcx
			//   Comparison_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *_9__61_0; // rbx
			//   Object *v16; // r14
			//   Comparison_1_Object_ *v17; // rax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   OneofDescriptorProto *v20; // rdx
			//   FileDescriptor *v21; // r8
			//   MessageDescriptor *v22; // r9
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   MessageDescriptor *v25; // r9
			//   unsigned __int64 v26; // rdx
			//   Light *SunSourceLight; // rbx
			//   void *z_low; // rcx
			//   HGEnvironmentPhase *m_interpolatedPhase; // rdi
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   HGEnvironmentPhase *v32; // rdi
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   HGEnvironmentPhase *v35; // rdi
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   HGEnvironmentPhase *v38; // rdi
			//   __int64 (__fastcall *v39)(Light *); // rax
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   __int64 v42; // rdi
			//   __int64 (__fastcall *v43)(__int64); // rax
			//   __int64 v44; // rax
			//   __int64 v45; // rdx
			//   __int64 v46; // rcx
			//   __int64 v47; // r14
			//   HGEnvironmentPhase *v48; // rdi
			//   void (__fastcall *v49)(__int64, OneofDescriptorProto **); // rax
			//   __int64 (__fastcall *v50)(Light *); // rax
			//   GameObject *v51; // rax
			//   __int64 v52; // rdx
			//   __int64 v53; // rcx
			//   FileDescriptor *v54; // r8
			//   MessageDescriptor *v55; // r9
			//   Object *v56; // r14
			//   void (__fastcall __noreturn **v57)(); // rbx
			//   __int64 v58; // rdx
			//   __int64 v59; // r8
			//   signed __int64 v60; // r9
			//   Camera *fields; // rdi
			//   HGCamera *v62; // rax
			//   __int64 v63; // rcx
			//   HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rax
			//   HGEnvironmentPhase *v65; // rcx
			//   __int64 v66; // r15
			//   __int64 v67; // rax
			//   unsigned int v68; // eax
			//   unsigned int v69; // edx
			//   __int64 v70; // rax
			//   unsigned __int64 v71; // rdx
			//   signed __int64 v72; // rtt
			//   __int64 v73; // r15
			//   __int64 v74; // rax
			//   __int64 v75; // r15
			//   _QWORD **v76; // rcx
			//   __int64 v77; // r8
			//   __int64 v78; // rax
			//   __int64 v79; // rdx
			//   __int64 v80; // r15
			//   unsigned int v81; // eax
			//   __int64 v82; // rax
			//   signed __int64 v83; // rtt
			//   __int64 v84; // rdi
			//   __int64 v85; // rax
			//   __int64 v86; // rdi
			//   _QWORD **v87; // rcx
			//   __int64 v88; // rcx
			//   __int64 v89; // rax
			//   unsigned __int8 (__fastcall *v90)(Object *); // rax
			//   void (__fastcall *v91)(Object *, _QWORD); // rax
			//   HGEnvironmentPhase *v92; // rax
			//   HGEnvironmentPhase *v93; // rax
			//   HGEnvironmentPhase *v94; // rax
			//   HGEnvironmentPhase *v95; // rax
			//   HGEnvironmentPhase *v96; // rax
			//   HGEnvironmentPhase *v97; // rax
			//   HGEnvironmentPhase *v98; // rax
			//   HGEnvironmentPhase *v99; // rax
			//   HGEnvironmentPhase *v100; // rax
			//   HGEnvironmentPhase *v101; // rax
			//   Vector3 *v102; // rax
			//   HGEnvironmentPhase *v103; // rax
			//   __int128 v104; // xmm6
			//   __int128 v105; // xmm7
			//   __int128 v106; // xmm8
			//   __int128 v107; // xmm9
			//   __int128 v108; // xmm10
			//   __int128 v109; // xmm11
			//   __int64 v110; // xmm12_8
			//   float shb8; // ebx
			//   void (__fastcall *v112)(_QWORD); // rax
			//   void (__fastcall *v113)(_QWORD); // rax
			//   void (__fastcall *v114)(__int64); // rax
			//   void (__fastcall *v115)(_OWORD *); // rax
			//   void (__fastcall *v116)(__int64); // rax
			//   __int64 v117; // rdx
			//   HGRainRenderer *s_rainRenderer; // rax
			//   HGSnowRenderer *s_snowRenderer; // rax
			//   __int64 v120; // rax
			//   __int64 v121; // rax
			//   __int64 v122; // rax
			//   __int64 v123; // rax
			//   __int64 v124; // rax
			//   __int64 v125; // rax
			//   __int64 v126; // rax
			//   __int64 v127; // rax
			//   __int64 v128; // rax
			//   __int64 v129; // rax
			//   __int64 v130; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-198h]
			//   MethodInfo *methodb; // [rsp+20h] [rbp-198h]
			//   String *v133; // [rsp+28h] [rbp-190h]
			//   String *v134; // [rsp+28h] [rbp-190h]
			//   MethodInfo *v135; // [rsp+30h] [rbp-188h]
			//   MethodInfo *v136; // [rsp+30h] [rbp-188h]
			//   unsigned __int8 v137; // [rsp+30h] [rbp-188h]
			//   Vector3 v138; // [rsp+40h] [rbp-178h] BYREF
			//   Color directColor; // [rsp+50h] [rbp-168h] BYREF
			//   OneofDescriptor v140; // [rsp+60h] [rbp-158h] BYREF
			//   _OWORD v141[6]; // [rsp+B0h] [rbp-108h] BYREF
			//   __int64 v142; // [rsp+110h] [rbp-A8h]
			//   float v143; // [rsp+118h] [rbp-A0h]
			// 
			//   v4 = (Object *)settingParameters;
			//   if ( !byte_18D8EDC6B )
			//   {
			//     sub_18003C530(&TypeInfo::System::Comparison<HG::Rendering::Runtime::HGEnvironmentVolume>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::get_Current);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::Rendering::LensFlareComponentSRP>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Camera>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::Sort);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c::__PipelineUpdate_b__61_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c);
			//     byte_18D8EDC6B = 1;
			//   }
			//   memset(&v140.fields._._File_k__BackingField, 0, 24);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, cameras);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v7, cameras);
			//   if ( wrapperArray.max_length.size > 583 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, cameras);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v9 = v7.static_fields.wrapperArray;
			//     if ( !v9 )
			//       sub_180B536AC(v7, cameras);
			//     if ( v9.max_length.size <= 0x247u )
			//       sub_180070270(v7, cameras);
			//     if ( v9[16].vector[7] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(583, 0LL);
			//       if ( !Patch )
			//         sub_180B536AC(v12, v11);
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//         (ILFixDynamicMethodWrapper_28 *)Patch,
			//         (Object *)this,
			//         (Object *)cameras,
			//         v4,
			//         0LL);
			//       return;
			//     }
			//   }
			//   if ( this.fields.m_sortNeeded )
			//   {
			//     m_sortedVolumes = (List_1_System_Object_ *)this.fields.m_sortedVolumes;
			//     v14 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c, cameras);
			//       v14 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c;
			//     }
			//     _9__61_0 = v14.static_fields.__9__61_0;
			//     if ( !_9__61_0 )
			//     {
			//       if ( !v14._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(v14, cameras);
			//         v14 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c;
			//       }
			//       v16 = (Object *)v14.static_fields.__9;
			//       v17 = (Comparison_1_Object_ *)sub_180004920(TypeInfo::System::Comparison<HG::Rendering::Runtime::HGEnvironmentVolume>);
			//       _9__61_0 = (Comparison_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *)v17;
			//       if ( !v17 )
			//         sub_180B536AC(v19, v18);
			//       System::Comparison<System::Object>::Comparison(
			//         v17,
			//         v16,
			//         MethodInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c::__PipelineUpdate_b__61_0,
			//         0LL);
			//       TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c.static_fields.__9__61_0 = _9__61_0;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c.static_fields.__9__61_0,
			//         v20,
			//         v21,
			//         v22,
			//         (String__Array *)methoda,
			//         v133,
			//         v135);
			//     }
			//     if ( !m_sortedVolumes )
			//       sub_180B536AC(v14, cameras);
			//     System::Collections::Generic::List<System::Object>::Sort(
			//       m_sortedVolumes,
			//       (Comparison_1_Object_ *)_9__61_0,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::Sort);
			//     this.fields.m_sortNeeded = 0;
			//   }
			//   if ( !this.fields.m_interpolatedPhase )
			//     sub_180B536AC(v7, cameras);
			//   HG::Rendering::Runtime::HGEnvironmentPhase::CopyFrom(
			//     this.fields.m_interpolatedPhase,
			//     this.fields.m_defaultPhase,
			//     0LL);
			//   this.fields.m_interpolateTrigger = HG::Rendering::Runtime::HGEnvironmentManager::_GetInterpolateTrigger(this, 0LL);
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.m_interpolateTrigger,
			//     v23,
			//     v24,
			//     v25,
			//     (String__Array *)methoda,
			//     v133,
			//     v135);
			//   HG::Rendering::Runtime::HGEnvironmentManager::_InterpolateVolumes(this, this.fields.m_interpolateTrigger, 0LL);
			//   SunSourceLight = UnityEngine::Light::GetSunSourceLight(0LL);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   z_low = TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( SunSourceLight )
			//   {
			//     z_low = TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//     if ( SunSourceLight.fields._._._.m_CachedPtr )
			//     {
			//       m_interpolatedPhase = this.fields.m_interpolatedPhase;
			//       if ( !m_interpolatedPhase )
			//         sub_180B536AC(z_low, v26);
			//       directColor = m_interpolatedPhase.fields.lightConfig.directColor;
			//       HG::Rendering::Runtime::HGEnvironmentUtils::SetColorIfNecessary(SunSourceLight, &directColor, 0LL);
			//       v32 = this.fields.m_interpolatedPhase;
			//       if ( !v32 )
			//         sub_180B536AC(v31, v30);
			//       HG::Rendering::Runtime::HGEnvironmentUtils::SetIntensityIfNecessary(
			//         SunSourceLight,
			//         v32.fields.lightConfig.directIntensityDividePi,
			//         0LL);
			//       v35 = this.fields.m_interpolatedPhase;
			//       if ( !v35 )
			//         sub_180B536AC(v34, v33);
			//       HG::Rendering::Runtime::HGEnvironmentUtils::SetSpecularIntensityIfNecessary(
			//         SunSourceLight,
			//         v35.fields.lightConfig.directSpecularIntensity,
			//         0LL);
			//       v38 = this.fields.m_interpolatedPhase;
			//       if ( !v38 )
			//         sub_180B536AC(v37, v36);
			//       HG::Rendering::Runtime::HGEnvironmentUtils::SetSoftSourceRaidiusIfNecessary(
			//         SunSourceLight,
			//         v38.fields.lightConfig.directSoftSourceRadius,
			//         0LL);
			//       v39 = (__int64 (__fastcall *)(Light *))qword_18D8F4D48;
			//       if ( !qword_18D8F4D48 )
			//       {
			//         v39 = (__int64 (__fastcall *)(Light *))il2cpp_resolve_icall_0("UnityEngine.Component::get_gameObject()");
			//         if ( !v39 )
			//         {
			//           v120 = sub_1802DBBE8("UnityEngine.Component::get_gameObject()");
			//           sub_18000F750(v120, 0LL);
			//         }
			//         qword_18D8F4D48 = (__int64)v39;
			//       }
			//       v42 = v39(SunSourceLight);
			//       if ( !v42 )
			//         sub_180B536AC(v41, v40);
			//       v43 = (__int64 (__fastcall *)(__int64))qword_18D8F4DC8;
			//       if ( !qword_18D8F4DC8 )
			//       {
			//         v43 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_0("UnityEngine.GameObject::get_transform()");
			//         if ( !v43 )
			//         {
			//           v121 = sub_1802DBBE8("UnityEngine.GameObject::get_transform()");
			//           sub_18000F750(v121, 0LL);
			//         }
			//         qword_18D8F4DC8 = (__int64)v43;
			//       }
			//       v44 = v43(v42);
			//       v47 = v44;
			//       v48 = this.fields.m_interpolatedPhase;
			//       if ( !v48 )
			//         sub_180B536AC(v46, v45);
			//       if ( !v44 )
			//         sub_180B536AC(v46, v45);
			//       *(Quaternion *)&v140.fields._Proto_k__BackingField = v48.fields.lightConfig.rotationDirect;
			//       v49 = (void (__fastcall *)(__int64, OneofDescriptorProto **))qword_18D8F5308;
			//       if ( !qword_18D8F5308 )
			//       {
			//         v49 = (void (__fastcall *)(__int64, OneofDescriptorProto **))il2cpp_resolve_icall_0(
			//                                                                        "UnityEngine.Transform::set_rotation_Injected(Unit"
			//                                                                        "yEngine.Quaternion&)");
			//         if ( !v49 )
			//         {
			//           v122 = sub_1802DBBE8("UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)");
			//           sub_18000F750(v122, 0LL);
			//         }
			//         qword_18D8F5308 = (__int64)v49;
			//       }
			//       v49(v47, &v140.fields._Proto_k__BackingField);
			//       v50 = (__int64 (__fastcall *)(Light *))qword_18D8F4D48;
			//       if ( !qword_18D8F4D48 )
			//       {
			//         v50 = (__int64 (__fastcall *)(Light *))il2cpp_resolve_icall_0("UnityEngine.Component::get_gameObject()");
			//         if ( !v50 )
			//         {
			//           v123 = sub_1802DBBE8("UnityEngine.Component::get_gameObject()");
			//           sub_18000F750(v123, 0LL);
			//         }
			//         qword_18D8F4D48 = (__int64)v50;
			//       }
			//       v51 = (GameObject *)v50(SunSourceLight);
			//       if ( !v51 )
			//         sub_180B536AC(v53, v52);
			//       v56 = UnityEngine::GameObject::GetComponent<System::Object>(
			//               v51,
			//               MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::Rendering::LensFlareComponentSRP>);
			//       *(_QWORD *)&v138.x = v56;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//       if ( !byte_18D8F4EAE )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAE = 1;
			//       }
			//       z_low = TypeInfo::UnityEngine::Object;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( v56 )
			//       {
			//         z_low = TypeInfo::UnityEngine::Object;
			//         if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//           il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v26);
			//         if ( v56[1].klass )
			//         {
			//           LOBYTE(v136) = 0;
			//           if ( !cameras )
			//             sub_180B536AC(z_low, v26);
			//           *(_OWORD *)&v140.monitor = 0LL;
			//           v140.klass = (OneofDescriptor__Class *)cameras;
			//           sub_1800054D0(&v140, (OneofDescriptorProto *)v26, v54, v55, (String__Array *)methodb, v134, v136);
			//           v57 = 0LL;
			//           LODWORD(v140.monitor) = 0;
			//           HIDWORD(v140.monitor) = cameras.fields._version;
			//           *(_QWORD *)&v140.fields._._Index_k__BackingField = 0LL;
			//           *(_OWORD *)&v140.fields._._File_k__BackingField = *(_OWORD *)&v140.klass;
			//           v140.fields.fields = 0LL;
			//           *(_QWORD *)&directColor.r = 0LL;
			//           *(_QWORD *)&directColor.b = &v140.fields._._File_k__BackingField;
			//           while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                     (List_1_T_Enumerator_System_Object_ *)&v140.fields._._File_k__BackingField,
			//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::MoveNext) )
			//           {
			//             fields = (Camera *)v140.fields.fields;
			//             if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v58);
			//             v62 = HG::Rendering::Runtime::HGCamera::GetOrCreate(fields, 0, 0LL);
			//             if ( !v62 )
			//               sub_1802DC2C8(v63, v58);
			//             m_envVolumeCameraComponent = v62.fields.m_envVolumeCameraComponent;
			//             if ( !m_envVolumeCameraComponent )
			//               sub_1802DC2C8(v63, v58);
			//             v65 = m_envVolumeCameraComponent.fields.m_interpolatedPhase;
			//             if ( !v65 )
			//               sub_1802DC2C8(0LL, v58);
			//             if ( v65.fields.lensFlareConfig.enable )
			//             {
			//               v137 = 1;
			//               break;
			//             }
			//           }
			//           if ( !byte_18D8EDC37 )
			//           {
			//             v58 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
			//             if ( (v58 & 1) != 0 )
			//             {
			//               v66 = ((unsigned int)v58 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v58 >> 29 )
			//               {
			//                 case 1u:
			//                   v67 = sub_18003C670((unsigned int)v66);
			//                   goto LABEL_85;
			//                 case 2u:
			//                   v67 = sub_18003C380((unsigned int)v66);
			//                   goto LABEL_85;
			//                 case 3u:
			//                 case 6u:
			//                   v68 = ((unsigned int)v58 >> 1) & 0xFFFFFFF;
			//                   v69 = (unsigned int)v58 >> 29;
			//                   if ( v69 )
			//                   {
			//                     if ( v69 == 3 )
			//                     {
			//                       v67 = sub_180039480(v68);
			//                       goto LABEL_85;
			//                     }
			//                     if ( v69 == 6 )
			//                     {
			//                       v70 = sub_1802DF9C0(v68);
			//                       v67 = sub_18005F4B0(v70, 0LL);
			// LABEL_85:
			//                       v58 = v67;
			//                       goto LABEL_112;
			//                     }
			//                     goto LABEL_95;
			//                   }
			//                   if ( !v68 || (v58 = (__int64)off_18A2C5600, v68 != 1) )
			// LABEL_95:
			//                     v58 = 0LL;
			// LABEL_112:
			//                   if ( !v58 )
			//                     goto LABEL_114;
			//                   v58 = _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, v58);
			//                   byte_18D8EDC37 = 1;
			//                   break;
			//                 case 4u:
			//                   v67 = sub_1802DF920((unsigned int)v66);
			//                   goto LABEL_85;
			//                 case 5u:
			//                   v59 = 8 * v66;
			//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v66) )
			//                   {
			//                     v58 = *(_QWORD *)(v59 + qword_18D8F6F98);
			//                   }
			//                   else
			//                   {
			//                     v60 = il2cpp_string_new_len(
			//                             qword_18D8E5198
			//                           + *(int *)(v59 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                           + *(int *)(qword_18D8E51A0 + 16),
			//                             *(unsigned int *)(v59 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//                     v58 = _InterlockedCompareExchange64(
			//                             (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v66),
			//                             v60,
			//                             0LL);
			//                     if ( !v58 )
			//                     {
			//                       if ( dword_18D8E43F8 )
			//                       {
			//                         v71 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v66) >> 12) & 0x1FFFFF) >> 6;
			//                         v59 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v66) >> 12) & 0x3F;
			//                         _m_prefetchw(&qword_18D6870D0[v71]);
			//                         do
			//                           v72 = qword_18D6870D0[v71];
			//                         while ( v72 != _InterlockedCompareExchange64(&qword_18D6870D0[v71], v72 | (1LL << v59), v72) );
			//                       }
			//                       v58 = v60;
			//                     }
			//                   }
			//                   goto LABEL_112;
			//                 case 7u:
			//                   v73 = sub_1802DF920((unsigned int)v66);
			//                   v74 = *(_QWORD *)(v73 + 16);
			//                   v75 = (v73 - *(_QWORD *)(v74 + 128)) >> 5;
			//                   if ( *(_BYTE *)(v74 + 42) == 21 )
			//                   {
			//                     v76 = *(_QWORD ***)(v74 + 96);
			//                     if ( *v76 )
			//                     {
			//                       v77 = **v76 - *(int *)(qword_18D8E51A0 + 160) - qword_18D8E5198;
			//                       v74 = sub_180039550(v77 / 92 + v77);
			//                     }
			//                     else
			//                     {
			//                       v74 = 0LL;
			//                     }
			//                   }
			//                   LODWORD(v138.x) = v75 + *(_DWORD *)(*(_QWORD *)(v74 + 104) + 32LL);
			//                   v78 = sub_1801B8ECC(
			//                           (unsigned int)&v138,
			//                           (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                           *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                           12,
			//                           (__int64)sub_1802C7760);
			//                   if ( !v78 || (v79 = *(unsigned int *)(v78 + 8), (_DWORD)v79 == -1) )
			//                     v58 = 0LL;
			//                   else
			//                     v58 = qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72) + v79;
			//                   goto LABEL_112;
			//                 default:
			//                   goto LABEL_114;
			//               }
			//             }
			//             else
			//             {
			// LABEL_114:
			//               byte_18D8EDC37 = 1;
			//             }
			//           }
			//           z_low = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v58);
			//             z_low = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           v26 = **((_QWORD **)z_low + 23);
			//           if ( !v26 )
			//             goto LABEL_230;
			//           if ( *(int *)(v26 + 24) > 609 )
			//           {
			//             if ( !*((_DWORD *)z_low + 56) )
			//             {
			//               il2cpp_runtime_class_init_0(z_low, v26);
			//               z_low = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//             }
			//             v26 = **((_QWORD **)z_low + 23);
			//             if ( !v26 )
			//               goto LABEL_230;
			//             if ( *(_DWORD *)(v26 + 24) <= 0x261u )
			//               goto LABEL_226;
			//             if ( *(_QWORD *)(v26 + 4904) )
			//             {
			//               if ( !byte_18D919D50 )
			//               {
			//                 v59 = _InterlockedExchangeAdd64(
			//                         (volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
			//                         0LL);
			//                 if ( (v59 & 1) != 0 )
			//                 {
			//                   v80 = ((unsigned int)v59 >> 1) & 0xFFFFFFF;
			//                   switch ( (unsigned int)v59 >> 29 )
			//                   {
			//                     case 1u:
			//                       v57 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v80);
			//                       goto LABEL_151;
			//                     case 2u:
			//                       v57 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v80);
			//                       goto LABEL_151;
			//                     case 3u:
			//                     case 6u:
			//                       v81 = ((unsigned int)v59 >> 1) & 0xFFFFFFF;
			//                       v59 = (unsigned int)v59 >> 29;
			//                       if ( (_DWORD)v59 )
			//                       {
			//                         if ( (_DWORD)v59 == 3 )
			//                         {
			//                           v57 = (void (__fastcall __noreturn **)())sub_180039480(v81);
			//                         }
			//                         else if ( (_DWORD)v59 == 6 )
			//                         {
			//                           v82 = sub_1802DF9C0(v81);
			//                           v57 = (void (__fastcall __noreturn **)())sub_18005F4B0(v82, 0LL);
			//                         }
			//                       }
			//                       else if ( v81 == 1 )
			//                       {
			//                         v57 = off_18A2C5600;
			//                       }
			//                       goto LABEL_151;
			//                     case 4u:
			//                       v57 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v80);
			//                       goto LABEL_151;
			//                     case 5u:
			//                       v59 = 8 * v80;
			//                       if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v80) )
			//                       {
			//                         v57 = *(void (__fastcall __noreturn ***)())(v59 + qword_18D8F6F98);
			//                       }
			//                       else
			//                       {
			//                         v60 = il2cpp_string_new_len(
			//                                 qword_18D8E5198
			//                               + *(int *)(v59 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198 + 4)
			//                               + *(int *)(qword_18D8E51A0 + 16),
			//                                 *(unsigned int *)(v59 + *(int *)(qword_18D8E51A0 + 8) + qword_18D8E5198));
			//                         v57 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                    (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v80),
			//                                                                    v60,
			//                                                                    0LL);
			//                         if ( !v57 )
			//                         {
			//                           if ( dword_18D8E43F8 )
			//                           {
			//                             v26 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v80) >> 12) & 0x1FFFFF) >> 6;
			//                             v59 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v80) >> 12) & 0x3F;
			//                             _m_prefetchw(&qword_18D6870D0[v26]);
			//                             do
			//                               v83 = qword_18D6870D0[v26];
			//                             while ( v83 != _InterlockedCompareExchange64(&qword_18D6870D0[v26], v83 | (1LL << v59), v83) );
			//                           }
			//                           v57 = (void (__fastcall __noreturn **)())v60;
			//                         }
			//                       }
			//                       goto LABEL_151;
			//                     case 7u:
			//                       v84 = sub_1802DF920((unsigned int)v80);
			//                       v85 = *(_QWORD *)(v84 + 16);
			//                       v86 = (v84 - *(_QWORD *)(v85 + 128)) >> 5;
			//                       if ( *(_BYTE *)(v85 + 42) == 21 )
			//                       {
			//                         v87 = *(_QWORD ***)(v85 + 96);
			//                         if ( *v87 )
			//                         {
			//                           v88 = **v87 - *(int *)(qword_18D8E51A0 + 160) - qword_18D8E5198;
			//                           v85 = sub_180039550(v88 / 92 + v88);
			//                         }
			//                         else
			//                         {
			//                           v85 = 0LL;
			//                         }
			//                       }
			//                       LODWORD(v138.x) = v86 + *(_DWORD *)(*(_QWORD *)(v85 + 104) + 32LL);
			//                       v89 = sub_1801B8ECC(
			//                               (unsigned int)&v138,
			//                               (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                               *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                               12,
			//                               (__int64)sub_1802C7760);
			//                       if ( v89 )
			//                       {
			//                         v26 = *(unsigned int *)(v89 + 8);
			//                         if ( (_DWORD)v26 != -1 )
			//                           v57 = (void (__fastcall __noreturn **)())(v26
			//                                                                   + qword_18D8E5198
			//                                                                   + *(int *)(qword_18D8E51A0 + 72));
			//                       }
			// LABEL_151:
			//                       if ( v57 )
			//                         _InterlockedExchange64(
			//                           (volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper,
			//                           (__int64)v57);
			//                       break;
			//                     default:
			//                       break;
			//                   }
			//                 }
			//                 byte_18D919D50 = 1;
			//                 z_low = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//               }
			//               if ( !*((_DWORD *)z_low + 56) )
			//               {
			//                 il2cpp_runtime_class_init_0(z_low, v26);
			//                 z_low = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//               }
			//               z_low = (void *)**((_QWORD **)z_low + 23);
			//               if ( !z_low )
			//                 goto LABEL_230;
			//               if ( *((_DWORD *)z_low + 6) > 0x261u )
			//               {
			//                 z_low = (void *)*((_QWORD *)z_low + 613);
			//                 if ( !z_low )
			//                   goto LABEL_230;
			//                 IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)z_low, v56, v137, 0LL);
			//                 goto LABEL_168;
			//               }
			// LABEL_226:
			//               sub_180070260(z_low, v26, v59, v60);
			//             }
			//           }
			//           v90 = (unsigned __int8 (__fastcall *)(Object *))qword_18D8F4D28;
			//           if ( !qword_18D8F4D28 )
			//           {
			//             v90 = (unsigned __int8 (__fastcall *)(Object *))il2cpp_resolve_icall_0("UnityEngine.Behaviour::get_enabled()");
			//             if ( !v90 )
			//             {
			//               v124 = sub_1802DBBE8("UnityEngine.Behaviour::get_enabled()");
			//               sub_18000F750(v124, 0LL);
			//             }
			//             qword_18D8F4D28 = (__int64)v90;
			//           }
			//           if ( v90(v56) != v137 )
			//           {
			//             v91 = (void (__fastcall *)(Object *, _QWORD))qword_18D8F4D30;
			//             if ( !qword_18D8F4D30 )
			//             {
			//               v91 = (void (__fastcall *)(Object *, _QWORD))il2cpp_resolve_icall_0("UnityEngine.Behaviour::set_enabled(System.Boolean)");
			//               if ( !v91 )
			//               {
			//                 v125 = sub_1802DBBE8("UnityEngine.Behaviour::set_enabled(System.Boolean)");
			//                 sub_18000F750(v125, 0LL);
			//               }
			//               qword_18D8F4D30 = (__int64)v91;
			//             }
			//             v91(v56, v137);
			//           }
			// LABEL_168:
			//           v92 = this.fields.m_interpolatedPhase;
			//           if ( v92 )
			//           {
			//             if ( !v92.fields.lensFlareConfig.enable )
			//             {
			// LABEL_180:
			//               v4 = (Object *)settingParameters;
			//               goto LABEL_181;
			//             }
			//             HG::Rendering::Runtime::HGEnvironmentUtils::SetLensFlareDataIfNecessary(
			//               (LensFlareComponentSRP *)v56,
			//               v92.fields.lensFlareConfig.lensFlareData,
			//               0LL);
			//             v93 = this.fields.m_interpolatedPhase;
			//             if ( v93 )
			//             {
			//               *(float *)&v56[2].klass = v93.fields.lensFlareConfig.intensity;
			//               v94 = this.fields.m_interpolatedPhase;
			//               if ( v94 )
			//               {
			//                 *(float *)&v56[6].klass = v94.fields.lensFlareConfig.scale;
			//                 v95 = this.fields.m_interpolatedPhase;
			//                 if ( v95 )
			//                 {
			//                   LOBYTE(v56[5].klass) = v95.fields.lensFlareConfig.useOcclusion;
			//                   v96 = this.fields.m_interpolatedPhase;
			//                   if ( v96 )
			//                   {
			//                     HIDWORD(v56[5].klass) = LODWORD(v96.fields.lensFlareConfig.occlusionRadius);
			//                     v97 = this.fields.m_interpolatedPhase;
			//                     if ( v97 )
			//                     {
			//                       LODWORD(v56[5].monitor) = v97.fields.lensFlareConfig.sampleCount;
			//                       v98 = this.fields.m_interpolatedPhase;
			//                       if ( v98 )
			//                       {
			//                         HIDWORD(v56[5].monitor) = LODWORD(v98.fields.lensFlareConfig.occlusionOffset);
			//                         v99 = this.fields.m_interpolatedPhase;
			//                         if ( v99 )
			//                         {
			//                           BYTE4(v56[6].klass) = v99.fields.lensFlareConfig.allowOffScreen;
			//                           v100 = this.fields.m_interpolatedPhase;
			//                           if ( v100 )
			//                           {
			//                             HIDWORD(v56[5].monitor) = LODWORD(v100.fields.lensFlareConfig.occlusionOffset);
			//                             BYTE5(v56[6].klass) = 1;
			//                             v101 = this.fields.m_interpolatedPhase;
			//                             if ( v101 )
			//                             {
			//                               *(_QWORD *)&v138.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//                               v138.z = 1.0;
			//                               *(Quaternion *)&v140.klass = v101.fields.lightConfig.rotationLensFlare;
			//                               v102 = UnityEngine::Quaternion::op_Multiply(
			//                                        (Vector3 *)&directColor,
			//                                        (Quaternion *)&v140,
			//                                        &v138,
			//                                        0LL);
			//                               z_low = (void *)LODWORD(v102.z);
			//                               v56[6].monitor = *(MonitorData **)&v102.x;
			//                               LODWORD(v56[7].klass) = (_DWORD)z_low;
			//                               goto LABEL_180;
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			// LABEL_230:
			//           sub_1802DC2C8(z_low, v26);
			//         }
			//       }
			//     }
			//   }
			// LABEL_181:
			//   v103 = this.fields.m_interpolatedPhase;
			//   if ( !v103 )
			//     goto LABEL_202;
			//   v104 = *(_OWORD *)&v103.fields.skyConfig.skyAmbientSH.shr0;
			//   v105 = *(_OWORD *)&v103.fields.skyConfig.skyAmbientSH.shr4;
			//   v106 = *(_OWORD *)&v103.fields.skyConfig.skyAmbientSH.shr8;
			//   v107 = *(_OWORD *)&v103.fields.skyConfig.skyAmbientSH.shg3;
			//   v108 = *(_OWORD *)&v103.fields.skyConfig.skyAmbientSH.shg7;
			//   v109 = *(_OWORD *)&v103.fields.skyConfig.skyAmbientSH.shb2;
			//   v110 = *(_QWORD *)&v103.fields.skyConfig.skyAmbientSH.shb6;
			//   shb8 = v103.fields.skyConfig.skyAmbientSH.shb8;
			//   v112 = (void (__fastcall *)(_QWORD))qword_18D8F4680;
			//   if ( !qword_18D8F4680 )
			//   {
			//     v112 = (void (__fastcall *)(_QWORD))il2cpp_resolve_icall_0("UnityEngine.RenderSettings::set_skybox(UnityEngine.Material)");
			//     if ( !v112 )
			//     {
			//       v126 = sub_1802DBBE8("UnityEngine.RenderSettings::set_skybox(UnityEngine.Material)");
			//       sub_18000F750(v126, 0LL);
			//     }
			//     qword_18D8F4680 = (__int64)v112;
			//   }
			//   v112(0LL);
			//   v113 = (void (__fastcall *)(_QWORD))qword_18D8F4688;
			//   if ( !qword_18D8F4688 )
			//   {
			//     v113 = (void (__fastcall *)(_QWORD))il2cpp_resolve_icall_0("UnityEngine.RenderSettings::set_sun(UnityEngine.Light)");
			//     if ( !v113 )
			//     {
			//       v127 = sub_1802DBBE8("UnityEngine.RenderSettings::set_sun(UnityEngine.Light)");
			//       sub_18000F750(v127, 0LL);
			//     }
			//     qword_18D8F4688 = (__int64)v113;
			//   }
			//   v113(0LL);
			//   v114 = (void (__fastcall *)(__int64))qword_18D8F4678;
			//   if ( !qword_18D8F4678 )
			//   {
			//     v114 = (void (__fastcall *)(__int64))il2cpp_resolve_icall_0(
			//                                            "UnityEngine.RenderSettings::set_ambientMode(UnityEngine.Rendering.AmbientMode)");
			//     if ( !v114 )
			//     {
			//       v128 = sub_1802DBBE8("UnityEngine.RenderSettings::set_ambientMode(UnityEngine.Rendering.AmbientMode)");
			//       sub_18000F750(v128, 0LL);
			//     }
			//     qword_18D8F4678 = (__int64)v114;
			//   }
			//   v114(4LL);
			//   v141[0] = v104;
			//   v141[1] = v105;
			//   v141[2] = v106;
			//   v141[3] = v107;
			//   v141[4] = v108;
			//   v141[5] = v109;
			//   v142 = v110;
			//   v143 = shb8;
			//   v115 = (void (__fastcall *)(_OWORD *))qword_18D8F4698;
			//   if ( !qword_18D8F4698 )
			//   {
			//     v115 = (void (__fastcall *)(_OWORD *))il2cpp_resolve_icall_0(
			//                                             "UnityEngine.RenderSettings::set_ambientProbe_Injected(UnityEngine.Rendering."
			//                                             "SphericalHarmonicsL2&)");
			//     if ( !v115 )
			//     {
			//       v129 = sub_1802DBBE8("UnityEngine.RenderSettings::set_ambientProbe_Injected(UnityEngine.Rendering.SphericalHarmonicsL2&)");
			//       sub_18000F750(v129, 0LL);
			//     }
			//     qword_18D8F4698 = (__int64)v115;
			//   }
			//   v115(v141);
			//   v116 = (void (__fastcall *)(__int64))qword_18D8F4690;
			//   if ( !qword_18D8F4690 )
			//   {
			//     v116 = (void (__fastcall *)(__int64))il2cpp_resolve_icall_0(
			//                                            "UnityEngine.RenderSettings::set_defaultReflectionMode(UnityEngine.Rendering.D"
			//                                            "efaultReflectionMode)");
			//     if ( !v116 )
			//     {
			//       v130 = sub_1802DBBE8("UnityEngine.RenderSettings::set_defaultReflectionMode(UnityEngine.Rendering.DefaultReflectionMode)");
			//       sub_18000F750(v130, 0LL);
			//     }
			//     qword_18D8F4690 = (__int64)v116;
			//   }
			//   v116(1LL);
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, v117);
			//   s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
			//   if ( !s_rainRenderer
			//     || (HG::Rendering::Runtime::HGRainRenderer::RainAndWetnessPipelineUpdate(
			//           s_rainRenderer,
			//           (HGSettingParameters *)v4,
			//           0LL),
			//         (s_snowRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(0LL)) == 0LL) )
			//   {
			// LABEL_202:
			//     sub_1802DC2C8(z_low, v26);
			//   }
			//   HG::Rendering::Runtime::HGSnowRenderer::SnowPipelineUpdate(s_snowRenderer, (HGSettingParameters *)v4, 0LL);
			// }
			// 
		}

		private void _UpdateCameraComponent(HGCamera hgCamera, Transform interpolateTrigger)
		{
			// // Void _UpdateCameraComponent(HGCamera, Transform)
			// // Hidden C++ exception states: #wind=3 #try_helpers=1
			// void HG::Rendering::Runtime::HGEnvironmentManager::_UpdateCameraComponent(
			//         HGEnvironmentManager *this,
			//         HGCamera *hgCamera,
			//         Transform *interpolateTrigger,
			//         MethodInfo *method)
			// {
			//   Object *v4; // r15
			//   Object *v5; // r13
			//   HGEnvironmentManager *v6; // r14
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v9; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   MessageDescriptor *klass; // rsi
			//   __int64 v14; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v15; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *v16; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v17; // rbx
			//   ILFixDynamicMethodWrapper_2 *v18; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *fieldsInDeclarationOrder; // rbx
			//   __int64 v22; // rdx
			//   struct ILFixDynamicMethodWrapper_2__Class *v23; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *v24; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v25; // rbx
			//   ILFixDynamicMethodWrapper_2 *v26; // rax
			//   __int64 v27; // rdx
			//   __int64 v28; // rcx
			//   List_1_System_Single_ *fieldsInNumberOrder; // rbx
			//   Object_1 *m_interpolateTrigger; // rbx
			//   void (__fastcall *v31)(Object *, String **); // rax
			//   MethodInfo *v32; // r9
			//   Vector3 *v33; // rax
			//   OneofDescriptorProto *v34; // rdx
			//   FileDescriptor *v35; // r8
			//   MessageDescriptor *v36; // r9
			//   unsigned int z_low; // ebx
			//   struct Math__Class *v38; // rcx
			//   __m128 v39; // xmm2
			//   __m128d v40; // xmm3
			//   double v41; // xmm0_8
			//   float v42; // xmm0_4
			//   float m_interpolateTimeFactor; // xmm8_4
			//   List_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *m_sortedVolumes; // rbx
			//   unsigned __int64 m_interpolatedVolumes; // rdx
			//   signed __int64 items; // rcx
			//   Object *current; // r15
			//   unsigned int v48; // r8d
			//   __int64 v49; // rdi
			//   void (__fastcall __noreturn **v50)(); // rax
			//   unsigned int v51; // eax
			//   unsigned int v52; // r8d
			//   __int64 v53; // rax
			//   signed __int64 v54; // r9
			//   char v55; // r8
			//   signed __int64 v56; // rtt
			//   __int64 v57; // rdi
			//   __int64 v58; // rax
			//   __int64 v59; // rdi
			//   _QWORD **v60; // rcx
			//   __int64 v61; // r8
			//   __int64 v62; // rax
			//   unsigned int v63; // r8d
			//   __int64 v64; // rdi
			//   void (__fastcall __noreturn **v65)(); // rax
			//   unsigned int v66; // eax
			//   unsigned int v67; // r8d
			//   __int64 v68; // rax
			//   signed __int64 v69; // r9
			//   char v70; // r8
			//   signed __int64 v71; // rtt
			//   __int64 v72; // rdi
			//   __int64 v73; // rax
			//   __int64 v74; // rdi
			//   _QWORD **v75; // rcx
			//   __int64 v76; // r8
			//   __int64 v77; // rax
			//   unsigned __int8 (__fastcall *v78)(Object *); // rax
			//   void (__fastcall *v79)(Transform *, OneofDescriptorProto **); // rax
			//   unsigned __int64 v80; // rdx
			//   unsigned __int64 v81; // r8
			//   signed __int64 v82; // r9
			//   OneofDescriptorProto *Proto_k__BackingField; // xmm6_8
			//   float v84; // esi
			//   __int64 v85; // rdi
			//   void (__fastcall __noreturn **v86)(); // rax
			//   unsigned int v87; // eax
			//   __int64 v88; // rax
			//   unsigned int v89; // r8d
			//   signed __int64 v90; // rtt
			//   __int64 v91; // rax
			//   struct ILFixDynamicMethodWrapper_2__Class *v92; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *v93; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v94; // rcx
			//   ILFixDynamicMethodWrapper_2 *v95; // rax
			//   __int64 v96; // rdx
			//   __int64 v97; // rcx
			//   __int64 v98; // rdx
			//   bool v99; // r14
			//   Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *monitor; // rcx
			//   __int64 v101; // rdx
			//   __int64 v102; // rcx
			//   Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *v103; // rcx
			//   Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *v104; // rsi
			//   struct MethodInfo *v105; // rdi
			//   int32_t Entry; // eax
			//   __int64 v107; // rdx
			//   __int64 v108; // r8
			//   __int64 v109; // r9
			//   Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *v110; // rcx
			//   __int64 v111; // rdx
			//   __int64 v112; // rcx
			//   Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *v113; // rsi
			//   struct MethodInfo *v114; // rdi
			//   int32_t v115; // eax
			//   __int64 v116; // rdx
			//   __int64 v117; // r8
			//   __int64 v118; // r9
			//   Dictionary_2_TKey_TValue_Entry_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera___Array *v119; // rcx
			//   float Epsilon; // xmm0_4
			//   Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v121; // rcx
			//   Dictionary_2_TKey_TValue_Entry_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera___Array *entries; // rcx
			//   float (*v123)(void); // rax
			//   __int64 v124; // rdx
			//   float v125; // xmm0_4
			//   __m128i FullName_k__BackingField_low; // xmm1
			//   float (*v127)(void); // rax
			//   float v128; // xmm0_4
			//   Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *v129; // rcx
			//   MessageDescriptor *containingType; // rsi
			//   HGEnvironmentManager *v131; // r14
			//   float z; // eax
			//   Object *v133; // rdi
			//   IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *v134; // rax
			//   __int64 v135; // rdx
			//   __int64 v136; // rcx
			//   List_1_System_Single_ *m_interpolatedVolumesFactor; // r9
			//   signed __int64 v138; // rtt
			//   __int64 v139; // rax
			//   __int64 v140; // rdx
			//   __int64 v141; // rdx
			//   float v142; // xmm6_4
			//   List_1_System_Single_ *v143; // rax
			//   __int64 v144; // rdx
			//   __int64 v145; // rcx
			//   __int64 v146; // r8
			//   List_1_System_Single_ *v147; // rbx
			//   struct MethodInfo *v148; // rdi
			//   Il2CppClass *v149; // rcx
			//   HGEnvironmentPhase *v150; // rdi
			//   IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *v151; // rbx
			//   List_1_System_Single_ *v152; // rax
			//   __int64 v153; // rax
			//   int v154; // ecx
			//   __int64 v155; // rax
			//   __int64 v156; // rax
			//   __int64 v157; // rax
			//   __int64 v158; // rax
			//   __int64 v159; // rax
			//   __int64 v160; // [rsp+0h] [rbp-188h] BYREF
			//   MethodInfo *methoda; // [rsp+20h] [rbp-168h]
			//   IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *interpolatedVolumes; // [rsp+28h] [rbp-160h]
			//   List_1_System_Single_ *interpolatedVolumesFactor; // [rsp+30h] [rbp-158h]
			//   OneofDescriptor v164; // [rsp+40h] [rbp-148h] BYREF
			//   __int128 v165; // [rsp+90h] [rbp-F8h] BYREF
			//   __int64 v166; // [rsp+A0h] [rbp-E8h]
			//   List_1_T_Enumerator_System_Object_ v167; // [rsp+A8h] [rbp-E0h] BYREF
			//   Vector3 v168; // [rsp+C0h] [rbp-C8h] BYREF
			//   Vector3 v169; // [rsp+D0h] [rbp-B8h] BYREF
			//   int v170; // [rsp+E0h] [rbp-A8h] BYREF
			//   Il2CppExceptionWrapper *v171; // [rsp+F8h] [rbp-90h] BYREF
			//   Il2CppExceptionWrapper *v172; // [rsp+100h] [rbp-88h] BYREF
			// 
			//   v4 = (Object *)interpolateTrigger;
			//   v5 = (Object *)hgCamera;
			//   v6 = this;
			//   if ( !byte_18D8EDC6C )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::set_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<float>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGEnvironmentVolume>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGEnvironmentVolume>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<float>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGEnvironmentVolume>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<float>::get_Current);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Add);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Clear);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC6C = 1;
			//   }
			//   memset(&v167, 0, sizeof(v167));
			//   v165 = 0LL;
			//   v166 = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, hgCamera);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v7, hgCamera);
			//   if ( wrapperArray.max_length.size > 722 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, hgCamera);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v9 = v7.static_fields.wrapperArray;
			//     if ( !v9 )
			//       sub_180B536AC(v7, hgCamera);
			//     if ( v9.max_length.size <= 0x2D2u )
			//       sub_180070270(v7, hgCamera);
			//     if ( v9[20].vector[2] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(722, 0LL);
			//       if ( !Patch )
			//         sub_180B536AC(v12, v11);
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)v6, v5, v4, 0LL);
			//       return;
			//     }
			//   }
			//   if ( !v5 )
			//     sub_180B536AC(v7, hgCamera);
			//   klass = (MessageDescriptor *)v5[157].klass;
			//   v164.fields.containingType = klass;
			//   if ( !klass )
			//     sub_180B536AC(v7, hgCamera);
			//   if ( !*(_QWORD *)&klass.fields._._Index_k__BackingField )
			//     sub_180B536AC(v7, hgCamera);
			//   HG::Rendering::Runtime::HGEnvironmentPhase::CopyFrom(
			//     *(HGEnvironmentPhase **)&klass.fields._._Index_k__BackingField,
			//     v6.fields.m_defaultPhase,
			//     0LL);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v15 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v14);
			//     v15 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v16 = v15.static_fields.wrapperArray;
			//   if ( !v16 )
			//     sub_180B536AC(v15, v14);
			//   if ( v16.max_length.size <= 723 )
			//     goto LABEL_32;
			//   if ( !v15._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v15, v14);
			//     v15 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v17 = v15.static_fields.wrapperArray;
			//   if ( !v17 )
			//     sub_180B536AC(v15, v14);
			//   if ( v17.max_length.size <= 0x2D3u )
			//     sub_180070270(v15, v14);
			//   if ( v17[20].vector[3] )
			//   {
			//     v18 = IFix::WrappersManagerImpl::GetPatch(723, 0LL);
			//     if ( !v18 )
			//       sub_180B536AC(v20, v19);
			//     fieldsInDeclarationOrder = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_276(v18, (Object *)klass, 0LL);
			//   }
			//   else
			//   {
			// LABEL_32:
			//     fieldsInDeclarationOrder = (IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *)klass.fields.fieldsInDeclarationOrder;
			//   }
			//   if ( !fieldsInDeclarationOrder )
			//     sub_180B536AC(v15, v14);
			//   Beyond::IndexedHashSet<System::Object>::Clear(
			//     (IndexedHashSet_1_System_Object_ *)fieldsInDeclarationOrder,
			//     MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Clear);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v23 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v22);
			//     v23 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v24 = v23.static_fields.wrapperArray;
			//   if ( !v24 )
			//     sub_180B536AC(v23, v22);
			//   if ( v24.max_length.size <= 724 )
			//     goto LABEL_47;
			//   if ( !v23._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v23, v22);
			//     v23 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v25 = v23.static_fields.wrapperArray;
			//   if ( !v25 )
			//     sub_180B536AC(v23, v22);
			//   if ( v25.max_length.size <= 0x2D4u )
			//     sub_180070270(v23, v22);
			//   if ( v25[20].vector[4] )
			//   {
			//     v26 = IFix::WrappersManagerImpl::GetPatch(724, 0LL);
			//     if ( !v26 )
			//       sub_180B536AC(v28, v27);
			//     fieldsInNumberOrder = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_277(v26, (Object *)klass, 0LL);
			//   }
			//   else
			//   {
			// LABEL_47:
			//     fieldsInNumberOrder = (List_1_System_Single_ *)klass.fields.fieldsInNumberOrder;
			//   }
			//   if ( !fieldsInNumberOrder )
			//     sub_180B536AC(v23, v22);
			//   ++fieldsInNumberOrder.fields._version;
			//   fieldsInNumberOrder.fields._size = 0;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v22);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v22);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !v4 )
			//     goto LABEL_272;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v22);
			//   if ( !v4[1].klass )
			//   {
			// LABEL_272:
			//     v153 = sub_18281C140(&v168);
			//     v154 = *(_DWORD *)(v153 + 8);
			//     klass.fields._._FullName_k__BackingField = *(String **)v153;
			//     LODWORD(klass.fields._._File_k__BackingField) = v154;
			//     return;
			//   }
			//   m_interpolateTrigger = (Object_1 *)v6.fields.m_interpolateTrigger;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v22);
			//   if ( !UnityEngine::Object::op_Equality((Object_1 *)v4, m_interpolateTrigger, 0LL) )
			//   {
			// LABEL_271:
			//     v150 = *(HGEnvironmentPhase **)&klass.fields._._Index_k__BackingField;
			//     v151 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedVolumes(
			//              (HGEnvironmentVolumeCameraComponent *)klass,
			//              0LL);
			//     v152 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedVolumesFactor(
			//              (HGEnvironmentVolumeCameraComponent *)klass,
			//              0LL);
			//     HG::Rendering::Runtime::HGEnvironmentManager::_InterpolateVolumesImpl(
			//       v6,
			//       (HGCamera *)v5,
			//       (Transform *)v4,
			//       v150,
			//       (Vector3 *)&klass.fields._._FullName_k__BackingField,
			//       v151,
			//       v152,
			//       0LL);
			//     return;
			//   }
			//   v164.fields._._FullName_k__BackingField = 0LL;
			//   LODWORD(v164.fields._._File_k__BackingField) = 0;
			//   v31 = (void (__fastcall *)(Object *, String **))qword_18D8F52E0;
			//   if ( !qword_18D8F52E0 )
			//   {
			//     v31 = (void (__fastcall *)(Object *, String **))il2cpp_resolve_icall_0(
			//                                                       "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//     if ( !v31 )
			//     {
			//       v155 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v155, 0LL);
			//     }
			//     qword_18D8F52E0 = (__int64)v31;
			//   }
			//   v31(v4, &v164.fields._._FullName_k__BackingField);
			//   v164.fields._Proto_k__BackingField = *(OneofDescriptorProto **)&v6.fields.m_lastInterpolateTriggerPosition.x;
			//   *(float *)&v164.fields._IsSynthetic_k__BackingField = v6.fields.m_lastInterpolateTriggerPosition.z;
			//   v164.fields.fields = (IList_1_Google_Protobuf_Reflection_FieldDescriptor_ *)v164.fields._._FullName_k__BackingField;
			//   LODWORD(v164.fields.accessor) = v164.fields._._File_k__BackingField;
			//   v33 = UnityEngine::Vector3::op_Subtraction(
			//           &v168,
			//           (Vector3 *)&v164.fields.fields,
			//           (Vector3 *)&v164.fields._Proto_k__BackingField,
			//           v32);
			//   v164.fields.fields = *(IList_1_Google_Protobuf_Reflection_FieldDescriptor_ **)&v33.x;
			//   z_low = LODWORD(v33.z);
			//   if ( !byte_18D8E3AA7 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D8E3AA7 = 1;
			//   }
			//   v38 = TypeInfo::System::Math;
			//   if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Math, v34);
			//   v39 = (__m128)_mm_cvtsi32_si128(z_low);
			//   v39.m128_f32[0] = (float)(v39.m128_f32[0] * v39.m128_f32[0])
			//                   + (float)((float)(*((float *)&v164.fields.fields + 1) * *((float *)&v164.fields.fields + 1))
			//                           + (float)(*(float *)&v164.fields.fields * *(float *)&v164.fields.fields));
			//   v40 = _mm_cvtps_pd(v39);
			//   if ( v40.m128d_f64[0] < 0.0 )
			//     v41 = sub_1801C22C0(v38, v34, v35);
			//   else
			//     *(_QWORD *)&v41 = *(_OWORD *)&_mm_sqrt_pd(v40);
			//   v42 = v41;
			//   if ( v42 <= 5.0 )
			//     m_interpolateTimeFactor = v6.fields.m_interpolateTimeFactor;
			//   else
			//     m_interpolateTimeFactor = 10000.0;
			//   m_sortedVolumes = v6.fields.m_sortedVolumes;
			//   if ( !m_sortedVolumes )
			//     sub_180B536AC(v38, v34);
			//   *(_OWORD *)&v164.monitor = 0LL;
			//   v164.klass = (OneofDescriptor__Class *)m_sortedVolumes;
			//   sub_1800054D0(
			//     &v164,
			//     v34,
			//     v35,
			//     v36,
			//     (String__Array *)methoda,
			//     (String *)interpolatedVolumes,
			//     (MethodInfo *)interpolatedVolumesFactor);
			//   LODWORD(v164.monitor) = 0;
			//   HIDWORD(v164.monitor) = m_sortedVolumes.fields._version;
			//   *(_QWORD *)&v164.fields._._Index_k__BackingField = 0LL;
			//   *(_OWORD *)&v167._list = *(_OWORD *)&v164.klass;
			//   v167._current = 0LL;
			//   v164.klass = 0LL;
			//   v164.monitor = (MonitorData *)&v167;
			//   while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//             &v167,
			//             MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGEnvironmentVolume>::MoveNext) )
			//   {
			//     current = v167._current;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, m_interpolatedVolumes);
			//     if ( !byte_18D8F4EFA )
			//     {
			//       v48 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//       if ( (v48 & 1) != 0 )
			//       {
			//         v49 = (v48 >> 1) & 0xFFFFFFF;
			//         switch ( v48 >> 29 )
			//         {
			//           case 1u:
			//             v50 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v49);
			//             goto LABEL_110;
			//           case 2u:
			//             v50 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v49);
			//             goto LABEL_110;
			//           case 3u:
			//           case 6u:
			//             v51 = (v48 >> 1) & 0xFFFFFFF;
			//             v52 = v48 >> 29;
			//             if ( v52 )
			//             {
			//               if ( v52 == 3 )
			//               {
			//                 v50 = (void (__fastcall __noreturn **)())sub_180039480(v51);
			//                 goto LABEL_110;
			//               }
			//               if ( v52 == 6 )
			//               {
			//                 v53 = sub_1802DF9C0(v51);
			//                 v50 = (void (__fastcall __noreturn **)())sub_18005F4B0(v53, 0LL);
			//                 goto LABEL_110;
			//               }
			//             }
			//             else if ( v51 == 1 )
			//             {
			//               v50 = off_18A2C5600;
			//               goto LABEL_110;
			//             }
			// LABEL_109:
			//             v50 = 0LL;
			// LABEL_110:
			//             if ( v50 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v50);
			//             break;
			//           case 4u:
			//             v50 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v49);
			//             goto LABEL_110;
			//           case 5u:
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v49) )
			//             {
			//               v50 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v49);
			//             }
			//             else
			//             {
			//               v54 = il2cpp_string_new_len(
			//                       qword_18D8E5198
			//                     + *(int *)(qword_18D8E51A0 + 16)
			//                     + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v49 + 4),
			//                       *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v49));
			//               v50 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                          (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v49),
			//                                                          v54,
			//                                                          0LL);
			//               if ( !v50 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   m_interpolatedVolumes = (((unsigned __int64)(qword_18D8F6F98 + 8 * v49) >> 12) & 0x1FFFFF) >> 6;
			//                   v55 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v49) >> 12) & 0x3F;
			//                   _m_prefetchw(&qword_18D6870D0[m_interpolatedVolumes]);
			//                   do
			//                     v56 = qword_18D6870D0[m_interpolatedVolumes];
			//                   while ( v56 != _InterlockedCompareExchange64(
			//                                    &qword_18D6870D0[m_interpolatedVolumes],
			//                                    v56 | (1LL << v55),
			//                                    v56) );
			//                 }
			//                 v50 = (void (__fastcall __noreturn **)())v54;
			//               }
			//             }
			//             goto LABEL_110;
			//           case 7u:
			//             v57 = sub_1802DF920((unsigned int)v49);
			//             v58 = *(_QWORD *)(v57 + 16);
			//             v59 = (v57 - *(_QWORD *)(v58 + 128)) >> 5;
			//             if ( *(_BYTE *)(v58 + 42) == 21 )
			//             {
			//               v60 = *(_QWORD ***)(v58 + 96);
			//               if ( *v60 )
			//               {
			//                 v61 = **v60 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                 v58 = sub_180039550(v61 / 92 + v61);
			//               }
			//               else
			//               {
			//                 v58 = 0LL;
			//               }
			//             }
			//             v170 = v59 + *(_DWORD *)(*(_QWORD *)(v58 + 104) + 32LL);
			//             v62 = sub_1801B8ECC(
			//                     (unsigned int)&v170,
			//                     (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                     *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                     12,
			//                     (__int64)sub_1802C7760);
			//             if ( !v62 )
			//               goto LABEL_109;
			//             m_interpolatedVolumes = *(unsigned int *)(v62 + 8);
			//             if ( (_DWORD)m_interpolatedVolumes == -1 )
			//               goto LABEL_109;
			//             v50 = (void (__fastcall __noreturn **)())(m_interpolatedVolumes
			//                                                     + qword_18D8E5198
			//                                                     + *(int *)(qword_18D8E51A0 + 72));
			//             goto LABEL_110;
			//           default:
			//             break;
			//         }
			//       }
			//       byte_18D8F4EFA = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, m_interpolatedVolumes);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       v63 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//       if ( (v63 & 1) != 0 )
			//       {
			//         v64 = (v63 >> 1) & 0xFFFFFFF;
			//         switch ( v63 >> 29 )
			//         {
			//           case 1u:
			//             v65 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v64);
			//             goto LABEL_143;
			//           case 2u:
			//             v65 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v64);
			//             goto LABEL_143;
			//           case 3u:
			//           case 6u:
			//             v66 = (v63 >> 1) & 0xFFFFFFF;
			//             v67 = v63 >> 29;
			//             if ( v67 )
			//             {
			//               if ( v67 == 3 )
			//               {
			//                 v65 = (void (__fastcall __noreturn **)())sub_180039480(v66);
			//                 goto LABEL_143;
			//               }
			//               if ( v67 == 6 )
			//               {
			//                 v68 = sub_1802DF9C0(v66);
			//                 v65 = (void (__fastcall __noreturn **)())sub_18005F4B0(v68, 0LL);
			//                 goto LABEL_143;
			//               }
			//             }
			//             else if ( v66 == 1 )
			//             {
			//               v65 = off_18A2C5600;
			//               goto LABEL_143;
			//             }
			// LABEL_142:
			//             v65 = 0LL;
			// LABEL_143:
			//             if ( v65 )
			//               _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v65);
			//             break;
			//           case 4u:
			//             v65 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v64);
			//             goto LABEL_143;
			//           case 5u:
			//             if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v64) )
			//             {
			//               v65 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v64);
			//             }
			//             else
			//             {
			//               v69 = il2cpp_string_new_len(
			//                       qword_18D8E5198
			//                     + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v64 + 4)
			//                     + *(int *)(qword_18D8E51A0 + 16),
			//                       *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v64));
			//               v65 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                          (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v64),
			//                                                          v69,
			//                                                          0LL);
			//               if ( !v65 )
			//               {
			//                 if ( dword_18D8E43F8 )
			//                 {
			//                   m_interpolatedVolumes = (((unsigned __int64)(qword_18D8F6F98 + 8 * v64) >> 12) & 0x1FFFFF) >> 6;
			//                   v70 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v64) >> 12) & 0x3F;
			//                   _m_prefetchw(&qword_18D6870D0[m_interpolatedVolumes]);
			//                   do
			//                     v71 = qword_18D6870D0[m_interpolatedVolumes];
			//                   while ( v71 != _InterlockedCompareExchange64(
			//                                    &qword_18D6870D0[m_interpolatedVolumes],
			//                                    v71 | (1LL << v70),
			//                                    v71) );
			//                 }
			//                 v65 = (void (__fastcall __noreturn **)())v69;
			//               }
			//             }
			//             goto LABEL_143;
			//           case 7u:
			//             v72 = sub_1802DF920((unsigned int)v64);
			//             v73 = *(_QWORD *)(v72 + 16);
			//             v74 = (v72 - *(_QWORD *)(v73 + 128)) >> 5;
			//             if ( *(_BYTE *)(v73 + 42) == 21 )
			//             {
			//               v75 = *(_QWORD ***)(v73 + 96);
			//               if ( *v75 )
			//               {
			//                 v76 = **v75 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                 v73 = sub_180039550(v76 / 92 + v76);
			//               }
			//               else
			//               {
			//                 v73 = 0LL;
			//               }
			//             }
			//             LODWORD(v168.x) = v74 + *(_DWORD *)(*(_QWORD *)(v73 + 104) + 32LL);
			//             v77 = sub_1801B8ECC(
			//                     (unsigned int)&v168,
			//                     (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                     *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                     12,
			//                     (__int64)sub_1802C7760);
			//             if ( !v77 )
			//               goto LABEL_142;
			//             m_interpolatedVolumes = *(unsigned int *)(v77 + 8);
			//             if ( (_DWORD)m_interpolatedVolumes == -1 )
			//               goto LABEL_142;
			//             v65 = (void (__fastcall __noreturn **)())(m_interpolatedVolumes
			//                                                     + qword_18D8E5198
			//                                                     + *(int *)(qword_18D8E51A0 + 72));
			//             goto LABEL_143;
			//           default:
			//             break;
			//         }
			//       }
			//       byte_18D8F4EAF = 1;
			//     }
			//     if ( current )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, m_interpolatedVolumes);
			//       if ( current[1].klass && LODWORD(current[2].monitor) == 2 )
			//       {
			//         v78 = (unsigned __int8 (__fastcall *)(Object *))qword_18D8F4D38;
			//         if ( !qword_18D8F4D38 )
			//         {
			//           v78 = (unsigned __int8 (__fastcall *)(Object *))il2cpp_resolve_icall_0("UnityEngine.Behaviour::get_isActiveAndEnabled()");
			//           if ( !v78 )
			//           {
			//             v156 = sub_1802DBBE8("UnityEngine.Behaviour::get_isActiveAndEnabled()");
			//             sub_18000F750(v156, 0LL);
			//           }
			//           qword_18D8F4D38 = (__int64)v78;
			//         }
			//         if ( v78(current) && (unsigned __int8)sub_1800023D0(11LL, current) )
			//         {
			//           v164.fields._Proto_k__BackingField = 0LL;
			//           *(_DWORD *)&v164.fields._IsSynthetic_k__BackingField = 0;
			//           v79 = (void (__fastcall *)(Transform *, OneofDescriptorProto **))qword_18D8F52E0;
			//           if ( !qword_18D8F52E0 )
			//           {
			//             v79 = (void (__fastcall *)(Transform *, OneofDescriptorProto **))il2cpp_resolve_icall_0(
			//                                                                                "UnityEngine.Transform::get_position_Injec"
			//                                                                                "ted(UnityEngine.Vector3&)");
			//             if ( !v79 )
			//             {
			//               v157 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//               sub_18000F750(v157, 0LL);
			//             }
			//             qword_18D8F52E0 = (__int64)v79;
			//           }
			//           v79(interpolateTrigger, &v164.fields._Proto_k__BackingField);
			//           Proto_k__BackingField = v164.fields._Proto_k__BackingField;
			//           v84 = *(float *)&v164.fields._IsSynthetic_k__BackingField;
			//           if ( !byte_18D8EDC37 )
			//           {
			//             v81 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
			//             if ( (v81 & 1) != 0 )
			//             {
			//               v85 = ((unsigned int)v81 >> 1) & 0xFFFFFFF;
			//               switch ( (unsigned int)v81 >> 29 )
			//               {
			//                 case 1u:
			//                   v86 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v85);
			//                   goto LABEL_181;
			//                 case 2u:
			//                   v86 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v85);
			//                   goto LABEL_181;
			//                 case 3u:
			//                 case 6u:
			//                   v87 = ((unsigned int)v81 >> 1) & 0xFFFFFFF;
			//                   v81 = (unsigned int)v81 >> 29;
			//                   if ( (_DWORD)v81 )
			//                   {
			//                     if ( (_DWORD)v81 == 3 )
			//                     {
			//                       v86 = (void (__fastcall __noreturn **)())sub_180039480(v87);
			//                       goto LABEL_181;
			//                     }
			//                     if ( (_DWORD)v81 == 6 )
			//                     {
			//                       v88 = sub_1802DF9C0(v87);
			//                       v86 = (void (__fastcall __noreturn **)())sub_18005F4B0(v88, 0LL);
			//                       goto LABEL_181;
			//                     }
			// LABEL_170:
			//                     v86 = 0LL;
			//                     goto LABEL_181;
			//                   }
			//                   if ( v87 != 1 )
			//                     goto LABEL_170;
			//                   v86 = off_18A2C5600;
			// LABEL_181:
			//                   if ( v86 )
			//                     _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, (__int64)v86);
			//                   break;
			//                 case 4u:
			//                   v86 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v85);
			//                   goto LABEL_181;
			//                 case 5u:
			//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v85) )
			//                   {
			//                     v86 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v85);
			//                   }
			//                   else
			//                   {
			//                     v82 = il2cpp_string_new_len(
			//                             qword_18D8E5198
			//                           + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v85 + 4)
			//                           + *(int *)(qword_18D8E51A0 + 16),
			//                             *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v85));
			//                     v86 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v85),
			//                                                                v82,
			//                                                                0LL);
			//                     if ( !v86 )
			//                     {
			//                       v81 = qword_18D8F6F98 + 8 * v85;
			//                       if ( dword_18D8E43F8 )
			//                       {
			//                         v89 = (v81 >> 12) & 0x1FFFFF;
			//                         v80 = (unsigned __int64)v89 >> 6;
			//                         v81 = v89 & 0x3F;
			//                         _m_prefetchw(&qword_18D6870D0[v80]);
			//                         do
			//                           v90 = qword_18D6870D0[v80];
			//                         while ( v90 != _InterlockedCompareExchange64(&qword_18D6870D0[v80], v90 | (1LL << v81), v90) );
			//                       }
			//                       v86 = (void (__fastcall __noreturn **)())v82;
			//                     }
			//                   }
			//                   goto LABEL_181;
			//                 case 7u:
			//                   v91 = sub_1802DF920((unsigned int)v85);
			//                   v86 = (void (__fastcall __noreturn **)())sub_18003D1A0(v91, &v164.fields._._FullName_k__BackingField);
			//                   goto LABEL_181;
			//                 default:
			//                   break;
			//               }
			//             }
			//             byte_18D8EDC37 = 1;
			//           }
			//           v92 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v80);
			//             v92 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           v93 = v92.static_fields.wrapperArray;
			//           if ( !v93 )
			//             sub_1802DC2C8(v92, 0LL);
			//           if ( v93.max_length.size <= 594 )
			//             goto LABEL_195;
			//           if ( !v92._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(v92, v93);
			//             v92 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           v94 = v92.static_fields.wrapperArray;
			//           if ( !v94 )
			//             sub_1802DC2C8(0LL, v93);
			//           if ( v94.max_length.size <= 0x252u )
			//             sub_180070260(v94, v93, v81, v82);
			//           if ( v94[16].vector[18] )
			//           {
			//             v95 = IFix::WrappersManagerImpl::GetPatch(594, 0LL);
			//             if ( !v95 )
			//               sub_1802DC2C8(v97, v96);
			//             v164.fields.fields = (IList_1_Google_Protobuf_Reflection_FieldDescriptor_ *)Proto_k__BackingField;
			//             *(float *)&v164.fields.accessor = v84;
			//             v99 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_231(v95, current, (Vector3 *)&v164.fields.fields, 0LL);
			//           }
			//           else
			//           {
			// LABEL_195:
			//             *(_QWORD *)&v169.x = Proto_k__BackingField;
			//             v169.z = v84;
			//             if ( HG::Rendering::Runtime::HGEnvironmentVolume::_DistanceToEdge(
			//                    (HGEnvironmentVolume *)current,
			//                    &v169,
			//                    0LL) > 0.0 )
			//             {
			//               v99 = 1;
			//               goto LABEL_197;
			//             }
			//             v99 = 0;
			//           }
			//           if ( v99 )
			//           {
			// LABEL_197:
			//             monitor = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)current[5].monitor;
			//             if ( !monitor )
			//               sub_1802DC2C8(0LL, v98);
			//             if ( !System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::ContainsKey(
			//                     monitor,
			//                     v5,
			//                     MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::ContainsKey) )
			//             {
			//               v103 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)current[5].monitor;
			//               if ( !v103 )
			//                 sub_1802DC2C8(0LL, v101);
			//               System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Add(
			//                 v103,
			//                 v5,
			//                 (HGEnvironmentVolume_InterpolateDataPerCamera)_mm_cvtsi128_si32((__m128i)0LL),
			//                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Add);
			//             }
			//             v104 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)current[5].monitor;
			//             if ( !v104 )
			//               sub_1802DC2C8(v102, v101);
			//             v105 = MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::get_Item;
			//             if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::get_Item.klass.rgctx_data[22].rgctxDataDummy
			//                   + 4) )
			//               (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::get_Item.klass.rgctx_data[22].rgctxDataDummy)();
			//             Entry = System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::FindEntry(
			//                       v104,
			//                       v5,
			//                       (MethodInfo *)v105.klass.rgctx_data[22].rgctxDataDummy);
			//             if ( Entry < 0 )
			//               System::ThrowHelper::ThrowKeyNotFoundException(v5, 0LL);
			//             entries = v104.fields._entries;
			//             if ( !entries )
			//               sub_1802DC2C8(0LL, v107);
			//             if ( (unsigned int)Entry >= entries.max_length.size )
			//               sub_180070260(entries, Entry, v108, v109);
			//             *(float *)&v164.fields._._FullName_k__BackingField = entries.vector[Entry].value.timeFadingFactor;
			//             if ( !v99 || LOBYTE(current[5].klass) )
			//             {
			//               v127 = (float (*)(void))qword_18D8F5188;
			//               if ( !qword_18D8F5188 )
			//               {
			//                 v127 = (float (*)(void))il2cpp_resolve_icall_0("UnityEngine.Time::get_deltaTime()");
			//                 if ( !v127 )
			//                 {
			//                   v159 = sub_1802DBBE8("UnityEngine.Time::get_deltaTime()");
			//                   sub_18000F750(v159, 0LL);
			//                 }
			//                 qword_18D8F5188 = (__int64)v127;
			//               }
			//               v128 = (float)(v127() * m_interpolateTimeFactor) / *(float *)&current[3].monitor;
			//               FullName_k__BackingField_low = (__m128i)LODWORD(v164.fields._._FullName_k__BackingField);
			//               *(float *)FullName_k__BackingField_low.m128i_i32 = *(float *)&v164.fields._._FullName_k__BackingField
			//                                                                - v128;
			//             }
			//             else
			//             {
			//               v123 = (float (*)(void))qword_18D8F5188;
			//               if ( !qword_18D8F5188 )
			//               {
			//                 v123 = (float (*)(void))il2cpp_resolve_icall_0("UnityEngine.Time::get_deltaTime()");
			//                 if ( !v123 )
			//                 {
			//                   v158 = sub_1802DBBE8("UnityEngine.Time::get_deltaTime()");
			//                   sub_18000F750(v158, 0LL);
			//                 }
			//                 qword_18D8F5188 = (__int64)v123;
			//               }
			//               v125 = (float)(v123() * m_interpolateTimeFactor) / *((float *)&current[3].klass + 1);
			//               FullName_k__BackingField_low = (__m128i)LODWORD(v164.fields._._FullName_k__BackingField);
			//               *(float *)FullName_k__BackingField_low.m128i_i32 = *(float *)&v164.fields._._FullName_k__BackingField
			//                                                                + v125;
			//             }
			//             if ( *(float *)FullName_k__BackingField_low.m128i_i32 >= 0.0 )
			//             {
			//               if ( *(float *)FullName_k__BackingField_low.m128i_i32 > 1.0 )
			//                 FullName_k__BackingField_low = (__m128i)0x3F800000u;
			//             }
			//             else
			//             {
			//               FullName_k__BackingField_low = 0LL;
			//             }
			//             v129 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)current[5].monitor;
			//             if ( !v129 )
			//               sub_1802DC2C8(0LL, v124);
			//             System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::set_Item(
			//               v129,
			//               v5,
			//               (HGEnvironmentVolume_InterpolateDataPerCamera)_mm_cvtsi128_si32(FullName_k__BackingField_low),
			//               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::set_Item);
			//           }
			//           else
			//           {
			//             v110 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)current[5].monitor;
			//             if ( !v110 )
			//               sub_1802DC2C8(0LL, v98);
			//             if ( System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::ContainsKey(
			//                    v110,
			//                    v5,
			//                    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::ContainsKey) )
			//             {
			//               v113 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)current[5].monitor;
			//               if ( !v113 )
			//                 sub_1802DC2C8(v112, v111);
			//               v114 = MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::get_Item;
			//               if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::get_Item.klass.rgctx_data[22].rgctxDataDummy
			//                     + 4) )
			//                 (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::get_Item.klass.rgctx_data[22].rgctxDataDummy)();
			//               v115 = System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::FindEntry(
			//                        v113,
			//                        v5,
			//                        (MethodInfo *)v114.klass.rgctx_data[22].rgctxDataDummy);
			//               if ( v115 < 0 )
			//                 System::ThrowHelper::ThrowKeyNotFoundException(v5, 0LL);
			//               v119 = v113.fields._entries;
			//               if ( !v119 )
			//                 sub_1802DC2C8(0LL, v116);
			//               v98 = v115;
			//               if ( (unsigned int)v115 >= v119.max_length.size )
			//                 sub_180070260(v119, v115, v117, v118);
			//               Epsilon = TypeInfo::UnityEngine::Mathf.static_fields.Epsilon;
			//               *(float *)&v164.fields._._FullName_k__BackingField = v119.vector[v115].value.timeFadingFactor;
			//               if ( Epsilon <= *(float *)&v164.fields._._FullName_k__BackingField )
			//                 goto LABEL_197;
			//               v121 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)current[5].monitor;
			//               if ( !v121 )
			//                 sub_1802DC2C8(0LL, v115);
			//               System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Remove(
			//                 v121,
			//                 v5,
			//                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Remove);
			//             }
			//           }
			//         }
			//       }
			//     }
			//   }
			//   containingType = v164.fields.containingType;
			//   if ( !v164.fields.containingType )
			//     goto LABEL_324;
			//   items = *(_QWORD *)&v164.fields.containingType.fields._._Index_k__BackingField;
			//   if ( !items )
			//     goto LABEL_324;
			//   v131 = this;
			//   HG::Rendering::Runtime::HGEnvironmentPhase::CopyFrom(
			//     (HGEnvironmentPhase *)items,
			//     this.fields.m_interpolatedPhase,
			//     0LL);
			//   z = this.fields.m_lastInterpolateTriggerPosition.z;
			//   containingType.fields._._FullName_k__BackingField = *(String **)&this.fields.m_lastInterpolateTriggerPosition.x;
			//   *(float *)&containingType.fields._._File_k__BackingField = z;
			//   m_interpolatedVolumes = (unsigned __int64)this.fields.m_interpolatedVolumes;
			//   if ( !m_interpolatedVolumes )
			//     goto LABEL_324;
			//   Beyond::IndexedHashSet<System::Object>::GetEnumerator(
			//     (List_1_T_Enumerator_System_Object_ *)&v164,
			//     (IndexedHashSet_1_System_Object_ *)m_interpolatedVolumes,
			//     MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::GetEnumerator);
			//   *(_OWORD *)&v167._list = *(_OWORD *)&v164.klass;
			//   v167._current = *(Object **)&v164.fields._._Index_k__BackingField;
			//   v164.klass = 0LL;
			//   v164.monitor = (MonitorData *)&v167;
			//   try
			//   {
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v167,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGEnvironmentVolume>::MoveNext) )
			//     {
			//       v133 = v167._current;
			//       v134 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedVolumes(
			//                (HGEnvironmentVolumeCameraComponent *)containingType,
			//                0LL);
			//       if ( !v134 )
			//         sub_1802DC2C8(v136, v135);
			//       Beyond::IndexedHashSet<System::Object>::Add(
			//         (IndexedHashSet_1_System_Object_ *)v134,
			//         v133,
			//         MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Add);
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v171 )
			//   {
			//     m_interpolatedVolumes = (unsigned __int64)&v160;
			//     v164.klass = (OneofDescriptor__Class *)v171.ex;
			//     items = (signed __int64)v164.klass;
			//     if ( v164.klass )
			//       sub_18000F780(v164.klass);
			//     containingType = v164.fields.containingType;
			//     v131 = this;
			//   }
			//   m_interpolatedVolumesFactor = v131.fields.m_interpolatedVolumesFactor;
			//   if ( !m_interpolatedVolumesFactor )
			// LABEL_324:
			//     sub_1802DC2C8(items, m_interpolatedVolumes);
			//   *(_OWORD *)&v164.monitor = 0LL;
			//   v164.klass = (OneofDescriptor__Class *)m_interpolatedVolumesFactor;
			//   if ( dword_18D8E43F8 )
			//   {
			//     m_interpolatedVolumes = (((unsigned __int64)&v164 >> 12) & 0x1FFFFF) >> 6;
			//     _m_prefetchw(&qword_18D6870D0[m_interpolatedVolumes]);
			//     do
			//     {
			//       items = qword_18D6870D0[m_interpolatedVolumes] | (1LL << (((unsigned __int64)&v164 >> 12) & 0x3F));
			//       v138 = qword_18D6870D0[m_interpolatedVolumes];
			//     }
			//     while ( v138 != _InterlockedCompareExchange64(&qword_18D6870D0[m_interpolatedVolumes], items, v138) );
			//   }
			//   LODWORD(v164.monitor) = 0;
			//   HIDWORD(v164.monitor) = m_interpolatedVolumesFactor.fields._version;
			//   v164.fields._._Index_k__BackingField = 0;
			//   v165 = *(_OWORD *)&v164.klass;
			//   v166 = *(_QWORD *)&v164.fields._._Index_k__BackingField;
			//   v164.klass = 0LL;
			//   v164.monitor = (MonitorData *)&v165;
			//   try
			//   {
			//     while ( 1 )
			//     {
			//       v139 = v165;
			//       if ( !(_QWORD)v165 )
			//         sub_1802DC2C8(items, m_interpolatedVolumes);
			//       v140 = HIDWORD(v165);
			//       if ( HIDWORD(v165) != *(_DWORD *)(v165 + 28) || DWORD2(v165) >= *(_DWORD *)(v165 + 24) )
			//         break;
			//       v141 = *(_QWORD *)(v165 + 16);
			//       if ( !v141 )
			//         sub_1802DC2C8(SDWORD2(v165), 0LL);
			//       if ( DWORD2(v165) >= *(_DWORD *)(v141 + 24) )
			//         sub_180070260(
			//           SDWORD2(v165),
			//           v141,
			//           MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<float>::MoveNext,
			//           m_interpolatedVolumesFactor);
			//       v142 = *(float *)(v141 + 4LL * SDWORD2(v165) + 32);
			//       *(float *)&v166 = v142;
			//       ++DWORD2(v165);
			//       v143 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedVolumesFactor(
			//                (HGEnvironmentVolumeCameraComponent *)containingType,
			//                0LL);
			//       v147 = v143;
			//       if ( !v143 )
			//         sub_1802DC2C8(v145, v144);
			//       v148 = MethodInfo::System::Collections::Generic::List<float>::Add;
			//       ++v143.fields._version;
			//       items = (signed __int64)v143.fields._items;
			//       m_interpolatedVolumes = v143.fields._size;
			//       if ( !items )
			//         sub_1802DC2C8(0LL, m_interpolatedVolumes);
			//       if ( (unsigned int)m_interpolatedVolumes < *(_DWORD *)(items + 24) )
			//       {
			//         v143.fields._size = m_interpolatedVolumes + 1;
			//         if ( (unsigned int)m_interpolatedVolumes >= *(_DWORD *)(items + 24) )
			//           sub_180070260(items, m_interpolatedVolumes, v146, m_interpolatedVolumesFactor);
			//         *(float *)(items + 4 * m_interpolatedVolumes + 32) = v142;
			//       }
			//       else
			//       {
			//         if ( !*((_QWORD *)v148.klass.rgctx_data[11].rgctxDataDummy + 4) )
			//           (*(void (**)(void))v148.klass.rgctx_data[11].rgctxDataDummy)();
			//         System::Collections::Generic::List<float>::AddWithResize(
			//           v147,
			//           v142,
			//           (MethodInfo *)v148.klass.rgctx_data[11].rgctxDataDummy);
			//       }
			//     }
			//     v149 = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<float>::MoveNext.klass;
			//     if ( ((__int64)v149.vtable[0].methodPtr & 1) == 0 )
			//     {
			//       sub_18003C700(v149);
			//       v140 = HIDWORD(v165);
			//       v139 = v165;
			//     }
			//     if ( !v139 )
			//       sub_1802DC2C8(v149, v140);
			//     if ( (_DWORD)v140 != *(_DWORD *)(v139 + 28) )
			//       System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			//     DWORD2(v165) = *(_DWORD *)(v139 + 24) + 1;
			//     LODWORD(v166) = 0;
			//   }
			//   catch ( Il2CppExceptionWrapper *v172 )
			//   {
			//     v164.klass = (OneofDescriptor__Class *)v172.ex;
			//     if ( v164.klass )
			//       sub_18000F780(v164.klass);
			//     v5 = (Object *)hgCamera;
			//     klass = v164.fields.containingType;
			//     v6 = this;
			//     v4 = (Object *)interpolateTrigger;
			//     goto LABEL_271;
			//   }
			// }
			// 
		}

		private void _PerCameraUpdate(HGCamera hgCamera, ref ScriptableRenderContext renderContext)
		{
			// // Void _PerCameraUpdate(HGCamera, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::HGEnvironmentManager::_PerCameraUpdate(
			//         HGEnvironmentManager *this,
			//         HGCamera *hgCamera,
			//         ScriptableRenderContext *renderContext,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGAdditionalCameraData *m_AdditionalCameraData; // rax
			//   HGRainRenderer *s_rainRenderer; // rax
			//   HGSnowRenderer *s_snowRenderer; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v13; // rax
			// 
			//   if ( !byte_18D8EDC6D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     byte_18D8EDC6D = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, hgCamera);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_25;
			//   if ( wrapperArray.max_length.size > 726 )
			//   {
			//     if ( !v7._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v7, wrapperArray);
			//       v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v7.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_25;
			//     if ( wrapperArray.max_length.size <= 0x2D6u )
			//       goto LABEL_41;
			//     if ( wrapperArray[20].vector[6] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(726, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_285(Patch, (Object *)this, (Object *)hgCamera, renderContext, 0LL);
			//         return;
			//       }
			//       goto LABEL_25;
			//     }
			//   }
			//   if ( !hgCamera )
			//     goto LABEL_25;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, wrapperArray);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_25;
			//   if ( wrapperArray.max_length.size <= 727 )
			//     goto LABEL_16;
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, wrapperArray);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = (struct ILFixDynamicMethodWrapper_2__Class *)v7.static_fields.wrapperArray;
			//   if ( !v7 )
			//     goto LABEL_25;
			//   if ( LODWORD(v7._0.namespaze) <= 0x2D7 )
			// LABEL_41:
			//     sub_180070270(v7, wrapperArray);
			//   if ( v7[15]._1.unity_user_data )
			//   {
			//     v13 = IFix::WrappersManagerImpl::GetPatch(727, 0LL);
			//     if ( !v13 )
			//       goto LABEL_25;
			//     if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v13, (Object *)hgCamera, 0LL) )
			//       goto LABEL_19;
			//     return;
			//   }
			// LABEL_16:
			//   m_AdditionalCameraData = hgCamera.fields.m_AdditionalCameraData;
			//   if ( !m_AdditionalCameraData )
			//     goto LABEL_25;
			//   if ( m_AdditionalCameraData.fields.hgRenderPath != 1 && m_AdditionalCameraData.fields.hgRenderPath != 2 )
			//   {
			// LABEL_19:
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager, wrapperArray);
			//     s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
			//     if ( s_rainRenderer )
			//     {
			//       HG::Rendering::Runtime::HGRainRenderer::UpdateRainAndWetnessData(s_rainRenderer, hgCamera, renderContext, 0LL);
			//       s_snowRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(0LL);
			//       if ( s_snowRenderer )
			//       {
			//         HG::Rendering::Runtime::HGSnowRenderer::UpdateSnowData(s_snowRenderer, hgCamera, renderContext, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_25:
			//     sub_180B536AC(v7, wrapperArray);
			//   }
			// }
			// 
		}

		private Transform _GetInterpolateTrigger()
		{
			// // Transform _GetInterpolateTrigger()
			// Transform *HG::Rendering::Runtime::HGEnvironmentManager::_GetInterpolateTrigger(
			//         HGEnvironmentManager *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Transform *m_interpolateTriggerOverride; // rbx
			//   HGRenderPipeline *currentPipeline; // rax
			//   Transform *currentPlayerCenter; // rbx
			//   HGRenderPipeline *v9; // rax
			//   __int64 v11; // rdx
			//   Camera *main; // rbx
			//   __int64 (__fastcall *v13)(Camera *); // rax
			//   ILFixDynamicMethodWrapper_2__Array *v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC6E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC6E = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_56;
			//   if ( wrapperArray.max_length.size <= 590 )
			//     goto LABEL_9;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   v14 = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_56;
			//   if ( v14.max_length.size <= 0x24Eu )
			//     sub_180070270(static_fields, wrapperArray);
			//   if ( !v14[16].vector[14] )
			//   {
			// LABEL_9:
			//     m_interpolateTriggerOverride = this.fields.m_interpolateTriggerOverride;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( !byte_18D8F4EFB )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFB = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     if ( m_interpolateTriggerOverride )
			//     {
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//       if ( m_interpolateTriggerOverride.fields._._.m_CachedPtr )
			//         return this.fields.m_interpolateTriggerOverride;
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, wrapperArray);
			//     currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//     if ( !currentPipeline )
			//       goto LABEL_56;
			//     currentPlayerCenter = currentPipeline.fields.currentPlayerCenter;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( !byte_18D8F4EFB )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EFB = 1;
			//     }
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( !byte_18D8F4EAF )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8F4EAF = 1;
			//     }
			//     if ( !currentPlayerCenter )
			//       goto LABEL_40;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( !currentPlayerCenter.fields._._.m_CachedPtr )
			//     {
			// LABEL_40:
			//       main = UnityEngine::Camera::get_main(0LL);
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//       if ( !byte_18D8F4EFB )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EFB = 1;
			//       }
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( !main )
			//         return 0LL;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//       if ( !main.fields._._._.m_CachedPtr )
			//         return 0LL;
			//       v13 = (__int64 (__fastcall *)(Camera *))qword_18D8F4D40;
			//       if ( !qword_18D8F4D40 )
			//       {
			//         v13 = (__int64 (__fastcall *)(Camera *))sub_180017470("UnityEngine.Component::get_transform()");
			//         qword_18D8F4D40 = (__int64)v13;
			//       }
			//       return (Transform *)v13(main);
			//     }
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline, wrapperArray);
			//     v9 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
			//     if ( v9 )
			//       return v9.fields.currentPlayerCenter;
			// LABEL_56:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(590, 0LL);
			//   if ( !Patch )
			//     goto LABEL_56;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_226(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		private void _InterpolateVolumes(Transform interpolateTrigger)
		{
			// // Void _InterpolateVolumes(Transform)
			// void HG::Rendering::Runtime::HGEnvironmentManager::_InterpolateVolumes(
			//         HGEnvironmentManager *this,
			//         Transform *interpolateTrigger,
			//         MethodInfo *method)
			// {
			//   IndexedHashSet_1_System_Object_ *m_interpolatedVolumes; // rcx
			//   Dictionary_2_System_Object_System_Int32___Class *klass; // rdx
			//   Vector3 *p_m_lastInterpolateTriggerPosition; // rsi
			//   __int64 v8; // rax
			//   float v9; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   char v11[24]; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC6F )
			//   {
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::Clear);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC6F = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   m_interpolatedVolumes = (IndexedHashSet_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, interpolateTrigger);
			//     m_interpolatedVolumes = (IndexedHashSet_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   klass = m_interpolatedVolumes[5].fields.m_indexDict.klass;
			//   if ( !klass )
			//     goto LABEL_26;
			//   if ( SLODWORD(klass._0.namespaze) <= 591 )
			//     goto LABEL_9;
			//   if ( !LODWORD(m_interpolatedVolumes[7].klass) )
			//   {
			//     il2cpp_runtime_class_init_0(m_interpolatedVolumes, klass);
			//     m_interpolatedVolumes = (IndexedHashSet_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   m_interpolatedVolumes = (IndexedHashSet_1_System_Object_ *)m_interpolatedVolumes[5].fields.m_indexDict.klass;
			//   if ( !m_interpolatedVolumes )
			// LABEL_26:
			//     sub_180B536AC(m_interpolatedVolumes, klass);
			//   if ( LODWORD(m_interpolatedVolumes.fields.m_indexDict) <= 0x24F )
			//     sub_180070270(m_interpolatedVolumes, klass);
			//   if ( m_interpolatedVolumes[148].fields.m_indexDict )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(591, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)interpolateTrigger,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_26;
			//   }
			// LABEL_9:
			//   m_interpolatedVolumes = (IndexedHashSet_1_System_Object_ *)this.fields.m_interpolatedVolumes;
			//   if ( !m_interpolatedVolumes )
			//     goto LABEL_26;
			//   Beyond::IndexedHashSet<System::Object>::Clear(
			//     m_interpolatedVolumes,
			//     MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Clear);
			//   m_interpolatedVolumes = (IndexedHashSet_1_System_Object_ *)this.fields.m_interpolatedVolumesFactor;
			//   if ( !m_interpolatedVolumes )
			//     goto LABEL_26;
			//   ++HIDWORD(m_interpolatedVolumes.fields.m_indexDict);
			//   LODWORD(m_interpolatedVolumes.fields.m_indexDict) = 0;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( interpolateTrigger )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, klass);
			//     p_m_lastInterpolateTriggerPosition = &this.fields.m_lastInterpolateTriggerPosition;
			//     if ( interpolateTrigger.fields._._.m_CachedPtr )
			//     {
			//       HG::Rendering::Runtime::HGEnvironmentManager::_InterpolateVolumesImpl(
			//         this,
			//         0LL,
			//         interpolateTrigger,
			//         this.fields.m_interpolatedPhase,
			//         &this.fields.m_lastInterpolateTriggerPosition,
			//         this.fields.m_interpolatedVolumes,
			//         this.fields.m_interpolatedVolumesFactor,
			//         0LL);
			//       return;
			//     }
			//   }
			//   else
			//   {
			//     p_m_lastInterpolateTriggerPosition = &this.fields.m_lastInterpolateTriggerPosition;
			//   }
			//   v8 = sub_18281C140(v11);
			//   v9 = *(float *)(v8 + 8);
			//   *(_QWORD *)&p_m_lastInterpolateTriggerPosition.x = *(_QWORD *)v8;
			//   p_m_lastInterpolateTriggerPosition.z = v9;
			// }
			// 
		}

		private void _InterpolateVolumesImpl(HGCamera hgCamera, Transform interpolateTrigger, HGEnvironmentPhase interpolatedPhaseTarget, ref Vector3 lastInterpolateTriggerPosition, IndexedHashSet<HGEnvironmentVolume> interpolatedVolumes, List<float> interpolatedVolumesFactor)
		{
			// // Void _InterpolateVolumesImpl(HGCamera, Transform, HGEnvironmentPhase, Vector3 ByRef, IndexedHashSet`1[HG.Rendering.Runtime.HGEnvironmentVolume], List`1[System.Single])
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGEnvironmentManager::_InterpolateVolumesImpl(
			//         HGEnvironmentManager *this,
			//         HGCamera *hgCamera,
			//         Transform *interpolateTrigger,
			//         HGEnvironmentPhase *interpolatedPhaseTarget,
			//         Vector3 *lastInterpolateTriggerPosition,
			//         IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *interpolatedVolumes,
			//         List_1_System_Single_ *interpolatedVolumesFactor,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v12; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v14; // rbx
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rbx
			//   void (__fastcall *v18)(Transform *, Vector3 *); // rax
			//   MethodInfo *v19; // r9
			//   Vector3 *v20; // rax
			//   __int64 v21; // rdx
			//   __int64 v22; // r8
			//   unsigned int z_low; // esi
			//   struct Math__Class *v24; // rcx
			//   __m128 v25; // xmm2
			//   __m128d v26; // xmm3
			//   __m128d v27; // xmm0
			//   float v28; // xmm0_4
			//   float m_interpolateTimeFactor; // xmm10_4
			//   __m128d v30; // xmm9
			//   void (__fastcall *v31)(Transform *, Vector3 *); // rax
			//   OneofDescriptorProto *v32; // rdx
			//   __int64 v33; // rcx
			//   FileDescriptor *v34; // r8
			//   MessageDescriptor *v35; // r9
			//   List_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *m_sortedVolumes; // rbx
			//   IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolume_ *v37; // rsi
			//   unsigned __int64 v38; // rdx
			//   Object *current; // rbx
			//   unsigned int v40; // r8d
			//   __int64 v41; // rdi
			//   void (__fastcall __noreturn **v42)(); // rax
			//   unsigned int v43; // eax
			//   unsigned int v44; // r8d
			//   __int64 v45; // rax
			//   signed __int64 v46; // r9
			//   char v47; // r8
			//   signed __int64 v48; // rtt
			//   __int64 v49; // rdi
			//   __int64 v50; // rax
			//   __int64 v51; // rdi
			//   _QWORD **v52; // rcx
			//   __int64 v53; // r8
			//   __int64 v54; // rax
			//   unsigned int v55; // r8d
			//   __int64 v56; // rdi
			//   void (__fastcall __noreturn **v57)(); // rax
			//   unsigned int v58; // eax
			//   unsigned int v59; // r8d
			//   __int64 v60; // rax
			//   signed __int64 v61; // r9
			//   char v62; // r8
			//   signed __int64 v63; // rtt
			//   __int64 v64; // rdi
			//   __int64 v65; // rax
			//   __int64 v66; // rdi
			//   _QWORD **v67; // rcx
			//   __int64 v68; // r8
			//   __int64 v69; // rax
			//   unsigned __int8 (__fastcall *v70)(Object *); // rax
			//   HGEnvironmentPhase *v71; // rax
			//   __int64 v72; // rdx
			//   __int64 v73; // rcx
			//   __int64 v74; // rdx
			//   __int64 v75; // rcx
			//   __int64 v76; // rdx
			//   __int64 v77; // rcx
			//   void (__fastcall *v78)(Transform *, Vector3 *); // rax
			//   __int64 v79; // rdx
			//   bool v80; // si
			//   Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *monitor; // rcx
			//   __int64 v82; // rdx
			//   Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *v83; // rcx
			//   __int64 v84; // rdx
			//   Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v85; // rcx
			//   char v86; // di
			//   Object *v87; // rdx
			//   Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *v88; // rcx
			//   __int64 v89; // rdx
			//   Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *v90; // rcx
			//   Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *v91; // rcx
			//   __m128i klass_high; // xmm6
			//   __m128i v93; // xmm0
			//   Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *v94; // rcx
			//   HGEnvironmentPhase *v95; // rax
			//   __int64 v96; // rdx
			//   __int64 v97; // rcx
			//   __int64 v98; // rdx
			//   __int64 v99; // rcx
			//   __int64 v100; // rdx
			//   __int64 v101; // rcx
			//   __int64 v102; // r8
			//   __int64 v103; // r9
			//   struct MethodInfo *v104; // rbx
			//   Single__Array *items; // rcx
			//   __int64 size; // rdx
			//   void (__fastcall *v107)(Transform *, Vector3 *); // rax
			//   float v108; // xmm6_4
			//   __int64 v109; // rdx
			//   ILFixDynamicMethodWrapper_2 *v110; // rcx
			//   HGEnvironmentPhase *v111; // rax
			//   __int64 v112; // rdx
			//   __int64 v113; // rcx
			//   __int64 v114; // rdx
			//   __int64 v115; // rcx
			//   __int64 v116; // rdx
			//   __int64 v117; // rcx
			//   void (__fastcall *v118)(Transform *, Vector3 *); // rax
			//   unsigned __int64 v119; // rdx
			//   unsigned __int64 v120; // r8
			//   signed __int64 v121; // r9
			//   __int64 v122; // xmm6_8
			//   float z; // esi
			//   __int64 v124; // rdi
			//   void (__fastcall __noreturn **v125)(); // rax
			//   unsigned int v126; // eax
			//   __int64 v127; // rax
			//   unsigned int v128; // r8d
			//   signed __int64 v129; // rtt
			//   __int64 v130; // rdi
			//   __int64 v131; // rax
			//   __int64 v132; // rdi
			//   _QWORD **v133; // rcx
			//   __int64 v134; // r8
			//   __int64 v135; // rax
			//   struct ILFixDynamicMethodWrapper_2__Class *v136; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *v137; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v138; // rcx
			//   ILFixDynamicMethodWrapper_2 *v139; // rax
			//   __int64 v140; // rdx
			//   __int64 v141; // rcx
			//   HGEnvironmentPhase *v142; // rax
			//   __int64 v143; // rdx
			//   __int64 v144; // rcx
			//   __int64 v145; // rdx
			//   __int64 v146; // rcx
			//   __int64 v147; // rdx
			//   __int64 v148; // rcx
			//   __int64 v149; // r8
			//   __int64 v150; // r9
			//   struct MethodInfo *v151; // rbx
			//   Single__Array *v152; // rcx
			//   __int64 v153; // rdx
			//   __int64 v154; // rax
			//   __int64 v155; // rax
			//   __int64 v156; // rax
			//   __int64 v157; // rax
			//   __int64 v158; // rax
			//   __int64 v159; // rax
			//   Object *P3; // [rsp+20h] [rbp-1D8h]
			//   String *P4; // [rsp+28h] [rbp-1D0h]
			//   MethodInfo *P5; // [rsp+30h] [rbp-1C8h]
			//   Vector3 v163; // [rsp+50h] [rbp-1A8h] BYREF
			//   Vector3 v164[2]; // [rsp+60h] [rbp-198h] BYREF
			//   Vector3 v165; // [rsp+80h] [rbp-178h] BYREF
			//   OneofDescriptor v166; // [rsp+90h] [rbp-168h] BYREF
			//   Vector3 v167; // [rsp+E0h] [rbp-118h] BYREF
			//   Vector3 v168; // [rsp+F0h] [rbp-108h] BYREF
			//   Vector3 v169; // [rsp+100h] [rbp-F8h] BYREF
			//   Vector3 v170; // [rsp+110h] [rbp-E8h] BYREF
			//   List_1_T_Enumerator_System_Object_ v171; // [rsp+120h] [rbp-D8h] BYREF
			//   int v172; // [rsp+138h] [rbp-C0h] BYREF
			//   int v173; // [rsp+148h] [rbp-B0h] BYREF
			//   Il2CppExceptionWrapper *v174; // [rsp+158h] [rbp-A0h] BYREF
			//   Vector3 v175[9]; // [rsp+160h] [rbp-98h] BYREF
			// 
			//   if ( !byte_18D8EDC70 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::set_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGEnvironmentVolume>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGEnvironmentVolume>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGEnvironmentVolume>::get_Current);
			//     sub_18003C530(&MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<float>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolume>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC70 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, hgCamera);
			//     v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v12.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v12, hgCamera);
			//   if ( wrapperArray.max_length.size > 592 )
			//   {
			//     if ( !v12._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v12, hgCamera);
			//       v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v14 = v12.static_fields.wrapperArray;
			//     if ( !v14 )
			//       sub_180B536AC(v12, hgCamera);
			//     if ( v14.max_length.size <= 0x250u )
			//       sub_180070270(v12, hgCamera);
			//     if ( v14[16].vector[16] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(592, 0LL);
			//       if ( !Patch )
			//         sub_180B536AC(v16, v15);
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_233(
			//         Patch,
			//         (Object *)this,
			//         (Object *)hgCamera,
			//         (Object *)interpolateTrigger,
			//         (Object *)interpolatedPhaseTarget,
			//         lastInterpolateTriggerPosition,
			//         (Object *)interpolatedVolumes,
			//         (Object *)interpolatedVolumesFactor,
			//         0LL);
			//       return;
			//     }
			//   }
			//   if ( !interpolateTrigger )
			//     sub_180B536AC(v12, hgCamera);
			//   *(_QWORD *)&v163.x = 0LL;
			//   v163.z = 0.0;
			//   v18 = (void (__fastcall *)(Transform *, Vector3 *))qword_18D8F52E0;
			//   if ( !qword_18D8F52E0 )
			//   {
			//     v18 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//     if ( !v18 )
			//     {
			//       v154 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v154, 0LL);
			//     }
			//     qword_18D8F52E0 = (__int64)v18;
			//   }
			//   v18(interpolateTrigger, &v163);
			//   v164[0] = *lastInterpolateTriggerPosition;
			//   v165 = v163;
			//   v20 = UnityEngine::Vector3::op_Subtraction(&v170, &v165, v164, v19);
			//   *(_QWORD *)&v164[0].x = *(_QWORD *)&v20.x;
			//   z_low = LODWORD(v20.z);
			//   if ( !byte_18D8E3AA7 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D8E3AA7 = 1;
			//   }
			//   v24 = TypeInfo::System::Math;
			//   if ( !TypeInfo::System::Math._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Math, v21);
			//   v25 = (__m128)_mm_cvtsi32_si128(z_low);
			//   v25.m128_f32[0] = (float)(v25.m128_f32[0] * v25.m128_f32[0])
			//                   + (float)((float)(v164[0].y * v164[0].y) + (float)(v164[0].x * v164[0].x));
			//   v26 = _mm_cvtps_pd(v25);
			//   if ( v26.m128d_f64[0] < 0.0 )
			//   {
			//     v27.m128d_f64[1] = v26.m128d_f64[1];
			//     v27.m128d_f64[0] = sub_1801C22C0(v24, v21, v22);
			//   }
			//   else
			//   {
			//     v27 = _mm_sqrt_pd(v26);
			//   }
			//   v28 = v27.m128d_f64[0];
			//   if ( v28 <= 5.0 )
			//     m_interpolateTimeFactor = this.fields.m_interpolateTimeFactor;
			//   else
			//     m_interpolateTimeFactor = 10000.0;
			//   *(float *)v27.m128d_f64 = UnityEngine::Time::get_deltaTime(0LL);
			//   v30 = v27;
			//   memset(&v163, 0, sizeof(v163));
			//   v31 = (void (__fastcall *)(Transform *, Vector3 *))qword_18D8F52E0;
			//   if ( !qword_18D8F52E0 )
			//   {
			//     v31 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_0(
			//                                                          "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//     if ( !v31 )
			//     {
			//       v155 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//       sub_18000F750(v155, 0LL);
			//     }
			//     qword_18D8F52E0 = (__int64)v31;
			//   }
			//   v31(interpolateTrigger, &v163);
			//   *lastInterpolateTriggerPosition = v163;
			//   m_sortedVolumes = this.fields.m_sortedVolumes;
			//   if ( !m_sortedVolumes )
			//     sub_180B536AC(v33, v32);
			//   *(_OWORD *)&v166.monitor = 0LL;
			//   v166.klass = (OneofDescriptor__Class *)m_sortedVolumes;
			//   sub_1800054D0(&v166, v32, v34, v35, (String__Array *)P3, P4, P5);
			//   LODWORD(v166.monitor) = 0;
			//   HIDWORD(v166.monitor) = m_sortedVolumes.fields._version;
			//   *(_QWORD *)&v166.fields._._Index_k__BackingField = 0LL;
			//   *(_OWORD *)&v171._list = *(_OWORD *)&v166.klass;
			//   v171._current = 0LL;
			//   v166.klass = 0LL;
			//   v166.monitor = (MonitorData *)&v171;
			//   try
			//   {
			// LABEL_36:
			//     v37 = interpolatedVolumes;
			//     while ( 1 )
			//     {
			//       while ( 1 )
			//       {
			//         while ( 1 )
			//         {
			//           while ( 1 )
			//           {
			//             if ( !System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                     &v171,
			//                     MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGEnvironmentVolume>::MoveNext) )
			//               return;
			//             current = v171._current;
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v38);
			//             if ( !byte_18D8F4EFA )
			//             {
			//               v40 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//               if ( (v40 & 1) != 0 )
			//               {
			//                 v41 = (v40 >> 1) & 0xFFFFFFF;
			//                 switch ( v40 >> 29 )
			//                 {
			//                   case 1u:
			//                     v42 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v41);
			//                     goto LABEL_68;
			//                   case 2u:
			//                     v42 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v41);
			//                     goto LABEL_68;
			//                   case 3u:
			//                   case 6u:
			//                     v43 = (v40 >> 1) & 0xFFFFFFF;
			//                     v44 = v40 >> 29;
			//                     if ( v44 )
			//                     {
			//                       if ( v44 == 3 )
			//                       {
			//                         v42 = (void (__fastcall __noreturn **)())sub_180039480(v43);
			//                         goto LABEL_68;
			//                       }
			//                       if ( v44 == 6 )
			//                       {
			//                         v45 = sub_1802DF9C0(v43);
			//                         v42 = (void (__fastcall __noreturn **)())sub_18005F4B0(v45, 0LL);
			//                         goto LABEL_68;
			//                       }
			//                     }
			//                     else if ( v43 == 1 )
			//                     {
			//                       v42 = off_18A2C5600;
			//                       goto LABEL_68;
			//                     }
			// LABEL_67:
			//                     v42 = 0LL;
			// LABEL_68:
			//                     if ( v42 )
			//                       _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v42);
			//                     break;
			//                   case 4u:
			//                     v42 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v41);
			//                     goto LABEL_68;
			//                   case 5u:
			//                     if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v41) )
			//                     {
			//                       v42 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v41);
			//                     }
			//                     else
			//                     {
			//                       v46 = il2cpp_string_new_len(
			//                               qword_18D8E5198
			//                             + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v41 + 4)
			//                             + *(int *)(qword_18D8E51A0 + 16),
			//                               *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v41));
			//                       v42 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v41),
			//                                                                  v46,
			//                                                                  0LL);
			//                       if ( !v42 )
			//                       {
			//                         if ( dword_18D8E43F8 )
			//                         {
			//                           v38 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v41) >> 12) & 0x1FFFFF) >> 6;
			//                           v47 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v41) >> 12) & 0x3F;
			//                           _m_prefetchw(&qword_18D6870D0[v38]);
			//                           do
			//                             v48 = qword_18D6870D0[v38];
			//                           while ( v48 != _InterlockedCompareExchange64(&qword_18D6870D0[v38], v48 | (1LL << v47), v48) );
			//                         }
			//                         v42 = (void (__fastcall __noreturn **)())v46;
			//                       }
			//                     }
			//                     goto LABEL_68;
			//                   case 7u:
			//                     v49 = sub_1802DF920((unsigned int)v41);
			//                     v50 = *(_QWORD *)(v49 + 16);
			//                     v51 = (v49 - *(_QWORD *)(v50 + 128)) >> 5;
			//                     if ( *(_BYTE *)(v50 + 42) == 21 )
			//                     {
			//                       v52 = *(_QWORD ***)(v50 + 96);
			//                       if ( *v52 )
			//                       {
			//                         v53 = **v52 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                         v50 = sub_180039550(v53 / 92 + v53);
			//                       }
			//                       else
			//                       {
			//                         v50 = 0LL;
			//                       }
			//                     }
			//                     v172 = v51 + *(_DWORD *)(*(_QWORD *)(v50 + 104) + 32LL);
			//                     v54 = sub_1801B8ECC(
			//                             (unsigned int)&v172,
			//                             (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                             *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                             12,
			//                             (__int64)sub_1802C7760);
			//                     if ( !v54 )
			//                       goto LABEL_67;
			//                     v38 = *(unsigned int *)(v54 + 8);
			//                     if ( (_DWORD)v38 == -1 )
			//                       goto LABEL_67;
			//                     v42 = (void (__fastcall __noreturn **)())(v38 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                     goto LABEL_68;
			//                   default:
			//                     break;
			//                 }
			//               }
			//               byte_18D8F4EFA = 1;
			//             }
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v38);
			//             if ( !byte_18D8F4EAF )
			//             {
			//               v55 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//               if ( (v55 & 1) != 0 )
			//               {
			//                 v56 = (v55 >> 1) & 0xFFFFFFF;
			//                 switch ( v55 >> 29 )
			//                 {
			//                   case 1u:
			//                     v57 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v56);
			//                     goto LABEL_101;
			//                   case 2u:
			//                     v57 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v56);
			//                     goto LABEL_101;
			//                   case 3u:
			//                   case 6u:
			//                     v58 = (v55 >> 1) & 0xFFFFFFF;
			//                     v59 = v55 >> 29;
			//                     if ( v59 )
			//                     {
			//                       if ( v59 == 3 )
			//                       {
			//                         v57 = (void (__fastcall __noreturn **)())sub_180039480(v58);
			//                         goto LABEL_101;
			//                       }
			//                       if ( v59 == 6 )
			//                       {
			//                         v60 = sub_1802DF9C0(v58);
			//                         v57 = (void (__fastcall __noreturn **)())sub_18005F4B0(v60, 0LL);
			//                         goto LABEL_101;
			//                       }
			//                     }
			//                     else if ( v58 == 1 )
			//                     {
			//                       v57 = off_18A2C5600;
			//                       goto LABEL_101;
			//                     }
			// LABEL_100:
			//                     v57 = 0LL;
			// LABEL_101:
			//                     if ( v57 )
			//                       _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v57);
			//                     break;
			//                   case 4u:
			//                     v57 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v56);
			//                     goto LABEL_101;
			//                   case 5u:
			//                     if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v56) )
			//                     {
			//                       v57 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v56);
			//                     }
			//                     else
			//                     {
			//                       v61 = il2cpp_string_new_len(
			//                               qword_18D8E5198
			//                             + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v56 + 4)
			//                             + *(int *)(qword_18D8E51A0 + 16),
			//                               *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v56));
			//                       v57 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                  (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v56),
			//                                                                  v61,
			//                                                                  0LL);
			//                       if ( !v57 )
			//                       {
			//                         if ( dword_18D8E43F8 )
			//                         {
			//                           v38 = (((unsigned __int64)(qword_18D8F6F98 + 8 * v56) >> 12) & 0x1FFFFF) >> 6;
			//                           v62 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v56) >> 12) & 0x3F;
			//                           _m_prefetchw(&qword_18D6870D0[v38]);
			//                           do
			//                             v63 = qword_18D6870D0[v38];
			//                           while ( v63 != _InterlockedCompareExchange64(&qword_18D6870D0[v38], v63 | (1LL << v62), v63) );
			//                         }
			//                         v57 = (void (__fastcall __noreturn **)())v61;
			//                       }
			//                     }
			//                     goto LABEL_101;
			//                   case 7u:
			//                     v64 = sub_1802DF920((unsigned int)v56);
			//                     v65 = *(_QWORD *)(v64 + 16);
			//                     v66 = (v64 - *(_QWORD *)(v65 + 128)) >> 5;
			//                     if ( *(_BYTE *)(v65 + 42) == 21 )
			//                     {
			//                       v67 = *(_QWORD ***)(v65 + 96);
			//                       if ( *v67 )
			//                       {
			//                         v68 = **v67 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                         v65 = sub_180039550(v68 / 92 + v68);
			//                       }
			//                       else
			//                       {
			//                         v65 = 0LL;
			//                       }
			//                     }
			//                     v173 = v66 + *(_DWORD *)(*(_QWORD *)(v65 + 104) + 32LL);
			//                     v69 = sub_1801B8ECC(
			//                             (unsigned int)&v173,
			//                             (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                             *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                             12,
			//                             (__int64)sub_1802C7760);
			//                     if ( !v69 )
			//                       goto LABEL_100;
			//                     v38 = *(unsigned int *)(v69 + 8);
			//                     if ( (_DWORD)v38 == -1 )
			//                       goto LABEL_100;
			//                     v57 = (void (__fastcall __noreturn **)())(v38 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                     goto LABEL_101;
			//                   default:
			//                     break;
			//                 }
			//               }
			//               byte_18D8F4EAF = 1;
			//             }
			//             if ( current )
			//             {
			//               if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                 il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v38);
			//               if ( current[1].klass )
			//               {
			//                 v70 = (unsigned __int8 (__fastcall *)(Object *))qword_18D8F4D38;
			//                 if ( !qword_18D8F4D38 )
			//                 {
			//                   v70 = (unsigned __int8 (__fastcall *)(Object *))il2cpp_resolve_icall_0("UnityEngine.Behaviour::get_isActiveAndEnabled()");
			//                   if ( !v70 )
			//                   {
			//                     v156 = sub_1802DBBE8("UnityEngine.Behaviour::get_isActiveAndEnabled()");
			//                     sub_18000F750(v156, 0LL);
			//                   }
			//                   qword_18D8F4D38 = (__int64)v70;
			//                 }
			//                 if ( v70(current) && (unsigned __int8)sub_1800023D0(11LL, current) )
			//                   break;
			//               }
			//             }
			//           }
			//           if ( !LODWORD(current[2].monitor) )
			//             break;
			//           if ( LODWORD(current[2].monitor) == 1 )
			//           {
			//             memset(&v163, 0, sizeof(v163));
			//             v107 = (void (__fastcall *)(Transform *, Vector3 *))qword_18D8F52E0;
			//             if ( !qword_18D8F52E0 )
			//             {
			//               v107 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_0(
			//                                                                     "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//               if ( !v107 )
			//               {
			//                 v158 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//                 sub_18000F750(v158, 0LL);
			//               }
			//               qword_18D8F52E0 = (__int64)v107;
			//             }
			//             v107(interpolateTrigger, &v163);
			//             if ( IFix::WrappersManagerImpl::IsPatched(600, 0LL) )
			//             {
			//               v110 = IFix::WrappersManagerImpl::GetPatch(600, 0LL);
			//               if ( !v110 )
			//                 sub_1802DC2C8(0LL, v109);
			//               v167 = v163;
			//               v108 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_230(v110, current, &v167, 0LL);
			//               goto LABEL_177;
			//             }
			//             if ( !LODWORD(current[2].klass) )
			//             {
			// LABEL_174:
			//               v108 = 1.0;
			//               goto LABEL_177;
			//             }
			//             *(Vector3 *)&v166.fields._Proto_k__BackingField = v163;
			//             v108 = HG::Rendering::Runtime::HGEnvironmentVolume::_DistanceToEdge(
			//                      (HGEnvironmentVolume *)current,
			//                      (Vector3 *)&v166.fields._Proto_k__BackingField,
			//                      0LL)
			//                  / (float)(*(float *)&current[3].klass + COERCE_FLOAT(1));
			//             if ( v108 >= 0.0 )
			//             {
			//               if ( v108 > 1.0 )
			//                 goto LABEL_174;
			//             }
			//             else
			//             {
			//               v108 = 0.0;
			//             }
			// LABEL_177:
			//             if ( v108 > TypeInfo::UnityEngine::Mathf.static_fields.Epsilon )
			//             {
			//               v111 = (HGEnvironmentPhase *)sub_18004A6C0(12LL, current);
			//               if ( !interpolatedPhaseTarget )
			//                 sub_1802DC2C8(v113, v112);
			//               HG::Rendering::Runtime::HGEnvironmentPhase::Lerp(
			//                 interpolatedPhaseTarget,
			//                 interpolatedPhaseTarget,
			//                 v111,
			//                 v108,
			//                 0LL);
			//               if ( !v37 )
			//                 sub_1802DC2C8(v115, v114);
			//               Beyond::IndexedHashSet<System::Object>::Add(
			//                 (IndexedHashSet_1_System_Object_ *)v37,
			//                 current,
			//                 MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Add);
			//               if ( !interpolatedVolumesFactor )
			//                 sub_1802DC2C8(v117, v116);
			// LABEL_122:
			//               sub_1824B31B0(interpolatedVolumesFactor);
			//             }
			//           }
			//           else if ( LODWORD(current[2].monitor) == 2 )
			//           {
			//             *(_QWORD *)&v165.x = 0LL;
			//             v165.z = 0.0;
			//             v78 = (void (__fastcall *)(Transform *, Vector3 *))qword_18D8F52E0;
			//             if ( !qword_18D8F52E0 )
			//             {
			//               v78 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_0(
			//                                                                    "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//               if ( !v78 )
			//               {
			//                 v157 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//                 sub_18000F750(v157, 0LL);
			//               }
			//               qword_18D8F52E0 = (__int64)v78;
			//             }
			//             v78(interpolateTrigger, &v165);
			//             *(Vector3 *)&v166.fields.fields = v165;
			//             v80 = HG::Rendering::Runtime::HGEnvironmentVolume::Contains(
			//                     (HGEnvironmentVolume *)current,
			//                     (Vector3 *)&v166.fields.fields,
			//                     0LL);
			//             if ( !v80 && hgCamera )
			//             {
			//               monitor = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)current[5].monitor;
			//               if ( !monitor )
			//                 sub_1802DC2C8(0LL, v79);
			//               if ( !System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::ContainsKey(
			//                       monitor,
			//                       (Object *)hgCamera,
			//                       MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::ContainsKey) )
			//                 goto LABEL_36;
			//               v83 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)current[5].monitor;
			//               if ( !v83 )
			//                 sub_1802DC2C8(0LL, v82);
			//               if ( TypeInfo::UnityEngine::Mathf.static_fields.Epsilon > System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::get_Item(
			//                                                                             v83,
			//                                                                             (Object *)hgCamera,
			//                                                                             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::get_Item).timeFadingFactor )
			//               {
			//                 v85 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)current[5].monitor;
			//                 if ( !v85 )
			//                   sub_1802DC2C8(0LL, v84);
			//                 System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Remove(
			//                   v85,
			//                   (Object *)hgCamera,
			//                   MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Remove);
			//                 goto LABEL_36;
			//               }
			//             }
			//             v86 = 0;
			//             v87 = (Object *)hgCamera;
			//             if ( hgCamera )
			//             {
			//               v88 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)current[5].monitor;
			//               if ( !v88 )
			//                 sub_1802DC2C8(0LL, hgCamera);
			//               if ( !System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::ContainsKey(
			//                       v88,
			//                       (Object *)hgCamera,
			//                       MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::ContainsKey) )
			//               {
			//                 v90 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)current[5].monitor;
			//                 if ( !v90 )
			//                   sub_1802DC2C8(0LL, v89);
			//                 System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Add(
			//                   v90,
			//                   (Object *)hgCamera,
			//                   (HGEnvironmentVolume_InterpolateDataPerCamera)_mm_cvtsi128_si32((__m128i)0LL),
			//                   MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::Add);
			//               }
			//               v86 = 1;
			//               v91 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)current[5].monitor;
			//               if ( !v91 )
			//                 sub_1802DC2C8(0LL, v89);
			//               klass_high = _mm_cvtsi32_si128((unsigned int)System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::get_Item(
			//                                                              v91,
			//                                                              (Object *)hgCamera,
			//                                                              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::get_Item).timeFadingFactor);
			//               v87 = (Object *)hgCamera;
			//             }
			//             else
			//             {
			//               klass_high = (__m128i)HIDWORD(current[5].klass);
			//             }
			//             if ( *(float *)v30.m128d_f64 > TypeInfo::UnityEngine::Mathf.static_fields.Epsilon )
			//             {
			//               if ( !v80 || LOBYTE(current[5].klass) )
			//               {
			//                 *(float *)klass_high.m128i_i32 = *(float *)klass_high.m128i_i32
			//                                                - (float)((float)(*(float *)v30.m128d_f64 * m_interpolateTimeFactor)
			//                                                        / *(float *)&current[3].monitor);
			//               }
			//               else
			//               {
			//                 v93 = (__m128i)v30;
			//                 *(float *)v93.m128i_i32 = (float)((float)(*(float *)v30.m128d_f64 * m_interpolateTimeFactor)
			//                                                 / *((float *)&current[3].klass + 1))
			//                                         + *(float *)klass_high.m128i_i32;
			//                 klass_high = v93;
			//               }
			//             }
			//             if ( *(float *)klass_high.m128i_i32 >= 0.0 )
			//             {
			//               if ( *(float *)klass_high.m128i_i32 > 1.0 )
			//                 klass_high = (__m128i)0x3F800000u;
			//             }
			//             else
			//             {
			//               klass_high = 0LL;
			//             }
			//             if ( v86 )
			//             {
			//               v94 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolume_InterpolateDataPerCamera_ *)current[5].monitor;
			//               if ( !v94 )
			//                 sub_1802DC2C8(0LL, v87);
			//               System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::set_Item(
			//                 v94,
			//                 v87,
			//                 (HGEnvironmentVolume_InterpolateDataPerCamera)_mm_cvtsi128_si32(klass_high),
			//                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolume::InterpolateDataPerCamera>::set_Item);
			//             }
			//             else
			//             {
			//               HIDWORD(current[5].klass) = klass_high.m128i_i32[0];
			//             }
			//             v37 = interpolatedVolumes;
			//             if ( *(float *)klass_high.m128i_i32 > TypeInfo::UnityEngine::Mathf.static_fields.Epsilon )
			//             {
			//               v95 = (HGEnvironmentPhase *)sub_18004A6C0(12LL, current);
			//               if ( !interpolatedPhaseTarget )
			//                 sub_1802DC2C8(v97, v96);
			//               HG::Rendering::Runtime::HGEnvironmentPhase::Lerp(
			//                 interpolatedPhaseTarget,
			//                 interpolatedPhaseTarget,
			//                 v95,
			//                 *(float *)klass_high.m128i_i32,
			//                 0LL);
			//               if ( !interpolatedVolumes )
			//                 sub_1802DC2C8(v99, v98);
			//               Beyond::IndexedHashSet<System::Object>::Add(
			//                 (IndexedHashSet_1_System_Object_ *)interpolatedVolumes,
			//                 current,
			//                 MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Add);
			//               if ( !interpolatedVolumesFactor )
			//                 sub_1802DC2C8(v101, v100);
			//               v104 = MethodInfo::System::Collections::Generic::List<float>::Add;
			//               ++interpolatedVolumesFactor.fields._version;
			//               items = interpolatedVolumesFactor.fields._items;
			//               size = interpolatedVolumesFactor.fields._size;
			//               if ( !items )
			//                 sub_1802DC2C8(0LL, size);
			//               if ( (unsigned int)size < items.max_length.size )
			//               {
			//                 interpolatedVolumesFactor.fields._size = size + 1;
			//                 if ( (unsigned int)size >= items.max_length.size )
			//                   sub_180070260(items, size, v102, v103);
			//                 LODWORD(items.vector[size]) = klass_high.m128i_i32[0];
			//               }
			//               else
			//               {
			//                 if ( !*((_QWORD *)v104.klass.rgctx_data[11].rgctxDataDummy + 4) )
			//                   (*(void (**)(void))v104.klass.rgctx_data[11].rgctxDataDummy)();
			//                 System::Collections::Generic::List<float>::AddWithResize(
			//                   interpolatedVolumesFactor,
			//                   *(float *)klass_high.m128i_i32,
			//                   (MethodInfo *)v104.klass.rgctx_data[11].rgctxDataDummy);
			//               }
			//             }
			//           }
			//           else if ( LODWORD(current[2].monitor) == 3
			//                  && *((float *)&current[3].monitor + 1) > TypeInfo::UnityEngine::Mathf.static_fields.Epsilon )
			//           {
			//             *(Vector3 *)&v166.fields._._File_k__BackingField = *UnityEngine::Transform::get_position(
			//                                                                   v175,
			//                                                                   interpolateTrigger,
			//                                                                   0LL);
			//             if ( HG::Rendering::Runtime::HGEnvironmentVolume::Contains(
			//                    (HGEnvironmentVolume *)current,
			//                    (Vector3 *)&v166.fields._._File_k__BackingField,
			//                    0LL) )
			//             {
			//               v71 = (HGEnvironmentPhase *)sub_18004A6C0(12LL, current);
			//               if ( !interpolatedPhaseTarget )
			//                 sub_1802DC2C8(v73, v72);
			//               HG::Rendering::Runtime::HGEnvironmentPhase::Lerp(
			//                 interpolatedPhaseTarget,
			//                 interpolatedPhaseTarget,
			//                 v71,
			//                 *((float *)&current[3].monitor + 1),
			//                 0LL);
			//               if ( !v37 )
			//                 sub_1802DC2C8(v75, v74);
			//               Beyond::IndexedHashSet<System::Object>::Add(
			//                 (IndexedHashSet_1_System_Object_ *)v37,
			//                 current,
			//                 MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Add);
			//               if ( !interpolatedVolumesFactor )
			//                 sub_1802DC2C8(v77, v76);
			//               goto LABEL_122;
			//             }
			//           }
			//         }
			//         *(_QWORD *)&v164[0].x = 0LL;
			//         v164[0].z = 0.0;
			//         v118 = (void (__fastcall *)(Transform *, Vector3 *))qword_18D8F52E0;
			//         if ( !qword_18D8F52E0 )
			//         {
			//           v118 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_0(
			//                                                                 "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//           if ( !v118 )
			//           {
			//             v159 = sub_1802DBBE8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
			//             sub_18000F750(v159, 0LL);
			//           }
			//           qword_18D8F52E0 = (__int64)v118;
			//         }
			//         v118(interpolateTrigger, v164);
			//         v122 = *(_QWORD *)&v164[0].x;
			//         z = v164[0].z;
			//         if ( !byte_18D8EDC37 )
			//         {
			//           v120 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, 0LL);
			//           if ( (v120 & 1) != 0 )
			//           {
			//             v124 = ((unsigned int)v120 >> 1) & 0xFFFFFFF;
			//             switch ( (unsigned int)v120 >> 29 )
			//             {
			//               case 1u:
			//                 v125 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v124);
			//                 goto LABEL_213;
			//               case 2u:
			//                 v125 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v124);
			//                 goto LABEL_213;
			//               case 3u:
			//               case 6u:
			//                 v126 = ((unsigned int)v120 >> 1) & 0xFFFFFFF;
			//                 v120 = (unsigned int)v120 >> 29;
			//                 if ( (_DWORD)v120 )
			//                 {
			//                   if ( (_DWORD)v120 == 3 )
			//                   {
			//                     v125 = (void (__fastcall __noreturn **)())sub_180039480(v126);
			//                     goto LABEL_213;
			//                   }
			//                   if ( (_DWORD)v120 == 6 )
			//                   {
			//                     v127 = sub_1802DF9C0(v126);
			//                     v125 = (void (__fastcall __noreturn **)())sub_18005F4B0(v127, 0LL);
			//                     goto LABEL_213;
			//                   }
			//                 }
			//                 else if ( v126 == 1 )
			//                 {
			//                   v125 = off_18A2C5600;
			//                   goto LABEL_213;
			//                 }
			// LABEL_212:
			//                 v125 = 0LL;
			// LABEL_213:
			//                 if ( v125 )
			//                   _InterlockedExchange64((volatile __int64 *)&TypeInfo::IFix::ILFixDynamicMethodWrapper, (__int64)v125);
			//                 break;
			//               case 4u:
			//                 v125 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v124);
			//                 goto LABEL_213;
			//               case 5u:
			//                 if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v124) )
			//                 {
			//                   v125 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v124);
			//                 }
			//                 else
			//                 {
			//                   v121 = il2cpp_string_new_len(
			//                            qword_18D8E5198
			//                          + *(int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v124 + 4)
			//                          + *(int *)(qword_18D8E51A0 + 16),
			//                            *(unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v124));
			//                   v125 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                               (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v124),
			//                                                               v121,
			//                                                               0LL);
			//                   if ( !v125 )
			//                   {
			//                     v120 = qword_18D8F6F98 + 8 * v124;
			//                     if ( dword_18D8E43F8 )
			//                     {
			//                       v128 = (v120 >> 12) & 0x1FFFFF;
			//                       v119 = (unsigned __int64)v128 >> 6;
			//                       v120 = v128 & 0x3F;
			//                       _m_prefetchw(&qword_18D6870D0[v119]);
			//                       do
			//                         v129 = qword_18D6870D0[v119];
			//                       while ( v129 != _InterlockedCompareExchange64(&qword_18D6870D0[v119], v129 | (1LL << v120), v129) );
			//                     }
			//                     v125 = (void (__fastcall __noreturn **)())v121;
			//                   }
			//                 }
			//                 goto LABEL_213;
			//               case 7u:
			//                 v130 = sub_1802DF920((unsigned int)v124);
			//                 v131 = *(_QWORD *)(v130 + 16);
			//                 v132 = (v130 - *(_QWORD *)(v131 + 128)) >> 5;
			//                 if ( *(_BYTE *)(v131 + 42) == 21 )
			//                 {
			//                   v133 = *(_QWORD ***)(v131 + 96);
			//                   if ( *v133 )
			//                   {
			//                     v134 = **v133 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                     v131 = sub_180039550(v134 / 92 + v134);
			//                   }
			//                   else
			//                   {
			//                     v131 = 0LL;
			//                   }
			//                 }
			//                 LODWORD(v170.x) = v132 + *(_DWORD *)(*(_QWORD *)(v131 + 104) + 32LL);
			//                 v135 = sub_1801B8ECC(
			//                          (unsigned int)&v170,
			//                          (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                          *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                          12,
			//                          (__int64)sub_1802C7760);
			//                 if ( !v135 )
			//                   goto LABEL_212;
			//                 v119 = *(unsigned int *)(v135 + 8);
			//                 if ( (_DWORD)v119 == -1 )
			//                   goto LABEL_212;
			//                 v125 = (void (__fastcall __noreturn **)())(v119 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                 goto LABEL_213;
			//               default:
			//                 break;
			//             }
			//           }
			//           byte_18D8EDC37 = 1;
			//         }
			//         v136 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v119);
			//           v136 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//         }
			//         v137 = v136.static_fields.wrapperArray;
			//         if ( !v137 )
			//           sub_1802DC2C8(v136, 0LL);
			//         if ( v137.max_length.size > 594 )
			//         {
			//           if ( !v136._1.cctor_finished_or_no_cctor )
			//           {
			//             il2cpp_runtime_class_init_0(v136, v137);
			//             v136 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//           }
			//           v138 = v136.static_fields.wrapperArray;
			//           if ( !v138 )
			//             sub_1802DC2C8(0LL, v137);
			//           if ( v138.max_length.size <= 0x252u )
			//             sub_180070260(v138, v137, v120, v121);
			//           if ( v138[16].vector[18] )
			//             break;
			//         }
			//         *(_QWORD *)&v169.x = v122;
			//         v169.z = z;
			//         v37 = interpolatedVolumes;
			//         if ( HG::Rendering::Runtime::HGEnvironmentVolume::_DistanceToEdge((HGEnvironmentVolume *)current, &v169, 0LL) > 0.0 )
			//           goto LABEL_229;
			//       }
			//       v139 = IFix::WrappersManagerImpl::GetPatch(594, 0LL);
			//       if ( !v139 )
			//         sub_1802DC2C8(v141, v140);
			//       *(_QWORD *)&v168.x = v122;
			//       v168.z = z;
			//       v37 = interpolatedVolumes;
			//       if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_231(v139, current, &v168, 0LL) )
			//       {
			// LABEL_229:
			//         sub_180003EE0(current.klass);
			//         v142 = (HGEnvironmentPhase *)((__int64 (__fastcall *)(Object *, const PropertyInfo *))current.klass[1]._0.events)(
			//                                        current,
			//                                        current.klass[1]._0.properties);
			//         if ( !interpolatedPhaseTarget )
			//           sub_1802DC2C8(v144, v143);
			//         HG::Rendering::Runtime::HGEnvironmentPhase::CopyFrom(interpolatedPhaseTarget, v142, 0LL);
			//         v37 = interpolatedVolumes;
			//         if ( !interpolatedVolumes )
			//           sub_1802DC2C8(v146, v145);
			//         Beyond::IndexedHashSet<System::Object>::Add(
			//           (IndexedHashSet_1_System_Object_ *)interpolatedVolumes,
			//           current,
			//           MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolume>::Add);
			//         if ( !interpolatedVolumesFactor )
			//           sub_1802DC2C8(v148, v147);
			//         v151 = MethodInfo::System::Collections::Generic::List<float>::Add;
			//         ++interpolatedVolumesFactor.fields._version;
			//         v152 = interpolatedVolumesFactor.fields._items;
			//         v153 = interpolatedVolumesFactor.fields._size;
			//         if ( !v152 )
			//           sub_1802DC2C8(0LL, v153);
			//         if ( (unsigned int)v153 < v152.max_length.size )
			//         {
			//           interpolatedVolumesFactor.fields._size = v153 + 1;
			//           if ( (unsigned int)v153 >= v152.max_length.size )
			//             sub_180070260(v152, v153, v149, v150);
			//           v152.vector[v153] = 1.0;
			//         }
			//         else
			//         {
			//           if ( !*((_QWORD *)v151.klass.rgctx_data[11].rgctxDataDummy + 4) )
			//             (*(void (**)(void))v151.klass.rgctx_data[11].rgctxDataDummy)();
			//           System::Collections::Generic::List<float>::AddWithResize(
			//             interpolatedVolumesFactor,
			//             1.0,
			//             (MethodInfo *)v151.klass.rgctx_data[11].rgctxDataDummy);
			//         }
			//       }
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v174 )
			//   {
			//     v166.klass = (OneofDescriptor__Class *)v174.ex;
			//     if ( v166.klass )
			//       sub_18000F780(v166.klass);
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly Lazy<HGEnvironmentManager> s_instance;

		private readonly HashSet<HGEnvironmentVolume> m_activeVolumes;

		private readonly List<HGEnvironmentVolume> m_sortedVolumes;

		private readonly IndexedHashSet<HGEnvironmentVolume> m_interpolatedVolumes;

		private readonly List<float> m_interpolatedVolumesFactor;

		private readonly HGAtmosphereRenderer m_atmosphereRenderer;

		private readonly HGVolumetricFogRenderer m_volumetricFogRenderer;

		private readonly HGSkyRenderer m_skyRenderer;

		private readonly HGSkydomeStarRenderer m_talosStarRenderer;

		private readonly HGRainRenderer m_rainRenderer;

		private readonly HGSnowRenderer m_snowRenderer;

		private readonly HGEnvironmentPhase m_defaultPhase;

		private readonly HGEnvironmentPhase m_interpolatedPhase;

		private Transform m_interpolateTrigger;

		private Transform m_interpolateTriggerOverride;

		private bool m_sortNeeded;

		private float m_interpolateTimeFactor;

		private Vector3 m_lastInterpolateTriggerPosition;
	}
}
