using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("HG/Effect/VFXPPInkWash(\u5168\u5C4F\u6C34\u58A8\u540E\u5904\u7406)")]
	[ExecuteInEditMode]
	public class VFXPPInkWash : VFXPPComponent // TypeDefIndex: 37957
	{
		// Fields
		[SerializeField]
		private bool _toggle; // 0x48
		[Range(0f, 1f)]
		[SerializeField]
		private float _intensity; // 0x4C
		[SerializeField]
		private bool _ignoreCharacter; // 0x50
		[SerializeField]
		private Material _baseMat; // 0x58
		[SerializeField]
		private float _VerticalFadeStart0; // 0x60
		[SerializeField]
		private float _VerticalFadeEnd0; // 0x64
		[SerializeField]
		private float _VerticalFadeAffectDist0; // 0x68
		[SerializeField]
		private float _VerticalFadeDist0; // 0x6C
		[SerializeField]
		private float _GroundColorAdj0; // 0x70
		[SerializeField]
		private Material _overlayMat; // 0x78
		[SerializeField]
		private float _VerticalFadeStart1; // 0x80
		[SerializeField]
		private float _VerticalFadeEnd1; // 0x84
		[SerializeField]
		private float _VerticalFadeAffectDist1; // 0x88
		[SerializeField]
		private float _VerticalFadeDist1; // 0x8C
		[SerializeField]
		private float _GroundColorAdj1; // 0x90
		[SerializeField]
		private Material _maskMat; // 0x98
		[Range(0.1f, 5f)]
		[SerializeField]
		private float _inkDropSize; // 0xA0
		[Range(0.1f, 10f)]
		[SerializeField]
		private float _inkBleedingSpeed; // 0xA4
		[SerializeField]
		private bool _randomSize; // 0xA8
		[Range(1f, 4f)]
		[SerializeField]
		private int _atlasSize; // 0xAC
		[Range(0f, 1f)]
		[SerializeField]
		private float _edgeFade; // 0xB0
		private const string SHADER_VFX_INK_WASH = "HGRP/Effect/VFXInkWash"; // Metadata: 0x02303773
		private const string SHADER_VFX_INK_WASH_MASK = "HGRP/Effect/VFXInkWashMask"; // Metadata: 0x0230378A
		private bool m_hasValidBaseShader; // 0xB4
		private bool m_hasValidOverlayShader; // 0xB5
		private bool m_hasValidMaskShader; // 0xB6
		private Vector4 prevInkPointDir; // 0xB8
		private Vector4 currInkPointDir; // 0xC8
		private Vector3 _inkPointDir; // 0xD8
		private bool _addNewInkDrop; // 0xE4
		private bool _isDrawing; // 0xE5
		private float m_strokeStartTime; // 0xE8
		private float m_randomFloat; // 0xEC
	
		// Properties
		protected override VFXPPType m_VFXPPType { get => default; } // 0x0000000189B61F60-0x0000000189B61FB0 
		// VFXPPType get_m_VFXPPType()
		VFXPPType__Enum HG::Rendering::Runtime::VFXPPInkWash::get_m_VFXPPType(VFXPPInkWash *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2511, 0LL) )
		    return 16;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2511, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		
		public override bool ImplementedInVolume { get => default; } // 0x0000000189B61F14-0x0000000189B61F60 
		// Boolean get_ImplementedInVolume()
		bool HG::Rendering::Runtime::VFXPPInkWash::get_ImplementedInVolume(VFXPPInkWash *this, MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(2512, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2512, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  return result;
		}
		
	
		// Constructors
		public VFXPPInkWash() {} // 0x0000000189B61E88-0x0000000189B61F14
		// VFXPPInkWash()
		void HG::Rendering::Runtime::VFXPPInkWash::VFXPPInkWash(VFXPPInkWash *this, MethodInfo *method)
		{
		  MethodInfo *v2; // r9
		  Vector3 *Vector; // rax
		  float z; // ecx
		  __int64 v5; // r8
		  Vector3 v6[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  this->fields._ignoreCharacter = 1;
		  this->fields._VerticalFadeAffectDist0 = 40.0;
		  this->fields._VerticalFadeAffectDist1 = 40.0;
		  this->fields._VerticalFadeDist0 = 10.0;
		  this->fields._VerticalFadeDist1 = 10.0;
		  this->fields._inkDropSize = 2.0;
		  this->fields._inkBleedingSpeed = 1.0;
		  this->fields._atlasSize = 2;
		  this->fields._edgeFade = 0.1;
		  Vector = UnityEngine::Animator::GetVector(v6, (Animator *)method, (int32_t)this, v2);
		  z = Vector->z;
		  *(_QWORD *)(v5 + 216) = *(_QWORD *)&Vector->x;
		  *(float *)(v5 + 224) = z;
		  *(_BYTE *)(v5 + 52) = 1;
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)v5, 0LL);
		}
		
	
		// Methods
		private void Awake() {} // 0x0000000189B61780-0x0000000189B617F0
		// Void Awake()
		void HG::Rendering::Runtime::VFXPPInkWash::Awake(VFXPPInkWash *this, MethodInfo *method)
		{
		  TileBase *v3; // rdx
		  Vector3Int *v4; // r8
		  ITilemap *v5; // r9
		  Vector4 v6; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  TileAnimationData v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2513, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2513, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VFXPPInkWash::ValidateMaterials(this, 0LL);
		    v6 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                     &v10,
		                                                     v3,
		                                                     v4,
		                                                     v5,
		                                                     (MethodInfo *)v10.m_AnimatedSprites));
		    this->fields._addNewInkDrop = 0;
		    this->fields.prevInkPointDir = v6;
		  }
		}
		
		private void ValidateMaterials() {} // 0x0000000189B61CE4-0x0000000189B61E88
		// Void ValidateMaterials()
		void HG::Rendering::Runtime::VFXPPInkWash::ValidateMaterials(VFXPPInkWash *this, MethodInfo *method)
		{
		  Object_1 *baseMat; // rbx
		  __int64 v4; // rdx
		  Material *v5; // rcx
		  Object_1 *shader; // rax
		  String *name; // rax
		  Object_1 *overlayMat; // rbx
		  Object_1 *v9; // rax
		  String *v10; // rax
		  Object_1 *maskMat; // rbx
		  Object_1 *v12; // rax
		  String *v13; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2514, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2514, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		    goto LABEL_21;
		  }
		  *(_WORD *)&this->fields.m_hasValidBaseShader = 0;
		  baseMat = (Object_1 *)this->fields._baseMat;
		  this->fields.m_hasValidMaskShader = 0;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Inequality(baseMat, 0LL, 0LL) )
		  {
		    v5 = this->fields._baseMat;
		    if ( !v5 )
		      goto LABEL_21;
		    shader = (Object_1 *)UnityEngine::Material::get_shader(v5, 0LL);
		    if ( !shader )
		      goto LABEL_21;
		    name = UnityEngine::Object::get_name(shader, 0LL);
		    if ( !name )
		      goto LABEL_21;
		    if ( System::String::Equals(name, (String *)"HGRP/Effect/VFXInkWash", 0LL) )
		      this->fields.m_hasValidBaseShader = 1;
		  }
		  overlayMat = (Object_1 *)this->fields._overlayMat;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Inequality(overlayMat, 0LL, 0LL) )
		  {
		    v5 = this->fields._overlayMat;
		    if ( !v5 )
		      goto LABEL_21;
		    v9 = (Object_1 *)UnityEngine::Material::get_shader(v5, 0LL);
		    if ( !v9 )
		      goto LABEL_21;
		    v10 = UnityEngine::Object::get_name(v9, 0LL);
		    if ( !v10 )
		      goto LABEL_21;
		    if ( System::String::Equals(v10, (String *)"HGRP/Effect/VFXInkWash", 0LL) )
		      this->fields.m_hasValidOverlayShader = 1;
		  }
		  maskMat = (Object_1 *)this->fields._maskMat;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Inequality(maskMat, 0LL, 0LL) )
		    return;
		  v5 = this->fields._maskMat;
		  if ( !v5
		    || (v12 = (Object_1 *)UnityEngine::Material::get_shader(v5, 0LL)) == 0LL
		    || (v13 = UnityEngine::Object::get_name(v12, 0LL)) == 0LL )
		  {
		LABEL_21:
		    sub_1800D8260(v5, v4);
		  }
		  if ( System::String::Equals(v13, (String *)"HGRP/Effect/VFXInkWashMask", 0LL) )
		    this->fields.m_hasValidMaskShader = 1;
		}
		
		private void LateUpdate() {} // 0x0000000189B618B8-0x0000000189B61934
		// Void LateUpdate()
		void HG::Rendering::Runtime::VFXPPInkWash::LateUpdate(VFXPPInkWash *this, MethodInfo *method)
		{
		  MethodInfo *v3; // r8
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 v8; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v9; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2515, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2515, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    z = this->fields._inkPointDir.z;
		    *(_QWORD *)&v8.x = *(_QWORD *)&this->fields._inkPointDir.x;
		    v8.z = z;
		    this->fields.currInkPointDir = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                               &v9,
		                                                                               &v8,
		                                                                               v3));
		  }
		}
		
		public override void Apply(VolumeProfile volumeProfile) {} // 0x0000000189B6172C-0x0000000189B61780
		// Void Apply(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPInkWash::Apply(VFXPPInkWash *this, VolumeProfile *volumeProfile, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2516, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2516, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)volumeProfile,
		      0LL);
		  }
		}
		
		public override void ResetByVolumeProfile(VolumeProfile volumeProfile) {} // 0x0000000189B61990-0x0000000189B619E4
		// Void ResetByVolumeProfile(VolumeProfile)
		void HG::Rendering::Runtime::VFXPPInkWash::ResetByVolumeProfile(
		        VFXPPInkWash *this,
		        VolumeProfile *volumeProfile,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2517, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2517, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)volumeProfile,
		      0LL);
		  }
		}
		
		public override void ApplyEnvPhase(HGEnvironmentPhase envPhase) {} // 0x0000000189B61330-0x0000000189B6172C
		// Void ApplyEnvPhase(HGEnvironmentPhase)
		void HG::Rendering::Runtime::VFXPPInkWash::ApplyEnvPhase(
		        VFXPPInkWash *this,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  Object_1 *transform; // rbx
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  HGRuntimeGrassQuery_Node *v8; // rdx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  float GroundColorAdj0; // xmm0_4
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **VerticalFadeStart1_low; // r9
		  float GroundColorAdj1; // xmm0_4
		  HGRuntimeGrassQuery_Node *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  bool addNewInkDrop; // al
		  MethodInfo *v26; // r8
		  Vector3 *v27; // rax
		  float z; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v30; // [rsp+20h] [rbp-38h] BYREF
		  Vector4 currInkPointDir; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2518, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2518, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)envPhase,
		        0LL);
		      return;
		    }
		LABEL_19:
		    sub_1800D8260(v7, v6);
		  }
		  transform = (Object_1 *)UnityEngine::Component::get_transform((Component *)this, 0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality(transform, 0LL, 0LL) )
		    return;
		  if ( !envPhase )
		    goto LABEL_19;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig);
		  HG::Rendering::Runtime::HGInkWashConfig::set_active(&envPhase->fields.inkWashConfig, 1, 0LL);
		  envPhase->fields.inkWashConfig.enable = this->fields._toggle;
		  envPhase->fields.inkWashConfig.intensity = this->fields._intensity;
		  envPhase->fields.inkWashConfig.isDrawing = this->fields._isDrawing;
		  if ( this->fields.m_hasValidBaseShader && this->fields._toggle )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig);
		    HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig::set_active(
		      &envPhase->fields.inkWashConfig.baseConfig,
		      1,
		      0LL);
		    envPhase->fields.inkWashConfig.baseConfig.baseMat = this->fields._baseMat;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&envPhase->fields.inkWashConfig.baseConfig,
		      v8,
		      v9,
		      v10,
		      *(MethodInfo **)&v30.x);
		    envPhase->fields.inkWashConfig.baseConfig.verticalFadeStart = this->fields._VerticalFadeStart0;
		    envPhase->fields.inkWashConfig.baseConfig.verticalFadeEnd = this->fields._VerticalFadeEnd0;
		    envPhase->fields.inkWashConfig.baseConfig.verticalFadeAffectDist = this->fields._VerticalFadeAffectDist0;
		    envPhase->fields.inkWashConfig.baseConfig.verticalFadeFadeDist = this->fields._VerticalFadeDist0;
		    GroundColorAdj0 = this->fields._GroundColorAdj0;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig);
		    HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig::set_active(
		      &envPhase->fields.inkWashConfig.baseConfig,
		      0,
		      0LL);
		    envPhase->fields.inkWashConfig.baseConfig.baseMat = 0LL;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&envPhase->fields.inkWashConfig.baseConfig,
		      v12,
		      v13,
		      v14,
		      *(MethodInfo **)&v30.x);
		    *(_QWORD *)&envPhase->fields.inkWashConfig.baseConfig.verticalFadeStart = 0LL;
		    GroundColorAdj0 = 0.0;
		    envPhase->fields.inkWashConfig.baseConfig.verticalFadeAffectDist = 40.0;
		    envPhase->fields.inkWashConfig.baseConfig.verticalFadeFadeDist = 10.0;
		  }
		  envPhase->fields.inkWashConfig.baseConfig.groundColorAdj = GroundColorAdj0;
		  if ( this->fields.m_hasValidOverlayShader && this->fields._isDrawing )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig);
		    HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig::set_active(
		      &envPhase->fields.inkWashConfig.overlayConfig,
		      1,
		      0LL);
		    envPhase->fields.inkWashConfig.overlayConfig.overlayMat = this->fields._overlayMat;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&envPhase->fields.inkWashConfig.overlayConfig,
		      v15,
		      v16,
		      v17,
		      *(MethodInfo **)&v30.x);
		    VerticalFadeStart1_low = (Int32__Array **)LODWORD(this->fields._VerticalFadeStart1);
		    LODWORD(envPhase->fields.inkWashConfig.overlayConfig.verticalFadeStart) = (_DWORD)VerticalFadeStart1_low;
		    envPhase->fields.inkWashConfig.overlayConfig.verticalFadeEnd = this->fields._VerticalFadeEnd1;
		    envPhase->fields.inkWashConfig.overlayConfig.verticalFadeAffectDist = this->fields._VerticalFadeAffectDist1;
		    envPhase->fields.inkWashConfig.overlayConfig.verticalFadeFadeDist = this->fields._VerticalFadeDist1;
		    GroundColorAdj1 = this->fields._GroundColorAdj1;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig);
		    HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig::set_active(
		      &envPhase->fields.inkWashConfig.overlayConfig,
		      0,
		      0LL);
		    envPhase->fields.inkWashConfig.overlayConfig.overlayMat = 0LL;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&envPhase->fields.inkWashConfig.overlayConfig,
		      v22,
		      v23,
		      v24,
		      *(MethodInfo **)&v30.x);
		    *(_QWORD *)&envPhase->fields.inkWashConfig.overlayConfig.verticalFadeStart = 0LL;
		    GroundColorAdj1 = 0.0;
		    envPhase->fields.inkWashConfig.overlayConfig.verticalFadeAffectDist = 40.0;
		    envPhase->fields.inkWashConfig.overlayConfig.verticalFadeFadeDist = 10.0;
		  }
		  envPhase->fields.inkWashConfig.overlayConfig.groundColorAdj = GroundColorAdj1;
		  if ( this->fields.m_hasValidMaskShader && this->fields._isDrawing )
		  {
		    addNewInkDrop = this->fields._addNewInkDrop;
		    this->fields.prevInkPointDir = this->fields.currInkPointDir;
		    envPhase->fields.inkWashConfig.maskConfig.addNewInkDrop = addNewInkDrop;
		    envPhase->fields.inkWashConfig.maskConfig.maskMat = this->fields._maskMat;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&envPhase->fields.inkWashConfig.maskConfig.maskMat,
		      v18,
		      v19,
		      VerticalFadeStart1_low,
		      *(MethodInfo **)&v30.x);
		    envPhase->fields.inkWashConfig.maskConfig.inkDropSize = this->fields._inkDropSize;
		    envPhase->fields.inkWashConfig.maskConfig.inkBleedingSpeed = this->fields._inkBleedingSpeed;
		    envPhase->fields.inkWashConfig.maskConfig.randomSize = this->fields._randomSize;
		    envPhase->fields.inkWashConfig.maskConfig.atlasSize = (float)this->fields._atlasSize;
		    envPhase->fields.inkWashConfig.maskConfig.edgeFade = this->fields._edgeFade;
		    currInkPointDir = this->fields.currInkPointDir;
		    v27 = UnityEngine::Vector4::op_Implicit(&v30, &currInkPointDir, v26);
		    z = v27->z;
		    *(_QWORD *)&envPhase->fields.inkWashConfig.maskConfig.currInkPointDir.x = *(_QWORD *)&v27->x;
		    envPhase->fields.inkWashConfig.maskConfig.currInkPointDir.z = z;
		    if ( this->fields._addNewInkDrop )
		    {
		      this->fields.m_strokeStartTime = HG::Rendering::Runtime::VFXPPInkWash::GetCurrentTime(this, 0LL);
		      this->fields.m_randomFloat = UnityEngine::Random::get_value(0LL);
		    }
		    envPhase->fields.inkWashConfig.maskConfig.inkBleedingDeltaTime = HG::Rendering::Runtime::VFXPPInkWash::GetCurrentTime(
		                                                                       this,
		                                                                       0LL)
		                                                                   - this->fields.m_strokeStartTime;
		    envPhase->fields.inkWashConfig.maskConfig.inkStrokeSeed = this->fields.m_randomFloat;
		    HG::Rendering::Runtime::VFXPPInkWash::RequestNewInkDraw(this, 0, 0LL);
		  }
		  else
		  {
		    envPhase->fields.inkWashConfig.maskConfig.addNewInkDrop = 0;
		    envPhase->fields.inkWashConfig.maskConfig.maskMat = 0LL;
		    sub_18002D1B0(
		      (HGRuntimeGrassQuery_Node *)&envPhase->fields.inkWashConfig.maskConfig.maskMat,
		      v18,
		      v19,
		      VerticalFadeStart1_low,
		      *(MethodInfo **)&v30.x);
		    envPhase->fields.inkWashConfig.maskConfig.inkDropSize = 2.0;
		    envPhase->fields.inkWashConfig.maskConfig.inkBleedingSpeed = 1.0;
		    envPhase->fields.inkWashConfig.maskConfig.randomSize = 0;
		    *(_QWORD *)&envPhase->fields.inkWashConfig.maskConfig.currInkPointPos.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		    envPhase->fields.inkWashConfig.maskConfig.currInkPointPos.z = 0.0;
		    envPhase->fields.inkWashConfig.maskConfig.atlasSize = 2.0;
		    envPhase->fields.inkWashConfig.maskConfig.edgeFade = 0.1;
		  }
		}
		
		public override void ResetEnvPhase(HGEnvironmentPhase envPhase) {} // 0x0000000189B61A44-0x0000000189B61BD8
		// Void ResetEnvPhase(HGEnvironmentPhase)
		void HG::Rendering::Runtime::VFXPPInkWash::ResetEnvPhase(
		        VFXPPInkWash *this,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v17; // [rsp+20h] [rbp-8h]
		  MethodInfo *v18; // [rsp+20h] [rbp-8h]
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2521, 0LL) )
		  {
		    if ( envPhase )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig);
		      HG::Rendering::Runtime::HGInkWashConfig::set_active(&envPhase->fields.inkWashConfig, 0, 0LL);
		      envPhase->fields.inkWashConfig.enable = 0;
		      envPhase->fields.inkWashConfig.intensity = 0.0;
		      envPhase->fields.inkWashConfig.isDrawing = 0;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig);
		      HG::Rendering::Runtime::HGInkWashConfig::HGInkWashBaseConfig::set_active(
		        &envPhase->fields.inkWashConfig.baseConfig,
		        0,
		        0LL);
		      envPhase->fields.inkWashConfig.baseConfig.baseMat = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&envPhase->fields.inkWashConfig.baseConfig, v7, v8, v9, v17);
		      *(_QWORD *)&envPhase->fields.inkWashConfig.baseConfig.verticalFadeStart = 0LL;
		      envPhase->fields.inkWashConfig.baseConfig.verticalFadeAffectDist = 40.0;
		      *(_QWORD *)&envPhase->fields.inkWashConfig.baseConfig.verticalFadeFadeDist = 1092616192LL;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig);
		      HG::Rendering::Runtime::HGInkWashConfig::HGInkWashOverlayConfig::set_active(
		        &envPhase->fields.inkWashConfig.overlayConfig,
		        0,
		        0LL);
		      envPhase->fields.inkWashConfig.overlayConfig.overlayMat = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&envPhase->fields.inkWashConfig.overlayConfig, v10, v11, v12, v18);
		      *(_QWORD *)&envPhase->fields.inkWashConfig.overlayConfig.verticalFadeStart = 0LL;
		      envPhase->fields.inkWashConfig.overlayConfig.verticalFadeAffectDist = 40.0;
		      *(_QWORD *)&envPhase->fields.inkWashConfig.overlayConfig.verticalFadeFadeDist = 1092616192LL;
		      envPhase->fields.inkWashConfig.maskConfig.addNewInkDrop = 0;
		      envPhase->fields.inkWashConfig.maskConfig.maskMat = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&envPhase->fields.inkWashConfig.maskConfig.maskMat, v13, v14, v15, v19);
		      envPhase->fields.inkWashConfig.maskConfig.inkDropSize = 2.0;
		      envPhase->fields.inkWashConfig.maskConfig.inkBleedingSpeed = 1.0;
		      envPhase->fields.inkWashConfig.maskConfig.randomSize = 0;
		      *(_QWORD *)&envPhase->fields.inkWashConfig.maskConfig.currInkPointPos.x = _mm_unpacklo_ps(
		                                                                                  (__m128)0LL,
		                                                                                  (__m128)0LL).m128_u64[0];
		      envPhase->fields.inkWashConfig.maskConfig.currInkPointPos.z = 0.0;
		      envPhase->fields.inkWashConfig.maskConfig.atlasSize = 2.0;
		      envPhase->fields.inkWashConfig.maskConfig.edgeFade = 0.1;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2521, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)envPhase,
		    0LL);
		}
		
		public override bool IsActive() => default; // 0x0000000189B6184C-0x0000000189B618B8
		// Boolean IsActive()
		bool HG::Rendering::Runtime::VFXPPInkWash::IsActive(VFXPPInkWash *this, MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(2522, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2522, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields._toggle )
		  {
		    return this->fields._intensity != 0.0;
		  }
		  return result;
		}
		
		public void ResetComponentState(HGEnvironmentPhase envPhase) {} // 0x0000000189B619E4-0x0000000189B61A44
		// Void ResetComponentState(HGEnvironmentPhase)
		void HG::Rendering::Runtime::VFXPPInkWash::ResetComponentState(
		        VFXPPInkWash *this,
		        HGEnvironmentPhase *envPhase,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2523, 0LL) )
		  {
		    if ( envPhase )
		    {
		      envPhase->fields.inkWashConfig.enable = 0;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2523, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)envPhase,
		    0LL);
		}
		
		public void SetInkWashState(bool toggle, float intensity, bool isDrawing) {} // 0x0000000189B61C58-0x0000000189B61CE4
		// Void SetInkWashState(Boolean, Single, Boolean)
		void HG::Rendering::Runtime::VFXPPInkWash::SetInkWashState(
		        VFXPPInkWash *this,
		        bool toggle,
		        float intensity,
		        bool isDrawing,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2524, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2524, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_955(Patch, (Object *)this, toggle, intensity, isDrawing, 0LL);
		  }
		  else
		  {
		    this->fields._intensity = intensity;
		    this->fields._toggle = toggle;
		    this->fields._isDrawing = isDrawing;
		  }
		}
		
		public void RequestNewInkDraw(bool addNewInkDrop) {} // 0x0000000189B61934-0x0000000189B61990
		// Void RequestNewInkDraw(Boolean)
		void HG::Rendering::Runtime::VFXPPInkWash::RequestNewInkDraw(
		        VFXPPInkWash *this,
		        bool addNewInkDrop,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2520, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2520, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
		      (ILFixDynamicMethodWrapper_18 *)Patch,
		      (Object *)this,
		      addNewInkDrop,
		      0LL);
		  }
		  else
		  {
		    this->fields._addNewInkDrop = addNewInkDrop;
		  }
		}
		
		public void SetInkDropDirection(Vector3 inkPointDir) {} // 0x0000000189B61BD8-0x0000000189B61C58
		// Void SetInkDropDirection(Vector3)
		void HG::Rendering::Runtime::VFXPPInkWash::SetInkDropDirection(
		        VFXPPInkWash *this,
		        Vector3 *inkPointDir,
		        MethodInfo *method)
		{
		  float v5; // eax
		  __int64 v6; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2525, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2525, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v6);
		    z = inkPointDir->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&inkPointDir->x;
		    v9.z = z;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_370(Patch, (Object *)this, &v9, 0LL);
		  }
		  else
		  {
		    v5 = inkPointDir->z;
		    *(_QWORD *)&this->fields._inkPointDir.x = *(_QWORD *)&inkPointDir->x;
		    this->fields._inkPointDir.z = v5;
		  }
		}
		
		private float GetCurrentTime() => default; // 0x0000000189B617F0-0x0000000189B6184C
		// Single GetCurrentTime()
		float HG::Rendering::Runtime::VFXPPInkWash::GetCurrentTime(VFXPPInkWash *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2519, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2519, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		    return HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
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
		
		public bool __iFixBaseProxy_get_ImplementedInVolume() => default; // 0x0000000189B60198-0x0000000189B601A0
		// Boolean <>iFixBaseProxy_get_ImplementedInVolume()
		bool HG::Rendering::Runtime::VFXPPInkWash::__iFixBaseProxy_get_ImplementedInVolume(
		        VFXPPInkWash *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::get_ImplementedInVolume((VFXPPComponent *)this, 0LL);
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
		
		public void __iFixBaseProxy_ApplyEnvPhase(HGEnvironmentPhase P0) {} // 0x0000000189B60188-0x0000000189B60190
		// Void <>iFixBaseProxy_ApplyEnvPhase(HGEnvironmentPhase)
		void HG::Rendering::Runtime::VFXPPInkWash::__iFixBaseProxy_ApplyEnvPhase(
		        VFXPPInkWash *this,
		        HGEnvironmentPhase *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::ApplyEnvPhase((VFXPPComponent *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_ResetEnvPhase(HGEnvironmentPhase P0) {} // 0x0000000189B60190-0x0000000189B60198
		// Void <>iFixBaseProxy_ResetEnvPhase(HGEnvironmentPhase)
		void HG::Rendering::Runtime::VFXPPInkWash::__iFixBaseProxy_ResetEnvPhase(
		        VFXPPInkWash *this,
		        HGEnvironmentPhase *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPPComponent::ResetEnvPhase((VFXPPComponent *)this, P0, 0LL);
		}
		
		public bool __iFixBaseProxy_IsActive() => default; // 0x0000000189B5D8F0-0x0000000189B5D8F8
		// Boolean <>iFixBaseProxy_IsActive()
		bool HG::Rendering::Runtime::VFXPPVignette::__iFixBaseProxy_IsActive(VFXPPVignette *this, MethodInfo *method)
		{
		  return HG::Rendering::Runtime::VFXPPComponent::IsActive((VFXPPComponent *)this, 0LL);
		}
		
	}
}
