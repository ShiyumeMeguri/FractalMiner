using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Rain
{
	public abstract class HGBaseWetnessFeature // TypeDefIndex: 38849
	{
		// Fields
		internal HGRainRenderer.WetnessFeaturesType wetnessType; // 0x10
	
		// Constructors
		protected HGBaseWetnessFeature() {} // 0x00000001841E1670-0x00000001841E1680
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
		internal virtual void PrepareResources(RainCommonResources commonResources) {} // 0x0000000184528130-0x0000000184528160
		// Void PrepareResources(RainCommonResources)
		void HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::PrepareResources(
		        HGBaseWetnessFeature *this,
		        RainCommonResources *commonResources,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(798, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(798, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)commonResources,
		      0LL);
		  }
		}
		
		internal virtual void UpdateData(RainCommonRenderingParam rainCommonRenderingParam, float deltaTime) {} // 0x0000000189CD9C34-0x0000000189CD9C9C
		// Void UpdateData(RainCommonRenderingParam, Single)
		void HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::UpdateData(
		        HGBaseWetnessFeature *this,
		        RainCommonRenderingParam *rainCommonRenderingParam,
		        float deltaTime,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(805, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(805, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
		      (ILFixDynamicMethodWrapper_9 *)Patch,
		      (Object *)this,
		      (Object *)rainCommonRenderingParam,
		      deltaTime,
		      0LL);
		  }
		}
		
		internal virtual void SetData(RainWetnessGlobalProps globalProps) {} // 0x0000000189CD9BE0-0x0000000189CD9C34
		// Void SetData(RainWetnessGlobalProps)
		void HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::SetData(
		        HGBaseWetnessFeature *this,
		        RainWetnessGlobalProps *globalProps,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1577, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1577, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)globalProps,
		      0LL);
		  }
		}
		
		internal virtual void ResetData(RainWetnessGlobalProps globalProps) {} // 0x0000000189CD9B8C-0x0000000189CD9BE0
		// Void ResetData(RainWetnessGlobalProps)
		void HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::ResetData(
		        HGBaseWetnessFeature *this,
		        RainWetnessGlobalProps *globalProps,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1578, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1578, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)globalProps,
		      0LL);
		  }
		}
		
	}
}
