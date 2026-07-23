using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPChromaticAberration(\u8272\u6563)")]
	[ExecuteInEditMode]
	public class VFXPPChromaticAberration : VFXPPComponent // TypeDefIndex: 37943
	{
		// Fields
		[Range(0f, 0.3f)]
		[SerializeField]
		private float _intensity; // 0x48
		[SerializeField]
		private bool _useAsCenterPosition; // 0x4C
		[SerializeField]
		private bool _averageSteps; // 0x4D
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x00000001847DF5F0-0x00000001847DF620 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPChromaticAberration::get_m_VFXPPType(
		        VFXPPChromaticAberration *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2441, 0LL) )
		    return 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2441, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPChromaticAberration() {} // 0x00000001844D8E60-0x00000001844D8E80
		// VFXPPChromaticAberration()
		void HG::Rendering::Runtime::VFXPPChromaticAberration::VFXPPChromaticAberration(
		        VFXPPChromaticAberration *this,
		        MethodInfo *method)
		{
		  this->fields._intensity = 0.1;
		  this->fields._.m_targetEnable = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		public override void SetData(VFXPPData data) {} // 0x0000000189B5F018-0x0000000189B5F09C
		// Void SetData(VFXPPData)
		void HG::Rendering::Runtime::VFXPPChromaticAberration::SetData(
		        VFXPPChromaticAberration *this,
		        VFXPPData *data,
		        MethodInfo *method)
		{
		  __int64 v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2442, 0LL) )
		  {
		    v5 = sub_180005050(data, TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
		    if ( v5 )
		    {
		      this->fields._intensity = *(float *)(v5 + 24);
		      this->fields._useAsCenterPosition = *(_BYTE *)(v5 + 28);
		      this->fields._averageSteps = *(_BYTE *)(v5 + 29);
		      this->fields._.m_priority = *(_DWORD *)(v5 + 16);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2442, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)data,
		    0LL);
		}
		
		public override VFXPPData GetData() => default; // 0x0000000189B5EF28-0x0000000189B5EFA8
		// VFXPPData GetData()
		VFXPPData *HG::Rendering::Runtime::VFXPPChromaticAberration::GetData(
		        VFXPPChromaticAberration *this,
		        MethodInfo *method)
		{
		  VFXPPData *result; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2443, 0LL) )
		  {
		    result = (VFXPPData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
		    if ( result )
		    {
		      LODWORD(result[1].klass) = 1036831949;
		      *(float *)&result[1].klass = this->fields._intensity;
		      BYTE4(result[1].klass) = this->fields._useAsCenterPosition;
		      BYTE5(result[1].klass) = this->fields._averageSteps;
		      result->fields.priority = this->fields._.m_priority;
		      return result;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2443, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_946(Patch, (Object *)this, 0LL);
		}
		
		public override VFXPPData GetDefaultData() => default; // 0x0000000189B5EFA8-0x0000000189B5F018
		// VFXPPData GetDefaultData()
		VFXPPData *HG::Rendering::Runtime::VFXPPChromaticAberration::GetDefaultData(
		        VFXPPChromaticAberration *this,
		        MethodInfo *method)
		{
		  VFXPPData *result; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2444, 0LL) )
		  {
		    result = (VFXPPData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
		    if ( result )
		    {
		      LODWORD(result[1].klass) = 0;
		      BYTE4(result[1].klass) = this->fields._useAsCenterPosition;
		      BYTE5(result[1].klass) = this->fields._averageSteps;
		      result->fields.priority = this->fields._.m_priority;
		      return result;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2444, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_946(Patch, (Object *)this, 0LL);
		}
		
		protected override VFXPPData _GetLerpData(float value) => default; // 0x0000000189B5F0BC-0x0000000189B5F194
		// VFXPPData _GetLerpData(Single)
		VFXPPData *HG::Rendering::Runtime::VFXPPChromaticAberration::_GetLerpData(
		        VFXPPChromaticAberration *this,
		        float value,
		        MethodInfo *method)
		{
		  float v3; // xmm3_4
		  __int64 v5; // rbx
		  __int64 v6; // rdi
		  Beyond::JobMathf *v7; // rax
		  __int64 v8; // rdx
		  Beyond::JobMathf *v9; // rcx
		  int v10; // xmm0_4
		  __int64 v11; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2445, 0LL) )
		  {
		    v5 = sub_180005050(this->fields._.m_snapShotData, TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
		    v6 = sub_180005050(this->fields._.m_targetData, TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
		    v7 = (Beyond::JobMathf *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::VFXPPChromaticAberrationData);
		    v9 = v7;
		    if ( v7 )
		    {
		      *((_DWORD *)v7 + 6) = 1036831949;
		      if ( v5 )
		      {
		        if ( v6 )
		        {
		          v10 = *(_DWORD *)(v5 + 24);
		          *(_DWORD *)(Beyond::JobMathf::ClampedLerp(v7, *(float *)(v6 + 24), value, v3) + 24) = v10;
		          *(_BYTE *)(v11 + 28) = *(_BYTE *)(v5 + 28);
		          *(_BYTE *)(v11 + 29) = *(_BYTE *)(v5 + 29);
		          *(_DWORD *)(v11 + 16) = *(_DWORD *)(v5 + 16);
		          return (VFXPPData *)v11;
		        }
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v9, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2445, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_947(Patch, (Object *)this, value, 0LL);
		}
		
		public override void Apply(VolumeProfile volumeProfile) {} // 0x00000001842126C0-0x00000001842129C0
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPChromaticAberration::Apply(
		        VFXPPChromaticAberration *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  void *v6; // rdx
		  _DWORD *klass; // rcx
		  Transform *v8; // rsi
		  __int64 v9; // r8
		  Object__Class *v10; // rax
		  MonitorData *monitor; // rax
		  __int64 v12; // r8
		  MonitorData *v13; // rax
		  MonitorData *v14; // rbx
		  Transform *v15; // rax
		  Vector3 *v16; // rax
		  __int64 v17; // xmm0_8
		  float v18; // eax
		  MonitorData *v19; // rax
		  MonitorData *v20; // rbx
		  Transform *v21; // rax
		  Vector3 *position; // rax
		  __int64 v23; // xmm0_8
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v26; // [rsp+20h] [rbp-20h] BYREF
		  float v27; // [rsp+28h] [rbp-18h]
		  Vector3 v28; // [rsp+30h] [rbp-10h] BYREF
		  Object *component; // [rsp+68h] [rbp+28h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2446, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2446, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)volumeProfile,
		        0LL);
		      return;
		    }
		    goto LABEL_40;
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  klass = TypeInfo::UnityEngine::Object;
		  v8 = transform;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    klass = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      klass = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( v8 )
		  {
		    if ( !klass[56] )
		      il2cpp_runtime_class_init_1(klass);
		    if ( v8->fields._._.m_CachedPtr )
		    {
		      if ( !volumeProfile )
		        goto LABEL_40;
		      if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
		              volumeProfile,
		              MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGChromaticAbberation>) )
		        UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
		          volumeProfile,
		          0,
		          MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGChromaticAbberation>);
		      if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		             volumeProfile,
		             &component,
		             MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGChromaticAbberation>) )
		      {
		        if ( component )
		        {
		          LOBYTE(component[1].monitor) = 1;
		          if ( component )
		          {
		            klass = component[3].klass;
		            if ( klass )
		            {
		              *((_BYTE *)klass + 16) = 1;
		              if ( component )
		              {
		                v6 = component[3].klass;
		                if ( v6 )
		                {
		                  LOBYTE(v9) = 1;
		                  sub_180043DF0(11LL, v6, v9);
		                  if ( component )
		                  {
		                    v10 = component[4].klass;
		                    if ( v10 )
		                    {
		                      LOBYTE(v10->_0.name) = 1;
		                      if ( component )
		                      {
		                        v6 = component[4].klass;
		                        if ( v6 )
		                        {
		                          sub_180049310(11LL, v6);
		                          if ( component )
		                          {
		                            monitor = component[4].monitor;
		                            if ( monitor )
		                            {
		                              *((_BYTE *)monitor + 16) = 1;
		                              if ( component )
		                              {
		                                v6 = component[4].monitor;
		                                if ( v6 )
		                                {
		                                  sub_180043DF0(11LL, v6, this->fields._averageSteps);
		                                  if ( this->fields._useAsCenterPosition )
		                                  {
		                                    if ( component )
		                                    {
		                                      klass = component[5].klass;
		                                      if ( klass )
		                                      {
		                                        *((_BYTE *)klass + 16) = 1;
		                                        if ( component )
		                                        {
		                                          v6 = component[5].klass;
		                                          if ( v6 )
		                                          {
		                                            LOBYTE(v12) = 1;
		                                            sub_180043DF0(11LL, v6, v12);
		                                            if ( component )
		                                            {
		                                              v19 = component[5].monitor;
		                                              if ( v19 )
		                                              {
		                                                *((_BYTE *)v19 + 16) = 1;
		                                                if ( component )
		                                                {
		                                                  v20 = component[5].monitor;
		                                                  v21 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		                                                  if ( v21 )
		                                                  {
		                                                    position = UnityEngine::Transform::get_position(&v28, v21, 0LL);
		                                                    if ( v20 )
		                                                    {
		                                                      v23 = *(_QWORD *)&position->x;
		                                                      z = position->z;
		                                                      v26 = v23;
		                                                      v27 = z;
		                                                      sub_18003B640(11LL, v20, &v26);
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
		                                  else if ( component )
		                                  {
		                                    klass = component[3].monitor;
		                                    if ( klass )
		                                    {
		                                      *((_BYTE *)klass + 16) = 0;
		                                      if ( component )
		                                      {
		                                        klass = component[3].monitor;
		                                        if ( klass )
		                                        {
		                                          *((_BYTE *)klass + 16) = 0;
		                                          if ( component )
		                                          {
		                                            klass = component[5].klass;
		                                            if ( klass )
		                                            {
		                                              *((_BYTE *)klass + 16) = 0;
		                                              if ( component )
		                                              {
		                                                v6 = component[5].klass;
		                                                if ( v6 )
		                                                {
		                                                  sub_180043DF0(11LL, v6, 0LL);
		                                                  if ( component )
		                                                  {
		                                                    v13 = component[5].monitor;
		                                                    if ( v13 )
		                                                    {
		                                                      *((_BYTE *)v13 + 16) = 0;
		                                                      if ( component )
		                                                      {
		                                                        v14 = component[5].monitor;
		                                                        v15 = UnityEngine::Component::get_transform(
		                                                                (Component *)this,
		                                                                0LL);
		                                                        if ( v15 )
		                                                        {
		                                                          v16 = UnityEngine::Transform::get_position(&v28, v15, 0LL);
		                                                          if ( v14 )
		                                                          {
		                                                            v17 = *(_QWORD *)&v16->x;
		                                                            v18 = v16->z;
		                                                            v26 = v17;
		                                                            v27 = v18;
		                                                            sub_18003B640(11LL, v14, &v26);
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
		            }
		          }
		        }
		LABEL_40:
		        sub_1800D8260(klass, v6);
		      }
		    }
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000184212490-0x00000001842126C0
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPChromaticAberration::ResetByVolumeProfile(
		        VFXPPChromaticAberration *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  struct Object_1__Class *v5; // rcx
		  void *monitor; // rdx
		  _BYTE *klass; // rcx
		  Object__Class *v8; // rax
		  MonitorData *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  unsigned __int64 v11; // [rsp+20h] [rbp-28h] BYREF
		  int v12; // [rsp+28h] [rbp-20h]
		  Object *component; // [rsp+68h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2447, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2447, 0LL);
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
		    sub_1800D8260(klass, monitor);
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
		           MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGChromaticAbberation>) )
		    {
		      if ( component )
		      {
		        klass = component[3].klass;
		        if ( klass )
		        {
		          klass[16] = 0;
		          if ( component )
		          {
		            monitor = component[3].klass;
		            if ( monitor )
		            {
		              sub_180043DF0(11LL, monitor, 0LL);
		              monitor = component;
		              if ( component )
		              {
		                monitor = component[4].klass;
		                if ( monitor )
		                {
		                  sub_180049310(11LL, monitor);
		                  if ( component )
		                  {
		                    LOBYTE(component[1].monitor) = 0;
		                    if ( component )
		                    {
		                      klass = component[4].monitor;
		                      if ( klass )
		                      {
		                        klass[16] = 0;
		                        if ( component )
		                        {
		                          monitor = component[4].monitor;
		                          if ( monitor )
		                          {
		                            sub_180043DF0(11LL, monitor, 0LL);
		                            if ( component )
		                            {
		                              v8 = component[5].klass;
		                              if ( v8 )
		                              {
		                                LOBYTE(v8->_0.name) = 0;
		                                if ( component )
		                                {
		                                  monitor = component[5].klass;
		                                  if ( monitor )
		                                  {
		                                    sub_180043DF0(11LL, monitor, 0LL);
		                                    if ( component )
		                                    {
		                                      v9 = component[5].monitor;
		                                      if ( v9 )
		                                      {
		                                        *((_BYTE *)v9 + 16) = 0;
		                                        if ( component )
		                                        {
		                                          monitor = component[5].monitor;
		                                          if ( monitor )
		                                          {
		                                            v12 = 0;
		                                            v11 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		                                            sub_18003B640(11LL, monitor, &v11);
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
		      goto LABEL_10;
		    }
		  }
		}
		
		public override bool IsActive() => default; // 0x0000000184585A70-0x0000000184585AA0
		// Boolean IsActive()
		bool HG::Rendering::Runtime::VFXPPChromaticAberration::IsActive(VFXPPChromaticAberration *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2448, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2448, 0LL);
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
		
		public void __iFixBaseProxy_SetData(VFXPPData P0) {} // 0x0000000189B5F0AC-0x0000000189B5F0B4
		// Void <>iFixBaseProxy_SetData(VFXPPData)
		void HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_SetData(
		        VFXPPVignette *this,
		        VFXPPData *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::SetData((VFXPPComponent *)this, P0, 0LL);
		}
		
		public VFXPPData __iFixBaseProxy_GetData() => default; // 0x0000000189B5F09C-0x0000000189B5F0A4
		// VFXPPData <>iFixBaseProxy_GetData()
		VFXPPData *HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_GetData(VFXPPVignette *this, MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::GetData((VFXPPComponent *)this, 0LL);
		}
		
		public VFXPPData __iFixBaseProxy_GetDefaultData() => default; // 0x0000000189B5F0A4-0x0000000189B5F0AC
		// VFXPPData <>iFixBaseProxy_GetDefaultData()
		VFXPPData *HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_GetDefaultData(
		        VFXPPVignette *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::GetDefaultData((VFXPPComponent *)this, 0LL);
		}
		
		public VFXPPData __iFixBaseProxy__GetLerpData(float P0) => default; // 0x0000000189B5F0B4-0x0000000189B5F0BC
		// VFXPPData <>iFixBaseProxy__GetLerpData(Single)
		VFXPPData *HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy__GetLerpData(
		        VFXPPVignette *this,
		        float P0,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::_GetLerpData((VFXPPComponent *)this, P0, 0LL);
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
