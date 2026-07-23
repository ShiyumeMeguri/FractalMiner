using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGCharacters // TypeDefIndex: 38689
	{
		// Fields
		private static readonly Lazy<HGCharacters> s_Instance; // 0x00
		public static readonly HGCharacters instance; // 0x08
		private static List<HGCharacterHelper> m_AllCharacterHelpers; // 0x10
		private static List<HGCharacterHelper> m_SelfShadowCharacterHelpers; // 0x18
		private static List<HGCharacterHelper> m_HDPLSCharacterHelpers; // 0x20
		public const int MAX_HDPLS_CHARACTER_COUNT = 32; // Metadata: 0x02304097
		public const int MAX_CHARACTER_SHADOWMAP_COUNT = 14; // Metadata: 0x02304098
		public const int SHADOW_LAYER_START_INDEX = 8; // Metadata: 0x02304099
	
		// Properties
		public static List<HGCharacterHelper> selfShadowCharacterHelpers { get => default; } // 0x00000001831038D0-0x00000001831039D0 
		// List`1[HG.Rendering.Runtime.HGCharacterHelper] get_selfShadowCharacterHelpers()
		List_1_HG_Rendering_Runtime_HGCharacterHelper_ *HG::Rendering::Runtime::HGCharacters::get_selfShadowCharacterHelpers(
		        MethodInfo *method)
		{
		  MethodInfo *v1; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  struct HGCharacters__Class *v4; // rax
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_ *m_SelfShadowCharacterHelpers; // rbx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v7; // rax
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  struct HGCharacters__Class *v11; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v13 = v1;
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size <= 2105 )
		    goto LABEL_5;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size <= 0x839u )
		    sub_1800D2AB0(wrapperArray, v2);
		  if ( !wrapperArray[58].vector[17] )
		  {
		LABEL_5:
		    v4 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		      v4 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		    }
		    m_SelfShadowCharacterHelpers = v4->static_fields->m_SelfShadowCharacterHelpers;
		    if ( m_SelfShadowCharacterHelpers )
		      return m_SelfShadowCharacterHelpers;
		    v7 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>);
		    m_SelfShadowCharacterHelpers = (List_1_HG_Rendering_Runtime_HGCharacterHelper_ *)v7;
		    if ( v7 )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		        v7,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::List);
		      v11 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		        v11 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      }
		      v11->static_fields->m_SelfShadowCharacterHelpers = m_SelfShadowCharacterHelpers;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_SelfShadowCharacterHelpers,
		        v8,
		        v9,
		        v10,
		        v13);
		      return m_SelfShadowCharacterHelpers;
		    }
		LABEL_10:
		    sub_1800D8260(wrapperArray, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2105, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_846(Patch, 0LL);
		}
		
		public static int selfShadowCount { get => default; } // 0x0000000183E161F0-0x0000000183E16270 
		// Int32 get_selfShadowCount()
		int32_t HG::Rendering::Runtime::HGCharacters::get_selfShadowCount(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_ *selfShadowCharacterHelpers; // rax
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
		  if ( wrapperArray->max_length.size <= 2104 )
		    goto LABEL_20;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 0x838u )
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !wrapperArray[58].vector[16] )
		  {
		LABEL_20:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    selfShadowCharacterHelpers = HG::Rendering::Runtime::HGCharacters::get_selfShadowCharacterHelpers(0LL);
		    if ( selfShadowCharacterHelpers )
		      return selfShadowCharacterHelpers->fields._size;
		LABEL_9:
		    sub_1800D8260(wrapperArray, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2104, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		public static List<HGCharacterHelper> hdplsCharacterHelpers { get => default; } // 0x0000000183A48C40-0x0000000183A48D40 
		// List`1[HG.Rendering.Runtime.HGCharacterHelper] get_hdplsCharacterHelpers()
		List_1_HG_Rendering_Runtime_HGCharacterHelper_ *HG::Rendering::Runtime::HGCharacters::get_hdplsCharacterHelpers(
		        MethodInfo *method)
		{
		  MethodInfo *v1; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  struct HGCharacters__Class *v4; // rax
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_ *m_HDPLSCharacterHelpers; // rbx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v7; // rax
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  struct HGCharacters__Class *v11; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v13; // [rsp+20h] [rbp-8h]
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v13 = v1;
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size <= 2171 )
		    goto LABEL_5;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size <= 0x87Bu )
		    sub_1800D2AB0(wrapperArray, v2);
		  if ( !wrapperArray[60].vector[11] )
		  {
		LABEL_5:
		    v4 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		      v4 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		    }
		    m_HDPLSCharacterHelpers = v4->static_fields->m_HDPLSCharacterHelpers;
		    if ( m_HDPLSCharacterHelpers )
		      return m_HDPLSCharacterHelpers;
		    v7 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>);
		    m_HDPLSCharacterHelpers = (List_1_HG_Rendering_Runtime_HGCharacterHelper_ *)v7;
		    if ( v7 )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		        v7,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::List);
		      v11 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		        v11 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      }
		      v11->static_fields->m_HDPLSCharacterHelpers = m_HDPLSCharacterHelpers;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_HDPLSCharacterHelpers,
		        v8,
		        v9,
		        v10,
		        v13);
		      return m_HDPLSCharacterHelpers;
		    }
		LABEL_10:
		    sub_1800D8260(wrapperArray, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2171, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_846(Patch, 0LL);
		}
		
		public static int hdplsCount { get => default; } // 0x0000000183A48BC0-0x0000000183A48C40 
		// Int32 get_hdplsCount()
		int32_t HG::Rendering::Runtime::HGCharacters::get_hdplsCount(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  List_1_HG_Rendering_Runtime_HGCharacterHelper_ *hdplsCharacterHelpers; // rax
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
		  if ( wrapperArray->max_length.size <= 2170 )
		    goto LABEL_20;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 0x87Au )
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !wrapperArray[60].vector[10] )
		  {
		LABEL_20:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    hdplsCharacterHelpers = HG::Rendering::Runtime::HGCharacters::get_hdplsCharacterHelpers(0LL);
		    if ( hdplsCharacterHelpers )
		      return hdplsCharacterHelpers->fields._size;
		LABEL_9:
		    sub_1800D8260(wrapperArray, v1);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2170, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		public static int hdplsRenderCount { get => default; } // 0x0000000183A48B20-0x0000000183A48BC0 
		// Int32 get_hdplsRenderCount()
		int32_t HG::Rendering::Runtime::HGCharacters::get_hdplsRenderCount(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rcx
		  int hdplsCount; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_12;
		  if ( wrapperArray->max_length.size > 2169 )
		  {
		    if ( !v1->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v1);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v1->static_fields->wrapperArray;
		    if ( wrapperArray )
		    {
		      if ( wrapperArray->max_length.size <= 0x879u )
		        sub_1800D2AB0(wrapperArray, v1);
		      if ( !wrapperArray[60].vector[9] )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(2169, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		    }
		LABEL_12:
		    sub_1800D8260(wrapperArray, v1);
		  }
		LABEL_5:
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		  hdplsCount = HG::Rendering::Runtime::HGCharacters::get_hdplsCount(0LL);
		  if ( !TypeInfo::System::Math->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Math);
		  if ( hdplsCount > 32 )
		    return 32;
		  return hdplsCount;
		}
		
	
		// Constructors
		public HGCharacters() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static HGCharacters() {} // 0x0000000184CA94E0-0x0000000184CA95F0
		// HGCharacters()
		void HG::Rendering::Runtime::HGCharacters::cctor(MethodInfo *method)
		{
		  struct HGCharacters_c__Class *v1; // rax
		  Object *v2; // rdi
		  Func_1_Object_ *v3; // rax
		  __int64 v4; // rdx
		  Lazy_1_HG_Rendering_Runtime_HGCharacters_ *s_Instance; // rcx
		  Func_1_Object_ *v6; // rbx
		  Lazy_1_Object_ *v7; // rax
		  Type__Class *v8; // rdi
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  Object *Value; // rax
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::HGCharacters::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGCharacters::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (Func_1_Object_ *)sub_1800368D0(TypeInfo::System::Func<HG::Rendering::Runtime::HGCharacters>);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_4;
		  System::Func<System::Object>::Func(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::HGCharacters::__c::__cctor_b__26_0,
		    0LL);
		  v7 = (Lazy_1_Object_ *)sub_1800368D0(TypeInfo::System::Lazy<HG::Rendering::Runtime::HGCharacters>);
		  v8 = (Type__Class *)v7;
		  if ( !v7
		    || (System::Lazy<System::Object>::Lazy(v7, v6, MethodInfo::System::Lazy<HG::Rendering::Runtime::HGCharacters>::Lazy),
		        static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields,
		        static_fields->klass = v8,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields,
		          static_fields,
		          v10,
		          v11,
		          v16),
		        (s_Instance = TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->s_Instance) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(s_Instance, v4);
		  }
		  Value = System::Lazy<System::Object>::get_Value(
		            (Lazy_1_Object_ *)s_Instance,
		            MethodInfo::System::Lazy<HG::Rendering::Runtime::HGCharacters>::get_Value);
		  v13 = (Type *)TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields;
		  v13->monitor = (MonitorData *)Value;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->instance,
		    v13,
		    v14,
		    v15,
		    v17);
		}
		
	
		// Methods
		public static void EnqueueCharacter(HGCharacterHelper characterHelper) {} // 0x0000000183A481F0-0x0000000183A483D0
		// Void EnqueueCharacter(HGCharacterHelper)
		void HG::Rendering::Runtime::HGCharacters::EnqueueCharacter(HGCharacterHelper *characterHelper, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct Object_1__Class *v4; // rcx
		  List_1_System_Object_ *m_AllCharacterHelpers; // rcx
		  struct HGCharacters__Class *v6; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v7; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v8; // rdi
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  struct HGCharacters__Class *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4135, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4135, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)characterHelper,
		        0LL);
		      return;
		    }
		    goto LABEL_19;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_AllCharacterHelpers )
		  {
		    v7 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>);
		    v8 = v7;
		    if ( !v7 )
		      goto LABEL_19;
		    System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		      v7,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::List);
		    v12 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		      v12 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		    }
		    v12->static_fields->m_AllCharacterHelpers = (List_1_HG_Rendering_Runtime_HGCharacterHelper_ *)v8;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_AllCharacterHelpers,
		      v9,
		      v10,
		      v11,
		      v14);
		  }
		  v4 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v4 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v4 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( characterHelper )
		  {
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v4);
		    if ( characterHelper->fields._._._._.m_CachedPtr )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		      m_AllCharacterHelpers = (List_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_AllCharacterHelpers;
		      if ( m_AllCharacterHelpers )
		      {
		        if ( System::Collections::Generic::List<System::Object>::Contains(
		               m_AllCharacterHelpers,
		               (Object *)characterHelper,
		               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Contains) )
		        {
		          return;
		        }
		        v6 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		          v6 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		        }
		        m_AllCharacterHelpers = (List_1_System_Object_ *)v6->static_fields->m_AllCharacterHelpers;
		        if ( m_AllCharacterHelpers )
		        {
		          System::Collections::Generic::List<System::Object>::Insert(
		            m_AllCharacterHelpers,
		            0,
		            (Object *)characterHelper,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Insert);
		          HG::Rendering::Runtime::HGCharacters::SortAndRebuild(0LL);
		          return;
		        }
		      }
		LABEL_19:
		      sub_1800D8260(m_AllCharacterHelpers, v3);
		    }
		  }
		}
		
		public static void SortAndRebuild() {} // 0x0000000183A483D0-0x0000000183A48470
		// Void SortAndRebuild()
		void HG::Rendering::Runtime::HGCharacters::SortAndRebuild(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  struct HGCharacters__Class *v2; // rax
		  List_1_System_Object_ *m_AllCharacterHelpers; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4127, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4127, 0LL);
		    if ( !Patch )
		      goto LABEL_10;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		  }
		  else
		  {
		    v2 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		      v2 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		    }
		    if ( v2->static_fields->m_AllCharacterHelpers )
		    {
		      if ( !v2->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v2);
		        v2 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      }
		      m_AllCharacterHelpers = (List_1_System_Object_ *)v2->static_fields->m_AllCharacterHelpers;
		      if ( m_AllCharacterHelpers )
		      {
		        System::Collections::Generic::List<System::Object>::Sort(
		          m_AllCharacterHelpers,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Sort);
		        HG::Rendering::Runtime::HGCharacters::RebuildFilteredLists(0LL);
		        return;
		      }
		LABEL_10:
		      sub_1800D8260(m_AllCharacterHelpers, v1);
		    }
		  }
		}
		
		private static void RebuildFilteredLists() {} // 0x0000000183A48470-0x0000000183A487C0
		// Void RebuildFilteredLists()
		void HG::Rendering::Runtime::HGCharacters::RebuildFilteredLists(MethodInfo *method)
		{
		  HGCharacters__StaticFields *items; // rdx
		  struct HGCharacters__Class *v2; // rcx
		  List_1_System_Object_ *m_SelfShadowCharacterHelpers; // rcx
		  struct HGCharacters__Class *v4; // rcx
		  int32_t v5; // edi
		  int32_t i; // ebx
		  struct HGCharacters__Class *v7; // rax
		  Object *Item; // rax
		  Object *v9; // rsi
		  struct HGCharacters__Class *v10; // rax
		  struct HGCharacters__Class *v11; // rax
		  Object *v12; // rax
		  int16_t SelfShadowID; // bx
		  Object *v14; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v15; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v16; // rbx
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  struct HGCharacters__Class *v20; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v21; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v22; // rbx
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  struct HGCharacters__Class *v26; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v28; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4128, 0LL) )
		  {
		    v2 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		      v2 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		    }
		    if ( v2->static_fields->m_SelfShadowCharacterHelpers )
		    {
		      if ( !v2->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v2);
		        v2 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      }
		      m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)v2->static_fields->m_SelfShadowCharacterHelpers;
		      if ( !m_SelfShadowCharacterHelpers )
		        goto LABEL_47;
		      sub_183127A90(
		        m_SelfShadowCharacterHelpers,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Clear);
		    }
		    else
		    {
		      v15 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>);
		      v16 = v15;
		      if ( !v15 )
		        goto LABEL_47;
		      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		        v15,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::List);
		      v20 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		        v20 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      }
		      v20->static_fields->m_SelfShadowCharacterHelpers = (List_1_HG_Rendering_Runtime_HGCharacterHelper_ *)v16;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_SelfShadowCharacterHelpers,
		        v17,
		        v18,
		        v19,
		        v28);
		    }
		    v4 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		      v4 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		    }
		    if ( v4->static_fields->m_HDPLSCharacterHelpers )
		    {
		      if ( !v4->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v4);
		        v4 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      }
		      m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)v4->static_fields->m_HDPLSCharacterHelpers;
		      if ( !m_SelfShadowCharacterHelpers )
		        goto LABEL_47;
		      sub_183127A90(
		        m_SelfShadowCharacterHelpers,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Clear);
		    }
		    else
		    {
		      v21 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>);
		      v22 = v21;
		      if ( !v21 )
		        goto LABEL_47;
		      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		        v21,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::List);
		      v26 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		        v26 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      }
		      v26->static_fields->m_HDPLSCharacterHelpers = (List_1_HG_Rendering_Runtime_HGCharacterHelper_ *)v22;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_HDPLSCharacterHelpers,
		        v23,
		        v24,
		        v25,
		        v28);
		    }
		    v5 = 0;
		    for ( i = 0; ; ++i )
		    {
		      v7 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		        v7 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      }
		      m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)v7->static_fields;
		      items = (HGCharacters__StaticFields *)m_SelfShadowCharacterHelpers->fields._items;
		      if ( !items )
		        goto LABEL_47;
		      if ( i >= SLODWORD(items->m_SelfShadowCharacterHelpers) )
		        break;
		      if ( !v7->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v7);
		        v7 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      }
		      m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)v7->static_fields->m_AllCharacterHelpers;
		      if ( !m_SelfShadowCharacterHelpers )
		        goto LABEL_47;
		      Item = System::Collections::Generic::List<System::Object>::get_Item(
		               m_SelfShadowCharacterHelpers,
		               i,
		               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::get_Item);
		      v9 = Item;
		      if ( !Item )
		        goto LABEL_47;
		      if ( HG::Rendering::Runtime::HGCharacterHelper::get_enableCastSelfShadow((HGCharacterHelper *)Item, 0LL) )
		      {
		        v10 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		          v10 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		        }
		        m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)v10->static_fields->m_SelfShadowCharacterHelpers;
		        if ( !m_SelfShadowCharacterHelpers )
		          goto LABEL_47;
		        sub_182F01190(m_SelfShadowCharacterHelpers, v9);
		      }
		      if ( HG::Rendering::Runtime::HGCharacterHelper::get_enableCastHDPunctualLightShadow((HGCharacterHelper *)v9, 0LL) )
		      {
		        v11 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		          v11 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		        }
		        m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)v11->static_fields->m_HDPLSCharacterHelpers;
		        if ( !m_SelfShadowCharacterHelpers )
		          goto LABEL_47;
		        sub_182F01190(m_SelfShadowCharacterHelpers, v9);
		      }
		    }
		    while ( 1 )
		    {
		      if ( !v7->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v7);
		        v7 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      }
		      m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)v7->static_fields;
		      items = (HGCharacters__StaticFields *)m_SelfShadowCharacterHelpers->fields._items;
		      if ( !items )
		        break;
		      if ( v5 >= SLODWORD(items->m_SelfShadowCharacterHelpers) )
		        return;
		      if ( !v7->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v7);
		        v7 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      }
		      m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)v7->static_fields->m_AllCharacterHelpers;
		      if ( !m_SelfShadowCharacterHelpers )
		        break;
		      v12 = System::Collections::Generic::List<System::Object>::get_Item(
		              m_SelfShadowCharacterHelpers,
		              v5,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::get_Item);
		      SelfShadowID = HG::Rendering::Runtime::HGCharacters::QuerySelfShadowID((HGCharacterHelper *)v12, 0LL);
		      items = TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields;
		      m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)items->m_AllCharacterHelpers;
		      if ( !m_SelfShadowCharacterHelpers )
		        break;
		      v14 = System::Collections::Generic::List<System::Object>::get_Item(
		              m_SelfShadowCharacterHelpers,
		              v5,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::get_Item);
		      if ( !v14 )
		        break;
		      HG::Rendering::Runtime::HGCharacterHelper::UpdateShadowRenderingLayer(
		        (HGCharacterHelper *)v14,
		        SelfShadowID,
		        0,
		        0LL);
		      v7 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		      ++v5;
		    }
		LABEL_47:
		    sub_1800D8260(m_SelfShadowCharacterHelpers, items);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4128, 0LL);
		  if ( !Patch )
		    goto LABEL_47;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		public static void DequeueCharacter(HGCharacterHelper characterHelper) {} // 0x0000000183A47E40-0x0000000183A47FC0
		// Void DequeueCharacter(HGCharacterHelper)
		void HG::Rendering::Runtime::HGCharacters::DequeueCharacter(HGCharacterHelper *characterHelper, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct Object_1__Class *v4; // rcx
		  List_1_System_Object_ *m_AllCharacterHelpers; // rcx
		  struct HGCharacters__Class *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4153, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4153, 0LL);
		    if ( !Patch )
		      goto LABEL_19;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)characterHelper, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    if ( TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_AllCharacterHelpers )
		    {
		      v4 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v4 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v4 = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( characterHelper )
		      {
		        if ( !v4->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v4);
		        if ( characterHelper->fields._._._._.m_CachedPtr )
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		          m_AllCharacterHelpers = (List_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_AllCharacterHelpers;
		          if ( !m_AllCharacterHelpers )
		            goto LABEL_19;
		          if ( System::Collections::Generic::List<System::Object>::Contains(
		                 m_AllCharacterHelpers,
		                 (Object *)characterHelper,
		                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Contains) )
		          {
		            v6 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		            if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		              v6 = TypeInfo::HG::Rendering::Runtime::HGCharacters;
		            }
		            m_AllCharacterHelpers = (List_1_System_Object_ *)v6->static_fields->m_AllCharacterHelpers;
		            if ( m_AllCharacterHelpers )
		            {
		              System::Collections::Generic::List<System::Object>::Remove(
		                m_AllCharacterHelpers,
		                (Object *)characterHelper,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::Remove);
		              HG::Rendering::Runtime::HGCharacterHelper::UpdateShadowRenderingLayer(characterHelper, -1, 1, 0LL);
		              HG::Rendering::Runtime::HGCharacters::SortAndRebuild(0LL);
		              return;
		            }
		LABEL_19:
		            sub_1800D8260(m_AllCharacterHelpers, v3);
		          }
		        }
		      }
		    }
		  }
		}
		
		public static short QuerySelfShadowID(HGCharacterHelper characterHelper) => default; // 0x0000000183A489D0-0x0000000183A48B20
		// Int16 QuerySelfShadowID(HGCharacterHelper)
		int16_t HG::Rendering::Runtime::HGCharacters::QuerySelfShadowID(HGCharacterHelper *characterHelper, MethodInfo *method)
		{
		  List_1_System_Object_ *m_SelfShadowCharacterHelpers; // rcx
		  __int64 v4; // rdx
		  struct Object_1__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = **(_QWORD **)&m_SelfShadowCharacterHelpers[4].fields._size;
		  if ( !v4 )
		    goto LABEL_18;
		  if ( *(int *)(v4 + 24) <= 2114 )
		    goto LABEL_31;
		  if ( !m_SelfShadowCharacterHelpers[5].fields._size )
		  {
		    il2cpp_runtime_class_init_1(m_SelfShadowCharacterHelpers);
		    m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  m_SelfShadowCharacterHelpers = **(List_1_System_Object_ ***)&m_SelfShadowCharacterHelpers[4].fields._size;
		  if ( !m_SelfShadowCharacterHelpers )
		    goto LABEL_18;
		  if ( m_SelfShadowCharacterHelpers->fields._size <= 0x842u )
		    sub_1800D2AB0(m_SelfShadowCharacterHelpers, v4);
		  if ( !*(_QWORD *)&m_SelfShadowCharacterHelpers[423].fields._size )
		  {
		LABEL_31:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_SelfShadowCharacterHelpers )
		      return -1;
		    v5 = TypeInfo::UnityEngine::Object;
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
		    if ( !characterHelper )
		      return -1;
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v5);
		    if ( !characterHelper->fields._._._._.m_CachedPtr )
		      return -1;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    m_SelfShadowCharacterHelpers = (List_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGCharacters->static_fields->m_SelfShadowCharacterHelpers;
		    if ( m_SelfShadowCharacterHelpers )
		      return System::Collections::Generic::List<System::Object>::IndexOf(
		               m_SelfShadowCharacterHelpers,
		               (Object *)characterHelper,
		               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCharacterHelper>::IndexOf);
		LABEL_18:
		    sub_1800D8260(m_SelfShadowCharacterHelpers, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2114, 0LL);
		  if ( !Patch )
		    goto LABEL_18;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		           (ILFixDynamicMethodWrapper_31 *)Patch,
		           (Object *)characterHelper,
		           0LL);
		}
		
		public static uint GetShadowLayer(short selfShadowIndex) => default; // 0x0000000183DEF6A0-0x0000000183DEF710
		// UInt32 GetShadowLayer(Int16)
		uint32_t HG::Rendering::Runtime::HGCharacters::GetShadowLayer(int16_t selfShadowIndex, MethodInfo *method)
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
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 2115 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x843 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[45]._0.byval_arg.data.dummy )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(2115, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_852(Patch, selfShadowIndex, 0LL);
		    }
		LABEL_8:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( selfShadowIndex < 0 )
		    return 0;
		  else
		    return 1 << ((selfShadowIndex + 8) & 0x1F);
		}
		
		public static bool EnableCharacterSelfShadow(HGCharacterHelper characterHelper) => default; // 0x0000000183A487C0-0x0000000183A48820
		// Boolean EnableCharacterSelfShadow(HGCharacterHelper)
		bool HG::Rendering::Runtime::HGCharacters::EnableCharacterSelfShadow(
		        HGCharacterHelper *characterHelper,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4131, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4131, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		             (ILFixDynamicMethodWrapper_20 *)Patch,
		             (Object *)characterHelper,
		             0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCharacters->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCharacters);
		    return (unsigned __int16)HG::Rendering::Runtime::HGCharacters::QuerySelfShadowID(characterHelper, 0LL) <= 0xDu;
		  }
		}
		
	}
}
