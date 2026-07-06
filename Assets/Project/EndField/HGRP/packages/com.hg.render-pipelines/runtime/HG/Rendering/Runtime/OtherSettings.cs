using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("HG/Other Settings", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public sealed class OtherSettings : VolumeComponent, IPostProcessComponent
	{
		public OtherSettings()
		{
			// // OtherSettings()
			// void HG::Rendering::Runtime::OtherSettings::OtherSettings(OtherSettings *this, MethodInfo *method)
			// {
			//   __int128 v2; // xmm7
			//   BoolParameter *v4; // rax
			//   HGRenderPathBase_HGRenderPathResources *v5; // rdx
			//   __int64 v6; // rcx
			//   BoolParameter *v7; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
			//   PassConstructorID__Enum__Array *v9; // r8
			//   HGCamera *v10; // r9
			//   BoolParameter *v11; // rax
			//   BoolParameter *v12; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   BoolParameter *v16; // rax
			//   BoolParameter *v17; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   __int64 v21; // rdi
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   __int64 v24; // rdi
			//   PassConstructorID__Enum__Array *v25; // r8
			//   HGCamera *v26; // r9
			//   FloatParameter *v27; // rax
			//   FloatParameter *v28; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v29; // rdx
			//   PassConstructorID__Enum__Array *v30; // r8
			//   HGCamera *v31; // r9
			//   MethodInfo *v32; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v33; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v34; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v35; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v36; // [rsp+20h] [rbp-28h]
			//   MethodInfo *v37; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v38; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v39; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v40; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v41; // [rsp+28h] [rbp-20h]
			// 
			//   if ( !byte_18D8ED9E2 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::BoolParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::FloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector3Parameter);
			//     byte_18D8ED9E2 = 1;
			//   }
			//   v4 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v7 = v4;
			//   if ( !v4 )
			//     goto LABEL_14;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v4, 0, 0, 0LL);
			//   this.fields.enable = v7;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.enable, v8, v9, v10, (MethodInfo *)v2, *((MethodInfo **)&v2 + 1));
			//   v11 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v12 = v11;
			//   if ( !v11 )
			//     goto LABEL_14;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v11, 0, 0, 0LL);
			//   this.fields.fakePlanarReflection = v12;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.fakePlanarReflection, v13, v14, v15, v32, v37);
			//   v16 = (BoolParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::BoolParameter);
			//   v17 = v16;
			//   if ( !v16 )
			//     goto LABEL_14;
			//   UnityEngine::Rendering::BoolParameter::BoolParameter(v16, 0, 0, 0LL);
			//   this.fields.fakePlanarDisableCharacterOutline = v17;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.fakePlanarDisableCharacterOutline, v18, v19, v20, v33, v38);
			//   v21 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector3Parameter);
			//   if ( !v21 )
			//     goto LABEL_14;
			//   if ( !byte_18D8F3663 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector3>::VolumeParameter);
			//     byte_18D8F3663 = 1;
			//   }
			//   *(_BYTE *)(v21 + 16) = 0;
			//   *(_QWORD *)(v21 + 24) = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//   *(_DWORD *)(v21 + 32) = 0;
			//   this.fields.fakeReflectionProbeNormal = (Vector3Parameter *)v21;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.fakeReflectionProbeNormal, v5, v22, v23, v34, v39);
			//   v24 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector3Parameter);
			//   if ( !v24 )
			//     goto LABEL_14;
			//   if ( !byte_18D8F3663 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector3>::VolumeParameter);
			//     byte_18D8F3663 = 1;
			//   }
			//   *(_BYTE *)(v24 + 16) = 0;
			//   *(_QWORD *)(v24 + 24) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   *(_DWORD *)(v24 + 32) = 0;
			//   this.fields.fakeReflectionPos = (Vector3Parameter *)v24;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.fakeReflectionPos, v5, v25, v26, v35, v40);
			//   v27 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatParameter);
			//   v28 = v27;
			//   if ( !v27 )
			// LABEL_14:
			//     sub_180B536AC(v6, v5);
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v27, 1.0, 0, 0LL);
			//   this.fields.fakePlanarReflectionBlur = v28;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.fakePlanarReflectionBlur, v29, v30, v31, v36, v41);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::OtherSettings::IsActive(OtherSettings *this, MethodInfo *method)
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
			//   if ( *(int *)&wrapperArray.fields._.m_Value <= 992 )
			//     goto LABEL_7;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_9;
			//   if ( LODWORD(v3._0.namespaze) <= 0x3E0 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !v3[21]._0.castClass )
			//   {
			// LABEL_7:
			//     wrapperArray = this.fields.enable;
			//     if ( wrapperArray )
			//       return sub_1800023D0(10LL, wrapperArray);
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(992, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public BoolParameter enable;

		public BoolParameter fakePlanarReflection;

		public BoolParameter fakePlanarDisableCharacterOutline;

		public Vector3Parameter fakeReflectionProbeNormal;

		public Vector3Parameter fakeReflectionPos;

		public FloatParameter fakePlanarReflectionBlur;
	}
}
