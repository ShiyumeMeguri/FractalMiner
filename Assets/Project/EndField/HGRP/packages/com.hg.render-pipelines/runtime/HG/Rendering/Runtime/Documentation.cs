using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class Documentation : DocumentationInfo // TypeDefIndex: 37550
	{
		// Fields
		public const string packageName = "com.hg.render-pipelines"; // Metadata: 0x02302F20
	
		// Constructors
		public Documentation() {} // 0x00000001841E1670-0x00000001841E1680
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
		public static string GetPageLink(string pageName) => default; // 0x0000000189C68E48-0x0000000189C68EA4
		// String GetPageLink(String)
		String *HG::Rendering::Runtime::Documentation::GetPageLink(String *pageName, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1240, 0LL) )
		    return UnityEngine::Rendering::DocumentationInfo::GetPageLink((String *)"com.hg.render-pipelines", pageName, 0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(1240, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)pageName, 0LL);
		}
		
	}
}
