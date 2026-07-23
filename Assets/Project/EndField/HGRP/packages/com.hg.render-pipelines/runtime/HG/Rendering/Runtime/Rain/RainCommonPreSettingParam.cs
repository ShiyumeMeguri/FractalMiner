using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Rain
{
	[Serializable]
	public class RainCommonPreSettingParam // TypeDefIndex: 38845
	{
		// Fields
		[Header("\u901A\u7528\u8BBE\u7F6E")]
		[Range(1f, 150f)]
		[Tooltip("\u6700\u8FDC\u7684\u96E8\u753B\u591A\u8FDC\uFF0C\u76F4\u63A5\u51B3\u5B9A\u5176\u96E8\u9525\u7684\u534A\u5F84")]
		public float farRainDistance; // 0x10
		[Range(1f, 60f)]
		[Tooltip("\u4E2D\u666F\u96E8\u753B\u591A\u8FDC\uFF0C\u76F4\u63A5\u51B3\u5B9A\u5176\u96E8\u9525\u7684\u534A\u5F84")]
		public float middleRainDistance; // 0x14
		[Range(50f, 200f)]
		[Tooltip("\u96E8\u96FE\u6CE2\u753B\u591A\u8FDC\uFF0C\u76F4\u63A5\u51B3\u5B9A\u5176\u96E8\u9525\u7684\u534A\u5F84")]
		public float rainWaveDistance; // 0x18
		[Range(1f, 300f)]
		[Tooltip("\u6700\u9AD8\u7684\u96E8\u591A\u9AD8\uFF0C\u76F4\u63A5\u51B3\u5B9A\u96E8\u9525\u9AD8\u5EA6\u548C\u906E\u853D\u56FE\u62CD\u6444\u9AD8\u5EA6")]
		public float maxRainHeight; // 0x1C
		[Range(0f, 1f)]
		[Tooltip("\u79FB\u52A8\u5F71\u54CD\u96E8\u65B9\u5411\u7684\u7A0B\u5EA6\uFF0C\u76EE\u524D\u76F4\u63A5\u7B49\u4E8E\u8BE5\u5411\u91CF\u6700\u5927\u7684\u6A21")]
		public float maxMoveDirectionLength; // 0x20
		[FormerlySerializedAs("rainTemporalTimeThreshould")]
		[Range(0f, 2f)]
		[Tooltip("\u51B3\u5B9A\u96E8\u65B9\u5411\u8FC7\u6E21\u7684\u5FEB\u6162")]
		public float rainTemporalTimeThreshold; // 0x24
		[Header("\u96E8\u9525\u8BBE\u7F6E")]
		[Range(0f, 200f)]
		[Tooltip("\u96E8\u9525\u975E\u7269\u7406\u6B63\u786E\u7684\u6700\u5927\u901F\u5EA6")]
		public float farRainMaxUVFlowSpeed; // 0x28
		public Texture2D farRainTex0; // 0x30
		public Vector4 farRainTex0_ST; // 0x38
		public Texture2D farRainTex1; // 0x48
		public Vector4 farRainTex1_ST; // 0x50
		[Header("\u7279\u6548\u96E8\u8BBE\u7F6E")]
		[Range(0f, 200f)]
		[Tooltip("\u7279\u6548\u96E8\u975E\u7269\u7406\u6B63\u786E\u7684\u6700\u5927\u901F\u5EA6")]
		public float sceneEffectRainMaxUVFlowSpeed; // 0x60
		[Range(0f, 100f)]
		public float sceneEffectRainRange; // 0x64
		public Texture2D sceneEffectRainTex; // 0x68
		public Vector4 sceneEffectRainTex_ST; // 0x70
		[Tooltip("R_\u96E8\u96FE\u6CE2\u5F62\u72B6\uFF0CG_\u566A\u58F0")]
		public Texture2D rainWaveTex; // 0x80
		public Vector4 rainWaveTex_ST; // 0x88
		public Vector4 rainWaveNoise_ST; // 0x98
		public float rainWaveNoiseFlowSpeedMultiplier; // 0xA8
		[Header("\u5C4F\u5E55\u96E8\u6EF4")]
		public Vector2 screenDropScatterParam; // 0xAC
		[Range(0f, 1f)]
		public float screenDropFXShadingSize; // 0xB4
		[Range(0f, 1f)]
		public float screenDropNoiseLevel; // 0xB8
		public Texture2D screenDropFXNoiseTex; // 0xC0
		public Vector4 screenDropFXNoiseTex_ST; // 0xC8
		[Header("\u6F6E\u6E7F")]
		[Tooltip("RG_\u6CD5\u7EBF, B_Mask")]
		public Texture2D verticalFlowTexture; // 0xD8
		public Vector4 verticalFlowTexture_ST; // 0xE0
		[Tooltip("RG_Ripple\u6CD5\u7EBF\uFF0CBA_wave\u6CD5\u7EBF")]
		public Texture2D rippleTexture; // 0xF0
		public int rippleRowColumnCount; // 0xF8
		public Vector2 rippleTexture_ST; // 0xFC
		[Header("\u6C34\u82B1\u8BBE\u7F6E")]
		[Tooltip("\u4E0D\u540C\u901A\u9053\u4EE3\u8868\u4E0D\u540C\u6C34\u82B1\u5F62\u72B6\u7684Flipbook")]
		public Texture2D rainSplashTexture; // 0x108
		public int rainSplashTextureRowColumnCount; // 0x110
		[Range(0f, 50f)]
		public float rainSplashRange; // 0x114
		[Range(0f, 1f)]
		public float rainSplashYBias; // 0x118
		[Header("\u96E8\u906E\u853D\u56FE\u8BBE\u7F6E")]
		[Range(1f, 200f)]
		public float rainOcclusionMapRange; // 0x11C
		[Range(1f, 300f)]
		[Tooltip("\u96E8\u906E\u853D\u56FE\u62CD\u6444\u9AD8\u5EA6\uFF0C\u5B9E\u9645\u62CD\u6444\u662F\u8FD9\u4E2A\u503C\u4E582\uFF0C\u4E0A\u4E0B\u90FD\u62CD")]
		public float rainOcclusionMapHeight; // 0x120
		[Range(0f, 5f)]
		public float rainOcclusionSampleNormalBias; // 0x124
		[Range(-3f, 3f)]
		public float rainOcclusionSampleDepthBias; // 0x128
		public Texture3D rainOcclusionSampleNoise; // 0x130
		[Range(0f, 1f)]
		public float rainOcclusionSampleNoiseScale; // 0x138
		[Range(0f, 2f)]
		public float rainOcclusionSampleHorizontalJitterLevel; // 0x13C
		[Range(0f, 2f)]
		public float rainOcclusionSampleVerticalJitterLevel; // 0x140
		[Header("\u89D2\u8272\u96E8\u8D44\u6E90")]
		public Texture2D characterRainDropTexture; // 0x148
		public Texture2D characterRainStreakTexture; // 0x150
		public Texture2D characterRainFaceDripTexture; // 0x158
		public Texture2D characterRainFaceDropletTexture; // 0x160
		[Range(0.01f, 10f)]
		public float characterRainTextureTiling; // 0x168
	
		// Constructors
		public RainCommonPreSettingParam() {} // 0x00000001831D3C50-0x00000001831D3D40
		// RainCommonPreSettingParam()
		void HG::Rendering::Runtime::Rain::RainCommonPreSettingParam::RainCommonPreSettingParam(
		        RainCommonPreSettingParam *this,
		        MethodInfo *method)
		{
		  Vector4 si128; // xmm0
		
		  si128 = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18B959740);
		  this->fields.farRainTex0_ST = si128;
		  this->fields.farRainDistance = 60.0;
		  this->fields.farRainTex1_ST = si128;
		  this->fields.middleRainDistance = 30.0;
		  this->fields.sceneEffectRainTex_ST = si128;
		  this->fields.rainWaveDistance = 115.0;
		  this->fields.rainWaveTex_ST = si128;
		  this->fields.maxRainHeight = 100.0;
		  this->fields.rainWaveNoise_ST = si128;
		  this->fields.maxMoveDirectionLength = 0.1;
		  this->fields.verticalFlowTexture_ST = si128;
		  this->fields.rainTemporalTimeThreshold = 1.0;
		  this->fields.farRainMaxUVFlowSpeed = 160.0;
		  this->fields.sceneEffectRainMaxUVFlowSpeed = 160.0;
		  this->fields.sceneEffectRainRange = 30.0;
		  this->fields.rainWaveNoiseFlowSpeedMultiplier = 1.0;
		  this->fields.screenDropScatterParam.x = 1.0;
		  this->fields.screenDropScatterParam.y = 1.0;
		  this->fields.rippleRowColumnCount = 1;
		  this->fields.rippleTexture_ST.x = 1.0;
		  this->fields.rippleTexture_ST.y = 1.0;
		  this->fields.rainSplashTextureRowColumnCount = 1;
		  this->fields.rainSplashRange = 30.0;
		  this->fields.rainOcclusionMapRange = 60.0;
		  this->fields.rainOcclusionMapHeight = 150.0;
		  this->fields.rainOcclusionSampleNoiseScale = 1.0;
		  this->fields.characterRainTextureTiling = 4.0;
		}
		
	}
}
