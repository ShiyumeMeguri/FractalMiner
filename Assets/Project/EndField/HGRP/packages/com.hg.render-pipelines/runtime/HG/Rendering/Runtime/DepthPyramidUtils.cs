using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	internal class DepthPyramidUtils
	{
		public DepthPyramidUtils()
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

		public static Vector2Int GetSize(Vector2Int size, int mip)
		{
			// // Vector2Int GetSize(Vector2Int, Int32)
			// Vector2Int HG::Rendering::Runtime::DepthPyramidUtils::GetSize(Vector2Int size, int32_t mip, MethodInfo *method)
			// {
			//   int32_t m_X; // r8d
			//   int v6; // edx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   int32_t m_Y; // [rsp+34h] [rbp+Ch]
			// 
			//   m_Y = size.m_Y;
			//   if ( IFix::WrappersManagerImpl::IsPatched(2570, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2570, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_488(Patch, size, mip, 0LL);
			//   }
			//   else
			//   {
			//     m_X = size.m_X;
			//     if ( mip )
			//     {
			//       m_X = (size.m_X >> (mip & 0x1F)) + ((size.m_X >> ((mip - 1) & 0x1F)) & 1);
			//       v6 = (m_Y >> (mip & 0x1F)) + ((m_Y >> ((mip - 1) & 0x1F)) & 1);
			//     }
			//     else
			//     {
			//       v6 = m_Y;
			//     }
			//     return (Vector2Int)__PAIR64__(v6, m_X);
			//   }
			// }
			// 
			return null;
		}
	}
}
