using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGColorGradingConfig : IEnvConfig
	{
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _tonemappingColor
		{
			get
			{
				// // Color get__tonemappingColor()
				// Color *HG::Rendering::Runtime::HGColorGradingConfig::get__tonemappingColor(
				//         Color *__return_ptr retstr,
				//         HGColorGradingConfig *this,
				//         MethodInfo *method)
				// {
				//   struct HGColorGradingConfig__Class *v4; // rax
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919CFB )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     byte_18D919CFB = 1;
				//   }
				//   v4 = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig;
				//   if ( !TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig, this);
				//     v4 = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig;
				//   }
				//   enabledColor = v4.static_fields._enabledColor;
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000534 RID: 1332 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _colorLookupColor
		{
			get
			{
				// // Color get__colorLookupColor()
				// Color *HG::Rendering::Runtime::HGColorGradingConfig::get__colorLookupColor(
				//         Color *__return_ptr retstr,
				//         HGColorGradingConfig *this,
				//         MethodInfo *method)
				// {
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919CFC )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     byte_18D919CFC = 1;
				//   }
				//   if ( this.colorLookupEnabled )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._enabledColor;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._disabledColor;
				//   }
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000535 RID: 1333 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _whiteBalanceColor
		{
			get
			{
				// // Color get__whiteBalanceColor()
				// Color *HG::Rendering::Runtime::HGColorGradingConfig::get__whiteBalanceColor(
				//         Color *__return_ptr retstr,
				//         HGColorGradingConfig *this,
				//         MethodInfo *method)
				// {
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919CFD )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     byte_18D919CFD = 1;
				//   }
				//   if ( this.whiteBalanceEnabled )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._enabledColor;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._disabledColor;
				//   }
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000536 RID: 1334 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _colorAdjustmentsColor
		{
			get
			{
				// // Color get__colorAdjustmentsColor()
				// Color *HG::Rendering::Runtime::HGColorGradingConfig::get__colorAdjustmentsColor(
				//         Color *__return_ptr retstr,
				//         HGColorGradingConfig *this,
				//         MethodInfo *method)
				// {
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919CFE )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     byte_18D919CFE = 1;
				//   }
				//   if ( this.colorAdjustmentsEnabled )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._enabledColor;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._disabledColor;
				//   }
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000537 RID: 1335 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _channelMixerColor
		{
			get
			{
				// // Color get__channelMixerColor()
				// Color *HG::Rendering::Runtime::HGColorGradingConfig::get__channelMixerColor(
				//         Color *__return_ptr retstr,
				//         HGColorGradingConfig *this,
				//         MethodInfo *method)
				// {
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919CFF )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     byte_18D919CFF = 1;
				//   }
				//   if ( this.channelMixerEnabled )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._enabledColor;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._disabledColor;
				//   }
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000538 RID: 1336 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _shadowsMidtonesHighlightsColor
		{
			get
			{
				// // Color get__shadowsMidtonesHighlightsColor()
				// Color *HG::Rendering::Runtime::HGColorGradingConfig::get__shadowsMidtonesHighlightsColor(
				//         Color *__return_ptr retstr,
				//         HGColorGradingConfig *this,
				//         MethodInfo *method)
				// {
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919D00 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     byte_18D919D00 = 1;
				//   }
				//   if ( this.shadowsMidtonesHighlightsEnabled )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._enabledColor;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._disabledColor;
				//   }
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000539 RID: 1337 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _liftGammaGainColor
		{
			get
			{
				// // Color get__liftGammaGainColor()
				// Color *HG::Rendering::Runtime::HGColorGradingConfig::get__liftGammaGainColor(
				//         Color *__return_ptr retstr,
				//         HGColorGradingConfig *this,
				//         MethodInfo *method)
				// {
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919D01 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     byte_18D919D01 = 1;
				//   }
				//   if ( this.liftGammaGainEnabled )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._enabledColor;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._disabledColor;
				//   }
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600053A RID: 1338 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _splitToningColor
		{
			get
			{
				// // Color get__splitToningColor()
				// Color *HG::Rendering::Runtime::HGColorGradingConfig::get__splitToningColor(
				//         Color *__return_ptr retstr,
				//         HGColorGradingConfig *this,
				//         MethodInfo *method)
				// {
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919D02 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     byte_18D919D02 = 1;
				//   }
				//   if ( this.splitToningEnabled )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._enabledColor;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._disabledColor;
				//   }
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600053B RID: 1339 RVA: 0x000025D2 File Offset: 0x000007D2
		private Color _colorCurvesColor
		{
			get
			{
				// // Color get__colorCurvesColor()
				// Color *HG::Rendering::Runtime::HGColorGradingConfig::get__colorCurvesColor(
				//         Color *__return_ptr retstr,
				//         HGColorGradingConfig *this,
				//         MethodInfo *method)
				// {
				//   Color enabledColor; // xmm0
				//   Color *result; // rax
				// 
				//   if ( !byte_18D919D03 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     byte_18D919D03 = 1;
				//   }
				//   if ( this.colorCurvesEnabled )
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._enabledColor;
				//   }
				//   else
				//   {
				//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
				//     enabledColor = TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig.static_fields._disabledColor;
				//   }
				//   result = retstr;
				//   *retstr = enabledColor;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600053C RID: 1340 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_isNavigationSilent()
				// bool UnityEngine::UI::Selectable::get_isNavigationSilent(Selectable *this, MethodInfo *method)
				// {
				//   return this.fields._isNavigationSilent_k__BackingField;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_isNavigationSilent(Boolean)
				// void UnityEngine::UI::Selectable::set_isNavigationSilent(Selectable *this, bool value, MethodInfo *method)
				// {
				//   this.fields._isNavigationSilent_k__BackingField = value;
				// }
				// 
			}
		}

		public HGColorGradingConfig(bool active)
		{
			// // HGColorGradingConfig(Boolean)
			// // local variable allocation has failed, the output may be wrong!
			// void HG::Rendering::Runtime::HGColorGradingConfig::HGColorGradingConfig(
			//         HGColorGradingConfig *this,
			//         bool active,
			//         MethodInfo *method)
			// {
			//   MessageDescriptor *v3; // r9
			//   MethodInfo *v6; // rdx
			//   Vector4 v7; // xmm1
			//   Vector4 midtones; // xmm1
			//   Vector4 highlights; // xmm0
			//   __int128 v10; // xmm1
			//   Vector4 shadows; // xmm0
			//   float shadowsStart; // eax
			//   Vector4 v13; // xmm1
			//   Vector4 v14; // xmm0
			//   MethodInfo *v15; // rdx
			//   MethodInfo *v16; // rdx
			//   Color v17; // xmm1
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   OneofDescriptorProto *v21; // rdx
			//   FileDescriptor *v22; // r8
			//   MessageDescriptor *v23; // r9
			//   HGShadowsMidtonesHighlights v24; // [rsp+20h] [rbp-59h] BYREF
			//   Vector4 v25; // [rsp+70h] [rbp-9h] BYREF
			//   HGColorCurve v26; // [rsp+80h] [rbp+7h] BYREF
			// 
			//   this.m_active = 0;
			//   this.tonemappingMode = 5;
			//   this.colorLookupTexture = 0LL;
			//   this.colorLookupEnabled = 0;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.colorLookupTexture,
			//     (OneofDescriptorProto *)active,
			//     (FileDescriptor *)method,
			//     v3,
			//     *(String__Array **)&v24.shadows.x,
			//     *(String **)&v24.shadows.z,
			//     *(MethodInfo **)&v24.midtones.x);
			//   this.colorLookupContribution = 1.0;
			//   this.whiteBalanceEnabled = 0;
			//   *(_QWORD *)&this.whiteBalanceTemperature = 0LL;
			//   this.colorAdjustmentsEnabled = 0;
			//   *(_QWORD *)&this.colorAdjustmentsPostExposure = 0LL;
			//   v24.shadows = 0LL;
			//   v7 = *UnityEngine::Vector4::get_one(&v25, v6);
			//   *(_QWORD *)&this.colorAdjustmentsHueShift = 0LL;
			//   this.channelMixerEnabled = 0;
			//   this.colorAdjustmentsColorFilter = (Color)v7;
			//   *(_QWORD *)&this.channelMixerRedOutRedIn = 1120403456LL;
			//   *(_QWORD *)&this.channelMixerRedOutBlueIn = 0LL;
			//   *(_QWORD *)&this.channelMixerGreenOutGreenIn = 1120403456LL;
			//   *(_QWORD *)&this.channelMixerBlueOutRedIn = 0LL;
			//   this.channelMixerBlueOutBlueIn = 100.0;
			//   this.shadowsMidtonesHighlightsEnabled = 0;
			//   memset(&v24.midtones, 0, 56);
			//   HGShadowsMidtonesHighlights::HGShadowsMidtonesHighlights(&v24, active, 0LL);
			//   midtones = v24.midtones;
			//   this.shadowsMidtonesHighlights.shadows = v24.shadows;
			//   highlights = v24.highlights;
			//   this.shadowsMidtonesHighlights.midtones = midtones;
			//   this.liftGammaGainEnabled = 0;
			//   v10 = *(_OWORD *)&v24.shadowsStart;
			//   this.shadowsMidtonesHighlights.highlights = highlights;
			//   v24.shadowsStart = 0.0;
			//   *(_QWORD *)&highlights.x = *(_QWORD *)&v24.shadowsOverriding;
			//   *(_OWORD *)&this.shadowsMidtonesHighlights.shadowsStart = v10;
			//   *(_QWORD *)&this.shadowsMidtonesHighlights.shadowsOverriding = *(_QWORD *)&highlights.x;
			//   memset(&v24, 0, 48);
			//   HGLiftGammaGain::HGLiftGammaGain((HGLiftGammaGain *)&v24, active, 0LL);
			//   shadows = v24.shadows;
			//   shadowsStart = v24.shadowsStart;
			//   v13 = v24.midtones;
			//   this.splitToningEnabled = 0;
			//   this.liftGammaGain.lift = shadows;
			//   v14 = v24.highlights;
			//   this.liftGammaGain.gamma = v13;
			//   this.liftGammaGain.gain = v14;
			//   *(float *)&this.liftGammaGain.liftOverriding = shadowsStart;
			//   this.splitToningShadows = *UnityEngine::Color::get_grey((Color *)&v25, v15);
			//   v17 = *UnityEngine::Color::get_grey((Color *)&v25, v16);
			//   this.splitToningBalance = 0.0;
			//   this.colorCurvesEnabled = 0;
			//   this.splitToningHighlights = v17;
			//   memset(&v26, 0, sizeof(v26));
			//   HGColorCurve::HGColorCurve(&v26, active, 0LL);
			//   v18 = *(_OWORD *)&v26.green;
			//   *(_OWORD *)&this.colorCurves.master = *(_OWORD *)&v26.master;
			//   v19 = *(_OWORD *)&v26.hueVsHue;
			//   *(_OWORD *)&this.colorCurves.green = v18;
			//   v20 = *(_OWORD *)&v26.satVsSat;
			//   *(_OWORD *)&this.colorCurves.hueVsHue = v19;
			//   *(_QWORD *)&v19 = *(_QWORD *)&v26.masterOverriding;
			//   *(_OWORD *)&this.colorCurves.satVsSat = v20;
			//   *(_QWORD *)&this.colorCurves.masterOverriding = v19;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.colorCurves,
			//     v21,
			//     v22,
			//     v23,
			//     *(String__Array **)&v24.shadows.x,
			//     *(String **)&v24.shadows.z,
			//     *(MethodInfo **)&v24.midtones.x);
			// }
			// 
		}

		public Texture2D GetColorLookupTexture()
		{
			// // Texture2D GetColorLookupTexture()
			// Texture2D *HG::Rendering::Runtime::HGColorGradingConfig::GetColorLookupTexture(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1184, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1184, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_444(Patch, this, 0LL);
			//   }
			//   else if ( this.colorLookupEnabled )
			//   {
			//     return this.colorLookupTexture;
			//   }
			//   else
			//   {
			//     return 0LL;
			//   }
			// }
			// 
			return null;
		}

		public float GetColorLookupContribution()
		{
			// // Single GetColorLookupContribution()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetColorLookupContribution(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1185, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1185, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//   }
			//   else if ( this.colorLookupEnabled )
			//   {
			//     return this.colorLookupContribution;
			//   }
			//   else
			//   {
			//     return 0.0;
			//   }
			// }
			// 
			return 0f;
		}

		public float GetWhiteBalanceTemperature()
		{
			// // Single GetWhiteBalanceTemperature()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetWhiteBalanceTemperature(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 897 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x381 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.element_class )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(897, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.whiteBalanceEnabled )
			//     return this.whiteBalanceTemperature;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public float GetWhiteBalanceTint()
		{
			// // Single GetWhiteBalanceTint()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetWhiteBalanceTint(HGColorGradingConfig *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 898 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x382 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.castClass )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(898, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.whiteBalanceEnabled )
			//     return this.whiteBalanceTint;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public float GetColorAdjustmentsPostExposure()
		{
			// // Single GetColorAdjustmentsPostExposure()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsPostExposure(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 1025 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x401 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[21].vtable.Finalize.method )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1025, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.colorAdjustmentsEnabled )
			//     return this.colorAdjustmentsPostExposure;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public float GetColorAdjustmentsContrast()
		{
			// // Single GetColorAdjustmentsContrast()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsContrast(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 901 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x385 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.generic_class )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(901, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.colorAdjustmentsEnabled )
			//     return this.colorAdjustmentsContrast;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public Color GetColorAdjustmentsColorFilter()
		{
			// // Color GetColorAdjustmentsColorFilter()
			// Color *HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsColorFilter(
			//         Color *__return_ptr retstr,
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Color *one; // rax
			//   Color colorAdjustmentsColorFilter; // xmm0
			//   Color *result; // rax
			//   ILFixDynamicMethodWrapper_2__Array *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Color v13; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size > 917 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v5.static_fields;
			//     v11 = static_fields.wrapperArray;
			//     if ( static_fields.wrapperArray )
			//     {
			//       if ( v11.max_length.size <= 0x395u )
			//         sub_180070270(static_fields, wrapperArray);
			//       if ( !v11[25].vector[17] )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(917, 0LL);
			//       if ( Patch )
			//       {
			//         one = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_346(&v13, Patch, this, 0LL);
			//         goto LABEL_9;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.colorAdjustmentsEnabled )
			//   {
			//     colorAdjustmentsColorFilter = this.colorAdjustmentsColorFilter;
			//     goto LABEL_10;
			//   }
			//   one = (Color *)UnityEngine::Vector4::get_one((Vector4 *)&v13, (MethodInfo *)wrapperArray);
			// LABEL_9:
			//   colorAdjustmentsColorFilter = *one;
			// LABEL_10:
			//   result = retstr;
			//   *retstr = colorAdjustmentsColorFilter;
			//   return result;
			// }
			// 
			return null;
		}

		public float GetColorAdjustmentsHueShift()
		{
			// // Single GetColorAdjustmentsHueShift()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsHueShift(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 899 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x383 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.declaringType )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(899, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.colorAdjustmentsEnabled )
			//     return this.colorAdjustmentsHueShift;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public float GetColorAdjustmentsSaturation()
		{
			// // Single GetColorAdjustmentsSaturation()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetColorAdjustmentsSaturation(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 900 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x384 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.parent )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(900, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.colorAdjustmentsEnabled )
			//     return this.colorAdjustmentsSaturation;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public float GetChannelMixerRedOutRedIn()
		{
			// // Single GetChannelMixerRedOutRedIn()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerRedOutRedIn(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 902 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x386 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.typeMetadataHandle )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(902, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.channelMixerEnabled )
			//     return this.channelMixerRedOutRedIn;
			//   else
			//     return 100.0;
			// }
			// 
			return 0f;
		}

		public float GetChannelMixerRedOutGreenIn()
		{
			// // Single GetChannelMixerRedOutGreenIn()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerRedOutGreenIn(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 903 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x387 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.interopData )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(903, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.channelMixerEnabled )
			//     return this.channelMixerRedOutGreenIn;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public float GetChannelMixerRedOutBlueIn()
		{
			// // Single GetChannelMixerRedOutBlueIn()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerRedOutBlueIn(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 904 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x388 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.klass )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(904, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.channelMixerEnabled )
			//     return this.channelMixerRedOutBlueIn;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public float GetChannelMixerGreenOutRedIn()
		{
			// // Single GetChannelMixerGreenOutRedIn()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerGreenOutRedIn(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 905 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x389 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.fields )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(905, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.channelMixerEnabled )
			//     return this.channelMixerGreenOutRedIn;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public float GetChannelMixerGreenOutGreenIn()
		{
			// // Single GetChannelMixerGreenOutGreenIn()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerGreenOutGreenIn(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 906 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x38A )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.events )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(906, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.channelMixerEnabled )
			//     return this.channelMixerGreenOutGreenIn;
			//   else
			//     return 100.0;
			// }
			// 
			return 0f;
		}

		public float GetChannelMixerGreenOutBlueIn()
		{
			// // Single GetChannelMixerGreenOutBlueIn()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerGreenOutBlueIn(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 907 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x38B )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.properties )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(907, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.channelMixerEnabled )
			//     return this.channelMixerGreenOutBlueIn;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public float GetChannelMixerBlueOutRedIn()
		{
			// // Single GetChannelMixerBlueOutRedIn()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerBlueOutRedIn(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 908 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x38C )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.methods )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(908, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.channelMixerEnabled )
			//     return this.channelMixerBlueOutRedIn;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public float GetChannelMixerBlueOutGreenIn()
		{
			// // Single GetChannelMixerBlueOutGreenIn()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerBlueOutGreenIn(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 909 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x38D )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.nestedTypes )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(909, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.channelMixerEnabled )
			//     return this.channelMixerBlueOutGreenIn;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public float GetChannelMixerBlueOutBlueIn()
		{
			// // Single GetChannelMixerBlueOutBlueIn()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetChannelMixerBlueOutBlueIn(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 910 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x38E )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._0.implementedInterfaces )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(910, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.channelMixerEnabled )
			//     return this.channelMixerBlueOutBlueIn;
			//   else
			//     return 100.0;
			// }
			// 
			return 0f;
		}

		public HGShadowsMidtonesHighlights GetShadowsMidtonesHighlights()
		{
			// // HGShadowsMidtonesHighlights GetShadowsMidtonesHighlights()
			// HGShadowsMidtonesHighlights *HG::Rendering::Runtime::HGColorGradingConfig::GetShadowsMidtonesHighlights(
			//         HGShadowsMidtonesHighlights *__return_ptr retstr,
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   struct HGShadowsMidtonesHighlights__Class *v7; // rax
			//   HGShadowsMidtonesHighlights *p_defaultConfig; // rax
			//   Vector4 v9; // xmm1
			//   Vector4 v10; // xmm0
			//   __int128 v11; // xmm1
			//   __int64 v12; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 midtones; // xmm1
			//   Vector4 highlights; // xmm0
			//   __int128 v17; // xmm1
			//   HGShadowsMidtonesHighlights v18; // [rsp+20h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D8EDC09 )
			//   {
			//     sub_18003C530(&TypeInfo::HGShadowsMidtonesHighlights);
			//     byte_18D8EDC09 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_15;
			//   if ( wrapperArray.max_length.size > 911 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x38F )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5[19].interfaceOffsets )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(911, 0LL);
			//       if ( Patch )
			//       {
			//         p_defaultConfig = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_344(&v18, Patch, this, 0LL);
			//         goto LABEL_13;
			//       }
			//     }
			// LABEL_15:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_9:
			//   if ( this.shadowsMidtonesHighlightsEnabled )
			//   {
			//     midtones = this.shadowsMidtonesHighlights.midtones;
			//     retstr.shadows = this.shadowsMidtonesHighlights.shadows;
			//     highlights = this.shadowsMidtonesHighlights.highlights;
			//     retstr.midtones = midtones;
			//     v17 = *(_OWORD *)&this.shadowsMidtonesHighlights.shadowsStart;
			//     retstr.highlights = highlights;
			//     v12 = *(_QWORD *)&this.shadowsMidtonesHighlights.shadowsOverriding;
			//     *(_OWORD *)&retstr.shadowsStart = v17;
			//     goto LABEL_14;
			//   }
			//   v7 = TypeInfo::HGShadowsMidtonesHighlights;
			//   if ( !TypeInfo::HGShadowsMidtonesHighlights._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HGShadowsMidtonesHighlights, wrapperArray);
			//     v7 = TypeInfo::HGShadowsMidtonesHighlights;
			//   }
			//   p_defaultConfig = &v7.static_fields.defaultConfig;
			// LABEL_13:
			//   v9 = p_defaultConfig.midtones;
			//   retstr.shadows = p_defaultConfig.shadows;
			//   v10 = p_defaultConfig.highlights;
			//   retstr.midtones = v9;
			//   v11 = *(_OWORD *)&p_defaultConfig.shadowsStart;
			//   retstr.highlights = v10;
			//   v12 = *(_QWORD *)&p_defaultConfig.shadowsOverriding;
			//   *(_OWORD *)&retstr.shadowsStart = v11;
			// LABEL_14:
			//   *(_QWORD *)&retstr.shadowsOverriding = v12;
			//   return retstr;
			// }
			// 
			return null;
		}

		public HGLiftGammaGain GetLiftGammaGain()
		{
			// // HGLiftGammaGain GetLiftGammaGain()
			// HGLiftGammaGain *HG::Rendering::Runtime::HGColorGradingConfig::GetLiftGammaGain(
			//         HGLiftGammaGain *__return_ptr retstr,
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   struct HGLiftGammaGain__Class *v7; // rax
			//   HGLiftGammaGain *p_defaultConfig; // rax
			//   Vector4 v9; // xmm1
			//   Vector4 v10; // xmm0
			//   int v11; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 gamma; // xmm1
			//   Vector4 gain; // xmm0
			//   HGLiftGammaGain v16; // [rsp+20h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D8EDC0A )
			//   {
			//     sub_18003C530(&TypeInfo::HGLiftGammaGain);
			//     byte_18D8EDC0A = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_15;
			//   if ( wrapperArray.max_length.size > 912 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x390 )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5[19].static_fields )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(912, 0LL);
			//       if ( Patch )
			//       {
			//         p_defaultConfig = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_345(&v16, Patch, this, 0LL);
			//         goto LABEL_13;
			//       }
			//     }
			// LABEL_15:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_9:
			//   if ( this.liftGammaGainEnabled )
			//   {
			//     v11 = *(_DWORD *)&this.liftGammaGain.liftOverriding;
			//     gamma = this.liftGammaGain.gamma;
			//     retstr.lift = this.liftGammaGain.lift;
			//     gain = this.liftGammaGain.gain;
			//     retstr.gamma = gamma;
			//     retstr.gain = gain;
			//     goto LABEL_14;
			//   }
			//   v7 = TypeInfo::HGLiftGammaGain;
			//   if ( !TypeInfo::HGLiftGammaGain._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HGLiftGammaGain, wrapperArray);
			//     v7 = TypeInfo::HGLiftGammaGain;
			//   }
			//   p_defaultConfig = &v7.static_fields.defaultConfig;
			// LABEL_13:
			//   v9 = p_defaultConfig.gamma;
			//   retstr.lift = p_defaultConfig.lift;
			//   v10 = p_defaultConfig.gain;
			//   v11 = *(_DWORD *)&p_defaultConfig.liftOverriding;
			//   retstr.gamma = v9;
			//   retstr.gain = v10;
			// LABEL_14:
			//   *(_DWORD *)&retstr.liftOverriding = v11;
			//   return retstr;
			// }
			// 
			return null;
		}

		public Color GetSplitToningShadows()
		{
			// // Color GetSplitToningShadows()
			// Color *HG::Rendering::Runtime::HGColorGradingConfig::GetSplitToningShadows(
			//         Color *__return_ptr retstr,
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Color *grey; // rax
			//   Color splitToningShadows; // xmm0
			//   Color *result; // rax
			//   ILFixDynamicMethodWrapper_2__Array *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Color v13; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size > 913 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v5.static_fields;
			//     v11 = static_fields.wrapperArray;
			//     if ( static_fields.wrapperArray )
			//     {
			//       if ( v11.max_length.size <= 0x391u )
			//         sub_180070270(static_fields, wrapperArray);
			//       if ( !v11[25].vector[13] )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(913, 0LL);
			//       if ( Patch )
			//       {
			//         grey = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_346(&v13, Patch, this, 0LL);
			//         goto LABEL_9;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.splitToningEnabled )
			//   {
			//     splitToningShadows = this.splitToningShadows;
			//     goto LABEL_10;
			//   }
			//   grey = UnityEngine::Color::get_grey(&v13, (MethodInfo *)wrapperArray);
			// LABEL_9:
			//   splitToningShadows = *grey;
			// LABEL_10:
			//   result = retstr;
			//   *retstr = splitToningShadows;
			//   return result;
			// }
			// 
			return null;
		}

		public Color GetSplitToningHighlights()
		{
			// // Color GetSplitToningHighlights()
			// Color *HG::Rendering::Runtime::HGColorGradingConfig::GetSplitToningHighlights(
			//         Color *__return_ptr retstr,
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Color *grey; // rax
			//   Color splitToningHighlights; // xmm0
			//   Color *result; // rax
			//   ILFixDynamicMethodWrapper_2__Array *v11; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Color v13; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v5.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size > 914 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v5.static_fields;
			//     v11 = static_fields.wrapperArray;
			//     if ( static_fields.wrapperArray )
			//     {
			//       if ( v11.max_length.size <= 0x392u )
			//         sub_180070270(static_fields, wrapperArray);
			//       if ( !v11[25].vector[14] )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(914, 0LL);
			//       if ( Patch )
			//       {
			//         grey = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_346(&v13, Patch, this, 0LL);
			//         goto LABEL_9;
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.splitToningEnabled )
			//   {
			//     splitToningHighlights = this.splitToningHighlights;
			//     goto LABEL_10;
			//   }
			//   grey = UnityEngine::Color::get_grey(&v13, (MethodInfo *)wrapperArray);
			// LABEL_9:
			//   splitToningHighlights = *grey;
			// LABEL_10:
			//   result = retstr;
			//   *retstr = splitToningHighlights;
			//   return result;
			// }
			// 
			return null;
		}

		public float GetSplitToningBalance()
		{
			// // Single GetSplitToningBalance()
			// float HG::Rendering::Runtime::HGColorGradingConfig::GetSplitToningBalance(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 915 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( v3 )
			//     {
			//       if ( LODWORD(v3._0.namespaze) <= 0x393 )
			//         sub_180070270(v3, wrapperArray);
			//       if ( !v3[19]._1.unity_user_data )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(915, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_343(Patch, this, 0LL);
			//     }
			// LABEL_9:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// LABEL_7:
			//   if ( this.splitToningEnabled )
			//     return this.splitToningBalance;
			//   else
			//     return 0.0;
			// }
			// 
			return 0f;
		}

		public HGColorCurve GetColorCurves()
		{
			// // HGColorCurve GetColorCurves()
			// HGColorCurve *HG::Rendering::Runtime::HGColorGradingConfig::GetColorCurves(
			//         HGColorCurve *__return_ptr retstr,
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   struct HGColorCurve__Class *v7; // rax
			//   HGColorCurve *p_defaultConfig; // rax
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   __int64 v12; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __int128 v17; // xmm1
			//   HGColorCurve v18; // [rsp+20h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D8EDC0B )
			//   {
			//     sub_18003C530(&TypeInfo::HGColorCurve);
			//     byte_18D8EDC0B = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_15;
			//   if ( wrapperArray.max_length.size > 916 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x394 )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !*(_QWORD *)&v5[19]._1.initializationExceptionGCHandle )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(916, 0LL);
			//       if ( Patch )
			//       {
			//         p_defaultConfig = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_347(&v18, Patch, this, 0LL);
			//         goto LABEL_13;
			//       }
			//     }
			// LABEL_15:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_9:
			//   if ( this.colorCurvesEnabled )
			//   {
			//     v15 = *(_OWORD *)&this.colorCurves.green;
			//     *(_OWORD *)&retstr.master = *(_OWORD *)&this.colorCurves.master;
			//     v16 = *(_OWORD *)&this.colorCurves.hueVsHue;
			//     *(_OWORD *)&retstr.green = v15;
			//     v17 = *(_OWORD *)&this.colorCurves.satVsSat;
			//     *(_OWORD *)&retstr.hueVsHue = v16;
			//     v12 = *(_QWORD *)&this.colorCurves.masterOverriding;
			//     *(_OWORD *)&retstr.satVsSat = v17;
			//     goto LABEL_14;
			//   }
			//   v7 = TypeInfo::HGColorCurve;
			//   if ( !TypeInfo::HGColorCurve._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HGColorCurve, wrapperArray);
			//     v7 = TypeInfo::HGColorCurve;
			//   }
			//   p_defaultConfig = &v7.static_fields.defaultConfig;
			// LABEL_13:
			//   v9 = *(_OWORD *)&p_defaultConfig.green;
			//   *(_OWORD *)&retstr.master = *(_OWORD *)&p_defaultConfig.master;
			//   v10 = *(_OWORD *)&p_defaultConfig.hueVsHue;
			//   *(_OWORD *)&retstr.green = v9;
			//   v11 = *(_OWORD *)&p_defaultConfig.satVsSat;
			//   *(_OWORD *)&retstr.hueVsHue = v10;
			//   v12 = *(_QWORD *)&p_defaultConfig.masterOverriding;
			//   *(_OWORD *)&retstr.satVsSat = v11;
			// LABEL_14:
			//   *(_QWORD *)&retstr.masterOverriding = v12;
			//   return retstr;
			// }
			// 
			return null;
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		public bool IsToneMappingActive()
		{
			// // Boolean IsToneMappingActive()
			// bool HG::Rendering::Runtime::HGColorGradingConfig::IsToneMappingActive(HGColorGradingConfig *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D919D04 )
			//   {
			//     sub_18003C530(&off_18D532218);
			//     byte_18D919D04 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1186, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1186, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_367(Patch, this, 0LL);
			//   }
			//   else if ( this.tonemappingMode == 4 )
			//   {
			//     HG::Rendering::HGRPLogger::LogWarning((String *)"Tonemapping Mode External is not implemented yet.", 0LL);
			//     return 1;
			//   }
			//   else
			//   {
			//     return this.tonemappingMode != 0;
			//   }
			// }
			// 
			return default(bool);
		}

		public bool IsColorLookupEnabled()
		{
			// // Boolean IsColorLookupEnabled()
			// bool HG::Rendering::Runtime::HGColorGradingConfig::IsColorLookupEnabled(HGColorGradingConfig *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDC0C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig);
			//     byte_18D8EDC0C = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size > 1022 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v3.static_fields;
			//     v7 = static_fields.wrapperArray;
			//     if ( static_fields.wrapperArray )
			//     {
			//       if ( v7.max_length.size <= 0x3FEu )
			//         sub_180070270(static_fields, wrapperArray);
			//       if ( !v7[28].vector[14] )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1022, 0LL);
			//       if ( Patch )
			//         return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_367(Patch, this, 0LL);
			//     }
			// LABEL_11:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			// LABEL_9:
			//   if ( !this.colorLookupEnabled )
			//     return 0;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGColorGradingConfig, wrapperArray);
			//   return HG::Rendering::Runtime::HGColorGradingConfig::ValidateColorLookupLUT(this, 0LL);
			// }
			// 
			return default(bool);
		}

		private bool ValidateColorLookupLUT()
		{
			// // Boolean ValidateColorLookupLUT()
			// bool HG::Rendering::Runtime::HGColorGradingConfig::ValidateColorLookupLUT(
			//         HGColorGradingConfig *this,
			//         MethodInfo *method)
			// {
			//   Object_1 *colorLookupTexture; // rbx
			//   __int64 v4; // rcx
			//   Texture2D *v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919D05 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919D05 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1023, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1023, 0LL);
			//     if ( !Patch )
			//       goto LABEL_11;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_367(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     colorLookupTexture = (Object_1 *)this.colorLookupTexture;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Equality(colorLookupTexture, 0LL, 0LL) )
			//     {
			//       v5 = this.colorLookupTexture;
			//       if ( !v5 )
			//         goto LABEL_11;
			//       if ( (unsigned int)sub_18003ED00(7LL) == 32 )
			//       {
			//         v5 = this.colorLookupTexture;
			//         if ( v5 )
			//           return (unsigned int)sub_18003ED00(5LL) == 1024;
			// LABEL_11:
			//         sub_180B536AC(v4, v5);
			//       }
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static Color _enabledColor;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static Color _disabledColor;

		[Header("色调映射模式")]
		[SerializeField]
		public TonemappingMode tonemappingMode;

		[Header("启用Color Lookup")]
		public bool colorLookupEnabled;

		[Header("LUT")]
		public Texture2D colorLookupTexture;

		[Range(0f, 1f)]
		[Header("Contribution")]
		public float colorLookupContribution;

		[Header("启用White Balance")]
		public bool whiteBalanceEnabled;

		[Header("色温")]
		[Range(-100f, 100f)]
		public float whiteBalanceTemperature;

		[Range(-100f, 100f)]
		[Header("色彩补偿")]
		public float whiteBalanceTint;

		[Header("启用Color Adjustments")]
		public bool colorAdjustmentsEnabled;

		[Header("场景曝光调整")]
		[Range(-16f, 16f)]
		public float colorAdjustmentsPostExposure;

		[Range(-100f, 100f)]
		[Header("对比度")]
		public float colorAdjustmentsContrast;

		[ColorUsage(false, true)]
		[Header("偏色过滤")]
		public Color colorAdjustmentsColorFilter;

		[Header("色相偏移")]
		[Range(-180f, 180f)]
		public float colorAdjustmentsHueShift;

		[Header("饱和度")]
		[Range(-100f, 100f)]
		public float colorAdjustmentsSaturation;

		[Header("启用Channel Mixer")]
		public bool channelMixerEnabled;

		[Header("Red")]
		[Range(-200f, 200f)]
		public float channelMixerRedOutRedIn;

		[Header("Green")]
		[Range(-200f, 200f)]
		public float channelMixerRedOutGreenIn;

		[Range(-200f, 200f)]
		[Header("Blue")]
		public float channelMixerRedOutBlueIn;

		[Header("Red")]
		[Range(-200f, 200f)]
		public float channelMixerGreenOutRedIn;

		[Range(-200f, 200f)]
		[Header("Green")]
		public float channelMixerGreenOutGreenIn;

		[Range(-200f, 200f)]
		[Header("Blue")]
		public float channelMixerGreenOutBlueIn;

		[Header("Red")]
		[Range(-200f, 200f)]
		public float channelMixerBlueOutRedIn;

		[Header("Green")]
		[Range(-200f, 200f)]
		public float channelMixerBlueOutGreenIn;

		[Header("Blue")]
		[Range(-200f, 200f)]
		public float channelMixerBlueOutBlueIn;

		[Header("启用ShadowsMidtonesHighlights")]
		public bool shadowsMidtonesHighlightsEnabled;

		public HGShadowsMidtonesHighlights shadowsMidtonesHighlights;

		[Header("启用LiftGammaGain")]
		public bool liftGammaGainEnabled;

		public HGLiftGammaGain liftGammaGain;

		[Header("启用Split Toning")]
		public bool splitToningEnabled;

		[Header("阴影色调")]
		[ColorUsage(false)]
		public Color splitToningShadows;

		[Header("高光色调")]
		[ColorUsage(false)]
		public Color splitToningHighlights;

		[Header("色调平衡")]
		[Range(-100f, 100f)]
		public float splitToningBalance;

		[Header("启用Color Curves")]
		public bool colorCurvesEnabled;

		public HGColorCurve colorCurves;

		[SerializeField]
		[HideInInspector]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		public static HGColorGradingConfig defaultConfig;
	}
}
