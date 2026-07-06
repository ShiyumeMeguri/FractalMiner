using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGFoliageOccluderRenderParams
	{
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGFoliageOccluderRenderParams defaultParams
		{
			get
			{
				// // HGFoliageOccluderRenderParams get_defaultParams()
				// HGFoliageOccluderRenderParams *HG::Rendering::Runtime::HGFoliageOccluderRenderParams::get_defaultParams(
				//         MethodInfo *method)
				// {
				//   __int64 v1; // rax
				//   __int64 v2; // rdx
				//   __int64 v3; // rcx
				//   __int64 v4; // rbx
				//   Matrix4x4 *zero; // rax
				//   __int128 v6; // xmm0
				//   __int128 v7; // xmm1
				//   __int128 v8; // xmm2
				//   __int128 v9; // xmm3
				//   HGFoliageOccluderRenderParams *result; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   Matrix4x4 v12; // [rsp+20h] [rbp-48h] BYREF
				// 
				//   if ( !byte_18D8ED9B2 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGFoliageOccluderRenderParams);
				//     byte_18D8ED9B2 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(2170, 0LL) )
				//   {
				//     v1 = sub_180004920(TypeInfo::HG::Rendering::Runtime::HGFoliageOccluderRenderParams);
				//     v4 = v1;
				//     if ( v1 )
				//     {
				//       *(_WORD *)(v1 + 16) = 256;
				//       *(_DWORD *)(v1 + 20) = 0;
				//       zero = UnityEngine::Matrix4x4::get_zero(&v12, 0LL);
				//       v6 = *(_OWORD *)&zero.m00;
				//       v7 = *(_OWORD *)&zero.m01;
				//       v8 = *(_OWORD *)&zero.m02;
				//       v9 = *(_OWORD *)&zero.m03;
				//       result = (HGFoliageOccluderRenderParams *)v4;
				//       *(_OWORD *)(v4 + 24) = v6;
				//       *(_OWORD *)(v4 + 40) = v7;
				//       *(_OWORD *)(v4 + 56) = v8;
				//       *(_OWORD *)(v4 + 72) = v9;
				//       return result;
				//     }
				// LABEL_6:
				//     sub_180B536AC(v3, v2);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(2170, 0LL);
				//   if ( !Patch )
				//     goto LABEL_6;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_789(Patch, 0LL);
				// }
				// 
				return null;
			}
		}

		public HGFoliageOccluderRenderParams()
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

		public bool shouldRender;

		public bool curMaskIsA;

		public float lodFadeValue;

		public Matrix4x4 cullingMatrix;
	}
}
