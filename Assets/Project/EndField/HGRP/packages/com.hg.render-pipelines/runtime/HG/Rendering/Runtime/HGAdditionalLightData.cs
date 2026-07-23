using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(Light))]
	public class HGAdditionalLightData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData // TypeDefIndex: 37760
	{
		// Fields
		[HideInInspector]
		public bool enableLightMeshForReflectionProbe; // 0x18
		[HideInInspector]
		public float sphericalLightRadius; // 0x1C
		[HideInInspector]
		public Texture2D areaLightCookie; // 0x20
		[HideInInspector]
		public bool debugLightMesh; // 0x28
		[HideInInspector]
		[SerializeField]
		private Vector4 m_lightNPRData; // 0x2C
		[HideInInspector]
		[SerializeField]
		private HGLightNPRType m_lightNPRType; // 0x3C
		[HideInInspector]
		[SerializeField]
		private bool m_lightNPRAdvancedParamMode; // 0x40
		[HideInInspector]
		[Range(0f, 2f)]
		[SerializeField]
		private float m_lightNPRDefaultContrast; // 0x44
		[HideInInspector]
		[SerializeField]
		private bool m_lightNPRDefaultAutoLimit; // 0x48
		[HideInInspector]
		[Range(-2f, 2f)]
		[SerializeField]
		private float m_lightNPRRampBias; // 0x4C
		[HideInInspector]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_lightNPRRampShadowDimmer; // 0x50
		[HideInInspector]
		[Range(-1f, 1f)]
		[SerializeField]
		private float m_lightNPRRampSDFBias; // 0x54
		[HideInInspector]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_lightNPRRampSDFDramatic; // 0x58
		[HideInInspector]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_lightNPRSpecMaxRoughness; // 0x5C
		[HideInInspector]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_lightNPRSpecRoughnessBias; // 0x60
		[HideInInspector]
		[SerializeField]
		private bool m_lightNPRSpecMetalOnly; // 0x64
		[HideInInspector]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_lightNPRRimWidth; // 0x68
		[HideInInspector]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_lightNPRRimAlbedoAlpha; // 0x6C
		[HideInInspector]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_lightNPRFogAlpha; // 0x70
		[HideInInspector]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_lightNPRFogFalloffFactor; // 0x74
		[HideInInspector]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_lightNPRFogRampBias; // 0x78
		[HideInInspector]
		[SerializeField]
		private bool m_lightNPRFogDirectionalFalloff; // 0x7C
		[HideInInspector]
		[SerializeField]
		private bool m_LightCharacterOnly; // 0x7D
		[HideInInspector]
		[SerializeField]
		private float m_volumetricScatteringIntensity; // 0x80
		[HideInInspector]
		[SerializeField]
		private float m_falloffExponent; // 0x84
		private Light m_light; // 0x88
	
		// Properties
		public HGLightNPRType LightNPRType { get => default; set {} } // 0x0000000189CFAFD8-0x0000000189CFB024 0x0000000189CFB270-0x0000000189CFB2D0
		// HGLightNPRType get_LightNPRType()
		HGLightNPRType__Enum HG::Rendering::Runtime::HGAdditionalLightData::get_LightNPRType(
		        HGAdditionalLightData *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1834, 0LL) )
		    return this->fields.m_lightNPRType;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1834, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_LightNPRType(HGLightNPRType)
		void HG::Rendering::Runtime::HGAdditionalLightData::set_LightNPRType(
		        HGAdditionalLightData *this,
		        HGLightNPRType__Enum value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1835, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1835, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2((ILFixDynamicMethodWrapper_30 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_lightNPRType = value;
		    HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
		  }
		}
		
		public float LightNPRRimWidth { get => default; set {} } // 0x0000000189CFAF88-0x0000000189CFAFD8 0x0000000189CFB20C-0x0000000189CFB270
		// Single get_LightNPRRimWidth()
		float HG::Rendering::Runtime::HGAdditionalLightData::get_LightNPRRimWidth(
		        HGAdditionalLightData *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1838, 0LL) )
		    return this->fields.m_lightNPRRimWidth;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1838, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_LightNPRRimWidth(Single)
		void HG::Rendering::Runtime::HGAdditionalLightData::set_LightNPRRimWidth(
		        HGAdditionalLightData *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1839, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1839, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_lightNPRRimWidth = value;
		    HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
		  }
		}
		
		public float LightNPRRimAlbedoAlpha { get => default; set {} } // 0x0000000189CFAF38-0x0000000189CFAF88 0x0000000189CFB1A8-0x0000000189CFB20C
		// Single get_LightNPRRimAlbedoAlpha()
		float HG::Rendering::Runtime::HGAdditionalLightData::get_LightNPRRimAlbedoAlpha(
		        HGAdditionalLightData *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1840, 0LL) )
		    return this->fields.m_lightNPRRimAlbedoAlpha;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1840, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_LightNPRRimAlbedoAlpha(Single)
		void HG::Rendering::Runtime::HGAdditionalLightData::set_LightNPRRimAlbedoAlpha(
		        HGAdditionalLightData *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1841, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1841, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_lightNPRRimAlbedoAlpha = value;
		    HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
		  }
		}
		
		public float LightNPRFogAlpha { get => default; set {} } // 0x0000000189CFAEE8-0x0000000189CFAF38 0x0000000189CFB144-0x0000000189CFB1A8
		// Single get_LightNPRFogAlpha()
		float HG::Rendering::Runtime::HGAdditionalLightData::get_LightNPRFogAlpha(
		        HGAdditionalLightData *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1842, 0LL) )
		    return this->fields.m_lightNPRFogAlpha;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1842, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_LightNPRFogAlpha(Single)
		void HG::Rendering::Runtime::HGAdditionalLightData::set_LightNPRFogAlpha(
		        HGAdditionalLightData *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1843, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1843, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_lightNPRFogAlpha = value;
		    HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
		  }
		}
		
		public bool LightCharacterOnly { get => default; set {} } // 0x0000000189CFAE9C-0x0000000189CFAEE8 0x0000000189CFB0E0-0x0000000189CFB144
		// Boolean get_LightCharacterOnly()
		bool HG::Rendering::Runtime::HGAdditionalLightData::get_LightCharacterOnly(
		        HGAdditionalLightData *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1844, 0LL) )
		    return this->fields.m_LightCharacterOnly;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1844, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_LightCharacterOnly(Boolean)
		void HG::Rendering::Runtime::HGAdditionalLightData::set_LightCharacterOnly(
		        HGAdditionalLightData *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1845, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1845, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_LightCharacterOnly = value;
		    HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
		  }
		}
		
		public float VolumetricScatteringIntensity { get => default; set {} } // 0x0000000189CFB024-0x0000000189CFB078 0x0000000189CFB2D0-0x0000000189CFB338
		// Single get_VolumetricScatteringIntensity()
		float HG::Rendering::Runtime::HGAdditionalLightData::get_VolumetricScatteringIntensity(
		        HGAdditionalLightData *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1846, 0LL) )
		    return this->fields.m_volumetricScatteringIntensity;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1846, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_VolumetricScatteringIntensity(Single)
		void HG::Rendering::Runtime::HGAdditionalLightData::set_VolumetricScatteringIntensity(
		        HGAdditionalLightData *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1847, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1847, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_volumetricScatteringIntensity = value;
		    HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
		  }
		}
		
		public float FalloffExponent { get => default; set {} } // 0x0000000189CFAE48-0x0000000189CFAE9C 0x0000000189CFB078-0x0000000189CFB0E0
		// Single get_FalloffExponent()
		float HG::Rendering::Runtime::HGAdditionalLightData::get_FalloffExponent(
		        HGAdditionalLightData *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1848, 0LL) )
		    return this->fields.m_falloffExponent;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1848, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_FalloffExponent(Single)
		void HG::Rendering::Runtime::HGAdditionalLightData::set_FalloffExponent(
		        HGAdditionalLightData *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1849, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1849, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_falloffExponent = value;
		    HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(this, 0LL);
		  }
		}
		
	
		// Nested types
		public struct HGAdditionalLightStreamingData // TypeDefIndex: 37759
		{
			// Fields
			public Vector4 lightNPRData; // 0x00
			public HGLightNPRType lightNPRType; // 0x10
			public bool lightNPRAdvancedParamMode; // 0x14
			public float lightNPRDefaultContrast; // 0x18
			public bool lightNPRDefaultAutoLimit; // 0x1C
			public float lightNPRRampBias; // 0x20
			public float lightNPRRampShadowDimmer; // 0x24
			public float lightNPRRampSDFBias; // 0x28
			public float lightNPRRampSDFDramatic; // 0x2C
			public float lightNPRSpecMaxRoughness; // 0x30
			public float lightNPRSpecRoughnessBias; // 0x34
			public bool lightNPRSpecMetalOnly; // 0x38
			public float lightNPRRimWidth; // 0x3C
			public float lightNPRRimAlbedoAlpha; // 0x40
			public float lightNPRFogAlpha; // 0x44
			public float lightNPRFogFalloffFactor; // 0x48
			public float lightNPRFogRampBias; // 0x4C
			public bool lightNPRFogDirectionalFalloff; // 0x50
			public bool LightCharacterOnly; // 0x51
			public float volumetricScatteringIntensity; // 0x54
			public float falloffExponent; // 0x58
		}
	
		// Constructors
		public HGAdditionalLightData() {} // 0x0000000183698F80-0x0000000183699000
		// HGAdditionalLightData()
		void HG::Rendering::Runtime::HGAdditionalLightData::HGAdditionalLightData(
		        HGAdditionalLightData *this,
		        MethodInfo *method)
		{
		  Vector3Int *v2; // r8
		  ITilemap *v3; // r9
		  TileAnimationData v4; // xmm1
		  __int64 v5; // rdx
		  TileAnimationData v6; // [rsp+20h] [rbp-18h] BYREF
		
		  this->fields.sphericalLightRadius = 0.1;
		  v4 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		          &v6,
		          (TileBase *)this,
		          v2,
		          v3,
		          (MethodInfo *)v6.m_AnimatedSprites);
		  *(_DWORD *)(v5 + 68) = 1065353216;
		  *(_BYTE *)(v5 + 72) = 1;
		  *(TileAnimationData *)(v5 + 44) = v4;
		  *(_DWORD *)(v5 + 92) = 1058642330;
		  *(_DWORD *)(v5 + 96) = 1061997773;
		  *(_BYTE *)(v5 + 100) = 1;
		  *(_DWORD *)(v5 + 104) = 1053609165;
		  *(_DWORD *)(v5 + 108) = 1065353216;
		  *(_DWORD *)(v5 + 112) = 1065353216;
		  *(_DWORD *)(v5 + 116) = 1065353216;
		  *(_DWORD *)(v5 + 132) = -1082130432;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018455E480-0x000000018455E4B0
		// Void OnBeforeSerialize()
		void HG::Rendering::Runtime::HGAdditionalLightData::OnBeforeSerialize(HGAdditionalLightData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1850, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1850, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		public void OnAfterDeserialize() {} // 0x0000000184483500-0x0000000184483530
		// Void OnAfterDeserialize()
		void HG::Rendering::Runtime::HGAdditionalLightData::OnAfterDeserialize(HGAdditionalLightData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1851, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1851, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		}
		
		public Vector4 GetLightNPRData() => default; // 0x00000001832025A0-0x00000001832026A0
		// Vector4 GetLightNPRData()
		Vector4 *HG::Rendering::Runtime::HGAdditionalLightData::GetLightNPRData(
		        Vector4 *__return_ptr retstr,
		        HGAdditionalLightData *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  int32_t m_lightNPRType; // ecx
		  float m_lightNPRRimAlbedoAlpha; // xmm0_4
		  float m_lightNPRDefaultContrast; // eax
		  Vector4 m_lightNPRData; // xmm0
		  Vector4 *result; // rax
		  float m_lightNPRRampSDFBias; // xmm1_4
		  float m_lightNPRRampSDFDramatic; // xmm2_4
		  float m_lightNPRRampBias; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  float v16; // xmm2_4
		  float m_lightNPRFogRampBias; // xmm1_4
		  float m_lightNPRFogAlpha; // eax
		  float v19; // xmm1_4
		  float m_lightNPRSpecRoughnessBias; // xmm0_4
		  Vector4 v21; // [rsp+20h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_22;
		  if ( wrapperArray->max_length.size <= 1069 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_22:
		    sub_1800D8260(v5, wrapperArray);
		  if ( LODWORD(v5->_0.namespaze) <= 0x42D )
		    sub_1800D2AB0(v5, wrapperArray);
		  if ( v5[22].vtable.Equals.methodPtr )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1069, 0LL);
		    if ( Patch )
		    {
		      m_lightNPRData = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v21, Patch, (Object *)this, 0LL);
		      goto LABEL_12;
		    }
		    goto LABEL_22;
		  }
		LABEL_5:
		  m_lightNPRType = this->fields.m_lightNPRType;
		  switch ( m_lightNPRType )
		  {
		    case 0:
		      if ( this->fields.m_lightNPRDefaultAutoLimit )
		        m_lightNPRRimAlbedoAlpha = 1.0;
		      else
		        m_lightNPRRimAlbedoAlpha = 0.0;
		      m_lightNPRDefaultContrast = this->fields.m_lightNPRDefaultContrast;
		      goto LABEL_9;
		    case 1:
		      m_lightNPRRampSDFBias = this->fields.m_lightNPRRampSDFBias;
		      m_lightNPRRampSDFDramatic = this->fields.m_lightNPRRampSDFDramatic;
		      m_lightNPRRampBias = this->fields.m_lightNPRRampBias;
		      this->fields.m_lightNPRData.y = this->fields.m_lightNPRRampShadowDimmer;
		      this->fields.m_lightNPRData.z = m_lightNPRRampSDFBias;
		      this->fields.m_lightNPRData.w = m_lightNPRRampSDFDramatic;
		      this->fields.m_lightNPRData.x = m_lightNPRRampBias;
		      break;
		    case 2:
		      if ( this->fields.m_lightNPRSpecMetalOnly )
		        v19 = 1.0;
		      else
		        v19 = 0.0;
		      m_lightNPRSpecRoughnessBias = this->fields.m_lightNPRSpecRoughnessBias;
		      this->fields.m_lightNPRData.x = this->fields.m_lightNPRSpecMaxRoughness;
		      this->fields.m_lightNPRData.w = 0.0;
		      this->fields.m_lightNPRData.y = m_lightNPRSpecRoughnessBias;
		      this->fields.m_lightNPRData.z = v19;
		      break;
		    case 3:
		      m_lightNPRRimAlbedoAlpha = this->fields.m_lightNPRRimAlbedoAlpha;
		      m_lightNPRDefaultContrast = this->fields.m_lightNPRRimWidth;
		LABEL_9:
		      this->fields.m_lightNPRData.x = m_lightNPRDefaultContrast;
		      this->fields.m_lightNPRData.y = m_lightNPRRimAlbedoAlpha;
		LABEL_10:
		      *(_QWORD *)&this->fields.m_lightNPRData.z = 0LL;
		      break;
		    case 4:
		      if ( this->fields.m_lightNPRFogDirectionalFalloff )
		        v16 = 1.0;
		      else
		        v16 = 0.0;
		      m_lightNPRFogRampBias = this->fields.m_lightNPRFogRampBias;
		      m_lightNPRFogAlpha = this->fields.m_lightNPRFogAlpha;
		      this->fields.m_lightNPRData.y = this->fields.m_lightNPRFogFalloffFactor;
		      this->fields.m_lightNPRData.w = m_lightNPRFogRampBias;
		      this->fields.m_lightNPRData.z = v16;
		      this->fields.m_lightNPRData.x = m_lightNPRFogAlpha;
		      break;
		    case 16:
		      *(_QWORD *)&this->fields.m_lightNPRData.x = 0LL;
		      goto LABEL_10;
		  }
		  m_lightNPRData = this->fields.m_lightNPRData;
		LABEL_12:
		  result = retstr;
		  *retstr = m_lightNPRData;
		  return result;
		}
		
		public HGLightAdditionalData GetlightAdditionalData() => default; // 0x00000001832024D0-0x00000001832025A0
		// HGLightAdditionalData GetlightAdditionalData()
		HGLightAdditionalData *HG::Rendering::Runtime::HGAdditionalLightData::GetlightAdditionalData(
		        HGLightAdditionalData *__return_ptr retstr,
		        HGAdditionalLightData *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  Vector4 *LightNPRData; // rax
		  float m_falloffExponent; // xmm0_4
		  float m_volumetricScatteringIntensity; // xmm2_4
		  Vector4 v10; // xmm1
		  __m128 v11; // xmm3
		  __m128 v12; // xmm3
		  __m128 v13; // xmm3
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGLightAdditionalData *v16; // rax
		  __int128 v17; // xmm1
		  Vector4 v18; // [rsp+20h] [rbp-38h] BYREF
		  HGLightAdditionalData v19; // [rsp+30h] [rbp-28h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 1068 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x42C )
		        sub_1800D2AB0(v5, this);
		      if ( !*(_QWORD *)&v5[22]._1.naturalAligment )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1068, 0LL);
		      if ( Patch )
		      {
		        v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(&v19, Patch, (Object *)this, 0LL);
		        v17 = *(_OWORD *)&v16->lightNPRType;
		        retstr->lightNPRData = v16->lightNPRData;
		        *(_OWORD *)&retstr->lightNPRType = v17;
		        return retstr;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, this);
		  }
		LABEL_5:
		  *(_OWORD *)&v19.lightNPRType = 0LL;
		  LightNPRData = HG::Rendering::Runtime::HGAdditionalLightData::GetLightNPRData(&v18, this, 0LL);
		  m_falloffExponent = this->fields.m_falloffExponent;
		  m_volumetricScatteringIntensity = this->fields.m_volumetricScatteringIntensity;
		  v10 = *LightNPRData;
		  v19.lightNPRType = this->fields.m_lightNPRType;
		  v19.LightCharacterOnly = this->fields.m_LightCharacterOnly;
		  v11 = *(__m128 *)&v19.lightNPRType;
		  retstr->lightNPRData = v10;
		  v12 = _mm_shuffle_ps(v11, v11, 147);
		  v12.m128_f32[0] = m_falloffExponent;
		  v13 = _mm_shuffle_ps(v12, v12, 39);
		  v13.m128_f32[0] = m_volumetricScatteringIntensity;
		  *(__m128 *)&retstr->lightNPRType = _mm_shuffle_ps(v13, v13, 201);
		  return retstr;
		}
		
		public void UpdateLightAdditionalData() {} // 0x0000000183D0D460-0x0000000183D0D560
		// Void UpdateLightAdditionalData()
		void HG::Rendering::Runtime::HGAdditionalLightData::UpdateLightAdditionalData(
		        HGAdditionalLightData *this,
		        MethodInfo *method)
		{
		  struct Object_1__Class *v3; // rcx
		  Light *m_light; // rbx
		  Light *v5; // rbx
		  HGLightAdditionalData *v6; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 lightNPRData; // xmm0
		  __int128 v10; // xmm1
		  void (__fastcall *v11)(Light *, _OWORD *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  _OWORD v15[2]; // [rsp+20h] [rbp-48h] BYREF
		  HGLightAdditionalData v16; // [rsp+40h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1837, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1837, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = TypeInfo::UnityEngine::Object;
		    m_light = this->fields.m_light;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v3 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v3 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( m_light )
		    {
		      if ( !v3->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v3);
		      if ( m_light->fields._._._.m_CachedPtr )
		      {
		        v5 = this->fields.m_light;
		        v6 = HG::Rendering::Runtime::HGAdditionalLightData::GetlightAdditionalData(&v16, this, 0LL);
		        if ( !v5 )
		          sub_1800D8260(v8, v7);
		        lightNPRData = v6->lightNPRData;
		        v10 = *(_OWORD *)&v6->lightNPRType;
		        v11 = (void (__fastcall *)(Light *, _OWORD *))qword_18F36F708;
		        v15[0] = lightNPRData;
		        v15[1] = v10;
		        if ( !qword_18F36F708 )
		        {
		          v11 = (void (__fastcall *)(Light *, _OWORD *))sub_180059EA0(
		                                                          "UnityEngine.Light::set_lightAdditionalData_Injected(UnityEngin"
		                                                          "e.HGLightAdditionalData&)");
		          qword_18F36F708 = (__int64)v11;
		        }
		        v11(v5, v15);
		      }
		    }
		  }
		}
		
		private void Awake() {} // 0x000000018435C140-0x000000018435C190
		// Void Awake()
		void HG::Rendering::Runtime::HGAdditionalLightData::Awake(HGAdditionalLightData *this, MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  MethodInfo *v9; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1852, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1852, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.m_light = (Light *)UnityEngine::Component::GetComponent<System::Object>(
		                                      (Component *)this,
		                                      MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::Light>);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_light, v3, v4, v5, v9);
		  }
		}
		
		private void OnEnable() {} // 0x0000000183D0D420-0x0000000183D0D460
		// Void OnEnable()
		void HG::Rendering::Runtime::HGAdditionalLightData::OnEnable(HGAdditionalLightData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1853, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1853, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGAdditionalLightData::UpdateLightAdditionalData(this, 0LL);
		  }
		}
		
		private void SetDataDirty() {} // 0x0000000189CFADF8-0x0000000189CFAE48
		// Void SetDataDirty()
		void HG::Rendering::Runtime::HGAdditionalLightData::SetDataDirty(HGAdditionalLightData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1836, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1836, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGAdditionalLightData::UpdateLightAdditionalData(this, 0LL);
		  }
		}
		
		public void InitFromStreamingData(ref HGAdditionalLightStreamingData streamingData) {} // 0x0000000183D0D560-0x0000000183D0D630
		// Void InitFromStreamingData(HGAdditionalLightData+HGAdditionalLightStreamingData ByRef)
		void HG::Rendering::Runtime::HGAdditionalLightData::InitFromStreamingData(
		        HGAdditionalLightData *this,
		        HGAdditionalLightData_HGAdditionalLightStreamingData *streamingData,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1854, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1854, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_744(Patch, (Object *)this, streamingData, 0LL);
		  }
		  else
		  {
		    this->fields.m_lightNPRData = streamingData->lightNPRData;
		    this->fields.m_lightNPRType = streamingData->lightNPRType;
		    this->fields.m_lightNPRAdvancedParamMode = streamingData->lightNPRAdvancedParamMode;
		    this->fields.m_lightNPRDefaultContrast = streamingData->lightNPRDefaultContrast;
		    this->fields.m_lightNPRDefaultAutoLimit = streamingData->lightNPRDefaultAutoLimit;
		    this->fields.m_lightNPRRampBias = streamingData->lightNPRRampBias;
		    this->fields.m_lightNPRRampShadowDimmer = streamingData->lightNPRRampShadowDimmer;
		    this->fields.m_lightNPRRampSDFBias = streamingData->lightNPRRampSDFBias;
		    this->fields.m_lightNPRRampSDFDramatic = streamingData->lightNPRRampSDFDramatic;
		    this->fields.m_lightNPRSpecMaxRoughness = streamingData->lightNPRSpecMaxRoughness;
		    this->fields.m_lightNPRSpecRoughnessBias = streamingData->lightNPRSpecRoughnessBias;
		    this->fields.m_lightNPRSpecMetalOnly = streamingData->lightNPRSpecMetalOnly;
		    this->fields.m_lightNPRRimWidth = streamingData->lightNPRRimWidth;
		    this->fields.m_lightNPRRimAlbedoAlpha = streamingData->lightNPRRimAlbedoAlpha;
		    this->fields.m_lightNPRFogAlpha = streamingData->lightNPRFogAlpha;
		    this->fields.m_lightNPRFogFalloffFactor = streamingData->lightNPRFogFalloffFactor;
		    this->fields.m_lightNPRFogRampBias = streamingData->lightNPRFogRampBias;
		    this->fields.m_lightNPRFogDirectionalFalloff = streamingData->lightNPRFogDirectionalFalloff;
		    this->fields.m_LightCharacterOnly = streamingData->LightCharacterOnly;
		    this->fields.m_volumetricScatteringIntensity = streamingData->volumetricScatteringIntensity;
		    this->fields.m_falloffExponent = streamingData->falloffExponent;
		    HG::Rendering::Runtime::HGAdditionalLightData::UpdateLightAdditionalData(this, 0LL);
		  }
		}
		
		public HGAdditionalLightStreamingData GetLightStreamingData() => default; // 0x0000000189CFAC98-0x0000000189CFADF8
		// HGAdditionalLightData+HGAdditionalLightStreamingData GetLightStreamingData()
		HGAdditionalLightData_HGAdditionalLightStreamingData *HG::Rendering::Runtime::HGAdditionalLightData::GetLightStreamingData(
		        HGAdditionalLightData_HGAdditionalLightStreamingData *__return_ptr retstr,
		        HGAdditionalLightData *this,
		        MethodInfo *method)
		{
		  float m_lightNPRDefaultContrast; // xmm0_4
		  float m_lightNPRSpecRoughnessBias; // xmm1_4
		  Vector4 v7; // xmm3
		  bool m_lightNPRAdvancedParamMode; // al
		  float m_falloffExponent; // xmm2_4
		  __int128 v10; // xmm0
		  bool m_lightNPRDefaultAutoLimit; // al
		  __int128 v12; // xmm0
		  bool m_lightNPRSpecMetalOnly; // al
		  bool m_lightNPRFogDirectionalFalloff; // al
		  bool m_LightCharacterOnly; // al
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  HGAdditionalLightData_HGAdditionalLightStreamingData *v21; // rax
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  HGAdditionalLightData_HGAdditionalLightStreamingData v27; // [rsp+20h] [rbp-60h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1855, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1855, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v20, v19);
		    v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_745(&v27, Patch, (Object *)this, 0LL);
		    v22 = *(_OWORD *)&v21->lightNPRType;
		    retstr->lightNPRData = v21->lightNPRData;
		    v23 = *(_OWORD *)&v21->lightNPRRampBias;
		    *(_OWORD *)&retstr->lightNPRType = v22;
		    v24 = *(_OWORD *)&v21->lightNPRSpecMaxRoughness;
		    *(_OWORD *)&retstr->lightNPRRampBias = v23;
		    v25 = *(_OWORD *)&v21->lightNPRRimAlbedoAlpha;
		    *(_OWORD *)&retstr->lightNPRSpecMaxRoughness = v24;
		    *(_QWORD *)&v24 = *(_QWORD *)&v21->lightNPRFogDirectionalFalloff;
		    *(float *)&v21 = v21->falloffExponent;
		    *(_OWORD *)&retstr->lightNPRRimAlbedoAlpha = v25;
		    *(_QWORD *)&retstr->lightNPRFogDirectionalFalloff = v24;
		    LODWORD(retstr->falloffExponent) = (_DWORD)v21;
		  }
		  else
		  {
		    sub_18033B9D0(&v27, 0LL, 92LL);
		    m_lightNPRDefaultContrast = this->fields.m_lightNPRDefaultContrast;
		    m_lightNPRSpecRoughnessBias = this->fields.m_lightNPRSpecRoughnessBias;
		    v7 = (Vector4)_mm_loadu_si128((const __m128i *)&this->fields.m_lightNPRData);
		    v27.lightNPRType = this->fields.m_lightNPRType;
		    m_lightNPRAdvancedParamMode = this->fields.m_lightNPRAdvancedParamMode;
		    m_falloffExponent = this->fields.m_falloffExponent;
		    v27.lightNPRDefaultContrast = m_lightNPRDefaultContrast;
		    v10 = *(_OWORD *)&this->fields.m_lightNPRRampBias;
		    v27.lightNPRAdvancedParamMode = m_lightNPRAdvancedParamMode;
		    m_lightNPRDefaultAutoLimit = this->fields.m_lightNPRDefaultAutoLimit;
		    *(_OWORD *)&v27.lightNPRRampBias = v10;
		    v27.lightNPRSpecMaxRoughness = this->fields.m_lightNPRSpecMaxRoughness;
		    v12 = *(_OWORD *)&this->fields.m_lightNPRRimWidth;
		    v27.lightNPRDefaultAutoLimit = m_lightNPRDefaultAutoLimit;
		    m_lightNPRSpecMetalOnly = this->fields.m_lightNPRSpecMetalOnly;
		    *(_OWORD *)&v27.lightNPRRimWidth = v12;
		    v27.lightNPRSpecMetalOnly = m_lightNPRSpecMetalOnly;
		    *(float *)&v12 = this->fields.m_lightNPRFogRampBias;
		    m_lightNPRFogDirectionalFalloff = this->fields.m_lightNPRFogDirectionalFalloff;
		    retstr->lightNPRData = v7;
		    v27.lightNPRFogDirectionalFalloff = m_lightNPRFogDirectionalFalloff;
		    m_LightCharacterOnly = this->fields.m_LightCharacterOnly;
		    LODWORD(v27.lightNPRFogRampBias) = v12;
		    v27.volumetricScatteringIntensity = this->fields.m_volumetricScatteringIntensity;
		    *(_OWORD *)&retstr->lightNPRType = *(_OWORD *)&v27.lightNPRType;
		    v27.LightCharacterOnly = m_LightCharacterOnly;
		    v27.lightNPRSpecRoughnessBias = m_lightNPRSpecRoughnessBias;
		    v16 = *(_OWORD *)&v27.lightNPRSpecMaxRoughness;
		    *(_OWORD *)&retstr->lightNPRRampBias = *(_OWORD *)&v27.lightNPRRampBias;
		    v17 = *(_OWORD *)&v27.lightNPRRimAlbedoAlpha;
		    *(_OWORD *)&retstr->lightNPRSpecMaxRoughness = v16;
		    *(_QWORD *)&v16 = *(_QWORD *)&v27.lightNPRFogDirectionalFalloff;
		    *(_OWORD *)&retstr->lightNPRRimAlbedoAlpha = v17;
		    *(_QWORD *)&retstr->lightNPRFogDirectionalFalloff = v16;
		    retstr->falloffExponent = m_falloffExponent;
		  }
		  return retstr;
		}
		
	}
}
