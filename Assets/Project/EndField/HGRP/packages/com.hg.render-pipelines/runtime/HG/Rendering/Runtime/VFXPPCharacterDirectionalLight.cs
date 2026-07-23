using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPCharacterDirectionalLight(\u89D2\u8272\u81EA\u5B9A\u4E49\u65B9\u5411\u5149)")]
	[ExecuteInEditMode]
	public class VFXPPCharacterDirectionalLight : VFXPPComponent // TypeDefIndex: 37939
	{
		// Fields
		[SerializeField]
		private UnityEngine.Color m_LightColor; // 0x48
		[SerializeField]
		private ColorParameter m_SkinLightColorParameter; // 0x58
		[Range(0f, 10f)]
		[SerializeField]
		[Space]
		private float m_Intensity; // 0x60
		[Range(0f, 2f)]
		[SerializeField]
		private float m_Contrast; // 0x64
		[Range(0f, 2f)]
		[SerializeField]
		private float m_SpecularIntensity; // 0x68
		[Range(-1f, 1f)]
		[SerializeField]
		private float m_RampBias; // 0x6C
		[Header("\u6295\u5F71\u63A7\u5236")]
		[SerializeField]
		private bool m_SelfShadowRealisticMode; // 0x70
		[SerializeField]
		private bool m_IgnoreSceneShadow; // 0x71
		[Header("\u9634\u5F71\u989C\u8272")]
		[SerializeField]
		private bool m_CustomShadowTint; // 0x72
		[SerializeField]
		private UnityEngine.Color m_CustomShadowTintColor; // 0x74
		[SerializeField]
		private UnityEngine.Color m_CustomShadowSkinTintColor; // 0x84
		[Header("\u773C\u775B\u5149\u7167")]
		[Range(0f, 3f)]
		[SerializeField]
		private float m_EyeBaselight; // 0x94
		[Range(0f, 3f)]
		[SerializeField]
		private float m_EyeHightlight; // 0x98
		[Range(0f, 3f)]
		[SerializeField]
		private float m_EyeScatterlight; // 0x9C
		[Header("\u591A\u5149\u6E90\u63A7\u5236")]
		[SerializeField]
		private bool m_IgnoreSceneAdditionalLights; // 0xA0
		[Header("Env\u63A7\u5236")]
		[SerializeField]
		private bool m_IgnoreSceneEnv; // 0xA1
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000184A35550-0x0000000184A35580 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPCharacterDirectionalLight::get_m_VFXPPType(
		        VFXPPCharacterDirectionalLight *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2428, 0LL) )
		    return 11;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2428, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPCharacterDirectionalLight() {} // 0x00000001844D8DA0-0x00000001844D8E60
		// VFXPPCharacterDirectionalLight()
		void HG::Rendering::Runtime::VFXPPCharacterDirectionalLight::VFXPPCharacterDirectionalLight(
		        VFXPPCharacterDirectionalLight *this,
		        MethodInfo *method)
		{
		  MethodInfo *v3; // rdx
		  __int64 v4; // rax
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  __int64 v6; // rcx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  Vector4 v9; // xmm0
		  MethodInfo *v10; // rdx
		  MethodInfo *v11; // rdx
		  Vector4 v12; // xmm1
		  Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
		
		  this->fields.m_LightColor = (Color)*UnityEngine::Vector4::get_one(&v13, method);
		  v13 = *UnityEngine::Vector4::get_one(&v13, v3);
		  v4 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v4 )
		    sub_1800D8260(v6, v5);
		  v9 = v13;
		  *(_WORD *)(v4 + 41) = 257;
		  *(_BYTE *)(v4 + 16) = 0;
		  *(Vector4 *)(v4 + 24) = v9;
		  this->fields.m_SkinLightColorParameter = (ColorParameter *)v4;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_SkinLightColorParameter, v5, v7, v8, *(MethodInfo **)&v13.x);
		  this->fields.m_Intensity = 1.0;
		  this->fields.m_Contrast = 0.5;
		  this->fields.m_SpecularIntensity = 1.0;
		  this->fields.m_IgnoreSceneShadow = 1;
		  this->fields.m_CustomShadowTintColor = (Color)*UnityEngine::Vector4::get_one(&v13, v10);
		  v12 = *UnityEngine::Vector4::get_one(&v13, v11);
		  this->fields._.m_targetEnable = 1;
		  this->fields.m_CustomShadowSkinTintColor = (Color)v12;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		public override void Apply(VolumeProfile volumeProfile) {} // 0x0000000184127F10-0x0000000184128410
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPCharacterDirectionalLight::Apply(
		        VFXPPCharacterDirectionalLight *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  Transform *transform; // rax
		  _BOOL8 overrideState; // rdx
		  __int64 m_IgnoreSceneShadow; // rcx
		  Transform *v8; // rsi
		  Object__Class *klass; // rax
		  ColorParameter *m_SkinLightColorParameter; // rax
		  ColorParameter *v11; // r8
		  Object__Class *v12; // rdi
		  __int128 *v13; // rax
		  MonitorData *monitor; // rax
		  MonitorData *v15; // rax
		  Color m_LightColor; // xmm0
		  Object__Class *v17; // rax
		  Object__Class *v18; // rax
		  Object__Class *v19; // rax
		  MonitorData *v20; // rax
		  MonitorData *v21; // rdi
		  Transform *v22; // rax
		  MonitorData *v23; // rax
		  Object__Class *v24; // rax
		  Color m_CustomShadowTintColor; // xmm0
		  Color m_CustomShadowSkinTintColor; // xmm1
		  MonitorData *v27; // rax
		  Object__Class *v28; // rax
		  MonitorData *v29; // rax
		  Object__Class *v30; // rax
		  MonitorData *v31; // rax
		  MonitorData *v32; // rax
		  Object__Class *v33; // rax
		  MonitorData *v34; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v36; // [rsp+20h] [rbp-20h]
		  __int128 v37; // [rsp+30h] [rbp-10h] BYREF
		  Object *component; // [rsp+68h] [rbp+28h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2429, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2429, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)volumeProfile,
		        0LL);
		      return;
		    }
		    goto LABEL_59;
		  }
		  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		  m_IgnoreSceneShadow = (__int64)TypeInfo::UnityEngine::Object;
		  v8 = transform;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    m_IgnoreSceneShadow = (__int64)TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      m_IgnoreSceneShadow = (__int64)TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( v8 )
		  {
		    if ( !*(_DWORD *)(m_IgnoreSceneShadow + 224) )
		      il2cpp_runtime_class_init_1(m_IgnoreSceneShadow);
		    if ( v8->fields._._.m_CachedPtr )
		    {
		      if ( !volumeProfile )
		        goto LABEL_59;
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
		            klass = component[12].klass;
		            if ( klass )
		            {
		              LOBYTE(klass->_0.name) = 1;
		              LODWORD(klass->_0.namespaze) = 2;
		              if ( component )
		              {
		                m_IgnoreSceneShadow = (__int64)component[14].klass;
		                m_SkinLightColorParameter = this->fields.m_SkinLightColorParameter;
		                if ( m_SkinLightColorParameter )
		                {
		                  overrideState = m_SkinLightColorParameter->fields._._.overrideState;
		                  if ( m_IgnoreSceneShadow )
		                  {
		                    *(_BYTE *)(m_IgnoreSceneShadow + 16) = overrideState;
		                    if ( component )
		                    {
		                      v11 = this->fields.m_SkinLightColorParameter;
		                      v12 = component[14].klass;
		                      if ( v11 )
		                      {
		                        v13 = (__int128 *)sub_180032E40(&v37, 10LL, v11);
		                        if ( v12 )
		                        {
		                          v37 = *v13;
		                          sub_1800386F0(11LL, v12, &v37);
		                          if ( component )
		                          {
		                            monitor = component[11].monitor;
		                            m_IgnoreSceneShadow = this->fields.m_IgnoreSceneShadow;
		                            if ( monitor )
		                            {
		                              *((_BYTE *)monitor + 16) = 1;
		                              *((_BYTE *)monitor + 24) = m_IgnoreSceneShadow;
		                              if ( component )
		                              {
		                                v15 = component[13].monitor;
		                                if ( v15 )
		                                {
		                                  m_LightColor = this->fields.m_LightColor;
		                                  *((_BYTE *)v15 + 16) = 1;
		                                  *(Color *)((char *)v15 + 24) = m_LightColor;
		                                  if ( component )
		                                  {
		                                    v17 = component[9].klass;
		                                    if ( v17 )
		                                    {
		                                      *(float *)&v17->_0.namespaze = this->fields.m_SpecularIntensity;
		                                      LOBYTE(v17->_0.name) = 1;
		                                      if ( component )
		                                      {
		                                        v18 = component[11].klass;
		                                        if ( v18 )
		                                        {
		                                          *(float *)&v18->_0.namespaze = this->fields.m_RampBias;
		                                          LOBYTE(v18->_0.name) = 1;
		                                          if ( component )
		                                          {
		                                            v19 = component[8].klass;
		                                            if ( v19 )
		                                            {
		                                              *(float *)&v19->_0.namespaze = this->fields.m_Contrast;
		                                              LOBYTE(v19->_0.name) = 1;
		                                              if ( component )
		                                              {
		                                                v20 = component[7].monitor;
		                                                if ( v20 )
		                                                {
		                                                  *((_DWORD *)v20 + 6) = LODWORD(this->fields.m_Intensity);
		                                                  *((_BYTE *)v20 + 16) = 1;
		                                                  if ( component )
		                                                  {
		                                                    v21 = component[12].monitor;
		                                                    v22 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		                                                    if ( v22 )
		                                                    {
		                                                      v36 = *(_QWORD *)&UnityEngine::Transform::get_eulerAngles(
		                                                                          (Vector3 *)&v37,
		                                                                          v22,
		                                                                          0LL)->x;
		                                                      if ( v21 )
		                                                      {
		                                                        *((_QWORD *)v21 + 3) = v36;
		                                                        *((_BYTE *)v21 + 16) = 1;
		                                                        if ( component )
		                                                        {
		                                                          m_IgnoreSceneShadow = 1LL;
		                                                          overrideState = !this->fields.m_SelfShadowRealisticMode;
		                                                          v23 = component[16].monitor;
		                                                          if ( v23 )
		                                                          {
		                                                            *((_BYTE *)v23 + 16) = 1;
		                                                            *((_DWORD *)v23 + 6) = overrideState;
		                                                            m_IgnoreSceneShadow = this->fields.m_IgnoreSceneShadow;
		                                                            if ( component )
		                                                            {
		                                                              v24 = component[15].klass;
		                                                              if ( v24 )
		                                                              {
		                                                                LOBYTE(v24->_0.name) = 1;
		                                                                LODWORD(v24->_0.namespaze) = m_IgnoreSceneShadow;
		                                                                if ( this->fields.m_CustomShadowTint )
		                                                                {
		                                                                  m_CustomShadowTintColor = this->fields.m_CustomShadowTintColor;
		                                                                  m_CustomShadowSkinTintColor = this->fields.m_CustomShadowSkinTintColor;
		                                                                }
		                                                                else
		                                                                {
		                                                                  m_CustomShadowTintColor = this->fields.m_LightColor;
		                                                                  m_CustomShadowSkinTintColor = m_CustomShadowTintColor;
		                                                                }
		                                                                if ( component )
		                                                                {
		                                                                  v27 = component[15].monitor;
		                                                                  if ( v27 )
		                                                                  {
		                                                                    *((_BYTE *)v27 + 16) = 1;
		                                                                    *(Color *)((char *)v27 + 24) = m_CustomShadowTintColor;
		                                                                    if ( component )
		                                                                    {
		                                                                      v28 = component[16].klass;
		                                                                      if ( v28 )
		                                                                      {
		                                                                        LOBYTE(v28->_0.name) = 1;
		                                                                        *(Color *)&v28->_0.namespaze = m_CustomShadowSkinTintColor;
		                                                                        if ( component )
		                                                                        {
		                                                                          v29 = component[25].monitor;
		                                                                          m_IgnoreSceneShadow = this->fields.m_IgnoreSceneAdditionalLights;
		                                                                          if ( v29 )
		                                                                          {
		                                                                            *((_BYTE *)v29 + 16) = 1;
		                                                                            *((_BYTE *)v29 + 24) = m_IgnoreSceneShadow;
		                                                                            if ( component )
		                                                                            {
		                                                                              v30 = component[26].klass;
		                                                                              m_IgnoreSceneShadow = this->fields.m_IgnoreSceneEnv;
		                                                                              if ( v30 )
		                                                                              {
		                                                                                LOBYTE(v30->_0.name) = 1;
		                                                                                LOBYTE(v30->_0.namespaze) = m_IgnoreSceneShadow;
		                                                                                if ( component )
		                                                                                {
		                                                                                  v31 = component[14].monitor;
		                                                                                  if ( v31 )
		                                                                                  {
		                                                                                    *((_BYTE *)v31 + 16) = 1;
		                                                                                    *((_BYTE *)v31 + 24) = 0;
		                                                                                    if ( component )
		                                                                                    {
		                                                                                      v32 = component[9].monitor;
		                                                                                      if ( v32 )
		                                                                                      {
		                                                                                        *((_DWORD *)v32 + 6) = LODWORD(this->fields.m_EyeBaselight);
		                                                                                        *((_BYTE *)v32 + 16) = 1;
		                                                                                        if ( component )
		                                                                                        {
		                                                                                          v33 = component[10].klass;
		                                                                                          if ( v33 )
		                                                                                          {
		                                                                                            *(float *)&v33->_0.namespaze = this->fields.m_EyeHightlight;
		                                                                                            LOBYTE(v33->_0.name) = 1;
		                                                                                            if ( component )
		                                                                                            {
		                                                                                              v34 = component[10].monitor;
		                                                                                              if ( v34 )
		                                                                                              {
		                                                                                                *((_DWORD *)v34 + 6) = LODWORD(this->fields.m_EyeScatterlight);
		                                                                                                *((_BYTE *)v34 + 16) = 1;
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
		LABEL_59:
		        sub_1800D8260(m_IgnoreSceneShadow, overrideState);
		      }
		    }
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000184127BE0-0x0000000184127F10
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPCharacterDirectionalLight::ResetByVolumeProfile(
		        VFXPPCharacterDirectionalLight *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  struct Object_1__Class *v5; // rcx
		  __int64 v6; // rdx
		  _BYTE *klass; // rcx
		  MonitorData *monitor; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Object *component; // [rsp+48h] [rbp+20h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2430, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2430, 0LL);
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
		        klass = component[12].klass;
		        if ( klass )
		        {
		          klass[16] = 0;
		          if ( component )
		          {
		            klass = component[14].klass;
		            if ( klass )
		            {
		              klass[16] = 0;
		              if ( component )
		              {
		                klass = component[11].monitor;
		                if ( klass )
		                {
		                  klass[16] = 0;
		                  if ( component )
		                  {
		                    klass = component[13].monitor;
		                    if ( klass )
		                    {
		                      klass[16] = 0;
		                      if ( component )
		                      {
		                        klass = component[11].klass;
		                        if ( klass )
		                        {
		                          klass[16] = 0;
		                          if ( component )
		                          {
		                            klass = component[7].monitor;
		                            if ( klass )
		                            {
		                              klass[16] = 0;
		                              if ( component )
		                              {
		                                klass = component[8].klass;
		                                if ( klass )
		                                {
		                                  klass[16] = 0;
		                                  if ( component )
		                                  {
		                                    klass = component[9].klass;
		                                    if ( klass )
		                                    {
		                                      klass[16] = 0;
		                                      if ( component )
		                                      {
		                                        klass = component[12].monitor;
		                                        if ( klass )
		                                        {
		                                          klass[16] = 0;
		                                          if ( component )
		                                          {
		                                            klass = component[16].monitor;
		                                            if ( klass )
		                                            {
		                                              klass[16] = 0;
		                                              if ( component )
		                                              {
		                                                klass = component[15].klass;
		                                                if ( klass )
		                                                {
		                                                  klass[16] = 0;
		                                                  if ( component )
		                                                  {
		                                                    klass = component[15].monitor;
		                                                    if ( klass )
		                                                    {
		                                                      klass[16] = 0;
		                                                      if ( component )
		                                                      {
		                                                        klass = component[16].klass;
		                                                        if ( klass )
		                                                        {
		                                                          klass[16] = 0;
		                                                          if ( component )
		                                                          {
		                                                            klass = component[25].monitor;
		                                                            if ( klass )
		                                                            {
		                                                              klass[16] = 0;
		                                                              if ( component )
		                                                              {
		                                                                klass = component[26].klass;
		                                                                if ( klass )
		                                                                {
		                                                                  klass[16] = 0;
		                                                                  if ( component )
		                                                                  {
		                                                                    klass = component[14].monitor;
		                                                                    if ( klass )
		                                                                    {
		                                                                      klass[16] = 0;
		                                                                      if ( component )
		                                                                      {
		                                                                        klass = component[9].monitor;
		                                                                        if ( klass )
		                                                                        {
		                                                                          klass[16] = 0;
		                                                                          if ( component )
		                                                                          {
		                                                                            klass = component[10].klass;
		                                                                            if ( klass )
		                                                                            {
		                                                                              klass[16] = 0;
		                                                                              if ( component )
		                                                                              {
		                                                                                monitor = component[10].monitor;
		                                                                                if ( monitor )
		                                                                                {
		                                                                                  *((_BYTE *)monitor + 16) = 0;
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
