using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/HGSharpen", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class HGSharpen : VolumeComponent, IPostProcessComponent
	{
		public HGSharpen()
		{
			// // HGSharpen()
			// void HG::Rendering::Runtime::HGSharpen::HGSharpen(HGSharpen *this, MethodInfo *method)
			// {
			//   HGSharpenModeParameter *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   HGSharpenModeParameter *v6; // rdi
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
			//   MethodInfo *overrideState; // [rsp+20h] [rbp-28h]
			//   MethodInfo *overrideStateb; // [rsp+20h] [rbp-28h]
			//   MethodInfo *overrideStatea; // [rsp+20h] [rbp-28h]
			//   MethodInfo *overrideStatec; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-20h]
			// 
			//   if ( !byte_18D8ED9DE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::FloatParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSharpenModeParameter);
			//     byte_18D8ED9DE = 1;
			//   }
			//   v3 = (HGSharpenModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGSharpenModeParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_8;
			//   HG::Rendering::Runtime::HGSharpenModeParameter::HGSharpenModeParameter(v3, HGSharpenMode__Enum_Off, 0, 0LL);
			//   this.fields.sharpenMode = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.sharpenMode, v7, v8, v9, overrideState, methoda);
			//   v10 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_8;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v10, 0.0, 0.0, 5.0, 0, 0LL);
			//   this.fields.sharpenIntensity = v11;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.sharpenIntensity, v12, v13, v14, overrideStateb, methodc);
			//   v15 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatParameter);
			//   v16 = v15;
			//   if ( !v15
			//     || (UnityEngine::Rendering::FloatParameter::FloatParameter(v15, 1.0, 0, 0LL),
			//         this.fields.sharpenRange = v16,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.sharpenRange, v17, v18, v19, overrideStatea, methodb),
			//         v20 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter),
			//         (v21 = v20) == 0LL) )
			//   {
			// LABEL_8:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v20, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.sharpenThreshold = v21;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.sharpenThreshold, v22, v23, v24, overrideStatec, methodd);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::HGSharpen::IsActive(HGSharpen *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   HGSharpenModeParameter *wrapperArray; // rdx
			//   int v5; // eax
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
			//   wrapperArray = (HGSharpenModeParameter *)v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.fields._.m_Value <= 963 )
			//     goto LABEL_7;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			// LABEL_11:
			//     sub_180B536AC(v3, wrapperArray);
			//   if ( LODWORD(v3._0.namespaze) <= 0x3C3 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( *(_QWORD *)&v3[20]._1.initializationExceptionGCHandle )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(963, 0LL);
			//     if ( Patch )
			//     {
			//       LOBYTE(v5) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//                      (ILFixDynamicMethodWrapper_27 *)Patch,
			//                      (Object *)this,
			//                      0LL);
			//       return v5;
			//     }
			//     goto LABEL_11;
			//   }
			// LABEL_7:
			//   wrapperArray = this.fields.sharpenMode;
			//   if ( !wrapperArray )
			//     goto LABEL_11;
			//   v5 = sub_18003ED00(10LL);
			//   if ( v5 )
			//     LOBYTE(v5) = 1;
			//   return v5;
			// }
			// 
			return default(bool);
		}

		public bool IsTileCompatible()
		{
			// // Boolean IsTileCompatible()
			// bool HG::Rendering::Runtime::HGSharpen::IsTileCompatible(HGSharpen *this, MethodInfo *method)
			// {
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   result = IFix::WrappersManagerImpl::IsPatched(2232, 0LL);
			//   if ( result )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2232, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}

		public HGSharpenModeParameter sharpenMode;

		public ClampedFloatParameter sharpenIntensity;

		public FloatParameter sharpenRange;

		public ClampedFloatParameter sharpenThreshold;
	}
}
