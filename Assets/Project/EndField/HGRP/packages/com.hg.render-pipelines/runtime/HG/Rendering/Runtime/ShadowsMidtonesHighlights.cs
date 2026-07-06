using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/Shadows, Midtones, Highlights", new Type[] { typeof(HGRenderPipeline) })]
	[MigratingVolumeComponent]
	[Serializable]
	public sealed class ShadowsMidtonesHighlights : VolumeComponent, IPostProcessComponent
	{
		private ShadowsMidtonesHighlights()
		{
			// // ShadowsMidtonesHighlights()
			// void HG::Rendering::Runtime::ShadowsMidtonesHighlights::ShadowsMidtonesHighlights(
			//         ShadowsMidtonesHighlights *this,
			//         MethodInfo *method)
			// {
			//   __int128 v2; // xmm6
			//   HGRenderPathBase_HGRenderPathResources *v4; // rdx
			//   __int64 v5; // rcx
			//   __int64 v6; // rdi
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   __m128i si128; // xmm6
			//   __int64 v10; // rdi
			//   PassConstructorID__Enum__Array *v11; // r8
			//   HGCamera *v12; // r9
			//   __m128i v13; // xmm6
			//   __int64 v14; // rdi
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   __m128i v17; // xmm6
			//   FloatParameter *v18; // rax
			//   FloatParameter *v19; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v20; // rdx
			//   PassConstructorID__Enum__Array *v21; // r8
			//   HGCamera *v22; // r9
			//   FloatParameter *v23; // rax
			//   FloatParameter *v24; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v25; // rdx
			//   PassConstructorID__Enum__Array *v26; // r8
			//   HGCamera *v27; // r9
			//   FloatParameter *v28; // rax
			//   FloatParameter *v29; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v30; // rdx
			//   PassConstructorID__Enum__Array *v31; // r8
			//   HGCamera *v32; // r9
			//   FloatParameter *v33; // rax
			//   FloatParameter *v34; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v35; // rdx
			//   PassConstructorID__Enum__Array *v36; // r8
			//   HGCamera *v37; // r9
			//   HGRenderPathBase_HGRenderPathResources *v38; // rdx
			//   PassConstructorID__Enum__Array *v39; // r8
			//   HGCamera *v40; // r9
			//   __int128 v41; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v42; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v43; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v44; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v45; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v46; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v47; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v48; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v49; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v50; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v51; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v52; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v53; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v54; // [rsp+60h] [rbp+28h]
			//   MethodInfo *v55; // [rsp+68h] [rbp+30h]
			// 
			//   if ( !byte_18D8ED9E7 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//     sub_18003C530(&off_18C8E8460);
			//     byte_18D8ED9E7 = 1;
			//   }
			//   v41 = v2;
			//   v6 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v6 )
			//     goto LABEL_17;
			//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A3577F0);
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(__m128i *)(v6 + 24) = si128;
			//   *(_BYTE *)(v6 + 16) = 0;
			//   this.fields.shadows = (Vector4Parameter *)v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.shadows, v4, v7, v8, (MethodInfo *)v41, *((MethodInfo **)&v41 + 1));
			//   v10 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v10 )
			//     goto LABEL_17;
			//   v13 = _mm_load_si128((const __m128i *)&xmmword_18A3577F0);
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(__m128i *)(v10 + 24) = v13;
			//   *(_BYTE *)(v10 + 16) = 0;
			//   this.fields.midtones = (Vector4Parameter *)v10;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.midtones, v4, v11, v12, v42, v48);
			//   v14 = sub_180004920(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
			//   if ( !v14 )
			//     goto LABEL_17;
			//   v17 = _mm_load_si128((const __m128i *)&xmmword_18A3577F0);
			//   if ( !byte_18D8F3664 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::VolumeParameter);
			//     byte_18D8F3664 = 1;
			//   }
			//   *(__m128i *)(v14 + 24) = v17;
			//   *(_BYTE *)(v14 + 16) = 0;
			//   this.fields.highlights = (Vector4Parameter *)v14;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.highlights, v4, v15, v16, v43, v49);
			//   v18 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v19 = v18;
			//   if ( !v18 )
			//     goto LABEL_17;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v18, 0.0, 0, 0LL);
			//   LODWORD(v19[1].klass) = 0;
			//   this.fields.shadowsStart = (MinFloatParameter *)v19;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.shadowsStart, v20, v21, v22, v44, v50);
			//   v23 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v24 = v23;
			//   if ( !v23 )
			//     goto LABEL_17;
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v23, 0.30000001, 0, 0LL);
			//   LODWORD(v24[1].klass) = 0;
			//   this.fields.shadowsEnd = (MinFloatParameter *)v24;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.shadowsEnd, v25, v26, v27, v45, v51);
			//   v28 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter);
			//   v29 = v28;
			//   if ( !v28
			//     || (UnityEngine::Rendering::FloatParameter::FloatParameter(v28, 0.55000001, 0, 0LL),
			//         LODWORD(v29[1].klass) = 0,
			//         this.fields.highlightsStart = (MinFloatParameter *)v29,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.highlightsStart, v30, v31, v32, v46, v52),
			//         v33 = (FloatParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::MinFloatParameter),
			//         (v34 = v33) == 0LL) )
			//   {
			// LABEL_17:
			//     sub_180B536AC(v5, v4);
			//   }
			//   UnityEngine::Rendering::FloatParameter::FloatParameter(v33, 1.0, 0, 0LL);
			//   LODWORD(v34[1].klass) = 0;
			//   this.fields.highlightsEnd = (MinFloatParameter *)v34;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.highlightsEnd, v35, v36, v37, v47, v53);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			//   this.fields._._displayName_k__BackingField = (String *)"Shadows, Midtones, Highlights";
			//   sub_1800054D0((HGRenderPathScene *)&this.fields._._displayName_k__BackingField, v38, v39, v40, v54, v55);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::ShadowsMidtonesHighlights::IsActive(ShadowsMidtonesHighlights *this, MethodInfo *method)
			// {
			//   __m128i si128; // xmm6
			//   Vector4Parameter *shadows; // rcx
			//   Vector4Parameter *midtones; // rcx
			//   Vector4Parameter *highlights; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __m128i v11; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D91945E )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::VolumeParameter<UnityEngine::Vector4>::op_Inequality);
			//     byte_18D91945E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2244, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2244, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     si128 = _mm_load_si128((const __m128i *)&xmmword_18A3577F0);
			//     shadows = this.fields.shadows;
			//     v11 = si128;
			//     if ( (unsigned __int8)sub_1808301B8(shadows, &v11) )
			//       return 1;
			//     midtones = this.fields.midtones;
			//     v11 = si128;
			//     if ( (unsigned __int8)sub_1808301B8(midtones, &v11) )
			//     {
			//       return 1;
			//     }
			//     else
			//     {
			//       highlights = this.fields.highlights;
			//       v11 = si128;
			//       return sub_1808301B8(highlights, &v11);
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		[Tooltip("Use this to control and apply a hue to the shadows.")]
		public Vector4Parameter shadows;

		[Tooltip("Use this to control and apply a hue to the midtones.")]
		public Vector4Parameter midtones;

		[Tooltip("Use this to control and apply a hue to the highlights.")]
		public Vector4Parameter highlights;

		[Tooltip("Sets the start point of the transition between shadows and midtones.")]
		[Header("Shadow Limits")]
		public MinFloatParameter shadowsStart;

		[Tooltip("Sets the end point of the transition between shadows and midtones.")]
		public MinFloatParameter shadowsEnd;

		[Tooltip("Sets the start point of the transition between midtones and highlights.")]
		[Header("Highlight Limits")]
		public MinFloatParameter highlightsStart;

		[Tooltip("Sets the end point of the transition between midtones and highlights.")]
		public MinFloatParameter highlightsEnd;
	}
}
