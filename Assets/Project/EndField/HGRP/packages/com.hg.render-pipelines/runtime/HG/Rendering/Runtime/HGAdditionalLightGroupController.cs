using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteAlways]
	public class HGAdditionalLightGroupController : MonoBehaviour // TypeDefIndex: 38676
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private List<Light> m_LightList; // 0x18
		[HideInInspector]
		[SerializeField]
		private List<LightInfo> m_LightInfoList; // 0x20
		private float m_curLightGroupAlpha; // 0x28
		protected DG.Tweening.Tween m_alphaTween; // 0x30
	
		// Nested types
		[Serializable]
		private struct LightInfo // TypeDefIndex: 38674
		{
			// Fields
			public float intensity; // 0x00
			public float fogAlpha; // 0x04
			public HGAdditionalLightData lightData; // 0x08
		}
	
		// Constructors
		public HGAdditionalLightGroupController() {} // 0x0000000189C1DFEC-0x0000000189C1E074
		// HGAdditionalLightGroupController()
		void HG::Rendering::Runtime::HGAdditionalLightGroupController::HGAdditionalLightGroupController(
		        HGAdditionalLightGroupController *this,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  List_1_UnityEngine_Light_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v10; // rax
		  List_1_HG_Rendering_Runtime_HGAdditionalLightGroupController_LightInfo_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		
		  v3 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Light>);
		  v6 = (List_1_UnityEngine_Light_ *)v3;
		  if ( !v3
		    || (System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		          v3,
		          MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::List),
		        this->fields.m_LightList = v6,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_LightList, v7, v8, v9, v15),
		        v10 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>),
		        (v11 = (List_1_HG_Rendering_Runtime_HGAdditionalLightGroupController_LightInfo_ *)v10) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::List);
		  this->fields.m_LightInfoList = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_LightInfoList, v12, v13, v14, v16);
		  RootMotion::Singleton<System::Object>::Singleton((Singleton_1_System_Object__1 *)this, 0LL);
		}
		
	
		// Methods
		private void OnEnable() {} // 0x0000000189C1DA34-0x0000000189C1DA84
		// Void OnEnable()
		void HG::Rendering::Runtime::HGAdditionalLightGroupController::OnEnable(
		        HGAdditionalLightGroupController *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4083, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4083, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGAdditionalLightGroupController::CollectLights(this, 0LL);
		  }
		}
		
		private void OnDisable() {} // 0x0000000189C1D9D4-0x0000000189C1DA34
		// Void OnDisable()
		void HG::Rendering::Runtime::HGAdditionalLightGroupController::OnDisable(
		        HGAdditionalLightGroupController *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4090, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4090, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( UnityEngine::Application::get_isPlaying(0LL) )
		  {
		    HG::Rendering::Runtime::HGAdditionalLightGroupController::ResetLights(this, 0LL);
		  }
		}
		
		public void SetLightGroupAlpha(float lightAlpha) {} // 0x0000000189C1DAE8-0x0000000189C1DB5C
		// Void SetLightGroupAlpha(Single)
		void HG::Rendering::Runtime::HGAdditionalLightGroupController::SetLightGroupAlpha(
		        HGAdditionalLightGroupController *this,
		        float lightAlpha,
		        MethodInfo *method)
		{
		  Beyond::JobMathf *v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4091, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4091, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
		      (ILFixDynamicMethodWrapper_18 *)Patch,
		      (Object *)this,
		      lightAlpha,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGAdditionalLightGroupController::_ClearTween(this, 0LL);
		    Beyond::JobMathf::Clamp01(v4, lightAlpha);
		    HG::Rendering::Runtime::HGAdditionalLightGroupController::SetLightProps(this, lightAlpha, 0LL);
		  }
		}
		
		public void TweenLightGroupAlpha(float fromLightAlpha, float toLightAlpha, float tweenDuration = 0.5f /* Metadata: 0x02304085 */) {} // 0x0000000189C1DD70-0x0000000189C1DF80
		// Void TweenLightGroupAlpha(Single, Single, Single)
		void HG::Rendering::Runtime::HGAdditionalLightGroupController::TweenLightGroupAlpha(
		        HGAdditionalLightGroupController *this,
		        float fromLightAlpha,
		        float toLightAlpha,
		        float tweenDuration,
		        MethodInfo *method)
		{
		  __int64 v6; // rax
		  Type *v7; // rdx
		  __int64 v8; // rcx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rbx
		  Beyond::JobMathf *v12; // rcx
		  DOGetter_1_System_Single_ *v13; // rax
		  DOGetter_1_System_Single_ *v14; // rbp
		  UnityAction_1_System_Single_ *v15; // rax
		  DOSetter_1_System_Single_ *v16; // rsi
		  float v17; // xmm6_4
		  Object *v18; // rbp
		  TweenCallback *v19; // rax
		  TweenCallback *v20; // rsi
		  Object *v21; // rbp
		  TweenCallback *v22; // rax
		  TweenCallback *v23; // rsi
		  Type *v24; // rdx
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-48h]
		  MethodInfo *P3a; // [rsp+20h] [rbp-48h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4092, 0LL) )
		  {
		    v6 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0);
		    v11 = v6;
		    if ( v6 )
		    {
		      *(_QWORD *)(v6 + 16) = this;
		      sub_18002D1B0((SingleFieldAccessor *)(v6 + 16), v7, v9, v10, P3);
		      *(float *)(v11 + 24) = toLightAlpha;
		      Beyond::JobMathf::Clamp01(v12, fromLightAlpha);
		      HG::Rendering::Runtime::HGAdditionalLightGroupController::SetLightProps(this, fromLightAlpha, 0LL);
		      this->fields.m_curLightGroupAlpha = fromLightAlpha;
		      HG::Rendering::Runtime::HGAdditionalLightGroupController::_ClearTween(this, 0LL);
		      v13 = (DOGetter_1_System_Single_ *)sub_18002C620(TypeInfo::DG::Tweening::Core::DOGetter<float>);
		      v14 = v13;
		      if ( v13 )
		      {
		        DG::Tweening::Core::DOGetter<float>::DOGetter(
		          v13,
		          (Object *)v11,
		          MethodInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0::_TweenLightGroupAlpha_b__0,
		          0LL);
		        v15 = (UnityAction_1_System_Single_ *)sub_18002C620(TypeInfo::DG::Tweening::Core::DOSetter<float>);
		        v16 = (DOSetter_1_System_Single_ *)v15;
		        if ( v15 )
		        {
		          UnityEngine::Events::UnityAction<float>::UnityAction(
		            v15,
		            (Object *)v11,
		            MethodInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0::_TweenLightGroupAlpha_b__1,
		            0LL);
		          v17 = *(float *)(v11 + 24);
		          sub_1800036A0(TypeInfo::DG::Tweening::DOTween);
		          v18 = (Object *)DG::Tweening::DOTween::To(v14, v16, v17, tweenDuration, 0LL);
		          v19 = (TweenCallback *)sub_18002C620(TypeInfo::DG::Tweening::TweenCallback);
		          v20 = v19;
		          if ( v19 )
		          {
		            DG::Tweening::TweenCallback::TweenCallback(
		              v19,
		              (Object *)v11,
		              MethodInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0::_TweenLightGroupAlpha_b__2,
		              0LL);
		            v21 = DG::Tweening::TweenSettingsExtensions::OnUpdate<System::Object>(
		                    v18,
		                    v20,
		                    MethodInfo::DG::Tweening::TweenSettingsExtensions::OnUpdate<DG::Tweening::Core::TweenerCore<float,float,DG::Tweening::Plugins::Options::FloatOptions>>);
		            v22 = (TweenCallback *)sub_18002C620(TypeInfo::DG::Tweening::TweenCallback);
		            v23 = v22;
		            if ( v22 )
		            {
		              DG::Tweening::TweenCallback::TweenCallback(
		                v22,
		                (Object *)v11,
		                MethodInfo::HG::Rendering::Runtime::HGAdditionalLightGroupController::__c__DisplayClass8_0::_TweenLightGroupAlpha_b__3,
		                0LL);
		              this->fields.m_alphaTween = (Tween *)DG::Tweening::TweenSettingsExtensions::OnComplete<System::Object>(
		                                                     v21,
		                                                     v23,
		                                                     MethodInfo::DG::Tweening::TweenSettingsExtensions::OnComplete<DG::Tweening::Core::TweenerCore<float,float,DG::Tweening::Plugins::Options::FloatOptions>>);
		              sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_alphaTween, v24, v25, v26, P3a);
		              DG::Tweening::TweenExtensions::Play<System::Object>(
		                (Object *)this->fields.m_alphaTween,
		                MethodInfo::DG::Tweening::TweenExtensions::Play<DG::Tweening::Tween>);
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4092, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_286(
		    (ILFixDynamicMethodWrapper_6 *)Patch,
		    (Object *)this,
		    fromLightAlpha,
		    toLightAlpha,
		    tweenDuration,
		    0LL);
		}
		
		public void CollectLights() {} // 0x0000000189C1D790-0x0000000189C1D934
		// Void CollectLights()
		void HG::Rendering::Runtime::HGAdditionalLightGroupController::CollectLights(
		        HGAdditionalLightGroupController *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_System_Object_ *m_LightList; // rcx
		  Object__Array *v5; // rbp
		  int32_t v6; // esi
		  Object *v7; // rbx
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  Object_1 *v11; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object_1 *x[2]; // [rsp+20h] [rbp-28h] BYREF
		  prXDGPaiLRznhHdqRYUShDUjqIyH_PUUjROsMtnhbqLEaBbcdiryfdlYVA v14; // [rsp+30h] [rbp-18h] BYREF
		
		  *(_OWORD *)x = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(4084, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4084, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_19:
		    sub_1800D8260(m_LightList, v3);
		  }
		  if ( HG::Rendering::Runtime::HGAdditionalLightGroupController::LerpState(this, 0LL) )
		    HG::Rendering::Runtime::HGAdditionalLightGroupController::ResetLights(this, 0LL);
		  HG::Rendering::Runtime::HGAdditionalLightGroupController::ClearLightInfo(this, 0LL);
		  v5 = UnityEngine::Component::GetComponentsInChildren<System::Object>(
		         (Component *)this,
		         MethodInfo::UnityEngine::Component::GetComponentsInChildren<UnityEngine::Light>);
		  v6 = 0;
		  if ( !v5 )
		    goto LABEL_19;
		  while ( v6 < v5->max_length.size )
		  {
		    if ( (unsigned int)v6 >= v5->max_length.size )
		      sub_1800D2AB0(m_LightList, v3);
		    v7 = v5->vector[v6];
		    if ( !v7 )
		      goto LABEL_19;
		    if ( UnityEngine::Light::get_type((Light *)v5->vector[v6], 0LL) == LightType__Enum_Point
		      || UnityEngine::Light::get_type((Light *)v7, 0LL) == LightType__Enum_Spot )
		    {
		      m_LightList = (List_1_System_Object_ *)this->fields.m_LightList;
		      if ( !m_LightList )
		        goto LABEL_19;
		      sub_182F01190(m_LightList, v7);
		      x[0] = (Object_1 *)COERCE_UNSIGNED_INT(UnityEngine::Light::get_intensity((Light *)v7, 0LL));
		      x[1] = (Object_1 *)UnityEngine::Component::GetComponent<System::Object>(
		                           (Component *)v7,
		                           MethodInfo::UnityEngine::Component::GetComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
		      sub_18002D1B0((SingleFieldAccessor *)&x[1], v8, v9, v10, (MethodInfo *)x[0]);
		      v11 = x[1];
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(v11, 0LL, 0LL) )
		      {
		        m_LightList = (List_1_System_Object_ *)x[1];
		        if ( !x[1] )
		          goto LABEL_19;
		        HIDWORD(x[0]) = HG::Rendering::Runtime::HGAdditionalLightData::get_LightNPRFogAlpha(
		                          (HGAdditionalLightData *)x[1],
		                          0LL);
		      }
		      m_LightList = (List_1_System_Object_ *)this->fields.m_LightInfoList;
		      if ( !m_LightList )
		        goto LABEL_19;
		      v14 = *(prXDGPaiLRznhHdqRYUShDUjqIyH_PUUjROsMtnhbqLEaBbcdiryfdlYVA *)x;
		      System::Collections::Generic::List<prXDGPaiLRznhHdqRYUShDUjqIyH::PUUjROsMtnhbqLEaBbcdiryfdlYVA>::Add(
		        (List_1_prXDGPaiLRznhHdqRYUShDUjqIyH_PUUjROsMtnhbqLEaBbcdiryfdlYVA_ *)m_LightList,
		        &v14,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::Add);
		    }
		    ++v6;
		  }
		}
		
		public bool LerpState() => default; // 0x0000000189C1D934-0x0000000189C1D9D4
		// Boolean LerpState()
		bool HG::Rendering::Runtime::HGAdditionalLightGroupController::LerpState(
		        HGAdditionalLightGroupController *this,
		        MethodInfo *method)
		{
		  __int32 v3; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4085, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4085, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    COERCE_FLOAT(v3 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		    return fmaxf(
		             fmaxf(COERCE_FLOAT(LODWORD(this->fields.m_curLightGroupAlpha) & v3), COERCE_FLOAT(v3 & 0x3F800000))
		           * 0.000001,
		             TypeInfo::UnityEngine::Mathf->static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(
		                                                                                           1.0
		                                                                                         - this->fields.m_curLightGroupAlpha) & v3);
		  }
		}
		
		private void SetLightProps(float lightAlpha) {} // 0x0000000189C1DB5C-0x0000000189C1DD70
		// Void SetLightProps(Single)
		void HG::Rendering::Runtime::HGAdditionalLightGroupController::SetLightProps(
		        HGAdditionalLightGroupController *this,
		        float lightAlpha,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *v4; // rdx
		  List_1_System_Object_ *size; // rcx
		  List_1_UnityEngine_Light_ *m_LightList; // rax
		  List_1_HG_Rendering_Runtime_HGAdditionalLightGroupController_LightInfo_ *m_LightInfoList; // rax
		  int32_t i; // esi
		  List_1_UnityEngine_Light_ *v9; // rax
		  Object *Item; // rbx
		  __m128i v11; // xmm6
		  Object *v12; // rax
		  Light *v13; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128i v15; // [rsp+20h] [rbp-68h] BYREF
		  RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry v16; // [rsp+30h] [rbp-58h] BYREF
		  RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry v17; // [rsp+40h] [rbp-48h] BYREF
		  RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry v18; // [rsp+50h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4088, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4088, 0LL);
		    if ( !Patch )
		      goto LABEL_21;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15(
		      (ILFixDynamicMethodWrapper_18 *)Patch,
		      (Object *)this,
		      lightAlpha,
		      0LL);
		  }
		  else
		  {
		    m_LightList = this->fields.m_LightList;
		    if ( !m_LightList )
		      goto LABEL_21;
		    size = (List_1_System_Object_ *)(unsigned int)m_LightList->fields._size;
		    m_LightInfoList = this->fields.m_LightInfoList;
		    if ( !m_LightInfoList )
		      goto LABEL_21;
		    if ( (_DWORD)size == m_LightInfoList->fields._size )
		    {
		      for ( i = 0; ; ++i )
		      {
		        v9 = this->fields.m_LightList;
		        if ( !v9 )
		          break;
		        if ( i >= v9->fields._size )
		          return;
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 (List_1_System_Object_ *)this->fields.m_LightList,
		                 i,
		                 MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::get_Item);
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Inequality((Object_1 *)Item, 0LL, 0LL) )
		        {
		          v4 = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)this->fields.m_LightInfoList;
		          if ( !v4 )
		            break;
		          System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		            (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry *)&v15,
		            v4,
		            i,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::get_Item);
		          v11 = v15;
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Inequality((Object_1 *)_mm_srli_si128(v11, 8).m128i_i64[0], 0LL, 0LL) )
		          {
		            v4 = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)this->fields.m_LightInfoList;
		            if ( !v4 )
		              break;
		            System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		              &v17,
		              v4,
		              i,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::get_Item);
		            v4 = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)this->fields.m_LightInfoList;
		            if ( !v4 )
		              break;
		            System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		              &v16,
		              v4,
		              i,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::get_Item);
		            size = *(List_1_System_Object_ **)&v17.freeBusCount;
		            if ( !*(_QWORD *)&v17.freeBusCount )
		              break;
		            HG::Rendering::Runtime::HGAdditionalLightData::set_LightNPRFogAlpha(
		              *(HGAdditionalLightData **)&v17.freeBusCount,
		              *((float *)&v16.coreZone + 1) * lightAlpha,
		              0LL);
		            size = (List_1_System_Object_ *)this->fields.m_LightList;
		            if ( !size )
		              break;
		            v12 = System::Collections::Generic::List<System::Object>::get_Item(
		                    size,
		                    i,
		                    MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::get_Item);
		            v4 = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)this->fields.m_LightInfoList;
		            v13 = (Light *)v12;
		            if ( !v4 )
		              break;
		            System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		              &v18,
		              v4,
		              i,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::get_Item);
		            if ( !v13 )
		              break;
		            UnityEngine::Light::set_intensity(v13, *(float *)&v18.coreZone * lightAlpha, 0LL);
		          }
		        }
		      }
		LABEL_21:
		      sub_1800D8260(size, v4);
		    }
		    sub_1800036A0(TypeInfo::UnityEngine::Debug);
		    UnityEngine::Debug::LogError((Object *)"Counts of Light list and light info list are different!", 0LL);
		  }
		}
		
		private void _ClearTween() {} // 0x0000000189C1DF80-0x0000000189C1DFEC
		// Void _ClearTween()
		void HG::Rendering::Runtime::HGAdditionalLightGroupController::_ClearTween(
		        HGAdditionalLightGroupController *this,
		        MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  Tween *m_alphaTween; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4087, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4087, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_alphaTween = this->fields.m_alphaTween;
		    if ( m_alphaTween )
		      DG::Tweening::TweenExtensions::Kill(m_alphaTween, 0, 0LL);
		    this->fields.m_alphaTween = 0LL;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_alphaTween, v3, v4, v5, v10);
		  }
		}
		
		private void ResetLights() {} // 0x0000000189C1DA84-0x0000000189C1DAE8
		// Void ResetLights()
		void HG::Rendering::Runtime::HGAdditionalLightGroupController::ResetLights(
		        HGAdditionalLightGroupController *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4086, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4086, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGAdditionalLightGroupController::_ClearTween(this, 0LL);
		    HG::Rendering::Runtime::HGAdditionalLightGroupController::SetLightProps(this, 1.0, 0LL);
		  }
		}
		
		private void ClearLightInfo() {} // 0x0000000189C1D714-0x0000000189C1D790
		// Void ClearLightInfo()
		void HG::Rendering::Runtime::HGAdditionalLightGroupController::ClearLightInfo(
		        HGAdditionalLightGroupController *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *m_LightList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4089, 0LL) )
		  {
		    HG::Rendering::Runtime::HGAdditionalLightGroupController::_ClearTween(this, 0LL);
		    m_LightList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields.m_LightList;
		    if ( m_LightList )
		    {
		      sub_183127A90(m_LightList, MethodInfo::System::Collections::Generic::List<UnityEngine::Light>::Clear);
		      m_LightList = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields.m_LightInfoList;
		      if ( m_LightList )
		      {
		        System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		          m_LightList,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGAdditionalLightGroupController::LightInfo>::Clear);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(m_LightList, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4089, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
