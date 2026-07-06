using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/ScreenSpacePlanarReflection", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public class ScreenSpacePlanarReflectionVolume : VolumeComponent
	{
		public ScreenSpacePlanarReflectionVolume()
		{
			// // ScreenSpacePlanarReflectionVolume()
			// void HG::Rendering::Runtime::ScreenSpacePlanarReflectionVolume::ScreenSpacePlanarReflectionVolume(
			//         ScreenSpacePlanarReflectionVolume *this,
			//         MethodInfo *method)
			// {
			//   BoolParameter *v3; // rax
			//   HGRenderPathBase_HGRenderPathResources *v4; // rdx
			//   __int64 v5; // rcx
			//   BoolParameter *v6; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   FloatParameter *v10; // rax
			//   FloatParameter *v11; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   ClampedFloatParameter *v15; // rax
			//   ClampedFloatParameter *v16; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   MethodInfo *v20; // rdx
			//   Vector4 v21; // xmm6
			//   __int64 v22; // rdi
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   BoolParameter *v25; // rax
			//   BoolParameter *v26; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   Texture2DParameter *v30; // rax
			//   Texture2DParameter *v31; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v32; // rdx
			//   PassConstructorID__Enum__Array *v33; // r8
			//   HGCamera *v34; // r9
			//   FloatParameter *v35; // rax
			//   FloatParameter *v36; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v37; // rdx
			//   PassConstructorID__Enum__Array *v38; // r8
			//   HGCamera *v39; // r9
			//   ClampedFloatParameter *v40; // rax
			//   ClampedFloatParameter *v41; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v42; // rdx
			//   PassConstructorID__Enum__Array *v43; // r8
			//   HGCamera *v44; // r9
			//   MethodInfo *overrideState; // [rsp+20h] [rbp-58h]
			//   MethodInfo *overrideStatea; // [rsp+20h] [rbp-58h]
			//   MethodInfo *overrideStatef; // [rsp+20h] [rbp-58h]
			//   MethodInfo *overrideStateb; // [rsp+20h] [rbp-58h]
			//   MethodInfo *overrideStatec; // [rsp+20h] [rbp-58h]
			//   MethodInfo *overrideStated; // [rsp+20h] [rbp-58h]
			//   MethodInfo *overrideStatee; // [rsp+20h] [rbp-58h]
			//   MethodInfo *overrideStateg; // [rsp+20h] [rbp-58h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-50h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-50h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-50h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-50h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-50h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-50h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-50h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-50h]
			//   Vector4 v61; // [rsp+30h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D8ED9E5 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::FloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//     byte_18D8ED9E5 = 1;
			//   }
			//   v3 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_14;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v3, 0, 0, 0LL);
			//   this.fields.enable = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enable, v7, v8, v9, overrideState, methoda);
			//   v10 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_14;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v10, 0.0099999998, 0, 0LL);
			//   this.fields.planeHeight = v11;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.planeHeight, v12, v13, v14, overrideStatea, methodb);
			//   v15 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v16 = v15;
			//   if ( !v15 )
			//     goto LABEL_14;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v15, 0.25, 0.0099999998, 1.0, 0, 0LL);
			//   this.fields.fadeness = v16;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.fadeness, v17, v18, v19, overrideStatef, methodg);
			//   v21 = *UnityEngine::Vector4::get_one(&v61, v20);
			//   v22 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v22 )
			//     goto LABEL_14;
			//   if ( !byte_18D8F3660 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3660 = 1;
			//   }
			//   *(_WORD *)(v22 + 41) = 257;
			//   *(Vector4 *)(v22 + 24) = v21;
			//   *(_BYTE *)(v22 + 16) = 0;
			//   this.fields.tintColor = (ColorParameter *)v22;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.tintColor, v4, v23, v24, overrideStateb, methodc);
			//   v25 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v26 = v25;
			//   if ( !v25 )
			//     goto LABEL_14;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v25, 0, 0, 0LL);
			//   this.fields.noiseEnable = v26;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.noiseEnable, v27, v28, v29, overrideStatec, methodd);
			//   v30 = (Texture2DParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//   v31 = v30;
			//   if ( !v30 )
			//     goto LABEL_14;
			//   UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v30, 0LL, 0, 0LL);
			//   this.fields.noiseTexture = v31;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.noiseTexture, v32, v33, v34, overrideStated, methode);
			//   v35 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v36 = v35;
			//   if ( !v35
			//     || (UnityEngine::Rendering::FloatParameter::FloatParameter(v35, 0.0, 0, 0LL),
			//         LODWORD(v36[1].klass) = 0,
			//         this.fields.noiseIntensity = (MinFloatParameter *)v36,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.noiseIntensity, v37, v38, v39, overrideStatee, methodf),
			//         v40 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter),
			//         (v41 = v40) == 0LL) )
			//   {
			// LABEL_14:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v40, 1.0, 0.25, 1.0, 0, 0LL);
			//   this.fields.rtScale = v41;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.rtScale, v42, v43, v44, overrideStateg, methodh);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::ScreenSpacePlanarReflectionVolume::IsActive(
			//         ScreenSpacePlanarReflectionVolume *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   BoolParameter *enable; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2243, 0LL) )
			//   {
			//     enable = this.fields.enable;
			//     if ( enable )
			//       return sub_1800023D0(10LL, enable);
			// LABEL_5:
			//     sub_180B536AC(v3, enable);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2243, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public BoolParameter enable;

		public FloatParameter planeHeight;

		public ClampedFloatParameter fadeness;

		public ColorParameter tintColor;

		public BoolParameter noiseEnable;

		[Tooltip("Specifies a noise texture for SSPR.")]
		public Texture2DParameter noiseTexture;

		public MinFloatParameter noiseIntensity;

		public ClampedFloatParameter rtScale;
	}
}
