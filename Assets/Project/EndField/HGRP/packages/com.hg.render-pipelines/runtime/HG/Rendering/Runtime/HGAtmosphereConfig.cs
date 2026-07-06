using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 152)]
	public struct HGAtmosphereConfig : IEnvConfig
	{
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_constrainedRotationYAxis()
				// bool UnityEngine::Animations::Rigging::MultiParentConstraintData::get_constrainedRotationYAxis(
				//         MultiParentConstraintData *this,
				//         MethodInfo *method)
				// {
				//   return this.m_ConstrainedRotationAxes.y;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_constrainedRotationYAxis(Boolean)
				// void UnityEngine::Animations::Rigging::MultiParentConstraintData::set_constrainedRotationYAxis(
				//         MultiParentConstraintData *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.m_ConstrainedRotationAxes.y = value;
				// }
				// 
			}
		}

		public HGAtmosphereConfig(bool active)
		{
			// // HGAtmosphereConfig(Boolean)
			// void HG::Rendering::Runtime::HGAtmosphereConfig::HGAtmosphereConfig(
			//         HGAtmosphereConfig *this,
			//         bool active,
			//         MethodInfo *method)
			// {
			//   Quaternion *identity; // rax
			//   __int64 v4; // rdx
			//   Vector4 *one; // rax
			//   __m128i si128; // xmm0
			//   Vector4 v7; // xmm1
			//   __int64 v8; // rdx
			//   Vector4 *v9; // rax
			//   __m128i v10; // xmm0
			//   Vector4 v11; // xmm1
			//   __int64 v12; // rdx
			//   __m128i v13; // xmm0
			//   Vector4 v14; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.m_active = 0;
			//   this.groundRadius = 6360.0;
			//   identity = UnityEngine::Quaternion::get_identity((Quaternion *)&v14, (MethodInfo *)this);
			//   *(Quaternion *)(v4 + 4) = *identity;
			//   one = UnityEngine::Vector4::get_one(&v14, (MethodInfo *)v4);
			//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A357CB0);
			//   v7 = *one;
			//   *(_DWORD *)(v8 + 36) = 1114636288;
			//   *(_DWORD *)(v8 + 40) = 1065353216;
			//   *(Vector4 *)(v8 + 20) = v7;
			//   *(_DWORD *)(v8 + 44) = 1023906782;
			//   *(__m128i *)(v8 + 48) = si128;
			//   *(_DWORD *)(v8 + 64) = 1090519040;
			//   *(_DWORD *)(v8 + 68) = 998437089;
			//   v9 = UnityEngine::Vector4::get_one(&v14, (MethodInfo *)v8);
			//   v10 = _mm_load_si128((const __m128i *)&xmmword_18A357460);
			//   v11 = *v9;
			//   *(_DWORD *)(v12 + 88) = 971557036;
			//   *(__m128i *)(v12 + 92) = v10;
			//   *(_DWORD *)(v12 + 108) = 1061997773;
			//   v13 = _mm_load_si128((const __m128i *)&xmmword_18A357CC0);
			//   *(Vector4 *)(v12 + 72) = v11;
			//   *(_DWORD *)(v12 + 112) = 1067030938;
			//   *(__m128i *)(v12 + 120) = v13;
			//   *(_DWORD *)(v12 + 116) = 989236195;
			//   *(_DWORD *)(v12 + 136) = 1103626240;
			//   *(_DWORD *)(v12 + 140) = 1065353216;
			//   *(_DWORD *)(v12 + 144) = 1097859072;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[RangeExponential(1f, 7000f, 5f)]
		[Header("行星参数")]
		public float groundRadius;

		public Color groundAlbedo;

		[Header("大气参数")]
		public Color outerSunIrradianceColor;

		[RangeExponential(1f, 200f, 2f)]
		public float atmosphereHeight;

		[Range(0f, 1f)]
		public float multiScatteringFactor;

		[Header("瑞利散射")]
		[RangeExponential(0f, 2f, 4f)]
		public float rayleighScatteringScale;

		public Color rayleighScattering;

		[RangeExponential(0.01f, 20f, 5f)]
		public float rayleighExponentialDistribution;

		[RangeExponential(0f, 5f, 4f)]
		[Header("米氏散射")]
		public float mieScatteringScale;

		public Color mieScattering;

		[RangeExponential(0f, 2f, 4f)]
		public float mieAbsorptionScale;

		public Color mieAbsorption;

		[Range(0f, 0.999f)]
		public float mieAnisotropy;

		[RangeExponential(0.01f, 10f, 5f)]
		public float mieExponentialDistribution;

		[Header("臭氧层")]
		[RangeExponential(0f, 0.2f, 3f)]
		public float ozoneAbsorptionScale;

		public Color ozoneAbsorption;

		[Range(0f, 60f)]
		public float tentTipAltitude;

		[RangeExponential(0f, 1f, 4f)]
		public float tentTipValue;

		[Range(0.01f, 20f)]
		public float tentWidth;

		[SerializeField]
		[HideInInspector]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGAtmosphereConfig defaultConfig;
	}
}
