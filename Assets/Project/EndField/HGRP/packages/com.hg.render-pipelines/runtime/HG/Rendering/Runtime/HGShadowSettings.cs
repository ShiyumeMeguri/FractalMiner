using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("Shadowing/Shadows", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public class HGShadowSettings : VolumeComponent
	{
		private HGShadowSettings()
		{
			// // HGShadowSettings()
			// void HG::Rendering::Runtime::HGShadowSettings::HGShadowSettings(HGShadowSettings *this, MethodInfo *method)
			// {
			//   ClampedFloatParameter *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ClampedFloatParameter *v6; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   ClampedFloatParameter *v10; // rax
			//   ClampedFloatParameter *v11; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   ClampedFloatParameter *v15; // rax
			//   ClampedFloatParameter *v16; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   ClampedFloatParameter *v20; // rax
			//   ClampedFloatParameter *v21; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v22; // rdx
			//   PassConstructorID__Enum__Array *v23; // r8
			//   HGCamera *v24; // r9
			//   Texture2DParameter *v25; // rax
			//   Texture2DParameter *v26; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   ClampedFloatParameter *v30; // rax
			//   ClampedFloatParameter *v31; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v32; // rdx
			//   PassConstructorID__Enum__Array *v33; // r8
			//   HGCamera *v34; // r9
			//   ClampedFloatParameter *v35; // rax
			//   ClampedFloatParameter *v36; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v37; // rdx
			//   PassConstructorID__Enum__Array *v38; // r8
			//   HGCamera *v39; // r9
			//   LightShadowResolutionParameter *v40; // rax
			//   LightShadowResolutionParameter *v41; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v42; // rdx
			//   PassConstructorID__Enum__Array *v43; // r8
			//   HGCamera *v44; // r9
			//   HGShadowSampleModeParameter *v45; // rax
			//   HGShadowSampleModeParameter *v46; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v47; // rdx
			//   PassConstructorID__Enum__Array *v48; // r8
			//   HGCamera *v49; // r9
			//   HGRenderPathBase_HGRenderPathResources *v50; // rdx
			//   PassConstructorID__Enum__Array *v51; // r8
			//   HGCamera *v52; // r9
			//   MethodInfo *overrideStatec; // [rsp+20h] [rbp-28h]
			//   MethodInfo *overrideStated; // [rsp+20h] [rbp-28h]
			//   MethodInfo *overrideStatee; // [rsp+20h] [rbp-28h]
			//   MethodInfo *overrideStatef; // [rsp+20h] [rbp-28h]
			//   MethodInfo *overrideState; // [rsp+20h] [rbp-28h]
			//   MethodInfo *overrideStateg; // [rsp+20h] [rbp-28h]
			//   MethodInfo *overrideStateh; // [rsp+20h] [rbp-28h]
			//   MethodInfo *overrideStatea; // [rsp+20h] [rbp-28h]
			//   MethodInfo *overrideStateb; // [rsp+20h] [rbp-28h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-20h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-20h]
			//   MethodInfo *v71; // [rsp+70h] [rbp+28h]
			//   MethodInfo *v72; // [rsp+78h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDD14 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowSampleModeParameter);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightShadowResolutionParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//     sub_18003C530(&off_18C9BC568);
			//     byte_18D8EDD14 = 1;
			//   }
			//   v3 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v3, 1.0, 0.0, 10.0, 0, 0LL);
			//   this.fields.csmDepthBias = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.csmDepthBias, v7, v8, v9, overrideStatec, methodd);
			//   v10 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v10, 1.0, 0.0, 5.0, 0, 0LL);
			//   this.fields.csmNormalBias = v11;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.csmNormalBias, v12, v13, v14, overrideStated, methode);
			//   v15 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v16 = v15;
			//   if ( !v15 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v15, 1.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.shadowIntensity = v16;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.shadowIntensity, v17, v18, v19, overrideStatee, methodf);
			//   v20 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v21 = v20;
			//   if ( !v20 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v20, 0.0099999998, 0.001, 0.1, 0, 0LL);
			//   this.fields.csmShadowSoftness = v21;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.csmShadowSoftness, v22, v23, v24, overrideStatef, methodg);
			//   v25 = (Texture2DParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
			//   v26 = v25;
			//   if ( !v25 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v25, 0LL, 0, 0LL);
			//   this.fields.csmShadowRamp = v26;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.csmShadowRamp, v27, v28, v29, overrideState, methoda);
			//   v30 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v31 = v30;
			//   if ( !v30 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v30, 1.0, 0.0, 3.0, 0, 0LL);
			//   this.fields.characterDepthBias = v31;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.characterDepthBias, v32, v33, v34, overrideStateg, methodh);
			//   v35 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v36 = v35;
			//   if ( !v35 )
			//     goto LABEL_13;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v35, 1.0, 0.0, 25.0, 0, 0LL);
			//   this.fields.characterNormalBias = v36;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.characterNormalBias, v37, v38, v39, overrideStateh, methodi);
			//   v40 = (LightShadowResolutionParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::LightShadowResolutionParameter);
			//   v41 = v40;
			//   if ( !v40
			//     || (HG::Rendering::Runtime::LightShadowResolutionParameter::LightShadowResolutionParameter(
			//           v40,
			//           LightShadowResolution__Enum_FromQualitySettings,
			//           0,
			//           0LL),
			//         this.fields.characterShadowResolution = v41,
			//         sub_1800054D0(
			//           (HGRenderPathScene *)&this.fields.characterShadowResolution,
			//           v42,
			//           v43,
			//           v44,
			//           overrideStatea,
			//           methodb),
			//         v45 = (HGShadowSampleModeParameter *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGShadowSampleModeParameter),
			//         (v46 = v45) == 0LL) )
			//   {
			// LABEL_13:
			//     sub_180B536AC(v5, v4);
			//   }
			//   HG::Rendering::Runtime::HGShadowSampleModeParameter::HGShadowSampleModeParameter(
			//     v45,
			//     HGShadowSampleMode__Enum_PCF_Hard,
			//     0,
			//     0LL);
			//   this.fields.characterShadowSampleMode = v46;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.characterShadowSampleMode, v47, v48, v49, overrideStateb, methodc);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			//   this.fields._._displayName_k__BackingField = (String *)"Shadows";
			//   sub_1800054D0((HGRenderPathScene *)&this.fields._._displayName_k__BackingField, v50, v51, v52, v71, v72);
			// }
			// 
		}

		public ClampedFloatParameter csmDepthBias;

		public ClampedFloatParameter csmNormalBias;

		public ClampedFloatParameter shadowIntensity;

		public ClampedFloatParameter csmShadowSoftness;

		public Texture2DParameter csmShadowRamp;

		public ClampedFloatParameter characterDepthBias;

		public ClampedFloatParameter characterNormalBias;

		public LightShadowResolutionParameter characterShadowResolution;

		public HGShadowSampleModeParameter characterShadowSampleMode;
	}
}
