using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPBlackBox(\u9ED1\u76D2\u7279\u6548)")]
	[ExecuteInEditMode]
	public class VFXPPBlackBox : VFXPPComponent // TypeDefIndex: 37936
	{
		// Fields
		[SerializeField]
		[Space(10f)]
		private bool _useBlackBox; // 0x48
		[ColorUsage(true, true)]
		[SerializeField]
		[Space(5f)]
		private UnityEngine.Color _blendColor; // 0x4C
		[Range(0f, 100f)]
		[SerializeField]
		private float _blendWidth; // 0x5C
		private float _blendRadius; // 0x60
		[Range(0f, 1f)]
		[SerializeField]
		private float _blendProgress; // 0x64
		[Range(0f, 100f)]
		[SerializeField]
		[Space(5f)]
		private float _contourRangeWidth; // 0x68
		private float _contourRangeRadius; // 0x6C
		[Range(0f, 1f)]
		[SerializeField]
		private float _contourRangeProgress; // 0x70
		[ColorUsage(true, true)]
		[SerializeField]
		private UnityEngine.Color _contourColor; // 0x74
		[SerializeField]
		[Space(5f)]
		private Texture2D _contourTexture; // 0x88
		[Header("\u7B49\u9AD8\u7EBF")]
		[SerializeField]
		private Vector2 _contourTexTiling; // 0x90
		[SerializeField]
		private Vector2 _contourTexUVSpeed; // 0x98
		[Header("\u6270\u52A8")]
		[SerializeField]
		private bool _useDisturb; // 0xA0
		[SerializeField]
		private Vector2 _disturbIntensity; // 0xA4
		[SerializeField]
		private Vector2 _disturbTexTiling; // 0xAC
		[SerializeField]
		private Vector2 _disturbTexUVSpeed; // 0xB4
		[Header("\u906E\u7F69")]
		[SerializeField]
		private bool _useMask; // 0xBC
		[SerializeField]
		private bool _useMaskAsAlpha; // 0xBD
		[SerializeField]
		private Vector2 _maskTexTiling; // 0xC0
		[SerializeField]
		private Vector2 _maskTexUVSpeed; // 0xC8
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000189B5EA0C-0x0000000189B5EA5C 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPBlackBox::get_m_VFXPPType(VFXPPBlackBox *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2416, 0LL) )
		    return 13;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2416, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPBlackBox() {} // 0x0000000189B5E99C-0x0000000189B5EA0C
		// VFXPPBlackBox()
		void HG::Rendering::Runtime::VFXPPBlackBox::VFXPPBlackBox(VFXPPBlackBox *this, MethodInfo *method)
		{
		  this->fields._useDisturb = 1;
		  this->fields._contourTexTiling.x = 20.0;
		  this->fields._blendRadius = 500.0;
		  this->fields._contourRangeRadius = 500.0;
		  *(_QWORD *)&this->fields._contourTexTiling.y = 1101004800LL;
		  this->fields._disturbTexTiling.x = 20.0;
		  *(_QWORD *)&this->fields._disturbTexTiling.y = 1101004800LL;
		  this->fields._maskTexTiling.x = 20.0;
		  *(_QWORD *)&this->fields._maskTexTiling.y = 1101004800LL;
		  this->fields._contourTexUVSpeed.y = 0.0;
		  this->fields._disturbIntensity = 0LL;
		  this->fields._disturbTexUVSpeed.y = 0.0;
		  this->fields._maskTexUVSpeed.y = 0.0;
		  *(_WORD *)&this->fields._useMask = 257;
		  this->fields._.m_targetEnable = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		public override void Apply(VolumeProfile volumeProfile) {} // 0x0000000189B5D9D0-0x0000000189B5E1B0
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPBlackBox::Apply(
		        VFXPPBlackBox *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  Object_1 *transform; // rbx
		  void *v6; // rdx
		  Object__Class *klass; // rcx
		  __int64 v8; // r8
		  __int64 v9; // r8
		  MonitorData *monitor; // rax
		  Object__Class *v11; // rax
		  Object__Class *v12; // rbx
		  Transform *v13; // rax
		  Vector3 *position; // rax
		  __int64 v15; // xmm0_8
		  MethodInfo *v16; // r8
		  Vector4 *v17; // rax
		  MonitorData *v18; // rax
		  Object__Class *v19; // rax
		  MonitorData *v20; // rax
		  Object__Class *v21; // rax
		  MonitorData *v22; // rax
		  Object__Class *v23; // rax
		  MonitorData *v24; // rax
		  Object__Class *v25; // rax
		  MonitorData *v26; // rax
		  Object__Class *v27; // rax
		  MonitorData *v28; // rax
		  Object__Class *v29; // rax
		  Object__Class *v30; // rax
		  MonitorData *v31; // rax
		  MonitorData *v32; // rax
		  Object__Class *v33; // rax
		  __int64 v34; // r8
		  MonitorData *v35; // rax
		  __int64 v36; // r8
		  Object__Class *v37; // rax
		  __int64 v38; // r8
		  MonitorData *v39; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v41; // [rsp+20h] [rbp-20h] BYREF
		  Color blendColor; // [rsp+30h] [rbp-10h] BYREF
		  Object *component; // [rsp+68h] [rbp+28h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2417, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2417, 0LL);
		    if ( !Patch )
		      goto LABEL_99;
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
		      goto LABEL_99;
		    if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
		            volumeProfile,
		            MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGBlackBox>) )
		      UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
		        volumeProfile,
		        0,
		        MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGBlackBox>);
		    if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		           volumeProfile,
		           &component,
		           MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGBlackBox>) )
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
		                        LOBYTE(v9) = 1;
		                        sub_180043DF0(11LL, v6, v9);
		                        if ( component )
		                        {
		                          v11 = component[4].klass;
		                          if ( v11 )
		                          {
		                            LOBYTE(v11->_0.name) = 1;
		                            if ( component )
		                            {
		                              v12 = component[4].klass;
		                              v13 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		                              if ( v13 )
		                              {
		                                position = UnityEngine::Transform::get_position((Vector3 *)&blendColor, v13, 0LL);
		                                v15 = *(_QWORD *)&position->x;
		                                *(float *)&position = position->z;
		                                *(_QWORD *)&v41.x = v15;
		                                LODWORD(v41.z) = (_DWORD)position;
		                                v17 = UnityEngine::Vector4::op_Implicit((Vector4 *)&blendColor, &v41, v16);
		                                if ( v12 )
		                                {
		                                  blendColor = (Color)*v17;
		                                  sub_1804E3628(11LL, v12, &blendColor);
		                                  if ( component )
		                                  {
		                                    v18 = component[4].monitor;
		                                    if ( v18 )
		                                    {
		                                      *((_BYTE *)v18 + 16) = 1;
		                                      if ( component )
		                                      {
		                                        v6 = component[4].monitor;
		                                        if ( v6 )
		                                        {
		                                          blendColor = this->fields._blendColor;
		                                          sub_1800386F0(11LL, v6, &blendColor);
		                                          if ( component )
		                                          {
		                                            v19 = component[5].klass;
		                                            if ( v19 )
		                                            {
		                                              LOBYTE(v19->_0.name) = 1;
		                                              if ( component )
		                                              {
		                                                v6 = component[5].klass;
		                                                if ( v6 )
		                                                {
		                                                  sub_180049310(11LL, v6);
		                                                  if ( component )
		                                                  {
		                                                    v20 = component[5].monitor;
		                                                    if ( v20 )
		                                                    {
		                                                      *((_BYTE *)v20 + 16) = 1;
		                                                      if ( component )
		                                                      {
		                                                        v6 = component[5].monitor;
		                                                        if ( v6 )
		                                                        {
		                                                          sub_180049310(11LL, v6);
		                                                          if ( component )
		                                                          {
		                                                            v21 = component[6].klass;
		                                                            if ( v21 )
		                                                            {
		                                                              LOBYTE(v21->_0.name) = 1;
		                                                              if ( component )
		                                                              {
		                                                                v6 = component[6].klass;
		                                                                if ( v6 )
		                                                                {
		                                                                  sub_180049310(11LL, v6);
		                                                                  if ( component )
		                                                                  {
		                                                                    v22 = component[6].monitor;
		                                                                    if ( v22 )
		                                                                    {
		                                                                      *((_BYTE *)v22 + 16) = 1;
		                                                                      if ( component )
		                                                                      {
		                                                                        v6 = component[6].monitor;
		                                                                        if ( v6 )
		                                                                        {
		                                                                          blendColor = this->fields._contourColor;
		                                                                          sub_1800386F0(11LL, v6, &blendColor);
		                                                                          if ( component )
		                                                                          {
		                                                                            v23 = component[7].klass;
		                                                                            if ( v23 )
		                                                                            {
		                                                                              LOBYTE(v23->_0.name) = 1;
		                                                                              if ( component )
		                                                                              {
		                                                                                v6 = component[7].klass;
		                                                                                if ( v6 )
		                                                                                {
		                                                                                  sub_180049310(11LL, v6);
		                                                                                  if ( component )
		                                                                                  {
		                                                                                    v24 = component[7].monitor;
		                                                                                    if ( v24 )
		                                                                                    {
		                                                                                      *((_BYTE *)v24 + 16) = 1;
		                                                                                      if ( component )
		                                                                                      {
		                                                                                        v6 = component[7].monitor;
		                                                                                        if ( v6 )
		                                                                                        {
		                                                                                          sub_180049310(11LL, v6);
		                                                                                          if ( component )
		                                                                                          {
		                                                                                            v25 = component[8].klass;
		                                                                                            if ( v25 )
		                                                                                            {
		                                                                                              LOBYTE(v25->_0.name) = 1;
		                                                                                              if ( component )
		                                                                                              {
		                                                                                                v6 = component[8].klass;
		                                                                                                if ( v6 )
		                                                                                                {
		                                                                                                  sub_180049310(
		                                                                                                    11LL,
		                                                                                                    v6);
		                                                                                                  if ( component )
		                                                                                                  {
		                                                                                                    v26 = component[8].monitor;
		                                                                                                    if ( v26 )
		                                                                                                    {
		                                                                                                      *((_BYTE *)v26 + 16) = 1;
		                                                                                                      if ( component )
		                                                                                                      {
		                                                                                                        v6 = component[8].monitor;
		                                                                                                        if ( v6 )
		                                                                                                        {
		                                                                                                          sub_18003BA30(klass, v6, this->fields._contourTexture);
		                                                                                                          if ( component )
		                                                                                                          {
		                                                                                                            v27 = component[9].klass;
		                                                                                                            if ( v27 )
		                                                                                                            {
		                                                                                                              LOBYTE(v27->_0.name) = 1;
		                                                                                                              if ( component )
		                                                                                                              {
		                                                                                                                v6 = component[9].klass;
		                                                                                                                if ( v6 )
		                                                                                                                {
		                                                                                                                  sub_1800A2570(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this->fields._contourTexTiling.x), (__m128)LODWORD(this->fields._contourTexTiling.y)).m128_u64[0]);
		                                                                                                                  if ( component )
		                                                                                                                  {
		                                                                                                                    v28 = component[9].monitor;
		                                                                                                                    if ( v28 )
		                                                                                                                    {
		                                                                                                                      *((_BYTE *)v28 + 16) = 1;
		                                                                                                                      if ( component )
		                                                                                                                      {
		                                                                                                                        v6 = component[9].monitor;
		                                                                                                                        if ( v6 )
		                                                                                                                        {
		                                                                                                                          sub_1800A2570(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this->fields._contourTexUVSpeed.x), (__m128)LODWORD(this->fields._contourTexUVSpeed.y)).m128_u64[0]);
		                                                                                                                          if ( component )
		                                                                                                                          {
		                                                                                                                            v29 = component[11].klass;
		                                                                                                                            if ( v29 )
		                                                                                                                            {
		                                                                                                                              LOBYTE(v29->_0.name) = 1;
		                                                                                                                              if ( component )
		                                                                                                                              {
		                                                                                                                                v6 = component[11].klass;
		                                                                                                                                if ( v6 )
		                                                                                                                                {
		                                                                                                                                  sub_1800A2570(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this->fields._disturbIntensity.x), (__m128)LODWORD(this->fields._disturbIntensity.y)).m128_u64[0]);
		                                                                                                                                  if ( component )
		                                                                                                                                  {
		                                                                                                                                    v30 = component[10].klass;
		                                                                                                                                    if ( v30 )
		                                                                                                                                    {
		                                                                                                                                      LOBYTE(v30->_0.name) = 1;
		                                                                                                                                      if ( component )
		                                                                                                                                      {
		                                                                                                                                        v6 = component[10].klass;
		                                                                                                                                        if ( v6 )
		                                                                                                                                        {
		                                                                                                                                          sub_1800A2570(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this->fields._disturbTexTiling.x), (__m128)LODWORD(this->fields._disturbTexTiling.y)).m128_u64[0]);
		                                                                                                                                          if ( component )
		                                                                                                                                          {
		                                                                                                                                            v31 = component[10].monitor;
		                                                                                                                                            if ( v31 )
		                                                                                                                                            {
		                                                                                                                                              *((_BYTE *)v31 + 16) = 1;
		                                                                                                                                              if ( component )
		                                                                                                                                              {
		                                                                                                                                                v6 = component[10].monitor;
		                                                                                                                                                if ( v6 )
		                                                                                                                                                {
		                                                                                                                                                  sub_1800A2570(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this->fields._disturbTexUVSpeed.x), (__m128)LODWORD(this->fields._disturbTexUVSpeed.y)).m128_u64[0]);
		                                                                                                                                                  if ( component )
		                                                                                                                                                  {
		                                                                                                                                                    v32 = component[11].monitor;
		                                                                                                                                                    if ( v32 )
		                                                                                                                                                    {
		                                                                                                                                                      *((_BYTE *)v32 + 16) = 1;
		                                                                                                                                                      if ( component )
		                                                                                                                                                      {
		                                                                                                                                                        v6 = component[11].monitor;
		                                                                                                                                                        if ( v6 )
		                                                                                                                                                        {
		                                                                                                                                                          sub_1800A2570(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this->fields._maskTexTiling.x), (__m128)LODWORD(this->fields._maskTexTiling.y)).m128_u64[0]);
		                                                                                                                                                          if ( component )
		                                                                                                                                                          {
		                                                                                                                                                            v33 = component[12].klass;
		                                                                                                                                                            if ( v33 )
		                                                                                                                                                            {
		                                                                                                                                                              LOBYTE(v33->_0.name) = 1;
		                                                                                                                                                              if ( component )
		                                                                                                                                                              {
		                                                                                                                                                                v6 = component[12].klass;
		                                                                                                                                                                if ( v6 )
		                                                                                                                                                                {
		                                                                                                                                                                  sub_1800A2570(11LL, v6, _mm_unpacklo_ps((__m128)LODWORD(this->fields._maskTexUVSpeed.x), (__m128)LODWORD(this->fields._maskTexUVSpeed.y)).m128_u64[0]);
		                                                                                                                                                                  if ( component )
		                                                                                                                                                                  {
		                                                                                                                                                                    v35 = component[12].monitor;
		                                                                                                                                                                    if ( v35 )
		                                                                                                                                                                    {
		                                                                                                                                                                      *((_BYTE *)v35 + 16) = 1;
		                                                                                                                                                                      if ( component )
		                                                                                                                                                                      {
		                                                                                                                                                                        v6 = component[12].monitor;
		                                                                                                                                                                        if ( v6 )
		                                                                                                                                                                        {
		                                                                                                                                                                          LOBYTE(v34) = this->fields._useDisturb;
		                                                                                                                                                                          sub_180043DF0(11LL, v6, v34);
		                                                                                                                                                                          if ( component )
		                                                                                                                                                                          {
		                                                                                                                                                                            v37 = component[13].klass;
		                                                                                                                                                                            if ( v37 )
		                                                                                                                                                                            {
		                                                                                                                                                                              LOBYTE(v37->_0.name) = 1;
		                                                                                                                                                                              if ( component )
		                                                                                                                                                                              {
		                                                                                                                                                                                v6 = component[13].klass;
		                                                                                                                                                                                if ( v6 )
		                                                                                                                                                                                {
		                                                                                                                                                                                  LOBYTE(v36) = this->fields._useMask;
		                                                                                                                                                                                  sub_180043DF0(11LL, v6, v36);
		                                                                                                                                                                                  if ( component )
		                                                                                                                                                                                  {
		                                                                                                                                                                                    v39 = component[13].monitor;
		                                                                                                                                                                                    if ( v39 )
		                                                                                                                                                                                    {
		                                                                                                                                                                                      *((_BYTE *)v39 + 16) = 1;
		                                                                                                                                                                                      if ( component )
		                                                                                                                                                                                      {
		                                                                                                                                                                                        v6 = component[13].monitor;
		                                                                                                                                                                                        if ( v6 )
		                                                                                                                                                                                        {
		                                                                                                                                                                                          LOBYTE(v38) = this->fields._useMaskAsAlpha;
		                                                                                                                                                                                          sub_180043DF0(11LL, v6, v38);
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
		        }
		      }
		LABEL_99:
		      sub_1800D8260(klass, v6);
		    }
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000189B5E1FC-0x0000000189B5E928
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPBlackBox::ResetByVolumeProfile(
		        VFXPPBlackBox *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  void *v5; // rdx
		  Object__Class *klass; // rcx
		  MonitorData *monitor; // rax
		  Vector3Int *v8; // r8
		  ITilemap *v9; // r9
		  Object__Class *v10; // rax
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  MonitorData *v12; // rax
		  Quaternion *identity; // rax
		  Object__Class *v14; // rax
		  MonitorData *v15; // rax
		  Object__Class *v16; // rax
		  MonitorData *v17; // rax
		  Quaternion *v18; // rax
		  Object__Class *v19; // rax
		  MonitorData *v20; // rax
		  Object__Class *v21; // rax
		  MonitorData *v22; // rax
		  Object__Class *v23; // rax
		  MonitorData *v24; // rax
		  Object__Class *v25; // rax
		  Object__Class *v26; // rax
		  MonitorData *v27; // rax
		  MonitorData *v28; // rax
		  Object__Class *v29; // rax
		  MonitorData *v30; // rax
		  Object__Class *v31; // rax
		  MonitorData *v32; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Quaternion v34; // [rsp+20h] [rbp-30h] BYREF
		  Object *component; // [rsp+78h] [rbp+28h] BYREF
		
		  component = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2418, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
		      return;
		    if ( volumeProfile )
		    {
		      if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		              volumeProfile,
		              &component,
		              MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGBlackBox>) )
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
		                        sub_180043DF0(11LL, v5, 0LL);
		                        if ( component )
		                        {
		                          v10 = component[4].klass;
		                          if ( v10 )
		                          {
		                            LOBYTE(v10->_0.name) = 0;
		                            if ( component )
		                            {
		                              TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                         (TileAnimationData *)&v34,
		                                                         (TileBase *)component[4].klass,
		                                                         v8,
		                                                         v9,
		                                                         *(MethodInfo **)&v34.x);
		                              if ( v5 )
		                              {
		                                v34 = (Quaternion)*TileAnimationDataNoRef;
		                                sub_1804E3628(11LL, v5, &v34);
		                                if ( component )
		                                {
		                                  v12 = component[4].monitor;
		                                  if ( v12 )
		                                  {
		                                    *((_BYTE *)v12 + 16) = 0;
		                                    if ( component )
		                                    {
		                                      identity = UnityEngine::Quaternion::get_identity(
		                                                   &v34,
		                                                   (MethodInfo *)component[4].monitor);
		                                      if ( v5 )
		                                      {
		                                        v34 = *identity;
		                                        sub_1800386F0(11LL, v5, &v34);
		                                        if ( component )
		                                        {
		                                          v14 = component[5].klass;
		                                          if ( v14 )
		                                          {
		                                            LOBYTE(v14->_0.name) = 0;
		                                            if ( component )
		                                            {
		                                              v5 = component[5].klass;
		                                              if ( v5 )
		                                              {
		                                                sub_180049310(11LL, v5);
		                                                if ( component )
		                                                {
		                                                  v15 = component[5].monitor;
		                                                  if ( v15 )
		                                                  {
		                                                    *((_BYTE *)v15 + 16) = 0;
		                                                    if ( component )
		                                                    {
		                                                      v5 = component[5].monitor;
		                                                      if ( v5 )
		                                                      {
		                                                        sub_180049310(11LL, v5);
		                                                        if ( component )
		                                                        {
		                                                          v16 = component[6].klass;
		                                                          if ( v16 )
		                                                          {
		                                                            LOBYTE(v16->_0.name) = 0;
		                                                            if ( component )
		                                                            {
		                                                              v5 = component[6].klass;
		                                                              if ( v5 )
		                                                              {
		                                                                sub_180049310(11LL, v5);
		                                                                if ( component )
		                                                                {
		                                                                  v17 = component[6].monitor;
		                                                                  if ( v17 )
		                                                                  {
		                                                                    *((_BYTE *)v17 + 16) = 0;
		                                                                    if ( component )
		                                                                    {
		                                                                      v18 = UnityEngine::Quaternion::get_identity(
		                                                                              &v34,
		                                                                              (MethodInfo *)component[6].monitor);
		                                                                      if ( v5 )
		                                                                      {
		                                                                        v34 = *v18;
		                                                                        sub_1800386F0(11LL, v5, &v34);
		                                                                        if ( component )
		                                                                        {
		                                                                          v19 = component[7].klass;
		                                                                          if ( v19 )
		                                                                          {
		                                                                            LOBYTE(v19->_0.name) = 0;
		                                                                            if ( component )
		                                                                            {
		                                                                              v5 = component[7].klass;
		                                                                              if ( v5 )
		                                                                              {
		                                                                                sub_180049310(11LL, v5);
		                                                                                if ( component )
		                                                                                {
		                                                                                  v20 = component[7].monitor;
		                                                                                  if ( v20 )
		                                                                                  {
		                                                                                    *((_BYTE *)v20 + 16) = 0;
		                                                                                    if ( component )
		                                                                                    {
		                                                                                      v5 = component[7].monitor;
		                                                                                      if ( v5 )
		                                                                                      {
		                                                                                        sub_180049310(11LL, v5);
		                                                                                        if ( component )
		                                                                                        {
		                                                                                          v21 = component[8].klass;
		                                                                                          if ( v21 )
		                                                                                          {
		                                                                                            LOBYTE(v21->_0.name) = 0;
		                                                                                            if ( component )
		                                                                                            {
		                                                                                              v5 = component[8].klass;
		                                                                                              if ( v5 )
		                                                                                              {
		                                                                                                sub_180049310(11LL, v5);
		                                                                                                if ( component )
		                                                                                                {
		                                                                                                  v22 = component[8].monitor;
		                                                                                                  if ( v22 )
		                                                                                                  {
		                                                                                                    *((_BYTE *)v22 + 16) = 0;
		                                                                                                    if ( component )
		                                                                                                    {
		                                                                                                      v5 = component[8].monitor;
		                                                                                                      if ( v5 )
		                                                                                                      {
		                                                                                                        sub_18003BA30(klass, v5, 0LL);
		                                                                                                        if ( component )
		                                                                                                        {
		                                                                                                          v23 = component[9].klass;
		                                                                                                          if ( v23 )
		                                                                                                          {
		                                                                                                            LOBYTE(v23->_0.name) = 0;
		                                                                                                            if ( component )
		                                                                                                            {
		                                                                                                              v5 = component[9].klass;
		                                                                                                              if ( v5 )
		                                                                                                              {
		                                                                                                                sub_1800A2570(11LL, v5, _mm_unpacklo_ps((__m128)0x41A00000u, (__m128)0x41A00000u).m128_u64[0]);
		                                                                                                                if ( component )
		                                                                                                                {
		                                                                                                                  v24 = component[9].monitor;
		                                                                                                                  if ( v24 )
		                                                                                                                  {
		                                                                                                                    *((_BYTE *)v24 + 16) = 0;
		                                                                                                                    if ( component )
		                                                                                                                    {
		                                                                                                                      v5 = component[9].monitor;
		                                                                                                                      if ( v5 )
		                                                                                                                      {
		                                                                                                                        sub_1800A2570(11LL, v5, _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
		                                                                                                                        if ( component )
		                                                                                                                        {
		                                                                                                                          v25 = component[11].klass;
		                                                                                                                          if ( v25 )
		                                                                                                                          {
		                                                                                                                            LOBYTE(v25->_0.name) = 0;
		                                                                                                                            if ( component )
		                                                                                                                            {
		                                                                                                                              v5 = component[11].klass;
		                                                                                                                              if ( v5 )
		                                                                                                                              {
		                                                                                                                                sub_1800A2570(11LL, v5, _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
		                                                                                                                                if ( component )
		                                                                                                                                {
		                                                                                                                                  v26 = component[10].klass;
		                                                                                                                                  if ( v26 )
		                                                                                                                                  {
		                                                                                                                                    LOBYTE(v26->_0.name) = 0;
		                                                                                                                                    if ( component )
		                                                                                                                                    {
		                                                                                                                                      v5 = component[10].klass;
		                                                                                                                                      if ( v5 )
		                                                                                                                                      {
		                                                                                                                                        sub_1800A2570(11LL, v5, _mm_unpacklo_ps((__m128)0x41A00000u, (__m128)0x41A00000u).m128_u64[0]);
		                                                                                                                                        if ( component )
		                                                                                                                                        {
		                                                                                                                                          v27 = component[10].monitor;
		                                                                                                                                          if ( v27 )
		                                                                                                                                          {
		                                                                                                                                            *((_BYTE *)v27 + 16) = 0;
		                                                                                                                                            if ( component )
		                                                                                                                                            {
		                                                                                                                                              v5 = component[10].monitor;
		                                                                                                                                              if ( v5 )
		                                                                                                                                              {
		                                                                                                                                                sub_1800A2570(11LL, v5, _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
		                                                                                                                                                if ( component )
		                                                                                                                                                {
		                                                                                                                                                  v28 = component[11].monitor;
		                                                                                                                                                  if ( v28 )
		                                                                                                                                                  {
		                                                                                                                                                    *((_BYTE *)v28 + 16) = 0;
		                                                                                                                                                    if ( component )
		                                                                                                                                                    {
		                                                                                                                                                      v5 = component[11].monitor;
		                                                                                                                                                      if ( v5 )
		                                                                                                                                                      {
		                                                                                                                                                        sub_1800A2570(11LL, v5, _mm_unpacklo_ps((__m128)0x41A00000u, (__m128)0x41A00000u).m128_u64[0]);
		                                                                                                                                                        if ( component )
		                                                                                                                                                        {
		                                                                                                                                                          v29 = component[12].klass;
		                                                                                                                                                          if ( v29 )
		                                                                                                                                                          {
		                                                                                                                                                            LOBYTE(v29->_0.name) = 0;
		                                                                                                                                                            if ( component )
		                                                                                                                                                            {
		                                                                                                                                                              v5 = component[12].klass;
		                                                                                                                                                              if ( v5 )
		                                                                                                                                                              {
		                                                                                                                                                                sub_1800A2570(11LL, v5, _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
		                                                                                                                                                                if ( component )
		                                                                                                                                                                {
		                                                                                                                                                                  v30 = component[12].monitor;
		                                                                                                                                                                  if ( v30 )
		                                                                                                                                                                  {
		                                                                                                                                                                    *((_BYTE *)v30 + 16) = 0;
		                                                                                                                                                                    if ( component )
		                                                                                                                                                                    {
		                                                                                                                                                                      v5 = component[12].monitor;
		                                                                                                                                                                      if ( v5 )
		                                                                                                                                                                      {
		                                                                                                                                                                        sub_180043DF0(11LL, v5, 0LL);
		                                                                                                                                                                        if ( component )
		                                                                                                                                                                        {
		                                                                                                                                                                          v31 = component[13].klass;
		                                                                                                                                                                          if ( v31 )
		                                                                                                                                                                          {
		                                                                                                                                                                            LOBYTE(v31->_0.name) = 0;
		                                                                                                                                                                            if ( component )
		                                                                                                                                                                            {
		                                                                                                                                                                              v5 = component[13].klass;
		                                                                                                                                                                              if ( v5 )
		                                                                                                                                                                              {
		                                                                                                                                                                                sub_180043DF0(11LL, v5, 0LL);
		                                                                                                                                                                                if ( component )
		                                                                                                                                                                                {
		                                                                                                                                                                                  v32 = component[13].monitor;
		                                                                                                                                                                                  if ( v32 )
		                                                                                                                                                                                  {
		                                                                                                                                                                                    *((_BYTE *)v32 + 16) = 0;
		                                                                                                                                                                                    if ( component )
		                                                                                                                                                                                    {
		                                                                                                                                                                                      v5 = component[13].monitor;
		                                                                                                                                                                                      if ( v5 )
		                                                                                                                                                                                      {
		                                                                                                                                                                                        sub_180043DF0(11LL, v5, 0LL);
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
		      }
		    }
		LABEL_96:
		    sub_1800D8260(klass, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2418, 0LL);
		  if ( !Patch )
		    goto LABEL_96;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)volumeProfile,
		    0LL);
		}
		
		public override bool IsActive() => default; // 0x0000000189B5E1B0-0x0000000189B5E1FC
		// Boolean IsActive()
		bool HG::Rendering::Runtime::VFXPPBlackBox::IsActive(VFXPPBlackBox *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2419, 0LL) )
		    return this->fields._useBlackBox;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2419, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public void SetBlackBoxRadius(float blendRadius, float contourRadius) {} // 0x0000000189B5E928-0x0000000189B5E99C
		// Void SetBlackBoxRadius(Single, Single)
		void HG::Rendering::Runtime::VFXPPBlackBox::SetBlackBoxRadius(
		        VFXPPBlackBox *this,
		        float blendRadius,
		        float contourRadius,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2420, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2420, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_6(
		      (ILFixDynamicMethodWrapper_4 *)Patch,
		      (Object *)this,
		      blendRadius,
		      contourRadius,
		      0LL);
		  }
		  else
		  {
		    this->fields._blendRadius = blendRadius;
		    this->fields._contourRangeRadius = contourRadius;
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
		
		public bool __iFixBaseProxy_IsActive() => default; // 0x0000000189B5D8F0-0x0000000189B5D8F8
		// Boolean <>iFixBaseProxy_IsActive()
		bool HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_IsActive(VFXPPVignette *this, MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::IsActive((VFXPPComponent *)this, 0LL);
		}
		
	}
}
