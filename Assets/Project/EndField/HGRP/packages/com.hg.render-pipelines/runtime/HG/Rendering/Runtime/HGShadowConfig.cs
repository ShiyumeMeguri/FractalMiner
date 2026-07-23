using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGShadowConfig : IEnvConfig // TypeDefIndex: 37617
	{
		// Fields
		private static UnityEngine.Color _enabledColor; // 0x00
		private static UnityEngine.Color _disabledColor; // 0x10
		private float csmDepthBias; // 0x00
		private float csmNormalBias; // 0x04
		[Header("CSM\u6DF1\u5EA6\u91C7\u6837\u504F\u79FB")]
		[Range(0f, 10f)]
		public float csmDepthBiasV2; // 0x08
		[Header("CSM\u6CD5\u7EBF\u91C7\u6837\u504F\u79FB")]
		[Range(0f, 5f)]
		public float csmNormalBiasV2; // 0x0C
		[Header("CSM\u9634\u5F71\u5F3A\u5EA6")]
		[Range(0f, 1f)]
		public float csmIntensity; // 0x10
		[Header("CSM Ramp\u8D34\u56FE")]
		public Texture2D csmRampTexture; // 0x18
		[HideInInspector]
		public float csmShadowSoftness; // 0x20
		[Header("ASM\u6295\u5F71\u573A\u666F\u6700\u4F4E\u9AD8\u5EA6 (Y)")]
		public float asmCasterMinY; // 0x24
		[Header("ASM\u6295\u5F71\u573A\u666F\u6700\u9AD8\u9AD8\u5EA6 (Y)")]
		public float asmCasterMaxY; // 0x28
		[Header("\u9634\u5F71\u5F3A\u5EA6")]
		[Range(0f, 1f)]
		public float contactShadowIntensity; // 0x2C
		[Header("\u50CF\u7D20\u539A\u5EA6\uFF08\u767E\u5206\u6BD4\uFF09")]
		[Range(0.4f, 1f)]
		public float contactShadowSurfaceThickness; // 0x30
		[Header("\u6DF1\u5EA6\u8FB9\u754C\u9608\u503C\uFF08\u767E\u5206\u6BD4\uFF09")]
		[Range(2f, 5f)]
		public float contactShadowBilinearThreshold; // 0x34
		[Header("\u9634\u5F71\u9510\u5EA6")]
		[Range(1f, 4f)]
		public int contactShadowContract; // 0x38
		[Header("\u5FFD\u7565\u8FB9\u754C\u50CF\u7D20")]
		public bool contactShadowIgnoreEdgePixels; // 0x3C
		[Header("\u662F\u5426\u5F3A\u5236\u4FEE\u6539CSM\u8FD1\u666F\u9634\u5F71\u8DDD\u79BB")]
		public bool overrideCsmFarDistanceEnabled; // 0x3D
		[Header("CSM\u8FD1\u666F\u9634\u5F71\u8DDD\u79BB Overrided")]
		[UnclampedRange(1f, 500f)]
		public float overrideCsmFarDistance; // 0x40
		[Header("\u662F\u5426\u542F\u7528\u5F3A\u5236\u8BBE\u7F6ECSM\u6E32\u67D3\u8303\u56F4\u529F\u80FD")]
		public bool manualOverrideCsmRendering; // 0x44
		[Header("\u6E32\u67D3\u7403\u4E2D\u5FC3")]
		public Vector3 overrideCsmSpherePosition; // 0x48
		[Header("\u6E32\u67D3\u7403\u534A\u5F84")]
		[Range(0.1f, 50f)]
		public float overrideCsmSphereRadius; // 0x54
		[Header("\u662F\u5426\u533A\u57DF\u5185\u5173\u95ED\u76F4\u63A5\u5149CSM\u6E32\u67D3")]
		public bool disableCsm; // 0x58
		[HideInInspector]
		public float disableCsmBlendFactor; // 0x5C
		[Header("\u533A\u57DF\u5185CSM\u6A21\u62DFAttenuation\u503C")]
		[Range(0f, 1f)]
		public float csmSimulatedAttenuation; // 0x60
		[Header("\u662F\u5426\u5173\u95EDASM\u8FDC\u666F\u9634\u5F71")]
		public bool disableAsm; // 0x64
		[Header("\u542F\u7528\u7F57\u5FB7\u5C9B\u6A21\u5F0F")]
		public bool rhodesModeEnabled; // 0x65
		[Header("\u6218\u8230\u4E2D\u5FC3\uFF08\u76F8\u673A region \u7A7A\u95F4\uFF09")]
		public Vector3 rhodesShipCenter; // 0x68
		[Header("\u6218\u8230\u534A\u5F84\uFF08\u76F8\u673A region \u7A7A\u95F4\uFF09")]
		public float rhodesShipRadius; // 0x74
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x78
		public static HGShadowConfig defaultConfig; // 0x20
	
		// Properties
		private UnityEngine.Color _overrideCsmFarDistanceColor { get => default; } // 0x0000000189CE45BC-0x0000000189CE4658 
		// Color get__overrideCsmFarDistanceColor()
		Color *HG::Rendering::Runtime::HGShadowConfig::get__overrideCsmFarDistanceColor(
		        Color *__return_ptr retstr,
		        HGShadowConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1393, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1393, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_566(&v10, Patch, this, 0LL);
		  }
		  else if ( this->overrideCsmFarDistanceEnabled )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields->_enabledColor;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields->_disabledColor;
		  }
		  *retstr = enabledColor;
		  return retstr;
		}
		
		private UnityEngine.Color _manualOverrideCsmRendering { get => default; } // 0x0000000189CE4520-0x0000000189CE45BC 
		// Color get__manualOverrideCsmRendering()
		Color *HG::Rendering::Runtime::HGShadowConfig::get__manualOverrideCsmRendering(
		        Color *__return_ptr retstr,
		        HGShadowConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1394, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1394, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_566(&v10, Patch, this, 0LL);
		  }
		  else if ( this->manualOverrideCsmRendering )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields->_enabledColor;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields->_disabledColor;
		  }
		  *retstr = enabledColor;
		  return retstr;
		}
		
		private UnityEngine.Color _disableCsmColor { get => default; } // 0x0000000189CE4484-0x0000000189CE4520 
		// Color get__disableCsmColor()
		Color *HG::Rendering::Runtime::HGShadowConfig::get__disableCsmColor(
		        Color *__return_ptr retstr,
		        HGShadowConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1395, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1395, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_566(&v10, Patch, this, 0LL);
		  }
		  else if ( this->disableCsm )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields->_enabledColor;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields->_disabledColor;
		  }
		  *retstr = enabledColor;
		  return retstr;
		}
		
		private UnityEngine.Color _disableAsmColor { get => default; } // 0x0000000189CE43E8-0x0000000189CE4484 
		// Color get__disableAsmColor()
		Color *HG::Rendering::Runtime::HGShadowConfig::get__disableAsmColor(
		        Color *__return_ptr retstr,
		        HGShadowConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1396, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1396, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_566(&v10, Patch, this, 0LL);
		  }
		  else if ( this->disableAsm )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields->_enabledColor;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields->_disabledColor;
		  }
		  *retstr = enabledColor;
		  return retstr;
		}
		
		public bool active { get => default; set {} } // 0x0000000183B5B1F0-0x0000000183B5B250 0x00000001831D51B0-0x00000001831D51F0
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGShadowConfig::get_active(HGShadowConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1397 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x575 )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[29]._1.naturalAligment )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1397, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_567(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGShadowConfig::set_active(HGShadowConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1398, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1398, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_568(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGShadowConfig(bool active) : this() {
			csmDepthBias = default;
			csmNormalBias = default;
			csmDepthBiasV2 = default;
			csmNormalBiasV2 = default;
			csmIntensity = default;
			csmRampTexture = default;
			csmShadowSoftness = default;
			asmCasterMinY = default;
			asmCasterMaxY = default;
			contactShadowIntensity = default;
			contactShadowSurfaceThickness = default;
			contactShadowBilinearThreshold = default;
			contactShadowContract = default;
			contactShadowIgnoreEdgePixels = default;
			overrideCsmFarDistanceEnabled = default;
			overrideCsmFarDistance = default;
			manualOverrideCsmRendering = default;
			overrideCsmSpherePosition = default;
			overrideCsmSphereRadius = default;
			disableCsm = default;
			disableCsmBlendFactor = default;
			csmSimulatedAttenuation = default;
			disableAsm = default;
			rhodesModeEnabled = default;
			rhodesShipCenter = default;
			rhodesShipRadius = default;
			m_active = default;
		} // 0x00000001845437E0-0x00000001845438B0
		// HGShadowConfig(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGShadowConfig::HGShadowConfig(HGShadowConfig *this, bool active, MethodInfo *method)
		{
		  __int64 v3; // r9
		  __int64 v4; // r10
		  MethodInfo *v5; // [rsp+20h] [rbp-8h]
		
		  this->m_active = 0;
		  *(_QWORD *)&this->csmDepthBiasV2 = 0LL;
		  this->csmRampTexture = 0LL;
		  this->csmIntensity = 1.0;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->csmRampTexture,
		    (HGRuntimeGrassQuery_Node *)active,
		    (HGRuntimeGrassQuery_Node *)method,
		    (Int32__Array **)this,
		    v5);
		  *(_DWORD *)(v3 + 32) = 1008981770;
		  *(_WORD *)(v3 + 60) = v4;
		  *(_QWORD *)(v3 + 72) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  *(_DWORD *)(v3 + 80) = 0;
		  *(_DWORD *)(v3 + 64) = 1092616192;
		  *(_BYTE *)(v3 + 68) = v4;
		  *(_DWORD *)(v3 + 84) = 1092616192;
		  *(_BYTE *)(v3 + 88) = v4;
		  *(_QWORD *)(v3 + 92) = v4;
		  *(_DWORD *)(v3 + 36) = -1007026176;
		  *(_DWORD *)(v3 + 40) = 1140457472;
		  *(_WORD *)(v3 + 100) = v4;
		  *(_DWORD *)(v3 + 116) = v4;
		  *(_QWORD *)(v3 + 104) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  *(_DWORD *)(v3 + 112) = 0;
		  *(_DWORD *)(v3 + 44) = 1056964608;
		  *(_DWORD *)(v3 + 48) = 1061997773;
		  *(_DWORD *)(v3 + 52) = 0x40000000;
		  *(_DWORD *)(v3 + 56) = 1;
		  *(_DWORD *)v3 = 1090519040;
		  *(_DWORD *)(v3 + 4) = 1036831949;
		}
		
		static HGShadowConfig() {
			_enabledColor = default;
			_disabledColor = default;
			defaultConfig = default;
		} // 0x00000001845436C0-0x00000001845437E0
		// HGShadowConfig()
		void HG::Rendering::Runtime::HGShadowConfig::cctor(MethodInfo *method)
		{
		  Color si128; // xmm1
		  __int128 v2; // xmm1
		  __int128 v3; // xmm2
		  HGShadowConfig__StaticFields *static_fields; // rcx
		  __int128 v5; // xmm3
		  __int128 v6; // xmm4
		  __int128 v7; // xmm5
		  __int128 v8; // xmm6
		  __int128 v9; // xmm7
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  HGShadowConfig v13; // [rsp+20h] [rbp-A8h] BYREF
		
		  si128 = (Color)_mm_load_si128((const __m128i *)&xmmword_18B959AE0);
		  TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields->_enabledColor = (Color)_mm_load_si128((const __m128i *)&xmmword_18B959AF0);
		  TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields->_disabledColor = si128;
		  memset(&v13, 0, sizeof(v13));
		  HG::Rendering::Runtime::HGShadowConfig::HGShadowConfig(&v13, 0, 0LL);
		  v2 = *(_OWORD *)&v13.csmIntensity;
		  v3 = *(_OWORD *)&v13.csmShadowSoftness;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields;
		  v5 = *(_OWORD *)&v13.contactShadowSurfaceThickness;
		  v6 = *(_OWORD *)&v13.overrideCsmFarDistance;
		  v7 = *(_OWORD *)&v13.overrideCsmSpherePosition.z;
		  v8 = *(_OWORD *)&v13.csmSimulatedAttenuation;
		  v9 = *(_OWORD *)&v13.rhodesShipCenter.z;
		  *(_OWORD *)&static_fields->defaultConfig.csmDepthBias = *(_OWORD *)&v13.csmDepthBias;
		  *(_OWORD *)&static_fields->defaultConfig.csmIntensity = v2;
		  *(_OWORD *)&static_fields->defaultConfig.csmShadowSoftness = v3;
		  *(_OWORD *)&static_fields->defaultConfig.contactShadowSurfaceThickness = v5;
		  *(_OWORD *)&static_fields->defaultConfig.overrideCsmFarDistance = v6;
		  *(_OWORD *)&static_fields->defaultConfig.overrideCsmSpherePosition.z = v7;
		  *(_OWORD *)&static_fields->defaultConfig.csmSimulatedAttenuation = v8;
		  *(_OWORD *)&static_fields->defaultConfig.rhodesShipCenter.z = v9;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowConfig->static_fields->defaultConfig.csmRampTexture,
		    v10,
		    v11,
		    v12,
		    *(MethodInfo **)&v13.csmDepthBias);
		}
		
	
		// Methods
		private void SetDisableCsmBlendFactor(bool newVal) {} // 0x0000000189CE437C-0x0000000189CE43E8
		// Void SetDisableCsmBlendFactor(Boolean)
		void HG::Rendering::Runtime::HGShadowConfig::SetDisableCsmBlendFactor(
		        HGShadowConfig *this,
		        bool newVal,
		        MethodInfo *method)
		{
		  float v5; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1399, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1399, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_568(Patch, this, newVal, 0LL);
		  }
		  else
		  {
		    if ( newVal )
		      v5 = 1.0;
		    else
		      v5 = 0.0;
		    this->disableCsmBlendFactor = v5;
		  }
		}
		
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
