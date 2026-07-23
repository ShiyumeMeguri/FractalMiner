using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPVignette(\u7279\u6548\u6697\u89D2)")]
	[ExecuteInEditMode]
	public class VFXPPVignette : VFXPPComponent // TypeDefIndex: 37967
	{
		// Fields
		[SerializeField]
		private UnityEngine.Color _color; // 0x48
		[Range(0f, 1f)]
		[SerializeField]
		private float _intensity; // 0x58
		[Range(0f, 1f)]
		[SerializeField]
		private float _smoothness; // 0x5C
		[SerializeField]
		private bool _rounded; // 0x60
		[SerializeField]
		private bool _blink; // 0x61
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000184A21650-0x0000000184A21680 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPVignette::get_m_VFXPPType(VFXPPVignette *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2580, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2580, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPVignette() {} // 0x00000001844D8CB0-0x00000001844D8CC0
		// VFXPPVignette()
		void HG::Rendering::Runtime::VFXPPVignette::VFXPPVignette(VFXPPVignette *this, MethodInfo *method)
		{
		  this->fields._.m_targetEnable = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		public override void SetData(VFXPPData data) {} // 0x0000000189B66574-0x0000000189B66608
		// Void SetData(VFXPPData)
		void HG::Rendering::Runtime::VFXPPVignette::SetData(VFXPPVignette *this, VFXPPData *data, MethodInfo *method)
		{
		  __int64 v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2581, 0LL) )
		  {
		    v5 = sub_180005050(data, TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
		    if ( v5 )
		    {
		      this->fields._intensity = *(float *)(v5 + 40);
		      this->fields._color = (Color)_mm_loadu_si128((const __m128i *)(v5 + 24));
		      this->fields._smoothness = *(float *)(v5 + 44);
		      this->fields._rounded = *(_BYTE *)(v5 + 48);
		      this->fields._blink = *(_BYTE *)(v5 + 49);
		      this->fields._.m_priority = *(_DWORD *)(v5 + 16);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2581, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)data,
		    0LL);
		}
		
		public override VFXPPData GetData() => default; // 0x0000000189B66464-0x0000000189B664F0
		// VFXPPData GetData()
		VFXPPData *HG::Rendering::Runtime::VFXPPVignette::GetData(VFXPPVignette *this, MethodInfo *method)
		{
		  VFXPPData *result; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2582, 0LL) )
		  {
		    result = (VFXPPData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
		    if ( result )
		    {
		      result[1].fields.priority = LODWORD(this->fields._intensity);
		      *(__m128i *)&result[1].klass = _mm_loadu_si128((const __m128i *)&this->fields._color);
		      *(&result[1].fields.priority + 1) = LODWORD(this->fields._smoothness);
		      LOBYTE(result[2].klass) = this->fields._rounded;
		      BYTE1(result[2].klass) = this->fields._blink;
		      result->fields.priority = this->fields._.m_priority;
		      return result;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2582, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_946(Patch, (Object *)this, 0LL);
		}
		
		public override VFXPPData GetDefaultData() => default; // 0x0000000189B664F0-0x0000000189B66574
		// VFXPPData GetDefaultData()
		VFXPPData *HG::Rendering::Runtime::VFXPPVignette::GetDefaultData(VFXPPVignette *this, MethodInfo *method)
		{
		  VFXPPData *result; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2583, 0LL) )
		  {
		    result = (VFXPPData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
		    if ( result )
		    {
		      result[1].fields.priority = 0;
		      *(__m128i *)&result[1].klass = _mm_loadu_si128((const __m128i *)&this->fields._color);
		      *(&result[1].fields.priority + 1) = LODWORD(this->fields._smoothness);
		      LOBYTE(result[2].klass) = this->fields._rounded;
		      BYTE1(result[2].klass) = this->fields._blink;
		      result->fields.priority = this->fields._.m_priority;
		      return result;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2583, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_946(Patch, (Object *)this, 0LL);
		}
		
		protected override VFXPPData _GetLerpData(float value) => default; // 0x0000000189B66608-0x0000000189B6673C
		// VFXPPData _GetLerpData(Single)
		VFXPPData *HG::Rendering::Runtime::VFXPPVignette::_GetLerpData(VFXPPVignette *this, float value, MethodInfo *method)
		{
		  float v3; // xmm3_4
		  __int64 v5; // rbx
		  __int64 v6; // rdi
		  __int64 v7; // rdx
		  Beyond::JobMathf *v8; // rcx
		  int v9; // xmm0_4
		  __int128 v10; // xmm0
		  const __m128i *v11; // rax
		  __int64 v12; // r9
		  Beyond::JobMathf *v13; // rcx
		  __int64 v14; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v17; // [rsp+30h] [rbp-48h] BYREF
		  __int128 v18; // [rsp+40h] [rbp-38h] BYREF
		  _BYTE v19[16]; // [rsp+50h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2584, 0LL) )
		  {
		    v5 = sub_180005050(this->fields._.m_snapShotData, TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
		    v6 = sub_180005050(this->fields._.m_targetData, TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData);
		    if ( sub_18002C620(TypeInfo::HG::Rendering::Runtime::VFXPPVignetteData) && v5 && v6 )
		    {
		      v9 = *(_DWORD *)(v5 + 40);
		      *(_DWORD *)(Beyond::JobMathf::ClampedLerp(v8, *(float *)(v6 + 40), value, v3) + 40) = v9;
		      v10 = *(_OWORD *)(v5 + 24);
		      v17 = *(_OWORD *)(v6 + 24);
		      v18 = v10;
		      v11 = (const __m128i *)sub_18374AF40(v19, &v18, &v17);
		      *(__m128i *)(v12 + 24) = _mm_loadu_si128(v11);
		      LODWORD(v10) = *(_DWORD *)(v5 + 44);
		      Beyond::JobMathf::ClampedLerp(v13, *(float *)(v6 + 44), value, value);
		      *(_DWORD *)(v14 + 44) = v10;
		      *(_BYTE *)(v14 + 48) = *(_BYTE *)(v6 + 48);
		      *(_BYTE *)(v14 + 49) = *(_BYTE *)(v6 + 49);
		      *(_DWORD *)(v14 + 16) = *(_DWORD *)(v6 + 16);
		      return (VFXPPData *)v14;
		    }
		LABEL_7:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2584, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_947(Patch, (Object *)this, value, 0LL);
		}
		
		public override void Apply(VolumeProfile volumeProfile) {} // 0x000000018314ED90-0x000000018314F110
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPVignette::Apply(
		        VFXPPVignette *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  _QWORD **monitor; // rcx
		  int *v6; // rdx
		  __int64 (__fastcall *v7)(VFXPPVignette *, int *, MethodInfo *); // rax
		  __int64 v8; // rax
		  __int64 v9; // rbx
		  struct MethodInfo *v10; // rbx
		  RuntimeTypeHandle v11; // rbx
		  Type *TypeFromHandle; // rax
		  struct MethodInfo *v13; // rsi
		  RuntimeTypeHandle v14; // rbx
		  Type *v15; // rbx
		  Il2CppRGCTXData v16; // rdx
		  Object__Class *klass; // rax
		  Object__Class *v18; // rax
		  MonitorData *v19; // rax
		  Object__Class *v20; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v22; // rax
		  Color color; // [rsp+20h] [rbp-18h] BYREF
		  Object *component; // [rsp+58h] [rbp+20h] BYREF
		
		  component = 0LL;
		  monitor = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    monitor = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (int *)*monitor[23];
		  if ( !v6 )
		    goto LABEL_48;
		  if ( v6[6] > 2585 )
		  {
		    if ( !*((_DWORD *)monitor + 56) )
		    {
		      il2cpp_runtime_class_init_1(monitor);
		      monitor = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    monitor = (_QWORD **)*monitor[23];
		    if ( !monitor )
		      goto LABEL_48;
		    if ( *((_DWORD *)monitor + 6) <= 0xA19u )
		      sub_1800D2AB0(monitor, v6);
		    if ( monitor[2589] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2585, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		          (ILFixDynamicMethodWrapper_39 *)Patch,
		          (Object *)this,
		          (Object *)volumeProfile,
		          0LL);
		        return;
		      }
		      goto LABEL_48;
		    }
		  }
		  v7 = (__int64 (__fastcall *)(VFXPPVignette *, int *, MethodInfo *))qword_18F36FBC0;
		  if ( !qword_18F36FBC0 )
		  {
		    v7 = (__int64 (__fastcall *)(VFXPPVignette *, int *, MethodInfo *))il2cpp_resolve_icall_1("UnityEngine.Component::get_transform()");
		    if ( !v7 )
		    {
		      v22 = sub_1802EE1B8("UnityEngine.Component::get_transform()");
		      sub_18007E1B0(v22, 0LL);
		    }
		    qword_18F36FBC0 = (__int64)v7;
		  }
		  v8 = v7(this, v6, method);
		  monitor = (_QWORD **)TypeInfo::UnityEngine::Object;
		  v9 = v8;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    monitor = (_QWORD **)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      monitor = (_QWORD **)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( v9 )
		  {
		    if ( !*((_DWORD *)monitor + 56) )
		      il2cpp_runtime_class_init_1(monitor);
		    if ( *(_QWORD *)(v9 + 16) )
		    {
		      if ( !volumeProfile )
		        goto LABEL_48;
		      v10 = MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGVignette>;
		      if ( !MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGVignette>->rgctx_data )
		        sub_1800430B0(MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGVignette>);
		      v11.value = v10->rgctx_data->rgctxDataDummy;
		      if ( !TypeInfo::System::Type->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::System::Type);
		      TypeFromHandle = System::Type::GetTypeFromHandle(v11, 0LL);
		      if ( !UnityEngine::Rendering::VolumeProfile::Has(volumeProfile, TypeFromHandle, 0LL) )
		        UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
		          volumeProfile,
		          0,
		          MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGVignette>);
		      v13 = MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGVignette>;
		      if ( !MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGVignette>->rgctx_data )
		        sub_1800430B0(MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGVignette>);
		      v14.value = v13->rgctx_data->rgctxDataDummy;
		      if ( !TypeInfo::System::Type->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::System::Type);
		      v15 = System::Type::GetTypeFromHandle(v14, 0LL);
		      v16.rgctxDataDummy = v13->rgctx_data[1].rgctxDataDummy;
		      if ( !*((_QWORD *)v16.rgctxDataDummy + 4) )
		        (*(void (**)(void))v16.rgctxDataDummy)();
		      if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		             volumeProfile,
		             v15,
		             &component,
		             (MethodInfo *)v13->rgctx_data[1].rgctxDataDummy) )
		      {
		        if ( component )
		        {
		          LOBYTE(component[1].monitor) = 1;
		          if ( component )
		          {
		            monitor = (_QWORD **)component[3].monitor;
		            if ( monitor )
		            {
		              *((_BYTE *)monitor + 16) = 1;
		              if ( component )
		              {
		                v6 = (int *)component[3].monitor;
		                if ( v6 )
		                {
		                  sub_180049310(11LL, v6);
		                  if ( component )
		                  {
		                    klass = component[3].klass;
		                    if ( klass )
		                    {
		                      LOBYTE(klass->_0.name) = 1;
		                      if ( component )
		                      {
		                        v6 = (int *)component[3].klass;
		                        if ( v6 )
		                        {
		                          color = this->fields._color;
		                          sub_1800386F0(11LL, v6, &color);
		                          if ( component )
		                          {
		                            v18 = component[4].klass;
		                            if ( v18 )
		                            {
		                              LOBYTE(v18->_0.name) = 1;
		                              if ( component )
		                              {
		                                v6 = (int *)component[4].klass;
		                                if ( v6 )
		                                {
		                                  sub_180049310(11LL, v6);
		                                  if ( component )
		                                  {
		                                    v19 = component[4].monitor;
		                                    if ( v19 )
		                                    {
		                                      *((_BYTE *)v19 + 16) = 1;
		                                      if ( component )
		                                      {
		                                        v6 = (int *)component[4].monitor;
		                                        if ( v6 )
		                                        {
		                                          sub_180043DF0(11LL, v6, this->fields._rounded);
		                                          if ( component )
		                                          {
		                                            v20 = component[5].klass;
		                                            if ( v20 )
		                                            {
		                                              LOBYTE(v20->_0.name) = 1;
		                                              if ( component )
		                                              {
		                                                v6 = (int *)component[5].klass;
		                                                if ( v6 )
		                                                {
		                                                  sub_180043DF0(11LL, v6, this->fields._blink);
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
		LABEL_48:
		        sub_1800D8260(monitor, v6);
		      }
		    }
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x00000001845789F0-0x0000000184578C30
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPVignette::ResetByVolumeProfile(
		        VFXPPVignette *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  struct Object_1__Class *v5; // rcx
		  void *v6; // rdx
		  MonitorData *monitor; // rcx
		  Object__Class *klass; // rax
		  Quaternion *identity; // rax
		  Object__Class *v10; // rax
		  MonitorData *v11; // rax
		  Object__Class *v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Quaternion v14; // [rsp+20h] [rbp-18h] BYREF
		  Object *component; // [rsp+58h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2586, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2586, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)volumeProfile,
		        0LL);
		      return;
		    }
		    goto LABEL_31;
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
		           MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGVignette>) )
		    {
		      if ( component )
		      {
		        LOBYTE(component[1].monitor) = 0;
		        if ( component )
		        {
		          monitor = component[3].monitor;
		          if ( monitor )
		          {
		            *((_BYTE *)monitor + 16) = 0;
		            if ( component )
		            {
		              v6 = component[3].monitor;
		              if ( v6 )
		              {
		                sub_180049310(11LL, v6);
		                if ( component )
		                {
		                  klass = component[3].klass;
		                  if ( klass )
		                  {
		                    LOBYTE(klass->_0.name) = 0;
		                    if ( component )
		                    {
		                      identity = UnityEngine::Quaternion::get_identity(&v14, (MethodInfo *)component[3].klass);
		                      if ( v6 )
		                      {
		                        v14 = *identity;
		                        sub_1800386F0(11LL, v6, &v14);
		                        if ( component )
		                        {
		                          v10 = component[4].klass;
		                          if ( v10 )
		                          {
		                            LOBYTE(v10->_0.name) = 0;
		                            if ( component )
		                            {
		                              v6 = component[4].klass;
		                              if ( v6 )
		                              {
		                                sub_180049310(11LL, v6);
		                                if ( component )
		                                {
		                                  v11 = component[4].monitor;
		                                  if ( v11 )
		                                  {
		                                    *((_BYTE *)v11 + 16) = 0;
		                                    if ( component )
		                                    {
		                                      v6 = component[4].monitor;
		                                      if ( v6 )
		                                      {
		                                        sub_180043DF0(11LL, v6, 0LL);
		                                        if ( component )
		                                        {
		                                          v12 = component[5].klass;
		                                          if ( v12 )
		                                          {
		                                            LOBYTE(v12->_0.name) = 0;
		                                            if ( component )
		                                            {
		                                              v6 = component[5].klass;
		                                              if ( v6 )
		                                              {
		                                                sub_180043DF0(11LL, v6, 0LL);
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
		LABEL_31:
		      sub_1800D8260(monitor, v6);
		    }
		  }
		}
		
		public override bool IsActive() => default; // 0x0000000183EE13F0-0x0000000183EE1460
		// Boolean IsActive()
		bool HG::Rendering::Runtime::VFXPPVignette::IsActive(VFXPPVignette *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
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
		  if ( wrapperArray->max_length.size <= 2587 )
		    return this->fields._intensity != 0.0;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0xA1B )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[55]._0.this_arg.data.dummy )
		    return this->fields._intensity != 0.0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2587, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
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
