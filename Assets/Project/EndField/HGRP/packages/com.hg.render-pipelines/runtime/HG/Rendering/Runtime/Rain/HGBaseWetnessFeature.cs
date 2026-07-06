using System;

namespace HG.Rendering.Runtime.Rain
{
	public abstract class HGBaseWetnessFeature
	{
		protected HGBaseWetnessFeature()
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

		internal virtual void PrepareResources(RainCommonResources commonResources)
		{
			// // Void PrepareResources(RainCommonResources)
			// void HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::PrepareResources(
			//         HGBaseWetnessFeature *this,
			//         RainCommonResources *commonResources,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(731, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(731, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)commonResources,
			//       0LL);
			//   }
			// }
			// 
		}

		internal virtual void UpdateData(RainCommonRenderingParam rainCommonRenderingParam, float deltaTime)
		{
			// // Void UpdateData(RainCommonRenderingParam, Single)
			// void HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::UpdateData(
			//         HGBaseWetnessFeature *this,
			//         RainCommonRenderingParam *rainCommonRenderingParam,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(737, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(737, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52(
			//       (ILFixDynamicMethodWrapper_9 *)Patch,
			//       (Object *)this,
			//       (Object *)rainCommonRenderingParam,
			//       deltaTime,
			//       0LL);
			//   }
			// }
			// 
		}

		internal virtual void SetData(RainWetnessGlobalProps globalProps)
		{
			// // Void SetData(RainWetnessGlobalProps)
			// void HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::SetData(
			//         HGBaseWetnessFeature *this,
			//         RainWetnessGlobalProps *globalProps,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(864, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(864, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)globalProps,
			//       0LL);
			//   }
			// }
			// 
		}

		internal virtual void ResetData(RainWetnessGlobalProps globalProps)
		{
			// // Void ResetData(RainWetnessGlobalProps)
			// void HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::ResetData(
			//         HGBaseWetnessFeature *this,
			//         RainWetnessGlobalProps *globalProps,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(865, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(865, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)globalProps,
			//       0LL);
			//   }
			// }
			// 
		}

		internal HGRainRenderer.WetnessFeaturesType wetnessType;
	}
}
