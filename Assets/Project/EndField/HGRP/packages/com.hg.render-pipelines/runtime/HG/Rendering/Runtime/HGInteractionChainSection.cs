using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	public struct HGInteractionChainSection
	{
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGInteractionChainSection DefaultValue
		{
			get
			{
				// // HGInteractionChainSection get_DefaultValue()
				// HGInteractionChainSection *HG::Rendering::Runtime::HGInteractionChainSection::get_DefaultValue(
				//         HGInteractionChainSection *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   HGInteractionChainSection v3; // xmm0
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   HGInteractionChainSection *result; // rax
				//   HGInteractionChainSection v8; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1493, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1493, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v6, v5);
				//     v3 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_569(&v8, Patch, 0LL);
				//   }
				//   else
				//   {
				//     v8 = (HGInteractionChainSection)0LL;
				//     v3 = (HGInteractionChainSection)0;
				//   }
				//   result = retstr;
				//   *retstr = v3;
				//   return result;
				// }
				// 
				return null;
			}
		}

		public Vector2 VRange;

		public float StartSize;

		public bool Active;
	}
}
