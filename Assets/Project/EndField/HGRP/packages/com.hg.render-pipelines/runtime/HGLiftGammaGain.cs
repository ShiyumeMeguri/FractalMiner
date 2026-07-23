using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

[Serializable]
public struct HGLiftGammaGain : IEnvConfig // TypeDefIndex: 37358
{
	// Fields
	public Vector4 lift; // 0x00
	public Vector4 gamma; // 0x10
	public Vector4 gain; // 0x20
	public bool liftOverriding; // 0x30
	public bool gammaOverriding; // 0x31
	public bool gainOverriding; // 0x32
	public static HGLiftGammaGain defaultConfig; // 0x00

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
	public HGLiftGammaGain(bool active) : this() {
		lift = default;
		gamma = default;
		gain = default;
		liftOverriding = default;
		gammaOverriding = default;
		gainOverriding = default;
	} // 0x0000000184DA1130-0x0000000184DA1150
	// HGLiftGammaGain(Boolean)
	void HGLiftGammaGain::HGLiftGammaGain(HGLiftGammaGain *this, bool active, MethodInfo *method)
	{
	  Vector4 si128; // xmm0
	
	  si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959690);
	  this->lift = si128;
	  *(_WORD *)&this->liftOverriding = 0;
	  this->gamma = si128;
	  this->gainOverriding = 0;
	  this->gain = si128;
	}
	
	static HGLiftGammaGain() {
		defaultConfig = default;
	} // 0x0000000184D14B80-0x0000000184D14BE0
	// HGLiftGammaGain()
	void HGLiftGammaGain::cctor(MethodInfo *method)
	{
	  Vector4 gamma; // xmm1
	  HGLiftGammaGain__StaticFields *static_fields; // rcx
	  int v3; // eax
	  Vector4 gain; // xmm0
	  HGLiftGammaGain v5; // [rsp+20h] [rbp-48h] BYREF
	
	  memset(&v5, 0, sizeof(v5));
	  HGLiftGammaGain::HGLiftGammaGain(&v5, 0, 0LL);
	  gamma = v5.gamma;
	  static_fields = TypeInfo::HGLiftGammaGain->static_fields;
	  v3 = *(_DWORD *)&v5.liftOverriding;
	  static_fields->defaultConfig.lift = v5.lift;
	  gain = v5.gain;
	  static_fields->defaultConfig.gamma = gamma;
	  static_fields->defaultConfig.gain = gain;
	  *(_DWORD *)&static_fields->defaultConfig.liftOverriding = v3;
	}
	

	// Methods
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

