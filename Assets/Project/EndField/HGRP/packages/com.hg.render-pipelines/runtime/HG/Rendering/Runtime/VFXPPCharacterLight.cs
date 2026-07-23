using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class VFXPPCharacterLight : VFXPPComponent // TypeDefIndex: 37940
	{
		// Fields
		[SerializeField]
		private CharLightVolumeData charLightData; // 0x48
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000189B5EE88-0x0000000189B5EED8 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPCharacterLight::get_m_VFXPPType(
		        VFXPPCharacterLight *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2431, 0LL) )
		    return 10;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2431, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPCharacterLight() {} // 0x00000001844D8CB0-0x00000001844D8CC0
		// VFXPPVignette()
		void HG::Rendering::Runtime::VFXPPVignette::VFXPPVignette(VFXPPVignette *this, MethodInfo *method)
		{
		  this->fields._.m_targetEnable = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		public override void Apply(VolumeProfile volumeProfile) {} // 0x0000000189B5ECD8-0x0000000189B5EDD4
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPCharacterLight::Apply(
		        VFXPPCharacterLight *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  Object_1 *transform; // rbx
		  __int64 v6; // rdx
		  Object *v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *component; // [rsp+48h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2432, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2432, 0LL);
		    if ( !Patch )
		      goto LABEL_11;
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
		      goto LABEL_11;
		    if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
		            volumeProfile,
		            MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGCharacterVolume>) )
		      UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
		        volumeProfile,
		        0,
		        MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGCharacterVolume>);
		    if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		           volumeProfile,
		           &component,
		           MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGCharacterVolume>) )
		    {
		      if ( component )
		      {
		        LOBYTE(component[1].monitor) = 1;
		        v7 = component;
		        if ( component )
		        {
		          HG::Rendering::Runtime::HGCharacterVolume::SetCharLightVolumeData(
		            (HGCharacterVolume *)component,
		            this->fields.charLightData,
		            0LL);
		          return;
		        }
		      }
		LABEL_11:
		      sub_1800D8260(v7, v6);
		    }
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000189B5EDD4-0x0000000189B5EE88
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPCharacterLight::ResetByVolumeProfile(
		        VFXPPCharacterLight *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Object *v7; // rbx
		  CharLightVolumeData *defaultCharLightVolumeData; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *component; // [rsp+48h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2435, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
		      return;
		    if ( volumeProfile )
		    {
		      if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		              volumeProfile,
		              &component,
		              MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGCharacterVolume>) )
		        return;
		      v7 = component;
		      defaultCharLightVolumeData = HG::Rendering::Runtime::CharLightVolumeData::get_defaultCharLightVolumeData(0LL);
		      if ( v7 )
		      {
		        HG::Rendering::Runtime::HGCharacterVolume::SetCharLightVolumeData(
		          (HGCharacterVolume *)v7,
		          defaultCharLightVolumeData,
		          0LL);
		        return;
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2435, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)volumeProfile,
		    0LL);
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
		
	}
}
