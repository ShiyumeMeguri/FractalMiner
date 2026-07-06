using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/HGVignette", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class HGVignette : VolumeComponent, IPostProcessComponent
	{
		public HGVignette()
		{
			// // HGVignette()
			// void HG::Rendering::Runtime::HGVignette::HGVignette(HGVignette *this, MethodInfo *method)
			// {
			//   Quaternion v3; // xmm6
			//   HGRenderPathBase_HGRenderPathResources *v4; // rdx
			//   __int64 v5; // rcx
			//   __int64 v6; // rdi
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   ClampedFloatParameter *v9; // rax
			//   ClampedFloatParameter *v10; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   ClampedFloatParameter *v14; // rax
			//   ClampedFloatParameter *v15; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v16; // rdx
			//   PassConstructorID__Enum__Array *v17; // r8
			//   HGCamera *v18; // r9
			//   BoolParameter *v19; // rax
			//   BoolParameter *v20; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v21; // rdx
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   BoolParameter *v24; // rax
			//   BoolParameter *v25; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v26; // rdx
			//   PassConstructorID__Enum__Array *v27; // r8
			//   HGCamera *v28; // r9
			//   MethodInfo *overrideState; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatec; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStated; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatea; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStateb; // [rsp+20h] [rbp-38h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-30h]
			//   Quaternion v39; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8ED9E0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     byte_18D8ED9E0 = 1;
			//   }
			//   v3 = *UnityEngine::Quaternion::get_identity(&v39, method);
			//   v6 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v6 )
			//     goto LABEL_11;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Quaternion *)(v6 + 24) = v3;
			//   *(_WORD *)(v6 + 40) = 0;
			//   *(_BYTE *)(v6 + 42) = 1;
			//   *(_BYTE *)(v6 + 16) = 0;
			//   this.fields.color = (ColorParameter *)v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.color, v4, v7, v8, overrideState, methoda);
			//   v9 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v10 = v9;
			//   if ( !v9 )
			//     goto LABEL_11;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v9, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.intensity = v10;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.intensity, v11, v12, v13, overrideStatec, methodd);
			//   v14 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v15 = v14;
			//   if ( !v14 )
			//     goto LABEL_11;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v14, 0.2, 0.0099999998, 1.0, 0, 0LL);
			//   this.fields.smoothness = v15;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.smoothness, v16, v17, v18, overrideStated, methode);
			//   v19 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v20 = v19;
			//   if ( !v19
			//     || (UnityEngine::Rendering::BoolParameter::BoolParameter(v19, 0, 0, 0LL),
			//         this.fields.rounded = v20,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.rounded, v21, v22, v23, overrideStatea, methodb),
			//         v24 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter),
			//         (v25 = v24) == 0LL) )
			//   {
			// LABEL_11:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v24, 0, 0, 0LL);
			//   this.fields.blink = v25;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.blink, v26, v27, v28, overrideStateb, methodc);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGVignette::IsActive(HGVignette *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   ClampedFloatParameter *intensity; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2241, 0LL) )
			//   {
			//     intensity = this.fields.intensity;
			//     if ( intensity )
			//       return sub_18003F9B0(10LL, intensity) > 0.0;
			// LABEL_5:
			//     sub_180B536AC(v3, intensity);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2241, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		[Tooltip("Specifies the color of the vignette.")]
		public ColorParameter color;

		[Tooltip("Controls the strength of the vignette effect.")]
		public ClampedFloatParameter intensity;

		[Tooltip("Controls the smoothness of the vignette borders.")]
		public ClampedFloatParameter smoothness;

		[Tooltip("When enabled, the vignette is perfectly round. When disabled, the vignette matches shape with the current aspect ratio.")]
		public BoolParameter rounded;

		[Tooltip("Blink")]
		public BoolParameter blink;
	}
}
