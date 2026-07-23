using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class FogSimpleConfig // TypeDefIndex: 37929
	{
		// Fields
		public const float DISTANCE_FADE_MIN = 0.001f; // Metadata: 0x023035F7
		public const float DEFAULT_STREAMING_CULLING_NEAR = 50f; // Metadata: 0x023035FB
		public const float DEFAULT_STREAMING_CULLING_DIS = 512f; // Metadata: 0x023035FF
		[NonSerialized]
		public bool previewInScene; // 0x10
		[NonSerialized]
		public FogSimpleType _fogSimpleType; // 0x14
		[HideInInspector]
		public bool isLunaPlatform; // 0x18
		public bool _cullingUseDistanceFade; // 0x19
		public float _cullingDistanceNear; // 0x1C
		public float _cullingDistanceFar; // 0x20
		public bool _distanceFade; // 0x24
		[UnclampedRange(0.001f, 512f)]
		public float _distanceFadeEnd; // 0x28
		[UnclampedRange(0.001f, 512f)]
		public float _distanceFadeStart; // 0x2C
		[UnclampedRange(0.001f, 3000f)]
		public float _nearCameraFadeDistanceEnd; // 0x30
		[UnclampedRange(0.001f, 3000f)]
		public float _nearCameraFadeDistanceStart; // 0x34
		public RenderFace _renderFace; // 0x38
		public BlendMode _blendMode; // 0x3C
		[ColorUsage(true, true)]
		public UnityEngine.Color _baseColor; // 0x40
		[UnclampedRange(0f, 10f)]
		public float _baseAlphaIntensity; // 0x50
		public Texture _mainTex; // 0x58
		public Vector4 _mainTexST; // 0x60
		public Texture _noiseTex; // 0x70
		public Vector4 _noiseTexST; // 0x78
		[Range(0f, 1f)]
		public float _fogNoiseIntensity; // 0x88
		public bool _useWind; // 0x8C
		[Range(0f, 1f)]
		public float _windNoiseIntensity; // 0x90
		[UnclampedRange(-5f, 5f)]
		public float _windNoiseContrast; // 0x94
		[UnclampedRange(0f, 1f)]
		public float _windScale; // 0x98
		public bool _useSeparateScale; // 0x9C
		[UnclampedRange(0f, 1f)]
		public float _windScaleX; // 0xA0
		[UnclampedRange(0f, 1f)]
		public float _windScaleY; // 0xA4
		[Range(-1f, 1f)]
		public float _windDirX; // 0xA8
		[Range(-1f, 1f)]
		public float _windDirY; // 0xAC
		[Range(0f, 1f)]
		public float _windSpeed; // 0xB0
		public bool _useLighting; // 0xB4
		public bool _useNormalTex; // 0xB5
		public Texture _normalTex; // 0xB8
		[Range(0f, 10f)]
		public float _normalScale; // 0xC0
		public bool _twoSidedNormal; // 0xC4
		[ColorUsage(true, true)]
		public UnityEngine.Color _indirectColor; // 0xC8
		[Range(0f, 1f)]
		public float _lightFactor; // 0xD8
		public bool _useFresnel; // 0xDC
		public bool _flipFresnel; // 0xDD
		[Range(0f, 1f)]
		public float _fresnelIntensity; // 0xE0
		[Range(0.01f, 10f)]
		public float _fresnelContract; // 0xE4
		public bool _topFade; // 0xE8
		[UnclampedRange(0f, 10f)]
		public float _topFadeContract; // 0xEC
		[UnclampedRange(-1f, 1f)]
		public float _topFadeOffset; // 0xF0
		public bool _useSoftBlend; // 0xF4
		[UnclampedRange(0f, 100f)]
		public float _softDistance; // 0xF8
		public bool _useFog; // 0xFC
		[UnclampedRange(0f, 1f)]
		public float _fogIntensity; // 0x100
		[UnclampedRange(10f, 10000f)]
		public float _fogIntensityFadeOutDistance; // 0x104
		public bool _usePreDepth; // 0x108
		[Range(0f, 2f)]
		public float _depthPrePassAlphaThreshold; // 0x10C
	
		// Properties
		public bool fogTypeIsStreaming { get => default; } // 0x0000000189B5768C-0x0000000189B576DC 
		// Boolean get_fogTypeIsStreaming()
		bool HG::Rendering::Runtime::FogSimpleConfig::get_fogTypeIsStreaming(FogSimpleConfig *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2355, 0LL) )
		    return this->fields._fogSimpleType == 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2355, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public bool fogTypeIsFarScene { get => default; } // 0x0000000189B5763C-0x0000000189B5768C 
		// Boolean get_fogTypeIsFarScene()
		bool HG::Rendering::Runtime::FogSimpleConfig::get_fogTypeIsFarScene(FogSimpleConfig *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2356, 0LL) )
		    return this->fields._fogSimpleType == 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2356, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		public enum FogSimpleType // TypeDefIndex: 37926
		{
			FarScene = 0,
			Streaming = 1
		}
	
		public enum RenderFace // TypeDefIndex: 37927
		{
			Both = 0,
			Back = 1,
			Front = 2
		}
	
		public enum BlendMode // TypeDefIndex: 37928
		{
			Alpha = 0,
			Additive = 1
		}
	
		// Constructors
		public FogSimpleConfig() {} // Dummy constructor
		public FogSimpleConfig(FakeFogSimple fakeFogSimple) {} // 0x0000000189B57524-0x0000000189B5763C
		// FogSimpleConfig(FakeFogSimple)
		void HG::Rendering::Runtime::FogSimpleConfig::FogSimpleConfig(
		        FogSimpleConfig *this,
		        FakeFogSimple *fakeFogSimple,
		        MethodInfo *method)
		{
		  Vector4 *one; // rax
		  __m128i si128; // xmm0
		  __m128i v5; // xmm1
		  __int64 v6; // r8
		  MethodInfo *v7; // rdx
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // r8
		  __m128i v11; // xmm1
		  int v12; // r9d
		  char v13; // r10
		  Vector4 v14; // [rsp+20h] [rbp-18h] BYREF
		
		  this->fields._cullingDistanceFar = 512.0;
		  this->fields._cullingDistanceNear = 50.0;
		  this->fields._distanceFadeStart = 50.0;
		  this->fields._fogSimpleType = 1;
		  this->fields._nearCameraFadeDistanceEnd = 0.001;
		  this->fields._nearCameraFadeDistanceStart = 0.001;
		  this->fields._cullingUseDistanceFade = 1;
		  this->fields._distanceFadeEnd = 80.0;
		  this->fields._renderFace = 2;
		  this->fields._blendMode = 1;
		  one = UnityEngine::Vector4::get_one(&v14, (MethodInfo *)fakeFogSimple);
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959740);
		  v5 = _mm_loadu_si128((const __m128i *)one);
		  *(_DWORD *)(v6 + 80) = 1065353216;
		  *(__m128i *)(v6 + 96) = si128;
		  *(_DWORD *)(v6 + 144) = 1065353216;
		  *(__m128i *)(v6 + 64) = v5;
		  *(_DWORD *)(v6 + 152) = 1065353216;
		  *(__m128i *)(v6 + 120) = si128;
		  *(_DWORD *)(v6 + 160) = 1065353216;
		  *(_DWORD *)(v6 + 164) = 1065353216;
		  *(_DWORD *)(v6 + 168) = 1065353216;
		  *(_DWORD *)(v6 + 172) = 1065353216;
		  *(_DWORD *)(v6 + 192) = 1065353216;
		  v11 = _mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::get_identity((Quaternion *)&v14, v7));
		  *(_DWORD *)(v10 + 216) = v12;
		  *(_BYTE *)(v10 + 221) = v13;
		  *(_DWORD *)(v10 + 228) = v12;
		  *(_DWORD *)(v10 + 240) = v12;
		  *(_DWORD *)(v10 + 248) = v12;
		  *(_DWORD *)(v10 + 256) = v12;
		  *(_DWORD *)(v10 + 260) = 1157234688;
		  *(_DWORD *)(v10 + 268) = 1059481190;
		  *(__m128i *)(v10 + 200) = v11;
		  if ( !v8 )
		    sub_1800D8260(v9, 0LL);
		  *(_BYTE *)(v10 + 24) = *(_BYTE *)(v8 + 80);
		}
		
	}
}
