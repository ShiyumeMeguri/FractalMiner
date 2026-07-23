using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPBWFlash(\u9ED1\u767D\u95EA)")]
	[ExecuteInEditMode]
	public class VFXPPBWFlash : VFXPPComponent // TypeDefIndex: 37937
	{
		// Fields
		[Range(0f, 1f)]
		[SerializeField]
		private float _bwSceneLerp; // 0x48
		[Range(0.51f, 1f)]
		[SerializeField]
		private float _bwThreshold; // 0x4C
		[Range(-1f, 1f)]
		[SerializeField]
		private float _colorBias; // 0x50
		[SerializeField]
		private bool _colorInverse; // 0x54
		[SerializeField]
		private bool _useFlashTex; // 0x55
		[SerializeField]
		private Vector2 _centerPosition; // 0x58
		[SerializeField]
		private Texture2D _flashTexture; // 0x60
		[SerializeField]
		private Vector2 _flashTexTiling; // 0x68
		[SerializeField]
		private Vector2 _flashTexOffset; // 0x70
		[SerializeField]
		private Vector2 _flashTexSpeed; // 0x78
		[SerializeField]
		private Vector2 _flashIntensity; // 0x80
		[SerializeField]
		private bool _useMaskTex; // 0x88
		[SerializeField]
		private Texture2D _maskTexture; // 0x90
		[Range(0f, 1f)]
		[SerializeField]
		private float _maskIntensity; // 0x98
		[SerializeField]
		private bool _maskUsePolarUV; // 0x9C
		[SerializeField]
		private Vector2 _maskTexTiling; // 0xA0
		[SerializeField]
		private Vector2 _maskTexOffset; // 0xA8
		[ColorUsage(true, false)]
		[SerializeField]
		private UnityEngine.Color _flashColor; // 0xB0
		[ColorUsage(true, false)]
		[SerializeField]
		private UnityEngine.Color _backGroundColor; // 0xC0
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000189B5D980-0x0000000189B5D9D0 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPBWFlash::get_m_VFXPPType(VFXPPBWFlash *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2421, 0LL) )
		    return 5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2421, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public VFXPPBWFlash() {} // 0x0000000189B5D908-0x0000000189B5D980
		// VFXPPBWFlash()
		void HG::Rendering::Runtime::VFXPPBWFlash::VFXPPBWFlash(VFXPPBWFlash *this, MethodInfo *method)
		{
		  Vector4 *one; // rax
		  __m128i *v3; // r8
		  MethodInfo *v4; // rdx
		  __m128i v5; // xmm1
		  __int64 v6; // r8
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  this->fields._bwThreshold = 0.50999999;
		  this->fields._bwSceneLerp = 1.0;
		  this->fields._flashTexTiling.x = 1.0;
		  this->fields._flashTexTiling.y = 1.0;
		  this->fields._flashIntensity.x = 1.0;
		  this->fields._flashIntensity.y = 1.0;
		  this->fields._maskTexTiling.x = 1.0;
		  this->fields._maskTexTiling.y = 1.0;
		  one = UnityEngine::Vector4::get_one(&v7, method);
		  v3[11] = _mm_loadu_si128((const __m128i *)one);
		  v5 = _mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::get_identity((Quaternion *)&v7, v4));
		  *(_BYTE *)(v6 + 52) = 1;
		  *(__m128i *)(v6 + 192) = v5;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)v6, 0LL);
		}
		
	
		// Methods
		public override void Apply(VolumeProfile volumeProfile) {} // 0x0000000189B5C794-0x0000000189B5D1E4
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPBWFlash::Apply(VFXPPBWFlash *this, VolumeProfile *volumeProfile, MethodInfo *method)
		{
		  Object_1 *transform; // rbx
		  void *v6; // rdx
		  _BYTE *klass; // rcx
		  __int64 v8; // r8
		  Object__Class *v9; // rax
		  MonitorData *monitor; // rax
		  Object__Class *v11; // rax
		  __int64 v12; // r8
		  MonitorData *v13; // rax
		  __int64 v14; // r8
		  Object__Class *v15; // rax
		  __int64 v16; // r8
		  Object__Class *v17; // rax
		  MonitorData *v18; // rax
		  Object__Class *v19; // rax
		  MonitorData *v20; // rax
		  Object__Class *v21; // rax
		  MonitorData *v22; // rax
		  unsigned __int64 v23; // xmm0_8
		  MonitorData *v24; // rax
		  Object__Class *v25; // rax
		  MonitorData *v26; // rax
		  Object__Class *v27; // rax
		  MonitorData *v28; // rax
		  Object__Class *v29; // rax
		  MonitorData *v30; // rax
		  Object__Class *v31; // rax
		  MonitorData *v32; // rax
		  unsigned __int64 v33; // xmm0_8
		  Object__Class *v34; // rax
		  __int64 v35; // r8
		  MonitorData *v36; // rax
		  Object__Class *v37; // rax
		  MonitorData *v38; // rax
		  MonitorData *v39; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Color flashColor; // [rsp+20h] [rbp-30h] BYREF
		  Object *component; // [rsp+88h] [rbp+38h] BYREF
		
		  component = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2422, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2422, 0LL);
		    if ( !Patch )
		      goto LABEL_140;
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
		      goto LABEL_140;
		    if ( !UnityEngine::Rendering::VolumeProfile::Has<System::Object>(
		            volumeProfile,
		            MethodInfo::UnityEngine::Rendering::VolumeProfile::Has<HG::Rendering::Runtime::HGBWFlash>) )
		      UnityEngine::Rendering::VolumeProfile::Add<System::Object>(
		        volumeProfile,
		        0,
		        MethodInfo::UnityEngine::Rendering::VolumeProfile::Add<HG::Rendering::Runtime::HGBWFlash>);
		    if ( UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		           volumeProfile,
		           &component,
		           MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGBWFlash>) )
		    {
		      if ( component )
		      {
		        LOBYTE(component[1].monitor) = 1;
		        if ( component )
		        {
		          klass = component[3].klass;
		          if ( klass )
		          {
		            klass[16] = 1;
		            if ( component )
		            {
		              v6 = component[3].klass;
		              if ( v6 )
		              {
		                LOBYTE(v8) = 1;
		                sub_180043DF0(11LL, v6, v8);
		                if ( component )
		                {
		                  v9 = component[4].klass;
		                  if ( v9 )
		                  {
		                    LOBYTE(v9->_0.name) = 1;
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
		                                sub_180049310(11LL, v6);
		                                if ( component )
		                                {
		                                  v11 = component[5].klass;
		                                  if ( v11 )
		                                  {
		                                    LOBYTE(v11->_0.name) = 1;
		                                    if ( component )
		                                    {
		                                      v6 = component[5].klass;
		                                      if ( v6 )
		                                      {
		                                        sub_180049310(11LL, v6);
		                                        if ( component )
		                                        {
		                                          v13 = component[5].monitor;
		                                          if ( v13 )
		                                          {
		                                            *((_BYTE *)v13 + 16) = 1;
		                                            if ( component )
		                                            {
		                                              v6 = component[5].monitor;
		                                              if ( v6 )
		                                              {
		                                                LOBYTE(v12) = this->fields._colorInverse;
		                                                sub_180043DF0(11LL, v6, v12);
		                                                if ( component )
		                                                {
		                                                  v15 = component[6].klass;
		                                                  if ( v15 )
		                                                  {
		                                                    LOBYTE(v15->_0.name) = 1;
		                                                    if ( component )
		                                                    {
		                                                      v6 = component[6].klass;
		                                                      if ( v6 )
		                                                      {
		                                                        LOBYTE(v14) = this->fields._useFlashTex;
		                                                        sub_180043DF0(11LL, v6, v14);
		                                                        if ( component )
		                                                        {
		                                                          v17 = component[9].klass;
		                                                          if ( v17 )
		                                                          {
		                                                            LOBYTE(v17->_0.name) = 1;
		                                                            if ( component )
		                                                            {
		                                                              v6 = component[9].klass;
		                                                              if ( v6 )
		                                                              {
		                                                                LOBYTE(v16) = this->fields._useMaskTex;
		                                                                sub_180043DF0(11LL, v6, v16);
		                                                                if ( this->fields._useFlashTex )
		                                                                {
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  klass = component[3].monitor;
		                                                                  if ( !klass )
		                                                                    goto LABEL_140;
		                                                                  klass[16] = 1;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[3].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_1800A2570(
		                                                                    11LL,
		                                                                    v6,
		                                                                    _mm_unpacklo_ps(
		                                                                      (__m128)LODWORD(this->fields._centerPosition.x),
		                                                                      (__m128)LODWORD(this->fields._centerPosition.y)).m128_u64[0]);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v24 = component[6].monitor;
		                                                                  if ( !v24 )
		                                                                    goto LABEL_140;
		                                                                  *((_BYTE *)v24 + 16) = 1;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[6].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_18003BA30(klass, v6, this->fields._flashTexture);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v25 = component[7].klass;
		                                                                  if ( !v25 )
		                                                                    goto LABEL_140;
		                                                                  LOBYTE(v25->_0.name) = 1;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[7].klass;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_1800A2570(
		                                                                    11LL,
		                                                                    v6,
		                                                                    _mm_unpacklo_ps(
		                                                                      (__m128)LODWORD(this->fields._flashTexTiling.x),
		                                                                      (__m128)LODWORD(this->fields._flashTexTiling.y)).m128_u64[0]);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v26 = component[7].monitor;
		                                                                  if ( !v26 )
		                                                                    goto LABEL_140;
		                                                                  *((_BYTE *)v26 + 16) = 1;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[7].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_1800A2570(
		                                                                    11LL,
		                                                                    v6,
		                                                                    _mm_unpacklo_ps(
		                                                                      (__m128)LODWORD(this->fields._flashTexOffset.x),
		                                                                      (__m128)LODWORD(this->fields._flashTexOffset.y)).m128_u64[0]);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v27 = component[8].klass;
		                                                                  if ( !v27 )
		                                                                    goto LABEL_140;
		                                                                  LOBYTE(v27->_0.name) = 1;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[8].klass;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_1800A2570(
		                                                                    11LL,
		                                                                    v6,
		                                                                    _mm_unpacklo_ps(
		                                                                      (__m128)LODWORD(this->fields._flashTexSpeed.x),
		                                                                      (__m128)LODWORD(this->fields._flashTexSpeed.y)).m128_u64[0]);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v28 = component[8].monitor;
		                                                                  if ( !v28 )
		                                                                    goto LABEL_140;
		                                                                  *((_BYTE *)v28 + 16) = 1;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[8].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  v23 = _mm_unpacklo_ps(
		                                                                          (__m128)LODWORD(this->fields._flashIntensity.x),
		                                                                          (__m128)LODWORD(this->fields._flashIntensity.y)).m128_u64[0];
		                                                                }
		                                                                else
		                                                                {
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  klass = component[3].monitor;
		                                                                  if ( !klass )
		                                                                    goto LABEL_140;
		                                                                  klass[16] = 0;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[3].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_1800A2570(
		                                                                    11LL,
		                                                                    v6,
		                                                                    _mm_unpacklo_ps(
		                                                                      (__m128)0x3F000000u,
		                                                                      (__m128)0x3F000000u).m128_u64[0]);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v18 = component[6].monitor;
		                                                                  if ( !v18 )
		                                                                    goto LABEL_140;
		                                                                  *((_BYTE *)v18 + 16) = 0;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[6].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_18003BA30(klass, v6, 0LL);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v19 = component[7].klass;
		                                                                  if ( !v19 )
		                                                                    goto LABEL_140;
		                                                                  LOBYTE(v19->_0.name) = 0;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[7].klass;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_1800A2570(
		                                                                    11LL,
		                                                                    v6,
		                                                                    _mm_unpacklo_ps(
		                                                                      (__m128)0x3F800000u,
		                                                                      (__m128)0x3F800000u).m128_u64[0]);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v20 = component[7].monitor;
		                                                                  if ( !v20 )
		                                                                    goto LABEL_140;
		                                                                  *((_BYTE *)v20 + 16) = 0;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[7].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_1800A2570(
		                                                                    11LL,
		                                                                    v6,
		                                                                    _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v21 = component[8].klass;
		                                                                  if ( !v21 )
		                                                                    goto LABEL_140;
		                                                                  LOBYTE(v21->_0.name) = 0;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[8].klass;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_1800A2570(
		                                                                    11LL,
		                                                                    v6,
		                                                                    _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v22 = component[8].monitor;
		                                                                  if ( !v22 )
		                                                                    goto LABEL_140;
		                                                                  *((_BYTE *)v22 + 16) = 0;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[8].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  v23 = _mm_unpacklo_ps(
		                                                                          (__m128)0x3F800000u,
		                                                                          (__m128)0x3F800000u).m128_u64[0];
		                                                                }
		                                                                sub_1800A2570(11LL, v6, v23);
		                                                                if ( this->fields._useMaskTex )
		                                                                {
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  klass = component[9].monitor;
		                                                                  if ( !klass )
		                                                                    goto LABEL_140;
		                                                                  klass[16] = 1;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[9].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_18003BA30(klass, v6, this->fields._maskTexture);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v34 = component[10].klass;
		                                                                  if ( !v34 )
		                                                                    goto LABEL_140;
		                                                                  LOBYTE(v34->_0.name) = 1;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[10].klass;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_180049310(11LL, v6);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v36 = component[10].monitor;
		                                                                  if ( !v36 )
		                                                                    goto LABEL_140;
		                                                                  *((_BYTE *)v36 + 16) = 1;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[10].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  LOBYTE(v35) = this->fields._maskUsePolarUV;
		                                                                  sub_180043DF0(11LL, v6, v35);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v37 = component[11].klass;
		                                                                  if ( !v37 )
		                                                                    goto LABEL_140;
		                                                                  LOBYTE(v37->_0.name) = 1;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[11].klass;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_1800A2570(
		                                                                    11LL,
		                                                                    v6,
		                                                                    _mm_unpacklo_ps(
		                                                                      (__m128)LODWORD(this->fields._maskTexTiling.x),
		                                                                      (__m128)LODWORD(this->fields._maskTexTiling.y)).m128_u64[0]);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v38 = component[11].monitor;
		                                                                  if ( !v38 )
		                                                                    goto LABEL_140;
		                                                                  *((_BYTE *)v38 + 16) = 1;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[11].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  v33 = _mm_unpacklo_ps(
		                                                                          (__m128)LODWORD(this->fields._maskTexOffset.x),
		                                                                          (__m128)LODWORD(this->fields._maskTexOffset.y)).m128_u64[0];
		                                                                }
		                                                                else
		                                                                {
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  klass = component[9].monitor;
		                                                                  if ( !klass )
		                                                                    goto LABEL_140;
		                                                                  klass[16] = 0;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[9].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_18003BA30(klass, v6, 0LL);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v29 = component[10].klass;
		                                                                  if ( !v29 )
		                                                                    goto LABEL_140;
		                                                                  LOBYTE(v29->_0.name) = 0;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[10].klass;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_180049310(11LL, v6);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v30 = component[10].monitor;
		                                                                  if ( !v30 )
		                                                                    goto LABEL_140;
		                                                                  *((_BYTE *)v30 + 16) = 0;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[10].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_180043DF0(11LL, v6, 0LL);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v31 = component[11].klass;
		                                                                  if ( !v31 )
		                                                                    goto LABEL_140;
		                                                                  LOBYTE(v31->_0.name) = 0;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[11].klass;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  sub_1800A2570(
		                                                                    11LL,
		                                                                    v6,
		                                                                    _mm_unpacklo_ps(
		                                                                      (__m128)0x3F800000u,
		                                                                      (__m128)0x3F800000u).m128_u64[0]);
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v32 = component[11].monitor;
		                                                                  if ( !v32 )
		                                                                    goto LABEL_140;
		                                                                  *((_BYTE *)v32 + 16) = 0;
		                                                                  if ( !component )
		                                                                    goto LABEL_140;
		                                                                  v6 = component[11].monitor;
		                                                                  if ( !v6 )
		                                                                    goto LABEL_140;
		                                                                  v33 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		                                                                }
		                                                                sub_1800A2570(11LL, v6, v33);
		                                                                if ( component )
		                                                                {
		                                                                  klass = component[12].klass;
		                                                                  if ( klass )
		                                                                  {
		                                                                    klass[16] = 1;
		                                                                    if ( component )
		                                                                    {
		                                                                      v6 = component[12].klass;
		                                                                      if ( v6 )
		                                                                      {
		                                                                        flashColor = this->fields._flashColor;
		                                                                        sub_1800386F0(11LL, v6, &flashColor);
		                                                                        if ( component )
		                                                                        {
		                                                                          v39 = component[12].monitor;
		                                                                          if ( v39 )
		                                                                          {
		                                                                            *((_BYTE *)v39 + 16) = 1;
		                                                                            if ( component )
		                                                                            {
		                                                                              v6 = component[12].monitor;
		                                                                              if ( v6 )
		                                                                              {
		                                                                                flashColor = this->fields._backGroundColor;
		                                                                                sub_1800386F0(11LL, v6, &flashColor);
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
		LABEL_140:
		      sub_1800D8260(klass, v6);
		    }
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000189B5D24C-0x0000000189B5D8E8
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPBWFlash::ResetByVolumeProfile(
		        VFXPPBWFlash *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  void *v5; // rdx
		  Object__Class *klass; // rcx
		  Object__Class *v7; // rax
		  MonitorData *monitor; // rax
		  Object__Class *v9; // rax
		  MonitorData *v10; // rax
		  Object__Class *v11; // rax
		  MonitorData *v12; // rax
		  MonitorData *v13; // rax
		  Object__Class *v14; // rax
		  MonitorData *v15; // rax
		  Object__Class *v16; // rax
		  MonitorData *v17; // rax
		  Object__Class *v18; // rax
		  MonitorData *v19; // rax
		  Object__Class *v20; // rax
		  MonitorData *v21; // rax
		  Object__Class *v22; // rax
		  MonitorData *v23; // rax
		  Object__Class *v24; // rax
		  Vector4 *one; // rax
		  MonitorData *v26; // rax
		  Quaternion *identity; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Quaternion v29; // [rsp+20h] [rbp-30h] BYREF
		  Object *component; // [rsp+78h] [rbp+28h] BYREF
		
		  component = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2423, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality((Object_1 *)volumeProfile, 0LL, 0LL) )
		      return;
		    if ( volumeProfile )
		    {
		      if ( !UnityEngine::Rendering::VolumeProfile::TryGet<System::Object>(
		              volumeProfile,
		              &component,
		              MethodInfo::UnityEngine::Rendering::VolumeProfile::TryGet<HG::Rendering::Runtime::HGBWFlash>) )
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
		                  v7 = component[4].klass;
		                  if ( v7 )
		                  {
		                    LOBYTE(v7->_0.name) = 0;
		                    if ( component )
		                    {
		                      v5 = component[4].klass;
		                      if ( v5 )
		                      {
		                        sub_180049310(11LL, v5);
		                        if ( component )
		                        {
		                          monitor = component[4].monitor;
		                          if ( monitor )
		                          {
		                            *((_BYTE *)monitor + 16) = 0;
		                            if ( component )
		                            {
		                              v5 = component[4].monitor;
		                              if ( v5 )
		                              {
		                                sub_180049310(11LL, v5);
		                                if ( component )
		                                {
		                                  v9 = component[5].klass;
		                                  if ( v9 )
		                                  {
		                                    LOBYTE(v9->_0.name) = 0;
		                                    if ( component )
		                                    {
		                                      v5 = component[5].klass;
		                                      if ( v5 )
		                                      {
		                                        sub_180049310(11LL, v5);
		                                        if ( component )
		                                        {
		                                          v10 = component[5].monitor;
		                                          if ( v10 )
		                                          {
		                                            *((_BYTE *)v10 + 16) = 0;
		                                            if ( component )
		                                            {
		                                              v5 = component[5].monitor;
		                                              if ( v5 )
		                                              {
		                                                sub_180043DF0(11LL, v5, 0LL);
		                                                if ( component )
		                                                {
		                                                  v11 = component[6].klass;
		                                                  if ( v11 )
		                                                  {
		                                                    LOBYTE(v11->_0.name) = 0;
		                                                    if ( component )
		                                                    {
		                                                      v5 = component[6].klass;
		                                                      if ( v5 )
		                                                      {
		                                                        sub_180043DF0(11LL, v5, 0LL);
		                                                        if ( component )
		                                                        {
		                                                          v12 = component[3].monitor;
		                                                          if ( v12 )
		                                                          {
		                                                            *((_BYTE *)v12 + 16) = 0;
		                                                            if ( component )
		                                                            {
		                                                              v5 = component[3].monitor;
		                                                              if ( v5 )
		                                                              {
		                                                                sub_1800A2570(
		                                                                  11LL,
		                                                                  v5,
		                                                                  _mm_unpacklo_ps(
		                                                                    (__m128)0x3F000000u,
		                                                                    (__m128)0x3F000000u).m128_u64[0]);
		                                                                if ( component )
		                                                                {
		                                                                  v13 = component[6].monitor;
		                                                                  if ( v13 )
		                                                                  {
		                                                                    *((_BYTE *)v13 + 16) = 0;
		                                                                    if ( component )
		                                                                    {
		                                                                      v5 = component[6].monitor;
		                                                                      if ( v5 )
		                                                                      {
		                                                                        sub_18003BA30(klass, v5, 0LL);
		                                                                        if ( component )
		                                                                        {
		                                                                          v14 = component[7].klass;
		                                                                          if ( v14 )
		                                                                          {
		                                                                            LOBYTE(v14->_0.name) = 0;
		                                                                            if ( component )
		                                                                            {
		                                                                              v5 = component[7].klass;
		                                                                              if ( v5 )
		                                                                              {
		                                                                                sub_1800A2570(
		                                                                                  11LL,
		                                                                                  v5,
		                                                                                  _mm_unpacklo_ps(
		                                                                                    (__m128)0x3F800000u,
		                                                                                    (__m128)0x3F800000u).m128_u64[0]);
		                                                                                if ( component )
		                                                                                {
		                                                                                  v15 = component[7].monitor;
		                                                                                  if ( v15 )
		                                                                                  {
		                                                                                    *((_BYTE *)v15 + 16) = 0;
		                                                                                    if ( component )
		                                                                                    {
		                                                                                      v5 = component[7].monitor;
		                                                                                      if ( v5 )
		                                                                                      {
		                                                                                        sub_1800A2570(
		                                                                                          11LL,
		                                                                                          v5,
		                                                                                          _mm_unpacklo_ps(
		                                                                                            (__m128)0LL,
		                                                                                            (__m128)0LL).m128_u64[0]);
		                                                                                        if ( component )
		                                                                                        {
		                                                                                          v16 = component[8].klass;
		                                                                                          if ( v16 )
		                                                                                          {
		                                                                                            LOBYTE(v16->_0.name) = 0;
		                                                                                            if ( component )
		                                                                                            {
		                                                                                              v5 = component[8].klass;
		                                                                                              if ( v5 )
		                                                                                              {
		                                                                                                sub_1800A2570(
		                                                                                                  11LL,
		                                                                                                  v5,
		                                                                                                  _mm_unpacklo_ps(
		                                                                                                    (__m128)0LL,
		                                                                                                    (__m128)0LL).m128_u64[0]);
		                                                                                                if ( component )
		                                                                                                {
		                                                                                                  v17 = component[8].monitor;
		                                                                                                  if ( v17 )
		                                                                                                  {
		                                                                                                    *((_BYTE *)v17 + 16) = 0;
		                                                                                                    if ( component )
		                                                                                                    {
		                                                                                                      v5 = component[8].monitor;
		                                                                                                      if ( v5 )
		                                                                                                      {
		                                                                                                        sub_1800A2570(11LL, v5, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
		                                                                                                        if ( component )
		                                                                                                        {
		                                                                                                          v18 = component[9].klass;
		                                                                                                          if ( v18 )
		                                                                                                          {
		                                                                                                            LOBYTE(v18->_0.name) = 0;
		                                                                                                            if ( component )
		                                                                                                            {
		                                                                                                              v5 = component[9].klass;
		                                                                                                              if ( v5 )
		                                                                                                              {
		                                                                                                                sub_180043DF0(11LL, v5, 0LL);
		                                                                                                                if ( component )
		                                                                                                                {
		                                                                                                                  v19 = component[9].monitor;
		                                                                                                                  if ( v19 )
		                                                                                                                  {
		                                                                                                                    *((_BYTE *)v19 + 16) = 0;
		                                                                                                                    if ( component )
		                                                                                                                    {
		                                                                                                                      v5 = component[9].monitor;
		                                                                                                                      if ( v5 )
		                                                                                                                      {
		                                                                                                                        sub_18003BA30(klass, v5, 0LL);
		                                                                                                                        if ( component )
		                                                                                                                        {
		                                                                                                                          v20 = component[10].klass;
		                                                                                                                          if ( v20 )
		                                                                                                                          {
		                                                                                                                            LOBYTE(v20->_0.name) = 0;
		                                                                                                                            if ( component )
		                                                                                                                            {
		                                                                                                                              v5 = component[10].klass;
		                                                                                                                              if ( v5 )
		                                                                                                                              {
		                                                                                                                                sub_180049310(11LL, v5);
		                                                                                                                                if ( component )
		                                                                                                                                {
		                                                                                                                                  v21 = component[10].monitor;
		                                                                                                                                  if ( v21 )
		                                                                                                                                  {
		                                                                                                                                    *((_BYTE *)v21 + 16) = 0;
		                                                                                                                                    if ( component )
		                                                                                                                                    {
		                                                                                                                                      v5 = component[10].monitor;
		                                                                                                                                      if ( v5 )
		                                                                                                                                      {
		                                                                                                                                        sub_180043DF0(11LL, v5, 0LL);
		                                                                                                                                        if ( component )
		                                                                                                                                        {
		                                                                                                                                          v22 = component[11].klass;
		                                                                                                                                          if ( v22 )
		                                                                                                                                          {
		                                                                                                                                            LOBYTE(v22->_0.name) = 0;
		                                                                                                                                            if ( component )
		                                                                                                                                            {
		                                                                                                                                              v5 = component[11].klass;
		                                                                                                                                              if ( v5 )
		                                                                                                                                              {
		                                                                                                                                                sub_1800A2570(11LL, v5, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
		                                                                                                                                                if ( component )
		                                                                                                                                                {
		                                                                                                                                                  v23 = component[11].monitor;
		                                                                                                                                                  if ( v23 )
		                                                                                                                                                  {
		                                                                                                                                                    *((_BYTE *)v23 + 16) = 0;
		                                                                                                                                                    if ( component )
		                                                                                                                                                    {
		                                                                                                                                                      v5 = component[11].monitor;
		                                                                                                                                                      if ( v5 )
		                                                                                                                                                      {
		                                                                                                                                                        sub_1800A2570(11LL, v5, _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0]);
		                                                                                                                                                        if ( component )
		                                                                                                                                                        {
		                                                                                                                                                          v24 = component[12].klass;
		                                                                                                                                                          if ( v24 )
		                                                                                                                                                          {
		                                                                                                                                                            LOBYTE(v24->_0.name) = 0;
		                                                                                                                                                            if ( component )
		                                                                                                                                                            {
		                                                                                                                                                              one = UnityEngine::Vector4::get_one((Vector4 *)&v29, (MethodInfo *)component[12].klass);
		                                                                                                                                                              if ( v5 )
		                                                                                                                                                              {
		                                                                                                                                                                v29 = (Quaternion)*one;
		                                                                                                                                                                sub_1800386F0(11LL, v5, &v29);
		                                                                                                                                                                if ( component )
		                                                                                                                                                                {
		                                                                                                                                                                  v26 = component[12].monitor;
		                                                                                                                                                                  if ( v26 )
		                                                                                                                                                                  {
		                                                                                                                                                                    *((_BYTE *)v26 + 16) = 0;
		                                                                                                                                                                    if ( component )
		                                                                                                                                                                    {
		                                                                                                                                                                      identity = UnityEngine::Quaternion::get_identity(&v29, (MethodInfo *)component[12].monitor);
		                                                                                                                                                                      if ( v5 )
		                                                                                                                                                                      {
		                                                                                                                                                                        v29 = *identity;
		                                                                                                                                                                        sub_1800386F0(11LL, v5, &v29);
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
		LABEL_88:
		    sub_1800D8260(klass, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2423, 0LL);
		  if ( !Patch )
		    goto LABEL_88;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)volumeProfile,
		    0LL);
		}
		
		public override bool IsActive() => default; // 0x0000000189B5D1E4-0x0000000189B5D24C
		// Boolean IsActive()
		bool HG::Rendering::Runtime::VFXPPBWFlash::IsActive(VFXPPBWFlash *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2424, 0LL) )
		    return this->fields._bwThreshold != 0.0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2424, 0LL);
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
