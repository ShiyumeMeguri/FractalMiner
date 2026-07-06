using System;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class Documentation : DocumentationInfo
	{
		public Documentation()
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

		public static string GetPageLink(string pageName)
		{
			// // String GetPageLink(String)
			// String *HG::Rendering::Runtime::Documentation::GetPageLink(String *pageName, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D919CD8 )
			//   {
			//     sub_18003C530(&off_18D532390);
			//     byte_18D919CD8 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1104, 0LL) )
			//     return UnityEngine::Rendering::DocumentationInfo::GetPageLink((String *)"com.hg.render-pipelines", pageName, 0LL);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1104, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48(Patch, (Object *)pageName, 0LL);
			// }
			// 
			return null;
		}

		public const string packageName = "com.hg.render-pipelines";
	}
}
