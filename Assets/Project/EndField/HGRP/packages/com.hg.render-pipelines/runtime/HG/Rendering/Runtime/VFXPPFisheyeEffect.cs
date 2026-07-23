using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPFisheyeEffect(\u9C7C\u773C\u540E\u6548)")]
	[ExecuteInEditMode]
	public class VFXPPFisheyeEffect : VFXPPComponent // TypeDefIndex: 37956
	{
		// Fields
		[Range(0f, 0.5f)]
		[SerializeField]
		private float _distortion; // 0x48
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000189B612E0-0x0000000189B61330 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPFisheyeEffect::get_m_VFXPPType(
		        VFXPPFisheyeEffect *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2507, 0LL) )
		    return 15;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2507, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPFisheyeEffect() {} // 0x00000001844D8CB0-0x00000001844D8CC0
		// VFXPPVignette()
		void HG::Rendering::Runtime::VFXPPVignette::VFXPPVignette(VFXPPVignette *this, MethodInfo *method)
		{
		  this->fields._.m_targetEnable = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		public override void Apply(VolumeProfile volumeProfile) {} // 0x0000000189B60FF4-0x0000000189B61154
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPFisheyeEffect::Apply(
		        VFXPPFisheyeEffect *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  Object_1 *transform; // rbx
		  void *v6; // rdx
		  Object__Class *klass; // rcx
		  __int64 v8; // r8
		  MonitorData *monitor; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *component; // [rsp+48h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2508, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2508, 0LL);
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
		            MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGFisheyeEffect>) )
		      UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
		        volumeProfile,
		        0,
		        MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGFisheyeEffect>);
		    if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		           volumeProfile,
		           &component,
		           MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGFisheyeEffect>) )
		    {
		      if ( component )
		      {
		        LOBYTE(component[1].monitor) = 1;
		        if ( component )
		        {
		          klass = component[3].klass;
		          if ( klass )
		          {
		            LOBYTE(klass->_0.name) = 1;
		            if ( component )
		            {
		              v6 = component[3].klass;
		              if ( v6 )
		              {
		                LOBYTE(v8) = 1;
		                sub_180043DF0(11LL, v6, v8);
		                if ( component )
		                {
		                  monitor = component[3].monitor;
		                  if ( monitor )
		                  {
		                    *((_BYTE *)monitor + 16) = 1;
		                    if ( component )
		                    {
		                      v6 = component[3].monitor;
		                      if ( v6 )
		                      {
		                        sub_180049310(11LL, v6);
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
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000189B611BC-0x0000000189B612E0
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPFisheyeEffect::ResetByVolumeProfile(
		        VFXPPFisheyeEffect *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  void *v5; // rdx
		  Object__Class *klass; // rcx
		  MonitorData *monitor; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *component; // [rsp+48h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2509, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
		      return;
		    if ( volumeProfile )
		    {
		      if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		              volumeProfile,
		              &component,
		              MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGFisheyeEffect>) )
		        return;
		      if ( component )
		      {
		        LOBYTE(component[1].monitor) = 0;
		        if ( component )
		        {
		          klass = component[3].klass;
		          if ( klass )
		          {
		            LOBYTE(klass->_0.name) = 0;
		            if ( component )
		            {
		              v5 = component[3].klass;
		              if ( v5 )
		              {
		                sub_180043DF0(11LL, v5, 0LL);
		                if ( component )
		                {
		                  monitor = component[3].monitor;
		                  if ( monitor )
		                  {
		                    *((_BYTE *)monitor + 16) = 0;
		                    if ( component )
		                    {
		                      v5 = component[3].monitor;
		                      if ( v5 )
		                      {
		                        sub_180049310(11LL, v5);
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
		  Patch = IFix::WrappersManagerImpl::GetPatch(2509, 0LL);
		  if ( !Patch )
		    goto LABEL_16;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)volumeProfile,
		    0LL);
		}
		
		public override bool IsActive() => default; // 0x0000000189B61154-0x0000000189B611BC
		// Boolean IsActive()
		bool HG::Rendering::Runtime::VFXPPFisheyeEffect::IsActive(VFXPPFisheyeEffect *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2510, 0LL) )
		    return this->fields._distortion != 0.0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2510, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public VFXPPType __iFixBaseProxy_get_m_VFXPPType() => default; // 0x0000000189B5D900-0x0000000189B5D908
		// VFXPPType <>iFixBaseProxy_get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_get_m_VFXPPType(
		        VFXPPVignette *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::get_m_VFXPPType((VFXPPComponent *)this, 0LL);
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
		
		public bool __iFixBaseProxy_IsActive() => default; // 0x0000000189B5D8F0-0x0000000189B5D8F8
		// Boolean <>iFixBaseProxy_IsActive()
		bool HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_IsActive(VFXPPVignette *this, MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::IsActive((VFXPPComponent *)this, 0LL);
		}
		
	}
}
