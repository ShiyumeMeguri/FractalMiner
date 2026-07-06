using System;
using UnityEngine;

namespace HG.Rendering.Runtime.Rain
{
	[Serializable]
	public class RainCommonPreSettingParam
	{
		public RainCommonPreSettingParam()
		{
			// // RainCommonPreSettingParam()
			// void HG::Rendering::Runtime::Rain::RainCommonPreSettingParam::RainCommonPreSettingParam(
			//         RainCommonPreSettingParam *this,
			//         MethodInfo *method)
			// {
			//   Vector4 si128; // xmm0
			// 
			//   si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357570);
			//   this.fields.farRainTex0_ST = si128;
			//   this.fields.farRainDistance = 60.0;
			//   this.fields.farRainTex1_ST = si128;
			//   this.fields.middleRainDistance = 30.0;
			//   this.fields.sceneEffectRainTex_ST = si128;
			//   this.fields.rainWaveDistance = 115.0;
			//   this.fields.rainWaveTex_ST = si128;
			//   this.fields.maxRainHeight = 100.0;
			//   this.fields.rainWaveNoise_ST = si128;
			//   this.fields.maxMoveDirectionLength = 0.1;
			//   this.fields.verticalFlowTexture_ST = si128;
			//   this.fields.rainTemporalTimeThreshould = 1.0;
			//   this.fields.farRainMaxUVFlowSpeed = 160.0;
			//   this.fields.sceneEffectRainMaxUVFlowSpeed = 160.0;
			//   this.fields.sceneEffectRainRange = 30.0;
			//   this.fields.rainWaveNoiseFlowSpeedMultiplier = 1.0;
			//   this.fields.screenDropScatterParam.x = 1.0;
			//   this.fields.screenDropScatterParam.y = 1.0;
			//   this.fields.rippleRowColumnCount = 1;
			//   this.fields.rippleTexture_ST.x = 1.0;
			//   this.fields.rippleTexture_ST.y = 1.0;
			//   this.fields.rainSplashTextureRowColumnCount = 1;
			//   this.fields.rainSplashRange = 30.0;
			//   this.fields.rainOcclusionMapRange = 60.0;
			//   this.fields.rainOcclusionMapHeight = 150.0;
			//   this.fields.rainOcclusionSampleNoiseScale = 1.0;
			//   this.fields.characterRainTextureTiling = 4.0;
			// }
			// 
		}

		[Header("通用设置")]
		[Range(1f, 150f)]
		[Tooltip("最远的雨画多远，直接决定其雨锥的半径")]
		public float farRainDistance;

		[Range(1f, 60f)]
		[Tooltip("中景雨画多远，直接决定其雨锥的半径")]
		public float middleRainDistance;

		[Range(50f, 200f)]
		[Tooltip("雨雾波画多远，直接决定其雨锥的半径")]
		public float rainWaveDistance;

		[Range(1f, 300f)]
		[Tooltip("最高的雨多高，直接决定雨锥高度和遮蔽图拍摄高度")]
		public float maxRainHeight;

		[Tooltip("移动影响雨方向的程度，目前直接等于该向量最大的模")]
		[Range(0f, 1f)]
		public float maxMoveDirectionLength;

		[Range(0f, 2f)]
		[Tooltip("决定雨方向过渡的快慢")]
		public float rainTemporalTimeThreshould;

		[Range(0f, 200f)]
		[Tooltip("雨锥非物理正确的最大速度")]
		[Header("雨锥设置")]
		public float farRainMaxUVFlowSpeed;

		public Texture2D farRainTex0;

		public Vector4 farRainTex0_ST;

		public Texture2D farRainTex1;

		public Vector4 farRainTex1_ST;

		[Header("特效雨设置")]
		[Tooltip("特效雨非物理正确的最大速度")]
		[Range(0f, 200f)]
		public float sceneEffectRainMaxUVFlowSpeed;

		[Range(0f, 100f)]
		public float sceneEffectRainRange;

		public Texture2D sceneEffectRainTex;

		public Vector4 sceneEffectRainTex_ST;

		[Tooltip("R_雨雾波形状，G_噪声")]
		public Texture2D rainWaveTex;

		public Vector4 rainWaveTex_ST;

		public Vector4 rainWaveNoise_ST;

		public float rainWaveNoiseFlowSpeedMultiplier;

		[Header("屏幕雨滴")]
		public Vector2 screenDropScatterParam;

		[Range(0f, 1f)]
		public float screenDropFXShadingSize;

		[Range(0f, 1f)]
		public float screenDropNoiseLevel;

		public Texture2D screenDropFXNoiseTex;

		public Vector4 screenDropFXNoiseTex_ST;

		[Header("潮湿")]
		[Tooltip("RG_法线, B_Mask")]
		public Texture2D verticalFlowTexture;

		public Vector4 verticalFlowTexture_ST;

		[Tooltip("RG_Ripple法线，BA_wave法线")]
		public Texture2D rippleTexture;

		public int rippleRowColumnCount;

		public Vector2 rippleTexture_ST;

		[Tooltip("不同通道代表不同水花形状的Flipbook")]
		[Header("水花设置")]
		public Texture2D rainSplashTexture;

		public int rainSplashTextureRowColumnCount;

		[Range(0f, 50f)]
		public float rainSplashRange;

		[Range(0f, 1f)]
		public float rainSplashYBias;

		[Range(1f, 200f)]
		[Header("雨遮蔽图设置")]
		public float rainOcclusionMapRange;

		[Tooltip("雨遮蔽图拍摄高度，实际拍摄是这个值乘2，上下都拍")]
		[Range(1f, 300f)]
		public float rainOcclusionMapHeight;

		[Range(0f, 5f)]
		public float rainOcclusionSampleNormalBias;

		[Range(-3f, 3f)]
		public float rainOcclusionSampleDepthBias;

		public Texture3D rainOcclusionSampleNoise;

		[Range(0f, 1f)]
		public float rainOcclusionSampleNoiseScale;

		[Range(0f, 2f)]
		public float rainOcclusionSampleHorizontalJitterLevel;

		[Range(0f, 2f)]
		public float rainOcclusionSampleVerticalJitterLevel;

		[Header("角色雨资源")]
		public Texture2D characterRainDropTexture;

		public Texture2D characterRainStreakTexture;

		public Texture2D characterRainFaceDripTexture;

		public Texture2D characterRainFaceDropletTexture;

		[Range(0.01f, 10f)]
		public float characterRainTextureTiling;
	}
}
