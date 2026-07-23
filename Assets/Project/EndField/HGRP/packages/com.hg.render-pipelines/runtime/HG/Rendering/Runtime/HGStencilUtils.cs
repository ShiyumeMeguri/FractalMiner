using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGStencilUtils // TypeDefIndex: 38166
	{
		// Nested types
		public enum HGStencilBitMask // TypeDefIndex: 38165
		{
			DeferredShadingModelBit0 = 1,
			DeferredShadingModelBit1 = 2,
			DeferredShadingModelBit2 = 4,
			DeferredShadingModel = 7,
			StencilTestDecal = 8,
			CharacterBit = 16,
			NotReceiveDecals = 32,
			IgnoreSceneEffectPP = 64,
			EditorTerrainDecal = 128,
			AllBit = 255
		}
	
		// Constructors
		public HGStencilUtils() {} // 0x00000001841E1670-0x00000001841E1680
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
		[IDTag(0)]
		public static int GetStencilValueByMask(int @ref, int readMask) => default; // 0x0000000189B8C654-0x0000000189B8C6AC
		// Int32 GetStencilValueByMask(Int32, Int32)
		int32_t HG::Rendering::Runtime::HGStencilUtils::GetStencilValueByMask(
		        int32_t ref,
		        int32_t readMask,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2999, 0LL) )
		    return readMask & ref;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2999, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_50((ILFixDynamicMethodWrapper_15 *)Patch, ref, readMask, 0LL);
		}
		
		[IDTag(1)]
		public static int GetStencilValueByMask(int @ref, HGStencilBitMask readMask) => default; // 0x0000000189B8C5F4-0x0000000189B8C654
		// Int32 GetStencilValueByMask(Int32, HGStencilUtils+HGStencilBitMask)
		int32_t HG::Rendering::Runtime::HGStencilUtils::GetStencilValueByMask(
		        int32_t ref,
		        HGStencilUtils_HGStencilBitMask__Enum readMask,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3000, 0LL) )
		    return HG::Rendering::Runtime::HGStencilUtils::GetStencilValueByMask(ref, readMask, 0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(3000, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_50((ILFixDynamicMethodWrapper_15 *)Patch, ref, readMask, 0LL);
		}
		
		[IDTag(0)]
		public static void SetStencilValueByMask(ref int @ref, int value, int writeMask) {} // 0x0000000189B8C724-0x0000000189B8C79C
		// Void SetStencilValueByMask(Int32 ByRef, Int32, Int32)
		void HG::Rendering::Runtime::HGStencilUtils::SetStencilValueByMask(
		        int32_t *ref,
		        int32_t value,
		        int32_t writeMask,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3001, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3001, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1116(
		      Patch,
		      ref,
		      value,
		      (HGStencilUtils_HGStencilBitMask__Enum)writeMask,
		      0LL);
		  }
		  else
		  {
		    *ref = writeMask & value | *ref & (writeMask ^ 0xFF);
		  }
		}
		
		[IDTag(1)]
		public static void SetStencilValueByMask(ref int @ref, int value, HGStencilBitMask writeMask) {} // 0x0000000189B8C6AC-0x0000000189B8C724
		// Void SetStencilValueByMask(Int32 ByRef, Int32, HGStencilUtils+HGStencilBitMask)
		void HG::Rendering::Runtime::HGStencilUtils::SetStencilValueByMask(
		        int32_t *ref,
		        int32_t value,
		        HGStencilUtils_HGStencilBitMask__Enum writeMask,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3002, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3002, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1116(Patch, ref, value, writeMask, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGStencilUtils::SetStencilValueByMask(ref, value, writeMask, 0LL);
		  }
		}
		
	}
}
