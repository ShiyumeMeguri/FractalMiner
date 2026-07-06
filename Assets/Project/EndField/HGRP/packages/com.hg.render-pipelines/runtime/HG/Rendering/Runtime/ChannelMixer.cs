using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/Channel Mixer", new Type[] { typeof(HGRenderPipeline) })]
	[MigratingVolumeComponent]
	[Serializable]
	public sealed class ChannelMixer : VolumeComponent, IPostProcessComponent
	{
		public ChannelMixer()
		{
			// // ChannelMixer()
			// void HG::Rendering::Runtime::ChannelMixer::ChannelMixer(ChannelMixer *this, MethodInfo *method)
			// {
			//   MethodInfo *v2; // xmm8_8
			//   ClampedFloatParameter *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ClampedFloatParameter *v7; // rdi
			//   OneofDescriptorProto *v8; // rdx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   ClampedFloatParameter *v11; // rax
			//   ClampedFloatParameter *v12; // rdi
			//   OneofDescriptorProto *v13; // rdx
			//   FileDescriptor *v14; // r8
			//   MessageDescriptor *v15; // r9
			//   ClampedFloatParameter *v16; // rax
			//   ClampedFloatParameter *v17; // rdi
			//   OneofDescriptorProto *v18; // rdx
			//   FileDescriptor *v19; // r8
			//   MessageDescriptor *v20; // r9
			//   ClampedFloatParameter *v21; // rax
			//   ClampedFloatParameter *v22; // rdi
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   MessageDescriptor *v25; // r9
			//   ClampedFloatParameter *v26; // rax
			//   ClampedFloatParameter *v27; // rdi
			//   OneofDescriptorProto *v28; // rdx
			//   FileDescriptor *v29; // r8
			//   MessageDescriptor *v30; // r9
			//   ClampedFloatParameter *v31; // rax
			//   ClampedFloatParameter *v32; // rdi
			//   OneofDescriptorProto *v33; // rdx
			//   FileDescriptor *v34; // r8
			//   MessageDescriptor *v35; // r9
			//   ClampedFloatParameter *v36; // rax
			//   ClampedFloatParameter *v37; // rdi
			//   OneofDescriptorProto *v38; // rdx
			//   FileDescriptor *v39; // r8
			//   MessageDescriptor *v40; // r9
			//   ClampedFloatParameter *v41; // rax
			//   ClampedFloatParameter *v42; // rdi
			//   OneofDescriptorProto *v43; // rdx
			//   FileDescriptor *v44; // r8
			//   MessageDescriptor *v45; // r9
			//   ClampedFloatParameter *v46; // rax
			//   ClampedFloatParameter *v47; // rdi
			//   OneofDescriptorProto *v48; // rdx
			//   FileDescriptor *v49; // r8
			//   MessageDescriptor *v50; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStated; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatee; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatef; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateg; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateh; // [rsp+20h] [rbp-48h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-40h]
			//   MethodInfo *v69; // [rsp+30h] [rbp-38h]
			//   MethodInfo *v70; // [rsp+30h] [rbp-38h]
			//   MethodInfo *v71; // [rsp+30h] [rbp-38h]
			//   MethodInfo *v72; // [rsp+30h] [rbp-38h]
			//   MethodInfo *v73; // [rsp+30h] [rbp-38h]
			//   MethodInfo *v74; // [rsp+30h] [rbp-38h]
			//   MethodInfo *v75; // [rsp+30h] [rbp-38h]
			//   MethodInfo *v76; // [rsp+30h] [rbp-38h]
			// 
			//   if ( !byte_18D8ED9C2 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     byte_18D8ED9C2 = 1;
			//   }
			//   v4 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v7 = v4;
			//   if ( !v4 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v4, 100.0, -200.0, 200.0, 0, 0LL);
			//   this.fields.redOutRedIn = v7;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.redOutRedIn, v8, v9, v10, overrideState, (String *)methoda, v2);
			//   v11 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v12 = v11;
			//   if ( !v11 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v11, 0.0, -200.0, 200.0, 0, 0LL);
			//   this.fields.redOutGreenIn = v12;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.redOutGreenIn, v13, v14, v15, overrideStatea, (String *)methodb, v69);
			//   v16 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v17 = v16;
			//   if ( !v16 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v16, 0.0, -200.0, 200.0, 0, 0LL);
			//   this.fields.redOutBlueIn = v17;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.redOutBlueIn, v18, v19, v20, overrideStateb, (String *)methodc, v70);
			//   v21 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v22 = v21;
			//   if ( !v21 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v21, 0.0, -200.0, 200.0, 0, 0LL);
			//   this.fields.greenOutRedIn = v22;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.greenOutRedIn, v23, v24, v25, overrideStatec, (String *)methodd, v71);
			//   v26 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v27 = v26;
			//   if ( !v26 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v26, 100.0, -200.0, 200.0, 0, 0LL);
			//   this.fields.greenOutGreenIn = v27;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.greenOutGreenIn, v28, v29, v30, overrideStated, (String *)methode, v72);
			//   v31 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v32 = v31;
			//   if ( !v31 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v31, 0.0, -200.0, 200.0, 0, 0LL);
			//   this.fields.greenOutBlueIn = v32;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.greenOutBlueIn, v33, v34, v35, overrideStatee, (String *)methodf, v73);
			//   v36 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v37 = v36;
			//   if ( !v36 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v36, 0.0, -200.0, 200.0, 0, 0LL);
			//   this.fields.blueOutRedIn = v37;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.blueOutRedIn, v38, v39, v40, overrideStatef, (String *)methodg, v74);
			//   v41 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v42 = v41;
			//   if ( !v41
			//     || (UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v41, 0.0, -200.0, 200.0, 0, 0LL),
			//         this.fields.blueOutGreenIn = v42,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.blueOutGreenIn,
			//           v43,
			//           v44,
			//           v45,
			//           overrideStateg,
			//           (String *)methodh,
			//           v75),
			//         v46 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter),
			//         (v47 = v46) == 0LL) )
			//   {
			// LABEL_13:
			//     sub_180B536AC(v6, v5);
			//   }
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v46, 100.0, -200.0, 200.0, 0, 0LL);
			//   this.fields.blueOutBlueIn = v47;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.blueOutBlueIn, v48, v49, v50, overrideStateh, (String *)methodi, v76);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::ChannelMixer::IsActive(ChannelMixer *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   ClampedFloatParameter *redOutRedIn; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2213, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2213, 0LL);
			//     if ( !Patch )
			//       goto LABEL_22;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     redOutRedIn = this.fields.redOutRedIn;
			//     if ( !redOutRedIn )
			//       goto LABEL_22;
			//     if ( sub_18003F9B0(10LL, redOutRedIn) == 100.0 )
			//     {
			//       redOutRedIn = this.fields.redOutGreenIn;
			//       if ( !redOutRedIn )
			//         goto LABEL_22;
			//       if ( sub_18003F9B0(10LL, redOutRedIn) == 0.0 )
			//       {
			//         redOutRedIn = this.fields.redOutBlueIn;
			//         if ( !redOutRedIn )
			//           goto LABEL_22;
			//         if ( sub_18003F9B0(10LL, redOutRedIn) == 0.0 )
			//         {
			//           redOutRedIn = this.fields.greenOutRedIn;
			//           if ( !redOutRedIn )
			//             goto LABEL_22;
			//           if ( sub_18003F9B0(10LL, redOutRedIn) == 0.0 )
			//           {
			//             redOutRedIn = this.fields.greenOutGreenIn;
			//             if ( !redOutRedIn )
			//               goto LABEL_22;
			//             if ( sub_18003F9B0(10LL, redOutRedIn) == 100.0 )
			//             {
			//               redOutRedIn = this.fields.greenOutBlueIn;
			//               if ( !redOutRedIn )
			//                 goto LABEL_22;
			//               if ( sub_18003F9B0(10LL, redOutRedIn) == 0.0 )
			//               {
			//                 redOutRedIn = this.fields.blueOutRedIn;
			//                 if ( !redOutRedIn )
			//                   goto LABEL_22;
			//                 if ( sub_18003F9B0(10LL, redOutRedIn) == 0.0 )
			//                 {
			//                   redOutRedIn = this.fields.blueOutGreenIn;
			//                   if ( !redOutRedIn )
			//                     goto LABEL_22;
			//                   if ( sub_18003F9B0(10LL, redOutRedIn) == 0.0 )
			//                   {
			//                     redOutRedIn = this.fields.blueOutBlueIn;
			//                     if ( redOutRedIn )
			//                       return sub_18003F9B0(10LL, redOutRedIn) != 100.0;
			// LABEL_22:
			//                     sub_180B536AC(v3, redOutRedIn);
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			//     return 1;
			//   }
			// }
			// 
			return default(bool);
		}

		[InspectorName("Red")]
		[Tooltip("Controls the influence of the red channel in the output red channel.")]
		[Header("Red Output Channel")]
		public ClampedFloatParameter redOutRedIn;

		[InspectorName("Green")]
		[Tooltip("Controls the influence of the green channel in the output red channel.")]
		public ClampedFloatParameter redOutGreenIn;

		[Tooltip("Controls the influence of the blue channel in the output red channel.")]
		[InspectorName("Blue")]
		public ClampedFloatParameter redOutBlueIn;

		[Header("Green Output Channel")]
		[Tooltip("Controls the influence of the red channel in the output green channel.")]
		[InspectorName("Red")]
		public ClampedFloatParameter greenOutRedIn;

		[Tooltip("Controls the influence of the green channel in the output green channel.")]
		[InspectorName("Green")]
		public ClampedFloatParameter greenOutGreenIn;

		[Tooltip("Controls the influence of the blue channel in the output green channel.")]
		[InspectorName("Blue")]
		public ClampedFloatParameter greenOutBlueIn;

		[Header("Blue Output Channel")]
		[Tooltip("Controls the influence of the red channel in the output blue channel.")]
		[InspectorName("Red")]
		public ClampedFloatParameter blueOutRedIn;

		[Tooltip("Controls the influence of the green channel in the output blue channel.")]
		[InspectorName("Green")]
		public ClampedFloatParameter blueOutGreenIn;

		[InspectorName("Blue")]
		[Tooltip("Controls the influence of the blue channel in the output blue channel.")]
		public ClampedFloatParameter blueOutBlueIn;
	}
}
