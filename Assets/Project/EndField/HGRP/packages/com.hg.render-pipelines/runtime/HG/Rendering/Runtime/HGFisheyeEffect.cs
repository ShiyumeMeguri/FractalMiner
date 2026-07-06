using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("HG/FisheyeEffect", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class HGFisheyeEffect : VolumeComponent
	{
		public HGFisheyeEffect()
		{
			// // HGFisheyeEffect()
			// void HG::Rendering::Runtime::HGFisheyeEffect::HGFisheyeEffect(HGFisheyeEffect *this, MethodInfo *method)
			// {
			//   BoolParameter *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   BoolParameter *v6; // rdi
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
			//   if ( !byte_18D8ED9DA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     byte_18D8ED9DA = 1;
			//   }
			//   v3 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v6 = v3;
			//   if ( !v3
			//     || (UnityEngine::Rendering::BoolParameter::BoolParameter(v3, 0, 0, 0LL),
			//         this.fields.enabled = v6,
			//         sub_1800054D0((OneofDescriptor *)&this.fields.enabled, v7, v8, v9, overrideState, (String *)methoda, v19),
			//         v10 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter),
			//         (v11 = v10) == 0LL) )
			//   {
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v10, 0.0, 0.0, 0.5, 0, 0LL);
			//   this.fields.distortion = v11;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.distortion, v12, v13, v14, overrideStatea, (String *)methodb, v20);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGFisheyeEffect::IsActive(HGFisheyeEffect *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   BoolParameter *enabled; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2230, 0LL) )
			//   {
			//     enabled = this.fields.enabled;
			//     if ( enabled )
			//       return sub_1800023D0(10LL, enabled);
			// LABEL_5:
			//     sub_180B536AC(v3, enabled);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2230, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public BoolParameter enabled;

		public ClampedFloatParameter distortion;
	}
}
