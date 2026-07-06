using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 20)]
	public struct HGFoliageInteractiveConfig
	{
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGFoliageInteractiveConfig defaultConfig
		{
			get
			{
				// // HGFoliageInteractiveConfig get_defaultConfig()
				// HGFoliageInteractiveConfig *HG::Rendering::Runtime::HGFoliageInteractiveConfig::get_defaultConfig(
				//         HGFoliageInteractiveConfig *__return_ptr retstr,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   HGFoliageInteractiveConfig *v7; // rax
				//   __int128 v8; // xmm0
				//   HGFoliageInteractiveConfig v9; // [rsp+20h] [rbp-28h] BYREF
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(1412, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1412, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v6, v5);
				//     v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_535(&v9, Patch, 0LL);
				//     v8 = *(_OWORD *)&v7.textureSize.m_X;
				//     LODWORD(v7) = v7.graphicsFormat;
				//     *(_OWORD *)&retstr.textureSize.m_X = v8;
				//     retstr.graphicsFormat = (int)v7;
				//   }
				//   else
				//   {
				//     v9.textureSize = (Vector2Int)0x10000000100LL;
				//     *(_QWORD *)&v9.centerOffsetHeight = 0x3F800000BF800000LL;
				//     *(_OWORD *)&retstr.textureSize.m_X = *(_OWORD *)&v9.textureSize.m_X;
				//     retstr.graphicsFormat = 46;
				//   }
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		public Vector2Int textureSize;

		public float centerOffsetHeight;

		public float characterOffsetHeight;

		public GraphicsFormat graphicsFormat;

		public const float FOLIAGE_INTERACTIVE_RAISE_SPEED = 0.5f;

		public const float FOLIAGE_INTERACTIVE_MIN_DELTA_TIME = 0.033f;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly Vector3 FOLIAGE_INTERACTIVE_CENTER_SIZE;
	}
}
