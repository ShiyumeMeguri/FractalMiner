using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("Post-processing/HGVignette", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class HGVignette : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38053
	{
		// Fields
		[Tooltip("Specifies the color of the vignette.")]
		public ColorParameter color; // 0x30
		[Tooltip("Controls the strength of the vignette effect.")]
		public ClampedFloatParameter intensity; // 0x38
		[Tooltip("Controls the smoothness of the vignette borders.")]
		public ClampedFloatParameter smoothness; // 0x40
		[Tooltip("When enabled, the vignette is perfectly round. When disabled, the vignette matches shape with the current aspect ratio.")]
		public BoolParameter rounded; // 0x48
		[Tooltip("Blink")]
		public BoolParameter blink; // 0x50
	
		// Constructors
		public HGVignette() {} // 0x0000000184581AC0-0x0000000184581C00
		// HGVignette()
		void HG::Rendering::Runtime::HGVignette::HGVignette(HGVignette *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  HGRuntimeGrassQuery_Node *v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  Quaternion v8; // xmm0
		  __int64 v9; // rax
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  __int64 v12; // rax
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  BoolParameter *v15; // rax
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  BoolParameter *v18; // rax
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  Quaternion v21; // [rsp+20h] [rbp-18h] BYREF
		
		  v21 = *UnityEngine::Quaternion::get_identity(&v21, method);
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v3 )
		    goto LABEL_7;
		  v8 = v21;
		  *(_WORD *)(v3 + 40) = 0;
		  *(_BYTE *)(v3 + 42) = 1;
		  *(Quaternion *)(v3 + 24) = v8;
		  *(_BYTE *)(v3 + 16) = 0;
		  this->fields.color = (ColorParameter *)v3;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.color, v4, v6, v7, *(MethodInfo **)&v21.x);
		  v9 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v9 )
		    goto LABEL_7;
		  *(_DWORD *)(v9 + 36) = 1065353216;
		  *(_DWORD *)(v9 + 24) = 0;
		  *(_BYTE *)(v9 + 16) = 0;
		  *(_DWORD *)(v9 + 32) = 0;
		  *(_DWORD *)(v9 + 40) = 1065353216;
		  this->fields.intensity = (ClampedFloatParameter *)v9;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.intensity, v4, v10, v11, *(MethodInfo **)&v21.x);
		  v12 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v12 )
		    goto LABEL_7;
		  *(_DWORD *)(v12 + 24) = 1045220557;
		  *(_BYTE *)(v12 + 16) = 0;
		  *(_DWORD *)(v12 + 32) = 1008981770;
		  *(_DWORD *)(v12 + 36) = 1065353216;
		  *(_DWORD *)(v12 + 40) = 1065353216;
		  this->fields.smoothness = (ClampedFloatParameter *)v12;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.smoothness, v4, v13, v14, *(MethodInfo **)&v21.x);
		  v15 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v15
		    || (v15->fields._.m_Value = 0,
		        v15->fields._._.overrideState = 0,
		        this->fields.rounded = v15,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.rounded, v4, v16, v17, *(MethodInfo **)&v21.x),
		        (v18 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter)) == 0LL) )
		  {
		LABEL_7:
		    sub_1800D8260(v5, v4);
		  }
		  v18->fields._.m_Value = 0;
		  v18->fields._._.overrideState = 0;
		  this->fields.blink = v18;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.blink, v4, v19, v20, *(MethodInfo **)&v21.x);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B6D84C-0x0000000189B6D8B4
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGVignette::IsActive(HGVignette *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  ClampedFloatParameter *intensity; // rdx
		  double v5; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2702, 0LL) )
		  {
		    intensity = this->fields.intensity;
		    if ( intensity )
		    {
		      v5 = sub_1800057D0(10LL, intensity);
		      return *(float *)&v5 > 0.0;
		    }
		LABEL_5:
		    sub_1800D8260(v3, intensity);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2702, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
