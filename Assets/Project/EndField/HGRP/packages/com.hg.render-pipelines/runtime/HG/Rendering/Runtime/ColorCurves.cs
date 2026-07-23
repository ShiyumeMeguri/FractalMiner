using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[MigratingVolumeComponent]
	[VolumeComponentMenuForRenderPipeline("Post-processing/Color Curves", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class ColorCurves : VolumeComponent, IPostProcessComponent // TypeDefIndex: 38008
	{
		// Fields
		public TextureCurveParameter master; // 0x30
		public TextureCurveParameter red; // 0x38
		public TextureCurveParameter green; // 0x40
		public TextureCurveParameter blue; // 0x48
		public TextureCurveParameter hueVsHue; // 0x50
		public TextureCurveParameter hueVsSat; // 0x58
		public TextureCurveParameter satVsSat; // 0x60
		public TextureCurveParameter lumVsSat; // 0x68
		[SerializeField]
		private int m_SelectedCurve; // 0x70
	
		// Constructors
		public ColorCurves() {} // 0x00000001839C50B0-0x00000001839C5700
		// ColorCurves()
		void HG::Rendering::Runtime::ColorCurves::ColorCurves(ColorCurves *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  __m128i si128; // xmm0
		  Keyframe__Array *v7; // rbx
		  __m128i v8; // xmm0
		  TextureCurve *v9; // rsi
		  TextureCurveParameter *v10; // rax
		  TextureCurveParameter *v11; // rbx
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  __int64 v15; // rax
		  __m128i v16; // xmm0
		  Keyframe__Array *v17; // rbx
		  __m128i v18; // xmm0
		  TextureCurve *v19; // rsi
		  TextureCurveParameter *v20; // rax
		  TextureCurveParameter *v21; // rbx
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  __int64 v25; // rax
		  __m128i v26; // xmm0
		  Keyframe__Array *v27; // rbx
		  __m128i v28; // xmm0
		  TextureCurve *v29; // rsi
		  TextureCurveParameter *v30; // rax
		  TextureCurveParameter *v31; // rbx
		  Type *v32; // rdx
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **v34; // r9
		  __int64 v35; // rax
		  __m128i v36; // xmm0
		  Keyframe__Array *v37; // rbx
		  __m128i v38; // xmm0
		  TextureCurve *v39; // rsi
		  TextureCurveParameter *v40; // rax
		  TextureCurveParameter *v41; // rbx
		  Type *v42; // rdx
		  PropertyInfo_1 *v43; // r8
		  Int32__Array **v44; // r9
		  Keyframe__Array *v45; // rbx
		  TextureCurve *v46; // rsi
		  TextureCurveParameter *v47; // rax
		  TextureCurveParameter *v48; // rbx
		  Type *v49; // rdx
		  PropertyInfo_1 *v50; // r8
		  Int32__Array **v51; // r9
		  Keyframe__Array *v52; // rbx
		  TextureCurve *v53; // rsi
		  TextureCurveParameter *v54; // rax
		  TextureCurveParameter *v55; // rbx
		  Type *v56; // rdx
		  PropertyInfo_1 *v57; // r8
		  Int32__Array **v58; // r9
		  Keyframe__Array *v59; // rbx
		  TextureCurve *v60; // rsi
		  TextureCurveParameter *v61; // rax
		  TextureCurveParameter *v62; // rbx
		  Type *v63; // rdx
		  PropertyInfo_1 *v64; // r8
		  Int32__Array **v65; // r9
		  Keyframe__Array *v66; // rbx
		  TextureCurve *v67; // rsi
		  TextureCurveParameter *v68; // rax
		  TextureCurveParameter *v69; // rbx
		  Type *v70; // rdx
		  PropertyInfo_1 *v71; // r8
		  Int32__Array **v72; // r9
		  MethodInfo *bounds; // [rsp+20h] [rbp-60h]
		  MethodInfo *boundsa; // [rsp+20h] [rbp-60h]
		  MethodInfo *boundsb; // [rsp+20h] [rbp-60h]
		  MethodInfo *boundsc; // [rsp+20h] [rbp-60h]
		  MethodInfo *boundsd; // [rsp+20h] [rbp-60h]
		  MethodInfo *boundse; // [rsp+20h] [rbp-60h]
		  MethodInfo *boundsf; // [rsp+20h] [rbp-60h]
		  MethodInfo *boundsg; // [rsp+20h] [rbp-60h]
		  Vector2 v81; // [rsp+B0h] [rbp+30h] BYREF
		
		  v3 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 2LL);
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959770);
		  v7 = (Keyframe__Array *)v3;
		  if ( !v3 )
		    goto LABEL_30;
		  if ( !*(_DWORD *)(v3 + 24)
		    || (*(__m128i *)(v3 + 32) = si128,
		        *(_QWORD *)(v3 + 48) = 0LL,
		        v8 = _mm_load_si128((const __m128i *)&xmmword_18B959780),
		        *(_DWORD *)(v3 + 56) = 0,
		        *(_DWORD *)(v3 + 24) <= 1u) )
		  {
		LABEL_31:
		    sub_1800D2AB0(v5, v4);
		  }
		  *(__m128i *)(v3 + 60) = v8;
		  *(_QWORD *)(v3 + 76) = 0LL;
		  *(_DWORD *)(v3 + 84) = 0;
		  v81 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  v9 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
		  if ( !v9 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurve::TextureCurve(v9, v7, 0.0, 0, &v81, 0LL);
		  v10 = (TextureCurveParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
		  v11 = v10;
		  if ( !v10
		    || (UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v10, v9, 0, 0LL),
		        this->fields.master = v11,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.master, v12, v13, v14, bounds),
		        v15 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 2LL),
		        v16 = _mm_load_si128((const __m128i *)&xmmword_18B959770),
		        (v17 = (Keyframe__Array *)v15) == 0LL) )
		  {
		LABEL_30:
		    sub_1800D8260(v5, v4);
		  }
		  if ( !*(_DWORD *)(v15 + 24) )
		    goto LABEL_31;
		  *(__m128i *)(v15 + 32) = v16;
		  *(_QWORD *)(v15 + 48) = 0LL;
		  v18 = _mm_load_si128((const __m128i *)&xmmword_18B959780);
		  *(_DWORD *)(v15 + 56) = 0;
		  if ( *(_DWORD *)(v15 + 24) <= 1u )
		    goto LABEL_31;
		  *(__m128i *)(v15 + 60) = v18;
		  *(_QWORD *)(v15 + 76) = 0LL;
		  *(_DWORD *)(v15 + 84) = 0;
		  v81 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  v19 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
		  if ( !v19 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurve::TextureCurve(v19, v17, 0.0, 0, &v81, 0LL);
		  v20 = (TextureCurveParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
		  v21 = v20;
		  if ( !v20 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v20, v19, 0, 0LL);
		  this->fields.red = v21;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.red, v22, v23, v24, boundsa);
		  v25 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 2LL);
		  v26 = _mm_load_si128((const __m128i *)&xmmword_18B959770);
		  v27 = (Keyframe__Array *)v25;
		  if ( !v25 )
		    goto LABEL_30;
		  if ( !*(_DWORD *)(v25 + 24) )
		    goto LABEL_31;
		  *(__m128i *)(v25 + 32) = v26;
		  *(_QWORD *)(v25 + 48) = 0LL;
		  v28 = _mm_load_si128((const __m128i *)&xmmword_18B959780);
		  *(_DWORD *)(v25 + 56) = 0;
		  if ( *(_DWORD *)(v25 + 24) <= 1u )
		    goto LABEL_31;
		  *(__m128i *)(v25 + 60) = v28;
		  *(_QWORD *)(v25 + 76) = 0LL;
		  *(_DWORD *)(v25 + 84) = 0;
		  v81 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  v29 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
		  if ( !v29 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurve::TextureCurve(v29, v27, 0.0, 0, &v81, 0LL);
		  v30 = (TextureCurveParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
		  v31 = v30;
		  if ( !v30 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v30, v29, 0, 0LL);
		  this->fields.green = v31;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.green, v32, v33, v34, boundsb);
		  v35 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 2LL);
		  v36 = _mm_load_si128((const __m128i *)&xmmword_18B959770);
		  v37 = (Keyframe__Array *)v35;
		  if ( !v35 )
		    goto LABEL_30;
		  if ( !*(_DWORD *)(v35 + 24) )
		    goto LABEL_31;
		  *(__m128i *)(v35 + 32) = v36;
		  *(_QWORD *)(v35 + 48) = 0LL;
		  v38 = _mm_load_si128((const __m128i *)&xmmword_18B959780);
		  *(_DWORD *)(v35 + 56) = 0;
		  if ( *(_DWORD *)(v35 + 24) <= 1u )
		    goto LABEL_31;
		  *(__m128i *)(v35 + 60) = v38;
		  *(_QWORD *)(v35 + 76) = 0LL;
		  *(_DWORD *)(v35 + 84) = 0;
		  v81 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  v39 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
		  if ( !v39 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurve::TextureCurve(v39, v37, 0.0, 0, &v81, 0LL);
		  v40 = (TextureCurveParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
		  v41 = v40;
		  if ( !v40 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v40, v39, 0, 0LL);
		  this->fields.blue = v41;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blue, v42, v43, v44, boundsc);
		  v45 = (Keyframe__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 0LL);
		  v81 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  v46 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
		  if ( !v46 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurve::TextureCurve(v46, v45, 0.5, 1, &v81, 0LL);
		  v47 = (TextureCurveParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
		  v48 = v47;
		  if ( !v47 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v47, v46, 0, 0LL);
		  this->fields.hueVsHue = v48;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.hueVsHue, v49, v50, v51, boundsd);
		  v52 = (Keyframe__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 0LL);
		  v81 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  v53 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
		  if ( !v53 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurve::TextureCurve(v53, v52, 0.5, 1, &v81, 0LL);
		  v54 = (TextureCurveParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
		  v55 = v54;
		  if ( !v54 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v54, v53, 0, 0LL);
		  this->fields.hueVsSat = v55;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.hueVsSat, v56, v57, v58, boundse);
		  v59 = (Keyframe__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 0LL);
		  v81 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  v60 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
		  if ( !v60 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurve::TextureCurve(v60, v59, 0.5, 0, &v81, 0LL);
		  v61 = (TextureCurveParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
		  v62 = v61;
		  if ( !v61 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v61, v60, 0, 0LL);
		  this->fields.satVsSat = v62;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.satVsSat, v63, v64, v65, boundsf);
		  v66 = (Keyframe__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 0LL);
		  v81 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  v67 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
		  if ( !v67 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurve::TextureCurve(v67, v66, 0.5, 0, &v81, 0LL);
		  v68 = (TextureCurveParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurveParameter);
		  v69 = v68;
		  if ( !v68 )
		    goto LABEL_30;
		  UnityEngine::Rendering::TextureCurveParameter::TextureCurveParameter(v68, v67, 0, 0LL);
		  this->fields.lumVsSat = v69;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.lumVsSat, v70, v71, v72, boundsg);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000189B68F1C-0x0000000189B68F68
		// Boolean IsActive()
		bool HG::Rendering::Runtime::ColorCurves::IsActive(ColorCurves *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2672, 0LL) )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2672, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
