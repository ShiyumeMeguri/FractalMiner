using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct ClothNodeData // TypeDefIndex: 37559
	{
		// Fields
		public Vector2Int anchorNodeCacheIdx; // 0x00
		public Vector2 anchorNodeDistance; // 0x08
		public Vector2 uv; // 0x10
		public Vector2 collisionPlaneXY; // 0x18
		public Vector4 packedBasePosition; // 0x20
		public Vector4 packedBaseNormal; // 0x30
		public Vector4 baseTangent; // 0x40
		public Vector4 packedPrePosition; // 0x50
		public Vector4 packedCurPosition; // 0x60
		public Vector4 packedCurNormal; // 0x70
		public unsafe fixed /* 0x00000000-0x00000000 */ int neighborClothNodeCacheIdx[0]; // 0x80
		public unsafe fixed /* 0x00000000-0x00000000 */ float neighborClothNodeDistance[0]; // 0xA0
	
		// Methods
		public void SetCollisionPlane(Vector4 plane) {} // 0x0000000189C68B80-0x0000000189C68C1C
		// Void SetCollisionPlane(Vector4)
		void HG::Rendering::Runtime::ClothNodeData::SetCollisionPlane(ClothNodeData *this, Vector4 *plane, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1254, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1254, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = *plane;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_481(Patch, this, &v8, 0LL);
		  }
		  else
		  {
		    v8 = *plane;
		    this->collisionPlaneXY = HG::Rendering::Runtime::VectorSwizzleUtils::xy(&v8, 0LL);
		    this->packedBaseNormal.w = plane->z;
		    this->packedPrePosition.w = plane->w;
		  }
		}
		
	}
}
