using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGHeightFogConfig : IEnvConfig // TypeDefIndex: 37601
	{
		// Fields
		[Header("\u542F\u7528\u9AD8\u5EA6\u96FE")]
		public bool enable; // 0x00
		[Header("\u8D77\u59CB\u9AD8\u5EA6")]
		[UnclampedRange(-500f, 500f)]
		public float heightFogStartHeight; // 0x04
		[Header("\u6D53\u5EA6")]
		[RangeExponential(0f, 1f, 3f)]
		public float heightFogDensity; // 0x08
		[Header("\u8870\u51CF")]
		[UnclampedRange(0.001f, 2f)]
		public float heightFogFalloff; // 0x0C
		[Header("\u8D77\u59CB\u9AD8\u5EA6")]
		[Range(-500f, 500f)]
		public float heightFogStartHeightSecond; // 0x10
		[Header("\u6D53\u5EA6")]
		[RangeExponential(0f, 1f, 3f)]
		public float heightFogDensitySecond; // 0x14
		[Header("\u8870\u51CF")]
		[UnclampedRange(0.001f, 2f)]
		public float heightFogFalloffSecond; // 0x18
		[ColorUsage(false, true)]
		[Header("\u6563\u5C04\uFF08\u96FE\u7684\u989C\u8272\uFF09")]
		public UnityEngine.Color heightFogInscatter; // 0x1C
		[Header("\u6700\u5927\u4E0D\u900F\u660E\u5EA6")]
		[Range(0f, 1f)]
		public float heightFogMaxOpacity; // 0x2C
		[Header("\u8D77\u59CB\u8DDD\u79BB")]
		[UnclampedRange(0f, 200f)]
		public float heightFogStartDistance; // 0x30
		[Header("\u8D77\u59CB\u533A\u57DF\u8FC7\u6E21")]
		[UnclampedRangeExponential(0.001f, 1f, 3f)]
		public float heightFogStartTransition; // 0x34
		[Header("\u7ED3\u675F\u8DDD\u79BB")]
		[UnclampedRangeExponential(0f, 200000f, 3f)]
		public float heightFogCutoffDistance; // 0x38
		[Header("\u7ED3\u675F\u533A\u57DF\u8FC7\u6E21")]
		[UnclampedRangeExponential(0.001f, 1f, 3f)]
		public float heightFogCutoffTransition; // 0x3C
		[Header("\u96FE\u88C1\u526A\u573A\u666F\u8DDD\u79BB")]
		[UnclampedRangeExponential(0.1f, 2000f, 3f)]
		public float heightFogCullingFarClipPlane; // 0x40
		[Header("\u65B9\u5411\u6563\u5C04\u8870\u51CF")]
		[Range(2f, 64f)]
		public float heightFogDirectionalInscatteringExponent; // 0x44
		[Header("\u65B9\u5411\u6563\u5C04\u8D77\u59CB\u8DDD\u79BB")]
		public float heightFogDirectionalInscatteringStartDistance; // 0x48
		[ColorUsage(false, true)]
		[Header("\u65B9\u5411\u6563\u5C04\u989C\u8272")]
		public UnityEngine.Color heightFogDirectionalInscattering; // 0x4C
		[Header("\u65B9\u5411\u6563\u5C04\u8870\u51CF\uFF08\u79FB\u52A8\u7AEF\uFF09")]
		[Range(2f, 64f)]
		public float heightFogDirectionalInscatteringExponentMobile; // 0x5C
		[ColorUsage(false, true)]
		[Header("\u65B9\u5411\u6563\u5C04\u989C\u8272\uFF08\u79FB\u52A8\u7AEF\uFF09")]
		public UnityEngine.Color heightFogDirectionalInscatteringMobile; // 0x60
		[HideInInspector]
		public bool enableVolumetricFog; // 0x70
		[HideInInspector]
		public float volumetricFogScatteringDistribution; // 0x74
		[HideInInspector]
		public UnityEngine.Color volumetricFogAlbedo; // 0x78
		[HideInInspector]
		public UnityEngine.Color volumetricFogEmissive; // 0x88
		[HideInInspector]
		public float volumetricFogExtinctionScale; // 0x98
		[HideInInspector]
		public float volumetricFogDistance; // 0x9C
		[HideInInspector]
		public float volumetricFogStartDistance; // 0xA0
		[HideInInspector]
		public float volumetricFogNearFadeInDistance; // 0xA4
		[HideInInspector]
		public float volumetricFogDirectLightingScatteringIntensity; // 0xA8
		[HideInInspector]
		public float volumetricFogSkyLightingScatteringIntensity; // 0xAC
		[Header("\u5F00\u542F\u6D41\u52A8Noise")]
		public bool enableFlowNoise; // 0xB0
		[Header("\u6D41\u52A8Noise\u5F3A\u5EA6")]
		[Range(0f, 1f)]
		public float flowNoiseIntensity; // 0xB4
		[Header("\u6D41\u52A8Noise\u6DE1\u51FA\u8DDD\u79BB")]
		[Range(10f, 1000f)]
		public float flowNoiseDistance; // 0xB8
		[Header("\u6D41\u52A8Noise\u5BC6\u5EA6")]
		[Range(0f, 0.05f)]
		public float flowNoiseTilling; // 0xBC
		[Header("\u6D41\u52A8Noise\u6C34\u5E73\u65B9\u5411")]
		[Range(0f, 360f)]
		public float flowNoiseHorizontalDirAngle; // 0xC0
		[Header("\u6D41\u52A8Noise\u5782\u76F4\u65B9\u5411")]
		[Range(-90f, 90f)]
		public float flowNoiseVerticalDirAngle; // 0xC4
		public Vector3 flowNoiseDir; // 0xC8
		[Header("\u6D41\u52A8Noise\u901F\u5EA6")]
		[Range(0f, 2f)]
		public float flowNoiseSpeed; // 0xD4
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0xD8
		public static HGHeightFogConfig defaultConfig; // 0x00
	
		// Properties
		public bool flowNoiseEnabled { get => default; } // 0x0000000183E964F0-0x0000000183E96560 
		// Boolean get_flowNoiseEnabled()
		bool HG::Rendering::Runtime::HGHeightFogConfig::get_flowNoiseEnabled(HGHeightFogConfig *this, MethodInfo *method)
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
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 1103 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x44F )
		        sub_1800D2AB0(v3, method);
		      if ( !v3[23]._1.unity_user_data )
		        return this->enable && this->enableFlowNoise;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1103, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_422(Patch, this, 0LL);
		    }
		LABEL_8:
		    sub_1800D8260(v3, method);
		  }
		  return this->enable && this->enableFlowNoise;
		}
		
		public bool active { get => default; set {} } // 0x0000000183AAD990-0x0000000183AAD9F0 0x00000001831D4FF0-0x00000001831D5030
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGHeightFogConfig::get_active(HGHeightFogConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1366 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x556 )
		    sub_1800D2AB0(v3, method);
		  if ( !*((_QWORD *)&v3[29]._0.this_arg + 1) )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1366, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_422(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGHeightFogConfig::set_active(HGHeightFogConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1367, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1367, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_542(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGHeightFogConfig(bool active) : this() {
			enable = default;
			heightFogStartHeight = default;
			heightFogDensity = default;
			heightFogFalloff = default;
			heightFogStartHeightSecond = default;
			heightFogDensitySecond = default;
			heightFogFalloffSecond = default;
			heightFogInscatter = default;
			heightFogMaxOpacity = default;
			heightFogStartDistance = default;
			heightFogStartTransition = default;
			heightFogCutoffDistance = default;
			heightFogCutoffTransition = default;
			heightFogCullingFarClipPlane = default;
			heightFogDirectionalInscatteringExponent = default;
			heightFogDirectionalInscatteringStartDistance = default;
			heightFogDirectionalInscattering = default;
			heightFogDirectionalInscatteringExponentMobile = default;
			heightFogDirectionalInscatteringMobile = default;
			enableVolumetricFog = default;
			volumetricFogScatteringDistribution = default;
			volumetricFogAlbedo = default;
			volumetricFogEmissive = default;
			volumetricFogExtinctionScale = default;
			volumetricFogDistance = default;
			volumetricFogStartDistance = default;
			volumetricFogNearFadeInDistance = default;
			volumetricFogDirectLightingScatteringIntensity = default;
			volumetricFogSkyLightingScatteringIntensity = default;
			enableFlowNoise = default;
			flowNoiseIntensity = default;
			flowNoiseDistance = default;
			flowNoiseTilling = default;
			flowNoiseHorizontalDirAngle = default;
			flowNoiseVerticalDirAngle = default;
			flowNoiseDir = default;
			flowNoiseSpeed = default;
			m_active = default;
		} // 0x0000000184990D80-0x0000000184990EE0
		// HGHeightFogConfig(Boolean)
		void HG::Rendering::Runtime::HGHeightFogConfig::HGHeightFogConfig(
		        HGHeightFogConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  Vector4 v3; // xmm1
		  __int64 v4; // rdx
		  Quaternion v5; // xmm1
		  __int64 v6; // rdx
		  Quaternion v7; // xmm1
		  __int64 v8; // rdx
		  char v9; // r8
		  Vector4 *one; // rax
		  __int64 v11; // rdx
		  Quaternion v12; // xmm1
		  __int64 v13; // rdx
		  int v14; // r8d
		  Vector4 v15; // [rsp+20h] [rbp-18h] BYREF
		
		  this->m_active = 0;
		  this->heightFogStartHeight = 0.0;
		  this->heightFogDensitySecond = 0.0;
		  this->enable = 0;
		  this->heightFogDensity = 0.02;
		  *(_QWORD *)&this->heightFogFalloff = 1045220557LL;
		  this->heightFogFalloffSecond = 0.2;
		  v3 = *UnityEngine::Vector4::get_one(&v15, (MethodInfo *)this);
		  *(_QWORD *)(v4 + 44) = 1065353216LL;
		  *(_DWORD *)(v4 + 52) = 1028443341;
		  *(Vector4 *)(v4 + 28) = v3;
		  *(_DWORD *)(v4 + 56) = 1128792064;
		  *(_DWORD *)(v4 + 60) = 1028443341;
		  *(_DWORD *)(v4 + 64) = 1203982336;
		  *(_DWORD *)(v4 + 68) = 1082130432;
		  *(_DWORD *)(v4 + 72) = 1120403456;
		  v5 = *UnityEngine::Quaternion::get_identity((Quaternion *)&v15, (MethodInfo *)v4);
		  *(_DWORD *)(v6 + 92) = 1082130432;
		  *(Quaternion *)(v6 + 76) = v5;
		  v7 = *UnityEngine::Quaternion::get_identity((Quaternion *)&v15, (MethodInfo *)v6);
		  *(_BYTE *)(v8 + 112) = v9;
		  *(_DWORD *)(v8 + 116) = 1045220557;
		  *(Quaternion *)(v8 + 96) = v7;
		  one = UnityEngine::Vector4::get_one(&v15, (MethodInfo *)v8);
		  *(Vector4 *)(v11 + 120) = *one;
		  v12 = *UnityEngine::Quaternion::get_identity((Quaternion *)&v15, (MethodInfo *)v11);
		  *(_DWORD *)(v13 + 152) = 1065353216;
		  *(_QWORD *)(v13 + 156) = 1114636288LL;
		  *(Quaternion *)(v13 + 136) = v12;
		  *(_DWORD *)(v13 + 164) = v14;
		  *(_DWORD *)(v13 + 168) = 1065353216;
		  *(_DWORD *)(v13 + 172) = 1065353216;
		  *(_BYTE *)(v13 + 176) = v14;
		  *(_DWORD *)(v13 + 180) = 1056964608;
		  *(_DWORD *)(v13 + 184) = 1114636288;
		  *(_QWORD *)(v13 + 188) = 1008981770LL;
		  *(_DWORD *)(v13 + 196) = v14;
		  *(_DWORD *)(v13 + 212) = v14;
		  *(_QWORD *)(v13 + 200) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  *(_DWORD *)(v13 + 208) = 1065353216;
		}
		
		static HGHeightFogConfig() {
			defaultConfig = default;
		} // 0x0000000184990CC0-0x0000000184990D80
		// HGHeightFogConfig()
		void HG::Rendering::Runtime::HGHeightFogConfig::cctor(MethodInfo *method)
		{
		  __int128 v1; // xmm1
		  HGHeightFogConfig__StaticFields *static_fields; // rdx
		  __int64 v3; // rax
		  __int128 v4; // xmm0
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  Color heightFogDirectionalInscatteringMobile; // xmm0
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  HGHeightFogConfig v14; // [rsp+20h] [rbp-E8h] BYREF
		
		  sub_18033B9D0(&v14, 0LL, 220LL);
		  HG::Rendering::Runtime::HGHeightFogConfig::HGHeightFogConfig(&v14, 0, 0LL);
		  v1 = *(_OWORD *)&v14.heightFogStartHeightSecond;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGHeightFogConfig->static_fields;
		  v3 = *(_QWORD *)&v14.flowNoiseDir.z;
		  *(_OWORD *)&static_fields->defaultConfig.enable = *(_OWORD *)&v14.enable;
		  v4 = *(_OWORD *)&v14.heightFogInscatter.g;
		  *(_OWORD *)&static_fields->defaultConfig.heightFogStartHeightSecond = v1;
		  v5 = *(_OWORD *)&v14.heightFogStartDistance;
		  *(_OWORD *)&static_fields->defaultConfig.heightFogInscatter.g = v4;
		  v6 = *(_OWORD *)&v14.heightFogCullingFarClipPlane;
		  *(_OWORD *)&static_fields->defaultConfig.heightFogStartDistance = v5;
		  v7 = *(_OWORD *)&v14.heightFogDirectionalInscattering.g;
		  *(_OWORD *)&static_fields->defaultConfig.heightFogCullingFarClipPlane = v6;
		  heightFogDirectionalInscatteringMobile = v14.heightFogDirectionalInscatteringMobile;
		  *(_OWORD *)&static_fields->defaultConfig.heightFogDirectionalInscattering.g = v7;
		  v9 = *(_OWORD *)&v14.volumetricFogAlbedo.b;
		  static_fields->defaultConfig.heightFogDirectionalInscatteringMobile = heightFogDirectionalInscatteringMobile;
		  static_fields = (HGHeightFogConfig__StaticFields *)((char *)static_fields + 128);
		  *(_OWORD *)&static_fields[-1].defaultConfig.flowNoiseDir.y = *(_OWORD *)&v14.enableVolumetricFog;
		  v10 = *(_OWORD *)&v14.volumetricFogEmissive.b;
		  *(_OWORD *)&static_fields->defaultConfig.enable = v9;
		  v11 = *(_OWORD *)&v14.volumetricFogStartDistance;
		  *(_OWORD *)&static_fields->defaultConfig.heightFogStartHeightSecond = v10;
		  v12 = *(_OWORD *)&v14.enableFlowNoise;
		  *(_OWORD *)&static_fields->defaultConfig.heightFogInscatter.g = v11;
		  v13 = *(_OWORD *)&v14.flowNoiseHorizontalDirAngle;
		  *(_OWORD *)&static_fields->defaultConfig.heightFogStartDistance = v12;
		  *(_OWORD *)&static_fields->defaultConfig.heightFogCullingFarClipPlane = v13;
		  *(_QWORD *)&static_fields->defaultConfig.heightFogDirectionalInscattering.g = v3;
		  static_fields->defaultConfig.heightFogDirectionalInscattering.a = *(float *)&v14.m_active;
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
