using System;

namespace HG.Rendering.Runtime
{
	public static class HGLightTypeExtension
	{
		public static bool IsSpot(this HGLightTypeAndShape type)
		{
			// // Boolean IsSpot(HGLightTypeAndShape)
			// bool HG::Rendering::Runtime::HGLightTypeExtension::IsSpot(HGLightTypeAndShape__Enum type, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1657, 0LL) )
			//     return type - 1 <= 1 || type == HGLightTypeAndShape__Enum_ConeSpot;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1657, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(
			//            (ILFixDynamicMethodWrapper_17 *)Patch,
			//            (AudioLogChannel__Enum)type,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public static bool IsArea(this HGLightTypeAndShape type)
		{
			// // Boolean IsArea(HGLightTypeAndShape)
			// bool HG::Rendering::Runtime::HGLightTypeExtension::IsArea(HGLightTypeAndShape__Enum type, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1658, 0LL) )
			//     return type - 5 <= 1 || type == HGLightTypeAndShape__Enum_DiscArea;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1658, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(
			//            (ILFixDynamicMethodWrapper_17 *)Patch,
			//            (AudioLogChannel__Enum)type,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public static bool SupportsRuntimeOnly(this HGLightTypeAndShape type)
		{
			// // Boolean SupportsRuntimeOnly(HGLightTypeAndShape)
			// bool HG::Rendering::Runtime::HGLightTypeExtension::SupportsRuntimeOnly(
			//         HGLightTypeAndShape__Enum type,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1659, 0LL) )
			//     return type != HGLightTypeAndShape__Enum_DiscArea;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1659, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(
			//            (ILFixDynamicMethodWrapper_17 *)Patch,
			//            (AudioLogChannel__Enum)type,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public static bool SupportsBakedOnly(this HGLightTypeAndShape type)
		{
			// // Boolean SupportsBakedOnly(HGLightTypeAndShape)
			// bool HG::Rendering::Runtime::HGLightTypeExtension::SupportsBakedOnly(
			//         HGLightTypeAndShape__Enum type,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1660, 0LL) )
			//     return type != HGLightTypeAndShape__Enum_TubeArea;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1660, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(
			//            (ILFixDynamicMethodWrapper_17 *)Patch,
			//            (AudioLogChannel__Enum)type,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public static bool SupportsMixed(this HGLightTypeAndShape type)
		{
			// // Boolean SupportsMixed(HGLightTypeAndShape)
			// bool HG::Rendering::Runtime::HGLightTypeExtension::SupportsMixed(HGLightTypeAndShape__Enum type, MethodInfo *method)
			// {
			//   bool result; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   result = IFix::WrappersManagerImpl::IsPatched(1661, 0LL);
			//   if ( result )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1661, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_86(
			//              (ILFixDynamicMethodWrapper_17 *)Patch,
			//              (AudioLogChannel__Enum)type,
			//              0LL);
			//   }
			//   else if ( type != HGLightTypeAndShape__Enum_TubeArea )
			//   {
			//     return type != HGLightTypeAndShape__Enum_DiscArea;
			//   }
			//   return result;
			// }
			// 
			return default(bool);
		}
	}
}
