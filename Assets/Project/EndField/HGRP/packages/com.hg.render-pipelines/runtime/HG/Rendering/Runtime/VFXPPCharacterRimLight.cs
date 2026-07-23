using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPCharacterRimLight(\u89D2\u8272\u5168\u5C40\u8FB9\u7F18\u5149)")]
	[ExecuteInEditMode]
	public class VFXPPCharacterRimLight : VFXPPComponent // TypeDefIndex: 37941
	{
		// Fields
		[Header("\u5168\u5C40\u8FB9\u7F18\u5149")]
		[SerializeField]
		private UnityEngine.Color m_RimLightColor; // 0x48
		[Range(0f, 1f)]
		[SerializeField]
		private float m_RimAngle; // 0x58
		[Range(0f, 10f)]
		[SerializeField]
		private float m_RimIntensity; // 0x5C
		[Range(0f, 1f)]
		[SerializeField]
		private float m_RimWidth; // 0x60
		[Range(0f, 1f)]
		[SerializeField]
		private float m_RimAlbedo; // 0x64
		[SerializeField]
		private bool m_RimMode; // 0x68
		[Header("\u8138\u90E8\u989D\u5916\u8FB9\u7F18\u5149")]
		[SerializeField]
		private bool m_EnableFaceRim; // 0x69
		[SerializeField]
		private UnityEngine.Color m_FaceRimLightColor; // 0x6C
		[Range(0f, 1f)]
		[SerializeField]
		private float m_FaceRimAngle; // 0x7C
		[Range(0f, 10f)]
		[SerializeField]
		private float m_FaceRimIntensity; // 0x80
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000184CA2D40-0x0000000184CA2D70 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPCharacterRimLight::get_m_VFXPPType(
		        VFXPPCharacterRimLight *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2437, 0LL) )
		    return 12;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2437, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPCharacterRimLight() {} // 0x00000001844D8CC0-0x00000001844D8D30
		// VFXPPCharacterRimLight()
		void HG::Rendering::Runtime::VFXPPCharacterRimLight::VFXPPCharacterRimLight(
		        VFXPPCharacterRimLight *this,
		        MethodInfo *method)
		{
		  Vector4 v2; // xmm1
		  __int64 v3; // r8
		  MethodInfo *v4; // rdx
		  Vector4 v5; // xmm1
		  __int64 v6; // r8
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  v2 = *UnityEngine::Vector4::get_one(&v7, method);
		  *(_DWORD *)(v3 + 92) = 1065353216;
		  *(_DWORD *)(v3 + 96) = 1053609165;
		  *(Vector4 *)(v3 + 72) = v2;
		  v5 = *UnityEngine::Vector4::get_one(&v7, v4);
		  *(_DWORD *)(v6 + 124) = 1036831949;
		  *(_DWORD *)(v6 + 128) = 1065353216;
		  *(Vector4 *)(v6 + 108) = v5;
		  *(_BYTE *)(v6 + 52) = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)v6, 0LL);
		}
		
	
		// Methods
		public override void Apply(VolumeProfile volumeProfile) {} // 0x0000000184128410-0x00000001841286F0
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPCharacterRimLight::Apply(
		        VFXPPCharacterRimLight *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  __int64 v6; // rdx
		  char *monitor; // rcx
		  Transform *v8; // rsi
		  Object__Class *klass; // rax
		  Color m_RimLightColor; // xmm0
		  Object__Class *v11; // rax
		  MonitorData *v12; // rax
		  Object__Class *v13; // rax
		  MonitorData *v14; // rax
		  Object__Class *v15; // rax
		  MonitorData *v16; // rax
		  Color m_FaceRimLightColor; // xmm0
		  MonitorData *v18; // rax
		  Object__Class *v19; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *component; // [rsp+48h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2438, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2438, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)volumeProfile,
		        0LL);
		      return;
		    }
		    goto LABEL_36;
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  monitor = (char *)TypeInfo::UnityEngine::Object;
		  v8 = transform;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    monitor = (char *)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      monitor = (char *)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( v8 )
		  {
		    if ( !*((_DWORD *)monitor + 56) )
		      il2cpp_runtime_class_init_1(monitor);
		    if ( v8->fields._._.m_CachedPtr )
		    {
		      if ( !volumeProfile )
		        goto LABEL_36;
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
		          if ( component )
		          {
		            klass = component[17].klass;
		            if ( klass )
		            {
		              LOBYTE(klass->_0.name) = 1;
		              LOBYTE(klass->_0.namespaze) = 1;
		              if ( component )
		              {
		                monitor = (char *)component[17].monitor;
		                if ( monitor )
		                {
		                  m_RimLightColor = this->fields.m_RimLightColor;
		                  monitor[16] = 1;
		                  *(Color *)(monitor + 24) = m_RimLightColor;
		                  if ( component )
		                  {
		                    v11 = component[18].klass;
		                    if ( v11 )
		                    {
		                      *(float *)&v11->_0.namespaze = this->fields.m_RimAngle;
		                      LOBYTE(v11->_0.name) = 1;
		                      if ( component )
		                      {
		                        v12 = component[18].monitor;
		                        if ( v12 )
		                        {
		                          *((_DWORD *)v12 + 6) = LODWORD(this->fields.m_RimIntensity);
		                          *((_BYTE *)v12 + 16) = 1;
		                          if ( component )
		                          {
		                            v13 = component[19].klass;
		                            if ( v13 )
		                            {
		                              *(float *)&v13->_0.namespaze = this->fields.m_RimWidth;
		                              LOBYTE(v13->_0.name) = 1;
		                              if ( component )
		                              {
		                                v14 = component[19].monitor;
		                                if ( v14 )
		                                {
		                                  *((_DWORD *)v14 + 6) = LODWORD(this->fields.m_RimAlbedo);
		                                  *((_BYTE *)v14 + 16) = 1;
		                                  if ( component )
		                                  {
		                                    v15 = component[20].klass;
		                                    monitor = (char *)this->fields.m_RimMode;
		                                    if ( v15 )
		                                    {
		                                      LOBYTE(v15->_0.name) = 1;
		                                      LOBYTE(v15->_0.namespaze) = (_BYTE)monitor;
		                                      if ( component )
		                                      {
		                                        v16 = component[20].monitor;
		                                        monitor = (char *)this->fields.m_EnableFaceRim;
		                                        if ( v16 )
		                                        {
		                                          *((_BYTE *)v16 + 16) = 1;
		                                          *((_BYTE *)v16 + 24) = (_BYTE)monitor;
		                                          if ( component )
		                                          {
		                                            monitor = (char *)component[21].klass;
		                                            if ( monitor )
		                                            {
		                                              m_FaceRimLightColor = this->fields.m_FaceRimLightColor;
		                                              monitor[16] = 1;
		                                              *(Color *)(monitor + 24) = m_FaceRimLightColor;
		                                              if ( component )
		                                              {
		                                                v18 = component[21].monitor;
		                                                if ( v18 )
		                                                {
		                                                  *((_DWORD *)v18 + 6) = LODWORD(this->fields.m_FaceRimAngle);
		                                                  *((_BYTE *)v18 + 16) = 1;
		                                                  if ( component )
		                                                  {
		                                                    v19 = component[22].klass;
		                                                    if ( v19 )
		                                                    {
		                                                      *(float *)&v19->_0.namespaze = this->fields.m_FaceRimIntensity;
		                                                      LOBYTE(v19->_0.name) = 1;
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
		            }
		          }
		        }
		LABEL_36:
		        sub_1800D8260(monitor, v6);
		      }
		    }
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x00000001841279D0-0x0000000184127BE0
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPCharacterRimLight::ResetByVolumeProfile(
		        VFXPPCharacterRimLight *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  struct Object_1__Class *v5; // rcx
		  __int64 v6; // rdx
		  _BYTE *klass; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *component; // [rsp+48h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2439, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2439, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)volumeProfile,
		        0LL);
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(klass, v6);
		  }
		  v5 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v5 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( volumeProfile )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v5);
		    if ( volumeProfile->fields._._.m_CachedPtr
		      && UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		           volumeProfile,
		           &component,
		           MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGCharacterVolume>) )
		    {
		      if ( component )
		      {
		        klass = component[17].klass;
		        if ( klass )
		        {
		          klass[16] = 0;
		          if ( component )
		          {
		            klass = component[17].monitor;
		            if ( klass )
		            {
		              klass[16] = 0;
		              if ( component )
		              {
		                klass = component[18].klass;
		                if ( klass )
		                {
		                  klass[16] = 0;
		                  if ( component )
		                  {
		                    klass = component[18].monitor;
		                    if ( klass )
		                    {
		                      klass[16] = 0;
		                      if ( component )
		                      {
		                        klass = component[19].klass;
		                        if ( klass )
		                        {
		                          klass[16] = 0;
		                          if ( component )
		                          {
		                            klass = component[19].monitor;
		                            if ( klass )
		                            {
		                              klass[16] = 0;
		                              if ( component )
		                              {
		                                klass = component[20].klass;
		                                if ( klass )
		                                {
		                                  klass[16] = 0;
		                                  if ( component )
		                                  {
		                                    klass = component[20].monitor;
		                                    if ( klass )
		                                    {
		                                      klass[16] = 0;
		                                      if ( component )
		                                      {
		                                        klass = component[21].klass;
		                                        if ( klass )
		                                        {
		                                          klass[16] = 0;
		                                          if ( component )
		                                          {
		                                            klass = component[21].monitor;
		                                            if ( klass )
		                                            {
		                                              klass[16] = 0;
		                                              if ( component )
		                                              {
		                                                klass = component[22].klass;
		                                                if ( klass )
		                                                {
		                                                  klass[16] = 0;
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
		        }
		      }
		      goto LABEL_10;
		    }
		  }
		}
		
		public void Reset() {} // 0x0000000189B5EED8-0x0000000189B5EF28
		// Void Reset()
		void HG::Rendering::Runtime::VFXPPCharacterRimLight::Reset(VFXPPCharacterRimLight *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2440, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2440, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_RimMode = 1;
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
