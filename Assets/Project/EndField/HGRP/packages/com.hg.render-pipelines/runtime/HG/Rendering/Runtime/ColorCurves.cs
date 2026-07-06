using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[VolumeComponentMenuForRenderPipeline("Post-processing/Color Curves", new Type[] { typeof(HGRenderPipeline) })]
	[MigratingVolumeComponent]
	[Serializable]
	public sealed class ColorCurves : VolumeComponent, IPostProcessComponent
	{
		public ColorCurves()
		{
			// // ColorCurves()
			// void HG::Rendering::Runtime::ColorCurves::ColorCurves(ColorCurves *this, MethodInfo *method)
			// {
			//   __int64 v2; // r8
			//   __int64 v3; // r9
			//   __int64 v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __m128i si128; // xmm0
			//   Keyframe__Array *v9; // rbx
			//   __m128i v10; // xmm0
			//   TextureCurve *v11; // rsi
			//   TextureCurveParameter *v12; // rax
			//   TextureCurveParameter *v13; // rbx
			//   OneofDescriptorProto *v14; // rdx
			//   FileDescriptor *v15; // r8
			//   MessageDescriptor *v16; // r9
			//   __int64 v17; // r8
			//   __int64 v18; // r9
			//   __int64 v19; // rax
			//   __m128i v20; // xmm0
			//   Keyframe__Array *v21; // rbx
			//   __m128i v22; // xmm0
			//   TextureCurve *v23; // rsi
			//   TextureCurveParameter *v24; // rax
			//   TextureCurveParameter *v25; // rbx
			//   OneofDescriptorProto *v26; // rdx
			//   FileDescriptor *v27; // r8
			//   MessageDescriptor *v28; // r9
			//   __int64 v29; // r8
			//   __int64 v30; // r9
			//   __int64 v31; // rax
			//   __m128i v32; // xmm0
			//   Keyframe__Array *v33; // rbx
			//   __m128i v34; // xmm0
			//   TextureCurve *v35; // rsi
			//   TextureCurveParameter *v36; // rax
			//   TextureCurveParameter *v37; // rbx
			//   OneofDescriptorProto *v38; // rdx
			//   FileDescriptor *v39; // r8
			//   MessageDescriptor *v40; // r9
			//   __int64 v41; // r8
			//   __int64 v42; // r9
			//   __int64 v43; // rax
			//   __m128i v44; // xmm0
			//   Keyframe__Array *v45; // rbx
			//   __m128i v46; // xmm0
			//   TextureCurve *v47; // rsi
			//   TextureCurveParameter *v48; // rax
			//   TextureCurveParameter *v49; // rbx
			//   OneofDescriptorProto *v50; // rdx
			//   FileDescriptor *v51; // r8
			//   MessageDescriptor *v52; // r9
			//   __int64 v53; // r8
			//   __int64 v54; // r9
			//   Keyframe__Array *v55; // rbx
			//   TextureCurve *v56; // rsi
			//   TextureCurveParameter *v57; // rax
			//   TextureCurveParameter *v58; // rbx
			//   OneofDescriptorProto *v59; // rdx
			//   FileDescriptor *v60; // r8
			//   MessageDescriptor *v61; // r9
			//   __int64 v62; // r8
			//   __int64 v63; // r9
			//   Keyframe__Array *v64; // rbx
			//   TextureCurve *v65; // rsi
			//   TextureCurveParameter *v66; // rax
			//   TextureCurveParameter *v67; // rbx
			//   OneofDescriptorProto *v68; // rdx
			//   FileDescriptor *v69; // r8
			//   MessageDescriptor *v70; // r9
			//   __int64 v71; // r8
			//   __int64 v72; // r9
			//   Keyframe__Array *v73; // rbx
			//   TextureCurve *v74; // rsi
			//   TextureCurveParameter *v75; // rax
			//   TextureCurveParameter *v76; // rbx
			//   OneofDescriptorProto *v77; // rdx
			//   FileDescriptor *v78; // r8
			//   MessageDescriptor *v79; // r9
			//   __int64 v80; // r8
			//   __int64 v81; // r9
			//   Keyframe__Array *v82; // rbx
			//   TextureCurve *v83; // rsi
			//   TextureCurveParameter *v84; // rax
			//   TextureCurveParameter *v85; // rbx
			//   OneofDescriptorProto *v86; // rdx
			//   FileDescriptor *v87; // r8
			//   MessageDescriptor *v88; // r9
			//   String__Array *bounds; // [rsp+20h] [rbp-60h]
			//   String__Array *boundsa; // [rsp+20h] [rbp-60h]
			//   String__Array *boundsb; // [rsp+20h] [rbp-60h]
			//   String__Array *boundsc; // [rsp+20h] [rbp-60h]
			//   String__Array *boundsd; // [rsp+20h] [rbp-60h]
			//   String__Array *boundse; // [rsp+20h] [rbp-60h]
			//   String__Array *boundsf; // [rsp+20h] [rbp-60h]
			//   String__Array *boundsg; // [rsp+20h] [rbp-60h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-58h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-58h]
			//   MethodInfo *v105; // [rsp+30h] [rbp-50h]
			//   MethodInfo *v106; // [rsp+30h] [rbp-50h]
			//   MethodInfo *v107; // [rsp+30h] [rbp-50h]
			//   MethodInfo *v108; // [rsp+30h] [rbp-50h]
			//   MethodInfo *v109; // [rsp+30h] [rbp-50h]
			//   MethodInfo *v110; // [rsp+30h] [rbp-50h]
			//   MethodInfo *v111; // [rsp+30h] [rbp-50h]
			//   MethodInfo *v112; // [rsp+30h] [rbp-50h]
			//   Vector2 v113; // [rsp+B0h] [rbp+30h] BYREF
			// 
			//   if ( !byte_18D8ED9C4 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Keyframe);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::TextureCurve);
			//     byte_18D8ED9C4 = 1;
			//   }
			//   v5 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 2LL, v2, v3);
			//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A357450);
			//   v9 = (Keyframe__Array *)v5;
			//   if ( !v5 )
			//     goto LABEL_32;
			//   if ( !*(_DWORD *)(v5 + 24)
			//     || (*(__m128i *)(v5 + 32) = si128,
			//         *(_QWORD *)(v5 + 48) = 0LL,
			//         v10 = _mm_load_si128((const __m128i *)&xmmword_18A357460),
			//         *(_DWORD *)(v5 + 56) = 0,
			//         *(_DWORD *)(v5 + 24) <= 1u) )
			//   {
			// LABEL_33:
			//     sub_180070270(v7, v6);
			//   }
			//   *(__m128i *)(v5 + 60) = v10;
			//   *(_QWORD *)(v5 + 76) = 0LL;
			//   *(_DWORD *)(v5 + 84) = 0;
			//   v113 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//   v11 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
			//   if ( !v11 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurve::TextureCurve(v11, v9, 0.0, 0, &v113, 0LL);
			//   v12 = (TextureCurveParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
			//   v13 = v12;
			//   if ( !v12
			//     || (UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v12, v11, 0, 0LL),
			//         this.fields.master = v13,
			//         sub_1800054D0((OneofDescriptor *)&this.fields.master, v14, v15, v16, bounds, (String *)methoda, v105),
			//         v19 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 2LL, v17, v18),
			//         v20 = _mm_load_si128((const __m128i *)&xmmword_18A357450),
			//         (v21 = (Keyframe__Array *)v19) == 0LL) )
			//   {
			// LABEL_32:
			//     sub_180B536AC(v7, v6);
			//   }
			//   if ( !*(_DWORD *)(v19 + 24) )
			//     goto LABEL_33;
			//   *(__m128i *)(v19 + 32) = v20;
			//   *(_QWORD *)(v19 + 48) = 0LL;
			//   v22 = _mm_load_si128((const __m128i *)&xmmword_18A357460);
			//   *(_DWORD *)(v19 + 56) = 0;
			//   if ( *(_DWORD *)(v19 + 24) <= 1u )
			//     goto LABEL_33;
			//   *(__m128i *)(v19 + 60) = v22;
			//   *(_QWORD *)(v19 + 76) = 0LL;
			//   *(_DWORD *)(v19 + 84) = 0;
			//   v113 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//   v23 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
			//   if ( !v23 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurve::TextureCurve(v23, v21, 0.0, 0, &v113, 0LL);
			//   v24 = (TextureCurveParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
			//   v25 = v24;
			//   if ( !v24 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v24, v23, 0, 0LL);
			//   this.fields.red = v25;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.red, v26, v27, v28, boundsa, (String *)methodb, v106);
			//   v31 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 2LL, v29, v30);
			//   v32 = _mm_load_si128((const __m128i *)&xmmword_18A357450);
			//   v33 = (Keyframe__Array *)v31;
			//   if ( !v31 )
			//     goto LABEL_32;
			//   if ( !*(_DWORD *)(v31 + 24) )
			//     goto LABEL_33;
			//   *(__m128i *)(v31 + 32) = v32;
			//   *(_QWORD *)(v31 + 48) = 0LL;
			//   v34 = _mm_load_si128((const __m128i *)&xmmword_18A357460);
			//   *(_DWORD *)(v31 + 56) = 0;
			//   if ( *(_DWORD *)(v31 + 24) <= 1u )
			//     goto LABEL_33;
			//   *(__m128i *)(v31 + 60) = v34;
			//   *(_QWORD *)(v31 + 76) = 0LL;
			//   *(_DWORD *)(v31 + 84) = 0;
			//   v113 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//   v35 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
			//   if ( !v35 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurve::TextureCurve(v35, v33, 0.0, 0, &v113, 0LL);
			//   v36 = (TextureCurveParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
			//   v37 = v36;
			//   if ( !v36 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v36, v35, 0, 0LL);
			//   this.fields.green = v37;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.green, v38, v39, v40, boundsb, (String *)methodc, v107);
			//   v43 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 2LL, v41, v42);
			//   v44 = _mm_load_si128((const __m128i *)&xmmword_18A357450);
			//   v45 = (Keyframe__Array *)v43;
			//   if ( !v43 )
			//     goto LABEL_32;
			//   if ( !*(_DWORD *)(v43 + 24) )
			//     goto LABEL_33;
			//   *(__m128i *)(v43 + 32) = v44;
			//   *(_QWORD *)(v43 + 48) = 0LL;
			//   v46 = _mm_load_si128((const __m128i *)&xmmword_18A357460);
			//   *(_DWORD *)(v43 + 56) = 0;
			//   if ( *(_DWORD *)(v43 + 24) <= 1u )
			//     goto LABEL_33;
			//   *(__m128i *)(v43 + 60) = v46;
			//   *(_QWORD *)(v43 + 76) = 0LL;
			//   *(_DWORD *)(v43 + 84) = 0;
			//   v113 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//   v47 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
			//   if ( !v47 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurve::TextureCurve(v47, v45, 0.0, 0, &v113, 0LL);
			//   v48 = (TextureCurveParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
			//   v49 = v48;
			//   if ( !v48 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v48, v47, 0, 0LL);
			//   this.fields.blue = v49;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.blue, v50, v51, v52, boundsc, (String *)methodd, v108);
			//   v55 = (Keyframe__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 0LL, v53, v54);
			//   v113 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//   v56 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
			//   if ( !v56 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurve::TextureCurve(v56, v55, 0.5, 1, &v113, 0LL);
			//   v57 = (TextureCurveParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
			//   v58 = v57;
			//   if ( !v57 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v57, v56, 0, 0LL);
			//   this.fields.hueVsHue = v58;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.hueVsHue, v59, v60, v61, boundsd, (String *)methode, v109);
			//   v64 = (Keyframe__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 0LL, v62, v63);
			//   v113 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//   v65 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
			//   if ( !v65 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurve::TextureCurve(v65, v64, 0.5, 1, &v113, 0LL);
			//   v66 = (TextureCurveParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
			//   v67 = v66;
			//   if ( !v66 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v66, v65, 0, 0LL);
			//   this.fields.hueVsSat = v67;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.hueVsSat, v68, v69, v70, boundse, (String *)methodf, v110);
			//   v73 = (Keyframe__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 0LL, v71, v72);
			//   v113 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//   v74 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
			//   if ( !v74 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurve::TextureCurve(v74, v73, 0.5, 0, &v113, 0LL);
			//   v75 = (TextureCurveParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
			//   v76 = v75;
			//   if ( !v75 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v75, v74, 0, 0LL);
			//   this.fields.satVsSat = v76;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.satVsSat, v77, v78, v79, boundsf, (String *)methodg, v111);
			//   v82 = (Keyframe__Array *)il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Keyframe, 0LL, v80, v81);
			//   v113 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
			//   v83 = (TextureCurve *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurve);
			//   if ( !v83 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurve::TextureCurve(v83, v82, 0.5, 0, &v113, 0LL);
			//   v84 = (TextureCurveParameter *)sub_180004920(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
			//   v85 = v84;
			//   if ( !v84 )
			//     goto LABEL_32;
			//   UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v84, v83, 0, 0LL);
			//   this.fields.lumVsSat = v85;
			//   sub_1800054D0((OneofDescriptor *)&this.fields.lumVsSat, v86, v87, v88, boundsg, (String *)methodh, v112);
			//   UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
			// }
			// 
		}

		public bool IsActive()
		{
			// // Boolean IsActive()
			// bool HG::Rendering::Runtime::ColorCurves::IsActive(ColorCurves *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2215, 0LL) )
			//     return 1;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2215, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public TextureCurveParameter master;

		public TextureCurveParameter red;

		public TextureCurveParameter green;

		public TextureCurveParameter blue;

		public TextureCurveParameter hueVsHue;

		public TextureCurveParameter hueVsSat;

		public TextureCurveParameter satVsSat;

		public TextureCurveParameter lumVsSat;

		[SerializeField]
		private int m_SelectedCurve;
	}
}
