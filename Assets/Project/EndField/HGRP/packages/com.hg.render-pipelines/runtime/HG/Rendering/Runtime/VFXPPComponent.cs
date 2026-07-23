using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class VFXPPComponent : VFXPlayableMonoBase // TypeDefIndex: 37947
	{
		// Fields
		[SerializeField]
		protected VFXPPPriority m_priority; // 0x20
		private DG.Tweening.Tween m_tween; // 0x28
		protected float m_tweenNum; // 0x30
		private bool m_targetEnable; // 0x34
		protected VFXPPData m_targetData; // 0x38
		protected VFXPPData m_snapShotData; // 0x40
	
		// Properties
		protected virtual VFXPPType m_VFXPPType { get => default; } // 0x0000000189B60A94-0x0000000189B60AE0 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPComponent::get_m_VFXPPType(VFXPPComponent *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2456, 0LL) )
		    return -1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2456, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public virtual bool ImplementedInVolume { get => default; } // 0x0000000183EAD940-0x0000000183EAD9A0 
		// Boolean get_ImplementedInVolume()
		bool HG::Rendering::Runtime::VFXPPComponent::get_ImplementedInVolume(VFXPPComponent *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 2457 )
		    return 1;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x999 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[52]._0.events )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2457, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public VFXPPPriority priority { get => default; } // 0x00000001830898A0-0x0000000183089900 
		// VFXPPPriority get_priority()
		VFXPPPriority__Enum HG::Rendering::Runtime::VFXPPComponent::get_priority(VFXPPComponent *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 2458 )
		    return this->fields.m_priority;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x99A )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[52]._0.properties )
		    return this->fields.m_priority;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2458, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPComponent() {} // 0x00000001844D8CB0-0x00000001844D8CC0
		// VFXPPVignette()
		void HG::Rendering::Runtime::VFXPPVignette::VFXPPVignette(VFXPPVignette *this, MethodInfo *method)
		{
		  this->fields._.m_targetEnable = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		protected override void OnPlay() {} // 0x0000000184369DD0-0x0000000184369E30
		// Void OnPlay()
		void HG::Rendering::Runtime::VFXPPComponent::OnPlay(VFXPPComponent *this, MethodInfo *method)
		{
		  VFXPPManager_1 *instance; // rdi
		  VFXPPType__Enum v4; // eax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2459, 0LL) )
		  {
		    instance = HG::Rendering::Runtime::VFXPPManager::get_instance(0LL);
		    v4 = (unsigned int)sub_180002F70(8LL, this);
		    if ( instance )
		    {
		      HG::Rendering::Runtime::VFXPPManager::AddActiveComponent(instance, v4, this, 0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2459, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		protected override void OnStop() {} // 0x00000001844C7FD0-0x00000001844C8030
		// Void OnStop()
		void HG::Rendering::Runtime::VFXPPComponent::OnStop(VFXPPComponent *this, MethodInfo *method)
		{
		  VFXPPManager_1 *instance; // rdi
		  VFXPPType__Enum v4; // eax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2463, 0LL) )
		  {
		    instance = HG::Rendering::Runtime::VFXPPManager::get_instance(0LL);
		    v4 = (unsigned int)sub_180002F70(8LL, this);
		    if ( instance )
		    {
		      HG::Rendering::Runtime::VFXPPManager::RemoveActiveComponent(instance, v4, this, 0LL);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2463, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private void OnDestroy() {} // 0x00000001848B3370-0x00000001848B33B0
		// Void OnDestroy()
		void HG::Rendering::Runtime::VFXPPComponent::OnDestroy(VFXPPComponent *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2467, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2467, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VFXPPComponent::_ClearTween(this, 0LL);
		  }
		}
		
		public virtual void SetData(VFXPPData data) {} // 0x0000000189B606F0-0x0000000189B60780
		// Void SetData(VFXPPData)
		void HG::Rendering::Runtime::VFXPPComponent::SetData(VFXPPComponent *this, VFXPPData *data, MethodInfo *method)
		{
		  __int64 v5; // rax
		  NotImplementedException *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  NotImplementedException *v9; // rbx
		  __int64 v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2469, 0LL) )
		  {
		    v5 = sub_18007E180(&TypeInfo::System::NotImplementedException);
		    v6 = (NotImplementedException *)sub_18002C620(v5);
		    v9 = v6;
		    if ( v6 )
		    {
		      System::NotImplementedException::NotImplementedException(v6, 0LL);
		      v10 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VFXPPComponent::SetData);
		      sub_18007E190(v9, v10);
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2469, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)data,
		    0LL);
		}
		
		public virtual VFXPPData GetData() => default; // 0x0000000189B604E0-0x0000000189B60564
		// VFXPPData GetData()
		VFXPPData *HG::Rendering::Runtime::VFXPPComponent::GetData(VFXPPComponent *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  NotImplementedException *v4; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  NotImplementedException *v7; // rbx
		  __int64 v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2470, 0LL) )
		  {
		    v3 = sub_18007E180(&TypeInfo::System::NotImplementedException);
		    v4 = (NotImplementedException *)sub_18002C620(v3);
		    v7 = v4;
		    if ( v4 )
		    {
		      System::NotImplementedException::NotImplementedException(v4, 0LL);
		      v8 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VFXPPComponent::GetData);
		      sub_18007E190(v7, v8);
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2470, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_946(Patch, (Object *)this, 0LL);
		}
		
		public virtual VFXPPData GetDefaultData() => default; // 0x0000000189B60564-0x0000000189B605E8
		// VFXPPData GetDefaultData()
		VFXPPData *HG::Rendering::Runtime::VFXPPComponent::GetDefaultData(VFXPPComponent *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  NotImplementedException *v4; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  NotImplementedException *v7; // rbx
		  __int64 v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2471, 0LL) )
		  {
		    v3 = sub_18007E180(&TypeInfo::System::NotImplementedException);
		    v4 = (NotImplementedException *)sub_18002C620(v3);
		    v7 = v4;
		    if ( v4 )
		    {
		      System::NotImplementedException::NotImplementedException(v4, 0LL);
		      v8 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VFXPPComponent::GetDefaultData);
		      sub_18007E190(v7, v8);
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2471, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_946(Patch, (Object *)this, 0LL);
		}
		
		private void _ClearTween() {} // 0x00000001848B33B0-0x00000001848B3400
		// Void _ClearTween()
		void HG::Rendering::Runtime::VFXPPComponent::_ClearTween(VFXPPComponent *this, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Tween *m_tween; // rcx
		  float v6; // r9d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2468, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2468, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_tween = this->fields.m_tween;
		    if ( m_tween )
		      DG::Tweening::TweenExtensions::Kill(m_tween, 0, 0LL);
		    this->fields.m_tween = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_tween, v3, v4, 0LL, v10);
		    this->fields.m_tweenNum = v6;
		    if ( this->fields.m_targetEnable == LOBYTE(v6) )
		      UnityEngine::Behaviour::set_enabled((Behaviour *)this, 0, 0LL);
		  }
		}
		
		public void EnableVFXPP(VFXPPData vfxPPData, float tweenTime = -1f /* Metadata: 0x02303750 */, AnimationCurve curve = null) {} // 0x0000000189B60400-0x0000000189B604E0
		// Void EnableVFXPP(VFXPPData, Single, AnimationCurve)
		void HG::Rendering::Runtime::VFXPPComponent::EnableVFXPP(
		        VFXPPComponent *this,
		        VFXPPData *vfxPPData,
		        float tweenTime,
		        AnimationCurve *curve,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-28h]
		  MethodInfo *P3a; // [rsp+20h] [rbp-28h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2472, 0LL) )
		  {
		    if ( this->fields.m_tween )
		      HG::Rendering::Runtime::VFXPPComponent::_ClearTween(this, 0LL);
		    this->fields.m_targetEnable = 1;
		    UnityEngine::Behaviour::set_enabled((Behaviour *)this, 1, 0LL);
		    this->fields.m_targetData = vfxPPData;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_targetData, v8, v9, v10, P3);
		    if ( vfxPPData )
		    {
		      this->fields.m_priority = vfxPPData->fields.priority;
		      this->fields.m_snapShotData = (VFXPPData *)sub_180056A90(11LL, this);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_snapShotData, v13, v14, v15, P3a);
		      HG::Rendering::Runtime::VFXPPComponent::_TryGenTween(this, tweenTime, curve, 0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(v12, v11);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2472, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_952(
		    Patch,
		    (Object *)this,
		    (Object *)vfxPPData,
		    tweenTime,
		    (Object *)curve,
		    0LL);
		}
		
		public void DisableVFXPP(float tweenTime = -1f /* Metadata: 0x02303754 */, AnimationCurve curve = null) {} // 0x0000000189B60310-0x0000000189B60400
		// Void DisableVFXPP(Single, AnimationCurve)
		void HG::Rendering::Runtime::VFXPPComponent::DisableVFXPP(
		        VFXPPComponent *this,
		        float tweenTime,
		        AnimationCurve *curve,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  MethodInfo *v15; // [rsp+20h] [rbp-28h]
		  MethodInfo *v16; // [rsp+20h] [rbp-28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2477, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2477, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_273(
		      (ILFixDynamicMethodWrapper_4 *)Patch,
		      (Object *)this,
		      tweenTime,
		      (Object *)curve,
		      0LL);
		  }
		  else
		  {
		    if ( this->fields.m_tween )
		      HG::Rendering::Runtime::VFXPPComponent::_ClearTween(this, 0LL);
		    if ( UnityEngine::Behaviour::get_enabled((Behaviour *)this, 0LL) )
		    {
		      if ( tweenTime <= 0.0 )
		      {
		        UnityEngine::Behaviour::set_enabled((Behaviour *)this, 0, 0LL);
		      }
		      else
		      {
		        this->fields.m_targetData = (VFXPPData *)sub_180056A90(12LL, this);
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_targetData, v6, v7, v8, v15);
		        this->fields.m_snapShotData = (VFXPPData *)sub_180056A90(11LL, this);
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_snapShotData, v9, v10, v11, v16);
		        HG::Rendering::Runtime::VFXPPComponent::_TryGenTween(this, tweenTime, curve, 0LL);
		        this->fields.m_targetEnable = 0;
		      }
		    }
		  }
		}
		
		private void _TryGenTween(float tweenTime, AnimationCurve curve = null) {} // 0x0000000189B608EC-0x0000000189B60A94
		// Void _TryGenTween(Single, AnimationCurve)
		void HG::Rendering::Runtime::VFXPPComponent::_TryGenTween(
		        VFXPPComponent *this,
		        float tweenTime,
		        AnimationCurve *curve,
		        MethodInfo *method)
		{
		  DOGetter_1_System_Single_ *v6; // rax
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  __int64 v8; // rcx
		  DOGetter_1_System_Single_ *v9; // rsi
		  UnityAction_1_System_Single_ *v10; // rax
		  DOSetter_1_System_Single_ *v11; // rbp
		  Object *v12; // rax
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  Object *m_tween; // rcx
		  Tween *v17; // rdi
		  TweenCallback *v18; // rax
		  TweenCallback *v19; // rsi
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v23; // [rsp+20h] [rbp-28h]
		  MethodInfo *v24; // [rsp+20h] [rbp-28h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2473, 0LL) )
		  {
		    HG::Rendering::Runtime::VFXPPComponent::_ClearTween(this, 0LL);
		    v6 = (DOGetter_1_System_Single_ *)sub_18002C620(TypeInfo::DG::Tweening::Core::DOGetter<float>);
		    v9 = v6;
		    if ( v6 )
		    {
		      DG::Tweening::Core::DOGetter<float>::DOGetter(
		        v6,
		        (Object *)this,
		        MethodInfo::HG::Rendering::Runtime::VFXPPComponent::_GetValue,
		        0LL);
		      v10 = (UnityAction_1_System_Single_ *)sub_18002C620(TypeInfo::DG::Tweening::Core::DOSetter<float>);
		      v11 = (DOSetter_1_System_Single_ *)v10;
		      if ( v10 )
		      {
		        UnityEngine::Events::UnityAction<float>::UnityAction(
		          v10,
		          (Object *)this,
		          MethodInfo::HG::Rendering::Runtime::VFXPPComponent::_SetValue,
		          0LL);
		        sub_1800036A0(TypeInfo::DG::Tweening::DOTween);
		        v12 = (Object *)DG::Tweening::DOTween::To(v9, v11, 1.0, tweenTime, 0LL);
		        this->fields.m_tween = (Tween *)DG::Tweening::TweenSettingsExtensions::SetUpdate<System::Object>(
		                                          v12,
		                                          UpdateType__Enum_Late,
		                                          MethodInfo::DG::Tweening::TweenSettingsExtensions::SetUpdate<DG::Tweening::Core::TweenerCore<float,float,DG::Tweening::Plugins::Options::FloatOptions>>);
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_tween, v13, v14, v15, v23);
		        m_tween = (Object *)this->fields.m_tween;
		        if ( curve )
		          DG::Tweening::TweenSettingsExtensions::SetEase<System::Object>(
		            m_tween,
		            curve,
		            MethodInfo::DG::Tweening::TweenSettingsExtensions::SetEase<DG::Tweening::Tween>);
		        else
		          DG::Tweening::TweenSettingsExtensions::SetEase<System::Object>(
		            m_tween,
		            Ease__Enum_InOutSine,
		            MethodInfo::DG::Tweening::TweenSettingsExtensions::SetEase<DG::Tweening::Tween>);
		        v17 = this->fields.m_tween;
		        v18 = (TweenCallback *)sub_18002C620(TypeInfo::DG::Tweening::TweenCallback);
		        v19 = v18;
		        if ( v18 )
		        {
		          DG::Tweening::TweenCallback::TweenCallback(
		            v18,
		            (Object *)this,
		            MethodInfo::HG::Rendering::Runtime::VFXPPComponent::_ClearTween,
		            0LL);
		          if ( v17 )
		          {
		            v17->fields.onComplete = v19;
		            sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v17->fields.onComplete, v7, v20, v21, v24);
		            DG::Tweening::TweenSettingsExtensions::SetAutoKill<System::Object>(
		              (Object *)this->fields.m_tween,
		              MethodInfo::DG::Tweening::TweenSettingsExtensions::SetAutoKill<DG::Tweening::Tween>);
		            return;
		          }
		        }
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2473, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_273(
		    (ILFixDynamicMethodWrapper_4 *)Patch,
		    (Object *)this,
		    tweenTime,
		    (Object *)curve,
		    0LL);
		}
		
		protected float _GetValue() => default; // 0x0000000189B60814-0x0000000189B60864
		// Single _GetValue()
		float HG::Rendering::Runtime::VFXPPComponent::_GetValue(VFXPPComponent *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2474, 0LL) )
		    return this->fields.m_tweenNum;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2474, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		
		protected virtual VFXPPData _GetLerpData(float value) => default; // 0x0000000189B60780-0x0000000189B60814
		// VFXPPData _GetLerpData(Single)
		VFXPPData *HG::Rendering::Runtime::VFXPPComponent::_GetLerpData(VFXPPComponent *this, float value, MethodInfo *method)
		{
		  __int64 v4; // rax
		  NotImplementedException *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  NotImplementedException *v8; // rbx
		  __int64 v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2476, 0LL) )
		  {
		    v4 = sub_18007E180(&TypeInfo::System::NotImplementedException);
		    v5 = (NotImplementedException *)sub_18002C620(v4);
		    v8 = v5;
		    if ( v5 )
		    {
		      System::NotImplementedException::NotImplementedException(v5, 0LL);
		      v9 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::VFXPPComponent::_GetLerpData);
		      sub_18007E190(v8, v9);
		    }
		LABEL_5:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2476, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_947(Patch, (Object *)this, value, 0LL);
		}
		
		protected void _SetValue(float value) {} // 0x0000000189B60864-0x0000000189B608EC
		// Void _SetValue(Single)
		void HG::Rendering::Runtime::VFXPPComponent::_SetValue(VFXPPComponent *this, float value, MethodInfo *method)
		{
		  VFXPPComponent__Class *klass; // rcx
		  __int64 v5; // rdx
		  __int64 v6; // rax
		  __int64 v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2475, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2475, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    klass = this->klass;
		    this->fields.m_tweenNum = value;
		    sub_1800049A0(klass);
		    v6 = ((__int64 (__fastcall *)(VFXPPComponent *, __int64, Il2CppMethodPointer))this->klass->vtable._GetLerpData.method)(
		           this,
		           v5,
		           this->klass->vtable.Apply.methodPtr);
		    sub_180085A50(v7, this, v6);
		  }
		}
		
		public void SetAsDefault() {} // 0x0000000189B60690-0x0000000189B606F0
		// Void SetAsDefault()
		void HG::Rendering::Runtime::VFXPPComponent::SetAsDefault(VFXPPComponent *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  __int64 v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2478, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2478, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = sub_180056A90(12LL, this);
		    sub_180085A50(v4, this, v3);
		  }
		}
		
		public virtual void Apply(VolumeProfile volumeProfile) {} // 0x0000000189B602BC-0x0000000189B60310
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPComponent::Apply(
		        VFXPPComponent *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2479, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2479, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)volumeProfile,
		      0LL);
		  }
		}
		
		public virtual void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000189B605E8-0x0000000189B6063C
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPComponent::ResetByVolumeProfile(
		        VFXPPComponent *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2465, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2465, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)volumeProfile,
		      0LL);
		  }
		}
		
		public virtual void ApplyEnvPhase(HGEnvironmentPhase envPhase) {} // 0x0000000189B60268-0x0000000189B602BC
		// Void ApplyEnvPhase(HGEnvironmentPhase)
		void HG::Rendering::Runtime::VFXPPComponent::ApplyEnvPhase(
		        VFXPPComponent *this,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2480, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2480, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)envPhase,
		      0LL);
		  }
		}
		
		public virtual void ResetEnvPhase(HGEnvironmentPhase envPhase) {} // 0x0000000189B6063C-0x0000000189B60690
		// Void ResetEnvPhase(HGEnvironmentPhase)
		void HG::Rendering::Runtime::VFXPPComponent::ResetEnvPhase(
		        VFXPPComponent *this,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2466, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2466, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)envPhase,
		      0LL);
		  }
		}
		
		public virtual bool IsActive() => default; // 0x000000018443E570-0x000000018443E5A0
		// Boolean IsActive()
		bool HG::Rendering::Runtime::VFXPPComponent::IsActive(VFXPPComponent *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2481, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2481, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public void __iFixBaseProxy_OnPlay() {} // 0x000000018745BF58-0x000000018745BF60
		// Void <>iFixBaseProxy_OnPlay()
		void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnPlay(VFXSceneDark *this, MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay((VFXPlayableMonoBase *)this, 0LL);
		}
		
		public void __iFixBaseProxy_OnStop() {} // 0x0000000186FE0B3C-0x0000000186FE0B44
		// Void <>iFixBaseProxy_OnStop()
		void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnStop(VFXSceneDark *this, MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPlayableMonoBase::OnStop((VFXPlayableMonoBase *)this, 0LL);
		}
		
	}
}
