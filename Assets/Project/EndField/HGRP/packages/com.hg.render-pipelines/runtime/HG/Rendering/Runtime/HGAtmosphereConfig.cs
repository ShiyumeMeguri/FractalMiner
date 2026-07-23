using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGAtmosphereConfig : IEnvConfig // TypeDefIndex: 37584
	{
		// Fields
		[Header("\u884C\u661F\u53C2\u6570")]
		[RangeExponential(1f, 7000f, 5f)]
		public float groundRadius; // 0x00
		public UnityEngine.Color groundAlbedo; // 0x04
		[Header("\u5927\u6C14\u53C2\u6570")]
		public UnityEngine.Color outerSunIrradianceColor; // 0x14
		[RangeExponential(1f, 200f, 2f)]
		public float atmosphereHeight; // 0x24
		[Range(0f, 1f)]
		public float multiScatteringFactor; // 0x28
		[Header("\u745E\u5229\u6563\u5C04")]
		[RangeExponential(0f, 2f, 4f)]
		public float rayleighScatteringScale; // 0x2C
		public UnityEngine.Color rayleighScattering; // 0x30
		[RangeExponential(0.01f, 20f, 5f)]
		public float rayleighExponentialDistribution; // 0x40
		[Header("\u7C73\u6C0F\u6563\u5C04")]
		[RangeExponential(0f, 5f, 4f)]
		public float mieScatteringScale; // 0x44
		public UnityEngine.Color mieScattering; // 0x48
		[RangeExponential(0f, 2f, 4f)]
		public float mieAbsorptionScale; // 0x58
		public UnityEngine.Color mieAbsorption; // 0x5C
		[Range(0f, 0.999f)]
		public float mieAnisotropy; // 0x6C
		[RangeExponential(0.01f, 10f, 5f)]
		public float mieExponentialDistribution; // 0x70
		[Header("\u81ED\u6C27\u5C42")]
		[RangeExponential(0f, 0.2f, 3f)]
		public float ozoneAbsorptionScale; // 0x74
		public UnityEngine.Color ozoneAbsorption; // 0x78
		[Range(0f, 60f)]
		public float tentTipAltitude; // 0x88
		[RangeExponential(0f, 1f, 4f)]
		public float tentTipValue; // 0x8C
		[Range(0.01f, 20f)]
		public float tentWidth; // 0x90
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x94
		public static HGAtmosphereConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183B5A4C0-0x0000000183B5A520 0x00000001831D4E70-0x00000001831D4EB0
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGAtmosphereConfig::get_active(HGAtmosphereConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1323 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x52B )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[28]._0.parent )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1323, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_511(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGAtmosphereConfig::set_active(HGAtmosphereConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1324, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1324, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_512(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGAtmosphereConfig(bool active) : this() {
			groundRadius = default;
			groundAlbedo = default;
			outerSunIrradianceColor = default;
			atmosphereHeight = default;
			multiScatteringFactor = default;
			rayleighScatteringScale = default;
			rayleighScattering = default;
			rayleighExponentialDistribution = default;
			mieScatteringScale = default;
			mieScattering = default;
			mieAbsorptionScale = default;
			mieAbsorption = default;
			mieAnisotropy = default;
			mieExponentialDistribution = default;
			ozoneAbsorptionScale = default;
			ozoneAbsorption = default;
			tentTipAltitude = default;
			tentTipValue = default;
			tentWidth = default;
			m_active = default;
		} // 0x0000000184A30950-0x0000000184A30A20
		// HGAtmosphereConfig(Boolean)
		void HG::Rendering::Runtime::HGAtmosphereConfig::HGAtmosphereConfig(
		        HGAtmosphereConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  Quaternion *identity; // rax
		  __int64 v4; // rdx
		  Vector4 *one; // rax
		  __m128i si128; // xmm0
		  Vector4 v7; // xmm1
		  __int64 v8; // rdx
		  Vector4 *v9; // rax
		  __m128i v10; // xmm0
		  Vector4 v11; // xmm1
		  __int64 v12; // rdx
		  __m128i v13; // xmm0
		  Vector4 v14; // [rsp+20h] [rbp-18h] BYREF
		
		  this->m_active = 0;
		  this->groundRadius = 6360.0;
		  identity = UnityEngine::Quaternion::get_identity((Quaternion *)&v14, (MethodInfo *)this);
		  *(Quaternion *)(v4 + 4) = *identity;
		  one = UnityEngine::Vector4::get_one(&v14, (MethodInfo *)v4);
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959CC0);
		  v7 = *one;
		  *(_DWORD *)(v8 + 36) = 1114636288;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  *(Vector4 *)(v8 + 20) = v7;
		  *(_DWORD *)(v8 + 44) = 1023906782;
		  *(__m128i *)(v8 + 48) = si128;
		  *(_DWORD *)(v8 + 64) = 1090519040;
		  *(_DWORD *)(v8 + 68) = 998437089;
		  v9 = UnityEngine::Vector4::get_one(&v14, (MethodInfo *)v8);
		  v10 = _mm_load_si128((const __m128i *)&xmmword_18B959780);
		  v11 = *v9;
		  *(_DWORD *)(v12 + 88) = 971557036;
		  *(__m128i *)(v12 + 92) = v10;
		  *(_DWORD *)(v12 + 108) = 1061997773;
		  v13 = _mm_load_si128((const __m128i *)&xmmword_18B959CD0);
		  *(Vector4 *)(v12 + 72) = v11;
		  *(_DWORD *)(v12 + 112) = 1067030938;
		  *(__m128i *)(v12 + 120) = v13;
		  *(_DWORD *)(v12 + 116) = 989236195;
		  *(_DWORD *)(v12 + 136) = 1103626240;
		  *(_DWORD *)(v12 + 140) = 1065353216;
		  *(_DWORD *)(v12 + 144) = 1097859072;
		}
		
		static HGAtmosphereConfig() {
			defaultConfig = default;
		} // 0x0000000184A30870-0x0000000184A30950
		// HGAtmosphereConfig()
		void HG::Rendering::Runtime::HGAtmosphereConfig::cctor(MethodInfo *method)
		{
		  __int128 v1; // xmm1
		  HGAtmosphereConfig__StaticFields *static_fields; // rcx
		  __int128 v3; // xmm0
		  Color rayleighScattering; // xmm1
		  __int128 v5; // xmm0
		  __int128 v6; // xmm1
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  HGAtmosphereConfig v10; // [rsp+20h] [rbp-A8h] BYREF
		
		  memset(&v10, 0, sizeof(v10));
		  HG::Rendering::Runtime::HGAtmosphereConfig::HGAtmosphereConfig(&v10, 0, 0LL);
		  v1 = *(_OWORD *)&v10.groundAlbedo.a;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGAtmosphereConfig->static_fields;
		  *(_OWORD *)&static_fields->defaultConfig.groundRadius = *(_OWORD *)&v10.groundRadius;
		  v3 = *(_OWORD *)&v10.outerSunIrradianceColor.a;
		  *(_OWORD *)&static_fields->defaultConfig.groundAlbedo.a = v1;
		  rayleighScattering = v10.rayleighScattering;
		  *(_OWORD *)&static_fields->defaultConfig.outerSunIrradianceColor.a = v3;
		  v5 = *(_OWORD *)&v10.rayleighExponentialDistribution;
		  static_fields->defaultConfig.rayleighScattering = rayleighScattering;
		  v6 = *(_OWORD *)&v10.mieScattering.b;
		  *(_OWORD *)&static_fields->defaultConfig.rayleighExponentialDistribution = v5;
		  v7 = *(_OWORD *)&v10.mieAbsorption.g;
		  *(_OWORD *)&static_fields->defaultConfig.mieScattering.b = v6;
		  v8 = *(_OWORD *)&v10.mieExponentialDistribution;
		  *(_OWORD *)&static_fields->defaultConfig.mieAbsorption.g = v7;
		  v9 = *(_OWORD *)&v10.ozoneAbsorption.b;
		  *(_OWORD *)&static_fields->defaultConfig.mieExponentialDistribution = v8;
		  *(_QWORD *)&v8 = *(_QWORD *)&v10.tentWidth;
		  *(_OWORD *)&static_fields->defaultConfig.ozoneAbsorption.b = v9;
		  *(_QWORD *)&static_fields->defaultConfig.tentWidth = v8;
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
