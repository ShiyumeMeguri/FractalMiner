using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGRPTimeManager // TypeDefIndex: 37918
	{
		// Fields
		private static readonly Lazy<HGRPTimeManager> s_Instance; // 0x00
		public static readonly HGRPTimeManager instance; // 0x08
		private float m_time; // 0x10
		private float m_lastTime; // 0x14
		private float m_gameplayTime; // 0x18
		private float m_lastGameplayTime; // 0x1C
	
		// Properties
		public static float time { get => default; } // 0x00000001832DE480-0x00000001832DE510 
		// Single get_time()
		float HG::Rendering::Runtime::HGRPTimeManager::get_time(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  void *wrapperArray; // rcx
		  struct HGRPTimeManager__Class *v3; // rax
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
		  if ( *((int *)wrapperArray + 6) <= 801 )
		    goto LABEL_5;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( *((_DWORD *)wrapperArray + 6) <= 0x321u )
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !*((_QWORD *)wrapperArray + 805) )
		  {
		LABEL_5:
		    v3 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		      v3 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    }
		    wrapperArray = v3->static_fields->instance;
		    if ( wrapperArray )
		      return *((float *)wrapperArray + 4);
		LABEL_9:
		    sub_1800D8260(wrapperArray, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(801, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52((ILFixDynamicMethodWrapper_6 *)Patch, 0LL);
		}
		
		public static float lastTime { get => default; } // 0x00000001832DE510-0x00000001832DE5A0 
		// Single get_lastTime()
		float HG::Rendering::Runtime::HGRPTimeManager::get_lastTime(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  void *wrapperArray; // rcx
		  struct HGRPTimeManager__Class *v3; // rax
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
		  if ( *((int *)wrapperArray + 6) <= 890 )
		    goto LABEL_5;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( *((_DWORD *)wrapperArray + 6) <= 0x37Au )
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !*((_QWORD *)wrapperArray + 894) )
		  {
		LABEL_5:
		    v3 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		      v3 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    }
		    wrapperArray = v3->static_fields->instance;
		    if ( wrapperArray )
		      return *((float *)wrapperArray + 5);
		LABEL_9:
		    sub_1800D8260(wrapperArray, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(890, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52((ILFixDynamicMethodWrapper_6 *)Patch, 0LL);
		}
		
		public static float gameplayTime { get => default; } // 0x00000001832DE9A0-0x00000001832DEA30 
		// Single get_gameplayTime()
		float HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  void *wrapperArray; // rcx
		  struct HGRPTimeManager__Class *v3; // rax
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
		  if ( *((int *)wrapperArray + 6) <= 891 )
		    goto LABEL_5;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( *((_DWORD *)wrapperArray + 6) <= 0x37Bu )
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !*((_QWORD *)wrapperArray + 895) )
		  {
		LABEL_5:
		    v3 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		      v3 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    }
		    wrapperArray = v3->static_fields->instance;
		    if ( wrapperArray )
		      return *((float *)wrapperArray + 6);
		LABEL_9:
		    sub_1800D8260(wrapperArray, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(891, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52((ILFixDynamicMethodWrapper_6 *)Patch, 0LL);
		}
		
		public static float lastGameplayTime { get => default; } // 0x00000001832DEA30-0x00000001832DEAC0 
		// Single get_lastGameplayTime()
		float HG::Rendering::Runtime::HGRPTimeManager::get_lastGameplayTime(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  void *wrapperArray; // rcx
		  struct HGRPTimeManager__Class *v3; // rax
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
		  if ( *((int *)wrapperArray + 6) <= 892 )
		    goto LABEL_5;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( *((_DWORD *)wrapperArray + 6) <= 0x37Cu )
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !*((_QWORD *)wrapperArray + 896) )
		  {
		LABEL_5:
		    v3 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		      v3 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    }
		    wrapperArray = v3->static_fields->instance;
		    if ( wrapperArray )
		      return *((float *)wrapperArray + 7);
		LABEL_9:
		    sub_1800D8260(wrapperArray, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(892, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52((ILFixDynamicMethodWrapper_6 *)Patch, 0LL);
		}
		
		public static float deltaTime { get => default; } // 0x00000001832E0FE0-0x00000001832E10B0 
		// Single get_deltaTime()
		float HG::Rendering::Runtime::HGRPTimeManager::get_deltaTime(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  struct HGRPTimeManager__Class *v3; // rax
		  HGRPTimeManager *instance; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v7; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_13;
		  if ( wrapperArray->max_length.size > 876 )
		  {
		    if ( !v1->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v1);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v1->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_13;
		    if ( wrapperArray->max_length.size <= 0x36Cu )
		LABEL_28:
		      sub_1800D2AB0(v1, wrapperArray);
		    if ( wrapperArray[24].vector[12] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(876, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52((ILFixDynamicMethodWrapper_6 *)Patch, 0LL);
		LABEL_13:
		      sub_1800D8260(v1, wrapperArray);
		    }
		  }
		  v3 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		    v3 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  instance = v3->static_fields->instance;
		  if ( !instance )
		    goto LABEL_13;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_13;
		  if ( wrapperArray->max_length.size <= 877 )
		    return instance->fields.m_time - instance->fields.m_lastTime;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v1 = (struct ILFixDynamicMethodWrapper_2__Class *)v1->static_fields->wrapperArray;
		  if ( !v1 )
		    goto LABEL_13;
		  if ( LODWORD(v1->_0.namespaze) <= 0x36D )
		    goto LABEL_28;
		  if ( !*(_QWORD *)&v1[18]._1.token )
		    return instance->fields.m_time - instance->fields.m_lastTime;
		  v7 = IFix::WrappersManagerImpl::GetPatch(877, 0LL);
		  if ( !v7 )
		    goto LABEL_13;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)v7, (Object *)instance, 0LL);
		}
		
		private float m_deltaTime { get => default; } // 0x00000001832E10B0-0x00000001832E1110 
		// Single get_m_deltaTime()
		float HG::Rendering::Runtime::HGRPTimeManager::get_m_deltaTime(HGRPTimeManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
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
		  if ( wrapperArray->max_length.size <= 877 )
		    return this->fields.m_time - this->fields.m_lastTime;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x36D )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !*(_QWORD *)&v3[18]._1.token )
		    return this->fields.m_time - this->fields.m_lastTime;
		  Patch = IFix::WrappersManagerImpl::GetPatch(877, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public HGRPTimeManager() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
		static HGRPTimeManager() {} // 0x0000000184CA93D0-0x0000000184CA94E0
	
		// Methods
		public static void SetGameplayTime(double gameplayTime) {} // 0x0000000183B0C6E0-0x0000000183B0C750
		// Void SetGameplayTime(Double)
		void HG::Rendering::Runtime::HGRPTimeManager::SetGameplayTime(double gameplayTime, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct HGRPTimeManager__Class *v4; // rax
		  HGRPTimeManager *instance; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2348, 0LL) )
		  {
		    v4 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		      v4 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    }
		    instance = v4->static_fields->instance;
		    if ( instance )
		    {
		      HG::Rendering::Runtime::HGRPTimeManager::_SetGameplayTime(instance, gameplayTime, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(instance, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2348, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_12((ILFixDynamicMethodWrapper_30 *)Patch, gameplayTime, 0LL);
		}
		
		public static void SetLastGameplayTime(double lastGameplayTime) {} // 0x0000000183B0C750-0x0000000183B0C7C0
		// Void SetLastGameplayTime(Double)
		void HG::Rendering::Runtime::HGRPTimeManager::SetLastGameplayTime(double lastGameplayTime, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct HGRPTimeManager__Class *v4; // rax
		  HGRPTimeManager *instance; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2350, 0LL) )
		  {
		    v4 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		      v4 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    }
		    instance = v4->static_fields->instance;
		    if ( instance )
		    {
		      HG::Rendering::Runtime::HGRPTimeManager::_SetLastGameplayTime(instance, lastGameplayTime, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(instance, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2350, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_12((ILFixDynamicMethodWrapper_30 *)Patch, lastGameplayTime, 0LL);
		}
		
		public static void Update() {} // 0x00000001832E13A0-0x00000001832E1500
		// Void Update()
		void HG::Rendering::Runtime::HGRPTimeManager::Update(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  struct HGRPTimeManager__Class *v3; // rax
		  HGRPTimeManager *instance; // rbx
		  float time; // xmm6_4
		  float deltaTime; // xmm0_4
		  void (*v7)(void); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2 *v9; // rax
		  __int64 v10; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_16;
		  if ( wrapperArray->max_length.size > 2293 )
		  {
		    if ( !v1->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v1);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v1->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_16;
		    if ( wrapperArray->max_length.size <= 0x8F5u )
		      goto LABEL_33;
		    if ( wrapperArray[63].vector[25] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2293, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		        return;
		      }
		      goto LABEL_16;
		    }
		  }
		  v3 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGRPTimeManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		    v3 = TypeInfo::HG::Rendering::Runtime::HGRPTimeManager;
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  instance = v3->static_fields->instance;
		  if ( !instance )
		    goto LABEL_16;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_16;
		  if ( wrapperArray->max_length.size > 2294 )
		  {
		    if ( !v1->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v1);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v1 = (struct ILFixDynamicMethodWrapper_2__Class *)v1->static_fields->wrapperArray;
		    if ( !v1 )
		      goto LABEL_16;
		    if ( LODWORD(v1->_0.namespaze) > 0x8F6 )
		    {
		      if ( !v1[48].vtable.Finalize.method )
		        goto LABEL_12;
		      v9 = IFix::WrappersManagerImpl::GetPatch(2294, 0LL);
		      if ( v9 )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)v9, (Object *)instance, 0LL);
		        return;
		      }
		LABEL_16:
		      sub_1800D8260(v1, wrapperArray);
		    }
		LABEL_33:
		    sub_1800D2AB0(v1, wrapperArray);
		  }
		LABEL_12:
		  time = UnityEngine::Time::get_time(0LL);
		  deltaTime = UnityEngine::Time::get_deltaTime(0LL);
		  v7 = (void (*)(void))qword_18F370898;
		  instance->fields.m_time = time;
		  instance->fields.m_lastTime = time - deltaTime;
		  if ( !v7 )
		  {
		    v7 = (void (*)(void))il2cpp_resolve_icall_1("UnityEngine.HyperGryph.HGLogicTimeManager::SetHgrpDeltaTime(System.Single)");
		    if ( !v7 )
		    {
		      v10 = sub_1802EE1B8("UnityEngine.HyperGryph.HGLogicTimeManager::SetHgrpDeltaTime(System.Single)");
		      sub_18007E1B0(v10, 0LL);
		    }
		    qword_18F370898 = (__int64)v7;
		  }
		  v7();
		  if ( !UnityEngine::Application::get_isPlaying(0LL) )
		    HG::Rendering::Runtime::HGRPTimeManager::UpdateOverrideTime(instance, 0LL);
		}
		
		private void _SetGameplayTime(double gameplayTime) {} // 0x0000000183B0C7C0-0x0000000183B0C810
		// Void _SetGameplayTime(Double)
		void HG::Rendering::Runtime::HGRPTimeManager::_SetGameplayTime(
		        HGRPTimeManager *this,
		        double gameplayTime,
		        MethodInfo *method)
		{
		  double v3; // xmm2_8
		  Unity::Mathematics::math *v5; // rcx
		  float v6; // xmm1_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2349, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2349, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_69(
		      (ILFixDynamicMethodWrapper_8 *)Patch,
		      (Object *)this,
		      gameplayTime,
		      0LL);
		  }
		  else
		  {
		    Unity::Mathematics::math::fmod(v5, 1000.0, v3);
		    v6 = gameplayTime;
		    this->fields.m_gameplayTime = v6;
		  }
		}
		
		private void _SetLastGameplayTime(double lastGameplayTime) {} // 0x0000000183B0C810-0x0000000183B0C860
		// Void _SetLastGameplayTime(Double)
		void HG::Rendering::Runtime::HGRPTimeManager::_SetLastGameplayTime(
		        HGRPTimeManager *this,
		        double lastGameplayTime,
		        MethodInfo *method)
		{
		  double v3; // xmm2_8
		  Unity::Mathematics::math *v5; // rcx
		  float v6; // xmm1_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2351, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2351, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_69(
		      (ILFixDynamicMethodWrapper_8 *)Patch,
		      (Object *)this,
		      lastGameplayTime,
		      0LL);
		  }
		  else
		  {
		    Unity::Mathematics::math::fmod(v5, 1000.0, v3);
		    v6 = lastGameplayTime;
		    this->fields.m_lastGameplayTime = v6;
		  }
		}
		
		private void UpdateOverrideTime() {} // 0x0000000189B58250-0x0000000189B58294
		// Void UpdateOverrideTime()
		void HG::Rendering::Runtime::HGRPTimeManager::UpdateOverrideTime(HGRPTimeManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2295, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2295, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		private void _Update() {} // 0x00000001832E1500-0x00000001832E15D0
		// Void _Update()
		void HG::Rendering::Runtime::HGRPTimeManager::_Update(HGRPTimeManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  float time; // xmm6_4
		  float deltaTime; // xmm0_4
		  void (*v7)(void); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_11;
		  if ( wrapperArray->max_length.size > 2294 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x8F6 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[48].vtable.Finalize.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(2294, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  time = UnityEngine::Time::get_time(0LL);
		  deltaTime = UnityEngine::Time::get_deltaTime(0LL);
		  v7 = (void (*)(void))qword_18F370898;
		  this->fields.m_time = time;
		  this->fields.m_lastTime = time - deltaTime;
		  if ( !v7 )
		  {
		    v7 = (void (*)(void))il2cpp_resolve_icall_1("UnityEngine.HyperGryph.HGLogicTimeManager::SetHgrpDeltaTime(System.Single)");
		    if ( !v7 )
		    {
		      v9 = sub_1802EE1B8("UnityEngine.HyperGryph.HGLogicTimeManager::SetHgrpDeltaTime(System.Single)");
		      sub_18007E1B0(v9, 0LL);
		    }
		    qword_18F370898 = (__int64)v7;
		  }
		  v7();
		  if ( !UnityEngine::Application::get_isPlaying(0LL) )
		    HG::Rendering::Runtime::HGRPTimeManager::UpdateOverrideTime(this, 0LL);
		}
		
	}
}
