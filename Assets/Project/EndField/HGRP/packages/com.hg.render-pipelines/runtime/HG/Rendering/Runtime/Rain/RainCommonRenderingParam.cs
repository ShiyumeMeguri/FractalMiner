using System;
using UnityEngine;

namespace HG.Rendering.Runtime.Rain
{
	internal class RainCommonRenderingParam
	{
		public RainCommonRenderingParam()
		{
			// // RainCommonRenderingParam()
			// void HG::Rendering::Runtime::Rain::RainCommonRenderingParam::RainCommonRenderingParam(
			//         RainCommonRenderingParam *this,
			//         MethodInfo *method)
			// {
			//   Vector4 v3; // xmm1
			//   TileBase *v4; // rdx
			//   Vector3Int *v5; // r8
			//   ITilemap *v6; // r9
			//   RainCommonPreSettingParam *v7; // rax
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v8; // rdx
			//   __int64 v9; // rcx
			//   RainCommonPreSettingParam *v10; // rdi
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v11; // rdx
			//   Bounds *v12; // r8
			//   Object__Array *v13; // r9
			//   RainCommonResources *v14; // rax
			//   Bounds *v15; // r8
			//   Object__Array *v16; // r9
			//   Vector4 v17; // [rsp+20h] [rbp-18h] BYREF
			//   MethodInfo *v18; // [rsp+60h] [rbp+28h]
			//   MethodInfo *v19; // [rsp+68h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDC26 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::RainCommonPreSettingParam);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::RainCommonResources);
			//     byte_18D8EDC26 = 1;
			//   }
			//   v3 = *UnityEngine::Vector4::get_one(&v17, method);
			//   this.fields.middleRainLayerSpeedDiffMultiplier = 1.0;
			//   this.fields.farRainLayerSpeedDiffMultiplier = 1.0;
			//   this.fields.color = (Color)v3;
			//   this.fields.middleRainAlphaMultiplier = 1.0;
			//   this.fields.farRainAlphaMultiplier = 1.0;
			//   *(_QWORD *)&this.fields.rainDirection.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
			//   this.fields.rainDirection.z = 0.0;
			//   *(_QWORD *)&this.fields.middleRainDirection.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
			//   this.fields.middleRainDirection.z = 0.0;
			//   *(_QWORD *)&this.fields.farRainDirection.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
			//   this.fields.farRainDirection.z = 0.0;
			//   this.fields.sceneEffectRainWidthScale = 0.029999999;
			//   *(_QWORD *)&this.fields.lastCamPos.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   this.fields.lastCamPos.z = 0.0;
			//   this.fields.sceneEffectRainLayerCount = 1;
			//   this.fields.screenDropColor = (Color)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                            (TileAnimationData *)&v17,
			//                                            v4,
			//                                            v5,
			//                                            v6,
			//                                            *(MethodInfo **)&v17.x);
			//   this.fields.screenDropMinMaxLifeTime = 0LL;
			//   this.fields.screenDropMinMaxSize = 0LL;
			//   this.fields.screenDropMinMaxSpeed = 0LL;
			//   this.fields.screenDropCentroidFadeParam = 0LL;
			//   this.fields.screenDropPercent = 1.0;
			//   this.fields.rainSplashMinMaxSize = 0LL;
			//   this.fields.verticalWetnessScalar = 1.0;
			//   this.fields.farSceneWetnessDistanceFactor = 1.0;
			//   this.fields.farSceneWetnessValue = 1.0;
			//   this.fields.wetnessProceduralForWater = 1.0;
			//   this.fields.cameraMask = -1;
			//   v7 = (RainCommonPreSettingParam *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Rain::RainCommonPreSettingParam);
			//   v10 = v7;
			//   if ( !v7
			//     || (HG::Rendering::Runtime::Rain::RainCommonPreSettingParam::RainCommonPreSettingParam(v7, 0LL),
			//         this.fields.commonPresettingParam = v10,
			//         sub_1800054D0(
			//           (BSP *)&this.fields.commonPresettingParam,
			//           v11,
			//           v12,
			//           v13,
			//           *(MethodInfo **)&v17.x,
			//           *(MethodInfo **)&v17.z),
			//         (v14 = (RainCommonResources *)sub_180004920(TypeInfo::HG::Rendering::Runtime::Rain::RainCommonResources)) == 0LL) )
			//   {
			//     sub_180B536AC(v9, v8);
			//   }
			//   this.fields.commonResources = v14;
			//   sub_1800054D0((BSP *)&this.fields.commonResources, v8, v15, v16, v18, v19);
			// }
			// 
		}

		public bool enable;

		public float rawIntensity;

		public float intensity;

		public float speed;

		public Color color;

		public float streakLength;

		public float rainCenterBias;

		public bool enableMiddleRain;

		public float middleRainLayerSpeedDiffMultiplier;

		public float farRainLayerSpeedDiffMultiplier;

		public float middleRainAlphaMultiplier;

		public float farRainAlphaMultiplier;

		public float middleRainLightingPercent;

		public bool enableRainWave;

		public float rainWaveAlpha;

		public float rainWaveVerticalSpeed;

		public float rainWaveHorizontalSpeed;

		public float rainWaveBottomFadeFactor;

		public Vector3 rainDirection;

		public Vector3 middleRainDirection;

		public Vector3 farRainDirection;

		public Vector3 lastCamPos;

		public float sceneEffectRainJitterLevel;

		public float sceneEffectRainWidthScale;

		public float sceneEffectRainLightingPercent;

		public int sceneEffectRainLayerCount;

		public Color screenDropColor;

		public int screenDropMaxCountLim;

		public float screenDropFlowPercent;

		public Vector2 screenDropMinMaxLifeTime;

		public Vector2 screenDropMinMaxSize;

		public Vector2 screenDropMinMaxSpeed;

		public Vector2 screenDropCentroidFadeParam;

		public float screenDropPercent;

		public float screenDropJitterSpeedScale;

		public int rainSplashCount;

		public float rainSplashSpeed;

		public float rainSplashAlpha;

		public Vector2 rainSplashMinMaxSize;

		public float rainSplashLightingPercent;

		public bool enableRainLighting;

		public bool enableWetness;

		public bool enableWetnessAffectSSR;

		public float wetness;

		public float wetnessBasePorosity;

		public float wetnessPorosityFactor;

		public float baseWetnessLevel;

		public float verticalWetnessScalar;

		public float verticalFlowSpeed;

		public float verticalFlowNormalStrength;

		public float verticalFlowSurfaceThreshold;

		public float verticalFlowPorosityBias;

		public float rippleFrequency;

		public float rippleWaveSpeed;

		public float rippleNormalStrength;

		public float rippleWaveNormalStrength;

		public float rippleRoughnessMaskThreshold;

		public float farSceneWetnessDistanceFactor;

		public float farSceneWetnessValue;

		public float wetnessProceduralForWater;

		public bool wetnessHighQualityKwEnabled;

		public int cameraMask;

		public RainCommonPreSettingParam commonPresettingParam;

		public RainCommonResources commonResources;
	}
}
