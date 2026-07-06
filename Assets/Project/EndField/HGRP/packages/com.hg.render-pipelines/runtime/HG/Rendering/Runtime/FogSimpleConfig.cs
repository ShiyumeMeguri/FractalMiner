using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class FogSimpleConfig
	{
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool fogTypeIsStreaming
		{
			get
			{
				// // Boolean get_fogTypeIsStreaming()
				// bool HG::Rendering::Runtime::FogSimpleConfig::get_fogTypeIsStreaming(FogSimpleConfig *this, MethodInfo *method)
				// {
				//   return this.fields._fogSimpleType == 1;
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool fogTypeIsFarScene
		{
			get
			{
				// // Boolean get_IsDefaultContext()
				// bool System::Runtime::Remoting::Contexts::Context::get_IsDefaultContext(Context *this, MethodInfo *method)
				// {
				//   return this.fields.context_id == 0;
				// }
				// 
				return default(bool);
			}
		}

		public FogSimpleConfig(FakeFogSimple fakeFogSimple)
		{
			// // FogSimpleConfig(FakeFogSimple)
			// void HG::Rendering::Runtime::FogSimpleConfig::FogSimpleConfig(
			//         FogSimpleConfig *this,
			//         FakeFogSimple *fakeFogSimple,
			//         MethodInfo *method)
			// {
			//   Vector4 *one; // rax
			//   __m128i si128; // xmm0
			//   __m128i v5; // xmm1
			//   __int64 v6; // r8
			//   MethodInfo *v7; // rdx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // r8
			//   __m128i v11; // xmm1
			//   int v12; // r9d
			//   char v13; // r10
			//   Vector4 v14; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   this.fields._cullingDistanceFar = 512.0;
			//   this.fields._distanceFadeEnd = 0.001;
			//   this.fields._distanceFadeStart = 0.001;
			//   this.fields._nearCameraFadeDistanceEnd = 0.001;
			//   this.fields._nearCameraFadeDistanceStart = 0.001;
			//   this.fields._fogSimpleType = 1;
			//   this.fields._cullingUseDistanceFade = 1;
			//   this.fields._blendMode = 1;
			//   this.fields._renderFace = 2;
			//   one = UnityEngine::Vector4::get_one(&v14, (MethodInfo *)fakeFogSimple);
			//   si128 = _mm_load_si128((const __m128i *)&xmmword_18A357570);
			//   v5 = _mm_loadu_si128((const __m128i *)one);
			//   *(_DWORD *)(v6 + 80) = 1065353216;
			//   *(__m128i *)(v6 + 96) = si128;
			//   *(_DWORD *)(v6 + 144) = 1065353216;
			//   *(__m128i *)(v6 + 64) = v5;
			//   *(_DWORD *)(v6 + 152) = 1065353216;
			//   *(__m128i *)(v6 + 120) = si128;
			//   *(_DWORD *)(v6 + 160) = 1065353216;
			//   *(_DWORD *)(v6 + 164) = 1065353216;
			//   *(_DWORD *)(v6 + 168) = 1065353216;
			//   *(_DWORD *)(v6 + 172) = 1065353216;
			//   *(_DWORD *)(v6 + 192) = 1065353216;
			//   v11 = _mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::get_identity((Quaternion *)&v14, v7));
			//   *(_DWORD *)(v10 + 216) = v12;
			//   *(_BYTE *)(v10 + 221) = v13;
			//   *(_DWORD *)(v10 + 228) = v12;
			//   *(_DWORD *)(v10 + 240) = v12;
			//   *(_DWORD *)(v10 + 248) = v12;
			//   *(_DWORD *)(v10 + 256) = v12;
			//   *(_DWORD *)(v10 + 260) = 1157234688;
			//   *(__m128i *)(v10 + 200) = v11;
			//   if ( !v8 )
			//     sub_180B536AC(v9, 0LL);
			//   *(_BYTE *)(v10 + 24) = *(_BYTE *)(v8 + 72);
			// }
			// 
		}

		public const float DISTANCE_FADE_MIN = 0.001f;

		public const float DEFAULT_STREAMING_CULLING_DIS = 512f;

		[NonSerialized]
		public bool previewInScene;

		[NonSerialized]
		public FogSimpleConfig.FogSimpleType _fogSimpleType;

		[HideInInspector]
		public bool isLunaPlatform;

		public bool _cullingUseDistanceFade;

		public float _cullingDistanceNear;

		public float _cullingDistanceFar;

		public bool _distanceFade;

		[UnclampedRange(0.001f, 512f)]
		public float _distanceFadeEnd;

		[UnclampedRange(0.001f, 512f)]
		public float _distanceFadeStart;

		[UnclampedRange(0.001f, 3000f)]
		public float _nearCameraFadeDistanceEnd;

		[UnclampedRange(0.001f, 3000f)]
		public float _nearCameraFadeDistanceStart;

		public FogSimpleConfig.RenderFace _renderFace;

		public FogSimpleConfig.BlendMode _blendMode;

		[ColorUsage(true, true)]
		public Color _baseColor;

		[UnclampedRange(0f, 10f)]
		public float _baseAlphaIntensity;

		public Texture _mainTex;

		public Vector4 _mainTexST;

		public Texture _noiseTex;

		public Vector4 _noiseTexST;

		[Range(0f, 1f)]
		public float _fogNoiseIntensity;

		public bool _useWind;

		[Range(0f, 1f)]
		public float _windNoiseIntensity;

		[UnclampedRange(-5f, 5f)]
		public float _windNoiseContrast;

		[UnclampedRange(0f, 1f)]
		public float _windScale;

		public bool _useSeparateScale;

		[UnclampedRange(0f, 1f)]
		public float _windScaleX;

		[UnclampedRange(0f, 1f)]
		public float _windScaleY;

		[Range(-1f, 1f)]
		public float _windDirX;

		[Range(-1f, 1f)]
		public float _windDirY;

		[Range(0f, 1f)]
		public float _windSpeed;

		public bool _useLighting;

		public bool _useNormalTex;

		public Texture _normalTex;

		[Range(0f, 10f)]
		public float _normalScale;

		public bool _twoSidedNormal;

		[ColorUsage(true, true)]
		public Color _indirectColor;

		[Range(0f, 1f)]
		public float _lightFactor;

		public bool _useFresnel;

		public bool _flipFresnel;

		[Range(0f, 1f)]
		public float _fresnelIntensity;

		[Range(0.01f, 10f)]
		public float _fresnelContract;

		public bool _topFade;

		[UnclampedRange(0f, 10f)]
		public float _topFadeContract;

		[UnclampedRange(-1f, 1f)]
		public float _topFadeOffset;

		public bool _useSoftBlend;

		[UnclampedRange(0f, 100f)]
		public float _softDistance;

		public bool _useFog;

		[UnclampedRange(0f, 1f)]
		public float _fogIntensity;

		[UnclampedRange(10f, 10000f)]
		public float _fogIntensityFadeOutDistance;

		public enum FogSimpleType
		{
			FarScene,
			Streaming
		}

		public enum RenderFace
		{
			Both,
			Back,
			Front
		}

		public enum BlendMode
		{
			Alpha,
			Additive
		}
	}
}
