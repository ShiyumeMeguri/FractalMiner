using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class VFXPPManager : MonoBehaviour // TypeDefIndex: 37958
	{
		// Fields
		private List<List<VFXPPComponent>> m_activeComponents; // 0x18
		private UnityEngine.Rendering.Volume m_ppVolumeForVFX; // 0x20
		private VolumeProfile m_ppVolumeProfile; // 0x28
		private HGEnvironmentVolume m_envVolumeForVFX; // 0x30
		private HGEnvironmentPhase m_envPhaseForVFX; // 0x38
		private VFXPPPriority m_curPriorityFilter; // 0x40
		protected static VFXPPManager s_instance; // 0x00
	
		// Properties
		public static VFXPPManager instance { get => default; } // 0x0000000183089A00-0x0000000183089B80 
		// VFXPPManager get_instance()
		VFXPPManager_1 *HG::Rendering::Runtime::VFXPPManager::get_instance(MethodInfo *method)
		{
		  VFXPPManager_1__StaticFields *static_fields; // rdx
		  MethodInfo *v2; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  VFXPPManager_1 *s_instance; // rbx
		  struct Object_1__Class *v6; // rcx
		  Object__Array *v8; // rax
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  GameObject *v11; // rax
		  GameObject *v12; // rbx
		  Object *v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v15 = v2;
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_14;
		  if ( wrapperArray->max_length.size <= 2460 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (VFXPPManager_1__StaticFields *)v3->static_fields->wrapperArray;
		  if ( !static_fields )
		    goto LABEL_14;
		  if ( LODWORD(static_fields[3].s_instance) <= 0x99C )
		    goto LABEL_31;
		  if ( !static_fields[2464].s_instance )
		  {
		LABEL_5:
		    s_instance = TypeInfo::HG::Rendering::Runtime::VFXPPManager->static_fields->s_instance;
		    v6 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v6 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v6 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( s_instance )
		    {
		      if ( !v6->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v6);
		        v6 = TypeInfo::UnityEngine::Object;
		      }
		      if ( s_instance->fields._._._._.m_CachedPtr )
		        return TypeInfo::HG::Rendering::Runtime::VFXPPManager->static_fields->s_instance;
		    }
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v6);
		    v8 = UnityEngine::Object::FindObjectsOfType<System::Object>(MethodInfo::UnityEngine::Object::FindObjectsOfType<HG::Rendering::Runtime::VFXPPManager>);
		    static_fields = (VFXPPManager_1__StaticFields *)v8;
		    if ( !v8 )
		LABEL_14:
		      sub_1800D8260(v3, static_fields);
		    if ( v8->max_length.size > 1 )
		    {
		      HG::Rendering::HGRPLogger::LogError<System::Object>(
		        (String *)"There should be never more than one singleton {0} in this scene.",
		        (Object *)"VFXPPManager",
		        MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String>);
		      return TypeInfo::HG::Rendering::Runtime::VFXPPManager->static_fields->s_instance;
		    }
		    if ( v8->max_length.size != 1 )
		    {
		      v11 = (GameObject *)sub_1800368D0(TypeInfo::UnityEngine::GameObject);
		      v12 = v11;
		      if ( !v11 )
		        goto LABEL_14;
		      UnityEngine::GameObject::GameObject(v11, (String *)"~VFXPPManager", 0LL);
		      v13 = UnityEngine::GameObject::AddComponent<System::Object>(
		              v12,
		              MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::VFXPPManager>);
		      static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPManager->static_fields;
		      static_fields->s_instance = (VFXPPManager_1 *)v13;
		      goto LABEL_19;
		    }
		    if ( v8->max_length.size )
		    {
		      TypeInfo::HG::Rendering::Runtime::VFXPPManager->static_fields->s_instance = (VFXPPManager_1 *)v8->vector[0];
		LABEL_19:
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::VFXPPManager->static_fields,
		        (HGRuntimeGrassQuery_Node *)static_fields,
		        v9,
		        v10,
		        v15);
		      return TypeInfo::HG::Rendering::Runtime::VFXPPManager->static_fields->s_instance;
		    }
		LABEL_31:
		    sub_1800D2AB0(v3, static_fields);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2460, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_949(Patch, 0LL);
		}
		
		private List<List<VFXPPComponent>> activeComponents { get => default; } // 0x0000000183089900-0x0000000183089A00 
		// List`1[List`1[HG.Rendering.Runtime.VFXPPComponent]] get_activeComponents()
		List_1_List_1_HG_Rendering_Runtime_VFXPPComponent_ *HG::Rendering::Runtime::VFXPPManager::get_activeComponents(
		        VFXPPManager_1 *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v6; // rax
		  List_1_List_1_HG_Rendering_Runtime_VFXPPComponent_ *v7; // rdi
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  int v11; // ebp
		  List_1_System_Object_ *m_activeComponents; // rsi
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v13; // rax
		  Object *v14; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size <= 2462 )
		    goto LABEL_24;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_7;
		  if ( LODWORD(v3->_0.namespaze) <= 0x99E )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[52].interfaceOffsets )
		  {
		LABEL_24:
		    if ( this->fields.m_activeComponents )
		      return this->fields.m_activeComponents;
		    v6 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>);
		    v7 = (List_1_List_1_HG_Rendering_Runtime_VFXPPComponent_ *)v6;
		    if ( v6 )
		    {
		      System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		        v6,
		        MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::List);
		      this->fields.m_activeComponents = v7;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_activeComponents, v8, v9, v10, v16);
		      v11 = 0;
		      while ( 1 )
		      {
		        m_activeComponents = (List_1_System_Object_ *)this->fields.m_activeComponents;
		        v13 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>);
		        v14 = (Object *)v13;
		        if ( !v13 )
		          break;
		        System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		          v13,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::List);
		        if ( !m_activeComponents )
		          break;
		        sub_182F01190(m_activeComponents, v14);
		        if ( ++v11 >= 17 )
		          return this->fields.m_activeComponents;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2462, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_950(Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPManager() {} // 0x0000000185393520-0x0000000185393538
		// Singleton`1[System.Object]()
		void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
		{
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		private void Awake() {} // 0x0000000183AB3360-0x0000000183AB3440
		// Void Awake()
		void HG::Rendering::Runtime::VFXPPManager::Awake(VFXPPManager_1 *this, MethodInfo *method)
		{
		  GameObject *gameObject; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  GameObject *v9; // rax
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Object_1 *v13; // rax
		  Object_1 *v14; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2526, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2526, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_3:
		    sub_1800D8260(v5, v4);
		  }
		  this->fields.m_curPriorityFilter = 0;
		  gameObject = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		  if ( !gameObject )
		    goto LABEL_3;
		  this->fields.m_ppVolumeForVFX = (Volume *)UnityEngine::GameObject::AddComponent<System::Object>(
		                                              gameObject,
		                                              MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::Rendering::Volume>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_ppVolumeForVFX, v6, v7, v8, v16);
		  v9 = UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		  if ( !v9 )
		    goto LABEL_3;
		  this->fields.m_envVolumeForVFX = (HGEnvironmentVolume *)UnityEngine::GameObject::AddComponent<System::Object>(
		                                                            v9,
		                                                            MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGEnvironmentVolume>);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_envVolumeForVFX, v10, v11, v12, v17);
		  v13 = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		  if ( !v13 )
		    goto LABEL_3;
		  UnityEngine::Object::set_hideFlags(v13, HideFlags__Enum_HideAndDontSave, 0LL);
		  if ( UnityEngine::Application::get_isPlaying(0LL) )
		  {
		    v14 = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    UnityEngine::Object::DontDestroyOnLoad(v14, 0LL);
		  }
		}
		
		private void OnEnable() {} // 0x0000000183A47C80-0x0000000183A47D30
		// Void OnEnable()
		void HG::Rendering::Runtime::VFXPPManager::OnEnable(VFXPPManager_1 *this, MethodInfo *method)
		{
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *v6; // rbx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v7; // rax
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *v8; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2527, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2527, 0LL);
		    if ( !Patch )
		      goto LABEL_6;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_1800368D0(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
		    v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *)v3;
		    if ( !v3 )
		      goto LABEL_6;
		    System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		      v3,
		      (Object *)this,
		      MethodInfo::HG::Rendering::Runtime::VFXPPManager::OnBeginFrameRendering,
		      0LL);
		    if ( !TypeInfo::UnityEngine::Rendering::RenderPipelineManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		    UnityEngine::Rendering::RenderPipelineManager::remove_beginFrameRenderingNoAlloc(v6, 0LL);
		    v7 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_1800368D0(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
		    v8 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *)v7;
		    if ( !v7 )
		LABEL_6:
		      sub_1800D8260(v5, v4);
		    System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		      v7,
		      (Object *)this,
		      MethodInfo::HG::Rendering::Runtime::VFXPPManager::OnBeginFrameRendering,
		      0LL);
		    UnityEngine::Rendering::RenderPipelineManager::add_beginFrameRenderingNoAlloc(v8, 0LL);
		  }
		}
		
		private void OnDisable() {} // 0x0000000189B62008-0x0000000189B62098
		// Void OnDisable()
		void HG::Rendering::Runtime::VFXPPManager::OnDisable(VFXPPManager_1 *this, MethodInfo *method)
		{
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2531, 0LL) )
		  {
		    v3 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_Object_ *)sub_18002C620(TypeInfo::System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Collections::Generic::List<UnityEngine::Camera>>);
		    v6 = (Action_2_UnityEngine_Rendering_ScriptableRenderContext_System_Collections_Generic_List_1_UnityEngine_Camera_ *)v3;
		    if ( v3 )
		    {
		      System::Action<UnityEngine::Rendering::ScriptableRenderContext,System::Object>::Action(
		        v3,
		        (Object *)this,
		        MethodInfo::HG::Rendering::Runtime::VFXPPManager::OnBeginFrameRendering,
		        0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RenderPipelineManager);
		      UnityEngine::Rendering::RenderPipelineManager::remove_beginFrameRenderingNoAlloc(v6, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2531, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void AddActiveComponent(VFXPPType type, VFXPPComponent component) {} // 0x0000000184369E30-0x0000000184369F20
		// Void AddActiveComponent(VFXPPType, VFXPPComponent)
		void HG::Rendering::Runtime::VFXPPManager::AddActiveComponent(
		        VFXPPManager_1 *this,
		        VFXPPType__Enum type,
		        VFXPPComponent *component,
		        MethodInfo *method)
		{
		  List_1_System_Object_ *activeComponents; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Object *Item; // rax
		  List_1_System_Object_ *v11; // rdi
		  int32_t v12; // ebx
		  Object *v13; // rax
		  VFXPPPriority__Enum priority; // ebp
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2461, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2461, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_21(
		        (ILFixDynamicMethodWrapper_14 *)Patch,
		        (Object *)this,
		        type,
		        (Object *)component,
		        0LL);
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(v9, v8);
		  }
		  activeComponents = (List_1_System_Object_ *)HG::Rendering::Runtime::VFXPPManager::get_activeComponents(this, 0LL);
		  if ( !activeComponents )
		    goto LABEL_10;
		  Item = System::Collections::Generic::List<System::Object>::get_Item(
		           activeComponents,
		           type,
		           MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::get_Item);
		  v11 = (List_1_System_Object_ *)Item;
		  if ( !Item )
		    goto LABEL_10;
		  v12 = LODWORD(Item[1].monitor) - 1;
		  if ( v12 >= 0 )
		  {
		    while ( 1 )
		    {
		      v13 = System::Collections::Generic::List<System::Object>::get_Item(
		              v11,
		              v12,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::get_Item);
		      if ( !v13 )
		        goto LABEL_10;
		      priority = HG::Rendering::Runtime::VFXPPComponent::get_priority((VFXPPComponent *)v13, 0LL);
		      if ( !component )
		        goto LABEL_10;
		      if ( (int)priority <= (int)HG::Rendering::Runtime::VFXPPComponent::get_priority(component, 0LL) )
		        break;
		      if ( --v12 < 0 )
		        goto LABEL_5;
		    }
		    System::Collections::Generic::List<System::Object>::Insert(
		      v11,
		      v12 + 1,
		      (Object *)component,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::Insert);
		  }
		  else
		  {
		LABEL_5:
		    System::Collections::Generic::List<System::Object>::Insert(
		      v11,
		      0,
		      (Object *)component,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::Insert);
		  }
		}
		
		public void RemoveActiveComponent(VFXPPType type, VFXPPComponent component) {} // 0x00000001830881E0-0x00000001830888B0
		// Void RemoveActiveComponent(VFXPPType, VFXPPComponent)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::VFXPPManager::RemoveActiveComponent(
		        VFXPPManager_1 *this,
		        VFXPPType__Enum type,
		        VFXPPComponent *component,
		        MethodInfo *method)
		{
		  VFXPPManager_1 *v6; // r15
		  int v7; // esi
		  VFXPPComponent *v8; // rdi
		  List_1_System_Object_ *activeComponents; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Object *v12; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  __int64 v15; // rdx
		  List_1_System_Object_ *list; // rcx
		  __int64 v17; // r8
		  Object *current; // r13
		  struct ILFixDynamicMethodWrapper_2__Class *v19; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v21; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v22; // rcx
		  ILFixDynamicMethodWrapper_2 *v23; // r15
		  Call *v24; // rax
		  __m128i v25; // xmm1
		  __m128i v26; // xmm2
		  Object *anonObj; // r12
		  _DWORD *v28; // xmm2_8
		  __int64 v29; // rcx
		  __int64 v30; // rdx
		  __int64 v31; // r14
		  Object__Array *managedStack; // rsi
		  Il2CppClass *element_class; // rbx
		  Object__Class *klass; // rdi
		  Value_1 *currentTop; // r8
		  signed __int64 v36; // rcx
		  __int64 v37; // rdx
		  signed __int64 v38; // rdi
		  Object__Array *v39; // rsi
		  Il2CppClass *v40; // rbx
		  Object__Class *v41; // r14
		  __int64 v42; // rdx
		  VirtualMachine *virtualMachine; // rcx
		  __int64 v44; // rdx
		  __int64 v45; // rcx
		  int32_t Value1; // ecx
		  struct Object_1__Class *v47; // rdx
		  Object *v48; // r14
		  bool v49; // zf
		  List_1_List_1_HG_Rendering_Runtime_VFXPPComponent_ *v50; // rax
		  __int64 v51; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v53; // rdx
		  __int64 v54; // rcx
		  __int64 v55; // rax
		  __int64 v56; // rax
		  int v57; // [rsp+30h] [rbp-D8h]
		  VFXPPComponent *v59; // [rsp+38h] [rbp-D0h]
		  Call call; // [rsp+40h] [rbp-C8h] BYREF
		  List_1_T_Enumerator_System_Object_ v61; // [rsp+68h] [rbp-A0h] BYREF
		  VFXPPComponent *v62; // [rsp+80h] [rbp-88h]
		  List_1_T_Enumerator_System_Object_ v63; // [rsp+88h] [rbp-80h] BYREF
		  Il2CppExceptionWrapper *v64; // [rsp+A0h] [rbp-68h] BYREF
		  Call v65[2]; // [rsp+A8h] [rbp-60h] BYREF
		
		  v6 = this;
		  v62 = component;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2464, 0LL) )
		  {
		    v7 = 0;
		    v57 = 0;
		    v8 = 0LL;
		    v59 = 0LL;
		    activeComponents = (List_1_System_Object_ *)HG::Rendering::Runtime::VFXPPManager::get_activeComponents(v6, 0LL);
		    if ( !activeComponents )
		      sub_1800D8260(v11, v10);
		    v12 = System::Collections::Generic::List<System::Object>::get_Item(
		            activeComponents,
		            type,
		            MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::get_Item);
		    if ( !v12 )
		      sub_1800D8260(v14, v13);
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v61,
		      (List_1_System_UInt64_ *)v12,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::GetEnumerator);
		    v63 = v61;
		    v61._list = 0LL;
		    *(_QWORD *)&v61._index = &v63;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                &v63,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VFXPPComponent>::MoveNext) )
		      {
		        current = v63._current;
		        if ( !v63._current )
		          sub_1800D8250(list, v15);
		        v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		          v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        wrapperArray = v19->static_fields->wrapperArray;
		        if ( !wrapperArray )
		          sub_1800D8250(v19, 0LL);
		        if ( wrapperArray->max_length.size <= 2458 )
		          goto LABEL_51;
		        if ( !v19->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v19);
		          v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v21 = v19->static_fields->wrapperArray;
		        if ( !v21 )
		          sub_1800D8250(v19, 0LL);
		        if ( v21->max_length.size <= 0x99Au )
		          sub_1800D2AA0(v19, v21, v17);
		        if ( v21[68].vector[10] )
		        {
		          if ( !v19->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v19);
		            v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v22 = v19->static_fields->wrapperArray;
		          if ( !v22 )
		            sub_1800D8250(0LL, v21);
		          if ( v22->max_length.size <= 0x99Au )
		            sub_1800D2AA0(v22, v21, v17);
		          v23 = v22[68].vector[10];
		          if ( !v23 )
		            sub_1800D8250(v22, v21);
		          memset(&call, 0, sizeof(call));
		          v24 = IFix::Core::Call::Begin(v65, 0LL);
		          v25 = *(__m128i *)&v24->argumentBase;
		          *(_OWORD *)&call.argumentBase = *(_OWORD *)&v24->argumentBase;
		          v26 = *(__m128i *)&v24->managedStack;
		          *(__m128i *)&call.managedStack = v26;
		          call.topWriteBack = v24->topWriteBack;
		          if ( v23->fields.anonObj )
		          {
		            anonObj = v23->fields.anonObj;
		            v28 = (_DWORD *)_mm_srli_si128(v26, 8).m128i_u64[0];
		            v29 = (__int64)v28 - _mm_srli_si128(v25, 8).m128i_u64[0];
		            v30 = (unsigned __int128)(v29 * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		            v31 = v29 / 12;
		            if ( !v28 )
		              sub_1800D8250(v29, v30);
		            *v28 = 8;
		            if ( !call.currentTop )
		              sub_1800D8250(v29, v30);
		            call.currentTop->Value1 = v31;
		            managedStack = call.managedStack;
		            if ( !call.managedStack )
		              sub_1800D8250(v29, v30);
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
		              v55 = sub_18031E23C();
		              sub_18007E190(v55, 0LL);
		            }
		            sub_180005370(managedStack, (int)v31, anonObj);
		            currentTop = ++call.currentTop;
		          }
		          else
		          {
		            currentTop = call.currentTop;
		          }
		          v36 = (char *)currentTop - (char *)call.evaluationStackBase;
		          v37 = (unsigned __int128)(((char *)currentTop - (char *)call.evaluationStackBase)
		                                  * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		          v38 = currentTop - call.evaluationStackBase;
		          if ( !currentTop )
		            sub_1800D8250(v36, v37);
		          currentTop->Type = 8;
		          if ( !call.currentTop )
		            sub_1800D8250(v36, v37);
		          call.currentTop->Value1 = v38;
		          v39 = call.managedStack;
		          if ( !call.managedStack )
		            sub_1800D8250(v36, v37);
		          v40 = call.managedStack->klass->_0.element_class;
		          v41 = current->klass;
		          if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v40, current->klass)
		            && ((BYTE1(v41->vtable.Equals.methodPtr) & 0x10) == 0
		             || ((v40->flags & 0x20) == 0
		              && *((_BYTE *)&v40->byval_arg + 10) != 19
		              && *((_BYTE *)&v40->byval_arg + 10) != 30
		              || !v40->interopData
		              || !v40->interopData->guid
		              || !sub_1802ED414(current))
		             && v40 != (Il2CppClass *)qword_18F35FF70) )
		          {
		            v56 = sub_18031E23C();
		            sub_18007E190(v56, 0LL);
		          }
		          sub_180005370(v39, (int)v38, current);
		          ++call.currentTop;
		          virtualMachine = v23->fields.virtualMachine;
		          if ( !virtualMachine )
		            sub_1800D8250(0LL, v42);
		          IFix::Core::VirtualMachine::Execute(
		            virtualMachine,
		            v23->fields.methodId,
		            &call,
		            (v23->fields.anonObj != 0LL) + 1,
		            0,
		            0LL);
		          if ( !call.argumentBase )
		            sub_1800D8250(v45, v44);
		          Value1 = call.argumentBase->Value1;
		          v8 = v59;
		          v7 = v57;
		          v6 = this;
		        }
		        else
		        {
		LABEL_51:
		          Value1 = (int32_t)current[2].klass;
		        }
		        if ( Value1 >= v6->fields.m_curPriorityFilter )
		        {
		          v57 = ++v7;
		          v8 = (VFXPPComponent *)current;
		          if ( v7 != 1 )
		            v8 = 0LL;
		          v59 = v8;
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v64 )
		    {
		      v61._list = (List_1_System_Object_ *)v64->ex;
		      list = v61._list;
		      if ( v61._list )
		        sub_18007E1E0(v61._list);
		      v8 = v59;
		      v7 = v57;
		      v6 = this;
		    }
		    if ( v7 == 1 )
		    {
		      v47 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v47 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v47 = TypeInfo::UnityEngine::Object;
		        }
		      }
		      LOBYTE(list) = v8 == 0LL;
		      v48 = (Object *)component;
		      if ( v8 == 0LL && component == 0LL )
		        goto LABEL_74;
		      if ( v62 )
		      {
		        if ( v8 )
		        {
		          v49 = v8 == component;
		        }
		        else
		        {
		          if ( !v47->_1.cctor_finished_or_no_cctor )
		            il2cpp_runtime_class_init_1(v47);
		          v49 = component->fields._._._._._.m_CachedPtr == 0LL;
		        }
		      }
		      else
		      {
		        if ( !v47->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v47);
		        if ( !v8 )
		          goto LABEL_109;
		        v49 = v8->fields._._._._._.m_CachedPtr == 0LL;
		      }
		      if ( v49 )
		      {
		LABEL_74:
		        if ( !component )
		          goto LABEL_109;
		        sub_1800049A0(component->klass);
		        if ( ((unsigned __int8 (__fastcall *)(VFXPPComponent *, Il2CppMethodPointer))component->klass->vtable.get_ImplementedInVolume.method)(
		               component,
		               component->klass->vtable.SetData.methodPtr) )
		        {
		          sub_18003B7B0(15LL, component, v6->fields.m_ppVolumeProfile);
		        }
		        else
		        {
		          sub_180073530(17LL, component, v6->fields.m_envPhaseForVFX);
		        }
		      }
		    }
		    else
		    {
		      v48 = (Object *)component;
		    }
		    v50 = HG::Rendering::Runtime::VFXPPManager::get_activeComponents(v6, 0LL);
		    if ( v50 )
		    {
		      v47 = (struct Object_1__Class *)(int)type;
		      if ( (unsigned int)type >= v50->fields._size )
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      list = (List_1_System_Object_ *)v50->fields._items;
		      if ( list )
		      {
		        if ( (unsigned int)type >= list->fields._size )
		          sub_1800D2AA0(list, type, v51);
		        list = (List_1_System_Object_ *)*((_QWORD *)&list->fields._syncRoot + (int)type);
		        if ( list )
		        {
		          System::Collections::Generic::List<System::Object>::Remove(
		            list,
		            v48,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::Remove);
		          return;
		        }
		      }
		    }
		LABEL_109:
		    sub_1800D8250(list, v47);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2464, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v54, v53);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_21(
		    (ILFixDynamicMethodWrapper_14 *)Patch,
		    (Object *)v6,
		    type,
		    (Object *)component,
		    0LL);
		}
		
		private void OnBeginFrameRendering(ScriptableRenderContext context, List<Camera> targetCamera) {} // 0x00000001830888B0-0x00000001830897D0
		// Void OnBeginFrameRendering(ScriptableRenderContext, List`1[UnityEngine.Camera])
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		void HG::Rendering::Runtime::VFXPPManager::OnBeginFrameRendering(
		        VFXPPManager_1 *this,
		        ScriptableRenderContext context,
		        List_1_UnityEngine_Camera_ *targetCamera,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v9; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  VFXPPManager_1 *instance; // rbx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  bool v17; // zf
		  struct Object_1__Class *v18; // rcx
		  Object_1 *gameObject; // rbx
		  VolumeProfile *m_ppVolumeProfile; // rbx
		  HGRuntimeGrassQuery_Node *v21; // rdx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  HGRuntimeGrassQuery_Node *v24; // rdx
		  __int64 v25; // rcx
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  Volume *m_ppVolumeForVFX; // rbx
		  Volume *v29; // rbx
		  HGEnvironmentPhase *m_envPhaseForVFX; // rbx
		  HGRuntimeGrassQuery_Node *v31; // rdx
		  HGRuntimeGrassQuery_Node *v32; // r8
		  Int32__Array **v33; // r9
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  struct ILFixDynamicMethodWrapper_2__Class *v38; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v39; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v40; // rbx
		  ILFixDynamicMethodWrapper_2 *v41; // rax
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  List_1_List_1_HG_Rendering_Runtime_VFXPPComponent_ *v44; // rbx
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v45; // rax
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  List_1_List_1_HG_Rendering_Runtime_VFXPPComponent_ *v48; // rbx
		  HGRuntimeGrassQuery_Node *v49; // rdx
		  HGRuntimeGrassQuery_Node *v50; // r8
		  Int32__Array **v51; // r9
		  __int64 v52; // rsi
		  List_1_System_Object_ *m_activeComponents; // rdi
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v54; // rax
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  Object *v57; // rbx
		  __int64 v58; // rdx
		  __int64 v59; // rcx
		  __int64 v60; // rdx
		  __int64 v61; // rcx
		  __int64 v62; // r8
		  HGRuntimeGrassQuery_Node *parent; // rsi
		  struct ILFixDynamicMethodWrapper_2__Class *v64; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v65; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v66; // rcx
		  ILFixDynamicMethodWrapper_2 *v67; // r13
		  Call *v68; // rax
		  __m128i v69; // xmm6
		  __m128i v70; // xmm2
		  Object *anonObj; // r13
		  _DWORD *v72; // xmm0_8
		  signed __int64 v73; // rcx
		  __int64 v74; // rdx
		  __int64 v75; // r14
		  Object__Array *v76; // r12
		  __int64 v77; // rdi
		  Object__Class *klass; // r15
		  _DWORD *v79; // rbx
		  unsigned __int64 v80; // rdi
		  char *v81; // rcx
		  __int64 v82; // rdx
		  __int64 v83; // r14
		  Il2CppClass *element_class; // rdi
		  VFXPPManager_1__Class *v85; // r15
		  VFXPPManager_1 *v86; // r15
		  _DWORD *v87; // rbx
		  char *v88; // rcx
		  __int64 v89; // rdx
		  __int64 v90; // rdi
		  Il2CppClass *v91; // rbx
		  HGRuntimeGrassQuery_Node__Class *v92; // r14
		  __int64 v93; // rdx
		  VirtualMachine *virtualMachine; // rcx
		  unsigned __int64 v95; // rdx
		  signed __int64 v96; // rcx
		  unsigned __int64 v97; // r8
		  struct MethodInfo *v98; // r14
		  __int64 v99; // rbx
		  void (__fastcall __noreturn **v100)(); // rax
		  unsigned int v101; // eax
		  __int64 v102; // rax
		  signed __int64 v103; // r9
		  unsigned int v104; // r8d
		  signed __int64 v105; // rtt
		  __int64 v106; // rbx
		  __int64 v107; // rax
		  __int64 v108; // rbx
		  _QWORD **v109; // rcx
		  __int64 v110; // r8
		  __int64 v111; // rax
		  __int64 v112; // rax
		  VFXPPComponent *v113; // rdi
		  __int64 v114; // rdx
		  const Il2CppRGCTXData *rgctx_data; // rax
		  _BYTE *rgctxDataDummy; // rbx
		  _BYTE *v117; // rax
		  VFXPPComponent__Class *v118; // rsi
		  float z; // ebx
		  __int64 v120; // rdi
		  struct Object_1__Class *v121; // rcx
		  __int64 v122; // rax
		  __int64 v123; // rax
		  __int64 v124; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-118h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-118h]
		  Value_1 *evaluationStackBase; // [rsp+58h] [rbp-E0h]
		  ILFixDynamicMethodWrapper_2 *v128; // [rsp+60h] [rbp-D8h]
		  HGRuntimeGrassQuery_Node v129; // [rsp+68h] [rbp-D0h] BYREF
		  __m128i v130; // [rsp+C0h] [rbp-78h]
		  Value_1 **topWriteBack; // [rsp+D0h] [rbp-68h]
		  Call v132; // [rsp+D8h] [rbp-60h] BYREF
		
		  v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v7->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v7, context.m_Ptr);
		  if ( wrapperArray->max_length.size > 2528 )
		  {
		    if ( !v7->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v7);
		      v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v9 = v7->static_fields->wrapperArray;
		    if ( !v9 )
		      sub_1800D8260(v7, context.m_Ptr);
		    if ( v9->max_length.size <= 0x9E0u )
		      sub_1800D2AB0(v7, context.m_Ptr);
		    if ( v9[70].vector[8] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2528, 0LL);
		      if ( !Patch )
		        sub_1800D8260(v12, v11);
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(Patch, (Object *)this, context, (Object *)targetCamera, 0LL);
		      return;
		    }
		  }
		  instance = HG::Rendering::Runtime::VFXPPManager::get_instance(0LL);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( instance == 0LL && this == 0LL )
		    goto LABEL_31;
		  if ( this )
		  {
		    if ( instance )
		    {
		      v17 = instance == this;
		    }
		    else
		    {
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v17 = this->fields._._._._.m_CachedPtr == 0LL;
		    }
		  }
		  else
		  {
		    v18 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !instance )
		      sub_1800D8260(v18, v13);
		    v17 = instance->fields._._._._.m_CachedPtr == 0LL;
		  }
		  if ( v17 )
		  {
		LABEL_31:
		    m_ppVolumeProfile = this->fields.m_ppVolumeProfile;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !m_ppVolumeProfile )
		      goto LABEL_39;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !m_ppVolumeProfile->fields._._.m_CachedPtr )
		    {
		LABEL_39:
		      this->fields.m_ppVolumeProfile = (VolumeProfile *)UnityEngine::ScriptableObject::CreateInstance<System::Object>(MethodInfo::UnityEngine::ScriptableObject::CreateInstance<UnityEngine::Rendering::VolumeProfile>);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_ppVolumeProfile, v21, v22, v23, methoda);
		      m_ppVolumeForVFX = this->fields.m_ppVolumeForVFX;
		      if ( !m_ppVolumeForVFX )
		        sub_1800D8260(v25, v24);
		      m_ppVolumeForVFX->fields.priority = 20000.0;
		      v29 = this->fields.m_ppVolumeForVFX;
		      if ( !v29 )
		        sub_1800D8260(v25, v24);
		      v29->fields.m_InternalProfile = this->fields.m_ppVolumeProfile;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v29->fields.m_InternalProfile, v24, v26, v27, methodb);
		    }
		    m_envPhaseForVFX = this->fields.m_envPhaseForVFX;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !m_envPhaseForVFX )
		      goto LABEL_50;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    if ( !m_envPhaseForVFX->fields._._.m_CachedPtr )
		    {
		LABEL_50:
		      this->fields.m_envPhaseForVFX = (HGEnvironmentPhase *)UnityEngine::ScriptableObject::CreateInstance<System::Object>(MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_envPhaseForVFX, v31, v32, v33, methoda);
		      if ( !this->fields.m_envVolumeForVFX )
		        sub_1800D8260(v35, v34);
		      HG::Rendering::Runtime::HGEnvironmentVolumeBase::set_priority(
		        (HGEnvironmentVolumeBase *)this->fields.m_envVolumeForVFX,
		        EnvPriority__Enum_VfxPp,
		        0LL);
		      if ( !this->fields.m_envVolumeForVFX )
		        sub_1800D8260(v37, v36);
		      HG::Rendering::Runtime::HGEnvironmentVolume::set_envPhase(
		        this->fields.m_envVolumeForVFX,
		        this->fields.m_envPhaseForVFX,
		        0LL);
		    }
		    v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v39 = v38->static_fields->wrapperArray;
		    if ( !v39 )
		      sub_1800D8260(v38, v13);
		    if ( v39->max_length.size <= 2462 )
		      goto LABEL_248;
		    if ( !v38->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v38);
		      v38 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v40 = v38->static_fields->wrapperArray;
		    if ( !v40 )
		      sub_1800D8260(v38, v13);
		    if ( v40->max_length.size <= 0x99Eu )
		      sub_1800D2AB0(v38, v13);
		    if ( v40[68].vector[14] )
		    {
		      v41 = IFix::WrappersManagerImpl::GetPatch(2462, 0LL);
		      if ( !v41 )
		        sub_1800D8260(v43, v42);
		      v44 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_950(v41, (Object *)this, 0LL);
		    }
		    else
		    {
		LABEL_248:
		      if ( !this->fields.m_activeComponents )
		      {
		        v45 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>);
		        v48 = (List_1_List_1_HG_Rendering_Runtime_VFXPPComponent_ *)v45;
		        if ( !v45 )
		          sub_1800D8260(v47, v46);
		        System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		          v45,
		          MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::List);
		        this->fields.m_activeComponents = v48;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_activeComponents, v49, v50, v51, methoda);
		        v52 = 17LL;
		        do
		        {
		          m_activeComponents = (List_1_System_Object_ *)this->fields.m_activeComponents;
		          v54 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>);
		          v57 = (Object *)v54;
		          if ( !v54 )
		            sub_1800D8260(v56, v55);
		          System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		            v54,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>::List);
		          if ( !m_activeComponents )
		            sub_1800D8260(v59, v58);
		          sub_182F01190(m_activeComponents, v57);
		          --v52;
		        }
		        while ( v52 );
		      }
		      v44 = this->fields.m_activeComponents;
		    }
		    if ( !v44 )
		      sub_1800D8260(v38, v13);
		    *(_OWORD *)&v129.monitor = 0LL;
		    v129.klass = (HGRuntimeGrassQuery_Node__Class *)v44;
		    sub_18002D1B0(&v129, v13, v15, v16, methoda);
		    LODWORD(v129.monitor) = 0;
		    HIDWORD(v129.monitor) = v44->fields._version;
		    *(_QWORD *)&v129.fields.bounds.m_Center.x = 0LL;
		    *(_OWORD *)&v129.fields.bounds.m_Center.z = *(_OWORD *)&v129.klass;
		    v129.fields.parent = 0LL;
		    v129.klass = 0LL;
		    v129.monitor = (MonitorData *)&v129.fields.bounds.m_Center.z;
		    while ( 1 )
		    {
		      do
		      {
		        if ( !System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                (List_1_T_Enumerator_System_Object_ *)&v129.fields.bounds.m_Center.z,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::MoveNext) )
		          return;
		        parent = v129.fields.parent;
		        if ( !v129.fields.parent )
		          sub_1800D8250(v61, v60);
		      }
		      while ( SLODWORD(v129.fields.parent->fields.bounds.m_Center.z) <= 0 );
		      v64 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        v64 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v65 = v64->static_fields->wrapperArray;
		      if ( !v65 )
		        sub_1800D8250(v64, 0LL);
		      if ( v65->max_length.size > 2530 )
		      {
		        if ( !v64->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v64);
		          v64 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v65 = v64->static_fields->wrapperArray;
		        if ( !v65 )
		          sub_1800D8250(v64, 0LL);
		        if ( v65->max_length.size <= 0x9E2u )
		          sub_1800D2AA0(v64, v65, v62);
		        if ( v65[70].vector[10] )
		          break;
		      }
		      if ( !parent )
		        sub_1800D8250(v64, v65);
		      z = parent->fields.bounds.m_Center.z;
		      while ( 1 )
		      {
		        --LODWORD(z);
		        if ( z < 0.0 )
		          break;
		        if ( LODWORD(z) >= LODWORD(parent->fields.bounds.m_Center.z) )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        v120 = *(_QWORD *)&parent->fields.bounds.m_Center.x;
		        if ( !v120 )
		          sub_1800D8250(v64, v65);
		        if ( LODWORD(z) >= *(_DWORD *)(v120 + 24) )
		          sub_1800D2AA0(v64, v65, v62);
		        v113 = *(VFXPPComponent **)(v120 + 8LL * SLODWORD(z) + 32);
		        if ( !v113 )
		          sub_1800D8250(v64, v65);
		        if ( (unsigned __int8)sub_180006280(18LL, v113) || z == 0.0 )
		          goto LABEL_194;
		      }
		      v113 = 0LL;
		LABEL_194:
		      v121 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v121 = TypeInfo::UnityEngine::Object;
		        if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		          v121 = TypeInfo::UnityEngine::Object;
		        }
		      }
		      if ( v113 )
		      {
		        if ( !v121->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v121);
		        if ( v113->fields._._._._._.m_CachedPtr
		          && (int)HG::Rendering::Runtime::VFXPPComponent::get_priority(v113, 0LL) >= this->fields.m_curPriorityFilter )
		        {
		          sub_1800049A0(v113->klass);
		          if ( ((unsigned __int8 (__fastcall *)(VFXPPComponent *, Il2CppMethodPointer))v113->klass->vtable.get_ImplementedInVolume.method)(
		                 v113,
		                 v113->klass->vtable.SetData.methodPtr) )
		          {
		            sub_18003B7B0(14LL, v113, this->fields.m_ppVolumeProfile);
		          }
		          else
		          {
		            sub_180073530(16LL, v113, this->fields.m_envPhaseForVFX);
		          }
		        }
		      }
		    }
		    if ( !v64->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v64);
		      v64 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v66 = v64->static_fields->wrapperArray;
		    if ( !v66 )
		      sub_1800D8250(0LL, v65);
		    if ( v66->max_length.size <= 0x9E2u )
		      sub_1800D2AA0(v66, v65, v62);
		    v67 = v66[70].vector[10];
		    v128 = v67;
		    if ( !v67 )
		      sub_1800D8250(v66, v65);
		    v68 = IFix::Core::Call::Begin(&v132, 0LL);
		    v69 = *(__m128i *)&v68->argumentBase;
		    v70 = *(__m128i *)&v68->managedStack;
		    v130 = v70;
		    topWriteBack = v68->topWriteBack;
		    if ( v67->fields.anonObj )
		    {
		      anonObj = v67->fields.anonObj;
		      v72 = (_DWORD *)_mm_srli_si128(v70, 8).m128i_u64[0];
		      evaluationStackBase = (Value_1 *)_mm_srli_si128(v69, 8).m128i_u64[0];
		      v73 = (char *)v72 - (char *)evaluationStackBase;
		      v74 = (unsigned __int128)(((char *)v72 - (char *)evaluationStackBase) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		      v75 = ((char *)v72 - (char *)evaluationStackBase) / 12;
		      if ( !v72 )
		        sub_1800D8250(v73, v74);
		      *v72 = 8;
		      v72[1] = v75;
		      v76 = (Object__Array *)v70.m128i_i64[0];
		      if ( !v70.m128i_i64[0] )
		        sub_1800D8250(v73, v74);
		      v77 = *(_QWORD *)(*(_QWORD *)v70.m128i_i64[0] + 64LL);
		      klass = anonObj->klass;
		      if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v77, anonObj->klass)
		        && ((BYTE1(klass->vtable.Equals.methodPtr) & 0x10) == 0
		         || ((*(_BYTE *)(v77 + 276) & 0x20) == 0 && *(_BYTE *)(v77 + 42) != 19 && *(_BYTE *)(v77 + 42) != 30
		          || !*(_QWORD *)(v77 + 112)
		          || !*(_QWORD *)(*(_QWORD *)(v77 + 112) + 40LL)
		          || !sub_1802ED414(anonObj))
		         && v77 != qword_18F35FF70) )
		      {
		        v122 = sub_18031E23C();
		        sub_18007E190(v122, 0LL);
		      }
		      sub_180005370(v70.m128i_i64[0], (int)v75, anonObj);
		      v79 = v72 + 3;
		      v67 = v128;
		      v80 = (unsigned __int64)evaluationStackBase;
		    }
		    else
		    {
		      v79 = (_DWORD *)v130.m128i_i64[1];
		      v76 = (Object__Array *)v130.m128i_i64[0];
		      v80 = _mm_srli_si128(v69, 8).m128i_u64[0];
		      evaluationStackBase = (Value_1 *)v80;
		    }
		    v81 = (char *)v79 - v80;
		    v82 = (unsigned __int128)((__int64)((__int64)v79 - v80) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		    v83 = (__int64)((__int64)v79 - v80) / 12;
		    if ( !v79 )
		      sub_1800D8250(v81, v82);
		    *v79 = 8;
		    v79[1] = v83;
		    if ( !v76 )
		      sub_1800D8250(v81, v82);
		    if ( !this )
		    {
		      v86 = 0LL;
		      goto LABEL_116;
		    }
		    element_class = v76->klass->_0.element_class;
		    v85 = this->klass;
		    if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(element_class, this->klass) )
		    {
		      if ( (BYTE1(v85->vtable.Equals.methodPtr) & 0x10) == 0 )
		        goto LABEL_228;
		      if ( (element_class->flags & 0x20) != 0
		        || *((_BYTE *)&element_class->byval_arg + 10) == 19
		        || *((_BYTE *)&element_class->byval_arg + 10) == 30 )
		      {
		        v86 = this;
		        if ( element_class->interopData && element_class->interopData->guid && sub_1802ED414(this) )
		          goto LABEL_115;
		      }
		      else
		      {
		        v86 = this;
		      }
		      if ( element_class != (Il2CppClass *)qword_18F35FF70 )
		      {
		LABEL_228:
		        v124 = sub_18031E23C();
		        sub_18007E190(v124, 0LL);
		      }
		      goto LABEL_115;
		    }
		    v86 = this;
		LABEL_115:
		    v80 = (unsigned __int64)evaluationStackBase;
		LABEL_116:
		    sub_180005370(v76, (int)v83, v86);
		    v87 = v79 + 3;
		    v88 = (char *)v87 - v80;
		    v89 = (unsigned __int128)((__int64)((__int64)v87 - v80) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		    v90 = (__int64)((__int64)v87 - v80) / 12;
		    if ( !v87 )
		      sub_1800D8250(v88, v89);
		    *v87 = 8;
		    v87[1] = v90;
		    if ( parent )
		    {
		      v91 = v76->klass->_0.element_class;
		      v92 = parent->klass;
		      if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v91, parent->klass)
		        && ((BYTE1(v92->vtable.Equals.methodPtr) & 0x10) == 0
		         || ((v91->flags & 0x20) == 0
		          && *((_BYTE *)&v91->byval_arg + 10) != 19
		          && *((_BYTE *)&v91->byval_arg + 10) != 30
		          || !v91->interopData
		          || !v91->interopData->guid
		          || !sub_1802ED414(parent))
		         && v91 != (Il2CppClass *)qword_18F35FF70) )
		      {
		        v123 = sub_18031E23C();
		        sub_18007E190(v123, 0LL);
		      }
		    }
		    sub_180005370(v76, (int)v90, parent);
		    virtualMachine = v67->fields.virtualMachine;
		    if ( !virtualMachine )
		      sub_1800D8250(0LL, v93);
		    IFix::Core::VirtualMachine::Execute(
		      virtualMachine,
		      virtualMachine->fields.unmanagedCodes[v67->fields.methodId],
		      (Value_1 *)v69.m128i_i64[0],
		      v76,
		      evaluationStackBase,
		      (v67->fields.anonObj != 0LL) + 2,
		      v67->fields.methodId,
		      0,
		      topWriteBack,
		      0LL);
		    v98 = MethodInfo::IFix::Core::Call::GetAsType<HG::Rendering::Runtime::VFXPPComponent>;
		    if ( !MethodInfo::IFix::Core::Call::GetAsType<HG::Rendering::Runtime::VFXPPComponent>->rgctx_data )
		      sub_1800430B0(MethodInfo::IFix::Core::Call::GetAsType<HG::Rendering::Runtime::VFXPPComponent>);
		    if ( !byte_18F3963A0 )
		    {
		      v97 = _InterlockedExchangeAdd64((volatile signed __int64 *)&MethodInfo::IFix::Core::Call::GetObject, 0LL);
		      if ( (v97 & 1) != 0 )
		      {
		        v99 = ((unsigned int)v97 >> 1) & 0xFFFFFFF;
		        switch ( (unsigned int)v97 >> 29 )
		        {
		          case 1u:
		            v100 = (void (__fastcall __noreturn **)())sub_180036020((unsigned int)v99);
		            goto LABEL_164;
		          case 2u:
		            v100 = (void (__fastcall __noreturn **)())sub_1800362C0((unsigned int)v99);
		            goto LABEL_164;
		          case 3u:
		          case 6u:
		            v101 = ((unsigned int)v97 >> 1) & 0xFFFFFFF;
		            v97 = (unsigned int)v97 >> 29;
		            if ( (_DWORD)v97 )
		            {
		              if ( (_DWORD)v97 == 3 )
		              {
		                v100 = (void (__fastcall __noreturn **)())sub_180009A40(v101);
		                goto LABEL_164;
		              }
		              if ( (_DWORD)v97 == 6 )
		              {
		                v102 = sub_1802F8800(v101);
		                v100 = (void (__fastcall __noreturn **)())sub_180026660(v102, 0LL);
		                goto LABEL_164;
		              }
		            }
		            else if ( v101 == 1 )
		            {
		              v100 = off_18B8C2EC0;
		              goto LABEL_164;
		            }
		LABEL_163:
		            v100 = 0LL;
		LABEL_164:
		            if ( v100 )
		              _InterlockedExchange64((volatile __int64 *)&MethodInfo::IFix::Core::Call::GetObject, (__int64)v100);
		            break;
		          case 4u:
		            v100 = (void (__fastcall __noreturn **)())sub_1802F8760((unsigned int)v99);
		            goto LABEL_164;
		          case 5u:
		            v96 = qword_18F371F68;
		            if ( *(_QWORD *)(qword_18F371F68 + 8 * v99) )
		            {
		              v100 = *(void (__fastcall __noreturn ***)())(qword_18F371F68 + 8 * v99);
		            }
		            else
		            {
		              v103 = il2cpp_string_new_len(
		                       qword_18F360DF8
		                     + *(int *)(qword_18F360DF8 + *(int *)(qword_18F360E00 + 8) + 8 * v99 + 4)
		                     + *(int *)(qword_18F360E00 + 16),
		                       *(unsigned int *)(qword_18F360DF8 + *(int *)(qword_18F360E00 + 8) + 8 * v99));
		              v96 = qword_18F371F68;
		              v100 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
		                                                          (volatile signed __int64 *)(qword_18F371F68 + 8 * v99),
		                                                          v103,
		                                                          0LL);
		              if ( !v100 )
		              {
		                v97 = qword_18F371F68 + 8 * v99;
		                if ( dword_18F35FD08 )
		                {
		                  v104 = (v97 >> 12) & 0x1FFFFF;
		                  v95 = (unsigned __int64)v104 >> 6;
		                  v97 = v104 & 0x3F;
		                  _m_prefetchw(&qword_18F103690[v95]);
		                  do
		                  {
		                    v96 = qword_18F103690[v95] | (1LL << v97);
		                    v105 = qword_18F103690[v95];
		                  }
		                  while ( v105 != _InterlockedCompareExchange64(&qword_18F103690[v95], v96, v105) );
		                }
		                v100 = (void (__fastcall __noreturn **)())v103;
		              }
		            }
		            goto LABEL_164;
		          case 7u:
		            v106 = sub_1802F8760((unsigned int)v99);
		            v107 = *(_QWORD *)(v106 + 16);
		            v108 = (v106 - *(_QWORD *)(v107 + 128)) >> 5;
		            if ( *(_BYTE *)(v107 + 42) == 21 )
		            {
		              v109 = *(_QWORD ***)(v107 + 96);
		              if ( *v109 )
		              {
		                v110 = **v109 - (qword_18F360DF8 + *(int *)(qword_18F360E00 + 160));
		                v107 = sub_180009B10(v110 / 92 + v110);
		              }
		              else
		              {
		                v107 = 0LL;
		              }
		            }
		            LODWORD(v129.fields.left) = v108 + *(_DWORD *)(*(_QWORD *)(v107 + 104) + 32LL);
		            v111 = sub_1801CD744(
		                     (unsigned int)&v129.fields.left,
		                     (int)qword_18F360DF8 + *(_DWORD *)(qword_18F360E00 + 64),
		                     *(int *)(qword_18F360E00 + 68) / 0xCuLL,
		                     12,
		                     (__int64)sub_1802F7130);
		            if ( !v111 )
		              goto LABEL_163;
		            v95 = *(unsigned int *)(v111 + 8);
		            if ( (_DWORD)v95 == -1 )
		              goto LABEL_163;
		            v100 = (void (__fastcall __noreturn **)())(v95 + qword_18F360DF8 + *(int *)(qword_18F360E00 + 72));
		            goto LABEL_164;
		          default:
		            break;
		        }
		      }
		      byte_18F3963A0 = 1;
		    }
		    if ( !v69.m128i_i64[0] )
		      sub_1800D8250(v96, v95);
		    v112 = *(int *)(v69.m128i_i64[0] + 4);
		    if ( (unsigned int)v112 >= v76->max_length.size )
		      sub_1800D2AA0(v96, v95, v97);
		    v113 = (VFXPPComponent *)v76->vector[v112];
		    sub_180005370(v76, (v69.m128i_i64[0] - (__int64)evaluationStackBase) / 12, 0LL);
		    rgctx_data = v98->rgctx_data;
		    rgctxDataDummy = rgctx_data->rgctxDataDummy;
		    if ( (*((_BYTE *)rgctx_data->rgctxDataDummy + 312) & 1) == 0 )
		    {
		      sub_1800360B0(rgctx_data->rgctxDataDummy, v114);
		      rgctxDataDummy = v117;
		    }
		    if ( v113 )
		    {
		      v118 = v113->klass;
		      if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(rgctxDataDummy, v113->klass)
		        && ((BYTE1(v118->vtable.Equals.methodPtr) & 0x10) == 0
		         || ((rgctxDataDummy[276] & 0x20) == 0 && rgctxDataDummy[42] != 19 && rgctxDataDummy[42] != 30
		          || !*((_QWORD *)rgctxDataDummy + 14)
		          || !*(_QWORD *)(*((_QWORD *)rgctxDataDummy + 14) + 40LL)
		          || !sub_1802ED414(v113))
		         && rgctxDataDummy != (_BYTE *)qword_18F35FF70) )
		      {
		        sub_18031E1F4(v113, rgctxDataDummy);
		      }
		    }
		    else
		    {
		      v113 = 0LL;
		    }
		    goto LABEL_194;
		  }
		  gameObject = (Object_1 *)UnityEngine::Component::get_gameObject((Component *)this, 0LL);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		  HG::Rendering::Runtime::HGUtils::Destroy(gameObject, 0LL);
		}
		
		private VFXPPComponent _FindLastActiveComponent(List<VFXPPComponent> list) => default; // 0x00000001830897D0-0x00000001830898A0
		// VFXPPComponent _FindLastActiveComponent(List`1[HG.Rendering.Runtime.VFXPPComponent])
		VFXPPComponent *HG::Rendering::Runtime::VFXPPManager::_FindLastActiveComponent(
		        VFXPPManager_1 *this,
		        List_1_HG_Rendering_Runtime_VFXPPComponent_ *list,
		        MethodInfo *method)
		{
		  _QWORD **items; // rcx
		  __int64 v6; // rdx
		  int32_t v7; // ebx
		  VFXPPComponent *v8; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = *items[23];
		  if ( !v6 )
		    goto LABEL_16;
		  if ( *(int *)(v6 + 24) <= 2530 )
		    goto LABEL_5;
		  if ( !*((_DWORD *)items + 56) )
		  {
		    il2cpp_runtime_class_init_1(items);
		    items = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = *items[23];
		  if ( !v6 )
		LABEL_16:
		    sub_1800D8260(items, v6);
		  if ( *(_DWORD *)(v6 + 24) <= 0x9E2u )
		LABEL_17:
		    sub_1800D2AB0(items, v6);
		  if ( *(_QWORD *)(v6 + 20272) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2530, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_956(Patch, (Object *)this, (Object *)list, 0LL);
		    goto LABEL_16;
		  }
		LABEL_5:
		  if ( !list )
		    goto LABEL_16;
		  v7 = list->fields._size - 1;
		  if ( v7 < 0 )
		    return 0LL;
		  while ( 1 )
		  {
		    if ( (unsigned int)v7 >= list->fields._size )
		      System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		    items = (_QWORD **)list->fields._items;
		    if ( !items )
		      goto LABEL_16;
		    if ( (unsigned int)v7 >= *((_DWORD *)items + 6) )
		      goto LABEL_17;
		    v8 = (VFXPPComponent *)items[v7 + 4];
		    if ( !v8 )
		      goto LABEL_16;
		    if ( (unsigned __int8)sub_180006280(18LL, v8) || !v7 )
		      return v8;
		    if ( --v7 < 0 )
		      return 0LL;
		  }
		}
		
		public void SetPriorityFilter(VFXPPPriority priority) {} // 0x00000001844D5B30-0x00000001844D6530
		// Void SetPriorityFilter(VFXPPPriority)
		// Hidden C++ exception states: #wind=1 #try_helpers=1
		void HG::Rendering::Runtime::VFXPPManager::SetPriorityFilter(
		        VFXPPManager_1 *this,
		        VFXPPPriority__Enum priority,
		        MethodInfo *method)
		{
		  List_1_System_UInt64_ *activeComponents; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // r8
		  Object *current; // rsi
		  struct ILFixDynamicMethodWrapper_2__Class *v12; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v14; // rcx
		  ILFixDynamicMethodWrapper_2 *v15; // r14
		  signed __int64 v16; // rcx
		  __int64 v17; // rdx
		  signed __int64 v18; // rdi
		  Object__Array *managedStack; // r15
		  Il2CppClass *element_class; // rbx
		  VFXPPManager_1__Class *v21; // r12
		  Value_1 *v22; // r8
		  signed __int64 v23; // rcx
		  __int64 v24; // rdx
		  signed __int64 v25; // rdi
		  Object__Array *v26; // r15
		  Il2CppClass *v27; // rbx
		  Object__Class *v28; // r12
		  __int64 v29; // rdx
		  VirtualMachine *virtualMachine; // rcx
		  __int64 v31; // rdx
		  __int64 v32; // r8
		  struct MethodInfo *v33; // rdi
		  signed __int64 v34; // rcx
		  __int64 v35; // rax
		  __int64 v36; // rax
		  __int64 v37; // rax
		  __int64 Value1; // rax
		  Object *v39; // rbx
		  const Il2CppRGCTXData *rgctx_data; // rax
		  _QWORD *rgctxDataDummy; // rdi
		  _QWORD *v42; // rax
		  Object__Class *v43; // rsi
		  unsigned int monitor; // edi
		  Object__Class *klass; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v46; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v47; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v48; // rdx
		  ILFixDynamicMethodWrapper_2__Array *v49; // rcx
		  ILFixDynamicMethodWrapper_2 *v50; // rdi
		  signed __int64 v51; // rcx
		  __int64 v52; // rdx
		  signed __int64 v53; // r14
		  Object__Array *v54; // r15
		  Il2CppClass *v55; // rsi
		  Object__Class *v56; // r12
		  __int64 v57; // rdx
		  VirtualMachine *v58; // rcx
		  __int64 v59; // rdx
		  __int64 v60; // rcx
		  int32_t v61; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v63; // rdx
		  __int64 v64; // rcx
		  __int64 v65; // rax
		  __int64 v66; // rax
		  __int64 v67; // rax
		  Call call; // [rsp+30h] [rbp-C8h] BYREF
		  Call v69; // [rsp+58h] [rbp-A0h] BYREF
		  List_1_T_Enumerator_System_Object_ v70; // [rsp+80h] [rbp-78h] BYREF
		  List_1_T_Enumerator_System_Object_ v71; // [rsp+98h] [rbp-60h] BYREF
		  Call v72; // [rsp+B8h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2532, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2532, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v64, v63);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, priority, 0LL);
		  }
		  else
		  {
		    this->fields.m_curPriorityFilter = priority;
		    activeComponents = (List_1_System_UInt64_ *)HG::Rendering::Runtime::VFXPPManager::get_activeComponents(this, 0LL);
		    if ( !activeComponents )
		      sub_1800D8260(v7, v6);
		    System::Collections::Generic::List<unsigned long>::GetEnumerator(
		      (List_1_T_Enumerator_System_UInt64_ *)&v70,
		      activeComponents,
		      MethodInfo::System::Collections::Generic::List<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::GetEnumerator);
		    v71 = v70;
		    v70._list = 0LL;
		    *(_QWORD *)&v70._index = &v71;
		    while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		              &v71,
		              MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<System::Collections::Generic::List<HG::Rendering::Runtime::VFXPPComponent>>::MoveNext) )
		    {
		      current = v71._current;
		      if ( !v71._current )
		        sub_1800D8250(v9, v8);
		      if ( SLODWORD(v71._current[1].monitor) > 0 )
		      {
		        v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		          v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        wrapperArray = v12->static_fields->wrapperArray;
		        if ( !wrapperArray )
		          sub_1800D8250(v12, 0LL);
		        if ( wrapperArray->max_length.size <= 2530 )
		          goto LABEL_78;
		        if ( !v12->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v12);
		          v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        wrapperArray = v12->static_fields->wrapperArray;
		        if ( !wrapperArray )
		          sub_1800D8250(v12, 0LL);
		        if ( wrapperArray->max_length.size <= 0x9E2u )
		          sub_1800D2AA0(v12, wrapperArray, v10);
		        if ( !wrapperArray[70].vector[10] )
		        {
		LABEL_78:
		          if ( !current )
		            sub_1800D8250(v12, wrapperArray);
		          monitor = (unsigned int)current[1].monitor;
		          while ( (--monitor & 0x80000000) == 0 )
		          {
		            if ( monitor >= LODWORD(current[1].monitor) )
		              System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		            klass = current[1].klass;
		            if ( !klass )
		              sub_1800D8250(v12, wrapperArray);
		            if ( monitor >= LODWORD(klass->_0.namespaze) )
		              sub_1800D2AA0(v12, wrapperArray, v10);
		            v39 = (Object *)*((_QWORD *)&klass->_0.byval_arg.data.dummy + (int)monitor);
		            if ( !v39 )
		              sub_1800D8250(v12, wrapperArray);
		            sub_1800049A0(v39->klass);
		            if ( ((unsigned __int8 (__fastcall *)(Object *, Il2CppMetadataGenericContainerHandle))v39->klass[1]._1.cctor_thread)(
		                   v39,
		                   v39->klass[1]._1.genericContainerHandle)
		              || !monitor )
		            {
		              goto LABEL_87;
		            }
		          }
		LABEL_129:
		          sub_1800D8250(v12, wrapperArray);
		        }
		        if ( !v12->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v12);
		          v12 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v14 = v12->static_fields->wrapperArray;
		        if ( !v14 )
		          sub_1800D8250(0LL, wrapperArray);
		        if ( v14->max_length.size <= 0x9E2u )
		          sub_1800D2AA0(v14, wrapperArray, v10);
		        v15 = v14[70].vector[10];
		        if ( !v15 )
		          sub_1800D8250(v14, wrapperArray);
		        memset(&call, 0, sizeof(call));
		        call = *IFix::Core::Call::Begin(&v69, 0LL);
		        if ( v15->fields.anonObj )
		          IFix::Core::Call::PushObject(&call, v15->fields.anonObj, 0LL);
		        v16 = (char *)call.currentTop - (char *)call.evaluationStackBase;
		        v17 = (unsigned __int128)(((char *)call.currentTop - (char *)call.evaluationStackBase)
		                                * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		        v18 = call.currentTop - call.evaluationStackBase;
		        if ( !call.currentTop )
		          sub_1800D8250(v16, v17);
		        call.currentTop->Type = 8;
		        if ( !call.currentTop )
		          sub_1800D8250(v16, v17);
		        call.currentTop->Value1 = v18;
		        managedStack = call.managedStack;
		        if ( !call.managedStack )
		          sub_1800D8250(v16, v17);
		        if ( this )
		        {
		          element_class = call.managedStack->klass->_0.element_class;
		          v21 = this->klass;
		          if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(element_class, this->klass)
		            && ((BYTE1(v21->vtable.Equals.methodPtr) & 0x10) == 0
		             || (!(unsigned __int8)il2cpp_class_is_interface(element_class)
		              || !element_class->interopData
		              || !element_class->interopData->guid
		              || !sub_1802ED414(this))
		             && element_class != (Il2CppClass *)qword_18F35FF70) )
		          {
		            v65 = sub_18031E23C();
		            sub_18007E190(v65, 0LL);
		          }
		        }
		        sub_180005370(managedStack, (int)v18, this);
		        v22 = call.currentTop + 1;
		        call.currentTop = v22;
		        v23 = (char *)v22 - (char *)call.evaluationStackBase;
		        v24 = (unsigned __int128)(((char *)v22 - (char *)call.evaluationStackBase) * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		        v25 = v22 - call.evaluationStackBase;
		        if ( !v22 )
		          sub_1800D8250(v23, v24);
		        v22->Type = 8;
		        if ( !call.currentTop )
		          sub_1800D8250(v23, v24);
		        call.currentTop->Value1 = v25;
		        v26 = call.managedStack;
		        if ( !call.managedStack )
		          sub_1800D8250(v23, v24);
		        if ( current )
		        {
		          v27 = call.managedStack->klass->_0.element_class;
		          v28 = current->klass;
		          if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v27, current->klass)
		            && ((BYTE1(v28->vtable.Equals.methodPtr) & 0x10) == 0
		             || (!(unsigned __int8)il2cpp_class_is_interface(v27)
		              || !v27->interopData
		              || !v27->interopData->guid
		              || !sub_1802ED414(current))
		             && v27 != (Il2CppClass *)qword_18F35FF70) )
		          {
		            v66 = sub_18031E23C();
		            sub_18007E190(v66, 0LL);
		          }
		        }
		        sub_180005370(v26, (int)v25, current);
		        ++call.currentTop;
		        virtualMachine = v15->fields.virtualMachine;
		        if ( !virtualMachine )
		          sub_1800D8250(0LL, v29);
		        IFix::Core::VirtualMachine::Execute(
		          virtualMachine,
		          v15->fields.methodId,
		          &call,
		          (v15->fields.anonObj != 0LL) + 2,
		          0,
		          0LL);
		        v33 = MethodInfo::IFix::Core::Call::GetAsType<HG::Rendering::Runtime::VFXPPComponent>;
		        if ( !MethodInfo::IFix::Core::Call::GetAsType<HG::Rendering::Runtime::VFXPPComponent>->rgctx_data )
		          sub_1800430B0(MethodInfo::IFix::Core::Call::GetAsType<HG::Rendering::Runtime::VFXPPComponent>);
		        if ( !byte_18F3963A0 )
		        {
		          v34 = _InterlockedExchangeAdd64((volatile signed __int64 *)&MethodInfo::IFix::Core::Call::GetObject, 0LL);
		          if ( (v34 & 1) != 0 )
		          {
		            v32 = ((unsigned int)v34 >> 1) & 0xFFFFFFF;
		            switch ( (unsigned int)v34 >> 29 )
		            {
		              case 1u:
		                v35 = sub_180036020((unsigned int)v32);
		                goto LABEL_59;
		              case 2u:
		                v35 = sub_1800362C0((unsigned int)v32);
		                goto LABEL_59;
		              case 3u:
		              case 6u:
		                v35 = sub_1802F8920(v34);
		                goto LABEL_59;
		              case 4u:
		                v35 = sub_1802F8760((unsigned int)v32);
		                goto LABEL_59;
		              case 5u:
		                v35 = sub_1802F89F0((unsigned int)v32);
		                goto LABEL_59;
		              case 7u:
		                v36 = sub_1802F8760((unsigned int)v32);
		                v37 = sub_1802F8690(v36);
		                if ( v37 )
		                  v35 = sub_1802F87B0(*(unsigned int *)(v37 + 8));
		                else
		                  v35 = 0LL;
		LABEL_59:
		                if ( v35 )
		                  _InterlockedExchange64((volatile __int64 *)&MethodInfo::IFix::Core::Call::GetObject, v35);
		                break;
		              default:
		                break;
		            }
		          }
		          byte_18F3963A0 = 1;
		        }
		        if ( !call.argumentBase )
		          sub_1800D8250(0LL, v31);
		        Value1 = call.argumentBase->Value1;
		        if ( !call.managedStack )
		          sub_1800D8250(call.argumentBase, v31);
		        if ( (unsigned int)Value1 >= call.managedStack->max_length.size )
		          sub_1800D2AA0(call.argumentBase, v31, v32);
		        v39 = call.managedStack->vector[Value1];
		        sub_180005370(call.managedStack, call.argumentBase - call.evaluationStackBase, 0LL);
		        rgctx_data = v33->rgctx_data;
		        rgctxDataDummy = rgctx_data->rgctxDataDummy;
		        if ( (*((_BYTE *)rgctx_data->rgctxDataDummy + 312) & 1) == 0 )
		        {
		          sub_1800360B0(rgctx_data->rgctxDataDummy, wrapperArray);
		          rgctxDataDummy = v42;
		        }
		        if ( v39 )
		        {
		          v43 = v39->klass;
		          if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(rgctxDataDummy, v39->klass)
		            && ((BYTE1(v43->vtable.Equals.methodPtr) & 0x10) == 0
		             || (!(unsigned __int8)il2cpp_class_is_interface(rgctxDataDummy)
		              || !rgctxDataDummy[14]
		              || (wrapperArray = *(ILFixDynamicMethodWrapper_2__Array **)(rgctxDataDummy[14] + 40LL)) == 0LL
		              || !sub_1802ED414(v39))
		             && rgctxDataDummy != (_QWORD *)qword_18F35FF70) )
		          {
		            sub_18031E1F4(v39, rgctxDataDummy);
		          }
		        }
		        else
		        {
		          v39 = 0LL;
		        }
		        if ( !v39 )
		          goto LABEL_129;
		LABEL_87:
		        v46 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		          v46 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v47 = v46->static_fields->wrapperArray;
		        if ( !v47 )
		          sub_1800D8250(v46, 0LL);
		        if ( v47->max_length.size <= 2458 )
		          goto LABEL_116;
		        if ( !v46->_1.cctor_finished_or_no_cctor )
		        {
		          il2cpp_runtime_class_init_1(v46);
		          v46 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        }
		        v48 = v46->static_fields->wrapperArray;
		        if ( !v48 )
		          sub_1800D8250(v46, 0LL);
		        if ( v48->max_length.size <= 0x99Au )
		          sub_1800D2AA0(v46, v48, v10);
		        if ( v48[68].vector[10] )
		        {
		          if ( !v46->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(v46);
		            v46 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		          }
		          v49 = v46->static_fields->wrapperArray;
		          if ( !v49 )
		            sub_1800D8250(0LL, v48);
		          if ( v49->max_length.size <= 0x99Au )
		            sub_1800D2AA0(v49, v48, v10);
		          v50 = v49[68].vector[10];
		          if ( !v50 )
		            sub_1800D8250(v49, v48);
		          memset(&v69, 0, sizeof(v69));
		          v69 = *IFix::Core::Call::Begin(&v72, 0LL);
		          if ( v50->fields.anonObj )
		            IFix::Core::Call::PushObject(&v69, v50->fields.anonObj, 0LL);
		          v51 = (char *)v69.currentTop - (char *)v69.evaluationStackBase;
		          v52 = (unsigned __int128)(((char *)v69.currentTop - (char *)v69.evaluationStackBase)
		                                  * (__int128)0x2AAAAAAAAAAAAAABLL) >> 64;
		          v53 = v69.currentTop - v69.evaluationStackBase;
		          if ( !v69.currentTop )
		            sub_1800D8250(v51, v52);
		          v69.currentTop->Type = 8;
		          if ( !v69.currentTop )
		            sub_1800D8250(v51, v52);
		          v69.currentTop->Value1 = v53;
		          v54 = v69.managedStack;
		          if ( !v69.managedStack )
		            sub_1800D8250(v51, v52);
		          v55 = v69.managedStack->klass->_0.element_class;
		          v56 = v39->klass;
		          if ( !(unsigned __int8)il2cpp_class_is_assignable_from_1(v55, v39->klass)
		            && ((BYTE1(v56->vtable.Equals.methodPtr) & 0x10) == 0
		             || (!(unsigned __int8)il2cpp_class_is_interface(v55)
		              || !v55->interopData
		              || !v55->interopData->guid
		              || !sub_1802ED414(v39))
		             && v55 != (Il2CppClass *)qword_18F35FF70) )
		          {
		            v67 = sub_18031E23C();
		            sub_18007E190(v67, 0LL);
		          }
		          sub_180005370(v54, (int)v53, v39);
		          ++v69.currentTop;
		          v58 = v50->fields.virtualMachine;
		          if ( !v58 )
		            sub_1800D8250(0LL, v57);
		          IFix::Core::VirtualMachine::Execute(v58, v50->fields.methodId, &v69, (v50->fields.anonObj != 0LL) + 1, 0, 0LL);
		          if ( !v69.argumentBase )
		            sub_1800D8250(v60, v59);
		          v61 = v69.argumentBase->Value1;
		        }
		        else
		        {
		LABEL_116:
		          v61 = (int32_t)v39[2].klass;
		        }
		        if ( v61 < this->fields.m_curPriorityFilter )
		        {
		          sub_1800049A0(v39->klass);
		          if ( ((unsigned __int8 (__fastcall *)(Object *, Il2CppGenericClass *))v39->klass[1]._0.parent)(
		                 v39,
		                 v39->klass[1]._0.generic_class) )
		          {
		            sub_18003B7B0(15LL, v39, this->fields.m_ppVolumeProfile);
		          }
		          else
		          {
		            sub_180073530(17LL, v39, this->fields.m_envPhaseForVFX);
		          }
		        }
		      }
		    }
		  }
		}
		
		public void SetVFXPPActive(bool active) {} // 0x0000000189B6211C-0x0000000189B6219C
		// Void SetVFXPPActive(Boolean)
		void HG::Rendering::Runtime::VFXPPManager::SetVFXPPActive(VFXPPManager_1 *this, bool active, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Behaviour *m_ppVolumeForVFX; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2533, 0LL) )
		  {
		    m_ppVolumeForVFX = (Behaviour *)this->fields.m_ppVolumeForVFX;
		    if ( m_ppVolumeForVFX )
		    {
		      UnityEngine::Behaviour::set_enabled(m_ppVolumeForVFX, active, 0LL);
		      m_ppVolumeForVFX = (Behaviour *)this->fields.m_envVolumeForVFX;
		      if ( m_ppVolumeForVFX )
		      {
		        UnityEngine::Behaviour::set_enabled(m_ppVolumeForVFX, active, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(m_ppVolumeForVFX, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2533, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, active, 0LL);
		}
		
		public bool GetVFXPPActive() => default; // 0x0000000189B61FB0-0x0000000189B62008
		// Boolean GetVFXPPActive()
		bool HG::Rendering::Runtime::VFXPPManager::GetVFXPPActive(VFXPPManager_1 *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Behaviour *m_ppVolumeForVFX; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2534, 0LL) )
		  {
		    m_ppVolumeForVFX = (Behaviour *)this->fields.m_ppVolumeForVFX;
		    if ( m_ppVolumeForVFX )
		      return UnityEngine::Behaviour::get_enabled(m_ppVolumeForVFX, 0LL);
		LABEL_5:
		    sub_1800D8260(m_ppVolumeForVFX, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2534, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public void SetVFXXPPLayer(int layer) {} // 0x0000000189B6219C-0x0000000189B62218
		// Void SetVFXXPPLayer(Int32)
		void HG::Rendering::Runtime::VFXPPManager::SetVFXXPPLayer(VFXPPManager_1 *this, int32_t layer, MethodInfo *method)
		{
		  Component *instance; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  GameObject *gameObject; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2535, 0LL) )
		  {
		    instance = (Component *)HG::Rendering::Runtime::VFXPPManager::get_instance(0LL);
		    if ( instance )
		    {
		      gameObject = UnityEngine::Component::get_gameObject(instance, 0LL);
		      if ( gameObject )
		      {
		        UnityEngine::GameObject::set_layer(gameObject, layer, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2535, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, layer, 0LL);
		}
		
		public void ResetVFXXPPLayer() {} // 0x0000000189B62098-0x0000000189B6211C
		// Void ResetVFXXPPLayer()
		void HG::Rendering::Runtime::VFXPPManager::ResetVFXXPPLayer(VFXPPManager_1 *this, MethodInfo *method)
		{
		  Component *instance; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  GameObject *gameObject; // rbx
		  int32_t v7; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2536, 0LL) )
		  {
		    instance = (Component *)HG::Rendering::Runtime::VFXPPManager::get_instance(0LL);
		    if ( instance )
		    {
		      gameObject = UnityEngine::Component::get_gameObject(instance, 0LL);
		      v7 = UnityEngine::LayerMask::NameToLayer((String *)"Default", 0LL);
		      if ( gameObject )
		      {
		        UnityEngine::GameObject::set_layer(gameObject, v7, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2536, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
