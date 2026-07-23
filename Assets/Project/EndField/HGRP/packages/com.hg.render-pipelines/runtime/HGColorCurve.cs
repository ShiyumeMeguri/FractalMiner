using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

[Serializable]
public struct HGColorCurve : IEnvConfig // TypeDefIndex: 37357
{
	// Fields
	public TextureCurve master; // 0x00
	public TextureCurve red; // 0x08
	public TextureCurve green; // 0x10
	public TextureCurve blue; // 0x18
	public TextureCurve hueVsHue; // 0x20
	public TextureCurve hueVsSat; // 0x28
	public TextureCurve satVsSat; // 0x30
	public TextureCurve lumVsSat; // 0x38
	public bool masterOverriding; // 0x40
	public bool redOverriding; // 0x41
	public bool greenOverriding; // 0x42
	public bool blueOverriding; // 0x43
	public bool hueVsHueOverriding; // 0x44
	public bool hueVsSatOverriding; // 0x45
	public bool satVsSatOverriding; // 0x46
	public bool lumVsSatOverriding; // 0x47
	public static HGColorCurve defaultConfig; // 0x00

	// Properties
	public bool active { get => default; set {} } // 0x0000000182FFF600-0x0000000182FFF610 0x00000001841E1670-0x00000001841E1680
	// Boolean get_alwaysRebindOnRefresh()
	bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
	        VerticalVirtualizationController_1_System_Object_ *this,
	        MethodInfo *method)
	{
	  return 1;
	}
	

	// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
	void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
	        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
	        HGWindConfig *cSrc,
	        HGWindConfig *cDst,
	        float t,
	        MethodInfo *method)
	{
	  ;
	}
	

	// Constructors
	public HGColorCurve(bool active) : this() {
		master = default;
		red = default;
		green = default;
		blue = default;
		hueVsHue = default;
		hueVsSat = default;
		satVsSat = default;
		lumVsSat = default;
		masterOverriding = default;
		redOverriding = default;
		greenOverriding = default;
		blueOverriding = default;
		hueVsHueOverriding = default;
		hueVsSatOverriding = default;
		satVsSatOverriding = default;
		lumVsSatOverriding = default;
	} // 0x0000000184543B80-0x0000000184544070
	// HGColorCurve(Boolean)
	void HGColorCurve::HGColorCurve(HGColorCurve *this, bool active, MethodInfo *method)
	{
	  __int64 v4; // rax
	  __int64 v5; // rdx
	  __int64 v6; // rcx
	  __m128i si128; // xmm0
	  Keyframe__Array *v8; // rdi
	  __m128i v9; // xmm0
	  TextureCurve *v10; // rsi
	  Type *v11; // rdx
	  PropertyInfo_1 *v12; // r8
	  Int32__Array **v13; // r9
	  __int64 v14; // rax
	  __m128i v15; // xmm0
	  Keyframe__Array *v16; // rdi
	  __m128i v17; // xmm0
	  TextureCurve *v18; // rsi
	  Type *v19; // rdx
	  PropertyInfo_1 *v20; // r8
	  Int32__Array **v21; // r9
	  __int64 v22; // rax
	  __m128i v23; // xmm0
	  Keyframe__Array *v24; // rdi
	  __m128i v25; // xmm0
	  TextureCurve *v26; // rsi
	  Type *v27; // rdx
	  PropertyInfo_1 *v28; // r8
	  Int32__Array **v29; // r9
	  __int64 v30; // rax
	  __m128i v31; // xmm0
	  Keyframe__Array *v32; // rdi
	  __m128i v33; // xmm0
	  TextureCurve *v34; // rsi
	  Type *v35; // rdx
	  PropertyInfo_1 *v36; // r8
	  Int32__Array **v37; // r9
	  Keyframe__Array *v38; // rsi
	  TextureCurve *v39; // rdi
	  Type *v40; // rdx
	  PropertyInfo_1 *v41; // r8
	  Int32__Array **v42; // r9
	  Keyframe__Array *v43; // rsi
	  TextureCurve *v44; // rdi
	  Type *v45; // rdx
	  PropertyInfo_1 *v46; // r8
	  Int32__Array **v47; // r9
	  Keyframe__Array *v48; // rsi
	  TextureCurve *v49; // rdi
	  Type *v50; // rdx
	  PropertyInfo_1 *v51; // r8
	  Int32__Array **v52; // r9
	  Keyframe__Array *v53; // rsi
	  TextureCurve *v54; // rdi
	  Type *v55; // rdx
	  PropertyInfo_1 *v56; // r8
	  Int32__Array **v57; // r9
	  MethodInfo *bounds; // [rsp+20h] [rbp-60h]
	  MethodInfo *boundsa; // [rsp+20h] [rbp-60h]
	  MethodInfo *boundsb; // [rsp+20h] [rbp-60h]
	  MethodInfo *boundsc; // [rsp+20h] [rbp-60h]
	  MethodInfo *boundsd; // [rsp+20h] [rbp-60h]
	  MethodInfo *boundse; // [rsp+20h] [rbp-60h]
	  MethodInfo *boundsf; // [rsp+20h] [rbp-60h]
	  MethodInfo *boundsg; // [rsp+20h] [rbp-60h]
	  Vector2 v66; // [rsp+B8h] [rbp+38h] BYREF
	
	  v4 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 2LL);
	  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959770);
	  v8 = (Keyframe__Array *)v4;
	  if ( !v4 )
	LABEL_2:
	    sub_1800D8260(v6, v5);
	  if ( !*(_DWORD *)(v4 + 24) )
	    goto LABEL_23;
	  *(__m128i *)(v4 + 32) = si128;
	  *(_QWORD *)(v4 + 48) = 0LL;
	  v9 = _mm_load_si128((const __m128i *)&xmmword_18B959780);
	  *(_DWORD *)(v4 + 56) = 0;
	  if ( *(_DWORD *)(v4 + 24) <= 1u )
	    goto LABEL_23;
	  *(__m128i *)(v4 + 60) = v9;
	  *(_QWORD *)(v4 + 76) = 0LL;
	  *(_DWORD *)(v4 + 84) = 0;
	  v66 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
	  v10 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
	  if ( !v10 )
	    goto LABEL_2;
	  UnityEngine::Rendering::TextureCurve::TextureCurve(v10, v8, 0.0, 0, &v66, 0LL);
	  this->master = v10;
	  sub_18002D1B0((SingleFieldAccessor *)this, v11, v12, v13, bounds);
	  v14 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 2LL);
	  v15 = _mm_load_si128((const __m128i *)&xmmword_18B959770);
	  v16 = (Keyframe__Array *)v14;
	  if ( !v14 )
	    goto LABEL_2;
	  if ( !*(_DWORD *)(v14 + 24) )
	    goto LABEL_23;
	  *(__m128i *)(v14 + 32) = v15;
	  *(_QWORD *)(v14 + 48) = 0LL;
	  v17 = _mm_load_si128((const __m128i *)&xmmword_18B959780);
	  *(_DWORD *)(v14 + 56) = 0;
	  if ( *(_DWORD *)(v14 + 24) <= 1u )
	    goto LABEL_23;
	  *(__m128i *)(v14 + 60) = v17;
	  *(_QWORD *)(v14 + 76) = 0LL;
	  *(_DWORD *)(v14 + 84) = 0;
	  v66 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
	  v18 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
	  if ( !v18 )
	    goto LABEL_2;
	  UnityEngine::Rendering::TextureCurve::TextureCurve(v18, v16, 0.0, 0, &v66, 0LL);
	  this->red = v18;
	  sub_18002D1B0((SingleFieldAccessor *)&this->red, v19, v20, v21, boundsa);
	  v22 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 2LL);
	  v23 = _mm_load_si128((const __m128i *)&xmmword_18B959770);
	  v24 = (Keyframe__Array *)v22;
	  if ( !v22 )
	    goto LABEL_2;
	  if ( !*(_DWORD *)(v22 + 24) )
	    goto LABEL_23;
	  *(__m128i *)(v22 + 32) = v23;
	  *(_QWORD *)(v22 + 48) = 0LL;
	  v25 = _mm_load_si128((const __m128i *)&xmmword_18B959780);
	  *(_DWORD *)(v22 + 56) = 0;
	  if ( *(_DWORD *)(v22 + 24) <= 1u )
	    goto LABEL_23;
	  *(__m128i *)(v22 + 60) = v25;
	  *(_QWORD *)(v22 + 76) = 0LL;
	  *(_DWORD *)(v22 + 84) = 0;
	  v66 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
	  v26 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
	  if ( !v26 )
	    goto LABEL_2;
	  UnityEngine::Rendering::TextureCurve::TextureCurve(v26, v24, 0.0, 0, &v66, 0LL);
	  this->green = v26;
	  sub_18002D1B0((SingleFieldAccessor *)&this->green, v27, v28, v29, boundsb);
	  v30 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 2LL);
	  v31 = _mm_load_si128((const __m128i *)&xmmword_18B959770);
	  v32 = (Keyframe__Array *)v30;
	  if ( !v30 )
	    goto LABEL_2;
	  if ( !*(_DWORD *)(v30 + 24)
	    || (*(__m128i *)(v30 + 32) = v31,
	        *(_QWORD *)(v30 + 48) = 0LL,
	        v33 = _mm_load_si128((const __m128i *)&xmmword_18B959780),
	        *(_DWORD *)(v30 + 56) = 0,
	        *(_DWORD *)(v30 + 24) <= 1u) )
	  {
	LABEL_23:
	    sub_1800D2AB0(v6, v5);
	  }
	  *(__m128i *)(v30 + 60) = v33;
	  *(_QWORD *)(v30 + 76) = 0LL;
	  *(_DWORD *)(v30 + 84) = 0;
	  v66 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
	  v34 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
	  if ( !v34 )
	    goto LABEL_2;
	  UnityEngine::Rendering::TextureCurve::TextureCurve(v34, v32, 0.0, 0, &v66, 0LL);
	  this->blue = v34;
	  sub_18002D1B0((SingleFieldAccessor *)&this->blue, v35, v36, v37, boundsc);
	  v38 = (Keyframe__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 0LL);
	  v66 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
	  v39 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
	  if ( !v39 )
	    goto LABEL_2;
	  UnityEngine::Rendering::TextureCurve::TextureCurve(v39, v38, 0.5, 1, &v66, 0LL);
	  this->hueVsHue = v39;
	  sub_18002D1B0((SingleFieldAccessor *)&this->hueVsHue, v40, v41, v42, boundsd);
	  v43 = (Keyframe__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 0LL);
	  v66 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
	  v44 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
	  if ( !v44 )
	    goto LABEL_2;
	  UnityEngine::Rendering::TextureCurve::TextureCurve(v44, v43, 0.5, 1, &v66, 0LL);
	  this->hueVsSat = v44;
	  sub_18002D1B0((SingleFieldAccessor *)&this->hueVsSat, v45, v46, v47, boundse);
	  v48 = (Keyframe__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 0LL);
	  v66 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
	  v49 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
	  if ( !v49 )
	    goto LABEL_2;
	  UnityEngine::Rendering::TextureCurve::TextureCurve(v49, v48, 0.5, 0, &v66, 0LL);
	  this->satVsSat = v49;
	  sub_18002D1B0((SingleFieldAccessor *)&this->satVsSat, v50, v51, v52, boundsf);
	  v53 = (Keyframe__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Keyframe, 0LL);
	  v66 = (Vector2)_mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
	  v54 = (TextureCurve *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::TextureCurve);
	  if ( !v54 )
	    goto LABEL_2;
	  UnityEngine::Rendering::TextureCurve::TextureCurve(v54, v53, 0.5, 0, &v66, 0LL);
	  this->lumVsSat = v54;
	  sub_18002D1B0((SingleFieldAccessor *)&this->lumVsSat, v55, v56, v57, boundsg);
	  *(_QWORD *)&this->masterOverriding = 0LL;
	}
	
	static HGColorCurve() {
		defaultConfig = default;
	} // 0x0000000184543470-0x0000000184543500
	// HGColorCurve()
	void HGColorCurve::cctor(MethodInfo *method)
	{
	  __int128 v1; // xmm2
	  __int128 v2; // xmm3
	  HGColorCurve__StaticFields *static_fields; // rcx
	  __int128 v4; // xmm4
	  __int64 v5; // xmm0_8
	  Type *v6; // rdx
	  PropertyInfo_1 *v7; // r8
	  Int32__Array **v8; // r9
	  HGColorCurve v9; // [rsp+20h] [rbp-58h] BYREF
	
	  memset(&v9, 0, sizeof(v9));
	  HGColorCurve::HGColorCurve(&v9, 0, 0LL);
	  v1 = *(_OWORD *)&v9.green;
	  v2 = *(_OWORD *)&v9.hueVsHue;
	  static_fields = TypeInfo::HGColorCurve->static_fields;
	  v4 = *(_OWORD *)&v9.satVsSat;
	  v5 = *(_QWORD *)&v9.masterOverriding;
	  *(_OWORD *)&static_fields->defaultConfig.master = *(_OWORD *)&v9.master;
	  *(_OWORD *)&static_fields->defaultConfig.green = v1;
	  *(_OWORD *)&static_fields->defaultConfig.hueVsHue = v2;
	  *(_OWORD *)&static_fields->defaultConfig.satVsSat = v4;
	  *(_QWORD *)&static_fields->defaultConfig.masterOverriding = v5;
	  sub_18002D1B0((SingleFieldAccessor *)TypeInfo::HGColorCurve->static_fields, v6, v7, v8, (MethodInfo *)v9.master);
	}
	

	// Methods
	public void Lerp<T>(ref ref T src, ref ref T dst, float t)
		where T : struct, IEnvConfig {}
}

