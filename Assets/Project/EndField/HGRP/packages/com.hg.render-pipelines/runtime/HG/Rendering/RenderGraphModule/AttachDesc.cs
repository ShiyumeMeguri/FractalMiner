using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	public struct AttachDesc // TypeDefIndex: 37440
	{
		// Fields
		public static readonly int INVALID_ATTACHMENT; // 0x00
		public TextureHandle textureHandle; // 0x00
		public RenderBufferLoadAction loadAction; // 0x10
		public RenderBufferStoreAction storeAction; // 0x14
		public UnityEngine.Color clearColor; // 0x18
		public uint depthSlice; // 0x28
		public float clearDepth; // 0x2C
		public uint clearStencil; // 0x30
		public bool manuallyOverride; // 0x34
	
		// Constructors
		static AttachDesc() {
			INVALID_ATTACHMENT = default;
		} // 0x0000000184DA1180-0x0000000184DA11A0
		// AttachDesc()
		void HG::Rendering::RenderGraphModule::AttachDesc::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::RenderGraphModule::AttachDesc->static_fields->INVALID_ATTACHMENT = -1;
		}
		
	
		// Methods
		public void Reset() {} // 0x0000000189B3402C-0x0000000189B340C0
		// Void Reset()
		void HG::Rendering::RenderGraphModule::AttachDesc::Reset(AttachDesc *this, MethodInfo *method)
		{
		  TextureHandle v3; // xmm0
		  TileBase *v4; // rdx
		  Vector3Int *v5; // r8
		  ITilemap *v6; // r9
		  Color v7; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  TextureHandle v11; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(274, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(274, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_133(Patch, this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    v3 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v11, 0LL);
		    this->loadAction = 0;
		    this->storeAction = 0;
		    this->textureHandle = v3;
		    v7 = (Color)_mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                   (TileAnimationData *)&v11,
		                                                   v4,
		                                                   v5,
		                                                   v6,
		                                                   *(MethodInfo **)&v11.handle));
		    this->clearStencil = 0;
		    this->clearDepth = 1.0;
		    this->clearColor = v7;
		    this->manuallyOverride = 0;
		  }
		}
		
	}
}
