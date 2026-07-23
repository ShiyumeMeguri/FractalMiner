using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

[Serializable]
public struct HGShadowsMidtonesHighlights : IEnvConfig // TypeDefIndex: 37359
{
	// Fields
	public Vector4 shadows; // 0x00
	public Vector4 midtones; // 0x10
	public Vector4 highlights; // 0x20
	public float shadowsStart; // 0x30
	public float shadowsEnd; // 0x34
	public float highlightsStart; // 0x38
	public float highlightsEnd; // 0x3C
	public bool shadowsOverriding; // 0x40
	public bool midtonesOverriding; // 0x41
	public bool highlightsOverriding; // 0x42
	public bool shadowsStartOverriding; // 0x43
	public bool shadowsEndOverriding; // 0x44
	public bool highlightsStartOverriding; // 0x45
	public bool highlightsEndOverriding; // 0x46
	public static HGShadowsMidtonesHighlights defaultConfig; // 0x00

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
	public HGShadowsMidtonesHighlights(bool active) : this() {
		shadows = default;
		midtones = default;
		highlights = default;
		shadowsStart = default;
		shadowsEnd = default;
		highlightsStart = default;
		highlightsEnd = default;
		shadowsOverriding = default;
		midtonesOverriding = default;
		highlightsOverriding = default;
		shadowsStartOverriding = default;
		shadowsEndOverriding = default;
		highlightsStartOverriding = default;
		highlightsEndOverriding = default;
	} // 0x0000000184543B40-0x0000000184543B80
	// HGShadowsMidtonesHighlights(Boolean)
	void HGShadowsMidtonesHighlights::HGShadowsMidtonesHighlights(
	        HGShadowsMidtonesHighlights *this,
	        bool active,
	        MethodInfo *method)
	{
	  Vector4 si128; // xmm0
	
	  si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959690);
	  this->shadows = si128;
	  this->shadowsStart = 0.0;
	  this->midtones = si128;
	  this->shadowsEnd = 0.30000001;
	  this->highlights = si128;
	  this->highlightsStart = 0.55000001;
	  *(_QWORD *)&this->highlightsEnd = 1065353216LL;
	  *(_WORD *)&this->shadowsEndOverriding = 0;
	  this->highlightsEndOverriding = 0;
	}
	
	static HGShadowsMidtonesHighlights() {
		defaultConfig = default;
	} // 0x00000001845438B0-0x0000000184543930
	// HGShadowsMidtonesHighlights()
	void HGShadowsMidtonesHighlights::cctor(MethodInfo *method)
	{
	  Vector4 midtones; // xmm1
	  HGShadowsMidtonesHighlights__StaticFields *static_fields; // rcx
	  Vector4 highlights; // xmm0
	  __int128 v4; // xmm1
	  HGShadowsMidtonesHighlights v5; // [rsp+20h] [rbp-58h] BYREF
	
	  memset(&v5, 0, sizeof(v5));
	  HGShadowsMidtonesHighlights::HGShadowsMidtonesHighlights(&v5, 0, 0LL);
	  midtones = v5.midtones;
	  static_fields = TypeInfo::HGShadowsMidtonesHighlights->static_fields;
	  static_fields->defaultConfig.shadows = v5.shadows;
	  highlights = v5.highlights;
	  static_fields->defaultConfig.midtones = midtones;
	  v4 = *(_OWORD *)&v5.shadowsStart;
	  static_fields->defaultConfig.highlights = highlights;
	  *(_QWORD *)&highlights.x = *(_QWORD *)&v5.shadowsOverriding;
	  *(_OWORD *)&static_fields->defaultConfig.shadowsStart = v4;
	  *(_QWORD *)&static_fields->defaultConfig.shadowsOverriding = *(_QWORD *)&highlights.x;
	}
	

	// Methods
	private static ValueTuple<bool, float> LerpParam(float srcParam, float dstParam, bool srcOverriding, bool dstOverriding, float t) => default; // 0x0000000189B3078C-0x0000000189B307DC
	// ValueTuple`2[Boolean,Single] LerpParam(Single, Single, Boolean, Boolean, Single)
	ValueTuple_2_Boolean_Single_ HGShadowsMidtonesHighlights::LerpParam(
	        float srcParam,
	        float dstParam,
	        bool srcOverriding,
	        bool dstOverriding,
	        float t,
	        MethodInfo *method)
	{
	  Beyond::JobMathf *v6; // rcx
	  float v7; // xmm3_4
	  ValueTuple_2_Boolean_Single_ v9; // [rsp+20h] [rbp-18h]
	
	  *(_DWORD *)&v9.Item1 = 0;
	  if ( srcOverriding )
	  {
	    if ( !dstOverriding )
	    {
	      v9.Item2 = srcParam;
	      goto LABEL_8;
	    }
	    v9.Item1 = 1;
	    Beyond::JobMathf::ClampedLerp(v6, dstParam, t, v7);
	  }
	  else if ( dstOverriding )
	  {
	    v9.Item2 = dstParam;
	LABEL_8:
	    v9.Item1 = 1;
	    return v9;
	  }
	  v9.Item2 = srcParam;
	  return v9;
	}
	
	private static ValueTuple<bool, Vector4> LerpParam(Vector4 srcParam, Vector4 dstParam, bool srcOverriding, bool dstOverriding, float t) => default; // 0x0000000189B28700-0x0000000189B287A4
	// ValueTuple`2[Boolean,UnityEngine.Vector4] LerpParam(Vector4, Vector4, Boolean, Boolean, Single)
	ValueTuple_2_Boolean_UnityEngine_Vector4_ *HGShadowsMidtonesHighlights::LerpParam(
	        ValueTuple_2_Boolean_UnityEngine_Vector4_ *__return_ptr retstr,
	        Vector4 *srcParam,
	        Vector4 *dstParam,
	        bool srcOverriding,
	        bool dstOverriding,
	        float t,
	        MethodInfo *method)
	{
	  ValueTuple_2_Boolean_UnityEngine_Vector4_ *result; // rax
	  Vector4 v8; // xmm0
	  Vector4 v9; // xmm1
	  Vector4 *v10; // rax
	  __int64 v11; // r10
	  __int16 v12; // r11
	  Vector4 v13; // xmm0
	  MethodInfo *v14; // [rsp+20h] [rbp-48h]
	  Vector4 v15; // [rsp+30h] [rbp-38h] BYREF
	  Vector4 v16; // [rsp+40h] [rbp-28h] BYREF
	  Vector4 v17; // [rsp+50h] [rbp-18h] BYREF
	
	  if ( srcOverriding )
	  {
	    if ( dstOverriding )
	    {
	      v9 = *srcParam;
	      v15 = *dstParam;
	      v16 = v9;
	      v10 = UnityEngine::Vector4::Lerp(&v17, &v16, &v15, t, v14);
	      *(_WORD *)(v11 + 1) = v12;
	      *(_BYTE *)(v11 + 3) = v12;
	      *(_BYTE *)v11 = 1;
	      v13 = *v10;
	      result = (ValueTuple_2_Boolean_UnityEngine_Vector4_ *)v11;
	      *(Vector4 *)(v11 + 4) = v13;
	      return result;
	    }
	    *(_WORD *)(&retstr->Item1 + 1) = 0;
	    result = retstr;
	    *(&retstr->Item1 + 3) = 0;
	    v8 = *srcParam;
	    goto LABEL_8;
	  }
	  result = retstr;
	  *(_WORD *)(&retstr->Item1 + 1) = 0;
	  *(&retstr->Item1 + 3) = 0;
	  if ( dstOverriding )
	  {
	    v8 = *dstParam;
	LABEL_8:
	    retstr->Item1 = 1;
	    goto LABEL_9;
	  }
	  v8 = *srcParam;
	  retstr->Item1 = 0;
	LABEL_9:
	  retstr->Item2 = v8;
	  return result;
	}
	
	public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
		where T : struct, IEnvConfig {}
}

