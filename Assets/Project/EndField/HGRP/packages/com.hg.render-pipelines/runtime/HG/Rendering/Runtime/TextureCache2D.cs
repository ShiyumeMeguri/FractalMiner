using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class TextureCache2D : TextureCache // TypeDefIndex: 37525
	{
		// Fields
		private RenderTexture m_Cache; // 0x48
	
		// Constructors
		public TextureCache2D() {} // Dummy constructor
		public TextureCache2D(string cacheName = "" /* Metadata: 0x02302EF2 */) {} // 0x0000000189B40898-0x0000000189B408DC
		// TextureCache2D(String)
		void HG::Rendering::Runtime::TextureCache2D::TextureCache2D(
		        TextureCache2D *this,
		        String *cacheName,
		        MethodInfo *method)
		{
		  if ( !TypeInfo::HG::Rendering::Runtime::TextureCache->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::TextureCache);
		  HG::Rendering::Runtime::TextureCache::TextureCache((TextureCache *)this, cacheName, 1, 0LL);
		}
		
	
		// Methods
		private bool TextureHasMipmaps(Texture texture) => default; // 0x0000000189B40348-0x0000000189B403F0
		// Boolean TextureHasMipmaps(Texture)
		bool HG::Rendering::Runtime::TextureCache2D::TextureHasMipmaps(
		        TextureCache2D *this,
		        Texture *texture,
		        MethodInfo *method)
		{
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  RenderTexture *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(377, 0LL) )
		  {
		    if ( texture && (struct Texture2D__Class *)texture->klass == TypeInfo::UnityEngine::Texture2D )
		      return UnityEngine::Texture::get_mipmapCount(texture, 0LL) > 1;
		    if ( sub_180005130(texture, TypeInfo::UnityEngine::RenderTexture) )
		    {
		      v8 = (RenderTexture *)sub_180005130(texture, TypeInfo::UnityEngine::RenderTexture);
		      return UnityEngine::RenderTexture::get_useMipMap(v8, 0LL);
		    }
		LABEL_8:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(377, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)Patch,
		           (Object *)this,
		           (Object *)texture,
		           0LL);
		}
		
		public override bool IsCreated() => default; // 0x0000000189B4028C-0x0000000189B402E4
		// Boolean IsCreated()
		bool HG::Rendering::Runtime::TextureCache2D::IsCreated(TextureCache2D *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  RenderTexture *m_Cache; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(378, 0LL) )
		  {
		    m_Cache = this->fields.m_Cache;
		    if ( m_Cache )
		      return UnityEngine::RenderTexture::IsCreated(m_Cache, 0LL);
		LABEL_5:
		    sub_1800D8260(m_Cache, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(378, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		protected override bool TransferToSlice(CommandBuffer cmd, int sliceIndex, Texture[] textureArray) => default; // 0x0000000189B403F0-0x0000000189B40890
		// Boolean TransferToSlice(CommandBuffer, Int32, Texture[])
		bool HG::Rendering::Runtime::TextureCache2D::TransferToSlice(
		        TextureCache2D *this,
		        CommandBuffer *cmd,
		        int32_t sliceIndex,
		        Texture__Array *textureArray,
		        MethodInfo *method)
		{
		  Texture *m_Cache; // rdx
		  unsigned __int64 v10; // rcx
		  bool v11; // si
		  unsigned int i; // edi
		  int v13; // esi
		  int v14; // esi
		  bool result; // al
		  int v16; // edi
		  int v17; // edi
		  GraphicsFormat__Enum graphicsFormat; // edi
		  bool v19; // zf
		  unsigned int j; // edi
		  RenderTargetIdentifier *v21; // rax
		  Texture *v22; // rdx
		  RenderTargetIdentifier *v23; // rax
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  __int128 v26; // xmm1
		  __int64 v27; // xmm0_8
		  int v28; // eax
		  RenderTargetIdentifier *v29; // rax
		  Texture *v30; // rdx
		  RenderTargetIdentifier *v31; // rax
		  __int64 v32; // rdx
		  __int64 v33; // rcx
		  __int128 v34; // xmm1
		  __int64 v35; // xmm0_8
		  int v36; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v38; // [rsp+38h] [rbp-61h]
		  __int64 v39; // [rsp+38h] [rbp-61h]
		  RenderTargetIdentifier v40; // [rsp+48h] [rbp-51h] BYREF
		  __int128 v41; // [rsp+78h] [rbp-21h]
		  __int128 v42; // [rsp+88h] [rbp-11h]
		  RenderTargetIdentifier v43; // [rsp+98h] [rbp-1h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(379, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(379, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_179(
		               Patch,
		               (Object *)this,
		               (Object *)cmd,
		               sliceIndex,
		               (Object *)textureArray,
		               0LL);
		    goto LABEL_65;
		  }
		  if ( !textureArray )
		    return 0;
		  if ( !textureArray->max_length.value )
		  {
		    if ( !textureArray->max_length.size )
		      goto LABEL_63;
		    if ( !sub_180005050(textureArray->vector[0], TypeInfo::UnityEngine::RenderTexture) )
		    {
		      if ( !textureArray->max_length.size )
		        goto LABEL_63;
		      v10 = (unsigned __int64)textureArray->vector[0];
		      if ( !v10 || *(struct Texture2D__Class **)v10 != TypeInfo::UnityEngine::Texture2D )
		        return 0;
		    }
		  }
		  v11 = 1;
		  for ( i = 1; (signed int)i < textureArray->max_length.size; ++i )
		  {
		    if ( i >= textureArray->max_length.size )
		      goto LABEL_63;
		    m_Cache = textureArray->vector[i];
		    if ( !m_Cache )
		      goto LABEL_65;
		    v13 = sub_180002F70(5LL, m_Cache);
		    if ( !textureArray->max_length.size )
		      goto LABEL_63;
		    m_Cache = textureArray->vector[0];
		    if ( !m_Cache )
		      goto LABEL_65;
		    if ( v13 != (unsigned int)sub_180002F70(5LL, m_Cache) )
		      goto LABEL_27;
		    if ( i >= textureArray->max_length.size )
		      goto LABEL_63;
		    m_Cache = textureArray->vector[i];
		    if ( !m_Cache )
		      goto LABEL_65;
		    v14 = sub_180002F70(7LL, m_Cache);
		    if ( !textureArray->max_length.size )
		      goto LABEL_63;
		    m_Cache = textureArray->vector[0];
		    if ( !m_Cache )
		      goto LABEL_65;
		    if ( v14 != (unsigned int)sub_180002F70(7LL, m_Cache) )
		      goto LABEL_27;
		    if ( !textureArray->max_length.size )
		      goto LABEL_63;
		    if ( !sub_180005050(textureArray->vector[0], TypeInfo::UnityEngine::RenderTexture) )
		    {
		      if ( !textureArray->max_length.size )
		        goto LABEL_63;
		      v10 = (unsigned __int64)textureArray->vector[0];
		      if ( !v10 || *(struct Texture2D__Class **)v10 != TypeInfo::UnityEngine::Texture2D )
		      {
		LABEL_27:
		        HG::Rendering::HGRPLogger::LogWarning(
		          (String *)"All the sub-textures should have the same dimensions to be handled by the texture cache.",
		          0LL);
		        return 0;
		      }
		    }
		    v11 = 1;
		  }
		  m_Cache = (Texture *)this->fields.m_Cache;
		  if ( !m_Cache )
		    goto LABEL_65;
		  v16 = sub_180002F70(5LL, m_Cache);
		  if ( !textureArray->max_length.size )
		    goto LABEL_63;
		  m_Cache = textureArray->vector[0];
		  if ( !m_Cache )
		    goto LABEL_65;
		  if ( v16 == (unsigned int)sub_180002F70(5LL, m_Cache) )
		  {
		    m_Cache = (Texture *)this->fields.m_Cache;
		    if ( !m_Cache )
		      goto LABEL_65;
		    v17 = sub_180002F70(7LL, m_Cache);
		    if ( !textureArray->max_length.size )
		LABEL_63:
		      sub_1800D2AB0(v10, m_Cache);
		    m_Cache = textureArray->vector[0];
		    if ( !m_Cache )
		      goto LABEL_65;
		    v11 = v17 != (unsigned int)sub_180002F70(7LL, m_Cache);
		  }
		  if ( !textureArray->max_length.size )
		    goto LABEL_63;
		  v10 = (unsigned __int64)textureArray->vector[0];
		  if ( !v10 || *(struct Texture2D__Class **)v10 != TypeInfo::UnityEngine::Texture2D )
		  {
		    result = 1;
		    goto LABEL_48;
		  }
		  v10 = (unsigned __int64)this->fields.m_Cache;
		  if ( !v10 )
		LABEL_65:
		    sub_1800D8260(v10, m_Cache);
		  graphicsFormat = UnityEngine::RenderTexture::get_graphicsFormat((RenderTexture *)v10, 0LL);
		  if ( !textureArray->max_length.size )
		    goto LABEL_63;
		  m_Cache = textureArray->vector[0];
		  if ( !m_Cache || (struct Texture2D__Class *)m_Cache->klass != TypeInfo::UnityEngine::Texture2D )
		    goto LABEL_65;
		  v19 = graphicsFormat == UnityEngine::Texture::get_graphicsFormat(textureArray->vector[0], 0LL);
		  v10 = v11;
		  result = 1;
		  if ( !v19 )
		    v10 = 1LL;
		  v11 = (_DWORD)v10 != 0;
		LABEL_48:
		  for ( j = 0; (signed int)j < textureArray->max_length.size; ++j )
		  {
		    if ( j >= textureArray->max_length.size
		      || !HG::Rendering::Runtime::TextureCache2D::TextureHasMipmaps(this, textureArray->vector[j], 0LL)
		      && j >= textureArray->max_length.size )
		    {
		      goto LABEL_63;
		    }
		    if ( v11 )
		    {
		      if ( j >= textureArray->max_length.size )
		        goto LABEL_63;
		      v29 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v40, textureArray->vector[j], 0LL);
		      v30 = (Texture *)this->fields.m_Cache;
		      v42 = *(_OWORD *)&v29->m_Type;
		      v41 = *(_OWORD *)&v29->m_BufferPointer;
		      v39 = *(_QWORD *)&v29->m_DepthSlice;
		      v31 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v43, v30, 0LL);
		      if ( !cmd )
		        sub_1800D8260(v33, v32);
		      v34 = *(_OWORD *)&v31->m_BufferPointer;
		      *(_OWORD *)&v40.m_Type = *(_OWORD *)&v31->m_Type;
		      v35 = *(_QWORD *)&v31->m_DepthSlice;
		      v36 = this->fields._.m_SliceSize * sliceIndex;
		      *(_OWORD *)&v40.m_BufferPointer = v34;
		      *(_QWORD *)&v40.m_DepthSlice = v35;
		      *(_OWORD *)&v43.m_Type = v42;
		      *(_OWORD *)&v43.m_BufferPointer = v41;
		      *(_QWORD *)&v43.m_DepthSlice = v39;
		      UnityEngine::Rendering::CommandBuffer::Blit(cmd, &v43, &v40, 0, j + v36, 0LL);
		    }
		    else
		    {
		      if ( j >= textureArray->max_length.size )
		        goto LABEL_63;
		      v21 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v40, textureArray->vector[j], 0LL);
		      v22 = (Texture *)this->fields.m_Cache;
		      v41 = *(_OWORD *)&v21->m_Type;
		      v42 = *(_OWORD *)&v21->m_BufferPointer;
		      v38 = *(_QWORD *)&v21->m_DepthSlice;
		      v23 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v40, v22, 0LL);
		      if ( !cmd )
		        sub_1800D8260(v25, v24);
		      v26 = *(_OWORD *)&v23->m_BufferPointer;
		      *(_OWORD *)&v43.m_Type = *(_OWORD *)&v23->m_Type;
		      v27 = *(_QWORD *)&v23->m_DepthSlice;
		      v28 = this->fields._.m_SliceSize * sliceIndex;
		      *(_OWORD *)&v43.m_BufferPointer = v26;
		      *(_QWORD *)&v43.m_DepthSlice = v27;
		      *(_OWORD *)&v40.m_Type = v41;
		      *(_OWORD *)&v40.m_BufferPointer = v42;
		      *(_QWORD *)&v40.m_DepthSlice = v38;
		      UnityEngine::Rendering::CommandBuffer::CopyTexture(cmd, &v40, 0, &v43, j + v28, 0LL);
		    }
		    result = 1;
		  }
		  return result;
		}
		
		public override Texture GetTexCache() => default; // 0x0000000189B4023C-0x0000000189B4028C
		// Texture GetTexCache()
		Texture *HG::Rendering::Runtime::TextureCache2D::GetTexCache(TextureCache2D *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(380, 0LL) )
		    return (Texture *)this->fields.m_Cache;
		  Patch = IFix::WrappersManagerImpl::GetPatch(380, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_180(Patch, (Object *)this, 0LL);
		}
		
		public bool AllocTextureArray(int numTextures, int width, int height, GraphicsFormat format, bool isMipMapped) => default; // 0x0000000189B3FDE4-0x0000000189B3FFD8
		// Boolean AllocTextureArray(Int32, Int32, Int32, GraphicsFormat, Boolean)
		bool HG::Rendering::Runtime::TextureCache2D::AllocTextureArray(
		        TextureCache2D *this,
		        int32_t numTextures,
		        int32_t width,
		        int32_t height,
		        GraphicsFormat__Enum format,
		        bool isMipMapped,
		        MethodInfo *method)
		{
		  bool v11; // r12
		  RenderTexture *v12; // rax
		  __int64 v13; // rdx
		  RenderTexture *m_Cache; // rcx
		  Object_1 *v15; // r13
		  String *m_CacheName; // rbx
		  String *TextureAutoName; // rax
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  MethodInfo *depthBufferBits; // [rsp+28h] [rbp-81h]
		  RenderTextureDescriptor v23; // [rsp+48h] [rbp-61h] BYREF
		  RenderTextureDescriptor v24; // [rsp+88h] [rbp-21h] BYREF
		
		  memset(&v23, 0, sizeof(v23));
		  if ( !IFix::WrappersManagerImpl::IsPatched(381, 0LL) )
		  {
		    v11 = HG::Rendering::Runtime::TextureCache::AllocTextureArray((TextureCache *)this, numTextures, 0LL);
		    this->fields._.m_NumMipLevels = HG::Rendering::Runtime::TextureCache::GetNumMips(
		                                      (TextureCache *)this,
		                                      width,
		                                      height,
		                                      0LL);
		    UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(&v23, width, height, format, 0, 0LL);
		    v23._dimension_k__BackingField = 5;
		    v23._volumeDepth_k__BackingField = numTextures;
		    UnityEngine::RenderTextureDescriptor::set_useMipMap(&v23, isMipMapped, 0LL);
		    v23._msaaSamples_k__BackingField = 1;
		    v12 = (RenderTexture *)sub_18002C620(TypeInfo::UnityEngine::RenderTexture);
		    v15 = (Object_1 *)v12;
		    if ( v12 )
		    {
		      v24 = v23;
		      UnityEngine::RenderTexture::RenderTexture(v12, &v24, 0LL);
		      UnityEngine::Object::set_hideFlags(v15, HideFlags__Enum_HideAndDontSave, 0LL);
		      UnityEngine::Texture::set_wrapMode((Texture *)v15, TextureWrapMode__Enum_Clamp, 0LL);
		      m_CacheName = this->fields._.m_CacheName;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      TextureAutoName = UnityEngine::Rendering::CoreUtils::GetTextureAutoName(
		                          width,
		                          height,
		                          format,
		                          TextureDimension__Enum_Tex2DArray,
		                          m_CacheName,
		                          0,
		                          numTextures,
		                          0LL);
		      UnityEngine::Object::set_name(v15, TextureAutoName, 0LL);
		      this->fields.m_Cache = (RenderTexture *)v15;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_Cache, v18, v19, v20, depthBufferBits);
		      HG::Rendering::Runtime::TextureCache2D::ClearCache(this, 0LL);
		      m_Cache = this->fields.m_Cache;
		      if ( m_Cache )
		      {
		        UnityEngine::RenderTexture::Create(m_Cache, 0LL);
		        return v11;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(m_Cache, v13);
		  }
		  m_Cache = (RenderTexture *)IFix::WrappersManagerImpl::GetPatch(381, 0LL);
		  if ( !m_Cache )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_181(
		           (ILFixDynamicMethodWrapper_2 *)m_Cache,
		           (Object *)this,
		           numTextures,
		           width,
		           height,
		           format,
		           isMipMapped,
		           0LL);
		}
		
		internal void ClearCache() {} // 0x0000000189B3FFD8-0x0000000189B400F0
		// Void ClearCache()
		void HG::Rendering::Runtime::TextureCache2D::ClearCache(TextureCache2D *this, MethodInfo *method)
		{
		  __int64 v3; // rcx
		  RenderTexture *m_Cache; // rdx
		  RenderTextureDescriptor *descriptor; // rax
		  int32_t NumMips; // ebp
		  int32_t v7; // esi
		  RenderTexture *v8; // rbx
		  TileBase *v9; // rdx
		  Vector3Int *v10; // r8
		  ITilemap *v11; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v13; // [rsp+20h] [rbp-A8h]
		  TileAnimationData v14; // [rsp+30h] [rbp-98h] BYREF
		  TileAnimationData v15; // [rsp+40h] [rbp-88h] BYREF
		  RenderTextureDescriptor v16; // [rsp+88h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(382, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(382, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(v3, m_Cache);
		  }
		  m_Cache = this->fields.m_Cache;
		  if ( !m_Cache )
		    goto LABEL_10;
		  descriptor = UnityEngine::RenderTexture::get_descriptor(&v16, m_Cache, 0LL);
		  if ( (_mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&descriptor->_dimension_k__BackingField, 12)) & 1) != 0 )
		  {
		    NumMips = HG::Rendering::Runtime::TextureCache::GetNumMips(
		                (TextureCache *)this,
		                *(_OWORD *)&descriptor->_width_k__BackingField,
		                HIDWORD(*(_QWORD *)&descriptor->_width_k__BackingField),
		                0LL);
		    v7 = 0;
		    if ( NumMips <= 0 )
		      return;
		  }
		  else
		  {
		    NumMips = 1;
		    v7 = 0;
		  }
		  do
		  {
		    v8 = this->fields.m_Cache;
		    sub_1800036A0(TypeInfo::UnityEngine::Graphics);
		    UnityEngine::Graphics::SetRenderTarget(v8, v7, CubemapFace__Enum_Unknown, -1, 0LL);
		    v14 = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(&v15, v9, v10, v11, v13);
		    UnityEngine::GL::Clear(0, 1, (Color *)&v14, 0LL);
		    ++v7;
		  }
		  while ( v7 < NumMips );
		}
		
		public void Release() {} // 0x0000000189B402E4-0x0000000189B40348
		// Void Release()
		void HG::Rendering::Runtime::TextureCache2D::Release(TextureCache2D *this, MethodInfo *method)
		{
		  Object_1 *m_Cache; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(383, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(383, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    m_Cache = (Object_1 *)this->fields.m_Cache;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::Destroy(m_Cache, 0LL);
		  }
		}
		
		internal static long GetApproxCacheSizeInByte(int nbElement, int resolution, int sliceSize) => default; // 0x0000000189B400F0-0x0000000189B40188
		// Int64 GetApproxCacheSizeInByte(Int32, Int32, Int32)
		int64_t HG::Rendering::Runtime::TextureCache2D::GetApproxCacheSizeInByte(
		        int32_t nbElement,
		        int32_t resolution,
		        int32_t sliceSize,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(384, 0LL) )
		    return (unsigned int)(int)(float)((float)((float)(8 * resolution * resolution * nbElement) * 1.33) * (float)sliceSize);
		  Patch = IFix::WrappersManagerImpl::GetPatch(384, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v10, v9);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_182(Patch, nbElement, resolution, sliceSize, 0LL);
		}
		
		internal static int GetMaxCacheSizeForWeightInByte(int weight, int resolution, int sliceSize) => default; // 0x0000000189B40188-0x0000000189B4023C
		// Int32 GetMaxCacheSizeForWeightInByte(Int32, Int32, Int32)
		int32_t HG::Rendering::Runtime::TextureCache2D::GetMaxCacheSizeForWeightInByte(
		        int32_t weight,
		        int32_t resolution,
		        int32_t sliceSize,
		        MethodInfo *method)
		{
		  char v7; // dl
		  __int64 v8; // rcx
		  int v9; // r8d
		  int32_t result; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(385, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(385, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1405(Patch, weight, resolution, sliceSize, 0LL);
		  }
		  else
		  {
		    result = sub_1834464B0(v8, v7, v9);
		    if ( result < 1 )
		    {
		      return 1;
		    }
		    else if ( result > 250 )
		    {
		      return 250;
		    }
		  }
		  return result;
		}
		
		public bool __iFixBaseProxy_IsCreated() => default; // 0x0000000189B40890-0x0000000189B40898
		// Boolean <>iFixBaseProxy_IsCreated()
		bool HG::Rendering::Runtime::TextureCacheCubemap::__iFixBaseProxy_IsCreated(
		        TextureCacheCubemap *this,
		        MethodInfo *method)
		{
		  return HG::Rendering::Runtime::TextureCache::IsCreated((TextureCache *)this, 0LL);
		}
		
	}
}
