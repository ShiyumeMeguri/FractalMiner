using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/HGDirtyLens", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class HGDirtyLens : VolumeComponent, IPostProcessComponent
	{
		public HGDirtyLens()
		{
			// // HGDirtyLens()
			// void HG::Rendering::Runtime::HGDirtyLens::HGDirtyLens(HGDirtyLens *this, MethodInfo *method)
			// {
			//   Texture2DParameter *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   Texture2DParameter *v6; // rdi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   ClampedFloatParameter *v10; // rax
			//   ClampedFloatParameter *v11; // rdi
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-18h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-10h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v19; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v20; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8ED9D9 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//     byte_18D8ED9D9 = 1;
			//   }
			//   v3 = (Texture2DParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//   v6 = v3;
			//   if ( !v3
			//     || (UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v3, 0LL, 0, 0LL),
			//         this.fields.dirtyTex = v6,
			//         sub_1800054D0((OneofDescriptor *)&this.fields.dirtyTex, v7, v8, v9, overrideState, (String *)methoda, v19),
			//         v10 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter),
			//         (v11 = v10) == 0LL) )
			//   {
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v10, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.intensity = v11;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.intensity, v12, v13, v14, overrideStatea, (String *)methodb, v20);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGDirtyLens::IsActive(HGDirtyLens *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   ClampedFloatParameter *intensity; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2229, 0LL) )
			//   {
			//     intensity = this.fields.intensity;
			//     if ( intensity )
			//       return sub_18003F9B0(10LL, intensity) > 0.0;
			// LABEL_5:
			//     sub_180B536AC(v3, intensity);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2229, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		[Tooltip("Controls the tex of the dirty lens effect.")]
		public Texture2DParameter dirtyTex;

		[Tooltip("Controls the strength of the dirty lens effect.")]
		public ClampedFloatParameter intensity;
	}
}
