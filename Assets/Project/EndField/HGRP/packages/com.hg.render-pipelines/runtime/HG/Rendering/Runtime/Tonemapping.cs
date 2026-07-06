using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/Tonemapping", new Type[] { typeof(HGRenderPipeline) })]
	[MigratingVolumeComponent]
	[Serializable]
	public sealed class Tonemapping : VolumeComponent, IPostProcessComponent
	{
		public Tonemapping()
		{
			// // Tonemapping()
			// void HG::Rendering::Runtime::Tonemapping::Tonemapping(Tonemapping *this, MethodInfo *method)
			// {
			//   TonemappingModeParameter *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   TonemappingModeParameter *v6; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   ClampedFloatParameter *v10; // rax
			//   ClampedFloatParameter *v11; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   ClampedFloatParameter *v15; // rax
			//   ClampedFloatParameter *v16; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   ClampedFloatParameter *v20; // rax
			//   ClampedFloatParameter *v21; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v22; // rdx
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   FloatParameter *v25; // rax
			//   FloatParameter *v26; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   ClampedFloatParameter *v30; // rax
			//   ClampedFloatParameter *v31; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v32; // rdx
			//   PassConstructorID__Enum__Array *v33; // r8
			//   HGCamera *v34; // r9
			//   FloatParameter *v35; // rax
			//   FloatParameter *v36; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v37; // rdx
			//   PassConstructorID__Enum__Array *v38; // r8
			//   HGCamera *v39; // r9
			//   Texture3DParameter *v40; // rax
			//   Texture3DParameter *v41; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v42; // rdx
			//   PassConstructorID__Enum__Array *v43; // r8
			//   HGCamera *v44; // r9
			//   ClampedFloatParameter *v45; // rax
			//   ClampedFloatParameter *v46; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v47; // rdx
			//   PassConstructorID__Enum__Array *v48; // r8
			//   HGCamera *v49; // r9
			//   MethodInfo *overrideState; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStated; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatee; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatef; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatea; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStateg; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStateb; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatec; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStateh; // [rsp+20h] [rbp-38h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-30h]
			// 
			//   if ( !byte_18D8ED9E9 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Texture3DParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::TonemappingModeParameter);
			//     byte_18D8ED9E9 = 1;
			//   }
			//   v3 = (TonemappingModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::TonemappingModeParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_13;
			//   HG::Rendering::Runtime::TonemappingModeParameter::TonemappingModeParameter(
			//     v3,
			//     TonemappingMode__Enum_ACES_modified,
			//     0,
			//     0LL);
			//   this.fields.mode = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.mode, v7, v8, v9, overrideState, methoda);
			//   v10 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v10, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.toeStrength = v11;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.toeStrength, v12, v13, v14, overrideStated, methode);
			//   v15 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v16 = v15;
			//   if ( !v15 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v15, 0.5, 0.0, 1.0, 0, 0LL);
			//   this.fields.toeLength = v16;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.toeLength, v17, v18, v19, overrideStatee, methodf);
			//   v20 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v21 = v20;
			//   if ( !v20 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v20, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.shoulderStrength = v21;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.shoulderStrength, v22, v23, v24, overrideStatef, methodg);
			//   v25 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v26 = v25;
			//   if ( !v25 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v25, 0.5, 0, 0LL);
			//   LODWORD(v26[1].klass) = 0;
			//   this.fields.shoulderLength = (MinFloatParameter *)v26;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.shoulderLength, v27, v28, v29, overrideStatea, methodb);
			//   v30 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v31 = v30;
			//   if ( !v30 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v30, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.shoulderAngle = v31;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.shoulderAngle, v32, v33, v34, overrideStateg, methodh);
			//   v35 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v36 = v35;
			//   if ( !v35 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v35, 1.0, 0, 0LL);
			//   LODWORD(v36[1].klass) = 981668463;
			//   this.fields.gamma = (MinFloatParameter *)v36;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.gamma, v37, v38, v39, overrideStateb, methodc);
			//   v40 = (Texture3DParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Texture3DParameter);
			//   v41 = v40;
			//   if ( !v40
			//     || (UnityEngine::Rendering::Texture3DParameter::Texture3DParameter(v40, 0LL, 0, 0LL),
			//         this.fields.lutTexture = v41,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.lutTexture, v42, v43, v44, overrideStatec, methodd),
			//         v45 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter),
			//         (v46 = v45) == 0LL) )
			//   {
			// LABEL_13:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v45, 1.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.lutContribution = v46;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.lutContribution, v47, v48, v49, overrideStateh, methodi);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::Tonemapping::IsActive(Tonemapping *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   void *mode; // rdx
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2246, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2246, 0LL);
			//     if ( !Patch )
			//       goto LABEL_10;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     mode = this.fields.mode;
			//     if ( !mode )
			//       goto LABEL_10;
			//     if ( (unsigned int)sub_18003ED00(10LL) != 4 )
			//     {
			//       mode = this.fields.mode;
			//       if ( mode )
			//         return (unsigned int)sub_18003ED00(10LL) != 0;
			// LABEL_10:
			//       sub_180B536AC(v3, mode);
			//     }
			//     result = HG::Rendering::Runtime::Tonemapping::ValidateLUT(this, 0LL);
			//     if ( result )
			//     {
			//       mode = this.fields.lutContribution;
			//       if ( !mode )
			//         goto LABEL_10;
			//       return sub_18003F9B0(10LL, mode) > 0.0;
			//     }
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public bool ValidateLUT()
		{
			// // Boolean ValidateLUT()
			// bool HG::Rendering::Runtime::Tonemapping::ValidateLUT(Tonemapping *this, MethodInfo *method)
			// {
			//   bool v2; // di
			//   Object_1 *currentAsset; // rbx
			//   __int64 v5; // rcx
			//   Texture3DParameter *lutTexture; // rdx
			//   Object_1 *v7; // rbx
			//   struct Texture3D__Class **v8; // rax
			//   Texture3D *v9; // rsi
			//   int v10; // ebx
			//   int v11; // ebx
			//   RenderTexture *v12; // rsi
			//   int v13; // ebx
			//   int v14; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v2 = 0;
			//   if ( !byte_18D919460 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture3D);
			//     byte_18D919460 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2247, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2247, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//     goto LABEL_23;
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
			//   currentAsset = (Object_1 *)HG::Rendering::Runtime::HGRenderPipeline::get_currentAsset(0LL);
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Equality(currentAsset, 0LL, 0LL) )
			//     return 0;
			//   lutTexture = this.fields.lutTexture;
			//   if ( !lutTexture )
			//     goto LABEL_23;
			//   v7 = (Object_1 *)sub_18004EF00(10LL, lutTexture);
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Equality(v7, 0LL, 0LL) )
			//     return 0;
			//   lutTexture = this.fields.lutTexture;
			//   if ( !lutTexture || !sub_18004EF00(10LL, lutTexture) )
			// LABEL_23:
			//     sub_180B536AC(v5, lutTexture);
			//   if ( (unsigned int)sub_18003ED00(5LL) != 32 )
			//     return 0;
			//   lutTexture = this.fields.lutTexture;
			//   if ( !lutTexture )
			//     goto LABEL_23;
			//   v8 = (struct Texture3D__Class **)sub_18004EF00(10LL, lutTexture);
			//   v9 = (Texture3D *)v8;
			//   if ( v8 && *v8 == TypeInfo::UnityEngine::Texture3D )
			//   {
			//     v10 = sub_18003ED00(5LL);
			//     if ( v10 == (unsigned int)sub_18003ED00(7LL) )
			//     {
			//       v11 = sub_18003ED00(7LL);
			//       return v11 == UnityEngine::Texture3D::get_depth(v9, 0LL);
			//     }
			//   }
			//   else
			//   {
			//     v12 = (RenderTexture *)sub_18003F5A0(v8, TypeInfo::UnityEngine::RenderTexture);
			//     if ( v12 )
			//     {
			//       if ( (unsigned int)sub_18003ED00(9LL) == 3 )
			//       {
			//         v13 = sub_18003ED00(5LL);
			//         if ( v13 == (unsigned int)sub_18003ED00(7LL) )
			//         {
			//           v14 = sub_18003ED00(7LL);
			//           if ( v14 == UnityEngine::RenderTexture::get_volumeDepth(v12, 0LL) )
			//             return 1;
			//         }
			//       }
			//     }
			//   }
			//   return v2;
			// }
			// 
			return default(bool);
		}

		[Tooltip("Specifies the tonemapping algorithm to use for the color grading process.")]
		public TonemappingModeParameter mode;

		[Tooltip("Controls the transition between the toe and the mid section of the curve. A value of 0 results in no transition and a value of 1 results in a very hard transition.")]
		public ClampedFloatParameter toeStrength;

		[Tooltip("Controls how much of the dynamic range is in the toe. Higher values result in longer toes and therefore contain more of the dynamic range.")]
		public ClampedFloatParameter toeLength;

		[Tooltip("Controls the transition between the midsection and the shoulder of the curve. A value of 0 results in no transition and a value of 1 results in a very hard transition.")]
		public ClampedFloatParameter shoulderStrength;

		[Tooltip("Sets how many F-stops (EV) to add to the dynamic range of the curve.")]
		public MinFloatParameter shoulderLength;

		[Tooltip("Controls how much overshoot to add to the shoulder.")]
		public ClampedFloatParameter shoulderAngle;

		[Tooltip("Sets a gamma correction value that HGRP applies to the whole curve.")]
		public MinFloatParameter gamma;

		[Tooltip("A custom 3D texture lookup table to apply.")]
		public Texture3DParameter lutTexture;

		[Tooltip("How much of the lookup texture will contribute to the color grading effect.")]
		public ClampedFloatParameter lutContribution;
	}
}
