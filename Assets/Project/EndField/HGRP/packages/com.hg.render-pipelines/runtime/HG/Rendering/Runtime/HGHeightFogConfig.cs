using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 200)]
	public struct HGHeightFogConfig : IEnvConfig
	{
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool flowNoiseEnabled
		{
			get
			{
				// // Boolean get_flowNoiseEnabled()
				// bool HG::Rendering::Runtime::HGHeightFogConfig::get_flowNoiseEnabled(HGHeightFogConfig *this, MethodInfo *method)
				// {
				//   return this.enable && this.enableFlowNoise;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000562 RID: 1378 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_fadeEndFromLight()
				// bool VLB::VolumetricLightBeam::get_fadeEndFromLight(VolumetricLightBeam *this, MethodInfo *method)
				// {
				//   return this.fields.fallOffEndFromLight;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_fadeEndFromLight(Boolean)
				// void VLB::VolumetricLightBeam::set_fadeEndFromLight(VolumetricLightBeam *this, bool value, MethodInfo *method)
				// {
				//   this.fields.fallOffEndFromLight = value;
				// }
				// 
			}
		}

		public HGHeightFogConfig(bool active)
		{
			// // HGHeightFogConfig(Boolean)
			// void HG::Rendering::Runtime::HGHeightFogConfig::HGHeightFogConfig(
			//         HGHeightFogConfig *this,
			//         bool active,
			//         MethodInfo *method)
			// {
			//   Vector4 v3; // xmm1
			//   __int64 v4; // rdx
			//   Quaternion v5; // xmm1
			//   __int64 v6; // rdx
			//   char v7; // r8
			//   Vector4 *one; // rax
			//   __int64 v9; // rdx
			//   Quaternion v10; // xmm1
			//   __int64 v11; // rdx
			//   int v12; // r8d
			//   Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.m_active = 0;
			//   this.heightFogStartHeight = 0.0;
			//   this.heightFogDensitySecond = 0.0;
			//   this.enable = 0;
			//   this.heightFogDensity = 0.02;
			//   *(_QWORD *)&this.heightFogFalloff = 1045220557LL;
			//   this.heightFogFalloffSecond = 0.2;
			//   v3 = *UnityEngine::Vector4::get_one(&v13, (MethodInfo *)this);
			//   *(_QWORD *)(v4 + 44) = 1065353216LL;
			//   *(_DWORD *)(v4 + 52) = 1028443341;
			//   *(Vector4 *)(v4 + 28) = v3;
			//   *(_DWORD *)(v4 + 56) = 1128792064;
			//   *(_DWORD *)(v4 + 60) = 1028443341;
			//   *(_DWORD *)(v4 + 64) = 1203982336;
			//   *(_DWORD *)(v4 + 68) = 1082130432;
			//   *(_DWORD *)(v4 + 72) = 1120403456;
			//   v5 = *UnityEngine::Quaternion::get_identity((Quaternion *)&v13, (MethodInfo *)v4);
			//   *(_BYTE *)(v6 + 92) = v7;
			//   *(_DWORD *)(v6 + 96) = 1045220557;
			//   *(Quaternion *)(v6 + 76) = v5;
			//   one = UnityEngine::Vector4::get_one(&v13, (MethodInfo *)v6);
			//   *(Vector4 *)(v9 + 100) = *one;
			//   v10 = *UnityEngine::Quaternion::get_identity((Quaternion *)&v13, (MethodInfo *)v9);
			//   *(_DWORD *)(v11 + 132) = 1065353216;
			//   *(_QWORD *)(v11 + 136) = 1114636288LL;
			//   *(Quaternion *)(v11 + 116) = v10;
			//   *(_DWORD *)(v11 + 144) = v12;
			//   *(_DWORD *)(v11 + 148) = 1065353216;
			//   *(_DWORD *)(v11 + 152) = 1065353216;
			//   *(_BYTE *)(v11 + 156) = v12;
			//   *(_DWORD *)(v11 + 160) = 1056964608;
			//   *(_DWORD *)(v11 + 164) = 1114636288;
			//   *(_QWORD *)(v11 + 168) = 1008981770LL;
			//   *(_DWORD *)(v11 + 176) = v12;
			//   *(_DWORD *)(v11 + 192) = v12;
			//   *(_QWORD *)(v11 + 180) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   *(_DWORD *)(v11 + 188) = 1065353216;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[Header("启用高度雾")]
		public bool enable;

		[Header("起始高度")]
		[UnclampedRange(-500f, 500f)]
		public float heightFogStartHeight;

		[RangeExponential(0f, 1f, 3f)]
		[Header("浓度")]
		public float heightFogDensity;

		[Header("衰减")]
		[UnclampedRange(0.001f, 2f)]
		public float heightFogFalloff;

		[Header("起始高度")]
		[Range(-500f, 500f)]
		public float heightFogStartHeightSecond;

		[Header("浓度")]
		[RangeExponential(0f, 1f, 3f)]
		public float heightFogDensitySecond;

		[UnclampedRange(0.001f, 2f)]
		[Header("衰减")]
		public float heightFogFalloffSecond;

		[Header("散射（雾的颜色）")]
		[ColorUsage(false, true)]
		public Color heightFogInscatter;

		[Range(0f, 1f)]
		[Header("最大不透明度")]
		public float heightFogMaxOpacity;

		[UnclampedRange(0f, 200f)]
		[Header("起始距离")]
		public float heightFogStartDistance;

		[UnclampedRangeExponential(0.001f, 1f, 3f)]
		[Header("起始区域过渡")]
		public float heightFogStartTransition;

		[UnclampedRangeExponential(0f, 200000f, 3f)]
		[Header("结束距离")]
		public float heightFogCutoffDistance;

		[Header("结束区域过渡")]
		[UnclampedRangeExponential(0.001f, 1f, 3f)]
		public float heightFogCutoffTransition;

		[Header("雾裁剪场景距离")]
		[UnclampedRangeExponential(0.1f, 2000f, 3f)]
		public float heightFogCullingFarClipPlane;

		[Header("方向散射衰减")]
		[Range(2f, 64f)]
		public float heightFogDirectionalInscatteringExponent;

		[Header("方向散射起始距离")]
		public float heightFogDirectionalInscatteringStartDistance;

		[Header("方向散射颜色")]
		[ColorUsage(false, true)]
		public Color heightFogDirectionalInscattering;

		[HideInInspector]
		public bool enableVolumetricFog;

		[HideInInspector]
		public float volumetricFogScatteringDistribution;

		[HideInInspector]
		public Color volumetricFogAlbedo;

		[HideInInspector]
		public Color volumetricFogEmissive;

		[HideInInspector]
		public float volumetricFogExtinctionScale;

		[HideInInspector]
		public float volumetricFogDistance;

		[HideInInspector]
		public float volumetricFogStartDistance;

		[HideInInspector]
		public float volumetricFogNearFadeInDistance;

		[HideInInspector]
		public float volumetricFogDirectLightingScatteringIntensity;

		[HideInInspector]
		public float volumetricFogSkyLightingScatteringIntensity;

		[Header("开启流动Noise")]
		public bool enableFlowNoise;

		[Range(0f, 1f)]
		[Header("流动Noise强度")]
		public float flowNoiseIntensity;

		[Range(10f, 1000f)]
		[Header("流动Noise淡出距离")]
		public float flowNoiseDistance;

		[Range(0f, 0.05f)]
		[Header("流动Noise密度")]
		public float flowNoiseTilling;

		[Range(0f, 360f)]
		[Header("流动Noise水平方向")]
		public float flowNoiseHorizontalDirAngle;

		[Range(-90f, 90f)]
		[Header("流动Noise垂直方向")]
		public float flowNoiseVerticalDirAngle;

		public Vector3 flowNoiseDir;

		[Range(0f, 2f)]
		[Header("流动Noise速度")]
		public float flowNoiseSpeed;

		[HideInInspector]
		[SerializeField]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGHeightFogConfig defaultConfig;
	}
}
