using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Vignette", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class Vignette : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38066
	{
		// Fields
		[Tooltip("Specifies the mode HDRP uses to display the vignette effect.")]
		public VignetteModeParameter mode; // 0x30
		[Tooltip("Specifies the color of the vignette.")]
		public ColorParameter color; // 0x38
		[Tooltip("Sets the center point for the vignette.")]
		public Vector2Parameter center; // 0x40
		[Tooltip("Controls the strength of the vignette effect.")]
		public ClampedFloatParameter intensity; // 0x48
		[Tooltip("Controls the smoothness of the vignette borders.")]
		public ClampedFloatParameter smoothness; // 0x50
		[Tooltip("Controls how round the vignette is, lower values result in a more square vignette.")]
		public ClampedFloatParameter roundness; // 0x58
		[Tooltip("When enabled, the vignette is perfectly round. When disabled, the vignette matches shape with the current aspect ratio.")]
		public BoolParameter rounded; // 0x60
		[Tooltip("Blink")]
		public BoolParameter blink; // 0x68
		[Tooltip("Specifies a black and white mask Texture to use as a vignette.")]
		public Texture2DParameter mask; // 0x70
		[Range(0f, 1f)]
		[Tooltip("Controls the opacity of the mask vignette. Lower values result in a more transparent vignette.")]
		public ClampedFloatParameter opacity; // 0x78
	
		// Constructors
		public Vignette() {} // 0x000000018402D730-0x000000018402D990
		// Vignette()
		void HG::Rendering::Runtime::Vignette::Vignette(Vignette *this, MethodInfo *method)
		{
		  VignetteModeParameter *v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // rdx
		  __int64 v9; // rax
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  Quaternion v12; // xmm0
		  __int64 v13; // rax
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  __int64 v16; // rax
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  __int64 v19; // rax
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  __int64 v22; // rax
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  BoolParameter *v25; // rax
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  BoolParameter *v28; // rax
		  HGRuntimeGrassQuery_Node *v29; // r8
		  Int32__Array **v30; // r9
		  Texture2DParameter *v31; // rax
		  Texture2DParameter *v32; // rdi
		  HGRuntimeGrassQuery_Node *v33; // rdx
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  __int64 v36; // rax
		  HGRuntimeGrassQuery_Node *v37; // r8
		  Int32__Array **v38; // r9
		  Quaternion v39; // [rsp+20h] [rbp-18h] BYREF
		
		  v3 = (VignetteModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::VignetteModeParameter);
		  if ( !v3 )
		    goto LABEL_12;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.mode = v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mode, v4, v6, v7, *(MethodInfo **)&v39.x);
		  v39 = *UnityEngine::Quaternion::get_identity(&v39, v8);
		  v9 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v9 )
		    goto LABEL_12;
		  v12 = v39;
		  *(_WORD *)(v9 + 40) = 0;
		  *(_BYTE *)(v9 + 42) = 1;
		  *(Quaternion *)(v9 + 24) = v12;
		  *(_BYTE *)(v9 + 16) = 0;
		  this->fields.color = (ColorParameter *)v9;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.color, v4, v10, v11, *(MethodInfo **)&v39.x);
		  v13 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v13 )
		    goto LABEL_12;
		  *(_DWORD *)(v13 + 24) = 1056964608;
		  *(_DWORD *)(v13 + 28) = 1056964608;
		  *(_BYTE *)(v13 + 16) = 0;
		  this->fields.center = (Vector2Parameter *)v13;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.center, v4, v14, v15, *(MethodInfo **)&v39.x);
		  v16 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v16 )
		    goto LABEL_12;
		  *(_DWORD *)(v16 + 24) = 0;
		  *(_BYTE *)(v16 + 16) = 0;
		  *(_DWORD *)(v16 + 32) = 0;
		  *(_DWORD *)(v16 + 36) = 1065353216;
		  *(_DWORD *)(v16 + 40) = 1065353216;
		  this->fields.intensity = (ClampedFloatParameter *)v16;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.intensity, v4, v17, v18, *(MethodInfo **)&v39.x);
		  v19 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v19 )
		    goto LABEL_12;
		  *(_DWORD *)(v19 + 24) = 1045220557;
		  *(_BYTE *)(v19 + 16) = 0;
		  *(_DWORD *)(v19 + 32) = 1008981770;
		  *(_DWORD *)(v19 + 36) = 1065353216;
		  *(_DWORD *)(v19 + 40) = 1065353216;
		  this->fields.smoothness = (ClampedFloatParameter *)v19;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.smoothness, v4, v20, v21, *(MethodInfo **)&v39.x);
		  v22 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v22 )
		    goto LABEL_12;
		  *(_DWORD *)(v22 + 24) = 1065353216;
		  *(_BYTE *)(v22 + 16) = 0;
		  *(_DWORD *)(v22 + 32) = 0;
		  *(_DWORD *)(v22 + 36) = 1065353216;
		  *(_DWORD *)(v22 + 40) = 1065353216;
		  this->fields.roundness = (ClampedFloatParameter *)v22;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.roundness, v4, v23, v24, *(MethodInfo **)&v39.x);
		  v25 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v25 )
		    goto LABEL_12;
		  v25->fields._.m_Value = 0;
		  v25->fields._._.overrideState = 0;
		  this->fields.rounded = v25;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.rounded, v4, v26, v27, *(MethodInfo **)&v39.x);
		  v28 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v28 )
		    goto LABEL_12;
		  v28->fields._.m_Value = 0;
		  v28->fields._._.overrideState = 0;
		  this->fields.blink = v28;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.blink, v4, v29, v30, *(MethodInfo **)&v39.x);
		  v31 = (Texture2DParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
		  v32 = v31;
		  if ( !v31
		    || (UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v31, 0LL, 0, 0LL),
		        this->fields.mask = v32,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.mask, v33, v34, v35, *(MethodInfo **)&v39.x),
		        (v36 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter)) == 0) )
		  {
		LABEL_12:
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v36 + 24) = 1065353216;
		  *(_BYTE *)(v36 + 16) = 0;
		  *(_DWORD *)(v36 + 32) = 0;
		  *(_DWORD *)(v36 + 36) = 1065353216;
		  *(_DWORD *)(v36 + 40) = 1065353216;
		  this->fields.opacity = (ClampedFloatParameter *)v36;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.opacity, v4, v37, v38, *(MethodInfo **)&v39.x);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B6E230-0x0000000189B6E324
		// Boolean IsActive()
		bool HG::Rendering::Runtime::Vignette::IsActive(Vignette *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  void *mode; // rdx
		  double v5; // xmm0_8
		  double v7; // xmm0_8
		  Object_1 *v8; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2709, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2709, 0LL);
		    if ( !Patch )
		      goto LABEL_15;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    mode = this->fields.mode;
		    if ( !mode )
		      goto LABEL_15;
		    if ( !(unsigned int)sub_180002F70(10LL, mode) )
		    {
		      mode = this->fields.intensity;
		      if ( !mode )
		        goto LABEL_15;
		      v5 = sub_1800057D0(10LL, mode);
		      if ( *(float *)&v5 > 0.0 )
		        return 1;
		    }
		    mode = this->fields.mode;
		    if ( !mode )
		LABEL_15:
		      sub_1800D8260(v3, mode);
		    if ( (unsigned int)sub_180002F70(10LL, mode) == 1 )
		    {
		      mode = this->fields.opacity;
		      if ( !mode )
		        goto LABEL_15;
		      v7 = sub_1800057D0(10LL, mode);
		      if ( *(float *)&v7 > 0.0 )
		      {
		        mode = this->fields.mask;
		        if ( mode )
		        {
		          v8 = (Object_1 *)sub_1800460A0(10LL, mode);
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          return UnityEngine::Object::op_Inequality(v8, 0LL, 0LL);
		        }
		        goto LABEL_15;
		      }
		    }
		    return 0;
		  }
		}
		
	}
}
