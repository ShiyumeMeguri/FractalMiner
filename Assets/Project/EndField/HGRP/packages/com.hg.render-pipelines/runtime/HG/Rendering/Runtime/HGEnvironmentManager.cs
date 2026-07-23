using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGEnvironmentManager // TypeDefIndex: 37648
	{
		// Fields
		private static readonly Lazy<HGEnvironmentManager> s_instance; // 0x00
		private readonly HashSet<HGEnvironmentVolumeBase> m_activeVolumes; // 0x10
		private readonly List<HGEnvironmentVolumeBase> m_sortedVolumes; // 0x18
		private readonly IndexedHashSet<HGEnvironmentVolumeBase> m_interpolatedVolumes; // 0x20
		private readonly List<float> m_interpolatedVolumesFactor; // 0x28
		private readonly HGAtmosphereRenderer m_atmosphereRenderer; // 0x30
		private readonly HGVolumetricFogRenderer m_volumetricFogRenderer; // 0x38
		private readonly HGSkyRenderer m_skyRenderer; // 0x40
		private readonly HGSkydomeStarRenderer m_talosStarRenderer; // 0x48
		private readonly HGRainRenderer m_rainRenderer; // 0x50
		private readonly HGSnowRenderer m_snowRenderer; // 0x58
		private readonly HGEnvironmentPhase m_defaultPhase; // 0x60
		private readonly HGEnvironmentPhase m_interpolatedPhase; // 0x68
		private float m_timeOfDay; // 0x70
		private Transform m_interpolateTrigger; // 0x78
		private Transform m_interpolateTriggerOverride; // 0x80
		private bool m_sortNeeded; // 0x88
		private float m_interpolateTimeFactor; // 0x8C
		private Vector3 m_lastInterpolateTriggerPosition; // 0x90
	
		// Properties
		public static HGEnvironmentManager instance { get => default; } // 0x0000000183106530-0x00000001831065C0 
		// HGEnvironmentManager get_instance()
		HGEnvironmentManager *HG::Rendering::Runtime::HGEnvironmentManager::get_instance(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  int *wrapperArray; // rcx
		  struct HGEnvironmentManager__Class *v3; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray[6] <= 450 )
		    goto LABEL_5;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( (unsigned int)wrapperArray[6] <= 0x1C2 )
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !*((_QWORD *)wrapperArray + 454) )
		  {
		LABEL_5:
		    v3 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      v3 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager;
		    }
		    wrapperArray = (int *)v3->static_fields->s_instance;
		    if ( wrapperArray )
		      return (HGEnvironmentManager *)System::Lazy<System::Object>::get_Value(
		                                       (Lazy_1_Object_ *)wrapperArray,
		                                       MethodInfo::System::Lazy<HG::Rendering::Runtime::HGEnvironmentManager>::get_Value);
		LABEL_9:
		    sub_1800D8260(wrapperArray, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(450, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_208(Patch, 0LL);
		}
		
		public static bool initialized { get => default; } // 0x0000000189CE16F4-0x0000000189CE1764 
		// Boolean get_initialized()
		bool HG::Rendering::Runtime::HGEnvironmentManager::get_initialized(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  HGEnvironmentManager__StaticFields *static_fields; // rcx
		  LazyHelper *state; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  signed __int32 v6[10]; // [rsp+0h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1488, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->static_fields;
		    if ( static_fields->s_instance )
		    {
		      state = static_fields->s_instance->fields._state;
		      _InterlockedOr(v6, 0);
		      return state == 0LL;
		    }
		LABEL_5:
		    sub_1800D8260(static_fields, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1488, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		}
		
		public static HGAtmosphereRenderer s_atmosphereRenderer { get => default; } // 0x0000000189CE17C4-0x0000000189CE1820 
		// HGAtmosphereRenderer get_s_atmosphereRenderer()
		HGAtmosphereRenderer *HG::Rendering::Runtime::HGEnvironmentManager::get_s_atmosphereRenderer(MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1489, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return instance->fields.m_atmosphereRenderer;
		LABEL_5:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1489, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_607(Patch, 0LL);
		}
		
		public static HGVolumetricFogRenderer s_volumetricFogRenderer { get => default; } // 0x0000000189CE1934-0x0000000189CE1990 
		// HGVolumetricFogRenderer get_s_volumetricFogRenderer()
		HGVolumetricFogRenderer *HG::Rendering::Runtime::HGEnvironmentManager::get_s_volumetricFogRenderer(MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1490, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return instance->fields.m_volumetricFogRenderer;
		LABEL_5:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1490, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_608(Patch, 0LL);
		}
		
		public static HGSkyRenderer s_skyRenderer { get => default; } // 0x00000001839458D0-0x0000000183945950 
		// HGSkyRenderer get_s_skyRenderer()
		HGSkyRenderer *HG::Rendering::Runtime::HGEnvironmentManager::get_s_skyRenderer(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  HGEnvironmentManager *instance; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 1135 )
		    goto LABEL_20;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 0x46Fu )
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !wrapperArray[31].vector[19] )
		  {
		LABEL_20:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return instance->fields.m_skyRenderer;
		LABEL_9:
		    sub_1800D8260(wrapperArray, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1135, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_430(Patch, 0LL);
		}
		
		public static HGSkydomeStarRenderer s_talosRenderer { get => default; } // 0x0000000189CE18D8-0x0000000189CE1934 
		// HGSkydomeStarRenderer get_s_talosRenderer()
		HGSkydomeStarRenderer *HG::Rendering::Runtime::HGEnvironmentManager::get_s_talosRenderer(MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1491, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return instance->fields.m_talosStarRenderer;
		LABEL_5:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1491, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_609(Patch, 0LL);
		}
		
		public static HGRainRenderer s_rainRenderer { get => default; } // 0x0000000182EE2570-0x0000000182EE2670 
		// HGRainRenderer get_s_rainRenderer()
		HGRainRenderer *HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rax
		  Lazy_1_Object_ *static_fields; // rcx
		  int *klass; // rdx
		  void *Value; // rax
		  __int64 v6; // r8
		  ILFixDynamicMethodWrapper_2 *v7; // rax
		  Lazy_1_Object___Class *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (Lazy_1_Object_ *)v1->static_fields;
		  klass = (int *)static_fields->klass;
		  if ( !static_fields->klass )
		    goto LABEL_17;
		  if ( klass[6] <= 517 )
		    goto LABEL_35;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  klass = (int *)v1->static_fields;
		  v6 = *(_QWORD *)klass;
		  if ( !*(_QWORD *)klass )
		    goto LABEL_17;
		  if ( *(_DWORD *)(v6 + 24) <= 0x205u )
		    goto LABEL_32;
		  if ( !*(_QWORD *)(v6 + 4168) )
		  {
		LABEL_35:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v1->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v1);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (Lazy_1_Object_ *)v1->static_fields;
		    klass = (int *)static_fields->klass;
		    if ( !static_fields->klass )
		      goto LABEL_17;
		    if ( klass[6] <= 450 )
		      goto LABEL_11;
		    if ( !v1->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v1);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (Lazy_1_Object_ *)v1->static_fields;
		    v8 = static_fields->klass;
		    if ( !static_fields->klass )
		      goto LABEL_17;
		    if ( LODWORD(v8->_0.namespaze) > 0x1C2 )
		    {
		      if ( *(_QWORD *)&v8[9]._1.instance_size )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(450, 0LL);
		        if ( !Patch )
		          goto LABEL_17;
		        Value = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_208(Patch, 0LL);
		LABEL_15:
		        if ( Value )
		          return (HGRainRenderer *)*((_QWORD *)Value + 10);
		LABEL_17:
		        sub_1800D8260(static_fields, klass);
		      }
		LABEL_11:
		      if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      static_fields = (Lazy_1_Object_ *)TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->static_fields->s_instance;
		      if ( !static_fields )
		        goto LABEL_17;
		      Value = System::Lazy<System::Object>::get_Value(
		                static_fields,
		                MethodInfo::System::Lazy<HG::Rendering::Runtime::HGEnvironmentManager>::get_Value);
		      goto LABEL_15;
		    }
		LABEL_32:
		    sub_1800D2AB0(static_fields, klass);
		  }
		  v7 = IFix::WrappersManagerImpl::GetPatch(517, 0LL);
		  if ( !v7 )
		    goto LABEL_17;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_225(v7, 0LL);
		}
		
		public static HGSnowRenderer s_snowRenderer { get => default; } // 0x0000000182EE24F0-0x0000000182EE2570 
		// HGSnowRenderer get_s_snowRenderer()
		HGSnowRenderer *HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  HGEnvironmentManager *instance; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 521 )
		    goto LABEL_20;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 0x209u )
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !wrapperArray[14].vector[17] )
		  {
		LABEL_20:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return instance->fields.m_snowRenderer;
		LABEL_9:
		    sub_1800D8260(wrapperArray, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(521, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_226(Patch, 0LL);
		}
		
		public static IndexedHashSet<HGEnvironmentVolumeBase> s_interpolatedVolumes { get => default; } // 0x0000000189CE187C-0x0000000189CE18D8 
		// IndexedHashSet`1[HG.Rendering.Runtime.HGEnvironmentVolumeBase] get_s_interpolatedVolumes()
		IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedVolumes(
		        MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1087, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return instance->fields.m_interpolatedVolumes;
		LABEL_5:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1087, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_418(Patch, 0LL);
		}
		
		public static List<float> s_interpolatedVolumesFactor { get => default; } // 0x0000000189CE1820-0x0000000189CE187C 
		// List`1[System.Single] get_s_interpolatedVolumesFactor()
		List_1_System_Single_ *HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedVolumesFactor(
		        MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1089, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return instance->fields.m_interpolatedVolumesFactor;
		LABEL_5:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1089, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_419(Patch, 0LL);
		}
		
		public static HGEnvironmentPhase s_interpolatedPhase { get => default; } // 0x0000000183104890-0x0000000183104990 
		// HGEnvironmentPhase get_s_interpolatedPhase()
		HGEnvironmentPhase *HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedPhase(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rax
		  Lazy_1_Object_ *static_fields; // rcx
		  int *klass; // rdx
		  void *Value; // rax
		  __int64 v6; // r8
		  ILFixDynamicMethodWrapper_2 *v7; // rax
		  Lazy_1_Object___Class *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (Lazy_1_Object_ *)v1->static_fields;
		  klass = (int *)static_fields->klass;
		  if ( !static_fields->klass )
		    goto LABEL_17;
		  if ( klass[6] <= 449 )
		    goto LABEL_35;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  klass = (int *)v1->static_fields;
		  v6 = *(_QWORD *)klass;
		  if ( !*(_QWORD *)klass )
		    goto LABEL_17;
		  if ( *(_DWORD *)(v6 + 24) <= 0x1C1u )
		    goto LABEL_32;
		  if ( !*(_QWORD *)(v6 + 3624) )
		  {
		LABEL_35:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v1->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v1);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (Lazy_1_Object_ *)v1->static_fields;
		    klass = (int *)static_fields->klass;
		    if ( !static_fields->klass )
		      goto LABEL_17;
		    if ( klass[6] <= 450 )
		      goto LABEL_11;
		    if ( !v1->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v1);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (Lazy_1_Object_ *)v1->static_fields;
		    v8 = static_fields->klass;
		    if ( !static_fields->klass )
		      goto LABEL_17;
		    if ( LODWORD(v8->_0.namespaze) > 0x1C2 )
		    {
		      if ( *(_QWORD *)&v8[9]._1.instance_size )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(450, 0LL);
		        if ( !Patch )
		          goto LABEL_17;
		        Value = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_208(Patch, 0LL);
		LABEL_15:
		        if ( Value )
		          return (HGEnvironmentPhase *)*((_QWORD *)Value + 13);
		LABEL_17:
		        sub_1800D8260(static_fields, klass);
		      }
		LABEL_11:
		      if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      static_fields = (Lazy_1_Object_ *)TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->static_fields->s_instance;
		      if ( !static_fields )
		        goto LABEL_17;
		      Value = System::Lazy<System::Object>::get_Value(
		                static_fields,
		                MethodInfo::System::Lazy<HG::Rendering::Runtime::HGEnvironmentManager>::get_Value);
		      goto LABEL_15;
		    }
		LABEL_32:
		    sub_1800D2AB0(static_fields, klass);
		  }
		  v7 = IFix::WrappersManagerImpl::GetPatch(449, 0LL);
		  if ( !v7 )
		    goto LABEL_17;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_209(v7, 0LL);
		}
		
		public static float s_timeOfDay { get => default; set {} } // 0x0000000183C82670-0x0000000183C826F0 0x0000000189CE1A60-0x0000000189CE1AD4
		// Single get_s_timeOfDay()
		float HG::Rendering::Runtime::HGEnvironmentManager::get_s_timeOfDay(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  HGEnvironmentManager *instance; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 631 )
		    goto LABEL_20;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 0x277u )
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !wrapperArray[17].vector[19] )
		  {
		LABEL_20:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return instance->fields.m_timeOfDay;
		LABEL_9:
		    sub_1800D8260(wrapperArray, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(631, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52((ILFixDynamicMethodWrapper_6 *)Patch, 0LL);
		}
		

		// Void set_s_timeOfDay(Single)
		void HG::Rendering::Runtime::HGEnvironmentManager::set_s_timeOfDay(float value, MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1492, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		    {
		      instance->fields.m_timeOfDay = value;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1492, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86((ILFixDynamicMethodWrapper_20 *)Patch, value, 0LL);
		}
		
		public static Transform interpolateTriggerOverride { get => default; set {} } // 0x00000001831C9EF0-0x00000001831C9F70 0x0000000189CE19EC-0x0000000189CE1A60
		// Transform get_interpolateTriggerOverride()
		Transform *HG::Rendering::Runtime::HGEnvironmentManager::get_interpolateTriggerOverride(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  HGEnvironmentManager *instance; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 787 )
		    goto LABEL_20;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 0x313u )
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !wrapperArray[21].vector[31] )
		  {
		LABEL_20:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return instance->fields.m_interpolateTriggerOverride;
		LABEL_9:
		    sub_1800D8260(wrapperArray, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(787, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_313(Patch, 0LL);
		}
		

		// Void set_interpolateTriggerOverride(Transform)
		void HG::Rendering::Runtime::HGEnvironmentManager::set_interpolateTriggerOverride(Transform *value, MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1494, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		    {
		      instance->fields.m_interpolateTriggerOverride = value;
		      sub_18002D1B0((SingleFieldAccessor *)&instance->fields.m_interpolateTriggerOverride, v4, v6, v7, v9);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1494, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)value, 0LL);
		}
		
		public static bool sortNeeded { get => default; set {} } // 0x0000000189CE1990-0x0000000189CE19EC 0x0000000183D09C30-0x0000000183D09C80
		// Boolean get_sortNeeded()
		bool HG::Rendering::Runtime::HGEnvironmentManager::get_sortNeeded(MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1495, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return instance->fields.m_sortNeeded;
		LABEL_5:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1495, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		}
		

		// Void set_sortNeeded(Boolean)
		void HG::Rendering::Runtime::HGEnvironmentManager::set_sortNeeded(bool value, MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1472, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		    {
		      instance->fields.m_sortNeeded = value;
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1472, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_30 *)Patch, value, 0LL);
		}
		
		public static float interpolateTimeFactor { get => default; set {} } // 0x0000000189CE1764-0x0000000189CE17C4 0x00000001849B1290-0x00000001849B12F0
		// Single get_interpolateTimeFactor()
		float HG::Rendering::Runtime::HGEnvironmentManager::get_interpolateTimeFactor(MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1496, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return instance->fields.m_interpolateTimeFactor;
		LABEL_5:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1496, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52((ILFixDynamicMethodWrapper_6 *)Patch, 0LL);
		}
		

		// Void set_interpolateTimeFactor(Single)
		void HG::Rendering::Runtime::HGEnvironmentManager::set_interpolateTimeFactor(float value, MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1497, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		    {
		      instance->fields.m_interpolateTimeFactor = value;
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1497, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86((ILFixDynamicMethodWrapper_20 *)Patch, value, 0LL);
		}
		
	
		// Constructors
		public HGEnvironmentManager() {} // 0x00000001831D35B0-0x00000001831D3840
		// HGEnvironmentManager()
		void HG::Rendering::Runtime::HGEnvironmentManager::HGEnvironmentManager(HGEnvironmentManager *this, MethodInfo *method)
		{
		  HGAtmosphereRenderer *v3; // rax
		  Type *v4; // rdx
		  HGEnvironmentPhase *m_defaultPhase; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  HGVolumetricFogRenderer *v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  HGSkyRenderer *v11; // rax
		  HGSkyRenderer *v12; // rdi
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  HGSkydomeStarRenderer *v16; // rax
		  HGSkydomeStarRenderer *v17; // rdi
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  HGRainRenderer *v21; // rax
		  HGRainRenderer *v22; // rdi
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  HGSnowRenderer *v26; // rax
		  HGSnowRenderer *v27; // rdi
		  Type *v28; // rdx
		  PropertyInfo_1 *v29; // r8
		  Int32__Array **v30; // r9
		  HashSet_1_System_Object_ *v31; // rax
		  HashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *v32; // rdi
		  Type *v33; // rdx
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v36; // rax
		  List_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *v37; // rdi
		  Type *v38; // rdx
		  PropertyInfo_1 *v39; // r8
		  Int32__Array **v40; // r9
		  IndexedHashSet_1_System_Object_ *v41; // rax
		  IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *v42; // rdi
		  Type *v43; // rdx
		  PropertyInfo_1 *v44; // r8
		  Int32__Array **v45; // r9
		  LowLevelList_1_System_Object_ *v46; // rax
		  List_1_System_Single_ *v47; // rdi
		  Type *v48; // rdx
		  PropertyInfo_1 *v49; // r8
		  Int32__Array **v50; // r9
		  Type *v51; // rdx
		  PropertyInfo_1 *v52; // r8
		  Int32__Array **v53; // r9
		  HGEnvironmentPhase *v54; // rax
		  HGLightConfig *p_lightConfig; // rdi
		  Type *v56; // rdx
		  PropertyInfo_1 *v57; // r8
		  Int32__Array **v58; // r9
		  Vector3__StaticFields *static_fields; // rcx
		  float z; // eax
		  MethodInfo *v61; // [rsp+20h] [rbp-8h]
		  MethodInfo *v62; // [rsp+20h] [rbp-8h]
		  MethodInfo *v63; // [rsp+20h] [rbp-8h]
		  MethodInfo *v64; // [rsp+20h] [rbp-8h]
		  MethodInfo *v65; // [rsp+20h] [rbp-8h]
		  MethodInfo *v66; // [rsp+20h] [rbp-8h]
		  MethodInfo *v67; // [rsp+20h] [rbp-8h]
		  MethodInfo *v68; // [rsp+20h] [rbp-8h]
		  MethodInfo *v69; // [rsp+20h] [rbp-8h]
		  MethodInfo *v70; // [rsp+20h] [rbp-8h]
		  MethodInfo *v71; // [rsp+20h] [rbp-8h]
		  MethodInfo *v72; // [rsp+20h] [rbp-8h]
		
		  v3 = (HGAtmosphereRenderer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGAtmosphereRenderer);
		  if ( !v3 )
		    goto LABEL_2;
		  this->fields.m_atmosphereRenderer = v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_atmosphereRenderer, v4, v6, v7, v61);
		  v8 = (HGVolumetricFogRenderer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		  if ( !v8 )
		    goto LABEL_2;
		  this->fields.m_volumetricFogRenderer = v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_volumetricFogRenderer, v4, v9, v10, v62);
		  v11 = (HGSkyRenderer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGSkyRenderer);
		  v12 = v11;
		  if ( !v11 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGSkyRenderer::HGSkyRenderer(v11, 0LL);
		  this->fields.m_skyRenderer = v12;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_skyRenderer, v13, v14, v15, v63);
		  v16 = (HGSkydomeStarRenderer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGSkydomeStarRenderer);
		  v17 = v16;
		  if ( !v16 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGSkydomeStarRenderer::HGSkydomeStarRenderer(v16, 0LL);
		  this->fields.m_talosStarRenderer = v17;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_talosStarRenderer, v18, v19, v20, v64);
		  v21 = (HGRainRenderer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
		  v22 = v21;
		  if ( !v21 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGRainRenderer::HGRainRenderer(v21, 0LL);
		  this->fields.m_rainRenderer = v22;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_rainRenderer, v23, v24, v25, v65);
		  v26 = (HGSnowRenderer *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGSnowRenderer);
		  v27 = v26;
		  if ( !v26 )
		    goto LABEL_2;
		  HG::Rendering::Runtime::HGSnowRenderer::HGSnowRenderer(v26, 0LL);
		  this->fields.m_snowRenderer = v27;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_snowRenderer, v28, v29, v30, v66);
		  v31 = (HashSet_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>);
		  v32 = (HashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *)v31;
		  if ( !v31 )
		    goto LABEL_2;
		  System::Collections::Generic::HashSet<System::Object>::HashSet(
		    v31,
		    MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::HashSet);
		  this->fields.m_activeVolumes = v32;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v33, v34, v35, v67);
		  v36 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolumeBase>);
		  v37 = (List_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *)v36;
		  if ( !v36 )
		    goto LABEL_2;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v36,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::List);
		  this->fields.m_sortedVolumes = v37;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_sortedVolumes, v38, v39, v40, v68);
		  v41 = (IndexedHashSet_1_System_Object_ *)sub_1800368D0(TypeInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>);
		  v42 = (IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *)v41;
		  if ( !v41 )
		    goto LABEL_2;
		  Beyond::IndexedHashSet<System::Object>::IndexedHashSet(
		    v41,
		    MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::IndexedHashSet);
		  this->fields.m_interpolatedVolumes = v42;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_interpolatedVolumes, v43, v44, v45, v69);
		  v46 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<float>);
		  v47 = (List_1_System_Single_ *)v46;
		  if ( !v46 )
		    goto LABEL_2;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v46,
		    MethodInfo::System::Collections::Generic::List<float>::List);
		  this->fields.m_interpolatedVolumesFactor = v47;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_interpolatedVolumesFactor, v48, v49, v50, v70);
		  this->fields.m_defaultPhase = (HGEnvironmentPhase *)UnityEngine::ScriptableObject::CreateInstance<System::Object>(MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_defaultPhase, v51, v52, v53, v71);
		  m_defaultPhase = this->fields.m_defaultPhase;
		  if ( !m_defaultPhase
		    || (HG::Rendering::Runtime::HGEnvironmentPhase::ActivateAllEnvConfig(m_defaultPhase, 1, 0LL),
		        (v54 = this->fields.m_defaultPhase) == 0LL) )
		  {
		LABEL_2:
		    sub_1800D8260(m_defaultPhase, v4);
		  }
		  p_lightConfig = &v54->fields.lightConfig;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGLightConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
		  HG::Rendering::Runtime::HGLightConfig::UpdateDirectFinalDirection(p_lightConfig, 0.0, 0LL);
		  this->fields.m_interpolatedPhase = (HGEnvironmentPhase *)UnityEngine::ScriptableObject::CreateInstance<System::Object>(MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_interpolatedPhase, v56, v57, v58, v72);
		  this->fields.m_sortNeeded = 0;
		  this->fields.m_interpolateTimeFactor = 1.0;
		  static_fields = TypeInfo::UnityEngine::Vector3->static_fields;
		  z = static_fields->negativeInfinityVector.z;
		  *(_QWORD *)&this->fields.m_lastInterpolateTriggerPosition.x = *(_QWORD *)&static_fields->negativeInfinityVector.x;
		  this->fields.m_lastInterpolateTriggerPosition.z = z;
		}
		
		static HGEnvironmentManager() {} // 0x0000000184CE9170-0x0000000184CE9230
		// HGEnvironmentManager()
		void HG::Rendering::Runtime::HGEnvironmentManager::cctor(MethodInfo *method)
		{
		  struct HGEnvironmentManager_c__Class *v1; // rax
		  Object *v2; // rdi
		  Func_1_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Func_1_Object_ *v6; // rbx
		  Lazy_1_Object_ *v7; // rax
		  Type__Class *v8; // rdi
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  MethodInfo *v12; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (Func_1_Object_ *)sub_1800368D0(TypeInfo::System::Func<HG::Rendering::Runtime::HGEnvironmentManager>);
		  v6 = v3;
		  if ( !v3
		    || (System::Func<System::Object>::Func(
		          v3,
		          v2,
		          MethodInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c::__cctor_b__72_0,
		          0LL),
		        v7 = (Lazy_1_Object_ *)sub_1800368D0(TypeInfo::System::Lazy<HG::Rendering::Runtime::HGEnvironmentManager>),
		        (v8 = (Type__Class *)v7) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  System::Lazy<System::Object>::Lazy(
		    v7,
		    v6,
		    MethodInfo::System::Lazy<HG::Rendering::Runtime::HGEnvironmentManager>::Lazy);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->static_fields;
		  static_fields->klass = v8;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->static_fields,
		    static_fields,
		    v10,
		    v11,
		    v12);
		}
		
	
		// Methods
		public static HGEnvironmentPhase GetInterpolatedPhase(HGCamera hgCamera) => default; // 0x00000001831065C0-0x0000000183106760
		// HGEnvironmentPhase GetInterpolatedPhase(HGCamera)
		HGEnvironmentPhase *HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rdx
		  ILFixDynamicMethodWrapper_2__StaticFields *wrapperArray; // rcx
		  HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rdi
		  bool m_useEnvVolumeInterpolatedPhase; // cl
		  ILFixDynamicMethodWrapper_2__Array *v9; // r8
		  int32_t v10; // ecx
		  ILFixDynamicMethodWrapper_2 *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2__Array *v13; // r8
		  ILFixDynamicMethodWrapper_2 *v14; // rax
		  ILFixDynamicMethodWrapper_2__Array *v15; // r8
		  ILFixDynamicMethodWrapper_2 *v16; // rax
		  ILFixDynamicMethodWrapper_2__Array *v17; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = v2->static_fields;
		  wrapperArray = (ILFixDynamicMethodWrapper_2__StaticFields *)static_fields->wrapperArray;
		  if ( !static_fields->wrapperArray )
		    goto LABEL_29;
		  if ( SLODWORD(wrapperArray[3].wrapperArray) > 446 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = v2->static_fields;
		    v9 = static_fields->wrapperArray;
		    if ( !static_fields->wrapperArray )
		      goto LABEL_29;
		    if ( v9->max_length.size <= 0x1BEu )
		      goto LABEL_65;
		    if ( v9[12].vector[14] )
		    {
		      v10 = 446;
		      goto LABEL_36;
		    }
		  }
		  if ( !hgCamera )
		    goto LABEL_29;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields;
		  static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		  if ( !wrapperArray->wrapperArray )
		    goto LABEL_29;
		  if ( SLODWORD(static_fields[3].wrapperArray) <= 447 )
		    goto LABEL_10;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields;
		  static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		  if ( !wrapperArray->wrapperArray )
		    goto LABEL_29;
		  if ( LODWORD(static_fields[3].wrapperArray) <= 0x1BF )
		    goto LABEL_65;
		  if ( static_fields[451].wrapperArray )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(447, 0LL);
		    if ( !Patch )
		      goto LABEL_29;
		    m_envVolumeCameraComponent = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_207(Patch, (Object *)hgCamera, 0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_10:
		    m_envVolumeCameraComponent = hgCamera->fields.m_envVolumeCameraComponent;
		  }
		  if ( !m_envVolumeCameraComponent )
		    goto LABEL_29;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields;
		  static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		  if ( !wrapperArray->wrapperArray )
		    goto LABEL_29;
		  if ( SLODWORD(static_fields[3].wrapperArray) <= 448 )
		    goto LABEL_16;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = v2->static_fields;
		  v13 = static_fields->wrapperArray;
		  if ( !static_fields->wrapperArray )
		    goto LABEL_29;
		  if ( v13->max_length.size <= 0x1C0u )
		    goto LABEL_65;
		  if ( v13[12].vector[16] )
		  {
		    v14 = IFix::WrappersManagerImpl::GetPatch(448, 0LL);
		    if ( !v14 )
		      goto LABEL_29;
		    m_useEnvVolumeInterpolatedPhase = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                                        (ILFixDynamicMethodWrapper_20 *)v14,
		                                        (Object *)m_envVolumeCameraComponent,
		                                        0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_16:
		    m_useEnvVolumeInterpolatedPhase = m_envVolumeCameraComponent->fields.m_useEnvVolumeInterpolatedPhase;
		  }
		  if ( m_useEnvVolumeInterpolatedPhase )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v2->static_fields;
		    static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		    if ( !wrapperArray->wrapperArray )
		      goto LABEL_29;
		    if ( SLODWORD(static_fields[3].wrapperArray) <= 447 )
		      goto LABEL_22;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = v2->static_fields;
		    v15 = static_fields->wrapperArray;
		    if ( !static_fields->wrapperArray )
		      goto LABEL_29;
		    if ( v15->max_length.size <= 0x1BFu )
		      goto LABEL_65;
		    if ( v15[12].vector[15] )
		    {
		      v16 = IFix::WrappersManagerImpl::GetPatch(447, 0LL);
		      if ( !v16 )
		        goto LABEL_29;
		      hgCamera = (HGCamera *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_207(v16, (Object *)hgCamera, 0LL);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_22:
		      hgCamera = (HGCamera *)hgCamera->fields.m_envVolumeCameraComponent;
		    }
		    if ( !hgCamera )
		      goto LABEL_29;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v2->static_fields;
		    static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		    if ( !wrapperArray->wrapperArray )
		      goto LABEL_29;
		    if ( SLODWORD(static_fields[3].wrapperArray) <= 451 )
		      return (HGEnvironmentPhase *)hgCamera->fields._name_k__BackingField;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v2->static_fields;
		    v17 = wrapperArray->wrapperArray;
		    if ( !wrapperArray->wrapperArray )
		      goto LABEL_29;
		    if ( v17->max_length.size > 0x1C3u )
		    {
		      if ( !v17[12].vector[19] )
		        return (HGEnvironmentPhase *)hgCamera->fields._name_k__BackingField;
		      v10 = 451;
		LABEL_36:
		      v11 = IFix::WrappersManagerImpl::GetPatch(v10, 0LL);
		      if ( v11 )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_210(v11, (Object *)hgCamera, 0LL);
		LABEL_29:
		      sub_1800D8260(wrapperArray, static_fields);
		    }
		LABEL_65:
		    sub_1800D2AB0(wrapperArray, static_fields);
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  return HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedPhase(0LL);
		}
		
		public static List<float> GetInterpolatedVolumesFactor(HGCamera hgCamera) => default; // 0x0000000183CC5CF0-0x0000000183CC5E90
		// List`1[System.Single] GetInterpolatedVolumesFactor(HGCamera)
		List_1_System_Single_ *HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedVolumesFactor(
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rdx
		  ILFixDynamicMethodWrapper_2__StaticFields *wrapperArray; // rcx
		  HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rdi
		  bool m_useEnvVolumeInterpolatedPhase; // cl
		  ILFixDynamicMethodWrapper_2__Array *v9; // r8
		  int32_t v10; // ecx
		  ILFixDynamicMethodWrapper_2 *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2__Array *v13; // r8
		  ILFixDynamicMethodWrapper_2 *v14; // rax
		  ILFixDynamicMethodWrapper_2__Array *v15; // r8
		  ILFixDynamicMethodWrapper_2 *v16; // rax
		  ILFixDynamicMethodWrapper_2__Array *v17; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = v2->static_fields;
		  wrapperArray = (ILFixDynamicMethodWrapper_2__StaticFields *)static_fields->wrapperArray;
		  if ( !static_fields->wrapperArray )
		    goto LABEL_29;
		  if ( SLODWORD(wrapperArray[3].wrapperArray) > 1088 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = v2->static_fields;
		    v9 = static_fields->wrapperArray;
		    if ( !static_fields->wrapperArray )
		      goto LABEL_29;
		    if ( v9->max_length.size <= 0x440u )
		      goto LABEL_65;
		    if ( v9[30].vector[8] )
		    {
		      v10 = 1088;
		      goto LABEL_36;
		    }
		  }
		  if ( !hgCamera )
		    goto LABEL_29;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields;
		  static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		  if ( !wrapperArray->wrapperArray )
		    goto LABEL_29;
		  if ( SLODWORD(static_fields[3].wrapperArray) <= 447 )
		    goto LABEL_10;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields;
		  static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		  if ( !wrapperArray->wrapperArray )
		    goto LABEL_29;
		  if ( LODWORD(static_fields[3].wrapperArray) <= 0x1BF )
		    goto LABEL_65;
		  if ( static_fields[451].wrapperArray )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(447, 0LL);
		    if ( !Patch )
		      goto LABEL_29;
		    m_envVolumeCameraComponent = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_207(Patch, (Object *)hgCamera, 0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_10:
		    m_envVolumeCameraComponent = hgCamera->fields.m_envVolumeCameraComponent;
		  }
		  if ( !m_envVolumeCameraComponent )
		    goto LABEL_29;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields;
		  static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		  if ( !wrapperArray->wrapperArray )
		    goto LABEL_29;
		  if ( SLODWORD(static_fields[3].wrapperArray) <= 448 )
		    goto LABEL_16;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = v2->static_fields;
		  v13 = static_fields->wrapperArray;
		  if ( !static_fields->wrapperArray )
		    goto LABEL_29;
		  if ( v13->max_length.size <= 0x1C0u )
		    goto LABEL_65;
		  if ( v13[12].vector[16] )
		  {
		    v14 = IFix::WrappersManagerImpl::GetPatch(448, 0LL);
		    if ( !v14 )
		      goto LABEL_29;
		    m_useEnvVolumeInterpolatedPhase = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                                        (ILFixDynamicMethodWrapper_20 *)v14,
		                                        (Object *)m_envVolumeCameraComponent,
		                                        0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_16:
		    m_useEnvVolumeInterpolatedPhase = m_envVolumeCameraComponent->fields.m_useEnvVolumeInterpolatedPhase;
		  }
		  if ( m_useEnvVolumeInterpolatedPhase )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v2->static_fields;
		    static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		    if ( !wrapperArray->wrapperArray )
		      goto LABEL_29;
		    if ( SLODWORD(static_fields[3].wrapperArray) <= 447 )
		      goto LABEL_22;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = v2->static_fields;
		    v15 = static_fields->wrapperArray;
		    if ( !static_fields->wrapperArray )
		      goto LABEL_29;
		    if ( v15->max_length.size <= 0x1BFu )
		      goto LABEL_65;
		    if ( v15[12].vector[15] )
		    {
		      v16 = IFix::WrappersManagerImpl::GetPatch(447, 0LL);
		      if ( !v16 )
		        goto LABEL_29;
		      hgCamera = (HGCamera *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_207(v16, (Object *)hgCamera, 0LL);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_22:
		      hgCamera = (HGCamera *)hgCamera->fields.m_envVolumeCameraComponent;
		    }
		    if ( !hgCamera )
		      goto LABEL_29;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v2->static_fields;
		    static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		    if ( !wrapperArray->wrapperArray )
		      goto LABEL_29;
		    if ( SLODWORD(static_fields[3].wrapperArray) <= 790 )
		      return (List_1_System_Single_ *)hgCamera->fields._sceneRTSize_k__BackingField;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v2->static_fields;
		    v17 = wrapperArray->wrapperArray;
		    if ( !wrapperArray->wrapperArray )
		      goto LABEL_29;
		    if ( v17->max_length.size > 0x316u )
		    {
		      if ( !v17[22].bounds )
		        return (List_1_System_Single_ *)hgCamera->fields._sceneRTSize_k__BackingField;
		      v10 = 790;
		LABEL_36:
		      v11 = IFix::WrappersManagerImpl::GetPatch(v10, 0LL);
		      if ( v11 )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_316(v11, (Object *)hgCamera, 0LL);
		LABEL_29:
		      sub_1800D8260(wrapperArray, static_fields);
		    }
		LABEL_65:
		    sub_1800D2AB0(wrapperArray, static_fields);
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  return HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedVolumesFactor(0LL);
		}
		
		public static IndexedHashSet<HGEnvironmentVolumeBase> GetInterpolatedVolumes(HGCamera hgCamera) => default; // 0x0000000183CC5B50-0x0000000183CC5CF0
		// IndexedHashSet`1[HG.Rendering.Runtime.HGEnvironmentVolumeBase] GetInterpolatedVolumes(HGCamera)
		IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedVolumes(
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rdx
		  ILFixDynamicMethodWrapper_2__StaticFields *wrapperArray; // rcx
		  HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rdi
		  bool m_useEnvVolumeInterpolatedPhase; // cl
		  ILFixDynamicMethodWrapper_2__Array *v9; // r8
		  int32_t v10; // ecx
		  ILFixDynamicMethodWrapper_2 *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2__Array *v13; // r8
		  ILFixDynamicMethodWrapper_2 *v14; // rax
		  ILFixDynamicMethodWrapper_2__Array *v15; // r8
		  ILFixDynamicMethodWrapper_2 *v16; // rax
		  ILFixDynamicMethodWrapper_2__Array *v17; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = v2->static_fields;
		  wrapperArray = (ILFixDynamicMethodWrapper_2__StaticFields *)static_fields->wrapperArray;
		  if ( !static_fields->wrapperArray )
		    goto LABEL_29;
		  if ( SLODWORD(wrapperArray[3].wrapperArray) > 1086 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = v2->static_fields;
		    v9 = static_fields->wrapperArray;
		    if ( !static_fields->wrapperArray )
		      goto LABEL_29;
		    if ( v9->max_length.size <= 0x43Eu )
		      goto LABEL_65;
		    if ( v9[30].vector[6] )
		    {
		      v10 = 1086;
		      goto LABEL_36;
		    }
		  }
		  if ( !hgCamera )
		    goto LABEL_29;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields;
		  static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		  if ( !wrapperArray->wrapperArray )
		    goto LABEL_29;
		  if ( SLODWORD(static_fields[3].wrapperArray) <= 447 )
		    goto LABEL_10;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields;
		  static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		  if ( !wrapperArray->wrapperArray )
		    goto LABEL_29;
		  if ( LODWORD(static_fields[3].wrapperArray) <= 0x1BF )
		    goto LABEL_65;
		  if ( static_fields[451].wrapperArray )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(447, 0LL);
		    if ( !Patch )
		      goto LABEL_29;
		    m_envVolumeCameraComponent = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_207(Patch, (Object *)hgCamera, 0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_10:
		    m_envVolumeCameraComponent = hgCamera->fields.m_envVolumeCameraComponent;
		  }
		  if ( !m_envVolumeCameraComponent )
		    goto LABEL_29;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields;
		  static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		  if ( !wrapperArray->wrapperArray )
		    goto LABEL_29;
		  if ( SLODWORD(static_fields[3].wrapperArray) <= 448 )
		    goto LABEL_16;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = v2->static_fields;
		  v13 = static_fields->wrapperArray;
		  if ( !static_fields->wrapperArray )
		    goto LABEL_29;
		  if ( v13->max_length.size <= 0x1C0u )
		    goto LABEL_65;
		  if ( v13[12].vector[16] )
		  {
		    v14 = IFix::WrappersManagerImpl::GetPatch(448, 0LL);
		    if ( !v14 )
		      goto LABEL_29;
		    m_useEnvVolumeInterpolatedPhase = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                                        (ILFixDynamicMethodWrapper_20 *)v14,
		                                        (Object *)m_envVolumeCameraComponent,
		                                        0LL);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_16:
		    m_useEnvVolumeInterpolatedPhase = m_envVolumeCameraComponent->fields.m_useEnvVolumeInterpolatedPhase;
		  }
		  if ( m_useEnvVolumeInterpolatedPhase )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v2->static_fields;
		    static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		    if ( !wrapperArray->wrapperArray )
		      goto LABEL_29;
		    if ( SLODWORD(static_fields[3].wrapperArray) <= 447 )
		      goto LABEL_22;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = v2->static_fields;
		    v15 = static_fields->wrapperArray;
		    if ( !static_fields->wrapperArray )
		      goto LABEL_29;
		    if ( v15->max_length.size <= 0x1BFu )
		      goto LABEL_65;
		    if ( v15[12].vector[15] )
		    {
		      v16 = IFix::WrappersManagerImpl::GetPatch(447, 0LL);
		      if ( !v16 )
		        goto LABEL_29;
		      hgCamera = (HGCamera *)IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_207(v16, (Object *)hgCamera, 0LL);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_22:
		      hgCamera = (HGCamera *)hgCamera->fields.m_envVolumeCameraComponent;
		    }
		    if ( !hgCamera )
		      goto LABEL_29;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v2->static_fields;
		    static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		    if ( !wrapperArray->wrapperArray )
		      goto LABEL_29;
		    if ( SLODWORD(static_fields[3].wrapperArray) <= 789 )
		      return *(IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ **)&hgCamera->fields._taauRTSizeParam_k__BackingField.z;
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v2->static_fields;
		    v17 = wrapperArray->wrapperArray;
		    if ( !wrapperArray->wrapperArray )
		      goto LABEL_29;
		    if ( v17->max_length.size > 0x315u )
		    {
		      if ( !v17[22].monitor )
		        return *(IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ **)&hgCamera->fields._taauRTSizeParam_k__BackingField.z;
		      v10 = 789;
		LABEL_36:
		      v11 = IFix::WrappersManagerImpl::GetPatch(v10, 0LL);
		      if ( v11 )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_315(v11, (Object *)hgCamera, 0LL);
		LABEL_29:
		      sub_1800D8260(wrapperArray, static_fields);
		    }
		LABEL_65:
		    sub_1800D2AB0(wrapperArray, static_fields);
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  return HG::Rendering::Runtime::HGEnvironmentManager::get_s_interpolatedVolumes(0LL);
		}
		
		public static List<HGEnvironmentVolumeBase> CopyInterpolatedVolumesTo(HGCamera hgCamera, List<HGEnvironmentVolumeBase> buffer) => default; // 0x0000000189CE1624-0x0000000189CE16F4
		// List`1[HG.Rendering.Runtime.HGEnvironmentVolumeBase] CopyInterpolatedVolumesTo(HGCamera, List`1[HG.Rendering.Runtime.HGEnvironmentVolumeBase])
		List_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *HG::Rendering::Runtime::HGEnvironmentManager::CopyInterpolatedVolumesTo(
		        HGCamera *hgCamera,
		        List_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *buffer,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  int32_t v7; // ebx
		  IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *InterpolatedVolumes; // rsi
		  Object *Item; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v7 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1493, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1493, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_611(Patch, (Object *)hgCamera, (Object *)buffer, 0LL);
		LABEL_8:
		    sub_1800D8260(v6, v5);
		  }
		  if ( !buffer )
		    goto LABEL_8;
		  sub_183127A90(
		    buffer,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Clear);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  InterpolatedVolumes = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedVolumes(hgCamera, 0LL);
		  if ( !InterpolatedVolumes )
		    goto LABEL_8;
		  while ( v7 < Beyond::UniqueList<System::Object>::get_length(
		                 (UniqueList_1_System_Object_ *)InterpolatedVolumes,
		                 MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::get_Count) )
		  {
		    Item = Beyond::IndexedHashSet<System::Object>::get_Item(
		             (IndexedHashSet_1_System_Object_ *)InterpolatedVolumes,
		             v7,
		             MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::get_Item);
		    sub_182F01190((List_1_System_Object_ *)buffer, Item);
		    ++v7;
		  }
		  return buffer;
		}
		
		public static bool Register(HGEnvironmentVolumeBase volume) => default; // 0x000000018389EA40-0x000000018389EAA0
		// Boolean Register(HGEnvironmentVolumeBase)
		bool HG::Rendering::Runtime::HGEnvironmentManager::Register(HGEnvironmentVolumeBase *volume, MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1482, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return HG::Rendering::Runtime::HGEnvironmentManager::_Register(instance, volume, 0LL);
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1482, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)volume, 0LL);
		}
		
		public static bool Unregister(HGEnvironmentVolumeBase volume) => default; // 0x000000018389E8C0-0x000000018389E920
		// Boolean Unregister(HGEnvironmentVolumeBase)
		bool HG::Rendering::Runtime::HGEnvironmentManager::Unregister(HGEnvironmentVolumeBase *volume, MethodInfo *method)
		{
		  HGEnvironmentManager *instance; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1485, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		      return HG::Rendering::Runtime::HGEnvironmentManager::_Unregister(instance, volume, 0LL);
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1485, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)volume, 0LL);
		}
		
		public static void PipelineUpdate(List<Camera> cameras, HGSettingParameters settingParameters) {} // 0x0000000182EDFC60-0x0000000182EDFCF0
		// Void PipelineUpdate(List`1[UnityEngine.Camera], HGSettingParameters)
		void HG::Rendering::Runtime::HGEnvironmentManager::PipelineUpdate(
		        List_1_UnityEngine_Camera_ *cameras,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  HGEnvironmentManager *instance; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 610 )
		    goto LABEL_20;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_9;
		  if ( LODWORD(v5->_0.namespaze) <= 0x262 )
		    sub_1800D2AB0(v5, settingParameters);
		  if ( !v5[13]._0.namespaze )
		  {
		LABEL_20:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		    if ( instance )
		    {
		      HG::Rendering::Runtime::HGEnvironmentManager::_PipelineUpdate(instance, cameras, settingParameters, 0LL);
		      return;
		    }
		LABEL_9:
		    sub_1800D8260(v5, settingParameters);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(610, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)cameras,
		    (Object *)settingParameters,
		    0LL);
		}
		
		public static Transform GetFinalTrigger(Camera camera, Transform interpolateTrigger) => default; // 0x00000001831C9B60-0x00000001831C9DE0
		// Transform GetFinalTrigger(Camera, Transform)
		Transform *HG::Rendering::Runtime::HGEnvironmentManager::GetFinalTrigger(
		        Camera *camera,
		        Transform *interpolateTrigger,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  Transform *interpolateTriggerOverride; // rax
		  struct Object_1__Class *v8; // rcx
		  Transform *v9; // rbx
		  HGRenderPipeline *currentPipeline; // rax
		  struct Object_1__Class *v11; // rcx
		  Transform *currentEnvCenter; // rbx
		  HGRenderPipeline *v13; // rax
		  Camera *main; // rax
		  struct Object_1__Class *v16; // rcx
		  Camera *v17; // rbx
		  __int64 (__fastcall *v18)(Camera *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_33;
		  if ( wrapperArray->max_length.size <= 786 )
		    goto LABEL_53;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_33;
		  if ( LODWORD(v5->_0.namespaze) <= 0x312 )
		    sub_1800D2AB0(v5, interpolateTrigger);
		  if ( !*(_QWORD *)&v5[16]._1.naturalAligment )
		  {
		LABEL_53:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    interpolateTriggerOverride = HG::Rendering::Runtime::HGEnvironmentManager::get_interpolateTriggerOverride(0LL);
		    v8 = TypeInfo::UnityEngine::Object;
		    v9 = interpolateTriggerOverride;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v8 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v8 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( v9 )
		    {
		      if ( !v8->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v8);
		      if ( v9->fields._._.m_CachedPtr )
		      {
		        if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		        return HG::Rendering::Runtime::HGEnvironmentManager::get_interpolateTriggerOverride(0LL);
		      }
		    }
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		    if ( !currentPipeline )
		      goto LABEL_33;
		    v11 = TypeInfo::UnityEngine::Object;
		    currentEnvCenter = currentPipeline->fields.currentEnvCenter;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v11 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v11 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !currentEnvCenter )
		      goto LABEL_24;
		    if ( !v11->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v11);
		    if ( !currentEnvCenter->fields._._.m_CachedPtr )
		    {
		LABEL_24:
		      main = UnityEngine::Camera::get_main(0LL);
		      v16 = TypeInfo::UnityEngine::Object;
		      v17 = main;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v16 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v16 = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( !v17 )
		        return 0LL;
		      if ( !v16->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v16);
		      if ( !v17->fields._._._.m_CachedPtr )
		        return 0LL;
		      v18 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		      if ( !qword_18F36FBC0 )
		      {
		        v18 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Component::get_transform()");
		        qword_18F36FBC0 = (__int64)v18;
		      }
		      return (Transform *)v18(v17);
		    }
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    v13 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		    if ( v13 )
		      return v13->fields.currentEnvCenter;
		LABEL_33:
		    sub_1800D8260(v5, interpolateTrigger);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(786, 0LL);
		  if ( !Patch )
		    goto LABEL_33;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_314(Patch, (Object *)camera, (Object *)interpolateTrigger, 0LL);
		}
		
		public static void UpdateCameraComponent(HGCamera camera) {} // 0x00000001831CB200-0x00000001831CB2E0
		// Void UpdateCameraComponent(HGCamera)
		void HG::Rendering::Runtime::HGEnvironmentManager::UpdateCameraComponent(HGCamera *camera, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Camera *v5; // rsi
		  __int64 (__fastcall *v6)(Camera *); // rax
		  Transform *v7; // rdi
		  Transform *FinalTrigger; // rdi
		  HGEnvironmentManager *instance; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_12;
		  if ( wrapperArray->max_length.size <= 785 )
		    goto LABEL_26;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_12;
		  if ( LODWORD(v3->_0.namespaze) <= 0x311 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !*(_QWORD *)&v3[16]._1.interfaces_count )
		  {
		LABEL_26:
		    if ( camera )
		    {
		      v5 = camera->fields.camera;
		      if ( v5 )
		      {
		        v6 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		        if ( !qword_18F36FBC0 )
		        {
		          v6 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		          if ( !v6 )
		          {
		            v11 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		            sub_18007E1B0(v11, 0LL);
		          }
		          qword_18F36FBC0 = (__int64)v6;
		        }
		        v7 = (Transform *)v6(v5);
		        if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		        FinalTrigger = HG::Rendering::Runtime::HGEnvironmentManager::GetFinalTrigger(v5, v7, 0LL);
		        instance = HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		        if ( instance )
		        {
		          HG::Rendering::Runtime::HGEnvironmentManager::_UpdateCameraComponent(instance, camera, FinalTrigger, 0LL);
		          return;
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(785, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)camera, 0LL);
		}
		
		public static void PerCameraUpdate(HGCamera camera, ref ScriptableRenderContext renderContext) {} // 0x0000000182EDF860-0x0000000182EDFA90
		// Void PerCameraUpdate(HGCamera, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::HGEnvironmentManager::PerCameraUpdate(
		        HGCamera *camera,
		        ScriptableRenderContext *renderContext,
		        MethodInfo *method)
		{
		  ScriptableRenderContext *v4; // rsi
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  Object *instance; // rdi
		  HGAdditionalCameraData *m_AdditionalCameraData; // rax
		  int32_t hgRenderPath; // eax
		  HGAdditionalCameraData *v10; // rax
		  int32_t v11; // eax
		  HGRainRenderer *s_rainRenderer; // rax
		  HGSnowRenderer *s_snowRenderer; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v15; // rax
		  ILFixDynamicMethodWrapper_2 *v16; // rax
		  ILFixDynamicMethodWrapper_2 *v17; // rax
		  ILFixDynamicMethodWrapper_2 *v18; // rax
		
		  v4 = renderContext;
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_37;
		  if ( wrapperArray->max_length.size > 792 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    renderContext = (ScriptableRenderContext *)v5->static_fields->wrapperArray;
		    if ( !renderContext )
		      goto LABEL_37;
		    if ( LODWORD(renderContext[3].m_Ptr) <= 0x318 )
		      goto LABEL_74;
		    if ( renderContext[796].m_Ptr )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(792, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_327(Patch, (Object *)camera, v4, 0LL);
		        return;
		      }
		      goto LABEL_37;
		    }
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  instance = (Object *)HG::Rendering::Runtime::HGEnvironmentManager::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_37;
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  renderContext = (ScriptableRenderContext *)v5->static_fields;
		  if ( !renderContext->m_Ptr )
		    goto LABEL_37;
		  if ( *((int *)renderContext->m_Ptr + 6) > 793 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    renderContext = (ScriptableRenderContext *)v5->static_fields->wrapperArray;
		    if ( !renderContext )
		      goto LABEL_37;
		    if ( LODWORD(renderContext[3].m_Ptr) <= 0x319 )
		      goto LABEL_74;
		    if ( renderContext[797].m_Ptr )
		    {
		      v15 = IFix::WrappersManagerImpl::GetPatch(793, 0LL);
		      if ( v15 )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_325(v15, instance, (Object *)camera, v4, 0LL);
		        return;
		      }
		      goto LABEL_37;
		    }
		  }
		  if ( !camera )
		    goto LABEL_37;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  renderContext = (ScriptableRenderContext *)v5->static_fields->wrapperArray;
		  if ( !renderContext )
		    goto LABEL_37;
		  if ( SLODWORD(renderContext[3].m_Ptr) <= 794 )
		    goto LABEL_77;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  renderContext = (ScriptableRenderContext *)v5->static_fields->wrapperArray;
		  if ( !renderContext )
		    goto LABEL_37;
		  if ( LODWORD(renderContext[3].m_Ptr) <= 0x31A )
		    goto LABEL_74;
		  if ( !renderContext[798].m_Ptr )
		  {
		LABEL_77:
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    renderContext = (ScriptableRenderContext *)v5->static_fields->wrapperArray;
		    if ( !renderContext )
		      goto LABEL_37;
		    if ( SLODWORD(renderContext[3].m_Ptr) <= 703 )
		      goto LABEL_21;
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    renderContext = (ScriptableRenderContext *)v5->static_fields->wrapperArray;
		    if ( !renderContext )
		      goto LABEL_37;
		    if ( LODWORD(renderContext[3].m_Ptr) <= 0x2BF )
		      goto LABEL_74;
		    if ( renderContext[707].m_Ptr )
		    {
		      v17 = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		      if ( !v17 )
		        goto LABEL_37;
		      hgRenderPath = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                       (ILFixDynamicMethodWrapper_31 *)v17,
		                       (Object *)camera,
		                       0LL);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_21:
		      m_AdditionalCameraData = camera->fields.m_AdditionalCameraData;
		      if ( !m_AdditionalCameraData )
		        goto LABEL_37;
		      hgRenderPath = m_AdditionalCameraData->fields.hgRenderPath;
		    }
		    if ( hgRenderPath == 1 )
		      return;
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    renderContext = (ScriptableRenderContext *)v5->static_fields->wrapperArray;
		    if ( !renderContext )
		      goto LABEL_37;
		    if ( SLODWORD(renderContext[3].m_Ptr) <= 703 )
		      goto LABEL_28;
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( !v5 )
		      goto LABEL_37;
		    if ( LODWORD(v5->_0.namespaze) > 0x2BF )
		    {
		      if ( v5[15]._0.name )
		      {
		        v18 = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		        if ( !v18 )
		          goto LABEL_37;
		        v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v18, (Object *)camera, 0LL);
		        goto LABEL_30;
		      }
		LABEL_28:
		      v10 = camera->fields.m_AdditionalCameraData;
		      if ( !v10 )
		        goto LABEL_37;
		      v11 = v10->fields.hgRenderPath;
		LABEL_30:
		      if ( v11 == 2 )
		        return;
		LABEL_31:
		      if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
		      if ( s_rainRenderer )
		      {
		        HG::Rendering::Runtime::HGRainRenderer::UpdateRainAndWetnessData(s_rainRenderer, camera, v4, 0LL);
		        s_snowRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(0LL);
		        if ( s_snowRenderer )
		        {
		          HG::Rendering::Runtime::HGSnowRenderer::UpdateSnowData(s_snowRenderer, camera, v4, 0LL);
		          return;
		        }
		      }
		LABEL_37:
		      sub_1800D8260(v5, renderContext);
		    }
		LABEL_74:
		    sub_1800D2AB0(v5, renderContext);
		  }
		  v16 = IFix::WrappersManagerImpl::GetPatch(794, 0LL);
		  if ( !v16 )
		    goto LABEL_37;
		  if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v16, (Object *)camera, 0LL) )
		    goto LABEL_31;
		}
		
		private bool _Register(HGEnvironmentVolumeBase volume) => default; // 0x00000001838A0610-0x00000001838A0710
		// Boolean _Register(HGEnvironmentVolumeBase)
		bool HG::Rendering::Runtime::HGEnvironmentManager::_Register(
		        HGEnvironmentManager *this,
		        HGEnvironmentVolumeBase *volume,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HashSet_1_System_Object_ *m_activeVolumes; // rcx
		  int32_t i; // edi
		  List_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *m_sortedVolumes; // rax
		  List_1_System_Object_ *v9; // rcx
		  Object *Item; // rax
		  Object_1 *gameObject; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1483, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1483, 0LL);
		    if ( !Patch )
		      goto LABEL_13;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		             (ILFixDynamicMethodWrapper_33 *)Patch,
		             (Object *)this,
		             (Object *)volume,
		             0LL);
		  }
		  else
		  {
		    m_activeVolumes = (HashSet_1_System_Object_ *)this->fields.m_activeVolumes;
		    if ( !m_activeVolumes )
		      goto LABEL_13;
		    if ( System::Collections::Generic::HashSet<System::Object>::Contains(
		           m_activeVolumes,
		           (Object *)volume,
		           MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Contains) )
		    {
		      if ( !volume )
		        goto LABEL_13;
		      gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)volume, 0LL);
		      HG::Rendering::HGRPLogger::LogWarning(
		        gameObject,
		        (String *)"Env Volume already exist in activeVolumes, register failed",
		        0LL);
		      return 0;
		    }
		    else
		    {
		      m_activeVolumes = (HashSet_1_System_Object_ *)this->fields.m_activeVolumes;
		      if ( !m_activeVolumes )
		        goto LABEL_13;
		      System::Collections::Generic::HashSet<System::Object>::Add(
		        m_activeVolumes,
		        (Object *)volume,
		        MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Add);
		      for ( i = 0; ; ++i )
		      {
		        m_sortedVolumes = this->fields.m_sortedVolumes;
		        if ( !m_sortedVolumes )
		          goto LABEL_13;
		        v9 = (List_1_System_Object_ *)this->fields.m_sortedVolumes;
		        if ( i >= m_sortedVolumes->fields._size )
		          break;
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 v9,
		                 i,
		                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::get_Item);
		        if ( !volume )
		          goto LABEL_13;
		        if ( HG::Rendering::Runtime::HGEnvironmentVolumeBase::CompareTo(volume, (HGEnvironmentVolumeBase *)Item, 0LL) == -1 )
		        {
		          m_activeVolumes = (HashSet_1_System_Object_ *)this->fields.m_sortedVolumes;
		          if ( m_activeVolumes )
		          {
		            System::Collections::Generic::List<System::Object>::Insert(
		              (List_1_System_Object_ *)m_activeVolumes,
		              i,
		              (Object *)volume,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Insert);
		            return 1;
		          }
		LABEL_13:
		          sub_1800D8260(m_activeVolumes, v5);
		        }
		      }
		      System::Collections::Generic::List<System::Object>::Insert(
		        v9,
		        m_sortedVolumes->fields._size,
		        (Object *)volume,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Insert);
		      return 1;
		    }
		  }
		}
		
		private bool _Unregister(HGEnvironmentVolumeBase volume) => default; // 0x000000018389E920-0x000000018389E9D0
		// Boolean _Unregister(HGEnvironmentVolumeBase)
		bool HG::Rendering::Runtime::HGEnvironmentManager::_Unregister(
		        HGEnvironmentManager *this,
		        HGEnvironmentVolumeBase *volume,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HashSet_1_System_Object_ *m_activeVolumes; // rcx
		  bool v7; // al
		  Object_1 *gameObject; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1486, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1486, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		             (ILFixDynamicMethodWrapper_33 *)Patch,
		             (Object *)this,
		             (Object *)volume,
		             0LL);
		  }
		  else
		  {
		    m_activeVolumes = (HashSet_1_System_Object_ *)this->fields.m_activeVolumes;
		    if ( !m_activeVolumes )
		      goto LABEL_9;
		    v7 = System::Collections::Generic::HashSet<System::Object>::Contains(
		           m_activeVolumes,
		           (Object *)volume,
		           MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Contains);
		    if ( !volume )
		      goto LABEL_9;
		    if ( v7 )
		    {
		      m_activeVolumes = (HashSet_1_System_Object_ *)volume->fields.dataPerCameras;
		      volume->fields._timeFadingFactor_k__BackingField = 0.0;
		      if ( m_activeVolumes )
		      {
		        System::Collections::Generic::Dictionary<Beyond::Gameplay::Core::WaterVolumePtr,System::ValueTuple<float,System::Int32Enum,System::Object>>::Clear(
		          (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)m_activeVolumes,
		          MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::Clear);
		        m_activeVolumes = (HashSet_1_System_Object_ *)this->fields.m_activeVolumes;
		        if ( m_activeVolumes )
		        {
		          System::Collections::Generic::HashSet<System::Object>::Remove(
		            m_activeVolumes,
		            (Object *)volume,
		            MethodInfo::System::Collections::Generic::HashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Remove);
		          m_activeVolumes = (HashSet_1_System_Object_ *)this->fields.m_sortedVolumes;
		          if ( m_activeVolumes )
		          {
		            System::Collections::Generic::List<System::Object>::Remove(
		              (List_1_System_Object_ *)m_activeVolumes,
		              (Object *)volume,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Remove);
		            return 1;
		          }
		        }
		      }
		LABEL_9:
		      sub_1800D8260(m_activeVolumes, v5);
		    }
		    gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)volume, 0LL);
		    HG::Rendering::HGRPLogger::LogWarning(
		      gameObject,
		      (String *)"Env Volume not exist in activeVolumes, unregister failed",
		      0LL);
		    return 0;
		  }
		}
		
		private void _PipelineUpdate(List<Camera> cameras, HGSettingParameters settingParameters) {} // 0x0000000182EE0F70-0x0000000182EE24B0
		// Void _PipelineUpdate(List`1[UnityEngine.Camera], HGSettingParameters)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		void HG::Rendering::Runtime::HGEnvironmentManager::_PipelineUpdate(
		        HGEnvironmentManager *this,
		        List_1_UnityEngine_Camera_ *cameras,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  Object *v4; // r13
		  HGEnvironmentManager *v6; // r15
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v9; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  List_1_System_Object_ *m_sortedVolumes; // rdi
		  struct HGEnvironmentManager_c__Class *v14; // rcx
		  Comparison_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *_9__66_0; // rbx
		  Object *v16; // rsi
		  Comparison_1_Object_ *v17; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  Type *v20; // rdx
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  __int64 v26; // rdx
		  Transform *m_interpolateTrigger; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v28; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v29; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v30; // rbx
		  ILFixDynamicMethodWrapper_2 *v31; // rax
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  List_1_System_Single_ *m_interpolatedVolumesFactor; // rbx
		  struct Object_1__Class *v37; // rcx
		  Vector3 *p_m_lastInterpolateTriggerPosition; // rdx
		  Vector3__StaticFields *static_fields; // rcx
		  float z; // eax
		  struct Object_1__Class *v41; // rdx
		  Light *SunSourceLight; // rbx
		  struct Object_1__Class *z_low; // rcx
		  HGEnvironmentPhase *m_interpolatedPhase; // rdi
		  __int64 v45; // rdx
		  __int64 v46; // rcx
		  HGEnvironmentPhase *v47; // rdi
		  __int64 v48; // rdx
		  __int64 v49; // rcx
		  HGEnvironmentPhase *v50; // rdi
		  __int64 v51; // rdx
		  __int64 v52; // rcx
		  HGEnvironmentPhase *v53; // rdi
		  __int64 (__fastcall *v54)(Light *); // rax
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  __int64 v57; // rdi
		  __int64 (__fastcall *v58)(__int64); // rax
		  __int64 v59; // rax
		  __int64 v60; // rdx
		  __int64 v61; // rcx
		  __int64 v62; // rsi
		  HGEnvironmentPhase *v63; // rdi
		  void (__fastcall *v64)(__int64, Quaternion *); // rax
		  __int64 (__fastcall *v65)(Light *); // rax
		  GameObject *v66; // rax
		  __int64 v67; // rdx
		  __int64 v68; // rcx
		  Behaviour *v69; // rsi
		  PropertyInfo_1 *v70; // r8
		  Int32__Array **v71; // r9
		  Object *current; // rbx
		  __int64 v73; // rdx
		  __int64 v74; // rcx
		  __int64 v75; // r8
		  HGCamera *v76; // r12
		  struct ILFixDynamicMethodWrapper_2__Class *v77; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v78; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v79; // rcx
		  ILFixDynamicMethodWrapper_2 *v80; // r15
		  Call *v81; // rax
		  __m128i v82; // xmm1
		  __m128i v83; // xmm2
		  Object *anonObj; // r12
		  _DWORD *v85; // xmm2_8
		  __int64 v86; // rcx
		  __int64 v87; // rdx
		  __int64 v88; // rdi
		  Object__Array *managedStack; // r14
		  Il2CppClass *element_class; // rbx
		  Object__Class *klass; // rsi
		  Value_1 *currentTop; // r8
		  signed __int64 v93; // rcx
		  __int64 v94; // rdx
		  signed __int64 v95; // rdi
		  Object__Array *v96; // r14
		  Il2CppClass *v97; // rbx
		  HGCamera__Class *v98; // rsi
		  __int64 v99; // rdx
		  VirtualMachine *virtualMachine; // rcx
		  unsigned __int64 v101; // rdx
		  unsigned __int64 v102; // r8
		  struct MethodInfo *v103; // rsi
		  __int64 v104; // rbx
		  void (__fastcall __noreturn **v105)(); // rax
		  unsigned int v106; // eax
		  __int64 v107; // rax
		  signed __int64 v108; // r9
		  unsigned int v109; // r8d
		  signed __int64 v110; // rtt
		  __int64 v111; // rbx
		  __int64 v112; // rax
		  __int64 v113; // rbx
		  _QWORD **v114; // rcx
		  __int64 v115; // r8
		  __int64 v116; // rax
		  __int64 Value1; // rax
		  HGEnvironmentVolumeCameraComponent *m_envVolumeCameraComponent; // rdi
		  const Il2CppRGCTXData *rgctx_data; // rax
		  _BYTE *rgctxDataDummy; // rbx
		  _BYTE *v121; // rax
		  HGEnvironmentVolumeCameraComponent__Class *v122; // rsi
		  HGEnvironmentPhase *interpolatedPhase; // rax
		  __int64 v124; // rdx
		  __int64 v125; // rcx
		  bool v126; // bl
		  Behaviour *v127; // rsi
		  ILFixDynamicMethodWrapper_2 *v128; // rax
		  HGEnvironmentPhase *v129; // rax
		  Object *lensFlareData; // rbx
		  Object *v131; // rdi
		  bool v132; // zf
		  unsigned __int64 v133; // rdx
		  signed __int64 v134; // rtt
		  Behaviour__Class *v135; // rbx
		  struct Object_1__Class *v136; // rcx
		  LensFlareCommonSRP *Instance; // rax
		  LensFlareCommonSRP *v138; // rax
		  ILFixDynamicMethodWrapper_2 *v139; // rax
		  HGEnvironmentPhase *v140; // rax
		  HGEnvironmentPhase *v141; // rax
		  HGEnvironmentPhase *v142; // rax
		  HGEnvironmentPhase *v143; // rax
		  HGEnvironmentPhase *v144; // rax
		  HGEnvironmentPhase *v145; // rax
		  HGEnvironmentPhase *v146; // rax
		  HGEnvironmentPhase *v147; // rax
		  HGEnvironmentPhase *v148; // rax
		  Vector3 *v149; // rax
		  HGEnvironmentPhase *v150; // rax
		  __int128 v151; // xmm6
		  __int128 v152; // xmm7
		  __int128 v153; // xmm8
		  __int128 v154; // xmm9
		  __int128 v155; // xmm10
		  __int128 v156; // xmm11
		  __int64 v157; // xmm12_8
		  float shb8; // ebx
		  void (__fastcall *v159)(_QWORD); // rax
		  void (__fastcall *v160)(_QWORD); // rax
		  void (__fastcall *v161)(__int64); // rax
		  void (__fastcall *v162)(_OWORD *); // rax
		  void (__fastcall *v163)(__int64); // rax
		  HGRainRenderer *s_rainRenderer; // rax
		  HGSnowRenderer *s_snowRenderer; // rax
		  __int64 v166; // rax
		  __int64 v167; // rax
		  __int64 v168; // rax
		  __int64 v169; // rax
		  __int64 v170; // rax
		  __int64 v171; // rax
		  __int64 v172; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-208h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-208h]
		  Vector3 v175; // [rsp+50h] [rbp-1D8h] BYREF
		  _BYTE v176[24]; // [rsp+60h] [rbp-1C8h] BYREF
		  Call call; // [rsp+80h] [rbp-1A8h] BYREF
		  Behaviour *v178; // [rsp+A8h] [rbp-180h]
		  List_1_T_Enumerator_System_Object_ v179; // [rsp+B0h] [rbp-178h] BYREF
		  Vector3 v180[2]; // [rsp+C8h] [rbp-160h] BYREF
		  Quaternion rotationDirect; // [rsp+E0h] [rbp-148h] BYREF
		  _OWORD v182[6]; // [rsp+F0h] [rbp-138h] BYREF
		  __int64 v183; // [rsp+150h] [rbp-D8h]
		  float v184; // [rsp+158h] [rbp-D0h]
		  Call v185[4]; // [rsp+160h] [rbp-C8h] BYREF
		
		  v4 = (Object *)settingParameters;
		  v6 = this;
		  memset(&v179, 0, sizeof(v179));
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v7, cameras);
		  if ( wrapperArray->max_length.size > 611 )
		  {
		    if ( !v7->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v7);
		      v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v9 = v7->static_fields->wrapperArray;
		    if ( !v9 )
		      sub_1800D8260(v7, cameras);
		    if ( v9->max_length.size <= 0x263u )
		      sub_1800D2AB0(v7, cameras);
		    if ( v9[17].max_length.value )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(611, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v12, v11);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		        (ILFixDynamicMethodWrapper_30 *)Patch,
		        (Object *)v6,
		        (Object *)cameras,
		        v4,
		        0LL);
		      return;
		    }
		  }
		  if ( v6->fields.m_sortNeeded )
		  {
		    m_sortedVolumes = (List_1_System_Object_ *)v6->fields.m_sortedVolumes;
		    v14 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c);
		      v14 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c;
		    }
		    _9__66_0 = v14->static_fields->__9__66_0;
		    if ( !_9__66_0 )
		    {
		      if ( !v14->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v14);
		        v14 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c;
		      }
		      v16 = (Object *)v14->static_fields->__9;
		      v17 = (Comparison_1_Object_ *)sub_1800368D0(TypeInfo::System::Comparison<HG::Rendering::Runtime::HGEnvironmentVolumeBase>);
		      _9__66_0 = (Comparison_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *)v17;
		      if ( !v17 )
		        sub_1800D8260(v19, v18);
		      System::Comparison<System::Object>::Comparison(
		        v17,
		        v16,
		        MethodInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c::__PipelineUpdate_b__66_0,
		        0LL);
		      TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c->static_fields->__9__66_0 = _9__66_0;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager::__c->static_fields->__9__66_0,
		        v20,
		        v21,
		        v22,
		        methoda);
		    }
		    if ( !m_sortedVolumes )
		      sub_1800D8260(v14, cameras);
		    System::Collections::Generic::List<System::Object>::Sort(
		      m_sortedVolumes,
		      (Comparison_1_Object_ *)_9__66_0,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Sort);
		    v6->fields.m_sortNeeded = 0;
		  }
		  if ( !v6->fields.m_interpolatedPhase )
		    sub_1800D8260(v7, cameras);
		  HG::Rendering::Runtime::HGEnvironmentPhase::AssignFrom(v6->fields.m_interpolatedPhase, v6->fields.m_defaultPhase, 0LL);
		  v6->fields.m_interpolateTrigger = HG::Rendering::Runtime::HGEnvironmentManager::_GetInterpolateTrigger(v6, 0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&v6->fields.m_interpolateTrigger, v23, v24, v25, methoda);
		  m_interpolateTrigger = v6->fields.m_interpolateTrigger;
		  v28 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v28 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v29 = v28->static_fields->wrapperArray;
		  if ( !v29 )
		    sub_1800D8260(v28, v26);
		  if ( v29->max_length.size <= 621 )
		    goto LABEL_34;
		  if ( !v28->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v28);
		    v28 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v30 = v28->static_fields->wrapperArray;
		  if ( !v30 )
		    sub_1800D8260(v28, v26);
		  if ( v30->max_length.size <= 0x26Du )
		    sub_1800D2AB0(v28, v26);
		  if ( !v30[17].vector[9] )
		  {
		LABEL_34:
		    if ( !v6->fields.m_interpolatedVolumes )
		      sub_1800D8260(v28, v26);
		    Beyond::IndexedHashSet<System::Object>::Clear(
		      (IndexedHashSet_1_System_Object_ *)v6->fields.m_interpolatedVolumes,
		      MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Clear);
		    m_interpolatedVolumesFactor = v6->fields.m_interpolatedVolumesFactor;
		    if ( !m_interpolatedVolumesFactor )
		      sub_1800D8260(v35, v34);
		    ++m_interpolatedVolumesFactor->fields._version;
		    m_interpolatedVolumesFactor->fields._size = 0;
		    v37 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v37 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v37 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( m_interpolateTrigger )
		    {
		      if ( !v37->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v37);
		      p_m_lastInterpolateTriggerPosition = &v6->fields.m_lastInterpolateTriggerPosition;
		      if ( m_interpolateTrigger->fields._._.m_CachedPtr )
		      {
		        HG::Rendering::Runtime::HGEnvironmentManager::_InterpolateVolumesImpl(
		          v6,
		          0LL,
		          m_interpolateTrigger,
		          v6->fields.m_interpolatedPhase,
		          &v6->fields.m_lastInterpolateTriggerPosition,
		          v6->fields.m_interpolatedVolumes,
		          v6->fields.m_interpolatedVolumesFactor,
		          0LL);
		        goto LABEL_46;
		      }
		    }
		    else
		    {
		      p_m_lastInterpolateTriggerPosition = &v6->fields.m_lastInterpolateTriggerPosition;
		    }
		    static_fields = TypeInfo::UnityEngine::Vector3->static_fields;
		    z = static_fields->negativeInfinityVector.z;
		    *(_QWORD *)&p_m_lastInterpolateTriggerPosition->x = *(_QWORD *)&static_fields->negativeInfinityVector.x;
		    p_m_lastInterpolateTriggerPosition->z = z;
		    goto LABEL_46;
		  }
		  v31 = IFix::WrappersManagerImpl::GetPatch(621, 0LL);
		  if ( !v31 )
		    sub_1800D8260(v33, v32);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)v31,
		    (Object *)v6,
		    (Object *)m_interpolateTrigger,
		    0LL);
		LABEL_46:
		  SunSourceLight = UnityEngine::Light::GetSunSourceLight(0LL);
		  z_low = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    z_low = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      z_low = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !SunSourceLight )
		    goto LABEL_235;
		  if ( !z_low->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(z_low);
		  if ( !SunSourceLight->fields._._._.m_CachedPtr )
		    goto LABEL_235;
		  m_interpolatedPhase = v6->fields.m_interpolatedPhase;
		  if ( !m_interpolatedPhase )
		    sub_1800D8260(z_low, v41);
		  *(Color *)v176 = m_interpolatedPhase->fields.lightConfig.directColor;
		  HG::Rendering::Runtime::HGEnvironmentUtils::SetColorIfNecessary(SunSourceLight, (Color *)v176, 0LL);
		  v47 = v6->fields.m_interpolatedPhase;
		  if ( !v47 )
		    sub_1800D8260(v46, v45);
		  HG::Rendering::Runtime::HGEnvironmentUtils::SetIntensityIfNecessary(
		    SunSourceLight,
		    v47->fields.lightConfig.directIntensityDividePi,
		    0LL);
		  v50 = v6->fields.m_interpolatedPhase;
		  if ( !v50 )
		    sub_1800D8260(v49, v48);
		  HG::Rendering::Runtime::HGEnvironmentUtils::SetSpecularIntensityIfNecessary(
		    SunSourceLight,
		    v50->fields.lightConfig.directSpecularIntensity,
		    0LL);
		  v53 = v6->fields.m_interpolatedPhase;
		  if ( !v53 )
		    sub_1800D8260(v52, v51);
		  HG::Rendering::Runtime::HGEnvironmentUtils::SetSoftSourceRaidiusIfNecessary(
		    SunSourceLight,
		    v53->fields.lightConfig.directSoftSourceRadius,
		    0LL);
		  v54 = (__int64 (__fastcall *)(Light *))qword_18F36FBC8;
		  if ( !qword_18F36FBC8 )
		  {
		    v54 = (__int64 (__fastcall *)(Light *))sub_180059EA0("UnityEngine.Component::get_gameObject()");
		    qword_18F36FBC8 = (__int64)v54;
		  }
		  v57 = v54(SunSourceLight);
		  if ( !v57 )
		    sub_1800D8260(v56, v55);
		  v58 = (__int64 (__fastcall *)(__int64))qword_18F36FC30;
		  if ( !qword_18F36FC30 )
		  {
		    v58 = (__int64 (__fastcall *)(__int64))sub_180059EA0("UnityEngine.GameObject::get_transform()");
		    qword_18F36FC30 = (__int64)v58;
		  }
		  v59 = v58(v57);
		  v62 = v59;
		  v63 = v6->fields.m_interpolatedPhase;
		  if ( !v63 )
		    sub_1800D8260(v61, v60);
		  if ( !v59 )
		    sub_1800D8260(v61, v60);
		  rotationDirect = v63->fields.lightConfig.rotationDirect;
		  v64 = (void (__fastcall *)(__int64, Quaternion *))qword_18F370118;
		  if ( !qword_18F370118 )
		  {
		    v64 = (void (__fastcall *)(__int64, Quaternion *))sub_180059EA0(
		                                                        "UnityEngine.Transform::set_rotation_Injected(UnityEngine.Quaternion&)");
		    qword_18F370118 = (__int64)v64;
		  }
		  v64(v62, &rotationDirect);
		  v65 = (__int64 (__fastcall *)(Light *))qword_18F36FBC8;
		  if ( !qword_18F36FBC8 )
		  {
		    v65 = (__int64 (__fastcall *)(Light *))sub_180059EA0("UnityEngine.Component::get_gameObject()");
		    qword_18F36FBC8 = (__int64)v65;
		  }
		  v66 = (GameObject *)v65(SunSourceLight);
		  if ( !v66 )
		    sub_1800D8260(v68, v67);
		  v69 = (Behaviour *)UnityEngine::GameObject::GetComponent<System::Object>(
		                       v66,
		                       MethodInfo::UnityEngine::GameObject::GetComponent<UnityEngine::Rendering::LensFlareComponentSRP>);
		  v178 = v69;
		  z_low = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    z_low = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      z_low = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !v69 )
		    goto LABEL_235;
		  if ( !z_low->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(z_low);
		  if ( !v69->fields._._.m_CachedPtr )
		    goto LABEL_235;
		  if ( !cameras )
		    sub_1800D8260(z_low, v41);
		  *(_OWORD *)&v176[8] = 0LL;
		  *(_QWORD *)v176 = cameras;
		  sub_18002D1B0((SingleFieldAccessor *)v176, (Type *)v41, v70, v71, methodb);
		  *(_DWORD *)&v176[8] = 0;
		  *(_DWORD *)&v176[12] = cameras->fields._version;
		  *(_QWORD *)&v176[16] = 0LL;
		  *(_OWORD *)&v179._list = *(_OWORD *)v176;
		  v179._current = 0LL;
		  *(_QWORD *)v176 = 0LL;
		  *(_QWORD *)&v176[8] = &v179;
		  while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		            &v179,
		            MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Camera>::MoveNext) )
		  {
		    current = v179._current;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    v76 = HG::Rendering::Runtime::HGCamera::GetOrCreate((Camera *)current, 0, 0LL);
		    *(_QWORD *)&v175.x = v76;
		    if ( !v76 )
		      sub_1800D8250(v74, v73);
		    v77 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v77 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v78 = v77->static_fields->wrapperArray;
		    if ( !v78 )
		      sub_1800D8250(v77, 0LL);
		    if ( v78->max_length.size <= 447 )
		      goto LABEL_174;
		    if ( !v77->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v77);
		      v77 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v78 = v77->static_fields->wrapperArray;
		    if ( !v78 )
		      sub_1800D8250(v77, 0LL);
		    if ( v78->max_length.size <= 0x1BFu )
		      sub_1800D2AA0(v77, v78, v75);
		    if ( v78[12].vector[15] )
		    {
		      if ( !v77->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v77);
		        v77 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v79 = v77->static_fields->wrapperArray;
		      if ( !v79 )
		        sub_1800D8250(0LL, v78);
		      if ( v79->max_length.size <= 0x1BFu )
		        sub_1800D2AA0(v79, v78, v75);
		      v80 = v79[12].vector[15];
		      if ( !v80 )
		        sub_1800D8250(v79, v78);
		      memset(&call, 0, sizeof(call));
		      v81 = IFix::Core::Call::Begin(v185, 0LL);
		      v82 = *(__m128i *)&v81->argumentBase;
		      *(_OWORD *)&call.argumentBase = *(_OWORD *)&v81->argumentBase;
		      v83 = *(__m128i *)&v81->managedStack;
		      *(__m128i *)&call.managedStack = v83;
		      call.topWriteBack = v81->topWriteBack;
		      if ( v80->fields.anonObj )
		      {
		        anonObj = v80->fields.anonObj;
		        v85 = (_DWORD *)_mm_srli_si128(v83, 8).m128i_u64[0];
		        v86 = (__int64)v85 - _mm_srli_si128(v82, 8).m128i_u64[0];
		        v87 = (unsigned __int128)(v86 * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		        v88 = v86 / 12;
		        if ( !v85 )
		          sub_1800D8250(v86, v87);
		        *v85 = 8;
		        if ( !call.currentTop )
		          sub_1800D8250(v86, v87);
		        call.currentTop->Value1 = v88;
		        managedStack = call.managedStack;
		        if ( !call.managedStack )
		          sub_1800D8250(v86, v87);
		        element_class = call.managedStack->klass->_0.element_class;
		        klass = anonObj->klass;
		        if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(element_class, anonObj->klass)
		          && ((BYTE1(klass->vtable.Equals.methodPtr) & 0x10) == 0
		           || ((element_class->flags & 0x20) == 0
		            && *((_BYTE *)&element_class->byval_arg + 10) != 19
		            && *((_BYTE *)&element_class->byval_arg + 10) != 30
		            || !element_class->interopData
		            || !element_class->interopData->guid
		            || !sub_1802ED414(anonObj))
		           && element_class != (Il2CppClass *)qword_18F35FF70) )
		        {
		          v166 = sub_18031E23C();
		          sub_18007E190(v166, 0LL);
		        }
		        sub_180005370(managedStack, (int)v88, anonObj);
		        currentTop = ++call.currentTop;
		        v76 = *(HGCamera **)&v175.x;
		      }
		      else
		      {
		        currentTop = call.currentTop;
		      }
		      v93 = (char *)currentTop - (char *)call.evaluationStackBase;
		      v94 = (unsigned __int128)(((char *)currentTop - (char *)call.evaluationStackBase) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		      v95 = currentTop - call.evaluationStackBase;
		      if ( !currentTop )
		        sub_1800D8250(v93, v94);
		      currentTop->Type = 8;
		      if ( !call.currentTop )
		        sub_1800D8250(v93, v94);
		      call.currentTop->Value1 = v95;
		      v96 = call.managedStack;
		      if ( !call.managedStack )
		        sub_1800D8250(v93, v94);
		      v97 = call.managedStack->klass->_0.element_class;
		      v98 = v76->klass;
		      if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v97, v76->klass)
		        && ((BYTE1(v98->vtable.Equals.methodPtr) & 0x10) == 0
		         || ((v97->flags & 0x20) == 0
		          && *((_BYTE *)&v97->byval_arg + 10) != 19
		          && *((_BYTE *)&v97->byval_arg + 10) != 30
		          || !v97->interopData
		          || !v97->interopData->guid
		          || !sub_1802ED414(v76))
		         && v97 != (Il2CppClass *)qword_18F35FF70) )
		      {
		        v167 = sub_18031E23C();
		        sub_18007E190(v167, 0LL);
		      }
		      sub_180005370(v96, (int)v95, v76);
		      ++call.currentTop;
		      virtualMachine = v80->fields.virtualMachine;
		      if ( !virtualMachine )
		        sub_1800D8250(0LL, v99);
		      IFix::Core::VirtualMachine::Execute(
		        virtualMachine,
		        v80->fields.methodId,
		        &call,
		        (v80->fields.anonObj != 0LL) + 1,
		        0,
		        0LL);
		      v103 = MethodInfo::IFix::Core::Call::GetAsType<HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent>;
		      if ( !MethodInfo::IFix::Core::Call::GetAsType<HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent>->rgctx_data )
		        sub_1800430B0(MethodInfo::IFix::Core::Call::GetAsType<HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent>);
		      if ( !byte_18F3963A0 )
		      {
		        v102 = _InterlockedExchangeAdd64((volatile signed __int64 *)&MethodInfo::IFix::Core::Call::GetObject, 0LL);
		        if ( (v102 & 1) != 0 )
		        {
		          v104 = ((unsigned int)v102 >> 1) & 0xFFFFFFF;
		          switch ( (unsigned int)v102 >> 29 )
		          {
		            case 1u:
		              v105 = (void (__fastcall __noreturn **)())sub_180036020((unsigned int)v104);
		              goto LABEL_154;
		            case 2u:
		              v105 = (void (__fastcall __noreturn **)())sub_1800362C0((unsigned int)v104);
		              goto LABEL_154;
		            case 3u:
		            case 6u:
		              v106 = ((unsigned int)v102 >> 1) & 0xFFFFFFF;
		              v102 = (unsigned int)v102 >> 29;
		              if ( (_DWORD)v102 )
		              {
		                if ( (_DWORD)v102 == 3 )
		                {
		                  v105 = (void (__fastcall __noreturn **)())sub_180009A40(v106);
		                  goto LABEL_154;
		                }
		                if ( (_DWORD)v102 == 6 )
		                {
		                  v107 = sub_1802F8800(v106);
		                  v105 = (void (__fastcall __noreturn **)())sub_180026660(v107, 0LL);
		                  goto LABEL_154;
		                }
		              }
		              else if ( v106 == 1 )
		              {
		                v105 = off_18B8C2EC0;
		                goto LABEL_154;
		              }
		LABEL_153:
		              v105 = 0LL;
		LABEL_154:
		              if ( v105 )
		                _InterlockedExchange64((volatile __int64 *)&MethodInfo::IFix::Core::Call::GetObject, (__int64)v105);
		              break;
		            case 4u:
		              v105 = (void (__fastcall __noreturn **)())sub_1802F8760((unsigned int)v104);
		              goto LABEL_154;
		            case 5u:
		              if ( *(_QWORD *)(qword_18F371F68 + 8 * v104) )
		              {
		                v105 = *(void (__fastcall __noreturn ***)())(qword_18F371F68 + 8 * v104);
		              }
		              else
		              {
		                v108 = il2cpp_string_new_len(
		                         qword_18F360DF8
		                       + *(int *)(qword_18F360DF8 + *(int *)(qword_18F360E00 + 8) + 8 * v104 + 4)
		                       + *(int *)(qword_18F360E00 + 16),
		                         *(unsigned int *)(qword_18F360DF8 + *(int *)(qword_18F360E00 + 8) + 8 * v104));
		                v105 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
		                                                            (volatile signed __int64 *)(qword_18F371F68 + 8 * v104),
		                                                            v108,
		                                                            0LL);
		                if ( !v105 )
		                {
		                  v102 = qword_18F371F68 + 8 * v104;
		                  if ( dword_18F35FD08 )
		                  {
		                    v109 = (v102 >> 12) & 0x1FFFFF;
		                    v101 = (unsigned __int64)v109 >> 6;
		                    v102 = v109 & 0x3F;
		                    _m_prefetchw(&qword_18F103690[v101]);
		                    do
		                      v110 = qword_18F103690[v101];
		                    while ( v110 != _InterlockedCompareExchange64(&qword_18F103690[v101], v110 | (1LL << v102), v110) );
		                  }
		                  v105 = (void (__fastcall __noreturn **)())v108;
		                }
		              }
		              goto LABEL_154;
		            case 7u:
		              v111 = sub_1802F8760((unsigned int)v104);
		              v112 = *(_QWORD *)(v111 + 16);
		              v113 = (v111 - *(_QWORD *)(v112 + 128)) >> 5;
		              if ( *(_BYTE *)(v112 + 42) == 21 )
		              {
		                v114 = *(_QWORD ***)(v112 + 96);
		                if ( *v114 )
		                {
		                  v115 = **v114 - (qword_18F360DF8 + *(int *)(qword_18F360E00 + 160));
		                  v112 = sub_180009B10(v115 / 92 + v115);
		                }
		                else
		                {
		                  v112 = 0LL;
		                }
		              }
		              LODWORD(v180[0].x) = v113 + *(_DWORD *)(*(_QWORD *)(v112 + 104) + 32LL);
		              v116 = sub_1801CD744(
		                       (unsigned int)v180,
		                       (int)qword_18F360DF8 + *(_DWORD *)(qword_18F360E00 + 64),
		                       *(int *)(qword_18F360E00 + 68) / 0xCuLL,
		                       12,
		                       (__int64)sub_1802F7130);
		              if ( !v116 )
		                goto LABEL_153;
		              v101 = *(unsigned int *)(v116 + 8);
		              if ( (_DWORD)v101 == -1 )
		                goto LABEL_153;
		              v105 = (void (__fastcall __noreturn **)())(v101 + qword_18F360DF8 + *(int *)(qword_18F360E00 + 72));
		              goto LABEL_154;
		            default:
		              break;
		          }
		        }
		        byte_18F3963A0 = 1;
		      }
		      if ( !call.argumentBase )
		        sub_1800D8250(0LL, v101);
		      Value1 = call.argumentBase->Value1;
		      if ( !call.managedStack )
		        sub_1800D8250(call.argumentBase, v101);
		      if ( (unsigned int)Value1 >= call.managedStack->max_length.size )
		        sub_1800D2AA0(call.argumentBase, v101, v102);
		      m_envVolumeCameraComponent = (HGEnvironmentVolumeCameraComponent *)call.managedStack->vector[Value1];
		      sub_180005370(call.managedStack, call.argumentBase - call.evaluationStackBase, 0LL);
		      rgctx_data = v103->rgctx_data;
		      rgctxDataDummy = rgctx_data->rgctxDataDummy;
		      if ( (*((_BYTE *)rgctx_data->rgctxDataDummy + 312) & 1) == 0 )
		      {
		        sub_1800360B0(rgctx_data->rgctxDataDummy, v78);
		        rgctxDataDummy = v121;
		      }
		      if ( m_envVolumeCameraComponent )
		      {
		        v122 = m_envVolumeCameraComponent->klass;
		        if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(rgctxDataDummy, m_envVolumeCameraComponent->klass)
		          && ((BYTE1(v122->vtable.Equals.methodPtr) & 0x10) == 0
		           || ((rgctxDataDummy[276] & 0x20) == 0 && rgctxDataDummy[42] != 19 && rgctxDataDummy[42] != 30
		            || !*((_QWORD *)rgctxDataDummy + 14)
		            || (v78 = *(ILFixDynamicMethodWrapper_2__Array **)(*((_QWORD *)rgctxDataDummy + 14) + 40LL)) == 0LL
		            || !sub_1802ED414(m_envVolumeCameraComponent))
		           && rgctxDataDummy != (_BYTE *)qword_18F35FF70) )
		        {
		          sub_18031E1F4(m_envVolumeCameraComponent, rgctxDataDummy);
		        }
		      }
		      else
		      {
		        m_envVolumeCameraComponent = 0LL;
		      }
		    }
		    else
		    {
		LABEL_174:
		      m_envVolumeCameraComponent = v76->fields.m_envVolumeCameraComponent;
		    }
		    if ( !m_envVolumeCameraComponent )
		      sub_1800D8250(v77, v78);
		    interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(
		                          m_envVolumeCameraComponent,
		                          0LL);
		    if ( !interpolatedPhase )
		      sub_1800D8250(v125, v124);
		    if ( interpolatedPhase->fields.lensFlareConfig.enable )
		    {
		      v126 = 1;
		      goto LABEL_180;
		    }
		  }
		  v126 = 0;
		LABEL_180:
		  if ( IFix::WrappersManagerImpl::IsPatched(646, 0LL) )
		  {
		    v128 = IFix::WrappersManagerImpl::GetPatch(646, 0LL);
		    if ( !v128 )
		      goto LABEL_302;
		    v127 = v178;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)v128, (Object *)v178, v126, 0LL);
		  }
		  else
		  {
		    v127 = v178;
		    if ( UnityEngine::Behaviour::get_enabled(v178, 0LL) != v126 )
		      UnityEngine::Behaviour::set_enabled(v127, v126, 0LL);
		  }
		  v6 = this;
		  v129 = this->fields.m_interpolatedPhase;
		  if ( !v129 )
		    goto LABEL_302;
		  if ( v129->fields.lensFlareConfig.enable )
		  {
		    lensFlareData = (Object *)v129->fields.lensFlareConfig.lensFlareData;
		    if ( IFix::WrappersManagerImpl::IsPatched(647, 0LL) )
		    {
		      v139 = IFix::WrappersManagerImpl::GetPatch(647, 0LL);
		      if ( !v139 )
		        goto LABEL_302;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)v139,
		        (Object *)v127,
		        lensFlareData,
		        0LL);
		    }
		    else
		    {
		      v131 = (Object *)v127[1].klass;
		      v41 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v41 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v41 = TypeInfo::UnityEngine::Object;
		        }
		      }
		      LOBYTE(z_low) = lensFlareData == 0LL;
		      if ( lensFlareData != 0LL || v131 != 0LL )
		      {
		        if ( lensFlareData )
		        {
		          if ( v131 )
		          {
		            v132 = v131 == lensFlareData;
		          }
		          else
		          {
		            if ( !v41->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(v41);
		            v132 = lensFlareData[1].klass == 0LL;
		          }
		        }
		        else
		        {
		          if ( !v41->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(v41);
		          if ( !v131 )
		            goto LABEL_302;
		          v132 = v131[1].klass == 0LL;
		        }
		        if ( !v132 )
		        {
		          v127[1].klass = (Behaviour__Class *)lensFlareData;
		          if ( dword_18F35FD08 )
		          {
		            v133 = (((unsigned __int64)&v127[1] >> 12) & 0x1FFFFF) >> 6;
		            _m_prefetchw(&qword_18F103690[v133]);
		            do
		              v134 = qword_18F103690[v133];
		            while ( v134 != _InterlockedCompareExchange64(
		                              &qword_18F103690[v133],
		                              v134 | (1LL << (((unsigned __int64)&v127[1] >> 12) & 0x3F)),
		                              v134) );
		          }
		          if ( !UnityEngine::Behaviour::get_isActiveAndEnabled(v127, 0LL) )
		            goto LABEL_309;
		          v135 = v127[1].klass;
		          v136 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v136 = TypeInfo::UnityEngine::Object;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              v136 = TypeInfo::UnityEngine::Object;
		            }
		          }
		          if ( !v135 )
		            goto LABEL_309;
		          if ( !v136->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(v136);
		          if ( v135->_0.name )
		          {
		            if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		            Instance = UnityEngine::Rendering::LensFlareCommonSRP::get_Instance(0LL);
		            if ( !Instance )
		              goto LABEL_302;
		            UnityEngine::Rendering::LensFlareCommonSRP::AddData(Instance, (LensFlareComponentSRP *)v127, 0LL);
		          }
		          else
		          {
		LABEL_309:
		            if ( !TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::LensFlareCommonSRP);
		            v138 = UnityEngine::Rendering::LensFlareCommonSRP::get_Instance(0LL);
		            if ( !v138 )
		              goto LABEL_302;
		            UnityEngine::Rendering::LensFlareCommonSRP::RemoveData(v138, (LensFlareComponentSRP *)v127, 0LL);
		          }
		        }
		      }
		    }
		    v140 = this->fields.m_interpolatedPhase;
		    if ( v140 )
		    {
		      *(float *)&v127[1].monitor = v140->fields.lensFlareConfig.intensity;
		      v141 = this->fields.m_interpolatedPhase;
		      if ( v141 )
		      {
		        *(float *)&v127[4].klass = v141->fields.lensFlareConfig.scale;
		        v142 = this->fields.m_interpolatedPhase;
		        if ( v142 )
		        {
		          LOBYTE(v127[3].monitor) = v142->fields.lensFlareConfig.useOcclusion;
		          v143 = this->fields.m_interpolatedPhase;
		          if ( v143 )
		          {
		            HIDWORD(v127[3].monitor) = LODWORD(v143->fields.lensFlareConfig.occlusionRadius);
		            v144 = this->fields.m_interpolatedPhase;
		            if ( v144 )
		            {
		              LODWORD(v127[3].fields._._.m_CachedPtr) = v144->fields.lensFlareConfig.sampleCount;
		              v145 = this->fields.m_interpolatedPhase;
		              if ( v145 )
		              {
		                HIDWORD(v127[3].fields._._.m_CachedPtr) = LODWORD(v145->fields.lensFlareConfig.occlusionOffset);
		                v146 = this->fields.m_interpolatedPhase;
		                if ( v146 )
		                {
		                  BYTE4(v127[4].klass) = v146->fields.lensFlareConfig.allowOffScreen;
		                  v147 = this->fields.m_interpolatedPhase;
		                  if ( v147 )
		                  {
		                    HIDWORD(v127[3].fields._._.m_CachedPtr) = LODWORD(v147->fields.lensFlareConfig.occlusionOffset);
		                    BYTE5(v127[4].klass) = 1;
		                    v148 = this->fields.m_interpolatedPhase;
		                    if ( v148 )
		                    {
		                      *(_QWORD *)&v175.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		                      v175.z = 1.0;
		                      *(Quaternion *)v176 = v148->fields.lightConfig.rotationLensFlare;
		                      v149 = UnityEngine::Quaternion::op_Multiply(v180, (Quaternion *)v176, &v175, 0LL);
		                      z_low = (struct Object_1__Class *)LODWORD(v149->z);
		                      v127[4].monitor = *(MonitorData **)&v149->x;
		                      LODWORD(v127[4].fields._._.m_CachedPtr) = (_DWORD)z_low;
		                      goto LABEL_234;
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_302:
		    sub_1800D8250(z_low, v41);
		  }
		LABEL_234:
		  v4 = (Object *)settingParameters;
		LABEL_235:
		  v150 = v6->fields.m_interpolatedPhase;
		  if ( !v150 )
		    goto LABEL_256;
		  v151 = *(_OWORD *)&v150->fields.skyConfig.skyAmbientSH.shr0;
		  v152 = *(_OWORD *)&v150->fields.skyConfig.skyAmbientSH.shr4;
		  v153 = *(_OWORD *)&v150->fields.skyConfig.skyAmbientSH.shr8;
		  v154 = *(_OWORD *)&v150->fields.skyConfig.skyAmbientSH.shg3;
		  v155 = *(_OWORD *)&v150->fields.skyConfig.skyAmbientSH.shg7;
		  v156 = *(_OWORD *)&v150->fields.skyConfig.skyAmbientSH.shb2;
		  v157 = *(_QWORD *)&v150->fields.skyConfig.skyAmbientSH.shb6;
		  shb8 = v150->fields.skyConfig.skyAmbientSH.shb8;
		  v159 = (void (__fastcall *)(_QWORD))qword_18F36F598;
		  if ( !qword_18F36F598 )
		  {
		    v159 = (void (__fastcall *)(_QWORD))il2cpp_resolve_icall_1("UnityEngine.RenderSettings::set_skybox(UnityEngine.Material)");
		    if ( !v159 )
		    {
		      v168 = sub_1802EE1B8("UnityEngine.RenderSettings::set_skybox(UnityEngine.Material)");
		      sub_18007E1B0(v168, 0LL);
		    }
		    qword_18F36F598 = (__int64)v159;
		  }
		  v159(0LL);
		  v160 = (void (__fastcall *)(_QWORD))qword_18F36F5A0;
		  if ( !qword_18F36F5A0 )
		  {
		    v160 = (void (__fastcall *)(_QWORD))il2cpp_resolve_icall_1("UnityEngine.RenderSettings::set_sun(UnityEngine.Light)");
		    if ( !v160 )
		    {
		      v169 = sub_1802EE1B8("UnityEngine.RenderSettings::set_sun(UnityEngine.Light)");
		      sub_18007E1B0(v169, 0LL);
		    }
		    qword_18F36F5A0 = (__int64)v160;
		  }
		  v160(0LL);
		  v161 = (void (__fastcall *)(__int64))qword_18F36F590;
		  if ( !qword_18F36F590 )
		  {
		    v161 = (void (__fastcall *)(__int64))il2cpp_resolve_icall_1(
		                                           "UnityEngine.RenderSettings::set_ambientMode(UnityEngine.Rendering.AmbientMode)");
		    if ( !v161 )
		    {
		      v170 = sub_1802EE1B8("UnityEngine.RenderSettings::set_ambientMode(UnityEngine.Rendering.AmbientMode)");
		      sub_18007E1B0(v170, 0LL);
		    }
		    qword_18F36F590 = (__int64)v161;
		  }
		  v161(4LL);
		  v182[0] = v151;
		  v182[1] = v152;
		  v182[2] = v153;
		  v182[3] = v154;
		  v182[4] = v155;
		  v182[5] = v156;
		  v183 = v157;
		  v184 = shb8;
		  v162 = (void (__fastcall *)(_OWORD *))qword_18F36F5B0;
		  if ( !qword_18F36F5B0 )
		  {
		    v162 = (void (__fastcall *)(_OWORD *))il2cpp_resolve_icall_1(
		                                            "UnityEngine.RenderSettings::set_ambientProbe_Injected(UnityEngine.Rendering."
		                                            "SphericalHarmonicsL2&)");
		    if ( !v162 )
		    {
		      v171 = sub_1802EE1B8("UnityEngine.RenderSettings::set_ambientProbe_Injected(UnityEngine.Rendering.SphericalHarmonicsL2&)");
		      sub_18007E1B0(v171, 0LL);
		    }
		    qword_18F36F5B0 = (__int64)v162;
		  }
		  v162(v182);
		  v163 = (void (__fastcall *)(__int64))qword_18F36F5A8;
		  if ( !qword_18F36F5A8 )
		  {
		    v163 = (void (__fastcall *)(__int64))il2cpp_resolve_icall_1(
		                                           "UnityEngine.RenderSettings::set_defaultReflectionMode(UnityEngine.Rendering.D"
		                                           "efaultReflectionMode)");
		    if ( !v163 )
		    {
		      v172 = sub_1802EE1B8("UnityEngine.RenderSettings::set_defaultReflectionMode(UnityEngine.Rendering.DefaultReflectionMode)");
		      sub_18007E1B0(v172, 0LL);
		    }
		    qword_18F36F5A8 = (__int64)v163;
		  }
		  v163(1LL);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		  s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
		  if ( !s_rainRenderer
		    || (HG::Rendering::Runtime::HGRainRenderer::RainAndWetnessPipelineUpdate(
		          s_rainRenderer,
		          (HGSettingParameters *)v4,
		          0LL),
		        (s_snowRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(0LL)) == 0LL) )
		  {
		LABEL_256:
		    sub_1800D8250(z_low, v41);
		  }
		  HG::Rendering::Runtime::HGSnowRenderer::SnowPipelineUpdate(s_snowRenderer, (HGSettingParameters *)v4, 0LL);
		}
		
		private void _UpdateCameraComponent(HGCamera hgCamera, Transform interpolateTrigger) {} // 0x00000001832731C0-0x00000001832748B0
		// Void _UpdateCameraComponent(HGCamera, Transform)
		// Hidden C++ exception states: #wind=3 #try_helpers=1
		void HG::Rendering::Runtime::HGEnvironmentManager::_UpdateCameraComponent(
		        HGEnvironmentManager *this,
		        HGCamera *hgCamera,
		        Transform *interpolateTrigger,
		        MethodInfo *method)
		{
		  Object *v5; // r14
		  HGEnvironmentManager *v6; // r13
		  ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  ILFixDynamicMethodWrapper_2__StaticFields *v12; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v13; // rbx
		  ILFixDynamicMethodWrapper_2 *v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  HGEnvironmentVolumeCameraComponent *klass; // r15
		  ILFixDynamicMethodWrapper_2__StaticFields *v18; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v19; // rbx
		  ILFixDynamicMethodWrapper_2 *v20; // rax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  HGEnvironmentPhase *m_interpolatedPhase; // rbx
		  __int64 v24; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *v25; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v26; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v27; // rbx
		  ILFixDynamicMethodWrapper_2 *v28; // rax
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *m_interpolatedVolumes; // rbx
		  __int64 v32; // rdx
		  struct ILFixDynamicMethodWrapper_2__Class *v33; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v34; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v35; // rbx
		  ILFixDynamicMethodWrapper_2 *v36; // rax
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  List_1_System_Single_ *m_interpolatedVolumesFactor; // rbx
		  struct Object_1__Class *v40; // rcx
		  Transform *v41; // rdi
		  Transform *m_interpolateTrigger; // rbx
		  bool v43; // zf
		  void (__fastcall *v44)(Transform *, FieldDescriptor **); // rax
		  MethodInfo *v45; // r9
		  Vector3 *v46; // rax
		  Type *v47; // rdx
		  PropertyInfo_1 *v48; // r8
		  Int32__Array **v49; // r9
		  unsigned int z_low; // ebx
		  struct Math__Class *v51; // rcx
		  __m128 v52; // xmm2
		  __m128d v53; // xmm3
		  double v54; // xmm0_8
		  float v55; // xmm0_4
		  float m_interpolateTimeFactor; // xmm9_4
		  List_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *m_sortedVolumes; // rbx
		  unsigned __int64 size; // rdx
		  signed __int64 items; // rcx
		  __int64 v60; // r8
		  _QWORD *p_klass; // r12
		  struct Object_1__Class *v62; // rcx
		  struct ILFixDynamicMethodWrapper_2__Class *v63; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v64; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v65; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v66; // rcx
		  ILFixDynamicMethodWrapper_2 *v67; // r13
		  Call *v68; // rax
		  __m128i v69; // xmm6
		  __m128i v70; // xmm2
		  Object *anonObj; // r12
		  _DWORD *v72; // xmm0_8
		  char *v73; // rcx
		  __int64 v74; // rdx
		  __int64 v75; // r15
		  Object__Array *v76; // r14
		  __int64 v77; // rdi
		  Object__Class *v78; // rsi
		  char *v79; // rbx
		  Value_1 *v80; // r15
		  signed __int64 v81; // rcx
		  __int64 v82; // rdx
		  __int64 v83; // rdi
		  Il2CppClass *element_class; // rbx
		  __int64 v85; // rsi
		  __int64 v86; // rdx
		  VirtualMachine *virtualMachine; // rcx
		  __int64 v88; // rdx
		  __int64 v89; // rcx
		  int v90; // eax
		  unsigned __int8 (__fastcall *v91)(_QWORD *); // rax
		  void (__fastcall *v92)(Transform *, FieldDescriptor **); // rax
		  __int64 v93; // r8
		  struct ILFixDynamicMethodWrapper_2__Class *v94; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v95; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v96; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v97; // rcx
		  ILFixDynamicMethodWrapper_2 *v98; // rcx
		  __int64 v99; // rdx
		  bool v100; // si
		  Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v101; // rcx
		  __int64 v102; // rdx
		  __int64 v103; // rcx
		  Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v104; // rcx
		  Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v105; // rdi
		  struct MethodInfo *v106; // rbx
		  int32_t Entry; // eax
		  __int64 v108; // rdx
		  __int64 v109; // r8
		  Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v110; // rcx
		  __int64 v111; // rdx
		  __int64 v112; // rcx
		  Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v113; // rdi
		  struct MethodInfo *v114; // rbx
		  int32_t v115; // eax
		  __int64 v116; // rdx
		  __int64 v117; // r8
		  Dictionary_2_TKey_TValue_Entry_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera___Array *v118; // rcx
		  float Epsilon; // xmm0_4
		  Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v120; // rcx
		  Dictionary_2_TKey_TValue_Entry_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera___Array *entries; // rcx
		  double (*v122)(void); // rax
		  __int64 v123; // r8
		  double v124; // xmm0_8
		  float v125; // xmm6_4
		  struct ILFixDynamicMethodWrapper_2__Class *v126; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v127; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v128; // rcx
		  ILFixDynamicMethodWrapper_15 *v129; // rcx
		  float v130; // xmm0_4
		  float v131; // xmm6_4
		  __m128i x_low; // xmm0
		  double (*v133)(void); // rax
		  __int64 v134; // r8
		  double v135; // xmm0_8
		  float v136; // xmm6_4
		  struct ILFixDynamicMethodWrapper_2__Class *v137; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v138; // rcx
		  ILFixDynamicMethodWrapper_15 *v139; // rcx
		  float v140; // xmm0_4
		  float v141; // xmm6_4
		  Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v142; // rcx
		  HGEnvironmentVolumeCameraComponent *v143; // r15
		  HGEnvironmentPhase *v144; // rax
		  HGEnvironmentManager *v145; // r13
		  Vector3 *v146; // rax
		  Object *current; // rbx
		  IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *v148; // rax
		  __int64 v149; // rdx
		  __int64 v150; // rcx
		  List_1_System_Single_ *v151; // r9
		  signed __int64 v152; // rtt
		  __int64 v153; // rax
		  __int64 v154; // rdx
		  __int64 v155; // rdx
		  float v156; // xmm6_4
		  List_1_System_Single_ *v157; // rax
		  __int64 v158; // rdx
		  __int64 v159; // rcx
		  __int64 v160; // r8
		  List_1_System_Single_ *v161; // rbx
		  struct MethodInfo *v162; // rdi
		  Il2CppClass *v163; // rcx
		  HGEnvironmentPhase *interpolatedPhase; // rsi
		  Vector3 *v165; // rdi
		  IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *interpolatedVolumes; // rbx
		  List_1_System_Single_ *interpolatedVolumesFactor; // rax
		  Vector3 *lastInterpolateTriggerPosition; // rax
		  Vector3__StaticFields *v169; // rdx
		  float z; // ecx
		  __int64 v171; // rax
		  __int64 v172; // rax
		  __int64 v173; // rax
		  __int64 v174; // rax
		  __int64 v175; // rax
		  __int64 v176; // rax
		  __int64 v177; // [rsp+0h] [rbp-1E8h] BYREF
		  MethodInfo *methoda; // [rsp+20h] [rbp-1C8h]
		  SingleFieldAccessor v179; // [rsp+50h] [rbp-198h] BYREF
		  float v180; // [rsp+88h] [rbp-160h]
		  Vector3 evaluationStackBase; // [rsp+90h] [rbp-158h] BYREF
		  __int128 v182; // [rsp+A0h] [rbp-148h] BYREF
		  Func_2_Google_Protobuf_IMessage_Object_ *getValueDelegate; // [rsp+B0h] [rbp-138h]
		  HGEnvironmentVolumeCameraComponent *v184; // [rsp+B8h] [rbp-130h]
		  List_1_T_Enumerator_System_Object_ v185; // [rsp+C0h] [rbp-128h] BYREF
		  HGEnvironmentVolumeCameraComponent *v186; // [rsp+D8h] [rbp-110h]
		  Vector3 v187; // [rsp+E0h] [rbp-108h] BYREF
		  Vector3 v188; // [rsp+F0h] [rbp-F8h] BYREF
		  Il2CppExceptionWrapper *v189; // [rsp+108h] [rbp-E0h] BYREF
		  Il2CppExceptionWrapper *v190; // [rsp+110h] [rbp-D8h] BYREF
		  __m128i v191; // [rsp+128h] [rbp-C0h]
		  Value_1 **topWriteBack; // [rsp+138h] [rbp-B0h]
		  Call v193[2]; // [rsp+140h] [rbp-A8h] BYREF
		
		  v5 = (Object *)hgCamera;
		  v6 = this;
		  memset(&v185, 0, sizeof(v185));
		  v182 = 0LL;
		  getValueDelegate = 0LL;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  if ( !static_fields->wrapperArray )
		    sub_1800D8260(static_fields, hgCamera);
		  if ( static_fields->wrapperArray->max_length.size > 788 )
		  {
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    static_fields = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		    wrapperArray = static_fields->wrapperArray;
		    if ( !static_fields->wrapperArray )
		      sub_1800D8260(static_fields, hgCamera);
		    if ( wrapperArray->max_length.size <= 0x314u )
		      sub_1800D2AB0(static_fields, hgCamera);
		    if ( wrapperArray[22].klass )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(788, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v11, v10);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		        (ILFixDynamicMethodWrapper_30 *)Patch,
		        (Object *)v6,
		        v5,
		        (Object *)interpolateTrigger,
		        0LL);
		      return;
		    }
		  }
		  if ( !v5 )
		    sub_1800D8260(static_fields, hgCamera);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  if ( !v12->wrapperArray )
		    sub_1800D8260(v12, hgCamera);
		  if ( v12->wrapperArray->max_length.size <= 447 )
		    goto LABEL_24;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v13 = v12->wrapperArray;
		  if ( !v12->wrapperArray )
		    sub_1800D8260(v12, hgCamera);
		  if ( v13->max_length.size <= 0x1BFu )
		    sub_1800D2AB0(v12, hgCamera);
		  if ( v13[12].vector[15] )
		  {
		    v14 = IFix::WrappersManagerImpl::GetPatch(447, 0LL);
		    if ( !v14 )
		      sub_1800D8260(v16, v15);
		    klass = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_207(v14, v5, 0LL);
		  }
		  else
		  {
		LABEL_24:
		    klass = (HGEnvironmentVolumeCameraComponent *)v5[157].klass;
		  }
		  v186 = klass;
		  v184 = klass;
		  if ( !klass )
		    sub_1800D8260(v12, hgCamera);
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  if ( !v18->wrapperArray )
		    sub_1800D8260(v18, hgCamera);
		  if ( v18->wrapperArray->max_length.size <= 451 )
		    goto LABEL_37;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		  v18 = TypeInfo::IFix::ILFixDynamicMethodWrapper->static_fields;
		  v19 = v18->wrapperArray;
		  if ( !v18->wrapperArray )
		    sub_1800D8260(v18, hgCamera);
		  if ( v19->max_length.size <= 0x1C3u )
		    sub_1800D2AB0(v18, hgCamera);
		  if ( v19[12].vector[19] )
		  {
		    v20 = IFix::WrappersManagerImpl::GetPatch(451, 0LL);
		    if ( !v20 )
		      sub_1800D8260(v22, v21);
		    m_interpolatedPhase = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_210(v20, (Object *)klass, 0LL);
		  }
		  else
		  {
		LABEL_37:
		    m_interpolatedPhase = klass->fields.m_interpolatedPhase;
		  }
		  if ( !m_interpolatedPhase )
		    sub_1800D8260(v18, hgCamera);
		  HG::Rendering::Runtime::HGEnvironmentPhase::AssignFrom(m_interpolatedPhase, v6->fields.m_defaultPhase, 0LL);
		  v25 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v25 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v26 = v25->static_fields->wrapperArray;
		  if ( !v26 )
		    sub_1800D8260(v25, v24);
		  if ( v26->max_length.size <= 789 )
		    goto LABEL_50;
		  if ( !v25->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v25);
		    v25 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v27 = v25->static_fields->wrapperArray;
		  if ( !v27 )
		    sub_1800D8260(v25, v24);
		  if ( v27->max_length.size <= 0x315u )
		    sub_1800D2AB0(v25, v24);
		  if ( v27[22].monitor )
		  {
		    v28 = IFix::WrappersManagerImpl::GetPatch(789, 0LL);
		    if ( !v28 )
		      sub_1800D8260(v30, v29);
		    m_interpolatedVolumes = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_315(v28, (Object *)klass, 0LL);
		  }
		  else
		  {
		LABEL_50:
		    m_interpolatedVolumes = klass->fields.m_interpolatedVolumes;
		  }
		  if ( !m_interpolatedVolumes )
		    sub_1800D8260(v25, v24);
		  Beyond::IndexedHashSet<System::Object>::Clear(
		    (IndexedHashSet_1_System_Object_ *)m_interpolatedVolumes,
		    MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Clear);
		  v33 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v33 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v34 = v33->static_fields->wrapperArray;
		  if ( !v34 )
		    sub_1800D8260(v33, v32);
		  if ( v34->max_length.size <= 790 )
		    goto LABEL_63;
		  if ( !v33->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v33);
		    v33 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v35 = v33->static_fields->wrapperArray;
		  if ( !v35 )
		    sub_1800D8260(v33, v32);
		  if ( v35->max_length.size <= 0x316u )
		    sub_1800D2AB0(v33, v32);
		  if ( v35[22].bounds )
		  {
		    v36 = IFix::WrappersManagerImpl::GetPatch(790, 0LL);
		    if ( !v36 )
		      sub_1800D8260(v38, v37);
		    m_interpolatedVolumesFactor = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_316(v36, (Object *)klass, 0LL);
		  }
		  else
		  {
		LABEL_63:
		    m_interpolatedVolumesFactor = klass->fields.m_interpolatedVolumesFactor;
		  }
		  if ( !m_interpolatedVolumesFactor )
		    sub_1800D8260(v33, v32);
		  ++m_interpolatedVolumesFactor->fields._version;
		  m_interpolatedVolumesFactor->fields._size = 0;
		  v40 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v40 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v40 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  v41 = interpolateTrigger;
		  if ( !interpolateTrigger )
		    goto LABEL_277;
		  if ( !v40->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v40);
		    v40 = TypeInfo::UnityEngine::Object;
		  }
		  if ( !interpolateTrigger->fields._._.m_CachedPtr )
		  {
		LABEL_277:
		    lastInterpolateTriggerPosition = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_lastInterpolateTriggerPosition(
		                                       klass,
		                                       0LL);
		    v169 = TypeInfo::UnityEngine::Vector3->static_fields;
		    z = v169->negativeInfinityVector.z;
		    *(_QWORD *)&lastInterpolateTriggerPosition->x = *(_QWORD *)&v169->negativeInfinityVector.x;
		    lastInterpolateTriggerPosition->z = z;
		    return;
		  }
		  m_interpolateTrigger = v6->fields.m_interpolateTrigger;
		  if ( !v40->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v40);
		    v40 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v40 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( m_interpolateTrigger )
		  {
		    v43 = interpolateTrigger == m_interpolateTrigger;
		  }
		  else
		  {
		    if ( !v40->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v40);
		    v43 = interpolateTrigger->fields._._.m_CachedPtr == 0LL;
		  }
		  if ( !v43 )
		  {
		LABEL_276:
		    interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(klass, 0LL);
		    v165 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_lastInterpolateTriggerPosition(klass, 0LL);
		    interpolatedVolumes = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedVolumes(
		                            klass,
		                            0LL);
		    interpolatedVolumesFactor = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedVolumesFactor(
		                                  klass,
		                                  0LL);
		    HG::Rendering::Runtime::HGEnvironmentManager::_InterpolateVolumesImpl(
		      v6,
		      (HGCamera *)v5,
		      interpolateTrigger,
		      interpolatedPhase,
		      v165,
		      interpolatedVolumes,
		      interpolatedVolumesFactor,
		      0LL);
		    return;
		  }
		  v179.fields._.descriptor = 0LL;
		  LODWORD(v179.fields.setValueDelegate) = 0;
		  v44 = (void (__fastcall *)(Transform *, FieldDescriptor **))qword_18F3700F0;
		  if ( !qword_18F3700F0 )
		  {
		    v44 = (void (__fastcall *)(Transform *, FieldDescriptor **))sub_180059EA0(
		                                                                  "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		    qword_18F3700F0 = (__int64)v44;
		  }
		  v44(interpolateTrigger, &v179.fields._.descriptor);
		  v179.fields.hasDelegate = *(Func_2_Google_Protobuf_IMessage_Boolean_ **)&v6->fields.m_lastInterpolateTriggerPosition.x;
		  v180 = v6->fields.m_lastInterpolateTriggerPosition.z;
		  evaluationStackBase = *(Vector3 *)&v179.fields._.descriptor;
		  v46 = UnityEngine::Vector3::op_Subtraction(&v187, &evaluationStackBase, (Vector3 *)&v179.fields.hasDelegate, v45);
		  v179.fields._.descriptor = *(FieldDescriptor **)&v46->x;
		  z_low = LODWORD(v46->z);
		  v51 = TypeInfo::System::Math;
		  if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		  v52 = (__m128)_mm_cvtsi32_si128(z_low);
		  v52.m128_f32[0] = (float)(v52.m128_f32[0] * v52.m128_f32[0])
		                  + (float)((float)(*((float *)&v179.fields._.descriptor + 1) * *((float *)&v179.fields._.descriptor + 1))
		                          + (float)(*(float *)&v179.fields._.descriptor * *(float *)&v179.fields._.descriptor));
		  v53 = _mm_cvtps_pd(v52);
		  if ( v53.m128d_f64[0] < 0.0 )
		    v54 = sub_1801D32D0(v51, v47, v48);
		  else
		    *(_QWORD *)&v54 = *(_OWORD *)&_mm_sqrt_pd(v53);
		  v55 = v54;
		  if ( v55 <= 5.0 )
		    m_interpolateTimeFactor = v6->fields.m_interpolateTimeFactor;
		  else
		    m_interpolateTimeFactor = 10000.0;
		  m_sortedVolumes = v6->fields.m_sortedVolumes;
		  if ( !m_sortedVolumes )
		    sub_1800D8260(v51, v47);
		  *(_OWORD *)&v179.monitor = 0LL;
		  v179.klass = (SingleFieldAccessor__Class *)m_sortedVolumes;
		  sub_18002D1B0(&v179, v47, v48, v49, methoda);
		  LODWORD(v179.monitor) = 0;
		  HIDWORD(v179.monitor) = m_sortedVolumes->fields._version;
		  v179.fields._.getValueDelegate = 0LL;
		  *(_OWORD *)&v185._list = *(_OWORD *)&v179.klass;
		  v185._current = 0LL;
		  v179.klass = 0LL;
		  v179.monitor = (MonitorData *)&v185;
		  while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		            &v185,
		            MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::MoveNext) )
		  {
		    p_klass = &v185._current->klass;
		    v179.fields.hasDelegate = (Func_2_Google_Protobuf_IMessage_Boolean_ *)v185._current;
		    v62 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v62 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v62 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( p_klass )
		    {
		      if ( !v62->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v62);
		      if ( p_klass[2] )
		      {
		        v63 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		          v63 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v64 = v63->static_fields->wrapperArray;
		        if ( !v64 )
		          sub_1800D8250(v63, 0LL);
		        if ( v64->max_length.size <= 623 )
		          goto LABEL_143;
		        if ( !v63->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v63);
		          v63 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v65 = v63->static_fields->wrapperArray;
		        if ( !v65 )
		          sub_1800D8250(v63, 0LL);
		        if ( v65->max_length.size <= 0x26Fu )
		          sub_1800D2AA0(v63, v65, v60);
		        if ( v65[17].vector[11] )
		        {
		          if ( !v63->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v63);
		            v63 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v66 = v63->static_fields->wrapperArray;
		          if ( !v66 )
		            sub_1800D8250(0LL, v65);
		          if ( v66->max_length.size <= 0x26Fu )
		            sub_1800D2AA0(v66, v65, v60);
		          v67 = v66[17].vector[11];
		          if ( !v67 )
		            sub_1800D8250(v66, v65);
		          v68 = IFix::Core::Call::Begin(v193, 0LL);
		          v69 = *(__m128i *)&v68->argumentBase;
		          v70 = *(__m128i *)&v68->managedStack;
		          v191 = v70;
		          topWriteBack = v68->topWriteBack;
		          if ( v67->fields.anonObj )
		          {
		            anonObj = v67->fields.anonObj;
		            v72 = (_DWORD *)_mm_srli_si128(v70, 8).m128i_u64[0];
		            *(_QWORD *)&evaluationStackBase.x = _mm_srli_si128(v69, 8).m128i_u64[0];
		            v73 = (char *)v72 - *(_QWORD *)&evaluationStackBase.x;
		            v74 = (unsigned __int128)(((__int64)v72 - *(_QWORD *)&evaluationStackBase.x) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		            v75 = ((__int64)v72 - *(_QWORD *)&evaluationStackBase.x) / 12;
		            if ( !v72 )
		              sub_1800D8250(v73, v74);
		            *v72 = 8;
		            v72[1] = v75;
		            v76 = (Object__Array *)v70.m128i_i64[0];
		            if ( !v70.m128i_i64[0] )
		              sub_1800D8250(v73, v74);
		            v77 = *(_QWORD *)(*(_QWORD *)v70.m128i_i64[0] + 64LL);
		            v78 = anonObj->klass;
		            if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v77, anonObj->klass)
		              && ((BYTE1(v78->vtable.Equals.methodPtr) & 0x10) == 0
		               || ((*(_BYTE *)(v77 + 276) & 0x20) == 0 && *(_BYTE *)(v77 + 42) != 19 && *(_BYTE *)(v77 + 42) != 30
		                || !*(_QWORD *)(v77 + 112)
		                || !*(_QWORD *)(*(_QWORD *)(v77 + 112) + 40LL)
		                || !sub_1802ED414(anonObj))
		               && v77 != qword_18F35FF70) )
		            {
		              v171 = sub_18031E23C();
		              sub_18007E190(v171, 0LL);
		            }
		            sub_180005370(v70.m128i_i64[0], (int)v75, anonObj);
		            v79 = (char *)(v72 + 3);
		            v80 = *(Value_1 **)&evaluationStackBase.x;
		            p_klass = &v179.fields.hasDelegate->klass;
		          }
		          else
		          {
		            v79 = (char *)v191.m128i_i64[1];
		            v76 = (Object__Array *)v191.m128i_i64[0];
		            v80 = (Value_1 *)_mm_srli_si128(v69, 8).m128i_u64[0];
		          }
		          v81 = v79 - (char *)v80;
		          v82 = (unsigned __int128)((v79 - (char *)v80) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		          v83 = (v79 - (char *)v80) / 12;
		          if ( !v79 )
		            sub_1800D8250(v81, v82);
		          *(_DWORD *)v79 = 8;
		          *((_DWORD *)v79 + 1) = v83;
		          if ( !v76 )
		            sub_1800D8250(v81, v82);
		          element_class = v76->klass->_0.element_class;
		          v85 = *p_klass;
		          if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(element_class, *p_klass)
		            && ((*(_BYTE *)(v85 + 313) & 0x10) == 0
		             || ((element_class->flags & 0x20) == 0
		              && *((_BYTE *)&element_class->byval_arg + 10) != 19
		              && *((_BYTE *)&element_class->byval_arg + 10) != 30
		              || !element_class->interopData
		              || !element_class->interopData->guid
		              || !sub_1802ED414(p_klass))
		             && element_class != (Il2CppClass *)qword_18F35FF70) )
		          {
		            v172 = sub_18031E23C();
		            sub_18007E190(v172, 0LL);
		          }
		          sub_180005370(v76, (int)v83, p_klass);
		          virtualMachine = v67->fields.virtualMachine;
		          if ( !virtualMachine )
		            sub_1800D8250(0LL, v86);
		          IFix::Core::VirtualMachine::Execute(
		            virtualMachine,
		            virtualMachine->fields.unmanagedCodes[v67->fields.methodId],
		            (Value_1 *)v69.m128i_i64[0],
		            v76,
		            v80,
		            (v67->fields.anonObj != 0LL) + 1,
		            v67->fields.methodId,
		            0,
		            topWriteBack,
		            0LL);
		          if ( !v69.m128i_i64[0] )
		            sub_1800D8250(v89, v88);
		          v90 = *(_DWORD *)(v69.m128i_i64[0] + 4);
		          v5 = (Object *)hgCamera;
		          v41 = interpolateTrigger;
		        }
		        else
		        {
		LABEL_143:
		          v90 = *((_DWORD *)p_klass + 10);
		        }
		        if ( v90 == 2 )
		        {
		          v91 = (unsigned __int8 (__fastcall *)(_QWORD *))qword_18F36FBB8;
		          if ( !qword_18F36FBB8 )
		          {
		            v91 = (unsigned __int8 (__fastcall *)(_QWORD *))il2cpp_resolve_icall_1("UnityEngine.Behaviour::get_isActiveAndEnabled()");
		            if ( !v91 )
		            {
		              v173 = sub_1802EE1B8("UnityEngine.Behaviour::get_isActiveAndEnabled()");
		              sub_18007E1B0(v173, 0LL);
		            }
		            qword_18F36FBB8 = (__int64)v91;
		          }
		          if ( v91(p_klass) )
		          {
		            sub_1800049A0(*p_klass);
		            if ( (*(unsigned __int8 (__fastcall **)(_QWORD *, _QWORD))(*p_klass + 464LL))(
		                   p_klass,
		                   *(_QWORD *)(*p_klass + 472LL)) )
		            {
		              v179.fields._.descriptor = 0LL;
		              LODWORD(v179.fields.setValueDelegate) = 0;
		              v92 = (void (__fastcall *)(Transform *, FieldDescriptor **))qword_18F3700F0;
		              if ( !qword_18F3700F0 )
		              {
		                v92 = (void (__fastcall *)(Transform *, FieldDescriptor **))il2cpp_resolve_icall_1(
		                                                                              "UnityEngine.Transform::get_position_Inject"
		                                                                              "ed(UnityEngine.Vector3&)");
		                if ( !v92 )
		                {
		                  v174 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		                  sub_18007E1B0(v174, 0LL);
		                }
		                qword_18F3700F0 = (__int64)v92;
		              }
		              v92(v41, &v179.fields._.descriptor);
		              v94 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		                v94 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              }
		              v95 = v94->static_fields->wrapperArray;
		              if ( !v95 )
		                sub_1800D8250(v94, 0LL);
		              if ( v95->max_length.size <= 624 )
		                goto LABEL_168;
		              if ( !v94->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(v94);
		                v94 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              }
		              v96 = v94->static_fields->wrapperArray;
		              if ( !v96 )
		                sub_1800D8250(v94, 0LL);
		              if ( v96->max_length.size <= 0x270u )
		                sub_1800D2AA0(v94, v96, v93);
		              if ( v96[17].vector[12] )
		              {
		                if ( !v94->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(v94);
		                  v94 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                }
		                v97 = v94->static_fields->wrapperArray;
		                if ( !v97 )
		                  sub_1800D8250(0LL, v96);
		                if ( v97->max_length.size <= 0x270u )
		                  sub_1800D2AA0(v97, v96, v93);
		                v98 = v97[17].vector[12];
		                if ( !v98 )
		                  sub_1800D8250(0LL, v96);
		                v188 = *(Vector3 *)&v179.fields._.descriptor;
		                v100 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_255(v98, (Object *)p_klass, &v188, 0LL);
		              }
		              else
		              {
		LABEL_168:
		                v187 = *(Vector3 *)&v179.fields._.descriptor;
		                if ( HG::Rendering::Runtime::HGEnvironmentVolumeBase::_DistanceToEdge(
		                       (HGEnvironmentVolumeBase *)p_klass,
		                       &v187,
		                       0LL) > 0.0 )
		                {
		                  v100 = 1;
		                  goto LABEL_170;
		                }
		                v100 = 0;
		              }
		              if ( v100 )
		              {
		LABEL_170:
		                v101 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)p_klass[10];
		                if ( !v101 )
		                  sub_1800D8250(0LL, v99);
		                if ( !System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::ContainsKey(
		                        v101,
		                        v5,
		                        MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::ContainsKey) )
		                {
		                  v104 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)p_klass[10];
		                  if ( !v104 )
		                    sub_1800D8250(0LL, v102);
		                  System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::Add(
		                    v104,
		                    v5,
		                    (HGEnvironmentVolumeBase_InterpolateDataPerCamera)_mm_cvtsi128_si32((__m128i)0LL),
		                    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::Add);
		                }
		                v105 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)p_klass[10];
		                if ( !v105 )
		                  sub_1800D8250(v103, v102);
		                v106 = MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::get_Item;
		                if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::get_Item->klass->rgctx_data[22].rgctxDataDummy
		                      + 4) )
		                  (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::get_Item->klass->rgctx_data[22].rgctxDataDummy)();
		                Entry = System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::FindEntry(
		                          v105,
		                          v5,
		                          (MethodInfo *)v106->klass->rgctx_data[22].rgctxDataDummy);
		                if ( Entry < 0 )
		                  System::ThrowHelper::ThrowKeyNotFoundException(v5, 0LL);
		                entries = v105->fields._entries;
		                if ( !entries )
		                  sub_1800D8250(0LL, v108);
		                if ( (unsigned int)Entry >= entries->max_length.size )
		                  sub_1800D2AA0(entries, Entry, v109);
		                evaluationStackBase.x = entries->vector[Entry].value.timeFadingFactor;
		                if ( !v100 || *((_BYTE *)p_klass + 72) )
		                {
		                  v133 = (double (*)(void))qword_18F36FFB8;
		                  if ( !qword_18F36FFB8 )
		                  {
		                    v133 = (double (*)(void))il2cpp_resolve_icall_1("UnityEngine.Time::get_deltaTime()");
		                    if ( !v133 )
		                    {
		                      v176 = sub_1802EE1B8("UnityEngine.Time::get_deltaTime()");
		                      sub_18007E1B0(v176, 0LL);
		                    }
		                    qword_18F36FFB8 = (__int64)v133;
		                  }
		                  v135 = v133();
		                  v136 = *(float *)&v135;
		                  v137 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		                  {
		                    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		                    v137 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                  }
		                  v127 = v137->static_fields->wrapperArray;
		                  if ( !v127 )
		                    sub_1800D8250(v137, 0LL);
		                  if ( v127->max_length.size <= 639 )
		                    goto LABEL_234;
		                  if ( !v137->_1.cctor_finished_or_no_cctor )
		                  {
		                    il2cpp_runtime_class_init_1(v137);
		                    v137 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                  }
		                  v127 = v137->static_fields->wrapperArray;
		                  if ( !v127 )
		                    sub_1800D8250(v137, 0LL);
		                  if ( v127->max_length.size <= 0x27Fu )
		                    sub_1800D2AA0(v137, v127, v134);
		                  if ( v127[17].vector[27] )
		                  {
		                    if ( !v137->_1.cctor_finished_or_no_cctor )
		                    {
		                      il2cpp_runtime_class_init_1(v137);
		                      v137 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                    }
		                    v138 = v137->static_fields->wrapperArray;
		                    if ( !v138 )
		                      sub_1800D8250(0LL, v127);
		                    if ( v138->max_length.size <= 0x27Fu )
		                      sub_1800D2AA0(v138, v127, v134);
		                    v139 = (ILFixDynamicMethodWrapper_15 *)v138[17].vector[27];
		                    if ( !v139 )
		                      sub_1800D8250(0LL, v127);
		                    v140 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(v139, (Object *)p_klass, 0LL);
		                  }
		                  else
		                  {
		LABEL_234:
		                    v140 = *((float *)p_klass + 14);
		                  }
		                  v141 = (float)(v136 * m_interpolateTimeFactor) / v140;
		                  x_low = (__m128i)LODWORD(evaluationStackBase.x);
		                  *(float *)x_low.m128i_i32 = evaluationStackBase.x - v141;
		                }
		                else
		                {
		                  v122 = (double (*)(void))qword_18F36FFB8;
		                  if ( !qword_18F36FFB8 )
		                  {
		                    v122 = (double (*)(void))il2cpp_resolve_icall_1("UnityEngine.Time::get_deltaTime()");
		                    if ( !v122 )
		                    {
		                      v175 = sub_1802EE1B8("UnityEngine.Time::get_deltaTime()");
		                      sub_18007E1B0(v175, 0LL);
		                    }
		                    qword_18F36FFB8 = (__int64)v122;
		                  }
		                  v124 = v122();
		                  v125 = *(float *)&v124;
		                  v126 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		                  {
		                    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		                    v126 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                  }
		                  v127 = v126->static_fields->wrapperArray;
		                  if ( !v127 )
		                    sub_1800D8250(v126, 0LL);
		                  if ( v127->max_length.size <= 638 )
		                    goto LABEL_214;
		                  if ( !v126->_1.cctor_finished_or_no_cctor )
		                  {
		                    il2cpp_runtime_class_init_1(v126);
		                    v126 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                  }
		                  v127 = v126->static_fields->wrapperArray;
		                  if ( !v127 )
		                    sub_1800D8250(v126, 0LL);
		                  if ( v127->max_length.size <= 0x27Eu )
		                    sub_1800D2AA0(v126, v127, v123);
		                  if ( v127[17].vector[26] )
		                  {
		                    if ( !v126->_1.cctor_finished_or_no_cctor )
		                    {
		                      il2cpp_runtime_class_init_1(v126);
		                      v126 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		                    }
		                    v128 = v126->static_fields->wrapperArray;
		                    if ( !v128 )
		                      sub_1800D8250(0LL, v127);
		                    if ( v128->max_length.size <= 0x27Eu )
		                      sub_1800D2AA0(v128, v127, v123);
		                    v129 = (ILFixDynamicMethodWrapper_15 *)v128[17].vector[26];
		                    if ( !v129 )
		                      sub_1800D8250(0LL, v127);
		                    v130 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(v129, (Object *)p_klass, 0LL);
		                  }
		                  else
		                  {
		LABEL_214:
		                    v130 = *((float *)p_klass + 13);
		                  }
		                  v131 = (float)(v125 * m_interpolateTimeFactor) / v130;
		                  x_low = (__m128i)LODWORD(evaluationStackBase.x);
		                  *(float *)x_low.m128i_i32 = evaluationStackBase.x + v131;
		                }
		                if ( *(float *)x_low.m128i_i32 < 0.0 )
		                {
		                  x_low = 0LL;
		                }
		                else if ( *(float *)x_low.m128i_i32 > 1.0 )
		                {
		                  x_low = (__m128i)0x3F800000u;
		                }
		                v142 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)p_klass[10];
		                if ( !v142 )
		                  sub_1800D8250(0LL, v127);
		                System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::set_Item(
		                  v142,
		                  v5,
		                  (HGEnvironmentVolumeBase_InterpolateDataPerCamera)_mm_cvtsi128_si32(x_low),
		                  MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::set_Item);
		                v41 = interpolateTrigger;
		              }
		              else
		              {
		                v110 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)p_klass[10];
		                if ( !v110 )
		                  sub_1800D8250(0LL, v99);
		                if ( System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::ContainsKey(
		                       v110,
		                       v5,
		                       MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::ContainsKey) )
		                {
		                  v113 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)p_klass[10];
		                  if ( !v113 )
		                    sub_1800D8250(v112, v111);
		                  v114 = MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::get_Item;
		                  if ( !*((_QWORD *)MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::get_Item->klass->rgctx_data[22].rgctxDataDummy
		                        + 4) )
		                    (*(void (**)(void))MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::get_Item->klass->rgctx_data[22].rgctxDataDummy)();
		                  v115 = System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::FindEntry(
		                           v113,
		                           v5,
		                           (MethodInfo *)v114->klass->rgctx_data[22].rgctxDataDummy);
		                  if ( v115 < 0 )
		                    System::ThrowHelper::ThrowKeyNotFoundException(v5, 0LL);
		                  v118 = v113->fields._entries;
		                  if ( !v118 )
		                    sub_1800D8250(0LL, v116);
		                  v99 = v115;
		                  if ( (unsigned int)v115 >= v118->max_length.size )
		                    sub_1800D2AA0(v118, v115, v117);
		                  Epsilon = TypeInfo::UnityEngine::Mathf->static_fields->Epsilon;
		                  evaluationStackBase.x = v118->vector[v115].value.timeFadingFactor;
		                  if ( Epsilon <= evaluationStackBase.x )
		                    goto LABEL_170;
		                  v120 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)p_klass[10];
		                  if ( !v120 )
		                    sub_1800D8250(0LL, v115);
		                  System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Remove(
		                    v120,
		                    v5,
		                    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::Remove);
		                  v41 = interpolateTrigger;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		  }
		  v143 = v186;
		  if ( !v186 )
		    goto LABEL_364;
		  v144 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(v186, 0LL);
		  if ( !v144 )
		    goto LABEL_364;
		  v145 = this;
		  HG::Rendering::Runtime::HGEnvironmentPhase::AssignFrom(v144, this->fields.m_interpolatedPhase, 0LL);
		  v146 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_lastInterpolateTriggerPosition(v143, 0LL);
		  items = LODWORD(this->fields.m_lastInterpolateTriggerPosition.z);
		  *(_QWORD *)&v146->x = *(_QWORD *)&this->fields.m_lastInterpolateTriggerPosition.x;
		  LODWORD(v146->z) = items;
		  size = (unsigned __int64)this->fields.m_interpolatedVolumes;
		  if ( !size )
		    goto LABEL_364;
		  Beyond::IndexedHashSet<System::Object>::GetEnumerator(
		    (List_1_T_Enumerator_System_Object_ *)&v179,
		    (IndexedHashSet_1_System_Object_ *)size,
		    MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::GetEnumerator);
		  *(_OWORD *)&v185._list = *(_OWORD *)&v179.klass;
		  v185._current = (Object *)v179.fields._.getValueDelegate;
		  v179.klass = 0LL;
		  v179.monitor = (MonitorData *)&v185;
		  try
		  {
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v185,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::MoveNext) )
		    {
		      current = v185._current;
		      v148 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedVolumes(v143, 0LL);
		      if ( !v148 )
		        sub_1800D8250(v150, v149);
		      Beyond::IndexedHashSet<System::Object>::Add(
		        (IndexedHashSet_1_System_Object_ *)v148,
		        current,
		        MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Add);
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v189 )
		  {
		    size = (unsigned __int64)&v177;
		    v179.klass = (SingleFieldAccessor__Class *)v189->ex;
		    items = (signed __int64)v179.klass;
		    if ( v179.klass )
		      sub_18007E1E0(v179.klass);
		    v143 = v184;
		    v145 = this;
		  }
		  v151 = v145->fields.m_interpolatedVolumesFactor;
		  if ( !v151 )
		LABEL_364:
		    sub_1800D8250(items, size);
		  *(_OWORD *)&v179.monitor = 0LL;
		  v179.klass = (SingleFieldAccessor__Class *)v151;
		  if ( dword_18F35FD08 )
		  {
		    size = (((unsigned __int64)&v179 >> 12) & 0x1FFFFF) >> 6;
		    _m_prefetchw(&qword_18F103690[size]);
		    do
		    {
		      items = qword_18F103690[size] | (1LL << (((unsigned __int64)&v179 >> 12) & 0x3F));
		      v152 = qword_18F103690[size];
		    }
		    while ( v152 != _InterlockedCompareExchange64(&qword_18F103690[size], items, v152) );
		  }
		  LODWORD(v179.monitor) = 0;
		  HIDWORD(v179.monitor) = v151->fields._version;
		  LODWORD(v179.fields._.getValueDelegate) = 0;
		  v182 = *(_OWORD *)&v179.klass;
		  getValueDelegate = v179.fields._.getValueDelegate;
		  v179.klass = 0LL;
		  v179.monitor = (MonitorData *)&v182;
		  try
		  {
		    while ( 1 )
		    {
		      v153 = v182;
		      if ( !(_QWORD)v182 )
		        sub_1800D8250(items, size);
		      v154 = HIDWORD(v182);
		      if ( HIDWORD(v182) != *(_DWORD *)(v182 + 28) || DWORD2(v182) >= *(_DWORD *)(v182 + 24) )
		        break;
		      v155 = *(_QWORD *)(v182 + 16);
		      if ( !v155 )
		        sub_1800D8250(SDWORD2(v182), 0LL);
		      if ( DWORD2(v182) >= *(_DWORD *)(v155 + 24) )
		        sub_1800D2AA0(
		          SDWORD2(v182),
		          v155,
		          MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<float>::MoveNext);
		      v156 = *(float *)(v155 + 4LL * SDWORD2(v182) + 32);
		      *(float *)&getValueDelegate = v156;
		      ++DWORD2(v182);
		      v157 = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedVolumesFactor(v143, 0LL);
		      v161 = v157;
		      if ( !v157 )
		        sub_1800D8250(v159, v158);
		      v162 = MethodInfo::System::Collections::Generic::List<float>::Add;
		      ++v157->fields._version;
		      items = (signed __int64)v157->fields._items;
		      size = v157->fields._size;
		      if ( !items )
		        sub_1800D8250(0LL, size);
		      if ( (unsigned int)size < *(_DWORD *)(items + 24) )
		      {
		        v157->fields._size = size + 1;
		        if ( (unsigned int)size >= *(_DWORD *)(items + 24) )
		          sub_1800D2AA0(items, size, v160);
		        *(float *)(items + 4 * size + 32) = v156;
		      }
		      else
		      {
		        if ( !*((_QWORD *)v162->klass->rgctx_data[11].rgctxDataDummy + 4) )
		          (*(void (**)(void))v162->klass->rgctx_data[11].rgctxDataDummy)();
		        System::Collections::Generic::List<float>::AddWithResize(
		          v161,
		          v156,
		          (MethodInfo *)v162->klass->rgctx_data[11].rgctxDataDummy);
		      }
		    }
		    v163 = MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<float>::MoveNext->klass;
		    if ( ((__int64)v163->vtable[0].methodPtr & 1) == 0 )
		    {
		      sub_1800360B0(v163, HIDWORD(v182));
		      v154 = HIDWORD(v182);
		      v153 = v182;
		    }
		    if ( !v153 )
		      sub_1800D8250(v163, v154);
		    if ( (_DWORD)v154 != *(_DWORD *)(v153 + 28) )
		      System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		    DWORD2(v182) = *(_DWORD *)(v153 + 24) + 1;
		    LODWORD(getValueDelegate) = 0;
		  }
		  catch ( Il2CppExceptionWrapper *v190 )
		  {
		    v179.klass = (SingleFieldAccessor__Class *)v190->ex;
		    if ( v179.klass )
		      sub_18007E1E0(v179.klass);
		    klass = v184;
		    v5 = (Object *)hgCamera;
		    v6 = this;
		    goto LABEL_276;
		  }
		}
		
		private void _PerCameraUpdate(HGCamera hgCamera, ref ScriptableRenderContext renderContext) {} // 0x0000000182EDFA90-0x0000000182EDFC60
		// Void _PerCameraUpdate(HGCamera, ScriptableRenderContext ByRef)
		void HG::Rendering::Runtime::HGEnvironmentManager::_PerCameraUpdate(
		        HGEnvironmentManager *this,
		        HGCamera *hgCamera,
		        ScriptableRenderContext *renderContext,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rax
		  Object *v7; // rsi
		  HGEnvironmentManager__Class *wrapperArray; // rdx
		  int32_t m_talosStarRenderer_high; // ecx
		  HGAdditionalCameraData *m_AdditionalCameraData; // rax
		  int32_t hgRenderPath; // eax
		  HGRainRenderer *s_rainRenderer; // rax
		  HGSnowRenderer *s_snowRenderer; // rax
		  const Il2CppImage *image; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  const Il2CppImage *v16; // r8
		  ILFixDynamicMethodWrapper_2 *v17; // rax
		  ILFixDynamicMethodWrapper_2 *v18; // rax
		  HGEnvironmentManager__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *v20; // rax
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v7 = (Object *)this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (HGEnvironmentManager__Class *)v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_30;
		  if ( SLODWORD(wrapperArray->_0.namespaze) > 793 )
		  {
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (HGEnvironmentManager__Class *)v4->static_fields;
		    image = wrapperArray->_0.image;
		    if ( !wrapperArray->_0.image )
		      goto LABEL_30;
		    if ( image->typeCount <= 0x319 )
		      goto LABEL_60;
		    if ( image[88].metadataHandle )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(793, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_325(Patch, v7, (Object *)hgCamera, renderContext, 0LL);
		        return;
		      }
		      goto LABEL_30;
		    }
		  }
		  if ( !hgCamera )
		    goto LABEL_30;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGEnvironmentManager *)v4->static_fields;
		  wrapperArray = this->klass;
		  if ( !this->klass )
		    goto LABEL_30;
		  if ( SLODWORD(wrapperArray->_0.namespaze) <= 794 )
		    goto LABEL_63;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (HGEnvironmentManager__Class *)v4->static_fields;
		  v16 = wrapperArray->_0.image;
		  if ( !wrapperArray->_0.image )
		    goto LABEL_30;
		  if ( v16->typeCount <= 0x31A )
		    goto LABEL_60;
		  if ( !v16[88].nameToClassHashTable )
		  {
		LABEL_63:
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGEnvironmentManager *)v4->static_fields;
		    wrapperArray = this->klass;
		    if ( !this->klass )
		      goto LABEL_30;
		    if ( SLODWORD(wrapperArray->_0.namespaze) <= 703 )
		      goto LABEL_14;
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGEnvironmentManager *)v4->static_fields;
		    wrapperArray = this->klass;
		    if ( !this->klass )
		      goto LABEL_30;
		    if ( LODWORD(wrapperArray->_0.namespaze) <= 0x2BF )
		      goto LABEL_60;
		    if ( wrapperArray[15]._0.name )
		    {
		      v18 = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		      if ( !v18 )
		        goto LABEL_30;
		      m_talosStarRenderer_high = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                                   (ILFixDynamicMethodWrapper_31 *)v18,
		                                   (Object *)hgCamera,
		                                   0LL);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    else
		    {
		LABEL_14:
		      this = (HGEnvironmentManager *)hgCamera->fields.m_AdditionalCameraData;
		      if ( !this )
		        goto LABEL_30;
		      m_talosStarRenderer_high = HIDWORD(this->fields.m_talosStarRenderer);
		    }
		    if ( m_talosStarRenderer_high == 1 )
		      return;
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGEnvironmentManager *)v4->static_fields;
		    wrapperArray = this->klass;
		    if ( !this->klass )
		      goto LABEL_30;
		    if ( SLODWORD(wrapperArray->_0.namespaze) <= 703 )
		      goto LABEL_21;
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGEnvironmentManager *)v4->static_fields;
		    klass = this->klass;
		    if ( !this->klass )
		      goto LABEL_30;
		    if ( LODWORD(klass->_0.namespaze) > 0x2BF )
		    {
		      if ( klass[15]._0.name )
		      {
		        v20 = IFix::WrappersManagerImpl::GetPatch(703, 0LL);
		        if ( !v20 )
		          goto LABEL_30;
		        hgRenderPath = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                         (ILFixDynamicMethodWrapper_31 *)v20,
		                         (Object *)hgCamera,
		                         0LL);
		        goto LABEL_23;
		      }
		LABEL_21:
		      m_AdditionalCameraData = hgCamera->fields.m_AdditionalCameraData;
		      if ( !m_AdditionalCameraData )
		        goto LABEL_30;
		      hgRenderPath = m_AdditionalCameraData->fields.hgRenderPath;
		LABEL_23:
		      if ( hgRenderPath == 2 )
		        return;
		LABEL_24:
		      if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      s_rainRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_rainRenderer(0LL);
		      if ( s_rainRenderer )
		      {
		        HG::Rendering::Runtime::HGRainRenderer::UpdateRainAndWetnessData(s_rainRenderer, hgCamera, renderContext, 0LL);
		        s_snowRenderer = HG::Rendering::Runtime::HGEnvironmentManager::get_s_snowRenderer(0LL);
		        if ( s_snowRenderer )
		        {
		          HG::Rendering::Runtime::HGSnowRenderer::UpdateSnowData(s_snowRenderer, hgCamera, renderContext, 0LL);
		          return;
		        }
		      }
		LABEL_30:
		      sub_1800D8260(this, wrapperArray);
		    }
		LABEL_60:
		    sub_1800D2AB0(this, wrapperArray);
		  }
		  v17 = IFix::WrappersManagerImpl::GetPatch(794, 0LL);
		  if ( !v17 )
		    goto LABEL_30;
		  if ( !IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)v17, (Object *)hgCamera, 0LL) )
		    goto LABEL_24;
		}
		
		private Transform _GetInterpolateTrigger() => default; // 0x00000001831C8E90-0x00000001831C90E0
		// Transform _GetInterpolateTrigger()
		Transform *HG::Rendering::Runtime::HGEnvironmentManager::_GetInterpolateTrigger(
		        HGEnvironmentManager *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  struct Object_1__Class *v5; // rcx
		  Transform *m_interpolateTriggerOverride; // rbx
		  HGRenderPipeline *currentPipeline; // rax
		  struct Object_1__Class *v8; // rcx
		  Transform *currentPlayerCenter; // rbx
		  HGRenderPipeline *v10; // rax
		  Camera *main; // rax
		  struct Object_1__Class *v13; // rcx
		  Camera *v14; // rbx
		  __int64 (__fastcall *v15)(Camera *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_31;
		  if ( wrapperArray->max_length.size <= 620 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_31;
		  if ( LODWORD(v3->_0.namespaze) <= 0x26C )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[13]._0.typeMetadataHandle )
		  {
		LABEL_5:
		    v5 = TypeInfo::UnityEngine::Object;
		    m_interpolateTriggerOverride = this->fields.m_interpolateTriggerOverride;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v5 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( m_interpolateTriggerOverride )
		    {
		      if ( !v5->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v5);
		      if ( m_interpolateTriggerOverride->fields._._.m_CachedPtr )
		        return this->fields.m_interpolateTriggerOverride;
		    }
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		    if ( !currentPipeline )
		      goto LABEL_31;
		    v8 = TypeInfo::UnityEngine::Object;
		    currentPlayerCenter = currentPipeline->fields.currentPlayerCenter;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v8 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v8 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( !currentPlayerCenter )
		      goto LABEL_22;
		    if ( !v8->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v8);
		    if ( !currentPlayerCenter->fields._._.m_CachedPtr )
		    {
		LABEL_22:
		      main = UnityEngine::Camera::get_main(0LL);
		      v13 = TypeInfo::UnityEngine::Object;
		      v14 = main;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v13 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v13 = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( !v14 )
		        return 0LL;
		      if ( !v13->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v13);
		      if ( !v14->fields._._._.m_CachedPtr )
		        return 0LL;
		      v15 = (__int64 (__fastcall *)(Camera *))qword_18F36FBC0;
		      if ( !qword_18F36FBC0 )
		      {
		        v15 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Component::get_transform()");
		        qword_18F36FBC0 = (__int64)v15;
		      }
		      return (Transform *)v15(v14);
		    }
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    v10 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		    if ( v10 )
		      return v10->fields.currentPlayerCenter;
		LABEL_31:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(620, 0LL);
		  if ( !Patch )
		    goto LABEL_31;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_248(Patch, (Object *)this, 0LL);
		}
		
		private void _InterpolateVolumes(Transform interpolateTrigger) {} // 0x0000000182EE2770-0x0000000182EE28E0
		// Void _InterpolateVolumes(Transform)
		void HG::Rendering::Runtime::HGEnvironmentManager::_InterpolateVolumes(
		        HGEnvironmentManager *this,
		        Transform *interpolateTrigger,
		        MethodInfo *method)
		{
		  IndexedHashSet_1_System_Object_ *m_interpolatedVolumes; // rcx
		  Dictionary_2_System_Object_System_Int32___Class *klass; // rdx
		  struct Object_1__Class *v7; // rcx
		  Vector3 *p_m_lastInterpolateTriggerPosition; // rdx
		  Vector3__StaticFields *static_fields; // rcx
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  m_interpolatedVolumes = (IndexedHashSet_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_interpolatedVolumes = (IndexedHashSet_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  klass = m_interpolatedVolumes[5].fields.m_indexDict->klass;
		  if ( !klass )
		    goto LABEL_15;
		  if ( SLODWORD(klass->_0.namespaze) <= 621 )
		    goto LABEL_5;
		  if ( !LODWORD(m_interpolatedVolumes[7].klass) )
		  {
		    il2cpp_runtime_class_init_1(m_interpolatedVolumes);
		    m_interpolatedVolumes = (IndexedHashSet_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_interpolatedVolumes = (IndexedHashSet_1_System_Object_ *)m_interpolatedVolumes[5].fields.m_indexDict->klass;
		  if ( !m_interpolatedVolumes )
		LABEL_15:
		    sub_1800D8260(m_interpolatedVolumes, klass);
		  if ( LODWORD(m_interpolatedVolumes->fields.m_indexDict) <= 0x26D )
		    sub_1800D2AB0(m_interpolatedVolumes, klass);
		  if ( m_interpolatedVolumes[156].monitor )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(621, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)interpolateTrigger,
		        0LL);
		      return;
		    }
		    goto LABEL_15;
		  }
		LABEL_5:
		  m_interpolatedVolumes = (IndexedHashSet_1_System_Object_ *)this->fields.m_interpolatedVolumes;
		  if ( !m_interpolatedVolumes )
		    goto LABEL_15;
		  Beyond::IndexedHashSet<System::Object>::Clear(
		    m_interpolatedVolumes,
		    MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Clear);
		  m_interpolatedVolumes = (IndexedHashSet_1_System_Object_ *)this->fields.m_interpolatedVolumesFactor;
		  if ( !m_interpolatedVolumes )
		    goto LABEL_15;
		  ++HIDWORD(m_interpolatedVolumes->fields.m_indexDict);
		  LODWORD(m_interpolatedVolumes->fields.m_indexDict) = 0;
		  v7 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v7 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v7 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( interpolateTrigger )
		  {
		    if ( !v7->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v7);
		    p_m_lastInterpolateTriggerPosition = &this->fields.m_lastInterpolateTriggerPosition;
		    if ( interpolateTrigger->fields._._.m_CachedPtr )
		    {
		      HG::Rendering::Runtime::HGEnvironmentManager::_InterpolateVolumesImpl(
		        this,
		        0LL,
		        interpolateTrigger,
		        this->fields.m_interpolatedPhase,
		        &this->fields.m_lastInterpolateTriggerPosition,
		        this->fields.m_interpolatedVolumes,
		        this->fields.m_interpolatedVolumesFactor,
		        0LL);
		      return;
		    }
		  }
		  else
		  {
		    p_m_lastInterpolateTriggerPosition = &this->fields.m_lastInterpolateTriggerPosition;
		  }
		  static_fields = TypeInfo::UnityEngine::Vector3->static_fields;
		  z = static_fields->negativeInfinityVector.z;
		  *(_QWORD *)&p_m_lastInterpolateTriggerPosition->x = *(_QWORD *)&static_fields->negativeInfinityVector.x;
		  p_m_lastInterpolateTriggerPosition->z = z;
		}
		
		private void _InterpolateVolumesImpl(HGCamera hgCamera, Transform interpolateTrigger, HGEnvironmentPhase interpolatedPhaseTarget, ref Vector3 lastInterpolateTriggerPosition, IndexedHashSet<HGEnvironmentVolumeBase> interpolatedVolumes, List<float> interpolatedVolumesFactor) {} // 0x00000001832764A0-0x0000000183277EC0
		// Void _InterpolateVolumesImpl(HGCamera, Transform, HGEnvironmentPhase, Vector3 ByRef, IndexedHashSet`1[HG.Rendering.Runtime.HGEnvironmentVolumeBase], List`1[System.Single])
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGEnvironmentManager::_InterpolateVolumesImpl(
		        HGEnvironmentManager *this,
		        HGCamera *hgCamera,
		        Transform *interpolateTrigger,
		        HGEnvironmentPhase *interpolatedPhaseTarget,
		        Vector3 *lastInterpolateTriggerPosition,
		        IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *interpolatedVolumes,
		        List_1_System_Single_ *interpolatedVolumesFactor,
		        MethodInfo *method)
		{
		  Object *v8; // r14
		  Object *v9; // r15
		  struct ILFixDynamicMethodWrapper_2__Class *v12; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v14; // rbx
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rbx
		  void (__fastcall *v18)(Object *, Vector3 *); // rax
		  MethodInfo *v19; // r9
		  Vector3 *v20; // rax
		  __int64 v21; // rdx
		  __int64 v22; // r8
		  unsigned int z_low; // esi
		  struct Math__Class *v24; // rcx
		  __m128 v25; // xmm2
		  __m128d v26; // xmm3
		  __m128d v27; // xmm0
		  float v28; // xmm0_4
		  float m_interpolateTimeFactor; // xmm11_4
		  __m128d v30; // xmm10
		  void (__fastcall *v31)(Object *, Vector3 *); // rax
		  Type *v32; // rdx
		  __int64 v33; // rcx
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  List_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *m_sortedVolumes; // rbx
		  _QWORD *p_klass; // r12
		  struct Object_1__Class *v38; // rcx
		  unsigned __int8 (__fastcall *v39)(_QWORD *); // rax
		  __int64 v40; // r8
		  struct ILFixDynamicMethodWrapper_2__Class *v41; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v42; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v43; // rcx
		  ILFixDynamicMethodWrapper_2 *v44; // r13
		  Call *v45; // rax
		  __m128i v46; // xmm6
		  __m128i v47; // xmm2
		  Object *anonObj; // r12
		  _DWORD *v49; // xmm0_8
		  signed __int64 v50; // rcx
		  __int64 v51; // rdx
		  __int64 v52; // r15
		  Object__Array *clearDelegate; // r14
		  __int64 v54; // rdi
		  Object__Class *klass; // rsi
		  Func_2_Google_Protobuf_IMessage_Boolean_ *hasDelegate; // rbx
		  Value_1 *v57; // r15
		  signed __int64 v58; // rcx
		  __int64 v59; // rdx
		  __int64 v60; // rdi
		  Il2CppClass *element_class; // rbx
		  __int64 v62; // rsi
		  __int64 v63; // rdx
		  VirtualMachine *virtualMachine; // rcx
		  __int64 v65; // rcx
		  int v66; // eax
		  IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *v67; // rsi
		  ILFixDynamicMethodWrapper_2__Array *v68; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v69; // rcx
		  ILFixDynamicMethodWrapper_2 *v70; // r13
		  Call *v71; // rax
		  __m128i v72; // xmm6
		  __m128i v73; // xmm2
		  Object *v74; // r12
		  _DWORD *v75; // xmm0_8
		  signed __int64 v76; // rcx
		  __int64 v77; // rdx
		  __int64 v78; // r15
		  Object__Array *v79; // r14
		  __int64 v80; // rdi
		  Object__Class *v81; // rsi
		  Func_2_Google_Protobuf_IMessage_Boolean_ *v82; // rbx
		  Value_1 *v83; // r15
		  signed __int64 v84; // rcx
		  __int64 v85; // rdx
		  __int64 v86; // rdi
		  Il2CppClass *v87; // rbx
		  __int64 v88; // rsi
		  __int64 v89; // rdx
		  VirtualMachine *v90; // rcx
		  __int64 v91; // rcx
		  int v92; // eax
		  ILFixDynamicMethodWrapper_2__Array *v93; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v94; // rcx
		  ILFixDynamicMethodWrapper_2 *v95; // r13
		  Call *v96; // rax
		  __m128i v97; // xmm6
		  __m128i v98; // xmm2
		  Object *v99; // r12
		  _DWORD *v100; // xmm0_8
		  signed __int64 v101; // rcx
		  __int64 v102; // rdx
		  __int64 v103; // r15
		  Object__Array *v104; // r14
		  __int64 v105; // rdi
		  Object__Class *v106; // rsi
		  Func_2_Google_Protobuf_IMessage_Boolean_ *v107; // rbx
		  Value_1 *v108; // r15
		  signed __int64 v109; // rcx
		  __int64 v110; // rdx
		  __int64 v111; // rdi
		  Il2CppClass *v112; // rbx
		  __int64 v113; // rsi
		  __int64 v114; // rdx
		  VirtualMachine *v115; // rcx
		  int v116; // eax
		  __int64 v117; // rdx
		  float manualBlendFactor; // xmm0_4
		  Mathf__StaticFields *v119; // rcx
		  __int64 v120; // rcx
		  __int64 v121; // rdx
		  __int64 v122; // rcx
		  HGEnvironmentPhase *v123; // rbx
		  float v124; // xmm6_4
		  __int64 v125; // rdx
		  __int64 v126; // rcx
		  float v127; // xmm0_4
		  __int64 v128; // rdx
		  __int64 v129; // rcx
		  __int64 v130; // rdx
		  __int64 v131; // rcx
		  List_1_System_Single_ *v132; // rdi
		  void (__fastcall *v133)(Transform *, Vector3 *); // rax
		  __int64 v134; // rdx
		  bool v135; // di
		  Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v136; // rcx
		  __int64 v137; // rdx
		  Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v138; // rcx
		  Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v139; // rcx
		  char v140; // bl
		  Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v141; // rcx
		  __int64 v142; // rdx
		  Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v143; // rcx
		  Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v144; // rcx
		  __m128i v145; // xmm6
		  __m128i v146; // xmm1
		  Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v147; // rcx
		  Mathf__StaticFields *v148; // rcx
		  __int64 v149; // rdx
		  __int64 v150; // rcx
		  HGEnvironmentPhase *v151; // rbx
		  float v152; // xmm7_4
		  __int64 v153; // rdx
		  __int64 v154; // rcx
		  __int64 v155; // rdx
		  __int64 v156; // rcx
		  __int64 v157; // rdx
		  __int64 v158; // rcx
		  __int64 v159; // r8
		  struct MethodInfo *v160; // rbx
		  Single__Array *items; // rcx
		  __int64 size; // rdx
		  void (__fastcall *v163)(Transform *, Vector3 *); // rax
		  float DistanceBlendFactor; // xmm6_4
		  Mathf__StaticFields *static_fields; // rcx
		  __int64 v166; // rdx
		  __int64 v167; // rcx
		  HGEnvironmentPhase *v168; // rbx
		  float s_timeOfDay; // xmm7_4
		  __int64 v170; // rdx
		  __int64 v171; // rcx
		  __int64 v172; // rdx
		  __int64 v173; // rcx
		  __int64 v174; // rcx
		  void (__fastcall *v175)(Object *, Vector3 *); // rax
		  __int64 v176; // r8
		  struct ILFixDynamicMethodWrapper_2__Class *v177; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v178; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v179; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v180; // rcx
		  ILFixDynamicMethodWrapper_2 *v181; // rcx
		  __int64 v182; // rdx
		  __int64 v183; // rcx
		  HGEnvironmentPhase *v184; // rbx
		  float v185; // xmm6_4
		  __int64 v186; // rdx
		  __int64 v187; // rcx
		  __int64 v188; // rdx
		  __int64 v189; // rcx
		  __int64 v190; // rdx
		  __int64 v191; // rcx
		  __int64 v192; // r8
		  struct MethodInfo *v193; // rbx
		  Single__Array *v194; // rcx
		  __int64 v195; // rdx
		  __int64 v196; // rax
		  __int64 v197; // rax
		  __int64 v198; // rax
		  __int64 v199; // rax
		  __int64 v200; // rax
		  __int64 v201; // rax
		  __int64 v202; // rax
		  __int64 v203; // rax
		  __int64 v204; // rax
		  __int64 v205; // rax
		  __int64 v206; // rax
		  __int64 v207; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-208h]
		  Vector3 v209; // [rsp+50h] [rbp-1D8h] BYREF
		  Value_1 *evaluationStackBase; // [rsp+60h] [rbp-1C8h]
		  Vector3 v211; // [rsp+70h] [rbp-1B8h] BYREF
		  Vector3 v212; // [rsp+80h] [rbp-1A8h] BYREF
		  HGEnvironmentVolumeBase *current; // [rsp+90h] [rbp-198h]
		  SingleFieldAccessor v214; // [rsp+98h] [rbp-190h] BYREF
		  Value_1 **topWriteBack; // [rsp+D0h] [rbp-158h]
		  Vector3 v216; // [rsp+E0h] [rbp-148h] BYREF
		  Vector3 v217; // [rsp+F0h] [rbp-138h] BYREF
		  Vector3 v218; // [rsp+100h] [rbp-128h] BYREF
		  Vector3 v219; // [rsp+110h] [rbp-118h] BYREF
		  Vector3 v220; // [rsp+120h] [rbp-108h] BYREF
		  List_1_T_Enumerator_System_Object_ v221; // [rsp+130h] [rbp-F8h] BYREF
		  Il2CppExceptionWrapper *v222; // [rsp+148h] [rbp-E0h] BYREF
		  Vector3 v223; // [rsp+150h] [rbp-D8h] BYREF
		  Call v224[3]; // [rsp+160h] [rbp-C8h] BYREF
		
		  v8 = (Object *)interpolatedPhaseTarget;
		  v9 = (Object *)interpolateTrigger;
		  v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v12->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v12, hgCamera);
		  if ( wrapperArray->max_length.size > 622 )
		  {
		    if ( !v12->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v12);
		      v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v14 = v12->static_fields->wrapperArray;
		    if ( !v14 )
		      sub_1800D8260(v12, hgCamera);
		    if ( v14->max_length.size <= 0x26Eu )
		      sub_1800D2AB0(v12, hgCamera);
		    if ( v14[17].vector[10] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(622, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v16, v15);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_259(
		        Patch,
		        (Object *)this,
		        (Object *)hgCamera,
		        v9,
		        v8,
		        lastInterpolateTriggerPosition,
		        (Object *)interpolatedVolumes,
		        (Object *)interpolatedVolumesFactor,
		        0LL);
		      return;
		    }
		  }
		  if ( !v9 )
		    sub_1800D8260(v12, hgCamera);
		  *(_QWORD *)&v209.x = 0LL;
		  v209.z = 0.0;
		  v18 = (void (__fastcall *)(Object *, Vector3 *))qword_18F3700F0;
		  if ( !qword_18F3700F0 )
		  {
		    v18 = (void (__fastcall *)(Object *, Vector3 *))il2cpp_resolve_icall_1(
		                                                      "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		    if ( !v18 )
		    {
		      v196 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v196, 0LL);
		    }
		    qword_18F3700F0 = (__int64)v18;
		  }
		  v18(v9, &v209);
		  v211 = *lastInterpolateTriggerPosition;
		  v212 = v209;
		  v20 = UnityEngine::Vector3::op_Subtraction(&v216, &v212, &v211, v19);
		  *(_QWORD *)&v211.x = *(_QWORD *)&v20->x;
		  z_low = LODWORD(v20->z);
		  v24 = TypeInfo::System::Math;
		  if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		  v25 = (__m128)_mm_cvtsi32_si128(z_low);
		  v25.m128_f32[0] = (float)(v25.m128_f32[0] * v25.m128_f32[0])
		                  + (float)((float)(v211.y * v211.y) + (float)(v211.x * v211.x));
		  v26 = _mm_cvtps_pd(v25);
		  if ( v26.m128d_f64[0] < 0.0 )
		  {
		    v27.m128d_f64[1] = v26.m128d_f64[1];
		    v27.m128d_f64[0] = sub_1801D32D0(v24, v21, v22);
		  }
		  else
		  {
		    v27 = _mm_sqrt_pd(v26);
		  }
		  v28 = v27.m128d_f64[0];
		  if ( v28 <= 5.0 )
		    m_interpolateTimeFactor = this->fields.m_interpolateTimeFactor;
		  else
		    m_interpolateTimeFactor = 10000.0;
		  *(float *)v27.m128d_f64 = UnityEngine::Time::get_deltaTime(0LL);
		  v30 = v27;
		  memset(&v209, 0, sizeof(v209));
		  v31 = (void (__fastcall *)(Object *, Vector3 *))qword_18F3700F0;
		  if ( !qword_18F3700F0 )
		  {
		    v31 = (void (__fastcall *)(Object *, Vector3 *))il2cpp_resolve_icall_1(
		                                                      "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		    if ( !v31 )
		    {
		      v197 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		      sub_18007E1B0(v197, 0LL);
		    }
		    qword_18F3700F0 = (__int64)v31;
		  }
		  v31(v9, &v209);
		  *lastInterpolateTriggerPosition = v209;
		  m_sortedVolumes = this->fields.m_sortedVolumes;
		  if ( !m_sortedVolumes )
		    sub_1800D8260(v33, v32);
		  *(_OWORD *)&v214.monitor = 0LL;
		  v214.klass = (SingleFieldAccessor__Class *)m_sortedVolumes;
		  sub_18002D1B0(&v214, v32, v34, v35, P3);
		  LODWORD(v214.monitor) = 0;
		  HIDWORD(v214.monitor) = m_sortedVolumes->fields._version;
		  v214.fields._.getValueDelegate = 0LL;
		  *(_OWORD *)&v221._list = *(_OWORD *)&v214.klass;
		  v221._current = 0LL;
		  v214.klass = 0LL;
		  v214.monitor = (MonitorData *)&v221;
		  try
		  {
		    v67 = interpolatedVolumes;
		    while ( 1 )
		    {
		      while ( 1 )
		      {
		        while ( 1 )
		        {
		          while ( 1 )
		          {
		            if ( !System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                    &v221,
		                    MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::MoveNext) )
		              return;
		            p_klass = &v221._current->klass;
		            current = (HGEnvironmentVolumeBase *)v221._current;
		            v38 = TypeInfo::UnityEngine::Object;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              v38 = TypeInfo::UnityEngine::Object;
		              if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                v38 = TypeInfo::UnityEngine::Object;
		              }
		            }
		            if ( p_klass )
		            {
		              if ( !v38->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(v38);
		              if ( p_klass[2] )
		              {
		                v39 = (unsigned __int8 (__fastcall *)(_QWORD *))qword_18F36FBB8;
		                if ( !qword_18F36FBB8 )
		                {
		                  v39 = (unsigned __int8 (__fastcall *)(_QWORD *))il2cpp_resolve_icall_1("UnityEngine.Behaviour::get_isActiveAndEnabled()");
		                  if ( !v39 )
		                  {
		                    v198 = sub_1802EE1B8("UnityEngine.Behaviour::get_isActiveAndEnabled()");
		                    sub_18007E1B0(v198, 0LL);
		                  }
		                  qword_18F36FBB8 = (__int64)v39;
		                }
		                if ( v39(p_klass) )
		                {
		                  sub_1800049A0(*p_klass);
		                  if ( (*(unsigned __int8 (__fastcall **)(_QWORD *, _QWORD))(*p_klass + 464LL))(
		                         p_klass,
		                         *(_QWORD *)(*p_klass + 472LL)) )
		                  {
		                    break;
		                  }
		                }
		              }
		            }
		          }
		          v41 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		            v41 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v42 = v41->static_fields->wrapperArray;
		          if ( !v42 )
		            sub_1800D8250(v41, 0LL);
		          if ( v42->max_length.size <= 623 )
		            goto LABEL_85;
		          if ( !v41->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v41);
		            v41 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v42 = v41->static_fields->wrapperArray;
		          if ( !v42 )
		            sub_1800D8250(v41, 0LL);
		          if ( v42->max_length.size <= 0x26Fu )
		            sub_1800D2AA0(v41, v42, v40);
		          if ( v42[17].vector[11] )
		          {
		            if ( !v41->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v41);
		              v41 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            v43 = v41->static_fields->wrapperArray;
		            if ( !v43 )
		              sub_1800D8250(0LL, v42);
		            if ( v43->max_length.size <= 0x26Fu )
		              sub_1800D2AA0(v43, v42, v40);
		            v44 = v43[17].vector[11];
		            if ( !v44 )
		              sub_1800D8250(v43, v42);
		            v45 = IFix::Core::Call::Begin(v224, 0LL);
		            v46 = *(__m128i *)&v45->argumentBase;
		            v47 = *(__m128i *)&v45->managedStack;
		            *(__m128i *)&v214.fields.clearDelegate = v47;
		            topWriteBack = v45->topWriteBack;
		            if ( v44->fields.anonObj )
		            {
		              anonObj = v44->fields.anonObj;
		              v49 = (_DWORD *)_mm_srli_si128(v47, 8).m128i_u64[0];
		              evaluationStackBase = (Value_1 *)_mm_srli_si128(v46, 8).m128i_u64[0];
		              v50 = (char *)v49 - (char *)evaluationStackBase;
		              v51 = (unsigned __int128)(((char *)v49 - (char *)evaluationStackBase) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		              v52 = ((char *)v49 - (char *)evaluationStackBase) / 12;
		              if ( !v49 )
		                sub_1800D8250(v50, v51);
		              *v49 = 8;
		              v49[1] = v52;
		              clearDelegate = (Object__Array *)v47.m128i_i64[0];
		              if ( !v47.m128i_i64[0] )
		                sub_1800D8250(v50, v51);
		              v54 = *(_QWORD *)(*(_QWORD *)v47.m128i_i64[0] + 64LL);
		              klass = anonObj->klass;
		              if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v54, anonObj->klass)
		                && ((BYTE1(klass->vtable.Equals.methodPtr) & 0x10) == 0
		                 || ((*(_BYTE *)(v54 + 276) & 0x20) == 0 && *(_BYTE *)(v54 + 42) != 19 && *(_BYTE *)(v54 + 42) != 30
		                  || !*(_QWORD *)(v54 + 112)
		                  || !*(_QWORD *)(*(_QWORD *)(v54 + 112) + 40LL)
		                  || !sub_1802ED414(anonObj))
		                 && v54 != qword_18F35FF70) )
		              {
		                v199 = sub_18031E23C();
		                sub_18007E190(v199, 0LL);
		              }
		              sub_180005370(v47.m128i_i64[0], (int)v52, anonObj);
		              hasDelegate = (Func_2_Google_Protobuf_IMessage_Boolean_ *)(v49 + 3);
		              v57 = evaluationStackBase;
		              p_klass = &current->klass;
		            }
		            else
		            {
		              hasDelegate = v214.fields.hasDelegate;
		              clearDelegate = (Object__Array *)v214.fields.clearDelegate;
		              v57 = (Value_1 *)_mm_srli_si128(v46, 8).m128i_u64[0];
		            }
		            v58 = (char *)hasDelegate - (char *)v57;
		            v59 = (unsigned __int128)(((char *)hasDelegate - (char *)v57) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		            v60 = ((char *)hasDelegate - (char *)v57) / 12;
		            if ( !hasDelegate )
		              sub_1800D8250(v58, v59);
		            LODWORD(hasDelegate->klass) = 8;
		            HIDWORD(hasDelegate->klass) = v60;
		            if ( !clearDelegate )
		              sub_1800D8250(v58, v59);
		            element_class = clearDelegate->klass->_0.element_class;
		            v62 = *p_klass;
		            if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(element_class, *p_klass)
		              && ((*(_BYTE *)(v62 + 313) & 0x10) == 0
		               || ((element_class->flags & 0x20) == 0
		                && *((_BYTE *)&element_class->byval_arg + 10) != 19
		                && *((_BYTE *)&element_class->byval_arg + 10) != 30
		                || !element_class->interopData
		                || !element_class->interopData->guid
		                || !sub_1802ED414(p_klass))
		               && element_class != (Il2CppClass *)qword_18F35FF70) )
		            {
		              v200 = sub_18031E23C();
		              sub_18007E190(v200, 0LL);
		            }
		            sub_180005370(clearDelegate, (int)v60, p_klass);
		            virtualMachine = v44->fields.virtualMachine;
		            if ( !virtualMachine )
		              sub_1800D8250(0LL, v63);
		            IFix::Core::VirtualMachine::Execute(
		              virtualMachine,
		              virtualMachine->fields.unmanagedCodes[v44->fields.methodId],
		              (Value_1 *)v46.m128i_i64[0],
		              clearDelegate,
		              v57,
		              (v44->fields.anonObj != 0LL) + 1,
		              v44->fields.methodId,
		              0,
		              topWriteBack,
		              0LL);
		            if ( !v46.m128i_i64[0] )
		              sub_1800D8250(v65, v42);
		            v66 = *(_DWORD *)(v46.m128i_i64[0] + 4);
		            v41 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            v8 = (Object *)interpolatedPhaseTarget;
		            v9 = (Object *)interpolateTrigger;
		            v67 = interpolatedVolumes;
		          }
		          else
		          {
		LABEL_85:
		            v66 = *((_DWORD *)p_klass + 10);
		          }
		          if ( !v66 )
		            break;
		          if ( !v41->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v41);
		            v41 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v68 = v41->static_fields->wrapperArray;
		          if ( !v68 )
		            sub_1800D8250(v41, 0LL);
		          if ( v68->max_length.size <= 623 )
		            goto LABEL_129;
		          if ( !v41->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v41);
		            v41 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v68 = v41->static_fields->wrapperArray;
		          if ( !v68 )
		            sub_1800D8250(v41, 0LL);
		          if ( v68->max_length.size <= 0x26Fu )
		            sub_1800D2AA0(v41, v68, v40);
		          if ( v68[17].vector[11] )
		          {
		            if ( !v41->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v41);
		              v41 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            v69 = v41->static_fields->wrapperArray;
		            if ( !v69 )
		              sub_1800D8250(0LL, v68);
		            if ( v69->max_length.size <= 0x26Fu )
		              sub_1800D2AA0(v69, v68, v40);
		            v70 = v69[17].vector[11];
		            if ( !v70 )
		              sub_1800D8250(v69, v68);
		            v71 = IFix::Core::Call::Begin(v224, 0LL);
		            v72 = *(__m128i *)&v71->argumentBase;
		            v73 = *(__m128i *)&v71->managedStack;
		            *(__m128i *)&v214.fields.clearDelegate = v73;
		            topWriteBack = v71->topWriteBack;
		            if ( v70->fields.anonObj )
		            {
		              v74 = v70->fields.anonObj;
		              v75 = (_DWORD *)_mm_srli_si128(v73, 8).m128i_u64[0];
		              evaluationStackBase = (Value_1 *)_mm_srli_si128(v72, 8).m128i_u64[0];
		              v76 = (char *)v75 - (char *)evaluationStackBase;
		              v77 = (unsigned __int128)(((char *)v75 - (char *)evaluationStackBase) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		              v78 = ((char *)v75 - (char *)evaluationStackBase) / 12;
		              if ( !v75 )
		                sub_1800D8250(v76, v77);
		              *v75 = 8;
		              v75[1] = v78;
		              v79 = (Object__Array *)v73.m128i_i64[0];
		              if ( !v73.m128i_i64[0] )
		                sub_1800D8250(v76, v77);
		              v80 = *(_QWORD *)(*(_QWORD *)v73.m128i_i64[0] + 64LL);
		              v81 = v74->klass;
		              if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v80, v74->klass)
		                && ((BYTE1(v81->vtable.Equals.methodPtr) & 0x10) == 0
		                 || ((*(_BYTE *)(v80 + 276) & 0x20) == 0 && *(_BYTE *)(v80 + 42) != 19 && *(_BYTE *)(v80 + 42) != 30
		                  || !*(_QWORD *)(v80 + 112)
		                  || !*(_QWORD *)(*(_QWORD *)(v80 + 112) + 40LL)
		                  || !sub_1802ED414(v74))
		                 && v80 != qword_18F35FF70) )
		              {
		                v201 = sub_18031E23C();
		                sub_18007E190(v201, 0LL);
		              }
		              sub_180005370(v73.m128i_i64[0], (int)v78, v74);
		              v82 = (Func_2_Google_Protobuf_IMessage_Boolean_ *)(v75 + 3);
		              v83 = evaluationStackBase;
		              p_klass = &current->klass;
		            }
		            else
		            {
		              v82 = v214.fields.hasDelegate;
		              v79 = (Object__Array *)v214.fields.clearDelegate;
		              v83 = (Value_1 *)_mm_srli_si128(v72, 8).m128i_u64[0];
		            }
		            v84 = (char *)v82 - (char *)v83;
		            v85 = (unsigned __int128)(((char *)v82 - (char *)v83) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		            v86 = ((char *)v82 - (char *)v83) / 12;
		            if ( !v82 )
		              sub_1800D8250(v84, v85);
		            LODWORD(v82->klass) = 8;
		            HIDWORD(v82->klass) = v86;
		            if ( !v79 )
		              sub_1800D8250(v84, v85);
		            v87 = v79->klass->_0.element_class;
		            v88 = *p_klass;
		            if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v87, *p_klass)
		              && ((*(_BYTE *)(v88 + 313) & 0x10) == 0
		               || ((v87->flags & 0x20) == 0
		                && *((_BYTE *)&v87->byval_arg + 10) != 19
		                && *((_BYTE *)&v87->byval_arg + 10) != 30
		                || !v87->interopData
		                || !v87->interopData->guid
		                || !sub_1802ED414(p_klass))
		               && v87 != (Il2CppClass *)qword_18F35FF70) )
		            {
		              v202 = sub_18031E23C();
		              sub_18007E190(v202, 0LL);
		            }
		            sub_180005370(v79, (int)v86, p_klass);
		            v90 = v70->fields.virtualMachine;
		            if ( !v90 )
		              sub_1800D8250(0LL, v89);
		            IFix::Core::VirtualMachine::Execute(
		              v90,
		              v90->fields.unmanagedCodes[v70->fields.methodId],
		              (Value_1 *)v72.m128i_i64[0],
		              v79,
		              v83,
		              (v70->fields.anonObj != 0LL) + 1,
		              v70->fields.methodId,
		              0,
		              topWriteBack,
		              0LL);
		            if ( !v72.m128i_i64[0] )
		              sub_1800D8250(v91, v68);
		            v92 = *(_DWORD *)(v72.m128i_i64[0] + 4);
		            v41 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          else
		          {
		LABEL_129:
		            v92 = *((_DWORD *)p_klass + 10);
		          }
		          if ( v92 == 1 )
		          {
		            v9 = (Object *)interpolateTrigger;
		            if ( !interpolateTrigger )
		              sub_1800D8250(v41, v68);
		            *(_QWORD *)&v211.x = 0LL;
		            v211.z = 0.0;
		            v163 = (void (__fastcall *)(Transform *, Vector3 *))qword_18F3700F0;
		            if ( !qword_18F3700F0 )
		            {
		              v163 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_1(
		                                                                    "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		              if ( !v163 )
		              {
		                v206 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		                sub_18007E1B0(v206, 0LL);
		              }
		              qword_18F3700F0 = (__int64)v163;
		            }
		            v163(interpolateTrigger, &v211);
		            v219 = v211;
		            DistanceBlendFactor = HG::Rendering::Runtime::HGEnvironmentVolumeBase::GetDistanceBlendFactor(
		                                    (HGEnvironmentVolumeBase *)p_klass,
		                                    &v219,
		                                    0LL);
		            static_fields = TypeInfo::UnityEngine::Mathf->static_fields;
		            v8 = (Object *)interpolatedPhaseTarget;
		            v67 = interpolatedVolumes;
		            if ( DistanceBlendFactor > static_fields->Epsilon )
		            {
		              v168 = (HGEnvironmentPhase *)sub_18008B570(static_fields, p_klass);
		              if ( !v168 )
		                sub_1800D8250(v167, v166);
		              if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		              s_timeOfDay = HG::Rendering::Runtime::HGEnvironmentManager::get_s_timeOfDay(0LL);
		              if ( !TypeInfo::HG::Rendering::Runtime::HGLightConfig->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
		              HG::Rendering::Runtime::HGLightConfig::UpdateDirectFinalDirection(
		                &v168->fields.lightConfig,
		                s_timeOfDay,
		                0LL);
		              v8 = (Object *)interpolatedPhaseTarget;
		              if ( !interpolatedPhaseTarget )
		                sub_1800D8250(v171, v170);
		              HG::Rendering::Runtime::HGEnvironmentPhase::Lerp(
		                interpolatedPhaseTarget,
		                interpolatedPhaseTarget,
		                v168,
		                DistanceBlendFactor,
		                0LL);
		              if ( !interpolatedVolumes )
		                sub_1800D8250(v173, v172);
		              Beyond::IndexedHashSet<System::Object>::Add(
		                (IndexedHashSet_1_System_Object_ *)interpolatedVolumes,
		                (Object *)p_klass,
		                MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Add);
		              v132 = interpolatedVolumesFactor;
		              if ( !interpolatedVolumesFactor )
		                sub_1800D8250(v174, v130);
		LABEL_250:
		              sub_1830BADF0(v132, v130, MethodInfo::System::Collections::Generic::List<float>::Add);
		            }
		          }
		          else
		          {
		            if ( !v41->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v41);
		              v41 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            v93 = v41->static_fields->wrapperArray;
		            if ( !v93 )
		              sub_1800D8250(v41, 0LL);
		            if ( v93->max_length.size <= 623 )
		              goto LABEL_173;
		            if ( !v41->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(v41);
		              v41 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		            }
		            v93 = v41->static_fields->wrapperArray;
		            if ( !v93 )
		              sub_1800D8250(v41, 0LL);
		            if ( v93->max_length.size <= 0x26Fu )
		              sub_1800D2AA0(v41, v93, v40);
		            if ( v93[17].vector[11] )
		            {
		              if ( !v41->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(v41);
		                v41 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		              }
		              v94 = v41->static_fields->wrapperArray;
		              if ( !v94 )
		                sub_1800D8250(0LL, v93);
		              if ( v94->max_length.size <= 0x26Fu )
		                sub_1800D2AA0(v94, v93, v40);
		              v95 = v94[17].vector[11];
		              if ( !v95 )
		                sub_1800D8250(v94, v93);
		              v96 = IFix::Core::Call::Begin(v224, 0LL);
		              v97 = *(__m128i *)&v96->argumentBase;
		              v98 = *(__m128i *)&v96->managedStack;
		              *(__m128i *)&v214.fields.clearDelegate = v98;
		              topWriteBack = v96->topWriteBack;
		              if ( v95->fields.anonObj )
		              {
		                v99 = v95->fields.anonObj;
		                v100 = (_DWORD *)_mm_srli_si128(v98, 8).m128i_u64[0];
		                evaluationStackBase = (Value_1 *)_mm_srli_si128(v97, 8).m128i_u64[0];
		                v101 = (char *)v100 - (char *)evaluationStackBase;
		                v102 = (unsigned __int128)(((char *)v100 - (char *)evaluationStackBase) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		                v103 = ((char *)v100 - (char *)evaluationStackBase) / 12;
		                if ( !v100 )
		                  sub_1800D8250(v101, v102);
		                *v100 = 8;
		                v100[1] = v103;
		                v104 = (Object__Array *)v98.m128i_i64[0];
		                if ( !v98.m128i_i64[0] )
		                  sub_1800D8250(v101, v102);
		                v105 = *(_QWORD *)(*(_QWORD *)v98.m128i_i64[0] + 64LL);
		                v106 = v99->klass;
		                if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v105, v99->klass)
		                  && ((BYTE1(v106->vtable.Equals.methodPtr) & 0x10) == 0
		                   || ((*(_BYTE *)(v105 + 276) & 0x20) == 0
		                    && *(_BYTE *)(v105 + 42) != 19
		                    && *(_BYTE *)(v105 + 42) != 30
		                    || !*(_QWORD *)(v105 + 112)
		                    || !*(_QWORD *)(*(_QWORD *)(v105 + 112) + 40LL)
		                    || !sub_1802ED414(v99))
		                   && v105 != qword_18F35FF70) )
		                {
		                  v203 = sub_18031E23C();
		                  sub_18007E190(v203, 0LL);
		                }
		                sub_180005370(v98.m128i_i64[0], (int)v103, v99);
		                v107 = (Func_2_Google_Protobuf_IMessage_Boolean_ *)(v100 + 3);
		                v108 = evaluationStackBase;
		                p_klass = &current->klass;
		              }
		              else
		              {
		                v107 = v214.fields.hasDelegate;
		                v104 = (Object__Array *)v214.fields.clearDelegate;
		                v108 = (Value_1 *)_mm_srli_si128(v97, 8).m128i_u64[0];
		              }
		              v109 = (char *)v107 - (char *)v108;
		              v110 = (unsigned __int128)(((char *)v107 - (char *)v108) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		              v111 = ((char *)v107 - (char *)v108) / 12;
		              if ( !v107 )
		                sub_1800D8250(v109, v110);
		              LODWORD(v107->klass) = 8;
		              HIDWORD(v107->klass) = v111;
		              if ( !v104 )
		                sub_1800D8250(v109, v110);
		              v112 = v104->klass->_0.element_class;
		              v113 = *p_klass;
		              if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v112, *p_klass)
		                && ((*(_BYTE *)(v113 + 313) & 0x10) == 0
		                 || ((v112->flags & 0x20) == 0
		                  && *((_BYTE *)&v112->byval_arg + 10) != 19
		                  && *((_BYTE *)&v112->byval_arg + 10) != 30
		                  || !v112->interopData
		                  || !v112->interopData->guid
		                  || !sub_1802ED414(p_klass))
		                 && v112 != (Il2CppClass *)qword_18F35FF70) )
		              {
		                v204 = sub_18031E23C();
		                sub_18007E190(v204, 0LL);
		              }
		              sub_180005370(v104, (int)v111, p_klass);
		              v115 = v95->fields.virtualMachine;
		              if ( !v115 )
		                sub_1800D8250(0LL, v114);
		              IFix::Core::VirtualMachine::Execute(
		                v115,
		                v115->fields.unmanagedCodes[v95->fields.methodId],
		                (Value_1 *)v97.m128i_i64[0],
		                v104,
		                v108,
		                (v95->fields.anonObj != 0LL) + 1,
		                v95->fields.methodId,
		                0,
		                topWriteBack,
		                0LL);
		              if ( !v97.m128i_i64[0] )
		                sub_1800D8250(v41, v93);
		              v116 = *(_DWORD *)(v97.m128i_i64[0] + 4);
		            }
		            else
		            {
		LABEL_173:
		              v116 = *((_DWORD *)p_klass + 10);
		            }
		            if ( v116 == 2 )
		            {
		              v9 = (Object *)interpolateTrigger;
		              if ( !interpolateTrigger )
		                sub_1800D8250(v41, v93);
		              *(_QWORD *)&v212.x = 0LL;
		              v212.z = 0.0;
		              v133 = (void (__fastcall *)(Transform *, Vector3 *))qword_18F3700F0;
		              if ( !qword_18F3700F0 )
		              {
		                v133 = (void (__fastcall *)(Transform *, Vector3 *))il2cpp_resolve_icall_1(
		                                                                      "UnityEngine.Transform::get_position_Injected(Unity"
		                                                                      "Engine.Vector3&)");
		                if ( !v133 )
		                {
		                  v205 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		                  sub_18007E1B0(v205, 0LL);
		                }
		                qword_18F3700F0 = (__int64)v133;
		              }
		              v133(interpolateTrigger, &v212);
		              v218 = v212;
		              v135 = HG::Rendering::Runtime::HGEnvironmentVolumeBase::Contains(
		                       (HGEnvironmentVolumeBase *)p_klass,
		                       &v218,
		                       0LL);
		              if ( v135 || !hgCamera )
		              {
		LABEL_200:
		                v140 = 0;
		                if ( hgCamera )
		                {
		                  v141 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)p_klass[10];
		                  if ( !v141 )
		                    sub_1800D8250(0LL, v134);
		                  if ( !System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::ContainsKey(
		                          v141,
		                          (Object *)hgCamera,
		                          MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::ContainsKey) )
		                  {
		                    v143 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)p_klass[10];
		                    if ( !v143 )
		                      sub_1800D8250(0LL, v142);
		                    System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::Add(
		                      v143,
		                      (Object *)hgCamera,
		                      (HGEnvironmentVolumeBase_InterpolateDataPerCamera)_mm_cvtsi128_si32((__m128i)0LL),
		                      MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::Add);
		                  }
		                  v140 = 1;
		                  v144 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)p_klass[10];
		                  if ( !v144 )
		                    sub_1800D8250(0LL, v142);
		                  v145 = _mm_cvtsi32_si128((unsigned int)System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::get_Item(
		                                                           v144,
		                                                           (Object *)hgCamera,
		                                                           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::get_Item).timeFadingFactor);
		                  LODWORD(current) = v145.m128i_i32[0];
		                }
		                else
		                {
		                  v145 = (__m128i)*((unsigned int *)p_klass + 19);
		                }
		                if ( *(float *)v30.m128d_f64 > TypeInfo::UnityEngine::Mathf->static_fields->Epsilon )
		                {
		                  if ( !v135 || *((_BYTE *)p_klass + 72) )
		                  {
		                    *(float *)v145.m128i_i32 = *(float *)v145.m128i_i32
		                                             - (float)((float)(*(float *)v30.m128d_f64 * m_interpolateTimeFactor)
		                                                     / HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_fadeOutDuration(
		                                                         (HGEnvironmentVolumeBase *)p_klass,
		                                                         0LL));
		                  }
		                  else
		                  {
		                    v146 = (__m128i)v30;
		                    *(float *)v146.m128i_i32 = (float)((float)(*(float *)v30.m128d_f64 * m_interpolateTimeFactor)
		                                                     / HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_fadeInDuration(
		                                                         (HGEnvironmentVolumeBase *)p_klass,
		                                                         0LL))
		                                             + *(float *)v145.m128i_i32;
		                    v145 = v146;
		                  }
		                }
		                if ( *(float *)v145.m128i_i32 < 0.0 )
		                {
		                  v145 = 0LL;
		                }
		                else if ( *(float *)v145.m128i_i32 > 1.0 )
		                {
		                  v145 = (__m128i)0x3F800000u;
		                }
		                if ( v140 )
		                {
		                  v147 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)p_klass[10];
		                  if ( !v147 )
		                    sub_1800D8250(0LL, v134);
		                  System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::set_Item(
		                    v147,
		                    (Object *)hgCamera,
		                    (HGEnvironmentVolumeBase_InterpolateDataPerCamera)_mm_cvtsi128_si32(v145),
		                    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::set_Item);
		                }
		                else
		                {
		                  *((_DWORD *)p_klass + 19) = v145.m128i_i32[0];
		                }
		                v148 = TypeInfo::UnityEngine::Mathf->static_fields;
		                v8 = (Object *)interpolatedPhaseTarget;
		                v67 = interpolatedVolumes;
		                if ( *(float *)v145.m128i_i32 > v148->Epsilon )
		                {
		                  v151 = (HGEnvironmentPhase *)sub_18008B570(v148, p_klass);
		                  if ( !v151 )
		                    sub_1800D8250(v150, v149);
		                  if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		                    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		                  v152 = HG::Rendering::Runtime::HGEnvironmentManager::get_s_timeOfDay(0LL);
		                  if ( !TypeInfo::HG::Rendering::Runtime::HGLightConfig->_1.cctor_finished_or_no_cctor )
		                    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
		                  HG::Rendering::Runtime::HGLightConfig::UpdateDirectFinalDirection(
		                    &v151->fields.lightConfig,
		                    v152,
		                    0LL);
		                  v8 = (Object *)interpolatedPhaseTarget;
		                  if ( !interpolatedPhaseTarget )
		                    sub_1800D8250(v154, v153);
		                  HG::Rendering::Runtime::HGEnvironmentPhase::Lerp(
		                    interpolatedPhaseTarget,
		                    interpolatedPhaseTarget,
		                    v151,
		                    *(float *)v145.m128i_i32,
		                    0LL);
		                  if ( !interpolatedVolumes )
		                    sub_1800D8250(v156, v155);
		                  Beyond::IndexedHashSet<System::Object>::Add(
		                    (IndexedHashSet_1_System_Object_ *)interpolatedVolumes,
		                    (Object *)p_klass,
		                    MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Add);
		                  if ( !interpolatedVolumesFactor )
		                    sub_1800D8250(v158, v157);
		                  v160 = MethodInfo::System::Collections::Generic::List<float>::Add;
		                  ++interpolatedVolumesFactor->fields._version;
		                  items = interpolatedVolumesFactor->fields._items;
		                  size = interpolatedVolumesFactor->fields._size;
		                  if ( !items )
		                    sub_1800D8250(0LL, size);
		                  if ( (unsigned int)size < items->max_length.size )
		                  {
		                    interpolatedVolumesFactor->fields._size = size + 1;
		                    if ( (unsigned int)size >= items->max_length.size )
		                      sub_1800D2AA0(items, size, v159);
		                    LODWORD(items->vector[size]) = v145.m128i_i32[0];
		                  }
		                  else
		                  {
		                    if ( !*((_QWORD *)v160->klass->rgctx_data[11].rgctxDataDummy + 4) )
		                      (*(void (**)(void))v160->klass->rgctx_data[11].rgctxDataDummy)();
		                    System::Collections::Generic::List<float>::AddWithResize(
		                      interpolatedVolumesFactor,
		                      *(float *)v145.m128i_i32,
		                      (MethodInfo *)v160->klass->rgctx_data[11].rgctxDataDummy);
		                  }
		                }
		              }
		              else
		              {
		                v136 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)p_klass[10];
		                if ( !v136 )
		                  sub_1800D8250(0LL, v134);
		                v8 = (Object *)interpolatedPhaseTarget;
		                v67 = interpolatedVolumes;
		                if ( System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::ContainsKey(
		                       v136,
		                       (Object *)hgCamera,
		                       MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::ContainsKey) )
		                {
		                  v138 = (Dictionary_2_System_Object_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)p_klass[10];
		                  if ( !v138 )
		                    sub_1800D8250(0LL, v137);
		                  if ( TypeInfo::UnityEngine::Mathf->static_fields->Epsilon <= System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::get_Item(
		                                                                                 v138,
		                                                                                 (Object *)hgCamera,
		                                                                                 MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::get_Item).timeFadingFactor )
		                    goto LABEL_200;
		                  v139 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)p_klass[10];
		                  if ( !v139 )
		                    sub_1800D8250(0LL, v134);
		                  System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Remove(
		                    v139,
		                    (Object *)hgCamera,
		                    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::Remove);
		                }
		              }
		            }
		            else
		            {
		              v8 = (Object *)interpolatedPhaseTarget;
		              v9 = (Object *)interpolateTrigger;
		              v67 = interpolatedVolumes;
		              if ( HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_blendMode(
		                     (HGEnvironmentVolumeBase *)p_klass,
		                     0LL) == EnvBlendMode__Enum_Manual )
		              {
		                manualBlendFactor = HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_manualBlendFactor(
		                                      (HGEnvironmentVolumeBase *)p_klass,
		                                      0LL);
		                v119 = TypeInfo::UnityEngine::Mathf->static_fields;
		                if ( manualBlendFactor > v119->Epsilon )
		                {
		                  if ( !interpolateTrigger )
		                    sub_1800D8250(v119, v117);
		                  v217 = *UnityEngine::Transform::get_position(&v223, interpolateTrigger, 0LL);
		                  if ( HG::Rendering::Runtime::HGEnvironmentVolumeBase::Contains(
		                         (HGEnvironmentVolumeBase *)p_klass,
		                         &v217,
		                         0LL) )
		                  {
		                    v123 = (HGEnvironmentPhase *)sub_18008B570(v120, p_klass);
		                    if ( !v123 )
		                      sub_1800D8250(v122, v121);
		                    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		                      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		                    v124 = HG::Rendering::Runtime::HGEnvironmentManager::get_s_timeOfDay(0LL);
		                    if ( !TypeInfo::HG::Rendering::Runtime::HGLightConfig->_1.cctor_finished_or_no_cctor )
		                      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
		                    HG::Rendering::Runtime::HGLightConfig::UpdateDirectFinalDirection(
		                      &v123->fields.lightConfig,
		                      v124,
		                      0LL);
		                    v127 = HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_manualBlendFactor(
		                             (HGEnvironmentVolumeBase *)p_klass,
		                             0LL);
		                    v8 = (Object *)interpolatedPhaseTarget;
		                    if ( !interpolatedPhaseTarget )
		                      sub_1800D8250(v126, v125);
		                    HG::Rendering::Runtime::HGEnvironmentPhase::Lerp(
		                      interpolatedPhaseTarget,
		                      interpolatedPhaseTarget,
		                      v123,
		                      v127,
		                      0LL);
		                    if ( !interpolatedVolumes )
		                      sub_1800D8250(v129, v128);
		                    Beyond::IndexedHashSet<System::Object>::Add(
		                      (IndexedHashSet_1_System_Object_ *)interpolatedVolumes,
		                      (Object *)p_klass,
		                      MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Add);
		                    HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_manualBlendFactor(
		                      (HGEnvironmentVolumeBase *)p_klass,
		                      0LL);
		                    v132 = interpolatedVolumesFactor;
		                    if ( !interpolatedVolumesFactor )
		                      sub_1800D8250(v131, v130);
		                    goto LABEL_250;
		                  }
		                }
		              }
		            }
		          }
		        }
		        if ( !v9 )
		          sub_1800D8250(v41, v42);
		        memset(&v209, 0, sizeof(v209));
		        v175 = (void (__fastcall *)(Object *, Vector3 *))qword_18F3700F0;
		        if ( !qword_18F3700F0 )
		        {
		          v175 = (void (__fastcall *)(Object *, Vector3 *))il2cpp_resolve_icall_1(
		                                                             "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		          if ( !v175 )
		          {
		            v207 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		            sub_18007E1B0(v207, 0LL);
		          }
		          qword_18F3700F0 = (__int64)v175;
		        }
		        v175(v9, &v209);
		        v177 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		          v177 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v178 = v177->static_fields->wrapperArray;
		        if ( !v178 )
		          sub_1800D8250(v177, 0LL);
		        if ( v178->max_length.size > 624 )
		        {
		          if ( !v177->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v177);
		            v177 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v179 = v177->static_fields->wrapperArray;
		          if ( !v179 )
		            sub_1800D8250(v177, 0LL);
		          if ( v179->max_length.size <= 0x270u )
		            sub_1800D2AA0(v177, v179, v176);
		          if ( v179[17].vector[12] )
		            break;
		        }
		        v216 = v209;
		        if ( HG::Rendering::Runtime::HGEnvironmentVolumeBase::_DistanceToEdge(
		               (HGEnvironmentVolumeBase *)p_klass,
		               &v216,
		               0LL) > 0.0 )
		          goto LABEL_272;
		      }
		      if ( !v177->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v177);
		        v177 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v180 = v177->static_fields->wrapperArray;
		      if ( !v180 )
		        sub_1800D8250(0LL, v179);
		      if ( v180->max_length.size <= 0x270u )
		        sub_1800D2AA0(v180, v179, v176);
		      v181 = v180[17].vector[12];
		      if ( !v181 )
		        sub_1800D8250(0LL, v179);
		      v220 = v209;
		      if ( IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_255(v181, (Object *)p_klass, &v220, 0LL) )
		      {
		LABEL_272:
		        sub_1800049A0(*p_klass);
		        v184 = (HGEnvironmentPhase *)(*(__int64 (__fastcall **)(_QWORD *, _QWORD))(*p_klass + 480LL))(
		                                       p_klass,
		                                       *(_QWORD *)(*p_klass + 488LL));
		        if ( !v184 )
		          sub_1800D8250(v183, v182);
		        if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		        v185 = HG::Rendering::Runtime::HGEnvironmentManager::get_s_timeOfDay(0LL);
		        if ( !TypeInfo::HG::Rendering::Runtime::HGLightConfig->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightConfig);
		        HG::Rendering::Runtime::HGLightConfig::UpdateDirectFinalDirection(&v184->fields.lightConfig, v185, 0LL);
		        if ( !v8 )
		          sub_1800D8250(v187, v186);
		        HG::Rendering::Runtime::HGEnvironmentPhase::CopyFrom((HGEnvironmentPhase *)v8, v184, 0LL);
		        if ( !v67 )
		          sub_1800D8250(v189, v188);
		        Beyond::IndexedHashSet<System::Object>::Add(
		          (IndexedHashSet_1_System_Object_ *)v67,
		          (Object *)p_klass,
		          MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::Add);
		        if ( !interpolatedVolumesFactor )
		          sub_1800D8250(v191, v190);
		        v193 = MethodInfo::System::Collections::Generic::List<float>::Add;
		        ++interpolatedVolumesFactor->fields._version;
		        v194 = interpolatedVolumesFactor->fields._items;
		        v195 = interpolatedVolumesFactor->fields._size;
		        if ( !v194 )
		          sub_1800D8250(0LL, v195);
		        if ( (unsigned int)v195 < v194->max_length.size )
		        {
		          interpolatedVolumesFactor->fields._size = v195 + 1;
		          if ( (unsigned int)v195 >= v194->max_length.size )
		            sub_1800D2AA0(v194, v195, v192);
		          v194->vector[v195] = 1.0;
		        }
		        else
		        {
		          if ( !*((_QWORD *)v193->klass->rgctx_data[11].rgctxDataDummy + 4) )
		            (*(void (**)(void))v193->klass->rgctx_data[11].rgctxDataDummy)();
		          System::Collections::Generic::List<float>::AddWithResize(
		            interpolatedVolumesFactor,
		            1.0,
		            (MethodInfo *)v193->klass->rgctx_data[11].rgctxDataDummy);
		        }
		      }
		    }
		  }
		  catch ( Il2CppExceptionWrapper *v222 )
		  {
		    v214.klass = (SingleFieldAccessor__Class *)v222->ex;
		    if ( v214.klass )
		      sub_18007E1E0(v214.klass);
		  }
		}
		
	}
}
