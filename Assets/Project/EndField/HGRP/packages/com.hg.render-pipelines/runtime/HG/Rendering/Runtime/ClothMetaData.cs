using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 176)]
	public struct ClothMetaData
	{
		public void SetLocalToWorld(Matrix4x4 localToWorld)
		{
			// // Void SetLocalToWorld(Matrix4x4)
			// void HG::Rendering::Runtime::ClothMetaData::SetLocalToWorld(
			//         ClothMetaData *this,
			//         Matrix4x4 *localToWorld,
			//         MethodInfo *method)
			// {
			//   Matrix4x4 *inverse; // rax
			//   __int128 v6; // xmm1
			//   __int128 v7; // xmm0
			//   __int128 v8; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   Vector4 v15; // [rsp+20h] [rbp-39h] BYREF
			//   Matrix4x4 v16; // [rsp+30h] [rbp-29h] BYREF
			//   Matrix4x4 v17; // [rsp+70h] [rbp+17h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1120, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1120, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     v12 = *(_OWORD *)&localToWorld.m01;
			//     *(_OWORD *)&v16.m00 = *(_OWORD *)&localToWorld.m00;
			//     v13 = *(_OWORD *)&localToWorld.m02;
			//     *(_OWORD *)&v16.m01 = v12;
			//     v14 = *(_OWORD *)&localToWorld.m03;
			//     *(_OWORD *)&v16.m02 = v13;
			//     *(_OWORD *)&v16.m03 = v14;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_413(Patch, this, &v16, 0LL);
			//   }
			//   else
			//   {
			//     this.localToWorld0 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow(
			//                                                                       &v15,
			//                                                                       localToWorld,
			//                                                                       0,
			//                                                                       0LL));
			//     this.localToWorld1 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow(
			//                                                                       &v15,
			//                                                                       localToWorld,
			//                                                                       1,
			//                                                                       0LL));
			//     this.localToWorld2 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow(
			//                                                                       &v15,
			//                                                                       localToWorld,
			//                                                                       2,
			//                                                                       0LL));
			//     inverse = UnityEngine::Matrix4x4::get_inverse(&v17, localToWorld, 0LL);
			//     v6 = *(_OWORD *)&inverse.m01;
			//     *(_OWORD *)&v16.m00 = *(_OWORD *)&inverse.m00;
			//     v7 = *(_OWORD *)&inverse.m02;
			//     *(_OWORD *)&v16.m01 = v6;
			//     v8 = *(_OWORD *)&inverse.m03;
			//     *(_OWORD *)&v16.m02 = v7;
			//     *(_OWORD *)&v16.m03 = v8;
			//     this.worldToLocal0 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow(&v15, &v16, 0, 0LL));
			//     this.worldToLocal1 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow(&v15, &v16, 1, 0LL));
			//     this.worldToLocal2 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow(&v15, &v16, 2, 0LL));
			//   }
			// }
			// 
		}

		public float GetWindIntensity()
		{
			// // Single GetWindIntensity()
			// float HG::Rendering::Runtime::ClothMetaData::GetWindIntensity(ClothMetaData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1121, 0LL) )
			//     return this.windIntensityScale;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1121, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_414(Patch, this, 0LL);
			// }
			// 
			return 0f;
		}

		public float GetWindSoftFactor()
		{
			// // Single GetWindSoftFactor()
			// float HG::Rendering::Runtime::ClothMetaData::GetWindSoftFactor(ClothMetaData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1122, 0LL) )
			//     return this.packedLongestAnchorDistance.z;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1122, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_414(Patch, this, 0LL);
			// }
			// 
			return 0f;
		}

		public float GetTransformScale()
		{
			// // Single GetTransformScale()
			// float HG::Rendering::Runtime::ClothMetaData::GetTransformScale(ClothMetaData *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1123, 0LL) )
			//     return this.packedLongestAnchorDistance.w;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1123, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_414(Patch, this, 0LL);
			// }
			// 
			return 0f;
		}

		public uint clothNodeIdxStart;

		public uint clothNodeIdxEnd;

		public uint batchIdxStart;

		public uint iterNum;

		public float damping;

		public float windFreqFactor;

		public float windBalanceFactor;

		public float windIntensityScale;

		public int4 groupOffset;

		public Vector4 packedLongestAnchorDistance;

		public Vector4 packedClothNormal;

		public Vector4 localToWorld0;

		public Vector4 localToWorld1;

		public Vector4 localToWorld2;

		public Vector4 worldToLocal0;

		public Vector4 worldToLocal1;

		public Vector4 worldToLocal2;
	}
}
