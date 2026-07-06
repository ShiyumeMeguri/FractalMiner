using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("HG/FrostedGlass", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class FrostedGlass : VolumeComponent
	{
		public FrostedGlass()
		{
			// // FrostedGlass()
			// void HG::Rendering::Runtime::FrostedGlass::FrostedGlass(FrostedGlass *this, MethodInfo *method)
			// {
			//   ClampedFloatParameter *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ClampedFloatParameter *v6; // rdi
			//   OneofDescriptorProto *v7; // rdx
			//   FileDescriptor *v8; // r8
			//   MessageDescriptor *v9; // r9
			//   ClampedFloatParameter *v10; // rax
			//   ClampedFloatParameter *v11; // rdi
			//   OneofDescriptorProto *v12; // rdx
			//   FileDescriptor *v13; // r8
			//   MessageDescriptor *v14; // r9
			//   IntParameter *v15; // rax
			//   ClampedIntParameter *v16; // rdi
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-18h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-18h]
			//   String__Array *overrideState; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-10h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-10h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v26; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v27; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v28; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8ED9C7 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedIntParameter);
			//     byte_18D8ED9C7 = 1;
			//   }
			//   v3 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_7;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v3, 2.5, 0.5, 5.0, 0, 0LL);
			//   this.fields.colorThreshold = v6;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.colorThreshold, v7, v8, v9, overrideStatea, (String *)methodb, v26);
			//   v10 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v11 = v10;
			//   if ( !v10
			//     || (UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v10, 0.25, 0.0625, 0.25, 0, 0LL),
			//         this.fields.downsampleScale = v11,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.downsampleScale,
			//           v12,
			//           v13,
			//           v14,
			//           overrideStateb,
			//           (String *)methodc,
			//           v27),
			//         v15 = (IntParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedIntParameter),
			//         (v16 = (ClampedIntParameter *)v15) == 0LL) )
			//   {
			// LABEL_7:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::IntParameter::IntParameter(v15, 3, 0, 0LL);
			//   v16.fields.min = 1;
			//   v16.fields.max = 4;
			//   this.fields.downsampleNum = v16;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.downsampleNum, v17, v18, v19, overrideState, (String *)methoda, v28);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::FrostedGlass::IsActive(FrostedGlass *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2219, 0LL) )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2219, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public ClampedFloatParameter colorThreshold;

		public ClampedFloatParameter downsampleScale;

		public ClampedIntParameter downsampleNum;
	}
}
