using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPCharacterBloom(\u89D2\u8272\u67D4\u5149)")]
	[ExecuteInEditMode]
	public class VFXPPCharacterBloom : VFXPPComponent // TypeDefIndex: 37938
	{
		// Fields
		[SerializeField]
		private bool m_CharacterBloomEnabled; // 0x48
		[SerializeField]
		private float m_CharacterBloomThreshold; // 0x4C
		[Range(0f, 10f)]
		[SerializeField]
		private float m_CharacterBloomIntensity; // 0x50
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000189B5EC88-0x0000000189B5ECD8 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPCharacterBloom::get_m_VFXPPType(
		        VFXPPCharacterBloom *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2425, 0LL) )
		    return 14;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2425, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPCharacterBloom() {} // 0x0000000189B5EC68-0x0000000189B5EC88
		// VFXPPCharacterBloom()
		void HG::Rendering::Runtime::VFXPPCharacterBloom::VFXPPCharacterBloom(VFXPPCharacterBloom *this, MethodInfo *method)
		{
		  this->fields.m_CharacterBloomEnabled = 1;
		  this->fields.m_CharacterBloomThreshold = 0.75;
		  this->fields.m_CharacterBloomIntensity = 1.0;
		  this->fields._.m_targetEnable = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		public override void Apply(VolumeProfile volumeProfile) {} // 0x0000000189B5EA5C-0x0000000189B5EB7C
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPCharacterBloom::Apply(
		        VFXPPCharacterBloom *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  MonitorData *monitor; // rax
		  Object__Class *klass; // rax
		  Object__Class *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *component; // [rsp+48h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2426, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2426, 0LL);
		    if ( !Patch )
		      goto LABEL_15;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)volumeProfile,
		      0LL);
		  }
		  else
		  {
		    if ( !volumeProfile )
		      goto LABEL_15;
		    if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
		            volumeProfile,
		            MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::Bloom>) )
		      UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
		        volumeProfile,
		        0,
		        MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::Bloom>);
		    if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		           volumeProfile,
		           &component,
		           MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::Bloom>) )
		    {
		      if ( component )
		      {
		        LOBYTE(component[1].monitor) = 1;
		        if ( component )
		        {
		          monitor = component[10].monitor;
		          LOBYTE(v6) = this->fields.m_CharacterBloomEnabled;
		          if ( monitor )
		          {
		            *((_BYTE *)monitor + 16) = 1;
		            *((_BYTE *)monitor + 24) = v6;
		            if ( component )
		            {
		              klass = component[11].klass;
		              if ( klass )
		              {
		                *(float *)&klass->_0.namespaze = this->fields.m_CharacterBloomThreshold;
		                LOBYTE(klass->_0.name) = 1;
		                if ( component )
		                {
		                  v9 = component[12].klass;
		                  if ( v9 )
		                  {
		                    *(float *)&v9->_0.namespaze = this->fields.m_CharacterBloomIntensity;
		                    LOBYTE(v9->_0.name) = 1;
		                    return;
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		LABEL_15:
		      sub_1800D8260(v6, v5);
		    }
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000189B5EB7C-0x0000000189B5EC68
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPCharacterBloom::ResetByVolumeProfile(
		        VFXPPCharacterBloom *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  _BYTE *monitor; // rcx
		  Object__Class *klass; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *component; // [rsp+48h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2427, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
		      return;
		    if ( volumeProfile )
		    {
		      if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		              volumeProfile,
		              &component,
		              MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::Bloom>) )
		        return;
		      if ( component )
		      {
		        monitor = component[10].monitor;
		        if ( monitor )
		        {
		          monitor[16] = 0;
		          if ( component )
		          {
		            monitor = component[11].klass;
		            if ( monitor )
		            {
		              monitor[16] = 0;
		              if ( component )
		              {
		                klass = component[12].klass;
		                if ( klass )
		                {
		                  LOBYTE(klass->_0.name) = 0;
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_13:
		    sub_1800D8260(monitor, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2427, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
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
