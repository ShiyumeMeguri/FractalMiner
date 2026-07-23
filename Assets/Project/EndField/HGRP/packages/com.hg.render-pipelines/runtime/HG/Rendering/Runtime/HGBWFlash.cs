using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("HG/BWFlash", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class HGBWFlash : VolumeComponent // TypeDefIndex: 38019
	{
		// Fields
		public BoolParameter enabled; // 0x30
		public Vector2Parameter centerPosition; // 0x38
		public ClampedFloatParameter bwSceneLerp; // 0x40
		public ClampedFloatParameter bwThreshold; // 0x48
		public ClampedFloatParameter colorBias; // 0x50
		public BoolParameter inverse; // 0x58
		public BoolParameter useFlashTex; // 0x60
		public Texture2DParameter flashTexture; // 0x68
		public Vector2Parameter flashTexTiling; // 0x70
		public Vector2Parameter flashTexOffset; // 0x78
		public Vector2Parameter flashTexSpeed; // 0x80
		public Vector2Parameter flashIntensity; // 0x88
		public BoolParameter useMaskTex; // 0x90
		public Texture2DParameter maskTexture; // 0x98
		public ClampedFloatParameter maskIntensity; // 0xA0
		public BoolParameter maskUsePolarUV; // 0xA8
		public Vector2Parameter maskTexTiling; // 0xB0
		public Vector2Parameter maskTexOffset; // 0xB8
		public ColorParameter flashColor; // 0xC0
		public ColorParameter backGroundColor; // 0xC8
	
		// Constructors
		public HGBWFlash() {} // 0x000000018402C250-0x000000018402C6E0
		// HGBWFlash()
		void HG::Rendering::Runtime::HGBWFlash::HGBWFlash(HGBWFlash *this, MethodInfo *method)
		{
		  BoolParameter *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rax
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  __int64 v14; // rax
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  __int64 v17; // rax
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  BoolParameter *v20; // rax
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  BoolParameter *v23; // rax
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  Texture2DParameter *v26; // rax
		  Texture2DParameter *v27; // rdi
		  Type *v28; // rdx
		  PropertyInfo_1 *v29; // r8
		  Int32__Array **v30; // r9
		  __int64 v31; // rax
		  PropertyInfo_1 *v32; // r8
		  Int32__Array **v33; // r9
		  __int64 v34; // rax
		  PropertyInfo_1 *v35; // r8
		  Int32__Array **v36; // r9
		  __int64 v37; // rax
		  PropertyInfo_1 *v38; // r8
		  Int32__Array **v39; // r9
		  __int64 v40; // rax
		  PropertyInfo_1 *v41; // r8
		  Int32__Array **v42; // r9
		  BoolParameter *v43; // rax
		  PropertyInfo_1 *v44; // r8
		  Int32__Array **v45; // r9
		  Texture2DParameter *v46; // rax
		  Texture2DParameter *v47; // rdi
		  Type *v48; // rdx
		  PropertyInfo_1 *v49; // r8
		  Int32__Array **v50; // r9
		  __int64 v51; // rax
		  PropertyInfo_1 *v52; // r8
		  Int32__Array **v53; // r9
		  BoolParameter *v54; // rax
		  PropertyInfo_1 *v55; // r8
		  Int32__Array **v56; // r9
		  __int64 v57; // rax
		  PropertyInfo_1 *v58; // r8
		  Int32__Array **v59; // r9
		  __int64 v60; // rax
		  PropertyInfo_1 *v61; // r8
		  Int32__Array **v62; // r9
		  MethodInfo *v63; // rdx
		  __int64 v64; // rax
		  PropertyInfo_1 *v65; // r8
		  Int32__Array **v66; // r9
		  Quaternion v67; // xmm0
		  MethodInfo *v68; // rdx
		  __int64 v69; // rax
		  PropertyInfo_1 *v70; // r8
		  Int32__Array **v71; // r9
		  Quaternion v72; // xmm0
		  Quaternion v73; // [rsp+20h] [rbp-18h] BYREF
		
		  v3 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_22;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.enabled = v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.enabled, v4, v6, v7, *(MethodInfo **)&v73.x);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v8 )
		    goto LABEL_22;
		  *(_DWORD *)(v8 + 24) = 1056964608;
		  *(_DWORD *)(v8 + 28) = 1056964608;
		  *(_BYTE *)(v8 + 16) = 0;
		  this->fields.centerPosition = (Vector2Parameter *)v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.centerPosition, v4, v9, v10, *(MethodInfo **)&v73.x);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v11 )
		    goto LABEL_22;
		  *(_DWORD *)(v11 + 24) = 1065353216;
		  *(_BYTE *)(v11 + 16) = 0;
		  *(_DWORD *)(v11 + 32) = 0;
		  *(_DWORD *)(v11 + 36) = 1065353216;
		  *(_DWORD *)(v11 + 40) = 1065353216;
		  this->fields.bwSceneLerp = (ClampedFloatParameter *)v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.bwSceneLerp, v4, v12, v13, *(MethodInfo **)&v73.x);
		  v14 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v14 )
		    goto LABEL_22;
		  *(_DWORD *)(v14 + 24) = 1065353216;
		  *(_BYTE *)(v14 + 16) = 0;
		  *(_DWORD *)(v14 + 32) = 1057132380;
		  *(_DWORD *)(v14 + 36) = 1065353216;
		  *(_DWORD *)(v14 + 40) = 1065353216;
		  this->fields.bwThreshold = (ClampedFloatParameter *)v14;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.bwThreshold, v4, v15, v16, *(MethodInfo **)&v73.x);
		  v17 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v17 )
		    goto LABEL_22;
		  *(_DWORD *)(v17 + 24) = 0;
		  *(_BYTE *)(v17 + 16) = 0;
		  *(_DWORD *)(v17 + 32) = -1082130432;
		  *(_DWORD *)(v17 + 36) = 1065353216;
		  *(_DWORD *)(v17 + 40) = 1065353216;
		  this->fields.colorBias = (ClampedFloatParameter *)v17;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.colorBias, v4, v18, v19, *(MethodInfo **)&v73.x);
		  v20 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v20 )
		    goto LABEL_22;
		  v20->fields._.m_Value = 0;
		  v20->fields._._.overrideState = 0;
		  this->fields.inverse = v20;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.inverse, v4, v21, v22, *(MethodInfo **)&v73.x);
		  v23 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v23 )
		    goto LABEL_22;
		  v23->fields._.m_Value = 0;
		  v23->fields._._.overrideState = 0;
		  this->fields.useFlashTex = v23;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.useFlashTex, v4, v24, v25, *(MethodInfo **)&v73.x);
		  v26 = (Texture2DParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
		  v27 = v26;
		  if ( !v26 )
		    goto LABEL_22;
		  UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v26, 0LL, 0, 0LL);
		  this->fields.flashTexture = v27;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.flashTexture, v28, v29, v30, *(MethodInfo **)&v73.x);
		  v31 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v31 )
		    goto LABEL_22;
		  *(_DWORD *)(v31 + 24) = 1065353216;
		  *(_DWORD *)(v31 + 28) = 1065353216;
		  *(_BYTE *)(v31 + 16) = 0;
		  this->fields.flashTexTiling = (Vector2Parameter *)v31;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.flashTexTiling, v4, v32, v33, *(MethodInfo **)&v73.x);
		  v34 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v34 )
		    goto LABEL_22;
		  *(_QWORD *)(v34 + 24) = 0LL;
		  *(_BYTE *)(v34 + 16) = 0;
		  this->fields.flashTexOffset = (Vector2Parameter *)v34;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.flashTexOffset, v4, v35, v36, *(MethodInfo **)&v73.x);
		  v37 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v37 )
		    goto LABEL_22;
		  *(_QWORD *)(v37 + 24) = 0LL;
		  *(_BYTE *)(v37 + 16) = 0;
		  this->fields.flashTexSpeed = (Vector2Parameter *)v37;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.flashTexSpeed, v4, v38, v39, *(MethodInfo **)&v73.x);
		  v40 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v40 )
		    goto LABEL_22;
		  *(_DWORD *)(v40 + 24) = 1065353216;
		  *(_DWORD *)(v40 + 28) = 1065353216;
		  *(_BYTE *)(v40 + 16) = 0;
		  this->fields.flashIntensity = (Vector2Parameter *)v40;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.flashIntensity, v4, v41, v42, *(MethodInfo **)&v73.x);
		  v43 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v43 )
		    goto LABEL_22;
		  v43->fields._.m_Value = 0;
		  v43->fields._._.overrideState = 0;
		  this->fields.useMaskTex = v43;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.useMaskTex, v4, v44, v45, *(MethodInfo **)&v73.x);
		  v46 = (Texture2DParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
		  v47 = v46;
		  if ( !v46 )
		    goto LABEL_22;
		  UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v46, 0LL, 0, 0LL);
		  this->fields.maskTexture = v47;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.maskTexture, v48, v49, v50, *(MethodInfo **)&v73.x);
		  v51 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v51 )
		    goto LABEL_22;
		  *(_DWORD *)(v51 + 24) = 1065353216;
		  *(_BYTE *)(v51 + 16) = 0;
		  *(_DWORD *)(v51 + 32) = 0;
		  *(_DWORD *)(v51 + 36) = 1065353216;
		  *(_DWORD *)(v51 + 40) = 1065353216;
		  this->fields.maskIntensity = (ClampedFloatParameter *)v51;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.maskIntensity, v4, v52, v53, *(MethodInfo **)&v73.x);
		  v54 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v54 )
		    goto LABEL_22;
		  v54->fields._.m_Value = 0;
		  v54->fields._._.overrideState = 0;
		  this->fields.maskUsePolarUV = v54;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.maskUsePolarUV, v4, v55, v56, *(MethodInfo **)&v73.x);
		  v57 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v57 )
		    goto LABEL_22;
		  *(_DWORD *)(v57 + 24) = 1065353216;
		  *(_DWORD *)(v57 + 28) = 1065353216;
		  *(_BYTE *)(v57 + 16) = 0;
		  this->fields.maskTexTiling = (Vector2Parameter *)v57;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.maskTexTiling, v4, v58, v59, *(MethodInfo **)&v73.x);
		  v60 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v60 )
		    goto LABEL_22;
		  *(_QWORD *)(v60 + 24) = 0LL;
		  *(_BYTE *)(v60 + 16) = 0;
		  this->fields.maskTexOffset = (Vector2Parameter *)v60;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.maskTexOffset, v4, v61, v62, *(MethodInfo **)&v73.x);
		  v73 = (Quaternion)*UnityEngine::Vector4::get_one((Vector4 *)&v73, v63);
		  v64 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v64 )
		    goto LABEL_22;
		  v67 = v73;
		  *(_WORD *)(v64 + 40) = 0;
		  *(_BYTE *)(v64 + 42) = 1;
		  *(Quaternion *)(v64 + 24) = v67;
		  *(_BYTE *)(v64 + 16) = 0;
		  this->fields.flashColor = (ColorParameter *)v64;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.flashColor, v4, v65, v66, *(MethodInfo **)&v73.x);
		  v73 = *UnityEngine::Quaternion::get_identity(&v73, v68);
		  v69 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v69 )
		LABEL_22:
		    sub_1800D8260(v5, v4);
		  v72 = v73;
		  *(_WORD *)(v69 + 40) = 0;
		  *(_BYTE *)(v69 + 42) = 1;
		  *(Quaternion *)(v69 + 24) = v72;
		  *(_BYTE *)(v69 + 16) = 0;
		  this->fields.backGroundColor = (ColorParameter *)v69;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.backGroundColor, v4, v70, v71, *(MethodInfo **)&v73.x);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B69344-0x0000000189B693A0
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGBWFlash::IsActive(HGBWFlash *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  BoolParameter *enabled; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2678, 0LL) )
		  {
		    enabled = this->fields.enabled;
		    if ( enabled )
		      return sub_180006280(10LL, enabled);
		LABEL_5:
		    sub_1800D8260(v3, enabled);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2678, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
