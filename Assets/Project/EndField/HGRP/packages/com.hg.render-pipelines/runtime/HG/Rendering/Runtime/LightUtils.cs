using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class LightUtils // TypeDefIndex: 37803
	{
		// Properties
		private static float s_LuminanceToEvFactor { get => default; } // 0x0000000189D0FA28-0x0000000189D0FA98 
		// Single get_s_LuminanceToEvFactor()
		float HG::Rendering::Runtime::LightUtils::get_s_LuminanceToEvFactor(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  __int64 v2; // r8
		  double v3; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1994, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1994, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    *(float *)&v3 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52((ILFixDynamicMethodWrapper_6 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ColorUtils);
		    v3 = sub_182F114D0(TypeInfo::UnityEngine::Rendering::ColorUtils->static_fields, v1, v2);
		  }
		  return *(float *)&v3;
		}
		
		private static float s_EvToLuminanceFactor { get => default; } // 0x0000000189D0F9B0-0x0000000189D0FA28 
		// Single get_s_EvToLuminanceFactor()
		float HG::Rendering::Runtime::LightUtils::get_s_EvToLuminanceFactor(MethodInfo *method)
		{
		  __int64 v1; // rdx
		  __int64 v2; // r8
		  double v3; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1995, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1995, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52((ILFixDynamicMethodWrapper_6 *)Patch, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ColorUtils);
		    v3 = sub_182F114D0(TypeInfo::UnityEngine::Rendering::ColorUtils->static_fields, v1, v2);
		    return -*(float *)&v3;
		  }
		}
		
	
		// Constructors
		public LightUtils() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		public static float ConvertPointLightLumenToCandela(float intensity) => default; // 0x0000000189D0F138-0x0000000189D0F198
		// Single ConvertPointLightLumenToCandela(Single)
		float HG::Rendering::Runtime::LightUtils::ConvertPointLightLumenToCandela(float intensity, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1996, 0LL) )
		    return intensity / 12.566371;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1996, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v5, v4);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, intensity, 0LL);
		}
		
		public static float ConvertPointLightCandelaToLumen(float intensity) => default; // 0x0000000189D0F0D8-0x0000000189D0F138
		// Single ConvertPointLightCandelaToLumen(Single)
		float HG::Rendering::Runtime::LightUtils::ConvertPointLightCandelaToLumen(float intensity, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1997, 0LL) )
		    return intensity * 12.566371;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1997, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v5, v4);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, intensity, 0LL);
		}
		
		public static float ConvertSpotLightLumenToCandela(float intensity, float angle, bool exact) => default; // 0x0000000189D0F908-0x0000000189D0F9B0
		// Single ConvertSpotLightLumenToCandela(Single, Single, Boolean)
		float HG::Rendering::Runtime::LightUtils::ConvertSpotLightLumenToCandela(
		        float intensity,
		        float angle,
		        bool exact,
		        MethodInfo *method)
		{
		  Beyond::DampingMath *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1998, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1998, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_769(Patch, intensity, angle, exact, 0LL);
		  }
		  else
		  {
		    if ( !exact )
		      return intensity / 3.1415927;
		    Beyond::DampingMath::cosf(v5, angle);
		    return intensity
		         / (float)((float)((float)(1.0 - (float)(angle * 0.5)) + (float)(1.0 - (float)(angle * 0.5))) * 3.1415927);
		  }
		}
		
		public static float ConvertSpotLightCandelaToLumen(float intensity, float angle, bool exact) => default; // 0x0000000189D0F85C-0x0000000189D0F908
		// Single ConvertSpotLightCandelaToLumen(Single, Single, Boolean)
		float HG::Rendering::Runtime::LightUtils::ConvertSpotLightCandelaToLumen(
		        float intensity,
		        float angle,
		        bool exact,
		        MethodInfo *method)
		{
		  Beyond::DampingMath *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1999, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1999, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_769(Patch, intensity, angle, exact, 0LL);
		  }
		  else if ( exact )
		  {
		    Beyond::DampingMath::cosf(v5, angle);
		    return (float)((float)((float)(1.0 - (float)(angle * 0.5)) + (float)(1.0 - (float)(angle * 0.5))) * 3.1415927)
		         * intensity;
		  }
		  else
		  {
		    return intensity * 3.1415927;
		  }
		}
		
		public static float ConvertFrustrumLightLumenToCandela(float intensity, float angleA, float angleB) => default; // 0x0000000189D0EECC-0x0000000189D0EF88
		// Single ConvertFrustrumLightLumenToCandela(Single, Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertFrustrumLightLumenToCandela(
		        float intensity,
		        float angleA,
		        float angleB,
		        MethodInfo *method)
		{
		  Beyond::DampingMath *v4; // rcx
		  Beyond::DampingMath *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2000, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2000, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_98(
		             (ILFixDynamicMethodWrapper_17 *)Patch,
		             intensity,
		             angleA,
		             angleB,
		             0LL);
		  }
		  else
		  {
		    Beyond::DampingMath::sinf(v4, angleA);
		    Beyond::DampingMath::sinf(v5, angleA);
		    return intensity / (float)(sub_180334170() * 4.0);
		  }
		}
		
		public static float ConvertFrustrumLightCandelaToLumen(float intensity, float angleA, float angleB) => default; // 0x0000000189D0EE14-0x0000000189D0EECC
		// Single ConvertFrustrumLightCandelaToLumen(Single, Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertFrustrumLightCandelaToLumen(
		        float intensity,
		        float angleA,
		        float angleB,
		        MethodInfo *method)
		{
		  Beyond::DampingMath *v4; // rcx
		  Beyond::DampingMath *v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2001, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2001, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_98(
		             (ILFixDynamicMethodWrapper_17 *)Patch,
		             intensity,
		             angleA,
		             angleB,
		             0LL);
		  }
		  else
		  {
		    Beyond::DampingMath::sinf(v4, angleA);
		    Beyond::DampingMath::sinf(v5, angleA);
		    return (float)(sub_180334170() * 4.0) * intensity;
		  }
		}
		
		public static float ConvertSphereLightLumenToLuminance(float intensity, float sphereRadius) => default; // 0x0000000189D0F768-0x0000000189D0F7E4
		// Single ConvertSphereLightLumenToLuminance(Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertSphereLightLumenToLuminance(
		        float intensity,
		        float sphereRadius,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2002, 0LL) )
		    return intensity / (float)((float)((float)(sphereRadius * 12.566371) * sphereRadius) * 3.1415927);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2002, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, intensity, sphereRadius, 0LL);
		}
		
		public static float ConvertSphereLightLuminanceToLumen(float intensity, float sphereRadius) => default; // 0x0000000189D0F7E4-0x0000000189D0F85C
		// Single ConvertSphereLightLuminanceToLumen(Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertSphereLightLuminanceToLumen(
		        float intensity,
		        float sphereRadius,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2003, 0LL) )
		    return (float)((float)((float)(sphereRadius * 12.566371) * sphereRadius) * 3.1415927) * intensity;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2003, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, intensity, sphereRadius, 0LL);
		}
		
		public static float ConvertDiscLightLumenToLuminance(float intensity, float discRadius) => default; // 0x0000000189D0EBE8-0x0000000189D0EC60
		// Single ConvertDiscLightLumenToLuminance(Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertDiscLightLumenToLuminance(
		        float intensity,
		        float discRadius,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2004, 0LL) )
		    return intensity / (float)((float)((float)(discRadius * discRadius) * 3.1415927) * 3.1415927);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2004, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, intensity, discRadius, 0LL);
		}
		
		public static float ConvertDiscLightLuminanceToLumen(float intensity, float discRadius) => default; // 0x0000000189D0EC60-0x0000000189D0ECD8
		// Single ConvertDiscLightLuminanceToLumen(Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertDiscLightLuminanceToLumen(
		        float intensity,
		        float discRadius,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2005, 0LL) )
		    return (float)((float)((float)(discRadius * discRadius) * 3.1415927) * 3.1415927) * intensity;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2005, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, intensity, discRadius, 0LL);
		}
		
		public static float ConvertRectLightLumenToLuminance(float intensity, float width, float height) => default; // 0x0000000189D0F658-0x0000000189D0F6E0
		// Single ConvertRectLightLumenToLuminance(Single, Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertRectLightLumenToLuminance(
		        float intensity,
		        float width,
		        float height,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2006, 0LL) )
		    return intensity / (float)((float)(width * height) * 3.1415927);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2006, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v7, v6);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_98(
		           (ILFixDynamicMethodWrapper_17 *)Patch,
		           intensity,
		           width,
		           height,
		           0LL);
		}
		
		public static float ConvertRectLightLuminanceToLumen(float intensity, float width, float height) => default; // 0x0000000189D0F6E0-0x0000000189D0F768
		// Single ConvertRectLightLuminanceToLumen(Single, Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertRectLightLuminanceToLumen(
		        float intensity,
		        float width,
		        float height,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2007, 0LL) )
		    return (float)((float)(width * height) * 3.1415927) * intensity;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2007, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v7, v6);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_98(
		           (ILFixDynamicMethodWrapper_17 *)Patch,
		           intensity,
		           width,
		           height,
		           0LL);
		}
		
		public static float ConvertLuxToCandela(float lux, float distance) => default; // 0x0000000189D0EFFC-0x0000000189D0F064
		// Single ConvertLuxToCandela(Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertLuxToCandela(float lux, float distance, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2008, 0LL) )
		    return (float)(lux * distance) * distance;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2008, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, lux, distance, 0LL);
		}
		
		public static float ConvertCandelaToLux(float candela, float distance) => default; // 0x0000000189D0EB80-0x0000000189D0EBE8
		// Single ConvertCandelaToLux(Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertCandelaToLux(float candela, float distance, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2009, 0LL) )
		    return candela / (float)(distance * distance);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2009, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, candela, distance, 0LL);
		}
		
		public static float ConvertEvToLuminance(float ev) => default; // 0x0000000189D0ED34-0x0000000189D0EDA4
		// Single ConvertEvToLuminance(Single)
		float HG::Rendering::Runtime::LightUtils::ConvertEvToLuminance(float ev, MethodInfo *method)
		{
		  double v2; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2010, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2010, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    *(float *)&v2 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, ev, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::LightUtils::get_s_EvToLuminanceFactor(0LL);
		    v2 = sub_1803369A0();
		  }
		  return *(float *)&v2;
		}
		
		public static float ConvertEvToCandela(float ev) => default; // 0x0000000189D0ECD8-0x0000000189D0ED34
		// Single ConvertEvToCandela(Single)
		float HG::Rendering::Runtime::LightUtils::ConvertEvToCandela(float ev, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2011, 0LL) )
		    return HG::Rendering::Runtime::LightUtils::ConvertEvToLuminance(ev, 0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2011, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v5, v4);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, ev, 0LL);
		}
		
		public static float ConvertEvToLux(float ev, float distance) => default; // 0x0000000189D0EDA4-0x0000000189D0EE14
		// Single ConvertEvToLux(Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertEvToLux(float ev, float distance, MethodInfo *method)
		{
		  float v3; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2012, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2012, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, ev, distance, 0LL);
		  }
		  else
		  {
		    v3 = HG::Rendering::Runtime::LightUtils::ConvertEvToLuminance(ev, 0LL);
		    return HG::Rendering::Runtime::LightUtils::ConvertCandelaToLux(v3, distance, 0LL);
		  }
		}
		
		public static float ConvertLuminanceToEv(float luminance) => default; // 0x0000000189D0EF88-0x0000000189D0EFFC
		// Single ConvertLuminanceToEv(Single)
		float HG::Rendering::Runtime::LightUtils::ConvertLuminanceToEv(float luminance, MethodInfo *method)
		{
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  __int64 v4; // r8
		  double v5; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2013, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2013, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, luminance, 0LL);
		  }
		  else
		  {
		    v5 = sub_182F114D0(v3, v2, v4);
		    return HG::Rendering::Runtime::LightUtils::get_s_LuminanceToEvFactor(0LL) + *(float *)&v5;
		  }
		}
		
		public static float ConvertCandelaToEv(float candela) => default; // 0x0000000189D0EB24-0x0000000189D0EB80
		// Single ConvertCandelaToEv(Single)
		float HG::Rendering::Runtime::LightUtils::ConvertCandelaToEv(float candela, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2014, 0LL) )
		    return HG::Rendering::Runtime::LightUtils::ConvertLuminanceToEv(candela, 0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2014, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v5, v4);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, candela, 0LL);
		}
		
		public static float ConvertLuxToEv(float lux, float distance) => default; // 0x0000000189D0F064-0x0000000189D0F0D8
		// Single ConvertLuxToEv(Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertLuxToEv(float lux, float distance, MethodInfo *method)
		{
		  float v3; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2015, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2015, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, lux, distance, 0LL);
		  }
		  else
		  {
		    v3 = HG::Rendering::Runtime::LightUtils::ConvertLuxToCandela(lux, distance, 0LL);
		    return HG::Rendering::Runtime::LightUtils::ConvertLuminanceToEv(v3, 0LL);
		  }
		}
		
		public static float ConvertPunctualLightLumenToCandela(HGLightType lightType, float lumen, float initialIntensity, bool enableSpotReflector) => default; // 0x0000000189D0F394-0x0000000189D0F428
		// Single ConvertPunctualLightLumenToCandela(HGLightType, Single, Single, Boolean)
		float HG::Rendering::Runtime::LightUtils::ConvertPunctualLightLumenToCandela(
		        HGLightType__Enum lightType,
		        float lumen,
		        float initialIntensity,
		        bool enableSpotReflector,
		        MethodInfo *method)
		{
		  BOOL P3; // ebx
		  BOOL v7; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  P3 = enableSpotReflector;
		  if ( IFix::WrappersManagerImpl::IsPatched(2016, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2016, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_805(Patch, lightType, lumen, initialIntensity, P3, 0LL);
		  }
		  else
		  {
		    v7 = 0;
		    if ( lightType == HGLightType__Enum_Spot )
		      v7 = P3;
		    if ( v7 )
		      return initialIntensity;
		    else
		      return HG::Rendering::Runtime::LightUtils::ConvertPointLightLumenToCandela(lumen, 0LL);
		  }
		}
		
		public static float ConvertPunctualLightLumenToLux(HGLightType lightType, float lumen, float initialIntensity, bool enableSpotReflector, float distance) => default; // 0x0000000189D0F4BC-0x0000000189D0F56C
		// Single ConvertPunctualLightLumenToLux(HGLightType, Single, Single, Boolean, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertPunctualLightLumenToLux(
		        HGLightType__Enum lightType,
		        float lumen,
		        float initialIntensity,
		        bool enableSpotReflector,
		        float distance,
		        MethodInfo *method)
		{
		  float v8; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2017, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2017, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_806(
		             Patch,
		             lightType,
		             lumen,
		             initialIntensity,
		             enableSpotReflector,
		             distance,
		             0LL);
		  }
		  else
		  {
		    v8 = HG::Rendering::Runtime::LightUtils::ConvertPunctualLightLumenToCandela(
		           lightType,
		           lumen,
		           initialIntensity,
		           enableSpotReflector,
		           0LL);
		    return HG::Rendering::Runtime::LightUtils::ConvertCandelaToLux(v8, distance, 0LL);
		  }
		}
		
		public static float ConvertPunctualLightCandelaToLumen(HGLightType lightType, SpotLightShape spotLightShape, float candela, bool enableSpotReflector, float spotAngle, float aspectRatio) => default; // 0x0000000189D0F198-0x0000000189D0F2C4
		// Single ConvertPunctualLightCandelaToLumen(HGLightType, SpotLightShape, Single, Boolean, Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertPunctualLightCandelaToLumen(
		        HGLightType__Enum lightType,
		        SpotLightShape__Enum spotLightShape,
		        float candela,
		        bool enableSpotReflector,
		        float spotAngle,
		        float aspectRatio,
		        MethodInfo *method)
		{
		  BOOL P3; // edi
		  BOOL v10; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  float angleB; // [rsp+40h] [rbp-28h] BYREF
		  float angleA[3]; // [rsp+44h] [rbp-24h] BYREF
		
		  angleA[0] = 0.0;
		  angleB = 0.0;
		  P3 = enableSpotReflector;
		  if ( IFix::WrappersManagerImpl::IsPatched(2018, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2018, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_808(
		             Patch,
		             lightType,
		             spotLightShape,
		             candela,
		             P3,
		             spotAngle,
		             aspectRatio,
		             0LL);
		  }
		  else
		  {
		    v10 = 0;
		    if ( lightType == HGLightType__Enum_Spot )
		      v10 = P3;
		    if ( !v10 )
		      return HG::Rendering::Runtime::LightUtils::ConvertPointLightCandelaToLumen(candela, 0LL);
		    if ( spotLightShape )
		    {
		      if ( spotLightShape != SpotLightShape__Enum_Pyramid )
		        return HG::Rendering::Runtime::LightUtils::ConvertPointLightCandelaToLumen(candela, 0LL);
		      HG::Rendering::Runtime::LightUtils::CalculateAnglesForPyramid(
		        aspectRatio,
		        spotAngle * 0.017453292,
		        angleA,
		        &angleB,
		        0LL);
		      return HG::Rendering::Runtime::LightUtils::ConvertFrustrumLightCandelaToLumen(candela, angleA[0], angleB, 0LL);
		    }
		    else
		    {
		      return HG::Rendering::Runtime::LightUtils::ConvertSpotLightCandelaToLumen(
		               candela,
		               spotAngle * 0.017453292,
		               1,
		               0LL);
		    }
		  }
		}
		
		public static float ConvertPunctualLightLuxToLumen(HGLightType lightType, SpotLightShape spotLightShape, float lux, bool enableSpotReflector, float spotAngle, float aspectRatio, float distance) => default; // 0x0000000189D0F56C-0x0000000189D0F658
		// Single ConvertPunctualLightLuxToLumen(HGLightType, SpotLightShape, Single, Boolean, Single, Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertPunctualLightLuxToLumen(
		        HGLightType__Enum lightType,
		        SpotLightShape__Enum spotLightShape,
		        float lux,
		        bool enableSpotReflector,
		        float spotAngle,
		        float aspectRatio,
		        float distance,
		        MethodInfo *method)
		{
		  float v11; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2020, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2020, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v15, v14);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_809(
		             Patch,
		             lightType,
		             spotLightShape,
		             lux,
		             enableSpotReflector,
		             spotAngle,
		             aspectRatio,
		             distance,
		             0LL);
		  }
		  else
		  {
		    v11 = HG::Rendering::Runtime::LightUtils::ConvertLuxToCandela(lux, distance, 0LL);
		    return HG::Rendering::Runtime::LightUtils::ConvertPunctualLightCandelaToLumen(
		             lightType,
		             spotLightShape,
		             v11,
		             enableSpotReflector,
		             spotAngle,
		             aspectRatio,
		             0LL);
		  }
		}
		
		public static float ConvertPunctualLightEvToLumen(HGLightType lightType, SpotLightShape spotLightShape, float ev, bool enableSpotReflector, float spotAngle, float aspectRatio) => default; // 0x0000000189D0F2C4-0x0000000189D0F394
		// Single ConvertPunctualLightEvToLumen(HGLightType, SpotLightShape, Single, Boolean, Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertPunctualLightEvToLumen(
		        HGLightType__Enum lightType,
		        SpotLightShape__Enum spotLightShape,
		        float ev,
		        bool enableSpotReflector,
		        float spotAngle,
		        float aspectRatio,
		        MethodInfo *method)
		{
		  float v10; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2021, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2021, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_808(
		             Patch,
		             lightType,
		             spotLightShape,
		             ev,
		             enableSpotReflector,
		             spotAngle,
		             aspectRatio,
		             0LL);
		  }
		  else
		  {
		    v10 = HG::Rendering::Runtime::LightUtils::ConvertEvToCandela(ev, 0LL);
		    return HG::Rendering::Runtime::LightUtils::ConvertPunctualLightCandelaToLumen(
		             lightType,
		             spotLightShape,
		             v10,
		             enableSpotReflector,
		             spotAngle,
		             aspectRatio,
		             0LL);
		  }
		}
		
		public static float ConvertPunctualLightLumenToEv(HGLightType lightType, float lumen, float initialIntensity, bool enableSpotReflector) => default; // 0x0000000189D0F428-0x0000000189D0F4BC
		// Single ConvertPunctualLightLumenToEv(HGLightType, Single, Single, Boolean)
		float HG::Rendering::Runtime::LightUtils::ConvertPunctualLightLumenToEv(
		        HGLightType__Enum lightType,
		        float lumen,
		        float initialIntensity,
		        bool enableSpotReflector,
		        MethodInfo *method)
		{
		  float v7; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2022, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2022, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_805(
		             Patch,
		             lightType,
		             lumen,
		             initialIntensity,
		             enableSpotReflector,
		             0LL);
		  }
		  else
		  {
		    v7 = HG::Rendering::Runtime::LightUtils::ConvertPunctualLightLumenToCandela(
		           lightType,
		           lumen,
		           initialIntensity,
		           enableSpotReflector,
		           0LL);
		    return HG::Rendering::Runtime::LightUtils::ConvertCandelaToEv(v7, 0LL);
		  }
		}
		
		public static float ConvertAreaLightLumenToLuminance(AreaLightShape areaLightShape, float lumen, float width, float height = 0f /* Metadata: 0x02303156 */) => default; // 0x0000000189D0E9B4-0x0000000189D0EA6C
		// Single ConvertAreaLightLumenToLuminance(AreaLightShape, Single, Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertAreaLightLumenToLuminance(
		        AreaLightShape__Enum areaLightShape,
		        float lumen,
		        float width,
		        float height,
		        MethodInfo *method)
		{
		  float result; // xmm0_4
		  unsigned __int32 v7; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2023, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2023, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_810(Patch, areaLightShape, lumen, width, height, 0LL);
		  }
		  else
		  {
		    result = lumen;
		    if ( areaLightShape )
		    {
		      v7 = areaLightShape - 1;
		      if ( v7 )
		      {
		        if ( v7 == 1 )
		          return HG::Rendering::Runtime::LightUtils::ConvertDiscLightLumenToLuminance(lumen, width, 0LL);
		      }
		      else
		      {
		        return HG::Rendering::Runtime::LightUtils::CalculateLineLightLumenToLuminance(lumen, width, 0LL);
		      }
		    }
		    else
		    {
		      return HG::Rendering::Runtime::LightUtils::ConvertRectLightLumenToLuminance(lumen, width, height, 0LL);
		    }
		  }
		  return result;
		}
		
		public static float ConvertAreaLightLuminanceToLumen(AreaLightShape areaLightShape, float luminance, float width, float height = 0f /* Metadata: 0x0230315A */) => default; // 0x0000000189D0EA6C-0x0000000189D0EB24
		// Single ConvertAreaLightLuminanceToLumen(AreaLightShape, Single, Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertAreaLightLuminanceToLumen(
		        AreaLightShape__Enum areaLightShape,
		        float luminance,
		        float width,
		        float height,
		        MethodInfo *method)
		{
		  float result; // xmm0_4
		  unsigned __int32 v7; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2025, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2025, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_810(Patch, areaLightShape, luminance, width, height, 0LL);
		  }
		  else
		  {
		    result = luminance;
		    if ( areaLightShape )
		    {
		      v7 = areaLightShape - 1;
		      if ( v7 )
		      {
		        if ( v7 == 1 )
		          return HG::Rendering::Runtime::LightUtils::ConvertDiscLightLuminanceToLumen(luminance, width, 0LL);
		      }
		      else
		      {
		        return HG::Rendering::Runtime::LightUtils::CalculateLineLightLuminanceToLumen(luminance, width, 0LL);
		      }
		    }
		    else
		    {
		      return HG::Rendering::Runtime::LightUtils::ConvertRectLightLuminanceToLumen(luminance, width, height, 0LL);
		    }
		  }
		  return result;
		}
		
		public static float ConvertAreaLightLumenToEv(AreaLightShape AreaLightShape, float lumen, float width, float height) => default; // 0x0000000189D0E918-0x0000000189D0E9B4
		// Single ConvertAreaLightLumenToEv(AreaLightShape, Single, Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertAreaLightLumenToEv(
		        AreaLightShape__Enum AreaLightShape,
		        float lumen,
		        float width,
		        float height,
		        MethodInfo *method)
		{
		  float v6; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2027, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2027, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_810(Patch, AreaLightShape, lumen, width, height, 0LL);
		  }
		  else
		  {
		    v6 = HG::Rendering::Runtime::LightUtils::ConvertAreaLightLumenToLuminance(AreaLightShape, lumen, width, height, 0LL);
		    return HG::Rendering::Runtime::LightUtils::ConvertLuminanceToEv(v6, 0LL);
		  }
		}
		
		public static float ConvertAreaLightEvToLumen(AreaLightShape AreaLightShape, float ev, float width, float height) => default; // 0x0000000189D0E878-0x0000000189D0E918
		// Single ConvertAreaLightEvToLumen(AreaLightShape, Single, Single, Single)
		float HG::Rendering::Runtime::LightUtils::ConvertAreaLightEvToLumen(
		        AreaLightShape__Enum AreaLightShape,
		        float ev,
		        float width,
		        float height,
		        MethodInfo *method)
		{
		  float v6; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2028, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2028, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_810(Patch, AreaLightShape, ev, width, height, 0LL);
		  }
		  else
		  {
		    v6 = HG::Rendering::Runtime::LightUtils::ConvertEvToLuminance(ev, 0LL);
		    return HG::Rendering::Runtime::LightUtils::ConvertAreaLightLuminanceToLumen(AreaLightShape, v6, width, height, 0LL);
		  }
		}
		
		public static float CalculateLineLightLumenToLuminance(float intensity, float lineWidth) => default; // 0x0000000189D0E7A0-0x0000000189D0E80C
		// Single CalculateLineLightLumenToLuminance(Single, Single)
		float HG::Rendering::Runtime::LightUtils::CalculateLineLightLumenToLuminance(
		        float intensity,
		        float lineWidth,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2024, 0LL) )
		    return intensity / (float)(lineWidth * 12.566371);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2024, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, intensity, lineWidth, 0LL);
		}
		
		public static float CalculateLineLightLuminanceToLumen(float intensity, float lineWidth) => default; // 0x0000000189D0E80C-0x0000000189D0E878
		// Single CalculateLineLightLuminanceToLumen(Single, Single)
		float HG::Rendering::Runtime::LightUtils::CalculateLineLightLuminanceToLumen(
		        float intensity,
		        float lineWidth,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2026, 0LL) )
		    return (float)(lineWidth * 12.566371) * intensity;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2026, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, intensity, lineWidth, 0LL);
		}
		
		public static void CalculateAnglesForPyramid(float aspectRatio, float spotAngle, out float angleA, out float angleB) {
			angleA = default;
			angleB = default;
		} // 0x0000000189D0E6EC-0x0000000189D0E7A0
		// Void CalculateAnglesForPyramid(Single, Single, Single ByRef, Single ByRef)
		void HG::Rendering::Runtime::LightUtils::CalculateAnglesForPyramid(
		        float aspectRatio,
		        float spotAngle,
		        float *angleA,
		        float *angleB,
		        MethodInfo *method)
		{
		  float v7; // xmm6_4
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  __int64 v10; // r8
		  __int64 v11; // r9
		  float v12; // xmm0_4
		  Beyond::DampingMath *v13; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		
		  v7 = aspectRatio;
		  if ( IFix::WrappersManagerImpl::IsPatched(2019, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2019, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v16, v15);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_807(Patch, aspectRatio, spotAngle, angleA, angleB, 0LL);
		  }
		  else
		  {
		    if ( aspectRatio < 1.0 )
		      v7 = 1.0 / aspectRatio;
		    *angleA = spotAngle;
		    v12 = sub_180338A80(v9, v8, v10, v11) * v7;
		    Beyond::DampingMath::fast_atan(v13, spotAngle);
		    *angleB = v12 + v12;
		  }
		}
		
	}
}
