using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/ContactShadow", new Type[] { typeof(HGRenderPipeline) })]
	[MigratingVolumeComponent]
	[Serializable]
	public class ContactShadowVolume : VolumeComponent
	{
		public ContactShadowVolume()
		{
			// // ContactShadowVolume()
			// void HG::Rendering::Runtime::ContactShadowVolume::ContactShadowVolume(ContactShadowVolume *this, MethodInfo *method)
			// {
			//   MethodInfo *v2; // xmm6_8
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
			//   IntParameter *v21; // rax
			//   ClampedIntParameter *v22; // rdi
			//   OneofDescriptorProto *v23; // rdx
			//   FileDescriptor *v24; // r8
			//   MessageDescriptor *v25; // r9
			//   BoolParameter *v26; // rax
			//   BoolParameter *v27; // rdi
			//   OneofDescriptorProto *v28; // rdx
			//   FileDescriptor *v29; // r8
			//   MessageDescriptor *v30; // r9
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStated; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideState; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v41; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v42; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v43; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v44; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D8ED9C6 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedIntParameter);
			//     byte_18D8ED9C6 = 1;
			//   }
			//   v4 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v7 = v4;
			//   if ( !v4 )
			//     goto LABEL_9;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v4, 0.5, 0.0, 1.0, 0, 0LL);
			//   this.fields.shadowIntensity = v7;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.shadowIntensity, v8, v9, v10, overrideStateb, (String *)methodc, v2);
			//   v11 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v12 = v11;
			//   if ( !v11 )
			//     goto LABEL_9;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v11, 0.80000001, 0.40000001, 1.0, 0, 0LL);
			//   this.fields.surfaceThickness = v12;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.surfaceThickness,
			//     v13,
			//     v14,
			//     v15,
			//     overrideStatec,
			//     (String *)methodd,
			//     v41);
			//   v16 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v17 = v16;
			//   if ( !v16 )
			//     goto LABEL_9;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v16, 2.0, 2.0, 5.0, 0, 0LL);
			//   this.fields.bilinearThreshold = v17;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.bilinearThreshold,
			//     v18,
			//     v19,
			//     v20,
			//     overrideStated,
			//     (String *)methode,
			//     v42);
			//   v21 = (IntParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedIntParameter);
			//   v22 = (ClampedIntParameter *)v21;
			//   if ( !v21
			//     || (UnityEngine::Rendering::IntParameter::IntParameter(v21, 4, 0, 0LL),
			//         v22.fields.min = 1,
			//         v22.fields.max = 4,
			//         this.fields.shadowContrast = v22,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.shadowContrast,
			//           v23,
			//           v24,
			//           v25,
			//           overrideState,
			//           (String *)methoda,
			//           v43),
			//         v26 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter),
			//         (v27 = v26) == 0LL) )
			//   {
			// LABEL_9:
			//     sub_180B536AC(v6, v5);
			//   }
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v26, 0, 0, 0LL);
			//   this.fields.ignoreEdgePixels = v27;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.ignoreEdgePixels,
			//     v28,
			//     v29,
			//     v30,
			//     overrideStatea,
			//     (String *)methodb,
			//     v44);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public ClampedFloatParameter shadowIntensity;

		public ClampedFloatParameter surfaceThickness;

		public ClampedFloatParameter bilinearThreshold;

		public ClampedIntParameter shadowContrast;

		public BoolParameter ignoreEdgePixels;
	}
}
