using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGColorGradingConfig : IEnvConfig // TypeDefIndex: 37599
	{
		// Fields
		private static UnityEngine.Color _enabledColor; // 0x00
		private static UnityEngine.Color _disabledColor; // 0x10
		[Header("\u8272\u8C03\u6620\u5C04\u6A21\u5F0F")]
		[SerializeField]
		public TonemappingMode tonemappingMode; // 0x00
		[Header("\u542F\u7528Color Lookup")]
		public bool colorLookupEnabled; // 0x04
		[Header("LUT")]
		public Texture2D colorLookupTexture; // 0x08
		[Header("Contribution")]
		[Range(0f, 1f)]
		public float colorLookupContribution; // 0x10
		[Header("\u542F\u7528White Balance")]
		public bool whiteBalanceEnabled; // 0x14
		[Header("\u8272\u6E29")]
		[Range(-100f, 100f)]
		public float whiteBalanceTemperature; // 0x18
		[Header("\u8272\u5F69\u8865\u507F")]
		[Range(-100f, 100f)]
		public float whiteBalanceTint; // 0x1C
		[Header("\u542F\u7528Color Adjustments")]
		public bool colorAdjustmentsEnabled; // 0x20
		[Header("\u573A\u666F\u66DD\u5149\u8C03\u6574")]
		[Range(-16f, 16f)]
		public float colorAdjustmentsPostExposure; // 0x24
		[Header("\u5BF9\u6BD4\u5EA6")]
		[Range(-100f, 100f)]
		public float colorAdjustmentsContrast; // 0x28
		[ColorUsage(false, true)]
		[Header("\u504F\u8272\u8FC7\u6EE4")]
		public UnityEngine.Color colorAdjustmentsColorFilter; // 0x2C
		[Header("\u8272\u76F8\u504F\u79FB")]
		[Range(-180f, 180f)]
		public float colorAdjustmentsHueShift; // 0x3C
		[Header("\u9971\u548C\u5EA6")]
		[Range(-100f, 100f)]
		public float colorAdjustmentsSaturation; // 0x40
		[Header("\u542F\u7528Channel Mixer")]
		public bool channelMixerEnabled; // 0x44
		[Header("Red")]
		[Range(-200f, 200f)]
		public float channelMixerRedOutRedIn; // 0x48
		[Header("Green")]
		[Range(-200f, 200f)]
		public float channelMixerRedOutGreenIn; // 0x4C
		[Header("Blue")]
		[Range(-200f, 200f)]
		public float channelMixerRedOutBlueIn; // 0x50
		[Header("Red")]
		[Range(-200f, 200f)]
		public float channelMixerGreenOutRedIn; // 0x54
		[Header("Green")]
		[Range(-200f, 200f)]
		public float channelMixerGreenOutGreenIn; // 0x58
		[Header("Blue")]
		[Range(-200f, 200f)]
		public float channelMixerGreenOutBlueIn; // 0x5C
		[Header("Red")]
		[Range(-200f, 200f)]
		public float channelMixerBlueOutRedIn; // 0x60
		[Header("Green")]
		[Range(-200f, 200f)]
		public float channelMixerBlueOutGreenIn; // 0x64
		[Header("Blue")]
		[Range(-200f, 200f)]
		public float channelMixerBlueOutBlueIn; // 0x68
		[Header("\u542F\u7528ShadowsMidtonesHighlights")]
		public bool shadowsMidtonesHighlightsEnabled; // 0x6C
		public HGShadowsMidtonesHighlights shadowsMidtonesHighlights; // 0x70
		[Header("\u542F\u7528LiftGammaGain")]
		public bool liftGammaGainEnabled; // 0xB8
		public HGLiftGammaGain liftGammaGain; // 0xBC
		[Header("\u542F\u7528Split Toning")]
		public bool splitToningEnabled; // 0xF0
		[ColorUsage(false)]
		[Header("\u9634\u5F71\u8272\u8C03")]
		public UnityEngine.Color splitToningShadows; // 0xF4
		[ColorUsage(false)]
		[Header("\u9AD8\u5149\u8272\u8C03")]
		public UnityEngine.Color splitToningHighlights; // 0x104
		[Header("\u8272\u8C03\u5E73\u8861")]
		[Range(-100f, 100f)]
		public float splitToningBalance; // 0x114
		[Header("\u542F\u7528Color Curves")]
		public bool colorCurvesEnabled; // 0x118
		public HGColorCurve colorCurves; // 0x120
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x168
		public static HGColorGradingConfig defaultConfig; // 0x20
	
		// Properties
		private UnityEngine.Color _tonemappingColor { get => default; } // 0x0000000189C6EA94-0x0000000189C6EB14 
		// Color get__tonemappingColor()
		Color *HG::Rendering::Runtime::HGColorGradingConfig::get__tonemappingColor(
		        Color *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color *result; // rax
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1351, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1351, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_386(&v10, Patch, this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_enabledColor;
		  }
		  result = retstr;
		  *retstr = enabledColor;
		  return result;
		}
		
		private UnityEngine.Color _colorLookupColor { get => default; } // 0x0000000189C6E81C-0x0000000189C6E8B8 
		// Color get__colorLookupColor()
		Color *HG::Rendering::Runtime::HGColorGradingConfig::get__colorLookupColor(
		        Color *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1352, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1352, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_386(&v10, Patch, this, 0LL);
		  }
		  else if ( this->colorLookupEnabled )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_enabledColor;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_disabledColor;
		  }
		  *retstr = enabledColor;
		  return retstr;
		}
		
		private UnityEngine.Color _whiteBalanceColor { get => default; } // 0x0000000189C6EB14-0x0000000189C6EBB0 
		// Color get__whiteBalanceColor()
		Color *HG::Rendering::Runtime::HGColorGradingConfig::get__whiteBalanceColor(
		        Color *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1353, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1353, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_386(&v10, Patch, this, 0LL);
		  }
		  else if ( this->whiteBalanceEnabled )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_enabledColor;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_disabledColor;
		  }
		  *retstr = enabledColor;
		  return retstr;
		}
		
		private UnityEngine.Color _colorAdjustmentsColor { get => default; } // 0x0000000189C6E6E0-0x0000000189C6E77C 
		// Color get__colorAdjustmentsColor()
		Color *HG::Rendering::Runtime::HGColorGradingConfig::get__colorAdjustmentsColor(
		        Color *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1354, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1354, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_386(&v10, Patch, this, 0LL);
		  }
		  else if ( this->colorAdjustmentsEnabled )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_enabledColor;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_disabledColor;
		  }
		  *retstr = enabledColor;
		  return retstr;
		}
		
		private UnityEngine.Color _channelMixerColor { get => default; } // 0x0000000189C6E644-0x0000000189C6E6E0 
		// Color get__channelMixerColor()
		Color *HG::Rendering::Runtime::HGColorGradingConfig::get__channelMixerColor(
		        Color *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1355, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1355, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_386(&v10, Patch, this, 0LL);
		  }
		  else if ( this->channelMixerEnabled )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_enabledColor;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_disabledColor;
		  }
		  *retstr = enabledColor;
		  return retstr;
		}
		
		private UnityEngine.Color _shadowsMidtonesHighlightsColor { get => default; } // 0x0000000189C6E958-0x0000000189C6E9F4 
		// Color get__shadowsMidtonesHighlightsColor()
		Color *HG::Rendering::Runtime::HGColorGradingConfig::get__shadowsMidtonesHighlightsColor(
		        Color *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1356, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1356, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_386(&v10, Patch, this, 0LL);
		  }
		  else if ( this->shadowsMidtonesHighlightsEnabled )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_enabledColor;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_disabledColor;
		  }
		  *retstr = enabledColor;
		  return retstr;
		}
		
		private UnityEngine.Color _liftGammaGainColor { get => default; } // 0x0000000189C6E8B8-0x0000000189C6E958 
		// Color get__liftGammaGainColor()
		Color *HG::Rendering::Runtime::HGColorGradingConfig::get__liftGammaGainColor(
		        Color *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1357, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1357, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_386(&v10, Patch, this, 0LL);
		  }
		  else if ( this->liftGammaGainEnabled )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_enabledColor;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_disabledColor;
		  }
		  *retstr = enabledColor;
		  return retstr;
		}
		
		private UnityEngine.Color _splitToningColor { get => default; } // 0x0000000189C6E9F4-0x0000000189C6EA94 
		// Color get__splitToningColor()
		Color *HG::Rendering::Runtime::HGColorGradingConfig::get__splitToningColor(
		        Color *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1358, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1358, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_386(&v10, Patch, this, 0LL);
		  }
		  else if ( this->splitToningEnabled )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_enabledColor;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_disabledColor;
		  }
		  *retstr = enabledColor;
		  return retstr;
		}
		
		private UnityEngine.Color _colorCurvesColor { get => default; } // 0x0000000189C6E77C-0x0000000189C6E81C 
		// Color get__colorCurvesColor()
		Color *HG::Rendering::Runtime::HGColorGradingConfig::get__colorCurvesColor(
		        Color *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  Color enabledColor; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1359, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1359, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    enabledColor = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_386(&v10, Patch, this, 0LL);
		  }
		  else if ( this->colorCurvesEnabled )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_enabledColor;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		    enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_disabledColor;
		  }
		  *retstr = enabledColor;
		  return retstr;
		}
		
		public bool active { get => default; set {} } // 0x0000000183A3F960-0x0000000183A3F9C0 0x00000001831D4F70-0x00000001831D4FB0
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGColorGradingConfig::get_active(HGColorGradingConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 969 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x3C9 )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[20]._1.static_fields_size )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(969, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_382(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGColorGradingConfig::set_active(
		        HGColorGradingConfig *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1362, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1362, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_539(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGColorGradingConfig(bool active) : this() {
			tonemappingMode = default;
			colorLookupEnabled = default;
			colorLookupTexture = default;
			colorLookupContribution = default;
			whiteBalanceEnabled = default;
			whiteBalanceTemperature = default;
			whiteBalanceTint = default;
			colorAdjustmentsEnabled = default;
			colorAdjustmentsPostExposure = default;
			colorAdjustmentsContrast = default;
			colorAdjustmentsColorFilter = default;
			colorAdjustmentsHueShift = default;
			colorAdjustmentsSaturation = default;
			channelMixerEnabled = default;
			channelMixerRedOutRedIn = default;
			channelMixerRedOutGreenIn = default;
			channelMixerRedOutBlueIn = default;
			channelMixerGreenOutRedIn = default;
			channelMixerGreenOutGreenIn = default;
			channelMixerGreenOutBlueIn = default;
			channelMixerBlueOutRedIn = default;
			channelMixerBlueOutGreenIn = default;
			channelMixerBlueOutBlueIn = default;
			shadowsMidtonesHighlightsEnabled = default;
			shadowsMidtonesHighlights = default;
			liftGammaGainEnabled = default;
			liftGammaGain = default;
			splitToningEnabled = default;
			splitToningShadows = default;
			splitToningHighlights = default;
			splitToningBalance = default;
			colorCurvesEnabled = default;
			colorCurves = default;
			m_active = default;
		} // 0x0000000184543930-0x0000000184543B40
		// HGColorGradingConfig(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGColorGradingConfig::HGColorGradingConfig(
		        HGColorGradingConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  MethodInfo *v6; // rdx
		  Vector4 v7; // xmm1
		  Vector4 midtones; // xmm1
		  Vector4 highlights; // xmm0
		  __int128 v10; // xmm1
		  Vector4 shadows; // xmm0
		  float shadowsStart; // eax
		  Vector4 v13; // xmm1
		  Vector4 v14; // xmm0
		  MethodInfo *v15; // rdx
		  MethodInfo *v16; // rdx
		  Color v17; // xmm1
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Int32__Array **v23; // r9
		  HGShadowsMidtonesHighlights v24; // [rsp+20h] [rbp-59h] BYREF
		  Vector4 v25; // [rsp+70h] [rbp-9h] BYREF
		  HGColorCurve v26; // [rsp+80h] [rbp+7h] BYREF
		
		  this->m_active = 0;
		  this->tonemappingMode = 5;
		  this->colorLookupTexture = 0LL;
		  this->colorLookupEnabled = 0;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->colorLookupTexture,
		    (Type *)active,
		    (PropertyInfo_1 *)method,
		    v3,
		    *(MethodInfo **)&v24.shadows.x);
		  this->colorLookupContribution = 1.0;
		  this->whiteBalanceEnabled = 0;
		  *(_QWORD *)&this->whiteBalanceTemperature = 0LL;
		  this->colorAdjustmentsEnabled = 0;
		  *(_QWORD *)&this->colorAdjustmentsPostExposure = 0LL;
		  v24.shadows = 0LL;
		  v7 = *UnityEngine::Vector4::get_one(&v25, v6);
		  *(_QWORD *)&this->colorAdjustmentsHueShift = 0LL;
		  this->channelMixerEnabled = 0;
		  this->colorAdjustmentsColorFilter = (Color)v7;
		  *(_QWORD *)&this->channelMixerRedOutRedIn = 1120403456LL;
		  *(_QWORD *)&this->channelMixerRedOutBlueIn = 0LL;
		  *(_QWORD *)&this->channelMixerGreenOutGreenIn = 1120403456LL;
		  *(_QWORD *)&this->channelMixerBlueOutRedIn = 0LL;
		  this->channelMixerBlueOutBlueIn = 100.0;
		  this->shadowsMidtonesHighlightsEnabled = 0;
		  memset(&v24.midtones, 0, 56);
		  HGShadowsMidtonesHighlights::HGShadowsMidtonesHighlights(&v24, active, 0LL);
		  midtones = v24.midtones;
		  this->shadowsMidtonesHighlights.shadows = v24.shadows;
		  highlights = v24.highlights;
		  this->shadowsMidtonesHighlights.midtones = midtones;
		  this->liftGammaGainEnabled = 0;
		  v10 = *(_OWORD *)&v24.shadowsStart;
		  this->shadowsMidtonesHighlights.highlights = highlights;
		  v24.shadowsStart = 0.0;
		  *(_QWORD *)&highlights.x = *(_QWORD *)&v24.shadowsOverriding;
		  *(_OWORD *)&this->shadowsMidtonesHighlights.shadowsStart = v10;
		  *(_QWORD *)&this->shadowsMidtonesHighlights.shadowsOverriding = *(_QWORD *)&highlights.x;
		  memset(&v24, 0, 48);
		  HGLiftGammaGain::HGLiftGammaGain((HGLiftGammaGain *)&v24, active, 0LL);
		  shadows = v24.shadows;
		  shadowsStart = v24.shadowsStart;
		  v13 = v24.midtones;
		  this->splitToningEnabled = 0;
		  this->liftGammaGain.lift = shadows;
		  v14 = v24.highlights;
		  this->liftGammaGain.gamma = v13;
		  this->liftGammaGain.gain = v14;
		  *(float *)&this->liftGammaGain.liftOverriding = shadowsStart;
		  this->splitToningShadows = *UnityEngine::Color::get_grey((Color *)&v25, v15);
		  v17 = *UnityEngine::Color::get_grey((Color *)&v25, v16);
		  this->splitToningBalance = 0.0;
		  this->colorCurvesEnabled = 0;
		  this->splitToningHighlights = v17;
		  memset(&v26, 0, sizeof(v26));
		  HGColorCurve::HGColorCurve(&v26, active, 0LL);
		  v18 = *(_OWORD *)&v26.green;
		  *(_OWORD *)&this->colorCurves.master = *(_OWORD *)&v26.master;
		  v19 = *(_OWORD *)&v26.hueVsHue;
		  *(_OWORD *)&this->colorCurves.green = v18;
		  v20 = *(_OWORD *)&v26.satVsSat;
		  *(_OWORD *)&this->colorCurves.hueVsHue = v19;
		  *(_QWORD *)&v19 = *(_QWORD *)&v26.masterOverriding;
		  *(_OWORD *)&this->colorCurves.satVsSat = v20;
		  *(_QWORD *)&this->colorCurves.masterOverriding = v19;
		  sub_18002D1B0((SingleFieldAccessor *)&this->colorCurves, v21, v22, v23, *(MethodInfo **)&v24.shadows.x);
		}
		
		static HGColorGradingConfig() {
			_enabledColor = default;
			_disabledColor = default;
			defaultConfig = default;
		} // 0x0000000184543500-0x00000001845436C0
		// HGColorGradingConfig()
		void HG::Rendering::Runtime::HGColorGradingConfig::cctor(MethodInfo *method)
		{
		  Color si128; // xmm1
		  Int32__Array **v2; // r9
		  __int64 v3; // rdx
		  _OWORD *v4; // rax
		  __int64 v5; // r8
		  HGColorGradingConfig *v6; // rcx
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 *v21; // rax
		  HGColorGradingConfig *p_defaultConfig; // rcx
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  HGColorGradingConfig v37; // [rsp+20h] [rbp-2E8h] BYREF
		  _BYTE v38[376]; // [rsp+190h] [rbp-178h] BYREF
		
		  si128 = (Color)_mm_load_si128((const __m128i *)&xmmword_18B959AE0);
		  TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_enabledColor = (Color)_mm_load_si128((const __m128i *)&xmmword_18B959AF0);
		  TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->_disabledColor = si128;
		  sub_18033B9D0(&v37, 0LL, 368LL);
		  HG::Rendering::Runtime::HGColorGradingConfig::HGColorGradingConfig(&v37, 0, 0LL);
		  v3 = 2LL;
		  v4 = v38;
		  v5 = 2LL;
		  v6 = &v37;
		  do
		  {
		    v4 += 8;
		    v7 = *(_OWORD *)&v6->tonemappingMode;
		    v8 = *(_OWORD *)&v6->colorLookupContribution;
		    v6 = (HGColorGradingConfig *)((char *)v6 + 128);
		    *(v4 - 8) = v7;
		    v9 = *(_OWORD *)&v6[-1].splitToningHighlights.a;
		    *(v4 - 7) = v8;
		    v10 = *(_OWORD *)&v6[-1].colorCurves.master;
		    *(v4 - 6) = v9;
		    v11 = *(_OWORD *)&v6[-1].colorCurves.green;
		    *(v4 - 5) = v10;
		    v12 = *(_OWORD *)&v6[-1].colorCurves.hueVsHue;
		    *(v4 - 4) = v11;
		    v13 = *(_OWORD *)&v6[-1].colorCurves.satVsSat;
		    *(v4 - 3) = v12;
		    v14 = *(_OWORD *)&v6[-1].colorCurves.masterOverriding;
		    *(v4 - 2) = v13;
		    *(v4 - 1) = v14;
		    --v5;
		  }
		  while ( v5 );
		  v15 = *(_OWORD *)&v6->colorLookupContribution;
		  *v4 = *(_OWORD *)&v6->tonemappingMode;
		  v16 = *(_OWORD *)&v6->colorAdjustmentsEnabled;
		  v4[1] = v15;
		  v17 = *(_OWORD *)&v6->colorAdjustmentsColorFilter.g;
		  v4[2] = v16;
		  v18 = *(_OWORD *)&v6->colorAdjustmentsSaturation;
		  v4[3] = v17;
		  v19 = *(_OWORD *)&v6->channelMixerRedOutBlueIn;
		  v4[4] = v18;
		  v20 = *(_OWORD *)&v6->channelMixerBlueOutRedIn;
		  v4[5] = v19;
		  v4[6] = v20;
		  v21 = (__int128 *)v38;
		  p_defaultConfig = &TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->defaultConfig;
		  do
		  {
		    p_defaultConfig = (HGColorGradingConfig *)((char *)p_defaultConfig + 128);
		    v23 = *v21;
		    v24 = v21[1];
		    v21 += 8;
		    *(_OWORD *)&p_defaultConfig[-1].splitToningEnabled = v23;
		    v25 = *(v21 - 6);
		    *(_OWORD *)&p_defaultConfig[-1].splitToningShadows.a = v24;
		    v26 = *(v21 - 5);
		    *(_OWORD *)&p_defaultConfig[-1].splitToningHighlights.a = v25;
		    v27 = *(v21 - 4);
		    *(_OWORD *)&p_defaultConfig[-1].colorCurves.master = v26;
		    v28 = *(v21 - 3);
		    *(_OWORD *)&p_defaultConfig[-1].colorCurves.green = v27;
		    v29 = *(v21 - 2);
		    *(_OWORD *)&p_defaultConfig[-1].colorCurves.hueVsHue = v28;
		    v30 = *(v21 - 1);
		    *(_OWORD *)&p_defaultConfig[-1].colorCurves.satVsSat = v29;
		    *(_OWORD *)&p_defaultConfig[-1].colorCurves.masterOverriding = v30;
		    --v3;
		  }
		  while ( v3 );
		  v31 = v21[1];
		  *(_OWORD *)&p_defaultConfig->tonemappingMode = *v21;
		  v32 = v21[2];
		  *(_OWORD *)&p_defaultConfig->colorLookupContribution = v31;
		  v33 = v21[3];
		  *(_OWORD *)&p_defaultConfig->colorAdjustmentsEnabled = v32;
		  v34 = v21[4];
		  *(_OWORD *)&p_defaultConfig->colorAdjustmentsColorFilter.g = v33;
		  v35 = v21[5];
		  *(_OWORD *)&p_defaultConfig->colorAdjustmentsSaturation = v34;
		  v36 = v21[6];
		  *(_OWORD *)&p_defaultConfig->channelMixerRedOutBlueIn = v35;
		  *(_OWORD *)&p_defaultConfig->channelMixerBlueOutRedIn = v36;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->static_fields->defaultConfig.colorLookupTexture,
		    0LL,
		    0LL,
		    v2,
		    *(MethodInfo **)&v37.tonemappingMode);
		}
		
	
		// Methods
		public Texture2D GetColorLookupTexture() => default; // 0x0000000189C6E4D8-0x0000000189C6E534
		// Texture2D GetColorLookupTexture()
		Texture2D *HG::Rendering::Runtime::HGColorGradingConfig::GetColorLookupTexture(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1360, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1360, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_538(Patch, this, 0LL);
		  }
		  else if ( this->colorLookupEnabled )
		  {
		    return this->colorLookupTexture;
		  }
		  else
		  {
		    return 0LL;
		  }
		}
		
		public float GetColorLookupContribution() => default; // 0x0000000189C6E47C-0x0000000189C6E4D8
		// Single GetColorLookupContribution()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetColorLookupContribution(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1361, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1361, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		  }
		  else if ( this->colorLookupEnabled )
		  {
		    return this->colorLookupContribution;
		  }
		  else
		  {
		    return 0.0;
		  }
		}
		
		public float GetWhiteBalanceTemperature() => default; // 0x0000000183E6DB80-0x0000000183E6DBE0
		// Single GetWhiteBalanceTemperature()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetWhiteBalanceTemperature(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 970 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3CA )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*(_QWORD *)&v3[20]._1.thread_static_fields_offset )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(970, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->whiteBalanceEnabled )
		    return this->whiteBalanceTemperature;
		  else
		    return 0.0;
		}
		
		public float GetWhiteBalanceTint() => default; // 0x0000000183E6DB20-0x0000000183E6DB80
		// Single GetWhiteBalanceTint()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetWhiteBalanceTint(HGColorGradingConfig *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 971 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3CB )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*(_QWORD *)&v3[20]._1.token )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(971, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->whiteBalanceEnabled )
		    return this->whiteBalanceTint;
		  else
		    return 0.0;
		}
		
		public float GetColorAdjustmentsPostExposure() => default; // 0x0000000183C94C50-0x0000000183C94CB0
		// Single GetColorAdjustmentsPostExposure()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsPostExposure(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 1147 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x47B )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[24].static_fields )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1147, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->colorAdjustmentsEnabled )
		    return this->colorAdjustmentsPostExposure;
		  else
		    return 0.0;
		}
		
		public float GetColorAdjustmentsContrast() => default; // 0x0000000183E6DD00-0x0000000183E6DD60
		// Single GetColorAdjustmentsContrast()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsContrast(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 974 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3CE )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*(_QWORD *)&v3[20]._1.naturalAligment )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(974, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->colorAdjustmentsEnabled )
		    return this->colorAdjustmentsContrast;
		  else
		    return 0.0;
		}
		
		public UnityEngine.Color GetColorAdjustmentsColorFilter() => default; // 0x0000000183DBB9C0-0x0000000183DBBA40
		// Color GetColorAdjustmentsColorFilter()
		Color *HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsColorFilter(
		        Color *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  Color *one; // rax
		  Color colorAdjustmentsColorFilter; // xmm0
		  Color *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Color v11; // [rsp+20h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 990 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x3DE )
		        sub_1800D2AB0(v5, this);
		      if ( !*((_QWORD *)&v5[21]._0.this_arg + 1) )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(990, 0LL);
		      if ( Patch )
		      {
		        one = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_386(&v11, Patch, this, 0LL);
		        goto LABEL_7;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v5, this);
		  }
		LABEL_5:
		  if ( this->colorAdjustmentsEnabled )
		  {
		    colorAdjustmentsColorFilter = this->colorAdjustmentsColorFilter;
		    goto LABEL_8;
		  }
		  one = (Color *)UnityEngine::Vector4::get_one((Vector4 *)&v11, (MethodInfo *)this);
		LABEL_7:
		  colorAdjustmentsColorFilter = *one;
		LABEL_8:
		  result = retstr;
		  *retstr = colorAdjustmentsColorFilter;
		  return result;
		}
		
		public float GetColorAdjustmentsHueShift() => default; // 0x0000000183E6DCA0-0x0000000183E6DD00
		// Single GetColorAdjustmentsHueShift()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsHueShift(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 972 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3CC )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*(_QWORD *)&v3[20]._1.field_count )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(972, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->colorAdjustmentsEnabled )
		    return this->colorAdjustmentsHueShift;
		  else
		    return 0.0;
		}
		
		public float GetColorAdjustmentsSaturation() => default; // 0x0000000183E6DC40-0x0000000183E6DCA0
		// Single GetColorAdjustmentsSaturation()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsSaturation(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 973 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3CD )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*(_QWORD *)&v3[20]._1.interfaces_count )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(973, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->colorAdjustmentsEnabled )
		    return this->colorAdjustmentsSaturation;
		  else
		    return 0.0;
		}
		
		public float GetChannelMixerRedOutRedIn() => default; // 0x0000000183E6D8B0-0x0000000183E6D920
		// Single GetChannelMixerRedOutRedIn()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerRedOutRedIn(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 975 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3CF )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[20].vtable.Equals.methodPtr )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(975, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->channelMixerEnabled )
		    return this->channelMixerRedOutRedIn;
		  else
		    return 100.0;
		}
		
		public float GetChannelMixerRedOutGreenIn() => default; // 0x0000000183E6DD60-0x0000000183E6DDC0
		// Single GetChannelMixerRedOutGreenIn()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerRedOutGreenIn(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 976 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3D0 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[20].vtable.Equals.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(976, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->channelMixerEnabled )
		    return this->channelMixerRedOutGreenIn;
		  else
		    return 0.0;
		}
		
		public float GetChannelMixerRedOutBlueIn() => default; // 0x0000000183E6DDC0-0x0000000183E6DE20
		// Single GetChannelMixerRedOutBlueIn()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerRedOutBlueIn(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 977 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3D1 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[20].vtable.Finalize.methodPtr )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(977, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->channelMixerEnabled )
		    return this->channelMixerRedOutBlueIn;
		  else
		    return 0.0;
		}
		
		public float GetChannelMixerGreenOutRedIn() => default; // 0x0000000183E6DE20-0x0000000183E6DE80
		// Single GetChannelMixerGreenOutRedIn()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerGreenOutRedIn(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 978 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3D2 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[20].vtable.Finalize.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(978, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->channelMixerEnabled )
		    return this->channelMixerGreenOutRedIn;
		  else
		    return 0.0;
		}
		
		public float GetChannelMixerGreenOutGreenIn() => default; // 0x0000000183E6D920-0x0000000183E6D990
		// Single GetChannelMixerGreenOutGreenIn()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerGreenOutGreenIn(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 979 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3D3 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[20].vtable.GetHashCode.methodPtr )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(979, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->channelMixerEnabled )
		    return this->channelMixerGreenOutGreenIn;
		  else
		    return 100.0;
		}
		
		public float GetChannelMixerGreenOutBlueIn() => default; // 0x0000000183E6DE80-0x0000000183E6DEE0
		// Single GetChannelMixerGreenOutBlueIn()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerGreenOutBlueIn(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 980 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3D4 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[20].vtable.GetHashCode.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(980, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->channelMixerEnabled )
		    return this->channelMixerGreenOutBlueIn;
		  else
		    return 0.0;
		}
		
		public float GetChannelMixerBlueOutRedIn() => default; // 0x0000000183E6DEE0-0x0000000183E6DF40
		// Single GetChannelMixerBlueOutRedIn()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerBlueOutRedIn(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 981 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3D5 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[20].vtable.ToString.methodPtr )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(981, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->channelMixerEnabled )
		    return this->channelMixerBlueOutRedIn;
		  else
		    return 0.0;
		}
		
		public float GetChannelMixerBlueOutGreenIn() => default; // 0x0000000183E6DF40-0x0000000183E6DFA0
		// Single GetChannelMixerBlueOutGreenIn()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerBlueOutGreenIn(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 982 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3D6 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[20].vtable.ToString.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(982, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->channelMixerEnabled )
		    return this->channelMixerBlueOutGreenIn;
		  else
		    return 0.0;
		}
		
		public float GetChannelMixerBlueOutBlueIn() => default; // 0x0000000183E6D990-0x0000000183E6DA00
		// Single GetChannelMixerBlueOutBlueIn()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerBlueOutBlueIn(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 983 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3D7 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !v3[21]._0.image )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(983, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->channelMixerEnabled )
		    return this->channelMixerBlueOutBlueIn;
		  else
		    return 100.0;
		}
		
		public HGShadowsMidtonesHighlights GetShadowsMidtonesHighlights() => default; // 0x0000000183D36B40-0x0000000183D36C10
		// HGShadowsMidtonesHighlights GetShadowsMidtonesHighlights()
		HGShadowsMidtonesHighlights *HG::Rendering::Runtime::HGColorGradingConfig::GetShadowsMidtonesHighlights(
		        HGShadowsMidtonesHighlights *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  struct HGShadowsMidtonesHighlights__Class *v7; // rax
		  HGShadowsMidtonesHighlights *p_defaultConfig; // rax
		  Vector4 v9; // xmm1
		  Vector4 v10; // xmm0
		  __int128 v11; // xmm1
		  __int64 v12; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 midtones; // xmm1
		  Vector4 highlights; // xmm0
		  __int128 v17; // xmm1
		  HGShadowsMidtonesHighlights v18; // [rsp+20h] [rbp-58h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_11;
		  if ( wrapperArray->max_length.size > 984 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x3D8 )
		        sub_1800D2AB0(v5, this);
		      if ( !v5[21]._0.gc_desc )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(984, 0LL);
		      if ( Patch )
		      {
		        p_defaultConfig = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_384(&v18, Patch, this, 0LL);
		        goto LABEL_9;
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v5, this);
		  }
		LABEL_5:
		  if ( this->shadowsMidtonesHighlightsEnabled )
		  {
		    midtones = this->shadowsMidtonesHighlights.midtones;
		    retstr->shadows = this->shadowsMidtonesHighlights.shadows;
		    highlights = this->shadowsMidtonesHighlights.highlights;
		    retstr->midtones = midtones;
		    v17 = *(_OWORD *)&this->shadowsMidtonesHighlights.shadowsStart;
		    retstr->highlights = highlights;
		    v12 = *(_QWORD *)&this->shadowsMidtonesHighlights.shadowsOverriding;
		    *(_OWORD *)&retstr->shadowsStart = v17;
		    goto LABEL_10;
		  }
		  v7 = TypeInfo::HGShadowsMidtonesHighlights;
		  if ( !TypeInfo::HGShadowsMidtonesHighlights->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HGShadowsMidtonesHighlights);
		    v7 = TypeInfo::HGShadowsMidtonesHighlights;
		  }
		  p_defaultConfig = &v7->static_fields->defaultConfig;
		LABEL_9:
		  v9 = p_defaultConfig->midtones;
		  retstr->shadows = p_defaultConfig->shadows;
		  v10 = p_defaultConfig->highlights;
		  retstr->midtones = v9;
		  v11 = *(_OWORD *)&p_defaultConfig->shadowsStart;
		  retstr->highlights = v10;
		  v12 = *(_QWORD *)&p_defaultConfig->shadowsOverriding;
		  *(_OWORD *)&retstr->shadowsStart = v11;
		LABEL_10:
		  *(_QWORD *)&retstr->shadowsOverriding = v12;
		  return retstr;
		}
		
		public HGLiftGammaGain GetLiftGammaGain() => default; // 0x0000000183D4E910-0x0000000183D4E9C0
		// HGLiftGammaGain GetLiftGammaGain()
		HGLiftGammaGain *HG::Rendering::Runtime::HGColorGradingConfig::GetLiftGammaGain(
		        HGLiftGammaGain *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  struct HGLiftGammaGain__Class *v7; // rax
		  HGLiftGammaGain *p_defaultConfig; // rax
		  Vector4 v9; // xmm1
		  Vector4 v10; // xmm0
		  int v11; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 gamma; // xmm1
		  Vector4 gain; // xmm0
		  HGLiftGammaGain v16; // [rsp+20h] [rbp-48h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_11;
		  if ( wrapperArray->max_length.size > 985 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x3D9 )
		        sub_1800D2AB0(v5, this);
		      if ( !v5[21]._0.name )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(985, 0LL);
		      if ( Patch )
		      {
		        p_defaultConfig = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_385(&v16, Patch, this, 0LL);
		        goto LABEL_9;
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v5, this);
		  }
		LABEL_5:
		  if ( this->liftGammaGainEnabled )
		  {
		    v11 = *(_DWORD *)&this->liftGammaGain.liftOverriding;
		    gamma = this->liftGammaGain.gamma;
		    retstr->lift = this->liftGammaGain.lift;
		    gain = this->liftGammaGain.gain;
		    retstr->gamma = gamma;
		    retstr->gain = gain;
		    goto LABEL_10;
		  }
		  v7 = TypeInfo::HGLiftGammaGain;
		  if ( !TypeInfo::HGLiftGammaGain->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HGLiftGammaGain);
		    v7 = TypeInfo::HGLiftGammaGain;
		  }
		  p_defaultConfig = &v7->static_fields->defaultConfig;
		LABEL_9:
		  v9 = p_defaultConfig->gamma;
		  retstr->lift = p_defaultConfig->lift;
		  v10 = p_defaultConfig->gain;
		  v11 = *(_DWORD *)&p_defaultConfig->liftOverriding;
		  retstr->gamma = v9;
		  retstr->gain = v10;
		LABEL_10:
		  *(_DWORD *)&retstr->liftOverriding = v11;
		  return retstr;
		}
		
		public UnityEngine.Color GetSplitToningShadows() => default; // 0x0000000183DBB8C0-0x0000000183DBB940
		// Color GetSplitToningShadows()
		Color *HG::Rendering::Runtime::HGColorGradingConfig::GetSplitToningShadows(
		        Color *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  Color *grey; // rax
		  Color splitToningShadows; // xmm0
		  Color *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Color v11; // [rsp+20h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 986 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x3DA )
		        sub_1800D2AB0(v5, this);
		      if ( !v5[21]._0.namespaze )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(986, 0LL);
		      if ( Patch )
		      {
		        grey = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_386(&v11, Patch, this, 0LL);
		        goto LABEL_7;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v5, this);
		  }
		LABEL_5:
		  if ( this->splitToningEnabled )
		  {
		    splitToningShadows = this->splitToningShadows;
		    goto LABEL_8;
		  }
		  grey = UnityEngine::Color::get_grey(&v11, (MethodInfo *)this);
		LABEL_7:
		  splitToningShadows = *grey;
		LABEL_8:
		  result = retstr;
		  *retstr = splitToningShadows;
		  return result;
		}
		
		public UnityEngine.Color GetSplitToningHighlights() => default; // 0x0000000183DBB940-0x0000000183DBB9C0
		// Color GetSplitToningHighlights()
		Color *HG::Rendering::Runtime::HGColorGradingConfig::GetSplitToningHighlights(
		        Color *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  Color *grey; // rax
		  Color splitToningHighlights; // xmm0
		  Color *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Color v11; // [rsp+20h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 987 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x3DB )
		        sub_1800D2AB0(v5, this);
		      if ( !v5[21]._0.byval_arg.data.dummy )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(987, 0LL);
		      if ( Patch )
		      {
		        grey = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_386(&v11, Patch, this, 0LL);
		        goto LABEL_7;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v5, this);
		  }
		LABEL_5:
		  if ( this->splitToningEnabled )
		  {
		    splitToningHighlights = this->splitToningHighlights;
		    goto LABEL_8;
		  }
		  grey = UnityEngine::Color::get_grey(&v11, (MethodInfo *)this);
		LABEL_7:
		  splitToningHighlights = *grey;
		LABEL_8:
		  result = retstr;
		  *retstr = splitToningHighlights;
		  return result;
		}
		
		public float GetSplitToningBalance() => default; // 0x0000000183E6DBE0-0x0000000183E6DC40
		// Single GetSplitToningBalance()
		float HG::Rendering::Runtime::HGColorGradingConfig::GetSplitToningBalance(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 988 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3DC )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*((_QWORD *)&v3[21]._0.byval_arg + 1) )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(988, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_383(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->splitToningEnabled )
		    return this->splitToningBalance;
		  else
		    return 0.0;
		}
		
		public HGColorCurve GetColorCurves() => default; // 0x0000000183D36C10-0x0000000183D36CE0
		// HGColorCurve GetColorCurves()
		HGColorCurve *HG::Rendering::Runtime::HGColorGradingConfig::GetColorCurves(
		        HGColorCurve *__return_ptr retstr,
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  struct HGColorCurve__Class *v7; // rax
		  HGColorCurve *p_defaultConfig; // rax
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int64 v12; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  HGColorCurve v18; // [rsp+20h] [rbp-58h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_11;
		  if ( wrapperArray->max_length.size > 989 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x3DD )
		        sub_1800D2AB0(v5, this);
		      if ( !v5[21]._0.this_arg.data.dummy )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(989, 0LL);
		      if ( Patch )
		      {
		        p_defaultConfig = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_387(&v18, Patch, this, 0LL);
		        goto LABEL_9;
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v5, this);
		  }
		LABEL_5:
		  if ( this->colorCurvesEnabled )
		  {
		    v15 = *(_OWORD *)&this->colorCurves.green;
		    *(_OWORD *)&retstr->master = *(_OWORD *)&this->colorCurves.master;
		    v16 = *(_OWORD *)&this->colorCurves.hueVsHue;
		    *(_OWORD *)&retstr->green = v15;
		    v17 = *(_OWORD *)&this->colorCurves.satVsSat;
		    *(_OWORD *)&retstr->hueVsHue = v16;
		    v12 = *(_QWORD *)&this->colorCurves.masterOverriding;
		    *(_OWORD *)&retstr->satVsSat = v17;
		    goto LABEL_10;
		  }
		  v7 = TypeInfo::HGColorCurve;
		  if ( !TypeInfo::HGColorCurve->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HGColorCurve);
		    v7 = TypeInfo::HGColorCurve;
		  }
		  p_defaultConfig = &v7->static_fields->defaultConfig;
		LABEL_9:
		  v9 = *(_OWORD *)&p_defaultConfig->green;
		  *(_OWORD *)&retstr->master = *(_OWORD *)&p_defaultConfig->master;
		  v10 = *(_OWORD *)&p_defaultConfig->hueVsHue;
		  *(_OWORD *)&retstr->green = v9;
		  v11 = *(_OWORD *)&p_defaultConfig->satVsSat;
		  *(_OWORD *)&retstr->hueVsHue = v10;
		  v12 = *(_QWORD *)&p_defaultConfig->masterOverriding;
		  *(_OWORD *)&retstr->satVsSat = v11;
		LABEL_10:
		  *(_QWORD *)&retstr->masterOverriding = v12;
		  return retstr;
		}
		
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
		public bool IsToneMappingActive() => default; // 0x0000000189C6E534-0x0000000189C6E5A0
		// Boolean IsToneMappingActive()
		bool HG::Rendering::Runtime::HGColorGradingConfig::IsToneMappingActive(HGColorGradingConfig *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1363, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1363, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_382(Patch, this, 0LL);
		  }
		  else if ( this->tonemappingMode == 4 )
		  {
		    HG::Rendering::HGRPLogger::LogWarning((String *)"Tonemapping Mode External is not implemented yet.", 0LL);
		    return 1;
		  }
		  else
		  {
		    return this->tonemappingMode != 0;
		  }
		}
		
		public bool IsColorLookupEnabled() => default; // 0x0000000183E9D580-0x0000000183E9D5E0
		// Boolean IsColorLookupEnabled()
		bool HG::Rendering::Runtime::HGColorGradingConfig::IsColorLookupEnabled(HGColorGradingConfig *this, MethodInfo *method)
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
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 1144 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x478 )
		        sub_1800D2AB0(v3, method);
		      if ( !v3[24]._0.nestedTypes )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1144, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_382(Patch, this, 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, method);
		  }
		LABEL_5:
		  if ( !this->colorLookupEnabled )
		    return 0;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
		  return HG::Rendering::Runtime::HGColorGradingConfig::ValidateColorLookupLUT(this, 0LL);
		}
		
		private bool ValidateColorLookupLUT() => default; // 0x0000000189C6E5A0-0x0000000189C6E644
		// Boolean ValidateColorLookupLUT()
		bool HG::Rendering::Runtime::HGColorGradingConfig::ValidateColorLookupLUT(
		        HGColorGradingConfig *this,
		        MethodInfo *method)
		{
		  Object_1 *colorLookupTexture; // rbx
		  __int64 v4; // rcx
		  Texture2D *v5; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1145, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1145, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_382(Patch, this, 0LL);
		  }
		  else
		  {
		    colorLookupTexture = (Object_1 *)this->colorLookupTexture;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality(colorLookupTexture, 0LL, 0LL) )
		    {
		      v5 = this->colorLookupTexture;
		      if ( !v5 )
		        goto LABEL_9;
		      if ( (unsigned int)sub_180002F70(7LL, v5) == 32 )
		      {
		        v5 = this->colorLookupTexture;
		        if ( v5 )
		          return (unsigned int)sub_180002F70(5LL, v5) == 1024;
		LABEL_9:
		        sub_1800D8260(v4, v5);
		      }
		    }
		    return 0;
		  }
		}
		
	}
}
