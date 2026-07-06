using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("HG/SceneColorStylizer", new Type[] { typeof(HGRenderPipeline) })]
	[Serializable]
	public class HGSceneColorStylizer : VolumeComponent
	{
		public HGSceneColorStylizer()
		{
			// // HGSceneColorStylizer()
			// void HG::Rendering::Runtime::HGSceneColorStylizer::HGSceneColorStylizer(HGSceneColorStylizer *this, MethodInfo *method)
			// {
			//   ClampedFloatParameter *v3; // rax
			//   HGRenderPathBase_HGRenderPathResources *v4; // rdx
			//   __int64 v5; // rcx
			//   ClampedFloatParameter *v6; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   FloatRangeParameter *v10; // rax
			//   FloatRangeParameter *v11; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   __int64 v15; // rdi
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   __m128i si128; // xmm7
			//   ClampedFloatParameter *v19; // rax
			//   ClampedFloatParameter *v20; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v21; // rdx
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   ClampedFloatParameter *v24; // rax
			//   ClampedFloatParameter *v25; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v26; // rdx
			//   PassConstructorID__Enum__Array *v27; // r8
			//   HGCamera *v28; // r9
			//   ClampedFloatParameter *v29; // rax
			//   ClampedFloatParameter *v30; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v31; // rdx
			//   PassConstructorID__Enum__Array *v32; // r8
			//   HGCamera *v33; // r9
			//   __int64 v34; // rdi
			//   PassConstructorID__Enum__Array *v35; // r8
			//   HGCamera *v36; // r9
			//   __m128i v37; // xmm7
			//   ClampedFloatParameter *v38; // rax
			//   ClampedFloatParameter *v39; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v40; // rdx
			//   PassConstructorID__Enum__Array *v41; // r8
			//   HGCamera *v42; // r9
			//   __int64 v43; // rdi
			//   PassConstructorID__Enum__Array *v44; // r8
			//   HGCamera *v45; // r9
			//   __m128i v46; // xmm7
			//   ClampedFloatParameter *v47; // rax
			//   ClampedFloatParameter *v48; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v49; // rdx
			//   PassConstructorID__Enum__Array *v50; // r8
			//   HGCamera *v51; // r9
			//   MethodInfo *overrideStatec; // [rsp+20h] [rbp-48h]
			//   MethodInfo *overrideStated; // [rsp+20h] [rbp-48h]
			//   MethodInfo *overrideState; // [rsp+20h] [rbp-48h]
			//   MethodInfo *overrideStatee; // [rsp+20h] [rbp-48h]
			//   MethodInfo *overrideStatef; // [rsp+20h] [rbp-48h]
			//   MethodInfo *overrideStateg; // [rsp+20h] [rbp-48h]
			//   MethodInfo *overrideStatea; // [rsp+20h] [rbp-48h]
			//   MethodInfo *overrideStateh; // [rsp+20h] [rbp-48h]
			//   MethodInfo *overrideStateb; // [rsp+20h] [rbp-48h]
			//   MethodInfo *overrideStatei; // [rsp+20h] [rbp-48h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-40h]
			//   MethodInfo *methodj; // [rsp+28h] [rbp-40h]
			// 
			//   if ( !byte_18D8EDC43 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::FloatRangeParameter);
			//     byte_18D8EDC43 = 1;
			//   }
			//   v3 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v6 = v3;
			//   if ( !v3 )
			//     goto LABEL_20;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v3, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.masterIntensity = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.masterIntensity, v7, v8, v9, overrideStatec, methodd);
			//   v10 = (FloatRangeParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::FloatRangeParameter);
			//   v11 = v10;
			//   if ( !v10 )
			//     goto LABEL_20;
			//   UnityEngine::Rendering::FloatRangeParameter::FloatRangeParameter(
			//     v10,
			//     (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x43480000u, (__m128)0x43960000u),
			//     0.0,
			//     1000.0,
			//     0,
			//     0LL);
			//   this.fields.startEndRange = v11;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.startEndRange, v12, v13, v14, overrideStated, methode);
			//   v15 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v15 )
			//     goto LABEL_20;
			//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A3577F0);
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(__m128i *)(v15 + 24) = si128;
			//   *(_WORD *)(v15 + 40) = 256;
			//   *(_BYTE *)(v15 + 42) = 1;
			//   *(_BYTE *)(v15 + 16) = 0;
			//   this.fields.farIndirectColorOverride = (ColorParameter *)v15;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farIndirectColorOverride, v4, v16, v17, overrideState, methoda);
			//   v19 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v20 = v19;
			//   if ( !v19 )
			//     goto LABEL_20;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v19, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.farRemoveIndirectDetail = v20;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farRemoveIndirectDetail, v21, v22, v23, overrideStatee, methodf);
			//   v24 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v25 = v24;
			//   if ( !v24 )
			//     goto LABEL_20;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v24, 1.0, 1.0, 10.0, 0, 0LL);
			//   this.fields.farIndirectColorIntensity = v25;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farIndirectColorIntensity, v26, v27, v28, overrideStatef, methodg);
			//   v29 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v30 = v29;
			//   if ( !v29 )
			//     goto LABEL_20;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v29, 0.0, 0.0, 1.0, 0, 0LL);
			//   this.fields.farIndirectRemove = v30;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farIndirectRemove, v31, v32, v33, overrideStateg, methodh);
			//   v34 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v34 )
			//     goto LABEL_20;
			//   v37 = _mm_load_si128((const __m128i *)&xmmword_18A3577F0);
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(__m128i *)(v34 + 24) = v37;
			//   *(_WORD *)(v34 + 40) = 256;
			//   *(_BYTE *)(v34 + 42) = 1;
			//   *(_BYTE *)(v34 + 16) = 0;
			//   this.fields.farDirectLightingOverride = (ColorParameter *)v34;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farDirectLightingOverride, v4, v35, v36, overrideStatea, methodb);
			//   v38 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v39 = v38;
			//   if ( !v38 )
			//     goto LABEL_20;
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v38, 1.0, 1.0, 10.0, 0, 0LL);
			//   this.fields.farDirectColorIntensity = v39;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farDirectColorIntensity, v40, v41, v42, overrideStateh, methodi);
			//   v43 = sub_180004920(TypeInfo::UnityEngine::Rendering::ColorParameter);
			//   if ( !v43 )
			//     goto LABEL_20;
			//   v46 = _mm_load_si128((const __m128i *)&xmmword_18A3577F0);
			//   if ( !byte_18D8F3661 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Color>::VolumeParameter);
			//     byte_18D8F3661 = 1;
			//   }
			//   *(__m128i *)(v43 + 24) = v46;
			//   *(_WORD *)(v43 + 40) = 256;
			//   *(_BYTE *)(v43 + 42) = 1;
			//   *(_BYTE *)(v43 + 16) = 0;
			//   this.fields.farAlbedoTint = (ColorParameter *)v43;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farAlbedoTint, v4, v44, v45, overrideStateb, methodc);
			//   v47 = (ClampedFloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
			//   v48 = v47;
			//   if ( !v47 )
			// LABEL_20:
			//     sub_180B536AC(v5, v4);
			//   UnityEngine::Rendering::ClampedFloatParameter::ClampedFloatParameter(v47, 1.0, 0.0, 5.0, 1, 0LL);
			//   this.fields.farAlbedoSaturation = v48;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.farAlbedoSaturation, v49, v50, v51, overrideStatei, methodj);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		private const string DOC_URL = "https://hypergryph.feishu.cn/wiki/wikcnvHsajmJ6CMUmnMfBzXgoSg";

		[InspectorName("总开关")]
		public ClampedFloatParameter masterIntensity;

		[InspectorName("影响范围起始 / 结束")]
		public FloatRangeParameter startEndRange;

		[Space(20f)]
		[InspectorName("远景间接光颜色覆盖")]
		public ColorParameter farIndirectColorOverride;

		[InspectorName("远景间接光细节扁平化")]
		public ClampedFloatParameter farRemoveIndirectDetail;

		[InspectorName("远景间接光增强")]
		public ClampedFloatParameter farIndirectColorIntensity;

		[InspectorName("远景直接光成分剔除间接光")]
		public ClampedFloatParameter farIndirectRemove;

		[Space(20f)]
		[InspectorName("远景直接光颜色覆盖")]
		public ColorParameter farDirectLightingOverride;

		[InspectorName("远景直接光增强")]
		public ClampedFloatParameter farDirectColorIntensity;

		[InspectorName("远景材质固有色染色")]
		[Space(20f)]
		public ColorParameter farAlbedoTint;

		[InspectorName("远景材质固有色饱和度")]
		public ClampedFloatParameter farAlbedoSaturation;
	}
}
