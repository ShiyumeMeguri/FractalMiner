using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 264)]
	public struct HGVolumetricFogConfig : IEnvConfig
	{
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool flowNoiseEnabled
		{
			get
			{
				// // Boolean get_flowNoiseEnabled()
				// bool HG::Rendering::Runtime::HGVolumetricFogConfig::get_flowNoiseEnabled(
				//         HGVolumetricFogConfig *this,
				//         MethodInfo *method)
				// {
				//   if ( !byte_18D8EDC3E )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
				//     byte_18D8EDC3E = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig, method);
				//   if ( !byte_18D8EDC40 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
				//     byte_18D8EDC40 = 1;
				//   }
				//   if ( !this.enable )
				//     return 0;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig, method);
				//   if ( !byte_18D8EDC3F )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
				//     byte_18D8EDC3F = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer, method);
				//   return HG::Rendering::Runtime::HGVolumetricFogRenderer::get_supportVolumetricFog(0LL) && this.enableFlowNoise;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool flowVLNoiseEnabled
		{
			get
			{
				// // Boolean get_flowVLNoiseEnabled()
				// bool HG::Rendering::Runtime::HGVolumetricFogConfig::get_flowVLNoiseEnabled(
				//         HGVolumetricFogConfig *this,
				//         MethodInfo *method)
				// {
				//   bool result; // al
				// 
				//   if ( !byte_18D919D59 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
				//     byte_18D919D59 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
				//   result = HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogEnabled(this, 0LL);
				//   if ( result )
				//     return this.enableVLFlowNoise;
				//   return result;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool volumetricFogAbleToEnable
		{
			get
			{
				// // Boolean get_volumetricFogAbleToEnable()
				// bool HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogAbleToEnable(
				//         HGVolumetricFogConfig *this,
				//         MethodInfo *method)
				// {
				//   if ( !byte_18D8EDC3F )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
				//     byte_18D8EDC3F = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer, method);
				//   return HG::Rendering::Runtime::HGVolumetricFogRenderer::get_supportVolumetricFog(0LL);
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool volumetricFogEnabled
		{
			get
			{
				// // Boolean get_volumetricFogEnabled()
				// bool HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogEnabled(
				//         HGVolumetricFogConfig *this,
				//         MethodInfo *method)
				// {
				//   if ( !byte_18D8EDC40 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
				//     byte_18D8EDC40 = 1;
				//   }
				//   if ( !this.enable )
				//     return 0;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig, method);
				//   if ( !byte_18D8EDC3F )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
				//     byte_18D8EDC3F = 1;
				//   }
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer, method);
				//   return HG::Rendering::Runtime::HGVolumetricFogRenderer::get_supportVolumetricFog(0LL);
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_active()
				// bool HG::Rendering::Runtime::HGVolumetricFogConfig::get_active(HGVolumetricFogConfig *this, MethodInfo *method)
				// {
				//   return this.m_active;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_active(Boolean)
				// void HG::Rendering::Runtime::HGVolumetricFogConfig::set_active(
				//         HGVolumetricFogConfig *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.m_active = value;
				// }
				// 
			}
		}

		public HGVolumetricFogConfig(bool active)
		{
			// // HGVolumetricFogConfig(Boolean)
			// void HG::Rendering::Runtime::HGVolumetricFogConfig::HGVolumetricFogConfig(
			//         HGVolumetricFogConfig *this,
			//         bool active,
			//         MethodInfo *method)
			// {
			//   Vector4 v3; // xmm1
			//   __int64 v4; // rdx
			//   Quaternion v5; // xmm1
			//   __int64 v6; // rdx
			//   Vector4 *one; // rax
			//   __int64 v8; // rdx
			//   Quaternion v9; // xmm1
			//   __int64 v10; // rdx
			//   __int64 v11; // r8
			//   Vector4 v12; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.m_active = 0;
			//   this.heightFogStartHeight = 0.0;
			//   this.heightFogDensitySecond = 0.0;
			//   this.enable = 0;
			//   this.heightFogDensity = 0.02;
			//   *(_QWORD *)&this.heightFogFalloff = 1045220557LL;
			//   this.heightFogFalloffSecond = 0.2;
			//   v3 = *UnityEngine::Vector4::get_one(&v12, (MethodInfo *)this);
			//   *(_QWORD *)(v4 + 44) = 1065353216LL;
			//   *(_DWORD *)(v4 + 52) = 1028443341;
			//   *(Vector4 *)(v4 + 28) = v3;
			//   *(_DWORD *)(v4 + 56) = 1128792064;
			//   *(_DWORD *)(v4 + 60) = 1028443341;
			//   *(_DWORD *)(v4 + 64) = 1082130432;
			//   *(_DWORD *)(v4 + 68) = 1120403456;
			//   v5 = *UnityEngine::Quaternion::get_identity((Quaternion *)&v12, (MethodInfo *)v4);
			//   *(_DWORD *)(v6 + 88) = 1045220557;
			//   *(Quaternion *)(v6 + 72) = v5;
			//   one = UnityEngine::Vector4::get_one(&v12, (MethodInfo *)v6);
			//   *(Vector4 *)(v8 + 92) = *one;
			//   v9 = *UnityEngine::Quaternion::get_identity((Quaternion *)&v12, (MethodInfo *)v8);
			//   *(_DWORD *)(v10 + 124) = 1065353216;
			//   *(_QWORD *)(v10 + 128) = 1114636288LL;
			//   *(Quaternion *)(v10 + 108) = v9;
			//   *(_DWORD *)(v10 + 136) = v11;
			//   *(_DWORD *)(v10 + 140) = 1065353216;
			//   *(_DWORD *)(v10 + 144) = 1065353216;
			//   *(_BYTE *)(v10 + 148) = v11;
			//   *(_DWORD *)(v10 + 152) = 1056964608;
			//   *(_DWORD *)(v10 + 156) = 1114636288;
			//   *(_QWORD *)(v10 + 160) = 1008981770LL;
			//   *(_DWORD *)(v10 + 168) = v11;
			//   *(_DWORD *)(v10 + 184) = v11;
			//   *(_QWORD *)(v10 + 172) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   *(_DWORD *)(v10 + 180) = 1065353216;
			//   *(_WORD *)(v10 + 188) = v11;
			//   *(_DWORD *)(v10 + 192) = 1056964608;
			//   *(_DWORD *)(v10 + 196) = 1114636288;
			//   *(_QWORD *)(v10 + 200) = 1008981770LL;
			//   *(_DWORD *)(v10 + 208) = v11;
			//   *(_DWORD *)(v10 + 224) = v11;
			//   *(_QWORD *)(v10 + 212) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   *(_DWORD *)(v10 + 220) = 1065353216;
			//   *(_DWORD *)(v10 + 228) = 1056964608;
			//   *(_DWORD *)(v10 + 232) = 1114636288;
			//   *(_QWORD *)(v10 + 236) = 1008981770LL;
			//   *(_QWORD *)(v10 + 244) = v11;
			//   *(_BYTE *)(v10 + 252) = v11;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[Header("启用体积雾")]
		public bool enable;

		[UnclampedRange(-500f, 500f)]
		[Header("起始高度")]
		public float heightFogStartHeight;

		[Header("浓度")]
		[RangeExponential(0f, 1f, 3f)]
		public float heightFogDensity;

		[Header("衰减")]
		[UnclampedRange(0.001f, 2f)]
		public float heightFogFalloff;

		[Range(-500f, 500f)]
		[Header("起始高度")]
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

		[Header("最大不透明度")]
		[Range(0f, 1f)]
		public float heightFogMaxOpacity;

		[Header("起始距离")]
		[UnclampedRange(0f, 200f)]
		public float heightFogStartDistance;

		[Header("起始区域过渡")]
		[UnclampedRangeExponential(0.001f, 1f, 3f)]
		public float heightFogStartTransition;

		[UnclampedRangeExponential(0f, 200000f, 3f)]
		[Header("结束距离")]
		public float heightFogCutoffDistance;

		[UnclampedRangeExponential(0.001f, 1f, 3f)]
		[Header("结束区域过渡")]
		public float heightFogCutoffTransition;

		[Header("方向散射衰减")]
		[Range(2f, 64f)]
		public float heightFogDirectionalInscatteringExponent;

		[Header("方向散射起始距离")]
		public float heightFogDirectionalInscatteringStartDistance;

		[ColorUsage(false, true)]
		[Header("方向散射颜色")]
		public Color heightFogDirectionalInscattering;

		[Header("散射分布")]
		[Range(-0.9f, 0.9f)]
		public float volumetricFogScatteringDistribution;

		[Header("反射率")]
		[ColorUsage(false, true)]
		public Color volumetricFogAlbedo;

		[ColorUsage(false, true)]
		[Header("自发光")]
		public Color volumetricFogEmissive;

		[Range(0.1f, 10f)]
		[Header("消光比例")]
		public float volumetricFogExtinctionScale;

		[Header("视野距离")]
		[Range(10f, 200f)]
		public float volumetricFogDistance;

		[Header("开始距离")]
		[UnclampedRange(0f, 50f)]
		public float volumetricFogStartDistance;

		[Header("近淡入距离")]
		[UnclampedRange(0f, 10f)]
		public float volumetricFogNearFadeInDistance;

		[Range(0f, 10f)]
		[Header("直接光散射强度")]
		public float volumetricFogDirectLightingScatteringIntensity;

		[UnclampedRange(0f, 10f)]
		[Header("天光散射强度")]
		public float volumetricFogSkyLightingScatteringIntensity;

		[Header("开启流动Noise")]
		public bool enableFlowNoise;

		[Range(0f, 1f)]
		[Header("流动Noise强度")]
		public float flowNoiseIntensity;

		[Header("流动Noise淡出距离")]
		[Range(10f, 1000f)]
		public float flowNoiseDistance;

		[Header("流动Noise密度")]
		[Range(0f, 0.2f)]
		public float flowNoiseTilling;

		[Header("流动Noise水平方向")]
		[Range(0f, 360f)]
		public float flowNoiseHorizontalDirAngle;

		[Range(-90f, 90f)]
		[Header("流动Noise垂直方向")]
		public float flowNoiseVerticalDirAngle;

		public Vector3 flowNoiseDir;

		[Header("流动Noise速度")]
		[Range(0f, 2f)]
		public float flowNoiseSpeed;

		[Header("开启体积光流动Noise")]
		public bool enableVLFlowNoise;

		[Header("体积光流动Noise参数自定义")]
		public bool enableTwoParameter;

		[Range(0f, 50f)]
		[Header("流动Noise强度")]
		public float flowVLNoiseIntensity;

		[Range(10f, 1000f)]
		[Header("流动Noise淡出距离")]
		public float flowVLNoiseDistance;

		[Range(0f, 0.2f)]
		[Header("流动Noise密度")]
		public float flowVLNoiseTilling;

		[Range(0f, 360f)]
		[Header("流动Noise水平方向")]
		public float flowVLNoiseHorizontalDirAngle;

		[Range(-90f, 90f)]
		[Header("流动Noise垂直方向")]
		public float flowVLNoiseVerticalDirAngle;

		public Vector3 flowVLNoiseDir;

		[Range(0f, 2f)]
		[Header("流动Noise速度")]
		public float flowVLNoiseSpeed;

		[HideInInspector]
		[SerializeField]
		private float m_backupVLNoiseIntensity;

		[SerializeField]
		[HideInInspector]
		private float m_backupVLNoiseDistance;

		[SerializeField]
		[HideInInspector]
		private float m_backupVLNoiseTilling;

		[SerializeField]
		[HideInInspector]
		private float m_backupVLNoiseHorizontalDirAngle;

		[SerializeField]
		[HideInInspector]
		private float m_backupVLNoiseVerticalDirAngle;

		[SerializeField]
		[HideInInspector]
		private float m_backupVLNoiseSpeed;

		[SerializeField]
		[HideInInspector]
		private bool m_prevEnableTwoParameter;

		[SerializeField]
		[HideInInspector]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGVolumetricFogConfig defaultConfig;
	}
}
