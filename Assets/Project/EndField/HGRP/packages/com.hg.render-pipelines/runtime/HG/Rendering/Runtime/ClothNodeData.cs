using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 192)]
	public struct ClothNodeData
	{
		public void SetCollisionPlane(Vector4 plane)
		{
			// // Void SetCollisionPlane(Vector4)
			// void HG::Rendering::Runtime::ClothNodeData::SetCollisionPlane(ClothNodeData *this, Vector4 *plane, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v8; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1118, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1118, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = *plane;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_412(Patch, this, &v8, 0LL);
			//   }
			//   else
			//   {
			//     v8 = *plane;
			//     this.collisionPlaneXY = HG::Rendering::Runtime::VectorSwizzleUtils::xy(&v8, 0LL);
			//     this.packedBaseNormal.w = plane.z;
			//     this.packedPrePosition.w = plane.w;
			//   }
			// }
			// 
		}

		public Vector2Int anchorNodeCacheIdx;

		public Vector2 anchorNodeDistance;

		public Vector2 uv;

		public Vector2 collisionPlaneXY;

		public Vector4 packedBasePosition;

		public Vector4 packedBaseNormal;

		public Vector4 baseTangent;

		public Vector4 packedPrePosition;

		public Vector4 packedCurPosition;

		public Vector4 packedCurNormal;

		[FixedBuffer(typeof(int), 8)]
		public ClothNodeData.<neighborClothNodeCacheIdx>e__FixedBuffer neighborClothNodeCacheIdx;

		[FixedBuffer(typeof(float), 8)]
		public ClothNodeData.<neighborClothNodeDistance>e__FixedBuffer neighborClothNodeDistance;

		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		public struct <neighborClothNodeCacheIdx>e__FixedBuffer
		{
			public int FixedElementField;
		}

		[UnsafeValueType]
		[CompilerGenerated]
		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		public struct <neighborClothNodeDistance>e__FixedBuffer
		{
			public float FixedElementField;
		}
	}
}
