using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Color Adjustments", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class ColorAdjustments : VolumeComponent, IPostProcessComponent
	{
		public ColorAdjustments()
		{
			// // ColorAdjustments()
			// void HG::Rendering::Runtime::ColorAdjustments::ColorAdjustments(ColorAdjustments *this, MethodInfo *method)
			// {
			//   FloatParameter *v3; // rax
			//   OneofDescriptorProto *v4; // rdx
			//   __int64 v5; // rcx
			//   FloatParameter *v6; // rdi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   ClampedFloatParameter *v10; // rax
			//   ClampedFloatParameter *v11; // rdi
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   MethodInfo *v15; // rdx
			//   Vector4 v16; // xmm8
			//   __int64 v17; // rdi
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   ClampedFloatParameter *v20; // rax
			//   ClampedFloatParameter *v21; // rdi
			//   OneofDescriptorProto *v22; // rdx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   ClampedFloatParameter *v25; // rax
			//   ClampedFloatParameter *v26; // rdi
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-58h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-58h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-58h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-58h]
			//   String__Array *overrideStated; // [rsp+20h] [rbp-58h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-50h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-50h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-50h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-50h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-50h]
			//   Vector4 v40; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D8ED9C3 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::FloatParameter);
			//     byte_18D8ED9C3 = 1;
			//   }
			//   v3 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_11;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v3, 0.0, 0, 0LL);
			//   this.fields.postExposure = v6;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.postExposure,
			//     v7,
			//     v8,
			//     v9,
			//     overrideState,
			//     (String *)methoda,
			//     *(MethodInfo **)&v40.x);
			//   v10 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_11;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v10, 0.0, -100.0, 100.0, 0, 0LL);
			//   this.fields.contrast = v11;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.contrast,
			//     v12,
			//     v13,
			//     v14,
			//     overrideStateb,
			//     (String *)methodc,
			//     *(MethodInfo **)&v40.x);
			//   v16 = *UnityEngine::Vector4::get_one(&v40, v15);
			//   v17 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v17 )
			//     goto LABEL_11;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Vector4 *)(v17 + 24) = v16;
			//   *(_WORD *)(v17 + 40) = 1;
			//   *(_BYTE *)(v17 + 42) = 1;
			//   *(_BYTE *)(v17 + 16) = 0;
			//   this.fields.colorFilter = (ColorParameter *)v17;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.colorFilter,
			//     v4,
			//     v18,
			//     v19,
			//     overrideStatea,
			//     (String *)methodb,
			//     *(MethodInfo **)&v40.x);
			//   v20 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v21 = v20;
			//   if ( !v20
			//     || (UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v20, 0.0, -180.0, 180.0, 0, 0LL),
			//         this.fields.hueShift = v21,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.hueShift,
			//           v22,
			//           v23,
			//           v24,
			//           overrideStatec,
			//           (String *)methodd,
			//           *(MethodInfo **)&v40.x),
			//         v25 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter),
			//         (v26 = v25) == 0LL) )
			//   {
			// LABEL_11:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v25, 0.0, -100.0, 100.0, 0, 0LL);
			//   this.fields.saturation = v26;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.saturation,
			//     v27,
			//     v28,
			//     v29,
			//     overrideStated,
			//     (String *)methode,
			//     *(MethodInfo **)&v40.x);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::ColorAdjustments::IsActive(ColorAdjustments *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   void *postExposure; // rdx
			//   MethodInfo *v5; // rdx
			//   Vector4 *one; // rax
			//   ColorParameter *colorFilter; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v10; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919452 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<float>::op_Inequality);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::op_Inequality);
			//     byte_18D919452 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2214, 0LL) )
			//   {
			//     postExposure = this.fields.postExposure;
			//     if ( postExposure )
			//     {
			//       if ( sub_18003F9B0(10LL, postExposure) != 0.0 )
			//         return 1;
			//       postExposure = this.fields.contrast;
			//       if ( postExposure )
			//       {
			//         if ( sub_18003F9B0(10LL, postExposure) == 0.0 )
			//         {
			//           one = UnityEngine::Vector4::get_one(&v10, v5);
			//           colorFilter = this.fields.colorFilter;
			//           v10 = *one;
			//           if ( !(unsigned __int8)sub_180830160(colorFilter, &v10)
			//             && !UnityEngine::Rendering::VolumeParameter<float>::op_Inequality(
			//                   (VolumeParameter_1_System_Single_ *)this.fields.hueShift,
			//                   0.0,
			//                   MethodInfo::UnityEngine::Rendering::VolumeParameter<float>::op_Inequality) )
			//           {
			//             return UnityEngine::Rendering::VolumeParameter<float>::op_Inequality(
			//                      (VolumeParameter_1_System_Single_ *)this.fields.saturation,
			//                      0.0,
			//                      MethodInfo::UnityEngine::Rendering::VolumeParameter<float>::op_Inequality);
			//           }
			//         }
			//         return 1;
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(v3, postExposure);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2214, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		[Tooltip("Adjusts the brightness of the image just before color grading, in EV.")]
		public FloatParameter postExposure;

		[Tooltip("Controls the overall range of the tonal values.")]
		public ClampedFloatParameter contrast;

		[Tooltip("Specifies the color that HGRP tints the render to.")]
		public ColorParameter colorFilter;

		[Tooltip("Controls the hue of all colors in the render.")]
		public ClampedFloatParameter hueShift;

		[Tooltip("Controls the intensity of all colors in the render.")]
		public ClampedFloatParameter saturation;
	}
}
