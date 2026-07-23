using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGLightConfig : IEnvConfig // TypeDefIndex: 37614
	{
		// Fields
		[Header("\u76F4\u63A5\u5149 - \u989C\u8272")]
		[SerializeField]
		public UnityEngine.Color directColor; // 0x00
		[Header("\u76F4\u63A5\u5149 - \u989C\u8272\u6A21\u5F0F")]
		[SerializeField]
		public ColorMode directColorMode; // 0x10
		public UnityEngine.Color directCustomColor; // 0x14
		[Range(1000f, 15000f)]
		public float directColorTemperature; // 0x24
		[Header("\u76F4\u63A5\u5149 - \u7167\u5EA6")]
		[UnclampedRangeExponential(0f, 200000f, 3f)]
		public float directLux; // 0x28
		[Header("\u76F4\u63A5\u5149 - \u9884\u66DD\u5149 EV100")]
		[UnclampedRange(-4f, 20f)]
		public float directEV100; // 0x2C
		[Header("\u76F4\u63A5\u5149 - \u9AD8\u5149\u5F3A\u5EA6")]
		[UnclampedRange(0f, 1f)]
		public float directSpecularIntensity; // 0x30
		[Header("\u76F4\u63A5\u5149 - \u9AD8\u5149\u8303\u56F4")]
		[UnclampedRange(0f, 2f)]
		public float directSoftSourceRadius; // 0x34
		[Header("\u76F4\u63A5\u5149 - \u65B9\u5411\u6A21\u5F0F")]
		public DirectDirectionMode directDirectionMode; // 0x38
		[Header("\u76F4\u63A5\u5149 - Pitch Yaw")]
		public Vector2 directPitchYaw; // 0x3C
		[Header("\u76F4\u63A5\u5149 - TOD Yaw Offset")]
		[Range(-180f, 180f)]
		public float timeOfDayYawOffset; // 0x44
		[Header("\u76F4\u63A5\u5149 - TOD Pitch Max")]
		[Range(0f, 90f)]
		public float timeOfDayPitchMax; // 0x48
		[Header("\u95F4\u63A5\u5149 - Diffuse \u7CFB\u6570")]
		[UnclampedRange(0f, 5f)]
		public float indirectDiffuseFactor; // 0x4C
		[Header("\u95F4\u63A5\u5149 - Specular \u7CFB\u6570")]
		[UnclampedRange(0f, 5f)]
		public float indirectSpecularFactor; // 0x50
		public IndirectSpecularFactorType indirectSpecularFactorType; // 0x54
		[Header("\u5927\u6C14\u6563\u5C04\u5149\u6E90\u65B9\u5411\u6765\u6E90")]
		public PitchYawMode atmospherePitchYawMode; // 0x58
		[Header("\u5927\u6C14\u6563\u5C04\u5149\u6E90 Pitch Yaw")]
		public Vector2 atmospherePitchYaw; // 0x5C
		[Header("\u5C4F\u5E55\u5149\u675F\u5149\u6E90\u65B9\u5411\u6765\u6E90")]
		public PitchYawMode lightShaftPitchYawMode; // 0x64
		[Header("\u5C4F\u5E55\u5149\u675F\u5149\u6E90 Pitch Yaw")]
		public Vector2 lightShaftPitchYaw; // 0x68
		[Header("SunDisc\u6563\u5C04\u5149\u6E90\u65B9\u5411\u6765\u6E90")]
		public PitchYawMode sunDiscPitchYawMode; // 0x70
		[Header("SunDisc\u5927\u6C14\u6563\u5C04\u5149\u6E90 Pitch Yaw")]
		public Vector2 sunDiscPitchYaw; // 0x74
		[Header("\u955C\u5934\u5149\u6655\u5149\u6E90\u65B9\u5411\u6765\u6E90")]
		public PitchYawMode lensFlarePitchYawMode; // 0x7C
		[Header("\u955C\u5934\u5149\u6655\u5149\u6E90\u65B9\u5411\u6765\u6E90 Pitch Yaw")]
		public Vector2 lensFlarePitchYaw; // 0x80
		[Header("\u4E91\u5F71\u5149\u6E90\u65B9\u5411\u6765\u6E90")]
		public PitchYawMode cloudShadowPitchYawMode; // 0x88
		[Header("\u4E91\u5F71\u5149\u6E90\u65B9\u5411\u6765\u6E90 Pitch Yaw")]
		public Vector2 cloudShadowPitchYaw; // 0x8C
		[Header("\u9AD8\u5EA6\u96FE\u65B9\u5411\u6563\u5C04\u5149\u6E90\u65B9\u5411\u6765\u6E90")]
		public PitchYawMode heightFogDirectionalInscatteringPitchYawMode; // 0x94
		[Header("\u9AD8\u5EA6\u96FE\u65B9\u5411\u6563\u5C04\u5149\u6E90 Pitch Yaw")]
		public Vector2 heightFogDirectionalInscatteringPitchYaw; // 0x98
		[HideInInspector]
		public float preExposure; // 0xA0
		[HideInInspector]
		public float directIntensity; // 0xA4
		[HideInInspector]
		public float directIntensityDividePi; // 0xA8
		[NonSerialized]
		public Vector2 directPitchYawRuntime; // 0xAC
		[NonSerialized]
		public Quaternion rotationDirect; // 0xB4
		[HideInInspector]
		public Vector3 forwardDirect; // 0xC4
		[HideInInspector]
		public Matrix4x4 localToWorld; // 0xD0
		[HideInInspector]
		public Quaternion rotationAtmosphere; // 0x110
		[HideInInspector]
		public Quaternion rotationLightShaft; // 0x120
		[HideInInspector]
		public Quaternion rotationSunDisc; // 0x130
		[HideInInspector]
		public Quaternion rotationLensFlare; // 0x140
		[HideInInspector]
		public Quaternion rotationCloudShadow; // 0x150
		[HideInInspector]
		public Quaternion rotationHeightFogDirectionalInscattering; // 0x160
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x170
		public static HGLightConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183A6E5D0-0x0000000183A6E6D0 0x00000001831D50F0-0x00000001831D5130
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGLightConfig::get_active(HGLightConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1385 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x569 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[29]._1.unity_user_data )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1385, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_559(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGLightConfig::set_active(HGLightConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1386, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1386, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_560(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Nested types
		public enum ColorMode // TypeDefIndex: 37610
		{
			ColorTemperature = 0,
			Custom = 1,
			Mix = 2
		}
	
		public enum PitchYawMode // TypeDefIndex: 37611
		{
			DirLight = 0,
			Custom = 1
		}
	
		public enum IndirectSpecularFactorType // TypeDefIndex: 37612
		{
			FollowDiffuse = 0,
			Individual = 1
		}
	
		public enum DirectDirectionMode // TypeDefIndex: 37613
		{
			Manual = 0,
			TimeOfDay = 1
		}
	
		// Constructors
		private HGLightConfig(bool active) : this() {
			directColor = default;
			directColorMode = default;
			directCustomColor = default;
			directColorTemperature = default;
			directLux = default;
			directEV100 = default;
			directSpecularIntensity = default;
			directSoftSourceRadius = default;
			directDirectionMode = default;
			directPitchYaw = default;
			timeOfDayYawOffset = default;
			timeOfDayPitchMax = default;
			indirectDiffuseFactor = default;
			indirectSpecularFactor = default;
			indirectSpecularFactorType = default;
			atmospherePitchYawMode = default;
			atmospherePitchYaw = default;
			lightShaftPitchYawMode = default;
			lightShaftPitchYaw = default;
			sunDiscPitchYawMode = default;
			sunDiscPitchYaw = default;
			lensFlarePitchYawMode = default;
			lensFlarePitchYaw = default;
			cloudShadowPitchYawMode = default;
			cloudShadowPitchYaw = default;
			heightFogDirectionalInscatteringPitchYawMode = default;
			heightFogDirectionalInscatteringPitchYaw = default;
			preExposure = default;
			directIntensity = default;
			directIntensityDividePi = default;
			directPitchYawRuntime = default;
			rotationDirect = default;
			forwardDirect = default;
			localToWorld = default;
			rotationAtmosphere = default;
			rotationLightShaft = default;
			rotationSunDisc = default;
			rotationLensFlare = default;
			rotationCloudShadow = default;
			rotationHeightFogDirectionalInscattering = default;
			m_active = default;
		} // 0x0000000183FD1C50-0x0000000183FD1ED0
		// HGLightConfig(Boolean)
		void HG::Rendering::Runtime::HGLightConfig::HGLightConfig(HGLightConfig *this, bool active, MethodInfo *method)
		{
		  Color si128; // xmm0
		  Vector4 v5; // xmm1
		  MethodInfo *v6; // rdx
		  Quaternion *identity; // rax
		  Vector4 v8; // xmm3
		  void (__fastcall *v9)(unsigned __int64 *, Vector4 *, unsigned __int64 *, __int128 *); // rax
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		  MethodInfo *v13; // rdx
		  MethodInfo *v14; // rdx
		  MethodInfo *v15; // rdx
		  MethodInfo *v16; // rdx
		  __int64 v17; // rax
		  unsigned __int64 v18; // [rsp+30h] [rbp-39h] BYREF
		  int v19; // [rsp+38h] [rbp-31h]
		  unsigned __int64 v20; // [rsp+40h] [rbp-29h] BYREF
		  int v21; // [rsp+48h] [rbp-21h]
		  Vector4 v22; // [rsp+50h] [rbp-19h] BYREF
		  Quaternion v23; // [rsp+60h] [rbp-9h] BYREF
		  __int128 v24; // [rsp+70h] [rbp+7h] BYREF
		  __int128 v25; // [rsp+80h] [rbp+17h]
		  __int128 v26; // [rsp+90h] [rbp+27h]
		  __int128 v27; // [rsp+A0h] [rbp+37h]
		
		  si128 = (Color)_mm_load_si128((const __m128i *)&xmmword_18B9598D0);
		  this->m_active = active;
		  this->directColor = si128;
		  this->directColorMode = 0;
		  v5 = *UnityEngine::Vector4::get_one(&v22, 0LL);
		  this->directColorTemperature = 5500.0;
		  this->directLux = 120000.0;
		  this->directCustomColor = (Color)v5;
		  this->directEV100 = 12.5;
		  *(_QWORD *)&this->directSpecularIntensity = 1065353216LL;
		  *(_QWORD *)&this->directDirectionMode = v6;
		  *(_QWORD *)&this->directPitchYaw.y = v6;
		  this->timeOfDayPitchMax = 70.0;
		  this->indirectDiffuseFactor = 1.0;
		  *(_QWORD *)&this->indirectSpecularFactor = 1065353216LL;
		  this->atmospherePitchYawMode = (int)v6;
		  this->atmospherePitchYaw = (Vector2)1107296256LL;
		  this->lightShaftPitchYawMode = (int)v6;
		  this->lightShaftPitchYaw = (Vector2)1107296256LL;
		  this->sunDiscPitchYawMode = (int)v6;
		  this->sunDiscPitchYaw.x = 30.0;
		  *(_QWORD *)&this->sunDiscPitchYaw.y = 1141309440LL;
		  this->lensFlarePitchYaw = (Vector2)1107296256LL;
		  this->cloudShadowPitchYawMode = 1;
		  this->cloudShadowPitchYaw = (Vector2)1119092736LL;
		  this->heightFogDirectionalInscatteringPitchYawMode = (int)v6;
		  this->heightFogDirectionalInscatteringPitchYaw = (Vector2)1119092736LL;
		  this->preExposure = 0.00014386119;
		  this->directIntensity = 17.26335;
		  *(_QWORD *)&this->directIntensityDividePi = 1085265871LL;
		  LODWORD(this->directPitchYawRuntime.y) = (_DWORD)v6;
		  identity = UnityEngine::Quaternion::get_identity(&v23, v6);
		  v8 = (Vector4)*identity;
		  this->rotationDirect = *identity;
		  *(_QWORD *)&this->forwardDirect.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->forwardDirect.z = 1.0;
		  v9 = (void (__fastcall *)(unsigned __int64 *, Vector4 *, unsigned __int64 *, __int128 *))qword_18F36FA58;
		  v18 = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  v20 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  v19 = 1065353216;
		  v21 = 0;
		  v22 = v8;
		  v24 = 0LL;
		  v25 = 0LL;
		  v26 = 0LL;
		  v27 = 0LL;
		  if ( !qword_18F36FA58 )
		  {
		    v9 = (void (__fastcall *)(unsigned __int64 *, Vector4 *, unsigned __int64 *, __int128 *))il2cpp_resolve_icall_1(
		                                                                                               "UnityEngine.Matrix4x4::TR"
		                                                                                               "S_Injected(UnityEngine.Ve"
		                                                                                               "ctor3&,UnityEngine.Quater"
		                                                                                               "nion&,UnityEngine.Vector3"
		                                                                                               "&,UnityEngine.Matrix4x4&)");
		    if ( !v9 )
		    {
		      v17 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v17, 0LL);
		    }
		    qword_18F36FA58 = (__int64)v9;
		  }
		  v9(&v20, &v22, &v18, &v24);
		  v10 = v25;
		  *(_OWORD *)&this->localToWorld.m00 = v24;
		  v11 = v26;
		  *(_OWORD *)&this->localToWorld.m01 = v10;
		  v12 = v27;
		  *(_OWORD *)&this->localToWorld.m02 = v11;
		  *(_OWORD *)&this->localToWorld.m03 = v12;
		  this->rotationAtmosphere = *UnityEngine::Quaternion::get_identity(&v23, v13);
		  this->rotationLightShaft = *UnityEngine::Quaternion::get_identity(&v23, v14);
		  this->rotationSunDisc = *UnityEngine::Quaternion::get_identity(&v23, v15);
		  this->rotationLensFlare = *UnityEngine::Quaternion::get_identity(&v23, v16);
		  this->rotationCloudShadow = *(Quaternion *)sub_182FA5990(&v23);
		  this->rotationHeightFogDirectionalInscattering = *(Quaternion *)sub_182FA5990(&v23);
		}
		
		static HGLightConfig() {
			defaultConfig = default;
		} // 0x0000000183FD03D0-0x0000000183FD04B0
		// HGLightConfig()
		void HG::Rendering::Runtime::HGLightConfig::cctor(MethodInfo *method)
		{
		  __int64 v1; // rcx
		  HGLightConfig__StaticFields *static_fields; // rdx
		  HGLightConfig *v3; // rax
		  Color directColor; // xmm0
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  int32_t sunDiscPitchYawMode; // ecx
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  HGLightConfig v19; // [rsp+20h] [rbp-188h] BYREF
		
		  sub_18033B9D0(&v19, 0LL, 372LL);
		  HG::Rendering::Runtime::HGLightConfig::HGLightConfig(&v19, 0, 0LL);
		  v1 = 2LL;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGLightConfig->static_fields;
		  v3 = &v19;
		  do
		  {
		    static_fields = (HGLightConfig__StaticFields *)((char *)static_fields + 128);
		    directColor = v3->directColor;
		    v5 = *(_OWORD *)&v3->directColorMode;
		    v3 = (HGLightConfig *)((char *)v3 + 128);
		    *(Color *)&static_fields[-1].defaultConfig.localToWorld.m12 = directColor;
		    v6 = *(_OWORD *)&v3[-1].rotationAtmosphere.y;
		    *(_OWORD *)&static_fields[-1].defaultConfig.localToWorld.m13 = v5;
		    v7 = *(_OWORD *)&v3[-1].rotationLightShaft.y;
		    *(_OWORD *)&static_fields[-1].defaultConfig.rotationAtmosphere.y = v6;
		    v8 = *(_OWORD *)&v3[-1].rotationSunDisc.y;
		    *(_OWORD *)&static_fields[-1].defaultConfig.rotationLightShaft.y = v7;
		    v9 = *(_OWORD *)&v3[-1].rotationLensFlare.y;
		    *(_OWORD *)&static_fields[-1].defaultConfig.rotationSunDisc.y = v8;
		    v10 = *(_OWORD *)&v3[-1].rotationCloudShadow.y;
		    *(_OWORD *)&static_fields[-1].defaultConfig.rotationLensFlare.y = v9;
		    v11 = *(_OWORD *)&v3[-1].rotationHeightFogDirectionalInscattering.y;
		    *(_OWORD *)&static_fields[-1].defaultConfig.rotationCloudShadow.y = v10;
		    *(_OWORD *)&static_fields[-1].defaultConfig.rotationHeightFogDirectionalInscattering.y = v11;
		    --v1;
		  }
		  while ( v1 );
		  sunDiscPitchYawMode = v3->sunDiscPitchYawMode;
		  v13 = *(_OWORD *)&v3->directColorMode;
		  static_fields->defaultConfig.directColor = v3->directColor;
		  v14 = *(_OWORD *)&v3->directCustomColor.a;
		  *(_OWORD *)&static_fields->defaultConfig.directColorMode = v13;
		  v15 = *(_OWORD *)&v3->directSpecularIntensity;
		  *(_OWORD *)&static_fields->defaultConfig.directCustomColor.a = v14;
		  v16 = *(_OWORD *)&v3->directPitchYaw.y;
		  *(_OWORD *)&static_fields->defaultConfig.directSpecularIntensity = v15;
		  v17 = *(_OWORD *)&v3->indirectSpecularFactor;
		  *(_OWORD *)&static_fields->defaultConfig.directPitchYaw.y = v16;
		  v18 = *(_OWORD *)&v3->atmospherePitchYaw.y;
		  *(_OWORD *)&static_fields->defaultConfig.indirectSpecularFactor = v17;
		  *(_OWORD *)&static_fields->defaultConfig.atmospherePitchYaw.y = v18;
		  static_fields->defaultConfig.sunDiscPitchYawMode = sunDiscPitchYawMode;
		}
		
	
		// Methods
		public UnityEngine.Color UpdateDirectFinalColor() => default; // 0x0000000189CE41F4-0x0000000189CE4324
		// Color UpdateDirectFinalColor()
		Color *HG::Rendering::Runtime::HGLightConfig::UpdateDirectFinalColor(
		        Color *__return_ptr retstr,
		        HGLightConfig *this,
		        MethodInfo *method)
		{
		  MethodInfo *v5; // r9
		  __m128i si128; // xmm6
		  Vector4 v7; // xmm0
		  MethodInfo *v8; // r9
		  Vector4 *v9; // rax
		  float directIntensityDividePi; // xmm2_4
		  MethodInfo *v11; // r9
		  Vector4 *v12; // rax
		  float v13; // xmm2_4
		  Color v14; // xmm6
		  MethodInfo *v15; // r8
		  Color *gamma; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  Color v21; // [rsp+20h] [rbp-40h] BYREF
		  __m128i directColor; // [rsp+30h] [rbp-30h] BYREF
		  Vector4 v23; // [rsp+40h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1387, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1387, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v19, v18);
		    gamma = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_561((Color *)&v23, Patch, this, 0LL);
		    goto LABEL_11;
		  }
		  if ( UnityEngine::Rendering::GraphicsSettings::get_lightsUseLinearIntensity(0LL) )
		  {
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18B959780);
		    v7 = *(Vector4 *)sub_183C6CBA0(&directColor, this);
		    directColor = si128;
		    v21 = (Color)v7;
		    v9 = UnityEngine::Vector4::Scale(&v23, (Vector4 *)&directColor, (Vector4 *)&v21, v8);
		    directIntensityDividePi = this->directIntensityDividePi;
		    directColor = *(__m128i *)v9;
		    v12 = UnityEngine::Vector4::op_Multiply(&v23, (Vector4 *)&directColor, directIntensityDividePi, v11);
		  }
		  else
		  {
		    v13 = this->directIntensityDividePi;
		    directColor = (__m128i)this->directColor;
		    directColor = *(__m128i *)UnityEngine::Vector4::op_Multiply(&v23, (Vector4 *)&directColor, v13, v5);
		    v12 = (Vector4 *)sub_183C6CBA0(&v23, &directColor);
		  }
		  v14 = (Color)_mm_loadu_si128((const __m128i *)v12);
		  v21 = v14;
		  if ( UnityEngine::QualitySettings::get_activeColorSpace(0LL) == ColorSpace__Enum_Gamma )
		  {
		    gamma = UnityEngine::Color::get_gamma((Color *)&v23, &v21, v15);
		LABEL_11:
		    *retstr = *gamma;
		    return retstr;
		  }
		  *retstr = v14;
		  return retstr;
		}
		
		public void UpdateDirectFinalDirection(float timeOfDay) {} // 0x00000001831D46B0-0x00000001831D4A60
		// Void UpdateDirectFinalDirection(Single)
		void HG::Rendering::Runtime::HGLightConfig::UpdateDirectFinalDirection(
		        HGLightConfig *this,
		        float timeOfDay,
		        MethodInfo *method)
		{
		  MethodInfo *v3; // r9
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  float x; // xmm0_4
		  float y; // xmm6_4
		  Vector3 *v9; // rax
		  __int64 v10; // xmm3_8
		  void (__fastcall *v11)(Quaternion *, Quaternion *); // rax
		  Quaternion v12; // xmm7
		  Vector3 *v13; // rax
		  float z; // ecx
		  void (__fastcall *v15)(Quaternion *, Quaternion *, Quaternion *, __int128 *); // rax
		  MethodInfo *v16; // r9
		  bool v17; // zf
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  Quaternion rotationDirect; // xmm0
		  Quaternion v22; // xmm0
		  Quaternion v23; // xmm0
		  Quaternion v24; // xmm0
		  Vector3 *v25; // rax
		  __int64 v26; // xmm3_8
		  void (__fastcall *v27)(Quaternion *, Quaternion *); // rax
		  Quaternion v28; // xmm0
		  Quaternion v29; // xmm0
		  Vector3 *v30; // rax
		  __int64 v31; // xmm3_8
		  void (__fastcall *v32)(Quaternion *, Quaternion *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v34; // rax
		  NotImplementedException *v35; // rax
		  NotImplementedException *v36; // rbx
		  __int64 v37; // rax
		  __int64 v38; // rax
		  __int64 v39; // rax
		  __int64 v40; // rax
		  __int64 v41; // rax
		  Quaternion v42; // [rsp+30h] [rbp-69h] BYREF
		  Quaternion v43; // [rsp+40h] [rbp-59h] BYREF
		  Quaternion v44; // [rsp+50h] [rbp-49h] BYREF
		  Quaternion v45; // [rsp+60h] [rbp-39h] BYREF
		  __int128 v46; // [rsp+70h] [rbp-29h] BYREF
		  __int128 v47; // [rsp+80h] [rbp-19h]
		  __int128 v48; // [rsp+90h] [rbp-9h]
		  __int128 v49; // [rsp+A0h] [rbp+7h]
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_27;
		  if ( wrapperArray->max_length.size > 632 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( !v5 )
		      goto LABEL_27;
		    if ( LODWORD(v5->_0.namespaze) <= 0x278 )
		      sub_1800D2AB0(v5, wrapperArray);
		    if ( v5[13]._1.typeHierarchy )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(632, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_257(Patch, this, timeOfDay, 0LL);
		        return;
		      }
		      goto LABEL_27;
		    }
		  }
		  if ( this->directDirectionMode )
		  {
		    if ( this->directDirectionMode == 1 )
		    {
		      Beyond::DampingMath::cosf((Beyond::DampingMath *)v5, timeOfDay);
		      x = (float)-(float)((float)((float)(timeOfDay / 24.0) * 3.1415927) + (float)((float)(timeOfDay / 24.0) * 3.1415927))
		        * this->timeOfDayPitchMax;
		      y = (float)((float)(timeOfDay / 24.0) * 360.0) + this->timeOfDayYawOffset;
		      goto LABEL_7;
		    }
		    v34 = sub_180035ED0(&TypeInfo::System::NotImplementedException);
		    v35 = (NotImplementedException *)sub_1800368D0(v34);
		    v36 = v35;
		    if ( v35 )
		    {
		      System::NotImplementedException::NotImplementedException(v35, 0LL);
		      v37 = sub_180035ED0(&MethodInfo::HG::Rendering::Runtime::HGLightConfig::UpdateDirectFinalDirection);
		      sub_18007E190(v36, v37);
		    }
		LABEL_27:
		    sub_1800D8260(v5, wrapperArray);
		  }
		  x = this->directPitchYaw.x;
		  y = this->directPitchYaw.y;
		LABEL_7:
		  this->directPitchYawRuntime.x = x;
		  this->directPitchYawRuntime.y = y;
		  *(_QWORD *)&v42.x = _mm_unpacklo_ps(
		                        (__m128)LODWORD(this->directPitchYawRuntime.x),
		                        (__m128)LODWORD(this->directPitchYawRuntime.y)).m128_u64[0];
		  v42.z = 0.0;
		  v9 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v43, (Vector3 *)&v42, 0.017453292, v3);
		  v44 = 0LL;
		  v10 = *(_QWORD *)&v9->x;
		  v42.z = v9->z;
		  v11 = (void (__fastcall *)(Quaternion *, Quaternion *))qword_18F36FAC8;
		  *(_QWORD *)&v42.x = v10;
		  if ( !qword_18F36FAC8 )
		  {
		    v11 = (void (__fastcall *)(Quaternion *, Quaternion *))il2cpp_resolve_icall_1(
		                                                             "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(Unit"
		                                                             "yEngine.Vector3&,UnityEngine.Quaternion&)");
		    if ( !v11 )
		    {
		      v38 = sub_1802EE1B8("UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
		      sub_18007E1B0(v38, 0LL);
		    }
		    qword_18F36FAC8 = (__int64)v11;
		  }
		  v11(&v42, &v44);
		  v12 = v44;
		  this->rotationDirect = v44;
		  v42.z = 1.0;
		  *(_QWORD *)&v42.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  v43 = v12;
		  v13 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v44, &v43, (Vector3 *)&v42, 0LL);
		  z = v13->z;
		  *(_QWORD *)&this->forwardDirect.x = *(_QWORD *)&v13->x;
		  this->forwardDirect.z = z;
		  v15 = (void (__fastcall *)(Quaternion *, Quaternion *, Quaternion *, __int128 *))qword_18F36FA58;
		  *(_QWORD *)&v42.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  *(_QWORD *)&v43.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  v45 = v12;
		  v42.z = 1.0;
		  v43.z = 0.0;
		  v46 = 0LL;
		  v47 = 0LL;
		  v48 = 0LL;
		  v49 = 0LL;
		  if ( !qword_18F36FA58 )
		  {
		    v15 = (void (__fastcall *)(Quaternion *, Quaternion *, Quaternion *, __int128 *))il2cpp_resolve_icall_1(
		                                                                                       "UnityEngine.Matrix4x4::TRS_Inject"
		                                                                                       "ed(UnityEngine.Vector3&,UnityEngi"
		                                                                                       "ne.Quaternion&,UnityEngine.Vector"
		                                                                                       "3&,UnityEngine.Matrix4x4&)");
		    if ( !v15 )
		    {
		      v39 = sub_1802EE1B8(
		              "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Unit"
		              "yEngine.Matrix4x4&)");
		      sub_18007E1B0(v39, 0LL);
		    }
		    qword_18F36FA58 = (__int64)v15;
		  }
		  v15(&v43, &v45, &v42, &v46);
		  v17 = this->atmospherePitchYawMode == 0;
		  v18 = v47;
		  *(_OWORD *)&this->localToWorld.m00 = v46;
		  v19 = v48;
		  *(_OWORD *)&this->localToWorld.m01 = v18;
		  v20 = v49;
		  *(_OWORD *)&this->localToWorld.m02 = v19;
		  *(_OWORD *)&this->localToWorld.m03 = v20;
		  if ( v17 )
		  {
		    rotationDirect = this->rotationDirect;
		  }
		  else
		  {
		    *(_QWORD *)&v43.x = _mm_unpacklo_ps(
		                          (__m128)LODWORD(this->atmospherePitchYaw.x),
		                          (__m128)LODWORD(this->atmospherePitchYaw.y)).m128_u64[0];
		    v43.z = 0.0;
		    v30 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v44, (Vector3 *)&v43, 0.017453292, v16);
		    v42 = 0LL;
		    v31 = *(_QWORD *)&v30->x;
		    v43.z = v30->z;
		    v32 = (void (__fastcall *)(Quaternion *, Quaternion *))qword_18F36FAC8;
		    *(_QWORD *)&v43.x = v31;
		    if ( !qword_18F36FAC8 )
		    {
		      v32 = (void (__fastcall *)(Quaternion *, Quaternion *))il2cpp_resolve_icall_1(
		                                                               "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(Un"
		                                                               "ityEngine.Vector3&,UnityEngine.Quaternion&)");
		      if ( !v32 )
		      {
		        v40 = sub_1802EE1B8("UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
		        sub_18007E1B0(v40, 0LL);
		      }
		      qword_18F36FAC8 = (__int64)v32;
		    }
		    v32(&v43, &v42);
		    rotationDirect = v42;
		  }
		  this->rotationAtmosphere = rotationDirect;
		  if ( this->lightShaftPitchYawMode )
		    v22 = *(Quaternion *)sub_182FA5990(&v45);
		  else
		    v22 = this->rotationDirect;
		  this->rotationLightShaft = v22;
		  if ( this->sunDiscPitchYawMode )
		    v23 = *(Quaternion *)sub_182FA5990(&v45);
		  else
		    v23 = this->rotationDirect;
		  this->rotationSunDisc = v23;
		  if ( this->lensFlarePitchYawMode )
		    v24 = *(Quaternion *)sub_182FA5990(&v45);
		  else
		    v24 = this->rotationDirect;
		  this->rotationLensFlare = v24;
		  if ( this->cloudShadowPitchYawMode )
		  {
		    *(_QWORD *)&v43.x = _mm_unpacklo_ps(
		                          (__m128)LODWORD(this->cloudShadowPitchYaw.x),
		                          (__m128)LODWORD(this->cloudShadowPitchYaw.y)).m128_u64[0];
		    v43.z = 0.0;
		    v25 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v44, (Vector3 *)&v43, 0.017453292, v16);
		    v42 = 0LL;
		    v26 = *(_QWORD *)&v25->x;
		    v43.z = v25->z;
		    v27 = (void (__fastcall *)(Quaternion *, Quaternion *))qword_18F36FAC8;
		    *(_QWORD *)&v43.x = v26;
		    if ( !qword_18F36FAC8 )
		    {
		      v27 = (void (__fastcall *)(Quaternion *, Quaternion *))il2cpp_resolve_icall_1(
		                                                               "UnityEngine.Quaternion::Internal_FromEulerRad_Injected(Un"
		                                                               "ityEngine.Vector3&,UnityEngine.Quaternion&)");
		      if ( !v27 )
		      {
		        v41 = sub_1802EE1B8("UnityEngine.Quaternion::Internal_FromEulerRad_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
		        sub_18007E1B0(v41, 0LL);
		      }
		      qword_18F36FAC8 = (__int64)v27;
		    }
		    v27(&v43, &v42);
		    v28 = v42;
		  }
		  else
		  {
		    v28 = this->rotationDirect;
		  }
		  this->rotationCloudShadow = v28;
		  if ( this->heightFogDirectionalInscatteringPitchYawMode )
		    v29 = *(Quaternion *)sub_182FA5990(&v45);
		  else
		    v29 = this->rotationDirect;
		  this->rotationHeightFogDirectionalInscattering = v29;
		}
		
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
		public LensFlareCommonSRP.SunSourceDirLightOverrideLightData ToDirLightOverrideData() => default; // 0x0000000183CE51C0-0x0000000183CE5280
		// LensFlareCommonSRP+SunSourceDirLightOverrideLightData ToDirLightOverrideData()
		LensFlareCommonSRP_SunSourceDirLightOverrideLightData *HG::Rendering::Runtime::HGLightConfig::ToDirLightOverrideData(
		        LensFlareCommonSRP_SunSourceDirLightOverrideLightData *__return_ptr retstr,
		        HGLightConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  Quaternion rotationLensFlare; // xmm0
		  __m128i directColor; // xmm2
		  double v9; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  LensFlareCommonSRP_SunSourceDirLightOverrideLightData *v12; // rax
		  __int128 v13; // xmm1
		  __int64 v14; // xmm0_8
		  LensFlareCommonSRP_SunSourceDirLightOverrideLightData v15; // [rsp+20h] [rbp-38h] BYREF
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  memset(&v15, 0, sizeof(v15));
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 1117 )
		  {
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = (struct ILFixDynamicMethodWrapper_2__Class *)v4->static_fields->wrapperArray;
		    if ( v4 )
		    {
		      if ( LODWORD(v4->_0.namespaze) <= 0x45D )
		        sub_1800D2AB0(v4, this);
		      if ( !v4[23].vtable.Equals.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1117, 0LL);
		      if ( Patch )
		      {
		        v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_424(&v15, Patch, this, 0LL);
		        v13 = *(_OWORD *)&v12->dirLightFoward.x;
		        retstr->rotationLensFlare = v12->rotationLensFlare;
		        v14 = *(_QWORD *)&v12->color.g;
		        *(float *)&v12 = v12->color.a;
		        *(_OWORD *)&retstr->dirLightFoward.x = v13;
		        *(_QWORD *)&retstr->color.g = v14;
		        LODWORD(retstr->color.a) = (_DWORD)v12;
		        return retstr;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v4, this);
		  }
		LABEL_5:
		  rotationLensFlare = this->rotationLensFlare;
		  directColor = (__m128i)this->directColor;
		  v15.dirLightFoward.z = this->forwardDirect.z;
		  v9 = *(double *)&this->forwardDirect.x;
		  retstr->rotationLensFlare = rotationLensFlare;
		  v15.color = (Color)directColor;
		  *(_QWORD *)&rotationLensFlare.z = *(_QWORD *)&v15.dirLightFoward.z;
		  *(double *)&rotationLensFlare.x = v9;
		  *(Quaternion *)&retstr->dirLightFoward.x = rotationLensFlare;
		  *(_QWORD *)&retstr->color.g = *(_QWORD *)&v15.color.g;
		  LODWORD(retstr->color.a) = _mm_cvtsi128_si32(_mm_srli_si128(directColor, 12));
		  return retstr;
		}
		
	}
}
