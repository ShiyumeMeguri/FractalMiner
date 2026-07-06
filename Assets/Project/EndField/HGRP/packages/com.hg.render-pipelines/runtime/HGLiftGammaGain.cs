using System;
using System.Runtime.InteropServices;
using HG.Rendering.Runtime;
using UnityEngine;

[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 60)]
public struct HGLiftGammaGain : IEnvConfig
{
	// (get) Token: 0x06000008 RID: 8 RVA: 0x000025D8 File Offset: 0x000007D8
	// (set) Token: 0x06000009 RID: 9 RVA: 0x000025D0 File Offset: 0x000007D0
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

	public HGLiftGammaGain(bool active)
	{
		// // HGLiftGammaGain(Boolean)
		// void HGLiftGammaGain::HGLiftGammaGain(HGLiftGammaGain *this, bool active, MethodInfo *method)
		// {
		//   Vector4 si128; // xmm0
		// 
		//   si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A3577F0);
		//   this.lift = si128;
		//   *(_WORD *)&this.liftOverriding = 0;
		//   this.gamma = si128;
		//   this.gainOverriding = 0;
		//   this.gain = si128;
		// }
		// 
	}

	private static ValueTuple<bool, Vector4> LerpParam(Vector4 srcParam, Vector4 dstParam, bool srcOverriding, bool dstOverriding, float t)
	{
		// // ValueTuple`2[Boolean,UnityEngine.Vector4] LerpParam(Vector4, Vector4, Boolean, Boolean, Single)
		// ValueTuple_2_Boolean_UnityEngine_Vector4_ *HGLiftGammaGain::LerpParam(
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
		//   if ( !byte_18D9192C6 )
		//   {
		//     sub_18003C530(&MethodInfo::System::ValueTuple<bool,UnityEngine::Vector4>::ValueTuple);
		//     byte_18D9192C6 = 1;
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

	public Vector4 lift;

	public Vector4 gamma;

	public Vector4 gain;

	public bool liftOverriding;

	public bool gammaOverriding;

	public bool gainOverriding;

	[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
	public static HGLiftGammaGain defaultConfig;
}
