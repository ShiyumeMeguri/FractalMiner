using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace HG.Rendering.RenderGraphModule
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 120)]
	public struct TextureDesc
	{
		public TextureDesc(int width, int height)
		{
			// // TextureDesc(Int32, Int32)
			// void HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//         TextureDesc *this,
			//         int32_t width,
			//         int32_t height,
			//         MethodInfo *method)
			// {
			//   *(_OWORD *)&this.width = 0LL;
			//   *(_OWORD *)&this.colorFormat = 0LL;
			//   *(_OWORD *)&this.enableRandomWrite = 0LL;
			//   *(_OWORD *)&this.bindTextureMS = 0LL;
			//   *(_OWORD *)&this.fastMemoryDesc.inFastMemory = 0LL;
			//   this.clearColor = 0LL;
			//   this.width = width;
			//   this.height = height;
			//   this.msaaSamples = 1;
			//   HG::Rendering::RenderGraphModule::TextureDesc::InitDefaultValues(this, 0LL);
			// }
			// 
		}

		public TextureDesc(Vector2Int size)
		{
			// // TextureDesc(Vector2Int)
			// void HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(TextureDesc *this, Vector2Int size, MethodInfo *method)
			// {
			//   HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(this, size.m_X, size.m_Y, 0LL);
			// }
			// 
		}

		public TextureDesc(TextureDesc input)
		{
			// // TextureDesc(TextureDesc)
			// void UnityEngine::Experimental::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
			//         TextureDesc_1 *this,
			//         TextureDesc_1 *input,
			//         MethodInfo *method)
			// {
			//   MessageDescriptor *v3; // r9
			//   __int128 v4; // xmm1
			//   __int128 v5; // xmm0
			//   __int128 v6; // xmm1
			//   __int128 v7; // xmm0
			//   Color clearColor; // xmm1
			//   String__Array *v9; // [rsp+28h] [rbp+28h]
			//   String *v10; // [rsp+30h] [rbp+30h]
			//   MethodInfo *v11; // [rsp+38h] [rbp+38h]
			// 
			//   v4 = *(_OWORD *)&input.colorFormat;
			//   *(_OWORD *)&this.width = *(_OWORD *)&input.width;
			//   v5 = *(_OWORD *)&input.enableRandomWrite;
			//   *(_OWORD *)&this.colorFormat = v4;
			//   v6 = *(_OWORD *)&input.bindTextureMS;
			//   *(_OWORD *)&this.enableRandomWrite = v5;
			//   v7 = *(_OWORD *)&input.fastMemoryDesc.inFastMemory;
			//   *(_OWORD *)&this.bindTextureMS = v6;
			//   clearColor = input.clearColor;
			//   *(_OWORD *)&this.fastMemoryDesc.inFastMemory = v7;
			//   this.clearColor = clearColor;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&this.name,
			//     (OneofDescriptorProto *)input,
			//     (FileDescriptor *)method,
			//     v3,
			//     v9,
			//     v10,
			//     v11);
			// }
			// 
		}

		private void InitDefaultValues()
		{
			// // Void InitDefaultValues()
			// void HG::Rendering::RenderGraphModule::TextureDesc::InitDefaultValues(TextureDesc *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(318, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(318, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_149(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     this.slices = 1;
			//     this.dimension = 2;
			//   }
			// }
			// 
		}

		public override int GetHashCode()
		{
			// // Int32 GetHashCode()
			// int32_t HG::Rendering::RenderGraphModule::TextureDesc::GetHashCode(TextureDesc *this, MethodInfo *method)
			// {
			//   int v3; // ebp
			//   int32_t width; // edi
			//   int32_t height; // ebx
			//   int32_t HashCode; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   v3 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(319, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(319, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_150(Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     width = this.width;
			//     height = this.height;
			//     HashCode = System::Single::GetHashCode((Single *)&this.mipMapBias, 0LL);
			//     LOBYTE(v3) = this.fastMemoryDesc.inFastMemory;
			//     return 1854975105 * height
			//          + 480779105 * this.colorFormat
			//          + 1561364439 * this.dimension
			//          + 1551643729 * this.wrapMode
			//          + 1001573953 * this.memoryless
			//          + 1328067399 * this.filterMode
			//          + v3
			//          + 23
			//          * (this.msaaSamples
			//           + (this.bindTextureMS ? 0x17 : 0)
			//           + (this.isShadowMap ? 0x211 : 0)
			//           + (this.autoGenerateMips ? 0x2F87 : 0)
			//           + (this.enableRandomWrite ? 0x6235F7 : 0)
			//           + (this.useMipMap ? 0x44521 : 0))
			//          - 1826982473 * this.depthBufferBits
			//          - 890141849 * this.anisoLevel
			//          + 929076081 * this.slices
			//          - 106086617 * HashCode
			//          - 285245545 * width
			//          + 138141601;
			//   }
			// }
			// 
			return 0;
		}

		public int <>iFixBaseProxy_GetHashCode()
		{
			// // Int32 <>iFixBaseProxy_GetHashCode()
			// int32_t HG::Rendering::RenderGraphModule::TextureDesc::__iFixBaseProxy_GetHashCode(
			//         TextureDesc *this,
			//         MethodInfo *method)
			// {
			//   __int64 v2; // r8
			//   __int128 v4; // xmm1
			//   __int128 v5; // xmm0
			//   __int128 v6; // xmm1
			//   __int128 v7; // xmm0
			//   Color clearColor; // xmm1
			//   ValueType *v9; // rax
			//   _OWORD v11[6]; // [rsp+20h] [rbp-68h] BYREF
			// 
			//   if ( !byte_18D9193B5 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureDesc);
			//     byte_18D9193B5 = 1;
			//   }
			//   v4 = *(_OWORD *)&this.colorFormat;
			//   v11[0] = *(_OWORD *)&this.width;
			//   v5 = *(_OWORD *)&this.enableRandomWrite;
			//   v11[1] = v4;
			//   v6 = *(_OWORD *)&this.bindTextureMS;
			//   v11[2] = v5;
			//   v7 = *(_OWORD *)&this.fastMemoryDesc.inFastMemory;
			//   v11[3] = v6;
			//   clearColor = this.clearColor;
			//   v11[4] = v7;
			//   v11[5] = clearColor;
			//   v9 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureDesc, v11, v2);
			//   return System::ValueType::GetHashCode(v9, 0LL);
			// }
			// 
			return 0;
		}

		public int width;

		public int height;

		public int slices;

		public DepthBits depthBufferBits;

		public GraphicsFormat colorFormat;

		public FilterMode filterMode;

		public TextureWrapMode wrapMode;

		public TextureDimension dimension;

		public bool enableRandomWrite;

		public bool useMipMap;

		public bool autoGenerateMips;

		public bool isShadowMap;

		public int anisoLevel;

		public float mipMapBias;

		public MSAASamples msaaSamples;

		public bool bindTextureMS;

		public RenderTextureMemoryless memoryless;

		public string name;

		public FastMemoryDesc fastMemoryDesc;

		public bool fallBackToBlackTexture;

		public bool clearBuffer;

		public Color clearColor;
	}
}
