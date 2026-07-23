using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPRadialBlur(\u5F84\u5411\u6A21\u7CCA)")]
	[ExecuteInEditMode]
	public class VFXPPRadialBlur : VFXPPComponent // TypeDefIndex: 37960
	{
		// Fields
		[Range(0f, 0.3f)]
		[SerializeField]
		private float _intensity; // 0x48
		[SerializeField]
		private bool _useAsCenterPosition; // 0x4C
		[SerializeField]
		private bool _averageSteps; // 0x4D
		[Range(1f, 2f)]
		[SerializeField]
		private float _power; // 0x50
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000184702EC0-0x0000000184702EF0 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPRadialBlur::get_m_VFXPPType(VFXPPRadialBlur *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2537, 0LL) )
		    return 2;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2537, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPRadialBlur() {} // 0x00000001844D8CB0-0x00000001844D8CC0
		// VFXPPVignette()
		void HG::Rendering::Runtime::VFXPPVignette::VFXPPVignette(VFXPPVignette *this, MethodInfo *method)
		{
		  this->fields._.m_targetEnable = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		public override VFXPPData GetDefaultData() => default; // 0x0000000189B622AC-0x0000000189B62320
		// VFXPPData GetDefaultData()
		VFXPPData *HG::Rendering::Runtime::VFXPPRadialBlur::GetDefaultData(VFXPPRadialBlur *this, MethodInfo *method)
		{
		  VFXPPData *result; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2538, 0LL) )
		  {
		    result = (VFXPPData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
		    if ( result )
		    {
		      LODWORD(result[1].klass) = 0;
		      LODWORD(result[1].monitor) = 0;
		      BYTE4(result[1].klass) = this->fields._useAsCenterPosition;
		      BYTE5(result[1].klass) = this->fields._averageSteps;
		      result->fields.priority = this->fields._.m_priority;
		      return result;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2538, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_946(Patch, (Object *)this, 0LL);
		}
		
		protected override VFXPPData _GetLerpData(float value) => default; // 0x0000000189B623A8-0x0000000189B62494
		// VFXPPData _GetLerpData(Single)
		VFXPPData *HG::Rendering::Runtime::VFXPPRadialBlur::_GetLerpData(
		        VFXPPRadialBlur *this,
		        float value,
		        MethodInfo *method)
		{
		  float v3; // xmm3_4
		  __int64 v5; // rbx
		  __int64 v6; // rdi
		  __int64 v7; // rdx
		  Beyond::JobMathf *v8; // rcx
		  int v9; // xmm0_4
		  int v10; // xmm0_4
		  Beyond::JobMathf *v11; // rcx
		  __int64 v12; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2539, 0LL) )
		  {
		    v5 = sub_180005050(this->fields._.m_snapShotData, TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
		    v6 = sub_180005050(this->fields._.m_targetData, TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
		    v8 = (Beyond::JobMathf *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
		    if ( v8 && v5 && v6 )
		    {
		      v9 = *(_DWORD *)(v5 + 24);
		      *(_DWORD *)(Beyond::JobMathf::ClampedLerp(v8, *(float *)(v6 + 24), value, v3) + 24) = v9;
		      v10 = *(_DWORD *)(v5 + 32);
		      *(_DWORD *)(Beyond::JobMathf::ClampedLerp(v11, *(float *)(v6 + 32), value, v3) + 32) = v10;
		      *(_BYTE *)(v12 + 28) = *(_BYTE *)(v5 + 28);
		      *(_BYTE *)(v12 + 29) = *(_BYTE *)(v5 + 29);
		      *(_DWORD *)(v12 + 16) = *(_DWORD *)(v5 + 16);
		      return (VFXPPData *)v12;
		    }
		LABEL_7:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2539, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_947(Patch, (Object *)this, value, 0LL);
		}
		
		public override void SetData(VFXPPData data) {} // 0x0000000189B62320-0x0000000189B623A8
		// Void SetData(VFXPPData)
		void HG::Rendering::Runtime::VFXPPRadialBlur::SetData(VFXPPRadialBlur *this, VFXPPData *data, MethodInfo *method)
		{
		  __int64 v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2540, 0LL) )
		  {
		    v5 = sub_180005050(data, TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
		    if ( v5 )
		    {
		      this->fields._intensity = *(float *)(v5 + 24);
		      this->fields._useAsCenterPosition = *(_BYTE *)(v5 + 28);
		      this->fields._averageSteps = *(_BYTE *)(v5 + 29);
		      this->fields._power = *(float *)(v5 + 32);
		      this->fields._.m_priority = *(_DWORD *)(v5 + 16);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2540, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)data,
		    0LL);
		}
		
		public override VFXPPData GetData() => default; // 0x0000000189B62218-0x0000000189B622AC
		// VFXPPData GetData()
		VFXPPData *HG::Rendering::Runtime::VFXPPRadialBlur::GetData(VFXPPRadialBlur *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  VFXPPData *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2541, 0LL) )
		  {
		    v3 = sub_18002C620(TypeInfo::HG::Rendering::Runtime::VFXPPRadiaBlurData);
		    v6 = (VFXPPData *)v3;
		    if ( v3 )
		    {
		      *(float *)(v3 + 24) = this->fields._intensity;
		      *(_BYTE *)(v3 + 28) = this->fields._useAsCenterPosition;
		      *(_BYTE *)(v3 + 29) = this->fields._averageSteps;
		      *(float *)(v3 + 32) = this->fields._power;
		      *(_DWORD *)(v3 + 16) = HG::Rendering::Runtime::VFXPPComponent::get_priority((VFXPPComponent *)this, 0LL);
		      return v6;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2541, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_946(Patch, (Object *)this, 0LL);
		}
		
		public override void Apply(VolumeProfile volumeProfile) {} // 0x0000000183087EC0-0x00000001830881E0
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPRadialBlur::Apply(
		        VFXPPRadialBlur *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  _BYTE *monitor; // rdx
		  _DWORD *klass; // rcx
		  Transform *v8; // rsi
		  __int64 v9; // r8
		  Object__Class *v10; // rax
		  Object__Class *v11; // rax
		  __int64 v12; // r8
		  Object__Class *v13; // rax
		  Object__Class *v14; // rdi
		  Transform *v15; // rax
		  Vector3 *position; // rax
		  __int64 v17; // xmm0_8
		  float z; // eax
		  Object__Class *v19; // rax
		  Transform *v20; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v22; // [rsp+20h] [rbp-20h] BYREF
		  float v23; // [rsp+28h] [rbp-18h]
		  Vector3 v24; // [rsp+30h] [rbp-10h] BYREF
		  Object *component; // [rsp+68h] [rbp+28h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2542, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2542, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)volumeProfile,
		        0LL);
		      return;
		    }
		    goto LABEL_42;
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
		        goto LABEL_42;
		      if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
		              volumeProfile,
		              MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGRadialBlur>) )
		        UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
		          volumeProfile,
		          0,
		          MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGRadialBlur>);
		      if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		             volumeProfile,
		             &component,
		             MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGRadialBlur>) )
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
		                monitor = component[3].klass;
		                if ( monitor )
		                {
		                  LOBYTE(v9) = 1;
		                  sub_180043DF0(11LL, monitor, v9);
		                  if ( component )
		                  {
		                    v10 = component[4].klass;
		                    if ( v10 )
		                    {
		                      LOBYTE(v10->_0.name) = 1;
		                      if ( component )
		                      {
		                        monitor = component[4].klass;
		                        if ( monitor )
		                        {
		                          sub_180049310(11LL, monitor);
		                          if ( component )
		                          {
		                            v11 = component[5].klass;
		                            if ( v11 )
		                            {
		                              LOBYTE(v11->_0.name) = 1;
		                              if ( component )
		                              {
		                                monitor = component[5].klass;
		                                if ( monitor )
		                                {
		                                  sub_180043DF0(11LL, monitor, this->fields._averageSteps);
		                                  if ( this->fields._useAsCenterPosition )
		                                  {
		                                    if ( !component )
		                                      goto LABEL_42;
		                                    klass = component[5].monitor;
		                                    if ( !klass )
		                                      goto LABEL_42;
		                                    *((_BYTE *)klass + 16) = 1;
		                                    if ( !component )
		                                      goto LABEL_42;
		                                    monitor = component[5].monitor;
		                                    if ( !monitor )
		                                      goto LABEL_42;
		                                    LOBYTE(v12) = 1;
		                                    sub_180043DF0(11LL, monitor, v12);
		                                    if ( !component )
		                                      goto LABEL_42;
		                                    v19 = component[6].klass;
		                                    if ( !v19 )
		                                      goto LABEL_42;
		                                    LOBYTE(v19->_0.name) = 1;
		                                    if ( !component )
		                                      goto LABEL_42;
		                                    v14 = component[6].klass;
		                                    v20 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		                                    if ( !v20 )
		                                      goto LABEL_42;
		                                    position = UnityEngine::Transform::get_position(&v24, v20, 0LL);
		                                    if ( !v14 )
		                                      goto LABEL_42;
		                                  }
		                                  else
		                                  {
		                                    if ( !component )
		                                      goto LABEL_42;
		                                    klass = component[3].monitor;
		                                    if ( !klass )
		                                      goto LABEL_42;
		                                    *((_BYTE *)klass + 16) = 0;
		                                    if ( !component )
		                                      goto LABEL_42;
		                                    klass = component[5].monitor;
		                                    if ( !klass )
		                                      goto LABEL_42;
		                                    *((_BYTE *)klass + 16) = 0;
		                                    if ( !component )
		                                      goto LABEL_42;
		                                    monitor = component[5].monitor;
		                                    if ( !monitor )
		                                      goto LABEL_42;
		                                    sub_180043DF0(11LL, monitor, 0LL);
		                                    if ( !component )
		                                      goto LABEL_42;
		                                    v13 = component[6].klass;
		                                    if ( !v13 )
		                                      goto LABEL_42;
		                                    LOBYTE(v13->_0.name) = 0;
		                                    if ( !component )
		                                      goto LABEL_42;
		                                    v14 = component[6].klass;
		                                    v15 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		                                    if ( !v15 )
		                                      goto LABEL_42;
		                                    position = UnityEngine::Transform::get_position(&v24, v15, 0LL);
		                                    if ( !v14 )
		                                      goto LABEL_42;
		                                  }
		                                  v17 = *(_QWORD *)&position->x;
		                                  z = position->z;
		                                  v22 = v17;
		                                  v23 = z;
		                                  sub_18003B640(11LL, v14, &v22);
		                                  if ( component )
		                                  {
		                                    monitor = component[4].monitor;
		                                    if ( monitor )
		                                    {
		                                      monitor[16] = 1;
		                                      if ( component )
		                                      {
		                                        monitor = component[4].monitor;
		                                        if ( monitor )
		                                        {
		                                          sub_180049310(11LL, monitor);
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
		LABEL_42:
		        sub_1800D8260(klass, monitor);
		      }
		    }
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000184535470-0x0000000184535700
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPRadialBlur::ResetByVolumeProfile(
		        VFXPPRadialBlur *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  struct Object_1__Class *v5; // rcx
		  void *v6; // rdx
		  Object__Class *klass; // rcx
		  Object__Class *v8; // rax
		  MonitorData *monitor; // rax
		  Object__Class *v10; // rax
		  Object__Class *v11; // rax
		  MonitorData *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  unsigned __int64 v14; // [rsp+20h] [rbp-28h] BYREF
		  int v15; // [rsp+28h] [rbp-20h]
		  Object *component; // [rsp+68h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2543, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2543, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)volumeProfile,
		        0LL);
		      return;
		    }
		LABEL_35:
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
		           MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGRadialBlur>) )
		    {
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
		              v6 = component[3].klass;
		              if ( v6 )
		              {
		                sub_180043DF0(11LL, v6, 0LL);
		                if ( component )
		                {
		                  v8 = component[4].klass;
		                  if ( v8 )
		                  {
		                    LOBYTE(v8->_0.name) = 0;
		                    if ( component )
		                    {
		                      v6 = component[4].klass;
		                      if ( v6 )
		                      {
		                        sub_180049310(11LL, v6);
		                        if ( component )
		                        {
		                          monitor = component[5].monitor;
		                          if ( monitor )
		                          {
		                            *((_BYTE *)monitor + 16) = 0;
		                            if ( component )
		                            {
		                              v6 = component[5].monitor;
		                              if ( v6 )
		                              {
		                                sub_180043DF0(11LL, v6, 0LL);
		                                if ( component )
		                                {
		                                  v10 = component[6].klass;
		                                  if ( v10 )
		                                  {
		                                    LOBYTE(v10->_0.name) = 0;
		                                    if ( component )
		                                    {
		                                      v6 = component[6].klass;
		                                      if ( v6 )
		                                      {
		                                        v15 = 0;
		                                        v14 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		                                        sub_18003B640(11LL, v6, &v14);
		                                        if ( component )
		                                        {
		                                          v11 = component[5].klass;
		                                          if ( v11 )
		                                          {
		                                            LOBYTE(v11->_0.name) = 0;
		                                            if ( component )
		                                            {
		                                              v6 = component[5].klass;
		                                              if ( v6 )
		                                              {
		                                                sub_180043DF0(11LL, v6, 0LL);
		                                                if ( component )
		                                                {
		                                                  v12 = component[4].monitor;
		                                                  if ( v12 )
		                                                  {
		                                                    *((_BYTE *)v12 + 16) = 0;
		                                                    if ( component )
		                                                    {
		                                                      v6 = component[4].monitor;
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
		      goto LABEL_35;
		    }
		  }
		}
		
		public override bool IsActive() => default; // 0x000000018436E7A0-0x000000018436E7E0
		// Boolean IsActive()
		bool HG::Rendering::Runtime::VFXPPRadialBlur::IsActive(VFXPPRadialBlur *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2544, 0LL) )
		    return this->fields._intensity != 0.0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2544, 0LL);
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
