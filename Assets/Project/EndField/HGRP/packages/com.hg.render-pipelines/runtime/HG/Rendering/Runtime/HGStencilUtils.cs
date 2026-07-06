using System;
using IFix.Core;

namespace HG.Rendering.Runtime
{
	public class HGStencilUtils
	{
		public HGStencilUtils()
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

		[IDTag(0)]
		public static int GetStencilValueByMask(int @ref, int readMask)
		{
			// // Int32 GetStencilValueByMask(Int32, Int32)
			// int32_t HG::Rendering::Runtime::HGStencilUtils::GetStencilValueByMask(
			//         int32_t ref,
			//         int32_t readMask,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2491, 0LL) )
			//     return readMask & ref;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2491, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47((ILFixDynamicMethodWrapper_16 *)Patch, ref, readMask, 0LL);
			// }
			// 
			return 0;
		}

		[IDTag(1)]
		public static int GetStencilValueByMask(int @ref, HGStencilUtils.HGStencilBitMask readMask)
		{
			// // Int32 GetStencilValueByMask(Int32, HGStencilUtils+HGStencilBitMask)
			// int32_t HG::Rendering::Runtime::HGStencilUtils::GetStencilValueByMask(
			//         int32_t ref,
			//         HGStencilUtils_HGStencilBitMask__Enum readMask,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2492, 0LL) )
			//     return HG::Rendering::Runtime::HGStencilUtils::GetStencilValueByMask(ref, readMask, 0LL);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2492, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47((ILFixDynamicMethodWrapper_16 *)Patch, ref, readMask, 0LL);
			// }
			// 
			return 0;
		}

		[IDTag(0)]
		public static void SetStencilValueByMask(ref int @ref, int value, int writeMask)
		{
			// // Void SetStencilValueByMask(Int32 ByRef, Int32, Int32)
			// void HG::Rendering::Runtime::HGStencilUtils::SetStencilValueByMask(
			//         int32_t *ref,
			//         int32_t value,
			//         int32_t writeMask,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2493, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2493, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_917(
			//       Patch,
			//       ref,
			//       value,
			//       (HGStencilUtils_HGStencilBitMask__Enum)writeMask,
			//       0LL);
			//   }
			//   else
			//   {
			//     *ref = writeMask & value | *ref & (writeMask ^ 0xFF);
			//   }
			// }
			// 
		}

		[IDTag(1)]
		public static void SetStencilValueByMask(ref int @ref, int value, HGStencilUtils.HGStencilBitMask writeMask)
		{
			// // Void SetStencilValueByMask(Int32 ByRef, Int32, HGStencilUtils+HGStencilBitMask)
			// void HG::Rendering::Runtime::HGStencilUtils::SetStencilValueByMask(
			//         int32_t *ref,
			//         int32_t value,
			//         HGStencilUtils_HGStencilBitMask__Enum writeMask,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2494, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2494, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_917(Patch, ref, value, writeMask, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGStencilUtils::SetStencilValueByMask(ref, value, writeMask, 0LL);
			//   }
			// }
			// 
		}

		public enum HGStencilBitMask
		{
			DeferredShadingModelBit0 = 1,
			DeferredShadingModelBit1,
			DeferredShadingModelBit2 = 4,
			StencilTestDecal = 8,
			CharacterBit = 16,
			NotReceiveDecals = 32,
			IgnoreSceneEffectPP = 64,
			EditorTerrainDecal = 128,
			DeferredShadingModel = 7,
			AllBit = 255
		}
	}
}
