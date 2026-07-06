using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("HG/AutoExposure", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class HGAutoExposure : VolumeComponent
	{
		public HGAutoExposure()
		{
			// // HGAutoExposure()
			// void HG::Rendering::Runtime::HGAutoExposure::HGAutoExposure(HGAutoExposure *this, MethodInfo *method)
			// {
			//   MethodInfo *v2; // xmm10_8
			//   BoolParameter *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   BoolParameter *v7; // rdi
			//   OneofDescriptorProto *v8; // rdx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   AutoExposureModeParameter *v11; // rax
			//   AutoExposureModeParameter *v12; // rdi
			//   OneofDescriptorProto *v13; // rdx
			//   FileDescriptor *v14; // r8
			//   MessageDescriptor *v15; // r9
			//   AnimationCurve *v16; // rax
			//   AnimationCurve *v17; // rsi
			//   AnimationCurveParameter *v18; // rax
			//   AnimationCurveParameter *v19; // rdi
			//   OneofDescriptorProto *v20; // rdx
			//   FileDescriptor *v21; // r8
			//   MessageDescriptor *v22; // r9
			//   ClampedFloatParameter *v23; // rax
			//   ClampedFloatParameter *v24; // rdi
			//   OneofDescriptorProto *v25; // rdx
			//   FileDescriptor *v26; // r8
			//   MessageDescriptor *v27; // r9
			//   BoolParameter *v28; // rax
			//   BoolParameter *v29; // rdi
			//   OneofDescriptorProto *v30; // rdx
			//   FileDescriptor *v31; // r8
			//   MessageDescriptor *v32; // r9
			//   ClampedFloatParameter *v33; // rax
			//   ClampedFloatParameter *v34; // rdi
			//   OneofDescriptorProto *v35; // rdx
			//   FileDescriptor *v36; // r8
			//   MessageDescriptor *v37; // r9
			//   ClampedFloatParameter *v38; // rax
			//   ClampedFloatParameter *v39; // rdi
			//   OneofDescriptorProto *v40; // rdx
			//   FileDescriptor *v41; // r8
			//   MessageDescriptor *v42; // r9
			//   FloatRangeParameter *v43; // rax
			//   FloatRangeParameter *v44; // rdi
			//   OneofDescriptorProto *v45; // rdx
			//   FileDescriptor *v46; // r8
			//   MessageDescriptor *v47; // r9
			//   FloatRangeParameter *v48; // rax
			//   FloatRangeParameter *v49; // rdi
			//   OneofDescriptorProto *v50; // rdx
			//   FileDescriptor *v51; // r8
			//   MessageDescriptor *v52; // r9
			//   AutoExposureMeteringModeParameter *v53; // rax
			//   AutoExposureMeteringModeParameter *v54; // rdi
			//   OneofDescriptorProto *v55; // rdx
			//   FileDescriptor *v56; // r8
			//   MessageDescriptor *v57; // r9
			//   ClampedFloatParameter *v58; // rax
			//   ClampedFloatParameter *v59; // rdi
			//   OneofDescriptorProto *v60; // rdx
			//   FileDescriptor *v61; // r8
			//   MessageDescriptor *v62; // r9
			//   FloatRangeParameter *v63; // rax
			//   FloatRangeParameter *v64; // rdi
			//   OneofDescriptorProto *v65; // rdx
			//   FileDescriptor *v66; // r8
			//   MessageDescriptor *v67; // r9
			//   ClampedFloatParameter *v68; // rax
			//   ClampedFloatParameter *v69; // rdi
			//   OneofDescriptorProto *v70; // rdx
			//   FileDescriptor *v71; // r8
			//   MessageDescriptor *v72; // r9
			//   FloatRangeParameter *v73; // rax
			//   FloatRangeParameter *v74; // rdi
			//   OneofDescriptorProto *v75; // rdx
			//   FileDescriptor *v76; // r8
			//   MessageDescriptor *v77; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStatee; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStatef; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStateg; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStateh; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStatei; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStated; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStatej; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStatek; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStatel; // [rsp+20h] [rbp-68h]
			//   String__Array *overrideStatem; // [rsp+20h] [rbp-68h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methodj; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methodk; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methodl; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methodm; // [rsp+28h] [rbp-60h]
			//   MethodInfo *methodn; // [rsp+28h] [rbp-60h]
			//   MethodInfo *v106; // [rsp+30h] [rbp-58h]
			//   MethodInfo *v107; // [rsp+30h] [rbp-58h]
			//   MethodInfo *v108; // [rsp+30h] [rbp-58h]
			//   MethodInfo *v109; // [rsp+30h] [rbp-58h]
			//   MethodInfo *v110; // [rsp+30h] [rbp-58h]
			//   MethodInfo *v111; // [rsp+30h] [rbp-58h]
			//   MethodInfo *v112; // [rsp+30h] [rbp-58h]
			//   MethodInfo *v113; // [rsp+30h] [rbp-58h]
			//   MethodInfo *v114; // [rsp+30h] [rbp-58h]
			//   MethodInfo *v115; // [rsp+30h] [rbp-58h]
			//   MethodInfo *v116; // [rsp+30h] [rbp-58h]
			//   MethodInfo *v117; // [rsp+30h] [rbp-58h]
			//   MethodInfo *v118; // [rsp+30h] [rbp-58h]
			// 
			//   if ( !byte_18D8ED9C9 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::AnimationCurveParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::AnimationCurve);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::AutoExposureMeteringModeParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::AutoExposureModeParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::FloatRangeParameter);
			//     byte_18D8ED9C9 = 1;
			//   }
			//   v4 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v7 = v4;
			//   if ( !v4 )
			//     goto LABEL_19;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v4, 0, 0, 0LL);
			//   this.fields.autoExposureEnabled = v7;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.autoExposureEnabled, v8, v9, v10, overrideState, (String *)methoda, v2);
			//   v11 = (AutoExposureModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::AutoExposureModeParameter);
			//   v12 = v11;
			//   if ( !v11 )
			//     goto LABEL_19;
			//   HG::Rendering::Runtime::AutoExposureModeParameter::AutoExposureModeParameter(v11, AutoExposureMode__Enum_Auto, 0, 0LL);
			//   this.fields.autoModeEnabled = v12;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.autoModeEnabled,
			//     v13,
			//     v14,
			//     v15,
			//     overrideStatea,
			//     (String *)methodb,
			//     v106);
			//   v16 = (AnimationCurve *)sub_180004920(TypeInfo::UnityEngine::AnimationCurve);
			//   v17 = v16;
			//   if ( !v16 )
			//     goto LABEL_19;
			//   UnityEngine::AnimationCurve::AnimationCurve(v16, 0LL);
			//   v18 = (AnimationCurveParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::AnimationCurveParameter);
			//   v19 = v18;
			//   if ( !v18 )
			//     goto LABEL_19;
			//   UnityEngine::Rendering::AnimationCurveParameter::AnimationCurveParameter(v18, v17, 0, 0LL);
			//   this.fields.envEV100CompensationCurve = v19;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.envEV100CompensationCurve,
			//     v20,
			//     v21,
			//     v22,
			//     overrideStateb,
			//     (String *)methodc,
			//     v107);
			//   v23 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v24 = v23;
			//   if ( !v23 )
			//     goto LABEL_19;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v23, 0.0, -8.0, 8.0, 0, 0LL);
			//   this.fields.manualEVCompensationAuto = v24;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.manualEVCompensationAuto,
			//     v25,
			//     v26,
			//     v27,
			//     overrideStatee,
			//     (String *)methodf,
			//     v108);
			//   v28 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v29 = v28;
			//   if ( !v28 )
			//     goto LABEL_19;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v28, 0, 0, 0LL);
			//   this.fields.curveEditModeEnabled = v29;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.curveEditModeEnabled,
			//     v30,
			//     v31,
			//     v32,
			//     overrideStatec,
			//     (String *)methodd,
			//     v109);
			//   v33 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v34 = v33;
			//   if ( !v33 )
			//     goto LABEL_19;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v33, 0.60000002, 0.0099999998, 20.0, 0, 0LL);
			//   this.fields.exposureLerpUpSpeed = v34;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.exposureLerpUpSpeed,
			//     v35,
			//     v36,
			//     v37,
			//     overrideStatef,
			//     (String *)methodg,
			//     v110);
			//   v38 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v39 = v38;
			//   if ( !v38 )
			//     goto LABEL_19;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v38, 0.40000001, 0.0099999998, 20.0, 0, 0LL);
			//   this.fields.exposureLerpDownSpeed = v39;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.exposureLerpDownSpeed,
			//     v40,
			//     v41,
			//     v42,
			//     overrideStateg,
			//     (String *)methodh,
			//     v111);
			//   v43 = (FloatRangeParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatRangeParameter);
			//   v44 = v43;
			//   if ( !v43 )
			//     goto LABEL_19;
			//   UnityEngine::Rendering::FloatRangeParameter::FloatRangeParameter(
			//     v43,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0xC1000000, (__m128)0x40800000u),
			//     -16.0,
			//     8.0,
			//     0,
			//     0LL);
			//   this.fields.exposureEV100Range = v44;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.exposureEV100Range,
			//     v45,
			//     v46,
			//     v47,
			//     overrideStateh,
			//     (String *)methodi,
			//     v112);
			//   v48 = (FloatRangeParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatRangeParameter);
			//   v49 = v48;
			//   if ( !v48 )
			//     goto LABEL_19;
			//   UnityEngine::Rendering::FloatRangeParameter::FloatRangeParameter(
			//     v48,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0xC1000000, (__m128)0x40800000u),
			//     -8.0,
			//     4.0,
			//     0,
			//     0LL);
			//   this.fields.exposureEV100HistogramRange = v49;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.exposureEV100HistogramRange,
			//     v50,
			//     v51,
			//     v52,
			//     overrideStatei,
			//     (String *)methodj,
			//     v113);
			//   v53 = (AutoExposureMeteringModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::AutoExposureMeteringModeParameter);
			//   v54 = v53;
			//   if ( !v53 )
			//     goto LABEL_19;
			//   HG::Rendering::Runtime::AutoExposureMeteringModeParameter::AutoExposureMeteringModeParameter(
			//     v53,
			//     AutoExposureMeteringMode__Enum_Center,
			//     0,
			//     0LL);
			//   this.fields.meteringMode = v54;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.meteringMode, v55, v56, v57, overrideStated, (String *)methode, v114);
			//   v58 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v59 = v58;
			//   if ( !v58 )
			//     goto LABEL_19;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v58, 0.75, 0.0, 1.0, 0, 0LL);
			//   this.fields.centerPixelWeight = v59;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.centerPixelWeight,
			//     v60,
			//     v61,
			//     v62,
			//     overrideStatej,
			//     (String *)methodk,
			//     v115);
			//   v63 = (FloatRangeParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatRangeParameter);
			//   v64 = v63;
			//   if ( !v63 )
			//     goto LABEL_19;
			//   UnityEngine::Rendering::FloatRangeParameter::FloatRangeParameter(
			//     v63,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3D4CCCCDu, (__m128)0x3F733333u),
			//     0.0,
			//     1.0,
			//     0,
			//     0LL);
			//   this.fields.pixelLuminanceRange = v64;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.pixelLuminanceRange,
			//     v65,
			//     v66,
			//     v67,
			//     overrideStatek,
			//     (String *)methodl,
			//     v116);
			//   v68 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v69 = v68;
			//   if ( !v68
			//     || (UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v68, 0.0, -8.0, 8.0, 0, 0LL),
			//         this.fields.manualEVCompensation = v69,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.manualEVCompensation,
			//           v70,
			//           v71,
			//           v72,
			//           overrideStatel,
			//           (String *)methodm,
			//           v117),
			//         v73 = (FloatRangeParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatRangeParameter),
			//         (v74 = v73) == 0LL) )
			//   {
			// LABEL_19:
			//     sub_180B536AC(v6, v5);
			//   }
			//   UnityEngine::Rendering::FloatRangeParameter::FloatRangeParameter(
			//     v73,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0xC0800000, (__m128)0x40800000u),
			//     -8.0,
			//     8.0,
			//     0,
			//     0LL);
			//   this.fields.evClampRange = v74;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.evClampRange, v75, v76, v77, overrideStatem, (String *)methodn, v118);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGAutoExposure::IsActive(HGAutoExposure *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   BoolParameter *autoExposureEnabled; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2220, 0LL) )
			//   {
			//     autoExposureEnabled = this.fields.autoExposureEnabled;
			//     if ( autoExposureEnabled )
			//       return sub_1800023D0(10LL, autoExposureEnabled);
			// LABEL_5:
			//     sub_180B536AC(v3, autoExposureEnabled);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2220, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		[Tooltip("Exposure Mode")]
		public BoolParameter autoExposureEnabled;

		[Tooltip("Auto Mode / Manual Mode")]
		public AutoExposureModeParameter autoModeEnabled;

		[Tooltip("Environment Exposure Compensation")]
		public AnimationCurveParameter envEV100CompensationCurve;

		[Tooltip("Environment Manual Exposure Auto Mode")]
		public ClampedFloatParameter manualEVCompensationAuto;

		public BoolParameter curveEditModeEnabled;

		[Tooltip("Exposure Lerp Up Speed")]
		public ClampedFloatParameter exposureLerpUpSpeed;

		[Tooltip("Exposure Lerp Down Speed")]
		public ClampedFloatParameter exposureLerpDownSpeed;

		[Tooltip("EV100 Range")]
		public FloatRangeParameter exposureEV100Range;

		[Tooltip("EV100 Histogram Range")]
		public FloatRangeParameter exposureEV100HistogramRange;

		[Tooltip("Metering Mode")]
		public AutoExposureMeteringModeParameter meteringMode;

		[Tooltip("Metering Center Pixel Weight")]
		public ClampedFloatParameter centerPixelWeight;

		[Tooltip("Pixel luminance percent range")]
		public FloatRangeParameter pixelLuminanceRange;

		[Tooltip("Environment Manual Exposure")]
		public ClampedFloatParameter manualEVCompensation;

		[Tooltip("EV100 Clamp Range")]
		public FloatRangeParameter evClampRange;
	}
}
