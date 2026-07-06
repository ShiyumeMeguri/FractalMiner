using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/MotionBlur", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public class HGMotionBlur : VolumeComponent
	{
		public HGMotionBlur()
		{
			// // HGMotionBlur()
			// void HG::Rendering::Runtime::HGMotionBlur::HGMotionBlur(HGMotionBlur *this, MethodInfo *method)
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
			//   ClampedFloatParameter *v15; // rax
			//   ClampedFloatParameter *v16; // rdi
			//   OneofDescriptorProto *v17; // rdx
			//   FileDescriptor *v18; // r8
			//   MessageDescriptor *v19; // r9
			//   IntParameter *v20; // rax
			//   ClampedIntParameter *v21; // rdi
			//   OneofDescriptorProto *v22; // rdx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   String__Array *overrideState; // [rsp+20h] [rbp-18h]
			//   String__Array *overrideStateb; // [rsp+20h] [rbp-18h]
			//   String__Array *overrideStatec; // [rsp+20h] [rbp-18h]
			//   String__Array *overrideStatea; // [rsp+20h] [rbp-18h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-10h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-10h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-10h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v33; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v34; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v35; // [rsp+30h] [rbp-8h]
			//   MethodInfo *v36; // [rsp+30h] [rbp-8h]
			// 
			//   if ( !byte_18D8ED9DB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedIntParameter);
			//     byte_18D8ED9DB = 1;
			//   }
			//   v3 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_8;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v3, 0, 0, 0LL);
			//   this.fields.enable = v6;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.enable, v7, v8, v9, overrideState, (String *)methoda, v33);
			//   v10 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_8;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v10, 30.0, 0.0, 360.0, 0, 0LL);
			//   this.fields.shutterAngle = v11;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.shutterAngle, v12, v13, v14, overrideStateb, (String *)methodc, v34);
			//   v15 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v16 = v15;
			//   if ( !v15
			//     || (UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v15, 0.0, 0.0, 1.0, 0, 0LL),
			//         this.fields.blendFrame = v16,
			//         sub_1800054D0(
			//           (OneofDescriptor *)&this.fields.blendFrame,
			//           v17,
			//           v18,
			//           v19,
			//           overrideStatec,
			//           (String *)methodd,
			//           v35),
			//         v20 = (IntParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedIntParameter),
			//         (v21 = (ClampedIntParameter *)v20) == 0LL) )
			//   {
			// LABEL_8:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::IntParameter::IntParameter(v20, 8, 0, 0LL);
			//   v21.fields.min = 4;
			//   v21.fields.max = 12;
			//   this.fields.sampleCount = v21;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.sampleCount, v22, v23, v24, overrideStatea, (String *)methodb, v36);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGMotionBlur::IsActive(HGMotionBlur *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   int *wrapperArray; // rdx
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = (int *)v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_10;
			//   if ( wrapperArray[6] > 1004 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( !v3 )
			//       goto LABEL_10;
			//     if ( LODWORD(v3._0.namespaze) <= 0x3EC )
			//       sub_180070270(v3, wrapperArray);
			//     if ( v3[21]._0.implementedInterfaces )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1004, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//       goto LABEL_10;
			//     }
			//   }
			//   wrapperArray = (int *)this.fields.enable;
			//   if ( !wrapperArray )
			//     goto LABEL_10;
			//   result = sub_1800023D0(10LL, wrapperArray);
			//   if ( result )
			//   {
			//     wrapperArray = (int *)this.fields.shutterAngle;
			//     if ( wrapperArray )
			//       return sub_18003F9B0(10LL, wrapperArray) > 0.0;
			// LABEL_10:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public BoolParameter enable;

		public ClampedFloatParameter shutterAngle;

		public ClampedFloatParameter blendFrame;

		public ClampedIntParameter sampleCount;
	}
}
