using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("Rendering/Environment Volume")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class HGEnvironmentVolume : HGEnvironmentVolumeBase // TypeDefIndex: 37643
	{
		// Fields
		[FormerlySerializedAs("envPhase")]
		[Header("\u73AF\u5883\u914D\u7F6E")]
		[SerializeField]
		private HGEnvironmentPhase _envPhase; // 0x58
	
		// Properties
		public HGEnvironmentPhase envPhase { get => default; set {} } // 0x0000000183A943C0-0x0000000183A94420 0x0000000183D0C110-0x0000000183D0C150
		// HGEnvironmentPhase get_envPhase()
		HGEnvironmentPhase *HG::Rendering::Runtime::HGEnvironmentVolume::get_envPhase(
		        HGEnvironmentVolume *this,
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
		  if ( wrapperArray->max_length.size <= 1463 )
		    return this->fields._envPhase;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x5B7 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[31]._0.declaringType )
		    return this->fields._envPhase;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1463, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_210(Patch, (Object *)this, 0LL);
		}
		

		// Void set_envPhase(HGEnvironmentPhase)
		void HG::Rendering::Runtime::HGEnvironmentVolume::set_envPhase(
		        HGEnvironmentVolume *this,
		        HGEnvironmentPhase *value,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1464, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1464, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)value,
		      0LL);
		  }
		  else
		  {
		    this->fields._envPhase = value;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields._envPhase, v5, v6, v7, v11);
		  }
		}
		
	
		// Constructors
		public HGEnvironmentVolume() {} // 0x00000001842EDFC0-0x00000001842EDFD0
		// HGTimeOfDayEnvironmentVolume()
		void HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume::HGTimeOfDayEnvironmentVolume(
		        HGTimeOfDayEnvironmentVolume *this,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::HGEnvironmentVolumeBase::HGEnvironmentVolumeBase((HGEnvironmentVolumeBase *)this, 0LL);
		}
		
	
		// Methods
		public override bool IsValid() => default; // 0x0000000183A942D0-0x0000000183A943C0
		// Boolean IsValid()
		bool HG::Rendering::Runtime::HGEnvironmentVolume::IsValid(HGEnvironmentVolume *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  Object *v3; // rbx
		  int *static_fields; // rdx
		  HGEnvironmentPhase *monitor; // rbx
		  struct Object_1__Class *v6; // rcx
		  __int64 v8; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGEnvironmentVolume__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *v11; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = (Object *)this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_16;
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) > 1465 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (int *)v2->static_fields;
		    v8 = *(_QWORD *)static_fields;
		    if ( !*(_QWORD *)static_fields )
		      goto LABEL_16;
		    if ( *(_DWORD *)(v8 + 24) <= 0x5B9u )
		      goto LABEL_33;
		    if ( *(_QWORD *)(v8 + 11752) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1465, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, v3, 0LL);
		      goto LABEL_16;
		    }
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGEnvironmentVolume *)v2->static_fields;
		  static_fields = (int *)this->klass;
		  if ( !this->klass )
		    goto LABEL_16;
		  if ( static_fields[6] <= 1463 )
		  {
		LABEL_9:
		    monitor = (HGEnvironmentPhase *)v3[5].monitor;
		    goto LABEL_10;
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGEnvironmentVolume *)v2->static_fields;
		  klass = this->klass;
		  if ( !this->klass )
		LABEL_16:
		    sub_1800D8260(this, static_fields);
		  if ( LODWORD(klass->_0.namespaze) <= 0x5B7 )
		LABEL_33:
		    sub_1800D2AB0(this, static_fields);
		  if ( !klass[24]._0.namespaze )
		    goto LABEL_9;
		  v11 = IFix::WrappersManagerImpl::GetPatch(1463, 0LL);
		  if ( !v11 )
		    goto LABEL_16;
		  monitor = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_210(v11, v3, 0LL);
		LABEL_10:
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
		  if ( !monitor )
		    return 0;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v6);
		  return monitor->fields._._.m_CachedPtr != 0LL;
		}
		
		public override HGEnvironmentPhase GetEnvPhaseForInterpolate() => default; // 0x0000000183C162C0-0x0000000183C16320
		// HGEnvironmentPhase GetEnvPhaseForInterpolate()
		HGEnvironmentPhase *HG::Rendering::Runtime::HGEnvironmentVolume::GetEnvPhaseForInterpolate(
		        HGEnvironmentVolume *this,
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
		  if ( wrapperArray->max_length.size <= 1466 )
		    return this->fields._envPhase;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x5BA )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[31]._0.typeMetadataHandle )
		    return this->fields._envPhase;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1466, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_210(Patch, (Object *)this, 0LL);
		}
		
		private void Start() {} // 0x00000001846B5230-0x00000001846B5270
		// Void Start()
		void HG::Rendering::Runtime::HGEnvironmentVolume::Start(HGEnvironmentVolume *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1467, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1467, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGEnvironmentVolume::_UpdateEnvPhaseParentId(this, 0LL);
		  }
		}
		
		private void _OnEnvPhaseChanged() {} // 0x0000000189CE3A78-0x0000000189CE3AC8
		// Void _OnEnvPhaseChanged()
		void HG::Rendering::Runtime::HGEnvironmentVolume::_OnEnvPhaseChanged(HGEnvironmentVolume *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1469, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1469, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGEnvironmentVolume::_UpdateEnvPhaseParentId(this, 0LL);
		  }
		}
		
		private void _UpdateEnvPhaseParentId() {} // 0x00000001846B5270-0x00000001846B52A0
		// Void _UpdateEnvPhaseParentId()
		void HG::Rendering::Runtime::HGEnvironmentVolume::_UpdateEnvPhaseParentId(
		        HGEnvironmentVolume *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1468, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1468, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
	}
}
