using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/ScreenSpaceReflection", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public class ScreenSpaceReflectionVolume : VolumeComponent
	{
		public ScreenSpaceReflectionVolume()
		{
			// // ScreenSpaceReflectionVolume()
			// void HG::Rendering::Runtime::ScreenSpaceReflectionVolume::ScreenSpaceReflectionVolume(
			//         ScreenSpaceReflectionVolume *this,
			//         MethodInfo *method)
			// {
			//   BoolParameter *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   BoolParameter *v6; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   ClampedFloatParameter *v10; // rax
			//   ClampedFloatParameter *v11; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   FloatParameter *v15; // rax
			//   FloatParameter *v16; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   ClampedFloatParameter *v20; // rax
			//   ClampedFloatParameter *v21; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v22; // rdx
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   FloatParameter *v25; // rax
			//   FloatParameter *v26; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   FloatParameter *v30; // rax
			//   FloatParameter *v31; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v32; // rdx
			//   PassConstructorID__Enum__Array *v33; // r8
			//   HGCamera *v34; // r9
			//   ClampedFloatParameter *v35; // rax
			//   ClampedFloatParameter *v36; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v37; // rdx
			//   PassConstructorID__Enum__Array *v38; // r8
			//   HGCamera *v39; // r9
			//   MethodInfo *overrideState; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStated; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatea; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatee; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStateb; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatec; // [rsp+20h] [rbp-38h]
			//   MethodInfo *overrideStatef; // [rsp+20h] [rbp-38h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-30h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-30h]
			// 
			//   if ( !byte_18D8ED9E6 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::FloatParameter);
			//     byte_18D8ED9E6 = 1;
			//   }
			//   v3 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_11;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v3, 0, 0, 0LL);
			//   this.fields.enable = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enable, v7, v8, v9, overrideState, methoda);
			//   v10 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_11;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v10, 0.1, 0.0, 1.0, 0, 0LL);
			//   this.fields.fadenessOnScreen = v11;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.fadenessOnScreen, v12, v13, v14, overrideStated, methode);
			//   v15 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatParameter);
			//   v16 = v15;
			//   if ( !v15 )
			//     goto LABEL_11;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v15, 50.0, 0, 0LL);
			//   this.fields.fadenessOnDepth = v16;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.fadenessOnDepth, v17, v18, v19, overrideStatea, methodb);
			//   v20 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v21 = v20;
			//   if ( !v20 )
			//     goto LABEL_11;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v20, 0.1, 0.0, 1.0, 0, 0LL);
			//   this.fields.fadenessOnDepthFactor = v21;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.fadenessOnDepthFactor, v22, v23, v24, overrideStatee, methodf);
			//   v25 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatParameter);
			//   v26 = v25;
			//   if ( !v25 )
			//     goto LABEL_11;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v25, 2.0, 0, 0LL);
			//   this.fields.fadenessOnMirrorMul = v26;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.fadenessOnMirrorMul, v27, v28, v29, overrideStateb, methodc);
			//   v30 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatParameter);
			//   v31 = v30;
			//   if ( !v30
			//     || (UnityEngine::Rendering::FloatParameter::FloatParameter(v30, -1.0, 0, 0LL),
			//         this.fields.fadenessOnMirrorAdd = v31,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.fadenessOnMirrorAdd, v32, v33, v34, overrideStatec, methodd),
			//         v35 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter),
			//         (v36 = v35) == 0LL) )
			//   {
			// LABEL_11:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v35, 0.0, -1.0, 1.0, 0, 0LL);
			//   this.fields.mipThreshold = v36;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.mipThreshold, v37, v38, v39, overrideStatef, methodg);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::ScreenSpaceReflectionVolume::IsActive(
			//         ScreenSpaceReflectionVolume *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   BoolParameter *wrapperArray; // rdx
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
			//   wrapperArray = (BoolParameter *)v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( *(int *)&wrapperArray.fields._.m_Value <= 881 )
			//     goto LABEL_7;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_9;
			//   if ( LODWORD(v3._0.namespaze) <= 0x371 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !v3[18].vtable.Equals.methodPtr )
			//   {
			// LABEL_7:
			//     wrapperArray = this.fields.enable;
			//     if ( wrapperArray )
			//       return sub_1800023D0(10LL, wrapperArray);
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(881, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public BoolParameter enable;

		public ClampedFloatParameter fadenessOnScreen;

		public FloatParameter fadenessOnDepth;

		public ClampedFloatParameter fadenessOnDepthFactor;

		public FloatParameter fadenessOnMirrorMul;

		public FloatParameter fadenessOnMirrorAdd;

		public ClampedFloatParameter mipThreshold;
	}
}
