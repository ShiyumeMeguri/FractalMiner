using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGRainConfig : IEnvConfig // TypeDefIndex: 37616
	{
		// Fields
		[FormerlySerializedAs("enableEdit")]
		[Header("\u542F\u7528\u4E0B\u96E8")]
		public bool enable; // 0x00
		[FormerlySerializedAs("intensityEdit")]
		[Header("\u964D\u96E8\u53C2\u6570")]
		[Range(0f, 100f)]
		[Tooltip("\u964D\u96E8\u5F3A\u5EA6\u3002\u5F71\u54CD\u96E8\u6EF4\u7684\u5BC6\u5EA6\u3002\u8303\u56F4 0 - 100")]
		public float intensity; // 0x04
		[Range(0f, 20f)]
		[Tooltip("\u964D\u96E8\u901F\u5EA6\u3002\u5373\u96E8\u6EF4\u843D\u4E0B\u7684\u901F\u5EA6\u3002\u8303\u56F4 0 - 20")]
		public float speed; // 0x08
		public UnityEngine.Color color; // 0x0C
		[Range(0f, 3f)]
		[Tooltip("\u96E8\u6EF4\u957F\u5EA6\u3002\u8303\u56F4 0 - 3")]
		public float streakLength; // 0x1C
		[Header("\u8FD1\u5904\u96E8\u8BBE\u7F6E")]
		[Range(0f, 360f)]
		[Tooltip("\u6C34\u5E73\u9762\u5185\u7684\u96E8\u5411\uFF0C0 \u4E3A\u6B63\u5317\uFF08z \u8F74\u6B63\u65B9\u5411\uFF09\uFF0C90 \u4E3A\u6B63\u4E1C\uFF08x \u8F74\u6B63\u65B9\u5411\uFF09")]
		public float horizontalRainAngle; // 0x20
		[Range(0f, 1f)]
		public float horizontalRainLevel; // 0x24
		[Range(0f, 1f)]
		public float sceneEffectRainJitterLevel; // 0x28
		[Range(0f, 0.2f)]
		public float sceneEffectRainWidthScale; // 0x2C
		[Range(0f, 1f)]
		public float sceneEffectRainLightingPercent; // 0x30
		[Range(0f, 80f)]
		public float rainCenterBias; // 0x34
		[Header("\u4E2D\u666F\u96E8\u8BBE\u7F6E")]
		[Range(0f, 5f)]
		public float middleRainLayerSpeedDiffMultiplier; // 0x38
		[Range(0f, 3f)]
		[Tooltip("\u4E2D\u666F\u96E8\u900F\u660E\u5EA6\uFF0C\u76F4\u63A5\u4E58\u5728\u96E8\u6EF4\u989C\u8272\u7684Alpha\u503C\u4E0A\u3002\u662F\u76F8\u5BF9\u900F\u660E\u5EA6")]
		public float middleRainAlphaMultiplier; // 0x3C
		[Range(0f, 360f)]
		[Tooltip("\u6C34\u5E73\u9762\u5185\u7684\u96E8\u5411\uFF0C0 \u4E3A\u6B63\u5317\uFF08z \u8F74\u6B63\u65B9\u5411\uFF09\uFF0C90 \u4E3A\u6B63\u4E1C\uFF08x \u8F74\u6B63\u65B9\u5411\uFF09")]
		public float middleHorizontalRainAngle; // 0x40
		[Range(0f, 1f)]
		public float middleHorizontalRainLevel; // 0x44
		[Range(0f, 1f)]
		public float middleRainLightingPercent; // 0x48
		[FormerlySerializedAs("rainLayerSpeedDiffMultiplier")]
		[Header("\u8FDC\u5904\u96E8\u9525\u8BBE\u7F6E")]
		[Range(0f, 5f)]
		public float farRainLayerSpeedDiffMultiplier; // 0x4C
		[Range(0f, 3f)]
		[Tooltip("\u8FDC\u5904\u96E8\u900F\u660E\u5EA6\uFF0C\u76F4\u63A5\u4E58\u5728\u96E8\u6EF4\u989C\u8272\u7684Alpha\u503C\u4E0A\u3002\u662F\u76F8\u5BF9\u900F\u660E\u5EA6")]
		public float farRainAlphaMultiplier; // 0x50
		[Range(0f, 360f)]
		[Tooltip("\u6C34\u5E73\u9762\u5185\u7684\u96E8\u5411\uFF0C0 \u4E3A\u6B63\u5317\uFF08z \u8F74\u6B63\u65B9\u5411\uFF09\uFF0C90 \u4E3A\u6B63\u4E1C\uFF08x \u8F74\u6B63\u65B9\u5411\uFF09")]
		public float farRainHorizontalRainAngle; // 0x54
		[Range(0f, 1f)]
		public float farRainHorizontalRainLevel; // 0x58
		[Header("\u96E8\u96FE\u6CE2\u8BBE\u7F6E")]
		[Range(0f, 5f)]
		public float rainWaveVerticalSpeed; // 0x5C
		[Range(-3f, 3f)]
		[Tooltip("\u96E8\u96FE\u6CE2\u6A2A\u5411\u6D41\u52A8")]
		public float rainWaveHorizontalSpeed; // 0x60
		[Range(0f, 3f)]
		[Tooltip("\u96E8\u96FE\u6CE2\u900F\u660E\u5EA6\uFF0C\u4E0E\u96E8\u672C\u8EAB\u900F\u660E\u5EA6\u65E0\u5173")]
		public float rainWaveAlpha; // 0x64
		[Range(0f, 1f)]
		public float rainWaveBottomFadeFactor; // 0x68
		[Header("\u955C\u5934\u96E8\u6EF4\u8BBE\u7F6E")]
		public UnityEngine.Color screenDropColor; // 0x6C
		[Range(0f, 30f)]
		[Tooltip("\u4EE3\u8868\u964D\u96E8\u5F3A\u5EA6\u4E3A100\u65F6\uFF0C\u51FA\u73B0\u7684\u96E8\u6EF4\u6570\u76EE")]
		public int screenDropMaxCountLim; // 0x7C
		public Vector2 screenDropMinMaxLifeTime; // 0x80
		public Vector2 screenDropMinMaxSize; // 0x88
		[Tooltip("\u8DDD\u79BB\u5C4F\u5E55\u4E2D\u5FC3\u6D88\u5931\u7684\u8303\u56F4\uFF0C\u4F4E\u4E8E\u6700\u4F4E\u503C\u4F1A\u5B8C\u5168\u6D88\u5931\uFF0C\u9AD8\u4E8E\u6700\u9AD8\u503C\u5B8C\u5168\u51FA\u73B0\uFF0C\u5728\u8FD9\u4E4B\u95F4\u4F1A\u6E10\u53D8\u6D88\u5931")]
		public Vector2 screenDropCentroidFadeParam; // 0x90
		[Range(0f, 1f)]
		[Tooltip("\u6BCF\u4E2A\u5C4F\u5E55\u96E8\u6EF4\u6709\u591A\u5C11\u6982\u7387\u53EF\u4EE5\u6D41\u52A8")]
		public float screenDropFlowPercent; // 0x98
		public Vector2 screenDropMinMaxSpeed; // 0x9C
		[Range(0f, 5f)]
		public float screenDropJitterSpeedScale; // 0xA4
		[Header("\u5730\u9762\u96E8\u82B1\u8BBE\u7F6E")]
		[Range(0f, 1000f)]
		public int rainSplashCount; // 0xA8
		[Range(0f, 10f)]
		public float rainSplashSpeed; // 0xAC
		[Range(0f, 3f)]
		[Tooltip("\u96E8\u82B1\u900F\u660E\u5EA6\uFF0C\u4E0E\u96E8\u672C\u8EAB\u900F\u660E\u5EA6\u65E0\u5173")]
		public float rainSplashAlpha; // 0xB0
		public Vector2 rainSplashMinMaxSize; // 0xB4
		[Range(0f, 1f)]
		public float rainSplashLightingPercent; // 0xBC
		[Header("\u5730\u9762\u6F6E\u6E7F\u8BBE\u7F6E")]
		public bool enableWetness; // 0xC0
		public bool enableWetnessAffectSSR; // 0xC1
		[Range(0f, 1f)]
		[Tooltip("\u5730\u9762\u6F6E\u6E7F\u7684\u7A0B\u5EA6\uFF0C\u5168\u5C40\u63A7\u5236\uFF0C\u5177\u4F53\u6BCF\u4E2A\u6750\u8D28\u8BF7\u5355\u72EC\u8BBE\u7F6E\u5438\u6536\u5EA6")]
		public float wetness; // 0xC4
		[Range(0f, 1f)]
		[Tooltip("\u5730\u9762\u6F6E\u6E7F\u57FA\u51C6\u5438\u6536\u5EA6\u3002\u5438\u6536\u5EA6\u8D8A\u9AD8\uFF0C\u8D8A\u6F6E\u6E7F\u5438\u6C34\u8D8A\u591A\u989C\u8272\u8D8A\u6DF1\uFF0C\u53CD\u4E4B\u8D8A\u6F6E\u6E7F\u5438\u6C34\u8D8A\u5C11\u8868\u9762\u8D8A\u5149\u6ED1")]
		public float wetnessBasePorosity; // 0xC8
		[Range(-1f, 1f)]
		[Tooltip("\u8D8A\u7C97\u7CD9\u7684\u7269\u4EF6\u53D7\u56E0\u5B50\u5F71\u54CD\u8D8A\u5C0F")]
		public float wetnessPorosityFactor; // 0xCC
		[Range(0f, 1f)]
		[Tooltip("\u5730\u9762\u6F6E\u6E7F\u57FA\u51C6\u5438\u6536\u5EA6\u3002\u5438\u6536\u5EA6\u8D8A\u9AD8\uFF0C\u8D8A\u6F6E\u6E7F\u5438\u6C34\u8D8A\u591A\u989C\u8272\u8D8A\u6DF1\uFF0C\u53CD\u4E4B\u8D8A\u6F6E\u6E7F\u5438\u6C34\u8D8A\u5C11\u8868\u9762\u8D8A\u5149\u6ED1")]
		public float baseWetnessLevel; // 0xD0
		[Range(0f, 1f)]
		public float verticalWetnessScalar; // 0xD4
		[Range(0f, 30f)]
		public float verticalFlowSpeed; // 0xD8
		[Range(0f, 3f)]
		public float verticalFlowNormalStrength; // 0xDC
		[Range(0f, 1f)]
		public float verticalFlowSurfaceThreshold; // 0xE0
		[Range(-2f, 2f)]
		public float verticalFlowPorosityBias; // 0xE4
		[Range(1f, 5f)]
		public float rippleFrequency; // 0xE8
		[Range(0f, 1f)]
		public float rippleNormalStrength; // 0xEC
		[Range(0f, 5f)]
		public float rippleWaveSpeed; // 0xF0
		[Range(0f, 1f)]
		public float rippleWaveNormalStrength; // 0xF4
		[Range(0f, 1f)]
		[Tooltip("\u4F4E\u4E8E\u8BE5\u7C97\u7CD9\u5EA6\u7684\u6C34\u5E73\u8868\u9762\u4F1A\u4EA7\u751F\u6D9F\u6F2A")]
		public float rippleRoughnessMaskThreshold; // 0xF8
		[Header("\u8FDC\u666F\u6F6E\u6E7F\u5EA6")]
		[Range(1f, 20f)]
		[Tooltip("\u8BE5\u8303\u56F4\u6BD4\u4F8B\u5916\u7684\u6F6E\u6E7F\u5EA6\u5C06\u88AB\u56FA\u5B9A\u503C\u8986\u76D6")]
		public float farSceneWetnessDistanceFactor; // 0xFC
		[Range(0f, 1f)]
		[Tooltip("\u8BE5\u8303\u56F4\u6BD4\u4F8B\u5916\u7684\u6F6E\u6E7F\u5EA6\u5C06\u88AB\u56FA\u5B9A\u503C\u8986\u76D6")]
		public float farSceneWetnessValue; // 0x100
		public float wetnessProceduralForWater; // 0x104
		[HideInInspector]
		public Vector3 rainDirection; // 0x108
		[HideInInspector]
		public Vector3 middleRainDirection; // 0x114
		[HideInInspector]
		public Vector3 farRainDirection; // 0x120
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x12C
		public static HGRainConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183AB7740-0x0000000183AB77A0 0x00000001831D5170-0x00000001831D51B0
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGRainConfig::get_active(HGRainConfig *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1391 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x56F )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[29]._1.element_size )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1391, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_564(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGRainConfig::set_active(HGRainConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1392, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1392, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_565(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGRainConfig(bool active) : this() {
			enable = default;
			intensity = default;
			speed = default;
			color = default;
			streakLength = default;
			horizontalRainAngle = default;
			horizontalRainLevel = default;
			sceneEffectRainJitterLevel = default;
			sceneEffectRainWidthScale = default;
			sceneEffectRainLightingPercent = default;
			rainCenterBias = default;
			middleRainLayerSpeedDiffMultiplier = default;
			middleRainAlphaMultiplier = default;
			middleHorizontalRainAngle = default;
			middleHorizontalRainLevel = default;
			middleRainLightingPercent = default;
			farRainLayerSpeedDiffMultiplier = default;
			farRainAlphaMultiplier = default;
			farRainHorizontalRainAngle = default;
			farRainHorizontalRainLevel = default;
			rainWaveVerticalSpeed = default;
			rainWaveHorizontalSpeed = default;
			rainWaveAlpha = default;
			rainWaveBottomFadeFactor = default;
			screenDropColor = default;
			screenDropMaxCountLim = default;
			screenDropMinMaxLifeTime = default;
			screenDropMinMaxSize = default;
			screenDropCentroidFadeParam = default;
			screenDropFlowPercent = default;
			screenDropMinMaxSpeed = default;
			screenDropJitterSpeedScale = default;
			rainSplashCount = default;
			rainSplashSpeed = default;
			rainSplashAlpha = default;
			rainSplashMinMaxSize = default;
			rainSplashLightingPercent = default;
			enableWetness = default;
			enableWetnessAffectSSR = default;
			wetness = default;
			wetnessBasePorosity = default;
			wetnessPorosityFactor = default;
			baseWetnessLevel = default;
			verticalWetnessScalar = default;
			verticalFlowSpeed = default;
			verticalFlowNormalStrength = default;
			verticalFlowSurfaceThreshold = default;
			verticalFlowPorosityBias = default;
			rippleFrequency = default;
			rippleNormalStrength = default;
			rippleWaveSpeed = default;
			rippleWaveNormalStrength = default;
			rippleRoughnessMaskThreshold = default;
			farSceneWetnessDistanceFactor = default;
			farSceneWetnessValue = default;
			wetnessProceduralForWater = default;
			rainDirection = default;
			middleRainDirection = default;
			farRainDirection = default;
			m_active = default;
		} // 0x000000018484DA40-0x000000018484DBB0
		// HGRainConfig(Boolean)
		void HG::Rendering::Runtime::HGRainConfig::HGRainConfig(HGRainConfig *this, bool active, MethodInfo *method)
		{
		  ITilemap *v3; // r9
		  TileAnimationData v4; // xmm1
		  __int64 v5; // rdx
		  Vector3Int *v6; // r8
		  ITilemap *v7; // r9
		  TileAnimationData v8; // xmm1
		  __int64 v9; // rdx
		  __int64 v10; // r8
		  TileAnimationData v11; // [rsp+20h] [rbp-18h] BYREF
		
		  this->m_active = 0;
		  *(_QWORD *)&this->intensity = 0LL;
		  this->enable = 0;
		  v4 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		          &v11,
		          (TileBase *)this,
		          0LL,
		          v3,
		          (MethodInfo *)v11.m_AnimatedSprites);
		  *(_QWORD *)(v5 + 28) = v6;
		  *(_QWORD *)(v5 + 36) = v6;
		  *(TileAnimationData *)(v5 + 12) = v4;
		  *(_QWORD *)(v5 + 44) = 1022739087LL;
		  *(_DWORD *)(v5 + 56) = 1065353216;
		  *(_QWORD *)(v5 + 60) = 1065353216LL;
		  *(_QWORD *)(v5 + 68) = v6;
		  *(_DWORD *)(v5 + 76) = 1065353216;
		  *(_QWORD *)(v5 + 80) = 1065353216LL;
		  *(_QWORD *)(v5 + 88) = v6;
		  *(_QWORD *)(v5 + 96) = v6;
		  *(_DWORD *)(v5 + 104) = (_DWORD)v6;
		  *(_DWORD *)(v5 + 52) = (_DWORD)v6;
		  v8 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		          &v11,
		          (TileBase *)v5,
		          v6,
		          v7,
		          (MethodInfo *)v11.m_AnimatedSprites);
		  *(_QWORD *)(v9 + 124) = v10;
		  *(TileAnimationData *)(v9 + 108) = v8;
		  *(_QWORD *)(v9 + 132) = v10;
		  *(_QWORD *)(v9 + 140) = v10;
		  *(_QWORD *)(v9 + 148) = v10;
		  *(_QWORD *)(v9 + 156) = v10;
		  *(_QWORD *)(v9 + 164) = v10;
		  *(_QWORD *)(v9 + 172) = v10;
		  *(_QWORD *)(v9 + 180) = v10;
		  *(_DWORD *)(v9 + 188) = v10;
		  *(_WORD *)(v9 + 192) = v10;
		  *(_QWORD *)(v9 + 196) = v10;
		  *(_QWORD *)(v9 + 204) = v10;
		  *(_QWORD *)(v9 + 212) = 1065353216LL;
		  *(_QWORD *)(v9 + 220) = v10;
		  *(_DWORD *)(v9 + 228) = v10;
		  *(_QWORD *)(v9 + 232) = 1065353216LL;
		  *(_QWORD *)(v9 + 240) = v10;
		  *(_DWORD *)(v9 + 248) = v10;
		  *(_QWORD *)(v9 + 264) = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		  *(_DWORD *)(v9 + 272) = 0;
		  *(_QWORD *)(v9 + 276) = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		  *(_DWORD *)(v9 + 284) = 0;
		  *(_DWORD *)(v9 + 252) = 1065353216;
		  *(_QWORD *)(v9 + 288) = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		  *(_DWORD *)(v9 + 296) = 0;
		  *(_QWORD *)(v9 + 256) = 1065353216LL;
		}
		
		static HGRainConfig() {
			defaultConfig = default;
		} // 0x000000018484D980-0x000000018484DA40
		// HGRainConfig()
		void HG::Rendering::Runtime::HGRainConfig::cctor(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  HGRainConfig__StaticFields *static_fields; // rcx
		  HGRainConfig *v3; // rax
		  __int128 v4; // xmm0
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  HGRainConfig v14; // [rsp+20h] [rbp-138h] BYREF
		
		  sub_18033B9D0(&v14, 0LL, 304LL);
		  HG::Rendering::Runtime::HGRainConfig::HGRainConfig(&v14, 0, 0LL);
		  v1 = 2LL;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGRainConfig->static_fields;
		  v3 = &v14;
		  do
		  {
		    static_fields = (HGRainConfig__StaticFields *)((char *)static_fields + 128);
		    v4 = *(_OWORD *)&v3->enable;
		    v5 = *(_OWORD *)&v3->color.g;
		    v3 = (HGRainConfig *)((char *)v3 + 128);
		    *(_OWORD *)&static_fields[-1].defaultConfig.rainSplashAlpha = v4;
		    v6 = *(_OWORD *)&v3[-1].baseWetnessLevel;
		    *(_OWORD *)&static_fields[-1].defaultConfig.enableWetness = v5;
		    v7 = *(_OWORD *)&v3[-1].verticalFlowSurfaceThreshold;
		    *(_OWORD *)&static_fields[-1].defaultConfig.baseWetnessLevel = v6;
		    v8 = *(_OWORD *)&v3[-1].rippleWaveSpeed;
		    *(_OWORD *)&static_fields[-1].defaultConfig.verticalFlowSurfaceThreshold = v7;
		    v9 = *(_OWORD *)&v3[-1].farSceneWetnessValue;
		    *(_OWORD *)&static_fields[-1].defaultConfig.rippleWaveSpeed = v8;
		    v10 = *(_OWORD *)&v3[-1].rainDirection.z;
		    *(_OWORD *)&static_fields[-1].defaultConfig.farSceneWetnessValue = v9;
		    v11 = *(_OWORD *)&v3[-1].farRainDirection.x;
		    *(_OWORD *)&static_fields[-1].defaultConfig.rainDirection.z = v10;
		    *(_OWORD *)&static_fields[-1].defaultConfig.farRainDirection.x = v11;
		    --v1;
		  }
		  while ( v1 );
		  v12 = *(_OWORD *)&v3->color.g;
		  *(_OWORD *)&static_fields->defaultConfig.enable = *(_OWORD *)&v3->enable;
		  v13 = *(_OWORD *)&v3->horizontalRainAngle;
		  *(_OWORD *)&static_fields->defaultConfig.color.g = v12;
		  *(_OWORD *)&static_fields->defaultConfig.horizontalRainAngle = v13;
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
