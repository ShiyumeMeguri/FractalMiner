using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGCapsuleShadows // TypeDefIndex: 38683
	{
		// Fields
		private static readonly Lazy<HGCapsuleShadows> s_Instance; // 0x00
		public static readonly HGCapsuleShadows instance; // 0x08
		private static List<HGCapsuleShadowHelper> m_capsuleShadowHelpers; // 0x10
	
		// Properties
		public static int count { get => default; } // 0x0000000189C44228-0x0000000189C44284 
		// Int32 get_count()
		int32_t HG::Rendering::Runtime::HGCapsuleShadows::get_count(MethodInfo *method)
		{
		  List_1_HG_Rendering_Runtime_HGCapsuleShadowHelper_ *capsuleShadowHelpers; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2084, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		    capsuleShadowHelpers = HG::Rendering::Runtime::HGCapsuleShadows::get_capsuleShadowHelpers(0LL);
		    if ( capsuleShadowHelpers )
		      return capsuleShadowHelpers->fields._size;
		LABEL_5:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2084, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		public static List<HGCapsuleShadowHelper> capsuleShadowHelpers { get => default; } // 0x0000000189C44164-0x0000000189C44228 
		// List`1[HG.Rendering.Runtime.HGCapsuleShadowHelper] get_capsuleShadowHelpers()
		List_1_HG_Rendering_Runtime_HGCapsuleShadowHelper_ *HG::Rendering::Runtime::HGCapsuleShadows::get_capsuleShadowHelpers(
		        MethodInfo *method)
		{
		  List_1_HG_Rendering_Runtime_HGCapsuleShadowHelper_ *m_capsuleShadowHelpers; // rbx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2085, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		    m_capsuleShadowHelpers = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields->m_capsuleShadowHelpers;
		    if ( m_capsuleShadowHelpers )
		      return m_capsuleShadowHelpers;
		    v2 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>);
		    m_capsuleShadowHelpers = (List_1_HG_Rendering_Runtime_HGCapsuleShadowHelper_ *)v2;
		    if ( v2 )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		        v2,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::List);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		      static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields;
		      static_fields->fields._impl.value = m_capsuleShadowHelpers;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields->m_capsuleShadowHelpers,
		        static_fields,
		        v6,
		        v7,
		        v10);
		      return m_capsuleShadowHelpers;
		    }
		LABEL_7:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2085, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_838(Patch, 0LL);
		}
		
	
		// Constructors
		public HGCapsuleShadows() {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static HGCapsuleShadows() {} // 0x0000000184CA95F0-0x0000000184CA9700
		// HGCapsuleShadows()
		void HG::Rendering::Runtime::HGCapsuleShadows::cctor(MethodInfo *method)
		{
		  struct HGCapsuleShadows_c__Class *v1; // rax
		  Object *v2; // rdi
		  Func_1_Object_ *v3; // rax
		  __int64 v4; // rdx
		  Lazy_1_HG_Rendering_Runtime_HGCapsuleShadows_ *s_Instance; // rcx
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
		
		  v1 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (Func_1_Object_ *)sub_1800368D0(TypeInfo::System::Func<HG::Rendering::Runtime::HGCapsuleShadows>);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_4;
		  System::Func<System::Object>::Func(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::HGCapsuleShadows::__c::__cctor_b__10_0,
		    0LL);
		  v7 = (Lazy_1_Object_ *)sub_1800368D0(TypeInfo::System::Lazy<HG::Rendering::Runtime::HGCapsuleShadows>);
		  v8 = (Type__Class *)v7;
		  if ( !v7
		    || (System::Lazy<System::Object>::Lazy(
		          v7,
		          v6,
		          MethodInfo::System::Lazy<HG::Rendering::Runtime::HGCapsuleShadows>::Lazy),
		        static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields,
		        static_fields->klass = v8,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields,
		          static_fields,
		          v10,
		          v11,
		          v16),
		        (s_Instance = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields->s_Instance) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(s_Instance, v4);
		  }
		  Value = System::Lazy<System::Object>::get_Value(
		            (Lazy_1_Object_ *)s_Instance,
		            MethodInfo::System::Lazy<HG::Rendering::Runtime::HGCapsuleShadows>::get_Value);
		  v13 = (Type *)TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields;
		  v13->monitor = (MonitorData *)Value;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields->instance,
		    v13,
		    v14,
		    v15,
		    v17);
		}
		
	
		// Methods
		public static void EnqueueCapsuleShadowHelper(HGCapsuleShadowHelper capsuleShadowHelper) {} // 0x000000018435DA10-0x000000018435DBE0
		// Void EnqueueCapsuleShadowHelper(HGCapsuleShadowHelper)
		void HG::Rendering::Runtime::HGCapsuleShadows::EnqueueCapsuleShadowHelper(
		        HGCapsuleShadowHelper *capsuleShadowHelper,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct Object_1__Class *v4; // rcx
		  List_1_System_Object_ *m_capsuleShadowHelpers; // rcx
		  struct HGCapsuleShadows__Class *v6; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v7; // rax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v8; // rdi
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  struct HGCapsuleShadows__Class *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4114, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4114, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)capsuleShadowHelper,
		        0LL);
		      return;
		    }
		    goto LABEL_19;
		  }
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields->m_capsuleShadowHelpers )
		  {
		    v7 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>);
		    v8 = v7;
		    if ( !v7 )
		      goto LABEL_19;
		    System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		      v7,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::List);
		    v12 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		      v12 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows;
		    }
		    v12->static_fields->m_capsuleShadowHelpers = (List_1_HG_Rendering_Runtime_HGCapsuleShadowHelper_ *)v8;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields->m_capsuleShadowHelpers,
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
		  if ( capsuleShadowHelper )
		  {
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v4);
		    if ( capsuleShadowHelper->fields._._._._.m_CachedPtr )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		      m_capsuleShadowHelpers = (List_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields->m_capsuleShadowHelpers;
		      if ( m_capsuleShadowHelpers )
		      {
		        if ( System::Collections::Generic::List<System::Object>::Contains(
		               m_capsuleShadowHelpers,
		               (Object *)capsuleShadowHelper,
		               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::Contains) )
		        {
		          return;
		        }
		        v6 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		          v6 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows;
		        }
		        m_capsuleShadowHelpers = (List_1_System_Object_ *)v6->static_fields->m_capsuleShadowHelpers;
		        if ( m_capsuleShadowHelpers )
		        {
		          sub_182F01190(m_capsuleShadowHelpers, (Object *)capsuleShadowHelper);
		          return;
		        }
		      }
		LABEL_19:
		      sub_1800D8260(m_capsuleShadowHelpers, v3);
		    }
		  }
		}
		
		public static void DequeueCapsuleShadowHelper(HGCapsuleShadowHelper capsuleShadowHelper) {} // 0x000000018435D7A0-0x000000018435D900
		// Void DequeueCapsuleShadowHelper(HGCapsuleShadowHelper)
		void HG::Rendering::Runtime::HGCapsuleShadows::DequeueCapsuleShadowHelper(
		        HGCapsuleShadowHelper *capsuleShadowHelper,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  struct Object_1__Class *v4; // rcx
		  List_1_System_Object_ *m_capsuleShadowHelpers; // rcx
		  struct HGCapsuleShadows__Class *v6; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4116, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4116, 0LL);
		    if ( !Patch )
		      goto LABEL_19;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)capsuleShadowHelper,
		      0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		    if ( TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields->m_capsuleShadowHelpers )
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
		      if ( capsuleShadowHelper )
		      {
		        if ( !v4->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v4);
		        if ( capsuleShadowHelper->fields._._._._.m_CachedPtr )
		        {
		          if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		          m_capsuleShadowHelpers = (List_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->static_fields->m_capsuleShadowHelpers;
		          if ( !m_capsuleShadowHelpers )
		            goto LABEL_19;
		          if ( System::Collections::Generic::List<System::Object>::Contains(
		                 m_capsuleShadowHelpers,
		                 (Object *)capsuleShadowHelper,
		                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::Contains) )
		          {
		            v6 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows;
		            if ( !TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows);
		              v6 = TypeInfo::HG::Rendering::Runtime::HGCapsuleShadows;
		            }
		            m_capsuleShadowHelpers = (List_1_System_Object_ *)v6->static_fields->m_capsuleShadowHelpers;
		            if ( m_capsuleShadowHelpers )
		            {
		              System::Collections::Generic::List<System::Object>::Remove(
		                m_capsuleShadowHelpers,
		                (Object *)capsuleShadowHelper,
		                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGCapsuleShadowHelper>::Remove);
		              return;
		            }
		LABEL_19:
		            sub_1800D8260(m_capsuleShadowHelpers, v3);
		          }
		        }
		      }
		    }
		  }
		}
		
	}
}
