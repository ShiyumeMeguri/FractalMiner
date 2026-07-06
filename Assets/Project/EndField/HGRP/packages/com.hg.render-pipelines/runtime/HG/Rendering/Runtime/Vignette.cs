using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/Vignette", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class Vignette : VolumeComponent, IPostProcessComponent
	{
		public Vignette()
		{
			// // Vignette()
			// void HG::Rendering::Runtime::Vignette::Vignette(Vignette *this, MethodInfo *method)
			// {
			//   VignetteModeParameter *v3; // rax
			//   HGRenderPathBase_HGRenderPathResources *v4; // rdx
			//   __int64 v5; // rcx
			//   VignetteModeParameter *v6; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   MethodInfo *v10; // rdx
			//   Quaternion v11; // xmm6
			//   __int64 v12; // rdi
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   Vector2Parameter *v15; // rax
			//   Vector2Parameter *v16; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   ClampedFloatParameter *v20; // rax
			//   ClampedFloatParameter *v21; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v22; // rdx
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   ClampedFloatParameter *v25; // rax
			//   ClampedFloatParameter *v26; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   ClampedFloatParameter *v30; // rax
			//   ClampedFloatParameter *v31; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v32; // rdx
			//   PassConstructorID__Enum__Array *v33; // r8
			//   HGCamera *v34; // r9
			//   BoolParameter *v35; // rax
			//   BoolParameter *v36; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v37; // rdx
			//   PassConstructorID__Enum__Array *v38; // r8
			//   HGCamera *v39; // r9
			//   BoolParameter *v40; // rax
			//   BoolParameter *v41; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v42; // rdx
			//   PassConstructorID__Enum__Array *v43; // r8
			//   HGCamera *v44; // r9
			//   Texture2DParameter *v45; // rax
			//   Texture2DParameter *v46; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v47; // rdx
			//   PassConstructorID__Enum__Array *v48; // r8
			//   HGCamera *v49; // r9
			//   ClampedFloatParameter *v50; // rax
			//   ClampedFloatParameter *v51; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v52; // rdx
			//   PassConstructorID__Enum__Array *v53; // r8
			//   HGCamera *v54; // r9
			//   MethodInfo *overrideState; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatea; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStateb; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatef; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStateg; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStateh; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatec; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStated; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatee; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatei; // [rsp+20h] [rbp-38h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodj; // [rsp+28h] [rbp-30h]
			//   Quaternion v75; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8ED9EB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VignetteModeParameter);
			//     byte_18D8ED9EB = 1;
			//   }
			//   v3 = (VignetteModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VignetteModeParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_16;
			//   HG::Rendering::Runtime::VignetteModeParameter::VignetteModeParameter(v3, VignetteMode__Enum_Procedural, 0, 0LL);
			//   this.fields.mode = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.mode, v7, v8, v9, overrideState, methoda);
			//   v11 = *UnityEngine::Quaternion::get_identity(&v75, v10);
			//   v12 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v12 )
			//     goto LABEL_16;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Quaternion *)(v12 + 24) = v11;
			//   *(_WORD *)(v12 + 40) = 0;
			//   *(_BYTE *)(v12 + 42) = 1;
			//   *(_BYTE *)(v12 + 16) = 0;
			//   this.fields.color = (ColorParameter *)v12;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.color, v4, v13, v14, overrideStatea, methodb);
			//   v15 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v16 = v15;
			//   if ( !v15 )
			//     goto LABEL_16;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v15,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3F000000u),
			//     0,
			//     0LL);
			//   this.fields.center = v16;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.center, v17, v18, v19, overrideStateb, methodc);
			//   v20 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v21 = v20;
			//   if ( !v20 )
			//     goto LABEL_16;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v20, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.intensity = v21;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.intensity, v22, v23, v24, overrideStatef, methodg);
			//   v25 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v26 = v25;
			//   if ( !v25 )
			//     goto LABEL_16;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v25, 0.2, 0.0099999998, 1.0, 0, 0LL);
			//   this.fields.smoothness = v26;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.smoothness, v27, v28, v29, overrideStateg, methodh);
			//   v30 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v31 = v30;
			//   if ( !v30 )
			//     goto LABEL_16;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v30, 1.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.roundness = v31;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.roundness, v32, v33, v34, overrideStateh, methodi);
			//   v35 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v36 = v35;
			//   if ( !v35 )
			//     goto LABEL_16;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v35, 0, 0, 0LL);
			//   this.fields.rounded = v36;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.rounded, v37, v38, v39, overrideStatec, methodd);
			//   v40 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v41 = v40;
			//   if ( !v40 )
			//     goto LABEL_16;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v40, 0, 0, 0LL);
			//   this.fields.blink = v41;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.blink, v42, v43, v44, overrideStated, methode);
			//   v45 = (Texture2DParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//   v46 = v45;
			//   if ( !v45
			//     || (UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v45, 0LL, 0, 0LL),
			//         this.fields.mask = v46,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.mask, v47, v48, v49, overrideStatee, methodf),
			//         v50 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter),
			//         (v51 = v50) == 0LL) )
			//   {
			// LABEL_16:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v50, 1.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.opacity = v51;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.opacity, v52, v53, v54, overrideStatei, methodj);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::Vignette::IsActive(Vignette *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   void *mode; // rdx
			//   Object_1 *v6; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919461 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919461 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2248, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2248, 0LL);
			//     if ( !Patch )
			//       goto LABEL_17;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     mode = this.fields.mode;
			//     if ( !mode )
			//       goto LABEL_17;
			//     if ( !(unsigned int)sub_18003ED00(10LL) )
			//     {
			//       mode = this.fields.intensity;
			//       if ( !mode )
			//         goto LABEL_17;
			//       if ( sub_18003F9B0(10LL, mode) > 0.0 )
			//         return 1;
			//     }
			//     mode = this.fields.mode;
			//     if ( !mode )
			// LABEL_17:
			//       sub_180B536AC(v3, mode);
			//     if ( (unsigned int)sub_18003ED00(10LL) == 1 )
			//     {
			//       mode = this.fields.opacity;
			//       if ( !mode )
			//         goto LABEL_17;
			//       if ( sub_18003F9B0(10LL, mode) > 0.0 )
			//       {
			//         mode = this.fields.mask;
			//         if ( mode )
			//         {
			//           v6 = (Object_1 *)sub_18004EF00(10LL, mode);
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           return UnityEngine::Object::op_Inequality(v6, 0LL, 0LL);
			//         }
			//         goto LABEL_17;
			//       }
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		[Tooltip("Specifies the mode HDRP uses to display the vignette effect.")]
		public VignetteModeParameter mode;

		[Tooltip("Specifies the color of the vignette.")]
		public ColorParameter color;

		[Tooltip("Sets the center point for the vignette.")]
		public Vector2Parameter center;

		[Tooltip("Controls the strength of the vignette effect.")]
		public ClampedFloatParameter intensity;

		[Tooltip("Controls the smoothness of the vignette borders.")]
		public ClampedFloatParameter smoothness;

		[Tooltip("Controls how round the vignette is, lower values result in a more square vignette.")]
		public ClampedFloatParameter roundness;

		[Tooltip("When enabled, the vignette is perfectly round. When disabled, the vignette matches shape with the current aspect ratio.")]
		public BoolParameter rounded;

		[Tooltip("Blink")]
		public BoolParameter blink;

		[Tooltip("Specifies a black and white mask Texture to use as a vignette.")]
		public Texture2DParameter mask;

		[Range(0f, 1f)]
		[Tooltip("Controls the opacity of the mask vignette. Lower values result in a more transparent vignette.")]
		public ClampedFloatParameter opacity;
	}
}
