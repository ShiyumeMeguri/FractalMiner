using System;

namespace HG.Rendering.Runtime
{
	internal class LightUtils
	{
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x000025F0 File Offset: 0x000007F0
		private static float s_LuminanceToEvFactor
		{
			get
			{
				// // Single get_s_LuminanceToEvFactor()
				// float HG::Rendering::Runtime::LightUtils::get_s_LuminanceToEvFactor(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   __int64 v2; // r8
				//   double v3; // xmm0_8
				// 
				//   if ( !byte_18D919E44 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorUtils);
				//     byte_18D919E44 = 1;
				//   }
				//   if ( !TypeInfo::UnityEngine::Rendering::ColorUtils._1.cctor_finished_or_no_cctor )
				//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::ColorUtils, v1);
				//   v3 = sub_182376F20(method, v1, v2);
				//   return *(float *)&v3;
				// }
				// 
				return 0f;
			}
		}

		// (get) Token: 0x060008DE RID: 2270 RVA: 0x000025F0 File Offset: 0x000007F0
		private static float s_EvToLuminanceFactor
		{
			get
			{
				// // Single get_s_EvToLuminanceFactor()
				// float HG::Rendering::Runtime::LightUtils::get_s_EvToLuminanceFactor(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   __int64 v2; // r8
				//   double v3; // xmm0_8
				// 
				//   if ( !byte_18D919E45 )
				//   {
				//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ColorUtils);
				//     byte_18D919E45 = 1;
				//   }
				//   sub_180002C70(TypeInfo::UnityEngine::Rendering::ColorUtils);
				//   v3 = sub_182376F20(TypeInfo::UnityEngine::Rendering::ColorUtils.static_fields, v1, v2);
				//   return -*(float *)&v3;
				// }
				// 
				return 0f;
			}
		}

		public LightUtils()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public static float ConvertPointLightLumenToCandela(float intensity)
		{
			// // Single ConvertPointLightLumenToCandela(Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertPointLightLumenToCandela(float intensity, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1682, 0LL) )
			//     return intensity / 12.566371;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1682, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v5, v4);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, intensity, 0LL);
			// }
			// 
			return 0f;
		}

		public static float ConvertPointLightCandelaToLumen(float intensity)
		{
			// // Single ConvertPointLightCandelaToLumen(Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertPointLightCandelaToLumen(float intensity, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1683, 0LL) )
			//     return intensity * 12.566371;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1683, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v5, v4);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, intensity, 0LL);
			// }
			// 
			return 0f;
		}

		public static float ConvertSpotLightLumenToCandela(float intensity, float angle, bool exact)
		{
			// // Single ConvertSpotLightLumenToCandela(Single, Single, Boolean)
			// float HG::Rendering::Runtime::LightUtils::ConvertSpotLightLumenToCandela(
			//         float intensity,
			//         float angle,
			//         bool exact,
			//         MethodInfo *method)
			// {
			//   double v6; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1684, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1684, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_616(Patch, intensity, angle, exact, 0LL);
			//   }
			//   else
			//   {
			//     if ( !exact )
			//       return intensity / 3.1415927;
			//     v6 = Beyond::DampingMath::cosf();
			//     return intensity / (float)((float)((float)(1.0 - *(float *)&v6) + (float)(1.0 - *(float *)&v6)) * 3.1415927);
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertSpotLightCandelaToLumen(float intensity, float angle, bool exact)
		{
			// // Single ConvertSpotLightCandelaToLumen(Single, Single, Boolean)
			// float HG::Rendering::Runtime::LightUtils::ConvertSpotLightCandelaToLumen(
			//         float intensity,
			//         float angle,
			//         bool exact,
			//         MethodInfo *method)
			// {
			//   double v6; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1685, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1685, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_616(Patch, intensity, angle, exact, 0LL);
			//   }
			//   else if ( exact )
			//   {
			//     v6 = Beyond::DampingMath::cosf();
			//     return (float)((float)((float)(1.0 - *(float *)&v6) + (float)(1.0 - *(float *)&v6)) * 3.1415927) * intensity;
			//   }
			//   else
			//   {
			//     return intensity * 3.1415927;
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertFrustrumLightLumenToCandela(float intensity, float angleA, float angleB)
		{
			// // Single ConvertFrustrumLightLumenToCandela(Single, Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertFrustrumLightLumenToCandela(
			//         float intensity,
			//         float angleA,
			//         float angleB,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1686, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1686, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_89(
			//              (ILFixDynamicMethodWrapper_17 *)Patch,
			//              intensity,
			//              angleA,
			//              angleB,
			//              0LL);
			//   }
			//   else
			//   {
			//     Beyond::DampingMath::sinf();
			//     Beyond::DampingMath::sinf();
			//     return intensity / (float)(sub_1802E8980(v6, v5) * 4.0);
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertFrustrumLightCandelaToLumen(float intensity, float angleA, float angleB)
		{
			// // Single ConvertFrustrumLightCandelaToLumen(Single, Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertFrustrumLightCandelaToLumen(
			//         float intensity,
			//         float angleA,
			//         float angleB,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1687, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1687, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_89(
			//              (ILFixDynamicMethodWrapper_17 *)Patch,
			//              intensity,
			//              angleA,
			//              angleB,
			//              0LL);
			//   }
			//   else
			//   {
			//     Beyond::DampingMath::sinf();
			//     Beyond::DampingMath::sinf();
			//     return (float)(sub_1802E8980(v6, v5) * 4.0) * intensity;
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertSphereLightLumenToLuminance(float intensity, float sphereRadius)
		{
			// // Single ConvertSphereLightLumenToLuminance(Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertSphereLightLumenToLuminance(
			//         float intensity,
			//         float sphereRadius,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1688, 0LL) )
			//     return intensity / (float)((float)((float)(sphereRadius * 12.566371) * sphereRadius) * 3.1415927);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1688, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(
			//            (ILFixDynamicMethodWrapper_3 *)Patch,
			//            intensity,
			//            sphereRadius,
			//            0LL);
			// }
			// 
			return 0f;
		}

		public static float ConvertSphereLightLuminanceToLumen(float intensity, float sphereRadius)
		{
			// // Single ConvertSphereLightLuminanceToLumen(Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertSphereLightLuminanceToLumen(
			//         float intensity,
			//         float sphereRadius,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1689, 0LL) )
			//     return (float)((float)((float)(sphereRadius * 12.566371) * sphereRadius) * 3.1415927) * intensity;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1689, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(
			//            (ILFixDynamicMethodWrapper_3 *)Patch,
			//            intensity,
			//            sphereRadius,
			//            0LL);
			// }
			// 
			return 0f;
		}

		public static float ConvertDiscLightLumenToLuminance(float intensity, float discRadius)
		{
			// // Single ConvertDiscLightLumenToLuminance(Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertDiscLightLumenToLuminance(
			//         float intensity,
			//         float discRadius,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1690, 0LL) )
			//     return intensity / (float)((float)((float)(discRadius * discRadius) * 3.1415927) * 3.1415927);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1690, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(
			//            (ILFixDynamicMethodWrapper_3 *)Patch,
			//            intensity,
			//            discRadius,
			//            0LL);
			// }
			// 
			return 0f;
		}

		public static float ConvertDiscLightLuminanceToLumen(float intensity, float discRadius)
		{
			// // Single ConvertDiscLightLuminanceToLumen(Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertDiscLightLuminanceToLumen(
			//         float intensity,
			//         float discRadius,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1691, 0LL) )
			//     return (float)((float)((float)(discRadius * discRadius) * 3.1415927) * 3.1415927) * intensity;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1691, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(
			//            (ILFixDynamicMethodWrapper_3 *)Patch,
			//            intensity,
			//            discRadius,
			//            0LL);
			// }
			// 
			return 0f;
		}

		public static float ConvertRectLightLumenToLuminance(float intensity, float width, float height)
		{
			// // Single ConvertRectLightLumenToLuminance(Single, Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertRectLightLumenToLuminance(
			//         float intensity,
			//         float width,
			//         float height,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1692, 0LL) )
			//     return intensity / (float)((float)(width * height) * 3.1415927);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1692, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v7, v6);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_89(
			//            (ILFixDynamicMethodWrapper_17 *)Patch,
			//            intensity,
			//            width,
			//            height,
			//            0LL);
			// }
			// 
			return 0f;
		}

		public static float ConvertRectLightLuminanceToLumen(float intensity, float width, float height)
		{
			// // Single ConvertRectLightLuminanceToLumen(Single, Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertRectLightLuminanceToLumen(
			//         float intensity,
			//         float width,
			//         float height,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1693, 0LL) )
			//     return (float)((float)(width * height) * 3.1415927) * intensity;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1693, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v7, v6);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_89(
			//            (ILFixDynamicMethodWrapper_17 *)Patch,
			//            intensity,
			//            width,
			//            height,
			//            0LL);
			// }
			// 
			return 0f;
		}

		public static float ConvertLuxToCandela(float lux, float distance)
		{
			// // Single ConvertLuxToCandela(Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertLuxToCandela(float lux, float distance, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1694, 0LL) )
			//     return (float)(lux * distance) * distance;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1694, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359((ILFixDynamicMethodWrapper_3 *)Patch, lux, distance, 0LL);
			// }
			// 
			return 0f;
		}

		public static float ConvertCandelaToLux(float candela, float distance)
		{
			// // Single ConvertCandelaToLux(Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertCandelaToLux(float candela, float distance, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1695, 0LL) )
			//     return candela / (float)(distance * distance);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1695, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359((ILFixDynamicMethodWrapper_3 *)Patch, candela, distance, 0LL);
			// }
			// 
			return 0f;
		}

		public static float ConvertEvToLuminance(float ev)
		{
			// // Single ConvertEvToLuminance(Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertEvToLuminance(float ev, MethodInfo *method)
			// {
			//   __int64 v2; // rdx
			//   int v3; // ecx
			//   double v4; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1696, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1696, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *(float *)&v4 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, ev, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::LightUtils::get_s_EvToLuminanceFactor(0LL);
			//     v4 = sub_1802EB1B0(v3, v2);
			//   }
			//   return *(float *)&v4;
			// }
			// 
			return 0f;
		}

		public static float ConvertEvToCandela(float ev)
		{
			// // Single ConvertEvToCandela(Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertEvToCandela(float ev, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1697, 0LL) )
			//     return HG::Rendering::Runtime::LightUtils::ConvertEvToLuminance(ev, 0LL);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1697, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v5, v4);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, ev, 0LL);
			// }
			// 
			return 0f;
		}

		public static float ConvertEvToLux(float ev, float distance)
		{
			// // Single ConvertEvToLux(Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertEvToLux(float ev, float distance, MethodInfo *method)
			// {
			//   float v3; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1698, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1698, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359((ILFixDynamicMethodWrapper_3 *)Patch, ev, distance, 0LL);
			//   }
			//   else
			//   {
			//     v3 = HG::Rendering::Runtime::LightUtils::ConvertEvToLuminance(ev, 0LL);
			//     return HG::Rendering::Runtime::LightUtils::ConvertCandelaToLux(v3, distance, 0LL);
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertLuminanceToEv(float luminance)
		{
			// // Single ConvertLuminanceToEv(Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertLuminanceToEv(float luminance, MethodInfo *method)
			// {
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			//   __int64 v4; // r8
			//   double v5; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1699, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1699, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, luminance, 0LL);
			//   }
			//   else
			//   {
			//     v5 = sub_182376F20(v3, v2, v4);
			//     return HG::Rendering::Runtime::LightUtils::get_s_LuminanceToEvFactor(0LL) + *(float *)&v5;
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertCandelaToEv(float candela)
		{
			// // Single ConvertCandelaToEv(Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertCandelaToEv(float candela, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1700, 0LL) )
			//     return HG::Rendering::Runtime::LightUtils::ConvertLuminanceToEv(candela, 0LL);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1700, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v5, v4);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, candela, 0LL);
			// }
			// 
			return 0f;
		}

		public static float ConvertLuxToEv(float lux, float distance)
		{
			// // Single ConvertLuxToEv(Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertLuxToEv(float lux, float distance, MethodInfo *method)
			// {
			//   float v3; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1701, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1701, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359((ILFixDynamicMethodWrapper_3 *)Patch, lux, distance, 0LL);
			//   }
			//   else
			//   {
			//     v3 = HG::Rendering::Runtime::LightUtils::ConvertLuxToCandela(lux, distance, 0LL);
			//     return HG::Rendering::Runtime::LightUtils::ConvertLuminanceToEv(v3, 0LL);
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertPunctualLightLumenToCandela(HGLightType lightType, float lumen, float initialIntensity, bool enableSpotReflector)
		{
			// // Single ConvertPunctualLightLumenToCandela(HGLightType, Single, Single, Boolean)
			// float HG::Rendering::Runtime::LightUtils::ConvertPunctualLightLumenToCandela(
			//         HGLightType__Enum lightType,
			//         float lumen,
			//         float initialIntensity,
			//         bool enableSpotReflector,
			//         MethodInfo *method)
			// {
			//   BOOL P3; // ebx
			//   BOOL v7; // edx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   P3 = enableSpotReflector;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1702, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1702, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_651(Patch, lightType, lumen, initialIntensity, P3, 0LL);
			//   }
			//   else
			//   {
			//     v7 = 0;
			//     if ( lightType == HGLightType__Enum_Spot )
			//       v7 = P3;
			//     if ( v7 )
			//       return initialIntensity;
			//     else
			//       return HG::Rendering::Runtime::LightUtils::ConvertPointLightLumenToCandela(lumen, 0LL);
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertPunctualLightLumenToLux(HGLightType lightType, float lumen, float initialIntensity, bool enableSpotReflector, float distance)
		{
			// // Single ConvertPunctualLightLumenToLux(HGLightType, Single, Single, Boolean, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertPunctualLightLumenToLux(
			//         HGLightType__Enum lightType,
			//         float lumen,
			//         float initialIntensity,
			//         bool enableSpotReflector,
			//         float distance,
			//         MethodInfo *method)
			// {
			//   float v8; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1703, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1703, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_652(
			//              Patch,
			//              lightType,
			//              lumen,
			//              initialIntensity,
			//              enableSpotReflector,
			//              distance,
			//              0LL);
			//   }
			//   else
			//   {
			//     v8 = HG::Rendering::Runtime::LightUtils::ConvertPunctualLightLumenToCandela(
			//            lightType,
			//            lumen,
			//            initialIntensity,
			//            enableSpotReflector,
			//            0LL);
			//     return HG::Rendering::Runtime::LightUtils::ConvertCandelaToLux(v8, distance, 0LL);
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertPunctualLightCandelaToLumen(HGLightType lightType, SpotLightShape spotLightShape, float candela, bool enableSpotReflector, float spotAngle, float aspectRatio)
		{
			// // Single ConvertPunctualLightCandelaToLumen(HGLightType, SpotLightShape, Single, Boolean, Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertPunctualLightCandelaToLumen(
			//         HGLightType__Enum lightType,
			//         SpotLightShape__Enum spotLightShape,
			//         float candela,
			//         bool enableSpotReflector,
			//         float spotAngle,
			//         float aspectRatio,
			//         MethodInfo *method)
			// {
			//   BOOL P3; // edi
			//   BOOL v10; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   float angleB; // [rsp+40h] [rbp-28h] BYREF
			//   float angleA[3]; // [rsp+44h] [rbp-24h] BYREF
			// 
			//   angleA[0] = 0.0;
			//   angleB = 0.0;
			//   P3 = enableSpotReflector;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1704, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1704, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_654(
			//              Patch,
			//              lightType,
			//              spotLightShape,
			//              candela,
			//              P3,
			//              spotAngle,
			//              aspectRatio,
			//              0LL);
			//   }
			//   else
			//   {
			//     v10 = 0;
			//     if ( lightType == HGLightType__Enum_Spot )
			//       v10 = P3;
			//     if ( !v10 )
			//       return HG::Rendering::Runtime::LightUtils::ConvertPointLightCandelaToLumen(candela, 0LL);
			//     if ( spotLightShape )
			//     {
			//       if ( spotLightShape != SpotLightShape__Enum_Pyramid )
			//         return HG::Rendering::Runtime::LightUtils::ConvertPointLightCandelaToLumen(candela, 0LL);
			//       HG::Rendering::Runtime::LightUtils::CalculateAnglesForPyramid(
			//         aspectRatio,
			//         spotAngle * 0.017453292,
			//         angleA,
			//         &angleB,
			//         0LL);
			//       return HG::Rendering::Runtime::LightUtils::ConvertFrustrumLightCandelaToLumen(candela, angleA[0], angleB, 0LL);
			//     }
			//     else
			//     {
			//       return HG::Rendering::Runtime::LightUtils::ConvertSpotLightCandelaToLumen(
			//                candela,
			//                spotAngle * 0.017453292,
			//                1,
			//                0LL);
			//     }
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertPunctualLightLuxToLumen(HGLightType lightType, SpotLightShape spotLightShape, float lux, bool enableSpotReflector, float spotAngle, float aspectRatio, float distance)
		{
			// // Single ConvertPunctualLightLuxToLumen(HGLightType, SpotLightShape, Single, Boolean, Single, Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertPunctualLightLuxToLumen(
			//         HGLightType__Enum lightType,
			//         SpotLightShape__Enum spotLightShape,
			//         float lux,
			//         bool enableSpotReflector,
			//         float spotAngle,
			//         float aspectRatio,
			//         float distance,
			//         MethodInfo *method)
			// {
			//   float v11; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1706, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1706, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v15, v14);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_655(
			//              Patch,
			//              lightType,
			//              spotLightShape,
			//              lux,
			//              enableSpotReflector,
			//              spotAngle,
			//              aspectRatio,
			//              distance,
			//              0LL);
			//   }
			//   else
			//   {
			//     v11 = HG::Rendering::Runtime::LightUtils::ConvertLuxToCandela(lux, distance, 0LL);
			//     return HG::Rendering::Runtime::LightUtils::ConvertPunctualLightCandelaToLumen(
			//              lightType,
			//              spotLightShape,
			//              v11,
			//              enableSpotReflector,
			//              spotAngle,
			//              aspectRatio,
			//              0LL);
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertPunctualLightEvToLumen(HGLightType lightType, SpotLightShape spotLightShape, float ev, bool enableSpotReflector, float spotAngle, float aspectRatio)
		{
			// // Single ConvertPunctualLightEvToLumen(HGLightType, SpotLightShape, Single, Boolean, Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertPunctualLightEvToLumen(
			//         HGLightType__Enum lightType,
			//         SpotLightShape__Enum spotLightShape,
			//         float ev,
			//         bool enableSpotReflector,
			//         float spotAngle,
			//         float aspectRatio,
			//         MethodInfo *method)
			// {
			//   float v10; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1707, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1707, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_654(
			//              Patch,
			//              lightType,
			//              spotLightShape,
			//              ev,
			//              enableSpotReflector,
			//              spotAngle,
			//              aspectRatio,
			//              0LL);
			//   }
			//   else
			//   {
			//     v10 = HG::Rendering::Runtime::LightUtils::ConvertEvToCandela(ev, 0LL);
			//     return HG::Rendering::Runtime::LightUtils::ConvertPunctualLightCandelaToLumen(
			//              lightType,
			//              spotLightShape,
			//              v10,
			//              enableSpotReflector,
			//              spotAngle,
			//              aspectRatio,
			//              0LL);
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertPunctualLightLumenToEv(HGLightType lightType, float lumen, float initialIntensity, bool enableSpotReflector)
		{
			// // Single ConvertPunctualLightLumenToEv(HGLightType, Single, Single, Boolean)
			// float HG::Rendering::Runtime::LightUtils::ConvertPunctualLightLumenToEv(
			//         HGLightType__Enum lightType,
			//         float lumen,
			//         float initialIntensity,
			//         bool enableSpotReflector,
			//         MethodInfo *method)
			// {
			//   float v7; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1708, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1708, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_651(
			//              Patch,
			//              lightType,
			//              lumen,
			//              initialIntensity,
			//              enableSpotReflector,
			//              0LL);
			//   }
			//   else
			//   {
			//     v7 = HG::Rendering::Runtime::LightUtils::ConvertPunctualLightLumenToCandela(
			//            lightType,
			//            lumen,
			//            initialIntensity,
			//            enableSpotReflector,
			//            0LL);
			//     return HG::Rendering::Runtime::LightUtils::ConvertCandelaToEv(v7, 0LL);
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertAreaLightLumenToLuminance(AreaLightShape areaLightShape, float lumen, float width, [MetadataOffset(Offset = "0x01F90E05")] float height = 0f)
		{
			// // Single ConvertAreaLightLumenToLuminance(AreaLightShape, Single, Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertAreaLightLumenToLuminance(
			//         AreaLightShape__Enum areaLightShape,
			//         float lumen,
			//         float width,
			//         float height,
			//         MethodInfo *method)
			// {
			//   float result; // xmm0_4
			//   unsigned __int32 v7; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1709, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1709, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_656(Patch, areaLightShape, lumen, width, height, 0LL);
			//   }
			//   else
			//   {
			//     result = lumen;
			//     if ( areaLightShape )
			//     {
			//       v7 = areaLightShape - 1;
			//       if ( v7 )
			//       {
			//         if ( v7 == 1 )
			//           return HG::Rendering::Runtime::LightUtils::ConvertDiscLightLumenToLuminance(lumen, width, 0LL);
			//       }
			//       else
			//       {
			//         return HG::Rendering::Runtime::LightUtils::CalculateLineLightLumenToLuminance(lumen, width, 0LL);
			//       }
			//     }
			//     else
			//     {
			//       return HG::Rendering::Runtime::LightUtils::ConvertRectLightLumenToLuminance(lumen, width, height, 0LL);
			//     }
			//   }
			//   return result;
			// }
			// 
			return 0f;
		}

		public static float ConvertAreaLightLuminanceToLumen(AreaLightShape areaLightShape, float luminance, float width, [MetadataOffset(Offset = "0x01F90E09")] float height = 0f)
		{
			// // Single ConvertAreaLightLuminanceToLumen(AreaLightShape, Single, Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertAreaLightLuminanceToLumen(
			//         AreaLightShape__Enum areaLightShape,
			//         float luminance,
			//         float width,
			//         float height,
			//         MethodInfo *method)
			// {
			//   float result; // xmm0_4
			//   unsigned __int32 v7; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1711, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1711, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_656(Patch, areaLightShape, luminance, width, height, 0LL);
			//   }
			//   else
			//   {
			//     result = luminance;
			//     if ( areaLightShape )
			//     {
			//       v7 = areaLightShape - 1;
			//       if ( v7 )
			//       {
			//         if ( v7 == 1 )
			//           return HG::Rendering::Runtime::LightUtils::ConvertDiscLightLuminanceToLumen(luminance, width, 0LL);
			//       }
			//       else
			//       {
			//         return HG::Rendering::Runtime::LightUtils::CalculateLineLightLuminanceToLumen(luminance, width, 0LL);
			//       }
			//     }
			//     else
			//     {
			//       return HG::Rendering::Runtime::LightUtils::ConvertRectLightLuminanceToLumen(luminance, width, height, 0LL);
			//     }
			//   }
			//   return result;
			// }
			// 
			return 0f;
		}

		public static float ConvertAreaLightLumenToEv(AreaLightShape AreaLightShape, float lumen, float width, float height)
		{
			// // Single ConvertAreaLightLumenToEv(AreaLightShape, Single, Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertAreaLightLumenToEv(
			//         AreaLightShape__Enum AreaLightShape,
			//         float lumen,
			//         float width,
			//         float height,
			//         MethodInfo *method)
			// {
			//   float v6; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1713, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1713, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_656(Patch, AreaLightShape, lumen, width, height, 0LL);
			//   }
			//   else
			//   {
			//     v6 = HG::Rendering::Runtime::LightUtils::ConvertAreaLightLumenToLuminance(AreaLightShape, lumen, width, height, 0LL);
			//     return HG::Rendering::Runtime::LightUtils::ConvertLuminanceToEv(v6, 0LL);
			//   }
			// }
			// 
			return 0f;
		}

		public static float ConvertAreaLightEvToLumen(AreaLightShape AreaLightShape, float ev, float width, float height)
		{
			// // Single ConvertAreaLightEvToLumen(AreaLightShape, Single, Single, Single)
			// float HG::Rendering::Runtime::LightUtils::ConvertAreaLightEvToLumen(
			//         AreaLightShape__Enum AreaLightShape,
			//         float ev,
			//         float width,
			//         float height,
			//         MethodInfo *method)
			// {
			//   float v6; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1714, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1714, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_656(Patch, AreaLightShape, ev, width, height, 0LL);
			//   }
			//   else
			//   {
			//     v6 = HG::Rendering::Runtime::LightUtils::ConvertEvToLuminance(ev, 0LL);
			//     return HG::Rendering::Runtime::LightUtils::ConvertAreaLightLuminanceToLumen(AreaLightShape, v6, width, height, 0LL);
			//   }
			// }
			// 
			return 0f;
		}

		public static float CalculateLineLightLumenToLuminance(float intensity, float lineWidth)
		{
			// // Single CalculateLineLightLumenToLuminance(Single, Single)
			// float HG::Rendering::Runtime::LightUtils::CalculateLineLightLumenToLuminance(
			//         float intensity,
			//         float lineWidth,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1710, 0LL) )
			//     return intensity / (float)(lineWidth * 12.566371);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1710, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(
			//            (ILFixDynamicMethodWrapper_3 *)Patch,
			//            intensity,
			//            lineWidth,
			//            0LL);
			// }
			// 
			return 0f;
		}

		public static float CalculateLineLightLuminanceToLumen(float intensity, float lineWidth)
		{
			// // Single CalculateLineLightLuminanceToLumen(Single, Single)
			// float HG::Rendering::Runtime::LightUtils::CalculateLineLightLuminanceToLumen(
			//         float intensity,
			//         float lineWidth,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1712, 0LL) )
			//     return (float)(lineWidth * 12.566371) * intensity;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1712, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(
			//            (ILFixDynamicMethodWrapper_3 *)Patch,
			//            intensity,
			//            lineWidth,
			//            0LL);
			// }
			// 
			return 0f;
		}

		public static void CalculateAnglesForPyramid(float aspectRatio, float spotAngle, out float angleA, out float angleB)
		{
			// // Void CalculateAnglesForPyramid(Single, Single, Single ByRef, Single ByRef)
			// void HG::Rendering::Runtime::LightUtils::CalculateAnglesForPyramid(
			//         float aspectRatio,
			//         float spotAngle,
			//         float *angleA,
			//         float *angleB,
			//         MethodInfo *method)
			// {
			//   float v7; // xmm6_4
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   float v12; // xmm0_4
			//   Beyond::DampingMath *v13; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			// 
			//   v7 = aspectRatio;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1705, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1705, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v16, v15);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_653(Patch, aspectRatio, spotAngle, angleA, angleB, 0LL);
			//   }
			//   else
			//   {
			//     if ( aspectRatio < 1.0 )
			//       v7 = 1.0 / aspectRatio;
			//     *angleA = spotAngle;
			//     v12 = sub_1802ED290(v9, v8, v10, v11) * v7;
			//     Beyond::DampingMath::fast_atan(v13, spotAngle);
			//     *angleB = v12 + v12;
			//   }
			// }
			// 
		}
	}
}
