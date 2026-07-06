using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 56)]
	public struct AttachDesc
	{
		public void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::RenderGraphModule::AttachDesc::Reset(AttachDesc *this, MethodInfo *method)
			// {
			//   TextureHandle v3; // xmm0
			//   TileBase *v4; // rdx
			//   Vector3Int *v5; // r8
			//   ITilemap *v6; // r9
			//   Color v7; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   TileAnimationData v11; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91935C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     byte_18D91935C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(270, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(270, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_130(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     v3 = *(TextureHandle *)sub_182E7CCD0(&v11);
			//     this.loadAction = 0;
			//     this.storeAction = 0;
			//     this.textureHandle = v3;
			//     v7 = (Color)_mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                    &v11,
			//                                                    v4,
			//                                                    v5,
			//                                                    v6,
			//                                                    (MethodInfo *)v11.m_AnimatedSprites));
			//     this.clearStencil = 0;
			//     this.clearDepth = 1.0;
			//     this.clearColor = v7;
			//     this.manuallyOverride = 0;
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly int INVALID_ATTACHMENT;

		public TextureHandle textureHandle;

		public RenderBufferLoadAction loadAction;

		public RenderBufferStoreAction storeAction;

		public Color clearColor;

		public uint depthSlice;

		public float clearDepth;

		public uint clearStencil;

		public bool manuallyOverride;
	}
}
