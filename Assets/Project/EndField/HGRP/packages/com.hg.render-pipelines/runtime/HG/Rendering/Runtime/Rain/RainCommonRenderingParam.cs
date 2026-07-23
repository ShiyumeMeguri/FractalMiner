using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Rain
{
	internal class RainCommonRenderingParam // TypeDefIndex: 38844
	{
		// Fields
		public bool enable; // 0x10
		public float rawIntensity; // 0x14
		public float intensity; // 0x18
		public float speed; // 0x1C
		public UnityEngine.Color color; // 0x20
		public float streakLength; // 0x30
		public float rainCenterBias; // 0x34
		public bool enableMiddleRain; // 0x38
		public float middleRainLayerSpeedDiffMultiplier; // 0x3C
		public float farRainLayerSpeedDiffMultiplier; // 0x40
		public float middleRainAlphaMultiplier; // 0x44
		public float farRainAlphaMultiplier; // 0x48
		public float middleRainLightingPercent; // 0x4C
		public bool enableRainWave; // 0x50
		public float rainWaveAlpha; // 0x54
		public float rainWaveVerticalSpeed; // 0x58
		public float rainWaveHorizontalSpeed; // 0x5C
		public float rainWaveBottomFadeFactor; // 0x60
		public Vector3 rainDirection; // 0x64
		public Vector3 middleRainDirection; // 0x70
		public Vector3 farRainDirection; // 0x7C
		public Vector3 lastCamPos; // 0x88
		public float sceneEffectRainJitterLevel; // 0x94
		public float sceneEffectRainWidthScale; // 0x98
		public float sceneEffectRainLightingPercent; // 0x9C
		public int sceneEffectRainLayerCount; // 0xA0
		public UnityEngine.Color screenDropColor; // 0xA4
		public int screenDropMaxCountLim; // 0xB4
		public float screenDropFlowPercent; // 0xB8
		public Vector2 screenDropMinMaxLifeTime; // 0xBC
		public Vector2 screenDropMinMaxSize; // 0xC4
		public Vector2 screenDropMinMaxSpeed; // 0xCC
		public Vector2 screenDropCentroidFadeParam; // 0xD4
		public float screenDropPercent; // 0xDC
		public float screenDropJitterSpeedScale; // 0xE0
		public int rainSplashCount; // 0xE4
		public float rainSplashSpeed; // 0xE8
		public float rainSplashAlpha; // 0xEC
		public Vector2 rainSplashMinMaxSize; // 0xF0
		public float rainSplashLightingPercent; // 0xF8
		public bool enableRainLighting; // 0xFC
		public bool enableWetness; // 0xFD
		public bool enableWetnessAffectSSR; // 0xFE
		public float wetness; // 0x100
		public float wetnessBasePorosity; // 0x104
		public float wetnessPorosityFactor; // 0x108
		public float baseWetnessLevel; // 0x10C
		public float verticalWetnessScalar; // 0x110
		public float verticalFlowSpeed; // 0x114
		public float verticalFlowNormalStrength; // 0x118
		public float verticalFlowSurfaceThreshold; // 0x11C
		public float verticalFlowPorosityBias; // 0x120
		public float rippleFrequency; // 0x124
		public float rippleWaveSpeed; // 0x128
		public float rippleNormalStrength; // 0x12C
		public float rippleWaveNormalStrength; // 0x130
		public float rippleRoughnessMaskThreshold; // 0x134
		public float farSceneWetnessDistanceFactor; // 0x138
		public float farSceneWetnessValue; // 0x13C
		public float wetnessProceduralForWater; // 0x140
		public bool wetnessHighQualityKwEnabled; // 0x144
		public int cameraMask; // 0x148
		public RainCommonPreSettingParam commonPresettingParam; // 0x150
		public RainCommonResources commonResources; // 0x158
	
		// Constructors
		public RainCommonRenderingParam() {} // 0x00000001831D3AD0-0x00000001831D3C50
	}
}
