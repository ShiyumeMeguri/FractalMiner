using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGEnvironmentVolumeCameraComponent // TypeDefIndex: 37646
	{
		// Fields
		private HGEnvironmentPhase m_interpolatedPhase; // 0x10
		private Vector3 m_lastInterpolateTriggerPosition; // 0x18
		private bool m_useEnvVolumeInterpolatedPhase; // 0x24
		private readonly IndexedHashSet<HGEnvironmentVolumeBase> m_interpolatedVolumes; // 0x28
		private readonly List<float> m_interpolatedVolumesFactor; // 0x30
	
		// Properties
		public HGEnvironmentPhase interpolatedPhase { get => default; } // 0x00000001831064D0-0x0000000183106530 
		// HGEnvironmentPhase get_interpolatedPhase()
		HGEnvironmentPhase *HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(
		        HGEnvironmentVolumeCameraComponent *this,
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
		  if ( wrapperArray->max_length.size <= 451 )
		    return this->fields.m_interpolatedPhase;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x1C3 )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[9]._1.element_size )
		    return this->fields.m_interpolatedPhase;
		  Patch = IFix::WrappersManagerImpl::GetPatch(451, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_210(Patch, (Object *)this, 0LL);
		}
		
		public ref Vector3 lastInterpolateTriggerPosition { get => default; } // 0x0000000183EC9420-0x0000000183EC9480 
		// Vector3& get_lastInterpolateTriggerPosition()
		Vector3 *HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_lastInterpolateTriggerPosition(
		        HGEnvironmentVolumeCameraComponent *this,
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
		  if ( wrapperArray->max_length.size <= 791 )
		    return &this->fields.m_lastInterpolateTriggerPosition;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x317 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[16].vtable.GetHashCode.methodPtr )
		    return &this->fields.m_lastInterpolateTriggerPosition;
		  Patch = IFix::WrappersManagerImpl::GetPatch(791, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_317(Patch, (Object *)this, 0LL);
		}
		
		public bool useEnvVolumeInterpolatedPhase { get => default; } // 0x0000000183106470-0x00000001831064D0 
		// Boolean get_useEnvVolumeInterpolatedPhase()
		bool HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_useEnvVolumeInterpolatedPhase(
		        HGEnvironmentVolumeCameraComponent *this,
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
		  if ( wrapperArray->max_length.size <= 448 )
		    return this->fields.m_useEnvVolumeInterpolatedPhase;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x1C0 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[9]._1.cctor_thread )
		    return this->fields.m_useEnvVolumeInterpolatedPhase;
		  Patch = IFix::WrappersManagerImpl::GetPatch(448, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public IndexedHashSet<HGEnvironmentVolumeBase> interpolatedVolumes { get => default; } // 0x0000000183272A70-0x0000000183272AD0 
		// IndexedHashSet`1[HG.Rendering.Runtime.HGEnvironmentVolumeBase] get_interpolatedVolumes()
		IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedVolumes(
		        HGEnvironmentVolumeCameraComponent *this,
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
		  if ( wrapperArray->max_length.size <= 789 )
		    return this->fields.m_interpolatedVolumes;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x315 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[16].vtable.Finalize.methodPtr )
		    return this->fields.m_interpolatedVolumes;
		  Patch = IFix::WrappersManagerImpl::GetPatch(789, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_315(Patch, (Object *)this, 0LL);
		}
		
		public List<float> interpolatedVolumesFactor { get => default; } // 0x0000000183272AD0-0x0000000183272B30 
		// List`1[System.Single] get_interpolatedVolumesFactor()
		List_1_System_Single_ *HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedVolumesFactor(
		        HGEnvironmentVolumeCameraComponent *this,
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
		  if ( wrapperArray->max_length.size <= 790 )
		    return this->fields.m_interpolatedVolumesFactor;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x316 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[16].vtable.Finalize.method )
		    return this->fields.m_interpolatedVolumesFactor;
		  Patch = IFix::WrappersManagerImpl::GetPatch(790, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_316(Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public HGEnvironmentVolumeCameraComponent() {} // 0x00000001831D3840-0x00000001831D38E0
		// HGEnvironmentVolumeCameraComponent()
		void HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::HGEnvironmentVolumeCameraComponent(
		        HGEnvironmentVolumeCameraComponent *this,
		        MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  IndexedHashSet_1_System_Object_ *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *v9; // rdi
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  LowLevelList_1_System_Object_ *v13; // rax
		  List_1_System_Single_ *v14; // rdi
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  MethodInfo *v18; // [rsp+20h] [rbp-8h]
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  MethodInfo *v20; // [rsp+50h] [rbp+28h]
		
		  this->fields.m_useEnvVolumeInterpolatedPhase = 1;
		  this->fields.m_interpolatedPhase = (HGEnvironmentPhase *)UnityEngine::ScriptableObject::CreateInstance<System::Object>(MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v3, v4, v5, v18);
		  v6 = (IndexedHashSet_1_System_Object_ *)sub_1800368D0(TypeInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>);
		  v9 = (IndexedHashSet_1_HG_Rendering_Runtime_HGEnvironmentVolumeBase_ *)v6;
		  if ( !v6
		    || (Beyond::IndexedHashSet<System::Object>::IndexedHashSet(
		          v6,
		          MethodInfo::Beyond::IndexedHashSet<HG::Rendering::Runtime::HGEnvironmentVolumeBase>::IndexedHashSet),
		        this->fields.m_interpolatedVolumes = v9,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_interpolatedVolumes, v10, v11, v12, v19),
		        v13 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<float>),
		        (v14 = (List_1_System_Single_ *)v13) == 0LL) )
		  {
		    sub_1800D8260(v8, v7);
		  }
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v13,
		    MethodInfo::System::Collections::Generic::List<float>::List);
		  this->fields.m_interpolatedVolumesFactor = v14;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_interpolatedVolumesFactor, v15, v16, v17, v20);
		}
		
	
		// Methods
		public bool UseDirLightDataFromEnvDirectly(Light dirLight) => default; // 0x0000000189CE39E4-0x0000000189CE3A78
		// Boolean UseDirLightDataFromEnvDirectly(Light)
		bool HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
		        HGEnvironmentVolumeCameraComponent *this,
		        Light *dirLight,
		        MethodInfo *method)
		{
		  Object_1 *SunSourceLight; // rbx
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1487, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1487, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		             (ILFixDynamicMethodWrapper_33 *)Patch,
		             (Object *)this,
		             (Object *)dirLight,
		             0LL);
		  }
		  else
		  {
		    SunSourceLight = (Object_1 *)UnityEngine::Light::GetSunSourceLight(0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    result = UnityEngine::Object::op_Equality(SunSourceLight, (Object_1 *)dirLight, 0LL);
		    if ( result )
		      return HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_useEnvVolumeInterpolatedPhase(this, 0LL);
		  }
		  return result;
		}
		
	}
}
