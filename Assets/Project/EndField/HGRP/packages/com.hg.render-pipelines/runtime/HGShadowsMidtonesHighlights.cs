using System;
using System.Runtime.InteropServices;
using HG.Rendering.Runtime;
using UnityEngine;

[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 92)]
public struct HGShadowsMidtonesHighlights : IEnvConfig
{
	// (get) Token: 0x0600000E RID: 14 RVA: 0x000025D8 File Offset: 0x000007D8
	// (set) Token: 0x0600000F RID: 15 RVA: 0x000025D0 File Offset: 0x000007D0
	public bool active
	{
		get
		{
			// // Boolean get_alwaysRebindOnRefresh()
			// bool UnityEngine::UIElements::VerticalVirtualizationController<System::Object>::get_alwaysRebindOnRefresh(
			//         VerticalVirtualizationController_1_System_Object_ *this,
			//         MethodInfo *method)
			// {
			//   return 1;
			// }
			// 
			return default(bool);
		}
		set
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}
	}

	public HGShadowsMidtonesHighlights(bool active)
	{
		// // HGShadowsMidtonesHighlights(Boolean)
		// void HGShadowsMidtonesHighlights::HGShadowsMidtonesHighlights(
		//         HGShadowsMidtonesHighlights *this,
		//         bool active,
		//         MethodInfo *method)
		// {
		//   Vector4 si128; // xmm0
		// 
		//   si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A3577F0);
		//   this.shadows = si128;
		//   this.shadowsStart = 0.0;
		//   this.midtones = si128;
		//   this.shadowsEnd = 0.30000001;
		//   this.highlights = si128;
		//   this.highlightsStart = 0.55000001;
		//   *(_QWORD *)&this.highlightsEnd = 1065353216LL;
		//   *(_WORD *)&this.shadowsEndOverriding = 0;
		//   this.highlightsEndOverriding = 0;
		// }
		// 
	}

	private static ValueTuple<bool, float> LerpParam(float srcParam, float dstParam, bool srcOverriding, bool dstOverriding, float t)
	{
		// // ValueTuple`2[Boolean,Single] LerpParam(Single, Single, Boolean, Boolean, Single)
		// ValueTuple_2_Boolean_Single_ HGShadowsMidtonesHighlights::LerpParam(
		//         float srcParam,
		//         float dstParam,
		//         bool srcOverriding,
		//         bool dstOverriding,
		//         float t,
		//         MethodInfo *method)
		// {
		//   Beyond::JobMathf *v6; // rcx
		//   double v9; // xmm0_8
		//   ValueTuple_2_Boolean_Single_ v11; // [rsp+20h] [rbp-38h]
		// 
		//   if ( !byte_18D9192C7 )
		//   {
		//     sub_18003C530(&MethodInfo::System::ValueTuple<bool,float>::ValueTuple);
		//     byte_18D9192C7 = 1;
		//   }
		//   *(_DWORD *)&v11.Item1 = 0;
		//   if ( srcOverriding )
		//   {
		//     if ( !dstOverriding )
		//     {
		//       v11.Item2 = srcParam;
		//       goto LABEL_10;
		//     }
		//     v11.Item1 = 1;
		//     v9 = Beyond::JobMathf::ClampedLerp(v6, dstParam, t);
		//     v11.Item2 = *(float *)&v9;
		//   }
		//   else
		//   {
		//     if ( dstOverriding )
		//     {
		//       v11.Item2 = dstParam;
		// LABEL_10:
		//       v11.Item1 = 1;
		//       return v11;
		//     }
		//     v11.Item2 = srcParam;
		//   }
		//   return v11;
		// }
		// 
		return null;
	}

	private static ValueTuple<bool, Vector4> LerpParam(Vector4 srcParam, Vector4 dstParam, bool srcOverriding, bool dstOverriding, float t)
	{
		// // ValueTuple`2[Boolean,UnityEngine.Vector4] LerpParam(Vector4, Vector4, Boolean, Boolean, Single)
		// ValueTuple_2_Boolean_UnityEngine_Vector4_ *HGShadowsMidtonesHighlights::LerpParam(
		//         ValueTuple_2_Boolean_UnityEngine_Vector4_ *__return_ptr retstr,
		//         Vector4 *srcParam,
		//         Vector4 *dstParam,
		//         bool srcOverriding,
		//         bool dstOverriding,
		//         float t,
		//         MethodInfo *method)
		// {
		//   ValueTuple_2_Boolean_UnityEngine_Vector4_ *result; // rax
		//   Vector4 v12; // xmm0
		//   Vector4 v13; // xmm1
		//   Vector4 *v14; // rax
		//   Vector4 v15; // [rsp+30h] [rbp-38h] BYREF
		//   Vector4 v16; // [rsp+40h] [rbp-28h] BYREF
		//   _BYTE v17[16]; // [rsp+50h] [rbp-18h] BYREF
		// 
		//   if ( !byte_18D9192C8 )
		//   {
		//     sub_18003C530(&MethodInfo::System::ValueTuple<bool,UnityEngine::Vector4>::ValueTuple);
		//     byte_18D9192C8 = 1;
		//   }
		//   if ( srcOverriding )
		//   {
		//     if ( dstOverriding )
		//     {
		//       v13 = *srcParam;
		//       v15 = *dstParam;
		//       v16 = v13;
		//       v14 = (Vector4 *)sub_18317A160(v17, &v16, &v15);
		//       *(_WORD *)(&retstr.Item1 + 1) = 0;
		//       *(&retstr.Item1 + 3) = 0;
		//       v12 = *v14;
		//     }
		//     else
		//     {
		//       *(_WORD *)(&retstr.Item1 + 1) = 0;
		//       *(&retstr.Item1 + 3) = 0;
		//       v12 = *srcParam;
		//     }
		//     result = retstr;
		//     goto LABEL_11;
		//   }
		//   result = retstr;
		//   *(_WORD *)(&retstr.Item1 + 1) = 0;
		//   *(&retstr.Item1 + 3) = 0;
		//   if ( dstOverriding )
		//   {
		//     v12 = *dstParam;
		// LABEL_11:
		//     retstr.Item1 = 1;
		//     goto LABEL_12;
		//   }
		//   v12 = *srcParam;
		//   retstr.Item1 = 0;
		// LABEL_12:
		//   retstr.Item2 = v12;
		//   return result;
		// }
		// 
		return null;
	}

	public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
	{
	}

	public Vector4 shadows;

	public Vector4 midtones;

	public Vector4 highlights;

	public float shadowsStart;

	public float shadowsEnd;

	public float highlightsStart;

	public float highlightsEnd;

	public bool shadowsOverriding;

	public bool midtonesOverriding;

	public bool highlightsOverriding;

	public bool shadowsStartOverriding;

	public bool shadowsEndOverriding;

	public bool highlightsStartOverriding;

	public bool highlightsEndOverriding;

	[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
	public static HGShadowsMidtonesHighlights defaultConfig;
}
