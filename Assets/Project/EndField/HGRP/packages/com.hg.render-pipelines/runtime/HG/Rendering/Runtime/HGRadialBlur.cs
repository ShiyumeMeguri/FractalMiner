using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("HG/RadialBlur", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class HGRadialBlur : VolumeComponent
	{
		public HGRadialBlur()
		{
			// // HGRadialBlur()
			// void HG::Rendering::Runtime::HGRadialBlur::HGRadialBlur(HGRadialBlur *this, MethodInfo *method)
			// {
			//   MethodInfo *v2; // xmm6_8
			//   BoolParameter *v4; // rax
			//   OneofDescriptorProto *v5; // rdx
			//   __int64 v6; // rcx
			//   BoolParameter *v7; // rdi
			//   OneofDescriptorProto *v8; // rdx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   Vector2Parameter *v11; // rax
			//   Vector2Parameter *v12; // rdi
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
			//   BoolParameter *v26; // rax
			//   BoolParameter *v27; // rdi
			//   OneofDescriptorProto *v28; // rdx
			//   FileDescriptor *v29; // r8
			//   MessageDescriptor *v30; // r9
			//   BoolParameter *v31; // rax
			//   BoolParameter *v32; // rdi
			//   OneofDescriptorProto *v33; // rdx
			//   FileDescriptor *v34; // r8
			//   MessageDescriptor *v35; // r9
			//   __int64 v36; // rdi
			//   FileDescriptor *v37; // r8
			//   MessageDescriptor *v38; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatee; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatef; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-28h]
			//   String__Array *overrideStated; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v53; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v54; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v55; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v56; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v57; // [rsp+30h] [rbp-18h]
			//   MethodInfo *v58; // [rsp+30h] [rbp-18h]
			// 
			//   if ( !byte_18D8ED9DC )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector3Parameter);
			//     byte_18D8ED9DC = 1;
			//   }
			//   v4 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v7 = v4;
			//   if ( !v4 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v4, 0, 0, 0LL);
			//   this.fields.enabled = v7;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.enabled, v8, v9, v10, overrideState, (String *)methoda, v2);
			//   v11 = (Vector2Parameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
			//   v12 = v11;
			//   if ( !v11 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::Vector2Parameter::Vector2Parameter(
			//     v11,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3F000000u),
			//     0,
			//     0LL);
			//   this.fields.center = v12;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.center, v13, v14, v15, overrideStatea, (String *)methodb, v53);
			//   v16 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v17 = v16;
			//   if ( !v16 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v16, 0.1, 0.0, 0.30000001, 0, 0LL);
			//   this.fields.intensity = v17;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.intensity, v18, v19, v20, overrideStatee, (String *)methodf, v54);
			//   v21 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v22 = v21;
			//   if ( !v21 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v21, 1.0, 1.0, 2.0, 0, 0LL);
			//   this.fields.power = v22;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.power, v23, v24, v25, overrideStatef, (String *)methodg, v55);
			//   v26 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v27 = v26;
			//   if ( !v26 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v26, 0, 0, 0LL);
			//   this.fields.averageSteps = v27;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.averageSteps, v28, v29, v30, overrideStateb, (String *)methodc, v56);
			//   v31 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v32 = v31;
			//   if ( !v31
			//     || (UnityEngine::Rendering::BoolParameter::BoolParameter(v31, 0, 0, 0LL),
			//         this.fields.enableGlobalCenter = v32,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.enableGlobalCenter,
			//           v33,
			//           v34,
			//           v35,
			//           overrideStatec,
			//           (String *)methodd,
			//           v57),
			//         (v36 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector3Parameter)) == 0) )
			//   {
			// LABEL_13:
			//     sub_180B536AC(v6, v5);
			//   }
			//   if ( !byte_18D8F3663 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector3>::VolumeParameter);
			//     byte_18D8F3663 = 1;
			//   }
			//   *(_BYTE *)(v36 + 16) = 0;
			//   *(_QWORD *)(v36 + 24) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   *(_DWORD *)(v36 + 32) = 0;
			//   this.fields.globalCenter = (Vector3Parameter *)v36;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.globalCenter, v5, v37, v38, overrideStated, (String *)methode, v58);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGRadialBlur::IsActive(HGRadialBlur *this, MethodInfo *method)
			// {
			//   __int64 v3; // rcx
			//   void *enabled; // rdx
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2231, 0LL) )
			//   {
			//     enabled = this.fields.enabled;
			//     if ( enabled )
			//     {
			//       result = sub_1800023D0(10LL, enabled);
			//       if ( !result )
			//         return result;
			//       enabled = this.fields.intensity;
			//       if ( enabled )
			//         return sub_18003F9B0(10LL, enabled) > 0.0;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v3, enabled);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2231, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public BoolParameter enabled;

		public Vector2Parameter center;

		public ClampedFloatParameter intensity;

		public ClampedFloatParameter power;

		public BoolParameter averageSteps;

		public BoolParameter enableGlobalCenter;

		public Vector3Parameter globalCenter;
	}
}
