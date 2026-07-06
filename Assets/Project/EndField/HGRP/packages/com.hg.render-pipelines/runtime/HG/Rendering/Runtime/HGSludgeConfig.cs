using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
	public struct HGSludgeConfig
	{
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGSludgeConfig defaultConfig
		{
			get
			{
				// // HGSludgeConfig get_defaultConfig()
				// HGSludgeConfig *HG::Rendering::Runtime::HGSludgeConfig::get_defaultConfig(
				//         HGSludgeConfig *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   HGSludgeConfig *v7; // rax
				//   Vector2Int textureSize; // xmm0_8
				//   HGSludgeConfig v9[2]; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1349, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1349, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v6, v5);
				//     v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_510(v9, Patch, 0LL);
				//     textureSize = v7.textureSize;
				//     LODWORD(v7) = v7.graphicsFormat;
				//     retstr.textureSize = textureSize;
				//     retstr.graphicsFormat = (int)v7;
				//   }
				//   else
				//   {
				//     v9[0].textureSize = (Vector2Int)0x10000000100LL;
				//     retstr.textureSize = (Vector2Int)0x10000000100LL;
				//     retstr.graphicsFormat = 21;
				//   }
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		public Vector2Int textureSize;

		public GraphicsFormat graphicsFormat;
	}
}
