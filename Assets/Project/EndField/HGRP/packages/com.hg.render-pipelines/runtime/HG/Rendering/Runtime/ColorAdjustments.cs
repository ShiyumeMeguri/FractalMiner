using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Color Adjustments", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class ColorAdjustments : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38007
	{
		// Fields
		[Tooltip("Adjusts the brightness of the image just before color grading, in EV.")]
		public FloatParameter postExposure; // 0x30
		[Tooltip("Controls the overall range of the tonal values.")]
		public ClampedFloatParameter contrast; // 0x38
		[Tooltip("Specifies the color that HGRP tints the render to.")]
		public ColorParameter colorFilter; // 0x40
		[Tooltip("Controls the hue of all colors in the render.")]
		public ClampedFloatParameter hueShift; // 0x48
		[Tooltip("Controls the intensity of all colors in the render.")]
		public ClampedFloatParameter saturation; // 0x50
	
		// Constructors
		public ColorAdjustments() {} // 0x000000018454EF30-0x000000018454F080
		// ColorAdjustments()
		void HG::Rendering::Runtime::ColorAdjustments::ColorAdjustments(ColorAdjustments *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  MethodInfo *v11; // rdx
		  __int64 v12; // rax
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  Vector4 v15; // xmm0
		  __int64 v16; // rax
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  __int64 v19; // rax
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  Vector4 v22; // [rsp+20h] [rbp-18h] BYREF
		
		  v3 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatParameter);
		  if ( !v3 )
		    goto LABEL_7;
		  *(_DWORD *)(v3 + 24) = 0;
		  *(_BYTE *)(v3 + 16) = 0;
		  this->fields.postExposure = (FloatParameter *)v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.postExposure, v4, v6, v7, *(MethodInfo **)&v22.x);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		    goto LABEL_7;
		  *(_DWORD *)(v8 + 24) = 0;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 32) = -1027080192;
		  *(_DWORD *)(v8 + 36) = 1120403456;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.contrast = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.contrast, v4, v9, v10, *(MethodInfo **)&v22.x);
		  v22 = *UnityEngine::Vector4::get_one(&v22, v11);
		  v12 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v12 )
		    goto LABEL_7;
		  v15 = v22;
		  *(_WORD *)(v12 + 40) = 1;
		  *(_BYTE *)(v12 + 42) = 1;
		  *(Vector4 *)(v12 + 24) = v15;
		  *(_BYTE *)(v12 + 16) = 0;
		  this->fields.colorFilter = (ColorParameter *)v12;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.colorFilter, v4, v13, v14, *(MethodInfo **)&v22.x);
		  v16 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v16 )
		    goto LABEL_7;
		  *(_DWORD *)(v16 + 24) = 0;
		  *(_BYTE *)(v16 + 16) = 0;
		  *(_DWORD *)(v16 + 32) = -1020002304;
		  *(_DWORD *)(v16 + 36) = 1127481344;
		  *(_DWORD *)(v16 + 40) = 1065353216;
		  this->fields.hueShift = (ClampedFloatParameter *)v16;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.hueShift, v4, v17, v18, *(MethodInfo **)&v22.x);
		  v19 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v19 )
		LABEL_7:
		    sub_1800D8260(v5, v4);
		  *(_DWORD *)(v19 + 24) = 0;
		  *(_BYTE *)(v19 + 16) = 0;
		  *(_DWORD *)(v19 + 32) = -1027080192;
		  *(_DWORD *)(v19 + 36) = 1120403456;
		  *(_DWORD *)(v19 + 40) = 1065353216;
		  this->fields.saturation = (ClampedFloatParameter *)v19;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.saturation, v4, v20, v21, *(MethodInfo **)&v22.x);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B68E34-0x0000000189B68F1C
		// Boolean IsActive()
		bool HG::Rendering::Runtime::ColorAdjustments::IsActive(ColorAdjustments *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  void *postExposure; // rdx
		  double v5; // xmm0_8
		  MethodInfo *v6; // rdx
		  double v7; // xmm0_8
		  Vector4 *one; // rax
		  ColorParameter *colorFilter; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v12; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2671, 0LL) )
		  {
		    postExposure = this->fields.postExposure;
		    if ( postExposure )
		    {
		      v5 = sub_1800057D0(10LL, postExposure);
		      if ( *(float *)&v5 != 0.0 )
		        return 1;
		      postExposure = this->fields.contrast;
		      if ( postExposure )
		      {
		        v7 = sub_1800057D0(10LL, postExposure);
		        if ( *(float *)&v7 == 0.0 )
		        {
		          one = UnityEngine::Vector4::get_one(&v12, v6);
		          colorFilter = this->fields.colorFilter;
		          v12 = *one;
		          if ( !(unsigned __int8)sub_1808AEDCC(colorFilter, &v12)
		            && !UnityEngine::Rendering::VolumeParameter<float>::op_Inequality(
		                  (VolumeParameter_1_System_Single_ *)this->fields.hueShift,
		                  0.0,
		                  MethodInfo::UnityEngine::Rendering::VolumeParameter<float>::op_Inequality) )
		          {
		            return UnityEngine::Rendering::VolumeParameter<float>::op_Inequality(
		                     (VolumeParameter_1_System_Single_ *)this->fields.saturation,
		                     0.0,
		                     MethodInfo::UnityEngine::Rendering::VolumeParameter<float>::op_Inequality);
		          }
		        }
		        return 1;
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v3, postExposure);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2671, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
