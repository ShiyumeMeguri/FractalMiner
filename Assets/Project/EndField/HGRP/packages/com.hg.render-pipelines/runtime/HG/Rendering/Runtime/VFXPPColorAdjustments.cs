using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPColorAdjustments(\u540E\u5904\u7406\u8C03\u8272)")]
	[ExecuteInEditMode]
	public class VFXPPColorAdjustments : VFXPPComponent // TypeDefIndex: 37944
	{
		// Fields
		[Range(-100f, 100f)]
		[SerializeField]
		private float _saturation; // 0x48
		[ColorUsage(true, true)]
		[SerializeField]
		private UnityEngine.Color _color; // 0x4C
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000189B60218-0x0000000189B60268 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPColorAdjustments::get_m_VFXPPType(
		        VFXPPColorAdjustments *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2449, 0LL) )
		    return 3;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2449, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public override bool ImplementedInVolume { get => default; } // 0x0000000189B601CC-0x0000000189B60218 
		// Boolean get_ImplementedInVolume()
		bool HG::Rendering::Runtime::VFXPPColorAdjustments::get_ImplementedInVolume(
		        VFXPPColorAdjustments *this,
		        MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(2450, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2450, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  return result;
		}
		
	
		// Constructors
		public VFXPPColorAdjustments() {} // 0x0000000189B601A0-0x0000000189B601CC
		// VFXPPColorAdjustments()
		void HG::Rendering::Runtime::VFXPPColorAdjustments::VFXPPColorAdjustments(
		        VFXPPColorAdjustments *this,
		        MethodInfo *method)
		{
		  Vector4 v2; // xmm1
		  __int64 v3; // r8
		  Vector4 v4; // [rsp+20h] [rbp-18h] BYREF
		
		  v2 = *UnityEngine::Vector4::get_one(&v4, method);
		  *(_BYTE *)(v3 + 52) = 1;
		  *(Vector4 *)(v3 + 76) = v2;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)v3, 0LL);
		}
		
	
		// Methods
		public override void Apply(VolumeProfile volumeProfile) {} // 0x0000000189B5FDAC-0x0000000189B5FF18
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPColorAdjustments::Apply(
		        VFXPPColorAdjustments *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  Object_1 *transform; // rbx
		  Object__Class *v6; // rdx
		  Object__Class *klass; // rcx
		  Object__Class *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Color color; // [rsp+20h] [rbp-18h] BYREF
		  Object *component; // [rsp+58h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2451, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2451, 0LL);
		    if ( !Patch )
		      goto LABEL_18;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)volumeProfile,
		      0LL);
		  }
		  else
		  {
		    transform = (Object_1 *)UnityEngine::Component::get_transform((Component *)this, 0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(transform, 0LL, 0LL) )
		      return;
		    if ( !volumeProfile )
		      goto LABEL_18;
		    if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
		            volumeProfile,
		            MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::ColorAdjustments>) )
		      UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
		        volumeProfile,
		        0,
		        MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::ColorAdjustments>);
		    if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		           volumeProfile,
		           &component,
		           MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::ColorAdjustments>) )
		    {
		      if ( component )
		      {
		        LOBYTE(component[1].monitor) = 1;
		        if ( component )
		        {
		          klass = component[5].klass;
		          if ( klass )
		          {
		            LOBYTE(klass->_0.name) = 1;
		            if ( component )
		            {
		              v6 = component[5].klass;
		              if ( v6 )
		              {
		                sub_180049310(11LL, v6);
		                if ( component )
		                {
		                  v8 = component[4].klass;
		                  if ( v8 )
		                  {
		                    LOBYTE(v8->_0.name) = 1;
		                    if ( component )
		                    {
		                      v6 = component[4].klass;
		                      if ( v6 )
		                      {
		                        color = this->fields._color;
		                        sub_1800386F0(11LL, v6, &color);
		                        return;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		LABEL_18:
		      sub_1800D8260(klass, v6);
		    }
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000189B5FFA8-0x0000000189B600EC
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPColorAdjustments::ResetByVolumeProfile(
		        VFXPPColorAdjustments *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  Object__Class *v5; // rdx
		  Object__Class *klass; // rcx
		  Object__Class *v7; // rax
		  Vector4 *one; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v10; // [rsp+20h] [rbp-18h] BYREF
		  Object *component; // [rsp+58h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2452, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
		      return;
		    if ( volumeProfile )
		    {
		      if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		              volumeProfile,
		              &component,
		              MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::ColorAdjustments>) )
		        return;
		      if ( component )
		      {
		        LOBYTE(component[1].monitor) = 0;
		        if ( component )
		        {
		          klass = component[5].klass;
		          if ( klass )
		          {
		            LOBYTE(klass->_0.name) = 0;
		            if ( component )
		            {
		              v5 = component[5].klass;
		              if ( v5 )
		              {
		                sub_180049310(11LL, v5);
		                if ( component )
		                {
		                  v7 = component[4].klass;
		                  if ( v7 )
		                  {
		                    LOBYTE(v7->_0.name) = 0;
		                    if ( component )
		                    {
		                      one = UnityEngine::Vector4::get_one(&v10, (MethodInfo *)component[4].klass);
		                      if ( v5 )
		                      {
		                        v10 = *one;
		                        sub_1800386F0(11LL, v5, &v10);
		                        return;
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_16:
		    sub_1800D8260(klass, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2452, 0LL);
		  if ( !Patch )
		    goto LABEL_16;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)volumeProfile,
		    0LL);
		}
		
		public override void ApplyEnvPhase(HGEnvironmentPhase envPhase) {} // 0x0000000189B5FCE4-0x0000000189B5FDAC
		// Void ApplyEnvPhase(HGEnvironmentPhase)
		void HG::Rendering::Runtime::VFXPPColorAdjustments::ApplyEnvPhase(
		        VFXPPColorAdjustments *this,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  Object_1 *transform; // rbx
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2453, 0LL) )
		  {
		    transform = (Object_1 *)UnityEngine::Component::get_transform((Component *)this, 0LL);
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(transform, 0LL, 0LL) )
		      return;
		    if ( envPhase )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		      HG::Rendering::Runtime::HGColorGradingConfig::set_active(&envPhase->fields.colorGradingConfig, 1, 0LL);
		      envPhase->fields.colorGradingConfig.colorAdjustmentsEnabled = 1;
		      envPhase->fields.colorGradingConfig.colorAdjustmentsSaturation = this->fields._saturation;
		      envPhase->fields.colorGradingConfig.colorAdjustmentsColorFilter = (Color)_mm_loadu_si128((const __m128i *)&this->fields._color);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2453, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)envPhase,
		    0LL);
		}
		
		public override void ResetEnvPhase(HGEnvironmentPhase envPhase) {} // 0x0000000189B600EC-0x0000000189B60188
		// Void ResetEnvPhase(HGEnvironmentPhase)
		void HG::Rendering::Runtime::VFXPPColorAdjustments::ResetEnvPhase(
		        VFXPPColorAdjustments *this,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  MethodInfo *v7; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v9; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2454, 0LL) )
		  {
		    if ( envPhase )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		      HG::Rendering::Runtime::HGColorGradingConfig::set_active(&envPhase->fields.colorGradingConfig, 0, 0LL);
		      envPhase->fields.colorGradingConfig.colorAdjustmentsEnabled = 0;
		      envPhase->fields.colorGradingConfig.colorAdjustmentsSaturation = 0.0;
		      envPhase->fields.colorGradingConfig.colorAdjustmentsColorFilter = (Color)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v9, v7));
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2454, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)envPhase,
		    0LL);
		}
		
		public override bool IsActive() => default; // 0x0000000189B5FF18-0x0000000189B5FFA8
		// Boolean IsActive()
		bool HG::Rendering::Runtime::VFXPPColorAdjustments::IsActive(VFXPPColorAdjustments *this, MethodInfo *method)
		{
		  MethodInfo *v3; // rdx
		  Vector4 v4; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Color color; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2455, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2455, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields._saturation == 0.0 )
		  {
		    v4 = *UnityEngine::Vector4::get_one((Vector4 *)&color, v3);
		    color = this->fields._color;
		    v9 = v4;
		    return sub_182FA61B0(&color, &v9) ^ 1;
		  }
		  else
		  {
		    return 1;
		  }
		}
		
		public VFXPPType __iFixBaseProxy_get_m_VFXPPType() => default; // 0x0000000189B5D900-0x0000000189B5D908
		// VFXPPType <>iFixBaseProxy_get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_get_m_VFXPPType(
		        VFXPPVignette *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::get_m_VFXPPType((VFXPPComponent *)this, 0LL);
		}
		
		public bool __iFixBaseProxy_get_ImplementedInVolume() => default; // 0x0000000189B60198-0x0000000189B601A0
		// Boolean <>iFixBaseProxy_get_ImplementedInVolume()
		bool HG::Rendering::Runtime::VFXPPInkWash::__iFixBaseProxy_get_ImplementedInVolume(
		        VFXPPInkWash *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::get_ImplementedInVolume((VFXPPComponent *)this, 0LL);
		}
		
		public void __iFixBaseProxy_Apply(VolumeProfile P0) {} // 0x0000000189B5D8E8-0x0000000189B5D8F0
		// Void <>iFixBaseProxy_Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_Apply(
		        VFXPPVignette *this,
		        VolumeProfile *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::Apply((VFXPPComponent *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_ResetByVolumeProfile(VolumeProfile P0) {} // 0x0000000189B5D8F8-0x0000000189B5D900
		// Void <>iFixBaseProxy_ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_ResetByVolumeProfile(
		        VFXPPVignette *this,
		        VolumeProfile *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::ResetByVolumeProfile((VFXPPComponent *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_ApplyEnvPhase(HGEnvironmentPhase P0) {} // 0x0000000189B60188-0x0000000189B60190
		// Void <>iFixBaseProxy_ApplyEnvPhase(HGEnvironmentPhase)
		void HG::Rendering::Runtime::VFXPPInkWash::__iFixBaseProxy_ApplyEnvPhase(
		        VFXPPInkWash *this,
		        HGEnvironmentPhase *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::ApplyEnvPhase((VFXPPComponent *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_ResetEnvPhase(HGEnvironmentPhase P0) {} // 0x0000000189B60190-0x0000000189B60198
		// Void <>iFixBaseProxy_ResetEnvPhase(HGEnvironmentPhase)
		void HG::Rendering::Runtime::VFXPPInkWash::__iFixBaseProxy_ResetEnvPhase(
		        VFXPPInkWash *this,
		        HGEnvironmentPhase *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::ResetEnvPhase((VFXPPComponent *)this, P0, 0LL);
		}
		
		public bool __iFixBaseProxy_IsActive() => default; // 0x0000000189B5D8F0-0x0000000189B5D8F8
		// Boolean <>iFixBaseProxy_IsActive()
		bool HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_IsActive(VFXPPVignette *this, MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::IsActive((VFXPPComponent *)this, 0LL);
		}
		
	}
}
