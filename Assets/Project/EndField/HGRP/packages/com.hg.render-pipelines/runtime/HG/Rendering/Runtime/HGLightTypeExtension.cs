using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGLightTypeExtension // TypeDefIndex: 37793
	{
		// Extension methods
		public static bool IsSpot(this HGLightTypeAndShape type) => default; // 0x0000000189D08A90-0x0000000189D08AF0
		// Boolean IsSpot(HGLightTypeAndShape)
		bool HG::Rendering::Runtime::HGLightTypeExtension::IsSpot(HGLightTypeAndShape__Enum type, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1969, 0LL) )
		    return type - 1 <= 1 || type == HGLightTypeAndShape__Enum_ConeSpot;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1969, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_95(
		           (ILFixDynamicMethodWrapper_17 *)Patch,
		           (AudioLogChannel__Enum)type,
		           0LL);
		}
		
		public static bool IsArea(this HGLightTypeAndShape type) => default; // 0x0000000189D08A30-0x0000000189D08A90
		// Boolean IsArea(HGLightTypeAndShape)
		bool HG::Rendering::Runtime::HGLightTypeExtension::IsArea(HGLightTypeAndShape__Enum type, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1970, 0LL) )
		    return type - 5 <= 1 || type == HGLightTypeAndShape__Enum_DiscArea;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1970, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_95(
		           (ILFixDynamicMethodWrapper_17 *)Patch,
		           (AudioLogChannel__Enum)type,
		           0LL);
		}
		
		public static bool SupportsRuntimeOnly(this HGLightTypeAndShape type) => default; // 0x0000000189D08B98-0x0000000189D08BE8
		// Boolean SupportsRuntimeOnly(HGLightTypeAndShape)
		bool HG::Rendering::Runtime::HGLightTypeExtension::SupportsRuntimeOnly(
		        HGLightTypeAndShape__Enum type,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1971, 0LL) )
		    return type != HGLightTypeAndShape__Enum_DiscArea;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1971, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_95(
		           (ILFixDynamicMethodWrapper_17 *)Patch,
		           (AudioLogChannel__Enum)type,
		           0LL);
		}
		
		public static bool SupportsBakedOnly(this HGLightTypeAndShape type) => default; // 0x0000000189D08AF0-0x0000000189D08B40
		// Boolean SupportsBakedOnly(HGLightTypeAndShape)
		bool HG::Rendering::Runtime::HGLightTypeExtension::SupportsBakedOnly(
		        HGLightTypeAndShape__Enum type,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1972, 0LL) )
		    return type != HGLightTypeAndShape__Enum_TubeArea;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1972, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_95(
		           (ILFixDynamicMethodWrapper_17 *)Patch,
		           (AudioLogChannel__Enum)type,
		           0LL);
		}
		
		public static bool SupportsMixed(this HGLightTypeAndShape type) => default; // 0x0000000189D08B40-0x0000000189D08B98
		// Boolean SupportsMixed(HGLightTypeAndShape)
		bool HG::Rendering::Runtime::HGLightTypeExtension::SupportsMixed(HGLightTypeAndShape__Enum type, MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(1973, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1973, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_95(
		             (ILFixDynamicMethodWrapper_17 *)Patch,
		             (AudioLogChannel__Enum)type,
		             0LL);
		  }
		  else if ( type != HGLightTypeAndShape__Enum_TubeArea )
		  {
		    return type != HGLightTypeAndShape__Enum_DiscArea;
		  }
		  return result;
		}
		
	}
}
