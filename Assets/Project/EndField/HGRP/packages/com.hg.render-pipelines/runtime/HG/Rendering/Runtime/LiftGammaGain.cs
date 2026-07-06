using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Lift, Gamma, Gain", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class LiftGammaGain : VolumeComponent, IPostProcessComponent
	{
		private LiftGammaGain()
		{
			// // LiftGammaGain()
			// void HG::Rendering::Runtime::LiftGammaGain::LiftGammaGain(LiftGammaGain *this, MethodInfo *method)
			// {
			//   __int128 v2; // xmm6
			//   HGRenderPathBase_HGRenderPathResources *v4; // rdx
			//   __int64 v5; // rcx
			//   __int64 v6; // rdi
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   __m128i si128; // xmm6
			//   __int64 v10; // rdi
			//   PassConstructorID__Enum__Array *v11; // r8
			//   HGCamera *v12; // r9
			//   __m128i v13; // xmm6
			//   __int64 v14; // rdi
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   __m128i v17; // xmm6
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   __int128 v21; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v22; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v23; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v24; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v25; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v26; // [rsp+60h] [rbp+28h]
			//   MethodInfo *v27; // [rsp+68h] [rbp+30h]
			// 
			//   if ( !byte_18D8ED9E1 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//     sub_18003C530(&off_18C8E8430);
			//     byte_18D8ED9E1 = 1;
			//   }
			//   v21 = v2;
			//   v6 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v6 )
			//     goto LABEL_13;
			//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A3577F0);
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(__m128i *)(v6 + 24) = si128;
			//   *(_BYTE *)(v6 + 16) = 0;
			//   this.fields.lift = (Vector4Parameter *)v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.lift, v4, v7, v8, (MethodInfo *)v21, *((MethodInfo **)&v21 + 1));
			//   v10 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v10 )
			//     goto LABEL_13;
			//   v13 = _mm_load_si128((const __m128i *)&xmmword_18A3577F0);
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(__m128i *)(v10 + 24) = v13;
			//   *(_BYTE *)(v10 + 16) = 0;
			//   this.fields.gamma = (Vector4Parameter *)v10;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.gamma, v4, v11, v12, v22, v24);
			//   v14 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v14 )
			// LABEL_13:
			//     sub_180B536AC(v5, v4);
			//   v17 = _mm_load_si128((const __m128i *)&xmmword_18A3577F0);
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(__m128i *)(v14 + 24) = v17;
			//   *(_BYTE *)(v14 + 16) = 0;
			//   this.fields.gain = (Vector4Parameter *)v14;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.gain, v4, v15, v16, v23, v25);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			//   this.fields._._displayName_k__BackingField = (String *)"Lift, Gamma, Gain";
			//   sub_1800054D0((HGRenderPathScene *)&this.fields._._displayName_k__BackingField, v18, v19, v20, v26, v27);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::LiftGammaGain::IsActive(LiftGammaGain *this, MethodInfo *method)
			// {
			//   __m128i si128; // xmm6
			//   Vector4Parameter *lift; // rcx
			//   Vector4Parameter *gamma; // rcx
			//   Vector4Parameter *gain; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __m128i v11; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91945D )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::op_Inequality);
			//     byte_18D91945D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2242, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2242, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     si128 = _mm_load_si128((const __m128i *)&xmmword_18A3577F0);
			//     lift = this.fields.lift;
			//     v11 = si128;
			//     if ( (unsigned __int8)sub_1808301B8(lift, &v11) )
			//       return 1;
			//     gamma = this.fields.gamma;
			//     v11 = si128;
			//     if ( (unsigned __int8)sub_1808301B8(gamma, &v11) )
			//     {
			//       return 1;
			//     }
			//     else
			//     {
			//       gain = this.fields.gain;
			//       v11 = si128;
			//       return sub_1808301B8(gain, &v11);
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		[Tooltip("Use this to control and apply a hue to the dark tones. This has a more exaggerated effect on shadows.")]
		public Vector4Parameter lift;

		[Tooltip("Use this to control and apply a hue to the mid-range tones with a power function.")]
		public Vector4Parameter gamma;

		[Tooltip("Use this to increase and apply a hue to the signal and make highlights brighter.")]
		public Vector4Parameter gain;
	}
}
