using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 308)]
	public struct HGRainConfig : IEnvConfig
	{
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_active()
				// bool HG::Rendering::Runtime::HGRainConfig::get_active(HGRainConfig *this, MethodInfo *method)
				// {
				//   return this.m_active;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_active(Boolean)
				// void HG::Rendering::Runtime::HGRainConfig::set_active(HGRainConfig *this, bool value, MethodInfo *method)
				// {
				//   this.m_active = value;
				// }
				// 
			}
		}

		public HGRainConfig(bool active)
		{
			// // HGRainConfig(Boolean)
			// void HG::Rendering::Runtime::HGRainConfig::HGRainConfig(HGRainConfig *this, bool active, MethodInfo *method)
			// {
			//   ITilemap *v3; // r9
			//   TileAnimationData v4; // xmm1
			//   __int64 v5; // rdx
			//   Vector3Int *v6; // r8
			//   ITilemap *v7; // r9
			//   TileAnimationData v8; // xmm1
			//   __int64 v9; // rdx
			//   __int64 v10; // r8
			//   TileAnimationData v11; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.m_active = 0;
			//   *(_QWORD *)&this.intensity = 0LL;
			//   this.enable = 0;
			//   v4 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//           &v11,
			//           (TileBase *)this,
			//           0LL,
			//           v3,
			//           (MethodInfo *)v11.m_AnimatedSprites);
			//   *(_QWORD *)(v5 + 28) = v6;
			//   *(_QWORD *)(v5 + 36) = v6;
			//   *(TileAnimationData *)(v5 + 12) = v4;
			//   *(_QWORD *)(v5 + 44) = 1022739087LL;
			//   *(_DWORD *)(v5 + 56) = 1065353216;
			//   *(_QWORD *)(v5 + 60) = 1065353216LL;
			//   *(_QWORD *)(v5 + 68) = v6;
			//   *(_DWORD *)(v5 + 76) = 1065353216;
			//   *(_QWORD *)(v5 + 80) = 1065353216LL;
			//   *(_QWORD *)(v5 + 88) = v6;
			//   *(_QWORD *)(v5 + 96) = v6;
			//   *(_DWORD *)(v5 + 104) = (_DWORD)v6;
			//   *(_DWORD *)(v5 + 52) = (_DWORD)v6;
			//   v8 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//           &v11,
			//           (TileBase *)v5,
			//           v6,
			//           v7,
			//           (MethodInfo *)v11.m_AnimatedSprites);
			//   *(_QWORD *)(v9 + 124) = v10;
			//   *(TileAnimationData *)(v9 + 108) = v8;
			//   *(_QWORD *)(v9 + 132) = v10;
			//   *(_QWORD *)(v9 + 140) = v10;
			//   *(_QWORD *)(v9 + 148) = v10;
			//   *(_QWORD *)(v9 + 156) = v10;
			//   *(_QWORD *)(v9 + 164) = v10;
			//   *(_QWORD *)(v9 + 172) = v10;
			//   *(_QWORD *)(v9 + 180) = v10;
			//   *(_DWORD *)(v9 + 188) = v10;
			//   *(_WORD *)(v9 + 192) = v10;
			//   *(_QWORD *)(v9 + 196) = v10;
			//   *(_QWORD *)(v9 + 204) = v10;
			//   *(_QWORD *)(v9 + 212) = 1065353216LL;
			//   *(_QWORD *)(v9 + 220) = v10;
			//   *(_DWORD *)(v9 + 228) = v10;
			//   *(_QWORD *)(v9 + 232) = 1065353216LL;
			//   *(_QWORD *)(v9 + 240) = v10;
			//   *(_DWORD *)(v9 + 248) = v10;
			//   *(_QWORD *)(v9 + 264) = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
			//   *(_DWORD *)(v9 + 272) = 0;
			//   *(_QWORD *)(v9 + 276) = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
			//   *(_DWORD *)(v9 + 284) = 0;
			//   *(_DWORD *)(v9 + 252) = 1065353216;
			//   *(_QWORD *)(v9 + 288) = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
			//   *(_DWORD *)(v9 + 296) = 0;
			//   *(_QWORD *)(v9 + 256) = 1065353216LL;
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		[FormerlySerializedAs("enableEdit")]
		[Header("启用下雨")]
		public bool enable;

		[Tooltip("降雨强度。影响雨滴的密度。范围 0 - 100")]
		[FormerlySerializedAs("intensityEdit")]
		[Header("降雨参数")]
		[Range(0f, 100f)]
		public float intensity;

		[Tooltip("降雨速度。即雨滴落下的速度。范围 0 - 20")]
		[Range(0f, 20f)]
		public float speed;

		public Color color;

		[Tooltip("雨滴长度。范围 0 - 3")]
		[Range(0f, 3f)]
		public float streakLength;

		[Range(0f, 360f)]
		[Tooltip("水平面内的雨向，0 为正北（z 轴正方向），90 为正东（x 轴正方向）")]
		[Header("近处雨设置")]
		public float horizontalRainAngle;

		[Range(0f, 1f)]
		public float horizontalRainLevel;

		[Range(0f, 1f)]
		public float sceneEffectRainJitterLevel;

		[Range(0f, 0.2f)]
		public float sceneEffectRainWidthScale;

		[Range(0f, 1f)]
		public float sceneEffectRainLightingPercent;

		[Range(0f, 80f)]
		public float rainCenterBias;

		[Range(0f, 5f)]
		[Header("中景雨设置")]
		public float middleRainLayerSpeedDiffMultiplier;

		[Tooltip("中景雨透明度，直接乘在雨滴颜色的Alpha值上。是相对透明度")]
		[Range(0f, 3f)]
		public float middleRainAlphaMultiplier;

		[Tooltip("水平面内的雨向，0 为正北（z 轴正方向），90 为正东（x 轴正方向）")]
		[Range(0f, 360f)]
		public float middleHorizontalRainAngle;

		[Range(0f, 1f)]
		public float middleHorizontalRainLevel;

		[Range(0f, 1f)]
		public float middleRainLightingPercent;

		[Range(0f, 5f)]
		[Header("远处雨锥设置")]
		[FormerlySerializedAs("rainLayerSpeedDiffMultiplier")]
		public float farRainLayerSpeedDiffMultiplier;

		[Tooltip("远处雨透明度，直接乘在雨滴颜色的Alpha值上。是相对透明度")]
		[Range(0f, 3f)]
		public float farRainAlphaMultiplier;

		[Tooltip("水平面内的雨向，0 为正北（z 轴正方向），90 为正东（x 轴正方向）")]
		[Range(0f, 360f)]
		public float farRainHorizontalRainAngle;

		[Range(0f, 1f)]
		public float farRainHorizontalRainLevel;

		[Header("雨雾波设置")]
		[Range(0f, 5f)]
		public float rainWaveVerticalSpeed;

		[Tooltip("雨雾波横向流动")]
		[Range(-3f, 3f)]
		public float rainWaveHorizontalSpeed;

		[Tooltip("雨雾波透明度，与雨本身透明度无关")]
		[Range(0f, 3f)]
		public float rainWaveAlpha;

		[Range(0f, 1f)]
		public float rainWaveBottomFadeFactor;

		[Header("镜头雨滴设置")]
		public Color screenDropColor;

		[Range(0f, 30f)]
		[Tooltip("代表降雨强度为100时，出现的雨滴数目")]
		public int screenDropMaxCountLim;

		public Vector2 screenDropMinMaxLifeTime;

		public Vector2 screenDropMinMaxSize;

		[Tooltip("距离屏幕中心消失的范围，低于最低值会完全消失，高于最高值完全出现，在这之间会渐变消失")]
		public Vector2 screenDropCentroidFadeParam;

		[Tooltip("每个屏幕雨滴有多少概率可以流动")]
		[Range(0f, 1f)]
		public float screenDropFlowPercent;

		public Vector2 screenDropMinMaxSpeed;

		[Range(0f, 5f)]
		public float screenDropJitterSpeedScale;

		[Header("地面雨花设置")]
		[Range(0f, 1000f)]
		public int rainSplashCount;

		[Range(0f, 10f)]
		public float rainSplashSpeed;

		[Range(0f, 3f)]
		[Tooltip("雨花透明度，与雨本身透明度无关")]
		public float rainSplashAlpha;

		public Vector2 rainSplashMinMaxSize;

		[Range(0f, 1f)]
		public float rainSplashLightingPercent;

		[Header("地面潮湿设置")]
		public bool enableWetness;

		public bool enableWetnessAffectSSR;

		[Range(0f, 1f)]
		[Tooltip("地面潮湿的程度，全局控制，具体每个材质请单独设置吸收度")]
		public float wetness;

		[Tooltip("地面潮湿基准吸收度。吸收度越高，越潮湿吸水越多颜色越深，反之越潮湿吸水越少表面越光滑")]
		[Range(0f, 1f)]
		public float wetnessBasePorosity;

		[Tooltip("越粗糙的物件受因子影响越小")]
		[Range(-1f, 1f)]
		public float wetnessPorosityFactor;

		[Tooltip("地面潮湿基准吸收度。吸收度越高，越潮湿吸水越多颜色越深，反之越潮湿吸水越少表面越光滑")]
		[Range(0f, 1f)]
		public float baseWetnessLevel;

		[Range(0f, 1f)]
		public float verticalWetnessScalar;

		[Range(0f, 30f)]
		public float verticalFlowSpeed;

		[Range(0f, 3f)]
		public float verticalFlowNormalStrength;

		[Range(0f, 1f)]
		public float verticalFlowSurfaceThreshold;

		[Range(-2f, 2f)]
		public float verticalFlowPorosityBias;

		[Range(1f, 5f)]
		public float rippleFrequency;

		[Range(0f, 1f)]
		public float rippleNormalStrength;

		[Range(0f, 5f)]
		public float rippleWaveSpeed;

		[Range(0f, 1f)]
		public float rippleWaveNormalStrength;

		[Tooltip("低于该粗糙度的水平表面会产生涟漪")]
		[Range(0f, 1f)]
		public float rippleRoughnessMaskThreshold;

		[Header("远景潮湿度")]
		[Tooltip("该范围比例外的潮湿度将被固定值覆盖")]
		[Range(1f, 20f)]
		public float farSceneWetnessDistanceFactor;

		[Tooltip("该范围比例外的潮湿度将被固定值覆盖")]
		[Range(0f, 1f)]
		public float farSceneWetnessValue;

		public float wetnessProceduralForWater;

		[HideInInspector]
		public Vector3 rainDirection;

		[HideInInspector]
		public Vector3 middleRainDirection;

		[HideInInspector]
		public Vector3 farRainDirection;

		[HideInInspector]
		[SerializeField]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGRainConfig defaultConfig;
	}
}
