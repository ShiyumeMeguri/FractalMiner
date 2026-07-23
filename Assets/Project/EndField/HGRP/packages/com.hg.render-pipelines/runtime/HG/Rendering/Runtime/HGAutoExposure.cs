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
	[VolumeComponentMenuForRenderPipeline("HG/AutoExposure", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class HGAutoExposure : VolumeComponent // TypeDefIndex: 38015
	{
		// Fields
		[Tooltip("Exposure Mode")]
		public BoolParameter autoExposureEnabled; // 0x30
		[Tooltip("Auto Mode / Manual Mode")]
		public AutoExposureModeParameter autoModeEnabled; // 0x38
		[Tooltip("Environment Exposure Compensation")]
		public AnimationCurveParameter envEV100CompensationCurve; // 0x40
		[Tooltip("Environment Manual Exposure Auto Mode")]
		public ClampedFloatParameter manualEVCompensationAuto; // 0x48
		public BoolParameter curveEditModeEnabled; // 0x50
		[Tooltip("Exposure Lerp Up Speed")]
		public ClampedFloatParameter exposureLerpUpSpeed; // 0x58
		[Tooltip("Exposure Lerp Down Speed")]
		public ClampedFloatParameter exposureLerpDownSpeed; // 0x60
		[Tooltip("EV100 Range")]
		public FloatRangeParameter exposureEV100Range; // 0x68
		[Tooltip("EV100 Histogram Range")]
		public FloatRangeParameter exposureEV100HistogramRange; // 0x70
		[Tooltip("Metering Mode")]
		public AutoExposureMeteringModeParameter meteringMode; // 0x78
		[Tooltip("Metering Center Pixel Weight")]
		public ClampedFloatParameter centerPixelWeight; // 0x80
		[Tooltip("Pixel luminance percent range")]
		public FloatRangeParameter pixelLuminanceRange; // 0x88
		[Tooltip("Environment Manual Exposure")]
		public ClampedFloatParameter manualEVCompensation; // 0x90
		[Tooltip("EV100 Clamp Range")]
		public FloatRangeParameter evClampRange; // 0x98
	
		// Constructors
		public HGAutoExposure() {} // 0x00000001843D3EC0-0x00000001843D42E0
		// HGAutoExposure()
		void HG::Rendering::Runtime::HGAutoExposure::HGAutoExposure(HGAutoExposure *this, MethodInfo *method)
		{
		  BoolParameter *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  AutoExposureModeParameter *v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  AnimationCurve *v11; // rax
		  AnimationCurve *v12; // rdi
		  AnimationCurveParameter *v13; // rax
		  AnimationCurveParameter *v14; // rsi
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  __int64 v18; // rax
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  BoolParameter *v21; // rax
		  PropertyInfo_1 *v22; // r8
		  Int32__Array **v23; // r9
		  __int64 v24; // rax
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  __int64 v27; // rax
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  FloatRangeParameter *v30; // rax
		  FloatRangeParameter *v31; // rdi
		  Type *v32; // rdx
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **v34; // r9
		  FloatRangeParameter *v35; // rax
		  FloatRangeParameter *v36; // rdi
		  Type *v37; // rdx
		  PropertyInfo_1 *v38; // r8
		  Int32__Array **v39; // r9
		  AutoExposureMeteringModeParameter *v40; // rax
		  PropertyInfo_1 *v41; // r8
		  Int32__Array **v42; // r9
		  __int64 v43; // rax
		  PropertyInfo_1 *v44; // r8
		  Int32__Array **v45; // r9
		  FloatRangeParameter *v46; // rax
		  FloatRangeParameter *v47; // rdi
		  Type *v48; // rdx
		  PropertyInfo_1 *v49; // r8
		  Int32__Array **v50; // r9
		  __int64 v51; // rax
		  PropertyInfo_1 *v52; // r8
		  Int32__Array **v53; // r9
		  FloatRangeParameter *v54; // rax
		  FloatRangeParameter *v55; // rdi
		  Type *v56; // rdx
		  PropertyInfo_1 *v57; // r8
		  Int32__Array **v58; // r9
		  MethodInfo *overrideState; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStatea; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStateb; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStatec; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStated; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStatee; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStatef; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStatej; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStatek; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStateg; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStateh; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStatel; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStatei; // [rsp+20h] [rbp-58h]
		  MethodInfo *overrideStatem; // [rsp+20h] [rbp-58h]
		
		  v3 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_17;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.autoExposureEnabled = v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.autoExposureEnabled, v4, v6, v7, overrideState);
		  v8 = (AutoExposureModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::AutoExposureModeParameter);
		  if ( !v8 )
		    goto LABEL_17;
		  v8->fields._.m_Value = 0;
		  v8->fields._._.overrideState = 0;
		  this->fields.autoModeEnabled = v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.autoModeEnabled, v4, v9, v10, overrideStatea);
		  v11 = (AnimationCurve *)sub_1800368D0(TypeInfo::UnityEngine::AnimationCurve);
		  v12 = v11;
		  if ( !v11 )
		    goto LABEL_17;
		  UnityEngine::AnimationCurve::AnimationCurve(v11, 0LL);
		  v13 = (AnimationCurveParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::AnimationCurveParameter);
		  v14 = v13;
		  if ( !v13 )
		    goto LABEL_17;
		  UnityEngine::Rendering::AnimationCurveParameter::AnimationCurveParameter(v13, v12, 0, 0LL);
		  this->fields.envEV100CompensationCurve = v14;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.envEV100CompensationCurve, v15, v16, v17, overrideStateb);
		  v18 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v18 )
		    goto LABEL_17;
		  *(_DWORD *)(v18 + 24) = 0;
		  *(_BYTE *)(v18 + 16) = 0;
		  *(_DWORD *)(v18 + 32) = -1056964608;
		  *(_DWORD *)(v18 + 36) = 1090519040;
		  *(_DWORD *)(v18 + 40) = 1065353216;
		  this->fields.manualEVCompensationAuto = (ClampedFloatParameter *)v18;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.manualEVCompensationAuto, v4, v19, v20, overrideStatec);
		  v21 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v21 )
		    goto LABEL_17;
		  v21->fields._.m_Value = 0;
		  v21->fields._._.overrideState = 0;
		  this->fields.curveEditModeEnabled = v21;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.curveEditModeEnabled, v4, v22, v23, overrideStated);
		  v24 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v24 )
		    goto LABEL_17;
		  *(_DWORD *)(v24 + 24) = 1058642330;
		  *(_BYTE *)(v24 + 16) = 0;
		  *(_DWORD *)(v24 + 32) = 1008981770;
		  *(_DWORD *)(v24 + 36) = 1101004800;
		  *(_DWORD *)(v24 + 40) = 1065353216;
		  this->fields.exposureLerpUpSpeed = (ClampedFloatParameter *)v24;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.exposureLerpUpSpeed, v4, v25, v26, overrideStatee);
		  v27 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v27 )
		    goto LABEL_17;
		  *(_DWORD *)(v27 + 24) = 1053609165;
		  *(_BYTE *)(v27 + 16) = 0;
		  *(_DWORD *)(v27 + 32) = 1008981770;
		  *(_DWORD *)(v27 + 36) = 1101004800;
		  *(_DWORD *)(v27 + 40) = 1065353216;
		  this->fields.exposureLerpDownSpeed = (ClampedFloatParameter *)v27;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.exposureLerpDownSpeed, v4, v28, v29, overrideStatef);
		  v30 = (FloatRangeParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatRangeParameter);
		  v31 = v30;
		  if ( !v30 )
		    goto LABEL_17;
		  UnityEngine::Rendering::FloatRangeParameter::FloatRangeParameter(
		    v30,
		    (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0xC1000000, (__m128)0x40800000u),
		    -16.0,
		    8.0,
		    0,
		    0LL);
		  this->fields.exposureEV100Range = v31;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.exposureEV100Range, v32, v33, v34, overrideStatej);
		  v35 = (FloatRangeParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatRangeParameter);
		  v36 = v35;
		  if ( !v35 )
		    goto LABEL_17;
		  UnityEngine::Rendering::FloatRangeParameter::FloatRangeParameter(
		    v35,
		    (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0xC1000000, (__m128)0x40800000u),
		    -8.0,
		    4.0,
		    0,
		    0LL);
		  this->fields.exposureEV100HistogramRange = v36;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.exposureEV100HistogramRange, v37, v38, v39, overrideStatek);
		  v40 = (AutoExposureMeteringModeParameter *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::AutoExposureMeteringModeParameter);
		  if ( !v40 )
		    goto LABEL_17;
		  v40->fields._.m_Value = 1;
		  v40->fields._._.overrideState = 0;
		  this->fields.meteringMode = v40;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.meteringMode, v4, v41, v42, overrideStateg);
		  v43 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v43 )
		    goto LABEL_17;
		  *(_DWORD *)(v43 + 24) = 1061158912;
		  *(_BYTE *)(v43 + 16) = 0;
		  *(_DWORD *)(v43 + 32) = 0;
		  *(_DWORD *)(v43 + 36) = 1065353216;
		  *(_DWORD *)(v43 + 40) = 1065353216;
		  this->fields.centerPixelWeight = (ClampedFloatParameter *)v43;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.centerPixelWeight, v4, v44, v45, overrideStateh);
		  v46 = (FloatRangeParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatRangeParameter);
		  v47 = v46;
		  if ( !v46 )
		    goto LABEL_17;
		  UnityEngine::Rendering::FloatRangeParameter::FloatRangeParameter(
		    v46,
		    (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3D4CCCCDu, (__m128)0x3F733333u),
		    0.0,
		    1.0,
		    0,
		    0LL);
		  this->fields.pixelLuminanceRange = v47;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.pixelLuminanceRange, v48, v49, v50, overrideStatel);
		  v51 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v51 )
		    goto LABEL_17;
		  *(_DWORD *)(v51 + 24) = 0;
		  *(_BYTE *)(v51 + 16) = 0;
		  *(_DWORD *)(v51 + 32) = -1056964608;
		  *(_DWORD *)(v51 + 36) = 1090519040;
		  *(_DWORD *)(v51 + 40) = 1065353216;
		  this->fields.manualEVCompensation = (ClampedFloatParameter *)v51;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.manualEVCompensation, v4, v52, v53, overrideStatei);
		  v54 = (FloatRangeParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatRangeParameter);
		  v55 = v54;
		  if ( !v54 )
		LABEL_17:
		    sub_1800D8260(v5, v4);
		  UnityEngine::Rendering::FloatRangeParameter::FloatRangeParameter(
		    v54,
		    (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0xC0800000, (__m128)0x40800000u),
		    -8.0,
		    8.0,
		    0,
		    0LL);
		  this->fields.evClampRange = v55;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.evClampRange, v56, v57, v58, overrideStatem);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B692E8-0x0000000189B69344
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGAutoExposure::IsActive(HGAutoExposure *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  BoolParameter *autoExposureEnabled; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2677, 0LL) )
		  {
		    autoExposureEnabled = this->fields.autoExposureEnabled;
		    if ( autoExposureEnabled )
		      return sub_180006280(10LL, autoExposureEnabled);
		LABEL_5:
		    sub_1800D8260(v3, autoExposureEnabled);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2677, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
