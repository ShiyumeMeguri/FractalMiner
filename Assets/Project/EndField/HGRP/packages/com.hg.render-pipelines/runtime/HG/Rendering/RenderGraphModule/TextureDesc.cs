using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.RenderGraphModule
{
	public struct TextureDesc // TypeDefIndex: 37471
	{
		// Fields
		public int width; // 0x00
		public int height; // 0x04
		public int slices; // 0x08
		public DepthBits depthBufferBits; // 0x0C
		public GraphicsFormat colorFormat; // 0x10
		public UnityEngine.FilterMode filterMode; // 0x14
		public TextureWrapMode wrapMode; // 0x18
		public TextureDimension dimension; // 0x1C
		public bool enableRandomWrite; // 0x20
		public bool useMipMap; // 0x21
		public bool autoGenerateMips; // 0x22
		public bool isShadowMap; // 0x23
		public int anisoLevel; // 0x24
		public float mipMapBias; // 0x28
		public MSAASamples msaaSamples; // 0x2C
		public bool bindTextureMS; // 0x30
		public RenderTextureMemoryless memoryless; // 0x34
		public string name; // 0x38
		public FastMemoryDesc fastMemoryDesc; // 0x40
		public bool fallBackToBlackTexture; // 0x4C
		public bool clearBuffer; // 0x4D
		public UnityEngine.Color clearColor; // 0x50
	
		// Constructors
		public TextureDesc(int width, int height) {
			this.width = default;
			this.height = default;
			slices = default;
			depthBufferBits = default;
			colorFormat = default;
			filterMode = default;
			wrapMode = default;
			dimension = default;
			enableRandomWrite = default;
			useMipMap = default;
			autoGenerateMips = default;
			isShadowMap = default;
			anisoLevel = default;
			mipMapBias = default;
			msaaSamples = default;
			bindTextureMS = default;
			memoryless = default;
			name = default;
			fastMemoryDesc = default;
			fallBackToBlackTexture = default;
			clearBuffer = default;
			clearColor = default;
		} // 0x0000000182EDC670-0x0000000182EDC6A0
		// TextureDesc(Int32, Int32)
		void HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        TextureDesc *this,
		        int32_t width,
		        int32_t height,
		        MethodInfo *method)
		{
		  *(_OWORD *)&this->width = 0LL;
		  *(_OWORD *)&this->colorFormat = 0LL;
		  *(_OWORD *)&this->enableRandomWrite = 0LL;
		  *(_OWORD *)&this->bindTextureMS = 0LL;
		  *(_OWORD *)&this->fastMemoryDesc.inFastMemory = 0LL;
		  this->clearColor = 0LL;
		  this->width = width;
		  this->height = height;
		  this->msaaSamples = 1;
		  HG::Rendering::RenderGraphModule::TextureDesc::InitDefaultValues(this, 0LL);
		}
		
		public TextureDesc(Vector2Int size) {
			width = default;
			height = default;
			slices = default;
			depthBufferBits = default;
			colorFormat = default;
			filterMode = default;
			wrapMode = default;
			dimension = default;
			enableRandomWrite = default;
			useMipMap = default;
			autoGenerateMips = default;
			isShadowMap = default;
			anisoLevel = default;
			mipMapBias = default;
			msaaSamples = default;
			bindTextureMS = default;
			memoryless = default;
			name = default;
			fastMemoryDesc = default;
			fallBackToBlackTexture = default;
			clearBuffer = default;
			clearColor = default;
		} // 0x0000000182EDC650-0x0000000182EDC670
		// TextureDesc(Vector2Int)
		void HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(TextureDesc *this, Vector2Int size, MethodInfo *method)
		{
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(this, size.m_X, size.m_Y, 0LL);
		}
		
		public TextureDesc(TextureDesc input) {
			width = default;
			height = default;
			slices = default;
			depthBufferBits = default;
			colorFormat = default;
			filterMode = default;
			wrapMode = default;
			dimension = default;
			enableRandomWrite = default;
			useMipMap = default;
			autoGenerateMips = default;
			isShadowMap = default;
			anisoLevel = default;
			mipMapBias = default;
			msaaSamples = default;
			bindTextureMS = default;
			memoryless = default;
			name = default;
			fastMemoryDesc = default;
			fallBackToBlackTexture = default;
			clearBuffer = default;
			clearColor = default;
		} // 0x0000000189B419A0-0x0000000189B419D8
		// TextureDesc(TextureDesc)
		void UnityEngine::Experimental::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        TextureDesc_1 *this,
		        TextureDesc_1 *input,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  __int128 v4; // xmm1
		  __int128 v5; // xmm0
		  __int128 v6; // xmm1
		  __int128 v7; // xmm0
		  Color clearColor; // xmm1
		  MethodInfo *v9; // [rsp+28h] [rbp+28h]
		
		  v4 = *(_OWORD *)&input->colorFormat;
		  *(_OWORD *)&this->width = *(_OWORD *)&input->width;
		  v5 = *(_OWORD *)&input->enableRandomWrite;
		  *(_OWORD *)&this->colorFormat = v4;
		  v6 = *(_OWORD *)&input->bindTextureMS;
		  *(_OWORD *)&this->enableRandomWrite = v5;
		  v7 = *(_OWORD *)&input->fastMemoryDesc.inFastMemory;
		  *(_OWORD *)&this->bindTextureMS = v6;
		  clearColor = input->clearColor;
		  *(_OWORD *)&this->fastMemoryDesc.inFastMemory = v7;
		  this->clearColor = clearColor;
		  sub_18002D1B0((SingleFieldAccessor *)&this->name, (Type *)input, (PropertyInfo_1 *)method, v3, v9);
		}
		
	
		// Methods
		private void InitDefaultValues() {} // 0x0000000182EDC6A0-0x0000000182EDC6E0
		// Void InitDefaultValues()
		void HG::Rendering::RenderGraphModule::TextureDesc::InitDefaultValues(TextureDesc *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(325, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(325, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_154(Patch, this, 0LL);
		  }
		  else
		  {
		    this->slices = 1;
		    this->dimension = 2;
		  }
		}
		
		public override int GetHashCode() => default; // 0x0000000189B41804-0x0000000189B41944
		// Int32 GetHashCode()
		int32_t HG::Rendering::RenderGraphModule::TextureDesc::GetHashCode(TextureDesc *this, MethodInfo *method)
		{
		  int v3; // ebp
		  int32_t width; // edi
		  int32_t height; // ebx
		  int32_t HashCode; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  v3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(326, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(326, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_155(Patch, this, 0LL);
		  }
		  else
		  {
		    width = this->width;
		    height = this->height;
		    HashCode = System::Single::GetHashCode((Single *)&this->mipMapBias, 0LL);
		    LOBYTE(v3) = this->fastMemoryDesc.inFastMemory;
		    return 1854975105 * height
		         + 480779105 * this->colorFormat
		         + 1561364439 * this->dimension
		         + 1551643729 * this->wrapMode
		         + 1001573953 * this->memoryless
		         + 1328067399 * this->filterMode
		         + v3
		         + 23
		         * (this->msaaSamples
		          + (this->bindTextureMS ? 0x17 : 0)
		          + (this->isShadowMap ? 0x211 : 0)
		          + (this->autoGenerateMips ? 0x2F87 : 0)
		          + (this->enableRandomWrite ? 0x6235F7 : 0)
		          + (this->useMipMap ? 0x44521 : 0))
		         - 1826982473 * this->depthBufferBits
		         - 890141849 * this->anisoLevel
		         + 929076081 * this->slices
		         - 106086617 * HashCode
		         - 285245545 * width
		         + 138141601;
		  }
		}
		
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000189B41944-0x0000000189B419A0
		// Int32 <>iFixBaseProxy_GetHashCode()
		int32_t HG::Rendering::RenderGraphModule::TextureDesc::__iFixBaseProxy_GetHashCode(
		        TextureDesc *this,
		        MethodInfo *method)
		{
		  __int128 v2; // xmm1
		  __int128 v3; // xmm0
		  __int128 v4; // xmm1
		  __int128 v5; // xmm0
		  Color clearColor; // xmm1
		  ValueType *v7; // rax
		  _OWORD v9[6]; // [rsp+20h] [rbp-68h] BYREF
		
		  v2 = *(_OWORD *)&this->colorFormat;
		  v9[0] = *(_OWORD *)&this->width;
		  v3 = *(_OWORD *)&this->enableRandomWrite;
		  v9[1] = v2;
		  v4 = *(_OWORD *)&this->bindTextureMS;
		  v9[2] = v3;
		  v5 = *(_OWORD *)&this->fastMemoryDesc.inFastMemory;
		  v9[3] = v4;
		  clearColor = this->clearColor;
		  v9[4] = v5;
		  v9[5] = clearColor;
		  v7 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::RenderGraphModule::TextureDesc, v9);
		  return System::ValueType::GetHashCode(v7, 0LL);
		}
		
	}
}
