using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/Split Toning", new Type[] { typeof(HGRenderPipeline) })]
	[MigratingVolumeComponent]
	[Serializable]
	public sealed class SplitToning : VolumeComponent, IPostProcessComponent
	{
		public SplitToning()
		{
			// // SplitToning()
			// void HG::Rendering::Runtime::SplitToning::SplitToning(SplitToning *this, MethodInfo *method)
			// {
			//   Color v3; // xmm6
			//   HGRenderPathBase_HGRenderPathResources *v4; // rdx
			//   __int64 v5; // rcx
			//   __int64 v6; // rbx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   MethodInfo *v9; // rdx
			//   Color v10; // xmm6
			//   __int64 v11; // rbx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   ClampedFloatParameter *v14; // rax
			//   ClampedFloatParameter *v15; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v16; // rdx
			//   PassConstructorID__Enum__Array *v17; // r8
			//   HGCamera *v18; // r9
			//   MethodInfo *overrideState; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatea; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStateb; // [rsp+20h] [rbp-38h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-30h]
			//   Color v25; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8ED9E8 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     byte_18D8ED9E8 = 1;
			//   }
			//   v3 = *UnityEngine::Color::get_grey(&v25, method);
			//   v6 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v6 )
			//     goto LABEL_11;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Color *)(v6 + 24) = v3;
			//   *(_WORD *)(v6 + 40) = 0;
			//   *(_BYTE *)(v6 + 42) = 1;
			//   *(_BYTE *)(v6 + 16) = 0;
			//   this.fields.shadows = (ColorParameter *)v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.shadows, v4, v7, v8, overrideState, methoda);
			//   v10 = *UnityEngine::Color::get_grey(&v25, v9);
			//   v11 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v11 )
			//     goto LABEL_11;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Color *)(v11 + 24) = v10;
			//   *(_WORD *)(v11 + 40) = 0;
			//   *(_BYTE *)(v11 + 42) = 1;
			//   *(_BYTE *)(v11 + 16) = 0;
			//   this.fields.highlights = (ColorParameter *)v11;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.highlights, v4, v12, v13, overrideStatea, methodb);
			//   v14 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v15 = v14;
			//   if ( !v14 )
			// LABEL_11:
			//     sub_180B536AC(v5, v4);
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v14, 0.0, -100.0, 100.0, 0, 0LL);
			//   this.fields.balance = v15;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.balance, v16, v17, v18, overrideStateb, methodc);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::SplitToning::IsActive(SplitToning *this, MethodInfo *method)
			// {
			//   MethodInfo *v3; // rdx
			//   Color *grey; // rax
			//   ColorParameter *shadows; // rcx
			//   MethodInfo *v6; // rdx
			//   Color *v8; // rax
			//   ColorParameter *highlights; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   Color v13; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91945F )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::op_Inequality);
			//     byte_18D91945F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2245, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2245, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     grey = UnityEngine::Color::get_grey(&v13, v3);
			//     shadows = this.fields.shadows;
			//     v13 = *grey;
			//     if ( (unsigned __int8)sub_180830160(shadows, &v13) )
			//     {
			//       return 1;
			//     }
			//     else
			//     {
			//       v8 = UnityEngine::Color::get_grey(&v13, v6);
			//       highlights = this.fields.highlights;
			//       v13 = *v8;
			//       return sub_180830160(highlights, &v13);
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		[Tooltip("Specifies the color to use for shadows.")]
		public ColorParameter shadows;

		[Tooltip("Specifies the color to use for highlights.")]
		public ColorParameter highlights;

		[Tooltip("Controls the balance between the colors in the highlights and shadows.")]
		public ClampedFloatParameter balance;
	}
}
