using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/HGAnamorphicStreaks", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public class HGAnamorphicStreaks : VolumeComponent
	{
		public HGAnamorphicStreaks()
		{
			// // HGAnamorphicStreaks()
			// void HG::Rendering::Runtime::HGAnamorphicStreaks::HGAnamorphicStreaks(HGAnamorphicStreaks *this, MethodInfo *method)
			// {
			//   BoolParameter *v3; // rax
			//   OneofDescriptorProto *v4; // rdx
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
			//   FloatParameter *v15; // rax
			//   FloatParameter *v16; // rdi
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   ClampedFloatParameter *v20; // rax
			//   ClampedFloatParameter *v21; // rdi
			//   OneofDescriptorProto *v22; // rdx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   MethodInfo *v25; // rdx
			//   Vector4 v26; // xmm7
			//   __int64 v27; // rdi
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   ClampedFloatParameter *v30; // rax
			//   ClampedFloatParameter *v31; // rdi
			//   OneofDescriptorProto *v32; // rdx
			//   FileDescriptor *v33; // r8
			//   MessageDescriptor *v34; // r9
			//   ClampedFloatParameter *v35; // rax
			//   ClampedFloatParameter *v36; // rdi
			//   OneofDescriptorProto *v37; // rdx
			//   FileDescriptor *v38; // r8
			//   MessageDescriptor *v39; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStated; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatee; // [rsp+20h] [rbp-48h]
			//   String__Array *overrideStatef; // [rsp+20h] [rbp-48h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-40h]
			//   Vector4 v54; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8ED9BC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//     byte_18D8ED9BC = 1;
			//   }
			//   v3 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v3, 0, 1, 0LL);
			//   this.fields.enable = v6;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.enable,
			//     v7,
			//     v8,
			//     v9,
			//     overrideState,
			//     (String *)methoda,
			//     *(MethodInfo **)&v54.x);
			//   v10 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v10, 1.0, 0.0, 10.0, 1, 0LL);
			//   this.fields.bloomScale = v11;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.bloomScale,
			//     v12,
			//     v13,
			//     v14,
			//     overrideStatec,
			//     (String *)methodd,
			//     *(MethodInfo **)&v54.x);
			//   v15 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v16 = v15;
			//   if ( !v15 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v15, 4.0, 1, 0LL);
			//   LODWORD(v16[1].klass) = 0;
			//   this.fields.bloomThreshold = (MinFloatParameter *)v16;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.bloomThreshold,
			//     v17,
			//     v18,
			//     v19,
			//     overrideStatea,
			//     (String *)methodb,
			//     *(MethodInfo **)&v54.x);
			//   v20 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v21 = v20;
			//   if ( !v20 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v20, 100.0, 0.0, 100.0, 1, 0LL);
			//   this.fields.bloomMaxBrightness = v21;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.bloomMaxBrightness,
			//     v22,
			//     v23,
			//     v24,
			//     overrideStated,
			//     (String *)methode,
			//     *(MethodInfo **)&v54.x);
			//   v26 = *UnityEngine::Vector4::get_one(&v54, v25);
			//   v27 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v27 )
			//     goto LABEL_13;
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(Vector4 *)(v27 + 24) = v26;
			//   *(_WORD *)(v27 + 40) = 1;
			//   *(_BYTE *)(v27 + 42) = 1;
			//   *(_BYTE *)(v27 + 16) = 1;
			//   this.fields.bloomTint = (ColorParameter *)v27;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.bloomTint,
			//     v4,
			//     v28,
			//     v29,
			//     overrideStateb,
			//     (String *)methodc,
			//     *(MethodInfo **)&v54.x);
			//   v30 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v31 = v30;
			//   if ( !v30
			//     || (UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v30, 0.69999999, 0.0, 1.0, 1, 0LL),
			//         this.fields.blurIntensity = v31,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.blurIntensity,
			//           v32,
			//           v33,
			//           v34,
			//           overrideStatee,
			//           (String *)methodf,
			//           *(MethodInfo **)&v54.x),
			//         v35 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter),
			//         (v36 = v35) == 0LL) )
			//   {
			// LABEL_13:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v35, 0.0, 0.0, 180.0, 1, 0LL);
			//   this.fields.blurDirAngle = v36;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.fields.blurDirAngle,
			//     v37,
			//     v38,
			//     v39,
			//     overrideStatef,
			//     (String *)methodg,
			//     *(MethodInfo **)&v54.x);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGAnamorphicStreaks::IsActive(HGAnamorphicStreaks *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   BoolParameter *enable; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2209, 0LL) )
			//   {
			//     enable = this.fields.enable;
			//     if ( enable )
			//       return sub_1800023D0(10LL, enable);
			// LABEL_5:
			//     sub_180B536AC(v3, enable);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2209, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public BoolParameter enable;

		public ClampedFloatParameter bloomScale;

		public MinFloatParameter bloomThreshold;

		public ClampedFloatParameter bloomMaxBrightness;

		public ColorParameter bloomTint;

		public ClampedFloatParameter blurIntensity;

		public ClampedFloatParameter blurDirAngle;
	}
}
